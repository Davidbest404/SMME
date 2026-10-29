using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 後翅_甲D : 後翅D
	{
		public 後翅_甲D()
		{
			this.ThisType = base.GetType();
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new 後翅_甲(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 後翅_後翅根_後翅_表示 = true;

		public bool 後翅_後翅根_翅脈1_表示 = true;

		public bool 後翅_後翅根_翅脈2_表示 = true;

		public bool 後翅_後翅根_翅脈3_表示 = true;

		public bool 後翅_後翅根_翅脈4_表示 = true;

		public bool 後翅_後翅先_後翅_表示 = true;

		public bool 後翅_後翅先_翅脈1_表示 = true;

		public bool 後翅_後翅先_翅脈2_表示 = true;

		public bool 後翅_後翅先_翅脈3_表示 = true;

		public bool 後翅_後翅先_翅脈4_表示 = true;

		public double 展開;
	}
}
