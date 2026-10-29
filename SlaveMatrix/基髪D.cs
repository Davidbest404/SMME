using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 基髪D : EleD
	{
		public 基髪D()
		{
			this.ThisType = base.GetType();
		}

		public void 頭頂左接続(EleD e)
		{
			this.頭頂左_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.基髪_頭頂左_接続;
		}

		public void 頭頂右接続(EleD e)
		{
			this.頭頂右_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.基髪_頭頂右_接続;
		}

		public void 横髪左接続(EleD e)
		{
			this.横髪左_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.基髪_横髪左_接続;
		}

		public void 横髪右接続(EleD e)
		{
			this.横髪右_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.基髪_横髪右_接続;
		}

		public void 前髪接続(EleD e)
		{
			this.前髪_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.基髪_前髪_接続;
		}

		public void 後髪接続(EleD e)
		{
			this.後髪_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.基髪_後髪_接続;
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new 基髪(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 髪_表示 = true;

		public List<EleD> 頭頂左_接続 = new List<EleD>();

		public List<EleD> 頭頂右_接続 = new List<EleD>();

		public List<EleD> 横髪左_接続 = new List<EleD>();

		public List<EleD> 横髪右_接続 = new List<EleD>();

		public List<EleD> 前髪_接続 = new List<EleD>();

		public List<EleD> 後髪_接続 = new List<EleD>();
	}
}
