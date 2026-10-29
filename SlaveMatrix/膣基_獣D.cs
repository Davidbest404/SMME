using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 膣基_獣D : 膣基D
	{
		public 膣基_獣D()
		{
			this.ThisType = base.GetType();
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new 膣基_獣(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 膣基_表示;
	}
}
