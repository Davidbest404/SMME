using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 単瞼D : EleD
	{
		public 単瞼D()
		{
			this.ThisType = base.GetType();
		}

		public 単瞼D SetRandom()
		{
			this.サイズ = OthN.XS.NextDouble();
			this.サイズX = OthN.XS.NextDouble();
			this.サイズY = OthN.XS.NextDouble();
			this.二重_表示 = OthN.XS.NextBool();
			this.睫毛上上左_表示 = OthN.XS.NextBool();
			this.睫毛上中左_表示 = OthN.XS.NextBool();
			this.睫毛上下左_表示 = OthN.XS.NextBool();
			this.睫毛上上右_表示 = this.睫毛上上左_表示;
			this.睫毛上中右_表示 = this.睫毛上中左_表示;
			this.睫毛上下右_表示 = this.睫毛上下左_表示;
			this.睫毛下上左_表示 = OthN.XS.NextBool();
			this.睫毛下下左_表示 = OthN.XS.NextBool();
			this.睫毛下上右_表示 = this.睫毛下上左_表示;
			this.睫毛下下右_表示 = this.睫毛下下左_表示;
			this.外線 = OthN.XS.NextDouble();
			this.睫毛上上左_長さ = OthN.XS.NextDouble();
			this.睫毛上中左_長さ = OthN.XS.NextDouble();
			this.睫毛上下左_長さ = OthN.XS.NextDouble();
			this.睫毛上上右_長さ = this.睫毛上上左_長さ;
			this.睫毛上中右_長さ = this.睫毛上中左_長さ;
			this.睫毛上下右_長さ = this.睫毛上下左_長さ;
			this.睫毛下上左_長さ = OthN.XS.NextDouble();
			this.睫毛下下左_長さ = OthN.XS.NextDouble();
			this.睫毛下上右_長さ = this.睫毛下上左_長さ;
			this.睫毛下下右_長さ = this.睫毛下下左_長さ;
			return this;
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new 単瞼(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 瞼下_表示 = true;

		public bool 瞼上_表示 = true;

		public bool 二重_表示 = true;

		public bool 睫毛上上左_表示 = true;

		public bool 睫毛上中左_表示 = true;

		public bool 睫毛上下左_表示 = true;

		public bool 睫毛上上右_表示 = true;

		public bool 睫毛上中右_表示 = true;

		public bool 睫毛上下右_表示 = true;

		public bool 睫毛下上左_表示 = true;

		public bool 睫毛下下左_表示 = true;

		public bool 睫毛下上右_表示 = true;

		public bool 睫毛下下右_表示 = true;

		public double 外線;

		public double 睫毛上上左_長さ;

		public double 睫毛上中左_長さ;

		public double 睫毛上下左_長さ;

		public double 睫毛上上右_長さ;

		public double 睫毛上中右_長さ;

		public double 睫毛上下右_長さ;

		public double 睫毛下上左_長さ;

		public double 睫毛下下左_長さ;

		public double 睫毛下上右_長さ;

		public double 睫毛下下右_長さ;
	}
}
