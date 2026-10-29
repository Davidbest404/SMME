using System;
using System.Collections.Generic;

namespace SlaveMatrix
{
	[Serializable]
	public class ペニスD : EleD
	{
		public ペニスD()
		{
			this.ThisType = base.GetType();
		}

		public void 尿道接続(EleD e)
		{
			this.尿道_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.ペニス_尿道_接続;
		}

		public bool 陰嚢_表示 = true;

		public bool 陰茎_表示 = true;

		public bool 血管下_表示 = true;

		public bool 血管上_表示 = true;

		public bool 亀頭_表示 = true;

		public List<EleD> 尿道_接続 = new List<EleD>();
	}
}
