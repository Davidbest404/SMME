using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 潮吹_小_獣 : 潮吹_小
	{
		public 潮吹_小_獣(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 潮吹_小_獣D e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif(Sta.性器付["四足潮吹"][0]);
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_雫 = pars["雫"].ToPar();
			pars = this.本体[0][1];
			this.X0Y1_雫 = pars["雫"].ToPar();
			pars = this.本体[0][2];
			this.X0Y2_雫 = pars["雫"].ToPar();
			pars = this.本体[0][3];
			this.X0Y3_雫 = pars["雫"].ToPar();
			pars = this.本体[0][4];
			this.X0Y4_雫 = pars["雫"].ToPar();
			pars = this.本体[0][5];
			this.X0Y5_雫 = pars["雫"].ToPar();
			pars = this.本体[0][6];
			this.X0Y6_雫 = pars["雫"].ToPar();
			pars = this.本体[0][7];
			this.X0Y7_雫 = pars["雫"].ToPar();
			pars = this.本体[0][8];
			this.X0Y8_雫 = pars["雫"].ToPar();
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
			this.雫_表示 = e.雫_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_雫CP = new ColorP(this.X0Y0_雫, this.雫CD, DisUnit, true);
			this.X0Y1_雫CP = new ColorP(this.X0Y1_雫, this.雫CD, DisUnit, true);
			this.X0Y2_雫CP = new ColorP(this.X0Y2_雫, this.雫CD, DisUnit, true);
			this.X0Y3_雫CP = new ColorP(this.X0Y3_雫, this.雫CD, DisUnit, true);
			this.X0Y4_雫CP = new ColorP(this.X0Y4_雫, this.雫CD, DisUnit, true);
			this.X0Y5_雫CP = new ColorP(this.X0Y5_雫, this.雫CD, DisUnit, true);
			this.X0Y6_雫CP = new ColorP(this.X0Y6_雫, this.雫CD, DisUnit, true);
			this.X0Y7_雫CP = new ColorP(this.X0Y7_雫, this.雫CD, DisUnit, true);
			this.X0Y8_雫CP = new ColorP(this.X0Y8_雫, this.雫CD, DisUnit, true);
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

		public bool 雫_表示
		{
			get
			{
				return this.X0Y0_雫.Dra;
			}
			set
			{
				this.X0Y0_雫.Dra = value;
				this.X0Y1_雫.Dra = value;
				this.X0Y2_雫.Dra = value;
				this.X0Y3_雫.Dra = value;
				this.X0Y4_雫.Dra = value;
				this.X0Y5_雫.Dra = value;
				this.X0Y6_雫.Dra = value;
				this.X0Y7_雫.Dra = value;
				this.X0Y8_雫.Dra = value;
				this.X0Y0_雫.Hit = value;
				this.X0Y1_雫.Hit = value;
				this.X0Y2_雫.Hit = value;
				this.X0Y3_雫.Hit = value;
				this.X0Y4_雫.Hit = value;
				this.X0Y5_雫.Hit = value;
				this.X0Y6_雫.Hit = value;
				this.X0Y7_雫.Hit = value;
				this.X0Y8_雫.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.雫_表示;
			}
			set
			{
				this.雫_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.雫CD.不透明度;
			}
			set
			{
				this.雫CD.不透明度 = value;
			}
		}

		public override void 色更新()
		{
			switch (this.本体.IndexY)
			{
			case 0:
				this.X0Y0_雫CP.Update();
				return;
			case 1:
				this.X0Y1_雫CP.Update();
				return;
			case 2:
				this.X0Y2_雫CP.Update();
				return;
			case 3:
				this.X0Y3_雫CP.Update();
				return;
			case 4:
				this.X0Y4_雫CP.Update();
				return;
			case 5:
				this.X0Y5_雫CP.Update();
				return;
			case 6:
				this.X0Y6_雫CP.Update();
				return;
			case 7:
				this.X0Y7_雫CP.Update();
				return;
			default:
				this.X0Y8_雫CP.Update();
				return;
			}
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.雫CD = new ColorD(ref Col.Empty, ref 体配色.体液);
		}

		public Par X0Y0_雫;

		public Par X0Y1_雫;

		public Par X0Y2_雫;

		public Par X0Y3_雫;

		public Par X0Y4_雫;

		public Par X0Y5_雫;

		public Par X0Y6_雫;

		public Par X0Y7_雫;

		public Par X0Y8_雫;

		public ColorD 雫CD;

		public ColorP X0Y0_雫CP;

		public ColorP X0Y1_雫CP;

		public ColorP X0Y2_雫CP;

		public ColorP X0Y3_雫CP;

		public ColorP X0Y4_雫CP;

		public ColorP X0Y5_雫CP;

		public ColorP X0Y6_雫CP;

		public ColorP X0Y7_雫CP;

		public ColorP X0Y8_雫CP;
	}
}
