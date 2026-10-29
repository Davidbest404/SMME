using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 後髪0_下2ハネD : お下げ2D
	{
		public 後髪0_下2ハネD()
		{
			this.ThisType = base.GetType();
		}

		public 後髪0_下2ハネD SetRandom()
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
			return new 後髪0_下2ハネ(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 髪基_表示 = true;

		public bool お下げ左_髪縛1_表示 = true;

		public bool お下げ左_髪縛2_表示 = true;

		public bool お下げ左_髪右_表示 = true;

		public bool お下げ左_髪左_表示 = true;

		public bool お下げ左_髪根_表示 = true;

		public bool お下げ右_髪縛1_表示 = true;

		public bool お下げ右_髪縛2_表示 = true;

		public bool お下げ右_髪左_表示 = true;

		public bool お下げ右_髪右_表示 = true;

		public bool お下げ右_髪根_表示 = true;

		public double 髪長0;

		public double 髪長1;

		public double 毛量;

		public double 広がり;

		public bool スライム;
	}
}
