using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 膣内精液_獣 : 膣内精液
	{
		public 膣内精液_獣(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 膣内精液_獣D e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.半身["四足膣内精液"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_精液 = pars["精液"].ToPar();
			this.X0Y0_血液1 = pars["血液1"].ToPar();
			this.X0Y0_血液2 = pars["血液2"].ToPar();
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
			this.精液_表示 = e.精液_表示;
			this.血液1_表示 = e.血液1_表示;
			this.血液2_表示 = e.血液2_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_精液CP = new ColorP(this.X0Y0_精液, this.精液CD, DisUnit, true);
			this.X0Y0_血液1CP = new ColorP(this.X0Y0_血液1, this.血液1CD, DisUnit, true);
			this.X0Y0_血液2CP = new ColorP(this.X0Y0_血液2, this.血液2CD, DisUnit, true);
			this.濃度 = e.濃度;
			this.精液濃度 = e.精液濃度;
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

		public override bool 精液_表示
		{
			get
			{
				return this.X0Y0_精液.Dra;
			}
			set
			{
				this.X0Y0_精液.Dra = value;
				this.X0Y0_精液.Hit = value;
			}
		}

		public override bool 血液1_表示
		{
			get
			{
				return this.X0Y0_血液1.Dra;
			}
			set
			{
				this.X0Y0_血液1.Dra = value;
				this.X0Y0_血液1.Hit = value;
			}
		}

		public override bool 血液2_表示
		{
			get
			{
				return this.X0Y0_血液2.Dra;
			}
			set
			{
				this.X0Y0_血液2.Dra = value;
				this.X0Y0_血液2.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.精液_表示;
			}
			set
			{
				this.精液_表示 = value;
				this.血液1_表示 = value;
				this.血液2_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.精液CD.不透明度;
			}
			set
			{
				this.精液CD.不透明度 = value;
				this.血液1CD.不透明度 = value;
				this.血液2CD.不透明度 = value;
			}
		}

		public override double 精液濃度
		{
			get
			{
				return this.精液CD.不透明度;
			}
			set
			{
				this.精液CD.不透明度 = value;
			}
		}

		public override void 色更新()
		{
			this.X0Y0_精液CP.Update();
			this.X0Y0_血液1CP.Update();
			this.X0Y0_血液2CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.精液CD = new ColorD();
			this.血液1CD = new ColorD(ref Col.Empty, ref 体配色.血液O);
			this.血液2CD = new ColorD(ref Col.Empty, ref 体配色.血液O);
		}

		public void 精液配色(主人公配色 配色)
		{
			this.精液CD.線 = 配色.精線;
			this.精液CD.色 = 配色.精液ぶっかけ;
			this.X0Y0_精液CP.Setting();
		}

		public Par X0Y0_精液;

		public Par X0Y0_血液1;

		public Par X0Y0_血液2;

		public ColorD 精液CD;

		public ColorD 血液1CD;

		public ColorD 血液2CD;

		public ColorP X0Y0_精液CP;

		public ColorP X0Y0_血液1CP;

		public ColorP X0Y0_血液2CP;
	}
}
