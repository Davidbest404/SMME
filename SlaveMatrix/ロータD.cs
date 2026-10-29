using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class ロ\u30FCタD : EleD
	{
		public ロ\u30FCタD()
		{
			this.ThisType = base.GetType();
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new ロ\u30FCタ(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool ロ\u30FCタ_表示 = true;

		public bool ロ\u30FCタ線_表示 = true;

		public bool コ\u30FCド_表示 = true;
	}
}
