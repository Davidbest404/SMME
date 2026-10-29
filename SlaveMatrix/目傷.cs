using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 目傷 : Ele
	{
		public 目傷(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 目傷D e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.胴体["目傷左"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_傷上 = pars["傷上"].ToPar();
			this.X0Y0_傷下 = pars["傷下"].ToPar();
			pars = this.本体[0][1];
			this.X0Y1_傷上 = pars["傷上"].ToPar();
			this.X0Y1_傷下 = pars["傷下"].ToPar();
			pars = this.本体[0][2];
			this.X0Y2_傷上 = pars["傷上"].ToPar();
			this.X0Y2_傷下 = pars["傷下"].ToPar();
			pars = this.本体[0][3];
			this.X0Y3_傷上 = pars["傷上"].ToPar();
			this.X0Y3_傷下 = pars["傷下"].ToPar();
			pars = this.本体[0][4];
			this.X0Y4_傷上 = pars["傷上"].ToPar();
			this.X0Y4_傷下 = pars["傷下"].ToPar();
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
			this.傷上_表示 = e.傷上_表示;
			this.傷下_表示 = e.傷下_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_傷上CP = new ColorP(this.X0Y0_傷上, this.傷上CD, DisUnit, true);
			this.X0Y0_傷下CP = new ColorP(this.X0Y0_傷下, this.傷下CD, DisUnit, true);
			this.X0Y1_傷上CP = new ColorP(this.X0Y1_傷上, this.傷上CD, DisUnit, true);
			this.X0Y1_傷下CP = new ColorP(this.X0Y1_傷下, this.傷下CD, DisUnit, true);
			this.X0Y2_傷上CP = new ColorP(this.X0Y2_傷上, this.傷上CD, DisUnit, true);
			this.X0Y2_傷下CP = new ColorP(this.X0Y2_傷下, this.傷下CD, DisUnit, true);
			this.X0Y3_傷上CP = new ColorP(this.X0Y3_傷上, this.傷上CD, DisUnit, true);
			this.X0Y3_傷下CP = new ColorP(this.X0Y3_傷下, this.傷下CD, DisUnit, true);
			this.X0Y4_傷上CP = new ColorP(this.X0Y4_傷上, this.傷上CD, DisUnit, true);
			this.X0Y4_傷下CP = new ColorP(this.X0Y4_傷下, this.傷下CD, DisUnit, true);
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

		public bool 傷上_表示
		{
			get
			{
				return this.X0Y0_傷上.Dra;
			}
			set
			{
				this.X0Y0_傷上.Dra = value;
				this.X0Y1_傷上.Dra = value;
				this.X0Y2_傷上.Dra = value;
				this.X0Y3_傷上.Dra = value;
				this.X0Y4_傷上.Dra = value;
				this.X0Y0_傷上.Hit = value;
				this.X0Y1_傷上.Hit = value;
				this.X0Y2_傷上.Hit = value;
				this.X0Y3_傷上.Hit = value;
				this.X0Y4_傷上.Hit = value;
			}
		}

		public bool 傷下_表示
		{
			get
			{
				return this.X0Y0_傷下.Dra;
			}
			set
			{
				this.X0Y0_傷下.Dra = value;
				this.X0Y1_傷下.Dra = value;
				this.X0Y2_傷下.Dra = value;
				this.X0Y3_傷下.Dra = value;
				this.X0Y4_傷下.Dra = value;
				this.X0Y0_傷下.Hit = value;
				this.X0Y1_傷下.Hit = value;
				this.X0Y2_傷下.Hit = value;
				this.X0Y3_傷下.Hit = value;
				this.X0Y4_傷下.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.傷上_表示;
			}
			set
			{
				this.傷上_表示 = value;
				this.傷下_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.傷上CD.不透明度;
			}
			set
			{
				this.傷上CD.不透明度 = value;
				this.傷下CD.不透明度 = value;
			}
		}

		public override double 肥大
		{
			set
			{
			}
		}

		public override double 身長
		{
			set
			{
			}
		}

		public override void 色更新()
		{
			switch (this.本体.IndexY)
			{
			case 0:
				this.X0Y0_傷上CP.Update();
				this.X0Y0_傷下CP.Update();
				return;
			case 1:
				this.X0Y1_傷上CP.Update();
				this.X0Y1_傷下CP.Update();
				return;
			case 2:
				this.X0Y2_傷上CP.Update();
				this.X0Y2_傷下CP.Update();
				return;
			case 3:
				this.X0Y3_傷上CP.Update();
				this.X0Y3_傷下CP.Update();
				return;
			default:
				this.X0Y4_傷上CP.Update();
				this.X0Y4_傷下CP.Update();
				return;
			}
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.傷上CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷下CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
		}

		public Par X0Y0_傷上;

		public Par X0Y0_傷下;

		public Par X0Y1_傷上;

		public Par X0Y1_傷下;

		public Par X0Y2_傷上;

		public Par X0Y2_傷下;

		public Par X0Y3_傷上;

		public Par X0Y3_傷下;

		public Par X0Y4_傷上;

		public Par X0Y4_傷下;

		public ColorD 傷上CD;

		public ColorD 傷下CD;

		public ColorP X0Y0_傷上CP;

		public ColorP X0Y0_傷下CP;

		public ColorP X0Y1_傷上CP;

		public ColorP X0Y1_傷下CP;

		public ColorP X0Y2_傷上CP;

		public ColorP X0Y2_傷下CP;

		public ColorP X0Y3_傷上CP;

		public ColorP X0Y3_傷下CP;

		public ColorP X0Y4_傷上CP;

		public ColorP X0Y4_傷下CP;
	}
}
