using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 四足胴D : EleD
	{
		public 四足胴D()
		{
			this.ThisType = base.GetType();
		}

		public void 腰接続(EleD e)
		{
			this.腰_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.四足胴_腰_接続;
		}

		public void 肌接続(EleD e)
		{
			this.肌_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.四足胴_肌_接続;
		}

		public void 翼左接続(EleD e)
		{
			this.翼左_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.四足胴_翼左_接続;
			foreach (EleD eleD in e.EnumEleD())
			{
				eleD.尺度B = 1.1;
			}
		}

		public void 翼右接続(EleD e)
		{
			this.翼右_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.四足胴_翼右_接続;
			foreach (EleD eleD in e.EnumEleD())
			{
				eleD.尺度B = 1.1;
			}
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new 四足胴(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 胴_表示 = true;

		public bool 筋肉_筋肉左_表示 = true;

		public bool 筋肉_筋肉右_表示 = true;

		public bool 獣性_獣毛左_表示;

		public bool 獣性_獣毛右_表示;

		public double 筋肉濃度 = 1.0;

		public List<EleD> 腰_接続 = new List<EleD>();

		public List<EleD> 肌_接続 = new List<EleD>();

		public List<EleD> 翼左_接続 = new List<EleD>();

		public List<EleD> 翼右_接続 = new List<EleD>();
	}
}
