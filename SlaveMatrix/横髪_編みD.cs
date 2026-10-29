using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 横髪_編みD : 横髪D
	{
		public 横髪_編みD()
		{
			this.ThisType = base.GetType();
		}

		public 横髪_編みD SetRandom()
		{
			this.髪長1 = OthN.XS.NextDouble();
			this.髪長2 = OthN.XS.NextDouble();
			this.毛量 = OthN.XS.NextDouble();
			this.広がり = OthN.XS.NextDouble();
			this.髪長1 = 1.0;
			this.髪長2 = 1.0;
			return this;
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new 横髪_編み(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 髪_表示 = true;

		public bool 編節1_髪節_表示 = true;

		public bool 編節1_髪編目_表示 = true;

		public bool 編節2_髪節_表示 = true;

		public bool 編節2_髪編目_表示 = true;

		public bool 編節3_髪節_表示 = true;

		public bool 編節3_髪編目_表示 = true;

		public bool 編節4_髪節_表示 = true;

		public bool 編節4_髪編目_表示 = true;

		public bool 髪縛1_表示 = true;

		public bool 髪縛2_表示 = true;

		public bool 髪左_表示 = true;

		public bool 髪右_表示 = true;

		public bool 髪根_表示 = true;

		public double 髪長1;

		public double 髪長2;

		public double 毛量;

		public double 広がり;
	}
}
