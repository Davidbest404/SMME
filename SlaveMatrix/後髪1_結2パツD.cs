using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 後髪1_結2パツD : サイドD
	{
		public 後髪1_結2パツD()
		{
			this.ThisType = base.GetType();
		}

		public 後髪1_結2パツD SetRandom()
		{
			this.髪長 = OthN.XS.NextDouble();
			this.毛量 = OthN.XS.NextDouble();
			this.広がり = OthN.XS.NextDouble();
			this.高さ = OthN.XS.NextDouble();
			return this;
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new 後髪1_結2パツ(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 髪基_表示 = true;

		public bool お下げ左_髪左根_表示 = true;

		public bool お下げ左_髪左1_表示 = true;

		public bool お下げ左_髪左2_表示 = true;

		public bool お下げ右_髪右根_表示 = true;

		public bool お下げ右_髪右1_表示 = true;

		public bool お下げ右_髪右2_表示 = true;

		public double 髪長;

		public double 毛量;

		public double 広がり;

		public double 高さ;
	}
}
