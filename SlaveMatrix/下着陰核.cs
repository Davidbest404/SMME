using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 下着陰核 : Ele
	{
		public 下着陰核(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 下着陰核D e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.胴体["下着陰核"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_陰核 = pars["陰核"].ToPar();
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
			this.陰核_表示 = e.陰核_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_陰核CP = new ColorP(this.X0Y0_陰核, this.陰核CD, DisUnit, true);
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

		public bool 陰核_表示
		{
			get
			{
				return this.X0Y0_陰核.Dra;
			}
			set
			{
				this.X0Y0_陰核.Dra = value;
				this.X0Y0_陰核.Hit = false;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.陰核_表示;
			}
			set
			{
				this.陰核_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.陰核CD.不透明度;
			}
			set
			{
				this.陰核CD.不透明度 = value;
			}
		}

		public override void 色更新()
		{
			this.X0Y0_陰核CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.陰核CD = new ColorD();
		}

		public void 配色(Color2 配色)
		{
			this.陰核CD.線 = Col.Empty;
			this.陰核CD.色 = 配色;
			this.X0Y0_陰核CP.Setting();
		}

		public Par X0Y0_陰核;

		public ColorD 陰核CD;

		public ColorP X0Y0_陰核CP;
	}
}
