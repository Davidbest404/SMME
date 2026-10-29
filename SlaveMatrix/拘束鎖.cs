using System;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 拘束鎖 : Ele
	{
		public 拘束鎖(double DisUnit, bool 右, 配色指定 配色指定, 体配色 体配色, bool Xasix)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.その他["拘束鎖"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_鎖2 = pars["鎖2"].ToPar();
			this.X0Y0_鎖1 = pars["鎖1"].ToPar();
			this.X0Y0_鎖4 = pars["鎖4"].ToPar();
			this.X0Y0_鎖3 = pars["鎖3"].ToPar();
			this.X0Y0_鎖6 = pars["鎖6"].ToPar();
			this.X0Y0_鎖5 = pars["鎖5"].ToPar();
			this.X0Y0_鎖8 = pars["鎖8"].ToPar();
			this.X0Y0_鎖7 = pars["鎖7"].ToPar();
			this.X0Y0_鎖9 = pars["鎖9"].ToPar();
			this.本体.SetJoints();
			this.接続根 = new JointD(this.本体);
			if (Xasix)
			{
				this.角度B = 90.0;
			}
			this.右 = 右;
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_鎖2CP = new ColorP(this.X0Y0_鎖2, this.鎖2CD, DisUnit, true);
			this.X0Y0_鎖1CP = new ColorP(this.X0Y0_鎖1, this.鎖1CD, DisUnit, true);
			this.X0Y0_鎖4CP = new ColorP(this.X0Y0_鎖4, this.鎖4CD, DisUnit, true);
			this.X0Y0_鎖3CP = new ColorP(this.X0Y0_鎖3, this.鎖3CD, DisUnit, true);
			this.X0Y0_鎖6CP = new ColorP(this.X0Y0_鎖6, this.鎖6CD, DisUnit, true);
			this.X0Y0_鎖5CP = new ColorP(this.X0Y0_鎖5, this.鎖5CD, DisUnit, true);
			this.X0Y0_鎖8CP = new ColorP(this.X0Y0_鎖8, this.鎖8CD, DisUnit, true);
			this.X0Y0_鎖7CP = new ColorP(this.X0Y0_鎖7, this.鎖7CD, DisUnit, true);
			this.X0Y0_鎖9CP = new ColorP(this.X0Y0_鎖9, this.鎖9CD, DisUnit, true);
			鎖色 鎖色 = default(鎖色);
			鎖色.SetDefault();
			this.配色鎖(鎖色);
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

		public bool 鎖2_表示
		{
			get
			{
				return this.X0Y0_鎖2.Dra;
			}
			set
			{
				this.X0Y0_鎖2.Dra = value;
				this.X0Y0_鎖2.Hit = false;
			}
		}

		public bool 鎖1_表示
		{
			get
			{
				return this.X0Y0_鎖1.Dra;
			}
			set
			{
				this.X0Y0_鎖1.Dra = value;
				this.X0Y0_鎖1.Hit = false;
			}
		}

		public bool 鎖4_表示
		{
			get
			{
				return this.X0Y0_鎖4.Dra;
			}
			set
			{
				this.X0Y0_鎖4.Dra = value;
				this.X0Y0_鎖4.Hit = false;
			}
		}

		public bool 鎖3_表示
		{
			get
			{
				return this.X0Y0_鎖3.Dra;
			}
			set
			{
				this.X0Y0_鎖3.Dra = value;
				this.X0Y0_鎖3.Hit = false;
			}
		}

		public bool 鎖6_表示
		{
			get
			{
				return this.X0Y0_鎖6.Dra;
			}
			set
			{
				this.X0Y0_鎖6.Dra = value;
				this.X0Y0_鎖6.Hit = false;
			}
		}

		public bool 鎖5_表示
		{
			get
			{
				return this.X0Y0_鎖5.Dra;
			}
			set
			{
				this.X0Y0_鎖5.Dra = value;
				this.X0Y0_鎖5.Hit = false;
			}
		}

		public bool 鎖8_表示
		{
			get
			{
				return this.X0Y0_鎖8.Dra;
			}
			set
			{
				this.X0Y0_鎖8.Dra = false;
				this.X0Y0_鎖8.Hit = false;
			}
		}

		public bool 鎖7_表示
		{
			get
			{
				return this.X0Y0_鎖7.Dra;
			}
			set
			{
				this.X0Y0_鎖7.Dra = value;
				this.X0Y0_鎖7.Hit = false;
			}
		}

		public bool 鎖9_表示
		{
			get
			{
				return this.X0Y0_鎖9.Dra;
			}
			set
			{
				this.X0Y0_鎖9.Dra = false;
				this.X0Y0_鎖9.Hit = false;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.鎖2_表示;
			}
			set
			{
				this.鎖2_表示 = value;
				this.鎖1_表示 = value;
				this.鎖4_表示 = value;
				this.鎖3_表示 = value;
				this.鎖6_表示 = value;
				this.鎖5_表示 = value;
				this.鎖8_表示 = value;
				this.鎖7_表示 = value;
				this.鎖9_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.鎖2CD.不透明度;
			}
			set
			{
				this.鎖2CD.不透明度 = value;
				this.鎖1CD.不透明度 = value;
				this.鎖4CD.不透明度 = value;
				this.鎖3CD.不透明度 = value;
				this.鎖6CD.不透明度 = value;
				this.鎖5CD.不透明度 = value;
				this.鎖8CD.不透明度 = value;
				this.鎖7CD.不透明度 = value;
				this.鎖9CD.不透明度 = value;
			}
		}

		public void SetSize()
		{
			Par par = this.接続根.Difs0.Current.GetPar(this.接続根.Path0);
			if (par.JP.Count > 0)
			{
				int num = 0;
				Vector2D vector2D = Dat.Vec2DZero;
				foreach (Out @out in par.OP)
				{
					foreach (Vector2D right in @out.ps.Skip(1).Take(@out.ps.Count - 2))
					{
						vector2D += right;
						num++;
					}
				}
				par.JP[0] = new Joi(vector2D / (double)num);
				this.接続P();
				this.尺度B = (par.GetArea() / this.X0Y0_鎖1.GetArea()).Sqrt() * 1.2;
			}
		}

		public override bool Is鉄(Par p)
		{
			return this.X0Y0_鎖2 == p || this.X0Y0_鎖1 == p || this.X0Y0_鎖4 == p || this.X0Y0_鎖3 == p || this.X0Y0_鎖6 == p || this.X0Y0_鎖5 == p || this.X0Y0_鎖8 == p || this.X0Y0_鎖7 == p || this.X0Y0_鎖9 == p;
		}

		public override void 色更新()
		{
			this.X0Y0_鎖2CP.Update();
			this.X0Y0_鎖1CP.Update();
			this.X0Y0_鎖4CP.Update();
			this.X0Y0_鎖3CP.Update();
			this.X0Y0_鎖6CP.Update();
			this.X0Y0_鎖5CP.Update();
			this.X0Y0_鎖8CP.Update();
			this.X0Y0_鎖7CP.Update();
			this.X0Y0_鎖9CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.鎖2CD = new ColorD();
			this.鎖1CD = new ColorD();
			this.鎖4CD = new ColorD();
			this.鎖3CD = new ColorD();
			this.鎖6CD = new ColorD();
			this.鎖5CD = new ColorD();
			this.鎖8CD = new ColorD();
			this.鎖7CD = new ColorD();
			this.鎖9CD = new ColorD();
			double num = 1.0;
			double num2 = num / 7.0;
			this.鎖1CD.不透明度 = num;
			num -= num2;
			this.鎖2CD.不透明度 = num;
			num -= num2;
			this.鎖3CD.不透明度 = num;
			num -= num2;
			this.鎖4CD.不透明度 = num;
			num -= num2;
			this.鎖5CD.不透明度 = num;
			num -= num2;
			this.鎖6CD.不透明度 = num;
			num -= num2;
			this.鎖7CD.不透明度 = num;
		}

		public void 配色鎖(鎖色 鎖色)
		{
			this.鎖1CD.色 = 鎖色.金属色;
			this.鎖2CD.色 = 鎖色.金属色;
			this.鎖3CD.色 = 鎖色.金属色;
			this.鎖4CD.色 = 鎖色.金属色;
			this.鎖5CD.色 = 鎖色.金属色;
			this.鎖6CD.色 = 鎖色.金属色;
			this.鎖7CD.色 = 鎖色.金属色;
			this.鎖8CD.色 = 鎖色.金属色;
			this.鎖9CD.色 = 鎖色.金属色;
			double num = 1.0;
			double num2 = num / 7.0;
			this.鎖1CD.不透明度 = num;
			num -= num2;
			this.鎖2CD.不透明度 = num;
			num -= num2;
			this.鎖3CD.不透明度 = num;
			num -= num2;
			this.鎖4CD.不透明度 = num;
			num -= num2;
			this.鎖5CD.不透明度 = num;
			num -= num2;
			this.鎖6CD.不透明度 = num;
			num -= num2;
			this.鎖7CD.不透明度 = num;
		}

		public Par X0Y0_鎖2;

		public Par X0Y0_鎖1;

		public Par X0Y0_鎖4;

		public Par X0Y0_鎖3;

		public Par X0Y0_鎖6;

		public Par X0Y0_鎖5;

		public Par X0Y0_鎖8;

		public Par X0Y0_鎖7;

		public Par X0Y0_鎖9;

		public ColorD 鎖2CD;

		public ColorD 鎖1CD;

		public ColorD 鎖4CD;

		public ColorD 鎖3CD;

		public ColorD 鎖6CD;

		public ColorD 鎖5CD;

		public ColorD 鎖8CD;

		public ColorD 鎖7CD;

		public ColorD 鎖9CD;

		public ColorP X0Y0_鎖2CP;

		public ColorP X0Y0_鎖1CP;

		public ColorP X0Y0_鎖4CP;

		public ColorP X0Y0_鎖3CP;

		public ColorP X0Y0_鎖6CP;

		public ColorP X0Y0_鎖5CP;

		public ColorP X0Y0_鎖8CP;

		public ColorP X0Y0_鎖7CP;

		public ColorP X0Y0_鎖9CP;
	}
}
