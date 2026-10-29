using System;
using System.IO;
using System.Text;

namespace _2DGAMELIB
{
	public static class Text
	{
		public static void ToText(this string str, string Path, Encoding Encoding)
		{
			using (StreamWriter streamWriter = new StreamWriter(Path, false, Encoding))
			{
				streamWriter.Write(str);
			}
		}

		public static string FromText(this string Path, Encoding Encoding)
		{
			string result;
			using (StreamReader streamReader = new StreamReader(Path, Encoding))
			{
				result = streamReader.ReadToEnd();
			}
			return result;
		}

		public static void ToWriteLast(this string Path, Encoding Encoding, string str)
		{
			using (StreamWriter streamWriter = new StreamWriter(Path, true, Encoding))
			{
				streamWriter.Write(str);
			}
		}

		public static void ToWriteFirst(this string Path, Encoding Encoding, string str)
		{
			(str + Path.FromText(Encoding)).ToText(Path, Encoding);
		}

		public static string FromRead(this string Path, Encoding Encoding, int Start, int Count)
		{
			int num = 0;
			using (StreamReader streamReader = new StreamReader(Path, Encoding))
			{
				while (streamReader.Peek() > -1)
				{
					if (num == Start)
					{
						StringBuilder stringBuilder = new StringBuilder();
						for (int i = 0; i < Count; i++)
						{
							stringBuilder.AppendLine(streamReader.ReadLine());
						}
						return stringBuilder.ToString();
					}
					streamReader.ReadLine();
					num++;
				}
			}
			return null;
		}

		public static string FromText(this string Path)
		{
			string result;
			using (FileStream fileStream = new FileStream(Path, FileMode.Open, FileAccess.Read))
			{
				byte[] array = new byte[fileStream.Length];
				fileStream.Read(array, 0, array.Length);
				using (StreamReader streamReader = new StreamReader(new MemoryStream(array), array.GetEncoding()))
				{
					result = streamReader.ReadToEnd();
				}
			}
			return result;
		}

		public static string[] ReadLines(this string Path, Encoding Encoding)
		{
			return Path.FromText(Encoding).Replace("\r", "").Split(new char[]
			{
				'\n'
			});
		}

		public static string[] ReadLines(this string Path)
		{
			return Path.FromText().Replace("\r", "").Split(new char[]
			{
				'\n'
			});
		}
	}
}
