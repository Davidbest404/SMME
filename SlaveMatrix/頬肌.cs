using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 頬肌 : Ele
	{
		public 頬肌(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 頬肌D e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.胴体["頬肌左"]);
			Pars pars = this.本体[0][0];
			Pars pars2 = pars["淫タトゥ"].ToPars();
			Pars pars3 = pars2["ハート"].ToPars();
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左 = pars3["タトゥ左"].ToPar();
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右 = pars3["タトゥ右"].ToPar();
			pars2 = pars["隈取"].ToPars();
			this.X0Y0_隈取_タトゥ1 = pars2["タトゥ1"].ToPar();
			this.X0Y0_隈取_タトゥ2 = pars2["タトゥ2"].ToPar();
			pars2 = pars["紋柄"].ToPars();
			this.X0Y0_紋柄_紋1 = pars2["紋1"].ToPar();
			this.X0Y0_紋柄_紋2 = pars2["紋2"].ToPar();
			this.X0Y0_紋柄_紋3 = pars2["紋3"].ToPar();
			pars2 = pars["傷"].ToPars();
			this.X0Y0_傷_傷X = pars2["傷X"].ToPar();
			this.X0Y0_傷_傷I1 = pars2["傷I1"].ToPar();
			this.X0Y0_傷_傷I2 = pars2["傷I2"].ToPar();
			this.X0Y0_傷_傷I3 = pars2["傷I3"].ToPar();
			pars2 = pars["蜘蛛"].ToPars();
			pars3 = pars2["眼"].ToPars();
			this.X0Y0_蜘蛛_眼_基 = pars3["基"].ToPar();
			this.X0Y0_蜘蛛_眼_眼 = pars3["眼"].ToPar();
			this.X0Y0_蜘蛛_眼_ハイライト = pars3["ハイライト"].ToPar();
			pars2 = pars["百足"].ToPars();
			pars3 = pars2["眼1"].ToPars();
			this.X0Y0_百足_眼1_基 = pars3["基"].ToPar();
			this.X0Y0_百足_眼1_眼 = pars3["眼"].ToPar();
			this.X0Y0_百足_眼1_ハイライト = pars3["ハイライト"].ToPar();
			pars3 = pars2["眼2"].ToPars();
			this.X0Y0_百足_眼2_基 = pars3["基"].ToPar();
			this.X0Y0_百足_眼2_眼 = pars3["眼"].ToPar();
			this.X0Y0_百足_眼2_ハイライト = pars3["ハイライト"].ToPar();
			pars3 = pars2["眼3"].ToPars();
			this.X0Y0_百足_眼3_基 = pars3["基"].ToPar();
			this.X0Y0_百足_眼3_眼 = pars3["眼"].ToPar();
			this.X0Y0_百足_眼3_ハイライト = pars3["ハイライト"].ToPar();
			pars2 = pars["獣性"].ToPars();
			this.X0Y0_獣性_獣毛 = pars2["獣毛"].ToPar();
			pars2 = pars["髭"].ToPars();
			this.X0Y0_獣性_髭1 = pars2["髭1"].ToPar();
			this.X0Y0_獣性_髭2 = pars2["髭2"].ToPar();
			this.X0Y0_獣性_髭3 = pars2["髭3"].ToPar();
			pars2 = pars["鱗"].ToPars();
			this.X0Y0_竜性_鱗1 = pars2["鱗1"].ToPar();
			this.X0Y0_竜性_鱗2 = pars2["鱗2"].ToPar();
			this.X0Y0_竜性_鱗3 = pars2["鱗3"].ToPar();
			pars2 = pars["猟豹"].ToPars();
			this.X0Y0_猟豹_タトゥ = pars2["タトゥ"].ToPar();
			pars2 = pars["牛柄"].ToPars();
			this.X0Y0_牛柄_牛柄 = pars2["牛柄"].ToPar();
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
			this.淫タトゥ_ハ\u30FCト_タトゥ左_表示 = e.淫タトゥ_ハ\u30FCト_タトゥ左_表示;
			this.淫タトゥ_ハ\u30FCト_タトゥ右_表示 = e.淫タトゥ_ハ\u30FCト_タトゥ右_表示;
			this.隈取_タトゥ1_表示 = e.隈取_タトゥ1_表示;
			this.隈取_タトゥ2_表示 = e.隈取_タトゥ2_表示;
			this.紋柄_紋1_表示 = e.紋柄_紋1_表示;
			this.紋柄_紋2_表示 = e.紋柄_紋2_表示;
			this.紋柄_紋3_表示 = e.紋柄_紋3_表示;
			this.傷_傷X_表示 = e.傷_傷X_表示;
			this.傷_傷I1_表示 = e.傷_傷I1_表示;
			this.傷_傷I2_表示 = e.傷_傷I2_表示;
			this.傷_傷I3_表示 = e.傷_傷I3_表示;
			this.蜘蛛_眼_基_表示 = e.蜘蛛_眼_基_表示;
			this.蜘蛛_眼_眼_表示 = e.蜘蛛_眼_眼_表示;
			this.蜘蛛_眼_ハイライト_表示 = e.蜘蛛_眼_ハイライト_表示;
			this.百足_眼1_基_表示 = e.百足_眼1_基_表示;
			this.百足_眼1_眼_表示 = e.百足_眼1_眼_表示;
			this.百足_眼1_ハイライト_表示 = e.百足_眼1_ハイライト_表示;
			this.百足_眼2_基_表示 = e.百足_眼2_基_表示;
			this.百足_眼2_眼_表示 = e.百足_眼2_眼_表示;
			this.百足_眼2_ハイライト_表示 = e.百足_眼2_ハイライト_表示;
			this.百足_眼3_基_表示 = e.百足_眼3_基_表示;
			this.百足_眼3_眼_表示 = e.百足_眼3_眼_表示;
			this.百足_眼3_ハイライト_表示 = e.百足_眼3_ハイライト_表示;
			this.獣性_獣毛_表示 = e.獣性_獣毛_表示;
			this.獣性_髭1_表示 = e.獣性_髭1_表示;
			this.獣性_髭2_表示 = e.獣性_髭2_表示;
			this.獣性_髭3_表示 = e.獣性_髭3_表示;
			this.竜性_鱗1_表示 = e.竜性_鱗1_表示;
			this.竜性_鱗2_表示 = e.竜性_鱗2_表示;
			this.竜性_鱗3_表示 = e.竜性_鱗3_表示;
			this.猟豹_タトゥ_表示 = e.猟豹_タトゥ_表示;
			this.牛柄_牛柄_表示 = e.牛柄_牛柄_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左CP = new ColorP(this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左, this.淫タトゥ_ハ\u30FCト_タトゥ左CD, DisUnit, true);
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右CP = new ColorP(this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右, this.淫タトゥ_ハ\u30FCト_タトゥ右CD, DisUnit, true);
			this.X0Y0_隈取_タトゥ1CP = new ColorP(this.X0Y0_隈取_タトゥ1, this.隈取_タトゥ1CD, DisUnit, true);
			this.X0Y0_隈取_タトゥ2CP = new ColorP(this.X0Y0_隈取_タトゥ2, this.隈取_タトゥ2CD, DisUnit, true);
			this.X0Y0_紋柄_紋1CP = new ColorP(this.X0Y0_紋柄_紋1, this.紋柄_紋1CD, DisUnit, true);
			this.X0Y0_紋柄_紋2CP = new ColorP(this.X0Y0_紋柄_紋2, this.紋柄_紋2CD, DisUnit, true);
			this.X0Y0_紋柄_紋3CP = new ColorP(this.X0Y0_紋柄_紋3, this.紋柄_紋3CD, DisUnit, true);
			this.X0Y0_傷_傷XCP = new ColorP(this.X0Y0_傷_傷X, this.傷_傷XCD, DisUnit, true);
			this.X0Y0_傷_傷I1CP = new ColorP(this.X0Y0_傷_傷I1, this.傷_傷I1CD, DisUnit, true);
			this.X0Y0_傷_傷I2CP = new ColorP(this.X0Y0_傷_傷I2, this.傷_傷I2CD, DisUnit, true);
			this.X0Y0_傷_傷I3CP = new ColorP(this.X0Y0_傷_傷I3, this.傷_傷I3CD, DisUnit, true);
			this.X0Y0_蜘蛛_眼_基CP = new ColorP(this.X0Y0_蜘蛛_眼_基, this.蜘蛛_眼_基CD, DisUnit, true);
			this.X0Y0_蜘蛛_眼_眼CP = new ColorP(this.X0Y0_蜘蛛_眼_眼, this.蜘蛛_眼_眼CD, DisUnit, true);
			this.X0Y0_蜘蛛_眼_ハイライトCP = new ColorP(this.X0Y0_蜘蛛_眼_ハイライト, this.蜘蛛_眼_ハイライトCD, DisUnit, true);
			this.X0Y0_百足_眼1_基CP = new ColorP(this.X0Y0_百足_眼1_基, this.百足_眼1_基CD, DisUnit, true);
			this.X0Y0_百足_眼1_眼CP = new ColorP(this.X0Y0_百足_眼1_眼, this.百足_眼1_眼CD, DisUnit, true);
			this.X0Y0_百足_眼1_ハイライトCP = new ColorP(this.X0Y0_百足_眼1_ハイライト, this.百足_眼1_ハイライトCD, DisUnit, true);
			this.X0Y0_百足_眼2_基CP = new ColorP(this.X0Y0_百足_眼2_基, this.百足_眼2_基CD, DisUnit, true);
			this.X0Y0_百足_眼2_眼CP = new ColorP(this.X0Y0_百足_眼2_眼, this.百足_眼2_眼CD, DisUnit, true);
			this.X0Y0_百足_眼2_ハイライトCP = new ColorP(this.X0Y0_百足_眼2_ハイライト, this.百足_眼2_ハイライトCD, DisUnit, true);
			this.X0Y0_百足_眼3_基CP = new ColorP(this.X0Y0_百足_眼3_基, this.百足_眼3_基CD, DisUnit, true);
			this.X0Y0_百足_眼3_眼CP = new ColorP(this.X0Y0_百足_眼3_眼, this.百足_眼3_眼CD, DisUnit, true);
			this.X0Y0_百足_眼3_ハイライトCP = new ColorP(this.X0Y0_百足_眼3_ハイライト, this.百足_眼3_ハイライトCD, DisUnit, true);
			this.X0Y0_獣性_獣毛CP = new ColorP(this.X0Y0_獣性_獣毛, this.獣性_獣毛CD, DisUnit, true);
			this.X0Y0_獣性_髭1CP = new ColorP(this.X0Y0_獣性_髭1, this.獣性_髭1CD, DisUnit, true);
			this.X0Y0_獣性_髭2CP = new ColorP(this.X0Y0_獣性_髭2, this.獣性_髭2CD, DisUnit, true);
			this.X0Y0_獣性_髭3CP = new ColorP(this.X0Y0_獣性_髭3, this.獣性_髭3CD, DisUnit, true);
			this.X0Y0_竜性_鱗1CP = new ColorP(this.X0Y0_竜性_鱗1, this.竜性_鱗1CD, DisUnit, true);
			this.X0Y0_竜性_鱗2CP = new ColorP(this.X0Y0_竜性_鱗2, this.竜性_鱗2CD, DisUnit, true);
			this.X0Y0_竜性_鱗3CP = new ColorP(this.X0Y0_竜性_鱗3, this.竜性_鱗3CD, DisUnit, true);
			this.X0Y0_猟豹_タトゥCP = new ColorP(this.X0Y0_猟豹_タトゥ, this.猟豹_タトゥCD, DisUnit, true);
			this.X0Y0_牛柄_牛柄CP = new ColorP(this.X0Y0_牛柄_牛柄, this.牛柄_牛柄CD, DisUnit, true);
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

		public bool 淫タトゥ_ハ\u30FCト_タトゥ左_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左.Dra = value;
				this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左.Hit = value;
			}
		}

		public bool 淫タトゥ_ハ\u30FCト_タトゥ右_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右.Dra = value;
				this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右.Hit = value;
			}
		}

		public bool 隈取_タトゥ1_表示
		{
			get
			{
				return this.X0Y0_隈取_タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_隈取_タトゥ1.Dra = value;
				this.X0Y0_隈取_タトゥ1.Hit = value;
			}
		}

		public bool 隈取_タトゥ2_表示
		{
			get
			{
				return this.X0Y0_隈取_タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_隈取_タトゥ2.Dra = value;
				this.X0Y0_隈取_タトゥ2.Hit = value;
			}
		}

		public bool 紋柄_紋1_表示
		{
			get
			{
				return this.X0Y0_紋柄_紋1.Dra;
			}
			set
			{
				this.X0Y0_紋柄_紋1.Dra = value;
				this.X0Y0_紋柄_紋1.Hit = value;
			}
		}

		public bool 紋柄_紋2_表示
		{
			get
			{
				return this.X0Y0_紋柄_紋2.Dra;
			}
			set
			{
				this.X0Y0_紋柄_紋2.Dra = value;
				this.X0Y0_紋柄_紋2.Hit = value;
			}
		}

		public bool 紋柄_紋3_表示
		{
			get
			{
				return this.X0Y0_紋柄_紋3.Dra;
			}
			set
			{
				this.X0Y0_紋柄_紋3.Dra = value;
				this.X0Y0_紋柄_紋3.Hit = value;
			}
		}

		public bool 傷_傷X_表示
		{
			get
			{
				return this.X0Y0_傷_傷X.Dra;
			}
			set
			{
				this.X0Y0_傷_傷X.Dra = value;
				this.X0Y0_傷_傷X.Hit = value;
			}
		}

		public bool 傷_傷I1_表示
		{
			get
			{
				return this.X0Y0_傷_傷I1.Dra;
			}
			set
			{
				this.X0Y0_傷_傷I1.Dra = value;
				this.X0Y0_傷_傷I1.Hit = value;
			}
		}

		public bool 傷_傷I2_表示
		{
			get
			{
				return this.X0Y0_傷_傷I2.Dra;
			}
			set
			{
				this.X0Y0_傷_傷I2.Dra = value;
				this.X0Y0_傷_傷I2.Hit = value;
			}
		}

		public bool 傷_傷I3_表示
		{
			get
			{
				return this.X0Y0_傷_傷I3.Dra;
			}
			set
			{
				this.X0Y0_傷_傷I3.Dra = value;
				this.X0Y0_傷_傷I3.Hit = value;
			}
		}

		public bool 蜘蛛_眼_基_表示
		{
			get
			{
				return this.X0Y0_蜘蛛_眼_基.Dra;
			}
			set
			{
				this.X0Y0_蜘蛛_眼_基.Dra = value;
				this.X0Y0_蜘蛛_眼_基.Hit = value;
			}
		}

		public bool 蜘蛛_眼_眼_表示
		{
			get
			{
				return this.X0Y0_蜘蛛_眼_眼.Dra;
			}
			set
			{
				this.X0Y0_蜘蛛_眼_眼.Dra = value;
				this.X0Y0_蜘蛛_眼_眼.Hit = value;
			}
		}

		public bool 蜘蛛_眼_ハイライト_表示
		{
			get
			{
				return this.X0Y0_蜘蛛_眼_ハイライト.Dra;
			}
			set
			{
				this.X0Y0_蜘蛛_眼_ハイライト.Dra = value;
				this.X0Y0_蜘蛛_眼_ハイライト.Hit = value;
			}
		}

		public bool 百足_眼1_基_表示
		{
			get
			{
				return this.X0Y0_百足_眼1_基.Dra;
			}
			set
			{
				this.X0Y0_百足_眼1_基.Dra = value;
				this.X0Y0_百足_眼1_基.Hit = value;
			}
		}

		public bool 百足_眼1_眼_表示
		{
			get
			{
				return this.X0Y0_百足_眼1_眼.Dra;
			}
			set
			{
				this.X0Y0_百足_眼1_眼.Dra = value;
				this.X0Y0_百足_眼1_眼.Hit = value;
			}
		}

		public bool 百足_眼1_ハイライト_表示
		{
			get
			{
				return this.X0Y0_百足_眼1_ハイライト.Dra;
			}
			set
			{
				this.X0Y0_百足_眼1_ハイライト.Dra = value;
				this.X0Y0_百足_眼1_ハイライト.Hit = value;
			}
		}

		public bool 百足_眼2_基_表示
		{
			get
			{
				return this.X0Y0_百足_眼2_基.Dra;
			}
			set
			{
				this.X0Y0_百足_眼2_基.Dra = value;
				this.X0Y0_百足_眼2_基.Hit = value;
			}
		}

		public bool 百足_眼2_眼_表示
		{
			get
			{
				return this.X0Y0_百足_眼2_眼.Dra;
			}
			set
			{
				this.X0Y0_百足_眼2_眼.Dra = value;
				this.X0Y0_百足_眼2_眼.Hit = value;
			}
		}

		public bool 百足_眼2_ハイライト_表示
		{
			get
			{
				return this.X0Y0_百足_眼2_ハイライト.Dra;
			}
			set
			{
				this.X0Y0_百足_眼2_ハイライト.Dra = value;
				this.X0Y0_百足_眼2_ハイライト.Hit = value;
			}
		}

		public bool 百足_眼3_基_表示
		{
			get
			{
				return this.X0Y0_百足_眼3_基.Dra;
			}
			set
			{
				this.X0Y0_百足_眼3_基.Dra = value;
				this.X0Y0_百足_眼3_基.Hit = value;
			}
		}

		public bool 百足_眼3_眼_表示
		{
			get
			{
				return this.X0Y0_百足_眼3_眼.Dra;
			}
			set
			{
				this.X0Y0_百足_眼3_眼.Dra = value;
				this.X0Y0_百足_眼3_眼.Hit = value;
			}
		}

		public bool 百足_眼3_ハイライト_表示
		{
			get
			{
				return this.X0Y0_百足_眼3_ハイライト.Dra;
			}
			set
			{
				this.X0Y0_百足_眼3_ハイライト.Dra = value;
				this.X0Y0_百足_眼3_ハイライト.Hit = value;
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
				this.X0Y0_獣性_獣毛.Hit = value;
			}
		}

		public bool 獣性_髭1_表示
		{
			get
			{
				return this.X0Y0_獣性_髭1.Dra;
			}
			set
			{
				this.X0Y0_獣性_髭1.Dra = value;
				this.X0Y0_獣性_髭1.Hit = value;
			}
		}

		public bool 獣性_髭2_表示
		{
			get
			{
				return this.X0Y0_獣性_髭2.Dra;
			}
			set
			{
				this.X0Y0_獣性_髭2.Dra = value;
				this.X0Y0_獣性_髭2.Hit = value;
			}
		}

		public bool 獣性_髭3_表示
		{
			get
			{
				return this.X0Y0_獣性_髭3.Dra;
			}
			set
			{
				this.X0Y0_獣性_髭3.Dra = value;
				this.X0Y0_獣性_髭3.Hit = value;
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
				this.X0Y0_竜性_鱗1.Hit = value;
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
				this.X0Y0_竜性_鱗2.Hit = value;
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
				this.X0Y0_竜性_鱗3.Hit = value;
			}
		}

		public bool 猟豹_タトゥ_表示
		{
			get
			{
				return this.X0Y0_猟豹_タトゥ.Dra;
			}
			set
			{
				this.X0Y0_猟豹_タトゥ.Dra = value;
				this.X0Y0_猟豹_タトゥ.Hit = value;
			}
		}

		public bool 牛柄_牛柄_表示
		{
			get
			{
				return this.X0Y0_牛柄_牛柄.Dra;
			}
			set
			{
				this.X0Y0_牛柄_牛柄.Dra = value;
				this.X0Y0_牛柄_牛柄.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.淫タトゥ_ハ\u30FCト_タトゥ左_表示;
			}
			set
			{
				this.淫タトゥ_ハ\u30FCト_タトゥ左_表示 = value;
				this.淫タトゥ_ハ\u30FCト_タトゥ右_表示 = value;
				this.隈取_タトゥ1_表示 = value;
				this.隈取_タトゥ2_表示 = value;
				this.紋柄_紋1_表示 = value;
				this.紋柄_紋2_表示 = value;
				this.紋柄_紋3_表示 = value;
				this.傷_傷X_表示 = value;
				this.傷_傷I1_表示 = value;
				this.傷_傷I2_表示 = value;
				this.傷_傷I3_表示 = value;
				this.蜘蛛_眼_基_表示 = value;
				this.蜘蛛_眼_眼_表示 = value;
				this.蜘蛛_眼_ハイライト_表示 = value;
				this.百足_眼1_基_表示 = value;
				this.百足_眼1_眼_表示 = value;
				this.百足_眼1_ハイライト_表示 = value;
				this.百足_眼2_基_表示 = value;
				this.百足_眼2_眼_表示 = value;
				this.百足_眼2_ハイライト_表示 = value;
				this.百足_眼3_基_表示 = value;
				this.百足_眼3_眼_表示 = value;
				this.百足_眼3_ハイライト_表示 = value;
				this.獣性_獣毛_表示 = value;
				this.獣性_髭1_表示 = value;
				this.獣性_髭2_表示 = value;
				this.獣性_髭3_表示 = value;
				this.竜性_鱗1_表示 = value;
				this.竜性_鱗2_表示 = value;
				this.竜性_鱗3_表示 = value;
				this.猟豹_タトゥ_表示 = value;
				this.牛柄_牛柄_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.淫タトゥ_ハ\u30FCト_タトゥ左CD.不透明度;
			}
			set
			{
				this.淫タトゥ_ハ\u30FCト_タトゥ左CD.不透明度 = value;
				this.淫タトゥ_ハ\u30FCト_タトゥ右CD.不透明度 = value;
				this.隈取_タトゥ1CD.不透明度 = value;
				this.隈取_タトゥ2CD.不透明度 = value;
				this.紋柄_紋1CD.不透明度 = value;
				this.紋柄_紋2CD.不透明度 = value;
				this.紋柄_紋3CD.不透明度 = value;
				this.傷_傷XCD.不透明度 = value;
				this.傷_傷I1CD.不透明度 = value;
				this.傷_傷I2CD.不透明度 = value;
				this.傷_傷I3CD.不透明度 = value;
				this.蜘蛛_眼_基CD.不透明度 = value;
				this.蜘蛛_眼_眼CD.不透明度 = value;
				this.蜘蛛_眼_ハイライトCD.不透明度 = value;
				this.百足_眼1_基CD.不透明度 = value;
				this.百足_眼1_眼CD.不透明度 = value;
				this.百足_眼1_ハイライトCD.不透明度 = value;
				this.百足_眼2_基CD.不透明度 = value;
				this.百足_眼2_眼CD.不透明度 = value;
				this.百足_眼2_ハイライトCD.不透明度 = value;
				this.百足_眼3_基CD.不透明度 = value;
				this.百足_眼3_眼CD.不透明度 = value;
				this.百足_眼3_ハイライトCD.不透明度 = value;
				this.獣性_獣毛CD.不透明度 = value;
				this.獣性_髭1CD.不透明度 = value;
				this.獣性_髭2CD.不透明度 = value;
				this.獣性_髭3CD.不透明度 = value;
				this.竜性_鱗1CD.不透明度 = value;
				this.竜性_鱗2CD.不透明度 = value;
				this.竜性_鱗3CD.不透明度 = value;
				this.猟豹_タトゥCD.不透明度 = value;
				this.牛柄_牛柄CD.不透明度 = value;
			}
		}

		public override void 描画0(Are Are)
		{
			Are.Draw(this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左);
			Are.Draw(this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右);
			Are.Draw(this.X0Y0_隈取_タトゥ1);
			Are.Draw(this.X0Y0_隈取_タトゥ2);
			Are.Draw(this.X0Y0_猟豹_タトゥ);
			Are.Draw(this.X0Y0_牛柄_牛柄);
			Are.Draw(this.X0Y0_獣性_獣毛);
			Are.Draw(this.X0Y0_紋柄_紋1);
			Are.Draw(this.X0Y0_紋柄_紋2);
			Are.Draw(this.X0Y0_紋柄_紋3);
			Are.Draw(this.X0Y0_竜性_鱗1);
			Are.Draw(this.X0Y0_竜性_鱗2);
			Are.Draw(this.X0Y0_竜性_鱗3);
			Are.Draw(this.X0Y0_百足_眼1_基);
			Are.Draw(this.X0Y0_百足_眼1_眼);
			Are.Draw(this.X0Y0_百足_眼1_ハイライト);
			Are.Draw(this.X0Y0_百足_眼2_基);
			Are.Draw(this.X0Y0_百足_眼2_眼);
			Are.Draw(this.X0Y0_百足_眼2_ハイライト);
			Are.Draw(this.X0Y0_百足_眼3_基);
			Are.Draw(this.X0Y0_百足_眼3_眼);
			Are.Draw(this.X0Y0_百足_眼3_ハイライト);
			Are.Draw(this.X0Y0_蜘蛛_眼_基);
			Are.Draw(this.X0Y0_蜘蛛_眼_眼);
			Are.Draw(this.X0Y0_蜘蛛_眼_ハイライト);
			Are.Draw(this.X0Y0_傷_傷X);
			Are.Draw(this.X0Y0_傷_傷I1);
			Are.Draw(this.X0Y0_傷_傷I2);
			Are.Draw(this.X0Y0_傷_傷I3);
		}

		public override void 描画1(Are Are)
		{
			Are.Draw(this.X0Y0_獣性_髭1);
			Are.Draw(this.X0Y0_獣性_髭2);
			Are.Draw(this.X0Y0_獣性_髭3);
		}

		public override void 色更新()
		{
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左CP.Update();
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右CP.Update();
			this.X0Y0_隈取_タトゥ1CP.Update();
			this.X0Y0_隈取_タトゥ2CP.Update();
			this.X0Y0_紋柄_紋1CP.Update();
			this.X0Y0_紋柄_紋2CP.Update();
			this.X0Y0_紋柄_紋3CP.Update();
			this.X0Y0_傷_傷XCP.Update();
			this.X0Y0_傷_傷I1CP.Update();
			this.X0Y0_傷_傷I2CP.Update();
			this.X0Y0_傷_傷I3CP.Update();
			this.X0Y0_蜘蛛_眼_基CP.Update();
			this.X0Y0_蜘蛛_眼_眼CP.Update();
			this.X0Y0_蜘蛛_眼_ハイライトCP.Update();
			this.X0Y0_百足_眼1_基CP.Update();
			this.X0Y0_百足_眼1_眼CP.Update();
			this.X0Y0_百足_眼1_ハイライトCP.Update();
			this.X0Y0_百足_眼2_基CP.Update();
			this.X0Y0_百足_眼2_眼CP.Update();
			this.X0Y0_百足_眼2_ハイライトCP.Update();
			this.X0Y0_百足_眼3_基CP.Update();
			this.X0Y0_百足_眼3_眼CP.Update();
			this.X0Y0_百足_眼3_ハイライトCP.Update();
			this.X0Y0_獣性_獣毛CP.Update();
			this.X0Y0_獣性_髭1CP.Update();
			this.X0Y0_獣性_髭2CP.Update();
			this.X0Y0_獣性_髭3CP.Update();
			this.X0Y0_竜性_鱗1CP.Update();
			this.X0Y0_竜性_鱗2CP.Update();
			this.X0Y0_竜性_鱗3CP.Update();
			this.X0Y0_猟豹_タトゥCP.Update();
			this.X0Y0_牛柄_牛柄CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.淫タトゥ_ハ\u30FCト_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.隈取_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.隈取_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.紋柄_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.傷_傷XCD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷_傷I1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷_傷I2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷_傷I3CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.蜘蛛_眼_基CD = new ColorD(ref Col.Black, ref 体配色.眼2O);
			this.蜘蛛_眼_眼CD = new ColorD(ref Col.Black, ref 体配色.眼2O);
			this.蜘蛛_眼_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
			this.百足_眼1_基CD = new ColorD(ref Col.Black, ref 体配色.眼1O);
			this.百足_眼1_眼CD = new ColorD(ref Col.Black, ref 体配色.眼1O);
			this.百足_眼1_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
			this.百足_眼2_基CD = new ColorD(ref Col.Black, ref 体配色.眼1O);
			this.百足_眼2_眼CD = new ColorD(ref Col.Black, ref 体配色.眼1O);
			this.百足_眼2_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
			this.百足_眼3_基CD = new ColorD(ref Col.Black, ref 体配色.眼1O);
			this.百足_眼3_眼CD = new ColorD(ref Col.Black, ref 体配色.眼1O);
			this.百足_眼3_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
			this.獣性_獣毛CD = new ColorD(ref Col.Empty, ref 体配色.毛0O);
			this.獣性_髭1CD = new ColorD(ref Col.Empty, ref 体配色.髭O);
			this.獣性_髭2CD = new ColorD(ref Col.Empty, ref 体配色.髭O);
			this.獣性_髭3CD = new ColorD(ref Col.Empty, ref 体配色.髭O);
			this.竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.猟豹_タトゥCD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.牛柄_牛柄CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
		}

		public Par X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左;

		public Par X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右;

		public Par X0Y0_隈取_タトゥ1;

		public Par X0Y0_隈取_タトゥ2;

		public Par X0Y0_紋柄_紋1;

		public Par X0Y0_紋柄_紋2;

		public Par X0Y0_紋柄_紋3;

		public Par X0Y0_傷_傷X;

		public Par X0Y0_傷_傷I1;

		public Par X0Y0_傷_傷I2;

		public Par X0Y0_傷_傷I3;

		public Par X0Y0_蜘蛛_眼_基;

		public Par X0Y0_蜘蛛_眼_眼;

		public Par X0Y0_蜘蛛_眼_ハイライト;

		public Par X0Y0_百足_眼1_基;

		public Par X0Y0_百足_眼1_眼;

		public Par X0Y0_百足_眼1_ハイライト;

		public Par X0Y0_百足_眼2_基;

		public Par X0Y0_百足_眼2_眼;

		public Par X0Y0_百足_眼2_ハイライト;

		public Par X0Y0_百足_眼3_基;

		public Par X0Y0_百足_眼3_眼;

		public Par X0Y0_百足_眼3_ハイライト;

		public Par X0Y0_獣性_獣毛;

		public Par X0Y0_獣性_髭1;

		public Par X0Y0_獣性_髭2;

		public Par X0Y0_獣性_髭3;

		public Par X0Y0_竜性_鱗1;

		public Par X0Y0_竜性_鱗2;

		public Par X0Y0_竜性_鱗3;

		public Par X0Y0_猟豹_タトゥ;

		public Par X0Y0_牛柄_牛柄;

		public ColorD 淫タトゥ_ハ\u30FCト_タトゥ左CD;

		public ColorD 淫タトゥ_ハ\u30FCト_タトゥ右CD;

		public ColorD 隈取_タトゥ1CD;

		public ColorD 隈取_タトゥ2CD;

		public ColorD 紋柄_紋1CD;

		public ColorD 紋柄_紋2CD;

		public ColorD 紋柄_紋3CD;

		public ColorD 傷_傷XCD;

		public ColorD 傷_傷I1CD;

		public ColorD 傷_傷I2CD;

		public ColorD 傷_傷I3CD;

		public ColorD 蜘蛛_眼_基CD;

		public ColorD 蜘蛛_眼_眼CD;

		public ColorD 蜘蛛_眼_ハイライトCD;

		public ColorD 百足_眼1_基CD;

		public ColorD 百足_眼1_眼CD;

		public ColorD 百足_眼1_ハイライトCD;

		public ColorD 百足_眼2_基CD;

		public ColorD 百足_眼2_眼CD;

		public ColorD 百足_眼2_ハイライトCD;

		public ColorD 百足_眼3_基CD;

		public ColorD 百足_眼3_眼CD;

		public ColorD 百足_眼3_ハイライトCD;

		public ColorD 獣性_獣毛CD;

		public ColorD 獣性_髭1CD;

		public ColorD 獣性_髭2CD;

		public ColorD 獣性_髭3CD;

		public ColorD 竜性_鱗1CD;

		public ColorD 竜性_鱗2CD;

		public ColorD 竜性_鱗3CD;

		public ColorD 猟豹_タトゥCD;

		public ColorD 牛柄_牛柄CD;

		public ColorP X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左CP;

		public ColorP X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右CP;

		public ColorP X0Y0_隈取_タトゥ1CP;

		public ColorP X0Y0_隈取_タトゥ2CP;

		public ColorP X0Y0_紋柄_紋1CP;

		public ColorP X0Y0_紋柄_紋2CP;

		public ColorP X0Y0_紋柄_紋3CP;

		public ColorP X0Y0_傷_傷XCP;

		public ColorP X0Y0_傷_傷I1CP;

		public ColorP X0Y0_傷_傷I2CP;

		public ColorP X0Y0_傷_傷I3CP;

		public ColorP X0Y0_蜘蛛_眼_基CP;

		public ColorP X0Y0_蜘蛛_眼_眼CP;

		public ColorP X0Y0_蜘蛛_眼_ハイライトCP;

		public ColorP X0Y0_百足_眼1_基CP;

		public ColorP X0Y0_百足_眼1_眼CP;

		public ColorP X0Y0_百足_眼1_ハイライトCP;

		public ColorP X0Y0_百足_眼2_基CP;

		public ColorP X0Y0_百足_眼2_眼CP;

		public ColorP X0Y0_百足_眼2_ハイライトCP;

		public ColorP X0Y0_百足_眼3_基CP;

		public ColorP X0Y0_百足_眼3_眼CP;

		public ColorP X0Y0_百足_眼3_ハイライトCP;

		public ColorP X0Y0_獣性_獣毛CP;

		public ColorP X0Y0_獣性_髭1CP;

		public ColorP X0Y0_獣性_髭2CP;

		public ColorP X0Y0_獣性_髭3CP;

		public ColorP X0Y0_竜性_鱗1CP;

		public ColorP X0Y0_竜性_鱗2CP;

		public ColorP X0Y0_竜性_鱗3CP;

		public ColorP X0Y0_猟豹_タトゥCP;

		public ColorP X0Y0_牛柄_牛柄CP;
	}
}
