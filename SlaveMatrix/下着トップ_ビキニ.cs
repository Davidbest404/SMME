using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 下着トップ_ビキニ : 下着トップ
	{
		public 下着トップ_ビキニ(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 下着トップ_ビキニD e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif(Sta.胴体["下着トップ"][1]);
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_紐 = pars["紐"].ToPar();
			Pars pars2 = pars["カップ左"].ToPars();
			this.X0Y0_カップ左_紐 = pars2["紐"].ToPar();
			this.X0Y0_カップ左_カップ = pars2["カップ"].ToPar();
			Pars pars3 = pars2["縁"].ToPars();
			this.X0Y0_カップ左_縁_縁1 = pars3["縁1"].ToPar();
			this.X0Y0_カップ左_縁_縁2 = pars3["縁2"].ToPar();
			this.X0Y0_カップ左_縁_縁3 = pars3["縁3"].ToPar();
			this.X0Y0_カップ左_縁_縁4 = pars3["縁4"].ToPar();
			pars2 = pars["カップ右"].ToPars();
			this.X0Y0_カップ右_紐 = pars2["紐"].ToPar();
			this.X0Y0_カップ右_カップ = pars2["カップ"].ToPar();
			pars3 = pars2["縁"].ToPars();
			this.X0Y0_カップ右_縁_縁1 = pars3["縁1"].ToPar();
			this.X0Y0_カップ右_縁_縁2 = pars3["縁2"].ToPar();
			this.X0Y0_カップ右_縁_縁3 = pars3["縁3"].ToPar();
			this.X0Y0_カップ右_縁_縁4 = pars3["縁4"].ToPar();
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
			this.sb = this.尺度B;
			this.syb = this.尺度YB;
			this.肥大 = e.肥大;
			this.身長 = e.身長;
			this.Xv = e.Xv;
			this.Yv = e.Yv;
			this.Xi = e.Xi;
			this.Yi = e.Yi;
			this.サイズ = e.サイズ;
			this.サイズX = e.サイズX;
			this.サイズY = e.サイズY;
			this.紐_表示 = e.紐_表示;
			this.カップ左_紐_表示 = e.カップ左_紐_表示;
			this.カップ左_カップ_表示 = e.カップ左_カップ_表示;
			this.カップ左_縁_縁1_表示 = e.カップ左_縁_縁1_表示;
			this.カップ左_縁_縁2_表示 = e.カップ左_縁_縁2_表示;
			this.カップ左_縁_縁3_表示 = e.カップ左_縁_縁3_表示;
			this.カップ左_縁_縁4_表示 = e.カップ左_縁_縁4_表示;
			this.カップ右_紐_表示 = e.カップ右_紐_表示;
			this.カップ右_カップ_表示 = e.カップ右_カップ_表示;
			this.カップ右_縁_縁1_表示 = e.カップ右_縁_縁1_表示;
			this.カップ右_縁_縁2_表示 = e.カップ右_縁_縁2_表示;
			this.カップ右_縁_縁3_表示 = e.カップ右_縁_縁3_表示;
			this.カップ右_縁_縁4_表示 = e.カップ右_縁_縁4_表示;
			this.ベ\u30FCス表示 = e.ベ\u30FCス表示;
			this.縁1表示 = e.縁1表示;
			this.縁2表示 = e.縁2表示;
			this.縁3表示 = e.縁3表示;
			this.縁4表示 = e.縁4表示;
			this.バスト = e.バスト;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_紐CP = new ColorP(this.X0Y0_紐, this.紐CD, DisUnit, true);
			this.X0Y0_カップ左_紐CP = new ColorP(this.X0Y0_カップ左_紐, this.カップ左_紐CD, DisUnit, true);
			this.X0Y0_カップ左_カップCP = new ColorP(this.X0Y0_カップ左_カップ, this.カップ左_カップCD, DisUnit, true);
			this.X0Y0_カップ左_縁_縁1CP = new ColorP(this.X0Y0_カップ左_縁_縁1, this.カップ左_縁_縁1CD, DisUnit, true);
			this.X0Y0_カップ左_縁_縁2CP = new ColorP(this.X0Y0_カップ左_縁_縁2, this.カップ左_縁_縁2CD, DisUnit, true);
			this.X0Y0_カップ左_縁_縁3CP = new ColorP(this.X0Y0_カップ左_縁_縁3, this.カップ左_縁_縁3CD, DisUnit, true);
			this.X0Y0_カップ左_縁_縁4CP = new ColorP(this.X0Y0_カップ左_縁_縁4, this.カップ左_縁_縁4CD, DisUnit, true);
			this.X0Y0_カップ右_紐CP = new ColorP(this.X0Y0_カップ右_紐, this.カップ右_紐CD, DisUnit, true);
			this.X0Y0_カップ右_カップCP = new ColorP(this.X0Y0_カップ右_カップ, this.カップ右_カップCD, DisUnit, true);
			this.X0Y0_カップ右_縁_縁1CP = new ColorP(this.X0Y0_カップ右_縁_縁1, this.カップ右_縁_縁1CD, DisUnit, true);
			this.X0Y0_カップ右_縁_縁2CP = new ColorP(this.X0Y0_カップ右_縁_縁2, this.カップ右_縁_縁2CD, DisUnit, true);
			this.X0Y0_カップ右_縁_縁3CP = new ColorP(this.X0Y0_カップ右_縁_縁3, this.カップ右_縁_縁3CD, DisUnit, true);
			this.X0Y0_カップ右_縁_縁4CP = new ColorP(this.X0Y0_カップ右_縁_縁4, this.カップ右_縁_縁4CD, DisUnit, true);
			this.尺度YB *= 1.1;
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

		public bool 紐_表示
		{
			get
			{
				return this.X0Y0_紐.Dra;
			}
			set
			{
				this.X0Y0_紐.Dra = value;
				this.X0Y0_紐.Hit = false;
			}
		}

		public bool カップ左_紐_表示
		{
			get
			{
				return this.X0Y0_カップ左_紐.Dra;
			}
			set
			{
				this.X0Y0_カップ左_紐.Dra = value;
				this.X0Y0_カップ左_紐.Hit = false;
			}
		}

		public bool カップ左_カップ_表示
		{
			get
			{
				return this.X0Y0_カップ左_カップ.Dra;
			}
			set
			{
				this.X0Y0_カップ左_カップ.Dra = value;
				this.X0Y0_カップ左_カップ.Hit = false;
			}
		}

		public bool カップ左_縁_縁1_表示
		{
			get
			{
				return this.X0Y0_カップ左_縁_縁1.Dra;
			}
			set
			{
				this.X0Y0_カップ左_縁_縁1.Dra = value;
				this.X0Y0_カップ左_縁_縁1.Hit = false;
			}
		}

		public bool カップ左_縁_縁2_表示
		{
			get
			{
				return this.X0Y0_カップ左_縁_縁2.Dra;
			}
			set
			{
				this.X0Y0_カップ左_縁_縁2.Dra = value;
				this.X0Y0_カップ左_縁_縁2.Hit = false;
			}
		}

		public bool カップ左_縁_縁3_表示
		{
			get
			{
				return this.X0Y0_カップ左_縁_縁3.Dra;
			}
			set
			{
				this.X0Y0_カップ左_縁_縁3.Dra = value;
				this.X0Y0_カップ左_縁_縁3.Hit = false;
			}
		}

		public bool カップ左_縁_縁4_表示
		{
			get
			{
				return this.X0Y0_カップ左_縁_縁4.Dra;
			}
			set
			{
				this.X0Y0_カップ左_縁_縁4.Dra = value;
				this.X0Y0_カップ左_縁_縁4.Hit = false;
			}
		}

		public bool カップ右_紐_表示
		{
			get
			{
				return this.X0Y0_カップ右_紐.Dra;
			}
			set
			{
				this.X0Y0_カップ右_紐.Dra = value;
				this.X0Y0_カップ右_紐.Hit = false;
			}
		}

		public bool カップ右_カップ_表示
		{
			get
			{
				return this.X0Y0_カップ右_カップ.Dra;
			}
			set
			{
				this.X0Y0_カップ右_カップ.Dra = value;
				this.X0Y0_カップ右_カップ.Hit = false;
			}
		}

		public bool カップ右_縁_縁1_表示
		{
			get
			{
				return this.X0Y0_カップ右_縁_縁1.Dra;
			}
			set
			{
				this.X0Y0_カップ右_縁_縁1.Dra = value;
				this.X0Y0_カップ右_縁_縁1.Hit = false;
			}
		}

		public bool カップ右_縁_縁2_表示
		{
			get
			{
				return this.X0Y0_カップ右_縁_縁2.Dra;
			}
			set
			{
				this.X0Y0_カップ右_縁_縁2.Dra = value;
				this.X0Y0_カップ右_縁_縁2.Hit = false;
			}
		}

		public bool カップ右_縁_縁3_表示
		{
			get
			{
				return this.X0Y0_カップ右_縁_縁3.Dra;
			}
			set
			{
				this.X0Y0_カップ右_縁_縁3.Dra = value;
				this.X0Y0_カップ右_縁_縁3.Hit = false;
			}
		}

		public bool カップ右_縁_縁4_表示
		{
			get
			{
				return this.X0Y0_カップ右_縁_縁4.Dra;
			}
			set
			{
				this.X0Y0_カップ右_縁_縁4.Dra = value;
				this.X0Y0_カップ右_縁_縁4.Hit = false;
			}
		}

		public bool ベ\u30FCス表示
		{
			get
			{
				return this.紐_表示;
			}
			set
			{
				this.紐_表示 = value;
				this.カップ左_紐_表示 = value;
				this.カップ左_カップ_表示 = value;
				this.カップ右_紐_表示 = value;
				this.カップ右_カップ_表示 = value;
			}
		}

		public bool 縁1表示
		{
			get
			{
				return this.カップ左_縁_縁3_表示;
			}
			set
			{
				this.カップ左_縁_縁3_表示 = value;
				this.カップ右_縁_縁3_表示 = value;
			}
		}

		public bool 縁2表示
		{
			get
			{
				return this.カップ左_縁_縁2_表示;
			}
			set
			{
				this.カップ左_縁_縁2_表示 = value;
				this.カップ右_縁_縁2_表示 = value;
			}
		}

		public bool 縁3表示
		{
			get
			{
				return this.カップ左_縁_縁1_表示;
			}
			set
			{
				this.カップ左_縁_縁1_表示 = value;
				this.カップ右_縁_縁1_表示 = value;
			}
		}

		public bool 縁4表示
		{
			get
			{
				return this.カップ左_縁_縁4_表示;
			}
			set
			{
				this.カップ左_縁_縁4_表示 = value;
				this.カップ右_縁_縁4_表示 = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.紐_表示;
			}
			set
			{
				this.紐_表示 = value;
				this.カップ左_紐_表示 = value;
				this.カップ左_カップ_表示 = value;
				this.カップ左_縁_縁1_表示 = value;
				this.カップ左_縁_縁2_表示 = value;
				this.カップ左_縁_縁3_表示 = value;
				this.カップ左_縁_縁4_表示 = value;
				this.カップ右_紐_表示 = value;
				this.カップ右_カップ_表示 = value;
				this.カップ右_縁_縁1_表示 = value;
				this.カップ右_縁_縁2_表示 = value;
				this.カップ右_縁_縁3_表示 = value;
				this.カップ右_縁_縁4_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.紐CD.不透明度;
			}
			set
			{
				this.紐CD.不透明度 = value;
				this.カップ左_紐CD.不透明度 = value;
				this.カップ左_カップCD.不透明度 = value;
				this.カップ左_縁_縁1CD.不透明度 = value;
				this.カップ左_縁_縁2CD.不透明度 = value;
				this.カップ左_縁_縁3CD.不透明度 = value;
				this.カップ左_縁_縁4CD.不透明度 = value;
				this.カップ右_紐CD.不透明度 = value;
				this.カップ右_カップCD.不透明度 = value;
				this.カップ右_縁_縁1CD.不透明度 = value;
				this.カップ右_縁_縁2CD.不透明度 = value;
				this.カップ右_縁_縁3CD.不透明度 = value;
				this.カップ右_縁_縁4CD.不透明度 = value;
			}
		}

		public double バスト
		{
			set
			{
				double num = this.sb * (0.9 + 0.25 * value);
				this.X0Y0_カップ左_紐.SizeBase = num;
				this.X0Y0_カップ左_カップ.SizeBase = num;
				this.X0Y0_カップ左_縁_縁1.SizeBase = num;
				this.X0Y0_カップ左_縁_縁2.SizeBase = num;
				this.X0Y0_カップ左_縁_縁3.SizeBase = num;
				this.X0Y0_カップ左_縁_縁4.SizeBase = num;
				this.X0Y0_カップ右_紐.SizeBase = num;
				this.X0Y0_カップ右_カップ.SizeBase = num;
				this.X0Y0_カップ右_縁_縁1.SizeBase = num;
				this.X0Y0_カップ右_縁_縁2.SizeBase = num;
				this.X0Y0_カップ右_縁_縁3.SizeBase = num;
				this.X0Y0_カップ右_縁_縁4.SizeBase = num;
				num = this.syb * (1.0 + 0.05 * value);
				this.X0Y0_カップ左_紐.SizeYBase = num;
				this.X0Y0_カップ左_カップ.SizeYBase = num;
				this.X0Y0_カップ左_縁_縁1.SizeYBase = num;
				this.X0Y0_カップ左_縁_縁2.SizeYBase = num;
				this.X0Y0_カップ左_縁_縁3.SizeYBase = num;
				this.X0Y0_カップ左_縁_縁4.SizeYBase = num;
				this.X0Y0_カップ右_紐.SizeYBase = num;
				this.X0Y0_カップ右_カップ.SizeYBase = num;
				this.X0Y0_カップ右_縁_縁1.SizeYBase = num;
				this.X0Y0_カップ右_縁_縁2.SizeYBase = num;
				this.X0Y0_カップ右_縁_縁3.SizeYBase = num;
				this.X0Y0_カップ右_縁_縁4.SizeYBase = num;
				num = 1.0 + (-0.5 * value + 0.2 * value.Inverse());
				this.X0Y0_カップ左_紐.SizeYBase *= num;
				this.X0Y0_カップ右_紐.SizeYBase *= num;
				this.位置C = new Vector2D(this.位置C.X, -0.003 * this.肥大);
			}
		}

		public override void 描画0(Are Are)
		{
			Are.Draw(this.X0Y0_紐);
		}

		public override void 描画1(Are Are)
		{
			Are.Draw(this.X0Y0_カップ左_紐);
			Are.Draw(this.X0Y0_カップ左_カップ);
			Are.Draw(this.X0Y0_カップ左_縁_縁1);
			Are.Draw(this.X0Y0_カップ左_縁_縁2);
			Are.Draw(this.X0Y0_カップ左_縁_縁3);
			Are.Draw(this.X0Y0_カップ左_縁_縁4);
			Are.Draw(this.X0Y0_カップ右_紐);
			Are.Draw(this.X0Y0_カップ右_カップ);
			Are.Draw(this.X0Y0_カップ右_縁_縁1);
			Are.Draw(this.X0Y0_カップ右_縁_縁2);
			Are.Draw(this.X0Y0_カップ右_縁_縁3);
			Are.Draw(this.X0Y0_カップ右_縁_縁4);
		}

		public override bool Is布(Par p)
		{
			return p == this.X0Y0_紐 || p == this.X0Y0_カップ左_紐 || p == this.X0Y0_カップ左_カップ || p == this.X0Y0_カップ左_縁_縁1 || p == this.X0Y0_カップ左_縁_縁2 || p == this.X0Y0_カップ左_縁_縁3 || p == this.X0Y0_カップ左_縁_縁4 || p == this.X0Y0_カップ右_紐 || p == this.X0Y0_カップ右_カップ || p == this.X0Y0_カップ右_縁_縁1 || p == this.X0Y0_カップ右_縁_縁2 || p == this.X0Y0_カップ右_縁_縁3 || p == this.X0Y0_カップ右_縁_縁4;
		}

		public override void 色更新()
		{
			this.X0Y0_紐CP.Update();
			this.X0Y0_カップ左_紐CP.Update();
			this.X0Y0_カップ左_カップCP.Update();
			this.X0Y0_カップ左_縁_縁1CP.Update();
			this.X0Y0_カップ左_縁_縁2CP.Update();
			this.X0Y0_カップ左_縁_縁3CP.Update();
			this.X0Y0_カップ左_縁_縁4CP.Update();
			this.X0Y0_カップ右_紐CP.Update();
			this.X0Y0_カップ右_カップCP.Update();
			this.X0Y0_カップ右_縁_縁1CP.Update();
			this.X0Y0_カップ右_縁_縁2CP.Update();
			this.X0Y0_カップ右_縁_縁3CP.Update();
			this.X0Y0_カップ右_縁_縁4CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.紐CD = new ColorD();
			this.カップ左_紐CD = new ColorD();
			this.カップ左_カップCD = new ColorD();
			this.カップ左_縁_縁1CD = new ColorD();
			this.カップ左_縁_縁2CD = new ColorD();
			this.カップ左_縁_縁3CD = new ColorD();
			this.カップ左_縁_縁4CD = new ColorD();
			this.カップ右_紐CD = new ColorD();
			this.カップ右_カップCD = new ColorD();
			this.カップ右_縁_縁1CD = new ColorD();
			this.カップ右_縁_縁2CD = new ColorD();
			this.カップ右_縁_縁3CD = new ColorD();
			this.カップ右_縁_縁4CD = new ColorD();
		}

		public void 配色(ビキニT色 配色)
		{
			this.紐CD.色 = 配色.紐色;
			this.カップ左_紐CD.色 = this.紐CD.色;
			this.カップ左_カップCD.色 = 配色.生地色;
			this.カップ左_縁_縁1CD.色 = 配色.縁色;
			this.カップ左_縁_縁2CD.色 = this.カップ左_縁_縁1CD.色;
			this.カップ左_縁_縁3CD.色 = this.カップ左_縁_縁1CD.色;
			this.カップ左_縁_縁4CD.色 = this.カップ左_縁_縁1CD.色;
			this.カップ右_紐CD.色 = this.紐CD.色;
			this.カップ右_カップCD.色 = this.カップ左_カップCD.色;
			this.カップ右_縁_縁1CD.色 = this.カップ左_縁_縁1CD.色;
			this.カップ右_縁_縁2CD.色 = this.カップ左_縁_縁1CD.色;
			this.カップ右_縁_縁3CD.色 = this.カップ左_縁_縁1CD.色;
			this.カップ右_縁_縁4CD.色 = this.カップ左_縁_縁1CD.色;
		}

		public Par X0Y0_紐;

		public Par X0Y0_カップ左_紐;

		public Par X0Y0_カップ左_カップ;

		public Par X0Y0_カップ左_縁_縁1;

		public Par X0Y0_カップ左_縁_縁2;

		public Par X0Y0_カップ左_縁_縁3;

		public Par X0Y0_カップ左_縁_縁4;

		public Par X0Y0_カップ右_紐;

		public Par X0Y0_カップ右_カップ;

		public Par X0Y0_カップ右_縁_縁1;

		public Par X0Y0_カップ右_縁_縁2;

		public Par X0Y0_カップ右_縁_縁3;

		public Par X0Y0_カップ右_縁_縁4;

		public ColorD 紐CD;

		public ColorD カップ左_紐CD;

		public ColorD カップ左_カップCD;

		public ColorD カップ左_縁_縁1CD;

		public ColorD カップ左_縁_縁2CD;

		public ColorD カップ左_縁_縁3CD;

		public ColorD カップ左_縁_縁4CD;

		public ColorD カップ右_紐CD;

		public ColorD カップ右_カップCD;

		public ColorD カップ右_縁_縁1CD;

		public ColorD カップ右_縁_縁2CD;

		public ColorD カップ右_縁_縁3CD;

		public ColorD カップ右_縁_縁4CD;

		public ColorP X0Y0_紐CP;

		public ColorP X0Y0_カップ左_紐CP;

		public ColorP X0Y0_カップ左_カップCP;

		public ColorP X0Y0_カップ左_縁_縁1CP;

		public ColorP X0Y0_カップ左_縁_縁2CP;

		public ColorP X0Y0_カップ左_縁_縁3CP;

		public ColorP X0Y0_カップ左_縁_縁4CP;

		public ColorP X0Y0_カップ右_紐CP;

		public ColorP X0Y0_カップ右_カップCP;

		public ColorP X0Y0_カップ右_縁_縁1CP;

		public ColorP X0Y0_カップ右_縁_縁2CP;

		public ColorP X0Y0_カップ右_縁_縁3CP;

		public ColorP X0Y0_カップ右_縁_縁4CP;

		private double sb;

		private double syb;
	}
}
