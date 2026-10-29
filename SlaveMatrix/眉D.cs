using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 眉D : EleD
	{
		public 眉D()
		{
			this.ThisType = base.GetType();
		}

		public 眉D SetRandom()
		{
			this.サイズY = OthN.XS.NextDouble();
			return this;
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new 眉(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 眉_表示 = true;

		public bool 眉間_表示;
	}
}
