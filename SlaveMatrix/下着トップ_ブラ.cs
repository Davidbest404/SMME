using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 下着トップ_ブラ : 下着トップ
	{
		public 下着トップ_ブラ(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 下着トップ_ブラD e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif(Sta.胴体["下着トップ"][0]);
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			Pars pars2 = pars["バンド"].ToPars();
			this.X0Y0_バンド_バンド = pars2["バンド"].ToPar();
			Pars pars3 = pars2["縁"].ToPars();
			this.X0Y0_バンド_縁_下 = pars3["下"].ToPar();
			this.X0Y0_バンド_縁_上 = pars3["上"].ToPar();
			this.X0Y0_バンド_縁_左 = pars3["左"].ToPar();
			this.X0Y0_バンド_縁_右 = pars3["右"].ToPar();
			pars2 = pars["カップ左"].ToPars();
			this.X0Y0_カップ左_紐 = pars2["紐"].ToPar();
			pars3 = pars2["ジャスター"].ToPars();
			this.X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC1 = pars3["ジャスター1"].ToPar();
			this.X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC2 = pars3["ジャスター2"].ToPar();
			this.X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC3 = pars3["ジャスター3"].ToPar();
			this.X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC4 = pars3["ジャスター4"].ToPar();
			this.X0Y0_カップ左_カップ2 = pars2["カップ2"].ToPar();
			pars3 = pars2["レース"].ToPars();
			this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス1 = pars3["レース1"].ToPar();
			this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス2 = pars3["レース2"].ToPar();
			this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス3 = pars3["レース3"].ToPar();
			this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス4 = pars3["レース4"].ToPar();
			this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス5 = pars3["レース5"].ToPar();
			this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス6 = pars3["レース6"].ToPar();
			this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス7 = pars3["レース7"].ToPar();
			this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス8 = pars3["レース8"].ToPar();
			this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス9 = pars3["レース9"].ToPar();
			this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス10 = pars3["レース10"].ToPar();
			this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス11 = pars3["レース11"].ToPar();
			this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス12 = pars3["レース12"].ToPar();
			this.X0Y0_カップ左_カップ1 = pars2["カップ1"].ToPar();
			pars3 = pars2["柄"].ToPars();
			Pars pars4 = pars3["柄1"].ToPars();
			this.X0Y0_カップ左_柄_柄1_柄1 = pars4["柄1"].ToPar();
			this.X0Y0_カップ左_柄_柄1_柄2 = pars4["柄2"].ToPar();
			pars4 = pars3["柄2"].ToPars();
			this.X0Y0_カップ左_柄_柄2_柄1 = pars4["柄1"].ToPar();
			this.X0Y0_カップ左_柄_柄2_柄2 = pars4["柄2"].ToPar();
			pars4 = pars3["柄3"].ToPars();
			this.X0Y0_カップ左_柄_柄3_柄1 = pars4["柄1"].ToPar();
			this.X0Y0_カップ左_柄_柄3_柄2 = pars4["柄2"].ToPar();
			pars4 = pars3["柄4"].ToPars();
			this.X0Y0_カップ左_柄_柄4_柄1 = pars4["柄1"].ToPar();
			this.X0Y0_カップ左_柄_柄4_柄2 = pars4["柄2"].ToPar();
			pars4 = pars3["柄5"].ToPars();
			this.X0Y0_カップ左_柄_柄5_柄1 = pars4["柄1"].ToPar();
			this.X0Y0_カップ左_柄_柄5_柄2 = pars4["柄2"].ToPar();
			pars4 = pars3["柄6"].ToPars();
			this.X0Y0_カップ左_柄_柄6_柄1 = pars4["柄1"].ToPar();
			this.X0Y0_カップ左_柄_柄6_柄2 = pars4["柄2"].ToPar();
			pars4 = pars3["柄7"].ToPars();
			this.X0Y0_カップ左_柄_柄7_柄1 = pars4["柄1"].ToPar();
			this.X0Y0_カップ左_柄_柄7_柄2 = pars4["柄2"].ToPar();
			pars3 = pars2["縁"].ToPars();
			this.X0Y0_カップ左_縁_縁1 = pars3["縁1"].ToPar();
			this.X0Y0_カップ左_縁_縁2 = pars3["縁2"].ToPar();
			this.X0Y0_カップ左_縁_縁3 = pars3["縁3"].ToPar();
			this.X0Y0_カップ左_縁_縁4 = pars3["縁4"].ToPar();
			pars2 = pars["カップ右"].ToPars();
			this.X0Y0_カップ右_紐 = pars2["紐"].ToPar();
			pars3 = pars2["ジャスター"].ToPars();
			this.X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC1 = pars3["ジャスター1"].ToPar();
			this.X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC2 = pars3["ジャスター2"].ToPar();
			this.X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC3 = pars3["ジャスター3"].ToPar();
			this.X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC4 = pars3["ジャスター4"].ToPar();
			this.X0Y0_カップ右_カップ2 = pars2["カップ2"].ToPar();
			pars3 = pars2["レース"].ToPars();
			this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス1 = pars3["レース1"].ToPar();
			this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス2 = pars3["レース2"].ToPar();
			this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス3 = pars3["レース3"].ToPar();
			this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス4 = pars3["レース4"].ToPar();
			this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス5 = pars3["レース5"].ToPar();
			this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス6 = pars3["レース6"].ToPar();
			this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス7 = pars3["レース7"].ToPar();
			this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス8 = pars3["レース8"].ToPar();
			this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス9 = pars3["レース9"].ToPar();
			this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス10 = pars3["レース10"].ToPar();
			this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス11 = pars3["レース11"].ToPar();
			this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス12 = pars3["レース12"].ToPar();
			this.X0Y0_カップ右_カップ1 = pars2["カップ1"].ToPar();
			pars3 = pars2["柄"].ToPars();
			pars4 = pars3["柄1"].ToPars();
			this.X0Y0_カップ右_柄_柄1_柄1 = pars4["柄1"].ToPar();
			this.X0Y0_カップ右_柄_柄1_柄2 = pars4["柄2"].ToPar();
			pars4 = pars3["柄2"].ToPars();
			this.X0Y0_カップ右_柄_柄2_柄1 = pars4["柄1"].ToPar();
			this.X0Y0_カップ右_柄_柄2_柄2 = pars4["柄2"].ToPar();
			pars4 = pars3["柄3"].ToPars();
			this.X0Y0_カップ右_柄_柄3_柄1 = pars4["柄1"].ToPar();
			this.X0Y0_カップ右_柄_柄3_柄2 = pars4["柄2"].ToPar();
			pars4 = pars3["柄4"].ToPars();
			this.X0Y0_カップ右_柄_柄4_柄1 = pars4["柄1"].ToPar();
			this.X0Y0_カップ右_柄_柄4_柄2 = pars4["柄2"].ToPar();
			pars4 = pars3["柄5"].ToPars();
			this.X0Y0_カップ右_柄_柄5_柄1 = pars4["柄1"].ToPar();
			this.X0Y0_カップ右_柄_柄5_柄2 = pars4["柄2"].ToPar();
			pars4 = pars3["柄6"].ToPars();
			this.X0Y0_カップ右_柄_柄6_柄1 = pars4["柄1"].ToPar();
			this.X0Y0_カップ右_柄_柄6_柄2 = pars4["柄2"].ToPar();
			pars4 = pars3["柄7"].ToPars();
			this.X0Y0_カップ右_柄_柄7_柄1 = pars4["柄1"].ToPar();
			this.X0Y0_カップ右_柄_柄7_柄2 = pars4["柄2"].ToPar();
			pars3 = pars2["縁"].ToPars();
			this.X0Y0_カップ右_縁_縁1 = pars3["縁1"].ToPar();
			this.X0Y0_カップ右_縁_縁2 = pars3["縁2"].ToPar();
			this.X0Y0_カップ右_縁_縁3 = pars3["縁3"].ToPar();
			this.X0Y0_カップ右_縁_縁4 = pars3["縁4"].ToPar();
			pars2 = pars["リボン"].ToPars();
			this.X0Y0_リボン_リボン = pars2["リボン"].ToPar();
			this.X0Y0_リボン_結び目 = pars2["結び目"].ToPar();
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
			this.バンド_バンド_表示 = e.バンド_バンド_表示;
			this.バンド_縁_下_表示 = e.バンド_縁_下_表示;
			this.バンド_縁_上_表示 = e.バンド_縁_上_表示;
			this.バンド_縁_左_表示 = e.バンド_縁_左_表示;
			this.バンド_縁_右_表示 = e.バンド_縁_右_表示;
			this.カップ左_紐_表示 = e.カップ左_紐_表示;
			this.カップ左_ジャスタ\u30FC_ジャスタ\u30FC1_表示 = e.カップ左_ジャスタ\u30FC_ジャスタ\u30FC1_表示;
			this.カップ左_ジャスタ\u30FC_ジャスタ\u30FC2_表示 = e.カップ左_ジャスタ\u30FC_ジャスタ\u30FC2_表示;
			this.カップ左_ジャスタ\u30FC_ジャスタ\u30FC3_表示 = e.カップ左_ジャスタ\u30FC_ジャスタ\u30FC3_表示;
			this.カップ左_ジャスタ\u30FC_ジャスタ\u30FC4_表示 = e.カップ左_ジャスタ\u30FC_ジャスタ\u30FC4_表示;
			this.カップ左_カップ2_表示 = e.カップ左_カップ2_表示;
			this.カップ左_レ\u30FCス_レ\u30FCス1_表示 = e.カップ左_レ\u30FCス_レ\u30FCス1_表示;
			this.カップ左_レ\u30FCス_レ\u30FCス2_表示 = e.カップ左_レ\u30FCス_レ\u30FCス2_表示;
			this.カップ左_レ\u30FCス_レ\u30FCス3_表示 = e.カップ左_レ\u30FCス_レ\u30FCス3_表示;
			this.カップ左_レ\u30FCス_レ\u30FCス4_表示 = e.カップ左_レ\u30FCス_レ\u30FCス4_表示;
			this.カップ左_レ\u30FCス_レ\u30FCス5_表示 = e.カップ左_レ\u30FCス_レ\u30FCス5_表示;
			this.カップ左_レ\u30FCス_レ\u30FCス6_表示 = e.カップ左_レ\u30FCス_レ\u30FCス6_表示;
			this.カップ左_レ\u30FCス_レ\u30FCス7_表示 = e.カップ左_レ\u30FCス_レ\u30FCス7_表示;
			this.カップ左_レ\u30FCス_レ\u30FCス8_表示 = e.カップ左_レ\u30FCス_レ\u30FCス8_表示;
			this.カップ左_レ\u30FCス_レ\u30FCス9_表示 = e.カップ左_レ\u30FCス_レ\u30FCス9_表示;
			this.カップ左_レ\u30FCス_レ\u30FCス10_表示 = e.カップ左_レ\u30FCス_レ\u30FCス10_表示;
			this.カップ左_レ\u30FCス_レ\u30FCス11_表示 = e.カップ左_レ\u30FCス_レ\u30FCス11_表示;
			this.カップ左_レ\u30FCス_レ\u30FCス12_表示 = e.カップ左_レ\u30FCス_レ\u30FCス12_表示;
			this.カップ左_カップ1_表示 = e.カップ左_カップ1_表示;
			this.カップ左_柄_柄1_柄1_表示 = e.カップ左_柄_柄1_柄1_表示;
			this.カップ左_柄_柄1_柄2_表示 = e.カップ左_柄_柄1_柄2_表示;
			this.カップ左_柄_柄2_柄1_表示 = e.カップ左_柄_柄2_柄1_表示;
			this.カップ左_柄_柄2_柄2_表示 = e.カップ左_柄_柄2_柄2_表示;
			this.カップ左_柄_柄3_柄1_表示 = e.カップ左_柄_柄3_柄1_表示;
			this.カップ左_柄_柄3_柄2_表示 = e.カップ左_柄_柄3_柄2_表示;
			this.カップ左_柄_柄4_柄1_表示 = e.カップ左_柄_柄4_柄1_表示;
			this.カップ左_柄_柄4_柄2_表示 = e.カップ左_柄_柄4_柄2_表示;
			this.カップ左_柄_柄5_柄1_表示 = e.カップ左_柄_柄5_柄1_表示;
			this.カップ左_柄_柄5_柄2_表示 = e.カップ左_柄_柄5_柄2_表示;
			this.カップ左_柄_柄6_柄1_表示 = e.カップ左_柄_柄6_柄1_表示;
			this.カップ左_柄_柄6_柄2_表示 = e.カップ左_柄_柄6_柄2_表示;
			this.カップ左_柄_柄7_柄1_表示 = e.カップ左_柄_柄7_柄1_表示;
			this.カップ左_柄_柄7_柄2_表示 = e.カップ左_柄_柄7_柄2_表示;
			this.カップ左_縁_縁1_表示 = e.カップ左_縁_縁1_表示;
			this.カップ左_縁_縁2_表示 = e.カップ左_縁_縁2_表示;
			this.カップ左_縁_縁3_表示 = e.カップ左_縁_縁3_表示;
			this.カップ左_縁_縁4_表示 = e.カップ左_縁_縁4_表示;
			this.カップ右_紐_表示 = e.カップ右_紐_表示;
			this.カップ右_ジャスタ\u30FC_ジャスタ\u30FC1_表示 = e.カップ右_ジャスタ\u30FC_ジャスタ\u30FC1_表示;
			this.カップ右_ジャスタ\u30FC_ジャスタ\u30FC2_表示 = e.カップ右_ジャスタ\u30FC_ジャスタ\u30FC2_表示;
			this.カップ右_ジャスタ\u30FC_ジャスタ\u30FC3_表示 = e.カップ右_ジャスタ\u30FC_ジャスタ\u30FC3_表示;
			this.カップ右_ジャスタ\u30FC_ジャスタ\u30FC4_表示 = e.カップ右_ジャスタ\u30FC_ジャスタ\u30FC4_表示;
			this.カップ右_カップ2_表示 = e.カップ右_カップ2_表示;
			this.カップ右_レ\u30FCス_レ\u30FCス1_表示 = e.カップ右_レ\u30FCス_レ\u30FCス1_表示;
			this.カップ右_レ\u30FCス_レ\u30FCス2_表示 = e.カップ右_レ\u30FCス_レ\u30FCス2_表示;
			this.カップ右_レ\u30FCス_レ\u30FCス3_表示 = e.カップ右_レ\u30FCス_レ\u30FCス3_表示;
			this.カップ右_レ\u30FCス_レ\u30FCス4_表示 = e.カップ右_レ\u30FCス_レ\u30FCス4_表示;
			this.カップ右_レ\u30FCス_レ\u30FCス5_表示 = e.カップ右_レ\u30FCス_レ\u30FCス5_表示;
			this.カップ右_レ\u30FCス_レ\u30FCス6_表示 = e.カップ右_レ\u30FCス_レ\u30FCス6_表示;
			this.カップ右_レ\u30FCス_レ\u30FCス7_表示 = e.カップ右_レ\u30FCス_レ\u30FCス7_表示;
			this.カップ右_レ\u30FCス_レ\u30FCス8_表示 = e.カップ右_レ\u30FCス_レ\u30FCス8_表示;
			this.カップ右_レ\u30FCス_レ\u30FCス9_表示 = e.カップ右_レ\u30FCス_レ\u30FCス9_表示;
			this.カップ右_レ\u30FCス_レ\u30FCス10_表示 = e.カップ右_レ\u30FCス_レ\u30FCス10_表示;
			this.カップ右_レ\u30FCス_レ\u30FCス11_表示 = e.カップ右_レ\u30FCス_レ\u30FCス11_表示;
			this.カップ右_レ\u30FCス_レ\u30FCス12_表示 = e.カップ右_レ\u30FCス_レ\u30FCス12_表示;
			this.カップ右_カップ1_表示 = e.カップ右_カップ1_表示;
			this.カップ右_柄_柄1_柄1_表示 = e.カップ右_柄_柄1_柄1_表示;
			this.カップ右_柄_柄1_柄2_表示 = e.カップ右_柄_柄1_柄2_表示;
			this.カップ右_柄_柄2_柄1_表示 = e.カップ右_柄_柄2_柄1_表示;
			this.カップ右_柄_柄2_柄2_表示 = e.カップ右_柄_柄2_柄2_表示;
			this.カップ右_柄_柄3_柄1_表示 = e.カップ右_柄_柄3_柄1_表示;
			this.カップ右_柄_柄3_柄2_表示 = e.カップ右_柄_柄3_柄2_表示;
			this.カップ右_柄_柄4_柄1_表示 = e.カップ右_柄_柄4_柄1_表示;
			this.カップ右_柄_柄4_柄2_表示 = e.カップ右_柄_柄4_柄2_表示;
			this.カップ右_柄_柄5_柄1_表示 = e.カップ右_柄_柄5_柄1_表示;
			this.カップ右_柄_柄5_柄2_表示 = e.カップ右_柄_柄5_柄2_表示;
			this.カップ右_柄_柄6_柄1_表示 = e.カップ右_柄_柄6_柄1_表示;
			this.カップ右_柄_柄6_柄2_表示 = e.カップ右_柄_柄6_柄2_表示;
			this.カップ右_柄_柄7_柄1_表示 = e.カップ右_柄_柄7_柄1_表示;
			this.カップ右_柄_柄7_柄2_表示 = e.カップ右_柄_柄7_柄2_表示;
			this.カップ右_縁_縁1_表示 = e.カップ右_縁_縁1_表示;
			this.カップ右_縁_縁2_表示 = e.カップ右_縁_縁2_表示;
			this.カップ右_縁_縁3_表示 = e.カップ右_縁_縁3_表示;
			this.カップ右_縁_縁4_表示 = e.カップ右_縁_縁4_表示;
			this.リボン_リボン_表示 = e.リボン_リボン_表示;
			this.リボン_結び目_表示 = e.リボン_結び目_表示;
			this.ベ\u30FCス表示 = e.ベ\u30FCス表示;
			this.縁1表示 = e.縁1表示;
			this.縁2表示 = e.縁2表示;
			this.縁3表示 = e.縁3表示;
			this.縁4表示 = e.縁4表示;
			this.縁5表示 = e.縁5表示;
			this.縁6表示 = e.縁6表示;
			this.縁7表示 = e.縁7表示;
			this.ジャスタ\u30FC表示 = e.ジャスタ\u30FC表示;
			this.レ\u30FCス表示 = e.レ\u30FCス表示;
			this.柄1表示 = e.柄1表示;
			this.柄2表示 = e.柄2表示;
			this.柄3表示 = e.柄3表示;
			this.柄4表示 = e.柄4表示;
			this.柄5表示 = e.柄5表示;
			this.柄6表示 = e.柄6表示;
			this.柄7表示 = e.柄7表示;
			this.柄8表示 = e.柄8表示;
			this.柄9表示 = e.柄9表示;
			this.柄10表示 = e.柄10表示;
			this.柄11表示 = e.柄11表示;
			this.柄12表示 = e.柄12表示;
			this.柄13表示 = e.柄13表示;
			this.柄14表示 = e.柄14表示;
			this.リボン表示 = e.リボン表示;
			this.リボン結び目表示 = e.リボン結び目表示;
			this.バスト = e.バスト;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_バンド_バンドCP = new ColorP(this.X0Y0_バンド_バンド, this.バンド_バンドCD, DisUnit, true);
			this.X0Y0_バンド_縁_下CP = new ColorP(this.X0Y0_バンド_縁_下, this.バンド_縁_下CD, DisUnit, true);
			this.X0Y0_バンド_縁_上CP = new ColorP(this.X0Y0_バンド_縁_上, this.バンド_縁_上CD, DisUnit, true);
			this.X0Y0_バンド_縁_左CP = new ColorP(this.X0Y0_バンド_縁_左, this.バンド_縁_左CD, DisUnit, true);
			this.X0Y0_バンド_縁_右CP = new ColorP(this.X0Y0_バンド_縁_右, this.バンド_縁_右CD, DisUnit, true);
			this.X0Y0_カップ左_紐CP = new ColorP(this.X0Y0_カップ左_紐, this.カップ左_紐CD, DisUnit, true);
			this.X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC1CP = new ColorP(this.X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC1, this.カップ左_ジャスタ\u30FC_ジャスタ\u30FC1CD, DisUnit, true);
			this.X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC2CP = new ColorP(this.X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC2, this.カップ左_ジャスタ\u30FC_ジャスタ\u30FC2CD, DisUnit, true);
			this.X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC3CP = new ColorP(this.X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC3, this.カップ左_ジャスタ\u30FC_ジャスタ\u30FC3CD, DisUnit, true);
			this.X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC4CP = new ColorP(this.X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC4, this.カップ左_ジャスタ\u30FC_ジャスタ\u30FC4CD, DisUnit, true);
			this.X0Y0_カップ左_カップ2CP = new ColorP(this.X0Y0_カップ左_カップ2, this.カップ左_カップ2CD, DisUnit, true);
			this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス1CP = new ColorP(this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス1, this.カップ左_レ\u30FCス_レ\u30FCス1CD, DisUnit, true);
			this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス2CP = new ColorP(this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス2, this.カップ左_レ\u30FCス_レ\u30FCス2CD, DisUnit, true);
			this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス3CP = new ColorP(this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス3, this.カップ左_レ\u30FCス_レ\u30FCス3CD, DisUnit, true);
			this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス4CP = new ColorP(this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス4, this.カップ左_レ\u30FCス_レ\u30FCス4CD, DisUnit, true);
			this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス5CP = new ColorP(this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス5, this.カップ左_レ\u30FCス_レ\u30FCス5CD, DisUnit, true);
			this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス6CP = new ColorP(this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス6, this.カップ左_レ\u30FCス_レ\u30FCス6CD, DisUnit, true);
			this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス7CP = new ColorP(this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス7, this.カップ左_レ\u30FCス_レ\u30FCス7CD, DisUnit, true);
			this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス8CP = new ColorP(this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス8, this.カップ左_レ\u30FCス_レ\u30FCス8CD, DisUnit, true);
			this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス9CP = new ColorP(this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス9, this.カップ左_レ\u30FCス_レ\u30FCス9CD, DisUnit, true);
			this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス10CP = new ColorP(this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス10, this.カップ左_レ\u30FCス_レ\u30FCス10CD, DisUnit, true);
			this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス11CP = new ColorP(this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス11, this.カップ左_レ\u30FCス_レ\u30FCス11CD, DisUnit, true);
			this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス12CP = new ColorP(this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス12, this.カップ左_レ\u30FCス_レ\u30FCス12CD, DisUnit, true);
			this.X0Y0_カップ左_カップ1CP = new ColorP(this.X0Y0_カップ左_カップ1, this.カップ左_カップ1CD, DisUnit, true);
			this.X0Y0_カップ左_柄_柄1_柄1CP = new ColorP(this.X0Y0_カップ左_柄_柄1_柄1, this.カップ左_柄_柄1_柄1CD, DisUnit, true);
			this.X0Y0_カップ左_柄_柄1_柄2CP = new ColorP(this.X0Y0_カップ左_柄_柄1_柄2, this.カップ左_柄_柄1_柄2CD, DisUnit, true);
			this.X0Y0_カップ左_柄_柄2_柄1CP = new ColorP(this.X0Y0_カップ左_柄_柄2_柄1, this.カップ左_柄_柄2_柄1CD, DisUnit, true);
			this.X0Y0_カップ左_柄_柄2_柄2CP = new ColorP(this.X0Y0_カップ左_柄_柄2_柄2, this.カップ左_柄_柄2_柄2CD, DisUnit, true);
			this.X0Y0_カップ左_柄_柄3_柄1CP = new ColorP(this.X0Y0_カップ左_柄_柄3_柄1, this.カップ左_柄_柄3_柄1CD, DisUnit, true);
			this.X0Y0_カップ左_柄_柄3_柄2CP = new ColorP(this.X0Y0_カップ左_柄_柄3_柄2, this.カップ左_柄_柄3_柄2CD, DisUnit, true);
			this.X0Y0_カップ左_柄_柄4_柄1CP = new ColorP(this.X0Y0_カップ左_柄_柄4_柄1, this.カップ左_柄_柄4_柄1CD, DisUnit, true);
			this.X0Y0_カップ左_柄_柄4_柄2CP = new ColorP(this.X0Y0_カップ左_柄_柄4_柄2, this.カップ左_柄_柄4_柄2CD, DisUnit, true);
			this.X0Y0_カップ左_柄_柄5_柄1CP = new ColorP(this.X0Y0_カップ左_柄_柄5_柄1, this.カップ左_柄_柄5_柄1CD, DisUnit, true);
			this.X0Y0_カップ左_柄_柄5_柄2CP = new ColorP(this.X0Y0_カップ左_柄_柄5_柄2, this.カップ左_柄_柄5_柄2CD, DisUnit, true);
			this.X0Y0_カップ左_柄_柄6_柄1CP = new ColorP(this.X0Y0_カップ左_柄_柄6_柄1, this.カップ左_柄_柄6_柄1CD, DisUnit, true);
			this.X0Y0_カップ左_柄_柄6_柄2CP = new ColorP(this.X0Y0_カップ左_柄_柄6_柄2, this.カップ左_柄_柄6_柄2CD, DisUnit, true);
			this.X0Y0_カップ左_柄_柄7_柄1CP = new ColorP(this.X0Y0_カップ左_柄_柄7_柄1, this.カップ左_柄_柄7_柄1CD, DisUnit, true);
			this.X0Y0_カップ左_柄_柄7_柄2CP = new ColorP(this.X0Y0_カップ左_柄_柄7_柄2, this.カップ左_柄_柄7_柄2CD, DisUnit, true);
			this.X0Y0_カップ左_縁_縁1CP = new ColorP(this.X0Y0_カップ左_縁_縁1, this.カップ左_縁_縁1CD, DisUnit, true);
			this.X0Y0_カップ左_縁_縁2CP = new ColorP(this.X0Y0_カップ左_縁_縁2, this.カップ左_縁_縁2CD, DisUnit, true);
			this.X0Y0_カップ左_縁_縁3CP = new ColorP(this.X0Y0_カップ左_縁_縁3, this.カップ左_縁_縁3CD, DisUnit, true);
			this.X0Y0_カップ左_縁_縁4CP = new ColorP(this.X0Y0_カップ左_縁_縁4, this.カップ左_縁_縁4CD, DisUnit, true);
			this.X0Y0_カップ右_紐CP = new ColorP(this.X0Y0_カップ右_紐, this.カップ右_紐CD, DisUnit, true);
			this.X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC1CP = new ColorP(this.X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC1, this.カップ右_ジャスタ\u30FC_ジャスタ\u30FC1CD, DisUnit, true);
			this.X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC2CP = new ColorP(this.X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC2, this.カップ右_ジャスタ\u30FC_ジャスタ\u30FC2CD, DisUnit, true);
			this.X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC3CP = new ColorP(this.X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC3, this.カップ右_ジャスタ\u30FC_ジャスタ\u30FC3CD, DisUnit, true);
			this.X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC4CP = new ColorP(this.X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC4, this.カップ右_ジャスタ\u30FC_ジャスタ\u30FC4CD, DisUnit, true);
			this.X0Y0_カップ右_カップ2CP = new ColorP(this.X0Y0_カップ右_カップ2, this.カップ右_カップ2CD, DisUnit, true);
			this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス1CP = new ColorP(this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス1, this.カップ右_レ\u30FCス_レ\u30FCス1CD, DisUnit, true);
			this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス2CP = new ColorP(this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス2, this.カップ右_レ\u30FCス_レ\u30FCス2CD, DisUnit, true);
			this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス3CP = new ColorP(this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス3, this.カップ右_レ\u30FCス_レ\u30FCス3CD, DisUnit, true);
			this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス4CP = new ColorP(this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス4, this.カップ右_レ\u30FCス_レ\u30FCス4CD, DisUnit, true);
			this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス5CP = new ColorP(this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス5, this.カップ右_レ\u30FCス_レ\u30FCス5CD, DisUnit, true);
			this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス6CP = new ColorP(this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス6, this.カップ右_レ\u30FCス_レ\u30FCス6CD, DisUnit, true);
			this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス7CP = new ColorP(this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス7, this.カップ右_レ\u30FCス_レ\u30FCス7CD, DisUnit, true);
			this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス8CP = new ColorP(this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス8, this.カップ右_レ\u30FCス_レ\u30FCス8CD, DisUnit, true);
			this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス9CP = new ColorP(this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス9, this.カップ右_レ\u30FCス_レ\u30FCス9CD, DisUnit, true);
			this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス10CP = new ColorP(this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス10, this.カップ右_レ\u30FCス_レ\u30FCス10CD, DisUnit, true);
			this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス11CP = new ColorP(this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス11, this.カップ右_レ\u30FCス_レ\u30FCス11CD, DisUnit, true);
			this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス12CP = new ColorP(this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス12, this.カップ右_レ\u30FCス_レ\u30FCス12CD, DisUnit, true);
			this.X0Y0_カップ右_カップ1CP = new ColorP(this.X0Y0_カップ右_カップ1, this.カップ右_カップ1CD, DisUnit, true);
			this.X0Y0_カップ右_柄_柄1_柄1CP = new ColorP(this.X0Y0_カップ右_柄_柄1_柄1, this.カップ右_柄_柄1_柄1CD, DisUnit, true);
			this.X0Y0_カップ右_柄_柄1_柄2CP = new ColorP(this.X0Y0_カップ右_柄_柄1_柄2, this.カップ右_柄_柄1_柄2CD, DisUnit, true);
			this.X0Y0_カップ右_柄_柄2_柄1CP = new ColorP(this.X0Y0_カップ右_柄_柄2_柄1, this.カップ右_柄_柄2_柄1CD, DisUnit, true);
			this.X0Y0_カップ右_柄_柄2_柄2CP = new ColorP(this.X0Y0_カップ右_柄_柄2_柄2, this.カップ右_柄_柄2_柄2CD, DisUnit, true);
			this.X0Y0_カップ右_柄_柄3_柄1CP = new ColorP(this.X0Y0_カップ右_柄_柄3_柄1, this.カップ右_柄_柄3_柄1CD, DisUnit, true);
			this.X0Y0_カップ右_柄_柄3_柄2CP = new ColorP(this.X0Y0_カップ右_柄_柄3_柄2, this.カップ右_柄_柄3_柄2CD, DisUnit, true);
			this.X0Y0_カップ右_柄_柄4_柄1CP = new ColorP(this.X0Y0_カップ右_柄_柄4_柄1, this.カップ右_柄_柄4_柄1CD, DisUnit, true);
			this.X0Y0_カップ右_柄_柄4_柄2CP = new ColorP(this.X0Y0_カップ右_柄_柄4_柄2, this.カップ右_柄_柄4_柄2CD, DisUnit, true);
			this.X0Y0_カップ右_柄_柄5_柄1CP = new ColorP(this.X0Y0_カップ右_柄_柄5_柄1, this.カップ右_柄_柄5_柄1CD, DisUnit, true);
			this.X0Y0_カップ右_柄_柄5_柄2CP = new ColorP(this.X0Y0_カップ右_柄_柄5_柄2, this.カップ右_柄_柄5_柄2CD, DisUnit, true);
			this.X0Y0_カップ右_柄_柄6_柄1CP = new ColorP(this.X0Y0_カップ右_柄_柄6_柄1, this.カップ右_柄_柄6_柄1CD, DisUnit, true);
			this.X0Y0_カップ右_柄_柄6_柄2CP = new ColorP(this.X0Y0_カップ右_柄_柄6_柄2, this.カップ右_柄_柄6_柄2CD, DisUnit, true);
			this.X0Y0_カップ右_柄_柄7_柄1CP = new ColorP(this.X0Y0_カップ右_柄_柄7_柄1, this.カップ右_柄_柄7_柄1CD, DisUnit, true);
			this.X0Y0_カップ右_柄_柄7_柄2CP = new ColorP(this.X0Y0_カップ右_柄_柄7_柄2, this.カップ右_柄_柄7_柄2CD, DisUnit, true);
			this.X0Y0_カップ右_縁_縁1CP = new ColorP(this.X0Y0_カップ右_縁_縁1, this.カップ右_縁_縁1CD, DisUnit, true);
			this.X0Y0_カップ右_縁_縁2CP = new ColorP(this.X0Y0_カップ右_縁_縁2, this.カップ右_縁_縁2CD, DisUnit, true);
			this.X0Y0_カップ右_縁_縁3CP = new ColorP(this.X0Y0_カップ右_縁_縁3, this.カップ右_縁_縁3CD, DisUnit, true);
			this.X0Y0_カップ右_縁_縁4CP = new ColorP(this.X0Y0_カップ右_縁_縁4, this.カップ右_縁_縁4CD, DisUnit, true);
			this.X0Y0_リボン_リボンCP = new ColorP(this.X0Y0_リボン_リボン, this.リボン_リボンCD, DisUnit, true);
			this.X0Y0_リボン_結び目CP = new ColorP(this.X0Y0_リボン_結び目, this.リボン_結び目CD, DisUnit, true);
			this.尺度YB *= 1.1;
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

		public bool バンド_バンド_表示
		{
			get
			{
				return this.X0Y0_バンド_バンド.Dra;
			}
			set
			{
				this.X0Y0_バンド_バンド.Dra = value;
				this.X0Y0_バンド_バンド.Hit = false;
			}
		}

		public bool バンド_縁_下_表示
		{
			get
			{
				return this.X0Y0_バンド_縁_下.Dra;
			}
			set
			{
				this.X0Y0_バンド_縁_下.Dra = value;
				this.X0Y0_バンド_縁_下.Hit = false;
			}
		}

		public bool バンド_縁_上_表示
		{
			get
			{
				return this.X0Y0_バンド_縁_上.Dra;
			}
			set
			{
				this.X0Y0_バンド_縁_上.Dra = value;
				this.X0Y0_バンド_縁_上.Hit = false;
			}
		}

		public bool バンド_縁_左_表示
		{
			get
			{
				return this.X0Y0_バンド_縁_左.Dra;
			}
			set
			{
				this.X0Y0_バンド_縁_左.Dra = value;
				this.X0Y0_バンド_縁_左.Hit = false;
			}
		}

		public bool バンド_縁_右_表示
		{
			get
			{
				return this.X0Y0_バンド_縁_右.Dra;
			}
			set
			{
				this.X0Y0_バンド_縁_右.Dra = value;
				this.X0Y0_バンド_縁_右.Hit = false;
			}
		}

		public bool カップ左_紐_表示
		{
			get
			{
				return this.X0Y0_カップ左_紐.Dra;
			}
			set
			{
				this.X0Y0_カップ左_紐.Dra = value;
				this.X0Y0_カップ左_紐.Hit = false;
			}
		}

		public bool カップ左_ジャスタ\u30FC_ジャスタ\u30FC1_表示
		{
			get
			{
				return this.X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC1.Dra;
			}
			set
			{
				this.X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC1.Dra = value;
				this.X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC1.Hit = false;
			}
		}

		public bool カップ左_ジャスタ\u30FC_ジャスタ\u30FC2_表示
		{
			get
			{
				return this.X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC2.Dra;
			}
			set
			{
				this.X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC2.Dra = value;
				this.X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC2.Hit = false;
			}
		}

		public bool カップ左_ジャスタ\u30FC_ジャスタ\u30FC3_表示
		{
			get
			{
				return this.X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC3.Dra;
			}
			set
			{
				this.X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC3.Dra = value;
				this.X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC3.Hit = false;
			}
		}

		public bool カップ左_ジャスタ\u30FC_ジャスタ\u30FC4_表示
		{
			get
			{
				return this.X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC4.Dra;
			}
			set
			{
				this.X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC4.Dra = value;
				this.X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC4.Hit = false;
			}
		}

		public bool カップ左_カップ2_表示
		{
			get
			{
				return this.X0Y0_カップ左_カップ2.Dra;
			}
			set
			{
				this.X0Y0_カップ左_カップ2.Dra = value;
				this.X0Y0_カップ左_カップ2.Hit = false;
			}
		}

		public bool カップ左_レ\u30FCス_レ\u30FCス1_表示
		{
			get
			{
				return this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス1.Dra;
			}
			set
			{
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス1.Dra = value;
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス1.Hit = false;
			}
		}

		public bool カップ左_レ\u30FCス_レ\u30FCス2_表示
		{
			get
			{
				return this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス2.Dra;
			}
			set
			{
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス2.Dra = value;
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス2.Hit = false;
			}
		}

		public bool カップ左_レ\u30FCス_レ\u30FCス3_表示
		{
			get
			{
				return this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス3.Dra;
			}
			set
			{
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス3.Dra = value;
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス3.Hit = false;
			}
		}

		public bool カップ左_レ\u30FCス_レ\u30FCス4_表示
		{
			get
			{
				return this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス4.Dra;
			}
			set
			{
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス4.Dra = value;
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス4.Hit = false;
			}
		}

		public bool カップ左_レ\u30FCス_レ\u30FCス5_表示
		{
			get
			{
				return this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス5.Dra;
			}
			set
			{
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス5.Dra = value;
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス5.Hit = false;
			}
		}

		public bool カップ左_レ\u30FCス_レ\u30FCス6_表示
		{
			get
			{
				return this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス6.Dra;
			}
			set
			{
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス6.Dra = value;
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス6.Hit = false;
			}
		}

		public bool カップ左_レ\u30FCス_レ\u30FCス7_表示
		{
			get
			{
				return this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス7.Dra;
			}
			set
			{
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス7.Dra = value;
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス7.Hit = false;
			}
		}

		public bool カップ左_レ\u30FCス_レ\u30FCス8_表示
		{
			get
			{
				return this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス8.Dra;
			}
			set
			{
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス8.Dra = value;
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス8.Hit = false;
			}
		}

		public bool カップ左_レ\u30FCス_レ\u30FCス9_表示
		{
			get
			{
				return this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス9.Dra;
			}
			set
			{
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス9.Dra = value;
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス9.Hit = false;
			}
		}

		public bool カップ左_レ\u30FCス_レ\u30FCス10_表示
		{
			get
			{
				return this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス10.Dra;
			}
			set
			{
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス10.Dra = value;
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス10.Hit = false;
			}
		}

		public bool カップ左_レ\u30FCス_レ\u30FCス11_表示
		{
			get
			{
				return this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス11.Dra;
			}
			set
			{
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス11.Dra = value;
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス11.Hit = false;
			}
		}

		public bool カップ左_レ\u30FCス_レ\u30FCス12_表示
		{
			get
			{
				return this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス12.Dra;
			}
			set
			{
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス12.Dra = value;
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス12.Hit = false;
			}
		}

		public bool カップ左_カップ1_表示
		{
			get
			{
				return this.X0Y0_カップ左_カップ1.Dra;
			}
			set
			{
				this.X0Y0_カップ左_カップ1.Dra = value;
				this.X0Y0_カップ左_カップ1.Hit = false;
			}
		}

		public bool カップ左_柄_柄1_柄1_表示
		{
			get
			{
				return this.X0Y0_カップ左_柄_柄1_柄1.Dra;
			}
			set
			{
				this.X0Y0_カップ左_柄_柄1_柄1.Dra = value;
				this.X0Y0_カップ左_柄_柄1_柄1.Hit = false;
			}
		}

		public bool カップ左_柄_柄1_柄2_表示
		{
			get
			{
				return this.X0Y0_カップ左_柄_柄1_柄2.Dra;
			}
			set
			{
				this.X0Y0_カップ左_柄_柄1_柄2.Dra = value;
				this.X0Y0_カップ左_柄_柄1_柄2.Hit = false;
			}
		}

		public bool カップ左_柄_柄2_柄1_表示
		{
			get
			{
				return this.X0Y0_カップ左_柄_柄2_柄1.Dra;
			}
			set
			{
				this.X0Y0_カップ左_柄_柄2_柄1.Dra = value;
				this.X0Y0_カップ左_柄_柄2_柄1.Hit = false;
			}
		}

		public bool カップ左_柄_柄2_柄2_表示
		{
			get
			{
				return this.X0Y0_カップ左_柄_柄2_柄2.Dra;
			}
			set
			{
				this.X0Y0_カップ左_柄_柄2_柄2.Dra = value;
				this.X0Y0_カップ左_柄_柄2_柄2.Hit = false;
			}
		}

		public bool カップ左_柄_柄3_柄1_表示
		{
			get
			{
				return this.X0Y0_カップ左_柄_柄3_柄1.Dra;
			}
			set
			{
				this.X0Y0_カップ左_柄_柄3_柄1.Dra = value;
				this.X0Y0_カップ左_柄_柄3_柄1.Hit = false;
			}
		}

		public bool カップ左_柄_柄3_柄2_表示
		{
			get
			{
				return this.X0Y0_カップ左_柄_柄3_柄2.Dra;
			}
			set
			{
				this.X0Y0_カップ左_柄_柄3_柄2.Dra = value;
				this.X0Y0_カップ左_柄_柄3_柄2.Hit = false;
			}
		}

		public bool カップ左_柄_柄4_柄1_表示
		{
			get
			{
				return this.X0Y0_カップ左_柄_柄4_柄1.Dra;
			}
			set
			{
				this.X0Y0_カップ左_柄_柄4_柄1.Dra = value;
				this.X0Y0_カップ左_柄_柄4_柄1.Hit = false;
			}
		}

		public bool カップ左_柄_柄4_柄2_表示
		{
			get
			{
				return this.X0Y0_カップ左_柄_柄4_柄2.Dra;
			}
			set
			{
				this.X0Y0_カップ左_柄_柄4_柄2.Dra = value;
				this.X0Y0_カップ左_柄_柄4_柄2.Hit = false;
			}
		}

		public bool カップ左_柄_柄5_柄1_表示
		{
			get
			{
				return this.X0Y0_カップ左_柄_柄5_柄1.Dra;
			}
			set
			{
				this.X0Y0_カップ左_柄_柄5_柄1.Dra = value;
				this.X0Y0_カップ左_柄_柄5_柄1.Hit = false;
			}
		}

		public bool カップ左_柄_柄5_柄2_表示
		{
			get
			{
				return this.X0Y0_カップ左_柄_柄5_柄2.Dra;
			}
			set
			{
				this.X0Y0_カップ左_柄_柄5_柄2.Dra = value;
				this.X0Y0_カップ左_柄_柄5_柄2.Hit = false;
			}
		}

		public bool カップ左_柄_柄6_柄1_表示
		{
			get
			{
				return this.X0Y0_カップ左_柄_柄6_柄1.Dra;
			}
			set
			{
				this.X0Y0_カップ左_柄_柄6_柄1.Dra = value;
				this.X0Y0_カップ左_柄_柄6_柄1.Hit = false;
			}
		}

		public bool カップ左_柄_柄6_柄2_表示
		{
			get
			{
				return this.X0Y0_カップ左_柄_柄6_柄2.Dra;
			}
			set
			{
				this.X0Y0_カップ左_柄_柄6_柄2.Dra = value;
				this.X0Y0_カップ左_柄_柄6_柄2.Hit = false;
			}
		}

		public bool カップ左_柄_柄7_柄1_表示
		{
			get
			{
				return this.X0Y0_カップ左_柄_柄7_柄1.Dra;
			}
			set
			{
				this.X0Y0_カップ左_柄_柄7_柄1.Dra = value;
				this.X0Y0_カップ左_柄_柄7_柄1.Hit = false;
			}
		}

		public bool カップ左_柄_柄7_柄2_表示
		{
			get
			{
				return this.X0Y0_カップ左_柄_柄7_柄2.Dra;
			}
			set
			{
				this.X0Y0_カップ左_柄_柄7_柄2.Dra = value;
				this.X0Y0_カップ左_柄_柄7_柄2.Hit = false;
			}
		}

		public bool カップ左_縁_縁1_表示
		{
			get
			{
				return this.X0Y0_カップ左_縁_縁1.Dra;
			}
			set
			{
				this.X0Y0_カップ左_縁_縁1.Dra = value;
				this.X0Y0_カップ左_縁_縁1.Hit = false;
			}
		}

		public bool カップ左_縁_縁2_表示
		{
			get
			{
				return this.X0Y0_カップ左_縁_縁2.Dra;
			}
			set
			{
				this.X0Y0_カップ左_縁_縁2.Dra = value;
				this.X0Y0_カップ左_縁_縁2.Hit = false;
			}
		}

		public bool カップ左_縁_縁3_表示
		{
			get
			{
				return this.X0Y0_カップ左_縁_縁3.Dra;
			}
			set
			{
				this.X0Y0_カップ左_縁_縁3.Dra = value;
				this.X0Y0_カップ左_縁_縁3.Hit = false;
			}
		}

		public bool カップ左_縁_縁4_表示
		{
			get
			{
				return this.X0Y0_カップ左_縁_縁4.Dra;
			}
			set
			{
				this.X0Y0_カップ左_縁_縁4.Dra = value;
				this.X0Y0_カップ左_縁_縁4.Hit = false;
			}
		}

		public bool カップ右_紐_表示
		{
			get
			{
				return this.X0Y0_カップ右_紐.Dra;
			}
			set
			{
				this.X0Y0_カップ右_紐.Dra = value;
				this.X0Y0_カップ右_紐.Hit = false;
			}
		}

		public bool カップ右_ジャスタ\u30FC_ジャスタ\u30FC1_表示
		{
			get
			{
				return this.X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC1.Dra;
			}
			set
			{
				this.X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC1.Dra = value;
				this.X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC1.Hit = false;
			}
		}

		public bool カップ右_ジャスタ\u30FC_ジャスタ\u30FC2_表示
		{
			get
			{
				return this.X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC2.Dra;
			}
			set
			{
				this.X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC2.Dra = value;
				this.X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC2.Hit = false;
			}
		}

		public bool カップ右_ジャスタ\u30FC_ジャスタ\u30FC3_表示
		{
			get
			{
				return this.X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC3.Dra;
			}
			set
			{
				this.X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC3.Dra = value;
				this.X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC3.Hit = false;
			}
		}

		public bool カップ右_ジャスタ\u30FC_ジャスタ\u30FC4_表示
		{
			get
			{
				return this.X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC4.Dra;
			}
			set
			{
				this.X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC4.Dra = value;
				this.X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC4.Hit = false;
			}
		}

		public bool カップ右_カップ2_表示
		{
			get
			{
				return this.X0Y0_カップ右_カップ2.Dra;
			}
			set
			{
				this.X0Y0_カップ右_カップ2.Dra = value;
				this.X0Y0_カップ右_カップ2.Hit = false;
			}
		}

		public bool カップ右_レ\u30FCス_レ\u30FCス1_表示
		{
			get
			{
				return this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス1.Dra;
			}
			set
			{
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス1.Dra = value;
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス1.Hit = false;
			}
		}

		public bool カップ右_レ\u30FCス_レ\u30FCス2_表示
		{
			get
			{
				return this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス2.Dra;
			}
			set
			{
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス2.Dra = value;
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス2.Hit = false;
			}
		}

		public bool カップ右_レ\u30FCス_レ\u30FCス3_表示
		{
			get
			{
				return this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス3.Dra;
			}
			set
			{
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス3.Dra = value;
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス3.Hit = false;
			}
		}

		public bool カップ右_レ\u30FCス_レ\u30FCス4_表示
		{
			get
			{
				return this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス4.Dra;
			}
			set
			{
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス4.Dra = value;
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス4.Hit = false;
			}
		}

		public bool カップ右_レ\u30FCス_レ\u30FCス5_表示
		{
			get
			{
				return this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス5.Dra;
			}
			set
			{
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス5.Dra = value;
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス5.Hit = false;
			}
		}

		public bool カップ右_レ\u30FCス_レ\u30FCス6_表示
		{
			get
			{
				return this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス6.Dra;
			}
			set
			{
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス6.Dra = value;
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス6.Hit = false;
			}
		}

		public bool カップ右_レ\u30FCス_レ\u30FCス7_表示
		{
			get
			{
				return this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス7.Dra;
			}
			set
			{
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス7.Dra = value;
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス7.Hit = false;
			}
		}

		public bool カップ右_レ\u30FCス_レ\u30FCス8_表示
		{
			get
			{
				return this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス8.Dra;
			}
			set
			{
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス8.Dra = value;
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス8.Hit = false;
			}
		}

		public bool カップ右_レ\u30FCス_レ\u30FCス9_表示
		{
			get
			{
				return this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス9.Dra;
			}
			set
			{
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス9.Dra = value;
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス9.Hit = false;
			}
		}

		public bool カップ右_レ\u30FCス_レ\u30FCス10_表示
		{
			get
			{
				return this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス10.Dra;
			}
			set
			{
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス10.Dra = value;
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス10.Hit = false;
			}
		}

		public bool カップ右_レ\u30FCス_レ\u30FCス11_表示
		{
			get
			{
				return this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス11.Dra;
			}
			set
			{
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス11.Dra = value;
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス11.Hit = false;
			}
		}

		public bool カップ右_レ\u30FCス_レ\u30FCス12_表示
		{
			get
			{
				return this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス12.Dra;
			}
			set
			{
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス12.Dra = value;
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス12.Hit = false;
			}
		}

		public bool カップ右_カップ1_表示
		{
			get
			{
				return this.X0Y0_カップ右_カップ1.Dra;
			}
			set
			{
				this.X0Y0_カップ右_カップ1.Dra = value;
				this.X0Y0_カップ右_カップ1.Hit = false;
			}
		}

		public bool カップ右_柄_柄1_柄1_表示
		{
			get
			{
				return this.X0Y0_カップ右_柄_柄1_柄1.Dra;
			}
			set
			{
				this.X0Y0_カップ右_柄_柄1_柄1.Dra = value;
				this.X0Y0_カップ右_柄_柄1_柄1.Hit = false;
			}
		}

		public bool カップ右_柄_柄1_柄2_表示
		{
			get
			{
				return this.X0Y0_カップ右_柄_柄1_柄2.Dra;
			}
			set
			{
				this.X0Y0_カップ右_柄_柄1_柄2.Dra = value;
				this.X0Y0_カップ右_柄_柄1_柄2.Hit = false;
			}
		}

		public bool カップ右_柄_柄2_柄1_表示
		{
			get
			{
				return this.X0Y0_カップ右_柄_柄2_柄1.Dra;
			}
			set
			{
				this.X0Y0_カップ右_柄_柄2_柄1.Dra = value;
				this.X0Y0_カップ右_柄_柄2_柄1.Hit = false;
			}
		}

		public bool カップ右_柄_柄2_柄2_表示
		{
			get
			{
				return this.X0Y0_カップ右_柄_柄2_柄2.Dra;
			}
			set
			{
				this.X0Y0_カップ右_柄_柄2_柄2.Dra = value;
				this.X0Y0_カップ右_柄_柄2_柄2.Hit = false;
			}
		}

		public bool カップ右_柄_柄3_柄1_表示
		{
			get
			{
				return this.X0Y0_カップ右_柄_柄3_柄1.Dra;
			}
			set
			{
				this.X0Y0_カップ右_柄_柄3_柄1.Dra = value;
				this.X0Y0_カップ右_柄_柄3_柄1.Hit = false;
			}
		}

		public bool カップ右_柄_柄3_柄2_表示
		{
			get
			{
				return this.X0Y0_カップ右_柄_柄3_柄2.Dra;
			}
			set
			{
				this.X0Y0_カップ右_柄_柄3_柄2.Dra = value;
				this.X0Y0_カップ右_柄_柄3_柄2.Hit = false;
			}
		}

		public bool カップ右_柄_柄4_柄1_表示
		{
			get
			{
				return this.X0Y0_カップ右_柄_柄4_柄1.Dra;
			}
			set
			{
				this.X0Y0_カップ右_柄_柄4_柄1.Dra = value;
				this.X0Y0_カップ右_柄_柄4_柄1.Hit = false;
			}
		}

		public bool カップ右_柄_柄4_柄2_表示
		{
			get
			{
				return this.X0Y0_カップ右_柄_柄4_柄2.Dra;
			}
			set
			{
				this.X0Y0_カップ右_柄_柄4_柄2.Dra = value;
				this.X0Y0_カップ右_柄_柄4_柄2.Hit = false;
			}
		}

		public bool カップ右_柄_柄5_柄1_表示
		{
			get
			{
				return this.X0Y0_カップ右_柄_柄5_柄1.Dra;
			}
			set
			{
				this.X0Y0_カップ右_柄_柄5_柄1.Dra = value;
				this.X0Y0_カップ右_柄_柄5_柄1.Hit = false;
			}
		}

		public bool カップ右_柄_柄5_柄2_表示
		{
			get
			{
				return this.X0Y0_カップ右_柄_柄5_柄2.Dra;
			}
			set
			{
				this.X0Y0_カップ右_柄_柄5_柄2.Dra = value;
				this.X0Y0_カップ右_柄_柄5_柄2.Hit = false;
			}
		}

		public bool カップ右_柄_柄6_柄1_表示
		{
			get
			{
				return this.X0Y0_カップ右_柄_柄6_柄1.Dra;
			}
			set
			{
				this.X0Y0_カップ右_柄_柄6_柄1.Dra = value;
				this.X0Y0_カップ右_柄_柄6_柄1.Hit = false;
			}
		}

		public bool カップ右_柄_柄6_柄2_表示
		{
			get
			{
				return this.X0Y0_カップ右_柄_柄6_柄2.Dra;
			}
			set
			{
				this.X0Y0_カップ右_柄_柄6_柄2.Dra = value;
				this.X0Y0_カップ右_柄_柄6_柄2.Hit = false;
			}
		}

		public bool カップ右_柄_柄7_柄1_表示
		{
			get
			{
				return this.X0Y0_カップ右_柄_柄7_柄1.Dra;
			}
			set
			{
				this.X0Y0_カップ右_柄_柄7_柄1.Dra = value;
				this.X0Y0_カップ右_柄_柄7_柄1.Hit = false;
			}
		}

		public bool カップ右_柄_柄7_柄2_表示
		{
			get
			{
				return this.X0Y0_カップ右_柄_柄7_柄2.Dra;
			}
			set
			{
				this.X0Y0_カップ右_柄_柄7_柄2.Dra = value;
				this.X0Y0_カップ右_柄_柄7_柄2.Hit = false;
			}
		}

		public bool カップ右_縁_縁1_表示
		{
			get
			{
				return this.X0Y0_カップ右_縁_縁1.Dra;
			}
			set
			{
				this.X0Y0_カップ右_縁_縁1.Dra = value;
				this.X0Y0_カップ右_縁_縁1.Hit = false;
			}
		}

		public bool カップ右_縁_縁2_表示
		{
			get
			{
				return this.X0Y0_カップ右_縁_縁2.Dra;
			}
			set
			{
				this.X0Y0_カップ右_縁_縁2.Dra = value;
				this.X0Y0_カップ右_縁_縁2.Hit = false;
			}
		}

		public bool カップ右_縁_縁3_表示
		{
			get
			{
				return this.X0Y0_カップ右_縁_縁3.Dra;
			}
			set
			{
				this.X0Y0_カップ右_縁_縁3.Dra = value;
				this.X0Y0_カップ右_縁_縁3.Hit = false;
			}
		}

		public bool カップ右_縁_縁4_表示
		{
			get
			{
				return this.X0Y0_カップ右_縁_縁4.Dra;
			}
			set
			{
				this.X0Y0_カップ右_縁_縁4.Dra = value;
				this.X0Y0_カップ右_縁_縁4.Hit = false;
			}
		}

		public bool リボン_リボン_表示
		{
			get
			{
				return this.X0Y0_リボン_リボン.Dra;
			}
			set
			{
				this.X0Y0_リボン_リボン.Dra = value;
				this.X0Y0_リボン_リボン.Hit = false;
			}
		}

		public bool リボン_結び目_表示
		{
			get
			{
				return this.X0Y0_リボン_結び目.Dra;
			}
			set
			{
				this.X0Y0_リボン_結び目.Dra = value;
				this.X0Y0_リボン_結び目.Hit = false;
			}
		}

		public bool ベ\u30FCス表示
		{
			get
			{
				return this.バンド_バンド_表示;
			}
			set
			{
				this.バンド_バンド_表示 = value;
				this.カップ左_カップ1_表示 = value;
				this.カップ右_カップ1_表示 = value;
				this.カップ左_カップ2_表示 = value;
				this.カップ右_カップ2_表示 = value;
				this.カップ左_紐_表示 = value;
				this.カップ右_紐_表示 = value;
			}
		}

		public bool 縁1表示
		{
			get
			{
				return this.バンド_縁_上_表示;
			}
			set
			{
				this.バンド_縁_上_表示 = value;
			}
		}

		public bool 縁2表示
		{
			get
			{
				return this.カップ左_縁_縁3_表示;
			}
			set
			{
				this.カップ左_縁_縁3_表示 = value;
				this.カップ右_縁_縁3_表示 = value;
			}
		}

		public bool 縁3表示
		{
			get
			{
				return this.カップ左_縁_縁2_表示;
			}
			set
			{
				this.カップ左_縁_縁2_表示 = value;
				this.カップ右_縁_縁2_表示 = value;
			}
		}

		public bool 縁4表示
		{
			get
			{
				return this.カップ左_縁_縁1_表示;
			}
			set
			{
				this.カップ左_縁_縁1_表示 = value;
				this.カップ右_縁_縁1_表示 = value;
			}
		}

		public bool 縁5表示
		{
			get
			{
				return this.バンド_縁_左_表示;
			}
			set
			{
				this.バンド_縁_左_表示 = value;
				this.バンド_縁_右_表示 = value;
			}
		}

		public bool 縁6表示
		{
			get
			{
				return this.カップ左_縁_縁4_表示;
			}
			set
			{
				this.カップ左_縁_縁4_表示 = value;
				this.カップ右_縁_縁4_表示 = value;
			}
		}

		public bool 縁7表示
		{
			get
			{
				return this.バンド_縁_下_表示;
			}
			set
			{
				this.バンド_縁_下_表示 = value;
			}
		}

		public bool ジャスタ\u30FC表示
		{
			get
			{
				return this.カップ左_ジャスタ\u30FC_ジャスタ\u30FC1_表示;
			}
			set
			{
				this.カップ左_ジャスタ\u30FC_ジャスタ\u30FC1_表示 = value;
				this.カップ左_ジャスタ\u30FC_ジャスタ\u30FC2_表示 = value;
				this.カップ左_ジャスタ\u30FC_ジャスタ\u30FC3_表示 = value;
				this.カップ左_ジャスタ\u30FC_ジャスタ\u30FC4_表示 = value;
				this.カップ右_ジャスタ\u30FC_ジャスタ\u30FC1_表示 = value;
				this.カップ右_ジャスタ\u30FC_ジャスタ\u30FC2_表示 = value;
				this.カップ右_ジャスタ\u30FC_ジャスタ\u30FC3_表示 = value;
				this.カップ右_ジャスタ\u30FC_ジャスタ\u30FC4_表示 = value;
			}
		}

		public bool レ\u30FCス表示
		{
			get
			{
				return this.カップ左_レ\u30FCス_レ\u30FCス1_表示;
			}
			set
			{
				this.カップ左_レ\u30FCス_レ\u30FCス1_表示 = value;
				this.カップ右_レ\u30FCス_レ\u30FCス1_表示 = value;
				this.カップ左_レ\u30FCス_レ\u30FCス2_表示 = value;
				this.カップ右_レ\u30FCス_レ\u30FCス2_表示 = value;
				this.カップ左_レ\u30FCス_レ\u30FCス3_表示 = value;
				this.カップ右_レ\u30FCス_レ\u30FCス3_表示 = value;
				this.カップ左_レ\u30FCス_レ\u30FCス4_表示 = value;
				this.カップ右_レ\u30FCス_レ\u30FCス4_表示 = value;
				this.カップ左_レ\u30FCス_レ\u30FCス5_表示 = value;
				this.カップ右_レ\u30FCス_レ\u30FCス5_表示 = value;
				this.カップ左_レ\u30FCス_レ\u30FCス6_表示 = value;
				this.カップ右_レ\u30FCス_レ\u30FCス6_表示 = value;
				this.カップ左_レ\u30FCス_レ\u30FCス7_表示 = value;
				this.カップ右_レ\u30FCス_レ\u30FCス7_表示 = value;
				this.カップ左_レ\u30FCス_レ\u30FCス8_表示 = value;
				this.カップ右_レ\u30FCス_レ\u30FCス8_表示 = value;
				this.カップ左_レ\u30FCス_レ\u30FCス9_表示 = value;
				this.カップ右_レ\u30FCス_レ\u30FCス9_表示 = value;
				this.カップ左_レ\u30FCス_レ\u30FCス10_表示 = value;
				this.カップ右_レ\u30FCス_レ\u30FCス10_表示 = value;
				this.カップ左_レ\u30FCス_レ\u30FCス11_表示 = value;
				this.カップ右_レ\u30FCス_レ\u30FCス11_表示 = value;
				this.カップ左_レ\u30FCス_レ\u30FCス12_表示 = value;
				this.カップ右_レ\u30FCス_レ\u30FCス12_表示 = value;
			}
		}

		public bool 柄1表示
		{
			get
			{
				return this.カップ左_柄_柄1_柄1_表示;
			}
			set
			{
				this.カップ左_柄_柄1_柄1_表示 = value;
				this.カップ右_柄_柄1_柄1_表示 = value;
			}
		}

		public bool 柄2表示
		{
			get
			{
				return this.カップ左_柄_柄1_柄2_表示;
			}
			set
			{
				this.カップ左_柄_柄1_柄2_表示 = value;
				this.カップ右_柄_柄1_柄2_表示 = value;
			}
		}

		public bool 柄3表示
		{
			get
			{
				return this.カップ左_柄_柄2_柄1_表示;
			}
			set
			{
				this.カップ左_柄_柄2_柄1_表示 = value;
				this.カップ右_柄_柄2_柄1_表示 = value;
			}
		}

		public bool 柄4表示
		{
			get
			{
				return this.カップ左_柄_柄2_柄2_表示;
			}
			set
			{
				this.カップ左_柄_柄2_柄2_表示 = value;
				this.カップ右_柄_柄2_柄2_表示 = value;
			}
		}

		public bool 柄5表示
		{
			get
			{
				return this.カップ左_柄_柄3_柄1_表示;
			}
			set
			{
				this.カップ左_柄_柄3_柄1_表示 = value;
				this.カップ右_柄_柄3_柄1_表示 = value;
			}
		}

		public bool 柄6表示
		{
			get
			{
				return this.カップ左_柄_柄3_柄2_表示;
			}
			set
			{
				this.カップ左_柄_柄3_柄2_表示 = value;
				this.カップ右_柄_柄3_柄2_表示 = value;
			}
		}

		public bool 柄7表示
		{
			get
			{
				return this.カップ左_柄_柄4_柄1_表示;
			}
			set
			{
				this.カップ左_柄_柄4_柄1_表示 = value;
				this.カップ右_柄_柄4_柄1_表示 = value;
			}
		}

		public bool 柄8表示
		{
			get
			{
				return this.カップ左_柄_柄4_柄2_表示;
			}
			set
			{
				this.カップ左_柄_柄4_柄2_表示 = value;
				this.カップ右_柄_柄4_柄2_表示 = value;
			}
		}

		public bool 柄9表示
		{
			get
			{
				return this.カップ左_柄_柄5_柄1_表示;
			}
			set
			{
				this.カップ左_柄_柄5_柄1_表示 = value;
				this.カップ右_柄_柄5_柄1_表示 = value;
			}
		}

		public bool 柄10表示
		{
			get
			{
				return this.カップ左_柄_柄5_柄2_表示;
			}
			set
			{
				this.カップ左_柄_柄5_柄2_表示 = value;
				this.カップ右_柄_柄5_柄2_表示 = value;
			}
		}

		public bool 柄11表示
		{
			get
			{
				return this.カップ左_柄_柄6_柄1_表示;
			}
			set
			{
				this.カップ左_柄_柄6_柄1_表示 = value;
				this.カップ右_柄_柄6_柄1_表示 = value;
			}
		}

		public bool 柄12表示
		{
			get
			{
				return this.カップ左_柄_柄6_柄2_表示;
			}
			set
			{
				this.カップ左_柄_柄6_柄2_表示 = value;
				this.カップ右_柄_柄6_柄2_表示 = value;
			}
		}

		public bool 柄13表示
		{
			get
			{
				return this.カップ左_柄_柄7_柄1_表示;
			}
			set
			{
				this.カップ左_柄_柄7_柄1_表示 = value;
				this.カップ右_柄_柄7_柄1_表示 = value;
			}
		}

		public bool 柄14表示
		{
			get
			{
				return this.カップ左_柄_柄7_柄2_表示;
			}
			set
			{
				this.カップ左_柄_柄7_柄2_表示 = value;
				this.カップ右_柄_柄7_柄2_表示 = value;
			}
		}

		public bool リボン表示
		{
			get
			{
				return this.リボン_リボン_表示;
			}
			set
			{
				this.リボン_リボン_表示 = value;
			}
		}

		public bool リボン結び目表示
		{
			get
			{
				return this.リボン_結び目_表示;
			}
			set
			{
				this.リボン_結び目_表示 = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.バンド_バンド_表示;
			}
			set
			{
				this.バンド_バンド_表示 = value;
				this.バンド_縁_下_表示 = value;
				this.バンド_縁_上_表示 = value;
				this.バンド_縁_左_表示 = value;
				this.バンド_縁_右_表示 = value;
				this.カップ左_紐_表示 = value;
				this.カップ左_ジャスタ\u30FC_ジャスタ\u30FC1_表示 = value;
				this.カップ左_ジャスタ\u30FC_ジャスタ\u30FC2_表示 = value;
				this.カップ左_ジャスタ\u30FC_ジャスタ\u30FC3_表示 = value;
				this.カップ左_ジャスタ\u30FC_ジャスタ\u30FC4_表示 = value;
				this.カップ左_カップ2_表示 = value;
				this.カップ左_レ\u30FCス_レ\u30FCス1_表示 = value;
				this.カップ左_レ\u30FCス_レ\u30FCス2_表示 = value;
				this.カップ左_レ\u30FCス_レ\u30FCス3_表示 = value;
				this.カップ左_レ\u30FCス_レ\u30FCス4_表示 = value;
				this.カップ左_レ\u30FCス_レ\u30FCス5_表示 = value;
				this.カップ左_レ\u30FCス_レ\u30FCス6_表示 = value;
				this.カップ左_レ\u30FCス_レ\u30FCス7_表示 = value;
				this.カップ左_レ\u30FCス_レ\u30FCス8_表示 = value;
				this.カップ左_レ\u30FCス_レ\u30FCス9_表示 = value;
				this.カップ左_レ\u30FCス_レ\u30FCス10_表示 = value;
				this.カップ左_レ\u30FCス_レ\u30FCス11_表示 = value;
				this.カップ左_レ\u30FCス_レ\u30FCス12_表示 = value;
				this.カップ左_カップ1_表示 = value;
				this.カップ左_柄_柄1_柄1_表示 = value;
				this.カップ左_柄_柄1_柄2_表示 = value;
				this.カップ左_柄_柄2_柄1_表示 = value;
				this.カップ左_柄_柄2_柄2_表示 = value;
				this.カップ左_柄_柄3_柄1_表示 = value;
				this.カップ左_柄_柄3_柄2_表示 = value;
				this.カップ左_柄_柄4_柄1_表示 = value;
				this.カップ左_柄_柄4_柄2_表示 = value;
				this.カップ左_柄_柄5_柄1_表示 = value;
				this.カップ左_柄_柄5_柄2_表示 = value;
				this.カップ左_柄_柄6_柄1_表示 = value;
				this.カップ左_柄_柄6_柄2_表示 = value;
				this.カップ左_柄_柄7_柄1_表示 = value;
				this.カップ左_柄_柄7_柄2_表示 = value;
				this.カップ左_縁_縁1_表示 = value;
				this.カップ左_縁_縁2_表示 = value;
				this.カップ左_縁_縁3_表示 = value;
				this.カップ左_縁_縁4_表示 = value;
				this.カップ右_紐_表示 = value;
				this.カップ右_ジャスタ\u30FC_ジャスタ\u30FC1_表示 = value;
				this.カップ右_ジャスタ\u30FC_ジャスタ\u30FC2_表示 = value;
				this.カップ右_ジャスタ\u30FC_ジャスタ\u30FC3_表示 = value;
				this.カップ右_ジャスタ\u30FC_ジャスタ\u30FC4_表示 = value;
				this.カップ右_カップ2_表示 = value;
				this.カップ右_レ\u30FCス_レ\u30FCス1_表示 = value;
				this.カップ右_レ\u30FCス_レ\u30FCス2_表示 = value;
				this.カップ右_レ\u30FCス_レ\u30FCス3_表示 = value;
				this.カップ右_レ\u30FCス_レ\u30FCス4_表示 = value;
				this.カップ右_レ\u30FCス_レ\u30FCス5_表示 = value;
				this.カップ右_レ\u30FCス_レ\u30FCス6_表示 = value;
				this.カップ右_レ\u30FCス_レ\u30FCス7_表示 = value;
				this.カップ右_レ\u30FCス_レ\u30FCス8_表示 = value;
				this.カップ右_レ\u30FCス_レ\u30FCス9_表示 = value;
				this.カップ右_レ\u30FCス_レ\u30FCス10_表示 = value;
				this.カップ右_レ\u30FCス_レ\u30FCス11_表示 = value;
				this.カップ右_レ\u30FCス_レ\u30FCス12_表示 = value;
				this.カップ右_カップ1_表示 = value;
				this.カップ右_柄_柄1_柄1_表示 = value;
				this.カップ右_柄_柄1_柄2_表示 = value;
				this.カップ右_柄_柄2_柄1_表示 = value;
				this.カップ右_柄_柄2_柄2_表示 = value;
				this.カップ右_柄_柄3_柄1_表示 = value;
				this.カップ右_柄_柄3_柄2_表示 = value;
				this.カップ右_柄_柄4_柄1_表示 = value;
				this.カップ右_柄_柄4_柄2_表示 = value;
				this.カップ右_柄_柄5_柄1_表示 = value;
				this.カップ右_柄_柄5_柄2_表示 = value;
				this.カップ右_柄_柄6_柄1_表示 = value;
				this.カップ右_柄_柄6_柄2_表示 = value;
				this.カップ右_柄_柄7_柄1_表示 = value;
				this.カップ右_柄_柄7_柄2_表示 = value;
				this.カップ右_縁_縁1_表示 = value;
				this.カップ右_縁_縁2_表示 = value;
				this.カップ右_縁_縁3_表示 = value;
				this.カップ右_縁_縁4_表示 = value;
				this.リボン_リボン_表示 = value;
				this.リボン_結び目_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.バンド_バンドCD.不透明度;
			}
			set
			{
				this.バンド_バンドCD.不透明度 = value;
				this.バンド_縁_下CD.不透明度 = value;
				this.バンド_縁_上CD.不透明度 = value;
				this.バンド_縁_左CD.不透明度 = value;
				this.バンド_縁_右CD.不透明度 = value;
				this.カップ左_紐CD.不透明度 = value;
				this.カップ左_ジャスタ\u30FC_ジャスタ\u30FC1CD.不透明度 = value;
				this.カップ左_ジャスタ\u30FC_ジャスタ\u30FC2CD.不透明度 = value;
				this.カップ左_ジャスタ\u30FC_ジャスタ\u30FC3CD.不透明度 = value;
				this.カップ左_ジャスタ\u30FC_ジャスタ\u30FC4CD.不透明度 = value;
				this.カップ左_カップ2CD.不透明度 = value;
				this.カップ左_レ\u30FCス_レ\u30FCス1CD.不透明度 = value;
				this.カップ左_レ\u30FCス_レ\u30FCス2CD.不透明度 = value;
				this.カップ左_レ\u30FCス_レ\u30FCス3CD.不透明度 = value;
				this.カップ左_レ\u30FCス_レ\u30FCス4CD.不透明度 = value;
				this.カップ左_レ\u30FCス_レ\u30FCス5CD.不透明度 = value;
				this.カップ左_レ\u30FCス_レ\u30FCス6CD.不透明度 = value;
				this.カップ左_レ\u30FCス_レ\u30FCス7CD.不透明度 = value;
				this.カップ左_レ\u30FCス_レ\u30FCス8CD.不透明度 = value;
				this.カップ左_レ\u30FCス_レ\u30FCス9CD.不透明度 = value;
				this.カップ左_レ\u30FCス_レ\u30FCス10CD.不透明度 = value;
				this.カップ左_レ\u30FCス_レ\u30FCス11CD.不透明度 = value;
				this.カップ左_レ\u30FCス_レ\u30FCス12CD.不透明度 = value;
				this.カップ左_カップ1CD.不透明度 = value;
				this.カップ左_柄_柄1_柄1CD.不透明度 = value;
				this.カップ左_柄_柄1_柄2CD.不透明度 = value;
				this.カップ左_柄_柄2_柄1CD.不透明度 = value;
				this.カップ左_柄_柄2_柄2CD.不透明度 = value;
				this.カップ左_柄_柄3_柄1CD.不透明度 = value;
				this.カップ左_柄_柄3_柄2CD.不透明度 = value;
				this.カップ左_柄_柄4_柄1CD.不透明度 = value;
				this.カップ左_柄_柄4_柄2CD.不透明度 = value;
				this.カップ左_柄_柄5_柄1CD.不透明度 = value;
				this.カップ左_柄_柄5_柄2CD.不透明度 = value;
				this.カップ左_柄_柄6_柄1CD.不透明度 = value;
				this.カップ左_柄_柄6_柄2CD.不透明度 = value;
				this.カップ左_柄_柄7_柄1CD.不透明度 = value;
				this.カップ左_柄_柄7_柄2CD.不透明度 = value;
				this.カップ左_縁_縁1CD.不透明度 = value;
				this.カップ左_縁_縁2CD.不透明度 = value;
				this.カップ左_縁_縁3CD.不透明度 = value;
				this.カップ左_縁_縁4CD.不透明度 = value;
				this.カップ右_紐CD.不透明度 = value;
				this.カップ右_ジャスタ\u30FC_ジャスタ\u30FC1CD.不透明度 = value;
				this.カップ右_ジャスタ\u30FC_ジャスタ\u30FC2CD.不透明度 = value;
				this.カップ右_ジャスタ\u30FC_ジャスタ\u30FC3CD.不透明度 = value;
				this.カップ右_ジャスタ\u30FC_ジャスタ\u30FC4CD.不透明度 = value;
				this.カップ右_カップ2CD.不透明度 = value;
				this.カップ右_レ\u30FCス_レ\u30FCス1CD.不透明度 = value;
				this.カップ右_レ\u30FCス_レ\u30FCス2CD.不透明度 = value;
				this.カップ右_レ\u30FCス_レ\u30FCス3CD.不透明度 = value;
				this.カップ右_レ\u30FCス_レ\u30FCス4CD.不透明度 = value;
				this.カップ右_レ\u30FCス_レ\u30FCス5CD.不透明度 = value;
				this.カップ右_レ\u30FCス_レ\u30FCス6CD.不透明度 = value;
				this.カップ右_レ\u30FCス_レ\u30FCス7CD.不透明度 = value;
				this.カップ右_レ\u30FCス_レ\u30FCス8CD.不透明度 = value;
				this.カップ右_レ\u30FCス_レ\u30FCス9CD.不透明度 = value;
				this.カップ右_レ\u30FCス_レ\u30FCス10CD.不透明度 = value;
				this.カップ右_レ\u30FCス_レ\u30FCス11CD.不透明度 = value;
				this.カップ右_レ\u30FCス_レ\u30FCス12CD.不透明度 = value;
				this.カップ右_カップ1CD.不透明度 = value;
				this.カップ右_柄_柄1_柄1CD.不透明度 = value;
				this.カップ右_柄_柄1_柄2CD.不透明度 = value;
				this.カップ右_柄_柄2_柄1CD.不透明度 = value;
				this.カップ右_柄_柄2_柄2CD.不透明度 = value;
				this.カップ右_柄_柄3_柄1CD.不透明度 = value;
				this.カップ右_柄_柄3_柄2CD.不透明度 = value;
				this.カップ右_柄_柄4_柄1CD.不透明度 = value;
				this.カップ右_柄_柄4_柄2CD.不透明度 = value;
				this.カップ右_柄_柄5_柄1CD.不透明度 = value;
				this.カップ右_柄_柄5_柄2CD.不透明度 = value;
				this.カップ右_柄_柄6_柄1CD.不透明度 = value;
				this.カップ右_柄_柄6_柄2CD.不透明度 = value;
				this.カップ右_柄_柄7_柄1CD.不透明度 = value;
				this.カップ右_柄_柄7_柄2CD.不透明度 = value;
				this.カップ右_縁_縁1CD.不透明度 = value;
				this.カップ右_縁_縁2CD.不透明度 = value;
				this.カップ右_縁_縁3CD.不透明度 = value;
				this.カップ右_縁_縁4CD.不透明度 = value;
				this.リボン_リボンCD.不透明度 = value;
				this.リボン_結び目CD.不透明度 = value;
			}
		}

		public double バスト
		{
			set
			{
				double num = this.sb * (0.9 + 0.25 * value);
				this.X0Y0_カップ左_紐.SizeBase = num;
				this.X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC1.SizeBase = num;
				this.X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC2.SizeBase = num;
				this.X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC3.SizeBase = num;
				this.X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC4.SizeBase = num;
				this.X0Y0_カップ左_カップ2.SizeBase = num;
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス1.SizeBase = num;
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス2.SizeBase = num;
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス3.SizeBase = num;
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス4.SizeBase = num;
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス5.SizeBase = num;
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス6.SizeBase = num;
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス7.SizeBase = num;
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス8.SizeBase = num;
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス9.SizeBase = num;
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス10.SizeBase = num;
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス11.SizeBase = num;
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス12.SizeBase = num;
				this.X0Y0_カップ左_カップ1.SizeBase = num;
				this.X0Y0_カップ左_柄_柄1_柄1.SizeBase = num;
				this.X0Y0_カップ左_柄_柄1_柄2.SizeBase = num;
				this.X0Y0_カップ左_柄_柄2_柄1.SizeBase = num;
				this.X0Y0_カップ左_柄_柄2_柄2.SizeBase = num;
				this.X0Y0_カップ左_柄_柄3_柄1.SizeBase = num;
				this.X0Y0_カップ左_柄_柄3_柄2.SizeBase = num;
				this.X0Y0_カップ左_柄_柄4_柄1.SizeBase = num;
				this.X0Y0_カップ左_柄_柄4_柄2.SizeBase = num;
				this.X0Y0_カップ左_柄_柄5_柄1.SizeBase = num;
				this.X0Y0_カップ左_柄_柄5_柄2.SizeBase = num;
				this.X0Y0_カップ左_柄_柄6_柄1.SizeBase = num;
				this.X0Y0_カップ左_柄_柄6_柄2.SizeBase = num;
				this.X0Y0_カップ左_柄_柄7_柄1.SizeBase = num;
				this.X0Y0_カップ左_柄_柄7_柄2.SizeBase = num;
				this.X0Y0_カップ左_縁_縁1.SizeBase = num;
				this.X0Y0_カップ左_縁_縁2.SizeBase = num;
				this.X0Y0_カップ左_縁_縁3.SizeBase = num;
				this.X0Y0_カップ左_縁_縁4.SizeBase = num;
				this.X0Y0_カップ右_紐.SizeBase = num;
				this.X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC1.SizeBase = num;
				this.X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC2.SizeBase = num;
				this.X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC3.SizeBase = num;
				this.X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC4.SizeBase = num;
				this.X0Y0_カップ右_カップ2.SizeBase = num;
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス1.SizeBase = num;
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス2.SizeBase = num;
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス3.SizeBase = num;
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス4.SizeBase = num;
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス5.SizeBase = num;
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス6.SizeBase = num;
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス7.SizeBase = num;
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス8.SizeBase = num;
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス9.SizeBase = num;
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス10.SizeBase = num;
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス11.SizeBase = num;
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス12.SizeBase = num;
				this.X0Y0_カップ右_カップ1.SizeBase = num;
				this.X0Y0_カップ右_柄_柄1_柄1.SizeBase = num;
				this.X0Y0_カップ右_柄_柄1_柄2.SizeBase = num;
				this.X0Y0_カップ右_柄_柄2_柄1.SizeBase = num;
				this.X0Y0_カップ右_柄_柄2_柄2.SizeBase = num;
				this.X0Y0_カップ右_柄_柄3_柄1.SizeBase = num;
				this.X0Y0_カップ右_柄_柄3_柄2.SizeBase = num;
				this.X0Y0_カップ右_柄_柄4_柄1.SizeBase = num;
				this.X0Y0_カップ右_柄_柄4_柄2.SizeBase = num;
				this.X0Y0_カップ右_柄_柄5_柄1.SizeBase = num;
				this.X0Y0_カップ右_柄_柄5_柄2.SizeBase = num;
				this.X0Y0_カップ右_柄_柄6_柄1.SizeBase = num;
				this.X0Y0_カップ右_柄_柄6_柄2.SizeBase = num;
				this.X0Y0_カップ右_柄_柄7_柄1.SizeBase = num;
				this.X0Y0_カップ右_柄_柄7_柄2.SizeBase = num;
				this.X0Y0_カップ右_縁_縁1.SizeBase = num;
				this.X0Y0_カップ右_縁_縁2.SizeBase = num;
				this.X0Y0_カップ右_縁_縁3.SizeBase = num;
				this.X0Y0_カップ右_縁_縁4.SizeBase = num;
				this.X0Y0_リボン_リボン.SizeBase = num;
				this.X0Y0_リボン_結び目.SizeBase = num;
				num = this.syb * (1.0 + 0.05 * value);
				this.X0Y0_カップ左_紐.SizeYBase = num;
				this.X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC1.SizeYBase = num;
				this.X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC2.SizeYBase = num;
				this.X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC3.SizeYBase = num;
				this.X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC4.SizeYBase = num;
				this.X0Y0_カップ左_カップ2.SizeYBase = num;
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス1.SizeYBase = num;
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス2.SizeYBase = num;
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス3.SizeYBase = num;
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス4.SizeYBase = num;
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス5.SizeYBase = num;
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス6.SizeYBase = num;
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス7.SizeYBase = num;
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス8.SizeYBase = num;
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス9.SizeYBase = num;
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス10.SizeYBase = num;
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス11.SizeYBase = num;
				this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス12.SizeYBase = num;
				this.X0Y0_カップ左_カップ1.SizeYBase = num;
				this.X0Y0_カップ左_柄_柄1_柄1.SizeYBase = num;
				this.X0Y0_カップ左_柄_柄1_柄2.SizeYBase = num;
				this.X0Y0_カップ左_柄_柄2_柄1.SizeYBase = num;
				this.X0Y0_カップ左_柄_柄2_柄2.SizeYBase = num;
				this.X0Y0_カップ左_柄_柄3_柄1.SizeYBase = num;
				this.X0Y0_カップ左_柄_柄3_柄2.SizeYBase = num;
				this.X0Y0_カップ左_柄_柄4_柄1.SizeYBase = num;
				this.X0Y0_カップ左_柄_柄4_柄2.SizeYBase = num;
				this.X0Y0_カップ左_柄_柄5_柄1.SizeYBase = num;
				this.X0Y0_カップ左_柄_柄5_柄2.SizeYBase = num;
				this.X0Y0_カップ左_柄_柄6_柄1.SizeYBase = num;
				this.X0Y0_カップ左_柄_柄6_柄2.SizeYBase = num;
				this.X0Y0_カップ左_柄_柄7_柄1.SizeYBase = num;
				this.X0Y0_カップ左_柄_柄7_柄2.SizeYBase = num;
				this.X0Y0_カップ左_縁_縁1.SizeYBase = num;
				this.X0Y0_カップ左_縁_縁2.SizeYBase = num;
				this.X0Y0_カップ左_縁_縁3.SizeYBase = num;
				this.X0Y0_カップ左_縁_縁4.SizeYBase = num;
				this.X0Y0_カップ右_紐.SizeYBase = num;
				this.X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC1.SizeYBase = num;
				this.X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC2.SizeYBase = num;
				this.X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC3.SizeYBase = num;
				this.X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC4.SizeYBase = num;
				this.X0Y0_カップ右_カップ2.SizeYBase = num;
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス1.SizeYBase = num;
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス2.SizeYBase = num;
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス3.SizeYBase = num;
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス4.SizeYBase = num;
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス5.SizeYBase = num;
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス6.SizeYBase = num;
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス7.SizeYBase = num;
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス8.SizeYBase = num;
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス9.SizeYBase = num;
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス10.SizeYBase = num;
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス11.SizeYBase = num;
				this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス12.SizeYBase = num;
				this.X0Y0_カップ右_カップ1.SizeYBase = num;
				this.X0Y0_カップ右_柄_柄1_柄1.SizeYBase = num;
				this.X0Y0_カップ右_柄_柄1_柄2.SizeYBase = num;
				this.X0Y0_カップ右_柄_柄2_柄1.SizeYBase = num;
				this.X0Y0_カップ右_柄_柄2_柄2.SizeYBase = num;
				this.X0Y0_カップ右_柄_柄3_柄1.SizeYBase = num;
				this.X0Y0_カップ右_柄_柄3_柄2.SizeYBase = num;
				this.X0Y0_カップ右_柄_柄4_柄1.SizeYBase = num;
				this.X0Y0_カップ右_柄_柄4_柄2.SizeYBase = num;
				this.X0Y0_カップ右_柄_柄5_柄1.SizeYBase = num;
				this.X0Y0_カップ右_柄_柄5_柄2.SizeYBase = num;
				this.X0Y0_カップ右_柄_柄6_柄1.SizeYBase = num;
				this.X0Y0_カップ右_柄_柄6_柄2.SizeYBase = num;
				this.X0Y0_カップ右_柄_柄7_柄1.SizeYBase = num;
				this.X0Y0_カップ右_柄_柄7_柄2.SizeYBase = num;
				this.X0Y0_カップ右_縁_縁1.SizeYBase = num;
				this.X0Y0_カップ右_縁_縁2.SizeYBase = num;
				this.X0Y0_カップ右_縁_縁3.SizeYBase = num;
				this.X0Y0_カップ右_縁_縁4.SizeYBase = num;
				this.X0Y0_リボン_リボン.SizeYBase = num;
				this.X0Y0_リボン_結び目.SizeYBase = num;
				num = 1.0 + (-0.5 * value + 0.2 * value.Inverse());
				this.X0Y0_カップ左_紐.SizeYBase *= num;
				this.X0Y0_カップ右_紐.SizeYBase *= num;
				this.位置C = new Vector2D(this.位置C.X, -0.003 * this.肥大);
			}
		}

		public override void 描画0(Are Are)
		{
			Are.Draw(this.X0Y0_バンド_バンド);
			Are.Draw(this.X0Y0_バンド_縁_下);
			Are.Draw(this.X0Y0_バンド_縁_上);
			Are.Draw(this.X0Y0_バンド_縁_左);
			Are.Draw(this.X0Y0_バンド_縁_右);
		}

		public override void 描画1(Are Are)
		{
			Are.Draw(this.X0Y0_カップ左_紐);
			Are.Draw(this.X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC1);
			Are.Draw(this.X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC2);
			Are.Draw(this.X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC3);
			Are.Draw(this.X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC4);
			Are.Draw(this.X0Y0_カップ左_カップ2);
			Are.Draw(this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス1);
			Are.Draw(this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス2);
			Are.Draw(this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス3);
			Are.Draw(this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス4);
			Are.Draw(this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス5);
			Are.Draw(this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス6);
			Are.Draw(this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス7);
			Are.Draw(this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス8);
			Are.Draw(this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス9);
			Are.Draw(this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス10);
			Are.Draw(this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス11);
			Are.Draw(this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス12);
			Are.Draw(this.X0Y0_カップ左_カップ1);
			Are.Draw(this.X0Y0_カップ左_柄_柄1_柄1);
			Are.Draw(this.X0Y0_カップ左_柄_柄1_柄2);
			Are.Draw(this.X0Y0_カップ左_柄_柄2_柄1);
			Are.Draw(this.X0Y0_カップ左_柄_柄2_柄2);
			Are.Draw(this.X0Y0_カップ左_柄_柄3_柄1);
			Are.Draw(this.X0Y0_カップ左_柄_柄3_柄2);
			Are.Draw(this.X0Y0_カップ左_柄_柄4_柄1);
			Are.Draw(this.X0Y0_カップ左_柄_柄4_柄2);
			Are.Draw(this.X0Y0_カップ左_柄_柄5_柄1);
			Are.Draw(this.X0Y0_カップ左_柄_柄5_柄2);
			Are.Draw(this.X0Y0_カップ左_柄_柄6_柄1);
			Are.Draw(this.X0Y0_カップ左_柄_柄6_柄2);
			Are.Draw(this.X0Y0_カップ左_柄_柄7_柄1);
			Are.Draw(this.X0Y0_カップ左_柄_柄7_柄2);
			Are.Draw(this.X0Y0_カップ左_縁_縁1);
			Are.Draw(this.X0Y0_カップ左_縁_縁2);
			Are.Draw(this.X0Y0_カップ左_縁_縁3);
			Are.Draw(this.X0Y0_カップ左_縁_縁4);
			Are.Draw(this.X0Y0_カップ右_紐);
			Are.Draw(this.X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC1);
			Are.Draw(this.X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC2);
			Are.Draw(this.X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC3);
			Are.Draw(this.X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC4);
			Are.Draw(this.X0Y0_カップ右_カップ2);
			Are.Draw(this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス1);
			Are.Draw(this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス2);
			Are.Draw(this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス3);
			Are.Draw(this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス4);
			Are.Draw(this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス5);
			Are.Draw(this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス6);
			Are.Draw(this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス7);
			Are.Draw(this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス8);
			Are.Draw(this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス9);
			Are.Draw(this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス10);
			Are.Draw(this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス11);
			Are.Draw(this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス12);
			Are.Draw(this.X0Y0_カップ右_カップ1);
			Are.Draw(this.X0Y0_カップ右_柄_柄1_柄1);
			Are.Draw(this.X0Y0_カップ右_柄_柄1_柄2);
			Are.Draw(this.X0Y0_カップ右_柄_柄2_柄1);
			Are.Draw(this.X0Y0_カップ右_柄_柄2_柄2);
			Are.Draw(this.X0Y0_カップ右_柄_柄3_柄1);
			Are.Draw(this.X0Y0_カップ右_柄_柄3_柄2);
			Are.Draw(this.X0Y0_カップ右_柄_柄4_柄1);
			Are.Draw(this.X0Y0_カップ右_柄_柄4_柄2);
			Are.Draw(this.X0Y0_カップ右_柄_柄5_柄1);
			Are.Draw(this.X0Y0_カップ右_柄_柄5_柄2);
			Are.Draw(this.X0Y0_カップ右_柄_柄6_柄1);
			Are.Draw(this.X0Y0_カップ右_柄_柄6_柄2);
			Are.Draw(this.X0Y0_カップ右_柄_柄7_柄1);
			Are.Draw(this.X0Y0_カップ右_柄_柄7_柄2);
			Are.Draw(this.X0Y0_カップ右_縁_縁1);
			Are.Draw(this.X0Y0_カップ右_縁_縁2);
			Are.Draw(this.X0Y0_カップ右_縁_縁3);
			Are.Draw(this.X0Y0_カップ右_縁_縁4);
			Are.Draw(this.X0Y0_リボン_リボン);
			Are.Draw(this.X0Y0_リボン_結び目);
		}

		public override bool Is布(Par p)
		{
			return p == this.X0Y0_バンド_バンド || p == this.X0Y0_バンド_縁_下 || p == this.X0Y0_バンド_縁_上 || p == this.X0Y0_バンド_縁_左 || p == this.X0Y0_バンド_縁_右 || p == this.X0Y0_カップ左_紐 || p == this.X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC1 || p == this.X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC2 || p == this.X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC3 || p == this.X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC4 || p == this.X0Y0_カップ左_カップ2 || p == this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス1 || p == this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス2 || p == this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス3 || p == this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス4 || p == this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス5 || p == this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス6 || p == this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス7 || p == this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス8 || p == this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス9 || p == this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス10 || p == this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス11 || p == this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス12 || p == this.X0Y0_カップ左_カップ1 || p == this.X0Y0_カップ左_柄_柄1_柄1 || p == this.X0Y0_カップ左_柄_柄1_柄2 || p == this.X0Y0_カップ左_柄_柄2_柄1 || p == this.X0Y0_カップ左_柄_柄2_柄2 || p == this.X0Y0_カップ左_柄_柄3_柄1 || p == this.X0Y0_カップ左_柄_柄3_柄2 || p == this.X0Y0_カップ左_柄_柄4_柄1 || p == this.X0Y0_カップ左_柄_柄4_柄2 || p == this.X0Y0_カップ左_柄_柄5_柄1 || p == this.X0Y0_カップ左_柄_柄5_柄2 || p == this.X0Y0_カップ左_柄_柄6_柄1 || p == this.X0Y0_カップ左_柄_柄6_柄2 || p == this.X0Y0_カップ左_柄_柄7_柄1 || p == this.X0Y0_カップ左_柄_柄7_柄2 || p == this.X0Y0_カップ左_縁_縁1 || p == this.X0Y0_カップ左_縁_縁2 || p == this.X0Y0_カップ左_縁_縁3 || p == this.X0Y0_カップ左_縁_縁4 || p == this.X0Y0_カップ右_紐 || p == this.X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC1 || p == this.X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC2 || p == this.X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC3 || p == this.X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC4 || p == this.X0Y0_カップ右_カップ2 || p == this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス1 || p == this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス2 || p == this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス3 || p == this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス4 || p == this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス5 || p == this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス6 || p == this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス7 || p == this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス8 || p == this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス9 || p == this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス10 || p == this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス11 || p == this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス12 || p == this.X0Y0_カップ右_カップ1 || p == this.X0Y0_カップ右_柄_柄1_柄1 || p == this.X0Y0_カップ右_柄_柄1_柄2 || p == this.X0Y0_カップ右_柄_柄2_柄1 || p == this.X0Y0_カップ右_柄_柄2_柄2 || p == this.X0Y0_カップ右_柄_柄3_柄1 || p == this.X0Y0_カップ右_柄_柄3_柄2 || p == this.X0Y0_カップ右_柄_柄4_柄1 || p == this.X0Y0_カップ右_柄_柄4_柄2 || p == this.X0Y0_カップ右_柄_柄5_柄1 || p == this.X0Y0_カップ右_柄_柄5_柄2 || p == this.X0Y0_カップ右_柄_柄6_柄1 || p == this.X0Y0_カップ右_柄_柄6_柄2 || p == this.X0Y0_カップ右_柄_柄7_柄1 || p == this.X0Y0_カップ右_柄_柄7_柄2 || p == this.X0Y0_カップ右_縁_縁1 || p == this.X0Y0_カップ右_縁_縁2 || p == this.X0Y0_カップ右_縁_縁3 || p == this.X0Y0_カップ右_縁_縁4 || p == this.X0Y0_リボン_リボン || p == this.X0Y0_リボン_結び目;
		}

		public override void 色更新()
		{
			this.X0Y0_バンド_バンドCP.Update();
			this.X0Y0_バンド_縁_下CP.Update();
			this.X0Y0_バンド_縁_上CP.Update();
			this.X0Y0_バンド_縁_左CP.Update();
			this.X0Y0_バンド_縁_右CP.Update();
			this.X0Y0_カップ左_紐CP.Update();
			this.X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC1CP.Update();
			this.X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC2CP.Update();
			this.X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC3CP.Update();
			this.X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC4CP.Update();
			this.X0Y0_カップ左_カップ2CP.Update();
			this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス1CP.Update();
			this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス2CP.Update();
			this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス3CP.Update();
			this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス4CP.Update();
			this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス5CP.Update();
			this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス6CP.Update();
			this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス7CP.Update();
			this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス8CP.Update();
			this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス9CP.Update();
			this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス10CP.Update();
			this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス11CP.Update();
			this.X0Y0_カップ左_レ\u30FCス_レ\u30FCス12CP.Update();
			this.X0Y0_カップ左_カップ1CP.Update();
			this.X0Y0_カップ左_柄_柄1_柄1CP.Update();
			this.X0Y0_カップ左_柄_柄1_柄2CP.Update();
			this.X0Y0_カップ左_柄_柄2_柄1CP.Update();
			this.X0Y0_カップ左_柄_柄2_柄2CP.Update();
			this.X0Y0_カップ左_柄_柄3_柄1CP.Update();
			this.X0Y0_カップ左_柄_柄3_柄2CP.Update();
			this.X0Y0_カップ左_柄_柄4_柄1CP.Update();
			this.X0Y0_カップ左_柄_柄4_柄2CP.Update();
			this.X0Y0_カップ左_柄_柄5_柄1CP.Update();
			this.X0Y0_カップ左_柄_柄5_柄2CP.Update();
			this.X0Y0_カップ左_柄_柄6_柄1CP.Update();
			this.X0Y0_カップ左_柄_柄6_柄2CP.Update();
			this.X0Y0_カップ左_柄_柄7_柄1CP.Update();
			this.X0Y0_カップ左_柄_柄7_柄2CP.Update();
			this.X0Y0_カップ左_縁_縁1CP.Update();
			this.X0Y0_カップ左_縁_縁2CP.Update();
			this.X0Y0_カップ左_縁_縁3CP.Update();
			this.X0Y0_カップ左_縁_縁4CP.Update();
			this.X0Y0_カップ右_紐CP.Update();
			this.X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC1CP.Update();
			this.X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC2CP.Update();
			this.X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC3CP.Update();
			this.X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC4CP.Update();
			this.X0Y0_カップ右_カップ2CP.Update();
			this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス1CP.Update();
			this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス2CP.Update();
			this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス3CP.Update();
			this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス4CP.Update();
			this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス5CP.Update();
			this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス6CP.Update();
			this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス7CP.Update();
			this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス8CP.Update();
			this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス9CP.Update();
			this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス10CP.Update();
			this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス11CP.Update();
			this.X0Y0_カップ右_レ\u30FCス_レ\u30FCス12CP.Update();
			this.X0Y0_カップ右_カップ1CP.Update();
			this.X0Y0_カップ右_柄_柄1_柄1CP.Update();
			this.X0Y0_カップ右_柄_柄1_柄2CP.Update();
			this.X0Y0_カップ右_柄_柄2_柄1CP.Update();
			this.X0Y0_カップ右_柄_柄2_柄2CP.Update();
			this.X0Y0_カップ右_柄_柄3_柄1CP.Update();
			this.X0Y0_カップ右_柄_柄3_柄2CP.Update();
			this.X0Y0_カップ右_柄_柄4_柄1CP.Update();
			this.X0Y0_カップ右_柄_柄4_柄2CP.Update();
			this.X0Y0_カップ右_柄_柄5_柄1CP.Update();
			this.X0Y0_カップ右_柄_柄5_柄2CP.Update();
			this.X0Y0_カップ右_柄_柄6_柄1CP.Update();
			this.X0Y0_カップ右_柄_柄6_柄2CP.Update();
			this.X0Y0_カップ右_柄_柄7_柄1CP.Update();
			this.X0Y0_カップ右_柄_柄7_柄2CP.Update();
			this.X0Y0_カップ右_縁_縁1CP.Update();
			this.X0Y0_カップ右_縁_縁2CP.Update();
			this.X0Y0_カップ右_縁_縁3CP.Update();
			this.X0Y0_カップ右_縁_縁4CP.Update();
			this.X0Y0_リボン_リボンCP.Update();
			this.X0Y0_リボン_結び目CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.バンド_バンドCD = new ColorD();
			this.バンド_縁_下CD = new ColorD();
			this.バンド_縁_上CD = new ColorD();
			this.バンド_縁_左CD = new ColorD();
			this.バンド_縁_右CD = new ColorD();
			this.カップ左_紐CD = new ColorD();
			this.カップ左_ジャスタ\u30FC_ジャスタ\u30FC1CD = new ColorD();
			this.カップ左_ジャスタ\u30FC_ジャスタ\u30FC2CD = new ColorD();
			this.カップ左_ジャスタ\u30FC_ジャスタ\u30FC3CD = new ColorD();
			this.カップ左_ジャスタ\u30FC_ジャスタ\u30FC4CD = new ColorD();
			this.カップ左_カップ2CD = new ColorD();
			this.カップ左_レ\u30FCス_レ\u30FCス1CD = new ColorD();
			this.カップ左_レ\u30FCス_レ\u30FCス2CD = new ColorD();
			this.カップ左_レ\u30FCス_レ\u30FCス3CD = new ColorD();
			this.カップ左_レ\u30FCス_レ\u30FCス4CD = new ColorD();
			this.カップ左_レ\u30FCス_レ\u30FCス5CD = new ColorD();
			this.カップ左_レ\u30FCス_レ\u30FCス6CD = new ColorD();
			this.カップ左_レ\u30FCス_レ\u30FCス7CD = new ColorD();
			this.カップ左_レ\u30FCス_レ\u30FCス8CD = new ColorD();
			this.カップ左_レ\u30FCス_レ\u30FCス9CD = new ColorD();
			this.カップ左_レ\u30FCス_レ\u30FCス10CD = new ColorD();
			this.カップ左_レ\u30FCス_レ\u30FCス11CD = new ColorD();
			this.カップ左_レ\u30FCス_レ\u30FCス12CD = new ColorD();
			this.カップ左_カップ1CD = new ColorD();
			this.カップ左_柄_柄1_柄1CD = new ColorD();
			this.カップ左_柄_柄1_柄2CD = new ColorD();
			this.カップ左_柄_柄2_柄1CD = new ColorD();
			this.カップ左_柄_柄2_柄2CD = new ColorD();
			this.カップ左_柄_柄3_柄1CD = new ColorD();
			this.カップ左_柄_柄3_柄2CD = new ColorD();
			this.カップ左_柄_柄4_柄1CD = new ColorD();
			this.カップ左_柄_柄4_柄2CD = new ColorD();
			this.カップ左_柄_柄5_柄1CD = new ColorD();
			this.カップ左_柄_柄5_柄2CD = new ColorD();
			this.カップ左_柄_柄6_柄1CD = new ColorD();
			this.カップ左_柄_柄6_柄2CD = new ColorD();
			this.カップ左_柄_柄7_柄1CD = new ColorD();
			this.カップ左_柄_柄7_柄2CD = new ColorD();
			this.カップ左_縁_縁1CD = new ColorD();
			this.カップ左_縁_縁2CD = new ColorD();
			this.カップ左_縁_縁3CD = new ColorD();
			this.カップ左_縁_縁4CD = new ColorD();
			this.カップ右_紐CD = new ColorD();
			this.カップ右_ジャスタ\u30FC_ジャスタ\u30FC1CD = new ColorD();
			this.カップ右_ジャスタ\u30FC_ジャスタ\u30FC2CD = new ColorD();
			this.カップ右_ジャスタ\u30FC_ジャスタ\u30FC3CD = new ColorD();
			this.カップ右_ジャスタ\u30FC_ジャスタ\u30FC4CD = new ColorD();
			this.カップ右_カップ2CD = new ColorD();
			this.カップ右_レ\u30FCス_レ\u30FCス1CD = new ColorD();
			this.カップ右_レ\u30FCス_レ\u30FCス2CD = new ColorD();
			this.カップ右_レ\u30FCス_レ\u30FCス3CD = new ColorD();
			this.カップ右_レ\u30FCス_レ\u30FCス4CD = new ColorD();
			this.カップ右_レ\u30FCス_レ\u30FCス5CD = new ColorD();
			this.カップ右_レ\u30FCス_レ\u30FCス6CD = new ColorD();
			this.カップ右_レ\u30FCス_レ\u30FCス7CD = new ColorD();
			this.カップ右_レ\u30FCス_レ\u30FCス8CD = new ColorD();
			this.カップ右_レ\u30FCス_レ\u30FCス9CD = new ColorD();
			this.カップ右_レ\u30FCス_レ\u30FCス10CD = new ColorD();
			this.カップ右_レ\u30FCス_レ\u30FCス11CD = new ColorD();
			this.カップ右_レ\u30FCス_レ\u30FCス12CD = new ColorD();
			this.カップ右_カップ1CD = new ColorD();
			this.カップ右_柄_柄1_柄1CD = new ColorD();
			this.カップ右_柄_柄1_柄2CD = new ColorD();
			this.カップ右_柄_柄2_柄1CD = new ColorD();
			this.カップ右_柄_柄2_柄2CD = new ColorD();
			this.カップ右_柄_柄3_柄1CD = new ColorD();
			this.カップ右_柄_柄3_柄2CD = new ColorD();
			this.カップ右_柄_柄4_柄1CD = new ColorD();
			this.カップ右_柄_柄4_柄2CD = new ColorD();
			this.カップ右_柄_柄5_柄1CD = new ColorD();
			this.カップ右_柄_柄5_柄2CD = new ColorD();
			this.カップ右_柄_柄6_柄1CD = new ColorD();
			this.カップ右_柄_柄6_柄2CD = new ColorD();
			this.カップ右_柄_柄7_柄1CD = new ColorD();
			this.カップ右_柄_柄7_柄2CD = new ColorD();
			this.カップ右_縁_縁1CD = new ColorD();
			this.カップ右_縁_縁2CD = new ColorD();
			this.カップ右_縁_縁3CD = new ColorD();
			this.カップ右_縁_縁4CD = new ColorD();
			this.リボン_リボンCD = new ColorD();
			this.リボン_結び目CD = new ColorD();
		}

		public void 配色(ブラT色 配色)
		{
			this.バンド_バンドCD.色 = 配色.生地1色;
			this.バンド_縁_下CD.色 = 配色.縁色;
			this.バンド_縁_上CD.色 = this.バンド_縁_下CD.色;
			this.バンド_縁_左CD.色 = this.バンド_縁_下CD.色;
			this.バンド_縁_右CD.色 = this.バンド_縁_下CD.色;
			this.カップ左_紐CD.色 = 配色.紐色;
			this.カップ左_ジャスタ\u30FC_ジャスタ\u30FC1CD.色 = 配色.ジャスタ\u30FC色;
			this.カップ左_ジャスタ\u30FC_ジャスタ\u30FC2CD.色 = this.カップ左_ジャスタ\u30FC_ジャスタ\u30FC1CD.色;
			this.カップ左_ジャスタ\u30FC_ジャスタ\u30FC3CD.色 = this.カップ左_ジャスタ\u30FC_ジャスタ\u30FC1CD.色;
			this.カップ左_ジャスタ\u30FC_ジャスタ\u30FC4CD.色 = this.カップ左_ジャスタ\u30FC_ジャスタ\u30FC1CD.色;
			this.カップ左_カップ2CD.色 = 配色.生地2色;
			this.カップ左_レ\u30FCス_レ\u30FCス1CD.色 = 配色.レ\u30FCス色;
			this.カップ左_レ\u30FCス_レ\u30FCス2CD.色 = this.カップ左_レ\u30FCス_レ\u30FCス1CD.色;
			this.カップ左_レ\u30FCス_レ\u30FCス3CD.色 = this.カップ左_レ\u30FCス_レ\u30FCス1CD.色;
			this.カップ左_レ\u30FCス_レ\u30FCス4CD.色 = this.カップ左_レ\u30FCス_レ\u30FCス1CD.色;
			this.カップ左_レ\u30FCス_レ\u30FCス5CD.色 = this.カップ左_レ\u30FCス_レ\u30FCス1CD.色;
			this.カップ左_レ\u30FCス_レ\u30FCス6CD.色 = this.カップ左_レ\u30FCス_レ\u30FCス1CD.色;
			this.カップ左_レ\u30FCス_レ\u30FCス7CD.色 = this.カップ左_レ\u30FCス_レ\u30FCス1CD.色;
			this.カップ左_レ\u30FCス_レ\u30FCス8CD.色 = this.カップ左_レ\u30FCス_レ\u30FCス1CD.色;
			this.カップ左_レ\u30FCス_レ\u30FCス9CD.色 = this.カップ左_レ\u30FCス_レ\u30FCス1CD.色;
			this.カップ左_レ\u30FCス_レ\u30FCス10CD.色 = this.カップ左_レ\u30FCス_レ\u30FCス1CD.色;
			this.カップ左_レ\u30FCス_レ\u30FCス11CD.色 = this.カップ左_レ\u30FCス_レ\u30FCス1CD.色;
			this.カップ左_レ\u30FCス_レ\u30FCス12CD.色 = this.カップ左_レ\u30FCス_レ\u30FCス1CD.色;
			this.カップ左_カップ1CD.色 = this.バンド_バンドCD.色;
			this.カップ左_柄_柄1_柄1CD.色 = 配色.柄色;
			this.カップ左_柄_柄1_柄2CD.色 = this.カップ左_柄_柄1_柄1CD.色;
			this.カップ左_柄_柄2_柄1CD.色 = this.カップ左_柄_柄1_柄1CD.色;
			this.カップ左_柄_柄2_柄2CD.色 = this.カップ左_柄_柄1_柄1CD.色;
			this.カップ左_柄_柄3_柄1CD.色 = this.カップ左_柄_柄1_柄1CD.色;
			this.カップ左_柄_柄3_柄2CD.色 = this.カップ左_柄_柄1_柄1CD.色;
			this.カップ左_柄_柄4_柄1CD.色 = this.カップ左_柄_柄1_柄1CD.色;
			this.カップ左_柄_柄4_柄2CD.色 = this.カップ左_柄_柄1_柄1CD.色;
			this.カップ左_柄_柄5_柄1CD.色 = this.カップ左_柄_柄1_柄1CD.色;
			this.カップ左_柄_柄5_柄2CD.色 = this.カップ左_柄_柄1_柄1CD.色;
			this.カップ左_柄_柄6_柄1CD.色 = this.カップ左_柄_柄1_柄1CD.色;
			this.カップ左_柄_柄6_柄2CD.色 = this.カップ左_柄_柄1_柄1CD.色;
			this.カップ左_柄_柄7_柄1CD.色 = this.カップ左_柄_柄1_柄1CD.色;
			this.カップ左_柄_柄7_柄2CD.色 = this.カップ左_柄_柄1_柄1CD.色;
			this.カップ左_縁_縁1CD.色 = this.バンド_縁_下CD.色;
			this.カップ左_縁_縁2CD.色 = this.バンド_縁_下CD.色;
			this.カップ左_縁_縁3CD.色 = this.バンド_縁_下CD.色;
			this.カップ左_縁_縁4CD.色 = this.バンド_縁_下CD.色;
			this.カップ右_紐CD.色 = this.カップ左_紐CD.色;
			this.カップ右_ジャスタ\u30FC_ジャスタ\u30FC1CD.色 = this.カップ左_ジャスタ\u30FC_ジャスタ\u30FC1CD.色;
			this.カップ右_ジャスタ\u30FC_ジャスタ\u30FC2CD.色 = this.カップ左_ジャスタ\u30FC_ジャスタ\u30FC1CD.色;
			this.カップ右_ジャスタ\u30FC_ジャスタ\u30FC3CD.色 = this.カップ左_ジャスタ\u30FC_ジャスタ\u30FC1CD.色;
			this.カップ右_ジャスタ\u30FC_ジャスタ\u30FC4CD.色 = this.カップ左_ジャスタ\u30FC_ジャスタ\u30FC1CD.色;
			this.カップ右_カップ2CD.色 = this.カップ左_カップ2CD.色;
			this.カップ右_レ\u30FCス_レ\u30FCス1CD.色 = this.カップ左_レ\u30FCス_レ\u30FCス1CD.色;
			this.カップ右_レ\u30FCス_レ\u30FCス2CD.色 = this.カップ左_レ\u30FCス_レ\u30FCス1CD.色;
			this.カップ右_レ\u30FCス_レ\u30FCス3CD.色 = this.カップ左_レ\u30FCス_レ\u30FCス1CD.色;
			this.カップ右_レ\u30FCス_レ\u30FCス4CD.色 = this.カップ左_レ\u30FCス_レ\u30FCス1CD.色;
			this.カップ右_レ\u30FCス_レ\u30FCス5CD.色 = this.カップ左_レ\u30FCス_レ\u30FCス1CD.色;
			this.カップ右_レ\u30FCス_レ\u30FCス6CD.色 = this.カップ左_レ\u30FCス_レ\u30FCス1CD.色;
			this.カップ右_レ\u30FCス_レ\u30FCス7CD.色 = this.カップ左_レ\u30FCス_レ\u30FCス1CD.色;
			this.カップ右_レ\u30FCス_レ\u30FCス8CD.色 = this.カップ左_レ\u30FCス_レ\u30FCス1CD.色;
			this.カップ右_レ\u30FCス_レ\u30FCス9CD.色 = this.カップ左_レ\u30FCス_レ\u30FCス1CD.色;
			this.カップ右_レ\u30FCス_レ\u30FCス10CD.色 = this.カップ左_レ\u30FCス_レ\u30FCス1CD.色;
			this.カップ右_レ\u30FCス_レ\u30FCス11CD.色 = this.カップ左_レ\u30FCス_レ\u30FCス1CD.色;
			this.カップ右_レ\u30FCス_レ\u30FCス12CD.色 = this.カップ左_レ\u30FCス_レ\u30FCス1CD.色;
			this.カップ右_カップ1CD.色 = this.バンド_バンドCD.色;
			this.カップ右_柄_柄1_柄1CD.色 = this.カップ左_柄_柄1_柄1CD.色;
			this.カップ右_柄_柄1_柄2CD.色 = this.カップ左_柄_柄1_柄1CD.色;
			this.カップ右_柄_柄2_柄1CD.色 = this.カップ左_柄_柄1_柄1CD.色;
			this.カップ右_柄_柄2_柄2CD.色 = this.カップ左_柄_柄1_柄1CD.色;
			this.カップ右_柄_柄3_柄1CD.色 = this.カップ左_柄_柄1_柄1CD.色;
			this.カップ右_柄_柄3_柄2CD.色 = this.カップ左_柄_柄1_柄1CD.色;
			this.カップ右_柄_柄4_柄1CD.色 = this.カップ左_柄_柄1_柄1CD.色;
			this.カップ右_柄_柄4_柄2CD.色 = this.カップ左_柄_柄1_柄1CD.色;
			this.カップ右_柄_柄5_柄1CD.色 = this.カップ左_柄_柄1_柄1CD.色;
			this.カップ右_柄_柄5_柄2CD.色 = this.カップ左_柄_柄1_柄1CD.色;
			this.カップ右_柄_柄6_柄1CD.色 = this.カップ左_柄_柄1_柄1CD.色;
			this.カップ右_柄_柄6_柄2CD.色 = this.カップ左_柄_柄1_柄1CD.色;
			this.カップ右_柄_柄7_柄1CD.色 = this.カップ左_柄_柄1_柄1CD.色;
			this.カップ右_柄_柄7_柄2CD.色 = this.カップ左_柄_柄1_柄1CD.色;
			this.カップ右_縁_縁1CD.色 = this.バンド_縁_下CD.色;
			this.カップ右_縁_縁2CD.色 = this.バンド_縁_下CD.色;
			this.カップ右_縁_縁3CD.色 = this.バンド_縁_下CD.色;
			this.カップ右_縁_縁4CD.色 = this.バンド_縁_下CD.色;
			this.リボン_リボンCD.色 = 配色.リボン色;
			this.リボン_結び目CD.色 = this.リボン_リボンCD.色;
		}

		public Par X0Y0_バンド_バンド;

		public Par X0Y0_バンド_縁_下;

		public Par X0Y0_バンド_縁_上;

		public Par X0Y0_バンド_縁_左;

		public Par X0Y0_バンド_縁_右;

		public Par X0Y0_カップ左_紐;

		public Par X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC1;

		public Par X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC2;

		public Par X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC3;

		public Par X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC4;

		public Par X0Y0_カップ左_カップ2;

		public Par X0Y0_カップ左_レ\u30FCス_レ\u30FCス1;

		public Par X0Y0_カップ左_レ\u30FCス_レ\u30FCス2;

		public Par X0Y0_カップ左_レ\u30FCス_レ\u30FCス3;

		public Par X0Y0_カップ左_レ\u30FCス_レ\u30FCス4;

		public Par X0Y0_カップ左_レ\u30FCス_レ\u30FCス5;

		public Par X0Y0_カップ左_レ\u30FCス_レ\u30FCス6;

		public Par X0Y0_カップ左_レ\u30FCス_レ\u30FCス7;

		public Par X0Y0_カップ左_レ\u30FCス_レ\u30FCス8;

		public Par X0Y0_カップ左_レ\u30FCス_レ\u30FCス9;

		public Par X0Y0_カップ左_レ\u30FCス_レ\u30FCス10;

		public Par X0Y0_カップ左_レ\u30FCス_レ\u30FCス11;

		public Par X0Y0_カップ左_レ\u30FCス_レ\u30FCス12;

		public Par X0Y0_カップ左_カップ1;

		public Par X0Y0_カップ左_柄_柄1_柄1;

		public Par X0Y0_カップ左_柄_柄1_柄2;

		public Par X0Y0_カップ左_柄_柄2_柄1;

		public Par X0Y0_カップ左_柄_柄2_柄2;

		public Par X0Y0_カップ左_柄_柄3_柄1;

		public Par X0Y0_カップ左_柄_柄3_柄2;

		public Par X0Y0_カップ左_柄_柄4_柄1;

		public Par X0Y0_カップ左_柄_柄4_柄2;

		public Par X0Y0_カップ左_柄_柄5_柄1;

		public Par X0Y0_カップ左_柄_柄5_柄2;

		public Par X0Y0_カップ左_柄_柄6_柄1;

		public Par X0Y0_カップ左_柄_柄6_柄2;

		public Par X0Y0_カップ左_柄_柄7_柄1;

		public Par X0Y0_カップ左_柄_柄7_柄2;

		public Par X0Y0_カップ左_縁_縁1;

		public Par X0Y0_カップ左_縁_縁2;

		public Par X0Y0_カップ左_縁_縁3;

		public Par X0Y0_カップ左_縁_縁4;

		public Par X0Y0_カップ右_紐;

		public Par X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC1;

		public Par X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC2;

		public Par X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC3;

		public Par X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC4;

		public Par X0Y0_カップ右_カップ2;

		public Par X0Y0_カップ右_レ\u30FCス_レ\u30FCス1;

		public Par X0Y0_カップ右_レ\u30FCス_レ\u30FCス2;

		public Par X0Y0_カップ右_レ\u30FCス_レ\u30FCス3;

		public Par X0Y0_カップ右_レ\u30FCス_レ\u30FCス4;

		public Par X0Y0_カップ右_レ\u30FCス_レ\u30FCス5;

		public Par X0Y0_カップ右_レ\u30FCス_レ\u30FCス6;

		public Par X0Y0_カップ右_レ\u30FCス_レ\u30FCス7;

		public Par X0Y0_カップ右_レ\u30FCス_レ\u30FCス8;

		public Par X0Y0_カップ右_レ\u30FCス_レ\u30FCス9;

		public Par X0Y0_カップ右_レ\u30FCス_レ\u30FCス10;

		public Par X0Y0_カップ右_レ\u30FCス_レ\u30FCス11;

		public Par X0Y0_カップ右_レ\u30FCス_レ\u30FCス12;

		public Par X0Y0_カップ右_カップ1;

		public Par X0Y0_カップ右_柄_柄1_柄1;

		public Par X0Y0_カップ右_柄_柄1_柄2;

		public Par X0Y0_カップ右_柄_柄2_柄1;

		public Par X0Y0_カップ右_柄_柄2_柄2;

		public Par X0Y0_カップ右_柄_柄3_柄1;

		public Par X0Y0_カップ右_柄_柄3_柄2;

		public Par X0Y0_カップ右_柄_柄4_柄1;

		public Par X0Y0_カップ右_柄_柄4_柄2;

		public Par X0Y0_カップ右_柄_柄5_柄1;

		public Par X0Y0_カップ右_柄_柄5_柄2;

		public Par X0Y0_カップ右_柄_柄6_柄1;

		public Par X0Y0_カップ右_柄_柄6_柄2;

		public Par X0Y0_カップ右_柄_柄7_柄1;

		public Par X0Y0_カップ右_柄_柄7_柄2;

		public Par X0Y0_カップ右_縁_縁1;

		public Par X0Y0_カップ右_縁_縁2;

		public Par X0Y0_カップ右_縁_縁3;

		public Par X0Y0_カップ右_縁_縁4;

		public Par X0Y0_リボン_リボン;

		public Par X0Y0_リボン_結び目;

		public ColorD バンド_バンドCD;

		public ColorD バンド_縁_下CD;

		public ColorD バンド_縁_上CD;

		public ColorD バンド_縁_左CD;

		public ColorD バンド_縁_右CD;

		public ColorD カップ左_紐CD;

		public ColorD カップ左_ジャスタ\u30FC_ジャスタ\u30FC1CD;

		public ColorD カップ左_ジャスタ\u30FC_ジャスタ\u30FC2CD;

		public ColorD カップ左_ジャスタ\u30FC_ジャスタ\u30FC3CD;

		public ColorD カップ左_ジャスタ\u30FC_ジャスタ\u30FC4CD;

		public ColorD カップ左_カップ2CD;

		public ColorD カップ左_レ\u30FCス_レ\u30FCス1CD;

		public ColorD カップ左_レ\u30FCス_レ\u30FCス2CD;

		public ColorD カップ左_レ\u30FCス_レ\u30FCス3CD;

		public ColorD カップ左_レ\u30FCス_レ\u30FCス4CD;

		public ColorD カップ左_レ\u30FCス_レ\u30FCス5CD;

		public ColorD カップ左_レ\u30FCス_レ\u30FCス6CD;

		public ColorD カップ左_レ\u30FCス_レ\u30FCス7CD;

		public ColorD カップ左_レ\u30FCス_レ\u30FCス8CD;

		public ColorD カップ左_レ\u30FCス_レ\u30FCス9CD;

		public ColorD カップ左_レ\u30FCス_レ\u30FCス10CD;

		public ColorD カップ左_レ\u30FCス_レ\u30FCス11CD;

		public ColorD カップ左_レ\u30FCス_レ\u30FCス12CD;

		public ColorD カップ左_カップ1CD;

		public ColorD カップ左_柄_柄1_柄1CD;

		public ColorD カップ左_柄_柄1_柄2CD;

		public ColorD カップ左_柄_柄2_柄1CD;

		public ColorD カップ左_柄_柄2_柄2CD;

		public ColorD カップ左_柄_柄3_柄1CD;

		public ColorD カップ左_柄_柄3_柄2CD;

		public ColorD カップ左_柄_柄4_柄1CD;

		public ColorD カップ左_柄_柄4_柄2CD;

		public ColorD カップ左_柄_柄5_柄1CD;

		public ColorD カップ左_柄_柄5_柄2CD;

		public ColorD カップ左_柄_柄6_柄1CD;

		public ColorD カップ左_柄_柄6_柄2CD;

		public ColorD カップ左_柄_柄7_柄1CD;

		public ColorD カップ左_柄_柄7_柄2CD;

		public ColorD カップ左_縁_縁1CD;

		public ColorD カップ左_縁_縁2CD;

		public ColorD カップ左_縁_縁3CD;

		public ColorD カップ左_縁_縁4CD;

		public ColorD カップ右_紐CD;

		public ColorD カップ右_ジャスタ\u30FC_ジャスタ\u30FC1CD;

		public ColorD カップ右_ジャスタ\u30FC_ジャスタ\u30FC2CD;

		public ColorD カップ右_ジャスタ\u30FC_ジャスタ\u30FC3CD;

		public ColorD カップ右_ジャスタ\u30FC_ジャスタ\u30FC4CD;

		public ColorD カップ右_カップ2CD;

		public ColorD カップ右_レ\u30FCス_レ\u30FCス1CD;

		public ColorD カップ右_レ\u30FCス_レ\u30FCス2CD;

		public ColorD カップ右_レ\u30FCス_レ\u30FCス3CD;

		public ColorD カップ右_レ\u30FCス_レ\u30FCス4CD;

		public ColorD カップ右_レ\u30FCス_レ\u30FCス5CD;

		public ColorD カップ右_レ\u30FCス_レ\u30FCス6CD;

		public ColorD カップ右_レ\u30FCス_レ\u30FCス7CD;

		public ColorD カップ右_レ\u30FCス_レ\u30FCス8CD;

		public ColorD カップ右_レ\u30FCス_レ\u30FCス9CD;

		public ColorD カップ右_レ\u30FCス_レ\u30FCス10CD;

		public ColorD カップ右_レ\u30FCス_レ\u30FCス11CD;

		public ColorD カップ右_レ\u30FCス_レ\u30FCス12CD;

		public ColorD カップ右_カップ1CD;

		public ColorD カップ右_柄_柄1_柄1CD;

		public ColorD カップ右_柄_柄1_柄2CD;

		public ColorD カップ右_柄_柄2_柄1CD;

		public ColorD カップ右_柄_柄2_柄2CD;

		public ColorD カップ右_柄_柄3_柄1CD;

		public ColorD カップ右_柄_柄3_柄2CD;

		public ColorD カップ右_柄_柄4_柄1CD;

		public ColorD カップ右_柄_柄4_柄2CD;

		public ColorD カップ右_柄_柄5_柄1CD;

		public ColorD カップ右_柄_柄5_柄2CD;

		public ColorD カップ右_柄_柄6_柄1CD;

		public ColorD カップ右_柄_柄6_柄2CD;

		public ColorD カップ右_柄_柄7_柄1CD;

		public ColorD カップ右_柄_柄7_柄2CD;

		public ColorD カップ右_縁_縁1CD;

		public ColorD カップ右_縁_縁2CD;

		public ColorD カップ右_縁_縁3CD;

		public ColorD カップ右_縁_縁4CD;

		public ColorD リボン_リボンCD;

		public ColorD リボン_結び目CD;

		public ColorP X0Y0_バンド_バンドCP;

		public ColorP X0Y0_バンド_縁_下CP;

		public ColorP X0Y0_バンド_縁_上CP;

		public ColorP X0Y0_バンド_縁_左CP;

		public ColorP X0Y0_バンド_縁_右CP;

		public ColorP X0Y0_カップ左_紐CP;

		public ColorP X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC1CP;

		public ColorP X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC2CP;

		public ColorP X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC3CP;

		public ColorP X0Y0_カップ左_ジャスタ\u30FC_ジャスタ\u30FC4CP;

		public ColorP X0Y0_カップ左_カップ2CP;

		public ColorP X0Y0_カップ左_レ\u30FCス_レ\u30FCス1CP;

		public ColorP X0Y0_カップ左_レ\u30FCス_レ\u30FCス2CP;

		public ColorP X0Y0_カップ左_レ\u30FCス_レ\u30FCス3CP;

		public ColorP X0Y0_カップ左_レ\u30FCス_レ\u30FCス4CP;

		public ColorP X0Y0_カップ左_レ\u30FCス_レ\u30FCス5CP;

		public ColorP X0Y0_カップ左_レ\u30FCス_レ\u30FCス6CP;

		public ColorP X0Y0_カップ左_レ\u30FCス_レ\u30FCス7CP;

		public ColorP X0Y0_カップ左_レ\u30FCス_レ\u30FCス8CP;

		public ColorP X0Y0_カップ左_レ\u30FCス_レ\u30FCス9CP;

		public ColorP X0Y0_カップ左_レ\u30FCス_レ\u30FCス10CP;

		public ColorP X0Y0_カップ左_レ\u30FCス_レ\u30FCス11CP;

		public ColorP X0Y0_カップ左_レ\u30FCス_レ\u30FCス12CP;

		public ColorP X0Y0_カップ左_カップ1CP;

		public ColorP X0Y0_カップ左_柄_柄1_柄1CP;

		public ColorP X0Y0_カップ左_柄_柄1_柄2CP;

		public ColorP X0Y0_カップ左_柄_柄2_柄1CP;

		public ColorP X0Y0_カップ左_柄_柄2_柄2CP;

		public ColorP X0Y0_カップ左_柄_柄3_柄1CP;

		public ColorP X0Y0_カップ左_柄_柄3_柄2CP;

		public ColorP X0Y0_カップ左_柄_柄4_柄1CP;

		public ColorP X0Y0_カップ左_柄_柄4_柄2CP;

		public ColorP X0Y0_カップ左_柄_柄5_柄1CP;

		public ColorP X0Y0_カップ左_柄_柄5_柄2CP;

		public ColorP X0Y0_カップ左_柄_柄6_柄1CP;

		public ColorP X0Y0_カップ左_柄_柄6_柄2CP;

		public ColorP X0Y0_カップ左_柄_柄7_柄1CP;

		public ColorP X0Y0_カップ左_柄_柄7_柄2CP;

		public ColorP X0Y0_カップ左_縁_縁1CP;

		public ColorP X0Y0_カップ左_縁_縁2CP;

		public ColorP X0Y0_カップ左_縁_縁3CP;

		public ColorP X0Y0_カップ左_縁_縁4CP;

		public ColorP X0Y0_カップ右_紐CP;

		public ColorP X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC1CP;

		public ColorP X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC2CP;

		public ColorP X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC3CP;

		public ColorP X0Y0_カップ右_ジャスタ\u30FC_ジャスタ\u30FC4CP;

		public ColorP X0Y0_カップ右_カップ2CP;

		public ColorP X0Y0_カップ右_レ\u30FCス_レ\u30FCス1CP;

		public ColorP X0Y0_カップ右_レ\u30FCス_レ\u30FCス2CP;

		public ColorP X0Y0_カップ右_レ\u30FCス_レ\u30FCス3CP;

		public ColorP X0Y0_カップ右_レ\u30FCス_レ\u30FCス4CP;

		public ColorP X0Y0_カップ右_レ\u30FCス_レ\u30FCス5CP;

		public ColorP X0Y0_カップ右_レ\u30FCス_レ\u30FCス6CP;

		public ColorP X0Y0_カップ右_レ\u30FCス_レ\u30FCス7CP;

		public ColorP X0Y0_カップ右_レ\u30FCス_レ\u30FCス8CP;

		public ColorP X0Y0_カップ右_レ\u30FCス_レ\u30FCス9CP;

		public ColorP X0Y0_カップ右_レ\u30FCス_レ\u30FCス10CP;

		public ColorP X0Y0_カップ右_レ\u30FCス_レ\u30FCス11CP;

		public ColorP X0Y0_カップ右_レ\u30FCス_レ\u30FCス12CP;

		public ColorP X0Y0_カップ右_カップ1CP;

		public ColorP X0Y0_カップ右_柄_柄1_柄1CP;

		public ColorP X0Y0_カップ右_柄_柄1_柄2CP;

		public ColorP X0Y0_カップ右_柄_柄2_柄1CP;

		public ColorP X0Y0_カップ右_柄_柄2_柄2CP;

		public ColorP X0Y0_カップ右_柄_柄3_柄1CP;

		public ColorP X0Y0_カップ右_柄_柄3_柄2CP;

		public ColorP X0Y0_カップ右_柄_柄4_柄1CP;

		public ColorP X0Y0_カップ右_柄_柄4_柄2CP;

		public ColorP X0Y0_カップ右_柄_柄5_柄1CP;

		public ColorP X0Y0_カップ右_柄_柄5_柄2CP;

		public ColorP X0Y0_カップ右_柄_柄6_柄1CP;

		public ColorP X0Y0_カップ右_柄_柄6_柄2CP;

		public ColorP X0Y0_カップ右_柄_柄7_柄1CP;

		public ColorP X0Y0_カップ右_柄_柄7_柄2CP;

		public ColorP X0Y0_カップ右_縁_縁1CP;

		public ColorP X0Y0_カップ右_縁_縁2CP;

		public ColorP X0Y0_カップ右_縁_縁3CP;

		public ColorP X0Y0_カップ右_縁_縁4CP;

		public ColorP X0Y0_リボン_リボンCP;

		public ColorP X0Y0_リボン_結び目CP;

		private double sb;

		private double syb;
	}
}
