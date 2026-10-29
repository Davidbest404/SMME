using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 口_裂け : 口
	{
		public 口_裂け(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 口_裂けD e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif(Sta.胴体["口"][1]);
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_口 = pars["口"].ToPar();
			this.X0Y0_歯 = pars["歯"].ToPar();
			this.X0Y0_口紅上 = pars["口紅上"].ToPar();
			Pars pars2 = pars["口紅下"].ToPars();
			this.X0Y0_口紅下_口紅 = pars2["口紅"].ToPar();
			this.X0Y0_口紅下_ハイライト = pars2["ハイライト"].ToPar();
			pars = this.本体[0][1];
			this.X0Y1_口 = pars["口"].ToPar();
			this.X0Y1_歯 = pars["歯"].ToPar();
			this.X0Y1_口紅上 = pars["口紅上"].ToPar();
			pars2 = pars["口紅下"].ToPars();
			this.X0Y1_口紅下_口紅 = pars2["口紅"].ToPar();
			this.X0Y1_口紅下_ハイライト = pars2["ハイライト"].ToPar();
			pars = this.本体[0][2];
			this.X0Y2_口 = pars["口"].ToPar();
			this.X0Y2_歯 = pars["歯"].ToPar();
			this.X0Y2_口紅上 = pars["口紅上"].ToPar();
			pars2 = pars["口紅下"].ToPars();
			this.X0Y2_口紅下_口紅 = pars2["口紅"].ToPar();
			this.X0Y2_口紅下_ハイライト = pars2["ハイライト"].ToPar();
			pars = this.本体[0][3];
			this.X0Y3_口 = pars["口"].ToPar();
			this.X0Y3_歯 = pars["歯"].ToPar();
			this.X0Y3_口紅上 = pars["口紅上"].ToPar();
			pars2 = pars["口紅下"].ToPars();
			this.X0Y3_口紅下_口紅 = pars2["口紅"].ToPar();
			this.X0Y3_口紅下_ハイライト = pars2["ハイライト"].ToPar();
			pars = this.本体[0][4];
			this.X0Y4_口 = pars["口"].ToPar();
			this.X0Y4_口紅上 = pars["口紅上"].ToPar();
			pars2 = pars["口紅下"].ToPars();
			this.X0Y4_口紅下_口紅 = pars2["口紅"].ToPar();
			this.X0Y4_口紅下_ハイライト = pars2["ハイライト"].ToPar();
			pars = this.本体[0][5];
			this.X0Y5_口 = pars["口"].ToPar();
			this.X0Y5_歯 = pars["歯"].ToPar();
			this.X0Y5_口紅上 = pars["口紅上"].ToPar();
			pars2 = pars["口紅下"].ToPars();
			this.X0Y5_口紅下_口紅 = pars2["口紅"].ToPar();
			this.X0Y5_口紅下_ハイライト = pars2["ハイライト"].ToPar();
			pars = this.本体[0][6];
			this.X0Y6_口 = pars["口"].ToPar();
			this.X0Y6_歯 = pars["歯"].ToPar();
			this.X0Y6_口紅上 = pars["口紅上"].ToPar();
			pars2 = pars["口紅下"].ToPars();
			this.X0Y6_口紅下_口紅 = pars2["口紅"].ToPar();
			this.X0Y6_口紅下_ハイライト = pars2["ハイライト"].ToPar();
			pars = this.本体[0][7];
			this.X0Y7_口 = pars["口"].ToPar();
			this.X0Y7_歯 = pars["歯"].ToPar();
			this.X0Y7_口紅上 = pars["口紅上"].ToPar();
			pars2 = pars["口紅下"].ToPars();
			this.X0Y7_口紅下_口紅 = pars2["口紅"].ToPar();
			this.X0Y7_口紅下_ハイライト = pars2["ハイライト"].ToPar();
			pars = this.本体[0][8];
			this.X0Y8_口 = pars["口"].ToPar();
			this.X0Y8_歯 = pars["歯"].ToPar();
			this.X0Y8_口紅上 = pars["口紅上"].ToPar();
			pars2 = pars["口紅下"].ToPars();
			this.X0Y8_口紅下_口紅 = pars2["口紅"].ToPar();
			this.X0Y8_口紅下_ハイライト = pars2["ハイライト"].ToPar();
			pars = this.本体[0][9];
			this.X0Y9_口 = pars["口"].ToPar();
			this.X0Y9_歯 = pars["歯"].ToPar();
			this.X0Y9_口紅上 = pars["口紅上"].ToPar();
			pars2 = pars["口紅下"].ToPars();
			this.X0Y9_口紅下_口紅 = pars2["口紅"].ToPar();
			this.X0Y9_口紅下_ハイライト = pars2["ハイライト"].ToPar();
			pars = this.本体[0][10];
			this.X0Y10_口 = pars["口"].ToPar();
			this.X0Y10_口紅上 = pars["口紅上"].ToPar();
			pars2 = pars["口紅下"].ToPars();
			this.X0Y10_口紅下_口紅 = pars2["口紅"].ToPar();
			this.X0Y10_口紅下_ハイライト = pars2["ハイライト"].ToPar();
			pars = this.本体[0][11];
			this.X0Y11_口 = pars["口"].ToPar();
			this.X0Y11_口紅上 = pars["口紅上"].ToPar();
			pars2 = pars["口紅下"].ToPars();
			this.X0Y11_口紅下_口紅 = pars2["口紅"].ToPar();
			this.X0Y11_口紅下_ハイライト = pars2["ハイライト"].ToPar();
			pars = this.本体[0][12];
			this.X0Y12_口 = pars["口"].ToPar();
			this.X0Y12_歯 = pars["歯"].ToPar();
			this.X0Y12_口紅上 = pars["口紅上"].ToPar();
			pars2 = pars["口紅下"].ToPars();
			this.X0Y12_口紅下_口紅 = pars2["口紅"].ToPar();
			this.X0Y12_口紅下_ハイライト = pars2["ハイライト"].ToPar();
			pars = this.本体[0][13];
			this.X0Y13_口 = pars["口"].ToPar();
			this.X0Y13_口紅上 = pars["口紅上"].ToPar();
			pars2 = pars["口紅下"].ToPars();
			this.X0Y13_口紅下_口紅 = pars2["口紅"].ToPar();
			this.X0Y13_口紅下_ハイライト = pars2["ハイライト"].ToPar();
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
			this.口_表示 = e.口_表示;
			this.歯_表示 = e.歯_表示;
			this.口紅上_表示 = e.口紅上_表示;
			this.口紅下_口紅_表示 = e.口紅下_口紅_表示;
			this.口紅下_ハイライト_表示 = e.口紅下_ハイライト_表示;
			this.口紅表示 = e.口紅表示;
			this.ハイライト表示 = e.ハイライト表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_口CP = new ColorP(this.X0Y0_口, this.歯CD, DisUnit, true);
			this.X0Y0_歯CP = new ColorP(this.X0Y0_歯, this.口CD, DisUnit, true);
			this.X0Y0_口紅上CP = new ColorP(this.X0Y0_口紅上, this.口紅上CD, DisUnit, true);
			this.X0Y0_口紅下_口紅CP = new ColorP(this.X0Y0_口紅下_口紅, this.口紅下_口紅CD, DisUnit, true);
			this.X0Y0_口紅下_ハイライトCP = new ColorP(this.X0Y0_口紅下_ハイライト, this.口紅下_ハイライトCD, DisUnit, true);
			this.X0Y1_口CP = new ColorP(this.X0Y1_口, this.歯CD, DisUnit, true);
			this.X0Y1_歯CP = new ColorP(this.X0Y1_歯, this.口CD, DisUnit, true);
			this.X0Y1_口紅上CP = new ColorP(this.X0Y1_口紅上, this.口紅上CD, DisUnit, true);
			this.X0Y1_口紅下_口紅CP = new ColorP(this.X0Y1_口紅下_口紅, this.口紅下_口紅CD, DisUnit, true);
			this.X0Y1_口紅下_ハイライトCP = new ColorP(this.X0Y1_口紅下_ハイライト, this.口紅下_ハイライトCD, DisUnit, true);
			this.X0Y2_口CP = new ColorP(this.X0Y2_口, this.歯CD, DisUnit, true);
			this.X0Y2_歯CP = new ColorP(this.X0Y2_歯, new ColorD(ref Col.Black, ref Color2.Empty), DisUnit, true);
			this.X0Y2_口紅上CP = new ColorP(this.X0Y2_口紅上, this.口紅上CD, DisUnit, true);
			this.X0Y2_口紅下_口紅CP = new ColorP(this.X0Y2_口紅下_口紅, this.口紅下_口紅CD, DisUnit, true);
			this.X0Y2_口紅下_ハイライトCP = new ColorP(this.X0Y2_口紅下_ハイライト, this.口紅下_ハイライトCD, DisUnit, true);
			this.X0Y3_口CP = new ColorP(this.X0Y3_口, this.歯CD, DisUnit, true);
			this.X0Y3_歯CP = new ColorP(this.X0Y3_歯, new ColorD(ref Col.Black, ref Color2.Empty), DisUnit, true);
			this.X0Y3_口紅上CP = new ColorP(this.X0Y3_口紅上, this.口紅上CD, DisUnit, true);
			this.X0Y3_口紅下_口紅CP = new ColorP(this.X0Y3_口紅下_口紅, this.口紅下_口紅CD, DisUnit, true);
			this.X0Y3_口紅下_ハイライトCP = new ColorP(this.X0Y3_口紅下_ハイライト, this.口紅下_ハイライトCD, DisUnit, true);
			this.X0Y4_口CP = new ColorP(this.X0Y4_口, this.歯CD, DisUnit, true);
			this.X0Y4_口紅上CP = new ColorP(this.X0Y4_口紅上, this.口紅上CD, DisUnit, true);
			this.X0Y4_口紅下_口紅CP = new ColorP(this.X0Y4_口紅下_口紅, this.口紅下_口紅CD, DisUnit, true);
			this.X0Y4_口紅下_ハイライトCP = new ColorP(this.X0Y4_口紅下_ハイライト, this.口紅下_ハイライトCD, DisUnit, true);
			this.X0Y5_口CP = new ColorP(this.X0Y5_口, this.歯CD, DisUnit, true);
			this.X0Y5_歯CP = new ColorP(this.X0Y5_歯, this.口CD, DisUnit, true);
			this.X0Y5_口紅上CP = new ColorP(this.X0Y5_口紅上, this.口紅上CD, DisUnit, true);
			this.X0Y5_口紅下_口紅CP = new ColorP(this.X0Y5_口紅下_口紅, this.口紅下_口紅CD, DisUnit, true);
			this.X0Y5_口紅下_ハイライトCP = new ColorP(this.X0Y5_口紅下_ハイライト, this.口紅下_ハイライトCD, DisUnit, true);
			this.X0Y6_口CP = new ColorP(this.X0Y6_口, this.歯CD, DisUnit, true);
			this.X0Y6_歯CP = new ColorP(this.X0Y6_歯, this.口CD, DisUnit, true);
			this.X0Y6_口紅上CP = new ColorP(this.X0Y6_口紅上, this.口紅上CD, DisUnit, true);
			this.X0Y6_口紅下_口紅CP = new ColorP(this.X0Y6_口紅下_口紅, this.口紅下_口紅CD, DisUnit, true);
			this.X0Y6_口紅下_ハイライトCP = new ColorP(this.X0Y6_口紅下_ハイライト, this.口紅下_ハイライトCD, DisUnit, true);
			this.X0Y7_口CP = new ColorP(this.X0Y7_口, this.歯CD, DisUnit, true);
			this.X0Y7_歯CP = new ColorP(this.X0Y7_歯, new ColorD(ref Col.Black, ref Color2.Empty), DisUnit, true);
			this.X0Y7_口紅上CP = new ColorP(this.X0Y7_口紅上, this.口紅上CD, DisUnit, true);
			this.X0Y7_口紅下_口紅CP = new ColorP(this.X0Y7_口紅下_口紅, this.口紅下_口紅CD, DisUnit, true);
			this.X0Y7_口紅下_ハイライトCP = new ColorP(this.X0Y7_口紅下_ハイライト, this.口紅下_ハイライトCD, DisUnit, true);
			this.X0Y8_口CP = new ColorP(this.X0Y8_口, this.歯CD, DisUnit, true);
			this.X0Y8_歯CP = new ColorP(this.X0Y8_歯, new ColorD(ref Col.Black, ref Color2.Empty), DisUnit, true);
			this.X0Y8_口紅上CP = new ColorP(this.X0Y8_口紅上, this.口紅上CD, DisUnit, true);
			this.X0Y8_口紅下_口紅CP = new ColorP(this.X0Y8_口紅下_口紅, this.口紅下_口紅CD, DisUnit, true);
			this.X0Y8_口紅下_ハイライトCP = new ColorP(this.X0Y8_口紅下_ハイライト, this.口紅下_ハイライトCD, DisUnit, true);
			this.X0Y9_口CP = new ColorP(this.X0Y9_口, this.歯CD, DisUnit, true);
			this.X0Y9_歯CP = new ColorP(this.X0Y9_歯, this.口CD, DisUnit, true);
			this.X0Y9_口紅上CP = new ColorP(this.X0Y9_口紅上, this.口紅上CD, DisUnit, true);
			this.X0Y9_口紅下_口紅CP = new ColorP(this.X0Y9_口紅下_口紅, this.口紅下_口紅CD, DisUnit, true);
			this.X0Y9_口紅下_ハイライトCP = new ColorP(this.X0Y9_口紅下_ハイライト, this.口紅下_ハイライトCD, DisUnit, true);
			this.X0Y10_口CP = new ColorP(this.X0Y10_口, this.歯CD, DisUnit, true);
			this.X0Y10_口紅上CP = new ColorP(this.X0Y10_口紅上, this.口紅上CD, DisUnit, true);
			this.X0Y10_口紅下_口紅CP = new ColorP(this.X0Y10_口紅下_口紅, this.口紅下_口紅CD, DisUnit, true);
			this.X0Y10_口紅下_ハイライトCP = new ColorP(this.X0Y10_口紅下_ハイライト, this.口紅下_ハイライトCD, DisUnit, true);
			this.X0Y11_口CP = new ColorP(this.X0Y11_口, this.歯CD, DisUnit, true);
			this.X0Y11_口紅上CP = new ColorP(this.X0Y11_口紅上, this.口紅上CD, DisUnit, true);
			this.X0Y11_口紅下_口紅CP = new ColorP(this.X0Y11_口紅下_口紅, this.口紅下_口紅CD, DisUnit, true);
			this.X0Y11_口紅下_ハイライトCP = new ColorP(this.X0Y11_口紅下_ハイライト, this.口紅下_ハイライトCD, DisUnit, true);
			this.X0Y12_口CP = new ColorP(this.X0Y12_口, this.歯CD, DisUnit, true);
			this.X0Y12_歯CP = new ColorP(this.X0Y12_歯, this.口CD, DisUnit, true);
			this.X0Y12_口紅上CP = new ColorP(this.X0Y12_口紅上, this.口紅上CD, DisUnit, true);
			this.X0Y12_口紅下_口紅CP = new ColorP(this.X0Y12_口紅下_口紅, this.口紅下_口紅CD, DisUnit, true);
			this.X0Y12_口紅下_ハイライトCP = new ColorP(this.X0Y12_口紅下_ハイライト, this.口紅下_ハイライトCD, DisUnit, true);
			this.X0Y13_口CP = new ColorP(this.X0Y13_口, this.歯CD, DisUnit, true);
			this.X0Y13_口紅上CP = new ColorP(this.X0Y13_口紅上, this.口紅上CD, DisUnit, true);
			this.X0Y13_口紅下_口紅CP = new ColorP(this.X0Y13_口紅下_口紅, this.口紅下_口紅CD, DisUnit, true);
			this.X0Y13_口紅下_ハイライトCP = new ColorP(this.X0Y13_口紅下_ハイライト, this.口紅下_ハイライトCD, DisUnit, true);
			this.口紅濃度 = e.口紅濃度;
			this.ハイライト濃度 = e.ハイライト濃度;
			this.濃度 = e.濃度;
			double y = 1.5E-05;
			this.X0Y0_口.BasePointBase = this.X0Y0_口.BasePointBase.AddY(y);
			this.X0Y1_口.BasePointBase = this.X0Y1_口.BasePointBase.AddY(y);
			this.X0Y2_口.BasePointBase = this.X0Y2_口.BasePointBase.AddY(y);
			this.X0Y3_口.BasePointBase = this.X0Y3_口.BasePointBase.AddY(y);
			this.X0Y4_口.BasePointBase = this.X0Y4_口.BasePointBase.AddY(y);
			this.X0Y5_口.BasePointBase = this.X0Y5_口.BasePointBase.AddY(y);
			this.X0Y6_口.BasePointBase = this.X0Y6_口.BasePointBase.AddY(y);
			this.X0Y7_口.BasePointBase = this.X0Y7_口.BasePointBase.AddY(y);
			this.X0Y8_口.BasePointBase = this.X0Y8_口.BasePointBase.AddY(y);
			this.X0Y9_口.BasePointBase = this.X0Y9_口.BasePointBase.AddY(y);
			this.X0Y10_口.BasePointBase = this.X0Y10_口.BasePointBase.AddY(y);
			this.X0Y11_口.BasePointBase = this.X0Y11_口.BasePointBase.AddY(y);
			this.X0Y12_口.BasePointBase = this.X0Y12_口.BasePointBase.AddY(y);
			this.X0Y13_口.BasePointBase = this.X0Y13_口.BasePointBase.AddY(y);
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

		public bool 口_表示
		{
			get
			{
				return this.X0Y0_口.Dra;
			}
			set
			{
				this.X0Y0_口.Dra = value;
				this.X0Y1_口.Dra = value;
				this.X0Y2_口.Dra = value;
				this.X0Y3_口.Dra = value;
				this.X0Y4_口.Dra = value;
				this.X0Y5_口.Dra = value;
				this.X0Y6_口.Dra = value;
				this.X0Y7_口.Dra = value;
				this.X0Y8_口.Dra = value;
				this.X0Y9_口.Dra = value;
				this.X0Y10_口.Dra = value;
				this.X0Y11_口.Dra = value;
				this.X0Y12_口.Dra = value;
				this.X0Y13_口.Dra = value;
				this.X0Y0_口.Hit = value;
				this.X0Y1_口.Hit = value;
				this.X0Y2_口.Hit = value;
				this.X0Y3_口.Hit = value;
				this.X0Y4_口.Hit = value;
				this.X0Y5_口.Hit = value;
				this.X0Y6_口.Hit = value;
				this.X0Y7_口.Hit = value;
				this.X0Y8_口.Hit = value;
				this.X0Y9_口.Hit = value;
				this.X0Y10_口.Hit = value;
				this.X0Y11_口.Hit = value;
				this.X0Y12_口.Hit = value;
				this.X0Y13_口.Hit = value;
			}
		}

		public bool 歯_表示
		{
			get
			{
				return this.X0Y0_歯.Dra;
			}
			set
			{
				this.X0Y0_歯.Dra = value;
				this.X0Y1_歯.Dra = value;
				this.X0Y2_歯.Dra = value;
				this.X0Y3_歯.Dra = value;
				this.X0Y5_歯.Dra = value;
				this.X0Y6_歯.Dra = value;
				this.X0Y7_歯.Dra = value;
				this.X0Y8_歯.Dra = value;
				this.X0Y9_歯.Dra = value;
				this.X0Y12_歯.Dra = value;
				this.X0Y0_歯.Hit = value;
				this.X0Y1_歯.Hit = value;
				this.X0Y2_歯.Hit = value;
				this.X0Y3_歯.Hit = value;
				this.X0Y5_歯.Hit = value;
				this.X0Y6_歯.Hit = value;
				this.X0Y7_歯.Hit = value;
				this.X0Y8_歯.Hit = value;
				this.X0Y9_歯.Hit = value;
				this.X0Y12_歯.Hit = value;
			}
		}

		public bool 口紅上_表示
		{
			get
			{
				return this.X0Y0_口紅上.Dra;
			}
			set
			{
				this.X0Y0_口紅上.Dra = value;
				this.X0Y1_口紅上.Dra = value;
				this.X0Y2_口紅上.Dra = value;
				this.X0Y3_口紅上.Dra = value;
				this.X0Y4_口紅上.Dra = value;
				this.X0Y5_口紅上.Dra = value;
				this.X0Y6_口紅上.Dra = value;
				this.X0Y7_口紅上.Dra = value;
				this.X0Y8_口紅上.Dra = value;
				this.X0Y9_口紅上.Dra = value;
				this.X0Y10_口紅上.Dra = value;
				this.X0Y11_口紅上.Dra = value;
				this.X0Y12_口紅上.Dra = value;
				this.X0Y13_口紅上.Dra = value;
				this.X0Y0_口紅上.Hit = value;
				this.X0Y1_口紅上.Hit = value;
				this.X0Y2_口紅上.Hit = value;
				this.X0Y3_口紅上.Hit = value;
				this.X0Y4_口紅上.Hit = value;
				this.X0Y5_口紅上.Hit = value;
				this.X0Y6_口紅上.Hit = value;
				this.X0Y7_口紅上.Hit = value;
				this.X0Y8_口紅上.Hit = value;
				this.X0Y9_口紅上.Hit = value;
				this.X0Y10_口紅上.Hit = value;
				this.X0Y11_口紅上.Hit = value;
				this.X0Y12_口紅上.Hit = value;
				this.X0Y13_口紅上.Hit = value;
			}
		}

		public bool 口紅下_口紅_表示
		{
			get
			{
				return this.X0Y0_口紅下_口紅.Dra;
			}
			set
			{
				this.X0Y0_口紅下_口紅.Dra = value;
				this.X0Y1_口紅下_口紅.Dra = value;
				this.X0Y2_口紅下_口紅.Dra = value;
				this.X0Y3_口紅下_口紅.Dra = value;
				this.X0Y4_口紅下_口紅.Dra = value;
				this.X0Y5_口紅下_口紅.Dra = value;
				this.X0Y6_口紅下_口紅.Dra = value;
				this.X0Y7_口紅下_口紅.Dra = value;
				this.X0Y8_口紅下_口紅.Dra = value;
				this.X0Y9_口紅下_口紅.Dra = value;
				this.X0Y10_口紅下_口紅.Dra = value;
				this.X0Y11_口紅下_口紅.Dra = value;
				this.X0Y12_口紅下_口紅.Dra = value;
				this.X0Y13_口紅下_口紅.Dra = value;
				this.X0Y0_口紅下_口紅.Hit = value;
				this.X0Y1_口紅下_口紅.Hit = value;
				this.X0Y2_口紅下_口紅.Hit = value;
				this.X0Y3_口紅下_口紅.Hit = value;
				this.X0Y4_口紅下_口紅.Hit = value;
				this.X0Y5_口紅下_口紅.Hit = value;
				this.X0Y6_口紅下_口紅.Hit = value;
				this.X0Y7_口紅下_口紅.Hit = value;
				this.X0Y8_口紅下_口紅.Hit = value;
				this.X0Y9_口紅下_口紅.Hit = value;
				this.X0Y10_口紅下_口紅.Hit = value;
				this.X0Y11_口紅下_口紅.Hit = value;
				this.X0Y12_口紅下_口紅.Hit = value;
				this.X0Y13_口紅下_口紅.Hit = value;
			}
		}

		public bool 口紅下_ハイライト_表示
		{
			get
			{
				return this.X0Y0_口紅下_ハイライト.Dra;
			}
			set
			{
				this.X0Y0_口紅下_ハイライト.Dra = value;
				this.X0Y1_口紅下_ハイライト.Dra = value;
				this.X0Y2_口紅下_ハイライト.Dra = value;
				this.X0Y3_口紅下_ハイライト.Dra = value;
				this.X0Y4_口紅下_ハイライト.Dra = value;
				this.X0Y5_口紅下_ハイライト.Dra = value;
				this.X0Y6_口紅下_ハイライト.Dra = value;
				this.X0Y7_口紅下_ハイライト.Dra = value;
				this.X0Y8_口紅下_ハイライト.Dra = value;
				this.X0Y9_口紅下_ハイライト.Dra = value;
				this.X0Y10_口紅下_ハイライト.Dra = value;
				this.X0Y11_口紅下_ハイライト.Dra = value;
				this.X0Y12_口紅下_ハイライト.Dra = value;
				this.X0Y13_口紅下_ハイライト.Dra = value;
				this.X0Y0_口紅下_ハイライト.Hit = value;
				this.X0Y1_口紅下_ハイライト.Hit = value;
				this.X0Y2_口紅下_ハイライト.Hit = value;
				this.X0Y3_口紅下_ハイライト.Hit = value;
				this.X0Y4_口紅下_ハイライト.Hit = value;
				this.X0Y5_口紅下_ハイライト.Hit = value;
				this.X0Y6_口紅下_ハイライト.Hit = value;
				this.X0Y7_口紅下_ハイライト.Hit = value;
				this.X0Y8_口紅下_ハイライト.Hit = value;
				this.X0Y9_口紅下_ハイライト.Hit = value;
				this.X0Y10_口紅下_ハイライト.Hit = value;
				this.X0Y11_口紅下_ハイライト.Hit = value;
				this.X0Y12_口紅下_ハイライト.Hit = value;
				this.X0Y13_口紅下_ハイライト.Hit = value;
			}
		}

		public bool 口紅表示
		{
			get
			{
				return this.口紅上_表示;
			}
			set
			{
				this.口紅上_表示 = value;
				this.口紅下_口紅_表示 = value;
			}
		}

		public bool ハイライト表示
		{
			get
			{
				return this.口紅下_ハイライト_表示;
			}
			set
			{
				this.口紅下_ハイライト_表示 = value;
			}
		}

		public double 口紅濃度
		{
			get
			{
				return this.口紅上CD.不透明度;
			}
			set
			{
				this.口紅上CD.不透明度 = value;
				this.口紅下_口紅CD.不透明度 = value;
			}
		}

		public double ハイライト濃度
		{
			get
			{
				return this.口紅下_ハイライトCD.不透明度;
			}
			set
			{
				this.口紅下_ハイライトCD.不透明度 = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.口_表示;
			}
			set
			{
				this.口_表示 = value;
				this.歯_表示 = value;
				this.口紅上_表示 = value;
				this.口紅下_口紅_表示 = value;
				this.口紅下_ハイライト_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.歯CD.不透明度;
			}
			set
			{
				this.歯CD.不透明度 = value;
				this.口CD.不透明度 = value;
				this.口紅上CD.不透明度 = value;
				this.口紅下_口紅CD.不透明度 = value;
				this.口紅下_ハイライトCD.不透明度 = value;
			}
		}

		public override void 色更新()
		{
			switch (this.本体.IndexY)
			{
			case 0:
				this.X0Y0_口CP.Update();
				this.X0Y0_歯CP.Update();
				this.X0Y0_口紅上CP.Update();
				this.X0Y0_口紅下_口紅CP.Update();
				this.X0Y0_口紅下_ハイライトCP.Update();
				return;
			case 1:
				this.X0Y1_口CP.Update();
				this.X0Y1_歯CP.Update();
				this.X0Y1_口紅上CP.Update();
				this.X0Y1_口紅下_口紅CP.Update();
				this.X0Y1_口紅下_ハイライトCP.Update();
				return;
			case 2:
				this.X0Y2_口CP.Update();
				this.X0Y2_歯CP.Update();
				this.X0Y2_口紅上CP.Update();
				this.X0Y2_口紅下_口紅CP.Update();
				this.X0Y2_口紅下_ハイライトCP.Update();
				return;
			case 3:
				this.X0Y3_口CP.Update();
				this.X0Y3_歯CP.Update();
				this.X0Y3_口紅上CP.Update();
				this.X0Y3_口紅下_口紅CP.Update();
				this.X0Y3_口紅下_ハイライトCP.Update();
				return;
			case 4:
				this.X0Y4_口CP.Update();
				this.X0Y4_口紅上CP.Update();
				this.X0Y4_口紅下_口紅CP.Update();
				this.X0Y4_口紅下_ハイライトCP.Update();
				return;
			case 5:
				this.X0Y5_口CP.Update();
				this.X0Y5_歯CP.Update();
				this.X0Y5_口紅上CP.Update();
				this.X0Y5_口紅下_口紅CP.Update();
				this.X0Y5_口紅下_ハイライトCP.Update();
				return;
			case 6:
				this.X0Y6_口CP.Update();
				this.X0Y6_歯CP.Update();
				this.X0Y6_口紅上CP.Update();
				this.X0Y6_口紅下_口紅CP.Update();
				this.X0Y6_口紅下_ハイライトCP.Update();
				return;
			case 7:
				this.X0Y7_口CP.Update();
				this.X0Y7_歯CP.Update();
				this.X0Y7_口紅上CP.Update();
				this.X0Y7_口紅下_口紅CP.Update();
				this.X0Y7_口紅下_ハイライトCP.Update();
				return;
			case 8:
				this.X0Y8_口CP.Update();
				this.X0Y8_歯CP.Update();
				this.X0Y8_口紅上CP.Update();
				this.X0Y8_口紅下_口紅CP.Update();
				this.X0Y8_口紅下_ハイライトCP.Update();
				return;
			case 9:
				this.X0Y9_口CP.Update();
				this.X0Y9_歯CP.Update();
				this.X0Y9_口紅上CP.Update();
				this.X0Y9_口紅下_口紅CP.Update();
				this.X0Y9_口紅下_ハイライトCP.Update();
				return;
			case 10:
				this.X0Y10_口CP.Update();
				this.X0Y10_口紅上CP.Update();
				this.X0Y10_口紅下_口紅CP.Update();
				this.X0Y10_口紅下_ハイライトCP.Update();
				return;
			case 11:
				this.X0Y11_口CP.Update();
				this.X0Y11_口紅上CP.Update();
				this.X0Y11_口紅下_口紅CP.Update();
				this.X0Y11_口紅下_ハイライトCP.Update();
				return;
			case 12:
				this.X0Y12_口CP.Update();
				this.X0Y12_歯CP.Update();
				this.X0Y12_口紅上CP.Update();
				this.X0Y12_口紅下_口紅CP.Update();
				this.X0Y12_口紅下_ハイライトCP.Update();
				return;
			default:
				this.X0Y13_口CP.Update();
				this.X0Y13_口紅上CP.Update();
				this.X0Y13_口紅下_口紅CP.Update();
				this.X0Y13_口紅下_ハイライトCP.Update();
				return;
			}
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.口CD = new ColorD(ref Col.Black, ref 体配色.粘膜);
			this.歯CD = new ColorD(ref Col.Black, ref 体配色.歯);
			this.口紅上CD = new ColorD(ref Col.Empty, ref 体配色.口紅);
			this.口紅下_口紅CD = new ColorD(ref Col.Empty, ref 体配色.口紅);
			this.口紅下_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
		}

		public Par X0Y0_口;

		public Par X0Y0_歯;

		public Par X0Y0_口紅上;

		public Par X0Y0_口紅下_口紅;

		public Par X0Y0_口紅下_ハイライト;

		public Par X0Y1_口;

		public Par X0Y1_歯;

		public Par X0Y1_口紅上;

		public Par X0Y1_口紅下_口紅;

		public Par X0Y1_口紅下_ハイライト;

		public Par X0Y2_口;

		public Par X0Y2_歯;

		public Par X0Y2_口紅上;

		public Par X0Y2_口紅下_口紅;

		public Par X0Y2_口紅下_ハイライト;

		public Par X0Y3_口;

		public Par X0Y3_歯;

		public Par X0Y3_口紅上;

		public Par X0Y3_口紅下_口紅;

		public Par X0Y3_口紅下_ハイライト;

		public Par X0Y4_口;

		public Par X0Y4_口紅上;

		public Par X0Y4_口紅下_口紅;

		public Par X0Y4_口紅下_ハイライト;

		public Par X0Y5_口;

		public Par X0Y5_歯;

		public Par X0Y5_口紅上;

		public Par X0Y5_口紅下_口紅;

		public Par X0Y5_口紅下_ハイライト;

		public Par X0Y6_口;

		public Par X0Y6_歯;

		public Par X0Y6_口紅上;

		public Par X0Y6_口紅下_口紅;

		public Par X0Y6_口紅下_ハイライト;

		public Par X0Y7_口;

		public Par X0Y7_歯;

		public Par X0Y7_口紅上;

		public Par X0Y7_口紅下_口紅;

		public Par X0Y7_口紅下_ハイライト;

		public Par X0Y8_口;

		public Par X0Y8_歯;

		public Par X0Y8_口紅上;

		public Par X0Y8_口紅下_口紅;

		public Par X0Y8_口紅下_ハイライト;

		public Par X0Y9_口;

		public Par X0Y9_歯;

		public Par X0Y9_口紅上;

		public Par X0Y9_口紅下_口紅;

		public Par X0Y9_口紅下_ハイライト;

		public Par X0Y10_口;

		public Par X0Y10_口紅上;

		public Par X0Y10_口紅下_口紅;

		public Par X0Y10_口紅下_ハイライト;

		public Par X0Y11_口;

		public Par X0Y11_口紅上;

		public Par X0Y11_口紅下_口紅;

		public Par X0Y11_口紅下_ハイライト;

		public Par X0Y12_口;

		public Par X0Y12_歯;

		public Par X0Y12_口紅上;

		public Par X0Y12_口紅下_口紅;

		public Par X0Y12_口紅下_ハイライト;

		public Par X0Y13_口;

		public Par X0Y13_口紅上;

		public Par X0Y13_口紅下_口紅;

		public Par X0Y13_口紅下_ハイライト;

		public ColorD 口CD;

		public ColorD 歯CD;

		public ColorD 口紅上CD;

		public ColorD 口紅下_口紅CD;

		public ColorD 口紅下_ハイライトCD;

		public ColorP X0Y0_口CP;

		public ColorP X0Y0_歯CP;

		public ColorP X0Y0_口紅上CP;

		public ColorP X0Y0_口紅下_口紅CP;

		public ColorP X0Y0_口紅下_ハイライトCP;

		public ColorP X0Y1_口CP;

		public ColorP X0Y1_歯CP;

		public ColorP X0Y1_口紅上CP;

		public ColorP X0Y1_口紅下_口紅CP;

		public ColorP X0Y1_口紅下_ハイライトCP;

		public ColorP X0Y2_口CP;

		public ColorP X0Y2_歯CP;

		public ColorP X0Y2_口紅上CP;

		public ColorP X0Y2_口紅下_口紅CP;

		public ColorP X0Y2_口紅下_ハイライトCP;

		public ColorP X0Y3_口CP;

		public ColorP X0Y3_歯CP;

		public ColorP X0Y3_口紅上CP;

		public ColorP X0Y3_口紅下_口紅CP;

		public ColorP X0Y3_口紅下_ハイライトCP;

		public ColorP X0Y4_口CP;

		public ColorP X0Y4_口紅上CP;

		public ColorP X0Y4_口紅下_口紅CP;

		public ColorP X0Y4_口紅下_ハイライトCP;

		public ColorP X0Y5_口CP;

		public ColorP X0Y5_歯CP;

		public ColorP X0Y5_口紅上CP;

		public ColorP X0Y5_口紅下_口紅CP;

		public ColorP X0Y5_口紅下_ハイライトCP;

		public ColorP X0Y6_口CP;

		public ColorP X0Y6_歯CP;

		public ColorP X0Y6_口紅上CP;

		public ColorP X0Y6_口紅下_口紅CP;

		public ColorP X0Y6_口紅下_ハイライトCP;

		public ColorP X0Y7_口CP;

		public ColorP X0Y7_歯CP;

		public ColorP X0Y7_口紅上CP;

		public ColorP X0Y7_口紅下_口紅CP;

		public ColorP X0Y7_口紅下_ハイライトCP;

		public ColorP X0Y8_口CP;

		public ColorP X0Y8_歯CP;

		public ColorP X0Y8_口紅上CP;

		public ColorP X0Y8_口紅下_口紅CP;

		public ColorP X0Y8_口紅下_ハイライトCP;

		public ColorP X0Y9_口CP;

		public ColorP X0Y9_歯CP;

		public ColorP X0Y9_口紅上CP;

		public ColorP X0Y9_口紅下_口紅CP;

		public ColorP X0Y9_口紅下_ハイライトCP;

		public ColorP X0Y10_口CP;

		public ColorP X0Y10_口紅上CP;

		public ColorP X0Y10_口紅下_口紅CP;

		public ColorP X0Y10_口紅下_ハイライトCP;

		public ColorP X0Y11_口CP;

		public ColorP X0Y11_口紅上CP;

		public ColorP X0Y11_口紅下_口紅CP;

		public ColorP X0Y11_口紅下_ハイライトCP;

		public ColorP X0Y12_口CP;

		public ColorP X0Y12_歯CP;

		public ColorP X0Y12_口紅上CP;

		public ColorP X0Y12_口紅下_口紅CP;

		public ColorP X0Y12_口紅下_ハイライトCP;

		public ColorP X0Y13_口CP;

		public ColorP X0Y13_口紅上CP;

		public ColorP X0Y13_口紅下_口紅CP;

		public ColorP X0Y13_口紅下_ハイライトCP;
	}
}
