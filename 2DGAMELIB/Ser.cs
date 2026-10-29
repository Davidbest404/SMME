using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using Newtonsoft.Json;

namespace _2DGAMELIB
{
	public static class Ser
	{
		public static bool IsSerialize(this Type Type)
		{
			return Attribute.GetCustomAttributes(Type).Contains(Ser.s);
		}

		public static T DeepCopy<T>(this T Object)
		{
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			T result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				binaryFormatter.Serialize(memoryStream, Object);
				memoryStream.Position = 0L;
				result = (T)((object)binaryFormatter.Deserialize(memoryStream));
			}
			return result;
		}

		public static byte[] ToSerialBytes<T>(this T Object)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				new BinaryFormatter().Serialize(memoryStream, Object);
				result = memoryStream.ToArray();
			}
			return result;
		}

		public static Stream ToSerialStream<T>(this T Object)
		{
			MemoryStream memoryStream = new MemoryStream();
			new BinaryFormatter().Serialize(memoryStream, Object);
			return memoryStream;
		}

		public static T ToDeserialObject<T>(this byte[] Bytes)
		{
			T result;
			using (MemoryStream memoryStream = new MemoryStream(Bytes))
			{
				result = (T)((object)new BinaryFormatter().Deserialize(memoryStream));
			}
			return result;
		}

		public static T ToDeserialObject<T>(this Stream Stream)
		{
			T result;
			try
			{
				result = (T)((object)new BinaryFormatter().Deserialize(Stream));
			}
			finally
			{
				if (Stream != null)
				{
					((IDisposable)Stream).Dispose();
				}
			}
			return result;
		}

		public static void Save<T>(this T Object, string Path)
		{
			using (FileStream fileStream = new FileStream(Path, FileMode.Create, FileAccess.Write))
			{
				new BinaryFormatter().Serialize(fileStream, Object);
			}
		}

		public static T Load<T>(this string Path)
		{
			T result;
			using (FileStream fileStream = new FileStream(Path, FileMode.Open, FileAccess.Read))
			{
				result = (T)((object)new BinaryFormatter().Deserialize(fileStream));
			}
			return result;
		}

		public static T Load<T>(this byte[] bd)
		{
			T result;
			using (MemoryStream memoryStream = new MemoryStream(bd))
			{
				result = (T)((object)new BinaryFormatter().Deserialize(memoryStream));
			}
			return result;
		}

		public static void ToXml<T>(this T Object, string Path)
		{
			using (FileStream fileStream = new FileStream(Path, FileMode.Create, FileAccess.Write))
			{
				using (XmlWriter xmlWriter = XmlWriter.Create(fileStream, new XmlWriterSettings
				{
					Indent = true
				}))
				{
					new DataContractSerializer(typeof(T)).WriteObject(xmlWriter, Object);
				}
			}
		}

		public static T FromXml<T>(this string Path)
		{
			T result;
			using (FileStream fileStream = new FileStream(Path, FileMode.Open, FileAccess.Read))
			{
				using (XmlReader xmlReader = XmlReader.Create(fileStream))
				{
					result = (T)((object)new DataContractSerializer(typeof(T)).ReadObject(xmlReader));
				}
			}
			return result;
		}

		public static void ToXml(this object[] Objects, string Path)
		{
			using (FileStream fileStream = new FileStream(Path, FileMode.Create, FileAccess.Write))
			{
				using (XmlWriter xmlWriter = XmlWriter.Create(fileStream, new XmlWriterSettings
				{
					Indent = true
				}))
				{
					new DataContractSerializer(typeof(object[]), from o in Objects
					select o.GetType()).WriteObject(xmlWriter, Objects);
				}
			}
		}

		public static void ToJson<T>(this T Object, string Path)
		{
			using (StreamWriter streamWriter = File.CreateText(Path))
			{
				new JsonSerializer
				{
					PreserveReferencesHandling = PreserveReferencesHandling.Objects,
					TypeNameHandling = TypeNameHandling.All,
					Formatting = Newtonsoft.Json.Formatting.Indented
				}.Serialize(streamWriter, Object);
			}
		}

		public static T UnJson<T>(string Path)
		{
			T result;
			using (StreamReader streamReader = File.OpenText(Path))
			{
				result = (T)((object)new JsonSerializer
				{
					NullValueHandling = NullValueHandling.Ignore,
					TypeNameHandling = TypeNameHandling.All
				}.Deserialize(streamReader, typeof(T)));
			}
			return result;
		}

		private static SerializableAttribute s = new SerializableAttribute();

		[Serializable]
		public struct Data
		{
			public override string ToString()
			{
				return this.Name + " " + this.Value.ToString();
			}

			public string Name;

			[NonSerialized]
			public int Value;

			[NonSerialized]
			public EventHandler Event;
		}

		[DataContract]
		public struct DateXml
		{
			public override string ToString()
			{
				return this.Name + " " + this.Value.ToString();
			}

			[DataMember]
			public string Name;

			[DataMember]
			public int Value;
		}
	}
}
