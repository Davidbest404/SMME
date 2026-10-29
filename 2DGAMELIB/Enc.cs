using System;
using System.IO;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Microsoft.CSharp.RuntimeBinder;

namespace _2DGAMELIB
{
	public static class Enc
	{
		public static byte[] Encrypt(this byte[] Bytes, EncClass EncryptClass, string Password)
		{
			object encryptClass = Enc.GetEncryptClass(EncryptClass);
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(Password, Enc.salt);
			if (Enc.<>o__1.<>p__3 == null)
			{
				Enc.<>o__1.<>p__3 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "Key", typeof(Enc), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, object, object> target = Enc.<>o__1.<>p__3.Target;
			CallSite <>p__ = Enc.<>o__1.<>p__3;
			object arg = encryptClass;
			if (Enc.<>o__1.<>p__2 == null)
			{
				Enc.<>o__1.<>p__2 = CallSite<Func<CallSite, Rfc2898DeriveBytes, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "GetBytes", null, typeof(Enc), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, Rfc2898DeriveBytes, object, object> target2 = Enc.<>o__1.<>p__2.Target;
			CallSite <>p__2 = Enc.<>o__1.<>p__2;
			Rfc2898DeriveBytes arg2 = rfc2898DeriveBytes;
			if (Enc.<>o__1.<>p__1 == null)
			{
				Enc.<>o__1.<>p__1 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Divide, typeof(Enc), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target3 = Enc.<>o__1.<>p__1.Target;
			CallSite <>p__3 = Enc.<>o__1.<>p__1;
			if (Enc.<>o__1.<>p__0 == null)
			{
				Enc.<>o__1.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "KeySize", typeof(Enc), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			target(<>p__, arg, target2(<>p__2, arg2, target3(<>p__3, Enc.<>o__1.<>p__0.Target(Enc.<>o__1.<>p__0, encryptClass), 8)));
			if (Enc.<>o__1.<>p__7 == null)
			{
				Enc.<>o__1.<>p__7 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "IV", typeof(Enc), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, object, object> target4 = Enc.<>o__1.<>p__7.Target;
			CallSite <>p__4 = Enc.<>o__1.<>p__7;
			object arg3 = encryptClass;
			if (Enc.<>o__1.<>p__6 == null)
			{
				Enc.<>o__1.<>p__6 = CallSite<Func<CallSite, Rfc2898DeriveBytes, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "GetBytes", null, typeof(Enc), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, Rfc2898DeriveBytes, object, object> target5 = Enc.<>o__1.<>p__6.Target;
			CallSite <>p__5 = Enc.<>o__1.<>p__6;
			Rfc2898DeriveBytes arg4 = rfc2898DeriveBytes;
			if (Enc.<>o__1.<>p__5 == null)
			{
				Enc.<>o__1.<>p__5 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Divide, typeof(Enc), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target6 = Enc.<>o__1.<>p__5.Target;
			CallSite <>p__6 = Enc.<>o__1.<>p__5;
			if (Enc.<>o__1.<>p__4 == null)
			{
				Enc.<>o__1.<>p__4 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "BlockSize", typeof(Enc), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			target4(<>p__4, arg3, target5(<>p__5, arg4, target6(<>p__6, Enc.<>o__1.<>p__4.Target(Enc.<>o__1.<>p__4, encryptClass), 8)));
			if (Enc.<>o__1.<>p__8 == null)
			{
				Enc.<>o__1.<>p__8 = CallSite<Func<CallSite, object, PaddingMode, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "Padding", typeof(Enc), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Enc.<>o__1.<>p__8.Target(Enc.<>o__1.<>p__8, encryptClass, PaddingMode.Zeros);
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				if (Enc.<>o__1.<>p__10 == null)
				{
					Enc.<>o__1.<>p__10 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "CreateEncryptor", null, typeof(Enc), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				object obj = Enc.<>o__1.<>p__10.Target(Enc.<>o__1.<>p__10, encryptClass);
				if (Enc.<>o__1.<>p__11 == null)
				{
					Enc.<>o__1.<>p__11 = CallSite<Func<CallSite, object, IDisposable>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(IDisposable), typeof(Enc)));
				}
				using (Enc.<>o__1.<>p__11.Target(Enc.<>o__1.<>p__11, obj))
				{
					if (Enc.<>o__1.<>p__9 == null)
					{
						Enc.<>o__1.<>p__9 = CallSite<Func<CallSite, Type, MemoryStream, object, CryptoStreamMode, CryptoStream>>.Create(Binder.InvokeConstructor(CSharpBinderFlags.None, typeof(Enc), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					using (CryptoStream cryptoStream = Enc.<>o__1.<>p__9.Target(Enc.<>o__1.<>p__9, typeof(CryptoStream), memoryStream, obj, CryptoStreamMode.Write))
					{
						cryptoStream.Write(Bytes, 0, Bytes.Length);
						cryptoStream.Close();
						result = memoryStream.ToArray();
					}
				}
			}
			return result;
		}

		public static void EncryptStreaming(this Stream InStream, int Size, EncClass EncryptClass, string Password, Stream OutStream)
		{
			object encryptClass = Enc.GetEncryptClass(EncryptClass);
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(Password, Enc.salt);
			if (Enc.<>o__2.<>p__3 == null)
			{
				Enc.<>o__2.<>p__3 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "Key", typeof(Enc), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, object, object> target = Enc.<>o__2.<>p__3.Target;
			CallSite <>p__ = Enc.<>o__2.<>p__3;
			object arg = encryptClass;
			if (Enc.<>o__2.<>p__2 == null)
			{
				Enc.<>o__2.<>p__2 = CallSite<Func<CallSite, Rfc2898DeriveBytes, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "GetBytes", null, typeof(Enc), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, Rfc2898DeriveBytes, object, object> target2 = Enc.<>o__2.<>p__2.Target;
			CallSite <>p__2 = Enc.<>o__2.<>p__2;
			Rfc2898DeriveBytes arg2 = rfc2898DeriveBytes;
			if (Enc.<>o__2.<>p__1 == null)
			{
				Enc.<>o__2.<>p__1 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Divide, typeof(Enc), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target3 = Enc.<>o__2.<>p__1.Target;
			CallSite <>p__3 = Enc.<>o__2.<>p__1;
			if (Enc.<>o__2.<>p__0 == null)
			{
				Enc.<>o__2.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "KeySize", typeof(Enc), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			target(<>p__, arg, target2(<>p__2, arg2, target3(<>p__3, Enc.<>o__2.<>p__0.Target(Enc.<>o__2.<>p__0, encryptClass), 8)));
			if (Enc.<>o__2.<>p__7 == null)
			{
				Enc.<>o__2.<>p__7 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "IV", typeof(Enc), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, object, object> target4 = Enc.<>o__2.<>p__7.Target;
			CallSite <>p__4 = Enc.<>o__2.<>p__7;
			object arg3 = encryptClass;
			if (Enc.<>o__2.<>p__6 == null)
			{
				Enc.<>o__2.<>p__6 = CallSite<Func<CallSite, Rfc2898DeriveBytes, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "GetBytes", null, typeof(Enc), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, Rfc2898DeriveBytes, object, object> target5 = Enc.<>o__2.<>p__6.Target;
			CallSite <>p__5 = Enc.<>o__2.<>p__6;
			Rfc2898DeriveBytes arg4 = rfc2898DeriveBytes;
			if (Enc.<>o__2.<>p__5 == null)
			{
				Enc.<>o__2.<>p__5 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Divide, typeof(Enc), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target6 = Enc.<>o__2.<>p__5.Target;
			CallSite <>p__6 = Enc.<>o__2.<>p__5;
			if (Enc.<>o__2.<>p__4 == null)
			{
				Enc.<>o__2.<>p__4 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "BlockSize", typeof(Enc), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			target4(<>p__4, arg3, target5(<>p__5, arg4, target6(<>p__6, Enc.<>o__2.<>p__4.Target(Enc.<>o__2.<>p__4, encryptClass), 8)));
			if (Enc.<>o__2.<>p__8 == null)
			{
				Enc.<>o__2.<>p__8 = CallSite<Func<CallSite, object, PaddingMode, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "Padding", typeof(Enc), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Enc.<>o__2.<>p__8.Target(Enc.<>o__2.<>p__8, encryptClass, PaddingMode.Zeros);
			try
			{
				try
				{
					if (Enc.<>o__2.<>p__10 == null)
					{
						Enc.<>o__2.<>p__10 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "CreateEncryptor", null, typeof(Enc), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					object obj = Enc.<>o__2.<>p__10.Target(Enc.<>o__2.<>p__10, encryptClass);
					if (Enc.<>o__2.<>p__11 == null)
					{
						Enc.<>o__2.<>p__11 = CallSite<Func<CallSite, object, IDisposable>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(IDisposable), typeof(Enc)));
					}
					using (Enc.<>o__2.<>p__11.Target(Enc.<>o__2.<>p__11, obj))
					{
						if (Enc.<>o__2.<>p__9 == null)
						{
							Enc.<>o__2.<>p__9 = CallSite<Func<CallSite, Type, Stream, object, CryptoStreamMode, CryptoStream>>.Create(Binder.InvokeConstructor(CSharpBinderFlags.None, typeof(Enc), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						using (CryptoStream cryptoStream = Enc.<>o__2.<>p__9.Target(Enc.<>o__2.<>p__9, typeof(CryptoStream), OutStream, obj, CryptoStreamMode.Write))
						{
							byte[] buffer = new byte[Size];
							int count;
							while ((count = InStream.Read(buffer, 0, Size)) > 0)
							{
								cryptoStream.Write(buffer, 0, count);
							}
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

		public static byte[] Decrypt(this byte[] Bytes, EncClass EncryptClass, string Password)
		{
			object encryptClass = Enc.GetEncryptClass(EncryptClass);
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(Password, Enc.salt);
			if (Enc.<>o__3.<>p__3 == null)
			{
				Enc.<>o__3.<>p__3 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "Key", typeof(Enc), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, object, object> target = Enc.<>o__3.<>p__3.Target;
			CallSite <>p__ = Enc.<>o__3.<>p__3;
			object arg = encryptClass;
			if (Enc.<>o__3.<>p__2 == null)
			{
				Enc.<>o__3.<>p__2 = CallSite<Func<CallSite, Rfc2898DeriveBytes, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "GetBytes", null, typeof(Enc), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, Rfc2898DeriveBytes, object, object> target2 = Enc.<>o__3.<>p__2.Target;
			CallSite <>p__2 = Enc.<>o__3.<>p__2;
			Rfc2898DeriveBytes arg2 = rfc2898DeriveBytes;
			if (Enc.<>o__3.<>p__1 == null)
			{
				Enc.<>o__3.<>p__1 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Divide, typeof(Enc), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target3 = Enc.<>o__3.<>p__1.Target;
			CallSite <>p__3 = Enc.<>o__3.<>p__1;
			if (Enc.<>o__3.<>p__0 == null)
			{
				Enc.<>o__3.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "KeySize", typeof(Enc), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			target(<>p__, arg, target2(<>p__2, arg2, target3(<>p__3, Enc.<>o__3.<>p__0.Target(Enc.<>o__3.<>p__0, encryptClass), 8)));
			if (Enc.<>o__3.<>p__7 == null)
			{
				Enc.<>o__3.<>p__7 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "IV", typeof(Enc), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, object, object> target4 = Enc.<>o__3.<>p__7.Target;
			CallSite <>p__4 = Enc.<>o__3.<>p__7;
			object arg3 = encryptClass;
			if (Enc.<>o__3.<>p__6 == null)
			{
				Enc.<>o__3.<>p__6 = CallSite<Func<CallSite, Rfc2898DeriveBytes, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "GetBytes", null, typeof(Enc), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, Rfc2898DeriveBytes, object, object> target5 = Enc.<>o__3.<>p__6.Target;
			CallSite <>p__5 = Enc.<>o__3.<>p__6;
			Rfc2898DeriveBytes arg4 = rfc2898DeriveBytes;
			if (Enc.<>o__3.<>p__5 == null)
			{
				Enc.<>o__3.<>p__5 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Divide, typeof(Enc), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target6 = Enc.<>o__3.<>p__5.Target;
			CallSite <>p__6 = Enc.<>o__3.<>p__5;
			if (Enc.<>o__3.<>p__4 == null)
			{
				Enc.<>o__3.<>p__4 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "BlockSize", typeof(Enc), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			target4(<>p__4, arg3, target5(<>p__5, arg4, target6(<>p__6, Enc.<>o__3.<>p__4.Target(Enc.<>o__3.<>p__4, encryptClass), 8)));
			if (Enc.<>o__3.<>p__8 == null)
			{
				Enc.<>o__3.<>p__8 = CallSite<Func<CallSite, object, PaddingMode, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "Padding", typeof(Enc), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Enc.<>o__3.<>p__8.Target(Enc.<>o__3.<>p__8, encryptClass, PaddingMode.Zeros);
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				if (Enc.<>o__3.<>p__10 == null)
				{
					Enc.<>o__3.<>p__10 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "CreateDecryptor", null, typeof(Enc), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				object obj = Enc.<>o__3.<>p__10.Target(Enc.<>o__3.<>p__10, encryptClass);
				if (Enc.<>o__3.<>p__11 == null)
				{
					Enc.<>o__3.<>p__11 = CallSite<Func<CallSite, object, IDisposable>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(IDisposable), typeof(Enc)));
				}
				using (Enc.<>o__3.<>p__11.Target(Enc.<>o__3.<>p__11, obj))
				{
					if (Enc.<>o__3.<>p__9 == null)
					{
						Enc.<>o__3.<>p__9 = CallSite<Func<CallSite, Type, MemoryStream, object, CryptoStreamMode, CryptoStream>>.Create(Binder.InvokeConstructor(CSharpBinderFlags.None, typeof(Enc), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					using (CryptoStream cryptoStream = Enc.<>o__3.<>p__9.Target(Enc.<>o__3.<>p__9, typeof(CryptoStream), memoryStream, obj, CryptoStreamMode.Write))
					{
						cryptoStream.Write(Bytes, 0, Bytes.Length);
						cryptoStream.Close();
						result = memoryStream.ToArray();
					}
				}
			}
			return result;
		}

		public static void DecryptStreaming(this Stream InStream, int Size, EncClass EncryptClass, string Password, Stream OutStream)
		{
			object encryptClass = Enc.GetEncryptClass(EncryptClass);
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(Password, Enc.salt);
			if (Enc.<>o__4.<>p__3 == null)
			{
				Enc.<>o__4.<>p__3 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "Key", typeof(Enc), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, object, object> target = Enc.<>o__4.<>p__3.Target;
			CallSite <>p__ = Enc.<>o__4.<>p__3;
			object arg = encryptClass;
			if (Enc.<>o__4.<>p__2 == null)
			{
				Enc.<>o__4.<>p__2 = CallSite<Func<CallSite, Rfc2898DeriveBytes, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "GetBytes", null, typeof(Enc), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, Rfc2898DeriveBytes, object, object> target2 = Enc.<>o__4.<>p__2.Target;
			CallSite <>p__2 = Enc.<>o__4.<>p__2;
			Rfc2898DeriveBytes arg2 = rfc2898DeriveBytes;
			if (Enc.<>o__4.<>p__1 == null)
			{
				Enc.<>o__4.<>p__1 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Divide, typeof(Enc), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target3 = Enc.<>o__4.<>p__1.Target;
			CallSite <>p__3 = Enc.<>o__4.<>p__1;
			if (Enc.<>o__4.<>p__0 == null)
			{
				Enc.<>o__4.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "KeySize", typeof(Enc), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			target(<>p__, arg, target2(<>p__2, arg2, target3(<>p__3, Enc.<>o__4.<>p__0.Target(Enc.<>o__4.<>p__0, encryptClass), 8)));
			if (Enc.<>o__4.<>p__7 == null)
			{
				Enc.<>o__4.<>p__7 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "IV", typeof(Enc), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, object, object> target4 = Enc.<>o__4.<>p__7.Target;
			CallSite <>p__4 = Enc.<>o__4.<>p__7;
			object arg3 = encryptClass;
			if (Enc.<>o__4.<>p__6 == null)
			{
				Enc.<>o__4.<>p__6 = CallSite<Func<CallSite, Rfc2898DeriveBytes, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "GetBytes", null, typeof(Enc), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, Rfc2898DeriveBytes, object, object> target5 = Enc.<>o__4.<>p__6.Target;
			CallSite <>p__5 = Enc.<>o__4.<>p__6;
			Rfc2898DeriveBytes arg4 = rfc2898DeriveBytes;
			if (Enc.<>o__4.<>p__5 == null)
			{
				Enc.<>o__4.<>p__5 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Divide, typeof(Enc), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target6 = Enc.<>o__4.<>p__5.Target;
			CallSite <>p__6 = Enc.<>o__4.<>p__5;
			if (Enc.<>o__4.<>p__4 == null)
			{
				Enc.<>o__4.<>p__4 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "BlockSize", typeof(Enc), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			target4(<>p__4, arg3, target5(<>p__5, arg4, target6(<>p__6, Enc.<>o__4.<>p__4.Target(Enc.<>o__4.<>p__4, encryptClass), 8)));
			if (Enc.<>o__4.<>p__8 == null)
			{
				Enc.<>o__4.<>p__8 = CallSite<Func<CallSite, object, PaddingMode, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "Padding", typeof(Enc), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Enc.<>o__4.<>p__8.Target(Enc.<>o__4.<>p__8, encryptClass, PaddingMode.Zeros);
			try
			{
				try
				{
					if (Enc.<>o__4.<>p__10 == null)
					{
						Enc.<>o__4.<>p__10 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "CreateDecryptor", null, typeof(Enc), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					object obj = Enc.<>o__4.<>p__10.Target(Enc.<>o__4.<>p__10, encryptClass);
					if (Enc.<>o__4.<>p__11 == null)
					{
						Enc.<>o__4.<>p__11 = CallSite<Func<CallSite, object, IDisposable>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(IDisposable), typeof(Enc)));
					}
					using (Enc.<>o__4.<>p__11.Target(Enc.<>o__4.<>p__11, obj))
					{
						if (Enc.<>o__4.<>p__9 == null)
						{
							Enc.<>o__4.<>p__9 = CallSite<Func<CallSite, Type, Stream, object, CryptoStreamMode, CryptoStream>>.Create(Binder.InvokeConstructor(CSharpBinderFlags.None, typeof(Enc), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						using (CryptoStream cryptoStream = Enc.<>o__4.<>p__9.Target(Enc.<>o__4.<>p__9, typeof(CryptoStream), OutStream, obj, CryptoStreamMode.Write))
						{
							byte[] buffer = new byte[Size];
							int count;
							while ((count = InStream.Read(buffer, 0, Size)) > 0)
							{
								cryptoStream.Write(buffer, 0, count);
							}
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

		[return: Dynamic]
		private static dynamic GetEncryptClass(EncClass EncryptClass)
		{
			switch (EncryptClass)
			{
			case EncClass.DESCSP:
				return new DESCryptoServiceProvider();
			case EncClass.RC2CSP:
				return new RC2CryptoServiceProvider();
			case EncClass.TDESCSP:
				return new TripleDESCryptoServiceProvider();
			case EncClass.RM:
				return new RijndaelManaged();
			case EncClass.ACSP:
				return new AesCryptoServiceProvider();
			case EncClass.AM:
				return new AesManaged();
			default:
				return null;
			}
		}

		private static byte[] salt = Encoding.UTF8.GetBytes("saltは必ず8バイト以上");
	}
}
