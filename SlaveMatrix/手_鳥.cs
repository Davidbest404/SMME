using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 手_鳥 : 翼手
	{
		public 手_鳥(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 手_鳥D e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.腕左["鳥翼手"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_鳥翼手 = pars["鳥翼手"].ToPar();
			Pars pars2 = pars["風切羽"].ToPars();
			this.X0Y0_風切羽_羽10 = pars2["羽10"].ToPar();
			this.X0Y0_風切羽_羽9 = pars2["羽9"].ToPar();
			this.X0Y0_風切羽_羽8 = pars2["羽8"].ToPar();
			this.X0Y0_風切羽_羽7 = pars2["羽7"].ToPar();
			this.X0Y0_風切羽_羽6 = pars2["羽6"].ToPar();
			this.X0Y0_風切羽_羽5 = pars2["羽5"].ToPar();
			this.X0Y0_風切羽_羽4 = pars2["羽4"].ToPar();
			this.X0Y0_風切羽_羽3 = pars2["羽3"].ToPar();
			this.X0Y0_風切羽_羽2 = pars2["羽2"].ToPar();
			this.X0Y0_風切羽_羽1 = pars2["羽1"].ToPar();
			pars2 = pars["雨覆羽"].ToPars();
			this.X0Y0_雨覆羽_羽10 = pars2["羽10"].ToPar();
			this.X0Y0_雨覆羽_羽9 = pars2["羽9"].ToPar();
			this.X0Y0_雨覆羽_羽8 = pars2["羽8"].ToPar();
			this.X0Y0_雨覆羽_羽7 = pars2["羽7"].ToPar();
			this.X0Y0_雨覆羽_羽6 = pars2["羽6"].ToPar();
			this.X0Y0_雨覆羽_羽5 = pars2["羽5"].ToPar();
			this.X0Y0_雨覆羽_羽4 = pars2["羽4"].ToPar();
			this.X0Y0_雨覆羽_羽3 = pars2["羽3"].ToPar();
			this.X0Y0_雨覆羽_羽2 = pars2["羽2"].ToPar();
			this.X0Y0_雨覆羽_羽1 = pars2["羽1"].ToPar();
			pars2 = pars["小翼羽"].ToPars();
			this.X0Y0_小翼羽_羽3 = pars2["羽3"].ToPar();
			this.X0Y0_小翼羽_羽2 = pars2["羽2"].ToPar();
			this.X0Y0_小翼羽_羽1 = pars2["羽1"].ToPar();
			pars2 = pars["指"].ToPars();
			Pars pars3 = pars2["中指"].ToPars();
			this.X0Y0_指_中指_爪 = pars3["爪"].ToPar();
			this.X0Y0_指_中指_指3 = pars3["指3"].ToPar();
			this.X0Y0_指_中指_指2 = pars3["指2"].ToPar();
			this.X0Y0_指_中指_指1 = pars3["指1"].ToPar();
			Pars pars4 = pars3["鱗3"].ToPars();
			this.X0Y0_指_中指_鱗3_鱗1 = pars4["鱗1"].ToPar();
			this.X0Y0_指_中指_鱗3_鱗2 = pars4["鱗2"].ToPar();
			this.X0Y0_指_中指_鱗3_鱗3 = pars4["鱗3"].ToPar();
			this.X0Y0_指_中指_鱗3_鱗4 = pars4["鱗4"].ToPar();
			pars4 = pars3["鱗2"].ToPars();
			this.X0Y0_指_中指_鱗2_鱗1 = pars4["鱗1"].ToPar();
			this.X0Y0_指_中指_鱗2_鱗2 = pars4["鱗2"].ToPar();
			this.X0Y0_指_中指_鱗2_鱗3 = pars4["鱗3"].ToPar();
			this.X0Y0_指_中指_鱗2_鱗4 = pars4["鱗4"].ToPar();
			pars4 = pars3["鱗1"].ToPars();
			this.X0Y0_指_中指_鱗1_鱗1 = pars4["鱗1"].ToPar();
			this.X0Y0_指_中指_鱗1_鱗2 = pars4["鱗2"].ToPar();
			this.X0Y0_指_中指_鱗1_鱗3 = pars4["鱗3"].ToPar();
			this.X0Y0_指_中指_鱗1_鱗4 = pars4["鱗4"].ToPar();
			this.X0Y0_指_中指_鱗1_鱗5 = pars4["鱗5"].ToPar();
			this.X0Y0_指_中指_鱗1_鱗6 = pars4["鱗6"].ToPar();
			pars3 = pars2["人指"].ToPars();
			this.X0Y0_指_人指_爪 = pars3["爪"].ToPar();
			this.X0Y0_指_人指_指3 = pars3["指3"].ToPar();
			this.X0Y0_指_人指_指2 = pars3["指2"].ToPar();
			this.X0Y0_指_人指_指1 = pars3["指1"].ToPar();
			pars4 = pars3["鱗3"].ToPars();
			this.X0Y0_指_人指_鱗3_鱗1 = pars4["鱗1"].ToPar();
			this.X0Y0_指_人指_鱗3_鱗2 = pars4["鱗2"].ToPar();
			this.X0Y0_指_人指_鱗3_鱗3 = pars4["鱗3"].ToPar();
			this.X0Y0_指_人指_鱗3_鱗4 = pars4["鱗4"].ToPar();
			pars4 = pars3["鱗2"].ToPars();
			this.X0Y0_指_人指_鱗2_鱗1 = pars4["鱗1"].ToPar();
			this.X0Y0_指_人指_鱗2_鱗2 = pars4["鱗2"].ToPar();
			this.X0Y0_指_人指_鱗2_鱗3 = pars4["鱗3"].ToPar();
			this.X0Y0_指_人指_鱗2_鱗4 = pars4["鱗4"].ToPar();
			pars4 = pars3["鱗1"].ToPars();
			this.X0Y0_指_人指_鱗1_鱗1 = pars4["鱗1"].ToPar();
			this.X0Y0_指_人指_鱗1_鱗2 = pars4["鱗2"].ToPar();
			this.X0Y0_指_人指_鱗1_鱗3 = pars4["鱗3"].ToPar();
			this.X0Y0_指_人指_鱗1_鱗4 = pars4["鱗4"].ToPar();
			this.X0Y0_指_人指_鱗1_鱗5 = pars4["鱗5"].ToPar();
			this.X0Y0_指_人指_鱗1_鱗6 = pars4["鱗6"].ToPar();
			pars3 = pars2["親指"].ToPars();
			this.X0Y0_指_親指_爪 = pars3["爪"].ToPar();
			this.X0Y0_指_親指_指2 = pars3["指2"].ToPar();
			this.X0Y0_指_親指_指1 = pars3["指1"].ToPar();
			pars4 = pars3["鱗2"].ToPars();
			this.X0Y0_指_親指_鱗2_鱗1 = pars4["鱗1"].ToPar();
			this.X0Y0_指_親指_鱗2_鱗2 = pars4["鱗2"].ToPar();
			this.X0Y0_指_親指_鱗2_鱗3 = pars4["鱗3"].ToPar();
			this.X0Y0_指_親指_鱗2_鱗4 = pars4["鱗4"].ToPar();
			pars4 = pars3["鱗1"].ToPars();
			this.X0Y0_指_親指_鱗1_鱗1 = pars4["鱗1"].ToPar();
			this.X0Y0_指_親指_鱗1_鱗2 = pars4["鱗2"].ToPar();
			this.X0Y0_指_親指_鱗1_鱗3 = pars4["鱗3"].ToPar();
			this.X0Y0_指_親指_鱗1_鱗4 = pars4["鱗4"].ToPar();
			this.X0Y0_指_親指_鱗1_鱗5 = pars4["鱗5"].ToPar();
			this.X0Y0_指_親指_鱗1_鱗6 = pars4["鱗6"].ToPar();
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
			this.鳥翼手_表示 = e.鳥翼手_表示;
			this.風切羽_羽10_表示 = e.風切羽_羽10_表示;
			this.風切羽_羽9_表示 = e.風切羽_羽9_表示;
			this.風切羽_羽8_表示 = e.風切羽_羽8_表示;
			this.風切羽_羽7_表示 = e.風切羽_羽7_表示;
			this.風切羽_羽6_表示 = e.風切羽_羽6_表示;
			this.風切羽_羽5_表示 = e.風切羽_羽5_表示;
			this.風切羽_羽4_表示 = e.風切羽_羽4_表示;
			this.風切羽_羽3_表示 = e.風切羽_羽3_表示;
			this.風切羽_羽2_表示 = e.風切羽_羽2_表示;
			this.風切羽_羽1_表示 = e.風切羽_羽1_表示;
			this.雨覆羽_羽10_表示 = e.雨覆羽_羽10_表示;
			this.雨覆羽_羽9_表示 = e.雨覆羽_羽9_表示;
			this.雨覆羽_羽8_表示 = e.雨覆羽_羽8_表示;
			this.雨覆羽_羽7_表示 = e.雨覆羽_羽7_表示;
			this.雨覆羽_羽6_表示 = e.雨覆羽_羽6_表示;
			this.雨覆羽_羽5_表示 = e.雨覆羽_羽5_表示;
			this.雨覆羽_羽4_表示 = e.雨覆羽_羽4_表示;
			this.雨覆羽_羽3_表示 = e.雨覆羽_羽3_表示;
			this.雨覆羽_羽2_表示 = e.雨覆羽_羽2_表示;
			this.雨覆羽_羽1_表示 = e.雨覆羽_羽1_表示;
			this.小翼羽_羽3_表示 = e.小翼羽_羽3_表示;
			this.小翼羽_羽2_表示 = e.小翼羽_羽2_表示;
			this.小翼羽_羽1_表示 = e.小翼羽_羽1_表示;
			this.指_中指_爪_表示 = e.指_中指_爪_表示;
			this.指_中指_指3_表示 = e.指_中指_指3_表示;
			this.指_中指_指2_表示 = e.指_中指_指2_表示;
			this.指_中指_指1_表示 = e.指_中指_指1_表示;
			this.指_中指_鱗3_鱗1_表示 = e.指_中指_鱗3_鱗1_表示;
			this.指_中指_鱗3_鱗2_表示 = e.指_中指_鱗3_鱗2_表示;
			this.指_中指_鱗3_鱗3_表示 = e.指_中指_鱗3_鱗3_表示;
			this.指_中指_鱗3_鱗4_表示 = e.指_中指_鱗3_鱗4_表示;
			this.指_中指_鱗2_鱗1_表示 = e.指_中指_鱗2_鱗1_表示;
			this.指_中指_鱗2_鱗2_表示 = e.指_中指_鱗2_鱗2_表示;
			this.指_中指_鱗2_鱗3_表示 = e.指_中指_鱗2_鱗3_表示;
			this.指_中指_鱗2_鱗4_表示 = e.指_中指_鱗2_鱗4_表示;
			this.指_中指_鱗1_鱗1_表示 = e.指_中指_鱗1_鱗1_表示;
			this.指_中指_鱗1_鱗2_表示 = e.指_中指_鱗1_鱗2_表示;
			this.指_中指_鱗1_鱗3_表示 = e.指_中指_鱗1_鱗3_表示;
			this.指_中指_鱗1_鱗4_表示 = e.指_中指_鱗1_鱗4_表示;
			this.指_中指_鱗1_鱗5_表示 = e.指_中指_鱗1_鱗5_表示;
			this.指_中指_鱗1_鱗6_表示 = e.指_中指_鱗1_鱗6_表示;
			this.指_人指_爪_表示 = e.指_人指_爪_表示;
			this.指_人指_指3_表示 = e.指_人指_指3_表示;
			this.指_人指_指2_表示 = e.指_人指_指2_表示;
			this.指_人指_指1_表示 = e.指_人指_指1_表示;
			this.指_人指_鱗3_鱗1_表示 = e.指_人指_鱗3_鱗1_表示;
			this.指_人指_鱗3_鱗2_表示 = e.指_人指_鱗3_鱗2_表示;
			this.指_人指_鱗3_鱗3_表示 = e.指_人指_鱗3_鱗3_表示;
			this.指_人指_鱗3_鱗4_表示 = e.指_人指_鱗3_鱗4_表示;
			this.指_人指_鱗2_鱗1_表示 = e.指_人指_鱗2_鱗1_表示;
			this.指_人指_鱗2_鱗2_表示 = e.指_人指_鱗2_鱗2_表示;
			this.指_人指_鱗2_鱗3_表示 = e.指_人指_鱗2_鱗3_表示;
			this.指_人指_鱗2_鱗4_表示 = e.指_人指_鱗2_鱗4_表示;
			this.指_人指_鱗1_鱗1_表示 = e.指_人指_鱗1_鱗1_表示;
			this.指_人指_鱗1_鱗2_表示 = e.指_人指_鱗1_鱗2_表示;
			this.指_人指_鱗1_鱗3_表示 = e.指_人指_鱗1_鱗3_表示;
			this.指_人指_鱗1_鱗4_表示 = e.指_人指_鱗1_鱗4_表示;
			this.指_人指_鱗1_鱗5_表示 = e.指_人指_鱗1_鱗5_表示;
			this.指_人指_鱗1_鱗6_表示 = e.指_人指_鱗1_鱗6_表示;
			this.指_親指_爪_表示 = e.指_親指_爪_表示;
			this.指_親指_指2_表示 = e.指_親指_指2_表示;
			this.指_親指_指1_表示 = e.指_親指_指1_表示;
			this.指_親指_鱗2_鱗1_表示 = e.指_親指_鱗2_鱗1_表示;
			this.指_親指_鱗2_鱗2_表示 = e.指_親指_鱗2_鱗2_表示;
			this.指_親指_鱗2_鱗3_表示 = e.指_親指_鱗2_鱗3_表示;
			this.指_親指_鱗2_鱗4_表示 = e.指_親指_鱗2_鱗4_表示;
			this.指_親指_鱗1_鱗1_表示 = e.指_親指_鱗1_鱗1_表示;
			this.指_親指_鱗1_鱗2_表示 = e.指_親指_鱗1_鱗2_表示;
			this.指_親指_鱗1_鱗3_表示 = e.指_親指_鱗1_鱗3_表示;
			this.指_親指_鱗1_鱗4_表示 = e.指_親指_鱗1_鱗4_表示;
			this.指_親指_鱗1_鱗5_表示 = e.指_親指_鱗1_鱗5_表示;
			this.指_親指_鱗1_鱗6_表示 = e.指_親指_鱗1_鱗6_表示;
			this.指_表示 = e.指_表示;
			this.展開 = e.展開;
			this.シャ\u30FCプ = e.シャ\u30FCプ;
			this.手_外線 = e.手_外線;
			this.小翼羽_羽1_外線 = e.小翼羽_羽1_外線;
			this.小翼羽_羽2_外線 = e.小翼羽_羽2_外線;
			this.小翼羽_羽3_外線 = e.小翼羽_羽3_外線;
			this.雨覆羽_羽1_外線 = e.雨覆羽_羽1_外線;
			this.雨覆羽_羽2_外線 = e.雨覆羽_羽2_外線;
			this.雨覆羽_羽3_外線 = e.雨覆羽_羽3_外線;
			this.雨覆羽_羽4_外線 = e.雨覆羽_羽4_外線;
			this.雨覆羽_羽5_外線 = e.雨覆羽_羽5_外線;
			this.雨覆羽_羽6_外線 = e.雨覆羽_羽6_外線;
			this.雨覆羽_羽7_外線 = e.雨覆羽_羽7_外線;
			this.雨覆羽_羽8_外線 = e.雨覆羽_羽8_外線;
			this.雨覆羽_羽9_外線 = e.雨覆羽_羽9_外線;
			this.雨覆羽_羽10_外線 = e.雨覆羽_羽10_外線;
			this.風切羽_羽1_外線 = e.風切羽_羽1_外線;
			this.風切羽_羽2_外線 = e.風切羽_羽2_外線;
			this.風切羽_羽3_外線 = e.風切羽_羽3_外線;
			this.風切羽_羽4_外線 = e.風切羽_羽4_外線;
			this.風切羽_羽5_外線 = e.風切羽_羽5_外線;
			this.風切羽_羽6_外線 = e.風切羽_羽6_外線;
			this.風切羽_羽7_外線 = e.風切羽_羽7_外線;
			this.風切羽_羽8_外線 = e.風切羽_羽8_外線;
			this.風切羽_羽9_外線 = e.風切羽_羽9_外線;
			this.風切羽_羽10_外線 = e.風切羽_羽10_外線;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_鳥翼手CP = new ColorP(this.X0Y0_鳥翼手, this.鳥翼手CD, DisUnit, true);
			this.X0Y0_風切羽_羽10CP = new ColorP(this.X0Y0_風切羽_羽10, this.風切羽_羽10CD, DisUnit, true);
			this.X0Y0_風切羽_羽9CP = new ColorP(this.X0Y0_風切羽_羽9, this.風切羽_羽9CD, DisUnit, true);
			this.X0Y0_風切羽_羽8CP = new ColorP(this.X0Y0_風切羽_羽8, this.風切羽_羽8CD, DisUnit, true);
			this.X0Y0_風切羽_羽7CP = new ColorP(this.X0Y0_風切羽_羽7, this.風切羽_羽7CD, DisUnit, true);
			this.X0Y0_風切羽_羽6CP = new ColorP(this.X0Y0_風切羽_羽6, this.風切羽_羽6CD, DisUnit, true);
			this.X0Y0_風切羽_羽5CP = new ColorP(this.X0Y0_風切羽_羽5, this.風切羽_羽5CD, DisUnit, true);
			this.X0Y0_風切羽_羽4CP = new ColorP(this.X0Y0_風切羽_羽4, this.風切羽_羽4CD, DisUnit, true);
			this.X0Y0_風切羽_羽3CP = new ColorP(this.X0Y0_風切羽_羽3, this.風切羽_羽3CD, DisUnit, true);
			this.X0Y0_風切羽_羽2CP = new ColorP(this.X0Y0_風切羽_羽2, this.風切羽_羽2CD, DisUnit, true);
			this.X0Y0_風切羽_羽1CP = new ColorP(this.X0Y0_風切羽_羽1, this.風切羽_羽1CD, DisUnit, true);
			this.X0Y0_雨覆羽_羽10CP = new ColorP(this.X0Y0_雨覆羽_羽10, this.雨覆羽_羽10CD, DisUnit, true);
			this.X0Y0_雨覆羽_羽9CP = new ColorP(this.X0Y0_雨覆羽_羽9, this.雨覆羽_羽9CD, DisUnit, true);
			this.X0Y0_雨覆羽_羽8CP = new ColorP(this.X0Y0_雨覆羽_羽8, this.雨覆羽_羽8CD, DisUnit, true);
			this.X0Y0_雨覆羽_羽7CP = new ColorP(this.X0Y0_雨覆羽_羽7, this.雨覆羽_羽7CD, DisUnit, true);
			this.X0Y0_雨覆羽_羽6CP = new ColorP(this.X0Y0_雨覆羽_羽6, this.雨覆羽_羽6CD, DisUnit, true);
			this.X0Y0_雨覆羽_羽5CP = new ColorP(this.X0Y0_雨覆羽_羽5, this.雨覆羽_羽5CD, DisUnit, true);
			this.X0Y0_雨覆羽_羽4CP = new ColorP(this.X0Y0_雨覆羽_羽4, this.雨覆羽_羽4CD, DisUnit, true);
			this.X0Y0_雨覆羽_羽3CP = new ColorP(this.X0Y0_雨覆羽_羽3, this.雨覆羽_羽3CD, DisUnit, true);
			this.X0Y0_雨覆羽_羽2CP = new ColorP(this.X0Y0_雨覆羽_羽2, this.雨覆羽_羽2CD, DisUnit, true);
			this.X0Y0_雨覆羽_羽1CP = new ColorP(this.X0Y0_雨覆羽_羽1, this.雨覆羽_羽1CD, DisUnit, true);
			this.X0Y0_小翼羽_羽3CP = new ColorP(this.X0Y0_小翼羽_羽3, this.小翼羽_羽3CD, DisUnit, true);
			this.X0Y0_小翼羽_羽2CP = new ColorP(this.X0Y0_小翼羽_羽2, this.小翼羽_羽2CD, DisUnit, true);
			this.X0Y0_小翼羽_羽1CP = new ColorP(this.X0Y0_小翼羽_羽1, this.小翼羽_羽1CD, DisUnit, true);
			this.X0Y0_指_中指_爪CP = new ColorP(this.X0Y0_指_中指_爪, this.指_中指_爪CD, DisUnit, true);
			this.X0Y0_指_中指_指3CP = new ColorP(this.X0Y0_指_中指_指3, this.指_中指_指3CD, DisUnit, true);
			this.X0Y0_指_中指_指2CP = new ColorP(this.X0Y0_指_中指_指2, this.指_中指_指2CD, DisUnit, true);
			this.X0Y0_指_中指_指1CP = new ColorP(this.X0Y0_指_中指_指1, this.指_中指_指1CD, DisUnit, true);
			this.X0Y0_指_中指_鱗3_鱗1CP = new ColorP(this.X0Y0_指_中指_鱗3_鱗1, this.指_中指_鱗3_鱗1CD, DisUnit, true);
			this.X0Y0_指_中指_鱗3_鱗2CP = new ColorP(this.X0Y0_指_中指_鱗3_鱗2, this.指_中指_鱗3_鱗2CD, DisUnit, true);
			this.X0Y0_指_中指_鱗3_鱗3CP = new ColorP(this.X0Y0_指_中指_鱗3_鱗3, this.指_中指_鱗3_鱗3CD, DisUnit, true);
			this.X0Y0_指_中指_鱗3_鱗4CP = new ColorP(this.X0Y0_指_中指_鱗3_鱗4, this.指_中指_鱗3_鱗4CD, DisUnit, true);
			this.X0Y0_指_中指_鱗2_鱗1CP = new ColorP(this.X0Y0_指_中指_鱗2_鱗1, this.指_中指_鱗2_鱗1CD, DisUnit, true);
			this.X0Y0_指_中指_鱗2_鱗2CP = new ColorP(this.X0Y0_指_中指_鱗2_鱗2, this.指_中指_鱗2_鱗2CD, DisUnit, true);
			this.X0Y0_指_中指_鱗2_鱗3CP = new ColorP(this.X0Y0_指_中指_鱗2_鱗3, this.指_中指_鱗2_鱗3CD, DisUnit, true);
			this.X0Y0_指_中指_鱗2_鱗4CP = new ColorP(this.X0Y0_指_中指_鱗2_鱗4, this.指_中指_鱗2_鱗4CD, DisUnit, true);
			this.X0Y0_指_中指_鱗1_鱗1CP = new ColorP(this.X0Y0_指_中指_鱗1_鱗1, this.指_中指_鱗1_鱗1CD, DisUnit, true);
			this.X0Y0_指_中指_鱗1_鱗2CP = new ColorP(this.X0Y0_指_中指_鱗1_鱗2, this.指_中指_鱗1_鱗2CD, DisUnit, true);
			this.X0Y0_指_中指_鱗1_鱗3CP = new ColorP(this.X0Y0_指_中指_鱗1_鱗3, this.指_中指_鱗1_鱗3CD, DisUnit, true);
			this.X0Y0_指_中指_鱗1_鱗4CP = new ColorP(this.X0Y0_指_中指_鱗1_鱗4, this.指_中指_鱗1_鱗4CD, DisUnit, true);
			this.X0Y0_指_中指_鱗1_鱗5CP = new ColorP(this.X0Y0_指_中指_鱗1_鱗5, this.指_中指_鱗1_鱗5CD, DisUnit, true);
			this.X0Y0_指_中指_鱗1_鱗6CP = new ColorP(this.X0Y0_指_中指_鱗1_鱗6, this.指_中指_鱗1_鱗6CD, DisUnit, true);
			this.X0Y0_指_人指_爪CP = new ColorP(this.X0Y0_指_人指_爪, this.指_人指_爪CD, DisUnit, true);
			this.X0Y0_指_人指_指3CP = new ColorP(this.X0Y0_指_人指_指3, this.指_人指_指3CD, DisUnit, true);
			this.X0Y0_指_人指_指2CP = new ColorP(this.X0Y0_指_人指_指2, this.指_人指_指2CD, DisUnit, true);
			this.X0Y0_指_人指_指1CP = new ColorP(this.X0Y0_指_人指_指1, this.指_人指_指1CD, DisUnit, true);
			this.X0Y0_指_人指_鱗3_鱗1CP = new ColorP(this.X0Y0_指_人指_鱗3_鱗1, this.指_人指_鱗3_鱗1CD, DisUnit, true);
			this.X0Y0_指_人指_鱗3_鱗2CP = new ColorP(this.X0Y0_指_人指_鱗3_鱗2, this.指_人指_鱗3_鱗2CD, DisUnit, true);
			this.X0Y0_指_人指_鱗3_鱗3CP = new ColorP(this.X0Y0_指_人指_鱗3_鱗3, this.指_人指_鱗3_鱗3CD, DisUnit, true);
			this.X0Y0_指_人指_鱗3_鱗4CP = new ColorP(this.X0Y0_指_人指_鱗3_鱗4, this.指_人指_鱗3_鱗4CD, DisUnit, true);
			this.X0Y0_指_人指_鱗2_鱗1CP = new ColorP(this.X0Y0_指_人指_鱗2_鱗1, this.指_人指_鱗2_鱗1CD, DisUnit, true);
			this.X0Y0_指_人指_鱗2_鱗2CP = new ColorP(this.X0Y0_指_人指_鱗2_鱗2, this.指_人指_鱗2_鱗2CD, DisUnit, true);
			this.X0Y0_指_人指_鱗2_鱗3CP = new ColorP(this.X0Y0_指_人指_鱗2_鱗3, this.指_人指_鱗2_鱗3CD, DisUnit, true);
			this.X0Y0_指_人指_鱗2_鱗4CP = new ColorP(this.X0Y0_指_人指_鱗2_鱗4, this.指_人指_鱗2_鱗4CD, DisUnit, true);
			this.X0Y0_指_人指_鱗1_鱗1CP = new ColorP(this.X0Y0_指_人指_鱗1_鱗1, this.指_人指_鱗1_鱗1CD, DisUnit, true);
			this.X0Y0_指_人指_鱗1_鱗2CP = new ColorP(this.X0Y0_指_人指_鱗1_鱗2, this.指_人指_鱗1_鱗2CD, DisUnit, true);
			this.X0Y0_指_人指_鱗1_鱗3CP = new ColorP(this.X0Y0_指_人指_鱗1_鱗3, this.指_人指_鱗1_鱗3CD, DisUnit, true);
			this.X0Y0_指_人指_鱗1_鱗4CP = new ColorP(this.X0Y0_指_人指_鱗1_鱗4, this.指_人指_鱗1_鱗4CD, DisUnit, true);
			this.X0Y0_指_人指_鱗1_鱗5CP = new ColorP(this.X0Y0_指_人指_鱗1_鱗5, this.指_人指_鱗1_鱗5CD, DisUnit, true);
			this.X0Y0_指_人指_鱗1_鱗6CP = new ColorP(this.X0Y0_指_人指_鱗1_鱗6, this.指_人指_鱗1_鱗6CD, DisUnit, true);
			this.X0Y0_指_親指_爪CP = new ColorP(this.X0Y0_指_親指_爪, this.指_親指_爪CD, DisUnit, true);
			this.X0Y0_指_親指_指2CP = new ColorP(this.X0Y0_指_親指_指2, this.指_親指_指2CD, DisUnit, true);
			this.X0Y0_指_親指_指1CP = new ColorP(this.X0Y0_指_親指_指1, this.指_親指_指1CD, DisUnit, true);
			this.X0Y0_指_親指_鱗2_鱗1CP = new ColorP(this.X0Y0_指_親指_鱗2_鱗1, this.指_親指_鱗2_鱗1CD, DisUnit, true);
			this.X0Y0_指_親指_鱗2_鱗2CP = new ColorP(this.X0Y0_指_親指_鱗2_鱗2, this.指_親指_鱗2_鱗2CD, DisUnit, true);
			this.X0Y0_指_親指_鱗2_鱗3CP = new ColorP(this.X0Y0_指_親指_鱗2_鱗3, this.指_親指_鱗2_鱗3CD, DisUnit, true);
			this.X0Y0_指_親指_鱗2_鱗4CP = new ColorP(this.X0Y0_指_親指_鱗2_鱗4, this.指_親指_鱗2_鱗4CD, DisUnit, true);
			this.X0Y0_指_親指_鱗1_鱗1CP = new ColorP(this.X0Y0_指_親指_鱗1_鱗1, this.指_親指_鱗1_鱗1CD, DisUnit, true);
			this.X0Y0_指_親指_鱗1_鱗2CP = new ColorP(this.X0Y0_指_親指_鱗1_鱗2, this.指_親指_鱗1_鱗2CD, DisUnit, true);
			this.X0Y0_指_親指_鱗1_鱗3CP = new ColorP(this.X0Y0_指_親指_鱗1_鱗3, this.指_親指_鱗1_鱗3CD, DisUnit, true);
			this.X0Y0_指_親指_鱗1_鱗4CP = new ColorP(this.X0Y0_指_親指_鱗1_鱗4, this.指_親指_鱗1_鱗4CD, DisUnit, true);
			this.X0Y0_指_親指_鱗1_鱗5CP = new ColorP(this.X0Y0_指_親指_鱗1_鱗5, this.指_親指_鱗1_鱗5CD, DisUnit, true);
			this.X0Y0_指_親指_鱗1_鱗6CP = new ColorP(this.X0Y0_指_親指_鱗1_鱗6, this.指_親指_鱗1_鱗6CD, DisUnit, true);
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

		public bool 鳥翼手_表示
		{
			get
			{
				return this.X0Y0_鳥翼手.Dra;
			}
			set
			{
				this.X0Y0_鳥翼手.Dra = value;
				this.X0Y0_鳥翼手.Hit = value;
			}
		}

		public bool 風切羽_羽10_表示
		{
			get
			{
				return this.X0Y0_風切羽_羽10.Dra;
			}
			set
			{
				this.X0Y0_風切羽_羽10.Dra = value;
				this.X0Y0_風切羽_羽10.Hit = value;
			}
		}

		public bool 風切羽_羽9_表示
		{
			get
			{
				return this.X0Y0_風切羽_羽9.Dra;
			}
			set
			{
				this.X0Y0_風切羽_羽9.Dra = value;
				this.X0Y0_風切羽_羽9.Hit = value;
			}
		}

		public bool 風切羽_羽8_表示
		{
			get
			{
				return this.X0Y0_風切羽_羽8.Dra;
			}
			set
			{
				this.X0Y0_風切羽_羽8.Dra = value;
				this.X0Y0_風切羽_羽8.Hit = value;
			}
		}

		public bool 風切羽_羽7_表示
		{
			get
			{
				return this.X0Y0_風切羽_羽7.Dra;
			}
			set
			{
				this.X0Y0_風切羽_羽7.Dra = value;
				this.X0Y0_風切羽_羽7.Hit = value;
			}
		}

		public bool 風切羽_羽6_表示
		{
			get
			{
				return this.X0Y0_風切羽_羽6.Dra;
			}
			set
			{
				this.X0Y0_風切羽_羽6.Dra = value;
				this.X0Y0_風切羽_羽6.Hit = value;
			}
		}

		public bool 風切羽_羽5_表示
		{
			get
			{
				return this.X0Y0_風切羽_羽5.Dra;
			}
			set
			{
				this.X0Y0_風切羽_羽5.Dra = value;
				this.X0Y0_風切羽_羽5.Hit = value;
			}
		}

		public bool 風切羽_羽4_表示
		{
			get
			{
				return this.X0Y0_風切羽_羽4.Dra;
			}
			set
			{
				this.X0Y0_風切羽_羽4.Dra = value;
				this.X0Y0_風切羽_羽4.Hit = value;
			}
		}

		public bool 風切羽_羽3_表示
		{
			get
			{
				return this.X0Y0_風切羽_羽3.Dra;
			}
			set
			{
				this.X0Y0_風切羽_羽3.Dra = value;
				this.X0Y0_風切羽_羽3.Hit = value;
			}
		}

		public bool 風切羽_羽2_表示
		{
			get
			{
				return this.X0Y0_風切羽_羽2.Dra;
			}
			set
			{
				this.X0Y0_風切羽_羽2.Dra = value;
				this.X0Y0_風切羽_羽2.Hit = value;
			}
		}

		public bool 風切羽_羽1_表示
		{
			get
			{
				return this.X0Y0_風切羽_羽1.Dra;
			}
			set
			{
				this.X0Y0_風切羽_羽1.Dra = value;
				this.X0Y0_風切羽_羽1.Hit = value;
			}
		}

		public bool 雨覆羽_羽10_表示
		{
			get
			{
				return this.X0Y0_雨覆羽_羽10.Dra;
			}
			set
			{
				this.X0Y0_雨覆羽_羽10.Dra = value;
				this.X0Y0_雨覆羽_羽10.Hit = value;
			}
		}

		public bool 雨覆羽_羽9_表示
		{
			get
			{
				return this.X0Y0_雨覆羽_羽9.Dra;
			}
			set
			{
				this.X0Y0_雨覆羽_羽9.Dra = value;
				this.X0Y0_雨覆羽_羽9.Hit = value;
			}
		}

		public bool 雨覆羽_羽8_表示
		{
			get
			{
				return this.X0Y0_雨覆羽_羽8.Dra;
			}
			set
			{
				this.X0Y0_雨覆羽_羽8.Dra = value;
				this.X0Y0_雨覆羽_羽8.Hit = value;
			}
		}

		public bool 雨覆羽_羽7_表示
		{
			get
			{
				return this.X0Y0_雨覆羽_羽7.Dra;
			}
			set
			{
				this.X0Y0_雨覆羽_羽7.Dra = value;
				this.X0Y0_雨覆羽_羽7.Hit = value;
			}
		}

		public bool 雨覆羽_羽6_表示
		{
			get
			{
				return this.X0Y0_雨覆羽_羽6.Dra;
			}
			set
			{
				this.X0Y0_雨覆羽_羽6.Dra = value;
				this.X0Y0_雨覆羽_羽6.Hit = value;
			}
		}

		public bool 雨覆羽_羽5_表示
		{
			get
			{
				return this.X0Y0_雨覆羽_羽5.Dra;
			}
			set
			{
				this.X0Y0_雨覆羽_羽5.Dra = value;
				this.X0Y0_雨覆羽_羽5.Hit = value;
			}
		}

		public bool 雨覆羽_羽4_表示
		{
			get
			{
				return this.X0Y0_雨覆羽_羽4.Dra;
			}
			set
			{
				this.X0Y0_雨覆羽_羽4.Dra = value;
				this.X0Y0_雨覆羽_羽4.Hit = value;
			}
		}

		public bool 雨覆羽_羽3_表示
		{
			get
			{
				return this.X0Y0_雨覆羽_羽3.Dra;
			}
			set
			{
				this.X0Y0_雨覆羽_羽3.Dra = value;
				this.X0Y0_雨覆羽_羽3.Hit = value;
			}
		}

		public bool 雨覆羽_羽2_表示
		{
			get
			{
				return this.X0Y0_雨覆羽_羽2.Dra;
			}
			set
			{
				this.X0Y0_雨覆羽_羽2.Dra = value;
				this.X0Y0_雨覆羽_羽2.Hit = value;
			}
		}

		public bool 雨覆羽_羽1_表示
		{
			get
			{
				return this.X0Y0_雨覆羽_羽1.Dra;
			}
			set
			{
				this.X0Y0_雨覆羽_羽1.Dra = value;
				this.X0Y0_雨覆羽_羽1.Hit = value;
			}
		}

		public bool 小翼羽_羽3_表示
		{
			get
			{
				return this.X0Y0_小翼羽_羽3.Dra;
			}
			set
			{
				this.X0Y0_小翼羽_羽3.Dra = value;
				this.X0Y0_小翼羽_羽3.Hit = value;
			}
		}

		public bool 小翼羽_羽2_表示
		{
			get
			{
				return this.X0Y0_小翼羽_羽2.Dra;
			}
			set
			{
				this.X0Y0_小翼羽_羽2.Dra = value;
				this.X0Y0_小翼羽_羽2.Hit = value;
			}
		}

		public bool 小翼羽_羽1_表示
		{
			get
			{
				return this.X0Y0_小翼羽_羽1.Dra;
			}
			set
			{
				this.X0Y0_小翼羽_羽1.Dra = value;
				this.X0Y0_小翼羽_羽1.Hit = value;
			}
		}

		public bool 指_中指_爪_表示
		{
			get
			{
				return this.X0Y0_指_中指_爪.Dra;
			}
			set
			{
				this.X0Y0_指_中指_爪.Dra = value;
				this.X0Y0_指_中指_爪.Hit = value;
			}
		}

		public bool 指_中指_指3_表示
		{
			get
			{
				return this.X0Y0_指_中指_指3.Dra;
			}
			set
			{
				this.X0Y0_指_中指_指3.Dra = value;
				this.X0Y0_指_中指_指3.Hit = value;
			}
		}

		public bool 指_中指_指2_表示
		{
			get
			{
				return this.X0Y0_指_中指_指2.Dra;
			}
			set
			{
				this.X0Y0_指_中指_指2.Dra = value;
				this.X0Y0_指_中指_指2.Hit = value;
			}
		}

		public bool 指_中指_指1_表示
		{
			get
			{
				return this.X0Y0_指_中指_指1.Dra;
			}
			set
			{
				this.X0Y0_指_中指_指1.Dra = value;
				this.X0Y0_指_中指_指1.Hit = value;
			}
		}

		public bool 指_中指_鱗3_鱗1_表示
		{
			get
			{
				return this.X0Y0_指_中指_鱗3_鱗1.Dra;
			}
			set
			{
				this.X0Y0_指_中指_鱗3_鱗1.Dra = value;
				this.X0Y0_指_中指_鱗3_鱗1.Hit = value;
			}
		}

		public bool 指_中指_鱗3_鱗2_表示
		{
			get
			{
				return this.X0Y0_指_中指_鱗3_鱗2.Dra;
			}
			set
			{
				this.X0Y0_指_中指_鱗3_鱗2.Dra = value;
				this.X0Y0_指_中指_鱗3_鱗2.Hit = value;
			}
		}

		public bool 指_中指_鱗3_鱗3_表示
		{
			get
			{
				return this.X0Y0_指_中指_鱗3_鱗3.Dra;
			}
			set
			{
				this.X0Y0_指_中指_鱗3_鱗3.Dra = value;
				this.X0Y0_指_中指_鱗3_鱗3.Hit = value;
			}
		}

		public bool 指_中指_鱗3_鱗4_表示
		{
			get
			{
				return this.X0Y0_指_中指_鱗3_鱗4.Dra;
			}
			set
			{
				this.X0Y0_指_中指_鱗3_鱗4.Dra = value;
				this.X0Y0_指_中指_鱗3_鱗4.Hit = value;
			}
		}

		public bool 指_中指_鱗2_鱗1_表示
		{
			get
			{
				return this.X0Y0_指_中指_鱗2_鱗1.Dra;
			}
			set
			{
				this.X0Y0_指_中指_鱗2_鱗1.Dra = value;
				this.X0Y0_指_中指_鱗2_鱗1.Hit = value;
			}
		}

		public bool 指_中指_鱗2_鱗2_表示
		{
			get
			{
				return this.X0Y0_指_中指_鱗2_鱗2.Dra;
			}
			set
			{
				this.X0Y0_指_中指_鱗2_鱗2.Dra = value;
				this.X0Y0_指_中指_鱗2_鱗2.Hit = value;
			}
		}

		public bool 指_中指_鱗2_鱗3_表示
		{
			get
			{
				return this.X0Y0_指_中指_鱗2_鱗3.Dra;
			}
			set
			{
				this.X0Y0_指_中指_鱗2_鱗3.Dra = value;
				this.X0Y0_指_中指_鱗2_鱗3.Hit = value;
			}
		}

		public bool 指_中指_鱗2_鱗4_表示
		{
			get
			{
				return this.X0Y0_指_中指_鱗2_鱗4.Dra;
			}
			set
			{
				this.X0Y0_指_中指_鱗2_鱗4.Dra = value;
				this.X0Y0_指_中指_鱗2_鱗4.Hit = value;
			}
		}

		public bool 指_中指_鱗1_鱗1_表示
		{
			get
			{
				return this.X0Y0_指_中指_鱗1_鱗1.Dra;
			}
			set
			{
				this.X0Y0_指_中指_鱗1_鱗1.Dra = value;
				this.X0Y0_指_中指_鱗1_鱗1.Hit = value;
			}
		}

		public bool 指_中指_鱗1_鱗2_表示
		{
			get
			{
				return this.X0Y0_指_中指_鱗1_鱗2.Dra;
			}
			set
			{
				this.X0Y0_指_中指_鱗1_鱗2.Dra = value;
				this.X0Y0_指_中指_鱗1_鱗2.Hit = value;
			}
		}

		public bool 指_中指_鱗1_鱗3_表示
		{
			get
			{
				return this.X0Y0_指_中指_鱗1_鱗3.Dra;
			}
			set
			{
				this.X0Y0_指_中指_鱗1_鱗3.Dra = value;
				this.X0Y0_指_中指_鱗1_鱗3.Hit = value;
			}
		}

		public bool 指_中指_鱗1_鱗4_表示
		{
			get
			{
				return this.X0Y0_指_中指_鱗1_鱗4.Dra;
			}
			set
			{
				this.X0Y0_指_中指_鱗1_鱗4.Dra = value;
				this.X0Y0_指_中指_鱗1_鱗4.Hit = value;
			}
		}

		public bool 指_中指_鱗1_鱗5_表示
		{
			get
			{
				return this.X0Y0_指_中指_鱗1_鱗5.Dra;
			}
			set
			{
				this.X0Y0_指_中指_鱗1_鱗5.Dra = value;
				this.X0Y0_指_中指_鱗1_鱗5.Hit = value;
			}
		}

		public bool 指_中指_鱗1_鱗6_表示
		{
			get
			{
				return this.X0Y0_指_中指_鱗1_鱗6.Dra;
			}
			set
			{
				this.X0Y0_指_中指_鱗1_鱗6.Dra = value;
				this.X0Y0_指_中指_鱗1_鱗6.Hit = value;
			}
		}

		public bool 指_人指_爪_表示
		{
			get
			{
				return this.X0Y0_指_人指_爪.Dra;
			}
			set
			{
				this.X0Y0_指_人指_爪.Dra = value;
				this.X0Y0_指_人指_爪.Hit = value;
			}
		}

		public bool 指_人指_指3_表示
		{
			get
			{
				return this.X0Y0_指_人指_指3.Dra;
			}
			set
			{
				this.X0Y0_指_人指_指3.Dra = value;
				this.X0Y0_指_人指_指3.Hit = value;
			}
		}

		public bool 指_人指_指2_表示
		{
			get
			{
				return this.X0Y0_指_人指_指2.Dra;
			}
			set
			{
				this.X0Y0_指_人指_指2.Dra = value;
				this.X0Y0_指_人指_指2.Hit = value;
			}
		}

		public bool 指_人指_指1_表示
		{
			get
			{
				return this.X0Y0_指_人指_指1.Dra;
			}
			set
			{
				this.X0Y0_指_人指_指1.Dra = value;
				this.X0Y0_指_人指_指1.Hit = value;
			}
		}

		public bool 指_人指_鱗3_鱗1_表示
		{
			get
			{
				return this.X0Y0_指_人指_鱗3_鱗1.Dra;
			}
			set
			{
				this.X0Y0_指_人指_鱗3_鱗1.Dra = value;
				this.X0Y0_指_人指_鱗3_鱗1.Hit = value;
			}
		}

		public bool 指_人指_鱗3_鱗2_表示
		{
			get
			{
				return this.X0Y0_指_人指_鱗3_鱗2.Dra;
			}
			set
			{
				this.X0Y0_指_人指_鱗3_鱗2.Dra = value;
				this.X0Y0_指_人指_鱗3_鱗2.Hit = value;
			}
		}

		public bool 指_人指_鱗3_鱗3_表示
		{
			get
			{
				return this.X0Y0_指_人指_鱗3_鱗3.Dra;
			}
			set
			{
				this.X0Y0_指_人指_鱗3_鱗3.Dra = value;
				this.X0Y0_指_人指_鱗3_鱗3.Hit = value;
			}
		}

		public bool 指_人指_鱗3_鱗4_表示
		{
			get
			{
				return this.X0Y0_指_人指_鱗3_鱗4.Dra;
			}
			set
			{
				this.X0Y0_指_人指_鱗3_鱗4.Dra = value;
				this.X0Y0_指_人指_鱗3_鱗4.Hit = value;
			}
		}

		public bool 指_人指_鱗2_鱗1_表示
		{
			get
			{
				return this.X0Y0_指_人指_鱗2_鱗1.Dra;
			}
			set
			{
				this.X0Y0_指_人指_鱗2_鱗1.Dra = value;
				this.X0Y0_指_人指_鱗2_鱗1.Hit = value;
			}
		}

		public bool 指_人指_鱗2_鱗2_表示
		{
			get
			{
				return this.X0Y0_指_人指_鱗2_鱗2.Dra;
			}
			set
			{
				this.X0Y0_指_人指_鱗2_鱗2.Dra = value;
				this.X0Y0_指_人指_鱗2_鱗2.Hit = value;
			}
		}

		public bool 指_人指_鱗2_鱗3_表示
		{
			get
			{
				return this.X0Y0_指_人指_鱗2_鱗3.Dra;
			}
			set
			{
				this.X0Y0_指_人指_鱗2_鱗3.Dra = value;
				this.X0Y0_指_人指_鱗2_鱗3.Hit = value;
			}
		}

		public bool 指_人指_鱗2_鱗4_表示
		{
			get
			{
				return this.X0Y0_指_人指_鱗2_鱗4.Dra;
			}
			set
			{
				this.X0Y0_指_人指_鱗2_鱗4.Dra = value;
				this.X0Y0_指_人指_鱗2_鱗4.Hit = value;
			}
		}

		public bool 指_人指_鱗1_鱗1_表示
		{
			get
			{
				return this.X0Y0_指_人指_鱗1_鱗1.Dra;
			}
			set
			{
				this.X0Y0_指_人指_鱗1_鱗1.Dra = value;
				this.X0Y0_指_人指_鱗1_鱗1.Hit = value;
			}
		}

		public bool 指_人指_鱗1_鱗2_表示
		{
			get
			{
				return this.X0Y0_指_人指_鱗1_鱗2.Dra;
			}
			set
			{
				this.X0Y0_指_人指_鱗1_鱗2.Dra = value;
				this.X0Y0_指_人指_鱗1_鱗2.Hit = value;
			}
		}

		public bool 指_人指_鱗1_鱗3_表示
		{
			get
			{
				return this.X0Y0_指_人指_鱗1_鱗3.Dra;
			}
			set
			{
				this.X0Y0_指_人指_鱗1_鱗3.Dra = value;
				this.X0Y0_指_人指_鱗1_鱗3.Hit = value;
			}
		}

		public bool 指_人指_鱗1_鱗4_表示
		{
			get
			{
				return this.X0Y0_指_人指_鱗1_鱗4.Dra;
			}
			set
			{
				this.X0Y0_指_人指_鱗1_鱗4.Dra = value;
				this.X0Y0_指_人指_鱗1_鱗4.Hit = value;
			}
		}

		public bool 指_人指_鱗1_鱗5_表示
		{
			get
			{
				return this.X0Y0_指_人指_鱗1_鱗5.Dra;
			}
			set
			{
				this.X0Y0_指_人指_鱗1_鱗5.Dra = value;
				this.X0Y0_指_人指_鱗1_鱗5.Hit = value;
			}
		}

		public bool 指_人指_鱗1_鱗6_表示
		{
			get
			{
				return this.X0Y0_指_人指_鱗1_鱗6.Dra;
			}
			set
			{
				this.X0Y0_指_人指_鱗1_鱗6.Dra = value;
				this.X0Y0_指_人指_鱗1_鱗6.Hit = value;
			}
		}

		public bool 指_親指_爪_表示
		{
			get
			{
				return this.X0Y0_指_親指_爪.Dra;
			}
			set
			{
				this.X0Y0_指_親指_爪.Dra = value;
				this.X0Y0_指_親指_爪.Hit = value;
			}
		}

		public bool 指_親指_指2_表示
		{
			get
			{
				return this.X0Y0_指_親指_指2.Dra;
			}
			set
			{
				this.X0Y0_指_親指_指2.Dra = value;
				this.X0Y0_指_親指_指2.Hit = value;
			}
		}

		public bool 指_親指_指1_表示
		{
			get
			{
				return this.X0Y0_指_親指_指1.Dra;
			}
			set
			{
				this.X0Y0_指_親指_指1.Dra = value;
				this.X0Y0_指_親指_指1.Hit = value;
			}
		}

		public bool 指_親指_鱗2_鱗1_表示
		{
			get
			{
				return this.X0Y0_指_親指_鱗2_鱗1.Dra;
			}
			set
			{
				this.X0Y0_指_親指_鱗2_鱗1.Dra = value;
				this.X0Y0_指_親指_鱗2_鱗1.Hit = value;
			}
		}

		public bool 指_親指_鱗2_鱗2_表示
		{
			get
			{
				return this.X0Y0_指_親指_鱗2_鱗2.Dra;
			}
			set
			{
				this.X0Y0_指_親指_鱗2_鱗2.Dra = value;
				this.X0Y0_指_親指_鱗2_鱗2.Hit = value;
			}
		}

		public bool 指_親指_鱗2_鱗3_表示
		{
			get
			{
				return this.X0Y0_指_親指_鱗2_鱗3.Dra;
			}
			set
			{
				this.X0Y0_指_親指_鱗2_鱗3.Dra = value;
				this.X0Y0_指_親指_鱗2_鱗3.Hit = value;
			}
		}

		public bool 指_親指_鱗2_鱗4_表示
		{
			get
			{
				return this.X0Y0_指_親指_鱗2_鱗4.Dra;
			}
			set
			{
				this.X0Y0_指_親指_鱗2_鱗4.Dra = value;
				this.X0Y0_指_親指_鱗2_鱗4.Hit = value;
			}
		}

		public bool 指_親指_鱗1_鱗1_表示
		{
			get
			{
				return this.X0Y0_指_親指_鱗1_鱗1.Dra;
			}
			set
			{
				this.X0Y0_指_親指_鱗1_鱗1.Dra = value;
				this.X0Y0_指_親指_鱗1_鱗1.Hit = value;
			}
		}

		public bool 指_親指_鱗1_鱗2_表示
		{
			get
			{
				return this.X0Y0_指_親指_鱗1_鱗2.Dra;
			}
			set
			{
				this.X0Y0_指_親指_鱗1_鱗2.Dra = value;
				this.X0Y0_指_親指_鱗1_鱗2.Hit = value;
			}
		}

		public bool 指_親指_鱗1_鱗3_表示
		{
			get
			{
				return this.X0Y0_指_親指_鱗1_鱗3.Dra;
			}
			set
			{
				this.X0Y0_指_親指_鱗1_鱗3.Dra = value;
				this.X0Y0_指_親指_鱗1_鱗3.Hit = value;
			}
		}

		public bool 指_親指_鱗1_鱗4_表示
		{
			get
			{
				return this.X0Y0_指_親指_鱗1_鱗4.Dra;
			}
			set
			{
				this.X0Y0_指_親指_鱗1_鱗4.Dra = value;
				this.X0Y0_指_親指_鱗1_鱗4.Hit = value;
			}
		}

		public bool 指_親指_鱗1_鱗5_表示
		{
			get
			{
				return this.X0Y0_指_親指_鱗1_鱗5.Dra;
			}
			set
			{
				this.X0Y0_指_親指_鱗1_鱗5.Dra = value;
				this.X0Y0_指_親指_鱗1_鱗5.Hit = value;
			}
		}

		public bool 指_親指_鱗1_鱗6_表示
		{
			get
			{
				return this.X0Y0_指_親指_鱗1_鱗6.Dra;
			}
			set
			{
				this.X0Y0_指_親指_鱗1_鱗6.Dra = value;
				this.X0Y0_指_親指_鱗1_鱗6.Hit = value;
			}
		}

		public bool 指_表示
		{
			get
			{
				return this.指_中指_爪_表示;
			}
			set
			{
				this.指_中指_爪_表示 = value;
				this.指_中指_指3_表示 = value;
				this.指_中指_指2_表示 = value;
				this.指_中指_指1_表示 = value;
				this.指_中指_鱗3_鱗1_表示 = value;
				this.指_中指_鱗3_鱗2_表示 = value;
				this.指_中指_鱗3_鱗3_表示 = value;
				this.指_中指_鱗3_鱗4_表示 = value;
				this.指_中指_鱗2_鱗1_表示 = value;
				this.指_中指_鱗2_鱗2_表示 = value;
				this.指_中指_鱗2_鱗3_表示 = value;
				this.指_中指_鱗2_鱗4_表示 = value;
				this.指_中指_鱗1_鱗1_表示 = value;
				this.指_中指_鱗1_鱗2_表示 = value;
				this.指_中指_鱗1_鱗3_表示 = value;
				this.指_中指_鱗1_鱗4_表示 = value;
				this.指_中指_鱗1_鱗5_表示 = value;
				this.指_中指_鱗1_鱗6_表示 = value;
				this.指_人指_爪_表示 = value;
				this.指_人指_指3_表示 = value;
				this.指_人指_指2_表示 = value;
				this.指_人指_指1_表示 = value;
				this.指_人指_鱗3_鱗1_表示 = value;
				this.指_人指_鱗3_鱗2_表示 = value;
				this.指_人指_鱗3_鱗3_表示 = value;
				this.指_人指_鱗3_鱗4_表示 = value;
				this.指_人指_鱗2_鱗1_表示 = value;
				this.指_人指_鱗2_鱗2_表示 = value;
				this.指_人指_鱗2_鱗3_表示 = value;
				this.指_人指_鱗2_鱗4_表示 = value;
				this.指_人指_鱗1_鱗1_表示 = value;
				this.指_人指_鱗1_鱗2_表示 = value;
				this.指_人指_鱗1_鱗3_表示 = value;
				this.指_人指_鱗1_鱗4_表示 = value;
				this.指_人指_鱗1_鱗5_表示 = value;
				this.指_人指_鱗1_鱗6_表示 = value;
				this.指_親指_爪_表示 = value;
				this.指_親指_指2_表示 = value;
				this.指_親指_指1_表示 = value;
				this.指_親指_鱗2_鱗1_表示 = value;
				this.指_親指_鱗2_鱗2_表示 = value;
				this.指_親指_鱗2_鱗3_表示 = value;
				this.指_親指_鱗2_鱗4_表示 = value;
				this.指_親指_鱗1_鱗1_表示 = value;
				this.指_親指_鱗1_鱗2_表示 = value;
				this.指_親指_鱗1_鱗3_表示 = value;
				this.指_親指_鱗1_鱗4_表示 = value;
				this.指_親指_鱗1_鱗5_表示 = value;
				this.指_親指_鱗1_鱗6_表示 = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.鳥翼手_表示;
			}
			set
			{
				this.鳥翼手_表示 = value;
				this.風切羽_羽10_表示 = value;
				this.風切羽_羽9_表示 = value;
				this.風切羽_羽8_表示 = value;
				this.風切羽_羽7_表示 = value;
				this.風切羽_羽6_表示 = value;
				this.風切羽_羽5_表示 = value;
				this.風切羽_羽4_表示 = value;
				this.風切羽_羽3_表示 = value;
				this.風切羽_羽2_表示 = value;
				this.風切羽_羽1_表示 = value;
				this.雨覆羽_羽10_表示 = value;
				this.雨覆羽_羽9_表示 = value;
				this.雨覆羽_羽8_表示 = value;
				this.雨覆羽_羽7_表示 = value;
				this.雨覆羽_羽6_表示 = value;
				this.雨覆羽_羽5_表示 = value;
				this.雨覆羽_羽4_表示 = value;
				this.雨覆羽_羽3_表示 = value;
				this.雨覆羽_羽2_表示 = value;
				this.雨覆羽_羽1_表示 = value;
				this.小翼羽_羽3_表示 = value;
				this.小翼羽_羽2_表示 = value;
				this.小翼羽_羽1_表示 = value;
				this.指_中指_爪_表示 = value;
				this.指_中指_指3_表示 = value;
				this.指_中指_指2_表示 = value;
				this.指_中指_指1_表示 = value;
				this.指_中指_鱗3_鱗1_表示 = value;
				this.指_中指_鱗3_鱗2_表示 = value;
				this.指_中指_鱗3_鱗3_表示 = value;
				this.指_中指_鱗3_鱗4_表示 = value;
				this.指_中指_鱗2_鱗1_表示 = value;
				this.指_中指_鱗2_鱗2_表示 = value;
				this.指_中指_鱗2_鱗3_表示 = value;
				this.指_中指_鱗2_鱗4_表示 = value;
				this.指_中指_鱗1_鱗1_表示 = value;
				this.指_中指_鱗1_鱗2_表示 = value;
				this.指_中指_鱗1_鱗3_表示 = value;
				this.指_中指_鱗1_鱗4_表示 = value;
				this.指_中指_鱗1_鱗5_表示 = value;
				this.指_中指_鱗1_鱗6_表示 = value;
				this.指_人指_爪_表示 = value;
				this.指_人指_指3_表示 = value;
				this.指_人指_指2_表示 = value;
				this.指_人指_指1_表示 = value;
				this.指_人指_鱗3_鱗1_表示 = value;
				this.指_人指_鱗3_鱗2_表示 = value;
				this.指_人指_鱗3_鱗3_表示 = value;
				this.指_人指_鱗3_鱗4_表示 = value;
				this.指_人指_鱗2_鱗1_表示 = value;
				this.指_人指_鱗2_鱗2_表示 = value;
				this.指_人指_鱗2_鱗3_表示 = value;
				this.指_人指_鱗2_鱗4_表示 = value;
				this.指_人指_鱗1_鱗1_表示 = value;
				this.指_人指_鱗1_鱗2_表示 = value;
				this.指_人指_鱗1_鱗3_表示 = value;
				this.指_人指_鱗1_鱗4_表示 = value;
				this.指_人指_鱗1_鱗5_表示 = value;
				this.指_人指_鱗1_鱗6_表示 = value;
				this.指_親指_爪_表示 = value;
				this.指_親指_指2_表示 = value;
				this.指_親指_指1_表示 = value;
				this.指_親指_鱗2_鱗1_表示 = value;
				this.指_親指_鱗2_鱗2_表示 = value;
				this.指_親指_鱗2_鱗3_表示 = value;
				this.指_親指_鱗2_鱗4_表示 = value;
				this.指_親指_鱗1_鱗1_表示 = value;
				this.指_親指_鱗1_鱗2_表示 = value;
				this.指_親指_鱗1_鱗3_表示 = value;
				this.指_親指_鱗1_鱗4_表示 = value;
				this.指_親指_鱗1_鱗5_表示 = value;
				this.指_親指_鱗1_鱗6_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.鳥翼手CD.不透明度;
			}
			set
			{
				this.鳥翼手CD.不透明度 = value;
				this.風切羽_羽10CD.不透明度 = value;
				this.風切羽_羽9CD.不透明度 = value;
				this.風切羽_羽8CD.不透明度 = value;
				this.風切羽_羽7CD.不透明度 = value;
				this.風切羽_羽6CD.不透明度 = value;
				this.風切羽_羽5CD.不透明度 = value;
				this.風切羽_羽4CD.不透明度 = value;
				this.風切羽_羽3CD.不透明度 = value;
				this.風切羽_羽2CD.不透明度 = value;
				this.風切羽_羽1CD.不透明度 = value;
				this.雨覆羽_羽10CD.不透明度 = value;
				this.雨覆羽_羽9CD.不透明度 = value;
				this.雨覆羽_羽8CD.不透明度 = value;
				this.雨覆羽_羽7CD.不透明度 = value;
				this.雨覆羽_羽6CD.不透明度 = value;
				this.雨覆羽_羽5CD.不透明度 = value;
				this.雨覆羽_羽4CD.不透明度 = value;
				this.雨覆羽_羽3CD.不透明度 = value;
				this.雨覆羽_羽2CD.不透明度 = value;
				this.雨覆羽_羽1CD.不透明度 = value;
				this.小翼羽_羽3CD.不透明度 = value;
				this.小翼羽_羽2CD.不透明度 = value;
				this.小翼羽_羽1CD.不透明度 = value;
				this.指_中指_爪CD.不透明度 = value;
				this.指_中指_指3CD.不透明度 = value;
				this.指_中指_指2CD.不透明度 = value;
				this.指_中指_指1CD.不透明度 = value;
				this.指_中指_鱗3_鱗1CD.不透明度 = value;
				this.指_中指_鱗3_鱗2CD.不透明度 = value;
				this.指_中指_鱗3_鱗3CD.不透明度 = value;
				this.指_中指_鱗3_鱗4CD.不透明度 = value;
				this.指_中指_鱗2_鱗1CD.不透明度 = value;
				this.指_中指_鱗2_鱗2CD.不透明度 = value;
				this.指_中指_鱗2_鱗3CD.不透明度 = value;
				this.指_中指_鱗2_鱗4CD.不透明度 = value;
				this.指_中指_鱗1_鱗1CD.不透明度 = value;
				this.指_中指_鱗1_鱗2CD.不透明度 = value;
				this.指_中指_鱗1_鱗3CD.不透明度 = value;
				this.指_中指_鱗1_鱗4CD.不透明度 = value;
				this.指_中指_鱗1_鱗5CD.不透明度 = value;
				this.指_中指_鱗1_鱗6CD.不透明度 = value;
				this.指_人指_爪CD.不透明度 = value;
				this.指_人指_指3CD.不透明度 = value;
				this.指_人指_指2CD.不透明度 = value;
				this.指_人指_指1CD.不透明度 = value;
				this.指_人指_鱗3_鱗1CD.不透明度 = value;
				this.指_人指_鱗3_鱗2CD.不透明度 = value;
				this.指_人指_鱗3_鱗3CD.不透明度 = value;
				this.指_人指_鱗3_鱗4CD.不透明度 = value;
				this.指_人指_鱗2_鱗1CD.不透明度 = value;
				this.指_人指_鱗2_鱗2CD.不透明度 = value;
				this.指_人指_鱗2_鱗3CD.不透明度 = value;
				this.指_人指_鱗2_鱗4CD.不透明度 = value;
				this.指_人指_鱗1_鱗1CD.不透明度 = value;
				this.指_人指_鱗1_鱗2CD.不透明度 = value;
				this.指_人指_鱗1_鱗3CD.不透明度 = value;
				this.指_人指_鱗1_鱗4CD.不透明度 = value;
				this.指_人指_鱗1_鱗5CD.不透明度 = value;
				this.指_人指_鱗1_鱗6CD.不透明度 = value;
				this.指_親指_爪CD.不透明度 = value;
				this.指_親指_指2CD.不透明度 = value;
				this.指_親指_指1CD.不透明度 = value;
				this.指_親指_鱗2_鱗1CD.不透明度 = value;
				this.指_親指_鱗2_鱗2CD.不透明度 = value;
				this.指_親指_鱗2_鱗3CD.不透明度 = value;
				this.指_親指_鱗2_鱗4CD.不透明度 = value;
				this.指_親指_鱗1_鱗1CD.不透明度 = value;
				this.指_親指_鱗1_鱗2CD.不透明度 = value;
				this.指_親指_鱗1_鱗3CD.不透明度 = value;
				this.指_親指_鱗1_鱗4CD.不透明度 = value;
				this.指_親指_鱗1_鱗5CD.不透明度 = value;
				this.指_親指_鱗1_鱗6CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			double num = this.右 ? -1.0 : 1.0;
			this.X0Y0_鳥翼手.AngleBase = num * -1.13686837721616E-13;
			this.X0Y0_風切羽_羽1.AngleBase = num * 4.30625920538989;
			this.X0Y0_風切羽_羽2.AngleBase = num * -3.79947296841442;
			this.X0Y0_風切羽_羽3.AngleBase = num * -11.0737082094246;
			this.X0Y0_風切羽_羽4.AngleBase = num * -18.5456655123347;
			this.X0Y0_風切羽_羽5.AngleBase = num * 333.756058186057;
			this.X0Y0_風切羽_羽6.AngleBase = num * 325.804892219803;
			this.X0Y0_風切羽_羽7.AngleBase = num * 317.578381763761;
			this.X0Y0_風切羽_羽8.AngleBase = num * 309.061028607936;
			this.X0Y0_風切羽_羽9.AngleBase = num * 300.247790167872;
			this.X0Y0_風切羽_羽10.AngleBase = num * 292.147867426599;
			this.X0Y0_雨覆羽_羽1.AngleBase = num * 10.5625779442967;
			this.X0Y0_雨覆羽_羽2.AngleBase = num * -0.983004946517724;
			this.X0Y0_雨覆羽_羽3.AngleBase = num * -11.3484562079468;
			this.X0Y0_雨覆羽_羽4.AngleBase = num * 337.795626900816;
			this.X0Y0_雨覆羽_羽5.AngleBase = num * 326.621692120892;
			this.X0Y0_雨覆羽_羽6.AngleBase = num * 315.356571907051;
			this.X0Y0_雨覆羽_羽7.AngleBase = num * 305.230065535076;
			this.X0Y0_雨覆羽_羽8.AngleBase = num * 294.429103024235;
			this.X0Y0_雨覆羽_羽9.AngleBase = num * 284.068635208099;
			this.X0Y0_雨覆羽_羽10.AngleBase = num * 277.113742476644;
			this.X0Y0_小翼羽_羽1.AngleBase = num * 9.19256790991403;
			this.X0Y0_小翼羽_羽2.AngleBase = num * -8.26267299324587;
			this.X0Y0_小翼羽_羽3.AngleBase = num * 335.232034316903;
			this.X0Y0_指_中指_指1.AngleBase = num * -4.0000000000001;
			this.X0Y0_指_中指_指2.AngleBase = num * 350.0;
			this.X0Y0_指_中指_指3.AngleBase = num * 4.00000000000011;
			this.X0Y0_指_人指_指1.AngleBase = num * 9.99999999999989;
			this.X0Y0_指_人指_指2.AngleBase = num * -9.0;
			this.X0Y0_指_人指_指3.AngleBase = num * 4.00000000000006;
			this.X0Y0_指_親指_指1.AngleBase = num * 399.0;
			this.X0Y0_指_親指_指2.AngleBase = num * -7.0;
			this.本体.JoinPAall();
		}

		public override double 展開
		{
			set
			{
				double num = value.Inverse();
				double num2 = this.右 ? -1.0 : 1.0;
				this.X0Y0_鳥翼手.AngleCont = num2 * -170.0 * num;
				this.X0Y0_風切羽_羽1.AngleCont = num2 * 12.0 * num;
				this.X0Y0_風切羽_羽2.AngleCont = num2 * 17.8 * num;
				this.X0Y0_風切羽_羽3.AngleCont = num2 * 23.6 * num;
				this.X0Y0_風切羽_羽4.AngleCont = num2 * 29.4 * num;
				this.X0Y0_風切羽_羽5.AngleCont = num2 * 35.2 * num;
				this.X0Y0_風切羽_羽6.AngleCont = num2 * 41.0 * num;
				this.X0Y0_風切羽_羽7.AngleCont = num2 * 46.8 * num;
				this.X0Y0_風切羽_羽8.AngleCont = num2 * 52.6 * num;
				this.X0Y0_風切羽_羽9.AngleCont = num2 * 58.4 * num;
				this.X0Y0_風切羽_羽10.AngleCont = num2 * 64.2 * num;
				this.X0Y0_雨覆羽_羽1.AngleCont = num2 * 7.0 * num;
				this.X0Y0_雨覆羽_羽2.AngleCont = num2 * 13.8 * num;
				this.X0Y0_雨覆羽_羽3.AngleCont = num2 * 20.6 * num;
				this.X0Y0_雨覆羽_羽4.AngleCont = num2 * 27.4 * num;
				this.X0Y0_雨覆羽_羽5.AngleCont = num2 * 34.2 * num;
				this.X0Y0_雨覆羽_羽6.AngleCont = num2 * 41.0 * num;
				this.X0Y0_雨覆羽_羽7.AngleCont = num2 * 47.8 * num;
				this.X0Y0_雨覆羽_羽8.AngleCont = num2 * 54.6 * num;
				this.X0Y0_雨覆羽_羽9.AngleCont = num2 * 61.4 * num;
				this.X0Y0_雨覆羽_羽10.AngleCont = num2 * 68.2 * num;
				this.X0Y0_小翼羽_羽1.AngleCont = num2 * 0.0 * num;
				this.X0Y0_小翼羽_羽2.AngleCont = num2 * 11.6666666666667 * num;
				this.X0Y0_小翼羽_羽3.AngleCont = num2 * 23.3333333333333 * num;
				this.X0Y0_指_中指_指1.AngleCont = num2 * 20.0 * num;
				this.X0Y0_指_中指_指2.AngleCont = num2 * 0.0 * num;
				this.X0Y0_指_中指_指3.AngleCont = num2 * 0.0 * num;
				this.X0Y0_指_人指_指1.AngleCont = num2 * 20.0 * num;
				this.X0Y0_指_人指_指2.AngleCont = num2 * 0.0 * num;
				this.X0Y0_指_人指_指3.AngleCont = num2 * 0.0 * num;
				this.X0Y0_指_親指_指1.AngleCont = num2 * 20.0 * num;
				this.X0Y0_指_親指_指2.AngleCont = num2 * 0.0 * num;
			}
		}

		public double シャ\u30FCプ
		{
			set
			{
				double num = 0.7;
				this.X0Y0_風切羽_羽10.SizeXBase *= 1.0 - 0.09 * num * value;
				this.X0Y0_風切羽_羽9.SizeXBase *= 1.0 - 0.08 * num * value;
				this.X0Y0_風切羽_羽8.SizeXBase *= 1.0 - 0.06 * num * value;
				this.X0Y0_風切羽_羽7.SizeXBase *= 1.0 - 0.05 * num * value;
				this.X0Y0_風切羽_羽6.SizeXBase *= 1.0 - 0.04 * num * value;
				this.X0Y0_風切羽_羽5.SizeXBase *= 1.0 - 0.026 * num * value;
				this.X0Y0_風切羽_羽4.SizeXBase *= 1.0 + 0.0125 * num * value;
				this.X0Y0_風切羽_羽3.SizeXBase *= 1.0 + 0.075 * num * value;
				this.X0Y0_風切羽_羽2.SizeXBase *= 1.0 + 0.2 * num * value;
				this.X0Y0_風切羽_羽1.SizeXBase *= 1.0 + 0.5 * num * value;
			}
		}

		public bool 手_外線
		{
			get
			{
				return this.X0Y0_鳥翼手.OP[this.右 ? 1 : 1].Outline;
			}
			set
			{
				this.X0Y0_鳥翼手.OP[this.右 ? 1 : 1].Outline = value;
				this.X0Y0_鳥翼手.OP[this.右 ? 0 : 2].Outline = value;
			}
		}

		public bool 小翼羽_羽1_外線
		{
			get
			{
				return this.X0Y0_小翼羽_羽1.OP[this.右 ? 1 : 3].Outline;
			}
			set
			{
				this.X0Y0_小翼羽_羽1.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_小翼羽_羽1.OP[this.右 ? 0 : 4].Outline = value;
			}
		}

		public bool 小翼羽_羽2_外線
		{
			get
			{
				return this.X0Y0_小翼羽_羽2.OP[this.右 ? 4 : 0].Outline;
			}
			set
			{
				this.X0Y0_小翼羽_羽2.OP[this.右 ? 4 : 0].Outline = value;
				this.X0Y0_小翼羽_羽2.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_小翼羽_羽2.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_小翼羽_羽2.OP[this.右 ? 0 : 4].Outline = value;
			}
		}

		public bool 小翼羽_羽3_外線
		{
			get
			{
				return this.X0Y0_小翼羽_羽3.OP[this.右 ? 4 : 0].Outline;
			}
			set
			{
				this.X0Y0_小翼羽_羽3.OP[this.右 ? 4 : 0].Outline = value;
				this.X0Y0_小翼羽_羽3.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_小翼羽_羽3.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_小翼羽_羽3.OP[this.右 ? 0 : 4].Outline = value;
			}
		}

		public bool 雨覆羽_羽1_外線
		{
			get
			{
				return this.X0Y0_雨覆羽_羽1.OP[this.右 ? 2 : 2].Outline;
			}
			set
			{
				this.X0Y0_雨覆羽_羽1.OP[this.右 ? 2 : 2].Outline = value;
				this.X0Y0_雨覆羽_羽1.OP[this.右 ? 1 : 3].Outline = value;
			}
		}

		public bool 雨覆羽_羽2_外線
		{
			get
			{
				return this.X0Y0_雨覆羽_羽2.OP[this.右 ? 4 : 0].Outline;
			}
			set
			{
				this.X0Y0_雨覆羽_羽2.OP[this.右 ? 4 : 0].Outline = value;
				this.X0Y0_雨覆羽_羽2.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_雨覆羽_羽2.OP[this.右 ? 2 : 2].Outline = value;
				this.X0Y0_雨覆羽_羽2.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_雨覆羽_羽2.OP[this.右 ? 0 : 4].Outline = value;
			}
		}

		public bool 雨覆羽_羽3_外線
		{
			get
			{
				return this.X0Y0_雨覆羽_羽3.OP[this.右 ? 4 : 0].Outline;
			}
			set
			{
				this.X0Y0_雨覆羽_羽3.OP[this.右 ? 4 : 0].Outline = value;
				this.X0Y0_雨覆羽_羽3.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_雨覆羽_羽3.OP[this.右 ? 2 : 2].Outline = value;
				this.X0Y0_雨覆羽_羽3.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_雨覆羽_羽3.OP[this.右 ? 0 : 4].Outline = value;
			}
		}

		public bool 雨覆羽_羽4_外線
		{
			get
			{
				return this.X0Y0_雨覆羽_羽4.OP[this.右 ? 4 : 0].Outline;
			}
			set
			{
				this.X0Y0_雨覆羽_羽4.OP[this.右 ? 4 : 0].Outline = value;
				this.X0Y0_雨覆羽_羽4.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_雨覆羽_羽4.OP[this.右 ? 2 : 2].Outline = value;
				this.X0Y0_雨覆羽_羽4.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_雨覆羽_羽4.OP[this.右 ? 0 : 4].Outline = value;
			}
		}

		public bool 雨覆羽_羽5_外線
		{
			get
			{
				return this.X0Y0_雨覆羽_羽5.OP[this.右 ? 4 : 0].Outline;
			}
			set
			{
				this.X0Y0_雨覆羽_羽5.OP[this.右 ? 4 : 0].Outline = value;
				this.X0Y0_雨覆羽_羽5.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_雨覆羽_羽5.OP[this.右 ? 2 : 2].Outline = value;
				this.X0Y0_雨覆羽_羽5.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_雨覆羽_羽5.OP[this.右 ? 0 : 4].Outline = value;
			}
		}

		public bool 雨覆羽_羽6_外線
		{
			get
			{
				return this.X0Y0_雨覆羽_羽6.OP[this.右 ? 4 : 0].Outline;
			}
			set
			{
				this.X0Y0_雨覆羽_羽6.OP[this.右 ? 4 : 0].Outline = value;
				this.X0Y0_雨覆羽_羽6.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_雨覆羽_羽6.OP[this.右 ? 2 : 2].Outline = value;
				this.X0Y0_雨覆羽_羽6.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_雨覆羽_羽6.OP[this.右 ? 0 : 4].Outline = value;
			}
		}

		public bool 雨覆羽_羽7_外線
		{
			get
			{
				return this.X0Y0_雨覆羽_羽7.OP[this.右 ? 4 : 0].Outline;
			}
			set
			{
				this.X0Y0_雨覆羽_羽7.OP[this.右 ? 4 : 0].Outline = value;
				this.X0Y0_雨覆羽_羽7.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_雨覆羽_羽7.OP[this.右 ? 2 : 2].Outline = value;
				this.X0Y0_雨覆羽_羽7.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_雨覆羽_羽7.OP[this.右 ? 0 : 4].Outline = value;
			}
		}

		public bool 雨覆羽_羽8_外線
		{
			get
			{
				return this.X0Y0_雨覆羽_羽8.OP[this.右 ? 4 : 0].Outline;
			}
			set
			{
				this.X0Y0_雨覆羽_羽8.OP[this.右 ? 4 : 0].Outline = value;
				this.X0Y0_雨覆羽_羽8.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_雨覆羽_羽8.OP[this.右 ? 2 : 2].Outline = value;
				this.X0Y0_雨覆羽_羽8.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_雨覆羽_羽8.OP[this.右 ? 0 : 4].Outline = value;
			}
		}

		public bool 雨覆羽_羽9_外線
		{
			get
			{
				return this.X0Y0_雨覆羽_羽9.OP[this.右 ? 4 : 0].Outline;
			}
			set
			{
				this.X0Y0_雨覆羽_羽9.OP[this.右 ? 4 : 0].Outline = value;
				this.X0Y0_雨覆羽_羽9.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_雨覆羽_羽9.OP[this.右 ? 2 : 2].Outline = value;
				this.X0Y0_雨覆羽_羽9.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_雨覆羽_羽9.OP[this.右 ? 0 : 4].Outline = value;
			}
		}

		public bool 雨覆羽_羽10_外線
		{
			get
			{
				return this.X0Y0_雨覆羽_羽10.OP[this.右 ? 4 : 0].Outline;
			}
			set
			{
				this.X0Y0_雨覆羽_羽10.OP[this.右 ? 4 : 0].Outline = value;
				this.X0Y0_雨覆羽_羽10.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_雨覆羽_羽10.OP[this.右 ? 2 : 2].Outline = value;
				this.X0Y0_雨覆羽_羽10.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_雨覆羽_羽10.OP[this.右 ? 0 : 4].Outline = value;
			}
		}

		public bool 風切羽_羽1_外線
		{
			get
			{
				return this.X0Y0_風切羽_羽1.OP[this.右 ? 2 : 2].Outline;
			}
			set
			{
				this.X0Y0_風切羽_羽1.OP[this.右 ? 2 : 2].Outline = value;
				this.X0Y0_風切羽_羽1.OP[this.右 ? 1 : 3].Outline = value;
			}
		}

		public bool 風切羽_羽2_外線
		{
			get
			{
				return this.X0Y0_風切羽_羽2.OP[this.右 ? 2 : 2].Outline;
			}
			set
			{
				this.X0Y0_風切羽_羽2.OP[this.右 ? 2 : 2].Outline = value;
				this.X0Y0_風切羽_羽2.OP[this.右 ? 1 : 3].Outline = value;
			}
		}

		public bool 風切羽_羽3_外線
		{
			get
			{
				return this.X0Y0_風切羽_羽3.OP[this.右 ? 2 : 2].Outline;
			}
			set
			{
				this.X0Y0_風切羽_羽3.OP[this.右 ? 2 : 2].Outline = value;
				this.X0Y0_風切羽_羽3.OP[this.右 ? 1 : 3].Outline = value;
			}
		}

		public bool 風切羽_羽4_外線
		{
			get
			{
				return this.X0Y0_風切羽_羽4.OP[this.右 ? 3 : 1].Outline;
			}
			set
			{
				this.X0Y0_風切羽_羽4.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_風切羽_羽4.OP[this.右 ? 2 : 2].Outline = value;
				this.X0Y0_風切羽_羽4.OP[this.右 ? 1 : 3].Outline = value;
			}
		}

		public bool 風切羽_羽5_外線
		{
			get
			{
				return this.X0Y0_風切羽_羽5.OP[this.右 ? 3 : 1].Outline;
			}
			set
			{
				this.X0Y0_風切羽_羽5.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_風切羽_羽5.OP[this.右 ? 2 : 2].Outline = value;
				this.X0Y0_風切羽_羽5.OP[this.右 ? 1 : 3].Outline = value;
			}
		}

		public bool 風切羽_羽6_外線
		{
			get
			{
				return this.X0Y0_風切羽_羽6.OP[this.右 ? 3 : 1].Outline;
			}
			set
			{
				this.X0Y0_風切羽_羽6.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_風切羽_羽6.OP[this.右 ? 2 : 2].Outline = value;
				this.X0Y0_風切羽_羽6.OP[this.右 ? 1 : 3].Outline = value;
			}
		}

		public bool 風切羽_羽7_外線
		{
			get
			{
				return this.X0Y0_風切羽_羽7.OP[this.右 ? 3 : 1].Outline;
			}
			set
			{
				this.X0Y0_風切羽_羽7.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_風切羽_羽7.OP[this.右 ? 2 : 2].Outline = value;
				this.X0Y0_風切羽_羽7.OP[this.右 ? 1 : 3].Outline = value;
			}
		}

		public bool 風切羽_羽8_外線
		{
			get
			{
				return this.X0Y0_風切羽_羽8.OP[this.右 ? 3 : 1].Outline;
			}
			set
			{
				this.X0Y0_風切羽_羽8.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_風切羽_羽8.OP[this.右 ? 2 : 2].Outline = value;
				this.X0Y0_風切羽_羽8.OP[this.右 ? 1 : 3].Outline = value;
			}
		}

		public bool 風切羽_羽9_外線
		{
			get
			{
				return this.X0Y0_風切羽_羽9.OP[this.右 ? 3 : 1].Outline;
			}
			set
			{
				this.X0Y0_風切羽_羽9.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_風切羽_羽9.OP[this.右 ? 2 : 2].Outline = value;
				this.X0Y0_風切羽_羽9.OP[this.右 ? 1 : 3].Outline = value;
			}
		}

		public bool 風切羽_羽10_外線
		{
			get
			{
				return this.X0Y0_風切羽_羽10.OP[this.右 ? 3 : 1].Outline;
			}
			set
			{
				this.X0Y0_風切羽_羽10.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_風切羽_羽10.OP[this.右 ? 2 : 2].Outline = value;
				this.X0Y0_風切羽_羽10.OP[this.右 ? 1 : 3].Outline = value;
			}
		}

		public override void 描画0(Are Are)
		{
			Are.Draw(this.X0Y0_鳥翼手);
			Are.Draw(this.X0Y0_風切羽_羽10);
			Are.Draw(this.X0Y0_風切羽_羽9);
			Are.Draw(this.X0Y0_風切羽_羽8);
			Are.Draw(this.X0Y0_風切羽_羽7);
			Are.Draw(this.X0Y0_風切羽_羽6);
			Are.Draw(this.X0Y0_風切羽_羽5);
			Are.Draw(this.X0Y0_風切羽_羽4);
			Are.Draw(this.X0Y0_風切羽_羽3);
			Are.Draw(this.X0Y0_風切羽_羽2);
			Are.Draw(this.X0Y0_風切羽_羽1);
			Are.Draw(this.X0Y0_雨覆羽_羽10);
			Are.Draw(this.X0Y0_雨覆羽_羽9);
			Are.Draw(this.X0Y0_雨覆羽_羽8);
			Are.Draw(this.X0Y0_雨覆羽_羽7);
			Are.Draw(this.X0Y0_雨覆羽_羽6);
			Are.Draw(this.X0Y0_雨覆羽_羽5);
			Are.Draw(this.X0Y0_雨覆羽_羽4);
			Are.Draw(this.X0Y0_雨覆羽_羽3);
			Are.Draw(this.X0Y0_雨覆羽_羽2);
			Are.Draw(this.X0Y0_雨覆羽_羽1);
			Are.Draw(this.X0Y0_小翼羽_羽3);
			Are.Draw(this.X0Y0_小翼羽_羽2);
			Are.Draw(this.X0Y0_小翼羽_羽1);
			Are.Draw(this.X0Y0_指_中指_爪);
			Are.Draw(this.X0Y0_指_中指_指3);
			Are.Draw(this.X0Y0_指_中指_指2);
			Are.Draw(this.X0Y0_指_中指_指1);
			Are.Draw(this.X0Y0_指_中指_鱗3_鱗1);
			Are.Draw(this.X0Y0_指_中指_鱗3_鱗2);
			Are.Draw(this.X0Y0_指_中指_鱗3_鱗3);
			Are.Draw(this.X0Y0_指_中指_鱗3_鱗4);
			Are.Draw(this.X0Y0_指_中指_鱗2_鱗1);
			Are.Draw(this.X0Y0_指_中指_鱗2_鱗2);
			Are.Draw(this.X0Y0_指_中指_鱗2_鱗3);
			Are.Draw(this.X0Y0_指_中指_鱗2_鱗4);
			Are.Draw(this.X0Y0_指_中指_鱗1_鱗1);
			Are.Draw(this.X0Y0_指_中指_鱗1_鱗2);
			Are.Draw(this.X0Y0_指_中指_鱗1_鱗3);
			Are.Draw(this.X0Y0_指_中指_鱗1_鱗4);
			Are.Draw(this.X0Y0_指_中指_鱗1_鱗5);
			Are.Draw(this.X0Y0_指_中指_鱗1_鱗6);
			Are.Draw(this.X0Y0_指_人指_爪);
			Are.Draw(this.X0Y0_指_人指_指3);
			Are.Draw(this.X0Y0_指_人指_指2);
			Are.Draw(this.X0Y0_指_人指_指1);
			Are.Draw(this.X0Y0_指_人指_鱗3_鱗1);
			Are.Draw(this.X0Y0_指_人指_鱗3_鱗2);
			Are.Draw(this.X0Y0_指_人指_鱗3_鱗3);
			Are.Draw(this.X0Y0_指_人指_鱗3_鱗4);
			Are.Draw(this.X0Y0_指_人指_鱗2_鱗1);
			Are.Draw(this.X0Y0_指_人指_鱗2_鱗2);
			Are.Draw(this.X0Y0_指_人指_鱗2_鱗3);
			Are.Draw(this.X0Y0_指_人指_鱗2_鱗4);
			Are.Draw(this.X0Y0_指_人指_鱗1_鱗1);
			Are.Draw(this.X0Y0_指_人指_鱗1_鱗2);
			Are.Draw(this.X0Y0_指_人指_鱗1_鱗3);
			Are.Draw(this.X0Y0_指_人指_鱗1_鱗4);
			Are.Draw(this.X0Y0_指_人指_鱗1_鱗5);
			Are.Draw(this.X0Y0_指_人指_鱗1_鱗6);
			Are.Draw(this.X0Y0_指_親指_爪);
			Are.Draw(this.X0Y0_指_親指_指2);
			Are.Draw(this.X0Y0_指_親指_指1);
			Are.Draw(this.X0Y0_指_親指_鱗2_鱗1);
			Are.Draw(this.X0Y0_指_親指_鱗2_鱗2);
			Are.Draw(this.X0Y0_指_親指_鱗2_鱗3);
			Are.Draw(this.X0Y0_指_親指_鱗2_鱗4);
			Are.Draw(this.X0Y0_指_親指_鱗1_鱗1);
			Are.Draw(this.X0Y0_指_親指_鱗1_鱗2);
			Are.Draw(this.X0Y0_指_親指_鱗1_鱗3);
			Are.Draw(this.X0Y0_指_親指_鱗1_鱗4);
			Are.Draw(this.X0Y0_指_親指_鱗1_鱗5);
			Are.Draw(this.X0Y0_指_親指_鱗1_鱗6);
		}

		public override void 色更新()
		{
			this.X0Y0_鳥翼手CP.Update();
			this.X0Y0_風切羽_羽10CP.Update();
			this.X0Y0_風切羽_羽9CP.Update();
			this.X0Y0_風切羽_羽8CP.Update();
			this.X0Y0_風切羽_羽7CP.Update();
			this.X0Y0_風切羽_羽6CP.Update();
			this.X0Y0_風切羽_羽5CP.Update();
			this.X0Y0_風切羽_羽4CP.Update();
			this.X0Y0_風切羽_羽3CP.Update();
			this.X0Y0_風切羽_羽2CP.Update();
			this.X0Y0_風切羽_羽1CP.Update();
			this.X0Y0_雨覆羽_羽10CP.Update();
			this.X0Y0_雨覆羽_羽9CP.Update();
			this.X0Y0_雨覆羽_羽8CP.Update();
			this.X0Y0_雨覆羽_羽7CP.Update();
			this.X0Y0_雨覆羽_羽6CP.Update();
			this.X0Y0_雨覆羽_羽5CP.Update();
			this.X0Y0_雨覆羽_羽4CP.Update();
			this.X0Y0_雨覆羽_羽3CP.Update();
			this.X0Y0_雨覆羽_羽2CP.Update();
			this.X0Y0_雨覆羽_羽1CP.Update();
			this.X0Y0_小翼羽_羽3CP.Update();
			this.X0Y0_小翼羽_羽2CP.Update();
			this.X0Y0_小翼羽_羽1CP.Update();
			this.X0Y0_指_中指_爪CP.Update();
			this.X0Y0_指_中指_指3CP.Update();
			this.X0Y0_指_中指_指2CP.Update();
			this.X0Y0_指_中指_指1CP.Update();
			this.X0Y0_指_中指_鱗3_鱗1CP.Update();
			this.X0Y0_指_中指_鱗3_鱗2CP.Update();
			this.X0Y0_指_中指_鱗3_鱗3CP.Update();
			this.X0Y0_指_中指_鱗3_鱗4CP.Update();
			this.X0Y0_指_中指_鱗2_鱗1CP.Update();
			this.X0Y0_指_中指_鱗2_鱗2CP.Update();
			this.X0Y0_指_中指_鱗2_鱗3CP.Update();
			this.X0Y0_指_中指_鱗2_鱗4CP.Update();
			this.X0Y0_指_中指_鱗1_鱗1CP.Update();
			this.X0Y0_指_中指_鱗1_鱗2CP.Update();
			this.X0Y0_指_中指_鱗1_鱗3CP.Update();
			this.X0Y0_指_中指_鱗1_鱗4CP.Update();
			this.X0Y0_指_中指_鱗1_鱗5CP.Update();
			this.X0Y0_指_中指_鱗1_鱗6CP.Update();
			this.X0Y0_指_人指_爪CP.Update();
			this.X0Y0_指_人指_指3CP.Update();
			this.X0Y0_指_人指_指2CP.Update();
			this.X0Y0_指_人指_指1CP.Update();
			this.X0Y0_指_人指_鱗3_鱗1CP.Update();
			this.X0Y0_指_人指_鱗3_鱗2CP.Update();
			this.X0Y0_指_人指_鱗3_鱗3CP.Update();
			this.X0Y0_指_人指_鱗3_鱗4CP.Update();
			this.X0Y0_指_人指_鱗2_鱗1CP.Update();
			this.X0Y0_指_人指_鱗2_鱗2CP.Update();
			this.X0Y0_指_人指_鱗2_鱗3CP.Update();
			this.X0Y0_指_人指_鱗2_鱗4CP.Update();
			this.X0Y0_指_人指_鱗1_鱗1CP.Update();
			this.X0Y0_指_人指_鱗1_鱗2CP.Update();
			this.X0Y0_指_人指_鱗1_鱗3CP.Update();
			this.X0Y0_指_人指_鱗1_鱗4CP.Update();
			this.X0Y0_指_人指_鱗1_鱗5CP.Update();
			this.X0Y0_指_人指_鱗1_鱗6CP.Update();
			this.X0Y0_指_親指_爪CP.Update();
			this.X0Y0_指_親指_指2CP.Update();
			this.X0Y0_指_親指_指1CP.Update();
			this.X0Y0_指_親指_鱗2_鱗1CP.Update();
			this.X0Y0_指_親指_鱗2_鱗2CP.Update();
			this.X0Y0_指_親指_鱗2_鱗3CP.Update();
			this.X0Y0_指_親指_鱗2_鱗4CP.Update();
			this.X0Y0_指_親指_鱗1_鱗1CP.Update();
			this.X0Y0_指_親指_鱗1_鱗2CP.Update();
			this.X0Y0_指_親指_鱗1_鱗3CP.Update();
			this.X0Y0_指_親指_鱗1_鱗4CP.Update();
			this.X0Y0_指_親指_鱗1_鱗5CP.Update();
			this.X0Y0_指_親指_鱗1_鱗6CP.Update();
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
			this.鳥翼手CD = new ColorD(ref Col.Black, ref 体配色.人肌R);
			this.風切羽_羽10CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_羽9CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_羽8CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_羽7CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_羽6CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_羽5CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_羽4CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_羽3CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_羽2CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_羽1CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.雨覆羽_羽10CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.雨覆羽_羽9CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.雨覆羽_羽8CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.雨覆羽_羽7CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.雨覆羽_羽6CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.雨覆羽_羽5CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.雨覆羽_羽4CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.雨覆羽_羽3CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.雨覆羽_羽2CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.雨覆羽_羽1CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.小翼羽_羽3CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
			this.小翼羽_羽2CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
			this.小翼羽_羽1CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
			this.指_中指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.指_中指_指3CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.指_中指_指2CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.指_中指_指1CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.指_中指_鱗3_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_中指_鱗3_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_中指_鱗3_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_中指_鱗3_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_中指_鱗2_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_中指_鱗2_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_中指_鱗2_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_中指_鱗2_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_中指_鱗1_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_中指_鱗1_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_中指_鱗1_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_中指_鱗1_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_中指_鱗1_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_中指_鱗1_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_人指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.指_人指_指3CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.指_人指_指2CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.指_人指_指1CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.指_人指_鱗3_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_人指_鱗3_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_人指_鱗3_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_人指_鱗3_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_人指_鱗2_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_人指_鱗2_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_人指_鱗2_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_人指_鱗2_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_人指_鱗1_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_人指_鱗1_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_人指_鱗1_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_人指_鱗1_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_人指_鱗1_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_人指_鱗1_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_親指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.指_親指_指2CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.指_親指_指1CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.指_親指_鱗2_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_親指_鱗2_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_親指_鱗2_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_親指_鱗2_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_親指_鱗1_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_親指_鱗1_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_親指_鱗1_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_親指_鱗1_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_親指_鱗1_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_親指_鱗1_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
		}

		private void 配色T0(体配色 体配色)
		{
			this.鳥翼手CD = new ColorD(ref Col.Black, ref 体配色.人肌R);
			this.風切羽_羽10CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_羽9CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.風切羽_羽8CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_羽7CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.風切羽_羽6CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_羽5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.風切羽_羽4CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_羽3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.風切羽_羽2CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_羽1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.雨覆羽_羽10CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.雨覆羽_羽9CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.雨覆羽_羽8CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.雨覆羽_羽7CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.雨覆羽_羽6CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.雨覆羽_羽5CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.雨覆羽_羽4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.雨覆羽_羽3CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.雨覆羽_羽2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.雨覆羽_羽1CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.小翼羽_羽3CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
			this.小翼羽_羽2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.小翼羽_羽1CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
			this.指_中指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.指_中指_指3CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.指_中指_指2CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.指_中指_指1CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.指_中指_鱗3_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.指_中指_鱗3_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_中指_鱗3_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.指_中指_鱗3_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_中指_鱗2_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.指_中指_鱗2_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_中指_鱗2_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.指_中指_鱗2_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_中指_鱗1_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.指_中指_鱗1_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_中指_鱗1_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.指_中指_鱗1_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_中指_鱗1_鱗5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.指_中指_鱗1_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_人指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.指_人指_指3CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.指_人指_指2CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.指_人指_指1CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.指_人指_鱗3_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.指_人指_鱗3_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_人指_鱗3_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.指_人指_鱗3_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_人指_鱗2_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.指_人指_鱗2_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_人指_鱗2_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.指_人指_鱗2_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_人指_鱗1_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.指_人指_鱗1_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_人指_鱗1_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.指_人指_鱗1_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_人指_鱗1_鱗5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.指_人指_鱗1_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_親指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.指_親指_指2CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.指_親指_指1CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.指_親指_鱗2_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.指_親指_鱗2_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_親指_鱗2_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.指_親指_鱗2_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_親指_鱗1_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.指_親指_鱗1_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_親指_鱗1_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.指_親指_鱗1_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_親指_鱗1_鱗5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.指_親指_鱗1_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
		}

		private void 配色T1(体配色 体配色)
		{
			this.鳥翼手CD = new ColorD(ref Col.Black, ref 体配色.人肌R);
			this.風切羽_羽10CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.風切羽_羽9CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_羽8CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.風切羽_羽7CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_羽6CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.風切羽_羽5CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_羽4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.風切羽_羽3CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_羽2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.風切羽_羽1CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.雨覆羽_羽10CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.雨覆羽_羽9CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.雨覆羽_羽8CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.雨覆羽_羽7CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.雨覆羽_羽6CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.雨覆羽_羽5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.雨覆羽_羽4CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.雨覆羽_羽3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.雨覆羽_羽2CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.雨覆羽_羽1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.小翼羽_羽3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.小翼羽_羽2CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
			this.小翼羽_羽1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.指_中指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.指_中指_指3CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.指_中指_指2CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.指_中指_指1CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.指_中指_鱗3_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_中指_鱗3_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.指_中指_鱗3_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_中指_鱗3_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.指_中指_鱗2_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_中指_鱗2_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.指_中指_鱗2_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_中指_鱗2_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.指_中指_鱗1_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_中指_鱗1_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.指_中指_鱗1_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_中指_鱗1_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.指_中指_鱗1_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_中指_鱗1_鱗6CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.指_人指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.指_人指_指3CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.指_人指_指2CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.指_人指_指1CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.指_人指_鱗3_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_人指_鱗3_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.指_人指_鱗3_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_人指_鱗3_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.指_人指_鱗2_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_人指_鱗2_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.指_人指_鱗2_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_人指_鱗2_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.指_人指_鱗1_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_人指_鱗1_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.指_人指_鱗1_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_人指_鱗1_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.指_人指_鱗1_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_人指_鱗1_鱗6CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.指_親指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.指_親指_指2CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.指_親指_指1CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.指_親指_鱗2_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_親指_鱗2_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.指_親指_鱗2_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_親指_鱗2_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.指_親指_鱗1_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_親指_鱗1_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.指_親指_鱗1_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_親指_鱗1_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.指_親指_鱗1_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.指_親指_鱗1_鱗6CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
		}

		public Par X0Y0_鳥翼手;

		public Par X0Y0_風切羽_羽10;

		public Par X0Y0_風切羽_羽9;

		public Par X0Y0_風切羽_羽8;

		public Par X0Y0_風切羽_羽7;

		public Par X0Y0_風切羽_羽6;

		public Par X0Y0_風切羽_羽5;

		public Par X0Y0_風切羽_羽4;

		public Par X0Y0_風切羽_羽3;

		public Par X0Y0_風切羽_羽2;

		public Par X0Y0_風切羽_羽1;

		public Par X0Y0_雨覆羽_羽10;

		public Par X0Y0_雨覆羽_羽9;

		public Par X0Y0_雨覆羽_羽8;

		public Par X0Y0_雨覆羽_羽7;

		public Par X0Y0_雨覆羽_羽6;

		public Par X0Y0_雨覆羽_羽5;

		public Par X0Y0_雨覆羽_羽4;

		public Par X0Y0_雨覆羽_羽3;

		public Par X0Y0_雨覆羽_羽2;

		public Par X0Y0_雨覆羽_羽1;

		public Par X0Y0_小翼羽_羽3;

		public Par X0Y0_小翼羽_羽2;

		public Par X0Y0_小翼羽_羽1;

		public Par X0Y0_指_中指_爪;

		public Par X0Y0_指_中指_指3;

		public Par X0Y0_指_中指_指2;

		public Par X0Y0_指_中指_指1;

		public Par X0Y0_指_中指_鱗3_鱗1;

		public Par X0Y0_指_中指_鱗3_鱗2;

		public Par X0Y0_指_中指_鱗3_鱗3;

		public Par X0Y0_指_中指_鱗3_鱗4;

		public Par X0Y0_指_中指_鱗2_鱗1;

		public Par X0Y0_指_中指_鱗2_鱗2;

		public Par X0Y0_指_中指_鱗2_鱗3;

		public Par X0Y0_指_中指_鱗2_鱗4;

		public Par X0Y0_指_中指_鱗1_鱗1;

		public Par X0Y0_指_中指_鱗1_鱗2;

		public Par X0Y0_指_中指_鱗1_鱗3;

		public Par X0Y0_指_中指_鱗1_鱗4;

		public Par X0Y0_指_中指_鱗1_鱗5;

		public Par X0Y0_指_中指_鱗1_鱗6;

		public Par X0Y0_指_人指_爪;

		public Par X0Y0_指_人指_指3;

		public Par X0Y0_指_人指_指2;

		public Par X0Y0_指_人指_指1;

		public Par X0Y0_指_人指_鱗3_鱗1;

		public Par X0Y0_指_人指_鱗3_鱗2;

		public Par X0Y0_指_人指_鱗3_鱗3;

		public Par X0Y0_指_人指_鱗3_鱗4;

		public Par X0Y0_指_人指_鱗2_鱗1;

		public Par X0Y0_指_人指_鱗2_鱗2;

		public Par X0Y0_指_人指_鱗2_鱗3;

		public Par X0Y0_指_人指_鱗2_鱗4;

		public Par X0Y0_指_人指_鱗1_鱗1;

		public Par X0Y0_指_人指_鱗1_鱗2;

		public Par X0Y0_指_人指_鱗1_鱗3;

		public Par X0Y0_指_人指_鱗1_鱗4;

		public Par X0Y0_指_人指_鱗1_鱗5;

		public Par X0Y0_指_人指_鱗1_鱗6;

		public Par X0Y0_指_親指_爪;

		public Par X0Y0_指_親指_指2;

		public Par X0Y0_指_親指_指1;

		public Par X0Y0_指_親指_鱗2_鱗1;

		public Par X0Y0_指_親指_鱗2_鱗2;

		public Par X0Y0_指_親指_鱗2_鱗3;

		public Par X0Y0_指_親指_鱗2_鱗4;

		public Par X0Y0_指_親指_鱗1_鱗1;

		public Par X0Y0_指_親指_鱗1_鱗2;

		public Par X0Y0_指_親指_鱗1_鱗3;

		public Par X0Y0_指_親指_鱗1_鱗4;

		public Par X0Y0_指_親指_鱗1_鱗5;

		public Par X0Y0_指_親指_鱗1_鱗6;

		public ColorD 鳥翼手CD;

		public ColorD 風切羽_羽10CD;

		public ColorD 風切羽_羽9CD;

		public ColorD 風切羽_羽8CD;

		public ColorD 風切羽_羽7CD;

		public ColorD 風切羽_羽6CD;

		public ColorD 風切羽_羽5CD;

		public ColorD 風切羽_羽4CD;

		public ColorD 風切羽_羽3CD;

		public ColorD 風切羽_羽2CD;

		public ColorD 風切羽_羽1CD;

		public ColorD 雨覆羽_羽10CD;

		public ColorD 雨覆羽_羽9CD;

		public ColorD 雨覆羽_羽8CD;

		public ColorD 雨覆羽_羽7CD;

		public ColorD 雨覆羽_羽6CD;

		public ColorD 雨覆羽_羽5CD;

		public ColorD 雨覆羽_羽4CD;

		public ColorD 雨覆羽_羽3CD;

		public ColorD 雨覆羽_羽2CD;

		public ColorD 雨覆羽_羽1CD;

		public ColorD 小翼羽_羽3CD;

		public ColorD 小翼羽_羽2CD;

		public ColorD 小翼羽_羽1CD;

		public ColorD 指_中指_爪CD;

		public ColorD 指_中指_指3CD;

		public ColorD 指_中指_指2CD;

		public ColorD 指_中指_指1CD;

		public ColorD 指_中指_鱗3_鱗1CD;

		public ColorD 指_中指_鱗3_鱗2CD;

		public ColorD 指_中指_鱗3_鱗3CD;

		public ColorD 指_中指_鱗3_鱗4CD;

		public ColorD 指_中指_鱗2_鱗1CD;

		public ColorD 指_中指_鱗2_鱗2CD;

		public ColorD 指_中指_鱗2_鱗3CD;

		public ColorD 指_中指_鱗2_鱗4CD;

		public ColorD 指_中指_鱗1_鱗1CD;

		public ColorD 指_中指_鱗1_鱗2CD;

		public ColorD 指_中指_鱗1_鱗3CD;

		public ColorD 指_中指_鱗1_鱗4CD;

		public ColorD 指_中指_鱗1_鱗5CD;

		public ColorD 指_中指_鱗1_鱗6CD;

		public ColorD 指_人指_爪CD;

		public ColorD 指_人指_指3CD;

		public ColorD 指_人指_指2CD;

		public ColorD 指_人指_指1CD;

		public ColorD 指_人指_鱗3_鱗1CD;

		public ColorD 指_人指_鱗3_鱗2CD;

		public ColorD 指_人指_鱗3_鱗3CD;

		public ColorD 指_人指_鱗3_鱗4CD;

		public ColorD 指_人指_鱗2_鱗1CD;

		public ColorD 指_人指_鱗2_鱗2CD;

		public ColorD 指_人指_鱗2_鱗3CD;

		public ColorD 指_人指_鱗2_鱗4CD;

		public ColorD 指_人指_鱗1_鱗1CD;

		public ColorD 指_人指_鱗1_鱗2CD;

		public ColorD 指_人指_鱗1_鱗3CD;

		public ColorD 指_人指_鱗1_鱗4CD;

		public ColorD 指_人指_鱗1_鱗5CD;

		public ColorD 指_人指_鱗1_鱗6CD;

		public ColorD 指_親指_爪CD;

		public ColorD 指_親指_指2CD;

		public ColorD 指_親指_指1CD;

		public ColorD 指_親指_鱗2_鱗1CD;

		public ColorD 指_親指_鱗2_鱗2CD;

		public ColorD 指_親指_鱗2_鱗3CD;

		public ColorD 指_親指_鱗2_鱗4CD;

		public ColorD 指_親指_鱗1_鱗1CD;

		public ColorD 指_親指_鱗1_鱗2CD;

		public ColorD 指_親指_鱗1_鱗3CD;

		public ColorD 指_親指_鱗1_鱗4CD;

		public ColorD 指_親指_鱗1_鱗5CD;

		public ColorD 指_親指_鱗1_鱗6CD;

		public ColorP X0Y0_鳥翼手CP;

		public ColorP X0Y0_風切羽_羽10CP;

		public ColorP X0Y0_風切羽_羽9CP;

		public ColorP X0Y0_風切羽_羽8CP;

		public ColorP X0Y0_風切羽_羽7CP;

		public ColorP X0Y0_風切羽_羽6CP;

		public ColorP X0Y0_風切羽_羽5CP;

		public ColorP X0Y0_風切羽_羽4CP;

		public ColorP X0Y0_風切羽_羽3CP;

		public ColorP X0Y0_風切羽_羽2CP;

		public ColorP X0Y0_風切羽_羽1CP;

		public ColorP X0Y0_雨覆羽_羽10CP;

		public ColorP X0Y0_雨覆羽_羽9CP;

		public ColorP X0Y0_雨覆羽_羽8CP;

		public ColorP X0Y0_雨覆羽_羽7CP;

		public ColorP X0Y0_雨覆羽_羽6CP;

		public ColorP X0Y0_雨覆羽_羽5CP;

		public ColorP X0Y0_雨覆羽_羽4CP;

		public ColorP X0Y0_雨覆羽_羽3CP;

		public ColorP X0Y0_雨覆羽_羽2CP;

		public ColorP X0Y0_雨覆羽_羽1CP;

		public ColorP X0Y0_小翼羽_羽3CP;

		public ColorP X0Y0_小翼羽_羽2CP;

		public ColorP X0Y0_小翼羽_羽1CP;

		public ColorP X0Y0_指_中指_爪CP;

		public ColorP X0Y0_指_中指_指3CP;

		public ColorP X0Y0_指_中指_指2CP;

		public ColorP X0Y0_指_中指_指1CP;

		public ColorP X0Y0_指_中指_鱗3_鱗1CP;

		public ColorP X0Y0_指_中指_鱗3_鱗2CP;

		public ColorP X0Y0_指_中指_鱗3_鱗3CP;

		public ColorP X0Y0_指_中指_鱗3_鱗4CP;

		public ColorP X0Y0_指_中指_鱗2_鱗1CP;

		public ColorP X0Y0_指_中指_鱗2_鱗2CP;

		public ColorP X0Y0_指_中指_鱗2_鱗3CP;

		public ColorP X0Y0_指_中指_鱗2_鱗4CP;

		public ColorP X0Y0_指_中指_鱗1_鱗1CP;

		public ColorP X0Y0_指_中指_鱗1_鱗2CP;

		public ColorP X0Y0_指_中指_鱗1_鱗3CP;

		public ColorP X0Y0_指_中指_鱗1_鱗4CP;

		public ColorP X0Y0_指_中指_鱗1_鱗5CP;

		public ColorP X0Y0_指_中指_鱗1_鱗6CP;

		public ColorP X0Y0_指_人指_爪CP;

		public ColorP X0Y0_指_人指_指3CP;

		public ColorP X0Y0_指_人指_指2CP;

		public ColorP X0Y0_指_人指_指1CP;

		public ColorP X0Y0_指_人指_鱗3_鱗1CP;

		public ColorP X0Y0_指_人指_鱗3_鱗2CP;

		public ColorP X0Y0_指_人指_鱗3_鱗3CP;

		public ColorP X0Y0_指_人指_鱗3_鱗4CP;

		public ColorP X0Y0_指_人指_鱗2_鱗1CP;

		public ColorP X0Y0_指_人指_鱗2_鱗2CP;

		public ColorP X0Y0_指_人指_鱗2_鱗3CP;

		public ColorP X0Y0_指_人指_鱗2_鱗4CP;

		public ColorP X0Y0_指_人指_鱗1_鱗1CP;

		public ColorP X0Y0_指_人指_鱗1_鱗2CP;

		public ColorP X0Y0_指_人指_鱗1_鱗3CP;

		public ColorP X0Y0_指_人指_鱗1_鱗4CP;

		public ColorP X0Y0_指_人指_鱗1_鱗5CP;

		public ColorP X0Y0_指_人指_鱗1_鱗6CP;

		public ColorP X0Y0_指_親指_爪CP;

		public ColorP X0Y0_指_親指_指2CP;

		public ColorP X0Y0_指_親指_指1CP;

		public ColorP X0Y0_指_親指_鱗2_鱗1CP;

		public ColorP X0Y0_指_親指_鱗2_鱗2CP;

		public ColorP X0Y0_指_親指_鱗2_鱗3CP;

		public ColorP X0Y0_指_親指_鱗2_鱗4CP;

		public ColorP X0Y0_指_親指_鱗1_鱗1CP;

		public ColorP X0Y0_指_親指_鱗1_鱗2CP;

		public ColorP X0Y0_指_親指_鱗1_鱗3CP;

		public ColorP X0Y0_指_親指_鱗1_鱗4CP;

		public ColorP X0Y0_指_親指_鱗1_鱗5CP;

		public ColorP X0Y0_指_親指_鱗1_鱗6CP;
	}
}
