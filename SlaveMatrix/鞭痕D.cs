using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 鞭痕D : EleD
	{
		public 鞭痕D()
		{
			this.ThisType = base.GetType();
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new 鞭痕(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 鞭痕_表示 = true;
	}
}
