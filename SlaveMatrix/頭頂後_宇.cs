using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 頭頂後_宇 : Ele
	{
		public 頭頂後_宇(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 頭頂後_宇D e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "エイリアン";
			dif.Add(new Pars(Sta.肢中["頭部後"][0][0]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_頭部 = pars["頭部"].ToPar();
			Pars pars2 = pars["線"].ToPars();
			this.X0Y0_線_線左1 = pars2["線左1"].ToPar();
			this.X0Y0_線_線左2 = pars2["線左2"].ToPar();
			this.X0Y0_線_線左3 = pars2["線左3"].ToPar();
			this.X0Y0_線_線右1 = pars2["線右1"].ToPar();
			this.X0Y0_線_線右2 = pars2["線右2"].ToPar();
			this.X0Y0_線_線右3 = pars2["線右3"].ToPar();
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
			this.頭部_表示 = e.頭部_表示;
			this.線_線左1_表示 = e.線_線左1_表示;
			this.線_線左2_表示 = e.線_線左2_表示;
			this.線_線左3_表示 = e.線_線左3_表示;
			this.線_線右1_表示 = e.線_線右1_表示;
			this.線_線右2_表示 = e.線_線右2_表示;
			this.線_線右3_表示 = e.線_線右3_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_頭部CP = new ColorP(this.X0Y0_頭部, this.頭部CD, DisUnit, true);
			this.X0Y0_線_線左1CP = new ColorP(this.X0Y0_線_線左1, this.線_線左1CD, DisUnit, true);
			this.X0Y0_線_線左2CP = new ColorP(this.X0Y0_線_線左2, this.線_線左2CD, DisUnit, true);
			this.X0Y0_線_線左3CP = new ColorP(this.X0Y0_線_線左3, this.線_線左3CD, DisUnit, true);
			this.X0Y0_線_線右1CP = new ColorP(this.X0Y0_線_線右1, this.線_線右1CD, DisUnit, true);
			this.X0Y0_線_線右2CP = new ColorP(this.X0Y0_線_線右2, this.線_線右2CD, DisUnit, true);
			this.X0Y0_線_線右3CP = new ColorP(this.X0Y0_線_線右3, this.線_線右3CD, DisUnit, true);
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

		public bool 頭部_表示
		{
			get
			{
				return this.X0Y0_頭部.Dra;
			}
			set
			{
				this.X0Y0_頭部.Dra = value;
				this.X0Y0_頭部.Hit = value;
			}
		}

		public bool 線_線左1_表示
		{
			get
			{
				return this.X0Y0_線_線左1.Dra;
			}
			set
			{
				this.X0Y0_線_線左1.Dra = value;
				this.X0Y0_線_線左1.Hit = value;
			}
		}

		public bool 線_線左2_表示
		{
			get
			{
				return this.X0Y0_線_線左2.Dra;
			}
			set
			{
				this.X0Y0_線_線左2.Dra = value;
				this.X0Y0_線_線左2.Hit = value;
			}
		}

		public bool 線_線左3_表示
		{
			get
			{
				return this.X0Y0_線_線左3.Dra;
			}
			set
			{
				this.X0Y0_線_線左3.Dra = value;
				this.X0Y0_線_線左3.Hit = value;
			}
		}

		public bool 線_線右1_表示
		{
			get
			{
				return this.X0Y0_線_線右1.Dra;
			}
			set
			{
				this.X0Y0_線_線右1.Dra = value;
				this.X0Y0_線_線右1.Hit = value;
			}
		}

		public bool 線_線右2_表示
		{
			get
			{
				return this.X0Y0_線_線右2.Dra;
			}
			set
			{
				this.X0Y0_線_線右2.Dra = value;
				this.X0Y0_線_線右2.Hit = value;
			}
		}

		public bool 線_線右3_表示
		{
			get
			{
				return this.X0Y0_線_線右3.Dra;
			}
			set
			{
				this.X0Y0_線_線右3.Dra = value;
				this.X0Y0_線_線右3.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.頭部_表示;
			}
			set
			{
				this.頭部_表示 = value;
				this.線_線左1_表示 = value;
				this.線_線左2_表示 = value;
				this.線_線左3_表示 = value;
				this.線_線右1_表示 = value;
				this.線_線右2_表示 = value;
				this.線_線右3_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.頭部CD.不透明度;
			}
			set
			{
				this.頭部CD.不透明度 = value;
				this.線_線左1CD.不透明度 = value;
				this.線_線左2CD.不透明度 = value;
				this.線_線左3CD.不透明度 = value;
				this.線_線右1CD.不透明度 = value;
				this.線_線右2CD.不透明度 = value;
				this.線_線右3CD.不透明度 = value;
			}
		}

		public override void 色更新()
		{
			this.X0Y0_頭部CP.Update();
			this.X0Y0_線_線左1CP.Update();
			this.X0Y0_線_線左2CP.Update();
			this.X0Y0_線_線左3CP.Update();
			this.X0Y0_線_線右1CP.Update();
			this.X0Y0_線_線右2CP.Update();
			this.X0Y0_線_線右3CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.頭部CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.線_線左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.線_線左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.線_線左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.線_線右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.線_線右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.線_線右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
		}

		public Par X0Y0_頭部;

		public Par X0Y0_線_線左1;

		public Par X0Y0_線_線左2;

		public Par X0Y0_線_線左3;

		public Par X0Y0_線_線右1;

		public Par X0Y0_線_線右2;

		public Par X0Y0_線_線右3;

		public ColorD 頭部CD;

		public ColorD 線_線左1CD;

		public ColorD 線_線左2CD;

		public ColorD 線_線左3CD;

		public ColorD 線_線右1CD;

		public ColorD 線_線右2CD;

		public ColorD 線_線右3CD;

		public ColorP X0Y0_頭部CP;

		public ColorP X0Y0_線_線左1CP;

		public ColorP X0Y0_線_線左2CP;

		public ColorP X0Y0_線_線左3CP;

		public ColorP X0Y0_線_線右1CP;

		public ColorP X0Y0_線_線右2CP;

		public ColorP X0Y0_線_線右3CP;
	}
}
