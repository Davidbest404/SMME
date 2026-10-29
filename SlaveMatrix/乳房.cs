using System;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 乳房 : Ele
	{
		public 乳房(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 乳房D e)
		{
			乳房.<>c__DisplayClass135_0 CS$<>8__locals1 = new 乳房.<>c__DisplayClass135_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.胴体["胸左"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_乳房 = pars["乳房"].ToPar();
			this.X0Y0_乳輪 = pars["乳輪"].ToPar();
			this.X0Y0_乳首 = pars["乳首"].ToPar();
			Pars pars2 = pars["淫タトゥ"].ToPars();
			this.X0Y0_淫タトゥ_タトゥ1 = pars2["タトゥ1"].ToPar();
			this.X0Y0_淫タトゥ_タトゥ2 = pars2["タトゥ2"].ToPar();
			this.X0Y0_淫タトゥ_タトゥ3 = pars2["タトゥ3"].ToPar();
			this.X0Y0_淫タトゥ_タトゥ4 = pars2["タトゥ4"].ToPar();
			this.X0Y0_ハイライト1 = pars["ハイライト1"].ToPar();
			this.X0Y0_ハイライト2 = pars["ハイライト2"].ToPar();
			this.X0Y0_傷X = pars["傷X"].ToPar();
			this.X0Y0_傷I1 = pars["傷I1"].ToPar();
			this.X0Y0_傷I2 = pars["傷I2"].ToPar();
			pars2 = pars["虫性"].ToPars();
			this.X0Y0_虫性_甲殻 = pars2["甲殻"].ToPar();
			pars = this.本体[0][1];
			this.X0Y1_乳房 = pars["乳房"].ToPar();
			this.X0Y1_乳輪 = pars["乳輪"].ToPar();
			this.X0Y1_乳首 = pars["乳首"].ToPar();
			pars2 = pars["淫タトゥ"].ToPars();
			this.X0Y1_淫タトゥ_タトゥ1 = pars2["タトゥ1"].ToPar();
			this.X0Y1_淫タトゥ_タトゥ2 = pars2["タトゥ2"].ToPar();
			this.X0Y1_淫タトゥ_タトゥ3 = pars2["タトゥ3"].ToPar();
			this.X0Y1_淫タトゥ_タトゥ4 = pars2["タトゥ4"].ToPar();
			this.X0Y1_ハイライト1 = pars["ハイライト1"].ToPar();
			this.X0Y1_ハイライト2 = pars["ハイライト2"].ToPar();
			this.X0Y1_傷X = pars["傷X"].ToPar();
			this.X0Y1_傷I1 = pars["傷I1"].ToPar();
			this.X0Y1_傷I2 = pars["傷I2"].ToPar();
			pars2 = pars["虫性"].ToPars();
			this.X0Y1_虫性_甲殻 = pars2["甲殻"].ToPar();
			pars = this.本体[0][2];
			this.X0Y2_乳房 = pars["乳房"].ToPar();
			this.X0Y2_乳輪 = pars["乳輪"].ToPar();
			this.X0Y2_乳首 = pars["乳首"].ToPar();
			pars2 = pars["淫タトゥ"].ToPars();
			this.X0Y2_淫タトゥ_タトゥ3 = pars2["タトゥ3"].ToPar();
			this.X0Y2_淫タトゥ_タトゥ4 = pars2["タトゥ4"].ToPar();
			this.X0Y2_ハイライト1 = pars["ハイライト1"].ToPar();
			this.X0Y2_ハイライト2 = pars["ハイライト2"].ToPar();
			this.X0Y2_傷X = pars["傷X"].ToPar();
			this.X0Y2_傷I1 = pars["傷I1"].ToPar();
			this.X0Y2_傷I2 = pars["傷I2"].ToPar();
			pars2 = pars["虫性"].ToPars();
			this.X0Y2_虫性_甲殻 = pars2["甲殻"].ToPar();
			pars = this.本体[0][3];
			this.X0Y3_乳房 = pars["乳房"].ToPar();
			this.X0Y3_乳輪 = pars["乳輪"].ToPar();
			this.X0Y3_乳首 = pars["乳首"].ToPar();
			pars2 = pars["淫タトゥ"].ToPars();
			this.X0Y3_淫タトゥ_タトゥ1 = pars2["タトゥ1"].ToPar();
			this.X0Y3_淫タトゥ_タトゥ3 = pars2["タトゥ3"].ToPar();
			this.X0Y3_淫タトゥ_タトゥ4 = pars2["タトゥ4"].ToPar();
			this.X0Y3_ハイライト1 = pars["ハイライト1"].ToPar();
			this.X0Y3_ハイライト2 = pars["ハイライト2"].ToPar();
			this.X0Y3_傷X = pars["傷X"].ToPar();
			this.X0Y3_傷I1 = pars["傷I1"].ToPar();
			this.X0Y3_傷I2 = pars["傷I2"].ToPar();
			pars2 = pars["虫性"].ToPars();
			this.X0Y3_虫性_甲殻 = pars2["甲殻"].ToPar();
			pars = this.本体[0][4];
			this.X0Y4_乳房 = pars["乳房"].ToPar();
			this.X0Y4_乳輪 = pars["乳輪"].ToPar();
			this.X0Y4_乳首 = pars["乳首"].ToPar();
			pars2 = pars["淫タトゥ"].ToPars();
			this.X0Y4_淫タトゥ_タトゥ1 = pars2["タトゥ1"].ToPar();
			this.X0Y4_淫タトゥ_タトゥ3 = pars2["タトゥ3"].ToPar();
			this.X0Y4_淫タトゥ_タトゥ4 = pars2["タトゥ4"].ToPar();
			this.X0Y4_ハイライト1 = pars["ハイライト1"].ToPar();
			this.X0Y4_ハイライト2 = pars["ハイライト2"].ToPar();
			this.X0Y4_傷X = pars["傷X"].ToPar();
			this.X0Y4_傷I1 = pars["傷I1"].ToPar();
			this.X0Y4_傷I2 = pars["傷I2"].ToPar();
			pars2 = pars["虫性"].ToPars();
			this.X0Y4_虫性_甲殻 = pars2["甲殻"].ToPar();
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
			this.sb = this.尺度B;
			this.syb = this.尺度YB;
			this.肥大 = e.肥大;
			this.身長 = e.身長;
			this.Xv = e.Xv;
			this.Yv = e.Yv;
			this.Xi = e.Xi;
			this.Yi = e.Yi;
			this.サイズ = e.サイズ;
			this.サイズX = e.サイズX;
			this.サイズY = e.サイズY;
			this.乳房_表示 = e.乳房_表示;
			this.乳輪_表示 = e.乳輪_表示;
			this.乳首_表示 = e.乳首_表示;
			this.淫タトゥ_タトゥ1_表示 = e.淫タトゥ_タトゥ1_表示;
			this.淫タトゥ_タトゥ2_表示 = e.淫タトゥ_タトゥ2_表示;
			this.淫タトゥ_タトゥ3_表示 = e.淫タトゥ_タトゥ3_表示;
			this.淫タトゥ_タトゥ4_表示 = e.淫タトゥ_タトゥ4_表示;
			this.ハイライト1_表示 = e.ハイライト1_表示;
			this.ハイライト2_表示 = e.ハイライト2_表示;
			this.傷X_表示 = e.傷X_表示;
			this.傷I1_表示 = e.傷I1_表示;
			this.傷I2_表示 = e.傷I2_表示;
			this.虫性_甲殻_表示 = e.虫性_甲殻_表示;
			this.ハイライト表示 = e.ハイライト表示;
			this.バスト = e.バスト;
			this.着衣 = e.着衣;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.噴乳_接続.Count > 0)
			{
				Ele f;
				this.噴乳_接続 = e.噴乳_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.乳房_噴乳_接続;
					f.接続(CS$<>8__locals1.<>4__this.噴乳_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_乳房CP = new ColorP(this.X0Y0_乳房, this.乳房CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_乳輪CP = new ColorP(this.X0Y0_乳輪, this.乳輪CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_乳首CP = new ColorP(this.X0Y0_乳首, this.乳首CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_タトゥ1CP = new ColorP(this.X0Y0_淫タトゥ_タトゥ1, this.淫タトゥ_タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_タトゥ2CP = new ColorP(this.X0Y0_淫タトゥ_タトゥ2, this.淫タトゥ_タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_タトゥ3CP = new ColorP(this.X0Y0_淫タトゥ_タトゥ3, this.淫タトゥ_タトゥ3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_タトゥ4CP = new ColorP(this.X0Y0_淫タトゥ_タトゥ4, this.淫タトゥ_タトゥ4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ハイライト1CP = new ColorP(this.X0Y0_ハイライト1, this.ハイライト1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ハイライト2CP = new ColorP(this.X0Y0_ハイライト2, this.ハイライト2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_傷XCP = new ColorP(this.X0Y0_傷X, this.傷XCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_傷I1CP = new ColorP(this.X0Y0_傷I1, this.傷I1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_傷I2CP = new ColorP(this.X0Y0_傷I2, this.傷I2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫性_甲殻CP = new ColorP(this.X0Y0_虫性_甲殻, this.虫性_甲殻CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_乳房CP = new ColorP(this.X0Y1_乳房, this.乳房CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_乳輪CP = new ColorP(this.X0Y1_乳輪, this.乳輪CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_乳首CP = new ColorP(this.X0Y1_乳首, this.乳首CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_淫タトゥ_タトゥ1CP = new ColorP(this.X0Y1_淫タトゥ_タトゥ1, this.淫タトゥ_タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_淫タトゥ_タトゥ2CP = new ColorP(this.X0Y1_淫タトゥ_タトゥ2, this.淫タトゥ_タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_淫タトゥ_タトゥ3CP = new ColorP(this.X0Y1_淫タトゥ_タトゥ3, this.淫タトゥ_タトゥ3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_淫タトゥ_タトゥ4CP = new ColorP(this.X0Y1_淫タトゥ_タトゥ4, this.淫タトゥ_タトゥ4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ハイライト1CP = new ColorP(this.X0Y1_ハイライト1, this.ハイライト1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ハイライト2CP = new ColorP(this.X0Y1_ハイライト2, this.ハイライト2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_傷XCP = new ColorP(this.X0Y1_傷X, this.傷XCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_傷I1CP = new ColorP(this.X0Y1_傷I1, this.傷I1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_傷I2CP = new ColorP(this.X0Y1_傷I2, this.傷I2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_虫性_甲殻CP = new ColorP(this.X0Y1_虫性_甲殻, this.虫性_甲殻CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_乳房CP = new ColorP(this.X0Y2_乳房, this.乳房CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_乳輪CP = new ColorP(this.X0Y2_乳輪, this.乳輪CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_乳首CP = new ColorP(this.X0Y2_乳首, this.乳首CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_淫タトゥ_タトゥ3CP = new ColorP(this.X0Y2_淫タトゥ_タトゥ3, this.淫タトゥ_タトゥ3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_淫タトゥ_タトゥ4CP = new ColorP(this.X0Y2_淫タトゥ_タトゥ4, this.淫タトゥ_タトゥ4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_ハイライト1CP = new ColorP(this.X0Y2_ハイライト1, this.ハイライト1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_ハイライト2CP = new ColorP(this.X0Y2_ハイライト2, this.ハイライト2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_傷XCP = new ColorP(this.X0Y2_傷X, this.傷XCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_傷I1CP = new ColorP(this.X0Y2_傷I1, this.傷I1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_傷I2CP = new ColorP(this.X0Y2_傷I2, this.傷I2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_虫性_甲殻CP = new ColorP(this.X0Y2_虫性_甲殻, this.虫性_甲殻CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_乳房CP = new ColorP(this.X0Y3_乳房, this.乳房CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_乳輪CP = new ColorP(this.X0Y3_乳輪, this.乳輪CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_乳首CP = new ColorP(this.X0Y3_乳首, this.乳首CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_淫タトゥ_タトゥ1CP = new ColorP(this.X0Y3_淫タトゥ_タトゥ1, this.淫タトゥ_タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_淫タトゥ_タトゥ3CP = new ColorP(this.X0Y3_淫タトゥ_タトゥ3, this.淫タトゥ_タトゥ3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_淫タトゥ_タトゥ4CP = new ColorP(this.X0Y3_淫タトゥ_タトゥ4, this.淫タトゥ_タトゥ4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_ハイライト1CP = new ColorP(this.X0Y3_ハイライト1, this.ハイライト1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_ハイライト2CP = new ColorP(this.X0Y3_ハイライト2, this.ハイライト2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_傷XCP = new ColorP(this.X0Y3_傷X, this.傷XCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_傷I1CP = new ColorP(this.X0Y3_傷I1, this.傷I1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_傷I2CP = new ColorP(this.X0Y3_傷I2, this.傷I2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_虫性_甲殻CP = new ColorP(this.X0Y3_虫性_甲殻, this.虫性_甲殻CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_乳房CP = new ColorP(this.X0Y4_乳房, this.乳房CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_乳輪CP = new ColorP(this.X0Y4_乳輪, this.乳輪CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_乳首CP = new ColorP(this.X0Y4_乳首, this.乳首CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_淫タトゥ_タトゥ1CP = new ColorP(this.X0Y4_淫タトゥ_タトゥ1, this.淫タトゥ_タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_淫タトゥ_タトゥ3CP = new ColorP(this.X0Y4_淫タトゥ_タトゥ3, this.淫タトゥ_タトゥ3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_淫タトゥ_タトゥ4CP = new ColorP(this.X0Y4_淫タトゥ_タトゥ4, this.淫タトゥ_タトゥ4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_ハイライト1CP = new ColorP(this.X0Y4_ハイライト1, this.ハイライト1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_ハイライト2CP = new ColorP(this.X0Y4_ハイライト2, this.ハイライト2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_傷XCP = new ColorP(this.X0Y4_傷X, this.傷XCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_傷I1CP = new ColorP(this.X0Y4_傷I1, this.傷I1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_傷I2CP = new ColorP(this.X0Y4_傷I2, this.傷I2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_虫性_甲殻CP = new ColorP(this.X0Y4_虫性_甲殻, this.虫性_甲殻CD, CS$<>8__locals1.DisUnit, true);
			this.傷X濃度 = e.傷X濃度;
			this.傷I1濃度 = e.傷I1濃度;
			this.傷I2濃度 = e.傷I2濃度;
			this.ハイライト濃度 = e.ハイライト濃度;
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

		public bool 乳房_表示
		{
			get
			{
				return this.X0Y0_乳房.Dra;
			}
			set
			{
				this.X0Y0_乳房.Dra = value;
				this.X0Y1_乳房.Dra = value;
				this.X0Y2_乳房.Dra = value;
				this.X0Y3_乳房.Dra = value;
				this.X0Y4_乳房.Dra = value;
				this.X0Y0_乳房.Hit = value;
				this.X0Y1_乳房.Hit = value;
				this.X0Y2_乳房.Hit = value;
				this.X0Y3_乳房.Hit = value;
				this.X0Y4_乳房.Hit = value;
			}
		}

		public bool 乳輪_表示
		{
			get
			{
				return this.X0Y0_乳輪.Dra;
			}
			set
			{
				this.X0Y0_乳輪.Dra = value;
				this.X0Y1_乳輪.Dra = value;
				this.X0Y2_乳輪.Dra = value;
				this.X0Y3_乳輪.Dra = value;
				this.X0Y4_乳輪.Dra = value;
				this.X0Y0_乳輪.Hit = value;
				this.X0Y1_乳輪.Hit = value;
				this.X0Y2_乳輪.Hit = value;
				this.X0Y3_乳輪.Hit = value;
				this.X0Y4_乳輪.Hit = value;
			}
		}

		public bool 乳首_表示
		{
			get
			{
				return this.X0Y0_乳首.Dra;
			}
			set
			{
				this.X0Y0_乳首.Dra = value;
				this.X0Y1_乳首.Dra = value;
				this.X0Y2_乳首.Dra = value;
				this.X0Y3_乳首.Dra = value;
				this.X0Y4_乳首.Dra = value;
				this.X0Y0_乳首.Hit = value;
				this.X0Y1_乳首.Hit = value;
				this.X0Y2_乳首.Hit = value;
				this.X0Y3_乳首.Hit = value;
				this.X0Y4_乳首.Hit = value;
			}
		}

		public bool 淫タトゥ_タトゥ1_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_タトゥ1.Dra = value;
				this.X0Y1_淫タトゥ_タトゥ1.Dra = value;
				this.X0Y3_淫タトゥ_タトゥ1.Dra = value;
				this.X0Y4_淫タトゥ_タトゥ1.Dra = value;
				this.X0Y0_淫タトゥ_タトゥ1.Hit = value;
				this.X0Y1_淫タトゥ_タトゥ1.Hit = value;
				this.X0Y3_淫タトゥ_タトゥ1.Hit = value;
				this.X0Y4_淫タトゥ_タトゥ1.Hit = value;
			}
		}

		public bool 淫タトゥ_タトゥ2_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_タトゥ2.Dra = value;
				this.X0Y1_淫タトゥ_タトゥ2.Dra = value;
				this.X0Y0_淫タトゥ_タトゥ2.Hit = value;
				this.X0Y1_淫タトゥ_タトゥ2.Hit = value;
			}
		}

		public bool 淫タトゥ_タトゥ3_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_タトゥ3.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_タトゥ3.Dra = value;
				this.X0Y1_淫タトゥ_タトゥ3.Dra = value;
				this.X0Y2_淫タトゥ_タトゥ3.Dra = value;
				this.X0Y3_淫タトゥ_タトゥ3.Dra = value;
				this.X0Y4_淫タトゥ_タトゥ3.Dra = value;
				this.X0Y0_淫タトゥ_タトゥ3.Hit = value;
				this.X0Y1_淫タトゥ_タトゥ3.Hit = value;
				this.X0Y2_淫タトゥ_タトゥ3.Hit = value;
				this.X0Y3_淫タトゥ_タトゥ3.Hit = value;
				this.X0Y4_淫タトゥ_タトゥ3.Hit = value;
			}
		}

		public bool 淫タトゥ_タトゥ4_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_タトゥ4.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_タトゥ4.Dra = value;
				this.X0Y1_淫タトゥ_タトゥ4.Dra = value;
				this.X0Y2_淫タトゥ_タトゥ4.Dra = value;
				this.X0Y3_淫タトゥ_タトゥ4.Dra = value;
				this.X0Y4_淫タトゥ_タトゥ4.Dra = value;
				this.X0Y0_淫タトゥ_タトゥ4.Hit = value;
				this.X0Y1_淫タトゥ_タトゥ4.Hit = value;
				this.X0Y2_淫タトゥ_タトゥ4.Hit = value;
				this.X0Y3_淫タトゥ_タトゥ4.Hit = value;
				this.X0Y4_淫タトゥ_タトゥ4.Hit = value;
			}
		}

		public bool ハイライト1_表示
		{
			get
			{
				return this.X0Y0_ハイライト1.Dra;
			}
			set
			{
				this.X0Y0_ハイライト1.Dra = value;
				this.X0Y1_ハイライト1.Dra = value;
				this.X0Y2_ハイライト1.Dra = value;
				this.X0Y3_ハイライト1.Dra = value;
				this.X0Y4_ハイライト1.Dra = value;
				this.X0Y0_ハイライト1.Hit = value;
				this.X0Y1_ハイライト1.Hit = value;
				this.X0Y2_ハイライト1.Hit = value;
				this.X0Y3_ハイライト1.Hit = value;
				this.X0Y4_ハイライト1.Hit = value;
			}
		}

		public bool ハイライト2_表示
		{
			get
			{
				return this.X0Y0_ハイライト2.Dra;
			}
			set
			{
				this.X0Y0_ハイライト2.Dra = value;
				this.X0Y1_ハイライト2.Dra = value;
				this.X0Y2_ハイライト2.Dra = value;
				this.X0Y3_ハイライト2.Dra = value;
				this.X0Y4_ハイライト2.Dra = value;
				this.X0Y0_ハイライト2.Hit = value;
				this.X0Y1_ハイライト2.Hit = value;
				this.X0Y2_ハイライト2.Hit = value;
				this.X0Y3_ハイライト2.Hit = value;
				this.X0Y4_ハイライト2.Hit = value;
			}
		}

		public bool 傷X_表示
		{
			get
			{
				return this.X0Y0_傷X.Dra;
			}
			set
			{
				this.X0Y0_傷X.Dra = value;
				this.X0Y1_傷X.Dra = value;
				this.X0Y2_傷X.Dra = value;
				this.X0Y3_傷X.Dra = value;
				this.X0Y4_傷X.Dra = value;
				this.X0Y0_傷X.Hit = value;
				this.X0Y1_傷X.Hit = value;
				this.X0Y2_傷X.Hit = value;
				this.X0Y3_傷X.Hit = value;
				this.X0Y4_傷X.Hit = value;
			}
		}

		public bool 傷I1_表示
		{
			get
			{
				return this.X0Y0_傷I1.Dra;
			}
			set
			{
				this.X0Y0_傷I1.Dra = value;
				this.X0Y1_傷I1.Dra = value;
				this.X0Y2_傷I1.Dra = value;
				this.X0Y3_傷I1.Dra = value;
				this.X0Y4_傷I1.Dra = value;
				this.X0Y0_傷I1.Hit = value;
				this.X0Y1_傷I1.Hit = value;
				this.X0Y2_傷I1.Hit = value;
				this.X0Y3_傷I1.Hit = value;
				this.X0Y4_傷I1.Hit = value;
			}
		}

		public bool 傷I2_表示
		{
			get
			{
				return this.X0Y0_傷I2.Dra;
			}
			set
			{
				this.X0Y0_傷I2.Dra = value;
				this.X0Y1_傷I2.Dra = value;
				this.X0Y2_傷I2.Dra = value;
				this.X0Y3_傷I2.Dra = value;
				this.X0Y4_傷I2.Dra = value;
				this.X0Y0_傷I2.Hit = value;
				this.X0Y1_傷I2.Hit = value;
				this.X0Y2_傷I2.Hit = value;
				this.X0Y3_傷I2.Hit = value;
				this.X0Y4_傷I2.Hit = value;
			}
		}

		public bool 虫性_甲殻_表示
		{
			get
			{
				return this.X0Y0_虫性_甲殻.Dra;
			}
			set
			{
				this.X0Y0_虫性_甲殻.Dra = value;
				this.X0Y1_虫性_甲殻.Dra = value;
				this.X0Y2_虫性_甲殻.Dra = value;
				this.X0Y3_虫性_甲殻.Dra = value;
				this.X0Y4_虫性_甲殻.Dra = value;
				this.X0Y0_虫性_甲殻.Hit = value;
				this.X0Y1_虫性_甲殻.Hit = value;
				this.X0Y2_虫性_甲殻.Hit = value;
				this.X0Y3_虫性_甲殻.Hit = value;
				this.X0Y4_虫性_甲殻.Hit = value;
			}
		}

		public bool ハイライト表示
		{
			get
			{
				return this.ハイライト1_表示;
			}
			set
			{
				this.ハイライト1_表示 = value;
				this.ハイライト2_表示 = value;
			}
		}

		public double 傷X濃度
		{
			get
			{
				return this.傷XCD.不透明度;
			}
			set
			{
				this.傷XCD.不透明度 = value;
			}
		}

		public double 傷I1濃度
		{
			get
			{
				return this.傷I1CD.不透明度;
			}
			set
			{
				this.傷I1CD.不透明度 = value;
			}
		}

		public double 傷I2濃度
		{
			get
			{
				return this.傷I2CD.不透明度;
			}
			set
			{
				this.傷I2CD.不透明度 = value;
			}
		}

		public double ハイライト濃度
		{
			get
			{
				return this.ハイライト1CD.不透明度;
			}
			set
			{
				this.ハイライト1CD.不透明度 = value;
				this.ハイライト2CD.不透明度 = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.乳房_表示;
			}
			set
			{
				this.乳房_表示 = value;
				this.乳輪_表示 = value;
				this.乳首_表示 = value;
				this.淫タトゥ_タトゥ1_表示 = value;
				this.淫タトゥ_タトゥ2_表示 = value;
				this.淫タトゥ_タトゥ3_表示 = value;
				this.淫タトゥ_タトゥ4_表示 = value;
				this.ハイライト1_表示 = value;
				this.ハイライト2_表示 = value;
				this.傷X_表示 = value;
				this.傷I1_表示 = value;
				this.傷I2_表示 = value;
				this.虫性_甲殻_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.乳房CD.不透明度;
			}
			set
			{
				this.乳房CD.不透明度 = value;
				this.乳輪CD.不透明度 = value;
				this.乳首CD.不透明度 = value;
				this.淫タトゥ_タトゥ1CD.不透明度 = value;
				this.淫タトゥ_タトゥ2CD.不透明度 = value;
				this.淫タトゥ_タトゥ3CD.不透明度 = value;
				this.淫タトゥ_タトゥ4CD.不透明度 = value;
				this.ハイライト1CD.不透明度 = value;
				this.ハイライト2CD.不透明度 = value;
				this.傷XCD.不透明度 = value;
				this.傷I1CD.不透明度 = value;
				this.傷I2CD.不透明度 = value;
				this.虫性_甲殻CD.不透明度 = value;
			}
		}

		public double バスト
		{
			get
			{
				return this.バスト_;
			}
			set
			{
				this.バスト_ = value;
				this.尺度B_ = this.sb * (0.9 + 0.25 * this.バスト_);
				this.尺度YB_ = this.syb * (1.0 + 0.05 * this.バスト_);
				if (this.バスト_ <= 0.2)
				{
					this.X0Y0_乳房.OP.OutlineFalse();
					this.X0Y1_乳房.OP.OutlineFalse();
					this.X0Y2_乳房.OP.OutlineFalse();
					this.X0Y3_乳房.OP.OutlineFalse();
					this.X0Y4_乳房.OP.OutlineFalse();
					this.X0Y0_乳房.OP[this.右 ? 1 : 3].Outline = true;
					this.X0Y1_乳房.OP[this.右 ? 1 : 3].Outline = true;
					this.X0Y2_乳房.OP[this.右 ? 1 : 3].Outline = true;
					this.X0Y3_乳房.OP[this.右 ? 1 : 3].Outline = true;
					this.X0Y4_乳房.OP[this.右 ? 1 : 3].Outline = true;
					this.X0Y0_乳房.OP[this.右 ? 0 : 4].Outline = true;
					this.X0Y1_乳房.OP[this.右 ? 0 : 4].Outline = true;
					this.X0Y2_乳房.OP[this.右 ? 0 : 4].Outline = true;
					this.X0Y3_乳房.OP[this.右 ? 0 : 4].Outline = true;
					this.X0Y4_乳房.OP[this.右 ? 0 : 4].Outline = true;
					this.X0Y0_淫タトゥ_タトゥ4.OP[this.右 ? 2 : 0].Outline = false;
					this.X0Y1_淫タトゥ_タトゥ4.OP[this.右 ? 2 : 0].Outline = false;
					this.X0Y2_淫タトゥ_タトゥ4.OP[this.右 ? 2 : 0].Outline = false;
					this.X0Y3_淫タトゥ_タトゥ4.OP[this.右 ? 2 : 0].Outline = false;
					this.X0Y4_淫タトゥ_タトゥ4.OP[this.右 ? 2 : 0].Outline = false;
				}
			}
		}

		public virtual double 尺度B_
		{
			get
			{
				return this.本体.CurJoinRoot.SizeBase;
			}
			set
			{
				foreach (Par par in this.本体.EnumAllPar())
				{
					par.SizeBase = value;
				}
				this.本体.JoinP();
			}
		}

		public virtual double 尺度YB_
		{
			get
			{
				return this.本体.CurJoinRoot.SizeYBase;
			}
			set
			{
				foreach (Par par in this.本体.EnumAllPar())
				{
					par.SizeYBase = value;
				}
				this.本体.JoinP();
			}
		}

		public bool 着衣
		{
			get
			{
				return this.着衣_;
			}
			set
			{
				this.着衣_ = value;
				if (this.着衣)
				{
					double num = this.右 ? -1.0 : 1.0;
					this.位置C = new Vector2D(num * (0.0001 + 0.0026 * this.バスト_.Inverse() * this.尺度B), 0.0005 + -0.0025 * this.バスト_ * this.尺度B);
					return;
				}
				this.位置C = Dat.Vec2DZero;
			}
		}

		public override void 描画0(Are Are)
		{
			switch (this.本体.IndexY)
			{
			case 0:
				Are.Draw(this.X0Y0_乳房);
				Are.Draw(this.X0Y0_乳輪);
				Are.Draw(this.X0Y0_乳首);
				Are.Draw(this.X0Y0_淫タトゥ_タトゥ1);
				Are.Draw(this.X0Y0_淫タトゥ_タトゥ2);
				Are.Draw(this.X0Y0_淫タトゥ_タトゥ3);
				Are.Draw(this.X0Y0_淫タトゥ_タトゥ4);
				Are.Draw(this.X0Y0_傷X);
				Are.Draw(this.X0Y0_傷I1);
				Are.Draw(this.X0Y0_傷I2);
				this.キスマ\u30FCク.Draw(Are);
				this.鞭痕.Draw(Are);
				Are.Draw(this.X0Y0_虫性_甲殻);
				Are.Draw(this.X0Y0_ハイライト1);
				Are.Draw(this.X0Y0_ハイライト2);
				return;
			case 1:
				Are.Draw(this.X0Y1_乳房);
				Are.Draw(this.X0Y1_乳輪);
				Are.Draw(this.X0Y1_乳首);
				Are.Draw(this.X0Y1_淫タトゥ_タトゥ1);
				Are.Draw(this.X0Y1_淫タトゥ_タトゥ2);
				Are.Draw(this.X0Y1_淫タトゥ_タトゥ3);
				Are.Draw(this.X0Y1_淫タトゥ_タトゥ4);
				Are.Draw(this.X0Y1_傷X);
				Are.Draw(this.X0Y1_傷I1);
				Are.Draw(this.X0Y1_傷I2);
				this.キスマ\u30FCク.Draw(Are);
				this.鞭痕.Draw(Are);
				Are.Draw(this.X0Y1_虫性_甲殻);
				Are.Draw(this.X0Y1_ハイライト1);
				Are.Draw(this.X0Y1_ハイライト2);
				return;
			case 2:
				Are.Draw(this.X0Y2_乳房);
				Are.Draw(this.X0Y2_乳輪);
				Are.Draw(this.X0Y2_乳首);
				Are.Draw(this.X0Y2_淫タトゥ_タトゥ3);
				Are.Draw(this.X0Y2_淫タトゥ_タトゥ4);
				Are.Draw(this.X0Y2_傷X);
				Are.Draw(this.X0Y2_傷I1);
				Are.Draw(this.X0Y2_傷I2);
				this.キスマ\u30FCク.Draw(Are);
				this.鞭痕.Draw(Are);
				Are.Draw(this.X0Y2_虫性_甲殻);
				Are.Draw(this.X0Y2_ハイライト1);
				Are.Draw(this.X0Y2_ハイライト2);
				return;
			case 3:
				Are.Draw(this.X0Y3_乳房);
				Are.Draw(this.X0Y3_乳輪);
				Are.Draw(this.X0Y3_乳首);
				Are.Draw(this.X0Y3_淫タトゥ_タトゥ1);
				Are.Draw(this.X0Y3_淫タトゥ_タトゥ3);
				Are.Draw(this.X0Y3_淫タトゥ_タトゥ4);
				Are.Draw(this.X0Y3_傷X);
				Are.Draw(this.X0Y3_傷I1);
				Are.Draw(this.X0Y3_傷I2);
				this.キスマ\u30FCク.Draw(Are);
				this.鞭痕.Draw(Are);
				Are.Draw(this.X0Y3_虫性_甲殻);
				Are.Draw(this.X0Y3_ハイライト1);
				Are.Draw(this.X0Y3_ハイライト2);
				return;
			default:
				Are.Draw(this.X0Y4_乳房);
				Are.Draw(this.X0Y4_乳輪);
				Are.Draw(this.X0Y4_乳首);
				Are.Draw(this.X0Y4_淫タトゥ_タトゥ1);
				Are.Draw(this.X0Y4_淫タトゥ_タトゥ3);
				Are.Draw(this.X0Y4_淫タトゥ_タトゥ4);
				Are.Draw(this.X0Y4_傷X);
				Are.Draw(this.X0Y4_傷I1);
				Are.Draw(this.X0Y4_傷I2);
				this.キスマ\u30FCク.Draw(Are);
				this.鞭痕.Draw(Are);
				Are.Draw(this.X0Y4_虫性_甲殻);
				Are.Draw(this.X0Y4_ハイライト1);
				Are.Draw(this.X0Y4_ハイライト2);
				return;
			}
		}

		public JointS 噴乳_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_乳首, 0);
			}
		}

		public override void 色更新()
		{
			switch (this.本体.IndexY)
			{
			case 0:
				this.X0Y0_乳房CP.Update();
				this.X0Y0_乳輪CP.Update();
				this.X0Y0_乳首CP.Update();
				this.X0Y0_淫タトゥ_タトゥ1CP.Update();
				this.X0Y0_淫タトゥ_タトゥ2CP.Update();
				this.X0Y0_淫タトゥ_タトゥ3CP.Update();
				this.X0Y0_淫タトゥ_タトゥ4CP.Update();
				this.X0Y0_ハイライト1CP.Update();
				this.X0Y0_ハイライト2CP.Update();
				this.X0Y0_傷XCP.Update();
				this.X0Y0_傷I1CP.Update();
				this.X0Y0_傷I2CP.Update();
				this.X0Y0_虫性_甲殻CP.Update();
				return;
			case 1:
				this.X0Y1_乳房CP.Update();
				this.X0Y1_乳輪CP.Update();
				this.X0Y1_乳首CP.Update();
				this.X0Y1_淫タトゥ_タトゥ1CP.Update();
				this.X0Y1_淫タトゥ_タトゥ2CP.Update();
				this.X0Y1_淫タトゥ_タトゥ3CP.Update();
				this.X0Y1_淫タトゥ_タトゥ4CP.Update();
				this.X0Y1_ハイライト1CP.Update();
				this.X0Y1_ハイライト2CP.Update();
				this.X0Y1_傷XCP.Update();
				this.X0Y1_傷I1CP.Update();
				this.X0Y1_傷I2CP.Update();
				this.X0Y1_虫性_甲殻CP.Update();
				return;
			case 2:
				this.X0Y2_乳房CP.Update();
				this.X0Y2_乳輪CP.Update();
				this.X0Y2_乳首CP.Update();
				this.X0Y2_淫タトゥ_タトゥ3CP.Update();
				this.X0Y2_淫タトゥ_タトゥ4CP.Update();
				this.X0Y2_ハイライト1CP.Update();
				this.X0Y2_ハイライト2CP.Update();
				this.X0Y2_傷XCP.Update();
				this.X0Y2_傷I1CP.Update();
				this.X0Y2_傷I2CP.Update();
				this.X0Y2_虫性_甲殻CP.Update();
				return;
			case 3:
				this.X0Y3_乳房CP.Update();
				this.X0Y3_乳輪CP.Update();
				this.X0Y3_乳首CP.Update();
				this.X0Y3_淫タトゥ_タトゥ1CP.Update();
				this.X0Y3_淫タトゥ_タトゥ3CP.Update();
				this.X0Y3_淫タトゥ_タトゥ4CP.Update();
				this.X0Y3_ハイライト1CP.Update();
				this.X0Y3_ハイライト2CP.Update();
				this.X0Y3_傷XCP.Update();
				this.X0Y3_傷I1CP.Update();
				this.X0Y3_傷I2CP.Update();
				this.X0Y3_虫性_甲殻CP.Update();
				return;
			default:
				this.X0Y4_乳房CP.Update();
				this.X0Y4_乳輪CP.Update();
				this.X0Y4_乳首CP.Update();
				this.X0Y4_淫タトゥ_タトゥ1CP.Update();
				this.X0Y4_淫タトゥ_タトゥ3CP.Update();
				this.X0Y4_淫タトゥ_タトゥ4CP.Update();
				this.X0Y4_ハイライト1CP.Update();
				this.X0Y4_ハイライト2CP.Update();
				this.X0Y4_傷XCP.Update();
				this.X0Y4_傷I1CP.Update();
				this.X0Y4_傷I2CP.Update();
				this.X0Y4_虫性_甲殻CP.Update();
				return;
			}
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.乳房CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.乳輪CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.乳首CD = new ColorD(ref 体配色.粘膜線, ref 体配色.粘膜);
			this.淫タトゥ_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ3CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ4CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.傷XCD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.虫性_甲殻CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
		}

		public Par X0Y0_乳房;

		public Par X0Y0_乳輪;

		public Par X0Y0_乳首;

		public Par X0Y0_淫タトゥ_タトゥ1;

		public Par X0Y0_淫タトゥ_タトゥ2;

		public Par X0Y0_淫タトゥ_タトゥ3;

		public Par X0Y0_淫タトゥ_タトゥ4;

		public Par X0Y0_ハイライト1;

		public Par X0Y0_ハイライト2;

		public Par X0Y0_傷X;

		public Par X0Y0_傷I1;

		public Par X0Y0_傷I2;

		public Par X0Y0_虫性_甲殻;

		public Par X0Y1_乳房;

		public Par X0Y1_乳輪;

		public Par X0Y1_乳首;

		public Par X0Y1_淫タトゥ_タトゥ1;

		public Par X0Y1_淫タトゥ_タトゥ2;

		public Par X0Y1_淫タトゥ_タトゥ3;

		public Par X0Y1_淫タトゥ_タトゥ4;

		public Par X0Y1_ハイライト1;

		public Par X0Y1_ハイライト2;

		public Par X0Y1_傷X;

		public Par X0Y1_傷I1;

		public Par X0Y1_傷I2;

		public Par X0Y1_虫性_甲殻;

		public Par X0Y2_乳房;

		public Par X0Y2_乳輪;

		public Par X0Y2_乳首;

		public Par X0Y2_淫タトゥ_タトゥ3;

		public Par X0Y2_淫タトゥ_タトゥ4;

		public Par X0Y2_ハイライト1;

		public Par X0Y2_ハイライト2;

		public Par X0Y2_傷X;

		public Par X0Y2_傷I1;

		public Par X0Y2_傷I2;

		public Par X0Y2_虫性_甲殻;

		public Par X0Y3_乳房;

		public Par X0Y3_乳輪;

		public Par X0Y3_乳首;

		public Par X0Y3_淫タトゥ_タトゥ1;

		public Par X0Y3_淫タトゥ_タトゥ3;

		public Par X0Y3_淫タトゥ_タトゥ4;

		public Par X0Y3_ハイライト1;

		public Par X0Y3_ハイライト2;

		public Par X0Y3_傷X;

		public Par X0Y3_傷I1;

		public Par X0Y3_傷I2;

		public Par X0Y3_虫性_甲殻;

		public Par X0Y4_乳房;

		public Par X0Y4_乳輪;

		public Par X0Y4_乳首;

		public Par X0Y4_淫タトゥ_タトゥ1;

		public Par X0Y4_淫タトゥ_タトゥ3;

		public Par X0Y4_淫タトゥ_タトゥ4;

		public Par X0Y4_ハイライト1;

		public Par X0Y4_ハイライト2;

		public Par X0Y4_傷X;

		public Par X0Y4_傷I1;

		public Par X0Y4_傷I2;

		public Par X0Y4_虫性_甲殻;

		public ColorD 乳房CD;

		public ColorD 乳輪CD;

		public ColorD 乳首CD;

		public ColorD 淫タトゥ_タトゥ1CD;

		public ColorD 淫タトゥ_タトゥ2CD;

		public ColorD 淫タトゥ_タトゥ3CD;

		public ColorD 淫タトゥ_タトゥ4CD;

		public ColorD ハイライト1CD;

		public ColorD ハイライト2CD;

		public ColorD 傷XCD;

		public ColorD 傷I1CD;

		public ColorD 傷I2CD;

		public ColorD 虫性_甲殻CD;

		public ColorP X0Y0_乳房CP;

		public ColorP X0Y0_乳輪CP;

		public ColorP X0Y0_乳首CP;

		public ColorP X0Y0_淫タトゥ_タトゥ1CP;

		public ColorP X0Y0_淫タトゥ_タトゥ2CP;

		public ColorP X0Y0_淫タトゥ_タトゥ3CP;

		public ColorP X0Y0_淫タトゥ_タトゥ4CP;

		public ColorP X0Y0_ハイライト1CP;

		public ColorP X0Y0_ハイライト2CP;

		public ColorP X0Y0_傷XCP;

		public ColorP X0Y0_傷I1CP;

		public ColorP X0Y0_傷I2CP;

		public ColorP X0Y0_虫性_甲殻CP;

		public ColorP X0Y1_乳房CP;

		public ColorP X0Y1_乳輪CP;

		public ColorP X0Y1_乳首CP;

		public ColorP X0Y1_淫タトゥ_タトゥ1CP;

		public ColorP X0Y1_淫タトゥ_タトゥ2CP;

		public ColorP X0Y1_淫タトゥ_タトゥ3CP;

		public ColorP X0Y1_淫タトゥ_タトゥ4CP;

		public ColorP X0Y1_ハイライト1CP;

		public ColorP X0Y1_ハイライト2CP;

		public ColorP X0Y1_傷XCP;

		public ColorP X0Y1_傷I1CP;

		public ColorP X0Y1_傷I2CP;

		public ColorP X0Y1_虫性_甲殻CP;

		public ColorP X0Y2_乳房CP;

		public ColorP X0Y2_乳輪CP;

		public ColorP X0Y2_乳首CP;

		public ColorP X0Y2_淫タトゥ_タトゥ3CP;

		public ColorP X0Y2_淫タトゥ_タトゥ4CP;

		public ColorP X0Y2_ハイライト1CP;

		public ColorP X0Y2_ハイライト2CP;

		public ColorP X0Y2_傷XCP;

		public ColorP X0Y2_傷I1CP;

		public ColorP X0Y2_傷I2CP;

		public ColorP X0Y2_虫性_甲殻CP;

		public ColorP X0Y3_乳房CP;

		public ColorP X0Y3_乳輪CP;

		public ColorP X0Y3_乳首CP;

		public ColorP X0Y3_淫タトゥ_タトゥ1CP;

		public ColorP X0Y3_淫タトゥ_タトゥ3CP;

		public ColorP X0Y3_淫タトゥ_タトゥ4CP;

		public ColorP X0Y3_ハイライト1CP;

		public ColorP X0Y3_ハイライト2CP;

		public ColorP X0Y3_傷XCP;

		public ColorP X0Y3_傷I1CP;

		public ColorP X0Y3_傷I2CP;

		public ColorP X0Y3_虫性_甲殻CP;

		public ColorP X0Y4_乳房CP;

		public ColorP X0Y4_乳輪CP;

		public ColorP X0Y4_乳首CP;

		public ColorP X0Y4_淫タトゥ_タトゥ1CP;

		public ColorP X0Y4_淫タトゥ_タトゥ3CP;

		public ColorP X0Y4_淫タトゥ_タトゥ4CP;

		public ColorP X0Y4_ハイライト1CP;

		public ColorP X0Y4_ハイライト2CP;

		public ColorP X0Y4_傷XCP;

		public ColorP X0Y4_傷I1CP;

		public ColorP X0Y4_傷I2CP;

		public ColorP X0Y4_虫性_甲殻CP;

		public double バスト_;

		public double sb;

		public double syb;

		private bool 着衣_;

		public スタンプK キスマ\u30FCク;

		public スタンプW 鞭痕;

		public Ele[] 噴乳_接続;
	}
}
