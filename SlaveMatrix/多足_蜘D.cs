using System;
using System.Collections.Generic;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 多足_蜘D : 半身D
	{
		public 多足_蜘D()
		{
			this.ThisType = base.GetType();
		}

		public void 触肢左接続(EleD e)
		{
			this.触肢左_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.多足_蜘_触肢左_接続;
		}

		public void 触肢右接続(EleD e)
		{
			this.触肢右_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.多足_蜘_触肢右_接続;
		}

		public void 節足左1接続(EleD e)
		{
			this.節足左1_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.多足_蜘_節足左1_接続;
		}

		public void 節足左2接続(EleD e)
		{
			this.節足左2_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.多足_蜘_節足左2_接続;
		}

		public void 節足左3接続(EleD e)
		{
			this.節足左3_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.多足_蜘_節足左3_接続;
		}

		public void 節足左4接続(EleD e)
		{
			this.節足左4_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.多足_蜘_節足左4_接続;
		}

		public void 節足右1接続(EleD e)
		{
			this.節足右1_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.多足_蜘_節足右1_接続;
		}

		public void 節足右2接続(EleD e)
		{
			this.節足右2_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.多足_蜘_節足右2_接続;
		}

		public void 節足右3接続(EleD e)
		{
			this.節足右3_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.多足_蜘_節足右3_接続;
		}

		public void 節足右4接続(EleD e)
		{
			this.節足右4_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.多足_蜘_節足右4_接続;
		}

		public void 尾接続(EleD e)
		{
			this.尾_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.多足_蜘_尾_接続;
			foreach (EleD eleD in e.EnumEleD())
			{
				eleD.尺度B = 1.0;
			}
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new 多足_蜘(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public override IEnumerable<EleD> EnumEleD()
		{
			yield return this;
			if (this.尾_接続 != null)
			{
				foreach (EleD eleD in (from e in this.尾_接続
				select e.EnumEleD()).JoinEnum<EleD>())
				{
					yield return eleD;
				}
				IEnumerator<EleD> enumerator = null;
			}
			if (this.節足左4_接続 != null)
			{
				foreach (EleD eleD2 in (from e in this.節足左4_接続
				select e.EnumEleD()).JoinEnum<EleD>())
				{
					yield return eleD2;
				}
				IEnumerator<EleD> enumerator = null;
			}
			if (this.節足右4_接続 != null)
			{
				foreach (EleD eleD3 in (from e in this.節足右4_接続
				select e.EnumEleD()).JoinEnum<EleD>())
				{
					yield return eleD3;
				}
				IEnumerator<EleD> enumerator = null;
			}
			if (this.節足左3_接続 != null)
			{
				foreach (EleD eleD4 in (from e in this.節足左3_接続
				select e.EnumEleD()).JoinEnum<EleD>())
				{
					yield return eleD4;
				}
				IEnumerator<EleD> enumerator = null;
			}
			if (this.節足右3_接続 != null)
			{
				foreach (EleD eleD5 in (from e in this.節足右3_接続
				select e.EnumEleD()).JoinEnum<EleD>())
				{
					yield return eleD5;
				}
				IEnumerator<EleD> enumerator = null;
			}
			if (this.節足左2_接続 != null)
			{
				foreach (EleD eleD6 in (from e in this.節足左2_接続
				select e.EnumEleD()).JoinEnum<EleD>())
				{
					yield return eleD6;
				}
				IEnumerator<EleD> enumerator = null;
			}
			if (this.節足右2_接続 != null)
			{
				foreach (EleD eleD7 in (from e in this.節足右2_接続
				select e.EnumEleD()).JoinEnum<EleD>())
				{
					yield return eleD7;
				}
				IEnumerator<EleD> enumerator = null;
			}
			if (this.節足左1_接続 != null)
			{
				foreach (EleD eleD8 in (from e in this.節足左1_接続
				select e.EnumEleD()).JoinEnum<EleD>())
				{
					yield return eleD8;
				}
				IEnumerator<EleD> enumerator = null;
			}
			if (this.節足右1_接続 != null)
			{
				foreach (EleD eleD9 in (from e in this.節足右1_接続
				select e.EnumEleD()).JoinEnum<EleD>())
				{
					yield return eleD9;
				}
				IEnumerator<EleD> enumerator = null;
			}
			if (this.触肢左_接続 != null)
			{
				foreach (EleD eleD10 in (from e in this.触肢左_接続
				select e.EnumEleD()).JoinEnum<EleD>())
				{
					yield return eleD10;
				}
				IEnumerator<EleD> enumerator = null;
			}
			if (this.触肢右_接続 != null)
			{
				foreach (EleD eleD11 in (from e in this.触肢右_接続
				select e.EnumEleD()).JoinEnum<EleD>())
				{
					yield return eleD11;
				}
				IEnumerator<EleD> enumerator = null;
			}
			yield break;
			yield break;
		}

		public bool 胴_表示 = true;

		public bool 胸版_表示 = true;

		public bool 柄_表示 = true;

		public List<EleD> 触肢左_接続 = new List<EleD>();

		public List<EleD> 触肢右_接続 = new List<EleD>();

		public List<EleD> 節足左1_接続 = new List<EleD>();

		public List<EleD> 節足左2_接続 = new List<EleD>();

		public List<EleD> 節足左3_接続 = new List<EleD>();

		public List<EleD> 節足左4_接続 = new List<EleD>();

		public List<EleD> 節足右1_接続 = new List<EleD>();

		public List<EleD> 節足右2_接続 = new List<EleD>();

		public List<EleD> 節足右3_接続 = new List<EleD>();

		public List<EleD> 節足右4_接続 = new List<EleD>();

		public List<EleD> 尾_接続 = new List<EleD>();
	}
}
