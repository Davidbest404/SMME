using System;
using System.Globalization;

namespace _2DGAMELIB
{
	[Serializable]
	public struct Vector2D
	{
		public Vector2D(int value)
		{
			this.X = (double)value;
			this.Y = (double)value;
		}

		public Vector2D(float value)
		{
			this.X = (double)value;
			this.Y = (double)value;
		}

		public Vector2D(double value)
		{
			this.X = value;
			this.Y = value;
		}

		public Vector2D(int x, int y)
		{
			this.X = (double)x;
			this.Y = (double)y;
		}

		public Vector2D(float x, float y)
		{
			this.X = (double)x;
			this.Y = (double)y;
		}

		public Vector2D(double x, double y)
		{
			this.X = x;
			this.Y = y;
		}

		public double this[int index]
		{
			get
			{
				if (index == 0)
				{
					return this.X;
				}
				if (index != 1)
				{
					throw new ArgumentOutOfRangeException("index", "Indices for Vector2D run from 0 to 1, inclusive.");
				}
				return this.Y;
			}
			set
			{
				if (index == 0)
				{
					this.X = value;
					return;
				}
				if (index != 1)
				{
					throw new ArgumentOutOfRangeException("index", "Indices for Vector2D run from 0 to 1, inclusive.");
				}
				this.Y = value;
			}
		}

		public double Length()
		{
			return Math.Sqrt(this.X * this.X + this.Y * this.Y);
		}

		public double LengthSquared()
		{
			return this.X * this.X + this.Y * this.Y;
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
		}

		public static Vector2D operator +(Vector2D left, Vector2D right)
		{
			return new Vector2D(left.X + right.X, left.Y + right.Y);
		}

		public static Vector2D operator -(Vector2D left, Vector2D right)
		{
			return new Vector2D(left.X - right.X, left.Y - right.Y);
		}

		public static Vector2D operator -(Vector2D value)
		{
			return new Vector2D(-value.X, -value.Y);
		}

		public static Vector2D operator *(Vector2D value, double scale)
		{
			return new Vector2D(value.X * scale, value.Y * scale);
		}

		public static Vector2D operator *(double scale, Vector2D value)
		{
			return new Vector2D(value.X * scale, value.Y * scale);
		}

		public static Vector2D operator /(Vector2D value, double scale)
		{
			return new Vector2D(value.X / scale, value.Y / scale);
		}

		public static bool operator ==(Vector2D left, Vector2D right)
		{
			return left.X == right.X && left.Y == right.Y;
		}

		public static bool operator !=(Vector2D left, Vector2D right)
		{
			return left.X != right.X || left.Y != right.Y;
		}

		public override string ToString()
		{
			return string.Format(CultureInfo.CurrentCulture, "X:{0} Y:{1}", new object[]
			{
				this.X.ToString(CultureInfo.CurrentCulture),
				this.Y.ToString(CultureInfo.CurrentCulture)
			});
		}

		public override int GetHashCode()
		{
			return this.X.GetHashCode() + this.Y.GetHashCode();
		}

		public override bool Equals(object value)
		{
			return value != null && !(value.GetType() != base.GetType()) && this.Equals((Vector2D)value);
		}

		public bool Equals(Vector2D value)
		{
			return this.X == value.X && this.Y == value.Y;
		}

		public bool Equals(ref Vector2D value)
		{
			return this.X == value.X && this.Y == value.Y;
		}

		public double X;

		public double Y;
	}
}
