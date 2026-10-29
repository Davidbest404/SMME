using System;
using System.Globalization;

namespace _2DGAMELIB
{
	[Serializable]
	public struct Vector4D
	{
		public Vector4D(double value)
		{
			this.X = value;
			this.Y = value;
			this.Z = value;
			this.W = value;
		}

		public Vector4D(Vector2D value, double z, double w)
		{
			this.X = value.X;
			this.Y = value.Y;
			this.Z = z;
			this.W = w;
		}

		public Vector4D(ref Vector2D value, double z, double w)
		{
			this.X = value.X;
			this.Y = value.Y;
			this.Z = z;
			this.W = w;
		}

		public Vector4D(Vector3D value, double w)
		{
			this.X = value.X;
			this.Y = value.Y;
			this.Z = value.Z;
			this.W = w;
		}

		public Vector4D(ref Vector3D value, double w)
		{
			this.X = value.X;
			this.Y = value.Y;
			this.Z = value.Z;
			this.W = w;
		}

		public Vector4D(double x, double y, double z, double w)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
			this.W = w;
		}

		public double this[int index]
		{
			get
			{
				switch (index)
				{
				case 0:
					return this.X;
				case 1:
					return this.Y;
				case 2:
					return this.Z;
				case 3:
					return this.W;
				default:
					throw new ArgumentOutOfRangeException("index", "Indices for Vector4D run from 0 to 3, inclusive.");
				}
			}
			set
			{
				switch (index)
				{
				case 0:
					this.X = value;
					return;
				case 1:
					this.Y = value;
					return;
				case 2:
					this.Z = value;
					return;
				case 3:
					this.W = value;
					return;
				default:
					throw new ArgumentOutOfRangeException("index", "Indices for Vector4D run from 0 to 3, inclusive.");
				}
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
			double num = this.Length();
			if (num == 0.0)
			{
				return;
			}
			double num2 = 1.0 / num;
			this.X *= num2;
			this.Y *= num2;
			this.Z *= num2;
			this.W *= num2;
		}

		public static Vector4D operator +(Vector4D left, Vector4D right)
		{
			return new Vector4D(left.X + right.X, left.Y + right.Y, left.Z + right.Z, left.W + right.W);
		}

		public static Vector4D operator -(Vector4D left, Vector4D right)
		{
			return new Vector4D(left.X - right.X, left.Y - right.Y, left.Z - right.Z, left.W - right.W);
		}

		public static Vector4D operator -(Vector4D value)
		{
			return new Vector4D(-value.X, -value.Y, -value.Z, -value.W);
		}

		public static Vector4D operator *(Vector4D value, double scale)
		{
			return new Vector4D(value.X * scale, value.Y * scale, value.Z * scale, value.W * scale);
		}

		public static Vector4D operator *(double scale, Vector4D value)
		{
			return new Vector4D(value.X * scale, value.Y * scale, value.Z * scale, value.W * scale);
		}

		public static Vector4D operator /(Vector4D value, double scale)
		{
			return new Vector4D(value.X / scale, value.Y / scale, value.Z / scale, value.W / scale);
		}

		public static bool operator ==(Vector4D left, Vector4D right)
		{
			return left.X == right.X && left.Y == right.Y && left.Z == right.Z && left.W == right.W;
		}

		public static bool operator !=(Vector4D left, Vector4D right)
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
			return value != null && !(value.GetType() != base.GetType()) && this.Equals((Vector4D)value);
		}

		public bool Equals(Vector4D value)
		{
			return this.X == value.X && this.Y == value.Y && this.Z == value.Z && this.W == value.W;
		}

		public bool Equals(ref Vector4D value)
		{
			return this.X == value.X && this.Y == value.Y && this.Z == value.Z && this.W == value.W;
		}

		public double X;

		public double Y;

		public double Z;

		public double W;
	}
}
