using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 舌_短D : 舌D
	{
		public 舌_短D()
		{
			this.ThisType = base.GetType();
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new 舌_短(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 舌1_表示 = true;

		public bool 舌2_表示 = true;

		public bool 舌3_表示 = true;

		public bool 舌4_表示 = true;

		public bool 舌5_表示 = true;
	}
}
