using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 汗 : Ele
	{
		public 汗(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 汗D e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.スタンプ["汗"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_汗0 = pars["汗0"].ToPar();
			this.X0Y0_汗1 = pars["汗1"].ToPar();
			this.X0Y0_汗ハイライト = pars["汗ハイライト"].ToPar();
			pars = this.本体[0][1];
			this.X0Y1_汗0流れ = pars["汗0流れ"].ToPar();
			pars = this.本体[0][2];
			this.X0Y2_汗0流れ = pars["汗0流れ"].ToPar();
			pars = this.本体[0][3];
			this.X0Y3_汗0流れ = pars["汗0流れ"].ToPar();
			pars = this.本体[0][4];
			this.X0Y4_汗0流れ = pars["汗0流れ"].ToPar();
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
			this.汗0_表示 = e.汗0_表示;
			this.汗1_表示 = e.汗1_表示;
			this.汗ハイライト_表示 = e.汗ハイライト_表示;
			this.汗0流れ_表示 = e.汗0流れ_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_汗0CP = new ColorP(this.X0Y0_汗0, this.汗0CD, DisUnit, true);
			this.X0Y0_汗1CP = new ColorP(this.X0Y0_汗1, this.汗1CD, DisUnit, true);
			this.X0Y0_汗ハイライトCP = new ColorP(this.X0Y0_汗ハイライト, this.汗ハイライトCD, DisUnit, true);
			this.X0Y1_汗0流れCP = new ColorP(this.X0Y1_汗0流れ, this.汗0流れCD, DisUnit, true);
			this.X0Y2_汗0流れCP = new ColorP(this.X0Y2_汗0流れ, this.汗0流れCD, DisUnit, true);
			this.X0Y3_汗0流れCP = new ColorP(this.X0Y3_汗0流れ, this.汗0流れCD, DisUnit, true);
			this.X0Y4_汗0流れCP = new ColorP(this.X0Y4_汗0流れ, this.汗0流れCD, DisUnit, true);
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

		public bool 汗0_表示
		{
			get
			{
				return this.X0Y0_汗0.Dra;
			}
			set
			{
				this.X0Y0_汗0.Dra = value;
				this.X0Y0_汗0.Hit = value;
			}
		}

		public bool 汗1_表示
		{
			get
			{
				return this.X0Y0_汗1.Dra;
			}
			set
			{
				this.X0Y0_汗1.Dra = value;
				this.X0Y0_汗1.Hit = value;
			}
		}

		public bool 汗ハイライト_表示
		{
			get
			{
				return this.X0Y0_汗ハイライト.Dra;
			}
			set
			{
				this.X0Y0_汗ハイライト.Dra = value;
				this.X0Y0_汗ハイライト.Hit = value;
			}
		}

		public bool 汗0流れ_表示
		{
			get
			{
				return this.X0Y1_汗0流れ.Dra;
			}
			set
			{
				this.X0Y1_汗0流れ.Dra = value;
				this.X0Y2_汗0流れ.Dra = value;
				this.X0Y3_汗0流れ.Dra = value;
				this.X0Y4_汗0流れ.Dra = value;
				this.X0Y1_汗0流れ.Hit = value;
				this.X0Y2_汗0流れ.Hit = value;
				this.X0Y3_汗0流れ.Hit = value;
				this.X0Y4_汗0流れ.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.汗0_表示;
			}
			set
			{
				this.汗0_表示 = value;
				this.汗1_表示 = value;
				this.汗ハイライト_表示 = value;
				this.汗0流れ_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.汗0流れCD.不透明度;
			}
			set
			{
				this.汗0流れCD.不透明度 = value;
				this.汗0CD.不透明度 = value;
				this.汗1CD.不透明度 = value;
				this.汗ハイライトCD.不透明度 = value;
			}
		}

		public override void 色更新()
		{
			switch (this.本体.IndexY)
			{
			case 0:
				this.X0Y0_汗0CP.Update();
				this.X0Y0_汗1CP.Update();
				this.X0Y0_汗ハイライトCP.Update();
				return;
			case 1:
				this.X0Y1_汗0流れCP.Update();
				return;
			case 2:
				this.X0Y2_汗0流れCP.Update();
				return;
			case 3:
				this.X0Y3_汗0流れCP.Update();
				return;
			default:
				this.X0Y4_汗0流れCP.Update();
				return;
			}
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.汗0流れCD = new ColorD(ref 体配色.体液線, ref Color2.Empty);
			this.汗0CD = new ColorD(ref 体配色.体液線, ref Color2.Empty);
			this.汗1CD = new ColorD(ref 体配色.体液線, ref Color2.Empty);
			this.汗ハイライトCD = new ColorD(ref 体配色.ハイライト.Col1, ref 体配色.ハイライト);
		}

		public Par X0Y0_汗0;

		public Par X0Y0_汗1;

		public Par X0Y0_汗ハイライト;

		public Par X0Y1_汗0流れ;

		public Par X0Y2_汗0流れ;

		public Par X0Y3_汗0流れ;

		public Par X0Y4_汗0流れ;

		public ColorD 汗0流れCD;

		public ColorD 汗0CD;

		public ColorD 汗1CD;

		public ColorD 汗ハイライトCD;

		public ColorP X0Y0_汗0CP;

		public ColorP X0Y0_汗1CP;

		public ColorP X0Y0_汗ハイライトCP;

		public ColorP X0Y1_汗0流れCP;

		public ColorP X0Y2_汗0流れCP;

		public ColorP X0Y3_汗0流れCP;

		public ColorP X0Y4_汗0流れCP;
	}
}
