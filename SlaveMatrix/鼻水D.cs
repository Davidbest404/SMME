using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 鼻水D : EleD
	{
		public 鼻水D()
		{
			this.ThisType = base.GetType();
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new 鼻水(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 鼻水_表示;
	}
}
