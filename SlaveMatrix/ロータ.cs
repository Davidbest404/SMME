using System;
using System.Drawing;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class ロ\u30FCタ : Ele
	{
		public ロ\u30FCタ(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, ロ\u30FCタD e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.カ\u30FCソル["ロータ"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_ロ\u30FCタ = pars["ロータ"].ToPar();
			this.X0Y0_ロ\u30FCタ線 = pars["ロータ線"].ToPar();
			this.X0Y0_コ\u30FCド = pars["コード"].ToPar();
			pars = this.本体[0][1];
			this.X0Y1_ロ\u30FCタ = pars["ロータ"].ToPar();
			this.X0Y1_ロ\u30FCタ線 = pars["ロータ線"].ToPar();
			this.X0Y1_コ\u30FCド = pars["コード"].ToPar();
			pars = this.本体[0][2];
			this.X0Y2_ロ\u30FCタ = pars["ロータ"].ToPar();
			this.X0Y2_ロ\u30FCタ線 = pars["ロータ線"].ToPar();
			this.X0Y2_コ\u30FCド = pars["コード"].ToPar();
			pars = this.本体[0][3];
			this.X0Y3_ロ\u30FCタ = pars["ロータ"].ToPar();
			this.X0Y3_コ\u30FCド = pars["コード"].ToPar();
			pars = this.本体[0][4];
			this.X0Y4_ロ\u30FCタ = pars["ロータ"].ToPar();
			this.X0Y4_コ\u30FCド = pars["コード"].ToPar();
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
			this.ロ\u30FCタ_表示 = e.ロ\u30FCタ_表示;
			this.ロ\u30FCタ線_表示 = e.ロ\u30FCタ線_表示;
			this.コ\u30FCド_表示 = e.コ\u30FCド_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_ロ\u30FCタCP = new ColorP(this.X0Y0_ロ\u30FCタ, this.ロ\u30FCタCD, DisUnit, true);
			this.X0Y0_ロ\u30FCタ線CP = new ColorP(this.X0Y0_ロ\u30FCタ線, this.ロ\u30FCタ線CD, DisUnit, true);
			this.X0Y0_コ\u30FCドCP = new ColorP(this.X0Y0_コ\u30FCド, this.コ\u30FCドCD, DisUnit, true);
			this.X0Y1_ロ\u30FCタCP = new ColorP(this.X0Y1_ロ\u30FCタ, this.ロ\u30FCタCD, DisUnit, true);
			this.X0Y1_ロ\u30FCタ線CP = new ColorP(this.X0Y1_ロ\u30FCタ線, this.ロ\u30FCタ線CD, DisUnit, true);
			this.X0Y1_コ\u30FCドCP = new ColorP(this.X0Y1_コ\u30FCド, this.コ\u30FCドCD, DisUnit, true);
			this.X0Y2_ロ\u30FCタCP = new ColorP(this.X0Y2_ロ\u30FCタ, this.ロ\u30FCタCD, DisUnit, true);
			this.X0Y2_ロ\u30FCタ線CP = new ColorP(this.X0Y2_ロ\u30FCタ線, this.ロ\u30FCタ線CD, DisUnit, true);
			this.X0Y2_コ\u30FCドCP = new ColorP(this.X0Y2_コ\u30FCド, this.コ\u30FCドCD, DisUnit, true);
			this.X0Y3_ロ\u30FCタCP = new ColorP(this.X0Y3_ロ\u30FCタ, this.ロ\u30FCタCD, DisUnit, true);
			this.X0Y3_コ\u30FCドCP = new ColorP(this.X0Y3_コ\u30FCド, this.コ\u30FCドCD, DisUnit, true);
			this.X0Y4_ロ\u30FCタCP = new ColorP(this.X0Y4_ロ\u30FCタ, this.ロ\u30FCタCD, DisUnit, true);
			this.X0Y4_コ\u30FCドCP = new ColorP(this.X0Y4_コ\u30FCド, this.コ\u30FCドCD, DisUnit, true);
			this.濃度 = e.濃度;
			this.X0Y0_ロ\u30FCタ.BasePointBase = this.X0Y0_ロ\u30FCタ.ToLocal(this.X0Y0_ロ\u30FCタ.ToGlobal(this.X0Y0_ロ\u30FCタ.JP[2].Joint));
			this.X0Y1_ロ\u30FCタ.BasePointBase = this.X0Y1_ロ\u30FCタ.ToLocal(this.X0Y1_ロ\u30FCタ.ToGlobal(this.X0Y1_ロ\u30FCタ.JP[2].Joint));
			this.X0Y2_ロ\u30FCタ.BasePointBase = this.X0Y2_ロ\u30FCタ.ToLocal(this.X0Y2_ロ\u30FCタ.ToGlobal(this.X0Y2_ロ\u30FCタ.JP[2].Joint));
			this.X0Y3_ロ\u30FCタ.BasePointBase = this.X0Y3_ロ\u30FCタ.ToLocal(this.X0Y3_ロ\u30FCタ.ToGlobal(this.X0Y3_ロ\u30FCタ.JP[1].Joint));
			this.X0Y4_ロ\u30FCタ.BasePointBase = this.X0Y4_ロ\u30FCタ.ToLocal(this.X0Y4_ロ\u30FCタ.ToGlobal(this.X0Y4_ロ\u30FCタ.JP[1].Joint));
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

		public bool ロ\u30FCタ_表示
		{
			get
			{
				return this.X0Y0_ロ\u30FCタ.Dra;
			}
			set
			{
				this.X0Y0_ロ\u30FCタ.Dra = value;
				this.X0Y1_ロ\u30FCタ.Dra = value;
				this.X0Y2_ロ\u30FCタ.Dra = value;
				this.X0Y3_ロ\u30FCタ.Dra = value;
				this.X0Y4_ロ\u30FCタ.Dra = value;
				this.X0Y0_ロ\u30FCタ.Hit = value;
				this.X0Y1_ロ\u30FCタ.Hit = value;
				this.X0Y2_ロ\u30FCタ.Hit = value;
				this.X0Y3_ロ\u30FCタ.Hit = value;
				this.X0Y4_ロ\u30FCタ.Hit = value;
			}
		}

		public bool ロ\u30FCタ線_表示
		{
			get
			{
				return this.X0Y0_ロ\u30FCタ線.Dra;
			}
			set
			{
				this.X0Y0_ロ\u30FCタ線.Dra = value;
				this.X0Y1_ロ\u30FCタ線.Dra = value;
				this.X0Y2_ロ\u30FCタ線.Dra = value;
				this.X0Y0_ロ\u30FCタ線.Hit = value;
				this.X0Y1_ロ\u30FCタ線.Hit = value;
				this.X0Y2_ロ\u30FCタ線.Hit = value;
			}
		}

		public bool コ\u30FCド_表示
		{
			get
			{
				return this.X0Y0_コ\u30FCド.Dra;
			}
			set
			{
				this.X0Y0_コ\u30FCド.Dra = value;
				this.X0Y1_コ\u30FCド.Dra = value;
				this.X0Y2_コ\u30FCド.Dra = value;
				this.X0Y3_コ\u30FCド.Dra = value;
				this.X0Y4_コ\u30FCド.Dra = value;
				this.X0Y0_コ\u30FCド.Hit = value;
				this.X0Y1_コ\u30FCド.Hit = value;
				this.X0Y2_コ\u30FCド.Hit = value;
				this.X0Y3_コ\u30FCド.Hit = value;
				this.X0Y4_コ\u30FCド.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.ロ\u30FCタ_表示;
			}
			set
			{
				this.ロ\u30FCタ_表示 = value;
				this.ロ\u30FCタ線_表示 = value;
				this.コ\u30FCド_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.ロ\u30FCタCD.不透明度;
			}
			set
			{
				this.ロ\u30FCタCD.不透明度 = value;
				this.ロ\u30FCタ線CD.不透明度 = value;
				this.コ\u30FCドCD.不透明度 = value;
			}
		}

		public override void 色更新()
		{
			switch (this.本体.IndexY)
			{
			case 0:
				this.X0Y0_ロ\u30FCタCP.Update();
				this.X0Y0_ロ\u30FCタ線CP.Update();
				this.X0Y0_コ\u30FCドCP.Update();
				return;
			case 1:
				this.X0Y1_ロ\u30FCタCP.Update();
				this.X0Y1_ロ\u30FCタ線CP.Update();
				this.X0Y1_コ\u30FCドCP.Update();
				return;
			case 2:
				this.X0Y2_ロ\u30FCタCP.Update();
				this.X0Y2_ロ\u30FCタ線CP.Update();
				this.X0Y2_コ\u30FCドCP.Update();
				return;
			case 3:
				this.X0Y3_ロ\u30FCタCP.Update();
				this.X0Y3_コ\u30FCドCP.Update();
				return;
			default:
				this.X0Y4_ロ\u30FCタCP.Update();
				this.X0Y4_コ\u30FCドCP.Update();
				return;
			}
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			Color2 color;
			Col.GetGrad(ref Col.Violet, out color);
			this.ロ\u30FCタCD = new ColorD(ref Col.Black, ref color);
			this.ロ\u30FCタ線CD = new ColorD(ref Col.Black, ref color);
			color.Col2 = Color.FromArgb(0, color.Col2);
			this.コ\u30FCドCD = new ColorD(ref Col.Black, ref color);
		}

		public Par X0Y0_ロ\u30FCタ;

		public Par X0Y0_ロ\u30FCタ線;

		public Par X0Y0_コ\u30FCド;

		public Par X0Y1_ロ\u30FCタ;

		public Par X0Y1_ロ\u30FCタ線;

		public Par X0Y1_コ\u30FCド;

		public Par X0Y2_ロ\u30FCタ;

		public Par X0Y2_ロ\u30FCタ線;

		public Par X0Y2_コ\u30FCド;

		public Par X0Y3_ロ\u30FCタ;

		public Par X0Y3_コ\u30FCド;

		public Par X0Y4_ロ\u30FCタ;

		public Par X0Y4_コ\u30FCド;

		public ColorD ロ\u30FCタCD;

		public ColorD ロ\u30FCタ線CD;

		public ColorD コ\u30FCドCD;

		public ColorP X0Y0_ロ\u30FCタCP;

		public ColorP X0Y0_ロ\u30FCタ線CP;

		public ColorP X0Y0_コ\u30FCドCP;

		public ColorP X0Y1_ロ\u30FCタCP;

		public ColorP X0Y1_ロ\u30FCタ線CP;

		public ColorP X0Y1_コ\u30FCドCP;

		public ColorP X0Y2_ロ\u30FCタCP;

		public ColorP X0Y2_ロ\u30FCタ線CP;

		public ColorP X0Y2_コ\u30FCドCP;

		public ColorP X0Y3_ロ\u30FCタCP;

		public ColorP X0Y3_コ\u30FCドCP;

		public ColorP X0Y4_ロ\u30FCタCP;

		public ColorP X0Y4_コ\u30FCドCP;
	}
}
