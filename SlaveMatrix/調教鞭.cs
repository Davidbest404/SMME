using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 調教鞭 : Ele
	{
		public 調教鞭(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 調教鞭D e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.カ\u30FCソル["調教鞭"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_先 = pars["先"].ToPar();
			this.X0Y0_柄 = pars["柄"].ToPar();
			this.X0Y0_線1 = pars["線1"].ToPar();
			this.X0Y0_線2 = pars["線2"].ToPar();
			this.X0Y0_線3 = pars["線3"].ToPar();
			this.X0Y0_線4 = pars["線4"].ToPar();
			this.X0Y0_線5 = pars["線5"].ToPar();
			this.X0Y0_線6 = pars["線6"].ToPar();
			this.X0Y0_線7 = pars["線7"].ToPar();
			this.X0Y0_線8 = pars["線8"].ToPar();
			this.X0Y0_紐 = pars["紐"].ToPar();
			pars = this.本体[0][1];
			this.X0Y1_先 = pars["先"].ToPar();
			this.X0Y1_柄 = pars["柄"].ToPar();
			this.X0Y1_線1 = pars["線1"].ToPar();
			this.X0Y1_線2 = pars["線2"].ToPar();
			this.X0Y1_線3 = pars["線3"].ToPar();
			this.X0Y1_線4 = pars["線4"].ToPar();
			this.X0Y1_線5 = pars["線5"].ToPar();
			this.X0Y1_線6 = pars["線6"].ToPar();
			this.X0Y1_線7 = pars["線7"].ToPar();
			this.X0Y1_線8 = pars["線8"].ToPar();
			this.X0Y1_紐 = pars["紐"].ToPar();
			pars = this.本体[0][2];
			this.X0Y2_先 = pars["先"].ToPar();
			this.X0Y2_柄 = pars["柄"].ToPar();
			this.X0Y2_線1 = pars["線1"].ToPar();
			this.X0Y2_線2 = pars["線2"].ToPar();
			this.X0Y2_線3 = pars["線3"].ToPar();
			this.X0Y2_線4 = pars["線4"].ToPar();
			this.X0Y2_線5 = pars["線5"].ToPar();
			this.X0Y2_線6 = pars["線6"].ToPar();
			this.X0Y2_線7 = pars["線7"].ToPar();
			this.X0Y2_線8 = pars["線8"].ToPar();
			this.X0Y2_紐 = pars["紐"].ToPar();
			pars = this.本体[0][3];
			this.X0Y3_先 = pars["先"].ToPar();
			this.X0Y3_柄 = pars["柄"].ToPar();
			this.X0Y3_線1 = pars["線1"].ToPar();
			this.X0Y3_線2 = pars["線2"].ToPar();
			this.X0Y3_線3 = pars["線3"].ToPar();
			this.X0Y3_線4 = pars["線4"].ToPar();
			this.X0Y3_線5 = pars["線5"].ToPar();
			this.X0Y3_線6 = pars["線6"].ToPar();
			this.X0Y3_線7 = pars["線7"].ToPar();
			this.X0Y3_線8 = pars["線8"].ToPar();
			this.X0Y3_紐 = pars["紐"].ToPar();
			pars = this.本体[0][4];
			this.X0Y4_先 = pars["先"].ToPar();
			this.X0Y4_柄 = pars["柄"].ToPar();
			this.X0Y4_線1 = pars["線1"].ToPar();
			this.X0Y4_線2 = pars["線2"].ToPar();
			this.X0Y4_線3 = pars["線3"].ToPar();
			this.X0Y4_線4 = pars["線4"].ToPar();
			this.X0Y4_線5 = pars["線5"].ToPar();
			this.X0Y4_線6 = pars["線6"].ToPar();
			this.X0Y4_線7 = pars["線7"].ToPar();
			this.X0Y4_線8 = pars["線8"].ToPar();
			this.X0Y4_紐 = pars["紐"].ToPar();
			pars = this.本体[1][0];
			this.X1Y0_先 = pars["先"].ToPar();
			this.X1Y0_柄 = pars["柄"].ToPar();
			this.X1Y0_線1 = pars["線1"].ToPar();
			this.X1Y0_線2 = pars["線2"].ToPar();
			this.X1Y0_線3 = pars["線3"].ToPar();
			this.X1Y0_線4 = pars["線4"].ToPar();
			this.X1Y0_線5 = pars["線5"].ToPar();
			this.X1Y0_線6 = pars["線6"].ToPar();
			this.X1Y0_線7 = pars["線7"].ToPar();
			this.X1Y0_線8 = pars["線8"].ToPar();
			this.X1Y0_紐 = pars["紐"].ToPar();
			this.X1Y0_鞭撃エフェクト1 = pars["鞭撃エフェクト1"].ToPar();
			this.X1Y0_鞭撃エフェクト2 = pars["鞭撃エフェクト2"].ToPar();
			pars = this.本体[1][1];
			this.X1Y1_先 = pars["先"].ToPar();
			this.X1Y1_柄 = pars["柄"].ToPar();
			this.X1Y1_線1 = pars["線1"].ToPar();
			this.X1Y1_線2 = pars["線2"].ToPar();
			this.X1Y1_線3 = pars["線3"].ToPar();
			this.X1Y1_線4 = pars["線4"].ToPar();
			this.X1Y1_線5 = pars["線5"].ToPar();
			this.X1Y1_線6 = pars["線6"].ToPar();
			this.X1Y1_線7 = pars["線7"].ToPar();
			this.X1Y1_線8 = pars["線8"].ToPar();
			this.X1Y1_紐 = pars["紐"].ToPar();
			this.X1Y1_鞭撃エフェクト1 = pars["鞭撃エフェクト1"].ToPar();
			this.X1Y1_鞭撃エフェクト2 = pars["鞭撃エフェクト2"].ToPar();
			pars = this.本体[1][2];
			this.X1Y2_先 = pars["先"].ToPar();
			this.X1Y2_柄 = pars["柄"].ToPar();
			this.X1Y2_線1 = pars["線1"].ToPar();
			this.X1Y2_線2 = pars["線2"].ToPar();
			this.X1Y2_線3 = pars["線3"].ToPar();
			this.X1Y2_線4 = pars["線4"].ToPar();
			this.X1Y2_線5 = pars["線5"].ToPar();
			this.X1Y2_線6 = pars["線6"].ToPar();
			this.X1Y2_線7 = pars["線7"].ToPar();
			this.X1Y2_線8 = pars["線8"].ToPar();
			this.X1Y2_紐 = pars["紐"].ToPar();
			this.X1Y2_鞭撃エフェクト1 = pars["鞭撃エフェクト1"].ToPar();
			this.X1Y2_鞭撃エフェクト2 = pars["鞭撃エフェクト2"].ToPar();
			pars = this.本体[1][3];
			this.X1Y3_先 = pars["先"].ToPar();
			this.X1Y3_柄 = pars["柄"].ToPar();
			this.X1Y3_線1 = pars["線1"].ToPar();
			this.X1Y3_線2 = pars["線2"].ToPar();
			this.X1Y3_線3 = pars["線3"].ToPar();
			this.X1Y3_線4 = pars["線4"].ToPar();
			this.X1Y3_線5 = pars["線5"].ToPar();
			this.X1Y3_線6 = pars["線6"].ToPar();
			this.X1Y3_線7 = pars["線7"].ToPar();
			this.X1Y3_線8 = pars["線8"].ToPar();
			this.X1Y3_紐 = pars["紐"].ToPar();
			pars = this.本体[1][4];
			this.X1Y4_先 = pars["先"].ToPar();
			this.X1Y4_柄 = pars["柄"].ToPar();
			this.X1Y4_線1 = pars["線1"].ToPar();
			this.X1Y4_線2 = pars["線2"].ToPar();
			this.X1Y4_線3 = pars["線3"].ToPar();
			this.X1Y4_線4 = pars["線4"].ToPar();
			this.X1Y4_線5 = pars["線5"].ToPar();
			this.X1Y4_線6 = pars["線6"].ToPar();
			this.X1Y4_線7 = pars["線7"].ToPar();
			this.X1Y4_線8 = pars["線8"].ToPar();
			this.X1Y4_紐 = pars["紐"].ToPar();
			this.X1Y4_鞭撃エフェクト1 = pars["鞭撃エフェクト1"].ToPar();
			this.X1Y4_鞭撃エフェクト2 = pars["鞭撃エフェクト2"].ToPar();
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
			this.先_表示 = e.先_表示;
			this.柄_表示 = e.柄_表示;
			this.線1_表示 = e.線1_表示;
			this.線2_表示 = e.線2_表示;
			this.線3_表示 = e.線3_表示;
			this.線4_表示 = e.線4_表示;
			this.線5_表示 = e.線5_表示;
			this.線6_表示 = e.線6_表示;
			this.線7_表示 = e.線7_表示;
			this.線8_表示 = e.線8_表示;
			this.紐_表示 = e.紐_表示;
			this.鞭撃エフェクト1_表示 = e.鞭撃エフェクト1_表示;
			this.鞭撃エフェクト2_表示 = e.鞭撃エフェクト2_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_先CP = new ColorP(this.X0Y0_先, this.先CD, DisUnit, true);
			this.X0Y0_柄CP = new ColorP(this.X0Y0_柄, this.柄CD, DisUnit, true);
			this.X0Y0_線1CP = new ColorP(this.X0Y0_線1, this.線1CD, DisUnit, true);
			this.X0Y0_線2CP = new ColorP(this.X0Y0_線2, this.線2CD, DisUnit, true);
			this.X0Y0_線3CP = new ColorP(this.X0Y0_線3, this.線3CD, DisUnit, true);
			this.X0Y0_線4CP = new ColorP(this.X0Y0_線4, this.線4CD, DisUnit, true);
			this.X0Y0_線5CP = new ColorP(this.X0Y0_線5, this.線5CD, DisUnit, true);
			this.X0Y0_線6CP = new ColorP(this.X0Y0_線6, this.線6CD, DisUnit, true);
			this.X0Y0_線7CP = new ColorP(this.X0Y0_線7, this.線7CD, DisUnit, true);
			this.X0Y0_線8CP = new ColorP(this.X0Y0_線8, this.線8CD, DisUnit, true);
			this.X0Y0_紐CP = new ColorP(this.X0Y0_紐, this.紐CD, DisUnit, true);
			this.X0Y1_先CP = new ColorP(this.X0Y1_先, this.先CD, DisUnit, true);
			this.X0Y1_柄CP = new ColorP(this.X0Y1_柄, this.柄CD, DisUnit, true);
			this.X0Y1_線1CP = new ColorP(this.X0Y1_線1, this.線1CD, DisUnit, true);
			this.X0Y1_線2CP = new ColorP(this.X0Y1_線2, this.線2CD, DisUnit, true);
			this.X0Y1_線3CP = new ColorP(this.X0Y1_線3, this.線3CD, DisUnit, true);
			this.X0Y1_線4CP = new ColorP(this.X0Y1_線4, this.線4CD, DisUnit, true);
			this.X0Y1_線5CP = new ColorP(this.X0Y1_線5, this.線5CD, DisUnit, true);
			this.X0Y1_線6CP = new ColorP(this.X0Y1_線6, this.線6CD, DisUnit, true);
			this.X0Y1_線7CP = new ColorP(this.X0Y1_線7, this.線7CD, DisUnit, true);
			this.X0Y1_線8CP = new ColorP(this.X0Y1_線8, this.線8CD, DisUnit, true);
			this.X0Y1_紐CP = new ColorP(this.X0Y1_紐, this.紐CD, DisUnit, true);
			this.X0Y2_先CP = new ColorP(this.X0Y2_先, this.先CD, DisUnit, true);
			this.X0Y2_柄CP = new ColorP(this.X0Y2_柄, this.柄CD, DisUnit, true);
			this.X0Y2_線1CP = new ColorP(this.X0Y2_線1, this.線1CD, DisUnit, true);
			this.X0Y2_線2CP = new ColorP(this.X0Y2_線2, this.線2CD, DisUnit, true);
			this.X0Y2_線3CP = new ColorP(this.X0Y2_線3, this.線3CD, DisUnit, true);
			this.X0Y2_線4CP = new ColorP(this.X0Y2_線4, this.線4CD, DisUnit, true);
			this.X0Y2_線5CP = new ColorP(this.X0Y2_線5, this.線5CD, DisUnit, true);
			this.X0Y2_線6CP = new ColorP(this.X0Y2_線6, this.線6CD, DisUnit, true);
			this.X0Y2_線7CP = new ColorP(this.X0Y2_線7, this.線7CD, DisUnit, true);
			this.X0Y2_線8CP = new ColorP(this.X0Y2_線8, this.線8CD, DisUnit, true);
			this.X0Y2_紐CP = new ColorP(this.X0Y2_紐, this.紐CD, DisUnit, true);
			this.X0Y3_先CP = new ColorP(this.X0Y3_先, this.先CD, DisUnit, true);
			this.X0Y3_柄CP = new ColorP(this.X0Y3_柄, this.柄CD, DisUnit, true);
			this.X0Y3_線1CP = new ColorP(this.X0Y3_線1, this.線1CD, DisUnit, true);
			this.X0Y3_線2CP = new ColorP(this.X0Y3_線2, this.線2CD, DisUnit, true);
			this.X0Y3_線3CP = new ColorP(this.X0Y3_線3, this.線3CD, DisUnit, true);
			this.X0Y3_線4CP = new ColorP(this.X0Y3_線4, this.線4CD, DisUnit, true);
			this.X0Y3_線5CP = new ColorP(this.X0Y3_線5, this.線5CD, DisUnit, true);
			this.X0Y3_線6CP = new ColorP(this.X0Y3_線6, this.線6CD, DisUnit, true);
			this.X0Y3_線7CP = new ColorP(this.X0Y3_線7, this.線7CD, DisUnit, true);
			this.X0Y3_線8CP = new ColorP(this.X0Y3_線8, this.線8CD, DisUnit, true);
			this.X0Y3_紐CP = new ColorP(this.X0Y3_紐, this.紐CD, DisUnit, true);
			this.X0Y4_先CP = new ColorP(this.X0Y4_先, this.先CD, DisUnit, true);
			this.X0Y4_柄CP = new ColorP(this.X0Y4_柄, this.柄CD, DisUnit, true);
			this.X0Y4_線1CP = new ColorP(this.X0Y4_線1, this.線1CD, DisUnit, true);
			this.X0Y4_線2CP = new ColorP(this.X0Y4_線2, this.線2CD, DisUnit, true);
			this.X0Y4_線3CP = new ColorP(this.X0Y4_線3, this.線3CD, DisUnit, true);
			this.X0Y4_線4CP = new ColorP(this.X0Y4_線4, this.線4CD, DisUnit, true);
			this.X0Y4_線5CP = new ColorP(this.X0Y4_線5, this.線5CD, DisUnit, true);
			this.X0Y4_線6CP = new ColorP(this.X0Y4_線6, this.線6CD, DisUnit, true);
			this.X0Y4_線7CP = new ColorP(this.X0Y4_線7, this.線7CD, DisUnit, true);
			this.X0Y4_線8CP = new ColorP(this.X0Y4_線8, this.線8CD, DisUnit, true);
			this.X0Y4_紐CP = new ColorP(this.X0Y4_紐, this.紐CD, DisUnit, true);
			this.X1Y0_先CP = new ColorP(this.X1Y0_先, this.先CD, DisUnit, true);
			this.X1Y0_柄CP = new ColorP(this.X1Y0_柄, this.柄CD, DisUnit, true);
			this.X1Y0_線1CP = new ColorP(this.X1Y0_線1, this.線1CD, DisUnit, true);
			this.X1Y0_線2CP = new ColorP(this.X1Y0_線2, this.線2CD, DisUnit, true);
			this.X1Y0_線3CP = new ColorP(this.X1Y0_線3, this.線3CD, DisUnit, true);
			this.X1Y0_線4CP = new ColorP(this.X1Y0_線4, this.線4CD, DisUnit, true);
			this.X1Y0_線5CP = new ColorP(this.X1Y0_線5, this.線5CD, DisUnit, true);
			this.X1Y0_線6CP = new ColorP(this.X1Y0_線6, this.線6CD, DisUnit, true);
			this.X1Y0_線7CP = new ColorP(this.X1Y0_線7, this.線7CD, DisUnit, true);
			this.X1Y0_線8CP = new ColorP(this.X1Y0_線8, this.線8CD, DisUnit, true);
			this.X1Y0_紐CP = new ColorP(this.X1Y0_紐, this.紐CD, DisUnit, true);
			this.X1Y0_鞭撃エフェクト1CP = new ColorP(this.X1Y0_鞭撃エフェクト1, this.鞭撃エフェクト1CD, DisUnit, true);
			this.X1Y0_鞭撃エフェクト2CP = new ColorP(this.X1Y0_鞭撃エフェクト2, this.鞭撃エフェクト2CD, DisUnit, true);
			this.X1Y1_先CP = new ColorP(this.X1Y1_先, this.先CD, DisUnit, true);
			this.X1Y1_柄CP = new ColorP(this.X1Y1_柄, this.柄CD, DisUnit, true);
			this.X1Y1_線1CP = new ColorP(this.X1Y1_線1, this.線1CD, DisUnit, true);
			this.X1Y1_線2CP = new ColorP(this.X1Y1_線2, this.線2CD, DisUnit, true);
			this.X1Y1_線3CP = new ColorP(this.X1Y1_線3, this.線3CD, DisUnit, true);
			this.X1Y1_線4CP = new ColorP(this.X1Y1_線4, this.線4CD, DisUnit, true);
			this.X1Y1_線5CP = new ColorP(this.X1Y1_線5, this.線5CD, DisUnit, true);
			this.X1Y1_線6CP = new ColorP(this.X1Y1_線6, this.線6CD, DisUnit, true);
			this.X1Y1_線7CP = new ColorP(this.X1Y1_線7, this.線7CD, DisUnit, true);
			this.X1Y1_線8CP = new ColorP(this.X1Y1_線8, this.線8CD, DisUnit, true);
			this.X1Y1_紐CP = new ColorP(this.X1Y1_紐, this.紐CD, DisUnit, true);
			this.X1Y1_鞭撃エフェクト1CP = new ColorP(this.X1Y1_鞭撃エフェクト1, this.鞭撃エフェクト1CD, DisUnit, true);
			this.X1Y1_鞭撃エフェクト2CP = new ColorP(this.X1Y1_鞭撃エフェクト2, this.鞭撃エフェクト2CD, DisUnit, true);
			this.X1Y2_先CP = new ColorP(this.X1Y2_先, this.先CD, DisUnit, true);
			this.X1Y2_柄CP = new ColorP(this.X1Y2_柄, this.柄CD, DisUnit, true);
			this.X1Y2_線1CP = new ColorP(this.X1Y2_線1, this.線1CD, DisUnit, true);
			this.X1Y2_線2CP = new ColorP(this.X1Y2_線2, this.線2CD, DisUnit, true);
			this.X1Y2_線3CP = new ColorP(this.X1Y2_線3, this.線3CD, DisUnit, true);
			this.X1Y2_線4CP = new ColorP(this.X1Y2_線4, this.線4CD, DisUnit, true);
			this.X1Y2_線5CP = new ColorP(this.X1Y2_線5, this.線5CD, DisUnit, true);
			this.X1Y2_線6CP = new ColorP(this.X1Y2_線6, this.線6CD, DisUnit, true);
			this.X1Y2_線7CP = new ColorP(this.X1Y2_線7, this.線7CD, DisUnit, true);
			this.X1Y2_線8CP = new ColorP(this.X1Y2_線8, this.線8CD, DisUnit, true);
			this.X1Y2_紐CP = new ColorP(this.X1Y2_紐, this.紐CD, DisUnit, true);
			this.X1Y2_鞭撃エフェクト1CP = new ColorP(this.X1Y2_鞭撃エフェクト1, this.鞭撃エフェクト1CD, DisUnit, true);
			this.X1Y2_鞭撃エフェクト2CP = new ColorP(this.X1Y2_鞭撃エフェクト2, this.鞭撃エフェクト2CD, DisUnit, true);
			this.X1Y3_先CP = new ColorP(this.X1Y3_先, this.先CD, DisUnit, true);
			this.X1Y3_柄CP = new ColorP(this.X1Y3_柄, this.柄CD, DisUnit, true);
			this.X1Y3_線1CP = new ColorP(this.X1Y3_線1, this.線1CD, DisUnit, true);
			this.X1Y3_線2CP = new ColorP(this.X1Y3_線2, this.線2CD, DisUnit, true);
			this.X1Y3_線3CP = new ColorP(this.X1Y3_線3, this.線3CD, DisUnit, true);
			this.X1Y3_線4CP = new ColorP(this.X1Y3_線4, this.線4CD, DisUnit, true);
			this.X1Y3_線5CP = new ColorP(this.X1Y3_線5, this.線5CD, DisUnit, true);
			this.X1Y3_線6CP = new ColorP(this.X1Y3_線6, this.線6CD, DisUnit, true);
			this.X1Y3_線7CP = new ColorP(this.X1Y3_線7, this.線7CD, DisUnit, true);
			this.X1Y3_線8CP = new ColorP(this.X1Y3_線8, this.線8CD, DisUnit, true);
			this.X1Y3_紐CP = new ColorP(this.X1Y3_紐, this.紐CD, DisUnit, true);
			this.X1Y4_先CP = new ColorP(this.X1Y4_先, this.先CD, DisUnit, true);
			this.X1Y4_柄CP = new ColorP(this.X1Y4_柄, this.柄CD, DisUnit, true);
			this.X1Y4_線1CP = new ColorP(this.X1Y4_線1, this.線1CD, DisUnit, true);
			this.X1Y4_線2CP = new ColorP(this.X1Y4_線2, this.線2CD, DisUnit, true);
			this.X1Y4_線3CP = new ColorP(this.X1Y4_線3, this.線3CD, DisUnit, true);
			this.X1Y4_線4CP = new ColorP(this.X1Y4_線4, this.線4CD, DisUnit, true);
			this.X1Y4_線5CP = new ColorP(this.X1Y4_線5, this.線5CD, DisUnit, true);
			this.X1Y4_線6CP = new ColorP(this.X1Y4_線6, this.線6CD, DisUnit, true);
			this.X1Y4_線7CP = new ColorP(this.X1Y4_線7, this.線7CD, DisUnit, true);
			this.X1Y4_線8CP = new ColorP(this.X1Y4_線8, this.線8CD, DisUnit, true);
			this.X1Y4_紐CP = new ColorP(this.X1Y4_紐, this.紐CD, DisUnit, true);
			this.X1Y4_鞭撃エフェクト1CP = new ColorP(this.X1Y4_鞭撃エフェクト1, this.鞭撃エフェクト1CD, DisUnit, true);
			this.X1Y4_鞭撃エフェクト2CP = new ColorP(this.X1Y4_鞭撃エフェクト2, this.鞭撃エフェクト2CD, DisUnit, true);
			this.濃度 = e.濃度;
			this.尺度B = 1.01;
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

		public bool 先_表示
		{
			get
			{
				return this.X0Y0_先.Dra;
			}
			set
			{
				this.X0Y0_先.Dra = value;
				this.X0Y1_先.Dra = value;
				this.X0Y2_先.Dra = value;
				this.X0Y3_先.Dra = value;
				this.X0Y4_先.Dra = value;
				this.X1Y0_先.Dra = value;
				this.X1Y1_先.Dra = value;
				this.X1Y2_先.Dra = value;
				this.X1Y3_先.Dra = value;
				this.X1Y4_先.Dra = value;
				this.X0Y0_先.Hit = value;
				this.X0Y1_先.Hit = value;
				this.X0Y2_先.Hit = value;
				this.X0Y3_先.Hit = value;
				this.X0Y4_先.Hit = value;
				this.X1Y0_先.Hit = value;
				this.X1Y1_先.Hit = value;
				this.X1Y2_先.Hit = value;
				this.X1Y3_先.Hit = value;
				this.X1Y4_先.Hit = value;
			}
		}

		public bool 柄_表示
		{
			get
			{
				return this.X0Y0_柄.Dra;
			}
			set
			{
				this.X0Y0_柄.Dra = value;
				this.X0Y1_柄.Dra = value;
				this.X0Y2_柄.Dra = value;
				this.X0Y3_柄.Dra = value;
				this.X0Y4_柄.Dra = value;
				this.X1Y0_柄.Dra = value;
				this.X1Y1_柄.Dra = value;
				this.X1Y2_柄.Dra = value;
				this.X1Y3_柄.Dra = value;
				this.X1Y4_柄.Dra = value;
				this.X0Y0_柄.Hit = value;
				this.X0Y1_柄.Hit = value;
				this.X0Y2_柄.Hit = value;
				this.X0Y3_柄.Hit = value;
				this.X0Y4_柄.Hit = value;
				this.X1Y0_柄.Hit = value;
				this.X1Y1_柄.Hit = value;
				this.X1Y2_柄.Hit = value;
				this.X1Y3_柄.Hit = value;
				this.X1Y4_柄.Hit = value;
			}
		}

		public bool 線1_表示
		{
			get
			{
				return this.X0Y0_線1.Dra;
			}
			set
			{
				this.X0Y0_線1.Dra = value;
				this.X0Y1_線1.Dra = value;
				this.X0Y2_線1.Dra = value;
				this.X0Y3_線1.Dra = value;
				this.X0Y4_線1.Dra = value;
				this.X1Y0_線1.Dra = value;
				this.X1Y1_線1.Dra = value;
				this.X1Y2_線1.Dra = value;
				this.X1Y3_線1.Dra = value;
				this.X1Y4_線1.Dra = value;
				this.X0Y0_線1.Hit = value;
				this.X0Y1_線1.Hit = value;
				this.X0Y2_線1.Hit = value;
				this.X0Y3_線1.Hit = value;
				this.X0Y4_線1.Hit = value;
				this.X1Y0_線1.Hit = value;
				this.X1Y1_線1.Hit = value;
				this.X1Y2_線1.Hit = value;
				this.X1Y3_線1.Hit = value;
				this.X1Y4_線1.Hit = value;
			}
		}

		public bool 線2_表示
		{
			get
			{
				return this.X0Y0_線2.Dra;
			}
			set
			{
				this.X0Y0_線2.Dra = value;
				this.X0Y1_線2.Dra = value;
				this.X0Y2_線2.Dra = value;
				this.X0Y3_線2.Dra = value;
				this.X0Y4_線2.Dra = value;
				this.X1Y0_線2.Dra = value;
				this.X1Y1_線2.Dra = value;
				this.X1Y2_線2.Dra = value;
				this.X1Y3_線2.Dra = value;
				this.X1Y4_線2.Dra = value;
				this.X0Y0_線2.Hit = value;
				this.X0Y1_線2.Hit = value;
				this.X0Y2_線2.Hit = value;
				this.X0Y3_線2.Hit = value;
				this.X0Y4_線2.Hit = value;
				this.X1Y0_線2.Hit = value;
				this.X1Y1_線2.Hit = value;
				this.X1Y2_線2.Hit = value;
				this.X1Y3_線2.Hit = value;
				this.X1Y4_線2.Hit = value;
			}
		}

		public bool 線3_表示
		{
			get
			{
				return this.X0Y0_線3.Dra;
			}
			set
			{
				this.X0Y0_線3.Dra = value;
				this.X0Y1_線3.Dra = value;
				this.X0Y2_線3.Dra = value;
				this.X0Y3_線3.Dra = value;
				this.X0Y4_線3.Dra = value;
				this.X1Y0_線3.Dra = value;
				this.X1Y1_線3.Dra = value;
				this.X1Y2_線3.Dra = value;
				this.X1Y3_線3.Dra = value;
				this.X1Y4_線3.Dra = value;
				this.X0Y0_線3.Hit = value;
				this.X0Y1_線3.Hit = value;
				this.X0Y2_線3.Hit = value;
				this.X0Y3_線3.Hit = value;
				this.X0Y4_線3.Hit = value;
				this.X1Y0_線3.Hit = value;
				this.X1Y1_線3.Hit = value;
				this.X1Y2_線3.Hit = value;
				this.X1Y3_線3.Hit = value;
				this.X1Y4_線3.Hit = value;
			}
		}

		public bool 線4_表示
		{
			get
			{
				return this.X0Y0_線4.Dra;
			}
			set
			{
				this.X0Y0_線4.Dra = value;
				this.X0Y1_線4.Dra = value;
				this.X0Y2_線4.Dra = value;
				this.X0Y3_線4.Dra = value;
				this.X0Y4_線4.Dra = value;
				this.X1Y0_線4.Dra = value;
				this.X1Y1_線4.Dra = value;
				this.X1Y2_線4.Dra = value;
				this.X1Y3_線4.Dra = value;
				this.X1Y4_線4.Dra = value;
				this.X0Y0_線4.Hit = value;
				this.X0Y1_線4.Hit = value;
				this.X0Y2_線4.Hit = value;
				this.X0Y3_線4.Hit = value;
				this.X0Y4_線4.Hit = value;
				this.X1Y0_線4.Hit = value;
				this.X1Y1_線4.Hit = value;
				this.X1Y2_線4.Hit = value;
				this.X1Y3_線4.Hit = value;
				this.X1Y4_線4.Hit = value;
			}
		}

		public bool 線5_表示
		{
			get
			{
				return this.X0Y0_線5.Dra;
			}
			set
			{
				this.X0Y0_線5.Dra = value;
				this.X0Y1_線5.Dra = value;
				this.X0Y2_線5.Dra = value;
				this.X0Y3_線5.Dra = value;
				this.X0Y4_線5.Dra = value;
				this.X1Y0_線5.Dra = value;
				this.X1Y1_線5.Dra = value;
				this.X1Y2_線5.Dra = value;
				this.X1Y3_線5.Dra = value;
				this.X1Y4_線5.Dra = value;
				this.X0Y0_線5.Hit = value;
				this.X0Y1_線5.Hit = value;
				this.X0Y2_線5.Hit = value;
				this.X0Y3_線5.Hit = value;
				this.X0Y4_線5.Hit = value;
				this.X1Y0_線5.Hit = value;
				this.X1Y1_線5.Hit = value;
				this.X1Y2_線5.Hit = value;
				this.X1Y3_線5.Hit = value;
				this.X1Y4_線5.Hit = value;
			}
		}

		public bool 線6_表示
		{
			get
			{
				return this.X0Y0_線6.Dra;
			}
			set
			{
				this.X0Y0_線6.Dra = value;
				this.X0Y1_線6.Dra = value;
				this.X0Y2_線6.Dra = value;
				this.X0Y3_線6.Dra = value;
				this.X0Y4_線6.Dra = value;
				this.X1Y0_線6.Dra = value;
				this.X1Y1_線6.Dra = value;
				this.X1Y2_線6.Dra = value;
				this.X1Y3_線6.Dra = value;
				this.X1Y4_線6.Dra = value;
				this.X0Y0_線6.Hit = value;
				this.X0Y1_線6.Hit = value;
				this.X0Y2_線6.Hit = value;
				this.X0Y3_線6.Hit = value;
				this.X0Y4_線6.Hit = value;
				this.X1Y0_線6.Hit = value;
				this.X1Y1_線6.Hit = value;
				this.X1Y2_線6.Hit = value;
				this.X1Y3_線6.Hit = value;
				this.X1Y4_線6.Hit = value;
			}
		}

		public bool 線7_表示
		{
			get
			{
				return this.X0Y0_線7.Dra;
			}
			set
			{
				this.X0Y0_線7.Dra = value;
				this.X0Y1_線7.Dra = value;
				this.X0Y2_線7.Dra = value;
				this.X0Y3_線7.Dra = value;
				this.X0Y4_線7.Dra = value;
				this.X1Y0_線7.Dra = value;
				this.X1Y1_線7.Dra = value;
				this.X1Y2_線7.Dra = value;
				this.X1Y3_線7.Dra = value;
				this.X1Y4_線7.Dra = value;
				this.X0Y0_線7.Hit = value;
				this.X0Y1_線7.Hit = value;
				this.X0Y2_線7.Hit = value;
				this.X0Y3_線7.Hit = value;
				this.X0Y4_線7.Hit = value;
				this.X1Y0_線7.Hit = value;
				this.X1Y1_線7.Hit = value;
				this.X1Y2_線7.Hit = value;
				this.X1Y3_線7.Hit = value;
				this.X1Y4_線7.Hit = value;
			}
		}

		public bool 線8_表示
		{
			get
			{
				return this.X0Y0_線8.Dra;
			}
			set
			{
				this.X0Y0_線8.Dra = value;
				this.X0Y1_線8.Dra = value;
				this.X0Y2_線8.Dra = value;
				this.X0Y3_線8.Dra = value;
				this.X0Y4_線8.Dra = value;
				this.X1Y0_線8.Dra = value;
				this.X1Y1_線8.Dra = value;
				this.X1Y2_線8.Dra = value;
				this.X1Y3_線8.Dra = value;
				this.X1Y4_線8.Dra = value;
				this.X0Y0_線8.Hit = value;
				this.X0Y1_線8.Hit = value;
				this.X0Y2_線8.Hit = value;
				this.X0Y3_線8.Hit = value;
				this.X0Y4_線8.Hit = value;
				this.X1Y0_線8.Hit = value;
				this.X1Y1_線8.Hit = value;
				this.X1Y2_線8.Hit = value;
				this.X1Y3_線8.Hit = value;
				this.X1Y4_線8.Hit = value;
			}
		}

		public bool 紐_表示
		{
			get
			{
				return this.X0Y0_紐.Dra;
			}
			set
			{
				this.X0Y0_紐.Dra = value;
				this.X0Y1_紐.Dra = value;
				this.X0Y2_紐.Dra = value;
				this.X0Y3_紐.Dra = value;
				this.X0Y4_紐.Dra = value;
				this.X1Y0_紐.Dra = value;
				this.X1Y1_紐.Dra = value;
				this.X1Y2_紐.Dra = value;
				this.X1Y3_紐.Dra = value;
				this.X1Y4_紐.Dra = value;
				this.X0Y0_紐.Hit = value;
				this.X0Y1_紐.Hit = value;
				this.X0Y2_紐.Hit = value;
				this.X0Y3_紐.Hit = value;
				this.X0Y4_紐.Hit = value;
				this.X1Y0_紐.Hit = value;
				this.X1Y1_紐.Hit = value;
				this.X1Y2_紐.Hit = value;
				this.X1Y3_紐.Hit = value;
				this.X1Y4_紐.Hit = value;
			}
		}

		public bool 鞭撃エフェクト1_表示
		{
			get
			{
				return this.X1Y0_鞭撃エフェクト1.Dra;
			}
			set
			{
				this.X1Y0_鞭撃エフェクト1.Dra = value;
				this.X1Y1_鞭撃エフェクト1.Dra = value;
				this.X1Y2_鞭撃エフェクト1.Dra = value;
				this.X1Y4_鞭撃エフェクト1.Dra = value;
				this.X1Y0_鞭撃エフェクト1.Hit = value;
				this.X1Y1_鞭撃エフェクト1.Hit = value;
				this.X1Y2_鞭撃エフェクト1.Hit = value;
				this.X1Y4_鞭撃エフェクト1.Hit = value;
			}
		}

		public bool 鞭撃エフェクト2_表示
		{
			get
			{
				return this.X1Y0_鞭撃エフェクト2.Dra;
			}
			set
			{
				this.X1Y0_鞭撃エフェクト2.Dra = value;
				this.X1Y1_鞭撃エフェクト2.Dra = value;
				this.X1Y2_鞭撃エフェクト2.Dra = value;
				this.X1Y4_鞭撃エフェクト2.Dra = value;
				this.X1Y0_鞭撃エフェクト2.Hit = value;
				this.X1Y1_鞭撃エフェクト2.Hit = value;
				this.X1Y2_鞭撃エフェクト2.Hit = value;
				this.X1Y4_鞭撃エフェクト2.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.先_表示;
			}
			set
			{
				this.先_表示 = value;
				this.柄_表示 = value;
				this.線1_表示 = value;
				this.線2_表示 = value;
				this.線3_表示 = value;
				this.線4_表示 = value;
				this.線5_表示 = value;
				this.線6_表示 = value;
				this.線7_表示 = value;
				this.線8_表示 = value;
				this.紐_表示 = value;
				this.鞭撃エフェクト1_表示 = value;
				this.鞭撃エフェクト2_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.先CD.不透明度;
			}
			set
			{
				this.先CD.不透明度 = value;
				this.柄CD.不透明度 = value;
				this.線1CD.不透明度 = value;
				this.線2CD.不透明度 = value;
				this.線3CD.不透明度 = value;
				this.線4CD.不透明度 = value;
				this.線5CD.不透明度 = value;
				this.線6CD.不透明度 = value;
				this.線7CD.不透明度 = value;
				this.線8CD.不透明度 = value;
				this.紐CD.不透明度 = value;
				this.鞭撃エフェクト1CD.不透明度 = value;
				this.鞭撃エフェクト2CD.不透明度 = value;
			}
		}

		public override void 色更新()
		{
			if (this.本体.IndexX == 0)
			{
				switch (this.本体.IndexY)
				{
				case 0:
					this.X0Y0_先CP.Update();
					this.X0Y0_柄CP.Update();
					this.X0Y0_線1CP.Update();
					this.X0Y0_線2CP.Update();
					this.X0Y0_線3CP.Update();
					this.X0Y0_線4CP.Update();
					this.X0Y0_線5CP.Update();
					this.X0Y0_線6CP.Update();
					this.X0Y0_線7CP.Update();
					this.X0Y0_線8CP.Update();
					this.X0Y0_紐CP.Update();
					return;
				case 1:
					this.X0Y1_先CP.Update();
					this.X0Y1_柄CP.Update();
					this.X0Y1_線1CP.Update();
					this.X0Y1_線2CP.Update();
					this.X0Y1_線3CP.Update();
					this.X0Y1_線4CP.Update();
					this.X0Y1_線5CP.Update();
					this.X0Y1_線6CP.Update();
					this.X0Y1_線7CP.Update();
					this.X0Y1_線8CP.Update();
					this.X0Y1_紐CP.Update();
					return;
				case 2:
					this.X0Y2_先CP.Update();
					this.X0Y2_柄CP.Update();
					this.X0Y2_線1CP.Update();
					this.X0Y2_線2CP.Update();
					this.X0Y2_線3CP.Update();
					this.X0Y2_線4CP.Update();
					this.X0Y2_線5CP.Update();
					this.X0Y2_線6CP.Update();
					this.X0Y2_線7CP.Update();
					this.X0Y2_線8CP.Update();
					this.X0Y2_紐CP.Update();
					return;
				case 3:
					this.X0Y3_先CP.Update();
					this.X0Y3_柄CP.Update();
					this.X0Y3_線1CP.Update();
					this.X0Y3_線2CP.Update();
					this.X0Y3_線3CP.Update();
					this.X0Y3_線4CP.Update();
					this.X0Y3_線5CP.Update();
					this.X0Y3_線6CP.Update();
					this.X0Y3_線7CP.Update();
					this.X0Y3_線8CP.Update();
					this.X0Y3_紐CP.Update();
					return;
				default:
					this.X0Y4_先CP.Update();
					this.X0Y4_柄CP.Update();
					this.X0Y4_線1CP.Update();
					this.X0Y4_線2CP.Update();
					this.X0Y4_線3CP.Update();
					this.X0Y4_線4CP.Update();
					this.X0Y4_線5CP.Update();
					this.X0Y4_線6CP.Update();
					this.X0Y4_線7CP.Update();
					this.X0Y4_線8CP.Update();
					this.X0Y4_紐CP.Update();
					return;
				}
			}
			else
			{
				switch (this.本体.IndexY)
				{
				case 0:
					this.X1Y0_先CP.Update();
					this.X1Y0_柄CP.Update();
					this.X1Y0_線1CP.Update();
					this.X1Y0_線2CP.Update();
					this.X1Y0_線3CP.Update();
					this.X1Y0_線4CP.Update();
					this.X1Y0_線5CP.Update();
					this.X1Y0_線6CP.Update();
					this.X1Y0_線7CP.Update();
					this.X1Y0_線8CP.Update();
					this.X1Y0_紐CP.Update();
					this.X1Y0_鞭撃エフェクト1CP.Update();
					this.X1Y0_鞭撃エフェクト2CP.Update();
					return;
				case 1:
					this.X1Y1_先CP.Update();
					this.X1Y1_柄CP.Update();
					this.X1Y1_線1CP.Update();
					this.X1Y1_線2CP.Update();
					this.X1Y1_線3CP.Update();
					this.X1Y1_線4CP.Update();
					this.X1Y1_線5CP.Update();
					this.X1Y1_線6CP.Update();
					this.X1Y1_線7CP.Update();
					this.X1Y1_線8CP.Update();
					this.X1Y1_紐CP.Update();
					this.X1Y1_鞭撃エフェクト1CP.Update();
					this.X1Y1_鞭撃エフェクト2CP.Update();
					return;
				case 2:
					this.X1Y2_先CP.Update();
					this.X1Y2_柄CP.Update();
					this.X1Y2_線1CP.Update();
					this.X1Y2_線2CP.Update();
					this.X1Y2_線3CP.Update();
					this.X1Y2_線4CP.Update();
					this.X1Y2_線5CP.Update();
					this.X1Y2_線6CP.Update();
					this.X1Y2_線7CP.Update();
					this.X1Y2_線8CP.Update();
					this.X1Y2_紐CP.Update();
					this.X1Y2_鞭撃エフェクト1CP.Update();
					this.X1Y2_鞭撃エフェクト2CP.Update();
					return;
				case 3:
					this.X1Y3_先CP.Update();
					this.X1Y3_柄CP.Update();
					this.X1Y3_線1CP.Update();
					this.X1Y3_線2CP.Update();
					this.X1Y3_線3CP.Update();
					this.X1Y3_線4CP.Update();
					this.X1Y3_線5CP.Update();
					this.X1Y3_線6CP.Update();
					this.X1Y3_線7CP.Update();
					this.X1Y3_線8CP.Update();
					this.X1Y3_紐CP.Update();
					return;
				default:
					this.X1Y4_先CP.Update();
					this.X1Y4_柄CP.Update();
					this.X1Y4_線1CP.Update();
					this.X1Y4_線2CP.Update();
					this.X1Y4_線3CP.Update();
					this.X1Y4_線4CP.Update();
					this.X1Y4_線5CP.Update();
					this.X1Y4_線6CP.Update();
					this.X1Y4_線7CP.Update();
					this.X1Y4_線8CP.Update();
					this.X1Y4_紐CP.Update();
					this.X1Y4_鞭撃エフェクト1CP.Update();
					this.X1Y4_鞭撃エフェクト2CP.Update();
					return;
				}
			}
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			Color2 color = new Color2(ref Col.Black, ref Col.Empty);
			this.先CD = new ColorD(ref Col.Black, ref color);
			this.紐CD = new ColorD(ref Col.Black, ref color);
			this.柄CD = new ColorD();
			this.柄CD.線 = Col.Black;
			this.柄CD.色 = new Color2(ref Col.DimGray, ref Col.Black);
			this.線1CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.線2CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.線3CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.線4CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.線5CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.線6CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.線7CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.線8CD = new ColorD(ref Col.Black, ref Color2.Empty);
			Col.GetGrad(ref Col.Silver, out color);
			this.鞭撃エフェクト1CD = new ColorD(ref Col.Empty, ref color);
			this.鞭撃エフェクト2CD = new ColorD(ref Col.Empty, ref color);
		}

		public Par X0Y0_先;

		public Par X0Y0_柄;

		public Par X0Y0_線1;

		public Par X0Y0_線2;

		public Par X0Y0_線3;

		public Par X0Y0_線4;

		public Par X0Y0_線5;

		public Par X0Y0_線6;

		public Par X0Y0_線7;

		public Par X0Y0_線8;

		public Par X0Y0_紐;

		public Par X0Y1_先;

		public Par X0Y1_柄;

		public Par X0Y1_線1;

		public Par X0Y1_線2;

		public Par X0Y1_線3;

		public Par X0Y1_線4;

		public Par X0Y1_線5;

		public Par X0Y1_線6;

		public Par X0Y1_線7;

		public Par X0Y1_線8;

		public Par X0Y1_紐;

		public Par X0Y2_先;

		public Par X0Y2_柄;

		public Par X0Y2_線1;

		public Par X0Y2_線2;

		public Par X0Y2_線3;

		public Par X0Y2_線4;

		public Par X0Y2_線5;

		public Par X0Y2_線6;

		public Par X0Y2_線7;

		public Par X0Y2_線8;

		public Par X0Y2_紐;

		public Par X0Y3_先;

		public Par X0Y3_柄;

		public Par X0Y3_線1;

		public Par X0Y3_線2;

		public Par X0Y3_線3;

		public Par X0Y3_線4;

		public Par X0Y3_線5;

		public Par X0Y3_線6;

		public Par X0Y3_線7;

		public Par X0Y3_線8;

		public Par X0Y3_紐;

		public Par X0Y4_先;

		public Par X0Y4_柄;

		public Par X0Y4_線1;

		public Par X0Y4_線2;

		public Par X0Y4_線3;

		public Par X0Y4_線4;

		public Par X0Y4_線5;

		public Par X0Y4_線6;

		public Par X0Y4_線7;

		public Par X0Y4_線8;

		public Par X0Y4_紐;

		public Par X1Y0_先;

		public Par X1Y0_柄;

		public Par X1Y0_線1;

		public Par X1Y0_線2;

		public Par X1Y0_線3;

		public Par X1Y0_線4;

		public Par X1Y0_線5;

		public Par X1Y0_線6;

		public Par X1Y0_線7;

		public Par X1Y0_線8;

		public Par X1Y0_紐;

		public Par X1Y0_鞭撃エフェクト1;

		public Par X1Y0_鞭撃エフェクト2;

		public Par X1Y1_先;

		public Par X1Y1_柄;

		public Par X1Y1_線1;

		public Par X1Y1_線2;

		public Par X1Y1_線3;

		public Par X1Y1_線4;

		public Par X1Y1_線5;

		public Par X1Y1_線6;

		public Par X1Y1_線7;

		public Par X1Y1_線8;

		public Par X1Y1_紐;

		public Par X1Y1_鞭撃エフェクト1;

		public Par X1Y1_鞭撃エフェクト2;

		public Par X1Y2_先;

		public Par X1Y2_柄;

		public Par X1Y2_線1;

		public Par X1Y2_線2;

		public Par X1Y2_線3;

		public Par X1Y2_線4;

		public Par X1Y2_線5;

		public Par X1Y2_線6;

		public Par X1Y2_線7;

		public Par X1Y2_線8;

		public Par X1Y2_紐;

		public Par X1Y2_鞭撃エフェクト1;

		public Par X1Y2_鞭撃エフェクト2;

		public Par X1Y3_先;

		public Par X1Y3_柄;

		public Par X1Y3_線1;

		public Par X1Y3_線2;

		public Par X1Y3_線3;

		public Par X1Y3_線4;

		public Par X1Y3_線5;

		public Par X1Y3_線6;

		public Par X1Y3_線7;

		public Par X1Y3_線8;

		public Par X1Y3_紐;

		public Par X1Y4_先;

		public Par X1Y4_柄;

		public Par X1Y4_線1;

		public Par X1Y4_線2;

		public Par X1Y4_線3;

		public Par X1Y4_線4;

		public Par X1Y4_線5;

		public Par X1Y4_線6;

		public Par X1Y4_線7;

		public Par X1Y4_線8;

		public Par X1Y4_紐;

		public Par X1Y4_鞭撃エフェクト1;

		public Par X1Y4_鞭撃エフェクト2;

		public ColorD 先CD;

		public ColorD 柄CD;

		public ColorD 線1CD;

		public ColorD 線2CD;

		public ColorD 線3CD;

		public ColorD 線4CD;

		public ColorD 線5CD;

		public ColorD 線6CD;

		public ColorD 線7CD;

		public ColorD 線8CD;

		public ColorD 紐CD;

		public ColorD 鞭撃エフェクト1CD;

		public ColorD 鞭撃エフェクト2CD;

		public ColorP X0Y0_先CP;

		public ColorP X0Y0_柄CP;

		public ColorP X0Y0_線1CP;

		public ColorP X0Y0_線2CP;

		public ColorP X0Y0_線3CP;

		public ColorP X0Y0_線4CP;

		public ColorP X0Y0_線5CP;

		public ColorP X0Y0_線6CP;

		public ColorP X0Y0_線7CP;

		public ColorP X0Y0_線8CP;

		public ColorP X0Y0_紐CP;

		public ColorP X0Y1_先CP;

		public ColorP X0Y1_柄CP;

		public ColorP X0Y1_線1CP;

		public ColorP X0Y1_線2CP;

		public ColorP X0Y1_線3CP;

		public ColorP X0Y1_線4CP;

		public ColorP X0Y1_線5CP;

		public ColorP X0Y1_線6CP;

		public ColorP X0Y1_線7CP;

		public ColorP X0Y1_線8CP;

		public ColorP X0Y1_紐CP;

		public ColorP X0Y2_先CP;

		public ColorP X0Y2_柄CP;

		public ColorP X0Y2_線1CP;

		public ColorP X0Y2_線2CP;

		public ColorP X0Y2_線3CP;

		public ColorP X0Y2_線4CP;

		public ColorP X0Y2_線5CP;

		public ColorP X0Y2_線6CP;

		public ColorP X0Y2_線7CP;

		public ColorP X0Y2_線8CP;

		public ColorP X0Y2_紐CP;

		public ColorP X0Y3_先CP;

		public ColorP X0Y3_柄CP;

		public ColorP X0Y3_線1CP;

		public ColorP X0Y3_線2CP;

		public ColorP X0Y3_線3CP;

		public ColorP X0Y3_線4CP;

		public ColorP X0Y3_線5CP;

		public ColorP X0Y3_線6CP;

		public ColorP X0Y3_線7CP;

		public ColorP X0Y3_線8CP;

		public ColorP X0Y3_紐CP;

		public ColorP X0Y4_先CP;

		public ColorP X0Y4_柄CP;

		public ColorP X0Y4_線1CP;

		public ColorP X0Y4_線2CP;

		public ColorP X0Y4_線3CP;

		public ColorP X0Y4_線4CP;

		public ColorP X0Y4_線5CP;

		public ColorP X0Y4_線6CP;

		public ColorP X0Y4_線7CP;

		public ColorP X0Y4_線8CP;

		public ColorP X0Y4_紐CP;

		public ColorP X1Y0_先CP;

		public ColorP X1Y0_柄CP;

		public ColorP X1Y0_線1CP;

		public ColorP X1Y0_線2CP;

		public ColorP X1Y0_線3CP;

		public ColorP X1Y0_線4CP;

		public ColorP X1Y0_線5CP;

		public ColorP X1Y0_線6CP;

		public ColorP X1Y0_線7CP;

		public ColorP X1Y0_線8CP;

		public ColorP X1Y0_紐CP;

		public ColorP X1Y0_鞭撃エフェクト1CP;

		public ColorP X1Y0_鞭撃エフェクト2CP;

		public ColorP X1Y1_先CP;

		public ColorP X1Y1_柄CP;

		public ColorP X1Y1_線1CP;

		public ColorP X1Y1_線2CP;

		public ColorP X1Y1_線3CP;

		public ColorP X1Y1_線4CP;

		public ColorP X1Y1_線5CP;

		public ColorP X1Y1_線6CP;

		public ColorP X1Y1_線7CP;

		public ColorP X1Y1_線8CP;

		public ColorP X1Y1_紐CP;

		public ColorP X1Y1_鞭撃エフェクト1CP;

		public ColorP X1Y1_鞭撃エフェクト2CP;

		public ColorP X1Y2_先CP;

		public ColorP X1Y2_柄CP;

		public ColorP X1Y2_線1CP;

		public ColorP X1Y2_線2CP;

		public ColorP X1Y2_線3CP;

		public ColorP X1Y2_線4CP;

		public ColorP X1Y2_線5CP;

		public ColorP X1Y2_線6CP;

		public ColorP X1Y2_線7CP;

		public ColorP X1Y2_線8CP;

		public ColorP X1Y2_紐CP;

		public ColorP X1Y2_鞭撃エフェクト1CP;

		public ColorP X1Y2_鞭撃エフェクト2CP;

		public ColorP X1Y3_先CP;

		public ColorP X1Y3_柄CP;

		public ColorP X1Y3_線1CP;

		public ColorP X1Y3_線2CP;

		public ColorP X1Y3_線3CP;

		public ColorP X1Y3_線4CP;

		public ColorP X1Y3_線5CP;

		public ColorP X1Y3_線6CP;

		public ColorP X1Y3_線7CP;

		public ColorP X1Y3_線8CP;

		public ColorP X1Y3_紐CP;

		public ColorP X1Y4_先CP;

		public ColorP X1Y4_柄CP;

		public ColorP X1Y4_線1CP;

		public ColorP X1Y4_線2CP;

		public ColorP X1Y4_線3CP;

		public ColorP X1Y4_線4CP;

		public ColorP X1Y4_線5CP;

		public ColorP X1Y4_線6CP;

		public ColorP X1Y4_線7CP;

		public ColorP X1Y4_線8CP;

		public ColorP X1Y4_紐CP;

		public ColorP X1Y4_鞭撃エフェクト1CP;

		public ColorP X1Y4_鞭撃エフェクト2CP;
	}
}
