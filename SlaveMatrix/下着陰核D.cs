using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 下着陰核D : EleD
	{
		public 下着陰核D()
		{
			this.ThisType = base.GetType();
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new 下着陰核(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 陰核_表示 = true;
	}
}
