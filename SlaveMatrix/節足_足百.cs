using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 節足_足百 : 節足
	{
		public 節足_足百(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 節足_足百D e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "節足百";
			dif.Add(new Pars(Sta.肢左["節足"][0][4]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_基節 = pars["基節"].ToPar();
			this.X0Y0_転節 = pars["転節"].ToPar();
			this.X0Y0_前腿節 = pars["前腿節"].ToPar();
			this.X0Y0_腿節 = pars["腿節"].ToPar();
			this.X0Y0_脛節 = pars["脛節"].ToPar();
			Pars pars2 = pars["輪"].ToPars();
			this.X0Y0_輪_革 = pars2["革"].ToPar();
			this.X0Y0_輪_金具1 = pars2["金具1"].ToPar();
			this.X0Y0_輪_金具2 = pars2["金具2"].ToPar();
			this.X0Y0_輪_金具3 = pars2["金具3"].ToPar();
			this.X0Y0_輪_金具左 = pars2["金具左"].ToPar();
			this.X0Y0_輪_金具右 = pars2["金具右"].ToPar();
			this.X0Y0_跗節1 = pars["跗節1"].ToPar();
			this.X0Y0_跗節2 = pars["跗節2"].ToPar();
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
			this.基節_表示 = e.基節_表示;
			this.転節_表示 = e.転節_表示;
			this.前腿節_表示 = e.前腿節_表示;
			this.腿節_表示 = e.腿節_表示;
			this.脛節_表示 = e.脛節_表示;
			this.輪_革_表示 = e.輪_革_表示;
			this.輪_金具1_表示 = e.輪_金具1_表示;
			this.輪_金具2_表示 = e.輪_金具2_表示;
			this.輪_金具3_表示 = e.輪_金具3_表示;
			this.輪_金具左_表示 = e.輪_金具左_表示;
			this.輪_金具右_表示 = e.輪_金具右_表示;
			this.跗節1_表示 = e.跗節1_表示;
			this.跗節2_表示 = e.跗節2_表示;
			this.輪表示 = e.輪表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_基節CP = new ColorP(this.X0Y0_基節, this.基節CD, DisUnit, true);
			this.X0Y0_転節CP = new ColorP(this.X0Y0_転節, this.転節CD, DisUnit, true);
			this.X0Y0_前腿節CP = new ColorP(this.X0Y0_前腿節, this.前腿節CD, DisUnit, true);
			this.X0Y0_腿節CP = new ColorP(this.X0Y0_腿節, this.腿節CD, DisUnit, true);
			this.X0Y0_脛節CP = new ColorP(this.X0Y0_脛節, this.脛節CD, DisUnit, true);
			this.X0Y0_輪_革CP = new ColorP(this.X0Y0_輪_革, this.輪_革CD, DisUnit, true);
			this.X0Y0_輪_金具1CP = new ColorP(this.X0Y0_輪_金具1, this.輪_金具1CD, DisUnit, true);
			this.X0Y0_輪_金具2CP = new ColorP(this.X0Y0_輪_金具2, this.輪_金具2CD, DisUnit, true);
			this.X0Y0_輪_金具3CP = new ColorP(this.X0Y0_輪_金具3, this.輪_金具3CD, DisUnit, true);
			this.X0Y0_輪_金具左CP = new ColorP(this.X0Y0_輪_金具左, this.輪_金具左CD, DisUnit, true);
			this.X0Y0_輪_金具右CP = new ColorP(this.X0Y0_輪_金具右, this.輪_金具右CD, DisUnit, true);
			this.X0Y0_跗節1CP = new ColorP(this.X0Y0_跗節1, this.跗節1CD, DisUnit, true);
			this.X0Y0_跗節2CP = new ColorP(this.X0Y0_跗節2, this.跗節2CD, DisUnit, true);
			this.濃度 = e.濃度;
			this.鎖2 = new 拘束鎖(DisUnit, true, 配色指定, 体配色, this.Xasix);
			this.鎖2.反転Y = true;
			this.鎖2.接続(this.鎖2_接続点);
			int num = this.右 ? -10 : 10;
			this.鎖2.角度B -= (double)num;
			this.鎖表示 = e.鎖表示;
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
				this.輪表示 = this.拘束_;
			}
		}

		public bool 基節_表示
		{
			get
			{
				return this.X0Y0_基節.Dra;
			}
			set
			{
				this.X0Y0_基節.Dra = value;
				this.X0Y0_基節.Hit = value;
			}
		}

		public bool 転節_表示
		{
			get
			{
				return this.X0Y0_転節.Dra;
			}
			set
			{
				this.X0Y0_転節.Dra = value;
				this.X0Y0_転節.Hit = value;
			}
		}

		public bool 前腿節_表示
		{
			get
			{
				return this.X0Y0_前腿節.Dra;
			}
			set
			{
				this.X0Y0_前腿節.Dra = value;
				this.X0Y0_前腿節.Hit = value;
			}
		}

		public bool 腿節_表示
		{
			get
			{
				return this.X0Y0_腿節.Dra;
			}
			set
			{
				this.X0Y0_腿節.Dra = value;
				this.X0Y0_腿節.Hit = value;
			}
		}

		public bool 脛節_表示
		{
			get
			{
				return this.X0Y0_脛節.Dra;
			}
			set
			{
				this.X0Y0_脛節.Dra = value;
				this.X0Y0_脛節.Hit = value;
			}
		}

		public bool 輪_革_表示
		{
			get
			{
				return this.X0Y0_輪_革.Dra;
			}
			set
			{
				this.X0Y0_輪_革.Dra = value;
				this.X0Y0_輪_革.Hit = value;
			}
		}

		public bool 輪_金具1_表示
		{
			get
			{
				return this.X0Y0_輪_金具1.Dra;
			}
			set
			{
				this.X0Y0_輪_金具1.Dra = value;
				this.X0Y0_輪_金具1.Hit = value;
			}
		}

		public bool 輪_金具2_表示
		{
			get
			{
				return this.X0Y0_輪_金具2.Dra;
			}
			set
			{
				this.X0Y0_輪_金具2.Dra = value;
				this.X0Y0_輪_金具2.Hit = value;
			}
		}

		public bool 輪_金具3_表示
		{
			get
			{
				return this.X0Y0_輪_金具3.Dra;
			}
			set
			{
				this.X0Y0_輪_金具3.Dra = value;
				this.X0Y0_輪_金具3.Hit = value;
			}
		}

		public bool 輪_金具左_表示
		{
			get
			{
				return this.X0Y0_輪_金具左.Dra;
			}
			set
			{
				this.X0Y0_輪_金具左.Dra = value;
				this.X0Y0_輪_金具左.Hit = value;
			}
		}

		public bool 輪_金具右_表示
		{
			get
			{
				return this.X0Y0_輪_金具右.Dra;
			}
			set
			{
				this.X0Y0_輪_金具右.Dra = value;
				this.X0Y0_輪_金具右.Hit = value;
			}
		}

		public bool 跗節1_表示
		{
			get
			{
				return this.X0Y0_跗節1.Dra;
			}
			set
			{
				this.X0Y0_跗節1.Dra = value;
				this.X0Y0_跗節1.Hit = value;
			}
		}

		public bool 跗節2_表示
		{
			get
			{
				return this.X0Y0_跗節2.Dra;
			}
			set
			{
				this.X0Y0_跗節2.Dra = value;
				this.X0Y0_跗節2.Hit = value;
			}
		}

		public bool 輪表示
		{
			get
			{
				return this.輪_革_表示;
			}
			set
			{
				this.輪_革_表示 = value;
				this.輪_金具1_表示 = value;
				this.輪_金具2_表示 = value;
				this.輪_金具3_表示 = value;
				this.輪_金具左_表示 = value;
				this.輪_金具右_表示 = value;
			}
		}

		public bool 鎖表示
		{
			get
			{
				return this.鎖2.表示;
			}
			set
			{
				this.鎖2.表示 = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.基節_表示;
			}
			set
			{
				this.基節_表示 = value;
				this.転節_表示 = value;
				this.前腿節_表示 = value;
				this.腿節_表示 = value;
				this.脛節_表示 = value;
				this.輪_革_表示 = value;
				this.輪_金具1_表示 = value;
				this.輪_金具2_表示 = value;
				this.輪_金具3_表示 = value;
				this.輪_金具左_表示 = value;
				this.輪_金具右_表示 = value;
				this.跗節1_表示 = value;
				this.跗節2_表示 = value;
				this.鎖2.表示 = value;
			}
		}

		public override void 描画0(Are Are)
		{
			Are.Draw(this.X0Y0_基節);
			Are.Draw(this.X0Y0_転節);
			Are.Draw(this.X0Y0_前腿節);
			Are.Draw(this.X0Y0_腿節);
			Are.Draw(this.X0Y0_脛節);
			Are.Draw(this.X0Y0_輪_革);
			Are.Draw(this.X0Y0_輪_金具1);
			Are.Draw(this.X0Y0_輪_金具2);
			Are.Draw(this.X0Y0_輪_金具3);
			Are.Draw(this.X0Y0_輪_金具左);
			Are.Draw(this.X0Y0_輪_金具右);
			this.鎖2.描画0(Are);
			Are.Draw(this.X0Y0_跗節1);
			Are.Draw(this.X0Y0_跗節2);
		}

		public override void Dispose()
		{
			base.Dispose();
			this.鎖2.Dispose();
		}

		public override double 濃度
		{
			get
			{
				return this.基節CD.不透明度;
			}
			set
			{
				this.基節CD.不透明度 = value;
				this.転節CD.不透明度 = value;
				this.前腿節CD.不透明度 = value;
				this.腿節CD.不透明度 = value;
				this.脛節CD.不透明度 = value;
				this.跗節1CD.不透明度 = value;
				this.跗節2CD.不透明度 = value;
				this.輪_革CD.不透明度 = value;
				this.輪_金具1CD.不透明度 = value;
				this.輪_金具2CD.不透明度 = value;
				this.輪_金具3CD.不透明度 = value;
				this.輪_金具左CD.不透明度 = value;
				this.輪_金具右CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			double num = this.右 ? -1.0 : 1.0;
			num *= (double)(this.反転Y ? -1 : 1);
			this.X0Y0_基節.AngleBase = num * (double)(1 - (this.反転Y ? 30 : 0));
			this.X0Y0_転節.AngleBase = num * 0.0;
			this.X0Y0_前腿節.AngleBase = num * 48.0;
			this.X0Y0_腿節.AngleBase = num * -49.0;
			this.X0Y0_脛節.AngleBase = num * -51.0;
			this.X0Y0_跗節1.AngleBase = num * -46.0;
			this.X0Y0_跗節2.AngleBase = num * 0.0;
			this.本体.JoinPAall();
		}

		public override bool Is革(Par p)
		{
			return p == this.X0Y0_輪_革 || p == this.X0Y0_輪_金具1 || p == this.X0Y0_輪_金具2 || p == this.X0Y0_輪_金具3 || p == this.X0Y0_輪_金具左 || p == this.X0Y0_輪_金具右;
		}

		public JointS 鎖1_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_輪_金具左, 0);
			}
		}

		public JointS 鎖2_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_輪_金具右, 0);
			}
		}

		public override void 色更新()
		{
			this.X0Y0_基節CP.Update();
			this.X0Y0_転節CP.Update();
			this.X0Y0_前腿節CP.Update();
			this.X0Y0_腿節CP.Update();
			this.X0Y0_脛節CP.Update();
			this.X0Y0_輪_革CP.Update();
			this.X0Y0_輪_金具1CP.Update();
			this.X0Y0_輪_金具2CP.Update();
			this.X0Y0_輪_金具3CP.Update();
			this.X0Y0_輪_金具左CP.Update();
			this.X0Y0_輪_金具右CP.Update();
			this.X0Y0_跗節1CP.Update();
			this.X0Y0_跗節2CP.Update();
			this.鎖2.接続PA();
			this.鎖2.色更新();
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
			this.基節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.転節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.前腿節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.腿節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.脛節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.跗節1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.跗節2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.輪_革CD = new ColorD();
			this.輪_金具1CD = new ColorD();
			this.輪_金具2CD = new ColorD();
			this.輪_金具3CD = new ColorD();
			this.輪_金具左CD = new ColorD();
			this.輪_金具右CD = new ColorD();
		}

		private void 配色T0(体配色 体配色)
		{
			this.基節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.転節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.前腿節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.腿節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.脛節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.跗節1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.跗節2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.輪_革CD = new ColorD();
			this.輪_金具1CD = new ColorD();
			this.輪_金具2CD = new ColorD();
			this.輪_金具3CD = new ColorD();
			this.輪_金具左CD = new ColorD();
			this.輪_金具右CD = new ColorD();
		}

		private void 配色T1(体配色 体配色)
		{
			this.基節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.転節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.前腿節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.腿節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脛節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.跗節1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.跗節2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.輪_革CD = new ColorD();
			this.輪_金具1CD = new ColorD();
			this.輪_金具2CD = new ColorD();
			this.輪_金具3CD = new ColorD();
			this.輪_金具左CD = new ColorD();
			this.輪_金具右CD = new ColorD();
		}

		public void 輪配色(拘束具色 配色)
		{
			this.輪_革CD.色 = 配色.革部色;
			this.輪_金具1CD.色 = 配色.金具色;
			this.輪_金具2CD.色 = this.輪_金具1CD.色;
			this.輪_金具3CD.色 = this.輪_金具1CD.色;
			this.輪_金具左CD.色 = this.輪_金具1CD.色;
			this.輪_金具右CD.色 = this.輪_金具1CD.色;
		}

		public void 鎖配色(鎖色 配色)
		{
			this.鎖2.配色鎖(配色);
		}

		public Par X0Y0_基節;

		public Par X0Y0_転節;

		public Par X0Y0_前腿節;

		public Par X0Y0_腿節;

		public Par X0Y0_脛節;

		public Par X0Y0_輪_革;

		public Par X0Y0_輪_金具1;

		public Par X0Y0_輪_金具2;

		public Par X0Y0_輪_金具3;

		public Par X0Y0_輪_金具左;

		public Par X0Y0_輪_金具右;

		public Par X0Y0_跗節1;

		public Par X0Y0_跗節2;

		public ColorD 基節CD;

		public ColorD 転節CD;

		public ColorD 前腿節CD;

		public ColorD 腿節CD;

		public ColorD 脛節CD;

		public ColorD 跗節1CD;

		public ColorD 跗節2CD;

		public ColorD 輪_革CD;

		public ColorD 輪_金具1CD;

		public ColorD 輪_金具2CD;

		public ColorD 輪_金具3CD;

		public ColorD 輪_金具左CD;

		public ColorD 輪_金具右CD;

		public ColorP X0Y0_基節CP;

		public ColorP X0Y0_転節CP;

		public ColorP X0Y0_前腿節CP;

		public ColorP X0Y0_腿節CP;

		public ColorP X0Y0_脛節CP;

		public ColorP X0Y0_輪_革CP;

		public ColorP X0Y0_輪_金具1CP;

		public ColorP X0Y0_輪_金具2CP;

		public ColorP X0Y0_輪_金具3CP;

		public ColorP X0Y0_輪_金具左CP;

		public ColorP X0Y0_輪_金具右CP;

		public ColorP X0Y0_跗節1CP;

		public ColorP X0Y0_跗節2CP;

		public 拘束鎖 鎖2;
	}
}
