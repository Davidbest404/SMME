using System;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 性器_人 : 性器
	{
		public 性器_人(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 性器_人D e)
		{
			性器_人.<>c__DisplayClass247_0 CS$<>8__locals1 = new 性器_人.<>c__DisplayClass247_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.性器["性器"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_小陰唇 = pars["小陰唇"].ToPar();
			this.X0Y0_性器基 = pars["性器基"].ToPar();
			this.X0Y0_陰核 = pars["陰核"].ToPar();
			this.X0Y0_尿道 = pars["尿道"].ToPar();
			this.X0Y0_膣口 = pars["膣口"].ToPar();
			pars = this.本体[0][1];
			this.X0Y1_小陰唇 = pars["小陰唇"].ToPar();
			this.X0Y1_性器基 = pars["性器基"].ToPar();
			this.X0Y1_陰核 = pars["陰核"].ToPar();
			this.X0Y1_尿道 = pars["尿道"].ToPar();
			this.X0Y1_膣口 = pars["膣口"].ToPar();
			pars = this.本体[0][2];
			this.X0Y2_小陰唇 = pars["小陰唇"].ToPar();
			this.X0Y2_性器基 = pars["性器基"].ToPar();
			this.X0Y2_陰核 = pars["陰核"].ToPar();
			this.X0Y2_尿道 = pars["尿道"].ToPar();
			this.X0Y2_膣口 = pars["膣口"].ToPar();
			pars = this.本体[0][3];
			this.X0Y3_小陰唇 = pars["小陰唇"].ToPar();
			this.X0Y3_性器基 = pars["性器基"].ToPar();
			this.X0Y3_陰核 = pars["陰核"].ToPar();
			this.X0Y3_尿道 = pars["尿道"].ToPar();
			this.X0Y3_膣口 = pars["膣口"].ToPar();
			pars = this.本体[0][4];
			this.X0Y4_小陰唇 = pars["小陰唇"].ToPar();
			this.X0Y4_性器基 = pars["性器基"].ToPar();
			this.X0Y4_陰核 = pars["陰核"].ToPar();
			this.X0Y4_尿道 = pars["尿道"].ToPar();
			this.X0Y4_膣口 = pars["膣口"].ToPar();
			pars = this.本体[0][5];
			this.X0Y5_小陰唇 = pars["小陰唇"].ToPar();
			this.X0Y5_性器基 = pars["性器基"].ToPar();
			this.X0Y5_陰核 = pars["陰核"].ToPar();
			this.X0Y5_尿道 = pars["尿道"].ToPar();
			this.X0Y5_膣口 = pars["膣口"].ToPar();
			pars = this.本体[1][0];
			this.X1Y0_小陰唇 = pars["小陰唇"].ToPar();
			this.X1Y0_性器基 = pars["性器基"].ToPar();
			this.X1Y0_陰核 = pars["陰核"].ToPar();
			this.X1Y0_尿道 = pars["尿道"].ToPar();
			this.X1Y0_膣口 = pars["膣口"].ToPar();
			pars = this.本体[1][1];
			this.X1Y1_小陰唇 = pars["小陰唇"].ToPar();
			this.X1Y1_性器基 = pars["性器基"].ToPar();
			this.X1Y1_陰核 = pars["陰核"].ToPar();
			this.X1Y1_尿道 = pars["尿道"].ToPar();
			this.X1Y1_膣口 = pars["膣口"].ToPar();
			pars = this.本体[1][2];
			this.X1Y2_小陰唇 = pars["小陰唇"].ToPar();
			this.X1Y2_性器基 = pars["性器基"].ToPar();
			this.X1Y2_陰核 = pars["陰核"].ToPar();
			this.X1Y2_尿道 = pars["尿道"].ToPar();
			this.X1Y2_膣口 = pars["膣口"].ToPar();
			pars = this.本体[1][3];
			this.X1Y3_小陰唇 = pars["小陰唇"].ToPar();
			this.X1Y3_性器基 = pars["性器基"].ToPar();
			this.X1Y3_陰核 = pars["陰核"].ToPar();
			this.X1Y3_尿道 = pars["尿道"].ToPar();
			this.X1Y3_膣口 = pars["膣口"].ToPar();
			pars = this.本体[1][4];
			this.X1Y4_小陰唇 = pars["小陰唇"].ToPar();
			this.X1Y4_性器基 = pars["性器基"].ToPar();
			this.X1Y4_陰核 = pars["陰核"].ToPar();
			this.X1Y4_尿道 = pars["尿道"].ToPar();
			this.X1Y4_膣口 = pars["膣口"].ToPar();
			pars = this.本体[1][5];
			this.X1Y5_小陰唇 = pars["小陰唇"].ToPar();
			this.X1Y5_性器基 = pars["性器基"].ToPar();
			this.X1Y5_陰核 = pars["陰核"].ToPar();
			this.X1Y5_尿道 = pars["尿道"].ToPar();
			this.X1Y5_膣口 = pars["膣口"].ToPar();
			pars = this.本体[2][0];
			this.X2Y0_小陰唇 = pars["小陰唇"].ToPar();
			this.X2Y0_性器基 = pars["性器基"].ToPar();
			this.X2Y0_陰核 = pars["陰核"].ToPar();
			this.X2Y0_尿道 = pars["尿道"].ToPar();
			this.X2Y0_膣口 = pars["膣口"].ToPar();
			pars = this.本体[2][1];
			this.X2Y1_小陰唇 = pars["小陰唇"].ToPar();
			this.X2Y1_性器基 = pars["性器基"].ToPar();
			this.X2Y1_陰核 = pars["陰核"].ToPar();
			this.X2Y1_尿道 = pars["尿道"].ToPar();
			this.X2Y1_膣口 = pars["膣口"].ToPar();
			pars = this.本体[2][2];
			this.X2Y2_小陰唇 = pars["小陰唇"].ToPar();
			this.X2Y2_性器基 = pars["性器基"].ToPar();
			this.X2Y2_陰核 = pars["陰核"].ToPar();
			this.X2Y2_尿道 = pars["尿道"].ToPar();
			this.X2Y2_膣口 = pars["膣口"].ToPar();
			pars = this.本体[2][3];
			this.X2Y3_小陰唇 = pars["小陰唇"].ToPar();
			this.X2Y3_性器基 = pars["性器基"].ToPar();
			this.X2Y3_陰核 = pars["陰核"].ToPar();
			this.X2Y3_尿道 = pars["尿道"].ToPar();
			this.X2Y3_膣口 = pars["膣口"].ToPar();
			pars = this.本体[2][4];
			this.X2Y4_小陰唇 = pars["小陰唇"].ToPar();
			this.X2Y4_性器基 = pars["性器基"].ToPar();
			this.X2Y4_陰核 = pars["陰核"].ToPar();
			this.X2Y4_尿道 = pars["尿道"].ToPar();
			this.X2Y4_膣口 = pars["膣口"].ToPar();
			pars = this.本体[2][5];
			this.X2Y5_小陰唇 = pars["小陰唇"].ToPar();
			this.X2Y5_性器基 = pars["性器基"].ToPar();
			this.X2Y5_陰核 = pars["陰核"].ToPar();
			this.X2Y5_尿道 = pars["尿道"].ToPar();
			this.X2Y5_膣口 = pars["膣口"].ToPar();
			pars = this.本体[3][0];
			this.X3Y0_小陰唇 = pars["小陰唇"].ToPar();
			this.X3Y0_性器基 = pars["性器基"].ToPar();
			this.X3Y0_陰核 = pars["陰核"].ToPar();
			this.X3Y0_尿道 = pars["尿道"].ToPar();
			this.X3Y0_膣口 = pars["膣口"].ToPar();
			pars = this.本体[3][1];
			this.X3Y1_小陰唇 = pars["小陰唇"].ToPar();
			this.X3Y1_性器基 = pars["性器基"].ToPar();
			this.X3Y1_陰核 = pars["陰核"].ToPar();
			this.X3Y1_尿道 = pars["尿道"].ToPar();
			this.X3Y1_膣口 = pars["膣口"].ToPar();
			pars = this.本体[3][2];
			this.X3Y2_小陰唇 = pars["小陰唇"].ToPar();
			this.X3Y2_性器基 = pars["性器基"].ToPar();
			this.X3Y2_陰核 = pars["陰核"].ToPar();
			this.X3Y2_尿道 = pars["尿道"].ToPar();
			this.X3Y2_膣口 = pars["膣口"].ToPar();
			pars = this.本体[3][3];
			this.X3Y3_小陰唇 = pars["小陰唇"].ToPar();
			this.X3Y3_性器基 = pars["性器基"].ToPar();
			this.X3Y3_陰核 = pars["陰核"].ToPar();
			this.X3Y3_尿道 = pars["尿道"].ToPar();
			this.X3Y3_膣口 = pars["膣口"].ToPar();
			pars = this.本体[3][4];
			this.X3Y4_小陰唇 = pars["小陰唇"].ToPar();
			this.X3Y4_性器基 = pars["性器基"].ToPar();
			this.X3Y4_陰核 = pars["陰核"].ToPar();
			this.X3Y4_尿道 = pars["尿道"].ToPar();
			this.X3Y4_膣口 = pars["膣口"].ToPar();
			pars = this.本体[3][5];
			this.X3Y5_小陰唇 = pars["小陰唇"].ToPar();
			this.X3Y5_性器基 = pars["性器基"].ToPar();
			this.X3Y5_陰核 = pars["陰核"].ToPar();
			this.X3Y5_尿道 = pars["尿道"].ToPar();
			this.X3Y5_膣口 = pars["膣口"].ToPar();
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
			this.小陰唇_表示 = e.小陰唇_表示;
			this.性器基_表示 = e.性器基_表示;
			this.陰核_表示 = e.陰核_表示;
			this.尿道_表示 = e.尿道_表示;
			this.膣口_表示 = e.膣口_表示;
			this.くぱぁ = e.くぱぁ;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.陰核_接続.Count > 0)
			{
				Ele f;
				this.陰核_接続 = e.陰核_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.性器_人_陰核_接続;
					f.接続(CS$<>8__locals1.<>4__this.陰核_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.尿道_接続.Count > 0)
			{
				Ele f;
				this.尿道_接続 = e.尿道_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.性器_人_尿道_接続;
					f.接続(CS$<>8__locals1.<>4__this.尿道_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.膣口_接続.Count > 0)
			{
				Ele f;
				this.膣口_接続 = e.膣口_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.性器_人_膣口_接続;
					f.接続(CS$<>8__locals1.<>4__this.膣口_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_小陰唇CP = new ColorP(this.X0Y0_小陰唇, this.小陰唇CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_性器基CP = new ColorP(this.X0Y0_性器基, this.性器基CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_陰核CP = new ColorP(this.X0Y0_陰核, this.陰核CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尿道CP = new ColorP(this.X0Y0_尿道, this.尿道CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_膣口CP = new ColorP(this.X0Y0_膣口, this.膣口CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_小陰唇CP = new ColorP(this.X0Y1_小陰唇, this.小陰唇CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_性器基CP = new ColorP(this.X0Y1_性器基, this.性器基CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_陰核CP = new ColorP(this.X0Y1_陰核, this.陰核CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_尿道CP = new ColorP(this.X0Y1_尿道, this.尿道CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_膣口CP = new ColorP(this.X0Y1_膣口, this.膣口CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_小陰唇CP = new ColorP(this.X0Y2_小陰唇, this.小陰唇CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_性器基CP = new ColorP(this.X0Y2_性器基, this.性器基CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_陰核CP = new ColorP(this.X0Y2_陰核, this.陰核CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_尿道CP = new ColorP(this.X0Y2_尿道, this.尿道CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_膣口CP = new ColorP(this.X0Y2_膣口, this.膣口CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_小陰唇CP = new ColorP(this.X0Y3_小陰唇, this.小陰唇CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_性器基CP = new ColorP(this.X0Y3_性器基, this.性器基CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_陰核CP = new ColorP(this.X0Y3_陰核, this.陰核CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_尿道CP = new ColorP(this.X0Y3_尿道, this.尿道CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_膣口CP = new ColorP(this.X0Y3_膣口, this.膣口CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_小陰唇CP = new ColorP(this.X0Y4_小陰唇, this.小陰唇CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_性器基CP = new ColorP(this.X0Y4_性器基, this.性器基CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_陰核CP = new ColorP(this.X0Y4_陰核, this.陰核CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_尿道CP = new ColorP(this.X0Y4_尿道, this.尿道CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_膣口CP = new ColorP(this.X0Y4_膣口, this.膣口CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y5_小陰唇CP = new ColorP(this.X0Y5_小陰唇, this.小陰唇CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y5_性器基CP = new ColorP(this.X0Y5_性器基, this.性器基CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y5_陰核CP = new ColorP(this.X0Y5_陰核, this.陰核CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y5_尿道CP = new ColorP(this.X0Y5_尿道, this.尿道CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y5_膣口CP = new ColorP(this.X0Y5_膣口, this.膣口CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y0_小陰唇CP = new ColorP(this.X1Y0_小陰唇, this.小陰唇CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y0_性器基CP = new ColorP(this.X1Y0_性器基, this.性器基CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y0_陰核CP = new ColorP(this.X1Y0_陰核, this.陰核CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y0_尿道CP = new ColorP(this.X1Y0_尿道, this.尿道CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y0_膣口CP = new ColorP(this.X1Y0_膣口, this.膣口CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y1_小陰唇CP = new ColorP(this.X1Y1_小陰唇, this.小陰唇CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y1_性器基CP = new ColorP(this.X1Y1_性器基, this.性器基CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y1_陰核CP = new ColorP(this.X1Y1_陰核, this.陰核CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y1_尿道CP = new ColorP(this.X1Y1_尿道, this.尿道CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y1_膣口CP = new ColorP(this.X1Y1_膣口, this.膣口CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y2_小陰唇CP = new ColorP(this.X1Y2_小陰唇, this.小陰唇CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y2_性器基CP = new ColorP(this.X1Y2_性器基, this.性器基CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y2_陰核CP = new ColorP(this.X1Y2_陰核, this.陰核CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y2_尿道CP = new ColorP(this.X1Y2_尿道, this.尿道CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y2_膣口CP = new ColorP(this.X1Y2_膣口, this.膣口CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y3_小陰唇CP = new ColorP(this.X1Y3_小陰唇, this.小陰唇CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y3_性器基CP = new ColorP(this.X1Y3_性器基, this.性器基CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y3_陰核CP = new ColorP(this.X1Y3_陰核, this.陰核CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y3_尿道CP = new ColorP(this.X1Y3_尿道, this.尿道CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y3_膣口CP = new ColorP(this.X1Y3_膣口, this.膣口CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y4_小陰唇CP = new ColorP(this.X1Y4_小陰唇, this.小陰唇CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y4_性器基CP = new ColorP(this.X1Y4_性器基, this.性器基CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y4_陰核CP = new ColorP(this.X1Y4_陰核, this.陰核CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y4_尿道CP = new ColorP(this.X1Y4_尿道, this.尿道CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y4_膣口CP = new ColorP(this.X1Y4_膣口, this.膣口CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y5_小陰唇CP = new ColorP(this.X1Y5_小陰唇, this.小陰唇CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y5_性器基CP = new ColorP(this.X1Y5_性器基, this.性器基CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y5_陰核CP = new ColorP(this.X1Y5_陰核, this.陰核CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y5_尿道CP = new ColorP(this.X1Y5_尿道, this.尿道CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y5_膣口CP = new ColorP(this.X1Y5_膣口, this.膣口CD, CS$<>8__locals1.DisUnit, true);
			this.X2Y0_小陰唇CP = new ColorP(this.X2Y0_小陰唇, this.小陰唇CD, CS$<>8__locals1.DisUnit, true);
			this.X2Y0_性器基CP = new ColorP(this.X2Y0_性器基, this.性器基CD, CS$<>8__locals1.DisUnit, true);
			this.X2Y0_陰核CP = new ColorP(this.X2Y0_陰核, this.陰核CD, CS$<>8__locals1.DisUnit, true);
			this.X2Y0_尿道CP = new ColorP(this.X2Y0_尿道, this.尿道CD, CS$<>8__locals1.DisUnit, true);
			this.X2Y0_膣口CP = new ColorP(this.X2Y0_膣口, this.膣口CD, CS$<>8__locals1.DisUnit, true);
			this.X2Y1_小陰唇CP = new ColorP(this.X2Y1_小陰唇, this.小陰唇CD, CS$<>8__locals1.DisUnit, true);
			this.X2Y1_性器基CP = new ColorP(this.X2Y1_性器基, this.性器基CD, CS$<>8__locals1.DisUnit, true);
			this.X2Y1_陰核CP = new ColorP(this.X2Y1_陰核, this.陰核CD, CS$<>8__locals1.DisUnit, true);
			this.X2Y1_尿道CP = new ColorP(this.X2Y1_尿道, this.尿道CD, CS$<>8__locals1.DisUnit, true);
			this.X2Y1_膣口CP = new ColorP(this.X2Y1_膣口, this.膣口CD, CS$<>8__locals1.DisUnit, true);
			this.X2Y2_小陰唇CP = new ColorP(this.X2Y2_小陰唇, this.小陰唇CD, CS$<>8__locals1.DisUnit, true);
			this.X2Y2_性器基CP = new ColorP(this.X2Y2_性器基, this.性器基CD, CS$<>8__locals1.DisUnit, true);
			this.X2Y2_陰核CP = new ColorP(this.X2Y2_陰核, this.陰核CD, CS$<>8__locals1.DisUnit, true);
			this.X2Y2_尿道CP = new ColorP(this.X2Y2_尿道, this.尿道CD, CS$<>8__locals1.DisUnit, true);
			this.X2Y2_膣口CP = new ColorP(this.X2Y2_膣口, this.膣口CD, CS$<>8__locals1.DisUnit, true);
			this.X2Y3_小陰唇CP = new ColorP(this.X2Y3_小陰唇, this.小陰唇CD, CS$<>8__locals1.DisUnit, true);
			this.X2Y3_性器基CP = new ColorP(this.X2Y3_性器基, this.性器基CD, CS$<>8__locals1.DisUnit, true);
			this.X2Y3_陰核CP = new ColorP(this.X2Y3_陰核, this.陰核CD, CS$<>8__locals1.DisUnit, true);
			this.X2Y3_尿道CP = new ColorP(this.X2Y3_尿道, this.尿道CD, CS$<>8__locals1.DisUnit, true);
			this.X2Y3_膣口CP = new ColorP(this.X2Y3_膣口, this.膣口CD, CS$<>8__locals1.DisUnit, true);
			this.X2Y4_小陰唇CP = new ColorP(this.X2Y4_小陰唇, this.小陰唇CD, CS$<>8__locals1.DisUnit, true);
			this.X2Y4_性器基CP = new ColorP(this.X2Y4_性器基, this.性器基CD, CS$<>8__locals1.DisUnit, true);
			this.X2Y4_陰核CP = new ColorP(this.X2Y4_陰核, this.陰核CD, CS$<>8__locals1.DisUnit, true);
			this.X2Y4_尿道CP = new ColorP(this.X2Y4_尿道, this.尿道CD, CS$<>8__locals1.DisUnit, true);
			this.X2Y4_膣口CP = new ColorP(this.X2Y4_膣口, this.膣口CD, CS$<>8__locals1.DisUnit, true);
			this.X2Y5_小陰唇CP = new ColorP(this.X2Y5_小陰唇, this.小陰唇CD, CS$<>8__locals1.DisUnit, true);
			this.X2Y5_性器基CP = new ColorP(this.X2Y5_性器基, this.性器基CD, CS$<>8__locals1.DisUnit, true);
			this.X2Y5_陰核CP = new ColorP(this.X2Y5_陰核, this.陰核CD, CS$<>8__locals1.DisUnit, true);
			this.X2Y5_尿道CP = new ColorP(this.X2Y5_尿道, this.尿道CD, CS$<>8__locals1.DisUnit, true);
			this.X2Y5_膣口CP = new ColorP(this.X2Y5_膣口, this.膣口CD, CS$<>8__locals1.DisUnit, true);
			this.X3Y0_小陰唇CP = new ColorP(this.X3Y0_小陰唇, this.小陰唇CD, CS$<>8__locals1.DisUnit, true);
			this.X3Y0_性器基CP = new ColorP(this.X3Y0_性器基, this.性器基CD, CS$<>8__locals1.DisUnit, true);
			this.X3Y0_陰核CP = new ColorP(this.X3Y0_陰核, this.陰核CD, CS$<>8__locals1.DisUnit, true);
			this.X3Y0_尿道CP = new ColorP(this.X3Y0_尿道, this.尿道CD, CS$<>8__locals1.DisUnit, true);
			this.X3Y0_膣口CP = new ColorP(this.X3Y0_膣口, this.膣口CD, CS$<>8__locals1.DisUnit, true);
			this.X3Y1_小陰唇CP = new ColorP(this.X3Y1_小陰唇, this.小陰唇CD, CS$<>8__locals1.DisUnit, true);
			this.X3Y1_性器基CP = new ColorP(this.X3Y1_性器基, this.性器基CD, CS$<>8__locals1.DisUnit, true);
			this.X3Y1_陰核CP = new ColorP(this.X3Y1_陰核, this.陰核CD, CS$<>8__locals1.DisUnit, true);
			this.X3Y1_尿道CP = new ColorP(this.X3Y1_尿道, this.尿道CD, CS$<>8__locals1.DisUnit, true);
			this.X3Y1_膣口CP = new ColorP(this.X3Y1_膣口, this.膣口CD, CS$<>8__locals1.DisUnit, true);
			this.X3Y2_小陰唇CP = new ColorP(this.X3Y2_小陰唇, this.小陰唇CD, CS$<>8__locals1.DisUnit, true);
			this.X3Y2_性器基CP = new ColorP(this.X3Y2_性器基, this.性器基CD, CS$<>8__locals1.DisUnit, true);
			this.X3Y2_陰核CP = new ColorP(this.X3Y2_陰核, this.陰核CD, CS$<>8__locals1.DisUnit, true);
			this.X3Y2_尿道CP = new ColorP(this.X3Y2_尿道, this.尿道CD, CS$<>8__locals1.DisUnit, true);
			this.X3Y2_膣口CP = new ColorP(this.X3Y2_膣口, this.膣口CD, CS$<>8__locals1.DisUnit, true);
			this.X3Y3_小陰唇CP = new ColorP(this.X3Y3_小陰唇, this.小陰唇CD, CS$<>8__locals1.DisUnit, true);
			this.X3Y3_性器基CP = new ColorP(this.X3Y3_性器基, this.性器基CD, CS$<>8__locals1.DisUnit, true);
			this.X3Y3_陰核CP = new ColorP(this.X3Y3_陰核, this.陰核CD, CS$<>8__locals1.DisUnit, true);
			this.X3Y3_尿道CP = new ColorP(this.X3Y3_尿道, this.尿道CD, CS$<>8__locals1.DisUnit, true);
			this.X3Y3_膣口CP = new ColorP(this.X3Y3_膣口, this.膣口CD, CS$<>8__locals1.DisUnit, true);
			this.X3Y4_小陰唇CP = new ColorP(this.X3Y4_小陰唇, this.小陰唇CD, CS$<>8__locals1.DisUnit, true);
			this.X3Y4_性器基CP = new ColorP(this.X3Y4_性器基, this.性器基CD, CS$<>8__locals1.DisUnit, true);
			this.X3Y4_陰核CP = new ColorP(this.X3Y4_陰核, this.陰核CD, CS$<>8__locals1.DisUnit, true);
			this.X3Y4_尿道CP = new ColorP(this.X3Y4_尿道, this.尿道CD, CS$<>8__locals1.DisUnit, true);
			this.X3Y4_膣口CP = new ColorP(this.X3Y4_膣口, this.膣口CD, CS$<>8__locals1.DisUnit, true);
			this.X3Y5_小陰唇CP = new ColorP(this.X3Y5_小陰唇, this.小陰唇CD, CS$<>8__locals1.DisUnit, true);
			this.X3Y5_性器基CP = new ColorP(this.X3Y5_性器基, this.性器基CD, CS$<>8__locals1.DisUnit, true);
			this.X3Y5_陰核CP = new ColorP(this.X3Y5_陰核, this.陰核CD, CS$<>8__locals1.DisUnit, true);
			this.X3Y5_尿道CP = new ColorP(this.X3Y5_尿道, this.尿道CD, CS$<>8__locals1.DisUnit, true);
			this.X3Y5_膣口CP = new ColorP(this.X3Y5_膣口, this.膣口CD, CS$<>8__locals1.DisUnit, true);
			this.AreM = new AreM(CS$<>8__locals1.Med.Unit, 1.0, 1.0, 0.024, CS$<>8__locals1.Med.DisQuality, CS$<>8__locals1.Med.HitAccuracy, 0.1);
			this.AreM.Setting();
			this.AreM.BasePoint = Shas.中央中央;
			this.AreMPos = this.AreM.GetPosition(ref this.AreM.BasePoint);
			this.濃度 = e.濃度;
			this.Xi = 1;
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

		public bool 小陰唇_表示
		{
			get
			{
				return this.X0Y0_小陰唇.Dra;
			}
			set
			{
				this.X0Y0_小陰唇.Dra = value;
				this.X0Y1_小陰唇.Dra = value;
				this.X0Y2_小陰唇.Dra = value;
				this.X0Y3_小陰唇.Dra = value;
				this.X0Y4_小陰唇.Dra = value;
				this.X0Y5_小陰唇.Dra = value;
				this.X1Y0_小陰唇.Dra = value;
				this.X1Y1_小陰唇.Dra = value;
				this.X1Y2_小陰唇.Dra = value;
				this.X1Y3_小陰唇.Dra = value;
				this.X1Y4_小陰唇.Dra = value;
				this.X1Y5_小陰唇.Dra = value;
				this.X2Y0_小陰唇.Dra = value;
				this.X2Y1_小陰唇.Dra = value;
				this.X2Y2_小陰唇.Dra = value;
				this.X2Y3_小陰唇.Dra = value;
				this.X2Y4_小陰唇.Dra = value;
				this.X2Y5_小陰唇.Dra = value;
				this.X3Y0_小陰唇.Dra = value;
				this.X3Y1_小陰唇.Dra = value;
				this.X3Y2_小陰唇.Dra = value;
				this.X3Y3_小陰唇.Dra = value;
				this.X3Y4_小陰唇.Dra = value;
				this.X3Y5_小陰唇.Dra = value;
				this.X0Y0_小陰唇.Hit = value;
				this.X0Y1_小陰唇.Hit = value;
				this.X0Y2_小陰唇.Hit = value;
				this.X0Y3_小陰唇.Hit = value;
				this.X0Y4_小陰唇.Hit = value;
				this.X0Y5_小陰唇.Hit = value;
				this.X1Y0_小陰唇.Hit = value;
				this.X1Y1_小陰唇.Hit = value;
				this.X1Y2_小陰唇.Hit = value;
				this.X1Y3_小陰唇.Hit = value;
				this.X1Y4_小陰唇.Hit = value;
				this.X1Y5_小陰唇.Hit = value;
				this.X2Y0_小陰唇.Hit = value;
				this.X2Y1_小陰唇.Hit = value;
				this.X2Y2_小陰唇.Hit = value;
				this.X2Y3_小陰唇.Hit = value;
				this.X2Y4_小陰唇.Hit = value;
				this.X2Y5_小陰唇.Hit = value;
				this.X3Y0_小陰唇.Hit = value;
				this.X3Y1_小陰唇.Hit = value;
				this.X3Y2_小陰唇.Hit = value;
				this.X3Y3_小陰唇.Hit = value;
				this.X3Y4_小陰唇.Hit = value;
				this.X3Y5_小陰唇.Hit = value;
			}
		}

		public bool 性器基_表示
		{
			get
			{
				return this.X0Y0_性器基.Dra;
			}
			set
			{
				this.X0Y0_性器基.Dra = value;
				this.X0Y1_性器基.Dra = value;
				this.X0Y2_性器基.Dra = value;
				this.X0Y3_性器基.Dra = value;
				this.X0Y4_性器基.Dra = value;
				this.X0Y5_性器基.Dra = value;
				this.X1Y0_性器基.Dra = value;
				this.X1Y1_性器基.Dra = value;
				this.X1Y2_性器基.Dra = value;
				this.X1Y3_性器基.Dra = value;
				this.X1Y4_性器基.Dra = value;
				this.X1Y5_性器基.Dra = value;
				this.X2Y0_性器基.Dra = value;
				this.X2Y1_性器基.Dra = value;
				this.X2Y2_性器基.Dra = value;
				this.X2Y3_性器基.Dra = value;
				this.X2Y4_性器基.Dra = value;
				this.X2Y5_性器基.Dra = value;
				this.X3Y0_性器基.Dra = value;
				this.X3Y1_性器基.Dra = value;
				this.X3Y2_性器基.Dra = value;
				this.X3Y3_性器基.Dra = value;
				this.X3Y4_性器基.Dra = value;
				this.X3Y5_性器基.Dra = value;
				this.X0Y0_性器基.Hit = value;
				this.X0Y1_性器基.Hit = value;
				this.X0Y2_性器基.Hit = value;
				this.X0Y3_性器基.Hit = value;
				this.X0Y4_性器基.Hit = value;
				this.X0Y5_性器基.Hit = value;
				this.X1Y0_性器基.Hit = value;
				this.X1Y1_性器基.Hit = value;
				this.X1Y2_性器基.Hit = value;
				this.X1Y3_性器基.Hit = value;
				this.X1Y4_性器基.Hit = value;
				this.X1Y5_性器基.Hit = value;
				this.X2Y0_性器基.Hit = value;
				this.X2Y1_性器基.Hit = value;
				this.X2Y2_性器基.Hit = value;
				this.X2Y3_性器基.Hit = value;
				this.X2Y4_性器基.Hit = value;
				this.X2Y5_性器基.Hit = value;
				this.X3Y0_性器基.Hit = value;
				this.X3Y1_性器基.Hit = value;
				this.X3Y2_性器基.Hit = value;
				this.X3Y3_性器基.Hit = value;
				this.X3Y4_性器基.Hit = value;
				this.X3Y5_性器基.Hit = value;
			}
		}

		public bool 陰核_表示
		{
			get
			{
				return this.X0Y0_陰核.Dra;
			}
			set
			{
				this.X0Y0_陰核.Dra = value;
				this.X0Y1_陰核.Dra = value;
				this.X0Y2_陰核.Dra = value;
				this.X0Y3_陰核.Dra = value;
				this.X0Y4_陰核.Dra = value;
				this.X0Y5_陰核.Dra = value;
				this.X1Y0_陰核.Dra = value;
				this.X1Y1_陰核.Dra = value;
				this.X1Y2_陰核.Dra = value;
				this.X1Y3_陰核.Dra = value;
				this.X1Y4_陰核.Dra = value;
				this.X1Y5_陰核.Dra = value;
				this.X2Y0_陰核.Dra = value;
				this.X2Y1_陰核.Dra = value;
				this.X2Y2_陰核.Dra = value;
				this.X2Y3_陰核.Dra = value;
				this.X2Y4_陰核.Dra = value;
				this.X2Y5_陰核.Dra = value;
				this.X3Y0_陰核.Dra = value;
				this.X3Y1_陰核.Dra = value;
				this.X3Y2_陰核.Dra = value;
				this.X3Y3_陰核.Dra = value;
				this.X3Y4_陰核.Dra = value;
				this.X3Y5_陰核.Dra = value;
				this.X0Y0_陰核.Hit = value;
				this.X0Y1_陰核.Hit = value;
				this.X0Y2_陰核.Hit = value;
				this.X0Y3_陰核.Hit = value;
				this.X0Y4_陰核.Hit = value;
				this.X0Y5_陰核.Hit = value;
				this.X1Y0_陰核.Hit = value;
				this.X1Y1_陰核.Hit = value;
				this.X1Y2_陰核.Hit = value;
				this.X1Y3_陰核.Hit = value;
				this.X1Y4_陰核.Hit = value;
				this.X1Y5_陰核.Hit = value;
				this.X2Y0_陰核.Hit = value;
				this.X2Y1_陰核.Hit = value;
				this.X2Y2_陰核.Hit = value;
				this.X2Y3_陰核.Hit = value;
				this.X2Y4_陰核.Hit = value;
				this.X2Y5_陰核.Hit = value;
				this.X3Y0_陰核.Hit = value;
				this.X3Y1_陰核.Hit = value;
				this.X3Y2_陰核.Hit = value;
				this.X3Y3_陰核.Hit = value;
				this.X3Y4_陰核.Hit = value;
				this.X3Y5_陰核.Hit = value;
			}
		}

		public bool 尿道_表示
		{
			get
			{
				return this.X0Y0_尿道.Dra;
			}
			set
			{
				this.X0Y0_尿道.Dra = value;
				this.X0Y1_尿道.Dra = value;
				this.X0Y2_尿道.Dra = value;
				this.X0Y3_尿道.Dra = value;
				this.X0Y4_尿道.Dra = value;
				this.X0Y5_尿道.Dra = value;
				this.X1Y0_尿道.Dra = value;
				this.X1Y1_尿道.Dra = value;
				this.X1Y2_尿道.Dra = value;
				this.X1Y3_尿道.Dra = value;
				this.X1Y4_尿道.Dra = value;
				this.X1Y5_尿道.Dra = value;
				this.X2Y0_尿道.Dra = value;
				this.X2Y1_尿道.Dra = value;
				this.X2Y2_尿道.Dra = value;
				this.X2Y3_尿道.Dra = value;
				this.X2Y4_尿道.Dra = value;
				this.X2Y5_尿道.Dra = value;
				this.X3Y0_尿道.Dra = value;
				this.X3Y1_尿道.Dra = value;
				this.X3Y2_尿道.Dra = value;
				this.X3Y3_尿道.Dra = value;
				this.X3Y4_尿道.Dra = value;
				this.X3Y5_尿道.Dra = value;
				this.X0Y0_尿道.Hit = value;
				this.X0Y1_尿道.Hit = value;
				this.X0Y2_尿道.Hit = value;
				this.X0Y3_尿道.Hit = value;
				this.X0Y4_尿道.Hit = value;
				this.X0Y5_尿道.Hit = value;
				this.X1Y0_尿道.Hit = value;
				this.X1Y1_尿道.Hit = value;
				this.X1Y2_尿道.Hit = value;
				this.X1Y3_尿道.Hit = value;
				this.X1Y4_尿道.Hit = value;
				this.X1Y5_尿道.Hit = value;
				this.X2Y0_尿道.Hit = value;
				this.X2Y1_尿道.Hit = value;
				this.X2Y2_尿道.Hit = value;
				this.X2Y3_尿道.Hit = value;
				this.X2Y4_尿道.Hit = value;
				this.X2Y5_尿道.Hit = value;
				this.X3Y0_尿道.Hit = value;
				this.X3Y1_尿道.Hit = value;
				this.X3Y2_尿道.Hit = value;
				this.X3Y3_尿道.Hit = value;
				this.X3Y4_尿道.Hit = value;
				this.X3Y5_尿道.Hit = value;
			}
		}

		public bool 膣口_表示
		{
			get
			{
				return this.X0Y0_膣口.Dra;
			}
			set
			{
				this.X0Y0_膣口.Dra = value;
				this.X0Y1_膣口.Dra = value;
				this.X0Y2_膣口.Dra = value;
				this.X0Y3_膣口.Dra = value;
				this.X0Y4_膣口.Dra = value;
				this.X0Y5_膣口.Dra = value;
				this.X1Y0_膣口.Dra = value;
				this.X1Y1_膣口.Dra = value;
				this.X1Y2_膣口.Dra = value;
				this.X1Y3_膣口.Dra = value;
				this.X1Y4_膣口.Dra = value;
				this.X1Y5_膣口.Dra = value;
				this.X2Y0_膣口.Dra = value;
				this.X2Y1_膣口.Dra = value;
				this.X2Y2_膣口.Dra = value;
				this.X2Y3_膣口.Dra = value;
				this.X2Y4_膣口.Dra = value;
				this.X2Y5_膣口.Dra = value;
				this.X3Y0_膣口.Dra = value;
				this.X3Y1_膣口.Dra = value;
				this.X3Y2_膣口.Dra = value;
				this.X3Y3_膣口.Dra = value;
				this.X3Y4_膣口.Dra = value;
				this.X3Y5_膣口.Dra = value;
				this.X0Y0_膣口.Hit = value;
				this.X0Y1_膣口.Hit = value;
				this.X0Y2_膣口.Hit = value;
				this.X0Y3_膣口.Hit = value;
				this.X0Y4_膣口.Hit = value;
				this.X0Y5_膣口.Hit = value;
				this.X1Y0_膣口.Hit = value;
				this.X1Y1_膣口.Hit = value;
				this.X1Y2_膣口.Hit = value;
				this.X1Y3_膣口.Hit = value;
				this.X1Y4_膣口.Hit = value;
				this.X1Y5_膣口.Hit = value;
				this.X2Y0_膣口.Hit = value;
				this.X2Y1_膣口.Hit = value;
				this.X2Y2_膣口.Hit = value;
				this.X2Y3_膣口.Hit = value;
				this.X2Y4_膣口.Hit = value;
				this.X2Y5_膣口.Hit = value;
				this.X3Y0_膣口.Hit = value;
				this.X3Y1_膣口.Hit = value;
				this.X3Y2_膣口.Hit = value;
				this.X3Y3_膣口.Hit = value;
				this.X3Y4_膣口.Hit = value;
				this.X3Y5_膣口.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.小陰唇_表示;
			}
			set
			{
				this.小陰唇_表示 = value;
				this.性器基_表示 = value;
				this.陰核_表示 = value;
				this.尿道_表示 = value;
				this.膣口_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.小陰唇CD.不透明度;
			}
			set
			{
				this.小陰唇CD.不透明度 = value;
				this.性器基CD.不透明度 = value;
				this.陰核CD.不透明度 = value;
				this.尿道CD.不透明度 = value;
				this.膣口CD.不透明度 = value;
			}
		}

		private void AreMSetPos()
		{
			this.p = this.接続根.Difs0.Current.GetPar(this.接続根.Path0);
			this.AreM.Position = this.p.ToGlobal(this.p.JP[this.接続根.Index].Joint);
		}

		public override void Dispose()
		{
			base.Dispose();
			this.AreM.Dispose();
		}

		public override void 描画0(Are Are)
		{
			this.AreM.Clear();
			this.位置B = this.AreMPos;
			this.本体.Draw(this.AreM);
			Are.Draw(this.AreM);
		}

		public override void 接続P()
		{
			this.接続根.JoinP();
			this.AreMSetPos();
		}

		public override void 接続PA()
		{
			this.接続根.JoinPA();
			this.AreMSetPos();
		}

		public override double くぱぁ
		{
			get
			{
				return this.くぱぁ_;
			}
			set
			{
				this.くぱぁ_ = value;
				this.尺度XC = 0.3 + 0.7 * this.くぱぁ_;
			}
		}

		public JointS 陰核_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_性器基, 0);
			}
		}

		public JointS 尿道_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_性器基, 1);
			}
		}

		public JointS 膣口_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_性器基, 2);
			}
		}

		public override void 色更新()
		{
			switch (this.本体.IndexX)
			{
			case 0:
				switch (this.本体.IndexY)
				{
				case 0:
					this.X0Y0_小陰唇CP.Update();
					this.X0Y0_性器基CP.Update();
					this.X0Y0_陰核CP.Update();
					this.X0Y0_尿道CP.Update();
					this.X0Y0_膣口CP.Update();
					return;
				case 1:
					this.X0Y1_小陰唇CP.Update();
					this.X0Y1_性器基CP.Update();
					this.X0Y1_陰核CP.Update();
					this.X0Y1_尿道CP.Update();
					this.X0Y1_膣口CP.Update();
					return;
				case 2:
					this.X0Y2_小陰唇CP.Update();
					this.X0Y2_性器基CP.Update();
					this.X0Y2_陰核CP.Update();
					this.X0Y2_尿道CP.Update();
					this.X0Y2_膣口CP.Update();
					return;
				case 3:
					this.X0Y3_小陰唇CP.Update();
					this.X0Y3_性器基CP.Update();
					this.X0Y3_陰核CP.Update();
					this.X0Y3_尿道CP.Update();
					this.X0Y3_膣口CP.Update();
					return;
				case 4:
					this.X0Y4_小陰唇CP.Update();
					this.X0Y4_性器基CP.Update();
					this.X0Y4_陰核CP.Update();
					this.X0Y4_尿道CP.Update();
					this.X0Y4_膣口CP.Update();
					return;
				default:
					this.X0Y5_小陰唇CP.Update();
					this.X0Y5_性器基CP.Update();
					this.X0Y5_陰核CP.Update();
					this.X0Y5_尿道CP.Update();
					this.X0Y5_膣口CP.Update();
					return;
				}
				break;
			case 1:
				switch (this.本体.IndexY)
				{
				case 0:
					this.X1Y0_小陰唇CP.Update();
					this.X1Y0_性器基CP.Update();
					this.X1Y0_陰核CP.Update();
					this.X1Y0_尿道CP.Update();
					this.X1Y0_膣口CP.Update();
					return;
				case 1:
					this.X1Y1_小陰唇CP.Update();
					this.X1Y1_性器基CP.Update();
					this.X1Y1_陰核CP.Update();
					this.X1Y1_尿道CP.Update();
					this.X1Y1_膣口CP.Update();
					return;
				case 2:
					this.X1Y2_小陰唇CP.Update();
					this.X1Y2_性器基CP.Update();
					this.X1Y2_陰核CP.Update();
					this.X1Y2_尿道CP.Update();
					this.X1Y2_膣口CP.Update();
					return;
				case 3:
					this.X1Y3_小陰唇CP.Update();
					this.X1Y3_性器基CP.Update();
					this.X1Y3_陰核CP.Update();
					this.X1Y3_尿道CP.Update();
					this.X1Y3_膣口CP.Update();
					return;
				case 4:
					this.X1Y4_小陰唇CP.Update();
					this.X1Y4_性器基CP.Update();
					this.X1Y4_陰核CP.Update();
					this.X1Y4_尿道CP.Update();
					this.X1Y4_膣口CP.Update();
					return;
				default:
					this.X1Y5_小陰唇CP.Update();
					this.X1Y5_性器基CP.Update();
					this.X1Y5_陰核CP.Update();
					this.X1Y5_尿道CP.Update();
					this.X1Y5_膣口CP.Update();
					return;
				}
				break;
			case 2:
				switch (this.本体.IndexY)
				{
				case 0:
					this.X2Y0_小陰唇CP.Update();
					this.X2Y0_性器基CP.Update();
					this.X2Y0_陰核CP.Update();
					this.X2Y0_尿道CP.Update();
					this.X2Y0_膣口CP.Update();
					return;
				case 1:
					this.X2Y1_小陰唇CP.Update();
					this.X2Y1_性器基CP.Update();
					this.X2Y1_陰核CP.Update();
					this.X2Y1_尿道CP.Update();
					this.X2Y1_膣口CP.Update();
					return;
				case 2:
					this.X2Y2_小陰唇CP.Update();
					this.X2Y2_性器基CP.Update();
					this.X2Y2_陰核CP.Update();
					this.X2Y2_尿道CP.Update();
					this.X2Y2_膣口CP.Update();
					return;
				case 3:
					this.X2Y3_小陰唇CP.Update();
					this.X2Y3_性器基CP.Update();
					this.X2Y3_陰核CP.Update();
					this.X2Y3_尿道CP.Update();
					this.X2Y3_膣口CP.Update();
					return;
				case 4:
					this.X2Y4_小陰唇CP.Update();
					this.X2Y4_性器基CP.Update();
					this.X2Y4_陰核CP.Update();
					this.X2Y4_尿道CP.Update();
					this.X2Y4_膣口CP.Update();
					return;
				default:
					this.X2Y5_小陰唇CP.Update();
					this.X2Y5_性器基CP.Update();
					this.X2Y5_陰核CP.Update();
					this.X2Y5_尿道CP.Update();
					this.X2Y5_膣口CP.Update();
					return;
				}
				break;
			default:
				switch (this.本体.IndexY)
				{
				case 0:
					this.X3Y0_小陰唇CP.Update();
					this.X3Y0_性器基CP.Update();
					this.X3Y0_陰核CP.Update();
					this.X3Y0_尿道CP.Update();
					this.X3Y0_膣口CP.Update();
					return;
				case 1:
					this.X3Y1_小陰唇CP.Update();
					this.X3Y1_性器基CP.Update();
					this.X3Y1_陰核CP.Update();
					this.X3Y1_尿道CP.Update();
					this.X3Y1_膣口CP.Update();
					return;
				case 2:
					this.X3Y2_小陰唇CP.Update();
					this.X3Y2_性器基CP.Update();
					this.X3Y2_陰核CP.Update();
					this.X3Y2_尿道CP.Update();
					this.X3Y2_膣口CP.Update();
					return;
				case 3:
					this.X3Y3_小陰唇CP.Update();
					this.X3Y3_性器基CP.Update();
					this.X3Y3_陰核CP.Update();
					this.X3Y3_尿道CP.Update();
					this.X3Y3_膣口CP.Update();
					return;
				case 4:
					this.X3Y4_小陰唇CP.Update();
					this.X3Y4_性器基CP.Update();
					this.X3Y4_陰核CP.Update();
					this.X3Y4_尿道CP.Update();
					this.X3Y4_膣口CP.Update();
					return;
				default:
					this.X3Y5_小陰唇CP.Update();
					this.X3Y5_性器基CP.Update();
					this.X3Y5_陰核CP.Update();
					this.X3Y5_尿道CP.Update();
					this.X3Y5_膣口CP.Update();
					return;
				}
				break;
			}
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.小陰唇CD = new ColorD(ref 体配色.粘膜線, ref 体配色.粘膜);
			this.性器基CD = new ColorD(ref 体配色.粘膜線, ref 体配色.粘膜);
			this.陰核CD = new ColorD(ref 体配色.粘膜線, ref 体配色.粘膜);
			this.尿道CD = new ColorD(ref 体配色.粘膜線, ref 体配色.粘膜穴);
			this.膣口CD = new ColorD(ref 体配色.粘膜線, ref 体配色.粘膜穴);
		}

		public Par X0Y0_小陰唇;

		public Par X0Y0_性器基;

		public Par X0Y0_陰核;

		public Par X0Y0_尿道;

		public Par X0Y0_膣口;

		public Par X0Y1_小陰唇;

		public Par X0Y1_性器基;

		public Par X0Y1_陰核;

		public Par X0Y1_尿道;

		public Par X0Y1_膣口;

		public Par X0Y2_小陰唇;

		public Par X0Y2_性器基;

		public Par X0Y2_陰核;

		public Par X0Y2_尿道;

		public Par X0Y2_膣口;

		public Par X0Y3_小陰唇;

		public Par X0Y3_性器基;

		public Par X0Y3_陰核;

		public Par X0Y3_尿道;

		public Par X0Y3_膣口;

		public Par X0Y4_小陰唇;

		public Par X0Y4_性器基;

		public Par X0Y4_陰核;

		public Par X0Y4_尿道;

		public Par X0Y4_膣口;

		public Par X0Y5_小陰唇;

		public Par X0Y5_性器基;

		public Par X0Y5_陰核;

		public Par X0Y5_尿道;

		public Par X0Y5_膣口;

		public Par X1Y0_小陰唇;

		public Par X1Y0_性器基;

		public Par X1Y0_陰核;

		public Par X1Y0_尿道;

		public Par X1Y0_膣口;

		public Par X1Y1_小陰唇;

		public Par X1Y1_性器基;

		public Par X1Y1_陰核;

		public Par X1Y1_尿道;

		public Par X1Y1_膣口;

		public Par X1Y2_小陰唇;

		public Par X1Y2_性器基;

		public Par X1Y2_陰核;

		public Par X1Y2_尿道;

		public Par X1Y2_膣口;

		public Par X1Y3_小陰唇;

		public Par X1Y3_性器基;

		public Par X1Y3_陰核;

		public Par X1Y3_尿道;

		public Par X1Y3_膣口;

		public Par X1Y4_小陰唇;

		public Par X1Y4_性器基;

		public Par X1Y4_陰核;

		public Par X1Y4_尿道;

		public Par X1Y4_膣口;

		public Par X1Y5_小陰唇;

		public Par X1Y5_性器基;

		public Par X1Y5_陰核;

		public Par X1Y5_尿道;

		public Par X1Y5_膣口;

		public Par X2Y0_小陰唇;

		public Par X2Y0_性器基;

		public Par X2Y0_陰核;

		public Par X2Y0_尿道;

		public Par X2Y0_膣口;

		public Par X2Y1_小陰唇;

		public Par X2Y1_性器基;

		public Par X2Y1_陰核;

		public Par X2Y1_尿道;

		public Par X2Y1_膣口;

		public Par X2Y2_小陰唇;

		public Par X2Y2_性器基;

		public Par X2Y2_陰核;

		public Par X2Y2_尿道;

		public Par X2Y2_膣口;

		public Par X2Y3_小陰唇;

		public Par X2Y3_性器基;

		public Par X2Y3_陰核;

		public Par X2Y3_尿道;

		public Par X2Y3_膣口;

		public Par X2Y4_小陰唇;

		public Par X2Y4_性器基;

		public Par X2Y4_陰核;

		public Par X2Y4_尿道;

		public Par X2Y4_膣口;

		public Par X2Y5_小陰唇;

		public Par X2Y5_性器基;

		public Par X2Y5_陰核;

		public Par X2Y5_尿道;

		public Par X2Y5_膣口;

		public Par X3Y0_小陰唇;

		public Par X3Y0_性器基;

		public Par X3Y0_陰核;

		public Par X3Y0_尿道;

		public Par X3Y0_膣口;

		public Par X3Y1_小陰唇;

		public Par X3Y1_性器基;

		public Par X3Y1_陰核;

		public Par X3Y1_尿道;

		public Par X3Y1_膣口;

		public Par X3Y2_小陰唇;

		public Par X3Y2_性器基;

		public Par X3Y2_陰核;

		public Par X3Y2_尿道;

		public Par X3Y2_膣口;

		public Par X3Y3_小陰唇;

		public Par X3Y3_性器基;

		public Par X3Y3_陰核;

		public Par X3Y3_尿道;

		public Par X3Y3_膣口;

		public Par X3Y4_小陰唇;

		public Par X3Y4_性器基;

		public Par X3Y4_陰核;

		public Par X3Y4_尿道;

		public Par X3Y4_膣口;

		public Par X3Y5_小陰唇;

		public Par X3Y5_性器基;

		public Par X3Y5_陰核;

		public Par X3Y5_尿道;

		public Par X3Y5_膣口;

		public AreM AreM;

		private Vector2D AreMPos;

		public ColorD 小陰唇CD;

		public ColorD 性器基CD;

		public ColorD 陰核CD;

		public ColorD 尿道CD;

		public ColorD 膣口CD;

		public ColorP X0Y0_小陰唇CP;

		public ColorP X0Y0_性器基CP;

		public ColorP X0Y0_陰核CP;

		public ColorP X0Y0_尿道CP;

		public ColorP X0Y0_膣口CP;

		public ColorP X0Y1_小陰唇CP;

		public ColorP X0Y1_性器基CP;

		public ColorP X0Y1_陰核CP;

		public ColorP X0Y1_尿道CP;

		public ColorP X0Y1_膣口CP;

		public ColorP X0Y2_小陰唇CP;

		public ColorP X0Y2_性器基CP;

		public ColorP X0Y2_陰核CP;

		public ColorP X0Y2_尿道CP;

		public ColorP X0Y2_膣口CP;

		public ColorP X0Y3_小陰唇CP;

		public ColorP X0Y3_性器基CP;

		public ColorP X0Y3_陰核CP;

		public ColorP X0Y3_尿道CP;

		public ColorP X0Y3_膣口CP;

		public ColorP X0Y4_小陰唇CP;

		public ColorP X0Y4_性器基CP;

		public ColorP X0Y4_陰核CP;

		public ColorP X0Y4_尿道CP;

		public ColorP X0Y4_膣口CP;

		public ColorP X0Y5_小陰唇CP;

		public ColorP X0Y5_性器基CP;

		public ColorP X0Y5_陰核CP;

		public ColorP X0Y5_尿道CP;

		public ColorP X0Y5_膣口CP;

		public ColorP X1Y0_小陰唇CP;

		public ColorP X1Y0_性器基CP;

		public ColorP X1Y0_陰核CP;

		public ColorP X1Y0_尿道CP;

		public ColorP X1Y0_膣口CP;

		public ColorP X1Y1_小陰唇CP;

		public ColorP X1Y1_性器基CP;

		public ColorP X1Y1_陰核CP;

		public ColorP X1Y1_尿道CP;

		public ColorP X1Y1_膣口CP;

		public ColorP X1Y2_小陰唇CP;

		public ColorP X1Y2_性器基CP;

		public ColorP X1Y2_陰核CP;

		public ColorP X1Y2_尿道CP;

		public ColorP X1Y2_膣口CP;

		public ColorP X1Y3_小陰唇CP;

		public ColorP X1Y3_性器基CP;

		public ColorP X1Y3_陰核CP;

		public ColorP X1Y3_尿道CP;

		public ColorP X1Y3_膣口CP;

		public ColorP X1Y4_小陰唇CP;

		public ColorP X1Y4_性器基CP;

		public ColorP X1Y4_陰核CP;

		public ColorP X1Y4_尿道CP;

		public ColorP X1Y4_膣口CP;

		public ColorP X1Y5_小陰唇CP;

		public ColorP X1Y5_性器基CP;

		public ColorP X1Y5_陰核CP;

		public ColorP X1Y5_尿道CP;

		public ColorP X1Y5_膣口CP;

		public ColorP X2Y0_小陰唇CP;

		public ColorP X2Y0_性器基CP;

		public ColorP X2Y0_陰核CP;

		public ColorP X2Y0_尿道CP;

		public ColorP X2Y0_膣口CP;

		public ColorP X2Y1_小陰唇CP;

		public ColorP X2Y1_性器基CP;

		public ColorP X2Y1_陰核CP;

		public ColorP X2Y1_尿道CP;

		public ColorP X2Y1_膣口CP;

		public ColorP X2Y2_小陰唇CP;

		public ColorP X2Y2_性器基CP;

		public ColorP X2Y2_陰核CP;

		public ColorP X2Y2_尿道CP;

		public ColorP X2Y2_膣口CP;

		public ColorP X2Y3_小陰唇CP;

		public ColorP X2Y3_性器基CP;

		public ColorP X2Y3_陰核CP;

		public ColorP X2Y3_尿道CP;

		public ColorP X2Y3_膣口CP;

		public ColorP X2Y4_小陰唇CP;

		public ColorP X2Y4_性器基CP;

		public ColorP X2Y4_陰核CP;

		public ColorP X2Y4_尿道CP;

		public ColorP X2Y4_膣口CP;

		public ColorP X2Y5_小陰唇CP;

		public ColorP X2Y5_性器基CP;

		public ColorP X2Y5_陰核CP;

		public ColorP X2Y5_尿道CP;

		public ColorP X2Y5_膣口CP;

		public ColorP X3Y0_小陰唇CP;

		public ColorP X3Y0_性器基CP;

		public ColorP X3Y0_陰核CP;

		public ColorP X3Y0_尿道CP;

		public ColorP X3Y0_膣口CP;

		public ColorP X3Y1_小陰唇CP;

		public ColorP X3Y1_性器基CP;

		public ColorP X3Y1_陰核CP;

		public ColorP X3Y1_尿道CP;

		public ColorP X3Y1_膣口CP;

		public ColorP X3Y2_小陰唇CP;

		public ColorP X3Y2_性器基CP;

		public ColorP X3Y2_陰核CP;

		public ColorP X3Y2_尿道CP;

		public ColorP X3Y2_膣口CP;

		public ColorP X3Y3_小陰唇CP;

		public ColorP X3Y3_性器基CP;

		public ColorP X3Y3_陰核CP;

		public ColorP X3Y3_尿道CP;

		public ColorP X3Y3_膣口CP;

		public ColorP X3Y4_小陰唇CP;

		public ColorP X3Y4_性器基CP;

		public ColorP X3Y4_陰核CP;

		public ColorP X3Y4_尿道CP;

		public ColorP X3Y4_膣口CP;

		public ColorP X3Y5_小陰唇CP;

		public ColorP X3Y5_性器基CP;

		public ColorP X3Y5_陰核CP;

		public ColorP X3Y5_尿道CP;

		public ColorP X3Y5_膣口CP;

		private Par p;

		private double くぱぁ_;

		public Ele[] 陰核_接続;

		public Ele[] 尿道_接続;

		public Ele[] 膣口_接続;
	}
}
