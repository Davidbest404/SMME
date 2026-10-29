using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 胸肌 : Ele
	{
		public 胸肌(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 胸肌D e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.胴体["胸郭肌"]);
			Pars pars = this.本体[0][0];
			Pars pars2 = pars["甲殻"].ToPars();
			this.X0Y0_虫性_甲殻2 = pars2["甲殻2"].ToPar();
			Pars pars3 = pars2["甲殻1"].ToPars();
			this.X0Y0_虫性_甲殻1_甲殻 = pars3["甲殻"].ToPar();
			this.X0Y0_虫性_甲殻1_甲殻左 = pars3["甲殻左"].ToPar();
			this.X0Y0_虫性_甲殻1_甲殻右 = pars3["甲殻右"].ToPar();
			pars2 = pars["淫タトゥ"].ToPars();
			pars3 = pars2["ハート"].ToPars();
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左1 = pars3["タトゥ左1"].ToPar();
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右1 = pars3["タトゥ右1"].ToPar();
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左2 = pars3["タトゥ左2"].ToPar();
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右2 = pars3["タトゥ右2"].ToPar();
			this.X0Y0_淫タトゥ_タトゥ左 = pars2["タトゥ左"].ToPar();
			this.X0Y0_淫タトゥ_タトゥ右 = pars2["タトゥ右"].ToPar();
			pars2 = pars["悪タトゥ"].ToPars();
			pars3 = pars2["逆十字"].ToPars();
			this.X0Y0_悪タトゥ_逆十字_逆十字1 = pars3["逆十字1"].ToPar();
			this.X0Y0_悪タトゥ_逆十字_逆十字2 = pars3["逆十字2"].ToPar();
			pars2 = pars["植タトゥ"].ToPars();
			this.X0Y0_植タトゥ_タトゥ = pars2["タトゥ"].ToPar();
			pars2 = pars["隈取"].ToPars();
			this.X0Y0_隈取_タトゥ左 = pars2["タトゥ左"].ToPar();
			this.X0Y0_隈取_タトゥ右 = pars2["タトゥ右"].ToPar();
			pars2 = pars["蜘蛛"].ToPars();
			pars3 = pars2["眼左1"].ToPars();
			this.X0Y0_蜘蛛_眼左1_基 = pars3["基"].ToPar();
			this.X0Y0_蜘蛛_眼左1_眼 = pars3["眼"].ToPar();
			this.X0Y0_蜘蛛_眼左1_ハイライト = pars3["ハイライト"].ToPar();
			pars3 = pars2["眼左2"].ToPars();
			this.X0Y0_蜘蛛_眼左2_基 = pars3["基"].ToPar();
			this.X0Y0_蜘蛛_眼左2_眼 = pars3["眼"].ToPar();
			this.X0Y0_蜘蛛_眼左2_ハイライト = pars3["ハイライト"].ToPar();
			pars3 = pars2["眼右1"].ToPars();
			this.X0Y0_蜘蛛_眼右1_基 = pars3["基"].ToPar();
			this.X0Y0_蜘蛛_眼右1_眼 = pars3["眼"].ToPar();
			this.X0Y0_蜘蛛_眼右1_ハイライト = pars3["ハイライト"].ToPar();
			pars3 = pars2["眼右2"].ToPars();
			this.X0Y0_蜘蛛_眼右2_基 = pars3["基"].ToPar();
			this.X0Y0_蜘蛛_眼右2_眼 = pars3["眼"].ToPar();
			this.X0Y0_蜘蛛_眼右2_ハイライト = pars3["ハイライト"].ToPar();
			pars2 = pars["鱗"].ToPars();
			this.X0Y0_竜性_鱗1 = pars2["鱗1"].ToPar();
			this.X0Y0_竜性_鱗2 = pars2["鱗2"].ToPar();
			this.X0Y0_竜性_鱗3 = pars2["鱗3"].ToPar();
			pars2 = pars["コア"].ToPars();
			pars3 = pars2["コア1"].ToPars();
			this.X0Y0_コア_コア2_基 = pars3["基"].ToPar();
			this.X0Y0_コア_コア2_コア = pars3["コア"].ToPar();
			this.X0Y0_コア_コア2_ハイライト = pars3["ハイライト"].ToPar();
			pars3 = pars2["コア2"].ToPars();
			this.X0Y0_コア_コア1_基 = pars3["基"].ToPar();
			this.X0Y0_コア_コア1_コア = pars3["コア"].ToPar();
			this.X0Y0_コア_コア1_ハイライト = pars3["ハイライト"].ToPar();
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
			this.虫性_甲殻2_表示 = e.虫性_甲殻2_表示;
			this.虫性_甲殻1_虫性_表示 = e.虫性_甲殻1_虫性_表示;
			this.虫性_甲殻1_甲殻左_表示 = e.虫性_甲殻1_甲殻左_表示;
			this.虫性_甲殻1_甲殻右_表示 = e.虫性_甲殻1_甲殻右_表示;
			this.淫タトゥ_ハ\u30FCト_タトゥ左1_表示 = e.淫タトゥ_ハ\u30FCト_タトゥ左1_表示;
			this.淫タトゥ_ハ\u30FCト_タトゥ右1_表示 = e.淫タトゥ_ハ\u30FCト_タトゥ右1_表示;
			this.淫タトゥ_ハ\u30FCト_タトゥ左2_表示 = e.淫タトゥ_ハ\u30FCト_タトゥ左2_表示;
			this.淫タトゥ_ハ\u30FCト_タトゥ右2_表示 = e.淫タトゥ_ハ\u30FCト_タトゥ右2_表示;
			this.淫タトゥ_タトゥ左_表示 = e.淫タトゥ_タトゥ左_表示;
			this.淫タトゥ_タトゥ右_表示 = e.淫タトゥ_タトゥ右_表示;
			this.悪タトゥ_逆十字_逆十字1_表示 = e.悪タトゥ_逆十字_逆十字1_表示;
			this.悪タトゥ_逆十字_逆十字2_表示 = e.悪タトゥ_逆十字_逆十字2_表示;
			this.植タトゥ_タトゥ_表示 = e.植タトゥ_タトゥ_表示;
			this.隈取_タトゥ左_表示 = e.隈取_タトゥ左_表示;
			this.隈取_タトゥ右_表示 = e.隈取_タトゥ右_表示;
			this.蜘蛛_眼左1_基_表示 = e.蜘蛛_眼左1_基_表示;
			this.蜘蛛_眼左1_眼_表示 = e.蜘蛛_眼左1_眼_表示;
			this.蜘蛛_眼左1_ハイライト_表示 = e.蜘蛛_眼左1_ハイライト_表示;
			this.蜘蛛_眼左2_基_表示 = e.蜘蛛_眼左2_基_表示;
			this.蜘蛛_眼左2_眼_表示 = e.蜘蛛_眼左2_眼_表示;
			this.蜘蛛_眼左2_ハイライト_表示 = e.蜘蛛_眼左2_ハイライト_表示;
			this.蜘蛛_眼右1_基_表示 = e.蜘蛛_眼右1_基_表示;
			this.蜘蛛_眼右1_眼_表示 = e.蜘蛛_眼右1_眼_表示;
			this.蜘蛛_眼右1_ハイライト_表示 = e.蜘蛛_眼右1_ハイライト_表示;
			this.蜘蛛_眼右2_基_表示 = e.蜘蛛_眼右2_基_表示;
			this.蜘蛛_眼右2_眼_表示 = e.蜘蛛_眼右2_眼_表示;
			this.蜘蛛_眼右2_ハイライト_表示 = e.蜘蛛_眼右2_ハイライト_表示;
			this.竜性_鱗1_表示 = e.竜性_鱗1_表示;
			this.竜性_鱗2_表示 = e.竜性_鱗2_表示;
			this.竜性_鱗3_表示 = e.竜性_鱗3_表示;
			this.コア_コア2_基_表示 = e.コア_コア2_基_表示;
			this.コア_コア2_コア_表示 = e.コア_コア2_コア_表示;
			this.コア_コア2_ハイライト_表示 = e.コア_コア2_ハイライト_表示;
			this.コア_コア1_基_表示 = e.コア_コア1_基_表示;
			this.コア_コア1_コア_表示 = e.コア_コア1_コア_表示;
			this.コア_コア1_ハイライト_表示 = e.コア_コア1_ハイライト_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_虫性_甲殻2CP = new ColorP(this.X0Y0_虫性_甲殻2, this.虫性_甲殻2CD, DisUnit, true);
			this.X0Y0_虫性_甲殻1_甲殻CP = new ColorP(this.X0Y0_虫性_甲殻1_甲殻, this.虫性_甲殻1_甲殻CD, DisUnit, true);
			this.X0Y0_虫性_甲殻1_甲殻左CP = new ColorP(this.X0Y0_虫性_甲殻1_甲殻左, this.虫性_甲殻1_甲殻左CD, DisUnit, true);
			this.X0Y0_虫性_甲殻1_甲殻右CP = new ColorP(this.X0Y0_虫性_甲殻1_甲殻右, this.虫性_甲殻1_甲殻右CD, DisUnit, true);
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左1CP = new ColorP(this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左1, this.淫タトゥ_ハ\u30FCト_タトゥ左1CD, DisUnit, true);
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右1CP = new ColorP(this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右1, this.淫タトゥ_ハ\u30FCト_タトゥ右1CD, DisUnit, true);
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左2CP = new ColorP(this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左2, this.淫タトゥ_ハ\u30FCト_タトゥ左2CD, DisUnit, true);
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右2CP = new ColorP(this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右2, this.淫タトゥ_ハ\u30FCト_タトゥ右2CD, DisUnit, true);
			this.X0Y0_淫タトゥ_タトゥ左CP = new ColorP(this.X0Y0_淫タトゥ_タトゥ左, this.淫タトゥ_タトゥ左CD, DisUnit, true);
			this.X0Y0_淫タトゥ_タトゥ右CP = new ColorP(this.X0Y0_淫タトゥ_タトゥ右, this.淫タトゥ_タトゥ右CD, DisUnit, true);
			this.X0Y0_悪タトゥ_逆十字_逆十字1CP = new ColorP(this.X0Y0_悪タトゥ_逆十字_逆十字1, this.悪タトゥ_逆十字_逆十字1CD, DisUnit, false);
			this.X0Y0_悪タトゥ_逆十字_逆十字2CP = new ColorP(this.X0Y0_悪タトゥ_逆十字_逆十字2, this.悪タトゥ_逆十字_逆十字2CD, DisUnit, true);
			this.X0Y0_植タトゥ_タトゥCP = new ColorP(this.X0Y0_植タトゥ_タトゥ, this.植タトゥ_タトゥCD, DisUnit, true);
			this.X0Y0_隈取_タトゥ左CP = new ColorP(this.X0Y0_隈取_タトゥ左, this.隈取_タトゥ左CD, DisUnit, true);
			this.X0Y0_隈取_タトゥ右CP = new ColorP(this.X0Y0_隈取_タトゥ右, this.隈取_タトゥ右CD, DisUnit, true);
			this.X0Y0_蜘蛛_眼左1_基CP = new ColorP(this.X0Y0_蜘蛛_眼左1_基, this.蜘蛛_眼左1_基CD, DisUnit, true);
			this.X0Y0_蜘蛛_眼左1_眼CP = new ColorP(this.X0Y0_蜘蛛_眼左1_眼, this.蜘蛛_眼左1_眼CD, DisUnit, true);
			this.X0Y0_蜘蛛_眼左1_ハイライトCP = new ColorP(this.X0Y0_蜘蛛_眼左1_ハイライト, this.蜘蛛_眼左1_ハイライトCD, DisUnit, true);
			this.X0Y0_蜘蛛_眼左2_基CP = new ColorP(this.X0Y0_蜘蛛_眼左2_基, this.蜘蛛_眼左2_基CD, DisUnit, true);
			this.X0Y0_蜘蛛_眼左2_眼CP = new ColorP(this.X0Y0_蜘蛛_眼左2_眼, this.蜘蛛_眼左2_眼CD, DisUnit, true);
			this.X0Y0_蜘蛛_眼左2_ハイライトCP = new ColorP(this.X0Y0_蜘蛛_眼左2_ハイライト, this.蜘蛛_眼左2_ハイライトCD, DisUnit, true);
			this.X0Y0_蜘蛛_眼右1_基CP = new ColorP(this.X0Y0_蜘蛛_眼右1_基, this.蜘蛛_眼右1_基CD, DisUnit, true);
			this.X0Y0_蜘蛛_眼右1_眼CP = new ColorP(this.X0Y0_蜘蛛_眼右1_眼, this.蜘蛛_眼右1_眼CD, DisUnit, true);
			this.X0Y0_蜘蛛_眼右1_ハイライトCP = new ColorP(this.X0Y0_蜘蛛_眼右1_ハイライト, this.蜘蛛_眼右1_ハイライトCD, DisUnit, true);
			this.X0Y0_蜘蛛_眼右2_基CP = new ColorP(this.X0Y0_蜘蛛_眼右2_基, this.蜘蛛_眼右2_基CD, DisUnit, true);
			this.X0Y0_蜘蛛_眼右2_眼CP = new ColorP(this.X0Y0_蜘蛛_眼右2_眼, this.蜘蛛_眼右2_眼CD, DisUnit, true);
			this.X0Y0_蜘蛛_眼右2_ハイライトCP = new ColorP(this.X0Y0_蜘蛛_眼右2_ハイライト, this.蜘蛛_眼右2_ハイライトCD, DisUnit, true);
			this.X0Y0_竜性_鱗1CP = new ColorP(this.X0Y0_竜性_鱗1, this.竜性_鱗1CD, DisUnit, true);
			this.X0Y0_竜性_鱗2CP = new ColorP(this.X0Y0_竜性_鱗2, this.竜性_鱗2CD, DisUnit, true);
			this.X0Y0_竜性_鱗3CP = new ColorP(this.X0Y0_竜性_鱗3, this.竜性_鱗3CD, DisUnit, true);
			this.X0Y0_コア_コア2_基CP = new ColorP(this.X0Y0_コア_コア2_基, this.コア_コア2_基CD, DisUnit, true);
			this.X0Y0_コア_コア2_コアCP = new ColorP(this.X0Y0_コア_コア2_コア, this.コア_コア2_コアCD, DisUnit, true);
			this.X0Y0_コア_コア2_ハイライトCP = new ColorP(this.X0Y0_コア_コア2_ハイライト, this.コア_コア2_ハイライトCD, DisUnit, true);
			this.X0Y0_コア_コア1_基CP = new ColorP(this.X0Y0_コア_コア1_基, this.コア_コア1_基CD, DisUnit, true);
			this.X0Y0_コア_コア1_コアCP = new ColorP(this.X0Y0_コア_コア1_コア, this.コア_コア1_コアCD, DisUnit, true);
			this.X0Y0_コア_コア1_ハイライトCP = new ColorP(this.X0Y0_コア_コア1_ハイライト, this.コア_コア1_ハイライトCD, DisUnit, true);
			this.濃度 = e.濃度;
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

		public bool 虫性_甲殻2_表示
		{
			get
			{
				return this.X0Y0_虫性_甲殻2.Dra;
			}
			set
			{
				this.X0Y0_虫性_甲殻2.Dra = value;
				this.X0Y0_虫性_甲殻2.Hit = value;
			}
		}

		public bool 虫性_甲殻1_虫性_表示
		{
			get
			{
				return this.X0Y0_虫性_甲殻1_甲殻.Dra;
			}
			set
			{
				this.X0Y0_虫性_甲殻1_甲殻.Dra = value;
				this.X0Y0_虫性_甲殻1_甲殻.Hit = value;
			}
		}

		public bool 虫性_甲殻1_甲殻左_表示
		{
			get
			{
				return this.X0Y0_虫性_甲殻1_甲殻左.Dra;
			}
			set
			{
				this.X0Y0_虫性_甲殻1_甲殻左.Dra = value;
				this.X0Y0_虫性_甲殻1_甲殻左.Hit = value;
			}
		}

		public bool 虫性_甲殻1_甲殻右_表示
		{
			get
			{
				return this.X0Y0_虫性_甲殻1_甲殻右.Dra;
			}
			set
			{
				this.X0Y0_虫性_甲殻1_甲殻右.Dra = value;
				this.X0Y0_虫性_甲殻1_甲殻右.Hit = value;
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
				this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左1.Hit = value;
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
				this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右1.Hit = value;
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
				this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左2.Hit = value;
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
				this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右2.Hit = value;
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

		public bool 悪タトゥ_逆十字_逆十字1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_逆十字_逆十字1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_逆十字_逆十字1.Dra = value;
				this.X0Y0_悪タトゥ_逆十字_逆十字1.Hit = value;
			}
		}

		public bool 悪タトゥ_逆十字_逆十字2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_逆十字_逆十字2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_逆十字_逆十字2.Dra = value;
				this.X0Y0_悪タトゥ_逆十字_逆十字2.Hit = value;
			}
		}

		public bool 植タトゥ_タトゥ_表示
		{
			get
			{
				return this.X0Y0_植タトゥ_タトゥ.Dra;
			}
			set
			{
				this.X0Y0_植タトゥ_タトゥ.Dra = value;
				this.X0Y0_植タトゥ_タトゥ.Hit = value;
			}
		}

		public bool 隈取_タトゥ左_表示
		{
			get
			{
				return this.X0Y0_隈取_タトゥ左.Dra;
			}
			set
			{
				this.X0Y0_隈取_タトゥ左.Dra = value;
				this.X0Y0_隈取_タトゥ左.Hit = value;
			}
		}

		public bool 隈取_タトゥ右_表示
		{
			get
			{
				return this.X0Y0_隈取_タトゥ右.Dra;
			}
			set
			{
				this.X0Y0_隈取_タトゥ右.Dra = value;
				this.X0Y0_隈取_タトゥ右.Hit = value;
			}
		}

		public bool 蜘蛛_眼左1_基_表示
		{
			get
			{
				return this.X0Y0_蜘蛛_眼左1_基.Dra;
			}
			set
			{
				this.X0Y0_蜘蛛_眼左1_基.Dra = value;
				this.X0Y0_蜘蛛_眼左1_基.Hit = value;
			}
		}

		public bool 蜘蛛_眼左1_眼_表示
		{
			get
			{
				return this.X0Y0_蜘蛛_眼左1_眼.Dra;
			}
			set
			{
				this.X0Y0_蜘蛛_眼左1_眼.Dra = value;
				this.X0Y0_蜘蛛_眼左1_眼.Hit = value;
			}
		}

		public bool 蜘蛛_眼左1_ハイライト_表示
		{
			get
			{
				return this.X0Y0_蜘蛛_眼左1_ハイライト.Dra;
			}
			set
			{
				this.X0Y0_蜘蛛_眼左1_ハイライト.Dra = value;
				this.X0Y0_蜘蛛_眼左1_ハイライト.Hit = value;
			}
		}

		public bool 蜘蛛_眼左2_基_表示
		{
			get
			{
				return this.X0Y0_蜘蛛_眼左2_基.Dra;
			}
			set
			{
				this.X0Y0_蜘蛛_眼左2_基.Dra = value;
				this.X0Y0_蜘蛛_眼左2_基.Hit = value;
			}
		}

		public bool 蜘蛛_眼左2_眼_表示
		{
			get
			{
				return this.X0Y0_蜘蛛_眼左2_眼.Dra;
			}
			set
			{
				this.X0Y0_蜘蛛_眼左2_眼.Dra = value;
				this.X0Y0_蜘蛛_眼左2_眼.Hit = value;
			}
		}

		public bool 蜘蛛_眼左2_ハイライト_表示
		{
			get
			{
				return this.X0Y0_蜘蛛_眼左2_ハイライト.Dra;
			}
			set
			{
				this.X0Y0_蜘蛛_眼左2_ハイライト.Dra = value;
				this.X0Y0_蜘蛛_眼左2_ハイライト.Hit = value;
			}
		}

		public bool 蜘蛛_眼右1_基_表示
		{
			get
			{
				return this.X0Y0_蜘蛛_眼右1_基.Dra;
			}
			set
			{
				this.X0Y0_蜘蛛_眼右1_基.Dra = value;
				this.X0Y0_蜘蛛_眼右1_基.Hit = value;
			}
		}

		public bool 蜘蛛_眼右1_眼_表示
		{
			get
			{
				return this.X0Y0_蜘蛛_眼右1_眼.Dra;
			}
			set
			{
				this.X0Y0_蜘蛛_眼右1_眼.Dra = value;
				this.X0Y0_蜘蛛_眼右1_眼.Hit = value;
			}
		}

		public bool 蜘蛛_眼右1_ハイライト_表示
		{
			get
			{
				return this.X0Y0_蜘蛛_眼右1_ハイライト.Dra;
			}
			set
			{
				this.X0Y0_蜘蛛_眼右1_ハイライト.Dra = value;
				this.X0Y0_蜘蛛_眼右1_ハイライト.Hit = value;
			}
		}

		public bool 蜘蛛_眼右2_基_表示
		{
			get
			{
				return this.X0Y0_蜘蛛_眼右2_基.Dra;
			}
			set
			{
				this.X0Y0_蜘蛛_眼右2_基.Dra = value;
				this.X0Y0_蜘蛛_眼右2_基.Hit = value;
			}
		}

		public bool 蜘蛛_眼右2_眼_表示
		{
			get
			{
				return this.X0Y0_蜘蛛_眼右2_眼.Dra;
			}
			set
			{
				this.X0Y0_蜘蛛_眼右2_眼.Dra = value;
				this.X0Y0_蜘蛛_眼右2_眼.Hit = value;
			}
		}

		public bool 蜘蛛_眼右2_ハイライト_表示
		{
			get
			{
				return this.X0Y0_蜘蛛_眼右2_ハイライト.Dra;
			}
			set
			{
				this.X0Y0_蜘蛛_眼右2_ハイライト.Dra = value;
				this.X0Y0_蜘蛛_眼右2_ハイライト.Hit = value;
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

		public bool コア_コア2_基_表示
		{
			get
			{
				return this.X0Y0_コア_コア2_基.Dra;
			}
			set
			{
				this.X0Y0_コア_コア2_基.Dra = value;
				this.X0Y0_コア_コア2_基.Hit = value;
			}
		}

		public bool コア_コア2_コア_表示
		{
			get
			{
				return this.X0Y0_コア_コア2_コア.Dra;
			}
			set
			{
				this.X0Y0_コア_コア2_コア.Dra = value;
				this.X0Y0_コア_コア2_コア.Hit = value;
			}
		}

		public bool コア_コア2_ハイライト_表示
		{
			get
			{
				return this.X0Y0_コア_コア2_ハイライト.Dra;
			}
			set
			{
				this.X0Y0_コア_コア2_ハイライト.Dra = value;
				this.X0Y0_コア_コア2_ハイライト.Hit = value;
			}
		}

		public bool コア_コア1_基_表示
		{
			get
			{
				return this.X0Y0_コア_コア1_基.Dra;
			}
			set
			{
				this.X0Y0_コア_コア1_基.Dra = value;
				this.X0Y0_コア_コア1_基.Hit = value;
			}
		}

		public bool コア_コア1_コア_表示
		{
			get
			{
				return this.X0Y0_コア_コア1_コア.Dra;
			}
			set
			{
				this.X0Y0_コア_コア1_コア.Dra = value;
				this.X0Y0_コア_コア1_コア.Hit = value;
			}
		}

		public bool コア_コア1_ハイライト_表示
		{
			get
			{
				return this.X0Y0_コア_コア1_ハイライト.Dra;
			}
			set
			{
				this.X0Y0_コア_コア1_ハイライト.Dra = value;
				this.X0Y0_コア_コア1_ハイライト.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.虫性_甲殻2_表示;
			}
			set
			{
				this.虫性_甲殻2_表示 = value;
				this.虫性_甲殻1_虫性_表示 = value;
				this.虫性_甲殻1_甲殻左_表示 = value;
				this.虫性_甲殻1_甲殻右_表示 = value;
				this.淫タトゥ_ハ\u30FCト_タトゥ左1_表示 = value;
				this.淫タトゥ_ハ\u30FCト_タトゥ右1_表示 = value;
				this.淫タトゥ_ハ\u30FCト_タトゥ左2_表示 = value;
				this.淫タトゥ_ハ\u30FCト_タトゥ右2_表示 = value;
				this.淫タトゥ_タトゥ左_表示 = value;
				this.淫タトゥ_タトゥ右_表示 = value;
				this.悪タトゥ_逆十字_逆十字1_表示 = value;
				this.悪タトゥ_逆十字_逆十字2_表示 = value;
				this.植タトゥ_タトゥ_表示 = value;
				this.隈取_タトゥ左_表示 = value;
				this.隈取_タトゥ右_表示 = value;
				this.蜘蛛_眼左1_基_表示 = value;
				this.蜘蛛_眼左1_眼_表示 = value;
				this.蜘蛛_眼左1_ハイライト_表示 = value;
				this.蜘蛛_眼左2_基_表示 = value;
				this.蜘蛛_眼左2_眼_表示 = value;
				this.蜘蛛_眼左2_ハイライト_表示 = value;
				this.蜘蛛_眼右1_基_表示 = value;
				this.蜘蛛_眼右1_眼_表示 = value;
				this.蜘蛛_眼右1_ハイライト_表示 = value;
				this.蜘蛛_眼右2_基_表示 = value;
				this.蜘蛛_眼右2_眼_表示 = value;
				this.蜘蛛_眼右2_ハイライト_表示 = value;
				this.竜性_鱗1_表示 = value;
				this.竜性_鱗2_表示 = value;
				this.竜性_鱗3_表示 = value;
				this.コア_コア2_基_表示 = value;
				this.コア_コア2_コア_表示 = value;
				this.コア_コア2_ハイライト_表示 = value;
				this.コア_コア1_基_表示 = value;
				this.コア_コア1_コア_表示 = value;
				this.コア_コア1_ハイライト_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.虫性_甲殻2CD.不透明度;
			}
			set
			{
				this.虫性_甲殻2CD.不透明度 = value;
				this.虫性_甲殻1_甲殻CD.不透明度 = value;
				this.虫性_甲殻1_甲殻左CD.不透明度 = value;
				this.虫性_甲殻1_甲殻右CD.不透明度 = value;
				this.淫タトゥ_ハ\u30FCト_タトゥ左1CD.不透明度 = value;
				this.淫タトゥ_ハ\u30FCト_タトゥ右1CD.不透明度 = value;
				this.淫タトゥ_ハ\u30FCト_タトゥ左2CD.不透明度 = value;
				this.淫タトゥ_ハ\u30FCト_タトゥ右2CD.不透明度 = value;
				this.淫タトゥ_タトゥ左CD.不透明度 = value;
				this.淫タトゥ_タトゥ右CD.不透明度 = value;
				this.悪タトゥ_逆十字_逆十字1CD.不透明度 = value;
				this.悪タトゥ_逆十字_逆十字2CD.不透明度 = value;
				this.植タトゥ_タトゥCD.不透明度 = value;
				this.隈取_タトゥ左CD.不透明度 = value;
				this.隈取_タトゥ右CD.不透明度 = value;
				this.蜘蛛_眼左1_基CD.不透明度 = value;
				this.蜘蛛_眼左1_眼CD.不透明度 = value;
				this.蜘蛛_眼左1_ハイライトCD.不透明度 = value;
				this.蜘蛛_眼左2_基CD.不透明度 = value;
				this.蜘蛛_眼左2_眼CD.不透明度 = value;
				this.蜘蛛_眼左2_ハイライトCD.不透明度 = value;
				this.蜘蛛_眼右1_基CD.不透明度 = value;
				this.蜘蛛_眼右1_眼CD.不透明度 = value;
				this.蜘蛛_眼右1_ハイライトCD.不透明度 = value;
				this.蜘蛛_眼右2_基CD.不透明度 = value;
				this.蜘蛛_眼右2_眼CD.不透明度 = value;
				this.蜘蛛_眼右2_ハイライトCD.不透明度 = value;
				this.竜性_鱗1CD.不透明度 = value;
				this.竜性_鱗2CD.不透明度 = value;
				this.竜性_鱗3CD.不透明度 = value;
				this.コア_コア2_基CD.不透明度 = value;
				this.コア_コア2_コアCD.不透明度 = value;
				this.コア_コア2_ハイライトCD.不透明度 = value;
				this.コア_コア1_基CD.不透明度 = value;
				this.コア_コア1_コアCD.不透明度 = value;
				this.コア_コア1_ハイライトCD.不透明度 = value;
			}
		}

		public override void 描画0(Are Are)
		{
			Are.Draw(this.X0Y0_虫性_甲殻2);
			Are.Draw(this.X0Y0_虫性_甲殻1_甲殻);
			Are.Draw(this.X0Y0_虫性_甲殻1_甲殻左);
			Are.Draw(this.X0Y0_虫性_甲殻1_甲殻右);
			Are.Draw(this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左1);
			Are.Draw(this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右1);
			Are.Draw(this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左2);
			Are.Draw(this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右2);
			Are.Draw(this.X0Y0_淫タトゥ_タトゥ左);
			Are.Draw(this.X0Y0_淫タトゥ_タトゥ右);
			Are.Draw(this.X0Y0_悪タトゥ_逆十字_逆十字1);
			Are.Draw(this.X0Y0_悪タトゥ_逆十字_逆十字2);
			Are.Draw(this.X0Y0_植タトゥ_タトゥ);
			Are.Draw(this.X0Y0_隈取_タトゥ左);
			Are.Draw(this.X0Y0_隈取_タトゥ右);
			Are.Draw(this.X0Y0_蜘蛛_眼左1_基);
			Are.Draw(this.X0Y0_蜘蛛_眼左1_眼);
			Are.Draw(this.X0Y0_蜘蛛_眼左1_ハイライト);
			Are.Draw(this.X0Y0_蜘蛛_眼左2_基);
			Are.Draw(this.X0Y0_蜘蛛_眼左2_眼);
			Are.Draw(this.X0Y0_蜘蛛_眼左2_ハイライト);
			Are.Draw(this.X0Y0_蜘蛛_眼右1_基);
			Are.Draw(this.X0Y0_蜘蛛_眼右1_眼);
			Are.Draw(this.X0Y0_蜘蛛_眼右1_ハイライト);
			Are.Draw(this.X0Y0_蜘蛛_眼右2_基);
			Are.Draw(this.X0Y0_蜘蛛_眼右2_眼);
			Are.Draw(this.X0Y0_蜘蛛_眼右2_ハイライト);
			Are.Draw(this.X0Y0_竜性_鱗1);
			Are.Draw(this.X0Y0_竜性_鱗2);
			Are.Draw(this.X0Y0_竜性_鱗3);
			Are.Draw(this.X0Y0_コア_コア1_基);
			Are.Draw(this.X0Y0_コア_コア1_コア);
			Are.Draw(this.X0Y0_コア_コア1_ハイライト);
		}

		public override void 描画1(Are Are)
		{
			Are.Draw(this.X0Y0_コア_コア2_基);
			Are.Draw(this.X0Y0_コア_コア2_コア);
			Are.Draw(this.X0Y0_コア_コア2_ハイライト);
		}

		public override void 色更新()
		{
			this.X0Y0_虫性_甲殻2CP.Update();
			this.X0Y0_虫性_甲殻1_甲殻CP.Update();
			this.X0Y0_虫性_甲殻1_甲殻左CP.Update();
			this.X0Y0_虫性_甲殻1_甲殻右CP.Update();
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左1CP.Update();
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右1CP.Update();
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左2CP.Update();
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右2CP.Update();
			this.X0Y0_淫タトゥ_タトゥ左CP.Update();
			this.X0Y0_淫タトゥ_タトゥ右CP.Update();
			this.X0Y0_悪タトゥ_逆十字_逆十字1CP.Update();
			this.X0Y0_悪タトゥ_逆十字_逆十字2CP.Update();
			this.X0Y0_植タトゥ_タトゥCP.Update();
			this.X0Y0_隈取_タトゥ左CP.Update();
			this.X0Y0_隈取_タトゥ右CP.Update();
			this.X0Y0_蜘蛛_眼左1_基CP.Update();
			this.X0Y0_蜘蛛_眼左1_眼CP.Update();
			this.X0Y0_蜘蛛_眼左1_ハイライトCP.Update();
			this.X0Y0_蜘蛛_眼左2_基CP.Update();
			this.X0Y0_蜘蛛_眼左2_眼CP.Update();
			this.X0Y0_蜘蛛_眼左2_ハイライトCP.Update();
			this.X0Y0_蜘蛛_眼右1_基CP.Update();
			this.X0Y0_蜘蛛_眼右1_眼CP.Update();
			this.X0Y0_蜘蛛_眼右1_ハイライトCP.Update();
			this.X0Y0_蜘蛛_眼右2_基CP.Update();
			this.X0Y0_蜘蛛_眼右2_眼CP.Update();
			this.X0Y0_蜘蛛_眼右2_ハイライトCP.Update();
			this.X0Y0_竜性_鱗1CP.Update();
			this.X0Y0_竜性_鱗2CP.Update();
			this.X0Y0_竜性_鱗3CP.Update();
			this.X0Y0_コア_コア2_基CP.Update();
			this.X0Y0_コア_コア2_コアCP.Update();
			this.X0Y0_コア_コア2_ハイライトCP.Update();
			this.X0Y0_コア_コア1_基CP.Update();
			this.X0Y0_コア_コア1_コアCP.Update();
			this.X0Y0_コア_コア1_ハイライトCP.Update();
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
			this.虫性_甲殻2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性_甲殻1_甲殻CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性_甲殻1_甲殻左CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性_甲殻1_甲殻右CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.淫タトゥ_ハ\u30FCト_タトゥ左1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ右1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ左2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ右2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_逆十字_逆十字2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.植タトゥ_タトゥCD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.隈取_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.隈取_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.蜘蛛_眼左1_基CD = new ColorD(ref Col.Black, ref 体配色.眼2O);
			this.蜘蛛_眼左1_眼CD = new ColorD(ref Col.Black, ref 体配色.眼2O);
			this.蜘蛛_眼左1_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
			this.蜘蛛_眼左2_基CD = new ColorD(ref Col.Black, ref 体配色.眼2O);
			this.蜘蛛_眼左2_眼CD = new ColorD(ref Col.Black, ref 体配色.眼2O);
			this.蜘蛛_眼左2_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
			this.蜘蛛_眼右1_基CD = new ColorD(ref Col.Black, ref 体配色.眼2O);
			this.蜘蛛_眼右1_眼CD = new ColorD(ref Col.Black, ref 体配色.眼2O);
			this.蜘蛛_眼右1_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
			this.蜘蛛_眼右2_基CD = new ColorD(ref Col.Black, ref 体配色.眼2O);
			this.蜘蛛_眼右2_眼CD = new ColorD(ref Col.Black, ref 体配色.眼2O);
			this.蜘蛛_眼右2_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
			this.竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.コア_コア2_基CD = new ColorD(ref Col.Black, ref 体配色.コアO);
			this.コア_コア2_コアCD = new ColorD(ref Col.Black, ref 体配色.コアO);
			this.コア_コア2_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
			this.コア_コア1_基CD = new ColorD(ref Col.Black, ref 体配色.コアO);
			this.コア_コア1_コアCD = new ColorD(ref Col.Black, ref 体配色.コアO);
			this.コア_コア1_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
		}

		private void 配色T0(体配色 体配色)
		{
			this.虫性_甲殻2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性_甲殻1_甲殻CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性_甲殻1_甲殻左CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性_甲殻1_甲殻右CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.淫タトゥ_ハ\u30FCト_タトゥ左1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ右1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ左2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ右2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_逆十字_逆十字2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.植タトゥ_タトゥCD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.隈取_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.隈取_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.蜘蛛_眼左1_基CD = new ColorD(ref Col.Black, ref 体配色.眼2O);
			this.蜘蛛_眼左1_眼CD = new ColorD(ref Col.Black, ref 体配色.眼2O);
			this.蜘蛛_眼左1_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
			this.蜘蛛_眼左2_基CD = new ColorD(ref Col.Black, ref 体配色.眼2O);
			this.蜘蛛_眼左2_眼CD = new ColorD(ref Col.Black, ref 体配色.眼2O);
			this.蜘蛛_眼左2_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
			this.蜘蛛_眼右1_基CD = new ColorD(ref Col.Black, ref 体配色.眼2O);
			this.蜘蛛_眼右1_眼CD = new ColorD(ref Col.Black, ref 体配色.眼2O);
			this.蜘蛛_眼右1_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
			this.蜘蛛_眼右2_基CD = new ColorD(ref Col.Black, ref 体配色.眼2O);
			this.蜘蛛_眼右2_眼CD = new ColorD(ref Col.Black, ref 体配色.眼2O);
			this.蜘蛛_眼右2_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
			this.竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.コア_コア2_基CD = new ColorD(ref Col.Black, ref 体配色.コアO);
			this.コア_コア2_コアCD = new ColorD(ref Col.Black, ref 体配色.コアO);
			this.コア_コア2_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
			this.コア_コア1_基CD = new ColorD(ref Col.Black, ref 体配色.コアO);
			this.コア_コア1_コアCD = new ColorD(ref Col.Black, ref 体配色.コアO);
			this.コア_コア1_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
		}

		private void 配色T1(体配色 体配色)
		{
			this.虫性_甲殻2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性_甲殻1_甲殻CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性_甲殻1_甲殻左CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性_甲殻1_甲殻右CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.淫タトゥ_ハ\u30FCト_タトゥ左1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ右1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ左2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ右2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_逆十字_逆十字2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.植タトゥ_タトゥCD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.隈取_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.隈取_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.蜘蛛_眼左1_基CD = new ColorD(ref Col.Black, ref 体配色.眼2O);
			this.蜘蛛_眼左1_眼CD = new ColorD(ref Col.Black, ref 体配色.眼2O);
			this.蜘蛛_眼左1_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
			this.蜘蛛_眼左2_基CD = new ColorD(ref Col.Black, ref 体配色.眼2O);
			this.蜘蛛_眼左2_眼CD = new ColorD(ref Col.Black, ref 体配色.眼2O);
			this.蜘蛛_眼左2_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
			this.蜘蛛_眼右1_基CD = new ColorD(ref Col.Black, ref 体配色.眼2O);
			this.蜘蛛_眼右1_眼CD = new ColorD(ref Col.Black, ref 体配色.眼2O);
			this.蜘蛛_眼右1_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
			this.蜘蛛_眼右2_基CD = new ColorD(ref Col.Black, ref 体配色.眼2O);
			this.蜘蛛_眼右2_眼CD = new ColorD(ref Col.Black, ref 体配色.眼2O);
			this.蜘蛛_眼右2_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
			this.竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.コア_コア2_基CD = new ColorD(ref Col.Black, ref 体配色.コアO);
			this.コア_コア2_コアCD = new ColorD(ref Col.Black, ref 体配色.コアO);
			this.コア_コア2_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
			this.コア_コア1_基CD = new ColorD(ref Col.Black, ref 体配色.コアO);
			this.コア_コア1_コアCD = new ColorD(ref Col.Black, ref 体配色.コアO);
			this.コア_コア1_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
		}

		public Par X0Y0_虫性_甲殻2;

		public Par X0Y0_虫性_甲殻1_甲殻;

		public Par X0Y0_虫性_甲殻1_甲殻左;

		public Par X0Y0_虫性_甲殻1_甲殻右;

		public Par X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左1;

		public Par X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右1;

		public Par X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左2;

		public Par X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右2;

		public Par X0Y0_淫タトゥ_タトゥ左;

		public Par X0Y0_淫タトゥ_タトゥ右;

		public Par X0Y0_悪タトゥ_逆十字_逆十字1;

		public Par X0Y0_悪タトゥ_逆十字_逆十字2;

		public Par X0Y0_植タトゥ_タトゥ;

		public Par X0Y0_隈取_タトゥ左;

		public Par X0Y0_隈取_タトゥ右;

		public Par X0Y0_蜘蛛_眼左1_基;

		public Par X0Y0_蜘蛛_眼左1_眼;

		public Par X0Y0_蜘蛛_眼左1_ハイライト;

		public Par X0Y0_蜘蛛_眼左2_基;

		public Par X0Y0_蜘蛛_眼左2_眼;

		public Par X0Y0_蜘蛛_眼左2_ハイライト;

		public Par X0Y0_蜘蛛_眼右1_基;

		public Par X0Y0_蜘蛛_眼右1_眼;

		public Par X0Y0_蜘蛛_眼右1_ハイライト;

		public Par X0Y0_蜘蛛_眼右2_基;

		public Par X0Y0_蜘蛛_眼右2_眼;

		public Par X0Y0_蜘蛛_眼右2_ハイライト;

		public Par X0Y0_竜性_鱗1;

		public Par X0Y0_竜性_鱗2;

		public Par X0Y0_竜性_鱗3;

		public Par X0Y0_コア_コア2_基;

		public Par X0Y0_コア_コア2_コア;

		public Par X0Y0_コア_コア2_ハイライト;

		public Par X0Y0_コア_コア1_基;

		public Par X0Y0_コア_コア1_コア;

		public Par X0Y0_コア_コア1_ハイライト;

		public ColorD 虫性_甲殻2CD;

		public ColorD 虫性_甲殻1_甲殻CD;

		public ColorD 虫性_甲殻1_甲殻左CD;

		public ColorD 虫性_甲殻1_甲殻右CD;

		public ColorD 淫タトゥ_ハ\u30FCト_タトゥ左1CD;

		public ColorD 淫タトゥ_ハ\u30FCト_タトゥ右1CD;

		public ColorD 淫タトゥ_ハ\u30FCト_タトゥ左2CD;

		public ColorD 淫タトゥ_ハ\u30FCト_タトゥ右2CD;

		public ColorD 淫タトゥ_タトゥ左CD;

		public ColorD 淫タトゥ_タトゥ右CD;

		public ColorD 悪タトゥ_逆十字_逆十字1CD;

		public ColorD 悪タトゥ_逆十字_逆十字2CD;

		public ColorD 植タトゥ_タトゥCD;

		public ColorD 隈取_タトゥ左CD;

		public ColorD 隈取_タトゥ右CD;

		public ColorD 蜘蛛_眼左1_基CD;

		public ColorD 蜘蛛_眼左1_眼CD;

		public ColorD 蜘蛛_眼左1_ハイライトCD;

		public ColorD 蜘蛛_眼左2_基CD;

		public ColorD 蜘蛛_眼左2_眼CD;

		public ColorD 蜘蛛_眼左2_ハイライトCD;

		public ColorD 蜘蛛_眼右1_基CD;

		public ColorD 蜘蛛_眼右1_眼CD;

		public ColorD 蜘蛛_眼右1_ハイライトCD;

		public ColorD 蜘蛛_眼右2_基CD;

		public ColorD 蜘蛛_眼右2_眼CD;

		public ColorD 蜘蛛_眼右2_ハイライトCD;

		public ColorD 竜性_鱗1CD;

		public ColorD 竜性_鱗2CD;

		public ColorD 竜性_鱗3CD;

		public ColorD コア_コア2_基CD;

		public ColorD コア_コア2_コアCD;

		public ColorD コア_コア2_ハイライトCD;

		public ColorD コア_コア1_基CD;

		public ColorD コア_コア1_コアCD;

		public ColorD コア_コア1_ハイライトCD;

		public ColorP X0Y0_虫性_甲殻2CP;

		public ColorP X0Y0_虫性_甲殻1_甲殻CP;

		public ColorP X0Y0_虫性_甲殻1_甲殻左CP;

		public ColorP X0Y0_虫性_甲殻1_甲殻右CP;

		public ColorP X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左1CP;

		public ColorP X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右1CP;

		public ColorP X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左2CP;

		public ColorP X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右2CP;

		public ColorP X0Y0_淫タトゥ_タトゥ左CP;

		public ColorP X0Y0_淫タトゥ_タトゥ右CP;

		public ColorP X0Y0_悪タトゥ_逆十字_逆十字1CP;

		public ColorP X0Y0_悪タトゥ_逆十字_逆十字2CP;

		public ColorP X0Y0_植タトゥ_タトゥCP;

		public ColorP X0Y0_隈取_タトゥ左CP;

		public ColorP X0Y0_隈取_タトゥ右CP;

		public ColorP X0Y0_蜘蛛_眼左1_基CP;

		public ColorP X0Y0_蜘蛛_眼左1_眼CP;

		public ColorP X0Y0_蜘蛛_眼左1_ハイライトCP;

		public ColorP X0Y0_蜘蛛_眼左2_基CP;

		public ColorP X0Y0_蜘蛛_眼左2_眼CP;

		public ColorP X0Y0_蜘蛛_眼左2_ハイライトCP;

		public ColorP X0Y0_蜘蛛_眼右1_基CP;

		public ColorP X0Y0_蜘蛛_眼右1_眼CP;

		public ColorP X0Y0_蜘蛛_眼右1_ハイライトCP;

		public ColorP X0Y0_蜘蛛_眼右2_基CP;

		public ColorP X0Y0_蜘蛛_眼右2_眼CP;

		public ColorP X0Y0_蜘蛛_眼右2_ハイライトCP;

		public ColorP X0Y0_竜性_鱗1CP;

		public ColorP X0Y0_竜性_鱗2CP;

		public ColorP X0Y0_竜性_鱗3CP;

		public ColorP X0Y0_コア_コア2_基CP;

		public ColorP X0Y0_コア_コア2_コアCP;

		public ColorP X0Y0_コア_コア2_ハイライトCP;

		public ColorP X0Y0_コア_コア1_基CP;

		public ColorP X0Y0_コア_コア1_コアCP;

		public ColorP X0Y0_コア_コア1_ハイライトCP;
	}
}
