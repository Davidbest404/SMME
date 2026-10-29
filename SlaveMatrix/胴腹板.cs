using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 胴腹板 : Ele
	{
		public 胴腹板(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 胴腹板D e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.胴体["胴腹板"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_虫性_腹板 = pars["腹板"].ToPar();
			this.X0Y0_虫性_縦線 = pars["縦線"].ToPar();
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
			this.虫性_腹板_表示 = e.虫性_腹板_表示;
			this.虫性_縦線_表示 = e.虫性_縦線_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_虫性_腹板CP = new ColorP(this.X0Y0_虫性_腹板, this.虫性_腹板CD, DisUnit, true);
			this.X0Y0_虫性_縦線CP = new ColorP(this.X0Y0_虫性_縦線, this.虫性_縦線CD, DisUnit, true);
			this.濃度 = e.濃度;
			this.尺度YB = 0.95;
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

		public bool 虫性_腹板_表示
		{
			get
			{
				return this.X0Y0_虫性_腹板.Dra;
			}
			set
			{
				this.X0Y0_虫性_腹板.Dra = value;
				this.X0Y0_虫性_腹板.Hit = value;
			}
		}

		public bool 虫性_縦線_表示
		{
			get
			{
				return this.X0Y0_虫性_縦線.Dra;
			}
			set
			{
				this.X0Y0_虫性_縦線.Dra = value;
				this.X0Y0_虫性_縦線.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.虫性_腹板_表示;
			}
			set
			{
				this.虫性_腹板_表示 = value;
				this.虫性_縦線_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.虫性_腹板CD.不透明度;
			}
			set
			{
				this.虫性_腹板CD.不透明度 = value;
				this.虫性_縦線CD.不透明度 = value;
			}
		}

		public override void 色更新()
		{
			this.X0Y0_虫性_腹板CP.Update();
			this.X0Y0_虫性_縦線CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.虫性_腹板CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.虫性_縦線CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
		}

		public Par X0Y0_虫性_腹板;

		public Par X0Y0_虫性_縦線;

		public ColorD 虫性_腹板CD;

		public ColorD 虫性_縦線CD;

		public ColorP X0Y0_虫性_腹板CP;

		public ColorP X0Y0_虫性_縦線CP;
	}
}
