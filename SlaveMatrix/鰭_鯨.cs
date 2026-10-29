using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 鰭_鯨 : 鰭
	{
		public 鰭_鯨(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 鰭_鯨D e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "鯨鰭";
			dif.Add(new Pars(Sta.肢左["鰭"][1][1]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_鰭 = pars["鰭"].ToPar();
			this.Xasix = false;
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
			this.鰭_表示 = e.鰭_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_鰭CP = new ColorP(this.X0Y0_鰭, this.鰭CD, DisUnit, true);
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

		public bool 鰭_表示
		{
			get
			{
				return this.X0Y0_鰭.Dra;
			}
			set
			{
				this.X0Y0_鰭.Dra = value;
				this.X0Y0_鰭.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.鰭_表示;
			}
			set
			{
				this.鰭_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.鰭CD.不透明度;
			}
			set
			{
				this.鰭CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			double num = this.右 ? -1.0 : 1.0;
			this.X0Y0_鰭.AngleBase = num * -29.0;
			this.本体.JoinPAall();
		}

		public override void 色更新()
		{
			this.X0Y0_鰭CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.鰭CD = new ColorD(ref Col.Black, ref 体配色.体0O);
		}

		public Par X0Y0_鰭;

		public ColorD 鰭CD;

		public ColorP X0Y0_鰭CP;
	}
}
