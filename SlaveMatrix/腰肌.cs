using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 腰肌 : Ele
	{
		public 腰肌(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 腰肌D e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.胴体["腰肌"]);
			Pars pars = this.本体[0][0];
			Pars pars2 = pars["淫タトゥ"].ToPars();
			Pars pars3 = pars2["ハート"].ToPars();
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左1 = pars3["タトゥ左1"].ToPar();
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右1 = pars3["タトゥ右1"].ToPar();
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左2 = pars3["タトゥ左2"].ToPar();
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右2 = pars3["タトゥ右2"].ToPar();
			this.X0Y0_淫タトゥ_タトゥ1左 = pars2["タトゥ1左"].ToPar();
			this.X0Y0_淫タトゥ_タトゥ1右 = pars2["タトゥ1右"].ToPar();
			this.X0Y0_淫タトゥ_タトゥ2左 = pars2["タトゥ2左"].ToPar();
			this.X0Y0_淫タトゥ_タトゥ2右 = pars2["タトゥ2右"].ToPar();
			pars2 = pars["植タトゥ"].ToPars();
			this.X0Y0_植タトゥ_タトゥ左 = pars2["タトゥ左"].ToPar();
			this.X0Y0_植タトゥ_タトゥ右 = pars2["タトゥ右"].ToPar();
			this.X0Y0_陰毛_ハ\u30FCト = pars["陰毛_ハート"].ToPar();
			pars2 = pars["獣性"].ToPars();
			this.X0Y0_獣性_獣毛 = pars2["獣毛"].ToPar();
			this.X0Y0_陰毛 = pars["陰毛"].ToPar();
			pars2 = pars["鱗"].ToPars();
			this.X0Y0_竜性_鱗1 = pars2["鱗1"].ToPar();
			this.X0Y0_竜性_鱗2 = pars2["鱗2"].ToPar();
			this.X0Y0_竜性_鱗3 = pars2["鱗3"].ToPar();
			this.X0Y0_竜性_鱗4 = pars2["鱗4"].ToPar();
			pars2 = pars["虫性"].ToPars();
			pars3 = pars2["腹板2"].ToPars();
			this.X0Y0_虫性_腹板2_腹板 = pars3["腹板"].ToPar();
			this.X0Y0_虫性_腹板2_縦線 = pars3["縦線"].ToPar();
			pars3 = pars2["腹板1"].ToPars();
			this.X0Y0_虫性_腹板1_腹板 = pars3["腹板"].ToPar();
			this.X0Y0_虫性_腹板1_縦線 = pars3["縦線"].ToPar();
			pars = this.本体[0][1];
			pars2 = pars["淫タトゥ"].ToPars();
			pars3 = pars2["ハート"].ToPars();
			this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ左1 = pars3["タトゥ左1"].ToPar();
			this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ右1 = pars3["タトゥ右1"].ToPar();
			this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ左2 = pars3["タトゥ左2"].ToPar();
			this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ右2 = pars3["タトゥ右2"].ToPar();
			this.X0Y1_淫タトゥ_タトゥ1左 = pars2["タトゥ1左"].ToPar();
			this.X0Y1_淫タトゥ_タトゥ1右 = pars2["タトゥ1右"].ToPar();
			this.X0Y1_淫タトゥ_タトゥ2左 = pars2["タトゥ2左"].ToPar();
			this.X0Y1_淫タトゥ_タトゥ2右 = pars2["タトゥ2右"].ToPar();
			pars2 = pars["植タトゥ"].ToPars();
			this.X0Y1_植タトゥ_タトゥ左 = pars2["タトゥ左"].ToPar();
			this.X0Y1_植タトゥ_タトゥ右 = pars2["タトゥ右"].ToPar();
			this.X0Y1_陰毛_ハ\u30FCト = pars["陰毛_ハート"].ToPar();
			pars2 = pars["獣性"].ToPars();
			this.X0Y1_獣性_獣毛 = pars2["獣毛"].ToPar();
			this.X0Y1_陰毛 = pars["陰毛"].ToPar();
			pars2 = pars["鱗"].ToPars();
			this.X0Y1_竜性_鱗1 = pars2["鱗1"].ToPar();
			this.X0Y1_竜性_鱗2 = pars2["鱗2"].ToPar();
			this.X0Y1_竜性_鱗3 = pars2["鱗3"].ToPar();
			this.X0Y1_竜性_鱗4 = pars2["鱗4"].ToPar();
			pars2 = pars["虫性"].ToPars();
			pars3 = pars2["腹板2"].ToPars();
			this.X0Y1_虫性_腹板2_腹板 = pars3["腹板"].ToPar();
			this.X0Y1_虫性_腹板2_縦線 = pars3["縦線"].ToPar();
			pars3 = pars2["腹板1"].ToPars();
			this.X0Y1_虫性_腹板1_腹板 = pars3["腹板"].ToPar();
			this.X0Y1_虫性_腹板1_縦線 = pars3["縦線"].ToPar();
			pars = this.本体[0][2];
			pars2 = pars["淫タトゥ"].ToPars();
			pars3 = pars2["ハート"].ToPars();
			this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ左1 = pars3["タトゥ左1"].ToPar();
			this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ右1 = pars3["タトゥ右1"].ToPar();
			this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ左2 = pars3["タトゥ左2"].ToPar();
			this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ右2 = pars3["タトゥ右2"].ToPar();
			this.X0Y2_淫タトゥ_タトゥ1左 = pars2["タトゥ1左"].ToPar();
			this.X0Y2_淫タトゥ_タトゥ1右 = pars2["タトゥ1右"].ToPar();
			this.X0Y2_淫タトゥ_タトゥ2左 = pars2["タトゥ2左"].ToPar();
			this.X0Y2_淫タトゥ_タトゥ2右 = pars2["タトゥ2右"].ToPar();
			pars2 = pars["植タトゥ"].ToPars();
			this.X0Y2_植タトゥ_タトゥ左 = pars2["タトゥ左"].ToPar();
			this.X0Y2_植タトゥ_タトゥ右 = pars2["タトゥ右"].ToPar();
			this.X0Y2_陰毛_ハ\u30FCト = pars["陰毛_ハート"].ToPar();
			pars2 = pars["獣性"].ToPars();
			this.X0Y2_獣性_獣毛 = pars2["獣毛"].ToPar();
			this.X0Y2_陰毛 = pars["陰毛"].ToPar();
			pars2 = pars["鱗"].ToPars();
			this.X0Y2_竜性_鱗1 = pars2["鱗1"].ToPar();
			this.X0Y2_竜性_鱗2 = pars2["鱗2"].ToPar();
			this.X0Y2_竜性_鱗3 = pars2["鱗3"].ToPar();
			this.X0Y2_竜性_鱗4 = pars2["鱗4"].ToPar();
			pars2 = pars["虫性"].ToPars();
			pars3 = pars2["腹板2"].ToPars();
			this.X0Y2_虫性_腹板2_腹板 = pars3["腹板"].ToPar();
			this.X0Y2_虫性_腹板2_縦線 = pars3["縦線"].ToPar();
			pars3 = pars2["腹板1"].ToPars();
			this.X0Y2_虫性_腹板1_腹板 = pars3["腹板"].ToPar();
			this.X0Y2_虫性_腹板1_縦線 = pars3["縦線"].ToPar();
			pars = this.本体[0][3];
			pars2 = pars["淫タトゥ"].ToPars();
			pars3 = pars2["ハート"].ToPars();
			this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ左1 = pars3["タトゥ左1"].ToPar();
			this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ右1 = pars3["タトゥ右1"].ToPar();
			this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ左2 = pars3["タトゥ左2"].ToPar();
			this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ右2 = pars3["タトゥ右2"].ToPar();
			this.X0Y3_淫タトゥ_タトゥ1左 = pars2["タトゥ1左"].ToPar();
			this.X0Y3_淫タトゥ_タトゥ1右 = pars2["タトゥ1右"].ToPar();
			this.X0Y3_淫タトゥ_タトゥ2左 = pars2["タトゥ2左"].ToPar();
			this.X0Y3_淫タトゥ_タトゥ2右 = pars2["タトゥ2右"].ToPar();
			pars2 = pars["植タトゥ"].ToPars();
			this.X0Y3_植タトゥ_タトゥ左 = pars2["タトゥ左"].ToPar();
			this.X0Y3_植タトゥ_タトゥ右 = pars2["タトゥ右"].ToPar();
			this.X0Y3_陰毛_ハ\u30FCト = pars["陰毛_ハート"].ToPar();
			pars2 = pars["獣性"].ToPars();
			this.X0Y3_獣性_獣毛 = pars2["獣毛"].ToPar();
			this.X0Y3_陰毛 = pars["陰毛"].ToPar();
			pars2 = pars["鱗"].ToPars();
			this.X0Y3_竜性_鱗1 = pars2["鱗1"].ToPar();
			this.X0Y3_竜性_鱗2 = pars2["鱗2"].ToPar();
			this.X0Y3_竜性_鱗3 = pars2["鱗3"].ToPar();
			this.X0Y3_竜性_鱗4 = pars2["鱗4"].ToPar();
			pars2 = pars["虫性"].ToPars();
			pars3 = pars2["腹板2"].ToPars();
			this.X0Y3_虫性_腹板2_腹板 = pars3["腹板"].ToPar();
			this.X0Y3_虫性_腹板2_縦線 = pars3["縦線"].ToPar();
			pars3 = pars2["腹板1"].ToPars();
			this.X0Y3_虫性_腹板1_腹板 = pars3["腹板"].ToPar();
			this.X0Y3_虫性_腹板1_縦線 = pars3["縦線"].ToPar();
			pars = this.本体[0][4];
			pars2 = pars["淫タトゥ"].ToPars();
			pars3 = pars2["ハート"].ToPars();
			this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ左1 = pars3["タトゥ左1"].ToPar();
			this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ右1 = pars3["タトゥ右1"].ToPar();
			this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ左2 = pars3["タトゥ左2"].ToPar();
			this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ右2 = pars3["タトゥ右2"].ToPar();
			this.X0Y4_淫タトゥ_タトゥ1左 = pars2["タトゥ1左"].ToPar();
			this.X0Y4_淫タトゥ_タトゥ1右 = pars2["タトゥ1右"].ToPar();
			this.X0Y4_淫タトゥ_タトゥ2左 = pars2["タトゥ2左"].ToPar();
			this.X0Y4_淫タトゥ_タトゥ2右 = pars2["タトゥ2右"].ToPar();
			pars2 = pars["植タトゥ"].ToPars();
			this.X0Y4_植タトゥ_タトゥ左 = pars2["タトゥ左"].ToPar();
			this.X0Y4_植タトゥ_タトゥ右 = pars2["タトゥ右"].ToPar();
			this.X0Y4_陰毛_ハ\u30FCト = pars["陰毛_ハート"].ToPar();
			pars2 = pars["獣性"].ToPars();
			this.X0Y4_獣性_獣毛 = pars2["獣毛"].ToPar();
			this.X0Y4_陰毛 = pars["陰毛"].ToPar();
			pars2 = pars["鱗"].ToPars();
			this.X0Y4_竜性_鱗1 = pars2["鱗1"].ToPar();
			this.X0Y4_竜性_鱗2 = pars2["鱗2"].ToPar();
			this.X0Y4_竜性_鱗3 = pars2["鱗3"].ToPar();
			this.X0Y4_竜性_鱗4 = pars2["鱗4"].ToPar();
			pars2 = pars["虫性"].ToPars();
			pars3 = pars2["腹板2"].ToPars();
			this.X0Y4_虫性_腹板2_腹板 = pars3["腹板"].ToPar();
			this.X0Y4_虫性_腹板2_縦線 = pars3["縦線"].ToPar();
			pars3 = pars2["腹板1"].ToPars();
			this.X0Y4_虫性_腹板1_腹板 = pars3["腹板"].ToPar();
			this.X0Y4_虫性_腹板1_縦線 = pars3["縦線"].ToPar();
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
			this.淫タトゥ_ハ\u30FCト_タトゥ左1_表示 = e.淫タトゥ_ハ\u30FCト_タトゥ左1_表示;
			this.淫タトゥ_ハ\u30FCト_タトゥ右1_表示 = e.淫タトゥ_ハ\u30FCト_タトゥ右1_表示;
			this.淫タトゥ_ハ\u30FCト_タトゥ左2_表示 = e.淫タトゥ_ハ\u30FCト_タトゥ左2_表示;
			this.淫タトゥ_ハ\u30FCト_タトゥ右2_表示 = e.淫タトゥ_ハ\u30FCト_タトゥ右2_表示;
			this.淫タトゥ_タトゥ1左_表示 = e.淫タトゥ_タトゥ1左_表示;
			this.淫タトゥ_タトゥ1右_表示 = e.淫タトゥ_タトゥ1右_表示;
			this.淫タトゥ_タトゥ2左_表示 = e.淫タトゥ_タトゥ2左_表示;
			this.淫タトゥ_タトゥ2右_表示 = e.淫タトゥ_タトゥ2右_表示;
			this.植タトゥ_タトゥ左_表示 = e.植タトゥ_タトゥ左_表示;
			this.植タトゥ_タトゥ右_表示 = e.植タトゥ_タトゥ右_表示;
			this.陰毛_ハ\u30FCト_表示 = e.陰毛_ハ\u30FCト_表示;
			this.獣性_獣毛_表示 = e.獣性_獣毛_表示;
			this.陰毛_表示 = e.陰毛_表示;
			this.竜性_鱗1_表示 = e.竜性_鱗1_表示;
			this.竜性_鱗2_表示 = e.竜性_鱗2_表示;
			this.竜性_鱗3_表示 = e.竜性_鱗3_表示;
			this.竜性_鱗4_表示 = e.竜性_鱗4_表示;
			this.虫性_腹板2_腹板_表示 = e.虫性_腹板2_腹板_表示;
			this.虫性_腹板2_縦線_表示 = e.虫性_腹板2_縦線_表示;
			this.虫性_腹板1_腹板_表示 = e.虫性_腹板1_腹板_表示;
			this.虫性_腹板1_縦線_表示 = e.虫性_腹板1_縦線_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左1CP = new ColorP(this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左1, this.淫タトゥ_ハ\u30FCト_タトゥ左1CD, DisUnit, true);
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右1CP = new ColorP(this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右1, this.淫タトゥ_ハ\u30FCト_タトゥ右1CD, DisUnit, true);
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左2CP = new ColorP(this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左2, this.淫タトゥ_ハ\u30FCト_タトゥ左2CD, DisUnit, true);
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右2CP = new ColorP(this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右2, this.淫タトゥ_ハ\u30FCト_タトゥ右2CD, DisUnit, true);
			this.X0Y0_淫タトゥ_タトゥ1左CP = new ColorP(this.X0Y0_淫タトゥ_タトゥ1左, this.淫タトゥ_タトゥ1左CD, DisUnit, true);
			this.X0Y0_淫タトゥ_タトゥ1右CP = new ColorP(this.X0Y0_淫タトゥ_タトゥ1右, this.淫タトゥ_タトゥ1右CD, DisUnit, true);
			this.X0Y0_淫タトゥ_タトゥ2左CP = new ColorP(this.X0Y0_淫タトゥ_タトゥ2左, this.淫タトゥ_タトゥ2左CD, DisUnit, true);
			this.X0Y0_淫タトゥ_タトゥ2右CP = new ColorP(this.X0Y0_淫タトゥ_タトゥ2右, this.淫タトゥ_タトゥ2右CD, DisUnit, true);
			this.X0Y0_植タトゥ_タトゥ左CP = new ColorP(this.X0Y0_植タトゥ_タトゥ左, this.植タトゥ_タトゥ左CD, DisUnit, true);
			this.X0Y0_植タトゥ_タトゥ右CP = new ColorP(this.X0Y0_植タトゥ_タトゥ右, this.植タトゥ_タトゥ右CD, DisUnit, true);
			this.X0Y0_陰毛_ハ\u30FCトCP = new ColorP(this.X0Y0_陰毛_ハ\u30FCト, this.陰毛_ハ\u30FCトCD, DisUnit, true);
			this.X0Y0_獣性_獣毛CP = new ColorP(this.X0Y0_獣性_獣毛, this.獣性_獣毛CD, DisUnit, true);
			this.X0Y0_陰毛CP = new ColorP(this.X0Y0_陰毛, this.陰毛CD, DisUnit, true);
			this.X0Y0_竜性_鱗1CP = new ColorP(this.X0Y0_竜性_鱗1, this.竜性_鱗1CD, DisUnit, true);
			this.X0Y0_竜性_鱗2CP = new ColorP(this.X0Y0_竜性_鱗2, this.竜性_鱗2CD, DisUnit, true);
			this.X0Y0_竜性_鱗3CP = new ColorP(this.X0Y0_竜性_鱗3, this.竜性_鱗3CD, DisUnit, true);
			this.X0Y0_竜性_鱗4CP = new ColorP(this.X0Y0_竜性_鱗4, this.竜性_鱗4CD, DisUnit, true);
			this.X0Y0_虫性_腹板2_腹板CP = new ColorP(this.X0Y0_虫性_腹板2_腹板, this.虫性_腹板2_腹板CD, DisUnit, true);
			this.X0Y0_虫性_腹板2_縦線CP = new ColorP(this.X0Y0_虫性_腹板2_縦線, this.虫性_腹板2_縦線CD, DisUnit, true);
			this.X0Y0_虫性_腹板1_腹板CP = new ColorP(this.X0Y0_虫性_腹板1_腹板, this.虫性_腹板1_腹板CD, DisUnit, true);
			this.X0Y0_虫性_腹板1_縦線CP = new ColorP(this.X0Y0_虫性_腹板1_縦線, this.虫性_腹板1_縦線CD, DisUnit, true);
			this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ左1CP = new ColorP(this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ左1, this.淫タトゥ_ハ\u30FCト_タトゥ左1CD, DisUnit, true);
			this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ右1CP = new ColorP(this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ右1, this.淫タトゥ_ハ\u30FCト_タトゥ右1CD, DisUnit, true);
			this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ左2CP = new ColorP(this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ左2, this.淫タトゥ_ハ\u30FCト_タトゥ左2CD, DisUnit, true);
			this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ右2CP = new ColorP(this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ右2, this.淫タトゥ_ハ\u30FCト_タトゥ右2CD, DisUnit, true);
			this.X0Y1_淫タトゥ_タトゥ1左CP = new ColorP(this.X0Y1_淫タトゥ_タトゥ1左, this.淫タトゥ_タトゥ1左CD, DisUnit, true);
			this.X0Y1_淫タトゥ_タトゥ1右CP = new ColorP(this.X0Y1_淫タトゥ_タトゥ1右, this.淫タトゥ_タトゥ1右CD, DisUnit, true);
			this.X0Y1_淫タトゥ_タトゥ2左CP = new ColorP(this.X0Y1_淫タトゥ_タトゥ2左, this.淫タトゥ_タトゥ2左CD, DisUnit, true);
			this.X0Y1_淫タトゥ_タトゥ2右CP = new ColorP(this.X0Y1_淫タトゥ_タトゥ2右, this.淫タトゥ_タトゥ2右CD, DisUnit, true);
			this.X0Y1_植タトゥ_タトゥ左CP = new ColorP(this.X0Y1_植タトゥ_タトゥ左, this.植タトゥ_タトゥ左CD, DisUnit, true);
			this.X0Y1_植タトゥ_タトゥ右CP = new ColorP(this.X0Y1_植タトゥ_タトゥ右, this.植タトゥ_タトゥ右CD, DisUnit, true);
			this.X0Y1_陰毛_ハ\u30FCトCP = new ColorP(this.X0Y1_陰毛_ハ\u30FCト, this.陰毛_ハ\u30FCトCD, DisUnit, true);
			this.X0Y1_獣性_獣毛CP = new ColorP(this.X0Y1_獣性_獣毛, this.獣性_獣毛CD, DisUnit, true);
			this.X0Y1_陰毛CP = new ColorP(this.X0Y1_陰毛, this.陰毛CD, DisUnit, true);
			this.X0Y1_竜性_鱗1CP = new ColorP(this.X0Y1_竜性_鱗1, this.竜性_鱗1CD, DisUnit, true);
			this.X0Y1_竜性_鱗2CP = new ColorP(this.X0Y1_竜性_鱗2, this.竜性_鱗2CD, DisUnit, true);
			this.X0Y1_竜性_鱗3CP = new ColorP(this.X0Y1_竜性_鱗3, this.竜性_鱗3CD, DisUnit, true);
			this.X0Y1_竜性_鱗4CP = new ColorP(this.X0Y1_竜性_鱗4, this.竜性_鱗4CD, DisUnit, true);
			this.X0Y1_虫性_腹板2_腹板CP = new ColorP(this.X0Y1_虫性_腹板2_腹板, this.虫性_腹板2_腹板CD, DisUnit, true);
			this.X0Y1_虫性_腹板2_縦線CP = new ColorP(this.X0Y1_虫性_腹板2_縦線, this.虫性_腹板2_縦線CD, DisUnit, true);
			this.X0Y1_虫性_腹板1_腹板CP = new ColorP(this.X0Y1_虫性_腹板1_腹板, this.虫性_腹板1_腹板CD, DisUnit, true);
			this.X0Y1_虫性_腹板1_縦線CP = new ColorP(this.X0Y1_虫性_腹板1_縦線, this.虫性_腹板1_縦線CD, DisUnit, true);
			this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ左1CP = new ColorP(this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ左1, this.淫タトゥ_ハ\u30FCト_タトゥ左1CD, DisUnit, true);
			this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ右1CP = new ColorP(this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ右1, this.淫タトゥ_ハ\u30FCト_タトゥ右1CD, DisUnit, true);
			this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ左2CP = new ColorP(this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ左2, this.淫タトゥ_ハ\u30FCト_タトゥ左2CD, DisUnit, true);
			this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ右2CP = new ColorP(this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ右2, this.淫タトゥ_ハ\u30FCト_タトゥ右2CD, DisUnit, true);
			this.X0Y2_淫タトゥ_タトゥ1左CP = new ColorP(this.X0Y2_淫タトゥ_タトゥ1左, this.淫タトゥ_タトゥ1左CD, DisUnit, true);
			this.X0Y2_淫タトゥ_タトゥ1右CP = new ColorP(this.X0Y2_淫タトゥ_タトゥ1右, this.淫タトゥ_タトゥ1右CD, DisUnit, true);
			this.X0Y2_淫タトゥ_タトゥ2左CP = new ColorP(this.X0Y2_淫タトゥ_タトゥ2左, this.淫タトゥ_タトゥ2左CD, DisUnit, true);
			this.X0Y2_淫タトゥ_タトゥ2右CP = new ColorP(this.X0Y2_淫タトゥ_タトゥ2右, this.淫タトゥ_タトゥ2右CD, DisUnit, true);
			this.X0Y2_植タトゥ_タトゥ左CP = new ColorP(this.X0Y2_植タトゥ_タトゥ左, this.植タトゥ_タトゥ左CD, DisUnit, true);
			this.X0Y2_植タトゥ_タトゥ右CP = new ColorP(this.X0Y2_植タトゥ_タトゥ右, this.植タトゥ_タトゥ右CD, DisUnit, true);
			this.X0Y2_陰毛_ハ\u30FCトCP = new ColorP(this.X0Y2_陰毛_ハ\u30FCト, this.陰毛_ハ\u30FCトCD, DisUnit, true);
			this.X0Y2_獣性_獣毛CP = new ColorP(this.X0Y2_獣性_獣毛, this.獣性_獣毛CD, DisUnit, true);
			this.X0Y2_陰毛CP = new ColorP(this.X0Y2_陰毛, this.陰毛CD, DisUnit, true);
			this.X0Y2_竜性_鱗1CP = new ColorP(this.X0Y2_竜性_鱗1, this.竜性_鱗1CD, DisUnit, true);
			this.X0Y2_竜性_鱗2CP = new ColorP(this.X0Y2_竜性_鱗2, this.竜性_鱗2CD, DisUnit, true);
			this.X0Y2_竜性_鱗3CP = new ColorP(this.X0Y2_竜性_鱗3, this.竜性_鱗3CD, DisUnit, true);
			this.X0Y2_竜性_鱗4CP = new ColorP(this.X0Y2_竜性_鱗4, this.竜性_鱗4CD, DisUnit, true);
			this.X0Y2_虫性_腹板2_腹板CP = new ColorP(this.X0Y2_虫性_腹板2_腹板, this.虫性_腹板2_腹板CD, DisUnit, true);
			this.X0Y2_虫性_腹板2_縦線CP = new ColorP(this.X0Y2_虫性_腹板2_縦線, this.虫性_腹板2_縦線CD, DisUnit, true);
			this.X0Y2_虫性_腹板1_腹板CP = new ColorP(this.X0Y2_虫性_腹板1_腹板, this.虫性_腹板1_腹板CD, DisUnit, true);
			this.X0Y2_虫性_腹板1_縦線CP = new ColorP(this.X0Y2_虫性_腹板1_縦線, this.虫性_腹板1_縦線CD, DisUnit, true);
			this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ左1CP = new ColorP(this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ左1, this.淫タトゥ_ハ\u30FCト_タトゥ左1CD, DisUnit, true);
			this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ右1CP = new ColorP(this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ右1, this.淫タトゥ_ハ\u30FCト_タトゥ右1CD, DisUnit, true);
			this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ左2CP = new ColorP(this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ左2, this.淫タトゥ_ハ\u30FCト_タトゥ左2CD, DisUnit, true);
			this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ右2CP = new ColorP(this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ右2, this.淫タトゥ_ハ\u30FCト_タトゥ右2CD, DisUnit, true);
			this.X0Y3_淫タトゥ_タトゥ1左CP = new ColorP(this.X0Y3_淫タトゥ_タトゥ1左, this.淫タトゥ_タトゥ1左CD, DisUnit, true);
			this.X0Y3_淫タトゥ_タトゥ1右CP = new ColorP(this.X0Y3_淫タトゥ_タトゥ1右, this.淫タトゥ_タトゥ1右CD, DisUnit, true);
			this.X0Y3_淫タトゥ_タトゥ2左CP = new ColorP(this.X0Y3_淫タトゥ_タトゥ2左, this.淫タトゥ_タトゥ2左CD, DisUnit, true);
			this.X0Y3_淫タトゥ_タトゥ2右CP = new ColorP(this.X0Y3_淫タトゥ_タトゥ2右, this.淫タトゥ_タトゥ2右CD, DisUnit, true);
			this.X0Y3_植タトゥ_タトゥ左CP = new ColorP(this.X0Y3_植タトゥ_タトゥ左, this.植タトゥ_タトゥ左CD, DisUnit, true);
			this.X0Y3_植タトゥ_タトゥ右CP = new ColorP(this.X0Y3_植タトゥ_タトゥ右, this.植タトゥ_タトゥ右CD, DisUnit, true);
			this.X0Y3_陰毛_ハ\u30FCトCP = new ColorP(this.X0Y3_陰毛_ハ\u30FCト, this.陰毛_ハ\u30FCトCD, DisUnit, true);
			this.X0Y3_獣性_獣毛CP = new ColorP(this.X0Y3_獣性_獣毛, this.獣性_獣毛CD, DisUnit, true);
			this.X0Y3_陰毛CP = new ColorP(this.X0Y3_陰毛, this.陰毛CD, DisUnit, true);
			this.X0Y3_竜性_鱗1CP = new ColorP(this.X0Y3_竜性_鱗1, this.竜性_鱗1CD, DisUnit, true);
			this.X0Y3_竜性_鱗2CP = new ColorP(this.X0Y3_竜性_鱗2, this.竜性_鱗2CD, DisUnit, true);
			this.X0Y3_竜性_鱗3CP = new ColorP(this.X0Y3_竜性_鱗3, this.竜性_鱗3CD, DisUnit, true);
			this.X0Y3_竜性_鱗4CP = new ColorP(this.X0Y3_竜性_鱗4, this.竜性_鱗4CD, DisUnit, true);
			this.X0Y3_虫性_腹板2_腹板CP = new ColorP(this.X0Y3_虫性_腹板2_腹板, this.虫性_腹板2_腹板CD, DisUnit, true);
			this.X0Y3_虫性_腹板2_縦線CP = new ColorP(this.X0Y3_虫性_腹板2_縦線, this.虫性_腹板2_縦線CD, DisUnit, true);
			this.X0Y3_虫性_腹板1_腹板CP = new ColorP(this.X0Y3_虫性_腹板1_腹板, this.虫性_腹板1_腹板CD, DisUnit, true);
			this.X0Y3_虫性_腹板1_縦線CP = new ColorP(this.X0Y3_虫性_腹板1_縦線, this.虫性_腹板1_縦線CD, DisUnit, true);
			this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ左1CP = new ColorP(this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ左1, this.淫タトゥ_ハ\u30FCト_タトゥ左1CD, DisUnit, true);
			this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ右1CP = new ColorP(this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ右1, this.淫タトゥ_ハ\u30FCト_タトゥ右1CD, DisUnit, true);
			this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ左2CP = new ColorP(this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ左2, this.淫タトゥ_ハ\u30FCト_タトゥ左2CD, DisUnit, true);
			this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ右2CP = new ColorP(this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ右2, this.淫タトゥ_ハ\u30FCト_タトゥ右2CD, DisUnit, true);
			this.X0Y4_淫タトゥ_タトゥ1左CP = new ColorP(this.X0Y4_淫タトゥ_タトゥ1左, this.淫タトゥ_タトゥ1左CD, DisUnit, true);
			this.X0Y4_淫タトゥ_タトゥ1右CP = new ColorP(this.X0Y4_淫タトゥ_タトゥ1右, this.淫タトゥ_タトゥ1右CD, DisUnit, true);
			this.X0Y4_淫タトゥ_タトゥ2左CP = new ColorP(this.X0Y4_淫タトゥ_タトゥ2左, this.淫タトゥ_タトゥ2左CD, DisUnit, true);
			this.X0Y4_淫タトゥ_タトゥ2右CP = new ColorP(this.X0Y4_淫タトゥ_タトゥ2右, this.淫タトゥ_タトゥ2右CD, DisUnit, true);
			this.X0Y4_植タトゥ_タトゥ左CP = new ColorP(this.X0Y4_植タトゥ_タトゥ左, this.植タトゥ_タトゥ左CD, DisUnit, true);
			this.X0Y4_植タトゥ_タトゥ右CP = new ColorP(this.X0Y4_植タトゥ_タトゥ右, this.植タトゥ_タトゥ右CD, DisUnit, true);
			this.X0Y4_陰毛_ハ\u30FCトCP = new ColorP(this.X0Y4_陰毛_ハ\u30FCト, this.陰毛_ハ\u30FCトCD, DisUnit, true);
			this.X0Y4_獣性_獣毛CP = new ColorP(this.X0Y4_獣性_獣毛, this.獣性_獣毛CD, DisUnit, true);
			this.X0Y4_陰毛CP = new ColorP(this.X0Y4_陰毛, this.陰毛CD, DisUnit, true);
			this.X0Y4_竜性_鱗1CP = new ColorP(this.X0Y4_竜性_鱗1, this.竜性_鱗1CD, DisUnit, true);
			this.X0Y4_竜性_鱗2CP = new ColorP(this.X0Y4_竜性_鱗2, this.竜性_鱗2CD, DisUnit, true);
			this.X0Y4_竜性_鱗3CP = new ColorP(this.X0Y4_竜性_鱗3, this.竜性_鱗3CD, DisUnit, true);
			this.X0Y4_竜性_鱗4CP = new ColorP(this.X0Y4_竜性_鱗4, this.竜性_鱗4CD, DisUnit, true);
			this.X0Y4_虫性_腹板2_腹板CP = new ColorP(this.X0Y4_虫性_腹板2_腹板, this.虫性_腹板2_腹板CD, DisUnit, true);
			this.X0Y4_虫性_腹板2_縦線CP = new ColorP(this.X0Y4_虫性_腹板2_縦線, this.虫性_腹板2_縦線CD, DisUnit, true);
			this.X0Y4_虫性_腹板1_腹板CP = new ColorP(this.X0Y4_虫性_腹板1_腹板, this.虫性_腹板1_腹板CD, DisUnit, true);
			this.X0Y4_虫性_腹板1_縦線CP = new ColorP(this.X0Y4_虫性_腹板1_縦線, this.虫性_腹板1_縦線CD, DisUnit, true);
			this.濃度 = e.濃度;
			this.尺度YB = 0.95;
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

		public bool 淫タトゥ_ハ\u30FCト_タトゥ左1_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左1.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左1.Dra = value;
				this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ左1.Dra = value;
				this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ左1.Dra = value;
				this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ左1.Dra = value;
				this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ左1.Dra = value;
				this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左1.Hit = value;
				this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ左1.Hit = value;
				this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ左1.Hit = value;
				this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ左1.Hit = value;
				this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ左1.Hit = value;
			}
		}

		public bool 淫タトゥ_ハ\u30FCト_タトゥ右1_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右1.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右1.Dra = value;
				this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ右1.Dra = value;
				this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ右1.Dra = value;
				this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ右1.Dra = value;
				this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ右1.Dra = value;
				this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右1.Hit = value;
				this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ右1.Hit = value;
				this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ右1.Hit = value;
				this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ右1.Hit = value;
				this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ右1.Hit = value;
			}
		}

		public bool 淫タトゥ_ハ\u30FCト_タトゥ左2_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左2.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左2.Dra = value;
				this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ左2.Dra = value;
				this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ左2.Dra = value;
				this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ左2.Dra = value;
				this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ左2.Dra = value;
				this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左2.Hit = value;
				this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ左2.Hit = value;
				this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ左2.Hit = value;
				this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ左2.Hit = value;
				this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ左2.Hit = value;
			}
		}

		public bool 淫タトゥ_ハ\u30FCト_タトゥ右2_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右2.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右2.Dra = value;
				this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ右2.Dra = value;
				this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ右2.Dra = value;
				this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ右2.Dra = value;
				this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ右2.Dra = value;
				this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右2.Hit = value;
				this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ右2.Hit = value;
				this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ右2.Hit = value;
				this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ右2.Hit = value;
				this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ右2.Hit = value;
			}
		}

		public bool 淫タトゥ_タトゥ1左_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_タトゥ1左.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_タトゥ1左.Dra = value;
				this.X0Y1_淫タトゥ_タトゥ1左.Dra = value;
				this.X0Y2_淫タトゥ_タトゥ1左.Dra = value;
				this.X0Y3_淫タトゥ_タトゥ1左.Dra = value;
				this.X0Y4_淫タトゥ_タトゥ1左.Dra = value;
				this.X0Y0_淫タトゥ_タトゥ1左.Hit = value;
				this.X0Y1_淫タトゥ_タトゥ1左.Hit = value;
				this.X0Y2_淫タトゥ_タトゥ1左.Hit = value;
				this.X0Y3_淫タトゥ_タトゥ1左.Hit = value;
				this.X0Y4_淫タトゥ_タトゥ1左.Hit = value;
			}
		}

		public bool 淫タトゥ_タトゥ1右_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_タトゥ1右.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_タトゥ1右.Dra = value;
				this.X0Y1_淫タトゥ_タトゥ1右.Dra = value;
				this.X0Y2_淫タトゥ_タトゥ1右.Dra = value;
				this.X0Y3_淫タトゥ_タトゥ1右.Dra = value;
				this.X0Y4_淫タトゥ_タトゥ1右.Dra = value;
				this.X0Y0_淫タトゥ_タトゥ1右.Hit = value;
				this.X0Y1_淫タトゥ_タトゥ1右.Hit = value;
				this.X0Y2_淫タトゥ_タトゥ1右.Hit = value;
				this.X0Y3_淫タトゥ_タトゥ1右.Hit = value;
				this.X0Y4_淫タトゥ_タトゥ1右.Hit = value;
			}
		}

		public bool 淫タトゥ_タトゥ2左_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_タトゥ2左.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_タトゥ2左.Dra = value;
				this.X0Y1_淫タトゥ_タトゥ2左.Dra = value;
				this.X0Y2_淫タトゥ_タトゥ2左.Dra = value;
				this.X0Y3_淫タトゥ_タトゥ2左.Dra = value;
				this.X0Y4_淫タトゥ_タトゥ2左.Dra = value;
				this.X0Y0_淫タトゥ_タトゥ2左.Hit = value;
				this.X0Y1_淫タトゥ_タトゥ2左.Hit = value;
				this.X0Y2_淫タトゥ_タトゥ2左.Hit = value;
				this.X0Y3_淫タトゥ_タトゥ2左.Hit = value;
				this.X0Y4_淫タトゥ_タトゥ2左.Hit = value;
			}
		}

		public bool 淫タトゥ_タトゥ2右_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_タトゥ2右.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_タトゥ2右.Dra = value;
				this.X0Y1_淫タトゥ_タトゥ2右.Dra = value;
				this.X0Y2_淫タトゥ_タトゥ2右.Dra = value;
				this.X0Y3_淫タトゥ_タトゥ2右.Dra = value;
				this.X0Y4_淫タトゥ_タトゥ2右.Dra = value;
				this.X0Y0_淫タトゥ_タトゥ2右.Hit = value;
				this.X0Y1_淫タトゥ_タトゥ2右.Hit = value;
				this.X0Y2_淫タトゥ_タトゥ2右.Hit = value;
				this.X0Y3_淫タトゥ_タトゥ2右.Hit = value;
				this.X0Y4_淫タトゥ_タトゥ2右.Hit = value;
			}
		}

		public bool 植タトゥ_タトゥ左_表示
		{
			get
			{
				return this.X0Y0_植タトゥ_タトゥ左.Dra;
			}
			set
			{
				this.X0Y0_植タトゥ_タトゥ左.Dra = value;
				this.X0Y1_植タトゥ_タトゥ左.Dra = value;
				this.X0Y2_植タトゥ_タトゥ左.Dra = value;
				this.X0Y3_植タトゥ_タトゥ左.Dra = value;
				this.X0Y4_植タトゥ_タトゥ左.Dra = value;
				this.X0Y0_植タトゥ_タトゥ左.Hit = value;
				this.X0Y1_植タトゥ_タトゥ左.Hit = value;
				this.X0Y2_植タトゥ_タトゥ左.Hit = value;
				this.X0Y3_植タトゥ_タトゥ左.Hit = value;
				this.X0Y4_植タトゥ_タトゥ左.Hit = value;
			}
		}

		public bool 植タトゥ_タトゥ右_表示
		{
			get
			{
				return this.X0Y0_植タトゥ_タトゥ右.Dra;
			}
			set
			{
				this.X0Y0_植タトゥ_タトゥ右.Dra = value;
				this.X0Y1_植タトゥ_タトゥ右.Dra = value;
				this.X0Y2_植タトゥ_タトゥ右.Dra = value;
				this.X0Y3_植タトゥ_タトゥ右.Dra = value;
				this.X0Y4_植タトゥ_タトゥ右.Dra = value;
				this.X0Y0_植タトゥ_タトゥ右.Hit = value;
				this.X0Y1_植タトゥ_タトゥ右.Hit = value;
				this.X0Y2_植タトゥ_タトゥ右.Hit = value;
				this.X0Y3_植タトゥ_タトゥ右.Hit = value;
				this.X0Y4_植タトゥ_タトゥ右.Hit = value;
			}
		}

		public bool 陰毛_ハ\u30FCト_表示
		{
			get
			{
				return this.X0Y0_陰毛_ハ\u30FCト.Dra;
			}
			set
			{
				this.X0Y0_陰毛_ハ\u30FCト.Dra = value;
				this.X0Y1_陰毛_ハ\u30FCト.Dra = value;
				this.X0Y2_陰毛_ハ\u30FCト.Dra = value;
				this.X0Y3_陰毛_ハ\u30FCト.Dra = value;
				this.X0Y4_陰毛_ハ\u30FCト.Dra = value;
				this.X0Y0_陰毛_ハ\u30FCト.Hit = value;
				this.X0Y1_陰毛_ハ\u30FCト.Hit = value;
				this.X0Y2_陰毛_ハ\u30FCト.Hit = value;
				this.X0Y3_陰毛_ハ\u30FCト.Hit = value;
				this.X0Y4_陰毛_ハ\u30FCト.Hit = value;
			}
		}

		public bool 獣性_獣毛_表示
		{
			get
			{
				return this.X0Y0_獣性_獣毛.Dra;
			}
			set
			{
				this.X0Y0_獣性_獣毛.Dra = value;
				this.X0Y1_獣性_獣毛.Dra = value;
				this.X0Y2_獣性_獣毛.Dra = value;
				this.X0Y3_獣性_獣毛.Dra = value;
				this.X0Y4_獣性_獣毛.Dra = value;
				this.X0Y0_獣性_獣毛.Hit = value;
				this.X0Y1_獣性_獣毛.Hit = value;
				this.X0Y2_獣性_獣毛.Hit = value;
				this.X0Y3_獣性_獣毛.Hit = value;
				this.X0Y4_獣性_獣毛.Hit = value;
			}
		}

		public bool 陰毛_表示
		{
			get
			{
				return this.X0Y0_陰毛.Dra;
			}
			set
			{
				this.X0Y0_陰毛.Dra = value;
				this.X0Y1_陰毛.Dra = value;
				this.X0Y2_陰毛.Dra = value;
				this.X0Y3_陰毛.Dra = value;
				this.X0Y4_陰毛.Dra = value;
				this.X0Y0_陰毛.Hit = value;
				this.X0Y1_陰毛.Hit = value;
				this.X0Y2_陰毛.Hit = value;
				this.X0Y3_陰毛.Hit = value;
				this.X0Y4_陰毛.Hit = value;
			}
		}

		public bool 竜性_鱗1_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗1.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗1.Dra = value;
				this.X0Y1_竜性_鱗1.Dra = value;
				this.X0Y2_竜性_鱗1.Dra = value;
				this.X0Y3_竜性_鱗1.Dra = value;
				this.X0Y4_竜性_鱗1.Dra = value;
				this.X0Y0_竜性_鱗1.Hit = value;
				this.X0Y1_竜性_鱗1.Hit = value;
				this.X0Y2_竜性_鱗1.Hit = value;
				this.X0Y3_竜性_鱗1.Hit = value;
				this.X0Y4_竜性_鱗1.Hit = value;
			}
		}

		public bool 竜性_鱗2_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗2.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗2.Dra = value;
				this.X0Y1_竜性_鱗2.Dra = value;
				this.X0Y2_竜性_鱗2.Dra = value;
				this.X0Y3_竜性_鱗2.Dra = value;
				this.X0Y4_竜性_鱗2.Dra = value;
				this.X0Y0_竜性_鱗2.Hit = value;
				this.X0Y1_竜性_鱗2.Hit = value;
				this.X0Y2_竜性_鱗2.Hit = value;
				this.X0Y3_竜性_鱗2.Hit = value;
				this.X0Y4_竜性_鱗2.Hit = value;
			}
		}

		public bool 竜性_鱗3_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗3.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗3.Dra = value;
				this.X0Y1_竜性_鱗3.Dra = value;
				this.X0Y2_竜性_鱗3.Dra = value;
				this.X0Y3_竜性_鱗3.Dra = value;
				this.X0Y4_竜性_鱗3.Dra = value;
				this.X0Y0_竜性_鱗3.Hit = value;
				this.X0Y1_竜性_鱗3.Hit = value;
				this.X0Y2_竜性_鱗3.Hit = value;
				this.X0Y3_竜性_鱗3.Hit = value;
				this.X0Y4_竜性_鱗3.Hit = value;
			}
		}

		public bool 竜性_鱗4_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗4.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗4.Dra = value;
				this.X0Y1_竜性_鱗4.Dra = value;
				this.X0Y2_竜性_鱗4.Dra = value;
				this.X0Y3_竜性_鱗4.Dra = value;
				this.X0Y4_竜性_鱗4.Dra = value;
				this.X0Y0_竜性_鱗4.Hit = value;
				this.X0Y1_竜性_鱗4.Hit = value;
				this.X0Y2_竜性_鱗4.Hit = value;
				this.X0Y3_竜性_鱗4.Hit = value;
				this.X0Y4_竜性_鱗4.Hit = value;
			}
		}

		public bool 虫性_腹板2_腹板_表示
		{
			get
			{
				return this.X0Y0_虫性_腹板2_腹板.Dra;
			}
			set
			{
				this.X0Y0_虫性_腹板2_腹板.Dra = value;
				this.X0Y1_虫性_腹板2_腹板.Dra = value;
				this.X0Y2_虫性_腹板2_腹板.Dra = value;
				this.X0Y3_虫性_腹板2_腹板.Dra = value;
				this.X0Y4_虫性_腹板2_腹板.Dra = value;
				this.X0Y0_虫性_腹板2_腹板.Hit = value;
				this.X0Y1_虫性_腹板2_腹板.Hit = value;
				this.X0Y2_虫性_腹板2_腹板.Hit = value;
				this.X0Y3_虫性_腹板2_腹板.Hit = value;
				this.X0Y4_虫性_腹板2_腹板.Hit = value;
			}
		}

		public bool 虫性_腹板2_縦線_表示
		{
			get
			{
				return this.X0Y0_虫性_腹板2_縦線.Dra;
			}
			set
			{
				this.X0Y0_虫性_腹板2_縦線.Dra = value;
				this.X0Y1_虫性_腹板2_縦線.Dra = value;
				this.X0Y2_虫性_腹板2_縦線.Dra = value;
				this.X0Y3_虫性_腹板2_縦線.Dra = value;
				this.X0Y4_虫性_腹板2_縦線.Dra = value;
				this.X0Y0_虫性_腹板2_縦線.Hit = value;
				this.X0Y1_虫性_腹板2_縦線.Hit = value;
				this.X0Y2_虫性_腹板2_縦線.Hit = value;
				this.X0Y3_虫性_腹板2_縦線.Hit = value;
				this.X0Y4_虫性_腹板2_縦線.Hit = value;
			}
		}

		public bool 虫性_腹板1_腹板_表示
		{
			get
			{
				return this.X0Y0_虫性_腹板1_腹板.Dra;
			}
			set
			{
				this.X0Y0_虫性_腹板1_腹板.Dra = value;
				this.X0Y1_虫性_腹板1_腹板.Dra = value;
				this.X0Y2_虫性_腹板1_腹板.Dra = value;
				this.X0Y3_虫性_腹板1_腹板.Dra = value;
				this.X0Y4_虫性_腹板1_腹板.Dra = value;
				this.X0Y0_虫性_腹板1_腹板.Hit = value;
				this.X0Y1_虫性_腹板1_腹板.Hit = value;
				this.X0Y2_虫性_腹板1_腹板.Hit = value;
				this.X0Y3_虫性_腹板1_腹板.Hit = value;
				this.X0Y4_虫性_腹板1_腹板.Hit = value;
			}
		}

		public bool 虫性_腹板1_縦線_表示
		{
			get
			{
				return this.X0Y0_虫性_腹板1_縦線.Dra;
			}
			set
			{
				this.X0Y0_虫性_腹板1_縦線.Dra = value;
				this.X0Y1_虫性_腹板1_縦線.Dra = value;
				this.X0Y2_虫性_腹板1_縦線.Dra = value;
				this.X0Y3_虫性_腹板1_縦線.Dra = value;
				this.X0Y4_虫性_腹板1_縦線.Dra = value;
				this.X0Y0_虫性_腹板1_縦線.Hit = value;
				this.X0Y1_虫性_腹板1_縦線.Hit = value;
				this.X0Y2_虫性_腹板1_縦線.Hit = value;
				this.X0Y3_虫性_腹板1_縦線.Hit = value;
				this.X0Y4_虫性_腹板1_縦線.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.淫タトゥ_ハ\u30FCト_タトゥ左1_表示;
			}
			set
			{
				this.淫タトゥ_ハ\u30FCト_タトゥ左1_表示 = value;
				this.淫タトゥ_ハ\u30FCト_タトゥ右1_表示 = value;
				this.淫タトゥ_ハ\u30FCト_タトゥ左2_表示 = value;
				this.淫タトゥ_ハ\u30FCト_タトゥ右2_表示 = value;
				this.淫タトゥ_タトゥ1左_表示 = value;
				this.淫タトゥ_タトゥ1右_表示 = value;
				this.淫タトゥ_タトゥ2左_表示 = value;
				this.淫タトゥ_タトゥ2右_表示 = value;
				this.植タトゥ_タトゥ左_表示 = value;
				this.植タトゥ_タトゥ右_表示 = value;
				this.陰毛_ハ\u30FCト_表示 = value;
				this.獣性_獣毛_表示 = value;
				this.陰毛_表示 = value;
				this.竜性_鱗1_表示 = value;
				this.竜性_鱗2_表示 = value;
				this.竜性_鱗3_表示 = value;
				this.竜性_鱗4_表示 = value;
				this.虫性_腹板2_腹板_表示 = value;
				this.虫性_腹板2_縦線_表示 = value;
				this.虫性_腹板1_腹板_表示 = value;
				this.虫性_腹板1_縦線_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.淫タトゥ_ハ\u30FCト_タトゥ左1CD.不透明度;
			}
			set
			{
				this.淫タトゥ_ハ\u30FCト_タトゥ左1CD.不透明度 = value;
				this.淫タトゥ_ハ\u30FCト_タトゥ右1CD.不透明度 = value;
				this.淫タトゥ_ハ\u30FCト_タトゥ左2CD.不透明度 = value;
				this.淫タトゥ_ハ\u30FCト_タトゥ右2CD.不透明度 = value;
				this.淫タトゥ_タトゥ1左CD.不透明度 = value;
				this.淫タトゥ_タトゥ1右CD.不透明度 = value;
				this.淫タトゥ_タトゥ2左CD.不透明度 = value;
				this.淫タトゥ_タトゥ2右CD.不透明度 = value;
				this.植タトゥ_タトゥ左CD.不透明度 = value;
				this.植タトゥ_タトゥ右CD.不透明度 = value;
				this.陰毛_ハ\u30FCトCD.不透明度 = value;
				this.獣性_獣毛CD.不透明度 = value;
				this.陰毛CD.不透明度 = value;
				this.竜性_鱗1CD.不透明度 = value;
				this.竜性_鱗2CD.不透明度 = value;
				this.竜性_鱗3CD.不透明度 = value;
				this.竜性_鱗4CD.不透明度 = value;
				this.虫性_腹板2_腹板CD.不透明度 = value;
				this.虫性_腹板2_縦線CD.不透明度 = value;
				this.虫性_腹板1_腹板CD.不透明度 = value;
				this.虫性_腹板1_縦線CD.不透明度 = value;
			}
		}

		public override void 色更新()
		{
			switch (this.本体.IndexY)
			{
			case 0:
				this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左1CP.Update();
				this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右1CP.Update();
				this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左2CP.Update();
				this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右2CP.Update();
				this.X0Y0_淫タトゥ_タトゥ1左CP.Update();
				this.X0Y0_淫タトゥ_タトゥ1右CP.Update();
				this.X0Y0_淫タトゥ_タトゥ2左CP.Update();
				this.X0Y0_淫タトゥ_タトゥ2右CP.Update();
				this.X0Y0_植タトゥ_タトゥ左CP.Update();
				this.X0Y0_植タトゥ_タトゥ右CP.Update();
				this.X0Y0_陰毛_ハ\u30FCトCP.Update();
				this.X0Y0_獣性_獣毛CP.Update();
				this.X0Y0_陰毛CP.Update();
				this.X0Y0_竜性_鱗1CP.Update();
				this.X0Y0_竜性_鱗2CP.Update();
				this.X0Y0_竜性_鱗3CP.Update();
				this.X0Y0_竜性_鱗4CP.Update();
				this.X0Y0_虫性_腹板2_腹板CP.Update();
				this.X0Y0_虫性_腹板2_縦線CP.Update();
				this.X0Y0_虫性_腹板1_腹板CP.Update();
				this.X0Y0_虫性_腹板1_縦線CP.Update();
				return;
			case 1:
				this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ左1CP.Update();
				this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ右1CP.Update();
				this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ左2CP.Update();
				this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ右2CP.Update();
				this.X0Y1_淫タトゥ_タトゥ1左CP.Update();
				this.X0Y1_淫タトゥ_タトゥ1右CP.Update();
				this.X0Y1_淫タトゥ_タトゥ2左CP.Update();
				this.X0Y1_淫タトゥ_タトゥ2右CP.Update();
				this.X0Y1_植タトゥ_タトゥ左CP.Update();
				this.X0Y1_植タトゥ_タトゥ右CP.Update();
				this.X0Y1_陰毛_ハ\u30FCトCP.Update();
				this.X0Y1_獣性_獣毛CP.Update();
				this.X0Y1_陰毛CP.Update();
				this.X0Y1_竜性_鱗1CP.Update();
				this.X0Y1_竜性_鱗2CP.Update();
				this.X0Y1_竜性_鱗3CP.Update();
				this.X0Y1_竜性_鱗4CP.Update();
				this.X0Y1_虫性_腹板2_腹板CP.Update();
				this.X0Y1_虫性_腹板2_縦線CP.Update();
				this.X0Y1_虫性_腹板1_腹板CP.Update();
				this.X0Y1_虫性_腹板1_縦線CP.Update();
				return;
			case 2:
				this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ左1CP.Update();
				this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ右1CP.Update();
				this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ左2CP.Update();
				this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ右2CP.Update();
				this.X0Y2_淫タトゥ_タトゥ1左CP.Update();
				this.X0Y2_淫タトゥ_タトゥ1右CP.Update();
				this.X0Y2_淫タトゥ_タトゥ2左CP.Update();
				this.X0Y2_淫タトゥ_タトゥ2右CP.Update();
				this.X0Y2_植タトゥ_タトゥ左CP.Update();
				this.X0Y2_植タトゥ_タトゥ右CP.Update();
				this.X0Y2_陰毛_ハ\u30FCトCP.Update();
				this.X0Y2_獣性_獣毛CP.Update();
				this.X0Y2_陰毛CP.Update();
				this.X0Y2_竜性_鱗1CP.Update();
				this.X0Y2_竜性_鱗2CP.Update();
				this.X0Y2_竜性_鱗3CP.Update();
				this.X0Y2_竜性_鱗4CP.Update();
				this.X0Y2_虫性_腹板2_腹板CP.Update();
				this.X0Y2_虫性_腹板2_縦線CP.Update();
				this.X0Y2_虫性_腹板1_腹板CP.Update();
				this.X0Y2_虫性_腹板1_縦線CP.Update();
				return;
			case 3:
				this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ左1CP.Update();
				this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ右1CP.Update();
				this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ左2CP.Update();
				this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ右2CP.Update();
				this.X0Y3_淫タトゥ_タトゥ1左CP.Update();
				this.X0Y3_淫タトゥ_タトゥ1右CP.Update();
				this.X0Y3_淫タトゥ_タトゥ2左CP.Update();
				this.X0Y3_淫タトゥ_タトゥ2右CP.Update();
				this.X0Y3_植タトゥ_タトゥ左CP.Update();
				this.X0Y3_植タトゥ_タトゥ右CP.Update();
				this.X0Y3_陰毛_ハ\u30FCトCP.Update();
				this.X0Y3_獣性_獣毛CP.Update();
				this.X0Y3_陰毛CP.Update();
				this.X0Y3_竜性_鱗1CP.Update();
				this.X0Y3_竜性_鱗2CP.Update();
				this.X0Y3_竜性_鱗3CP.Update();
				this.X0Y3_竜性_鱗4CP.Update();
				this.X0Y3_虫性_腹板2_腹板CP.Update();
				this.X0Y3_虫性_腹板2_縦線CP.Update();
				this.X0Y3_虫性_腹板1_腹板CP.Update();
				this.X0Y3_虫性_腹板1_縦線CP.Update();
				return;
			default:
				this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ左1CP.Update();
				this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ右1CP.Update();
				this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ左2CP.Update();
				this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ右2CP.Update();
				this.X0Y4_淫タトゥ_タトゥ1左CP.Update();
				this.X0Y4_淫タトゥ_タトゥ1右CP.Update();
				this.X0Y4_淫タトゥ_タトゥ2左CP.Update();
				this.X0Y4_淫タトゥ_タトゥ2右CP.Update();
				this.X0Y4_植タトゥ_タトゥ左CP.Update();
				this.X0Y4_植タトゥ_タトゥ右CP.Update();
				this.X0Y4_陰毛_ハ\u30FCトCP.Update();
				this.X0Y4_獣性_獣毛CP.Update();
				this.X0Y4_陰毛CP.Update();
				this.X0Y4_竜性_鱗1CP.Update();
				this.X0Y4_竜性_鱗2CP.Update();
				this.X0Y4_竜性_鱗3CP.Update();
				this.X0Y4_竜性_鱗4CP.Update();
				this.X0Y4_虫性_腹板2_腹板CP.Update();
				this.X0Y4_虫性_腹板2_縦線CP.Update();
				this.X0Y4_虫性_腹板1_腹板CP.Update();
				this.X0Y4_虫性_腹板1_縦線CP.Update();
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
			this.淫タトゥ_ハ\u30FCト_タトゥ左1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ右1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ左2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ右2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ1左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ1右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ2左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ2右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.植タトゥ_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.植タトゥ_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.陰毛_ハ\u30FCトCD = new ColorD(ref Col.Empty, ref 体配色.毛0O);
			this.獣性_獣毛CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.陰毛CD = new ColorD(ref Col.Empty, ref 体配色.毛0O);
			this.竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.虫性_腹板2_腹板CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.虫性_腹板2_縦線CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.虫性_腹板1_腹板CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.虫性_腹板1_縦線CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
		}

		private void 配色T0(体配色 体配色)
		{
			this.淫タトゥ_ハ\u30FCト_タトゥ左1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ右1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ左2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ右2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ1左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ1右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ2左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ2右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.植タトゥ_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.植タトゥ_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.陰毛_ハ\u30FCトCD = new ColorD(ref Col.Empty, ref 体配色.毛0O);
			this.獣性_獣毛CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.陰毛CD = new ColorD(ref Col.Empty, ref 体配色.毛0O);
			this.竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.虫性_腹板2_腹板CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.虫性_腹板2_縦線CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.虫性_腹板1_腹板CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.虫性_腹板1_縦線CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
		}

		private void 配色T1(体配色 体配色)
		{
			this.淫タトゥ_ハ\u30FCト_タトゥ左1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ右1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ左2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ右2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ1左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ1右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ2左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ2右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.植タトゥ_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.植タトゥ_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.陰毛_ハ\u30FCトCD = new ColorD(ref Col.Empty, ref 体配色.毛0O);
			this.獣性_獣毛CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.陰毛CD = new ColorD(ref Col.Empty, ref 体配色.毛0O);
			this.竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.虫性_腹板2_腹板CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.虫性_腹板2_縦線CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.虫性_腹板1_腹板CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.虫性_腹板1_縦線CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
		}

		public Par X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左1;

		public Par X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右1;

		public Par X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左2;

		public Par X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右2;

		public Par X0Y0_淫タトゥ_タトゥ1左;

		public Par X0Y0_淫タトゥ_タトゥ1右;

		public Par X0Y0_淫タトゥ_タトゥ2左;

		public Par X0Y0_淫タトゥ_タトゥ2右;

		public Par X0Y0_植タトゥ_タトゥ左;

		public Par X0Y0_植タトゥ_タトゥ右;

		public Par X0Y0_陰毛_ハ\u30FCト;

		public Par X0Y0_獣性_獣毛;

		public Par X0Y0_陰毛;

		public Par X0Y0_竜性_鱗1;

		public Par X0Y0_竜性_鱗2;

		public Par X0Y0_竜性_鱗3;

		public Par X0Y0_竜性_鱗4;

		public Par X0Y0_虫性_腹板2_腹板;

		public Par X0Y0_虫性_腹板2_縦線;

		public Par X0Y0_虫性_腹板1_腹板;

		public Par X0Y0_虫性_腹板1_縦線;

		public Par X0Y1_淫タトゥ_ハ\u30FCト_タトゥ左1;

		public Par X0Y1_淫タトゥ_ハ\u30FCト_タトゥ右1;

		public Par X0Y1_淫タトゥ_ハ\u30FCト_タトゥ左2;

		public Par X0Y1_淫タトゥ_ハ\u30FCト_タトゥ右2;

		public Par X0Y1_淫タトゥ_タトゥ1左;

		public Par X0Y1_淫タトゥ_タトゥ1右;

		public Par X0Y1_淫タトゥ_タトゥ2左;

		public Par X0Y1_淫タトゥ_タトゥ2右;

		public Par X0Y1_植タトゥ_タトゥ左;

		public Par X0Y1_植タトゥ_タトゥ右;

		public Par X0Y1_陰毛_ハ\u30FCト;

		public Par X0Y1_獣性_獣毛;

		public Par X0Y1_陰毛;

		public Par X0Y1_竜性_鱗1;

		public Par X0Y1_竜性_鱗2;

		public Par X0Y1_竜性_鱗3;

		public Par X0Y1_竜性_鱗4;

		public Par X0Y1_虫性_腹板2_腹板;

		public Par X0Y1_虫性_腹板2_縦線;

		public Par X0Y1_虫性_腹板1_腹板;

		public Par X0Y1_虫性_腹板1_縦線;

		public Par X0Y2_淫タトゥ_ハ\u30FCト_タトゥ左1;

		public Par X0Y2_淫タトゥ_ハ\u30FCト_タトゥ右1;

		public Par X0Y2_淫タトゥ_ハ\u30FCト_タトゥ左2;

		public Par X0Y2_淫タトゥ_ハ\u30FCト_タトゥ右2;

		public Par X0Y2_淫タトゥ_タトゥ1左;

		public Par X0Y2_淫タトゥ_タトゥ1右;

		public Par X0Y2_淫タトゥ_タトゥ2左;

		public Par X0Y2_淫タトゥ_タトゥ2右;

		public Par X0Y2_植タトゥ_タトゥ左;

		public Par X0Y2_植タトゥ_タトゥ右;

		public Par X0Y2_陰毛_ハ\u30FCト;

		public Par X0Y2_獣性_獣毛;

		public Par X0Y2_陰毛;

		public Par X0Y2_竜性_鱗1;

		public Par X0Y2_竜性_鱗2;

		public Par X0Y2_竜性_鱗3;

		public Par X0Y2_竜性_鱗4;

		public Par X0Y2_虫性_腹板2_腹板;

		public Par X0Y2_虫性_腹板2_縦線;

		public Par X0Y2_虫性_腹板1_腹板;

		public Par X0Y2_虫性_腹板1_縦線;

		public Par X0Y3_淫タトゥ_ハ\u30FCト_タトゥ左1;

		public Par X0Y3_淫タトゥ_ハ\u30FCト_タトゥ右1;

		public Par X0Y3_淫タトゥ_ハ\u30FCト_タトゥ左2;

		public Par X0Y3_淫タトゥ_ハ\u30FCト_タトゥ右2;

		public Par X0Y3_淫タトゥ_タトゥ1左;

		public Par X0Y3_淫タトゥ_タトゥ1右;

		public Par X0Y3_淫タトゥ_タトゥ2左;

		public Par X0Y3_淫タトゥ_タトゥ2右;

		public Par X0Y3_植タトゥ_タトゥ左;

		public Par X0Y3_植タトゥ_タトゥ右;

		public Par X0Y3_陰毛_ハ\u30FCト;

		public Par X0Y3_獣性_獣毛;

		public Par X0Y3_陰毛;

		public Par X0Y3_竜性_鱗1;

		public Par X0Y3_竜性_鱗2;

		public Par X0Y3_竜性_鱗3;

		public Par X0Y3_竜性_鱗4;

		public Par X0Y3_虫性_腹板2_腹板;

		public Par X0Y3_虫性_腹板2_縦線;

		public Par X0Y3_虫性_腹板1_腹板;

		public Par X0Y3_虫性_腹板1_縦線;

		public Par X0Y4_淫タトゥ_ハ\u30FCト_タトゥ左1;

		public Par X0Y4_淫タトゥ_ハ\u30FCト_タトゥ右1;

		public Par X0Y4_淫タトゥ_ハ\u30FCト_タトゥ左2;

		public Par X0Y4_淫タトゥ_ハ\u30FCト_タトゥ右2;

		public Par X0Y4_淫タトゥ_タトゥ1左;

		public Par X0Y4_淫タトゥ_タトゥ1右;

		public Par X0Y4_淫タトゥ_タトゥ2左;

		public Par X0Y4_淫タトゥ_タトゥ2右;

		public Par X0Y4_植タトゥ_タトゥ左;

		public Par X0Y4_植タトゥ_タトゥ右;

		public Par X0Y4_陰毛_ハ\u30FCト;

		public Par X0Y4_獣性_獣毛;

		public Par X0Y4_陰毛;

		public Par X0Y4_竜性_鱗1;

		public Par X0Y4_竜性_鱗2;

		public Par X0Y4_竜性_鱗3;

		public Par X0Y4_竜性_鱗4;

		public Par X0Y4_虫性_腹板2_腹板;

		public Par X0Y4_虫性_腹板2_縦線;

		public Par X0Y4_虫性_腹板1_腹板;

		public Par X0Y4_虫性_腹板1_縦線;

		public ColorD 淫タトゥ_ハ\u30FCト_タトゥ左1CD;

		public ColorD 淫タトゥ_ハ\u30FCト_タトゥ右1CD;

		public ColorD 淫タトゥ_ハ\u30FCト_タトゥ左2CD;

		public ColorD 淫タトゥ_ハ\u30FCト_タトゥ右2CD;

		public ColorD 淫タトゥ_タトゥ1左CD;

		public ColorD 淫タトゥ_タトゥ1右CD;

		public ColorD 淫タトゥ_タトゥ2左CD;

		public ColorD 淫タトゥ_タトゥ2右CD;

		public ColorD 植タトゥ_タトゥ左CD;

		public ColorD 植タトゥ_タトゥ右CD;

		public ColorD 陰毛_ハ\u30FCトCD;

		public ColorD 獣性_獣毛CD;

		public ColorD 陰毛CD;

		public ColorD 竜性_鱗1CD;

		public ColorD 竜性_鱗2CD;

		public ColorD 竜性_鱗3CD;

		public ColorD 竜性_鱗4CD;

		public ColorD 虫性_腹板2_腹板CD;

		public ColorD 虫性_腹板2_縦線CD;

		public ColorD 虫性_腹板1_腹板CD;

		public ColorD 虫性_腹板1_縦線CD;

		public ColorP X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左1CP;

		public ColorP X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右1CP;

		public ColorP X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左2CP;

		public ColorP X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右2CP;

		public ColorP X0Y0_淫タトゥ_タトゥ1左CP;

		public ColorP X0Y0_淫タトゥ_タトゥ1右CP;

		public ColorP X0Y0_淫タトゥ_タトゥ2左CP;

		public ColorP X0Y0_淫タトゥ_タトゥ2右CP;

		public ColorP X0Y0_植タトゥ_タトゥ左CP;

		public ColorP X0Y0_植タトゥ_タトゥ右CP;

		public ColorP X0Y0_陰毛_ハ\u30FCトCP;

		public ColorP X0Y0_獣性_獣毛CP;

		public ColorP X0Y0_陰毛CP;

		public ColorP X0Y0_竜性_鱗1CP;

		public ColorP X0Y0_竜性_鱗2CP;

		public ColorP X0Y0_竜性_鱗3CP;

		public ColorP X0Y0_竜性_鱗4CP;

		public ColorP X0Y0_虫性_腹板2_腹板CP;

		public ColorP X0Y0_虫性_腹板2_縦線CP;

		public ColorP X0Y0_虫性_腹板1_腹板CP;

		public ColorP X0Y0_虫性_腹板1_縦線CP;

		public ColorP X0Y1_淫タトゥ_ハ\u30FCト_タトゥ左1CP;

		public ColorP X0Y1_淫タトゥ_ハ\u30FCト_タトゥ右1CP;

		public ColorP X0Y1_淫タトゥ_ハ\u30FCト_タトゥ左2CP;

		public ColorP X0Y1_淫タトゥ_ハ\u30FCト_タトゥ右2CP;

		public ColorP X0Y1_淫タトゥ_タトゥ1左CP;

		public ColorP X0Y1_淫タトゥ_タトゥ1右CP;

		public ColorP X0Y1_淫タトゥ_タトゥ2左CP;

		public ColorP X0Y1_淫タトゥ_タトゥ2右CP;

		public ColorP X0Y1_植タトゥ_タトゥ左CP;

		public ColorP X0Y1_植タトゥ_タトゥ右CP;

		public ColorP X0Y1_陰毛_ハ\u30FCトCP;

		public ColorP X0Y1_獣性_獣毛CP;

		public ColorP X0Y1_陰毛CP;

		public ColorP X0Y1_竜性_鱗1CP;

		public ColorP X0Y1_竜性_鱗2CP;

		public ColorP X0Y1_竜性_鱗3CP;

		public ColorP X0Y1_竜性_鱗4CP;

		public ColorP X0Y1_虫性_腹板2_腹板CP;

		public ColorP X0Y1_虫性_腹板2_縦線CP;

		public ColorP X0Y1_虫性_腹板1_腹板CP;

		public ColorP X0Y1_虫性_腹板1_縦線CP;

		public ColorP X0Y2_淫タトゥ_ハ\u30FCト_タトゥ左1CP;

		public ColorP X0Y2_淫タトゥ_ハ\u30FCト_タトゥ右1CP;

		public ColorP X0Y2_淫タトゥ_ハ\u30FCト_タトゥ左2CP;

		public ColorP X0Y2_淫タトゥ_ハ\u30FCト_タトゥ右2CP;

		public ColorP X0Y2_淫タトゥ_タトゥ1左CP;

		public ColorP X0Y2_淫タトゥ_タトゥ1右CP;

		public ColorP X0Y2_淫タトゥ_タトゥ2左CP;

		public ColorP X0Y2_淫タトゥ_タトゥ2右CP;

		public ColorP X0Y2_植タトゥ_タトゥ左CP;

		public ColorP X0Y2_植タトゥ_タトゥ右CP;

		public ColorP X0Y2_陰毛_ハ\u30FCトCP;

		public ColorP X0Y2_獣性_獣毛CP;

		public ColorP X0Y2_陰毛CP;

		public ColorP X0Y2_竜性_鱗1CP;

		public ColorP X0Y2_竜性_鱗2CP;

		public ColorP X0Y2_竜性_鱗3CP;

		public ColorP X0Y2_竜性_鱗4CP;

		public ColorP X0Y2_虫性_腹板2_腹板CP;

		public ColorP X0Y2_虫性_腹板2_縦線CP;

		public ColorP X0Y2_虫性_腹板1_腹板CP;

		public ColorP X0Y2_虫性_腹板1_縦線CP;

		public ColorP X0Y3_淫タトゥ_ハ\u30FCト_タトゥ左1CP;

		public ColorP X0Y3_淫タトゥ_ハ\u30FCト_タトゥ右1CP;

		public ColorP X0Y3_淫タトゥ_ハ\u30FCト_タトゥ左2CP;

		public ColorP X0Y3_淫タトゥ_ハ\u30FCト_タトゥ右2CP;

		public ColorP X0Y3_淫タトゥ_タトゥ1左CP;

		public ColorP X0Y3_淫タトゥ_タトゥ1右CP;

		public ColorP X0Y3_淫タトゥ_タトゥ2左CP;

		public ColorP X0Y3_淫タトゥ_タトゥ2右CP;

		public ColorP X0Y3_植タトゥ_タトゥ左CP;

		public ColorP X0Y3_植タトゥ_タトゥ右CP;

		public ColorP X0Y3_陰毛_ハ\u30FCトCP;

		public ColorP X0Y3_獣性_獣毛CP;

		public ColorP X0Y3_陰毛CP;

		public ColorP X0Y3_竜性_鱗1CP;

		public ColorP X0Y3_竜性_鱗2CP;

		public ColorP X0Y3_竜性_鱗3CP;

		public ColorP X0Y3_竜性_鱗4CP;

		public ColorP X0Y3_虫性_腹板2_腹板CP;

		public ColorP X0Y3_虫性_腹板2_縦線CP;

		public ColorP X0Y3_虫性_腹板1_腹板CP;

		public ColorP X0Y3_虫性_腹板1_縦線CP;

		public ColorP X0Y4_淫タトゥ_ハ\u30FCト_タトゥ左1CP;

		public ColorP X0Y4_淫タトゥ_ハ\u30FCト_タトゥ右1CP;

		public ColorP X0Y4_淫タトゥ_ハ\u30FCト_タトゥ左2CP;

		public ColorP X0Y4_淫タトゥ_ハ\u30FCト_タトゥ右2CP;

		public ColorP X0Y4_淫タトゥ_タトゥ1左CP;

		public ColorP X0Y4_淫タトゥ_タトゥ1右CP;

		public ColorP X0Y4_淫タトゥ_タトゥ2左CP;

		public ColorP X0Y4_淫タトゥ_タトゥ2右CP;

		public ColorP X0Y4_植タトゥ_タトゥ左CP;

		public ColorP X0Y4_植タトゥ_タトゥ右CP;

		public ColorP X0Y4_陰毛_ハ\u30FCトCP;

		public ColorP X0Y4_獣性_獣毛CP;

		public ColorP X0Y4_陰毛CP;

		public ColorP X0Y4_竜性_鱗1CP;

		public ColorP X0Y4_竜性_鱗2CP;

		public ColorP X0Y4_竜性_鱗3CP;

		public ColorP X0Y4_竜性_鱗4CP;

		public ColorP X0Y4_虫性_腹板2_腹板CP;

		public ColorP X0Y4_虫性_腹板2_縦線CP;

		public ColorP X0Y4_虫性_腹板1_腹板CP;

		public ColorP X0Y4_虫性_腹板1_縦線CP;
	}
}
