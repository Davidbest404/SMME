using System;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 上着ボトム_クロス : 上着ボトム
	{
		public 上着ボトム_クロス(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 上着ボトム_クロスD e)
		{
			上着ボトム_クロス.<>c__DisplayClass85_0 CS$<>8__locals1 = new 上着ボトム_クロス.<>c__DisplayClass85_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			Dif dif = new Dif(Sta.胴体["上着ボトム前"][0]);
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			Pars pars2 = pars["中"].ToPars();
			this.X0Y0_中_下地 = pars2["下地"].ToPar();
			this.X0Y0_中_皺1 = pars2["皺1"].ToPar();
			this.X0Y0_中_皺2 = pars2["皺2"].ToPar();
			pars2 = pars["左"].ToPars();
			this.X0Y0_左_下地 = pars2["下地"].ToPar();
			this.X0Y0_左_皺1 = pars2["皺1"].ToPar();
			this.X0Y0_左_皺2 = pars2["皺2"].ToPar();
			this.X0Y0_左_皺3 = pars2["皺3"].ToPar();
			this.X0Y0_左_皺4 = pars2["皺4"].ToPar();
			this.X0Y0_左_皺5 = pars2["皺5"].ToPar();
			this.X0Y0_左_皺6 = pars2["皺6"].ToPar();
			pars2 = pars["右"].ToPars();
			this.X0Y0_右_下地 = pars2["下地"].ToPar();
			this.X0Y0_右_皺1 = pars2["皺1"].ToPar();
			this.X0Y0_右_皺2 = pars2["皺2"].ToPar();
			this.X0Y0_右_皺3 = pars2["皺3"].ToPar();
			this.X0Y0_右_皺4 = pars2["皺4"].ToPar();
			this.X0Y0_右_皺5 = pars2["皺5"].ToPar();
			this.X0Y0_右_皺6 = pars2["皺6"].ToPar();
			Pars pars3 = this.本体[0][1];
			pars2 = pars3["中"].ToPars();
			this.X0Y1_中_下地 = pars2["下地"].ToPar();
			this.X0Y1_中_皺1 = pars2["皺1"].ToPar();
			this.X0Y1_中_皺2 = pars2["皺2"].ToPar();
			pars2 = pars3["左"].ToPars();
			this.X0Y1_左_下地 = pars2["下地"].ToPar();
			this.X0Y1_左_皺1 = pars2["皺1"].ToPar();
			this.X0Y1_左_皺2 = pars2["皺2"].ToPar();
			this.X0Y1_左_皺3 = pars2["皺3"].ToPar();
			this.X0Y1_左_皺4 = pars2["皺4"].ToPar();
			this.X0Y1_左_皺5 = pars2["皺5"].ToPar();
			this.X0Y1_左_皺6 = pars2["皺6"].ToPar();
			pars2 = pars3["右"].ToPars();
			this.X0Y1_右_下地 = pars2["下地"].ToPar();
			this.X0Y1_右_皺1 = pars2["皺1"].ToPar();
			this.X0Y1_右_皺2 = pars2["皺2"].ToPar();
			this.X0Y1_右_皺3 = pars2["皺3"].ToPar();
			this.X0Y1_右_皺4 = pars2["皺4"].ToPar();
			this.X0Y1_右_皺5 = pars2["皺5"].ToPar();
			this.X0Y1_右_皺6 = pars2["皺6"].ToPar();
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
			this.中_下地_表示 = e.中_下地_表示;
			this.中_皺1_表示 = e.中_皺1_表示;
			this.中_皺2_表示 = e.中_皺2_表示;
			this.左_下地_表示 = e.左_下地_表示;
			this.左_皺1_表示 = e.左_皺1_表示;
			this.左_皺2_表示 = e.左_皺2_表示;
			this.左_皺3_表示 = e.左_皺3_表示;
			this.左_皺4_表示 = e.左_皺4_表示;
			this.左_皺5_表示 = e.左_皺5_表示;
			this.左_皺6_表示 = e.左_皺6_表示;
			this.右_下地_表示 = e.右_下地_表示;
			this.右_皺1_表示 = e.右_皺1_表示;
			this.右_皺2_表示 = e.右_皺2_表示;
			this.右_皺3_表示 = e.右_皺3_表示;
			this.右_皺4_表示 = e.右_皺4_表示;
			this.右_皺5_表示 = e.右_皺5_表示;
			this.右_皺6_表示 = e.右_皺6_表示;
			this.ベ\u30FCス表示 = e.ベ\u30FCス表示;
			this.ベ\u30FCス皺1表示 = e.ベ\u30FCス皺1表示;
			this.ベ\u30FCス皺2表示 = e.ベ\u30FCス皺2表示;
			this.ベ\u30FCス皺3表示 = e.ベ\u30FCス皺3表示;
			this.ベ\u30FCス皺4表示 = e.ベ\u30FCス皺4表示;
			this.ベ\u30FCス皺5表示 = e.ベ\u30FCス皺5表示;
			this.中表示 = e.中表示;
			this.中皺1表示 = e.中皺1表示;
			this.中皺2表示 = e.中皺2表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.上着ボトム後_接続.Count > 0)
			{
				Ele f;
				this.上着ボトム後_接続 = e.上着ボトム後_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.上着ボトム_クロス_上着ボトム後_接続;
					f.接続(CS$<>8__locals1.<>4__this.上着ボトム後_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_中_下地CP = new ColorP(this.X0Y0_中_下地, this.中_下地CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_中_皺1CP = new ColorP(this.X0Y0_中_皺1, this.中_皺1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_中_皺2CP = new ColorP(this.X0Y0_中_皺2, this.中_皺2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_左_下地CP = new ColorP(this.X0Y0_左_下地, this.左_下地CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_左_皺1CP = new ColorP(this.X0Y0_左_皺1, this.左_皺1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_左_皺2CP = new ColorP(this.X0Y0_左_皺2, this.左_皺2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_左_皺3CP = new ColorP(this.X0Y0_左_皺3, this.左_皺3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_左_皺4CP = new ColorP(this.X0Y0_左_皺4, this.左_皺4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_左_皺5CP = new ColorP(this.X0Y0_左_皺5, this.左_皺5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_左_皺6CP = new ColorP(this.X0Y0_左_皺6, this.左_皺6CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_右_下地CP = new ColorP(this.X0Y0_右_下地, this.右_下地CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_右_皺1CP = new ColorP(this.X0Y0_右_皺1, this.右_皺1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_右_皺2CP = new ColorP(this.X0Y0_右_皺2, this.右_皺2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_右_皺3CP = new ColorP(this.X0Y0_右_皺3, this.右_皺3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_右_皺4CP = new ColorP(this.X0Y0_右_皺4, this.右_皺4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_右_皺5CP = new ColorP(this.X0Y0_右_皺5, this.右_皺5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_右_皺6CP = new ColorP(this.X0Y0_右_皺6, this.右_皺6CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_中_下地CP = new ColorP(this.X0Y1_中_下地, this.中_下地CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_中_皺1CP = new ColorP(this.X0Y1_中_皺1, this.中_皺1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_中_皺2CP = new ColorP(this.X0Y1_中_皺2, this.中_皺2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_左_下地CP = new ColorP(this.X0Y1_左_下地, this.左_下地CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_左_皺1CP = new ColorP(this.X0Y1_左_皺1, this.左_皺1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_左_皺2CP = new ColorP(this.X0Y1_左_皺2, this.左_皺2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_左_皺3CP = new ColorP(this.X0Y1_左_皺3, this.左_皺3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_左_皺4CP = new ColorP(this.X0Y1_左_皺4, this.左_皺4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_左_皺5CP = new ColorP(this.X0Y1_左_皺5, this.左_皺5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_左_皺6CP = new ColorP(this.X0Y1_左_皺6, this.左_皺6CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_右_下地CP = new ColorP(this.X0Y1_右_下地, this.右_下地CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_右_皺1CP = new ColorP(this.X0Y1_右_皺1, this.右_皺1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_右_皺2CP = new ColorP(this.X0Y1_右_皺2, this.右_皺2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_右_皺3CP = new ColorP(this.X0Y1_右_皺3, this.右_皺3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_右_皺4CP = new ColorP(this.X0Y1_右_皺4, this.右_皺4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_右_皺5CP = new ColorP(this.X0Y1_右_皺5, this.右_皺5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_右_皺6CP = new ColorP(this.X0Y1_右_皺6, this.右_皺6CD, CS$<>8__locals1.DisUnit, true);
			this.濃度 = e.濃度;
			this.尺度XB = 1.01;
			this.尺度YB = 0.95;
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

		public bool 中_下地_表示
		{
			get
			{
				return this.X0Y0_中_下地.Dra;
			}
			set
			{
				this.X0Y0_中_下地.Dra = value;
				this.X0Y1_中_下地.Dra = value;
				this.X0Y0_中_下地.Hit = false;
				this.X0Y1_中_下地.Hit = false;
			}
		}

		public bool 中_皺1_表示
		{
			get
			{
				return this.X0Y0_中_皺1.Dra;
			}
			set
			{
				this.X0Y0_中_皺1.Dra = value;
				this.X0Y1_中_皺1.Dra = value;
				this.X0Y0_中_皺1.Hit = false;
				this.X0Y1_中_皺1.Hit = false;
			}
		}

		public bool 中_皺2_表示
		{
			get
			{
				return this.X0Y0_中_皺2.Dra;
			}
			set
			{
				this.X0Y0_中_皺2.Dra = value;
				this.X0Y1_中_皺2.Dra = value;
				this.X0Y0_中_皺2.Hit = false;
				this.X0Y1_中_皺2.Hit = false;
			}
		}

		public bool 左_下地_表示
		{
			get
			{
				return this.X0Y0_左_下地.Dra;
			}
			set
			{
				this.X0Y0_左_下地.Dra = value;
				this.X0Y1_左_下地.Dra = value;
				this.X0Y0_左_下地.Hit = false;
				this.X0Y1_左_下地.Hit = false;
			}
		}

		public bool 左_皺1_表示
		{
			get
			{
				return this.X0Y0_左_皺1.Dra;
			}
			set
			{
				this.X0Y0_左_皺1.Dra = value;
				this.X0Y1_左_皺1.Dra = value;
				this.X0Y0_左_皺1.Hit = false;
				this.X0Y1_左_皺1.Hit = false;
			}
		}

		public bool 左_皺2_表示
		{
			get
			{
				return this.X0Y0_左_皺2.Dra;
			}
			set
			{
				this.X0Y0_左_皺2.Dra = value;
				this.X0Y1_左_皺2.Dra = value;
				this.X0Y0_左_皺2.Hit = false;
				this.X0Y1_左_皺2.Hit = false;
			}
		}

		public bool 左_皺3_表示
		{
			get
			{
				return this.X0Y0_左_皺3.Dra;
			}
			set
			{
				this.X0Y0_左_皺3.Dra = value;
				this.X0Y1_左_皺3.Dra = value;
				this.X0Y0_左_皺3.Hit = false;
				this.X0Y1_左_皺3.Hit = false;
			}
		}

		public bool 左_皺4_表示
		{
			get
			{
				return this.X0Y0_左_皺4.Dra;
			}
			set
			{
				this.X0Y0_左_皺4.Dra = value;
				this.X0Y1_左_皺4.Dra = value;
				this.X0Y0_左_皺4.Hit = false;
				this.X0Y1_左_皺4.Hit = false;
			}
		}

		public bool 左_皺5_表示
		{
			get
			{
				return this.X0Y0_左_皺5.Dra;
			}
			set
			{
				this.X0Y0_左_皺5.Dra = value;
				this.X0Y1_左_皺5.Dra = value;
				this.X0Y0_左_皺5.Hit = false;
				this.X0Y1_左_皺5.Hit = false;
			}
		}

		public bool 左_皺6_表示
		{
			get
			{
				return this.X0Y0_左_皺6.Dra;
			}
			set
			{
				this.X0Y0_左_皺6.Dra = value;
				this.X0Y1_左_皺6.Dra = value;
				this.X0Y0_左_皺6.Hit = false;
				this.X0Y1_左_皺6.Hit = false;
			}
		}

		public bool 右_下地_表示
		{
			get
			{
				return this.X0Y0_右_下地.Dra;
			}
			set
			{
				this.X0Y0_右_下地.Dra = value;
				this.X0Y1_右_下地.Dra = value;
				this.X0Y0_右_下地.Hit = false;
				this.X0Y1_右_下地.Hit = false;
			}
		}

		public bool 右_皺1_表示
		{
			get
			{
				return this.X0Y0_右_皺1.Dra;
			}
			set
			{
				this.X0Y0_右_皺1.Dra = value;
				this.X0Y1_右_皺1.Dra = value;
				this.X0Y0_右_皺1.Hit = false;
				this.X0Y1_右_皺1.Hit = false;
			}
		}

		public bool 右_皺2_表示
		{
			get
			{
				return this.X0Y0_右_皺2.Dra;
			}
			set
			{
				this.X0Y0_右_皺2.Dra = value;
				this.X0Y1_右_皺2.Dra = value;
				this.X0Y0_右_皺2.Hit = false;
				this.X0Y1_右_皺2.Hit = false;
			}
		}

		public bool 右_皺3_表示
		{
			get
			{
				return this.X0Y0_右_皺3.Dra;
			}
			set
			{
				this.X0Y0_右_皺3.Dra = value;
				this.X0Y1_右_皺3.Dra = value;
				this.X0Y0_右_皺3.Hit = false;
				this.X0Y1_右_皺3.Hit = false;
			}
		}

		public bool 右_皺4_表示
		{
			get
			{
				return this.X0Y0_右_皺4.Dra;
			}
			set
			{
				this.X0Y0_右_皺4.Dra = value;
				this.X0Y1_右_皺4.Dra = value;
				this.X0Y0_右_皺4.Hit = false;
				this.X0Y1_右_皺4.Hit = false;
			}
		}

		public bool 右_皺5_表示
		{
			get
			{
				return this.X0Y0_右_皺5.Dra;
			}
			set
			{
				this.X0Y0_右_皺5.Dra = value;
				this.X0Y1_右_皺5.Dra = value;
				this.X0Y0_右_皺5.Hit = false;
				this.X0Y1_右_皺5.Hit = false;
			}
		}

		public bool 右_皺6_表示
		{
			get
			{
				return this.X0Y0_右_皺6.Dra;
			}
			set
			{
				this.X0Y0_右_皺6.Dra = value;
				this.X0Y1_右_皺6.Dra = value;
				this.X0Y0_右_皺6.Hit = false;
				this.X0Y1_右_皺6.Hit = false;
			}
		}

		public bool ベ\u30FCス表示
		{
			get
			{
				return this.左_下地_表示;
			}
			set
			{
				this.左_下地_表示 = value;
				this.右_下地_表示 = value;
				this.左_皺1_表示 = value;
				this.右_皺1_表示 = value;
			}
		}

		public bool ベ\u30FCス皺1表示
		{
			get
			{
				return this.左_皺2_表示;
			}
			set
			{
				this.左_皺2_表示 = value;
				this.右_皺2_表示 = value;
			}
		}

		public bool ベ\u30FCス皺2表示
		{
			get
			{
				return this.左_皺3_表示;
			}
			set
			{
				this.左_皺3_表示 = value;
				this.右_皺3_表示 = value;
			}
		}

		public bool ベ\u30FCス皺3表示
		{
			get
			{
				return this.左_皺4_表示;
			}
			set
			{
				this.左_皺4_表示 = value;
				this.右_皺4_表示 = value;
			}
		}

		public bool ベ\u30FCス皺4表示
		{
			get
			{
				return this.左_皺5_表示;
			}
			set
			{
				this.左_皺5_表示 = value;
				this.右_皺5_表示 = value;
			}
		}

		public bool ベ\u30FCス皺5表示
		{
			get
			{
				return this.左_皺6_表示;
			}
			set
			{
				this.左_皺6_表示 = value;
				this.右_皺6_表示 = value;
			}
		}

		public bool 中表示
		{
			get
			{
				return this.中_下地_表示;
			}
			set
			{
				this.中_下地_表示 = value;
			}
		}

		public bool 中皺1表示
		{
			get
			{
				return this.中_皺1_表示;
			}
			set
			{
				this.中_皺1_表示 = value;
			}
		}

		public bool 中皺2表示
		{
			get
			{
				return this.中_皺2_表示;
			}
			set
			{
				this.中_皺2_表示 = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.中_下地_表示;
			}
			set
			{
				this.中_下地_表示 = value;
				this.中_皺1_表示 = value;
				this.中_皺2_表示 = value;
				this.左_下地_表示 = value;
				this.左_皺1_表示 = value;
				this.左_皺2_表示 = value;
				this.左_皺3_表示 = value;
				this.左_皺4_表示 = value;
				this.左_皺5_表示 = value;
				this.左_皺6_表示 = value;
				this.右_下地_表示 = value;
				this.右_皺1_表示 = value;
				this.右_皺2_表示 = value;
				this.右_皺3_表示 = value;
				this.右_皺4_表示 = value;
				this.右_皺5_表示 = value;
				this.右_皺6_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.中_下地CD.不透明度;
			}
			set
			{
				this.中_下地CD.不透明度 = value;
				this.中_皺1CD.不透明度 = value;
				this.中_皺2CD.不透明度 = value;
				this.左_下地CD.不透明度 = value;
				this.左_皺1CD.不透明度 = value;
				this.左_皺2CD.不透明度 = value;
				this.左_皺3CD.不透明度 = value;
				this.左_皺4CD.不透明度 = value;
				this.左_皺5CD.不透明度 = value;
				this.左_皺6CD.不透明度 = value;
				this.右_下地CD.不透明度 = value;
				this.右_皺1CD.不透明度 = value;
				this.右_皺2CD.不透明度 = value;
				this.右_皺3CD.不透明度 = value;
				this.右_皺4CD.不透明度 = value;
				this.右_皺5CD.不透明度 = value;
				this.右_皺6CD.不透明度 = value;
			}
		}

		public override bool Is布(Par p)
		{
			return p == this.X0Y0_中_下地 || p == this.X0Y0_中_皺1 || p == this.X0Y0_中_皺2 || p == this.X0Y0_左_下地 || p == this.X0Y0_左_皺1 || p == this.X0Y0_左_皺2 || p == this.X0Y0_左_皺3 || p == this.X0Y0_左_皺4 || p == this.X0Y0_左_皺5 || p == this.X0Y0_左_皺6 || p == this.X0Y0_右_下地 || p == this.X0Y0_右_皺1 || p == this.X0Y0_右_皺2 || p == this.X0Y0_右_皺3 || p == this.X0Y0_右_皺4 || p == this.X0Y0_右_皺5 || p == this.X0Y0_右_皺6 || p == this.X0Y1_中_下地 || p == this.X0Y1_中_皺1 || p == this.X0Y1_中_皺2 || p == this.X0Y1_左_下地 || p == this.X0Y1_左_皺1 || p == this.X0Y1_左_皺2 || p == this.X0Y1_左_皺3 || p == this.X0Y1_左_皺4 || p == this.X0Y1_左_皺5 || p == this.X0Y1_左_皺6 || p == this.X0Y1_右_下地 || p == this.X0Y1_右_皺1 || p == this.X0Y1_右_皺2 || p == this.X0Y1_右_皺3 || p == this.X0Y1_右_皺4 || p == this.X0Y1_右_皺5 || p == this.X0Y1_右_皺6;
		}

		public JointS 上着ボトム後_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_中_下地, 4);
			}
		}

		public override void 色更新()
		{
			if (this.本体.IndexY == 0)
			{
				this.X0Y0_中_下地CP.Update();
				this.X0Y0_中_皺1CP.Update();
				this.X0Y0_中_皺2CP.Update();
				this.X0Y0_左_下地CP.Update();
				this.X0Y0_左_皺1CP.Update();
				this.X0Y0_左_皺2CP.Update();
				this.X0Y0_左_皺3CP.Update();
				this.X0Y0_左_皺4CP.Update();
				this.X0Y0_左_皺5CP.Update();
				this.X0Y0_左_皺6CP.Update();
				this.X0Y0_右_下地CP.Update();
				this.X0Y0_右_皺1CP.Update();
				this.X0Y0_右_皺2CP.Update();
				this.X0Y0_右_皺3CP.Update();
				this.X0Y0_右_皺4CP.Update();
				this.X0Y0_右_皺5CP.Update();
				this.X0Y0_右_皺6CP.Update();
				return;
			}
			this.X0Y1_中_下地CP.Update();
			this.X0Y1_中_皺1CP.Update();
			this.X0Y1_中_皺2CP.Update();
			this.X0Y1_左_下地CP.Update();
			this.X0Y1_左_皺1CP.Update();
			this.X0Y1_左_皺2CP.Update();
			this.X0Y1_左_皺3CP.Update();
			this.X0Y1_左_皺4CP.Update();
			this.X0Y1_左_皺5CP.Update();
			this.X0Y1_左_皺6CP.Update();
			this.X0Y1_右_下地CP.Update();
			this.X0Y1_右_皺1CP.Update();
			this.X0Y1_右_皺2CP.Update();
			this.X0Y1_右_皺3CP.Update();
			this.X0Y1_右_皺4CP.Update();
			this.X0Y1_右_皺5CP.Update();
			this.X0Y1_右_皺6CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.中_下地CD = new ColorD();
			this.中_皺1CD = new ColorD();
			this.中_皺2CD = new ColorD();
			this.左_下地CD = new ColorD();
			this.左_皺1CD = new ColorD();
			this.左_皺2CD = new ColorD();
			this.左_皺3CD = new ColorD();
			this.左_皺4CD = new ColorD();
			this.左_皺5CD = new ColorD();
			this.左_皺6CD = new ColorD();
			this.右_下地CD = new ColorD();
			this.右_皺1CD = new ColorD();
			this.右_皺2CD = new ColorD();
			this.右_皺3CD = new ColorD();
			this.右_皺4CD = new ColorD();
			this.右_皺5CD = new ColorD();
			this.右_皺6CD = new ColorD();
		}

		public void 配色(クロスB色 配色)
		{
			this.中_下地CD.色 = 配色.生地2色;
			this.中_皺1CD.色 = this.中_下地CD.色;
			this.中_皺2CD.色 = this.中_下地CD.色;
			this.左_下地CD.色 = 配色.生地1色;
			this.左_皺1CD.色 = this.左_下地CD.色;
			this.左_皺2CD.色 = this.左_下地CD.色;
			this.左_皺3CD.色 = this.左_下地CD.色;
			this.左_皺4CD.色 = this.左_下地CD.色;
			this.左_皺5CD.色 = this.左_下地CD.色;
			this.左_皺6CD.色 = this.左_下地CD.色;
			this.右_下地CD.色 = this.左_下地CD.色;
			this.右_皺1CD.色 = this.左_下地CD.色;
			this.右_皺2CD.色 = this.左_下地CD.色;
			this.右_皺3CD.色 = this.左_下地CD.色;
			this.右_皺4CD.色 = this.左_下地CD.色;
			this.右_皺5CD.色 = this.左_下地CD.色;
			this.右_皺6CD.色 = this.左_下地CD.色;
		}

		public Par X0Y0_中_下地;

		public Par X0Y0_中_皺1;

		public Par X0Y0_中_皺2;

		public Par X0Y0_左_下地;

		public Par X0Y0_左_皺1;

		public Par X0Y0_左_皺2;

		public Par X0Y0_左_皺3;

		public Par X0Y0_左_皺4;

		public Par X0Y0_左_皺5;

		public Par X0Y0_左_皺6;

		public Par X0Y0_右_下地;

		public Par X0Y0_右_皺1;

		public Par X0Y0_右_皺2;

		public Par X0Y0_右_皺3;

		public Par X0Y0_右_皺4;

		public Par X0Y0_右_皺5;

		public Par X0Y0_右_皺6;

		public Par X0Y1_中_下地;

		public Par X0Y1_中_皺1;

		public Par X0Y1_中_皺2;

		public Par X0Y1_左_下地;

		public Par X0Y1_左_皺1;

		public Par X0Y1_左_皺2;

		public Par X0Y1_左_皺3;

		public Par X0Y1_左_皺4;

		public Par X0Y1_左_皺5;

		public Par X0Y1_左_皺6;

		public Par X0Y1_右_下地;

		public Par X0Y1_右_皺1;

		public Par X0Y1_右_皺2;

		public Par X0Y1_右_皺3;

		public Par X0Y1_右_皺4;

		public Par X0Y1_右_皺5;

		public Par X0Y1_右_皺6;

		public ColorD 中_下地CD;

		public ColorD 中_皺1CD;

		public ColorD 中_皺2CD;

		public ColorD 左_下地CD;

		public ColorD 左_皺1CD;

		public ColorD 左_皺2CD;

		public ColorD 左_皺3CD;

		public ColorD 左_皺4CD;

		public ColorD 左_皺5CD;

		public ColorD 左_皺6CD;

		public ColorD 右_下地CD;

		public ColorD 右_皺1CD;

		public ColorD 右_皺2CD;

		public ColorD 右_皺3CD;

		public ColorD 右_皺4CD;

		public ColorD 右_皺5CD;

		public ColorD 右_皺6CD;

		public ColorP X0Y0_中_下地CP;

		public ColorP X0Y0_中_皺1CP;

		public ColorP X0Y0_中_皺2CP;

		public ColorP X0Y0_左_下地CP;

		public ColorP X0Y0_左_皺1CP;

		public ColorP X0Y0_左_皺2CP;

		public ColorP X0Y0_左_皺3CP;

		public ColorP X0Y0_左_皺4CP;

		public ColorP X0Y0_左_皺5CP;

		public ColorP X0Y0_左_皺6CP;

		public ColorP X0Y0_右_下地CP;

		public ColorP X0Y0_右_皺1CP;

		public ColorP X0Y0_右_皺2CP;

		public ColorP X0Y0_右_皺3CP;

		public ColorP X0Y0_右_皺4CP;

		public ColorP X0Y0_右_皺5CP;

		public ColorP X0Y0_右_皺6CP;

		public ColorP X0Y1_中_下地CP;

		public ColorP X0Y1_中_皺1CP;

		public ColorP X0Y1_中_皺2CP;

		public ColorP X0Y1_左_下地CP;

		public ColorP X0Y1_左_皺1CP;

		public ColorP X0Y1_左_皺2CP;

		public ColorP X0Y1_左_皺3CP;

		public ColorP X0Y1_左_皺4CP;

		public ColorP X0Y1_左_皺5CP;

		public ColorP X0Y1_左_皺6CP;

		public ColorP X0Y1_右_下地CP;

		public ColorP X0Y1_右_皺1CP;

		public ColorP X0Y1_右_皺2CP;

		public ColorP X0Y1_右_皺3CP;

		public ColorP X0Y1_右_皺4CP;

		public ColorP X0Y1_右_皺5CP;

		public ColorP X0Y1_右_皺6CP;

		public Ele[] 上着ボトム後_接続;
	}
}
