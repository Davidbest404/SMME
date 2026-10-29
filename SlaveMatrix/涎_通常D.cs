using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 涎_通常D : 涎D
	{
		public 涎_通常D()
		{
			this.ThisType = base.GetType();
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new 涎_通常(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 涎_表示;
	}
}
