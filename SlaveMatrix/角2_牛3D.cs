using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 角2_牛3D : 角2D
	{
		public 角2_牛3D()
		{
			this.ThisType = base.GetType();
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new 角2_牛3(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 根_表示 = true;

		public bool 凹1_表示 = true;

		public bool 凹2_表示 = true;

		public bool 凹3_表示 = true;

		public bool 凹4_表示 = true;

		public bool 凹5_表示 = true;

		public bool 凹6_表示 = true;

		public bool 凹7_表示 = true;
	}
}
