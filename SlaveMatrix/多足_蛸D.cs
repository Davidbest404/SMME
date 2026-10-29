using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 多足_蛸D : 半身D
	{
		public 多足_蛸D()
		{
			this.ThisType = base.GetType();
		}

		public void 軟体外左接続(EleD e)
		{
			this.軟体外左_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.多足_蛸_軟体外左_接続;
			foreach (EleD eleD in e.EnumEleD())
			{
				eleD.尺度B = 1.0;
			}
		}

		public void 軟体外右接続(EleD e)
		{
			this.軟体外右_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.多足_蛸_軟体外右_接続;
			foreach (EleD eleD in e.EnumEleD())
			{
				eleD.尺度B = 1.0;
			}
		}

		public void 軟体内左接続(EleD e)
		{
			this.軟体内左_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.多足_蛸_軟体内左_接続;
			foreach (EleD eleD in e.EnumEleD())
			{
				eleD.尺度B = 1.0;
			}
		}

		public void 軟体内右接続(EleD e)
		{
			this.軟体内右_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.多足_蛸_軟体内右_接続;
			foreach (EleD eleD in e.EnumEleD())
			{
				eleD.尺度B = 1.0;
			}
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new 多足_蛸(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 胴_表示 = true;

		public List<EleD> 軟体外左_接続 = new List<EleD>();

		public List<EleD> 軟体外右_接続 = new List<EleD>();

		public List<EleD> 軟体内左_接続 = new List<EleD>();

		public List<EleD> 軟体内右_接続 = new List<EleD>();
	}
}
