using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class ピアスD : EleD
	{
		public ピアスD()
		{
			this.ThisType = base.GetType();
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new ピアス(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool ピアス_表示;
	}
}
