using System;
using System.Collections.Generic;
using System.Linq;

namespace _2DGAMELIB
{
	public static class Shas
	{
		public static Vector2D Get左端上端(this Vector2D Vector2D)
		{
			return Dat.Vec2DZero;
		}

		public static Vector2D Get中央上端(this Vector2D Vector2D)
		{
			return new Vector2D(Vector2D.X * 0.5, 0.0);
		}

		public static Vector2D Get左寄上端(this Vector2D Vector2D)
		{
			return new Vector2D(Vector2D.X / 3.0, 0.0);
		}

		public static Vector2D Get右寄上端(this Vector2D Vector2D)
		{
			return new Vector2D(Vector2D.X / 3.0 * 2.0, 0.0);
		}

		public static Vector2D Get右端上端(this Vector2D Vector2D)
		{
			return new Vector2D(Vector2D.X, 0.0);
		}

		public static Vector2D Get左端中央(this Vector2D Vector2D)
		{
			return new Vector2D(0.0, Vector2D.Y * 0.5);
		}

		public static Vector2D Get中央中央(this Vector2D Vector2D)
		{
			return new Vector2D(Vector2D.X * 0.5, Vector2D.Y * 0.5);
		}

		public static Vector2D Get左寄中央(this Vector2D Vector2D)
		{
			return new Vector2D(Vector2D.X / 3.0, Vector2D.Y * 0.5);
		}

		public static Vector2D Get右寄中央(this Vector2D Vector2D)
		{
			return new Vector2D(Vector2D.X / 3.0 * 2.0, Vector2D.Y * 0.5);
		}

		public static Vector2D Get右端中央(this Vector2D Vector2D)
		{
			return new Vector2D(Vector2D.X, Vector2D.Y * 0.5);
		}

		public static Vector2D Get左端上寄(this Vector2D Vector2D)
		{
			return new Vector2D(0.0, Vector2D.Y / 3.0);
		}

		public static Vector2D Get中央上寄(this Vector2D Vector2D)
		{
			return new Vector2D(Vector2D.X * 0.5, Vector2D.Y / 3.0);
		}

		public static Vector2D Get左寄上寄(this Vector2D Vector2D)
		{
			return new Vector2D(Vector2D.X / 3.0, Vector2D.Y / 3.0);
		}

		public static Vector2D Get右寄上寄(this Vector2D Vector2D)
		{
			return new Vector2D(Vector2D.X / 3.0 * 2.0, Vector2D.Y / 3.0);
		}

		public static Vector2D Get右端上寄(this Vector2D Vector2D)
		{
			return new Vector2D(Vector2D.X, Vector2D.Y / 3.0);
		}

		public static Vector2D Get左端下寄(this Vector2D Vector2D)
		{
			return new Vector2D(0.0, Vector2D.Y / 3.0 * 2.0);
		}

		public static Vector2D Get中央下寄(this Vector2D Vector2D)
		{
			return new Vector2D(Vector2D.X * 0.5, Vector2D.Y / 3.0 * 2.0);
		}

		public static Vector2D Get左寄下寄(this Vector2D Vector2D)
		{
			return new Vector2D(Vector2D.X / 3.0, Vector2D.Y / 3.0 * 2.0);
		}

		public static Vector2D Get右寄下寄(this Vector2D Vector2D)
		{
			return new Vector2D(Vector2D.X / 3.0 * 2.0, Vector2D.Y / 3.0 * 2.0);
		}

		public static Vector2D Get右端下寄(this Vector2D Vector2D)
		{
			return new Vector2D(Vector2D.X, Vector2D.Y / 3.0 * 2.0);
		}

		public static Vector2D Get左端下端(this Vector2D Vector2D)
		{
			return new Vector2D(0.0, Vector2D.Y);
		}

		public static Vector2D Get中央下端(this Vector2D Vector2D)
		{
			return new Vector2D(Vector2D.X * 0.5, Vector2D.Y);
		}

		public static Vector2D Get左寄下端(this Vector2D Vector2D)
		{
			return new Vector2D(Vector2D.X / 3.0, Vector2D.Y);
		}

		public static Vector2D Get右寄下端(this Vector2D Vector2D)
		{
			return new Vector2D(Vector2D.X / 3.0 * 2.0, Vector2D.Y);
		}

		public static Vector2D Get右端下端(this Vector2D Vector2D)
		{
			return Vector2D;
		}

		private static Vector2D GetTP2()
		{
			return Mat.TransformCoordinateBP(ref Shas.TP1, ref Shas.中央中央, ref Shas.m120);
		}

		private static Vector2D GetTP3()
		{
			return Mat.TransformCoordinateBP(ref Shas.TP1, ref Shas.中央中央, ref Shas.m240);
		}

		public static Vector2D MulX(this Vector2D Vector, double X)
		{
			Vector.X *= X;
			return Vector;
		}

		public static Vector2D MulX(ref Vector2D Vector, double X)
		{
			Vector.X *= X;
			return Vector;
		}

		public static Vector2D MulY(this Vector2D Vector, double Y)
		{
			Vector.Y *= Y;
			return Vector;
		}

		public static Vector2D MulY(ref Vector2D Vector, double Y)
		{
			Vector.Y *= Y;
			return Vector;
		}

		public static Vector2D MulXY(this Vector2D Vector, double X, double Y)
		{
			Vector.X *= X;
			Vector.Y *= Y;
			return Vector;
		}

		public static Vector2D MulXY(ref Vector2D Vector, double X, double Y)
		{
			Vector.X *= X;
			Vector.Y *= Y;
			return Vector;
		}

		public static Vector2D DivX(this Vector2D Vector, double X)
		{
			Vector.X /= X;
			return Vector;
		}

		public static Vector2D DivX(ref Vector2D Vector, double X)
		{
			Vector.X /= X;
			return Vector;
		}

		public static Vector2D DivY(this Vector2D Vector, double Y)
		{
			Vector.Y /= Y;
			return Vector;
		}

		public static Vector2D DivY(ref Vector2D Vector, double Y)
		{
			Vector.Y /= Y;
			return Vector;
		}

		public static Vector2D DivXY(this Vector2D Vector, double X, double Y)
		{
			Vector.X /= X;
			Vector.Y /= Y;
			return Vector;
		}

		public static Vector2D DivXY(ref Vector2D Vector, double X, double Y)
		{
			Vector.X /= X;
			Vector.Y /= Y;
			return Vector;
		}

		public static Vector2D AddX(this Vector2D Point, double X)
		{
			Point.X += X;
			return Point;
		}

		public static Vector2D AddX(ref Vector2D Point, double X)
		{
			Point.X += X;
			return Point;
		}

		public static Vector2D AddY(this Vector2D Point, double Y)
		{
			Point.Y += Y;
			return Point;
		}

		public static Vector2D AddY(ref Vector2D Point, double Y)
		{
			Point.Y += Y;
			return Point;
		}

		public static Vector2D AddXY(this Vector2D Point, double X, double Y)
		{
			Point.X += X;
			Point.Y += Y;
			return Point;
		}

		public static Vector2D AddXY(ref Vector2D Point, double X, double Y)
		{
			Point.X += X;
			Point.Y += Y;
			return Point;
		}

		public static void SetTension(this IEnumerable<Out> Out, float Tension)
		{
			foreach (Out @out in Out)
			{
				@out.Tension = Tension;
			}
		}

		public static void OutlineFalse(this IEnumerable<Out> Out)
		{
			foreach (Out @out in Out)
			{
				@out.Outline = false;
			}
		}

		public static void OutlineTrue(this IEnumerable<Out> Out)
		{
			foreach (Out @out in Out)
			{
				@out.Outline = true;
			}
		}

		public static Vector2D GetCenter(this IEnumerable<Out> Out)
		{
			double num = 0.0;
			Vector2D vector2D = Dat.Vec2DZero;
			foreach (Out @out in Out)
			{
				foreach (Vector2D right in @out.ps)
				{
					vector2D += right;
				}
				num += (double)@out.ps.Count;
			}
			return vector2D / num;
		}

		public static Vector2D GetCenter(this IEnumerable<Joi> Joi)
		{
			double num = 0.0;
			Vector2D vector2D = Dat.Vec2DZero;
			foreach (Joi joi in Joi)
			{
				vector2D += joi.Joint;
				num += 1.0;
			}
			return vector2D / num;
		}

		public static void AddVector(this IEnumerable<Out> Out, Vector2D Vector)
		{
			foreach (Out @out in Out)
			{
				for (int i = 0; i < @out.ps.Count; i++)
				{
					List<Vector2D> ps = @out.ps;
					int index = i;
					ps[index] += Vector;
				}
			}
		}

		public static void AddVector(this IEnumerable<Joi> Joi, Vector2D Vector)
		{
			foreach (Joi joi in Joi)
			{
				joi.Joint += Vector;
			}
		}

		public static void Rotation(this IEnumerable<Out> Out, Vector2D BP, double Angle)
		{
			MatrixD transform = Angle.ToRadian().RotationZ();
			foreach (Out @out in Out)
			{
				for (int i = 0; i < @out.ps.Count; i++)
				{
					@out.ps[i] = @out.ps[i].TransformCoordinateBP(BP, transform);
				}
			}
		}

		public static void Rotation(this IEnumerable<Out> Out, ref Vector2D BP, double Angle)
		{
			MatrixD transform = Angle.ToRadian().RotationZ();
			foreach (Out @out in Out)
			{
				for (int i = 0; i < @out.ps.Count; i++)
				{
					@out.ps[i] = @out.ps[i].TransformCoordinateBP(BP, transform);
				}
			}
		}

		public static void Rotation(this IEnumerable<Joi> Joi, Vector2D BP, double Angle)
		{
			MatrixD matrixD = Angle.ToRadian().RotationZ();
			foreach (Joi joi in Joi)
			{
				joi.Joint = Mat.TransformCoordinateBP(ref joi.Joint, ref BP, ref matrixD);
			}
		}

		public static void Rotation(this IEnumerable<Joi> Joi, ref Vector2D BP, double Angle)
		{
			MatrixD matrixD = Angle.ToRadian().RotationZ();
			foreach (Joi joi in Joi)
			{
				joi.Joint = Mat.TransformCoordinateBP(ref joi.Joint, ref BP, ref matrixD);
			}
		}

		public static void ScalingX(this IEnumerable<Out> Out, Vector2D BP, double Rate)
		{
			double num = BP.X - BP.X * Rate;
			foreach (Out @out in Out)
			{
				for (int i = 0; i < @out.ps.Count; i++)
				{
					Vector2D vector2D = @out.ps[i];
					vector2D.X = vector2D.X * Rate + num;
					@out.ps[i] = vector2D;
				}
			}
		}

		public static void ScalingX(this IEnumerable<Out> Out, ref Vector2D BP, double Rate)
		{
			double num = BP.X - BP.X * Rate;
			foreach (Out @out in Out)
			{
				for (int i = 0; i < @out.ps.Count; i++)
				{
					Vector2D vector2D = @out.ps[i];
					vector2D.X = vector2D.X * Rate + num;
					@out.ps[i] = vector2D;
				}
			}
		}

		public static void ScalingY(this IEnumerable<Out> Out, Vector2D BP, double Rate)
		{
			double num = BP.Y - BP.Y * Rate;
			foreach (Out @out in Out)
			{
				for (int i = 0; i < @out.ps.Count; i++)
				{
					Vector2D vector2D = @out.ps[i];
					vector2D.Y = vector2D.Y * Rate + num;
					@out.ps[i] = vector2D;
				}
			}
		}

		public static void ScalingY(this IEnumerable<Out> Out, ref Vector2D BP, double Rate)
		{
			double num = BP.Y - BP.Y * Rate;
			foreach (Out @out in Out)
			{
				for (int i = 0; i < @out.ps.Count; i++)
				{
					Vector2D vector2D = @out.ps[i];
					vector2D.Y = vector2D.Y * Rate + num;
					@out.ps[i] = vector2D;
				}
			}
		}

		public static void ScalingXY(this IEnumerable<Out> Out, Vector2D BP, double Rate)
		{
			Vector2D vector2D;
			vector2D.X = BP.X - BP.X * Rate;
			vector2D.Y = BP.Y - BP.Y * Rate;
			foreach (Out @out in Out)
			{
				for (int i = 0; i < @out.ps.Count; i++)
				{
					Vector2D vector2D2 = @out.ps[i];
					vector2D2.X = vector2D2.X * Rate + vector2D.X;
					vector2D2.Y = vector2D2.Y * Rate + vector2D.Y;
					@out.ps[i] = vector2D2;
				}
			}
		}

		public static void ScalingXY(this IEnumerable<Out> Out, ref Vector2D BP, double Rate)
		{
			Vector2D vector2D;
			vector2D.X = BP.X - BP.X * Rate;
			vector2D.Y = BP.Y - BP.Y * Rate;
			foreach (Out @out in Out)
			{
				for (int i = 0; i < @out.ps.Count; i++)
				{
					Vector2D vector2D2 = @out.ps[i];
					vector2D2.X = vector2D2.X * Rate + vector2D.X;
					vector2D2.Y = vector2D2.Y * Rate + vector2D.Y;
					@out.ps[i] = vector2D2;
				}
			}
		}

		public static void ScalingXY(this IEnumerable<Out> Out, Vector2D BP, double X, double Y)
		{
			Vector2D vector2D;
			vector2D.X = BP.X - BP.X * X;
			vector2D.Y = BP.Y - BP.Y * Y;
			foreach (Out @out in Out)
			{
				for (int i = 0; i < @out.ps.Count; i++)
				{
					Vector2D vector2D2 = @out.ps[i];
					vector2D2.X = vector2D2.X * X + vector2D.X;
					vector2D2.Y = vector2D2.Y * Y + vector2D.Y;
					@out.ps[i] = vector2D2;
				}
			}
		}

		public static void ScalingXY(this IEnumerable<Out> Out, ref Vector2D BP, double X, double Y)
		{
			Vector2D vector2D;
			vector2D.X = BP.X - BP.X * X;
			vector2D.Y = BP.Y - BP.Y * Y;
			foreach (Out @out in Out)
			{
				for (int i = 0; i < @out.ps.Count; i++)
				{
					Vector2D vector2D2 = @out.ps[i];
					vector2D2.X = vector2D2.X * X + vector2D.X;
					vector2D2.Y = vector2D2.Y * Y + vector2D.Y;
					@out.ps[i] = vector2D2;
				}
			}
		}

		public static void ScalingX(this IEnumerable<Joi> Joi, Vector2D BP, double Rate)
		{
			double num = BP.X - BP.X * Rate;
			foreach (Joi joi in Joi)
			{
				joi.Joint.X = joi.Joint.X * Rate + num;
			}
		}

		public static void ScalingX(this IEnumerable<Joi> Joi, ref Vector2D BP, double Rate)
		{
			double num = BP.X - BP.X * Rate;
			foreach (Joi joi in Joi)
			{
				joi.Joint.X = joi.Joint.X * Rate + num;
			}
		}

		public static void ScalingY(this IEnumerable<Joi> Joi, Vector2D BP, double Rate)
		{
			double num = BP.Y - BP.Y * Rate;
			foreach (Joi joi in Joi)
			{
				joi.Joint.Y = joi.Joint.Y * Rate + num;
			}
		}

		public static void ScalingY(this IEnumerable<Joi> Joi, ref Vector2D BP, double Rate)
		{
			double num = BP.Y - BP.Y * Rate;
			foreach (Joi joi in Joi)
			{
				joi.Joint.Y = joi.Joint.Y * Rate + num;
			}
		}

		public static void ScalingXY(this IEnumerable<Joi> Joi, Vector2D BP, double Rate)
		{
			Vector2D vector2D;
			vector2D.X = BP.X - BP.X * Rate;
			vector2D.Y = BP.Y - BP.Y * Rate;
			foreach (Joi joi in Joi)
			{
				joi.Joint.X = joi.Joint.X * Rate + vector2D.X;
				joi.Joint.Y = joi.Joint.Y * Rate + vector2D.Y;
			}
		}

		public static void ScalingXY(this IEnumerable<Joi> Joi, ref Vector2D BP, double Rate)
		{
			Vector2D vector2D;
			vector2D.X = BP.X - BP.X * Rate;
			vector2D.Y = BP.Y - BP.Y * Rate;
			foreach (Joi joi in Joi)
			{
				joi.Joint.X = joi.Joint.X * Rate + vector2D.X;
				joi.Joint.Y = joi.Joint.Y * Rate + vector2D.Y;
			}
		}

		public static void ScalingXY(this IEnumerable<Joi> Joi, Vector2D BP, double X, double Y)
		{
			Vector2D vector2D;
			vector2D.X = BP.X - BP.X * X;
			vector2D.Y = BP.Y - BP.Y * Y;
			foreach (Joi joi in Joi)
			{
				joi.Joint.X = joi.Joint.X * X + vector2D.X;
				joi.Joint.Y = joi.Joint.Y * Y + vector2D.Y;
			}
		}

		public static void ScalingXY(this IEnumerable<Joi> Joi, ref Vector2D BP, double X, double Y)
		{
			Vector2D vector2D;
			vector2D.X = BP.X - BP.X * X;
			vector2D.Y = BP.Y - BP.Y * Y;
			foreach (Joi joi in Joi)
			{
				joi.Joint.X = joi.Joint.X * X + vector2D.X;
				joi.Joint.Y = joi.Joint.Y * Y + vector2D.Y;
			}
		}

		public static void ReverseX(this List<Out> Out, Vector2D BP)
		{
			double num = BP.X - (1.0 - BP.X);
			foreach (Out @out in Out)
			{
				for (int i = 0; i < @out.ps.Count; i++)
				{
					Vector2D vector2D = @out.ps[i];
					vector2D.X = 1.0 - vector2D.X + num;
					@out.ps[i] = vector2D;
				}
				@out.ps.Reverse();
			}
			Out.Reverse();
		}

		public static void ReverseX(this List<Out> Out, ref Vector2D BP)
		{
			double num = BP.X - (1.0 - BP.X);
			foreach (Out @out in Out)
			{
				for (int i = 0; i < @out.ps.Count; i++)
				{
					Vector2D vector2D = @out.ps[i];
					vector2D.X = 1.0 - vector2D.X + num;
					@out.ps[i] = vector2D;
				}
				@out.ps.Reverse();
			}
			Out.Reverse();
		}

		public static void ReverseY(this List<Out> Out, Vector2D BP)
		{
			double num = BP.Y - (1.0 - BP.Y);
			foreach (Out @out in Out)
			{
				for (int i = 0; i < @out.ps.Count; i++)
				{
					Vector2D vector2D = @out.ps[i];
					vector2D.Y = 1.0 - vector2D.Y + num;
					@out.ps[i] = vector2D;
				}
				@out.ps.Reverse();
			}
			Out.Reverse();
		}

		public static void ReverseY(this List<Out> Out, ref Vector2D BP)
		{
			double num = BP.Y - (1.0 - BP.Y);
			foreach (Out @out in Out)
			{
				for (int i = 0; i < @out.ps.Count; i++)
				{
					Vector2D vector2D = @out.ps[i];
					vector2D.Y = 1.0 - vector2D.Y + num;
					@out.ps[i] = vector2D;
				}
				@out.ps.Reverse();
			}
			Out.Reverse();
		}

		public static void ReverseXY(this List<Out> Out, Vector2D BP)
		{
			Vector2D vector2D;
			vector2D.X = BP.X - (1.0 - BP.X);
			vector2D.Y = BP.Y - (1.0 - BP.Y);
			foreach (Out @out in Out)
			{
				for (int i = 0; i < @out.ps.Count; i++)
				{
					Vector2D vector2D2 = @out.ps[i];
					vector2D2.X = 1.0 - vector2D2.X + vector2D.X;
					vector2D2.Y = 1.0 - vector2D2.Y + vector2D.Y;
					@out.ps[i] = vector2D2;
				}
				@out.ps.Reverse();
			}
			Out.Reverse();
		}

		public static void ReverseXY(this List<Out> Out, ref Vector2D BP)
		{
			Vector2D vector2D;
			vector2D.X = BP.X - (1.0 - BP.X);
			vector2D.Y = BP.Y - (1.0 - BP.Y);
			foreach (Out @out in Out)
			{
				for (int i = 0; i < @out.ps.Count; i++)
				{
					Vector2D vector2D2 = @out.ps[i];
					vector2D2.X = 1.0 - vector2D2.X + vector2D.X;
					vector2D2.Y = 1.0 - vector2D2.Y + vector2D.Y;
					@out.ps[i] = vector2D2;
				}
				@out.ps.Reverse();
			}
			Out.Reverse();
		}

		public static void ReverseX(this List<Joi> Joi, Vector2D BP)
		{
			double num = BP.X - (1.0 - BP.X);
			foreach (Joi joi in Joi)
			{
				joi.Joint.X = 1.0 - joi.Joint.X + num;
			}
		}

		public static void ReverseX(this List<Joi> Joi, ref Vector2D BP)
		{
			double num = BP.X - (1.0 - BP.X);
			foreach (Joi joi in Joi)
			{
				joi.Joint.X = 1.0 - joi.Joint.X + num;
			}
		}

		public static void ReverseY(this List<Joi> Joi, Vector2D BP)
		{
			double num = BP.Y - (1.0 - BP.Y);
			foreach (Joi joi in Joi)
			{
				joi.Joint.Y = 1.0 - joi.Joint.Y + num;
			}
		}

		public static void ReverseY(this List<Joi> Joi, ref Vector2D BP)
		{
			double num = BP.Y - (1.0 - BP.Y);
			foreach (Joi joi in Joi)
			{
				joi.Joint.Y = 1.0 - joi.Joint.Y + num;
			}
		}

		public static void ReverseXY(this List<Joi> Joi, Vector2D BP)
		{
			Vector2D vector2D;
			vector2D.X = BP.X - (1.0 - BP.X);
			vector2D.Y = BP.Y - (1.0 - BP.Y);
			foreach (Joi joi in Joi)
			{
				joi.Joint.X = 1.0 - joi.Joint.X + vector2D.X;
				joi.Joint.Y = 1.0 - joi.Joint.Y + vector2D.Y;
			}
		}

		public static void ReverseXY(this List<Joi> Joi, ref Vector2D BP)
		{
			Vector2D vector2D;
			vector2D.X = BP.X - (1.0 - BP.X);
			vector2D.Y = BP.Y - (1.0 - BP.Y);
			foreach (Joi joi in Joi)
			{
				joi.Joint.X = 1.0 - joi.Joint.X + vector2D.X;
				joi.Joint.Y = 1.0 - joi.Joint.Y + vector2D.Y;
			}
		}

		public static void ExpansionX(this List<Out> Out, Vector2D BP, double Rate)
		{
			foreach (Out @out in Out)
			{
				for (int i = 0; i < @out.ps.Count; i++)
				{
					Vector2D value = (@out.ps[i] - BP).newNormalize();
					value.Y = 0.0;
					List<Vector2D> ps = @out.ps;
					int index = i;
					ps[index] += value * Rate;
				}
			}
		}

		public static void ExpansionX(this List<Out> Out, ref Vector2D BP, double Rate)
		{
			foreach (Out @out in Out)
			{
				for (int i = 0; i < @out.ps.Count; i++)
				{
					Vector2D value = (@out.ps[i] - BP).newNormalize();
					value.Y = 0.0;
					List<Vector2D> ps = @out.ps;
					int index = i;
					ps[index] += value * Rate;
				}
			}
		}

		public static void ExpansionY(this List<Out> Out, Vector2D BP, double Rate)
		{
			foreach (Out @out in Out)
			{
				for (int i = 0; i < @out.ps.Count; i++)
				{
					Vector2D value = (@out.ps[i] - BP).newNormalize();
					value.X = 0.0;
					List<Vector2D> ps = @out.ps;
					int index = i;
					ps[index] += value * Rate;
				}
			}
		}

		public static void ExpansionY(this List<Out> Out, ref Vector2D BP, double Rate)
		{
			foreach (Out @out in Out)
			{
				for (int i = 0; i < @out.ps.Count; i++)
				{
					Vector2D value = (@out.ps[i] - BP).newNormalize();
					value.X = 0.0;
					List<Vector2D> ps = @out.ps;
					int index = i;
					ps[index] += value * Rate;
				}
			}
		}

		public static void ExpansionXY(this List<Out> Out, Vector2D BP, double Rate)
		{
			foreach (Out @out in Out)
			{
				for (int i = 0; i < @out.ps.Count; i++)
				{
					List<Vector2D> ps = @out.ps;
					int index = i;
					ps[index] += (@out.ps[i] - BP).newNormalize() * Rate;
				}
			}
		}

		public static void ExpansionXY(this List<Out> Out, ref Vector2D BP, double Rate)
		{
			foreach (Out @out in Out)
			{
				for (int i = 0; i < @out.ps.Count; i++)
				{
					List<Vector2D> ps = @out.ps;
					int index = i;
					ps[index] += (@out.ps[i] - BP).newNormalize() * Rate;
				}
			}
		}

		public static void ExpansionX(this List<Joi> Joi, Vector2D BP, double Rate)
		{
			foreach (Joi joi in Joi)
			{
				Vector2D value = (joi.Joint - BP).newNormalize();
				value.Y = 0.0;
				joi.Joint += value * Rate;
			}
		}

		public static void ExpansionX(this List<Joi> Joi, ref Vector2D BP, double Rate)
		{
			foreach (Joi joi in Joi)
			{
				Vector2D value = (joi.Joint - BP).newNormalize();
				value.Y = 0.0;
				joi.Joint += value * Rate;
			}
		}

		public static void ExpansionY(this List<Joi> Joi, Vector2D BP, double Rate)
		{
			foreach (Joi joi in Joi)
			{
				Vector2D value = (joi.Joint - BP).newNormalize();
				value.X = 0.0;
				joi.Joint += value * Rate;
			}
		}

		public static void ExpansionY(this List<Joi> Joi, ref Vector2D BP, double Rate)
		{
			foreach (Joi joi in Joi)
			{
				Vector2D value = (joi.Joint - BP).newNormalize();
				value.X = 0.0;
				joi.Joint += value * Rate;
			}
		}

		public static void ExpansionXY(this List<Joi> Joi, Vector2D BP, double Rate)
		{
			foreach (Joi joi in Joi)
			{
				joi.Joint += (joi.Joint - BP).newNormalize() * Rate;
			}
		}

		public static void ExpansionXY(this List<Joi> Joi, ref Vector2D BP, double Rate)
		{
			foreach (Joi joi in Joi)
			{
				joi.Joint += (joi.Joint - BP).newNormalize() * Rate;
			}
		}

		public static void ScalingLef(this IEnumerable<Out> Out, double Rate)
		{
			Vector2D center = Out.GetCenter();
			foreach (Out @out in Out)
			{
				for (int i = 0; i < @out.ps.Count; i++)
				{
					if (@out.ps[i].X < center.X)
					{
						Vector2D value = @out.ps[i];
						value.X *= Rate;
						@out.ps[i] = value;
					}
				}
			}
		}

		public static void ScalingRig(this IEnumerable<Out> Out, double Rate)
		{
			Vector2D center = Out.GetCenter();
			foreach (Out @out in Out)
			{
				for (int i = 0; i < @out.ps.Count; i++)
				{
					if (@out.ps[i].X > center.X)
					{
						Vector2D value = @out.ps[i];
						value.X *= Rate;
						@out.ps[i] = value;
					}
				}
			}
		}

		public static void ScalingTop(this IEnumerable<Out> Out, double Rate)
		{
			Vector2D center = Out.GetCenter();
			foreach (Out @out in Out)
			{
				for (int i = 0; i < @out.ps.Count; i++)
				{
					if (@out.ps[i].Y < center.Y)
					{
						Vector2D value = @out.ps[i];
						value.Y *= Rate;
						@out.ps[i] = value;
					}
				}
			}
		}

		public static void ScalingBot(this IEnumerable<Out> Out, double Rate)
		{
			Vector2D center = Out.GetCenter();
			foreach (Out @out in Out)
			{
				for (int i = 0; i < @out.ps.Count; i++)
				{
					if (@out.ps[i].Y > center.Y)
					{
						Vector2D value = @out.ps[i];
						value.Y *= Rate;
						@out.ps[i] = value;
					}
				}
			}
		}

		public static void ScalingLef(this IEnumerable<Joi> Joi, double Rate)
		{
			Vector2D center = Joi.GetCenter();
			foreach (Joi joi in Joi)
			{
				if (joi.Joint.X < center.X)
				{
					Joi joi2 = joi;
					joi2.Joint.X = joi2.Joint.X * Rate;
				}
			}
		}

		public static void ScalingRig(this IEnumerable<Joi> Joi, double Rate)
		{
			Vector2D center = Joi.GetCenter();
			foreach (Joi joi in Joi)
			{
				if (joi.Joint.X > center.X)
				{
					Joi joi2 = joi;
					joi2.Joint.X = joi2.Joint.X * Rate;
				}
			}
		}

		public static void ScalingTop(this IEnumerable<Joi> Joi, double Rate)
		{
			Vector2D center = Joi.GetCenter();
			foreach (Joi joi in Joi)
			{
				if (joi.Joint.Y < center.Y)
				{
					Joi joi2 = joi;
					joi2.Joint.Y = joi2.Joint.Y * Rate;
				}
			}
		}

		public static void ScalingBot(this IEnumerable<Joi> Joi, double Rate)
		{
			Vector2D center = Joi.GetCenter();
			foreach (Joi joi in Joi)
			{
				if (joi.Joint.Y > center.Y)
				{
					Joi joi2 = joi;
					joi2.Joint.Y = joi2.Joint.Y * Rate;
				}
			}
		}

		public static IEnumerable<Vector2D> EnumPoints(this IEnumerable<Out> Out)
		{
			HashSet<Vector2D> hs = new HashSet<Vector2D>();
			foreach (Out @out in Out)
			{
				foreach (Vector2D p in @out.ps)
				{
					if (!hs.Contains(p))
					{
						yield return p;
						hs.Add(p);
					}
				}
				List<Vector2D>.Enumerator enumerator2 = default(List<Vector2D>.Enumerator);
			}
			IEnumerator<Out> enumerator = null;
			yield break;
			yield break;
		}

		public static IEnumerable<Out> EnumRange(this List<Out> Out, int s, int e)
		{
			int num;
			for (int i = s; i <= e; i = num + 1)
			{
				yield return Out[i];
				num = i;
			}
			yield break;
		}

		public static Out GetSide(Vector2D ps, Vector2D pe, int num)
		{
			Out @out = new Out();
			Vector2D right = (pe - ps) / ((double)num + 1.0);
			@out.ps.Add(ps);
			for (int i = 0; i < num; i++)
			{
				@out.ps.Add(@out.ps[i] + right);
			}
			@out.ps.Add(pe);
			return @out;
		}

		public static Out GetSide(ref Vector2D ps, ref Vector2D pe, int num)
		{
			Out @out = new Out();
			Vector2D right = (pe - ps) / ((double)num + 1.0);
			@out.ps.Add(ps);
			for (int i = 0; i < num; i++)
			{
				@out.ps.Add(@out.ps[i] + right);
			}
			@out.ps.Add(pe);
			return @out;
		}

		public static Out[] GetSides(Vector2D ps, Vector2D pe, int num)
		{
			Out[] array = new Out[num];
			Vector2D right = (pe - ps) / (double)num;
			Vector2D vector2D = ps;
			for (int i = 0; i < num; i++)
			{
				array[i] = Shas.GetSide(vector2D, vector2D += right, 1);
			}
			array.Last<Out>().ps[2] = pe;
			return array;
		}

		public static Out[] GetSides(ref Vector2D ps, ref Vector2D pe, int num)
		{
			Out[] array = new Out[num];
			Vector2D right = (pe - ps) / (double)num;
			Vector2D vector2D = ps;
			for (int i = 0; i < num; i++)
			{
				array[i] = Shas.GetSide(vector2D, vector2D += right, 1);
			}
			array.Last<Out>().ps[2] = pe;
			return array;
		}

		public static Out GetSemicircle(Vector2D ps, Vector2D pe, int num, bool Direction, out Vector2D Center)
		{
			Out @out = new Out();
			Center = (ps + pe) * 0.5;
			MatrixD transform = ((Direction ? 180.0 : -180.0) / ((double)num + 1.0)).ToRadian().RotationZ();
			@out.ps.Add(ps);
			for (int i = 0; i < num; i++)
			{
				@out.ps.Add(@out.ps.Last<Vector2D>().TransformCoordinateBP(Center, transform));
			}
			@out.ps.Add(pe);
			return @out;
		}

		public static Out GetSemicircle(ref Vector2D ps, ref Vector2D pe, int num, bool Direction, out Vector2D Center)
		{
			Out @out = new Out();
			Center = (ps + pe) * 0.5;
			MatrixD transform = ((Direction ? 180.0 : -180.0) / ((double)num + 1.0)).ToRadian().RotationZ();
			@out.ps.Add(ps);
			for (int i = 0; i < num; i++)
			{
				@out.ps.Add(@out.ps.Last<Vector2D>().TransformCoordinateBP(Center, transform));
			}
			@out.ps.Add(pe);
			return @out;
		}

		public static Out[] GetSemicircles(Vector2D ps, Vector2D pe, int num, bool Direction, out Vector2D Center)
		{
			Out[] array = new Out[num];
			Center = (ps + pe) * 0.5;
			MatrixD matrixD = ((Direction ? 180.0 : -180.0) / (double)num).ToRadian().RotationZ();
			Vector2D ps2 = ps;
			for (int i = 0; i < num; i++)
			{
				array[i] = Shas.GetSide(ps2, ps2 = Mat.TransformCoordinateBP(ref ps2, ref Center, ref matrixD), 1);
			}
			array.Last<Out>().ps[2] = pe;
			return array;
		}

		public static Out[] GetSemicircles(ref Vector2D ps, ref Vector2D pe, int num, bool Direction, out Vector2D Center)
		{
			Out[] array = new Out[num];
			Center = (ps + pe) * 0.5;
			MatrixD matrixD = ((Direction ? 180.0 : -180.0) / (double)num).ToRadian().RotationZ();
			Vector2D ps2 = ps;
			for (int i = 0; i < num; i++)
			{
				array[i] = Shas.GetSide(ps2, ps2 = Mat.TransformCoordinateBP(ref ps2, ref Center, ref matrixD), 1);
			}
			array.Last<Out>().ps[2] = pe;
			return array;
		}

		public static Out GetPolygon(int num)
		{
			Out @out = new Out
			{
				Tension = 0f
			};
			MatrixD matrixD = (360.0 / (double)num).ToRadian().RotationZ();
			Vector2D vector2D = Shas.中央上端;
			for (int i = 0; i < num; i++)
			{
				@out.ps.Add(vector2D = Mat.TransformCoordinateBP(ref vector2D, ref Shas.中央中央, ref matrixD));
			}
			return @out;
		}

		public static Out[] GetPolygons(int num)
		{
			Out[] array = new Out[num];
			MatrixD matrixD = (360.0 / (double)num).ToRadian().RotationZ();
			Vector2D ps = Shas.中央上端;
			for (int i = 0; i < num; i++)
			{
				array[i] = Shas.GetSide(ps, ps = Mat.TransformCoordinateBP(ref ps, ref Shas.中央中央, ref matrixD), 1);
			}
			return array;
		}

		public static Out Get三角形()
		{
			return new Out
			{
				Tension = 0f,
				ps = 
				{
					Shas.TP1,
					Shas.TP2,
					Shas.TP3
				}
			};
		}

		public static Out Get正方形()
		{
			return new Out
			{
				Tension = 0f,
				ps = 
				{
					Shas.左端上端,
					Shas.右端上端,
					Shas.右端下端,
					Shas.左端下端
				}
			};
		}

		public static Out Get円形()
		{
			Out @out = new Out();
			double num = 10.0;
			MatrixD transform = (360.0 / num).ToRadian().RotationZ();
			@out.ps.Add(Shas.中央上端);
			int num2 = 1;
			while ((double)num2 < num)
			{
				@out.ps.Add(@out.ps.Last<Vector2D>().TransformCoordinateBP(Shas.中央中央, transform));
				num2++;
			}
			return @out;
		}

		public static readonly double D3 = 0.3333333333333333;

		public static readonly double D3_2 = 0.6666666666666666;

		public static Vector2D 左端上端 = Dat.Vec2DZero;

		public static Vector2D 中央上端 = new Vector2D(0.5, 0.0);

		public static Vector2D 左寄上端 = new Vector2D(Shas.D3, 0.0);

		public static Vector2D 右寄上端 = new Vector2D(Shas.D3_2, 0.0);

		public static Vector2D 右端上端 = new Vector2D(1.0, 0.0);

		public static Vector2D 左端中央 = new Vector2D(0.0, 0.5);

		public static Vector2D 中央中央 = new Vector2D(0.5, 0.5);

		public static Vector2D 左寄中央 = new Vector2D(Shas.D3, 0.5);

		public static Vector2D 右寄中央 = new Vector2D(Shas.D3_2, 0.5);

		public static Vector2D 右端中央 = new Vector2D(1.0, 0.5);

		public static Vector2D 左端上寄 = new Vector2D(0.0, Shas.D3);

		public static Vector2D 中央上寄 = new Vector2D(0.5, Shas.D3);

		public static Vector2D 左寄上寄 = new Vector2D(Shas.D3, Shas.D3);

		public static Vector2D 右寄上寄 = new Vector2D(Shas.D3_2, Shas.D3);

		public static Vector2D 右端上寄 = new Vector2D(1.0, Shas.D3);

		public static Vector2D 左端下寄 = new Vector2D(0.0, Shas.D3_2);

		public static Vector2D 中央下寄 = new Vector2D(0.5, Shas.D3_2);

		public static Vector2D 左寄下寄 = new Vector2D(Shas.D3, Shas.D3_2);

		public static Vector2D 右寄下寄 = new Vector2D(Shas.D3_2, Shas.D3_2);

		public static Vector2D 右端下寄 = new Vector2D(1.0, Shas.D3_2);

		public static Vector2D 左端下端 = new Vector2D(0.0, 1.0);

		public static Vector2D 中央下端 = new Vector2D(0.5, 1.0);

		public static Vector2D 左寄下端 = new Vector2D(Shas.D3, 1.0);

		public static Vector2D 右寄下端 = new Vector2D(Shas.D3_2, 1.0);

		public static Vector2D 右端下端 = Dat.Vec2DOne;

		private static MatrixD m120 = 120.0.ToRadian().RotationZ();

		private static MatrixD m240 = 240.0.ToRadian().RotationZ();

		public static Vector2D TP1 = Shas.中央上端;

		public static Vector2D TP2 = Shas.GetTP2();

		public static Vector2D TP3 = Shas.GetTP3();

		public static Vector2D TP1_2 = (Shas.TP1 + Shas.TP2) * 0.5;

		public static Vector2D TP2_3 = (Shas.TP2 + Shas.TP3) * 0.5;

		public static Vector2D TP3_1 = (Shas.TP3 + Shas.TP1) * 0.5;
	}
}
