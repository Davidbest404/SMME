using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 横髪_ジグ : 横髪
	{
		public 横髪_ジグ(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 横髪_ジグD e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "ジグ";
			dif.Add(new Pars(Sta.胴体["横髪左"][0][0]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_髪1 = pars["髪1"].ToPar();
			this.X0Y0_髪2 = pars["髪2"].ToPar();
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
			this.髪1_表示 = e.髪1_表示;
			this.髪2_表示 = e.髪2_表示;
			this.髪長1 = e.髪長1;
			this.髪長2 = e.髪長2;
			this.毛量 = e.毛量;
			this.広がり = e.広がり;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_髪1CP = new ColorP(this.X0Y0_髪1, this.髪1CD, DisUnit, false);
			this.X0Y0_髪2CP = new ColorP(this.X0Y0_髪2, this.髪2CD, DisUnit, false);
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

		public bool 髪1_表示
		{
			get
			{
				return this.X0Y0_髪1.Dra;
			}
			set
			{
				this.X0Y0_髪1.Dra = value;
				this.X0Y0_髪1.Hit = value;
			}
		}

		public bool 髪2_表示
		{
			get
			{
				return this.X0Y0_髪2.Dra;
			}
			set
			{
				this.X0Y0_髪2.Dra = value;
				this.X0Y0_髪2.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.髪1_表示;
			}
			set
			{
				this.髪1_表示 = value;
				this.髪2_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.髪1CD.不透明度;
			}
			set
			{
				this.髪1CD.不透明度 = value;
				this.髪2CD.不透明度 = value;
			}
		}

		public double 髪長1
		{
			set
			{
				double num = 0.8 + 0.3 * value;
				this.X0Y0_髪1.SizeYBase *= num;
			}
		}

		public double 髪長2
		{
			set
			{
				double num = 0.8 + 0.3 * value;
				this.X0Y0_髪2.SizeYBase *= num;
			}
		}

		public double 毛量
		{
			set
			{
				double num = 1.0 + 0.1 * value;
				this.X0Y0_髪1.SizeXBase *= num;
				this.X0Y0_髪2.SizeXBase *= num;
			}
		}

		public double 広がり
		{
			set
			{
				double num = this.右 ? -1.0 : 1.0;
				this.X0Y0_髪2.AngleBase = num * 3.0 * value;
			}
		}

		public override void 色更新()
		{
			this.X0Y0_髪1CP.Update();
			this.X0Y0_髪2CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.髪1CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.髪2CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
		}

		public Par X0Y0_髪1;

		public Par X0Y0_髪2;

		public ColorD 髪1CD;

		public ColorD 髪2CD;

		public ColorP X0Y0_髪1CP;

		public ColorP X0Y0_髪2CP;
	}
}
