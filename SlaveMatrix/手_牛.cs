using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 手_牛 : 獣手
	{
		public 手_牛(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 手_牛D e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "牛";
			dif.Add(new Pars(Sta.腕左["四足手"][1][1]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_指0 = pars["指0"].ToPar();
			this.X0Y0_筋 = pars["筋"].ToPar();
			Pars pars2 = pars["蹄"].ToPars();
			this.X0Y0_蹄_蹄2 = pars2["蹄2"].ToPar();
			this.X0Y0_蹄_蹄1 = pars2["蹄1"].ToPar();
			this.X0Y0_蹄_副蹄 = pars2["副蹄"].ToPar();
			this.X0Y0_指1 = pars["指1"].ToPar();
			pars2 = pars["腕輪"].ToPars();
			this.X0Y0_腕輪_革 = pars2["革"].ToPar();
			this.X0Y0_腕輪_金具1 = pars2["金具1"].ToPar();
			this.X0Y0_腕輪_金具2 = pars2["金具2"].ToPar();
			this.X0Y0_腕輪_金具3 = pars2["金具3"].ToPar();
			this.X0Y0_腕輪_金具左 = pars2["金具左"].ToPar();
			this.X0Y0_腕輪_金具右 = pars2["金具右"].ToPar();
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
			this.指0_表示 = e.指0_表示;
			this.筋_表示 = e.筋_表示;
			this.蹄_蹄2_表示 = e.蹄_蹄2_表示;
			this.蹄_蹄1_表示 = e.蹄_蹄1_表示;
			this.蹄_副蹄_表示 = e.蹄_副蹄_表示;
			this.指1_表示 = e.指1_表示;
			this.腕輪_革_表示 = e.腕輪_革_表示;
			this.腕輪_金具1_表示 = e.腕輪_金具1_表示;
			this.腕輪_金具2_表示 = e.腕輪_金具2_表示;
			this.腕輪_金具3_表示 = e.腕輪_金具3_表示;
			this.腕輪_金具左_表示 = e.腕輪_金具左_表示;
			this.腕輪_金具右_表示 = e.腕輪_金具右_表示;
			this.腕輪表示 = e.腕輪表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_指0CP = new ColorP(this.X0Y0_指0, this.指0CD, DisUnit, true);
			this.X0Y0_筋CP = new ColorP(this.X0Y0_筋, this.筋CD, DisUnit, false);
			this.X0Y0_蹄_蹄2CP = new ColorP(this.X0Y0_蹄_蹄2, this.蹄_蹄2CD, DisUnit, true);
			this.X0Y0_蹄_蹄1CP = new ColorP(this.X0Y0_蹄_蹄1, this.蹄_蹄1CD, DisUnit, true);
			this.X0Y0_蹄_副蹄CP = new ColorP(this.X0Y0_蹄_副蹄, this.蹄_副蹄CD, DisUnit, true);
			this.X0Y0_指1CP = new ColorP(this.X0Y0_指1, this.指1CD, DisUnit, true);
			this.X0Y0_腕輪_革CP = new ColorP(this.X0Y0_腕輪_革, this.腕輪_革CD, DisUnit, true);
			this.X0Y0_腕輪_金具1CP = new ColorP(this.X0Y0_腕輪_金具1, this.腕輪_金具1CD, DisUnit, true);
			this.X0Y0_腕輪_金具2CP = new ColorP(this.X0Y0_腕輪_金具2, this.腕輪_金具2CD, DisUnit, true);
			this.X0Y0_腕輪_金具3CP = new ColorP(this.X0Y0_腕輪_金具3, this.腕輪_金具3CD, DisUnit, true);
			this.X0Y0_腕輪_金具左CP = new ColorP(this.X0Y0_腕輪_金具左, this.腕輪_金具左CD, DisUnit, true);
			this.X0Y0_腕輪_金具右CP = new ColorP(this.X0Y0_腕輪_金具右, this.腕輪_金具右CD, DisUnit, true);
			this.濃度 = e.濃度;
			this.鎖1 = new 拘束鎖(DisUnit, false, 配色指定, 体配色, this.Xasix);
			this.鎖1.反転Y = true;
			this.鎖1.接続(this.鎖1_接続点);
			int num = this.右 ? -10 : 10;
			this.鎖1.角度B -= (double)num;
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
				this.筋_表示 = this.筋肉_;
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
				this.腕輪表示 = this.拘束_;
			}
		}

		public bool 指0_表示
		{
			get
			{
				return this.X0Y0_指0.Dra;
			}
			set
			{
				this.X0Y0_指0.Dra = value;
				this.X0Y0_指0.Hit = value;
			}
		}

		public bool 筋_表示
		{
			get
			{
				return this.X0Y0_筋.Dra;
			}
			set
			{
				this.X0Y0_筋.Dra = value;
				this.X0Y0_筋.Hit = value;
			}
		}

		public bool 蹄_蹄2_表示
		{
			get
			{
				return this.X0Y0_蹄_蹄2.Dra;
			}
			set
			{
				this.X0Y0_蹄_蹄2.Dra = value;
				this.X0Y0_蹄_蹄2.Hit = value;
			}
		}

		public bool 蹄_蹄1_表示
		{
			get
			{
				return this.X0Y0_蹄_蹄1.Dra;
			}
			set
			{
				this.X0Y0_蹄_蹄1.Dra = value;
				this.X0Y0_蹄_蹄1.Hit = value;
			}
		}

		public bool 蹄_副蹄_表示
		{
			get
			{
				return this.X0Y0_蹄_副蹄.Dra;
			}
			set
			{
				this.X0Y0_蹄_副蹄.Dra = value;
				this.X0Y0_蹄_副蹄.Hit = value;
			}
		}

		public bool 指1_表示
		{
			get
			{
				return this.X0Y0_指1.Dra;
			}
			set
			{
				this.X0Y0_指1.Dra = value;
				this.X0Y0_指1.Hit = value;
			}
		}

		public bool 腕輪_革_表示
		{
			get
			{
				return this.X0Y0_腕輪_革.Dra;
			}
			set
			{
				this.X0Y0_腕輪_革.Dra = value;
				this.X0Y0_腕輪_革.Hit = value;
			}
		}

		public bool 腕輪_金具1_表示
		{
			get
			{
				return this.X0Y0_腕輪_金具1.Dra;
			}
			set
			{
				this.X0Y0_腕輪_金具1.Dra = value;
				this.X0Y0_腕輪_金具1.Hit = value;
			}
		}

		public bool 腕輪_金具2_表示
		{
			get
			{
				return this.X0Y0_腕輪_金具2.Dra;
			}
			set
			{
				this.X0Y0_腕輪_金具2.Dra = value;
				this.X0Y0_腕輪_金具2.Hit = value;
			}
		}

		public bool 腕輪_金具3_表示
		{
			get
			{
				return this.X0Y0_腕輪_金具3.Dra;
			}
			set
			{
				this.X0Y0_腕輪_金具3.Dra = value;
				this.X0Y0_腕輪_金具3.Hit = value;
			}
		}

		public bool 腕輪_金具左_表示
		{
			get
			{
				return this.X0Y0_腕輪_金具左.Dra;
			}
			set
			{
				this.X0Y0_腕輪_金具左.Dra = value;
				this.X0Y0_腕輪_金具左.Hit = value;
			}
		}

		public bool 腕輪_金具右_表示
		{
			get
			{
				return this.X0Y0_腕輪_金具右.Dra;
			}
			set
			{
				this.X0Y0_腕輪_金具右.Dra = value;
				this.X0Y0_腕輪_金具右.Hit = value;
			}
		}

		public bool 腕輪表示
		{
			get
			{
				return this.腕輪_革_表示;
			}
			set
			{
				this.腕輪_革_表示 = value;
				this.腕輪_金具1_表示 = value;
				this.腕輪_金具2_表示 = value;
				this.腕輪_金具3_表示 = value;
				this.腕輪_金具左_表示 = value;
				this.腕輪_金具右_表示 = value;
			}
		}

		public bool 鎖表示
		{
			get
			{
				return this.鎖1.表示;
			}
			set
			{
				this.鎖1.表示 = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.指0_表示;
			}
			set
			{
				this.指0_表示 = value;
				this.筋_表示 = value;
				this.蹄_蹄2_表示 = value;
				this.蹄_蹄1_表示 = value;
				this.蹄_副蹄_表示 = value;
				this.指1_表示 = value;
				this.腕輪_革_表示 = value;
				this.腕輪_金具1_表示 = value;
				this.腕輪_金具2_表示 = value;
				this.腕輪_金具3_表示 = value;
				this.腕輪_金具左_表示 = value;
				this.腕輪_金具右_表示 = value;
				this.鎖1.表示 = value;
			}
		}

		public override void 描画0(Are Are)
		{
			this.本体.Draw(Are);
			this.鎖1.描画0(Are);
		}

		public override void Dispose()
		{
			base.Dispose();
			this.鎖1.Dispose();
		}

		public override double 濃度
		{
			get
			{
				return this.指0CD.不透明度;
			}
			set
			{
				this.指0CD.不透明度 = value;
				this.筋CD.不透明度 = value;
				this.蹄_蹄2CD.不透明度 = value;
				this.蹄_蹄1CD.不透明度 = value;
				this.蹄_副蹄CD.不透明度 = value;
				this.指1CD.不透明度 = value;
				this.腕輪_革CD.不透明度 = value;
				this.腕輪_金具1CD.不透明度 = value;
				this.腕輪_金具2CD.不透明度 = value;
				this.腕輪_金具3CD.不透明度 = value;
				this.腕輪_金具左CD.不透明度 = value;
				this.腕輪_金具右CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			double num = this.右 ? -1.0 : 1.0;
			this.X0Y0_指0.AngleBase = num * 217.0;
			this.X0Y0_指1.AngleBase = num * -11.0;
			this.本体.JoinPAall();
		}

		public override bool Is革(Par p)
		{
			return p == this.X0Y0_腕輪_革 || p == this.X0Y0_腕輪_金具1 || p == this.X0Y0_腕輪_金具2 || p == this.X0Y0_腕輪_金具3 || p == this.X0Y0_腕輪_金具左 || p == this.X0Y0_腕輪_金具右;
		}

		public JointS 鎖1_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_腕輪_金具左, 0);
			}
		}

		public JointS 鎖2_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_腕輪_金具右, 0);
			}
		}

		public override void 色更新()
		{
			this.X0Y0_指0CP.Update();
			this.X0Y0_筋CP.Update();
			this.X0Y0_蹄_蹄2CP.Update();
			this.X0Y0_蹄_蹄1CP.Update();
			this.X0Y0_蹄_副蹄CP.Update();
			this.X0Y0_指1CP.Update();
			this.X0Y0_腕輪_革CP.Update();
			this.X0Y0_腕輪_金具1CP.Update();
			this.X0Y0_腕輪_金具2CP.Update();
			this.X0Y0_腕輪_金具3CP.Update();
			this.X0Y0_腕輪_金具左CP.Update();
			this.X0Y0_腕輪_金具右CP.Update();
			this.鎖1.接続PA();
			this.鎖1.色更新();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.指0CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.筋CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.蹄_蹄2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.蹄_蹄1CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.蹄_副蹄CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.指1CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.腕輪_革CD = new ColorD();
			this.腕輪_金具1CD = new ColorD();
			this.腕輪_金具2CD = new ColorD();
			this.腕輪_金具3CD = new ColorD();
			this.腕輪_金具左CD = new ColorD();
			this.腕輪_金具右CD = new ColorD();
		}

		public void 腕輪配色(拘束具色 配色)
		{
			this.腕輪_革CD.色 = 配色.革部色;
			this.腕輪_金具1CD.色 = 配色.金具色;
			this.腕輪_金具2CD.色 = this.腕輪_金具1CD.色;
			this.腕輪_金具3CD.色 = this.腕輪_金具1CD.色;
			this.腕輪_金具左CD.色 = this.腕輪_金具1CD.色;
			this.腕輪_金具右CD.色 = this.腕輪_金具1CD.色;
		}

		public void 鎖配色(鎖色 配色)
		{
			this.鎖1.配色鎖(配色);
		}

		public Par X0Y0_指0;

		public Par X0Y0_筋;

		public Par X0Y0_蹄_蹄2;

		public Par X0Y0_蹄_蹄1;

		public Par X0Y0_蹄_副蹄;

		public Par X0Y0_指1;

		public Par X0Y0_腕輪_革;

		public Par X0Y0_腕輪_金具1;

		public Par X0Y0_腕輪_金具2;

		public Par X0Y0_腕輪_金具3;

		public Par X0Y0_腕輪_金具左;

		public Par X0Y0_腕輪_金具右;

		public ColorD 指0CD;

		public ColorD 筋CD;

		public ColorD 蹄_蹄2CD;

		public ColorD 蹄_蹄1CD;

		public ColorD 蹄_副蹄CD;

		public ColorD 指1CD;

		public ColorD 腕輪_革CD;

		public ColorD 腕輪_金具1CD;

		public ColorD 腕輪_金具2CD;

		public ColorD 腕輪_金具3CD;

		public ColorD 腕輪_金具左CD;

		public ColorD 腕輪_金具右CD;

		public ColorP X0Y0_指0CP;

		public ColorP X0Y0_筋CP;

		public ColorP X0Y0_蹄_蹄2CP;

		public ColorP X0Y0_蹄_蹄1CP;

		public ColorP X0Y0_蹄_副蹄CP;

		public ColorP X0Y0_指1CP;

		public ColorP X0Y0_腕輪_革CP;

		public ColorP X0Y0_腕輪_金具1CP;

		public ColorP X0Y0_腕輪_金具2CP;

		public ColorP X0Y0_腕輪_金具3CP;

		public ColorP X0Y0_腕輪_金具左CP;

		public ColorP X0Y0_腕輪_金具右CP;

		public 拘束鎖 鎖1;
	}
}
