using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class キャップ2D : EleD
	{
		public キャップ2D()
		{
			this.ThisType = base.GetType();
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new キャップ2(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 根本_表示;

		public bool 先端_表示;
	}
}
