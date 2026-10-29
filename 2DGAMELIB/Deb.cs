using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.CSharp.RuntimeBinder;

namespace _2DGAMELIB
{
	public static class Deb
	{
		public static string ToStrings<T>(this T obj)
		{
			if (obj == null)
			{
				return "null";
			}
			Type type = obj.GetType();
			if (type != typeof(string))
			{
				Type[] interfaces = type.GetInterfaces();
				if (interfaces.Any((Type t) => t.Name.Contains("IDictionary")))
				{
					object arg = obj;
					StringBuilder stringBuilder = new StringBuilder();
					stringBuilder.Append("{");
					if (Deb.<>o__0<T>.<>p__9 == null)
					{
						Deb.<>o__0<T>.<>p__9 = CallSite<Func<CallSite, object, IEnumerable>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(IEnumerable), typeof(Deb)));
					}
					Func<CallSite, object, IEnumerable> target = Deb.<>o__0<T>.<>p__9.Target;
					CallSite <>p__ = Deb.<>o__0<T>.<>p__9;
					if (Deb.<>o__0<T>.<>p__0 == null)
					{
						Deb.<>o__0<T>.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "Keys", typeof(Deb), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					foreach (object arg2 in target(<>p__, Deb.<>o__0<T>.<>p__0.Target(Deb.<>o__0<T>.<>p__0, arg)))
					{
						if (Deb.<>o__0<T>.<>p__8 == null)
						{
							Deb.<>o__0<T>.<>p__8 = CallSite<Action<CallSite, StringBuilder, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Append", null, typeof(Deb), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Action<CallSite, StringBuilder, object> target2 = Deb.<>o__0<T>.<>p__8.Target;
						CallSite <>p__2 = Deb.<>o__0<T>.<>p__8;
						StringBuilder arg3 = stringBuilder;
						if (Deb.<>o__0<T>.<>p__7 == null)
						{
							Deb.<>o__0<T>.<>p__7 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Deb), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						Func<CallSite, object, string, object> target3 = Deb.<>o__0<T>.<>p__7.Target;
						CallSite <>p__3 = Deb.<>o__0<T>.<>p__7;
						if (Deb.<>o__0<T>.<>p__6 == null)
						{
							Deb.<>o__0<T>.<>p__6 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Deb), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, object, object, object> target4 = Deb.<>o__0<T>.<>p__6.Target;
						CallSite <>p__4 = Deb.<>o__0<T>.<>p__6;
						if (Deb.<>o__0<T>.<>p__3 == null)
						{
							Deb.<>o__0<T>.<>p__3 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Deb), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						Func<CallSite, object, string, object> target5 = Deb.<>o__0<T>.<>p__3.Target;
						CallSite <>p__5 = Deb.<>o__0<T>.<>p__3;
						if (Deb.<>o__0<T>.<>p__2 == null)
						{
							Deb.<>o__0<T>.<>p__2 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Deb), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, string, object, object> target6 = Deb.<>o__0<T>.<>p__2.Target;
						CallSite <>p__6 = Deb.<>o__0<T>.<>p__2;
						string arg4 = "{ ";
						if (Deb.<>o__0<T>.<>p__1 == null)
						{
							Deb.<>o__0<T>.<>p__1 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToStrings", null, typeof(Deb), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						object arg5 = target5(<>p__5, target6(<>p__6, arg4, Deb.<>o__0<T>.<>p__1.Target(Deb.<>o__0<T>.<>p__1, typeof(Deb), arg2)), " = ");
						if (Deb.<>o__0<T>.<>p__5 == null)
						{
							Deb.<>o__0<T>.<>p__5 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToStrings", null, typeof(Deb), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, Type, object, object> target7 = Deb.<>o__0<T>.<>p__5.Target;
						CallSite <>p__7 = Deb.<>o__0<T>.<>p__5;
						Type typeFromHandle = typeof(Deb);
						if (Deb.<>o__0<T>.<>p__4 == null)
						{
							Deb.<>o__0<T>.<>p__4 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Deb), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						target2(<>p__2, arg3, target3(<>p__3, target4(<>p__4, arg5, target7(<>p__7, typeFromHandle, Deb.<>o__0<T>.<>p__4.Target(Deb.<>o__0<T>.<>p__4, arg, arg2))), " }, "));
					}
					if (stringBuilder.Length > 1)
					{
						stringBuilder.Remove(stringBuilder.Length - 2, 2);
					}
					stringBuilder.Append("}");
					return stringBuilder.ToString();
				}
				if (interfaces.Any((Type t) => t.Name.Contains("IEnumerable")))
				{
					object arg6 = obj;
					StringBuilder stringBuilder2 = new StringBuilder();
					stringBuilder2.Append("{");
					if (Deb.<>o__0<T>.<>p__15 == null)
					{
						Deb.<>o__0<T>.<>p__15 = CallSite<Func<CallSite, object, IEnumerable>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(IEnumerable), typeof(Deb)));
					}
					foreach (object arg7 in Deb.<>o__0<T>.<>p__15.Target(Deb.<>o__0<T>.<>p__15, arg6))
					{
						if (Deb.<>o__0<T>.<>p__11 == null)
						{
							Deb.<>o__0<T>.<>p__11 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Deb), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, object, bool> target8 = Deb.<>o__0<T>.<>p__11.Target;
						CallSite <>p__8 = Deb.<>o__0<T>.<>p__11;
						if (Deb.<>o__0<T>.<>p__10 == null)
						{
							Deb.<>o__0<T>.<>p__10 = CallSite<Func<CallSite, Type, object, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Equals", null, typeof(Deb), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						if (target8(<>p__8, Deb.<>o__0<T>.<>p__10.Target(Deb.<>o__0<T>.<>p__10, typeof(object), arg7, null)))
						{
							stringBuilder2.Append("null, ");
						}
						else
						{
							if (Deb.<>o__0<T>.<>p__14 == null)
							{
								Deb.<>o__0<T>.<>p__14 = CallSite<Action<CallSite, StringBuilder, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Append", null, typeof(Deb), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							Action<CallSite, StringBuilder, object> target9 = Deb.<>o__0<T>.<>p__14.Target;
							CallSite <>p__9 = Deb.<>o__0<T>.<>p__14;
							StringBuilder arg8 = stringBuilder2;
							if (Deb.<>o__0<T>.<>p__13 == null)
							{
								Deb.<>o__0<T>.<>p__13 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Deb), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
								}));
							}
							Func<CallSite, object, string, object> target10 = Deb.<>o__0<T>.<>p__13.Target;
							CallSite <>p__10 = Deb.<>o__0<T>.<>p__13;
							if (Deb.<>o__0<T>.<>p__12 == null)
							{
								Deb.<>o__0<T>.<>p__12 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToStrings", null, typeof(Deb), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							target9(<>p__9, arg8, target10(<>p__10, Deb.<>o__0<T>.<>p__12.Target(Deb.<>o__0<T>.<>p__12, typeof(Deb), arg7), ", "));
						}
					}
					if (stringBuilder2.Length > 1)
					{
						stringBuilder2.Remove(stringBuilder2.Length - 2, 2);
					}
					stringBuilder2.Append("}");
					return stringBuilder2.ToString();
				}
			}
			return obj.ToString();
		}

		public static string Fairing(this string str)
		{
			string text = str;
			if (str.Contains("{{") && str.Contains("}}"))
			{
				int num = 1;
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < str.Length; i++)
				{
					if (str[i] == '{' && str[i + 1] == '{')
					{
						stringBuilder.Append("\t");
						text = text.Insert(num + i, "\r\n" + stringBuilder.ToString());
						num = num + 2 + stringBuilder.Length;
					}
					else if (str[i] == ' ' && str[i - 2] == '}' && str[i + 2] != '}')
					{
						text = text.Insert(num + i, "\r\n" + stringBuilder.ToString());
						num = num + 2 + stringBuilder.Length;
					}
					else if (str[i] == '}' && str[i - 1] == '}')
					{
						if (stringBuilder.Length > 0)
						{
							stringBuilder.Remove(0, 1);
						}
						text = text.Insert(num + i - 1, "\r\n" + stringBuilder.ToString());
						num = num + 2 + stringBuilder.Length;
					}
				}
			}
			else
			{
				text = text.Replace(", ", ", \r\n").Replace("{", "{\r\n").Replace("}", "\r\n}");
			}
			return text;
		}

		public static string ToCRLF(this string src)
		{
			StringReader stringReader = new StringReader(src);
			StringBuilder stringBuilder = new StringBuilder();
			while (stringReader.Peek() >= 0)
			{
				stringBuilder.AppendLine(stringReader.ReadLine());
			}
			if (src.Length > 1 && src[src.Length - 1] == '\n')
			{
				stringBuilder = stringBuilder.Remove(stringBuilder.Length - 2, 2);
			}
			return stringBuilder.ToString();
		}

		public static void TryCatchThrow(this Action a)
		{
			try
			{
				a();
			}
			catch (Exception obj)
			{
				obj.ToConsole();
			}
		}
	}
}
