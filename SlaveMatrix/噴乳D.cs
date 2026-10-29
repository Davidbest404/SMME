using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 噴乳D : EleD
	{
		public 噴乳D()
		{
			this.ThisType = base.GetType();
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new 噴乳(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 母乳垂れ1_表示;

		public bool 母乳垂れ2_表示;

		public bool 母乳1_表示;

		public bool 母乳2_表示;

		public bool 母乳3_表示;

		public bool 母乳4_表示;
	}
}
