using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 尾_龍 : 尾
	{
		public 尾_龍(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 尾_龍D e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "龍尾";
			dif.Add(new Pars(Sta.尻尾["尾"][0][5]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_尾40 = pars["尾40"].ToPar();
			this.X0Y0_尾39 = pars["尾39"].ToPar();
			this.X0Y0_尾38 = pars["尾38"].ToPar();
			this.X0Y0_尾37 = pars["尾37"].ToPar();
			this.X0Y0_尾36 = pars["尾36"].ToPar();
			this.X0Y0_尾35 = pars["尾35"].ToPar();
			this.X0Y0_尾34 = pars["尾34"].ToPar();
			this.X0Y0_尾33 = pars["尾33"].ToPar();
			this.X0Y0_尾32 = pars["尾32"].ToPar();
			this.X0Y0_尾31 = pars["尾31"].ToPar();
			this.X0Y0_尾30 = pars["尾30"].ToPar();
			this.X0Y0_尾29 = pars["尾29"].ToPar();
			this.X0Y0_尾28 = pars["尾28"].ToPar();
			this.X0Y0_尾27 = pars["尾27"].ToPar();
			this.X0Y0_尾26 = pars["尾26"].ToPar();
			this.X0Y0_尾25 = pars["尾25"].ToPar();
			this.X0Y0_尾24 = pars["尾24"].ToPar();
			this.X0Y0_尾23 = pars["尾23"].ToPar();
			this.X0Y0_尾22 = pars["尾22"].ToPar();
			this.X0Y0_尾21 = pars["尾21"].ToPar();
			this.X0Y0_尾20 = pars["尾20"].ToPar();
			this.X0Y0_尾19 = pars["尾19"].ToPar();
			this.X0Y0_尾18 = pars["尾18"].ToPar();
			this.X0Y0_尾17 = pars["尾17"].ToPar();
			this.X0Y0_尾16 = pars["尾16"].ToPar();
			this.X0Y0_尾15 = pars["尾15"].ToPar();
			Pars pars2 = pars["輪2"].ToPars();
			this.X0Y0_輪2_革 = pars2["革"].ToPar();
			this.X0Y0_輪2_金具1 = pars2["金具1"].ToPar();
			this.X0Y0_輪2_金具2 = pars2["金具2"].ToPar();
			this.X0Y0_輪2_金具3 = pars2["金具3"].ToPar();
			this.X0Y0_輪2_金具左 = pars2["金具左"].ToPar();
			this.X0Y0_輪2_金具右 = pars2["金具右"].ToPar();
			this.X0Y0_尾14 = pars["尾14"].ToPar();
			this.X0Y0_尾13 = pars["尾13"].ToPar();
			this.X0Y0_尾12 = pars["尾12"].ToPar();
			this.X0Y0_尾11 = pars["尾11"].ToPar();
			this.X0Y0_尾10 = pars["尾10"].ToPar();
			this.X0Y0_尾9 = pars["尾9"].ToPar();
			this.X0Y0_尾8 = pars["尾8"].ToPar();
			this.X0Y0_尾7 = pars["尾7"].ToPar();
			this.X0Y0_尾6 = pars["尾6"].ToPar();
			this.X0Y0_尾5 = pars["尾5"].ToPar();
			this.X0Y0_尾4 = pars["尾4"].ToPar();
			pars2 = pars["輪1"].ToPars();
			this.X0Y0_輪1_革 = pars2["革"].ToPar();
			this.X0Y0_輪1_金具1 = pars2["金具1"].ToPar();
			this.X0Y0_輪1_金具2 = pars2["金具2"].ToPar();
			this.X0Y0_輪1_金具3 = pars2["金具3"].ToPar();
			this.X0Y0_輪1_金具左 = pars2["金具左"].ToPar();
			this.X0Y0_輪1_金具右 = pars2["金具右"].ToPar();
			this.X0Y0_尾3 = pars["尾3"].ToPar();
			this.X0Y0_尾2 = pars["尾2"].ToPar();
			this.X0Y0_尾1 = pars["尾1"].ToPar();
			this.X0Y0_尾0 = pars["尾0"].ToPar();
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
			this.尾40_表示 = e.尾40_表示;
			this.尾39_表示 = e.尾39_表示;
			this.尾38_表示 = e.尾38_表示;
			this.尾37_表示 = e.尾37_表示;
			this.尾36_表示 = e.尾36_表示;
			this.尾35_表示 = e.尾35_表示;
			this.尾34_表示 = e.尾34_表示;
			this.尾33_表示 = e.尾33_表示;
			this.尾32_表示 = e.尾32_表示;
			this.尾31_表示 = e.尾31_表示;
			this.尾30_表示 = e.尾30_表示;
			this.尾29_表示 = e.尾29_表示;
			this.尾28_表示 = e.尾28_表示;
			this.尾27_表示 = e.尾27_表示;
			this.尾26_表示 = e.尾26_表示;
			this.尾25_表示 = e.尾25_表示;
			this.尾24_表示 = e.尾24_表示;
			this.尾23_表示 = e.尾23_表示;
			this.尾22_表示 = e.尾22_表示;
			this.尾21_表示 = e.尾21_表示;
			this.尾20_表示 = e.尾20_表示;
			this.尾19_表示 = e.尾19_表示;
			this.尾18_表示 = e.尾18_表示;
			this.尾17_表示 = e.尾17_表示;
			this.尾16_表示 = e.尾16_表示;
			this.尾15_表示 = e.尾15_表示;
			this.輪2_革_表示 = e.輪2_革_表示;
			this.輪2_金具1_表示 = e.輪2_金具1_表示;
			this.輪2_金具2_表示 = e.輪2_金具2_表示;
			this.輪2_金具3_表示 = e.輪2_金具3_表示;
			this.輪2_金具左_表示 = e.輪2_金具左_表示;
			this.輪2_金具右_表示 = e.輪2_金具右_表示;
			this.尾14_表示 = e.尾14_表示;
			this.尾13_表示 = e.尾13_表示;
			this.尾12_表示 = e.尾12_表示;
			this.尾11_表示 = e.尾11_表示;
			this.尾10_表示 = e.尾10_表示;
			this.尾9_表示 = e.尾9_表示;
			this.尾8_表示 = e.尾8_表示;
			this.尾7_表示 = e.尾7_表示;
			this.尾6_表示 = e.尾6_表示;
			this.尾5_表示 = e.尾5_表示;
			this.尾4_表示 = e.尾4_表示;
			this.輪1_革_表示 = e.輪1_革_表示;
			this.輪1_金具1_表示 = e.輪1_金具1_表示;
			this.輪1_金具2_表示 = e.輪1_金具2_表示;
			this.輪1_金具3_表示 = e.輪1_金具3_表示;
			this.輪1_金具左_表示 = e.輪1_金具左_表示;
			this.輪1_金具右_表示 = e.輪1_金具右_表示;
			this.尾3_表示 = e.尾3_表示;
			this.尾2_表示 = e.尾2_表示;
			this.尾1_表示 = e.尾1_表示;
			this.尾0_表示 = e.尾0_表示;
			this.輪1表示 = e.輪1表示;
			this.輪2表示 = e.輪2表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_尾40CP = new ColorP(this.X0Y0_尾40, this.尾40CD, DisUnit, true);
			this.X0Y0_尾39CP = new ColorP(this.X0Y0_尾39, this.尾39CD, DisUnit, true);
			this.X0Y0_尾38CP = new ColorP(this.X0Y0_尾38, this.尾38CD, DisUnit, true);
			this.X0Y0_尾37CP = new ColorP(this.X0Y0_尾37, this.尾37CD, DisUnit, true);
			this.X0Y0_尾36CP = new ColorP(this.X0Y0_尾36, this.尾36CD, DisUnit, true);
			this.X0Y0_尾35CP = new ColorP(this.X0Y0_尾35, this.尾35CD, DisUnit, true);
			this.X0Y0_尾34CP = new ColorP(this.X0Y0_尾34, this.尾34CD, DisUnit, true);
			this.X0Y0_尾33CP = new ColorP(this.X0Y0_尾33, this.尾33CD, DisUnit, true);
			this.X0Y0_尾32CP = new ColorP(this.X0Y0_尾32, this.尾32CD, DisUnit, true);
			this.X0Y0_尾31CP = new ColorP(this.X0Y0_尾31, this.尾31CD, DisUnit, true);
			this.X0Y0_尾30CP = new ColorP(this.X0Y0_尾30, this.尾30CD, DisUnit, true);
			this.X0Y0_尾29CP = new ColorP(this.X0Y0_尾29, this.尾29CD, DisUnit, true);
			this.X0Y0_尾28CP = new ColorP(this.X0Y0_尾28, this.尾28CD, DisUnit, true);
			this.X0Y0_尾27CP = new ColorP(this.X0Y0_尾27, this.尾27CD, DisUnit, true);
			this.X0Y0_尾26CP = new ColorP(this.X0Y0_尾26, this.尾26CD, DisUnit, true);
			this.X0Y0_尾25CP = new ColorP(this.X0Y0_尾25, this.尾25CD, DisUnit, true);
			this.X0Y0_尾24CP = new ColorP(this.X0Y0_尾24, this.尾24CD, DisUnit, true);
			this.X0Y0_尾23CP = new ColorP(this.X0Y0_尾23, this.尾23CD, DisUnit, true);
			this.X0Y0_尾22CP = new ColorP(this.X0Y0_尾22, this.尾22CD, DisUnit, true);
			this.X0Y0_尾21CP = new ColorP(this.X0Y0_尾21, this.尾21CD, DisUnit, true);
			this.X0Y0_尾20CP = new ColorP(this.X0Y0_尾20, this.尾20CD, DisUnit, true);
			this.X0Y0_尾19CP = new ColorP(this.X0Y0_尾19, this.尾19CD, DisUnit, true);
			this.X0Y0_尾18CP = new ColorP(this.X0Y0_尾18, this.尾18CD, DisUnit, true);
			this.X0Y0_尾17CP = new ColorP(this.X0Y0_尾17, this.尾17CD, DisUnit, true);
			this.X0Y0_尾16CP = new ColorP(this.X0Y0_尾16, this.尾16CD, DisUnit, true);
			this.X0Y0_尾15CP = new ColorP(this.X0Y0_尾15, this.尾15CD, DisUnit, true);
			this.X0Y0_輪2_革CP = new ColorP(this.X0Y0_輪2_革, this.輪2_革CD, DisUnit, true);
			this.X0Y0_輪2_金具1CP = new ColorP(this.X0Y0_輪2_金具1, this.輪2_金具1CD, DisUnit, true);
			this.X0Y0_輪2_金具2CP = new ColorP(this.X0Y0_輪2_金具2, this.輪2_金具2CD, DisUnit, true);
			this.X0Y0_輪2_金具3CP = new ColorP(this.X0Y0_輪2_金具3, this.輪2_金具3CD, DisUnit, true);
			this.X0Y0_輪2_金具左CP = new ColorP(this.X0Y0_輪2_金具左, this.輪2_金具左CD, DisUnit, true);
			this.X0Y0_輪2_金具右CP = new ColorP(this.X0Y0_輪2_金具右, this.輪2_金具右CD, DisUnit, true);
			this.X0Y0_尾14CP = new ColorP(this.X0Y0_尾14, this.尾14CD, DisUnit, true);
			this.X0Y0_尾13CP = new ColorP(this.X0Y0_尾13, this.尾13CD, DisUnit, true);
			this.X0Y0_尾12CP = new ColorP(this.X0Y0_尾12, this.尾12CD, DisUnit, true);
			this.X0Y0_尾11CP = new ColorP(this.X0Y0_尾11, this.尾11CD, DisUnit, true);
			this.X0Y0_尾10CP = new ColorP(this.X0Y0_尾10, this.尾10CD, DisUnit, true);
			this.X0Y0_尾9CP = new ColorP(this.X0Y0_尾9, this.尾9CD, DisUnit, true);
			this.X0Y0_尾8CP = new ColorP(this.X0Y0_尾8, this.尾8CD, DisUnit, true);
			this.X0Y0_尾7CP = new ColorP(this.X0Y0_尾7, this.尾7CD, DisUnit, true);
			this.X0Y0_尾6CP = new ColorP(this.X0Y0_尾6, this.尾6CD, DisUnit, true);
			this.X0Y0_尾5CP = new ColorP(this.X0Y0_尾5, this.尾5CD, DisUnit, true);
			this.X0Y0_尾4CP = new ColorP(this.X0Y0_尾4, this.尾4CD, DisUnit, true);
			this.X0Y0_輪1_革CP = new ColorP(this.X0Y0_輪1_革, this.輪1_革CD, DisUnit, true);
			this.X0Y0_輪1_金具1CP = new ColorP(this.X0Y0_輪1_金具1, this.輪1_金具1CD, DisUnit, true);
			this.X0Y0_輪1_金具2CP = new ColorP(this.X0Y0_輪1_金具2, this.輪1_金具2CD, DisUnit, true);
			this.X0Y0_輪1_金具3CP = new ColorP(this.X0Y0_輪1_金具3, this.輪1_金具3CD, DisUnit, true);
			this.X0Y0_輪1_金具左CP = new ColorP(this.X0Y0_輪1_金具左, this.輪1_金具左CD, DisUnit, true);
			this.X0Y0_輪1_金具右CP = new ColorP(this.X0Y0_輪1_金具右, this.輪1_金具右CD, DisUnit, true);
			this.X0Y0_尾3CP = new ColorP(this.X0Y0_尾3, this.尾3CD, DisUnit, true);
			this.X0Y0_尾2CP = new ColorP(this.X0Y0_尾2, this.尾2CD, DisUnit, true);
			this.X0Y0_尾1CP = new ColorP(this.X0Y0_尾1, this.尾1CD, DisUnit, true);
			this.X0Y0_尾0CP = new ColorP(this.X0Y0_尾0, this.尾0CD, DisUnit, true);
			this.濃度 = e.濃度;
			this.鎖1 = new 拘束鎖(DisUnit, this.右, 配色指定, 体配色, this.Xasix);
			this.鎖2 = new 拘束鎖(DisUnit, !this.右, 配色指定, 体配色, this.Xasix);
			this.鎖3 = new 拘束鎖(DisUnit, this.右, 配色指定, 体配色, this.Xasix);
			this.鎖4 = new 拘束鎖(DisUnit, !this.右, 配色指定, 体配色, this.Xasix);
			this.鎖1.接続(this.鎖1_接続点);
			this.鎖2.接続(this.鎖2_接続点);
			this.鎖3.接続(this.鎖3_接続点);
			this.鎖4.接続(this.鎖4_接続点);
			int num = this.右 ? -10 : 10;
			this.鎖1.角度B -= (double)num;
			this.鎖2.角度B += (double)num;
			this.鎖3.角度B -= (double)num;
			this.鎖4.角度B += (double)num;
			this.鎖表示 = e.鎖表示;
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
				this.輪1表示 = this.拘束_;
				this.輪2表示 = this.拘束_;
			}
		}

		public bool 尾40_表示
		{
			get
			{
				return this.X0Y0_尾40.Dra;
			}
			set
			{
				this.X0Y0_尾40.Dra = value;
				this.X0Y0_尾40.Hit = value;
			}
		}

		public bool 尾39_表示
		{
			get
			{
				return this.X0Y0_尾39.Dra;
			}
			set
			{
				this.X0Y0_尾39.Dra = value;
				this.X0Y0_尾39.Hit = value;
			}
		}

		public bool 尾38_表示
		{
			get
			{
				return this.X0Y0_尾38.Dra;
			}
			set
			{
				this.X0Y0_尾38.Dra = value;
				this.X0Y0_尾38.Hit = value;
			}
		}

		public bool 尾37_表示
		{
			get
			{
				return this.X0Y0_尾37.Dra;
			}
			set
			{
				this.X0Y0_尾37.Dra = value;
				this.X0Y0_尾37.Hit = value;
			}
		}

		public bool 尾36_表示
		{
			get
			{
				return this.X0Y0_尾36.Dra;
			}
			set
			{
				this.X0Y0_尾36.Dra = value;
				this.X0Y0_尾36.Hit = value;
			}
		}

		public bool 尾35_表示
		{
			get
			{
				return this.X0Y0_尾35.Dra;
			}
			set
			{
				this.X0Y0_尾35.Dra = value;
				this.X0Y0_尾35.Hit = value;
			}
		}

		public bool 尾34_表示
		{
			get
			{
				return this.X0Y0_尾34.Dra;
			}
			set
			{
				this.X0Y0_尾34.Dra = value;
				this.X0Y0_尾34.Hit = value;
			}
		}

		public bool 尾33_表示
		{
			get
			{
				return this.X0Y0_尾33.Dra;
			}
			set
			{
				this.X0Y0_尾33.Dra = value;
				this.X0Y0_尾33.Hit = value;
			}
		}

		public bool 尾32_表示
		{
			get
			{
				return this.X0Y0_尾32.Dra;
			}
			set
			{
				this.X0Y0_尾32.Dra = value;
				this.X0Y0_尾32.Hit = value;
			}
		}

		public bool 尾31_表示
		{
			get
			{
				return this.X0Y0_尾31.Dra;
			}
			set
			{
				this.X0Y0_尾31.Dra = value;
				this.X0Y0_尾31.Hit = value;
			}
		}

		public bool 尾30_表示
		{
			get
			{
				return this.X0Y0_尾30.Dra;
			}
			set
			{
				this.X0Y0_尾30.Dra = value;
				this.X0Y0_尾30.Hit = value;
			}
		}

		public bool 尾29_表示
		{
			get
			{
				return this.X0Y0_尾29.Dra;
			}
			set
			{
				this.X0Y0_尾29.Dra = value;
				this.X0Y0_尾29.Hit = value;
			}
		}

		public bool 尾28_表示
		{
			get
			{
				return this.X0Y0_尾28.Dra;
			}
			set
			{
				this.X0Y0_尾28.Dra = value;
				this.X0Y0_尾28.Hit = value;
			}
		}

		public bool 尾27_表示
		{
			get
			{
				return this.X0Y0_尾27.Dra;
			}
			set
			{
				this.X0Y0_尾27.Dra = value;
				this.X0Y0_尾27.Hit = value;
			}
		}

		public bool 尾26_表示
		{
			get
			{
				return this.X0Y0_尾26.Dra;
			}
			set
			{
				this.X0Y0_尾26.Dra = value;
				this.X0Y0_尾26.Hit = value;
			}
		}

		public bool 尾25_表示
		{
			get
			{
				return this.X0Y0_尾25.Dra;
			}
			set
			{
				this.X0Y0_尾25.Dra = value;
				this.X0Y0_尾25.Hit = value;
			}
		}

		public bool 尾24_表示
		{
			get
			{
				return this.X0Y0_尾24.Dra;
			}
			set
			{
				this.X0Y0_尾24.Dra = value;
				this.X0Y0_尾24.Hit = value;
			}
		}

		public bool 尾23_表示
		{
			get
			{
				return this.X0Y0_尾23.Dra;
			}
			set
			{
				this.X0Y0_尾23.Dra = value;
				this.X0Y0_尾23.Hit = value;
			}
		}

		public bool 尾22_表示
		{
			get
			{
				return this.X0Y0_尾22.Dra;
			}
			set
			{
				this.X0Y0_尾22.Dra = value;
				this.X0Y0_尾22.Hit = value;
			}
		}

		public bool 尾21_表示
		{
			get
			{
				return this.X0Y0_尾21.Dra;
			}
			set
			{
				this.X0Y0_尾21.Dra = value;
				this.X0Y0_尾21.Hit = value;
			}
		}

		public bool 尾20_表示
		{
			get
			{
				return this.X0Y0_尾20.Dra;
			}
			set
			{
				this.X0Y0_尾20.Dra = value;
				this.X0Y0_尾20.Hit = value;
			}
		}

		public bool 尾19_表示
		{
			get
			{
				return this.X0Y0_尾19.Dra;
			}
			set
			{
				this.X0Y0_尾19.Dra = value;
				this.X0Y0_尾19.Hit = value;
			}
		}

		public bool 尾18_表示
		{
			get
			{
				return this.X0Y0_尾18.Dra;
			}
			set
			{
				this.X0Y0_尾18.Dra = value;
				this.X0Y0_尾18.Hit = value;
			}
		}

		public bool 尾17_表示
		{
			get
			{
				return this.X0Y0_尾17.Dra;
			}
			set
			{
				this.X0Y0_尾17.Dra = value;
				this.X0Y0_尾17.Hit = value;
			}
		}

		public bool 尾16_表示
		{
			get
			{
				return this.X0Y0_尾16.Dra;
			}
			set
			{
				this.X0Y0_尾16.Dra = value;
				this.X0Y0_尾16.Hit = value;
			}
		}

		public bool 尾15_表示
		{
			get
			{
				return this.X0Y0_尾15.Dra;
			}
			set
			{
				this.X0Y0_尾15.Dra = value;
				this.X0Y0_尾15.Hit = value;
			}
		}

		public bool 輪2_革_表示
		{
			get
			{
				return this.X0Y0_輪2_革.Dra;
			}
			set
			{
				this.X0Y0_輪2_革.Dra = value;
				this.X0Y0_輪2_革.Hit = value;
			}
		}

		public bool 輪2_金具1_表示
		{
			get
			{
				return this.X0Y0_輪2_金具1.Dra;
			}
			set
			{
				this.X0Y0_輪2_金具1.Dra = value;
				this.X0Y0_輪2_金具1.Hit = value;
			}
		}

		public bool 輪2_金具2_表示
		{
			get
			{
				return this.X0Y0_輪2_金具2.Dra;
			}
			set
			{
				this.X0Y0_輪2_金具2.Dra = value;
				this.X0Y0_輪2_金具2.Hit = value;
			}
		}

		public bool 輪2_金具3_表示
		{
			get
			{
				return this.X0Y0_輪2_金具3.Dra;
			}
			set
			{
				this.X0Y0_輪2_金具3.Dra = value;
				this.X0Y0_輪2_金具3.Hit = value;
			}
		}

		public bool 輪2_金具左_表示
		{
			get
			{
				return this.X0Y0_輪2_金具左.Dra;
			}
			set
			{
				this.X0Y0_輪2_金具左.Dra = value;
				this.X0Y0_輪2_金具左.Hit = value;
			}
		}

		public bool 輪2_金具右_表示
		{
			get
			{
				return this.X0Y0_輪2_金具右.Dra;
			}
			set
			{
				this.X0Y0_輪2_金具右.Dra = value;
				this.X0Y0_輪2_金具右.Hit = value;
			}
		}

		public bool 尾14_表示
		{
			get
			{
				return this.X0Y0_尾14.Dra;
			}
			set
			{
				this.X0Y0_尾14.Dra = value;
				this.X0Y0_尾14.Hit = value;
			}
		}

		public bool 尾13_表示
		{
			get
			{
				return this.X0Y0_尾13.Dra;
			}
			set
			{
				this.X0Y0_尾13.Dra = value;
				this.X0Y0_尾13.Hit = value;
			}
		}

		public bool 尾12_表示
		{
			get
			{
				return this.X0Y0_尾12.Dra;
			}
			set
			{
				this.X0Y0_尾12.Dra = value;
				this.X0Y0_尾12.Hit = value;
			}
		}

		public bool 尾11_表示
		{
			get
			{
				return this.X0Y0_尾11.Dra;
			}
			set
			{
				this.X0Y0_尾11.Dra = value;
				this.X0Y0_尾11.Hit = value;
			}
		}

		public bool 尾10_表示
		{
			get
			{
				return this.X0Y0_尾10.Dra;
			}
			set
			{
				this.X0Y0_尾10.Dra = value;
				this.X0Y0_尾10.Hit = value;
			}
		}

		public bool 尾9_表示
		{
			get
			{
				return this.X0Y0_尾9.Dra;
			}
			set
			{
				this.X0Y0_尾9.Dra = value;
				this.X0Y0_尾9.Hit = value;
			}
		}

		public bool 尾8_表示
		{
			get
			{
				return this.X0Y0_尾8.Dra;
			}
			set
			{
				this.X0Y0_尾8.Dra = value;
				this.X0Y0_尾8.Hit = value;
			}
		}

		public bool 尾7_表示
		{
			get
			{
				return this.X0Y0_尾7.Dra;
			}
			set
			{
				this.X0Y0_尾7.Dra = value;
				this.X0Y0_尾7.Hit = value;
			}
		}

		public bool 尾6_表示
		{
			get
			{
				return this.X0Y0_尾6.Dra;
			}
			set
			{
				this.X0Y0_尾6.Dra = value;
				this.X0Y0_尾6.Hit = value;
			}
		}

		public bool 尾5_表示
		{
			get
			{
				return this.X0Y0_尾5.Dra;
			}
			set
			{
				this.X0Y0_尾5.Dra = value;
				this.X0Y0_尾5.Hit = value;
			}
		}

		public bool 尾4_表示
		{
			get
			{
				return this.X0Y0_尾4.Dra;
			}
			set
			{
				this.X0Y0_尾4.Dra = value;
				this.X0Y0_尾4.Hit = value;
			}
		}

		public bool 輪1_革_表示
		{
			get
			{
				return this.X0Y0_輪1_革.Dra;
			}
			set
			{
				this.X0Y0_輪1_革.Dra = value;
				this.X0Y0_輪1_革.Hit = value;
			}
		}

		public bool 輪1_金具1_表示
		{
			get
			{
				return this.X0Y0_輪1_金具1.Dra;
			}
			set
			{
				this.X0Y0_輪1_金具1.Dra = value;
				this.X0Y0_輪1_金具1.Hit = value;
			}
		}

		public bool 輪1_金具2_表示
		{
			get
			{
				return this.X0Y0_輪1_金具2.Dra;
			}
			set
			{
				this.X0Y0_輪1_金具2.Dra = value;
				this.X0Y0_輪1_金具2.Hit = value;
			}
		}

		public bool 輪1_金具3_表示
		{
			get
			{
				return this.X0Y0_輪1_金具3.Dra;
			}
			set
			{
				this.X0Y0_輪1_金具3.Dra = value;
				this.X0Y0_輪1_金具3.Hit = value;
			}
		}

		public bool 輪1_金具左_表示
		{
			get
			{
				return this.X0Y0_輪1_金具左.Dra;
			}
			set
			{
				this.X0Y0_輪1_金具左.Dra = value;
				this.X0Y0_輪1_金具左.Hit = value;
			}
		}

		public bool 輪1_金具右_表示
		{
			get
			{
				return this.X0Y0_輪1_金具右.Dra;
			}
			set
			{
				this.X0Y0_輪1_金具右.Dra = value;
				this.X0Y0_輪1_金具右.Hit = value;
			}
		}

		public bool 尾3_表示
		{
			get
			{
				return this.X0Y0_尾3.Dra;
			}
			set
			{
				this.X0Y0_尾3.Dra = value;
				this.X0Y0_尾3.Hit = value;
			}
		}

		public bool 尾2_表示
		{
			get
			{
				return this.X0Y0_尾2.Dra;
			}
			set
			{
				this.X0Y0_尾2.Dra = value;
				this.X0Y0_尾2.Hit = value;
			}
		}

		public bool 尾1_表示
		{
			get
			{
				return this.X0Y0_尾1.Dra;
			}
			set
			{
				this.X0Y0_尾1.Dra = value;
				this.X0Y0_尾1.Hit = value;
			}
		}

		public bool 尾0_表示
		{
			get
			{
				return this.X0Y0_尾0.Dra;
			}
			set
			{
				this.X0Y0_尾0.Dra = value;
				this.X0Y0_尾0.Hit = value;
			}
		}

		public bool 輪1表示
		{
			get
			{
				return this.輪1_革_表示;
			}
			set
			{
				this.輪1_革_表示 = value;
				this.輪1_金具1_表示 = value;
				this.輪1_金具2_表示 = value;
				this.輪1_金具3_表示 = value;
				this.輪1_金具左_表示 = value;
				this.輪1_金具右_表示 = value;
			}
		}

		public bool 輪2表示
		{
			get
			{
				return this.輪2_革_表示;
			}
			set
			{
				this.輪2_革_表示 = value;
				this.輪2_金具1_表示 = value;
				this.輪2_金具2_表示 = value;
				this.輪2_金具3_表示 = value;
				this.輪2_金具左_表示 = value;
				this.輪2_金具右_表示 = value;
			}
		}

		public bool 鎖表示
		{
			get
			{
				return this.鎖1.表示;
			}
			set
			{
				this.鎖1.表示 = value;
				this.鎖2.表示 = value;
				this.鎖3.表示 = value;
				this.鎖4.表示 = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.尾40_表示;
			}
			set
			{
				this.尾40_表示 = value;
				this.尾39_表示 = value;
				this.尾38_表示 = value;
				this.尾37_表示 = value;
				this.尾36_表示 = value;
				this.尾35_表示 = value;
				this.尾34_表示 = value;
				this.尾33_表示 = value;
				this.尾32_表示 = value;
				this.尾31_表示 = value;
				this.尾30_表示 = value;
				this.尾29_表示 = value;
				this.尾28_表示 = value;
				this.尾27_表示 = value;
				this.尾26_表示 = value;
				this.尾25_表示 = value;
				this.尾24_表示 = value;
				this.尾23_表示 = value;
				this.尾22_表示 = value;
				this.尾21_表示 = value;
				this.尾20_表示 = value;
				this.尾19_表示 = value;
				this.尾18_表示 = value;
				this.尾17_表示 = value;
				this.尾16_表示 = value;
				this.尾15_表示 = value;
				this.輪2_革_表示 = value;
				this.輪2_金具1_表示 = value;
				this.輪2_金具2_表示 = value;
				this.輪2_金具3_表示 = value;
				this.輪2_金具左_表示 = value;
				this.輪2_金具右_表示 = value;
				this.尾14_表示 = value;
				this.尾13_表示 = value;
				this.尾12_表示 = value;
				this.尾11_表示 = value;
				this.尾10_表示 = value;
				this.尾9_表示 = value;
				this.尾8_表示 = value;
				this.尾7_表示 = value;
				this.尾6_表示 = value;
				this.尾5_表示 = value;
				this.尾4_表示 = value;
				this.輪1_革_表示 = value;
				this.輪1_金具1_表示 = value;
				this.輪1_金具2_表示 = value;
				this.輪1_金具3_表示 = value;
				this.輪1_金具左_表示 = value;
				this.輪1_金具右_表示 = value;
				this.尾3_表示 = value;
				this.尾2_表示 = value;
				this.尾1_表示 = value;
				this.尾0_表示 = value;
				this.鎖1.表示 = value;
				this.鎖2.表示 = value;
				this.鎖3.表示 = value;
				this.鎖4.表示 = value;
			}
		}

		public override void 描画0(Are Are)
		{
			Are.Draw(this.X0Y0_尾40);
			Are.Draw(this.X0Y0_尾39);
			Are.Draw(this.X0Y0_尾38);
			Are.Draw(this.X0Y0_尾37);
			Are.Draw(this.X0Y0_尾36);
			Are.Draw(this.X0Y0_尾35);
			Are.Draw(this.X0Y0_尾34);
			Are.Draw(this.X0Y0_尾33);
			Are.Draw(this.X0Y0_尾32);
			Are.Draw(this.X0Y0_尾31);
			Are.Draw(this.X0Y0_尾30);
			Are.Draw(this.X0Y0_尾29);
			Are.Draw(this.X0Y0_尾28);
			Are.Draw(this.X0Y0_尾27);
			Are.Draw(this.X0Y0_尾26);
			Are.Draw(this.X0Y0_尾25);
			Are.Draw(this.X0Y0_尾24);
			Are.Draw(this.X0Y0_尾23);
			Are.Draw(this.X0Y0_尾22);
			Are.Draw(this.X0Y0_尾21);
			Are.Draw(this.X0Y0_尾20);
			Are.Draw(this.X0Y0_尾19);
			Are.Draw(this.X0Y0_尾18);
			Are.Draw(this.X0Y0_尾17);
			Are.Draw(this.X0Y0_尾16);
			Are.Draw(this.X0Y0_尾15);
			Are.Draw(this.X0Y0_輪2_革);
			Are.Draw(this.X0Y0_輪2_金具1);
			Are.Draw(this.X0Y0_輪2_金具2);
			Are.Draw(this.X0Y0_輪2_金具3);
			Are.Draw(this.X0Y0_輪2_金具左);
			Are.Draw(this.X0Y0_輪2_金具右);
			this.鎖1.描画0(Are);
			this.鎖2.描画0(Are);
			Are.Draw(this.X0Y0_尾14);
			Are.Draw(this.X0Y0_尾13);
			Are.Draw(this.X0Y0_尾12);
			Are.Draw(this.X0Y0_尾11);
			Are.Draw(this.X0Y0_尾10);
			Are.Draw(this.X0Y0_尾9);
			Are.Draw(this.X0Y0_尾8);
			Are.Draw(this.X0Y0_尾7);
			Are.Draw(this.X0Y0_尾6);
			Are.Draw(this.X0Y0_尾5);
			Are.Draw(this.X0Y0_尾4);
			Are.Draw(this.X0Y0_輪1_革);
			Are.Draw(this.X0Y0_輪1_金具1);
			Are.Draw(this.X0Y0_輪1_金具2);
			Are.Draw(this.X0Y0_輪1_金具3);
			Are.Draw(this.X0Y0_輪1_金具左);
			Are.Draw(this.X0Y0_輪1_金具右);
			this.鎖3.描画0(Are);
			this.鎖4.描画0(Are);
			Are.Draw(this.X0Y0_尾3);
			Are.Draw(this.X0Y0_尾2);
			Are.Draw(this.X0Y0_尾1);
			Are.Draw(this.X0Y0_尾0);
		}

		public override void Dispose()
		{
			base.Dispose();
			this.鎖1.Dispose();
			this.鎖2.Dispose();
			this.鎖3.Dispose();
			this.鎖4.Dispose();
		}

		public override double 濃度
		{
			get
			{
				return this.尾40CD.不透明度;
			}
			set
			{
				this.尾40CD.不透明度 = value;
				this.尾39CD.不透明度 = value;
				this.尾38CD.不透明度 = value;
				this.尾37CD.不透明度 = value;
				this.尾36CD.不透明度 = value;
				this.尾35CD.不透明度 = value;
				this.尾34CD.不透明度 = value;
				this.尾33CD.不透明度 = value;
				this.尾32CD.不透明度 = value;
				this.尾31CD.不透明度 = value;
				this.尾30CD.不透明度 = value;
				this.尾29CD.不透明度 = value;
				this.尾28CD.不透明度 = value;
				this.尾27CD.不透明度 = value;
				this.尾26CD.不透明度 = value;
				this.尾25CD.不透明度 = value;
				this.尾24CD.不透明度 = value;
				this.尾23CD.不透明度 = value;
				this.尾22CD.不透明度 = value;
				this.尾21CD.不透明度 = value;
				this.尾20CD.不透明度 = value;
				this.尾19CD.不透明度 = value;
				this.尾18CD.不透明度 = value;
				this.尾17CD.不透明度 = value;
				this.尾16CD.不透明度 = value;
				this.尾15CD.不透明度 = value;
				this.尾14CD.不透明度 = value;
				this.尾13CD.不透明度 = value;
				this.尾12CD.不透明度 = value;
				this.尾11CD.不透明度 = value;
				this.尾10CD.不透明度 = value;
				this.尾9CD.不透明度 = value;
				this.尾8CD.不透明度 = value;
				this.尾7CD.不透明度 = value;
				this.尾6CD.不透明度 = value;
				this.尾5CD.不透明度 = value;
				this.尾4CD.不透明度 = value;
				this.尾3CD.不透明度 = value;
				this.尾2CD.不透明度 = value;
				this.尾1CD.不透明度 = value;
				this.尾0CD.不透明度 = value;
				this.輪1_革CD.不透明度 = value;
				this.輪1_金具1CD.不透明度 = value;
				this.輪1_金具2CD.不透明度 = value;
				this.輪1_金具3CD.不透明度 = value;
				this.輪1_金具左CD.不透明度 = value;
				this.輪1_金具右CD.不透明度 = value;
				this.輪2_革CD.不透明度 = value;
				this.輪2_金具1CD.不透明度 = value;
				this.輪2_金具2CD.不透明度 = value;
				this.輪2_金具3CD.不透明度 = value;
				this.輪2_金具左CD.不透明度 = value;
				this.輪2_金具右CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			bool 右 = this.右;
			double maxAngle = 20.0;
			this.X0Y0_尾40.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾39.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾38.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾37.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾36.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾35.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾34.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾33.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾32.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾31.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾30.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾29.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾28.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾27.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾26.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾25.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾24.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾23.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾22.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾21.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾20.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾19.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾18.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾17.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾16.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾15.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾14.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾13.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾12.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾11.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾10.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾9.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾8.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾7.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾6.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾5.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾4.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾3.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾2.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾1.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾0.AngleBase = maxAngle.GetRanAngle();
			this.本体.JoinPAall();
		}

		public override bool Is革(Par p)
		{
			return p == this.X0Y0_輪2_革 || p == this.X0Y0_輪2_金具1 || p == this.X0Y0_輪2_金具2 || p == this.X0Y0_輪2_金具3 || p == this.X0Y0_輪2_金具左 || p == this.X0Y0_輪2_金具右 || p == this.X0Y0_輪1_革 || p == this.X0Y0_輪1_金具1 || p == this.X0Y0_輪1_金具2 || p == this.X0Y0_輪1_金具3 || p == this.X0Y0_輪1_金具左 || p == this.X0Y0_輪1_金具右;
		}

		public override IEnumerable<Par> Enum軸()
		{
			yield return this.X0Y0_尾0;
			yield return this.X0Y0_尾1;
			yield return this.X0Y0_尾2;
			yield return this.X0Y0_尾3;
			yield return this.X0Y0_尾4;
			yield return this.X0Y0_尾5;
			yield return this.X0Y0_尾6;
			yield return this.X0Y0_尾7;
			yield return this.X0Y0_尾8;
			yield return this.X0Y0_尾9;
			yield return this.X0Y0_尾10;
			yield return this.X0Y0_尾11;
			yield return this.X0Y0_尾12;
			yield return this.X0Y0_尾13;
			yield return this.X0Y0_尾14;
			yield return this.X0Y0_尾15;
			yield return this.X0Y0_尾16;
			yield return this.X0Y0_尾17;
			yield return this.X0Y0_尾18;
			yield return this.X0Y0_尾19;
			yield return this.X0Y0_尾20;
			yield return this.X0Y0_尾21;
			yield return this.X0Y0_尾22;
			yield return this.X0Y0_尾23;
			yield return this.X0Y0_尾24;
			yield return this.X0Y0_尾25;
			yield return this.X0Y0_尾26;
			yield return this.X0Y0_尾27;
			yield return this.X0Y0_尾28;
			yield return this.X0Y0_尾29;
			yield return this.X0Y0_尾30;
			yield return this.X0Y0_尾31;
			yield return this.X0Y0_尾32;
			yield return this.X0Y0_尾33;
			yield return this.X0Y0_尾34;
			yield return this.X0Y0_尾35;
			yield return this.X0Y0_尾36;
			yield return this.X0Y0_尾37;
			yield return this.X0Y0_尾38;
			yield return this.X0Y0_尾39;
			yield return this.X0Y0_尾40;
			yield break;
		}

		public JointS 鎖1_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_輪1_金具左, 0);
			}
		}

		public JointS 鎖2_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_輪1_金具右, 0);
			}
		}

		public JointS 鎖3_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_輪2_金具左, 0);
			}
		}

		public JointS 鎖4_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_輪2_金具右, 0);
			}
		}

		public override void 色更新()
		{
			this.X0Y0_尾40CP.Update();
			this.X0Y0_尾39CP.Update();
			this.X0Y0_尾38CP.Update();
			this.X0Y0_尾37CP.Update();
			this.X0Y0_尾36CP.Update();
			this.X0Y0_尾35CP.Update();
			this.X0Y0_尾34CP.Update();
			this.X0Y0_尾33CP.Update();
			this.X0Y0_尾32CP.Update();
			this.X0Y0_尾31CP.Update();
			this.X0Y0_尾30CP.Update();
			this.X0Y0_尾29CP.Update();
			this.X0Y0_尾28CP.Update();
			this.X0Y0_尾27CP.Update();
			this.X0Y0_尾26CP.Update();
			this.X0Y0_尾25CP.Update();
			this.X0Y0_尾24CP.Update();
			this.X0Y0_尾23CP.Update();
			this.X0Y0_尾22CP.Update();
			this.X0Y0_尾21CP.Update();
			this.X0Y0_尾20CP.Update();
			this.X0Y0_尾19CP.Update();
			this.X0Y0_尾18CP.Update();
			this.X0Y0_尾17CP.Update();
			this.X0Y0_尾16CP.Update();
			this.X0Y0_尾15CP.Update();
			this.X0Y0_輪2_革CP.Update();
			this.X0Y0_輪2_金具1CP.Update();
			this.X0Y0_輪2_金具2CP.Update();
			this.X0Y0_輪2_金具3CP.Update();
			this.X0Y0_輪2_金具左CP.Update();
			this.X0Y0_輪2_金具右CP.Update();
			this.X0Y0_尾14CP.Update();
			this.X0Y0_尾13CP.Update();
			this.X0Y0_尾12CP.Update();
			this.X0Y0_尾11CP.Update();
			this.X0Y0_尾10CP.Update();
			this.X0Y0_尾9CP.Update();
			this.X0Y0_尾8CP.Update();
			this.X0Y0_尾7CP.Update();
			this.X0Y0_尾6CP.Update();
			this.X0Y0_尾5CP.Update();
			this.X0Y0_尾4CP.Update();
			this.X0Y0_輪1_革CP.Update();
			this.X0Y0_輪1_金具1CP.Update();
			this.X0Y0_輪1_金具2CP.Update();
			this.X0Y0_輪1_金具3CP.Update();
			this.X0Y0_輪1_金具左CP.Update();
			this.X0Y0_輪1_金具右CP.Update();
			this.X0Y0_尾3CP.Update();
			this.X0Y0_尾2CP.Update();
			this.X0Y0_尾1CP.Update();
			this.X0Y0_尾0CP.Update();
			this.鎖1.接続PA();
			this.鎖2.接続PA();
			this.鎖3.接続PA();
			this.鎖4.接続PA();
			this.鎖1.色更新();
			this.鎖2.色更新();
			this.鎖3.色更新();
			this.鎖4.色更新();
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
			this.尾40CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾39CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾38CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾37CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾36CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾35CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾34CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾33CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾32CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾31CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾30CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾29CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾28CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾27CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾26CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾25CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾24CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾23CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾22CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾21CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾20CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾19CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾18CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾17CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾16CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾15CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾14CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾13CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾12CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾11CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾10CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾9CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾8CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾7CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾6CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾5CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾4CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾3CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾2CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾1CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾0CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.輪1_革CD = new ColorD();
			this.輪1_金具1CD = new ColorD();
			this.輪1_金具2CD = new ColorD();
			this.輪1_金具3CD = new ColorD();
			this.輪1_金具左CD = new ColorD();
			this.輪1_金具右CD = new ColorD();
			this.輪2_革CD = new ColorD();
			this.輪2_金具1CD = new ColorD();
			this.輪2_金具2CD = new ColorD();
			this.輪2_金具3CD = new ColorD();
			this.輪2_金具左CD = new ColorD();
			this.輪2_金具右CD = new ColorD();
		}

		private void 配色T0(体配色 体配色)
		{
			this.配色T(0, "尾", ref 体配色.鱗0R, ref 体配色.刺青R);
			this.輪1_革CD = new ColorD();
			this.輪1_金具1CD = new ColorD();
			this.輪1_金具2CD = new ColorD();
			this.輪1_金具3CD = new ColorD();
			this.輪1_金具左CD = new ColorD();
			this.輪1_金具右CD = new ColorD();
			this.輪2_革CD = new ColorD();
			this.輪2_金具1CD = new ColorD();
			this.輪2_金具2CD = new ColorD();
			this.輪2_金具3CD = new ColorD();
			this.輪2_金具左CD = new ColorD();
			this.輪2_金具右CD = new ColorD();
		}

		private void 配色T1(体配色 体配色)
		{
			this.配色T(1, "尾", ref 体配色.鱗0R, ref 体配色.刺青R);
			this.輪1_革CD = new ColorD();
			this.輪1_金具1CD = new ColorD();
			this.輪1_金具2CD = new ColorD();
			this.輪1_金具3CD = new ColorD();
			this.輪1_金具左CD = new ColorD();
			this.輪1_金具右CD = new ColorD();
			this.輪2_革CD = new ColorD();
			this.輪2_金具1CD = new ColorD();
			this.輪2_金具2CD = new ColorD();
			this.輪2_金具3CD = new ColorD();
			this.輪2_金具左CD = new ColorD();
			this.輪2_金具右CD = new ColorD();
		}

		public void 輪1配色(拘束具色 配色)
		{
			this.輪1_革CD.色 = 配色.革部色;
			this.輪1_金具1CD.色 = 配色.金具色;
			this.輪1_金具2CD.色 = this.輪1_金具1CD.色;
			this.輪1_金具3CD.色 = this.輪1_金具1CD.色;
			this.輪1_金具左CD.色 = this.輪1_金具1CD.色;
			this.輪1_金具右CD.色 = this.輪1_金具1CD.色;
		}

		public void 輪2配色(拘束具色 配色)
		{
			this.輪2_革CD.色 = 配色.革部色;
			this.輪2_金具1CD.色 = 配色.金具色;
			this.輪2_金具2CD.色 = this.輪2_金具1CD.色;
			this.輪2_金具3CD.色 = this.輪2_金具1CD.色;
			this.輪2_金具左CD.色 = this.輪2_金具1CD.色;
			this.輪2_金具右CD.色 = this.輪2_金具1CD.色;
		}

		public void 鎖配色(鎖色 配色)
		{
			this.鎖1.配色鎖(配色);
			this.鎖2.配色鎖(配色);
			this.鎖3.配色鎖(配色);
			this.鎖4.配色鎖(配色);
		}

		public Par X0Y0_尾40;

		public Par X0Y0_尾39;

		public Par X0Y0_尾38;

		public Par X0Y0_尾37;

		public Par X0Y0_尾36;

		public Par X0Y0_尾35;

		public Par X0Y0_尾34;

		public Par X0Y0_尾33;

		public Par X0Y0_尾32;

		public Par X0Y0_尾31;

		public Par X0Y0_尾30;

		public Par X0Y0_尾29;

		public Par X0Y0_尾28;

		public Par X0Y0_尾27;

		public Par X0Y0_尾26;

		public Par X0Y0_尾25;

		public Par X0Y0_尾24;

		public Par X0Y0_尾23;

		public Par X0Y0_尾22;

		public Par X0Y0_尾21;

		public Par X0Y0_尾20;

		public Par X0Y0_尾19;

		public Par X0Y0_尾18;

		public Par X0Y0_尾17;

		public Par X0Y0_尾16;

		public Par X0Y0_尾15;

		public Par X0Y0_輪2_革;

		public Par X0Y0_輪2_金具1;

		public Par X0Y0_輪2_金具2;

		public Par X0Y0_輪2_金具3;

		public Par X0Y0_輪2_金具左;

		public Par X0Y0_輪2_金具右;

		public Par X0Y0_尾14;

		public Par X0Y0_尾13;

		public Par X0Y0_尾12;

		public Par X0Y0_尾11;

		public Par X0Y0_尾10;

		public Par X0Y0_尾9;

		public Par X0Y0_尾8;

		public Par X0Y0_尾7;

		public Par X0Y0_尾6;

		public Par X0Y0_尾5;

		public Par X0Y0_尾4;

		public Par X0Y0_輪1_革;

		public Par X0Y0_輪1_金具1;

		public Par X0Y0_輪1_金具2;

		public Par X0Y0_輪1_金具3;

		public Par X0Y0_輪1_金具左;

		public Par X0Y0_輪1_金具右;

		public Par X0Y0_尾3;

		public Par X0Y0_尾2;

		public Par X0Y0_尾1;

		public Par X0Y0_尾0;

		public ColorD 尾40CD;

		public ColorD 尾39CD;

		public ColorD 尾38CD;

		public ColorD 尾37CD;

		public ColorD 尾36CD;

		public ColorD 尾35CD;

		public ColorD 尾34CD;

		public ColorD 尾33CD;

		public ColorD 尾32CD;

		public ColorD 尾31CD;

		public ColorD 尾30CD;

		public ColorD 尾29CD;

		public ColorD 尾28CD;

		public ColorD 尾27CD;

		public ColorD 尾26CD;

		public ColorD 尾25CD;

		public ColorD 尾24CD;

		public ColorD 尾23CD;

		public ColorD 尾22CD;

		public ColorD 尾21CD;

		public ColorD 尾20CD;

		public ColorD 尾19CD;

		public ColorD 尾18CD;

		public ColorD 尾17CD;

		public ColorD 尾16CD;

		public ColorD 尾15CD;

		public ColorD 尾14CD;

		public ColorD 尾13CD;

		public ColorD 尾12CD;

		public ColorD 尾11CD;

		public ColorD 尾10CD;

		public ColorD 尾9CD;

		public ColorD 尾8CD;

		public ColorD 尾7CD;

		public ColorD 尾6CD;

		public ColorD 尾5CD;

		public ColorD 尾4CD;

		public ColorD 尾3CD;

		public ColorD 尾2CD;

		public ColorD 尾1CD;

		public ColorD 尾0CD;

		public ColorD 輪1_革CD;

		public ColorD 輪1_金具1CD;

		public ColorD 輪1_金具2CD;

		public ColorD 輪1_金具3CD;

		public ColorD 輪1_金具左CD;

		public ColorD 輪1_金具右CD;

		public ColorD 輪2_革CD;

		public ColorD 輪2_金具1CD;

		public ColorD 輪2_金具2CD;

		public ColorD 輪2_金具3CD;

		public ColorD 輪2_金具左CD;

		public ColorD 輪2_金具右CD;

		public ColorP X0Y0_尾40CP;

		public ColorP X0Y0_尾39CP;

		public ColorP X0Y0_尾38CP;

		public ColorP X0Y0_尾37CP;

		public ColorP X0Y0_尾36CP;

		public ColorP X0Y0_尾35CP;

		public ColorP X0Y0_尾34CP;

		public ColorP X0Y0_尾33CP;

		public ColorP X0Y0_尾32CP;

		public ColorP X0Y0_尾31CP;

		public ColorP X0Y0_尾30CP;

		public ColorP X0Y0_尾29CP;

		public ColorP X0Y0_尾28CP;

		public ColorP X0Y0_尾27CP;

		public ColorP X0Y0_尾26CP;

		public ColorP X0Y0_尾25CP;

		public ColorP X0Y0_尾24CP;

		public ColorP X0Y0_尾23CP;

		public ColorP X0Y0_尾22CP;

		public ColorP X0Y0_尾21CP;

		public ColorP X0Y0_尾20CP;

		public ColorP X0Y0_尾19CP;

		public ColorP X0Y0_尾18CP;

		public ColorP X0Y0_尾17CP;

		public ColorP X0Y0_尾16CP;

		public ColorP X0Y0_尾15CP;

		public ColorP X0Y0_輪2_革CP;

		public ColorP X0Y0_輪2_金具1CP;

		public ColorP X0Y0_輪2_金具2CP;

		public ColorP X0Y0_輪2_金具3CP;

		public ColorP X0Y0_輪2_金具左CP;

		public ColorP X0Y0_輪2_金具右CP;

		public ColorP X0Y0_尾14CP;

		public ColorP X0Y0_尾13CP;

		public ColorP X0Y0_尾12CP;

		public ColorP X0Y0_尾11CP;

		public ColorP X0Y0_尾10CP;

		public ColorP X0Y0_尾9CP;

		public ColorP X0Y0_尾8CP;

		public ColorP X0Y0_尾7CP;

		public ColorP X0Y0_尾6CP;

		public ColorP X0Y0_尾5CP;

		public ColorP X0Y0_尾4CP;

		public ColorP X0Y0_輪1_革CP;

		public ColorP X0Y0_輪1_金具1CP;

		public ColorP X0Y0_輪1_金具2CP;

		public ColorP X0Y0_輪1_金具3CP;

		public ColorP X0Y0_輪1_金具左CP;

		public ColorP X0Y0_輪1_金具右CP;

		public ColorP X0Y0_尾3CP;

		public ColorP X0Y0_尾2CP;

		public ColorP X0Y0_尾1CP;

		public ColorP X0Y0_尾0CP;

		public 拘束鎖 鎖1;

		public 拘束鎖 鎖2;

		public 拘束鎖 鎖3;

		public 拘束鎖 鎖4;
	}
}
