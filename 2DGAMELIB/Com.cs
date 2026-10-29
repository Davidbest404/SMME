using System;
using System.IO;
using System.IO.Compression;

namespace _2DGAMELIB
{
	public static class Com
	{
		public static byte[] GZip(this byte[] Bytes)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (GZipStream gzipStream = new GZipStream(memoryStream, CompressionMode.Compress))
				{
					gzipStream.Write(Bytes, 0, Bytes.Length);
				}
				result = memoryStream.ToArray();
			}
			return result;
		}

		public static void GZipStreaming(this Stream InStream, int Size, Stream OutStream)
		{
			byte[] buffer = new byte[Size];
			try
			{
				try
				{
					using (GZipStream gzipStream = new GZipStream(OutStream, CompressionMode.Compress))
					{
						int count;
						while ((count = InStream.Read(buffer, 0, Size)) > 0)
						{
							gzipStream.Write(buffer, 0, count);
						}
					}
				}
				finally
				{
					if (OutStream != null)
					{
						((IDisposable)OutStream).Dispose();
					}
				}
			}
			finally
			{
				if (InStream != null)
				{
					((IDisposable)InStream).Dispose();
				}
			}
		}

		public static byte[] Deflate(this byte[] Bytes)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (DeflateStream deflateStream = new DeflateStream(memoryStream, CompressionMode.Compress))
				{
					deflateStream.Write(Bytes, 0, Bytes.Length);
				}
				result = memoryStream.ToArray();
			}
			return result;
		}

		public static void DeflateStreaming(this Stream InStream, int Size, Stream OutStream)
		{
			byte[] buffer = new byte[Size];
			try
			{
				try
				{
					using (DeflateStream deflateStream = new DeflateStream(OutStream, CompressionMode.Compress))
					{
						int count;
						while ((count = InStream.Read(buffer, 0, Size)) > 0)
						{
							deflateStream.Write(buffer, 0, count);
						}
					}
				}
				finally
				{
					if (OutStream != null)
					{
						((IDisposable)OutStream).Dispose();
					}
				}
			}
			finally
			{
				if (InStream != null)
				{
					((IDisposable)InStream).Dispose();
				}
			}
		}

		public static byte[] UnGZip(this byte[] Bytes)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream(Bytes))
			{
				using (MemoryStream memoryStream2 = new MemoryStream())
				{
					using (GZipStream gzipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
					{
						gzipStream.CopyTo(memoryStream2);
					}
					result = memoryStream2.ToArray();
				}
			}
			return result;
		}

		public static void UnGZipStreaming(this Stream InStream, int Size, Stream OutStream)
		{
			byte[] buffer = new byte[Size];
			try
			{
				using (GZipStream gzipStream = new GZipStream(InStream, CompressionMode.Decompress))
				{
					try
					{
						int count;
						while ((count = gzipStream.Read(buffer, 0, Size)) > 0)
						{
							OutStream.Write(buffer, 0, count);
						}
					}
					finally
					{
						if (OutStream != null)
						{
							((IDisposable)OutStream).Dispose();
						}
					}
				}
			}
			finally
			{
				if (InStream != null)
				{
					((IDisposable)InStream).Dispose();
				}
			}
		}

		public static byte[] UnDeflate(this byte[] Bytes)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream(Bytes))
			{
				using (MemoryStream memoryStream2 = new MemoryStream())
				{
					using (DeflateStream deflateStream = new DeflateStream(memoryStream, CompressionMode.Decompress))
					{
						deflateStream.CopyTo(memoryStream2);
					}
					result = memoryStream2.ToArray();
				}
			}
			return result;
		}

		public static void UnDeflateStreaming(this Stream InStream, int Size, Stream OutStream)
		{
			byte[] buffer = new byte[Size];
			try
			{
				using (DeflateStream deflateStream = new DeflateStream(InStream, CompressionMode.Decompress))
				{
					try
					{
						int count;
						while ((count = deflateStream.Read(buffer, 0, Size)) > 0)
						{
							OutStream.Write(buffer, 0, count);
						}
					}
					finally
					{
						if (OutStream != null)
						{
							((IDisposable)OutStream).Dispose();
						}
					}
				}
			}
			finally
			{
				if (InStream != null)
				{
					((IDisposable)InStream).Dispose();
				}
			}
		}
	}
}
