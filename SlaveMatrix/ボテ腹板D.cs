using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class ボテ腹板D : EleD
	{
		public ボテ腹板D()
		{
			this.ThisType = base.GetType();
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new ボテ腹板(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 腹板4_腹板_表示;

		public bool 腹板4_縦線_表示;

		public bool 腹板3_腹板_表示;

		public bool 腹板3_縦線_表示;

		public bool 腹板2_腹板_表示;

		public bool 腹板2_縦線_表示;

		public bool 腹板1_腹板_表示;

		public bool 腹板1_縦線_表示;
	}
}
