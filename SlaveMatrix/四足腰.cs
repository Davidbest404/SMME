using System;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 四足腰 : Ele
	{
		public 四足腰(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 四足腰D e)
		{
			四足腰.<>c__DisplayClass308_0 CS$<>8__locals1 = new 四足腰.<>c__DisplayClass308_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.半身["四足腰"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_腰 = pars["腰"].ToPar();
			this.X0Y0_股 = pars["股"].ToPar();
			this.X0Y0_下腹 = pars["下腹"].ToPar();
			this.X0Y0_腰皺 = pars["腰皺"].ToPar();
			Pars pars2 = pars["筋肉"].ToPars();
			this.X0Y0_筋肉_筋肉下 = pars2["筋肉下"].ToPar();
			this.X0Y0_筋肉_筋肉左 = pars2["筋肉左"].ToPar();
			this.X0Y0_筋肉_筋肉右 = pars2["筋肉右"].ToPar();
			this.X0Y0_筋肉_筋上左 = pars2["筋上左"].ToPar();
			this.X0Y0_筋肉_筋上右 = pars2["筋上右"].ToPar();
			this.X0Y0_筋肉_筋下左 = pars2["筋下左"].ToPar();
			this.X0Y0_筋肉_筋下右 = pars2["筋下右"].ToPar();
			this.X0Y0_臍 = pars["臍"].ToPar();
			pars2 = pars["紋柄"].ToPars();
			Pars pars3 = pars2["紋左"].ToPars();
			this.X0Y0_紋柄_紋左_紋1 = pars3["紋1"].ToPar();
			this.X0Y0_紋柄_紋左_紋2 = pars3["紋2"].ToPar();
			this.X0Y0_紋柄_紋左_紋3 = pars3["紋3"].ToPar();
			pars3 = pars2["紋右"].ToPars();
			this.X0Y0_紋柄_紋右_紋1 = pars3["紋1"].ToPar();
			this.X0Y0_紋柄_紋右_紋2 = pars3["紋2"].ToPar();
			this.X0Y0_紋柄_紋右_紋3 = pars3["紋3"].ToPar();
			pars2 = pars["虎柄"].ToPars();
			this.X0Y0_虎柄_虎左 = pars2["虎左"].ToPar();
			this.X0Y0_虎柄_虎右 = pars2["虎右"].ToPar();
			pars2 = pars["鱗"].ToPars();
			pars3 = pars2["中"].ToPars();
			this.X0Y0_竜性_中_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_竜性_中_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_竜性_中_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_竜性_中_鱗4 = pars3["鱗4"].ToPar();
			pars3 = pars2["左"].ToPars();
			this.X0Y0_竜性_左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_竜性_左_鱗2 = pars3["鱗2"].ToPar();
			pars3 = pars2["右"].ToPars();
			this.X0Y0_竜性_右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_竜性_右_鱗2 = pars3["鱗2"].ToPar();
			pars = this.本体[0][1];
			this.X0Y1_腰 = pars["腰"].ToPar();
			this.X0Y1_股 = pars["股"].ToPar();
			this.X0Y1_下腹 = pars["下腹"].ToPar();
			this.X0Y1_腰皺 = pars["腰皺"].ToPar();
			pars2 = pars["筋肉"].ToPars();
			this.X0Y1_筋肉_筋肉下 = pars2["筋肉下"].ToPar();
			this.X0Y1_筋肉_筋肉左 = pars2["筋肉左"].ToPar();
			this.X0Y1_筋肉_筋肉右 = pars2["筋肉右"].ToPar();
			this.X0Y1_筋肉_筋上左 = pars2["筋上左"].ToPar();
			this.X0Y1_筋肉_筋上右 = pars2["筋上右"].ToPar();
			this.X0Y1_筋肉_筋下左 = pars2["筋下左"].ToPar();
			this.X0Y1_筋肉_筋下右 = pars2["筋下右"].ToPar();
			this.X0Y1_臍 = pars["臍"].ToPar();
			pars2 = pars["紋柄"].ToPars();
			pars3 = pars2["紋左"].ToPars();
			this.X0Y1_紋柄_紋左_紋1 = pars3["紋1"].ToPar();
			this.X0Y1_紋柄_紋左_紋2 = pars3["紋2"].ToPar();
			this.X0Y1_紋柄_紋左_紋3 = pars3["紋3"].ToPar();
			pars3 = pars2["紋右"].ToPars();
			this.X0Y1_紋柄_紋右_紋1 = pars3["紋1"].ToPar();
			this.X0Y1_紋柄_紋右_紋2 = pars3["紋2"].ToPar();
			this.X0Y1_紋柄_紋右_紋3 = pars3["紋3"].ToPar();
			pars2 = pars["虎柄"].ToPars();
			this.X0Y1_虎柄_虎左 = pars2["虎左"].ToPar();
			this.X0Y1_虎柄_虎右 = pars2["虎右"].ToPar();
			pars2 = pars["鱗"].ToPars();
			pars3 = pars2["中"].ToPars();
			this.X0Y1_竜性_中_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y1_竜性_中_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y1_竜性_中_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y1_竜性_中_鱗4 = pars3["鱗4"].ToPar();
			pars3 = pars2["左"].ToPars();
			this.X0Y1_竜性_左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y1_竜性_左_鱗2 = pars3["鱗2"].ToPar();
			pars3 = pars2["右"].ToPars();
			this.X0Y1_竜性_右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y1_竜性_右_鱗2 = pars3["鱗2"].ToPar();
			pars = this.本体[0][2];
			this.X0Y2_腰 = pars["腰"].ToPar();
			this.X0Y2_股 = pars["股"].ToPar();
			this.X0Y2_下腹 = pars["下腹"].ToPar();
			this.X0Y2_腰皺 = pars["腰皺"].ToPar();
			pars2 = pars["筋肉"].ToPars();
			this.X0Y2_筋肉_筋肉下 = pars2["筋肉下"].ToPar();
			this.X0Y2_筋肉_筋肉左 = pars2["筋肉左"].ToPar();
			this.X0Y2_筋肉_筋肉右 = pars2["筋肉右"].ToPar();
			this.X0Y2_筋肉_筋上左 = pars2["筋上左"].ToPar();
			this.X0Y2_筋肉_筋上右 = pars2["筋上右"].ToPar();
			this.X0Y2_筋肉_筋下左 = pars2["筋下左"].ToPar();
			this.X0Y2_筋肉_筋下右 = pars2["筋下右"].ToPar();
			this.X0Y2_臍 = pars["臍"].ToPar();
			pars2 = pars["紋柄"].ToPars();
			pars3 = pars2["紋左"].ToPars();
			this.X0Y2_紋柄_紋左_紋1 = pars3["紋1"].ToPar();
			this.X0Y2_紋柄_紋左_紋2 = pars3["紋2"].ToPar();
			this.X0Y2_紋柄_紋左_紋3 = pars3["紋3"].ToPar();
			pars3 = pars2["紋右"].ToPars();
			this.X0Y2_紋柄_紋右_紋1 = pars3["紋1"].ToPar();
			this.X0Y2_紋柄_紋右_紋2 = pars3["紋2"].ToPar();
			this.X0Y2_紋柄_紋右_紋3 = pars3["紋3"].ToPar();
			pars2 = pars["虎柄"].ToPars();
			this.X0Y2_虎柄_虎左 = pars2["虎左"].ToPar();
			this.X0Y2_虎柄_虎右 = pars2["虎右"].ToPar();
			pars2 = pars["鱗"].ToPars();
			pars3 = pars2["中"].ToPars();
			this.X0Y2_竜性_中_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y2_竜性_中_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y2_竜性_中_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y2_竜性_中_鱗4 = pars3["鱗4"].ToPar();
			pars3 = pars2["左"].ToPars();
			this.X0Y2_竜性_左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y2_竜性_左_鱗2 = pars3["鱗2"].ToPar();
			pars3 = pars2["右"].ToPars();
			this.X0Y2_竜性_右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y2_竜性_右_鱗2 = pars3["鱗2"].ToPar();
			pars = this.本体[0][3];
			this.X0Y3_腰 = pars["腰"].ToPar();
			this.X0Y3_股 = pars["股"].ToPar();
			this.X0Y3_下腹 = pars["下腹"].ToPar();
			this.X0Y3_腰皺 = pars["腰皺"].ToPar();
			pars2 = pars["筋肉"].ToPars();
			this.X0Y3_筋肉_筋肉下 = pars2["筋肉下"].ToPar();
			this.X0Y3_筋肉_筋肉左 = pars2["筋肉左"].ToPar();
			this.X0Y3_筋肉_筋肉右 = pars2["筋肉右"].ToPar();
			this.X0Y3_筋肉_筋上左 = pars2["筋上左"].ToPar();
			this.X0Y3_筋肉_筋上右 = pars2["筋上右"].ToPar();
			this.X0Y3_筋肉_筋下左 = pars2["筋下左"].ToPar();
			this.X0Y3_筋肉_筋下右 = pars2["筋下右"].ToPar();
			this.X0Y3_臍 = pars["臍"].ToPar();
			pars2 = pars["紋柄"].ToPars();
			pars3 = pars2["紋左"].ToPars();
			this.X0Y3_紋柄_紋左_紋1 = pars3["紋1"].ToPar();
			this.X0Y3_紋柄_紋左_紋2 = pars3["紋2"].ToPar();
			this.X0Y3_紋柄_紋左_紋3 = pars3["紋3"].ToPar();
			pars3 = pars2["紋右"].ToPars();
			this.X0Y3_紋柄_紋右_紋1 = pars3["紋1"].ToPar();
			this.X0Y3_紋柄_紋右_紋2 = pars3["紋2"].ToPar();
			this.X0Y3_紋柄_紋右_紋3 = pars3["紋3"].ToPar();
			pars2 = pars["虎柄"].ToPars();
			this.X0Y3_虎柄_虎左 = pars2["虎左"].ToPar();
			this.X0Y3_虎柄_虎右 = pars2["虎右"].ToPar();
			pars2 = pars["鱗"].ToPars();
			pars3 = pars2["中"].ToPars();
			this.X0Y3_竜性_中_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y3_竜性_中_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y3_竜性_中_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y3_竜性_中_鱗4 = pars3["鱗4"].ToPar();
			pars3 = pars2["左"].ToPars();
			this.X0Y3_竜性_左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y3_竜性_左_鱗2 = pars3["鱗2"].ToPar();
			pars3 = pars2["右"].ToPars();
			this.X0Y3_竜性_右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y3_竜性_右_鱗2 = pars3["鱗2"].ToPar();
			pars = this.本体[0][4];
			this.X0Y4_腰 = pars["腰"].ToPar();
			this.X0Y4_股 = pars["股"].ToPar();
			this.X0Y4_下腹 = pars["下腹"].ToPar();
			this.X0Y4_腰皺 = pars["腰皺"].ToPar();
			pars2 = pars["筋肉"].ToPars();
			this.X0Y4_筋肉_筋肉下 = pars2["筋肉下"].ToPar();
			this.X0Y4_筋肉_筋肉左 = pars2["筋肉左"].ToPar();
			this.X0Y4_筋肉_筋肉右 = pars2["筋肉右"].ToPar();
			this.X0Y4_筋肉_筋上左 = pars2["筋上左"].ToPar();
			this.X0Y4_筋肉_筋上右 = pars2["筋上右"].ToPar();
			this.X0Y4_筋肉_筋下左 = pars2["筋下左"].ToPar();
			this.X0Y4_筋肉_筋下右 = pars2["筋下右"].ToPar();
			this.X0Y4_臍 = pars["臍"].ToPar();
			pars2 = pars["紋柄"].ToPars();
			pars3 = pars2["紋左"].ToPars();
			this.X0Y4_紋柄_紋左_紋1 = pars3["紋1"].ToPar();
			this.X0Y4_紋柄_紋左_紋2 = pars3["紋2"].ToPar();
			this.X0Y4_紋柄_紋左_紋3 = pars3["紋3"].ToPar();
			pars3 = pars2["紋右"].ToPars();
			this.X0Y4_紋柄_紋右_紋1 = pars3["紋1"].ToPar();
			this.X0Y4_紋柄_紋右_紋2 = pars3["紋2"].ToPar();
			this.X0Y4_紋柄_紋右_紋3 = pars3["紋3"].ToPar();
			pars2 = pars["虎柄"].ToPars();
			this.X0Y4_虎柄_虎左 = pars2["虎左"].ToPar();
			this.X0Y4_虎柄_虎右 = pars2["虎右"].ToPar();
			pars2 = pars["鱗"].ToPars();
			pars3 = pars2["中"].ToPars();
			this.X0Y4_竜性_中_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y4_竜性_中_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y4_竜性_中_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y4_竜性_中_鱗4 = pars3["鱗4"].ToPar();
			pars3 = pars2["左"].ToPars();
			this.X0Y4_竜性_左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y4_竜性_左_鱗2 = pars3["鱗2"].ToPar();
			pars3 = pars2["右"].ToPars();
			this.X0Y4_竜性_右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y4_竜性_右_鱗2 = pars3["鱗2"].ToPar();
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
			this.腰_表示 = e.腰_表示;
			this.股_表示 = e.股_表示;
			this.下腹_表示 = e.下腹_表示;
			this.腰皺_表示 = e.腰皺_表示;
			this.筋肉_筋肉下_表示 = e.筋肉_筋肉下_表示;
			this.筋肉_筋肉左_表示 = e.筋肉_筋肉左_表示;
			this.筋肉_筋肉右_表示 = e.筋肉_筋肉右_表示;
			this.筋肉_筋上左_表示 = e.筋肉_筋上左_表示;
			this.筋肉_筋上右_表示 = e.筋肉_筋上右_表示;
			this.筋肉_筋下左_表示 = e.筋肉_筋下左_表示;
			this.筋肉_筋下右_表示 = e.筋肉_筋下右_表示;
			this.臍_表示 = e.臍_表示;
			this.紋柄_紋左_紋1_表示 = e.紋柄_紋左_紋1_表示;
			this.紋柄_紋左_紋2_表示 = e.紋柄_紋左_紋2_表示;
			this.紋柄_紋左_紋3_表示 = e.紋柄_紋左_紋3_表示;
			this.紋柄_紋右_紋1_表示 = e.紋柄_紋右_紋1_表示;
			this.紋柄_紋右_紋2_表示 = e.紋柄_紋右_紋2_表示;
			this.紋柄_紋右_紋3_表示 = e.紋柄_紋右_紋3_表示;
			this.虎柄_虎左_表示 = e.虎柄_虎左_表示;
			this.虎柄_虎右_表示 = e.虎柄_虎右_表示;
			this.竜性_中_鱗1_表示 = e.竜性_中_鱗1_表示;
			this.竜性_中_鱗2_表示 = e.竜性_中_鱗2_表示;
			this.竜性_中_鱗3_表示 = e.竜性_中_鱗3_表示;
			this.竜性_中_鱗4_表示 = e.竜性_中_鱗4_表示;
			this.竜性_左_鱗1_表示 = e.竜性_左_鱗1_表示;
			this.竜性_左_鱗2_表示 = e.竜性_左_鱗2_表示;
			this.竜性_右_鱗1_表示 = e.竜性_右_鱗1_表示;
			this.竜性_右_鱗2_表示 = e.竜性_右_鱗2_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.腿左_接続.Count > 0)
			{
				Ele f;
				this.腿左_接続 = e.腿左_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.四足腰_腿左_接続;
					f.接続(CS$<>8__locals1.<>4__this.腿左_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.腿右_接続.Count > 0)
			{
				Ele f;
				this.腿右_接続 = e.腿右_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.四足腰_腿右_接続;
					f.接続(CS$<>8__locals1.<>4__this.腿右_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.膣基_接続.Count > 0)
			{
				Ele f;
				this.膣基_接続 = e.膣基_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.四足腰_膣基_接続;
					f.接続(CS$<>8__locals1.<>4__this.膣基_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.肛門_接続.Count > 0)
			{
				Ele f;
				this.肛門_接続 = e.肛門_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.四足腰_肛門_接続;
					f.接続(CS$<>8__locals1.<>4__this.肛門_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.尾_接続.Count > 0)
			{
				Ele f;
				this.尾_接続 = e.尾_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.四足腰_尾_接続;
					f.接続(CS$<>8__locals1.<>4__this.尾_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.半身_接続.Count > 0)
			{
				Ele f;
				this.半身_接続 = e.半身_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.四足腰_半身_接続;
					f.接続(CS$<>8__locals1.<>4__this.半身_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.上着_接続.Count > 0)
			{
				Ele f;
				this.上着_接続 = e.上着_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.四足腰_上着_接続;
					f.接続(CS$<>8__locals1.<>4__this.上着_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.肌_接続.Count > 0)
			{
				Ele f;
				this.肌_接続 = e.肌_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.四足腰_肌_接続;
					f.接続(CS$<>8__locals1.<>4__this.肌_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.翼左_接続.Count > 0)
			{
				Ele f;
				this.翼左_接続 = e.翼左_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.四足腰_翼左_接続;
					f.接続(CS$<>8__locals1.<>4__this.翼左_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.翼右_接続.Count > 0)
			{
				Ele f;
				this.翼右_接続 = e.翼右_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.四足腰_翼右_接続;
					f.接続(CS$<>8__locals1.<>4__this.翼右_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_腰CP = new ColorP(this.X0Y0_腰, this.腰CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_股CP = new ColorP(this.X0Y0_股, this.股CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_下腹CP = new ColorP(this.X0Y0_下腹, this.下腹CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_腰皺CP = new ColorP(this.X0Y0_腰皺, this.腰皺CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_筋肉_筋肉下CP = new ColorP(this.X0Y0_筋肉_筋肉下, this.筋肉_筋肉下CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_筋肉_筋肉左CP = new ColorP(this.X0Y0_筋肉_筋肉左, this.筋肉_筋肉左CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_筋肉_筋肉右CP = new ColorP(this.X0Y0_筋肉_筋肉右, this.筋肉_筋肉右CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_筋肉_筋上左CP = new ColorP(this.X0Y0_筋肉_筋上左, this.筋肉_筋上左CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_筋肉_筋上右CP = new ColorP(this.X0Y0_筋肉_筋上右, this.筋肉_筋上右CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_筋肉_筋下左CP = new ColorP(this.X0Y0_筋肉_筋下左, this.筋肉_筋下左CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_筋肉_筋下右CP = new ColorP(this.X0Y0_筋肉_筋下右, this.筋肉_筋下右CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_臍CP = new ColorP(this.X0Y0_臍, this.臍CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_紋柄_紋左_紋1CP = new ColorP(this.X0Y0_紋柄_紋左_紋1, this.紋柄_紋左_紋1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_紋柄_紋左_紋2CP = new ColorP(this.X0Y0_紋柄_紋左_紋2, this.紋柄_紋左_紋2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_紋柄_紋左_紋3CP = new ColorP(this.X0Y0_紋柄_紋左_紋3, this.紋柄_紋左_紋3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_紋柄_紋右_紋1CP = new ColorP(this.X0Y0_紋柄_紋右_紋1, this.紋柄_紋右_紋1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_紋柄_紋右_紋2CP = new ColorP(this.X0Y0_紋柄_紋右_紋2, this.紋柄_紋右_紋2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_紋柄_紋右_紋3CP = new ColorP(this.X0Y0_紋柄_紋右_紋3, this.紋柄_紋右_紋3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虎柄_虎左CP = new ColorP(this.X0Y0_虎柄_虎左, this.虎柄_虎左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虎柄_虎右CP = new ColorP(this.X0Y0_虎柄_虎右, this.虎柄_虎右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_中_鱗1CP = new ColorP(this.X0Y0_竜性_中_鱗1, this.竜性_中_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_中_鱗2CP = new ColorP(this.X0Y0_竜性_中_鱗2, this.竜性_中_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_中_鱗3CP = new ColorP(this.X0Y0_竜性_中_鱗3, this.竜性_中_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_中_鱗4CP = new ColorP(this.X0Y0_竜性_中_鱗4, this.竜性_中_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_左_鱗1CP = new ColorP(this.X0Y0_竜性_左_鱗1, this.竜性_左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_左_鱗2CP = new ColorP(this.X0Y0_竜性_左_鱗2, this.竜性_左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_右_鱗1CP = new ColorP(this.X0Y0_竜性_右_鱗1, this.竜性_右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_右_鱗2CP = new ColorP(this.X0Y0_竜性_右_鱗2, this.竜性_右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_腰CP = new ColorP(this.X0Y1_腰, this.腰CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_股CP = new ColorP(this.X0Y1_股, this.股CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y1_下腹CP = new ColorP(this.X0Y1_下腹, this.下腹CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y1_腰皺CP = new ColorP(this.X0Y1_腰皺, this.腰皺CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y1_筋肉_筋肉下CP = new ColorP(this.X0Y1_筋肉_筋肉下, this.筋肉_筋肉下CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y1_筋肉_筋肉左CP = new ColorP(this.X0Y1_筋肉_筋肉左, this.筋肉_筋肉左CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y1_筋肉_筋肉右CP = new ColorP(this.X0Y1_筋肉_筋肉右, this.筋肉_筋肉右CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y1_筋肉_筋上左CP = new ColorP(this.X0Y1_筋肉_筋上左, this.筋肉_筋上左CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y1_筋肉_筋上右CP = new ColorP(this.X0Y1_筋肉_筋上右, this.筋肉_筋上右CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y1_筋肉_筋下左CP = new ColorP(this.X0Y1_筋肉_筋下左, this.筋肉_筋下左CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y1_筋肉_筋下右CP = new ColorP(this.X0Y1_筋肉_筋下右, this.筋肉_筋下右CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y1_臍CP = new ColorP(this.X0Y1_臍, this.臍CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y1_紋柄_紋左_紋1CP = new ColorP(this.X0Y1_紋柄_紋左_紋1, this.紋柄_紋左_紋1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_紋柄_紋左_紋2CP = new ColorP(this.X0Y1_紋柄_紋左_紋2, this.紋柄_紋左_紋2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_紋柄_紋左_紋3CP = new ColorP(this.X0Y1_紋柄_紋左_紋3, this.紋柄_紋左_紋3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_紋柄_紋右_紋1CP = new ColorP(this.X0Y1_紋柄_紋右_紋1, this.紋柄_紋右_紋1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_紋柄_紋右_紋2CP = new ColorP(this.X0Y1_紋柄_紋右_紋2, this.紋柄_紋右_紋2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_紋柄_紋右_紋3CP = new ColorP(this.X0Y1_紋柄_紋右_紋3, this.紋柄_紋右_紋3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_虎柄_虎左CP = new ColorP(this.X0Y1_虎柄_虎左, this.虎柄_虎左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_虎柄_虎右CP = new ColorP(this.X0Y1_虎柄_虎右, this.虎柄_虎右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_竜性_中_鱗1CP = new ColorP(this.X0Y1_竜性_中_鱗1, this.竜性_中_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_竜性_中_鱗2CP = new ColorP(this.X0Y1_竜性_中_鱗2, this.竜性_中_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_竜性_中_鱗3CP = new ColorP(this.X0Y1_竜性_中_鱗3, this.竜性_中_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_竜性_中_鱗4CP = new ColorP(this.X0Y1_竜性_中_鱗4, this.竜性_中_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_竜性_左_鱗1CP = new ColorP(this.X0Y1_竜性_左_鱗1, this.竜性_左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_竜性_左_鱗2CP = new ColorP(this.X0Y1_竜性_左_鱗2, this.竜性_左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_竜性_右_鱗1CP = new ColorP(this.X0Y1_竜性_右_鱗1, this.竜性_右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_竜性_右_鱗2CP = new ColorP(this.X0Y1_竜性_右_鱗2, this.竜性_右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_腰CP = new ColorP(this.X0Y2_腰, this.腰CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_股CP = new ColorP(this.X0Y2_股, this.股CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y2_下腹CP = new ColorP(this.X0Y2_下腹, this.下腹CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y2_腰皺CP = new ColorP(this.X0Y2_腰皺, this.腰皺CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y2_筋肉_筋肉下CP = new ColorP(this.X0Y2_筋肉_筋肉下, this.筋肉_筋肉下CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y2_筋肉_筋肉左CP = new ColorP(this.X0Y2_筋肉_筋肉左, this.筋肉_筋肉左CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y2_筋肉_筋肉右CP = new ColorP(this.X0Y2_筋肉_筋肉右, this.筋肉_筋肉右CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y2_筋肉_筋上左CP = new ColorP(this.X0Y2_筋肉_筋上左, this.筋肉_筋上左CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y2_筋肉_筋上右CP = new ColorP(this.X0Y2_筋肉_筋上右, this.筋肉_筋上右CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y2_筋肉_筋下左CP = new ColorP(this.X0Y2_筋肉_筋下左, this.筋肉_筋下左CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y2_筋肉_筋下右CP = new ColorP(this.X0Y2_筋肉_筋下右, this.筋肉_筋下右CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y2_臍CP = new ColorP(this.X0Y2_臍, this.臍CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y2_紋柄_紋左_紋1CP = new ColorP(this.X0Y2_紋柄_紋左_紋1, this.紋柄_紋左_紋1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_紋柄_紋左_紋2CP = new ColorP(this.X0Y2_紋柄_紋左_紋2, this.紋柄_紋左_紋2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_紋柄_紋左_紋3CP = new ColorP(this.X0Y2_紋柄_紋左_紋3, this.紋柄_紋左_紋3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_紋柄_紋右_紋1CP = new ColorP(this.X0Y2_紋柄_紋右_紋1, this.紋柄_紋右_紋1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_紋柄_紋右_紋2CP = new ColorP(this.X0Y2_紋柄_紋右_紋2, this.紋柄_紋右_紋2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_紋柄_紋右_紋3CP = new ColorP(this.X0Y2_紋柄_紋右_紋3, this.紋柄_紋右_紋3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_虎柄_虎左CP = new ColorP(this.X0Y2_虎柄_虎左, this.虎柄_虎左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_虎柄_虎右CP = new ColorP(this.X0Y2_虎柄_虎右, this.虎柄_虎右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_竜性_中_鱗1CP = new ColorP(this.X0Y2_竜性_中_鱗1, this.竜性_中_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_竜性_中_鱗2CP = new ColorP(this.X0Y2_竜性_中_鱗2, this.竜性_中_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_竜性_中_鱗3CP = new ColorP(this.X0Y2_竜性_中_鱗3, this.竜性_中_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_竜性_中_鱗4CP = new ColorP(this.X0Y2_竜性_中_鱗4, this.竜性_中_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_竜性_左_鱗1CP = new ColorP(this.X0Y2_竜性_左_鱗1, this.竜性_左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_竜性_左_鱗2CP = new ColorP(this.X0Y2_竜性_左_鱗2, this.竜性_左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_竜性_右_鱗1CP = new ColorP(this.X0Y2_竜性_右_鱗1, this.竜性_右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_竜性_右_鱗2CP = new ColorP(this.X0Y2_竜性_右_鱗2, this.竜性_右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_腰CP = new ColorP(this.X0Y3_腰, this.腰CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_股CP = new ColorP(this.X0Y3_股, this.股CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y3_下腹CP = new ColorP(this.X0Y3_下腹, this.下腹CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y3_腰皺CP = new ColorP(this.X0Y3_腰皺, this.腰皺CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y3_筋肉_筋肉下CP = new ColorP(this.X0Y3_筋肉_筋肉下, this.筋肉_筋肉下CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y3_筋肉_筋肉左CP = new ColorP(this.X0Y3_筋肉_筋肉左, this.筋肉_筋肉左CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y3_筋肉_筋肉右CP = new ColorP(this.X0Y3_筋肉_筋肉右, this.筋肉_筋肉右CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y3_筋肉_筋上左CP = new ColorP(this.X0Y3_筋肉_筋上左, this.筋肉_筋上左CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y3_筋肉_筋上右CP = new ColorP(this.X0Y3_筋肉_筋上右, this.筋肉_筋上右CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y3_筋肉_筋下左CP = new ColorP(this.X0Y3_筋肉_筋下左, this.筋肉_筋下左CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y3_筋肉_筋下右CP = new ColorP(this.X0Y3_筋肉_筋下右, this.筋肉_筋下右CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y3_臍CP = new ColorP(this.X0Y3_臍, this.臍CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y3_紋柄_紋左_紋1CP = new ColorP(this.X0Y3_紋柄_紋左_紋1, this.紋柄_紋左_紋1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_紋柄_紋左_紋2CP = new ColorP(this.X0Y3_紋柄_紋左_紋2, this.紋柄_紋左_紋2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_紋柄_紋左_紋3CP = new ColorP(this.X0Y3_紋柄_紋左_紋3, this.紋柄_紋左_紋3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_紋柄_紋右_紋1CP = new ColorP(this.X0Y3_紋柄_紋右_紋1, this.紋柄_紋右_紋1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_紋柄_紋右_紋2CP = new ColorP(this.X0Y3_紋柄_紋右_紋2, this.紋柄_紋右_紋2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_紋柄_紋右_紋3CP = new ColorP(this.X0Y3_紋柄_紋右_紋3, this.紋柄_紋右_紋3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_虎柄_虎左CP = new ColorP(this.X0Y3_虎柄_虎左, this.虎柄_虎左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_虎柄_虎右CP = new ColorP(this.X0Y3_虎柄_虎右, this.虎柄_虎右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_竜性_中_鱗1CP = new ColorP(this.X0Y3_竜性_中_鱗1, this.竜性_中_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_竜性_中_鱗2CP = new ColorP(this.X0Y3_竜性_中_鱗2, this.竜性_中_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_竜性_中_鱗3CP = new ColorP(this.X0Y3_竜性_中_鱗3, this.竜性_中_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_竜性_中_鱗4CP = new ColorP(this.X0Y3_竜性_中_鱗4, this.竜性_中_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_竜性_左_鱗1CP = new ColorP(this.X0Y3_竜性_左_鱗1, this.竜性_左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_竜性_左_鱗2CP = new ColorP(this.X0Y3_竜性_左_鱗2, this.竜性_左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_竜性_右_鱗1CP = new ColorP(this.X0Y3_竜性_右_鱗1, this.竜性_右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_竜性_右_鱗2CP = new ColorP(this.X0Y3_竜性_右_鱗2, this.竜性_右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_腰CP = new ColorP(this.X0Y4_腰, this.腰CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_股CP = new ColorP(this.X0Y4_股, this.股CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y4_下腹CP = new ColorP(this.X0Y4_下腹, this.下腹CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y4_腰皺CP = new ColorP(this.X0Y4_腰皺, this.腰皺CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y4_筋肉_筋肉下CP = new ColorP(this.X0Y4_筋肉_筋肉下, this.筋肉_筋肉下CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y4_筋肉_筋肉左CP = new ColorP(this.X0Y4_筋肉_筋肉左, this.筋肉_筋肉左CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y4_筋肉_筋肉右CP = new ColorP(this.X0Y4_筋肉_筋肉右, this.筋肉_筋肉右CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y4_筋肉_筋上左CP = new ColorP(this.X0Y4_筋肉_筋上左, this.筋肉_筋上左CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y4_筋肉_筋上右CP = new ColorP(this.X0Y4_筋肉_筋上右, this.筋肉_筋上右CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y4_筋肉_筋下左CP = new ColorP(this.X0Y4_筋肉_筋下左, this.筋肉_筋下左CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y4_筋肉_筋下右CP = new ColorP(this.X0Y4_筋肉_筋下右, this.筋肉_筋下右CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y4_臍CP = new ColorP(this.X0Y4_臍, this.臍CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y4_紋柄_紋左_紋1CP = new ColorP(this.X0Y4_紋柄_紋左_紋1, this.紋柄_紋左_紋1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_紋柄_紋左_紋2CP = new ColorP(this.X0Y4_紋柄_紋左_紋2, this.紋柄_紋左_紋2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_紋柄_紋左_紋3CP = new ColorP(this.X0Y4_紋柄_紋左_紋3, this.紋柄_紋左_紋3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_紋柄_紋右_紋1CP = new ColorP(this.X0Y4_紋柄_紋右_紋1, this.紋柄_紋右_紋1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_紋柄_紋右_紋2CP = new ColorP(this.X0Y4_紋柄_紋右_紋2, this.紋柄_紋右_紋2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_紋柄_紋右_紋3CP = new ColorP(this.X0Y4_紋柄_紋右_紋3, this.紋柄_紋右_紋3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_虎柄_虎左CP = new ColorP(this.X0Y4_虎柄_虎左, this.虎柄_虎左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_虎柄_虎右CP = new ColorP(this.X0Y4_虎柄_虎右, this.虎柄_虎右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_竜性_中_鱗1CP = new ColorP(this.X0Y4_竜性_中_鱗1, this.竜性_中_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_竜性_中_鱗2CP = new ColorP(this.X0Y4_竜性_中_鱗2, this.竜性_中_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_竜性_中_鱗3CP = new ColorP(this.X0Y4_竜性_中_鱗3, this.竜性_中_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_竜性_中_鱗4CP = new ColorP(this.X0Y4_竜性_中_鱗4, this.竜性_中_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_竜性_左_鱗1CP = new ColorP(this.X0Y4_竜性_左_鱗1, this.竜性_左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_竜性_左_鱗2CP = new ColorP(this.X0Y4_竜性_左_鱗2, this.竜性_左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_竜性_右_鱗1CP = new ColorP(this.X0Y4_竜性_右_鱗1, this.竜性_右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_竜性_右_鱗2CP = new ColorP(this.X0Y4_竜性_右_鱗2, this.竜性_右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.筋肉濃度 = e.筋肉濃度;
			this.濃度 = e.濃度;
			this.尺度YB = 0.96;
			this.X0Y0_臍.BasePointBase = new Vector2D(this.X0Y0_臍.BasePointBase.X, 0.363998381176966);
			this.X0Y1_臍.BasePointBase = new Vector2D(this.X0Y1_臍.BasePointBase.X, 0.363099175689868);
			this.X0Y2_臍.BasePointBase = new Vector2D(this.X0Y2_臍.BasePointBase.X, 0.362199970202771);
			this.X0Y3_臍.BasePointBase = new Vector2D(this.X0Y3_臍.BasePointBase.X, 0.361300764715674);
			this.X0Y4_臍.BasePointBase = new Vector2D(this.X0Y4_臍.BasePointBase.X, 0.360401559228577);
			double num = 1.5;
			this.X0Y0_臍.SizeBase *= num;
			this.X0Y1_臍.SizeBase *= num;
			this.X0Y2_臍.SizeBase *= num;
			this.X0Y3_臍.SizeBase *= num;
			this.X0Y4_臍.SizeBase *= num;
			num = 0.6;
			this.X0Y0_臍.SizeXBase *= num;
			this.X0Y1_臍.SizeXBase *= num;
			this.X0Y2_臍.SizeXBase *= num;
			this.X0Y3_臍.SizeXBase *= num;
			this.X0Y4_臍.SizeXBase *= num;
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
				this.筋肉_筋肉下_表示 = this.筋肉_;
				this.筋肉_筋肉左_表示 = this.筋肉_;
				this.筋肉_筋肉右_表示 = this.筋肉_;
				this.筋肉_筋上左_表示 = this.筋肉_;
				this.筋肉_筋上右_表示 = this.筋肉_;
				this.筋肉_筋下左_表示 = this.筋肉_;
				this.筋肉_筋下右_表示 = this.筋肉_;
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

		public bool 腰_表示
		{
			get
			{
				return this.X0Y0_腰.Dra;
			}
			set
			{
				this.X0Y0_腰.Dra = value;
				this.X0Y1_腰.Dra = value;
				this.X0Y2_腰.Dra = value;
				this.X0Y3_腰.Dra = value;
				this.X0Y4_腰.Dra = value;
				this.X0Y0_腰.Hit = value;
				this.X0Y1_腰.Hit = value;
				this.X0Y2_腰.Hit = value;
				this.X0Y3_腰.Hit = value;
				this.X0Y4_腰.Hit = value;
			}
		}

		public bool 股_表示
		{
			get
			{
				return this.X0Y0_股.Dra;
			}
			set
			{
				this.X0Y0_股.Dra = value;
				this.X0Y1_股.Dra = value;
				this.X0Y2_股.Dra = value;
				this.X0Y3_股.Dra = value;
				this.X0Y4_股.Dra = value;
				this.X0Y0_股.Hit = value;
				this.X0Y1_股.Hit = value;
				this.X0Y2_股.Hit = value;
				this.X0Y3_股.Hit = value;
				this.X0Y4_股.Hit = value;
			}
		}

		public bool 下腹_表示
		{
			get
			{
				return this.X0Y0_下腹.Dra;
			}
			set
			{
				this.X0Y0_下腹.Dra = value;
				this.X0Y1_下腹.Dra = value;
				this.X0Y2_下腹.Dra = value;
				this.X0Y3_下腹.Dra = value;
				this.X0Y4_下腹.Dra = value;
				this.X0Y0_下腹.Hit = value;
				this.X0Y1_下腹.Hit = value;
				this.X0Y2_下腹.Hit = value;
				this.X0Y3_下腹.Hit = value;
				this.X0Y4_下腹.Hit = value;
			}
		}

		public bool 腰皺_表示
		{
			get
			{
				return this.X0Y0_腰皺.Dra;
			}
			set
			{
				this.X0Y0_腰皺.Dra = value;
				this.X0Y1_腰皺.Dra = value;
				this.X0Y2_腰皺.Dra = value;
				this.X0Y3_腰皺.Dra = value;
				this.X0Y4_腰皺.Dra = value;
				this.X0Y0_腰皺.Hit = value;
				this.X0Y1_腰皺.Hit = value;
				this.X0Y2_腰皺.Hit = value;
				this.X0Y3_腰皺.Hit = value;
				this.X0Y4_腰皺.Hit = value;
			}
		}

		public bool 筋肉_筋肉下_表示
		{
			get
			{
				return this.X0Y0_筋肉_筋肉下.Dra;
			}
			set
			{
				this.X0Y0_筋肉_筋肉下.Dra = value;
				this.X0Y1_筋肉_筋肉下.Dra = value;
				this.X0Y2_筋肉_筋肉下.Dra = value;
				this.X0Y3_筋肉_筋肉下.Dra = value;
				this.X0Y4_筋肉_筋肉下.Dra = value;
				this.X0Y0_筋肉_筋肉下.Hit = value;
				this.X0Y1_筋肉_筋肉下.Hit = value;
				this.X0Y2_筋肉_筋肉下.Hit = value;
				this.X0Y3_筋肉_筋肉下.Hit = value;
				this.X0Y4_筋肉_筋肉下.Hit = value;
			}
		}

		public bool 筋肉_筋肉左_表示
		{
			get
			{
				return this.X0Y0_筋肉_筋肉左.Dra;
			}
			set
			{
				this.X0Y0_筋肉_筋肉左.Dra = value;
				this.X0Y1_筋肉_筋肉左.Dra = value;
				this.X0Y2_筋肉_筋肉左.Dra = value;
				this.X0Y3_筋肉_筋肉左.Dra = value;
				this.X0Y4_筋肉_筋肉左.Dra = value;
				this.X0Y0_筋肉_筋肉左.Hit = value;
				this.X0Y1_筋肉_筋肉左.Hit = value;
				this.X0Y2_筋肉_筋肉左.Hit = value;
				this.X0Y3_筋肉_筋肉左.Hit = value;
				this.X0Y4_筋肉_筋肉左.Hit = value;
			}
		}

		public bool 筋肉_筋肉右_表示
		{
			get
			{
				return this.X0Y0_筋肉_筋肉右.Dra;
			}
			set
			{
				this.X0Y0_筋肉_筋肉右.Dra = value;
				this.X0Y1_筋肉_筋肉右.Dra = value;
				this.X0Y2_筋肉_筋肉右.Dra = value;
				this.X0Y3_筋肉_筋肉右.Dra = value;
				this.X0Y4_筋肉_筋肉右.Dra = value;
				this.X0Y0_筋肉_筋肉右.Hit = value;
				this.X0Y1_筋肉_筋肉右.Hit = value;
				this.X0Y2_筋肉_筋肉右.Hit = value;
				this.X0Y3_筋肉_筋肉右.Hit = value;
				this.X0Y4_筋肉_筋肉右.Hit = value;
			}
		}

		public bool 筋肉_筋上左_表示
		{
			get
			{
				return this.X0Y0_筋肉_筋上左.Dra;
			}
			set
			{
				this.X0Y0_筋肉_筋上左.Dra = value;
				this.X0Y1_筋肉_筋上左.Dra = value;
				this.X0Y2_筋肉_筋上左.Dra = value;
				this.X0Y3_筋肉_筋上左.Dra = value;
				this.X0Y4_筋肉_筋上左.Dra = value;
				this.X0Y0_筋肉_筋上左.Hit = value;
				this.X0Y1_筋肉_筋上左.Hit = value;
				this.X0Y2_筋肉_筋上左.Hit = value;
				this.X0Y3_筋肉_筋上左.Hit = value;
				this.X0Y4_筋肉_筋上左.Hit = value;
			}
		}

		public bool 筋肉_筋上右_表示
		{
			get
			{
				return this.X0Y0_筋肉_筋上右.Dra;
			}
			set
			{
				this.X0Y0_筋肉_筋上右.Dra = value;
				this.X0Y1_筋肉_筋上右.Dra = value;
				this.X0Y2_筋肉_筋上右.Dra = value;
				this.X0Y3_筋肉_筋上右.Dra = value;
				this.X0Y4_筋肉_筋上右.Dra = value;
				this.X0Y0_筋肉_筋上右.Hit = value;
				this.X0Y1_筋肉_筋上右.Hit = value;
				this.X0Y2_筋肉_筋上右.Hit = value;
				this.X0Y3_筋肉_筋上右.Hit = value;
				this.X0Y4_筋肉_筋上右.Hit = value;
			}
		}

		public bool 筋肉_筋下左_表示
		{
			get
			{
				return this.X0Y0_筋肉_筋下左.Dra;
			}
			set
			{
				this.X0Y0_筋肉_筋下左.Dra = value;
				this.X0Y1_筋肉_筋下左.Dra = value;
				this.X0Y2_筋肉_筋下左.Dra = value;
				this.X0Y3_筋肉_筋下左.Dra = value;
				this.X0Y4_筋肉_筋下左.Dra = value;
				this.X0Y0_筋肉_筋下左.Hit = value;
				this.X0Y1_筋肉_筋下左.Hit = value;
				this.X0Y2_筋肉_筋下左.Hit = value;
				this.X0Y3_筋肉_筋下左.Hit = value;
				this.X0Y4_筋肉_筋下左.Hit = value;
			}
		}

		public bool 筋肉_筋下右_表示
		{
			get
			{
				return this.X0Y0_筋肉_筋下右.Dra;
			}
			set
			{
				this.X0Y0_筋肉_筋下右.Dra = value;
				this.X0Y1_筋肉_筋下右.Dra = value;
				this.X0Y2_筋肉_筋下右.Dra = value;
				this.X0Y3_筋肉_筋下右.Dra = value;
				this.X0Y4_筋肉_筋下右.Dra = value;
				this.X0Y0_筋肉_筋下右.Hit = value;
				this.X0Y1_筋肉_筋下右.Hit = value;
				this.X0Y2_筋肉_筋下右.Hit = value;
				this.X0Y3_筋肉_筋下右.Hit = value;
				this.X0Y4_筋肉_筋下右.Hit = value;
			}
		}

		public bool 臍_表示
		{
			get
			{
				return this.X0Y0_臍.Dra;
			}
			set
			{
				this.X0Y0_臍.Dra = value;
				this.X0Y1_臍.Dra = value;
				this.X0Y2_臍.Dra = value;
				this.X0Y3_臍.Dra = value;
				this.X0Y4_臍.Dra = value;
				this.X0Y0_臍.Hit = value;
				this.X0Y1_臍.Hit = value;
				this.X0Y2_臍.Hit = value;
				this.X0Y3_臍.Hit = value;
				this.X0Y4_臍.Hit = value;
			}
		}

		public bool 紋柄_紋左_紋1_表示
		{
			get
			{
				return this.X0Y0_紋柄_紋左_紋1.Dra;
			}
			set
			{
				this.X0Y0_紋柄_紋左_紋1.Dra = value;
				this.X0Y1_紋柄_紋左_紋1.Dra = value;
				this.X0Y2_紋柄_紋左_紋1.Dra = value;
				this.X0Y3_紋柄_紋左_紋1.Dra = value;
				this.X0Y4_紋柄_紋左_紋1.Dra = value;
				this.X0Y0_紋柄_紋左_紋1.Hit = value;
				this.X0Y1_紋柄_紋左_紋1.Hit = value;
				this.X0Y2_紋柄_紋左_紋1.Hit = value;
				this.X0Y3_紋柄_紋左_紋1.Hit = value;
				this.X0Y4_紋柄_紋左_紋1.Hit = value;
			}
		}

		public bool 紋柄_紋左_紋2_表示
		{
			get
			{
				return this.X0Y0_紋柄_紋左_紋2.Dra;
			}
			set
			{
				this.X0Y0_紋柄_紋左_紋2.Dra = value;
				this.X0Y1_紋柄_紋左_紋2.Dra = value;
				this.X0Y2_紋柄_紋左_紋2.Dra = value;
				this.X0Y3_紋柄_紋左_紋2.Dra = value;
				this.X0Y4_紋柄_紋左_紋2.Dra = value;
				this.X0Y0_紋柄_紋左_紋2.Hit = value;
				this.X0Y1_紋柄_紋左_紋2.Hit = value;
				this.X0Y2_紋柄_紋左_紋2.Hit = value;
				this.X0Y3_紋柄_紋左_紋2.Hit = value;
				this.X0Y4_紋柄_紋左_紋2.Hit = value;
			}
		}

		public bool 紋柄_紋左_紋3_表示
		{
			get
			{
				return this.X0Y0_紋柄_紋左_紋3.Dra;
			}
			set
			{
				this.X0Y0_紋柄_紋左_紋3.Dra = value;
				this.X0Y1_紋柄_紋左_紋3.Dra = value;
				this.X0Y2_紋柄_紋左_紋3.Dra = value;
				this.X0Y3_紋柄_紋左_紋3.Dra = value;
				this.X0Y4_紋柄_紋左_紋3.Dra = value;
				this.X0Y0_紋柄_紋左_紋3.Hit = value;
				this.X0Y1_紋柄_紋左_紋3.Hit = value;
				this.X0Y2_紋柄_紋左_紋3.Hit = value;
				this.X0Y3_紋柄_紋左_紋3.Hit = value;
				this.X0Y4_紋柄_紋左_紋3.Hit = value;
			}
		}

		public bool 紋柄_紋右_紋1_表示
		{
			get
			{
				return this.X0Y0_紋柄_紋右_紋1.Dra;
			}
			set
			{
				this.X0Y0_紋柄_紋右_紋1.Dra = value;
				this.X0Y1_紋柄_紋右_紋1.Dra = value;
				this.X0Y2_紋柄_紋右_紋1.Dra = value;
				this.X0Y3_紋柄_紋右_紋1.Dra = value;
				this.X0Y4_紋柄_紋右_紋1.Dra = value;
				this.X0Y0_紋柄_紋右_紋1.Hit = value;
				this.X0Y1_紋柄_紋右_紋1.Hit = value;
				this.X0Y2_紋柄_紋右_紋1.Hit = value;
				this.X0Y3_紋柄_紋右_紋1.Hit = value;
				this.X0Y4_紋柄_紋右_紋1.Hit = value;
			}
		}

		public bool 紋柄_紋右_紋2_表示
		{
			get
			{
				return this.X0Y0_紋柄_紋右_紋2.Dra;
			}
			set
			{
				this.X0Y0_紋柄_紋右_紋2.Dra = value;
				this.X0Y1_紋柄_紋右_紋2.Dra = value;
				this.X0Y2_紋柄_紋右_紋2.Dra = value;
				this.X0Y3_紋柄_紋右_紋2.Dra = value;
				this.X0Y4_紋柄_紋右_紋2.Dra = value;
				this.X0Y0_紋柄_紋右_紋2.Hit = value;
				this.X0Y1_紋柄_紋右_紋2.Hit = value;
				this.X0Y2_紋柄_紋右_紋2.Hit = value;
				this.X0Y3_紋柄_紋右_紋2.Hit = value;
				this.X0Y4_紋柄_紋右_紋2.Hit = value;
			}
		}

		public bool 紋柄_紋右_紋3_表示
		{
			get
			{
				return this.X0Y0_紋柄_紋右_紋3.Dra;
			}
			set
			{
				this.X0Y0_紋柄_紋右_紋3.Dra = value;
				this.X0Y1_紋柄_紋右_紋3.Dra = value;
				this.X0Y2_紋柄_紋右_紋3.Dra = value;
				this.X0Y3_紋柄_紋右_紋3.Dra = value;
				this.X0Y4_紋柄_紋右_紋3.Dra = value;
				this.X0Y0_紋柄_紋右_紋3.Hit = value;
				this.X0Y1_紋柄_紋右_紋3.Hit = value;
				this.X0Y2_紋柄_紋右_紋3.Hit = value;
				this.X0Y3_紋柄_紋右_紋3.Hit = value;
				this.X0Y4_紋柄_紋右_紋3.Hit = value;
			}
		}

		public bool 虎柄_虎左_表示
		{
			get
			{
				return this.X0Y0_虎柄_虎左.Dra;
			}
			set
			{
				this.X0Y0_虎柄_虎左.Dra = value;
				this.X0Y1_虎柄_虎左.Dra = value;
				this.X0Y2_虎柄_虎左.Dra = value;
				this.X0Y3_虎柄_虎左.Dra = value;
				this.X0Y4_虎柄_虎左.Dra = value;
				this.X0Y0_虎柄_虎左.Hit = value;
				this.X0Y1_虎柄_虎左.Hit = value;
				this.X0Y2_虎柄_虎左.Hit = value;
				this.X0Y3_虎柄_虎左.Hit = value;
				this.X0Y4_虎柄_虎左.Hit = value;
			}
		}

		public bool 虎柄_虎右_表示
		{
			get
			{
				return this.X0Y0_虎柄_虎右.Dra;
			}
			set
			{
				this.X0Y0_虎柄_虎右.Dra = value;
				this.X0Y1_虎柄_虎右.Dra = value;
				this.X0Y2_虎柄_虎右.Dra = value;
				this.X0Y3_虎柄_虎右.Dra = value;
				this.X0Y4_虎柄_虎右.Dra = value;
				this.X0Y0_虎柄_虎右.Hit = value;
				this.X0Y1_虎柄_虎右.Hit = value;
				this.X0Y2_虎柄_虎右.Hit = value;
				this.X0Y3_虎柄_虎右.Hit = value;
				this.X0Y4_虎柄_虎右.Hit = value;
			}
		}

		public bool 竜性_中_鱗1_表示
		{
			get
			{
				return this.X0Y0_竜性_中_鱗1.Dra;
			}
			set
			{
				this.X0Y0_竜性_中_鱗1.Dra = false;
				this.X0Y1_竜性_中_鱗1.Dra = false;
				this.X0Y2_竜性_中_鱗1.Dra = false;
				this.X0Y3_竜性_中_鱗1.Dra = false;
				this.X0Y4_竜性_中_鱗1.Dra = false;
				this.X0Y0_竜性_中_鱗1.Hit = false;
				this.X0Y1_竜性_中_鱗1.Hit = false;
				this.X0Y2_竜性_中_鱗1.Hit = false;
				this.X0Y3_竜性_中_鱗1.Hit = false;
				this.X0Y4_竜性_中_鱗1.Hit = false;
			}
		}

		public bool 竜性_中_鱗2_表示
		{
			get
			{
				return this.X0Y0_竜性_中_鱗2.Dra;
			}
			set
			{
				this.X0Y0_竜性_中_鱗2.Dra = false;
				this.X0Y1_竜性_中_鱗2.Dra = false;
				this.X0Y2_竜性_中_鱗2.Dra = false;
				this.X0Y3_竜性_中_鱗2.Dra = false;
				this.X0Y4_竜性_中_鱗2.Dra = false;
				this.X0Y0_竜性_中_鱗2.Hit = false;
				this.X0Y1_竜性_中_鱗2.Hit = false;
				this.X0Y2_竜性_中_鱗2.Hit = false;
				this.X0Y3_竜性_中_鱗2.Hit = false;
				this.X0Y4_竜性_中_鱗2.Hit = false;
			}
		}

		public bool 竜性_中_鱗3_表示
		{
			get
			{
				return this.X0Y0_竜性_中_鱗3.Dra;
			}
			set
			{
				this.X0Y0_竜性_中_鱗3.Dra = false;
				this.X0Y1_竜性_中_鱗3.Dra = false;
				this.X0Y2_竜性_中_鱗3.Dra = false;
				this.X0Y3_竜性_中_鱗3.Dra = false;
				this.X0Y4_竜性_中_鱗3.Dra = false;
				this.X0Y0_竜性_中_鱗3.Hit = false;
				this.X0Y1_竜性_中_鱗3.Hit = false;
				this.X0Y2_竜性_中_鱗3.Hit = false;
				this.X0Y3_竜性_中_鱗3.Hit = false;
				this.X0Y4_竜性_中_鱗3.Hit = false;
			}
		}

		public bool 竜性_中_鱗4_表示
		{
			get
			{
				return this.X0Y0_竜性_中_鱗4.Dra;
			}
			set
			{
				this.X0Y0_竜性_中_鱗4.Dra = false;
				this.X0Y1_竜性_中_鱗4.Dra = false;
				this.X0Y2_竜性_中_鱗4.Dra = false;
				this.X0Y3_竜性_中_鱗4.Dra = false;
				this.X0Y4_竜性_中_鱗4.Dra = false;
				this.X0Y0_竜性_中_鱗4.Hit = false;
				this.X0Y1_竜性_中_鱗4.Hit = false;
				this.X0Y2_竜性_中_鱗4.Hit = false;
				this.X0Y3_竜性_中_鱗4.Hit = false;
				this.X0Y4_竜性_中_鱗4.Hit = false;
			}
		}

		public bool 竜性_左_鱗1_表示
		{
			get
			{
				return this.X0Y0_竜性_左_鱗1.Dra;
			}
			set
			{
				this.X0Y0_竜性_左_鱗1.Dra = value;
				this.X0Y1_竜性_左_鱗1.Dra = value;
				this.X0Y2_竜性_左_鱗1.Dra = value;
				this.X0Y3_竜性_左_鱗1.Dra = value;
				this.X0Y4_竜性_左_鱗1.Dra = value;
				this.X0Y0_竜性_左_鱗1.Hit = value;
				this.X0Y1_竜性_左_鱗1.Hit = value;
				this.X0Y2_竜性_左_鱗1.Hit = value;
				this.X0Y3_竜性_左_鱗1.Hit = value;
				this.X0Y4_竜性_左_鱗1.Hit = value;
			}
		}

		public bool 竜性_左_鱗2_表示
		{
			get
			{
				return this.X0Y0_竜性_左_鱗2.Dra;
			}
			set
			{
				this.X0Y0_竜性_左_鱗2.Dra = value;
				this.X0Y1_竜性_左_鱗2.Dra = value;
				this.X0Y2_竜性_左_鱗2.Dra = value;
				this.X0Y3_竜性_左_鱗2.Dra = value;
				this.X0Y4_竜性_左_鱗2.Dra = value;
				this.X0Y0_竜性_左_鱗2.Hit = value;
				this.X0Y1_竜性_左_鱗2.Hit = value;
				this.X0Y2_竜性_左_鱗2.Hit = value;
				this.X0Y3_竜性_左_鱗2.Hit = value;
				this.X0Y4_竜性_左_鱗2.Hit = value;
			}
		}

		public bool 竜性_右_鱗1_表示
		{
			get
			{
				return this.X0Y0_竜性_右_鱗1.Dra;
			}
			set
			{
				this.X0Y0_竜性_右_鱗1.Dra = value;
				this.X0Y1_竜性_右_鱗1.Dra = value;
				this.X0Y2_竜性_右_鱗1.Dra = value;
				this.X0Y3_竜性_右_鱗1.Dra = value;
				this.X0Y4_竜性_右_鱗1.Dra = value;
				this.X0Y0_竜性_右_鱗1.Hit = value;
				this.X0Y1_竜性_右_鱗1.Hit = value;
				this.X0Y2_竜性_右_鱗1.Hit = value;
				this.X0Y3_竜性_右_鱗1.Hit = value;
				this.X0Y4_竜性_右_鱗1.Hit = value;
			}
		}

		public bool 竜性_右_鱗2_表示
		{
			get
			{
				return this.X0Y0_竜性_右_鱗2.Dra;
			}
			set
			{
				this.X0Y0_竜性_右_鱗2.Dra = value;
				this.X0Y1_竜性_右_鱗2.Dra = value;
				this.X0Y2_竜性_右_鱗2.Dra = value;
				this.X0Y3_竜性_右_鱗2.Dra = value;
				this.X0Y4_竜性_右_鱗2.Dra = value;
				this.X0Y0_竜性_右_鱗2.Hit = value;
				this.X0Y1_竜性_右_鱗2.Hit = value;
				this.X0Y2_竜性_右_鱗2.Hit = value;
				this.X0Y3_竜性_右_鱗2.Hit = value;
				this.X0Y4_竜性_右_鱗2.Hit = value;
			}
		}

		public double 筋肉濃度
		{
			get
			{
				return this.筋肉_筋肉下CD.不透明度;
			}
			set
			{
				this.筋肉_筋肉下CD.不透明度 = value;
				this.筋肉_筋肉左CD.不透明度 = value;
				this.筋肉_筋肉右CD.不透明度 = value;
				this.筋肉_筋上左CD.不透明度 = value;
				this.筋肉_筋上右CD.不透明度 = value;
				this.筋肉_筋下左CD.不透明度 = value;
				this.筋肉_筋下右CD.不透明度 = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.腰_表示;
			}
			set
			{
				this.腰_表示 = value;
				this.股_表示 = value;
				this.下腹_表示 = value;
				this.腰皺_表示 = value;
				this.筋肉_筋肉下_表示 = value;
				this.筋肉_筋肉左_表示 = value;
				this.筋肉_筋肉右_表示 = value;
				this.筋肉_筋上左_表示 = value;
				this.筋肉_筋上右_表示 = value;
				this.筋肉_筋下左_表示 = value;
				this.筋肉_筋下右_表示 = value;
				this.臍_表示 = value;
				this.紋柄_紋左_紋1_表示 = value;
				this.紋柄_紋左_紋2_表示 = value;
				this.紋柄_紋左_紋3_表示 = value;
				this.紋柄_紋右_紋1_表示 = value;
				this.紋柄_紋右_紋2_表示 = value;
				this.紋柄_紋右_紋3_表示 = value;
				this.虎柄_虎左_表示 = value;
				this.虎柄_虎右_表示 = value;
				this.竜性_中_鱗1_表示 = value;
				this.竜性_中_鱗2_表示 = value;
				this.竜性_中_鱗3_表示 = value;
				this.竜性_中_鱗4_表示 = value;
				this.竜性_左_鱗1_表示 = value;
				this.竜性_左_鱗2_表示 = value;
				this.竜性_右_鱗1_表示 = value;
				this.竜性_右_鱗2_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.腰CD.不透明度;
			}
			set
			{
				this.腰CD.不透明度 = value;
				this.股CD.不透明度 = value;
				this.下腹CD.不透明度 = value;
				this.腰皺CD.不透明度 = value;
				this.筋肉_筋肉下CD.不透明度 = value;
				this.筋肉_筋肉左CD.不透明度 = value;
				this.筋肉_筋肉右CD.不透明度 = value;
				this.筋肉_筋上左CD.不透明度 = value;
				this.筋肉_筋上右CD.不透明度 = value;
				this.筋肉_筋下左CD.不透明度 = value;
				this.筋肉_筋下右CD.不透明度 = value;
				this.臍CD.不透明度 = value;
				this.紋柄_紋左_紋1CD.不透明度 = value;
				this.紋柄_紋左_紋2CD.不透明度 = value;
				this.紋柄_紋左_紋3CD.不透明度 = value;
				this.紋柄_紋右_紋1CD.不透明度 = value;
				this.紋柄_紋右_紋2CD.不透明度 = value;
				this.紋柄_紋右_紋3CD.不透明度 = value;
				this.虎柄_虎左CD.不透明度 = value;
				this.虎柄_虎右CD.不透明度 = value;
				this.竜性_中_鱗1CD.不透明度 = value;
				this.竜性_中_鱗2CD.不透明度 = value;
				this.竜性_中_鱗3CD.不透明度 = value;
				this.竜性_中_鱗4CD.不透明度 = value;
				this.竜性_左_鱗1CD.不透明度 = value;
				this.竜性_左_鱗2CD.不透明度 = value;
				this.竜性_右_鱗1CD.不透明度 = value;
				this.竜性_右_鱗2CD.不透明度 = value;
			}
		}

		public JointS 腿左_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_腰, 0);
			}
		}

		public JointS 腿右_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_腰, 1);
			}
		}

		public JointS 膣基_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_腰, 3);
			}
		}

		public JointS 肛門_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_腰, 4);
			}
		}

		public JointS 尾_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_腰, 4);
			}
		}

		public JointS 半身_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_腰, 4);
			}
		}

		public JointS 上着_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_腰, 5);
			}
		}

		public JointS 肌_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_腰, 6);
			}
		}

		public JointS 翼左_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_腰, 7);
			}
		}

		public JointS 翼右_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_腰, 8);
			}
		}

		public override void 色更新()
		{
			switch (this.本体.IndexY)
			{
			case 0:
				this.X0Y0_腰CP.Update();
				this.X0Y0_股CP.Update();
				this.X0Y0_下腹CP.Update();
				this.X0Y0_腰皺CP.Update();
				this.X0Y0_筋肉_筋肉下CP.Update();
				this.X0Y0_筋肉_筋肉左CP.Update();
				this.X0Y0_筋肉_筋肉右CP.Update();
				this.X0Y0_筋肉_筋上左CP.Update();
				this.X0Y0_筋肉_筋上右CP.Update();
				this.X0Y0_筋肉_筋下左CP.Update();
				this.X0Y0_筋肉_筋下右CP.Update();
				this.X0Y0_臍CP.Update();
				this.X0Y0_紋柄_紋左_紋1CP.Update();
				this.X0Y0_紋柄_紋左_紋2CP.Update();
				this.X0Y0_紋柄_紋左_紋3CP.Update();
				this.X0Y0_紋柄_紋右_紋1CP.Update();
				this.X0Y0_紋柄_紋右_紋2CP.Update();
				this.X0Y0_紋柄_紋右_紋3CP.Update();
				this.X0Y0_虎柄_虎左CP.Update();
				this.X0Y0_虎柄_虎右CP.Update();
				this.X0Y0_竜性_中_鱗1CP.Update();
				this.X0Y0_竜性_中_鱗2CP.Update();
				this.X0Y0_竜性_中_鱗3CP.Update();
				this.X0Y0_竜性_中_鱗4CP.Update();
				this.X0Y0_竜性_左_鱗1CP.Update();
				this.X0Y0_竜性_左_鱗2CP.Update();
				this.X0Y0_竜性_右_鱗1CP.Update();
				this.X0Y0_竜性_右_鱗2CP.Update();
				return;
			case 1:
				this.X0Y1_腰CP.Update();
				this.X0Y1_股CP.Update();
				this.X0Y1_下腹CP.Update();
				this.X0Y1_腰皺CP.Update();
				this.X0Y1_筋肉_筋肉下CP.Update();
				this.X0Y1_筋肉_筋肉左CP.Update();
				this.X0Y1_筋肉_筋肉右CP.Update();
				this.X0Y1_筋肉_筋上左CP.Update();
				this.X0Y1_筋肉_筋上右CP.Update();
				this.X0Y1_筋肉_筋下左CP.Update();
				this.X0Y1_筋肉_筋下右CP.Update();
				this.X0Y1_臍CP.Update();
				this.X0Y1_紋柄_紋左_紋1CP.Update();
				this.X0Y1_紋柄_紋左_紋2CP.Update();
				this.X0Y1_紋柄_紋左_紋3CP.Update();
				this.X0Y1_紋柄_紋右_紋1CP.Update();
				this.X0Y1_紋柄_紋右_紋2CP.Update();
				this.X0Y1_紋柄_紋右_紋3CP.Update();
				this.X0Y1_虎柄_虎左CP.Update();
				this.X0Y1_虎柄_虎右CP.Update();
				this.X0Y1_竜性_中_鱗1CP.Update();
				this.X0Y1_竜性_中_鱗2CP.Update();
				this.X0Y1_竜性_中_鱗3CP.Update();
				this.X0Y1_竜性_中_鱗4CP.Update();
				this.X0Y1_竜性_左_鱗1CP.Update();
				this.X0Y1_竜性_左_鱗2CP.Update();
				this.X0Y1_竜性_右_鱗1CP.Update();
				this.X0Y1_竜性_右_鱗2CP.Update();
				return;
			case 2:
				this.X0Y2_腰CP.Update();
				this.X0Y2_股CP.Update();
				this.X0Y2_下腹CP.Update();
				this.X0Y2_腰皺CP.Update();
				this.X0Y2_筋肉_筋肉下CP.Update();
				this.X0Y2_筋肉_筋肉左CP.Update();
				this.X0Y2_筋肉_筋肉右CP.Update();
				this.X0Y2_筋肉_筋上左CP.Update();
				this.X0Y2_筋肉_筋上右CP.Update();
				this.X0Y2_筋肉_筋下左CP.Update();
				this.X0Y2_筋肉_筋下右CP.Update();
				this.X0Y2_臍CP.Update();
				this.X0Y2_紋柄_紋左_紋1CP.Update();
				this.X0Y2_紋柄_紋左_紋2CP.Update();
				this.X0Y2_紋柄_紋左_紋3CP.Update();
				this.X0Y2_紋柄_紋右_紋1CP.Update();
				this.X0Y2_紋柄_紋右_紋2CP.Update();
				this.X0Y2_紋柄_紋右_紋3CP.Update();
				this.X0Y2_虎柄_虎左CP.Update();
				this.X0Y2_虎柄_虎右CP.Update();
				this.X0Y2_竜性_中_鱗1CP.Update();
				this.X0Y2_竜性_中_鱗2CP.Update();
				this.X0Y2_竜性_中_鱗3CP.Update();
				this.X0Y2_竜性_中_鱗4CP.Update();
				this.X0Y2_竜性_左_鱗1CP.Update();
				this.X0Y2_竜性_左_鱗2CP.Update();
				this.X0Y2_竜性_右_鱗1CP.Update();
				this.X0Y2_竜性_右_鱗2CP.Update();
				return;
			case 3:
				this.X0Y3_腰CP.Update();
				this.X0Y3_股CP.Update();
				this.X0Y3_下腹CP.Update();
				this.X0Y3_腰皺CP.Update();
				this.X0Y3_筋肉_筋肉下CP.Update();
				this.X0Y3_筋肉_筋肉左CP.Update();
				this.X0Y3_筋肉_筋肉右CP.Update();
				this.X0Y3_筋肉_筋上左CP.Update();
				this.X0Y3_筋肉_筋上右CP.Update();
				this.X0Y3_筋肉_筋下左CP.Update();
				this.X0Y3_筋肉_筋下右CP.Update();
				this.X0Y3_臍CP.Update();
				this.X0Y3_紋柄_紋左_紋1CP.Update();
				this.X0Y3_紋柄_紋左_紋2CP.Update();
				this.X0Y3_紋柄_紋左_紋3CP.Update();
				this.X0Y3_紋柄_紋右_紋1CP.Update();
				this.X0Y3_紋柄_紋右_紋2CP.Update();
				this.X0Y3_紋柄_紋右_紋3CP.Update();
				this.X0Y3_虎柄_虎左CP.Update();
				this.X0Y3_虎柄_虎右CP.Update();
				this.X0Y3_竜性_中_鱗1CP.Update();
				this.X0Y3_竜性_中_鱗2CP.Update();
				this.X0Y3_竜性_中_鱗3CP.Update();
				this.X0Y3_竜性_中_鱗4CP.Update();
				this.X0Y3_竜性_左_鱗1CP.Update();
				this.X0Y3_竜性_左_鱗2CP.Update();
				this.X0Y3_竜性_右_鱗1CP.Update();
				this.X0Y3_竜性_右_鱗2CP.Update();
				return;
			default:
				this.X0Y4_腰CP.Update();
				this.X0Y4_股CP.Update();
				this.X0Y4_下腹CP.Update();
				this.X0Y4_腰皺CP.Update();
				this.X0Y4_筋肉_筋肉下CP.Update();
				this.X0Y4_筋肉_筋肉左CP.Update();
				this.X0Y4_筋肉_筋肉右CP.Update();
				this.X0Y4_筋肉_筋上左CP.Update();
				this.X0Y4_筋肉_筋上右CP.Update();
				this.X0Y4_筋肉_筋下左CP.Update();
				this.X0Y4_筋肉_筋下右CP.Update();
				this.X0Y4_臍CP.Update();
				this.X0Y4_紋柄_紋左_紋1CP.Update();
				this.X0Y4_紋柄_紋左_紋2CP.Update();
				this.X0Y4_紋柄_紋左_紋3CP.Update();
				this.X0Y4_紋柄_紋右_紋1CP.Update();
				this.X0Y4_紋柄_紋右_紋2CP.Update();
				this.X0Y4_紋柄_紋右_紋3CP.Update();
				this.X0Y4_虎柄_虎左CP.Update();
				this.X0Y4_虎柄_虎右CP.Update();
				this.X0Y4_竜性_中_鱗1CP.Update();
				this.X0Y4_竜性_中_鱗2CP.Update();
				this.X0Y4_竜性_中_鱗3CP.Update();
				this.X0Y4_竜性_中_鱗4CP.Update();
				this.X0Y4_竜性_左_鱗1CP.Update();
				this.X0Y4_竜性_左_鱗2CP.Update();
				this.X0Y4_竜性_右_鱗1CP.Update();
				this.X0Y4_竜性_右_鱗2CP.Update();
				return;
			}
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
			this.腰CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.股CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.下腹CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.腰皺CD = new ColorD(ref 体配色.薄線, ref Color2.Empty);
			this.筋肉_筋肉下CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.筋肉_筋肉左CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.筋肉_筋肉右CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.筋肉_筋上左CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.筋肉_筋上右CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.筋肉_筋下左CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.筋肉_筋下右CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.臍CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.紋柄_紋左_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋左_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋左_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋右_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋右_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋右_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.虎柄_虎左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.虎柄_虎右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.竜性_中_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_中_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_中_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_中_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
		}

		private void 配色T0(体配色 体配色)
		{
			this.腰CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.股CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.下腹CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.腰皺CD = new ColorD(ref 体配色.薄線, ref Color2.Empty);
			this.筋肉_筋肉下CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.筋肉_筋肉左CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.筋肉_筋肉右CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.筋肉_筋上左CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.筋肉_筋上右CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.筋肉_筋下左CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.筋肉_筋下右CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.臍CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.紋柄_紋左_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋左_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋左_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋右_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋右_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋右_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.虎柄_虎左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.虎柄_虎右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.竜性_中_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_中_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_中_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_中_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
		}

		private void 配色T1(体配色 体配色)
		{
			this.腰CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.股CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.下腹CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.腰皺CD = new ColorD(ref 体配色.薄線, ref Color2.Empty);
			this.筋肉_筋肉下CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.筋肉_筋肉左CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.筋肉_筋肉右CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.筋肉_筋上左CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.筋肉_筋上右CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.筋肉_筋下左CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.筋肉_筋下右CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.臍CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.紋柄_紋左_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋左_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋左_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋右_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋右_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋右_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.虎柄_虎左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.虎柄_虎右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.竜性_中_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_中_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_中_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_中_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
		}

		public Par X0Y0_腰;

		public Par X0Y0_股;

		public Par X0Y0_下腹;

		public Par X0Y0_腰皺;

		public Par X0Y0_筋肉_筋肉下;

		public Par X0Y0_筋肉_筋肉左;

		public Par X0Y0_筋肉_筋肉右;

		public Par X0Y0_筋肉_筋上左;

		public Par X0Y0_筋肉_筋上右;

		public Par X0Y0_筋肉_筋下左;

		public Par X0Y0_筋肉_筋下右;

		public Par X0Y0_臍;

		public Par X0Y0_紋柄_紋左_紋1;

		public Par X0Y0_紋柄_紋左_紋2;

		public Par X0Y0_紋柄_紋左_紋3;

		public Par X0Y0_紋柄_紋右_紋1;

		public Par X0Y0_紋柄_紋右_紋2;

		public Par X0Y0_紋柄_紋右_紋3;

		public Par X0Y0_虎柄_虎左;

		public Par X0Y0_虎柄_虎右;

		public Par X0Y0_竜性_中_鱗1;

		public Par X0Y0_竜性_中_鱗2;

		public Par X0Y0_竜性_中_鱗3;

		public Par X0Y0_竜性_中_鱗4;

		public Par X0Y0_竜性_左_鱗1;

		public Par X0Y0_竜性_左_鱗2;

		public Par X0Y0_竜性_右_鱗1;

		public Par X0Y0_竜性_右_鱗2;

		public Par X0Y1_腰;

		public Par X0Y1_股;

		public Par X0Y1_下腹;

		public Par X0Y1_腰皺;

		public Par X0Y1_筋肉_筋肉下;

		public Par X0Y1_筋肉_筋肉左;

		public Par X0Y1_筋肉_筋肉右;

		public Par X0Y1_筋肉_筋上左;

		public Par X0Y1_筋肉_筋上右;

		public Par X0Y1_筋肉_筋下左;

		public Par X0Y1_筋肉_筋下右;

		public Par X0Y1_臍;

		public Par X0Y1_紋柄_紋左_紋1;

		public Par X0Y1_紋柄_紋左_紋2;

		public Par X0Y1_紋柄_紋左_紋3;

		public Par X0Y1_紋柄_紋右_紋1;

		public Par X0Y1_紋柄_紋右_紋2;

		public Par X0Y1_紋柄_紋右_紋3;

		public Par X0Y1_虎柄_虎左;

		public Par X0Y1_虎柄_虎右;

		public Par X0Y1_竜性_中_鱗1;

		public Par X0Y1_竜性_中_鱗2;

		public Par X0Y1_竜性_中_鱗3;

		public Par X0Y1_竜性_中_鱗4;

		public Par X0Y1_竜性_左_鱗1;

		public Par X0Y1_竜性_左_鱗2;

		public Par X0Y1_竜性_右_鱗1;

		public Par X0Y1_竜性_右_鱗2;

		public Par X0Y2_腰;

		public Par X0Y2_股;

		public Par X0Y2_下腹;

		public Par X0Y2_腰皺;

		public Par X0Y2_筋肉_筋肉下;

		public Par X0Y2_筋肉_筋肉左;

		public Par X0Y2_筋肉_筋肉右;

		public Par X0Y2_筋肉_筋上左;

		public Par X0Y2_筋肉_筋上右;

		public Par X0Y2_筋肉_筋下左;

		public Par X0Y2_筋肉_筋下右;

		public Par X0Y2_臍;

		public Par X0Y2_紋柄_紋左_紋1;

		public Par X0Y2_紋柄_紋左_紋2;

		public Par X0Y2_紋柄_紋左_紋3;

		public Par X0Y2_紋柄_紋右_紋1;

		public Par X0Y2_紋柄_紋右_紋2;

		public Par X0Y2_紋柄_紋右_紋3;

		public Par X0Y2_虎柄_虎左;

		public Par X0Y2_虎柄_虎右;

		public Par X0Y2_竜性_中_鱗1;

		public Par X0Y2_竜性_中_鱗2;

		public Par X0Y2_竜性_中_鱗3;

		public Par X0Y2_竜性_中_鱗4;

		public Par X0Y2_竜性_左_鱗1;

		public Par X0Y2_竜性_左_鱗2;

		public Par X0Y2_竜性_右_鱗1;

		public Par X0Y2_竜性_右_鱗2;

		public Par X0Y3_腰;

		public Par X0Y3_股;

		public Par X0Y3_下腹;

		public Par X0Y3_腰皺;

		public Par X0Y3_筋肉_筋肉下;

		public Par X0Y3_筋肉_筋肉左;

		public Par X0Y3_筋肉_筋肉右;

		public Par X0Y3_筋肉_筋上左;

		public Par X0Y3_筋肉_筋上右;

		public Par X0Y3_筋肉_筋下左;

		public Par X0Y3_筋肉_筋下右;

		public Par X0Y3_臍;

		public Par X0Y3_紋柄_紋左_紋1;

		public Par X0Y3_紋柄_紋左_紋2;

		public Par X0Y3_紋柄_紋左_紋3;

		public Par X0Y3_紋柄_紋右_紋1;

		public Par X0Y3_紋柄_紋右_紋2;

		public Par X0Y3_紋柄_紋右_紋3;

		public Par X0Y3_虎柄_虎左;

		public Par X0Y3_虎柄_虎右;

		public Par X0Y3_竜性_中_鱗1;

		public Par X0Y3_竜性_中_鱗2;

		public Par X0Y3_竜性_中_鱗3;

		public Par X0Y3_竜性_中_鱗4;

		public Par X0Y3_竜性_左_鱗1;

		public Par X0Y3_竜性_左_鱗2;

		public Par X0Y3_竜性_右_鱗1;

		public Par X0Y3_竜性_右_鱗2;

		public Par X0Y4_腰;

		public Par X0Y4_股;

		public Par X0Y4_下腹;

		public Par X0Y4_腰皺;

		public Par X0Y4_筋肉_筋肉下;

		public Par X0Y4_筋肉_筋肉左;

		public Par X0Y4_筋肉_筋肉右;

		public Par X0Y4_筋肉_筋上左;

		public Par X0Y4_筋肉_筋上右;

		public Par X0Y4_筋肉_筋下左;

		public Par X0Y4_筋肉_筋下右;

		public Par X0Y4_臍;

		public Par X0Y4_紋柄_紋左_紋1;

		public Par X0Y4_紋柄_紋左_紋2;

		public Par X0Y4_紋柄_紋左_紋3;

		public Par X0Y4_紋柄_紋右_紋1;

		public Par X0Y4_紋柄_紋右_紋2;

		public Par X0Y4_紋柄_紋右_紋3;

		public Par X0Y4_虎柄_虎左;

		public Par X0Y4_虎柄_虎右;

		public Par X0Y4_竜性_中_鱗1;

		public Par X0Y4_竜性_中_鱗2;

		public Par X0Y4_竜性_中_鱗3;

		public Par X0Y4_竜性_中_鱗4;

		public Par X0Y4_竜性_左_鱗1;

		public Par X0Y4_竜性_左_鱗2;

		public Par X0Y4_竜性_右_鱗1;

		public Par X0Y4_竜性_右_鱗2;

		public ColorD 腰CD;

		public ColorD 股CD;

		public ColorD 下腹CD;

		public ColorD 腰皺CD;

		public ColorD 筋肉_筋肉下CD;

		public ColorD 筋肉_筋肉左CD;

		public ColorD 筋肉_筋肉右CD;

		public ColorD 筋肉_筋上左CD;

		public ColorD 筋肉_筋上右CD;

		public ColorD 筋肉_筋下左CD;

		public ColorD 筋肉_筋下右CD;

		public ColorD 臍CD;

		public ColorD 紋柄_紋左_紋1CD;

		public ColorD 紋柄_紋左_紋2CD;

		public ColorD 紋柄_紋左_紋3CD;

		public ColorD 紋柄_紋右_紋1CD;

		public ColorD 紋柄_紋右_紋2CD;

		public ColorD 紋柄_紋右_紋3CD;

		public ColorD 虎柄_虎左CD;

		public ColorD 虎柄_虎右CD;

		public ColorD 竜性_中_鱗1CD;

		public ColorD 竜性_中_鱗2CD;

		public ColorD 竜性_中_鱗3CD;

		public ColorD 竜性_中_鱗4CD;

		public ColorD 竜性_左_鱗1CD;

		public ColorD 竜性_左_鱗2CD;

		public ColorD 竜性_右_鱗1CD;

		public ColorD 竜性_右_鱗2CD;

		public ColorP X0Y0_腰CP;

		public ColorP X0Y0_股CP;

		public ColorP X0Y0_下腹CP;

		public ColorP X0Y0_腰皺CP;

		public ColorP X0Y0_筋肉_筋肉下CP;

		public ColorP X0Y0_筋肉_筋肉左CP;

		public ColorP X0Y0_筋肉_筋肉右CP;

		public ColorP X0Y0_筋肉_筋上左CP;

		public ColorP X0Y0_筋肉_筋上右CP;

		public ColorP X0Y0_筋肉_筋下左CP;

		public ColorP X0Y0_筋肉_筋下右CP;

		public ColorP X0Y0_臍CP;

		public ColorP X0Y0_紋柄_紋左_紋1CP;

		public ColorP X0Y0_紋柄_紋左_紋2CP;

		public ColorP X0Y0_紋柄_紋左_紋3CP;

		public ColorP X0Y0_紋柄_紋右_紋1CP;

		public ColorP X0Y0_紋柄_紋右_紋2CP;

		public ColorP X0Y0_紋柄_紋右_紋3CP;

		public ColorP X0Y0_虎柄_虎左CP;

		public ColorP X0Y0_虎柄_虎右CP;

		public ColorP X0Y0_竜性_中_鱗1CP;

		public ColorP X0Y0_竜性_中_鱗2CP;

		public ColorP X0Y0_竜性_中_鱗3CP;

		public ColorP X0Y0_竜性_中_鱗4CP;

		public ColorP X0Y0_竜性_左_鱗1CP;

		public ColorP X0Y0_竜性_左_鱗2CP;

		public ColorP X0Y0_竜性_右_鱗1CP;

		public ColorP X0Y0_竜性_右_鱗2CP;

		public ColorP X0Y1_腰CP;

		public ColorP X0Y1_股CP;

		public ColorP X0Y1_下腹CP;

		public ColorP X0Y1_腰皺CP;

		public ColorP X0Y1_筋肉_筋肉下CP;

		public ColorP X0Y1_筋肉_筋肉左CP;

		public ColorP X0Y1_筋肉_筋肉右CP;

		public ColorP X0Y1_筋肉_筋上左CP;

		public ColorP X0Y1_筋肉_筋上右CP;

		public ColorP X0Y1_筋肉_筋下左CP;

		public ColorP X0Y1_筋肉_筋下右CP;

		public ColorP X0Y1_臍CP;

		public ColorP X0Y1_紋柄_紋左_紋1CP;

		public ColorP X0Y1_紋柄_紋左_紋2CP;

		public ColorP X0Y1_紋柄_紋左_紋3CP;

		public ColorP X0Y1_紋柄_紋右_紋1CP;

		public ColorP X0Y1_紋柄_紋右_紋2CP;

		public ColorP X0Y1_紋柄_紋右_紋3CP;

		public ColorP X0Y1_虎柄_虎左CP;

		public ColorP X0Y1_虎柄_虎右CP;

		public ColorP X0Y1_竜性_中_鱗1CP;

		public ColorP X0Y1_竜性_中_鱗2CP;

		public ColorP X0Y1_竜性_中_鱗3CP;

		public ColorP X0Y1_竜性_中_鱗4CP;

		public ColorP X0Y1_竜性_左_鱗1CP;

		public ColorP X0Y1_竜性_左_鱗2CP;

		public ColorP X0Y1_竜性_右_鱗1CP;

		public ColorP X0Y1_竜性_右_鱗2CP;

		public ColorP X0Y2_腰CP;

		public ColorP X0Y2_股CP;

		public ColorP X0Y2_下腹CP;

		public ColorP X0Y2_腰皺CP;

		public ColorP X0Y2_筋肉_筋肉下CP;

		public ColorP X0Y2_筋肉_筋肉左CP;

		public ColorP X0Y2_筋肉_筋肉右CP;

		public ColorP X0Y2_筋肉_筋上左CP;

		public ColorP X0Y2_筋肉_筋上右CP;

		public ColorP X0Y2_筋肉_筋下左CP;

		public ColorP X0Y2_筋肉_筋下右CP;

		public ColorP X0Y2_臍CP;

		public ColorP X0Y2_紋柄_紋左_紋1CP;

		public ColorP X0Y2_紋柄_紋左_紋2CP;

		public ColorP X0Y2_紋柄_紋左_紋3CP;

		public ColorP X0Y2_紋柄_紋右_紋1CP;

		public ColorP X0Y2_紋柄_紋右_紋2CP;

		public ColorP X0Y2_紋柄_紋右_紋3CP;

		public ColorP X0Y2_虎柄_虎左CP;

		public ColorP X0Y2_虎柄_虎右CP;

		public ColorP X0Y2_竜性_中_鱗1CP;

		public ColorP X0Y2_竜性_中_鱗2CP;

		public ColorP X0Y2_竜性_中_鱗3CP;

		public ColorP X0Y2_竜性_中_鱗4CP;

		public ColorP X0Y2_竜性_左_鱗1CP;

		public ColorP X0Y2_竜性_左_鱗2CP;

		public ColorP X0Y2_竜性_右_鱗1CP;

		public ColorP X0Y2_竜性_右_鱗2CP;

		public ColorP X0Y3_腰CP;

		public ColorP X0Y3_股CP;

		public ColorP X0Y3_下腹CP;

		public ColorP X0Y3_腰皺CP;

		public ColorP X0Y3_筋肉_筋肉下CP;

		public ColorP X0Y3_筋肉_筋肉左CP;

		public ColorP X0Y3_筋肉_筋肉右CP;

		public ColorP X0Y3_筋肉_筋上左CP;

		public ColorP X0Y3_筋肉_筋上右CP;

		public ColorP X0Y3_筋肉_筋下左CP;

		public ColorP X0Y3_筋肉_筋下右CP;

		public ColorP X0Y3_臍CP;

		public ColorP X0Y3_紋柄_紋左_紋1CP;

		public ColorP X0Y3_紋柄_紋左_紋2CP;

		public ColorP X0Y3_紋柄_紋左_紋3CP;

		public ColorP X0Y3_紋柄_紋右_紋1CP;

		public ColorP X0Y3_紋柄_紋右_紋2CP;

		public ColorP X0Y3_紋柄_紋右_紋3CP;

		public ColorP X0Y3_虎柄_虎左CP;

		public ColorP X0Y3_虎柄_虎右CP;

		public ColorP X0Y3_竜性_中_鱗1CP;

		public ColorP X0Y3_竜性_中_鱗2CP;

		public ColorP X0Y3_竜性_中_鱗3CP;

		public ColorP X0Y3_竜性_中_鱗4CP;

		public ColorP X0Y3_竜性_左_鱗1CP;

		public ColorP X0Y3_竜性_左_鱗2CP;

		public ColorP X0Y3_竜性_右_鱗1CP;

		public ColorP X0Y3_竜性_右_鱗2CP;

		public ColorP X0Y4_腰CP;

		public ColorP X0Y4_股CP;

		public ColorP X0Y4_下腹CP;

		public ColorP X0Y4_腰皺CP;

		public ColorP X0Y4_筋肉_筋肉下CP;

		public ColorP X0Y4_筋肉_筋肉左CP;

		public ColorP X0Y4_筋肉_筋肉右CP;

		public ColorP X0Y4_筋肉_筋上左CP;

		public ColorP X0Y4_筋肉_筋上右CP;

		public ColorP X0Y4_筋肉_筋下左CP;

		public ColorP X0Y4_筋肉_筋下右CP;

		public ColorP X0Y4_臍CP;

		public ColorP X0Y4_紋柄_紋左_紋1CP;

		public ColorP X0Y4_紋柄_紋左_紋2CP;

		public ColorP X0Y4_紋柄_紋左_紋3CP;

		public ColorP X0Y4_紋柄_紋右_紋1CP;

		public ColorP X0Y4_紋柄_紋右_紋2CP;

		public ColorP X0Y4_紋柄_紋右_紋3CP;

		public ColorP X0Y4_虎柄_虎左CP;

		public ColorP X0Y4_虎柄_虎右CP;

		public ColorP X0Y4_竜性_中_鱗1CP;

		public ColorP X0Y4_竜性_中_鱗2CP;

		public ColorP X0Y4_竜性_中_鱗3CP;

		public ColorP X0Y4_竜性_中_鱗4CP;

		public ColorP X0Y4_竜性_左_鱗1CP;

		public ColorP X0Y4_竜性_左_鱗2CP;

		public ColorP X0Y4_竜性_右_鱗1CP;

		public ColorP X0Y4_竜性_右_鱗2CP;

		public Ele[] 腿左_接続;

		public Ele[] 腿右_接続;

		public Ele[] 膣基_接続;

		public Ele[] 肛門_接続;

		public Ele[] 尾_接続;

		public Ele[] 半身_接続;

		public Ele[] 上着_接続;

		public Ele[] 肌_接続;

		public Ele[] 翼左_接続;

		public Ele[] 翼右_接続;
	}
}
