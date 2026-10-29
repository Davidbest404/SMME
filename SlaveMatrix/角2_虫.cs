using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 角2_虫 : 角2
	{
		public 角2_虫(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 角2_虫D e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif(Sta.肢左["角"][9]);
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_根 = pars["根"].ToPar();
			Pars pars2 = pars["刺"].ToPars();
			this.X0Y0_棘_棘1 = pars2["刺1"].ToPar();
			this.X0Y0_棘_棘2 = pars2["刺2"].ToPar();
			this.X0Y0_棘_棘3 = pars2["刺3"].ToPar();
			pars2 = pars["輪"].ToPars();
			this.X0Y0_輪_革 = pars2["革"].ToPar();
			this.X0Y0_輪_金具1 = pars2["金具1"].ToPar();
			this.X0Y0_輪_金具2 = pars2["金具2"].ToPar();
			this.X0Y0_輪_金具3 = pars2["金具3"].ToPar();
			this.X0Y0_輪_金具左 = pars2["金具左"].ToPar();
			this.X0Y0_輪_金具右 = pars2["金具右"].ToPar();
			pars = this.本体[0][1];
			this.X0Y1_根 = pars["根"].ToPar();
			pars2 = pars["刺"].ToPars();
			this.X0Y1_棘_棘2 = pars2["刺2"].ToPar();
			this.X0Y1_棘_棘3 = pars2["刺3"].ToPar();
			this.X0Y1_折線 = pars["折線"].ToPar();
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
			this.根_表示 = e.根_表示;
			this.刺_棘1_表示 = e.刺_棘1_表示;
			this.刺_棘2_表示 = e.刺_棘2_表示;
			this.刺_棘3_表示 = e.刺_棘3_表示;
			this.輪_革_表示 = e.輪_革_表示;
			this.輪_金具1_表示 = e.輪_金具1_表示;
			this.輪_金具2_表示 = e.輪_金具2_表示;
			this.輪_金具3_表示 = e.輪_金具3_表示;
			this.輪_金具左_表示 = e.輪_金具左_表示;
			this.輪_金具右_表示 = e.輪_金具右_表示;
			this.折線_表示 = e.折線_表示;
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
			this.X0Y0_根CP = new ColorP(this.X0Y0_根, this.根CD, DisUnit, true);
			this.X0Y0_棘_棘1CP = new ColorP(this.X0Y0_棘_棘1, this.刺_棘1CD, DisUnit, true);
			this.X0Y0_棘_棘2CP = new ColorP(this.X0Y0_棘_棘2, this.刺_棘2CD, DisUnit, true);
			this.X0Y0_棘_棘3CP = new ColorP(this.X0Y0_棘_棘3, this.刺_棘3CD, DisUnit, true);
			this.X0Y0_輪_革CP = new ColorP(this.X0Y0_輪_革, this.輪_革CD, DisUnit, true);
			this.X0Y0_輪_金具1CP = new ColorP(this.X0Y0_輪_金具1, this.輪_金具1CD, DisUnit, true);
			this.X0Y0_輪_金具2CP = new ColorP(this.X0Y0_輪_金具2, this.輪_金具2CD, DisUnit, true);
			this.X0Y0_輪_金具3CP = new ColorP(this.X0Y0_輪_金具3, this.輪_金具3CD, DisUnit, true);
			this.X0Y0_輪_金具左CP = new ColorP(this.X0Y0_輪_金具左, this.輪_金具左CD, DisUnit, true);
			this.X0Y0_輪_金具右CP = new ColorP(this.X0Y0_輪_金具右, this.輪_金具右CD, DisUnit, true);
			this.X0Y1_根CP = new ColorP(this.X0Y1_根, this.根CD, DisUnit, true);
			this.X0Y1_棘_棘2CP = new ColorP(this.X0Y1_棘_棘2, this.刺_棘2CD, DisUnit, true);
			this.X0Y1_棘_棘3CP = new ColorP(this.X0Y1_棘_棘3, this.刺_棘3CD, DisUnit, true);
			this.X0Y1_折線CP = new ColorP(this.X0Y1_折線, this.折線CD, DisUnit, true);
			this.濃度 = e.濃度;
			this.鎖1 = new 拘束鎖(DisUnit, this.右, 配色指定, 体配色, this.Xasix);
			this.鎖1.接続(this.鎖1_接続点);
			int num = this.右 ? -10 : 10;
			this.鎖1.角度B += (double)num;
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
				this.本体.IndexY = (this.欠損_ ? 1 : 0);
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

		public bool 根_表示
		{
			get
			{
				return this.X0Y0_根.Dra;
			}
			set
			{
				this.X0Y0_根.Dra = value;
				this.X0Y1_根.Dra = value;
				this.X0Y0_根.Hit = value;
				this.X0Y1_根.Hit = value;
			}
		}

		public bool 刺_棘1_表示
		{
			get
			{
				return this.X0Y0_棘_棘1.Dra;
			}
			set
			{
				this.X0Y0_棘_棘1.Dra = value;
				this.X0Y0_棘_棘1.Hit = value;
			}
		}

		public bool 刺_棘2_表示
		{
			get
			{
				return this.X0Y0_棘_棘2.Dra;
			}
			set
			{
				this.X0Y0_棘_棘2.Dra = value;
				this.X0Y1_棘_棘2.Dra = value;
				this.X0Y0_棘_棘2.Hit = value;
				this.X0Y1_棘_棘2.Hit = value;
			}
		}

		public bool 刺_棘3_表示
		{
			get
			{
				return this.X0Y0_棘_棘3.Dra;
			}
			set
			{
				this.X0Y0_棘_棘3.Dra = value;
				this.X0Y1_棘_棘3.Dra = value;
				this.X0Y0_棘_棘3.Hit = value;
				this.X0Y1_棘_棘3.Hit = value;
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

		public bool 折線_表示
		{
			get
			{
				return this.X0Y1_折線.Dra;
			}
			set
			{
				this.X0Y1_折線.Dra = value;
				this.X0Y1_折線.Hit = value;
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
				return this.根_表示;
			}
			set
			{
				this.根_表示 = value;
				this.刺_棘1_表示 = value;
				this.刺_棘2_表示 = value;
				this.刺_棘3_表示 = value;
				this.輪_革_表示 = value;
				this.輪_金具1_表示 = value;
				this.輪_金具2_表示 = value;
				this.輪_金具3_表示 = value;
				this.輪_金具左_表示 = value;
				this.輪_金具右_表示 = value;
				this.折線_表示 = value;
			}
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
				return this.根CD.不透明度;
			}
			set
			{
				this.根CD.不透明度 = value;
				this.刺_棘1CD.不透明度 = value;
				this.刺_棘2CD.不透明度 = value;
				this.刺_棘3CD.不透明度 = value;
				this.輪_革CD.不透明度 = value;
				this.輪_金具1CD.不透明度 = value;
				this.輪_金具2CD.不透明度 = value;
				this.輪_金具3CD.不透明度 = value;
				this.輪_金具左CD.不透明度 = value;
				this.輪_金具右CD.不透明度 = value;
				this.折線CD.不透明度 = value;
			}
		}

		public override void 根描画(Are Are)
		{
			this.本体.Draw(Are);
			if (!this.欠損_)
			{
				this.鎖1.描画0(Are);
			}
		}

		public override void 描画0(Are Are)
		{
			this.本体.Draw(Are);
			if (!this.欠損_)
			{
				this.鎖1.描画0(Are);
			}
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
			if (this.本体.IndexY == 0)
			{
				this.X0Y0_根CP.Update();
				this.X0Y0_棘_棘1CP.Update();
				this.X0Y0_棘_棘2CP.Update();
				this.X0Y0_棘_棘3CP.Update();
				this.X0Y0_輪_革CP.Update();
				this.X0Y0_輪_金具1CP.Update();
				this.X0Y0_輪_金具2CP.Update();
				this.X0Y0_輪_金具3CP.Update();
				this.X0Y0_輪_金具左CP.Update();
				this.X0Y0_輪_金具右CP.Update();
				this.鎖1.接続PA();
				this.鎖1.色更新();
				return;
			}
			this.X0Y1_根CP.Update();
			this.X0Y1_棘_棘2CP.Update();
			this.X0Y1_棘_棘3CP.Update();
			this.X0Y1_折線CP.Update();
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
			this.根CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.刺_棘1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.刺_棘2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.刺_棘3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.輪_革CD = new ColorD();
			this.輪_金具1CD = new ColorD();
			this.輪_金具2CD = new ColorD();
			this.輪_金具3CD = new ColorD();
			this.輪_金具左CD = new ColorD();
			this.輪_金具右CD = new ColorD();
			this.折線CD = new ColorD(ref Col.Black, ref Color2.Empty);
		}

		private void 配色T0(体配色 体配色)
		{
			this.根CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.刺_棘1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.刺_棘2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.刺_棘3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.輪_革CD = new ColorD();
			this.輪_金具1CD = new ColorD();
			this.輪_金具2CD = new ColorD();
			this.輪_金具3CD = new ColorD();
			this.輪_金具左CD = new ColorD();
			this.輪_金具右CD = new ColorD();
			this.折線CD = new ColorD(ref Col.Black, ref Color2.Empty);
		}

		private void 配色T1(体配色 体配色)
		{
			this.根CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.刺_棘1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.刺_棘2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.刺_棘3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.輪_革CD = new ColorD();
			this.輪_金具1CD = new ColorD();
			this.輪_金具2CD = new ColorD();
			this.輪_金具3CD = new ColorD();
			this.輪_金具左CD = new ColorD();
			this.輪_金具右CD = new ColorD();
			this.折線CD = new ColorD(ref Col.Black, ref Color2.Empty);
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
			this.鎖1.配色鎖(配色);
		}

		public Par X0Y0_根;

		public Par X0Y0_棘_棘1;

		public Par X0Y0_棘_棘2;

		public Par X0Y0_棘_棘3;

		public Par X0Y0_輪_革;

		public Par X0Y0_輪_金具1;

		public Par X0Y0_輪_金具2;

		public Par X0Y0_輪_金具3;

		public Par X0Y0_輪_金具左;

		public Par X0Y0_輪_金具右;

		public Par X0Y1_根;

		public Par X0Y1_棘_棘2;

		public Par X0Y1_棘_棘3;

		public Par X0Y1_折線;

		public ColorD 根CD;

		public ColorD 刺_棘1CD;

		public ColorD 刺_棘2CD;

		public ColorD 刺_棘3CD;

		public ColorD 輪_革CD;

		public ColorD 輪_金具1CD;

		public ColorD 輪_金具2CD;

		public ColorD 輪_金具3CD;

		public ColorD 輪_金具左CD;

		public ColorD 輪_金具右CD;

		public ColorD 折線CD;

		public ColorP X0Y0_根CP;

		public ColorP X0Y0_棘_棘1CP;

		public ColorP X0Y0_棘_棘2CP;

		public ColorP X0Y0_棘_棘3CP;

		public ColorP X0Y0_輪_革CP;

		public ColorP X0Y0_輪_金具1CP;

		public ColorP X0Y0_輪_金具2CP;

		public ColorP X0Y0_輪_金具3CP;

		public ColorP X0Y0_輪_金具左CP;

		public ColorP X0Y0_輪_金具右CP;

		public ColorP X0Y1_根CP;

		public ColorP X0Y1_棘_棘2CP;

		public ColorP X0Y1_棘_棘3CP;

		public ColorP X0Y1_折線CP;

		public 拘束鎖 鎖1;
	}
}
