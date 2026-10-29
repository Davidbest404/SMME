using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 鰭_魚D : 鰭D
	{
		public 鰭_魚D()
		{
			this.ThisType = base.GetType();
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new 鰭_魚(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 鰭2_鰭膜_表示 = true;

		public bool 鰭2_鰭条_表示 = true;

		public bool 鰭1_鰭膜_表示 = true;

		public bool 鰭1_鰭条_表示 = true;
	}
}
