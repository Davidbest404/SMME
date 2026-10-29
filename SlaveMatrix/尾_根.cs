using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 尾_根 : 尾
	{
		public 尾_根(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 尾_根D e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "根尾";
			dif.Add(new Pars(Sta.尻尾["尾"][0][22]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			Pars pars2 = pars["尾0"].ToPars();
			this.X0Y0_尾0_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾0_線1 = pars2["線1"].ToPar();
			this.X0Y0_尾0_線2 = pars2["線2"].ToPar();
			pars2 = pars["尾1"].ToPars();
			this.X0Y0_尾1_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾1_線1 = pars2["線1"].ToPar();
			this.X0Y0_尾1_線2 = pars2["線2"].ToPar();
			pars2 = pars["尾2"].ToPars();
			this.X0Y0_尾2_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾2_線1 = pars2["線1"].ToPar();
			this.X0Y0_尾2_線2 = pars2["線2"].ToPar();
			pars2 = pars["尾3"].ToPars();
			this.X0Y0_尾3_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾3_線1 = pars2["線1"].ToPar();
			this.X0Y0_尾3_線2 = pars2["線2"].ToPar();
			pars2 = pars["尾4"].ToPars();
			this.X0Y0_尾4_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾4_線1 = pars2["線1"].ToPar();
			this.X0Y0_尾4_線2 = pars2["線2"].ToPar();
			pars2 = pars["尾5"].ToPars();
			this.X0Y0_尾5_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾5_線1 = pars2["線1"].ToPar();
			this.X0Y0_尾5_線2 = pars2["線2"].ToPar();
			pars2 = pars["尾6"].ToPars();
			this.X0Y0_尾6_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾6_線1 = pars2["線1"].ToPar();
			this.X0Y0_尾6_線2 = pars2["線2"].ToPar();
			pars2 = pars["尾7"].ToPars();
			this.X0Y0_尾7_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾7_線1 = pars2["線1"].ToPar();
			this.X0Y0_尾7_線2 = pars2["線2"].ToPar();
			pars2 = pars["輪"].ToPars();
			this.X0Y0_輪_革 = pars2["革"].ToPar();
			this.X0Y0_輪_金具1 = pars2["金具1"].ToPar();
			this.X0Y0_輪_金具2 = pars2["金具2"].ToPar();
			this.X0Y0_輪_金具3 = pars2["金具3"].ToPar();
			this.X0Y0_輪_金具左 = pars2["金具左"].ToPar();
			this.X0Y0_輪_金具右 = pars2["金具右"].ToPar();
			pars2 = pars["尾8"].ToPars();
			this.X0Y0_尾8_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾8_線1 = pars2["線1"].ToPar();
			this.X0Y0_尾8_線2 = pars2["線2"].ToPar();
			pars2 = pars["尾9"].ToPars();
			this.X0Y0_尾9_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾9_線1 = pars2["線1"].ToPar();
			this.X0Y0_尾9_線2 = pars2["線2"].ToPar();
			pars2 = pars["尾10"].ToPars();
			this.X0Y0_尾10_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾10_線1 = pars2["線1"].ToPar();
			this.X0Y0_尾10_線2 = pars2["線2"].ToPar();
			pars2 = pars["尾11"].ToPars();
			this.X0Y0_尾11_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾11_線1 = pars2["線1"].ToPar();
			this.X0Y0_尾11_線2 = pars2["線2"].ToPar();
			pars2 = pars["尾12"].ToPars();
			this.X0Y0_尾12_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾12_線1 = pars2["線1"].ToPar();
			this.X0Y0_尾12_線2 = pars2["線2"].ToPar();
			pars2 = pars["尾13"].ToPars();
			this.X0Y0_尾13_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾13_線1 = pars2["線1"].ToPar();
			this.X0Y0_尾13_線2 = pars2["線2"].ToPar();
			pars2 = pars["尾14"].ToPars();
			this.X0Y0_尾14_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾14_線1 = pars2["線1"].ToPar();
			this.X0Y0_尾14_線2 = pars2["線2"].ToPar();
			pars2 = pars["尾15"].ToPars();
			this.X0Y0_尾15_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾15_線1 = pars2["線1"].ToPar();
			this.X0Y0_尾15_線2 = pars2["線2"].ToPar();
			pars2 = pars["尾16"].ToPars();
			this.X0Y0_尾16_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾16_線1 = pars2["線1"].ToPar();
			this.X0Y0_尾16_線2 = pars2["線2"].ToPar();
			pars2 = pars["尾17"].ToPars();
			this.X0Y0_尾17_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾17_線1 = pars2["線1"].ToPar();
			this.X0Y0_尾17_線2 = pars2["線2"].ToPar();
			this.X0Y0_尾18 = pars["尾18"].ToPar();
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
			this.尾0_尾_表示 = e.尾0_尾_表示;
			this.尾0_線1_表示 = e.尾0_線1_表示;
			this.尾0_線2_表示 = e.尾0_線2_表示;
			this.尾1_尾_表示 = e.尾1_尾_表示;
			this.尾1_線1_表示 = e.尾1_線1_表示;
			this.尾1_線2_表示 = e.尾1_線2_表示;
			this.尾2_尾_表示 = e.尾2_尾_表示;
			this.尾2_線1_表示 = e.尾2_線1_表示;
			this.尾2_線2_表示 = e.尾2_線2_表示;
			this.尾3_尾_表示 = e.尾3_尾_表示;
			this.尾3_線1_表示 = e.尾3_線1_表示;
			this.尾3_線2_表示 = e.尾3_線2_表示;
			this.尾4_尾_表示 = e.尾4_尾_表示;
			this.尾4_線1_表示 = e.尾4_線1_表示;
			this.尾4_線2_表示 = e.尾4_線2_表示;
			this.尾5_尾_表示 = e.尾5_尾_表示;
			this.尾5_線1_表示 = e.尾5_線1_表示;
			this.尾5_線2_表示 = e.尾5_線2_表示;
			this.尾6_尾_表示 = e.尾6_尾_表示;
			this.尾6_線1_表示 = e.尾6_線1_表示;
			this.尾6_線2_表示 = e.尾6_線2_表示;
			this.尾7_尾_表示 = e.尾7_尾_表示;
			this.尾7_線1_表示 = e.尾7_線1_表示;
			this.尾7_線2_表示 = e.尾7_線2_表示;
			this.輪_革_表示 = e.輪_革_表示;
			this.輪_金具1_表示 = e.輪_金具1_表示;
			this.輪_金具2_表示 = e.輪_金具2_表示;
			this.輪_金具3_表示 = e.輪_金具3_表示;
			this.輪_金具左_表示 = e.輪_金具左_表示;
			this.輪_金具右_表示 = e.輪_金具右_表示;
			this.尾8_尾_表示 = e.尾8_尾_表示;
			this.尾8_線1_表示 = e.尾8_線1_表示;
			this.尾8_線2_表示 = e.尾8_線2_表示;
			this.尾9_尾_表示 = e.尾9_尾_表示;
			this.尾9_線1_表示 = e.尾9_線1_表示;
			this.尾9_線2_表示 = e.尾9_線2_表示;
			this.尾10_尾_表示 = e.尾10_尾_表示;
			this.尾10_線1_表示 = e.尾10_線1_表示;
			this.尾10_線2_表示 = e.尾10_線2_表示;
			this.尾11_尾_表示 = e.尾11_尾_表示;
			this.尾11_線1_表示 = e.尾11_線1_表示;
			this.尾11_線2_表示 = e.尾11_線2_表示;
			this.尾12_尾_表示 = e.尾12_尾_表示;
			this.尾12_線1_表示 = e.尾12_線1_表示;
			this.尾12_線2_表示 = e.尾12_線2_表示;
			this.尾13_尾_表示 = e.尾13_尾_表示;
			this.尾13_線1_表示 = e.尾13_線1_表示;
			this.尾13_線2_表示 = e.尾13_線2_表示;
			this.尾14_尾_表示 = e.尾14_尾_表示;
			this.尾14_線1_表示 = e.尾14_線1_表示;
			this.尾14_線2_表示 = e.尾14_線2_表示;
			this.尾15_尾_表示 = e.尾15_尾_表示;
			this.尾15_線1_表示 = e.尾15_線1_表示;
			this.尾15_線2_表示 = e.尾15_線2_表示;
			this.尾16_尾_表示 = e.尾16_尾_表示;
			this.尾16_線1_表示 = e.尾16_線1_表示;
			this.尾16_線2_表示 = e.尾16_線2_表示;
			this.尾17_尾_表示 = e.尾17_尾_表示;
			this.尾17_線1_表示 = e.尾17_線1_表示;
			this.尾17_線2_表示 = e.尾17_線2_表示;
			this.尾18_表示 = e.尾18_表示;
			this.輪表示 = e.輪表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.Pars = new Par[]
			{
				this.X0Y0_尾0_尾,
				this.X0Y0_尾1_尾,
				this.X0Y0_尾2_尾,
				this.X0Y0_尾3_尾,
				this.X0Y0_尾4_尾,
				this.X0Y0_尾5_尾,
				this.X0Y0_尾6_尾,
				this.X0Y0_尾7_尾,
				this.X0Y0_尾8_尾,
				this.X0Y0_尾9_尾,
				this.X0Y0_尾10_尾,
				this.X0Y0_尾11_尾,
				this.X0Y0_尾12_尾,
				this.X0Y0_尾13_尾,
				this.X0Y0_尾14_尾,
				this.X0Y0_尾15_尾,
				this.X0Y0_尾16_尾,
				this.X0Y0_尾17_尾,
				this.X0Y0_尾18
			};
			this.X0Y0_尾0_尾CP = new ColorP(this.X0Y0_尾0_尾, this.尾0_尾CD, DisUnit, true);
			this.X0Y0_尾0_線1CP = new ColorP(this.X0Y0_尾0_線1, this.尾0_線1CD, DisUnit, true);
			this.X0Y0_尾0_線2CP = new ColorP(this.X0Y0_尾0_線2, this.尾0_線2CD, DisUnit, true);
			this.X0Y0_尾1_尾CP = new ColorP(this.X0Y0_尾1_尾, this.尾1_尾CD, DisUnit, true);
			this.X0Y0_尾1_線1CP = new ColorP(this.X0Y0_尾1_線1, this.尾1_線1CD, DisUnit, true);
			this.X0Y0_尾1_線2CP = new ColorP(this.X0Y0_尾1_線2, this.尾1_線2CD, DisUnit, true);
			this.X0Y0_尾2_尾CP = new ColorP(this.X0Y0_尾2_尾, this.尾2_尾CD, DisUnit, true);
			this.X0Y0_尾2_線1CP = new ColorP(this.X0Y0_尾2_線1, this.尾2_線1CD, DisUnit, true);
			this.X0Y0_尾2_線2CP = new ColorP(this.X0Y0_尾2_線2, this.尾2_線2CD, DisUnit, true);
			this.X0Y0_尾3_尾CP = new ColorP(this.X0Y0_尾3_尾, this.尾3_尾CD, DisUnit, true);
			this.X0Y0_尾3_線1CP = new ColorP(this.X0Y0_尾3_線1, this.尾3_線1CD, DisUnit, true);
			this.X0Y0_尾3_線2CP = new ColorP(this.X0Y0_尾3_線2, this.尾3_線2CD, DisUnit, true);
			this.X0Y0_尾4_尾CP = new ColorP(this.X0Y0_尾4_尾, this.尾4_尾CD, DisUnit, true);
			this.X0Y0_尾4_線1CP = new ColorP(this.X0Y0_尾4_線1, this.尾4_線1CD, DisUnit, true);
			this.X0Y0_尾4_線2CP = new ColorP(this.X0Y0_尾4_線2, this.尾4_線2CD, DisUnit, true);
			this.X0Y0_尾5_尾CP = new ColorP(this.X0Y0_尾5_尾, this.尾5_尾CD, DisUnit, true);
			this.X0Y0_尾5_線1CP = new ColorP(this.X0Y0_尾5_線1, this.尾5_線1CD, DisUnit, true);
			this.X0Y0_尾5_線2CP = new ColorP(this.X0Y0_尾5_線2, this.尾5_線2CD, DisUnit, true);
			this.X0Y0_尾6_尾CP = new ColorP(this.X0Y0_尾6_尾, this.尾6_尾CD, DisUnit, true);
			this.X0Y0_尾6_線1CP = new ColorP(this.X0Y0_尾6_線1, this.尾6_線1CD, DisUnit, true);
			this.X0Y0_尾6_線2CP = new ColorP(this.X0Y0_尾6_線2, this.尾6_線2CD, DisUnit, true);
			this.X0Y0_尾7_尾CP = new ColorP(this.X0Y0_尾7_尾, this.尾7_尾CD, DisUnit, true);
			this.X0Y0_尾7_線1CP = new ColorP(this.X0Y0_尾7_線1, this.尾7_線1CD, DisUnit, true);
			this.X0Y0_尾7_線2CP = new ColorP(this.X0Y0_尾7_線2, this.尾7_線2CD, DisUnit, true);
			this.X0Y0_輪_革CP = new ColorP(this.X0Y0_輪_革, this.輪_革CD, DisUnit, true);
			this.X0Y0_輪_金具1CP = new ColorP(this.X0Y0_輪_金具1, this.輪_金具1CD, DisUnit, true);
			this.X0Y0_輪_金具2CP = new ColorP(this.X0Y0_輪_金具2, this.輪_金具2CD, DisUnit, true);
			this.X0Y0_輪_金具3CP = new ColorP(this.X0Y0_輪_金具3, this.輪_金具3CD, DisUnit, true);
			this.X0Y0_輪_金具左CP = new ColorP(this.X0Y0_輪_金具左, this.輪_金具左CD, DisUnit, true);
			this.X0Y0_輪_金具右CP = new ColorP(this.X0Y0_輪_金具右, this.輪_金具右CD, DisUnit, true);
			this.X0Y0_尾8_尾CP = new ColorP(this.X0Y0_尾8_尾, this.尾8_尾CD, DisUnit, true);
			this.X0Y0_尾8_線1CP = new ColorP(this.X0Y0_尾8_線1, this.尾8_線1CD, DisUnit, true);
			this.X0Y0_尾8_線2CP = new ColorP(this.X0Y0_尾8_線2, this.尾8_線2CD, DisUnit, true);
			this.X0Y0_尾9_尾CP = new ColorP(this.X0Y0_尾9_尾, this.尾9_尾CD, DisUnit, true);
			this.X0Y0_尾9_線1CP = new ColorP(this.X0Y0_尾9_線1, this.尾9_線1CD, DisUnit, true);
			this.X0Y0_尾9_線2CP = new ColorP(this.X0Y0_尾9_線2, this.尾9_線2CD, DisUnit, true);
			this.X0Y0_尾10_尾CP = new ColorP(this.X0Y0_尾10_尾, this.尾10_尾CD, DisUnit, true);
			this.X0Y0_尾10_線1CP = new ColorP(this.X0Y0_尾10_線1, this.尾10_線1CD, DisUnit, true);
			this.X0Y0_尾10_線2CP = new ColorP(this.X0Y0_尾10_線2, this.尾10_線2CD, DisUnit, true);
			this.X0Y0_尾11_尾CP = new ColorP(this.X0Y0_尾11_尾, this.尾11_尾CD, DisUnit, true);
			this.X0Y0_尾11_線1CP = new ColorP(this.X0Y0_尾11_線1, this.尾11_線1CD, DisUnit, true);
			this.X0Y0_尾11_線2CP = new ColorP(this.X0Y0_尾11_線2, this.尾11_線2CD, DisUnit, true);
			this.X0Y0_尾12_尾CP = new ColorP(this.X0Y0_尾12_尾, this.尾12_尾CD, DisUnit, true);
			this.X0Y0_尾12_線1CP = new ColorP(this.X0Y0_尾12_線1, this.尾12_線1CD, DisUnit, true);
			this.X0Y0_尾12_線2CP = new ColorP(this.X0Y0_尾12_線2, this.尾12_線2CD, DisUnit, true);
			this.X0Y0_尾13_尾CP = new ColorP(this.X0Y0_尾13_尾, this.尾13_尾CD, DisUnit, true);
			this.X0Y0_尾13_線1CP = new ColorP(this.X0Y0_尾13_線1, this.尾13_線1CD, DisUnit, true);
			this.X0Y0_尾13_線2CP = new ColorP(this.X0Y0_尾13_線2, this.尾13_線2CD, DisUnit, true);
			this.X0Y0_尾14_尾CP = new ColorP(this.X0Y0_尾14_尾, this.尾14_尾CD, DisUnit, true);
			this.X0Y0_尾14_線1CP = new ColorP(this.X0Y0_尾14_線1, this.尾14_線1CD, DisUnit, true);
			this.X0Y0_尾14_線2CP = new ColorP(this.X0Y0_尾14_線2, this.尾14_線2CD, DisUnit, true);
			this.X0Y0_尾15_尾CP = new ColorP(this.X0Y0_尾15_尾, this.尾15_尾CD, DisUnit, true);
			this.X0Y0_尾15_線1CP = new ColorP(this.X0Y0_尾15_線1, this.尾15_線1CD, DisUnit, true);
			this.X0Y0_尾15_線2CP = new ColorP(this.X0Y0_尾15_線2, this.尾15_線2CD, DisUnit, true);
			this.X0Y0_尾16_尾CP = new ColorP(this.X0Y0_尾16_尾, this.尾16_尾CD, DisUnit, true);
			this.X0Y0_尾16_線1CP = new ColorP(this.X0Y0_尾16_線1, this.尾16_線1CD, DisUnit, true);
			this.X0Y0_尾16_線2CP = new ColorP(this.X0Y0_尾16_線2, this.尾16_線2CD, DisUnit, true);
			this.X0Y0_尾17_尾CP = new ColorP(this.X0Y0_尾17_尾, this.尾17_尾CD, DisUnit, true);
			this.X0Y0_尾17_線1CP = new ColorP(this.X0Y0_尾17_線1, this.尾17_線1CD, DisUnit, true);
			this.X0Y0_尾17_線2CP = new ColorP(this.X0Y0_尾17_線2, this.尾17_線2CD, DisUnit, true);
			this.X0Y0_尾18CP = new ColorP(this.X0Y0_尾18, this.尾18CD, DisUnit, true);
			this.濃度 = e.濃度;
			this.鎖1 = new 拘束鎖(DisUnit, this.右, 配色指定, 体配色, this.Xasix);
			this.鎖2 = new 拘束鎖(DisUnit, !this.右, 配色指定, 体配色, this.Xasix);
			this.鎖1.接続(this.鎖1_接続点);
			this.鎖2.接続(this.鎖2_接続点);
			int num = this.右 ? -10 : 10;
			this.鎖1.角度B -= (double)num;
			this.鎖2.角度B += (double)num;
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
				this.輪表示 = this.拘束_;
			}
		}

		public bool 尾0_尾_表示
		{
			get
			{
				return this.X0Y0_尾0_尾.Dra;
			}
			set
			{
				this.X0Y0_尾0_尾.Dra = value;
				this.X0Y0_尾0_尾.Hit = value;
			}
		}

		public bool 尾0_線1_表示
		{
			get
			{
				return this.X0Y0_尾0_線1.Dra;
			}
			set
			{
				this.X0Y0_尾0_線1.Dra = value;
				this.X0Y0_尾0_線1.Hit = value;
			}
		}

		public bool 尾0_線2_表示
		{
			get
			{
				return this.X0Y0_尾0_線2.Dra;
			}
			set
			{
				this.X0Y0_尾0_線2.Dra = value;
				this.X0Y0_尾0_線2.Hit = value;
			}
		}

		public bool 尾1_尾_表示
		{
			get
			{
				return this.X0Y0_尾1_尾.Dra;
			}
			set
			{
				this.X0Y0_尾1_尾.Dra = value;
				this.X0Y0_尾1_尾.Hit = value;
			}
		}

		public bool 尾1_線1_表示
		{
			get
			{
				return this.X0Y0_尾1_線1.Dra;
			}
			set
			{
				this.X0Y0_尾1_線1.Dra = value;
				this.X0Y0_尾1_線1.Hit = value;
			}
		}

		public bool 尾1_線2_表示
		{
			get
			{
				return this.X0Y0_尾1_線2.Dra;
			}
			set
			{
				this.X0Y0_尾1_線2.Dra = value;
				this.X0Y0_尾1_線2.Hit = value;
			}
		}

		public bool 尾2_尾_表示
		{
			get
			{
				return this.X0Y0_尾2_尾.Dra;
			}
			set
			{
				this.X0Y0_尾2_尾.Dra = value;
				this.X0Y0_尾2_尾.Hit = value;
			}
		}

		public bool 尾2_線1_表示
		{
			get
			{
				return this.X0Y0_尾2_線1.Dra;
			}
			set
			{
				this.X0Y0_尾2_線1.Dra = value;
				this.X0Y0_尾2_線1.Hit = value;
			}
		}

		public bool 尾2_線2_表示
		{
			get
			{
				return this.X0Y0_尾2_線2.Dra;
			}
			set
			{
				this.X0Y0_尾2_線2.Dra = value;
				this.X0Y0_尾2_線2.Hit = value;
			}
		}

		public bool 尾3_尾_表示
		{
			get
			{
				return this.X0Y0_尾3_尾.Dra;
			}
			set
			{
				this.X0Y0_尾3_尾.Dra = value;
				this.X0Y0_尾3_尾.Hit = value;
			}
		}

		public bool 尾3_線1_表示
		{
			get
			{
				return this.X0Y0_尾3_線1.Dra;
			}
			set
			{
				this.X0Y0_尾3_線1.Dra = value;
				this.X0Y0_尾3_線1.Hit = value;
			}
		}

		public bool 尾3_線2_表示
		{
			get
			{
				return this.X0Y0_尾3_線2.Dra;
			}
			set
			{
				this.X0Y0_尾3_線2.Dra = value;
				this.X0Y0_尾3_線2.Hit = value;
			}
		}

		public bool 尾4_尾_表示
		{
			get
			{
				return this.X0Y0_尾4_尾.Dra;
			}
			set
			{
				this.X0Y0_尾4_尾.Dra = value;
				this.X0Y0_尾4_尾.Hit = value;
			}
		}

		public bool 尾4_線1_表示
		{
			get
			{
				return this.X0Y0_尾4_線1.Dra;
			}
			set
			{
				this.X0Y0_尾4_線1.Dra = value;
				this.X0Y0_尾4_線1.Hit = value;
			}
		}

		public bool 尾4_線2_表示
		{
			get
			{
				return this.X0Y0_尾4_線2.Dra;
			}
			set
			{
				this.X0Y0_尾4_線2.Dra = value;
				this.X0Y0_尾4_線2.Hit = value;
			}
		}

		public bool 尾5_尾_表示
		{
			get
			{
				return this.X0Y0_尾5_尾.Dra;
			}
			set
			{
				this.X0Y0_尾5_尾.Dra = value;
				this.X0Y0_尾5_尾.Hit = value;
			}
		}

		public bool 尾5_線1_表示
		{
			get
			{
				return this.X0Y0_尾5_線1.Dra;
			}
			set
			{
				this.X0Y0_尾5_線1.Dra = value;
				this.X0Y0_尾5_線1.Hit = value;
			}
		}

		public bool 尾5_線2_表示
		{
			get
			{
				return this.X0Y0_尾5_線2.Dra;
			}
			set
			{
				this.X0Y0_尾5_線2.Dra = value;
				this.X0Y0_尾5_線2.Hit = value;
			}
		}

		public bool 尾6_尾_表示
		{
			get
			{
				return this.X0Y0_尾6_尾.Dra;
			}
			set
			{
				this.X0Y0_尾6_尾.Dra = value;
				this.X0Y0_尾6_尾.Hit = value;
			}
		}

		public bool 尾6_線1_表示
		{
			get
			{
				return this.X0Y0_尾6_線1.Dra;
			}
			set
			{
				this.X0Y0_尾6_線1.Dra = value;
				this.X0Y0_尾6_線1.Hit = value;
			}
		}

		public bool 尾6_線2_表示
		{
			get
			{
				return this.X0Y0_尾6_線2.Dra;
			}
			set
			{
				this.X0Y0_尾6_線2.Dra = value;
				this.X0Y0_尾6_線2.Hit = value;
			}
		}

		public bool 尾7_尾_表示
		{
			get
			{
				return this.X0Y0_尾7_尾.Dra;
			}
			set
			{
				this.X0Y0_尾7_尾.Dra = value;
				this.X0Y0_尾7_尾.Hit = value;
			}
		}

		public bool 尾7_線1_表示
		{
			get
			{
				return this.X0Y0_尾7_線1.Dra;
			}
			set
			{
				this.X0Y0_尾7_線1.Dra = value;
				this.X0Y0_尾7_線1.Hit = value;
			}
		}

		public bool 尾7_線2_表示
		{
			get
			{
				return this.X0Y0_尾7_線2.Dra;
			}
			set
			{
				this.X0Y0_尾7_線2.Dra = value;
				this.X0Y0_尾7_線2.Hit = value;
			}
		}

		public bool 輪_革_表示
		{
			get
			{
				return this.X0Y0_輪_革.Dra;
			}
			set
			{
				this.X0Y0_輪_革.Dra = value;
				this.X0Y0_輪_革.Hit = value;
			}
		}

		public bool 輪_金具1_表示
		{
			get
			{
				return this.X0Y0_輪_金具1.Dra;
			}
			set
			{
				this.X0Y0_輪_金具1.Dra = value;
				this.X0Y0_輪_金具1.Hit = value;
			}
		}

		public bool 輪_金具2_表示
		{
			get
			{
				return this.X0Y0_輪_金具2.Dra;
			}
			set
			{
				this.X0Y0_輪_金具2.Dra = value;
				this.X0Y0_輪_金具2.Hit = value;
			}
		}

		public bool 輪_金具3_表示
		{
			get
			{
				return this.X0Y0_輪_金具3.Dra;
			}
			set
			{
				this.X0Y0_輪_金具3.Dra = value;
				this.X0Y0_輪_金具3.Hit = value;
			}
		}

		public bool 輪_金具左_表示
		{
			get
			{
				return this.X0Y0_輪_金具左.Dra;
			}
			set
			{
				this.X0Y0_輪_金具左.Dra = value;
				this.X0Y0_輪_金具左.Hit = value;
			}
		}

		public bool 輪_金具右_表示
		{
			get
			{
				return this.X0Y0_輪_金具右.Dra;
			}
			set
			{
				this.X0Y0_輪_金具右.Dra = value;
				this.X0Y0_輪_金具右.Hit = value;
			}
		}

		public bool 尾8_尾_表示
		{
			get
			{
				return this.X0Y0_尾8_尾.Dra;
			}
			set
			{
				this.X0Y0_尾8_尾.Dra = value;
				this.X0Y0_尾8_尾.Hit = value;
			}
		}

		public bool 尾8_線1_表示
		{
			get
			{
				return this.X0Y0_尾8_線1.Dra;
			}
			set
			{
				this.X0Y0_尾8_線1.Dra = value;
				this.X0Y0_尾8_線1.Hit = value;
			}
		}

		public bool 尾8_線2_表示
		{
			get
			{
				return this.X0Y0_尾8_線2.Dra;
			}
			set
			{
				this.X0Y0_尾8_線2.Dra = value;
				this.X0Y0_尾8_線2.Hit = value;
			}
		}

		public bool 尾9_尾_表示
		{
			get
			{
				return this.X0Y0_尾9_尾.Dra;
			}
			set
			{
				this.X0Y0_尾9_尾.Dra = value;
				this.X0Y0_尾9_尾.Hit = value;
			}
		}

		public bool 尾9_線1_表示
		{
			get
			{
				return this.X0Y0_尾9_線1.Dra;
			}
			set
			{
				this.X0Y0_尾9_線1.Dra = value;
				this.X0Y0_尾9_線1.Hit = value;
			}
		}

		public bool 尾9_線2_表示
		{
			get
			{
				return this.X0Y0_尾9_線2.Dra;
			}
			set
			{
				this.X0Y0_尾9_線2.Dra = value;
				this.X0Y0_尾9_線2.Hit = value;
			}
		}

		public bool 尾10_尾_表示
		{
			get
			{
				return this.X0Y0_尾10_尾.Dra;
			}
			set
			{
				this.X0Y0_尾10_尾.Dra = value;
				this.X0Y0_尾10_尾.Hit = value;
			}
		}

		public bool 尾10_線1_表示
		{
			get
			{
				return this.X0Y0_尾10_線1.Dra;
			}
			set
			{
				this.X0Y0_尾10_線1.Dra = value;
				this.X0Y0_尾10_線1.Hit = value;
			}
		}

		public bool 尾10_線2_表示
		{
			get
			{
				return this.X0Y0_尾10_線2.Dra;
			}
			set
			{
				this.X0Y0_尾10_線2.Dra = value;
				this.X0Y0_尾10_線2.Hit = value;
			}
		}

		public bool 尾11_尾_表示
		{
			get
			{
				return this.X0Y0_尾11_尾.Dra;
			}
			set
			{
				this.X0Y0_尾11_尾.Dra = value;
				this.X0Y0_尾11_尾.Hit = value;
			}
		}

		public bool 尾11_線1_表示
		{
			get
			{
				return this.X0Y0_尾11_線1.Dra;
			}
			set
			{
				this.X0Y0_尾11_線1.Dra = value;
				this.X0Y0_尾11_線1.Hit = value;
			}
		}

		public bool 尾11_線2_表示
		{
			get
			{
				return this.X0Y0_尾11_線2.Dra;
			}
			set
			{
				this.X0Y0_尾11_線2.Dra = value;
				this.X0Y0_尾11_線2.Hit = value;
			}
		}

		public bool 尾12_尾_表示
		{
			get
			{
				return this.X0Y0_尾12_尾.Dra;
			}
			set
			{
				this.X0Y0_尾12_尾.Dra = value;
				this.X0Y0_尾12_尾.Hit = value;
			}
		}

		public bool 尾12_線1_表示
		{
			get
			{
				return this.X0Y0_尾12_線1.Dra;
			}
			set
			{
				this.X0Y0_尾12_線1.Dra = value;
				this.X0Y0_尾12_線1.Hit = value;
			}
		}

		public bool 尾12_線2_表示
		{
			get
			{
				return this.X0Y0_尾12_線2.Dra;
			}
			set
			{
				this.X0Y0_尾12_線2.Dra = value;
				this.X0Y0_尾12_線2.Hit = value;
			}
		}

		public bool 尾13_尾_表示
		{
			get
			{
				return this.X0Y0_尾13_尾.Dra;
			}
			set
			{
				this.X0Y0_尾13_尾.Dra = value;
				this.X0Y0_尾13_尾.Hit = value;
			}
		}

		public bool 尾13_線1_表示
		{
			get
			{
				return this.X0Y0_尾13_線1.Dra;
			}
			set
			{
				this.X0Y0_尾13_線1.Dra = value;
				this.X0Y0_尾13_線1.Hit = value;
			}
		}

		public bool 尾13_線2_表示
		{
			get
			{
				return this.X0Y0_尾13_線2.Dra;
			}
			set
			{
				this.X0Y0_尾13_線2.Dra = value;
				this.X0Y0_尾13_線2.Hit = value;
			}
		}

		public bool 尾14_尾_表示
		{
			get
			{
				return this.X0Y0_尾14_尾.Dra;
			}
			set
			{
				this.X0Y0_尾14_尾.Dra = value;
				this.X0Y0_尾14_尾.Hit = value;
			}
		}

		public bool 尾14_線1_表示
		{
			get
			{
				return this.X0Y0_尾14_線1.Dra;
			}
			set
			{
				this.X0Y0_尾14_線1.Dra = value;
				this.X0Y0_尾14_線1.Hit = value;
			}
		}

		public bool 尾14_線2_表示
		{
			get
			{
				return this.X0Y0_尾14_線2.Dra;
			}
			set
			{
				this.X0Y0_尾14_線2.Dra = value;
				this.X0Y0_尾14_線2.Hit = value;
			}
		}

		public bool 尾15_尾_表示
		{
			get
			{
				return this.X0Y0_尾15_尾.Dra;
			}
			set
			{
				this.X0Y0_尾15_尾.Dra = value;
				this.X0Y0_尾15_尾.Hit = value;
			}
		}

		public bool 尾15_線1_表示
		{
			get
			{
				return this.X0Y0_尾15_線1.Dra;
			}
			set
			{
				this.X0Y0_尾15_線1.Dra = value;
				this.X0Y0_尾15_線1.Hit = value;
			}
		}

		public bool 尾15_線2_表示
		{
			get
			{
				return this.X0Y0_尾15_線2.Dra;
			}
			set
			{
				this.X0Y0_尾15_線2.Dra = value;
				this.X0Y0_尾15_線2.Hit = value;
			}
		}

		public bool 尾16_尾_表示
		{
			get
			{
				return this.X0Y0_尾16_尾.Dra;
			}
			set
			{
				this.X0Y0_尾16_尾.Dra = value;
				this.X0Y0_尾16_尾.Hit = value;
			}
		}

		public bool 尾16_線1_表示
		{
			get
			{
				return this.X0Y0_尾16_線1.Dra;
			}
			set
			{
				this.X0Y0_尾16_線1.Dra = value;
				this.X0Y0_尾16_線1.Hit = value;
			}
		}

		public bool 尾16_線2_表示
		{
			get
			{
				return this.X0Y0_尾16_線2.Dra;
			}
			set
			{
				this.X0Y0_尾16_線2.Dra = value;
				this.X0Y0_尾16_線2.Hit = value;
			}
		}

		public bool 尾17_尾_表示
		{
			get
			{
				return this.X0Y0_尾17_尾.Dra;
			}
			set
			{
				this.X0Y0_尾17_尾.Dra = value;
				this.X0Y0_尾17_尾.Hit = value;
			}
		}

		public bool 尾17_線1_表示
		{
			get
			{
				return this.X0Y0_尾17_線1.Dra;
			}
			set
			{
				this.X0Y0_尾17_線1.Dra = value;
				this.X0Y0_尾17_線1.Hit = value;
			}
		}

		public bool 尾17_線2_表示
		{
			get
			{
				return this.X0Y0_尾17_線2.Dra;
			}
			set
			{
				this.X0Y0_尾17_線2.Dra = value;
				this.X0Y0_尾17_線2.Hit = value;
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

		public bool 輪表示
		{
			get
			{
				return this.輪_革_表示;
			}
			set
			{
				this.輪_革_表示 = value;
				this.輪_金具1_表示 = value;
				this.輪_金具2_表示 = value;
				this.輪_金具3_表示 = value;
				this.輪_金具左_表示 = value;
				this.輪_金具右_表示 = value;
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
			}
		}

		public override bool 表示
		{
			get
			{
				return this.尾0_尾_表示;
			}
			set
			{
				this.尾0_尾_表示 = value;
				this.尾0_線1_表示 = value;
				this.尾0_線2_表示 = value;
				this.尾1_尾_表示 = value;
				this.尾1_線1_表示 = value;
				this.尾1_線2_表示 = value;
				this.尾2_尾_表示 = value;
				this.尾2_線1_表示 = value;
				this.尾2_線2_表示 = value;
				this.尾3_尾_表示 = value;
				this.尾3_線1_表示 = value;
				this.尾3_線2_表示 = value;
				this.尾4_尾_表示 = value;
				this.尾4_線1_表示 = value;
				this.尾4_線2_表示 = value;
				this.尾5_尾_表示 = value;
				this.尾5_線1_表示 = value;
				this.尾5_線2_表示 = value;
				this.尾6_尾_表示 = value;
				this.尾6_線1_表示 = value;
				this.尾6_線2_表示 = value;
				this.尾7_尾_表示 = value;
				this.尾7_線1_表示 = value;
				this.尾7_線2_表示 = value;
				this.輪_革_表示 = value;
				this.輪_金具1_表示 = value;
				this.輪_金具2_表示 = value;
				this.輪_金具3_表示 = value;
				this.輪_金具左_表示 = value;
				this.輪_金具右_表示 = value;
				this.尾8_尾_表示 = value;
				this.尾8_線1_表示 = value;
				this.尾8_線2_表示 = value;
				this.尾9_尾_表示 = value;
				this.尾9_線1_表示 = value;
				this.尾9_線2_表示 = value;
				this.尾10_尾_表示 = value;
				this.尾10_線1_表示 = value;
				this.尾10_線2_表示 = value;
				this.尾11_尾_表示 = value;
				this.尾11_線1_表示 = value;
				this.尾11_線2_表示 = value;
				this.尾12_尾_表示 = value;
				this.尾12_線1_表示 = value;
				this.尾12_線2_表示 = value;
				this.尾13_尾_表示 = value;
				this.尾13_線1_表示 = value;
				this.尾13_線2_表示 = value;
				this.尾14_尾_表示 = value;
				this.尾14_線1_表示 = value;
				this.尾14_線2_表示 = value;
				this.尾15_尾_表示 = value;
				this.尾15_線1_表示 = value;
				this.尾15_線2_表示 = value;
				this.尾16_尾_表示 = value;
				this.尾16_線1_表示 = value;
				this.尾16_線2_表示 = value;
				this.尾17_尾_表示 = value;
				this.尾17_線1_表示 = value;
				this.尾17_線2_表示 = value;
				this.尾18_表示 = value;
				this.鎖1.表示 = value;
				this.鎖2.表示 = value;
			}
		}

		public override void 描画0(Are Are)
		{
			Are.Draw(this.X0Y0_尾0_尾);
			Are.Draw(this.X0Y0_尾0_線1);
			Are.Draw(this.X0Y0_尾0_線2);
			Are.Draw(this.X0Y0_尾1_尾);
			Are.Draw(this.X0Y0_尾1_線1);
			Are.Draw(this.X0Y0_尾1_線2);
			Are.Draw(this.X0Y0_尾2_尾);
			Are.Draw(this.X0Y0_尾2_線1);
			Are.Draw(this.X0Y0_尾2_線2);
			Are.Draw(this.X0Y0_尾3_尾);
			Are.Draw(this.X0Y0_尾3_線1);
			Are.Draw(this.X0Y0_尾3_線2);
			Are.Draw(this.X0Y0_尾4_尾);
			Are.Draw(this.X0Y0_尾4_線1);
			Are.Draw(this.X0Y0_尾4_線2);
			Are.Draw(this.X0Y0_尾5_尾);
			Are.Draw(this.X0Y0_尾5_線1);
			Are.Draw(this.X0Y0_尾5_線2);
			Are.Draw(this.X0Y0_尾6_尾);
			Are.Draw(this.X0Y0_尾6_線1);
			Are.Draw(this.X0Y0_尾6_線2);
			Are.Draw(this.X0Y0_尾7_尾);
			Are.Draw(this.X0Y0_尾7_線1);
			Are.Draw(this.X0Y0_尾7_線2);
			Are.Draw(this.X0Y0_輪_革);
			Are.Draw(this.X0Y0_輪_金具1);
			Are.Draw(this.X0Y0_輪_金具2);
			Are.Draw(this.X0Y0_輪_金具3);
			Are.Draw(this.X0Y0_輪_金具左);
			Are.Draw(this.X0Y0_輪_金具右);
			this.鎖1.描画0(Are);
			this.鎖2.描画0(Are);
			Are.Draw(this.X0Y0_尾8_尾);
			Are.Draw(this.X0Y0_尾8_線1);
			Are.Draw(this.X0Y0_尾8_線2);
			Are.Draw(this.X0Y0_尾9_尾);
			Are.Draw(this.X0Y0_尾9_線1);
			Are.Draw(this.X0Y0_尾9_線2);
			Are.Draw(this.X0Y0_尾10_尾);
			Are.Draw(this.X0Y0_尾10_線1);
			Are.Draw(this.X0Y0_尾10_線2);
			Are.Draw(this.X0Y0_尾11_尾);
			Are.Draw(this.X0Y0_尾11_線1);
			Are.Draw(this.X0Y0_尾11_線2);
			Are.Draw(this.X0Y0_尾12_尾);
			Are.Draw(this.X0Y0_尾12_線1);
			Are.Draw(this.X0Y0_尾12_線2);
			Are.Draw(this.X0Y0_尾13_尾);
			Are.Draw(this.X0Y0_尾13_線1);
			Are.Draw(this.X0Y0_尾13_線2);
			Are.Draw(this.X0Y0_尾14_尾);
			Are.Draw(this.X0Y0_尾14_線1);
			Are.Draw(this.X0Y0_尾14_線2);
			Are.Draw(this.X0Y0_尾15_尾);
			Are.Draw(this.X0Y0_尾15_線1);
			Are.Draw(this.X0Y0_尾15_線2);
			Are.Draw(this.X0Y0_尾16_尾);
			Are.Draw(this.X0Y0_尾16_線1);
			Are.Draw(this.X0Y0_尾16_線2);
			Are.Draw(this.X0Y0_尾17_尾);
			Are.Draw(this.X0Y0_尾17_線1);
			Are.Draw(this.X0Y0_尾17_線2);
			Are.Draw(this.X0Y0_尾18);
		}

		public override void Dispose()
		{
			base.Dispose();
			this.鎖1.Dispose();
			this.鎖2.Dispose();
		}

		public override double 濃度
		{
			get
			{
				return this.尾0_尾CD.不透明度;
			}
			set
			{
				this.尾0_尾CD.不透明度 = value;
				this.尾0_線1CD.不透明度 = value;
				this.尾0_線2CD.不透明度 = value;
				this.尾1_尾CD.不透明度 = value;
				this.尾1_線1CD.不透明度 = value;
				this.尾1_線2CD.不透明度 = value;
				this.尾2_尾CD.不透明度 = value;
				this.尾2_線1CD.不透明度 = value;
				this.尾2_線2CD.不透明度 = value;
				this.尾3_尾CD.不透明度 = value;
				this.尾3_線1CD.不透明度 = value;
				this.尾3_線2CD.不透明度 = value;
				this.尾4_尾CD.不透明度 = value;
				this.尾4_線1CD.不透明度 = value;
				this.尾4_線2CD.不透明度 = value;
				this.尾5_尾CD.不透明度 = value;
				this.尾5_線1CD.不透明度 = value;
				this.尾5_線2CD.不透明度 = value;
				this.尾6_尾CD.不透明度 = value;
				this.尾6_線1CD.不透明度 = value;
				this.尾6_線2CD.不透明度 = value;
				this.尾7_尾CD.不透明度 = value;
				this.尾7_線1CD.不透明度 = value;
				this.尾7_線2CD.不透明度 = value;
				this.尾8_尾CD.不透明度 = value;
				this.尾8_線1CD.不透明度 = value;
				this.尾8_線2CD.不透明度 = value;
				this.尾9_尾CD.不透明度 = value;
				this.尾9_線1CD.不透明度 = value;
				this.尾9_線2CD.不透明度 = value;
				this.尾10_尾CD.不透明度 = value;
				this.尾10_線1CD.不透明度 = value;
				this.尾10_線2CD.不透明度 = value;
				this.尾11_尾CD.不透明度 = value;
				this.尾11_線1CD.不透明度 = value;
				this.尾11_線2CD.不透明度 = value;
				this.尾12_尾CD.不透明度 = value;
				this.尾12_線1CD.不透明度 = value;
				this.尾12_線2CD.不透明度 = value;
				this.尾13_尾CD.不透明度 = value;
				this.尾13_線1CD.不透明度 = value;
				this.尾13_線2CD.不透明度 = value;
				this.尾14_尾CD.不透明度 = value;
				this.尾14_線1CD.不透明度 = value;
				this.尾14_線2CD.不透明度 = value;
				this.尾15_尾CD.不透明度 = value;
				this.尾15_線1CD.不透明度 = value;
				this.尾15_線2CD.不透明度 = value;
				this.尾16_尾CD.不透明度 = value;
				this.尾16_線1CD.不透明度 = value;
				this.尾16_線2CD.不透明度 = value;
				this.尾17_尾CD.不透明度 = value;
				this.尾17_線1CD.不透明度 = value;
				this.尾17_線2CD.不透明度 = value;
				this.尾18CD.不透明度 = value;
				this.輪_革CD.不透明度 = value;
				this.輪_金具1CD.不透明度 = value;
				this.輪_金具2CD.不透明度 = value;
				this.輪_金具3CD.不透明度 = value;
				this.輪_金具左CD.不透明度 = value;
				this.輪_金具右CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			bool 右 = this.右;
			double maxAngle = 20.0;
			this.X0Y0_尾0_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾1_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾2_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾3_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾4_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾5_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾6_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾7_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾8_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾9_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾10_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾11_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾12_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾13_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾14_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾15_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾16_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾17_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾18.AngleBase = maxAngle.GetRanAngle();
			this.本体.JoinPAall();
		}

		public override bool Is革(Par p)
		{
			return p == this.X0Y0_輪_革 || p == this.X0Y0_輪_金具1 || p == this.X0Y0_輪_金具2 || p == this.X0Y0_輪_金具3 || p == this.X0Y0_輪_金具左 || p == this.X0Y0_輪_金具右;
		}

		public override IEnumerable<Par> Enum軸()
		{
			yield return this.X0Y0_尾0_尾;
			yield return this.X0Y0_尾1_尾;
			yield return this.X0Y0_尾2_尾;
			yield return this.X0Y0_尾3_尾;
			yield return this.X0Y0_尾4_尾;
			yield return this.X0Y0_尾5_尾;
			yield return this.X0Y0_尾6_尾;
			yield return this.X0Y0_尾7_尾;
			yield return this.X0Y0_尾8_尾;
			yield return this.X0Y0_尾9_尾;
			yield return this.X0Y0_尾10_尾;
			yield return this.X0Y0_尾11_尾;
			yield return this.X0Y0_尾12_尾;
			yield return this.X0Y0_尾13_尾;
			yield return this.X0Y0_尾14_尾;
			yield return this.X0Y0_尾15_尾;
			yield return this.X0Y0_尾16_尾;
			yield return this.X0Y0_尾17_尾;
			yield return this.X0Y0_尾18;
			yield break;
		}

		public JointS 鎖1_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_輪_金具左, 0);
			}
		}

		public JointS 鎖2_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_輪_金具右, 0);
			}
		}

		public override void 色更新()
		{
			this.Pars.GetMiY_MaY(out this.mm);
			this.X0Y0_尾0_尾CP.Update(this.mm);
			this.X0Y0_尾0_線1CP.Update();
			this.X0Y0_尾0_線2CP.Update();
			this.X0Y0_尾1_尾CP.Update(this.mm);
			this.X0Y0_尾1_線1CP.Update();
			this.X0Y0_尾1_線2CP.Update();
			this.X0Y0_尾2_尾CP.Update(this.mm);
			this.X0Y0_尾2_線1CP.Update();
			this.X0Y0_尾2_線2CP.Update();
			this.X0Y0_尾3_尾CP.Update(this.mm);
			this.X0Y0_尾3_線1CP.Update();
			this.X0Y0_尾3_線2CP.Update();
			this.X0Y0_尾4_尾CP.Update(this.mm);
			this.X0Y0_尾4_線1CP.Update();
			this.X0Y0_尾4_線2CP.Update();
			this.X0Y0_尾5_尾CP.Update(this.mm);
			this.X0Y0_尾5_線1CP.Update();
			this.X0Y0_尾5_線2CP.Update();
			this.X0Y0_尾6_尾CP.Update(this.mm);
			this.X0Y0_尾6_線1CP.Update();
			this.X0Y0_尾6_線2CP.Update();
			this.X0Y0_尾7_尾CP.Update(this.mm);
			this.X0Y0_尾7_線1CP.Update();
			this.X0Y0_尾7_線2CP.Update();
			this.X0Y0_輪_革CP.Update();
			this.X0Y0_輪_金具1CP.Update();
			this.X0Y0_輪_金具2CP.Update();
			this.X0Y0_輪_金具3CP.Update();
			this.X0Y0_輪_金具左CP.Update();
			this.X0Y0_輪_金具右CP.Update();
			this.X0Y0_尾8_尾CP.Update(this.mm);
			this.X0Y0_尾8_線1CP.Update();
			this.X0Y0_尾8_線2CP.Update();
			this.X0Y0_尾9_尾CP.Update(this.mm);
			this.X0Y0_尾9_線1CP.Update();
			this.X0Y0_尾9_線2CP.Update();
			this.X0Y0_尾10_尾CP.Update(this.mm);
			this.X0Y0_尾10_線1CP.Update();
			this.X0Y0_尾10_線2CP.Update();
			this.X0Y0_尾11_尾CP.Update(this.mm);
			this.X0Y0_尾11_線1CP.Update();
			this.X0Y0_尾11_線2CP.Update();
			this.X0Y0_尾12_尾CP.Update(this.mm);
			this.X0Y0_尾12_線1CP.Update();
			this.X0Y0_尾12_線2CP.Update();
			this.X0Y0_尾13_尾CP.Update(this.mm);
			this.X0Y0_尾13_線1CP.Update();
			this.X0Y0_尾13_線2CP.Update();
			this.X0Y0_尾14_尾CP.Update(this.mm);
			this.X0Y0_尾14_線1CP.Update();
			this.X0Y0_尾14_線2CP.Update();
			this.X0Y0_尾15_尾CP.Update(this.mm);
			this.X0Y0_尾15_線1CP.Update();
			this.X0Y0_尾15_線2CP.Update();
			this.X0Y0_尾16_尾CP.Update(this.mm);
			this.X0Y0_尾16_線1CP.Update();
			this.X0Y0_尾16_線2CP.Update();
			this.X0Y0_尾17_尾CP.Update(this.mm);
			this.X0Y0_尾17_線1CP.Update();
			this.X0Y0_尾17_線2CP.Update();
			this.X0Y0_尾18CP.Update(this.mm);
			this.鎖1.接続PA();
			this.鎖2.接続PA();
			this.鎖1.色更新();
			this.鎖2.色更新();
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
			this.尾0_尾CD = new ColorD(ref Col.Black, ref 体配色.植0R);
			this.尾0_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾0_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾1_尾CD = new ColorD(ref Col.Black, ref 体配色.植0R);
			this.尾1_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾1_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾2_尾CD = new ColorD(ref Col.Black, ref 体配色.植0R);
			this.尾2_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾2_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾3_尾CD = new ColorD(ref Col.Black, ref 体配色.植0R);
			this.尾3_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾3_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾4_尾CD = new ColorD(ref Col.Black, ref 体配色.植0R);
			this.尾4_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾4_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾5_尾CD = new ColorD(ref Col.Black, ref 体配色.植0R);
			this.尾5_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾5_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾6_尾CD = new ColorD(ref Col.Black, ref 体配色.植0R);
			this.尾6_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾6_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾7_尾CD = new ColorD(ref Col.Black, ref 体配色.植0R);
			this.尾7_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾7_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾8_尾CD = new ColorD(ref Col.Black, ref 体配色.植0R);
			this.尾8_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾8_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾9_尾CD = new ColorD(ref Col.Black, ref 体配色.植0R);
			this.尾9_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾9_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾10_尾CD = new ColorD(ref Col.Black, ref 体配色.植0R);
			this.尾10_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾10_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾11_尾CD = new ColorD(ref Col.Black, ref 体配色.植0R);
			this.尾11_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾11_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾12_尾CD = new ColorD(ref Col.Black, ref 体配色.植0R);
			this.尾12_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾12_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾13_尾CD = new ColorD(ref Col.Black, ref 体配色.植0R);
			this.尾13_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾13_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾14_尾CD = new ColorD(ref Col.Black, ref 体配色.植0R);
			this.尾14_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾14_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾15_尾CD = new ColorD(ref Col.Black, ref 体配色.植0R);
			this.尾15_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾15_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾16_尾CD = new ColorD(ref Col.Black, ref 体配色.植0R);
			this.尾16_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾16_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾17_尾CD = new ColorD(ref Col.Black, ref 体配色.植0R);
			this.尾17_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾17_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾18CD = new ColorD(ref Col.Black, ref 体配色.植0R);
			this.輪_革CD = new ColorD();
			this.輪_金具1CD = new ColorD();
			this.輪_金具2CD = new ColorD();
			this.輪_金具3CD = new ColorD();
			this.輪_金具左CD = new ColorD();
			this.輪_金具右CD = new ColorD();
		}

		private void 配色T0(体配色 体配色)
		{
			this.配色T(0, "尾", ref 体配色.植0R, ref 体配色.刺青R);
			this.尾0_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾0_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾1_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾1_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾2_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾2_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾3_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾3_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾4_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾4_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾5_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾5_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾6_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾6_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾7_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾7_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾8_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾8_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾9_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾9_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾10_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾10_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾11_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾11_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾12_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾12_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾13_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾13_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾14_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾14_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾15_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾15_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾16_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾16_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾17_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾17_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.輪_革CD = new ColorD();
			this.輪_金具1CD = new ColorD();
			this.輪_金具2CD = new ColorD();
			this.輪_金具3CD = new ColorD();
			this.輪_金具左CD = new ColorD();
			this.輪_金具右CD = new ColorD();
		}

		private void 配色T1(体配色 体配色)
		{
			this.配色T(1, "尾", ref 体配色.植0R, ref 体配色.刺青R);
			this.尾0_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾0_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾1_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾1_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾2_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾2_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾3_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾3_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾4_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾4_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾5_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾5_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾6_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾6_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾7_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾7_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾8_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾8_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾9_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾9_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾10_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾10_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾11_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾11_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾12_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾12_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾13_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾13_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾14_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾14_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾15_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾15_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾16_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾16_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾17_線1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.尾17_線2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.輪_革CD = new ColorD();
			this.輪_金具1CD = new ColorD();
			this.輪_金具2CD = new ColorD();
			this.輪_金具3CD = new ColorD();
			this.輪_金具左CD = new ColorD();
			this.輪_金具右CD = new ColorD();
		}

		public void 輪配色(拘束具色 配色)
		{
			this.輪_革CD.色 = 配色.革部色;
			this.輪_金具1CD.色 = 配色.金具色;
			this.輪_金具2CD.色 = this.輪_金具1CD.色;
			this.輪_金具3CD.色 = this.輪_金具1CD.色;
			this.輪_金具左CD.色 = this.輪_金具1CD.色;
			this.輪_金具右CD.色 = this.輪_金具1CD.色;
		}

		public void 鎖配色(鎖色 配色)
		{
			this.鎖1.配色鎖(配色);
			this.鎖2.配色鎖(配色);
		}

		public Par X0Y0_尾0_尾;

		public Par X0Y0_尾0_線1;

		public Par X0Y0_尾0_線2;

		public Par X0Y0_尾1_尾;

		public Par X0Y0_尾1_線1;

		public Par X0Y0_尾1_線2;

		public Par X0Y0_尾2_尾;

		public Par X0Y0_尾2_線1;

		public Par X0Y0_尾2_線2;

		public Par X0Y0_尾3_尾;

		public Par X0Y0_尾3_線1;

		public Par X0Y0_尾3_線2;

		public Par X0Y0_尾4_尾;

		public Par X0Y0_尾4_線1;

		public Par X0Y0_尾4_線2;

		public Par X0Y0_尾5_尾;

		public Par X0Y0_尾5_線1;

		public Par X0Y0_尾5_線2;

		public Par X0Y0_尾6_尾;

		public Par X0Y0_尾6_線1;

		public Par X0Y0_尾6_線2;

		public Par X0Y0_尾7_尾;

		public Par X0Y0_尾7_線1;

		public Par X0Y0_尾7_線2;

		public Par X0Y0_輪_革;

		public Par X0Y0_輪_金具1;

		public Par X0Y0_輪_金具2;

		public Par X0Y0_輪_金具3;

		public Par X0Y0_輪_金具左;

		public Par X0Y0_輪_金具右;

		public Par X0Y0_尾8_尾;

		public Par X0Y0_尾8_線1;

		public Par X0Y0_尾8_線2;

		public Par X0Y0_尾9_尾;

		public Par X0Y0_尾9_線1;

		public Par X0Y0_尾9_線2;

		public Par X0Y0_尾10_尾;

		public Par X0Y0_尾10_線1;

		public Par X0Y0_尾10_線2;

		public Par X0Y0_尾11_尾;

		public Par X0Y0_尾11_線1;

		public Par X0Y0_尾11_線2;

		public Par X0Y0_尾12_尾;

		public Par X0Y0_尾12_線1;

		public Par X0Y0_尾12_線2;

		public Par X0Y0_尾13_尾;

		public Par X0Y0_尾13_線1;

		public Par X0Y0_尾13_線2;

		public Par X0Y0_尾14_尾;

		public Par X0Y0_尾14_線1;

		public Par X0Y0_尾14_線2;

		public Par X0Y0_尾15_尾;

		public Par X0Y0_尾15_線1;

		public Par X0Y0_尾15_線2;

		public Par X0Y0_尾16_尾;

		public Par X0Y0_尾16_線1;

		public Par X0Y0_尾16_線2;

		public Par X0Y0_尾17_尾;

		public Par X0Y0_尾17_線1;

		public Par X0Y0_尾17_線2;

		public Par X0Y0_尾18;

		public ColorD 尾0_尾CD;

		public ColorD 尾0_線1CD;

		public ColorD 尾0_線2CD;

		public ColorD 尾1_尾CD;

		public ColorD 尾1_線1CD;

		public ColorD 尾1_線2CD;

		public ColorD 尾2_尾CD;

		public ColorD 尾2_線1CD;

		public ColorD 尾2_線2CD;

		public ColorD 尾3_尾CD;

		public ColorD 尾3_線1CD;

		public ColorD 尾3_線2CD;

		public ColorD 尾4_尾CD;

		public ColorD 尾4_線1CD;

		public ColorD 尾4_線2CD;

		public ColorD 尾5_尾CD;

		public ColorD 尾5_線1CD;

		public ColorD 尾5_線2CD;

		public ColorD 尾6_尾CD;

		public ColorD 尾6_線1CD;

		public ColorD 尾6_線2CD;

		public ColorD 尾7_尾CD;

		public ColorD 尾7_線1CD;

		public ColorD 尾7_線2CD;

		public ColorD 尾8_尾CD;

		public ColorD 尾8_線1CD;

		public ColorD 尾8_線2CD;

		public ColorD 尾9_尾CD;

		public ColorD 尾9_線1CD;

		public ColorD 尾9_線2CD;

		public ColorD 尾10_尾CD;

		public ColorD 尾10_線1CD;

		public ColorD 尾10_線2CD;

		public ColorD 尾11_尾CD;

		public ColorD 尾11_線1CD;

		public ColorD 尾11_線2CD;

		public ColorD 尾12_尾CD;

		public ColorD 尾12_線1CD;

		public ColorD 尾12_線2CD;

		public ColorD 尾13_尾CD;

		public ColorD 尾13_線1CD;

		public ColorD 尾13_線2CD;

		public ColorD 尾14_尾CD;

		public ColorD 尾14_線1CD;

		public ColorD 尾14_線2CD;

		public ColorD 尾15_尾CD;

		public ColorD 尾15_線1CD;

		public ColorD 尾15_線2CD;

		public ColorD 尾16_尾CD;

		public ColorD 尾16_線1CD;

		public ColorD 尾16_線2CD;

		public ColorD 尾17_尾CD;

		public ColorD 尾17_線1CD;

		public ColorD 尾17_線2CD;

		public ColorD 尾18CD;

		public ColorD 輪_革CD;

		public ColorD 輪_金具1CD;

		public ColorD 輪_金具2CD;

		public ColorD 輪_金具3CD;

		public ColorD 輪_金具左CD;

		public ColorD 輪_金具右CD;

		public ColorP X0Y0_尾0_尾CP;

		public ColorP X0Y0_尾0_線1CP;

		public ColorP X0Y0_尾0_線2CP;

		public ColorP X0Y0_尾1_尾CP;

		public ColorP X0Y0_尾1_線1CP;

		public ColorP X0Y0_尾1_線2CP;

		public ColorP X0Y0_尾2_尾CP;

		public ColorP X0Y0_尾2_線1CP;

		public ColorP X0Y0_尾2_線2CP;

		public ColorP X0Y0_尾3_尾CP;

		public ColorP X0Y0_尾3_線1CP;

		public ColorP X0Y0_尾3_線2CP;

		public ColorP X0Y0_尾4_尾CP;

		public ColorP X0Y0_尾4_線1CP;

		public ColorP X0Y0_尾4_線2CP;

		public ColorP X0Y0_尾5_尾CP;

		public ColorP X0Y0_尾5_線1CP;

		public ColorP X0Y0_尾5_線2CP;

		public ColorP X0Y0_尾6_尾CP;

		public ColorP X0Y0_尾6_線1CP;

		public ColorP X0Y0_尾6_線2CP;

		public ColorP X0Y0_尾7_尾CP;

		public ColorP X0Y0_尾7_線1CP;

		public ColorP X0Y0_尾7_線2CP;

		public ColorP X0Y0_輪_革CP;

		public ColorP X0Y0_輪_金具1CP;

		public ColorP X0Y0_輪_金具2CP;

		public ColorP X0Y0_輪_金具3CP;

		public ColorP X0Y0_輪_金具左CP;

		public ColorP X0Y0_輪_金具右CP;

		public ColorP X0Y0_尾8_尾CP;

		public ColorP X0Y0_尾8_線1CP;

		public ColorP X0Y0_尾8_線2CP;

		public ColorP X0Y0_尾9_尾CP;

		public ColorP X0Y0_尾9_線1CP;

		public ColorP X0Y0_尾9_線2CP;

		public ColorP X0Y0_尾10_尾CP;

		public ColorP X0Y0_尾10_線1CP;

		public ColorP X0Y0_尾10_線2CP;

		public ColorP X0Y0_尾11_尾CP;

		public ColorP X0Y0_尾11_線1CP;

		public ColorP X0Y0_尾11_線2CP;

		public ColorP X0Y0_尾12_尾CP;

		public ColorP X0Y0_尾12_線1CP;

		public ColorP X0Y0_尾12_線2CP;

		public ColorP X0Y0_尾13_尾CP;

		public ColorP X0Y0_尾13_線1CP;

		public ColorP X0Y0_尾13_線2CP;

		public ColorP X0Y0_尾14_尾CP;

		public ColorP X0Y0_尾14_線1CP;

		public ColorP X0Y0_尾14_線2CP;

		public ColorP X0Y0_尾15_尾CP;

		public ColorP X0Y0_尾15_線1CP;

		public ColorP X0Y0_尾15_線2CP;

		public ColorP X0Y0_尾16_尾CP;

		public ColorP X0Y0_尾16_線1CP;

		public ColorP X0Y0_尾16_線2CP;

		public ColorP X0Y0_尾17_尾CP;

		public ColorP X0Y0_尾17_線1CP;

		public ColorP X0Y0_尾17_線2CP;

		public ColorP X0Y0_尾18CP;

		public 拘束鎖 鎖1;

		public 拘束鎖 鎖2;

		public Par[] Pars;

		private Vector2D[] mm;
	}
}
