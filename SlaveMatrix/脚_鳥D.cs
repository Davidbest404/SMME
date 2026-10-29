using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 脚_鳥D : 獣脚D
	{
		public 脚_鳥D()
		{
			this.ThisType = base.GetType();
		}

		public override void 足接続(EleD e)
		{
			this.足_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.脚_鳥_足_接続;
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new 脚_鳥(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 脚_表示 = true;

		public bool 筋_表示;

		public bool 脚輪_革_表示;

		public bool 脚輪_金具1_表示;

		public bool 脚輪_金具2_表示;

		public bool 脚輪_金具3_表示;

		public bool 脚輪_金具左_表示;

		public bool 脚輪_金具右_表示;

		public bool 脚輪表示;

		public bool 鎖表示;
	}
}
