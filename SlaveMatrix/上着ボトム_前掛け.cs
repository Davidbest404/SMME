using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 上着ボトム_前掛け : 上着ボトム
	{
		public 上着ボトム_前掛け(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 上着ボトム_前掛けD e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif(Sta.胴体["上着ボトム前"][1]);
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_帯 = pars["帯"].ToPar();
			this.X0Y0_巻 = pars["巻"].ToPar();
			Pars pars2 = pars["縁後"].ToPars();
			this.X0Y0_縁後_縁左 = pars2["縁左"].ToPar();
			this.X0Y0_縁後_縁右 = pars2["縁右"].ToPar();
			pars2 = pars["前掛"].ToPars();
			this.X0Y0_前掛_前掛1 = pars2["前掛1"].ToPar();
			this.X0Y0_前掛_前掛2 = pars2["前掛2"].ToPar();
			this.X0Y0_前掛_前掛3 = pars2["前掛3"].ToPar();
			pars2 = pars["縁前"].ToPars();
			this.X0Y0_縁前_縁左 = pars2["縁左"].ToPar();
			this.X0Y0_縁前_縁右 = pars2["縁右"].ToPar();
			this.X0Y0_縁前_縁中 = pars2["縁中"].ToPar();
			pars = this.本体[0][1];
			this.X0Y1_帯 = pars["帯"].ToPar();
			this.X0Y1_巻 = pars["巻"].ToPar();
			pars2 = pars["縁後"].ToPars();
			this.X0Y1_縁後_縁左 = pars2["縁左"].ToPar();
			this.X0Y1_縁後_縁右 = pars2["縁右"].ToPar();
			pars2 = pars["前掛"].ToPars();
			this.X0Y1_前掛_前掛1 = pars2["前掛1"].ToPar();
			this.X0Y1_前掛_前掛2 = pars2["前掛2"].ToPar();
			pars2 = pars["縁前"].ToPars();
			this.X0Y1_縁前_縁左 = pars2["縁左"].ToPar();
			this.X0Y1_縁前_縁右 = pars2["縁右"].ToPar();
			this.X0Y1_縁前_縁中 = pars2["縁中"].ToPar();
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
			this.帯_表示 = e.帯_表示;
			this.巻_表示 = e.巻_表示;
			this.縁後_縁左_表示 = e.縁後_縁左_表示;
			this.縁後_縁右_表示 = e.縁後_縁右_表示;
			this.前掛_前掛1_表示 = e.前掛_前掛1_表示;
			this.前掛_前掛2_表示 = e.前掛_前掛2_表示;
			this.前掛_前掛3_表示 = e.前掛_前掛3_表示;
			this.縁前_縁左_表示 = e.縁前_縁左_表示;
			this.縁前_縁右_表示 = e.縁前_縁右_表示;
			this.縁前_縁中_表示 = e.縁前_縁中_表示;
			this.ベ\u30FCス表示 = e.ベ\u30FCス表示;
			this.縁表示 = e.縁表示;
			this.巻縁表示 = e.巻縁表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_帯CP = new ColorP(this.X0Y0_帯, this.帯CD, DisUnit, true);
			this.X0Y0_巻CP = new ColorP(this.X0Y0_巻, this.巻CD, DisUnit, true);
			this.X0Y0_縁後_縁左CP = new ColorP(this.X0Y0_縁後_縁左, this.縁後_縁左CD, DisUnit, true);
			this.X0Y0_縁後_縁右CP = new ColorP(this.X0Y0_縁後_縁右, this.縁後_縁右CD, DisUnit, true);
			this.X0Y0_前掛_前掛1CP = new ColorP(this.X0Y0_前掛_前掛1, this.前掛_前掛1CD, DisUnit, true);
			this.X0Y0_前掛_前掛2CP = new ColorP(this.X0Y0_前掛_前掛2, this.前掛_前掛2CD, DisUnit, true);
			this.X0Y0_前掛_前掛3CP = new ColorP(this.X0Y0_前掛_前掛3, this.前掛_前掛3CD, DisUnit, true);
			this.X0Y0_縁前_縁左CP = new ColorP(this.X0Y0_縁前_縁左, this.縁前_縁左CD, DisUnit, true);
			this.X0Y0_縁前_縁右CP = new ColorP(this.X0Y0_縁前_縁右, this.縁前_縁右CD, DisUnit, true);
			this.X0Y0_縁前_縁中CP = new ColorP(this.X0Y0_縁前_縁中, this.縁前_縁中CD, DisUnit, true);
			this.X0Y1_帯CP = new ColorP(this.X0Y1_帯, this.帯CD, DisUnit, true);
			this.X0Y1_巻CP = new ColorP(this.X0Y1_巻, this.巻CD, DisUnit, true);
			this.X0Y1_縁後_縁左CP = new ColorP(this.X0Y1_縁後_縁左, this.縁後_縁左CD, DisUnit, true);
			this.X0Y1_縁後_縁右CP = new ColorP(this.X0Y1_縁後_縁右, this.縁後_縁右CD, DisUnit, true);
			this.X0Y1_前掛_前掛1CP = new ColorP(this.X0Y1_前掛_前掛1, this.前掛_前掛1CD, DisUnit, true);
			this.X0Y1_前掛_前掛2CP = new ColorP(this.X0Y1_前掛_前掛2, this.前掛_前掛2CD, DisUnit, true);
			this.X0Y1_縁前_縁左CP = new ColorP(this.X0Y1_縁前_縁左, this.縁前_縁左CD, DisUnit, true);
			this.X0Y1_縁前_縁右CP = new ColorP(this.X0Y1_縁前_縁右, this.縁前_縁右CD, DisUnit, true);
			this.X0Y1_縁前_縁中CP = new ColorP(this.X0Y1_縁前_縁中, this.縁前_縁中CD, DisUnit, true);
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

		public bool 帯_表示
		{
			get
			{
				return this.X0Y0_帯.Dra;
			}
			set
			{
				this.X0Y0_帯.Dra = value;
				this.X0Y1_帯.Dra = value;
				this.X0Y0_帯.Hit = false;
				this.X0Y1_帯.Hit = false;
			}
		}

		public bool 巻_表示
		{
			get
			{
				return this.X0Y0_巻.Dra;
			}
			set
			{
				this.X0Y0_巻.Dra = value;
				this.X0Y1_巻.Dra = value;
				this.X0Y0_巻.Hit = false;
				this.X0Y1_巻.Hit = false;
			}
		}

		public bool 縁後_縁左_表示
		{
			get
			{
				return this.X0Y0_縁後_縁左.Dra;
			}
			set
			{
				this.X0Y0_縁後_縁左.Dra = value;
				this.X0Y1_縁後_縁左.Dra = value;
				this.X0Y0_縁後_縁左.Hit = false;
				this.X0Y1_縁後_縁左.Hit = false;
			}
		}

		public bool 縁後_縁右_表示
		{
			get
			{
				return this.X0Y0_縁後_縁右.Dra;
			}
			set
			{
				this.X0Y0_縁後_縁右.Dra = value;
				this.X0Y1_縁後_縁右.Dra = value;
				this.X0Y0_縁後_縁右.Hit = false;
				this.X0Y1_縁後_縁右.Hit = false;
			}
		}

		public bool 前掛_前掛1_表示
		{
			get
			{
				return this.X0Y0_前掛_前掛1.Dra;
			}
			set
			{
				this.X0Y0_前掛_前掛1.Dra = value;
				this.X0Y1_前掛_前掛1.Dra = value;
				this.X0Y0_前掛_前掛1.Hit = false;
				this.X0Y1_前掛_前掛1.Hit = false;
			}
		}

		public bool 前掛_前掛2_表示
		{
			get
			{
				return this.X0Y0_前掛_前掛2.Dra;
			}
			set
			{
				this.X0Y0_前掛_前掛2.Dra = value;
				this.X0Y1_前掛_前掛2.Dra = value;
				this.X0Y0_前掛_前掛2.Hit = false;
				this.X0Y1_前掛_前掛2.Hit = false;
			}
		}

		public bool 前掛_前掛3_表示
		{
			get
			{
				return this.X0Y0_前掛_前掛3.Dra;
			}
			set
			{
				this.X0Y0_前掛_前掛3.Dra = value;
				this.X0Y0_前掛_前掛3.Hit = false;
			}
		}

		public bool 縁前_縁左_表示
		{
			get
			{
				return this.X0Y0_縁前_縁左.Dra;
			}
			set
			{
				this.X0Y0_縁前_縁左.Dra = value;
				this.X0Y1_縁前_縁左.Dra = value;
				this.X0Y0_縁前_縁左.Hit = false;
				this.X0Y1_縁前_縁左.Hit = false;
			}
		}

		public bool 縁前_縁右_表示
		{
			get
			{
				return this.X0Y0_縁前_縁右.Dra;
			}
			set
			{
				this.X0Y0_縁前_縁右.Dra = value;
				this.X0Y1_縁前_縁右.Dra = value;
				this.X0Y0_縁前_縁右.Hit = false;
				this.X0Y1_縁前_縁右.Hit = false;
			}
		}

		public bool 縁前_縁中_表示
		{
			get
			{
				return this.X0Y0_縁前_縁中.Dra;
			}
			set
			{
				this.X0Y0_縁前_縁中.Dra = value;
				this.X0Y1_縁前_縁中.Dra = value;
				this.X0Y0_縁前_縁中.Hit = false;
				this.X0Y1_縁前_縁中.Hit = false;
			}
		}

		public bool ベ\u30FCス表示
		{
			get
			{
				return this.帯_表示;
			}
			set
			{
				this.帯_表示 = value;
				this.巻_表示 = value;
				this.前掛_前掛1_表示 = value;
				this.前掛_前掛2_表示 = value;
				this.前掛_前掛3_表示 = value;
			}
		}

		public bool 縁表示
		{
			get
			{
				return this.縁前_縁左_表示;
			}
			set
			{
				this.縁前_縁左_表示 = value;
				this.縁前_縁右_表示 = value;
				this.縁前_縁中_表示 = value;
			}
		}

		public bool 巻縁表示
		{
			get
			{
				return this.縁後_縁左_表示;
			}
			set
			{
				this.縁後_縁左_表示 = value;
				this.縁後_縁右_表示 = value;
			}
		}

		public override void 描画0(Are Are)
		{
			if (this.本体.IndexY == 0)
			{
				Are.Draw(this.X0Y0_帯);
				Are.Draw(this.X0Y0_巻);
				Are.Draw(this.X0Y0_縁後_縁左);
				Are.Draw(this.X0Y0_縁後_縁右);
				return;
			}
			Are.Draw(this.X0Y1_帯);
			Are.Draw(this.X0Y1_巻);
			Are.Draw(this.X0Y1_縁後_縁左);
			Are.Draw(this.X0Y1_縁後_縁右);
			Are.Draw(this.X0Y1_前掛_前掛1);
			Are.Draw(this.X0Y1_前掛_前掛2);
			Are.Draw(this.X0Y1_縁前_縁左);
			Are.Draw(this.X0Y1_縁前_縁右);
			Are.Draw(this.X0Y1_縁前_縁中);
		}

		public void 前(Are Are)
		{
			if (this.本体.IndexY == 0)
			{
				Are.Draw(this.X0Y0_前掛_前掛1);
				Are.Draw(this.X0Y0_前掛_前掛2);
				Are.Draw(this.X0Y0_前掛_前掛3);
				Are.Draw(this.X0Y0_縁前_縁左);
				Are.Draw(this.X0Y0_縁前_縁右);
				Are.Draw(this.X0Y0_縁前_縁中);
			}
		}

		public override bool 表示
		{
			get
			{
				return this.帯_表示;
			}
			set
			{
				this.帯_表示 = value;
				this.巻_表示 = value;
				this.縁後_縁左_表示 = value;
				this.縁後_縁右_表示 = value;
				this.前掛_前掛1_表示 = value;
				this.前掛_前掛2_表示 = value;
				this.前掛_前掛3_表示 = value;
				this.縁前_縁左_表示 = value;
				this.縁前_縁右_表示 = value;
				this.縁前_縁中_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.帯CD.不透明度;
			}
			set
			{
				this.帯CD.不透明度 = value;
				this.巻CD.不透明度 = value;
				this.縁後_縁左CD.不透明度 = value;
				this.縁後_縁右CD.不透明度 = value;
				this.前掛_前掛1CD.不透明度 = value;
				this.前掛_前掛2CD.不透明度 = value;
				this.前掛_前掛3CD.不透明度 = value;
				this.縁前_縁左CD.不透明度 = value;
				this.縁前_縁右CD.不透明度 = value;
				this.縁前_縁中CD.不透明度 = value;
			}
		}

		public override bool Is布(Par p)
		{
			return p == this.X0Y0_帯 || p == this.X0Y0_巻 || p == this.X0Y0_縁後_縁左 || p == this.X0Y0_縁後_縁右 || p == this.X0Y0_前掛_前掛1 || p == this.X0Y0_前掛_前掛2 || p == this.X0Y0_前掛_前掛3 || p == this.X0Y0_縁前_縁左 || p == this.X0Y0_縁前_縁右 || p == this.X0Y0_縁前_縁中 || p == this.X0Y1_帯 || p == this.X0Y1_巻 || p == this.X0Y1_縁後_縁左 || p == this.X0Y1_縁後_縁右 || p == this.X0Y1_前掛_前掛1 || p == this.X0Y1_前掛_前掛2 || p == this.X0Y1_縁前_縁左 || p == this.X0Y1_縁前_縁右 || p == this.X0Y1_縁前_縁中;
		}

		public override void 色更新()
		{
			if (this.本体.IndexY == 0)
			{
				this.X0Y0_帯CP.Update();
				this.X0Y0_巻CP.Update();
				this.X0Y0_縁後_縁左CP.Update();
				this.X0Y0_縁後_縁右CP.Update();
				this.X0Y0_前掛_前掛1CP.Update();
				this.X0Y0_前掛_前掛2CP.Update();
				this.X0Y0_前掛_前掛3CP.Update();
				this.X0Y0_縁前_縁左CP.Update();
				this.X0Y0_縁前_縁右CP.Update();
				this.X0Y0_縁前_縁中CP.Update();
				return;
			}
			this.X0Y1_帯CP.Update();
			this.X0Y1_巻CP.Update();
			this.X0Y1_縁後_縁左CP.Update();
			this.X0Y1_縁後_縁右CP.Update();
			this.X0Y1_前掛_前掛1CP.Update();
			this.X0Y1_前掛_前掛2CP.Update();
			this.X0Y1_縁前_縁左CP.Update();
			this.X0Y1_縁前_縁右CP.Update();
			this.X0Y1_縁前_縁中CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.帯CD = new ColorD();
			this.巻CD = new ColorD();
			this.縁後_縁左CD = new ColorD();
			this.縁後_縁右CD = new ColorD();
			this.前掛_前掛1CD = new ColorD();
			this.前掛_前掛2CD = new ColorD();
			this.前掛_前掛3CD = new ColorD();
			this.縁前_縁左CD = new ColorD();
			this.縁前_縁右CD = new ColorD();
			this.縁前_縁中CD = new ColorD();
		}

		public void 配色(前掛けB色 配色)
		{
			this.帯CD.色 = 配色.紐色;
			this.巻CD.色 = 配色.縁色;
			this.縁後_縁左CD.色 = this.巻CD.色;
			this.縁後_縁右CD.色 = this.巻CD.色;
			this.前掛_前掛1CD.色 = 配色.生地色;
			this.前掛_前掛2CD.色 = this.前掛_前掛1CD.色;
			this.前掛_前掛3CD.色 = this.前掛_前掛1CD.色;
			this.縁前_縁左CD.色 = this.巻CD.色;
			this.縁前_縁右CD.色 = this.巻CD.色;
			this.縁前_縁中CD.色 = this.巻CD.色;
		}

		public Par X0Y0_帯;

		public Par X0Y0_巻;

		public Par X0Y0_縁後_縁左;

		public Par X0Y0_縁後_縁右;

		public Par X0Y0_前掛_前掛1;

		public Par X0Y0_前掛_前掛2;

		public Par X0Y0_前掛_前掛3;

		public Par X0Y0_縁前_縁左;

		public Par X0Y0_縁前_縁右;

		public Par X0Y0_縁前_縁中;

		public Par X0Y1_帯;

		public Par X0Y1_巻;

		public Par X0Y1_縁後_縁左;

		public Par X0Y1_縁後_縁右;

		public Par X0Y1_前掛_前掛1;

		public Par X0Y1_前掛_前掛2;

		public Par X0Y1_縁前_縁左;

		public Par X0Y1_縁前_縁右;

		public Par X0Y1_縁前_縁中;

		public ColorD 帯CD;

		public ColorD 巻CD;

		public ColorD 縁後_縁左CD;

		public ColorD 縁後_縁右CD;

		public ColorD 前掛_前掛1CD;

		public ColorD 前掛_前掛2CD;

		public ColorD 前掛_前掛3CD;

		public ColorD 縁前_縁左CD;

		public ColorD 縁前_縁右CD;

		public ColorD 縁前_縁中CD;

		public ColorP X0Y0_帯CP;

		public ColorP X0Y0_巻CP;

		public ColorP X0Y0_縁後_縁左CP;

		public ColorP X0Y0_縁後_縁右CP;

		public ColorP X0Y0_前掛_前掛1CP;

		public ColorP X0Y0_前掛_前掛2CP;

		public ColorP X0Y0_前掛_前掛3CP;

		public ColorP X0Y0_縁前_縁左CP;

		public ColorP X0Y0_縁前_縁右CP;

		public ColorP X0Y0_縁前_縁中CP;

		public ColorP X0Y1_帯CP;

		public ColorP X0Y1_巻CP;

		public ColorP X0Y1_縁後_縁左CP;

		public ColorP X0Y1_縁後_縁右CP;

		public ColorP X0Y1_前掛_前掛1CP;

		public ColorP X0Y1_前掛_前掛2CP;

		public ColorP X0Y1_縁前_縁左CP;

		public ColorP X0Y1_縁前_縁右CP;

		public ColorP X0Y1_縁前_縁中CP;
	}
}
