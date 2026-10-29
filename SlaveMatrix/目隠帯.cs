using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 目隠帯 : Ele
	{
		public 目隠帯(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 目隠帯D e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.胴体["目隠帯"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_革 = pars["革"].ToPar();
			this.X0Y0_丸金具上中 = pars["丸金具上中"].ToPar();
			this.X0Y0_丸金具上左1 = pars["丸金具上左1"].ToPar();
			this.X0Y0_丸金具上左2 = pars["丸金具上左2"].ToPar();
			this.X0Y0_丸金具上左3 = pars["丸金具上左3"].ToPar();
			this.X0Y0_丸金具上左4 = pars["丸金具上左4"].ToPar();
			this.X0Y0_丸金具上左5 = pars["丸金具上左5"].ToPar();
			this.X0Y0_丸金具上右1 = pars["丸金具上右1"].ToPar();
			this.X0Y0_丸金具上右2 = pars["丸金具上右2"].ToPar();
			this.X0Y0_丸金具上右3 = pars["丸金具上右3"].ToPar();
			this.X0Y0_丸金具上右4 = pars["丸金具上右4"].ToPar();
			this.X0Y0_丸金具上右5 = pars["丸金具上右5"].ToPar();
			this.X0Y0_丸金具下左1 = pars["丸金具下左1"].ToPar();
			this.X0Y0_丸金具下左2 = pars["丸金具下左2"].ToPar();
			this.X0Y0_丸金具下左3 = pars["丸金具下左3"].ToPar();
			this.X0Y0_丸金具下左4 = pars["丸金具下左4"].ToPar();
			this.X0Y0_丸金具下左5 = pars["丸金具下左5"].ToPar();
			this.X0Y0_丸金具下右1 = pars["丸金具下右1"].ToPar();
			this.X0Y0_丸金具下右2 = pars["丸金具下右2"].ToPar();
			this.X0Y0_丸金具下右3 = pars["丸金具下右3"].ToPar();
			this.X0Y0_丸金具下右4 = pars["丸金具下右4"].ToPar();
			this.X0Y0_丸金具下右5 = pars["丸金具下右5"].ToPar();
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
			this.革_表示 = e.革_表示;
			this.丸金具上中_表示 = e.丸金具上中_表示;
			this.丸金具上左1_表示 = e.丸金具上左1_表示;
			this.丸金具上左2_表示 = e.丸金具上左2_表示;
			this.丸金具上左3_表示 = e.丸金具上左3_表示;
			this.丸金具上左4_表示 = e.丸金具上左4_表示;
			this.丸金具上左5_表示 = e.丸金具上左5_表示;
			this.丸金具上右1_表示 = e.丸金具上右1_表示;
			this.丸金具上右2_表示 = e.丸金具上右2_表示;
			this.丸金具上右3_表示 = e.丸金具上右3_表示;
			this.丸金具上右4_表示 = e.丸金具上右4_表示;
			this.丸金具上右5_表示 = e.丸金具上右5_表示;
			this.丸金具下左1_表示 = e.丸金具下左1_表示;
			this.丸金具下左2_表示 = e.丸金具下左2_表示;
			this.丸金具下左3_表示 = e.丸金具下左3_表示;
			this.丸金具下左4_表示 = e.丸金具下左4_表示;
			this.丸金具下左5_表示 = e.丸金具下左5_表示;
			this.丸金具下右1_表示 = e.丸金具下右1_表示;
			this.丸金具下右2_表示 = e.丸金具下右2_表示;
			this.丸金具下右3_表示 = e.丸金具下右3_表示;
			this.丸金具下右4_表示 = e.丸金具下右4_表示;
			this.丸金具下右5_表示 = e.丸金具下右5_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_革CP = new ColorP(this.X0Y0_革, this.革CD, DisUnit, true);
			this.X0Y0_丸金具上中CP = new ColorP(this.X0Y0_丸金具上中, this.丸金具上中CD, DisUnit, true);
			this.X0Y0_丸金具上左1CP = new ColorP(this.X0Y0_丸金具上左1, this.丸金具上左1CD, DisUnit, true);
			this.X0Y0_丸金具上左2CP = new ColorP(this.X0Y0_丸金具上左2, this.丸金具上左2CD, DisUnit, true);
			this.X0Y0_丸金具上左3CP = new ColorP(this.X0Y0_丸金具上左3, this.丸金具上左3CD, DisUnit, true);
			this.X0Y0_丸金具上左4CP = new ColorP(this.X0Y0_丸金具上左4, this.丸金具上左4CD, DisUnit, true);
			this.X0Y0_丸金具上左5CP = new ColorP(this.X0Y0_丸金具上左5, this.丸金具上左5CD, DisUnit, true);
			this.X0Y0_丸金具上右1CP = new ColorP(this.X0Y0_丸金具上右1, this.丸金具上右1CD, DisUnit, true);
			this.X0Y0_丸金具上右2CP = new ColorP(this.X0Y0_丸金具上右2, this.丸金具上右2CD, DisUnit, true);
			this.X0Y0_丸金具上右3CP = new ColorP(this.X0Y0_丸金具上右3, this.丸金具上右3CD, DisUnit, true);
			this.X0Y0_丸金具上右4CP = new ColorP(this.X0Y0_丸金具上右4, this.丸金具上右4CD, DisUnit, true);
			this.X0Y0_丸金具上右5CP = new ColorP(this.X0Y0_丸金具上右5, this.丸金具上右5CD, DisUnit, true);
			this.X0Y0_丸金具下左1CP = new ColorP(this.X0Y0_丸金具下左1, this.丸金具下左1CD, DisUnit, true);
			this.X0Y0_丸金具下左2CP = new ColorP(this.X0Y0_丸金具下左2, this.丸金具下左2CD, DisUnit, true);
			this.X0Y0_丸金具下左3CP = new ColorP(this.X0Y0_丸金具下左3, this.丸金具下左3CD, DisUnit, true);
			this.X0Y0_丸金具下左4CP = new ColorP(this.X0Y0_丸金具下左4, this.丸金具下左4CD, DisUnit, true);
			this.X0Y0_丸金具下左5CP = new ColorP(this.X0Y0_丸金具下左5, this.丸金具下左5CD, DisUnit, true);
			this.X0Y0_丸金具下右1CP = new ColorP(this.X0Y0_丸金具下右1, this.丸金具下右1CD, DisUnit, true);
			this.X0Y0_丸金具下右2CP = new ColorP(this.X0Y0_丸金具下右2, this.丸金具下右2CD, DisUnit, true);
			this.X0Y0_丸金具下右3CP = new ColorP(this.X0Y0_丸金具下右3, this.丸金具下右3CD, DisUnit, true);
			this.X0Y0_丸金具下右4CP = new ColorP(this.X0Y0_丸金具下右4, this.丸金具下右4CD, DisUnit, true);
			this.X0Y0_丸金具下右5CP = new ColorP(this.X0Y0_丸金具下右5, this.丸金具下右5CD, DisUnit, true);
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

		public bool 革_表示
		{
			get
			{
				return this.X0Y0_革.Dra;
			}
			set
			{
				this.X0Y0_革.Dra = value;
				this.X0Y0_革.Hit = value;
			}
		}

		public bool 丸金具上中_表示
		{
			get
			{
				return this.X0Y0_丸金具上中.Dra;
			}
			set
			{
				this.X0Y0_丸金具上中.Dra = value;
				this.X0Y0_丸金具上中.Hit = value;
			}
		}

		public bool 丸金具上左1_表示
		{
			get
			{
				return this.X0Y0_丸金具上左1.Dra;
			}
			set
			{
				this.X0Y0_丸金具上左1.Dra = value;
				this.X0Y0_丸金具上左1.Hit = value;
			}
		}

		public bool 丸金具上左2_表示
		{
			get
			{
				return this.X0Y0_丸金具上左2.Dra;
			}
			set
			{
				this.X0Y0_丸金具上左2.Dra = value;
				this.X0Y0_丸金具上左2.Hit = value;
			}
		}

		public bool 丸金具上左3_表示
		{
			get
			{
				return this.X0Y0_丸金具上左3.Dra;
			}
			set
			{
				this.X0Y0_丸金具上左3.Dra = value;
				this.X0Y0_丸金具上左3.Hit = value;
			}
		}

		public bool 丸金具上左4_表示
		{
			get
			{
				return this.X0Y0_丸金具上左4.Dra;
			}
			set
			{
				this.X0Y0_丸金具上左4.Dra = value;
				this.X0Y0_丸金具上左4.Hit = value;
			}
		}

		public bool 丸金具上左5_表示
		{
			get
			{
				return this.X0Y0_丸金具上左5.Dra;
			}
			set
			{
				this.X0Y0_丸金具上左5.Dra = value;
				this.X0Y0_丸金具上左5.Hit = value;
			}
		}

		public bool 丸金具上右1_表示
		{
			get
			{
				return this.X0Y0_丸金具上右1.Dra;
			}
			set
			{
				this.X0Y0_丸金具上右1.Dra = value;
				this.X0Y0_丸金具上右1.Hit = value;
			}
		}

		public bool 丸金具上右2_表示
		{
			get
			{
				return this.X0Y0_丸金具上右2.Dra;
			}
			set
			{
				this.X0Y0_丸金具上右2.Dra = value;
				this.X0Y0_丸金具上右2.Hit = value;
			}
		}

		public bool 丸金具上右3_表示
		{
			get
			{
				return this.X0Y0_丸金具上右3.Dra;
			}
			set
			{
				this.X0Y0_丸金具上右3.Dra = value;
				this.X0Y0_丸金具上右3.Hit = value;
			}
		}

		public bool 丸金具上右4_表示
		{
			get
			{
				return this.X0Y0_丸金具上右4.Dra;
			}
			set
			{
				this.X0Y0_丸金具上右4.Dra = value;
				this.X0Y0_丸金具上右4.Hit = value;
			}
		}

		public bool 丸金具上右5_表示
		{
			get
			{
				return this.X0Y0_丸金具上右5.Dra;
			}
			set
			{
				this.X0Y0_丸金具上右5.Dra = value;
				this.X0Y0_丸金具上右5.Hit = value;
			}
		}

		public bool 丸金具下左1_表示
		{
			get
			{
				return this.X0Y0_丸金具下左1.Dra;
			}
			set
			{
				this.X0Y0_丸金具下左1.Dra = value;
				this.X0Y0_丸金具下左1.Hit = value;
			}
		}

		public bool 丸金具下左2_表示
		{
			get
			{
				return this.X0Y0_丸金具下左2.Dra;
			}
			set
			{
				this.X0Y0_丸金具下左2.Dra = value;
				this.X0Y0_丸金具下左2.Hit = value;
			}
		}

		public bool 丸金具下左3_表示
		{
			get
			{
				return this.X0Y0_丸金具下左3.Dra;
			}
			set
			{
				this.X0Y0_丸金具下左3.Dra = value;
				this.X0Y0_丸金具下左3.Hit = value;
			}
		}

		public bool 丸金具下左4_表示
		{
			get
			{
				return this.X0Y0_丸金具下左4.Dra;
			}
			set
			{
				this.X0Y0_丸金具下左4.Dra = value;
				this.X0Y0_丸金具下左4.Hit = value;
			}
		}

		public bool 丸金具下左5_表示
		{
			get
			{
				return this.X0Y0_丸金具下左5.Dra;
			}
			set
			{
				this.X0Y0_丸金具下左5.Dra = value;
				this.X0Y0_丸金具下左5.Hit = value;
			}
		}

		public bool 丸金具下右1_表示
		{
			get
			{
				return this.X0Y0_丸金具下右1.Dra;
			}
			set
			{
				this.X0Y0_丸金具下右1.Dra = value;
				this.X0Y0_丸金具下右1.Hit = value;
			}
		}

		public bool 丸金具下右2_表示
		{
			get
			{
				return this.X0Y0_丸金具下右2.Dra;
			}
			set
			{
				this.X0Y0_丸金具下右2.Dra = value;
				this.X0Y0_丸金具下右2.Hit = value;
			}
		}

		public bool 丸金具下右3_表示
		{
			get
			{
				return this.X0Y0_丸金具下右3.Dra;
			}
			set
			{
				this.X0Y0_丸金具下右3.Dra = value;
				this.X0Y0_丸金具下右3.Hit = value;
			}
		}

		public bool 丸金具下右4_表示
		{
			get
			{
				return this.X0Y0_丸金具下右4.Dra;
			}
			set
			{
				this.X0Y0_丸金具下右4.Dra = value;
				this.X0Y0_丸金具下右4.Hit = value;
			}
		}

		public bool 丸金具下右5_表示
		{
			get
			{
				return this.X0Y0_丸金具下右5.Dra;
			}
			set
			{
				this.X0Y0_丸金具下右5.Dra = value;
				this.X0Y0_丸金具下右5.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.革_表示;
			}
			set
			{
				this.革_表示 = value;
				this.丸金具上中_表示 = value;
				this.丸金具上左1_表示 = value;
				this.丸金具上左2_表示 = value;
				this.丸金具上左3_表示 = value;
				this.丸金具上左4_表示 = value;
				this.丸金具上左5_表示 = value;
				this.丸金具上右1_表示 = value;
				this.丸金具上右2_表示 = value;
				this.丸金具上右3_表示 = value;
				this.丸金具上右4_表示 = value;
				this.丸金具上右5_表示 = value;
				this.丸金具下左1_表示 = value;
				this.丸金具下左2_表示 = value;
				this.丸金具下左3_表示 = value;
				this.丸金具下左4_表示 = value;
				this.丸金具下左5_表示 = value;
				this.丸金具下右1_表示 = value;
				this.丸金具下右2_表示 = value;
				this.丸金具下右3_表示 = value;
				this.丸金具下右4_表示 = value;
				this.丸金具下右5_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.革CD.不透明度;
			}
			set
			{
				this.革CD.不透明度 = value;
				this.丸金具上中CD.不透明度 = value;
				this.丸金具上左1CD.不透明度 = value;
				this.丸金具上左2CD.不透明度 = value;
				this.丸金具上左3CD.不透明度 = value;
				this.丸金具上左4CD.不透明度 = value;
				this.丸金具上左5CD.不透明度 = value;
				this.丸金具上右1CD.不透明度 = value;
				this.丸金具上右2CD.不透明度 = value;
				this.丸金具上右3CD.不透明度 = value;
				this.丸金具上右4CD.不透明度 = value;
				this.丸金具上右5CD.不透明度 = value;
				this.丸金具下左1CD.不透明度 = value;
				this.丸金具下左2CD.不透明度 = value;
				this.丸金具下左3CD.不透明度 = value;
				this.丸金具下左4CD.不透明度 = value;
				this.丸金具下左5CD.不透明度 = value;
				this.丸金具下右1CD.不透明度 = value;
				this.丸金具下右2CD.不透明度 = value;
				this.丸金具下右3CD.不透明度 = value;
				this.丸金具下右4CD.不透明度 = value;
				this.丸金具下右5CD.不透明度 = value;
			}
		}

		public override bool Is革(Par p)
		{
			return p == this.X0Y0_革 || p == this.X0Y0_丸金具上中 || p == this.X0Y0_丸金具上左1 || p == this.X0Y0_丸金具上左2 || p == this.X0Y0_丸金具上左3 || p == this.X0Y0_丸金具上左4 || p == this.X0Y0_丸金具上左5 || p == this.X0Y0_丸金具上右1 || p == this.X0Y0_丸金具上右2 || p == this.X0Y0_丸金具上右3 || p == this.X0Y0_丸金具上右4 || p == this.X0Y0_丸金具上右5 || p == this.X0Y0_丸金具下左1 || p == this.X0Y0_丸金具下左2 || p == this.X0Y0_丸金具下左3 || p == this.X0Y0_丸金具下左4 || p == this.X0Y0_丸金具下左5 || p == this.X0Y0_丸金具下右1 || p == this.X0Y0_丸金具下右2 || p == this.X0Y0_丸金具下右3 || p == this.X0Y0_丸金具下右4 || p == this.X0Y0_丸金具下右5;
		}

		public override void 色更新()
		{
			this.X0Y0_革CP.Update();
			this.X0Y0_丸金具上中CP.Update();
			this.X0Y0_丸金具上左1CP.Update();
			this.X0Y0_丸金具上左2CP.Update();
			this.X0Y0_丸金具上左3CP.Update();
			this.X0Y0_丸金具上左4CP.Update();
			this.X0Y0_丸金具上左5CP.Update();
			this.X0Y0_丸金具上右1CP.Update();
			this.X0Y0_丸金具上右2CP.Update();
			this.X0Y0_丸金具上右3CP.Update();
			this.X0Y0_丸金具上右4CP.Update();
			this.X0Y0_丸金具上右5CP.Update();
			this.X0Y0_丸金具下左1CP.Update();
			this.X0Y0_丸金具下左2CP.Update();
			this.X0Y0_丸金具下左3CP.Update();
			this.X0Y0_丸金具下左4CP.Update();
			this.X0Y0_丸金具下左5CP.Update();
			this.X0Y0_丸金具下右1CP.Update();
			this.X0Y0_丸金具下右2CP.Update();
			this.X0Y0_丸金具下右3CP.Update();
			this.X0Y0_丸金具下右4CP.Update();
			this.X0Y0_丸金具下右5CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.革CD = new ColorD();
			this.丸金具上中CD = new ColorD();
			this.丸金具上左1CD = new ColorD();
			this.丸金具上左2CD = new ColorD();
			this.丸金具上左3CD = new ColorD();
			this.丸金具上左4CD = new ColorD();
			this.丸金具上左5CD = new ColorD();
			this.丸金具上右1CD = new ColorD();
			this.丸金具上右2CD = new ColorD();
			this.丸金具上右3CD = new ColorD();
			this.丸金具上右4CD = new ColorD();
			this.丸金具上右5CD = new ColorD();
			this.丸金具下左1CD = new ColorD();
			this.丸金具下左2CD = new ColorD();
			this.丸金具下左3CD = new ColorD();
			this.丸金具下左4CD = new ColorD();
			this.丸金具下左5CD = new ColorD();
			this.丸金具下右1CD = new ColorD();
			this.丸金具下右2CD = new ColorD();
			this.丸金具下右3CD = new ColorD();
			this.丸金具下右4CD = new ColorD();
			this.丸金具下右5CD = new ColorD();
		}

		public void 配色(拘束具色 配色)
		{
			this.革CD.色 = 配色.革部色;
			this.丸金具上中CD.色 = 配色.金具色;
			this.丸金具上左1CD.色 = this.丸金具上中CD.色;
			this.丸金具上左2CD.色 = this.丸金具上中CD.色;
			this.丸金具上左3CD.色 = this.丸金具上中CD.色;
			this.丸金具上左4CD.色 = this.丸金具上中CD.色;
			this.丸金具上左5CD.色 = this.丸金具上中CD.色;
			this.丸金具上右1CD.色 = this.丸金具上中CD.色;
			this.丸金具上右2CD.色 = this.丸金具上中CD.色;
			this.丸金具上右3CD.色 = this.丸金具上中CD.色;
			this.丸金具上右4CD.色 = this.丸金具上中CD.色;
			this.丸金具上右5CD.色 = this.丸金具上中CD.色;
			this.丸金具下左1CD.色 = this.丸金具上中CD.色;
			this.丸金具下左2CD.色 = this.丸金具上中CD.色;
			this.丸金具下左3CD.色 = this.丸金具上中CD.色;
			this.丸金具下左4CD.色 = this.丸金具上中CD.色;
			this.丸金具下左5CD.色 = this.丸金具上中CD.色;
			this.丸金具下右1CD.色 = this.丸金具上中CD.色;
			this.丸金具下右2CD.色 = this.丸金具上中CD.色;
			this.丸金具下右3CD.色 = this.丸金具上中CD.色;
			this.丸金具下右4CD.色 = this.丸金具上中CD.色;
			this.丸金具下右5CD.色 = this.丸金具上中CD.色;
		}

		public Par X0Y0_革;

		public Par X0Y0_丸金具上中;

		public Par X0Y0_丸金具上左1;

		public Par X0Y0_丸金具上左2;

		public Par X0Y0_丸金具上左3;

		public Par X0Y0_丸金具上左4;

		public Par X0Y0_丸金具上左5;

		public Par X0Y0_丸金具上右1;

		public Par X0Y0_丸金具上右2;

		public Par X0Y0_丸金具上右3;

		public Par X0Y0_丸金具上右4;

		public Par X0Y0_丸金具上右5;

		public Par X0Y0_丸金具下左1;

		public Par X0Y0_丸金具下左2;

		public Par X0Y0_丸金具下左3;

		public Par X0Y0_丸金具下左4;

		public Par X0Y0_丸金具下左5;

		public Par X0Y0_丸金具下右1;

		public Par X0Y0_丸金具下右2;

		public Par X0Y0_丸金具下右3;

		public Par X0Y0_丸金具下右4;

		public Par X0Y0_丸金具下右5;

		public ColorD 革CD;

		public ColorD 丸金具上中CD;

		public ColorD 丸金具上左1CD;

		public ColorD 丸金具上左2CD;

		public ColorD 丸金具上左3CD;

		public ColorD 丸金具上左4CD;

		public ColorD 丸金具上左5CD;

		public ColorD 丸金具上右1CD;

		public ColorD 丸金具上右2CD;

		public ColorD 丸金具上右3CD;

		public ColorD 丸金具上右4CD;

		public ColorD 丸金具上右5CD;

		public ColorD 丸金具下左1CD;

		public ColorD 丸金具下左2CD;

		public ColorD 丸金具下左3CD;

		public ColorD 丸金具下左4CD;

		public ColorD 丸金具下左5CD;

		public ColorD 丸金具下右1CD;

		public ColorD 丸金具下右2CD;

		public ColorD 丸金具下右3CD;

		public ColorD 丸金具下右4CD;

		public ColorD 丸金具下右5CD;

		public ColorP X0Y0_革CP;

		public ColorP X0Y0_丸金具上中CP;

		public ColorP X0Y0_丸金具上左1CP;

		public ColorP X0Y0_丸金具上左2CP;

		public ColorP X0Y0_丸金具上左3CP;

		public ColorP X0Y0_丸金具上左4CP;

		public ColorP X0Y0_丸金具上左5CP;

		public ColorP X0Y0_丸金具上右1CP;

		public ColorP X0Y0_丸金具上右2CP;

		public ColorP X0Y0_丸金具上右3CP;

		public ColorP X0Y0_丸金具上右4CP;

		public ColorP X0Y0_丸金具上右5CP;

		public ColorP X0Y0_丸金具下左1CP;

		public ColorP X0Y0_丸金具下左2CP;

		public ColorP X0Y0_丸金具下左3CP;

		public ColorP X0Y0_丸金具下左4CP;

		public ColorP X0Y0_丸金具下左5CP;

		public ColorP X0Y0_丸金具下右1CP;

		public ColorP X0Y0_丸金具下右2CP;

		public ColorP X0Y0_丸金具下右3CP;

		public ColorP X0Y0_丸金具下右4CP;

		public ColorP X0Y0_丸金具下右5CP;
	}
}
