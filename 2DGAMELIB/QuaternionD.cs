using System;
using System.Globalization;

namespace _2DGAMELIB
{
	[Serializable]
	public struct QuaternionD
	{
		public QuaternionD(double x, double y, double z, double w)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
			this.W = w;
		}

		public QuaternionD(Vector3D value, double w)
		{
			this.X = value.X;
			this.Y = value.Y;
			this.Z = value.Z;
			this.W = w;
		}

		public QuaternionD(ref Vector3D value, double w)
		{
			this.X = value.X;
			this.Y = value.Y;
			this.Z = value.Z;
			this.W = w;
		}

		public static QuaternionD Identity
		{
			get
			{
				QuaternionD result;
				result.X = 0.0;
				result.Y = 0.0;
				result.Z = 0.0;
				result.W = 1.0;
				return result;
			}
		}

		public bool IsIdentity
		{
			get
			{
				return this.X == 0.0 && this.Y == 0.0 && this.Z == 0.0 && this.W == 1.0;
			}
		}

		public Vector3D Axis
		{
			get
			{
				return new Vector3D(this.X, this.Y, this.Z) / Math.Sin(this.Angle * 0.5);
			}
		}

		public double Angle
		{
			get
			{
				return Math.Acos(this.W) * 2.0;
			}
		}

		public double Length()
		{
			return Math.Sqrt(this.X * this.X + this.Y * this.Y + this.Z * this.Z + this.W * this.W);
		}

		public double LengthSquared()
		{
			return this.X * this.X + this.Y * this.Y + this.Z * this.Z + this.W * this.W;
		}

		public void Normalize()
		{
			double num = 1.0 / this.Length();
			this.X *= num;
			this.Y *= num;
			this.Z *= num;
			this.W *= num;
		}

		public void Conjugate()
		{
			this.X = -this.X;
			this.Y = -this.Y;
			this.Z = -this.Z;
		}

		public void Invert()
		{
			double num = 1.0 / (this.X * this.X + this.Y * this.Y + this.Z * this.Z + this.W * this.W);
			this.X = -this.X * num;
			this.Y = -this.Y * num;
			this.Z = -this.Z * num;
			this.W *= num;
		}

		public static QuaternionD operator +(QuaternionD lhs, QuaternionD rhs)
		{
			QuaternionD result;
			result.X = lhs.X + rhs.X;
			result.Y = lhs.Y + rhs.Y;
			result.Z = lhs.Z + rhs.Z;
			result.W = lhs.W + rhs.W;
			return result;
		}

		public static QuaternionD operator -(QuaternionD lhs, QuaternionD rhs)
		{
			QuaternionD result;
			result.X = lhs.X - rhs.X;
			result.Y = lhs.Y - rhs.Y;
			result.Z = lhs.Z - rhs.Z;
			result.W = lhs.W - rhs.W;
			return result;
		}

		public static QuaternionD operator -(QuaternionD quaternion)
		{
			QuaternionD result;
			result.X = -quaternion.X;
			result.Y = -quaternion.Y;
			result.Z = -quaternion.Z;
			result.W = -quaternion.W;
			return result;
		}

		public static QuaternionD operator *(QuaternionD left, QuaternionD right)
		{
			double x = left.X;
			double y = left.Y;
			double z = left.Z;
			double w = left.W;
			double x2 = right.X;
			double y2 = right.Y;
			double z2 = right.Z;
			double w2 = right.W;
			QuaternionD result;
			result.X = x2 * w + x * w2 + y2 * z - z2 * y;
			result.Y = y2 * w + y * w2 + z2 * x - x2 * z;
			result.Z = z2 * w + z * w2 + x2 * y - y2 * x;
			result.W = w2 * w - (x2 * x + y2 * y + z2 * z);
			return result;
		}

		public static QuaternionD operator *(QuaternionD quaternion, double scale)
		{
			QuaternionD result;
			result.X = quaternion.X * scale;
			result.Y = quaternion.Y * scale;
			result.Z = quaternion.Z * scale;
			result.W = quaternion.W * scale;
			return result;
		}

		public static QuaternionD operator *(double scale, QuaternionD quaternion)
		{
			QuaternionD result;
			result.X = quaternion.X * scale;
			result.Y = quaternion.Y * scale;
			result.Z = quaternion.Z * scale;
			result.W = quaternion.W * scale;
			return result;
		}

		public static QuaternionD operator /(QuaternionD lhs, double rhs)
		{
			QuaternionD result;
			result.X = lhs.X / rhs;
			result.Y = lhs.Y / rhs;
			result.Z = lhs.Z / rhs;
			result.W = lhs.W / rhs;
			return result;
		}

		public static bool operator ==(QuaternionD left, QuaternionD right)
		{
			return left.X == right.X && left.Y == right.Y && left.Z == right.Z && left.W == right.W;
		}

		public static bool operator !=(QuaternionD left, QuaternionD right)
		{
			return left.X != right.X || left.Y != right.Y || left.Z != right.Z || left.W != right.W;
		}

		public override string ToString()
		{
			return string.Format(CultureInfo.CurrentCulture, "X:{0} Y:{1} Z:{2} W:{3}", new object[]
			{
				this.X.ToString(CultureInfo.CurrentCulture),
				this.Y.ToString(CultureInfo.CurrentCulture),
				this.Z.ToString(CultureInfo.CurrentCulture),
				this.W.ToString(CultureInfo.CurrentCulture)
			});
		}

		public override int GetHashCode()
		{
			return this.X.GetHashCode() + this.Y.GetHashCode() + this.Z.GetHashCode() + this.W.GetHashCode();
		}

		public override bool Equals(object value)
		{
			return value != null && !(value.GetType() != base.GetType()) && this.Equals((QuaternionD)value);
		}

		public bool Equals(QuaternionD value)
		{
			return this.X == value.X && this.Y == value.Y && this.Z == value.Z && this.W == value.W;
		}

		public bool Equals(ref QuaternionD value)
		{
			return this.X == value.X && this.Y == value.Y && this.Z == value.Z && this.W == value.W;
		}

		public double X;

		public double Y;

		public double Z;

		public double W;
	}
}
