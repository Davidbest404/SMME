using System;
using System.Collections.Generic;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 多足_蜘 : 半身
	{
		public 多足_蜘(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 多足_蜘D e)
		{
			多足_蜘.<>c__DisplayClass9_0 CS$<>8__locals1 = new 多足_蜘.<>c__DisplayClass9_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "蜘";
			dif.Add(new Pars(Sta.半身["多足"][0][1]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_胴 = pars["胴"].ToPar();
			this.X0Y0_胸版 = pars["胸版"].ToPar();
			this.X0Y0_柄 = pars["柄"].ToPar();
			this.本体.SetJoints();
			this.接続根 = new JointD(this.本体);
			this.右 = e.右;
			this.反転X = e.反転X;
			this.反転Y = e.反転Y;
			this.基準C = e.基準C;
			this.位置C = e.位置C;
			this.角度B = e.角度B;
			this.角度C = e.角度C;
			this.尺度B = e.尺度B;
			this.尺度C = e.尺度C;
			this.尺度XB = e.尺度XB;
			this.尺度XC = e.尺度XC;
			this.尺度YB = e.尺度YB;
			this.尺度YC = e.尺度YC;
			this.肥大 = e.肥大;
			this.身長 = e.身長;
			this.Xv = e.Xv;
			this.Yv = e.Yv;
			this.Xi = e.Xi;
			this.Yi = e.Yi;
			this.サイズ = e.サイズ;
			this.サイズX = e.サイズX;
			this.サイズY = e.サイズY;
			this.胴_表示 = e.胴_表示;
			this.胸版_表示 = e.胸版_表示;
			this.柄_表示 = e.柄_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.触肢左_接続.Count > 0)
			{
				Ele f;
				this.触肢左_接続 = e.触肢左_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.多足_蜘_触肢左_接続;
					f.接続(CS$<>8__locals1.<>4__this.触肢左_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.触肢右_接続.Count > 0)
			{
				Ele f;
				this.触肢右_接続 = e.触肢右_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.多足_蜘_触肢右_接続;
					f.接続(CS$<>8__locals1.<>4__this.触肢右_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.節足左1_接続.Count > 0)
			{
				Ele f;
				this.節足左1_接続 = e.節足左1_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.多足_蜘_節足左1_接続;
					f.接続(CS$<>8__locals1.<>4__this.節足左1_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.節足左2_接続.Count > 0)
			{
				Ele f;
				this.節足左2_接続 = e.節足左2_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.多足_蜘_節足左2_接続;
					f.接続(CS$<>8__locals1.<>4__this.節足左2_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.節足左3_接続.Count > 0)
			{
				Ele f;
				this.節足左3_接続 = e.節足左3_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.多足_蜘_節足左3_接続;
					f.接続(CS$<>8__locals1.<>4__this.節足左3_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.節足左4_接続.Count > 0)
			{
				Ele f;
				this.節足左4_接続 = e.節足左4_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.多足_蜘_節足左4_接続;
					f.接続(CS$<>8__locals1.<>4__this.節足左4_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.節足右1_接続.Count > 0)
			{
				Ele f;
				this.節足右1_接続 = e.節足右1_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.多足_蜘_節足右1_接続;
					f.接続(CS$<>8__locals1.<>4__this.節足右1_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.節足右2_接続.Count > 0)
			{
				Ele f;
				this.節足右2_接続 = e.節足右2_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.多足_蜘_節足右2_接続;
					f.接続(CS$<>8__locals1.<>4__this.節足右2_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.節足右3_接続.Count > 0)
			{
				Ele f;
				this.節足右3_接続 = e.節足右3_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.多足_蜘_節足右3_接続;
					f.接続(CS$<>8__locals1.<>4__this.節足右3_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.節足右4_接続.Count > 0)
			{
				Ele f;
				this.節足右4_接続 = e.節足右4_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.多足_蜘_節足右4_接続;
					f.接続(CS$<>8__locals1.<>4__this.節足右4_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.尾_接続.Count > 0)
			{
				Ele f;
				this.尾_接続 = e.尾_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.多足_蜘_尾_接続;
					f.接続(CS$<>8__locals1.<>4__this.尾_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_胴CP = new ColorP(this.X0Y0_胴, this.胴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胸版CP = new ColorP(this.X0Y0_胸版, this.胸版CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_柄CP = new ColorP(this.X0Y0_柄, this.柄CD, CS$<>8__locals1.DisUnit, true);
			this.濃度 = e.濃度;
		}

		public override bool 欠損
		{
			get
			{
				return this.欠損_;
			}
			set
			{
				this.欠損_ = value;
			}
		}

		public override bool 筋肉
		{
			get
			{
				return this.筋肉_;
			}
			set
			{
				this.筋肉_ = value;
			}
		}

		public override bool 拘束
		{
			get
			{
				return this.拘束_;
			}
			set
			{
				this.拘束_ = value;
			}
		}

		public bool 胴_表示
		{
			get
			{
				return this.X0Y0_胴.Dra;
			}
			set
			{
				this.X0Y0_胴.Dra = value;
				this.X0Y0_胴.Hit = value;
			}
		}

		public bool 胸版_表示
		{
			get
			{
				return this.X0Y0_胸版.Dra;
			}
			set
			{
				this.X0Y0_胸版.Dra = value;
				this.X0Y0_胸版.Hit = value;
			}
		}

		public bool 柄_表示
		{
			get
			{
				return this.X0Y0_柄.Dra;
			}
			set
			{
				this.X0Y0_柄.Dra = value;
				this.X0Y0_柄.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.胴_表示;
			}
			set
			{
				this.胴_表示 = value;
				this.胸版_表示 = value;
				this.柄_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.胴CD.不透明度;
			}
			set
			{
				this.胴CD.不透明度 = value;
				this.胸版CD.不透明度 = value;
				this.柄CD.不透明度 = value;
			}
		}

		public JointS 触肢左_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴, 10);
			}
		}

		public JointS 触肢右_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴, 11);
			}
		}

		public JointS 節足左1_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴, 2);
			}
		}

		public JointS 節足左2_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴, 4);
			}
		}

		public JointS 節足左3_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴, 6);
			}
		}

		public JointS 節足左4_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴, 8);
			}
		}

		public JointS 節足右1_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴, 3);
			}
		}

		public JointS 節足右2_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴, 5);
			}
		}

		public JointS 節足右3_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴, 7);
			}
		}

		public JointS 節足右4_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴, 9);
			}
		}

		public JointS 尾_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴, 0);
			}
		}

		public override void 色更新()
		{
			this.X0Y0_胴CP.Update();
			this.X0Y0_胸版CP.Update();
			this.X0Y0_柄CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			switch (this.配色指定)
			{
			case 配色指定.N0:
				this.配色N0(体配色);
				return;
			case 配色指定.T0:
				this.配色T0(体配色);
				return;
			case 配色指定.T1:
				this.配色T1(体配色);
				return;
			default:
				this.配色N0(体配色);
				return;
			}
		}

		private void 配色N0(体配色 体配色)
		{
			this.胴CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.胸版CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.柄CD = new ColorD(ref Col.Black, ref 体配色.体0O);
		}

		private void 配色T0(体配色 体配色)
		{
			this.胴CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.胸版CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.柄CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
		}

		private void 配色T1(体配色 体配色)
		{
			this.胴CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.胸版CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.柄CD = new ColorD(ref Col.Black, ref 体配色.体0O);
		}

		public override IEnumerable<Ele> EnumEle()
		{
			yield return this;
			if (this.尾_接続 != null)
			{
				foreach (Ele ele in (from e in this.尾_接続
				select e.EnumEle()).JoinEnum<Ele>())
				{
					yield return ele;
				}
				IEnumerator<Ele> enumerator = null;
			}
			if (this.節足左4_接続 != null)
			{
				foreach (Ele ele2 in (from e in this.節足左4_接続
				select e.EnumEle()).JoinEnum<Ele>())
				{
					yield return ele2;
				}
				IEnumerator<Ele> enumerator = null;
			}
			if (this.節足右4_接続 != null)
			{
				foreach (Ele ele3 in (from e in this.節足右4_接続
				select e.EnumEle()).JoinEnum<Ele>())
				{
					yield return ele3;
				}
				IEnumerator<Ele> enumerator = null;
			}
			if (this.節足左3_接続 != null)
			{
				foreach (Ele ele4 in (from e in this.節足左3_接続
				select e.EnumEle()).JoinEnum<Ele>())
				{
					yield return ele4;
				}
				IEnumerator<Ele> enumerator = null;
			}
			if (this.節足右3_接続 != null)
			{
				foreach (Ele ele5 in (from e in this.節足右3_接続
				select e.EnumEle()).JoinEnum<Ele>())
				{
					yield return ele5;
				}
				IEnumerator<Ele> enumerator = null;
			}
			if (this.節足左2_接続 != null)
			{
				foreach (Ele ele6 in (from e in this.節足左2_接続
				select e.EnumEle()).JoinEnum<Ele>())
				{
					yield return ele6;
				}
				IEnumerator<Ele> enumerator = null;
			}
			if (this.節足右2_接続 != null)
			{
				foreach (Ele ele7 in (from e in this.節足右2_接続
				select e.EnumEle()).JoinEnum<Ele>())
				{
					yield return ele7;
				}
				IEnumerator<Ele> enumerator = null;
			}
			if (this.節足左1_接続 != null)
			{
				foreach (Ele ele8 in (from e in this.節足左1_接続
				select e.EnumEle()).JoinEnum<Ele>())
				{
					yield return ele8;
				}
				IEnumerator<Ele> enumerator = null;
			}
			if (this.節足右1_接続 != null)
			{
				foreach (Ele ele9 in (from e in this.節足右1_接続
				select e.EnumEle()).JoinEnum<Ele>())
				{
					yield return ele9;
				}
				IEnumerator<Ele> enumerator = null;
			}
			if (this.触肢左_接続 != null)
			{
				foreach (Ele ele10 in (from e in this.触肢左_接続
				select e.EnumEle()).JoinEnum<Ele>())
				{
					yield return ele10;
				}
				IEnumerator<Ele> enumerator = null;
			}
			if (this.触肢右_接続 != null)
			{
				foreach (Ele ele11 in (from e in this.触肢右_接続
				select e.EnumEle()).JoinEnum<Ele>())
				{
					yield return ele11;
				}
				IEnumerator<Ele> enumerator = null;
			}
			yield break;
			yield break;
		}

		public Par X0Y0_胴;

		public Par X0Y0_胸版;

		public Par X0Y0_柄;

		public ColorD 胴CD;

		public ColorD 胸版CD;

		public ColorD 柄CD;

		public ColorP X0Y0_胴CP;

		public ColorP X0Y0_胸版CP;

		public ColorP X0Y0_柄CP;

		public Ele[] 触肢左_接続;

		public Ele[] 触肢右_接続;

		public Ele[] 節足左1_接続;

		public Ele[] 節足左2_接続;

		public Ele[] 節足左3_接続;

		public Ele[] 節足左4_接続;

		public Ele[] 節足右1_接続;

		public Ele[] 節足右2_接続;

		public Ele[] 節足右3_接続;

		public Ele[] 節足右4_接続;

		public Ele[] 尾_接続;
	}
}
