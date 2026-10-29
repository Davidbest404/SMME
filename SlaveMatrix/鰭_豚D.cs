using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 鰭_豚D : 鰭D
	{
		public 鰭_豚D()
		{
			this.ThisType = base.GetType();
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new 鰭_豚(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 鰭_表示 = true;
	}
}
