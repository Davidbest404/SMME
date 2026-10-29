using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 涎_裂け : 涎
	{
		public 涎_裂け(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 涎_裂けD e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.胴体["涎口裂け左"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_涎 = pars["涎"].ToPar();
			pars = this.本体[0][1];
			this.X0Y1_涎 = pars["涎"].ToPar();
			pars = this.本体[0][2];
			this.X0Y2_涎 = pars["涎"].ToPar();
			pars = this.本体[0][3];
			this.X0Y3_涎 = pars["涎"].ToPar();
			pars = this.本体[0][4];
			this.X0Y4_涎 = pars["涎"].ToPar();
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
			this.涎_表示 = e.涎_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_涎CP = new ColorP(this.X0Y0_涎, this.涎CD, DisUnit, false);
			this.X0Y1_涎CP = new ColorP(this.X0Y1_涎, this.涎CD, DisUnit, false);
			this.X0Y2_涎CP = new ColorP(this.X0Y2_涎, this.涎CD, DisUnit, false);
			this.X0Y3_涎CP = new ColorP(this.X0Y3_涎, this.涎CD, DisUnit, false);
			this.X0Y4_涎CP = new ColorP(this.X0Y4_涎, this.涎CD, DisUnit, false);
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

		public bool 涎_表示
		{
			get
			{
				return this.X0Y0_涎.Dra;
			}
			set
			{
				this.X0Y0_涎.Dra = value;
				this.X0Y1_涎.Dra = value;
				this.X0Y2_涎.Dra = value;
				this.X0Y3_涎.Dra = value;
				this.X0Y4_涎.Dra = value;
				this.X0Y0_涎.Hit = value;
				this.X0Y1_涎.Hit = value;
				this.X0Y2_涎.Hit = value;
				this.X0Y3_涎.Hit = value;
				this.X0Y4_涎.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.涎_表示;
			}
			set
			{
				this.涎_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.涎CD.不透明度;
			}
			set
			{
				this.涎CD.不透明度 = value;
			}
		}

		public override void 色更新()
		{
			switch (this.本体.IndexY)
			{
			case 0:
				this.X0Y0_涎CP.Update();
				return;
			case 1:
				this.X0Y1_涎CP.Update();
				return;
			case 2:
				this.X0Y2_涎CP.Update();
				return;
			case 3:
				this.X0Y3_涎CP.Update();
				return;
			default:
				this.X0Y4_涎CP.Update();
				return;
			}
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.涎CD = new ColorD(ref 体配色.体液線, ref Color2.Empty);
		}

		public Par X0Y0_涎;

		public Par X0Y1_涎;

		public Par X0Y2_涎;

		public Par X0Y3_涎;

		public Par X0Y4_涎;

		public ColorD 涎CD;

		public ColorP X0Y0_涎CP;

		public ColorP X0Y1_涎CP;

		public ColorP X0Y2_涎CP;

		public ColorP X0Y3_涎CP;

		public ColorP X0Y4_涎CP;
	}
}
