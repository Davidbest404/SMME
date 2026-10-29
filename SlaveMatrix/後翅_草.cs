using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 後翅_草 : 後翅
	{
		public 後翅_草(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 後翅_草D e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif(Sta.肢左["後翅"][3]);
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0]["後翅"].ToPars();
			Pars pars2 = pars["後翅1"].ToPars();
			this.X0Y0_後翅_後翅1_後翅 = pars2["後翅"].ToPar();
			this.X0Y0_後翅_後翅1_翅脈1 = pars2["翅脈1"].ToPar();
			this.X0Y0_後翅_後翅1_翅脈2 = pars2["翅脈2"].ToPar();
			this.X0Y0_後翅_後翅1_翅脈3 = pars2["翅脈3"].ToPar();
			pars2 = pars["後翅2"].ToPars();
			this.X0Y0_後翅_後翅2_後翅 = pars2["後翅"].ToPar();
			this.X0Y0_後翅_後翅2_翅脈1 = pars2["翅脈1"].ToPar();
			this.X0Y0_後翅_後翅2_翅脈2 = pars2["翅脈2"].ToPar();
			this.X0Y0_後翅_後翅2_翅脈3 = pars2["翅脈3"].ToPar();
			pars2 = pars["後翅3"].ToPars();
			this.X0Y0_後翅_後翅3_後翅 = pars2["後翅"].ToPar();
			this.X0Y0_後翅_後翅3_翅脈1 = pars2["翅脈1"].ToPar();
			this.X0Y0_後翅_後翅3_翅脈2 = pars2["翅脈2"].ToPar();
			this.X0Y0_後翅_後翅3_翅脈3 = pars2["翅脈3"].ToPar();
			pars2 = pars["後翅4"].ToPars();
			this.X0Y0_後翅_後翅4_後翅 = pars2["後翅"].ToPar();
			this.X0Y0_後翅_後翅4_翅脈1 = pars2["翅脈1"].ToPar();
			this.X0Y0_後翅_後翅4_翅脈2 = pars2["翅脈2"].ToPar();
			this.X0Y0_後翅_後翅4_翅脈3 = pars2["翅脈3"].ToPar();
			pars2 = pars["後翅5"].ToPars();
			this.X0Y0_後翅_後翅5_後翅 = pars2["後翅"].ToPar();
			this.X0Y0_後翅_後翅5_翅脈1 = pars2["翅脈1"].ToPar();
			this.X0Y0_後翅_後翅5_翅脈2 = pars2["翅脈2"].ToPar();
			this.X0Y0_後翅_後翅5_翅脈3 = pars2["翅脈3"].ToPar();
			pars2 = pars["後翅6"].ToPars();
			this.X0Y0_後翅_後翅6_後翅 = pars2["後翅"].ToPar();
			this.X0Y0_後翅_後翅6_翅脈1 = pars2["翅脈1"].ToPar();
			this.X0Y0_後翅_後翅6_翅脈2 = pars2["翅脈2"].ToPar();
			this.X0Y0_後翅_後翅6_翅脈3 = pars2["翅脈3"].ToPar();
			pars2 = pars["後翅7"].ToPars();
			this.X0Y0_後翅_後翅7_後翅 = pars2["後翅"].ToPar();
			this.X0Y0_後翅_後翅7_翅脈1 = pars2["翅脈1"].ToPar();
			this.X0Y0_後翅_後翅7_翅脈2 = pars2["翅脈2"].ToPar();
			this.X0Y0_後翅_後翅7_翅脈3 = pars2["翅脈3"].ToPar();
			pars2 = pars["後翅8"].ToPars();
			this.X0Y0_後翅_後翅8_後翅 = pars2["後翅"].ToPar();
			this.X0Y0_後翅_後翅8_翅脈1 = pars2["翅脈1"].ToPar();
			this.X0Y0_後翅_後翅8_翅脈2 = pars2["翅脈2"].ToPar();
			this.X0Y0_後翅_後翅8_翅脈3 = pars2["翅脈3"].ToPar();
			pars2 = pars["後翅9"].ToPars();
			this.X0Y0_後翅_後翅9_後翅 = pars2["後翅"].ToPar();
			this.X0Y0_後翅_後翅9_翅脈1 = pars2["翅脈1"].ToPar();
			this.X0Y0_後翅_後翅9_翅脈2 = pars2["翅脈2"].ToPar();
			this.X0Y0_後翅_後翅9_翅脈3 = pars2["翅脈3"].ToPar();
			pars2 = pars["後翅10"].ToPars();
			this.X0Y0_後翅_後翅10_後翅 = pars2["後翅"].ToPar();
			this.X0Y0_後翅_後翅10_翅脈1 = pars2["翅脈1"].ToPar();
			this.X0Y0_後翅_後翅10_翅脈2 = pars2["翅脈2"].ToPar();
			this.X0Y0_後翅_後翅10_翅脈3 = pars2["翅脈3"].ToPar();
			pars2 = pars["後翅11"].ToPars();
			this.X0Y0_後翅_後翅11_後翅 = pars2["後翅"].ToPar();
			this.X0Y0_後翅_後翅11_翅脈1 = pars2["翅脈1"].ToPar();
			this.X0Y0_後翅_後翅11_翅脈2 = pars2["翅脈2"].ToPar();
			this.X0Y0_後翅_後翅11_翅脈3 = pars2["翅脈3"].ToPar();
			Pars pars3 = this.本体[0][1]["後翅"].ToPars();
			pars2 = pars3["後翅1"].ToPars();
			this.X0Y1_後翅_後翅1_後翅 = pars2["後翅"].ToPar();
			this.X0Y1_後翅_後翅1_翅脈1 = pars2["翅脈1"].ToPar();
			this.X0Y1_後翅_後翅1_翅脈2 = pars2["翅脈2"].ToPar();
			this.X0Y1_後翅_後翅1_翅脈3 = pars2["翅脈3"].ToPar();
			pars2 = pars3["後翅2"].ToPars();
			this.X0Y1_後翅_後翅2_後翅 = pars2["後翅"].ToPar();
			this.X0Y1_後翅_後翅2_翅脈1 = pars2["翅脈1"].ToPar();
			this.X0Y1_後翅_後翅2_翅脈2 = pars2["翅脈2"].ToPar();
			this.X0Y1_後翅_後翅2_翅脈3 = pars2["翅脈3"].ToPar();
			pars2 = pars3["後翅3"].ToPars();
			this.X0Y1_後翅_後翅3_後翅 = pars2["後翅"].ToPar();
			this.X0Y1_後翅_後翅3_翅脈1 = pars2["翅脈1"].ToPar();
			this.X0Y1_後翅_後翅3_翅脈2 = pars2["翅脈2"].ToPar();
			this.X0Y1_後翅_後翅3_翅脈3 = pars2["翅脈3"].ToPar();
			pars2 = pars3["後翅4"].ToPars();
			this.X0Y1_後翅_後翅4_後翅 = pars2["後翅"].ToPar();
			this.X0Y1_後翅_後翅4_翅脈1 = pars2["翅脈1"].ToPar();
			this.X0Y1_後翅_後翅4_翅脈2 = pars2["翅脈2"].ToPar();
			this.X0Y1_後翅_後翅4_翅脈3 = pars2["翅脈3"].ToPar();
			pars2 = pars3["後翅5"].ToPars();
			this.X0Y1_後翅_後翅5_後翅 = pars2["後翅"].ToPar();
			this.X0Y1_後翅_後翅5_翅脈1 = pars2["翅脈1"].ToPar();
			this.X0Y1_後翅_後翅5_翅脈2 = pars2["翅脈2"].ToPar();
			this.X0Y1_後翅_後翅5_翅脈3 = pars2["翅脈3"].ToPar();
			pars2 = pars3["後翅6"].ToPars();
			this.X0Y1_後翅_後翅6_後翅 = pars2["後翅"].ToPar();
			this.X0Y1_後翅_後翅6_翅脈1 = pars2["翅脈1"].ToPar();
			this.X0Y1_後翅_後翅6_翅脈2 = pars2["翅脈2"].ToPar();
			this.X0Y1_後翅_後翅6_翅脈3 = pars2["翅脈3"].ToPar();
			pars2 = pars3["後翅7"].ToPars();
			this.X0Y1_後翅_後翅7_後翅 = pars2["後翅"].ToPar();
			this.X0Y1_後翅_後翅7_翅脈1 = pars2["翅脈1"].ToPar();
			this.X0Y1_後翅_後翅7_翅脈2 = pars2["翅脈2"].ToPar();
			this.X0Y1_後翅_後翅7_翅脈3 = pars2["翅脈3"].ToPar();
			pars2 = pars3["後翅8"].ToPars();
			this.X0Y1_後翅_後翅8_後翅 = pars2["後翅"].ToPar();
			this.X0Y1_後翅_後翅8_翅脈1 = pars2["翅脈1"].ToPar();
			this.X0Y1_後翅_後翅8_翅脈2 = pars2["翅脈2"].ToPar();
			this.X0Y1_後翅_後翅8_翅脈3 = pars2["翅脈3"].ToPar();
			pars2 = pars3["後翅9"].ToPars();
			this.X0Y1_後翅_後翅9_後翅 = pars2["後翅"].ToPar();
			this.X0Y1_後翅_後翅9_翅脈1 = pars2["翅脈1"].ToPar();
			this.X0Y1_後翅_後翅9_翅脈2 = pars2["翅脈2"].ToPar();
			this.X0Y1_後翅_後翅9_翅脈3 = pars2["翅脈3"].ToPar();
			pars2 = pars3["後翅10"].ToPars();
			this.X0Y1_後翅_後翅10_後翅 = pars2["後翅"].ToPar();
			this.X0Y1_後翅_後翅10_翅脈1 = pars2["翅脈1"].ToPar();
			this.X0Y1_後翅_後翅10_翅脈2 = pars2["翅脈2"].ToPar();
			this.X0Y1_後翅_後翅10_翅脈3 = pars2["翅脈3"].ToPar();
			pars2 = pars3["後翅11"].ToPars();
			this.X0Y1_後翅_後翅11_後翅 = pars2["後翅"].ToPar();
			this.X0Y1_後翅_後翅11_翅脈1 = pars2["翅脈1"].ToPar();
			this.X0Y1_後翅_後翅11_翅脈2 = pars2["翅脈2"].ToPar();
			this.X0Y1_後翅_後翅11_翅脈3 = pars2["翅脈3"].ToPar();
			this.Xasix = false;
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
			this.後翅_後翅1_後翅_表示 = e.後翅_後翅1_後翅_表示;
			this.後翅_後翅1_翅脈1_表示 = e.後翅_後翅1_翅脈1_表示;
			this.後翅_後翅1_翅脈2_表示 = e.後翅_後翅1_翅脈2_表示;
			this.後翅_後翅1_翅脈3_表示 = e.後翅_後翅1_翅脈3_表示;
			this.後翅_後翅2_後翅_表示 = e.後翅_後翅2_後翅_表示;
			this.後翅_後翅2_翅脈1_表示 = e.後翅_後翅2_翅脈1_表示;
			this.後翅_後翅2_翅脈2_表示 = e.後翅_後翅2_翅脈2_表示;
			this.後翅_後翅2_翅脈3_表示 = e.後翅_後翅2_翅脈3_表示;
			this.後翅_後翅3_後翅_表示 = e.後翅_後翅3_後翅_表示;
			this.後翅_後翅3_翅脈1_表示 = e.後翅_後翅3_翅脈1_表示;
			this.後翅_後翅3_翅脈2_表示 = e.後翅_後翅3_翅脈2_表示;
			this.後翅_後翅3_翅脈3_表示 = e.後翅_後翅3_翅脈3_表示;
			this.後翅_後翅4_後翅_表示 = e.後翅_後翅4_後翅_表示;
			this.後翅_後翅4_翅脈1_表示 = e.後翅_後翅4_翅脈1_表示;
			this.後翅_後翅4_翅脈2_表示 = e.後翅_後翅4_翅脈2_表示;
			this.後翅_後翅4_翅脈3_表示 = e.後翅_後翅4_翅脈3_表示;
			this.後翅_後翅5_後翅_表示 = e.後翅_後翅5_後翅_表示;
			this.後翅_後翅5_翅脈1_表示 = e.後翅_後翅5_翅脈1_表示;
			this.後翅_後翅5_翅脈2_表示 = e.後翅_後翅5_翅脈2_表示;
			this.後翅_後翅5_翅脈3_表示 = e.後翅_後翅5_翅脈3_表示;
			this.後翅_後翅6_後翅_表示 = e.後翅_後翅6_後翅_表示;
			this.後翅_後翅6_翅脈1_表示 = e.後翅_後翅6_翅脈1_表示;
			this.後翅_後翅6_翅脈2_表示 = e.後翅_後翅6_翅脈2_表示;
			this.後翅_後翅6_翅脈3_表示 = e.後翅_後翅6_翅脈3_表示;
			this.後翅_後翅7_後翅_表示 = e.後翅_後翅7_後翅_表示;
			this.後翅_後翅7_翅脈1_表示 = e.後翅_後翅7_翅脈1_表示;
			this.後翅_後翅7_翅脈2_表示 = e.後翅_後翅7_翅脈2_表示;
			this.後翅_後翅7_翅脈3_表示 = e.後翅_後翅7_翅脈3_表示;
			this.後翅_後翅8_後翅_表示 = e.後翅_後翅8_後翅_表示;
			this.後翅_後翅8_翅脈1_表示 = e.後翅_後翅8_翅脈1_表示;
			this.後翅_後翅8_翅脈2_表示 = e.後翅_後翅8_翅脈2_表示;
			this.後翅_後翅8_翅脈3_表示 = e.後翅_後翅8_翅脈3_表示;
			this.後翅_後翅9_後翅_表示 = e.後翅_後翅9_後翅_表示;
			this.後翅_後翅9_翅脈1_表示 = e.後翅_後翅9_翅脈1_表示;
			this.後翅_後翅9_翅脈2_表示 = e.後翅_後翅9_翅脈2_表示;
			this.後翅_後翅9_翅脈3_表示 = e.後翅_後翅9_翅脈3_表示;
			this.後翅_後翅10_後翅_表示 = e.後翅_後翅10_後翅_表示;
			this.後翅_後翅10_翅脈1_表示 = e.後翅_後翅10_翅脈1_表示;
			this.後翅_後翅10_翅脈2_表示 = e.後翅_後翅10_翅脈2_表示;
			this.後翅_後翅10_翅脈3_表示 = e.後翅_後翅10_翅脈3_表示;
			this.後翅_後翅11_後翅_表示 = e.後翅_後翅11_後翅_表示;
			this.後翅_後翅11_翅脈1_表示 = e.後翅_後翅11_翅脈1_表示;
			this.後翅_後翅11_翅脈2_表示 = e.後翅_後翅11_翅脈2_表示;
			this.後翅_後翅11_翅脈3_表示 = e.後翅_後翅11_翅脈3_表示;
			this.展開 = e.展開;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_後翅_後翅1_後翅CP = new ColorP(this.X0Y0_後翅_後翅1_後翅, this.後翅_後翅1_後翅CD, DisUnit, true);
			this.X0Y0_後翅_後翅1_翅脈1CP = new ColorP(this.X0Y0_後翅_後翅1_翅脈1, this.後翅_後翅1_翅脈1CD, DisUnit, true);
			this.X0Y0_後翅_後翅1_翅脈2CP = new ColorP(this.X0Y0_後翅_後翅1_翅脈2, this.後翅_後翅1_翅脈2CD, DisUnit, true);
			this.X0Y0_後翅_後翅1_翅脈3CP = new ColorP(this.X0Y0_後翅_後翅1_翅脈3, this.後翅_後翅1_翅脈3CD, DisUnit, true);
			this.X0Y0_後翅_後翅2_後翅CP = new ColorP(this.X0Y0_後翅_後翅2_後翅, this.後翅_後翅2_後翅CD, DisUnit, true);
			this.X0Y0_後翅_後翅2_翅脈1CP = new ColorP(this.X0Y0_後翅_後翅2_翅脈1, this.後翅_後翅2_翅脈1CD, DisUnit, true);
			this.X0Y0_後翅_後翅2_翅脈2CP = new ColorP(this.X0Y0_後翅_後翅2_翅脈2, this.後翅_後翅2_翅脈2CD, DisUnit, true);
			this.X0Y0_後翅_後翅2_翅脈3CP = new ColorP(this.X0Y0_後翅_後翅2_翅脈3, this.後翅_後翅2_翅脈3CD, DisUnit, true);
			this.X0Y0_後翅_後翅3_後翅CP = new ColorP(this.X0Y0_後翅_後翅3_後翅, this.後翅_後翅3_後翅CD, DisUnit, true);
			this.X0Y0_後翅_後翅3_翅脈1CP = new ColorP(this.X0Y0_後翅_後翅3_翅脈1, this.後翅_後翅3_翅脈1CD, DisUnit, true);
			this.X0Y0_後翅_後翅3_翅脈2CP = new ColorP(this.X0Y0_後翅_後翅3_翅脈2, this.後翅_後翅3_翅脈2CD, DisUnit, true);
			this.X0Y0_後翅_後翅3_翅脈3CP = new ColorP(this.X0Y0_後翅_後翅3_翅脈3, this.後翅_後翅3_翅脈3CD, DisUnit, true);
			this.X0Y0_後翅_後翅4_後翅CP = new ColorP(this.X0Y0_後翅_後翅4_後翅, this.後翅_後翅4_後翅CD, DisUnit, true);
			this.X0Y0_後翅_後翅4_翅脈1CP = new ColorP(this.X0Y0_後翅_後翅4_翅脈1, this.後翅_後翅4_翅脈1CD, DisUnit, true);
			this.X0Y0_後翅_後翅4_翅脈2CP = new ColorP(this.X0Y0_後翅_後翅4_翅脈2, this.後翅_後翅4_翅脈2CD, DisUnit, true);
			this.X0Y0_後翅_後翅4_翅脈3CP = new ColorP(this.X0Y0_後翅_後翅4_翅脈3, this.後翅_後翅4_翅脈3CD, DisUnit, true);
			this.X0Y0_後翅_後翅5_後翅CP = new ColorP(this.X0Y0_後翅_後翅5_後翅, this.後翅_後翅5_後翅CD, DisUnit, true);
			this.X0Y0_後翅_後翅5_翅脈1CP = new ColorP(this.X0Y0_後翅_後翅5_翅脈1, this.後翅_後翅5_翅脈1CD, DisUnit, true);
			this.X0Y0_後翅_後翅5_翅脈2CP = new ColorP(this.X0Y0_後翅_後翅5_翅脈2, this.後翅_後翅5_翅脈2CD, DisUnit, true);
			this.X0Y0_後翅_後翅5_翅脈3CP = new ColorP(this.X0Y0_後翅_後翅5_翅脈3, this.後翅_後翅5_翅脈3CD, DisUnit, true);
			this.X0Y0_後翅_後翅6_後翅CP = new ColorP(this.X0Y0_後翅_後翅6_後翅, this.後翅_後翅6_後翅CD, DisUnit, true);
			this.X0Y0_後翅_後翅6_翅脈1CP = new ColorP(this.X0Y0_後翅_後翅6_翅脈1, this.後翅_後翅6_翅脈1CD, DisUnit, true);
			this.X0Y0_後翅_後翅6_翅脈2CP = new ColorP(this.X0Y0_後翅_後翅6_翅脈2, this.後翅_後翅6_翅脈2CD, DisUnit, true);
			this.X0Y0_後翅_後翅6_翅脈3CP = new ColorP(this.X0Y0_後翅_後翅6_翅脈3, this.後翅_後翅6_翅脈3CD, DisUnit, true);
			this.X0Y0_後翅_後翅7_後翅CP = new ColorP(this.X0Y0_後翅_後翅7_後翅, this.後翅_後翅7_後翅CD, DisUnit, true);
			this.X0Y0_後翅_後翅7_翅脈1CP = new ColorP(this.X0Y0_後翅_後翅7_翅脈1, this.後翅_後翅7_翅脈1CD, DisUnit, true);
			this.X0Y0_後翅_後翅7_翅脈2CP = new ColorP(this.X0Y0_後翅_後翅7_翅脈2, this.後翅_後翅7_翅脈2CD, DisUnit, true);
			this.X0Y0_後翅_後翅7_翅脈3CP = new ColorP(this.X0Y0_後翅_後翅7_翅脈3, this.後翅_後翅7_翅脈3CD, DisUnit, true);
			this.X0Y0_後翅_後翅8_後翅CP = new ColorP(this.X0Y0_後翅_後翅8_後翅, this.後翅_後翅8_後翅CD, DisUnit, true);
			this.X0Y0_後翅_後翅8_翅脈1CP = new ColorP(this.X0Y0_後翅_後翅8_翅脈1, this.後翅_後翅8_翅脈1CD, DisUnit, true);
			this.X0Y0_後翅_後翅8_翅脈2CP = new ColorP(this.X0Y0_後翅_後翅8_翅脈2, this.後翅_後翅8_翅脈2CD, DisUnit, true);
			this.X0Y0_後翅_後翅8_翅脈3CP = new ColorP(this.X0Y0_後翅_後翅8_翅脈3, this.後翅_後翅8_翅脈3CD, DisUnit, true);
			this.X0Y0_後翅_後翅9_後翅CP = new ColorP(this.X0Y0_後翅_後翅9_後翅, this.後翅_後翅9_後翅CD, DisUnit, true);
			this.X0Y0_後翅_後翅9_翅脈1CP = new ColorP(this.X0Y0_後翅_後翅9_翅脈1, this.後翅_後翅9_翅脈1CD, DisUnit, true);
			this.X0Y0_後翅_後翅9_翅脈2CP = new ColorP(this.X0Y0_後翅_後翅9_翅脈2, this.後翅_後翅9_翅脈2CD, DisUnit, true);
			this.X0Y0_後翅_後翅9_翅脈3CP = new ColorP(this.X0Y0_後翅_後翅9_翅脈3, this.後翅_後翅9_翅脈3CD, DisUnit, true);
			this.X0Y0_後翅_後翅10_後翅CP = new ColorP(this.X0Y0_後翅_後翅10_後翅, this.後翅_後翅10_後翅CD, DisUnit, true);
			this.X0Y0_後翅_後翅10_翅脈1CP = new ColorP(this.X0Y0_後翅_後翅10_翅脈1, this.後翅_後翅10_翅脈1CD, DisUnit, true);
			this.X0Y0_後翅_後翅10_翅脈2CP = new ColorP(this.X0Y0_後翅_後翅10_翅脈2, this.後翅_後翅10_翅脈2CD, DisUnit, true);
			this.X0Y0_後翅_後翅10_翅脈3CP = new ColorP(this.X0Y0_後翅_後翅10_翅脈3, this.後翅_後翅10_翅脈3CD, DisUnit, true);
			this.X0Y0_後翅_後翅11_後翅CP = new ColorP(this.X0Y0_後翅_後翅11_後翅, this.後翅_後翅11_後翅CD, DisUnit, true);
			this.X0Y0_後翅_後翅11_翅脈1CP = new ColorP(this.X0Y0_後翅_後翅11_翅脈1, this.後翅_後翅11_翅脈1CD, DisUnit, true);
			this.X0Y0_後翅_後翅11_翅脈2CP = new ColorP(this.X0Y0_後翅_後翅11_翅脈2, this.後翅_後翅11_翅脈2CD, DisUnit, true);
			this.X0Y0_後翅_後翅11_翅脈3CP = new ColorP(this.X0Y0_後翅_後翅11_翅脈3, this.後翅_後翅11_翅脈3CD, DisUnit, true);
			this.X0Y1_後翅_後翅1_後翅CP = new ColorP(this.X0Y1_後翅_後翅1_後翅, this.後翅_後翅1_後翅CD, DisUnit, true);
			this.X0Y1_後翅_後翅1_翅脈1CP = new ColorP(this.X0Y1_後翅_後翅1_翅脈1, this.後翅_後翅1_翅脈1CD, DisUnit, true);
			this.X0Y1_後翅_後翅1_翅脈2CP = new ColorP(this.X0Y1_後翅_後翅1_翅脈2, this.後翅_後翅1_翅脈2CD, DisUnit, true);
			this.X0Y1_後翅_後翅1_翅脈3CP = new ColorP(this.X0Y1_後翅_後翅1_翅脈3, this.後翅_後翅1_翅脈3CD, DisUnit, true);
			this.X0Y1_後翅_後翅2_後翅CP = new ColorP(this.X0Y1_後翅_後翅2_後翅, this.後翅_後翅2_後翅CD, DisUnit, true);
			this.X0Y1_後翅_後翅2_翅脈1CP = new ColorP(this.X0Y1_後翅_後翅2_翅脈1, this.後翅_後翅2_翅脈1CD, DisUnit, true);
			this.X0Y1_後翅_後翅2_翅脈2CP = new ColorP(this.X0Y1_後翅_後翅2_翅脈2, this.後翅_後翅2_翅脈2CD, DisUnit, true);
			this.X0Y1_後翅_後翅2_翅脈3CP = new ColorP(this.X0Y1_後翅_後翅2_翅脈3, this.後翅_後翅2_翅脈3CD, DisUnit, true);
			this.X0Y1_後翅_後翅3_後翅CP = new ColorP(this.X0Y1_後翅_後翅3_後翅, this.後翅_後翅3_後翅CD, DisUnit, true);
			this.X0Y1_後翅_後翅3_翅脈1CP = new ColorP(this.X0Y1_後翅_後翅3_翅脈1, this.後翅_後翅3_翅脈1CD, DisUnit, true);
			this.X0Y1_後翅_後翅3_翅脈2CP = new ColorP(this.X0Y1_後翅_後翅3_翅脈2, this.後翅_後翅3_翅脈2CD, DisUnit, true);
			this.X0Y1_後翅_後翅3_翅脈3CP = new ColorP(this.X0Y1_後翅_後翅3_翅脈3, this.後翅_後翅3_翅脈3CD, DisUnit, true);
			this.X0Y1_後翅_後翅4_後翅CP = new ColorP(this.X0Y1_後翅_後翅4_後翅, this.後翅_後翅4_後翅CD, DisUnit, true);
			this.X0Y1_後翅_後翅4_翅脈1CP = new ColorP(this.X0Y1_後翅_後翅4_翅脈1, this.後翅_後翅4_翅脈1CD, DisUnit, true);
			this.X0Y1_後翅_後翅4_翅脈2CP = new ColorP(this.X0Y1_後翅_後翅4_翅脈2, this.後翅_後翅4_翅脈2CD, DisUnit, true);
			this.X0Y1_後翅_後翅4_翅脈3CP = new ColorP(this.X0Y1_後翅_後翅4_翅脈3, this.後翅_後翅4_翅脈3CD, DisUnit, true);
			this.X0Y1_後翅_後翅5_後翅CP = new ColorP(this.X0Y1_後翅_後翅5_後翅, this.後翅_後翅5_後翅CD, DisUnit, true);
			this.X0Y1_後翅_後翅5_翅脈1CP = new ColorP(this.X0Y1_後翅_後翅5_翅脈1, this.後翅_後翅5_翅脈1CD, DisUnit, true);
			this.X0Y1_後翅_後翅5_翅脈2CP = new ColorP(this.X0Y1_後翅_後翅5_翅脈2, this.後翅_後翅5_翅脈2CD, DisUnit, true);
			this.X0Y1_後翅_後翅5_翅脈3CP = new ColorP(this.X0Y1_後翅_後翅5_翅脈3, this.後翅_後翅5_翅脈3CD, DisUnit, true);
			this.X0Y1_後翅_後翅6_後翅CP = new ColorP(this.X0Y1_後翅_後翅6_後翅, this.後翅_後翅6_後翅CD, DisUnit, true);
			this.X0Y1_後翅_後翅6_翅脈1CP = new ColorP(this.X0Y1_後翅_後翅6_翅脈1, this.後翅_後翅6_翅脈1CD, DisUnit, true);
			this.X0Y1_後翅_後翅6_翅脈2CP = new ColorP(this.X0Y1_後翅_後翅6_翅脈2, this.後翅_後翅6_翅脈2CD, DisUnit, true);
			this.X0Y1_後翅_後翅6_翅脈3CP = new ColorP(this.X0Y1_後翅_後翅6_翅脈3, this.後翅_後翅6_翅脈3CD, DisUnit, true);
			this.X0Y1_後翅_後翅7_後翅CP = new ColorP(this.X0Y1_後翅_後翅7_後翅, this.後翅_後翅7_後翅CD, DisUnit, true);
			this.X0Y1_後翅_後翅7_翅脈1CP = new ColorP(this.X0Y1_後翅_後翅7_翅脈1, this.後翅_後翅7_翅脈1CD, DisUnit, true);
			this.X0Y1_後翅_後翅7_翅脈2CP = new ColorP(this.X0Y1_後翅_後翅7_翅脈2, this.後翅_後翅7_翅脈2CD, DisUnit, true);
			this.X0Y1_後翅_後翅7_翅脈3CP = new ColorP(this.X0Y1_後翅_後翅7_翅脈3, this.後翅_後翅7_翅脈3CD, DisUnit, true);
			this.X0Y1_後翅_後翅8_後翅CP = new ColorP(this.X0Y1_後翅_後翅8_後翅, this.後翅_後翅8_後翅CD, DisUnit, true);
			this.X0Y1_後翅_後翅8_翅脈1CP = new ColorP(this.X0Y1_後翅_後翅8_翅脈1, this.後翅_後翅8_翅脈1CD, DisUnit, true);
			this.X0Y1_後翅_後翅8_翅脈2CP = new ColorP(this.X0Y1_後翅_後翅8_翅脈2, this.後翅_後翅8_翅脈2CD, DisUnit, true);
			this.X0Y1_後翅_後翅8_翅脈3CP = new ColorP(this.X0Y1_後翅_後翅8_翅脈3, this.後翅_後翅8_翅脈3CD, DisUnit, true);
			this.X0Y1_後翅_後翅9_後翅CP = new ColorP(this.X0Y1_後翅_後翅9_後翅, this.後翅_後翅9_後翅CD, DisUnit, true);
			this.X0Y1_後翅_後翅9_翅脈1CP = new ColorP(this.X0Y1_後翅_後翅9_翅脈1, this.後翅_後翅9_翅脈1CD, DisUnit, true);
			this.X0Y1_後翅_後翅9_翅脈2CP = new ColorP(this.X0Y1_後翅_後翅9_翅脈2, this.後翅_後翅9_翅脈2CD, DisUnit, true);
			this.X0Y1_後翅_後翅9_翅脈3CP = new ColorP(this.X0Y1_後翅_後翅9_翅脈3, this.後翅_後翅9_翅脈3CD, DisUnit, true);
			this.X0Y1_後翅_後翅10_後翅CP = new ColorP(this.X0Y1_後翅_後翅10_後翅, this.後翅_後翅10_後翅CD, DisUnit, true);
			this.X0Y1_後翅_後翅10_翅脈1CP = new ColorP(this.X0Y1_後翅_後翅10_翅脈1, this.後翅_後翅10_翅脈1CD, DisUnit, true);
			this.X0Y1_後翅_後翅10_翅脈2CP = new ColorP(this.X0Y1_後翅_後翅10_翅脈2, this.後翅_後翅10_翅脈2CD, DisUnit, true);
			this.X0Y1_後翅_後翅10_翅脈3CP = new ColorP(this.X0Y1_後翅_後翅10_翅脈3, this.後翅_後翅10_翅脈3CD, DisUnit, true);
			this.X0Y1_後翅_後翅11_後翅CP = new ColorP(this.X0Y1_後翅_後翅11_後翅, this.後翅_後翅11_後翅CD, DisUnit, true);
			this.X0Y1_後翅_後翅11_翅脈1CP = new ColorP(this.X0Y1_後翅_後翅11_翅脈1, this.後翅_後翅11_翅脈1CD, DisUnit, true);
			this.X0Y1_後翅_後翅11_翅脈2CP = new ColorP(this.X0Y1_後翅_後翅11_翅脈2, this.後翅_後翅11_翅脈2CD, DisUnit, true);
			this.X0Y1_後翅_後翅11_翅脈3CP = new ColorP(this.X0Y1_後翅_後翅11_翅脈3, this.後翅_後翅11_翅脈3CD, DisUnit, true);
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
				this.本体.IndexY = (this.欠損_ ? 1 : 0);
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

		public bool 後翅_後翅1_後翅_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅1_後翅.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅1_後翅.Dra = value;
				this.X0Y1_後翅_後翅1_後翅.Dra = value;
				this.X0Y0_後翅_後翅1_後翅.Hit = value;
				this.X0Y1_後翅_後翅1_後翅.Hit = value;
			}
		}

		public bool 後翅_後翅1_翅脈1_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅1_翅脈1.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅1_翅脈1.Dra = value;
				this.X0Y1_後翅_後翅1_翅脈1.Dra = value;
				this.X0Y0_後翅_後翅1_翅脈1.Hit = value;
				this.X0Y1_後翅_後翅1_翅脈1.Hit = value;
			}
		}

		public bool 後翅_後翅1_翅脈2_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅1_翅脈2.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅1_翅脈2.Dra = value;
				this.X0Y1_後翅_後翅1_翅脈2.Dra = value;
				this.X0Y0_後翅_後翅1_翅脈2.Hit = value;
				this.X0Y1_後翅_後翅1_翅脈2.Hit = value;
			}
		}

		public bool 後翅_後翅1_翅脈3_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅1_翅脈3.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅1_翅脈3.Dra = value;
				this.X0Y1_後翅_後翅1_翅脈3.Dra = value;
				this.X0Y0_後翅_後翅1_翅脈3.Hit = value;
				this.X0Y1_後翅_後翅1_翅脈3.Hit = value;
			}
		}

		public bool 後翅_後翅2_後翅_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅2_後翅.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅2_後翅.Dra = value;
				this.X0Y1_後翅_後翅2_後翅.Dra = value;
				this.X0Y0_後翅_後翅2_後翅.Hit = value;
				this.X0Y1_後翅_後翅2_後翅.Hit = value;
			}
		}

		public bool 後翅_後翅2_翅脈1_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅2_翅脈1.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅2_翅脈1.Dra = value;
				this.X0Y1_後翅_後翅2_翅脈1.Dra = value;
				this.X0Y0_後翅_後翅2_翅脈1.Hit = value;
				this.X0Y1_後翅_後翅2_翅脈1.Hit = value;
			}
		}

		public bool 後翅_後翅2_翅脈2_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅2_翅脈2.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅2_翅脈2.Dra = value;
				this.X0Y1_後翅_後翅2_翅脈2.Dra = value;
				this.X0Y0_後翅_後翅2_翅脈2.Hit = value;
				this.X0Y1_後翅_後翅2_翅脈2.Hit = value;
			}
		}

		public bool 後翅_後翅2_翅脈3_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅2_翅脈3.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅2_翅脈3.Dra = value;
				this.X0Y1_後翅_後翅2_翅脈3.Dra = value;
				this.X0Y0_後翅_後翅2_翅脈3.Hit = value;
				this.X0Y1_後翅_後翅2_翅脈3.Hit = value;
			}
		}

		public bool 後翅_後翅3_後翅_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅3_後翅.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅3_後翅.Dra = value;
				this.X0Y1_後翅_後翅3_後翅.Dra = value;
				this.X0Y0_後翅_後翅3_後翅.Hit = value;
				this.X0Y1_後翅_後翅3_後翅.Hit = value;
			}
		}

		public bool 後翅_後翅3_翅脈1_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅3_翅脈1.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅3_翅脈1.Dra = value;
				this.X0Y1_後翅_後翅3_翅脈1.Dra = value;
				this.X0Y0_後翅_後翅3_翅脈1.Hit = value;
				this.X0Y1_後翅_後翅3_翅脈1.Hit = value;
			}
		}

		public bool 後翅_後翅3_翅脈2_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅3_翅脈2.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅3_翅脈2.Dra = value;
				this.X0Y1_後翅_後翅3_翅脈2.Dra = value;
				this.X0Y0_後翅_後翅3_翅脈2.Hit = value;
				this.X0Y1_後翅_後翅3_翅脈2.Hit = value;
			}
		}

		public bool 後翅_後翅3_翅脈3_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅3_翅脈3.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅3_翅脈3.Dra = value;
				this.X0Y1_後翅_後翅3_翅脈3.Dra = value;
				this.X0Y0_後翅_後翅3_翅脈3.Hit = value;
				this.X0Y1_後翅_後翅3_翅脈3.Hit = value;
			}
		}

		public bool 後翅_後翅4_後翅_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅4_後翅.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅4_後翅.Dra = value;
				this.X0Y1_後翅_後翅4_後翅.Dra = value;
				this.X0Y0_後翅_後翅4_後翅.Hit = value;
				this.X0Y1_後翅_後翅4_後翅.Hit = value;
			}
		}

		public bool 後翅_後翅4_翅脈1_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅4_翅脈1.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅4_翅脈1.Dra = value;
				this.X0Y1_後翅_後翅4_翅脈1.Dra = value;
				this.X0Y0_後翅_後翅4_翅脈1.Hit = value;
				this.X0Y1_後翅_後翅4_翅脈1.Hit = value;
			}
		}

		public bool 後翅_後翅4_翅脈2_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅4_翅脈2.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅4_翅脈2.Dra = value;
				this.X0Y1_後翅_後翅4_翅脈2.Dra = value;
				this.X0Y0_後翅_後翅4_翅脈2.Hit = value;
				this.X0Y1_後翅_後翅4_翅脈2.Hit = value;
			}
		}

		public bool 後翅_後翅4_翅脈3_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅4_翅脈3.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅4_翅脈3.Dra = value;
				this.X0Y1_後翅_後翅4_翅脈3.Dra = value;
				this.X0Y0_後翅_後翅4_翅脈3.Hit = value;
				this.X0Y1_後翅_後翅4_翅脈3.Hit = value;
			}
		}

		public bool 後翅_後翅5_後翅_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅5_後翅.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅5_後翅.Dra = value;
				this.X0Y1_後翅_後翅5_後翅.Dra = value;
				this.X0Y0_後翅_後翅5_後翅.Hit = value;
				this.X0Y1_後翅_後翅5_後翅.Hit = value;
			}
		}

		public bool 後翅_後翅5_翅脈1_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅5_翅脈1.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅5_翅脈1.Dra = value;
				this.X0Y1_後翅_後翅5_翅脈1.Dra = value;
				this.X0Y0_後翅_後翅5_翅脈1.Hit = value;
				this.X0Y1_後翅_後翅5_翅脈1.Hit = value;
			}
		}

		public bool 後翅_後翅5_翅脈2_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅5_翅脈2.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅5_翅脈2.Dra = value;
				this.X0Y1_後翅_後翅5_翅脈2.Dra = value;
				this.X0Y0_後翅_後翅5_翅脈2.Hit = value;
				this.X0Y1_後翅_後翅5_翅脈2.Hit = value;
			}
		}

		public bool 後翅_後翅5_翅脈3_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅5_翅脈3.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅5_翅脈3.Dra = value;
				this.X0Y1_後翅_後翅5_翅脈3.Dra = value;
				this.X0Y0_後翅_後翅5_翅脈3.Hit = value;
				this.X0Y1_後翅_後翅5_翅脈3.Hit = value;
			}
		}

		public bool 後翅_後翅6_後翅_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅6_後翅.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅6_後翅.Dra = value;
				this.X0Y1_後翅_後翅6_後翅.Dra = value;
				this.X0Y0_後翅_後翅6_後翅.Hit = value;
				this.X0Y1_後翅_後翅6_後翅.Hit = value;
			}
		}

		public bool 後翅_後翅6_翅脈1_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅6_翅脈1.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅6_翅脈1.Dra = value;
				this.X0Y1_後翅_後翅6_翅脈1.Dra = value;
				this.X0Y0_後翅_後翅6_翅脈1.Hit = value;
				this.X0Y1_後翅_後翅6_翅脈1.Hit = value;
			}
		}

		public bool 後翅_後翅6_翅脈2_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅6_翅脈2.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅6_翅脈2.Dra = value;
				this.X0Y1_後翅_後翅6_翅脈2.Dra = value;
				this.X0Y0_後翅_後翅6_翅脈2.Hit = value;
				this.X0Y1_後翅_後翅6_翅脈2.Hit = value;
			}
		}

		public bool 後翅_後翅6_翅脈3_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅6_翅脈3.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅6_翅脈3.Dra = value;
				this.X0Y1_後翅_後翅6_翅脈3.Dra = value;
				this.X0Y0_後翅_後翅6_翅脈3.Hit = value;
				this.X0Y1_後翅_後翅6_翅脈3.Hit = value;
			}
		}

		public bool 後翅_後翅7_後翅_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅7_後翅.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅7_後翅.Dra = value;
				this.X0Y1_後翅_後翅7_後翅.Dra = value;
				this.X0Y0_後翅_後翅7_後翅.Hit = value;
				this.X0Y1_後翅_後翅7_後翅.Hit = value;
			}
		}

		public bool 後翅_後翅7_翅脈1_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅7_翅脈1.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅7_翅脈1.Dra = value;
				this.X0Y1_後翅_後翅7_翅脈1.Dra = value;
				this.X0Y0_後翅_後翅7_翅脈1.Hit = value;
				this.X0Y1_後翅_後翅7_翅脈1.Hit = value;
			}
		}

		public bool 後翅_後翅7_翅脈2_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅7_翅脈2.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅7_翅脈2.Dra = value;
				this.X0Y1_後翅_後翅7_翅脈2.Dra = value;
				this.X0Y0_後翅_後翅7_翅脈2.Hit = value;
				this.X0Y1_後翅_後翅7_翅脈2.Hit = value;
			}
		}

		public bool 後翅_後翅7_翅脈3_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅7_翅脈3.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅7_翅脈3.Dra = value;
				this.X0Y1_後翅_後翅7_翅脈3.Dra = value;
				this.X0Y0_後翅_後翅7_翅脈3.Hit = value;
				this.X0Y1_後翅_後翅7_翅脈3.Hit = value;
			}
		}

		public bool 後翅_後翅8_後翅_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅8_後翅.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅8_後翅.Dra = value;
				this.X0Y1_後翅_後翅8_後翅.Dra = value;
				this.X0Y0_後翅_後翅8_後翅.Hit = value;
				this.X0Y1_後翅_後翅8_後翅.Hit = value;
			}
		}

		public bool 後翅_後翅8_翅脈1_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅8_翅脈1.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅8_翅脈1.Dra = value;
				this.X0Y1_後翅_後翅8_翅脈1.Dra = value;
				this.X0Y0_後翅_後翅8_翅脈1.Hit = value;
				this.X0Y1_後翅_後翅8_翅脈1.Hit = value;
			}
		}

		public bool 後翅_後翅8_翅脈2_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅8_翅脈2.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅8_翅脈2.Dra = value;
				this.X0Y1_後翅_後翅8_翅脈2.Dra = value;
				this.X0Y0_後翅_後翅8_翅脈2.Hit = value;
				this.X0Y1_後翅_後翅8_翅脈2.Hit = value;
			}
		}

		public bool 後翅_後翅8_翅脈3_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅8_翅脈3.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅8_翅脈3.Dra = value;
				this.X0Y1_後翅_後翅8_翅脈3.Dra = value;
				this.X0Y0_後翅_後翅8_翅脈3.Hit = value;
				this.X0Y1_後翅_後翅8_翅脈3.Hit = value;
			}
		}

		public bool 後翅_後翅9_後翅_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅9_後翅.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅9_後翅.Dra = value;
				this.X0Y1_後翅_後翅9_後翅.Dra = value;
				this.X0Y0_後翅_後翅9_後翅.Hit = value;
				this.X0Y1_後翅_後翅9_後翅.Hit = value;
			}
		}

		public bool 後翅_後翅9_翅脈1_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅9_翅脈1.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅9_翅脈1.Dra = value;
				this.X0Y1_後翅_後翅9_翅脈1.Dra = value;
				this.X0Y0_後翅_後翅9_翅脈1.Hit = value;
				this.X0Y1_後翅_後翅9_翅脈1.Hit = value;
			}
		}

		public bool 後翅_後翅9_翅脈2_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅9_翅脈2.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅9_翅脈2.Dra = value;
				this.X0Y1_後翅_後翅9_翅脈2.Dra = value;
				this.X0Y0_後翅_後翅9_翅脈2.Hit = value;
				this.X0Y1_後翅_後翅9_翅脈2.Hit = value;
			}
		}

		public bool 後翅_後翅9_翅脈3_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅9_翅脈3.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅9_翅脈3.Dra = value;
				this.X0Y1_後翅_後翅9_翅脈3.Dra = value;
				this.X0Y0_後翅_後翅9_翅脈3.Hit = value;
				this.X0Y1_後翅_後翅9_翅脈3.Hit = value;
			}
		}

		public bool 後翅_後翅10_後翅_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅10_後翅.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅10_後翅.Dra = value;
				this.X0Y1_後翅_後翅10_後翅.Dra = value;
				this.X0Y0_後翅_後翅10_後翅.Hit = value;
				this.X0Y1_後翅_後翅10_後翅.Hit = value;
			}
		}

		public bool 後翅_後翅10_翅脈1_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅10_翅脈1.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅10_翅脈1.Dra = value;
				this.X0Y1_後翅_後翅10_翅脈1.Dra = value;
				this.X0Y0_後翅_後翅10_翅脈1.Hit = value;
				this.X0Y1_後翅_後翅10_翅脈1.Hit = value;
			}
		}

		public bool 後翅_後翅10_翅脈2_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅10_翅脈2.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅10_翅脈2.Dra = value;
				this.X0Y1_後翅_後翅10_翅脈2.Dra = value;
				this.X0Y0_後翅_後翅10_翅脈2.Hit = value;
				this.X0Y1_後翅_後翅10_翅脈2.Hit = value;
			}
		}

		public bool 後翅_後翅10_翅脈3_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅10_翅脈3.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅10_翅脈3.Dra = value;
				this.X0Y1_後翅_後翅10_翅脈3.Dra = value;
				this.X0Y0_後翅_後翅10_翅脈3.Hit = value;
				this.X0Y1_後翅_後翅10_翅脈3.Hit = value;
			}
		}

		public bool 後翅_後翅11_後翅_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅11_後翅.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅11_後翅.Dra = value;
				this.X0Y1_後翅_後翅11_後翅.Dra = value;
				this.X0Y0_後翅_後翅11_後翅.Hit = value;
				this.X0Y1_後翅_後翅11_後翅.Hit = value;
			}
		}

		public bool 後翅_後翅11_翅脈1_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅11_翅脈1.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅11_翅脈1.Dra = value;
				this.X0Y1_後翅_後翅11_翅脈1.Dra = value;
				this.X0Y0_後翅_後翅11_翅脈1.Hit = value;
				this.X0Y1_後翅_後翅11_翅脈1.Hit = value;
			}
		}

		public bool 後翅_後翅11_翅脈2_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅11_翅脈2.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅11_翅脈2.Dra = value;
				this.X0Y1_後翅_後翅11_翅脈2.Dra = value;
				this.X0Y0_後翅_後翅11_翅脈2.Hit = value;
				this.X0Y1_後翅_後翅11_翅脈2.Hit = value;
			}
		}

		public bool 後翅_後翅11_翅脈3_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅11_翅脈3.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅11_翅脈3.Dra = value;
				this.X0Y1_後翅_後翅11_翅脈3.Dra = value;
				this.X0Y0_後翅_後翅11_翅脈3.Hit = value;
				this.X0Y1_後翅_後翅11_翅脈3.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.後翅_後翅1_後翅_表示;
			}
			set
			{
				this.後翅_後翅1_後翅_表示 = value;
				this.後翅_後翅1_翅脈1_表示 = value;
				this.後翅_後翅1_翅脈2_表示 = value;
				this.後翅_後翅1_翅脈3_表示 = value;
				this.後翅_後翅2_後翅_表示 = value;
				this.後翅_後翅2_翅脈1_表示 = value;
				this.後翅_後翅2_翅脈2_表示 = value;
				this.後翅_後翅2_翅脈3_表示 = value;
				this.後翅_後翅3_後翅_表示 = value;
				this.後翅_後翅3_翅脈1_表示 = value;
				this.後翅_後翅3_翅脈2_表示 = value;
				this.後翅_後翅3_翅脈3_表示 = value;
				this.後翅_後翅4_後翅_表示 = value;
				this.後翅_後翅4_翅脈1_表示 = value;
				this.後翅_後翅4_翅脈2_表示 = value;
				this.後翅_後翅4_翅脈3_表示 = value;
				this.後翅_後翅5_後翅_表示 = value;
				this.後翅_後翅5_翅脈1_表示 = value;
				this.後翅_後翅5_翅脈2_表示 = value;
				this.後翅_後翅5_翅脈3_表示 = value;
				this.後翅_後翅6_後翅_表示 = value;
				this.後翅_後翅6_翅脈1_表示 = value;
				this.後翅_後翅6_翅脈2_表示 = value;
				this.後翅_後翅6_翅脈3_表示 = value;
				this.後翅_後翅7_後翅_表示 = value;
				this.後翅_後翅7_翅脈1_表示 = value;
				this.後翅_後翅7_翅脈2_表示 = value;
				this.後翅_後翅7_翅脈3_表示 = value;
				this.後翅_後翅8_後翅_表示 = value;
				this.後翅_後翅8_翅脈1_表示 = value;
				this.後翅_後翅8_翅脈2_表示 = value;
				this.後翅_後翅8_翅脈3_表示 = value;
				this.後翅_後翅9_後翅_表示 = value;
				this.後翅_後翅9_翅脈1_表示 = value;
				this.後翅_後翅9_翅脈2_表示 = value;
				this.後翅_後翅9_翅脈3_表示 = value;
				this.後翅_後翅10_後翅_表示 = value;
				this.後翅_後翅10_翅脈1_表示 = value;
				this.後翅_後翅10_翅脈2_表示 = value;
				this.後翅_後翅10_翅脈3_表示 = value;
				this.後翅_後翅11_後翅_表示 = value;
				this.後翅_後翅11_翅脈1_表示 = value;
				this.後翅_後翅11_翅脈2_表示 = value;
				this.後翅_後翅11_翅脈3_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.後翅_後翅1_後翅CD.不透明度;
			}
			set
			{
				this.後翅_後翅1_後翅CD.不透明度 = value;
				this.後翅_後翅1_翅脈1CD.不透明度 = value;
				this.後翅_後翅1_翅脈2CD.不透明度 = value;
				this.後翅_後翅1_翅脈3CD.不透明度 = value;
				this.後翅_後翅2_後翅CD.不透明度 = value;
				this.後翅_後翅2_翅脈1CD.不透明度 = value;
				this.後翅_後翅2_翅脈2CD.不透明度 = value;
				this.後翅_後翅2_翅脈3CD.不透明度 = value;
				this.後翅_後翅3_後翅CD.不透明度 = value;
				this.後翅_後翅3_翅脈1CD.不透明度 = value;
				this.後翅_後翅3_翅脈2CD.不透明度 = value;
				this.後翅_後翅3_翅脈3CD.不透明度 = value;
				this.後翅_後翅4_後翅CD.不透明度 = value;
				this.後翅_後翅4_翅脈1CD.不透明度 = value;
				this.後翅_後翅4_翅脈2CD.不透明度 = value;
				this.後翅_後翅4_翅脈3CD.不透明度 = value;
				this.後翅_後翅5_後翅CD.不透明度 = value;
				this.後翅_後翅5_翅脈1CD.不透明度 = value;
				this.後翅_後翅5_翅脈2CD.不透明度 = value;
				this.後翅_後翅5_翅脈3CD.不透明度 = value;
				this.後翅_後翅6_後翅CD.不透明度 = value;
				this.後翅_後翅6_翅脈1CD.不透明度 = value;
				this.後翅_後翅6_翅脈2CD.不透明度 = value;
				this.後翅_後翅6_翅脈3CD.不透明度 = value;
				this.後翅_後翅7_後翅CD.不透明度 = value;
				this.後翅_後翅7_翅脈1CD.不透明度 = value;
				this.後翅_後翅7_翅脈2CD.不透明度 = value;
				this.後翅_後翅7_翅脈3CD.不透明度 = value;
				this.後翅_後翅8_後翅CD.不透明度 = value;
				this.後翅_後翅8_翅脈1CD.不透明度 = value;
				this.後翅_後翅8_翅脈2CD.不透明度 = value;
				this.後翅_後翅8_翅脈3CD.不透明度 = value;
				this.後翅_後翅9_後翅CD.不透明度 = value;
				this.後翅_後翅9_翅脈1CD.不透明度 = value;
				this.後翅_後翅9_翅脈2CD.不透明度 = value;
				this.後翅_後翅9_翅脈3CD.不透明度 = value;
				this.後翅_後翅10_後翅CD.不透明度 = value;
				this.後翅_後翅10_翅脈1CD.不透明度 = value;
				this.後翅_後翅10_翅脈2CD.不透明度 = value;
				this.後翅_後翅10_翅脈3CD.不透明度 = value;
				this.後翅_後翅11_後翅CD.不透明度 = value;
				this.後翅_後翅11_翅脈1CD.不透明度 = value;
				this.後翅_後翅11_翅脈2CD.不透明度 = value;
				this.後翅_後翅11_翅脈3CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			double num = this.右 ? -1.0 : 1.0;
			this.X0Y0_後翅_後翅1_後翅.AngleBase = num * 0.0;
			this.X0Y1_後翅_後翅1_後翅.AngleBase = num * 0.0;
			this.本体.JoinPAall();
		}

		public double 展開
		{
			set
			{
				double num = value.Inverse();
				double num2 = this.右 ? -1.0 : 1.0;
				this.X0Y0_後翅_後翅1_後翅.AngleCont = num2 * -88.0 * num;
				this.X0Y0_後翅_後翅2_後翅.AngleCont = num2 * 8.2 * num;
				this.X0Y0_後翅_後翅3_後翅.AngleCont = num2 * 16.5 * num;
				this.X0Y0_後翅_後翅4_後翅.AngleCont = num2 * 24.5 * num;
				this.X0Y0_後翅_後翅5_後翅.AngleCont = num2 * 32.5 * num;
				this.X0Y0_後翅_後翅6_後翅.AngleCont = num2 * 40.5 * num;
				this.X0Y0_後翅_後翅7_後翅.AngleCont = num2 * 48.5 * num;
				this.X0Y0_後翅_後翅8_後翅.AngleCont = num2 * 56.5 * num;
				this.X0Y0_後翅_後翅9_後翅.AngleCont = num2 * 64.5 * num;
				this.X0Y0_後翅_後翅10_後翅.AngleCont = num2 * 72.5 * num;
				this.X0Y0_後翅_後翅11_後翅.AngleCont = num2 * 80.5 * num;
				this.X0Y1_後翅_後翅1_後翅.AngleCont = num2 * -88.0 * num;
				this.X0Y1_後翅_後翅2_後翅.AngleCont = num2 * 8.2 * num;
				this.X0Y1_後翅_後翅3_後翅.AngleCont = num2 * 16.5 * num;
				this.X0Y1_後翅_後翅4_後翅.AngleCont = num2 * 24.5 * num;
				this.X0Y1_後翅_後翅5_後翅.AngleCont = num2 * 32.5 * num;
				this.X0Y1_後翅_後翅6_後翅.AngleCont = num2 * 40.5 * num;
				this.X0Y1_後翅_後翅7_後翅.AngleCont = num2 * 48.5 * num;
				this.X0Y1_後翅_後翅8_後翅.AngleCont = num2 * 56.5 * num;
				this.X0Y1_後翅_後翅9_後翅.AngleCont = num2 * 64.5 * num;
				this.X0Y1_後翅_後翅10_後翅.AngleCont = num2 * 72.5 * num;
				this.X0Y1_後翅_後翅11_後翅.AngleCont = num2 * 80.5 * num;
			}
		}

		public override void 色更新()
		{
			if (this.本体.IndexY == 0)
			{
				this.X0Y0_後翅_後翅1_後翅CP.Update();
				this.X0Y0_後翅_後翅1_翅脈1CP.Update();
				this.X0Y0_後翅_後翅1_翅脈2CP.Update();
				this.X0Y0_後翅_後翅1_翅脈3CP.Update();
				this.X0Y0_後翅_後翅2_後翅CP.Update();
				this.X0Y0_後翅_後翅2_翅脈1CP.Update();
				this.X0Y0_後翅_後翅2_翅脈2CP.Update();
				this.X0Y0_後翅_後翅2_翅脈3CP.Update();
				this.X0Y0_後翅_後翅3_後翅CP.Update();
				this.X0Y0_後翅_後翅3_翅脈1CP.Update();
				this.X0Y0_後翅_後翅3_翅脈2CP.Update();
				this.X0Y0_後翅_後翅3_翅脈3CP.Update();
				this.X0Y0_後翅_後翅4_後翅CP.Update();
				this.X0Y0_後翅_後翅4_翅脈1CP.Update();
				this.X0Y0_後翅_後翅4_翅脈2CP.Update();
				this.X0Y0_後翅_後翅4_翅脈3CP.Update();
				this.X0Y0_後翅_後翅5_後翅CP.Update();
				this.X0Y0_後翅_後翅5_翅脈1CP.Update();
				this.X0Y0_後翅_後翅5_翅脈2CP.Update();
				this.X0Y0_後翅_後翅5_翅脈3CP.Update();
				this.X0Y0_後翅_後翅6_後翅CP.Update();
				this.X0Y0_後翅_後翅6_翅脈1CP.Update();
				this.X0Y0_後翅_後翅6_翅脈2CP.Update();
				this.X0Y0_後翅_後翅6_翅脈3CP.Update();
				this.X0Y0_後翅_後翅7_後翅CP.Update();
				this.X0Y0_後翅_後翅7_翅脈1CP.Update();
				this.X0Y0_後翅_後翅7_翅脈2CP.Update();
				this.X0Y0_後翅_後翅7_翅脈3CP.Update();
				this.X0Y0_後翅_後翅8_後翅CP.Update();
				this.X0Y0_後翅_後翅8_翅脈1CP.Update();
				this.X0Y0_後翅_後翅8_翅脈2CP.Update();
				this.X0Y0_後翅_後翅8_翅脈3CP.Update();
				this.X0Y0_後翅_後翅9_後翅CP.Update();
				this.X0Y0_後翅_後翅9_翅脈1CP.Update();
				this.X0Y0_後翅_後翅9_翅脈2CP.Update();
				this.X0Y0_後翅_後翅9_翅脈3CP.Update();
				this.X0Y0_後翅_後翅10_後翅CP.Update();
				this.X0Y0_後翅_後翅10_翅脈1CP.Update();
				this.X0Y0_後翅_後翅10_翅脈2CP.Update();
				this.X0Y0_後翅_後翅10_翅脈3CP.Update();
				this.X0Y0_後翅_後翅11_後翅CP.Update();
				this.X0Y0_後翅_後翅11_翅脈1CP.Update();
				this.X0Y0_後翅_後翅11_翅脈2CP.Update();
				this.X0Y0_後翅_後翅11_翅脈3CP.Update();
				return;
			}
			this.X0Y1_後翅_後翅1_後翅CP.Update();
			this.X0Y1_後翅_後翅1_翅脈1CP.Update();
			this.X0Y1_後翅_後翅1_翅脈2CP.Update();
			this.X0Y1_後翅_後翅1_翅脈3CP.Update();
			this.X0Y1_後翅_後翅2_後翅CP.Update();
			this.X0Y1_後翅_後翅2_翅脈1CP.Update();
			this.X0Y1_後翅_後翅2_翅脈2CP.Update();
			this.X0Y1_後翅_後翅2_翅脈3CP.Update();
			this.X0Y1_後翅_後翅3_後翅CP.Update();
			this.X0Y1_後翅_後翅3_翅脈1CP.Update();
			this.X0Y1_後翅_後翅3_翅脈2CP.Update();
			this.X0Y1_後翅_後翅3_翅脈3CP.Update();
			this.X0Y1_後翅_後翅4_後翅CP.Update();
			this.X0Y1_後翅_後翅4_翅脈1CP.Update();
			this.X0Y1_後翅_後翅4_翅脈2CP.Update();
			this.X0Y1_後翅_後翅4_翅脈3CP.Update();
			this.X0Y1_後翅_後翅5_後翅CP.Update();
			this.X0Y1_後翅_後翅5_翅脈1CP.Update();
			this.X0Y1_後翅_後翅5_翅脈2CP.Update();
			this.X0Y1_後翅_後翅5_翅脈3CP.Update();
			this.X0Y1_後翅_後翅6_後翅CP.Update();
			this.X0Y1_後翅_後翅6_翅脈1CP.Update();
			this.X0Y1_後翅_後翅6_翅脈2CP.Update();
			this.X0Y1_後翅_後翅6_翅脈3CP.Update();
			this.X0Y1_後翅_後翅7_後翅CP.Update();
			this.X0Y1_後翅_後翅7_翅脈1CP.Update();
			this.X0Y1_後翅_後翅7_翅脈2CP.Update();
			this.X0Y1_後翅_後翅7_翅脈3CP.Update();
			this.X0Y1_後翅_後翅8_後翅CP.Update();
			this.X0Y1_後翅_後翅8_翅脈1CP.Update();
			this.X0Y1_後翅_後翅8_翅脈2CP.Update();
			this.X0Y1_後翅_後翅8_翅脈3CP.Update();
			this.X0Y1_後翅_後翅9_後翅CP.Update();
			this.X0Y1_後翅_後翅9_翅脈1CP.Update();
			this.X0Y1_後翅_後翅9_翅脈2CP.Update();
			this.X0Y1_後翅_後翅9_翅脈3CP.Update();
			this.X0Y1_後翅_後翅10_後翅CP.Update();
			this.X0Y1_後翅_後翅10_翅脈1CP.Update();
			this.X0Y1_後翅_後翅10_翅脈2CP.Update();
			this.X0Y1_後翅_後翅10_翅脈3CP.Update();
			this.X0Y1_後翅_後翅11_後翅CP.Update();
			this.X0Y1_後翅_後翅11_翅脈1CP.Update();
			this.X0Y1_後翅_後翅11_翅脈2CP.Update();
			this.X0Y1_後翅_後翅11_翅脈3CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			Color2 color;
			Col.Alpha(ref 体配色.体1O, 128, out color);
			this.後翅_後翅1_後翅CD = new ColorD(ref Col.Black, ref color);
			Col.Alpha(ref 体配色.柄O, 128, out color);
			this.後翅_後翅1_翅脈1CD = new ColorD(ref Col.Black, ref color);
			this.後翅_後翅1_翅脈2CD = new ColorD(ref Col.Black, ref this.後翅_後翅1_翅脈1CD.c2);
			this.後翅_後翅1_翅脈3CD = new ColorD(ref Col.Black, ref this.後翅_後翅1_翅脈1CD.c2);
			this.後翅_後翅2_後翅CD = new ColorD(ref Col.Black, ref this.後翅_後翅1_後翅CD.c2);
			this.後翅_後翅2_翅脈1CD = new ColorD(ref Col.Black, ref this.後翅_後翅1_翅脈1CD.c2);
			this.後翅_後翅2_翅脈2CD = new ColorD(ref Col.Black, ref this.後翅_後翅1_翅脈1CD.c2);
			this.後翅_後翅2_翅脈3CD = new ColorD(ref Col.Black, ref this.後翅_後翅1_翅脈1CD.c2);
			this.後翅_後翅3_後翅CD = new ColorD(ref Col.Black, ref this.後翅_後翅1_後翅CD.c2);
			this.後翅_後翅3_翅脈1CD = new ColorD(ref Col.Black, ref this.後翅_後翅1_翅脈1CD.c2);
			this.後翅_後翅3_翅脈2CD = new ColorD(ref Col.Black, ref this.後翅_後翅1_翅脈1CD.c2);
			this.後翅_後翅3_翅脈3CD = new ColorD(ref Col.Black, ref this.後翅_後翅1_翅脈1CD.c2);
			this.後翅_後翅4_後翅CD = new ColorD(ref Col.Black, ref this.後翅_後翅1_後翅CD.c2);
			this.後翅_後翅4_翅脈1CD = new ColorD(ref Col.Black, ref this.後翅_後翅1_翅脈1CD.c2);
			this.後翅_後翅4_翅脈2CD = new ColorD(ref Col.Black, ref this.後翅_後翅1_翅脈1CD.c2);
			this.後翅_後翅4_翅脈3CD = new ColorD(ref Col.Black, ref this.後翅_後翅1_翅脈1CD.c2);
			this.後翅_後翅5_後翅CD = new ColorD(ref Col.Black, ref this.後翅_後翅1_後翅CD.c2);
			this.後翅_後翅5_翅脈1CD = new ColorD(ref Col.Black, ref this.後翅_後翅1_翅脈1CD.c2);
			this.後翅_後翅5_翅脈2CD = new ColorD(ref Col.Black, ref this.後翅_後翅1_翅脈1CD.c2);
			this.後翅_後翅5_翅脈3CD = new ColorD(ref Col.Black, ref this.後翅_後翅1_翅脈1CD.c2);
			this.後翅_後翅6_後翅CD = new ColorD(ref Col.Black, ref this.後翅_後翅1_後翅CD.c2);
			this.後翅_後翅6_翅脈1CD = new ColorD(ref Col.Black, ref this.後翅_後翅1_翅脈1CD.c2);
			this.後翅_後翅6_翅脈2CD = new ColorD(ref Col.Black, ref this.後翅_後翅1_翅脈1CD.c2);
			this.後翅_後翅6_翅脈3CD = new ColorD(ref Col.Black, ref this.後翅_後翅1_翅脈1CD.c2);
			this.後翅_後翅7_後翅CD = new ColorD(ref Col.Black, ref this.後翅_後翅1_後翅CD.c2);
			this.後翅_後翅7_翅脈1CD = new ColorD(ref Col.Black, ref this.後翅_後翅1_翅脈1CD.c2);
			this.後翅_後翅7_翅脈2CD = new ColorD(ref Col.Black, ref this.後翅_後翅1_翅脈1CD.c2);
			this.後翅_後翅7_翅脈3CD = new ColorD(ref Col.Black, ref this.後翅_後翅1_翅脈1CD.c2);
			this.後翅_後翅8_後翅CD = new ColorD(ref Col.Black, ref this.後翅_後翅1_後翅CD.c2);
			this.後翅_後翅8_翅脈1CD = new ColorD(ref Col.Black, ref this.後翅_後翅1_翅脈1CD.c2);
			this.後翅_後翅8_翅脈2CD = new ColorD(ref Col.Black, ref this.後翅_後翅1_翅脈1CD.c2);
			this.後翅_後翅8_翅脈3CD = new ColorD(ref Col.Black, ref this.後翅_後翅1_翅脈1CD.c2);
			this.後翅_後翅9_後翅CD = new ColorD(ref Col.Black, ref this.後翅_後翅1_後翅CD.c2);
			this.後翅_後翅9_翅脈1CD = new ColorD(ref Col.Black, ref this.後翅_後翅1_翅脈1CD.c2);
			this.後翅_後翅9_翅脈2CD = new ColorD(ref Col.Black, ref this.後翅_後翅1_翅脈1CD.c2);
			this.後翅_後翅9_翅脈3CD = new ColorD(ref Col.Black, ref this.後翅_後翅1_翅脈1CD.c2);
			this.後翅_後翅10_後翅CD = new ColorD(ref Col.Black, ref this.後翅_後翅1_後翅CD.c2);
			this.後翅_後翅10_翅脈1CD = new ColorD(ref Col.Black, ref this.後翅_後翅1_翅脈1CD.c2);
			this.後翅_後翅10_翅脈2CD = new ColorD(ref Col.Black, ref this.後翅_後翅1_翅脈1CD.c2);
			this.後翅_後翅10_翅脈3CD = new ColorD(ref Col.Black, ref this.後翅_後翅1_翅脈1CD.c2);
			this.後翅_後翅11_後翅CD = new ColorD(ref Col.Black, ref this.後翅_後翅1_後翅CD.c2);
			this.後翅_後翅11_翅脈1CD = new ColorD(ref Col.Black, ref this.後翅_後翅1_翅脈1CD.c2);
			this.後翅_後翅11_翅脈2CD = new ColorD(ref Col.Black, ref this.後翅_後翅1_翅脈1CD.c2);
			this.後翅_後翅11_翅脈3CD = new ColorD(ref Col.Black, ref this.後翅_後翅1_翅脈1CD.c2);
		}

		public Par X0Y0_後翅_後翅1_後翅;

		public Par X0Y0_後翅_後翅1_翅脈1;

		public Par X0Y0_後翅_後翅1_翅脈2;

		public Par X0Y0_後翅_後翅1_翅脈3;

		public Par X0Y0_後翅_後翅2_後翅;

		public Par X0Y0_後翅_後翅2_翅脈1;

		public Par X0Y0_後翅_後翅2_翅脈2;

		public Par X0Y0_後翅_後翅2_翅脈3;

		public Par X0Y0_後翅_後翅3_後翅;

		public Par X0Y0_後翅_後翅3_翅脈1;

		public Par X0Y0_後翅_後翅3_翅脈2;

		public Par X0Y0_後翅_後翅3_翅脈3;

		public Par X0Y0_後翅_後翅4_後翅;

		public Par X0Y0_後翅_後翅4_翅脈1;

		public Par X0Y0_後翅_後翅4_翅脈2;

		public Par X0Y0_後翅_後翅4_翅脈3;

		public Par X0Y0_後翅_後翅5_後翅;

		public Par X0Y0_後翅_後翅5_翅脈1;

		public Par X0Y0_後翅_後翅5_翅脈2;

		public Par X0Y0_後翅_後翅5_翅脈3;

		public Par X0Y0_後翅_後翅6_後翅;

		public Par X0Y0_後翅_後翅6_翅脈1;

		public Par X0Y0_後翅_後翅6_翅脈2;

		public Par X0Y0_後翅_後翅6_翅脈3;

		public Par X0Y0_後翅_後翅7_後翅;

		public Par X0Y0_後翅_後翅7_翅脈1;

		public Par X0Y0_後翅_後翅7_翅脈2;

		public Par X0Y0_後翅_後翅7_翅脈3;

		public Par X0Y0_後翅_後翅8_後翅;

		public Par X0Y0_後翅_後翅8_翅脈1;

		public Par X0Y0_後翅_後翅8_翅脈2;

		public Par X0Y0_後翅_後翅8_翅脈3;

		public Par X0Y0_後翅_後翅9_後翅;

		public Par X0Y0_後翅_後翅9_翅脈1;

		public Par X0Y0_後翅_後翅9_翅脈2;

		public Par X0Y0_後翅_後翅9_翅脈3;

		public Par X0Y0_後翅_後翅10_後翅;

		public Par X0Y0_後翅_後翅10_翅脈1;

		public Par X0Y0_後翅_後翅10_翅脈2;

		public Par X0Y0_後翅_後翅10_翅脈3;

		public Par X0Y0_後翅_後翅11_後翅;

		public Par X0Y0_後翅_後翅11_翅脈1;

		public Par X0Y0_後翅_後翅11_翅脈2;

		public Par X0Y0_後翅_後翅11_翅脈3;

		public Par X0Y1_後翅_後翅1_後翅;

		public Par X0Y1_後翅_後翅1_翅脈1;

		public Par X0Y1_後翅_後翅1_翅脈2;

		public Par X0Y1_後翅_後翅1_翅脈3;

		public Par X0Y1_後翅_後翅2_後翅;

		public Par X0Y1_後翅_後翅2_翅脈1;

		public Par X0Y1_後翅_後翅2_翅脈2;

		public Par X0Y1_後翅_後翅2_翅脈3;

		public Par X0Y1_後翅_後翅3_後翅;

		public Par X0Y1_後翅_後翅3_翅脈1;

		public Par X0Y1_後翅_後翅3_翅脈2;

		public Par X0Y1_後翅_後翅3_翅脈3;

		public Par X0Y1_後翅_後翅4_後翅;

		public Par X0Y1_後翅_後翅4_翅脈1;

		public Par X0Y1_後翅_後翅4_翅脈2;

		public Par X0Y1_後翅_後翅4_翅脈3;

		public Par X0Y1_後翅_後翅5_後翅;

		public Par X0Y1_後翅_後翅5_翅脈1;

		public Par X0Y1_後翅_後翅5_翅脈2;

		public Par X0Y1_後翅_後翅5_翅脈3;

		public Par X0Y1_後翅_後翅6_後翅;

		public Par X0Y1_後翅_後翅6_翅脈1;

		public Par X0Y1_後翅_後翅6_翅脈2;

		public Par X0Y1_後翅_後翅6_翅脈3;

		public Par X0Y1_後翅_後翅7_後翅;

		public Par X0Y1_後翅_後翅7_翅脈1;

		public Par X0Y1_後翅_後翅7_翅脈2;

		public Par X0Y1_後翅_後翅7_翅脈3;

		public Par X0Y1_後翅_後翅8_後翅;

		public Par X0Y1_後翅_後翅8_翅脈1;

		public Par X0Y1_後翅_後翅8_翅脈2;

		public Par X0Y1_後翅_後翅8_翅脈3;

		public Par X0Y1_後翅_後翅9_後翅;

		public Par X0Y1_後翅_後翅9_翅脈1;

		public Par X0Y1_後翅_後翅9_翅脈2;

		public Par X0Y1_後翅_後翅9_翅脈3;

		public Par X0Y1_後翅_後翅10_後翅;

		public Par X0Y1_後翅_後翅10_翅脈1;

		public Par X0Y1_後翅_後翅10_翅脈2;

		public Par X0Y1_後翅_後翅10_翅脈3;

		public Par X0Y1_後翅_後翅11_後翅;

		public Par X0Y1_後翅_後翅11_翅脈1;

		public Par X0Y1_後翅_後翅11_翅脈2;

		public Par X0Y1_後翅_後翅11_翅脈3;

		public ColorD 後翅_後翅1_後翅CD;

		public ColorD 後翅_後翅1_翅脈1CD;

		public ColorD 後翅_後翅1_翅脈2CD;

		public ColorD 後翅_後翅1_翅脈3CD;

		public ColorD 後翅_後翅2_後翅CD;

		public ColorD 後翅_後翅2_翅脈1CD;

		public ColorD 後翅_後翅2_翅脈2CD;

		public ColorD 後翅_後翅2_翅脈3CD;

		public ColorD 後翅_後翅3_後翅CD;

		public ColorD 後翅_後翅3_翅脈1CD;

		public ColorD 後翅_後翅3_翅脈2CD;

		public ColorD 後翅_後翅3_翅脈3CD;

		public ColorD 後翅_後翅4_後翅CD;

		public ColorD 後翅_後翅4_翅脈1CD;

		public ColorD 後翅_後翅4_翅脈2CD;

		public ColorD 後翅_後翅4_翅脈3CD;

		public ColorD 後翅_後翅5_後翅CD;

		public ColorD 後翅_後翅5_翅脈1CD;

		public ColorD 後翅_後翅5_翅脈2CD;

		public ColorD 後翅_後翅5_翅脈3CD;

		public ColorD 後翅_後翅6_後翅CD;

		public ColorD 後翅_後翅6_翅脈1CD;

		public ColorD 後翅_後翅6_翅脈2CD;

		public ColorD 後翅_後翅6_翅脈3CD;

		public ColorD 後翅_後翅7_後翅CD;

		public ColorD 後翅_後翅7_翅脈1CD;

		public ColorD 後翅_後翅7_翅脈2CD;

		public ColorD 後翅_後翅7_翅脈3CD;

		public ColorD 後翅_後翅8_後翅CD;

		public ColorD 後翅_後翅8_翅脈1CD;

		public ColorD 後翅_後翅8_翅脈2CD;

		public ColorD 後翅_後翅8_翅脈3CD;

		public ColorD 後翅_後翅9_後翅CD;

		public ColorD 後翅_後翅9_翅脈1CD;

		public ColorD 後翅_後翅9_翅脈2CD;

		public ColorD 後翅_後翅9_翅脈3CD;

		public ColorD 後翅_後翅10_後翅CD;

		public ColorD 後翅_後翅10_翅脈1CD;

		public ColorD 後翅_後翅10_翅脈2CD;

		public ColorD 後翅_後翅10_翅脈3CD;

		public ColorD 後翅_後翅11_後翅CD;

		public ColorD 後翅_後翅11_翅脈1CD;

		public ColorD 後翅_後翅11_翅脈2CD;

		public ColorD 後翅_後翅11_翅脈3CD;

		public ColorP X0Y0_後翅_後翅1_後翅CP;

		public ColorP X0Y0_後翅_後翅1_翅脈1CP;

		public ColorP X0Y0_後翅_後翅1_翅脈2CP;

		public ColorP X0Y0_後翅_後翅1_翅脈3CP;

		public ColorP X0Y0_後翅_後翅2_後翅CP;

		public ColorP X0Y0_後翅_後翅2_翅脈1CP;

		public ColorP X0Y0_後翅_後翅2_翅脈2CP;

		public ColorP X0Y0_後翅_後翅2_翅脈3CP;

		public ColorP X0Y0_後翅_後翅3_後翅CP;

		public ColorP X0Y0_後翅_後翅3_翅脈1CP;

		public ColorP X0Y0_後翅_後翅3_翅脈2CP;

		public ColorP X0Y0_後翅_後翅3_翅脈3CP;

		public ColorP X0Y0_後翅_後翅4_後翅CP;

		public ColorP X0Y0_後翅_後翅4_翅脈1CP;

		public ColorP X0Y0_後翅_後翅4_翅脈2CP;

		public ColorP X0Y0_後翅_後翅4_翅脈3CP;

		public ColorP X0Y0_後翅_後翅5_後翅CP;

		public ColorP X0Y0_後翅_後翅5_翅脈1CP;

		public ColorP X0Y0_後翅_後翅5_翅脈2CP;

		public ColorP X0Y0_後翅_後翅5_翅脈3CP;

		public ColorP X0Y0_後翅_後翅6_後翅CP;

		public ColorP X0Y0_後翅_後翅6_翅脈1CP;

		public ColorP X0Y0_後翅_後翅6_翅脈2CP;

		public ColorP X0Y0_後翅_後翅6_翅脈3CP;

		public ColorP X0Y0_後翅_後翅7_後翅CP;

		public ColorP X0Y0_後翅_後翅7_翅脈1CP;

		public ColorP X0Y0_後翅_後翅7_翅脈2CP;

		public ColorP X0Y0_後翅_後翅7_翅脈3CP;

		public ColorP X0Y0_後翅_後翅8_後翅CP;

		public ColorP X0Y0_後翅_後翅8_翅脈1CP;

		public ColorP X0Y0_後翅_後翅8_翅脈2CP;

		public ColorP X0Y0_後翅_後翅8_翅脈3CP;

		public ColorP X0Y0_後翅_後翅9_後翅CP;

		public ColorP X0Y0_後翅_後翅9_翅脈1CP;

		public ColorP X0Y0_後翅_後翅9_翅脈2CP;

		public ColorP X0Y0_後翅_後翅9_翅脈3CP;

		public ColorP X0Y0_後翅_後翅10_後翅CP;

		public ColorP X0Y0_後翅_後翅10_翅脈1CP;

		public ColorP X0Y0_後翅_後翅10_翅脈2CP;

		public ColorP X0Y0_後翅_後翅10_翅脈3CP;

		public ColorP X0Y0_後翅_後翅11_後翅CP;

		public ColorP X0Y0_後翅_後翅11_翅脈1CP;

		public ColorP X0Y0_後翅_後翅11_翅脈2CP;

		public ColorP X0Y0_後翅_後翅11_翅脈3CP;

		public ColorP X0Y1_後翅_後翅1_後翅CP;

		public ColorP X0Y1_後翅_後翅1_翅脈1CP;

		public ColorP X0Y1_後翅_後翅1_翅脈2CP;

		public ColorP X0Y1_後翅_後翅1_翅脈3CP;

		public ColorP X0Y1_後翅_後翅2_後翅CP;

		public ColorP X0Y1_後翅_後翅2_翅脈1CP;

		public ColorP X0Y1_後翅_後翅2_翅脈2CP;

		public ColorP X0Y1_後翅_後翅2_翅脈3CP;

		public ColorP X0Y1_後翅_後翅3_後翅CP;

		public ColorP X0Y1_後翅_後翅3_翅脈1CP;

		public ColorP X0Y1_後翅_後翅3_翅脈2CP;

		public ColorP X0Y1_後翅_後翅3_翅脈3CP;

		public ColorP X0Y1_後翅_後翅4_後翅CP;

		public ColorP X0Y1_後翅_後翅4_翅脈1CP;

		public ColorP X0Y1_後翅_後翅4_翅脈2CP;

		public ColorP X0Y1_後翅_後翅4_翅脈3CP;

		public ColorP X0Y1_後翅_後翅5_後翅CP;

		public ColorP X0Y1_後翅_後翅5_翅脈1CP;

		public ColorP X0Y1_後翅_後翅5_翅脈2CP;

		public ColorP X0Y1_後翅_後翅5_翅脈3CP;

		public ColorP X0Y1_後翅_後翅6_後翅CP;

		public ColorP X0Y1_後翅_後翅6_翅脈1CP;

		public ColorP X0Y1_後翅_後翅6_翅脈2CP;

		public ColorP X0Y1_後翅_後翅6_翅脈3CP;

		public ColorP X0Y1_後翅_後翅7_後翅CP;

		public ColorP X0Y1_後翅_後翅7_翅脈1CP;

		public ColorP X0Y1_後翅_後翅7_翅脈2CP;

		public ColorP X0Y1_後翅_後翅7_翅脈3CP;

		public ColorP X0Y1_後翅_後翅8_後翅CP;

		public ColorP X0Y1_後翅_後翅8_翅脈1CP;

		public ColorP X0Y1_後翅_後翅8_翅脈2CP;

		public ColorP X0Y1_後翅_後翅8_翅脈3CP;

		public ColorP X0Y1_後翅_後翅9_後翅CP;

		public ColorP X0Y1_後翅_後翅9_翅脈1CP;

		public ColorP X0Y1_後翅_後翅9_翅脈2CP;

		public ColorP X0Y1_後翅_後翅9_翅脈3CP;

		public ColorP X0Y1_後翅_後翅10_後翅CP;

		public ColorP X0Y1_後翅_後翅10_翅脈1CP;

		public ColorP X0Y1_後翅_後翅10_翅脈2CP;

		public ColorP X0Y1_後翅_後翅10_翅脈3CP;

		public ColorP X0Y1_後翅_後翅11_後翅CP;

		public ColorP X0Y1_後翅_後翅11_翅脈1CP;

		public ColorP X0Y1_後翅_後翅11_翅脈2CP;

		public ColorP X0Y1_後翅_後翅11_翅脈3CP;
	}
}
