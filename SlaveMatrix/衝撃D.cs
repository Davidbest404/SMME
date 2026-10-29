using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 衝撃D : EleD
	{
		public 衝撃D()
		{
			this.ThisType = base.GetType();
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new 衝撃(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 衝撃_表示 = true;
	}
}
