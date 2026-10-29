using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 胴_蛇D : 長胴D
	{
		public 胴_蛇D()
		{
			this.ThisType = base.GetType();
		}

		public override void 左接続(EleD e)
		{
			this.左_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.胴_蛇_左_接続;
		}

		public override void 右接続(EleD e)
		{
			this.右_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.胴_蛇_右_接続;
		}

		public override void 胴接続(EleD e)
		{
			this.胴_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.胴_蛇_胴_接続;
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new 胴_蛇(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 胴_鱗_表示 = true;

		public bool 胴_鱗左_表示 = true;

		public bool 胴_鱗右_表示 = true;

		public bool 胴_表示 = true;

		public bool 輪_革_表示 = true;

		public bool 輪_金具1_表示 = true;

		public bool 輪_金具2_表示 = true;

		public bool 輪_金具3_表示 = true;

		public bool 輪_金具左_表示 = true;

		public bool 輪_金具右_表示 = true;

		public bool 輪表示 = true;

		public bool 鎖表示;
	}
}
