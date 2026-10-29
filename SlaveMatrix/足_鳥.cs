using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 足_鳥 : 獣足
	{
		public 足_鳥(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 足_鳥D e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "鳥";
			dif.Add(new Pars(Sta.脚左["四足足"][2][0]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_足 = pars["足"].ToPar();
			this.X0Y0_筋 = pars["筋"].ToPar();
			this.X0Y0_足首 = pars["足首"].ToPar();
			Pars pars2 = pars["足首鱗"].ToPars();
			this.X0Y0_足首鱗_竜性_竜性_鱗1 = pars2["鱗1"].ToPar();
			this.X0Y0_足首鱗_竜性_竜性_鱗2 = pars2["鱗2"].ToPar();
			this.X0Y0_足首鱗_竜性_竜性_鱗3 = pars2["鱗3"].ToPar();
			pars2 = pars["踵鱗"].ToPars();
			this.X0Y0_踵鱗_竜性_竜性_鱗3 = pars2["鱗3"].ToPar();
			this.X0Y0_踵鱗_竜性_竜性_鱗2 = pars2["鱗2"].ToPar();
			this.X0Y0_踵鱗_竜性_竜性_鱗1 = pars2["鱗1"].ToPar();
			this.X0Y0_竜性_鱗 = pars["鱗"].ToPar();
			pars2 = pars["足鱗"].ToPars();
			this.X0Y0_足鱗_竜性_竜性_鱗1 = pars2["鱗1"].ToPar();
			this.X0Y0_足鱗_竜性_竜性_鱗2 = pars2["鱗2"].ToPar();
			this.X0Y0_足鱗_竜性_竜性_鱗3 = pars2["鱗3"].ToPar();
			this.X0Y0_足鱗_竜性_竜性_鱗4 = pars2["鱗4"].ToPar();
			this.X0Y0_足鱗_竜性_竜性_鱗5 = pars2["鱗5"].ToPar();
			this.X0Y0_足鱗_竜性_竜性_鱗6 = pars2["鱗6"].ToPar();
			this.X0Y0_足鱗_竜性_竜性_鱗7 = pars2["鱗7"].ToPar();
			this.X0Y0_足鱗_竜性_竜性_鱗8 = pars2["鱗8"].ToPar();
			this.X0Y0_足鱗_竜性_竜性_鱗9 = pars2["鱗9"].ToPar();
			this.X0Y0_足鱗_竜性_竜性_鱗10 = pars2["鱗10"].ToPar();
			this.X0Y0_足鱗_竜性_竜性_鱗11 = pars2["鱗11"].ToPar();
			pars2 = pars["薬指"].ToPars();
			this.X0Y0_薬指_爪 = pars2["爪"].ToPar();
			this.X0Y0_薬指_指3 = pars2["指3"].ToPar();
			this.X0Y0_薬指_指2 = pars2["指2"].ToPar();
			this.X0Y0_薬指_指1 = pars2["指1"].ToPar();
			Pars pars3 = pars2["鱗3"].ToPars();
			this.X0Y0_薬指_竜性_鱗3_竜性_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_薬指_竜性_鱗3_竜性_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_薬指_竜性_鱗3_竜性_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_薬指_竜性_鱗3_竜性_鱗4 = pars3["鱗4"].ToPar();
			pars3 = pars2["鱗2"].ToPars();
			this.X0Y0_薬指_竜性_鱗2_竜性_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_薬指_竜性_鱗2_竜性_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_薬指_竜性_鱗2_竜性_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_薬指_竜性_鱗2_竜性_鱗4 = pars3["鱗4"].ToPar();
			pars3 = pars2["鱗1"].ToPars();
			this.X0Y0_薬指_竜性_鱗1_竜性_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_薬指_竜性_鱗1_竜性_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_薬指_竜性_鱗1_竜性_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_薬指_竜性_鱗1_竜性_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_薬指_竜性_鱗1_竜性_鱗5 = pars3["鱗5"].ToPar();
			this.X0Y0_薬指_竜性_鱗1_竜性_鱗6 = pars3["鱗6"].ToPar();
			pars2 = pars["中指"].ToPars();
			this.X0Y0_中指_爪 = pars2["爪"].ToPar();
			this.X0Y0_中指_指3 = pars2["指3"].ToPar();
			this.X0Y0_中指_指2 = pars2["指2"].ToPar();
			this.X0Y0_中指_指1 = pars2["指1"].ToPar();
			pars3 = pars2["鱗3"].ToPars();
			this.X0Y0_中指_竜性_鱗3_竜性_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_中指_竜性_鱗3_竜性_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_中指_竜性_鱗3_竜性_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_中指_竜性_鱗3_竜性_鱗4 = pars3["鱗4"].ToPar();
			pars3 = pars2["鱗2"].ToPars();
			this.X0Y0_中指_竜性_鱗2_竜性_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_中指_竜性_鱗2_竜性_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_中指_竜性_鱗2_竜性_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_中指_竜性_鱗2_竜性_鱗4 = pars3["鱗4"].ToPar();
			pars3 = pars2["鱗1"].ToPars();
			this.X0Y0_中指_竜性_鱗1_竜性_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_中指_竜性_鱗1_竜性_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_中指_竜性_鱗1_竜性_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_中指_竜性_鱗1_竜性_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_中指_竜性_鱗1_竜性_鱗5 = pars3["鱗5"].ToPar();
			this.X0Y0_中指_竜性_鱗1_竜性_鱗6 = pars3["鱗6"].ToPar();
			pars2 = pars["人指"].ToPars();
			this.X0Y0_人指_爪 = pars2["爪"].ToPar();
			this.X0Y0_人指_指2 = pars2["指2"].ToPar();
			this.X0Y0_人指_指1 = pars2["指1"].ToPar();
			pars3 = pars2["鱗2"].ToPars();
			this.X0Y0_人指_竜性_鱗2_竜性_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_人指_竜性_鱗2_竜性_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_人指_竜性_鱗2_竜性_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_人指_竜性_鱗2_竜性_鱗4 = pars3["鱗4"].ToPar();
			pars3 = pars2["鱗1"].ToPars();
			this.X0Y0_人指_竜性_鱗1_竜性_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_人指_竜性_鱗1_竜性_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_人指_竜性_鱗1_竜性_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_人指_竜性_鱗1_竜性_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_人指_竜性_鱗1_竜性_鱗5 = pars3["鱗5"].ToPar();
			this.X0Y0_人指_竜性_鱗1_竜性_鱗6 = pars3["鱗6"].ToPar();
			pars2 = pars["脚輪"].ToPars();
			this.X0Y0_脚輪_革 = pars2["革"].ToPar();
			this.X0Y0_脚輪_金具1 = pars2["金具1"].ToPar();
			this.X0Y0_脚輪_金具2 = pars2["金具2"].ToPar();
			this.X0Y0_脚輪_金具3 = pars2["金具3"].ToPar();
			this.X0Y0_脚輪_金具左 = pars2["金具左"].ToPar();
			this.X0Y0_脚輪_金具右 = pars2["金具右"].ToPar();
			pars2 = pars["親指"].ToPars();
			this.X0Y0_親指_爪 = pars2["爪"].ToPar();
			this.X0Y0_親指_指1 = pars2["指1"].ToPar();
			pars3 = pars2["鱗1"].ToPars();
			this.X0Y0_親指_竜性_鱗1_竜性_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_親指_竜性_鱗1_竜性_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_親指_竜性_鱗1_竜性_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_親指_竜性_鱗1_竜性_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_親指_竜性_鱗1_竜性_鱗5 = pars3["鱗5"].ToPar();
			this.X0Y0_親指_竜性_鱗1_竜性_鱗6 = pars3["鱗6"].ToPar();
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
			this.筋_表示 = e.筋_表示;
			this.足首_表示 = e.足首_表示;
			this.足首鱗_竜性_鱗1_表示 = e.足首鱗_竜性_鱗1_表示;
			this.足首鱗_竜性_鱗2_表示 = e.足首鱗_竜性_鱗2_表示;
			this.足首鱗_竜性_鱗3_表示 = e.足首鱗_竜性_鱗3_表示;
			this.踵鱗_竜性_鱗3_表示 = e.踵鱗_竜性_鱗3_表示;
			this.踵鱗_竜性_鱗2_表示 = e.踵鱗_竜性_鱗2_表示;
			this.踵鱗_竜性_鱗1_表示 = e.踵鱗_竜性_鱗1_表示;
			this.竜性_鱗_表示 = e.竜性_鱗_表示;
			this.足鱗_竜性_鱗1_表示 = e.足鱗_竜性_鱗1_表示;
			this.足鱗_竜性_鱗2_表示 = e.足鱗_竜性_鱗2_表示;
			this.足鱗_竜性_鱗3_表示 = e.足鱗_竜性_鱗3_表示;
			this.足鱗_竜性_鱗4_表示 = e.足鱗_竜性_鱗4_表示;
			this.足鱗_竜性_鱗5_表示 = e.足鱗_竜性_鱗5_表示;
			this.足鱗_竜性_鱗6_表示 = e.足鱗_竜性_鱗6_表示;
			this.足鱗_竜性_鱗7_表示 = e.足鱗_竜性_鱗7_表示;
			this.足鱗_竜性_鱗8_表示 = e.足鱗_竜性_鱗8_表示;
			this.足鱗_竜性_鱗9_表示 = e.足鱗_竜性_鱗9_表示;
			this.足鱗_竜性_鱗10_表示 = e.足鱗_竜性_鱗10_表示;
			this.足鱗_竜性_鱗11_表示 = e.足鱗_竜性_鱗11_表示;
			this.薬指_爪_表示 = e.薬指_爪_表示;
			this.薬指_指3_表示 = e.薬指_指3_表示;
			this.薬指_指2_表示 = e.薬指_指2_表示;
			this.薬指_指1_表示 = e.薬指_指1_表示;
			this.薬指_竜性_鱗3_鱗1_表示 = e.薬指_竜性_鱗3_鱗1_表示;
			this.薬指_竜性_鱗3_鱗2_表示 = e.薬指_竜性_鱗3_鱗2_表示;
			this.薬指_竜性_鱗3_鱗3_表示 = e.薬指_竜性_鱗3_鱗3_表示;
			this.薬指_竜性_鱗3_鱗4_表示 = e.薬指_竜性_鱗3_鱗4_表示;
			this.薬指_竜性_鱗2_鱗1_表示 = e.薬指_竜性_鱗2_鱗1_表示;
			this.薬指_竜性_鱗2_鱗2_表示 = e.薬指_竜性_鱗2_鱗2_表示;
			this.薬指_竜性_鱗2_鱗3_表示 = e.薬指_竜性_鱗2_鱗3_表示;
			this.薬指_竜性_鱗2_鱗4_表示 = e.薬指_竜性_鱗2_鱗4_表示;
			this.薬指_竜性_鱗1_鱗1_表示 = e.薬指_竜性_鱗1_鱗1_表示;
			this.薬指_竜性_鱗1_鱗2_表示 = e.薬指_竜性_鱗1_鱗2_表示;
			this.薬指_竜性_鱗1_鱗3_表示 = e.薬指_竜性_鱗1_鱗3_表示;
			this.薬指_竜性_鱗1_鱗4_表示 = e.薬指_竜性_鱗1_鱗4_表示;
			this.薬指_竜性_鱗1_鱗5_表示 = e.薬指_竜性_鱗1_鱗5_表示;
			this.薬指_竜性_鱗1_鱗6_表示 = e.薬指_竜性_鱗1_鱗6_表示;
			this.中指_爪_表示 = e.中指_爪_表示;
			this.中指_指3_表示 = e.中指_指3_表示;
			this.中指_指2_表示 = e.中指_指2_表示;
			this.中指_指1_表示 = e.中指_指1_表示;
			this.中指_竜性_鱗3_鱗1_表示 = e.中指_竜性_鱗3_鱗1_表示;
			this.中指_竜性_鱗3_鱗2_表示 = e.中指_竜性_鱗3_鱗2_表示;
			this.中指_竜性_鱗3_鱗3_表示 = e.中指_竜性_鱗3_鱗3_表示;
			this.中指_竜性_鱗3_鱗4_表示 = e.中指_竜性_鱗3_鱗4_表示;
			this.中指_竜性_鱗2_鱗1_表示 = e.中指_竜性_鱗2_鱗1_表示;
			this.中指_竜性_鱗2_鱗2_表示 = e.中指_竜性_鱗2_鱗2_表示;
			this.中指_竜性_鱗2_鱗3_表示 = e.中指_竜性_鱗2_鱗3_表示;
			this.中指_竜性_鱗2_鱗4_表示 = e.中指_竜性_鱗2_鱗4_表示;
			this.中指_竜性_鱗1_鱗1_表示 = e.中指_竜性_鱗1_鱗1_表示;
			this.中指_竜性_鱗1_鱗2_表示 = e.中指_竜性_鱗1_鱗2_表示;
			this.中指_竜性_鱗1_鱗3_表示 = e.中指_竜性_鱗1_鱗3_表示;
			this.中指_竜性_鱗1_鱗4_表示 = e.中指_竜性_鱗1_鱗4_表示;
			this.中指_竜性_鱗1_鱗5_表示 = e.中指_竜性_鱗1_鱗5_表示;
			this.中指_竜性_鱗1_鱗6_表示 = e.中指_竜性_鱗1_鱗6_表示;
			this.人指_爪_表示 = e.人指_爪_表示;
			this.人指_指2_表示 = e.人指_指2_表示;
			this.人指_指1_表示 = e.人指_指1_表示;
			this.人指_竜性_鱗2_鱗1_表示 = e.人指_竜性_鱗2_鱗1_表示;
			this.人指_竜性_鱗2_鱗2_表示 = e.人指_竜性_鱗2_鱗2_表示;
			this.人指_竜性_鱗2_鱗3_表示 = e.人指_竜性_鱗2_鱗3_表示;
			this.人指_竜性_鱗2_鱗4_表示 = e.人指_竜性_鱗2_鱗4_表示;
			this.人指_竜性_鱗1_鱗1_表示 = e.人指_竜性_鱗1_鱗1_表示;
			this.人指_竜性_鱗1_鱗2_表示 = e.人指_竜性_鱗1_鱗2_表示;
			this.人指_竜性_鱗1_鱗3_表示 = e.人指_竜性_鱗1_鱗3_表示;
			this.人指_竜性_鱗1_鱗4_表示 = e.人指_竜性_鱗1_鱗4_表示;
			this.人指_竜性_鱗1_鱗5_表示 = e.人指_竜性_鱗1_鱗5_表示;
			this.人指_竜性_鱗1_鱗6_表示 = e.人指_竜性_鱗1_鱗6_表示;
			this.脚輪_革_表示 = e.脚輪_革_表示;
			this.脚輪_金具1_表示 = e.脚輪_金具1_表示;
			this.脚輪_金具2_表示 = e.脚輪_金具2_表示;
			this.脚輪_金具3_表示 = e.脚輪_金具3_表示;
			this.脚輪_金具左_表示 = e.脚輪_金具左_表示;
			this.脚輪_金具右_表示 = e.脚輪_金具右_表示;
			this.親指_爪_表示 = e.親指_爪_表示;
			this.親指_指1_表示 = e.親指_指1_表示;
			this.親指_竜性_鱗1_鱗1_表示 = e.親指_竜性_鱗1_鱗1_表示;
			this.親指_竜性_鱗1_鱗2_表示 = e.親指_竜性_鱗1_鱗2_表示;
			this.親指_竜性_鱗1_鱗3_表示 = e.親指_竜性_鱗1_鱗3_表示;
			this.親指_竜性_鱗1_鱗4_表示 = e.親指_竜性_鱗1_鱗4_表示;
			this.親指_竜性_鱗1_鱗5_表示 = e.親指_竜性_鱗1_鱗5_表示;
			this.親指_竜性_鱗1_鱗6_表示 = e.親指_竜性_鱗1_鱗6_表示;
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
			this.X0Y0_筋CP = new ColorP(this.X0Y0_筋, this.筋CD, DisUnit, false);
			this.X0Y0_足首CP = new ColorP(this.X0Y0_足首, this.足首CD, DisUnit, true);
			this.X0Y0_足首鱗_竜性_竜性_鱗1CP = new ColorP(this.X0Y0_足首鱗_竜性_竜性_鱗1, this.足首鱗_竜性_鱗1CD, DisUnit, true);
			this.X0Y0_足首鱗_竜性_竜性_鱗2CP = new ColorP(this.X0Y0_足首鱗_竜性_竜性_鱗2, this.足首鱗_竜性_鱗2CD, DisUnit, true);
			this.X0Y0_足首鱗_竜性_竜性_鱗3CP = new ColorP(this.X0Y0_足首鱗_竜性_竜性_鱗3, this.足首鱗_竜性_鱗3CD, DisUnit, true);
			this.X0Y0_踵鱗_竜性_竜性_鱗3CP = new ColorP(this.X0Y0_踵鱗_竜性_竜性_鱗3, this.踵鱗_竜性_鱗3CD, DisUnit, true);
			this.X0Y0_踵鱗_竜性_竜性_鱗2CP = new ColorP(this.X0Y0_踵鱗_竜性_竜性_鱗2, this.踵鱗_竜性_鱗2CD, DisUnit, true);
			this.X0Y0_踵鱗_竜性_竜性_鱗1CP = new ColorP(this.X0Y0_踵鱗_竜性_竜性_鱗1, this.踵鱗_竜性_鱗1CD, DisUnit, true);
			this.X0Y0_竜性_鱗CP = new ColorP(this.X0Y0_竜性_鱗, this.鱗CD, DisUnit, true);
			this.X0Y0_足鱗_竜性_竜性_鱗1CP = new ColorP(this.X0Y0_足鱗_竜性_竜性_鱗1, this.足鱗_竜性_鱗1CD, DisUnit, true);
			this.X0Y0_足鱗_竜性_竜性_鱗2CP = new ColorP(this.X0Y0_足鱗_竜性_竜性_鱗2, this.足鱗_竜性_鱗2CD, DisUnit, true);
			this.X0Y0_足鱗_竜性_竜性_鱗3CP = new ColorP(this.X0Y0_足鱗_竜性_竜性_鱗3, this.足鱗_竜性_鱗3CD, DisUnit, true);
			this.X0Y0_足鱗_竜性_竜性_鱗4CP = new ColorP(this.X0Y0_足鱗_竜性_竜性_鱗4, this.足鱗_竜性_鱗4CD, DisUnit, true);
			this.X0Y0_足鱗_竜性_竜性_鱗5CP = new ColorP(this.X0Y0_足鱗_竜性_竜性_鱗5, this.足鱗_竜性_鱗5CD, DisUnit, true);
			this.X0Y0_足鱗_竜性_竜性_鱗6CP = new ColorP(this.X0Y0_足鱗_竜性_竜性_鱗6, this.足鱗_竜性_鱗6CD, DisUnit, true);
			this.X0Y0_足鱗_竜性_竜性_鱗7CP = new ColorP(this.X0Y0_足鱗_竜性_竜性_鱗7, this.足鱗_竜性_鱗7CD, DisUnit, true);
			this.X0Y0_足鱗_竜性_竜性_鱗8CP = new ColorP(this.X0Y0_足鱗_竜性_竜性_鱗8, this.足鱗_竜性_鱗8CD, DisUnit, true);
			this.X0Y0_足鱗_竜性_竜性_鱗9CP = new ColorP(this.X0Y0_足鱗_竜性_竜性_鱗9, this.足鱗_竜性_鱗9CD, DisUnit, true);
			this.X0Y0_足鱗_竜性_竜性_鱗10CP = new ColorP(this.X0Y0_足鱗_竜性_竜性_鱗10, this.足鱗_竜性_鱗10CD, DisUnit, true);
			this.X0Y0_足鱗_竜性_竜性_鱗11CP = new ColorP(this.X0Y0_足鱗_竜性_竜性_鱗11, this.足鱗_竜性_鱗11CD, DisUnit, true);
			this.X0Y0_薬指_爪CP = new ColorP(this.X0Y0_薬指_爪, this.薬指_爪CD, DisUnit, true);
			this.X0Y0_薬指_指3CP = new ColorP(this.X0Y0_薬指_指3, this.薬指_指3CD, DisUnit, true);
			this.X0Y0_薬指_指2CP = new ColorP(this.X0Y0_薬指_指2, this.薬指_指2CD, DisUnit, true);
			this.X0Y0_薬指_指1CP = new ColorP(this.X0Y0_薬指_指1, this.薬指_指1CD, DisUnit, true);
			this.X0Y0_薬指_竜性_鱗3_竜性_鱗1CP = new ColorP(this.X0Y0_薬指_竜性_鱗3_竜性_鱗1, this.薬指_竜性_鱗3_竜性_鱗1CD, DisUnit, true);
			this.X0Y0_薬指_竜性_鱗3_竜性_鱗2CP = new ColorP(this.X0Y0_薬指_竜性_鱗3_竜性_鱗2, this.薬指_竜性_鱗3_竜性_鱗2CD, DisUnit, true);
			this.X0Y0_薬指_竜性_鱗3_竜性_鱗3CP = new ColorP(this.X0Y0_薬指_竜性_鱗3_竜性_鱗3, this.薬指_竜性_鱗3_竜性_鱗3CD, DisUnit, true);
			this.X0Y0_薬指_竜性_鱗3_竜性_鱗4CP = new ColorP(this.X0Y0_薬指_竜性_鱗3_竜性_鱗4, this.薬指_竜性_鱗3_竜性_鱗4CD, DisUnit, true);
			this.X0Y0_薬指_竜性_鱗2_竜性_鱗1CP = new ColorP(this.X0Y0_薬指_竜性_鱗2_竜性_鱗1, this.薬指_竜性_鱗2_竜性_鱗1CD, DisUnit, true);
			this.X0Y0_薬指_竜性_鱗2_竜性_鱗2CP = new ColorP(this.X0Y0_薬指_竜性_鱗2_竜性_鱗2, this.薬指_竜性_鱗2_竜性_鱗2CD, DisUnit, true);
			this.X0Y0_薬指_竜性_鱗2_竜性_鱗3CP = new ColorP(this.X0Y0_薬指_竜性_鱗2_竜性_鱗3, this.薬指_竜性_鱗2_竜性_鱗3CD, DisUnit, true);
			this.X0Y0_薬指_竜性_鱗2_竜性_鱗4CP = new ColorP(this.X0Y0_薬指_竜性_鱗2_竜性_鱗4, this.薬指_竜性_鱗2_竜性_鱗4CD, DisUnit, true);
			this.X0Y0_薬指_竜性_鱗1_竜性_鱗1CP = new ColorP(this.X0Y0_薬指_竜性_鱗1_竜性_鱗1, this.薬指_竜性_鱗1_竜性_鱗1CD, DisUnit, true);
			this.X0Y0_薬指_竜性_鱗1_竜性_鱗2CP = new ColorP(this.X0Y0_薬指_竜性_鱗1_竜性_鱗2, this.薬指_竜性_鱗1_竜性_鱗2CD, DisUnit, true);
			this.X0Y0_薬指_竜性_鱗1_竜性_鱗3CP = new ColorP(this.X0Y0_薬指_竜性_鱗1_竜性_鱗3, this.薬指_竜性_鱗1_竜性_鱗3CD, DisUnit, true);
			this.X0Y0_薬指_竜性_鱗1_竜性_鱗4CP = new ColorP(this.X0Y0_薬指_竜性_鱗1_竜性_鱗4, this.薬指_竜性_鱗1_竜性_鱗4CD, DisUnit, true);
			this.X0Y0_薬指_竜性_鱗1_竜性_鱗5CP = new ColorP(this.X0Y0_薬指_竜性_鱗1_竜性_鱗5, this.薬指_竜性_鱗1_竜性_鱗5CD, DisUnit, true);
			this.X0Y0_薬指_竜性_鱗1_竜性_鱗6CP = new ColorP(this.X0Y0_薬指_竜性_鱗1_竜性_鱗6, this.薬指_竜性_鱗1_竜性_鱗6CD, DisUnit, true);
			this.X0Y0_中指_爪CP = new ColorP(this.X0Y0_中指_爪, this.中指_爪CD, DisUnit, true);
			this.X0Y0_中指_指3CP = new ColorP(this.X0Y0_中指_指3, this.中指_指3CD, DisUnit, true);
			this.X0Y0_中指_指2CP = new ColorP(this.X0Y0_中指_指2, this.中指_指2CD, DisUnit, true);
			this.X0Y0_中指_指1CP = new ColorP(this.X0Y0_中指_指1, this.中指_指1CD, DisUnit, true);
			this.X0Y0_中指_竜性_鱗3_竜性_鱗1CP = new ColorP(this.X0Y0_中指_竜性_鱗3_竜性_鱗1, this.中指_竜性_鱗3_竜性_鱗1CD, DisUnit, true);
			this.X0Y0_中指_竜性_鱗3_竜性_鱗2CP = new ColorP(this.X0Y0_中指_竜性_鱗3_竜性_鱗2, this.中指_竜性_鱗3_竜性_鱗2CD, DisUnit, true);
			this.X0Y0_中指_竜性_鱗3_竜性_鱗3CP = new ColorP(this.X0Y0_中指_竜性_鱗3_竜性_鱗3, this.中指_竜性_鱗3_竜性_鱗3CD, DisUnit, true);
			this.X0Y0_中指_竜性_鱗3_竜性_鱗4CP = new ColorP(this.X0Y0_中指_竜性_鱗3_竜性_鱗4, this.中指_竜性_鱗3_竜性_鱗4CD, DisUnit, true);
			this.X0Y0_中指_竜性_鱗2_竜性_鱗1CP = new ColorP(this.X0Y0_中指_竜性_鱗2_竜性_鱗1, this.中指_竜性_鱗2_竜性_鱗1CD, DisUnit, true);
			this.X0Y0_中指_竜性_鱗2_竜性_鱗2CP = new ColorP(this.X0Y0_中指_竜性_鱗2_竜性_鱗2, this.中指_竜性_鱗2_竜性_鱗2CD, DisUnit, true);
			this.X0Y0_中指_竜性_鱗2_竜性_鱗3CP = new ColorP(this.X0Y0_中指_竜性_鱗2_竜性_鱗3, this.中指_竜性_鱗2_竜性_鱗3CD, DisUnit, true);
			this.X0Y0_中指_竜性_鱗2_竜性_鱗4CP = new ColorP(this.X0Y0_中指_竜性_鱗2_竜性_鱗4, this.中指_竜性_鱗2_竜性_鱗4CD, DisUnit, true);
			this.X0Y0_中指_竜性_鱗1_竜性_鱗1CP = new ColorP(this.X0Y0_中指_竜性_鱗1_竜性_鱗1, this.中指_竜性_鱗1_竜性_鱗1CD, DisUnit, true);
			this.X0Y0_中指_竜性_鱗1_竜性_鱗2CP = new ColorP(this.X0Y0_中指_竜性_鱗1_竜性_鱗2, this.中指_竜性_鱗1_竜性_鱗2CD, DisUnit, true);
			this.X0Y0_中指_竜性_鱗1_竜性_鱗3CP = new ColorP(this.X0Y0_中指_竜性_鱗1_竜性_鱗3, this.中指_竜性_鱗1_竜性_鱗3CD, DisUnit, true);
			this.X0Y0_中指_竜性_鱗1_竜性_鱗4CP = new ColorP(this.X0Y0_中指_竜性_鱗1_竜性_鱗4, this.中指_竜性_鱗1_竜性_鱗4CD, DisUnit, true);
			this.X0Y0_中指_竜性_鱗1_竜性_鱗5CP = new ColorP(this.X0Y0_中指_竜性_鱗1_竜性_鱗5, this.中指_竜性_鱗1_竜性_鱗5CD, DisUnit, true);
			this.X0Y0_中指_竜性_鱗1_竜性_鱗6CP = new ColorP(this.X0Y0_中指_竜性_鱗1_竜性_鱗6, this.中指_竜性_鱗1_竜性_鱗6CD, DisUnit, true);
			this.X0Y0_人指_爪CP = new ColorP(this.X0Y0_人指_爪, this.人指_爪CD, DisUnit, true);
			this.X0Y0_人指_指2CP = new ColorP(this.X0Y0_人指_指2, this.人指_指2CD, DisUnit, true);
			this.X0Y0_人指_指1CP = new ColorP(this.X0Y0_人指_指1, this.人指_指1CD, DisUnit, true);
			this.X0Y0_人指_竜性_鱗2_竜性_鱗1CP = new ColorP(this.X0Y0_人指_竜性_鱗2_竜性_鱗1, this.人指_竜性_鱗2_竜性_鱗1CD, DisUnit, true);
			this.X0Y0_人指_竜性_鱗2_竜性_鱗2CP = new ColorP(this.X0Y0_人指_竜性_鱗2_竜性_鱗2, this.人指_竜性_鱗2_竜性_鱗2CD, DisUnit, true);
			this.X0Y0_人指_竜性_鱗2_竜性_鱗3CP = new ColorP(this.X0Y0_人指_竜性_鱗2_竜性_鱗3, this.人指_竜性_鱗2_竜性_鱗3CD, DisUnit, true);
			this.X0Y0_人指_竜性_鱗2_竜性_鱗4CP = new ColorP(this.X0Y0_人指_竜性_鱗2_竜性_鱗4, this.人指_竜性_鱗2_竜性_鱗4CD, DisUnit, true);
			this.X0Y0_人指_竜性_鱗1_竜性_鱗1CP = new ColorP(this.X0Y0_人指_竜性_鱗1_竜性_鱗1, this.人指_竜性_鱗1_竜性_鱗1CD, DisUnit, true);
			this.X0Y0_人指_竜性_鱗1_竜性_鱗2CP = new ColorP(this.X0Y0_人指_竜性_鱗1_竜性_鱗2, this.人指_竜性_鱗1_竜性_鱗2CD, DisUnit, true);
			this.X0Y0_人指_竜性_鱗1_竜性_鱗3CP = new ColorP(this.X0Y0_人指_竜性_鱗1_竜性_鱗3, this.人指_竜性_鱗1_竜性_鱗3CD, DisUnit, true);
			this.X0Y0_人指_竜性_鱗1_竜性_鱗4CP = new ColorP(this.X0Y0_人指_竜性_鱗1_竜性_鱗4, this.人指_竜性_鱗1_竜性_鱗4CD, DisUnit, true);
			this.X0Y0_人指_竜性_鱗1_竜性_鱗5CP = new ColorP(this.X0Y0_人指_竜性_鱗1_竜性_鱗5, this.人指_竜性_鱗1_竜性_鱗5CD, DisUnit, true);
			this.X0Y0_人指_竜性_鱗1_竜性_鱗6CP = new ColorP(this.X0Y0_人指_竜性_鱗1_竜性_鱗6, this.人指_竜性_鱗1_竜性_鱗6CD, DisUnit, true);
			this.X0Y0_脚輪_革CP = new ColorP(this.X0Y0_脚輪_革, this.脚輪_革CD, DisUnit, true);
			this.X0Y0_脚輪_金具1CP = new ColorP(this.X0Y0_脚輪_金具1, this.脚輪_金具1CD, DisUnit, true);
			this.X0Y0_脚輪_金具2CP = new ColorP(this.X0Y0_脚輪_金具2, this.脚輪_金具2CD, DisUnit, true);
			this.X0Y0_脚輪_金具3CP = new ColorP(this.X0Y0_脚輪_金具3, this.脚輪_金具3CD, DisUnit, true);
			this.X0Y0_脚輪_金具左CP = new ColorP(this.X0Y0_脚輪_金具左, this.脚輪_金具左CD, DisUnit, true);
			this.X0Y0_脚輪_金具右CP = new ColorP(this.X0Y0_脚輪_金具右, this.脚輪_金具右CD, DisUnit, true);
			this.X0Y0_親指_爪CP = new ColorP(this.X0Y0_親指_爪, this.親指_爪CD, DisUnit, true);
			this.X0Y0_親指_指1CP = new ColorP(this.X0Y0_親指_指1, this.親指_指1CD, DisUnit, true);
			this.X0Y0_親指_竜性_鱗1_竜性_鱗1CP = new ColorP(this.X0Y0_親指_竜性_鱗1_竜性_鱗1, this.親指_竜性_鱗1_竜性_鱗1CD, DisUnit, true);
			this.X0Y0_親指_竜性_鱗1_竜性_鱗2CP = new ColorP(this.X0Y0_親指_竜性_鱗1_竜性_鱗2, this.親指_竜性_鱗1_竜性_鱗2CD, DisUnit, true);
			this.X0Y0_親指_竜性_鱗1_竜性_鱗3CP = new ColorP(this.X0Y0_親指_竜性_鱗1_竜性_鱗3, this.親指_竜性_鱗1_竜性_鱗3CD, DisUnit, true);
			this.X0Y0_親指_竜性_鱗1_竜性_鱗4CP = new ColorP(this.X0Y0_親指_竜性_鱗1_竜性_鱗4, this.親指_竜性_鱗1_竜性_鱗4CD, DisUnit, true);
			this.X0Y0_親指_竜性_鱗1_竜性_鱗5CP = new ColorP(this.X0Y0_親指_竜性_鱗1_竜性_鱗5, this.親指_竜性_鱗1_竜性_鱗5CD, DisUnit, true);
			this.X0Y0_親指_竜性_鱗1_竜性_鱗6CP = new ColorP(this.X0Y0_親指_竜性_鱗1_竜性_鱗6, this.親指_竜性_鱗1_竜性_鱗6CD, DisUnit, true);
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

		public bool 足首_表示
		{
			get
			{
				return this.X0Y0_足首.Dra;
			}
			set
			{
				this.X0Y0_足首.Dra = value;
				this.X0Y0_足首.Hit = value;
			}
		}

		public bool 足首鱗_竜性_鱗1_表示
		{
			get
			{
				return this.X0Y0_足首鱗_竜性_竜性_鱗1.Dra;
			}
			set
			{
				this.X0Y0_足首鱗_竜性_竜性_鱗1.Dra = value;
				this.X0Y0_足首鱗_竜性_竜性_鱗1.Hit = value;
			}
		}

		public bool 足首鱗_竜性_鱗2_表示
		{
			get
			{
				return this.X0Y0_足首鱗_竜性_竜性_鱗2.Dra;
			}
			set
			{
				this.X0Y0_足首鱗_竜性_竜性_鱗2.Dra = value;
				this.X0Y0_足首鱗_竜性_竜性_鱗2.Hit = value;
			}
		}

		public bool 足首鱗_竜性_鱗3_表示
		{
			get
			{
				return this.X0Y0_足首鱗_竜性_竜性_鱗3.Dra;
			}
			set
			{
				this.X0Y0_足首鱗_竜性_竜性_鱗3.Dra = value;
				this.X0Y0_足首鱗_竜性_竜性_鱗3.Hit = value;
			}
		}

		public bool 踵鱗_竜性_鱗3_表示
		{
			get
			{
				return this.X0Y0_踵鱗_竜性_竜性_鱗3.Dra;
			}
			set
			{
				this.X0Y0_踵鱗_竜性_竜性_鱗3.Dra = value;
				this.X0Y0_踵鱗_竜性_竜性_鱗3.Hit = value;
			}
		}

		public bool 踵鱗_竜性_鱗2_表示
		{
			get
			{
				return this.X0Y0_踵鱗_竜性_竜性_鱗2.Dra;
			}
			set
			{
				this.X0Y0_踵鱗_竜性_竜性_鱗2.Dra = value;
				this.X0Y0_踵鱗_竜性_竜性_鱗2.Hit = value;
			}
		}

		public bool 踵鱗_竜性_鱗1_表示
		{
			get
			{
				return this.X0Y0_踵鱗_竜性_竜性_鱗1.Dra;
			}
			set
			{
				this.X0Y0_踵鱗_竜性_竜性_鱗1.Dra = value;
				this.X0Y0_踵鱗_竜性_竜性_鱗1.Hit = value;
			}
		}

		public bool 竜性_鱗_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗.Dra = value;
				this.X0Y0_竜性_鱗.Hit = value;
			}
		}

		public bool 足鱗_竜性_鱗1_表示
		{
			get
			{
				return this.X0Y0_足鱗_竜性_竜性_鱗1.Dra;
			}
			set
			{
				this.X0Y0_足鱗_竜性_竜性_鱗1.Dra = value;
				this.X0Y0_足鱗_竜性_竜性_鱗1.Hit = value;
			}
		}

		public bool 足鱗_竜性_鱗2_表示
		{
			get
			{
				return this.X0Y0_足鱗_竜性_竜性_鱗2.Dra;
			}
			set
			{
				this.X0Y0_足鱗_竜性_竜性_鱗2.Dra = value;
				this.X0Y0_足鱗_竜性_竜性_鱗2.Hit = value;
			}
		}

		public bool 足鱗_竜性_鱗3_表示
		{
			get
			{
				return this.X0Y0_足鱗_竜性_竜性_鱗3.Dra;
			}
			set
			{
				this.X0Y0_足鱗_竜性_竜性_鱗3.Dra = value;
				this.X0Y0_足鱗_竜性_竜性_鱗3.Hit = value;
			}
		}

		public bool 足鱗_竜性_鱗4_表示
		{
			get
			{
				return this.X0Y0_足鱗_竜性_竜性_鱗4.Dra;
			}
			set
			{
				this.X0Y0_足鱗_竜性_竜性_鱗4.Dra = value;
				this.X0Y0_足鱗_竜性_竜性_鱗4.Hit = value;
			}
		}

		public bool 足鱗_竜性_鱗5_表示
		{
			get
			{
				return this.X0Y0_足鱗_竜性_竜性_鱗5.Dra;
			}
			set
			{
				this.X0Y0_足鱗_竜性_竜性_鱗5.Dra = value;
				this.X0Y0_足鱗_竜性_竜性_鱗5.Hit = value;
			}
		}

		public bool 足鱗_竜性_鱗6_表示
		{
			get
			{
				return this.X0Y0_足鱗_竜性_竜性_鱗6.Dra;
			}
			set
			{
				this.X0Y0_足鱗_竜性_竜性_鱗6.Dra = value;
				this.X0Y0_足鱗_竜性_竜性_鱗6.Hit = value;
			}
		}

		public bool 足鱗_竜性_鱗7_表示
		{
			get
			{
				return this.X0Y0_足鱗_竜性_竜性_鱗7.Dra;
			}
			set
			{
				this.X0Y0_足鱗_竜性_竜性_鱗7.Dra = value;
				this.X0Y0_足鱗_竜性_竜性_鱗7.Hit = value;
			}
		}

		public bool 足鱗_竜性_鱗8_表示
		{
			get
			{
				return this.X0Y0_足鱗_竜性_竜性_鱗8.Dra;
			}
			set
			{
				this.X0Y0_足鱗_竜性_竜性_鱗8.Dra = value;
				this.X0Y0_足鱗_竜性_竜性_鱗8.Hit = value;
			}
		}

		public bool 足鱗_竜性_鱗9_表示
		{
			get
			{
				return this.X0Y0_足鱗_竜性_竜性_鱗9.Dra;
			}
			set
			{
				this.X0Y0_足鱗_竜性_竜性_鱗9.Dra = value;
				this.X0Y0_足鱗_竜性_竜性_鱗9.Hit = value;
			}
		}

		public bool 足鱗_竜性_鱗10_表示
		{
			get
			{
				return this.X0Y0_足鱗_竜性_竜性_鱗10.Dra;
			}
			set
			{
				this.X0Y0_足鱗_竜性_竜性_鱗10.Dra = value;
				this.X0Y0_足鱗_竜性_竜性_鱗10.Hit = value;
			}
		}

		public bool 足鱗_竜性_鱗11_表示
		{
			get
			{
				return this.X0Y0_足鱗_竜性_竜性_鱗11.Dra;
			}
			set
			{
				this.X0Y0_足鱗_竜性_竜性_鱗11.Dra = value;
				this.X0Y0_足鱗_竜性_竜性_鱗11.Hit = value;
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

		public bool 薬指_指3_表示
		{
			get
			{
				return this.X0Y0_薬指_指3.Dra;
			}
			set
			{
				this.X0Y0_薬指_指3.Dra = value;
				this.X0Y0_薬指_指3.Hit = value;
			}
		}

		public bool 薬指_指2_表示
		{
			get
			{
				return this.X0Y0_薬指_指2.Dra;
			}
			set
			{
				this.X0Y0_薬指_指2.Dra = value;
				this.X0Y0_薬指_指2.Hit = value;
			}
		}

		public bool 薬指_指1_表示
		{
			get
			{
				return this.X0Y0_薬指_指1.Dra;
			}
			set
			{
				this.X0Y0_薬指_指1.Dra = value;
				this.X0Y0_薬指_指1.Hit = value;
			}
		}

		public bool 薬指_竜性_鱗3_鱗1_表示
		{
			get
			{
				return this.X0Y0_薬指_竜性_鱗3_竜性_鱗1.Dra;
			}
			set
			{
				this.X0Y0_薬指_竜性_鱗3_竜性_鱗1.Dra = value;
				this.X0Y0_薬指_竜性_鱗3_竜性_鱗1.Hit = value;
			}
		}

		public bool 薬指_竜性_鱗3_鱗2_表示
		{
			get
			{
				return this.X0Y0_薬指_竜性_鱗3_竜性_鱗2.Dra;
			}
			set
			{
				this.X0Y0_薬指_竜性_鱗3_竜性_鱗2.Dra = value;
				this.X0Y0_薬指_竜性_鱗3_竜性_鱗2.Hit = value;
			}
		}

		public bool 薬指_竜性_鱗3_鱗3_表示
		{
			get
			{
				return this.X0Y0_薬指_竜性_鱗3_竜性_鱗3.Dra;
			}
			set
			{
				this.X0Y0_薬指_竜性_鱗3_竜性_鱗3.Dra = value;
				this.X0Y0_薬指_竜性_鱗3_竜性_鱗3.Hit = value;
			}
		}

		public bool 薬指_竜性_鱗3_鱗4_表示
		{
			get
			{
				return this.X0Y0_薬指_竜性_鱗3_竜性_鱗4.Dra;
			}
			set
			{
				this.X0Y0_薬指_竜性_鱗3_竜性_鱗4.Dra = value;
				this.X0Y0_薬指_竜性_鱗3_竜性_鱗4.Hit = value;
			}
		}

		public bool 薬指_竜性_鱗2_鱗1_表示
		{
			get
			{
				return this.X0Y0_薬指_竜性_鱗2_竜性_鱗1.Dra;
			}
			set
			{
				this.X0Y0_薬指_竜性_鱗2_竜性_鱗1.Dra = value;
				this.X0Y0_薬指_竜性_鱗2_竜性_鱗1.Hit = value;
			}
		}

		public bool 薬指_竜性_鱗2_鱗2_表示
		{
			get
			{
				return this.X0Y0_薬指_竜性_鱗2_竜性_鱗2.Dra;
			}
			set
			{
				this.X0Y0_薬指_竜性_鱗2_竜性_鱗2.Dra = value;
				this.X0Y0_薬指_竜性_鱗2_竜性_鱗2.Hit = value;
			}
		}

		public bool 薬指_竜性_鱗2_鱗3_表示
		{
			get
			{
				return this.X0Y0_薬指_竜性_鱗2_竜性_鱗3.Dra;
			}
			set
			{
				this.X0Y0_薬指_竜性_鱗2_竜性_鱗3.Dra = value;
				this.X0Y0_薬指_竜性_鱗2_竜性_鱗3.Hit = value;
			}
		}

		public bool 薬指_竜性_鱗2_鱗4_表示
		{
			get
			{
				return this.X0Y0_薬指_竜性_鱗2_竜性_鱗4.Dra;
			}
			set
			{
				this.X0Y0_薬指_竜性_鱗2_竜性_鱗4.Dra = value;
				this.X0Y0_薬指_竜性_鱗2_竜性_鱗4.Hit = value;
			}
		}

		public bool 薬指_竜性_鱗1_鱗1_表示
		{
			get
			{
				return this.X0Y0_薬指_竜性_鱗1_竜性_鱗1.Dra;
			}
			set
			{
				this.X0Y0_薬指_竜性_鱗1_竜性_鱗1.Dra = value;
				this.X0Y0_薬指_竜性_鱗1_竜性_鱗1.Hit = value;
			}
		}

		public bool 薬指_竜性_鱗1_鱗2_表示
		{
			get
			{
				return this.X0Y0_薬指_竜性_鱗1_竜性_鱗2.Dra;
			}
			set
			{
				this.X0Y0_薬指_竜性_鱗1_竜性_鱗2.Dra = value;
				this.X0Y0_薬指_竜性_鱗1_竜性_鱗2.Hit = value;
			}
		}

		public bool 薬指_竜性_鱗1_鱗3_表示
		{
			get
			{
				return this.X0Y0_薬指_竜性_鱗1_竜性_鱗3.Dra;
			}
			set
			{
				this.X0Y0_薬指_竜性_鱗1_竜性_鱗3.Dra = value;
				this.X0Y0_薬指_竜性_鱗1_竜性_鱗3.Hit = value;
			}
		}

		public bool 薬指_竜性_鱗1_鱗4_表示
		{
			get
			{
				return this.X0Y0_薬指_竜性_鱗1_竜性_鱗4.Dra;
			}
			set
			{
				this.X0Y0_薬指_竜性_鱗1_竜性_鱗4.Dra = value;
				this.X0Y0_薬指_竜性_鱗1_竜性_鱗4.Hit = value;
			}
		}

		public bool 薬指_竜性_鱗1_鱗5_表示
		{
			get
			{
				return this.X0Y0_薬指_竜性_鱗1_竜性_鱗5.Dra;
			}
			set
			{
				this.X0Y0_薬指_竜性_鱗1_竜性_鱗5.Dra = value;
				this.X0Y0_薬指_竜性_鱗1_竜性_鱗5.Hit = value;
			}
		}

		public bool 薬指_竜性_鱗1_鱗6_表示
		{
			get
			{
				return this.X0Y0_薬指_竜性_鱗1_竜性_鱗6.Dra;
			}
			set
			{
				this.X0Y0_薬指_竜性_鱗1_竜性_鱗6.Dra = value;
				this.X0Y0_薬指_竜性_鱗1_竜性_鱗6.Hit = value;
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

		public bool 中指_指3_表示
		{
			get
			{
				return this.X0Y0_中指_指3.Dra;
			}
			set
			{
				this.X0Y0_中指_指3.Dra = value;
				this.X0Y0_中指_指3.Hit = value;
			}
		}

		public bool 中指_指2_表示
		{
			get
			{
				return this.X0Y0_中指_指2.Dra;
			}
			set
			{
				this.X0Y0_中指_指2.Dra = value;
				this.X0Y0_中指_指2.Hit = value;
			}
		}

		public bool 中指_指1_表示
		{
			get
			{
				return this.X0Y0_中指_指1.Dra;
			}
			set
			{
				this.X0Y0_中指_指1.Dra = value;
				this.X0Y0_中指_指1.Hit = value;
			}
		}

		public bool 中指_竜性_鱗3_鱗1_表示
		{
			get
			{
				return this.X0Y0_中指_竜性_鱗3_竜性_鱗1.Dra;
			}
			set
			{
				this.X0Y0_中指_竜性_鱗3_竜性_鱗1.Dra = value;
				this.X0Y0_中指_竜性_鱗3_竜性_鱗1.Hit = value;
			}
		}

		public bool 中指_竜性_鱗3_鱗2_表示
		{
			get
			{
				return this.X0Y0_中指_竜性_鱗3_竜性_鱗2.Dra;
			}
			set
			{
				this.X0Y0_中指_竜性_鱗3_竜性_鱗2.Dra = value;
				this.X0Y0_中指_竜性_鱗3_竜性_鱗2.Hit = value;
			}
		}

		public bool 中指_竜性_鱗3_鱗3_表示
		{
			get
			{
				return this.X0Y0_中指_竜性_鱗3_竜性_鱗3.Dra;
			}
			set
			{
				this.X0Y0_中指_竜性_鱗3_竜性_鱗3.Dra = value;
				this.X0Y0_中指_竜性_鱗3_竜性_鱗3.Hit = value;
			}
		}

		public bool 中指_竜性_鱗3_鱗4_表示
		{
			get
			{
				return this.X0Y0_中指_竜性_鱗3_竜性_鱗4.Dra;
			}
			set
			{
				this.X0Y0_中指_竜性_鱗3_竜性_鱗4.Dra = value;
				this.X0Y0_中指_竜性_鱗3_竜性_鱗4.Hit = value;
			}
		}

		public bool 中指_竜性_鱗2_鱗1_表示
		{
			get
			{
				return this.X0Y0_中指_竜性_鱗2_竜性_鱗1.Dra;
			}
			set
			{
				this.X0Y0_中指_竜性_鱗2_竜性_鱗1.Dra = value;
				this.X0Y0_中指_竜性_鱗2_竜性_鱗1.Hit = value;
			}
		}

		public bool 中指_竜性_鱗2_鱗2_表示
		{
			get
			{
				return this.X0Y0_中指_竜性_鱗2_竜性_鱗2.Dra;
			}
			set
			{
				this.X0Y0_中指_竜性_鱗2_竜性_鱗2.Dra = value;
				this.X0Y0_中指_竜性_鱗2_竜性_鱗2.Hit = value;
			}
		}

		public bool 中指_竜性_鱗2_鱗3_表示
		{
			get
			{
				return this.X0Y0_中指_竜性_鱗2_竜性_鱗3.Dra;
			}
			set
			{
				this.X0Y0_中指_竜性_鱗2_竜性_鱗3.Dra = value;
				this.X0Y0_中指_竜性_鱗2_竜性_鱗3.Hit = value;
			}
		}

		public bool 中指_竜性_鱗2_鱗4_表示
		{
			get
			{
				return this.X0Y0_中指_竜性_鱗2_竜性_鱗4.Dra;
			}
			set
			{
				this.X0Y0_中指_竜性_鱗2_竜性_鱗4.Dra = value;
				this.X0Y0_中指_竜性_鱗2_竜性_鱗4.Hit = value;
			}
		}

		public bool 中指_竜性_鱗1_鱗1_表示
		{
			get
			{
				return this.X0Y0_中指_竜性_鱗1_竜性_鱗1.Dra;
			}
			set
			{
				this.X0Y0_中指_竜性_鱗1_竜性_鱗1.Dra = value;
				this.X0Y0_中指_竜性_鱗1_竜性_鱗1.Hit = value;
			}
		}

		public bool 中指_竜性_鱗1_鱗2_表示
		{
			get
			{
				return this.X0Y0_中指_竜性_鱗1_竜性_鱗2.Dra;
			}
			set
			{
				this.X0Y0_中指_竜性_鱗1_竜性_鱗2.Dra = value;
				this.X0Y0_中指_竜性_鱗1_竜性_鱗2.Hit = value;
			}
		}

		public bool 中指_竜性_鱗1_鱗3_表示
		{
			get
			{
				return this.X0Y0_中指_竜性_鱗1_竜性_鱗3.Dra;
			}
			set
			{
				this.X0Y0_中指_竜性_鱗1_竜性_鱗3.Dra = value;
				this.X0Y0_中指_竜性_鱗1_竜性_鱗3.Hit = value;
			}
		}

		public bool 中指_竜性_鱗1_鱗4_表示
		{
			get
			{
				return this.X0Y0_中指_竜性_鱗1_竜性_鱗4.Dra;
			}
			set
			{
				this.X0Y0_中指_竜性_鱗1_竜性_鱗4.Dra = value;
				this.X0Y0_中指_竜性_鱗1_竜性_鱗4.Hit = value;
			}
		}

		public bool 中指_竜性_鱗1_鱗5_表示
		{
			get
			{
				return this.X0Y0_中指_竜性_鱗1_竜性_鱗5.Dra;
			}
			set
			{
				this.X0Y0_中指_竜性_鱗1_竜性_鱗5.Dra = value;
				this.X0Y0_中指_竜性_鱗1_竜性_鱗5.Hit = value;
			}
		}

		public bool 中指_竜性_鱗1_鱗6_表示
		{
			get
			{
				return this.X0Y0_中指_竜性_鱗1_竜性_鱗6.Dra;
			}
			set
			{
				this.X0Y0_中指_竜性_鱗1_竜性_鱗6.Dra = value;
				this.X0Y0_中指_竜性_鱗1_竜性_鱗6.Hit = value;
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

		public bool 人指_指2_表示
		{
			get
			{
				return this.X0Y0_人指_指2.Dra;
			}
			set
			{
				this.X0Y0_人指_指2.Dra = value;
				this.X0Y0_人指_指2.Hit = value;
			}
		}

		public bool 人指_指1_表示
		{
			get
			{
				return this.X0Y0_人指_指1.Dra;
			}
			set
			{
				this.X0Y0_人指_指1.Dra = value;
				this.X0Y0_人指_指1.Hit = value;
			}
		}

		public bool 人指_竜性_鱗2_鱗1_表示
		{
			get
			{
				return this.X0Y0_人指_竜性_鱗2_竜性_鱗1.Dra;
			}
			set
			{
				this.X0Y0_人指_竜性_鱗2_竜性_鱗1.Dra = value;
				this.X0Y0_人指_竜性_鱗2_竜性_鱗1.Hit = value;
			}
		}

		public bool 人指_竜性_鱗2_鱗2_表示
		{
			get
			{
				return this.X0Y0_人指_竜性_鱗2_竜性_鱗2.Dra;
			}
			set
			{
				this.X0Y0_人指_竜性_鱗2_竜性_鱗2.Dra = value;
				this.X0Y0_人指_竜性_鱗2_竜性_鱗2.Hit = value;
			}
		}

		public bool 人指_竜性_鱗2_鱗3_表示
		{
			get
			{
				return this.X0Y0_人指_竜性_鱗2_竜性_鱗3.Dra;
			}
			set
			{
				this.X0Y0_人指_竜性_鱗2_竜性_鱗3.Dra = value;
				this.X0Y0_人指_竜性_鱗2_竜性_鱗3.Hit = value;
			}
		}

		public bool 人指_竜性_鱗2_鱗4_表示
		{
			get
			{
				return this.X0Y0_人指_竜性_鱗2_竜性_鱗4.Dra;
			}
			set
			{
				this.X0Y0_人指_竜性_鱗2_竜性_鱗4.Dra = value;
				this.X0Y0_人指_竜性_鱗2_竜性_鱗4.Hit = value;
			}
		}

		public bool 人指_竜性_鱗1_鱗1_表示
		{
			get
			{
				return this.X0Y0_人指_竜性_鱗1_竜性_鱗1.Dra;
			}
			set
			{
				this.X0Y0_人指_竜性_鱗1_竜性_鱗1.Dra = value;
				this.X0Y0_人指_竜性_鱗1_竜性_鱗1.Hit = value;
			}
		}

		public bool 人指_竜性_鱗1_鱗2_表示
		{
			get
			{
				return this.X0Y0_人指_竜性_鱗1_竜性_鱗2.Dra;
			}
			set
			{
				this.X0Y0_人指_竜性_鱗1_竜性_鱗2.Dra = value;
				this.X0Y0_人指_竜性_鱗1_竜性_鱗2.Hit = value;
			}
		}

		public bool 人指_竜性_鱗1_鱗3_表示
		{
			get
			{
				return this.X0Y0_人指_竜性_鱗1_竜性_鱗3.Dra;
			}
			set
			{
				this.X0Y0_人指_竜性_鱗1_竜性_鱗3.Dra = value;
				this.X0Y0_人指_竜性_鱗1_竜性_鱗3.Hit = value;
			}
		}

		public bool 人指_竜性_鱗1_鱗4_表示
		{
			get
			{
				return this.X0Y0_人指_竜性_鱗1_竜性_鱗4.Dra;
			}
			set
			{
				this.X0Y0_人指_竜性_鱗1_竜性_鱗4.Dra = value;
				this.X0Y0_人指_竜性_鱗1_竜性_鱗4.Hit = value;
			}
		}

		public bool 人指_竜性_鱗1_鱗5_表示
		{
			get
			{
				return this.X0Y0_人指_竜性_鱗1_竜性_鱗5.Dra;
			}
			set
			{
				this.X0Y0_人指_竜性_鱗1_竜性_鱗5.Dra = value;
				this.X0Y0_人指_竜性_鱗1_竜性_鱗5.Hit = value;
			}
		}

		public bool 人指_竜性_鱗1_鱗6_表示
		{
			get
			{
				return this.X0Y0_人指_竜性_鱗1_竜性_鱗6.Dra;
			}
			set
			{
				this.X0Y0_人指_竜性_鱗1_竜性_鱗6.Dra = value;
				this.X0Y0_人指_竜性_鱗1_竜性_鱗6.Hit = value;
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

		public bool 親指_指1_表示
		{
			get
			{
				return this.X0Y0_親指_指1.Dra;
			}
			set
			{
				this.X0Y0_親指_指1.Dra = value;
				this.X0Y0_親指_指1.Hit = value;
			}
		}

		public bool 親指_竜性_鱗1_鱗1_表示
		{
			get
			{
				return this.X0Y0_親指_竜性_鱗1_竜性_鱗1.Dra;
			}
			set
			{
				this.X0Y0_親指_竜性_鱗1_竜性_鱗1.Dra = value;
				this.X0Y0_親指_竜性_鱗1_竜性_鱗1.Hit = value;
			}
		}

		public bool 親指_竜性_鱗1_鱗2_表示
		{
			get
			{
				return this.X0Y0_親指_竜性_鱗1_竜性_鱗2.Dra;
			}
			set
			{
				this.X0Y0_親指_竜性_鱗1_竜性_鱗2.Dra = value;
				this.X0Y0_親指_竜性_鱗1_竜性_鱗2.Hit = value;
			}
		}

		public bool 親指_竜性_鱗1_鱗3_表示
		{
			get
			{
				return this.X0Y0_親指_竜性_鱗1_竜性_鱗3.Dra;
			}
			set
			{
				this.X0Y0_親指_竜性_鱗1_竜性_鱗3.Dra = value;
				this.X0Y0_親指_竜性_鱗1_竜性_鱗3.Hit = value;
			}
		}

		public bool 親指_竜性_鱗1_鱗4_表示
		{
			get
			{
				return this.X0Y0_親指_竜性_鱗1_竜性_鱗4.Dra;
			}
			set
			{
				this.X0Y0_親指_竜性_鱗1_竜性_鱗4.Dra = value;
				this.X0Y0_親指_竜性_鱗1_竜性_鱗4.Hit = value;
			}
		}

		public bool 親指_竜性_鱗1_鱗5_表示
		{
			get
			{
				return this.X0Y0_親指_竜性_鱗1_竜性_鱗5.Dra;
			}
			set
			{
				this.X0Y0_親指_竜性_鱗1_竜性_鱗5.Dra = value;
				this.X0Y0_親指_竜性_鱗1_竜性_鱗5.Hit = value;
			}
		}

		public bool 親指_竜性_鱗1_鱗6_表示
		{
			get
			{
				return this.X0Y0_親指_竜性_鱗1_竜性_鱗6.Dra;
			}
			set
			{
				this.X0Y0_親指_竜性_鱗1_竜性_鱗6.Dra = value;
				this.X0Y0_親指_竜性_鱗1_竜性_鱗6.Hit = value;
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
				this.筋_表示 = value;
				this.足首_表示 = value;
				this.足首鱗_竜性_鱗1_表示 = value;
				this.足首鱗_竜性_鱗2_表示 = value;
				this.足首鱗_竜性_鱗3_表示 = value;
				this.踵鱗_竜性_鱗3_表示 = value;
				this.踵鱗_竜性_鱗2_表示 = value;
				this.踵鱗_竜性_鱗1_表示 = value;
				this.竜性_鱗_表示 = value;
				this.足鱗_竜性_鱗1_表示 = value;
				this.足鱗_竜性_鱗2_表示 = value;
				this.足鱗_竜性_鱗3_表示 = value;
				this.足鱗_竜性_鱗4_表示 = value;
				this.足鱗_竜性_鱗5_表示 = value;
				this.足鱗_竜性_鱗6_表示 = value;
				this.足鱗_竜性_鱗7_表示 = value;
				this.足鱗_竜性_鱗8_表示 = value;
				this.足鱗_竜性_鱗9_表示 = value;
				this.足鱗_竜性_鱗10_表示 = value;
				this.足鱗_竜性_鱗11_表示 = value;
				this.薬指_爪_表示 = value;
				this.薬指_指3_表示 = value;
				this.薬指_指2_表示 = value;
				this.薬指_指1_表示 = value;
				this.薬指_竜性_鱗3_鱗1_表示 = value;
				this.薬指_竜性_鱗3_鱗2_表示 = value;
				this.薬指_竜性_鱗3_鱗3_表示 = value;
				this.薬指_竜性_鱗3_鱗4_表示 = value;
				this.薬指_竜性_鱗2_鱗1_表示 = value;
				this.薬指_竜性_鱗2_鱗2_表示 = value;
				this.薬指_竜性_鱗2_鱗3_表示 = value;
				this.薬指_竜性_鱗2_鱗4_表示 = value;
				this.薬指_竜性_鱗1_鱗1_表示 = value;
				this.薬指_竜性_鱗1_鱗2_表示 = value;
				this.薬指_竜性_鱗1_鱗3_表示 = value;
				this.薬指_竜性_鱗1_鱗4_表示 = value;
				this.薬指_竜性_鱗1_鱗5_表示 = value;
				this.薬指_竜性_鱗1_鱗6_表示 = value;
				this.中指_爪_表示 = value;
				this.中指_指3_表示 = value;
				this.中指_指2_表示 = value;
				this.中指_指1_表示 = value;
				this.中指_竜性_鱗3_鱗1_表示 = value;
				this.中指_竜性_鱗3_鱗2_表示 = value;
				this.中指_竜性_鱗3_鱗3_表示 = value;
				this.中指_竜性_鱗3_鱗4_表示 = value;
				this.中指_竜性_鱗2_鱗1_表示 = value;
				this.中指_竜性_鱗2_鱗2_表示 = value;
				this.中指_竜性_鱗2_鱗3_表示 = value;
				this.中指_竜性_鱗2_鱗4_表示 = value;
				this.中指_竜性_鱗1_鱗1_表示 = value;
				this.中指_竜性_鱗1_鱗2_表示 = value;
				this.中指_竜性_鱗1_鱗3_表示 = value;
				this.中指_竜性_鱗1_鱗4_表示 = value;
				this.中指_竜性_鱗1_鱗5_表示 = value;
				this.中指_竜性_鱗1_鱗6_表示 = value;
				this.人指_爪_表示 = value;
				this.人指_指2_表示 = value;
				this.人指_指1_表示 = value;
				this.人指_竜性_鱗2_鱗1_表示 = value;
				this.人指_竜性_鱗2_鱗2_表示 = value;
				this.人指_竜性_鱗2_鱗3_表示 = value;
				this.人指_竜性_鱗2_鱗4_表示 = value;
				this.人指_竜性_鱗1_鱗1_表示 = value;
				this.人指_竜性_鱗1_鱗2_表示 = value;
				this.人指_竜性_鱗1_鱗3_表示 = value;
				this.人指_竜性_鱗1_鱗4_表示 = value;
				this.人指_竜性_鱗1_鱗5_表示 = value;
				this.人指_竜性_鱗1_鱗6_表示 = value;
				this.脚輪_革_表示 = value;
				this.脚輪_金具1_表示 = value;
				this.脚輪_金具2_表示 = value;
				this.脚輪_金具3_表示 = value;
				this.脚輪_金具左_表示 = value;
				this.脚輪_金具右_表示 = value;
				this.親指_爪_表示 = value;
				this.親指_指1_表示 = value;
				this.親指_竜性_鱗1_鱗1_表示 = value;
				this.親指_竜性_鱗1_鱗2_表示 = value;
				this.親指_竜性_鱗1_鱗3_表示 = value;
				this.親指_竜性_鱗1_鱗4_表示 = value;
				this.親指_竜性_鱗1_鱗5_表示 = value;
				this.親指_竜性_鱗1_鱗6_表示 = value;
				this.鎖1.表示 = value;
			}
		}

		public override void 描画0(Are Are)
		{
			Are.Draw(this.X0Y0_足);
			Are.Draw(this.X0Y0_筋);
			Are.Draw(this.X0Y0_足首);
			Are.Draw(this.X0Y0_足首鱗_竜性_竜性_鱗1);
			Are.Draw(this.X0Y0_足首鱗_竜性_竜性_鱗2);
			Are.Draw(this.X0Y0_足首鱗_竜性_竜性_鱗3);
			Are.Draw(this.X0Y0_踵鱗_竜性_竜性_鱗3);
			Are.Draw(this.X0Y0_踵鱗_竜性_竜性_鱗2);
			Are.Draw(this.X0Y0_踵鱗_竜性_竜性_鱗1);
			Are.Draw(this.X0Y0_竜性_鱗);
			Are.Draw(this.X0Y0_足鱗_竜性_竜性_鱗1);
			Are.Draw(this.X0Y0_足鱗_竜性_竜性_鱗2);
			Are.Draw(this.X0Y0_足鱗_竜性_竜性_鱗3);
			Are.Draw(this.X0Y0_足鱗_竜性_竜性_鱗4);
			Are.Draw(this.X0Y0_足鱗_竜性_竜性_鱗5);
			Are.Draw(this.X0Y0_足鱗_竜性_竜性_鱗6);
			Are.Draw(this.X0Y0_足鱗_竜性_竜性_鱗7);
			Are.Draw(this.X0Y0_足鱗_竜性_竜性_鱗8);
			Are.Draw(this.X0Y0_足鱗_竜性_竜性_鱗9);
			Are.Draw(this.X0Y0_足鱗_竜性_竜性_鱗10);
			Are.Draw(this.X0Y0_足鱗_竜性_竜性_鱗11);
			Are.Draw(this.X0Y0_薬指_爪);
			Are.Draw(this.X0Y0_薬指_指3);
			Are.Draw(this.X0Y0_薬指_指2);
			Are.Draw(this.X0Y0_薬指_指1);
			Are.Draw(this.X0Y0_薬指_竜性_鱗3_竜性_鱗1);
			Are.Draw(this.X0Y0_薬指_竜性_鱗3_竜性_鱗2);
			Are.Draw(this.X0Y0_薬指_竜性_鱗3_竜性_鱗3);
			Are.Draw(this.X0Y0_薬指_竜性_鱗3_竜性_鱗4);
			Are.Draw(this.X0Y0_薬指_竜性_鱗2_竜性_鱗1);
			Are.Draw(this.X0Y0_薬指_竜性_鱗2_竜性_鱗2);
			Are.Draw(this.X0Y0_薬指_竜性_鱗2_竜性_鱗3);
			Are.Draw(this.X0Y0_薬指_竜性_鱗2_竜性_鱗4);
			Are.Draw(this.X0Y0_薬指_竜性_鱗1_竜性_鱗1);
			Are.Draw(this.X0Y0_薬指_竜性_鱗1_竜性_鱗2);
			Are.Draw(this.X0Y0_薬指_竜性_鱗1_竜性_鱗3);
			Are.Draw(this.X0Y0_薬指_竜性_鱗1_竜性_鱗4);
			Are.Draw(this.X0Y0_薬指_竜性_鱗1_竜性_鱗5);
			Are.Draw(this.X0Y0_薬指_竜性_鱗1_竜性_鱗6);
			Are.Draw(this.X0Y0_中指_爪);
			Are.Draw(this.X0Y0_中指_指3);
			Are.Draw(this.X0Y0_中指_指2);
			Are.Draw(this.X0Y0_中指_指1);
			Are.Draw(this.X0Y0_中指_竜性_鱗3_竜性_鱗1);
			Are.Draw(this.X0Y0_中指_竜性_鱗3_竜性_鱗2);
			Are.Draw(this.X0Y0_中指_竜性_鱗3_竜性_鱗3);
			Are.Draw(this.X0Y0_中指_竜性_鱗3_竜性_鱗4);
			Are.Draw(this.X0Y0_中指_竜性_鱗2_竜性_鱗1);
			Are.Draw(this.X0Y0_中指_竜性_鱗2_竜性_鱗2);
			Are.Draw(this.X0Y0_中指_竜性_鱗2_竜性_鱗3);
			Are.Draw(this.X0Y0_中指_竜性_鱗2_竜性_鱗4);
			Are.Draw(this.X0Y0_中指_竜性_鱗1_竜性_鱗1);
			Are.Draw(this.X0Y0_中指_竜性_鱗1_竜性_鱗2);
			Are.Draw(this.X0Y0_中指_竜性_鱗1_竜性_鱗3);
			Are.Draw(this.X0Y0_中指_竜性_鱗1_竜性_鱗4);
			Are.Draw(this.X0Y0_中指_竜性_鱗1_竜性_鱗5);
			Are.Draw(this.X0Y0_中指_竜性_鱗1_竜性_鱗6);
			Are.Draw(this.X0Y0_人指_爪);
			Are.Draw(this.X0Y0_人指_指2);
			Are.Draw(this.X0Y0_人指_指1);
			Are.Draw(this.X0Y0_人指_竜性_鱗2_竜性_鱗1);
			Are.Draw(this.X0Y0_人指_竜性_鱗2_竜性_鱗2);
			Are.Draw(this.X0Y0_人指_竜性_鱗2_竜性_鱗3);
			Are.Draw(this.X0Y0_人指_竜性_鱗2_竜性_鱗4);
			Are.Draw(this.X0Y0_人指_竜性_鱗1_竜性_鱗1);
			Are.Draw(this.X0Y0_人指_竜性_鱗1_竜性_鱗2);
			Are.Draw(this.X0Y0_人指_竜性_鱗1_竜性_鱗3);
			Are.Draw(this.X0Y0_人指_竜性_鱗1_竜性_鱗4);
			Are.Draw(this.X0Y0_人指_竜性_鱗1_竜性_鱗5);
			Are.Draw(this.X0Y0_人指_竜性_鱗1_竜性_鱗6);
			Are.Draw(this.X0Y0_脚輪_革);
			Are.Draw(this.X0Y0_脚輪_金具1);
			Are.Draw(this.X0Y0_脚輪_金具2);
			Are.Draw(this.X0Y0_脚輪_金具3);
			Are.Draw(this.X0Y0_脚輪_金具左);
			Are.Draw(this.X0Y0_脚輪_金具右);
			this.鎖1.描画0(Are);
			Are.Draw(this.X0Y0_親指_爪);
			Are.Draw(this.X0Y0_親指_指1);
			Are.Draw(this.X0Y0_親指_竜性_鱗1_竜性_鱗1);
			Are.Draw(this.X0Y0_親指_竜性_鱗1_竜性_鱗2);
			Are.Draw(this.X0Y0_親指_竜性_鱗1_竜性_鱗3);
			Are.Draw(this.X0Y0_親指_竜性_鱗1_竜性_鱗4);
			Are.Draw(this.X0Y0_親指_竜性_鱗1_竜性_鱗5);
			Are.Draw(this.X0Y0_親指_竜性_鱗1_竜性_鱗6);
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
				this.筋CD.不透明度 = value;
				this.足首CD.不透明度 = value;
				this.足首鱗_竜性_鱗1CD.不透明度 = value;
				this.足首鱗_竜性_鱗2CD.不透明度 = value;
				this.足首鱗_竜性_鱗3CD.不透明度 = value;
				this.踵鱗_竜性_鱗3CD.不透明度 = value;
				this.踵鱗_竜性_鱗2CD.不透明度 = value;
				this.踵鱗_竜性_鱗1CD.不透明度 = value;
				this.鱗CD.不透明度 = value;
				this.足鱗_竜性_鱗1CD.不透明度 = value;
				this.足鱗_竜性_鱗2CD.不透明度 = value;
				this.足鱗_竜性_鱗3CD.不透明度 = value;
				this.足鱗_竜性_鱗4CD.不透明度 = value;
				this.足鱗_竜性_鱗5CD.不透明度 = value;
				this.足鱗_竜性_鱗6CD.不透明度 = value;
				this.足鱗_竜性_鱗7CD.不透明度 = value;
				this.足鱗_竜性_鱗8CD.不透明度 = value;
				this.足鱗_竜性_鱗9CD.不透明度 = value;
				this.足鱗_竜性_鱗10CD.不透明度 = value;
				this.足鱗_竜性_鱗11CD.不透明度 = value;
				this.薬指_爪CD.不透明度 = value;
				this.薬指_指3CD.不透明度 = value;
				this.薬指_指2CD.不透明度 = value;
				this.薬指_指1CD.不透明度 = value;
				this.薬指_竜性_鱗3_竜性_鱗1CD.不透明度 = value;
				this.薬指_竜性_鱗3_竜性_鱗2CD.不透明度 = value;
				this.薬指_竜性_鱗3_竜性_鱗3CD.不透明度 = value;
				this.薬指_竜性_鱗3_竜性_鱗4CD.不透明度 = value;
				this.薬指_竜性_鱗2_竜性_鱗1CD.不透明度 = value;
				this.薬指_竜性_鱗2_竜性_鱗2CD.不透明度 = value;
				this.薬指_竜性_鱗2_竜性_鱗3CD.不透明度 = value;
				this.薬指_竜性_鱗2_竜性_鱗4CD.不透明度 = value;
				this.薬指_竜性_鱗1_竜性_鱗1CD.不透明度 = value;
				this.薬指_竜性_鱗1_竜性_鱗2CD.不透明度 = value;
				this.薬指_竜性_鱗1_竜性_鱗3CD.不透明度 = value;
				this.薬指_竜性_鱗1_竜性_鱗4CD.不透明度 = value;
				this.薬指_竜性_鱗1_竜性_鱗5CD.不透明度 = value;
				this.薬指_竜性_鱗1_竜性_鱗6CD.不透明度 = value;
				this.中指_爪CD.不透明度 = value;
				this.中指_指3CD.不透明度 = value;
				this.中指_指2CD.不透明度 = value;
				this.中指_指1CD.不透明度 = value;
				this.中指_竜性_鱗3_竜性_鱗1CD.不透明度 = value;
				this.中指_竜性_鱗3_竜性_鱗2CD.不透明度 = value;
				this.中指_竜性_鱗3_竜性_鱗3CD.不透明度 = value;
				this.中指_竜性_鱗3_竜性_鱗4CD.不透明度 = value;
				this.中指_竜性_鱗2_竜性_鱗1CD.不透明度 = value;
				this.中指_竜性_鱗2_竜性_鱗2CD.不透明度 = value;
				this.中指_竜性_鱗2_竜性_鱗3CD.不透明度 = value;
				this.中指_竜性_鱗2_竜性_鱗4CD.不透明度 = value;
				this.中指_竜性_鱗1_竜性_鱗1CD.不透明度 = value;
				this.中指_竜性_鱗1_竜性_鱗2CD.不透明度 = value;
				this.中指_竜性_鱗1_竜性_鱗3CD.不透明度 = value;
				this.中指_竜性_鱗1_竜性_鱗4CD.不透明度 = value;
				this.中指_竜性_鱗1_竜性_鱗5CD.不透明度 = value;
				this.中指_竜性_鱗1_竜性_鱗6CD.不透明度 = value;
				this.人指_爪CD.不透明度 = value;
				this.人指_指2CD.不透明度 = value;
				this.人指_指1CD.不透明度 = value;
				this.人指_竜性_鱗2_竜性_鱗1CD.不透明度 = value;
				this.人指_竜性_鱗2_竜性_鱗2CD.不透明度 = value;
				this.人指_竜性_鱗2_竜性_鱗3CD.不透明度 = value;
				this.人指_竜性_鱗2_竜性_鱗4CD.不透明度 = value;
				this.人指_竜性_鱗1_竜性_鱗1CD.不透明度 = value;
				this.人指_竜性_鱗1_竜性_鱗2CD.不透明度 = value;
				this.人指_竜性_鱗1_竜性_鱗3CD.不透明度 = value;
				this.人指_竜性_鱗1_竜性_鱗4CD.不透明度 = value;
				this.人指_竜性_鱗1_竜性_鱗5CD.不透明度 = value;
				this.人指_竜性_鱗1_竜性_鱗6CD.不透明度 = value;
				this.脚輪_革CD.不透明度 = value;
				this.脚輪_金具1CD.不透明度 = value;
				this.脚輪_金具2CD.不透明度 = value;
				this.脚輪_金具3CD.不透明度 = value;
				this.脚輪_金具左CD.不透明度 = value;
				this.脚輪_金具右CD.不透明度 = value;
				this.親指_爪CD.不透明度 = value;
				this.親指_指1CD.不透明度 = value;
				this.親指_竜性_鱗1_竜性_鱗1CD.不透明度 = value;
				this.親指_竜性_鱗1_竜性_鱗2CD.不透明度 = value;
				this.親指_竜性_鱗1_竜性_鱗3CD.不透明度 = value;
				this.親指_竜性_鱗1_竜性_鱗4CD.不透明度 = value;
				this.親指_竜性_鱗1_竜性_鱗5CD.不透明度 = value;
				this.親指_竜性_鱗1_竜性_鱗6CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			double num = this.右 ? -1.0 : 1.0;
			this.X0Y0_足.AngleBase = num * -25.0;
			this.X0Y0_足首.AngleBase = num * -19.0;
			this.X0Y0_薬指_指3.AngleBase = num * -15.0;
			this.X0Y0_薬指_指2.AngleBase = num * -15.0;
			this.X0Y0_薬指_指1.AngleBase = num * -1.0;
			this.X0Y0_中指_指3.AngleBase = num * -15.0;
			this.X0Y0_中指_指2.AngleBase = num * -16.0;
			this.X0Y0_中指_指1.AngleBase = num * 21.0;
			this.X0Y0_人指_指2.AngleBase = num * -13.0;
			this.X0Y0_人指_指1.AngleBase = num * 41.0;
			this.X0Y0_親指_指1.AngleBase = num * 43.0;
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
			this.X0Y0_筋CP.Update();
			this.X0Y0_足首CP.Update();
			this.X0Y0_足首鱗_竜性_竜性_鱗1CP.Update();
			this.X0Y0_足首鱗_竜性_竜性_鱗2CP.Update();
			this.X0Y0_足首鱗_竜性_竜性_鱗3CP.Update();
			this.X0Y0_踵鱗_竜性_竜性_鱗3CP.Update();
			this.X0Y0_踵鱗_竜性_竜性_鱗2CP.Update();
			this.X0Y0_踵鱗_竜性_竜性_鱗1CP.Update();
			this.X0Y0_竜性_鱗CP.Update();
			this.X0Y0_足鱗_竜性_竜性_鱗1CP.Update();
			this.X0Y0_足鱗_竜性_竜性_鱗2CP.Update();
			this.X0Y0_足鱗_竜性_竜性_鱗3CP.Update();
			this.X0Y0_足鱗_竜性_竜性_鱗4CP.Update();
			this.X0Y0_足鱗_竜性_竜性_鱗5CP.Update();
			this.X0Y0_足鱗_竜性_竜性_鱗6CP.Update();
			this.X0Y0_足鱗_竜性_竜性_鱗7CP.Update();
			this.X0Y0_足鱗_竜性_竜性_鱗8CP.Update();
			this.X0Y0_足鱗_竜性_竜性_鱗9CP.Update();
			this.X0Y0_足鱗_竜性_竜性_鱗10CP.Update();
			this.X0Y0_足鱗_竜性_竜性_鱗11CP.Update();
			this.X0Y0_薬指_爪CP.Update();
			this.X0Y0_薬指_指3CP.Update();
			this.X0Y0_薬指_指2CP.Update();
			this.X0Y0_薬指_指1CP.Update();
			this.X0Y0_薬指_竜性_鱗3_竜性_鱗1CP.Update();
			this.X0Y0_薬指_竜性_鱗3_竜性_鱗2CP.Update();
			this.X0Y0_薬指_竜性_鱗3_竜性_鱗3CP.Update();
			this.X0Y0_薬指_竜性_鱗3_竜性_鱗4CP.Update();
			this.X0Y0_薬指_竜性_鱗2_竜性_鱗1CP.Update();
			this.X0Y0_薬指_竜性_鱗2_竜性_鱗2CP.Update();
			this.X0Y0_薬指_竜性_鱗2_竜性_鱗3CP.Update();
			this.X0Y0_薬指_竜性_鱗2_竜性_鱗4CP.Update();
			this.X0Y0_薬指_竜性_鱗1_竜性_鱗1CP.Update();
			this.X0Y0_薬指_竜性_鱗1_竜性_鱗2CP.Update();
			this.X0Y0_薬指_竜性_鱗1_竜性_鱗3CP.Update();
			this.X0Y0_薬指_竜性_鱗1_竜性_鱗4CP.Update();
			this.X0Y0_薬指_竜性_鱗1_竜性_鱗5CP.Update();
			this.X0Y0_薬指_竜性_鱗1_竜性_鱗6CP.Update();
			this.X0Y0_中指_爪CP.Update();
			this.X0Y0_中指_指3CP.Update();
			this.X0Y0_中指_指2CP.Update();
			this.X0Y0_中指_指1CP.Update();
			this.X0Y0_中指_竜性_鱗3_竜性_鱗1CP.Update();
			this.X0Y0_中指_竜性_鱗3_竜性_鱗2CP.Update();
			this.X0Y0_中指_竜性_鱗3_竜性_鱗3CP.Update();
			this.X0Y0_中指_竜性_鱗3_竜性_鱗4CP.Update();
			this.X0Y0_中指_竜性_鱗2_竜性_鱗1CP.Update();
			this.X0Y0_中指_竜性_鱗2_竜性_鱗2CP.Update();
			this.X0Y0_中指_竜性_鱗2_竜性_鱗3CP.Update();
			this.X0Y0_中指_竜性_鱗2_竜性_鱗4CP.Update();
			this.X0Y0_中指_竜性_鱗1_竜性_鱗1CP.Update();
			this.X0Y0_中指_竜性_鱗1_竜性_鱗2CP.Update();
			this.X0Y0_中指_竜性_鱗1_竜性_鱗3CP.Update();
			this.X0Y0_中指_竜性_鱗1_竜性_鱗4CP.Update();
			this.X0Y0_中指_竜性_鱗1_竜性_鱗5CP.Update();
			this.X0Y0_中指_竜性_鱗1_竜性_鱗6CP.Update();
			this.X0Y0_人指_爪CP.Update();
			this.X0Y0_人指_指2CP.Update();
			this.X0Y0_人指_指1CP.Update();
			this.X0Y0_人指_竜性_鱗2_竜性_鱗1CP.Update();
			this.X0Y0_人指_竜性_鱗2_竜性_鱗2CP.Update();
			this.X0Y0_人指_竜性_鱗2_竜性_鱗3CP.Update();
			this.X0Y0_人指_竜性_鱗2_竜性_鱗4CP.Update();
			this.X0Y0_人指_竜性_鱗1_竜性_鱗1CP.Update();
			this.X0Y0_人指_竜性_鱗1_竜性_鱗2CP.Update();
			this.X0Y0_人指_竜性_鱗1_竜性_鱗3CP.Update();
			this.X0Y0_人指_竜性_鱗1_竜性_鱗4CP.Update();
			this.X0Y0_人指_竜性_鱗1_竜性_鱗5CP.Update();
			this.X0Y0_人指_竜性_鱗1_竜性_鱗6CP.Update();
			this.X0Y0_脚輪_革CP.Update();
			this.X0Y0_脚輪_金具1CP.Update();
			this.X0Y0_脚輪_金具2CP.Update();
			this.X0Y0_脚輪_金具3CP.Update();
			this.X0Y0_脚輪_金具左CP.Update();
			this.X0Y0_脚輪_金具右CP.Update();
			this.X0Y0_親指_爪CP.Update();
			this.X0Y0_親指_指1CP.Update();
			this.X0Y0_親指_竜性_鱗1_竜性_鱗1CP.Update();
			this.X0Y0_親指_竜性_鱗1_竜性_鱗2CP.Update();
			this.X0Y0_親指_竜性_鱗1_竜性_鱗3CP.Update();
			this.X0Y0_親指_竜性_鱗1_竜性_鱗4CP.Update();
			this.X0Y0_親指_竜性_鱗1_竜性_鱗5CP.Update();
			this.X0Y0_親指_竜性_鱗1_竜性_鱗6CP.Update();
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
			this.足CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.筋CD = new ColorD(ref 体配色.薄線, ref Color2.Empty);
			this.足首CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.足首鱗_竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.足首鱗_竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.足首鱗_竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.踵鱗_竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.踵鱗_竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.踵鱗_竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.足鱗_竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.足鱗_竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.足鱗_竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.足鱗_竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.足鱗_竜性_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.足鱗_竜性_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.足鱗_竜性_鱗7CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.足鱗_竜性_鱗8CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.足鱗_竜性_鱗9CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.足鱗_竜性_鱗10CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.足鱗_竜性_鱗11CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.薬指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.薬指_指3CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.薬指_指2CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.薬指_指1CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.薬指_竜性_鱗3_竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.薬指_竜性_鱗3_竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.薬指_竜性_鱗3_竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.薬指_竜性_鱗3_竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.薬指_竜性_鱗2_竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.薬指_竜性_鱗2_竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.薬指_竜性_鱗2_竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.薬指_竜性_鱗2_竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.薬指_竜性_鱗1_竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.薬指_竜性_鱗1_竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.薬指_竜性_鱗1_竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.薬指_竜性_鱗1_竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.薬指_竜性_鱗1_竜性_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.薬指_竜性_鱗1_竜性_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.中指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.中指_指3CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.中指_指2CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.中指_指1CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.中指_竜性_鱗3_竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.中指_竜性_鱗3_竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.中指_竜性_鱗3_竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.中指_竜性_鱗3_竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.中指_竜性_鱗2_竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.中指_竜性_鱗2_竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.中指_竜性_鱗2_竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.中指_竜性_鱗2_竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.中指_竜性_鱗1_竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.中指_竜性_鱗1_竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.中指_竜性_鱗1_竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.中指_竜性_鱗1_竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.中指_竜性_鱗1_竜性_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.中指_竜性_鱗1_竜性_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.人指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.人指_指2CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.人指_指1CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.人指_竜性_鱗2_竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.人指_竜性_鱗2_竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.人指_竜性_鱗2_竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.人指_竜性_鱗2_竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.人指_竜性_鱗1_竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.人指_竜性_鱗1_竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.人指_竜性_鱗1_竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.人指_竜性_鱗1_竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.人指_竜性_鱗1_竜性_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.人指_竜性_鱗1_竜性_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚輪_革CD = new ColorD();
			this.脚輪_金具1CD = new ColorD();
			this.脚輪_金具2CD = new ColorD();
			this.脚輪_金具3CD = new ColorD();
			this.脚輪_金具左CD = new ColorD();
			this.脚輪_金具右CD = new ColorD();
			this.親指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.親指_指1CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.親指_竜性_鱗1_竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.親指_竜性_鱗1_竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.親指_竜性_鱗1_竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.親指_竜性_鱗1_竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.親指_竜性_鱗1_竜性_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.親指_竜性_鱗1_竜性_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
		}

		private void 配色T0(体配色 体配色)
		{
			this.足CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.筋CD = new ColorD(ref 体配色.薄線, ref Color2.Empty);
			this.足首CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.足首鱗_竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.足首鱗_竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.足首鱗_竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.踵鱗_竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.踵鱗_竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.踵鱗_竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.鱗CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.足鱗_竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.足鱗_竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.足鱗_竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.足鱗_竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.足鱗_竜性_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.足鱗_竜性_鱗6CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.足鱗_竜性_鱗7CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.足鱗_竜性_鱗8CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.足鱗_竜性_鱗9CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.足鱗_竜性_鱗10CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.足鱗_竜性_鱗11CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.薬指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.薬指_指3CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.薬指_指2CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.薬指_指1CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.薬指_竜性_鱗3_竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.薬指_竜性_鱗3_竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.薬指_竜性_鱗3_竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.薬指_竜性_鱗3_竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.薬指_竜性_鱗2_竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.薬指_竜性_鱗2_竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.薬指_竜性_鱗2_竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.薬指_竜性_鱗2_竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.薬指_竜性_鱗1_竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.薬指_竜性_鱗1_竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.薬指_竜性_鱗1_竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.薬指_竜性_鱗1_竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.薬指_竜性_鱗1_竜性_鱗5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.薬指_竜性_鱗1_竜性_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.中指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.中指_指3CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.中指_指2CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.中指_指1CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.中指_竜性_鱗3_竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.中指_竜性_鱗3_竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.中指_竜性_鱗3_竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.中指_竜性_鱗3_竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.中指_竜性_鱗2_竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.中指_竜性_鱗2_竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.中指_竜性_鱗2_竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.中指_竜性_鱗2_竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.中指_竜性_鱗1_竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.中指_竜性_鱗1_竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.中指_竜性_鱗1_竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.中指_竜性_鱗1_竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.中指_竜性_鱗1_竜性_鱗5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.中指_竜性_鱗1_竜性_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.人指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.人指_指2CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.人指_指1CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.人指_竜性_鱗2_竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.人指_竜性_鱗2_竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.人指_竜性_鱗2_竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.人指_竜性_鱗2_竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.人指_竜性_鱗1_竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.人指_竜性_鱗1_竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.人指_竜性_鱗1_竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.人指_竜性_鱗1_竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.人指_竜性_鱗1_竜性_鱗5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.人指_竜性_鱗1_竜性_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚輪_革CD = new ColorD();
			this.脚輪_金具1CD = new ColorD();
			this.脚輪_金具2CD = new ColorD();
			this.脚輪_金具3CD = new ColorD();
			this.脚輪_金具左CD = new ColorD();
			this.脚輪_金具右CD = new ColorD();
			this.親指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.親指_指1CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.親指_竜性_鱗1_竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.親指_竜性_鱗1_竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.親指_竜性_鱗1_竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.親指_竜性_鱗1_竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.親指_竜性_鱗1_竜性_鱗5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.親指_竜性_鱗1_竜性_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
		}

		private void 配色T1(体配色 体配色)
		{
			this.足CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.筋CD = new ColorD(ref 体配色.薄線, ref Color2.Empty);
			this.足首CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.足首鱗_竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.足首鱗_竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.足首鱗_竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.踵鱗_竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.踵鱗_竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.踵鱗_竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.足鱗_竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.足鱗_竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.足鱗_竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.足鱗_竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.足鱗_竜性_鱗5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.足鱗_竜性_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.足鱗_竜性_鱗7CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.足鱗_竜性_鱗8CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.足鱗_竜性_鱗9CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.足鱗_竜性_鱗10CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.足鱗_竜性_鱗11CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.薬指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.薬指_指3CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.薬指_指2CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.薬指_指1CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.薬指_竜性_鱗3_竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.薬指_竜性_鱗3_竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.薬指_竜性_鱗3_竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.薬指_竜性_鱗3_竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.薬指_竜性_鱗2_竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.薬指_竜性_鱗2_竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.薬指_竜性_鱗2_竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.薬指_竜性_鱗2_竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.薬指_竜性_鱗1_竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.薬指_竜性_鱗1_竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.薬指_竜性_鱗1_竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.薬指_竜性_鱗1_竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.薬指_竜性_鱗1_竜性_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.薬指_竜性_鱗1_竜性_鱗6CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.中指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.中指_指3CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.中指_指2CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.中指_指1CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.中指_竜性_鱗3_竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.中指_竜性_鱗3_竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.中指_竜性_鱗3_竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.中指_竜性_鱗3_竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.中指_竜性_鱗2_竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.中指_竜性_鱗2_竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.中指_竜性_鱗2_竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.中指_竜性_鱗2_竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.中指_竜性_鱗1_竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.中指_竜性_鱗1_竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.中指_竜性_鱗1_竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.中指_竜性_鱗1_竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.中指_竜性_鱗1_竜性_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.中指_竜性_鱗1_竜性_鱗6CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.人指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.人指_指2CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.人指_指1CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.人指_竜性_鱗2_竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.人指_竜性_鱗2_竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.人指_竜性_鱗2_竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.人指_竜性_鱗2_竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.人指_竜性_鱗1_竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.人指_竜性_鱗1_竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.人指_竜性_鱗1_竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.人指_竜性_鱗1_竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.人指_竜性_鱗1_竜性_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.人指_竜性_鱗1_竜性_鱗6CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚輪_革CD = new ColorD();
			this.脚輪_金具1CD = new ColorD();
			this.脚輪_金具2CD = new ColorD();
			this.脚輪_金具3CD = new ColorD();
			this.脚輪_金具左CD = new ColorD();
			this.脚輪_金具右CD = new ColorD();
			this.親指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.親指_指1CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.親指_竜性_鱗1_竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.親指_竜性_鱗1_竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.親指_竜性_鱗1_竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.親指_竜性_鱗1_竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.親指_竜性_鱗1_竜性_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.親指_竜性_鱗1_竜性_鱗6CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
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

		public Par X0Y0_筋;

		public Par X0Y0_足首;

		public Par X0Y0_足首鱗_竜性_竜性_鱗1;

		public Par X0Y0_足首鱗_竜性_竜性_鱗2;

		public Par X0Y0_足首鱗_竜性_竜性_鱗3;

		public Par X0Y0_踵鱗_竜性_竜性_鱗3;

		public Par X0Y0_踵鱗_竜性_竜性_鱗2;

		public Par X0Y0_踵鱗_竜性_竜性_鱗1;

		public Par X0Y0_竜性_鱗;

		public Par X0Y0_足鱗_竜性_竜性_鱗1;

		public Par X0Y0_足鱗_竜性_竜性_鱗2;

		public Par X0Y0_足鱗_竜性_竜性_鱗3;

		public Par X0Y0_足鱗_竜性_竜性_鱗4;

		public Par X0Y0_足鱗_竜性_竜性_鱗5;

		public Par X0Y0_足鱗_竜性_竜性_鱗6;

		public Par X0Y0_足鱗_竜性_竜性_鱗7;

		public Par X0Y0_足鱗_竜性_竜性_鱗8;

		public Par X0Y0_足鱗_竜性_竜性_鱗9;

		public Par X0Y0_足鱗_竜性_竜性_鱗10;

		public Par X0Y0_足鱗_竜性_竜性_鱗11;

		public Par X0Y0_薬指_爪;

		public Par X0Y0_薬指_指3;

		public Par X0Y0_薬指_指2;

		public Par X0Y0_薬指_指1;

		public Par X0Y0_薬指_竜性_鱗3_竜性_鱗1;

		public Par X0Y0_薬指_竜性_鱗3_竜性_鱗2;

		public Par X0Y0_薬指_竜性_鱗3_竜性_鱗3;

		public Par X0Y0_薬指_竜性_鱗3_竜性_鱗4;

		public Par X0Y0_薬指_竜性_鱗2_竜性_鱗1;

		public Par X0Y0_薬指_竜性_鱗2_竜性_鱗2;

		public Par X0Y0_薬指_竜性_鱗2_竜性_鱗3;

		public Par X0Y0_薬指_竜性_鱗2_竜性_鱗4;

		public Par X0Y0_薬指_竜性_鱗1_竜性_鱗1;

		public Par X0Y0_薬指_竜性_鱗1_竜性_鱗2;

		public Par X0Y0_薬指_竜性_鱗1_竜性_鱗3;

		public Par X0Y0_薬指_竜性_鱗1_竜性_鱗4;

		public Par X0Y0_薬指_竜性_鱗1_竜性_鱗5;

		public Par X0Y0_薬指_竜性_鱗1_竜性_鱗6;

		public Par X0Y0_中指_爪;

		public Par X0Y0_中指_指3;

		public Par X0Y0_中指_指2;

		public Par X0Y0_中指_指1;

		public Par X0Y0_中指_竜性_鱗3_竜性_鱗1;

		public Par X0Y0_中指_竜性_鱗3_竜性_鱗2;

		public Par X0Y0_中指_竜性_鱗3_竜性_鱗3;

		public Par X0Y0_中指_竜性_鱗3_竜性_鱗4;

		public Par X0Y0_中指_竜性_鱗2_竜性_鱗1;

		public Par X0Y0_中指_竜性_鱗2_竜性_鱗2;

		public Par X0Y0_中指_竜性_鱗2_竜性_鱗3;

		public Par X0Y0_中指_竜性_鱗2_竜性_鱗4;

		public Par X0Y0_中指_竜性_鱗1_竜性_鱗1;

		public Par X0Y0_中指_竜性_鱗1_竜性_鱗2;

		public Par X0Y0_中指_竜性_鱗1_竜性_鱗3;

		public Par X0Y0_中指_竜性_鱗1_竜性_鱗4;

		public Par X0Y0_中指_竜性_鱗1_竜性_鱗5;

		public Par X0Y0_中指_竜性_鱗1_竜性_鱗6;

		public Par X0Y0_人指_爪;

		public Par X0Y0_人指_指2;

		public Par X0Y0_人指_指1;

		public Par X0Y0_人指_竜性_鱗2_竜性_鱗1;

		public Par X0Y0_人指_竜性_鱗2_竜性_鱗2;

		public Par X0Y0_人指_竜性_鱗2_竜性_鱗3;

		public Par X0Y0_人指_竜性_鱗2_竜性_鱗4;

		public Par X0Y0_人指_竜性_鱗1_竜性_鱗1;

		public Par X0Y0_人指_竜性_鱗1_竜性_鱗2;

		public Par X0Y0_人指_竜性_鱗1_竜性_鱗3;

		public Par X0Y0_人指_竜性_鱗1_竜性_鱗4;

		public Par X0Y0_人指_竜性_鱗1_竜性_鱗5;

		public Par X0Y0_人指_竜性_鱗1_竜性_鱗6;

		public Par X0Y0_脚輪_革;

		public Par X0Y0_脚輪_金具1;

		public Par X0Y0_脚輪_金具2;

		public Par X0Y0_脚輪_金具3;

		public Par X0Y0_脚輪_金具左;

		public Par X0Y0_脚輪_金具右;

		public Par X0Y0_親指_爪;

		public Par X0Y0_親指_指1;

		public Par X0Y0_親指_竜性_鱗1_竜性_鱗1;

		public Par X0Y0_親指_竜性_鱗1_竜性_鱗2;

		public Par X0Y0_親指_竜性_鱗1_竜性_鱗3;

		public Par X0Y0_親指_竜性_鱗1_竜性_鱗4;

		public Par X0Y0_親指_竜性_鱗1_竜性_鱗5;

		public Par X0Y0_親指_竜性_鱗1_竜性_鱗6;

		public ColorD 足CD;

		public ColorD 筋CD;

		public ColorD 足首CD;

		public ColorD 足首鱗_竜性_鱗1CD;

		public ColorD 足首鱗_竜性_鱗2CD;

		public ColorD 足首鱗_竜性_鱗3CD;

		public ColorD 踵鱗_竜性_鱗3CD;

		public ColorD 踵鱗_竜性_鱗2CD;

		public ColorD 踵鱗_竜性_鱗1CD;

		public ColorD 鱗CD;

		public ColorD 足鱗_竜性_鱗1CD;

		public ColorD 足鱗_竜性_鱗2CD;

		public ColorD 足鱗_竜性_鱗3CD;

		public ColorD 足鱗_竜性_鱗4CD;

		public ColorD 足鱗_竜性_鱗5CD;

		public ColorD 足鱗_竜性_鱗6CD;

		public ColorD 足鱗_竜性_鱗7CD;

		public ColorD 足鱗_竜性_鱗8CD;

		public ColorD 足鱗_竜性_鱗9CD;

		public ColorD 足鱗_竜性_鱗10CD;

		public ColorD 足鱗_竜性_鱗11CD;

		public ColorD 薬指_爪CD;

		public ColorD 薬指_指3CD;

		public ColorD 薬指_指2CD;

		public ColorD 薬指_指1CD;

		public ColorD 薬指_竜性_鱗3_竜性_鱗1CD;

		public ColorD 薬指_竜性_鱗3_竜性_鱗2CD;

		public ColorD 薬指_竜性_鱗3_竜性_鱗3CD;

		public ColorD 薬指_竜性_鱗3_竜性_鱗4CD;

		public ColorD 薬指_竜性_鱗2_竜性_鱗1CD;

		public ColorD 薬指_竜性_鱗2_竜性_鱗2CD;

		public ColorD 薬指_竜性_鱗2_竜性_鱗3CD;

		public ColorD 薬指_竜性_鱗2_竜性_鱗4CD;

		public ColorD 薬指_竜性_鱗1_竜性_鱗1CD;

		public ColorD 薬指_竜性_鱗1_竜性_鱗2CD;

		public ColorD 薬指_竜性_鱗1_竜性_鱗3CD;

		public ColorD 薬指_竜性_鱗1_竜性_鱗4CD;

		public ColorD 薬指_竜性_鱗1_竜性_鱗5CD;

		public ColorD 薬指_竜性_鱗1_竜性_鱗6CD;

		public ColorD 中指_爪CD;

		public ColorD 中指_指3CD;

		public ColorD 中指_指2CD;

		public ColorD 中指_指1CD;

		public ColorD 中指_竜性_鱗3_竜性_鱗1CD;

		public ColorD 中指_竜性_鱗3_竜性_鱗2CD;

		public ColorD 中指_竜性_鱗3_竜性_鱗3CD;

		public ColorD 中指_竜性_鱗3_竜性_鱗4CD;

		public ColorD 中指_竜性_鱗2_竜性_鱗1CD;

		public ColorD 中指_竜性_鱗2_竜性_鱗2CD;

		public ColorD 中指_竜性_鱗2_竜性_鱗3CD;

		public ColorD 中指_竜性_鱗2_竜性_鱗4CD;

		public ColorD 中指_竜性_鱗1_竜性_鱗1CD;

		public ColorD 中指_竜性_鱗1_竜性_鱗2CD;

		public ColorD 中指_竜性_鱗1_竜性_鱗3CD;

		public ColorD 中指_竜性_鱗1_竜性_鱗4CD;

		public ColorD 中指_竜性_鱗1_竜性_鱗5CD;

		public ColorD 中指_竜性_鱗1_竜性_鱗6CD;

		public ColorD 人指_爪CD;

		public ColorD 人指_指2CD;

		public ColorD 人指_指1CD;

		public ColorD 人指_竜性_鱗2_竜性_鱗1CD;

		public ColorD 人指_竜性_鱗2_竜性_鱗2CD;

		public ColorD 人指_竜性_鱗2_竜性_鱗3CD;

		public ColorD 人指_竜性_鱗2_竜性_鱗4CD;

		public ColorD 人指_竜性_鱗1_竜性_鱗1CD;

		public ColorD 人指_竜性_鱗1_竜性_鱗2CD;

		public ColorD 人指_竜性_鱗1_竜性_鱗3CD;

		public ColorD 人指_竜性_鱗1_竜性_鱗4CD;

		public ColorD 人指_竜性_鱗1_竜性_鱗5CD;

		public ColorD 人指_竜性_鱗1_竜性_鱗6CD;

		public ColorD 脚輪_革CD;

		public ColorD 脚輪_金具1CD;

		public ColorD 脚輪_金具2CD;

		public ColorD 脚輪_金具3CD;

		public ColorD 脚輪_金具左CD;

		public ColorD 脚輪_金具右CD;

		public ColorD 親指_爪CD;

		public ColorD 親指_指1CD;

		public ColorD 親指_竜性_鱗1_竜性_鱗1CD;

		public ColorD 親指_竜性_鱗1_竜性_鱗2CD;

		public ColorD 親指_竜性_鱗1_竜性_鱗3CD;

		public ColorD 親指_竜性_鱗1_竜性_鱗4CD;

		public ColorD 親指_竜性_鱗1_竜性_鱗5CD;

		public ColorD 親指_竜性_鱗1_竜性_鱗6CD;

		public ColorP X0Y0_足CP;

		public ColorP X0Y0_筋CP;

		public ColorP X0Y0_足首CP;

		public ColorP X0Y0_足首鱗_竜性_竜性_鱗1CP;

		public ColorP X0Y0_足首鱗_竜性_竜性_鱗2CP;

		public ColorP X0Y0_足首鱗_竜性_竜性_鱗3CP;

		public ColorP X0Y0_踵鱗_竜性_竜性_鱗3CP;

		public ColorP X0Y0_踵鱗_竜性_竜性_鱗2CP;

		public ColorP X0Y0_踵鱗_竜性_竜性_鱗1CP;

		public ColorP X0Y0_竜性_鱗CP;

		public ColorP X0Y0_足鱗_竜性_竜性_鱗1CP;

		public ColorP X0Y0_足鱗_竜性_竜性_鱗2CP;

		public ColorP X0Y0_足鱗_竜性_竜性_鱗3CP;

		public ColorP X0Y0_足鱗_竜性_竜性_鱗4CP;

		public ColorP X0Y0_足鱗_竜性_竜性_鱗5CP;

		public ColorP X0Y0_足鱗_竜性_竜性_鱗6CP;

		public ColorP X0Y0_足鱗_竜性_竜性_鱗7CP;

		public ColorP X0Y0_足鱗_竜性_竜性_鱗8CP;

		public ColorP X0Y0_足鱗_竜性_竜性_鱗9CP;

		public ColorP X0Y0_足鱗_竜性_竜性_鱗10CP;

		public ColorP X0Y0_足鱗_竜性_竜性_鱗11CP;

		public ColorP X0Y0_薬指_爪CP;

		public ColorP X0Y0_薬指_指3CP;

		public ColorP X0Y0_薬指_指2CP;

		public ColorP X0Y0_薬指_指1CP;

		public ColorP X0Y0_薬指_竜性_鱗3_竜性_鱗1CP;

		public ColorP X0Y0_薬指_竜性_鱗3_竜性_鱗2CP;

		public ColorP X0Y0_薬指_竜性_鱗3_竜性_鱗3CP;

		public ColorP X0Y0_薬指_竜性_鱗3_竜性_鱗4CP;

		public ColorP X0Y0_薬指_竜性_鱗2_竜性_鱗1CP;

		public ColorP X0Y0_薬指_竜性_鱗2_竜性_鱗2CP;

		public ColorP X0Y0_薬指_竜性_鱗2_竜性_鱗3CP;

		public ColorP X0Y0_薬指_竜性_鱗2_竜性_鱗4CP;

		public ColorP X0Y0_薬指_竜性_鱗1_竜性_鱗1CP;

		public ColorP X0Y0_薬指_竜性_鱗1_竜性_鱗2CP;

		public ColorP X0Y0_薬指_竜性_鱗1_竜性_鱗3CP;

		public ColorP X0Y0_薬指_竜性_鱗1_竜性_鱗4CP;

		public ColorP X0Y0_薬指_竜性_鱗1_竜性_鱗5CP;

		public ColorP X0Y0_薬指_竜性_鱗1_竜性_鱗6CP;

		public ColorP X0Y0_中指_爪CP;

		public ColorP X0Y0_中指_指3CP;

		public ColorP X0Y0_中指_指2CP;

		public ColorP X0Y0_中指_指1CP;

		public ColorP X0Y0_中指_竜性_鱗3_竜性_鱗1CP;

		public ColorP X0Y0_中指_竜性_鱗3_竜性_鱗2CP;

		public ColorP X0Y0_中指_竜性_鱗3_竜性_鱗3CP;

		public ColorP X0Y0_中指_竜性_鱗3_竜性_鱗4CP;

		public ColorP X0Y0_中指_竜性_鱗2_竜性_鱗1CP;

		public ColorP X0Y0_中指_竜性_鱗2_竜性_鱗2CP;

		public ColorP X0Y0_中指_竜性_鱗2_竜性_鱗3CP;

		public ColorP X0Y0_中指_竜性_鱗2_竜性_鱗4CP;

		public ColorP X0Y0_中指_竜性_鱗1_竜性_鱗1CP;

		public ColorP X0Y0_中指_竜性_鱗1_竜性_鱗2CP;

		public ColorP X0Y0_中指_竜性_鱗1_竜性_鱗3CP;

		public ColorP X0Y0_中指_竜性_鱗1_竜性_鱗4CP;

		public ColorP X0Y0_中指_竜性_鱗1_竜性_鱗5CP;

		public ColorP X0Y0_中指_竜性_鱗1_竜性_鱗6CP;

		public ColorP X0Y0_人指_爪CP;

		public ColorP X0Y0_人指_指2CP;

		public ColorP X0Y0_人指_指1CP;

		public ColorP X0Y0_人指_竜性_鱗2_竜性_鱗1CP;

		public ColorP X0Y0_人指_竜性_鱗2_竜性_鱗2CP;

		public ColorP X0Y0_人指_竜性_鱗2_竜性_鱗3CP;

		public ColorP X0Y0_人指_竜性_鱗2_竜性_鱗4CP;

		public ColorP X0Y0_人指_竜性_鱗1_竜性_鱗1CP;

		public ColorP X0Y0_人指_竜性_鱗1_竜性_鱗2CP;

		public ColorP X0Y0_人指_竜性_鱗1_竜性_鱗3CP;

		public ColorP X0Y0_人指_竜性_鱗1_竜性_鱗4CP;

		public ColorP X0Y0_人指_竜性_鱗1_竜性_鱗5CP;

		public ColorP X0Y0_人指_竜性_鱗1_竜性_鱗6CP;

		public ColorP X0Y0_脚輪_革CP;

		public ColorP X0Y0_脚輪_金具1CP;

		public ColorP X0Y0_脚輪_金具2CP;

		public ColorP X0Y0_脚輪_金具3CP;

		public ColorP X0Y0_脚輪_金具左CP;

		public ColorP X0Y0_脚輪_金具右CP;

		public ColorP X0Y0_親指_爪CP;

		public ColorP X0Y0_親指_指1CP;

		public ColorP X0Y0_親指_竜性_鱗1_竜性_鱗1CP;

		public ColorP X0Y0_親指_竜性_鱗1_竜性_鱗2CP;

		public ColorP X0Y0_親指_竜性_鱗1_竜性_鱗3CP;

		public ColorP X0Y0_親指_竜性_鱗1_竜性_鱗4CP;

		public ColorP X0Y0_親指_竜性_鱗1_竜性_鱗5CP;

		public ColorP X0Y0_親指_竜性_鱗1_竜性_鱗6CP;

		public 拘束鎖 鎖1;
	}
}
