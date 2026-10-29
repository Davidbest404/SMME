using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 飛沫_獣D : 飛沫D
	{
		public 飛沫_獣D()
		{
			this.ThisType = base.GetType();
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new 飛沫_獣(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 飛沫基_表示;

		public bool 雫1_表示;

		public bool 雫2_表示;

		public bool 雫3_表示;

		public bool 雫4_表示;

		public bool 雫5_表示;

		public bool 雫6_表示;

		public bool 雫7_表示;

		public bool 雫8_表示;

		public bool 雫9_表示;

		public bool 雫10_表示;
	}
}
