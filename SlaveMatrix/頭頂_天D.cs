using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 頭頂_天D : 頭頂D
	{
		public 頭頂_天D()
		{
			this.ThisType = base.GetType();
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new 頭頂_天(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 天輪上_表示 = true;

		public bool 天輪下_表示 = true;
	}
}
