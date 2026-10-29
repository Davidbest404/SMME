using System;
using System.Globalization;

namespace _2DGAMELIB
{
	[Serializable]
	public struct MatrixD
	{
		public MatrixD(double M11, double M12, double M13, double M14, double M21, double M22, double M23, double M24, double M31, double M32, double M33, double M34, double M41, double M42, double M43, double M44)
		{
			this.M11 = M11;
			this.M12 = M12;
			this.M13 = M13;
			this.M14 = M14;
			this.M21 = M21;
			this.M22 = M22;
			this.M23 = M23;
			this.M24 = M24;
			this.M31 = M31;
			this.M32 = M32;
			this.M33 = M33;
			this.M34 = M34;
			this.M41 = M41;
			this.M42 = M42;
			this.M43 = M43;
			this.M44 = M44;
		}

		public double this[int row, int col]
		{
			get
			{
				switch (row)
				{
				case 0:
					switch (col)
					{
					case 0:
						return this.M11;
					case 1:
						return this.M12;
					case 2:
						return this.M13;
					case 3:
						return this.M14;
					default:
						this.error(row, col);
						return 0.0;
					}
					break;
				case 1:
					switch (col)
					{
					case 0:
						return this.M21;
					case 1:
						return this.M22;
					case 2:
						return this.M23;
					case 3:
						return this.M24;
					default:
						this.error(row, col);
						return 0.0;
					}
					break;
				case 2:
					switch (col)
					{
					case 0:
						return this.M31;
					case 1:
						return this.M32;
					case 2:
						return this.M33;
					case 3:
						return this.M34;
					default:
						this.error(row, col);
						return 0.0;
					}
					break;
				case 3:
					switch (col)
					{
					case 0:
						return this.M41;
					case 1:
						return this.M42;
					case 2:
						return this.M43;
					case 3:
						return this.M44;
					default:
						this.error(row, col);
						return 0.0;
					}
					break;
				default:
					this.error(row, col);
					return 0.0;
				}
			}
			set
			{
				switch (row)
				{
				case 0:
					switch (col)
					{
					case 0:
						this.M11 = value;
						return;
					case 1:
						this.M12 = value;
						return;
					case 2:
						this.M13 = value;
						return;
					case 3:
						this.M14 = value;
						return;
					default:
						this.error(row, col);
						return;
					}
					break;
				case 1:
					switch (col)
					{
					case 0:
						this.M21 = value;
						return;
					case 1:
						this.M22 = value;
						return;
					case 2:
						this.M23 = value;
						return;
					case 3:
						this.M24 = value;
						return;
					default:
						this.error(row, col);
						return;
					}
					break;
				case 2:
					switch (col)
					{
					case 0:
						this.M31 = value;
						return;
					case 1:
						this.M32 = value;
						return;
					case 2:
						this.M33 = value;
						return;
					case 3:
						this.M34 = value;
						return;
					default:
						this.error(row, col);
						return;
					}
					break;
				case 3:
					switch (col)
					{
					case 0:
						this.M41 = value;
						return;
					case 1:
						this.M42 = value;
						return;
					case 2:
						this.M43 = value;
						return;
					case 3:
						this.M44 = value;
						return;
					default:
						this.error(row, col);
						return;
					}
					break;
				default:
					this.error(row, col);
					return;
				}
			}
		}

		private void error(int row, int col)
		{
			if (row < 0 || row > 3)
			{
				throw new ArgumentOutOfRangeException("row", "Rows and columns for matrices run from 0 to 3, inclusive.");
			}
			if (col < 0 || col > 3)
			{
				throw new ArgumentOutOfRangeException("col", "Rows and columns for matrices run from 0 to 3, inclusive.");
			}
		}

		public Vector4D GetRow(int row)
		{
			return new Vector4D(this[row, 0], this[row, 1], this[row, 2], this[row, 3]);
		}

		public void SetRow(int row, Vector4D value)
		{
			this[row, 0] = value.X;
			this[row, 1] = value.Y;
			this[row, 2] = value.Z;
			this[row, 3] = value.W;
		}

		public void SetRow(int row, ref Vector4D value)
		{
			this[row, 0] = value.X;
			this[row, 1] = value.Y;
			this[row, 2] = value.Z;
			this[row, 3] = value.W;
		}

		public Vector4D GetCol(int column)
		{
			return new Vector4D(this[0, column], this[1, column], this[2, column], this[3, column]);
		}

		public void SetCol(int column, Vector4D value)
		{
			this[0, column] = value.X;
			this[1, column] = value.Y;
			this[2, column] = value.Z;
			this[3, column] = value.W;
		}

		public void SetCol(int column, ref Vector4D value)
		{
			this[0, column] = value.X;
			this[1, column] = value.Y;
			this[2, column] = value.Z;
			this[3, column] = value.W;
		}

		public static MatrixD Identity
		{
			get
			{
				return new MatrixD
				{
					M11 = 1.0,
					M22 = 1.0,
					M33 = 1.0,
					M44 = 1.0
				};
			}
		}

		public bool IsIdentity
		{
			get
			{
				return this.M11 == 1.0 && this.M22 == 1.0 && this.M33 == 1.0 && this.M44 == 1.0 && this.M12 == 0.0 && this.M13 == 0.0 && this.M14 == 0.0 && this.M21 == 0.0 && this.M23 == 0.0 && this.M24 == 0.0 && this.M31 == 0.0 && this.M32 == 0.0 && this.M34 == 0.0 && this.M41 == 0.0 && this.M42 == 0.0 && this.M43 == 0.0;
			}
		}

		public double[] ToArray()
		{
			return new double[]
			{
				this.M11,
				this.M12,
				this.M13,
				this.M14,
				this.M21,
				this.M22,
				this.M23,
				this.M24,
				this.M31,
				this.M32,
				this.M33,
				this.M34,
				this.M41,
				this.M42,
				this.M43,
				this.M44
			};
		}

		public void Invert()
		{
			MatrixD matDIdentity = Dat.MatDIdentity;
			for (int i = 0; i < 4; i++)
			{
				double num = 1.0 / this[i, i];
				for (int j = 0; j < 4; j++)
				{
					int num2 = i;
					int num3 = j;
					this[num2, num3] *= num;
					ref MatrixD ptr = ref matDIdentity;
					num3 = i;
					num2 = j;
					ptr[num3, num2] *= num;
				}
				for (int j = 0; j < 4; j++)
				{
					if (i != j)
					{
						num = this[j, i];
						for (int k = 0; k < 4; k++)
						{
							int num2 = j;
							int num3 = k;
							this[num2, num3] -= this[i, k] * num;
							ref MatrixD ptr = ref matDIdentity;
							num3 = j;
							num2 = k;
							ptr[num3, num2] -= matDIdentity[i, k] * num;
						}
					}
				}
			}
			this = matDIdentity;
		}

		public double Determinant()
		{
			double num = this.M33 * this.M44 - this.M34 * this.M43;
			double num2 = this.M32 * this.M44 - this.M34 * this.M42;
			double num3 = this.M32 * this.M43 - this.M33 * this.M42;
			double num4 = this.M31 * this.M44 - this.M34 * this.M41;
			double num5 = this.M31 * this.M43 - this.M33 * this.M41;
			double num6 = this.M31 * this.M42 - this.M32 * this.M41;
			return this.M11 * (this.M22 * num - this.M23 * num2 + this.M24 * num3) - this.M12 * (this.M21 * num - this.M23 * num4 + this.M24 * num5) + this.M13 * (this.M21 * num2 - this.M22 * num4 + this.M24 * num6) - this.M14 * (this.M21 * num3 - this.M22 * num5 + this.M23 * num6);
		}

		public static MatrixD operator +(MatrixD left, MatrixD right)
		{
			MatrixD result;
			result.M11 = left.M11 + right.M11;
			result.M12 = left.M12 + right.M12;
			result.M13 = left.M13 + right.M13;
			result.M14 = left.M14 + right.M14;
			result.M21 = left.M21 + right.M21;
			result.M22 = left.M22 + right.M22;
			result.M23 = left.M23 + right.M23;
			result.M24 = left.M24 + right.M24;
			result.M31 = left.M31 + right.M31;
			result.M32 = left.M32 + right.M32;
			result.M33 = left.M33 + right.M33;
			result.M34 = left.M34 + right.M34;
			result.M41 = left.M41 + right.M41;
			result.M42 = left.M42 + right.M42;
			result.M43 = left.M43 + right.M43;
			result.M44 = left.M44 + right.M44;
			return result;
		}

		public static MatrixD operator -(MatrixD left, MatrixD right)
		{
			MatrixD result;
			result.M11 = left.M11 - right.M11;
			result.M12 = left.M12 - right.M12;
			result.M13 = left.M13 - right.M13;
			result.M14 = left.M14 - right.M14;
			result.M21 = left.M21 - right.M21;
			result.M22 = left.M22 - right.M22;
			result.M23 = left.M23 - right.M23;
			result.M24 = left.M24 - right.M24;
			result.M31 = left.M31 - right.M31;
			result.M32 = left.M32 - right.M32;
			result.M33 = left.M33 - right.M33;
			result.M34 = left.M34 - right.M34;
			result.M41 = left.M41 - right.M41;
			result.M42 = left.M42 - right.M42;
			result.M43 = left.M43 - right.M43;
			result.M44 = left.M44 - right.M44;
			return result;
		}

		public static MatrixD operator -(MatrixD matrix)
		{
			MatrixD result;
			result.M11 = -matrix.M11;
			result.M12 = -matrix.M12;
			result.M13 = -matrix.M13;
			result.M14 = -matrix.M14;
			result.M21 = -matrix.M21;
			result.M22 = -matrix.M22;
			result.M23 = -matrix.M23;
			result.M24 = -matrix.M24;
			result.M31 = -matrix.M31;
			result.M32 = -matrix.M32;
			result.M33 = -matrix.M33;
			result.M34 = -matrix.M34;
			result.M41 = -matrix.M41;
			result.M42 = -matrix.M42;
			result.M43 = -matrix.M43;
			result.M44 = -matrix.M44;
			return result;
		}

		public static MatrixD operator *(MatrixD left, MatrixD right)
		{
			MatrixD result;
			result.M11 = left.M11 * right.M11 + left.M12 * right.M21 + left.M13 * right.M31 + left.M14 * right.M41;
			result.M12 = left.M11 * right.M12 + left.M12 * right.M22 + left.M13 * right.M32 + left.M14 * right.M42;
			result.M13 = left.M11 * right.M13 + left.M12 * right.M23 + left.M13 * right.M33 + left.M14 * right.M43;
			result.M14 = left.M11 * right.M14 + left.M12 * right.M24 + left.M13 * right.M34 + left.M14 * right.M44;
			result.M21 = left.M21 * right.M11 + left.M22 * right.M21 + left.M23 * right.M31 + left.M24 * right.M41;
			result.M22 = left.M21 * right.M12 + left.M22 * right.M22 + left.M23 * right.M32 + left.M24 * right.M42;
			result.M23 = left.M21 * right.M13 + left.M22 * right.M23 + left.M23 * right.M33 + left.M24 * right.M43;
			result.M24 = left.M21 * right.M14 + left.M22 * right.M24 + left.M23 * right.M34 + left.M24 * right.M44;
			result.M31 = left.M31 * right.M11 + left.M32 * right.M21 + left.M33 * right.M31 + left.M34 * right.M41;
			result.M32 = left.M31 * right.M12 + left.M32 * right.M22 + left.M33 * right.M32 + left.M34 * right.M42;
			result.M33 = left.M31 * right.M13 + left.M32 * right.M23 + left.M33 * right.M33 + left.M34 * right.M43;
			result.M34 = left.M31 * right.M14 + left.M32 * right.M24 + left.M33 * right.M34 + left.M34 * right.M44;
			result.M41 = left.M41 * right.M11 + left.M42 * right.M21 + left.M43 * right.M31 + left.M44 * right.M41;
			result.M42 = left.M41 * right.M12 + left.M42 * right.M22 + left.M43 * right.M32 + left.M44 * right.M42;
			result.M43 = left.M41 * right.M13 + left.M42 * right.M23 + left.M43 * right.M33 + left.M44 * right.M43;
			result.M44 = left.M41 * right.M14 + left.M42 * right.M24 + left.M43 * right.M34 + left.M44 * right.M44;
			return result;
		}

		public static MatrixD operator *(MatrixD left, double right)
		{
			MatrixD result;
			result.M11 = left.M11 * right;
			result.M12 = left.M12 * right;
			result.M13 = left.M13 * right;
			result.M14 = left.M14 * right;
			result.M21 = left.M21 * right;
			result.M22 = left.M22 * right;
			result.M23 = left.M23 * right;
			result.M24 = left.M24 * right;
			result.M31 = left.M31 * right;
			result.M32 = left.M32 * right;
			result.M33 = left.M33 * right;
			result.M34 = left.M34 * right;
			result.M41 = left.M41 * right;
			result.M42 = left.M42 * right;
			result.M43 = left.M43 * right;
			result.M44 = left.M44 * right;
			return result;
		}

		public static MatrixD operator *(double right, MatrixD left)
		{
			MatrixD result;
			result.M11 = left.M11 * right;
			result.M12 = left.M12 * right;
			result.M13 = left.M13 * right;
			result.M14 = left.M14 * right;
			result.M21 = left.M21 * right;
			result.M22 = left.M22 * right;
			result.M23 = left.M23 * right;
			result.M24 = left.M24 * right;
			result.M31 = left.M31 * right;
			result.M32 = left.M32 * right;
			result.M33 = left.M33 * right;
			result.M34 = left.M34 * right;
			result.M41 = left.M41 * right;
			result.M42 = left.M42 * right;
			result.M43 = left.M43 * right;
			result.M44 = left.M44 * right;
			return result;
		}

		public static MatrixD operator /(MatrixD left, MatrixD right)
		{
			MatrixD result;
			result.M11 = left.M11 / right.M11;
			result.M12 = left.M12 / right.M12;
			result.M13 = left.M13 / right.M13;
			result.M14 = left.M14 / right.M14;
			result.M21 = left.M21 / right.M21;
			result.M22 = left.M22 / right.M22;
			result.M23 = left.M23 / right.M23;
			result.M24 = left.M24 / right.M24;
			result.M31 = left.M31 / right.M31;
			result.M32 = left.M32 / right.M32;
			result.M33 = left.M33 / right.M33;
			result.M34 = left.M34 / right.M34;
			result.M41 = left.M41 / right.M41;
			result.M42 = left.M42 / right.M42;
			result.M43 = left.M43 / right.M43;
			result.M44 = left.M44 / right.M44;
			return result;
		}

		public static MatrixD operator /(MatrixD left, double right)
		{
			MatrixD result;
			result.M11 = left.M11 / right;
			result.M12 = left.M12 / right;
			result.M13 = left.M13 / right;
			result.M14 = left.M14 / right;
			result.M21 = left.M21 / right;
			result.M22 = left.M22 / right;
			result.M23 = left.M23 / right;
			result.M24 = left.M24 / right;
			result.M31 = left.M31 / right;
			result.M32 = left.M32 / right;
			result.M33 = left.M33 / right;
			result.M34 = left.M34 / right;
			result.M41 = left.M41 / right;
			result.M42 = left.M42 / right;
			result.M43 = left.M43 / right;
			result.M44 = left.M44 / right;
			return result;
		}

		public static bool operator ==(MatrixD left, MatrixD right)
		{
			return left.M11 == right.M11 && left.M12 == right.M12 && left.M13 == right.M13 && left.M14 == right.M14 && left.M21 == right.M21 && left.M22 == right.M22 && left.M23 == right.M23 && left.M24 == right.M24 && left.M31 == right.M31 && left.M32 == right.M32 && left.M33 == right.M33 && left.M34 == right.M34 && left.M41 == right.M41 && left.M42 == right.M42 && left.M43 == right.M43 && left.M44 == right.M44;
		}

		public static bool operator !=(MatrixD left, MatrixD right)
		{
			return left.M11 != right.M11 || left.M12 != right.M12 || left.M13 != right.M13 || left.M14 != right.M14 || left.M21 != right.M21 || left.M22 != right.M22 || left.M23 != right.M23 || left.M24 != right.M24 || left.M31 != right.M31 || left.M32 != right.M32 || left.M33 != right.M33 || left.M34 != right.M34 || left.M41 != right.M41 || left.M42 != right.M42 || left.M43 != right.M43 || left.M44 != right.M44;
		}

		public override string ToString()
		{
			return string.Format(CultureInfo.CurrentCulture, "[M11:{0} M12:{1} M13:{2} M14:{3}] [M21:{4} M22:{5} M23:{6} M24:{7}] [M31:{8} M32:{9} M33:{10} M34:{11}] [M41:{12} M42:{13} M43:{14} M44:{15}]", new object[]
			{
				this.M11.ToString(CultureInfo.CurrentCulture),
				this.M12.ToString(CultureInfo.CurrentCulture),
				this.M13.ToString(CultureInfo.CurrentCulture),
				this.M14.ToString(CultureInfo.CurrentCulture),
				this.M21.ToString(CultureInfo.CurrentCulture),
				this.M22.ToString(CultureInfo.CurrentCulture),
				this.M23.ToString(CultureInfo.CurrentCulture),
				this.M24.ToString(CultureInfo.CurrentCulture),
				this.M31.ToString(CultureInfo.CurrentCulture),
				this.M32.ToString(CultureInfo.CurrentCulture),
				this.M33.ToString(CultureInfo.CurrentCulture),
				this.M34.ToString(CultureInfo.CurrentCulture),
				this.M41.ToString(CultureInfo.CurrentCulture),
				this.M42.ToString(CultureInfo.CurrentCulture),
				this.M43.ToString(CultureInfo.CurrentCulture),
				this.M44.ToString(CultureInfo.CurrentCulture)
			});
		}

		public override int GetHashCode()
		{
			return this.M11.GetHashCode() + this.M12.GetHashCode() + this.M13.GetHashCode() + this.M14.GetHashCode() + this.M21.GetHashCode() + this.M22.GetHashCode() + this.M23.GetHashCode() + this.M24.GetHashCode() + this.M31.GetHashCode() + this.M32.GetHashCode() + this.M33.GetHashCode() + this.M34.GetHashCode() + this.M41.GetHashCode() + this.M42.GetHashCode() + this.M43.GetHashCode() + this.M44.GetHashCode();
		}

		public override bool Equals(object value)
		{
			return value != null && !(value.GetType() != base.GetType()) && this.Equals((MatrixD)value);
		}

		public bool Equals(MatrixD value)
		{
			return this.M11 == value.M11 && this.M12 == value.M12 && this.M13 == value.M13 && this.M14 == value.M14 && this.M21 == value.M21 && this.M22 == value.M22 && this.M23 == value.M23 && this.M24 == value.M24 && this.M31 == value.M31 && this.M32 == value.M32 && this.M33 == value.M33 && this.M34 == value.M34 && this.M41 == value.M41 && this.M42 == value.M42 && this.M43 == value.M43 && this.M44 == value.M44;
		}

		public bool Equals(ref MatrixD value)
		{
			return this.M11 == value.M11 && this.M12 == value.M12 && this.M13 == value.M13 && this.M14 == value.M14 && this.M21 == value.M21 && this.M22 == value.M22 && this.M23 == value.M23 && this.M24 == value.M24 && this.M31 == value.M31 && this.M32 == value.M32 && this.M33 == value.M33 && this.M34 == value.M34 && this.M41 == value.M41 && this.M42 == value.M42 && this.M43 == value.M43 && this.M44 == value.M44;
		}

		public double M11;

		public double M12;

		public double M13;

		public double M14;

		public double M21;

		public double M22;

		public double M23;

		public double M24;

		public double M31;

		public double M32;

		public double M33;

		public double M34;

		public double M41;

		public double M42;

		public double M43;

		public double M44;
	}
}
