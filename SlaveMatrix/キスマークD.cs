using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class キスマ\u30FCクD : EleD
	{
		public キスマ\u30FCクD()
		{
			this.ThisType = base.GetType();
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new キスマ\u30FCク(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool キスマ\u30FCク_表示 = true;
	}
}
