using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 下着ボトム_マイクロ : 下着ボトム
	{
		public 下着ボトム_マイクロ(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 下着ボトム_マイクロD e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif(Sta.胴体["下着ボトム"][1]);
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_紐左 = pars["紐左"].ToPar();
			this.X0Y0_紐右 = pars["紐右"].ToPar();
			this.X0Y0_下地 = pars["下地"].ToPar();
			this.X0Y0_線 = pars["線"].ToPar();
			Pars pars2 = pars["ライン"].ToPars();
			this.X0Y0_ライン_ライン上 = pars2["ライン上"].ToPar();
			this.X0Y0_ライン_ライン左 = pars2["ライン左"].ToPar();
			this.X0Y0_ライン_ライン右 = pars2["ライン右"].ToPar();
			this.X0Y0_ライン_ライン左下 = pars2["ライン左下"].ToPar();
			this.X0Y0_ライン_ライン右下 = pars2["ライン右下"].ToPar();
			this.X0Y0_ライン_ライン下左 = pars2["ライン下左"].ToPar();
			this.X0Y0_ライン_ライン下右 = pars2["ライン下右"].ToPar();
			pars2 = pars["結び紐左"].ToPars();
			this.X0Y0_結び紐左_紐1 = pars2["紐1"].ToPar();
			this.X0Y0_結び紐左_紐2 = pars2["紐2"].ToPar();
			Pars pars3 = pars2["輪1"].ToPars();
			this.X0Y0_結び紐左_輪1_紐後 = pars3["紐後"].ToPar();
			this.X0Y0_結び紐左_輪1_紐前 = pars3["紐前"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X0Y0_結び紐左_輪2_紐後 = pars3["紐後"].ToPar();
			this.X0Y0_結び紐左_輪2_紐前 = pars3["紐前"].ToPar();
			this.X0Y0_結び紐左_結び目 = pars2["結び目"].ToPar();
			pars2 = pars["結び紐右"].ToPars();
			this.X0Y0_結び紐右_紐1 = pars2["紐1"].ToPar();
			this.X0Y0_結び紐右_紐2 = pars2["紐2"].ToPar();
			pars3 = pars2["輪1"].ToPars();
			this.X0Y0_結び紐右_輪1_紐後 = pars3["紐後"].ToPar();
			this.X0Y0_結び紐右_輪1_紐前 = pars3["紐前"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X0Y0_結び紐右_輪2_紐後 = pars3["紐後"].ToPar();
			this.X0Y0_結び紐右_輪2_紐前 = pars3["紐前"].ToPar();
			this.X0Y0_結び紐右_結び目 = pars2["結び目"].ToPar();
			pars2 = pars["ヴィオラ"].ToPars();
			this.X0Y0_ヴィオラ_紐左 = pars2["紐左"].ToPar();
			this.X0Y0_ヴィオラ_紐右 = pars2["紐右"].ToPar();
			this.X0Y0_ヴィオラ_丸金具左 = pars2["丸金具左"].ToPar();
			this.X0Y0_ヴィオラ_丸金具右 = pars2["丸金具右"].ToPar();
			pars3 = pars2["金具左"].ToPars();
			this.X0Y0_ヴィオラ_金具左_金具1 = pars3["金具1"].ToPar();
			this.X0Y0_ヴィオラ_金具左_金具2 = pars3["金具2"].ToPar();
			pars3 = pars2["金具右"].ToPars();
			this.X0Y0_ヴィオラ_金具右_金具1 = pars3["金具1"].ToPar();
			this.X0Y0_ヴィオラ_金具右_金具2 = pars3["金具2"].ToPar();
			pars2 = pars["染み"].ToPars();
			this.X0Y0_染み_染み2 = pars2["染み2"].ToPar();
			this.X0Y0_染み_染み1 = pars2["染み1"].ToPar();
			pars = this.本体[0][1];
			this.X0Y1_紐左 = pars["紐左"].ToPar();
			this.X0Y1_紐右 = pars["紐右"].ToPar();
			this.X0Y1_下地 = pars["下地"].ToPar();
			this.X0Y1_線 = pars["線"].ToPar();
			pars2 = pars["ライン"].ToPars();
			this.X0Y1_ライン_ライン上 = pars2["ライン上"].ToPar();
			this.X0Y1_ライン_ライン左 = pars2["ライン左"].ToPar();
			this.X0Y1_ライン_ライン右 = pars2["ライン右"].ToPar();
			this.X0Y1_ライン_ライン左下 = pars2["ライン左下"].ToPar();
			this.X0Y1_ライン_ライン右下 = pars2["ライン右下"].ToPar();
			this.X0Y1_ライン_ライン下左 = pars2["ライン下左"].ToPar();
			this.X0Y1_ライン_ライン下右 = pars2["ライン下右"].ToPar();
			pars2 = pars["結び紐左"].ToPars();
			this.X0Y1_結び紐左_紐1 = pars2["紐1"].ToPar();
			this.X0Y1_結び紐左_紐2 = pars2["紐2"].ToPar();
			pars3 = pars2["輪1"].ToPars();
			this.X0Y1_結び紐左_輪1_紐後 = pars3["紐後"].ToPar();
			this.X0Y1_結び紐左_輪1_紐前 = pars3["紐前"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X0Y1_結び紐左_輪2_紐後 = pars3["紐後"].ToPar();
			this.X0Y1_結び紐左_輪2_紐前 = pars3["紐前"].ToPar();
			this.X0Y1_結び紐左_結び目 = pars2["結び目"].ToPar();
			pars2 = pars["結び紐右"].ToPars();
			this.X0Y1_結び紐右_紐1 = pars2["紐1"].ToPar();
			this.X0Y1_結び紐右_紐2 = pars2["紐2"].ToPar();
			pars3 = pars2["輪1"].ToPars();
			this.X0Y1_結び紐右_輪1_紐後 = pars3["紐後"].ToPar();
			this.X0Y1_結び紐右_輪1_紐前 = pars3["紐前"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X0Y1_結び紐右_輪2_紐後 = pars3["紐後"].ToPar();
			this.X0Y1_結び紐右_輪2_紐前 = pars3["紐前"].ToPar();
			this.X0Y1_結び紐右_結び目 = pars2["結び目"].ToPar();
			pars2 = pars["ヴィオラ"].ToPars();
			this.X0Y1_ヴィオラ_紐左 = pars2["紐左"].ToPar();
			this.X0Y1_ヴィオラ_紐右 = pars2["紐右"].ToPar();
			this.X0Y1_ヴィオラ_丸金具左 = pars2["丸金具左"].ToPar();
			this.X0Y1_ヴィオラ_丸金具右 = pars2["丸金具右"].ToPar();
			pars3 = pars2["金具左"].ToPars();
			this.X0Y1_ヴィオラ_金具左_金具1 = pars3["金具1"].ToPar();
			this.X0Y1_ヴィオラ_金具左_金具2 = pars3["金具2"].ToPar();
			pars3 = pars2["金具右"].ToPars();
			this.X0Y1_ヴィオラ_金具右_金具1 = pars3["金具1"].ToPar();
			this.X0Y1_ヴィオラ_金具右_金具2 = pars3["金具2"].ToPar();
			pars2 = pars["染み"].ToPars();
			this.X0Y1_染み_染み2 = pars2["染み2"].ToPar();
			this.X0Y1_染み_染み1 = pars2["染み1"].ToPar();
			pars = this.本体[0][2];
			this.X0Y2_紐左 = pars["紐左"].ToPar();
			this.X0Y2_紐右 = pars["紐右"].ToPar();
			this.X0Y2_下地 = pars["下地"].ToPar();
			this.X0Y2_線 = pars["線"].ToPar();
			pars2 = pars["ライン"].ToPars();
			this.X0Y2_ライン_ライン上 = pars2["ライン上"].ToPar();
			this.X0Y2_ライン_ライン左 = pars2["ライン左"].ToPar();
			this.X0Y2_ライン_ライン右 = pars2["ライン右"].ToPar();
			this.X0Y2_ライン_ライン左下 = pars2["ライン左下"].ToPar();
			this.X0Y2_ライン_ライン右下 = pars2["ライン右下"].ToPar();
			this.X0Y2_ライン_ライン下左 = pars2["ライン下左"].ToPar();
			this.X0Y2_ライン_ライン下右 = pars2["ライン下右"].ToPar();
			pars2 = pars["結び紐左"].ToPars();
			this.X0Y2_結び紐左_紐1 = pars2["紐1"].ToPar();
			this.X0Y2_結び紐左_紐2 = pars2["紐2"].ToPar();
			pars3 = pars2["輪1"].ToPars();
			this.X0Y2_結び紐左_輪1_紐後 = pars3["紐後"].ToPar();
			this.X0Y2_結び紐左_輪1_紐前 = pars3["紐前"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X0Y2_結び紐左_輪2_紐後 = pars3["紐後"].ToPar();
			this.X0Y2_結び紐左_輪2_紐前 = pars3["紐前"].ToPar();
			this.X0Y2_結び紐左_結び目 = pars2["結び目"].ToPar();
			pars2 = pars["結び紐右"].ToPars();
			this.X0Y2_結び紐右_紐1 = pars2["紐1"].ToPar();
			this.X0Y2_結び紐右_紐2 = pars2["紐2"].ToPar();
			pars3 = pars2["輪1"].ToPars();
			this.X0Y2_結び紐右_輪1_紐後 = pars3["紐後"].ToPar();
			this.X0Y2_結び紐右_輪1_紐前 = pars3["紐前"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X0Y2_結び紐右_輪2_紐後 = pars3["紐後"].ToPar();
			this.X0Y2_結び紐右_輪2_紐前 = pars3["紐前"].ToPar();
			this.X0Y2_結び紐右_結び目 = pars2["結び目"].ToPar();
			pars2 = pars["ヴィオラ"].ToPars();
			this.X0Y2_ヴィオラ_紐左 = pars2["紐左"].ToPar();
			this.X0Y2_ヴィオラ_紐右 = pars2["紐右"].ToPar();
			this.X0Y2_ヴィオラ_丸金具左 = pars2["丸金具左"].ToPar();
			this.X0Y2_ヴィオラ_丸金具右 = pars2["丸金具右"].ToPar();
			pars3 = pars2["金具左"].ToPars();
			this.X0Y2_ヴィオラ_金具左_金具1 = pars3["金具1"].ToPar();
			this.X0Y2_ヴィオラ_金具左_金具2 = pars3["金具2"].ToPar();
			pars3 = pars2["金具右"].ToPars();
			this.X0Y2_ヴィオラ_金具右_金具1 = pars3["金具1"].ToPar();
			this.X0Y2_ヴィオラ_金具右_金具2 = pars3["金具2"].ToPar();
			pars2 = pars["染み"].ToPars();
			this.X0Y2_染み_染み2 = pars2["染み2"].ToPar();
			this.X0Y2_染み_染み1 = pars2["染み1"].ToPar();
			pars = this.本体[0][3];
			this.X0Y3_紐左 = pars["紐左"].ToPar();
			this.X0Y3_紐右 = pars["紐右"].ToPar();
			this.X0Y3_下地 = pars["下地"].ToPar();
			this.X0Y3_線 = pars["線"].ToPar();
			pars2 = pars["ライン"].ToPars();
			this.X0Y3_ライン_ライン上 = pars2["ライン上"].ToPar();
			this.X0Y3_ライン_ライン左 = pars2["ライン左"].ToPar();
			this.X0Y3_ライン_ライン右 = pars2["ライン右"].ToPar();
			this.X0Y3_ライン_ライン左下 = pars2["ライン左下"].ToPar();
			this.X0Y3_ライン_ライン右下 = pars2["ライン右下"].ToPar();
			this.X0Y3_ライン_ライン下左 = pars2["ライン下左"].ToPar();
			this.X0Y3_ライン_ライン下右 = pars2["ライン下右"].ToPar();
			pars2 = pars["結び紐左"].ToPars();
			this.X0Y3_結び紐左_紐1 = pars2["紐1"].ToPar();
			this.X0Y3_結び紐左_紐2 = pars2["紐2"].ToPar();
			pars3 = pars2["輪1"].ToPars();
			this.X0Y3_結び紐左_輪1_紐後 = pars3["紐後"].ToPar();
			this.X0Y3_結び紐左_輪1_紐前 = pars3["紐前"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X0Y3_結び紐左_輪2_紐後 = pars3["紐後"].ToPar();
			this.X0Y3_結び紐左_輪2_紐前 = pars3["紐前"].ToPar();
			this.X0Y3_結び紐左_結び目 = pars2["結び目"].ToPar();
			pars2 = pars["結び紐右"].ToPars();
			this.X0Y3_結び紐右_紐1 = pars2["紐1"].ToPar();
			this.X0Y3_結び紐右_紐2 = pars2["紐2"].ToPar();
			pars3 = pars2["輪1"].ToPars();
			this.X0Y3_結び紐右_輪1_紐後 = pars3["紐後"].ToPar();
			this.X0Y3_結び紐右_輪1_紐前 = pars3["紐前"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X0Y3_結び紐右_輪2_紐後 = pars3["紐後"].ToPar();
			this.X0Y3_結び紐右_輪2_紐前 = pars3["紐前"].ToPar();
			this.X0Y3_結び紐右_結び目 = pars2["結び目"].ToPar();
			pars2 = pars["ヴィオラ"].ToPars();
			this.X0Y3_ヴィオラ_紐左 = pars2["紐左"].ToPar();
			this.X0Y3_ヴィオラ_紐右 = pars2["紐右"].ToPar();
			this.X0Y3_ヴィオラ_丸金具左 = pars2["丸金具左"].ToPar();
			this.X0Y3_ヴィオラ_丸金具右 = pars2["丸金具右"].ToPar();
			pars3 = pars2["金具左"].ToPars();
			this.X0Y3_ヴィオラ_金具左_金具1 = pars3["金具1"].ToPar();
			this.X0Y3_ヴィオラ_金具左_金具2 = pars3["金具2"].ToPar();
			pars3 = pars2["金具右"].ToPars();
			this.X0Y3_ヴィオラ_金具右_金具1 = pars3["金具1"].ToPar();
			this.X0Y3_ヴィオラ_金具右_金具2 = pars3["金具2"].ToPar();
			pars2 = pars["染み"].ToPars();
			this.X0Y3_染み_染み2 = pars2["染み2"].ToPar();
			this.X0Y3_染み_染み1 = pars2["染み1"].ToPar();
			pars = this.本体[0][4];
			this.X0Y4_紐左 = pars["紐左"].ToPar();
			this.X0Y4_紐右 = pars["紐右"].ToPar();
			this.X0Y4_下地 = pars["下地"].ToPar();
			this.X0Y4_線 = pars["線"].ToPar();
			pars2 = pars["ライン"].ToPars();
			this.X0Y4_ライン_ライン上 = pars2["ライン上"].ToPar();
			this.X0Y4_ライン_ライン左 = pars2["ライン左"].ToPar();
			this.X0Y4_ライン_ライン右 = pars2["ライン右"].ToPar();
			this.X0Y4_ライン_ライン左下 = pars2["ライン左下"].ToPar();
			this.X0Y4_ライン_ライン右下 = pars2["ライン右下"].ToPar();
			this.X0Y4_ライン_ライン下左 = pars2["ライン下左"].ToPar();
			this.X0Y4_ライン_ライン下右 = pars2["ライン下右"].ToPar();
			pars2 = pars["結び紐左"].ToPars();
			this.X0Y4_結び紐左_紐1 = pars2["紐1"].ToPar();
			this.X0Y4_結び紐左_紐2 = pars2["紐2"].ToPar();
			pars3 = pars2["輪1"].ToPars();
			this.X0Y4_結び紐左_輪1_紐後 = pars3["紐後"].ToPar();
			this.X0Y4_結び紐左_輪1_紐前 = pars3["紐前"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X0Y4_結び紐左_輪2_紐後 = pars3["紐後"].ToPar();
			this.X0Y4_結び紐左_輪2_紐前 = pars3["紐前"].ToPar();
			this.X0Y4_結び紐左_結び目 = pars2["結び目"].ToPar();
			pars2 = pars["結び紐右"].ToPars();
			this.X0Y4_結び紐右_紐1 = pars2["紐1"].ToPar();
			this.X0Y4_結び紐右_紐2 = pars2["紐2"].ToPar();
			pars3 = pars2["輪1"].ToPars();
			this.X0Y4_結び紐右_輪1_紐後 = pars3["紐後"].ToPar();
			this.X0Y4_結び紐右_輪1_紐前 = pars3["紐前"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X0Y4_結び紐右_輪2_紐後 = pars3["紐後"].ToPar();
			this.X0Y4_結び紐右_輪2_紐前 = pars3["紐前"].ToPar();
			this.X0Y4_結び紐右_結び目 = pars2["結び目"].ToPar();
			pars2 = pars["ヴィオラ"].ToPars();
			this.X0Y4_ヴィオラ_紐左 = pars2["紐左"].ToPar();
			this.X0Y4_ヴィオラ_紐右 = pars2["紐右"].ToPar();
			this.X0Y4_ヴィオラ_丸金具左 = pars2["丸金具左"].ToPar();
			this.X0Y4_ヴィオラ_丸金具右 = pars2["丸金具右"].ToPar();
			pars3 = pars2["金具左"].ToPars();
			this.X0Y4_ヴィオラ_金具左_金具1 = pars3["金具1"].ToPar();
			this.X0Y4_ヴィオラ_金具左_金具2 = pars3["金具2"].ToPar();
			pars3 = pars2["金具右"].ToPars();
			this.X0Y4_ヴィオラ_金具右_金具1 = pars3["金具1"].ToPar();
			this.X0Y4_ヴィオラ_金具右_金具2 = pars3["金具2"].ToPar();
			pars2 = pars["染み"].ToPars();
			this.X0Y4_染み_染み2 = pars2["染み2"].ToPar();
			this.X0Y4_染み_染み1 = pars2["染み1"].ToPar();
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
			this.紐左_表示 = e.紐左_表示;
			this.紐右_表示 = e.紐右_表示;
			this.下地_表示 = e.下地_表示;
			this.線_表示 = e.線_表示;
			this.ライン_ライン上_表示 = e.ライン_ライン上_表示;
			this.ライン_ライン左_表示 = e.ライン_ライン左_表示;
			this.ライン_ライン右_表示 = e.ライン_ライン右_表示;
			this.ライン_ライン左下_表示 = e.ライン_ライン左下_表示;
			this.ライン_ライン右下_表示 = e.ライン_ライン右下_表示;
			this.ライン_ライン下左_表示 = e.ライン_ライン下左_表示;
			this.ライン_ライン下右_表示 = e.ライン_ライン下右_表示;
			this.結び紐左_紐1_表示 = e.結び紐左_紐1_表示;
			this.結び紐左_紐2_表示 = e.結び紐左_紐2_表示;
			this.結び紐左_輪1_紐後_表示 = e.結び紐左_輪1_紐後_表示;
			this.結び紐左_輪1_紐前_表示 = e.結び紐左_輪1_紐前_表示;
			this.結び紐左_輪2_紐後_表示 = e.結び紐左_輪2_紐後_表示;
			this.結び紐左_輪2_紐前_表示 = e.結び紐左_輪2_紐前_表示;
			this.結び紐左_結び目_表示 = e.結び紐左_結び目_表示;
			this.結び紐右_紐1_表示 = e.結び紐右_紐1_表示;
			this.結び紐右_紐2_表示 = e.結び紐右_紐2_表示;
			this.結び紐右_輪1_紐後_表示 = e.結び紐右_輪1_紐後_表示;
			this.結び紐右_輪1_紐前_表示 = e.結び紐右_輪1_紐前_表示;
			this.結び紐右_輪2_紐後_表示 = e.結び紐右_輪2_紐後_表示;
			this.結び紐右_輪2_紐前_表示 = e.結び紐右_輪2_紐前_表示;
			this.結び紐右_結び目_表示 = e.結び紐右_結び目_表示;
			this.ヴィオラ_紐左_表示 = e.ヴィオラ_紐左_表示;
			this.ヴィオラ_紐右_表示 = e.ヴィオラ_紐右_表示;
			this.ヴィオラ_丸金具左_表示 = e.ヴィオラ_丸金具左_表示;
			this.ヴィオラ_丸金具右_表示 = e.ヴィオラ_丸金具右_表示;
			this.ヴィオラ_金具左_金具1_表示 = e.ヴィオラ_金具左_金具1_表示;
			this.ヴィオラ_金具左_金具2_表示 = e.ヴィオラ_金具左_金具2_表示;
			this.ヴィオラ_金具右_金具1_表示 = e.ヴィオラ_金具右_金具1_表示;
			this.ヴィオラ_金具右_金具2_表示 = e.ヴィオラ_金具右_金具2_表示;
			this.染み_染み2_表示 = e.染み_染み2_表示;
			this.染み_染み1_表示 = e.染み_染み1_表示;
			this.ベ\u30FCス表示 = e.ベ\u30FCス表示;
			this.紐輪表示 = e.紐輪表示;
			this.紐表示 = e.紐表示;
			this.縁1表示 = e.縁1表示;
			this.縁2表示 = e.縁2表示;
			this.縁3表示 = e.縁3表示;
			this.縁4表示 = e.縁4表示;
			this.ヴィオラ表示 = e.ヴィオラ表示;
			this.染み表示 = e.染み表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_紐左CP = new ColorP(this.X0Y0_紐左, this.紐左CD, DisUnit, true);
			this.X0Y0_紐右CP = new ColorP(this.X0Y0_紐右, this.紐右CD, DisUnit, true);
			this.X0Y0_下地CP = new ColorP(this.X0Y0_下地, this.下地CD, DisUnit, true);
			this.X0Y0_線CP = new ColorP(this.X0Y0_線, this.線CD, DisUnit, true);
			this.X0Y0_ライン_ライン上CP = new ColorP(this.X0Y0_ライン_ライン上, this.ライン_ライン上CD, DisUnit, true);
			this.X0Y0_ライン_ライン左CP = new ColorP(this.X0Y0_ライン_ライン左, this.ライン_ライン左CD, DisUnit, true);
			this.X0Y0_ライン_ライン右CP = new ColorP(this.X0Y0_ライン_ライン右, this.ライン_ライン右CD, DisUnit, true);
			this.X0Y0_ライン_ライン左下CP = new ColorP(this.X0Y0_ライン_ライン左下, this.ライン_ライン左下CD, DisUnit, true);
			this.X0Y0_ライン_ライン右下CP = new ColorP(this.X0Y0_ライン_ライン右下, this.ライン_ライン右下CD, DisUnit, true);
			this.X0Y0_ライン_ライン下左CP = new ColorP(this.X0Y0_ライン_ライン下左, this.ライン_ライン下左CD, DisUnit, true);
			this.X0Y0_ライン_ライン下右CP = new ColorP(this.X0Y0_ライン_ライン下右, this.ライン_ライン下右CD, DisUnit, true);
			this.X0Y0_結び紐左_紐1CP = new ColorP(this.X0Y0_結び紐左_紐1, this.結び紐左_紐1CD, DisUnit, true);
			this.X0Y0_結び紐左_紐2CP = new ColorP(this.X0Y0_結び紐左_紐2, this.結び紐左_紐2CD, DisUnit, true);
			this.X0Y0_結び紐左_輪1_紐後CP = new ColorP(this.X0Y0_結び紐左_輪1_紐後, this.結び紐左_輪1_紐後CD, DisUnit, true);
			this.X0Y0_結び紐左_輪1_紐前CP = new ColorP(this.X0Y0_結び紐左_輪1_紐前, this.結び紐左_輪1_紐前CD, DisUnit, true);
			this.X0Y0_結び紐左_輪2_紐後CP = new ColorP(this.X0Y0_結び紐左_輪2_紐後, this.結び紐左_輪2_紐後CD, DisUnit, true);
			this.X0Y0_結び紐左_輪2_紐前CP = new ColorP(this.X0Y0_結び紐左_輪2_紐前, this.結び紐左_輪2_紐前CD, DisUnit, true);
			this.X0Y0_結び紐左_結び目CP = new ColorP(this.X0Y0_結び紐左_結び目, this.結び紐左_結び目CD, DisUnit, true);
			this.X0Y0_結び紐右_紐1CP = new ColorP(this.X0Y0_結び紐右_紐1, this.結び紐右_紐1CD, DisUnit, true);
			this.X0Y0_結び紐右_紐2CP = new ColorP(this.X0Y0_結び紐右_紐2, this.結び紐右_紐2CD, DisUnit, true);
			this.X0Y0_結び紐右_輪1_紐後CP = new ColorP(this.X0Y0_結び紐右_輪1_紐後, this.結び紐右_輪1_紐後CD, DisUnit, true);
			this.X0Y0_結び紐右_輪1_紐前CP = new ColorP(this.X0Y0_結び紐右_輪1_紐前, this.結び紐右_輪1_紐前CD, DisUnit, true);
			this.X0Y0_結び紐右_輪2_紐後CP = new ColorP(this.X0Y0_結び紐右_輪2_紐後, this.結び紐右_輪2_紐後CD, DisUnit, true);
			this.X0Y0_結び紐右_輪2_紐前CP = new ColorP(this.X0Y0_結び紐右_輪2_紐前, this.結び紐右_輪2_紐前CD, DisUnit, true);
			this.X0Y0_結び紐右_結び目CP = new ColorP(this.X0Y0_結び紐右_結び目, this.結び紐右_結び目CD, DisUnit, true);
			this.X0Y0_ヴィオラ_紐左CP = new ColorP(this.X0Y0_ヴィオラ_紐左, this.ヴィオラ_紐左CD, DisUnit, true);
			this.X0Y0_ヴィオラ_紐右CP = new ColorP(this.X0Y0_ヴィオラ_紐右, this.ヴィオラ_紐右CD, DisUnit, true);
			this.X0Y0_ヴィオラ_丸金具左CP = new ColorP(this.X0Y0_ヴィオラ_丸金具左, this.ヴィオラ_丸金具左CD, DisUnit, true);
			this.X0Y0_ヴィオラ_丸金具右CP = new ColorP(this.X0Y0_ヴィオラ_丸金具右, this.ヴィオラ_丸金具右CD, DisUnit, true);
			this.X0Y0_ヴィオラ_金具左_金具1CP = new ColorP(this.X0Y0_ヴィオラ_金具左_金具1, this.ヴィオラ_金具左_金具1CD, DisUnit, true);
			this.X0Y0_ヴィオラ_金具左_金具2CP = new ColorP(this.X0Y0_ヴィオラ_金具左_金具2, this.ヴィオラ_金具左_金具2CD, DisUnit, true);
			this.X0Y0_ヴィオラ_金具右_金具1CP = new ColorP(this.X0Y0_ヴィオラ_金具右_金具1, this.ヴィオラ_金具右_金具1CD, DisUnit, true);
			this.X0Y0_ヴィオラ_金具右_金具2CP = new ColorP(this.X0Y0_ヴィオラ_金具右_金具2, this.ヴィオラ_金具右_金具2CD, DisUnit, true);
			this.X0Y0_染み_染み2CP = new ColorP(this.X0Y0_染み_染み2, this.染み_染み2CD, DisUnit, true);
			this.X0Y0_染み_染み1CP = new ColorP(this.X0Y0_染み_染み1, this.染み_染み1CD, DisUnit, true);
			this.X0Y1_紐左CP = new ColorP(this.X0Y1_紐左, this.紐左CD, DisUnit, true);
			this.X0Y1_紐右CP = new ColorP(this.X0Y1_紐右, this.紐右CD, DisUnit, true);
			this.X0Y1_下地CP = new ColorP(this.X0Y1_下地, this.下地CD, DisUnit, true);
			this.X0Y1_線CP = new ColorP(this.X0Y1_線, this.線CD, DisUnit, true);
			this.X0Y1_ライン_ライン上CP = new ColorP(this.X0Y1_ライン_ライン上, this.ライン_ライン上CD, DisUnit, true);
			this.X0Y1_ライン_ライン左CP = new ColorP(this.X0Y1_ライン_ライン左, this.ライン_ライン左CD, DisUnit, true);
			this.X0Y1_ライン_ライン右CP = new ColorP(this.X0Y1_ライン_ライン右, this.ライン_ライン右CD, DisUnit, true);
			this.X0Y1_ライン_ライン左下CP = new ColorP(this.X0Y1_ライン_ライン左下, this.ライン_ライン左下CD, DisUnit, true);
			this.X0Y1_ライン_ライン右下CP = new ColorP(this.X0Y1_ライン_ライン右下, this.ライン_ライン右下CD, DisUnit, true);
			this.X0Y1_ライン_ライン下左CP = new ColorP(this.X0Y1_ライン_ライン下左, this.ライン_ライン下左CD, DisUnit, true);
			this.X0Y1_ライン_ライン下右CP = new ColorP(this.X0Y1_ライン_ライン下右, this.ライン_ライン下右CD, DisUnit, true);
			this.X0Y1_結び紐左_紐1CP = new ColorP(this.X0Y1_結び紐左_紐1, this.結び紐左_紐1CD, DisUnit, true);
			this.X0Y1_結び紐左_紐2CP = new ColorP(this.X0Y1_結び紐左_紐2, this.結び紐左_紐2CD, DisUnit, true);
			this.X0Y1_結び紐左_輪1_紐後CP = new ColorP(this.X0Y1_結び紐左_輪1_紐後, this.結び紐左_輪1_紐後CD, DisUnit, true);
			this.X0Y1_結び紐左_輪1_紐前CP = new ColorP(this.X0Y1_結び紐左_輪1_紐前, this.結び紐左_輪1_紐前CD, DisUnit, true);
			this.X0Y1_結び紐左_輪2_紐後CP = new ColorP(this.X0Y1_結び紐左_輪2_紐後, this.結び紐左_輪2_紐後CD, DisUnit, true);
			this.X0Y1_結び紐左_輪2_紐前CP = new ColorP(this.X0Y1_結び紐左_輪2_紐前, this.結び紐左_輪2_紐前CD, DisUnit, true);
			this.X0Y1_結び紐左_結び目CP = new ColorP(this.X0Y1_結び紐左_結び目, this.結び紐左_結び目CD, DisUnit, true);
			this.X0Y1_結び紐右_紐1CP = new ColorP(this.X0Y1_結び紐右_紐1, this.結び紐右_紐1CD, DisUnit, true);
			this.X0Y1_結び紐右_紐2CP = new ColorP(this.X0Y1_結び紐右_紐2, this.結び紐右_紐2CD, DisUnit, true);
			this.X0Y1_結び紐右_輪1_紐後CP = new ColorP(this.X0Y1_結び紐右_輪1_紐後, this.結び紐右_輪1_紐後CD, DisUnit, true);
			this.X0Y1_結び紐右_輪1_紐前CP = new ColorP(this.X0Y1_結び紐右_輪1_紐前, this.結び紐右_輪1_紐前CD, DisUnit, true);
			this.X0Y1_結び紐右_輪2_紐後CP = new ColorP(this.X0Y1_結び紐右_輪2_紐後, this.結び紐右_輪2_紐後CD, DisUnit, true);
			this.X0Y1_結び紐右_輪2_紐前CP = new ColorP(this.X0Y1_結び紐右_輪2_紐前, this.結び紐右_輪2_紐前CD, DisUnit, true);
			this.X0Y1_結び紐右_結び目CP = new ColorP(this.X0Y1_結び紐右_結び目, this.結び紐右_結び目CD, DisUnit, true);
			this.X0Y1_ヴィオラ_紐左CP = new ColorP(this.X0Y1_ヴィオラ_紐左, this.ヴィオラ_紐左CD, DisUnit, true);
			this.X0Y1_ヴィオラ_紐右CP = new ColorP(this.X0Y1_ヴィオラ_紐右, this.ヴィオラ_紐右CD, DisUnit, true);
			this.X0Y1_ヴィオラ_丸金具左CP = new ColorP(this.X0Y1_ヴィオラ_丸金具左, this.ヴィオラ_丸金具左CD, DisUnit, true);
			this.X0Y1_ヴィオラ_丸金具右CP = new ColorP(this.X0Y1_ヴィオラ_丸金具右, this.ヴィオラ_丸金具右CD, DisUnit, true);
			this.X0Y1_ヴィオラ_金具左_金具1CP = new ColorP(this.X0Y1_ヴィオラ_金具左_金具1, this.ヴィオラ_金具左_金具1CD, DisUnit, true);
			this.X0Y1_ヴィオラ_金具左_金具2CP = new ColorP(this.X0Y1_ヴィオラ_金具左_金具2, this.ヴィオラ_金具左_金具2CD, DisUnit, true);
			this.X0Y1_ヴィオラ_金具右_金具1CP = new ColorP(this.X0Y1_ヴィオラ_金具右_金具1, this.ヴィオラ_金具右_金具1CD, DisUnit, true);
			this.X0Y1_ヴィオラ_金具右_金具2CP = new ColorP(this.X0Y1_ヴィオラ_金具右_金具2, this.ヴィオラ_金具右_金具2CD, DisUnit, true);
			this.X0Y1_染み_染み2CP = new ColorP(this.X0Y1_染み_染み2, this.染み_染み2CD, DisUnit, true);
			this.X0Y1_染み_染み1CP = new ColorP(this.X0Y1_染み_染み1, this.染み_染み1CD, DisUnit, true);
			this.X0Y2_紐左CP = new ColorP(this.X0Y2_紐左, this.紐左CD, DisUnit, true);
			this.X0Y2_紐右CP = new ColorP(this.X0Y2_紐右, this.紐右CD, DisUnit, true);
			this.X0Y2_下地CP = new ColorP(this.X0Y2_下地, this.下地CD, DisUnit, true);
			this.X0Y2_線CP = new ColorP(this.X0Y2_線, this.線CD, DisUnit, true);
			this.X0Y2_ライン_ライン上CP = new ColorP(this.X0Y2_ライン_ライン上, this.ライン_ライン上CD, DisUnit, true);
			this.X0Y2_ライン_ライン左CP = new ColorP(this.X0Y2_ライン_ライン左, this.ライン_ライン左CD, DisUnit, true);
			this.X0Y2_ライン_ライン右CP = new ColorP(this.X0Y2_ライン_ライン右, this.ライン_ライン右CD, DisUnit, true);
			this.X0Y2_ライン_ライン左下CP = new ColorP(this.X0Y2_ライン_ライン左下, this.ライン_ライン左下CD, DisUnit, true);
			this.X0Y2_ライン_ライン右下CP = new ColorP(this.X0Y2_ライン_ライン右下, this.ライン_ライン右下CD, DisUnit, true);
			this.X0Y2_ライン_ライン下左CP = new ColorP(this.X0Y2_ライン_ライン下左, this.ライン_ライン下左CD, DisUnit, true);
			this.X0Y2_ライン_ライン下右CP = new ColorP(this.X0Y2_ライン_ライン下右, this.ライン_ライン下右CD, DisUnit, true);
			this.X0Y2_結び紐左_紐1CP = new ColorP(this.X0Y2_結び紐左_紐1, this.結び紐左_紐1CD, DisUnit, true);
			this.X0Y2_結び紐左_紐2CP = new ColorP(this.X0Y2_結び紐左_紐2, this.結び紐左_紐2CD, DisUnit, true);
			this.X0Y2_結び紐左_輪1_紐後CP = new ColorP(this.X0Y2_結び紐左_輪1_紐後, this.結び紐左_輪1_紐後CD, DisUnit, true);
			this.X0Y2_結び紐左_輪1_紐前CP = new ColorP(this.X0Y2_結び紐左_輪1_紐前, this.結び紐左_輪1_紐前CD, DisUnit, true);
			this.X0Y2_結び紐左_輪2_紐後CP = new ColorP(this.X0Y2_結び紐左_輪2_紐後, this.結び紐左_輪2_紐後CD, DisUnit, true);
			this.X0Y2_結び紐左_輪2_紐前CP = new ColorP(this.X0Y2_結び紐左_輪2_紐前, this.結び紐左_輪2_紐前CD, DisUnit, true);
			this.X0Y2_結び紐左_結び目CP = new ColorP(this.X0Y2_結び紐左_結び目, this.結び紐左_結び目CD, DisUnit, true);
			this.X0Y2_結び紐右_紐1CP = new ColorP(this.X0Y2_結び紐右_紐1, this.結び紐右_紐1CD, DisUnit, true);
			this.X0Y2_結び紐右_紐2CP = new ColorP(this.X0Y2_結び紐右_紐2, this.結び紐右_紐2CD, DisUnit, true);
			this.X0Y2_結び紐右_輪1_紐後CP = new ColorP(this.X0Y2_結び紐右_輪1_紐後, this.結び紐右_輪1_紐後CD, DisUnit, true);
			this.X0Y2_結び紐右_輪1_紐前CP = new ColorP(this.X0Y2_結び紐右_輪1_紐前, this.結び紐右_輪1_紐前CD, DisUnit, true);
			this.X0Y2_結び紐右_輪2_紐後CP = new ColorP(this.X0Y2_結び紐右_輪2_紐後, this.結び紐右_輪2_紐後CD, DisUnit, true);
			this.X0Y2_結び紐右_輪2_紐前CP = new ColorP(this.X0Y2_結び紐右_輪2_紐前, this.結び紐右_輪2_紐前CD, DisUnit, true);
			this.X0Y2_結び紐右_結び目CP = new ColorP(this.X0Y2_結び紐右_結び目, this.結び紐右_結び目CD, DisUnit, true);
			this.X0Y2_ヴィオラ_紐左CP = new ColorP(this.X0Y2_ヴィオラ_紐左, this.ヴィオラ_紐左CD, DisUnit, true);
			this.X0Y2_ヴィオラ_紐右CP = new ColorP(this.X0Y2_ヴィオラ_紐右, this.ヴィオラ_紐右CD, DisUnit, true);
			this.X0Y2_ヴィオラ_丸金具左CP = new ColorP(this.X0Y2_ヴィオラ_丸金具左, this.ヴィオラ_丸金具左CD, DisUnit, true);
			this.X0Y2_ヴィオラ_丸金具右CP = new ColorP(this.X0Y2_ヴィオラ_丸金具右, this.ヴィオラ_丸金具右CD, DisUnit, true);
			this.X0Y2_ヴィオラ_金具左_金具1CP = new ColorP(this.X0Y2_ヴィオラ_金具左_金具1, this.ヴィオラ_金具左_金具1CD, DisUnit, true);
			this.X0Y2_ヴィオラ_金具左_金具2CP = new ColorP(this.X0Y2_ヴィオラ_金具左_金具2, this.ヴィオラ_金具左_金具2CD, DisUnit, true);
			this.X0Y2_ヴィオラ_金具右_金具1CP = new ColorP(this.X0Y2_ヴィオラ_金具右_金具1, this.ヴィオラ_金具右_金具1CD, DisUnit, true);
			this.X0Y2_ヴィオラ_金具右_金具2CP = new ColorP(this.X0Y2_ヴィオラ_金具右_金具2, this.ヴィオラ_金具右_金具2CD, DisUnit, true);
			this.X0Y2_染み_染み2CP = new ColorP(this.X0Y2_染み_染み2, this.染み_染み2CD, DisUnit, true);
			this.X0Y2_染み_染み1CP = new ColorP(this.X0Y2_染み_染み1, this.染み_染み1CD, DisUnit, true);
			this.X0Y3_紐左CP = new ColorP(this.X0Y3_紐左, this.紐左CD, DisUnit, true);
			this.X0Y3_紐右CP = new ColorP(this.X0Y3_紐右, this.紐右CD, DisUnit, true);
			this.X0Y3_下地CP = new ColorP(this.X0Y3_下地, this.下地CD, DisUnit, true);
			this.X0Y3_線CP = new ColorP(this.X0Y3_線, this.線CD, DisUnit, true);
			this.X0Y3_ライン_ライン上CP = new ColorP(this.X0Y3_ライン_ライン上, this.ライン_ライン上CD, DisUnit, true);
			this.X0Y3_ライン_ライン左CP = new ColorP(this.X0Y3_ライン_ライン左, this.ライン_ライン左CD, DisUnit, true);
			this.X0Y3_ライン_ライン右CP = new ColorP(this.X0Y3_ライン_ライン右, this.ライン_ライン右CD, DisUnit, true);
			this.X0Y3_ライン_ライン左下CP = new ColorP(this.X0Y3_ライン_ライン左下, this.ライン_ライン左下CD, DisUnit, true);
			this.X0Y3_ライン_ライン右下CP = new ColorP(this.X0Y3_ライン_ライン右下, this.ライン_ライン右下CD, DisUnit, true);
			this.X0Y3_ライン_ライン下左CP = new ColorP(this.X0Y3_ライン_ライン下左, this.ライン_ライン下左CD, DisUnit, true);
			this.X0Y3_ライン_ライン下右CP = new ColorP(this.X0Y3_ライン_ライン下右, this.ライン_ライン下右CD, DisUnit, true);
			this.X0Y3_結び紐左_紐1CP = new ColorP(this.X0Y3_結び紐左_紐1, this.結び紐左_紐1CD, DisUnit, true);
			this.X0Y3_結び紐左_紐2CP = new ColorP(this.X0Y3_結び紐左_紐2, this.結び紐左_紐2CD, DisUnit, true);
			this.X0Y3_結び紐左_輪1_紐後CP = new ColorP(this.X0Y3_結び紐左_輪1_紐後, this.結び紐左_輪1_紐後CD, DisUnit, true);
			this.X0Y3_結び紐左_輪1_紐前CP = new ColorP(this.X0Y3_結び紐左_輪1_紐前, this.結び紐左_輪1_紐前CD, DisUnit, true);
			this.X0Y3_結び紐左_輪2_紐後CP = new ColorP(this.X0Y3_結び紐左_輪2_紐後, this.結び紐左_輪2_紐後CD, DisUnit, true);
			this.X0Y3_結び紐左_輪2_紐前CP = new ColorP(this.X0Y3_結び紐左_輪2_紐前, this.結び紐左_輪2_紐前CD, DisUnit, true);
			this.X0Y3_結び紐左_結び目CP = new ColorP(this.X0Y3_結び紐左_結び目, this.結び紐左_結び目CD, DisUnit, true);
			this.X0Y3_結び紐右_紐1CP = new ColorP(this.X0Y3_結び紐右_紐1, this.結び紐右_紐1CD, DisUnit, true);
			this.X0Y3_結び紐右_紐2CP = new ColorP(this.X0Y3_結び紐右_紐2, this.結び紐右_紐2CD, DisUnit, true);
			this.X0Y3_結び紐右_輪1_紐後CP = new ColorP(this.X0Y3_結び紐右_輪1_紐後, this.結び紐右_輪1_紐後CD, DisUnit, true);
			this.X0Y3_結び紐右_輪1_紐前CP = new ColorP(this.X0Y3_結び紐右_輪1_紐前, this.結び紐右_輪1_紐前CD, DisUnit, true);
			this.X0Y3_結び紐右_輪2_紐後CP = new ColorP(this.X0Y3_結び紐右_輪2_紐後, this.結び紐右_輪2_紐後CD, DisUnit, true);
			this.X0Y3_結び紐右_輪2_紐前CP = new ColorP(this.X0Y3_結び紐右_輪2_紐前, this.結び紐右_輪2_紐前CD, DisUnit, true);
			this.X0Y3_結び紐右_結び目CP = new ColorP(this.X0Y3_結び紐右_結び目, this.結び紐右_結び目CD, DisUnit, true);
			this.X0Y3_ヴィオラ_紐左CP = new ColorP(this.X0Y3_ヴィオラ_紐左, this.ヴィオラ_紐左CD, DisUnit, true);
			this.X0Y3_ヴィオラ_紐右CP = new ColorP(this.X0Y3_ヴィオラ_紐右, this.ヴィオラ_紐右CD, DisUnit, true);
			this.X0Y3_ヴィオラ_丸金具左CP = new ColorP(this.X0Y3_ヴィオラ_丸金具左, this.ヴィオラ_丸金具左CD, DisUnit, true);
			this.X0Y3_ヴィオラ_丸金具右CP = new ColorP(this.X0Y3_ヴィオラ_丸金具右, this.ヴィオラ_丸金具右CD, DisUnit, true);
			this.X0Y3_ヴィオラ_金具左_金具1CP = new ColorP(this.X0Y3_ヴィオラ_金具左_金具1, this.ヴィオラ_金具左_金具1CD, DisUnit, true);
			this.X0Y3_ヴィオラ_金具左_金具2CP = new ColorP(this.X0Y3_ヴィオラ_金具左_金具2, this.ヴィオラ_金具左_金具2CD, DisUnit, true);
			this.X0Y3_ヴィオラ_金具右_金具1CP = new ColorP(this.X0Y3_ヴィオラ_金具右_金具1, this.ヴィオラ_金具右_金具1CD, DisUnit, true);
			this.X0Y3_ヴィオラ_金具右_金具2CP = new ColorP(this.X0Y3_ヴィオラ_金具右_金具2, this.ヴィオラ_金具右_金具2CD, DisUnit, true);
			this.X0Y3_染み_染み2CP = new ColorP(this.X0Y3_染み_染み2, this.染み_染み2CD, DisUnit, true);
			this.X0Y3_染み_染み1CP = new ColorP(this.X0Y3_染み_染み1, this.染み_染み1CD, DisUnit, true);
			this.X0Y4_紐左CP = new ColorP(this.X0Y4_紐左, this.紐左CD, DisUnit, true);
			this.X0Y4_紐右CP = new ColorP(this.X0Y4_紐右, this.紐右CD, DisUnit, true);
			this.X0Y4_下地CP = new ColorP(this.X0Y4_下地, this.下地CD, DisUnit, true);
			this.X0Y4_線CP = new ColorP(this.X0Y4_線, this.線CD, DisUnit, true);
			this.X0Y4_ライン_ライン上CP = new ColorP(this.X0Y4_ライン_ライン上, this.ライン_ライン上CD, DisUnit, true);
			this.X0Y4_ライン_ライン左CP = new ColorP(this.X0Y4_ライン_ライン左, this.ライン_ライン左CD, DisUnit, true);
			this.X0Y4_ライン_ライン右CP = new ColorP(this.X0Y4_ライン_ライン右, this.ライン_ライン右CD, DisUnit, true);
			this.X0Y4_ライン_ライン左下CP = new ColorP(this.X0Y4_ライン_ライン左下, this.ライン_ライン左下CD, DisUnit, true);
			this.X0Y4_ライン_ライン右下CP = new ColorP(this.X0Y4_ライン_ライン右下, this.ライン_ライン右下CD, DisUnit, true);
			this.X0Y4_ライン_ライン下左CP = new ColorP(this.X0Y4_ライン_ライン下左, this.ライン_ライン下左CD, DisUnit, true);
			this.X0Y4_ライン_ライン下右CP = new ColorP(this.X0Y4_ライン_ライン下右, this.ライン_ライン下右CD, DisUnit, true);
			this.X0Y4_結び紐左_紐1CP = new ColorP(this.X0Y4_結び紐左_紐1, this.結び紐左_紐1CD, DisUnit, true);
			this.X0Y4_結び紐左_紐2CP = new ColorP(this.X0Y4_結び紐左_紐2, this.結び紐左_紐2CD, DisUnit, true);
			this.X0Y4_結び紐左_輪1_紐後CP = new ColorP(this.X0Y4_結び紐左_輪1_紐後, this.結び紐左_輪1_紐後CD, DisUnit, true);
			this.X0Y4_結び紐左_輪1_紐前CP = new ColorP(this.X0Y4_結び紐左_輪1_紐前, this.結び紐左_輪1_紐前CD, DisUnit, true);
			this.X0Y4_結び紐左_輪2_紐後CP = new ColorP(this.X0Y4_結び紐左_輪2_紐後, this.結び紐左_輪2_紐後CD, DisUnit, true);
			this.X0Y4_結び紐左_輪2_紐前CP = new ColorP(this.X0Y4_結び紐左_輪2_紐前, this.結び紐左_輪2_紐前CD, DisUnit, true);
			this.X0Y4_結び紐左_結び目CP = new ColorP(this.X0Y4_結び紐左_結び目, this.結び紐左_結び目CD, DisUnit, true);
			this.X0Y4_結び紐右_紐1CP = new ColorP(this.X0Y4_結び紐右_紐1, this.結び紐右_紐1CD, DisUnit, true);
			this.X0Y4_結び紐右_紐2CP = new ColorP(this.X0Y4_結び紐右_紐2, this.結び紐右_紐2CD, DisUnit, true);
			this.X0Y4_結び紐右_輪1_紐後CP = new ColorP(this.X0Y4_結び紐右_輪1_紐後, this.結び紐右_輪1_紐後CD, DisUnit, true);
			this.X0Y4_結び紐右_輪1_紐前CP = new ColorP(this.X0Y4_結び紐右_輪1_紐前, this.結び紐右_輪1_紐前CD, DisUnit, true);
			this.X0Y4_結び紐右_輪2_紐後CP = new ColorP(this.X0Y4_結び紐右_輪2_紐後, this.結び紐右_輪2_紐後CD, DisUnit, true);
			this.X0Y4_結び紐右_輪2_紐前CP = new ColorP(this.X0Y4_結び紐右_輪2_紐前, this.結び紐右_輪2_紐前CD, DisUnit, true);
			this.X0Y4_結び紐右_結び目CP = new ColorP(this.X0Y4_結び紐右_結び目, this.結び紐右_結び目CD, DisUnit, true);
			this.X0Y4_ヴィオラ_紐左CP = new ColorP(this.X0Y4_ヴィオラ_紐左, this.ヴィオラ_紐左CD, DisUnit, true);
			this.X0Y4_ヴィオラ_紐右CP = new ColorP(this.X0Y4_ヴィオラ_紐右, this.ヴィオラ_紐右CD, DisUnit, true);
			this.X0Y4_ヴィオラ_丸金具左CP = new ColorP(this.X0Y4_ヴィオラ_丸金具左, this.ヴィオラ_丸金具左CD, DisUnit, true);
			this.X0Y4_ヴィオラ_丸金具右CP = new ColorP(this.X0Y4_ヴィオラ_丸金具右, this.ヴィオラ_丸金具右CD, DisUnit, true);
			this.X0Y4_ヴィオラ_金具左_金具1CP = new ColorP(this.X0Y4_ヴィオラ_金具左_金具1, this.ヴィオラ_金具左_金具1CD, DisUnit, true);
			this.X0Y4_ヴィオラ_金具左_金具2CP = new ColorP(this.X0Y4_ヴィオラ_金具左_金具2, this.ヴィオラ_金具左_金具2CD, DisUnit, true);
			this.X0Y4_ヴィオラ_金具右_金具1CP = new ColorP(this.X0Y4_ヴィオラ_金具右_金具1, this.ヴィオラ_金具右_金具1CD, DisUnit, true);
			this.X0Y4_ヴィオラ_金具右_金具2CP = new ColorP(this.X0Y4_ヴィオラ_金具右_金具2, this.ヴィオラ_金具右_金具2CD, DisUnit, true);
			this.X0Y4_染み_染み2CP = new ColorP(this.X0Y4_染み_染み2, this.染み_染み2CD, DisUnit, true);
			this.X0Y4_染み_染み1CP = new ColorP(this.X0Y4_染み_染み1, this.染み_染み1CD, DisUnit, true);
			this.染み濃度 = e.染み濃度;
			this.濃度 = e.濃度;
			this.尺度YB = 0.95;
			double y = 0.0005;
			this.X0Y0_下地.BasePointBase = this.X0Y0_下地.BasePointBase.AddY(y);
			this.X0Y1_下地.BasePointBase = this.X0Y1_下地.BasePointBase.AddY(y);
			this.X0Y2_下地.BasePointBase = this.X0Y2_下地.BasePointBase.AddY(y);
			this.X0Y3_下地.BasePointBase = this.X0Y3_下地.BasePointBase.AddY(y);
			this.X0Y4_下地.BasePointBase = this.X0Y4_下地.BasePointBase.AddY(y);
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

		public bool 紐左_表示
		{
			get
			{
				return this.X0Y0_紐左.Dra;
			}
			set
			{
				this.X0Y0_紐左.Dra = value;
				this.X0Y1_紐左.Dra = value;
				this.X0Y2_紐左.Dra = value;
				this.X0Y3_紐左.Dra = value;
				this.X0Y4_紐左.Dra = value;
				this.X0Y0_紐左.Hit = false;
				this.X0Y1_紐左.Hit = false;
				this.X0Y2_紐左.Hit = false;
				this.X0Y3_紐左.Hit = false;
				this.X0Y4_紐左.Hit = false;
			}
		}

		public bool 紐右_表示
		{
			get
			{
				return this.X0Y0_紐右.Dra;
			}
			set
			{
				this.X0Y0_紐右.Dra = value;
				this.X0Y1_紐右.Dra = value;
				this.X0Y2_紐右.Dra = value;
				this.X0Y3_紐右.Dra = value;
				this.X0Y4_紐右.Dra = value;
				this.X0Y0_紐右.Hit = false;
				this.X0Y1_紐右.Hit = false;
				this.X0Y2_紐右.Hit = false;
				this.X0Y3_紐右.Hit = false;
				this.X0Y4_紐右.Hit = false;
			}
		}

		public bool 下地_表示
		{
			get
			{
				return this.X0Y0_下地.Dra;
			}
			set
			{
				this.X0Y0_下地.Dra = value;
				this.X0Y1_下地.Dra = value;
				this.X0Y2_下地.Dra = value;
				this.X0Y3_下地.Dra = value;
				this.X0Y4_下地.Dra = value;
				this.X0Y0_下地.Hit = false;
				this.X0Y1_下地.Hit = false;
				this.X0Y2_下地.Hit = false;
				this.X0Y3_下地.Hit = false;
				this.X0Y4_下地.Hit = false;
			}
		}

		public bool 線_表示
		{
			get
			{
				return this.X0Y0_線.Dra;
			}
			set
			{
				this.X0Y0_線.Dra = value;
				this.X0Y1_線.Dra = value;
				this.X0Y2_線.Dra = value;
				this.X0Y3_線.Dra = value;
				this.X0Y4_線.Dra = value;
				this.X0Y0_線.Hit = false;
				this.X0Y1_線.Hit = false;
				this.X0Y2_線.Hit = false;
				this.X0Y3_線.Hit = false;
				this.X0Y4_線.Hit = false;
			}
		}

		public bool ライン_ライン上_表示
		{
			get
			{
				return this.X0Y0_ライン_ライン上.Dra;
			}
			set
			{
				this.X0Y0_ライン_ライン上.Dra = value;
				this.X0Y1_ライン_ライン上.Dra = value;
				this.X0Y2_ライン_ライン上.Dra = value;
				this.X0Y3_ライン_ライン上.Dra = value;
				this.X0Y4_ライン_ライン上.Dra = value;
				this.X0Y0_ライン_ライン上.Hit = false;
				this.X0Y1_ライン_ライン上.Hit = false;
				this.X0Y2_ライン_ライン上.Hit = false;
				this.X0Y3_ライン_ライン上.Hit = false;
				this.X0Y4_ライン_ライン上.Hit = false;
			}
		}

		public bool ライン_ライン左_表示
		{
			get
			{
				return this.X0Y0_ライン_ライン左.Dra;
			}
			set
			{
				this.X0Y0_ライン_ライン左.Dra = value;
				this.X0Y1_ライン_ライン左.Dra = value;
				this.X0Y2_ライン_ライン左.Dra = value;
				this.X0Y3_ライン_ライン左.Dra = value;
				this.X0Y4_ライン_ライン左.Dra = value;
				this.X0Y0_ライン_ライン左.Hit = false;
				this.X0Y1_ライン_ライン左.Hit = false;
				this.X0Y2_ライン_ライン左.Hit = false;
				this.X0Y3_ライン_ライン左.Hit = false;
				this.X0Y4_ライン_ライン左.Hit = false;
			}
		}

		public bool ライン_ライン右_表示
		{
			get
			{
				return this.X0Y0_ライン_ライン右.Dra;
			}
			set
			{
				this.X0Y0_ライン_ライン右.Dra = value;
				this.X0Y1_ライン_ライン右.Dra = value;
				this.X0Y2_ライン_ライン右.Dra = value;
				this.X0Y3_ライン_ライン右.Dra = value;
				this.X0Y4_ライン_ライン右.Dra = value;
				this.X0Y0_ライン_ライン右.Hit = false;
				this.X0Y1_ライン_ライン右.Hit = false;
				this.X0Y2_ライン_ライン右.Hit = false;
				this.X0Y3_ライン_ライン右.Hit = false;
				this.X0Y4_ライン_ライン右.Hit = false;
			}
		}

		public bool ライン_ライン左下_表示
		{
			get
			{
				return this.X0Y0_ライン_ライン左下.Dra;
			}
			set
			{
				this.X0Y0_ライン_ライン左下.Dra = value;
				this.X0Y1_ライン_ライン左下.Dra = value;
				this.X0Y2_ライン_ライン左下.Dra = value;
				this.X0Y3_ライン_ライン左下.Dra = value;
				this.X0Y4_ライン_ライン左下.Dra = value;
				this.X0Y0_ライン_ライン左下.Hit = false;
				this.X0Y1_ライン_ライン左下.Hit = false;
				this.X0Y2_ライン_ライン左下.Hit = false;
				this.X0Y3_ライン_ライン左下.Hit = false;
				this.X0Y4_ライン_ライン左下.Hit = false;
			}
		}

		public bool ライン_ライン右下_表示
		{
			get
			{
				return this.X0Y0_ライン_ライン右下.Dra;
			}
			set
			{
				this.X0Y0_ライン_ライン右下.Dra = value;
				this.X0Y1_ライン_ライン右下.Dra = value;
				this.X0Y2_ライン_ライン右下.Dra = value;
				this.X0Y3_ライン_ライン右下.Dra = value;
				this.X0Y4_ライン_ライン右下.Dra = value;
				this.X0Y0_ライン_ライン右下.Hit = false;
				this.X0Y1_ライン_ライン右下.Hit = false;
				this.X0Y2_ライン_ライン右下.Hit = false;
				this.X0Y3_ライン_ライン右下.Hit = false;
				this.X0Y4_ライン_ライン右下.Hit = false;
			}
		}

		public bool ライン_ライン下左_表示
		{
			get
			{
				return this.X0Y0_ライン_ライン下左.Dra;
			}
			set
			{
				this.X0Y0_ライン_ライン下左.Dra = value;
				this.X0Y1_ライン_ライン下左.Dra = value;
				this.X0Y2_ライン_ライン下左.Dra = value;
				this.X0Y3_ライン_ライン下左.Dra = value;
				this.X0Y4_ライン_ライン下左.Dra = value;
				this.X0Y0_ライン_ライン下左.Hit = false;
				this.X0Y1_ライン_ライン下左.Hit = false;
				this.X0Y2_ライン_ライン下左.Hit = false;
				this.X0Y3_ライン_ライン下左.Hit = false;
				this.X0Y4_ライン_ライン下左.Hit = false;
			}
		}

		public bool ライン_ライン下右_表示
		{
			get
			{
				return this.X0Y0_ライン_ライン下右.Dra;
			}
			set
			{
				this.X0Y0_ライン_ライン下右.Dra = value;
				this.X0Y1_ライン_ライン下右.Dra = value;
				this.X0Y2_ライン_ライン下右.Dra = value;
				this.X0Y3_ライン_ライン下右.Dra = value;
				this.X0Y4_ライン_ライン下右.Dra = value;
				this.X0Y0_ライン_ライン下右.Hit = false;
				this.X0Y1_ライン_ライン下右.Hit = false;
				this.X0Y2_ライン_ライン下右.Hit = false;
				this.X0Y3_ライン_ライン下右.Hit = false;
				this.X0Y4_ライン_ライン下右.Hit = false;
			}
		}

		public bool 結び紐左_紐1_表示
		{
			get
			{
				return this.X0Y0_結び紐左_紐1.Dra;
			}
			set
			{
				this.X0Y0_結び紐左_紐1.Dra = value;
				this.X0Y1_結び紐左_紐1.Dra = value;
				this.X0Y2_結び紐左_紐1.Dra = value;
				this.X0Y3_結び紐左_紐1.Dra = value;
				this.X0Y4_結び紐左_紐1.Dra = value;
				this.X0Y0_結び紐左_紐1.Hit = false;
				this.X0Y1_結び紐左_紐1.Hit = false;
				this.X0Y2_結び紐左_紐1.Hit = false;
				this.X0Y3_結び紐左_紐1.Hit = false;
				this.X0Y4_結び紐左_紐1.Hit = false;
			}
		}

		public bool 結び紐左_紐2_表示
		{
			get
			{
				return this.X0Y0_結び紐左_紐2.Dra;
			}
			set
			{
				this.X0Y0_結び紐左_紐2.Dra = value;
				this.X0Y1_結び紐左_紐2.Dra = value;
				this.X0Y2_結び紐左_紐2.Dra = value;
				this.X0Y3_結び紐左_紐2.Dra = value;
				this.X0Y4_結び紐左_紐2.Dra = value;
				this.X0Y0_結び紐左_紐2.Hit = false;
				this.X0Y1_結び紐左_紐2.Hit = false;
				this.X0Y2_結び紐左_紐2.Hit = false;
				this.X0Y3_結び紐左_紐2.Hit = false;
				this.X0Y4_結び紐左_紐2.Hit = false;
			}
		}

		public bool 結び紐左_輪1_紐後_表示
		{
			get
			{
				return this.X0Y0_結び紐左_輪1_紐後.Dra;
			}
			set
			{
				this.X0Y0_結び紐左_輪1_紐後.Dra = value;
				this.X0Y1_結び紐左_輪1_紐後.Dra = value;
				this.X0Y2_結び紐左_輪1_紐後.Dra = value;
				this.X0Y3_結び紐左_輪1_紐後.Dra = value;
				this.X0Y4_結び紐左_輪1_紐後.Dra = value;
				this.X0Y0_結び紐左_輪1_紐後.Hit = false;
				this.X0Y1_結び紐左_輪1_紐後.Hit = false;
				this.X0Y2_結び紐左_輪1_紐後.Hit = false;
				this.X0Y3_結び紐左_輪1_紐後.Hit = false;
				this.X0Y4_結び紐左_輪1_紐後.Hit = false;
			}
		}

		public bool 結び紐左_輪1_紐前_表示
		{
			get
			{
				return this.X0Y0_結び紐左_輪1_紐前.Dra;
			}
			set
			{
				this.X0Y0_結び紐左_輪1_紐前.Dra = value;
				this.X0Y1_結び紐左_輪1_紐前.Dra = value;
				this.X0Y2_結び紐左_輪1_紐前.Dra = value;
				this.X0Y3_結び紐左_輪1_紐前.Dra = value;
				this.X0Y4_結び紐左_輪1_紐前.Dra = value;
				this.X0Y0_結び紐左_輪1_紐前.Hit = false;
				this.X0Y1_結び紐左_輪1_紐前.Hit = false;
				this.X0Y2_結び紐左_輪1_紐前.Hit = false;
				this.X0Y3_結び紐左_輪1_紐前.Hit = false;
				this.X0Y4_結び紐左_輪1_紐前.Hit = false;
			}
		}

		public bool 結び紐左_輪2_紐後_表示
		{
			get
			{
				return this.X0Y0_結び紐左_輪2_紐後.Dra;
			}
			set
			{
				this.X0Y0_結び紐左_輪2_紐後.Dra = value;
				this.X0Y1_結び紐左_輪2_紐後.Dra = value;
				this.X0Y2_結び紐左_輪2_紐後.Dra = value;
				this.X0Y3_結び紐左_輪2_紐後.Dra = value;
				this.X0Y4_結び紐左_輪2_紐後.Dra = value;
				this.X0Y0_結び紐左_輪2_紐後.Hit = false;
				this.X0Y1_結び紐左_輪2_紐後.Hit = false;
				this.X0Y2_結び紐左_輪2_紐後.Hit = false;
				this.X0Y3_結び紐左_輪2_紐後.Hit = false;
				this.X0Y4_結び紐左_輪2_紐後.Hit = false;
			}
		}

		public bool 結び紐左_輪2_紐前_表示
		{
			get
			{
				return this.X0Y0_結び紐左_輪2_紐前.Dra;
			}
			set
			{
				this.X0Y0_結び紐左_輪2_紐前.Dra = value;
				this.X0Y1_結び紐左_輪2_紐前.Dra = value;
				this.X0Y2_結び紐左_輪2_紐前.Dra = value;
				this.X0Y3_結び紐左_輪2_紐前.Dra = value;
				this.X0Y4_結び紐左_輪2_紐前.Dra = value;
				this.X0Y0_結び紐左_輪2_紐前.Hit = false;
				this.X0Y1_結び紐左_輪2_紐前.Hit = false;
				this.X0Y2_結び紐左_輪2_紐前.Hit = false;
				this.X0Y3_結び紐左_輪2_紐前.Hit = false;
				this.X0Y4_結び紐左_輪2_紐前.Hit = false;
			}
		}

		public bool 結び紐左_結び目_表示
		{
			get
			{
				return this.X0Y0_結び紐左_結び目.Dra;
			}
			set
			{
				this.X0Y0_結び紐左_結び目.Dra = value;
				this.X0Y1_結び紐左_結び目.Dra = value;
				this.X0Y2_結び紐左_結び目.Dra = value;
				this.X0Y3_結び紐左_結び目.Dra = value;
				this.X0Y4_結び紐左_結び目.Dra = value;
				this.X0Y0_結び紐左_結び目.Hit = false;
				this.X0Y1_結び紐左_結び目.Hit = false;
				this.X0Y2_結び紐左_結び目.Hit = false;
				this.X0Y3_結び紐左_結び目.Hit = false;
				this.X0Y4_結び紐左_結び目.Hit = false;
			}
		}

		public bool 結び紐右_紐1_表示
		{
			get
			{
				return this.X0Y0_結び紐右_紐1.Dra;
			}
			set
			{
				this.X0Y0_結び紐右_紐1.Dra = value;
				this.X0Y1_結び紐右_紐1.Dra = value;
				this.X0Y2_結び紐右_紐1.Dra = value;
				this.X0Y3_結び紐右_紐1.Dra = value;
				this.X0Y4_結び紐右_紐1.Dra = value;
				this.X0Y0_結び紐右_紐1.Hit = false;
				this.X0Y1_結び紐右_紐1.Hit = false;
				this.X0Y2_結び紐右_紐1.Hit = false;
				this.X0Y3_結び紐右_紐1.Hit = false;
				this.X0Y4_結び紐右_紐1.Hit = false;
			}
		}

		public bool 結び紐右_紐2_表示
		{
			get
			{
				return this.X0Y0_結び紐右_紐2.Dra;
			}
			set
			{
				this.X0Y0_結び紐右_紐2.Dra = value;
				this.X0Y1_結び紐右_紐2.Dra = value;
				this.X0Y2_結び紐右_紐2.Dra = value;
				this.X0Y3_結び紐右_紐2.Dra = value;
				this.X0Y4_結び紐右_紐2.Dra = value;
				this.X0Y0_結び紐右_紐2.Hit = false;
				this.X0Y1_結び紐右_紐2.Hit = false;
				this.X0Y2_結び紐右_紐2.Hit = false;
				this.X0Y3_結び紐右_紐2.Hit = false;
				this.X0Y4_結び紐右_紐2.Hit = false;
			}
		}

		public bool 結び紐右_輪1_紐後_表示
		{
			get
			{
				return this.X0Y0_結び紐右_輪1_紐後.Dra;
			}
			set
			{
				this.X0Y0_結び紐右_輪1_紐後.Dra = value;
				this.X0Y1_結び紐右_輪1_紐後.Dra = value;
				this.X0Y2_結び紐右_輪1_紐後.Dra = value;
				this.X0Y3_結び紐右_輪1_紐後.Dra = value;
				this.X0Y4_結び紐右_輪1_紐後.Dra = value;
				this.X0Y0_結び紐右_輪1_紐後.Hit = false;
				this.X0Y1_結び紐右_輪1_紐後.Hit = false;
				this.X0Y2_結び紐右_輪1_紐後.Hit = false;
				this.X0Y3_結び紐右_輪1_紐後.Hit = false;
				this.X0Y4_結び紐右_輪1_紐後.Hit = false;
			}
		}

		public bool 結び紐右_輪1_紐前_表示
		{
			get
			{
				return this.X0Y0_結び紐右_輪1_紐前.Dra;
			}
			set
			{
				this.X0Y0_結び紐右_輪1_紐前.Dra = value;
				this.X0Y1_結び紐右_輪1_紐前.Dra = value;
				this.X0Y2_結び紐右_輪1_紐前.Dra = value;
				this.X0Y3_結び紐右_輪1_紐前.Dra = value;
				this.X0Y4_結び紐右_輪1_紐前.Dra = value;
				this.X0Y0_結び紐右_輪1_紐前.Hit = false;
				this.X0Y1_結び紐右_輪1_紐前.Hit = false;
				this.X0Y2_結び紐右_輪1_紐前.Hit = false;
				this.X0Y3_結び紐右_輪1_紐前.Hit = false;
				this.X0Y4_結び紐右_輪1_紐前.Hit = false;
			}
		}

		public bool 結び紐右_輪2_紐後_表示
		{
			get
			{
				return this.X0Y0_結び紐右_輪2_紐後.Dra;
			}
			set
			{
				this.X0Y0_結び紐右_輪2_紐後.Dra = value;
				this.X0Y1_結び紐右_輪2_紐後.Dra = value;
				this.X0Y2_結び紐右_輪2_紐後.Dra = value;
				this.X0Y3_結び紐右_輪2_紐後.Dra = value;
				this.X0Y4_結び紐右_輪2_紐後.Dra = value;
				this.X0Y0_結び紐右_輪2_紐後.Hit = false;
				this.X0Y1_結び紐右_輪2_紐後.Hit = false;
				this.X0Y2_結び紐右_輪2_紐後.Hit = false;
				this.X0Y3_結び紐右_輪2_紐後.Hit = false;
				this.X0Y4_結び紐右_輪2_紐後.Hit = false;
			}
		}

		public bool 結び紐右_輪2_紐前_表示
		{
			get
			{
				return this.X0Y0_結び紐右_輪2_紐前.Dra;
			}
			set
			{
				this.X0Y0_結び紐右_輪2_紐前.Dra = value;
				this.X0Y1_結び紐右_輪2_紐前.Dra = value;
				this.X0Y2_結び紐右_輪2_紐前.Dra = value;
				this.X0Y3_結び紐右_輪2_紐前.Dra = value;
				this.X0Y4_結び紐右_輪2_紐前.Dra = value;
				this.X0Y0_結び紐右_輪2_紐前.Hit = false;
				this.X0Y1_結び紐右_輪2_紐前.Hit = false;
				this.X0Y2_結び紐右_輪2_紐前.Hit = false;
				this.X0Y3_結び紐右_輪2_紐前.Hit = false;
				this.X0Y4_結び紐右_輪2_紐前.Hit = false;
			}
		}

		public bool 結び紐右_結び目_表示
		{
			get
			{
				return this.X0Y0_結び紐右_結び目.Dra;
			}
			set
			{
				this.X0Y0_結び紐右_結び目.Dra = value;
				this.X0Y1_結び紐右_結び目.Dra = value;
				this.X0Y2_結び紐右_結び目.Dra = value;
				this.X0Y3_結び紐右_結び目.Dra = value;
				this.X0Y4_結び紐右_結び目.Dra = value;
				this.X0Y0_結び紐右_結び目.Hit = false;
				this.X0Y1_結び紐右_結び目.Hit = false;
				this.X0Y2_結び紐右_結び目.Hit = false;
				this.X0Y3_結び紐右_結び目.Hit = false;
				this.X0Y4_結び紐右_結び目.Hit = false;
			}
		}

		public bool ヴィオラ_紐左_表示
		{
			get
			{
				return this.X0Y0_ヴィオラ_紐左.Dra;
			}
			set
			{
				this.X0Y0_ヴィオラ_紐左.Dra = value;
				this.X0Y1_ヴィオラ_紐左.Dra = value;
				this.X0Y2_ヴィオラ_紐左.Dra = value;
				this.X0Y3_ヴィオラ_紐左.Dra = value;
				this.X0Y4_ヴィオラ_紐左.Dra = value;
				this.X0Y0_ヴィオラ_紐左.Hit = false;
				this.X0Y1_ヴィオラ_紐左.Hit = false;
				this.X0Y2_ヴィオラ_紐左.Hit = false;
				this.X0Y3_ヴィオラ_紐左.Hit = false;
				this.X0Y4_ヴィオラ_紐左.Hit = false;
			}
		}

		public bool ヴィオラ_紐右_表示
		{
			get
			{
				return this.X0Y0_ヴィオラ_紐右.Dra;
			}
			set
			{
				this.X0Y0_ヴィオラ_紐右.Dra = value;
				this.X0Y1_ヴィオラ_紐右.Dra = value;
				this.X0Y2_ヴィオラ_紐右.Dra = value;
				this.X0Y3_ヴィオラ_紐右.Dra = value;
				this.X0Y4_ヴィオラ_紐右.Dra = value;
				this.X0Y0_ヴィオラ_紐右.Hit = false;
				this.X0Y1_ヴィオラ_紐右.Hit = false;
				this.X0Y2_ヴィオラ_紐右.Hit = false;
				this.X0Y3_ヴィオラ_紐右.Hit = false;
				this.X0Y4_ヴィオラ_紐右.Hit = false;
			}
		}

		public bool ヴィオラ_丸金具左_表示
		{
			get
			{
				return this.X0Y0_ヴィオラ_丸金具左.Dra;
			}
			set
			{
				this.X0Y0_ヴィオラ_丸金具左.Dra = value;
				this.X0Y1_ヴィオラ_丸金具左.Dra = value;
				this.X0Y2_ヴィオラ_丸金具左.Dra = value;
				this.X0Y3_ヴィオラ_丸金具左.Dra = value;
				this.X0Y4_ヴィオラ_丸金具左.Dra = value;
				this.X0Y0_ヴィオラ_丸金具左.Hit = false;
				this.X0Y1_ヴィオラ_丸金具左.Hit = false;
				this.X0Y2_ヴィオラ_丸金具左.Hit = false;
				this.X0Y3_ヴィオラ_丸金具左.Hit = false;
				this.X0Y4_ヴィオラ_丸金具左.Hit = false;
			}
		}

		public bool ヴィオラ_丸金具右_表示
		{
			get
			{
				return this.X0Y0_ヴィオラ_丸金具右.Dra;
			}
			set
			{
				this.X0Y0_ヴィオラ_丸金具右.Dra = value;
				this.X0Y1_ヴィオラ_丸金具右.Dra = value;
				this.X0Y2_ヴィオラ_丸金具右.Dra = value;
				this.X0Y3_ヴィオラ_丸金具右.Dra = value;
				this.X0Y4_ヴィオラ_丸金具右.Dra = value;
				this.X0Y0_ヴィオラ_丸金具右.Hit = false;
				this.X0Y1_ヴィオラ_丸金具右.Hit = false;
				this.X0Y2_ヴィオラ_丸金具右.Hit = false;
				this.X0Y3_ヴィオラ_丸金具右.Hit = false;
				this.X0Y4_ヴィオラ_丸金具右.Hit = false;
			}
		}

		public bool ヴィオラ_金具左_金具1_表示
		{
			get
			{
				return this.X0Y0_ヴィオラ_金具左_金具1.Dra;
			}
			set
			{
				this.X0Y0_ヴィオラ_金具左_金具1.Dra = value;
				this.X0Y1_ヴィオラ_金具左_金具1.Dra = value;
				this.X0Y2_ヴィオラ_金具左_金具1.Dra = value;
				this.X0Y3_ヴィオラ_金具左_金具1.Dra = value;
				this.X0Y4_ヴィオラ_金具左_金具1.Dra = value;
				this.X0Y0_ヴィオラ_金具左_金具1.Hit = false;
				this.X0Y1_ヴィオラ_金具左_金具1.Hit = false;
				this.X0Y2_ヴィオラ_金具左_金具1.Hit = false;
				this.X0Y3_ヴィオラ_金具左_金具1.Hit = false;
				this.X0Y4_ヴィオラ_金具左_金具1.Hit = false;
			}
		}

		public bool ヴィオラ_金具左_金具2_表示
		{
			get
			{
				return this.X0Y0_ヴィオラ_金具左_金具2.Dra;
			}
			set
			{
				this.X0Y0_ヴィオラ_金具左_金具2.Dra = value;
				this.X0Y1_ヴィオラ_金具左_金具2.Dra = value;
				this.X0Y2_ヴィオラ_金具左_金具2.Dra = value;
				this.X0Y3_ヴィオラ_金具左_金具2.Dra = value;
				this.X0Y4_ヴィオラ_金具左_金具2.Dra = value;
				this.X0Y0_ヴィオラ_金具左_金具2.Hit = false;
				this.X0Y1_ヴィオラ_金具左_金具2.Hit = false;
				this.X0Y2_ヴィオラ_金具左_金具2.Hit = false;
				this.X0Y3_ヴィオラ_金具左_金具2.Hit = false;
				this.X0Y4_ヴィオラ_金具左_金具2.Hit = false;
			}
		}

		public bool ヴィオラ_金具右_金具1_表示
		{
			get
			{
				return this.X0Y0_ヴィオラ_金具右_金具1.Dra;
			}
			set
			{
				this.X0Y0_ヴィオラ_金具右_金具1.Dra = value;
				this.X0Y1_ヴィオラ_金具右_金具1.Dra = value;
				this.X0Y2_ヴィオラ_金具右_金具1.Dra = value;
				this.X0Y3_ヴィオラ_金具右_金具1.Dra = value;
				this.X0Y4_ヴィオラ_金具右_金具1.Dra = value;
				this.X0Y0_ヴィオラ_金具右_金具1.Hit = false;
				this.X0Y1_ヴィオラ_金具右_金具1.Hit = false;
				this.X0Y2_ヴィオラ_金具右_金具1.Hit = false;
				this.X0Y3_ヴィオラ_金具右_金具1.Hit = false;
				this.X0Y4_ヴィオラ_金具右_金具1.Hit = false;
			}
		}

		public bool ヴィオラ_金具右_金具2_表示
		{
			get
			{
				return this.X0Y0_ヴィオラ_金具右_金具2.Dra;
			}
			set
			{
				this.X0Y0_ヴィオラ_金具右_金具2.Dra = value;
				this.X0Y1_ヴィオラ_金具右_金具2.Dra = value;
				this.X0Y2_ヴィオラ_金具右_金具2.Dra = value;
				this.X0Y3_ヴィオラ_金具右_金具2.Dra = value;
				this.X0Y4_ヴィオラ_金具右_金具2.Dra = value;
				this.X0Y0_ヴィオラ_金具右_金具2.Hit = false;
				this.X0Y1_ヴィオラ_金具右_金具2.Hit = false;
				this.X0Y2_ヴィオラ_金具右_金具2.Hit = false;
				this.X0Y3_ヴィオラ_金具右_金具2.Hit = false;
				this.X0Y4_ヴィオラ_金具右_金具2.Hit = false;
			}
		}

		public bool 染み_染み2_表示
		{
			get
			{
				return this.X0Y0_染み_染み2.Dra;
			}
			set
			{
				this.X0Y0_染み_染み2.Dra = value;
				this.X0Y1_染み_染み2.Dra = value;
				this.X0Y2_染み_染み2.Dra = value;
				this.X0Y3_染み_染み2.Dra = value;
				this.X0Y4_染み_染み2.Dra = value;
				this.X0Y0_染み_染み2.Hit = false;
				this.X0Y1_染み_染み2.Hit = false;
				this.X0Y2_染み_染み2.Hit = false;
				this.X0Y3_染み_染み2.Hit = false;
				this.X0Y4_染み_染み2.Hit = false;
			}
		}

		public bool 染み_染み1_表示
		{
			get
			{
				return this.X0Y0_染み_染み1.Dra;
			}
			set
			{
				this.X0Y0_染み_染み1.Dra = value;
				this.X0Y1_染み_染み1.Dra = value;
				this.X0Y2_染み_染み1.Dra = value;
				this.X0Y3_染み_染み1.Dra = value;
				this.X0Y4_染み_染み1.Dra = value;
				this.X0Y0_染み_染み1.Hit = false;
				this.X0Y1_染み_染み1.Hit = false;
				this.X0Y2_染み_染み1.Hit = false;
				this.X0Y3_染み_染み1.Hit = false;
				this.X0Y4_染み_染み1.Hit = false;
			}
		}

		public bool ベ\u30FCス表示
		{
			get
			{
				return this.紐左_表示;
			}
			set
			{
				this.紐左_表示 = value;
				this.紐右_表示 = value;
				this.下地_表示 = value;
				this.線_表示 = value;
			}
		}

		public bool 紐輪表示
		{
			get
			{
				return this.結び紐左_輪1_紐後_表示;
			}
			set
			{
				this.結び紐左_輪1_紐後_表示 = value;
				this.結び紐左_輪1_紐前_表示 = value;
				this.結び紐左_輪2_紐後_表示 = value;
				this.結び紐左_輪2_紐前_表示 = value;
				this.結び紐左_結び目_表示 = value;
				this.結び紐右_輪1_紐後_表示 = value;
				this.結び紐右_輪1_紐前_表示 = value;
				this.結び紐右_輪2_紐後_表示 = value;
				this.結び紐右_輪2_紐前_表示 = value;
				this.結び紐右_結び目_表示 = value;
			}
		}

		public bool 紐表示
		{
			get
			{
				return this.結び紐左_紐1_表示;
			}
			set
			{
				this.結び紐左_紐1_表示 = value;
				this.結び紐左_紐2_表示 = value;
				this.結び紐右_紐1_表示 = value;
				this.結び紐右_紐2_表示 = value;
			}
		}

		public bool 縁1表示
		{
			get
			{
				return this.ライン_ライン上_表示;
			}
			set
			{
				this.ライン_ライン上_表示 = value;
			}
		}

		public bool 縁2表示
		{
			get
			{
				return this.ライン_ライン左_表示;
			}
			set
			{
				this.ライン_ライン左_表示 = value;
				this.ライン_ライン右_表示 = value;
			}
		}

		public bool 縁3表示
		{
			get
			{
				return this.ライン_ライン左下_表示;
			}
			set
			{
				this.ライン_ライン左下_表示 = value;
				this.ライン_ライン右下_表示 = value;
			}
		}

		public bool 縁4表示
		{
			get
			{
				return this.ライン_ライン下左_表示;
			}
			set
			{
				this.ライン_ライン下左_表示 = value;
				this.ライン_ライン下右_表示 = value;
			}
		}

		public bool ヴィオラ表示
		{
			get
			{
				return this.ヴィオラ_紐左_表示;
			}
			set
			{
				this.ヴィオラ_紐左_表示 = value;
				this.ヴィオラ_紐右_表示 = value;
				this.ヴィオラ_丸金具左_表示 = value;
				this.ヴィオラ_丸金具右_表示 = value;
				this.ヴィオラ_金具左_金具1_表示 = value;
				this.ヴィオラ_金具左_金具2_表示 = value;
				this.ヴィオラ_金具右_金具1_表示 = value;
				this.ヴィオラ_金具右_金具2_表示 = value;
			}
		}

		public bool 染み表示
		{
			get
			{
				return this.染み_染み2_表示;
			}
			set
			{
				this.染み_染み2_表示 = value;
				this.染み_染み1_表示 = value;
			}
		}

		public double 染み濃度
		{
			get
			{
				return this.染み_染み2CD.不透明度;
			}
			set
			{
				this.染み_染み2CD.不透明度 = value;
				this.染み_染み1CD.不透明度 = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.紐左_表示;
			}
			set
			{
				this.紐左_表示 = value;
				this.紐右_表示 = value;
				this.下地_表示 = value;
				this.線_表示 = value;
				this.ライン_ライン上_表示 = value;
				this.ライン_ライン左_表示 = value;
				this.ライン_ライン右_表示 = value;
				this.ライン_ライン左下_表示 = value;
				this.ライン_ライン右下_表示 = value;
				this.ライン_ライン下左_表示 = value;
				this.ライン_ライン下右_表示 = value;
				this.結び紐左_紐1_表示 = value;
				this.結び紐左_紐2_表示 = value;
				this.結び紐左_輪1_紐後_表示 = value;
				this.結び紐左_輪1_紐前_表示 = value;
				this.結び紐左_輪2_紐後_表示 = value;
				this.結び紐左_輪2_紐前_表示 = value;
				this.結び紐左_結び目_表示 = value;
				this.結び紐右_紐1_表示 = value;
				this.結び紐右_紐2_表示 = value;
				this.結び紐右_輪1_紐後_表示 = value;
				this.結び紐右_輪1_紐前_表示 = value;
				this.結び紐右_輪2_紐後_表示 = value;
				this.結び紐右_輪2_紐前_表示 = value;
				this.結び紐右_結び目_表示 = value;
				this.ヴィオラ_紐左_表示 = value;
				this.ヴィオラ_紐右_表示 = value;
				this.ヴィオラ_丸金具左_表示 = value;
				this.ヴィオラ_丸金具右_表示 = value;
				this.ヴィオラ_金具左_金具1_表示 = value;
				this.ヴィオラ_金具左_金具2_表示 = value;
				this.ヴィオラ_金具右_金具1_表示 = value;
				this.ヴィオラ_金具右_金具2_表示 = value;
				this.染み_染み2_表示 = value;
				this.染み_染み1_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.紐左CD.不透明度;
			}
			set
			{
				this.紐左CD.不透明度 = value;
				this.紐右CD.不透明度 = value;
				this.下地CD.不透明度 = value;
				this.線CD.不透明度 = value;
				this.ライン_ライン上CD.不透明度 = value;
				this.ライン_ライン左CD.不透明度 = value;
				this.ライン_ライン右CD.不透明度 = value;
				this.ライン_ライン左下CD.不透明度 = value;
				this.ライン_ライン右下CD.不透明度 = value;
				this.ライン_ライン下左CD.不透明度 = value;
				this.ライン_ライン下右CD.不透明度 = value;
				this.結び紐左_紐1CD.不透明度 = value;
				this.結び紐左_紐2CD.不透明度 = value;
				this.結び紐左_輪1_紐後CD.不透明度 = value;
				this.結び紐左_輪1_紐前CD.不透明度 = value;
				this.結び紐左_輪2_紐後CD.不透明度 = value;
				this.結び紐左_輪2_紐前CD.不透明度 = value;
				this.結び紐左_結び目CD.不透明度 = value;
				this.結び紐右_紐1CD.不透明度 = value;
				this.結び紐右_紐2CD.不透明度 = value;
				this.結び紐右_輪1_紐後CD.不透明度 = value;
				this.結び紐右_輪1_紐前CD.不透明度 = value;
				this.結び紐右_輪2_紐後CD.不透明度 = value;
				this.結び紐右_輪2_紐前CD.不透明度 = value;
				this.結び紐右_結び目CD.不透明度 = value;
				this.ヴィオラ_紐左CD.不透明度 = value;
				this.ヴィオラ_紐右CD.不透明度 = value;
				this.ヴィオラ_丸金具左CD.不透明度 = value;
				this.ヴィオラ_丸金具右CD.不透明度 = value;
				this.ヴィオラ_金具左_金具1CD.不透明度 = value;
				this.ヴィオラ_金具左_金具2CD.不透明度 = value;
				this.ヴィオラ_金具右_金具1CD.不透明度 = value;
				this.ヴィオラ_金具右_金具2CD.不透明度 = value;
				this.染み_染み2CD.不透明度 = value;
				this.染み_染み1CD.不透明度 = value;
			}
		}

		public override void 描画0(Are Are)
		{
			switch (this.本体.IndexY)
			{
			case 0:
				Are.Draw(this.X0Y0_紐左);
				Are.Draw(this.X0Y0_紐右);
				return;
			case 1:
				Are.Draw(this.X0Y1_紐左);
				Are.Draw(this.X0Y1_紐右);
				return;
			case 2:
				Are.Draw(this.X0Y2_紐左);
				Are.Draw(this.X0Y2_紐右);
				return;
			case 3:
				Are.Draw(this.X0Y3_紐左);
				Are.Draw(this.X0Y3_紐右);
				return;
			default:
				Are.Draw(this.X0Y4_紐左);
				Are.Draw(this.X0Y4_紐右);
				return;
			}
		}

		public override void 描画1(Are Are)
		{
			switch (this.本体.IndexY)
			{
			case 0:
				Are.Draw(this.X0Y0_下地);
				Are.Draw(this.X0Y0_線);
				Are.Draw(this.X0Y0_ライン_ライン上);
				Are.Draw(this.X0Y0_ライン_ライン左);
				Are.Draw(this.X0Y0_ライン_ライン右);
				Are.Draw(this.X0Y0_ライン_ライン左下);
				Are.Draw(this.X0Y0_ライン_ライン右下);
				Are.Draw(this.X0Y0_ライン_ライン下左);
				Are.Draw(this.X0Y0_ライン_ライン下右);
				Are.Draw(this.X0Y0_結び紐左_紐1);
				Are.Draw(this.X0Y0_結び紐左_紐2);
				Are.Draw(this.X0Y0_結び紐左_輪1_紐後);
				Are.Draw(this.X0Y0_結び紐左_輪1_紐前);
				Are.Draw(this.X0Y0_結び紐左_輪2_紐後);
				Are.Draw(this.X0Y0_結び紐左_輪2_紐前);
				Are.Draw(this.X0Y0_結び紐左_結び目);
				Are.Draw(this.X0Y0_結び紐右_紐1);
				Are.Draw(this.X0Y0_結び紐右_紐2);
				Are.Draw(this.X0Y0_結び紐右_輪1_紐後);
				Are.Draw(this.X0Y0_結び紐右_輪1_紐前);
				Are.Draw(this.X0Y0_結び紐右_輪2_紐後);
				Are.Draw(this.X0Y0_結び紐右_輪2_紐前);
				Are.Draw(this.X0Y0_結び紐右_結び目);
				Are.Draw(this.X0Y0_ヴィオラ_紐左);
				Are.Draw(this.X0Y0_ヴィオラ_紐右);
				Are.Draw(this.X0Y0_ヴィオラ_丸金具左);
				Are.Draw(this.X0Y0_ヴィオラ_丸金具右);
				Are.Draw(this.X0Y0_ヴィオラ_金具左_金具1);
				Are.Draw(this.X0Y0_ヴィオラ_金具左_金具2);
				Are.Draw(this.X0Y0_ヴィオラ_金具右_金具1);
				Are.Draw(this.X0Y0_ヴィオラ_金具右_金具2);
				Are.Draw(this.X0Y0_染み_染み2);
				Are.Draw(this.X0Y0_染み_染み1);
				return;
			case 1:
				Are.Draw(this.X0Y1_下地);
				Are.Draw(this.X0Y1_線);
				Are.Draw(this.X0Y1_ライン_ライン上);
				Are.Draw(this.X0Y1_ライン_ライン左);
				Are.Draw(this.X0Y1_ライン_ライン右);
				Are.Draw(this.X0Y1_ライン_ライン左下);
				Are.Draw(this.X0Y1_ライン_ライン右下);
				Are.Draw(this.X0Y1_ライン_ライン下左);
				Are.Draw(this.X0Y1_ライン_ライン下右);
				Are.Draw(this.X0Y1_結び紐左_紐1);
				Are.Draw(this.X0Y1_結び紐左_紐2);
				Are.Draw(this.X0Y1_結び紐左_輪1_紐後);
				Are.Draw(this.X0Y1_結び紐左_輪1_紐前);
				Are.Draw(this.X0Y1_結び紐左_輪2_紐後);
				Are.Draw(this.X0Y1_結び紐左_輪2_紐前);
				Are.Draw(this.X0Y1_結び紐左_結び目);
				Are.Draw(this.X0Y1_結び紐右_紐1);
				Are.Draw(this.X0Y1_結び紐右_紐2);
				Are.Draw(this.X0Y1_結び紐右_輪1_紐後);
				Are.Draw(this.X0Y1_結び紐右_輪1_紐前);
				Are.Draw(this.X0Y1_結び紐右_輪2_紐後);
				Are.Draw(this.X0Y1_結び紐右_輪2_紐前);
				Are.Draw(this.X0Y1_結び紐右_結び目);
				Are.Draw(this.X0Y1_ヴィオラ_紐左);
				Are.Draw(this.X0Y1_ヴィオラ_紐右);
				Are.Draw(this.X0Y1_ヴィオラ_丸金具左);
				Are.Draw(this.X0Y1_ヴィオラ_丸金具右);
				Are.Draw(this.X0Y1_ヴィオラ_金具左_金具1);
				Are.Draw(this.X0Y1_ヴィオラ_金具左_金具2);
				Are.Draw(this.X0Y1_ヴィオラ_金具右_金具1);
				Are.Draw(this.X0Y1_ヴィオラ_金具右_金具2);
				Are.Draw(this.X0Y1_染み_染み2);
				Are.Draw(this.X0Y1_染み_染み1);
				return;
			case 2:
				Are.Draw(this.X0Y2_下地);
				Are.Draw(this.X0Y2_線);
				Are.Draw(this.X0Y2_ライン_ライン上);
				Are.Draw(this.X0Y2_ライン_ライン左);
				Are.Draw(this.X0Y2_ライン_ライン右);
				Are.Draw(this.X0Y2_ライン_ライン左下);
				Are.Draw(this.X0Y2_ライン_ライン右下);
				Are.Draw(this.X0Y2_ライン_ライン下左);
				Are.Draw(this.X0Y2_ライン_ライン下右);
				Are.Draw(this.X0Y2_結び紐左_紐1);
				Are.Draw(this.X0Y2_結び紐左_紐2);
				Are.Draw(this.X0Y2_結び紐左_輪1_紐後);
				Are.Draw(this.X0Y2_結び紐左_輪1_紐前);
				Are.Draw(this.X0Y2_結び紐左_輪2_紐後);
				Are.Draw(this.X0Y2_結び紐左_輪2_紐前);
				Are.Draw(this.X0Y2_結び紐左_結び目);
				Are.Draw(this.X0Y2_結び紐右_紐1);
				Are.Draw(this.X0Y2_結び紐右_紐2);
				Are.Draw(this.X0Y2_結び紐右_輪1_紐後);
				Are.Draw(this.X0Y2_結び紐右_輪1_紐前);
				Are.Draw(this.X0Y2_結び紐右_輪2_紐後);
				Are.Draw(this.X0Y2_結び紐右_輪2_紐前);
				Are.Draw(this.X0Y2_結び紐右_結び目);
				Are.Draw(this.X0Y2_ヴィオラ_紐左);
				Are.Draw(this.X0Y2_ヴィオラ_紐右);
				Are.Draw(this.X0Y2_ヴィオラ_丸金具左);
				Are.Draw(this.X0Y2_ヴィオラ_丸金具右);
				Are.Draw(this.X0Y2_ヴィオラ_金具左_金具1);
				Are.Draw(this.X0Y2_ヴィオラ_金具左_金具2);
				Are.Draw(this.X0Y2_ヴィオラ_金具右_金具1);
				Are.Draw(this.X0Y2_ヴィオラ_金具右_金具2);
				Are.Draw(this.X0Y2_染み_染み2);
				Are.Draw(this.X0Y2_染み_染み1);
				return;
			case 3:
				Are.Draw(this.X0Y3_下地);
				Are.Draw(this.X0Y3_線);
				Are.Draw(this.X0Y3_ライン_ライン上);
				Are.Draw(this.X0Y3_ライン_ライン左);
				Are.Draw(this.X0Y3_ライン_ライン右);
				Are.Draw(this.X0Y3_ライン_ライン左下);
				Are.Draw(this.X0Y3_ライン_ライン右下);
				Are.Draw(this.X0Y3_ライン_ライン下左);
				Are.Draw(this.X0Y3_ライン_ライン下右);
				Are.Draw(this.X0Y3_結び紐左_紐1);
				Are.Draw(this.X0Y3_結び紐左_紐2);
				Are.Draw(this.X0Y3_結び紐左_輪1_紐後);
				Are.Draw(this.X0Y3_結び紐左_輪1_紐前);
				Are.Draw(this.X0Y3_結び紐左_輪2_紐後);
				Are.Draw(this.X0Y3_結び紐左_輪2_紐前);
				Are.Draw(this.X0Y3_結び紐左_結び目);
				Are.Draw(this.X0Y3_結び紐右_紐1);
				Are.Draw(this.X0Y3_結び紐右_紐2);
				Are.Draw(this.X0Y3_結び紐右_輪1_紐後);
				Are.Draw(this.X0Y3_結び紐右_輪1_紐前);
				Are.Draw(this.X0Y3_結び紐右_輪2_紐後);
				Are.Draw(this.X0Y3_結び紐右_輪2_紐前);
				Are.Draw(this.X0Y3_結び紐右_結び目);
				Are.Draw(this.X0Y3_ヴィオラ_紐左);
				Are.Draw(this.X0Y3_ヴィオラ_紐右);
				Are.Draw(this.X0Y3_ヴィオラ_丸金具左);
				Are.Draw(this.X0Y3_ヴィオラ_丸金具右);
				Are.Draw(this.X0Y3_ヴィオラ_金具左_金具1);
				Are.Draw(this.X0Y3_ヴィオラ_金具左_金具2);
				Are.Draw(this.X0Y3_ヴィオラ_金具右_金具1);
				Are.Draw(this.X0Y3_ヴィオラ_金具右_金具2);
				Are.Draw(this.X0Y3_染み_染み2);
				Are.Draw(this.X0Y3_染み_染み1);
				return;
			default:
				Are.Draw(this.X0Y4_下地);
				Are.Draw(this.X0Y4_線);
				Are.Draw(this.X0Y4_ライン_ライン上);
				Are.Draw(this.X0Y4_ライン_ライン左);
				Are.Draw(this.X0Y4_ライン_ライン右);
				Are.Draw(this.X0Y4_ライン_ライン左下);
				Are.Draw(this.X0Y4_ライン_ライン右下);
				Are.Draw(this.X0Y4_ライン_ライン下左);
				Are.Draw(this.X0Y4_ライン_ライン下右);
				Are.Draw(this.X0Y4_結び紐左_紐1);
				Are.Draw(this.X0Y4_結び紐左_紐2);
				Are.Draw(this.X0Y4_結び紐左_輪1_紐後);
				Are.Draw(this.X0Y4_結び紐左_輪1_紐前);
				Are.Draw(this.X0Y4_結び紐左_輪2_紐後);
				Are.Draw(this.X0Y4_結び紐左_輪2_紐前);
				Are.Draw(this.X0Y4_結び紐左_結び目);
				Are.Draw(this.X0Y4_結び紐右_紐1);
				Are.Draw(this.X0Y4_結び紐右_紐2);
				Are.Draw(this.X0Y4_結び紐右_輪1_紐後);
				Are.Draw(this.X0Y4_結び紐右_輪1_紐前);
				Are.Draw(this.X0Y4_結び紐右_輪2_紐後);
				Are.Draw(this.X0Y4_結び紐右_輪2_紐前);
				Are.Draw(this.X0Y4_結び紐右_結び目);
				Are.Draw(this.X0Y4_ヴィオラ_紐左);
				Are.Draw(this.X0Y4_ヴィオラ_紐右);
				Are.Draw(this.X0Y4_ヴィオラ_丸金具左);
				Are.Draw(this.X0Y4_ヴィオラ_丸金具右);
				Are.Draw(this.X0Y4_ヴィオラ_金具左_金具1);
				Are.Draw(this.X0Y4_ヴィオラ_金具左_金具2);
				Are.Draw(this.X0Y4_ヴィオラ_金具右_金具1);
				Are.Draw(this.X0Y4_ヴィオラ_金具右_金具2);
				Are.Draw(this.X0Y4_染み_染み2);
				Are.Draw(this.X0Y4_染み_染み1);
				return;
			}
		}

		public override bool Is布(Par p)
		{
			return p == this.X0Y0_紐左 || p == this.X0Y0_紐右 || p == this.X0Y0_下地 || p == this.X0Y0_線 || p == this.X0Y0_ライン_ライン上 || p == this.X0Y0_ライン_ライン左 || p == this.X0Y0_ライン_ライン右 || p == this.X0Y0_ライン_ライン左下 || p == this.X0Y0_ライン_ライン右下 || p == this.X0Y0_ライン_ライン下左 || p == this.X0Y0_ライン_ライン下右 || p == this.X0Y0_結び紐左_紐1 || p == this.X0Y0_結び紐左_紐2 || p == this.X0Y0_結び紐左_輪1_紐後 || p == this.X0Y0_結び紐左_輪1_紐前 || p == this.X0Y0_結び紐左_輪2_紐後 || p == this.X0Y0_結び紐左_輪2_紐前 || p == this.X0Y0_結び紐左_結び目 || p == this.X0Y0_結び紐右_紐1 || p == this.X0Y0_結び紐右_紐2 || p == this.X0Y0_結び紐右_輪1_紐後 || p == this.X0Y0_結び紐右_輪1_紐前 || p == this.X0Y0_結び紐右_輪2_紐後 || p == this.X0Y0_結び紐右_輪2_紐前 || p == this.X0Y0_結び紐右_結び目 || p == this.X0Y0_ヴィオラ_紐左 || p == this.X0Y0_ヴィオラ_紐右 || p == this.X0Y0_ヴィオラ_丸金具左 || p == this.X0Y0_ヴィオラ_丸金具右 || p == this.X0Y0_ヴィオラ_金具左_金具1 || p == this.X0Y0_ヴィオラ_金具左_金具2 || p == this.X0Y0_ヴィオラ_金具右_金具1 || p == this.X0Y0_ヴィオラ_金具右_金具2 || p == this.X0Y0_染み_染み2 || p == this.X0Y0_染み_染み1 || p == this.X0Y1_紐左 || p == this.X0Y1_紐右 || p == this.X0Y1_下地 || p == this.X0Y1_線 || p == this.X0Y1_ライン_ライン上 || p == this.X0Y1_ライン_ライン左 || p == this.X0Y1_ライン_ライン右 || p == this.X0Y1_ライン_ライン左下 || p == this.X0Y1_ライン_ライン右下 || p == this.X0Y1_ライン_ライン下左 || p == this.X0Y1_ライン_ライン下右 || p == this.X0Y1_結び紐左_紐1 || p == this.X0Y1_結び紐左_紐2 || p == this.X0Y1_結び紐左_輪1_紐後 || p == this.X0Y1_結び紐左_輪1_紐前 || p == this.X0Y1_結び紐左_輪2_紐後 || p == this.X0Y1_結び紐左_輪2_紐前 || p == this.X0Y1_結び紐左_結び目 || p == this.X0Y1_結び紐右_紐1 || p == this.X0Y1_結び紐右_紐2 || p == this.X0Y1_結び紐右_輪1_紐後 || p == this.X0Y1_結び紐右_輪1_紐前 || p == this.X0Y1_結び紐右_輪2_紐後 || p == this.X0Y1_結び紐右_輪2_紐前 || p == this.X0Y1_結び紐右_結び目 || p == this.X0Y1_ヴィオラ_紐左 || p == this.X0Y1_ヴィオラ_紐右 || p == this.X0Y1_ヴィオラ_丸金具左 || p == this.X0Y1_ヴィオラ_丸金具右 || p == this.X0Y1_ヴィオラ_金具左_金具1 || p == this.X0Y1_ヴィオラ_金具左_金具2 || p == this.X0Y1_ヴィオラ_金具右_金具1 || p == this.X0Y1_ヴィオラ_金具右_金具2 || p == this.X0Y1_染み_染み2 || p == this.X0Y1_染み_染み1 || p == this.X0Y2_紐左 || p == this.X0Y2_紐右 || p == this.X0Y2_下地 || p == this.X0Y2_線 || p == this.X0Y2_ライン_ライン上 || p == this.X0Y2_ライン_ライン左 || p == this.X0Y2_ライン_ライン右 || p == this.X0Y2_ライン_ライン左下 || p == this.X0Y2_ライン_ライン右下 || p == this.X0Y2_ライン_ライン下左 || p == this.X0Y2_ライン_ライン下右 || p == this.X0Y2_結び紐左_紐1 || p == this.X0Y2_結び紐左_紐2 || p == this.X0Y2_結び紐左_輪1_紐後 || p == this.X0Y2_結び紐左_輪1_紐前 || p == this.X0Y2_結び紐左_輪2_紐後 || p == this.X0Y2_結び紐左_輪2_紐前 || p == this.X0Y2_結び紐左_結び目 || p == this.X0Y2_結び紐右_紐1 || p == this.X0Y2_結び紐右_紐2 || p == this.X0Y2_結び紐右_輪1_紐後 || p == this.X0Y2_結び紐右_輪1_紐前 || p == this.X0Y2_結び紐右_輪2_紐後 || p == this.X0Y2_結び紐右_輪2_紐前 || p == this.X0Y2_結び紐右_結び目 || p == this.X0Y2_ヴィオラ_紐左 || p == this.X0Y2_ヴィオラ_紐右 || p == this.X0Y2_ヴィオラ_丸金具左 || p == this.X0Y2_ヴィオラ_丸金具右 || p == this.X0Y2_ヴィオラ_金具左_金具1 || p == this.X0Y2_ヴィオラ_金具左_金具2 || p == this.X0Y2_ヴィオラ_金具右_金具1 || p == this.X0Y2_ヴィオラ_金具右_金具2 || p == this.X0Y2_染み_染み2 || p == this.X0Y2_染み_染み1 || p == this.X0Y3_紐左 || p == this.X0Y3_紐右 || p == this.X0Y3_下地 || p == this.X0Y3_線 || p == this.X0Y3_ライン_ライン上 || p == this.X0Y3_ライン_ライン左 || p == this.X0Y3_ライン_ライン右 || p == this.X0Y3_ライン_ライン左下 || p == this.X0Y3_ライン_ライン右下 || p == this.X0Y3_ライン_ライン下左 || p == this.X0Y3_ライン_ライン下右 || p == this.X0Y3_結び紐左_紐1 || p == this.X0Y3_結び紐左_紐2 || p == this.X0Y3_結び紐左_輪1_紐後 || p == this.X0Y3_結び紐左_輪1_紐前 || p == this.X0Y3_結び紐左_輪2_紐後 || p == this.X0Y3_結び紐左_輪2_紐前 || p == this.X0Y3_結び紐左_結び目 || p == this.X0Y3_結び紐右_紐1 || p == this.X0Y3_結び紐右_紐2 || p == this.X0Y3_結び紐右_輪1_紐後 || p == this.X0Y3_結び紐右_輪1_紐前 || p == this.X0Y3_結び紐右_輪2_紐後 || p == this.X0Y3_結び紐右_輪2_紐前 || p == this.X0Y3_結び紐右_結び目 || p == this.X0Y3_ヴィオラ_紐左 || p == this.X0Y3_ヴィオラ_紐右 || p == this.X0Y3_ヴィオラ_丸金具左 || p == this.X0Y3_ヴィオラ_丸金具右 || p == this.X0Y3_ヴィオラ_金具左_金具1 || p == this.X0Y3_ヴィオラ_金具左_金具2 || p == this.X0Y3_ヴィオラ_金具右_金具1 || p == this.X0Y3_ヴィオラ_金具右_金具2 || p == this.X0Y3_染み_染み2 || p == this.X0Y3_染み_染み1 || p == this.X0Y4_紐左 || p == this.X0Y4_紐右 || p == this.X0Y4_下地 || p == this.X0Y4_線 || p == this.X0Y4_ライン_ライン上 || p == this.X0Y4_ライン_ライン左 || p == this.X0Y4_ライン_ライン右 || p == this.X0Y4_ライン_ライン左下 || p == this.X0Y4_ライン_ライン右下 || p == this.X0Y4_ライン_ライン下左 || p == this.X0Y4_ライン_ライン下右 || p == this.X0Y4_結び紐左_紐1 || p == this.X0Y4_結び紐左_紐2 || p == this.X0Y4_結び紐左_輪1_紐後 || p == this.X0Y4_結び紐左_輪1_紐前 || p == this.X0Y4_結び紐左_輪2_紐後 || p == this.X0Y4_結び紐左_輪2_紐前 || p == this.X0Y4_結び紐左_結び目 || p == this.X0Y4_結び紐右_紐1 || p == this.X0Y4_結び紐右_紐2 || p == this.X0Y4_結び紐右_輪1_紐後 || p == this.X0Y4_結び紐右_輪1_紐前 || p == this.X0Y4_結び紐右_輪2_紐後 || p == this.X0Y4_結び紐右_輪2_紐前 || p == this.X0Y4_結び紐右_結び目 || p == this.X0Y4_ヴィオラ_紐左 || p == this.X0Y4_ヴィオラ_紐右 || p == this.X0Y4_ヴィオラ_丸金具左 || p == this.X0Y4_ヴィオラ_丸金具右 || p == this.X0Y4_ヴィオラ_金具左_金具1 || p == this.X0Y4_ヴィオラ_金具左_金具2 || p == this.X0Y4_ヴィオラ_金具右_金具1 || p == this.X0Y4_ヴィオラ_金具右_金具2 || p == this.X0Y4_染み_染み2 || p == this.X0Y4_染み_染み1;
		}

		public override void 色更新()
		{
			switch (this.本体.IndexY)
			{
			case 0:
				this.X0Y0_紐左CP.Update();
				this.X0Y0_紐右CP.Update();
				this.X0Y0_下地CP.Update();
				this.X0Y0_線CP.Update();
				this.X0Y0_ライン_ライン上CP.Update();
				this.X0Y0_ライン_ライン左CP.Update();
				this.X0Y0_ライン_ライン右CP.Update();
				this.X0Y0_ライン_ライン左下CP.Update();
				this.X0Y0_ライン_ライン右下CP.Update();
				this.X0Y0_ライン_ライン下左CP.Update();
				this.X0Y0_ライン_ライン下右CP.Update();
				this.X0Y0_結び紐左_紐1CP.Update();
				this.X0Y0_結び紐左_紐2CP.Update();
				this.X0Y0_結び紐左_輪1_紐後CP.Update();
				this.X0Y0_結び紐左_輪1_紐前CP.Update();
				this.X0Y0_結び紐左_輪2_紐後CP.Update();
				this.X0Y0_結び紐左_輪2_紐前CP.Update();
				this.X0Y0_結び紐左_結び目CP.Update();
				this.X0Y0_結び紐右_紐1CP.Update();
				this.X0Y0_結び紐右_紐2CP.Update();
				this.X0Y0_結び紐右_輪1_紐後CP.Update();
				this.X0Y0_結び紐右_輪1_紐前CP.Update();
				this.X0Y0_結び紐右_輪2_紐後CP.Update();
				this.X0Y0_結び紐右_輪2_紐前CP.Update();
				this.X0Y0_結び紐右_結び目CP.Update();
				this.X0Y0_ヴィオラ_紐左CP.Update();
				this.X0Y0_ヴィオラ_紐右CP.Update();
				this.X0Y0_ヴィオラ_丸金具左CP.Update();
				this.X0Y0_ヴィオラ_丸金具右CP.Update();
				this.X0Y0_ヴィオラ_金具左_金具1CP.Update();
				this.X0Y0_ヴィオラ_金具左_金具2CP.Update();
				this.X0Y0_ヴィオラ_金具右_金具1CP.Update();
				this.X0Y0_ヴィオラ_金具右_金具2CP.Update();
				this.X0Y0_染み_染み2CP.Update();
				this.X0Y0_染み_染み1CP.Update();
				return;
			case 1:
				this.X0Y1_紐左CP.Update();
				this.X0Y1_紐右CP.Update();
				this.X0Y1_下地CP.Update();
				this.X0Y1_線CP.Update();
				this.X0Y1_ライン_ライン上CP.Update();
				this.X0Y1_ライン_ライン左CP.Update();
				this.X0Y1_ライン_ライン右CP.Update();
				this.X0Y1_ライン_ライン左下CP.Update();
				this.X0Y1_ライン_ライン右下CP.Update();
				this.X0Y1_ライン_ライン下左CP.Update();
				this.X0Y1_ライン_ライン下右CP.Update();
				this.X0Y1_結び紐左_紐1CP.Update();
				this.X0Y1_結び紐左_紐2CP.Update();
				this.X0Y1_結び紐左_輪1_紐後CP.Update();
				this.X0Y1_結び紐左_輪1_紐前CP.Update();
				this.X0Y1_結び紐左_輪2_紐後CP.Update();
				this.X0Y1_結び紐左_輪2_紐前CP.Update();
				this.X0Y1_結び紐左_結び目CP.Update();
				this.X0Y1_結び紐右_紐1CP.Update();
				this.X0Y1_結び紐右_紐2CP.Update();
				this.X0Y1_結び紐右_輪1_紐後CP.Update();
				this.X0Y1_結び紐右_輪1_紐前CP.Update();
				this.X0Y1_結び紐右_輪2_紐後CP.Update();
				this.X0Y1_結び紐右_輪2_紐前CP.Update();
				this.X0Y1_結び紐右_結び目CP.Update();
				this.X0Y1_ヴィオラ_紐左CP.Update();
				this.X0Y1_ヴィオラ_紐右CP.Update();
				this.X0Y1_ヴィオラ_丸金具左CP.Update();
				this.X0Y1_ヴィオラ_丸金具右CP.Update();
				this.X0Y1_ヴィオラ_金具左_金具1CP.Update();
				this.X0Y1_ヴィオラ_金具左_金具2CP.Update();
				this.X0Y1_ヴィオラ_金具右_金具1CP.Update();
				this.X0Y1_ヴィオラ_金具右_金具2CP.Update();
				this.X0Y1_染み_染み2CP.Update();
				this.X0Y1_染み_染み1CP.Update();
				return;
			case 2:
				this.X0Y2_紐左CP.Update();
				this.X0Y2_紐右CP.Update();
				this.X0Y2_下地CP.Update();
				this.X0Y2_線CP.Update();
				this.X0Y2_ライン_ライン上CP.Update();
				this.X0Y2_ライン_ライン左CP.Update();
				this.X0Y2_ライン_ライン右CP.Update();
				this.X0Y2_ライン_ライン左下CP.Update();
				this.X0Y2_ライン_ライン右下CP.Update();
				this.X0Y2_ライン_ライン下左CP.Update();
				this.X0Y2_ライン_ライン下右CP.Update();
				this.X0Y2_結び紐左_紐1CP.Update();
				this.X0Y2_結び紐左_紐2CP.Update();
				this.X0Y2_結び紐左_輪1_紐後CP.Update();
				this.X0Y2_結び紐左_輪1_紐前CP.Update();
				this.X0Y2_結び紐左_輪2_紐後CP.Update();
				this.X0Y2_結び紐左_輪2_紐前CP.Update();
				this.X0Y2_結び紐左_結び目CP.Update();
				this.X0Y2_結び紐右_紐1CP.Update();
				this.X0Y2_結び紐右_紐2CP.Update();
				this.X0Y2_結び紐右_輪1_紐後CP.Update();
				this.X0Y2_結び紐右_輪1_紐前CP.Update();
				this.X0Y2_結び紐右_輪2_紐後CP.Update();
				this.X0Y2_結び紐右_輪2_紐前CP.Update();
				this.X0Y2_結び紐右_結び目CP.Update();
				this.X0Y2_ヴィオラ_紐左CP.Update();
				this.X0Y2_ヴィオラ_紐右CP.Update();
				this.X0Y2_ヴィオラ_丸金具左CP.Update();
				this.X0Y2_ヴィオラ_丸金具右CP.Update();
				this.X0Y2_ヴィオラ_金具左_金具1CP.Update();
				this.X0Y2_ヴィオラ_金具左_金具2CP.Update();
				this.X0Y2_ヴィオラ_金具右_金具1CP.Update();
				this.X0Y2_ヴィオラ_金具右_金具2CP.Update();
				this.X0Y2_染み_染み2CP.Update();
				this.X0Y2_染み_染み1CP.Update();
				return;
			case 3:
				this.X0Y3_紐左CP.Update();
				this.X0Y3_紐右CP.Update();
				this.X0Y3_下地CP.Update();
				this.X0Y3_線CP.Update();
				this.X0Y3_ライン_ライン上CP.Update();
				this.X0Y3_ライン_ライン左CP.Update();
				this.X0Y3_ライン_ライン右CP.Update();
				this.X0Y3_ライン_ライン左下CP.Update();
				this.X0Y3_ライン_ライン右下CP.Update();
				this.X0Y3_ライン_ライン下左CP.Update();
				this.X0Y3_ライン_ライン下右CP.Update();
				this.X0Y3_結び紐左_紐1CP.Update();
				this.X0Y3_結び紐左_紐2CP.Update();
				this.X0Y3_結び紐左_輪1_紐後CP.Update();
				this.X0Y3_結び紐左_輪1_紐前CP.Update();
				this.X0Y3_結び紐左_輪2_紐後CP.Update();
				this.X0Y3_結び紐左_輪2_紐前CP.Update();
				this.X0Y3_結び紐左_結び目CP.Update();
				this.X0Y3_結び紐右_紐1CP.Update();
				this.X0Y3_結び紐右_紐2CP.Update();
				this.X0Y3_結び紐右_輪1_紐後CP.Update();
				this.X0Y3_結び紐右_輪1_紐前CP.Update();
				this.X0Y3_結び紐右_輪2_紐後CP.Update();
				this.X0Y3_結び紐右_輪2_紐前CP.Update();
				this.X0Y3_結び紐右_結び目CP.Update();
				this.X0Y3_ヴィオラ_紐左CP.Update();
				this.X0Y3_ヴィオラ_紐右CP.Update();
				this.X0Y3_ヴィオラ_丸金具左CP.Update();
				this.X0Y3_ヴィオラ_丸金具右CP.Update();
				this.X0Y3_ヴィオラ_金具左_金具1CP.Update();
				this.X0Y3_ヴィオラ_金具左_金具2CP.Update();
				this.X0Y3_ヴィオラ_金具右_金具1CP.Update();
				this.X0Y3_ヴィオラ_金具右_金具2CP.Update();
				this.X0Y3_染み_染み2CP.Update();
				this.X0Y3_染み_染み1CP.Update();
				return;
			default:
				this.X0Y4_紐左CP.Update();
				this.X0Y4_紐右CP.Update();
				this.X0Y4_下地CP.Update();
				this.X0Y4_線CP.Update();
				this.X0Y4_ライン_ライン上CP.Update();
				this.X0Y4_ライン_ライン左CP.Update();
				this.X0Y4_ライン_ライン右CP.Update();
				this.X0Y4_ライン_ライン左下CP.Update();
				this.X0Y4_ライン_ライン右下CP.Update();
				this.X0Y4_ライン_ライン下左CP.Update();
				this.X0Y4_ライン_ライン下右CP.Update();
				this.X0Y4_結び紐左_紐1CP.Update();
				this.X0Y4_結び紐左_紐2CP.Update();
				this.X0Y4_結び紐左_輪1_紐後CP.Update();
				this.X0Y4_結び紐左_輪1_紐前CP.Update();
				this.X0Y4_結び紐左_輪2_紐後CP.Update();
				this.X0Y4_結び紐左_輪2_紐前CP.Update();
				this.X0Y4_結び紐左_結び目CP.Update();
				this.X0Y4_結び紐右_紐1CP.Update();
				this.X0Y4_結び紐右_紐2CP.Update();
				this.X0Y4_結び紐右_輪1_紐後CP.Update();
				this.X0Y4_結び紐右_輪1_紐前CP.Update();
				this.X0Y4_結び紐右_輪2_紐後CP.Update();
				this.X0Y4_結び紐右_輪2_紐前CP.Update();
				this.X0Y4_結び紐右_結び目CP.Update();
				this.X0Y4_ヴィオラ_紐左CP.Update();
				this.X0Y4_ヴィオラ_紐右CP.Update();
				this.X0Y4_ヴィオラ_丸金具左CP.Update();
				this.X0Y4_ヴィオラ_丸金具右CP.Update();
				this.X0Y4_ヴィオラ_金具左_金具1CP.Update();
				this.X0Y4_ヴィオラ_金具左_金具2CP.Update();
				this.X0Y4_ヴィオラ_金具右_金具1CP.Update();
				this.X0Y4_ヴィオラ_金具右_金具2CP.Update();
				this.X0Y4_染み_染み2CP.Update();
				this.X0Y4_染み_染み1CP.Update();
				return;
			}
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.紐左CD = new ColorD();
			this.紐右CD = new ColorD();
			this.下地CD = new ColorD();
			this.線CD = new ColorD();
			this.ライン_ライン上CD = new ColorD();
			this.ライン_ライン左CD = new ColorD();
			this.ライン_ライン右CD = new ColorD();
			this.ライン_ライン左下CD = new ColorD();
			this.ライン_ライン右下CD = new ColorD();
			this.ライン_ライン下左CD = new ColorD();
			this.ライン_ライン下右CD = new ColorD();
			this.結び紐左_紐1CD = new ColorD();
			this.結び紐左_紐2CD = new ColorD();
			this.結び紐左_輪1_紐後CD = new ColorD();
			this.結び紐左_輪1_紐前CD = new ColorD();
			this.結び紐左_輪2_紐後CD = new ColorD();
			this.結び紐左_輪2_紐前CD = new ColorD();
			this.結び紐左_結び目CD = new ColorD();
			this.結び紐右_紐1CD = new ColorD();
			this.結び紐右_紐2CD = new ColorD();
			this.結び紐右_輪1_紐後CD = new ColorD();
			this.結び紐右_輪1_紐前CD = new ColorD();
			this.結び紐右_輪2_紐後CD = new ColorD();
			this.結び紐右_輪2_紐前CD = new ColorD();
			this.結び紐右_結び目CD = new ColorD();
			this.ヴィオラ_紐左CD = new ColorD();
			this.ヴィオラ_紐右CD = new ColorD();
			this.ヴィオラ_丸金具左CD = new ColorD();
			this.ヴィオラ_丸金具右CD = new ColorD();
			this.ヴィオラ_金具左_金具1CD = new ColorD();
			this.ヴィオラ_金具左_金具2CD = new ColorD();
			this.ヴィオラ_金具右_金具1CD = new ColorD();
			this.ヴィオラ_金具右_金具2CD = new ColorD();
			this.染み_染み2CD = new ColorD(ref Col.Empty, ref 体配色.染み);
			this.染み_染み1CD = new ColorD(ref Col.Empty, ref 体配色.染み);
		}

		public void 配色(マイクロB色 配色)
		{
			this.紐左CD.色 = 配色.紐色;
			this.紐右CD.色 = this.紐左CD.色;
			this.下地CD.色 = 配色.生地色;
			this.線CD.色 = Color2.Empty;
			this.X0Y0_線CP.Setting();
			this.X0Y1_線CP.Setting();
			this.X0Y2_線CP.Setting();
			this.X0Y3_線CP.Setting();
			this.X0Y4_線CP.Setting();
			this.ライン_ライン上CD.色 = 配色.縁色;
			this.ライン_ライン左CD.色 = this.ライン_ライン上CD.色;
			this.ライン_ライン右CD.色 = this.ライン_ライン上CD.色;
			this.ライン_ライン左下CD.色 = this.ライン_ライン上CD.色;
			this.ライン_ライン右下CD.色 = this.ライン_ライン上CD.色;
			this.ライン_ライン下左CD.色 = this.ライン_ライン上CD.色;
			this.ライン_ライン下右CD.色 = this.ライン_ライン上CD.色;
			this.結び紐左_紐1CD.色 = this.紐左CD.色;
			this.結び紐左_紐2CD.色 = this.紐左CD.色;
			this.結び紐左_輪1_紐後CD.色 = this.紐左CD.色;
			this.結び紐左_輪1_紐前CD.色 = this.紐左CD.色;
			this.結び紐左_輪2_紐後CD.色 = this.紐左CD.色;
			this.結び紐左_輪2_紐前CD.色 = this.紐左CD.色;
			this.結び紐左_結び目CD.色 = this.紐左CD.色;
			this.結び紐右_紐1CD.色 = this.紐左CD.色;
			this.結び紐右_紐2CD.色 = this.紐左CD.色;
			this.結び紐右_輪1_紐後CD.色 = this.紐左CD.色;
			this.結び紐右_輪1_紐前CD.色 = this.紐左CD.色;
			this.結び紐右_輪2_紐後CD.色 = this.紐左CD.色;
			this.結び紐右_輪2_紐前CD.色 = this.紐左CD.色;
			this.結び紐右_結び目CD.色 = this.紐左CD.色;
			this.ヴィオラ_紐左CD.色 = this.紐左CD.色;
			this.ヴィオラ_紐右CD.色 = this.紐左CD.色;
			this.ヴィオラ_丸金具左CD.色 = 配色.留色;
			this.ヴィオラ_丸金具右CD.色 = this.ヴィオラ_丸金具左CD.色;
			this.ヴィオラ_金具左_金具1CD.色 = this.ヴィオラ_丸金具左CD.色;
			this.ヴィオラ_金具左_金具2CD.色 = this.ヴィオラ_丸金具左CD.色;
			this.ヴィオラ_金具右_金具1CD.色 = this.ヴィオラ_丸金具左CD.色;
			this.ヴィオラ_金具右_金具2CD.色 = this.ヴィオラ_丸金具左CD.色;
		}

		public Par X0Y0_紐左;

		public Par X0Y0_紐右;

		public Par X0Y0_下地;

		public Par X0Y0_線;

		public Par X0Y0_ライン_ライン上;

		public Par X0Y0_ライン_ライン左;

		public Par X0Y0_ライン_ライン右;

		public Par X0Y0_ライン_ライン左下;

		public Par X0Y0_ライン_ライン右下;

		public Par X0Y0_ライン_ライン下左;

		public Par X0Y0_ライン_ライン下右;

		public Par X0Y0_結び紐左_紐1;

		public Par X0Y0_結び紐左_紐2;

		public Par X0Y0_結び紐左_輪1_紐後;

		public Par X0Y0_結び紐左_輪1_紐前;

		public Par X0Y0_結び紐左_輪2_紐後;

		public Par X0Y0_結び紐左_輪2_紐前;

		public Par X0Y0_結び紐左_結び目;

		public Par X0Y0_結び紐右_紐1;

		public Par X0Y0_結び紐右_紐2;

		public Par X0Y0_結び紐右_輪1_紐後;

		public Par X0Y0_結び紐右_輪1_紐前;

		public Par X0Y0_結び紐右_輪2_紐後;

		public Par X0Y0_結び紐右_輪2_紐前;

		public Par X0Y0_結び紐右_結び目;

		public Par X0Y0_ヴィオラ_紐左;

		public Par X0Y0_ヴィオラ_紐右;

		public Par X0Y0_ヴィオラ_丸金具左;

		public Par X0Y0_ヴィオラ_丸金具右;

		public Par X0Y0_ヴィオラ_金具左_金具1;

		public Par X0Y0_ヴィオラ_金具左_金具2;

		public Par X0Y0_ヴィオラ_金具右_金具1;

		public Par X0Y0_ヴィオラ_金具右_金具2;

		public Par X0Y0_染み_染み2;

		public Par X0Y0_染み_染み1;

		public Par X0Y1_紐左;

		public Par X0Y1_紐右;

		public Par X0Y1_下地;

		public Par X0Y1_線;

		public Par X0Y1_ライン_ライン上;

		public Par X0Y1_ライン_ライン左;

		public Par X0Y1_ライン_ライン右;

		public Par X0Y1_ライン_ライン左下;

		public Par X0Y1_ライン_ライン右下;

		public Par X0Y1_ライン_ライン下左;

		public Par X0Y1_ライン_ライン下右;

		public Par X0Y1_結び紐左_紐1;

		public Par X0Y1_結び紐左_紐2;

		public Par X0Y1_結び紐左_輪1_紐後;

		public Par X0Y1_結び紐左_輪1_紐前;

		public Par X0Y1_結び紐左_輪2_紐後;

		public Par X0Y1_結び紐左_輪2_紐前;

		public Par X0Y1_結び紐左_結び目;

		public Par X0Y1_結び紐右_紐1;

		public Par X0Y1_結び紐右_紐2;

		public Par X0Y1_結び紐右_輪1_紐後;

		public Par X0Y1_結び紐右_輪1_紐前;

		public Par X0Y1_結び紐右_輪2_紐後;

		public Par X0Y1_結び紐右_輪2_紐前;

		public Par X0Y1_結び紐右_結び目;

		public Par X0Y1_ヴィオラ_紐左;

		public Par X0Y1_ヴィオラ_紐右;

		public Par X0Y1_ヴィオラ_丸金具左;

		public Par X0Y1_ヴィオラ_丸金具右;

		public Par X0Y1_ヴィオラ_金具左_金具1;

		public Par X0Y1_ヴィオラ_金具左_金具2;

		public Par X0Y1_ヴィオラ_金具右_金具1;

		public Par X0Y1_ヴィオラ_金具右_金具2;

		public Par X0Y1_染み_染み2;

		public Par X0Y1_染み_染み1;

		public Par X0Y2_紐左;

		public Par X0Y2_紐右;

		public Par X0Y2_下地;

		public Par X0Y2_線;

		public Par X0Y2_ライン_ライン上;

		public Par X0Y2_ライン_ライン左;

		public Par X0Y2_ライン_ライン右;

		public Par X0Y2_ライン_ライン左下;

		public Par X0Y2_ライン_ライン右下;

		public Par X0Y2_ライン_ライン下左;

		public Par X0Y2_ライン_ライン下右;

		public Par X0Y2_結び紐左_紐1;

		public Par X0Y2_結び紐左_紐2;

		public Par X0Y2_結び紐左_輪1_紐後;

		public Par X0Y2_結び紐左_輪1_紐前;

		public Par X0Y2_結び紐左_輪2_紐後;

		public Par X0Y2_結び紐左_輪2_紐前;

		public Par X0Y2_結び紐左_結び目;

		public Par X0Y2_結び紐右_紐1;

		public Par X0Y2_結び紐右_紐2;

		public Par X0Y2_結び紐右_輪1_紐後;

		public Par X0Y2_結び紐右_輪1_紐前;

		public Par X0Y2_結び紐右_輪2_紐後;

		public Par X0Y2_結び紐右_輪2_紐前;

		public Par X0Y2_結び紐右_結び目;

		public Par X0Y2_ヴィオラ_紐左;

		public Par X0Y2_ヴィオラ_紐右;

		public Par X0Y2_ヴィオラ_丸金具左;

		public Par X0Y2_ヴィオラ_丸金具右;

		public Par X0Y2_ヴィオラ_金具左_金具1;

		public Par X0Y2_ヴィオラ_金具左_金具2;

		public Par X0Y2_ヴィオラ_金具右_金具1;

		public Par X0Y2_ヴィオラ_金具右_金具2;

		public Par X0Y2_染み_染み2;

		public Par X0Y2_染み_染み1;

		public Par X0Y3_紐左;

		public Par X0Y3_紐右;

		public Par X0Y3_下地;

		public Par X0Y3_線;

		public Par X0Y3_ライン_ライン上;

		public Par X0Y3_ライン_ライン左;

		public Par X0Y3_ライン_ライン右;

		public Par X0Y3_ライン_ライン左下;

		public Par X0Y3_ライン_ライン右下;

		public Par X0Y3_ライン_ライン下左;

		public Par X0Y3_ライン_ライン下右;

		public Par X0Y3_結び紐左_紐1;

		public Par X0Y3_結び紐左_紐2;

		public Par X0Y3_結び紐左_輪1_紐後;

		public Par X0Y3_結び紐左_輪1_紐前;

		public Par X0Y3_結び紐左_輪2_紐後;

		public Par X0Y3_結び紐左_輪2_紐前;

		public Par X0Y3_結び紐左_結び目;

		public Par X0Y3_結び紐右_紐1;

		public Par X0Y3_結び紐右_紐2;

		public Par X0Y3_結び紐右_輪1_紐後;

		public Par X0Y3_結び紐右_輪1_紐前;

		public Par X0Y3_結び紐右_輪2_紐後;

		public Par X0Y3_結び紐右_輪2_紐前;

		public Par X0Y3_結び紐右_結び目;

		public Par X0Y3_ヴィオラ_紐左;

		public Par X0Y3_ヴィオラ_紐右;

		public Par X0Y3_ヴィオラ_丸金具左;

		public Par X0Y3_ヴィオラ_丸金具右;

		public Par X0Y3_ヴィオラ_金具左_金具1;

		public Par X0Y3_ヴィオラ_金具左_金具2;

		public Par X0Y3_ヴィオラ_金具右_金具1;

		public Par X0Y3_ヴィオラ_金具右_金具2;

		public Par X0Y3_染み_染み2;

		public Par X0Y3_染み_染み1;

		public Par X0Y4_紐左;

		public Par X0Y4_紐右;

		public Par X0Y4_下地;

		public Par X0Y4_線;

		public Par X0Y4_ライン_ライン上;

		public Par X0Y4_ライン_ライン左;

		public Par X0Y4_ライン_ライン右;

		public Par X0Y4_ライン_ライン左下;

		public Par X0Y4_ライン_ライン右下;

		public Par X0Y4_ライン_ライン下左;

		public Par X0Y4_ライン_ライン下右;

		public Par X0Y4_結び紐左_紐1;

		public Par X0Y4_結び紐左_紐2;

		public Par X0Y4_結び紐左_輪1_紐後;

		public Par X0Y4_結び紐左_輪1_紐前;

		public Par X0Y4_結び紐左_輪2_紐後;

		public Par X0Y4_結び紐左_輪2_紐前;

		public Par X0Y4_結び紐左_結び目;

		public Par X0Y4_結び紐右_紐1;

		public Par X0Y4_結び紐右_紐2;

		public Par X0Y4_結び紐右_輪1_紐後;

		public Par X0Y4_結び紐右_輪1_紐前;

		public Par X0Y4_結び紐右_輪2_紐後;

		public Par X0Y4_結び紐右_輪2_紐前;

		public Par X0Y4_結び紐右_結び目;

		public Par X0Y4_ヴィオラ_紐左;

		public Par X0Y4_ヴィオラ_紐右;

		public Par X0Y4_ヴィオラ_丸金具左;

		public Par X0Y4_ヴィオラ_丸金具右;

		public Par X0Y4_ヴィオラ_金具左_金具1;

		public Par X0Y4_ヴィオラ_金具左_金具2;

		public Par X0Y4_ヴィオラ_金具右_金具1;

		public Par X0Y4_ヴィオラ_金具右_金具2;

		public Par X0Y4_染み_染み2;

		public Par X0Y4_染み_染み1;

		public ColorD 紐左CD;

		public ColorD 紐右CD;

		public ColorD 下地CD;

		public ColorD 線CD;

		public ColorD ライン_ライン上CD;

		public ColorD ライン_ライン左CD;

		public ColorD ライン_ライン右CD;

		public ColorD ライン_ライン左下CD;

		public ColorD ライン_ライン右下CD;

		public ColorD ライン_ライン下左CD;

		public ColorD ライン_ライン下右CD;

		public ColorD 結び紐左_紐1CD;

		public ColorD 結び紐左_紐2CD;

		public ColorD 結び紐左_輪1_紐後CD;

		public ColorD 結び紐左_輪1_紐前CD;

		public ColorD 結び紐左_輪2_紐後CD;

		public ColorD 結び紐左_輪2_紐前CD;

		public ColorD 結び紐左_結び目CD;

		public ColorD 結び紐右_紐1CD;

		public ColorD 結び紐右_紐2CD;

		public ColorD 結び紐右_輪1_紐後CD;

		public ColorD 結び紐右_輪1_紐前CD;

		public ColorD 結び紐右_輪2_紐後CD;

		public ColorD 結び紐右_輪2_紐前CD;

		public ColorD 結び紐右_結び目CD;

		public ColorD ヴィオラ_紐左CD;

		public ColorD ヴィオラ_紐右CD;

		public ColorD ヴィオラ_丸金具左CD;

		public ColorD ヴィオラ_丸金具右CD;

		public ColorD ヴィオラ_金具左_金具1CD;

		public ColorD ヴィオラ_金具左_金具2CD;

		public ColorD ヴィオラ_金具右_金具1CD;

		public ColorD ヴィオラ_金具右_金具2CD;

		public ColorD 染み_染み2CD;

		public ColorD 染み_染み1CD;

		public ColorP X0Y0_紐左CP;

		public ColorP X0Y0_紐右CP;

		public ColorP X0Y0_下地CP;

		public ColorP X0Y0_線CP;

		public ColorP X0Y0_ライン_ライン上CP;

		public ColorP X0Y0_ライン_ライン左CP;

		public ColorP X0Y0_ライン_ライン右CP;

		public ColorP X0Y0_ライン_ライン左下CP;

		public ColorP X0Y0_ライン_ライン右下CP;

		public ColorP X0Y0_ライン_ライン下左CP;

		public ColorP X0Y0_ライン_ライン下右CP;

		public ColorP X0Y0_結び紐左_紐1CP;

		public ColorP X0Y0_結び紐左_紐2CP;

		public ColorP X0Y0_結び紐左_輪1_紐後CP;

		public ColorP X0Y0_結び紐左_輪1_紐前CP;

		public ColorP X0Y0_結び紐左_輪2_紐後CP;

		public ColorP X0Y0_結び紐左_輪2_紐前CP;

		public ColorP X0Y0_結び紐左_結び目CP;

		public ColorP X0Y0_結び紐右_紐1CP;

		public ColorP X0Y0_結び紐右_紐2CP;

		public ColorP X0Y0_結び紐右_輪1_紐後CP;

		public ColorP X0Y0_結び紐右_輪1_紐前CP;

		public ColorP X0Y0_結び紐右_輪2_紐後CP;

		public ColorP X0Y0_結び紐右_輪2_紐前CP;

		public ColorP X0Y0_結び紐右_結び目CP;

		public ColorP X0Y0_ヴィオラ_紐左CP;

		public ColorP X0Y0_ヴィオラ_紐右CP;

		public ColorP X0Y0_ヴィオラ_丸金具左CP;

		public ColorP X0Y0_ヴィオラ_丸金具右CP;

		public ColorP X0Y0_ヴィオラ_金具左_金具1CP;

		public ColorP X0Y0_ヴィオラ_金具左_金具2CP;

		public ColorP X0Y0_ヴィオラ_金具右_金具1CP;

		public ColorP X0Y0_ヴィオラ_金具右_金具2CP;

		public ColorP X0Y0_染み_染み2CP;

		public ColorP X0Y0_染み_染み1CP;

		public ColorP X0Y1_紐左CP;

		public ColorP X0Y1_紐右CP;

		public ColorP X0Y1_下地CP;

		public ColorP X0Y1_線CP;

		public ColorP X0Y1_ライン_ライン上CP;

		public ColorP X0Y1_ライン_ライン左CP;

		public ColorP X0Y1_ライン_ライン右CP;

		public ColorP X0Y1_ライン_ライン左下CP;

		public ColorP X0Y1_ライン_ライン右下CP;

		public ColorP X0Y1_ライン_ライン下左CP;

		public ColorP X0Y1_ライン_ライン下右CP;

		public ColorP X0Y1_結び紐左_紐1CP;

		public ColorP X0Y1_結び紐左_紐2CP;

		public ColorP X0Y1_結び紐左_輪1_紐後CP;

		public ColorP X0Y1_結び紐左_輪1_紐前CP;

		public ColorP X0Y1_結び紐左_輪2_紐後CP;

		public ColorP X0Y1_結び紐左_輪2_紐前CP;

		public ColorP X0Y1_結び紐左_結び目CP;

		public ColorP X0Y1_結び紐右_紐1CP;

		public ColorP X0Y1_結び紐右_紐2CP;

		public ColorP X0Y1_結び紐右_輪1_紐後CP;

		public ColorP X0Y1_結び紐右_輪1_紐前CP;

		public ColorP X0Y1_結び紐右_輪2_紐後CP;

		public ColorP X0Y1_結び紐右_輪2_紐前CP;

		public ColorP X0Y1_結び紐右_結び目CP;

		public ColorP X0Y1_ヴィオラ_紐左CP;

		public ColorP X0Y1_ヴィオラ_紐右CP;

		public ColorP X0Y1_ヴィオラ_丸金具左CP;

		public ColorP X0Y1_ヴィオラ_丸金具右CP;

		public ColorP X0Y1_ヴィオラ_金具左_金具1CP;

		public ColorP X0Y1_ヴィオラ_金具左_金具2CP;

		public ColorP X0Y1_ヴィオラ_金具右_金具1CP;

		public ColorP X0Y1_ヴィオラ_金具右_金具2CP;

		public ColorP X0Y1_染み_染み2CP;

		public ColorP X0Y1_染み_染み1CP;

		public ColorP X0Y2_紐左CP;

		public ColorP X0Y2_紐右CP;

		public ColorP X0Y2_下地CP;

		public ColorP X0Y2_線CP;

		public ColorP X0Y2_ライン_ライン上CP;

		public ColorP X0Y2_ライン_ライン左CP;

		public ColorP X0Y2_ライン_ライン右CP;

		public ColorP X0Y2_ライン_ライン左下CP;

		public ColorP X0Y2_ライン_ライン右下CP;

		public ColorP X0Y2_ライン_ライン下左CP;

		public ColorP X0Y2_ライン_ライン下右CP;

		public ColorP X0Y2_結び紐左_紐1CP;

		public ColorP X0Y2_結び紐左_紐2CP;

		public ColorP X0Y2_結び紐左_輪1_紐後CP;

		public ColorP X0Y2_結び紐左_輪1_紐前CP;

		public ColorP X0Y2_結び紐左_輪2_紐後CP;

		public ColorP X0Y2_結び紐左_輪2_紐前CP;

		public ColorP X0Y2_結び紐左_結び目CP;

		public ColorP X0Y2_結び紐右_紐1CP;

		public ColorP X0Y2_結び紐右_紐2CP;

		public ColorP X0Y2_結び紐右_輪1_紐後CP;

		public ColorP X0Y2_結び紐右_輪1_紐前CP;

		public ColorP X0Y2_結び紐右_輪2_紐後CP;

		public ColorP X0Y2_結び紐右_輪2_紐前CP;

		public ColorP X0Y2_結び紐右_結び目CP;

		public ColorP X0Y2_ヴィオラ_紐左CP;

		public ColorP X0Y2_ヴィオラ_紐右CP;

		public ColorP X0Y2_ヴィオラ_丸金具左CP;

		public ColorP X0Y2_ヴィオラ_丸金具右CP;

		public ColorP X0Y2_ヴィオラ_金具左_金具1CP;

		public ColorP X0Y2_ヴィオラ_金具左_金具2CP;

		public ColorP X0Y2_ヴィオラ_金具右_金具1CP;

		public ColorP X0Y2_ヴィオラ_金具右_金具2CP;

		public ColorP X0Y2_染み_染み2CP;

		public ColorP X0Y2_染み_染み1CP;

		public ColorP X0Y3_紐左CP;

		public ColorP X0Y3_紐右CP;

		public ColorP X0Y3_下地CP;

		public ColorP X0Y3_線CP;

		public ColorP X0Y3_ライン_ライン上CP;

		public ColorP X0Y3_ライン_ライン左CP;

		public ColorP X0Y3_ライン_ライン右CP;

		public ColorP X0Y3_ライン_ライン左下CP;

		public ColorP X0Y3_ライン_ライン右下CP;

		public ColorP X0Y3_ライン_ライン下左CP;

		public ColorP X0Y3_ライン_ライン下右CP;

		public ColorP X0Y3_結び紐左_紐1CP;

		public ColorP X0Y3_結び紐左_紐2CP;

		public ColorP X0Y3_結び紐左_輪1_紐後CP;

		public ColorP X0Y3_結び紐左_輪1_紐前CP;

		public ColorP X0Y3_結び紐左_輪2_紐後CP;

		public ColorP X0Y3_結び紐左_輪2_紐前CP;

		public ColorP X0Y3_結び紐左_結び目CP;

		public ColorP X0Y3_結び紐右_紐1CP;

		public ColorP X0Y3_結び紐右_紐2CP;

		public ColorP X0Y3_結び紐右_輪1_紐後CP;

		public ColorP X0Y3_結び紐右_輪1_紐前CP;

		public ColorP X0Y3_結び紐右_輪2_紐後CP;

		public ColorP X0Y3_結び紐右_輪2_紐前CP;

		public ColorP X0Y3_結び紐右_結び目CP;

		public ColorP X0Y3_ヴィオラ_紐左CP;

		public ColorP X0Y3_ヴィオラ_紐右CP;

		public ColorP X0Y3_ヴィオラ_丸金具左CP;

		public ColorP X0Y3_ヴィオラ_丸金具右CP;

		public ColorP X0Y3_ヴィオラ_金具左_金具1CP;

		public ColorP X0Y3_ヴィオラ_金具左_金具2CP;

		public ColorP X0Y3_ヴィオラ_金具右_金具1CP;

		public ColorP X0Y3_ヴィオラ_金具右_金具2CP;

		public ColorP X0Y3_染み_染み2CP;

		public ColorP X0Y3_染み_染み1CP;

		public ColorP X0Y4_紐左CP;

		public ColorP X0Y4_紐右CP;

		public ColorP X0Y4_下地CP;

		public ColorP X0Y4_線CP;

		public ColorP X0Y4_ライン_ライン上CP;

		public ColorP X0Y4_ライン_ライン左CP;

		public ColorP X0Y4_ライン_ライン右CP;

		public ColorP X0Y4_ライン_ライン左下CP;

		public ColorP X0Y4_ライン_ライン右下CP;

		public ColorP X0Y4_ライン_ライン下左CP;

		public ColorP X0Y4_ライン_ライン下右CP;

		public ColorP X0Y4_結び紐左_紐1CP;

		public ColorP X0Y4_結び紐左_紐2CP;

		public ColorP X0Y4_結び紐左_輪1_紐後CP;

		public ColorP X0Y4_結び紐左_輪1_紐前CP;

		public ColorP X0Y4_結び紐左_輪2_紐後CP;

		public ColorP X0Y4_結び紐左_輪2_紐前CP;

		public ColorP X0Y4_結び紐左_結び目CP;

		public ColorP X0Y4_結び紐右_紐1CP;

		public ColorP X0Y4_結び紐右_紐2CP;

		public ColorP X0Y4_結び紐右_輪1_紐後CP;

		public ColorP X0Y4_結び紐右_輪1_紐前CP;

		public ColorP X0Y4_結び紐右_輪2_紐後CP;

		public ColorP X0Y4_結び紐右_輪2_紐前CP;

		public ColorP X0Y4_結び紐右_結び目CP;

		public ColorP X0Y4_ヴィオラ_紐左CP;

		public ColorP X0Y4_ヴィオラ_紐右CP;

		public ColorP X0Y4_ヴィオラ_丸金具左CP;

		public ColorP X0Y4_ヴィオラ_丸金具右CP;

		public ColorP X0Y4_ヴィオラ_金具左_金具1CP;

		public ColorP X0Y4_ヴィオラ_金具左_金具2CP;

		public ColorP X0Y4_ヴィオラ_金具右_金具1CP;

		public ColorP X0Y4_ヴィオラ_金具右_金具2CP;

		public ColorP X0Y4_染み_染み2CP;

		public ColorP X0Y4_染み_染み1CP;
	}
}
