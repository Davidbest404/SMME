using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 下着トップ_クロス : 下着トップ
	{
		public 下着トップ_クロス(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 下着トップ_クロスD e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif(Sta.胴体["下着トップ"][4]);
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			Pars pars2 = pars["布"].ToPars();
			Pars pars3 = pars2["布左"].ToPars();
			this.X0Y0_布_布左_布 = pars3["布"].ToPar();
			Pars pars4 = pars3["皺"].ToPars();
			this.X0Y0_布_布左_皺_皺1 = pars4["皺1"].ToPar();
			this.X0Y0_布_布左_皺_皺2 = pars4["皺2"].ToPar();
			pars4 = pars3["縁"].ToPars();
			this.X0Y0_布_布左_縁_縁1 = pars4["縁1"].ToPar();
			this.X0Y0_布_布左_縁_縁2 = pars4["縁2"].ToPar();
			pars3 = pars2["布右"].ToPars();
			this.X0Y0_布_布右_布 = pars3["布"].ToPar();
			pars4 = pars3["皺"].ToPars();
			this.X0Y0_布_布右_皺_皺1 = pars4["皺1"].ToPar();
			this.X0Y0_布_布右_皺_皺2 = pars4["皺2"].ToPar();
			pars4 = pars3["縁"].ToPars();
			this.X0Y0_布_布右_縁_縁1 = pars4["縁1"].ToPar();
			this.X0Y0_布_布右_縁_縁2 = pars4["縁2"].ToPar();
			pars2 = pars["カップ右"].ToPars();
			this.X0Y0_カップ右_布 = pars2["布"].ToPar();
			this.X0Y0_カップ右_皺 = pars2["皺"].ToPar();
			pars3 = pars2["縁"].ToPars();
			this.X0Y0_カップ右_縁_縁1 = pars3["縁1"].ToPar();
			this.X0Y0_カップ右_縁_縁2 = pars3["縁2"].ToPar();
			pars2 = pars["カップ左"].ToPars();
			this.X0Y0_カップ左_布 = pars2["布"].ToPar();
			this.X0Y0_カップ左_皺 = pars2["皺"].ToPar();
			pars3 = pars2["縁"].ToPars();
			this.X0Y0_カップ左_縁_縁1 = pars3["縁1"].ToPar();
			this.X0Y0_カップ左_縁_縁2 = pars3["縁2"].ToPar();
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
			this.布_布左_布_表示 = e.布_布左_布_表示;
			this.布_布左_皺_皺1_表示 = e.布_布左_皺_皺1_表示;
			this.布_布左_皺_皺2_表示 = e.布_布左_皺_皺2_表示;
			this.布_布左_縁_縁1_表示 = e.布_布左_縁_縁1_表示;
			this.布_布左_縁_縁2_表示 = e.布_布左_縁_縁2_表示;
			this.布_布右_布_表示 = e.布_布右_布_表示;
			this.布_布右_皺_皺1_表示 = e.布_布右_皺_皺1_表示;
			this.布_布右_皺_皺2_表示 = e.布_布右_皺_皺2_表示;
			this.布_布右_縁_縁1_表示 = e.布_布右_縁_縁1_表示;
			this.布_布右_縁_縁2_表示 = e.布_布右_縁_縁2_表示;
			this.カップ右_布_表示 = e.カップ右_布_表示;
			this.カップ右_皺_表示 = e.カップ右_皺_表示;
			this.カップ右_縁_縁1_表示 = e.カップ右_縁_縁1_表示;
			this.カップ右_縁_縁2_表示 = e.カップ右_縁_縁2_表示;
			this.カップ左_布_表示 = e.カップ左_布_表示;
			this.カップ左_皺_表示 = e.カップ左_皺_表示;
			this.カップ左_縁_縁1_表示 = e.カップ左_縁_縁1_表示;
			this.カップ左_縁_縁2_表示 = e.カップ左_縁_縁2_表示;
			this.ベ\u30FCス表示 = e.ベ\u30FCス表示;
			this.皺1表示 = e.皺1表示;
			this.皺2表示 = e.皺2表示;
			this.皺3表示 = e.皺3表示;
			this.縁1表示 = e.縁1表示;
			this.縁2表示 = e.縁2表示;
			this.縁3表示 = e.縁3表示;
			this.縁4表示 = e.縁4表示;
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
			this.X0Y0_布_布左_布CP = new ColorP(this.X0Y0_布_布左_布, this.布_布左_布CD, DisUnit, true);
			this.X0Y0_布_布左_皺_皺1CP = new ColorP(this.X0Y0_布_布左_皺_皺1, this.布_布左_皺_皺1CD, DisUnit, true);
			this.X0Y0_布_布左_皺_皺2CP = new ColorP(this.X0Y0_布_布左_皺_皺2, this.布_布左_皺_皺2CD, DisUnit, true);
			this.X0Y0_布_布左_縁_縁1CP = new ColorP(this.X0Y0_布_布左_縁_縁1, this.布_布左_縁_縁1CD, DisUnit, true);
			this.X0Y0_布_布左_縁_縁2CP = new ColorP(this.X0Y0_布_布左_縁_縁2, this.布_布左_縁_縁2CD, DisUnit, true);
			this.X0Y0_布_布右_布CP = new ColorP(this.X0Y0_布_布右_布, this.布_布右_布CD, DisUnit, true);
			this.X0Y0_布_布右_皺_皺1CP = new ColorP(this.X0Y0_布_布右_皺_皺1, this.布_布右_皺_皺1CD, DisUnit, true);
			this.X0Y0_布_布右_皺_皺2CP = new ColorP(this.X0Y0_布_布右_皺_皺2, this.布_布右_皺_皺2CD, DisUnit, true);
			this.X0Y0_布_布右_縁_縁1CP = new ColorP(this.X0Y0_布_布右_縁_縁1, this.布_布右_縁_縁1CD, DisUnit, true);
			this.X0Y0_布_布右_縁_縁2CP = new ColorP(this.X0Y0_布_布右_縁_縁2, this.布_布右_縁_縁2CD, DisUnit, true);
			this.X0Y0_カップ右_布CP = new ColorP(this.X0Y0_カップ右_布, this.カップ右_布CD, DisUnit, true);
			this.X0Y0_カップ右_皺CP = new ColorP(this.X0Y0_カップ右_皺, this.カップ右_皺CD, DisUnit, true);
			this.X0Y0_カップ右_縁_縁1CP = new ColorP(this.X0Y0_カップ右_縁_縁1, this.カップ右_縁_縁1CD, DisUnit, true);
			this.X0Y0_カップ右_縁_縁2CP = new ColorP(this.X0Y0_カップ右_縁_縁2, this.カップ右_縁_縁2CD, DisUnit, true);
			this.X0Y0_カップ左_布CP = new ColorP(this.X0Y0_カップ左_布, this.カップ左_布CD, DisUnit, true);
			this.X0Y0_カップ左_皺CP = new ColorP(this.X0Y0_カップ左_皺, this.カップ左_皺CD, DisUnit, true);
			this.X0Y0_カップ左_縁_縁1CP = new ColorP(this.X0Y0_カップ左_縁_縁1, this.カップ左_縁_縁1CD, DisUnit, true);
			this.X0Y0_カップ左_縁_縁2CP = new ColorP(this.X0Y0_カップ左_縁_縁2, this.カップ左_縁_縁2CD, DisUnit, true);
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

		public bool 布_布左_布_表示
		{
			get
			{
				return this.X0Y0_布_布左_布.Dra;
			}
			set
			{
				this.X0Y0_布_布左_布.Dra = value;
				this.X0Y0_布_布左_布.Hit = false;
			}
		}

		public bool 布_布左_皺_皺1_表示
		{
			get
			{
				return this.X0Y0_布_布左_皺_皺1.Dra;
			}
			set
			{
				this.X0Y0_布_布左_皺_皺1.Dra = value;
				this.X0Y0_布_布左_皺_皺1.Hit = false;
			}
		}

		public bool 布_布左_皺_皺2_表示
		{
			get
			{
				return this.X0Y0_布_布左_皺_皺2.Dra;
			}
			set
			{
				this.X0Y0_布_布左_皺_皺2.Dra = value;
				this.X0Y0_布_布左_皺_皺2.Hit = false;
			}
		}

		public bool 布_布左_縁_縁1_表示
		{
			get
			{
				return this.X0Y0_布_布左_縁_縁1.Dra;
			}
			set
			{
				this.X0Y0_布_布左_縁_縁1.Dra = value;
				this.X0Y0_布_布左_縁_縁1.Hit = false;
			}
		}

		public bool 布_布左_縁_縁2_表示
		{
			get
			{
				return this.X0Y0_布_布左_縁_縁2.Dra;
			}
			set
			{
				this.X0Y0_布_布左_縁_縁2.Dra = value;
				this.X0Y0_布_布左_縁_縁2.Hit = false;
			}
		}

		public bool 布_布右_布_表示
		{
			get
			{
				return this.X0Y0_布_布右_布.Dra;
			}
			set
			{
				this.X0Y0_布_布右_布.Dra = value;
				this.X0Y0_布_布右_布.Hit = false;
			}
		}

		public bool 布_布右_皺_皺1_表示
		{
			get
			{
				return this.X0Y0_布_布右_皺_皺1.Dra;
			}
			set
			{
				this.X0Y0_布_布右_皺_皺1.Dra = value;
				this.X0Y0_布_布右_皺_皺1.Hit = false;
			}
		}

		public bool 布_布右_皺_皺2_表示
		{
			get
			{
				return this.X0Y0_布_布右_皺_皺2.Dra;
			}
			set
			{
				this.X0Y0_布_布右_皺_皺2.Dra = value;
				this.X0Y0_布_布右_皺_皺2.Hit = false;
			}
		}

		public bool 布_布右_縁_縁1_表示
		{
			get
			{
				return this.X0Y0_布_布右_縁_縁1.Dra;
			}
			set
			{
				this.X0Y0_布_布右_縁_縁1.Dra = value;
				this.X0Y0_布_布右_縁_縁1.Hit = false;
			}
		}

		public bool 布_布右_縁_縁2_表示
		{
			get
			{
				return this.X0Y0_布_布右_縁_縁2.Dra;
			}
			set
			{
				this.X0Y0_布_布右_縁_縁2.Dra = value;
				this.X0Y0_布_布右_縁_縁2.Hit = false;
			}
		}

		public bool カップ右_布_表示
		{
			get
			{
				return this.X0Y0_カップ右_布.Dra;
			}
			set
			{
				this.X0Y0_カップ右_布.Dra = value;
				this.X0Y0_カップ右_布.Hit = false;
			}
		}

		public bool カップ右_皺_表示
		{
			get
			{
				return this.X0Y0_カップ右_皺.Dra;
			}
			set
			{
				this.X0Y0_カップ右_皺.Dra = value;
				this.X0Y0_カップ右_皺.Hit = false;
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

		public bool カップ左_布_表示
		{
			get
			{
				return this.X0Y0_カップ左_布.Dra;
			}
			set
			{
				this.X0Y0_カップ左_布.Dra = value;
				this.X0Y0_カップ左_布.Hit = false;
			}
		}

		public bool カップ左_皺_表示
		{
			get
			{
				return this.X0Y0_カップ左_皺.Dra;
			}
			set
			{
				this.X0Y0_カップ左_皺.Dra = value;
				this.X0Y0_カップ左_皺.Hit = false;
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

		public bool ベ\u30FCス表示
		{
			get
			{
				return this.布_布左_布_表示;
			}
			set
			{
				this.布_布左_布_表示 = value;
				this.布_布右_布_表示 = value;
				this.カップ右_布_表示 = value;
				this.カップ左_布_表示 = value;
			}
		}

		public bool 皺1表示
		{
			get
			{
				return this.カップ左_皺_表示;
			}
			set
			{
				this.カップ左_皺_表示 = value;
				this.カップ右_皺_表示 = value;
			}
		}

		public bool 皺2表示
		{
			get
			{
				return this.布_布左_皺_皺1_表示;
			}
			set
			{
				this.布_布左_皺_皺1_表示 = value;
				this.布_布右_皺_皺1_表示 = value;
			}
		}

		public bool 皺3表示
		{
			get
			{
				return this.布_布左_皺_皺2_表示;
			}
			set
			{
				this.布_布左_皺_皺2_表示 = value;
				this.布_布右_皺_皺2_表示 = value;
			}
		}

		public bool 縁1表示
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

		public bool 縁2表示
		{
			get
			{
				return this.布_布左_縁_縁1_表示;
			}
			set
			{
				this.布_布左_縁_縁1_表示 = value;
				this.布_布右_縁_縁1_表示 = value;
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
				return this.布_布左_縁_縁2_表示;
			}
			set
			{
				this.布_布左_縁_縁2_表示 = value;
				this.布_布右_縁_縁2_表示 = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.布_布左_布_表示;
			}
			set
			{
				this.布_布左_布_表示 = value;
				this.布_布左_皺_皺1_表示 = value;
				this.布_布左_皺_皺2_表示 = value;
				this.布_布左_縁_縁1_表示 = value;
				this.布_布左_縁_縁2_表示 = value;
				this.布_布右_布_表示 = value;
				this.布_布右_皺_皺1_表示 = value;
				this.布_布右_皺_皺2_表示 = value;
				this.布_布右_縁_縁1_表示 = value;
				this.布_布右_縁_縁2_表示 = value;
				this.カップ右_布_表示 = value;
				this.カップ右_皺_表示 = value;
				this.カップ右_縁_縁1_表示 = value;
				this.カップ右_縁_縁2_表示 = value;
				this.カップ左_布_表示 = value;
				this.カップ左_皺_表示 = value;
				this.カップ左_縁_縁1_表示 = value;
				this.カップ左_縁_縁2_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.布_布左_布CD.不透明度;
			}
			set
			{
				this.布_布左_布CD.不透明度 = value;
				this.布_布左_皺_皺1CD.不透明度 = value;
				this.布_布左_皺_皺2CD.不透明度 = value;
				this.布_布左_縁_縁1CD.不透明度 = value;
				this.布_布左_縁_縁2CD.不透明度 = value;
				this.布_布右_布CD.不透明度 = value;
				this.布_布右_皺_皺1CD.不透明度 = value;
				this.布_布右_皺_皺2CD.不透明度 = value;
				this.布_布右_縁_縁1CD.不透明度 = value;
				this.布_布右_縁_縁2CD.不透明度 = value;
				this.カップ右_布CD.不透明度 = value;
				this.カップ右_皺CD.不透明度 = value;
				this.カップ右_縁_縁1CD.不透明度 = value;
				this.カップ右_縁_縁2CD.不透明度 = value;
				this.カップ左_布CD.不透明度 = value;
				this.カップ左_皺CD.不透明度 = value;
				this.カップ左_縁_縁1CD.不透明度 = value;
				this.カップ左_縁_縁2CD.不透明度 = value;
			}
		}

		public double バスト
		{
			set
			{
				double num = this.sb * (0.9 + 0.24 * value);
				this.X0Y0_カップ右_布.SizeBase = num;
				this.X0Y0_カップ右_皺.SizeBase = num;
				this.X0Y0_カップ右_縁_縁1.SizeBase = num;
				this.X0Y0_カップ右_縁_縁2.SizeBase = num;
				this.X0Y0_カップ左_布.SizeBase = num;
				this.X0Y0_カップ左_皺.SizeBase = num;
				this.X0Y0_カップ左_縁_縁1.SizeBase = num;
				this.X0Y0_カップ左_縁_縁2.SizeBase = num;
				num = this.syb * (1.0 + 0.05 * value.Inverse());
				this.X0Y0_カップ右_布.SizeYBase = num;
				this.X0Y0_カップ右_皺.SizeYBase = num;
				this.X0Y0_カップ右_縁_縁1.SizeYBase = num;
				this.X0Y0_カップ右_縁_縁2.SizeYBase = num;
				this.X0Y0_カップ左_布.SizeYBase = num;
				this.X0Y0_カップ左_皺.SizeYBase = num;
				this.X0Y0_カップ左_縁_縁1.SizeYBase = num;
				this.X0Y0_カップ左_縁_縁2.SizeYBase = num;
				this.X0Y0_布_布左_布.SizeYBase = num;
				this.X0Y0_布_布左_皺_皺1.SizeYBase = num;
				this.X0Y0_布_布左_皺_皺2.SizeYBase = num;
				this.X0Y0_布_布左_縁_縁1.SizeYBase = num;
				this.X0Y0_布_布左_縁_縁2.SizeYBase = num;
				this.X0Y0_布_布右_布.SizeYBase = num;
				this.X0Y0_布_布右_皺_皺1.SizeYBase = num;
				this.X0Y0_布_布右_皺_皺2.SizeYBase = num;
				this.X0Y0_布_布右_縁_縁1.SizeYBase = num;
				this.X0Y0_布_布右_縁_縁2.SizeYBase = num;
				this.位置C = new Vector2D(this.位置C.X, -0.001);
				this.X0Y0_布_布左_布.PositionCont = new Vector2D(this.X0Y0_布_布左_布.PositionCont.X, -0.005);
				this.X0Y0_布_布右_布.PositionCont = new Vector2D(this.X0Y0_布_布右_布.PositionCont.X, -0.005);
			}
		}

		public override void 描画0(Are Are)
		{
			Are.Draw(this.X0Y0_布_布左_布);
			Are.Draw(this.X0Y0_布_布左_皺_皺1);
			Are.Draw(this.X0Y0_布_布左_皺_皺2);
			Are.Draw(this.X0Y0_布_布左_縁_縁1);
			Are.Draw(this.X0Y0_布_布左_縁_縁2);
			Are.Draw(this.X0Y0_布_布右_布);
			Are.Draw(this.X0Y0_布_布右_皺_皺1);
			Are.Draw(this.X0Y0_布_布右_皺_皺2);
			Are.Draw(this.X0Y0_布_布右_縁_縁1);
			Are.Draw(this.X0Y0_布_布右_縁_縁2);
		}

		public override void 描画1(Are Are)
		{
			Are.Draw(this.X0Y0_カップ右_布);
			Are.Draw(this.X0Y0_カップ右_皺);
			Are.Draw(this.X0Y0_カップ右_縁_縁1);
			Are.Draw(this.X0Y0_カップ右_縁_縁2);
			Are.Draw(this.X0Y0_カップ左_布);
			Are.Draw(this.X0Y0_カップ左_皺);
			Are.Draw(this.X0Y0_カップ左_縁_縁1);
			Are.Draw(this.X0Y0_カップ左_縁_縁2);
		}

		public override bool Is布(Par p)
		{
			return p == this.X0Y0_布_布左_布 || p == this.X0Y0_布_布左_皺_皺1 || p == this.X0Y0_布_布左_皺_皺2 || p == this.X0Y0_布_布左_縁_縁1 || p == this.X0Y0_布_布左_縁_縁2 || p == this.X0Y0_布_布右_布 || p == this.X0Y0_布_布右_皺_皺1 || p == this.X0Y0_布_布右_皺_皺2 || p == this.X0Y0_布_布右_縁_縁1 || p == this.X0Y0_布_布右_縁_縁2 || p == this.X0Y0_カップ右_布 || p == this.X0Y0_カップ右_皺 || p == this.X0Y0_カップ右_縁_縁1 || p == this.X0Y0_カップ右_縁_縁2 || p == this.X0Y0_カップ左_布 || p == this.X0Y0_カップ左_皺 || p == this.X0Y0_カップ左_縁_縁1 || p == this.X0Y0_カップ左_縁_縁2;
		}

		public override void 色更新()
		{
			this.X0Y0_布_布左_布CP.Update();
			this.X0Y0_布_布左_皺_皺1CP.Update();
			this.X0Y0_布_布左_皺_皺2CP.Update();
			this.X0Y0_布_布左_縁_縁1CP.Update();
			this.X0Y0_布_布左_縁_縁2CP.Update();
			this.X0Y0_布_布右_布CP.Update();
			this.X0Y0_布_布右_皺_皺1CP.Update();
			this.X0Y0_布_布右_皺_皺2CP.Update();
			this.X0Y0_布_布右_縁_縁1CP.Update();
			this.X0Y0_布_布右_縁_縁2CP.Update();
			this.X0Y0_カップ右_布CP.Update();
			this.X0Y0_カップ右_皺CP.Update();
			this.X0Y0_カップ右_縁_縁1CP.Update();
			this.X0Y0_カップ右_縁_縁2CP.Update();
			this.X0Y0_カップ左_布CP.Update();
			this.X0Y0_カップ左_皺CP.Update();
			this.X0Y0_カップ左_縁_縁1CP.Update();
			this.X0Y0_カップ左_縁_縁2CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.布_布左_布CD = new ColorD();
			this.布_布左_皺_皺1CD = new ColorD();
			this.布_布左_皺_皺2CD = new ColorD();
			this.布_布左_縁_縁1CD = new ColorD();
			this.布_布左_縁_縁2CD = new ColorD();
			this.布_布右_布CD = new ColorD();
			this.布_布右_皺_皺1CD = new ColorD();
			this.布_布右_皺_皺2CD = new ColorD();
			this.布_布右_縁_縁1CD = new ColorD();
			this.布_布右_縁_縁2CD = new ColorD();
			this.カップ右_布CD = new ColorD();
			this.カップ右_皺CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.カップ右_縁_縁1CD = new ColorD();
			this.カップ右_縁_縁2CD = new ColorD();
			this.カップ左_布CD = new ColorD();
			this.カップ左_皺CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.カップ左_縁_縁1CD = new ColorD();
			this.カップ左_縁_縁2CD = new ColorD();
		}

		public void 配色(クロスT色 配色)
		{
			this.布_布左_布CD.色 = 配色.生地色;
			this.布_布左_皺_皺1CD.色 = 配色.生地色;
			this.布_布左_皺_皺2CD.色 = 配色.生地色;
			this.布_布左_縁_縁1CD.色 = 配色.縁色;
			this.布_布左_縁_縁2CD.色 = 配色.縁色;
			this.布_布右_布CD.色 = 配色.生地色;
			this.布_布右_皺_皺1CD.色 = 配色.生地色;
			this.布_布右_皺_皺2CD.色 = 配色.生地色;
			this.布_布右_縁_縁1CD.色 = 配色.縁色;
			this.布_布右_縁_縁2CD.色 = 配色.縁色;
			this.カップ右_布CD.色 = 配色.生地色;
			this.カップ右_皺CD.色 = 配色.生地色;
			this.カップ右_縁_縁1CD.色 = 配色.縁色;
			this.カップ右_縁_縁2CD.色 = 配色.縁色;
			this.カップ左_布CD.色 = 配色.生地色;
			this.カップ左_皺CD.色 = 配色.生地色;
			this.カップ左_縁_縁1CD.色 = 配色.縁色;
			this.カップ左_縁_縁2CD.色 = 配色.縁色;
		}

		public Par X0Y0_布_布左_布;

		public Par X0Y0_布_布左_皺_皺1;

		public Par X0Y0_布_布左_皺_皺2;

		public Par X0Y0_布_布左_縁_縁1;

		public Par X0Y0_布_布左_縁_縁2;

		public Par X0Y0_布_布右_布;

		public Par X0Y0_布_布右_皺_皺1;

		public Par X0Y0_布_布右_皺_皺2;

		public Par X0Y0_布_布右_縁_縁1;

		public Par X0Y0_布_布右_縁_縁2;

		public Par X0Y0_カップ右_布;

		public Par X0Y0_カップ右_皺;

		public Par X0Y0_カップ右_縁_縁1;

		public Par X0Y0_カップ右_縁_縁2;

		public Par X0Y0_カップ左_布;

		public Par X0Y0_カップ左_皺;

		public Par X0Y0_カップ左_縁_縁1;

		public Par X0Y0_カップ左_縁_縁2;

		public ColorD 布_布左_布CD;

		public ColorD 布_布左_皺_皺1CD;

		public ColorD 布_布左_皺_皺2CD;

		public ColorD 布_布左_縁_縁1CD;

		public ColorD 布_布左_縁_縁2CD;

		public ColorD 布_布右_布CD;

		public ColorD 布_布右_皺_皺1CD;

		public ColorD 布_布右_皺_皺2CD;

		public ColorD 布_布右_縁_縁1CD;

		public ColorD 布_布右_縁_縁2CD;

		public ColorD カップ右_布CD;

		public ColorD カップ右_皺CD;

		public ColorD カップ右_縁_縁1CD;

		public ColorD カップ右_縁_縁2CD;

		public ColorD カップ左_布CD;

		public ColorD カップ左_皺CD;

		public ColorD カップ左_縁_縁1CD;

		public ColorD カップ左_縁_縁2CD;

		public ColorP X0Y0_布_布左_布CP;

		public ColorP X0Y0_布_布左_皺_皺1CP;

		public ColorP X0Y0_布_布左_皺_皺2CP;

		public ColorP X0Y0_布_布左_縁_縁1CP;

		public ColorP X0Y0_布_布左_縁_縁2CP;

		public ColorP X0Y0_布_布右_布CP;

		public ColorP X0Y0_布_布右_皺_皺1CP;

		public ColorP X0Y0_布_布右_皺_皺2CP;

		public ColorP X0Y0_布_布右_縁_縁1CP;

		public ColorP X0Y0_布_布右_縁_縁2CP;

		public ColorP X0Y0_カップ右_布CP;

		public ColorP X0Y0_カップ右_皺CP;

		public ColorP X0Y0_カップ右_縁_縁1CP;

		public ColorP X0Y0_カップ右_縁_縁2CP;

		public ColorP X0Y0_カップ左_布CP;

		public ColorP X0Y0_カップ左_皺CP;

		public ColorP X0Y0_カップ左_縁_縁1CP;

		public ColorP X0Y0_カップ左_縁_縁2CP;

		private double sb;

		private double syb;
	}
}
