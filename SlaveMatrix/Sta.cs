using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using SlaveMatrix.Properties;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public static class Sta
	{
		public static void タイル準備()
		{
			Sta.タイル.SetJoints();
			foreach (Par par in Sta.タイル.EnumAllPar())
			{
				par.BrushColor = Col.DarkGray;
				int num;
				par.GetAlpha(out num);
				par.PenColor = Color.FromArgb(num / 2, Col.Black);
				par.Hit = false;
			}
		}

		public static void Disposes()
		{
			Sta.胴体.Dispose();
			Sta.肩左.Dispose();
			Sta.腕左.Dispose();
			Sta.脚左.Dispose();
			Sta.尻尾.Dispose();
			Sta.半身.Dispose();
			Sta.肢左.Dispose();
			Sta.肢中.Dispose();
			Sta.性器.Dispose();
			Sta.性器付.Dispose();
			Sta.スタンプ.Dispose();
			Sta.カ\u30FCソル.Dispose();
			Sta.その他.Dispose();
			Sta.タイル.Dispose();
			Sou.Close();
			Mods.Dispose();
		}

		public static double GetRanAngle(this double MaxAngle)
		{
			return MaxAngle * OthN.XS.NextDouble() * (double)(OthN.XS.NextBool() ? 1 : -1);
		}

		public static T GetEleD<T>(this IEnumerable<EleD> src) where T : EleD
		{
			if (src == null)
			{
				return default(T);
			}
			return (T)((object)src.FirstOrDefault((EleD e) => e is T));
		}

		public static T GetEleD<T>(this IEnumerable<EleD> src, bool 右) where T : EleD
		{
			if (src == null)
			{
				return default(T);
			}
			return (T)((object)src.FirstOrDefault((EleD e) => e is T && e.右 == 右));
		}

		public static T GetEleD<T>(this IEnumerable<EleD> src, Func<T, bool> con) where T : EleD
		{
			if (src == null)
			{
				return default(T);
			}
			return (T)((object)src.FirstOrDefault((EleD e) => e is T && con((T)((object)e))));
		}

		public static IEnumerable<T> GetEleDs<T>(this IEnumerable<EleD> src) where T : EleD
		{
			if (src == null)
			{
				return null;
			}
			return (from e in src
			where e is T
			select e).Cast<T>();
		}

		public static IEnumerable<T> GetEleDs<T>(this IEnumerable<EleD> src, bool 右) where T : EleD
		{
			if (src == null)
			{
				return null;
			}
			return (from e in src
			where e is T && e.右 == 右
			select e).Cast<T>();
		}

		public static IEnumerable<T> GetEleDs<T>(this IEnumerable<EleD> src, Func<T, bool> con) where T : EleD
		{
			if (src == null)
			{
				return null;
			}
			return (from e in src
			where e is T && con((T)((object)e))
			select e).Cast<T>();
		}

		public static void SetEleD<T>(this IEnumerable<EleD> src, Action<T> a) where T : EleD
		{
			T eleD = src.GetEleD<T>();
			if (eleD != null)
			{
				a(eleD);
			}
		}

		public static void SetEleD<T>(this IEnumerable<EleD> src, bool 右, Action<T> a) where T : EleD
		{
			T eleD = src.GetEleD(右);
			if (eleD != null)
			{
				a(eleD);
			}
		}

		public static void SetEleD<T>(this IEnumerable<EleD> src, Func<T, bool> con, Action<T> a) where T : EleD
		{
			T eleD = src.GetEleD(con);
			if (eleD != null)
			{
				a(eleD);
			}
		}

		public static void SetEleDs<T>(this IEnumerable<EleD> src, Action<T> a) where T : EleD
		{
			if (src == null)
			{
				return;
			}
			foreach (T obj in src.GetEleDs<T>())
			{
				a(obj);
			}
		}

		public static void SetEleDs<T>(this IEnumerable<EleD> src, bool 右, Action<T> a) where T : EleD
		{
			if (src == null)
			{
				return;
			}
			foreach (T obj in src.GetEleDs(右))
			{
				a(obj);
			}
		}

		public static void SetEleDs<T>(this IEnumerable<EleD> src, Func<T, bool> con, Action<T> a) where T : EleD
		{
			if (src == null)
			{
				return;
			}
			foreach (T obj in src.GetEleDs(con))
			{
				a(obj);
			}
		}

		public static bool IsEleD<T>(this IEnumerable<EleD> src) where T : EleD
		{
			return src.GetEleD<T>() != null;
		}

		public static bool IsEleD<T>(this IEnumerable<EleD> src, bool 右) where T : EleD
		{
			return src.GetEleD(右) != null;
		}

		public static bool IsEleD<T>(this IEnumerable<EleD> src, Func<T, bool> con) where T : EleD
		{
			return src.GetEleD(con) != null;
		}

		public static void SetValuesD(this EleD e, string s, object value)
		{
			if (e == null)
			{
				return;
			}
			string b = value.GetType().ToString();
			foreach (FieldInfo fieldInfo in e.GetType().GetFields())
			{
				if (fieldInfo.FieldType.ToString() == b && fieldInfo.Name.Contains(s))
				{
					fieldInfo.SetValue(e, value);
				}
			}
		}

		public static void SetValuesD(this IEnumerable<EleD> src, string s, object value)
		{
			if (src == null)
			{
				return;
			}
			string b = value.GetType().ToString();
			foreach (EleD eleD in src)
			{
				foreach (FieldInfo fieldInfo in eleD.GetType().GetFields())
				{
					if (fieldInfo.FieldType.ToString() == b && fieldInfo.Name.Contains(s))
					{
						fieldInfo.SetValue(eleD, value);
					}
				}
			}
		}

		public static void SetValuesD<T>(this IEnumerable<EleD> src, string s, object value) where T : EleD
		{
			if (src == null)
			{
				return;
			}
			string b = value.GetType().ToString();
			foreach (T t in src.GetEleDs<T>())
			{
				foreach (FieldInfo fieldInfo in t.GetType().GetFields())
				{
					if (fieldInfo.FieldType.ToString() == b && fieldInfo.Name.Contains(s))
					{
						fieldInfo.SetValue(t, value);
					}
				}
			}
		}

		public static T GetEleDL<T>(this IEnumerable<EleD> src) where T : EleD
		{
			if (src == null)
			{
				return default(T);
			}
			return (T)((object)src.LastOrDefault((EleD e) => e is T));
		}

		public static T GetEleDL<T>(this IEnumerable<EleD> src, bool 右) where T : EleD
		{
			if (src == null)
			{
				return default(T);
			}
			return (T)((object)src.LastOrDefault((EleD e) => e is T && e.右 == 右));
		}

		public static T GetEleDL<T>(this IEnumerable<EleD> src, Func<T, bool> con) where T : EleD
		{
			if (src == null)
			{
				return default(T);
			}
			return (T)((object)src.LastOrDefault((EleD e) => e is T && con((T)((object)e))));
		}

		public static IEnumerable<T> GetEleDsL<T>(this IEnumerable<EleD> src) where T : EleD
		{
			if (src == null)
			{
				return null;
			}
			return (from e in src
			where e is T
			select e).Cast<T>();
		}

		public static IEnumerable<T> GetEleDsL<T>(this IEnumerable<EleD> src, bool 右) where T : EleD
		{
			if (src == null)
			{
				return null;
			}
			return (from e in src
			where e is T && e.右 == 右
			select e).Cast<T>();
		}

		public static IEnumerable<T> GetEleDsL<T>(this IEnumerable<EleD> src, Func<T, bool> con) where T : EleD
		{
			if (src == null)
			{
				return null;
			}
			return (from e in src
			where e is T && con((T)((object)e))
			select e).Cast<T>();
		}

		public static void SetEleDL<T>(this IEnumerable<EleD> src, Action<T> a) where T : EleD
		{
			T eleDL = src.GetEleDL<T>();
			if (eleDL != null)
			{
				a(eleDL);
			}
		}

		public static void SetEleDL<T>(this IEnumerable<EleD> src, bool 右, Action<T> a) where T : EleD
		{
			T eleDL = src.GetEleDL(右);
			if (eleDL != null)
			{
				a(eleDL);
			}
		}

		public static void SetEleDL<T>(this IEnumerable<EleD> src, Func<T, bool> con, Action<T> a) where T : EleD
		{
			T eleDL = src.GetEleDL(con);
			if (eleDL != null)
			{
				a(eleDL);
			}
		}

		public static void SetEleDsL<T>(this IEnumerable<EleD> src, Action<T> a) where T : EleD
		{
			if (src == null)
			{
				return;
			}
			foreach (T obj in src.GetEleDsL<T>())
			{
				a(obj);
			}
		}

		public static void SetEleDsL<T>(this IEnumerable<EleD> src, bool 右, Action<T> a) where T : EleD
		{
			if (src == null)
			{
				return;
			}
			foreach (T obj in src.GetEleDsL(右))
			{
				a(obj);
			}
		}

		public static void SetEleDsL<T>(this IEnumerable<EleD> src, Func<T, bool> con, Action<T> a) where T : EleD
		{
			if (src == null)
			{
				return;
			}
			foreach (T obj in src.GetEleDsL(con))
			{
				a(obj);
			}
		}

		public static bool IsEleDL<T>(this IEnumerable<EleD> src) where T : EleD
		{
			return src.GetEleDL<T>() != null;
		}

		public static bool IsEleDL<T>(this IEnumerable<EleD> src, bool 右) where T : EleD
		{
			return src.GetEleDL(右) != null;
		}

		public static bool IsEleDL<T>(this IEnumerable<EleD> src, Func<T, bool> con) where T : EleD
		{
			return src.GetEleDL(con) != null;
		}

		public static void SetValuesDL<T>(this IEnumerable<EleD> src, string s, object value) where T : EleD
		{
			if (src == null)
			{
				return;
			}
			string b = value.GetType().ToString();
			foreach (T t in src.GetEleDsL<T>())
			{
				foreach (FieldInfo fieldInfo in t.GetType().GetFields())
				{
					if (fieldInfo.FieldType.ToString() == b && fieldInfo.Name.Contains(s))
					{
						fieldInfo.SetValue(t, value);
					}
				}
			}
		}

		public static T GetEle<T>(this IEnumerable<Ele> src) where T : Ele
		{
			if (src == null)
			{
				return default(T);
			}
			return (T)((object)src.FirstOrDefault((Ele e) => e is T));
		}

		public static T GetEle<T>(this IEnumerable<Ele> src, bool 右) where T : Ele
		{
			if (src == null)
			{
				return default(T);
			}
			return (T)((object)src.FirstOrDefault((Ele e) => e is T && e.右 == 右));
		}

		public static T GetEle<T>(this IEnumerable<Ele> src, Func<T, bool> con) where T : Ele
		{
			if (src == null)
			{
				return default(T);
			}
			return (T)((object)src.FirstOrDefault((Ele e) => e is T && con((T)((object)e))));
		}

		public static IEnumerable<T> GetEles<T>(this IEnumerable<Ele> src) where T : Ele
		{
			if (src == null)
			{
				return null;
			}
			return (from e in src
			where e is T
			select e).Cast<T>();
		}

		public static IEnumerable<T> GetEles<T>(this IEnumerable<Ele> src, bool 右) where T : Ele
		{
			if (src == null)
			{
				return null;
			}
			return (from e in src
			where e is T && e.右 == 右
			select e).Cast<T>();
		}

		public static IEnumerable<T> GetEles<T>(this IEnumerable<Ele> src, Func<T, bool> con) where T : Ele
		{
			if (src == null)
			{
				return null;
			}
			return (from e in src
			where e is T && con((T)((object)e))
			select e).Cast<T>();
		}

		public static void SetEle<T>(this IEnumerable<Ele> src, Action<T> a) where T : Ele
		{
			T ele = src.GetEle<T>();
			if (ele != null)
			{
				a(ele);
			}
		}

		public static void SetEle<T>(this IEnumerable<Ele> src, bool 右, Action<T> a) where T : Ele
		{
			T ele = src.GetEle(右);
			if (ele != null)
			{
				a(ele);
			}
		}

		public static void SetEle<T>(this IEnumerable<Ele> src, Func<T, bool> con, Action<T> a) where T : Ele
		{
			T ele = src.GetEle(con);
			if (ele != null)
			{
				a(ele);
			}
		}

		public static void SetEles<T>(this IEnumerable<Ele> src, Action<T> a) where T : Ele
		{
			if (src == null)
			{
				return;
			}
			foreach (T obj in src.GetEles<T>())
			{
				a(obj);
			}
		}

		public static void SetEles<T>(this IEnumerable<Ele> src, bool 右, Action<T> a) where T : Ele
		{
			if (src == null)
			{
				return;
			}
			foreach (T obj in src.GetEles(右))
			{
				a(obj);
			}
		}

		public static void SetEles<T>(this IEnumerable<Ele> src, Func<T, bool> con, Action<T> a) where T : Ele
		{
			if (src == null)
			{
				return;
			}
			foreach (T obj in src.GetEles(con))
			{
				a(obj);
			}
		}

		public static bool IsEle<T>(this IEnumerable<Ele> src) where T : Ele
		{
			return src.GetEle<T>() != null;
		}

		public static bool IsEle<T>(this IEnumerable<Ele> src, bool 右) where T : Ele
		{
			return src.GetEle(右) != null;
		}

		public static bool IsEle<T>(this IEnumerable<Ele> src, Func<T, bool> con) where T : Ele
		{
			return src.GetEle(con) != null;
		}

		public static void SetValues(this Ele e, string s, object value)
		{
			if (e == null)
			{
				return;
			}
			string b = value.GetType().ToString();
			foreach (PropertyInfo propertyInfo in e.GetType().GetProperties())
			{
				if (propertyInfo.CanWrite && propertyInfo.PropertyType.ToString() == b && propertyInfo.Name.Contains(s))
				{
					propertyInfo.SetValue(e, value, null);
				}
			}
		}

		public static void SetValues(this IEnumerable<Ele> src, string s, object value)
		{
			if (src == null)
			{
				return;
			}
			string b = value.GetType().ToString();
			foreach (Ele ele in src)
			{
				foreach (PropertyInfo propertyInfo in ele.GetType().GetProperties())
				{
					if (propertyInfo.CanWrite && propertyInfo.PropertyType.ToString() == b && propertyInfo.Name.Contains(s))
					{
						propertyInfo.SetValue(ele, value, null);
					}
				}
			}
		}

		public static void SetValues<T>(this IEnumerable<Ele> src, string s, object value) where T : Ele
		{
			if (src == null)
			{
				return;
			}
			string b = value.GetType().ToString();
			foreach (T t in src.GetEles<T>())
			{
				foreach (PropertyInfo propertyInfo in t.GetType().GetProperties())
				{
					if (propertyInfo.CanWrite && propertyInfo.PropertyType.ToString() == b && propertyInfo.Name.Contains(s))
					{
						propertyInfo.SetValue(t, value, null);
					}
				}
			}
		}

		public static T GetEleL<T>(this IEnumerable<Ele> src) where T : Ele
		{
			if (src == null)
			{
				return default(T);
			}
			return (T)((object)src.LastOrDefault((Ele e) => e is T));
		}

		public static T GetEleL<T>(this IEnumerable<Ele> src, bool 右) where T : Ele
		{
			if (src == null)
			{
				return default(T);
			}
			return (T)((object)src.LastOrDefault((Ele e) => e is T && e.右 == 右));
		}

		public static T GetEleL<T>(this IEnumerable<Ele> src, Func<T, bool> con) where T : Ele
		{
			if (src == null)
			{
				return default(T);
			}
			return (T)((object)src.LastOrDefault((Ele e) => e is T && con((T)((object)e))));
		}

		public static IEnumerable<T> GetElesL<T>(this IEnumerable<Ele> src) where T : Ele
		{
			if (src == null)
			{
				return null;
			}
			return (from e in src
			where e is T
			select e).Cast<T>();
		}

		public static IEnumerable<T> GetElesL<T>(this IEnumerable<Ele> src, bool 右) where T : Ele
		{
			if (src == null)
			{
				return null;
			}
			return (from e in src
			where e is T && e.右 == 右
			select e).Cast<T>();
		}

		public static IEnumerable<T> GetElesL<T>(this IEnumerable<Ele> src, Func<T, bool> con) where T : Ele
		{
			if (src == null)
			{
				return null;
			}
			return (from e in src
			where e is T && con((T)((object)e))
			select e).Cast<T>();
		}

		public static void SetEleL<T>(this IEnumerable<Ele> src, Action<T> a) where T : Ele
		{
			T eleL = src.GetEleL<T>();
			if (eleL != null)
			{
				a(eleL);
			}
		}

		public static void SetEleL<T>(this IEnumerable<Ele> src, bool 右, Action<T> a) where T : Ele
		{
			T eleL = src.GetEleL(右);
			if (eleL != null)
			{
				a(eleL);
			}
		}

		public static void SetEleL<T>(this IEnumerable<Ele> src, Func<T, bool> con, Action<T> a) where T : Ele
		{
			T eleL = src.GetEleL(con);
			if (eleL != null)
			{
				a(eleL);
			}
		}

		public static void SetElesL<T>(this IEnumerable<Ele> src, Action<T> a) where T : Ele
		{
			if (src == null)
			{
				return;
			}
			foreach (T obj in src.GetElesL<T>())
			{
				a(obj);
			}
		}

		public static void SetElesL<T>(this IEnumerable<Ele> src, bool 右, Action<T> a) where T : Ele
		{
			if (src == null)
			{
				return;
			}
			foreach (T obj in src.GetElesL(右))
			{
				a(obj);
			}
		}

		public static void SetElesL<T>(this IEnumerable<Ele> src, Func<T, bool> con, Action<T> a) where T : Ele
		{
			if (src == null)
			{
				return;
			}
			foreach (T obj in src.GetElesL(con))
			{
				a(obj);
			}
		}

		public static bool IsEleL<T>(this IEnumerable<Ele> src) where T : Ele
		{
			return src.GetEleL<T>() != null;
		}

		public static bool IsEleL<T>(this IEnumerable<Ele> src, bool 右) where T : Ele
		{
			return src.GetEleL(右) != null;
		}

		public static bool IsEleL<T>(this IEnumerable<Ele> src, Func<T, bool> con) where T : Ele
		{
			return src.GetEleL(con) != null;
		}

		public static void SetValuesL<T>(this IEnumerable<Ele> src, string s, object value) where T : Ele
		{
			if (src == null)
			{
				return;
			}
			string b = value.GetType().ToString();
			foreach (T t in src.GetElesL<T>())
			{
				foreach (PropertyInfo propertyInfo in t.GetType().GetProperties())
				{
					if (propertyInfo.CanWrite && propertyInfo.PropertyType.ToString() == b && propertyInfo.Name.Contains(s))
					{
						propertyInfo.SetValue(t, value, null);
					}
				}
			}
		}

		public static void 描画0(this IEnumerable<Ele> es, Are Are)
		{
			foreach (Ele ele in es)
			{
				ele.描画0(Are);
			}
		}

		public static void 描画1(this IEnumerable<Ele> es, Are Are)
		{
			foreach (Ele ele in es)
			{
				ele.描画1(Are);
			}
		}

		public static void 描画2(this IEnumerable<Ele> es, Are Are)
		{
			foreach (Ele ele in es)
			{
				ele.描画2(Are);
			}
		}

		public static IEnumerable<T> JoinEnum<T>(this IEnumerable<IEnumerable<T>> es)
		{
			foreach (IEnumerable<T> enumerable in es)
			{
				foreach (T t in enumerable)
				{
					yield return t;
				}
				IEnumerator<T> enumerator2 = null;
			}
			IEnumerator<IEnumerable<T>> enumerator = null;
			yield break;
			yield break;
		}

		public static void 配色T(this Ele ele, int i, string s, ref Color2 c1, ref Color2 c2)
		{
			Type type = ele.GetType();
			string ft = typeof(ColorD).ToString();
			int num = 0;
			IEnumerable<FieldInfo> fields = type.GetFields();
			Func<FieldInfo, bool> <>9__0;
			Func<FieldInfo, bool> predicate;
			if ((predicate = <>9__0) == null)
			{
				predicate = (<>9__0 = ((FieldInfo e) => e.FieldType.ToString() == ft && e.Name.Contains(s)));
			}
			foreach (FieldInfo fieldInfo in fields.Where(predicate))
			{
				if (num % 2 == i)
				{
					fieldInfo.SetValue(ele, new ColorD(ref Col.Black, ref c1));
				}
				else
				{
					fieldInfo.SetValue(ele, new ColorD(ref Col.Black, ref c2));
				}
				num++;
			}
		}

		public static bool Is左右無し(this 接続情報 接続情報)
		{
			return Sta.左右無し.Contains(接続情報);
		}

		public static 接続情報 To接続情報(this string s)
		{
			return (接続情報)Enum.Parse(Sta.接続情報t, s);
		}

		public static object GetField(this Type Type, object Object, string Name)
		{
			return Type.GetField(Name, Sta.bf).GetValue(Object);
		}

		public static object GetProperty(this Type Type, object Object, string Name)
		{
			return Type.GetProperty(Name, Sta.bf).GetValue(Object, null);
		}

		public static string ToStringG(this object Object)
		{
			Type type = Object.GetType();
			StringBuilder stringBuilder = new StringBuilder();
			foreach (MemberInfo memberInfo in type.GetMembers())
			{
				string name = memberInfo.Name;
				stringBuilder.Append(name);
				stringBuilder.Append(" = ");
				string text = memberInfo.MemberType.ToString();
				if (text.Equals("Field"))
				{
					stringBuilder.AppendLine(type.GetField(Object, name).ToString());
				}
				else if (text.Equals("Property"))
				{
					stringBuilder.AppendLine(type.GetProperty(Object, name).ToString());
				}
			}
			stringBuilder.Remove(stringBuilder.Length - 2, 2);
			return stringBuilder.ToString();
		}

		public static Color BlendP1(this Color Cd, Color Cs)
		{
			double num = (double)Cd.A / 255.0;
			double num2 = (double)Cs.A / 255.0;
			double num3 = 1.0 - num2;
			double num4 = num2 + num3 * num;
			return Color.FromArgb((int)(255.0 * num4), (int)(((double)Cs.R * num2 + (double)Cd.R * num3 * num) / num4), (int)(((double)Cs.G * num2 + (double)Cd.G * num3 * num) / num4), (int)(((double)Cs.B * num2 + (double)Cd.B * num3 * num) / num4));
		}

		public static Color BlendP1(ref Color Cd, ref Color Cs)
		{
			double num = (double)Cd.A / 255.0;
			double num2 = (double)Cs.A / 255.0;
			double num3 = 1.0 - num2;
			double num4 = num2 + num3 * num;
			return Color.FromArgb((int)(255.0 * num4), (int)(((double)Cs.R * num2 + (double)Cd.R * num3 * num) / num4), (int)(((double)Cs.G * num2 + (double)Cd.G * num3 * num) / num4), (int)(((double)Cs.B * num2 + (double)Cd.B * num3 * num) / num4));
		}

		public static void SetHitFalse(this Ele e)
		{
			foreach (Par par in e.本体.EnumAllPar())
			{
				par.Hit = false;
			}
		}

		public static void SetHitTrue(this Ele e)
		{
			foreach (Par par in e.本体.EnumAllPar())
			{
				par.Hit = true;
			}
		}

		public static void Setting(this Are Are)
		{
			Are.GD.SmoothingMode = SmoothingMode.HighQuality;
			Are.GD.PixelOffsetMode = PixelOffsetMode.HighQuality;
		}

		public static string Numf1(this double n)
		{
			return n.ToString("P1").PadLeft(6);
		}

		public static string Numf2(this double n)
		{
			return n.ToString("P2").PadLeft(7);
		}

		public static string[] SDPaths()
		{
			IEnumerable<string> source = Directory.EnumerateFiles(Sta.SavePath);
			string[] array = new string[10];
			array[0] = source.FirstOrDefault((string e) => e.StartsWith(Sta.SavePath + "\\0： "));
			array[1] = source.FirstOrDefault((string e) => e.StartsWith(Sta.SavePath + "\\1： "));
			array[2] = source.FirstOrDefault((string e) => e.StartsWith(Sta.SavePath + "\\2： "));
			array[3] = source.FirstOrDefault((string e) => e.StartsWith(Sta.SavePath + "\\3： "));
			array[4] = source.FirstOrDefault((string e) => e.StartsWith(Sta.SavePath + "\\4： "));
			array[5] = source.FirstOrDefault((string e) => e.StartsWith(Sta.SavePath + "\\5： "));
			array[6] = source.FirstOrDefault((string e) => e.StartsWith(Sta.SavePath + "\\6： "));
			array[7] = source.FirstOrDefault((string e) => e.StartsWith(Sta.SavePath + "\\7： "));
			array[8] = source.FirstOrDefault((string e) => e.StartsWith(Sta.SavePath + "\\8： "));
			array[9] = source.FirstOrDefault((string e) => e.StartsWith(Sta.SavePath + "\\9： "));
			return array;
		}

		public static void GDSave(int i)
		{
			if (!Sta.EncryptSave)
			{
				Sta.GameData.SaveExMod(string.Concat(new object[]
				{
					Sta.SavePath,
					"\\",
					i,
					"： ",
					Sta.GameData.GetSaveDateString().Replace("/", "_"),
					".sav"
				}));
				return;
			}
			Sta.GameData.SaveEx(string.Concat(new object[]
			{
				Sta.SavePath,
				"\\",
				i,
				"： ",
				Sta.GameData.GetSaveDateString().Replace("/", "_"),
				".sav"
			}));
		}

		public static string GetVal(this List<string[]> t, double v1, double v2)
		{
			int count = t.Count;
			double[] array = new double[count];
			int num = ((int)((double)count * v1)).Limit(0, count);
			for (int i = 0; i < count; i++)
			{
				array[i] = (double)(count - (num - i).Abs());
			}
			num = Oth.GetRandomIndex(array);
			int num2 = ((int)((double)t[num].Length * v2)).Limit(0, t[num].Length);
			return t[num][num2];
		}

		public static List<string[]> パ\u30FCス(this string s)
		{
			List<string[]> list = new List<string[]>();
			foreach (string text in s.Split("\r\n\r\n"))
			{
				if (!string.IsNullOrWhiteSpace(text))
				{
					list.Add((from f in text.Split("\r\n")
					where !string.IsNullOrWhiteSpace(f) && !f.StartsWith("//")
					select f).ToArray<string>());
				}
			}
			return list;
		}

		public static void Set擬音()
		{
			string[] array = Sta.ImiPath.FromText().Split(new char[]
			{
				','
			});
			Sta.口挿 = array[0].パ\u30FCス();
			Sta.口中 = array[1].パ\u30FCス();
			Sta.口抜 = array[2].パ\u30FCス();
			Sta.膣挿 = array[3].パ\u30FCス();
			Sta.膣中 = array[4].パ\u30FCス();
			Sta.膣抜 = array[5].パ\u30FCス();
			Sta.肛挿 = array[6].パ\u30FCス();
			Sta.肛中 = array[7].パ\u30FCス();
			Sta.肛抜 = array[8].パ\u30FCス();
			Sta.糸挿 = array[9].パ\u30FCス();
			Sta.糸中 = array[10].パ\u30FCス();
			Sta.糸抜 = array[11].パ\u30FCス();
			Sta.潮吹 = array[12].パ\u30FCス();
			Sta.放尿 = array[13].パ\u30FCス();
			Sta.くぱ = array[14].パ\u30FCス();
			Sta.吸引 = array[15].パ\u30FCス();
			Sta.吸着 = array[16].パ\u30FCス();
			Sta.吸脱 = array[17].パ\u30FCス();
			Sta.振動 = array[18].パ\u30FCス();
			Sta.鞭振 = array[19].パ\u30FCス();
			Sta.鞭打 = array[20].パ\u30FCス();
			Sta.剃り = array[21].パ\u30FCス();
			Sta.射精 = array[22].パ\u30FCス();
			Sta.処女喪失 = (from f in array[23].Split("\r\n")
			where !string.IsNullOrWhiteSpace(f) && !f.StartsWith("//")
			select f).First<string>();
		}

		public static Vector2D GetAreaPoint(this Vector2D Base, double r)
		{
			double num = r * 0.5;
			double num2 = Base.X - num;
			double num3 = Base.X + num;
			double num4 = Base.Y - num;
			double num5 = Base.Y + num;
			double num6 = num3 - num2;
			double num7 = num5 - num4;
			switch (OthN.XS.Next(7))
			{
			case 0:
				return new Vector2D(OthN.XS.NextDouble(num2 - num6, num2), OthN.XS.NextDouble(num4, num5));
			case 1:
				return new Vector2D(OthN.XS.NextDouble(num2 - num6, num2), OthN.XS.NextDouble(num4, num5));
			case 2:
				return new Vector2D(OthN.XS.NextDouble(num2 - num6, num2), OthN.XS.NextDouble(num5, num5 + num7));
			case 3:
				return new Vector2D(OthN.XS.NextDouble(num2, num3), OthN.XS.NextDouble(num5, num5 + num7));
			case 4:
				return new Vector2D(OthN.XS.NextDouble(num3, num3 + num6), OthN.XS.NextDouble(num5, num5 + num7));
			case 5:
				return new Vector2D(OthN.XS.NextDouble(num3, num3 + num6), OthN.XS.NextDouble(num4, num5));
			case 6:
				return new Vector2D(OthN.XS.NextDouble(num3, num3 + num6), OthN.XS.NextDouble(num4, num5));
			default:
				return Dat.Vec2DZero;
			}
		}

		public static Vector2D GetAreaPoint(ref Vector2D Base, double r)
		{
			double num = r * 0.5;
			double num2 = Base.X - num;
			double num3 = Base.X + num;
			double num4 = Base.Y - num;
			double num5 = Base.Y + num;
			double num6 = num3 - num2;
			double num7 = num5 - num4;
			switch (OthN.XS.Next(7))
			{
			case 0:
				return new Vector2D(OthN.XS.NextDouble(num2 - num6, num2), OthN.XS.NextDouble(num4, num5));
			case 1:
				return new Vector2D(OthN.XS.NextDouble(num2 - num6, num2), OthN.XS.NextDouble(num4, num5));
			case 2:
				return new Vector2D(OthN.XS.NextDouble(num2 - num6, num2), OthN.XS.NextDouble(num5, num5 + num7));
			case 3:
				return new Vector2D(OthN.XS.NextDouble(num2, num3), OthN.XS.NextDouble(num5, num5 + num7));
			case 4:
				return new Vector2D(OthN.XS.NextDouble(num3, num3 + num6), OthN.XS.NextDouble(num5, num5 + num7));
			case 5:
				return new Vector2D(OthN.XS.NextDouble(num3, num3 + num6), OthN.XS.NextDouble(num4, num5));
			case 6:
				return new Vector2D(OthN.XS.NextDouble(num3, num3 + num6), OthN.XS.NextDouble(num4, num5));
			default:
				return Dat.Vec2DZero;
			}
		}

		public static void Set喘ぎ()
		{
			Sta.a = (from f in (Sta.PanPath + "\\a.txt").FromText().Split(new char[]
			{
				','
			})
			select (from g in f.Split("\r\n")
			where !string.IsNullOrWhiteSpace(g) && !g.StartsWith("//")
			select g).ToArray<string>()).ToArray<string[]>();
			Sta.i = (from f in (Sta.PanPath + "\\i.txt").FromText().Split(new char[]
			{
				','
			})
			select (from g in f.Split("\r\n")
			where !string.IsNullOrWhiteSpace(g) && !g.StartsWith("//")
			select g).ToArray<string>()).ToArray<string[]>();
			Sta.u = (from f in (Sta.PanPath + "\\u.txt").FromText().Split(new char[]
			{
				','
			})
			select (from g in f.Split("\r\n")
			where !string.IsNullOrWhiteSpace(g) && !g.StartsWith("//")
			select g).ToArray<string>()).ToArray<string[]>();
			Sta.e = (from f in (Sta.PanPath + "\\e.txt").FromText().Split(new char[]
			{
				','
			})
			select (from g in f.Split("\r\n")
			where !string.IsNullOrWhiteSpace(g) && !g.StartsWith("//")
			select g).ToArray<string>()).ToArray<string[]>();
			Sta.o = (from f in (Sta.PanPath + "\\o.txt").FromText().Split(new char[]
			{
				','
			})
			select (from g in f.Split("\r\n")
			where !string.IsNullOrWhiteSpace(g) && !g.StartsWith("//")
			select g).ToArray<string>()).ToArray<string[]>();
			Sta.n = (from f in (Sta.PanPath + "\\n.txt").FromText().Split(new char[]
			{
				','
			})
			select (from g in f.Split("\r\n")
			where !string.IsNullOrWhiteSpace(g) && !g.StartsWith("//")
			select g).ToArray<string>()).ToArray<string[]>();
			Sta.end = (from g in (Sta.PanPath + "\\end.txt").FromText().Split("\r\n")
			where !g.StartsWith("//")
			select g).ToArray<string>();
		}

		public static void LoadConfig()
		{
			try
			{
				if (!File.Exists(Sta.ConfigPath))
				{
					"SimpleMating:0\r\nComplexMating:0\r\nAutoSort:0\r\nPlayBGM:1\r\nFastText:0\r\nShowFPS:0\r\nBigWindow:0\r\nNoScaling:0\r\nHighQuality:0\r\nAntiAliasing:0\r\nSensesButton:0\r\nFixInfo:0\r\nJsonButton:0\r\nTranslateJson:0\r\nMoveButton:0\r\nStaminaButton:0\r\nEditorButton:0\r\nRefreshStoreEveryTime:0\r\nHumanInStore:0\r\nAlwaysUseName:0\r\nMoveInsectMask:1\r\nWhipScars:0\r\nNoFarting:0\r\nNoPissing:0\r\nEncryptSave:1\r\nDecryptLoad:1".ToText(Sta.ConfigPath, Encoding.Unicode);
				}
				string[] source = Sta.ConfigPath.ReadLines();
				Sta.SimpleMating = (source.First((string e) => e.StartsWith("SimpleMating:")).Last<char>() == '1');
				Sta.ComplexMating = (source.First((string e) => e.StartsWith("ComplexMating:")).Last<char>() == '1');
				Sta.AutoSort = (source.First((string e) => e.StartsWith("AutoSort:")).Last<char>() == '1');
				Sta.PlayBGM = (source.First((string e) => e.StartsWith("PlayBGM:")).Last<char>() == '1');
				Sta.FastText = (source.First((string e) => e.StartsWith("FastText:")).Last<char>() == '1');
				Sta.ShowFPS = (source.First((string e) => e.StartsWith("ShowFPS:")).Last<char>() == '1');
				Sta.BigWindow = (source.First((string e) => e.StartsWith("BigWindow:")).Last<char>() == '1');
				Sta.NoScaling = (source.First((string e) => e.StartsWith("NoScaling:")).Last<char>() == '1');
				Sta.HighQuality = (source.First((string e) => e.StartsWith("HighQuality:")).Last<char>() == '1');
				Sta.AntiAliasing = (source.First((string e) => e.StartsWith("AntiAliasing:")).Last<char>() == '1');
				Sta.SensesButton = (source.First((string e) => e.StartsWith("SensesButton:")).Last<char>() == '1');
				Sta.FixInfo = (source.First((string e) => e.StartsWith("FixInfo:")).Last<char>() == '1');
				Sta.JsonButton = (source.First((string e) => e.StartsWith("JsonButton:")).Last<char>() == '1');
				Sta.TranslateJson = (source.First((string e) => e.StartsWith("TranslateJson:")).Last<char>() == '1');
				Sta.MoveButton = (source.First((string e) => e.StartsWith("MoveButton:")).Last<char>() == '1');
				Sta.StaminaButton = (source.First((string e) => e.StartsWith("StaminaButton:")).Last<char>() == '1');
				Sta.EditorButton = (source.First((string e) => e.StartsWith("EditorButton:")).Last<char>() == '1');
				Sta.RefreshStoreEveryTime = (source.First((string e) => e.StartsWith("RefreshStoreEveryTime:")).Last<char>() == '1');
				Sta.HumanInStore = (source.First((string e) => e.StartsWith("HumanInStore:")).Last<char>() == '1');
				Sta.AlwaysUseName = (source.First((string e) => e.StartsWith("AlwaysUseName:")).Last<char>() == '1');
				Sta.MoveInsectMask = (source.First((string e) => e.StartsWith("MoveInsectMask:")).Last<char>() == '1');
				Sta.WhipScars = (source.First((string e) => e.StartsWith("WhipScars:")).Last<char>() == '1');
				Sta.NoFarting = (source.First((string e) => e.StartsWith("NoFarting:")).Last<char>() == '1');
				Sta.NoPissing = (source.First((string e) => e.StartsWith("NoPissing:")).Last<char>() == '1');
				Sta.EncryptSave = (source.First((string e) => e.StartsWith("EncryptSave:")).Last<char>() == '1');
				Sta.DecryptLoad = (source.First((string e) => e.StartsWith("DecryptLoad:")).Last<char>() == '1');
			}
			catch
			{
				Sta.SimpleMating = false;
				Sta.ComplexMating = false;
				Sta.AutoSort = false;
				Sta.PlayBGM = true;
				Sta.FastText = false;
				Sta.ShowFPS = false;
				Sta.BigWindow = false;
				Sta.NoScaling = false;
				Sta.HighQuality = false;
				Sta.AntiAliasing = false;
				Sta.SensesButton = false;
				Sta.FixInfo = false;
				Sta.JsonButton = false;
				Sta.TranslateJson = false;
				Sta.MoveButton = false;
				Sta.StaminaButton = false;
				Sta.EditorButton = false;
				Sta.RefreshStoreEveryTime = false;
				Sta.HumanInStore = false;
				Sta.AlwaysUseName = false;
				Sta.MoveInsectMask = true;
				Sta.WhipScars = false;
				Sta.NoFarting = false;
				Sta.NoPissing = false;
				Sta.EncryptSave = true;
				Sta.DecryptLoad = true;
			}
			if (!Sta.PlayBGM)
			{
				Sou.OPBGM = new SoundPlayer(Sta.CurrentDirectory + "\\bgm\\doesntexist", true);
				Sou.日常BGM = new SoundPlayer(Sta.CurrentDirectory + "\\bgm\\doesntexist2", true);
			}
		}

		public static void GDSaveJson(int i)
		{
			for (int j = 0; j < Sta.GameData.Gen.Length; j++)
			{
				Sta.GameData.Gen[j].Buf.Clear();
			}
			string path = string.Concat(new object[]
			{
				Sta.JsonSavePath,
				"\\",
				i,
				"： ",
				Sta.GameData.GetSaveDateString().Replace("/", "_"),
				".json"
			});
			Sta.GameData.ToJson(path);
			if (Sta.TranslateJson)
			{
				string sourceFileName = Sta.Translate(path, 0);
				File.Delete(path);
				File.Move(sourceFileName, path);
			}
		}

		public static string[] JSDPaths()
		{
			Sta.JsonSavePath = Sta.CurrentDirectory + "\\save\\json";
			IEnumerable<string> source = Directory.EnumerateFiles(Sta.JsonSavePath);
			string[] array = new string[10];
			array[0] = source.FirstOrDefault((string e) => e.StartsWith(Sta.JsonSavePath + "\\0： "));
			array[1] = source.FirstOrDefault((string e) => e.StartsWith(Sta.JsonSavePath + "\\1： "));
			array[2] = source.FirstOrDefault((string e) => e.StartsWith(Sta.JsonSavePath + "\\2： "));
			array[3] = source.FirstOrDefault((string e) => e.StartsWith(Sta.JsonSavePath + "\\3： "));
			array[4] = source.FirstOrDefault((string e) => e.StartsWith(Sta.JsonSavePath + "\\4： "));
			array[5] = source.FirstOrDefault((string e) => e.StartsWith(Sta.JsonSavePath + "\\5： "));
			array[6] = source.FirstOrDefault((string e) => e.StartsWith(Sta.JsonSavePath + "\\6： "));
			array[7] = source.FirstOrDefault((string e) => e.StartsWith(Sta.JsonSavePath + "\\7： "));
			array[8] = source.FirstOrDefault((string e) => e.StartsWith(Sta.JsonSavePath + "\\8： "));
			array[9] = source.FirstOrDefault((string e) => e.StartsWith(Sta.JsonSavePath + "\\9： "));
			return array;
		}

		public static string Translate(string Path, int Mode)
		{
			Sta.TranslateJsonFile = Sta.CurrentDirectory + "\\text\\Translate.json";
			Sta.TranslateDict = Ser.UnJson<Dictionary<string, string>>(Sta.TranslateJsonFile);
			if (Mode == 1)
			{
				Sta.TranslateDict = Sta.TranslateDict.ToDictionary((KeyValuePair<string, string> x) => x.Value, (KeyValuePair<string, string> x) => x.Key);
			}
			string tempPath = Sta.CurrentDirectory + "\\save\\json\\$temp.json";
			if (new FileInfo(Path).Length >= 80000000L)
			{
				int splitSize = 1000000;
				using (IEnumerator<string> lineIterator = File.ReadLines(Path).GetEnumerator())
				{
					bool stillGoing = true;
					int chunk = 0;
					while (stillGoing)
					{
						using (StreamWriter writer = File.CreateText(tempPath + chunk))
						{
							for (int i = 0; i <= splitSize; i++)
							{
								if (!lineIterator.MoveNext())
								{
									stillGoing = false;
									break;
								}
								writer.WriteLine(lineIterator.Current);
							}
						}
						chunk++;
					}
				}
				string[] files = Directory.GetFiles(Sta.CurrentDirectory + "\\save\\json\\", "$temp.json*");
				foreach (string path in files)
				{
					string text = File.ReadAllText(path);
					text = new Regex("\\\"(.+)\\\"\\:", RegexOptions.Compiled).Replace(text, delegate(Match match)
					{
						if (!Sta.TranslateDict.ContainsKey(match.Groups[1].Value))
						{
							return match.Value;
						}
						return "\"" + Sta.TranslateDict[match.Groups[1].Value] + "\":";
					});
					File.WriteAllText(path, text);
				}
				using (FileStream output = File.Create(tempPath))
				{
					foreach (string file in files)
					{
						using (FileStream input = File.OpenRead(file))
						{
							input.CopyTo(output);
						}
						File.Delete(file);
					}
				}
				return tempPath;
			}
			string text2 = File.ReadAllText(Path);
			text2 = new Regex("\\\"(.+)\\\"\\:", RegexOptions.Compiled).Replace(text2, delegate(Match match)
			{
				if (!Sta.TranslateDict.ContainsKey(match.Groups[1].Value))
				{
					return match.Value;
				}
				return "\"" + Sta.TranslateDict[match.Groups[1].Value] + "\":";
			});
			File.WriteAllText(tempPath, text2);
			return tempPath;
		}

		public static Obj 胴体 = Resources.胴体.ObjLoad();

		public static Obj 肩左 = Resources.肩左.ObjLoad();

		public static Obj 腕左 = Resources.腕左.ObjLoad();

		public static Obj 脚左 = Resources.脚左.ObjLoad();

		public static Obj 尻尾 = Resources.尻尾.ObjLoad();

		public static Obj 半身 = Resources.半身.ObjLoad();

		public static Obj 肢左 = Resources.肢左.ObjLoad();

		public static Obj 肢中 = Resources.肢中.ObjLoad();

		public static Obj 性器 = Resources.性器.ObjLoad();

		public static Obj 性器付 = Resources.性器付.ObjLoad();

		public static Obj スタンプ = Resources.スタンプ.ObjLoad();

		public static Obj カ\u30FCソル = Resources.カ\u30FCソル.ObjLoad();

		public static Obj その他 = Resources.その他.ObjLoad();

		public static Obj タイル = Resources.タイル.ObjLoad();

		public static double MaxAre = 0.0584246154149664;

		public static Type Elet = typeof(Ele);

		public static Type EleDt = typeof(EleD);

		public static Type 胸t = typeof(胸);

		public static Type 肩t = typeof(肩);

		public static Type 胴t = typeof(胴);

		public static Type 腰t = typeof(腰);

		public static Type 尾_鯨t = typeof(尾_鯨);

		public static Type 上腕_人t = typeof(上腕_人);

		public static Type 上腕_鳥t = typeof(上腕_鳥);

		public static Type 長物_鯨t = typeof(長物_鯨);

		public static Type 後髪0_ジグDt = typeof(後髪0_ジグD);

		public static Type 後髪0_ハネDt = typeof(後髪0_ハネD);

		public static Type 後髪0_パツDt = typeof(後髪0_パツD);

		public static Type 後髪0_カルDt = typeof(後髪0_カルD);

		public static Type 後髪0_肢系Dt = typeof(後髪0_肢系D);

		public static Type 耳_人Dt = typeof(耳_人D);

		public static Type 耳_尖Dt = typeof(耳_尖D);

		public static Type 耳_長Dt = typeof(耳_長D);

		public static Type 耳_鰭Dt = typeof(耳_鰭D);

		public static Type 耳_羽Dt = typeof(耳_羽D);

		public static Type 耳_獣Dt = typeof(耳_獣D);

		public static Type 肩Dt = typeof(肩D);

		public static Type 角1_一Dt = typeof(角1_一D);

		public static Type 角1_鬼Dt = typeof(角1_鬼D);

		public static Type 角1_虫Dt = typeof(角1_虫D);

		public static Type 角2_山1Dt = typeof(角2_山1D);

		public static Type 角2_山2Dt = typeof(角2_山2D);

		public static Type 角2_山3Dt = typeof(角2_山3D);

		public static Type 角2_巻Dt = typeof(角2_巻D);

		public static Type 角2_牛1Dt = typeof(角2_牛1D);

		public static Type 角2_牛2Dt = typeof(角2_牛2D);

		public static Type 角2_牛3Dt = typeof(角2_牛3D);

		public static Type 角2_牛4Dt = typeof(角2_牛4D);

		public static Type 角2_鬼Dt = typeof(角2_鬼D);

		public static Type 角2_虫Dt = typeof(角2_虫D);

		public static Type 花_薔Dt = typeof(花_薔D);

		public static Type 花_百Dt = typeof(花_百D);

		public static Type 顔面_甲Dt = typeof(顔面_甲D);

		public static Type 顔面_虫Dt = typeof(顔面_虫D);

		public static Type 顔面_蟲Dt = typeof(顔面_蟲D);

		public static Type 頭頂_宇Dt = typeof(頭頂_宇D);

		public static Type 頭頂_皿Dt = typeof(頭頂_皿D);

		public static Type 頭頂_天Dt = typeof(頭頂_天D);

		public static Type 頭頂後_宇Dt = typeof(頭頂後_宇D);

		public static Type 背中_羽Dt = typeof(背中_羽D);

		public static Type 背中_甲Dt = typeof(背中_甲D);

		public static Type 背中_光Dt = typeof(背中_光D);

		public static Type 触覚_線Dt = typeof(触覚_線D);

		public static Type 触覚_節Dt = typeof(触覚_節D);

		public static Type 触覚_甲Dt = typeof(触覚_甲D);

		public static Type 触覚_蝶Dt = typeof(触覚_蝶D);

		public static Type 触覚_蛾Dt = typeof(触覚_蛾D);

		public static Type 触覚_蠍Dt = typeof(触覚_蠍D);

		public static Type 尾_猫Dt = typeof(尾_猫D);

		public static Type 尾_犬Dt = typeof(尾_犬D);

		public static Type 尾_狐Dt = typeof(尾_狐D);

		public static Type 尾_馬Dt = typeof(尾_馬D);

		public static Type 尾_牛Dt = typeof(尾_牛D);

		public static Type 尾_龍Dt = typeof(尾_龍D);

		public static Type 尾_竜Dt = typeof(尾_竜D);

		public static Type 尾_悪Dt = typeof(尾_悪D);

		public static Type 尾_淫Dt = typeof(尾_淫D);

		public static Type 尾_鳥Dt = typeof(尾_鳥D);

		public static Type 尾_虫Dt = typeof(尾_虫D);

		public static Type 尾_蜘Dt = typeof(尾_蜘D);

		public static Type 尾_蠍Dt = typeof(尾_蠍D);

		public static Type 尾_蛇Dt = typeof(尾_蛇D);

		public static Type 尾_腓Dt = typeof(尾_腓D);

		public static Type 尾_短Dt = typeof(尾_短D);

		public static Type 尾_ヘDt = typeof(尾_ヘD);

		public static Type 尾_ガDt = typeof(尾_ガD);

		public static Type 尾_ウDt = typeof(尾_ウD);

		public static Type 尾_魚Dt = typeof(尾_魚D);

		public static Type 尾_鯨Dt = typeof(尾_鯨D);

		public static Type 尾_蟲Dt = typeof(尾_蟲D);

		public static Type 尾_根Dt = typeof(尾_根D);

		public static Type 尾鰭_魚Dt = typeof(尾鰭_魚D);

		public static Type 尾鰭_鯨Dt = typeof(尾鰭_鯨D);

		public static Type 鰭_魚Dt = typeof(鰭_魚D);

		public static Type 鰭_豚Dt = typeof(鰭_豚D);

		public static Type 鰭_鯨Dt = typeof(鰭_鯨D);

		public static Type 葉_披Dt = typeof(葉_披D);

		public static Type 葉_心Dt = typeof(葉_心D);

		public static Type 前翅_甲Dt = typeof(前翅_甲D);

		public static Type 前翅_羽Dt = typeof(前翅_羽D);

		public static Type 前翅_蝶Dt = typeof(前翅_蝶D);

		public static Type 前翅_草Dt = typeof(前翅_草D);

		public static Type 後翅_甲Dt = typeof(後翅_甲D);

		public static Type 後翅_羽Dt = typeof(後翅_羽D);

		public static Type 後翅_蝶Dt = typeof(後翅_蝶D);

		public static Type 後翅_草Dt = typeof(後翅_草D);

		public static Type 触肢_肢蜘Dt = typeof(触肢_肢蜘D);

		public static Type 触肢_肢蠍Dt = typeof(触肢_肢蠍D);

		public static Type 節足_足蜘Dt = typeof(節足_足蜘D);

		public static Type 節足_足蠍Dt = typeof(節足_足蠍D);

		public static Type 節足_足百Dt = typeof(節足_足百D);

		public static Type 節尾_曳航Dt = typeof(節尾_曳航D);

		public static Type 節尾_鋏Dt = typeof(節尾_鋏D);

		public static Type 触手_軟Dt = typeof(触手_軟D);

		public static Type 触手_触Dt = typeof(触手_触D);

		public static Type 触手_犬Dt = typeof(触手_犬D);

		public static Type 触手_蔦Dt = typeof(触手_蔦D);

		public static Type 上腕_人Dt = typeof(上腕_人D);

		public static Type 上腕_鳥Dt = typeof(上腕_鳥D);

		public static Type 上腕_蝙Dt = typeof(上腕_蝙D);

		public static Type 上腕_獣Dt = typeof(上腕_獣D);

		public static Type 上腕_蹄Dt = typeof(上腕_蹄D);

		public static Type 下腕_人Dt = typeof(下腕_人D);

		public static Type 下腕_鳥Dt = typeof(下腕_鳥D);

		public static Type 下腕_蝙Dt = typeof(下腕_蝙D);

		public static Type 獣下腕Dt = typeof(獣下腕D);

		public static Type 下腕_獣Dt = typeof(下腕_獣D);

		public static Type 下腕_蹄Dt = typeof(下腕_蹄D);

		public static Type 手_人Dt = typeof(手_人D);

		public static Type 手_鳥Dt = typeof(手_鳥D);

		public static Type 手_蝙Dt = typeof(手_蝙D);

		public static Type 手_獣Dt = typeof(手_獣D);

		public static Type 手_馬Dt = typeof(手_馬D);

		public static Type 手_牛Dt = typeof(手_牛D);

		public static Type 腿_人Dt = typeof(腿_人D);

		public static Type 腿_獣Dt = typeof(腿_獣D);

		public static Type 腿_蹄Dt = typeof(腿_蹄D);

		public static Type 腿_鳥Dt = typeof(腿_鳥D);

		public static Type 腿_竜Dt = typeof(腿_竜D);

		public static Type 脚_人Dt = typeof(脚_人D);

		public static Type 脚_獣Dt = typeof(脚_獣D);

		public static Type 脚_蹄Dt = typeof(脚_蹄D);

		public static Type 脚_鳥Dt = typeof(脚_鳥D);

		public static Type 脚_竜Dt = typeof(脚_竜D);

		public static Type 足_人Dt = typeof(足_人D);

		public static Type 足_獣Dt = typeof(足_獣D);

		public static Type 足_馬Dt = typeof(足_馬D);

		public static Type 足_牛Dt = typeof(足_牛D);

		public static Type 足_鳥Dt = typeof(足_鳥D);

		public static Type 足_竜Dt = typeof(足_竜D);

		public static Type 四足脇Dt = typeof(四足脇D);

		public static Type 胴_蛇Dt = typeof(胴_蛇D);

		public static Type 胴_蟲Dt = typeof(胴_蟲D);

		public static Type 大顎基Dt = typeof(大顎基D);

		public static Type 鳳凰Dt = typeof(鳳凰D);

		public static Type 大顎Dt = typeof(大顎D);

		public static Type 虫顎Dt = typeof(虫顎D);

		public static Type 虫鎌Dt = typeof(虫鎌D);

		public static Type 獣耳Dt = typeof(獣耳D);

		public static Type 植Dt = typeof(植D);

		public static string 拘束鎖t = typeof(拘束鎖).ToString();

		public static string lt = typeof(List<EleD>).ToString();

		public static string at = typeof(Ele[]).ToString();

		public static string cdt = typeof(ColorD).ToString();

		public static string cpt = typeof(ColorP).ToString();

		public static Type Bodt = typeof(Bod);

		public static string dt = typeof(double).ToString();

		public static string bt = typeof(bool).ToString();

		public static string ct = typeof(Color).ToString();

		private static HashSet<接続情報> 左右無し = new HashSet<接続情報>(new 接続情報[]
		{
			接続情報.none,
			接続情報.頭_基髪_接続,
			接続情報.頭_鼻_接続,
			接続情報.頭_口_接続,
			接続情報.頭_額_接続,
			接続情報.頭_鼻肌_接続,
			接続情報.頭_単眼目_接続,
			接続情報.頭_単眼眉_接続,
			接続情報.頭_大顎基_接続,
			接続情報.頭_顔面_接続,
			接続情報.頭_頭頂_接続,
			接続情報.基髪_前髪_接続,
			接続情報.基髪_後髪_接続,
			接続情報.後髪0_肢系_中央_接続,
			接続情報.単目_瞼_接続,
			接続情報.縦目_瞼_接続,
			接続情報.吹出し_吹出し_接続,
			接続情報.首_頭_接続,
			接続情報.胸_首_接続,
			接続情報.胸_肌_接続,
			接続情報.胸_背中_接続,
			接続情報.胴_胸_接続,
			接続情報.胴_肌_接続,
			接続情報.腰_胴_接続,
			接続情報.腰_肌_接続,
			接続情報.腰_膣基_接続,
			接続情報.腰_肛門_接続,
			接続情報.腰_尾_接続,
			接続情報.腰_半身_接続,
			接続情報.腰_上着_接続,
			接続情報.ボテ腹_人_腹板_接続,
			接続情報.ボテ腹_獣_腹板_接続,
			接続情報.肛門_人_肛門精液_接続,
			接続情報.肛門_獣_肛門精液_接続,
			接続情報.性器_人_陰核_接続,
			接続情報.性器_人_尿道_接続,
			接続情報.性器_人_膣口_接続,
			接続情報.性器_獣_陰核_接続,
			接続情報.性器_獣_尿道_接続,
			接続情報.性器_獣_膣口_接続,
			接続情報.上着ボトム_クロス_上着ボトム後_接続,
			接続情報.頭頂_宇_頭部後_接続,
			接続情報.尾_ヘ_尾先_接続,
			接続情報.尾_ウ_尾先_接続,
			接続情報.尾_魚_尾先_接続,
			接続情報.尾_鯨_尾先_接続,
			接続情報.長物_魚_尾_接続,
			接続情報.長物_鯨_尾_接続,
			接続情報.長物_蛇_胴_接続,
			接続情報.長物_蟲_胴_接続,
			接続情報.四足胸_胴_接続,
			接続情報.四足胸_肌_接続,
			接続情報.四足胸_背中_接続,
			接続情報.四足胴_腰_接続,
			接続情報.四足胴_肌_接続,
			接続情報.四足腰_膣基_接続,
			接続情報.四足腰_肛門_接続,
			接続情報.四足腰_尾_接続,
			接続情報.四足腰_半身_接続,
			接続情報.四足腰_上着_接続,
			接続情報.四足腰_肌_接続,
			接続情報.多足_蜘_尾_接続,
			接続情報.多足_蠍_尾_接続,
			接続情報.単足_植_根中央_接続,
			接続情報.胴_蛇_胴_接続,
			接続情報.胴_蟲_胴_接続,
			接続情報.ペニス_尿道_接続
		});

		private static Type 接続情報t = typeof(接続情報);

		private static BindingFlags bf = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

		private static BindingFlags bfi = Sta.bf | BindingFlags.InvokeMethod;

		public static 髪留2情報 髪留2初期化 = default(髪留2情報);

		public static 玉口枷情報 玉口枷初期化 = default(玉口枷情報);

		public static 目隠帯情報 目隠帯初期化 = default(目隠帯情報);

		public static 拘束具情報 拘束具初期化 = default(拘束具情報);

		public static ピアス情報 ピアス初期化 = default(ピアス情報);

		public static キャップ情報 キャップ初期化 = default(キャップ情報);

		public static ドレス首情報 ドレス首初期化 = default(ドレス首情報);

		public static 下着T_チュ\u30FCブ情報 下着T_チュ\u30FCブ初期化 = default(下着T_チュ\u30FCブ情報);

		public static 下着T_クロス情報 下着T_クロス初期化 = default(下着T_クロス情報);

		public static 下着T_ビキニ情報 下着T_ビキニ初期化 = default(下着T_ビキニ情報);

		public static 下着T_マイクロ情報 下着T_マイクロ初期化 = default(下着T_マイクロ情報);

		public static 下着T_ブラ情報 下着T_ブラ初期化 = default(下着T_ブラ情報);

		public static 下着B_ノ\u30FCマル情報 下着B_ノ\u30FCマル初期化 = default(下着B_ノ\u30FCマル情報);

		public static 下着B_マイクロ情報 下着B_マイクロ初期化 = default(下着B_マイクロ情報);

		public static ドレス情報 ドレス初期化 = default(ドレス情報);

		public static 上着B_クロス情報 上着B_クロス初期化 = default(上着B_クロス情報);

		public static 上着B_前掛け情報 上着B_前掛け初期化 = default(上着B_前掛け情報);

		public static ブ\u30FCツ情報 ブ\u30FCツ初期化 = default(ブ\u30FCツ情報);

		public static string CurrentDirectory = Directory.GetCurrentDirectory();

		public static GameState GameData = new GameState();

		public static string SavePath = Sta.CurrentDirectory + "\\save";

		public static string ImiPath = Sta.CurrentDirectory + "\\text\\Basement\\Training\\Imitation.txt";

		public static List<string[]> 口挿;

		public static List<string[]> 口中;

		public static List<string[]> 口抜;

		public static List<string[]> 膣挿;

		public static List<string[]> 膣中;

		public static List<string[]> 膣抜;

		public static List<string[]> 肛挿;

		public static List<string[]> 肛中;

		public static List<string[]> 肛抜;

		public static List<string[]> 糸挿;

		public static List<string[]> 糸中;

		public static List<string[]> 糸抜;

		public static List<string[]> 潮吹;

		public static List<string[]> 放尿;

		public static List<string[]> くぱ;

		public static List<string[]> 吸引;

		public static List<string[]> 吸着;

		public static List<string[]> 吸脱;

		public static List<string[]> 振動;

		public static List<string[]> 鞭振;

		public static List<string[]> 鞭打;

		public static List<string[]> 剃り;

		public static List<string[]> 射精;

		public static string 処女喪失;

		public static string PanPath = Sta.CurrentDirectory + "\\text\\Basement\\Training\\Pant";

		public static string[][] a;

		public static string[][] i;

		public static string[][] u;

		public static string[][] e;

		public static string[][] o;

		public static string[][] n;

		public static string[] end;

		public static ParallelOptions po3 = new ParallelOptions
		{
			MaxDegreeOfParallelism = 3
		};

		public static string ConfigPath = Sta.CurrentDirectory + "\\Config.ini";

		public static bool SimpleMating = false;

		public static bool AutoSort = false;

		public static bool PlayBGM = true;

		public static bool BigWindow = false;

		public static bool HighQuality = false;

		public static bool SensesButton = false;

		public static bool FixInfo = false;

		public static bool JsonButton = false;

		public static bool RefreshStoreEveryTime = false;

		public static bool EncryptSave = true;

		public static bool DecryptLoad = true;

		public static string JsonSavePath;

		public static bool DontScar = false;

		public static bool FastText = false;

		public static bool AntiAliasing = false;

		public static bool TranslateJson = false;

		public static string TranslateJsonFile;

		public static Dictionary<string, string> TranslateDict;

		public static bool ShowFPS = false;

		public static bool MoveButton = false;

		public static bool StaminaButton = false;

		public static bool AlwaysUseName = false;

		public static bool MoveInsectMask = true;

		public static bool EditorButton = false;

		public static bool WhipScars = false;

		public static bool HumanInStore = false;

		public static bool NoFarting = false;

		public static bool NoPissing = false;

		public static bool NoScaling = false;

		public static bool ComplexMating = false;
	}
}
