using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class キャップ1 : Ele
	{
		public キャップ1(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, キャップ1D e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.性器付["キャップ中"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_根本 = pars["根本"].ToPar();
			this.X0Y0_先端 = pars["先端"].ToPar();
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
			this.根本_表示 = e.根本_表示;
			this.先端_表示 = e.先端_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_根本CP = new ColorP(this.X0Y0_根本, this.根本CD, DisUnit, true);
			this.X0Y0_先端CP = new ColorP(this.X0Y0_先端, this.先端CD, DisUnit, true);
			this.濃度 = e.濃度;
			Vector2D local = this.X0Y0_根本.OP[0].ps[2];
			foreach (Par par in this.本体.EnumJoinRoot)
			{
				par.BasePointBase = par.ToLocal(this.X0Y0_根本.ToGlobal(local));
			}
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

		public bool 根本_表示
		{
			get
			{
				return this.X0Y0_根本.Dra;
			}
			set
			{
				this.X0Y0_根本.Dra = value;
				this.X0Y0_根本.Hit = value;
			}
		}

		public bool 先端_表示
		{
			get
			{
				return this.X0Y0_先端.Dra;
			}
			set
			{
				this.X0Y0_先端.Dra = value;
				this.X0Y0_先端.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.根本_表示;
			}
			set
			{
				this.根本_表示 = value;
				this.先端_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.根本CD.不透明度;
			}
			set
			{
				this.根本CD.不透明度 = value;
				this.先端CD.不透明度 = value;
			}
		}

		public override double 肥大
		{
			set
			{
			}
		}

		public override double 身長
		{
			set
			{
			}
		}

		public override void 色更新()
		{
			this.X0Y0_根本CP.Update();
			this.X0Y0_先端CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.根本CD = new ColorD();
			this.先端CD = new ColorD();
		}

		public void 配色(キャップ色 配色)
		{
			this.根本CD.色 = 配色.根本色;
			this.先端CD.色 = 配色.先端色;
		}

		public Par X0Y0_根本;

		public Par X0Y0_先端;

		public ColorD 根本CD;

		public ColorD 先端CD;

		public ColorP X0Y0_根本CP;

		public ColorP X0Y0_先端CP;
	}
}
