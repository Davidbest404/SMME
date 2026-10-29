using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 放尿_獣D : 放尿D
	{
		public 放尿_獣D()
		{
			this.ThisType = base.GetType();
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new 放尿_獣(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 尿_表示;

		public bool 尿散り1_表示;

		public bool 尿散り2_表示;

		public bool 尿散り3_表示;

		public bool 尿散り4_表示;

		public bool 尿散り5_表示;
	}
}
