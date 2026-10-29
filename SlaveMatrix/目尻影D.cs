using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 目尻影D : EleD
	{
		public 目尻影D()
		{
			this.ThisType = base.GetType();
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new 目尻影(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 目尻影_表示;
	}
}
