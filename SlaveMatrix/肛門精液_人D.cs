using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 肛門精液_人D : 肛門精液D
	{
		public 肛門精液_人D()
		{
			this.ThisType = base.GetType();
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new 肛門精液_人(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 精液_表示;
	}
}
