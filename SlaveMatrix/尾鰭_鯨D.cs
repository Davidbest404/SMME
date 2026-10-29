using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 尾鰭_鯨D : 尾鰭D
	{
		public 尾鰭_鯨D()
		{
			this.ThisType = base.GetType();
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new 尾鰭_鯨(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 鰭_表示 = true;

		public bool 尾_表示 = true;
	}
}
