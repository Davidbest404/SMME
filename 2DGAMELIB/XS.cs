using System;

namespace _2DGAMELIB
{
	public class XS : Random
	{
		protected uint InitMtSub(uint s, uint i)
		{
			return 1812433253U * (s ^ s >> 30) + i + 1U;
		}

		public void Initialize(uint s)
		{
			this.x = this.InitMtSub(s, 0U);
			this.y = this.InitMtSub(this.x, 1U);
			this.z = this.InitMtSub(this.y, 2U);
			this.w = this.InitMtSub(this.z, 3U);
		}

		public XS(uint s)
		{
			this.Initialize(s);
		}

		public XS() : this(4357U)
		{
		}

		public void Initialize(uint[] key)
		{
			uint num = (uint)key.Length;
			uint[] array = new uint[4];
			this.Initialize(1U);
			array[0] = this.x;
			array[1] = this.y;
			array[2] = this.z;
			array[3] = this.w;
			uint s = this.w;
			uint num2;
			for (num2 = 0U; num2 < num; num2 += 1U)
			{
				array[(int)(num2 & 3U)] ^= (s = this.InitMtSub(s, key[(int)num2] + num2));
			}
			uint num3 = 0U;
			while (num3 < 3U)
			{
				array[(int)(num2 & 3U)] ^= (s = this.InitMtSub(s, num3));
				num3 += 1U;
				num2 += 1U;
			}
			this.x = array[0];
			this.y = array[1];
			this.z = array[2];
			this.w = array[3];
			if (this.x == 0U && this.y == 0U && this.z == 0U && this.w == 0U)
			{
				this.x = 1U;
			}
		}

		public XS(uint[] key)
		{
			this.Initialize(key);
		}

		public uint NextUint()
		{
			uint num = this.x ^ this.x << 11;
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			return this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8);
		}

		public void NextUint(out uint o)
		{
			uint num = this.x ^ this.x << 11;
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			o = (this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8));
		}

		public uint NextUint(uint les)
		{
			uint num = this.x ^ this.x << 11;
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			return (uint)(les * 2.3283064365386963E-10 * (this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)));
		}

		public void NextUint(uint les, out uint o)
		{
			uint num = this.x ^ this.x << 11;
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			o = (uint)(les * 2.3283064365386963E-10 * (this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)));
		}

		public uint NextUint(uint sta, uint les)
		{
			uint num = this.x ^ this.x << 11;
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			return (uint)((les - sta) * 2.3283064365386963E-10 * (this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8))) + sta;
		}

		public void NextUint(uint sta, uint les, out uint o)
		{
			uint num = this.x ^ this.x << 11;
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			o = (uint)((les - sta) * 2.3283064365386963E-10 * (this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8))) + sta;
		}

		public uint NextUintM(uint max)
		{
			uint num = this.x ^ this.x << 11;
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			return (uint)(((ulong)max + 1UL) * 2.3283064365386963E-10 * (this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)));
		}

		public void NextUintM(uint max, out uint o)
		{
			uint num = this.x ^ this.x << 11;
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			o = (uint)(((ulong)max + 1UL) * 2.3283064365386963E-10 * (this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)));
		}

		public uint NextUintM(uint min, uint max)
		{
			uint num = this.x ^ this.x << 11;
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			return (uint)(((ulong)(max - min) + 1UL) * 2.3283064365386963E-10 * (this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8))) + min;
		}

		public void NextUintM(uint min, uint max, out uint o)
		{
			uint num = this.x ^ this.x << 11;
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			o = (uint)(((ulong)(max - min) + 1UL) * 2.3283064365386963E-10 * (this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8))) + min;
		}

		public override int Next()
		{
			uint num = this.x ^ this.x << 11;
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			return (int)(0.5 * (this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)));
		}

		public void Next(out int o)
		{
			uint num = this.x ^ this.x << 11;
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			o = (int)(0.5 * (this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)));
		}

		public override int Next(int les)
		{
			uint num = this.x ^ this.x << 11;
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			return (int)((double)les * 2.3283064365386963E-10 * (this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)));
		}

		public void Next(int les, out int o)
		{
			uint num = this.x ^ this.x << 11;
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			o = (int)((double)les * 2.3283064365386963E-10 * (this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)));
		}

		public override int Next(int sta, int les)
		{
			uint num = this.x ^ this.x << 11;
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			return (int)((double)(les - sta) * 2.3283064365386963E-10 * (this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8))) + sta;
		}

		public void Next(int sta, int les, out int o)
		{
			uint num = this.x ^ this.x << 11;
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			o = (int)((double)(les - sta) * 2.3283064365386963E-10 * (this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8))) + sta;
		}

		public int NextM(int max)
		{
			uint num = this.x ^ this.x << 11;
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			return (int)((double)((long)max + 1L) * 2.3283064365386963E-10 * (this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)));
		}

		public void NextM(int max, out int o)
		{
			uint num = this.x ^ this.x << 11;
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			o = (int)((double)((long)max + 1L) * 2.3283064365386963E-10 * (this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)));
		}

		public int NextM(int min, int max)
		{
			uint num = this.x ^ this.x << 11;
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			return (int)((double)((long)(max - min) + 1L) * 2.3283064365386963E-10 * (this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8))) + min;
		}

		public void NextM(int min, int max, out int o)
		{
			uint num = this.x ^ this.x << 11;
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			o = (int)((double)((long)(max - min) + 1L) * 2.3283064365386963E-10 * (this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8))) + min;
		}

		public override void NextBytes(byte[] buf)
		{
			int num = buf.Length;
			for (int i = 0; i < num; i++)
			{
				uint num2 = this.x ^ this.x << 11;
				this.x = this.y;
				this.y = this.z;
				this.z = this.w;
				buf[i] = (byte)(5.960464477539063E-08 * (this.w = (this.w ^ this.w >> 19 ^ num2 ^ num2 >> 8)));
			}
		}

		public override double NextDouble()
		{
			uint num = this.x ^ this.x << 11;
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			uint num2 = (this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)) >> 11;
			num = (this.x ^ this.x << 11);
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			return 1.1102230246251565E-16 * ((this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)) * 2097152.0 + num2);
		}

		public void NextDouble(out double o)
		{
			uint num = this.x ^ this.x << 11;
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			uint num2 = (this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)) >> 11;
			num = (this.x ^ this.x << 11);
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			o = 1.1102230246251565E-16 * ((this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)) * 2097152.0 + num2);
		}

		public double NextDouble(double les)
		{
			uint num = this.x ^ this.x << 11;
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			uint num2 = (this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)) >> 11;
			num = (this.x ^ this.x << 11);
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			return les * 1.1102230246251565E-16 * ((this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)) * 2097152.0 + num2);
		}

		public void NextDouble(double les, out double o)
		{
			uint num = this.x ^ this.x << 11;
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			uint num2 = (this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)) >> 11;
			num = (this.x ^ this.x << 11);
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			o = les * 1.1102230246251565E-16 * ((this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)) * 2097152.0 + num2);
		}

		public double NextDouble(double sta, double les)
		{
			uint num = this.x ^ this.x << 11;
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			uint num2 = (this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)) >> 11;
			num = (this.x ^ this.x << 11);
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			return (les - sta) * 1.1102230246251565E-16 * ((this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)) * 2097152.0 + num2) + sta;
		}

		public void NextDouble(double sta, double les, out double o)
		{
			uint num = this.x ^ this.x << 11;
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			uint num2 = (this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)) >> 11;
			num = (this.x ^ this.x << 11);
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			o = (les - sta) * 1.1102230246251565E-16 * ((this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)) * 2097152.0 + num2) + sta;
		}

		public bool NextBool()
		{
			uint num = this.x ^ this.x << 11;
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			return (this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)) % 2U == 0U;
		}

		public void NextBool(out bool o)
		{
			uint num = this.x ^ this.x << 11;
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			uint num2 = this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8);
			o = (num2 % 2U == 0U);
		}

		public int NextSign()
		{
			uint num = this.x ^ this.x << 11;
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			if ((this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)) % 2U != 0U)
			{
				return -1;
			}
			return 1;
		}

		public void NextSign(out int o)
		{
			uint num = this.x ^ this.x << 11;
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			o = (((this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)) % 2U == 0U) ? 1 : -1);
		}

		public double NextNorCos(double mu = 0.0, double sigma = 1.0)
		{
			uint num = this.x ^ this.x << 11;
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			uint num2 = (this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)) >> 11;
			num = (this.x ^ this.x << 11);
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			double d = 1.1102230246251565E-16 * ((this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)) * 2097152.0 + num2);
			num = (this.x ^ this.x << 11);
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			num2 = (this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)) >> 11;
			num = (this.x ^ this.x << 11);
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			double num3 = 1.1102230246251565E-16 * ((this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)) * 2097152.0 + num2);
			return Math.Sqrt(-2.0 * Math.Log(d)) * Math.Cos(6.283185307179586 * num3) * sigma + mu;
		}

		public void NextNorCos(double mu, double sigma, out double o)
		{
			uint num = this.x ^ this.x << 11;
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			uint num2 = (this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)) >> 11;
			num = (this.x ^ this.x << 11);
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			double d = 1.1102230246251565E-16 * ((this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)) * 2097152.0 + num2);
			num = (this.x ^ this.x << 11);
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			num2 = (this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)) >> 11;
			num = (this.x ^ this.x << 11);
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			double num3 = 1.1102230246251565E-16 * ((this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)) * 2097152.0 + num2);
			o = Math.Sqrt(-2.0 * Math.Log(d)) * Math.Cos(6.283185307179586 * num3) * sigma + mu;
		}

		public double NextNorSin(double mu = 0.0, double sigma = 1.0)
		{
			uint num = this.x ^ this.x << 11;
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			uint num2 = (this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)) >> 11;
			num = (this.x ^ this.x << 11);
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			double d = 1.1102230246251565E-16 * ((this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)) * 2097152.0 + num2);
			num = (this.x ^ this.x << 11);
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			num2 = (this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)) >> 11;
			num = (this.x ^ this.x << 11);
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			double num3 = 1.1102230246251565E-16 * ((this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)) * 2097152.0 + num2);
			return Math.Sqrt(-2.0 * Math.Log(d)) * Math.Sin(6.283185307179586 * num3) * sigma + mu;
		}

		public void NextNorSin(double mu, double sigma, out double o)
		{
			uint num = this.x ^ this.x << 11;
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			uint num2 = (this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)) >> 11;
			num = (this.x ^ this.x << 11);
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			double d = 1.1102230246251565E-16 * ((this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)) * 2097152.0 + num2);
			num = (this.x ^ this.x << 11);
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			num2 = (this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)) >> 11;
			num = (this.x ^ this.x << 11);
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			double num3 = 1.1102230246251565E-16 * ((this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)) * 2097152.0 + num2);
			o = Math.Sqrt(-2.0 * Math.Log(d)) * Math.Sin(6.283185307179586 * num3) * sigma + mu;
		}

		public double[] NextNorPair(double mu = 0.0, double sigma = 1.0)
		{
			uint num = this.x ^ this.x << 11;
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			uint num2 = (this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)) >> 11;
			num = (this.x ^ this.x << 11);
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			double d = 1.1102230246251565E-16 * ((this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)) * 2097152.0 + num2);
			num = (this.x ^ this.x << 11);
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			num2 = (this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)) >> 11;
			num = (this.x ^ this.x << 11);
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			double num3 = 1.1102230246251565E-16 * ((this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)) * 2097152.0 + num2);
			return new double[]
			{
				Math.Sqrt(-2.0 * Math.Log(d)) * Math.Cos(6.283185307179586 * num3) * sigma + mu,
				Math.Sqrt(-2.0 * Math.Log(d)) * Math.Sin(6.283185307179586 * num3) * sigma + mu
			};
		}

		public void NextNorPair(double mu, double sigma, out double[] o)
		{
			uint num = this.x ^ this.x << 11;
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			uint num2 = (this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)) >> 11;
			num = (this.x ^ this.x << 11);
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			double d = 1.1102230246251565E-16 * ((this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)) * 2097152.0 + num2);
			num = (this.x ^ this.x << 11);
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			num2 = (this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)) >> 11;
			num = (this.x ^ this.x << 11);
			this.x = this.y;
			this.y = this.z;
			this.z = this.w;
			double num3 = 1.1102230246251565E-16 * ((this.w = (this.w ^ this.w >> 19 ^ num ^ num >> 8)) * 2097152.0 + num2);
			o = new double[]
			{
				Math.Sqrt(-2.0 * Math.Log(d)) * Math.Cos(6.283185307179586 * num3) * sigma + mu,
				Math.Sqrt(-2.0 * Math.Log(d)) * Math.Sin(6.283185307179586 * num3) * sigma + mu
			};
		}

		protected uint x;

		protected uint y;

		protected uint z;

		protected uint w;

		private const double d_4294967296 = 2.3283064365386963E-10;

		private const double d_9007199254740992 = 1.1102230246251565E-16;
	}
}
