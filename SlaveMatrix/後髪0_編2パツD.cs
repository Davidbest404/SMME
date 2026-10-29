using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 後髪0_編2パツD : お下げ2D
	{
		public 後髪0_編2パツD()
		{
			this.ThisType = base.GetType();
		}

		public 後髪0_編2パツD SetRandom()
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
			return new 後髪0_編2パツ(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 髪基_表示 = true;

		public bool お下げ左_編節1_髪節_表示 = true;

		public bool お下げ左_編節1_髪編目_表示 = true;

		public bool お下げ左_編節2_髪節_表示 = true;

		public bool お下げ左_編節2_髪編目_表示 = true;

		public bool お下げ左_編節3_髪節_表示 = true;

		public bool お下げ左_編節3_髪編目_表示 = true;

		public bool お下げ左_編節4_髪節_表示 = true;

		public bool お下げ左_編節4_髪編目_表示 = true;

		public bool お下げ左_編節5_髪節_表示 = true;

		public bool お下げ左_編節5_髪編目_表示 = true;

		public bool お下げ左_編節6_髪節_表示 = true;

		public bool お下げ左_編節6_髪編目_表示 = true;

		public bool お下げ左_編節7_髪節_表示 = true;

		public bool お下げ左_編節7_髪編目_表示 = true;

		public bool お下げ左_編節8_髪節_表示 = true;

		public bool お下げ左_編節8_髪編目_表示 = true;

		public bool お下げ左_髪縛1_表示 = true;

		public bool お下げ左_髪縛2_表示 = true;

		public bool お下げ左_髪左1_表示 = true;

		public bool お下げ左_髪右1_表示 = true;

		public bool お下げ左_髪根_表示 = true;

		public bool お下げ右_編節1_髪節_表示 = true;

		public bool お下げ右_編節1_髪編目_表示 = true;

		public bool お下げ右_編節2_髪節_表示 = true;

		public bool お下げ右_編節2_髪編目_表示 = true;

		public bool お下げ右_編節3_髪節_表示 = true;

		public bool お下げ右_編節3_髪編目_表示 = true;

		public bool お下げ右_編節4_髪節_表示 = true;

		public bool お下げ右_編節4_髪編目_表示 = true;

		public bool お下げ右_編節5_髪節_表示 = true;

		public bool お下げ右_編節5_髪編目_表示 = true;

		public bool お下げ右_編節6_髪節_表示 = true;

		public bool お下げ右_編節6_髪編目_表示 = true;

		public bool お下げ右_編節7_髪節_表示 = true;

		public bool お下げ右_編節7_髪編目_表示 = true;

		public bool お下げ右_編節8_髪節_表示 = true;

		public bool お下げ右_編節8_髪編目_表示 = true;

		public bool お下げ右_髪縛1_表示 = true;

		public bool お下げ右_髪縛2_表示 = true;

		public bool お下げ右_髪右1_表示 = true;

		public bool お下げ右_髪左1_表示 = true;

		public bool お下げ右_髪根_表示 = true;

		public double 髪長0;

		public double 髪長1;

		public double 毛量;

		public double 広がり;

		public bool スライム;
	}
}
