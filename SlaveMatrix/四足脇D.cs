using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 四足脇D : EleD
	{
		public 四足脇D()
		{
			this.ThisType = base.GetType();
		}

		public void 上腕接続(EleD e)
		{
			this.上腕_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.四足脇_上腕_接続;
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new 四足脇(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 脇_表示 = true;

		public bool 筋肉_表示 = true;

		public double 筋肉濃度 = 1.0;

		public List<EleD> 上腕_接続 = new List<EleD>();
	}
}
