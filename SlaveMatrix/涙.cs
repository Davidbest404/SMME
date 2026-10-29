using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 涙 : Ele
	{
		public 涙(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 涙D e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.胴体["涙左"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_涙0流れ0 = pars["涙0流れ0"].ToPar();
			this.X0Y0_涙0 = pars["涙0"].ToPar();
			this.X0Y0_涙1 = pars["涙1"].ToPar();
			this.X0Y0_涙ハイライト = pars["涙ハイライト"].ToPar();
			pars = this.本体[0][1];
			this.X0Y1_涙0流れ0 = pars["涙0流れ0"].ToPar();
			this.X0Y1_涙0流れ1 = pars["涙0流れ1"].ToPar();
			this.X0Y1_涙0 = pars["涙0"].ToPar();
			this.X0Y1_涙1 = pars["涙1"].ToPar();
			this.X0Y1_涙ハイライト = pars["涙ハイライト"].ToPar();
			pars = this.本体[0][2];
			this.X0Y2_涙0流れ0 = pars["涙0流れ0"].ToPar();
			this.X0Y2_涙0流れ1 = pars["涙0流れ1"].ToPar();
			this.X0Y2_涙0 = pars["涙0"].ToPar();
			this.X0Y2_涙1 = pars["涙1"].ToPar();
			this.X0Y2_涙ハイライト = pars["涙ハイライト"].ToPar();
			pars = this.本体[0][3];
			this.X0Y3_涙0流れ0 = pars["涙0流れ0"].ToPar();
			this.X0Y3_涙0流れ1 = pars["涙0流れ1"].ToPar();
			this.X0Y3_涙0 = pars["涙0"].ToPar();
			this.X0Y3_涙1 = pars["涙1"].ToPar();
			this.X0Y3_涙ハイライト = pars["涙ハイライト"].ToPar();
			pars = this.本体[0][4];
			this.X0Y4_涙0流れ0 = pars["涙0流れ0"].ToPar();
			this.X0Y4_涙0流れ1 = pars["涙0流れ1"].ToPar();
			this.X0Y4_涙0 = pars["涙0"].ToPar();
			this.X0Y4_涙1 = pars["涙1"].ToPar();
			this.X0Y4_涙ハイライト = pars["涙ハイライト"].ToPar();
			pars = this.本体[0][5];
			this.X0Y5_涙0流れ0 = pars["涙0流れ0"].ToPar();
			this.X0Y5_涙0流れ1 = pars["涙0流れ1"].ToPar();
			this.X0Y5_涙0 = pars["涙0"].ToPar();
			this.X0Y5_涙1 = pars["涙1"].ToPar();
			this.X0Y5_涙ハイライト = pars["涙ハイライト"].ToPar();
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
			this.涙0流れ0_表示 = e.涙0流れ0_表示;
			this.涙0_表示 = e.涙0_表示;
			this.涙1_表示 = e.涙1_表示;
			this.涙ハイライト_表示 = e.涙ハイライト_表示;
			this.涙0流れ1_表示 = e.涙0流れ1_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_涙0流れ0CP = new ColorP(this.X0Y0_涙0流れ0, this.涙0流れ0CD, DisUnit, true);
			this.X0Y0_涙0CP = new ColorP(this.X0Y0_涙0, this.涙0CD, DisUnit, true);
			this.X0Y0_涙1CP = new ColorP(this.X0Y0_涙1, this.涙1CD, DisUnit, true);
			this.X0Y0_涙ハイライトCP = new ColorP(this.X0Y0_涙ハイライト, this.涙ハイライトCD, DisUnit, true);
			this.X0Y1_涙0流れ0CP = new ColorP(this.X0Y1_涙0流れ0, this.涙0流れ0CD, DisUnit, true);
			this.X0Y1_涙0流れ1CP = new ColorP(this.X0Y1_涙0流れ1, this.涙0流れ1CD, DisUnit, true);
			this.X0Y1_涙0CP = new ColorP(this.X0Y1_涙0, this.涙0CD, DisUnit, true);
			this.X0Y1_涙1CP = new ColorP(this.X0Y1_涙1, this.涙1CD, DisUnit, true);
			this.X0Y1_涙ハイライトCP = new ColorP(this.X0Y1_涙ハイライト, this.涙ハイライトCD, DisUnit, true);
			this.X0Y2_涙0流れ0CP = new ColorP(this.X0Y2_涙0流れ0, this.涙0流れ0CD, DisUnit, true);
			this.X0Y2_涙0流れ1CP = new ColorP(this.X0Y2_涙0流れ1, this.涙0流れ1CD, DisUnit, true);
			this.X0Y2_涙0CP = new ColorP(this.X0Y2_涙0, this.涙0CD, DisUnit, true);
			this.X0Y2_涙1CP = new ColorP(this.X0Y2_涙1, this.涙1CD, DisUnit, true);
			this.X0Y2_涙ハイライトCP = new ColorP(this.X0Y2_涙ハイライト, this.涙ハイライトCD, DisUnit, true);
			this.X0Y3_涙0流れ0CP = new ColorP(this.X0Y3_涙0流れ0, this.涙0流れ0CD, DisUnit, true);
			this.X0Y3_涙0流れ1CP = new ColorP(this.X0Y3_涙0流れ1, this.涙0流れ1CD, DisUnit, true);
			this.X0Y3_涙0CP = new ColorP(this.X0Y3_涙0, this.涙0CD, DisUnit, true);
			this.X0Y3_涙1CP = new ColorP(this.X0Y3_涙1, this.涙1CD, DisUnit, true);
			this.X0Y3_涙ハイライトCP = new ColorP(this.X0Y3_涙ハイライト, this.涙ハイライトCD, DisUnit, true);
			this.X0Y4_涙0流れ0CP = new ColorP(this.X0Y4_涙0流れ0, this.涙0流れ0CD, DisUnit, true);
			this.X0Y4_涙0流れ1CP = new ColorP(this.X0Y4_涙0流れ1, this.涙0流れ1CD, DisUnit, true);
			this.X0Y4_涙0CP = new ColorP(this.X0Y4_涙0, this.涙0CD, DisUnit, true);
			this.X0Y4_涙1CP = new ColorP(this.X0Y4_涙1, this.涙1CD, DisUnit, true);
			this.X0Y4_涙ハイライトCP = new ColorP(this.X0Y4_涙ハイライト, this.涙ハイライトCD, DisUnit, true);
			this.X0Y5_涙0流れ0CP = new ColorP(this.X0Y5_涙0流れ0, this.涙0流れ0CD, DisUnit, true);
			this.X0Y5_涙0流れ1CP = new ColorP(this.X0Y5_涙0流れ1, this.涙0流れ1CD, DisUnit, true);
			this.X0Y5_涙0CP = new ColorP(this.X0Y5_涙0, this.涙0CD, DisUnit, true);
			this.X0Y5_涙1CP = new ColorP(this.X0Y5_涙1, this.涙1CD, DisUnit, true);
			this.X0Y5_涙ハイライトCP = new ColorP(this.X0Y5_涙ハイライト, this.涙ハイライトCD, DisUnit, true);
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

		public bool 涙0流れ0_表示
		{
			get
			{
				return this.X0Y0_涙0流れ0.Dra;
			}
			set
			{
				this.X0Y0_涙0流れ0.Dra = value;
				this.X0Y1_涙0流れ0.Dra = value;
				this.X0Y2_涙0流れ0.Dra = value;
				this.X0Y3_涙0流れ0.Dra = value;
				this.X0Y4_涙0流れ0.Dra = value;
				this.X0Y5_涙0流れ0.Dra = value;
				this.X0Y0_涙0流れ0.Hit = value;
				this.X0Y1_涙0流れ0.Hit = value;
				this.X0Y2_涙0流れ0.Hit = value;
				this.X0Y3_涙0流れ0.Hit = value;
				this.X0Y4_涙0流れ0.Hit = value;
				this.X0Y5_涙0流れ0.Hit = value;
			}
		}

		public bool 涙0_表示
		{
			get
			{
				return this.X0Y0_涙0.Dra;
			}
			set
			{
				this.X0Y0_涙0.Dra = value;
				this.X0Y1_涙0.Dra = value;
				this.X0Y2_涙0.Dra = value;
				this.X0Y3_涙0.Dra = value;
				this.X0Y4_涙0.Dra = value;
				this.X0Y5_涙0.Dra = value;
				this.X0Y0_涙0.Hit = value;
				this.X0Y1_涙0.Hit = value;
				this.X0Y2_涙0.Hit = value;
				this.X0Y3_涙0.Hit = value;
				this.X0Y4_涙0.Hit = value;
				this.X0Y5_涙0.Hit = value;
			}
		}

		public bool 涙1_表示
		{
			get
			{
				return this.X0Y0_涙1.Dra;
			}
			set
			{
				this.X0Y0_涙1.Dra = value;
				this.X0Y1_涙1.Dra = value;
				this.X0Y2_涙1.Dra = value;
				this.X0Y3_涙1.Dra = value;
				this.X0Y4_涙1.Dra = value;
				this.X0Y5_涙1.Dra = value;
				this.X0Y0_涙1.Hit = value;
				this.X0Y1_涙1.Hit = value;
				this.X0Y2_涙1.Hit = value;
				this.X0Y3_涙1.Hit = value;
				this.X0Y4_涙1.Hit = value;
				this.X0Y5_涙1.Hit = value;
			}
		}

		public bool 涙ハイライト_表示
		{
			get
			{
				return this.X0Y0_涙ハイライト.Dra;
			}
			set
			{
				this.X0Y0_涙ハイライト.Dra = value;
				this.X0Y1_涙ハイライト.Dra = value;
				this.X0Y2_涙ハイライト.Dra = value;
				this.X0Y3_涙ハイライト.Dra = value;
				this.X0Y4_涙ハイライト.Dra = value;
				this.X0Y5_涙ハイライト.Dra = value;
				this.X0Y0_涙ハイライト.Hit = value;
				this.X0Y1_涙ハイライト.Hit = value;
				this.X0Y2_涙ハイライト.Hit = value;
				this.X0Y3_涙ハイライト.Hit = value;
				this.X0Y4_涙ハイライト.Hit = value;
				this.X0Y5_涙ハイライト.Hit = value;
			}
		}

		public bool 涙0流れ1_表示
		{
			get
			{
				return this.X0Y1_涙0流れ1.Dra;
			}
			set
			{
				this.X0Y1_涙0流れ1.Dra = value;
				this.X0Y2_涙0流れ1.Dra = value;
				this.X0Y3_涙0流れ1.Dra = value;
				this.X0Y4_涙0流れ1.Dra = value;
				this.X0Y5_涙0流れ1.Dra = value;
				this.X0Y1_涙0流れ1.Hit = value;
				this.X0Y2_涙0流れ1.Hit = value;
				this.X0Y3_涙0流れ1.Hit = value;
				this.X0Y4_涙0流れ1.Hit = value;
				this.X0Y5_涙0流れ1.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.涙0流れ0_表示;
			}
			set
			{
				this.涙0流れ0_表示 = value;
				this.涙0_表示 = value;
				this.涙1_表示 = value;
				this.涙ハイライト_表示 = value;
				this.涙0流れ1_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.涙0流れ0CD.不透明度;
			}
			set
			{
				this.涙0流れ0CD.不透明度 = value;
				this.涙0流れ1CD.不透明度 = value;
				this.涙0CD.不透明度 = value;
				this.涙1CD.不透明度 = value;
				this.涙ハイライトCD.不透明度 = value;
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
				this.X0Y0_涙0流れ0CP.Update();
				this.X0Y0_涙0CP.Update();
				this.X0Y0_涙1CP.Update();
				this.X0Y0_涙ハイライトCP.Update();
				return;
			case 1:
				this.X0Y1_涙0流れ0CP.Update();
				this.X0Y1_涙0流れ1CP.Update();
				this.X0Y1_涙0CP.Update();
				this.X0Y1_涙1CP.Update();
				this.X0Y1_涙ハイライトCP.Update();
				return;
			case 2:
				this.X0Y2_涙0流れ0CP.Update();
				this.X0Y2_涙0流れ1CP.Update();
				this.X0Y2_涙0CP.Update();
				this.X0Y2_涙1CP.Update();
				this.X0Y2_涙ハイライトCP.Update();
				return;
			case 3:
				this.X0Y3_涙0流れ0CP.Update();
				this.X0Y3_涙0流れ1CP.Update();
				this.X0Y3_涙0CP.Update();
				this.X0Y3_涙1CP.Update();
				this.X0Y3_涙ハイライトCP.Update();
				return;
			case 4:
				this.X0Y4_涙0流れ0CP.Update();
				this.X0Y4_涙0流れ1CP.Update();
				this.X0Y4_涙0CP.Update();
				this.X0Y4_涙1CP.Update();
				this.X0Y4_涙ハイライトCP.Update();
				return;
			default:
				this.X0Y5_涙0流れ0CP.Update();
				this.X0Y5_涙0流れ1CP.Update();
				this.X0Y5_涙0CP.Update();
				this.X0Y5_涙1CP.Update();
				this.X0Y5_涙ハイライトCP.Update();
				return;
			}
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.涙0流れ0CD = new ColorD(ref 体配色.体液線, ref Color2.Empty);
			this.涙0流れ1CD = new ColorD(ref 体配色.体液線, ref Color2.Empty);
			this.涙0CD = new ColorD(ref 体配色.体液線, ref 体配色.人肌O);
			this.涙1CD = new ColorD(ref 体配色.体液線, ref Color2.Empty);
			this.涙ハイライトCD = new ColorD(ref 体配色.ハイライト.Col1, ref 体配色.ハイライト);
		}

		public Par X0Y0_涙0流れ0;

		public Par X0Y0_涙0;

		public Par X0Y0_涙1;

		public Par X0Y0_涙ハイライト;

		public Par X0Y1_涙0流れ0;

		public Par X0Y1_涙0流れ1;

		public Par X0Y1_涙0;

		public Par X0Y1_涙1;

		public Par X0Y1_涙ハイライト;

		public Par X0Y2_涙0流れ0;

		public Par X0Y2_涙0流れ1;

		public Par X0Y2_涙0;

		public Par X0Y2_涙1;

		public Par X0Y2_涙ハイライト;

		public Par X0Y3_涙0流れ0;

		public Par X0Y3_涙0流れ1;

		public Par X0Y3_涙0;

		public Par X0Y3_涙1;

		public Par X0Y3_涙ハイライト;

		public Par X0Y4_涙0流れ0;

		public Par X0Y4_涙0流れ1;

		public Par X0Y4_涙0;

		public Par X0Y4_涙1;

		public Par X0Y4_涙ハイライト;

		public Par X0Y5_涙0流れ0;

		public Par X0Y5_涙0流れ1;

		public Par X0Y5_涙0;

		public Par X0Y5_涙1;

		public Par X0Y5_涙ハイライト;

		public ColorD 涙0流れ0CD;

		public ColorD 涙0流れ1CD;

		public ColorD 涙0CD;

		public ColorD 涙1CD;

		public ColorD 涙ハイライトCD;

		public ColorP X0Y0_涙0流れ0CP;

		public ColorP X0Y0_涙0CP;

		public ColorP X0Y0_涙1CP;

		public ColorP X0Y0_涙ハイライトCP;

		public ColorP X0Y1_涙0流れ0CP;

		public ColorP X0Y1_涙0流れ1CP;

		public ColorP X0Y1_涙0CP;

		public ColorP X0Y1_涙1CP;

		public ColorP X0Y1_涙ハイライトCP;

		public ColorP X0Y2_涙0流れ0CP;

		public ColorP X0Y2_涙0流れ1CP;

		public ColorP X0Y2_涙0CP;

		public ColorP X0Y2_涙1CP;

		public ColorP X0Y2_涙ハイライトCP;

		public ColorP X0Y3_涙0流れ0CP;

		public ColorP X0Y3_涙0流れ1CP;

		public ColorP X0Y3_涙0CP;

		public ColorP X0Y3_涙1CP;

		public ColorP X0Y3_涙ハイライトCP;

		public ColorP X0Y4_涙0流れ0CP;

		public ColorP X0Y4_涙0流れ1CP;

		public ColorP X0Y4_涙0CP;

		public ColorP X0Y4_涙1CP;

		public ColorP X0Y4_涙ハイライトCP;

		public ColorP X0Y5_涙0流れ0CP;

		public ColorP X0Y5_涙0流れ1CP;

		public ColorP X0Y5_涙0CP;

		public ColorP X0Y5_涙1CP;

		public ColorP X0Y5_涙ハイライトCP;
	}
}
