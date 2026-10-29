using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 背中_羽 : 背中
	{
		public 背中_羽(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 背中_羽D e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "羽毛";
			dif.Add(new Pars(Sta.肢中["背中"][0][0]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_羽毛1 = pars["羽毛1"].ToPar();
			this.X0Y0_羽毛2 = pars["羽毛2"].ToPar();
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
			this.羽毛1_表示 = e.羽毛1_表示;
			this.羽毛2_表示 = e.羽毛2_表示;
			if (e.毛)
			{
				this.毛();
			}
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_羽毛1CP = new ColorP(this.X0Y0_羽毛1, this.羽毛1CD, DisUnit, true);
			this.X0Y0_羽毛2CP = new ColorP(this.X0Y0_羽毛2, this.羽毛2CD, DisUnit, true);
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

		public bool 羽毛1_表示
		{
			get
			{
				return this.X0Y0_羽毛1.Dra;
			}
			set
			{
				this.X0Y0_羽毛1.Dra = value;
				this.X0Y0_羽毛1.Hit = value;
			}
		}

		public bool 羽毛2_表示
		{
			get
			{
				return this.X0Y0_羽毛2.Dra;
			}
			set
			{
				this.X0Y0_羽毛2.Dra = value;
				this.X0Y0_羽毛2.Hit = value;
			}
		}

		public void 毛()
		{
			this.X0Y0_羽毛1.OP.SetTension(0f);
			this.X0Y0_羽毛2.OP.SetTension(0f);
		}

		public override bool 表示
		{
			get
			{
				return this.羽毛1_表示;
			}
			set
			{
				this.羽毛1_表示 = value;
				this.羽毛2_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.羽毛1CD.不透明度;
			}
			set
			{
				this.羽毛1CD.不透明度 = value;
				this.羽毛2CD.不透明度 = value;
			}
		}

		public override void 色更新()
		{
			this.X0Y0_羽毛1CP.Update();
			this.X0Y0_羽毛2CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			switch (this.配色指定)
			{
			case 配色指定.N0:
				this.配色N0(体配色);
				return;
			case 配色指定.T0:
				this.配色T0(体配色);
				return;
			case 配色指定.T1:
				this.配色T1(体配色);
				return;
			default:
				this.配色N0(体配色);
				return;
			}
		}

		private void 配色N0(体配色 体配色)
		{
			this.羽毛1CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.羽毛2CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
		}

		private void 配色T0(体配色 体配色)
		{
			this.羽毛1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽毛2CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
		}

		private void 配色T1(体配色 体配色)
		{
			this.羽毛1CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.羽毛2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
		}

		public Par X0Y0_羽毛1;

		public Par X0Y0_羽毛2;

		public ColorD 羽毛1CD;

		public ColorD 羽毛2CD;

		public ColorP X0Y0_羽毛1CP;

		public ColorP X0Y0_羽毛2CP;
	}
}
