using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 胸D : EleD
	{
		public 胸D()
		{
			this.ThisType = base.GetType();
		}

		public void 首接続(EleD e)
		{
			this.首_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.胸_首_接続;
		}

		public void 肩左接続(EleD e)
		{
			this.肩左_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.胸_肩左_接続;
		}

		public void 肩右接続(EleD e)
		{
			this.肩右_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.胸_肩右_接続;
		}

		public void 胸左接続(EleD e)
		{
			this.胸左_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.胸_胸左_接続;
		}

		public void 胸右接続(EleD e)
		{
			this.胸右_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.胸_胸右_接続;
		}

		public void 肌接続(EleD e)
		{
			this.肌_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.胸_肌_接続;
		}

		public void 翼上左接続(EleD e)
		{
			this.翼上左_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.胸_翼上左_接続;
			if (e is 尾D)
			{
				foreach (EleD eleD in e.EnumEleD())
				{
					eleD.尺度B = 1.0;
				}
			}
		}

		public void 翼上右接続(EleD e)
		{
			this.翼上右_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.胸_翼上右_接続;
			if (e is 尾D)
			{
				foreach (EleD eleD in e.EnumEleD())
				{
					eleD.尺度B = 1.0;
				}
			}
		}

		public void 翼下左接続(EleD e)
		{
			this.翼下左_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.胸_翼下左_接続;
			if (e is 尾D)
			{
				foreach (EleD eleD in e.EnumEleD())
				{
					eleD.尺度B = 1.0;
				}
			}
		}

		public void 翼下右接続(EleD e)
		{
			this.翼下右_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.胸_翼下右_接続;
			if (e is 尾D)
			{
				foreach (EleD eleD in e.EnumEleD())
				{
					eleD.尺度B = 1.0;
				}
			}
		}

		public void 背中接続(EleD e)
		{
			this.背中_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.胸_背中_接続;
			foreach (EleD eleD in e.EnumEleD())
			{
				eleD.尺度B = 1.0;
			}
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new 胸(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 胸郭_表示 = true;

		public bool 筋肉_筋肉左_表示;

		public bool 筋肉_筋肉右_表示;

		public bool 筋肉_筋肉中_表示;

		public bool 筋肉_筋肉左下_表示;

		public bool 筋肉_筋肉左中_表示;

		public bool 筋肉_筋肉左上_表示;

		public bool 筋肉_筋肉右下_表示;

		public bool 筋肉_筋肉右中_表示;

		public bool 筋肉_筋肉右上_表示;

		public bool 紋柄_紋左_紋1_表示;

		public bool 紋柄_紋左_紋2_表示;

		public bool 紋柄_紋左_紋3_表示;

		public bool 紋柄_紋左_紋4_表示;

		public bool 紋柄_紋右_紋1_表示;

		public bool 紋柄_紋右_紋2_表示;

		public bool 紋柄_紋右_紋3_表示;

		public bool 紋柄_紋右_紋4_表示;

		public bool 淫タトゥ_タトゥ左_表示;

		public bool 淫タトゥ_タトゥ右_表示;

		public bool 悪タトゥ_タトゥ左1_表示;

		public bool 悪タトゥ_タトゥ左2_表示;

		public bool 悪タトゥ_タトゥ左3_表示;

		public bool 悪タトゥ_タトゥ右1_表示;

		public bool 悪タトゥ_タトゥ右2_表示;

		public bool 悪タトゥ_タトゥ右3_表示;

		public bool 植タトゥ_左_上_タトゥ1_表示;

		public bool 植タトゥ_左_上_タトゥ2_表示;

		public bool 植タトゥ_左_下_タトゥ1_表示;

		public bool 植タトゥ_左_下_タトゥ2_表示;

		public bool 植タトゥ_右_上_タトゥ1_表示;

		public bool 植タトゥ_右_上_タトゥ2_表示;

		public bool 植タトゥ_右_下_タトゥ1_表示;

		public bool 植タトゥ_右_下_タトゥ2_表示;

		public bool 獣性_獣毛左1_表示;

		public bool 獣性_獣毛左2_表示;

		public bool 獣性_獣毛右1_表示;

		public bool 獣性_獣毛右2_表示;

		public bool 竜性_左_鱗1_表示;

		public bool 竜性_左_鱗2_表示;

		public bool 竜性_左_鱗3_表示;

		public bool 竜性_右_鱗1_表示;

		public bool 竜性_右_鱗2_表示;

		public bool 竜性_右_鱗3_表示;

		public bool 虫性_甲殻左_甲殻2_甲殻_表示;

		public bool 虫性_甲殻左_甲殻2_器官_表示;

		public bool 虫性_甲殻左_甲殻1_甲殻_表示;

		public bool 虫性_甲殻左_甲殻1_器官_表示;

		public bool 虫性_甲殻右_甲殻2_甲殻_表示;

		public bool 虫性_甲殻右_甲殻2_器官_表示;

		public bool 虫性_甲殻右_甲殻1_甲殻_表示;

		public bool 虫性_甲殻右_甲殻1_器官_表示;

		public bool 傷X左_表示;

		public bool 傷X右_表示;

		public bool ハイライト外左_表示;

		public bool ハイライト外右_表示;

		public bool ハイライト内左_表示;

		public bool ハイライト内右_表示;

		public bool ハイライト表示;

		public double 筋肉濃度 = 1.0;

		public double 傷X左濃度 = 1.0;

		public double 傷X右濃度 = 1.0;

		public double ハイライト濃度 = 1.0;

		public List<EleD> 首_接続 = new List<EleD>();

		public List<EleD> 肩左_接続 = new List<EleD>();

		public List<EleD> 肩右_接続 = new List<EleD>();

		public List<EleD> 胸左_接続 = new List<EleD>();

		public List<EleD> 胸右_接続 = new List<EleD>();

		public List<EleD> 肌_接続 = new List<EleD>();

		public List<EleD> 翼上左_接続 = new List<EleD>();

		public List<EleD> 翼上右_接続 = new List<EleD>();

		public List<EleD> 翼下左_接続 = new List<EleD>();

		public List<EleD> 翼下右_接続 = new List<EleD>();

		public List<EleD> 背中_接続 = new List<EleD>();
	}
}
