using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class ぶっかけ_小D : EleD
	{
		public ぶっかけ_小D()
		{
			this.ThisType = base.GetType();
		}

		public override Ele GetEle(double DisUnit, Med Med, 主人公配色 体配色)
		{
			return new ぶっかけ_小(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 精液_表示 = true;
	}
}
