using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 足_獣 : 獣足
	{
		public 足_獣(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 足_獣D e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "獣";
			dif.Add(new Pars(Sta.脚左["四足足"][0][0]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_足 = pars["足"].ToPar();
			this.X0Y0_筋 = pars["筋"].ToPar();
			Pars pars2 = pars["小指"].ToPars();
			this.X0Y0_小指_指 = pars2["指"].ToPar();
			this.X0Y0_小指_爪 = pars2["爪"].ToPar();
			this.X0Y0_小指_肉球 = pars2["肉球"].ToPar();
			pars2 = pars["薬指"].ToPars();
			this.X0Y0_薬指_指 = pars2["指"].ToPar();
			this.X0Y0_薬指_爪 = pars2["爪"].ToPar();
			this.X0Y0_薬指_肉球 = pars2["肉球"].ToPar();
			pars2 = pars["中指"].ToPars();
			this.X0Y0_中指_指 = pars2["指"].ToPar();
			this.X0Y0_中指_爪 = pars2["爪"].ToPar();
			this.X0Y0_中指_肉球 = pars2["肉球"].ToPar();
			pars2 = pars["人指"].ToPars();
			this.X0Y0_人指_指 = pars2["指"].ToPar();
			this.X0Y0_人指_爪 = pars2["爪"].ToPar();
			this.X0Y0_人指_肉球 = pars2["肉球"].ToPar();
			pars2 = pars["肉球"].ToPars();
			this.X0Y0_肉球_肉球左 = pars2["肉球左"].ToPar();
			this.X0Y0_肉球_肉球中 = pars2["肉球中"].ToPar();
			this.X0Y0_肉球_肉球右 = pars2["肉球右"].ToPar();
			pars2 = pars["脚輪"].ToPars();
			this.X0Y0_脚輪_革 = pars2["革"].ToPar();
			this.X0Y0_脚輪_金具1 = pars2["金具1"].ToPar();
			this.X0Y0_脚輪_金具2 = pars2["金具2"].ToPar();
			this.X0Y0_脚輪_金具3 = pars2["金具3"].ToPar();
			this.X0Y0_脚輪_金具左 = pars2["金具左"].ToPar();
			this.X0Y0_脚輪_金具右 = pars2["金具右"].ToPar();
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
			this.足_表示 = e.足_表示;
			this.筋_表示 = e.筋_表示;
			this.小指_指_表示 = e.小指_指_表示;
			this.小指_爪_表示 = e.小指_爪_表示;
			this.小指_肉球_表示 = e.小指_肉球_表示;
			this.薬指_指_表示 = e.薬指_指_表示;
			this.薬指_爪_表示 = e.薬指_爪_表示;
			this.薬指_肉球_表示 = e.薬指_肉球_表示;
			this.中指_指_表示 = e.中指_指_表示;
			this.中指_爪_表示 = e.中指_爪_表示;
			this.中指_肉球_表示 = e.中指_肉球_表示;
			this.人指_指_表示 = e.人指_指_表示;
			this.人指_爪_表示 = e.人指_爪_表示;
			this.人指_肉球_表示 = e.人指_肉球_表示;
			this.肉球_肉球左_表示 = e.肉球_肉球左_表示;
			this.肉球_肉球中_表示 = e.肉球_肉球中_表示;
			this.肉球_肉球右_表示 = e.肉球_肉球右_表示;
			this.脚輪_革_表示 = e.脚輪_革_表示;
			this.脚輪_金具1_表示 = e.脚輪_金具1_表示;
			this.脚輪_金具2_表示 = e.脚輪_金具2_表示;
			this.脚輪_金具3_表示 = e.脚輪_金具3_表示;
			this.脚輪_金具左_表示 = e.脚輪_金具左_表示;
			this.脚輪_金具右_表示 = e.脚輪_金具右_表示;
			this.脚輪表示 = e.脚輪表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_足CP = new ColorP(this.X0Y0_足, this.足CD, DisUnit, true);
			this.X0Y0_筋CP = new ColorP(this.X0Y0_筋, this.筋CD, DisUnit, false);
			this.X0Y0_小指_指CP = new ColorP(this.X0Y0_小指_指, this.小指_指CD, DisUnit, true);
			this.X0Y0_小指_爪CP = new ColorP(this.X0Y0_小指_爪, this.小指_爪CD, DisUnit, true);
			this.X0Y0_小指_肉球CP = new ColorP(this.X0Y0_小指_肉球, this.小指_肉球CD, DisUnit, true);
			this.X0Y0_薬指_指CP = new ColorP(this.X0Y0_薬指_指, this.薬指_指CD, DisUnit, true);
			this.X0Y0_薬指_爪CP = new ColorP(this.X0Y0_薬指_爪, this.薬指_爪CD, DisUnit, true);
			this.X0Y0_薬指_肉球CP = new ColorP(this.X0Y0_薬指_肉球, this.薬指_肉球CD, DisUnit, true);
			this.X0Y0_中指_指CP = new ColorP(this.X0Y0_中指_指, this.中指_指CD, DisUnit, true);
			this.X0Y0_中指_爪CP = new ColorP(this.X0Y0_中指_爪, this.中指_爪CD, DisUnit, true);
			this.X0Y0_中指_肉球CP = new ColorP(this.X0Y0_中指_肉球, this.中指_肉球CD, DisUnit, true);
			this.X0Y0_人指_指CP = new ColorP(this.X0Y0_人指_指, this.人指_指CD, DisUnit, true);
			this.X0Y0_人指_爪CP = new ColorP(this.X0Y0_人指_爪, this.人指_爪CD, DisUnit, true);
			this.X0Y0_人指_肉球CP = new ColorP(this.X0Y0_人指_肉球, this.人指_肉球CD, DisUnit, true);
			this.X0Y0_肉球_肉球左CP = new ColorP(this.X0Y0_肉球_肉球左, this.肉球_肉球左CD, DisUnit, true);
			this.X0Y0_肉球_肉球中CP = new ColorP(this.X0Y0_肉球_肉球中, this.肉球_肉球中CD, DisUnit, true);
			this.X0Y0_肉球_肉球右CP = new ColorP(this.X0Y0_肉球_肉球右, this.肉球_肉球右CD, DisUnit, true);
			this.X0Y0_脚輪_革CP = new ColorP(this.X0Y0_脚輪_革, this.脚輪_革CD, DisUnit, true);
			this.X0Y0_脚輪_金具1CP = new ColorP(this.X0Y0_脚輪_金具1, this.脚輪_金具1CD, DisUnit, true);
			this.X0Y0_脚輪_金具2CP = new ColorP(this.X0Y0_脚輪_金具2, this.脚輪_金具2CD, DisUnit, true);
			this.X0Y0_脚輪_金具3CP = new ColorP(this.X0Y0_脚輪_金具3, this.脚輪_金具3CD, DisUnit, true);
			this.X0Y0_脚輪_金具左CP = new ColorP(this.X0Y0_脚輪_金具左, this.脚輪_金具左CD, DisUnit, true);
			this.X0Y0_脚輪_金具右CP = new ColorP(this.X0Y0_脚輪_金具右, this.脚輪_金具右CD, DisUnit, true);
			this.濃度 = e.濃度;
			this.鎖1 = new 拘束鎖(DisUnit, this.右, 配色指定, 体配色, this.Xasix);
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
				this.脚輪表示 = this.拘束_;
			}
		}

		public bool 足_表示
		{
			get
			{
				return this.X0Y0_足.Dra;
			}
			set
			{
				this.X0Y0_足.Dra = value;
				this.X0Y0_足.Hit = value;
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

		public bool 小指_指_表示
		{
			get
			{
				return this.X0Y0_小指_指.Dra;
			}
			set
			{
				this.X0Y0_小指_指.Dra = value;
				this.X0Y0_小指_指.Hit = value;
			}
		}

		public bool 小指_爪_表示
		{
			get
			{
				return this.X0Y0_小指_爪.Dra;
			}
			set
			{
				this.X0Y0_小指_爪.Dra = value;
				this.X0Y0_小指_爪.Hit = value;
			}
		}

		public bool 小指_肉球_表示
		{
			get
			{
				return this.X0Y0_小指_肉球.Dra;
			}
			set
			{
				this.X0Y0_小指_肉球.Dra = value;
				this.X0Y0_小指_肉球.Hit = value;
			}
		}

		public bool 薬指_指_表示
		{
			get
			{
				return this.X0Y0_薬指_指.Dra;
			}
			set
			{
				this.X0Y0_薬指_指.Dra = value;
				this.X0Y0_薬指_指.Hit = value;
			}
		}

		public bool 薬指_爪_表示
		{
			get
			{
				return this.X0Y0_薬指_爪.Dra;
			}
			set
			{
				this.X0Y0_薬指_爪.Dra = value;
				this.X0Y0_薬指_爪.Hit = value;
			}
		}

		public bool 薬指_肉球_表示
		{
			get
			{
				return this.X0Y0_薬指_肉球.Dra;
			}
			set
			{
				this.X0Y0_薬指_肉球.Dra = value;
				this.X0Y0_薬指_肉球.Hit = value;
			}
		}

		public bool 中指_指_表示
		{
			get
			{
				return this.X0Y0_中指_指.Dra;
			}
			set
			{
				this.X0Y0_中指_指.Dra = value;
				this.X0Y0_中指_指.Hit = value;
			}
		}

		public bool 中指_爪_表示
		{
			get
			{
				return this.X0Y0_中指_爪.Dra;
			}
			set
			{
				this.X0Y0_中指_爪.Dra = value;
				this.X0Y0_中指_爪.Hit = value;
			}
		}

		public bool 中指_肉球_表示
		{
			get
			{
				return this.X0Y0_中指_肉球.Dra;
			}
			set
			{
				this.X0Y0_中指_肉球.Dra = value;
				this.X0Y0_中指_肉球.Hit = value;
			}
		}

		public bool 人指_指_表示
		{
			get
			{
				return this.X0Y0_人指_指.Dra;
			}
			set
			{
				this.X0Y0_人指_指.Dra = value;
				this.X0Y0_人指_指.Hit = value;
			}
		}

		public bool 人指_爪_表示
		{
			get
			{
				return this.X0Y0_人指_爪.Dra;
			}
			set
			{
				this.X0Y0_人指_爪.Dra = value;
				this.X0Y0_人指_爪.Hit = value;
			}
		}

		public bool 人指_肉球_表示
		{
			get
			{
				return this.X0Y0_人指_肉球.Dra;
			}
			set
			{
				this.X0Y0_人指_肉球.Dra = value;
				this.X0Y0_人指_肉球.Hit = value;
			}
		}

		public bool 肉球_肉球左_表示
		{
			get
			{
				return this.X0Y0_肉球_肉球左.Dra;
			}
			set
			{
				this.X0Y0_肉球_肉球左.Dra = value;
				this.X0Y0_肉球_肉球左.Hit = value;
			}
		}

		public bool 肉球_肉球中_表示
		{
			get
			{
				return this.X0Y0_肉球_肉球中.Dra;
			}
			set
			{
				this.X0Y0_肉球_肉球中.Dra = value;
				this.X0Y0_肉球_肉球中.Hit = value;
			}
		}

		public bool 肉球_肉球右_表示
		{
			get
			{
				return this.X0Y0_肉球_肉球右.Dra;
			}
			set
			{
				this.X0Y0_肉球_肉球右.Dra = value;
				this.X0Y0_肉球_肉球右.Hit = value;
			}
		}

		public bool 脚輪_革_表示
		{
			get
			{
				return this.X0Y0_脚輪_革.Dra;
			}
			set
			{
				this.X0Y0_脚輪_革.Dra = value;
				this.X0Y0_脚輪_革.Hit = value;
			}
		}

		public bool 脚輪_金具1_表示
		{
			get
			{
				return this.X0Y0_脚輪_金具1.Dra;
			}
			set
			{
				this.X0Y0_脚輪_金具1.Dra = value;
				this.X0Y0_脚輪_金具1.Hit = value;
			}
		}

		public bool 脚輪_金具2_表示
		{
			get
			{
				return this.X0Y0_脚輪_金具2.Dra;
			}
			set
			{
				this.X0Y0_脚輪_金具2.Dra = value;
				this.X0Y0_脚輪_金具2.Hit = value;
			}
		}

		public bool 脚輪_金具3_表示
		{
			get
			{
				return this.X0Y0_脚輪_金具3.Dra;
			}
			set
			{
				this.X0Y0_脚輪_金具3.Dra = value;
				this.X0Y0_脚輪_金具3.Hit = value;
			}
		}

		public bool 脚輪_金具左_表示
		{
			get
			{
				return this.X0Y0_脚輪_金具左.Dra;
			}
			set
			{
				this.X0Y0_脚輪_金具左.Dra = value;
				this.X0Y0_脚輪_金具左.Hit = value;
			}
		}

		public bool 脚輪_金具右_表示
		{
			get
			{
				return this.X0Y0_脚輪_金具右.Dra;
			}
			set
			{
				this.X0Y0_脚輪_金具右.Dra = value;
				this.X0Y0_脚輪_金具右.Hit = value;
			}
		}

		public bool 脚輪表示
		{
			get
			{
				return this.脚輪_革_表示;
			}
			set
			{
				this.脚輪_革_表示 = value;
				this.脚輪_金具1_表示 = value;
				this.脚輪_金具2_表示 = value;
				this.脚輪_金具3_表示 = value;
				this.脚輪_金具左_表示 = value;
				this.脚輪_金具右_表示 = value;
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
				return this.足_表示;
			}
			set
			{
				this.足_表示 = value;
				this.筋_表示 = value;
				this.小指_指_表示 = value;
				this.小指_爪_表示 = value;
				this.小指_肉球_表示 = value;
				this.薬指_指_表示 = value;
				this.薬指_爪_表示 = value;
				this.薬指_肉球_表示 = value;
				this.中指_指_表示 = value;
				this.中指_爪_表示 = value;
				this.中指_肉球_表示 = value;
				this.人指_指_表示 = value;
				this.人指_爪_表示 = value;
				this.人指_肉球_表示 = value;
				this.肉球_肉球左_表示 = value;
				this.肉球_肉球中_表示 = value;
				this.肉球_肉球右_表示 = value;
				this.脚輪_革_表示 = value;
				this.脚輪_金具1_表示 = value;
				this.脚輪_金具2_表示 = value;
				this.脚輪_金具3_表示 = value;
				this.脚輪_金具左_表示 = value;
				this.脚輪_金具右_表示 = value;
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
				return this.足CD.不透明度;
			}
			set
			{
				this.足CD.不透明度 = value;
				this.筋CD.不透明度 = value;
				this.小指_指CD.不透明度 = value;
				this.小指_爪CD.不透明度 = value;
				this.小指_肉球CD.不透明度 = value;
				this.薬指_指CD.不透明度 = value;
				this.薬指_爪CD.不透明度 = value;
				this.薬指_肉球CD.不透明度 = value;
				this.中指_指CD.不透明度 = value;
				this.中指_爪CD.不透明度 = value;
				this.中指_肉球CD.不透明度 = value;
				this.人指_指CD.不透明度 = value;
				this.人指_爪CD.不透明度 = value;
				this.人指_肉球CD.不透明度 = value;
				this.肉球_肉球左CD.不透明度 = value;
				this.肉球_肉球中CD.不透明度 = value;
				this.肉球_肉球右CD.不透明度 = value;
				this.脚輪_革CD.不透明度 = value;
				this.脚輪_金具1CD.不透明度 = value;
				this.脚輪_金具2CD.不透明度 = value;
				this.脚輪_金具3CD.不透明度 = value;
				this.脚輪_金具左CD.不透明度 = value;
				this.脚輪_金具右CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			double num = this.右 ? -1.0 : 1.0;
			this.X0Y0_足.AngleBase = num * -40.0;
			this.X0Y0_小指_指.AngleBase = num * 22.0;
			this.X0Y0_薬指_指.AngleBase = num * 22.0;
			this.X0Y0_中指_指.AngleBase = num * 19.0;
			this.X0Y0_人指_指.AngleBase = num * 14.0;
			this.X0Y0_肉球_肉球中.AngleBase = num * 16.0;
			this.本体.JoinPAall();
		}

		public JointS 鎖1_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_脚輪_金具左, 0);
			}
		}

		public JointS 鎖2_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_脚輪_金具右, 0);
			}
		}

		public override void 色更新()
		{
			this.X0Y0_足CP.Update();
			this.X0Y0_筋CP.Update();
			this.X0Y0_小指_指CP.Update();
			this.X0Y0_小指_爪CP.Update();
			this.X0Y0_小指_肉球CP.Update();
			this.X0Y0_薬指_指CP.Update();
			this.X0Y0_薬指_爪CP.Update();
			this.X0Y0_薬指_肉球CP.Update();
			this.X0Y0_中指_指CP.Update();
			this.X0Y0_中指_爪CP.Update();
			this.X0Y0_中指_肉球CP.Update();
			this.X0Y0_人指_指CP.Update();
			this.X0Y0_人指_爪CP.Update();
			this.X0Y0_人指_肉球CP.Update();
			this.X0Y0_肉球_肉球左CP.Update();
			this.X0Y0_肉球_肉球中CP.Update();
			this.X0Y0_肉球_肉球右CP.Update();
			this.X0Y0_脚輪_革CP.Update();
			this.X0Y0_脚輪_金具1CP.Update();
			this.X0Y0_脚輪_金具2CP.Update();
			this.X0Y0_脚輪_金具3CP.Update();
			this.X0Y0_脚輪_金具左CP.Update();
			this.X0Y0_脚輪_金具右CP.Update();
			this.鎖1.接続PA();
			this.鎖1.色更新();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.足CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.筋CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.小指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.小指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.小指_肉球CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.薬指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.薬指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.薬指_肉球CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.中指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.中指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.中指_肉球CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.人指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.人指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.人指_肉球CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.肉球_肉球左CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.肉球_肉球中CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.肉球_肉球右CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.脚輪_革CD = new ColorD();
			this.脚輪_金具1CD = new ColorD();
			this.脚輪_金具2CD = new ColorD();
			this.脚輪_金具3CD = new ColorD();
			this.脚輪_金具左CD = new ColorD();
			this.脚輪_金具右CD = new ColorD();
		}

		public void 脚輪配色(拘束具色 配色)
		{
			this.脚輪_革CD.色 = 配色.革部色;
			this.脚輪_金具1CD.色 = 配色.金具色;
			this.脚輪_金具2CD.色 = this.脚輪_金具1CD.色;
			this.脚輪_金具3CD.色 = this.脚輪_金具1CD.色;
			this.脚輪_金具左CD.色 = this.脚輪_金具1CD.色;
			this.脚輪_金具右CD.色 = this.脚輪_金具1CD.色;
		}

		public void 鎖配色(鎖色 配色)
		{
			this.鎖1.配色鎖(配色);
		}

		public Par X0Y0_足;

		public Par X0Y0_筋;

		public Par X0Y0_小指_指;

		public Par X0Y0_小指_爪;

		public Par X0Y0_小指_肉球;

		public Par X0Y0_薬指_指;

		public Par X0Y0_薬指_爪;

		public Par X0Y0_薬指_肉球;

		public Par X0Y0_中指_指;

		public Par X0Y0_中指_爪;

		public Par X0Y0_中指_肉球;

		public Par X0Y0_人指_指;

		public Par X0Y0_人指_爪;

		public Par X0Y0_人指_肉球;

		public Par X0Y0_肉球_肉球左;

		public Par X0Y0_肉球_肉球中;

		public Par X0Y0_肉球_肉球右;

		public Par X0Y0_脚輪_革;

		public Par X0Y0_脚輪_金具1;

		public Par X0Y0_脚輪_金具2;

		public Par X0Y0_脚輪_金具3;

		public Par X0Y0_脚輪_金具左;

		public Par X0Y0_脚輪_金具右;

		public ColorD 足CD;

		public ColorD 筋CD;

		public ColorD 小指_指CD;

		public ColorD 小指_爪CD;

		public ColorD 小指_肉球CD;

		public ColorD 薬指_指CD;

		public ColorD 薬指_爪CD;

		public ColorD 薬指_肉球CD;

		public ColorD 中指_指CD;

		public ColorD 中指_爪CD;

		public ColorD 中指_肉球CD;

		public ColorD 人指_指CD;

		public ColorD 人指_爪CD;

		public ColorD 人指_肉球CD;

		public ColorD 肉球_肉球左CD;

		public ColorD 肉球_肉球中CD;

		public ColorD 肉球_肉球右CD;

		public ColorD 脚輪_革CD;

		public ColorD 脚輪_金具1CD;

		public ColorD 脚輪_金具2CD;

		public ColorD 脚輪_金具3CD;

		public ColorD 脚輪_金具左CD;

		public ColorD 脚輪_金具右CD;

		public ColorP X0Y0_足CP;

		public ColorP X0Y0_筋CP;

		public ColorP X0Y0_小指_指CP;

		public ColorP X0Y0_小指_爪CP;

		public ColorP X0Y0_小指_肉球CP;

		public ColorP X0Y0_薬指_指CP;

		public ColorP X0Y0_薬指_爪CP;

		public ColorP X0Y0_薬指_肉球CP;

		public ColorP X0Y0_中指_指CP;

		public ColorP X0Y0_中指_爪CP;

		public ColorP X0Y0_中指_肉球CP;

		public ColorP X0Y0_人指_指CP;

		public ColorP X0Y0_人指_爪CP;

		public ColorP X0Y0_人指_肉球CP;

		public ColorP X0Y0_肉球_肉球左CP;

		public ColorP X0Y0_肉球_肉球中CP;

		public ColorP X0Y0_肉球_肉球右CP;

		public ColorP X0Y0_脚輪_革CP;

		public ColorP X0Y0_脚輪_金具1CP;

		public ColorP X0Y0_脚輪_金具2CP;

		public ColorP X0Y0_脚輪_金具3CP;

		public ColorP X0Y0_脚輪_金具左CP;

		public ColorP X0Y0_脚輪_金具右CP;

		public 拘束鎖 鎖1;
	}
}
