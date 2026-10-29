using System;

namespace _2DGAMELIB
{
	public static class Mat
	{
		public static MatrixD RotationZ(this double angle)
		{
			MatrixD matrixD;
			matrixD.M11 = Math.Cos(angle);
			matrixD.M12 = Math.Sin(angle);
			matrixD.M13 = 0.0;
			matrixD.M14 = 0.0;
			matrixD.M21 = -matrixD.M12;
			matrixD.M22 = matrixD.M11;
			matrixD.M23 = 0.0;
			matrixD.M24 = 0.0;
			matrixD.M31 = 0.0;
			matrixD.M32 = 0.0;
			matrixD.M33 = 1.0;
			matrixD.M34 = 0.0;
			matrixD.M41 = 0.0;
			matrixD.M42 = 0.0;
			matrixD.M43 = 0.0;
			matrixD.M44 = 1.0;
			return matrixD;
		}

		public static void RotationZ(this double angle, out MatrixD result)
		{
			result.M11 = Math.Cos(angle);
			result.M12 = Math.Sin(angle);
			result.M13 = 0.0;
			result.M14 = 0.0;
			result.M21 = -result.M12;
			result.M22 = result.M11;
			result.M23 = 0.0;
			result.M24 = 0.0;
			result.M31 = 0.0;
			result.M32 = 0.0;
			result.M33 = 1.0;
			result.M34 = 0.0;
			result.M41 = 0.0;
			result.M42 = 0.0;
			result.M43 = 0.0;
			result.M44 = 1.0;
		}

		public static Vector2D TransformCoordinate(this Vector2D coord, MatrixD transform)
		{
			double num = 1.0 / (coord.X * transform.M14 + coord.Y * transform.M24 + transform.M44);
			return new Vector2D((coord.X * transform.M11 + coord.Y * transform.M21 + transform.M41) * num, (coord.X * transform.M12 + coord.Y * transform.M22 + transform.M42) * num);
		}

		public static Vector2D TransformCoordinate(ref Vector2D coord, ref MatrixD transform)
		{
			double num = 1.0 / (coord.X * transform.M14 + coord.Y * transform.M24 + transform.M44);
			return new Vector2D((coord.X * transform.M11 + coord.Y * transform.M21 + transform.M41) * num, (coord.X * transform.M12 + coord.Y * transform.M22 + transform.M42) * num);
		}

		public static void TransformCoordinate(this Vector2D coord, MatrixD transform, out Vector2D result)
		{
			double num = 1.0 / (coord.X * transform.M14 + coord.Y * transform.M24 + transform.M44);
			result.X = (coord.X * transform.M11 + coord.Y * transform.M21 + transform.M41) * num;
			result.Y = (coord.X * transform.M12 + coord.Y * transform.M22 + transform.M42) * num;
		}

		public static void TransformCoordinate(ref Vector2D coord, ref MatrixD transform, out Vector2D result)
		{
			double num = 1.0 / (coord.X * transform.M14 + coord.Y * transform.M24 + transform.M44);
			result.X = (coord.X * transform.M11 + coord.Y * transform.M21 + transform.M41) * num;
			result.Y = (coord.X * transform.M12 + coord.Y * transform.M22 + transform.M42) * num;
		}

		public static Vector2D[] TransformCoordinate(this Vector2D[] coords, MatrixD transform)
		{
			int num = coords.Length;
			Vector2D[] array = new Vector2D[num];
			for (int i = 0; i < num; i++)
			{
				double num2 = 1.0 / (coords[i].X * transform.M14 + coords[i].Y * transform.M24 + transform.M44);
				array[i].X = (coords[i].X * transform.M11 + coords[i].Y * transform.M21 + transform.M41) * num2;
				array[i].Y = (coords[i].X * transform.M12 + coords[i].Y * transform.M22 + transform.M42) * num2;
			}
			return array;
		}

		public static Vector2D[] TransformCoordinate(this Vector2D[] coords, ref MatrixD transform)
		{
			int num = coords.Length;
			Vector2D[] array = new Vector2D[num];
			for (int i = 0; i < num; i++)
			{
				double num2 = 1.0 / (coords[i].X * transform.M14 + coords[i].Y * transform.M24 + transform.M44);
				array[i].X = (coords[i].X * transform.M11 + coords[i].Y * transform.M21 + transform.M41) * num2;
				array[i].Y = (coords[i].X * transform.M12 + coords[i].Y * transform.M22 + transform.M42) * num2;
			}
			return array;
		}

		public static void TransformCoordinate(this Vector2D[] coords, MatrixD transform, out Vector2D[] results)
		{
			int num = coords.Length;
			results = new Vector2D[num];
			for (int i = 0; i < num; i++)
			{
				double num2 = 1.0 / (coords[i].X * transform.M14 + coords[i].Y * transform.M24 + transform.M44);
				results[i].X = (coords[i].X * transform.M11 + coords[i].Y * transform.M21 + transform.M41) * num2;
				results[i].Y = (coords[i].X * transform.M12 + coords[i].Y * transform.M22 + transform.M42) * num2;
			}
		}

		public static void TransformCoordinate(this Vector2D[] coords, ref MatrixD transform, out Vector2D[] results)
		{
			int num = coords.Length;
			results = new Vector2D[num];
			for (int i = 0; i < num; i++)
			{
				double num2 = 1.0 / (coords[i].X * transform.M14 + coords[i].Y * transform.M24 + transform.M44);
				results[i].X = (coords[i].X * transform.M11 + coords[i].Y * transform.M21 + transform.M41) * num2;
				results[i].Y = (coords[i].X * transform.M12 + coords[i].Y * transform.M22 + transform.M42) * num2;
			}
		}

		public static Vector2D TransformCoordinateBP(this Vector2D coord, Vector2D BasePoint, MatrixD transform)
		{
			Vec.Subtract(ref coord, ref BasePoint, out coord);
			Vector2D result;
			Mat.TransformCoordinate(ref coord, ref transform, out result);
			Vec.Add(ref result, ref BasePoint, out result);
			return result;
		}

		public static Vector2D TransformCoordinateBP(ref Vector2D coord, ref Vector2D BasePoint, ref MatrixD transform)
		{
			Vector2D vector2D;
			Vec.Subtract(ref coord, ref BasePoint, out vector2D);
			Vector2D result;
			Mat.TransformCoordinate(ref vector2D, ref transform, out result);
			Vec.Add(ref result, ref BasePoint, out result);
			return result;
		}

		public static void TransformCoordinateBP(this Vector2D coord, Vector2D BasePoint, MatrixD transform, out Vector2D result)
		{
			Vec.Subtract(ref coord, ref BasePoint, out coord);
			Mat.TransformCoordinate(ref coord, ref transform, out result);
			Vec.Add(ref result, ref BasePoint, out result);
		}

		public static void TransformCoordinateBP(ref Vector2D coord, ref Vector2D BasePoint, ref MatrixD transform, out Vector2D result)
		{
			Vector2D vector2D;
			Vec.Subtract(ref coord, ref BasePoint, out vector2D);
			Mat.TransformCoordinate(ref vector2D, ref transform, out result);
			Vec.Add(ref result, ref BasePoint, out result);
		}
	}
}
