using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 瞼_強D : 双瞼D
	{
		public 瞼_強D()
		{
			this.ThisType = base.GetType();
		}

		public 瞼_強D SetRandom()
		{
			this.サイズ = OthN.XS.NextDouble();
			this.サイズX = OthN.XS.NextDouble();
			this.サイズY = OthN.XS.NextDouble();
			this.二重_表示 = OthN.XS.NextBool();
			this.睫毛_睫毛3_表示 = OthN.XS.NextBool();
			this.睫毛_睫毛4_表示 = OthN.XS.NextBool();
			this.睫毛_睫毛1_表示 = OthN.XS.NextBool();
			this.睫毛_睫毛2_表示 = OthN.XS.NextBool();
			this.外線 = OthN.XS.NextDouble();
			this.睫毛_睫毛3_長さ = OthN.XS.NextDouble();
			this.睫毛_睫毛4_長さ = OthN.XS.NextDouble();
			this.睫毛_睫毛1_長さ = OthN.XS.NextDouble();
			this.睫毛_睫毛2_長さ = OthN.XS.NextDouble();
			this.傾き = OthN.XS.NextDouble();
			return this;
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new 瞼_強(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 瞼_表示 = true;

		public bool 二重_表示 = true;

		public bool 睫毛_睫毛3_表示 = true;

		public bool 睫毛_睫毛4_表示 = true;

		public bool 睫毛_睫毛1_表示 = true;

		public bool 睫毛_睫毛2_表示 = true;

		public double 外線;

		public double 睫毛_睫毛3_長さ;

		public double 睫毛_睫毛4_長さ;

		public double 睫毛_睫毛1_長さ;

		public double 睫毛_睫毛2_長さ;
	}
}
