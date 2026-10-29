using System;

namespace _2DGAMELIB
{
	public static class Vec
	{
		public static Vector2D Add(this Vector2D v1, Vector2D v2)
		{
			return new Vector2D(v1.X + v2.X, v1.Y + v2.Y);
		}

		public static Vector2D Add(ref Vector2D v1, ref Vector2D v2)
		{
			return new Vector2D(v1.X + v2.X, v1.Y + v2.Y);
		}

		public static void Add(Vector2D v1, Vector2D v2, out Vector2D r)
		{
			r.X = v1.X + v2.X;
			r.Y = v1.Y + v2.Y;
		}

		public static void Add(ref Vector2D v1, ref Vector2D v2, out Vector2D r)
		{
			r.X = v1.X + v2.X;
			r.Y = v1.Y + v2.Y;
		}

		public static Vector2D Subtract(this Vector2D v1, Vector2D v2)
		{
			return new Vector2D(v1.X - v2.X, v1.Y - v2.Y);
		}

		public static Vector2D Subtract(ref Vector2D v1, ref Vector2D v2)
		{
			return new Vector2D(v1.X - v2.X, v1.Y - v2.Y);
		}

		public static void Subtract(Vector2D v1, Vector2D v2, out Vector2D r)
		{
			r.X = v1.X - v2.X;
			r.Y = v1.Y - v2.Y;
		}

		public static void Subtract(ref Vector2D v1, ref Vector2D v2, out Vector2D r)
		{
			r.X = v1.X - v2.X;
			r.Y = v1.Y - v2.Y;
		}

		public static double DistanceSquared(this Vector2D v1, Vector2D v2)
		{
			double num = v1.X - v2.X;
			double num2 = v1.Y - v2.Y;
			return num * num + num2 * num2;
		}

		public static double DistanceSquared(ref Vector2D v1, ref Vector2D v2)
		{
			double num = v1.X - v2.X;
			double num2 = v1.Y - v2.Y;
			return num * num + num2 * num2;
		}

		public static void DistanceSquared(this Vector2D v1, Vector2D v2, out double r)
		{
			double num = v1.X - v2.X;
			double num2 = v1.Y - v2.Y;
			r = num * num + num2 * num2;
		}

		public static void DistanceSquared(ref Vector2D v1, ref Vector2D v2, out double r)
		{
			double num = v1.X - v2.X;
			double num2 = v1.Y - v2.Y;
			r = num * num + num2 * num2;
		}

		public static double Dot(this Vector2D v1, Vector2D v2)
		{
			return v1.X * v2.X + v1.Y * v2.Y;
		}

		public static double Dot(ref Vector2D v1, ref Vector2D v2)
		{
			return v1.X * v2.X + v1.Y * v2.Y;
		}

		public static void Dot(this Vector2D v1, Vector2D v2, out double r)
		{
			r = v1.X * v2.X + v1.Y * v2.Y;
		}

		public static void Dot(ref Vector2D v1, ref Vector2D v2, out double r)
		{
			r = v1.X * v2.X + v1.Y * v2.Y;
		}

		public static double Cross(this Vector2D v1, Vector2D v2)
		{
			return v1.X * v2.Y - v1.Y * v2.X;
		}

		public static double Cross(ref Vector2D v1, ref Vector2D v2)
		{
			return v1.X * v2.Y - v1.Y * v2.X;
		}

		public static void Cross(this Vector2D v1, Vector2D v2, out double r)
		{
			r = v1.X * v2.Y - v1.Y * v2.X;
		}

		public static void Cross(ref Vector2D v1, ref Vector2D v2, out double r)
		{
			r = v1.X * v2.Y - v1.Y * v2.X;
		}

		public static Vector2D newNormalize(this Vector2D vector)
		{
			vector.Normalize();
			return vector;
		}

		public static double Angle(this Vector2D v1, Vector2D v2)
		{
			double num;
			Vec.Dot(ref v1, ref v2, out num);
			num /= v1.Length() * v2.Length();
			if (num > 1.0)
			{
				num = 1.0;
			}
			else if (num < -1.0)
			{
				num = -1.0;
			}
			return Math.Acos(num);
		}

		public static double Angle(ref Vector2D v1, ref Vector2D v2)
		{
			double num;
			Vec.Dot(ref v1, ref v2, out num);
			num /= v1.Length() * v2.Length();
			if (num > 1.0)
			{
				num = 1.0;
			}
			else if (num < -1.0)
			{
				num = -1.0;
			}
			return Math.Acos(num);
		}

		public static double Angleπ(this Vector2D v1, Vector2D v2)
		{
			double num = Vec.Angle(ref v1, ref v2);
			if (Vec.Cross(ref v1, ref v2) < 0.0)
			{
				num = -num;
			}
			return num;
		}

		public static double Angleπ(ref Vector2D v1, ref Vector2D v2)
		{
			double num = Vec.Angle(ref v1, ref v2);
			if (Vec.Cross(ref v1, ref v2) < 0.0)
			{
				num = -num;
			}
			return num;
		}

		public static double Angle02π(this Vector2D v1, Vector2D v2)
		{
			double num = Vec.Angle(ref v1, ref v2);
			if (Vec.Cross(ref v1, ref v2) < 0.0)
			{
				num = 6.283185307179586 - num;
			}
			return num;
		}

		public static double Angle02π(ref Vector2D v1, ref Vector2D v2)
		{
			double num = Vec.Angle(ref v1, ref v2);
			if (Vec.Cross(ref v1, ref v2) < 0.0)
			{
				num = 6.283185307179586 - num;
			}
			return num;
		}
	}
}
