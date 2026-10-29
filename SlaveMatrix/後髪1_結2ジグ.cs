using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 後髪1_結2ジグ : サイド
	{
		public 後髪1_結2ジグ(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 後髪1_結2ジグD e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "結い2ジグ";
			dif.Add(new Pars(Sta.胴体["後髪1"][0][4]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_髪基 = pars["髪基"].ToPar();
			Pars pars2 = pars["お下げ左"].ToPars();
			this.X0Y0_お下げ左_髪左根 = pars2["髪左根"].ToPar();
			this.X0Y0_お下げ左_髪左1 = pars2["髪左1"].ToPar();
			this.X0Y0_お下げ左_髪左2 = pars2["髪左2"].ToPar();
			pars2 = pars["お下げ右"].ToPars();
			this.X0Y0_お下げ右_髪右根 = pars2["髪右根"].ToPar();
			this.X0Y0_お下げ右_髪右1 = pars2["髪右1"].ToPar();
			this.X0Y0_お下げ右_髪右2 = pars2["髪右2"].ToPar();
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
			this.髪基_表示 = e.髪基_表示;
			this.お下げ左_髪左根_表示 = e.お下げ左_髪左根_表示;
			this.お下げ左_髪左1_表示 = e.お下げ左_髪左1_表示;
			this.お下げ左_髪左2_表示 = e.お下げ左_髪左2_表示;
			this.お下げ右_髪右根_表示 = e.お下げ右_髪右根_表示;
			this.お下げ右_髪右1_表示 = e.お下げ右_髪右1_表示;
			this.お下げ右_髪右2_表示 = e.お下げ右_髪右2_表示;
			this.髪長 = e.髪長;
			this.毛量 = e.毛量;
			this.広がり = e.広がり;
			this.高さ = e.高さ;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_髪基CP = new ColorP(this.X0Y0_髪基, this.髪基CD, DisUnit, false);
			this.X0Y0_お下げ左_髪左根CP = new ColorP(this.X0Y0_お下げ左_髪左根, this.お下げ左_髪左根CD, DisUnit, false);
			this.X0Y0_お下げ左_髪左1CP = new ColorP(this.X0Y0_お下げ左_髪左1, this.お下げ左_髪左1CD, DisUnit, false);
			this.X0Y0_お下げ左_髪左2CP = new ColorP(this.X0Y0_お下げ左_髪左2, this.お下げ左_髪左2CD, DisUnit, false);
			this.X0Y0_お下げ右_髪右根CP = new ColorP(this.X0Y0_お下げ右_髪右根, this.お下げ右_髪右根CD, DisUnit, false);
			this.X0Y0_お下げ右_髪右1CP = new ColorP(this.X0Y0_お下げ右_髪右1, this.お下げ右_髪右1CD, DisUnit, false);
			this.X0Y0_お下げ右_髪右2CP = new ColorP(this.X0Y0_お下げ右_髪右2, this.お下げ右_髪右2CD, DisUnit, false);
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

		public bool 髪基_表示
		{
			get
			{
				return this.X0Y0_髪基.Dra;
			}
			set
			{
				this.X0Y0_髪基.Dra = value;
				this.X0Y0_髪基.Hit = value;
			}
		}

		public bool お下げ左_髪左根_表示
		{
			get
			{
				return this.X0Y0_お下げ左_髪左根.Dra;
			}
			set
			{
				this.X0Y0_お下げ左_髪左根.Dra = value;
				this.X0Y0_お下げ左_髪左根.Hit = value;
			}
		}

		public bool お下げ左_髪左1_表示
		{
			get
			{
				return this.X0Y0_お下げ左_髪左1.Dra;
			}
			set
			{
				this.X0Y0_お下げ左_髪左1.Dra = value;
				this.X0Y0_お下げ左_髪左1.Hit = value;
			}
		}

		public bool お下げ左_髪左2_表示
		{
			get
			{
				return this.X0Y0_お下げ左_髪左2.Dra;
			}
			set
			{
				this.X0Y0_お下げ左_髪左2.Dra = value;
				this.X0Y0_お下げ左_髪左2.Hit = value;
			}
		}

		public bool お下げ右_髪右根_表示
		{
			get
			{
				return this.X0Y0_お下げ右_髪右根.Dra;
			}
			set
			{
				this.X0Y0_お下げ右_髪右根.Dra = value;
				this.X0Y0_お下げ右_髪右根.Hit = value;
			}
		}

		public bool お下げ右_髪右1_表示
		{
			get
			{
				return this.X0Y0_お下げ右_髪右1.Dra;
			}
			set
			{
				this.X0Y0_お下げ右_髪右1.Dra = value;
				this.X0Y0_お下げ右_髪右1.Hit = value;
			}
		}

		public bool お下げ右_髪右2_表示
		{
			get
			{
				return this.X0Y0_お下げ右_髪右2.Dra;
			}
			set
			{
				this.X0Y0_お下げ右_髪右2.Dra = value;
				this.X0Y0_お下げ右_髪右2.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.髪基_表示;
			}
			set
			{
				this.髪基_表示 = value;
				this.お下げ左_髪左根_表示 = value;
				this.お下げ左_髪左1_表示 = value;
				this.お下げ左_髪左2_表示 = value;
				this.お下げ右_髪右根_表示 = value;
				this.お下げ右_髪右1_表示 = value;
				this.お下げ右_髪右2_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.髪基CD.不透明度;
			}
			set
			{
				this.髪基CD.不透明度 = value;
				this.お下げ左_髪左根CD.不透明度 = value;
				this.お下げ左_髪左1CD.不透明度 = value;
				this.お下げ左_髪左2CD.不透明度 = value;
				this.お下げ右_髪右根CD.不透明度 = value;
				this.お下げ右_髪右1CD.不透明度 = value;
				this.お下げ右_髪右2CD.不透明度 = value;
			}
		}

		public double 髪長
		{
			set
			{
				double num = 0.5 + 0.9 * value;
				this.X0Y0_お下げ左_髪左根.SizeYBase *= num;
				this.X0Y0_お下げ左_髪左1.SizeYBase *= num;
				this.X0Y0_お下げ左_髪左2.SizeYBase *= num;
				this.X0Y0_お下げ右_髪右根.SizeYBase *= num;
				this.X0Y0_お下げ右_髪右1.SizeYBase *= num;
				this.X0Y0_お下げ右_髪右2.SizeYBase *= num;
			}
		}

		public double 毛量
		{
			set
			{
				double num = 1.0 + 0.5 * value;
				this.X0Y0_お下げ左_髪左根.SizeXBase *= num;
				this.X0Y0_お下げ左_髪左1.SizeXBase *= num;
				this.X0Y0_お下げ左_髪左2.SizeXBase *= num;
				this.X0Y0_お下げ右_髪右根.SizeXBase *= num;
				this.X0Y0_お下げ右_髪右1.SizeXBase *= num;
				this.X0Y0_お下げ右_髪右2.SizeXBase *= num;
			}
		}

		public double 広がり
		{
			set
			{
				this.X0Y0_お下げ左_髪左1.AngleBase = 1.5 * value;
				this.X0Y0_お下げ左_髪左2.AngleBase = 1.5 * value;
				this.X0Y0_お下げ右_髪右1.AngleBase = -1.5 * value;
				this.X0Y0_お下げ右_髪右2.AngleBase = -1.5 * value;
			}
		}

		public double 高さ
		{
			set
			{
				double num = value.Inverse();
				this.X0Y0_お下げ左_髪左根.PositionCont = new Vector2D(this.X0Y0_お下げ左_髪左根.PositionCont.X - 0.005 * num, this.X0Y0_お下げ左_髪左根.PositionCont.Y + 0.02 * num);
				this.X0Y0_お下げ右_髪右根.PositionCont = new Vector2D(this.X0Y0_お下げ右_髪右根.PositionCont.X + 0.005 * num, this.X0Y0_お下げ右_髪右根.PositionCont.Y + 0.02 * num);
			}
		}

		public override void 色更新()
		{
			this.X0Y0_髪基CP.Update();
			this.X0Y0_お下げ左_髪左根CP.Update();
			this.X0Y0_お下げ左_髪左1CP.Update();
			this.X0Y0_お下げ左_髪左2CP.Update();
			this.X0Y0_お下げ右_髪右根CP.Update();
			this.X0Y0_お下げ右_髪右1CP.Update();
			this.X0Y0_お下げ右_髪右2CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.髪基CD = new ColorD(ref Col.Empty, ref Color2.Empty);
			this.お下げ左_髪左根CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.お下げ左_髪左1CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.お下げ左_髪左2CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.お下げ右_髪右根CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.お下げ右_髪右1CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.お下げ右_髪右2CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
		}

		public Par X0Y0_髪基;

		public Par X0Y0_お下げ左_髪左根;

		public Par X0Y0_お下げ左_髪左1;

		public Par X0Y0_お下げ左_髪左2;

		public Par X0Y0_お下げ右_髪右根;

		public Par X0Y0_お下げ右_髪右1;

		public Par X0Y0_お下げ右_髪右2;

		public ColorD 髪基CD;

		public ColorD お下げ左_髪左根CD;

		public ColorD お下げ左_髪左1CD;

		public ColorD お下げ左_髪左2CD;

		public ColorD お下げ右_髪右根CD;

		public ColorD お下げ右_髪右1CD;

		public ColorD お下げ右_髪右2CD;

		public ColorP X0Y0_髪基CP;

		public ColorP X0Y0_お下げ左_髪左根CP;

		public ColorP X0Y0_お下げ左_髪左1CP;

		public ColorP X0Y0_お下げ左_髪左2CP;

		public ColorP X0Y0_お下げ右_髪右根CP;

		public ColorP X0Y0_お下げ右_髪右1CP;

		public ColorP X0Y0_お下げ右_髪右2CP;
	}
}
