using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 足_竜 : 獣足
	{
		public 足_竜(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 足_竜D e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "竜";
			dif.Add(new Pars(Sta.脚左["四足足"][3][0]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_足 = pars["足"].ToPar();
			Pars pars2 = pars["鱗足"].ToPars();
			this.X0Y0_竜性_鱗足_鱗6 = pars2["鱗6"].ToPar();
			this.X0Y0_竜性_鱗足_鱗5 = pars2["鱗5"].ToPar();
			this.X0Y0_竜性_鱗足_鱗4 = pars2["鱗4"].ToPar();
			this.X0Y0_竜性_鱗足_鱗3 = pars2["鱗3"].ToPar();
			this.X0Y0_竜性_鱗足_鱗2 = pars2["鱗2"].ToPar();
			this.X0Y0_竜性_鱗足_鱗1 = pars2["鱗1"].ToPar();
			pars2 = pars["鱗踵"].ToPars();
			this.X0Y0_竜性_鱗踵_鱗1 = pars2["鱗1"].ToPar();
			this.X0Y0_竜性_鱗踵_鱗2 = pars2["鱗2"].ToPar();
			this.X0Y0_竜性_鱗踵_鱗3 = pars2["鱗3"].ToPar();
			pars2 = pars["鱗甲"].ToPars();
			this.X0Y0_竜性_鱗甲_鱗11 = pars2["鱗11"].ToPar();
			this.X0Y0_竜性_鱗甲_鱗10 = pars2["鱗10"].ToPar();
			this.X0Y0_竜性_鱗甲_鱗9 = pars2["鱗9"].ToPar();
			this.X0Y0_竜性_鱗甲_鱗8 = pars2["鱗8"].ToPar();
			this.X0Y0_竜性_鱗甲_鱗7 = pars2["鱗7"].ToPar();
			this.X0Y0_竜性_鱗甲_鱗6 = pars2["鱗6"].ToPar();
			this.X0Y0_竜性_鱗甲_鱗5 = pars2["鱗5"].ToPar();
			this.X0Y0_竜性_鱗甲_鱗4 = pars2["鱗4"].ToPar();
			this.X0Y0_竜性_鱗甲_鱗3 = pars2["鱗3"].ToPar();
			this.X0Y0_竜性_鱗甲_鱗2 = pars2["鱗2"].ToPar();
			this.X0Y0_竜性_鱗甲_鱗1 = pars2["鱗1"].ToPar();
			pars2 = pars["薬指"].ToPars();
			this.X0Y0_薬指_指 = pars2["指"].ToPar();
			this.X0Y0_薬指_爪 = pars2["爪"].ToPar();
			Pars pars3 = pars2["鱗"].ToPars();
			Pars pars4 = pars3["下"].ToPars();
			this.X0Y0_薬指_竜性_鱗_下_鱗1 = pars4["鱗1"].ToPar();
			this.X0Y0_薬指_竜性_鱗_下_鱗2 = pars4["鱗2"].ToPar();
			pars4 = pars3["上"].ToPars();
			this.X0Y0_薬指_竜性_鱗_上_鱗1 = pars4["鱗1"].ToPar();
			this.X0Y0_薬指_竜性_鱗_上_鱗2 = pars4["鱗2"].ToPar();
			this.X0Y0_薬指_竜性_鱗_上_鱗3 = pars4["鱗3"].ToPar();
			pars2 = pars["中指"].ToPars();
			this.X0Y0_中指_指 = pars2["指"].ToPar();
			this.X0Y0_中指_爪 = pars2["爪"].ToPar();
			Pars pars5 = pars2["鱗"].ToPars();
			pars4 = pars5["下"].ToPars();
			this.X0Y0_中指_竜性_鱗_下_鱗1 = pars4["鱗1"].ToPar();
			this.X0Y0_中指_竜性_鱗_下_鱗2 = pars4["鱗2"].ToPar();
			pars4 = pars5["上"].ToPars();
			this.X0Y0_中指_竜性_鱗_上_鱗1 = pars4["鱗1"].ToPar();
			this.X0Y0_中指_竜性_鱗_上_鱗2 = pars4["鱗2"].ToPar();
			this.X0Y0_中指_竜性_鱗_上_鱗3 = pars4["鱗3"].ToPar();
			pars2 = pars["人指"].ToPars();
			this.X0Y0_人指_指 = pars2["指"].ToPar();
			this.X0Y0_人指_爪 = pars2["爪"].ToPar();
			Pars pars6 = pars2["鱗"].ToPars();
			pars4 = pars6["下"].ToPars();
			this.X0Y0_人指_竜性_鱗_下_鱗1 = pars4["鱗1"].ToPar();
			this.X0Y0_人指_竜性_鱗_下_鱗2 = pars4["鱗2"].ToPar();
			pars4 = pars6["上"].ToPars();
			this.X0Y0_人指_竜性_鱗_上_鱗1 = pars4["鱗1"].ToPar();
			this.X0Y0_人指_竜性_鱗_上_鱗2 = pars4["鱗2"].ToPar();
			this.X0Y0_人指_竜性_鱗_上_鱗3 = pars4["鱗3"].ToPar();
			pars2 = pars["親指"].ToPars();
			this.X0Y0_親指_指 = pars2["指"].ToPar();
			this.X0Y0_親指_爪 = pars2["爪"].ToPar();
			Pars pars7 = pars2["鱗"].ToPars();
			pars4 = pars7["下"].ToPars();
			this.X0Y0_親指_竜性_鱗_下_鱗1 = pars4["鱗1"].ToPar();
			this.X0Y0_親指_竜性_鱗_下_鱗2 = pars4["鱗2"].ToPar();
			pars4 = pars7["上"].ToPars();
			this.X0Y0_親指_竜性_鱗_上_鱗1 = pars4["鱗1"].ToPar();
			this.X0Y0_親指_竜性_鱗_上_鱗2 = pars4["鱗2"].ToPar();
			this.X0Y0_親指_竜性_鱗_上_鱗3 = pars4["鱗3"].ToPar();
			this.X0Y0_筋 = pars["筋"].ToPar();
			pars2 = pars["脚輪"].ToPars();
			this.X0Y0_脚輪_革 = pars2["革"].ToPar();
			this.X0Y0_脚輪_金具1 = pars2["金具1"].ToPar();
			this.X0Y0_脚輪_金具2 = pars2["金具2"].ToPar();
			this.X0Y0_脚輪_金具3 = pars2["金具3"].ToPar();
			this.X0Y0_脚輪_金具左 = pars2["金具左"].ToPar();
			this.X0Y0_脚輪_金具右 = pars2["金具右"].ToPar();
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
			this.足_表示 = e.足_表示;
			this.竜性_鱗足_鱗6_表示 = e.竜性_鱗足_鱗6_表示;
			this.竜性_鱗足_鱗5_表示 = e.竜性_鱗足_鱗5_表示;
			this.竜性_鱗足_鱗4_表示 = e.竜性_鱗足_鱗4_表示;
			this.竜性_鱗足_鱗3_表示 = e.竜性_鱗足_鱗3_表示;
			this.竜性_鱗足_鱗2_表示 = e.竜性_鱗足_鱗2_表示;
			this.竜性_鱗足_鱗1_表示 = e.竜性_鱗足_鱗1_表示;
			this.竜性_鱗踵_鱗1_表示 = e.竜性_鱗踵_鱗1_表示;
			this.竜性_鱗踵_鱗2_表示 = e.竜性_鱗踵_鱗2_表示;
			this.竜性_鱗踵_鱗3_表示 = e.竜性_鱗踵_鱗3_表示;
			this.竜性_鱗甲_鱗11_表示 = e.竜性_鱗甲_鱗11_表示;
			this.竜性_鱗甲_鱗10_表示 = e.竜性_鱗甲_鱗10_表示;
			this.竜性_鱗甲_鱗9_表示 = e.竜性_鱗甲_鱗9_表示;
			this.竜性_鱗甲_鱗8_表示 = e.竜性_鱗甲_鱗8_表示;
			this.竜性_鱗甲_鱗7_表示 = e.竜性_鱗甲_鱗7_表示;
			this.竜性_鱗甲_鱗6_表示 = e.竜性_鱗甲_鱗6_表示;
			this.竜性_鱗甲_鱗5_表示 = e.竜性_鱗甲_鱗5_表示;
			this.竜性_鱗甲_鱗4_表示 = e.竜性_鱗甲_鱗4_表示;
			this.竜性_鱗甲_鱗3_表示 = e.竜性_鱗甲_鱗3_表示;
			this.竜性_鱗甲_鱗2_表示 = e.竜性_鱗甲_鱗2_表示;
			this.竜性_鱗甲_鱗1_表示 = e.竜性_鱗甲_鱗1_表示;
			this.薬指_指_表示 = e.薬指_指_表示;
			this.薬指_爪_表示 = e.薬指_爪_表示;
			this.薬指_竜性_鱗_下_鱗1_表示 = e.薬指_竜性_鱗_下_鱗1_表示;
			this.薬指_竜性_鱗_下_鱗2_表示 = e.薬指_竜性_鱗_下_鱗2_表示;
			this.薬指_竜性_鱗_上_鱗1_表示 = e.薬指_竜性_鱗_上_鱗1_表示;
			this.薬指_竜性_鱗_上_鱗2_表示 = e.薬指_竜性_鱗_上_鱗2_表示;
			this.薬指_竜性_鱗_上_鱗3_表示 = e.薬指_竜性_鱗_上_鱗3_表示;
			this.中指_指_表示 = e.中指_指_表示;
			this.中指_爪_表示 = e.中指_爪_表示;
			this.中指_竜性_鱗_下_鱗1_表示 = e.中指_竜性_鱗_下_鱗1_表示;
			this.中指_竜性_鱗_下_鱗2_表示 = e.中指_竜性_鱗_下_鱗2_表示;
			this.中指_竜性_鱗_上_鱗1_表示 = e.中指_竜性_鱗_上_鱗1_表示;
			this.中指_竜性_鱗_上_鱗2_表示 = e.中指_竜性_鱗_上_鱗2_表示;
			this.中指_竜性_鱗_上_鱗3_表示 = e.中指_竜性_鱗_上_鱗3_表示;
			this.人指_指_表示 = e.人指_指_表示;
			this.人指_爪_表示 = e.人指_爪_表示;
			this.人指_竜性_鱗_下_鱗1_表示 = e.人指_竜性_鱗_下_鱗1_表示;
			this.人指_竜性_鱗_下_鱗2_表示 = e.人指_竜性_鱗_下_鱗2_表示;
			this.人指_竜性_鱗_上_鱗1_表示 = e.人指_竜性_鱗_上_鱗1_表示;
			this.人指_竜性_鱗_上_鱗2_表示 = e.人指_竜性_鱗_上_鱗2_表示;
			this.人指_竜性_鱗_上_鱗3_表示 = e.人指_竜性_鱗_上_鱗3_表示;
			this.親指_指_表示 = e.親指_指_表示;
			this.親指_爪_表示 = e.親指_爪_表示;
			this.親指_竜性_鱗_下_鱗1_表示 = e.親指_竜性_鱗_下_鱗1_表示;
			this.親指_竜性_鱗_下_鱗2_表示 = e.親指_竜性_鱗_下_鱗2_表示;
			this.親指_竜性_鱗_上_鱗1_表示 = e.親指_竜性_鱗_上_鱗1_表示;
			this.親指_竜性_鱗_上_鱗2_表示 = e.親指_竜性_鱗_上_鱗2_表示;
			this.親指_竜性_鱗_上_鱗3_表示 = e.親指_竜性_鱗_上_鱗3_表示;
			this.筋_表示 = e.筋_表示;
			this.脚輪_革_表示 = e.脚輪_革_表示;
			this.脚輪_金具1_表示 = e.脚輪_金具1_表示;
			this.脚輪_金具2_表示 = e.脚輪_金具2_表示;
			this.脚輪_金具3_表示 = e.脚輪_金具3_表示;
			this.脚輪_金具左_表示 = e.脚輪_金具左_表示;
			this.脚輪_金具右_表示 = e.脚輪_金具右_表示;
			this.脚輪表示 = e.脚輪表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_足CP = new ColorP(this.X0Y0_足, this.足CD, DisUnit, true);
			this.X0Y0_竜性_鱗足_鱗6CP = new ColorP(this.X0Y0_竜性_鱗足_鱗6, this.竜性_鱗足_鱗6CD, DisUnit, true);
			this.X0Y0_竜性_鱗足_鱗5CP = new ColorP(this.X0Y0_竜性_鱗足_鱗5, this.竜性_鱗足_鱗5CD, DisUnit, true);
			this.X0Y0_竜性_鱗足_鱗4CP = new ColorP(this.X0Y0_竜性_鱗足_鱗4, this.竜性_鱗足_鱗4CD, DisUnit, true);
			this.X0Y0_竜性_鱗足_鱗3CP = new ColorP(this.X0Y0_竜性_鱗足_鱗3, this.竜性_鱗足_鱗3CD, DisUnit, true);
			this.X0Y0_竜性_鱗足_鱗2CP = new ColorP(this.X0Y0_竜性_鱗足_鱗2, this.竜性_鱗足_鱗2CD, DisUnit, true);
			this.X0Y0_竜性_鱗足_鱗1CP = new ColorP(this.X0Y0_竜性_鱗足_鱗1, this.竜性_鱗足_鱗1CD, DisUnit, true);
			this.X0Y0_竜性_鱗踵_鱗1CP = new ColorP(this.X0Y0_竜性_鱗踵_鱗1, this.竜性_鱗踵_鱗1CD, DisUnit, true);
			this.X0Y0_竜性_鱗踵_鱗2CP = new ColorP(this.X0Y0_竜性_鱗踵_鱗2, this.竜性_鱗踵_鱗2CD, DisUnit, true);
			this.X0Y0_竜性_鱗踵_鱗3CP = new ColorP(this.X0Y0_竜性_鱗踵_鱗3, this.竜性_鱗踵_鱗3CD, DisUnit, true);
			this.X0Y0_竜性_鱗甲_鱗11CP = new ColorP(this.X0Y0_竜性_鱗甲_鱗11, this.竜性_鱗甲_鱗11CD, DisUnit, true);
			this.X0Y0_竜性_鱗甲_鱗10CP = new ColorP(this.X0Y0_竜性_鱗甲_鱗10, this.竜性_鱗甲_鱗10CD, DisUnit, true);
			this.X0Y0_竜性_鱗甲_鱗9CP = new ColorP(this.X0Y0_竜性_鱗甲_鱗9, this.竜性_鱗甲_鱗9CD, DisUnit, true);
			this.X0Y0_竜性_鱗甲_鱗8CP = new ColorP(this.X0Y0_竜性_鱗甲_鱗8, this.竜性_鱗甲_鱗8CD, DisUnit, true);
			this.X0Y0_竜性_鱗甲_鱗7CP = new ColorP(this.X0Y0_竜性_鱗甲_鱗7, this.竜性_鱗甲_鱗7CD, DisUnit, true);
			this.X0Y0_竜性_鱗甲_鱗6CP = new ColorP(this.X0Y0_竜性_鱗甲_鱗6, this.竜性_鱗甲_鱗6CD, DisUnit, true);
			this.X0Y0_竜性_鱗甲_鱗5CP = new ColorP(this.X0Y0_竜性_鱗甲_鱗5, this.竜性_鱗甲_鱗5CD, DisUnit, true);
			this.X0Y0_竜性_鱗甲_鱗4CP = new ColorP(this.X0Y0_竜性_鱗甲_鱗4, this.竜性_鱗甲_鱗4CD, DisUnit, true);
			this.X0Y0_竜性_鱗甲_鱗3CP = new ColorP(this.X0Y0_竜性_鱗甲_鱗3, this.竜性_鱗甲_鱗3CD, DisUnit, true);
			this.X0Y0_竜性_鱗甲_鱗2CP = new ColorP(this.X0Y0_竜性_鱗甲_鱗2, this.竜性_鱗甲_鱗2CD, DisUnit, true);
			this.X0Y0_竜性_鱗甲_鱗1CP = new ColorP(this.X0Y0_竜性_鱗甲_鱗1, this.竜性_鱗甲_鱗1CD, DisUnit, true);
			this.X0Y0_薬指_指CP = new ColorP(this.X0Y0_薬指_指, this.薬指_指CD, DisUnit, true);
			this.X0Y0_薬指_爪CP = new ColorP(this.X0Y0_薬指_爪, this.薬指_爪CD, DisUnit, true);
			this.X0Y0_薬指_竜性_鱗_下_鱗1CP = new ColorP(this.X0Y0_薬指_竜性_鱗_下_鱗1, this.薬指_竜性_鱗_下_鱗1CD, DisUnit, true);
			this.X0Y0_薬指_竜性_鱗_下_鱗2CP = new ColorP(this.X0Y0_薬指_竜性_鱗_下_鱗2, this.薬指_竜性_鱗_下_鱗2CD, DisUnit, true);
			this.X0Y0_薬指_竜性_鱗_上_鱗1CP = new ColorP(this.X0Y0_薬指_竜性_鱗_上_鱗1, this.薬指_竜性_鱗_上_鱗1CD, DisUnit, true);
			this.X0Y0_薬指_竜性_鱗_上_鱗2CP = new ColorP(this.X0Y0_薬指_竜性_鱗_上_鱗2, this.薬指_竜性_鱗_上_鱗2CD, DisUnit, true);
			this.X0Y0_薬指_竜性_鱗_上_鱗3CP = new ColorP(this.X0Y0_薬指_竜性_鱗_上_鱗3, this.薬指_竜性_鱗_上_鱗3CD, DisUnit, true);
			this.X0Y0_中指_指CP = new ColorP(this.X0Y0_中指_指, this.中指_指CD, DisUnit, true);
			this.X0Y0_中指_爪CP = new ColorP(this.X0Y0_中指_爪, this.中指_爪CD, DisUnit, true);
			this.X0Y0_中指_竜性_鱗_下_鱗1CP = new ColorP(this.X0Y0_中指_竜性_鱗_下_鱗1, this.中指_竜性_鱗_下_鱗1CD, DisUnit, true);
			this.X0Y0_中指_竜性_鱗_下_鱗2CP = new ColorP(this.X0Y0_中指_竜性_鱗_下_鱗2, this.中指_竜性_鱗_下_鱗2CD, DisUnit, true);
			this.X0Y0_中指_竜性_鱗_上_鱗1CP = new ColorP(this.X0Y0_中指_竜性_鱗_上_鱗1, this.中指_竜性_鱗_上_鱗1CD, DisUnit, true);
			this.X0Y0_中指_竜性_鱗_上_鱗2CP = new ColorP(this.X0Y0_中指_竜性_鱗_上_鱗2, this.中指_竜性_鱗_上_鱗2CD, DisUnit, true);
			this.X0Y0_中指_竜性_鱗_上_鱗3CP = new ColorP(this.X0Y0_中指_竜性_鱗_上_鱗3, this.中指_竜性_鱗_上_鱗3CD, DisUnit, true);
			this.X0Y0_人指_指CP = new ColorP(this.X0Y0_人指_指, this.人指_指CD, DisUnit, true);
			this.X0Y0_人指_爪CP = new ColorP(this.X0Y0_人指_爪, this.人指_爪CD, DisUnit, true);
			this.X0Y0_人指_竜性_鱗_下_鱗1CP = new ColorP(this.X0Y0_人指_竜性_鱗_下_鱗1, this.人指_竜性_鱗_下_鱗1CD, DisUnit, true);
			this.X0Y0_人指_竜性_鱗_下_鱗2CP = new ColorP(this.X0Y0_人指_竜性_鱗_下_鱗2, this.人指_竜性_鱗_下_鱗2CD, DisUnit, true);
			this.X0Y0_人指_竜性_鱗_上_鱗1CP = new ColorP(this.X0Y0_人指_竜性_鱗_上_鱗1, this.人指_竜性_鱗_上_鱗1CD, DisUnit, true);
			this.X0Y0_人指_竜性_鱗_上_鱗2CP = new ColorP(this.X0Y0_人指_竜性_鱗_上_鱗2, this.人指_竜性_鱗_上_鱗2CD, DisUnit, true);
			this.X0Y0_人指_竜性_鱗_上_鱗3CP = new ColorP(this.X0Y0_人指_竜性_鱗_上_鱗3, this.人指_竜性_鱗_上_鱗3CD, DisUnit, true);
			this.X0Y0_親指_指CP = new ColorP(this.X0Y0_親指_指, this.親指_指CD, DisUnit, true);
			this.X0Y0_親指_爪CP = new ColorP(this.X0Y0_親指_爪, this.親指_爪CD, DisUnit, true);
			this.X0Y0_親指_竜性_鱗_下_鱗1CP = new ColorP(this.X0Y0_親指_竜性_鱗_下_鱗1, this.親指_竜性_鱗_下_鱗1CD, DisUnit, true);
			this.X0Y0_親指_竜性_鱗_下_鱗2CP = new ColorP(this.X0Y0_親指_竜性_鱗_下_鱗2, this.親指_竜性_鱗_下_鱗2CD, DisUnit, true);
			this.X0Y0_親指_竜性_鱗_上_鱗1CP = new ColorP(this.X0Y0_親指_竜性_鱗_上_鱗1, this.親指_竜性_鱗_上_鱗1CD, DisUnit, true);
			this.X0Y0_親指_竜性_鱗_上_鱗2CP = new ColorP(this.X0Y0_親指_竜性_鱗_上_鱗2, this.親指_竜性_鱗_上_鱗2CD, DisUnit, true);
			this.X0Y0_親指_竜性_鱗_上_鱗3CP = new ColorP(this.X0Y0_親指_竜性_鱗_上_鱗3, this.親指_竜性_鱗_上_鱗3CD, DisUnit, true);
			this.X0Y0_筋CP = new ColorP(this.X0Y0_筋, this.筋CD, DisUnit, false);
			this.X0Y0_脚輪_革CP = new ColorP(this.X0Y0_脚輪_革, this.脚輪_革CD, DisUnit, true);
			this.X0Y0_脚輪_金具1CP = new ColorP(this.X0Y0_脚輪_金具1, this.脚輪_金具1CD, DisUnit, true);
			this.X0Y0_脚輪_金具2CP = new ColorP(this.X0Y0_脚輪_金具2, this.脚輪_金具2CD, DisUnit, true);
			this.X0Y0_脚輪_金具3CP = new ColorP(this.X0Y0_脚輪_金具3, this.脚輪_金具3CD, DisUnit, true);
			this.X0Y0_脚輪_金具左CP = new ColorP(this.X0Y0_脚輪_金具左, this.脚輪_金具左CD, DisUnit, true);
			this.X0Y0_脚輪_金具右CP = new ColorP(this.X0Y0_脚輪_金具右, this.脚輪_金具右CD, DisUnit, true);
			this.濃度 = e.濃度;
			this.鎖1 = new 拘束鎖(DisUnit, this.右, 配色指定, 体配色, this.Xasix);
			this.鎖1.接続(this.鎖1_接続点);
			int num = this.右 ? -10 : 10;
			this.鎖1.角度B -= (double)num;
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
				this.筋_表示 = this.筋肉_;
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
				this.脚輪表示 = this.拘束_;
			}
		}

		public bool 足_表示
		{
			get
			{
				return this.X0Y0_足.Dra;
			}
			set
			{
				this.X0Y0_足.Dra = value;
				this.X0Y0_足.Hit = value;
			}
		}

		public bool 竜性_鱗足_鱗6_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗足_鱗6.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗足_鱗6.Dra = value;
				this.X0Y0_竜性_鱗足_鱗6.Hit = value;
			}
		}

		public bool 竜性_鱗足_鱗5_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗足_鱗5.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗足_鱗5.Dra = value;
				this.X0Y0_竜性_鱗足_鱗5.Hit = value;
			}
		}

		public bool 竜性_鱗足_鱗4_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗足_鱗4.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗足_鱗4.Dra = value;
				this.X0Y0_竜性_鱗足_鱗4.Hit = value;
			}
		}

		public bool 竜性_鱗足_鱗3_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗足_鱗3.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗足_鱗3.Dra = value;
				this.X0Y0_竜性_鱗足_鱗3.Hit = value;
			}
		}

		public bool 竜性_鱗足_鱗2_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗足_鱗2.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗足_鱗2.Dra = value;
				this.X0Y0_竜性_鱗足_鱗2.Hit = value;
			}
		}

		public bool 竜性_鱗足_鱗1_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗足_鱗1.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗足_鱗1.Dra = value;
				this.X0Y0_竜性_鱗足_鱗1.Hit = value;
			}
		}

		public bool 竜性_鱗踵_鱗1_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗踵_鱗1.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗踵_鱗1.Dra = value;
				this.X0Y0_竜性_鱗踵_鱗1.Hit = value;
			}
		}

		public bool 竜性_鱗踵_鱗2_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗踵_鱗2.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗踵_鱗2.Dra = value;
				this.X0Y0_竜性_鱗踵_鱗2.Hit = value;
			}
		}

		public bool 竜性_鱗踵_鱗3_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗踵_鱗3.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗踵_鱗3.Dra = value;
				this.X0Y0_竜性_鱗踵_鱗3.Hit = value;
			}
		}

		public bool 竜性_鱗甲_鱗11_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗甲_鱗11.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗甲_鱗11.Dra = value;
				this.X0Y0_竜性_鱗甲_鱗11.Hit = value;
			}
		}

		public bool 竜性_鱗甲_鱗10_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗甲_鱗10.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗甲_鱗10.Dra = value;
				this.X0Y0_竜性_鱗甲_鱗10.Hit = value;
			}
		}

		public bool 竜性_鱗甲_鱗9_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗甲_鱗9.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗甲_鱗9.Dra = value;
				this.X0Y0_竜性_鱗甲_鱗9.Hit = value;
			}
		}

		public bool 竜性_鱗甲_鱗8_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗甲_鱗8.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗甲_鱗8.Dra = value;
				this.X0Y0_竜性_鱗甲_鱗8.Hit = value;
			}
		}

		public bool 竜性_鱗甲_鱗7_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗甲_鱗7.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗甲_鱗7.Dra = value;
				this.X0Y0_竜性_鱗甲_鱗7.Hit = value;
			}
		}

		public bool 竜性_鱗甲_鱗6_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗甲_鱗6.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗甲_鱗6.Dra = value;
				this.X0Y0_竜性_鱗甲_鱗6.Hit = value;
			}
		}

		public bool 竜性_鱗甲_鱗5_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗甲_鱗5.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗甲_鱗5.Dra = value;
				this.X0Y0_竜性_鱗甲_鱗5.Hit = value;
			}
		}

		public bool 竜性_鱗甲_鱗4_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗甲_鱗4.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗甲_鱗4.Dra = value;
				this.X0Y0_竜性_鱗甲_鱗4.Hit = value;
			}
		}

		public bool 竜性_鱗甲_鱗3_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗甲_鱗3.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗甲_鱗3.Dra = value;
				this.X0Y0_竜性_鱗甲_鱗3.Hit = value;
			}
		}

		public bool 竜性_鱗甲_鱗2_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗甲_鱗2.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗甲_鱗2.Dra = value;
				this.X0Y0_竜性_鱗甲_鱗2.Hit = value;
			}
		}

		public bool 竜性_鱗甲_鱗1_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗甲_鱗1.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗甲_鱗1.Dra = value;
				this.X0Y0_竜性_鱗甲_鱗1.Hit = value;
			}
		}

		public bool 薬指_指_表示
		{
			get
			{
				return this.X0Y0_薬指_指.Dra;
			}
			set
			{
				this.X0Y0_薬指_指.Dra = value;
				this.X0Y0_薬指_指.Hit = value;
			}
		}

		public bool 薬指_爪_表示
		{
			get
			{
				return this.X0Y0_薬指_爪.Dra;
			}
			set
			{
				this.X0Y0_薬指_爪.Dra = value;
				this.X0Y0_薬指_爪.Hit = value;
			}
		}

		public bool 薬指_竜性_鱗_下_鱗1_表示
		{
			get
			{
				return this.X0Y0_薬指_竜性_鱗_下_鱗1.Dra;
			}
			set
			{
				this.X0Y0_薬指_竜性_鱗_下_鱗1.Dra = value;
				this.X0Y0_薬指_竜性_鱗_下_鱗1.Hit = value;
			}
		}

		public bool 薬指_竜性_鱗_下_鱗2_表示
		{
			get
			{
				return this.X0Y0_薬指_竜性_鱗_下_鱗2.Dra;
			}
			set
			{
				this.X0Y0_薬指_竜性_鱗_下_鱗2.Dra = value;
				this.X0Y0_薬指_竜性_鱗_下_鱗2.Hit = value;
			}
		}

		public bool 薬指_竜性_鱗_上_鱗1_表示
		{
			get
			{
				return this.X0Y0_薬指_竜性_鱗_上_鱗1.Dra;
			}
			set
			{
				this.X0Y0_薬指_竜性_鱗_上_鱗1.Dra = value;
				this.X0Y0_薬指_竜性_鱗_上_鱗1.Hit = value;
			}
		}

		public bool 薬指_竜性_鱗_上_鱗2_表示
		{
			get
			{
				return this.X0Y0_薬指_竜性_鱗_上_鱗2.Dra;
			}
			set
			{
				this.X0Y0_薬指_竜性_鱗_上_鱗2.Dra = value;
				this.X0Y0_薬指_竜性_鱗_上_鱗2.Hit = value;
			}
		}

		public bool 薬指_竜性_鱗_上_鱗3_表示
		{
			get
			{
				return this.X0Y0_薬指_竜性_鱗_上_鱗3.Dra;
			}
			set
			{
				this.X0Y0_薬指_竜性_鱗_上_鱗3.Dra = value;
				this.X0Y0_薬指_竜性_鱗_上_鱗3.Hit = value;
			}
		}

		public bool 中指_指_表示
		{
			get
			{
				return this.X0Y0_中指_指.Dra;
			}
			set
			{
				this.X0Y0_中指_指.Dra = value;
				this.X0Y0_中指_指.Hit = value;
			}
		}

		public bool 中指_爪_表示
		{
			get
			{
				return this.X0Y0_中指_爪.Dra;
			}
			set
			{
				this.X0Y0_中指_爪.Dra = value;
				this.X0Y0_中指_爪.Hit = value;
			}
		}

		public bool 中指_竜性_鱗_下_鱗1_表示
		{
			get
			{
				return this.X0Y0_中指_竜性_鱗_下_鱗1.Dra;
			}
			set
			{
				this.X0Y0_中指_竜性_鱗_下_鱗1.Dra = value;
				this.X0Y0_中指_竜性_鱗_下_鱗1.Hit = value;
			}
		}

		public bool 中指_竜性_鱗_下_鱗2_表示
		{
			get
			{
				return this.X0Y0_中指_竜性_鱗_下_鱗2.Dra;
			}
			set
			{
				this.X0Y0_中指_竜性_鱗_下_鱗2.Dra = value;
				this.X0Y0_中指_竜性_鱗_下_鱗2.Hit = value;
			}
		}

		public bool 中指_竜性_鱗_上_鱗1_表示
		{
			get
			{
				return this.X0Y0_中指_竜性_鱗_上_鱗1.Dra;
			}
			set
			{
				this.X0Y0_中指_竜性_鱗_上_鱗1.Dra = value;
				this.X0Y0_中指_竜性_鱗_上_鱗1.Hit = value;
			}
		}

		public bool 中指_竜性_鱗_上_鱗2_表示
		{
			get
			{
				return this.X0Y0_中指_竜性_鱗_上_鱗2.Dra;
			}
			set
			{
				this.X0Y0_中指_竜性_鱗_上_鱗2.Dra = value;
				this.X0Y0_中指_竜性_鱗_上_鱗2.Hit = value;
			}
		}

		public bool 中指_竜性_鱗_上_鱗3_表示
		{
			get
			{
				return this.X0Y0_中指_竜性_鱗_上_鱗3.Dra;
			}
			set
			{
				this.X0Y0_中指_竜性_鱗_上_鱗3.Dra = value;
				this.X0Y0_中指_竜性_鱗_上_鱗3.Hit = value;
			}
		}

		public bool 人指_指_表示
		{
			get
			{
				return this.X0Y0_人指_指.Dra;
			}
			set
			{
				this.X0Y0_人指_指.Dra = value;
				this.X0Y0_人指_指.Hit = value;
			}
		}

		public bool 人指_爪_表示
		{
			get
			{
				return this.X0Y0_人指_爪.Dra;
			}
			set
			{
				this.X0Y0_人指_爪.Dra = value;
				this.X0Y0_人指_爪.Hit = value;
			}
		}

		public bool 人指_竜性_鱗_下_鱗1_表示
		{
			get
			{
				return this.X0Y0_人指_竜性_鱗_下_鱗1.Dra;
			}
			set
			{
				this.X0Y0_人指_竜性_鱗_下_鱗1.Dra = value;
				this.X0Y0_人指_竜性_鱗_下_鱗1.Hit = value;
			}
		}

		public bool 人指_竜性_鱗_下_鱗2_表示
		{
			get
			{
				return this.X0Y0_人指_竜性_鱗_下_鱗2.Dra;
			}
			set
			{
				this.X0Y0_人指_竜性_鱗_下_鱗2.Dra = value;
				this.X0Y0_人指_竜性_鱗_下_鱗2.Hit = value;
			}
		}

		public bool 人指_竜性_鱗_上_鱗1_表示
		{
			get
			{
				return this.X0Y0_人指_竜性_鱗_上_鱗1.Dra;
			}
			set
			{
				this.X0Y0_人指_竜性_鱗_上_鱗1.Dra = value;
				this.X0Y0_人指_竜性_鱗_上_鱗1.Hit = value;
			}
		}

		public bool 人指_竜性_鱗_上_鱗2_表示
		{
			get
			{
				return this.X0Y0_人指_竜性_鱗_上_鱗2.Dra;
			}
			set
			{
				this.X0Y0_人指_竜性_鱗_上_鱗2.Dra = value;
				this.X0Y0_人指_竜性_鱗_上_鱗2.Hit = value;
			}
		}

		public bool 人指_竜性_鱗_上_鱗3_表示
		{
			get
			{
				return this.X0Y0_人指_竜性_鱗_上_鱗3.Dra;
			}
			set
			{
				this.X0Y0_人指_竜性_鱗_上_鱗3.Dra = value;
				this.X0Y0_人指_竜性_鱗_上_鱗3.Hit = value;
			}
		}

		public bool 親指_指_表示
		{
			get
			{
				return this.X0Y0_親指_指.Dra;
			}
			set
			{
				this.X0Y0_親指_指.Dra = value;
				this.X0Y0_親指_指.Hit = value;
			}
		}

		public bool 親指_爪_表示
		{
			get
			{
				return this.X0Y0_親指_爪.Dra;
			}
			set
			{
				this.X0Y0_親指_爪.Dra = value;
				this.X0Y0_親指_爪.Hit = value;
			}
		}

		public bool 親指_竜性_鱗_下_鱗1_表示
		{
			get
			{
				return this.X0Y0_親指_竜性_鱗_下_鱗1.Dra;
			}
			set
			{
				this.X0Y0_親指_竜性_鱗_下_鱗1.Dra = value;
				this.X0Y0_親指_竜性_鱗_下_鱗1.Hit = value;
			}
		}

		public bool 親指_竜性_鱗_下_鱗2_表示
		{
			get
			{
				return this.X0Y0_親指_竜性_鱗_下_鱗2.Dra;
			}
			set
			{
				this.X0Y0_親指_竜性_鱗_下_鱗2.Dra = value;
				this.X0Y0_親指_竜性_鱗_下_鱗2.Hit = value;
			}
		}

		public bool 親指_竜性_鱗_上_鱗1_表示
		{
			get
			{
				return this.X0Y0_親指_竜性_鱗_上_鱗1.Dra;
			}
			set
			{
				this.X0Y0_親指_竜性_鱗_上_鱗1.Dra = value;
				this.X0Y0_親指_竜性_鱗_上_鱗1.Hit = value;
			}
		}

		public bool 親指_竜性_鱗_上_鱗2_表示
		{
			get
			{
				return this.X0Y0_親指_竜性_鱗_上_鱗2.Dra;
			}
			set
			{
				this.X0Y0_親指_竜性_鱗_上_鱗2.Dra = value;
				this.X0Y0_親指_竜性_鱗_上_鱗2.Hit = value;
			}
		}

		public bool 親指_竜性_鱗_上_鱗3_表示
		{
			get
			{
				return this.X0Y0_親指_竜性_鱗_上_鱗3.Dra;
			}
			set
			{
				this.X0Y0_親指_竜性_鱗_上_鱗3.Dra = value;
				this.X0Y0_親指_竜性_鱗_上_鱗3.Hit = value;
			}
		}

		public bool 筋_表示
		{
			get
			{
				return this.X0Y0_筋.Dra;
			}
			set
			{
				this.X0Y0_筋.Dra = value;
				this.X0Y0_筋.Hit = value;
			}
		}

		public bool 脚輪_革_表示
		{
			get
			{
				return this.X0Y0_脚輪_革.Dra;
			}
			set
			{
				this.X0Y0_脚輪_革.Dra = value;
				this.X0Y0_脚輪_革.Hit = value;
			}
		}

		public bool 脚輪_金具1_表示
		{
			get
			{
				return this.X0Y0_脚輪_金具1.Dra;
			}
			set
			{
				this.X0Y0_脚輪_金具1.Dra = value;
				this.X0Y0_脚輪_金具1.Hit = value;
			}
		}

		public bool 脚輪_金具2_表示
		{
			get
			{
				return this.X0Y0_脚輪_金具2.Dra;
			}
			set
			{
				this.X0Y0_脚輪_金具2.Dra = value;
				this.X0Y0_脚輪_金具2.Hit = value;
			}
		}

		public bool 脚輪_金具3_表示
		{
			get
			{
				return this.X0Y0_脚輪_金具3.Dra;
			}
			set
			{
				this.X0Y0_脚輪_金具3.Dra = value;
				this.X0Y0_脚輪_金具3.Hit = value;
			}
		}

		public bool 脚輪_金具左_表示
		{
			get
			{
				return this.X0Y0_脚輪_金具左.Dra;
			}
			set
			{
				this.X0Y0_脚輪_金具左.Dra = value;
				this.X0Y0_脚輪_金具左.Hit = value;
			}
		}

		public bool 脚輪_金具右_表示
		{
			get
			{
				return this.X0Y0_脚輪_金具右.Dra;
			}
			set
			{
				this.X0Y0_脚輪_金具右.Dra = value;
				this.X0Y0_脚輪_金具右.Hit = value;
			}
		}

		public bool 脚輪表示
		{
			get
			{
				return this.脚輪_革_表示;
			}
			set
			{
				this.脚輪_革_表示 = value;
				this.脚輪_金具1_表示 = value;
				this.脚輪_金具2_表示 = value;
				this.脚輪_金具3_表示 = value;
				this.脚輪_金具左_表示 = value;
				this.脚輪_金具右_表示 = value;
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
			}
		}

		public override bool 表示
		{
			get
			{
				return this.足_表示;
			}
			set
			{
				this.足_表示 = value;
				this.竜性_鱗足_鱗6_表示 = value;
				this.竜性_鱗足_鱗5_表示 = value;
				this.竜性_鱗足_鱗4_表示 = value;
				this.竜性_鱗足_鱗3_表示 = value;
				this.竜性_鱗足_鱗2_表示 = value;
				this.竜性_鱗足_鱗1_表示 = value;
				this.竜性_鱗踵_鱗1_表示 = value;
				this.竜性_鱗踵_鱗2_表示 = value;
				this.竜性_鱗踵_鱗3_表示 = value;
				this.竜性_鱗甲_鱗11_表示 = value;
				this.竜性_鱗甲_鱗10_表示 = value;
				this.竜性_鱗甲_鱗9_表示 = value;
				this.竜性_鱗甲_鱗8_表示 = value;
				this.竜性_鱗甲_鱗7_表示 = value;
				this.竜性_鱗甲_鱗6_表示 = value;
				this.竜性_鱗甲_鱗5_表示 = value;
				this.竜性_鱗甲_鱗4_表示 = value;
				this.竜性_鱗甲_鱗3_表示 = value;
				this.竜性_鱗甲_鱗2_表示 = value;
				this.竜性_鱗甲_鱗1_表示 = value;
				this.薬指_指_表示 = value;
				this.薬指_爪_表示 = value;
				this.薬指_竜性_鱗_下_鱗1_表示 = value;
				this.薬指_竜性_鱗_下_鱗2_表示 = value;
				this.薬指_竜性_鱗_上_鱗1_表示 = value;
				this.薬指_竜性_鱗_上_鱗2_表示 = value;
				this.薬指_竜性_鱗_上_鱗3_表示 = value;
				this.中指_指_表示 = value;
				this.中指_爪_表示 = value;
				this.中指_竜性_鱗_下_鱗1_表示 = value;
				this.中指_竜性_鱗_下_鱗2_表示 = value;
				this.中指_竜性_鱗_上_鱗1_表示 = value;
				this.中指_竜性_鱗_上_鱗2_表示 = value;
				this.中指_竜性_鱗_上_鱗3_表示 = value;
				this.人指_指_表示 = value;
				this.人指_爪_表示 = value;
				this.人指_竜性_鱗_下_鱗1_表示 = value;
				this.人指_竜性_鱗_下_鱗2_表示 = value;
				this.人指_竜性_鱗_上_鱗1_表示 = value;
				this.人指_竜性_鱗_上_鱗2_表示 = value;
				this.人指_竜性_鱗_上_鱗3_表示 = value;
				this.親指_指_表示 = value;
				this.親指_爪_表示 = value;
				this.親指_竜性_鱗_下_鱗1_表示 = value;
				this.親指_竜性_鱗_下_鱗2_表示 = value;
				this.親指_竜性_鱗_上_鱗1_表示 = value;
				this.親指_竜性_鱗_上_鱗2_表示 = value;
				this.親指_竜性_鱗_上_鱗3_表示 = value;
				this.筋_表示 = value;
				this.脚輪_革_表示 = value;
				this.脚輪_金具1_表示 = value;
				this.脚輪_金具2_表示 = value;
				this.脚輪_金具3_表示 = value;
				this.脚輪_金具左_表示 = value;
				this.脚輪_金具右_表示 = value;
				this.鎖1.表示 = value;
			}
		}

		public override void 描画0(Are Are)
		{
			this.本体.Draw(Are);
			this.鎖1.描画0(Are);
		}

		public override void Dispose()
		{
			base.Dispose();
			this.鎖1.Dispose();
		}

		public override double 濃度
		{
			get
			{
				return this.足CD.不透明度;
			}
			set
			{
				this.足CD.不透明度 = value;
				this.竜性_鱗足_鱗6CD.不透明度 = value;
				this.竜性_鱗足_鱗5CD.不透明度 = value;
				this.竜性_鱗足_鱗4CD.不透明度 = value;
				this.竜性_鱗足_鱗3CD.不透明度 = value;
				this.竜性_鱗足_鱗2CD.不透明度 = value;
				this.竜性_鱗足_鱗1CD.不透明度 = value;
				this.竜性_鱗踵_鱗1CD.不透明度 = value;
				this.竜性_鱗踵_鱗2CD.不透明度 = value;
				this.竜性_鱗踵_鱗3CD.不透明度 = value;
				this.竜性_鱗甲_鱗11CD.不透明度 = value;
				this.竜性_鱗甲_鱗10CD.不透明度 = value;
				this.竜性_鱗甲_鱗9CD.不透明度 = value;
				this.竜性_鱗甲_鱗8CD.不透明度 = value;
				this.竜性_鱗甲_鱗7CD.不透明度 = value;
				this.竜性_鱗甲_鱗6CD.不透明度 = value;
				this.竜性_鱗甲_鱗5CD.不透明度 = value;
				this.竜性_鱗甲_鱗4CD.不透明度 = value;
				this.竜性_鱗甲_鱗3CD.不透明度 = value;
				this.竜性_鱗甲_鱗2CD.不透明度 = value;
				this.竜性_鱗甲_鱗1CD.不透明度 = value;
				this.薬指_指CD.不透明度 = value;
				this.薬指_爪CD.不透明度 = value;
				this.薬指_竜性_鱗_下_鱗1CD.不透明度 = value;
				this.薬指_竜性_鱗_下_鱗2CD.不透明度 = value;
				this.薬指_竜性_鱗_上_鱗1CD.不透明度 = value;
				this.薬指_竜性_鱗_上_鱗2CD.不透明度 = value;
				this.薬指_竜性_鱗_上_鱗3CD.不透明度 = value;
				this.中指_指CD.不透明度 = value;
				this.中指_爪CD.不透明度 = value;
				this.中指_竜性_鱗_下_鱗1CD.不透明度 = value;
				this.中指_竜性_鱗_下_鱗2CD.不透明度 = value;
				this.中指_竜性_鱗_上_鱗1CD.不透明度 = value;
				this.中指_竜性_鱗_上_鱗2CD.不透明度 = value;
				this.中指_竜性_鱗_上_鱗3CD.不透明度 = value;
				this.人指_指CD.不透明度 = value;
				this.人指_爪CD.不透明度 = value;
				this.人指_竜性_鱗_下_鱗1CD.不透明度 = value;
				this.人指_竜性_鱗_下_鱗2CD.不透明度 = value;
				this.人指_竜性_鱗_上_鱗1CD.不透明度 = value;
				this.人指_竜性_鱗_上_鱗2CD.不透明度 = value;
				this.人指_竜性_鱗_上_鱗3CD.不透明度 = value;
				this.親指_指CD.不透明度 = value;
				this.親指_爪CD.不透明度 = value;
				this.親指_竜性_鱗_下_鱗1CD.不透明度 = value;
				this.親指_竜性_鱗_下_鱗2CD.不透明度 = value;
				this.親指_竜性_鱗_上_鱗1CD.不透明度 = value;
				this.親指_竜性_鱗_上_鱗2CD.不透明度 = value;
				this.親指_竜性_鱗_上_鱗3CD.不透明度 = value;
				this.筋CD.不透明度 = value;
				this.脚輪_革CD.不透明度 = value;
				this.脚輪_金具1CD.不透明度 = value;
				this.脚輪_金具2CD.不透明度 = value;
				this.脚輪_金具3CD.不透明度 = value;
				this.脚輪_金具左CD.不透明度 = value;
				this.脚輪_金具右CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			double num = this.右 ? -1.0 : 1.0;
			this.X0Y0_足.AngleBase = num * -38.0;
			this.X0Y0_薬指_指.AngleBase = num * -6.0;
			this.X0Y0_中指_指.AngleBase = num * -6.0;
			this.X0Y0_人指_指.AngleBase = num * -6.0;
			this.X0Y0_親指_指.AngleBase = num * -6.0;
			this.本体.JoinPAall();
		}

		public JointS 鎖1_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_脚輪_金具左, 0);
			}
		}

		public JointS 鎖2_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_脚輪_金具右, 0);
			}
		}

		public override void 色更新()
		{
			this.X0Y0_足CP.Update();
			this.X0Y0_竜性_鱗足_鱗6CP.Update();
			this.X0Y0_竜性_鱗足_鱗5CP.Update();
			this.X0Y0_竜性_鱗足_鱗4CP.Update();
			this.X0Y0_竜性_鱗足_鱗3CP.Update();
			this.X0Y0_竜性_鱗足_鱗2CP.Update();
			this.X0Y0_竜性_鱗足_鱗1CP.Update();
			this.X0Y0_竜性_鱗踵_鱗1CP.Update();
			this.X0Y0_竜性_鱗踵_鱗2CP.Update();
			this.X0Y0_竜性_鱗踵_鱗3CP.Update();
			this.X0Y0_竜性_鱗甲_鱗11CP.Update();
			this.X0Y0_竜性_鱗甲_鱗10CP.Update();
			this.X0Y0_竜性_鱗甲_鱗9CP.Update();
			this.X0Y0_竜性_鱗甲_鱗8CP.Update();
			this.X0Y0_竜性_鱗甲_鱗7CP.Update();
			this.X0Y0_竜性_鱗甲_鱗6CP.Update();
			this.X0Y0_竜性_鱗甲_鱗5CP.Update();
			this.X0Y0_竜性_鱗甲_鱗4CP.Update();
			this.X0Y0_竜性_鱗甲_鱗3CP.Update();
			this.X0Y0_竜性_鱗甲_鱗2CP.Update();
			this.X0Y0_竜性_鱗甲_鱗1CP.Update();
			this.X0Y0_薬指_指CP.Update();
			this.X0Y0_薬指_爪CP.Update();
			this.X0Y0_薬指_竜性_鱗_下_鱗1CP.Update();
			this.X0Y0_薬指_竜性_鱗_下_鱗2CP.Update();
			this.X0Y0_薬指_竜性_鱗_上_鱗1CP.Update();
			this.X0Y0_薬指_竜性_鱗_上_鱗2CP.Update();
			this.X0Y0_薬指_竜性_鱗_上_鱗3CP.Update();
			this.X0Y0_中指_指CP.Update();
			this.X0Y0_中指_爪CP.Update();
			this.X0Y0_中指_竜性_鱗_下_鱗1CP.Update();
			this.X0Y0_中指_竜性_鱗_下_鱗2CP.Update();
			this.X0Y0_中指_竜性_鱗_上_鱗1CP.Update();
			this.X0Y0_中指_竜性_鱗_上_鱗2CP.Update();
			this.X0Y0_中指_竜性_鱗_上_鱗3CP.Update();
			this.X0Y0_人指_指CP.Update();
			this.X0Y0_人指_爪CP.Update();
			this.X0Y0_人指_竜性_鱗_下_鱗1CP.Update();
			this.X0Y0_人指_竜性_鱗_下_鱗2CP.Update();
			this.X0Y0_人指_竜性_鱗_上_鱗1CP.Update();
			this.X0Y0_人指_竜性_鱗_上_鱗2CP.Update();
			this.X0Y0_人指_竜性_鱗_上_鱗3CP.Update();
			this.X0Y0_親指_指CP.Update();
			this.X0Y0_親指_爪CP.Update();
			this.X0Y0_親指_竜性_鱗_下_鱗1CP.Update();
			this.X0Y0_親指_竜性_鱗_下_鱗2CP.Update();
			this.X0Y0_親指_竜性_鱗_上_鱗1CP.Update();
			this.X0Y0_親指_竜性_鱗_上_鱗2CP.Update();
			this.X0Y0_親指_竜性_鱗_上_鱗3CP.Update();
			this.X0Y0_筋CP.Update();
			this.X0Y0_脚輪_革CP.Update();
			this.X0Y0_脚輪_金具1CP.Update();
			this.X0Y0_脚輪_金具2CP.Update();
			this.X0Y0_脚輪_金具3CP.Update();
			this.X0Y0_脚輪_金具左CP.Update();
			this.X0Y0_脚輪_金具右CP.Update();
			this.鎖1.接続PA();
			this.鎖1.色更新();
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
			this.足CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.竜性_鱗足_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗足_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗足_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗足_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗足_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗足_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗踵_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗踵_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗踵_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗甲_鱗11CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗甲_鱗10CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗甲_鱗9CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗甲_鱗8CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗甲_鱗7CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗甲_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗甲_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗甲_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗甲_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗甲_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗甲_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.薬指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.薬指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.薬指_竜性_鱗_下_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.薬指_竜性_鱗_下_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.薬指_竜性_鱗_上_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.薬指_竜性_鱗_上_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.薬指_竜性_鱗_上_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.中指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.中指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.中指_竜性_鱗_下_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.中指_竜性_鱗_下_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.中指_竜性_鱗_上_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.中指_竜性_鱗_上_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.中指_竜性_鱗_上_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.人指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.人指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.人指_竜性_鱗_下_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.人指_竜性_鱗_下_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.人指_竜性_鱗_上_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.人指_竜性_鱗_上_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.人指_竜性_鱗_上_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.親指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.親指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.親指_竜性_鱗_下_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.親指_竜性_鱗_下_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.親指_竜性_鱗_上_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.親指_竜性_鱗_上_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.親指_竜性_鱗_上_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.筋CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.脚輪_革CD = new ColorD();
			this.脚輪_金具1CD = new ColorD();
			this.脚輪_金具2CD = new ColorD();
			this.脚輪_金具3CD = new ColorD();
			this.脚輪_金具左CD = new ColorD();
			this.脚輪_金具右CD = new ColorD();
		}

		private void 配色T0(体配色 体配色)
		{
			this.足CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.竜性_鱗足_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗足_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗足_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗足_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗足_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗足_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗踵_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_鱗踵_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗踵_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_鱗甲_鱗11CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗甲_鱗10CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_鱗甲_鱗9CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗甲_鱗8CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_鱗甲_鱗7CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗甲_鱗6CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_鱗甲_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗甲_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_鱗甲_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗甲_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_鱗甲_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.薬指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.薬指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.薬指_竜性_鱗_下_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.薬指_竜性_鱗_下_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.薬指_竜性_鱗_上_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.薬指_竜性_鱗_上_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.薬指_竜性_鱗_上_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.中指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.中指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.中指_竜性_鱗_下_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.中指_竜性_鱗_下_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.中指_竜性_鱗_上_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.中指_竜性_鱗_上_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.中指_竜性_鱗_上_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.人指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.人指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.人指_竜性_鱗_下_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.人指_竜性_鱗_下_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.人指_竜性_鱗_上_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.人指_竜性_鱗_上_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.人指_竜性_鱗_上_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.親指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.親指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.親指_竜性_鱗_下_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.親指_竜性_鱗_下_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.親指_竜性_鱗_上_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.親指_竜性_鱗_上_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.親指_竜性_鱗_上_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.筋CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.脚輪_革CD = new ColorD();
			this.脚輪_金具1CD = new ColorD();
			this.脚輪_金具2CD = new ColorD();
			this.脚輪_金具3CD = new ColorD();
			this.脚輪_金具左CD = new ColorD();
			this.脚輪_金具右CD = new ColorD();
		}

		private void 配色T1(体配色 体配色)
		{
			this.足CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.竜性_鱗足_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗足_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗足_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗足_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗足_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗足_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗踵_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗踵_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_鱗踵_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗甲_鱗11CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_鱗甲_鱗10CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗甲_鱗9CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_鱗甲_鱗8CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗甲_鱗7CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_鱗甲_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗甲_鱗5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_鱗甲_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗甲_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_鱗甲_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗甲_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.薬指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.薬指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.薬指_竜性_鱗_下_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.薬指_竜性_鱗_下_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.薬指_竜性_鱗_上_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.薬指_竜性_鱗_上_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.薬指_竜性_鱗_上_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.中指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.中指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.中指_竜性_鱗_下_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.中指_竜性_鱗_下_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.中指_竜性_鱗_上_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.中指_竜性_鱗_上_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.中指_竜性_鱗_上_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.人指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.人指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.人指_竜性_鱗_下_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.人指_竜性_鱗_下_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.人指_竜性_鱗_上_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.人指_竜性_鱗_上_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.人指_竜性_鱗_上_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.親指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.親指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.親指_竜性_鱗_下_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.親指_竜性_鱗_下_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.親指_竜性_鱗_上_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.親指_竜性_鱗_上_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.親指_竜性_鱗_上_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.筋CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.脚輪_革CD = new ColorD();
			this.脚輪_金具1CD = new ColorD();
			this.脚輪_金具2CD = new ColorD();
			this.脚輪_金具3CD = new ColorD();
			this.脚輪_金具左CD = new ColorD();
			this.脚輪_金具右CD = new ColorD();
		}

		public void 脚輪配色(拘束具色 配色)
		{
			this.脚輪_革CD.色 = 配色.革部色;
			this.脚輪_金具1CD.色 = 配色.金具色;
			this.脚輪_金具2CD.色 = this.脚輪_金具1CD.色;
			this.脚輪_金具3CD.色 = this.脚輪_金具1CD.色;
			this.脚輪_金具左CD.色 = this.脚輪_金具1CD.色;
			this.脚輪_金具右CD.色 = this.脚輪_金具1CD.色;
		}

		public void 鎖配色(鎖色 配色)
		{
			this.鎖1.配色鎖(配色);
		}

		public Par X0Y0_足;

		public Par X0Y0_竜性_鱗足_鱗6;

		public Par X0Y0_竜性_鱗足_鱗5;

		public Par X0Y0_竜性_鱗足_鱗4;

		public Par X0Y0_竜性_鱗足_鱗3;

		public Par X0Y0_竜性_鱗足_鱗2;

		public Par X0Y0_竜性_鱗足_鱗1;

		public Par X0Y0_竜性_鱗踵_鱗1;

		public Par X0Y0_竜性_鱗踵_鱗2;

		public Par X0Y0_竜性_鱗踵_鱗3;

		public Par X0Y0_竜性_鱗甲_鱗11;

		public Par X0Y0_竜性_鱗甲_鱗10;

		public Par X0Y0_竜性_鱗甲_鱗9;

		public Par X0Y0_竜性_鱗甲_鱗8;

		public Par X0Y0_竜性_鱗甲_鱗7;

		public Par X0Y0_竜性_鱗甲_鱗6;

		public Par X0Y0_竜性_鱗甲_鱗5;

		public Par X0Y0_竜性_鱗甲_鱗4;

		public Par X0Y0_竜性_鱗甲_鱗3;

		public Par X0Y0_竜性_鱗甲_鱗2;

		public Par X0Y0_竜性_鱗甲_鱗1;

		public Par X0Y0_薬指_指;

		public Par X0Y0_薬指_爪;

		public Par X0Y0_薬指_竜性_鱗_下_鱗1;

		public Par X0Y0_薬指_竜性_鱗_下_鱗2;

		public Par X0Y0_薬指_竜性_鱗_上_鱗1;

		public Par X0Y0_薬指_竜性_鱗_上_鱗2;

		public Par X0Y0_薬指_竜性_鱗_上_鱗3;

		public Par X0Y0_中指_指;

		public Par X0Y0_中指_爪;

		public Par X0Y0_中指_竜性_鱗_下_鱗1;

		public Par X0Y0_中指_竜性_鱗_下_鱗2;

		public Par X0Y0_中指_竜性_鱗_上_鱗1;

		public Par X0Y0_中指_竜性_鱗_上_鱗2;

		public Par X0Y0_中指_竜性_鱗_上_鱗3;

		public Par X0Y0_人指_指;

		public Par X0Y0_人指_爪;

		public Par X0Y0_人指_竜性_鱗_下_鱗1;

		public Par X0Y0_人指_竜性_鱗_下_鱗2;

		public Par X0Y0_人指_竜性_鱗_上_鱗1;

		public Par X0Y0_人指_竜性_鱗_上_鱗2;

		public Par X0Y0_人指_竜性_鱗_上_鱗3;

		public Par X0Y0_親指_指;

		public Par X0Y0_親指_爪;

		public Par X0Y0_親指_竜性_鱗_下_鱗1;

		public Par X0Y0_親指_竜性_鱗_下_鱗2;

		public Par X0Y0_親指_竜性_鱗_上_鱗1;

		public Par X0Y0_親指_竜性_鱗_上_鱗2;

		public Par X0Y0_親指_竜性_鱗_上_鱗3;

		public Par X0Y0_筋;

		public Par X0Y0_脚輪_革;

		public Par X0Y0_脚輪_金具1;

		public Par X0Y0_脚輪_金具2;

		public Par X0Y0_脚輪_金具3;

		public Par X0Y0_脚輪_金具左;

		public Par X0Y0_脚輪_金具右;

		public ColorD 足CD;

		public ColorD 竜性_鱗足_鱗6CD;

		public ColorD 竜性_鱗足_鱗5CD;

		public ColorD 竜性_鱗足_鱗4CD;

		public ColorD 竜性_鱗足_鱗3CD;

		public ColorD 竜性_鱗足_鱗2CD;

		public ColorD 竜性_鱗足_鱗1CD;

		public ColorD 竜性_鱗踵_鱗1CD;

		public ColorD 竜性_鱗踵_鱗2CD;

		public ColorD 竜性_鱗踵_鱗3CD;

		public ColorD 竜性_鱗甲_鱗11CD;

		public ColorD 竜性_鱗甲_鱗10CD;

		public ColorD 竜性_鱗甲_鱗9CD;

		public ColorD 竜性_鱗甲_鱗8CD;

		public ColorD 竜性_鱗甲_鱗7CD;

		public ColorD 竜性_鱗甲_鱗6CD;

		public ColorD 竜性_鱗甲_鱗5CD;

		public ColorD 竜性_鱗甲_鱗4CD;

		public ColorD 竜性_鱗甲_鱗3CD;

		public ColorD 竜性_鱗甲_鱗2CD;

		public ColorD 竜性_鱗甲_鱗1CD;

		public ColorD 薬指_指CD;

		public ColorD 薬指_爪CD;

		public ColorD 薬指_竜性_鱗_下_鱗1CD;

		public ColorD 薬指_竜性_鱗_下_鱗2CD;

		public ColorD 薬指_竜性_鱗_上_鱗1CD;

		public ColorD 薬指_竜性_鱗_上_鱗2CD;

		public ColorD 薬指_竜性_鱗_上_鱗3CD;

		public ColorD 中指_指CD;

		public ColorD 中指_爪CD;

		public ColorD 中指_竜性_鱗_下_鱗1CD;

		public ColorD 中指_竜性_鱗_下_鱗2CD;

		public ColorD 中指_竜性_鱗_上_鱗1CD;

		public ColorD 中指_竜性_鱗_上_鱗2CD;

		public ColorD 中指_竜性_鱗_上_鱗3CD;

		public ColorD 人指_指CD;

		public ColorD 人指_爪CD;

		public ColorD 人指_竜性_鱗_下_鱗1CD;

		public ColorD 人指_竜性_鱗_下_鱗2CD;

		public ColorD 人指_竜性_鱗_上_鱗1CD;

		public ColorD 人指_竜性_鱗_上_鱗2CD;

		public ColorD 人指_竜性_鱗_上_鱗3CD;

		public ColorD 親指_指CD;

		public ColorD 親指_爪CD;

		public ColorD 親指_竜性_鱗_下_鱗1CD;

		public ColorD 親指_竜性_鱗_下_鱗2CD;

		public ColorD 親指_竜性_鱗_上_鱗1CD;

		public ColorD 親指_竜性_鱗_上_鱗2CD;

		public ColorD 親指_竜性_鱗_上_鱗3CD;

		public ColorD 筋CD;

		public ColorD 脚輪_革CD;

		public ColorD 脚輪_金具1CD;

		public ColorD 脚輪_金具2CD;

		public ColorD 脚輪_金具3CD;

		public ColorD 脚輪_金具左CD;

		public ColorD 脚輪_金具右CD;

		public ColorP X0Y0_足CP;

		public ColorP X0Y0_竜性_鱗足_鱗6CP;

		public ColorP X0Y0_竜性_鱗足_鱗5CP;

		public ColorP X0Y0_竜性_鱗足_鱗4CP;

		public ColorP X0Y0_竜性_鱗足_鱗3CP;

		public ColorP X0Y0_竜性_鱗足_鱗2CP;

		public ColorP X0Y0_竜性_鱗足_鱗1CP;

		public ColorP X0Y0_竜性_鱗踵_鱗1CP;

		public ColorP X0Y0_竜性_鱗踵_鱗2CP;

		public ColorP X0Y0_竜性_鱗踵_鱗3CP;

		public ColorP X0Y0_竜性_鱗甲_鱗11CP;

		public ColorP X0Y0_竜性_鱗甲_鱗10CP;

		public ColorP X0Y0_竜性_鱗甲_鱗9CP;

		public ColorP X0Y0_竜性_鱗甲_鱗8CP;

		public ColorP X0Y0_竜性_鱗甲_鱗7CP;

		public ColorP X0Y0_竜性_鱗甲_鱗6CP;

		public ColorP X0Y0_竜性_鱗甲_鱗5CP;

		public ColorP X0Y0_竜性_鱗甲_鱗4CP;

		public ColorP X0Y0_竜性_鱗甲_鱗3CP;

		public ColorP X0Y0_竜性_鱗甲_鱗2CP;

		public ColorP X0Y0_竜性_鱗甲_鱗1CP;

		public ColorP X0Y0_薬指_指CP;

		public ColorP X0Y0_薬指_爪CP;

		public ColorP X0Y0_薬指_竜性_鱗_下_鱗1CP;

		public ColorP X0Y0_薬指_竜性_鱗_下_鱗2CP;

		public ColorP X0Y0_薬指_竜性_鱗_上_鱗1CP;

		public ColorP X0Y0_薬指_竜性_鱗_上_鱗2CP;

		public ColorP X0Y0_薬指_竜性_鱗_上_鱗3CP;

		public ColorP X0Y0_中指_指CP;

		public ColorP X0Y0_中指_爪CP;

		public ColorP X0Y0_中指_竜性_鱗_下_鱗1CP;

		public ColorP X0Y0_中指_竜性_鱗_下_鱗2CP;

		public ColorP X0Y0_中指_竜性_鱗_上_鱗1CP;

		public ColorP X0Y0_中指_竜性_鱗_上_鱗2CP;

		public ColorP X0Y0_中指_竜性_鱗_上_鱗3CP;

		public ColorP X0Y0_人指_指CP;

		public ColorP X0Y0_人指_爪CP;

		public ColorP X0Y0_人指_竜性_鱗_下_鱗1CP;

		public ColorP X0Y0_人指_竜性_鱗_下_鱗2CP;

		public ColorP X0Y0_人指_竜性_鱗_上_鱗1CP;

		public ColorP X0Y0_人指_竜性_鱗_上_鱗2CP;

		public ColorP X0Y0_人指_竜性_鱗_上_鱗3CP;

		public ColorP X0Y0_親指_指CP;

		public ColorP X0Y0_親指_爪CP;

		public ColorP X0Y0_親指_竜性_鱗_下_鱗1CP;

		public ColorP X0Y0_親指_竜性_鱗_下_鱗2CP;

		public ColorP X0Y0_親指_竜性_鱗_上_鱗1CP;

		public ColorP X0Y0_親指_竜性_鱗_上_鱗2CP;

		public ColorP X0Y0_親指_竜性_鱗_上_鱗3CP;

		public ColorP X0Y0_筋CP;

		public ColorP X0Y0_脚輪_革CP;

		public ColorP X0Y0_脚輪_金具1CP;

		public ColorP X0Y0_脚輪_金具2CP;

		public ColorP X0Y0_脚輪_金具3CP;

		public ColorP X0Y0_脚輪_金具左CP;

		public ColorP X0Y0_脚輪_金具右CP;

		public 拘束鎖 鎖1;
	}
}
