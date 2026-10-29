using System;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 下腕_鳥 : 翼下腕
	{
		public 下腕_鳥(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 下腕_鳥D e)
		{
			下腕_鳥.<>c__DisplayClass178_0 CS$<>8__locals1 = new 下腕_鳥.<>c__DisplayClass178_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.腕左["鳥翼下腕"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_鳥翼下腕 = pars["鳥翼下腕"].ToPar();
			Pars pars2 = pars["風切羽"].ToPars();
			this.X0Y0_風切羽_羽15 = pars2["羽15"].ToPar();
			this.X0Y0_風切羽_羽14 = pars2["羽14"].ToPar();
			this.X0Y0_風切羽_羽13 = pars2["羽13"].ToPar();
			this.X0Y0_風切羽_羽12 = pars2["羽12"].ToPar();
			this.X0Y0_風切羽_羽11 = pars2["羽11"].ToPar();
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
			this.X0Y0_雨覆羽_羽14 = pars2["羽14"].ToPar();
			this.X0Y0_雨覆羽_羽13 = pars2["羽13"].ToPar();
			this.X0Y0_雨覆羽_羽12 = pars2["羽12"].ToPar();
			this.X0Y0_雨覆羽_羽11 = pars2["羽11"].ToPar();
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
			pars2 = pars["中雨覆羽"].ToPars();
			this.X0Y0_中雨覆羽_羽13 = pars2["羽13"].ToPar();
			this.X0Y0_中雨覆羽_羽12 = pars2["羽12"].ToPar();
			this.X0Y0_中雨覆羽_羽11 = pars2["羽11"].ToPar();
			this.X0Y0_中雨覆羽_羽10 = pars2["羽10"].ToPar();
			this.X0Y0_中雨覆羽_羽9 = pars2["羽9"].ToPar();
			this.X0Y0_中雨覆羽_羽8 = pars2["羽8"].ToPar();
			this.X0Y0_中雨覆羽_羽7 = pars2["羽7"].ToPar();
			this.X0Y0_中雨覆羽_羽6 = pars2["羽6"].ToPar();
			this.X0Y0_中雨覆羽_羽5 = pars2["羽5"].ToPar();
			this.X0Y0_中雨覆羽_羽4 = pars2["羽4"].ToPar();
			this.X0Y0_中雨覆羽_羽3 = pars2["羽3"].ToPar();
			this.X0Y0_中雨覆羽_羽2 = pars2["羽2"].ToPar();
			this.X0Y0_中雨覆羽_羽1 = pars2["羽1"].ToPar();
			pars2 = pars["小雨覆"].ToPars();
			this.X0Y0_小雨覆_小雨覆 = pars2["小雨覆"].ToPar();
			pars2 = pars2["鱗"].ToPars();
			this.X0Y0_小雨覆_竜性_鱗1 = pars2["鱗1"].ToPar();
			this.X0Y0_小雨覆_竜性_鱗2 = pars2["鱗2"].ToPar();
			this.X0Y0_小雨覆_竜性_鱗3 = pars2["鱗3"].ToPar();
			this.X0Y0_小雨覆_竜性_鱗4 = pars2["鱗4"].ToPar();
			this.X0Y0_小雨覆_竜性_鱗5 = pars2["鱗5"].ToPar();
			this.X0Y0_小雨覆_竜性_鱗6 = pars2["鱗6"].ToPar();
			this.X0Y0_小雨覆_竜性_鱗7 = pars2["鱗7"].ToPar();
			this.X0Y0_小雨覆_竜性_鱗8 = pars2["鱗8"].ToPar();
			this.X0Y0_小雨覆_竜性_鱗9 = pars2["鱗9"].ToPar();
			pars2 = pars["腕輪"].ToPars();
			this.X0Y0_腕輪_革 = pars2["革"].ToPar();
			this.X0Y0_腕輪_金具1 = pars2["金具1"].ToPar();
			this.X0Y0_腕輪_金具2 = pars2["金具2"].ToPar();
			this.X0Y0_腕輪_金具3 = pars2["金具3"].ToPar();
			this.X0Y0_腕輪_金具左 = pars2["金具左"].ToPar();
			this.X0Y0_腕輪_金具右 = pars2["金具右"].ToPar();
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
			this.鳥翼下腕_表示 = e.鳥翼下腕_表示;
			this.風切羽_羽15_表示 = e.風切羽_羽15_表示;
			this.風切羽_羽14_表示 = e.風切羽_羽14_表示;
			this.風切羽_羽13_表示 = e.風切羽_羽13_表示;
			this.風切羽_羽12_表示 = e.風切羽_羽12_表示;
			this.風切羽_羽11_表示 = e.風切羽_羽11_表示;
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
			this.雨覆羽_羽14_表示 = e.雨覆羽_羽14_表示;
			this.雨覆羽_羽13_表示 = e.雨覆羽_羽13_表示;
			this.雨覆羽_羽12_表示 = e.雨覆羽_羽12_表示;
			this.雨覆羽_羽11_表示 = e.雨覆羽_羽11_表示;
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
			this.中雨覆羽_羽13_表示 = e.中雨覆羽_羽13_表示;
			this.中雨覆羽_羽12_表示 = e.中雨覆羽_羽12_表示;
			this.中雨覆羽_羽11_表示 = e.中雨覆羽_羽11_表示;
			this.中雨覆羽_羽10_表示 = e.中雨覆羽_羽10_表示;
			this.中雨覆羽_羽9_表示 = e.中雨覆羽_羽9_表示;
			this.中雨覆羽_羽8_表示 = e.中雨覆羽_羽8_表示;
			this.中雨覆羽_羽7_表示 = e.中雨覆羽_羽7_表示;
			this.中雨覆羽_羽6_表示 = e.中雨覆羽_羽6_表示;
			this.中雨覆羽_羽5_表示 = e.中雨覆羽_羽5_表示;
			this.中雨覆羽_羽4_表示 = e.中雨覆羽_羽4_表示;
			this.中雨覆羽_羽3_表示 = e.中雨覆羽_羽3_表示;
			this.中雨覆羽_羽2_表示 = e.中雨覆羽_羽2_表示;
			this.中雨覆羽_羽1_表示 = e.中雨覆羽_羽1_表示;
			this.小雨覆_小雨覆_表示 = e.小雨覆_小雨覆_表示;
			this.小雨覆_竜性_鱗1_表示 = e.小雨覆_竜性_鱗1_表示;
			this.小雨覆_竜性_鱗2_表示 = e.小雨覆_竜性_鱗2_表示;
			this.小雨覆_竜性_鱗3_表示 = e.小雨覆_竜性_鱗3_表示;
			this.小雨覆_竜性_鱗4_表示 = e.小雨覆_竜性_鱗4_表示;
			this.小雨覆_竜性_鱗5_表示 = e.小雨覆_竜性_鱗5_表示;
			this.小雨覆_竜性_鱗6_表示 = e.小雨覆_竜性_鱗6_表示;
			this.小雨覆_竜性_鱗7_表示 = e.小雨覆_竜性_鱗7_表示;
			this.小雨覆_竜性_鱗8_表示 = e.小雨覆_竜性_鱗8_表示;
			this.小雨覆_竜性_鱗9_表示 = e.小雨覆_竜性_鱗9_表示;
			this.腕輪_革_表示 = e.腕輪_革_表示;
			this.腕輪_金具1_表示 = e.腕輪_金具1_表示;
			this.腕輪_金具2_表示 = e.腕輪_金具2_表示;
			this.腕輪_金具3_表示 = e.腕輪_金具3_表示;
			this.腕輪_金具左_表示 = e.腕輪_金具左_表示;
			this.腕輪_金具右_表示 = e.腕輪_金具右_表示;
			this.腕輪表示 = e.腕輪表示;
			this.展開 = e.展開;
			this.シャ\u30FCプ = e.シャ\u30FCプ;
			this.下腕_外線 = e.下腕_外線;
			this.小雨覆_外線 = e.小雨覆_外線;
			this.中雨覆羽_羽1_外線 = e.中雨覆羽_羽1_外線;
			this.中雨覆羽_羽2_外線 = e.中雨覆羽_羽2_外線;
			this.中雨覆羽_羽3_外線 = e.中雨覆羽_羽3_外線;
			this.中雨覆羽_羽4_外線 = e.中雨覆羽_羽4_外線;
			this.中雨覆羽_羽5_外線 = e.中雨覆羽_羽5_外線;
			this.中雨覆羽_羽6_外線 = e.中雨覆羽_羽6_外線;
			this.中雨覆羽_羽7_外線 = e.中雨覆羽_羽7_外線;
			this.中雨覆羽_羽8_外線 = e.中雨覆羽_羽8_外線;
			this.中雨覆羽_羽9_外線 = e.中雨覆羽_羽9_外線;
			this.中雨覆羽_羽10_外線 = e.中雨覆羽_羽10_外線;
			this.中雨覆羽_羽11_外線 = e.中雨覆羽_羽11_外線;
			this.中雨覆羽_羽12_外線 = e.中雨覆羽_羽12_外線;
			this.中雨覆羽_羽13_外線 = e.中雨覆羽_羽13_外線;
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
			this.雨覆羽_羽11_外線 = e.雨覆羽_羽11_外線;
			this.雨覆羽_羽12_外線 = e.雨覆羽_羽12_外線;
			this.雨覆羽_羽13_外線 = e.雨覆羽_羽13_外線;
			this.雨覆羽_羽14_外線 = e.雨覆羽_羽14_外線;
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
			this.風切羽_羽11_外線 = e.風切羽_羽11_外線;
			this.風切羽_羽12_外線 = e.風切羽_羽12_外線;
			this.風切羽_羽13_外線 = e.風切羽_羽13_外線;
			this.風切羽_羽14_外線 = e.風切羽_羽14_外線;
			this.風切羽_羽15_外線 = e.風切羽_羽15_外線;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.手_接続.Count > 0)
			{
				Ele f;
				this.手_接続 = e.手_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.下腕_鳥_手_接続;
					f.接続(CS$<>8__locals1.<>4__this.手_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_鳥翼下腕CP = new ColorP(this.X0Y0_鳥翼下腕, this.鳥翼下腕CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_風切羽_羽15CP = new ColorP(this.X0Y0_風切羽_羽15, this.風切羽_羽15CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_風切羽_羽14CP = new ColorP(this.X0Y0_風切羽_羽14, this.風切羽_羽14CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_風切羽_羽13CP = new ColorP(this.X0Y0_風切羽_羽13, this.風切羽_羽13CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_風切羽_羽12CP = new ColorP(this.X0Y0_風切羽_羽12, this.風切羽_羽12CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_風切羽_羽11CP = new ColorP(this.X0Y0_風切羽_羽11, this.風切羽_羽11CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_風切羽_羽10CP = new ColorP(this.X0Y0_風切羽_羽10, this.風切羽_羽10CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_風切羽_羽9CP = new ColorP(this.X0Y0_風切羽_羽9, this.風切羽_羽9CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_風切羽_羽8CP = new ColorP(this.X0Y0_風切羽_羽8, this.風切羽_羽8CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_風切羽_羽7CP = new ColorP(this.X0Y0_風切羽_羽7, this.風切羽_羽7CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_風切羽_羽6CP = new ColorP(this.X0Y0_風切羽_羽6, this.風切羽_羽6CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_風切羽_羽5CP = new ColorP(this.X0Y0_風切羽_羽5, this.風切羽_羽5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_風切羽_羽4CP = new ColorP(this.X0Y0_風切羽_羽4, this.風切羽_羽4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_風切羽_羽3CP = new ColorP(this.X0Y0_風切羽_羽3, this.風切羽_羽3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_風切羽_羽2CP = new ColorP(this.X0Y0_風切羽_羽2, this.風切羽_羽2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_風切羽_羽1CP = new ColorP(this.X0Y0_風切羽_羽1, this.風切羽_羽1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_雨覆羽_羽14CP = new ColorP(this.X0Y0_雨覆羽_羽14, this.雨覆羽_羽14CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_雨覆羽_羽13CP = new ColorP(this.X0Y0_雨覆羽_羽13, this.雨覆羽_羽13CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_雨覆羽_羽12CP = new ColorP(this.X0Y0_雨覆羽_羽12, this.雨覆羽_羽12CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_雨覆羽_羽11CP = new ColorP(this.X0Y0_雨覆羽_羽11, this.雨覆羽_羽11CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_雨覆羽_羽10CP = new ColorP(this.X0Y0_雨覆羽_羽10, this.雨覆羽_羽10CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_雨覆羽_羽9CP = new ColorP(this.X0Y0_雨覆羽_羽9, this.雨覆羽_羽9CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_雨覆羽_羽8CP = new ColorP(this.X0Y0_雨覆羽_羽8, this.雨覆羽_羽8CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_雨覆羽_羽7CP = new ColorP(this.X0Y0_雨覆羽_羽7, this.雨覆羽_羽7CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_雨覆羽_羽6CP = new ColorP(this.X0Y0_雨覆羽_羽6, this.雨覆羽_羽6CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_雨覆羽_羽5CP = new ColorP(this.X0Y0_雨覆羽_羽5, this.雨覆羽_羽5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_雨覆羽_羽4CP = new ColorP(this.X0Y0_雨覆羽_羽4, this.雨覆羽_羽4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_雨覆羽_羽3CP = new ColorP(this.X0Y0_雨覆羽_羽3, this.雨覆羽_羽3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_雨覆羽_羽2CP = new ColorP(this.X0Y0_雨覆羽_羽2, this.雨覆羽_羽2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_雨覆羽_羽1CP = new ColorP(this.X0Y0_雨覆羽_羽1, this.雨覆羽_羽1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_中雨覆羽_羽13CP = new ColorP(this.X0Y0_中雨覆羽_羽13, this.中雨覆羽_羽13CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_中雨覆羽_羽12CP = new ColorP(this.X0Y0_中雨覆羽_羽12, this.中雨覆羽_羽12CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_中雨覆羽_羽11CP = new ColorP(this.X0Y0_中雨覆羽_羽11, this.中雨覆羽_羽11CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_中雨覆羽_羽10CP = new ColorP(this.X0Y0_中雨覆羽_羽10, this.中雨覆羽_羽10CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_中雨覆羽_羽9CP = new ColorP(this.X0Y0_中雨覆羽_羽9, this.中雨覆羽_羽9CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_中雨覆羽_羽8CP = new ColorP(this.X0Y0_中雨覆羽_羽8, this.中雨覆羽_羽8CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_中雨覆羽_羽7CP = new ColorP(this.X0Y0_中雨覆羽_羽7, this.中雨覆羽_羽7CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_中雨覆羽_羽6CP = new ColorP(this.X0Y0_中雨覆羽_羽6, this.中雨覆羽_羽6CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_中雨覆羽_羽5CP = new ColorP(this.X0Y0_中雨覆羽_羽5, this.中雨覆羽_羽5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_中雨覆羽_羽4CP = new ColorP(this.X0Y0_中雨覆羽_羽4, this.中雨覆羽_羽4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_中雨覆羽_羽3CP = new ColorP(this.X0Y0_中雨覆羽_羽3, this.中雨覆羽_羽3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_中雨覆羽_羽2CP = new ColorP(this.X0Y0_中雨覆羽_羽2, this.中雨覆羽_羽2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_中雨覆羽_羽1CP = new ColorP(this.X0Y0_中雨覆羽_羽1, this.中雨覆羽_羽1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_小雨覆_小雨覆CP = new ColorP(this.X0Y0_小雨覆_小雨覆, this.小雨覆_小雨覆CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_小雨覆_竜性_鱗1CP = new ColorP(this.X0Y0_小雨覆_竜性_鱗1, this.小雨覆_竜性_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_小雨覆_竜性_鱗2CP = new ColorP(this.X0Y0_小雨覆_竜性_鱗2, this.小雨覆_竜性_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_小雨覆_竜性_鱗3CP = new ColorP(this.X0Y0_小雨覆_竜性_鱗3, this.小雨覆_竜性_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_小雨覆_竜性_鱗4CP = new ColorP(this.X0Y0_小雨覆_竜性_鱗4, this.小雨覆_竜性_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_小雨覆_竜性_鱗5CP = new ColorP(this.X0Y0_小雨覆_竜性_鱗5, this.小雨覆_竜性_鱗5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_小雨覆_竜性_鱗6CP = new ColorP(this.X0Y0_小雨覆_竜性_鱗6, this.小雨覆_竜性_鱗6CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_小雨覆_竜性_鱗7CP = new ColorP(this.X0Y0_小雨覆_竜性_鱗7, this.小雨覆_竜性_鱗7CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_小雨覆_竜性_鱗8CP = new ColorP(this.X0Y0_小雨覆_竜性_鱗8, this.小雨覆_竜性_鱗8CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_小雨覆_竜性_鱗9CP = new ColorP(this.X0Y0_小雨覆_竜性_鱗9, this.小雨覆_竜性_鱗9CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_腕輪_革CP = new ColorP(this.X0Y0_腕輪_革, this.腕輪_革CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_腕輪_金具1CP = new ColorP(this.X0Y0_腕輪_金具1, this.腕輪_金具1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_腕輪_金具2CP = new ColorP(this.X0Y0_腕輪_金具2, this.腕輪_金具2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_腕輪_金具3CP = new ColorP(this.X0Y0_腕輪_金具3, this.腕輪_金具3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_腕輪_金具左CP = new ColorP(this.X0Y0_腕輪_金具左, this.腕輪_金具左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_腕輪_金具右CP = new ColorP(this.X0Y0_腕輪_金具右, this.腕輪_金具右CD, CS$<>8__locals1.DisUnit, true);
			this.濃度 = e.濃度;
			this.鎖1 = new 拘束鎖(CS$<>8__locals1.DisUnit, false, 配色指定, CS$<>8__locals1.体配色, this.Xasix);
			this.鎖1.接続(this.鎖1_接続点);
			int num = this.右 ? -10 : 10;
			this.鎖1.角度B += (double)num;
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
				this.腕輪表示 = this.拘束_;
			}
		}

		public bool 鳥翼下腕_表示
		{
			get
			{
				return this.X0Y0_鳥翼下腕.Dra;
			}
			set
			{
				this.X0Y0_鳥翼下腕.Dra = value;
				this.X0Y0_鳥翼下腕.Hit = value;
			}
		}

		public bool 風切羽_羽15_表示
		{
			get
			{
				return this.X0Y0_風切羽_羽15.Dra;
			}
			set
			{
				this.X0Y0_風切羽_羽15.Dra = value;
				this.X0Y0_風切羽_羽15.Hit = value;
			}
		}

		public bool 風切羽_羽14_表示
		{
			get
			{
				return this.X0Y0_風切羽_羽14.Dra;
			}
			set
			{
				this.X0Y0_風切羽_羽14.Dra = value;
				this.X0Y0_風切羽_羽14.Hit = value;
			}
		}

		public bool 風切羽_羽13_表示
		{
			get
			{
				return this.X0Y0_風切羽_羽13.Dra;
			}
			set
			{
				this.X0Y0_風切羽_羽13.Dra = value;
				this.X0Y0_風切羽_羽13.Hit = value;
			}
		}

		public bool 風切羽_羽12_表示
		{
			get
			{
				return this.X0Y0_風切羽_羽12.Dra;
			}
			set
			{
				this.X0Y0_風切羽_羽12.Dra = value;
				this.X0Y0_風切羽_羽12.Hit = value;
			}
		}

		public bool 風切羽_羽11_表示
		{
			get
			{
				return this.X0Y0_風切羽_羽11.Dra;
			}
			set
			{
				this.X0Y0_風切羽_羽11.Dra = value;
				this.X0Y0_風切羽_羽11.Hit = value;
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

		public bool 雨覆羽_羽14_表示
		{
			get
			{
				return this.X0Y0_雨覆羽_羽14.Dra;
			}
			set
			{
				this.X0Y0_雨覆羽_羽14.Dra = value;
				this.X0Y0_雨覆羽_羽14.Hit = value;
			}
		}

		public bool 雨覆羽_羽13_表示
		{
			get
			{
				return this.X0Y0_雨覆羽_羽13.Dra;
			}
			set
			{
				this.X0Y0_雨覆羽_羽13.Dra = value;
				this.X0Y0_雨覆羽_羽13.Hit = value;
			}
		}

		public bool 雨覆羽_羽12_表示
		{
			get
			{
				return this.X0Y0_雨覆羽_羽12.Dra;
			}
			set
			{
				this.X0Y0_雨覆羽_羽12.Dra = value;
				this.X0Y0_雨覆羽_羽12.Hit = value;
			}
		}

		public bool 雨覆羽_羽11_表示
		{
			get
			{
				return this.X0Y0_雨覆羽_羽11.Dra;
			}
			set
			{
				this.X0Y0_雨覆羽_羽11.Dra = value;
				this.X0Y0_雨覆羽_羽11.Hit = value;
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

		public bool 中雨覆羽_羽13_表示
		{
			get
			{
				return this.X0Y0_中雨覆羽_羽13.Dra;
			}
			set
			{
				this.X0Y0_中雨覆羽_羽13.Dra = value;
				this.X0Y0_中雨覆羽_羽13.Hit = value;
			}
		}

		public bool 中雨覆羽_羽12_表示
		{
			get
			{
				return this.X0Y0_中雨覆羽_羽12.Dra;
			}
			set
			{
				this.X0Y0_中雨覆羽_羽12.Dra = value;
				this.X0Y0_中雨覆羽_羽12.Hit = value;
			}
		}

		public bool 中雨覆羽_羽11_表示
		{
			get
			{
				return this.X0Y0_中雨覆羽_羽11.Dra;
			}
			set
			{
				this.X0Y0_中雨覆羽_羽11.Dra = value;
				this.X0Y0_中雨覆羽_羽11.Hit = value;
			}
		}

		public bool 中雨覆羽_羽10_表示
		{
			get
			{
				return this.X0Y0_中雨覆羽_羽10.Dra;
			}
			set
			{
				this.X0Y0_中雨覆羽_羽10.Dra = value;
				this.X0Y0_中雨覆羽_羽10.Hit = value;
			}
		}

		public bool 中雨覆羽_羽9_表示
		{
			get
			{
				return this.X0Y0_中雨覆羽_羽9.Dra;
			}
			set
			{
				this.X0Y0_中雨覆羽_羽9.Dra = value;
				this.X0Y0_中雨覆羽_羽9.Hit = value;
			}
		}

		public bool 中雨覆羽_羽8_表示
		{
			get
			{
				return this.X0Y0_中雨覆羽_羽8.Dra;
			}
			set
			{
				this.X0Y0_中雨覆羽_羽8.Dra = value;
				this.X0Y0_中雨覆羽_羽8.Hit = value;
			}
		}

		public bool 中雨覆羽_羽7_表示
		{
			get
			{
				return this.X0Y0_中雨覆羽_羽7.Dra;
			}
			set
			{
				this.X0Y0_中雨覆羽_羽7.Dra = value;
				this.X0Y0_中雨覆羽_羽7.Hit = value;
			}
		}

		public bool 中雨覆羽_羽6_表示
		{
			get
			{
				return this.X0Y0_中雨覆羽_羽6.Dra;
			}
			set
			{
				this.X0Y0_中雨覆羽_羽6.Dra = value;
				this.X0Y0_中雨覆羽_羽6.Hit = value;
			}
		}

		public bool 中雨覆羽_羽5_表示
		{
			get
			{
				return this.X0Y0_中雨覆羽_羽5.Dra;
			}
			set
			{
				this.X0Y0_中雨覆羽_羽5.Dra = value;
				this.X0Y0_中雨覆羽_羽5.Hit = value;
			}
		}

		public bool 中雨覆羽_羽4_表示
		{
			get
			{
				return this.X0Y0_中雨覆羽_羽4.Dra;
			}
			set
			{
				this.X0Y0_中雨覆羽_羽4.Dra = value;
				this.X0Y0_中雨覆羽_羽4.Hit = value;
			}
		}

		public bool 中雨覆羽_羽3_表示
		{
			get
			{
				return this.X0Y0_中雨覆羽_羽3.Dra;
			}
			set
			{
				this.X0Y0_中雨覆羽_羽3.Dra = value;
				this.X0Y0_中雨覆羽_羽3.Hit = value;
			}
		}

		public bool 中雨覆羽_羽2_表示
		{
			get
			{
				return this.X0Y0_中雨覆羽_羽2.Dra;
			}
			set
			{
				this.X0Y0_中雨覆羽_羽2.Dra = value;
				this.X0Y0_中雨覆羽_羽2.Hit = value;
			}
		}

		public bool 中雨覆羽_羽1_表示
		{
			get
			{
				return this.X0Y0_中雨覆羽_羽1.Dra;
			}
			set
			{
				this.X0Y0_中雨覆羽_羽1.Dra = value;
				this.X0Y0_中雨覆羽_羽1.Hit = value;
			}
		}

		public bool 小雨覆_小雨覆_表示
		{
			get
			{
				return this.X0Y0_小雨覆_小雨覆.Dra;
			}
			set
			{
				this.X0Y0_小雨覆_小雨覆.Dra = value;
				this.X0Y0_小雨覆_小雨覆.Hit = value;
			}
		}

		public bool 小雨覆_竜性_鱗1_表示
		{
			get
			{
				return this.X0Y0_小雨覆_竜性_鱗1.Dra;
			}
			set
			{
				this.X0Y0_小雨覆_竜性_鱗1.Dra = false;
				this.X0Y0_小雨覆_竜性_鱗1.Hit = false;
			}
		}

		public bool 小雨覆_竜性_鱗2_表示
		{
			get
			{
				return this.X0Y0_小雨覆_竜性_鱗2.Dra;
			}
			set
			{
				this.X0Y0_小雨覆_竜性_鱗2.Dra = false;
				this.X0Y0_小雨覆_竜性_鱗2.Hit = false;
			}
		}

		public bool 小雨覆_竜性_鱗3_表示
		{
			get
			{
				return this.X0Y0_小雨覆_竜性_鱗3.Dra;
			}
			set
			{
				this.X0Y0_小雨覆_竜性_鱗3.Dra = value;
				this.X0Y0_小雨覆_竜性_鱗3.Hit = value;
			}
		}

		public bool 小雨覆_竜性_鱗4_表示
		{
			get
			{
				return this.X0Y0_小雨覆_竜性_鱗4.Dra;
			}
			set
			{
				this.X0Y0_小雨覆_竜性_鱗4.Dra = value;
				this.X0Y0_小雨覆_竜性_鱗4.Hit = value;
			}
		}

		public bool 小雨覆_竜性_鱗5_表示
		{
			get
			{
				return this.X0Y0_小雨覆_竜性_鱗5.Dra;
			}
			set
			{
				this.X0Y0_小雨覆_竜性_鱗5.Dra = value;
				this.X0Y0_小雨覆_竜性_鱗5.Hit = value;
			}
		}

		public bool 小雨覆_竜性_鱗6_表示
		{
			get
			{
				return this.X0Y0_小雨覆_竜性_鱗6.Dra;
			}
			set
			{
				this.X0Y0_小雨覆_竜性_鱗6.Dra = value;
				this.X0Y0_小雨覆_竜性_鱗6.Hit = value;
			}
		}

		public bool 小雨覆_竜性_鱗7_表示
		{
			get
			{
				return this.X0Y0_小雨覆_竜性_鱗7.Dra;
			}
			set
			{
				this.X0Y0_小雨覆_竜性_鱗7.Dra = value;
				this.X0Y0_小雨覆_竜性_鱗7.Hit = value;
			}
		}

		public bool 小雨覆_竜性_鱗8_表示
		{
			get
			{
				return this.X0Y0_小雨覆_竜性_鱗8.Dra;
			}
			set
			{
				this.X0Y0_小雨覆_竜性_鱗8.Dra = value;
				this.X0Y0_小雨覆_竜性_鱗8.Hit = value;
			}
		}

		public bool 小雨覆_竜性_鱗9_表示
		{
			get
			{
				return this.X0Y0_小雨覆_竜性_鱗9.Dra;
			}
			set
			{
				this.X0Y0_小雨覆_竜性_鱗9.Dra = value;
				this.X0Y0_小雨覆_竜性_鱗9.Hit = value;
			}
		}

		public bool 腕輪_革_表示
		{
			get
			{
				return this.X0Y0_腕輪_革.Dra;
			}
			set
			{
				this.X0Y0_腕輪_革.Dra = value;
				this.X0Y0_腕輪_革.Hit = value;
			}
		}

		public bool 腕輪_金具1_表示
		{
			get
			{
				return this.X0Y0_腕輪_金具1.Dra;
			}
			set
			{
				this.X0Y0_腕輪_金具1.Dra = value;
				this.X0Y0_腕輪_金具1.Hit = value;
			}
		}

		public bool 腕輪_金具2_表示
		{
			get
			{
				return this.X0Y0_腕輪_金具2.Dra;
			}
			set
			{
				this.X0Y0_腕輪_金具2.Dra = value;
				this.X0Y0_腕輪_金具2.Hit = value;
			}
		}

		public bool 腕輪_金具3_表示
		{
			get
			{
				return this.X0Y0_腕輪_金具3.Dra;
			}
			set
			{
				this.X0Y0_腕輪_金具3.Dra = value;
				this.X0Y0_腕輪_金具3.Hit = value;
			}
		}

		public bool 腕輪_金具左_表示
		{
			get
			{
				return this.X0Y0_腕輪_金具左.Dra;
			}
			set
			{
				this.X0Y0_腕輪_金具左.Dra = value;
				this.X0Y0_腕輪_金具左.Hit = value;
			}
		}

		public bool 腕輪_金具右_表示
		{
			get
			{
				return this.X0Y0_腕輪_金具右.Dra;
			}
			set
			{
				value = false;
				this.X0Y0_腕輪_金具右.Dra = value;
				this.X0Y0_腕輪_金具右.Hit = value;
			}
		}

		public bool 腕輪表示
		{
			get
			{
				return this.腕輪_革_表示;
			}
			set
			{
				this.腕輪_革_表示 = value;
				this.腕輪_金具1_表示 = value;
				this.腕輪_金具2_表示 = value;
				this.腕輪_金具3_表示 = value;
				this.腕輪_金具左_表示 = value;
				this.腕輪_金具右_表示 = value;
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

		public override void Dispose()
		{
			base.Dispose();
			this.鎖1.Dispose();
		}

		public override bool 表示
		{
			get
			{
				return this.鳥翼下腕_表示;
			}
			set
			{
				this.鳥翼下腕_表示 = value;
				this.風切羽_羽15_表示 = value;
				this.風切羽_羽14_表示 = value;
				this.風切羽_羽13_表示 = value;
				this.風切羽_羽12_表示 = value;
				this.風切羽_羽11_表示 = value;
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
				this.雨覆羽_羽14_表示 = value;
				this.雨覆羽_羽13_表示 = value;
				this.雨覆羽_羽12_表示 = value;
				this.雨覆羽_羽11_表示 = value;
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
				this.中雨覆羽_羽13_表示 = value;
				this.中雨覆羽_羽12_表示 = value;
				this.中雨覆羽_羽11_表示 = value;
				this.中雨覆羽_羽10_表示 = value;
				this.中雨覆羽_羽9_表示 = value;
				this.中雨覆羽_羽8_表示 = value;
				this.中雨覆羽_羽7_表示 = value;
				this.中雨覆羽_羽6_表示 = value;
				this.中雨覆羽_羽5_表示 = value;
				this.中雨覆羽_羽4_表示 = value;
				this.中雨覆羽_羽3_表示 = value;
				this.中雨覆羽_羽2_表示 = value;
				this.中雨覆羽_羽1_表示 = value;
				this.小雨覆_小雨覆_表示 = value;
				this.小雨覆_竜性_鱗1_表示 = value;
				this.小雨覆_竜性_鱗2_表示 = value;
				this.小雨覆_竜性_鱗3_表示 = value;
				this.小雨覆_竜性_鱗4_表示 = value;
				this.小雨覆_竜性_鱗5_表示 = value;
				this.小雨覆_竜性_鱗6_表示 = value;
				this.小雨覆_竜性_鱗7_表示 = value;
				this.小雨覆_竜性_鱗8_表示 = value;
				this.小雨覆_竜性_鱗9_表示 = value;
				this.腕輪_革_表示 = value;
				this.腕輪_金具1_表示 = value;
				this.腕輪_金具2_表示 = value;
				this.腕輪_金具3_表示 = value;
				this.腕輪_金具左_表示 = value;
				this.腕輪_金具右_表示 = value;
				this.鎖1.表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.鳥翼下腕CD.不透明度;
			}
			set
			{
				this.鳥翼下腕CD.不透明度 = value;
				this.風切羽_羽15CD.不透明度 = value;
				this.風切羽_羽14CD.不透明度 = value;
				this.風切羽_羽13CD.不透明度 = value;
				this.風切羽_羽12CD.不透明度 = value;
				this.風切羽_羽11CD.不透明度 = value;
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
				this.雨覆羽_羽14CD.不透明度 = value;
				this.雨覆羽_羽13CD.不透明度 = value;
				this.雨覆羽_羽12CD.不透明度 = value;
				this.雨覆羽_羽11CD.不透明度 = value;
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
				this.中雨覆羽_羽13CD.不透明度 = value;
				this.中雨覆羽_羽12CD.不透明度 = value;
				this.中雨覆羽_羽11CD.不透明度 = value;
				this.中雨覆羽_羽10CD.不透明度 = value;
				this.中雨覆羽_羽9CD.不透明度 = value;
				this.中雨覆羽_羽8CD.不透明度 = value;
				this.中雨覆羽_羽7CD.不透明度 = value;
				this.中雨覆羽_羽6CD.不透明度 = value;
				this.中雨覆羽_羽5CD.不透明度 = value;
				this.中雨覆羽_羽4CD.不透明度 = value;
				this.中雨覆羽_羽3CD.不透明度 = value;
				this.中雨覆羽_羽2CD.不透明度 = value;
				this.中雨覆羽_羽1CD.不透明度 = value;
				this.小雨覆_小雨覆CD.不透明度 = value;
				this.小雨覆_竜性_鱗1CD.不透明度 = value;
				this.小雨覆_竜性_鱗2CD.不透明度 = value;
				this.小雨覆_竜性_鱗3CD.不透明度 = value;
				this.小雨覆_竜性_鱗4CD.不透明度 = value;
				this.小雨覆_竜性_鱗5CD.不透明度 = value;
				this.小雨覆_竜性_鱗6CD.不透明度 = value;
				this.小雨覆_竜性_鱗7CD.不透明度 = value;
				this.小雨覆_竜性_鱗8CD.不透明度 = value;
				this.小雨覆_竜性_鱗9CD.不透明度 = value;
				this.腕輪_革CD.不透明度 = value;
				this.腕輪_金具1CD.不透明度 = value;
				this.腕輪_金具2CD.不透明度 = value;
				this.腕輪_金具3CD.不透明度 = value;
				this.腕輪_金具左CD.不透明度 = value;
				this.腕輪_金具右CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			double num = this.右 ? -1.0 : 1.0;
			this.X0Y0_鳥翼下腕.AngleBase = num * -341.0;
			this.X0Y0_風切羽_羽1.AngleBase = num * -72.3455557531598;
			this.X0Y0_風切羽_羽2.AngleBase = num * -76.3455557531598;
			this.X0Y0_風切羽_羽3.AngleBase = num * -79.3455557531599;
			this.X0Y0_風切羽_羽4.AngleBase = num * -82.34555575315983;
			this.X0Y0_風切羽_羽5.AngleBase = num * -85.34555575315983;
			this.X0Y0_風切羽_羽6.AngleBase = num * -88.34555575315994;
			this.X0Y0_風切羽_羽7.AngleBase = num * -91.34555575315983;
			this.X0Y0_風切羽_羽8.AngleBase = num * -94.34555575315994;
			this.X0Y0_風切羽_羽9.AngleBase = num * -97.34555575315983;
			this.X0Y0_風切羽_羽10.AngleBase = num * -100.3455557531598;
			this.X0Y0_風切羽_羽11.AngleBase = num * -103.34555575316;
			this.X0Y0_風切羽_羽12.AngleBase = num * -106.3455557531598;
			this.X0Y0_風切羽_羽13.AngleBase = num * 250.654444246839;
			this.X0Y0_風切羽_羽14.AngleBase = num * 247.65444424684;
			this.X0Y0_風切羽_羽15.AngleBase = num * 244.65444424684;
			this.X0Y0_雨覆羽_羽1.AngleBase = num * -61.6335605882607;
			this.X0Y0_雨覆羽_羽2.AngleBase = num * -65.0211000072925;
			this.X0Y0_雨覆羽_羽3.AngleBase = num * -68.6100025846698;
			this.X0Y0_雨覆羽_羽4.AngleBase = num * -72.4094733624345;
			this.X0Y0_雨覆羽_羽5.AngleBase = num * -76.4248591735387;
			this.X0Y0_雨覆羽_羽6.AngleBase = num * -80.65615843821939;
			this.X0Y0_雨覆羽_羽7.AngleBase = num * -85.09647453999872;
			this.X0Y0_雨覆羽_羽8.AngleBase = num * -89.73063451433654;
			this.X0Y0_雨覆羽_羽9.AngleBase = num * -94.53427462319013;
			this.X0Y0_雨覆羽_羽10.AngleBase = num * -99.47372396003561;
			this.X0Y0_雨覆羽_羽11.AngleBase = num * -104.5069529689633;
			this.X0Y0_雨覆羽_羽12.AngleBase = num * 250.41432558095;
			this.X0Y0_雨覆羽_羽13.AngleBase = num * 245.34158111747;
			this.X0Y0_雨覆羽_羽14.AngleBase = num * 240.325859447711;
			this.X0Y0_中雨覆羽_羽1.AngleBase = num * -49.1787166893964;
			this.X0Y0_中雨覆羽_羽2.AngleBase = num * -57.1787166893962;
			this.X0Y0_中雨覆羽_羽3.AngleBase = num * -65.1787166893963;
			this.X0Y0_中雨覆羽_羽4.AngleBase = num * -73.1787166893963;
			this.X0Y0_中雨覆羽_羽5.AngleBase = num * -81.17871668939631;
			this.X0Y0_中雨覆羽_羽6.AngleBase = num * -89.17871668939688;
			this.X0Y0_中雨覆羽_羽7.AngleBase = num * -97.17871668939625;
			this.X0Y0_中雨覆羽_羽8.AngleBase = num * -105.1787166893964;
			this.X0Y0_中雨覆羽_羽9.AngleBase = num * 246.821283310604;
			this.X0Y0_中雨覆羽_羽10.AngleBase = num * 238.821283310604;
			this.X0Y0_中雨覆羽_羽11.AngleBase = num * 230.821283310604;
			this.X0Y0_中雨覆羽_羽12.AngleBase = num * 222.821283310604;
			this.X0Y0_中雨覆羽_羽13.AngleBase = num * 214.821283310604;
			this.本体.JoinPAall();
		}

		public override double 展開
		{
			set
			{
				double num = value.Inverse();
				double num2 = this.右 ? -1.0 : 1.0;
				this.X0Y0_鳥翼下腕.AngleCont = num2 * 120.0 * num;
				this.X0Y0_風切羽_羽1.AngleCont = num2 * -95.0 * num;
				this.X0Y0_風切羽_羽2.AngleCont = num2 * -92.6666666666667 * num;
				this.X0Y0_風切羽_羽3.AngleCont = num2 * -90.3333333333333 * num;
				this.X0Y0_風切羽_羽4.AngleCont = num2 * -88.0 * num;
				this.X0Y0_風切羽_羽5.AngleCont = num2 * -85.6666666666667 * num;
				this.X0Y0_風切羽_羽6.AngleCont = num2 * -83.3333333333334 * num;
				this.X0Y0_風切羽_羽7.AngleCont = num2 * -81.0 * num;
				this.X0Y0_風切羽_羽8.AngleCont = num2 * -78.6666666666667 * num;
				this.X0Y0_風切羽_羽9.AngleCont = num2 * -76.3333333333334 * num;
				this.X0Y0_風切羽_羽10.AngleCont = num2 * -74.0 * num;
				this.X0Y0_風切羽_羽11.AngleCont = num2 * -71.6666666666667 * num;
				this.X0Y0_風切羽_羽12.AngleCont = num2 * -69.3333333333334 * num;
				this.X0Y0_風切羽_羽13.AngleCont = num2 * -67.0000000000001 * num;
				this.X0Y0_風切羽_羽14.AngleCont = num2 * -64.6666666666667 * num;
				this.X0Y0_風切羽_羽15.AngleCont = num2 * -62.3333333333334 * num;
				this.X0Y0_雨覆羽_羽1.AngleCont = num2 * -100.0 * num;
				this.X0Y0_雨覆羽_羽2.AngleCont = num2 * -97.1428571428571 * num;
				this.X0Y0_雨覆羽_羽3.AngleCont = num2 * -94.2857142857143 * num;
				this.X0Y0_雨覆羽_羽4.AngleCont = num2 * -91.4285714285714 * num;
				this.X0Y0_雨覆羽_羽5.AngleCont = num2 * -88.5714285714286 * num;
				this.X0Y0_雨覆羽_羽6.AngleCont = num2 * -85.7142857142857 * num;
				this.X0Y0_雨覆羽_羽7.AngleCont = num2 * -82.8571428571428 * num;
				this.X0Y0_雨覆羽_羽8.AngleCont = num2 * -80.0 * num;
				this.X0Y0_雨覆羽_羽9.AngleCont = num2 * -77.1428571428571 * num;
				this.X0Y0_雨覆羽_羽10.AngleCont = num2 * -74.2857142857142 * num;
				this.X0Y0_雨覆羽_羽11.AngleCont = num2 * -71.4285714285714 * num;
				this.X0Y0_雨覆羽_羽12.AngleCont = num2 * -68.5714285714285 * num;
				this.X0Y0_雨覆羽_羽13.AngleCont = num2 * -65.7142857142857 * num;
				this.X0Y0_雨覆羽_羽14.AngleCont = num2 * -62.8571428571428 * num;
				this.X0Y0_中雨覆羽_羽1.AngleCont = num2 * -110.0 * num;
				this.X0Y0_中雨覆羽_羽2.AngleCont = num2 * -103.076923076923 * num;
				this.X0Y0_中雨覆羽_羽3.AngleCont = num2 * -96.1538461538462 * num;
				this.X0Y0_中雨覆羽_羽4.AngleCont = num2 * -89.2307692307692 * num;
				this.X0Y0_中雨覆羽_羽5.AngleCont = num2 * -82.3076923076923 * num;
				this.X0Y0_中雨覆羽_羽6.AngleCont = num2 * -75.3846153846154 * num;
				this.X0Y0_中雨覆羽_羽7.AngleCont = num2 * -68.4615384615385 * num;
				this.X0Y0_中雨覆羽_羽8.AngleCont = num2 * -61.5384615384616 * num;
				this.X0Y0_中雨覆羽_羽9.AngleCont = num2 * -54.6153846153846 * num;
				this.X0Y0_中雨覆羽_羽10.AngleCont = num2 * -47.6923076923077 * num;
				this.X0Y0_中雨覆羽_羽11.AngleCont = num2 * -40.7692307692308 * num;
				this.X0Y0_中雨覆羽_羽12.AngleCont = num2 * -33.8461538461539 * num;
				this.X0Y0_中雨覆羽_羽13.AngleCont = num2 * -26.923076923077 * num;
			}
		}

		public double シャ\u30FCプ
		{
			set
			{
				double num = 0.05;
				this.X0Y0_風切羽_羽15.SizeYBase *= 1.0 - num * value;
				this.X0Y0_風切羽_羽14.SizeYBase *= 1.0 - num * value;
				this.X0Y0_風切羽_羽13.SizeYBase *= 1.0 - num * value;
				this.X0Y0_風切羽_羽12.SizeYBase *= 1.0 - num * value;
				this.X0Y0_風切羽_羽11.SizeYBase *= 1.0 - num * value;
				this.X0Y0_風切羽_羽10.SizeYBase *= 1.0 - num * value;
				this.X0Y0_風切羽_羽9.SizeYBase *= 1.0 - num * value;
				this.X0Y0_風切羽_羽8.SizeYBase *= 1.0 - num * value;
				this.X0Y0_風切羽_羽7.SizeYBase *= 1.0 - num * value;
				this.X0Y0_風切羽_羽6.SizeYBase *= 1.0 - num * value;
				this.X0Y0_風切羽_羽5.SizeYBase *= 1.0 - num * value;
				this.X0Y0_風切羽_羽4.SizeYBase *= 1.0 - num * value;
				this.X0Y0_風切羽_羽3.SizeYBase *= 1.0 - num * value;
				this.X0Y0_風切羽_羽2.SizeYBase *= 1.0 - num * value;
				this.X0Y0_風切羽_羽1.SizeYBase *= 1.0 - num * value;
			}
		}

		public bool 下腕_外線
		{
			get
			{
				return this.X0Y0_鳥翼下腕.OP[this.右 ? 2 : 1].Outline;
			}
			set
			{
				this.X0Y0_鳥翼下腕.OP[this.右 ? 2 : 1].Outline = value;
				this.X0Y0_鳥翼下腕.OP[this.右 ? 1 : 2].Outline = value;
				this.X0Y0_鳥翼下腕.OP[this.右 ? 0 : 3].Outline = value;
			}
		}

		public bool 小雨覆_外線
		{
			get
			{
				return this.X0Y0_小雨覆_小雨覆.OP[this.右 ? 11 : 2].Outline;
			}
			set
			{
				this.X0Y0_小雨覆_小雨覆.OP[this.右 ? 11 : 2].Outline = value;
				this.X0Y0_小雨覆_小雨覆.OP[this.右 ? 6 : 7].Outline = value;
				this.X0Y0_小雨覆_小雨覆.OP[this.右 ? 4 : 9].Outline = value;
				this.X0Y0_小雨覆_小雨覆.OP[this.右 ? 2 : 11].Outline = value;
			}
		}

		public bool 中雨覆羽_羽1_外線
		{
			get
			{
				return this.X0Y0_中雨覆羽_羽1.OP[this.右 ? 4 : 0].Outline;
			}
			set
			{
				this.X0Y0_中雨覆羽_羽1.OP[this.右 ? 4 : 0].Outline = value;
				this.X0Y0_中雨覆羽_羽1.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_中雨覆羽_羽1.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_中雨覆羽_羽1.OP[this.右 ? 0 : 4].Outline = value;
			}
		}

		public bool 中雨覆羽_羽2_外線
		{
			get
			{
				return this.X0Y0_中雨覆羽_羽2.OP[this.右 ? 4 : 0].Outline;
			}
			set
			{
				this.X0Y0_中雨覆羽_羽2.OP[this.右 ? 4 : 0].Outline = value;
				this.X0Y0_中雨覆羽_羽2.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_中雨覆羽_羽2.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_中雨覆羽_羽2.OP[this.右 ? 0 : 4].Outline = value;
			}
		}

		public bool 中雨覆羽_羽3_外線
		{
			get
			{
				return this.X0Y0_中雨覆羽_羽3.OP[this.右 ? 4 : 0].Outline;
			}
			set
			{
				this.X0Y0_中雨覆羽_羽3.OP[this.右 ? 4 : 0].Outline = value;
				this.X0Y0_中雨覆羽_羽3.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_中雨覆羽_羽3.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_中雨覆羽_羽3.OP[this.右 ? 0 : 4].Outline = value;
			}
		}

		public bool 中雨覆羽_羽4_外線
		{
			get
			{
				return this.X0Y0_中雨覆羽_羽4.OP[this.右 ? 4 : 0].Outline;
			}
			set
			{
				this.X0Y0_中雨覆羽_羽4.OP[this.右 ? 4 : 0].Outline = value;
				this.X0Y0_中雨覆羽_羽4.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_中雨覆羽_羽4.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_中雨覆羽_羽4.OP[this.右 ? 0 : 4].Outline = value;
			}
		}

		public bool 中雨覆羽_羽5_外線
		{
			get
			{
				return this.X0Y0_中雨覆羽_羽5.OP[this.右 ? 4 : 0].Outline;
			}
			set
			{
				this.X0Y0_中雨覆羽_羽5.OP[this.右 ? 4 : 0].Outline = value;
				this.X0Y0_中雨覆羽_羽5.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_中雨覆羽_羽5.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_中雨覆羽_羽5.OP[this.右 ? 0 : 4].Outline = value;
			}
		}

		public bool 中雨覆羽_羽6_外線
		{
			get
			{
				return this.X0Y0_中雨覆羽_羽6.OP[this.右 ? 4 : 0].Outline;
			}
			set
			{
				this.X0Y0_中雨覆羽_羽6.OP[this.右 ? 4 : 0].Outline = value;
				this.X0Y0_中雨覆羽_羽6.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_中雨覆羽_羽6.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_中雨覆羽_羽6.OP[this.右 ? 0 : 4].Outline = value;
			}
		}

		public bool 中雨覆羽_羽7_外線
		{
			get
			{
				return this.X0Y0_中雨覆羽_羽7.OP[this.右 ? 4 : 0].Outline;
			}
			set
			{
				this.X0Y0_中雨覆羽_羽7.OP[this.右 ? 4 : 0].Outline = value;
				this.X0Y0_中雨覆羽_羽7.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_中雨覆羽_羽7.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_中雨覆羽_羽7.OP[this.右 ? 0 : 4].Outline = value;
			}
		}

		public bool 中雨覆羽_羽8_外線
		{
			get
			{
				return this.X0Y0_中雨覆羽_羽8.OP[this.右 ? 4 : 0].Outline;
			}
			set
			{
				this.X0Y0_中雨覆羽_羽8.OP[this.右 ? 4 : 0].Outline = value;
				this.X0Y0_中雨覆羽_羽8.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_中雨覆羽_羽8.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_中雨覆羽_羽8.OP[this.右 ? 0 : 4].Outline = value;
			}
		}

		public bool 中雨覆羽_羽9_外線
		{
			get
			{
				return this.X0Y0_中雨覆羽_羽9.OP[this.右 ? 4 : 0].Outline;
			}
			set
			{
				this.X0Y0_中雨覆羽_羽9.OP[this.右 ? 4 : 0].Outline = value;
				this.X0Y0_中雨覆羽_羽9.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_中雨覆羽_羽9.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_中雨覆羽_羽9.OP[this.右 ? 0 : 4].Outline = value;
			}
		}

		public bool 中雨覆羽_羽10_外線
		{
			get
			{
				return this.X0Y0_中雨覆羽_羽10.OP[this.右 ? 4 : 0].Outline;
			}
			set
			{
				this.X0Y0_中雨覆羽_羽10.OP[this.右 ? 4 : 0].Outline = value;
				this.X0Y0_中雨覆羽_羽10.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_中雨覆羽_羽10.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_中雨覆羽_羽10.OP[this.右 ? 0 : 4].Outline = value;
			}
		}

		public bool 中雨覆羽_羽11_外線
		{
			get
			{
				return this.X0Y0_中雨覆羽_羽11.OP[this.右 ? 4 : 0].Outline;
			}
			set
			{
				this.X0Y0_中雨覆羽_羽11.OP[this.右 ? 4 : 0].Outline = value;
				this.X0Y0_中雨覆羽_羽11.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_中雨覆羽_羽11.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_中雨覆羽_羽11.OP[this.右 ? 0 : 4].Outline = value;
			}
		}

		public bool 中雨覆羽_羽12_外線
		{
			get
			{
				return this.X0Y0_中雨覆羽_羽12.OP[this.右 ? 4 : 0].Outline;
			}
			set
			{
				this.X0Y0_中雨覆羽_羽12.OP[this.右 ? 4 : 0].Outline = value;
				this.X0Y0_中雨覆羽_羽12.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_中雨覆羽_羽12.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_中雨覆羽_羽12.OP[this.右 ? 0 : 4].Outline = value;
			}
		}

		public bool 中雨覆羽_羽13_外線
		{
			get
			{
				return this.X0Y0_中雨覆羽_羽13.OP[this.右 ? 4 : 0].Outline;
			}
			set
			{
				this.X0Y0_中雨覆羽_羽13.OP[this.右 ? 4 : 0].Outline = value;
				this.X0Y0_中雨覆羽_羽13.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_中雨覆羽_羽13.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_中雨覆羽_羽13.OP[this.右 ? 0 : 4].Outline = value;
			}
		}

		public bool 雨覆羽_羽1_外線
		{
			get
			{
				return this.X0Y0_雨覆羽_羽1.OP[this.右 ? 4 : 0].Outline;
			}
			set
			{
				this.X0Y0_雨覆羽_羽1.OP[this.右 ? 4 : 0].Outline = value;
				this.X0Y0_雨覆羽_羽1.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_雨覆羽_羽1.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_雨覆羽_羽1.OP[this.右 ? 0 : 4].Outline = value;
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
				this.X0Y0_雨覆羽_羽10.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_雨覆羽_羽10.OP[this.右 ? 0 : 4].Outline = value;
			}
		}

		public bool 雨覆羽_羽11_外線
		{
			get
			{
				return this.X0Y0_雨覆羽_羽11.OP[this.右 ? 4 : 0].Outline;
			}
			set
			{
				this.X0Y0_雨覆羽_羽11.OP[this.右 ? 4 : 0].Outline = value;
				this.X0Y0_雨覆羽_羽11.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_雨覆羽_羽11.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_雨覆羽_羽11.OP[this.右 ? 0 : 4].Outline = value;
			}
		}

		public bool 雨覆羽_羽12_外線
		{
			get
			{
				return this.X0Y0_雨覆羽_羽12.OP[this.右 ? 4 : 0].Outline;
			}
			set
			{
				this.X0Y0_雨覆羽_羽12.OP[this.右 ? 4 : 0].Outline = value;
				this.X0Y0_雨覆羽_羽12.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_雨覆羽_羽12.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_雨覆羽_羽12.OP[this.右 ? 0 : 4].Outline = value;
			}
		}

		public bool 雨覆羽_羽13_外線
		{
			get
			{
				return this.X0Y0_雨覆羽_羽13.OP[this.右 ? 4 : 0].Outline;
			}
			set
			{
				this.X0Y0_雨覆羽_羽13.OP[this.右 ? 4 : 0].Outline = value;
				this.X0Y0_雨覆羽_羽13.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_雨覆羽_羽13.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_雨覆羽_羽13.OP[this.右 ? 0 : 4].Outline = value;
			}
		}

		public bool 雨覆羽_羽14_外線
		{
			get
			{
				return this.X0Y0_雨覆羽_羽14.OP[this.右 ? 4 : 0].Outline;
			}
			set
			{
				this.X0Y0_雨覆羽_羽14.OP[this.右 ? 4 : 0].Outline = value;
				this.X0Y0_雨覆羽_羽14.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_雨覆羽_羽14.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_雨覆羽_羽14.OP[this.右 ? 0 : 4].Outline = value;
			}
		}

		public bool 風切羽_羽1_外線
		{
			get
			{
				return this.X0Y0_風切羽_羽1.OP[this.右 ? 3 : 1].Outline;
			}
			set
			{
				this.X0Y0_風切羽_羽1.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_風切羽_羽1.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_風切羽_羽1.OP[this.右 ? 0 : 4].Outline = value;
			}
		}

		public bool 風切羽_羽2_外線
		{
			get
			{
				return this.X0Y0_風切羽_羽2.OP[this.右 ? 3 : 1].Outline;
			}
			set
			{
				this.X0Y0_風切羽_羽2.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_風切羽_羽2.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_風切羽_羽2.OP[this.右 ? 0 : 4].Outline = value;
			}
		}

		public bool 風切羽_羽3_外線
		{
			get
			{
				return this.X0Y0_風切羽_羽3.OP[this.右 ? 3 : 1].Outline;
			}
			set
			{
				this.X0Y0_風切羽_羽3.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_風切羽_羽3.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_風切羽_羽3.OP[this.右 ? 0 : 4].Outline = value;
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
				this.X0Y0_風切羽_羽4.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_風切羽_羽4.OP[this.右 ? 0 : 4].Outline = value;
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
				this.X0Y0_風切羽_羽5.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_風切羽_羽5.OP[this.右 ? 0 : 4].Outline = value;
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
				this.X0Y0_風切羽_羽6.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_風切羽_羽6.OP[this.右 ? 0 : 4].Outline = value;
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
				this.X0Y0_風切羽_羽7.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_風切羽_羽7.OP[this.右 ? 0 : 4].Outline = value;
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
				this.X0Y0_風切羽_羽8.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_風切羽_羽8.OP[this.右 ? 0 : 4].Outline = value;
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
				this.X0Y0_風切羽_羽9.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_風切羽_羽9.OP[this.右 ? 0 : 4].Outline = value;
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
				this.X0Y0_風切羽_羽10.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_風切羽_羽10.OP[this.右 ? 0 : 4].Outline = value;
			}
		}

		public bool 風切羽_羽11_外線
		{
			get
			{
				return this.X0Y0_風切羽_羽11.OP[this.右 ? 3 : 1].Outline;
			}
			set
			{
				this.X0Y0_風切羽_羽11.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_風切羽_羽11.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_風切羽_羽11.OP[this.右 ? 0 : 4].Outline = value;
			}
		}

		public bool 風切羽_羽12_外線
		{
			get
			{
				return this.X0Y0_風切羽_羽12.OP[this.右 ? 3 : 1].Outline;
			}
			set
			{
				this.X0Y0_風切羽_羽12.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_風切羽_羽12.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_風切羽_羽12.OP[this.右 ? 0 : 4].Outline = value;
			}
		}

		public bool 風切羽_羽13_外線
		{
			get
			{
				return this.X0Y0_風切羽_羽13.OP[this.右 ? 3 : 1].Outline;
			}
			set
			{
				this.X0Y0_風切羽_羽13.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_風切羽_羽13.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_風切羽_羽13.OP[this.右 ? 0 : 4].Outline = value;
			}
		}

		public bool 風切羽_羽14_外線
		{
			get
			{
				return this.X0Y0_風切羽_羽14.OP[this.右 ? 3 : 1].Outline;
			}
			set
			{
				this.X0Y0_風切羽_羽14.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_風切羽_羽14.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_風切羽_羽14.OP[this.右 ? 0 : 4].Outline = value;
			}
		}

		public bool 風切羽_羽15_外線
		{
			get
			{
				return this.X0Y0_風切羽_羽15.OP[this.右 ? 3 : 1].Outline;
			}
			set
			{
				this.X0Y0_風切羽_羽15.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_風切羽_羽15.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_風切羽_羽15.OP[this.右 ? 0 : 4].Outline = value;
			}
		}

		public override void 描画0(Are Are)
		{
			Are.Draw(this.X0Y0_鳥翼下腕);
			Are.Draw(this.X0Y0_風切羽_羽15);
			Are.Draw(this.X0Y0_風切羽_羽14);
			Are.Draw(this.X0Y0_風切羽_羽13);
			Are.Draw(this.X0Y0_風切羽_羽12);
			Are.Draw(this.X0Y0_風切羽_羽11);
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
			Are.Draw(this.X0Y0_雨覆羽_羽14);
			Are.Draw(this.X0Y0_雨覆羽_羽13);
			Are.Draw(this.X0Y0_雨覆羽_羽12);
			Are.Draw(this.X0Y0_雨覆羽_羽11);
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
			Are.Draw(this.X0Y0_中雨覆羽_羽13);
			Are.Draw(this.X0Y0_中雨覆羽_羽12);
			Are.Draw(this.X0Y0_中雨覆羽_羽11);
			Are.Draw(this.X0Y0_中雨覆羽_羽10);
			Are.Draw(this.X0Y0_中雨覆羽_羽9);
			Are.Draw(this.X0Y0_中雨覆羽_羽8);
			Are.Draw(this.X0Y0_中雨覆羽_羽7);
			Are.Draw(this.X0Y0_中雨覆羽_羽6);
			Are.Draw(this.X0Y0_中雨覆羽_羽5);
			Are.Draw(this.X0Y0_中雨覆羽_羽4);
			Are.Draw(this.X0Y0_中雨覆羽_羽3);
			Are.Draw(this.X0Y0_中雨覆羽_羽2);
			Are.Draw(this.X0Y0_中雨覆羽_羽1);
		}

		public void 小雨覆描画(Are Are)
		{
			Are.Draw(this.X0Y0_小雨覆_小雨覆);
			Are.Draw(this.X0Y0_小雨覆_竜性_鱗1);
			Are.Draw(this.X0Y0_小雨覆_竜性_鱗2);
			Are.Draw(this.X0Y0_小雨覆_竜性_鱗3);
			Are.Draw(this.X0Y0_小雨覆_竜性_鱗4);
			Are.Draw(this.X0Y0_小雨覆_竜性_鱗5);
			Are.Draw(this.X0Y0_小雨覆_竜性_鱗6);
			Are.Draw(this.X0Y0_小雨覆_竜性_鱗7);
			Are.Draw(this.X0Y0_小雨覆_竜性_鱗8);
			Are.Draw(this.X0Y0_小雨覆_竜性_鱗9);
			Are.Draw(this.X0Y0_腕輪_革);
			Are.Draw(this.X0Y0_腕輪_金具1);
			Are.Draw(this.X0Y0_腕輪_金具2);
			Are.Draw(this.X0Y0_腕輪_金具3);
			Are.Draw(this.X0Y0_腕輪_金具左);
			Are.Draw(this.X0Y0_腕輪_金具右);
			this.鎖1.描画0(Are);
		}

		public override bool Is革(Par p)
		{
			return p == this.X0Y0_腕輪_革 || p == this.X0Y0_腕輪_金具1 || p == this.X0Y0_腕輪_金具2 || p == this.X0Y0_腕輪_金具3 || p == this.X0Y0_腕輪_金具左 || p == this.X0Y0_腕輪_金具右;
		}

		public override bool 肘部_外線
		{
			get
			{
				return this.X0Y0_鳥翼下腕.OP[this.右 ? 3 : 0].Outline;
			}
			set
			{
				this.X0Y0_鳥翼下腕.OP[this.右 ? 3 : 0].Outline = value;
			}
		}

		public JointS 手_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_鳥翼下腕, 15);
			}
		}

		public JointS 小雨覆_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_鳥翼下腕, 29);
			}
		}

		public JointS 鎖1_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_腕輪_金具左, 0);
			}
		}

		public JointS 鎖2_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_腕輪_金具右, 0);
			}
		}

		public override void 色更新()
		{
			this.X0Y0_鳥翼下腕CP.Update();
			this.X0Y0_風切羽_羽15CP.Update();
			this.X0Y0_風切羽_羽14CP.Update();
			this.X0Y0_風切羽_羽13CP.Update();
			this.X0Y0_風切羽_羽12CP.Update();
			this.X0Y0_風切羽_羽11CP.Update();
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
			this.X0Y0_雨覆羽_羽14CP.Update();
			this.X0Y0_雨覆羽_羽13CP.Update();
			this.X0Y0_雨覆羽_羽12CP.Update();
			this.X0Y0_雨覆羽_羽11CP.Update();
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
			this.X0Y0_中雨覆羽_羽13CP.Update();
			this.X0Y0_中雨覆羽_羽12CP.Update();
			this.X0Y0_中雨覆羽_羽11CP.Update();
			this.X0Y0_中雨覆羽_羽10CP.Update();
			this.X0Y0_中雨覆羽_羽9CP.Update();
			this.X0Y0_中雨覆羽_羽8CP.Update();
			this.X0Y0_中雨覆羽_羽7CP.Update();
			this.X0Y0_中雨覆羽_羽6CP.Update();
			this.X0Y0_中雨覆羽_羽5CP.Update();
			this.X0Y0_中雨覆羽_羽4CP.Update();
			this.X0Y0_中雨覆羽_羽3CP.Update();
			this.X0Y0_中雨覆羽_羽2CP.Update();
			this.X0Y0_中雨覆羽_羽1CP.Update();
			this.X0Y0_小雨覆_小雨覆CP.Update();
			this.X0Y0_小雨覆_竜性_鱗1CP.Update();
			this.X0Y0_小雨覆_竜性_鱗2CP.Update();
			this.X0Y0_小雨覆_竜性_鱗3CP.Update();
			this.X0Y0_小雨覆_竜性_鱗4CP.Update();
			this.X0Y0_小雨覆_竜性_鱗5CP.Update();
			this.X0Y0_小雨覆_竜性_鱗6CP.Update();
			this.X0Y0_小雨覆_竜性_鱗7CP.Update();
			this.X0Y0_小雨覆_竜性_鱗8CP.Update();
			this.X0Y0_小雨覆_竜性_鱗9CP.Update();
			this.X0Y0_腕輪_革CP.Update();
			this.X0Y0_腕輪_金具1CP.Update();
			this.X0Y0_腕輪_金具2CP.Update();
			this.X0Y0_腕輪_金具3CP.Update();
			this.X0Y0_腕輪_金具左CP.Update();
			this.X0Y0_腕輪_金具右CP.Update();
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
			this.鳥翼下腕CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.風切羽_羽15CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_羽14CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_羽13CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_羽12CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_羽11CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
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
			this.雨覆羽_羽14CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.雨覆羽_羽13CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.雨覆羽_羽12CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.雨覆羽_羽11CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
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
			this.中雨覆羽_羽13CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.中雨覆羽_羽12CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.中雨覆羽_羽11CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.中雨覆羽_羽10CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.中雨覆羽_羽9CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.中雨覆羽_羽8CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.中雨覆羽_羽7CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.中雨覆羽_羽6CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.中雨覆羽_羽5CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.中雨覆羽_羽4CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.中雨覆羽_羽3CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.中雨覆羽_羽2CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.中雨覆羽_羽1CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.小雨覆_小雨覆CD = new ColorD(ref 体配色.髪線, ref 体配色.羽0O);
			this.小雨覆_竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.小雨覆_竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.小雨覆_竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.小雨覆_竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.小雨覆_竜性_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.小雨覆_竜性_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.小雨覆_竜性_鱗7CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.小雨覆_竜性_鱗8CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.小雨覆_竜性_鱗9CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.腕輪_革CD = new ColorD();
			this.腕輪_金具1CD = new ColorD();
			this.腕輪_金具2CD = new ColorD();
			this.腕輪_金具3CD = new ColorD();
			this.腕輪_金具左CD = new ColorD();
			this.腕輪_金具右CD = new ColorD();
		}

		private void 配色T0(体配色 体配色)
		{
			this.鳥翼下腕CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.風切羽_羽15CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.風切羽_羽14CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_羽13CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.風切羽_羽12CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_羽11CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
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
			this.雨覆羽_羽14CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.雨覆羽_羽13CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.雨覆羽_羽12CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.雨覆羽_羽11CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
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
			this.中雨覆羽_羽13CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.中雨覆羽_羽12CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.中雨覆羽_羽11CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.中雨覆羽_羽10CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.中雨覆羽_羽9CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.中雨覆羽_羽8CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.中雨覆羽_羽7CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.中雨覆羽_羽6CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.中雨覆羽_羽5CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.中雨覆羽_羽4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.中雨覆羽_羽3CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.中雨覆羽_羽2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.中雨覆羽_羽1CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.小雨覆_小雨覆CD = new ColorD(ref 体配色.髪線, ref 体配色.羽0O);
			this.小雨覆_竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.小雨覆_竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.小雨覆_竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.小雨覆_竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.小雨覆_竜性_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.小雨覆_竜性_鱗6CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.小雨覆_竜性_鱗7CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.小雨覆_竜性_鱗8CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.小雨覆_竜性_鱗9CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.腕輪_革CD = new ColorD();
			this.腕輪_金具1CD = new ColorD();
			this.腕輪_金具2CD = new ColorD();
			this.腕輪_金具3CD = new ColorD();
			this.腕輪_金具左CD = new ColorD();
			this.腕輪_金具右CD = new ColorD();
		}

		private void 配色T1(体配色 体配色)
		{
			this.鳥翼下腕CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.風切羽_羽15CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_羽14CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.風切羽_羽13CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_羽12CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.風切羽_羽11CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
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
			this.雨覆羽_羽14CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.雨覆羽_羽13CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.雨覆羽_羽12CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.雨覆羽_羽11CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
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
			this.中雨覆羽_羽13CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.中雨覆羽_羽12CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.中雨覆羽_羽11CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.中雨覆羽_羽10CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.中雨覆羽_羽9CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.中雨覆羽_羽8CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.中雨覆羽_羽7CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.中雨覆羽_羽6CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.中雨覆羽_羽5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.中雨覆羽_羽4CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.中雨覆羽_羽3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.中雨覆羽_羽2CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.中雨覆羽_羽1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.小雨覆_小雨覆CD = new ColorD(ref 体配色.髪線, ref 体配色.羽0O);
			this.小雨覆_竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.小雨覆_竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.小雨覆_竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.小雨覆_竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.小雨覆_竜性_鱗5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.小雨覆_竜性_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.小雨覆_竜性_鱗7CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.小雨覆_竜性_鱗8CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.小雨覆_竜性_鱗9CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.腕輪_革CD = new ColorD();
			this.腕輪_金具1CD = new ColorD();
			this.腕輪_金具2CD = new ColorD();
			this.腕輪_金具3CD = new ColorD();
			this.腕輪_金具左CD = new ColorD();
			this.腕輪_金具右CD = new ColorD();
		}

		public void 腕輪配色(拘束具色 配色)
		{
			this.腕輪_革CD.色 = 配色.革部色;
			this.腕輪_金具1CD.色 = 配色.金具色;
			this.腕輪_金具2CD.色 = this.腕輪_金具1CD.色;
			this.腕輪_金具3CD.色 = this.腕輪_金具1CD.色;
			this.腕輪_金具左CD.色 = this.腕輪_金具1CD.色;
			this.腕輪_金具右CD.色 = this.腕輪_金具1CD.色;
		}

		public void 鎖配色(鎖色 配色)
		{
			this.鎖1.配色鎖(配色);
		}

		public Par X0Y0_鳥翼下腕;

		public Par X0Y0_風切羽_羽15;

		public Par X0Y0_風切羽_羽14;

		public Par X0Y0_風切羽_羽13;

		public Par X0Y0_風切羽_羽12;

		public Par X0Y0_風切羽_羽11;

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

		public Par X0Y0_雨覆羽_羽14;

		public Par X0Y0_雨覆羽_羽13;

		public Par X0Y0_雨覆羽_羽12;

		public Par X0Y0_雨覆羽_羽11;

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

		public Par X0Y0_中雨覆羽_羽13;

		public Par X0Y0_中雨覆羽_羽12;

		public Par X0Y0_中雨覆羽_羽11;

		public Par X0Y0_中雨覆羽_羽10;

		public Par X0Y0_中雨覆羽_羽9;

		public Par X0Y0_中雨覆羽_羽8;

		public Par X0Y0_中雨覆羽_羽7;

		public Par X0Y0_中雨覆羽_羽6;

		public Par X0Y0_中雨覆羽_羽5;

		public Par X0Y0_中雨覆羽_羽4;

		public Par X0Y0_中雨覆羽_羽3;

		public Par X0Y0_中雨覆羽_羽2;

		public Par X0Y0_中雨覆羽_羽1;

		public Par X0Y0_小雨覆_小雨覆;

		public Par X0Y0_小雨覆_竜性_鱗1;

		public Par X0Y0_小雨覆_竜性_鱗2;

		public Par X0Y0_小雨覆_竜性_鱗3;

		public Par X0Y0_小雨覆_竜性_鱗4;

		public Par X0Y0_小雨覆_竜性_鱗5;

		public Par X0Y0_小雨覆_竜性_鱗6;

		public Par X0Y0_小雨覆_竜性_鱗7;

		public Par X0Y0_小雨覆_竜性_鱗8;

		public Par X0Y0_小雨覆_竜性_鱗9;

		public Par X0Y0_腕輪_革;

		public Par X0Y0_腕輪_金具1;

		public Par X0Y0_腕輪_金具2;

		public Par X0Y0_腕輪_金具3;

		public Par X0Y0_腕輪_金具左;

		public Par X0Y0_腕輪_金具右;

		public ColorD 鳥翼下腕CD;

		public ColorD 風切羽_羽15CD;

		public ColorD 風切羽_羽14CD;

		public ColorD 風切羽_羽13CD;

		public ColorD 風切羽_羽12CD;

		public ColorD 風切羽_羽11CD;

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

		public ColorD 雨覆羽_羽14CD;

		public ColorD 雨覆羽_羽13CD;

		public ColorD 雨覆羽_羽12CD;

		public ColorD 雨覆羽_羽11CD;

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

		public ColorD 中雨覆羽_羽13CD;

		public ColorD 中雨覆羽_羽12CD;

		public ColorD 中雨覆羽_羽11CD;

		public ColorD 中雨覆羽_羽10CD;

		public ColorD 中雨覆羽_羽9CD;

		public ColorD 中雨覆羽_羽8CD;

		public ColorD 中雨覆羽_羽7CD;

		public ColorD 中雨覆羽_羽6CD;

		public ColorD 中雨覆羽_羽5CD;

		public ColorD 中雨覆羽_羽4CD;

		public ColorD 中雨覆羽_羽3CD;

		public ColorD 中雨覆羽_羽2CD;

		public ColorD 中雨覆羽_羽1CD;

		public ColorD 小雨覆_小雨覆CD;

		public ColorD 小雨覆_竜性_鱗1CD;

		public ColorD 小雨覆_竜性_鱗2CD;

		public ColorD 小雨覆_竜性_鱗3CD;

		public ColorD 小雨覆_竜性_鱗4CD;

		public ColorD 小雨覆_竜性_鱗5CD;

		public ColorD 小雨覆_竜性_鱗6CD;

		public ColorD 小雨覆_竜性_鱗7CD;

		public ColorD 小雨覆_竜性_鱗8CD;

		public ColorD 小雨覆_竜性_鱗9CD;

		public ColorD 腕輪_革CD;

		public ColorD 腕輪_金具1CD;

		public ColorD 腕輪_金具2CD;

		public ColorD 腕輪_金具3CD;

		public ColorD 腕輪_金具左CD;

		public ColorD 腕輪_金具右CD;

		public ColorP X0Y0_鳥翼下腕CP;

		public ColorP X0Y0_風切羽_羽15CP;

		public ColorP X0Y0_風切羽_羽14CP;

		public ColorP X0Y0_風切羽_羽13CP;

		public ColorP X0Y0_風切羽_羽12CP;

		public ColorP X0Y0_風切羽_羽11CP;

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

		public ColorP X0Y0_雨覆羽_羽14CP;

		public ColorP X0Y0_雨覆羽_羽13CP;

		public ColorP X0Y0_雨覆羽_羽12CP;

		public ColorP X0Y0_雨覆羽_羽11CP;

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

		public ColorP X0Y0_中雨覆羽_羽13CP;

		public ColorP X0Y0_中雨覆羽_羽12CP;

		public ColorP X0Y0_中雨覆羽_羽11CP;

		public ColorP X0Y0_中雨覆羽_羽10CP;

		public ColorP X0Y0_中雨覆羽_羽9CP;

		public ColorP X0Y0_中雨覆羽_羽8CP;

		public ColorP X0Y0_中雨覆羽_羽7CP;

		public ColorP X0Y0_中雨覆羽_羽6CP;

		public ColorP X0Y0_中雨覆羽_羽5CP;

		public ColorP X0Y0_中雨覆羽_羽4CP;

		public ColorP X0Y0_中雨覆羽_羽3CP;

		public ColorP X0Y0_中雨覆羽_羽2CP;

		public ColorP X0Y0_中雨覆羽_羽1CP;

		public ColorP X0Y0_小雨覆_小雨覆CP;

		public ColorP X0Y0_小雨覆_竜性_鱗1CP;

		public ColorP X0Y0_小雨覆_竜性_鱗2CP;

		public ColorP X0Y0_小雨覆_竜性_鱗3CP;

		public ColorP X0Y0_小雨覆_竜性_鱗4CP;

		public ColorP X0Y0_小雨覆_竜性_鱗5CP;

		public ColorP X0Y0_小雨覆_竜性_鱗6CP;

		public ColorP X0Y0_小雨覆_竜性_鱗7CP;

		public ColorP X0Y0_小雨覆_竜性_鱗8CP;

		public ColorP X0Y0_小雨覆_竜性_鱗9CP;

		public ColorP X0Y0_腕輪_革CP;

		public ColorP X0Y0_腕輪_金具1CP;

		public ColorP X0Y0_腕輪_金具2CP;

		public ColorP X0Y0_腕輪_金具3CP;

		public ColorP X0Y0_腕輪_金具左CP;

		public ColorP X0Y0_腕輪_金具右CP;

		public 拘束鎖 鎖1;
	}
}
