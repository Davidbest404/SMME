using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 胴肌 : Ele
	{
		public 胴肌(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 胴肌D e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.胴体["胴肌"]);
			Pars pars = this.本体[0][0]["植タトゥ"].ToPars();
			this.X0Y0_植タトゥ_タトゥ花左 = pars["タトゥ花左"].ToPar();
			this.X0Y0_植タトゥ_タトゥ花右 = pars["タトゥ花右"].ToPar();
			this.X0Y0_植タトゥ_タトゥ花 = pars["タトゥ花"].ToPar();
			this.X0Y0_植タトゥ_タトゥ茎 = pars["タトゥ茎"].ToPar();
			this.X0Y0_植タトゥ_タトゥ葉左 = pars["タトゥ葉左"].ToPar();
			this.X0Y0_植タトゥ_タトゥ葉右 = pars["タトゥ葉右"].ToPar();
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
			this.植タトゥ_タトゥ花左_表示 = e.植タトゥ_タトゥ花左_表示;
			this.植タトゥ_タトゥ花右_表示 = e.植タトゥ_タトゥ花右_表示;
			this.植タトゥ_タトゥ花_表示 = e.植タトゥ_タトゥ花_表示;
			this.植タトゥ_タトゥ茎_表示 = e.植タトゥ_タトゥ茎_表示;
			this.植タトゥ_タトゥ葉左_表示 = e.植タトゥ_タトゥ葉左_表示;
			this.植タトゥ_タトゥ葉右_表示 = e.植タトゥ_タトゥ葉右_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_植タトゥ_タトゥ花左CP = new ColorP(this.X0Y0_植タトゥ_タトゥ花左, this.植タトゥ_タトゥ花左CD, DisUnit, true);
			this.X0Y0_植タトゥ_タトゥ花右CP = new ColorP(this.X0Y0_植タトゥ_タトゥ花右, this.植タトゥ_タトゥ花右CD, DisUnit, true);
			this.X0Y0_植タトゥ_タトゥ花CP = new ColorP(this.X0Y0_植タトゥ_タトゥ花, this.植タトゥ_タトゥ花CD, DisUnit, true);
			this.X0Y0_植タトゥ_タトゥ茎CP = new ColorP(this.X0Y0_植タトゥ_タトゥ茎, this.植タトゥ_タトゥ茎CD, DisUnit, true);
			this.X0Y0_植タトゥ_タトゥ葉左CP = new ColorP(this.X0Y0_植タトゥ_タトゥ葉左, this.植タトゥ_タトゥ葉左CD, DisUnit, true);
			this.X0Y0_植タトゥ_タトゥ葉右CP = new ColorP(this.X0Y0_植タトゥ_タトゥ葉右, this.植タトゥ_タトゥ葉右CD, DisUnit, true);
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

		public bool 植タトゥ_タトゥ花左_表示
		{
			get
			{
				return this.X0Y0_植タトゥ_タトゥ花左.Dra;
			}
			set
			{
				this.X0Y0_植タトゥ_タトゥ花左.Dra = value;
				this.X0Y0_植タトゥ_タトゥ花左.Hit = value;
			}
		}

		public bool 植タトゥ_タトゥ花右_表示
		{
			get
			{
				return this.X0Y0_植タトゥ_タトゥ花右.Dra;
			}
			set
			{
				this.X0Y0_植タトゥ_タトゥ花右.Dra = value;
				this.X0Y0_植タトゥ_タトゥ花右.Hit = value;
			}
		}

		public bool 植タトゥ_タトゥ花_表示
		{
			get
			{
				return this.X0Y0_植タトゥ_タトゥ花.Dra;
			}
			set
			{
				this.X0Y0_植タトゥ_タトゥ花.Dra = value;
				this.X0Y0_植タトゥ_タトゥ花.Hit = value;
			}
		}

		public bool 植タトゥ_タトゥ茎_表示
		{
			get
			{
				return this.X0Y0_植タトゥ_タトゥ茎.Dra;
			}
			set
			{
				this.X0Y0_植タトゥ_タトゥ茎.Dra = value;
				this.X0Y0_植タトゥ_タトゥ茎.Hit = value;
			}
		}

		public bool 植タトゥ_タトゥ葉左_表示
		{
			get
			{
				return this.X0Y0_植タトゥ_タトゥ葉左.Dra;
			}
			set
			{
				this.X0Y0_植タトゥ_タトゥ葉左.Dra = value;
				this.X0Y0_植タトゥ_タトゥ葉左.Hit = value;
			}
		}

		public bool 植タトゥ_タトゥ葉右_表示
		{
			get
			{
				return this.X0Y0_植タトゥ_タトゥ葉右.Dra;
			}
			set
			{
				this.X0Y0_植タトゥ_タトゥ葉右.Dra = value;
				this.X0Y0_植タトゥ_タトゥ葉右.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.植タトゥ_タトゥ花左_表示;
			}
			set
			{
				this.植タトゥ_タトゥ花左_表示 = value;
				this.植タトゥ_タトゥ花右_表示 = value;
				this.植タトゥ_タトゥ花_表示 = value;
				this.植タトゥ_タトゥ茎_表示 = value;
				this.植タトゥ_タトゥ葉左_表示 = value;
				this.植タトゥ_タトゥ葉右_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.植タトゥ_タトゥ花左CD.不透明度;
			}
			set
			{
				this.植タトゥ_タトゥ花左CD.不透明度 = value;
				this.植タトゥ_タトゥ花右CD.不透明度 = value;
				this.植タトゥ_タトゥ花CD.不透明度 = value;
				this.植タトゥ_タトゥ茎CD.不透明度 = value;
				this.植タトゥ_タトゥ葉左CD.不透明度 = value;
				this.植タトゥ_タトゥ葉右CD.不透明度 = value;
			}
		}

		public override void 色更新()
		{
			this.X0Y0_植タトゥ_タトゥ花左CP.Update();
			this.X0Y0_植タトゥ_タトゥ花右CP.Update();
			this.X0Y0_植タトゥ_タトゥ花CP.Update();
			this.X0Y0_植タトゥ_タトゥ茎CP.Update();
			this.X0Y0_植タトゥ_タトゥ葉左CP.Update();
			this.X0Y0_植タトゥ_タトゥ葉右CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.植タトゥ_タトゥ花左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.植タトゥ_タトゥ花右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.植タトゥ_タトゥ花CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.植タトゥ_タトゥ茎CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.植タトゥ_タトゥ葉左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.植タトゥ_タトゥ葉右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
		}

		public Par X0Y0_植タトゥ_タトゥ花左;

		public Par X0Y0_植タトゥ_タトゥ花右;

		public Par X0Y0_植タトゥ_タトゥ花;

		public Par X0Y0_植タトゥ_タトゥ茎;

		public Par X0Y0_植タトゥ_タトゥ葉左;

		public Par X0Y0_植タトゥ_タトゥ葉右;

		public ColorD 植タトゥ_タトゥ花左CD;

		public ColorD 植タトゥ_タトゥ花右CD;

		public ColorD 植タトゥ_タトゥ花CD;

		public ColorD 植タトゥ_タトゥ茎CD;

		public ColorD 植タトゥ_タトゥ葉左CD;

		public ColorD 植タトゥ_タトゥ葉右CD;

		public ColorP X0Y0_植タトゥ_タトゥ花左CP;

		public ColorP X0Y0_植タトゥ_タトゥ花右CP;

		public ColorP X0Y0_植タトゥ_タトゥ花CP;

		public ColorP X0Y0_植タトゥ_タトゥ茎CP;

		public ColorP X0Y0_植タトゥ_タトゥ葉左CP;

		public ColorP X0Y0_植タトゥ_タトゥ葉右CP;
	}
}
