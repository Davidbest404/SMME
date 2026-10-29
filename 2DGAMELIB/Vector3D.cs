using System;
using System.Globalization;

namespace _2DGAMELIB
{
	[Serializable]
	public struct Vector3D
	{
		public Vector3D(double value)
		{
			this.X = value;
			this.Y = value;
			this.Z = value;
		}

		public Vector3D(Vector2D value, double z)
		{
			this.X = value.X;
			this.Y = value.Y;
			this.Z = z;
		}

		public Vector3D(ref Vector2D value, double z)
		{
			this.X = value.X;
			this.Y = value.Y;
			this.Z = z;
		}

		public Vector3D(double x, double y, double z)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
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
				default:
					throw new ArgumentOutOfRangeException("index", "Indices for Vector3D run from 0 to 2, inclusive.");
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
				default:
					throw new ArgumentOutOfRangeException("index", "Indices for Vector3D run from 0 to 2, inclusive.");
				}
			}
		}

		public double Length()
		{
			return Math.Sqrt(this.X * this.X + this.Y * this.Y + this.Z * this.Z);
		}

		public double LengthSquared()
		{
			return this.X * this.X + this.Y * this.Y + this.Z * this.Z;
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
		}

		public static Vector3D operator +(Vector3D left, Vector3D right)
		{
			return new Vector3D(left.X + right.X, left.Y + right.Y, left.Z + right.Z);
		}

		public static Vector3D operator -(Vector3D left, Vector3D right)
		{
			return new Vector3D(left.X - right.X, left.Y - right.Y, left.Z - right.Z);
		}

		public static Vector3D operator -(Vector3D value)
		{
			return new Vector3D(-value.X, -value.Y, -value.Z);
		}

		public static Vector3D operator *(Vector3D value, double scale)
		{
			return new Vector3D(value.X * scale, value.Y * scale, value.Z * scale);
		}

		public static Vector3D operator *(double scale, Vector3D value)
		{
			return new Vector3D(value.X * scale, value.Y * scale, value.Z * scale);
		}

		public static Vector3D operator /(Vector3D value, double scale)
		{
			return new Vector3D(value.X / scale, value.Y / scale, value.Z / scale);
		}

		public static bool operator ==(Vector3D left, Vector3D right)
		{
			return left.X == right.X && left.Y == right.Y && left.Z == right.Z;
		}

		public static bool operator !=(Vector3D left, Vector3D right)
		{
			return left.X != right.X || left.Y != right.Y || left.Z != right.Z;
		}

		public override string ToString()
		{
			return string.Format(CultureInfo.CurrentCulture, "X:{0} Y:{1} Z:{2}", new object[]
			{
				this.X.ToString(CultureInfo.CurrentCulture),
				this.Y.ToString(CultureInfo.CurrentCulture),
				this.Z.ToString(CultureInfo.CurrentCulture)
			});
		}

		public override int GetHashCode()
		{
			return this.X.GetHashCode() + this.Y.GetHashCode() + this.Z.GetHashCode();
		}

		public override bool Equals(object value)
		{
			return value != null && !(value.GetType() != base.GetType()) && this.Equals((Vector3D)value);
		}

		public bool Equals(Vector3D value)
		{
			return this.X == value.X && this.Y == value.Y && this.Z == value.Z;
		}

		public bool Equals(ref Vector3D value)
		{
			return this.X == value.X && this.Y == value.Y && this.Z == value.Z;
		}

		public double X;

		public double Y;

		public double Z;
	}
}
