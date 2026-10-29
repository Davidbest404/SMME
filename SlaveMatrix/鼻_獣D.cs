using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 鼻_獣D : 鼻D
	{
		public 鼻_獣D()
		{
			this.ThisType = base.GetType();
		}

		public override void 鼻水左接続(EleD e)
		{
			this.鼻水左_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.鼻_獣_鼻水左_接続;
		}

		public override void 鼻水右接続(EleD e)
		{
			this.鼻水右_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.鼻_獣_鼻水右_接続;
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new 鼻_獣(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 鼻_表示 = true;
	}
}
