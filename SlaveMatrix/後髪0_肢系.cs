using System;
using System.Collections.Generic;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 後髪0_肢系 : 下ろし
	{
		public 後髪0_肢系(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 後髪0_肢系D e)
		{
			後髪0_肢系.<>c__DisplayClass3_0 CS$<>8__locals1 = new 後髪0_肢系.<>c__DisplayClass3_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "肢系";
			dif.Add(new Pars(Sta.胴体["後髪0"][0][21]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_髪基 = pars["髪基"].ToPar();
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
			this.髪基_表示 = e.髪基_表示;
			this.髪長0 = e.髪長0;
			if (e.スライム)
			{
				this.スライム();
			}
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.左5_接続.Count > 0)
			{
				Ele f;
				this.左5_接続 = e.左5_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.後髪0_肢系_左5_接続;
					f.接続(CS$<>8__locals1.<>4__this.左5_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.左4_接続.Count > 0)
			{
				Ele f;
				this.左4_接続 = e.左4_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.後髪0_肢系_左4_接続;
					f.接続(CS$<>8__locals1.<>4__this.左4_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.左3_接続.Count > 0)
			{
				Ele f;
				this.左3_接続 = e.左3_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.後髪0_肢系_左3_接続;
					f.接続(CS$<>8__locals1.<>4__this.左3_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.左2_接続.Count > 0)
			{
				Ele f;
				this.左2_接続 = e.左2_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.後髪0_肢系_左2_接続;
					f.接続(CS$<>8__locals1.<>4__this.左2_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.左1_接続.Count > 0)
			{
				Ele f;
				this.左1_接続 = e.左1_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.後髪0_肢系_左1_接続;
					f.接続(CS$<>8__locals1.<>4__this.左1_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.中央_接続.Count > 0)
			{
				Ele f;
				this.中央_接続 = e.中央_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.後髪0_肢系_中央_接続;
					f.接続(CS$<>8__locals1.<>4__this.中央_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右1_接続.Count > 0)
			{
				Ele f;
				this.右1_接続 = e.右1_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.後髪0_肢系_右1_接続;
					f.接続(CS$<>8__locals1.<>4__this.右1_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右2_接続.Count > 0)
			{
				Ele f;
				this.右2_接続 = e.右2_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.後髪0_肢系_右2_接続;
					f.接続(CS$<>8__locals1.<>4__this.右2_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右3_接続.Count > 0)
			{
				Ele f;
				this.右3_接続 = e.右3_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.後髪0_肢系_右3_接続;
					f.接続(CS$<>8__locals1.<>4__this.右3_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右4_接続.Count > 0)
			{
				Ele f;
				this.右4_接続 = e.右4_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.後髪0_肢系_右4_接続;
					f.接続(CS$<>8__locals1.<>4__this.右4_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右5_接続.Count > 0)
			{
				Ele f;
				this.右5_接続 = e.右5_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.後髪0_肢系_右5_接続;
					f.接続(CS$<>8__locals1.<>4__this.右5_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_髪基CP = new ColorP(this.X0Y0_髪基, this.髪基CD, CS$<>8__locals1.DisUnit, false);
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

		public bool 髪基_表示
		{
			get
			{
				return this.X0Y0_髪基.Dra;
			}
			set
			{
				this.X0Y0_髪基.Dra = value;
				this.X0Y0_髪基.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.髪基_表示;
			}
			set
			{
				this.髪基_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.髪基CD.不透明度;
			}
			set
			{
				this.髪基CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			bool 右 = this.右;
			this.本体.JoinPAall();
		}

		public double 髪長0
		{
			set
			{
				double num = 0.7 + 0.3 * value;
				this.X0Y0_髪基.SizeYBase *= num;
			}
		}

		public void スライム()
		{
			this.X0Y0_髪基.OP[this.右 ? 1 : 0].Outline = false;
			this.X0Y0_髪基.OP[this.右 ? 0 : 1].Outline = false;
		}

		public JointS 左5_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_髪基, 5);
			}
		}

		public JointS 左4_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_髪基, 1);
			}
		}

		public JointS 左3_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_髪基, 7);
			}
		}

		public JointS 左2_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_髪基, 3);
			}
		}

		public JointS 左1_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_髪基, 9);
			}
		}

		public JointS 中央_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_髪基, 0);
			}
		}

		public JointS 右1_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_髪基, 10);
			}
		}

		public JointS 右2_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_髪基, 4);
			}
		}

		public JointS 右3_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_髪基, 8);
			}
		}

		public JointS 右4_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_髪基, 2);
			}
		}

		public JointS 右5_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_髪基, 6);
			}
		}

		public override void 色更新()
		{
			this.X0Y0_髪基CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.髪基CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
		}

		public override IEnumerable<Ele> EnumEle()
		{
			yield return this;
			if (this.中央_接続 != null)
			{
				foreach (Ele ele in (from e in this.中央_接続
				select e.EnumEle()).JoinEnum<Ele>())
				{
					yield return ele;
				}
				IEnumerator<Ele> enumerator = null;
			}
			if (this.左1_接続 != null)
			{
				foreach (Ele ele2 in (from e in this.左1_接続
				select e.EnumEle()).JoinEnum<Ele>())
				{
					yield return ele2;
				}
				IEnumerator<Ele> enumerator = null;
			}
			if (this.右1_接続 != null)
			{
				foreach (Ele ele3 in (from e in this.右1_接続
				select e.EnumEle()).JoinEnum<Ele>())
				{
					yield return ele3;
				}
				IEnumerator<Ele> enumerator = null;
			}
			if (this.左2_接続 != null)
			{
				foreach (Ele ele4 in (from e in this.左2_接続
				select e.EnumEle()).JoinEnum<Ele>())
				{
					yield return ele4;
				}
				IEnumerator<Ele> enumerator = null;
			}
			if (this.右2_接続 != null)
			{
				foreach (Ele ele5 in (from e in this.右2_接続
				select e.EnumEle()).JoinEnum<Ele>())
				{
					yield return ele5;
				}
				IEnumerator<Ele> enumerator = null;
			}
			if (this.左3_接続 != null)
			{
				foreach (Ele ele6 in (from e in this.左3_接続
				select e.EnumEle()).JoinEnum<Ele>())
				{
					yield return ele6;
				}
				IEnumerator<Ele> enumerator = null;
			}
			if (this.右3_接続 != null)
			{
				foreach (Ele ele7 in (from e in this.右3_接続
				select e.EnumEle()).JoinEnum<Ele>())
				{
					yield return ele7;
				}
				IEnumerator<Ele> enumerator = null;
			}
			if (this.左4_接続 != null)
			{
				foreach (Ele ele8 in (from e in this.左4_接続
				select e.EnumEle()).JoinEnum<Ele>())
				{
					yield return ele8;
				}
				IEnumerator<Ele> enumerator = null;
			}
			if (this.右4_接続 != null)
			{
				foreach (Ele ele9 in (from e in this.右4_接続
				select e.EnumEle()).JoinEnum<Ele>())
				{
					yield return ele9;
				}
				IEnumerator<Ele> enumerator = null;
			}
			if (this.左5_接続 != null)
			{
				foreach (Ele ele10 in (from e in this.左5_接続
				select e.EnumEle()).JoinEnum<Ele>())
				{
					yield return ele10;
				}
				IEnumerator<Ele> enumerator = null;
			}
			if (this.右5_接続 != null)
			{
				foreach (Ele ele11 in (from e in this.右5_接続
				select e.EnumEle()).JoinEnum<Ele>())
				{
					yield return ele11;
				}
				IEnumerator<Ele> enumerator = null;
			}
			yield break;
			yield break;
		}

		public Par X0Y0_髪基;

		public ColorD 髪基CD;

		public ColorP X0Y0_髪基CP;

		public Ele[] 左5_接続;

		public Ele[] 左4_接続;

		public Ele[] 左3_接続;

		public Ele[] 左2_接続;

		public Ele[] 左1_接続;

		public Ele[] 中央_接続;

		public Ele[] 右1_接続;

		public Ele[] 右2_接続;

		public Ele[] 右3_接続;

		public Ele[] 右4_接続;

		public Ele[] 右5_接続;
	}
}
