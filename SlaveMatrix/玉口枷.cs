using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 玉口枷 : Ele
	{
		public 玉口枷(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 玉口枷D e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.胴体["玉口枷"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_金具左上 = pars["金具左上"].ToPar();
			this.X0Y0_金具左下 = pars["金具左下"].ToPar();
			this.X0Y0_革左 = pars["革左"].ToPar();
			this.X0Y0_金具右上 = pars["金具右上"].ToPar();
			this.X0Y0_金具右下 = pars["金具右下"].ToPar();
			this.X0Y0_革右 = pars["革右"].ToPar();
			this.X0Y0_革 = pars["革"].ToPar();
			this.X0Y0_玉 = pars["玉"].ToPar();
			this.X0Y0_穴中上 = pars["穴中上"].ToPar();
			this.X0Y0_穴右 = pars["穴右"].ToPar();
			this.X0Y0_穴中下 = pars["穴中下"].ToPar();
			this.X0Y0_穴左 = pars["穴左"].ToPar();
			this.X0Y0_穴上右上 = pars["穴上右上"].ToPar();
			this.X0Y0_穴上右下 = pars["穴上右下"].ToPar();
			this.X0Y0_穴下右上 = pars["穴下右上"].ToPar();
			this.X0Y0_穴下右下 = pars["穴下右下"].ToPar();
			this.X0Y0_穴下左下 = pars["穴下左下"].ToPar();
			this.X0Y0_穴下左上 = pars["穴下左上"].ToPar();
			this.X0Y0_穴上左下 = pars["穴上左下"].ToPar();
			this.X0Y0_穴上左上 = pars["穴上左上"].ToPar();
			this.X0Y0_丸金具左内 = pars["丸金具左内"].ToPar();
			this.X0Y0_丸金具右内 = pars["丸金具右内"].ToPar();
			this.X0Y0_丸金具左外 = pars["丸金具左外"].ToPar();
			this.X0Y0_丸金具右外 = pars["丸金具右外"].ToPar();
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
			this.金具左上_表示 = e.金具左上_表示;
			this.金具左下_表示 = e.金具左下_表示;
			this.革左_表示 = e.革左_表示;
			this.金具右上_表示 = e.金具右上_表示;
			this.金具右下_表示 = e.金具右下_表示;
			this.革右_表示 = e.革右_表示;
			this.革_表示 = e.革_表示;
			this.玉_表示 = e.玉_表示;
			this.穴中上_表示 = e.穴中上_表示;
			this.穴右_表示 = e.穴右_表示;
			this.穴中下_表示 = e.穴中下_表示;
			this.穴左_表示 = e.穴左_表示;
			this.穴上右上_表示 = e.穴上右上_表示;
			this.穴上右下_表示 = e.穴上右下_表示;
			this.穴下右上_表示 = e.穴下右上_表示;
			this.穴下右下_表示 = e.穴下右下_表示;
			this.穴下左下_表示 = e.穴下左下_表示;
			this.穴下左上_表示 = e.穴下左上_表示;
			this.穴上左下_表示 = e.穴上左下_表示;
			this.穴上左上_表示 = e.穴上左上_表示;
			this.丸金具左内_表示 = e.丸金具左内_表示;
			this.丸金具右内2_表示 = e.丸金具右内2_表示;
			this.丸金具左外_表示 = e.丸金具左外_表示;
			this.丸金具右外_表示 = e.丸金具右外_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_金具左上CP = new ColorP(this.X0Y0_金具左上, this.金具左上CD, DisUnit, true);
			this.X0Y0_金具左下CP = new ColorP(this.X0Y0_金具左下, this.金具左下CD, DisUnit, true);
			this.X0Y0_革左CP = new ColorP(this.X0Y0_革左, this.革左CD, DisUnit, true);
			this.X0Y0_金具右上CP = new ColorP(this.X0Y0_金具右上, this.金具右上CD, DisUnit, true);
			this.X0Y0_金具右下CP = new ColorP(this.X0Y0_金具右下, this.金具右下CD, DisUnit, true);
			this.X0Y0_革右CP = new ColorP(this.X0Y0_革右, this.革右CD, DisUnit, true);
			this.X0Y0_革CP = new ColorP(this.X0Y0_革, this.革CD, DisUnit, true);
			this.X0Y0_玉CP = new ColorP(this.X0Y0_玉, this.玉CD, DisUnit, true);
			this.X0Y0_穴中上CP = new ColorP(this.X0Y0_穴中上, this.穴中上CD, DisUnit, true);
			this.X0Y0_穴右CP = new ColorP(this.X0Y0_穴右, this.穴右CD, DisUnit, true);
			this.X0Y0_穴中下CP = new ColorP(this.X0Y0_穴中下, this.穴中下CD, DisUnit, true);
			this.X0Y0_穴左CP = new ColorP(this.X0Y0_穴左, this.穴左CD, DisUnit, true);
			this.X0Y0_穴上右上CP = new ColorP(this.X0Y0_穴上右上, this.穴上右上CD, DisUnit, true);
			this.X0Y0_穴上右下CP = new ColorP(this.X0Y0_穴上右下, this.穴上右下CD, DisUnit, true);
			this.X0Y0_穴下右上CP = new ColorP(this.X0Y0_穴下右上, this.穴下右上CD, DisUnit, true);
			this.X0Y0_穴下右下CP = new ColorP(this.X0Y0_穴下右下, this.穴下右下CD, DisUnit, true);
			this.X0Y0_穴下左下CP = new ColorP(this.X0Y0_穴下左下, this.穴下左下CD, DisUnit, true);
			this.X0Y0_穴下左上CP = new ColorP(this.X0Y0_穴下左上, this.穴下左上CD, DisUnit, true);
			this.X0Y0_穴上左下CP = new ColorP(this.X0Y0_穴上左下, this.穴上左下CD, DisUnit, true);
			this.X0Y0_穴上左上CP = new ColorP(this.X0Y0_穴上左上, this.穴上左上CD, DisUnit, true);
			this.X0Y0_丸金具左内CP = new ColorP(this.X0Y0_丸金具左内, this.丸金具左内CD, DisUnit, true);
			this.X0Y0_丸金具右内CP = new ColorP(this.X0Y0_丸金具右内, this.丸金具右内CD, DisUnit, true);
			this.X0Y0_丸金具左外CP = new ColorP(this.X0Y0_丸金具左外, this.丸金具左外CD, DisUnit, true);
			this.X0Y0_丸金具右外CP = new ColorP(this.X0Y0_丸金具右外, this.丸金具右外CD, DisUnit, true);
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

		public bool 金具左上_表示
		{
			get
			{
				return this.X0Y0_金具左上.Dra;
			}
			set
			{
				this.X0Y0_金具左上.Dra = value;
				this.X0Y0_金具左上.Hit = value;
			}
		}

		public bool 金具左下_表示
		{
			get
			{
				return this.X0Y0_金具左下.Dra;
			}
			set
			{
				this.X0Y0_金具左下.Dra = value;
				this.X0Y0_金具左下.Hit = value;
			}
		}

		public bool 革左_表示
		{
			get
			{
				return this.X0Y0_革左.Dra;
			}
			set
			{
				this.X0Y0_革左.Dra = value;
				this.X0Y0_革左.Hit = value;
			}
		}

		public bool 金具右上_表示
		{
			get
			{
				return this.X0Y0_金具右上.Dra;
			}
			set
			{
				this.X0Y0_金具右上.Dra = value;
				this.X0Y0_金具右上.Hit = value;
			}
		}

		public bool 金具右下_表示
		{
			get
			{
				return this.X0Y0_金具右下.Dra;
			}
			set
			{
				this.X0Y0_金具右下.Dra = value;
				this.X0Y0_金具右下.Hit = value;
			}
		}

		public bool 革右_表示
		{
			get
			{
				return this.X0Y0_革右.Dra;
			}
			set
			{
				this.X0Y0_革右.Dra = value;
				this.X0Y0_革右.Hit = value;
			}
		}

		public bool 革_表示
		{
			get
			{
				return this.X0Y0_革.Dra;
			}
			set
			{
				this.X0Y0_革.Dra = value;
				this.X0Y0_革.Hit = value;
			}
		}

		public bool 玉_表示
		{
			get
			{
				return this.X0Y0_玉.Dra;
			}
			set
			{
				this.X0Y0_玉.Dra = value;
				this.X0Y0_玉.Hit = value;
			}
		}

		public bool 穴中上_表示
		{
			get
			{
				return this.X0Y0_穴中上.Dra;
			}
			set
			{
				this.X0Y0_穴中上.Dra = value;
				this.X0Y0_穴中上.Hit = value;
			}
		}

		public bool 穴右_表示
		{
			get
			{
				return this.X0Y0_穴右.Dra;
			}
			set
			{
				this.X0Y0_穴右.Dra = value;
				this.X0Y0_穴右.Hit = value;
			}
		}

		public bool 穴中下_表示
		{
			get
			{
				return this.X0Y0_穴中下.Dra;
			}
			set
			{
				this.X0Y0_穴中下.Dra = value;
				this.X0Y0_穴中下.Hit = value;
			}
		}

		public bool 穴左_表示
		{
			get
			{
				return this.X0Y0_穴左.Dra;
			}
			set
			{
				this.X0Y0_穴左.Dra = value;
				this.X0Y0_穴左.Hit = value;
			}
		}

		public bool 穴上右上_表示
		{
			get
			{
				return this.X0Y0_穴上右上.Dra;
			}
			set
			{
				this.X0Y0_穴上右上.Dra = value;
				this.X0Y0_穴上右上.Hit = value;
			}
		}

		public bool 穴上右下_表示
		{
			get
			{
				return this.X0Y0_穴上右下.Dra;
			}
			set
			{
				this.X0Y0_穴上右下.Dra = value;
				this.X0Y0_穴上右下.Hit = value;
			}
		}

		public bool 穴下右上_表示
		{
			get
			{
				return this.X0Y0_穴下右上.Dra;
			}
			set
			{
				this.X0Y0_穴下右上.Dra = value;
				this.X0Y0_穴下右上.Hit = value;
			}
		}

		public bool 穴下右下_表示
		{
			get
			{
				return this.X0Y0_穴下右下.Dra;
			}
			set
			{
				this.X0Y0_穴下右下.Dra = value;
				this.X0Y0_穴下右下.Hit = value;
			}
		}

		public bool 穴下左下_表示
		{
			get
			{
				return this.X0Y0_穴下左下.Dra;
			}
			set
			{
				this.X0Y0_穴下左下.Dra = value;
				this.X0Y0_穴下左下.Hit = value;
			}
		}

		public bool 穴下左上_表示
		{
			get
			{
				return this.X0Y0_穴下左上.Dra;
			}
			set
			{
				this.X0Y0_穴下左上.Dra = value;
				this.X0Y0_穴下左上.Hit = value;
			}
		}

		public bool 穴上左下_表示
		{
			get
			{
				return this.X0Y0_穴上左下.Dra;
			}
			set
			{
				this.X0Y0_穴上左下.Dra = value;
				this.X0Y0_穴上左下.Hit = value;
			}
		}

		public bool 穴上左上_表示
		{
			get
			{
				return this.X0Y0_穴上左上.Dra;
			}
			set
			{
				this.X0Y0_穴上左上.Dra = value;
				this.X0Y0_穴上左上.Hit = value;
			}
		}

		public bool 丸金具左内_表示
		{
			get
			{
				return this.X0Y0_丸金具左内.Dra;
			}
			set
			{
				this.X0Y0_丸金具左内.Dra = value;
				this.X0Y0_丸金具左内.Hit = value;
			}
		}

		public bool 丸金具右内2_表示
		{
			get
			{
				return this.X0Y0_丸金具右内.Dra;
			}
			set
			{
				this.X0Y0_丸金具右内.Dra = value;
				this.X0Y0_丸金具右内.Hit = value;
			}
		}

		public bool 丸金具左外_表示
		{
			get
			{
				return this.X0Y0_丸金具左外.Dra;
			}
			set
			{
				this.X0Y0_丸金具左外.Dra = value;
				this.X0Y0_丸金具左外.Hit = value;
			}
		}

		public bool 丸金具右外_表示
		{
			get
			{
				return this.X0Y0_丸金具右外.Dra;
			}
			set
			{
				this.X0Y0_丸金具右外.Dra = value;
				this.X0Y0_丸金具右外.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.金具左上_表示;
			}
			set
			{
				this.金具左上_表示 = value;
				this.金具左下_表示 = value;
				this.革左_表示 = value;
				this.金具右上_表示 = value;
				this.金具右下_表示 = value;
				this.革右_表示 = value;
				this.革_表示 = value;
				this.玉_表示 = value;
				this.穴中上_表示 = value;
				this.穴右_表示 = value;
				this.穴中下_表示 = value;
				this.穴左_表示 = value;
				this.穴上右上_表示 = value;
				this.穴上右下_表示 = value;
				this.穴下右上_表示 = value;
				this.穴下右下_表示 = value;
				this.穴下左下_表示 = value;
				this.穴下左上_表示 = value;
				this.穴上左下_表示 = value;
				this.穴上左上_表示 = value;
				this.丸金具左内_表示 = value;
				this.丸金具右内2_表示 = value;
				this.丸金具左外_表示 = value;
				this.丸金具右外_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.金具左上CD.不透明度;
			}
			set
			{
				this.金具左上CD.不透明度 = value;
				this.金具左下CD.不透明度 = value;
				this.革左CD.不透明度 = value;
				this.金具右上CD.不透明度 = value;
				this.金具右下CD.不透明度 = value;
				this.革右CD.不透明度 = value;
				this.革CD.不透明度 = value;
				this.玉CD.不透明度 = value;
				this.穴中上CD.不透明度 = value;
				this.穴右CD.不透明度 = value;
				this.穴中下CD.不透明度 = value;
				this.穴左CD.不透明度 = value;
				this.穴上右上CD.不透明度 = value;
				this.穴上右下CD.不透明度 = value;
				this.穴下右上CD.不透明度 = value;
				this.穴下右下CD.不透明度 = value;
				this.穴下左下CD.不透明度 = value;
				this.穴下左上CD.不透明度 = value;
				this.穴上左下CD.不透明度 = value;
				this.穴上左上CD.不透明度 = value;
				this.丸金具左内CD.不透明度 = value;
				this.丸金具右内CD.不透明度 = value;
				this.丸金具左外CD.不透明度 = value;
				this.丸金具右外CD.不透明度 = value;
			}
		}

		public override bool Is革(Par p)
		{
			return p == this.X0Y0_金具左上 || p == this.X0Y0_金具左下 || p == this.X0Y0_革左 || p == this.X0Y0_金具右上 || p == this.X0Y0_金具右下 || p == this.X0Y0_革右 || p == this.X0Y0_革 || p == this.X0Y0_玉 || p == this.X0Y0_穴中上 || p == this.X0Y0_穴右 || p == this.X0Y0_穴中下 || p == this.X0Y0_穴左 || p == this.X0Y0_穴上右上 || p == this.X0Y0_穴上右下 || p == this.X0Y0_穴下右上 || p == this.X0Y0_穴下右下 || p == this.X0Y0_穴下左下 || p == this.X0Y0_穴下左上 || p == this.X0Y0_穴上左下 || p == this.X0Y0_穴上左上 || p == this.X0Y0_丸金具左内 || p == this.X0Y0_丸金具右内 || p == this.X0Y0_丸金具左外 || p == this.X0Y0_丸金具右外;
		}

		public override void 色更新()
		{
			this.X0Y0_金具左上CP.Update();
			this.X0Y0_金具左下CP.Update();
			this.X0Y0_革左CP.Update();
			this.X0Y0_金具右上CP.Update();
			this.X0Y0_金具右下CP.Update();
			this.X0Y0_革右CP.Update();
			this.X0Y0_革CP.Update();
			this.X0Y0_玉CP.Update();
			this.X0Y0_穴中上CP.Update();
			this.X0Y0_穴右CP.Update();
			this.X0Y0_穴中下CP.Update();
			this.X0Y0_穴左CP.Update();
			this.X0Y0_穴上右上CP.Update();
			this.X0Y0_穴上右下CP.Update();
			this.X0Y0_穴下右上CP.Update();
			this.X0Y0_穴下右下CP.Update();
			this.X0Y0_穴下左下CP.Update();
			this.X0Y0_穴下左上CP.Update();
			this.X0Y0_穴上左下CP.Update();
			this.X0Y0_穴上左上CP.Update();
			this.X0Y0_丸金具左内CP.Update();
			this.X0Y0_丸金具右内CP.Update();
			this.X0Y0_丸金具左外CP.Update();
			this.X0Y0_丸金具右外CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.金具左上CD = new ColorD();
			this.金具左下CD = new ColorD();
			this.革左CD = new ColorD();
			this.金具右上CD = new ColorD();
			this.金具右下CD = new ColorD();
			this.革右CD = new ColorD();
			this.革CD = new ColorD();
			this.玉CD = new ColorD();
			this.穴中上CD = new ColorD();
			this.穴右CD = new ColorD();
			this.穴中下CD = new ColorD();
			this.穴左CD = new ColorD();
			this.穴上右上CD = new ColorD();
			this.穴上右下CD = new ColorD();
			this.穴下右上CD = new ColorD();
			this.穴下右下CD = new ColorD();
			this.穴下左下CD = new ColorD();
			this.穴下左上CD = new ColorD();
			this.穴上左下CD = new ColorD();
			this.穴上左上CD = new ColorD();
			this.丸金具左内CD = new ColorD();
			this.丸金具右内CD = new ColorD();
			this.丸金具左外CD = new ColorD();
			this.丸金具右外CD = new ColorD();
		}

		public void 配色(玉口枷色 配色)
		{
			this.金具左上CD.色 = 配色.金具色;
			this.金具左下CD.色 = this.金具左上CD.色;
			this.革左CD.色 = 配色.革部色;
			this.金具右上CD.色 = this.金具左上CD.色;
			this.金具右下CD.色 = this.金具左上CD.色;
			this.革右CD.色 = this.革左CD.色;
			this.革CD.色 = this.革左CD.色;
			this.玉CD.色 = 配色.玉部色;
			Color2 色;
			this.玉CD.色.GetRep(out 色);
			this.穴中上CD.色 = 色;
			this.穴右CD.色 = this.穴中上CD.色;
			this.穴中下CD.色 = this.穴中上CD.色;
			this.穴左CD.色 = this.穴中上CD.色;
			this.穴上右上CD.色 = this.穴中上CD.色;
			this.穴上右下CD.色 = this.穴中上CD.色;
			this.穴下右上CD.色 = this.穴中上CD.色;
			this.穴下右下CD.色 = this.穴中上CD.色;
			this.穴下左下CD.色 = this.穴中上CD.色;
			this.穴下左上CD.色 = this.穴中上CD.色;
			this.穴上左下CD.色 = this.穴中上CD.色;
			this.穴上左上CD.色 = this.穴中上CD.色;
			this.丸金具左内CD.色 = this.金具左上CD.色;
			this.丸金具右内CD.色 = this.金具左上CD.色;
			this.丸金具左外CD.色 = this.金具左上CD.色;
			this.丸金具右外CD.色 = this.金具左上CD.色;
		}

		public Par X0Y0_金具左上;

		public Par X0Y0_金具左下;

		public Par X0Y0_革左;

		public Par X0Y0_金具右上;

		public Par X0Y0_金具右下;

		public Par X0Y0_革右;

		public Par X0Y0_革;

		public Par X0Y0_玉;

		public Par X0Y0_穴中上;

		public Par X0Y0_穴右;

		public Par X0Y0_穴中下;

		public Par X0Y0_穴左;

		public Par X0Y0_穴上右上;

		public Par X0Y0_穴上右下;

		public Par X0Y0_穴下右上;

		public Par X0Y0_穴下右下;

		public Par X0Y0_穴下左下;

		public Par X0Y0_穴下左上;

		public Par X0Y0_穴上左下;

		public Par X0Y0_穴上左上;

		public Par X0Y0_丸金具左内;

		public Par X0Y0_丸金具右内;

		public Par X0Y0_丸金具左外;

		public Par X0Y0_丸金具右外;

		public ColorD 金具左上CD;

		public ColorD 金具左下CD;

		public ColorD 革左CD;

		public ColorD 金具右上CD;

		public ColorD 金具右下CD;

		public ColorD 革右CD;

		public ColorD 革CD;

		public ColorD 玉CD;

		public ColorD 穴中上CD;

		public ColorD 穴右CD;

		public ColorD 穴中下CD;

		public ColorD 穴左CD;

		public ColorD 穴上右上CD;

		public ColorD 穴上右下CD;

		public ColorD 穴下右上CD;

		public ColorD 穴下右下CD;

		public ColorD 穴下左下CD;

		public ColorD 穴下左上CD;

		public ColorD 穴上左下CD;

		public ColorD 穴上左上CD;

		public ColorD 丸金具左内CD;

		public ColorD 丸金具右内CD;

		public ColorD 丸金具左外CD;

		public ColorD 丸金具右外CD;

		public ColorP X0Y0_金具左上CP;

		public ColorP X0Y0_金具左下CP;

		public ColorP X0Y0_革左CP;

		public ColorP X0Y0_金具右上CP;

		public ColorP X0Y0_金具右下CP;

		public ColorP X0Y0_革右CP;

		public ColorP X0Y0_革CP;

		public ColorP X0Y0_玉CP;

		public ColorP X0Y0_穴中上CP;

		public ColorP X0Y0_穴右CP;

		public ColorP X0Y0_穴中下CP;

		public ColorP X0Y0_穴左CP;

		public ColorP X0Y0_穴上右上CP;

		public ColorP X0Y0_穴上右下CP;

		public ColorP X0Y0_穴下右上CP;

		public ColorP X0Y0_穴下右下CP;

		public ColorP X0Y0_穴下左下CP;

		public ColorP X0Y0_穴下左上CP;

		public ColorP X0Y0_穴上左下CP;

		public ColorP X0Y0_穴上左上CP;

		public ColorP X0Y0_丸金具左内CP;

		public ColorP X0Y0_丸金具右内CP;

		public ColorP X0Y0_丸金具左外CP;

		public ColorP X0Y0_丸金具右外CP;
	}
}
