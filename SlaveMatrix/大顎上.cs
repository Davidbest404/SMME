using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 大顎上 : Ele
	{
		public 大顎上(double DisUnit, 配色指定 配色指定, 体配色 体配色)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.肢中["大顎上"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_甲殻 = pars["甲殻"].ToPar();
			this.X0Y0_線左 = pars["線左"].ToPar();
			this.X0Y0_線右 = pars["線右"].ToPar();
			this.X0Y0_棘左 = pars["刺左"].ToPar();
			this.X0Y0_棘右 = pars["刺右"].ToPar();
			this.本体.SetJoints();
			this.接続根 = new JointD(this.本体);
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_甲殻CP = new ColorP(this.X0Y0_甲殻, this.甲殻CD, DisUnit, true);
			this.X0Y0_線左CP = new ColorP(this.X0Y0_線左, this.線左CD, DisUnit, true);
			this.X0Y0_線右CP = new ColorP(this.X0Y0_線右, this.線右CD, DisUnit, true);
			this.X0Y0_棘左CP = new ColorP(this.X0Y0_棘左, this.刺左CD, DisUnit, true);
			this.X0Y0_棘右CP = new ColorP(this.X0Y0_棘右, this.刺右CD, DisUnit, true);
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

		public bool 甲殻_表示
		{
			get
			{
				return this.X0Y0_甲殻.Dra;
			}
			set
			{
				this.X0Y0_甲殻.Dra = value;
				this.X0Y0_甲殻.Hit = value;
			}
		}

		public bool 線左_表示
		{
			get
			{
				return this.X0Y0_線左.Dra;
			}
			set
			{
				this.X0Y0_線左.Dra = value;
				this.X0Y0_線左.Hit = value;
			}
		}

		public bool 線右_表示
		{
			get
			{
				return this.X0Y0_線右.Dra;
			}
			set
			{
				this.X0Y0_線右.Dra = value;
				this.X0Y0_線右.Hit = value;
			}
		}

		public bool 刺左_表示
		{
			get
			{
				return this.X0Y0_棘左.Dra;
			}
			set
			{
				this.X0Y0_棘左.Dra = value;
				this.X0Y0_棘左.Hit = value;
			}
		}

		public bool 刺右_表示
		{
			get
			{
				return this.X0Y0_棘右.Dra;
			}
			set
			{
				this.X0Y0_棘右.Dra = value;
				this.X0Y0_棘右.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.甲殻_表示;
			}
			set
			{
				this.甲殻_表示 = value;
				this.線左_表示 = value;
				this.線右_表示 = value;
				this.刺左_表示 = value;
				this.刺右_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.甲殻CD.不透明度;
			}
			set
			{
				this.甲殻CD.不透明度 = value;
				this.線左CD.不透明度 = value;
				this.線右CD.不透明度 = value;
				this.刺左CD.不透明度 = value;
				this.刺右CD.不透明度 = value;
			}
		}

		public override void 色更新()
		{
			this.X0Y0_甲殻CP.Update();
			this.X0Y0_線左CP.Update();
			this.X0Y0_線右CP.Update();
			this.X0Y0_棘左CP.Update();
			this.X0Y0_棘右CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.甲殻CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.線左CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.線右CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.刺左CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.刺右CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
		}

		public Par X0Y0_甲殻;

		public Par X0Y0_線左;

		public Par X0Y0_線右;

		public Par X0Y0_棘左;

		public Par X0Y0_棘右;

		public ColorD 甲殻CD;

		public ColorD 線左CD;

		public ColorD 線右CD;

		public ColorD 刺左CD;

		public ColorD 刺右CD;

		public ColorP X0Y0_甲殻CP;

		public ColorP X0Y0_線左CP;

		public ColorP X0Y0_線右CP;

		public ColorP X0Y0_棘左CP;

		public ColorP X0Y0_棘右CP;
	}
}
