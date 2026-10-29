using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 後髪0_ハネD : 下ろしD
	{
		public 後髪0_ハネD()
		{
			this.ThisType = base.GetType();
		}

		public 後髪0_ハネD SetRandom()
		{
			this.髪長0 = OthN.XS.NextDouble();
			this.髪長1 = OthN.XS.NextDouble();
			this.毛量 = OthN.XS.NextDouble();
			this.広がり = OthN.XS.NextDouble();
			this.右 = OthN.XS.NextBool();
			return this;
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new 後髪0_ハネ(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 髪基_表示 = true;

		public bool 髪中_表示 = true;

		public bool 髪左1_表示 = true;

		public bool 髪左2_表示 = true;

		public bool 髪左3_表示 = true;

		public bool 髪左4_表示 = true;

		public bool 髪左5_表示 = true;

		public bool 髪右1_表示 = true;

		public bool 髪右2_表示 = true;

		public bool 髪右3_表示 = true;

		public bool 髪右4_表示 = true;

		public bool 髪右5_表示 = true;

		public double 髪長0;

		public double 髪長1;

		public double 毛量;

		public double 広がり;

		public bool スライム;
	}
}
