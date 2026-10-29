using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 角2_巻 : 角2
	{
		public 角2_巻(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 角2_巻D e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif(Sta.肢左["角"][3]);
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			Pars pars2 = pars["根"].ToPars();
			this.X0Y0_根_根 = pars2["根"].ToPar();
			this.X0Y0_根_凸6 = pars2["凸6"].ToPar();
			this.X0Y0_根_凸5 = pars2["凸5"].ToPar();
			this.X0Y0_根_凸4 = pars2["凸4"].ToPar();
			this.X0Y0_根_凸3 = pars2["凸3"].ToPar();
			this.X0Y0_根_凸2 = pars2["凸2"].ToPar();
			this.X0Y0_根_凸1 = pars2["凸1"].ToPar();
			pars2 = pars["先"].ToPars();
			this.X0Y0_先_先 = pars2["先"].ToPar();
			this.X0Y0_先_凸1 = pars2["凸1"].ToPar();
			this.X0Y0_先_凸2 = pars2["凸2"].ToPar();
			this.X0Y0_先_凸3 = pars2["凸3"].ToPar();
			this.X0Y0_先_凸4 = pars2["凸4"].ToPar();
			this.X0Y0_先_凸5 = pars2["凸5"].ToPar();
			pars2 = this.本体[0][1]["根"].ToPars();
			this.X0Y1_根_根 = pars2["根"].ToPar();
			this.X0Y1_根_折線1 = pars2["折線1"].ToPar();
			this.X0Y1_根_折線2 = pars2["折線2"].ToPar();
			this.X0Y1_根_凸6 = pars2["凸6"].ToPar();
			this.X0Y1_根_凸4 = pars2["凸4"].ToPar();
			this.X0Y1_根_凸3 = pars2["凸3"].ToPar();
			this.X0Y1_根_凸2 = pars2["凸2"].ToPar();
			this.X0Y1_根_凸1 = pars2["凸1"].ToPar();
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
			this.根_根_表示 = e.根_根_表示;
			this.根_凸6_表示 = e.根_凸6_表示;
			this.根_凸5_表示 = e.根_凸5_表示;
			this.根_凸4_表示 = e.根_凸4_表示;
			this.根_凸3_表示 = e.根_凸3_表示;
			this.根_凸2_表示 = e.根_凸2_表示;
			this.根_凸1_表示 = e.根_凸1_表示;
			this.先_先_表示 = e.先_先_表示;
			this.先_凸1_表示 = e.先_凸1_表示;
			this.先_凸2_表示 = e.先_凸2_表示;
			this.先_凸3_表示 = e.先_凸3_表示;
			this.先_凸4_表示 = e.先_凸4_表示;
			this.先_凸5_表示 = e.先_凸5_表示;
			this.根_折線1_表示 = e.根_折線1_表示;
			this.根_折線2_表示 = e.根_折線2_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_根_根CP = new ColorP(this.X0Y0_根_根, this.根_根CD, DisUnit, true);
			this.X0Y0_根_凸6CP = new ColorP(this.X0Y0_根_凸6, this.根_凸6CD, DisUnit, true);
			this.X0Y0_根_凸5CP = new ColorP(this.X0Y0_根_凸5, this.根_凸5CD, DisUnit, true);
			this.X0Y0_根_凸4CP = new ColorP(this.X0Y0_根_凸4, this.根_凸4CD, DisUnit, true);
			this.X0Y0_根_凸3CP = new ColorP(this.X0Y0_根_凸3, this.根_凸3CD, DisUnit, true);
			this.X0Y0_根_凸2CP = new ColorP(this.X0Y0_根_凸2, this.根_凸2CD, DisUnit, true);
			this.X0Y0_根_凸1CP = new ColorP(this.X0Y0_根_凸1, this.根_凸1CD, DisUnit, true);
			this.X0Y0_先_先CP = new ColorP(this.X0Y0_先_先, this.先_先CD, DisUnit, true);
			this.X0Y0_先_凸1CP = new ColorP(this.X0Y0_先_凸1, this.先_凸1CD, DisUnit, true);
			this.X0Y0_先_凸2CP = new ColorP(this.X0Y0_先_凸2, this.先_凸2CD, DisUnit, true);
			this.X0Y0_先_凸3CP = new ColorP(this.X0Y0_先_凸3, this.先_凸3CD, DisUnit, true);
			this.X0Y0_先_凸4CP = new ColorP(this.X0Y0_先_凸4, this.先_凸4CD, DisUnit, true);
			this.X0Y0_先_凸5CP = new ColorP(this.X0Y0_先_凸5, this.先_凸5CD, DisUnit, true);
			this.X0Y1_根_根CP = new ColorP(this.X0Y1_根_根, this.根_根CD, DisUnit, true);
			this.X0Y1_根_折線1CP = new ColorP(this.X0Y1_根_折線1, this.根_折線1CD, DisUnit, true);
			this.X0Y1_根_折線2CP = new ColorP(this.X0Y1_根_折線2, this.根_折線2CD, DisUnit, true);
			this.X0Y1_根_凸6CP = new ColorP(this.X0Y1_根_凸6, this.根_凸6CD, DisUnit, true);
			this.X0Y1_根_凸4CP = new ColorP(this.X0Y1_根_凸4, this.根_凸4CD, DisUnit, true);
			this.X0Y1_根_凸3CP = new ColorP(this.X0Y1_根_凸3, this.根_凸3CD, DisUnit, true);
			this.X0Y1_根_凸2CP = new ColorP(this.X0Y1_根_凸2, this.根_凸2CD, DisUnit, true);
			this.X0Y1_根_凸1CP = new ColorP(this.X0Y1_根_凸1, this.根_凸1CD, DisUnit, true);
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
			}
		}

		public bool 根_根_表示
		{
			get
			{
				return this.X0Y0_根_根.Dra;
			}
			set
			{
				this.X0Y0_根_根.Dra = value;
				this.X0Y1_根_根.Dra = value;
				this.X0Y0_根_根.Hit = value;
				this.X0Y1_根_根.Hit = value;
			}
		}

		public bool 根_凸6_表示
		{
			get
			{
				return this.X0Y0_根_凸6.Dra;
			}
			set
			{
				this.X0Y0_根_凸6.Dra = value;
				this.X0Y1_根_凸6.Dra = value;
				this.X0Y0_根_凸6.Hit = value;
				this.X0Y1_根_凸6.Hit = value;
			}
		}

		public bool 根_凸5_表示
		{
			get
			{
				return this.X0Y0_根_凸5.Dra;
			}
			set
			{
				this.X0Y0_根_凸5.Dra = value;
				this.X0Y0_根_凸5.Hit = value;
			}
		}

		public bool 根_凸4_表示
		{
			get
			{
				return this.X0Y0_根_凸4.Dra;
			}
			set
			{
				this.X0Y0_根_凸4.Dra = value;
				this.X0Y1_根_凸4.Dra = value;
				this.X0Y0_根_凸4.Hit = value;
				this.X0Y1_根_凸4.Hit = value;
			}
		}

		public bool 根_凸3_表示
		{
			get
			{
				return this.X0Y0_根_凸3.Dra;
			}
			set
			{
				this.X0Y0_根_凸3.Dra = value;
				this.X0Y1_根_凸3.Dra = value;
				this.X0Y0_根_凸3.Hit = value;
				this.X0Y1_根_凸3.Hit = value;
			}
		}

		public bool 根_凸2_表示
		{
			get
			{
				return this.X0Y0_根_凸2.Dra;
			}
			set
			{
				this.X0Y0_根_凸2.Dra = value;
				this.X0Y1_根_凸2.Dra = value;
				this.X0Y0_根_凸2.Hit = value;
				this.X0Y1_根_凸2.Hit = value;
			}
		}

		public bool 根_凸1_表示
		{
			get
			{
				return this.X0Y0_根_凸1.Dra;
			}
			set
			{
				this.X0Y0_根_凸1.Dra = value;
				this.X0Y1_根_凸1.Dra = value;
				this.X0Y0_根_凸1.Hit = value;
				this.X0Y1_根_凸1.Hit = value;
			}
		}

		public bool 先_先_表示
		{
			get
			{
				return this.X0Y0_先_先.Dra;
			}
			set
			{
				this.X0Y0_先_先.Dra = value;
				this.X0Y0_先_先.Hit = value;
			}
		}

		public bool 先_凸1_表示
		{
			get
			{
				return this.X0Y0_先_凸1.Dra;
			}
			set
			{
				this.X0Y0_先_凸1.Dra = value;
				this.X0Y0_先_凸1.Hit = value;
			}
		}

		public bool 先_凸2_表示
		{
			get
			{
				return this.X0Y0_先_凸2.Dra;
			}
			set
			{
				this.X0Y0_先_凸2.Dra = value;
				this.X0Y0_先_凸2.Hit = value;
			}
		}

		public bool 先_凸3_表示
		{
			get
			{
				return this.X0Y0_先_凸3.Dra;
			}
			set
			{
				this.X0Y0_先_凸3.Dra = value;
				this.X0Y0_先_凸3.Hit = value;
			}
		}

		public bool 先_凸4_表示
		{
			get
			{
				return this.X0Y0_先_凸4.Dra;
			}
			set
			{
				this.X0Y0_先_凸4.Dra = value;
				this.X0Y0_先_凸4.Hit = value;
			}
		}

		public bool 先_凸5_表示
		{
			get
			{
				return this.X0Y0_先_凸5.Dra;
			}
			set
			{
				this.X0Y0_先_凸5.Dra = value;
				this.X0Y0_先_凸5.Hit = value;
			}
		}

		public bool 根_折線1_表示
		{
			get
			{
				return this.X0Y1_根_折線1.Dra;
			}
			set
			{
				this.X0Y1_根_折線1.Dra = value;
				this.X0Y1_根_折線1.Hit = value;
			}
		}

		public bool 根_折線2_表示
		{
			get
			{
				return this.X0Y1_根_折線2.Dra;
			}
			set
			{
				this.X0Y1_根_折線2.Dra = value;
				this.X0Y1_根_折線2.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.根_根_表示;
			}
			set
			{
				this.根_根_表示 = value;
				this.根_凸6_表示 = value;
				this.根_凸5_表示 = value;
				this.根_凸4_表示 = value;
				this.根_凸3_表示 = value;
				this.根_凸2_表示 = value;
				this.根_凸1_表示 = value;
				this.先_先_表示 = value;
				this.先_凸1_表示 = value;
				this.先_凸2_表示 = value;
				this.先_凸3_表示 = value;
				this.先_凸4_表示 = value;
				this.先_凸5_表示 = value;
				this.根_折線1_表示 = value;
				this.根_折線2_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.根_根CD.不透明度;
			}
			set
			{
				this.根_根CD.不透明度 = value;
				this.根_凸6CD.不透明度 = value;
				this.根_凸5CD.不透明度 = value;
				this.根_凸4CD.不透明度 = value;
				this.根_凸3CD.不透明度 = value;
				this.根_凸2CD.不透明度 = value;
				this.根_凸1CD.不透明度 = value;
				this.先_先CD.不透明度 = value;
				this.先_凸1CD.不透明度 = value;
				this.先_凸2CD.不透明度 = value;
				this.先_凸3CD.不透明度 = value;
				this.先_凸4CD.不透明度 = value;
				this.先_凸5CD.不透明度 = value;
				this.根_折線1CD.不透明度 = value;
				this.根_折線2CD.不透明度 = value;
			}
		}

		public override void 根描画(Are Are)
		{
			if (this.本体.IndexY == 0)
			{
				Are.Draw(this.X0Y0_根_根);
				Are.Draw(this.X0Y0_根_凸6);
				Are.Draw(this.X0Y0_根_凸5);
				Are.Draw(this.X0Y0_根_凸4);
				Are.Draw(this.X0Y0_根_凸3);
				Are.Draw(this.X0Y0_根_凸2);
				Are.Draw(this.X0Y0_根_凸1);
				return;
			}
			Are.Draw(this.X0Y1_根_根);
			Are.Draw(this.X0Y1_根_折線1);
			Are.Draw(this.X0Y1_根_折線2);
			Are.Draw(this.X0Y1_根_凸6);
			Are.Draw(this.X0Y1_根_凸4);
			Are.Draw(this.X0Y1_根_凸3);
			Are.Draw(this.X0Y1_根_凸2);
			Are.Draw(this.X0Y1_根_凸1);
		}

		public override void 先描画(Are Are)
		{
			if (this.本体.IndexY == 0)
			{
				Are.Draw(this.X0Y0_先_先);
				Are.Draw(this.X0Y0_先_凸1);
				Are.Draw(this.X0Y0_先_凸2);
				Are.Draw(this.X0Y0_先_凸3);
				Are.Draw(this.X0Y0_先_凸4);
				Are.Draw(this.X0Y0_先_凸5);
			}
		}

		public override void 色更新()
		{
			if (this.本体.IndexY == 0)
			{
				this.X0Y0_根_根CP.Update();
				this.X0Y0_根_凸6CP.Update();
				this.X0Y0_根_凸5CP.Update();
				this.X0Y0_根_凸4CP.Update();
				this.X0Y0_根_凸3CP.Update();
				this.X0Y0_根_凸2CP.Update();
				this.X0Y0_根_凸1CP.Update();
				this.X0Y0_先_先CP.Update();
				this.X0Y0_先_凸1CP.Update();
				this.X0Y0_先_凸2CP.Update();
				this.X0Y0_先_凸3CP.Update();
				this.X0Y0_先_凸4CP.Update();
				this.X0Y0_先_凸5CP.Update();
				return;
			}
			this.X0Y1_根_根CP.Update();
			this.X0Y1_根_折線1CP.Update();
			this.X0Y1_根_折線2CP.Update();
			this.X0Y1_根_凸6CP.Update();
			this.X0Y1_根_凸4CP.Update();
			this.X0Y1_根_凸3CP.Update();
			this.X0Y1_根_凸2CP.Update();
			this.X0Y1_根_凸1CP.Update();
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
			this.根_根CD = new ColorD(ref Col.Black, ref 体配色.角0O);
			this.根_凸6CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.根_凸5CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.根_凸4CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.根_凸3CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.根_凸2CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.根_凸1CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.先_先CD = new ColorD(ref Col.Black, ref 体配色.角0O);
			this.先_凸1CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.先_凸2CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.先_凸3CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.先_凸4CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.先_凸5CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.根_折線1CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.根_折線2CD = new ColorD(ref Col.Black, ref Color2.Empty);
		}

		private void 配色T0(体配色 体配色)
		{
			this.根_根CD = new ColorD(ref Col.Black, ref 体配色.角0O);
			this.根_凸6CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.根_凸5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.根_凸4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.根_凸3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.根_凸2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.根_凸1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.先_先CD = new ColorD(ref Col.Black, ref 体配色.角0O);
			this.先_凸1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.先_凸2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.先_凸3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.先_凸4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.先_凸5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.根_折線1CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.根_折線2CD = new ColorD(ref Col.Black, ref Color2.Empty);
		}

		private void 配色T1(体配色 体配色)
		{
			this.根_根CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.根_凸6CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.根_凸5CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.根_凸4CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.根_凸3CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.根_凸2CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.根_凸1CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.先_先CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.先_凸1CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.先_凸2CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.先_凸3CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.先_凸4CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.先_凸5CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.根_折線1CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.根_折線2CD = new ColorD(ref Col.Black, ref Color2.Empty);
		}

		public Par X0Y0_根_根;

		public Par X0Y0_根_凸6;

		public Par X0Y0_根_凸5;

		public Par X0Y0_根_凸4;

		public Par X0Y0_根_凸3;

		public Par X0Y0_根_凸2;

		public Par X0Y0_根_凸1;

		public Par X0Y0_先_先;

		public Par X0Y0_先_凸1;

		public Par X0Y0_先_凸2;

		public Par X0Y0_先_凸3;

		public Par X0Y0_先_凸4;

		public Par X0Y0_先_凸5;

		public Par X0Y1_根_根;

		public Par X0Y1_根_折線1;

		public Par X0Y1_根_折線2;

		public Par X0Y1_根_凸6;

		public Par X0Y1_根_凸4;

		public Par X0Y1_根_凸3;

		public Par X0Y1_根_凸2;

		public Par X0Y1_根_凸1;

		public ColorD 根_根CD;

		public ColorD 根_凸6CD;

		public ColorD 根_凸5CD;

		public ColorD 根_凸4CD;

		public ColorD 根_凸3CD;

		public ColorD 根_凸2CD;

		public ColorD 根_凸1CD;

		public ColorD 先_先CD;

		public ColorD 先_凸1CD;

		public ColorD 先_凸2CD;

		public ColorD 先_凸3CD;

		public ColorD 先_凸4CD;

		public ColorD 先_凸5CD;

		public ColorD 根_折線1CD;

		public ColorD 根_折線2CD;

		public ColorP X0Y0_根_根CP;

		public ColorP X0Y0_根_凸6CP;

		public ColorP X0Y0_根_凸5CP;

		public ColorP X0Y0_根_凸4CP;

		public ColorP X0Y0_根_凸3CP;

		public ColorP X0Y0_根_凸2CP;

		public ColorP X0Y0_根_凸1CP;

		public ColorP X0Y0_先_先CP;

		public ColorP X0Y0_先_凸1CP;

		public ColorP X0Y0_先_凸2CP;

		public ColorP X0Y0_先_凸3CP;

		public ColorP X0Y0_先_凸4CP;

		public ColorP X0Y0_先_凸5CP;

		public ColorP X0Y1_根_根CP;

		public ColorP X0Y1_根_折線1CP;

		public ColorP X0Y1_根_折線2CP;

		public ColorP X0Y1_根_凸6CP;

		public ColorP X0Y1_根_凸4CP;

		public ColorP X0Y1_根_凸3CP;

		public ColorP X0Y1_根_凸2CP;

		public ColorP X0Y1_根_凸1CP;
	}
}
