using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 縦瞼D : EleD
	{
		public 縦瞼D()
		{
			this.ThisType = base.GetType();
		}

		public 縦瞼D SetRandom()
		{
			this.サイズX = OthN.XS.NextDouble();
			this.瞼左_睫毛1_表示 = OthN.XS.NextBool();
			this.瞼左_睫毛2_表示 = OthN.XS.NextBool();
			this.瞼右_睫毛1_表示 = this.瞼左_睫毛1_表示;
			this.瞼右_睫毛2_表示 = this.瞼左_睫毛2_表示;
			this.外線 = OthN.XS.NextDouble();
			this.瞼左_睫毛1_長さ = OthN.XS.NextDouble();
			this.瞼左_睫毛2_長さ = OthN.XS.NextDouble();
			this.瞼右_睫毛1_長さ = this.瞼左_睫毛1_長さ;
			this.瞼右_睫毛2_長さ = this.瞼左_睫毛2_長さ;
			return this;
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new 縦瞼(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 瞼左_瞼_表示 = true;

		public bool 瞼左_睫毛1_表示 = true;

		public bool 瞼左_睫毛2_表示 = true;

		public bool 瞼右_瞼_表示 = true;

		public bool 瞼右_睫毛1_表示 = true;

		public bool 瞼右_睫毛2_表示 = true;

		public double 外線;

		public double 瞼左_睫毛1_長さ;

		public double 瞼左_睫毛2_長さ;

		public double 瞼右_睫毛1_長さ;

		public double 瞼右_睫毛2_長さ;
	}
}
