using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 瞼_宇D : 双瞼D
	{
		public 瞼_宇D()
		{
			this.ThisType = base.GetType();
		}

		public void 涙接続(EleD e)
		{
			this.涙_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.瞼_宇_涙_接続;
		}

		public 瞼_宇D SetRandom()
		{
			this.サイズ = OthN.XS.NextDouble();
			this.サイズX = OthN.XS.NextDouble();
			this.サイズY = OthN.XS.NextDouble();
			this.傾き = OthN.XS.NextDouble();
			return this;
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new 瞼_宇(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 目_表示 = true;

		public bool ハイライト_表示 = true;

		public bool 瞬膜_表示 = true;

		public List<EleD> 涙_接続 = new List<EleD>();
	}
}
