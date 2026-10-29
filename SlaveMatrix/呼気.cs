using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 呼気 : Ele
	{
		public 呼気(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 呼気D e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.胴体["呼気"]);
			Pars pars = this.本体[0][0];
			Pars pars2 = pars["呼気左1"].ToPars();
			this.X0Y0_呼気左1_呼気1 = pars2["呼気1"].ToPar();
			this.X0Y0_呼気左1_呼気2 = pars2["呼気2"].ToPar();
			pars2 = pars["呼気左2"].ToPars();
			this.X0Y0_呼気左2_呼気1 = pars2["呼気1"].ToPar();
			this.X0Y0_呼気左2_呼気2 = pars2["呼気2"].ToPar();
			pars2 = pars["呼気左3"].ToPars();
			this.X0Y0_呼気左3_呼気1 = pars2["呼気1"].ToPar();
			this.X0Y0_呼気左3_呼気2 = pars2["呼気2"].ToPar();
			pars2 = pars["呼気右1"].ToPars();
			this.X0Y0_呼気右1_呼気1 = pars2["呼気1"].ToPar();
			this.X0Y0_呼気右1_呼気2 = pars2["呼気2"].ToPar();
			pars2 = pars["呼気右2"].ToPars();
			this.X0Y0_呼気右2_呼気1 = pars2["呼気1"].ToPar();
			this.X0Y0_呼気右2_呼気2 = pars2["呼気2"].ToPar();
			pars2 = pars["呼気右3"].ToPars();
			this.X0Y0_呼気右3_呼気1 = pars2["呼気1"].ToPar();
			this.X0Y0_呼気右3_呼気2 = pars2["呼気2"].ToPar();
			Pars pars3 = this.本体[0][1];
			pars2 = pars3["呼気左1"].ToPars();
			this.X0Y1_呼気左1_呼気1 = pars2["呼気1"].ToPar();
			this.X0Y1_呼気左1_呼気2 = pars2["呼気2"].ToPar();
			pars2 = pars3["呼気左2"].ToPars();
			this.X0Y1_呼気左2_呼気1 = pars2["呼気1"].ToPar();
			this.X0Y1_呼気左2_呼気2 = pars2["呼気2"].ToPar();
			pars2 = pars3["呼気左3"].ToPars();
			this.X0Y1_呼気左3_呼気1 = pars2["呼気1"].ToPar();
			this.X0Y1_呼気左3_呼気2 = pars2["呼気2"].ToPar();
			pars2 = pars3["呼気右1"].ToPars();
			this.X0Y1_呼気右1_呼気1 = pars2["呼気1"].ToPar();
			this.X0Y1_呼気右1_呼気2 = pars2["呼気2"].ToPar();
			pars2 = pars3["呼気右2"].ToPars();
			this.X0Y1_呼気右2_呼気1 = pars2["呼気1"].ToPar();
			this.X0Y1_呼気右2_呼気2 = pars2["呼気2"].ToPar();
			pars2 = pars3["呼気右3"].ToPars();
			this.X0Y1_呼気右3_呼気1 = pars2["呼気1"].ToPar();
			this.X0Y1_呼気右3_呼気2 = pars2["呼気2"].ToPar();
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
			this.呼気左1_呼気1_表示 = e.呼気左1_呼気1_表示;
			this.呼気左1_呼気2_表示 = e.呼気左1_呼気2_表示;
			this.呼気左2_呼気1_表示 = e.呼気左2_呼気1_表示;
			this.呼気左2_呼気2_表示 = e.呼気左2_呼気2_表示;
			this.呼気左3_呼気1_表示 = e.呼気左3_呼気1_表示;
			this.呼気左3_呼気2_表示 = e.呼気左3_呼気2_表示;
			this.呼気右1_呼気1_表示 = e.呼気右1_呼気1_表示;
			this.呼気右1_呼気2_表示 = e.呼気右1_呼気2_表示;
			this.呼気右2_呼気1_表示 = e.呼気右2_呼気1_表示;
			this.呼気右2_呼気2_表示 = e.呼気右2_呼気2_表示;
			this.呼気右3_呼気1_表示 = e.呼気右3_呼気1_表示;
			this.呼気右3_呼気2_表示 = e.呼気右3_呼気2_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_呼気左1_呼気1CP = new ColorP(this.X0Y0_呼気左1_呼気1, this.呼気左1_呼気1CD, DisUnit, true);
			this.X0Y0_呼気左1_呼気2CP = new ColorP(this.X0Y0_呼気左1_呼気2, this.呼気左1_呼気2CD, DisUnit, true);
			this.X0Y0_呼気左2_呼気1CP = new ColorP(this.X0Y0_呼気左2_呼気1, this.呼気左2_呼気1CD, DisUnit, true);
			this.X0Y0_呼気左2_呼気2CP = new ColorP(this.X0Y0_呼気左2_呼気2, this.呼気左2_呼気2CD, DisUnit, true);
			this.X0Y0_呼気左3_呼気1CP = new ColorP(this.X0Y0_呼気左3_呼気1, this.呼気左3_呼気1CD, DisUnit, true);
			this.X0Y0_呼気左3_呼気2CP = new ColorP(this.X0Y0_呼気左3_呼気2, this.呼気左3_呼気2CD, DisUnit, true);
			this.X0Y0_呼気右1_呼気1CP = new ColorP(this.X0Y0_呼気右1_呼気1, this.呼気右1_呼気1CD, DisUnit, true);
			this.X0Y0_呼気右1_呼気2CP = new ColorP(this.X0Y0_呼気右1_呼気2, this.呼気右1_呼気2CD, DisUnit, true);
			this.X0Y0_呼気右2_呼気1CP = new ColorP(this.X0Y0_呼気右2_呼気1, this.呼気右2_呼気1CD, DisUnit, true);
			this.X0Y0_呼気右2_呼気2CP = new ColorP(this.X0Y0_呼気右2_呼気2, this.呼気右2_呼気2CD, DisUnit, true);
			this.X0Y0_呼気右3_呼気1CP = new ColorP(this.X0Y0_呼気右3_呼気1, this.呼気右3_呼気1CD, DisUnit, true);
			this.X0Y0_呼気右3_呼気2CP = new ColorP(this.X0Y0_呼気右3_呼気2, this.呼気右3_呼気2CD, DisUnit, true);
			this.X0Y1_呼気左1_呼気1CP = new ColorP(this.X0Y1_呼気左1_呼気1, this.呼気左1_呼気1CD, DisUnit, true);
			this.X0Y1_呼気左1_呼気2CP = new ColorP(this.X0Y1_呼気左1_呼気2, this.呼気左1_呼気2CD, DisUnit, true);
			this.X0Y1_呼気左2_呼気1CP = new ColorP(this.X0Y1_呼気左2_呼気1, this.呼気左2_呼気1CD, DisUnit, true);
			this.X0Y1_呼気左2_呼気2CP = new ColorP(this.X0Y1_呼気左2_呼気2, this.呼気左2_呼気2CD, DisUnit, true);
			this.X0Y1_呼気左3_呼気1CP = new ColorP(this.X0Y1_呼気左3_呼気1, this.呼気左3_呼気1CD, DisUnit, true);
			this.X0Y1_呼気左3_呼気2CP = new ColorP(this.X0Y1_呼気左3_呼気2, this.呼気左3_呼気2CD, DisUnit, true);
			this.X0Y1_呼気右1_呼気1CP = new ColorP(this.X0Y1_呼気右1_呼気1, this.呼気右1_呼気1CD, DisUnit, true);
			this.X0Y1_呼気右1_呼気2CP = new ColorP(this.X0Y1_呼気右1_呼気2, this.呼気右1_呼気2CD, DisUnit, true);
			this.X0Y1_呼気右2_呼気1CP = new ColorP(this.X0Y1_呼気右2_呼気1, this.呼気右2_呼気1CD, DisUnit, true);
			this.X0Y1_呼気右2_呼気2CP = new ColorP(this.X0Y1_呼気右2_呼気2, this.呼気右2_呼気2CD, DisUnit, true);
			this.X0Y1_呼気右3_呼気1CP = new ColorP(this.X0Y1_呼気右3_呼気1, this.呼気右3_呼気1CD, DisUnit, true);
			this.X0Y1_呼気右3_呼気2CP = new ColorP(this.X0Y1_呼気右3_呼気2, this.呼気右3_呼気2CD, DisUnit, true);
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

		public bool 呼気左1_呼気1_表示
		{
			get
			{
				return this.X0Y0_呼気左1_呼気1.Dra;
			}
			set
			{
				this.X0Y0_呼気左1_呼気1.Dra = value;
				this.X0Y1_呼気左1_呼気1.Dra = value;
				this.X0Y0_呼気左1_呼気1.Hit = value;
				this.X0Y1_呼気左1_呼気1.Hit = value;
			}
		}

		public bool 呼気左1_呼気2_表示
		{
			get
			{
				return this.X0Y0_呼気左1_呼気2.Dra;
			}
			set
			{
				this.X0Y0_呼気左1_呼気2.Dra = value;
				this.X0Y1_呼気左1_呼気2.Dra = value;
				this.X0Y0_呼気左1_呼気2.Hit = value;
				this.X0Y1_呼気左1_呼気2.Hit = value;
			}
		}

		public bool 呼気左2_呼気1_表示
		{
			get
			{
				return this.X0Y0_呼気左2_呼気1.Dra;
			}
			set
			{
				this.X0Y0_呼気左2_呼気1.Dra = value;
				this.X0Y1_呼気左2_呼気1.Dra = value;
				this.X0Y0_呼気左2_呼気1.Hit = value;
				this.X0Y1_呼気左2_呼気1.Hit = value;
			}
		}

		public bool 呼気左2_呼気2_表示
		{
			get
			{
				return this.X0Y0_呼気左2_呼気2.Dra;
			}
			set
			{
				this.X0Y0_呼気左2_呼気2.Dra = value;
				this.X0Y1_呼気左2_呼気2.Dra = value;
				this.X0Y0_呼気左2_呼気2.Hit = value;
				this.X0Y1_呼気左2_呼気2.Hit = value;
			}
		}

		public bool 呼気左3_呼気1_表示
		{
			get
			{
				return this.X0Y0_呼気左3_呼気1.Dra;
			}
			set
			{
				this.X0Y0_呼気左3_呼気1.Dra = value;
				this.X0Y1_呼気左3_呼気1.Dra = value;
				this.X0Y0_呼気左3_呼気1.Hit = value;
				this.X0Y1_呼気左3_呼気1.Hit = value;
			}
		}

		public bool 呼気左3_呼気2_表示
		{
			get
			{
				return this.X0Y0_呼気左3_呼気2.Dra;
			}
			set
			{
				this.X0Y0_呼気左3_呼気2.Dra = value;
				this.X0Y1_呼気左3_呼気2.Dra = value;
				this.X0Y0_呼気左3_呼気2.Hit = value;
				this.X0Y1_呼気左3_呼気2.Hit = value;
			}
		}

		public bool 呼気右1_呼気1_表示
		{
			get
			{
				return this.X0Y0_呼気右1_呼気1.Dra;
			}
			set
			{
				this.X0Y0_呼気右1_呼気1.Dra = value;
				this.X0Y1_呼気右1_呼気1.Dra = value;
				this.X0Y0_呼気右1_呼気1.Hit = value;
				this.X0Y1_呼気右1_呼気1.Hit = value;
			}
		}

		public bool 呼気右1_呼気2_表示
		{
			get
			{
				return this.X0Y0_呼気右1_呼気2.Dra;
			}
			set
			{
				this.X0Y0_呼気右1_呼気2.Dra = value;
				this.X0Y1_呼気右1_呼気2.Dra = value;
				this.X0Y0_呼気右1_呼気2.Hit = value;
				this.X0Y1_呼気右1_呼気2.Hit = value;
			}
		}

		public bool 呼気右2_呼気1_表示
		{
			get
			{
				return this.X0Y0_呼気右2_呼気1.Dra;
			}
			set
			{
				this.X0Y0_呼気右2_呼気1.Dra = value;
				this.X0Y1_呼気右2_呼気1.Dra = value;
				this.X0Y0_呼気右2_呼気1.Hit = value;
				this.X0Y1_呼気右2_呼気1.Hit = value;
			}
		}

		public bool 呼気右2_呼気2_表示
		{
			get
			{
				return this.X0Y0_呼気右2_呼気2.Dra;
			}
			set
			{
				this.X0Y0_呼気右2_呼気2.Dra = value;
				this.X0Y1_呼気右2_呼気2.Dra = value;
				this.X0Y0_呼気右2_呼気2.Hit = value;
				this.X0Y1_呼気右2_呼気2.Hit = value;
			}
		}

		public bool 呼気右3_呼気1_表示
		{
			get
			{
				return this.X0Y0_呼気右3_呼気1.Dra;
			}
			set
			{
				this.X0Y0_呼気右3_呼気1.Dra = value;
				this.X0Y1_呼気右3_呼気1.Dra = value;
				this.X0Y0_呼気右3_呼気1.Hit = value;
				this.X0Y1_呼気右3_呼気1.Hit = value;
			}
		}

		public bool 呼気右3_呼気2_表示
		{
			get
			{
				return this.X0Y0_呼気右3_呼気2.Dra;
			}
			set
			{
				this.X0Y0_呼気右3_呼気2.Dra = value;
				this.X0Y1_呼気右3_呼気2.Dra = value;
				this.X0Y0_呼気右3_呼気2.Hit = value;
				this.X0Y1_呼気右3_呼気2.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.呼気左1_呼気1_表示;
			}
			set
			{
				this.呼気左1_呼気1_表示 = value;
				this.呼気左1_呼気2_表示 = value;
				this.呼気左2_呼気1_表示 = value;
				this.呼気左2_呼気2_表示 = value;
				this.呼気左3_呼気1_表示 = value;
				this.呼気左3_呼気2_表示 = value;
				this.呼気右1_呼気1_表示 = value;
				this.呼気右1_呼気2_表示 = value;
				this.呼気右2_呼気1_表示 = value;
				this.呼気右2_呼気2_表示 = value;
				this.呼気右3_呼気1_表示 = value;
				this.呼気右3_呼気2_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.呼気左1_呼気1CD.不透明度;
			}
			set
			{
				this.呼気左1_呼気1CD.不透明度 = value;
				this.呼気左1_呼気2CD.不透明度 = value;
				this.呼気左2_呼気1CD.不透明度 = value;
				this.呼気左2_呼気2CD.不透明度 = value;
				this.呼気左3_呼気1CD.不透明度 = value;
				this.呼気左3_呼気2CD.不透明度 = value;
				this.呼気右1_呼気1CD.不透明度 = value;
				this.呼気右1_呼気2CD.不透明度 = value;
				this.呼気右2_呼気1CD.不透明度 = value;
				this.呼気右2_呼気2CD.不透明度 = value;
				this.呼気右3_呼気1CD.不透明度 = value;
				this.呼気右3_呼気2CD.不透明度 = value;
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
			if (this.本体.IndexY == 0)
			{
				this.X0Y0_呼気左1_呼気1CP.Update();
				this.X0Y0_呼気左1_呼気2CP.Update();
				this.X0Y0_呼気左2_呼気1CP.Update();
				this.X0Y0_呼気左2_呼気2CP.Update();
				this.X0Y0_呼気左3_呼気1CP.Update();
				this.X0Y0_呼気左3_呼気2CP.Update();
				this.X0Y0_呼気右1_呼気1CP.Update();
				this.X0Y0_呼気右1_呼気2CP.Update();
				this.X0Y0_呼気右2_呼気1CP.Update();
				this.X0Y0_呼気右2_呼気2CP.Update();
				this.X0Y0_呼気右3_呼気1CP.Update();
				this.X0Y0_呼気右3_呼気2CP.Update();
				return;
			}
			this.X0Y1_呼気左1_呼気1CP.Update();
			this.X0Y1_呼気左1_呼気2CP.Update();
			this.X0Y1_呼気左2_呼気1CP.Update();
			this.X0Y1_呼気左2_呼気2CP.Update();
			this.X0Y1_呼気左3_呼気1CP.Update();
			this.X0Y1_呼気左3_呼気2CP.Update();
			this.X0Y1_呼気右1_呼気1CP.Update();
			this.X0Y1_呼気右1_呼気2CP.Update();
			this.X0Y1_呼気右2_呼気1CP.Update();
			this.X0Y1_呼気右2_呼気2CP.Update();
			this.X0Y1_呼気右3_呼気1CP.Update();
			this.X0Y1_呼気右3_呼気2CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.呼気左1_呼気1CD = new ColorD(ref Col.Empty, ref 体配色.呼気);
			this.呼気左1_呼気2CD = new ColorD(ref Col.Empty, ref 体配色.呼気);
			this.呼気左2_呼気1CD = new ColorD(ref Col.Empty, ref 体配色.呼気);
			this.呼気左2_呼気2CD = new ColorD(ref Col.Empty, ref 体配色.呼気);
			this.呼気左3_呼気1CD = new ColorD(ref Col.Empty, ref 体配色.呼気);
			this.呼気左3_呼気2CD = new ColorD(ref Col.Empty, ref 体配色.呼気);
			this.呼気右1_呼気1CD = new ColorD(ref Col.Empty, ref 体配色.呼気);
			this.呼気右1_呼気2CD = new ColorD(ref Col.Empty, ref 体配色.呼気);
			this.呼気右2_呼気1CD = new ColorD(ref Col.Empty, ref 体配色.呼気);
			this.呼気右2_呼気2CD = new ColorD(ref Col.Empty, ref 体配色.呼気);
			this.呼気右3_呼気1CD = new ColorD(ref Col.Empty, ref 体配色.呼気);
			this.呼気右3_呼気2CD = new ColorD(ref Col.Empty, ref 体配色.呼気);
		}

		public Par X0Y0_呼気左1_呼気1;

		public Par X0Y0_呼気左1_呼気2;

		public Par X0Y0_呼気左2_呼気1;

		public Par X0Y0_呼気左2_呼気2;

		public Par X0Y0_呼気左3_呼気1;

		public Par X0Y0_呼気左3_呼気2;

		public Par X0Y0_呼気右1_呼気1;

		public Par X0Y0_呼気右1_呼気2;

		public Par X0Y0_呼気右2_呼気1;

		public Par X0Y0_呼気右2_呼気2;

		public Par X0Y0_呼気右3_呼気1;

		public Par X0Y0_呼気右3_呼気2;

		public Par X0Y1_呼気左1_呼気1;

		public Par X0Y1_呼気左1_呼気2;

		public Par X0Y1_呼気左2_呼気1;

		public Par X0Y1_呼気左2_呼気2;

		public Par X0Y1_呼気左3_呼気1;

		public Par X0Y1_呼気左3_呼気2;

		public Par X0Y1_呼気右1_呼気1;

		public Par X0Y1_呼気右1_呼気2;

		public Par X0Y1_呼気右2_呼気1;

		public Par X0Y1_呼気右2_呼気2;

		public Par X0Y1_呼気右3_呼気1;

		public Par X0Y1_呼気右3_呼気2;

		public ColorD 呼気左1_呼気1CD;

		public ColorD 呼気左1_呼気2CD;

		public ColorD 呼気左2_呼気1CD;

		public ColorD 呼気左2_呼気2CD;

		public ColorD 呼気左3_呼気1CD;

		public ColorD 呼気左3_呼気2CD;

		public ColorD 呼気右1_呼気1CD;

		public ColorD 呼気右1_呼気2CD;

		public ColorD 呼気右2_呼気1CD;

		public ColorD 呼気右2_呼気2CD;

		public ColorD 呼気右3_呼気1CD;

		public ColorD 呼気右3_呼気2CD;

		public ColorP X0Y0_呼気左1_呼気1CP;

		public ColorP X0Y0_呼気左1_呼気2CP;

		public ColorP X0Y0_呼気左2_呼気1CP;

		public ColorP X0Y0_呼気左2_呼気2CP;

		public ColorP X0Y0_呼気左3_呼気1CP;

		public ColorP X0Y0_呼気左3_呼気2CP;

		public ColorP X0Y0_呼気右1_呼気1CP;

		public ColorP X0Y0_呼気右1_呼気2CP;

		public ColorP X0Y0_呼気右2_呼気1CP;

		public ColorP X0Y0_呼気右2_呼気2CP;

		public ColorP X0Y0_呼気右3_呼気1CP;

		public ColorP X0Y0_呼気右3_呼気2CP;

		public ColorP X0Y1_呼気左1_呼気1CP;

		public ColorP X0Y1_呼気左1_呼気2CP;

		public ColorP X0Y1_呼気左2_呼気1CP;

		public ColorP X0Y1_呼気左2_呼気2CP;

		public ColorP X0Y1_呼気左3_呼気1CP;

		public ColorP X0Y1_呼気左3_呼気2CP;

		public ColorP X0Y1_呼気右1_呼気1CP;

		public ColorP X0Y1_呼気右1_呼気2CP;

		public ColorP X0Y1_呼気右2_呼気1CP;

		public ColorP X0Y1_呼気右2_呼気2CP;

		public ColorP X0Y1_呼気右3_呼気1CP;

		public ColorP X0Y1_呼気右3_呼気2CP;
	}
}
