using System;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 胸 : Ele
	{
		public 胸(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 胸D e)
		{
			胸.<>c__DisplayClass174_0 CS$<>8__locals1 = new 胸.<>c__DisplayClass174_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.胴体["胸郭"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_胸郭 = pars["胸郭"].ToPar();
			Pars pars2 = pars["筋肉"].ToPars();
			this.X0Y0_筋肉_筋肉左 = pars2["筋肉左"].ToPar();
			this.X0Y0_筋肉_筋肉右 = pars2["筋肉右"].ToPar();
			this.X0Y0_筋肉_筋肉中 = pars2["筋肉中"].ToPar();
			this.X0Y0_筋肉_筋肉左下 = pars2["筋肉左下"].ToPar();
			this.X0Y0_筋肉_筋肉左中 = pars2["筋肉左中"].ToPar();
			this.X0Y0_筋肉_筋肉左上 = pars2["筋肉左上"].ToPar();
			this.X0Y0_筋肉_筋肉右下 = pars2["筋肉右下"].ToPar();
			this.X0Y0_筋肉_筋肉右中 = pars2["筋肉右中"].ToPar();
			this.X0Y0_筋肉_筋肉右上 = pars2["筋肉右上"].ToPar();
			pars2 = pars["紋柄"].ToPars();
			Pars pars3 = pars2["紋左"].ToPars();
			this.X0Y0_紋柄_紋左_紋1 = pars3["紋1"].ToPar();
			this.X0Y0_紋柄_紋左_紋2 = pars3["紋2"].ToPar();
			this.X0Y0_紋柄_紋左_紋3 = pars3["紋3"].ToPar();
			this.X0Y0_紋柄_紋左_紋4 = pars3["紋4"].ToPar();
			pars3 = pars2["紋右"].ToPars();
			this.X0Y0_紋柄_紋右_紋1 = pars3["紋1"].ToPar();
			this.X0Y0_紋柄_紋右_紋2 = pars3["紋2"].ToPar();
			this.X0Y0_紋柄_紋右_紋3 = pars3["紋3"].ToPar();
			this.X0Y0_紋柄_紋右_紋4 = pars3["紋4"].ToPar();
			pars2 = pars["淫タトゥ"].ToPars();
			this.X0Y0_淫タトゥ_タトゥ左 = pars2["タトゥ左"].ToPar();
			this.X0Y0_淫タトゥ_タトゥ右 = pars2["タトゥ右"].ToPar();
			pars2 = pars["悪タトゥ"].ToPars();
			this.X0Y0_悪タトゥ_タトゥ左1 = pars2["タトゥ左1"].ToPar();
			this.X0Y0_悪タトゥ_タトゥ左2 = pars2["タトゥ左2"].ToPar();
			this.X0Y0_悪タトゥ_タトゥ左3 = pars2["タトゥ左3"].ToPar();
			this.X0Y0_悪タトゥ_タトゥ右1 = pars2["タトゥ右1"].ToPar();
			this.X0Y0_悪タトゥ_タトゥ右2 = pars2["タトゥ右2"].ToPar();
			this.X0Y0_悪タトゥ_タトゥ右3 = pars2["タトゥ右3"].ToPar();
			pars2 = pars["植タトゥ"].ToPars();
			pars3 = pars2["左"].ToPars();
			Pars pars4 = pars3["上"].ToPars();
			this.X0Y0_植タトゥ_左_上_タトゥ1 = pars4["タトゥ1"].ToPar();
			this.X0Y0_植タトゥ_左_上_タトゥ2 = pars4["タトゥ2"].ToPar();
			pars4 = pars3["下"].ToPars();
			this.X0Y0_植タトゥ_左_下_タトゥ1 = pars4["タトゥ1"].ToPar();
			this.X0Y0_植タトゥ_左_下_タトゥ2 = pars4["タトゥ2"].ToPar();
			pars3 = pars2["右"].ToPars();
			pars4 = pars3["上"].ToPars();
			this.X0Y0_植タトゥ_右_上_タトゥ1 = pars4["タトゥ1"].ToPar();
			this.X0Y0_植タトゥ_右_上_タトゥ2 = pars4["タトゥ2"].ToPar();
			pars4 = pars3["下"].ToPars();
			this.X0Y0_植タトゥ_右_下_タトゥ1 = pars4["タトゥ1"].ToPar();
			this.X0Y0_植タトゥ_右_下_タトゥ2 = pars4["タトゥ2"].ToPar();
			pars2 = pars["獣性"].ToPars();
			this.X0Y0_獣性_獣毛左1 = pars2["獣毛左1"].ToPar();
			this.X0Y0_獣性_獣毛左2 = pars2["獣毛左2"].ToPar();
			this.X0Y0_獣性_獣毛右1 = pars2["獣毛右1"].ToPar();
			this.X0Y0_獣性_獣毛右2 = pars2["獣毛右2"].ToPar();
			pars2 = pars["鱗"].ToPars();
			pars3 = pars2["左"].ToPars();
			this.X0Y0_竜性_左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_竜性_左_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_竜性_左_鱗3 = pars3["鱗3"].ToPar();
			pars3 = pars2["右"].ToPars();
			this.X0Y0_竜性_右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_竜性_右_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_竜性_右_鱗3 = pars3["鱗3"].ToPar();
			pars2 = pars["虫性"].ToPars();
			pars3 = pars2["甲殻左"].ToPars();
			pars4 = pars3["甲殻2"].ToPars();
			this.X0Y0_虫性_甲殻左_甲殻2_甲殻 = pars4["甲殻"].ToPar();
			this.X0Y0_虫性_甲殻左_甲殻2_器官 = pars4["器官"].ToPar();
			pars4 = pars3["甲殻1"].ToPars();
			this.X0Y0_虫性_甲殻左_甲殻1_甲殻 = pars4["甲殻"].ToPar();
			this.X0Y0_虫性_甲殻左_甲殻1_器官 = pars4["器官"].ToPar();
			pars3 = pars2["甲殻右"].ToPars();
			pars4 = pars3["甲殻2"].ToPars();
			this.X0Y0_虫性_甲殻右_甲殻2_甲殻 = pars4["甲殻"].ToPar();
			this.X0Y0_虫性_甲殻右_甲殻2_器官 = pars4["器官"].ToPar();
			pars4 = pars3["甲殻1"].ToPars();
			this.X0Y0_虫性_甲殻右_甲殻1_甲殻 = pars4["甲殻"].ToPar();
			this.X0Y0_虫性_甲殻右_甲殻1_器官 = pars4["器官"].ToPar();
			this.X0Y0_傷X左 = pars["傷X左"].ToPar();
			this.X0Y0_傷X右 = pars["傷X右"].ToPar();
			this.X0Y0_ハイライト外左 = pars["ハイライト外左"].ToPar();
			this.X0Y0_ハイライト外右 = pars["ハイライト外右"].ToPar();
			this.X0Y0_ハイライト内左 = pars["ハイライト内左"].ToPar();
			this.X0Y0_ハイライト内右 = pars["ハイライト内右"].ToPar();
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
			this.胸郭_表示 = e.胸郭_表示;
			this.筋肉_筋肉左_表示 = e.筋肉_筋肉左_表示;
			this.筋肉_筋肉右_表示 = e.筋肉_筋肉右_表示;
			this.筋肉_筋肉中_表示 = e.筋肉_筋肉中_表示;
			this.筋肉_筋肉左下_表示 = e.筋肉_筋肉左下_表示;
			this.筋肉_筋肉左中_表示 = e.筋肉_筋肉左中_表示;
			this.筋肉_筋肉左上_表示 = e.筋肉_筋肉左上_表示;
			this.筋肉_筋肉右下_表示 = e.筋肉_筋肉右下_表示;
			this.筋肉_筋肉右中_表示 = e.筋肉_筋肉右中_表示;
			this.筋肉_筋肉右上_表示 = e.筋肉_筋肉右上_表示;
			this.紋柄_紋左_紋1_表示 = e.紋柄_紋左_紋1_表示;
			this.紋柄_紋左_紋2_表示 = e.紋柄_紋左_紋2_表示;
			this.紋柄_紋左_紋3_表示 = e.紋柄_紋左_紋3_表示;
			this.紋柄_紋左_紋4_表示 = e.紋柄_紋左_紋4_表示;
			this.紋柄_紋右_紋1_表示 = e.紋柄_紋右_紋1_表示;
			this.紋柄_紋右_紋2_表示 = e.紋柄_紋右_紋2_表示;
			this.紋柄_紋右_紋3_表示 = e.紋柄_紋右_紋3_表示;
			this.紋柄_紋右_紋4_表示 = e.紋柄_紋右_紋4_表示;
			this.淫タトゥ_タトゥ左_表示 = e.淫タトゥ_タトゥ左_表示;
			this.淫タトゥ_タトゥ右_表示 = e.淫タトゥ_タトゥ右_表示;
			this.悪タトゥ_タトゥ左1_表示 = e.悪タトゥ_タトゥ左1_表示;
			this.悪タトゥ_タトゥ左2_表示 = e.悪タトゥ_タトゥ左2_表示;
			this.悪タトゥ_タトゥ左3_表示 = e.悪タトゥ_タトゥ左3_表示;
			this.悪タトゥ_タトゥ右1_表示 = e.悪タトゥ_タトゥ右1_表示;
			this.悪タトゥ_タトゥ右2_表示 = e.悪タトゥ_タトゥ右2_表示;
			this.悪タトゥ_タトゥ右3_表示 = e.悪タトゥ_タトゥ右3_表示;
			this.植タトゥ_左_上_タトゥ1_表示 = e.植タトゥ_左_上_タトゥ1_表示;
			this.植タトゥ_左_上_タトゥ2_表示 = e.植タトゥ_左_上_タトゥ2_表示;
			this.植タトゥ_左_下_タトゥ1_表示 = e.植タトゥ_左_下_タトゥ1_表示;
			this.植タトゥ_左_下_タトゥ2_表示 = e.植タトゥ_左_下_タトゥ2_表示;
			this.植タトゥ_右_上_タトゥ1_表示 = e.植タトゥ_右_上_タトゥ1_表示;
			this.植タトゥ_右_上_タトゥ2_表示 = e.植タトゥ_右_上_タトゥ2_表示;
			this.植タトゥ_右_下_タトゥ1_表示 = e.植タトゥ_右_下_タトゥ1_表示;
			this.植タトゥ_右_下_タトゥ2_表示 = e.植タトゥ_右_下_タトゥ2_表示;
			this.獣性_獣毛左1_表示 = e.獣性_獣毛左1_表示;
			this.獣性_獣毛左2_表示 = e.獣性_獣毛左2_表示;
			this.獣性_獣毛右1_表示 = e.獣性_獣毛右1_表示;
			this.獣性_獣毛右2_表示 = e.獣性_獣毛右2_表示;
			this.竜性_左_鱗1_表示 = e.竜性_左_鱗1_表示;
			this.竜性_左_鱗2_表示 = e.竜性_左_鱗2_表示;
			this.竜性_左_鱗3_表示 = e.竜性_左_鱗3_表示;
			this.竜性_右_鱗1_表示 = e.竜性_右_鱗1_表示;
			this.竜性_右_鱗2_表示 = e.竜性_右_鱗2_表示;
			this.竜性_右_鱗3_表示 = e.竜性_右_鱗3_表示;
			this.虫性_甲殻左_甲殻2_甲殻_表示 = e.虫性_甲殻左_甲殻2_甲殻_表示;
			this.虫性_甲殻左_甲殻2_器官_表示 = e.虫性_甲殻左_甲殻2_器官_表示;
			this.虫性_甲殻左_甲殻1_甲殻_表示 = e.虫性_甲殻左_甲殻1_甲殻_表示;
			this.虫性_甲殻左_甲殻1_器官_表示 = e.虫性_甲殻左_甲殻1_器官_表示;
			this.虫性_甲殻右_甲殻2_甲殻_表示 = e.虫性_甲殻右_甲殻2_甲殻_表示;
			this.虫性_甲殻右_甲殻2_器官_表示 = e.虫性_甲殻右_甲殻2_器官_表示;
			this.虫性_甲殻右_甲殻1_甲殻_表示 = e.虫性_甲殻右_甲殻1_甲殻_表示;
			this.虫性_甲殻右_甲殻1_器官_表示 = e.虫性_甲殻右_甲殻1_器官_表示;
			this.傷X左_表示 = e.傷X左_表示;
			this.傷X右_表示 = e.傷X右_表示;
			this.ハイライト外左_表示 = e.ハイライト外左_表示;
			this.ハイライト外右_表示 = e.ハイライト外右_表示;
			this.ハイライト内左_表示 = e.ハイライト内左_表示;
			this.ハイライト内右_表示 = e.ハイライト内右_表示;
			this.ハイライト表示 = e.ハイライト表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.首_接続.Count > 0)
			{
				Ele f;
				this.首_接続 = e.首_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.胸_首_接続;
					f.接続(CS$<>8__locals1.<>4__this.首_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.肩左_接続.Count > 0)
			{
				Ele f;
				this.肩左_接続 = e.肩左_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.胸_肩左_接続;
					f.接続(CS$<>8__locals1.<>4__this.肩左_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.肩右_接続.Count > 0)
			{
				Ele f;
				this.肩右_接続 = e.肩右_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.胸_肩右_接続;
					f.接続(CS$<>8__locals1.<>4__this.肩右_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.胸左_接続.Count > 0)
			{
				Ele f;
				this.胸左_接続 = e.胸左_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.胸_胸左_接続;
					f.接続(CS$<>8__locals1.<>4__this.胸左_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.胸右_接続.Count > 0)
			{
				Ele f;
				this.胸右_接続 = e.胸右_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.胸_胸右_接続;
					f.接続(CS$<>8__locals1.<>4__this.胸右_接続点);
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
					f.接続情報 = 接続情報.胸_肌_接続;
					f.接続(CS$<>8__locals1.<>4__this.肌_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.翼上左_接続.Count > 0)
			{
				Ele f;
				this.翼上左_接続 = e.翼上左_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.胸_翼上左_接続;
					f.接続(CS$<>8__locals1.<>4__this.翼上左_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.翼上右_接続.Count > 0)
			{
				Ele f;
				this.翼上右_接続 = e.翼上右_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.胸_翼上右_接続;
					f.接続(CS$<>8__locals1.<>4__this.翼上右_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.翼下左_接続.Count > 0)
			{
				Ele f;
				this.翼下左_接続 = e.翼下左_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.胸_翼下左_接続;
					f.接続(CS$<>8__locals1.<>4__this.翼下左_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.翼下右_接続.Count > 0)
			{
				Ele f;
				this.翼下右_接続 = e.翼下右_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.胸_翼下右_接続;
					f.接続(CS$<>8__locals1.<>4__this.翼下右_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.背中_接続.Count > 0)
			{
				Ele f;
				this.背中_接続 = e.背中_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.胸_背中_接続;
					f.接続(CS$<>8__locals1.<>4__this.背中_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_胸郭CP = new ColorP(this.X0Y0_胸郭, this.胸郭CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_筋肉_筋肉左CP = new ColorP(this.X0Y0_筋肉_筋肉左, this.筋肉_筋肉左CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_筋肉_筋肉右CP = new ColorP(this.X0Y0_筋肉_筋肉右, this.筋肉_筋肉右CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_筋肉_筋肉中CP = new ColorP(this.X0Y0_筋肉_筋肉中, this.筋肉_筋肉中CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_筋肉_筋肉左下CP = new ColorP(this.X0Y0_筋肉_筋肉左下, this.筋肉_筋肉左下CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_筋肉_筋肉左中CP = new ColorP(this.X0Y0_筋肉_筋肉左中, this.筋肉_筋肉左中CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_筋肉_筋肉左上CP = new ColorP(this.X0Y0_筋肉_筋肉左上, this.筋肉_筋肉左上CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_筋肉_筋肉右下CP = new ColorP(this.X0Y0_筋肉_筋肉右下, this.筋肉_筋肉右下CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_筋肉_筋肉右中CP = new ColorP(this.X0Y0_筋肉_筋肉右中, this.筋肉_筋肉右中CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_筋肉_筋肉右上CP = new ColorP(this.X0Y0_筋肉_筋肉右上, this.筋肉_筋肉右上CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_紋柄_紋左_紋1CP = new ColorP(this.X0Y0_紋柄_紋左_紋1, this.紋柄_紋左_紋1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_紋柄_紋左_紋2CP = new ColorP(this.X0Y0_紋柄_紋左_紋2, this.紋柄_紋左_紋2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_紋柄_紋左_紋3CP = new ColorP(this.X0Y0_紋柄_紋左_紋3, this.紋柄_紋左_紋3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_紋柄_紋左_紋4CP = new ColorP(this.X0Y0_紋柄_紋左_紋4, this.紋柄_紋左_紋4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_紋柄_紋右_紋1CP = new ColorP(this.X0Y0_紋柄_紋右_紋1, this.紋柄_紋右_紋1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_紋柄_紋右_紋2CP = new ColorP(this.X0Y0_紋柄_紋右_紋2, this.紋柄_紋右_紋2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_紋柄_紋右_紋3CP = new ColorP(this.X0Y0_紋柄_紋右_紋3, this.紋柄_紋右_紋3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_紋柄_紋右_紋4CP = new ColorP(this.X0Y0_紋柄_紋右_紋4, this.紋柄_紋右_紋4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_タトゥ左CP = new ColorP(this.X0Y0_淫タトゥ_タトゥ左, this.淫タトゥ_タトゥ左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_タトゥ右CP = new ColorP(this.X0Y0_淫タトゥ_タトゥ右, this.淫タトゥ_タトゥ右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_タトゥ左1CP = new ColorP(this.X0Y0_悪タトゥ_タトゥ左1, this.悪タトゥ_タトゥ左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_タトゥ左2CP = new ColorP(this.X0Y0_悪タトゥ_タトゥ左2, this.悪タトゥ_タトゥ左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_タトゥ左3CP = new ColorP(this.X0Y0_悪タトゥ_タトゥ左3, this.悪タトゥ_タトゥ左3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_タトゥ右1CP = new ColorP(this.X0Y0_悪タトゥ_タトゥ右1, this.悪タトゥ_タトゥ右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_タトゥ右2CP = new ColorP(this.X0Y0_悪タトゥ_タトゥ右2, this.悪タトゥ_タトゥ右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_タトゥ右3CP = new ColorP(this.X0Y0_悪タトゥ_タトゥ右3, this.悪タトゥ_タトゥ右3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_植タトゥ_左_上_タトゥ1CP = new ColorP(this.X0Y0_植タトゥ_左_上_タトゥ1, this.植タトゥ_左_上_タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_植タトゥ_左_上_タトゥ2CP = new ColorP(this.X0Y0_植タトゥ_左_上_タトゥ2, this.植タトゥ_左_上_タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_植タトゥ_左_下_タトゥ1CP = new ColorP(this.X0Y0_植タトゥ_左_下_タトゥ1, this.植タトゥ_左_下_タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_植タトゥ_左_下_タトゥ2CP = new ColorP(this.X0Y0_植タトゥ_左_下_タトゥ2, this.植タトゥ_左_下_タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_植タトゥ_右_上_タトゥ1CP = new ColorP(this.X0Y0_植タトゥ_右_上_タトゥ1, this.植タトゥ_右_上_タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_植タトゥ_右_上_タトゥ2CP = new ColorP(this.X0Y0_植タトゥ_右_上_タトゥ2, this.植タトゥ_右_上_タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_植タトゥ_右_下_タトゥ1CP = new ColorP(this.X0Y0_植タトゥ_右_下_タトゥ1, this.植タトゥ_右_下_タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_植タトゥ_右_下_タトゥ2CP = new ColorP(this.X0Y0_植タトゥ_右_下_タトゥ2, this.植タトゥ_右_下_タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_獣性_獣毛左1CP = new ColorP(this.X0Y0_獣性_獣毛左1, this.獣性_獣毛左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_獣性_獣毛左2CP = new ColorP(this.X0Y0_獣性_獣毛左2, this.獣性_獣毛左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_獣性_獣毛右1CP = new ColorP(this.X0Y0_獣性_獣毛右1, this.獣性_獣毛右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_獣性_獣毛右2CP = new ColorP(this.X0Y0_獣性_獣毛右2, this.獣性_獣毛右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_左_鱗1CP = new ColorP(this.X0Y0_竜性_左_鱗1, this.竜性_左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_左_鱗2CP = new ColorP(this.X0Y0_竜性_左_鱗2, this.竜性_左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_左_鱗3CP = new ColorP(this.X0Y0_竜性_左_鱗3, this.竜性_左_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_右_鱗1CP = new ColorP(this.X0Y0_竜性_右_鱗1, this.竜性_右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_右_鱗2CP = new ColorP(this.X0Y0_竜性_右_鱗2, this.竜性_右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_右_鱗3CP = new ColorP(this.X0Y0_竜性_右_鱗3, this.竜性_右_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫性_甲殻左_甲殻2_甲殻CP = new ColorP(this.X0Y0_虫性_甲殻左_甲殻2_甲殻, this.虫性_甲殻左_甲殻2_甲殻CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫性_甲殻左_甲殻2_器官CP = new ColorP(this.X0Y0_虫性_甲殻左_甲殻2_器官, this.虫性_甲殻左_甲殻2_器官CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫性_甲殻左_甲殻1_甲殻CP = new ColorP(this.X0Y0_虫性_甲殻左_甲殻1_甲殻, this.虫性_甲殻左_甲殻1_甲殻CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫性_甲殻左_甲殻1_器官CP = new ColorP(this.X0Y0_虫性_甲殻左_甲殻1_器官, this.虫性_甲殻左_甲殻1_器官CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫性_甲殻右_甲殻2_甲殻CP = new ColorP(this.X0Y0_虫性_甲殻右_甲殻2_甲殻, this.虫性_甲殻右_甲殻2_甲殻CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫性_甲殻右_甲殻2_器官CP = new ColorP(this.X0Y0_虫性_甲殻右_甲殻2_器官, this.虫性_甲殻右_甲殻2_器官CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫性_甲殻右_甲殻1_甲殻CP = new ColorP(this.X0Y0_虫性_甲殻右_甲殻1_甲殻, this.虫性_甲殻右_甲殻1_甲殻CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫性_甲殻右_甲殻1_器官CP = new ColorP(this.X0Y0_虫性_甲殻右_甲殻1_器官, this.虫性_甲殻右_甲殻1_器官CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_傷X左CP = new ColorP(this.X0Y0_傷X左, this.傷X左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_傷X右CP = new ColorP(this.X0Y0_傷X右, this.傷X右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ハイライト外左CP = new ColorP(this.X0Y0_ハイライト外左, this.ハイライト外左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ハイライト外右CP = new ColorP(this.X0Y0_ハイライト外右, this.ハイライト外右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ハイライト内左CP = new ColorP(this.X0Y0_ハイライト内左, this.ハイライト内左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ハイライト内右CP = new ColorP(this.X0Y0_ハイライト内右, this.ハイライト内右CD, CS$<>8__locals1.DisUnit, true);
			this.筋肉濃度 = e.筋肉濃度;
			this.傷X左濃度 = e.傷X左濃度;
			this.傷X右濃度 = e.傷X右濃度;
			this.ハイライト濃度 = e.ハイライト濃度;
			this.濃度 = e.濃度;
			this.尺度B = 0.99;
			this.尺度YB = 0.99;
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
				this.筋肉_筋肉左_表示 = this.筋肉_;
				this.筋肉_筋肉右_表示 = this.筋肉_;
				this.筋肉_筋肉中_表示 = this.筋肉_;
				this.筋肉_筋肉左下_表示 = this.筋肉_;
				this.筋肉_筋肉左中_表示 = this.筋肉_;
				this.筋肉_筋肉左上_表示 = this.筋肉_;
				this.筋肉_筋肉右下_表示 = this.筋肉_;
				this.筋肉_筋肉右中_表示 = this.筋肉_;
				this.筋肉_筋肉右上_表示 = this.筋肉_;
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

		public bool 胸郭_表示
		{
			get
			{
				return this.X0Y0_胸郭.Dra;
			}
			set
			{
				this.X0Y0_胸郭.Dra = value;
				this.X0Y0_胸郭.Hit = value;
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
				this.X0Y0_筋肉_筋肉左.Hit = value;
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
				this.X0Y0_筋肉_筋肉右.Hit = value;
			}
		}

		public bool 筋肉_筋肉中_表示
		{
			get
			{
				return this.X0Y0_筋肉_筋肉中.Dra;
			}
			set
			{
				this.X0Y0_筋肉_筋肉中.Dra = value;
				this.X0Y0_筋肉_筋肉中.Hit = value;
			}
		}

		public bool 筋肉_筋肉左下_表示
		{
			get
			{
				return this.X0Y0_筋肉_筋肉左下.Dra;
			}
			set
			{
				this.X0Y0_筋肉_筋肉左下.Dra = value;
				this.X0Y0_筋肉_筋肉左下.Hit = value;
			}
		}

		public bool 筋肉_筋肉左中_表示
		{
			get
			{
				return this.X0Y0_筋肉_筋肉左中.Dra;
			}
			set
			{
				this.X0Y0_筋肉_筋肉左中.Dra = value;
				this.X0Y0_筋肉_筋肉左中.Hit = value;
			}
		}

		public bool 筋肉_筋肉左上_表示
		{
			get
			{
				return this.X0Y0_筋肉_筋肉左上.Dra;
			}
			set
			{
				this.X0Y0_筋肉_筋肉左上.Dra = value;
				this.X0Y0_筋肉_筋肉左上.Hit = value;
			}
		}

		public bool 筋肉_筋肉右下_表示
		{
			get
			{
				return this.X0Y0_筋肉_筋肉右下.Dra;
			}
			set
			{
				this.X0Y0_筋肉_筋肉右下.Dra = value;
				this.X0Y0_筋肉_筋肉右下.Hit = value;
			}
		}

		public bool 筋肉_筋肉右中_表示
		{
			get
			{
				return this.X0Y0_筋肉_筋肉右中.Dra;
			}
			set
			{
				this.X0Y0_筋肉_筋肉右中.Dra = value;
				this.X0Y0_筋肉_筋肉右中.Hit = value;
			}
		}

		public bool 筋肉_筋肉右上_表示
		{
			get
			{
				return this.X0Y0_筋肉_筋肉右上.Dra;
			}
			set
			{
				this.X0Y0_筋肉_筋肉右上.Dra = value;
				this.X0Y0_筋肉_筋肉右上.Hit = value;
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
				this.X0Y0_紋柄_紋左_紋1.Hit = value;
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
				this.X0Y0_紋柄_紋左_紋2.Hit = value;
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
				this.X0Y0_紋柄_紋左_紋3.Hit = value;
			}
		}

		public bool 紋柄_紋左_紋4_表示
		{
			get
			{
				return this.X0Y0_紋柄_紋左_紋4.Dra;
			}
			set
			{
				this.X0Y0_紋柄_紋左_紋4.Dra = value;
				this.X0Y0_紋柄_紋左_紋4.Hit = value;
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
				this.X0Y0_紋柄_紋右_紋1.Hit = value;
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
				this.X0Y0_紋柄_紋右_紋2.Hit = value;
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
				this.X0Y0_紋柄_紋右_紋3.Hit = value;
			}
		}

		public bool 紋柄_紋右_紋4_表示
		{
			get
			{
				return this.X0Y0_紋柄_紋右_紋4.Dra;
			}
			set
			{
				this.X0Y0_紋柄_紋右_紋4.Dra = value;
				this.X0Y0_紋柄_紋右_紋4.Hit = value;
			}
		}

		public bool 淫タトゥ_タトゥ左_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_タトゥ左.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_タトゥ左.Dra = value;
				this.X0Y0_淫タトゥ_タトゥ左.Hit = value;
			}
		}

		public bool 淫タトゥ_タトゥ右_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_タトゥ右.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_タトゥ右.Dra = value;
				this.X0Y0_淫タトゥ_タトゥ右.Hit = value;
			}
		}

		public bool 悪タトゥ_タトゥ左1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_タトゥ左1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_タトゥ左1.Dra = value;
				this.X0Y0_悪タトゥ_タトゥ左1.Hit = value;
			}
		}

		public bool 悪タトゥ_タトゥ左2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_タトゥ左2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_タトゥ左2.Dra = value;
				this.X0Y0_悪タトゥ_タトゥ左2.Hit = value;
			}
		}

		public bool 悪タトゥ_タトゥ左3_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_タトゥ左3.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_タトゥ左3.Dra = value;
				this.X0Y0_悪タトゥ_タトゥ左3.Hit = value;
			}
		}

		public bool 悪タトゥ_タトゥ右1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_タトゥ右1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_タトゥ右1.Dra = value;
				this.X0Y0_悪タトゥ_タトゥ右1.Hit = value;
			}
		}

		public bool 悪タトゥ_タトゥ右2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_タトゥ右2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_タトゥ右2.Dra = value;
				this.X0Y0_悪タトゥ_タトゥ右2.Hit = value;
			}
		}

		public bool 悪タトゥ_タトゥ右3_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_タトゥ右3.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_タトゥ右3.Dra = value;
				this.X0Y0_悪タトゥ_タトゥ右3.Hit = value;
			}
		}

		public bool 植タトゥ_左_上_タトゥ1_表示
		{
			get
			{
				return this.X0Y0_植タトゥ_左_上_タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_植タトゥ_左_上_タトゥ1.Dra = value;
				this.X0Y0_植タトゥ_左_上_タトゥ1.Hit = value;
			}
		}

		public bool 植タトゥ_左_上_タトゥ2_表示
		{
			get
			{
				return this.X0Y0_植タトゥ_左_上_タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_植タトゥ_左_上_タトゥ2.Dra = value;
				this.X0Y0_植タトゥ_左_上_タトゥ2.Hit = value;
			}
		}

		public bool 植タトゥ_左_下_タトゥ1_表示
		{
			get
			{
				return this.X0Y0_植タトゥ_左_下_タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_植タトゥ_左_下_タトゥ1.Dra = value;
				this.X0Y0_植タトゥ_左_下_タトゥ1.Hit = value;
			}
		}

		public bool 植タトゥ_左_下_タトゥ2_表示
		{
			get
			{
				return this.X0Y0_植タトゥ_左_下_タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_植タトゥ_左_下_タトゥ2.Dra = value;
				this.X0Y0_植タトゥ_左_下_タトゥ2.Hit = value;
			}
		}

		public bool 植タトゥ_右_上_タトゥ1_表示
		{
			get
			{
				return this.X0Y0_植タトゥ_右_上_タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_植タトゥ_右_上_タトゥ1.Dra = value;
				this.X0Y0_植タトゥ_右_上_タトゥ1.Hit = value;
			}
		}

		public bool 植タトゥ_右_上_タトゥ2_表示
		{
			get
			{
				return this.X0Y0_植タトゥ_右_上_タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_植タトゥ_右_上_タトゥ2.Dra = value;
				this.X0Y0_植タトゥ_右_上_タトゥ2.Hit = value;
			}
		}

		public bool 植タトゥ_右_下_タトゥ1_表示
		{
			get
			{
				return this.X0Y0_植タトゥ_右_下_タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_植タトゥ_右_下_タトゥ1.Dra = value;
				this.X0Y0_植タトゥ_右_下_タトゥ1.Hit = value;
			}
		}

		public bool 植タトゥ_右_下_タトゥ2_表示
		{
			get
			{
				return this.X0Y0_植タトゥ_右_下_タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_植タトゥ_右_下_タトゥ2.Dra = value;
				this.X0Y0_植タトゥ_右_下_タトゥ2.Hit = value;
			}
		}

		public bool 獣性_獣毛左1_表示
		{
			get
			{
				return this.X0Y0_獣性_獣毛左1.Dra;
			}
			set
			{
				this.X0Y0_獣性_獣毛左1.Dra = value;
				this.X0Y0_獣性_獣毛左1.Hit = value;
			}
		}

		public bool 獣性_獣毛左2_表示
		{
			get
			{
				return this.X0Y0_獣性_獣毛左2.Dra;
			}
			set
			{
				this.X0Y0_獣性_獣毛左2.Dra = value;
				this.X0Y0_獣性_獣毛左2.Hit = value;
			}
		}

		public bool 獣性_獣毛右1_表示
		{
			get
			{
				return this.X0Y0_獣性_獣毛右1.Dra;
			}
			set
			{
				this.X0Y0_獣性_獣毛右1.Dra = value;
				this.X0Y0_獣性_獣毛右1.Hit = value;
			}
		}

		public bool 獣性_獣毛右2_表示
		{
			get
			{
				return this.X0Y0_獣性_獣毛右2.Dra;
			}
			set
			{
				this.X0Y0_獣性_獣毛右2.Dra = value;
				this.X0Y0_獣性_獣毛右2.Hit = value;
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
				this.X0Y0_竜性_左_鱗1.Hit = value;
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
				this.X0Y0_竜性_左_鱗2.Hit = value;
			}
		}

		public bool 竜性_左_鱗3_表示
		{
			get
			{
				return this.X0Y0_竜性_左_鱗3.Dra;
			}
			set
			{
				this.X0Y0_竜性_左_鱗3.Dra = value;
				this.X0Y0_竜性_左_鱗3.Hit = value;
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
				this.X0Y0_竜性_右_鱗1.Hit = value;
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
				this.X0Y0_竜性_右_鱗2.Hit = value;
			}
		}

		public bool 竜性_右_鱗3_表示
		{
			get
			{
				return this.X0Y0_竜性_右_鱗3.Dra;
			}
			set
			{
				this.X0Y0_竜性_右_鱗3.Dra = value;
				this.X0Y0_竜性_右_鱗3.Hit = value;
			}
		}

		public bool 虫性_甲殻左_甲殻2_甲殻_表示
		{
			get
			{
				return this.X0Y0_虫性_甲殻左_甲殻2_甲殻.Dra;
			}
			set
			{
				this.X0Y0_虫性_甲殻左_甲殻2_甲殻.Dra = value;
				this.X0Y0_虫性_甲殻左_甲殻2_甲殻.Hit = value;
			}
		}

		public bool 虫性_甲殻左_甲殻2_器官_表示
		{
			get
			{
				return this.X0Y0_虫性_甲殻左_甲殻2_器官.Dra;
			}
			set
			{
				this.X0Y0_虫性_甲殻左_甲殻2_器官.Dra = value;
				this.X0Y0_虫性_甲殻左_甲殻2_器官.Hit = value;
			}
		}

		public bool 虫性_甲殻左_甲殻1_甲殻_表示
		{
			get
			{
				return this.X0Y0_虫性_甲殻左_甲殻1_甲殻.Dra;
			}
			set
			{
				this.X0Y0_虫性_甲殻左_甲殻1_甲殻.Dra = value;
				this.X0Y0_虫性_甲殻左_甲殻1_甲殻.Hit = value;
			}
		}

		public bool 虫性_甲殻左_甲殻1_器官_表示
		{
			get
			{
				return this.X0Y0_虫性_甲殻左_甲殻1_器官.Dra;
			}
			set
			{
				this.X0Y0_虫性_甲殻左_甲殻1_器官.Dra = value;
				this.X0Y0_虫性_甲殻左_甲殻1_器官.Hit = value;
			}
		}

		public bool 虫性_甲殻右_甲殻2_甲殻_表示
		{
			get
			{
				return this.X0Y0_虫性_甲殻右_甲殻2_甲殻.Dra;
			}
			set
			{
				this.X0Y0_虫性_甲殻右_甲殻2_甲殻.Dra = value;
				this.X0Y0_虫性_甲殻右_甲殻2_甲殻.Hit = value;
			}
		}

		public bool 虫性_甲殻右_甲殻2_器官_表示
		{
			get
			{
				return this.X0Y0_虫性_甲殻右_甲殻2_器官.Dra;
			}
			set
			{
				this.X0Y0_虫性_甲殻右_甲殻2_器官.Dra = value;
				this.X0Y0_虫性_甲殻右_甲殻2_器官.Hit = value;
			}
		}

		public bool 虫性_甲殻右_甲殻1_甲殻_表示
		{
			get
			{
				return this.X0Y0_虫性_甲殻右_甲殻1_甲殻.Dra;
			}
			set
			{
				this.X0Y0_虫性_甲殻右_甲殻1_甲殻.Dra = value;
				this.X0Y0_虫性_甲殻右_甲殻1_甲殻.Hit = value;
			}
		}

		public bool 虫性_甲殻右_甲殻1_器官_表示
		{
			get
			{
				return this.X0Y0_虫性_甲殻右_甲殻1_器官.Dra;
			}
			set
			{
				this.X0Y0_虫性_甲殻右_甲殻1_器官.Dra = value;
				this.X0Y0_虫性_甲殻右_甲殻1_器官.Hit = value;
			}
		}

		public bool 傷X左_表示
		{
			get
			{
				return this.X0Y0_傷X左.Dra;
			}
			set
			{
				this.X0Y0_傷X左.Dra = value;
				this.X0Y0_傷X左.Hit = value;
			}
		}

		public bool 傷X右_表示
		{
			get
			{
				return this.X0Y0_傷X右.Dra;
			}
			set
			{
				this.X0Y0_傷X右.Dra = value;
				this.X0Y0_傷X右.Hit = value;
			}
		}

		public bool ハイライト外左_表示
		{
			get
			{
				return this.X0Y0_ハイライト外左.Dra;
			}
			set
			{
				this.X0Y0_ハイライト外左.Dra = value;
				this.X0Y0_ハイライト外左.Hit = value;
			}
		}

		public bool ハイライト外右_表示
		{
			get
			{
				return this.X0Y0_ハイライト外右.Dra;
			}
			set
			{
				this.X0Y0_ハイライト外右.Dra = value;
				this.X0Y0_ハイライト外右.Hit = value;
			}
		}

		public bool ハイライト内左_表示
		{
			get
			{
				return this.X0Y0_ハイライト内左.Dra;
			}
			set
			{
				this.X0Y0_ハイライト内左.Dra = value;
				this.X0Y0_ハイライト内左.Hit = value;
			}
		}

		public bool ハイライト内右_表示
		{
			get
			{
				return this.X0Y0_ハイライト内右.Dra;
			}
			set
			{
				this.X0Y0_ハイライト内右.Dra = value;
				this.X0Y0_ハイライト内右.Hit = value;
			}
		}

		public bool ハイライト表示
		{
			get
			{
				return this.ハイライト外左_表示;
			}
			set
			{
				this.ハイライト外左_表示 = value;
				this.ハイライト外右_表示 = value;
				this.ハイライト内左_表示 = value;
				this.ハイライト内右_表示 = value;
			}
		}

		public double 筋肉濃度
		{
			get
			{
				return this.筋肉_筋肉左CD.不透明度;
			}
			set
			{
				this.筋肉_筋肉左CD.不透明度 = value;
				this.筋肉_筋肉右CD.不透明度 = value;
				this.筋肉_筋肉中CD.不透明度 = value;
				this.筋肉_筋肉左下CD.不透明度 = value;
				this.筋肉_筋肉左中CD.不透明度 = value;
				this.筋肉_筋肉左上CD.不透明度 = value;
				this.筋肉_筋肉右下CD.不透明度 = value;
				this.筋肉_筋肉右中CD.不透明度 = value;
				this.筋肉_筋肉右上CD.不透明度 = value;
			}
		}

		public double 傷X左濃度
		{
			get
			{
				return this.傷X左CD.不透明度;
			}
			set
			{
				this.傷X左CD.不透明度 = value;
			}
		}

		public double 傷X右濃度
		{
			get
			{
				return this.傷X右CD.不透明度;
			}
			set
			{
				this.傷X右CD.不透明度 = value;
			}
		}

		public double ハイライト濃度
		{
			get
			{
				return this.ハイライト外左CD.不透明度;
			}
			set
			{
				this.ハイライト外左CD.不透明度 = value;
				this.ハイライト外右CD.不透明度 = value;
				this.ハイライト内左CD.不透明度 = value;
				this.ハイライト内右CD.不透明度 = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.胸郭_表示;
			}
			set
			{
				this.胸郭_表示 = value;
				this.筋肉_筋肉左_表示 = value;
				this.筋肉_筋肉右_表示 = value;
				this.筋肉_筋肉中_表示 = value;
				this.筋肉_筋肉左下_表示 = value;
				this.筋肉_筋肉左中_表示 = value;
				this.筋肉_筋肉左上_表示 = value;
				this.筋肉_筋肉右下_表示 = value;
				this.筋肉_筋肉右中_表示 = value;
				this.筋肉_筋肉右上_表示 = value;
				this.紋柄_紋左_紋1_表示 = value;
				this.紋柄_紋左_紋2_表示 = value;
				this.紋柄_紋左_紋3_表示 = value;
				this.紋柄_紋左_紋4_表示 = value;
				this.紋柄_紋右_紋1_表示 = value;
				this.紋柄_紋右_紋2_表示 = value;
				this.紋柄_紋右_紋3_表示 = value;
				this.紋柄_紋右_紋4_表示 = value;
				this.淫タトゥ_タトゥ左_表示 = value;
				this.淫タトゥ_タトゥ右_表示 = value;
				this.悪タトゥ_タトゥ左1_表示 = value;
				this.悪タトゥ_タトゥ左2_表示 = value;
				this.悪タトゥ_タトゥ左3_表示 = value;
				this.悪タトゥ_タトゥ右1_表示 = value;
				this.悪タトゥ_タトゥ右2_表示 = value;
				this.悪タトゥ_タトゥ右3_表示 = value;
				this.植タトゥ_左_上_タトゥ1_表示 = value;
				this.植タトゥ_左_上_タトゥ2_表示 = value;
				this.植タトゥ_左_下_タトゥ1_表示 = value;
				this.植タトゥ_左_下_タトゥ2_表示 = value;
				this.植タトゥ_右_上_タトゥ1_表示 = value;
				this.植タトゥ_右_上_タトゥ2_表示 = value;
				this.植タトゥ_右_下_タトゥ1_表示 = value;
				this.植タトゥ_右_下_タトゥ2_表示 = value;
				this.獣性_獣毛左1_表示 = value;
				this.獣性_獣毛左2_表示 = value;
				this.獣性_獣毛右1_表示 = value;
				this.獣性_獣毛右2_表示 = value;
				this.竜性_左_鱗1_表示 = value;
				this.竜性_左_鱗2_表示 = value;
				this.竜性_左_鱗3_表示 = value;
				this.竜性_右_鱗1_表示 = value;
				this.竜性_右_鱗2_表示 = value;
				this.竜性_右_鱗3_表示 = value;
				this.虫性_甲殻左_甲殻2_甲殻_表示 = value;
				this.虫性_甲殻左_甲殻2_器官_表示 = value;
				this.虫性_甲殻左_甲殻1_甲殻_表示 = value;
				this.虫性_甲殻左_甲殻1_器官_表示 = value;
				this.虫性_甲殻右_甲殻2_甲殻_表示 = value;
				this.虫性_甲殻右_甲殻2_器官_表示 = value;
				this.虫性_甲殻右_甲殻1_甲殻_表示 = value;
				this.虫性_甲殻右_甲殻1_器官_表示 = value;
				this.傷X左_表示 = value;
				this.傷X右_表示 = value;
				this.ハイライト外左_表示 = value;
				this.ハイライト外右_表示 = value;
				this.ハイライト内左_表示 = value;
				this.ハイライト内右_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.胸郭CD.不透明度;
			}
			set
			{
				this.胸郭CD.不透明度 = value;
				this.筋肉_筋肉左CD.不透明度 = value;
				this.筋肉_筋肉右CD.不透明度 = value;
				this.筋肉_筋肉中CD.不透明度 = value;
				this.筋肉_筋肉左下CD.不透明度 = value;
				this.筋肉_筋肉左中CD.不透明度 = value;
				this.筋肉_筋肉左上CD.不透明度 = value;
				this.筋肉_筋肉右下CD.不透明度 = value;
				this.筋肉_筋肉右中CD.不透明度 = value;
				this.筋肉_筋肉右上CD.不透明度 = value;
				this.紋柄_紋左_紋1CD.不透明度 = value;
				this.紋柄_紋左_紋2CD.不透明度 = value;
				this.紋柄_紋左_紋3CD.不透明度 = value;
				this.紋柄_紋左_紋4CD.不透明度 = value;
				this.紋柄_紋右_紋1CD.不透明度 = value;
				this.紋柄_紋右_紋2CD.不透明度 = value;
				this.紋柄_紋右_紋3CD.不透明度 = value;
				this.紋柄_紋右_紋4CD.不透明度 = value;
				this.淫タトゥ_タトゥ左CD.不透明度 = value;
				this.淫タトゥ_タトゥ右CD.不透明度 = value;
				this.悪タトゥ_タトゥ左1CD.不透明度 = value;
				this.悪タトゥ_タトゥ左2CD.不透明度 = value;
				this.悪タトゥ_タトゥ左3CD.不透明度 = value;
				this.悪タトゥ_タトゥ右1CD.不透明度 = value;
				this.悪タトゥ_タトゥ右2CD.不透明度 = value;
				this.悪タトゥ_タトゥ右3CD.不透明度 = value;
				this.植タトゥ_左_上_タトゥ1CD.不透明度 = value;
				this.植タトゥ_左_上_タトゥ2CD.不透明度 = value;
				this.植タトゥ_左_下_タトゥ1CD.不透明度 = value;
				this.植タトゥ_左_下_タトゥ2CD.不透明度 = value;
				this.植タトゥ_右_上_タトゥ1CD.不透明度 = value;
				this.植タトゥ_右_上_タトゥ2CD.不透明度 = value;
				this.植タトゥ_右_下_タトゥ1CD.不透明度 = value;
				this.植タトゥ_右_下_タトゥ2CD.不透明度 = value;
				this.獣性_獣毛左1CD.不透明度 = value;
				this.獣性_獣毛左2CD.不透明度 = value;
				this.獣性_獣毛右1CD.不透明度 = value;
				this.獣性_獣毛右2CD.不透明度 = value;
				this.竜性_左_鱗1CD.不透明度 = value;
				this.竜性_左_鱗2CD.不透明度 = value;
				this.竜性_左_鱗3CD.不透明度 = value;
				this.竜性_右_鱗1CD.不透明度 = value;
				this.竜性_右_鱗2CD.不透明度 = value;
				this.竜性_右_鱗3CD.不透明度 = value;
				this.虫性_甲殻左_甲殻2_甲殻CD.不透明度 = value;
				this.虫性_甲殻左_甲殻2_器官CD.不透明度 = value;
				this.虫性_甲殻左_甲殻1_甲殻CD.不透明度 = value;
				this.虫性_甲殻左_甲殻1_器官CD.不透明度 = value;
				this.虫性_甲殻右_甲殻2_甲殻CD.不透明度 = value;
				this.虫性_甲殻右_甲殻2_器官CD.不透明度 = value;
				this.虫性_甲殻右_甲殻1_甲殻CD.不透明度 = value;
				this.虫性_甲殻右_甲殻1_器官CD.不透明度 = value;
				this.傷X左CD.不透明度 = value;
				this.傷X右CD.不透明度 = value;
				this.ハイライト外左CD.不透明度 = value;
				this.ハイライト外右CD.不透明度 = value;
				this.ハイライト内左CD.不透明度 = value;
				this.ハイライト内右CD.不透明度 = value;
			}
		}

		public override void 描画0(Are Are)
		{
			Are.Draw(this.X0Y0_胸郭);
			Are.Draw(this.X0Y0_筋肉_筋肉左);
			Are.Draw(this.X0Y0_筋肉_筋肉右);
			Are.Draw(this.X0Y0_筋肉_筋肉中);
			Are.Draw(this.X0Y0_筋肉_筋肉左下);
			Are.Draw(this.X0Y0_筋肉_筋肉左中);
			Are.Draw(this.X0Y0_筋肉_筋肉左上);
			Are.Draw(this.X0Y0_筋肉_筋肉右下);
			Are.Draw(this.X0Y0_筋肉_筋肉右中);
			Are.Draw(this.X0Y0_筋肉_筋肉右上);
			Are.Draw(this.X0Y0_紋柄_紋左_紋1);
			Are.Draw(this.X0Y0_紋柄_紋左_紋2);
			Are.Draw(this.X0Y0_紋柄_紋左_紋3);
			Are.Draw(this.X0Y0_紋柄_紋左_紋4);
			Are.Draw(this.X0Y0_紋柄_紋右_紋1);
			Are.Draw(this.X0Y0_紋柄_紋右_紋2);
			Are.Draw(this.X0Y0_紋柄_紋右_紋3);
			Are.Draw(this.X0Y0_紋柄_紋右_紋4);
			Are.Draw(this.X0Y0_淫タトゥ_タトゥ左);
			Are.Draw(this.X0Y0_淫タトゥ_タトゥ右);
			Are.Draw(this.X0Y0_悪タトゥ_タトゥ左1);
			Are.Draw(this.X0Y0_悪タトゥ_タトゥ左2);
			Are.Draw(this.X0Y0_悪タトゥ_タトゥ左3);
			Are.Draw(this.X0Y0_悪タトゥ_タトゥ右1);
			Are.Draw(this.X0Y0_悪タトゥ_タトゥ右2);
			Are.Draw(this.X0Y0_悪タトゥ_タトゥ右3);
			Are.Draw(this.X0Y0_植タトゥ_左_上_タトゥ1);
			Are.Draw(this.X0Y0_植タトゥ_左_上_タトゥ2);
			Are.Draw(this.X0Y0_植タトゥ_左_下_タトゥ1);
			Are.Draw(this.X0Y0_植タトゥ_左_下_タトゥ2);
			Are.Draw(this.X0Y0_植タトゥ_右_上_タトゥ1);
			Are.Draw(this.X0Y0_植タトゥ_右_上_タトゥ2);
			Are.Draw(this.X0Y0_植タトゥ_右_下_タトゥ1);
			Are.Draw(this.X0Y0_植タトゥ_右_下_タトゥ2);
			Are.Draw(this.X0Y0_獣性_獣毛左1);
			Are.Draw(this.X0Y0_獣性_獣毛左2);
			Are.Draw(this.X0Y0_獣性_獣毛右1);
			Are.Draw(this.X0Y0_獣性_獣毛右2);
			Are.Draw(this.X0Y0_竜性_左_鱗1);
			Are.Draw(this.X0Y0_竜性_左_鱗2);
			Are.Draw(this.X0Y0_竜性_左_鱗3);
			Are.Draw(this.X0Y0_竜性_右_鱗1);
			Are.Draw(this.X0Y0_竜性_右_鱗2);
			Are.Draw(this.X0Y0_竜性_右_鱗3);
			Are.Draw(this.X0Y0_傷X左);
			Are.Draw(this.X0Y0_傷X右);
			this.キスマ\u30FCク.Draw(Are);
			this.鞭痕.Draw(Are);
			Are.Draw(this.X0Y0_虫性_甲殻左_甲殻2_甲殻);
			Are.Draw(this.X0Y0_虫性_甲殻左_甲殻2_器官);
			Are.Draw(this.X0Y0_虫性_甲殻左_甲殻1_甲殻);
			Are.Draw(this.X0Y0_虫性_甲殻左_甲殻1_器官);
			Are.Draw(this.X0Y0_虫性_甲殻右_甲殻2_甲殻);
			Are.Draw(this.X0Y0_虫性_甲殻右_甲殻2_器官);
			Are.Draw(this.X0Y0_虫性_甲殻右_甲殻1_甲殻);
			Are.Draw(this.X0Y0_虫性_甲殻右_甲殻1_器官);
			Are.Draw(this.X0Y0_ハイライト外左);
			Are.Draw(this.X0Y0_ハイライト外右);
			Are.Draw(this.X0Y0_ハイライト内左);
			Are.Draw(this.X0Y0_ハイライト内右);
		}

		public JointS 首_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胸郭, 0);
			}
		}

		public JointS 肩左_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胸郭, 1);
			}
		}

		public JointS 肩右_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胸郭, 2);
			}
		}

		public JointS 胸左_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胸郭, 3);
			}
		}

		public JointS 胸右_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胸郭, 4);
			}
		}

		public JointS 肌_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胸郭, 10);
			}
		}

		public JointS 翼上左_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胸郭, 8);
			}
		}

		public JointS 翼上右_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胸郭, 9);
			}
		}

		public JointS 翼下左_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胸郭, 11);
			}
		}

		public JointS 翼下右_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胸郭, 12);
			}
		}

		public JointS 背中_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胸郭, 10);
			}
		}

		public override void 色更新()
		{
			this.X0Y0_胸郭CP.Update();
			this.X0Y0_筋肉_筋肉左CP.Update();
			this.X0Y0_筋肉_筋肉右CP.Update();
			this.X0Y0_筋肉_筋肉中CP.Update();
			this.X0Y0_筋肉_筋肉左下CP.Update();
			this.X0Y0_筋肉_筋肉左中CP.Update();
			this.X0Y0_筋肉_筋肉左上CP.Update();
			this.X0Y0_筋肉_筋肉右下CP.Update();
			this.X0Y0_筋肉_筋肉右中CP.Update();
			this.X0Y0_筋肉_筋肉右上CP.Update();
			this.X0Y0_紋柄_紋左_紋1CP.Update();
			this.X0Y0_紋柄_紋左_紋2CP.Update();
			this.X0Y0_紋柄_紋左_紋3CP.Update();
			this.X0Y0_紋柄_紋左_紋4CP.Update();
			this.X0Y0_紋柄_紋右_紋1CP.Update();
			this.X0Y0_紋柄_紋右_紋2CP.Update();
			this.X0Y0_紋柄_紋右_紋3CP.Update();
			this.X0Y0_紋柄_紋右_紋4CP.Update();
			this.X0Y0_淫タトゥ_タトゥ左CP.Update();
			this.X0Y0_淫タトゥ_タトゥ右CP.Update();
			this.X0Y0_悪タトゥ_タトゥ左1CP.Update();
			this.X0Y0_悪タトゥ_タトゥ左2CP.Update();
			this.X0Y0_悪タトゥ_タトゥ左3CP.Update();
			this.X0Y0_悪タトゥ_タトゥ右1CP.Update();
			this.X0Y0_悪タトゥ_タトゥ右2CP.Update();
			this.X0Y0_悪タトゥ_タトゥ右3CP.Update();
			this.X0Y0_植タトゥ_左_上_タトゥ1CP.Update();
			this.X0Y0_植タトゥ_左_上_タトゥ2CP.Update();
			this.X0Y0_植タトゥ_左_下_タトゥ1CP.Update();
			this.X0Y0_植タトゥ_左_下_タトゥ2CP.Update();
			this.X0Y0_植タトゥ_右_上_タトゥ1CP.Update();
			this.X0Y0_植タトゥ_右_上_タトゥ2CP.Update();
			this.X0Y0_植タトゥ_右_下_タトゥ1CP.Update();
			this.X0Y0_植タトゥ_右_下_タトゥ2CP.Update();
			this.X0Y0_獣性_獣毛左1CP.Update();
			this.X0Y0_獣性_獣毛左2CP.Update();
			this.X0Y0_獣性_獣毛右1CP.Update();
			this.X0Y0_獣性_獣毛右2CP.Update();
			this.X0Y0_竜性_左_鱗1CP.Update();
			this.X0Y0_竜性_左_鱗2CP.Update();
			this.X0Y0_竜性_左_鱗3CP.Update();
			this.X0Y0_竜性_右_鱗1CP.Update();
			this.X0Y0_竜性_右_鱗2CP.Update();
			this.X0Y0_竜性_右_鱗3CP.Update();
			this.X0Y0_虫性_甲殻左_甲殻2_甲殻CP.Update();
			this.X0Y0_虫性_甲殻左_甲殻2_器官CP.Update();
			this.X0Y0_虫性_甲殻左_甲殻1_甲殻CP.Update();
			this.X0Y0_虫性_甲殻左_甲殻1_器官CP.Update();
			this.X0Y0_虫性_甲殻右_甲殻2_甲殻CP.Update();
			this.X0Y0_虫性_甲殻右_甲殻2_器官CP.Update();
			this.X0Y0_虫性_甲殻右_甲殻1_甲殻CP.Update();
			this.X0Y0_虫性_甲殻右_甲殻1_器官CP.Update();
			this.X0Y0_傷X左CP.Update();
			this.X0Y0_傷X右CP.Update();
			this.X0Y0_ハイライト外左CP.Update();
			this.X0Y0_ハイライト外右CP.Update();
			this.X0Y0_ハイライト内左CP.Update();
			this.X0Y0_ハイライト内右CP.Update();
		}

		public override void 色更新(Vector2D[] mm)
		{
			this.X0Y0_胸郭CP.Update(mm);
			this.X0Y0_筋肉_筋肉左CP.Update();
			this.X0Y0_筋肉_筋肉右CP.Update();
			this.X0Y0_筋肉_筋肉中CP.Update();
			this.X0Y0_筋肉_筋肉左下CP.Update();
			this.X0Y0_筋肉_筋肉左中CP.Update();
			this.X0Y0_筋肉_筋肉左上CP.Update();
			this.X0Y0_筋肉_筋肉右下CP.Update();
			this.X0Y0_筋肉_筋肉右中CP.Update();
			this.X0Y0_筋肉_筋肉右上CP.Update();
			this.X0Y0_紋柄_紋左_紋1CP.Update();
			this.X0Y0_紋柄_紋左_紋2CP.Update();
			this.X0Y0_紋柄_紋左_紋3CP.Update();
			this.X0Y0_紋柄_紋左_紋4CP.Update();
			this.X0Y0_紋柄_紋右_紋1CP.Update();
			this.X0Y0_紋柄_紋右_紋2CP.Update();
			this.X0Y0_紋柄_紋右_紋3CP.Update();
			this.X0Y0_紋柄_紋右_紋4CP.Update();
			this.X0Y0_淫タトゥ_タトゥ左CP.Update();
			this.X0Y0_淫タトゥ_タトゥ右CP.Update();
			this.X0Y0_悪タトゥ_タトゥ左1CP.Update();
			this.X0Y0_悪タトゥ_タトゥ左2CP.Update();
			this.X0Y0_悪タトゥ_タトゥ左3CP.Update();
			this.X0Y0_悪タトゥ_タトゥ右1CP.Update();
			this.X0Y0_悪タトゥ_タトゥ右2CP.Update();
			this.X0Y0_悪タトゥ_タトゥ右3CP.Update();
			this.X0Y0_植タトゥ_左_上_タトゥ1CP.Update();
			this.X0Y0_植タトゥ_左_上_タトゥ2CP.Update();
			this.X0Y0_植タトゥ_左_下_タトゥ1CP.Update();
			this.X0Y0_植タトゥ_左_下_タトゥ2CP.Update();
			this.X0Y0_植タトゥ_右_上_タトゥ1CP.Update();
			this.X0Y0_植タトゥ_右_上_タトゥ2CP.Update();
			this.X0Y0_植タトゥ_右_下_タトゥ1CP.Update();
			this.X0Y0_植タトゥ_右_下_タトゥ2CP.Update();
			this.X0Y0_獣性_獣毛左1CP.Update();
			this.X0Y0_獣性_獣毛左2CP.Update();
			this.X0Y0_獣性_獣毛右1CP.Update();
			this.X0Y0_獣性_獣毛右2CP.Update();
			this.X0Y0_竜性_左_鱗1CP.Update();
			this.X0Y0_竜性_左_鱗2CP.Update();
			this.X0Y0_竜性_左_鱗3CP.Update();
			this.X0Y0_竜性_右_鱗1CP.Update();
			this.X0Y0_竜性_右_鱗2CP.Update();
			this.X0Y0_竜性_右_鱗3CP.Update();
			this.X0Y0_虫性_甲殻左_甲殻2_甲殻CP.Update();
			this.X0Y0_虫性_甲殻左_甲殻2_器官CP.Update();
			this.X0Y0_虫性_甲殻左_甲殻1_甲殻CP.Update();
			this.X0Y0_虫性_甲殻左_甲殻1_器官CP.Update();
			this.X0Y0_虫性_甲殻右_甲殻2_甲殻CP.Update();
			this.X0Y0_虫性_甲殻右_甲殻2_器官CP.Update();
			this.X0Y0_虫性_甲殻右_甲殻1_甲殻CP.Update();
			this.X0Y0_虫性_甲殻右_甲殻1_器官CP.Update();
			this.X0Y0_傷X左CP.Update();
			this.X0Y0_傷X右CP.Update();
			this.X0Y0_ハイライト外左CP.Update();
			this.X0Y0_ハイライト外右CP.Update();
			this.X0Y0_ハイライト内左CP.Update();
			this.X0Y0_ハイライト内右CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.胸郭CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.筋肉_筋肉左CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.筋肉_筋肉右CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.筋肉_筋肉中CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.筋肉_筋肉左下CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.筋肉_筋肉左中CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.筋肉_筋肉左上CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.筋肉_筋肉右下CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.筋肉_筋肉右中CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.筋肉_筋肉右上CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.紋柄_紋左_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋左_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋左_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋左_紋4CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋右_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋右_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋右_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋右_紋4CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.淫タトゥ_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ左1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ左2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ左3CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ右1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ右2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ右3CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.植タトゥ_左_上_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.植タトゥ_左_上_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.植タトゥ_左_下_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.植タトゥ_左_下_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.植タトゥ_右_上_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.植タトゥ_右_上_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.植タトゥ_右_下_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.植タトゥ_右_下_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.獣性_獣毛左1CD = new ColorD(ref Col.Empty, ref 体配色.毛0O);
			this.獣性_獣毛左2CD = new ColorD(ref Col.Empty, ref 体配色.毛0O);
			this.獣性_獣毛右1CD = new ColorD(ref Col.Empty, ref 体配色.毛0O);
			this.獣性_獣毛右2CD = new ColorD(ref Col.Empty, ref 体配色.毛0O);
			this.竜性_左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.虫性_甲殻左_甲殻2_甲殻CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性_甲殻左_甲殻2_器官CD = new ColorD(ref Col.Black, ref 体配色.甲1R);
			this.虫性_甲殻左_甲殻1_甲殻CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性_甲殻左_甲殻1_器官CD = new ColorD(ref Col.Black, ref 体配色.甲1R);
			this.虫性_甲殻右_甲殻2_甲殻CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性_甲殻右_甲殻2_器官CD = new ColorD(ref Col.Black, ref 体配色.甲1R);
			this.虫性_甲殻右_甲殻1_甲殻CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性_甲殻右_甲殻1_器官CD = new ColorD(ref Col.Black, ref 体配色.甲1R);
			this.傷X左CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷X右CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.ハイライト外左CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ハイライト外右CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ハイライト内左CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ハイライト内右CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
		}

		public Par X0Y0_胸郭;

		public Par X0Y0_筋肉_筋肉左;

		public Par X0Y0_筋肉_筋肉右;

		public Par X0Y0_筋肉_筋肉中;

		public Par X0Y0_筋肉_筋肉左下;

		public Par X0Y0_筋肉_筋肉左中;

		public Par X0Y0_筋肉_筋肉左上;

		public Par X0Y0_筋肉_筋肉右下;

		public Par X0Y0_筋肉_筋肉右中;

		public Par X0Y0_筋肉_筋肉右上;

		public Par X0Y0_紋柄_紋左_紋1;

		public Par X0Y0_紋柄_紋左_紋2;

		public Par X0Y0_紋柄_紋左_紋3;

		public Par X0Y0_紋柄_紋左_紋4;

		public Par X0Y0_紋柄_紋右_紋1;

		public Par X0Y0_紋柄_紋右_紋2;

		public Par X0Y0_紋柄_紋右_紋3;

		public Par X0Y0_紋柄_紋右_紋4;

		public Par X0Y0_淫タトゥ_タトゥ左;

		public Par X0Y0_淫タトゥ_タトゥ右;

		public Par X0Y0_悪タトゥ_タトゥ左1;

		public Par X0Y0_悪タトゥ_タトゥ左2;

		public Par X0Y0_悪タトゥ_タトゥ左3;

		public Par X0Y0_悪タトゥ_タトゥ右1;

		public Par X0Y0_悪タトゥ_タトゥ右2;

		public Par X0Y0_悪タトゥ_タトゥ右3;

		public Par X0Y0_植タトゥ_左_上_タトゥ1;

		public Par X0Y0_植タトゥ_左_上_タトゥ2;

		public Par X0Y0_植タトゥ_左_下_タトゥ1;

		public Par X0Y0_植タトゥ_左_下_タトゥ2;

		public Par X0Y0_植タトゥ_右_上_タトゥ1;

		public Par X0Y0_植タトゥ_右_上_タトゥ2;

		public Par X0Y0_植タトゥ_右_下_タトゥ1;

		public Par X0Y0_植タトゥ_右_下_タトゥ2;

		public Par X0Y0_獣性_獣毛左1;

		public Par X0Y0_獣性_獣毛左2;

		public Par X0Y0_獣性_獣毛右1;

		public Par X0Y0_獣性_獣毛右2;

		public Par X0Y0_竜性_左_鱗1;

		public Par X0Y0_竜性_左_鱗2;

		public Par X0Y0_竜性_左_鱗3;

		public Par X0Y0_竜性_右_鱗1;

		public Par X0Y0_竜性_右_鱗2;

		public Par X0Y0_竜性_右_鱗3;

		public Par X0Y0_虫性_甲殻左_甲殻2_甲殻;

		public Par X0Y0_虫性_甲殻左_甲殻2_器官;

		public Par X0Y0_虫性_甲殻左_甲殻1_甲殻;

		public Par X0Y0_虫性_甲殻左_甲殻1_器官;

		public Par X0Y0_虫性_甲殻右_甲殻2_甲殻;

		public Par X0Y0_虫性_甲殻右_甲殻2_器官;

		public Par X0Y0_虫性_甲殻右_甲殻1_甲殻;

		public Par X0Y0_虫性_甲殻右_甲殻1_器官;

		public Par X0Y0_傷X左;

		public Par X0Y0_傷X右;

		public Par X0Y0_ハイライト外左;

		public Par X0Y0_ハイライト外右;

		public Par X0Y0_ハイライト内左;

		public Par X0Y0_ハイライト内右;

		public ColorD 胸郭CD;

		public ColorD 筋肉_筋肉左CD;

		public ColorD 筋肉_筋肉右CD;

		public ColorD 筋肉_筋肉中CD;

		public ColorD 筋肉_筋肉左下CD;

		public ColorD 筋肉_筋肉左中CD;

		public ColorD 筋肉_筋肉左上CD;

		public ColorD 筋肉_筋肉右下CD;

		public ColorD 筋肉_筋肉右中CD;

		public ColorD 筋肉_筋肉右上CD;

		public ColorD 紋柄_紋左_紋1CD;

		public ColorD 紋柄_紋左_紋2CD;

		public ColorD 紋柄_紋左_紋3CD;

		public ColorD 紋柄_紋左_紋4CD;

		public ColorD 紋柄_紋右_紋1CD;

		public ColorD 紋柄_紋右_紋2CD;

		public ColorD 紋柄_紋右_紋3CD;

		public ColorD 紋柄_紋右_紋4CD;

		public ColorD 淫タトゥ_タトゥ左CD;

		public ColorD 淫タトゥ_タトゥ右CD;

		public ColorD 悪タトゥ_タトゥ左1CD;

		public ColorD 悪タトゥ_タトゥ左2CD;

		public ColorD 悪タトゥ_タトゥ左3CD;

		public ColorD 悪タトゥ_タトゥ右1CD;

		public ColorD 悪タトゥ_タトゥ右2CD;

		public ColorD 悪タトゥ_タトゥ右3CD;

		public ColorD 植タトゥ_左_上_タトゥ1CD;

		public ColorD 植タトゥ_左_上_タトゥ2CD;

		public ColorD 植タトゥ_左_下_タトゥ1CD;

		public ColorD 植タトゥ_左_下_タトゥ2CD;

		public ColorD 植タトゥ_右_上_タトゥ1CD;

		public ColorD 植タトゥ_右_上_タトゥ2CD;

		public ColorD 植タトゥ_右_下_タトゥ1CD;

		public ColorD 植タトゥ_右_下_タトゥ2CD;

		public ColorD 獣性_獣毛左1CD;

		public ColorD 獣性_獣毛左2CD;

		public ColorD 獣性_獣毛右1CD;

		public ColorD 獣性_獣毛右2CD;

		public ColorD 竜性_左_鱗1CD;

		public ColorD 竜性_左_鱗2CD;

		public ColorD 竜性_左_鱗3CD;

		public ColorD 竜性_右_鱗1CD;

		public ColorD 竜性_右_鱗2CD;

		public ColorD 竜性_右_鱗3CD;

		public ColorD 虫性_甲殻左_甲殻2_甲殻CD;

		public ColorD 虫性_甲殻左_甲殻2_器官CD;

		public ColorD 虫性_甲殻左_甲殻1_甲殻CD;

		public ColorD 虫性_甲殻左_甲殻1_器官CD;

		public ColorD 虫性_甲殻右_甲殻2_甲殻CD;

		public ColorD 虫性_甲殻右_甲殻2_器官CD;

		public ColorD 虫性_甲殻右_甲殻1_甲殻CD;

		public ColorD 虫性_甲殻右_甲殻1_器官CD;

		public ColorD 傷X左CD;

		public ColorD 傷X右CD;

		public ColorD ハイライト外左CD;

		public ColorD ハイライト外右CD;

		public ColorD ハイライト内左CD;

		public ColorD ハイライト内右CD;

		public ColorP X0Y0_胸郭CP;

		public ColorP X0Y0_筋肉_筋肉左CP;

		public ColorP X0Y0_筋肉_筋肉右CP;

		public ColorP X0Y0_筋肉_筋肉中CP;

		public ColorP X0Y0_筋肉_筋肉左下CP;

		public ColorP X0Y0_筋肉_筋肉左中CP;

		public ColorP X0Y0_筋肉_筋肉左上CP;

		public ColorP X0Y0_筋肉_筋肉右下CP;

		public ColorP X0Y0_筋肉_筋肉右中CP;

		public ColorP X0Y0_筋肉_筋肉右上CP;

		public ColorP X0Y0_紋柄_紋左_紋1CP;

		public ColorP X0Y0_紋柄_紋左_紋2CP;

		public ColorP X0Y0_紋柄_紋左_紋3CP;

		public ColorP X0Y0_紋柄_紋左_紋4CP;

		public ColorP X0Y0_紋柄_紋右_紋1CP;

		public ColorP X0Y0_紋柄_紋右_紋2CP;

		public ColorP X0Y0_紋柄_紋右_紋3CP;

		public ColorP X0Y0_紋柄_紋右_紋4CP;

		public ColorP X0Y0_淫タトゥ_タトゥ左CP;

		public ColorP X0Y0_淫タトゥ_タトゥ右CP;

		public ColorP X0Y0_悪タトゥ_タトゥ左1CP;

		public ColorP X0Y0_悪タトゥ_タトゥ左2CP;

		public ColorP X0Y0_悪タトゥ_タトゥ左3CP;

		public ColorP X0Y0_悪タトゥ_タトゥ右1CP;

		public ColorP X0Y0_悪タトゥ_タトゥ右2CP;

		public ColorP X0Y0_悪タトゥ_タトゥ右3CP;

		public ColorP X0Y0_植タトゥ_左_上_タトゥ1CP;

		public ColorP X0Y0_植タトゥ_左_上_タトゥ2CP;

		public ColorP X0Y0_植タトゥ_左_下_タトゥ1CP;

		public ColorP X0Y0_植タトゥ_左_下_タトゥ2CP;

		public ColorP X0Y0_植タトゥ_右_上_タトゥ1CP;

		public ColorP X0Y0_植タトゥ_右_上_タトゥ2CP;

		public ColorP X0Y0_植タトゥ_右_下_タトゥ1CP;

		public ColorP X0Y0_植タトゥ_右_下_タトゥ2CP;

		public ColorP X0Y0_獣性_獣毛左1CP;

		public ColorP X0Y0_獣性_獣毛左2CP;

		public ColorP X0Y0_獣性_獣毛右1CP;

		public ColorP X0Y0_獣性_獣毛右2CP;

		public ColorP X0Y0_竜性_左_鱗1CP;

		public ColorP X0Y0_竜性_左_鱗2CP;

		public ColorP X0Y0_竜性_左_鱗3CP;

		public ColorP X0Y0_竜性_右_鱗1CP;

		public ColorP X0Y0_竜性_右_鱗2CP;

		public ColorP X0Y0_竜性_右_鱗3CP;

		public ColorP X0Y0_虫性_甲殻左_甲殻2_甲殻CP;

		public ColorP X0Y0_虫性_甲殻左_甲殻2_器官CP;

		public ColorP X0Y0_虫性_甲殻左_甲殻1_甲殻CP;

		public ColorP X0Y0_虫性_甲殻左_甲殻1_器官CP;

		public ColorP X0Y0_虫性_甲殻右_甲殻2_甲殻CP;

		public ColorP X0Y0_虫性_甲殻右_甲殻2_器官CP;

		public ColorP X0Y0_虫性_甲殻右_甲殻1_甲殻CP;

		public ColorP X0Y0_虫性_甲殻右_甲殻1_器官CP;

		public ColorP X0Y0_傷X左CP;

		public ColorP X0Y0_傷X右CP;

		public ColorP X0Y0_ハイライト外左CP;

		public ColorP X0Y0_ハイライト外右CP;

		public ColorP X0Y0_ハイライト内左CP;

		public ColorP X0Y0_ハイライト内右CP;

		public スタンプK キスマ\u30FCク;

		public スタンプW 鞭痕;

		public Ele[] 首_接続;

		public Ele[] 肩左_接続;

		public Ele[] 肩右_接続;

		public Ele[] 胸左_接続;

		public Ele[] 胸右_接続;

		public Ele[] 肌_接続;

		public Ele[] 翼上左_接続;

		public Ele[] 翼上右_接続;

		public Ele[] 翼下左_接続;

		public Ele[] 翼下右_接続;

		public Ele[] 背中_接続;
	}
}
