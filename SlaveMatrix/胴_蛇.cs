using System;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 胴_蛇 : 長胴
	{
		public 胴_蛇(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 胴_蛇D e)
		{
			胴_蛇.<>c__DisplayClass32_0 CS$<>8__locals1 = new 胴_蛇.<>c__DisplayClass32_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			Pars pars = new Pars();
			pars.Tag = "蛇";
			pars.Add(new Pars(Sta.半身["長物"][0][2]["胴2"].ToPars()));
			pars.Add(new Pars(Sta.半身["長物"][0][2]["輪1"].ToPars()));
			Dif dif = new Dif();
			dif.Tag = pars.Tag;
			dif.Add(pars);
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars2 = this.本体[0][0];
			Pars pars3 = pars2["胴2"].ToPars();
			this.X0Y0_胴_鱗 = pars3["鱗"].ToPar();
			this.X0Y0_胴_鱗左 = pars3["鱗左"].ToPar();
			this.X0Y0_胴_鱗右 = pars3["鱗右"].ToPar();
			this.X0Y0_胴_胴 = pars3["胴"].ToPar();
			pars3 = pars2["輪1"].ToPars();
			this.X0Y0_輪_革 = pars3["革"].ToPar();
			this.X0Y0_輪_金具1 = pars3["金具1"].ToPar();
			this.X0Y0_輪_金具2 = pars3["金具2"].ToPar();
			this.X0Y0_輪_金具3 = pars3["金具3"].ToPar();
			this.X0Y0_輪_金具左 = pars3["金具左"].ToPar();
			this.X0Y0_輪_金具右 = pars3["金具右"].ToPar();
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
			this.胴_鱗_表示 = e.胴_鱗_表示;
			this.胴_鱗左_表示 = e.胴_鱗左_表示;
			this.胴_鱗右_表示 = e.胴_鱗右_表示;
			this.胴_表示 = e.胴_表示;
			this.輪_革_表示 = e.輪_革_表示;
			this.輪_金具1_表示 = e.輪_金具1_表示;
			this.輪_金具2_表示 = e.輪_金具2_表示;
			this.輪_金具3_表示 = e.輪_金具3_表示;
			this.輪_金具左_表示 = e.輪_金具左_表示;
			this.輪_金具右_表示 = e.輪_金具右_表示;
			this.輪表示 = e.輪表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.左_接続.Count > 0)
			{
				Ele f;
				this.左_接続 = e.左_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.胴_蛇_左_接続;
					f.接続(CS$<>8__locals1.<>4__this.左_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右_接続.Count > 0)
			{
				Ele f;
				this.右_接続 = e.右_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.胴_蛇_右_接続;
					f.接続(CS$<>8__locals1.<>4__this.右_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.胴_接続.Count > 0)
			{
				Ele f;
				this.胴_接続 = e.胴_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.胴_蛇_胴_接続;
					f.接続(CS$<>8__locals1.<>4__this.胴_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_胴_鱗CP = new ColorP(this.X0Y0_胴_鱗, this.胴_鱗CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_鱗左CP = new ColorP(this.X0Y0_胴_鱗左, this.胴_鱗左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_鱗右CP = new ColorP(this.X0Y0_胴_鱗右, this.胴_鱗右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_胴CP = new ColorP(this.X0Y0_胴_胴, this.胴_胴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪_革CP = new ColorP(this.X0Y0_輪_革, this.輪_革CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪_金具1CP = new ColorP(this.X0Y0_輪_金具1, this.輪_金具1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪_金具2CP = new ColorP(this.X0Y0_輪_金具2, this.輪_金具2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪_金具3CP = new ColorP(this.X0Y0_輪_金具3, this.輪_金具3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪_金具左CP = new ColorP(this.X0Y0_輪_金具左, this.輪_金具左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪_金具右CP = new ColorP(this.X0Y0_輪_金具右, this.輪_金具右CD, CS$<>8__locals1.DisUnit, true);
			this.濃度 = e.濃度;
			this.鎖1 = new 拘束鎖(CS$<>8__locals1.DisUnit, this.右, 配色指定, CS$<>8__locals1.体配色, this.Xasix);
			this.鎖2 = new 拘束鎖(CS$<>8__locals1.DisUnit, !this.右, 配色指定, CS$<>8__locals1.体配色, this.Xasix);
			this.鎖1.接続(this.鎖1_接続点);
			this.鎖2.接続(this.鎖2_接続点);
			int num = this.右 ? -10 : 10;
			this.鎖1.角度B += (double)num;
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

		public bool 胴_鱗_表示
		{
			get
			{
				return this.X0Y0_胴_鱗.Dra;
			}
			set
			{
				this.X0Y0_胴_鱗.Dra = value;
				this.X0Y0_胴_鱗.Hit = value;
			}
		}

		public bool 胴_鱗左_表示
		{
			get
			{
				return this.X0Y0_胴_鱗左.Dra;
			}
			set
			{
				this.X0Y0_胴_鱗左.Dra = value;
				this.X0Y0_胴_鱗左.Hit = value;
			}
		}

		public bool 胴_鱗右_表示
		{
			get
			{
				return this.X0Y0_胴_鱗右.Dra;
			}
			set
			{
				this.X0Y0_胴_鱗右.Dra = value;
				this.X0Y0_胴_鱗右.Hit = value;
			}
		}

		public bool 胴_表示
		{
			get
			{
				return this.X0Y0_胴_胴.Dra;
			}
			set
			{
				this.X0Y0_胴_胴.Dra = value;
				this.X0Y0_胴_胴.Hit = value;
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
				this.鎖2.表示 = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.胴_鱗_表示;
			}
			set
			{
				this.胴_鱗_表示 = value;
				this.胴_鱗左_表示 = value;
				this.胴_鱗右_表示 = value;
				this.胴_表示 = value;
				this.輪_革_表示 = value;
				this.輪_金具1_表示 = value;
				this.輪_金具2_表示 = value;
				this.輪_金具3_表示 = value;
				this.輪_金具左_表示 = value;
				this.輪_金具右_表示 = value;
				this.鎖1.表示 = value;
				this.鎖2.表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.胴_鱗CD.不透明度;
			}
			set
			{
				this.胴_鱗CD.不透明度 = value;
				this.胴_鱗左CD.不透明度 = value;
				this.胴_鱗右CD.不透明度 = value;
				this.胴_胴CD.不透明度 = value;
				this.輪_革CD.不透明度 = value;
				this.輪_金具1CD.不透明度 = value;
				this.輪_金具2CD.不透明度 = value;
				this.輪_金具3CD.不透明度 = value;
				this.輪_金具左CD.不透明度 = value;
				this.輪_金具右CD.不透明度 = value;
			}
		}

		public override void 描画0(Are Are)
		{
			Are.Draw(this.X0Y0_胴_鱗);
			Are.Draw(this.X0Y0_胴_鱗左);
			Are.Draw(this.X0Y0_胴_鱗右);
			Are.Draw(this.X0Y0_胴_胴);
			if (this.胴_接続 != null && this.胴_接続[0].拘束 && this.胴_接続[0] is 胴_蛇)
			{
				((胴_蛇)this.胴_接続[0]).拘束具描画(Are);
			}
		}

		public void 拘束具描画(Are Are)
		{
			Are.Draw(this.X0Y0_輪_革);
			Are.Draw(this.X0Y0_輪_金具1);
			Are.Draw(this.X0Y0_輪_金具2);
			Are.Draw(this.X0Y0_輪_金具3);
			Are.Draw(this.X0Y0_輪_金具左);
			Are.Draw(this.X0Y0_輪_金具右);
			this.鎖1.描画0(Are);
			this.鎖2.描画0(Are);
		}

		public override void Dispose()
		{
			base.Dispose();
			this.鎖1.Dispose();
			this.鎖2.Dispose();
		}

		public override void Set角度0()
		{
			if (this.Par != null && !(this.Par is 長物_蛇) && this.Par.Par != null && !(this.Par.Par is 長物_蛇))
			{
				bool 右 = this.右;
				this.X0Y0_胴_胴.AngleBase = 20.0.GetRanAngle();
				this.本体.JoinPAall();
			}
		}

		public override bool Is革(Par p)
		{
			return p == this.X0Y0_輪_革 || p == this.X0Y0_輪_金具1 || p == this.X0Y0_輪_金具2 || p == this.X0Y0_輪_金具3 || p == this.X0Y0_輪_金具左 || p == this.X0Y0_輪_金具右;
		}

		public JointS 左_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴_胴, 2);
			}
		}

		public JointS 右_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴_胴, 3);
			}
		}

		public JointS 胴_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴_胴, 1);
			}
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
			this.X0Y0_胴_鱗CP.Update();
			this.X0Y0_胴_鱗左CP.Update();
			this.X0Y0_胴_鱗右CP.Update();
			this.X0Y0_胴_胴CP.Update();
			this.X0Y0_輪_革CP.Update();
			this.X0Y0_輪_金具1CP.Update();
			this.X0Y0_輪_金具2CP.Update();
			this.X0Y0_輪_金具3CP.Update();
			this.X0Y0_輪_金具左CP.Update();
			this.X0Y0_輪_金具右CP.Update();
			this.鎖1.接続PA();
			this.鎖2.接続PA();
			this.鎖1.色更新();
			this.鎖2.色更新();
		}

		public void 配色(体配色 体配色)
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
			this.胴_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.胴_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_胴CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.輪_革CD = new ColorD();
			this.輪_金具1CD = new ColorD();
			this.輪_金具2CD = new ColorD();
			this.輪_金具3CD = new ColorD();
			this.輪_金具左CD = new ColorD();
			this.輪_金具右CD = new ColorD();
		}

		private void 配色T0(体配色 体配色)
		{
			this.胴_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.胴_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_胴CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.輪_革CD = new ColorD();
			this.輪_金具1CD = new ColorD();
			this.輪_金具2CD = new ColorD();
			this.輪_金具3CD = new ColorD();
			this.輪_金具左CD = new ColorD();
			this.輪_金具右CD = new ColorD();
		}

		private void 配色T1(体配色 体配色)
		{
			this.胴_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.胴_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_胴CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
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
			this.鎖1.配色鎖(配色);
			this.鎖2.配色鎖(配色);
		}

		public Par X0Y0_胴_鱗;

		public Par X0Y0_胴_鱗左;

		public Par X0Y0_胴_鱗右;

		public Par X0Y0_胴_胴;

		public Par X0Y0_輪_革;

		public Par X0Y0_輪_金具1;

		public Par X0Y0_輪_金具2;

		public Par X0Y0_輪_金具3;

		public Par X0Y0_輪_金具左;

		public Par X0Y0_輪_金具右;

		public ColorD 胴_鱗CD;

		public ColorD 胴_鱗左CD;

		public ColorD 胴_鱗右CD;

		public ColorD 胴_胴CD;

		public ColorD 輪_革CD;

		public ColorD 輪_金具1CD;

		public ColorD 輪_金具2CD;

		public ColorD 輪_金具3CD;

		public ColorD 輪_金具左CD;

		public ColorD 輪_金具右CD;

		public ColorP X0Y0_胴_鱗CP;

		public ColorP X0Y0_胴_鱗左CP;

		public ColorP X0Y0_胴_鱗右CP;

		public ColorP X0Y0_胴_胴CP;

		public ColorP X0Y0_輪_革CP;

		public ColorP X0Y0_輪_金具1CP;

		public ColorP X0Y0_輪_金具2CP;

		public ColorP X0Y0_輪_金具3CP;

		public ColorP X0Y0_輪_金具左CP;

		public ColorP X0Y0_輪_金具右CP;

		public 拘束鎖 鎖1;

		public 拘束鎖 鎖2;

		public Ele[] 左_接続;

		public Ele[] 右_接続;

		public Ele[] 胴_接続;
	}
}
