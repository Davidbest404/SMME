using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 角2_鬼D : 角2D
	{
		public 角2_鬼D()
		{
			this.ThisType = base.GetType();
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new 角2_鬼(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 根_表示 = true;

		public bool 線1_表示 = true;

		public bool 線2_表示 = true;

		public bool 線3_表示 = true;

		public bool 線4_表示 = true;

		public bool 線5_表示 = true;

		public bool 線6_表示 = true;

		public bool 折線1_表示 = true;

		public bool 折線2_表示 = true;
	}
}
