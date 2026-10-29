using System;
using System.Drawing;

namespace _2DGAMELIB
{
	public static class HSV
	{
		public static void ToHSV(int r, int g, int b, out int h, out int s, out int v)
		{
			v = HSV.GetMax(r, g, b);
			int num = v - HSV.GetMin(r, g, b);
			if (num == 0)
			{
				s = 0;
			}
			else
			{
				s = (int)((double)(num * 255) / (double)v);
			}
			if (s == 0)
			{
				h = 0;
				return;
			}
			double num2 = (double)num;
			if (r == v)
			{
				h = v - (int)((double)(b * 60) / num2) - (v - (int)((double)(g * 60) / num2));
			}
			else if (g == v)
			{
				h = 120 + (v - (int)((double)(r * 60) / num2)) - (v - (int)((double)(b * 60) / num2));
			}
			else
			{
				h = 240 + (v - (int)((double)(g * 60) / num2)) - (v - (int)((double)(r * 60) / num2));
			}
			if (h < 0)
			{
				h += 360;
			}
		}

		public static void ToRGB(int h, int s, int v, out int r, out int g, out int b)
		{
			if (s == 0)
			{
				b = v;
				g = v;
				r = v;
				return;
			}
			int num = h * 6;
			switch (num / 360)
			{
			case 0:
				r = v;
				g = (int)((double)(v * (255 - (int)((double)(s * (360 - num % 360)) / 360.0))) / 255.0);
				b = (int)((double)(v * (255 - s)) / 255.0);
				return;
			case 1:
				r = (int)((double)(v * (255 - (int)((double)(s * (num % 360)) / 360.0))) / 255.0);
				g = v;
				b = (int)((double)(v * (255 - s)) / 255.0);
				return;
			case 2:
				r = (int)((double)(v * (255 - s)) / 255.0);
				g = v;
				b = (int)((double)(v * (255 - (int)((double)(s * (360 - num % 360)) / 360.0))) / 255.0);
				return;
			case 3:
				r = (int)((double)(v * (255 - s)) / 255.0);
				g = (int)((double)(v * (255 - (int)((double)(s * (num % 360)) / 360.0))) / 255.0);
				b = v;
				return;
			case 4:
				r = (int)((double)(v * (255 - (int)((double)(s * (360 - num % 360)) / 360.0))) / 255.0);
				g = (int)((double)(v * (255 - s)) / 255.0);
				b = v;
				return;
			default:
				r = v;
				g = (int)((double)(v * (255 - s)) / 255.0);
				b = (int)((double)(v * (255 - (int)((double)(s * (num % 360)) / 360.0))) / 255.0);
				return;
			}
		}

		public static void ToHSV(this Color col, out int h, out int s, out int v)
		{
			HSV.ToHSV((int)col.R, (int)col.G, (int)col.B, out h, out s, out v);
		}

		public static void ToHSV(ref Color col, out int h, out int s, out int v)
		{
			HSV.ToHSV((int)col.R, (int)col.G, (int)col.B, out h, out s, out v);
		}

		public static void ToRGB(int h, int s, int v, out Color ret)
		{
			int red;
			int green;
			int blue;
			HSV.ToRGB(h, s, v, out red, out green, out blue);
			ret = Color.FromArgb(red, green, blue);
		}

		public static void ToRGB(int h, int s, int v, int a, out Color ret)
		{
			int red;
			int green;
			int blue;
			HSV.ToRGB(h, s, v, out red, out green, out blue);
			ret = Color.FromArgb(a, red, green, blue);
		}

		public static void ToRGB(this Hsv hsv, out int r, out int g, out int b)
		{
			HSV.ToRGB(hsv.H, hsv.S, hsv.V, out r, out g, out b);
		}

		public static void ToRGB(ref Hsv hsv, out int r, out int g, out int b)
		{
			HSV.ToRGB(hsv.H, hsv.S, hsv.V, out r, out g, out b);
		}

		public static Hsv ToHSV(int r, int g, int b)
		{
			Hsv result;
			HSV.ToHSV(r, g, b, out result.H, out result.S, out result.V);
			return result;
		}

		public static Hsv ToHSV(this Color col)
		{
			Hsv result;
			HSV.ToHSV((int)col.R, (int)col.G, (int)col.B, out result.H, out result.S, out result.V);
			return result;
		}

		public static Hsv ToHSV(ref Color col)
		{
			Hsv result;
			HSV.ToHSV((int)col.R, (int)col.G, (int)col.B, out result.H, out result.S, out result.V);
			return result;
		}

		public static Color ToRGB(this Hsv hsv)
		{
			int red;
			int green;
			int blue;
			HSV.ToRGB(hsv.H, hsv.S, hsv.V, out red, out green, out blue);
			return Color.FromArgb(red, green, blue);
		}

		public static Color ToRGB(ref Hsv hsv)
		{
			int red;
			int green;
			int blue;
			HSV.ToRGB(hsv.H, hsv.S, hsv.V, out red, out green, out blue);
			return Color.FromArgb(red, green, blue);
		}

		private static int GetMax(int x, int y, int z)
		{
			if (x < y)
			{
				if (z >= y)
				{
					return z;
				}
				return y;
			}
			else
			{
				if (z < x)
				{
					return x;
				}
				return z;
			}
		}

		private static int GetMin(int x, int y, int z)
		{
			if (x > y)
			{
				if (z <= y)
				{
					return z;
				}
				return y;
			}
			else
			{
				if (z > x)
				{
					return x;
				}
				return z;
			}
		}
	}
}
