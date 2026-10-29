using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 耳_人D : 耳D
	{
		public 耳_人D()
		{
			this.ThisType = base.GetType();
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new 耳_人(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 耳_表示 = true;

		public bool 耳線_表示 = true;
	}
}
