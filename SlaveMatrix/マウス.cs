using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class マウス : Ele
	{
		public マウス(double DisUnit, 配色指定 配色指定, 主人公配色 体配色, Med Med, マウスD e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.カ\u30FCソル["マウス"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_上唇 = pars["上唇"].ToPar();
			this.X0Y0_下唇 = pars["下唇"].ToPar();
			pars = this.本体[1][0];
			this.X1Y0_上唇 = pars["上唇"].ToPar();
			this.X1Y0_下唇 = pars["下唇"].ToPar();
			pars = this.本体[2][0];
			this.X2Y0_舌 = pars["舌"].ToPar();
			this.X2Y0_上唇 = pars["上唇"].ToPar();
			this.X2Y0_下唇 = pars["下唇"].ToPar();
			pars = this.本体[3][0];
			this.X3Y0_舌 = pars["舌"].ToPar();
			this.X3Y0_上唇 = pars["上唇"].ToPar();
			this.X3Y0_下唇 = pars["下唇"].ToPar();
			pars = this.本体[3][1];
			this.X3Y1_舌 = pars["舌"].ToPar();
			this.X3Y1_上唇 = pars["上唇"].ToPar();
			this.X3Y1_下唇 = pars["下唇"].ToPar();
			pars = this.本体[3][2];
			this.X3Y2_舌 = pars["舌"].ToPar();
			this.X3Y2_上唇 = pars["上唇"].ToPar();
			this.X3Y2_下唇 = pars["下唇"].ToPar();
			pars = this.本体[3][3];
			this.X3Y3_舌 = pars["舌"].ToPar();
			this.X3Y3_上唇 = pars["上唇"].ToPar();
			this.X3Y3_下唇 = pars["下唇"].ToPar();
			pars = this.本体[3][4];
			this.X3Y4_舌 = pars["舌"].ToPar();
			this.X3Y4_上唇 = pars["上唇"].ToPar();
			this.X3Y4_下唇 = pars["下唇"].ToPar();
			pars = this.本体[4][0];
			this.X4Y0_舌 = pars["舌"].ToPar();
			this.X4Y0_上唇 = pars["上唇"].ToPar();
			this.X4Y0_下唇 = pars["下唇"].ToPar();
			pars = this.本体[4][1];
			this.X4Y1_舌 = pars["舌"].ToPar();
			this.X4Y1_上唇 = pars["上唇"].ToPar();
			this.X4Y1_下唇 = pars["下唇"].ToPar();
			pars = this.本体[4][2];
			this.X4Y2_舌 = pars["舌"].ToPar();
			this.X4Y2_上唇 = pars["上唇"].ToPar();
			this.X4Y2_下唇 = pars["下唇"].ToPar();
			pars = this.本体[4][3];
			this.X4Y3_舌 = pars["舌"].ToPar();
			this.X4Y3_上唇 = pars["上唇"].ToPar();
			this.X4Y3_下唇 = pars["下唇"].ToPar();
			pars = this.本体[4][4];
			this.X4Y4_舌 = pars["舌"].ToPar();
			this.X4Y4_上唇 = pars["上唇"].ToPar();
			this.X4Y4_下唇 = pars["下唇"].ToPar();
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
			this.上唇_表示 = e.上唇_表示;
			this.下唇_表示 = e.下唇_表示;
			this.舌_表示 = e.舌_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_上唇CP = new ColorP(this.X0Y0_上唇, this.上唇CD, DisUnit, true);
			this.X0Y0_下唇CP = new ColorP(this.X0Y0_下唇, this.下唇CD, DisUnit, true);
			this.X1Y0_上唇CP = new ColorP(this.X1Y0_上唇, this.上唇CD, DisUnit, true);
			this.X1Y0_下唇CP = new ColorP(this.X1Y0_下唇, this.下唇CD, DisUnit, true);
			this.X2Y0_舌CP = new ColorP(this.X2Y0_舌, this.舌CD, DisUnit, true);
			this.X2Y0_上唇CP = new ColorP(this.X2Y0_上唇, this.上唇CD, DisUnit, true);
			this.X2Y0_下唇CP = new ColorP(this.X2Y0_下唇, this.下唇CD, DisUnit, true);
			this.X3Y0_舌CP = new ColorP(this.X3Y0_舌, this.舌CD, DisUnit, true);
			this.X3Y0_上唇CP = new ColorP(this.X3Y0_上唇, this.上唇CD, DisUnit, true);
			this.X3Y0_下唇CP = new ColorP(this.X3Y0_下唇, this.下唇CD, DisUnit, true);
			this.X3Y1_舌CP = new ColorP(this.X3Y1_舌, this.舌CD, DisUnit, true);
			this.X3Y1_上唇CP = new ColorP(this.X3Y1_上唇, this.上唇CD, DisUnit, true);
			this.X3Y1_下唇CP = new ColorP(this.X3Y1_下唇, this.下唇CD, DisUnit, true);
			this.X3Y2_舌CP = new ColorP(this.X3Y2_舌, this.舌CD, DisUnit, true);
			this.X3Y2_上唇CP = new ColorP(this.X3Y2_上唇, this.上唇CD, DisUnit, true);
			this.X3Y2_下唇CP = new ColorP(this.X3Y2_下唇, this.下唇CD, DisUnit, true);
			this.X3Y3_舌CP = new ColorP(this.X3Y3_舌, this.舌CD, DisUnit, true);
			this.X3Y3_上唇CP = new ColorP(this.X3Y3_上唇, this.上唇CD, DisUnit, true);
			this.X3Y3_下唇CP = new ColorP(this.X3Y3_下唇, this.下唇CD, DisUnit, true);
			this.X3Y4_舌CP = new ColorP(this.X3Y4_舌, this.舌CD, DisUnit, true);
			this.X3Y4_上唇CP = new ColorP(this.X3Y4_上唇, this.上唇CD, DisUnit, true);
			this.X3Y4_下唇CP = new ColorP(this.X3Y4_下唇, this.下唇CD, DisUnit, true);
			this.X4Y0_舌CP = new ColorP(this.X4Y0_舌, this.舌CD, DisUnit, true);
			this.X4Y0_上唇CP = new ColorP(this.X4Y0_上唇, this.上唇CD, DisUnit, true);
			this.X4Y0_下唇CP = new ColorP(this.X4Y0_下唇, this.下唇CD, DisUnit, true);
			this.X4Y1_舌CP = new ColorP(this.X4Y1_舌, this.舌CD, DisUnit, true);
			this.X4Y1_上唇CP = new ColorP(this.X4Y1_上唇, this.上唇CD, DisUnit, true);
			this.X4Y1_下唇CP = new ColorP(this.X4Y1_下唇, this.下唇CD, DisUnit, true);
			this.X4Y2_舌CP = new ColorP(this.X4Y2_舌, this.舌CD, DisUnit, true);
			this.X4Y2_上唇CP = new ColorP(this.X4Y2_上唇, this.上唇CD, DisUnit, true);
			this.X4Y2_下唇CP = new ColorP(this.X4Y2_下唇, this.下唇CD, DisUnit, true);
			this.X4Y3_舌CP = new ColorP(this.X4Y3_舌, this.舌CD, DisUnit, true);
			this.X4Y3_上唇CP = new ColorP(this.X4Y3_上唇, this.上唇CD, DisUnit, true);
			this.X4Y3_下唇CP = new ColorP(this.X4Y3_下唇, this.下唇CD, DisUnit, true);
			this.X4Y4_舌CP = new ColorP(this.X4Y4_舌, this.舌CD, DisUnit, true);
			this.X4Y4_上唇CP = new ColorP(this.X4Y4_上唇, this.上唇CD, DisUnit, true);
			this.X4Y4_下唇CP = new ColorP(this.X4Y4_下唇, this.下唇CD, DisUnit, true);
			this.濃度 = e.濃度;
			this.X4Y0_上唇.BasePointBase = this.X4Y0_上唇.ToLocal(this.X4Y0_舌.ToGlobal(this.X4Y0_舌.JP[0].Joint));
			this.X4Y1_上唇.BasePointBase = this.X4Y1_上唇.ToLocal(this.X4Y1_舌.ToGlobal(this.X4Y1_舌.JP[0].Joint));
			this.X4Y2_上唇.BasePointBase = this.X4Y2_上唇.ToLocal(this.X4Y2_舌.ToGlobal(this.X4Y2_舌.JP[0].Joint));
			this.X4Y3_上唇.BasePointBase = this.X4Y3_上唇.ToLocal(this.X4Y3_舌.ToGlobal(this.X4Y3_舌.JP[0].Joint));
			this.X4Y4_上唇.BasePointBase = this.X4Y4_上唇.ToLocal(this.X4Y4_舌.ToGlobal(this.X4Y4_舌.JP[0].Joint));
			this.尺度B = 1.08;
			this.本体.JoinPAall();
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

		public bool 上唇_表示
		{
			get
			{
				return this.X0Y0_上唇.Dra;
			}
			set
			{
				this.X0Y0_上唇.Dra = value;
				this.X1Y0_上唇.Dra = value;
				this.X2Y0_上唇.Dra = value;
				this.X3Y0_上唇.Dra = value;
				this.X3Y1_上唇.Dra = value;
				this.X3Y2_上唇.Dra = value;
				this.X3Y3_上唇.Dra = value;
				this.X3Y4_上唇.Dra = value;
				this.X4Y0_上唇.Dra = value;
				this.X4Y1_上唇.Dra = value;
				this.X4Y2_上唇.Dra = value;
				this.X4Y3_上唇.Dra = value;
				this.X4Y4_上唇.Dra = value;
				this.X0Y0_上唇.Hit = value;
				this.X1Y0_上唇.Hit = value;
				this.X2Y0_上唇.Hit = value;
				this.X3Y0_上唇.Hit = value;
				this.X3Y1_上唇.Hit = value;
				this.X3Y2_上唇.Hit = value;
				this.X3Y3_上唇.Hit = value;
				this.X3Y4_上唇.Hit = value;
				this.X4Y0_上唇.Hit = value;
				this.X4Y1_上唇.Hit = value;
				this.X4Y2_上唇.Hit = value;
				this.X4Y3_上唇.Hit = value;
				this.X4Y4_上唇.Hit = value;
			}
		}

		public bool 下唇_表示
		{
			get
			{
				return this.X0Y0_下唇.Dra;
			}
			set
			{
				this.X0Y0_下唇.Dra = value;
				this.X1Y0_下唇.Dra = value;
				this.X2Y0_下唇.Dra = value;
				this.X3Y0_下唇.Dra = value;
				this.X3Y1_下唇.Dra = value;
				this.X3Y2_下唇.Dra = value;
				this.X3Y3_下唇.Dra = value;
				this.X3Y4_下唇.Dra = value;
				this.X4Y0_下唇.Dra = value;
				this.X4Y1_下唇.Dra = value;
				this.X4Y2_下唇.Dra = value;
				this.X4Y3_下唇.Dra = value;
				this.X4Y4_下唇.Dra = value;
				this.X0Y0_下唇.Hit = value;
				this.X1Y0_下唇.Hit = value;
				this.X2Y0_下唇.Hit = value;
				this.X3Y0_下唇.Hit = value;
				this.X3Y1_下唇.Hit = value;
				this.X3Y2_下唇.Hit = value;
				this.X3Y3_下唇.Hit = value;
				this.X3Y4_下唇.Hit = value;
				this.X4Y0_下唇.Hit = value;
				this.X4Y1_下唇.Hit = value;
				this.X4Y2_下唇.Hit = value;
				this.X4Y3_下唇.Hit = value;
				this.X4Y4_下唇.Hit = value;
			}
		}

		public bool 舌_表示
		{
			get
			{
				return this.X2Y0_舌.Dra;
			}
			set
			{
				this.X2Y0_舌.Dra = value;
				this.X3Y0_舌.Dra = value;
				this.X3Y1_舌.Dra = value;
				this.X3Y2_舌.Dra = value;
				this.X3Y3_舌.Dra = value;
				this.X3Y4_舌.Dra = value;
				this.X4Y0_舌.Dra = value;
				this.X4Y1_舌.Dra = value;
				this.X4Y2_舌.Dra = value;
				this.X4Y3_舌.Dra = value;
				this.X4Y4_舌.Dra = value;
				this.X2Y0_舌.Hit = value;
				this.X3Y0_舌.Hit = value;
				this.X3Y1_舌.Hit = value;
				this.X3Y2_舌.Hit = value;
				this.X3Y3_舌.Hit = value;
				this.X3Y4_舌.Hit = value;
				this.X4Y0_舌.Hit = value;
				this.X4Y1_舌.Hit = value;
				this.X4Y2_舌.Hit = value;
				this.X4Y3_舌.Hit = value;
				this.X4Y4_舌.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.上唇_表示;
			}
			set
			{
				this.上唇_表示 = value;
				this.下唇_表示 = value;
				this.舌_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.舌CD.不透明度;
			}
			set
			{
				this.舌CD.不透明度 = value;
				this.上唇CD.不透明度 = value;
				this.下唇CD.不透明度 = value;
			}
		}

		public override void 描画0(Are Are)
		{
			switch (this.本体.IndexX)
			{
			case 2:
				Are.Draw(this.X2Y0_舌);
				return;
			case 3:
				switch (this.本体.IndexY)
				{
				case 0:
					Are.Draw(this.X3Y0_舌);
					return;
				case 1:
					Are.Draw(this.X3Y1_舌);
					return;
				case 2:
					Are.Draw(this.X3Y2_舌);
					return;
				case 3:
					Are.Draw(this.X3Y3_舌);
					return;
				default:
					Are.Draw(this.X3Y4_舌);
					return;
				}
				break;
			case 4:
				switch (this.本体.IndexY)
				{
				case 0:
					Are.Draw(this.X4Y0_舌);
					return;
				case 1:
					Are.Draw(this.X4Y1_舌);
					return;
				case 2:
					Are.Draw(this.X4Y2_舌);
					return;
				case 3:
					Are.Draw(this.X4Y3_舌);
					return;
				default:
					Are.Draw(this.X4Y4_舌);
					return;
				}
				break;
			default:
				return;
			}
		}

		public override void 描画1(Are Are)
		{
			switch (this.本体.IndexX)
			{
			case 0:
				Are.Draw(this.X0Y0_上唇);
				Are.Draw(this.X0Y0_下唇);
				return;
			case 1:
				Are.Draw(this.X1Y0_上唇);
				Are.Draw(this.X1Y0_下唇);
				return;
			case 2:
				Are.Draw(this.X2Y0_上唇);
				Are.Draw(this.X2Y0_下唇);
				return;
			case 3:
				switch (this.本体.IndexY)
				{
				case 0:
					Are.Draw(this.X3Y0_上唇);
					Are.Draw(this.X3Y0_下唇);
					return;
				case 1:
					Are.Draw(this.X3Y1_上唇);
					Are.Draw(this.X3Y1_下唇);
					return;
				case 2:
					Are.Draw(this.X3Y2_上唇);
					Are.Draw(this.X3Y2_下唇);
					return;
				case 3:
					Are.Draw(this.X3Y3_上唇);
					Are.Draw(this.X3Y3_下唇);
					return;
				default:
					Are.Draw(this.X3Y4_上唇);
					Are.Draw(this.X3Y4_下唇);
					return;
				}
				break;
			default:
				switch (this.本体.IndexY)
				{
				case 0:
					Are.Draw(this.X4Y0_上唇);
					Are.Draw(this.X4Y0_下唇);
					return;
				case 1:
					Are.Draw(this.X4Y1_上唇);
					Are.Draw(this.X4Y1_下唇);
					return;
				case 2:
					Are.Draw(this.X4Y2_上唇);
					Are.Draw(this.X4Y2_下唇);
					return;
				case 3:
					Are.Draw(this.X4Y3_上唇);
					Are.Draw(this.X4Y3_下唇);
					return;
				default:
					Are.Draw(this.X4Y4_上唇);
					Are.Draw(this.X4Y4_下唇);
					return;
				}
				break;
			}
		}

		public override void 色更新()
		{
			switch (this.本体.IndexX)
			{
			case 0:
				this.X0Y0_上唇CP.Update();
				this.X0Y0_下唇CP.Update();
				return;
			case 1:
				this.X1Y0_上唇CP.Update();
				this.X1Y0_下唇CP.Update();
				return;
			case 2:
				this.X2Y0_舌CP.Update();
				this.X2Y0_上唇CP.Update();
				this.X2Y0_下唇CP.Update();
				return;
			case 3:
				switch (this.本体.IndexY)
				{
				case 0:
					this.X3Y0_舌CP.Update();
					this.X3Y0_上唇CP.Update();
					this.X3Y0_下唇CP.Update();
					return;
				case 1:
					this.X3Y1_舌CP.Update();
					this.X3Y1_上唇CP.Update();
					this.X3Y1_下唇CP.Update();
					return;
				case 2:
					this.X3Y2_舌CP.Update();
					this.X3Y2_上唇CP.Update();
					this.X3Y2_下唇CP.Update();
					return;
				case 3:
					this.X3Y3_舌CP.Update();
					this.X3Y3_上唇CP.Update();
					this.X3Y3_下唇CP.Update();
					return;
				default:
					this.X3Y4_舌CP.Update();
					this.X3Y4_上唇CP.Update();
					this.X3Y4_下唇CP.Update();
					return;
				}
				break;
			default:
				switch (this.本体.IndexY)
				{
				case 0:
					this.X4Y0_舌CP.Update();
					this.X4Y0_上唇CP.Update();
					this.X4Y0_下唇CP.Update();
					return;
				case 1:
					this.X4Y1_舌CP.Update();
					this.X4Y1_上唇CP.Update();
					this.X4Y1_下唇CP.Update();
					return;
				case 2:
					this.X4Y2_舌CP.Update();
					this.X4Y2_上唇CP.Update();
					this.X4Y2_下唇CP.Update();
					return;
				case 3:
					this.X4Y3_舌CP.Update();
					this.X4Y3_上唇CP.Update();
					this.X4Y3_下唇CP.Update();
					return;
				default:
					this.X4Y4_舌CP.Update();
					this.X4Y4_上唇CP.Update();
					this.X4Y4_下唇CP.Update();
					return;
				}
				break;
			}
		}

		private void 配色(主人公配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(主人公配色 体配色)
		{
			this.舌CD = new ColorD(ref 体配色.粘線, ref 体配色.粘膜);
			this.上唇CD = new ColorD(ref 体配色.粘線, ref 体配色.粘膜);
			this.下唇CD = new ColorD(ref 体配色.粘線, ref 体配色.粘膜);
		}

		public void 再配色(主人公配色 体配色)
		{
			this.舌CD.線 = 体配色.粘線;
			this.舌CD.色 = 体配色.粘膜;
			this.上唇CD.線 = 体配色.粘線;
			this.上唇CD.色 = 体配色.粘膜;
			this.下唇CD.線 = 体配色.粘線;
			this.下唇CD.色 = 体配色.粘膜;
		}

		public Par X0Y0_上唇;

		public Par X0Y0_下唇;

		public Par X1Y0_上唇;

		public Par X1Y0_下唇;

		public Par X2Y0_舌;

		public Par X2Y0_上唇;

		public Par X2Y0_下唇;

		public Par X3Y0_舌;

		public Par X3Y0_上唇;

		public Par X3Y0_下唇;

		public Par X3Y1_舌;

		public Par X3Y1_上唇;

		public Par X3Y1_下唇;

		public Par X3Y2_舌;

		public Par X3Y2_上唇;

		public Par X3Y2_下唇;

		public Par X3Y3_舌;

		public Par X3Y3_上唇;

		public Par X3Y3_下唇;

		public Par X3Y4_舌;

		public Par X3Y4_上唇;

		public Par X3Y4_下唇;

		public Par X4Y0_舌;

		public Par X4Y0_上唇;

		public Par X4Y0_下唇;

		public Par X4Y1_舌;

		public Par X4Y1_上唇;

		public Par X4Y1_下唇;

		public Par X4Y2_舌;

		public Par X4Y2_上唇;

		public Par X4Y2_下唇;

		public Par X4Y3_舌;

		public Par X4Y3_上唇;

		public Par X4Y3_下唇;

		public Par X4Y4_舌;

		public Par X4Y4_上唇;

		public Par X4Y4_下唇;

		public ColorD 舌CD;

		public ColorD 上唇CD;

		public ColorD 下唇CD;

		public ColorP X0Y0_上唇CP;

		public ColorP X0Y0_下唇CP;

		public ColorP X1Y0_上唇CP;

		public ColorP X1Y0_下唇CP;

		public ColorP X2Y0_舌CP;

		public ColorP X2Y0_上唇CP;

		public ColorP X2Y0_下唇CP;

		public ColorP X3Y0_舌CP;

		public ColorP X3Y0_上唇CP;

		public ColorP X3Y0_下唇CP;

		public ColorP X3Y1_舌CP;

		public ColorP X3Y1_上唇CP;

		public ColorP X3Y1_下唇CP;

		public ColorP X3Y2_舌CP;

		public ColorP X3Y2_上唇CP;

		public ColorP X3Y2_下唇CP;

		public ColorP X3Y3_舌CP;

		public ColorP X3Y3_上唇CP;

		public ColorP X3Y3_下唇CP;

		public ColorP X3Y4_舌CP;

		public ColorP X3Y4_上唇CP;

		public ColorP X3Y4_下唇CP;

		public ColorP X4Y0_舌CP;

		public ColorP X4Y0_上唇CP;

		public ColorP X4Y0_下唇CP;

		public ColorP X4Y1_舌CP;

		public ColorP X4Y1_上唇CP;

		public ColorP X4Y1_下唇CP;

		public ColorP X4Y2_舌CP;

		public ColorP X4Y2_上唇CP;

		public ColorP X4Y2_下唇CP;

		public ColorP X4Y3_舌CP;

		public ColorP X4Y3_上唇CP;

		public ColorP X4Y3_下唇CP;

		public ColorP X4Y4_舌CP;

		public ColorP X4Y4_上唇CP;

		public ColorP X4Y4_下唇CP;
	}
}
