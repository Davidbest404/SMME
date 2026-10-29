using System;
using System.Drawing;

namespace SlaveMatrix
{
	[Serializable]
	public struct Color2
	{
		public Color2(ref Color Col1, ref Color Col2)
		{
			this.Col1 = Col1;
			this.Col2 = Col2;
		}

		public void GetRep(out Color2 ret)
		{
			ret.Col1 = this.Col2;
			ret.Col2 = this.Col1;
		}

		public static bool operator ==(Color2 left, Color2 right)
		{
			return left.Col1 == right.Col1 && left.Col2 == right.Col2;
		}

		public static bool operator !=(Color2 left, Color2 right)
		{
			return !(left.Col1 == right.Col1) || !(left.Col2 == right.Col2);
		}

		public override int GetHashCode()
		{
			return this.Col1.GetHashCode() + this.Col2.GetHashCode();
		}

		public override bool Equals(object value)
		{
			return value != null && !(value.GetType().ToString() != base.GetType().ToString()) && this.Equals((Color2)value);
		}

		public bool Equals(Color2 value)
		{
			return this.Col1 == value.Col1 && this.Col2 == value.Col2;
		}

		public Color Col1;

		public Color Col2;

		public static Color2 Empty = new Color2(ref Col.Empty, ref Col.Empty);
	}
}
