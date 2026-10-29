using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 吹出し : Ele
	{
		public 吹出し(double DisUnit)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.胴体["吹出し"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_吹出し = pars["吹出し"].ToPar();
			this.本体.SetJoints();
			this.接続根 = new JointD(this.本体);
			this.吹出しCD = new ColorD();
			this.吹出しCD.線 = Col.Black;
			this.吹出しCD.色 = new Color2(ref Col.White, ref Col.Empty);
			this.X0Y0_吹出しCP = new ColorP(this.X0Y0_吹出し, this.吹出しCD, DisUnit, true);
			this.X0Y0_吹出し.BasePointBase = this.X0Y0_吹出し.BasePointBase.AddX(-0.015);
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

		public bool 吹出し_表示
		{
			get
			{
				return this.X0Y0_吹出し.Dra;
			}
			set
			{
				this.X0Y0_吹出し.Dra = value;
				this.X0Y0_吹出し.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.吹出し_表示;
			}
			set
			{
				this.吹出し_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.吹出しCD.不透明度;
			}
			set
			{
				this.吹出しCD.不透明度 = value;
			}
		}

		public JointS 吹出し_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_吹出し, 0);
			}
		}

		public override void 色更新()
		{
			this.X0Y0_吹出しCP.Update();
		}

		public Par X0Y0_吹出し;

		public ColorD 吹出しCD;

		public ColorP X0Y0_吹出しCP;

		public Ele[] 吹出し_接続;
	}
}
