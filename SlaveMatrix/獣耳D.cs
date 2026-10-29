using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 獣耳D : EleD
	{
		public 獣耳D()
		{
			this.ThisType = base.GetType();
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new 獣耳(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 獣耳外_表示 = true;

		public bool 獣耳内_表示 = true;

		public bool 耳毛_表示 = true;
	}
}
