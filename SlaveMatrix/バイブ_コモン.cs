using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class バイブ_コモン : Ele
	{
		public バイブ_コモン(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, バイブ_コモンD e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.カ\u30FCソル["コモン"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_ヘッド = pars["ヘッド"].ToPar();
			this.X0Y0_イボ1 = pars["イボ1"].ToPar();
			this.X0Y0_イボ2 = pars["イボ2"].ToPar();
			this.X0Y0_イボ3 = pars["イボ3"].ToPar();
			this.X0Y0_イボ4 = pars["イボ4"].ToPar();
			this.X0Y0_イボ5 = pars["イボ5"].ToPar();
			this.X0Y0_イボ6 = pars["イボ6"].ToPar();
			this.X0Y0_イボ7 = pars["イボ7"].ToPar();
			this.X0Y0_イボ8 = pars["イボ8"].ToPar();
			this.X0Y0_イボ9 = pars["イボ9"].ToPar();
			this.X0Y0_イボ10 = pars["イボ10"].ToPar();
			this.X0Y0_イボ11 = pars["イボ11"].ToPar();
			this.X0Y0_イボ12 = pars["イボ12"].ToPar();
			Pars pars2 = pars["ユニット"].ToPars();
			this.X0Y0_ユニット_ユニット = pars2["ユニット"].ToPar();
			this.X0Y0_ユニット_ユニット線上 = pars2["ユニット線上"].ToPar();
			this.X0Y0_ユニット_ユニット線下 = pars2["ユニット線下"].ToPar();
			this.X0Y0_ユニット_ボタン上 = pars2["ボタン上"].ToPar();
			this.X0Y0_ユニット_ボタン下 = pars2["ボタン下"].ToPar();
			this.X0Y0_ユニット_パワ\u30FC根 = pars2["パワー根"].ToPar();
			this.X0Y0_ユニット_パワ\u30FC1 = pars2["パワー1"].ToPar();
			this.X0Y0_ユニット_パワ\u30FC2 = pars2["パワー2"].ToPar();
			this.X0Y0_ユニット_パワ\u30FC3 = pars2["パワー3"].ToPar();
			this.X0Y0_ユニット_パワ\u30FC4 = pars2["パワー4"].ToPar();
			pars = this.本体[0][1];
			this.X0Y1_ヘッド = pars["ヘッド"].ToPar();
			this.X0Y1_イボ1 = pars["イボ1"].ToPar();
			this.X0Y1_イボ2 = pars["イボ2"].ToPar();
			this.X0Y1_イボ3 = pars["イボ3"].ToPar();
			this.X0Y1_イボ4 = pars["イボ4"].ToPar();
			this.X0Y1_イボ5 = pars["イボ5"].ToPar();
			this.X0Y1_イボ6 = pars["イボ6"].ToPar();
			this.X0Y1_イボ7 = pars["イボ7"].ToPar();
			this.X0Y1_イボ8 = pars["イボ8"].ToPar();
			this.X0Y1_イボ9 = pars["イボ9"].ToPar();
			this.X0Y1_イボ10 = pars["イボ10"].ToPar();
			this.X0Y1_イボ11 = pars["イボ11"].ToPar();
			this.X0Y1_イボ12 = pars["イボ12"].ToPar();
			pars2 = pars["ユニット"].ToPars();
			this.X0Y1_ユニット_ユニット = pars2["ユニット"].ToPar();
			this.X0Y1_ユニット_ユニット線上 = pars2["ユニット線上"].ToPar();
			this.X0Y1_ユニット_ユニット線下 = pars2["ユニット線下"].ToPar();
			this.X0Y1_ユニット_ボタン上 = pars2["ボタン上"].ToPar();
			this.X0Y1_ユニット_ボタン下 = pars2["ボタン下"].ToPar();
			this.X0Y1_ユニット_パワ\u30FC根 = pars2["パワー根"].ToPar();
			this.X0Y1_ユニット_パワ\u30FC1 = pars2["パワー1"].ToPar();
			this.X0Y1_ユニット_パワ\u30FC2 = pars2["パワー2"].ToPar();
			this.X0Y1_ユニット_パワ\u30FC3 = pars2["パワー3"].ToPar();
			this.X0Y1_ユニット_パワ\u30FC4 = pars2["パワー4"].ToPar();
			pars = this.本体[0][2];
			this.X0Y2_ヘッド = pars["ヘッド"].ToPar();
			this.X0Y2_イボ1 = pars["イボ1"].ToPar();
			this.X0Y2_イボ2 = pars["イボ2"].ToPar();
			this.X0Y2_イボ3 = pars["イボ3"].ToPar();
			this.X0Y2_イボ4 = pars["イボ4"].ToPar();
			this.X0Y2_イボ5 = pars["イボ5"].ToPar();
			this.X0Y2_イボ6 = pars["イボ6"].ToPar();
			this.X0Y2_イボ7 = pars["イボ7"].ToPar();
			this.X0Y2_イボ8 = pars["イボ8"].ToPar();
			this.X0Y2_イボ9 = pars["イボ9"].ToPar();
			pars2 = pars["ユニット"].ToPars();
			this.X0Y2_ユニット_ユニット = pars2["ユニット"].ToPar();
			this.X0Y2_ユニット_ユニット線上 = pars2["ユニット線上"].ToPar();
			this.X0Y2_ユニット_ユニット線下 = pars2["ユニット線下"].ToPar();
			this.X0Y2_ユニット_ボタン上 = pars2["ボタン上"].ToPar();
			this.X0Y2_ユニット_ボタン下 = pars2["ボタン下"].ToPar();
			this.X0Y2_ユニット_パワ\u30FC根 = pars2["パワー根"].ToPar();
			this.X0Y2_ユニット_パワ\u30FC1 = pars2["パワー1"].ToPar();
			this.X0Y2_ユニット_パワ\u30FC2 = pars2["パワー2"].ToPar();
			this.X0Y2_ユニット_パワ\u30FC3 = pars2["パワー3"].ToPar();
			this.X0Y2_ユニット_パワ\u30FC4 = pars2["パワー4"].ToPar();
			pars = this.本体[0][3];
			this.X0Y3_ヘッド = pars["ヘッド"].ToPar();
			this.X0Y3_イボ1 = pars["イボ1"].ToPar();
			this.X0Y3_イボ2 = pars["イボ2"].ToPar();
			this.X0Y3_イボ3 = pars["イボ3"].ToPar();
			this.X0Y3_イボ4 = pars["イボ4"].ToPar();
			this.X0Y3_イボ5 = pars["イボ5"].ToPar();
			this.X0Y3_イボ6 = pars["イボ6"].ToPar();
			pars2 = pars["ユニット"].ToPars();
			this.X0Y3_ユニット_ユニット = pars2["ユニット"].ToPar();
			this.X0Y3_ユニット_ユニット線上 = pars2["ユニット線上"].ToPar();
			this.X0Y3_ユニット_ユニット線下 = pars2["ユニット線下"].ToPar();
			this.X0Y3_ユニット_ボタン上 = pars2["ボタン上"].ToPar();
			this.X0Y3_ユニット_ボタン下 = pars2["ボタン下"].ToPar();
			this.X0Y3_ユニット_パワ\u30FC根 = pars2["パワー根"].ToPar();
			this.X0Y3_ユニット_パワ\u30FC1 = pars2["パワー1"].ToPar();
			this.X0Y3_ユニット_パワ\u30FC2 = pars2["パワー2"].ToPar();
			this.X0Y3_ユニット_パワ\u30FC3 = pars2["パワー3"].ToPar();
			this.X0Y3_ユニット_パワ\u30FC4 = pars2["パワー4"].ToPar();
			pars = this.本体[0][4];
			this.X0Y4_ヘッド = pars["ヘッド"].ToPar();
			pars2 = pars["ユニット"].ToPars();
			this.X0Y4_ユニット_ユニット = pars2["ユニット"].ToPar();
			this.X0Y4_ユニット_ユニット線上 = pars2["ユニット線上"].ToPar();
			this.X0Y4_ユニット_ユニット線下 = pars2["ユニット線下"].ToPar();
			this.X0Y4_ユニット_ボタン上 = pars2["ボタン上"].ToPar();
			this.X0Y4_ユニット_ボタン下 = pars2["ボタン下"].ToPar();
			this.X0Y4_ユニット_パワ\u30FC根 = pars2["パワー根"].ToPar();
			this.X0Y4_ユニット_パワ\u30FC1 = pars2["パワー1"].ToPar();
			this.X0Y4_ユニット_パワ\u30FC2 = pars2["パワー2"].ToPar();
			this.X0Y4_ユニット_パワ\u30FC3 = pars2["パワー3"].ToPar();
			this.X0Y4_ユニット_パワ\u30FC4 = pars2["パワー4"].ToPar();
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
			this.ヘッド_表示 = e.ヘッド_表示;
			this.イボ1_表示 = e.イボ1_表示;
			this.イボ2_表示 = e.イボ2_表示;
			this.イボ3_表示 = e.イボ3_表示;
			this.イボ4_表示 = e.イボ4_表示;
			this.イボ5_表示 = e.イボ5_表示;
			this.イボ6_表示 = e.イボ6_表示;
			this.イボ7_表示 = e.イボ7_表示;
			this.イボ8_表示 = e.イボ8_表示;
			this.イボ9_表示 = e.イボ9_表示;
			this.イボ10_表示 = e.イボ10_表示;
			this.イボ11_表示 = e.イボ11_表示;
			this.イボ12_表示 = e.イボ12_表示;
			this.ユニット_ユニット_表示 = e.ユニット_ユニット_表示;
			this.ユニット_ユニット線上_表示 = e.ユニット_ユニット線上_表示;
			this.ユニット_ユニット線下_表示 = e.ユニット_ユニット線下_表示;
			this.ユニット_ボタン上_表示 = e.ユニット_ボタン上_表示;
			this.ユニット_ボタン下_表示 = e.ユニット_ボタン下_表示;
			this.ユニット_パワ\u30FC根_表示 = e.ユニット_パワ\u30FC根_表示;
			this.ユニット_パワ\u30FC1_表示 = e.ユニット_パワ\u30FC1_表示;
			this.ユニット_パワ\u30FC2_表示 = e.ユニット_パワ\u30FC2_表示;
			this.ユニット_パワ\u30FC3_表示 = e.ユニット_パワ\u30FC3_表示;
			this.ユニット_パワ\u30FC4_表示 = e.ユニット_パワ\u30FC4_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_ヘッドCP = new ColorP(this.X0Y0_ヘッド, this.ヘッドCD, DisUnit, true);
			this.X0Y0_イボ1CP = new ColorP(this.X0Y0_イボ1, this.イボ1CD, DisUnit, true);
			this.X0Y0_イボ2CP = new ColorP(this.X0Y0_イボ2, this.イボ2CD, DisUnit, true);
			this.X0Y0_イボ3CP = new ColorP(this.X0Y0_イボ3, this.イボ3CD, DisUnit, true);
			this.X0Y0_イボ4CP = new ColorP(this.X0Y0_イボ4, this.イボ4CD, DisUnit, true);
			this.X0Y0_イボ5CP = new ColorP(this.X0Y0_イボ5, this.イボ5CD, DisUnit, true);
			this.X0Y0_イボ6CP = new ColorP(this.X0Y0_イボ6, this.イボ6CD, DisUnit, true);
			this.X0Y0_イボ7CP = new ColorP(this.X0Y0_イボ7, this.イボ7CD, DisUnit, true);
			this.X0Y0_イボ8CP = new ColorP(this.X0Y0_イボ8, this.イボ8CD, DisUnit, true);
			this.X0Y0_イボ9CP = new ColorP(this.X0Y0_イボ9, this.イボ9CD, DisUnit, true);
			this.X0Y0_イボ10CP = new ColorP(this.X0Y0_イボ10, this.イボ10CD, DisUnit, true);
			this.X0Y0_イボ11CP = new ColorP(this.X0Y0_イボ11, this.イボ11CD, DisUnit, true);
			this.X0Y0_イボ12CP = new ColorP(this.X0Y0_イボ12, this.イボ12CD, DisUnit, true);
			this.X0Y0_ユニット_ユニットCP = new ColorP(this.X0Y0_ユニット_ユニット, this.ユニット_ユニットCD, DisUnit, true);
			this.X0Y0_ユニット_ユニット線上CP = new ColorP(this.X0Y0_ユニット_ユニット線上, this.ユニット_ユニット線上CD, DisUnit, true);
			this.X0Y0_ユニット_ユニット線下CP = new ColorP(this.X0Y0_ユニット_ユニット線下, this.ユニット_ユニット線下CD, DisUnit, true);
			this.X0Y0_ユニット_ボタン上CP = new ColorP(this.X0Y0_ユニット_ボタン上, this.ユニット_ボタン上CD, DisUnit, true);
			this.X0Y0_ユニット_ボタン下CP = new ColorP(this.X0Y0_ユニット_ボタン下, this.ユニット_ボタン下CD, DisUnit, true);
			this.X0Y0_ユニット_パワ\u30FC根CP = new ColorP(this.X0Y0_ユニット_パワ\u30FC根, this.ユニット_パワ\u30FC根CD, DisUnit, true);
			this.X0Y0_ユニット_パワ\u30FC1CP = new ColorP(this.X0Y0_ユニット_パワ\u30FC1, this.ユニット_パワ\u30FC1CD, DisUnit, true);
			this.X0Y0_ユニット_パワ\u30FC2CP = new ColorP(this.X0Y0_ユニット_パワ\u30FC2, this.ユニット_パワ\u30FC2CD, DisUnit, true);
			this.X0Y0_ユニット_パワ\u30FC3CP = new ColorP(this.X0Y0_ユニット_パワ\u30FC3, this.ユニット_パワ\u30FC3CD, DisUnit, true);
			this.X0Y0_ユニット_パワ\u30FC4CP = new ColorP(this.X0Y0_ユニット_パワ\u30FC4, this.ユニット_パワ\u30FC4CD, DisUnit, true);
			this.X0Y1_ヘッドCP = new ColorP(this.X0Y1_ヘッド, this.ヘッドCD, DisUnit, true);
			this.X0Y1_イボ1CP = new ColorP(this.X0Y1_イボ1, this.イボ1CD, DisUnit, true);
			this.X0Y1_イボ2CP = new ColorP(this.X0Y1_イボ2, this.イボ2CD, DisUnit, true);
			this.X0Y1_イボ3CP = new ColorP(this.X0Y1_イボ3, this.イボ3CD, DisUnit, true);
			this.X0Y1_イボ4CP = new ColorP(this.X0Y1_イボ4, this.イボ4CD, DisUnit, true);
			this.X0Y1_イボ5CP = new ColorP(this.X0Y1_イボ5, this.イボ5CD, DisUnit, true);
			this.X0Y1_イボ6CP = new ColorP(this.X0Y1_イボ6, this.イボ6CD, DisUnit, true);
			this.X0Y1_イボ7CP = new ColorP(this.X0Y1_イボ7, this.イボ7CD, DisUnit, true);
			this.X0Y1_イボ8CP = new ColorP(this.X0Y1_イボ8, this.イボ8CD, DisUnit, true);
			this.X0Y1_イボ9CP = new ColorP(this.X0Y1_イボ9, this.イボ9CD, DisUnit, true);
			this.X0Y1_イボ10CP = new ColorP(this.X0Y1_イボ10, this.イボ10CD, DisUnit, true);
			this.X0Y1_イボ11CP = new ColorP(this.X0Y1_イボ11, this.イボ11CD, DisUnit, true);
			this.X0Y1_イボ12CP = new ColorP(this.X0Y1_イボ12, this.イボ12CD, DisUnit, true);
			this.X0Y1_ユニット_ユニットCP = new ColorP(this.X0Y1_ユニット_ユニット, this.ユニット_ユニットCD, DisUnit, true);
			this.X0Y1_ユニット_ユニット線上CP = new ColorP(this.X0Y1_ユニット_ユニット線上, this.ユニット_ユニット線上CD, DisUnit, true);
			this.X0Y1_ユニット_ユニット線下CP = new ColorP(this.X0Y1_ユニット_ユニット線下, this.ユニット_ユニット線下CD, DisUnit, true);
			this.X0Y1_ユニット_ボタン上CP = new ColorP(this.X0Y1_ユニット_ボタン上, this.ユニット_ボタン上CD, DisUnit, true);
			this.X0Y1_ユニット_ボタン下CP = new ColorP(this.X0Y1_ユニット_ボタン下, this.ユニット_ボタン下CD, DisUnit, true);
			this.X0Y1_ユニット_パワ\u30FC根CP = new ColorP(this.X0Y1_ユニット_パワ\u30FC根, this.ユニット_パワ\u30FC根CD, DisUnit, true);
			this.X0Y1_ユニット_パワ\u30FC1CP = new ColorP(this.X0Y1_ユニット_パワ\u30FC1, this.ユニット_パワ\u30FC1CD, DisUnit, true);
			this.X0Y1_ユニット_パワ\u30FC2CP = new ColorP(this.X0Y1_ユニット_パワ\u30FC2, this.ユニット_パワ\u30FC2CD, DisUnit, true);
			this.X0Y1_ユニット_パワ\u30FC3CP = new ColorP(this.X0Y1_ユニット_パワ\u30FC3, this.ユニット_パワ\u30FC3CD, DisUnit, true);
			this.X0Y1_ユニット_パワ\u30FC4CP = new ColorP(this.X0Y1_ユニット_パワ\u30FC4, this.ユニット_パワ\u30FC4CD, DisUnit, true);
			this.X0Y2_ヘッドCP = new ColorP(this.X0Y2_ヘッド, this.ヘッドCD, DisUnit, true);
			this.X0Y2_イボ1CP = new ColorP(this.X0Y2_イボ1, this.イボ1CD, DisUnit, true);
			this.X0Y2_イボ2CP = new ColorP(this.X0Y2_イボ2, this.イボ2CD, DisUnit, true);
			this.X0Y2_イボ3CP = new ColorP(this.X0Y2_イボ3, this.イボ3CD, DisUnit, true);
			this.X0Y2_イボ4CP = new ColorP(this.X0Y2_イボ4, this.イボ4CD, DisUnit, true);
			this.X0Y2_イボ5CP = new ColorP(this.X0Y2_イボ5, this.イボ5CD, DisUnit, true);
			this.X0Y2_イボ6CP = new ColorP(this.X0Y2_イボ6, this.イボ6CD, DisUnit, true);
			this.X0Y2_イボ7CP = new ColorP(this.X0Y2_イボ7, this.イボ7CD, DisUnit, true);
			this.X0Y2_イボ8CP = new ColorP(this.X0Y2_イボ8, this.イボ8CD, DisUnit, true);
			this.X0Y2_イボ9CP = new ColorP(this.X0Y2_イボ9, this.イボ9CD, DisUnit, true);
			this.X0Y2_ユニット_ユニットCP = new ColorP(this.X0Y2_ユニット_ユニット, this.ユニット_ユニットCD, DisUnit, true);
			this.X0Y2_ユニット_ユニット線上CP = new ColorP(this.X0Y2_ユニット_ユニット線上, this.ユニット_ユニット線上CD, DisUnit, true);
			this.X0Y2_ユニット_ユニット線下CP = new ColorP(this.X0Y2_ユニット_ユニット線下, this.ユニット_ユニット線下CD, DisUnit, true);
			this.X0Y2_ユニット_ボタン上CP = new ColorP(this.X0Y2_ユニット_ボタン上, this.ユニット_ボタン上CD, DisUnit, true);
			this.X0Y2_ユニット_ボタン下CP = new ColorP(this.X0Y2_ユニット_ボタン下, this.ユニット_ボタン下CD, DisUnit, true);
			this.X0Y2_ユニット_パワ\u30FC根CP = new ColorP(this.X0Y2_ユニット_パワ\u30FC根, this.ユニット_パワ\u30FC根CD, DisUnit, true);
			this.X0Y2_ユニット_パワ\u30FC1CP = new ColorP(this.X0Y2_ユニット_パワ\u30FC1, this.ユニット_パワ\u30FC1CD, DisUnit, true);
			this.X0Y2_ユニット_パワ\u30FC2CP = new ColorP(this.X0Y2_ユニット_パワ\u30FC2, this.ユニット_パワ\u30FC2CD, DisUnit, true);
			this.X0Y2_ユニット_パワ\u30FC3CP = new ColorP(this.X0Y2_ユニット_パワ\u30FC3, this.ユニット_パワ\u30FC3CD, DisUnit, true);
			this.X0Y2_ユニット_パワ\u30FC4CP = new ColorP(this.X0Y2_ユニット_パワ\u30FC4, this.ユニット_パワ\u30FC4CD, DisUnit, true);
			this.X0Y3_ヘッドCP = new ColorP(this.X0Y3_ヘッド, this.ヘッドCD, DisUnit, true);
			this.X0Y3_イボ1CP = new ColorP(this.X0Y3_イボ1, this.イボ1CD, DisUnit, true);
			this.X0Y3_イボ2CP = new ColorP(this.X0Y3_イボ2, this.イボ2CD, DisUnit, true);
			this.X0Y3_イボ3CP = new ColorP(this.X0Y3_イボ3, this.イボ3CD, DisUnit, true);
			this.X0Y3_イボ4CP = new ColorP(this.X0Y3_イボ4, this.イボ4CD, DisUnit, true);
			this.X0Y3_イボ5CP = new ColorP(this.X0Y3_イボ5, this.イボ5CD, DisUnit, true);
			this.X0Y3_イボ6CP = new ColorP(this.X0Y3_イボ6, this.イボ6CD, DisUnit, true);
			this.X0Y3_ユニット_ユニットCP = new ColorP(this.X0Y3_ユニット_ユニット, this.ユニット_ユニットCD, DisUnit, true);
			this.X0Y3_ユニット_ユニット線上CP = new ColorP(this.X0Y3_ユニット_ユニット線上, this.ユニット_ユニット線上CD, DisUnit, true);
			this.X0Y3_ユニット_ユニット線下CP = new ColorP(this.X0Y3_ユニット_ユニット線下, this.ユニット_ユニット線下CD, DisUnit, true);
			this.X0Y3_ユニット_ボタン上CP = new ColorP(this.X0Y3_ユニット_ボタン上, this.ユニット_ボタン上CD, DisUnit, true);
			this.X0Y3_ユニット_ボタン下CP = new ColorP(this.X0Y3_ユニット_ボタン下, this.ユニット_ボタン下CD, DisUnit, true);
			this.X0Y3_ユニット_パワ\u30FC根CP = new ColorP(this.X0Y3_ユニット_パワ\u30FC根, this.ユニット_パワ\u30FC根CD, DisUnit, true);
			this.X0Y3_ユニット_パワ\u30FC1CP = new ColorP(this.X0Y3_ユニット_パワ\u30FC1, this.ユニット_パワ\u30FC1CD, DisUnit, true);
			this.X0Y3_ユニット_パワ\u30FC2CP = new ColorP(this.X0Y3_ユニット_パワ\u30FC2, this.ユニット_パワ\u30FC2CD, DisUnit, true);
			this.X0Y3_ユニット_パワ\u30FC3CP = new ColorP(this.X0Y3_ユニット_パワ\u30FC3, this.ユニット_パワ\u30FC3CD, DisUnit, true);
			this.X0Y3_ユニット_パワ\u30FC4CP = new ColorP(this.X0Y3_ユニット_パワ\u30FC4, this.ユニット_パワ\u30FC4CD, DisUnit, true);
			this.X0Y4_ヘッドCP = new ColorP(this.X0Y4_ヘッド, this.ヘッドCD, DisUnit, true);
			this.X0Y4_ユニット_ユニットCP = new ColorP(this.X0Y4_ユニット_ユニット, this.ユニット_ユニットCD, DisUnit, true);
			this.X0Y4_ユニット_ユニット線上CP = new ColorP(this.X0Y4_ユニット_ユニット線上, this.ユニット_ユニット線上CD, DisUnit, true);
			this.X0Y4_ユニット_ユニット線下CP = new ColorP(this.X0Y4_ユニット_ユニット線下, this.ユニット_ユニット線下CD, DisUnit, true);
			this.X0Y4_ユニット_ボタン上CP = new ColorP(this.X0Y4_ユニット_ボタン上, this.ユニット_ボタン上CD, DisUnit, true);
			this.X0Y4_ユニット_ボタン下CP = new ColorP(this.X0Y4_ユニット_ボタン下, this.ユニット_ボタン下CD, DisUnit, true);
			this.X0Y4_ユニット_パワ\u30FC根CP = new ColorP(this.X0Y4_ユニット_パワ\u30FC根, this.ユニット_パワ\u30FC根CD, DisUnit, true);
			this.X0Y4_ユニット_パワ\u30FC1CP = new ColorP(this.X0Y4_ユニット_パワ\u30FC1, this.ユニット_パワ\u30FC1CD, DisUnit, true);
			this.X0Y4_ユニット_パワ\u30FC2CP = new ColorP(this.X0Y4_ユニット_パワ\u30FC2, this.ユニット_パワ\u30FC2CD, DisUnit, true);
			this.X0Y4_ユニット_パワ\u30FC3CP = new ColorP(this.X0Y4_ユニット_パワ\u30FC3, this.ユニット_パワ\u30FC3CD, DisUnit, true);
			this.X0Y4_ユニット_パワ\u30FC4CP = new ColorP(this.X0Y4_ユニット_パワ\u30FC4, this.ユニット_パワ\u30FC4CD, DisUnit, true);
			this.濃度 = e.濃度;
			this.X0Y0_ユニット_ユニット.BasePointBase = this.X0Y0_ユニット_ユニット.ToLocal(this.X0Y0_ヘッド.ToGlobal(this.X0Y0_ヘッド.JP[12].Joint));
			this.X0Y1_ユニット_ユニット.BasePointBase = this.X0Y1_ユニット_ユニット.ToLocal(this.X0Y1_ヘッド.ToGlobal(this.X0Y1_ヘッド.JP[12].Joint));
			this.X0Y2_ユニット_ユニット.BasePointBase = this.X0Y2_ユニット_ユニット.ToLocal(this.X0Y2_ヘッド.ToGlobal(this.X0Y2_ヘッド.JP[9].Joint));
			this.X0Y3_ユニット_ユニット.BasePointBase = this.X0Y3_ユニット_ユニット.ToLocal(this.X0Y3_ヘッド.ToGlobal(this.X0Y3_ヘッド.JP[6].Joint));
			this.X0Y4_ユニット_ユニット.BasePointBase = this.X0Y4_ユニット_ユニット.ToLocal(this.X0Y4_ヘッド.ToGlobal(this.X0Y4_ヘッド.JP[0].Joint));
			this.尺度B *= 1.07;
			this.尺度B = 1.08;
			this.本体.JoinPAall();
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

		public bool ヘッド_表示
		{
			get
			{
				return this.X0Y0_ヘッド.Dra;
			}
			set
			{
				this.X0Y0_ヘッド.Dra = value;
				this.X0Y1_ヘッド.Dra = value;
				this.X0Y2_ヘッド.Dra = value;
				this.X0Y3_ヘッド.Dra = value;
				this.X0Y4_ヘッド.Dra = value;
				this.X0Y0_ヘッド.Hit = value;
				this.X0Y1_ヘッド.Hit = value;
				this.X0Y2_ヘッド.Hit = value;
				this.X0Y3_ヘッド.Hit = value;
				this.X0Y4_ヘッド.Hit = value;
			}
		}

		public bool イボ1_表示
		{
			get
			{
				return this.X0Y0_イボ1.Dra;
			}
			set
			{
				this.X0Y0_イボ1.Dra = value;
				this.X0Y1_イボ1.Dra = value;
				this.X0Y2_イボ1.Dra = value;
				this.X0Y3_イボ1.Dra = value;
				this.X0Y0_イボ1.Hit = value;
				this.X0Y1_イボ1.Hit = value;
				this.X0Y2_イボ1.Hit = value;
				this.X0Y3_イボ1.Hit = value;
			}
		}

		public bool イボ2_表示
		{
			get
			{
				return this.X0Y0_イボ2.Dra;
			}
			set
			{
				this.X0Y0_イボ2.Dra = value;
				this.X0Y1_イボ2.Dra = value;
				this.X0Y2_イボ2.Dra = value;
				this.X0Y3_イボ2.Dra = value;
				this.X0Y0_イボ2.Hit = value;
				this.X0Y1_イボ2.Hit = value;
				this.X0Y2_イボ2.Hit = value;
				this.X0Y3_イボ2.Hit = value;
			}
		}

		public bool イボ3_表示
		{
			get
			{
				return this.X0Y0_イボ3.Dra;
			}
			set
			{
				this.X0Y0_イボ3.Dra = value;
				this.X0Y1_イボ3.Dra = value;
				this.X0Y2_イボ3.Dra = value;
				this.X0Y3_イボ3.Dra = value;
				this.X0Y0_イボ3.Hit = value;
				this.X0Y1_イボ3.Hit = value;
				this.X0Y2_イボ3.Hit = value;
				this.X0Y3_イボ3.Hit = value;
			}
		}

		public bool イボ4_表示
		{
			get
			{
				return this.X0Y0_イボ4.Dra;
			}
			set
			{
				this.X0Y0_イボ4.Dra = value;
				this.X0Y1_イボ4.Dra = value;
				this.X0Y2_イボ4.Dra = value;
				this.X0Y3_イボ4.Dra = value;
				this.X0Y0_イボ4.Hit = value;
				this.X0Y1_イボ4.Hit = value;
				this.X0Y2_イボ4.Hit = value;
				this.X0Y3_イボ4.Hit = value;
			}
		}

		public bool イボ5_表示
		{
			get
			{
				return this.X0Y0_イボ5.Dra;
			}
			set
			{
				this.X0Y0_イボ5.Dra = value;
				this.X0Y1_イボ5.Dra = value;
				this.X0Y2_イボ5.Dra = value;
				this.X0Y3_イボ5.Dra = value;
				this.X0Y0_イボ5.Hit = value;
				this.X0Y1_イボ5.Hit = value;
				this.X0Y2_イボ5.Hit = value;
				this.X0Y3_イボ5.Hit = value;
			}
		}

		public bool イボ6_表示
		{
			get
			{
				return this.X0Y0_イボ6.Dra;
			}
			set
			{
				this.X0Y0_イボ6.Dra = value;
				this.X0Y1_イボ6.Dra = value;
				this.X0Y2_イボ6.Dra = value;
				this.X0Y3_イボ6.Dra = value;
				this.X0Y0_イボ6.Hit = value;
				this.X0Y1_イボ6.Hit = value;
				this.X0Y2_イボ6.Hit = value;
				this.X0Y3_イボ6.Hit = value;
			}
		}

		public bool イボ7_表示
		{
			get
			{
				return this.X0Y0_イボ7.Dra;
			}
			set
			{
				this.X0Y0_イボ7.Dra = value;
				this.X0Y1_イボ7.Dra = value;
				this.X0Y2_イボ7.Dra = value;
				this.X0Y0_イボ7.Hit = value;
				this.X0Y1_イボ7.Hit = value;
				this.X0Y2_イボ7.Hit = value;
			}
		}

		public bool イボ8_表示
		{
			get
			{
				return this.X0Y0_イボ8.Dra;
			}
			set
			{
				this.X0Y0_イボ8.Dra = value;
				this.X0Y1_イボ8.Dra = value;
				this.X0Y2_イボ8.Dra = value;
				this.X0Y0_イボ8.Hit = value;
				this.X0Y1_イボ8.Hit = value;
				this.X0Y2_イボ8.Hit = value;
			}
		}

		public bool イボ9_表示
		{
			get
			{
				return this.X0Y0_イボ9.Dra;
			}
			set
			{
				this.X0Y0_イボ9.Dra = value;
				this.X0Y1_イボ9.Dra = value;
				this.X0Y2_イボ9.Dra = value;
				this.X0Y0_イボ9.Hit = value;
				this.X0Y1_イボ9.Hit = value;
				this.X0Y2_イボ9.Hit = value;
			}
		}

		public bool イボ10_表示
		{
			get
			{
				return this.X0Y0_イボ10.Dra;
			}
			set
			{
				this.X0Y0_イボ10.Dra = value;
				this.X0Y1_イボ10.Dra = value;
				this.X0Y0_イボ10.Hit = value;
				this.X0Y1_イボ10.Hit = value;
			}
		}

		public bool イボ11_表示
		{
			get
			{
				return this.X0Y0_イボ11.Dra;
			}
			set
			{
				this.X0Y0_イボ11.Dra = value;
				this.X0Y1_イボ11.Dra = value;
				this.X0Y0_イボ11.Hit = value;
				this.X0Y1_イボ11.Hit = value;
			}
		}

		public bool イボ12_表示
		{
			get
			{
				return this.X0Y0_イボ12.Dra;
			}
			set
			{
				this.X0Y0_イボ12.Dra = value;
				this.X0Y1_イボ12.Dra = value;
				this.X0Y0_イボ12.Hit = value;
				this.X0Y1_イボ12.Hit = value;
			}
		}

		public bool ユニット_ユニット_表示
		{
			get
			{
				return this.X0Y0_ユニット_ユニット.Dra;
			}
			set
			{
				this.X0Y0_ユニット_ユニット.Dra = value;
				this.X0Y1_ユニット_ユニット.Dra = value;
				this.X0Y2_ユニット_ユニット.Dra = value;
				this.X0Y3_ユニット_ユニット.Dra = value;
				this.X0Y4_ユニット_ユニット.Dra = value;
				this.X0Y0_ユニット_ユニット.Hit = value;
				this.X0Y1_ユニット_ユニット.Hit = value;
				this.X0Y2_ユニット_ユニット.Hit = value;
				this.X0Y3_ユニット_ユニット.Hit = value;
				this.X0Y4_ユニット_ユニット.Hit = value;
			}
		}

		public bool ユニット_ユニット線上_表示
		{
			get
			{
				return this.X0Y0_ユニット_ユニット線上.Dra;
			}
			set
			{
				this.X0Y0_ユニット_ユニット線上.Dra = value;
				this.X0Y1_ユニット_ユニット線上.Dra = value;
				this.X0Y2_ユニット_ユニット線上.Dra = value;
				this.X0Y3_ユニット_ユニット線上.Dra = value;
				this.X0Y4_ユニット_ユニット線上.Dra = value;
				this.X0Y0_ユニット_ユニット線上.Hit = value;
				this.X0Y1_ユニット_ユニット線上.Hit = value;
				this.X0Y2_ユニット_ユニット線上.Hit = value;
				this.X0Y3_ユニット_ユニット線上.Hit = value;
				this.X0Y4_ユニット_ユニット線上.Hit = value;
			}
		}

		public bool ユニット_ユニット線下_表示
		{
			get
			{
				return this.X0Y0_ユニット_ユニット線下.Dra;
			}
			set
			{
				this.X0Y0_ユニット_ユニット線下.Dra = value;
				this.X0Y1_ユニット_ユニット線下.Dra = value;
				this.X0Y2_ユニット_ユニット線下.Dra = value;
				this.X0Y3_ユニット_ユニット線下.Dra = value;
				this.X0Y4_ユニット_ユニット線下.Dra = value;
				this.X0Y0_ユニット_ユニット線下.Hit = value;
				this.X0Y1_ユニット_ユニット線下.Hit = value;
				this.X0Y2_ユニット_ユニット線下.Hit = value;
				this.X0Y3_ユニット_ユニット線下.Hit = value;
				this.X0Y4_ユニット_ユニット線下.Hit = value;
			}
		}

		public bool ユニット_ボタン上_表示
		{
			get
			{
				return this.X0Y0_ユニット_ボタン上.Dra;
			}
			set
			{
				this.X0Y0_ユニット_ボタン上.Dra = value;
				this.X0Y1_ユニット_ボタン上.Dra = value;
				this.X0Y2_ユニット_ボタン上.Dra = value;
				this.X0Y3_ユニット_ボタン上.Dra = value;
				this.X0Y4_ユニット_ボタン上.Dra = value;
				this.X0Y0_ユニット_ボタン上.Hit = value;
				this.X0Y1_ユニット_ボタン上.Hit = value;
				this.X0Y2_ユニット_ボタン上.Hit = value;
				this.X0Y3_ユニット_ボタン上.Hit = value;
				this.X0Y4_ユニット_ボタン上.Hit = value;
			}
		}

		public bool ユニット_ボタン下_表示
		{
			get
			{
				return this.X0Y0_ユニット_ボタン下.Dra;
			}
			set
			{
				this.X0Y0_ユニット_ボタン下.Dra = value;
				this.X0Y1_ユニット_ボタン下.Dra = value;
				this.X0Y2_ユニット_ボタン下.Dra = value;
				this.X0Y3_ユニット_ボタン下.Dra = value;
				this.X0Y4_ユニット_ボタン下.Dra = value;
				this.X0Y0_ユニット_ボタン下.Hit = value;
				this.X0Y1_ユニット_ボタン下.Hit = value;
				this.X0Y2_ユニット_ボタン下.Hit = value;
				this.X0Y3_ユニット_ボタン下.Hit = value;
				this.X0Y4_ユニット_ボタン下.Hit = value;
			}
		}

		public bool ユニット_パワ\u30FC根_表示
		{
			get
			{
				return this.X0Y0_ユニット_パワ\u30FC根.Dra;
			}
			set
			{
				this.X0Y0_ユニット_パワ\u30FC根.Dra = value;
				this.X0Y1_ユニット_パワ\u30FC根.Dra = value;
				this.X0Y2_ユニット_パワ\u30FC根.Dra = value;
				this.X0Y3_ユニット_パワ\u30FC根.Dra = value;
				this.X0Y4_ユニット_パワ\u30FC根.Dra = value;
				this.X0Y0_ユニット_パワ\u30FC根.Hit = value;
				this.X0Y1_ユニット_パワ\u30FC根.Hit = value;
				this.X0Y2_ユニット_パワ\u30FC根.Hit = value;
				this.X0Y3_ユニット_パワ\u30FC根.Hit = value;
				this.X0Y4_ユニット_パワ\u30FC根.Hit = value;
			}
		}

		public bool ユニット_パワ\u30FC1_表示
		{
			get
			{
				return this.X0Y0_ユニット_パワ\u30FC1.Dra;
			}
			set
			{
				this.X0Y0_ユニット_パワ\u30FC1.Dra = value;
				this.X0Y1_ユニット_パワ\u30FC1.Dra = value;
				this.X0Y2_ユニット_パワ\u30FC1.Dra = value;
				this.X0Y3_ユニット_パワ\u30FC1.Dra = value;
				this.X0Y4_ユニット_パワ\u30FC1.Dra = value;
				this.X0Y0_ユニット_パワ\u30FC1.Hit = value;
				this.X0Y1_ユニット_パワ\u30FC1.Hit = value;
				this.X0Y2_ユニット_パワ\u30FC1.Hit = value;
				this.X0Y3_ユニット_パワ\u30FC1.Hit = value;
				this.X0Y4_ユニット_パワ\u30FC1.Hit = value;
			}
		}

		public bool ユニット_パワ\u30FC2_表示
		{
			get
			{
				return this.X0Y0_ユニット_パワ\u30FC2.Dra;
			}
			set
			{
				this.X0Y0_ユニット_パワ\u30FC2.Dra = value;
				this.X0Y1_ユニット_パワ\u30FC2.Dra = value;
				this.X0Y2_ユニット_パワ\u30FC2.Dra = value;
				this.X0Y3_ユニット_パワ\u30FC2.Dra = value;
				this.X0Y4_ユニット_パワ\u30FC2.Dra = value;
				this.X0Y0_ユニット_パワ\u30FC2.Hit = value;
				this.X0Y1_ユニット_パワ\u30FC2.Hit = value;
				this.X0Y2_ユニット_パワ\u30FC2.Hit = value;
				this.X0Y3_ユニット_パワ\u30FC2.Hit = value;
				this.X0Y4_ユニット_パワ\u30FC2.Hit = value;
			}
		}

		public bool ユニット_パワ\u30FC3_表示
		{
			get
			{
				return this.X0Y0_ユニット_パワ\u30FC3.Dra;
			}
			set
			{
				this.X0Y0_ユニット_パワ\u30FC3.Dra = value;
				this.X0Y1_ユニット_パワ\u30FC3.Dra = value;
				this.X0Y2_ユニット_パワ\u30FC3.Dra = value;
				this.X0Y3_ユニット_パワ\u30FC3.Dra = value;
				this.X0Y4_ユニット_パワ\u30FC3.Dra = value;
				this.X0Y0_ユニット_パワ\u30FC3.Hit = value;
				this.X0Y1_ユニット_パワ\u30FC3.Hit = value;
				this.X0Y2_ユニット_パワ\u30FC3.Hit = value;
				this.X0Y3_ユニット_パワ\u30FC3.Hit = value;
				this.X0Y4_ユニット_パワ\u30FC3.Hit = value;
			}
		}

		public bool ユニット_パワ\u30FC4_表示
		{
			get
			{
				return this.X0Y0_ユニット_パワ\u30FC4.Dra;
			}
			set
			{
				this.X0Y0_ユニット_パワ\u30FC4.Dra = value;
				this.X0Y1_ユニット_パワ\u30FC4.Dra = value;
				this.X0Y2_ユニット_パワ\u30FC4.Dra = value;
				this.X0Y3_ユニット_パワ\u30FC4.Dra = value;
				this.X0Y4_ユニット_パワ\u30FC4.Dra = value;
				this.X0Y0_ユニット_パワ\u30FC4.Hit = value;
				this.X0Y1_ユニット_パワ\u30FC4.Hit = value;
				this.X0Y2_ユニット_パワ\u30FC4.Hit = value;
				this.X0Y3_ユニット_パワ\u30FC4.Hit = value;
				this.X0Y4_ユニット_パワ\u30FC4.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.ヘッド_表示;
			}
			set
			{
				this.ヘッド_表示 = value;
				this.イボ1_表示 = value;
				this.イボ2_表示 = value;
				this.イボ3_表示 = value;
				this.イボ4_表示 = value;
				this.イボ5_表示 = value;
				this.イボ6_表示 = value;
				this.イボ7_表示 = value;
				this.イボ8_表示 = value;
				this.イボ9_表示 = value;
				this.イボ10_表示 = value;
				this.イボ11_表示 = value;
				this.イボ12_表示 = value;
				this.ユニット_ユニット_表示 = value;
				this.ユニット_ユニット線上_表示 = value;
				this.ユニット_ユニット線下_表示 = value;
				this.ユニット_ボタン上_表示 = value;
				this.ユニット_ボタン下_表示 = value;
				this.ユニット_パワ\u30FC根_表示 = value;
				this.ユニット_パワ\u30FC1_表示 = value;
				this.ユニット_パワ\u30FC2_表示 = value;
				this.ユニット_パワ\u30FC3_表示 = value;
				this.ユニット_パワ\u30FC4_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.ヘッドCD.不透明度;
			}
			set
			{
				this.ヘッドCD.不透明度 = value;
				this.イボ1CD.不透明度 = value;
				this.イボ2CD.不透明度 = value;
				this.イボ3CD.不透明度 = value;
				this.イボ4CD.不透明度 = value;
				this.イボ5CD.不透明度 = value;
				this.イボ6CD.不透明度 = value;
				this.イボ7CD.不透明度 = value;
				this.イボ8CD.不透明度 = value;
				this.イボ9CD.不透明度 = value;
				this.イボ10CD.不透明度 = value;
				this.イボ11CD.不透明度 = value;
				this.イボ12CD.不透明度 = value;
				this.ユニット_ユニットCD.不透明度 = value;
				this.ユニット_ユニット線上CD.不透明度 = value;
				this.ユニット_ユニット線下CD.不透明度 = value;
				this.ユニット_ボタン上CD.不透明度 = value;
				this.ユニット_ボタン下CD.不透明度 = value;
				this.ユニット_パワ\u30FC根CD.不透明度 = value;
				this.ユニット_パワ\u30FC1CD.不透明度 = value;
				this.ユニット_パワ\u30FC2CD.不透明度 = value;
				this.ユニット_パワ\u30FC3CD.不透明度 = value;
				this.ユニット_パワ\u30FC4CD.不透明度 = value;
			}
		}

		public override void 色更新()
		{
			switch (this.本体.IndexY)
			{
			case 0:
				this.X0Y0_ヘッドCP.Update();
				this.X0Y0_イボ1CP.Update();
				this.X0Y0_イボ2CP.Update();
				this.X0Y0_イボ3CP.Update();
				this.X0Y0_イボ4CP.Update();
				this.X0Y0_イボ5CP.Update();
				this.X0Y0_イボ6CP.Update();
				this.X0Y0_イボ7CP.Update();
				this.X0Y0_イボ8CP.Update();
				this.X0Y0_イボ9CP.Update();
				this.X0Y0_イボ10CP.Update();
				this.X0Y0_イボ11CP.Update();
				this.X0Y0_イボ12CP.Update();
				this.X0Y0_ユニット_ユニットCP.Update();
				this.X0Y0_ユニット_ユニット線上CP.Update();
				this.X0Y0_ユニット_ユニット線下CP.Update();
				this.X0Y0_ユニット_ボタン上CP.Update();
				this.X0Y0_ユニット_ボタン下CP.Update();
				this.X0Y0_ユニット_パワ\u30FC根CP.Update();
				this.X0Y0_ユニット_パワ\u30FC1CP.Update();
				this.X0Y0_ユニット_パワ\u30FC2CP.Update();
				this.X0Y0_ユニット_パワ\u30FC3CP.Update();
				this.X0Y0_ユニット_パワ\u30FC4CP.Update();
				return;
			case 1:
				this.X0Y1_ヘッドCP.Update();
				this.X0Y1_イボ1CP.Update();
				this.X0Y1_イボ2CP.Update();
				this.X0Y1_イボ3CP.Update();
				this.X0Y1_イボ4CP.Update();
				this.X0Y1_イボ5CP.Update();
				this.X0Y1_イボ6CP.Update();
				this.X0Y1_イボ7CP.Update();
				this.X0Y1_イボ8CP.Update();
				this.X0Y1_イボ9CP.Update();
				this.X0Y1_イボ10CP.Update();
				this.X0Y1_イボ11CP.Update();
				this.X0Y1_イボ12CP.Update();
				this.X0Y1_ユニット_ユニットCP.Update();
				this.X0Y1_ユニット_ユニット線上CP.Update();
				this.X0Y1_ユニット_ユニット線下CP.Update();
				this.X0Y1_ユニット_ボタン上CP.Update();
				this.X0Y1_ユニット_ボタン下CP.Update();
				this.X0Y1_ユニット_パワ\u30FC根CP.Update();
				this.X0Y1_ユニット_パワ\u30FC1CP.Update();
				this.X0Y1_ユニット_パワ\u30FC2CP.Update();
				this.X0Y1_ユニット_パワ\u30FC3CP.Update();
				this.X0Y1_ユニット_パワ\u30FC4CP.Update();
				return;
			case 2:
				this.X0Y2_ヘッドCP.Update();
				this.X0Y2_イボ1CP.Update();
				this.X0Y2_イボ2CP.Update();
				this.X0Y2_イボ3CP.Update();
				this.X0Y2_イボ4CP.Update();
				this.X0Y2_イボ5CP.Update();
				this.X0Y2_イボ6CP.Update();
				this.X0Y2_イボ7CP.Update();
				this.X0Y2_イボ8CP.Update();
				this.X0Y2_イボ9CP.Update();
				this.X0Y2_ユニット_ユニットCP.Update();
				this.X0Y2_ユニット_ユニット線上CP.Update();
				this.X0Y2_ユニット_ユニット線下CP.Update();
				this.X0Y2_ユニット_ボタン上CP.Update();
				this.X0Y2_ユニット_ボタン下CP.Update();
				this.X0Y2_ユニット_パワ\u30FC根CP.Update();
				this.X0Y2_ユニット_パワ\u30FC1CP.Update();
				this.X0Y2_ユニット_パワ\u30FC2CP.Update();
				this.X0Y2_ユニット_パワ\u30FC3CP.Update();
				this.X0Y2_ユニット_パワ\u30FC4CP.Update();
				return;
			case 3:
				this.X0Y3_ヘッドCP.Update();
				this.X0Y3_イボ1CP.Update();
				this.X0Y3_イボ2CP.Update();
				this.X0Y3_イボ3CP.Update();
				this.X0Y3_イボ4CP.Update();
				this.X0Y3_イボ5CP.Update();
				this.X0Y3_イボ6CP.Update();
				this.X0Y3_ユニット_ユニットCP.Update();
				this.X0Y3_ユニット_ユニット線上CP.Update();
				this.X0Y3_ユニット_ユニット線下CP.Update();
				this.X0Y3_ユニット_ボタン上CP.Update();
				this.X0Y3_ユニット_ボタン下CP.Update();
				this.X0Y3_ユニット_パワ\u30FC根CP.Update();
				this.X0Y3_ユニット_パワ\u30FC1CP.Update();
				this.X0Y3_ユニット_パワ\u30FC2CP.Update();
				this.X0Y3_ユニット_パワ\u30FC3CP.Update();
				this.X0Y3_ユニット_パワ\u30FC4CP.Update();
				return;
			default:
				this.X0Y4_ヘッドCP.Update();
				this.X0Y4_ユニット_ユニットCP.Update();
				this.X0Y4_ユニット_ユニット線上CP.Update();
				this.X0Y4_ユニット_ユニット線下CP.Update();
				this.X0Y4_ユニット_ボタン上CP.Update();
				this.X0Y4_ユニット_ボタン下CP.Update();
				this.X0Y4_ユニット_パワ\u30FC根CP.Update();
				this.X0Y4_ユニット_パワ\u30FC1CP.Update();
				this.X0Y4_ユニット_パワ\u30FC2CP.Update();
				this.X0Y4_ユニット_パワ\u30FC3CP.Update();
				this.X0Y4_ユニット_パワ\u30FC4CP.Update();
				return;
			}
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			Color2 color;
			Col.GetGrad(ref Col.HotPink, out color);
			this.ヘッドCD = new ColorD(ref Col.Black, ref color);
			this.イボ1CD = new ColorD(ref Col.Black, ref color);
			this.イボ2CD = new ColorD(ref Col.Black, ref color);
			this.イボ3CD = new ColorD(ref Col.Black, ref color);
			this.イボ4CD = new ColorD(ref Col.Black, ref color);
			this.イボ5CD = new ColorD(ref Col.Black, ref color);
			this.イボ6CD = new ColorD(ref Col.Black, ref color);
			this.イボ7CD = new ColorD(ref Col.Black, ref color);
			this.イボ8CD = new ColorD(ref Col.Black, ref color);
			this.イボ9CD = new ColorD(ref Col.Black, ref color);
			this.イボ10CD = new ColorD(ref Col.Black, ref color);
			this.イボ11CD = new ColorD(ref Col.Black, ref color);
			this.イボ12CD = new ColorD(ref Col.Black, ref color);
			Col.GetGrad(ref Col.Silver, out color);
			this.ユニット_ユニットCD = new ColorD(ref Col.Black, ref color);
			this.ユニット_ユニット線上CD = new ColorD(ref Col.Black, ref color);
			this.ユニット_ユニット線下CD = new ColorD(ref Col.Black, ref color);
			this.ユニット_ボタン上CD = new ColorD(ref Col.Black, ref color);
			this.ユニット_ボタン下CD = new ColorD(ref Col.Black, ref color);
			this.ユニット_パワ\u30FC根CD = new ColorD(ref Col.Black, ref color);
			this.ユニット_パワ\u30FC1CD = new ColorD(ref Col.Black, ref color);
			this.ユニット_パワ\u30FC2CD = new ColorD(ref Col.Black, ref color);
			this.ユニット_パワ\u30FC3CD = new ColorD(ref Col.Black, ref color);
			this.ユニット_パワ\u30FC4CD = new ColorD(ref Col.Black, ref color);
		}

		public Par X0Y0_ヘッド;

		public Par X0Y0_イボ1;

		public Par X0Y0_イボ2;

		public Par X0Y0_イボ3;

		public Par X0Y0_イボ4;

		public Par X0Y0_イボ5;

		public Par X0Y0_イボ6;

		public Par X0Y0_イボ7;

		public Par X0Y0_イボ8;

		public Par X0Y0_イボ9;

		public Par X0Y0_イボ10;

		public Par X0Y0_イボ11;

		public Par X0Y0_イボ12;

		public Par X0Y0_ユニット_ユニット;

		public Par X0Y0_ユニット_ユニット線上;

		public Par X0Y0_ユニット_ユニット線下;

		public Par X0Y0_ユニット_ボタン上;

		public Par X0Y0_ユニット_ボタン下;

		public Par X0Y0_ユニット_パワ\u30FC根;

		public Par X0Y0_ユニット_パワ\u30FC1;

		public Par X0Y0_ユニット_パワ\u30FC2;

		public Par X0Y0_ユニット_パワ\u30FC3;

		public Par X0Y0_ユニット_パワ\u30FC4;

		public Par X0Y1_ヘッド;

		public Par X0Y1_イボ1;

		public Par X0Y1_イボ2;

		public Par X0Y1_イボ3;

		public Par X0Y1_イボ4;

		public Par X0Y1_イボ5;

		public Par X0Y1_イボ6;

		public Par X0Y1_イボ7;

		public Par X0Y1_イボ8;

		public Par X0Y1_イボ9;

		public Par X0Y1_イボ10;

		public Par X0Y1_イボ11;

		public Par X0Y1_イボ12;

		public Par X0Y1_ユニット_ユニット;

		public Par X0Y1_ユニット_ユニット線上;

		public Par X0Y1_ユニット_ユニット線下;

		public Par X0Y1_ユニット_ボタン上;

		public Par X0Y1_ユニット_ボタン下;

		public Par X0Y1_ユニット_パワ\u30FC根;

		public Par X0Y1_ユニット_パワ\u30FC1;

		public Par X0Y1_ユニット_パワ\u30FC2;

		public Par X0Y1_ユニット_パワ\u30FC3;

		public Par X0Y1_ユニット_パワ\u30FC4;

		public Par X0Y2_ヘッド;

		public Par X0Y2_イボ1;

		public Par X0Y2_イボ2;

		public Par X0Y2_イボ3;

		public Par X0Y2_イボ4;

		public Par X0Y2_イボ5;

		public Par X0Y2_イボ6;

		public Par X0Y2_イボ7;

		public Par X0Y2_イボ8;

		public Par X0Y2_イボ9;

		public Par X0Y2_ユニット_ユニット;

		public Par X0Y2_ユニット_ユニット線上;

		public Par X0Y2_ユニット_ユニット線下;

		public Par X0Y2_ユニット_ボタン上;

		public Par X0Y2_ユニット_ボタン下;

		public Par X0Y2_ユニット_パワ\u30FC根;

		public Par X0Y2_ユニット_パワ\u30FC1;

		public Par X0Y2_ユニット_パワ\u30FC2;

		public Par X0Y2_ユニット_パワ\u30FC3;

		public Par X0Y2_ユニット_パワ\u30FC4;

		public Par X0Y3_ヘッド;

		public Par X0Y3_イボ1;

		public Par X0Y3_イボ2;

		public Par X0Y3_イボ3;

		public Par X0Y3_イボ4;

		public Par X0Y3_イボ5;

		public Par X0Y3_イボ6;

		public Par X0Y3_ユニット_ユニット;

		public Par X0Y3_ユニット_ユニット線上;

		public Par X0Y3_ユニット_ユニット線下;

		public Par X0Y3_ユニット_ボタン上;

		public Par X0Y3_ユニット_ボタン下;

		public Par X0Y3_ユニット_パワ\u30FC根;

		public Par X0Y3_ユニット_パワ\u30FC1;

		public Par X0Y3_ユニット_パワ\u30FC2;

		public Par X0Y3_ユニット_パワ\u30FC3;

		public Par X0Y3_ユニット_パワ\u30FC4;

		public Par X0Y4_ヘッド;

		public Par X0Y4_ユニット_ユニット;

		public Par X0Y4_ユニット_ユニット線上;

		public Par X0Y4_ユニット_ユニット線下;

		public Par X0Y4_ユニット_ボタン上;

		public Par X0Y4_ユニット_ボタン下;

		public Par X0Y4_ユニット_パワ\u30FC根;

		public Par X0Y4_ユニット_パワ\u30FC1;

		public Par X0Y4_ユニット_パワ\u30FC2;

		public Par X0Y4_ユニット_パワ\u30FC3;

		public Par X0Y4_ユニット_パワ\u30FC4;

		public ColorD ヘッドCD;

		public ColorD イボ1CD;

		public ColorD イボ2CD;

		public ColorD イボ3CD;

		public ColorD イボ4CD;

		public ColorD イボ5CD;

		public ColorD イボ6CD;

		public ColorD イボ7CD;

		public ColorD イボ8CD;

		public ColorD イボ9CD;

		public ColorD イボ10CD;

		public ColorD イボ11CD;

		public ColorD イボ12CD;

		public ColorD ユニット_ユニットCD;

		public ColorD ユニット_ユニット線上CD;

		public ColorD ユニット_ユニット線下CD;

		public ColorD ユニット_ボタン上CD;

		public ColorD ユニット_ボタン下CD;

		public ColorD ユニット_パワ\u30FC根CD;

		public ColorD ユニット_パワ\u30FC1CD;

		public ColorD ユニット_パワ\u30FC2CD;

		public ColorD ユニット_パワ\u30FC3CD;

		public ColorD ユニット_パワ\u30FC4CD;

		public ColorP X0Y0_ヘッドCP;

		public ColorP X0Y0_イボ1CP;

		public ColorP X0Y0_イボ2CP;

		public ColorP X0Y0_イボ3CP;

		public ColorP X0Y0_イボ4CP;

		public ColorP X0Y0_イボ5CP;

		public ColorP X0Y0_イボ6CP;

		public ColorP X0Y0_イボ7CP;

		public ColorP X0Y0_イボ8CP;

		public ColorP X0Y0_イボ9CP;

		public ColorP X0Y0_イボ10CP;

		public ColorP X0Y0_イボ11CP;

		public ColorP X0Y0_イボ12CP;

		public ColorP X0Y0_ユニット_ユニットCP;

		public ColorP X0Y0_ユニット_ユニット線上CP;

		public ColorP X0Y0_ユニット_ユニット線下CP;

		public ColorP X0Y0_ユニット_ボタン上CP;

		public ColorP X0Y0_ユニット_ボタン下CP;

		public ColorP X0Y0_ユニット_パワ\u30FC根CP;

		public ColorP X0Y0_ユニット_パワ\u30FC1CP;

		public ColorP X0Y0_ユニット_パワ\u30FC2CP;

		public ColorP X0Y0_ユニット_パワ\u30FC3CP;

		public ColorP X0Y0_ユニット_パワ\u30FC4CP;

		public ColorP X0Y1_ヘッドCP;

		public ColorP X0Y1_イボ1CP;

		public ColorP X0Y1_イボ2CP;

		public ColorP X0Y1_イボ3CP;

		public ColorP X0Y1_イボ4CP;

		public ColorP X0Y1_イボ5CP;

		public ColorP X0Y1_イボ6CP;

		public ColorP X0Y1_イボ7CP;

		public ColorP X0Y1_イボ8CP;

		public ColorP X0Y1_イボ9CP;

		public ColorP X0Y1_イボ10CP;

		public ColorP X0Y1_イボ11CP;

		public ColorP X0Y1_イボ12CP;

		public ColorP X0Y1_ユニット_ユニットCP;

		public ColorP X0Y1_ユニット_ユニット線上CP;

		public ColorP X0Y1_ユニット_ユニット線下CP;

		public ColorP X0Y1_ユニット_ボタン上CP;

		public ColorP X0Y1_ユニット_ボタン下CP;

		public ColorP X0Y1_ユニット_パワ\u30FC根CP;

		public ColorP X0Y1_ユニット_パワ\u30FC1CP;

		public ColorP X0Y1_ユニット_パワ\u30FC2CP;

		public ColorP X0Y1_ユニット_パワ\u30FC3CP;

		public ColorP X0Y1_ユニット_パワ\u30FC4CP;

		public ColorP X0Y2_ヘッドCP;

		public ColorP X0Y2_イボ1CP;

		public ColorP X0Y2_イボ2CP;

		public ColorP X0Y2_イボ3CP;

		public ColorP X0Y2_イボ4CP;

		public ColorP X0Y2_イボ5CP;

		public ColorP X0Y2_イボ6CP;

		public ColorP X0Y2_イボ7CP;

		public ColorP X0Y2_イボ8CP;

		public ColorP X0Y2_イボ9CP;

		public ColorP X0Y2_ユニット_ユニットCP;

		public ColorP X0Y2_ユニット_ユニット線上CP;

		public ColorP X0Y2_ユニット_ユニット線下CP;

		public ColorP X0Y2_ユニット_ボタン上CP;

		public ColorP X0Y2_ユニット_ボタン下CP;

		public ColorP X0Y2_ユニット_パワ\u30FC根CP;

		public ColorP X0Y2_ユニット_パワ\u30FC1CP;

		public ColorP X0Y2_ユニット_パワ\u30FC2CP;

		public ColorP X0Y2_ユニット_パワ\u30FC3CP;

		public ColorP X0Y2_ユニット_パワ\u30FC4CP;

		public ColorP X0Y3_ヘッドCP;

		public ColorP X0Y3_イボ1CP;

		public ColorP X0Y3_イボ2CP;

		public ColorP X0Y3_イボ3CP;

		public ColorP X0Y3_イボ4CP;

		public ColorP X0Y3_イボ5CP;

		public ColorP X0Y3_イボ6CP;

		public ColorP X0Y3_ユニット_ユニットCP;

		public ColorP X0Y3_ユニット_ユニット線上CP;

		public ColorP X0Y3_ユニット_ユニット線下CP;

		public ColorP X0Y3_ユニット_ボタン上CP;

		public ColorP X0Y3_ユニット_ボタン下CP;

		public ColorP X0Y3_ユニット_パワ\u30FC根CP;

		public ColorP X0Y3_ユニット_パワ\u30FC1CP;

		public ColorP X0Y3_ユニット_パワ\u30FC2CP;

		public ColorP X0Y3_ユニット_パワ\u30FC3CP;

		public ColorP X0Y3_ユニット_パワ\u30FC4CP;

		public ColorP X0Y4_ヘッドCP;

		public ColorP X0Y4_ユニット_ユニットCP;

		public ColorP X0Y4_ユニット_ユニット線上CP;

		public ColorP X0Y4_ユニット_ユニット線下CP;

		public ColorP X0Y4_ユニット_ボタン上CP;

		public ColorP X0Y4_ユニット_ボタン下CP;

		public ColorP X0Y4_ユニット_パワ\u30FC根CP;

		public ColorP X0Y4_ユニット_パワ\u30FC1CP;

		public ColorP X0Y4_ユニット_パワ\u30FC2CP;

		public ColorP X0Y4_ユニット_パワ\u30FC3CP;

		public ColorP X0Y4_ユニット_パワ\u30FC4CP;
	}
}
