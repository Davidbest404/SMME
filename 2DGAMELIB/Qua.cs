using System;

namespace _2DGAMELIB
{
	public static class Qua
	{
		public static QuaternionD RotationZQ(this double angle)
		{
			double num = angle * 0.5;
			QuaternionD result;
			result.X = 0.0;
			result.Y = 0.0;
			result.Z = Math.Sin(num);
			result.W = Math.Cos(num);
			return result;
		}

		public static void RotationZQ(this double angle, out QuaternionD result)
		{
			double num = angle * 0.5;
			result.X = 0.0;
			result.Y = 0.0;
			result.Z = Math.Sin(num);
			result.W = Math.Cos(num);
		}

		public static Vector2D TransformCoordinate(this Vector2D coord, QuaternionD rotation)
		{
			double num = rotation.Y + rotation.Y;
			double num2 = rotation.Z + rotation.Z;
			double num3 = rotation.W * num2;
			double num4 = rotation.X * num;
			double num5 = rotation.Z * num2;
			return new Vector2D(coord.X * (1.0 - rotation.Y * num - num5) + coord.Y * (num4 - num3), coord.X * (num4 + num3) + coord.Y * (1.0 - rotation.X * (rotation.X + rotation.X) - num5));
		}

		public static Vector2D TransformCoordinate(ref Vector2D coord, ref QuaternionD rotation)
		{
			double num = rotation.Y + rotation.Y;
			double num2 = rotation.Z + rotation.Z;
			double num3 = rotation.W * num2;
			double num4 = rotation.X * num;
			double num5 = rotation.Z * num2;
			return new Vector2D(coord.X * (1.0 - rotation.Y * num - num5) + coord.Y * (num4 - num3), coord.X * (num4 + num3) + coord.Y * (1.0 - rotation.X * (rotation.X + rotation.X) - num5));
		}

		public static void TransformCoordinate(this Vector2D coord, QuaternionD rotation, out Vector2D result)
		{
			double num = rotation.Y + rotation.Y;
			double num2 = rotation.Z + rotation.Z;
			double num3 = rotation.W * num2;
			double num4 = rotation.X * num;
			double num5 = rotation.Z * num2;
			result.X = coord.X * (1.0 - rotation.Y * num - num5) + coord.Y * (num4 - num3);
			result.Y = coord.X * (num4 + num3) + coord.Y * (1.0 - rotation.X * (rotation.X + rotation.X) - num5);
		}

		public static void TransformCoordinate(ref Vector2D coord, ref QuaternionD rotation, out Vector2D result)
		{
			double num = rotation.Y + rotation.Y;
			double num2 = rotation.Z + rotation.Z;
			double num3 = rotation.W * num2;
			double num4 = rotation.X * num;
			double num5 = rotation.Z * num2;
			result.X = coord.X * (1.0 - rotation.Y * num - num5) + coord.Y * (num4 - num3);
			result.Y = coord.X * (num4 + num3) + coord.Y * (1.0 - rotation.X * (rotation.X + rotation.X) - num5);
		}

		public static Vector2D[] TransformCoordinate(this Vector2D[] coords, QuaternionD rotation)
		{
			int num = coords.Length;
			Vector2D[] array = new Vector2D[num];
			double num2 = rotation.Y + rotation.Y;
			double num3 = rotation.Z + rotation.Z;
			double num4 = rotation.W * num3;
			double num5 = rotation.X * num2;
			double num6 = rotation.Z * num3;
			for (int i = 0; i < num; i++)
			{
				array[i].X = coords[i].X * (1.0 - rotation.Y * num2 - num6) + coords[i].Y * (num5 - num4);
				array[i].Y = coords[i].X * (num5 + num4) + coords[i].Y * (1.0 - rotation.X * (rotation.X + rotation.X) - num6);
			}
			return array;
		}

		public static Vector2D[] TransformCoordinate(this Vector2D[] coords, ref QuaternionD rotation)
		{
			int num = coords.Length;
			Vector2D[] array = new Vector2D[num];
			double num2 = rotation.Y + rotation.Y;
			double num3 = rotation.Z + rotation.Z;
			double num4 = rotation.W * num3;
			double num5 = rotation.X * num2;
			double num6 = rotation.Z * num3;
			for (int i = 0; i < num; i++)
			{
				array[i].X = coords[i].X * (1.0 - rotation.Y * num2 - num6) + coords[i].Y * (num5 - num4);
				array[i].Y = coords[i].X * (num5 + num4) + coords[i].Y * (1.0 - rotation.X * (rotation.X + rotation.X) - num6);
			}
			return array;
		}

		public static void TransformCoordinate(this Vector2D[] coords, QuaternionD rotation, out Vector2D[] results)
		{
			int num = coords.Length;
			results = new Vector2D[num];
			double num2 = rotation.Y + rotation.Y;
			double num3 = rotation.Z + rotation.Z;
			double num4 = rotation.W * num3;
			double num5 = rotation.X * num2;
			double num6 = rotation.Z * num3;
			for (int i = 0; i < num; i++)
			{
				results[i].X = coords[i].X * (1.0 - rotation.Y * num2 - num6) + coords[i].Y * (num5 - num4);
				results[i].Y = coords[i].X * (num5 + num4) + coords[i].Y * (1.0 - rotation.X * (rotation.X + rotation.X) - num6);
			}
		}

		public static void TransformCoordinate(this Vector2D[] coords, ref QuaternionD rotation, out Vector2D[] results)
		{
			int num = coords.Length;
			results = new Vector2D[num];
			double num2 = rotation.Y + rotation.Y;
			double num3 = rotation.Z + rotation.Z;
			double num4 = rotation.W * num3;
			double num5 = rotation.X * num2;
			double num6 = rotation.Z * num3;
			for (int i = 0; i < num; i++)
			{
				results[i].X = coords[i].X * (1.0 - rotation.Y * num2 - num6) + coords[i].Y * (num5 - num4);
				results[i].Y = coords[i].X * (num5 + num4) + coords[i].Y * (1.0 - rotation.X * (rotation.X + rotation.X) - num6);
			}
		}

		public static Vector2D TransformCoordinateBP(this Vector2D coord, Vector2D BasePoint, QuaternionD rotation)
		{
			Vec.Subtract(ref coord, ref BasePoint, out coord);
			Vector2D result;
			Qua.TransformCoordinate(ref coord, ref rotation, out result);
			Vec.Add(ref result, ref BasePoint, out result);
			return result;
		}

		public static Vector2D TransformCoordinateBP(ref Vector2D coord, ref Vector2D BasePoint, ref QuaternionD rotation)
		{
			Vector2D vector2D;
			Vec.Subtract(ref coord, ref BasePoint, out vector2D);
			Vector2D result;
			Qua.TransformCoordinate(ref vector2D, ref rotation, out result);
			Vec.Add(ref result, ref BasePoint, out result);
			return result;
		}

		public static void TransformCoordinateBP(this Vector2D coord, Vector2D BasePoint, QuaternionD rotation, out Vector2D result)
		{
			Vec.Subtract(ref coord, ref BasePoint, out coord);
			Qua.TransformCoordinate(ref coord, ref rotation, out result);
			Vec.Add(ref result, ref BasePoint, out result);
		}

		public static void TransformCoordinateBP(ref Vector2D coord, ref Vector2D BasePoint, ref QuaternionD rotation, out Vector2D result)
		{
			Vector2D vector2D;
			Vec.Subtract(ref coord, ref BasePoint, out vector2D);
			Qua.TransformCoordinate(ref vector2D, ref rotation, out result);
			Vec.Add(ref result, ref BasePoint, out result);
		}
	}
}
