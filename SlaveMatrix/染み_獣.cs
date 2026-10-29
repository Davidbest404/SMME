using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 染み_獣 : 染み
	{
		public 染み_獣(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 染み_獣D e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.その他["四足染み"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_潮1 = pars["潮1"].ToPar();
			this.X0Y0_潮2 = pars["潮2"].ToPar();
			this.X0Y0_潮3 = pars["潮3"].ToPar();
			this.X0Y0_尿1 = pars["尿1"].ToPar();
			this.X0Y0_尿2 = pars["尿2"].ToPar();
			this.X0Y0_汗 = pars["汗"].ToPar();
			Pars pars2 = pars["湯気"].ToPars();
			Pars pars3 = pars2["湯気左1"].ToPars();
			this.X0Y0_湯気_湯気左1_湯気1 = pars3["湯気1"].ToPar();
			this.X0Y0_湯気_湯気左1_湯気2 = pars3["湯気2"].ToPar();
			pars3 = pars2["湯気左2"].ToPars();
			this.X0Y0_湯気_湯気左2_湯気1 = pars3["湯気1"].ToPar();
			this.X0Y0_湯気_湯気左2_湯気2 = pars3["湯気2"].ToPar();
			pars3 = pars2["湯気左3"].ToPars();
			this.X0Y0_湯気_湯気左3_湯気1 = pars3["湯気1"].ToPar();
			this.X0Y0_湯気_湯気左3_湯気2 = pars3["湯気2"].ToPar();
			pars3 = pars2["湯気右1"].ToPars();
			this.X0Y0_湯気_湯気右1_湯気1 = pars3["湯気1"].ToPar();
			this.X0Y0_湯気_湯気右1_湯気2 = pars3["湯気2"].ToPar();
			pars3 = pars2["湯気右2"].ToPars();
			this.X0Y0_湯気_湯気右2_湯気1 = pars3["湯気1"].ToPar();
			this.X0Y0_湯気_湯気右2_湯気2 = pars3["湯気2"].ToPar();
			pars3 = pars2["湯気右3"].ToPars();
			this.X0Y0_湯気_湯気右3_湯気1 = pars3["湯気1"].ToPar();
			this.X0Y0_湯気_湯気右3_湯気2 = pars3["湯気2"].ToPar();
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
			this.潮1_表示 = e.潮1_表示;
			this.潮2_表示 = e.潮2_表示;
			this.潮3_表示 = e.潮3_表示;
			this.尿1_表示 = e.尿1_表示;
			this.尿2_表示 = e.尿2_表示;
			this.汗_表示 = e.汗_表示;
			this.湯気_湯気左1_湯気1_表示 = e.湯気_湯気左1_湯気1_表示;
			this.湯気_湯気左1_湯気2_表示 = e.湯気_湯気左1_湯気2_表示;
			this.湯気_湯気左2_湯気1_表示 = e.湯気_湯気左2_湯気1_表示;
			this.湯気_湯気左2_湯気2_表示 = e.湯気_湯気左2_湯気2_表示;
			this.湯気_湯気左3_湯気1_表示 = e.湯気_湯気左3_湯気1_表示;
			this.湯気_湯気左3_湯気2_表示 = e.湯気_湯気左3_湯気2_表示;
			this.湯気_湯気右1_湯気1_表示 = e.湯気_湯気右1_湯気1_表示;
			this.湯気_湯気右1_湯気2_表示 = e.湯気_湯気右1_湯気2_表示;
			this.湯気_湯気右2_湯気1_表示 = e.湯気_湯気右2_湯気1_表示;
			this.湯気_湯気右2_湯気2_表示 = e.湯気_湯気右2_湯気2_表示;
			this.湯気_湯気右3_湯気1_表示 = e.湯気_湯気右3_湯気1_表示;
			this.湯気_湯気右3_湯気2_表示 = e.湯気_湯気右3_湯気2_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_潮1CP = new ColorP(this.X0Y0_潮1, this.潮1CD, DisUnit, true);
			this.X0Y0_潮2CP = new ColorP(this.X0Y0_潮2, this.潮2CD, DisUnit, true);
			this.X0Y0_潮3CP = new ColorP(this.X0Y0_潮3, this.潮3CD, DisUnit, true);
			this.X0Y0_尿1CP = new ColorP(this.X0Y0_尿1, this.尿1CD, DisUnit, true);
			this.X0Y0_尿2CP = new ColorP(this.X0Y0_尿2, this.尿2CD, DisUnit, true);
			this.X0Y0_汗CP = new ColorP(this.X0Y0_汗, this.汗CD, DisUnit, true);
			this.X0Y0_湯気_湯気左1_湯気1CP = new ColorP(this.X0Y0_湯気_湯気左1_湯気1, this.湯気_湯気左1_湯気1CD, DisUnit, true);
			this.X0Y0_湯気_湯気左1_湯気2CP = new ColorP(this.X0Y0_湯気_湯気左1_湯気2, this.湯気_湯気左1_湯気2CD, DisUnit, true);
			this.X0Y0_湯気_湯気左2_湯気1CP = new ColorP(this.X0Y0_湯気_湯気左2_湯気1, this.湯気_湯気左2_湯気1CD, DisUnit, true);
			this.X0Y0_湯気_湯気左2_湯気2CP = new ColorP(this.X0Y0_湯気_湯気左2_湯気2, this.湯気_湯気左2_湯気2CD, DisUnit, true);
			this.X0Y0_湯気_湯気左3_湯気1CP = new ColorP(this.X0Y0_湯気_湯気左3_湯気1, this.湯気_湯気左3_湯気1CD, DisUnit, true);
			this.X0Y0_湯気_湯気左3_湯気2CP = new ColorP(this.X0Y0_湯気_湯気左3_湯気2, this.湯気_湯気左3_湯気2CD, DisUnit, true);
			this.X0Y0_湯気_湯気右1_湯気1CP = new ColorP(this.X0Y0_湯気_湯気右1_湯気1, this.湯気_湯気右1_湯気1CD, DisUnit, true);
			this.X0Y0_湯気_湯気右1_湯気2CP = new ColorP(this.X0Y0_湯気_湯気右1_湯気2, this.湯気_湯気右1_湯気2CD, DisUnit, true);
			this.X0Y0_湯気_湯気右2_湯気1CP = new ColorP(this.X0Y0_湯気_湯気右2_湯気1, this.湯気_湯気右2_湯気1CD, DisUnit, true);
			this.X0Y0_湯気_湯気右2_湯気2CP = new ColorP(this.X0Y0_湯気_湯気右2_湯気2, this.湯気_湯気右2_湯気2CD, DisUnit, true);
			this.X0Y0_湯気_湯気右3_湯気1CP = new ColorP(this.X0Y0_湯気_湯気右3_湯気1, this.湯気_湯気右3_湯気1CD, DisUnit, true);
			this.X0Y0_湯気_湯気右3_湯気2CP = new ColorP(this.X0Y0_湯気_湯気右3_湯気2, this.湯気_湯気右3_湯気2CD, DisUnit, true);
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

		public bool 潮1_表示
		{
			get
			{
				return this.X0Y0_潮1.Dra;
			}
			set
			{
				this.X0Y0_潮1.Dra = value;
				this.X0Y0_潮1.Hit = value;
			}
		}

		public bool 潮2_表示
		{
			get
			{
				return this.X0Y0_潮2.Dra;
			}
			set
			{
				this.X0Y0_潮2.Dra = value;
				this.X0Y0_潮2.Hit = value;
			}
		}

		public bool 潮3_表示
		{
			get
			{
				return this.X0Y0_潮3.Dra;
			}
			set
			{
				this.X0Y0_潮3.Dra = value;
				this.X0Y0_潮3.Hit = value;
			}
		}

		public bool 尿1_表示
		{
			get
			{
				return this.X0Y0_尿1.Dra;
			}
			set
			{
				this.X0Y0_尿1.Dra = value;
				this.X0Y0_尿1.Hit = value;
			}
		}

		public bool 尿2_表示
		{
			get
			{
				return this.X0Y0_尿2.Dra;
			}
			set
			{
				this.X0Y0_尿2.Dra = value;
				this.X0Y0_尿2.Hit = value;
			}
		}

		public bool 汗_表示
		{
			get
			{
				return this.X0Y0_汗.Dra;
			}
			set
			{
				this.X0Y0_汗.Dra = value;
				this.X0Y0_汗.Hit = value;
			}
		}

		public bool 湯気_湯気左1_湯気1_表示
		{
			get
			{
				return this.X0Y0_湯気_湯気左1_湯気1.Dra;
			}
			set
			{
				this.X0Y0_湯気_湯気左1_湯気1.Dra = value;
				this.X0Y0_湯気_湯気左1_湯気1.Hit = value;
			}
		}

		public bool 湯気_湯気左1_湯気2_表示
		{
			get
			{
				return this.X0Y0_湯気_湯気左1_湯気2.Dra;
			}
			set
			{
				this.X0Y0_湯気_湯気左1_湯気2.Dra = value;
				this.X0Y0_湯気_湯気左1_湯気2.Hit = value;
			}
		}

		public bool 湯気_湯気左2_湯気1_表示
		{
			get
			{
				return this.X0Y0_湯気_湯気左2_湯気1.Dra;
			}
			set
			{
				this.X0Y0_湯気_湯気左2_湯気1.Dra = value;
				this.X0Y0_湯気_湯気左2_湯気1.Hit = value;
			}
		}

		public bool 湯気_湯気左2_湯気2_表示
		{
			get
			{
				return this.X0Y0_湯気_湯気左2_湯気2.Dra;
			}
			set
			{
				this.X0Y0_湯気_湯気左2_湯気2.Dra = value;
				this.X0Y0_湯気_湯気左2_湯気2.Hit = value;
			}
		}

		public bool 湯気_湯気左3_湯気1_表示
		{
			get
			{
				return this.X0Y0_湯気_湯気左3_湯気1.Dra;
			}
			set
			{
				this.X0Y0_湯気_湯気左3_湯気1.Dra = value;
				this.X0Y0_湯気_湯気左3_湯気1.Hit = value;
			}
		}

		public bool 湯気_湯気左3_湯気2_表示
		{
			get
			{
				return this.X0Y0_湯気_湯気左3_湯気2.Dra;
			}
			set
			{
				this.X0Y0_湯気_湯気左3_湯気2.Dra = value;
				this.X0Y0_湯気_湯気左3_湯気2.Hit = value;
			}
		}

		public bool 湯気_湯気右1_湯気1_表示
		{
			get
			{
				return this.X0Y0_湯気_湯気右1_湯気1.Dra;
			}
			set
			{
				this.X0Y0_湯気_湯気右1_湯気1.Dra = value;
				this.X0Y0_湯気_湯気右1_湯気1.Hit = value;
			}
		}

		public bool 湯気_湯気右1_湯気2_表示
		{
			get
			{
				return this.X0Y0_湯気_湯気右1_湯気2.Dra;
			}
			set
			{
				this.X0Y0_湯気_湯気右1_湯気2.Dra = value;
				this.X0Y0_湯気_湯気右1_湯気2.Hit = value;
			}
		}

		public bool 湯気_湯気右2_湯気1_表示
		{
			get
			{
				return this.X0Y0_湯気_湯気右2_湯気1.Dra;
			}
			set
			{
				this.X0Y0_湯気_湯気右2_湯気1.Dra = value;
				this.X0Y0_湯気_湯気右2_湯気1.Hit = value;
			}
		}

		public bool 湯気_湯気右2_湯気2_表示
		{
			get
			{
				return this.X0Y0_湯気_湯気右2_湯気2.Dra;
			}
			set
			{
				this.X0Y0_湯気_湯気右2_湯気2.Dra = value;
				this.X0Y0_湯気_湯気右2_湯気2.Hit = value;
			}
		}

		public bool 湯気_湯気右3_湯気1_表示
		{
			get
			{
				return this.X0Y0_湯気_湯気右3_湯気1.Dra;
			}
			set
			{
				this.X0Y0_湯気_湯気右3_湯気1.Dra = value;
				this.X0Y0_湯気_湯気右3_湯気1.Hit = value;
			}
		}

		public bool 湯気_湯気右3_湯気2_表示
		{
			get
			{
				return this.X0Y0_湯気_湯気右3_湯気2.Dra;
			}
			set
			{
				this.X0Y0_湯気_湯気右3_湯気2.Dra = value;
				this.X0Y0_湯気_湯気右3_湯気2.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.潮1_表示;
			}
			set
			{
				this.潮1_表示 = value;
				this.潮2_表示 = value;
				this.潮3_表示 = value;
				this.尿1_表示 = value;
				this.尿2_表示 = value;
				this.汗_表示 = value;
				this.湯気_湯気左1_湯気1_表示 = value;
				this.湯気_湯気左1_湯気2_表示 = value;
				this.湯気_湯気左2_湯気1_表示 = value;
				this.湯気_湯気左2_湯気2_表示 = value;
				this.湯気_湯気左3_湯気1_表示 = value;
				this.湯気_湯気左3_湯気2_表示 = value;
				this.湯気_湯気右1_湯気1_表示 = value;
				this.湯気_湯気右1_湯気2_表示 = value;
				this.湯気_湯気右2_湯気1_表示 = value;
				this.湯気_湯気右2_湯気2_表示 = value;
				this.湯気_湯気右3_湯気1_表示 = value;
				this.湯気_湯気右3_湯気2_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.潮1CD.不透明度;
			}
			set
			{
				this.潮1CD.不透明度 = value;
				this.潮2CD.不透明度 = value;
				this.潮3CD.不透明度 = value;
				this.尿1CD.不透明度 = value;
				this.尿2CD.不透明度 = value;
				this.汗CD.不透明度 = value;
				this.湯気_湯気左1_湯気1CD.不透明度 = value;
				this.湯気_湯気左1_湯気2CD.不透明度 = value;
				this.湯気_湯気左2_湯気1CD.不透明度 = value;
				this.湯気_湯気左2_湯気2CD.不透明度 = value;
				this.湯気_湯気左3_湯気1CD.不透明度 = value;
				this.湯気_湯気左3_湯気2CD.不透明度 = value;
				this.湯気_湯気右1_湯気1CD.不透明度 = value;
				this.湯気_湯気右1_湯気2CD.不透明度 = value;
				this.湯気_湯気右2_湯気1CD.不透明度 = value;
				this.湯気_湯気右2_湯気2CD.不透明度 = value;
				this.湯気_湯気右3_湯気1CD.不透明度 = value;
				this.湯気_湯気右3_湯気2CD.不透明度 = value;
			}
		}

		public override void 描画0(Are Are)
		{
			Are.Draw(this.X0Y0_潮1);
			Are.Draw(this.X0Y0_潮2);
			Are.Draw(this.X0Y0_潮3);
			Are.Draw(this.X0Y0_尿1);
			Are.Draw(this.X0Y0_尿2);
			Are.Draw(this.X0Y0_汗);
		}

		public void 湯気描画(Are Are)
		{
			Are.Draw(this.X0Y0_湯気_湯気左1_湯気1);
			Are.Draw(this.X0Y0_湯気_湯気左1_湯気2);
			Are.Draw(this.X0Y0_湯気_湯気左2_湯気1);
			Are.Draw(this.X0Y0_湯気_湯気左2_湯気2);
			Are.Draw(this.X0Y0_湯気_湯気左3_湯気1);
			Are.Draw(this.X0Y0_湯気_湯気左3_湯気2);
			Are.Draw(this.X0Y0_湯気_湯気右1_湯気1);
			Are.Draw(this.X0Y0_湯気_湯気右1_湯気2);
			Are.Draw(this.X0Y0_湯気_湯気右2_湯気1);
			Are.Draw(this.X0Y0_湯気_湯気右2_湯気2);
			Are.Draw(this.X0Y0_湯気_湯気右3_湯気1);
			Are.Draw(this.X0Y0_湯気_湯気右3_湯気2);
		}

		public override void 色更新()
		{
			this.X0Y0_潮1CP.Update();
			this.X0Y0_潮2CP.Update();
			this.X0Y0_潮3CP.Update();
			this.X0Y0_尿1CP.Update();
			this.X0Y0_尿2CP.Update();
			this.X0Y0_汗CP.Update();
			this.X0Y0_湯気_湯気左1_湯気1CP.Update();
			this.X0Y0_湯気_湯気左1_湯気2CP.Update();
			this.X0Y0_湯気_湯気左2_湯気1CP.Update();
			this.X0Y0_湯気_湯気左2_湯気2CP.Update();
			this.X0Y0_湯気_湯気左3_湯気1CP.Update();
			this.X0Y0_湯気_湯気左3_湯気2CP.Update();
			this.X0Y0_湯気_湯気右1_湯気1CP.Update();
			this.X0Y0_湯気_湯気右1_湯気2CP.Update();
			this.X0Y0_湯気_湯気右2_湯気1CP.Update();
			this.X0Y0_湯気_湯気右2_湯気2CP.Update();
			this.X0Y0_湯気_湯気右3_湯気1CP.Update();
			this.X0Y0_湯気_湯気右3_湯気2CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.潮1CD = new ColorD(ref Col.Empty, ref 体配色.染み);
			this.潮2CD = new ColorD(ref Col.Empty, ref 体配色.染み);
			this.潮3CD = new ColorD(ref Col.Empty, ref 体配色.染み);
			this.尿1CD = new ColorD(ref Col.Empty, ref 体配色.染み);
			this.尿2CD = new ColorD(ref Col.Empty, ref 体配色.染み);
			this.汗CD = new ColorD(ref Col.Empty, ref 体配色.染み);
			this.湯気_湯気左1_湯気1CD = new ColorD(ref Col.Empty, ref 体配色.呼気);
			this.湯気_湯気左1_湯気2CD = new ColorD(ref Col.Empty, ref 体配色.呼気);
			this.湯気_湯気左2_湯気1CD = new ColorD(ref Col.Empty, ref 体配色.呼気);
			this.湯気_湯気左2_湯気2CD = new ColorD(ref Col.Empty, ref 体配色.呼気);
			this.湯気_湯気左3_湯気1CD = new ColorD(ref Col.Empty, ref 体配色.呼気);
			this.湯気_湯気左3_湯気2CD = new ColorD(ref Col.Empty, ref 体配色.呼気);
			this.湯気_湯気右1_湯気1CD = new ColorD(ref Col.Empty, ref 体配色.呼気);
			this.湯気_湯気右1_湯気2CD = new ColorD(ref Col.Empty, ref 体配色.呼気);
			this.湯気_湯気右2_湯気1CD = new ColorD(ref Col.Empty, ref 体配色.呼気);
			this.湯気_湯気右2_湯気2CD = new ColorD(ref Col.Empty, ref 体配色.呼気);
			this.湯気_湯気右3_湯気1CD = new ColorD(ref Col.Empty, ref 体配色.呼気);
			this.湯気_湯気右3_湯気2CD = new ColorD(ref Col.Empty, ref 体配色.呼気);
		}

		public Par X0Y0_潮1;

		public Par X0Y0_潮2;

		public Par X0Y0_潮3;

		public Par X0Y0_尿1;

		public Par X0Y0_尿2;

		public Par X0Y0_汗;

		public Par X0Y0_湯気_湯気左1_湯気1;

		public Par X0Y0_湯気_湯気左1_湯気2;

		public Par X0Y0_湯気_湯気左2_湯気1;

		public Par X0Y0_湯気_湯気左2_湯気2;

		public Par X0Y0_湯気_湯気左3_湯気1;

		public Par X0Y0_湯気_湯気左3_湯気2;

		public Par X0Y0_湯気_湯気右1_湯気1;

		public Par X0Y0_湯気_湯気右1_湯気2;

		public Par X0Y0_湯気_湯気右2_湯気1;

		public Par X0Y0_湯気_湯気右2_湯気2;

		public Par X0Y0_湯気_湯気右3_湯気1;

		public Par X0Y0_湯気_湯気右3_湯気2;

		public ColorD 潮1CD;

		public ColorD 潮2CD;

		public ColorD 潮3CD;

		public ColorD 尿1CD;

		public ColorD 尿2CD;

		public ColorD 汗CD;

		public ColorD 湯気_湯気左1_湯気1CD;

		public ColorD 湯気_湯気左1_湯気2CD;

		public ColorD 湯気_湯気左2_湯気1CD;

		public ColorD 湯気_湯気左2_湯気2CD;

		public ColorD 湯気_湯気左3_湯気1CD;

		public ColorD 湯気_湯気左3_湯気2CD;

		public ColorD 湯気_湯気右1_湯気1CD;

		public ColorD 湯気_湯気右1_湯気2CD;

		public ColorD 湯気_湯気右2_湯気1CD;

		public ColorD 湯気_湯気右2_湯気2CD;

		public ColorD 湯気_湯気右3_湯気1CD;

		public ColorD 湯気_湯気右3_湯気2CD;

		public ColorP X0Y0_潮1CP;

		public ColorP X0Y0_潮2CP;

		public ColorP X0Y0_潮3CP;

		public ColorP X0Y0_尿1CP;

		public ColorP X0Y0_尿2CP;

		public ColorP X0Y0_汗CP;

		public ColorP X0Y0_湯気_湯気左1_湯気1CP;

		public ColorP X0Y0_湯気_湯気左1_湯気2CP;

		public ColorP X0Y0_湯気_湯気左2_湯気1CP;

		public ColorP X0Y0_湯気_湯気左2_湯気2CP;

		public ColorP X0Y0_湯気_湯気左3_湯気1CP;

		public ColorP X0Y0_湯気_湯気左3_湯気2CP;

		public ColorP X0Y0_湯気_湯気右1_湯気1CP;

		public ColorP X0Y0_湯気_湯気右1_湯気2CP;

		public ColorP X0Y0_湯気_湯気右2_湯気1CP;

		public ColorP X0Y0_湯気_湯気右2_湯気2CP;

		public ColorP X0Y0_湯気_湯気右3_湯気1CP;

		public ColorP X0Y0_湯気_湯気右3_湯気2CP;
	}
}
