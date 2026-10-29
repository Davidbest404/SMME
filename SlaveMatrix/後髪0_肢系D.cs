using System;
using System.Collections.Generic;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 後髪0_肢系D : 下ろしD
	{
		public 後髪0_肢系D()
		{
			this.ThisType = base.GetType();
		}

		public void 左5接続(EleD e)
		{
			this.左5_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.後髪0_肢系_左5_接続;
			foreach (EleD eleD in e.EnumEleD())
			{
				eleD.尺度B = 0.6;
			}
		}

		public void 左4接続(EleD e)
		{
			this.左4_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.後髪0_肢系_左4_接続;
			foreach (EleD eleD in e.EnumEleD())
			{
				eleD.尺度B = 0.6;
			}
		}

		public void 左3接続(EleD e)
		{
			this.左3_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.後髪0_肢系_左3_接続;
			foreach (EleD eleD in e.EnumEleD())
			{
				eleD.尺度B = 0.6;
			}
		}

		public void 左2接続(EleD e)
		{
			this.左2_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.後髪0_肢系_左2_接続;
			foreach (EleD eleD in e.EnumEleD())
			{
				eleD.尺度B = 0.6;
			}
		}

		public void 左1接続(EleD e)
		{
			this.左1_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.後髪0_肢系_左1_接続;
			foreach (EleD eleD in e.EnumEleD())
			{
				eleD.尺度B = 0.6;
			}
		}

		public void 中央接続(EleD e)
		{
			this.中央_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.後髪0_肢系_中央_接続;
			foreach (EleD eleD in e.EnumEleD())
			{
				eleD.尺度B = 0.6;
			}
		}

		public void 右1接続(EleD e)
		{
			this.右1_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.後髪0_肢系_右1_接続;
			foreach (EleD eleD in e.EnumEleD())
			{
				eleD.尺度B = 0.6;
			}
		}

		public void 右2接続(EleD e)
		{
			this.右2_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.後髪0_肢系_右2_接続;
			foreach (EleD eleD in e.EnumEleD())
			{
				eleD.尺度B = 0.6;
			}
		}

		public void 右3接続(EleD e)
		{
			this.右3_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.後髪0_肢系_右3_接続;
			foreach (EleD eleD in e.EnumEleD())
			{
				eleD.尺度B = 0.6;
			}
		}

		public void 右4接続(EleD e)
		{
			this.右4_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.後髪0_肢系_右4_接続;
			foreach (EleD eleD in e.EnumEleD())
			{
				eleD.尺度B = 0.6;
			}
		}

		public void 右5接続(EleD e)
		{
			this.右5_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.後髪0_肢系_右5_接続;
			foreach (EleD eleD in e.EnumEleD())
			{
				eleD.尺度B = 0.6;
			}
		}

		public 後髪0_肢系D SetRandom()
		{
			this.髪長0 = OthN.XS.NextDouble();
			this.右 = OthN.XS.NextBool();
			return this;
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new 後髪0_肢系(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public override IEnumerable<EleD> EnumEleD()
		{
			yield return this;
			if (this.中央_接続 != null)
			{
				foreach (EleD eleD in (from e in this.中央_接続
				select e.EnumEleD()).JoinEnum<EleD>())
				{
					yield return eleD;
				}
				IEnumerator<EleD> enumerator = null;
			}
			if (this.左1_接続 != null)
			{
				foreach (EleD eleD2 in (from e in this.左1_接続
				select e.EnumEleD()).JoinEnum<EleD>())
				{
					yield return eleD2;
				}
				IEnumerator<EleD> enumerator = null;
			}
			if (this.右1_接続 != null)
			{
				foreach (EleD eleD3 in (from e in this.右1_接続
				select e.EnumEleD()).JoinEnum<EleD>())
				{
					yield return eleD3;
				}
				IEnumerator<EleD> enumerator = null;
			}
			if (this.左2_接続 != null)
			{
				foreach (EleD eleD4 in (from e in this.左2_接続
				select e.EnumEleD()).JoinEnum<EleD>())
				{
					yield return eleD4;
				}
				IEnumerator<EleD> enumerator = null;
			}
			if (this.右2_接続 != null)
			{
				foreach (EleD eleD5 in (from e in this.右2_接続
				select e.EnumEleD()).JoinEnum<EleD>())
				{
					yield return eleD5;
				}
				IEnumerator<EleD> enumerator = null;
			}
			if (this.左3_接続 != null)
			{
				foreach (EleD eleD6 in (from e in this.左3_接続
				select e.EnumEleD()).JoinEnum<EleD>())
				{
					yield return eleD6;
				}
				IEnumerator<EleD> enumerator = null;
			}
			if (this.右3_接続 != null)
			{
				foreach (EleD eleD7 in (from e in this.右3_接続
				select e.EnumEleD()).JoinEnum<EleD>())
				{
					yield return eleD7;
				}
				IEnumerator<EleD> enumerator = null;
			}
			if (this.左4_接続 != null)
			{
				foreach (EleD eleD8 in (from e in this.左4_接続
				select e.EnumEleD()).JoinEnum<EleD>())
				{
					yield return eleD8;
				}
				IEnumerator<EleD> enumerator = null;
			}
			if (this.右4_接続 != null)
			{
				foreach (EleD eleD9 in (from e in this.右4_接続
				select e.EnumEleD()).JoinEnum<EleD>())
				{
					yield return eleD9;
				}
				IEnumerator<EleD> enumerator = null;
			}
			if (this.左5_接続 != null)
			{
				foreach (EleD eleD10 in (from e in this.左5_接続
				select e.EnumEleD()).JoinEnum<EleD>())
				{
					yield return eleD10;
				}
				IEnumerator<EleD> enumerator = null;
			}
			if (this.右5_接続 != null)
			{
				foreach (EleD eleD11 in (from e in this.右5_接続
				select e.EnumEleD()).JoinEnum<EleD>())
				{
					yield return eleD11;
				}
				IEnumerator<EleD> enumerator = null;
			}
			yield break;
			yield break;
		}

		public bool 髪基_表示 = true;

		public double 髪長0;

		public bool スライム;

		public List<EleD> 左5_接続 = new List<EleD>();

		public List<EleD> 左4_接続 = new List<EleD>();

		public List<EleD> 左3_接続 = new List<EleD>();

		public List<EleD> 左2_接続 = new List<EleD>();

		public List<EleD> 左1_接続 = new List<EleD>();

		public List<EleD> 中央_接続 = new List<EleD>();

		public List<EleD> 右1_接続 = new List<EleD>();

		public List<EleD> 右2_接続 = new List<EleD>();

		public List<EleD> 右3_接続 = new List<EleD>();

		public List<EleD> 右4_接続 = new List<EleD>();

		public List<EleD> 右5_接続 = new List<EleD>();
	}
}
