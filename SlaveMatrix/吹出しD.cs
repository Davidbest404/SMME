using System;
using System.Collections.Generic;

namespace SlaveMatrix
{
	[Serializable]
	public class 吹出しD : EleD
	{
		public 吹出しD()
		{
			this.ThisType = base.GetType();
		}

		public void 吹出し接続(EleD e)
		{
			this.吹出し_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.吹出し_吹出し_接続;
		}

		public bool 吹出し_表示;

		public List<EleD> 吹出し_接続 = new List<EleD>();
	}
}
