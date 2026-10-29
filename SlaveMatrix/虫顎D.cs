using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 虫顎D : EleD
	{
		public 虫顎D()
		{
			this.ThisType = base.GetType();
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new 虫顎(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 顎_表示 = true;

		public bool 節_表示 = true;

		public bool 牙_牙1_表示 = true;

		public bool 牙_牙2_表示 = true;

		public bool 牙_牙0_表示 = true;
	}
}
