using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 長物_蛇D : 半身D
	{
		public 長物_蛇D()
		{
			this.ThisType = base.GetType();
		}

		public void 左接続(EleD e)
		{
			this.左_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.長物_蛇_左_接続;
		}

		public void 右接続(EleD e)
		{
			this.右_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.長物_蛇_右_接続;
		}

		public void 胴接続(EleD e)
		{
			this.胴_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.長物_蛇_胴_接続;
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new 長物_蛇(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 胴1_表示 = true;

		public bool 胴1_鱗2_表示 = true;

		public bool 胴1_鱗右_表示 = true;

		public bool 胴1_鱗左_表示 = true;

		public bool 胴1_鱗1_表示 = true;

		public bool 胴1_鱗左2_表示 = true;

		public bool 胴1_鱗右2_表示 = true;

		public bool 胴1_鱗左1_表示 = true;

		public bool 胴1_鱗右1_表示 = true;

		public double くぱぁ;

		public bool ガ\u30FCド = true;

		public List<EleD> 左_接続 = new List<EleD>();

		public List<EleD> 右_接続 = new List<EleD>();

		public List<EleD> 胴_接続 = new List<EleD>();
	}
}
