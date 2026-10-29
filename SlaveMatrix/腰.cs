using System;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 腰 : Ele
	{
		public 腰(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 腰D e)
		{
			腰.<>c__DisplayClass473_0 CS$<>8__locals1 = new 腰.<>c__DisplayClass473_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.胴体["腰"]);
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
			this.X0Y0_ハイライト = pars["ハイライト"].ToPar();
			this.X0Y0_臍 = pars["臍"].ToPar();
			pars2 = pars["淫タトゥ"].ToPars();
			Pars pars3 = pars2["渦"].ToPars();
			this.X0Y0_悪タトゥ_渦_タトゥ1左 = pars3["タトゥ1左"].ToPar();
			this.X0Y0_悪タトゥ_渦_タトゥ1右 = pars3["タトゥ1右"].ToPar();
			this.X0Y0_悪タトゥ_渦_タトゥ2左 = pars3["タトゥ2左"].ToPar();
			this.X0Y0_悪タトゥ_渦_タトゥ2右 = pars3["タトゥ2右"].ToPar();
			pars3 = pars2["ハート"].ToPars();
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ1左 = pars3["タトゥ1左"].ToPar();
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ1右 = pars3["タトゥ1右"].ToPar();
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ2左 = pars3["タトゥ2左"].ToPar();
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ2右 = pars3["タトゥ2右"].ToPar();
			this.X0Y0_傷X左 = pars["傷X左"].ToPar();
			this.X0Y0_傷X右 = pars["傷X右"].ToPar();
			this.X0Y0_傷I左 = pars["傷I左"].ToPar();
			this.X0Y0_傷I右 = pars["傷I右"].ToPar();
			pars2 = pars["紋柄"].ToPars();
			pars3 = pars2["紋左"].ToPars();
			this.X0Y0_紋柄_紋左_紋1 = pars3["紋1"].ToPar();
			this.X0Y0_紋柄_紋左_紋2 = pars3["紋2"].ToPar();
			this.X0Y0_紋柄_紋左_紋3 = pars3["紋3"].ToPar();
			pars3 = pars2["紋右"].ToPars();
			this.X0Y0_紋柄_紋右_紋1 = pars3["紋1"].ToPar();
			this.X0Y0_紋柄_紋右_紋2 = pars3["紋2"].ToPar();
			this.X0Y0_紋柄_紋右_紋3 = pars3["紋3"].ToPar();
			pars2 = pars["獣性"].ToPars();
			this.X0Y0_獣性_獣毛左 = pars2["獣毛左"].ToPar();
			this.X0Y0_獣性_獣毛右 = pars2["獣毛右"].ToPar();
			pars2 = pars["虫性"].ToPars();
			this.X0Y0_虫性_甲殻2 = pars2["甲殻2"].ToPar();
			this.X0Y0_虫性_甲殻1 = pars2["甲殻1"].ToPar();
			pars2 = pars["鱗"].ToPars();
			pars3 = pars2["左"].ToPars();
			this.X0Y0_竜性_左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_竜性_左_鱗2 = pars3["鱗2"].ToPar();
			pars3 = pars2["右"].ToPars();
			this.X0Y0_竜性_右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_竜性_右_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_ハイライト上左 = pars["ハイライト上左"].ToPar();
			this.X0Y0_ハイライト上右 = pars["ハイライト上右"].ToPar();
			this.X0Y0_ハイライト下左 = pars["ハイライト下左"].ToPar();
			this.X0Y0_ハイライト下右 = pars["ハイライト下右"].ToPar();
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
			this.X0Y1_ハイライト = pars["ハイライト"].ToPar();
			this.X0Y1_臍 = pars["臍"].ToPar();
			pars2 = pars["淫タトゥ"].ToPars();
			pars3 = pars2["渦"].ToPars();
			this.X0Y1_悪タトゥ_渦_タトゥ1左 = pars3["タトゥ1左"].ToPar();
			this.X0Y1_悪タトゥ_渦_タトゥ1右 = pars3["タトゥ1右"].ToPar();
			this.X0Y1_悪タトゥ_渦_タトゥ2左 = pars3["タトゥ2左"].ToPar();
			this.X0Y1_悪タトゥ_渦_タトゥ2右 = pars3["タトゥ2右"].ToPar();
			pars3 = pars2["ハート"].ToPars();
			this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ1左 = pars3["タトゥ1左"].ToPar();
			this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ1右 = pars3["タトゥ1右"].ToPar();
			this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ2左 = pars3["タトゥ2左"].ToPar();
			this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ2右 = pars3["タトゥ2右"].ToPar();
			this.X0Y1_傷X左 = pars["傷X左"].ToPar();
			this.X0Y1_傷X右 = pars["傷X右"].ToPar();
			this.X0Y1_傷I左 = pars["傷I左"].ToPar();
			this.X0Y1_傷I右 = pars["傷I右"].ToPar();
			pars2 = pars["紋柄"].ToPars();
			pars3 = pars2["紋左"].ToPars();
			this.X0Y1_紋柄_紋左_紋1 = pars3["紋1"].ToPar();
			this.X0Y1_紋柄_紋左_紋2 = pars3["紋2"].ToPar();
			this.X0Y1_紋柄_紋左_紋3 = pars3["紋3"].ToPar();
			pars3 = pars2["紋右"].ToPars();
			this.X0Y1_紋柄_紋右_紋1 = pars3["紋1"].ToPar();
			this.X0Y1_紋柄_紋右_紋2 = pars3["紋2"].ToPar();
			this.X0Y1_紋柄_紋右_紋3 = pars3["紋3"].ToPar();
			pars2 = pars["獣性"].ToPars();
			this.X0Y1_獣性_獣毛左 = pars2["獣毛左"].ToPar();
			this.X0Y1_獣性_獣毛右 = pars2["獣毛右"].ToPar();
			pars2 = pars["虫性"].ToPars();
			this.X0Y1_虫性_甲殻2 = pars2["甲殻2"].ToPar();
			this.X0Y1_虫性_甲殻1 = pars2["甲殻1"].ToPar();
			pars2 = pars["鱗"].ToPars();
			pars3 = pars2["左"].ToPars();
			this.X0Y1_竜性_左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y1_竜性_左_鱗2 = pars3["鱗2"].ToPar();
			pars3 = pars2["右"].ToPars();
			this.X0Y1_竜性_右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y1_竜性_右_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y1_ハイライト上左 = pars["ハイライト上左"].ToPar();
			this.X0Y1_ハイライト上右 = pars["ハイライト上右"].ToPar();
			this.X0Y1_ハイライト下左 = pars["ハイライト下左"].ToPar();
			this.X0Y1_ハイライト下右 = pars["ハイライト下右"].ToPar();
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
			this.X0Y2_ハイライト = pars["ハイライト"].ToPar();
			this.X0Y2_臍 = pars["臍"].ToPar();
			pars2 = pars["淫タトゥ"].ToPars();
			pars3 = pars2["渦"].ToPars();
			this.X0Y2_悪タトゥ_渦_タトゥ1左 = pars3["タトゥ1左"].ToPar();
			this.X0Y2_悪タトゥ_渦_タトゥ1右 = pars3["タトゥ1右"].ToPar();
			this.X0Y2_悪タトゥ_渦_タトゥ2左 = pars3["タトゥ2左"].ToPar();
			this.X0Y2_悪タトゥ_渦_タトゥ2右 = pars3["タトゥ2右"].ToPar();
			pars3 = pars2["ハート"].ToPars();
			this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ1左 = pars3["タトゥ1左"].ToPar();
			this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ1右 = pars3["タトゥ1右"].ToPar();
			this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ2左 = pars3["タトゥ2左"].ToPar();
			this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ2右 = pars3["タトゥ2右"].ToPar();
			this.X0Y2_傷X左 = pars["傷X左"].ToPar();
			this.X0Y2_傷X右 = pars["傷X右"].ToPar();
			this.X0Y2_傷I左 = pars["傷I左"].ToPar();
			this.X0Y2_傷I右 = pars["傷I右"].ToPar();
			pars2 = pars["紋柄"].ToPars();
			pars3 = pars2["紋左"].ToPars();
			this.X0Y2_紋柄_紋左_紋1 = pars3["紋1"].ToPar();
			this.X0Y2_紋柄_紋左_紋2 = pars3["紋2"].ToPar();
			this.X0Y2_紋柄_紋左_紋3 = pars3["紋3"].ToPar();
			pars3 = pars2["紋右"].ToPars();
			this.X0Y2_紋柄_紋右_紋1 = pars3["紋1"].ToPar();
			this.X0Y2_紋柄_紋右_紋2 = pars3["紋2"].ToPar();
			this.X0Y2_紋柄_紋右_紋3 = pars3["紋3"].ToPar();
			pars2 = pars["獣性"].ToPars();
			this.X0Y2_獣性_獣毛左 = pars2["獣毛左"].ToPar();
			this.X0Y2_獣性_獣毛右 = pars2["獣毛右"].ToPar();
			pars2 = pars["虫性"].ToPars();
			this.X0Y2_虫性_甲殻2 = pars2["甲殻2"].ToPar();
			this.X0Y2_虫性_甲殻1 = pars2["甲殻1"].ToPar();
			pars2 = pars["鱗"].ToPars();
			pars3 = pars2["左"].ToPars();
			this.X0Y2_竜性_左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y2_竜性_左_鱗2 = pars3["鱗2"].ToPar();
			pars3 = pars2["右"].ToPars();
			this.X0Y2_竜性_右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y2_竜性_右_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y2_ハイライト上左 = pars["ハイライト上左"].ToPar();
			this.X0Y2_ハイライト上右 = pars["ハイライト上右"].ToPar();
			this.X0Y2_ハイライト下左 = pars["ハイライト下左"].ToPar();
			this.X0Y2_ハイライト下右 = pars["ハイライト下右"].ToPar();
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
			this.X0Y3_ハイライト = pars["ハイライト"].ToPar();
			this.X0Y3_臍 = pars["臍"].ToPar();
			pars2 = pars["淫タトゥ"].ToPars();
			pars3 = pars2["渦"].ToPars();
			this.X0Y3_悪タトゥ_渦_タトゥ1左 = pars3["タトゥ1左"].ToPar();
			this.X0Y3_悪タトゥ_渦_タトゥ1右 = pars3["タトゥ1右"].ToPar();
			this.X0Y3_悪タトゥ_渦_タトゥ2左 = pars3["タトゥ2左"].ToPar();
			this.X0Y3_悪タトゥ_渦_タトゥ2右 = pars3["タトゥ2右"].ToPar();
			pars3 = pars2["ハート"].ToPars();
			this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ1左 = pars3["タトゥ1左"].ToPar();
			this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ1右 = pars3["タトゥ1右"].ToPar();
			this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ2左 = pars3["タトゥ2左"].ToPar();
			this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ2右 = pars3["タトゥ2右"].ToPar();
			this.X0Y3_傷X左 = pars["傷X左"].ToPar();
			this.X0Y3_傷X右 = pars["傷X右"].ToPar();
			this.X0Y3_傷I左 = pars["傷I左"].ToPar();
			this.X0Y3_傷I右 = pars["傷I右"].ToPar();
			pars2 = pars["紋柄"].ToPars();
			pars3 = pars2["紋左"].ToPars();
			this.X0Y3_紋柄_紋左_紋1 = pars3["紋1"].ToPar();
			this.X0Y3_紋柄_紋左_紋2 = pars3["紋2"].ToPar();
			this.X0Y3_紋柄_紋左_紋3 = pars3["紋3"].ToPar();
			pars3 = pars2["紋右"].ToPars();
			this.X0Y3_紋柄_紋右_紋1 = pars3["紋1"].ToPar();
			this.X0Y3_紋柄_紋右_紋2 = pars3["紋2"].ToPar();
			this.X0Y3_紋柄_紋右_紋3 = pars3["紋3"].ToPar();
			pars2 = pars["獣性"].ToPars();
			this.X0Y3_獣性_獣毛左 = pars2["獣毛左"].ToPar();
			this.X0Y3_獣性_獣毛右 = pars2["獣毛右"].ToPar();
			pars2 = pars["虫性"].ToPars();
			this.X0Y3_虫性_甲殻2 = pars2["甲殻2"].ToPar();
			this.X0Y3_虫性_甲殻1 = pars2["甲殻1"].ToPar();
			pars2 = pars["鱗"].ToPars();
			pars3 = pars2["左"].ToPars();
			this.X0Y3_竜性_左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y3_竜性_左_鱗2 = pars3["鱗2"].ToPar();
			pars3 = pars2["右"].ToPars();
			this.X0Y3_竜性_右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y3_竜性_右_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y3_ハイライト上左 = pars["ハイライト上左"].ToPar();
			this.X0Y3_ハイライト上右 = pars["ハイライト上右"].ToPar();
			this.X0Y3_ハイライト下左 = pars["ハイライト下左"].ToPar();
			this.X0Y3_ハイライト下右 = pars["ハイライト下右"].ToPar();
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
			this.X0Y4_ハイライト = pars["ハイライト"].ToPar();
			this.X0Y4_臍 = pars["臍"].ToPar();
			pars2 = pars["淫タトゥ"].ToPars();
			pars3 = pars2["渦"].ToPars();
			this.X0Y4_悪タトゥ_渦_タトゥ1左 = pars3["タトゥ1左"].ToPar();
			this.X0Y4_悪タトゥ_渦_タトゥ1右 = pars3["タトゥ1右"].ToPar();
			this.X0Y4_悪タトゥ_渦_タトゥ2左 = pars3["タトゥ2左"].ToPar();
			this.X0Y4_悪タトゥ_渦_タトゥ2右 = pars3["タトゥ2右"].ToPar();
			pars3 = pars2["ハート"].ToPars();
			this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ1左 = pars3["タトゥ1左"].ToPar();
			this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ1右 = pars3["タトゥ1右"].ToPar();
			this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ2左 = pars3["タトゥ2左"].ToPar();
			this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ2右 = pars3["タトゥ2右"].ToPar();
			this.X0Y4_傷X左 = pars["傷X左"].ToPar();
			this.X0Y4_傷X右 = pars["傷X右"].ToPar();
			this.X0Y4_傷I左 = pars["傷I左"].ToPar();
			this.X0Y4_傷I右 = pars["傷I右"].ToPar();
			pars2 = pars["紋柄"].ToPars();
			pars3 = pars2["紋左"].ToPars();
			this.X0Y4_紋柄_紋左_紋1 = pars3["紋1"].ToPar();
			this.X0Y4_紋柄_紋左_紋2 = pars3["紋2"].ToPar();
			this.X0Y4_紋柄_紋左_紋3 = pars3["紋3"].ToPar();
			pars3 = pars2["紋右"].ToPars();
			this.X0Y4_紋柄_紋右_紋1 = pars3["紋1"].ToPar();
			this.X0Y4_紋柄_紋右_紋2 = pars3["紋2"].ToPar();
			this.X0Y4_紋柄_紋右_紋3 = pars3["紋3"].ToPar();
			pars2 = pars["獣性"].ToPars();
			this.X0Y4_獣性_獣毛左 = pars2["獣毛左"].ToPar();
			this.X0Y4_獣性_獣毛右 = pars2["獣毛右"].ToPar();
			pars2 = pars["虫性"].ToPars();
			this.X0Y4_虫性_甲殻2 = pars2["甲殻2"].ToPar();
			this.X0Y4_虫性_甲殻1 = pars2["甲殻1"].ToPar();
			pars2 = pars["鱗"].ToPars();
			pars3 = pars2["左"].ToPars();
			this.X0Y4_竜性_左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y4_竜性_左_鱗2 = pars3["鱗2"].ToPar();
			pars3 = pars2["右"].ToPars();
			this.X0Y4_竜性_右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y4_竜性_右_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y4_ハイライト上左 = pars["ハイライト上左"].ToPar();
			this.X0Y4_ハイライト上右 = pars["ハイライト上右"].ToPar();
			this.X0Y4_ハイライト下左 = pars["ハイライト下左"].ToPar();
			this.X0Y4_ハイライト下右 = pars["ハイライト下右"].ToPar();
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
			this.ハイライト_表示 = e.ハイライト_表示;
			this.臍_表示 = e.臍_表示;
			this.悪タトゥ_渦_タトゥ1左_表示 = e.悪タトゥ_渦_タトゥ1左_表示;
			this.悪タトゥ_渦_タトゥ1右_表示 = e.悪タトゥ_渦_タトゥ1右_表示;
			this.悪タトゥ_渦_タトゥ2左_表示 = e.悪タトゥ_渦_タトゥ2左_表示;
			this.悪タトゥ_渦_タトゥ2右_表示 = e.悪タトゥ_渦_タトゥ2右_表示;
			this.淫タトゥ_ハ\u30FCト_タトゥ1左_表示 = e.淫タトゥ_ハ\u30FCト_タトゥ1左_表示;
			this.淫タトゥ_ハ\u30FCト_タトゥ1右_表示 = e.淫タトゥ_ハ\u30FCト_タトゥ1右_表示;
			this.淫タトゥ_ハ\u30FCト_タトゥ2左_表示 = e.淫タトゥ_ハ\u30FCト_タトゥ2左_表示;
			this.淫タトゥ_ハ\u30FCト_タトゥ2右_表示 = e.淫タトゥ_ハ\u30FCト_タトゥ2右_表示;
			this.傷X左_表示 = e.傷X左_表示;
			this.傷X右_表示 = e.傷X右_表示;
			this.傷I左_表示 = e.傷I左_表示;
			this.傷I右_表示 = e.傷I右_表示;
			this.紋柄_紋左_紋1_表示 = e.紋柄_紋左_紋1_表示;
			this.紋柄_紋左_紋2_表示 = e.紋柄_紋左_紋2_表示;
			this.紋柄_紋左_紋3_表示 = e.紋柄_紋左_紋3_表示;
			this.紋柄_紋右_紋1_表示 = e.紋柄_紋右_紋1_表示;
			this.紋柄_紋右_紋2_表示 = e.紋柄_紋右_紋2_表示;
			this.紋柄_紋右_紋3_表示 = e.紋柄_紋右_紋3_表示;
			this.獣性_獣毛左_表示 = e.獣性_獣毛左_表示;
			this.獣性_獣毛右_表示 = e.獣性_獣毛右_表示;
			this.虫性_甲殻2_表示 = e.虫性_甲殻2_表示;
			this.虫性_甲殻1_表示 = e.虫性_甲殻1_表示;
			this.竜性_左_鱗1_表示 = e.竜性_左_鱗1_表示;
			this.竜性_左_鱗2_表示 = e.竜性_左_鱗2_表示;
			this.竜性_右_鱗1_表示 = e.竜性_右_鱗1_表示;
			this.竜性_右_鱗2_表示 = e.竜性_右_鱗2_表示;
			this.ハイライト上左_表示 = e.ハイライト上左_表示;
			this.ハイライト上右_表示 = e.ハイライト上右_表示;
			this.ハイライト下左_表示 = e.ハイライト下左_表示;
			this.ハイライト下右_表示 = e.ハイライト下右_表示;
			this.ハイライト表示 = e.ハイライト表示;
			if (e.スライム)
			{
				this.スライム();
			}
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.胴_接続.Count > 0)
			{
				Ele f;
				this.胴_接続 = e.胴_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.腰_胴_接続;
					f.接続(CS$<>8__locals1.<>4__this.胴_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.腿左_接続.Count > 0)
			{
				Ele f;
				this.腿左_接続 = e.腿左_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.腰_腿左_接続;
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
					f.接続情報 = 接続情報.腰_腿右_接続;
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
					f.接続情報 = 接続情報.腰_膣基_接続;
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
					f.接続情報 = 接続情報.腰_肛門_接続;
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
					f.接続情報 = 接続情報.腰_尾_接続;
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
					f.接続情報 = 接続情報.腰_半身_接続;
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
					f.接続情報 = 接続情報.腰_上着_接続;
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
					f.接続情報 = 接続情報.腰_肌_接続;
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
					f.接続情報 = 接続情報.腰_翼左_接続;
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
					f.接続情報 = 接続情報.腰_翼右_接続;
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
			this.X0Y0_ハイライトCP = new ColorP(this.X0Y0_ハイライト, this.ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_臍CP = new ColorP(this.X0Y0_臍, this.臍CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_悪タトゥ_渦_タトゥ1左CP = new ColorP(this.X0Y0_悪タトゥ_渦_タトゥ1左, this.悪タトゥ_渦_タトゥ1左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_渦_タトゥ1右CP = new ColorP(this.X0Y0_悪タトゥ_渦_タトゥ1右, this.悪タトゥ_渦_タトゥ1右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_渦_タトゥ2左CP = new ColorP(this.X0Y0_悪タトゥ_渦_タトゥ2左, this.悪タトゥ_渦_タトゥ2左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_渦_タトゥ2右CP = new ColorP(this.X0Y0_悪タトゥ_渦_タトゥ2右, this.悪タトゥ_渦_タトゥ2右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ1左CP = new ColorP(this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ1左, this.淫タトゥ_ハ\u30FCト_タトゥ1左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ1右CP = new ColorP(this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ1右, this.淫タトゥ_ハ\u30FCト_タトゥ1右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ2左CP = new ColorP(this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ2左, this.淫タトゥ_ハ\u30FCト_タトゥ2左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ2右CP = new ColorP(this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ2右, this.淫タトゥ_ハ\u30FCト_タトゥ2右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_傷X左CP = new ColorP(this.X0Y0_傷X左, this.傷X左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_傷X右CP = new ColorP(this.X0Y0_傷X右, this.傷X右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_傷I左CP = new ColorP(this.X0Y0_傷I左, this.傷I左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_傷I右CP = new ColorP(this.X0Y0_傷I右, this.傷I右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_紋柄_紋左_紋1CP = new ColorP(this.X0Y0_紋柄_紋左_紋1, this.紋柄_紋左_紋1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_紋柄_紋左_紋2CP = new ColorP(this.X0Y0_紋柄_紋左_紋2, this.紋柄_紋左_紋2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_紋柄_紋左_紋3CP = new ColorP(this.X0Y0_紋柄_紋左_紋3, this.紋柄_紋左_紋3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_紋柄_紋右_紋1CP = new ColorP(this.X0Y0_紋柄_紋右_紋1, this.紋柄_紋右_紋1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_紋柄_紋右_紋2CP = new ColorP(this.X0Y0_紋柄_紋右_紋2, this.紋柄_紋右_紋2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_紋柄_紋右_紋3CP = new ColorP(this.X0Y0_紋柄_紋右_紋3, this.紋柄_紋右_紋3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_獣性_獣毛左CP = new ColorP(this.X0Y0_獣性_獣毛左, this.獣性_獣毛左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_獣性_獣毛右CP = new ColorP(this.X0Y0_獣性_獣毛右, this.獣性_獣毛右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫性_甲殻2CP = new ColorP(this.X0Y0_虫性_甲殻2, this.虫性_甲殻2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫性_甲殻1CP = new ColorP(this.X0Y0_虫性_甲殻1, this.虫性_甲殻1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_左_鱗1CP = new ColorP(this.X0Y0_竜性_左_鱗1, this.竜性_左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_左_鱗2CP = new ColorP(this.X0Y0_竜性_左_鱗2, this.竜性_左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_右_鱗1CP = new ColorP(this.X0Y0_竜性_右_鱗1, this.竜性_右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_右_鱗2CP = new ColorP(this.X0Y0_竜性_右_鱗2, this.竜性_右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ハイライト上左CP = new ColorP(this.X0Y0_ハイライト上左, this.ハイライト上左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ハイライト上右CP = new ColorP(this.X0Y0_ハイライト上右, this.ハイライト上右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ハイライト下左CP = new ColorP(this.X0Y0_ハイライト下左, this.ハイライト下左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ハイライト下右CP = new ColorP(this.X0Y0_ハイライト下右, this.ハイライト下右CD, CS$<>8__locals1.DisUnit, true);
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
			this.X0Y1_ハイライトCP = new ColorP(this.X0Y1_ハイライト, this.ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_臍CP = new ColorP(this.X0Y1_臍, this.臍CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y1_悪タトゥ_渦_タトゥ1左CP = new ColorP(this.X0Y1_悪タトゥ_渦_タトゥ1左, this.悪タトゥ_渦_タトゥ1左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ_渦_タトゥ1右CP = new ColorP(this.X0Y1_悪タトゥ_渦_タトゥ1右, this.悪タトゥ_渦_タトゥ1右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ_渦_タトゥ2左CP = new ColorP(this.X0Y1_悪タトゥ_渦_タトゥ2左, this.悪タトゥ_渦_タトゥ2左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ_渦_タトゥ2右CP = new ColorP(this.X0Y1_悪タトゥ_渦_タトゥ2右, this.悪タトゥ_渦_タトゥ2右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ1左CP = new ColorP(this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ1左, this.淫タトゥ_ハ\u30FCト_タトゥ1左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ1右CP = new ColorP(this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ1右, this.淫タトゥ_ハ\u30FCト_タトゥ1右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ2左CP = new ColorP(this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ2左, this.淫タトゥ_ハ\u30FCト_タトゥ2左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ2右CP = new ColorP(this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ2右, this.淫タトゥ_ハ\u30FCト_タトゥ2右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_傷X左CP = new ColorP(this.X0Y1_傷X左, this.傷X左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_傷X右CP = new ColorP(this.X0Y1_傷X右, this.傷X右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_傷I左CP = new ColorP(this.X0Y1_傷I左, this.傷I左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_傷I右CP = new ColorP(this.X0Y1_傷I右, this.傷I右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_紋柄_紋左_紋1CP = new ColorP(this.X0Y1_紋柄_紋左_紋1, this.紋柄_紋左_紋1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_紋柄_紋左_紋2CP = new ColorP(this.X0Y1_紋柄_紋左_紋2, this.紋柄_紋左_紋2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_紋柄_紋左_紋3CP = new ColorP(this.X0Y1_紋柄_紋左_紋3, this.紋柄_紋左_紋3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_紋柄_紋右_紋1CP = new ColorP(this.X0Y1_紋柄_紋右_紋1, this.紋柄_紋右_紋1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_紋柄_紋右_紋2CP = new ColorP(this.X0Y1_紋柄_紋右_紋2, this.紋柄_紋右_紋2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_紋柄_紋右_紋3CP = new ColorP(this.X0Y1_紋柄_紋右_紋3, this.紋柄_紋右_紋3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_獣性_獣毛左CP = new ColorP(this.X0Y1_獣性_獣毛左, this.獣性_獣毛左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_獣性_獣毛右CP = new ColorP(this.X0Y1_獣性_獣毛右, this.獣性_獣毛右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_虫性_甲殻2CP = new ColorP(this.X0Y1_虫性_甲殻2, this.虫性_甲殻2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_虫性_甲殻1CP = new ColorP(this.X0Y1_虫性_甲殻1, this.虫性_甲殻1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_竜性_左_鱗1CP = new ColorP(this.X0Y1_竜性_左_鱗1, this.竜性_左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_竜性_左_鱗2CP = new ColorP(this.X0Y1_竜性_左_鱗2, this.竜性_左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_竜性_右_鱗1CP = new ColorP(this.X0Y1_竜性_右_鱗1, this.竜性_右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_竜性_右_鱗2CP = new ColorP(this.X0Y1_竜性_右_鱗2, this.竜性_右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ハイライト上左CP = new ColorP(this.X0Y1_ハイライト上左, this.ハイライト上左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ハイライト上右CP = new ColorP(this.X0Y1_ハイライト上右, this.ハイライト上右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ハイライト下左CP = new ColorP(this.X0Y1_ハイライト下左, this.ハイライト下左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ハイライト下右CP = new ColorP(this.X0Y1_ハイライト下右, this.ハイライト下右CD, CS$<>8__locals1.DisUnit, true);
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
			this.X0Y2_ハイライトCP = new ColorP(this.X0Y2_ハイライト, this.ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_臍CP = new ColorP(this.X0Y2_臍, this.臍CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y2_悪タトゥ_渦_タトゥ1左CP = new ColorP(this.X0Y2_悪タトゥ_渦_タトゥ1左, this.悪タトゥ_渦_タトゥ1左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_悪タトゥ_渦_タトゥ1右CP = new ColorP(this.X0Y2_悪タトゥ_渦_タトゥ1右, this.悪タトゥ_渦_タトゥ1右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_悪タトゥ_渦_タトゥ2左CP = new ColorP(this.X0Y2_悪タトゥ_渦_タトゥ2左, this.悪タトゥ_渦_タトゥ2左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_悪タトゥ_渦_タトゥ2右CP = new ColorP(this.X0Y2_悪タトゥ_渦_タトゥ2右, this.悪タトゥ_渦_タトゥ2右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ1左CP = new ColorP(this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ1左, this.淫タトゥ_ハ\u30FCト_タトゥ1左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ1右CP = new ColorP(this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ1右, this.淫タトゥ_ハ\u30FCト_タトゥ1右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ2左CP = new ColorP(this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ2左, this.淫タトゥ_ハ\u30FCト_タトゥ2左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ2右CP = new ColorP(this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ2右, this.淫タトゥ_ハ\u30FCト_タトゥ2右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_傷X左CP = new ColorP(this.X0Y2_傷X左, this.傷X左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_傷X右CP = new ColorP(this.X0Y2_傷X右, this.傷X右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_傷I左CP = new ColorP(this.X0Y2_傷I左, this.傷I左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_傷I右CP = new ColorP(this.X0Y2_傷I右, this.傷I右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_紋柄_紋左_紋1CP = new ColorP(this.X0Y2_紋柄_紋左_紋1, this.紋柄_紋左_紋1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_紋柄_紋左_紋2CP = new ColorP(this.X0Y2_紋柄_紋左_紋2, this.紋柄_紋左_紋2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_紋柄_紋左_紋3CP = new ColorP(this.X0Y2_紋柄_紋左_紋3, this.紋柄_紋左_紋3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_紋柄_紋右_紋1CP = new ColorP(this.X0Y2_紋柄_紋右_紋1, this.紋柄_紋右_紋1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_紋柄_紋右_紋2CP = new ColorP(this.X0Y2_紋柄_紋右_紋2, this.紋柄_紋右_紋2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_紋柄_紋右_紋3CP = new ColorP(this.X0Y2_紋柄_紋右_紋3, this.紋柄_紋右_紋3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_獣性_獣毛左CP = new ColorP(this.X0Y2_獣性_獣毛左, this.獣性_獣毛左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_獣性_獣毛右CP = new ColorP(this.X0Y2_獣性_獣毛右, this.獣性_獣毛右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_虫性_甲殻2CP = new ColorP(this.X0Y2_虫性_甲殻2, this.虫性_甲殻2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_虫性_甲殻1CP = new ColorP(this.X0Y2_虫性_甲殻1, this.虫性_甲殻1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_竜性_左_鱗1CP = new ColorP(this.X0Y2_竜性_左_鱗1, this.竜性_左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_竜性_左_鱗2CP = new ColorP(this.X0Y2_竜性_左_鱗2, this.竜性_左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_竜性_右_鱗1CP = new ColorP(this.X0Y2_竜性_右_鱗1, this.竜性_右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_竜性_右_鱗2CP = new ColorP(this.X0Y2_竜性_右_鱗2, this.竜性_右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_ハイライト上左CP = new ColorP(this.X0Y2_ハイライト上左, this.ハイライト上左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_ハイライト上右CP = new ColorP(this.X0Y2_ハイライト上右, this.ハイライト上右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_ハイライト下左CP = new ColorP(this.X0Y2_ハイライト下左, this.ハイライト下左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_ハイライト下右CP = new ColorP(this.X0Y2_ハイライト下右, this.ハイライト下右CD, CS$<>8__locals1.DisUnit, true);
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
			this.X0Y3_ハイライトCP = new ColorP(this.X0Y3_ハイライト, this.ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_臍CP = new ColorP(this.X0Y3_臍, this.臍CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y3_悪タトゥ_渦_タトゥ1左CP = new ColorP(this.X0Y3_悪タトゥ_渦_タトゥ1左, this.悪タトゥ_渦_タトゥ1左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_悪タトゥ_渦_タトゥ1右CP = new ColorP(this.X0Y3_悪タトゥ_渦_タトゥ1右, this.悪タトゥ_渦_タトゥ1右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_悪タトゥ_渦_タトゥ2左CP = new ColorP(this.X0Y3_悪タトゥ_渦_タトゥ2左, this.悪タトゥ_渦_タトゥ2左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_悪タトゥ_渦_タトゥ2右CP = new ColorP(this.X0Y3_悪タトゥ_渦_タトゥ2右, this.悪タトゥ_渦_タトゥ2右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ1左CP = new ColorP(this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ1左, this.淫タトゥ_ハ\u30FCト_タトゥ1左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ1右CP = new ColorP(this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ1右, this.淫タトゥ_ハ\u30FCト_タトゥ1右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ2左CP = new ColorP(this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ2左, this.淫タトゥ_ハ\u30FCト_タトゥ2左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ2右CP = new ColorP(this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ2右, this.淫タトゥ_ハ\u30FCト_タトゥ2右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_傷X左CP = new ColorP(this.X0Y3_傷X左, this.傷X左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_傷X右CP = new ColorP(this.X0Y3_傷X右, this.傷X右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_傷I左CP = new ColorP(this.X0Y3_傷I左, this.傷I左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_傷I右CP = new ColorP(this.X0Y3_傷I右, this.傷I右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_紋柄_紋左_紋1CP = new ColorP(this.X0Y3_紋柄_紋左_紋1, this.紋柄_紋左_紋1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_紋柄_紋左_紋2CP = new ColorP(this.X0Y3_紋柄_紋左_紋2, this.紋柄_紋左_紋2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_紋柄_紋左_紋3CP = new ColorP(this.X0Y3_紋柄_紋左_紋3, this.紋柄_紋左_紋3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_紋柄_紋右_紋1CP = new ColorP(this.X0Y3_紋柄_紋右_紋1, this.紋柄_紋右_紋1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_紋柄_紋右_紋2CP = new ColorP(this.X0Y3_紋柄_紋右_紋2, this.紋柄_紋右_紋2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_紋柄_紋右_紋3CP = new ColorP(this.X0Y3_紋柄_紋右_紋3, this.紋柄_紋右_紋3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_獣性_獣毛左CP = new ColorP(this.X0Y3_獣性_獣毛左, this.獣性_獣毛左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_獣性_獣毛右CP = new ColorP(this.X0Y3_獣性_獣毛右, this.獣性_獣毛右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_虫性_甲殻2CP = new ColorP(this.X0Y3_虫性_甲殻2, this.虫性_甲殻2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_虫性_甲殻1CP = new ColorP(this.X0Y3_虫性_甲殻1, this.虫性_甲殻1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_竜性_左_鱗1CP = new ColorP(this.X0Y3_竜性_左_鱗1, this.竜性_左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_竜性_左_鱗2CP = new ColorP(this.X0Y3_竜性_左_鱗2, this.竜性_左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_竜性_右_鱗1CP = new ColorP(this.X0Y3_竜性_右_鱗1, this.竜性_右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_竜性_右_鱗2CP = new ColorP(this.X0Y3_竜性_右_鱗2, this.竜性_右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_ハイライト上左CP = new ColorP(this.X0Y3_ハイライト上左, this.ハイライト上左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_ハイライト上右CP = new ColorP(this.X0Y3_ハイライト上右, this.ハイライト上右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_ハイライト下左CP = new ColorP(this.X0Y3_ハイライト下左, this.ハイライト下左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_ハイライト下右CP = new ColorP(this.X0Y3_ハイライト下右, this.ハイライト下右CD, CS$<>8__locals1.DisUnit, true);
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
			this.X0Y4_ハイライトCP = new ColorP(this.X0Y4_ハイライト, this.ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_臍CP = new ColorP(this.X0Y4_臍, this.臍CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y4_悪タトゥ_渦_タトゥ1左CP = new ColorP(this.X0Y4_悪タトゥ_渦_タトゥ1左, this.悪タトゥ_渦_タトゥ1左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_悪タトゥ_渦_タトゥ1右CP = new ColorP(this.X0Y4_悪タトゥ_渦_タトゥ1右, this.悪タトゥ_渦_タトゥ1右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_悪タトゥ_渦_タトゥ2左CP = new ColorP(this.X0Y4_悪タトゥ_渦_タトゥ2左, this.悪タトゥ_渦_タトゥ2左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_悪タトゥ_渦_タトゥ2右CP = new ColorP(this.X0Y4_悪タトゥ_渦_タトゥ2右, this.悪タトゥ_渦_タトゥ2右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ1左CP = new ColorP(this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ1左, this.淫タトゥ_ハ\u30FCト_タトゥ1左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ1右CP = new ColorP(this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ1右, this.淫タトゥ_ハ\u30FCト_タトゥ1右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ2左CP = new ColorP(this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ2左, this.淫タトゥ_ハ\u30FCト_タトゥ2左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ2右CP = new ColorP(this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ2右, this.淫タトゥ_ハ\u30FCト_タトゥ2右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_傷X左CP = new ColorP(this.X0Y4_傷X左, this.傷X左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_傷X右CP = new ColorP(this.X0Y4_傷X右, this.傷X右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_傷I左CP = new ColorP(this.X0Y4_傷I左, this.傷I左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_傷I右CP = new ColorP(this.X0Y4_傷I右, this.傷I右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_紋柄_紋左_紋1CP = new ColorP(this.X0Y4_紋柄_紋左_紋1, this.紋柄_紋左_紋1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_紋柄_紋左_紋2CP = new ColorP(this.X0Y4_紋柄_紋左_紋2, this.紋柄_紋左_紋2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_紋柄_紋左_紋3CP = new ColorP(this.X0Y4_紋柄_紋左_紋3, this.紋柄_紋左_紋3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_紋柄_紋右_紋1CP = new ColorP(this.X0Y4_紋柄_紋右_紋1, this.紋柄_紋右_紋1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_紋柄_紋右_紋2CP = new ColorP(this.X0Y4_紋柄_紋右_紋2, this.紋柄_紋右_紋2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_紋柄_紋右_紋3CP = new ColorP(this.X0Y4_紋柄_紋右_紋3, this.紋柄_紋右_紋3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_獣性_獣毛左CP = new ColorP(this.X0Y4_獣性_獣毛左, this.獣性_獣毛左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_獣性_獣毛右CP = new ColorP(this.X0Y4_獣性_獣毛右, this.獣性_獣毛右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_虫性_甲殻2CP = new ColorP(this.X0Y4_虫性_甲殻2, this.虫性_甲殻2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_虫性_甲殻1CP = new ColorP(this.X0Y4_虫性_甲殻1, this.虫性_甲殻1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_竜性_左_鱗1CP = new ColorP(this.X0Y4_竜性_左_鱗1, this.竜性_左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_竜性_左_鱗2CP = new ColorP(this.X0Y4_竜性_左_鱗2, this.竜性_左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_竜性_右_鱗1CP = new ColorP(this.X0Y4_竜性_右_鱗1, this.竜性_右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_竜性_右_鱗2CP = new ColorP(this.X0Y4_竜性_右_鱗2, this.竜性_右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_ハイライト上左CP = new ColorP(this.X0Y4_ハイライト上左, this.ハイライト上左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_ハイライト上右CP = new ColorP(this.X0Y4_ハイライト上右, this.ハイライト上右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_ハイライト下左CP = new ColorP(this.X0Y4_ハイライト下左, this.ハイライト下左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_ハイライト下右CP = new ColorP(this.X0Y4_ハイライト下右, this.ハイライト下右CD, CS$<>8__locals1.DisUnit, true);
			this.筋肉濃度 = e.筋肉濃度;
			this.傷X左濃度 = e.傷X左濃度;
			this.傷X右濃度 = e.傷X右濃度;
			this.傷I左濃度 = e.傷I左濃度;
			this.傷I右濃度 = e.傷I右濃度;
			this.ハイライト濃度 = e.ハイライト濃度;
			this.濃度 = e.濃度;
			this.尺度YB = 0.95;
			this.X0Y0_臍.BasePointBase = new Vector2D(this.X0Y0_臍.BasePointBase.X, 0.363998381176966);
			this.X0Y1_臍.BasePointBase = new Vector2D(this.X0Y1_臍.BasePointBase.X, 0.363099175689868);
			this.X0Y2_臍.BasePointBase = new Vector2D(this.X0Y2_臍.BasePointBase.X, 0.362199970202771);
			this.X0Y3_臍.BasePointBase = new Vector2D(this.X0Y3_臍.BasePointBase.X, 0.361300764715674);
			this.X0Y4_臍.BasePointBase = new Vector2D(this.X0Y4_臍.BasePointBase.X, 0.360401559228577);
			this.X0Y0_ハイライト.BasePointBase = new Vector2D(this.X0Y0_ハイライト.BasePointBase.X, 0.0225674877335118);
			this.X0Y1_ハイライト.BasePointBase = new Vector2D(this.X0Y1_ハイライト.BasePointBase.X, 0.0218134639688308);
			this.X0Y2_ハイライト.BasePointBase = new Vector2D(this.X0Y2_ハイライト.BasePointBase.X, 0.0210594402041497);
			this.X0Y3_ハイライト.BasePointBase = new Vector2D(this.X0Y3_ハイライト.BasePointBase.X, 0.0203054164394687);
			this.X0Y4_ハイライト.BasePointBase = new Vector2D(this.X0Y4_ハイライト.BasePointBase.X, 0.0195513926747877);
			double num = 1.5;
			this.X0Y0_臍.SizeBase *= num;
			this.X0Y1_臍.SizeBase *= num;
			this.X0Y2_臍.SizeBase *= num;
			this.X0Y3_臍.SizeBase *= num;
			this.X0Y4_臍.SizeBase *= num;
			this.X0Y0_ハイライト.SizeBase *= num;
			this.X0Y1_ハイライト.SizeBase *= num;
			this.X0Y2_ハイライト.SizeBase *= num;
			this.X0Y3_ハイライト.SizeBase *= num;
			this.X0Y4_ハイライト.SizeBase *= num;
			num = 0.6;
			this.X0Y0_臍.SizeXBase *= num;
			this.X0Y1_臍.SizeXBase *= num;
			this.X0Y2_臍.SizeXBase *= num;
			this.X0Y3_臍.SizeXBase *= num;
			this.X0Y4_臍.SizeXBase *= num;
			this.X0Y0_ハイライト.SizeXBase *= num;
			this.X0Y1_ハイライト.SizeXBase *= num;
			this.X0Y2_ハイライト.SizeXBase *= num;
			this.X0Y3_ハイライト.SizeXBase *= num;
			this.X0Y4_ハイライト.SizeXBase *= num;
			num = 1.009;
			this.X0Y0_腰.BasePointBase = this.X0Y0_腰.JP[0].Joint.MulY(num);
			this.X0Y1_腰.BasePointBase = this.X0Y1_腰.JP[0].Joint.MulY(num);
			this.X0Y2_腰.BasePointBase = this.X0Y2_腰.JP[0].Joint.MulY(num);
			this.X0Y3_腰.BasePointBase = this.X0Y3_腰.JP[0].Joint.MulY(num);
			this.X0Y4_腰.BasePointBase = this.X0Y4_腰.JP[0].Joint.MulY(num);
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

		public bool ハイライト_表示
		{
			get
			{
				return this.X0Y0_ハイライト.Dra;
			}
			set
			{
				this.X0Y0_ハイライト.Dra = value;
				this.X0Y1_ハイライト.Dra = value;
				this.X0Y2_ハイライト.Dra = value;
				this.X0Y3_ハイライト.Dra = value;
				this.X0Y4_ハイライト.Dra = value;
				this.X0Y0_ハイライト.Hit = value;
				this.X0Y1_ハイライト.Hit = value;
				this.X0Y2_ハイライト.Hit = value;
				this.X0Y3_ハイライト.Hit = value;
				this.X0Y4_ハイライト.Hit = value;
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

		public bool 悪タトゥ_渦_タトゥ1左_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_渦_タトゥ1左.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_渦_タトゥ1左.Dra = value;
				this.X0Y1_悪タトゥ_渦_タトゥ1左.Dra = value;
				this.X0Y2_悪タトゥ_渦_タトゥ1左.Dra = value;
				this.X0Y3_悪タトゥ_渦_タトゥ1左.Dra = value;
				this.X0Y4_悪タトゥ_渦_タトゥ1左.Dra = value;
				this.X0Y0_悪タトゥ_渦_タトゥ1左.Hit = value;
				this.X0Y1_悪タトゥ_渦_タトゥ1左.Hit = value;
				this.X0Y2_悪タトゥ_渦_タトゥ1左.Hit = value;
				this.X0Y3_悪タトゥ_渦_タトゥ1左.Hit = value;
				this.X0Y4_悪タトゥ_渦_タトゥ1左.Hit = value;
			}
		}

		public bool 悪タトゥ_渦_タトゥ1右_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_渦_タトゥ1右.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_渦_タトゥ1右.Dra = value;
				this.X0Y1_悪タトゥ_渦_タトゥ1右.Dra = value;
				this.X0Y2_悪タトゥ_渦_タトゥ1右.Dra = value;
				this.X0Y3_悪タトゥ_渦_タトゥ1右.Dra = value;
				this.X0Y4_悪タトゥ_渦_タトゥ1右.Dra = value;
				this.X0Y0_悪タトゥ_渦_タトゥ1右.Hit = value;
				this.X0Y1_悪タトゥ_渦_タトゥ1右.Hit = value;
				this.X0Y2_悪タトゥ_渦_タトゥ1右.Hit = value;
				this.X0Y3_悪タトゥ_渦_タトゥ1右.Hit = value;
				this.X0Y4_悪タトゥ_渦_タトゥ1右.Hit = value;
			}
		}

		public bool 悪タトゥ_渦_タトゥ2左_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_渦_タトゥ2左.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_渦_タトゥ2左.Dra = value;
				this.X0Y1_悪タトゥ_渦_タトゥ2左.Dra = value;
				this.X0Y2_悪タトゥ_渦_タトゥ2左.Dra = value;
				this.X0Y3_悪タトゥ_渦_タトゥ2左.Dra = value;
				this.X0Y4_悪タトゥ_渦_タトゥ2左.Dra = value;
				this.X0Y0_悪タトゥ_渦_タトゥ2左.Hit = value;
				this.X0Y1_悪タトゥ_渦_タトゥ2左.Hit = value;
				this.X0Y2_悪タトゥ_渦_タトゥ2左.Hit = value;
				this.X0Y3_悪タトゥ_渦_タトゥ2左.Hit = value;
				this.X0Y4_悪タトゥ_渦_タトゥ2左.Hit = value;
			}
		}

		public bool 悪タトゥ_渦_タトゥ2右_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_渦_タトゥ2右.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_渦_タトゥ2右.Dra = value;
				this.X0Y1_悪タトゥ_渦_タトゥ2右.Dra = value;
				this.X0Y2_悪タトゥ_渦_タトゥ2右.Dra = value;
				this.X0Y3_悪タトゥ_渦_タトゥ2右.Dra = value;
				this.X0Y4_悪タトゥ_渦_タトゥ2右.Dra = value;
				this.X0Y0_悪タトゥ_渦_タトゥ2右.Hit = value;
				this.X0Y1_悪タトゥ_渦_タトゥ2右.Hit = value;
				this.X0Y2_悪タトゥ_渦_タトゥ2右.Hit = value;
				this.X0Y3_悪タトゥ_渦_タトゥ2右.Hit = value;
				this.X0Y4_悪タトゥ_渦_タトゥ2右.Hit = value;
			}
		}

		public bool 淫タトゥ_ハ\u30FCト_タトゥ1左_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ1左.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ1左.Dra = value;
				this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ1左.Dra = value;
				this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ1左.Dra = value;
				this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ1左.Dra = value;
				this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ1左.Dra = value;
				this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ1左.Hit = value;
				this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ1左.Hit = value;
				this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ1左.Hit = value;
				this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ1左.Hit = value;
				this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ1左.Hit = value;
			}
		}

		public bool 淫タトゥ_ハ\u30FCト_タトゥ1右_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ1右.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ1右.Dra = value;
				this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ1右.Dra = value;
				this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ1右.Dra = value;
				this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ1右.Dra = value;
				this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ1右.Dra = value;
				this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ1右.Hit = value;
				this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ1右.Hit = value;
				this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ1右.Hit = value;
				this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ1右.Hit = value;
				this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ1右.Hit = value;
			}
		}

		public bool 淫タトゥ_ハ\u30FCト_タトゥ2左_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ2左.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ2左.Dra = value;
				this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ2左.Dra = value;
				this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ2左.Dra = value;
				this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ2左.Dra = value;
				this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ2左.Dra = value;
				this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ2左.Hit = value;
				this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ2左.Hit = value;
				this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ2左.Hit = value;
				this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ2左.Hit = value;
				this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ2左.Hit = value;
			}
		}

		public bool 淫タトゥ_ハ\u30FCト_タトゥ2右_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ2右.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ2右.Dra = value;
				this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ2右.Dra = value;
				this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ2右.Dra = value;
				this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ2右.Dra = value;
				this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ2右.Dra = value;
				this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ2右.Hit = value;
				this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ2右.Hit = value;
				this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ2右.Hit = value;
				this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ2右.Hit = value;
				this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ2右.Hit = value;
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
				this.X0Y1_傷X左.Dra = value;
				this.X0Y2_傷X左.Dra = value;
				this.X0Y3_傷X左.Dra = value;
				this.X0Y4_傷X左.Dra = value;
				this.X0Y0_傷X左.Hit = value;
				this.X0Y1_傷X左.Hit = value;
				this.X0Y2_傷X左.Hit = value;
				this.X0Y3_傷X左.Hit = value;
				this.X0Y4_傷X左.Hit = value;
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
				this.X0Y1_傷X右.Dra = value;
				this.X0Y2_傷X右.Dra = value;
				this.X0Y3_傷X右.Dra = value;
				this.X0Y4_傷X右.Dra = value;
				this.X0Y0_傷X右.Hit = value;
				this.X0Y1_傷X右.Hit = value;
				this.X0Y2_傷X右.Hit = value;
				this.X0Y3_傷X右.Hit = value;
				this.X0Y4_傷X右.Hit = value;
			}
		}

		public bool 傷I左_表示
		{
			get
			{
				return this.X0Y0_傷I左.Dra;
			}
			set
			{
				this.X0Y0_傷I左.Dra = value;
				this.X0Y1_傷I左.Dra = value;
				this.X0Y2_傷I左.Dra = value;
				this.X0Y3_傷I左.Dra = value;
				this.X0Y4_傷I左.Dra = value;
				this.X0Y0_傷I左.Hit = value;
				this.X0Y1_傷I左.Hit = value;
				this.X0Y2_傷I左.Hit = value;
				this.X0Y3_傷I左.Hit = value;
				this.X0Y4_傷I左.Hit = value;
			}
		}

		public bool 傷I右_表示
		{
			get
			{
				return this.X0Y0_傷I右.Dra;
			}
			set
			{
				this.X0Y0_傷I右.Dra = value;
				this.X0Y1_傷I右.Dra = value;
				this.X0Y2_傷I右.Dra = value;
				this.X0Y3_傷I右.Dra = value;
				this.X0Y4_傷I右.Dra = value;
				this.X0Y0_傷I右.Hit = value;
				this.X0Y1_傷I右.Hit = value;
				this.X0Y2_傷I右.Hit = value;
				this.X0Y3_傷I右.Hit = value;
				this.X0Y4_傷I右.Hit = value;
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

		public bool 獣性_獣毛左_表示
		{
			get
			{
				return this.X0Y0_獣性_獣毛左.Dra;
			}
			set
			{
				this.X0Y0_獣性_獣毛左.Dra = value;
				this.X0Y1_獣性_獣毛左.Dra = value;
				this.X0Y2_獣性_獣毛左.Dra = value;
				this.X0Y3_獣性_獣毛左.Dra = value;
				this.X0Y4_獣性_獣毛左.Dra = value;
				this.X0Y0_獣性_獣毛左.Hit = value;
				this.X0Y1_獣性_獣毛左.Hit = value;
				this.X0Y2_獣性_獣毛左.Hit = value;
				this.X0Y3_獣性_獣毛左.Hit = value;
				this.X0Y4_獣性_獣毛左.Hit = value;
			}
		}

		public bool 獣性_獣毛右_表示
		{
			get
			{
				return this.X0Y0_獣性_獣毛右.Dra;
			}
			set
			{
				this.X0Y0_獣性_獣毛右.Dra = value;
				this.X0Y1_獣性_獣毛右.Dra = value;
				this.X0Y2_獣性_獣毛右.Dra = value;
				this.X0Y3_獣性_獣毛右.Dra = value;
				this.X0Y4_獣性_獣毛右.Dra = value;
				this.X0Y0_獣性_獣毛右.Hit = value;
				this.X0Y1_獣性_獣毛右.Hit = value;
				this.X0Y2_獣性_獣毛右.Hit = value;
				this.X0Y3_獣性_獣毛右.Hit = value;
				this.X0Y4_獣性_獣毛右.Hit = value;
			}
		}

		public bool 虫性_甲殻2_表示
		{
			get
			{
				return this.X0Y0_虫性_甲殻2.Dra;
			}
			set
			{
				this.X0Y0_虫性_甲殻2.Dra = value;
				this.X0Y1_虫性_甲殻2.Dra = value;
				this.X0Y2_虫性_甲殻2.Dra = value;
				this.X0Y3_虫性_甲殻2.Dra = value;
				this.X0Y4_虫性_甲殻2.Dra = value;
				this.X0Y0_虫性_甲殻2.Hit = value;
				this.X0Y1_虫性_甲殻2.Hit = value;
				this.X0Y2_虫性_甲殻2.Hit = value;
				this.X0Y3_虫性_甲殻2.Hit = value;
				this.X0Y4_虫性_甲殻2.Hit = value;
			}
		}

		public bool 虫性_甲殻1_表示
		{
			get
			{
				return this.X0Y0_虫性_甲殻1.Dra;
			}
			set
			{
				this.X0Y0_虫性_甲殻1.Dra = value;
				this.X0Y1_虫性_甲殻1.Dra = value;
				this.X0Y2_虫性_甲殻1.Dra = value;
				this.X0Y3_虫性_甲殻1.Dra = value;
				this.X0Y4_虫性_甲殻1.Dra = value;
				this.X0Y0_虫性_甲殻1.Hit = value;
				this.X0Y1_虫性_甲殻1.Hit = value;
				this.X0Y2_虫性_甲殻1.Hit = value;
				this.X0Y3_虫性_甲殻1.Hit = value;
				this.X0Y4_虫性_甲殻1.Hit = value;
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

		public bool ハイライト上左_表示
		{
			get
			{
				return this.X0Y0_ハイライト上左.Dra;
			}
			set
			{
				this.X0Y0_ハイライト上左.Dra = value;
				this.X0Y1_ハイライト上左.Dra = value;
				this.X0Y2_ハイライト上左.Dra = value;
				this.X0Y3_ハイライト上左.Dra = value;
				this.X0Y4_ハイライト上左.Dra = value;
				this.X0Y0_ハイライト上左.Hit = value;
				this.X0Y1_ハイライト上左.Hit = value;
				this.X0Y2_ハイライト上左.Hit = value;
				this.X0Y3_ハイライト上左.Hit = value;
				this.X0Y4_ハイライト上左.Hit = value;
			}
		}

		public bool ハイライト上右_表示
		{
			get
			{
				return this.X0Y0_ハイライト上右.Dra;
			}
			set
			{
				this.X0Y0_ハイライト上右.Dra = value;
				this.X0Y1_ハイライト上右.Dra = value;
				this.X0Y2_ハイライト上右.Dra = value;
				this.X0Y3_ハイライト上右.Dra = value;
				this.X0Y4_ハイライト上右.Dra = value;
				this.X0Y0_ハイライト上右.Hit = value;
				this.X0Y1_ハイライト上右.Hit = value;
				this.X0Y2_ハイライト上右.Hit = value;
				this.X0Y3_ハイライト上右.Hit = value;
				this.X0Y4_ハイライト上右.Hit = value;
			}
		}

		public bool ハイライト下左_表示
		{
			get
			{
				return this.X0Y0_ハイライト下左.Dra;
			}
			set
			{
				this.X0Y0_ハイライト下左.Dra = value;
				this.X0Y1_ハイライト下左.Dra = value;
				this.X0Y2_ハイライト下左.Dra = value;
				this.X0Y3_ハイライト下左.Dra = value;
				this.X0Y4_ハイライト下左.Dra = value;
				this.X0Y0_ハイライト下左.Hit = value;
				this.X0Y1_ハイライト下左.Hit = value;
				this.X0Y2_ハイライト下左.Hit = value;
				this.X0Y3_ハイライト下左.Hit = value;
				this.X0Y4_ハイライト下左.Hit = value;
			}
		}

		public bool ハイライト下右_表示
		{
			get
			{
				return this.X0Y0_ハイライト下右.Dra;
			}
			set
			{
				this.X0Y0_ハイライト下右.Dra = value;
				this.X0Y1_ハイライト下右.Dra = value;
				this.X0Y2_ハイライト下右.Dra = value;
				this.X0Y3_ハイライト下右.Dra = value;
				this.X0Y4_ハイライト下右.Dra = value;
				this.X0Y0_ハイライト下右.Hit = value;
				this.X0Y1_ハイライト下右.Hit = value;
				this.X0Y2_ハイライト下右.Hit = value;
				this.X0Y3_ハイライト下右.Hit = value;
				this.X0Y4_ハイライト下右.Hit = value;
			}
		}

		public bool ハイライト表示
		{
			get
			{
				return this.ハイライト_表示;
			}
			set
			{
				this.ハイライト_表示 = value;
				this.ハイライト上左_表示 = value;
				this.ハイライト上右_表示 = value;
				this.ハイライト下左_表示 = value;
				this.ハイライト下右_表示 = value;
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

		public double 傷I左濃度
		{
			get
			{
				return this.傷I左CD.不透明度;
			}
			set
			{
				this.傷I左CD.不透明度 = value;
			}
		}

		public double 傷I右濃度
		{
			get
			{
				return this.傷I右CD.不透明度;
			}
			set
			{
				this.傷I右CD.不透明度 = value;
			}
		}

		public double ハイライト濃度
		{
			get
			{
				return this.ハイライトCD.不透明度;
			}
			set
			{
				this.ハイライトCD.不透明度 = value;
				this.ハイライト上左CD.不透明度 = value;
				this.ハイライト上右CD.不透明度 = value;
				this.ハイライト下左CD.不透明度 = value;
				this.ハイライト下右CD.不透明度 = value;
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
				this.ハイライト_表示 = value;
				this.臍_表示 = value;
				this.悪タトゥ_渦_タトゥ1左_表示 = value;
				this.悪タトゥ_渦_タトゥ1右_表示 = value;
				this.悪タトゥ_渦_タトゥ2左_表示 = value;
				this.悪タトゥ_渦_タトゥ2右_表示 = value;
				this.淫タトゥ_ハ\u30FCト_タトゥ1左_表示 = value;
				this.淫タトゥ_ハ\u30FCト_タトゥ1右_表示 = value;
				this.淫タトゥ_ハ\u30FCト_タトゥ2左_表示 = value;
				this.淫タトゥ_ハ\u30FCト_タトゥ2右_表示 = value;
				this.傷X左_表示 = value;
				this.傷X右_表示 = value;
				this.傷I左_表示 = value;
				this.傷I右_表示 = value;
				this.紋柄_紋左_紋1_表示 = value;
				this.紋柄_紋左_紋2_表示 = value;
				this.紋柄_紋左_紋3_表示 = value;
				this.紋柄_紋右_紋1_表示 = value;
				this.紋柄_紋右_紋2_表示 = value;
				this.紋柄_紋右_紋3_表示 = value;
				this.獣性_獣毛左_表示 = value;
				this.獣性_獣毛右_表示 = value;
				this.虫性_甲殻2_表示 = value;
				this.虫性_甲殻1_表示 = value;
				this.竜性_左_鱗1_表示 = value;
				this.竜性_左_鱗2_表示 = value;
				this.竜性_右_鱗1_表示 = value;
				this.竜性_右_鱗2_表示 = value;
				this.ハイライト上左_表示 = value;
				this.ハイライト上右_表示 = value;
				this.ハイライト下左_表示 = value;
				this.ハイライト下右_表示 = value;
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
				this.ハイライトCD.不透明度 = value;
				this.臍CD.不透明度 = value;
				this.悪タトゥ_渦_タトゥ1左CD.不透明度 = value;
				this.悪タトゥ_渦_タトゥ1右CD.不透明度 = value;
				this.悪タトゥ_渦_タトゥ2左CD.不透明度 = value;
				this.悪タトゥ_渦_タトゥ2右CD.不透明度 = value;
				this.淫タトゥ_ハ\u30FCト_タトゥ1左CD.不透明度 = value;
				this.淫タトゥ_ハ\u30FCト_タトゥ1右CD.不透明度 = value;
				this.淫タトゥ_ハ\u30FCト_タトゥ2左CD.不透明度 = value;
				this.淫タトゥ_ハ\u30FCト_タトゥ2右CD.不透明度 = value;
				this.傷X左CD.不透明度 = value;
				this.傷X右CD.不透明度 = value;
				this.傷I左CD.不透明度 = value;
				this.傷I右CD.不透明度 = value;
				this.紋柄_紋左_紋1CD.不透明度 = value;
				this.紋柄_紋左_紋2CD.不透明度 = value;
				this.紋柄_紋左_紋3CD.不透明度 = value;
				this.紋柄_紋右_紋1CD.不透明度 = value;
				this.紋柄_紋右_紋2CD.不透明度 = value;
				this.紋柄_紋右_紋3CD.不透明度 = value;
				this.獣性_獣毛左CD.不透明度 = value;
				this.獣性_獣毛右CD.不透明度 = value;
				this.虫性_甲殻2CD.不透明度 = value;
				this.虫性_甲殻1CD.不透明度 = value;
				this.竜性_左_鱗1CD.不透明度 = value;
				this.竜性_左_鱗2CD.不透明度 = value;
				this.竜性_右_鱗1CD.不透明度 = value;
				this.竜性_右_鱗2CD.不透明度 = value;
				this.ハイライト上左CD.不透明度 = value;
				this.ハイライト上右CD.不透明度 = value;
				this.ハイライト下左CD.不透明度 = value;
				this.ハイライト下右CD.不透明度 = value;
			}
		}

		public void スライム()
		{
			this.X0Y0_腰.OP[this.右 ? 3 : 3].Outline = false;
			this.X0Y0_腰.OP[this.右 ? 2 : 4].Outline = false;
			this.X0Y1_腰.OP[this.右 ? 3 : 3].Outline = false;
			this.X0Y1_腰.OP[this.右 ? 2 : 4].Outline = false;
			this.X0Y2_腰.OP[this.右 ? 3 : 3].Outline = false;
			this.X0Y2_腰.OP[this.右 ? 2 : 4].Outline = false;
			this.X0Y3_腰.OP[this.右 ? 3 : 3].Outline = false;
			this.X0Y3_腰.OP[this.右 ? 2 : 4].Outline = false;
			this.X0Y4_腰.OP[this.右 ? 3 : 3].Outline = false;
			this.X0Y4_腰.OP[this.右 ? 2 : 4].Outline = false;
			this.X0Y0_股.OP.OutlineFalse();
			this.X0Y1_股.OP.OutlineFalse();
			this.X0Y2_股.OP.OutlineFalse();
			this.X0Y3_股.OP.OutlineFalse();
			this.X0Y4_股.OP.OutlineFalse();
			this.X0Y0_下腹.OP[this.右 ? 3 : 2].Outline = false;
			this.X0Y0_下腹.OP[this.右 ? 1 : 4].Outline = false;
			this.X0Y1_下腹.OP[this.右 ? 3 : 2].Outline = false;
			this.X0Y1_下腹.OP[this.右 ? 1 : 4].Outline = false;
			this.X0Y2_下腹.OP[this.右 ? 3 : 2].Outline = false;
			this.X0Y2_下腹.OP[this.右 ? 1 : 4].Outline = false;
			this.X0Y3_下腹.OP[this.右 ? 3 : 2].Outline = false;
			this.X0Y3_下腹.OP[this.右 ? 1 : 4].Outline = false;
			this.X0Y4_下腹.OP[this.右 ? 3 : 2].Outline = false;
			this.X0Y4_下腹.OP[this.右 ? 1 : 4].Outline = false;
		}

		public override void 接続P()
		{
			this.本体.JoinP();
		}

		public override void 接続PA()
		{
			this.本体.JoinPA();
		}

		public override void 描画0(Are Are)
		{
			switch (this.本体.IndexY)
			{
			case 0:
				Are.Draw(this.X0Y0_腰);
				Are.Draw(this.X0Y0_股);
				Are.Draw(this.X0Y0_下腹);
				Are.Draw(this.X0Y0_腰皺);
				Are.Draw(this.X0Y0_筋肉_筋肉下);
				Are.Draw(this.X0Y0_筋肉_筋肉左);
				Are.Draw(this.X0Y0_筋肉_筋肉右);
				Are.Draw(this.X0Y0_筋肉_筋上左);
				Are.Draw(this.X0Y0_筋肉_筋上右);
				Are.Draw(this.X0Y0_筋肉_筋下左);
				Are.Draw(this.X0Y0_筋肉_筋下右);
				return;
			case 1:
				Are.Draw(this.X0Y1_腰);
				Are.Draw(this.X0Y1_股);
				Are.Draw(this.X0Y1_下腹);
				Are.Draw(this.X0Y1_腰皺);
				Are.Draw(this.X0Y1_筋肉_筋肉下);
				Are.Draw(this.X0Y1_筋肉_筋肉左);
				Are.Draw(this.X0Y1_筋肉_筋肉右);
				Are.Draw(this.X0Y1_筋肉_筋上左);
				Are.Draw(this.X0Y1_筋肉_筋上右);
				Are.Draw(this.X0Y1_筋肉_筋下左);
				Are.Draw(this.X0Y1_筋肉_筋下右);
				return;
			case 2:
				Are.Draw(this.X0Y2_腰);
				Are.Draw(this.X0Y2_股);
				Are.Draw(this.X0Y2_下腹);
				Are.Draw(this.X0Y2_腰皺);
				Are.Draw(this.X0Y2_筋肉_筋肉下);
				Are.Draw(this.X0Y2_筋肉_筋肉左);
				Are.Draw(this.X0Y2_筋肉_筋肉右);
				Are.Draw(this.X0Y2_筋肉_筋上左);
				Are.Draw(this.X0Y2_筋肉_筋上右);
				Are.Draw(this.X0Y2_筋肉_筋下左);
				Are.Draw(this.X0Y2_筋肉_筋下右);
				return;
			case 3:
				Are.Draw(this.X0Y3_腰);
				Are.Draw(this.X0Y3_股);
				Are.Draw(this.X0Y3_下腹);
				Are.Draw(this.X0Y3_腰皺);
				Are.Draw(this.X0Y3_筋肉_筋肉下);
				Are.Draw(this.X0Y3_筋肉_筋肉左);
				Are.Draw(this.X0Y3_筋肉_筋肉右);
				Are.Draw(this.X0Y3_筋肉_筋上左);
				Are.Draw(this.X0Y3_筋肉_筋上右);
				Are.Draw(this.X0Y3_筋肉_筋下左);
				Are.Draw(this.X0Y3_筋肉_筋下右);
				return;
			default:
				Are.Draw(this.X0Y4_腰);
				Are.Draw(this.X0Y4_股);
				Are.Draw(this.X0Y4_下腹);
				Are.Draw(this.X0Y4_腰皺);
				Are.Draw(this.X0Y4_筋肉_筋肉下);
				Are.Draw(this.X0Y4_筋肉_筋肉左);
				Are.Draw(this.X0Y4_筋肉_筋肉右);
				Are.Draw(this.X0Y4_筋肉_筋上左);
				Are.Draw(this.X0Y4_筋肉_筋上右);
				Are.Draw(this.X0Y4_筋肉_筋下左);
				Are.Draw(this.X0Y4_筋肉_筋下右);
				return;
			}
		}

		public override void 描画1(Are Are)
		{
			switch (this.本体.IndexY)
			{
			case 0:
				Are.Draw(this.X0Y0_ハイライト);
				Are.Draw(this.X0Y0_臍);
				Are.Draw(this.X0Y0_悪タトゥ_渦_タトゥ1左);
				Are.Draw(this.X0Y0_悪タトゥ_渦_タトゥ1右);
				Are.Draw(this.X0Y0_悪タトゥ_渦_タトゥ2左);
				Are.Draw(this.X0Y0_悪タトゥ_渦_タトゥ2右);
				Are.Draw(this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ1左);
				Are.Draw(this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ1右);
				Are.Draw(this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ2左);
				Are.Draw(this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ2右);
				Are.Draw(this.X0Y0_紋柄_紋左_紋1);
				Are.Draw(this.X0Y0_紋柄_紋左_紋2);
				Are.Draw(this.X0Y0_紋柄_紋左_紋3);
				Are.Draw(this.X0Y0_紋柄_紋右_紋1);
				Are.Draw(this.X0Y0_紋柄_紋右_紋2);
				Are.Draw(this.X0Y0_紋柄_紋右_紋3);
				Are.Draw(this.X0Y0_獣性_獣毛左);
				Are.Draw(this.X0Y0_獣性_獣毛右);
				Are.Draw(this.X0Y0_傷X左);
				Are.Draw(this.X0Y0_傷X右);
				Are.Draw(this.X0Y0_傷I左);
				Are.Draw(this.X0Y0_傷I右);
				this.キスマ\u30FCク.Draw(Are);
				this.鞭痕.Draw(Are);
				Are.Draw(this.X0Y0_虫性_甲殻2);
				Are.Draw(this.X0Y0_虫性_甲殻1);
				Are.Draw(this.X0Y0_竜性_左_鱗1);
				Are.Draw(this.X0Y0_竜性_左_鱗2);
				Are.Draw(this.X0Y0_竜性_右_鱗1);
				Are.Draw(this.X0Y0_竜性_右_鱗2);
				Are.Draw(this.X0Y0_ハイライト上左);
				Are.Draw(this.X0Y0_ハイライト上右);
				Are.Draw(this.X0Y0_ハイライト下左);
				Are.Draw(this.X0Y0_ハイライト下右);
				return;
			case 1:
				Are.Draw(this.X0Y1_ハイライト);
				Are.Draw(this.X0Y1_臍);
				Are.Draw(this.X0Y1_悪タトゥ_渦_タトゥ1左);
				Are.Draw(this.X0Y1_悪タトゥ_渦_タトゥ1右);
				Are.Draw(this.X0Y1_悪タトゥ_渦_タトゥ2左);
				Are.Draw(this.X0Y1_悪タトゥ_渦_タトゥ2右);
				Are.Draw(this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ1左);
				Are.Draw(this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ1右);
				Are.Draw(this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ2左);
				Are.Draw(this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ2右);
				Are.Draw(this.X0Y1_紋柄_紋左_紋1);
				Are.Draw(this.X0Y1_紋柄_紋左_紋2);
				Are.Draw(this.X0Y1_紋柄_紋左_紋3);
				Are.Draw(this.X0Y1_紋柄_紋右_紋1);
				Are.Draw(this.X0Y1_紋柄_紋右_紋2);
				Are.Draw(this.X0Y1_紋柄_紋右_紋3);
				Are.Draw(this.X0Y1_獣性_獣毛左);
				Are.Draw(this.X0Y1_獣性_獣毛右);
				Are.Draw(this.X0Y1_傷X左);
				Are.Draw(this.X0Y1_傷X右);
				Are.Draw(this.X0Y1_傷I左);
				Are.Draw(this.X0Y1_傷I右);
				this.キスマ\u30FCク.Draw(Are);
				this.鞭痕.Draw(Are);
				Are.Draw(this.X0Y1_虫性_甲殻2);
				Are.Draw(this.X0Y1_虫性_甲殻1);
				Are.Draw(this.X0Y1_竜性_左_鱗1);
				Are.Draw(this.X0Y1_竜性_左_鱗2);
				Are.Draw(this.X0Y1_竜性_右_鱗1);
				Are.Draw(this.X0Y1_竜性_右_鱗2);
				Are.Draw(this.X0Y1_ハイライト上左);
				Are.Draw(this.X0Y1_ハイライト上右);
				Are.Draw(this.X0Y1_ハイライト下左);
				Are.Draw(this.X0Y1_ハイライト下右);
				return;
			case 2:
				Are.Draw(this.X0Y2_ハイライト);
				Are.Draw(this.X0Y2_臍);
				Are.Draw(this.X0Y2_悪タトゥ_渦_タトゥ1左);
				Are.Draw(this.X0Y2_悪タトゥ_渦_タトゥ1右);
				Are.Draw(this.X0Y2_悪タトゥ_渦_タトゥ2左);
				Are.Draw(this.X0Y2_悪タトゥ_渦_タトゥ2右);
				Are.Draw(this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ1左);
				Are.Draw(this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ1右);
				Are.Draw(this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ2左);
				Are.Draw(this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ2右);
				Are.Draw(this.X0Y2_紋柄_紋左_紋1);
				Are.Draw(this.X0Y2_紋柄_紋左_紋2);
				Are.Draw(this.X0Y2_紋柄_紋左_紋3);
				Are.Draw(this.X0Y2_紋柄_紋右_紋1);
				Are.Draw(this.X0Y2_紋柄_紋右_紋2);
				Are.Draw(this.X0Y2_紋柄_紋右_紋3);
				Are.Draw(this.X0Y2_獣性_獣毛左);
				Are.Draw(this.X0Y2_獣性_獣毛右);
				Are.Draw(this.X0Y2_傷X左);
				Are.Draw(this.X0Y2_傷X右);
				Are.Draw(this.X0Y2_傷I左);
				Are.Draw(this.X0Y2_傷I右);
				this.キスマ\u30FCク.Draw(Are);
				this.鞭痕.Draw(Are);
				Are.Draw(this.X0Y2_虫性_甲殻2);
				Are.Draw(this.X0Y2_虫性_甲殻1);
				Are.Draw(this.X0Y2_竜性_左_鱗1);
				Are.Draw(this.X0Y2_竜性_左_鱗2);
				Are.Draw(this.X0Y2_竜性_右_鱗1);
				Are.Draw(this.X0Y2_竜性_右_鱗2);
				Are.Draw(this.X0Y2_ハイライト上左);
				Are.Draw(this.X0Y2_ハイライト上右);
				Are.Draw(this.X0Y2_ハイライト下左);
				Are.Draw(this.X0Y2_ハイライト下右);
				return;
			case 3:
				Are.Draw(this.X0Y3_ハイライト);
				Are.Draw(this.X0Y3_臍);
				Are.Draw(this.X0Y3_悪タトゥ_渦_タトゥ1左);
				Are.Draw(this.X0Y3_悪タトゥ_渦_タトゥ1右);
				Are.Draw(this.X0Y3_悪タトゥ_渦_タトゥ2左);
				Are.Draw(this.X0Y3_悪タトゥ_渦_タトゥ2右);
				Are.Draw(this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ1左);
				Are.Draw(this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ1右);
				Are.Draw(this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ2左);
				Are.Draw(this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ2右);
				Are.Draw(this.X0Y3_紋柄_紋左_紋1);
				Are.Draw(this.X0Y3_紋柄_紋左_紋2);
				Are.Draw(this.X0Y3_紋柄_紋左_紋3);
				Are.Draw(this.X0Y3_紋柄_紋右_紋1);
				Are.Draw(this.X0Y3_紋柄_紋右_紋2);
				Are.Draw(this.X0Y3_紋柄_紋右_紋3);
				Are.Draw(this.X0Y3_獣性_獣毛左);
				Are.Draw(this.X0Y3_獣性_獣毛右);
				Are.Draw(this.X0Y3_傷X左);
				Are.Draw(this.X0Y3_傷X右);
				Are.Draw(this.X0Y3_傷I左);
				Are.Draw(this.X0Y3_傷I右);
				this.キスマ\u30FCク.Draw(Are);
				this.鞭痕.Draw(Are);
				Are.Draw(this.X0Y3_虫性_甲殻2);
				Are.Draw(this.X0Y3_虫性_甲殻1);
				Are.Draw(this.X0Y3_竜性_左_鱗1);
				Are.Draw(this.X0Y3_竜性_左_鱗2);
				Are.Draw(this.X0Y3_竜性_右_鱗1);
				Are.Draw(this.X0Y3_竜性_右_鱗2);
				Are.Draw(this.X0Y3_ハイライト上左);
				Are.Draw(this.X0Y3_ハイライト上右);
				Are.Draw(this.X0Y3_ハイライト下左);
				Are.Draw(this.X0Y3_ハイライト下右);
				return;
			default:
				Are.Draw(this.X0Y4_ハイライト);
				Are.Draw(this.X0Y4_臍);
				Are.Draw(this.X0Y4_悪タトゥ_渦_タトゥ1左);
				Are.Draw(this.X0Y4_悪タトゥ_渦_タトゥ1右);
				Are.Draw(this.X0Y4_悪タトゥ_渦_タトゥ2左);
				Are.Draw(this.X0Y4_悪タトゥ_渦_タトゥ2右);
				Are.Draw(this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ1左);
				Are.Draw(this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ1右);
				Are.Draw(this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ2左);
				Are.Draw(this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ2右);
				Are.Draw(this.X0Y4_紋柄_紋左_紋1);
				Are.Draw(this.X0Y4_紋柄_紋左_紋2);
				Are.Draw(this.X0Y4_紋柄_紋左_紋3);
				Are.Draw(this.X0Y4_紋柄_紋右_紋1);
				Are.Draw(this.X0Y4_紋柄_紋右_紋2);
				Are.Draw(this.X0Y4_紋柄_紋右_紋3);
				Are.Draw(this.X0Y4_獣性_獣毛左);
				Are.Draw(this.X0Y4_獣性_獣毛右);
				Are.Draw(this.X0Y4_傷X左);
				Are.Draw(this.X0Y4_傷X右);
				Are.Draw(this.X0Y4_傷I左);
				Are.Draw(this.X0Y4_傷I右);
				this.キスマ\u30FCク.Draw(Are);
				this.鞭痕.Draw(Are);
				Are.Draw(this.X0Y4_虫性_甲殻2);
				Are.Draw(this.X0Y4_虫性_甲殻1);
				Are.Draw(this.X0Y4_竜性_左_鱗1);
				Are.Draw(this.X0Y4_竜性_左_鱗2);
				Are.Draw(this.X0Y4_竜性_右_鱗1);
				Are.Draw(this.X0Y4_竜性_右_鱗2);
				Are.Draw(this.X0Y4_ハイライト上左);
				Are.Draw(this.X0Y4_ハイライト上右);
				Are.Draw(this.X0Y4_ハイライト下左);
				Are.Draw(this.X0Y4_ハイライト下右);
				return;
			}
		}

		public JointS 胴_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_腰, 0);
			}
		}

		public JointS 腿左_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_腰, 1);
			}
		}

		public JointS 腿右_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_腰, 2);
			}
		}

		public JointS 膣基_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_腰, 4);
			}
		}

		public JointS 肛門_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_腰, 5);
			}
		}

		public JointS 尾_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_腰, 5);
			}
		}

		public JointS 半身_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_腰, 5);
			}
		}

		public JointS 上着_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_腰, 6);
			}
		}

		public JointS 肌_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_腰, 7);
			}
		}

		public JointS 翼左_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_腰, 8);
			}
		}

		public JointS 翼右_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_腰, 9);
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
				this.X0Y0_ハイライトCP.Update();
				this.X0Y0_臍CP.Update();
				this.X0Y0_悪タトゥ_渦_タトゥ1左CP.Update();
				this.X0Y0_悪タトゥ_渦_タトゥ1右CP.Update();
				this.X0Y0_悪タトゥ_渦_タトゥ2左CP.Update();
				this.X0Y0_悪タトゥ_渦_タトゥ2右CP.Update();
				this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ1左CP.Update();
				this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ1右CP.Update();
				this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ2左CP.Update();
				this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ2右CP.Update();
				this.X0Y0_傷X左CP.Update();
				this.X0Y0_傷X右CP.Update();
				this.X0Y0_傷I左CP.Update();
				this.X0Y0_傷I右CP.Update();
				this.X0Y0_紋柄_紋左_紋1CP.Update();
				this.X0Y0_紋柄_紋左_紋2CP.Update();
				this.X0Y0_紋柄_紋左_紋3CP.Update();
				this.X0Y0_紋柄_紋右_紋1CP.Update();
				this.X0Y0_紋柄_紋右_紋2CP.Update();
				this.X0Y0_紋柄_紋右_紋3CP.Update();
				this.X0Y0_獣性_獣毛左CP.Update();
				this.X0Y0_獣性_獣毛右CP.Update();
				this.X0Y0_虫性_甲殻2CP.Update();
				this.X0Y0_虫性_甲殻1CP.Update();
				this.X0Y0_竜性_左_鱗1CP.Update();
				this.X0Y0_竜性_左_鱗2CP.Update();
				this.X0Y0_竜性_右_鱗1CP.Update();
				this.X0Y0_竜性_右_鱗2CP.Update();
				this.X0Y0_ハイライト上左CP.Update();
				this.X0Y0_ハイライト上右CP.Update();
				this.X0Y0_ハイライト下左CP.Update();
				this.X0Y0_ハイライト下右CP.Update();
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
				this.X0Y1_ハイライトCP.Update();
				this.X0Y1_臍CP.Update();
				this.X0Y1_悪タトゥ_渦_タトゥ1左CP.Update();
				this.X0Y1_悪タトゥ_渦_タトゥ1右CP.Update();
				this.X0Y1_悪タトゥ_渦_タトゥ2左CP.Update();
				this.X0Y1_悪タトゥ_渦_タトゥ2右CP.Update();
				this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ1左CP.Update();
				this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ1右CP.Update();
				this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ2左CP.Update();
				this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ2右CP.Update();
				this.X0Y1_傷X左CP.Update();
				this.X0Y1_傷X右CP.Update();
				this.X0Y1_傷I左CP.Update();
				this.X0Y1_傷I右CP.Update();
				this.X0Y1_紋柄_紋左_紋1CP.Update();
				this.X0Y1_紋柄_紋左_紋2CP.Update();
				this.X0Y1_紋柄_紋左_紋3CP.Update();
				this.X0Y1_紋柄_紋右_紋1CP.Update();
				this.X0Y1_紋柄_紋右_紋2CP.Update();
				this.X0Y1_紋柄_紋右_紋3CP.Update();
				this.X0Y1_獣性_獣毛左CP.Update();
				this.X0Y1_獣性_獣毛右CP.Update();
				this.X0Y1_虫性_甲殻2CP.Update();
				this.X0Y1_虫性_甲殻1CP.Update();
				this.X0Y1_竜性_左_鱗1CP.Update();
				this.X0Y1_竜性_左_鱗2CP.Update();
				this.X0Y1_竜性_右_鱗1CP.Update();
				this.X0Y1_竜性_右_鱗2CP.Update();
				this.X0Y1_ハイライト上左CP.Update();
				this.X0Y1_ハイライト上右CP.Update();
				this.X0Y1_ハイライト下左CP.Update();
				this.X0Y1_ハイライト下右CP.Update();
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
				this.X0Y2_ハイライトCP.Update();
				this.X0Y2_臍CP.Update();
				this.X0Y2_悪タトゥ_渦_タトゥ1左CP.Update();
				this.X0Y2_悪タトゥ_渦_タトゥ1右CP.Update();
				this.X0Y2_悪タトゥ_渦_タトゥ2左CP.Update();
				this.X0Y2_悪タトゥ_渦_タトゥ2右CP.Update();
				this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ1左CP.Update();
				this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ1右CP.Update();
				this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ2左CP.Update();
				this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ2右CP.Update();
				this.X0Y2_傷X左CP.Update();
				this.X0Y2_傷X右CP.Update();
				this.X0Y2_傷I左CP.Update();
				this.X0Y2_傷I右CP.Update();
				this.X0Y2_紋柄_紋左_紋1CP.Update();
				this.X0Y2_紋柄_紋左_紋2CP.Update();
				this.X0Y2_紋柄_紋左_紋3CP.Update();
				this.X0Y2_紋柄_紋右_紋1CP.Update();
				this.X0Y2_紋柄_紋右_紋2CP.Update();
				this.X0Y2_紋柄_紋右_紋3CP.Update();
				this.X0Y2_獣性_獣毛左CP.Update();
				this.X0Y2_獣性_獣毛右CP.Update();
				this.X0Y2_虫性_甲殻2CP.Update();
				this.X0Y2_虫性_甲殻1CP.Update();
				this.X0Y2_竜性_左_鱗1CP.Update();
				this.X0Y2_竜性_左_鱗2CP.Update();
				this.X0Y2_竜性_右_鱗1CP.Update();
				this.X0Y2_竜性_右_鱗2CP.Update();
				this.X0Y2_ハイライト上左CP.Update();
				this.X0Y2_ハイライト上右CP.Update();
				this.X0Y2_ハイライト下左CP.Update();
				this.X0Y2_ハイライト下右CP.Update();
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
				this.X0Y3_ハイライトCP.Update();
				this.X0Y3_臍CP.Update();
				this.X0Y3_悪タトゥ_渦_タトゥ1左CP.Update();
				this.X0Y3_悪タトゥ_渦_タトゥ1右CP.Update();
				this.X0Y3_悪タトゥ_渦_タトゥ2左CP.Update();
				this.X0Y3_悪タトゥ_渦_タトゥ2右CP.Update();
				this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ1左CP.Update();
				this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ1右CP.Update();
				this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ2左CP.Update();
				this.X0Y3_淫タトゥ_ハ\u30FCト_タトゥ2右CP.Update();
				this.X0Y3_傷X左CP.Update();
				this.X0Y3_傷X右CP.Update();
				this.X0Y3_傷I左CP.Update();
				this.X0Y3_傷I右CP.Update();
				this.X0Y3_紋柄_紋左_紋1CP.Update();
				this.X0Y3_紋柄_紋左_紋2CP.Update();
				this.X0Y3_紋柄_紋左_紋3CP.Update();
				this.X0Y3_紋柄_紋右_紋1CP.Update();
				this.X0Y3_紋柄_紋右_紋2CP.Update();
				this.X0Y3_紋柄_紋右_紋3CP.Update();
				this.X0Y3_獣性_獣毛左CP.Update();
				this.X0Y3_獣性_獣毛右CP.Update();
				this.X0Y3_虫性_甲殻2CP.Update();
				this.X0Y3_虫性_甲殻1CP.Update();
				this.X0Y3_竜性_左_鱗1CP.Update();
				this.X0Y3_竜性_左_鱗2CP.Update();
				this.X0Y3_竜性_右_鱗1CP.Update();
				this.X0Y3_竜性_右_鱗2CP.Update();
				this.X0Y3_ハイライト上左CP.Update();
				this.X0Y3_ハイライト上右CP.Update();
				this.X0Y3_ハイライト下左CP.Update();
				this.X0Y3_ハイライト下右CP.Update();
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
				this.X0Y4_ハイライトCP.Update();
				this.X0Y4_臍CP.Update();
				this.X0Y4_悪タトゥ_渦_タトゥ1左CP.Update();
				this.X0Y4_悪タトゥ_渦_タトゥ1右CP.Update();
				this.X0Y4_悪タトゥ_渦_タトゥ2左CP.Update();
				this.X0Y4_悪タトゥ_渦_タトゥ2右CP.Update();
				this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ1左CP.Update();
				this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ1右CP.Update();
				this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ2左CP.Update();
				this.X0Y4_淫タトゥ_ハ\u30FCト_タトゥ2右CP.Update();
				this.X0Y4_傷X左CP.Update();
				this.X0Y4_傷X右CP.Update();
				this.X0Y4_傷I左CP.Update();
				this.X0Y4_傷I右CP.Update();
				this.X0Y4_紋柄_紋左_紋1CP.Update();
				this.X0Y4_紋柄_紋左_紋2CP.Update();
				this.X0Y4_紋柄_紋左_紋3CP.Update();
				this.X0Y4_紋柄_紋右_紋1CP.Update();
				this.X0Y4_紋柄_紋右_紋2CP.Update();
				this.X0Y4_紋柄_紋右_紋3CP.Update();
				this.X0Y4_獣性_獣毛左CP.Update();
				this.X0Y4_獣性_獣毛右CP.Update();
				this.X0Y4_虫性_甲殻2CP.Update();
				this.X0Y4_虫性_甲殻1CP.Update();
				this.X0Y4_竜性_左_鱗1CP.Update();
				this.X0Y4_竜性_左_鱗2CP.Update();
				this.X0Y4_竜性_右_鱗1CP.Update();
				this.X0Y4_竜性_右_鱗2CP.Update();
				this.X0Y4_ハイライト上左CP.Update();
				this.X0Y4_ハイライト上右CP.Update();
				this.X0Y4_ハイライト下左CP.Update();
				this.X0Y4_ハイライト下右CP.Update();
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
			this.腰CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.股CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌R);
			this.下腹CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.腰皺CD = new ColorD(ref 体配色.薄線, ref Color2.Empty);
			this.筋肉_筋肉下CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.筋肉_筋肉左CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.筋肉_筋肉右CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.筋肉_筋上左CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.筋肉_筋上右CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.筋肉_筋下左CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.筋肉_筋下右CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.臍CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.悪タトゥ_渦_タトゥ1左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_渦_タトゥ1右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_渦_タトゥ2左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_渦_タトゥ2右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ1左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ1右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ2左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ2右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.傷X左CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷X右CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I左CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I右CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.紋柄_紋左_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋左_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋左_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋右_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋右_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋右_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.獣性_獣毛左CD = new ColorD(ref Col.Empty, ref 体配色.毛0O);
			this.獣性_獣毛右CD = new ColorD(ref Col.Empty, ref 体配色.毛0O);
			this.虫性_甲殻2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性_甲殻1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.竜性_左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.ハイライト上左CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ハイライト上右CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ハイライト下左CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ハイライト下右CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
		}

		private void 配色T0(体配色 体配色)
		{
			this.腰CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.股CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌R);
			this.下腹CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.腰皺CD = new ColorD(ref 体配色.薄線, ref Color2.Empty);
			this.筋肉_筋肉下CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.筋肉_筋肉左CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.筋肉_筋肉右CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.筋肉_筋上左CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.筋肉_筋上右CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.筋肉_筋下左CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.筋肉_筋下右CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.臍CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.悪タトゥ_渦_タトゥ1左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_渦_タトゥ1右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_渦_タトゥ2左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_渦_タトゥ2右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ1左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ1右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ2左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ2右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.傷X左CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷X右CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I左CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I右CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.紋柄_紋左_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋左_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋左_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋右_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋右_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋右_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.獣性_獣毛左CD = new ColorD(ref Col.Empty, ref 体配色.毛0O);
			this.獣性_獣毛右CD = new ColorD(ref Col.Empty, ref 体配色.毛0O);
			this.虫性_甲殻2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性_甲殻1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.竜性_左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.ハイライト上左CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ハイライト上右CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ハイライト下左CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ハイライト下右CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
		}

		private void 配色T1(体配色 体配色)
		{
			this.腰CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.股CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌R);
			this.下腹CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.腰皺CD = new ColorD(ref 体配色.薄線, ref Color2.Empty);
			this.筋肉_筋肉下CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.筋肉_筋肉左CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.筋肉_筋肉右CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.筋肉_筋上左CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.筋肉_筋上右CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.筋肉_筋下左CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.筋肉_筋下右CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.臍CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.悪タトゥ_渦_タトゥ1左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_渦_タトゥ1右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_渦_タトゥ2左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_渦_タトゥ2右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ1左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ1右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ2左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ2右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.傷X左CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷X右CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I左CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I右CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.紋柄_紋左_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋左_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋左_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋右_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋右_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋右_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.獣性_獣毛左CD = new ColorD(ref Col.Empty, ref 体配色.毛0O);
			this.獣性_獣毛右CD = new ColorD(ref Col.Empty, ref 体配色.毛0O);
			this.虫性_甲殻2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性_甲殻1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.竜性_左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.ハイライト上左CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ハイライト上右CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ハイライト下左CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ハイライト下右CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
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

		public Par X0Y0_ハイライト;

		public Par X0Y0_臍;

		public Par X0Y0_悪タトゥ_渦_タトゥ1左;

		public Par X0Y0_悪タトゥ_渦_タトゥ1右;

		public Par X0Y0_悪タトゥ_渦_タトゥ2左;

		public Par X0Y0_悪タトゥ_渦_タトゥ2右;

		public Par X0Y0_淫タトゥ_ハ\u30FCト_タトゥ1左;

		public Par X0Y0_淫タトゥ_ハ\u30FCト_タトゥ1右;

		public Par X0Y0_淫タトゥ_ハ\u30FCト_タトゥ2左;

		public Par X0Y0_淫タトゥ_ハ\u30FCト_タトゥ2右;

		public Par X0Y0_傷X左;

		public Par X0Y0_傷X右;

		public Par X0Y0_傷I左;

		public Par X0Y0_傷I右;

		public Par X0Y0_紋柄_紋左_紋1;

		public Par X0Y0_紋柄_紋左_紋2;

		public Par X0Y0_紋柄_紋左_紋3;

		public Par X0Y0_紋柄_紋右_紋1;

		public Par X0Y0_紋柄_紋右_紋2;

		public Par X0Y0_紋柄_紋右_紋3;

		public Par X0Y0_獣性_獣毛左;

		public Par X0Y0_獣性_獣毛右;

		public Par X0Y0_虫性_甲殻2;

		public Par X0Y0_虫性_甲殻1;

		public Par X0Y0_竜性_左_鱗1;

		public Par X0Y0_竜性_左_鱗2;

		public Par X0Y0_竜性_右_鱗1;

		public Par X0Y0_竜性_右_鱗2;

		public Par X0Y0_ハイライト上左;

		public Par X0Y0_ハイライト上右;

		public Par X0Y0_ハイライト下左;

		public Par X0Y0_ハイライト下右;

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

		public Par X0Y1_ハイライト;

		public Par X0Y1_臍;

		public Par X0Y1_悪タトゥ_渦_タトゥ1左;

		public Par X0Y1_悪タトゥ_渦_タトゥ1右;

		public Par X0Y1_悪タトゥ_渦_タトゥ2左;

		public Par X0Y1_悪タトゥ_渦_タトゥ2右;

		public Par X0Y1_淫タトゥ_ハ\u30FCト_タトゥ1左;

		public Par X0Y1_淫タトゥ_ハ\u30FCト_タトゥ1右;

		public Par X0Y1_淫タトゥ_ハ\u30FCト_タトゥ2左;

		public Par X0Y1_淫タトゥ_ハ\u30FCト_タトゥ2右;

		public Par X0Y1_傷X左;

		public Par X0Y1_傷X右;

		public Par X0Y1_傷I左;

		public Par X0Y1_傷I右;

		public Par X0Y1_紋柄_紋左_紋1;

		public Par X0Y1_紋柄_紋左_紋2;

		public Par X0Y1_紋柄_紋左_紋3;

		public Par X0Y1_紋柄_紋右_紋1;

		public Par X0Y1_紋柄_紋右_紋2;

		public Par X0Y1_紋柄_紋右_紋3;

		public Par X0Y1_獣性_獣毛左;

		public Par X0Y1_獣性_獣毛右;

		public Par X0Y1_虫性_甲殻2;

		public Par X0Y1_虫性_甲殻1;

		public Par X0Y1_竜性_左_鱗1;

		public Par X0Y1_竜性_左_鱗2;

		public Par X0Y1_竜性_右_鱗1;

		public Par X0Y1_竜性_右_鱗2;

		public Par X0Y1_ハイライト上左;

		public Par X0Y1_ハイライト上右;

		public Par X0Y1_ハイライト下左;

		public Par X0Y1_ハイライト下右;

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

		public Par X0Y2_ハイライト;

		public Par X0Y2_臍;

		public Par X0Y2_悪タトゥ_渦_タトゥ1左;

		public Par X0Y2_悪タトゥ_渦_タトゥ1右;

		public Par X0Y2_悪タトゥ_渦_タトゥ2左;

		public Par X0Y2_悪タトゥ_渦_タトゥ2右;

		public Par X0Y2_淫タトゥ_ハ\u30FCト_タトゥ1左;

		public Par X0Y2_淫タトゥ_ハ\u30FCト_タトゥ1右;

		public Par X0Y2_淫タトゥ_ハ\u30FCト_タトゥ2左;

		public Par X0Y2_淫タトゥ_ハ\u30FCト_タトゥ2右;

		public Par X0Y2_傷X左;

		public Par X0Y2_傷X右;

		public Par X0Y2_傷I左;

		public Par X0Y2_傷I右;

		public Par X0Y2_紋柄_紋左_紋1;

		public Par X0Y2_紋柄_紋左_紋2;

		public Par X0Y2_紋柄_紋左_紋3;

		public Par X0Y2_紋柄_紋右_紋1;

		public Par X0Y2_紋柄_紋右_紋2;

		public Par X0Y2_紋柄_紋右_紋3;

		public Par X0Y2_獣性_獣毛左;

		public Par X0Y2_獣性_獣毛右;

		public Par X0Y2_虫性_甲殻2;

		public Par X0Y2_虫性_甲殻1;

		public Par X0Y2_竜性_左_鱗1;

		public Par X0Y2_竜性_左_鱗2;

		public Par X0Y2_竜性_右_鱗1;

		public Par X0Y2_竜性_右_鱗2;

		public Par X0Y2_ハイライト上左;

		public Par X0Y2_ハイライト上右;

		public Par X0Y2_ハイライト下左;

		public Par X0Y2_ハイライト下右;

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

		public Par X0Y3_ハイライト;

		public Par X0Y3_臍;

		public Par X0Y3_悪タトゥ_渦_タトゥ1左;

		public Par X0Y3_悪タトゥ_渦_タトゥ1右;

		public Par X0Y3_悪タトゥ_渦_タトゥ2左;

		public Par X0Y3_悪タトゥ_渦_タトゥ2右;

		public Par X0Y3_淫タトゥ_ハ\u30FCト_タトゥ1左;

		public Par X0Y3_淫タトゥ_ハ\u30FCト_タトゥ1右;

		public Par X0Y3_淫タトゥ_ハ\u30FCト_タトゥ2左;

		public Par X0Y3_淫タトゥ_ハ\u30FCト_タトゥ2右;

		public Par X0Y3_傷X左;

		public Par X0Y3_傷X右;

		public Par X0Y3_傷I左;

		public Par X0Y3_傷I右;

		public Par X0Y3_紋柄_紋左_紋1;

		public Par X0Y3_紋柄_紋左_紋2;

		public Par X0Y3_紋柄_紋左_紋3;

		public Par X0Y3_紋柄_紋右_紋1;

		public Par X0Y3_紋柄_紋右_紋2;

		public Par X0Y3_紋柄_紋右_紋3;

		public Par X0Y3_獣性_獣毛左;

		public Par X0Y3_獣性_獣毛右;

		public Par X0Y3_虫性_甲殻2;

		public Par X0Y3_虫性_甲殻1;

		public Par X0Y3_竜性_左_鱗1;

		public Par X0Y3_竜性_左_鱗2;

		public Par X0Y3_竜性_右_鱗1;

		public Par X0Y3_竜性_右_鱗2;

		public Par X0Y3_ハイライト上左;

		public Par X0Y3_ハイライト上右;

		public Par X0Y3_ハイライト下左;

		public Par X0Y3_ハイライト下右;

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

		public Par X0Y4_ハイライト;

		public Par X0Y4_臍;

		public Par X0Y4_悪タトゥ_渦_タトゥ1左;

		public Par X0Y4_悪タトゥ_渦_タトゥ1右;

		public Par X0Y4_悪タトゥ_渦_タトゥ2左;

		public Par X0Y4_悪タトゥ_渦_タトゥ2右;

		public Par X0Y4_淫タトゥ_ハ\u30FCト_タトゥ1左;

		public Par X0Y4_淫タトゥ_ハ\u30FCト_タトゥ1右;

		public Par X0Y4_淫タトゥ_ハ\u30FCト_タトゥ2左;

		public Par X0Y4_淫タトゥ_ハ\u30FCト_タトゥ2右;

		public Par X0Y4_傷X左;

		public Par X0Y4_傷X右;

		public Par X0Y4_傷I左;

		public Par X0Y4_傷I右;

		public Par X0Y4_紋柄_紋左_紋1;

		public Par X0Y4_紋柄_紋左_紋2;

		public Par X0Y4_紋柄_紋左_紋3;

		public Par X0Y4_紋柄_紋右_紋1;

		public Par X0Y4_紋柄_紋右_紋2;

		public Par X0Y4_紋柄_紋右_紋3;

		public Par X0Y4_獣性_獣毛左;

		public Par X0Y4_獣性_獣毛右;

		public Par X0Y4_虫性_甲殻2;

		public Par X0Y4_虫性_甲殻1;

		public Par X0Y4_竜性_左_鱗1;

		public Par X0Y4_竜性_左_鱗2;

		public Par X0Y4_竜性_右_鱗1;

		public Par X0Y4_竜性_右_鱗2;

		public Par X0Y4_ハイライト上左;

		public Par X0Y4_ハイライト上右;

		public Par X0Y4_ハイライト下左;

		public Par X0Y4_ハイライト下右;

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

		public ColorD ハイライトCD;

		public ColorD 臍CD;

		public ColorD 悪タトゥ_渦_タトゥ1左CD;

		public ColorD 悪タトゥ_渦_タトゥ1右CD;

		public ColorD 悪タトゥ_渦_タトゥ2左CD;

		public ColorD 悪タトゥ_渦_タトゥ2右CD;

		public ColorD 淫タトゥ_ハ\u30FCト_タトゥ1左CD;

		public ColorD 淫タトゥ_ハ\u30FCト_タトゥ1右CD;

		public ColorD 淫タトゥ_ハ\u30FCト_タトゥ2左CD;

		public ColorD 淫タトゥ_ハ\u30FCト_タトゥ2右CD;

		public ColorD 傷X左CD;

		public ColorD 傷X右CD;

		public ColorD 傷I左CD;

		public ColorD 傷I右CD;

		public ColorD 紋柄_紋左_紋1CD;

		public ColorD 紋柄_紋左_紋2CD;

		public ColorD 紋柄_紋左_紋3CD;

		public ColorD 紋柄_紋右_紋1CD;

		public ColorD 紋柄_紋右_紋2CD;

		public ColorD 紋柄_紋右_紋3CD;

		public ColorD 獣性_獣毛左CD;

		public ColorD 獣性_獣毛右CD;

		public ColorD 虫性_甲殻2CD;

		public ColorD 虫性_甲殻1CD;

		public ColorD 竜性_左_鱗1CD;

		public ColorD 竜性_左_鱗2CD;

		public ColorD 竜性_右_鱗1CD;

		public ColorD 竜性_右_鱗2CD;

		public ColorD ハイライト上左CD;

		public ColorD ハイライト上右CD;

		public ColorD ハイライト下左CD;

		public ColorD ハイライト下右CD;

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

		public ColorP X0Y0_ハイライトCP;

		public ColorP X0Y0_臍CP;

		public ColorP X0Y0_悪タトゥ_渦_タトゥ1左CP;

		public ColorP X0Y0_悪タトゥ_渦_タトゥ1右CP;

		public ColorP X0Y0_悪タトゥ_渦_タトゥ2左CP;

		public ColorP X0Y0_悪タトゥ_渦_タトゥ2右CP;

		public ColorP X0Y0_淫タトゥ_ハ\u30FCト_タトゥ1左CP;

		public ColorP X0Y0_淫タトゥ_ハ\u30FCト_タトゥ1右CP;

		public ColorP X0Y0_淫タトゥ_ハ\u30FCト_タトゥ2左CP;

		public ColorP X0Y0_淫タトゥ_ハ\u30FCト_タトゥ2右CP;

		public ColorP X0Y0_傷X左CP;

		public ColorP X0Y0_傷X右CP;

		public ColorP X0Y0_傷I左CP;

		public ColorP X0Y0_傷I右CP;

		public ColorP X0Y0_紋柄_紋左_紋1CP;

		public ColorP X0Y0_紋柄_紋左_紋2CP;

		public ColorP X0Y0_紋柄_紋左_紋3CP;

		public ColorP X0Y0_紋柄_紋右_紋1CP;

		public ColorP X0Y0_紋柄_紋右_紋2CP;

		public ColorP X0Y0_紋柄_紋右_紋3CP;

		public ColorP X0Y0_獣性_獣毛左CP;

		public ColorP X0Y0_獣性_獣毛右CP;

		public ColorP X0Y0_虫性_甲殻2CP;

		public ColorP X0Y0_虫性_甲殻1CP;

		public ColorP X0Y0_竜性_左_鱗1CP;

		public ColorP X0Y0_竜性_左_鱗2CP;

		public ColorP X0Y0_竜性_右_鱗1CP;

		public ColorP X0Y0_竜性_右_鱗2CP;

		public ColorP X0Y0_ハイライト上左CP;

		public ColorP X0Y0_ハイライト上右CP;

		public ColorP X0Y0_ハイライト下左CP;

		public ColorP X0Y0_ハイライト下右CP;

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

		public ColorP X0Y1_ハイライトCP;

		public ColorP X0Y1_臍CP;

		public ColorP X0Y1_悪タトゥ_渦_タトゥ1左CP;

		public ColorP X0Y1_悪タトゥ_渦_タトゥ1右CP;

		public ColorP X0Y1_悪タトゥ_渦_タトゥ2左CP;

		public ColorP X0Y1_悪タトゥ_渦_タトゥ2右CP;

		public ColorP X0Y1_淫タトゥ_ハ\u30FCト_タトゥ1左CP;

		public ColorP X0Y1_淫タトゥ_ハ\u30FCト_タトゥ1右CP;

		public ColorP X0Y1_淫タトゥ_ハ\u30FCト_タトゥ2左CP;

		public ColorP X0Y1_淫タトゥ_ハ\u30FCト_タトゥ2右CP;

		public ColorP X0Y1_傷X左CP;

		public ColorP X0Y1_傷X右CP;

		public ColorP X0Y1_傷I左CP;

		public ColorP X0Y1_傷I右CP;

		public ColorP X0Y1_紋柄_紋左_紋1CP;

		public ColorP X0Y1_紋柄_紋左_紋2CP;

		public ColorP X0Y1_紋柄_紋左_紋3CP;

		public ColorP X0Y1_紋柄_紋右_紋1CP;

		public ColorP X0Y1_紋柄_紋右_紋2CP;

		public ColorP X0Y1_紋柄_紋右_紋3CP;

		public ColorP X0Y1_獣性_獣毛左CP;

		public ColorP X0Y1_獣性_獣毛右CP;

		public ColorP X0Y1_虫性_甲殻2CP;

		public ColorP X0Y1_虫性_甲殻1CP;

		public ColorP X0Y1_竜性_左_鱗1CP;

		public ColorP X0Y1_竜性_左_鱗2CP;

		public ColorP X0Y1_竜性_右_鱗1CP;

		public ColorP X0Y1_竜性_右_鱗2CP;

		public ColorP X0Y1_ハイライト上左CP;

		public ColorP X0Y1_ハイライト上右CP;

		public ColorP X0Y1_ハイライト下左CP;

		public ColorP X0Y1_ハイライト下右CP;

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

		public ColorP X0Y2_ハイライトCP;

		public ColorP X0Y2_臍CP;

		public ColorP X0Y2_悪タトゥ_渦_タトゥ1左CP;

		public ColorP X0Y2_悪タトゥ_渦_タトゥ1右CP;

		public ColorP X0Y2_悪タトゥ_渦_タトゥ2左CP;

		public ColorP X0Y2_悪タトゥ_渦_タトゥ2右CP;

		public ColorP X0Y2_淫タトゥ_ハ\u30FCト_タトゥ1左CP;

		public ColorP X0Y2_淫タトゥ_ハ\u30FCト_タトゥ1右CP;

		public ColorP X0Y2_淫タトゥ_ハ\u30FCト_タトゥ2左CP;

		public ColorP X0Y2_淫タトゥ_ハ\u30FCト_タトゥ2右CP;

		public ColorP X0Y2_傷X左CP;

		public ColorP X0Y2_傷X右CP;

		public ColorP X0Y2_傷I左CP;

		public ColorP X0Y2_傷I右CP;

		public ColorP X0Y2_紋柄_紋左_紋1CP;

		public ColorP X0Y2_紋柄_紋左_紋2CP;

		public ColorP X0Y2_紋柄_紋左_紋3CP;

		public ColorP X0Y2_紋柄_紋右_紋1CP;

		public ColorP X0Y2_紋柄_紋右_紋2CP;

		public ColorP X0Y2_紋柄_紋右_紋3CP;

		public ColorP X0Y2_獣性_獣毛左CP;

		public ColorP X0Y2_獣性_獣毛右CP;

		public ColorP X0Y2_虫性_甲殻2CP;

		public ColorP X0Y2_虫性_甲殻1CP;

		public ColorP X0Y2_竜性_左_鱗1CP;

		public ColorP X0Y2_竜性_左_鱗2CP;

		public ColorP X0Y2_竜性_右_鱗1CP;

		public ColorP X0Y2_竜性_右_鱗2CP;

		public ColorP X0Y2_ハイライト上左CP;

		public ColorP X0Y2_ハイライト上右CP;

		public ColorP X0Y2_ハイライト下左CP;

		public ColorP X0Y2_ハイライト下右CP;

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

		public ColorP X0Y3_ハイライトCP;

		public ColorP X0Y3_臍CP;

		public ColorP X0Y3_悪タトゥ_渦_タトゥ1左CP;

		public ColorP X0Y3_悪タトゥ_渦_タトゥ1右CP;

		public ColorP X0Y3_悪タトゥ_渦_タトゥ2左CP;

		public ColorP X0Y3_悪タトゥ_渦_タトゥ2右CP;

		public ColorP X0Y3_淫タトゥ_ハ\u30FCト_タトゥ1左CP;

		public ColorP X0Y3_淫タトゥ_ハ\u30FCト_タトゥ1右CP;

		public ColorP X0Y3_淫タトゥ_ハ\u30FCト_タトゥ2左CP;

		public ColorP X0Y3_淫タトゥ_ハ\u30FCト_タトゥ2右CP;

		public ColorP X0Y3_傷X左CP;

		public ColorP X0Y3_傷X右CP;

		public ColorP X0Y3_傷I左CP;

		public ColorP X0Y3_傷I右CP;

		public ColorP X0Y3_紋柄_紋左_紋1CP;

		public ColorP X0Y3_紋柄_紋左_紋2CP;

		public ColorP X0Y3_紋柄_紋左_紋3CP;

		public ColorP X0Y3_紋柄_紋右_紋1CP;

		public ColorP X0Y3_紋柄_紋右_紋2CP;

		public ColorP X0Y3_紋柄_紋右_紋3CP;

		public ColorP X0Y3_獣性_獣毛左CP;

		public ColorP X0Y3_獣性_獣毛右CP;

		public ColorP X0Y3_虫性_甲殻2CP;

		public ColorP X0Y3_虫性_甲殻1CP;

		public ColorP X0Y3_竜性_左_鱗1CP;

		public ColorP X0Y3_竜性_左_鱗2CP;

		public ColorP X0Y3_竜性_右_鱗1CP;

		public ColorP X0Y3_竜性_右_鱗2CP;

		public ColorP X0Y3_ハイライト上左CP;

		public ColorP X0Y3_ハイライト上右CP;

		public ColorP X0Y3_ハイライト下左CP;

		public ColorP X0Y3_ハイライト下右CP;

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

		public ColorP X0Y4_ハイライトCP;

		public ColorP X0Y4_臍CP;

		public ColorP X0Y4_悪タトゥ_渦_タトゥ1左CP;

		public ColorP X0Y4_悪タトゥ_渦_タトゥ1右CP;

		public ColorP X0Y4_悪タトゥ_渦_タトゥ2左CP;

		public ColorP X0Y4_悪タトゥ_渦_タトゥ2右CP;

		public ColorP X0Y4_淫タトゥ_ハ\u30FCト_タトゥ1左CP;

		public ColorP X0Y4_淫タトゥ_ハ\u30FCト_タトゥ1右CP;

		public ColorP X0Y4_淫タトゥ_ハ\u30FCト_タトゥ2左CP;

		public ColorP X0Y4_淫タトゥ_ハ\u30FCト_タトゥ2右CP;

		public ColorP X0Y4_傷X左CP;

		public ColorP X0Y4_傷X右CP;

		public ColorP X0Y4_傷I左CP;

		public ColorP X0Y4_傷I右CP;

		public ColorP X0Y4_紋柄_紋左_紋1CP;

		public ColorP X0Y4_紋柄_紋左_紋2CP;

		public ColorP X0Y4_紋柄_紋左_紋3CP;

		public ColorP X0Y4_紋柄_紋右_紋1CP;

		public ColorP X0Y4_紋柄_紋右_紋2CP;

		public ColorP X0Y4_紋柄_紋右_紋3CP;

		public ColorP X0Y4_獣性_獣毛左CP;

		public ColorP X0Y4_獣性_獣毛右CP;

		public ColorP X0Y4_虫性_甲殻2CP;

		public ColorP X0Y4_虫性_甲殻1CP;

		public ColorP X0Y4_竜性_左_鱗1CP;

		public ColorP X0Y4_竜性_左_鱗2CP;

		public ColorP X0Y4_竜性_右_鱗1CP;

		public ColorP X0Y4_竜性_右_鱗2CP;

		public ColorP X0Y4_ハイライト上左CP;

		public ColorP X0Y4_ハイライト上右CP;

		public ColorP X0Y4_ハイライト下左CP;

		public ColorP X0Y4_ハイライト下右CP;

		public スタンプK キスマ\u30FCク;

		public スタンプW 鞭痕;

		public Ele[] 胴_接続;

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
