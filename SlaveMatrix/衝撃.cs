using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 衝撃 : Ele
	{
		public 衝撃(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 衝撃D e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.その他["衝撃"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_衝撃 = pars["衝撃"].ToPar();
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
			this.衝撃_表示 = e.衝撃_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_衝撃CP = new ColorP(this.X0Y0_衝撃, this.衝撃CD, DisUnit, true);
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

		public bool 衝撃_表示
		{
			get
			{
				return this.X0Y0_衝撃.Dra;
			}
			set
			{
				this.X0Y0_衝撃.Dra = value;
				this.X0Y0_衝撃.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.衝撃_表示;
			}
			set
			{
				this.衝撃_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.衝撃CD.不透明度;
			}
			set
			{
				this.衝撃CD.不透明度 = value;
			}
		}

		public override void 色更新()
		{
			this.X0Y0_衝撃CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.衝撃CD = new ColorD();
			this.衝撃CD.線 = Col.Empty;
			this.衝撃CD.色 = new Color2(ref Col.White, ref Col.Empty);
		}

		public Par X0Y0_衝撃;

		public ColorD 衝撃CD;

		public ColorP X0Y0_衝撃CP;
	}
}
