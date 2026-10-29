using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2DGAMELIB
{
	public static class Oth
	{
		public static void InvokeL(this Control con, Action act)
		{
			con.Invoke(act);
		}

		public static double GetDiagonalLength(this double Width, double Height)
		{
			return Math.Sqrt(Width * Width + Height * Height);
		}

		public static double GetDiagonalLengthSquared(this double Width, double Height)
		{
			return Width * Width + Height * Height;
		}

		public static double GetPriDisDiaLen()
		{
			return ((double)Screen.PrimaryScreen.Bounds.Width).GetDiagonalLength((double)Screen.PrimaryScreen.Bounds.Height);
		}

		public static Color Reverse(this Color c)
		{
			return Color.FromArgb((int)c.A, (int)(byte.MaxValue - c.R), (int)(byte.MaxValue - c.G), (int)(byte.MaxValue - c.B));
		}

		public static Color Reverse(ref Color c)
		{
			return Color.FromArgb((int)c.A, (int)(byte.MaxValue - c.R), (int)(byte.MaxValue - c.G), (int)(byte.MaxValue - c.B));
		}

		public static void GetRandomColor(out Color ret)
		{
			ret = Color.FromArgb(255, OthN.XS.Next(256), OthN.XS.Next(256), OthN.XS.Next(256));
		}

		public static Color GetInter(this Color c1, Color c2)
		{
			return Color.FromArgb((int)((c1.A + c2.A) / 2), (int)((c1.R + c2.R) / 2), (int)((c1.G + c2.G) / 2), (int)((c1.B + c2.B) / 2));
		}

		public static Color GetInter(ref Color c1, ref Color c2)
		{
			return Color.FromArgb((int)((c1.A + c2.A) / 2), (int)((c1.R + c2.R) / 2), (int)((c1.G + c2.G) / 2), (int)((c1.B + c2.B) / 2));
		}

		public static void GetInter(ref Color c1, ref Color c2, out Color ret)
		{
			ret = Color.FromArgb((int)((c1.A + c2.A) / 2), (int)((c1.R + c2.R) / 2), (int)((c1.G + c2.G) / 2), (int)((c1.B + c2.B) / 2));
		}

		public static Vector2D GetRandomVector()
		{
			return new Vector2D(OthN.XS.NextDouble() * (double)(OthN.XS.NextBool() ? 1 : -1), OthN.XS.NextDouble() * (double)(OthN.XS.NextBool() ? 1 : -1));
		}

		public static Color FuncHSV(this Color Color, Func<Hsv, Hsv> Func)
		{
			return Func(new Hsv(ref Color)).GetColor();
		}

		public static Color FuncHSV(ref Color Color, Func<Hsv, Hsv> Func)
		{
			return Func(new Hsv(ref Color)).GetColor();
		}

		public static Rectangle GetRect(this Bitmap Bmp)
		{
			return new Rectangle(0, 0, Bmp.Width, Bmp.Height);
		}

		public static LinearGradientBrush GetLGB(double Unit, Vector2D[] MM, Color Color1, Color Color2)
		{
			return new LinearGradientBrush((MM[0] * Unit * Oth.s0).ToPointF(), (MM[1] * Unit * Oth.s1).ToPointF(), Color1, Color2)
			{
				GammaCorrection = true
			};
		}

		public static LinearGradientBrush GetLGB(double Unit, Vector2D[] MM, ref Color Color1, ref Color Color2)
		{
			return new LinearGradientBrush((MM[0] * Unit * Oth.s0).ToPointF(), (MM[1] * Unit * Oth.s1).ToPointF(), Color1, Color2)
			{
				GammaCorrection = true
			};
		}

		private static void GetMinMaxX(Par Par, ref double MinX, ref double MaxX)
		{
			foreach (Out @out in Par.OP)
			{
				foreach (Vector2D local in @out.ps)
				{
					Vector2D vector2D = Par.ToGlobal(local);
					if (MinX > vector2D.X)
					{
						MinX = vector2D.X;
					}
					else if (MaxX < vector2D.X)
					{
						MaxX = vector2D.X;
					}
				}
			}
		}

		private static void GetMinMaxX(Pars Pars, ref double MinX, ref double MaxX)
		{
			foreach (Par par in Pars.EnumAllPar())
			{
				Oth.GetMinMaxX(par, ref MinX, ref MaxX);
			}
		}

		private static void GetMinMaxX(Par[] Pars, ref double MinX, ref double MaxX)
		{
			for (int i = 0; i < Pars.Length; i++)
			{
				Oth.GetMinMaxX(Pars[i], ref MinX, ref MaxX);
			}
		}

		private static void GetMinMaxY(Par Par, ref double MinY, ref double MaxY)
		{
			foreach (Out @out in Par.OP)
			{
				foreach (Vector2D local in @out.ps)
				{
					Vector2D vector2D = Par.ToGlobal(local);
					if (MinY > vector2D.Y)
					{
						MinY = vector2D.Y;
					}
					else if (MaxY < vector2D.Y)
					{
						MaxY = vector2D.Y;
					}
				}
			}
		}

		private static void GetMinMaxY(Pars Pars, ref double MinY, ref double MaxY)
		{
			foreach (Par par in Pars.EnumAllPar())
			{
				Oth.GetMinMaxY(par, ref MinY, ref MaxY);
			}
		}

		private static void GetMinMaxY(Par[] Pars, ref double MinY, ref double MaxY)
		{
			for (int i = 0; i < Pars.Length; i++)
			{
				Oth.GetMinMaxY(Pars[i], ref MinY, ref MaxY);
			}
		}

		private static void GetMinMaxXY(Par Par, ref double MinX, ref double MinY, ref double MaxX, ref double MaxY)
		{
			foreach (Out @out in Par.OP)
			{
				foreach (Vector2D local in @out.ps)
				{
					Vector2D vector2D = Par.ToGlobal(local);
					if (MinX > vector2D.X)
					{
						MinX = vector2D.X;
					}
					else if (MaxX < vector2D.X)
					{
						MaxX = vector2D.X;
					}
					if (MinY > vector2D.Y)
					{
						MinY = vector2D.Y;
					}
					else if (MaxY < vector2D.Y)
					{
						MaxY = vector2D.Y;
					}
				}
			}
		}

		private static void GetMinMaxXY(Pars Pars, ref double MinX, ref double MinY, ref double MaxX, ref double MaxY)
		{
			foreach (Par par in Pars.EnumAllPar())
			{
				Oth.GetMinMaxXY(par, ref MinX, ref MinY, ref MaxX, ref MaxY);
			}
		}

		private static void GetMinMaxXY(Par[] Pars, ref double MinX, ref double MinY, ref double MaxX, ref double MaxY)
		{
			for (int i = 0; i < Pars.Length; i++)
			{
				Oth.GetMinMaxXY(Pars[i], ref MinX, ref MinY, ref MaxX, ref MaxY);
			}
		}

		public static void GetMiX_MaX(this Par Par, out Vector2D[] MM)
		{
			Vector2D vector2D = Par.ToGlobal(Par.OP.First<Out>().ps.First<Vector2D>());
			MM = new Vector2D[2];
			MM[0].X = vector2D.X;
			MM[1].X = vector2D.X;
			Oth.GetMinMaxX(Par, ref MM[0].X, ref MM[1].X);
		}

		public static void GetMiX_MaX(this Pars Pars, out Vector2D[] MM)
		{
			Par par = Pars.EnumAllPar().First<Par>();
			Vector2D vector2D = par.ToGlobal(par.OP.First<Out>().ps.First<Vector2D>());
			MM = new Vector2D[2];
			MM[0].X = vector2D.X;
			MM[1].X = vector2D.X;
			Oth.GetMinMaxX(Pars, ref MM[0].X, ref MM[1].X);
		}

		public static void GetMiX_MaX(this Par[] Pars, out Vector2D[] MM)
		{
			Par par = Pars.First<Par>();
			Vector2D vector2D = par.ToGlobal(par.OP.First<Out>().ps.First<Vector2D>());
			MM = new Vector2D[2];
			MM[0].X = vector2D.X;
			MM[1].X = vector2D.X;
			Oth.GetMinMaxX(Pars, ref MM[0].X, ref MM[1].X);
		}

		public static void GetMaX_MiX(this Par Par, out Vector2D[] MM)
		{
			Vector2D vector2D = Par.ToGlobal(Par.OP.First<Out>().ps.First<Vector2D>());
			MM = new Vector2D[2];
			MM[0].X = vector2D.X;
			MM[1].X = vector2D.X;
			Oth.GetMinMaxX(Par, ref MM[1].X, ref MM[0].X);
		}

		public static void GetMaX_MiX(this Pars Pars, out Vector2D[] MM)
		{
			Par par = Pars.EnumAllPar().First<Par>();
			Vector2D vector2D = par.ToGlobal(par.OP.First<Out>().ps.First<Vector2D>());
			MM = new Vector2D[2];
			MM[0].X = vector2D.X;
			MM[1].X = vector2D.X;
			Oth.GetMinMaxX(Pars, ref MM[1].X, ref MM[0].X);
		}

		public static void GetMaX_MiX(this Par[] Pars, out Vector2D[] MM)
		{
			Par par = Pars.First<Par>();
			Vector2D vector2D = par.ToGlobal(par.OP.First<Out>().ps.First<Vector2D>());
			MM = new Vector2D[2];
			MM[0].X = vector2D.X;
			MM[1].X = vector2D.X;
			Oth.GetMinMaxX(Pars, ref MM[1].X, ref MM[0].X);
		}

		public static void GetMiY_MaY(this Par Par, out Vector2D[] MM)
		{
			Vector2D vector2D = Par.ToGlobal(Par.OP.First<Out>().ps.First<Vector2D>());
			MM = new Vector2D[2];
			MM[0].Y = vector2D.Y;
			MM[1].Y = vector2D.Y;
			Oth.GetMinMaxY(Par, ref MM[0].Y, ref MM[1].Y);
		}

		public static void GetMiY_MaY(this Pars Pars, out Vector2D[] MM)
		{
			Par par = Pars.EnumAllPar().First<Par>();
			Vector2D vector2D = par.ToGlobal(par.OP.First<Out>().ps.First<Vector2D>());
			MM = new Vector2D[2];
			MM[0].Y = vector2D.Y;
			MM[1].Y = vector2D.Y;
			Oth.GetMinMaxY(Pars, ref MM[0].Y, ref MM[1].Y);
		}

		public static void GetMiY_MaY(this Par[] Pars, out Vector2D[] MM)
		{
			Par par = Pars.First<Par>();
			Vector2D vector2D = par.ToGlobal(par.OP.First<Out>().ps.First<Vector2D>());
			MM = new Vector2D[2];
			MM[0].Y = vector2D.Y;
			MM[1].Y = vector2D.Y;
			Oth.GetMinMaxY(Pars, ref MM[0].Y, ref MM[1].Y);
		}

		public static void GetMaY_MiY(this Par Par, out Vector2D[] MM)
		{
			Vector2D vector2D = Par.ToGlobal(Par.OP.First<Out>().ps.First<Vector2D>());
			MM = new Vector2D[2];
			MM[0].Y = vector2D.Y;
			MM[1].Y = vector2D.Y;
			Oth.GetMinMaxY(Par, ref MM[1].Y, ref MM[0].Y);
		}

		public static void GetMaY_MiY(this Pars Pars, out Vector2D[] MM)
		{
			Par par = Pars.EnumAllPar().First<Par>();
			Vector2D vector2D = par.ToGlobal(par.OP.First<Out>().ps.First<Vector2D>());
			MM = new Vector2D[2];
			MM[0].Y = vector2D.Y;
			MM[1].Y = vector2D.Y;
			Oth.GetMinMaxY(Pars, ref MM[1].Y, ref MM[0].Y);
		}

		public static void GetMaY_MiY(this Par[] Pars, out Vector2D[] MM)
		{
			Par par = Pars.First<Par>();
			Vector2D vector2D = par.ToGlobal(par.OP.First<Out>().ps.First<Vector2D>());
			MM = new Vector2D[2];
			MM[0].Y = vector2D.Y;
			MM[1].Y = vector2D.Y;
			Oth.GetMinMaxY(Pars, ref MM[1].Y, ref MM[0].Y);
		}

		public static void GetMiXMiY_MaXMaY(this Par Par, out Vector2D[] MM)
		{
			Vector2D vector2D = Par.ToGlobal(Par.OP.First<Out>().ps.First<Vector2D>());
			MM = new Vector2D[2];
			MM[0].X = vector2D.X;
			MM[0].Y = vector2D.Y;
			MM[1].X = vector2D.X;
			MM[1].Y = vector2D.Y;
			Oth.GetMinMaxXY(Par, ref MM[0].X, ref MM[0].Y, ref MM[1].X, ref MM[1].Y);
		}

		public static void GetMiXMiY_MaXMaY(this Pars Pars, out Vector2D[] MM)
		{
			Par par = Pars.EnumAllPar().First<Par>();
			Vector2D vector2D = par.ToGlobal(par.OP.First<Out>().ps.First<Vector2D>());
			MM = new Vector2D[2];
			MM[0].X = vector2D.X;
			MM[0].Y = vector2D.Y;
			MM[1].X = vector2D.X;
			MM[1].Y = vector2D.Y;
			Oth.GetMinMaxXY(Pars, ref MM[0].X, ref MM[0].Y, ref MM[1].X, ref MM[1].Y);
		}

		public static void GetMiXMiY_MaXMaY(this Par[] Pars, out Vector2D[] MM)
		{
			Par par = Pars.First<Par>();
			Vector2D vector2D = par.ToGlobal(par.OP.First<Out>().ps.First<Vector2D>());
			MM = new Vector2D[2];
			MM[0].X = vector2D.X;
			MM[0].Y = vector2D.Y;
			MM[1].X = vector2D.X;
			MM[1].Y = vector2D.Y;
			Oth.GetMinMaxXY(Pars, ref MM[0].X, ref MM[0].Y, ref MM[1].X, ref MM[1].Y);
		}

		public static void GetMaXMaY_MiXMiY(this Par Par, out Vector2D[] MM)
		{
			Vector2D vector2D = Par.ToGlobal(Par.OP.First<Out>().ps.First<Vector2D>());
			MM = new Vector2D[2];
			MM[0].X = vector2D.X;
			MM[0].Y = vector2D.Y;
			MM[1].X = vector2D.X;
			MM[1].Y = vector2D.Y;
			Oth.GetMinMaxXY(Par, ref MM[1].X, ref MM[1].Y, ref MM[0].X, ref MM[0].Y);
		}

		public static void GetMaXMaY_MiXMiY(this Pars Pars, out Vector2D[] MM)
		{
			Par par = Pars.EnumAllPar().First<Par>();
			Vector2D vector2D = par.ToGlobal(par.OP.First<Out>().ps.First<Vector2D>());
			MM = new Vector2D[2];
			MM[0].X = vector2D.X;
			MM[0].Y = vector2D.Y;
			MM[1].X = vector2D.X;
			MM[1].Y = vector2D.Y;
			Oth.GetMinMaxXY(Pars, ref MM[1].X, ref MM[1].Y, ref MM[0].X, ref MM[0].Y);
		}

		public static void GetMaXMaY_MiXMiY(this Par[] Pars, out Vector2D[] MM)
		{
			Par par = Pars.First<Par>();
			Vector2D vector2D = par.ToGlobal(par.OP.First<Out>().ps.First<Vector2D>());
			MM = new Vector2D[2];
			MM[0].X = vector2D.X;
			MM[0].Y = vector2D.Y;
			MM[1].X = vector2D.X;
			MM[1].Y = vector2D.Y;
			Oth.GetMinMaxXY(Pars, ref MM[1].X, ref MM[1].Y, ref MM[0].X, ref MM[0].Y);
		}

		public static void GetMiXMaY_MaXMiY(this Par Par, out Vector2D[] MM)
		{
			Vector2D vector2D = Par.ToGlobal(Par.OP.First<Out>().ps.First<Vector2D>());
			MM = new Vector2D[2];
			MM[0].X = vector2D.X;
			MM[0].Y = vector2D.Y;
			MM[1].X = vector2D.X;
			MM[1].Y = vector2D.Y;
			Oth.GetMinMaxXY(Par, ref MM[0].X, ref MM[1].Y, ref MM[1].X, ref MM[0].Y);
		}

		public static void GetMiXMaY_MaXMiY(this Pars Pars, out Vector2D[] MM)
		{
			Par par = Pars.EnumAllPar().First<Par>();
			Vector2D vector2D = par.ToGlobal(par.OP.First<Out>().ps.First<Vector2D>());
			MM = new Vector2D[2];
			MM[0].X = vector2D.X;
			MM[0].Y = vector2D.Y;
			MM[1].X = vector2D.X;
			MM[1].Y = vector2D.Y;
			Oth.GetMinMaxXY(Pars, ref MM[0].X, ref MM[1].Y, ref MM[1].X, ref MM[0].Y);
		}

		public static void GetMiXMaY_MaXMiY(this Par[] Pars, out Vector2D[] MM)
		{
			Par par = Pars.First<Par>();
			Vector2D vector2D = par.ToGlobal(par.OP.First<Out>().ps.First<Vector2D>());
			MM = new Vector2D[2];
			MM[0].X = vector2D.X;
			MM[0].Y = vector2D.Y;
			MM[1].X = vector2D.X;
			MM[1].Y = vector2D.Y;
			Oth.GetMinMaxXY(Pars, ref MM[0].X, ref MM[1].Y, ref MM[1].X, ref MM[0].Y);
		}

		public static void GetMaXMiY_MiXMaY(this Par Par, out Vector2D[] MM)
		{
			Vector2D vector2D = Par.ToGlobal(Par.OP.First<Out>().ps.First<Vector2D>());
			MM = new Vector2D[2];
			MM[0].X = vector2D.X;
			MM[0].Y = vector2D.Y;
			MM[1].X = vector2D.X;
			MM[1].Y = vector2D.Y;
			Oth.GetMinMaxXY(Par, ref MM[1].X, ref MM[0].Y, ref MM[0].X, ref MM[1].Y);
		}

		public static void GetMaXMiY_MiXMaY(this Pars Pars, out Vector2D[] MM)
		{
			Par par = Pars.EnumAllPar().First<Par>();
			Vector2D vector2D = par.ToGlobal(par.OP.First<Out>().ps.First<Vector2D>());
			MM = new Vector2D[2];
			MM[0].X = vector2D.X;
			MM[0].Y = vector2D.Y;
			MM[1].X = vector2D.X;
			MM[1].Y = vector2D.Y;
			Oth.GetMinMaxXY(Pars, ref MM[1].X, ref MM[0].Y, ref MM[0].X, ref MM[1].Y);
		}

		public static void GetMaXMiY_MiXMaY(this Par[] Pars, out Vector2D[] MM)
		{
			Par par = Pars.First<Par>();
			Vector2D vector2D = par.ToGlobal(par.OP.First<Out>().ps.First<Vector2D>());
			MM = new Vector2D[2];
			MM[0].X = vector2D.X;
			MM[0].Y = vector2D.Y;
			MM[1].X = vector2D.X;
			MM[1].Y = vector2D.Y;
			Oth.GetMinMaxXY(Pars, ref MM[1].X, ref MM[0].Y, ref MM[0].X, ref MM[1].Y);
		}

		public static void SaveEx<T>(this T Obj, string Path)
		{
			Obj.ToSerialBytes<T>().GZip().Encrypt(EncClass.AM, "SlaveMatrix_z_@").Save(Path);
		}

		public static T LoadEx<T>(this string Path)
		{
			return Path.Load<byte[]>().Decrypt(EncClass.AM, "SlaveMatrix_z_@").UnGZip().ToDeserialObject<T>();
		}

		public static T LoadEx<T>(this byte[] bd)
		{
			return bd.Load<byte[]>().Decrypt(EncClass.AM, "SlaveMatrix_z_@").UnGZip().ToDeserialObject<T>();
		}

		public static void ObjSave(this Obj Obj, string Path)
		{
			Obj.SaveEx(Path);
		}

		public static Obj ObjLoad(this string Path)
		{
			return Path.LoadEx<Obj>().SetDefaultR();
		}

		public static Obj ObjLoad(this byte[] bd)
		{
			return bd.LoadEx<Obj>().SetDefaultR();
		}

		public static BitmapData GetBitmapDataR(this Bitmap b)
		{
			return b.LockBits(new Rectangle(0, 0, b.Width, b.Height), ImageLockMode.ReadOnly, b.PixelFormat);
		}

		public static BitmapData GetBitmapDataW(this Bitmap b)
		{
			return b.LockBits(new Rectangle(0, 0, b.Width, b.Height), ImageLockMode.WriteOnly, b.PixelFormat);
		}

		public static BitmapData GetBitmapDataRW(this Bitmap b)
		{
			return b.LockBits(new Rectangle(0, 0, b.Width, b.Height), ImageLockMode.ReadWrite, b.PixelFormat);
		}

		public static int Dice(this int n)
		{
			return OthN.XS.Next(n);
		}

		public static bool Lot(this double p)
		{
			return OthN.XS.NextDouble() < p;
		}

		public static IEnumerable<T> Enum<T>(this IEnumerable<T> Enum, Action<T> Acti)
		{
			foreach (T t in Enum)
			{
				Acti(t);
				yield return t;
			}
			IEnumerator<T> enumerator = null;
			yield break;
			yield break;
		}

		public static int GetRandomIndex(params double[] WeightTable)
		{
			double les = WeightTable.Sum();
			double num = OthN.XS.NextDouble(les);
			int result = -1;
			for (int i = 0; i < WeightTable.Length; i++)
			{
				if (WeightTable[i] >= num)
				{
					result = i;
					break;
				}
				num -= WeightTable[i];
			}
			return result;
		}

		public static Encoding GetEncoding(this byte[] Bytes)
		{
			byte[] array;
			if (Bytes.Length > 4000)
			{
				array = new byte[4000];
				Array.Copy(Bytes, array, 4000);
			}
			else
			{
				array = Bytes;
			}
			int num = array.Length;
			bool flag = false;
			for (int i = 0; i < num; i++)
			{
				byte b = array[i];
				if (b <= 6 || b == 127 || b == 255)
				{
					flag = true;
					if (b == 0 && i < num - 1 && array[i + 1] <= 127)
					{
						return Encoding.Unicode;
					}
				}
			}
			if (flag)
			{
				return null;
			}
			bool flag2 = true;
			foreach (byte b2 in array)
			{
				if (b2 == 27 || 128 <= b2)
				{
					flag2 = false;
					break;
				}
			}
			if (flag2)
			{
				return Encoding.ASCII;
			}
			for (int k = 0; k < num - 2; k++)
			{
				byte b = array[k];
				byte b3 = array[k + 1];
				byte b4 = array[k + 2];
				if (b == 27)
				{
					if (b3 == 36 && b4 == 64)
					{
						return Encoding.GetEncoding(50220);
					}
					if (b3 == 36 && b4 == 66)
					{
						return Encoding.GetEncoding(50220);
					}
					if (b3 == 40 && (b4 == 66 || b4 == 74))
					{
						return Encoding.GetEncoding(50220);
					}
					if (b3 == 40 && b4 == 73)
					{
						return Encoding.GetEncoding(50220);
					}
					if (k < num - 3)
					{
						byte b5 = array[k + 3];
						if (b3 == 36 && b4 == 40 && b5 == 68)
						{
							return Encoding.GetEncoding(50220);
						}
						if (k < num - 5 && b3 == 38 && b4 == 64 && b5 == 27 && array[k + 4] == 36 && array[k + 5] == 66)
						{
							return Encoding.GetEncoding(50220);
						}
					}
				}
			}
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			for (int l = 0; l < num - 1; l++)
			{
				byte b = array[l];
				byte b3 = array[l + 1];
				if (((129 <= b && b <= 159) || (224 <= b && b <= 252)) && ((64 <= b3 && b3 <= 126) || (128 <= b3 && b3 <= 252)))
				{
					num2 += 2;
					l++;
				}
			}
			for (int m = 0; m < num - 1; m++)
			{
				byte b = array[m];
				byte b3 = array[m + 1];
				if ((161 <= b && b <= 254 && 161 <= b3 && b3 <= 254) || (b == 142 && 161 <= b3 && b3 <= 223))
				{
					num3 += 2;
					m++;
				}
				else if (m < num - 2)
				{
					byte b4 = array[m + 2];
					if (b == 143 && 161 <= b3 && b3 <= 254 && 161 <= b4 && b4 <= 254)
					{
						num3 += 3;
						m += 2;
					}
				}
			}
			for (int n = 0; n < num - 1; n++)
			{
				byte b = array[n];
				byte b3 = array[n + 1];
				if (192 <= b && b <= 223 && 128 <= b3 && b3 <= 191)
				{
					num4 += 2;
					n++;
				}
				else if (n < num - 2)
				{
					byte b4 = array[n + 2];
					if (224 <= b && b <= 239 && 128 <= b3 && b3 <= 191 && 128 <= b4 && b4 <= 191)
					{
						num4 += 3;
						n += 2;
					}
				}
			}
			if (num3 > num2 && num3 > num4)
			{
				return Encoding.GetEncoding(51932);
			}
			if (num2 > num3 && num2 > num4)
			{
				return Encoding.GetEncoding(932);
			}
			if (num4 > num3 && num4 > num2)
			{
				return Encoding.UTF8;
			}
			return null;
		}

		public static string Join(this IEnumerable<string> strs, string Separator)
		{
			return string.Join(Separator, strs);
		}

		public static string[] Split(this string str, string Separator)
		{
			return str.Split(new string[]
			{
				Separator
			}, StringSplitOptions.None);
		}

		public static void SaveExMod<T>(this T Obj, string Path)
		{
			Obj.ToSerialBytes<T>().Save(Path);
		}

		public static T LoadExMod<T>(this string Path)
		{
			return Path.Load<byte[]>().ToDeserialObject<T>();
		}

		private static double s1 = 1.01;

		private static double s0 = Oth.s1.Reciprocal();
	}
}
