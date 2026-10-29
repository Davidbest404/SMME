using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 角2_鬼 : 角2
	{
		public 角2_鬼(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 角2_鬼D e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif(Sta.肢左["角"][8]);
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_根 = pars["根"].ToPar();
			this.X0Y0_線1 = pars["線1"].ToPar();
			this.X0Y0_線2 = pars["線2"].ToPar();
			this.X0Y0_線3 = pars["線3"].ToPar();
			this.X0Y0_線4 = pars["線4"].ToPar();
			this.X0Y0_線5 = pars["線5"].ToPar();
			this.X0Y0_線6 = pars["線6"].ToPar();
			pars = this.本体[0][1];
			this.X0Y1_根 = pars["根"].ToPar();
			this.X0Y1_折線1 = pars["折線1"].ToPar();
			this.X0Y1_折線2 = pars["折線2"].ToPar();
			this.X0Y1_線1 = pars["線1"].ToPar();
			this.X0Y1_線2 = pars["線2"].ToPar();
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
			this.線1_表示 = e.線1_表示;
			this.線2_表示 = e.線2_表示;
			this.線3_表示 = e.線3_表示;
			this.線4_表示 = e.線4_表示;
			this.線5_表示 = e.線5_表示;
			this.線6_表示 = e.線6_表示;
			this.折線1_表示 = e.折線1_表示;
			this.折線2_表示 = e.折線2_表示;
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
			this.X0Y0_線1CP = new ColorP(this.X0Y0_線1, this.線1CD, DisUnit, false);
			this.X0Y0_線2CP = new ColorP(this.X0Y0_線2, this.線2CD, DisUnit, false);
			this.X0Y0_線3CP = new ColorP(this.X0Y0_線3, this.線3CD, DisUnit, false);
			this.X0Y0_線4CP = new ColorP(this.X0Y0_線4, this.線4CD, DisUnit, false);
			this.X0Y0_線5CP = new ColorP(this.X0Y0_線5, this.線5CD, DisUnit, false);
			this.X0Y0_線6CP = new ColorP(this.X0Y0_線6, this.線6CD, DisUnit, false);
			this.X0Y1_根CP = new ColorP(this.X0Y1_根, this.根CD, DisUnit, true);
			this.X0Y1_折線1CP = new ColorP(this.X0Y1_折線1, this.折線1CD, DisUnit, true);
			this.X0Y1_折線2CP = new ColorP(this.X0Y1_折線2, this.折線2CD, DisUnit, true);
			this.X0Y1_線1CP = new ColorP(this.X0Y1_線1, this.線1CD, DisUnit, false);
			this.X0Y1_線2CP = new ColorP(this.X0Y1_線2, this.線2CD, DisUnit, false);
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

		public bool 線1_表示
		{
			get
			{
				return this.X0Y0_線1.Dra;
			}
			set
			{
				this.X0Y0_線1.Dra = value;
				this.X0Y1_線1.Dra = value;
				this.X0Y0_線1.Hit = value;
				this.X0Y1_線1.Hit = value;
			}
		}

		public bool 線2_表示
		{
			get
			{
				return this.X0Y0_線2.Dra;
			}
			set
			{
				this.X0Y0_線2.Dra = value;
				this.X0Y1_線2.Dra = value;
				this.X0Y0_線2.Hit = value;
				this.X0Y1_線2.Hit = value;
			}
		}

		public bool 線3_表示
		{
			get
			{
				return this.X0Y0_線3.Dra;
			}
			set
			{
				this.X0Y0_線3.Dra = value;
				this.X0Y0_線3.Hit = value;
			}
		}

		public bool 線4_表示
		{
			get
			{
				return this.X0Y0_線4.Dra;
			}
			set
			{
				this.X0Y0_線4.Dra = value;
				this.X0Y0_線4.Hit = value;
			}
		}

		public bool 線5_表示
		{
			get
			{
				return this.X0Y0_線5.Dra;
			}
			set
			{
				this.X0Y0_線5.Dra = value;
				this.X0Y0_線5.Hit = value;
			}
		}

		public bool 線6_表示
		{
			get
			{
				return this.X0Y0_線6.Dra;
			}
			set
			{
				this.X0Y0_線6.Dra = value;
				this.X0Y0_線6.Hit = value;
			}
		}

		public bool 折線1_表示
		{
			get
			{
				return this.X0Y1_折線1.Dra;
			}
			set
			{
				this.X0Y1_折線1.Dra = value;
				this.X0Y1_折線1.Hit = value;
			}
		}

		public bool 折線2_表示
		{
			get
			{
				return this.X0Y1_折線2.Dra;
			}
			set
			{
				this.X0Y1_折線2.Dra = value;
				this.X0Y1_折線2.Hit = value;
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
				this.線1_表示 = value;
				this.線2_表示 = value;
				this.線3_表示 = value;
				this.線4_表示 = value;
				this.線5_表示 = value;
				this.線6_表示 = value;
				this.折線1_表示 = value;
				this.折線2_表示 = value;
			}
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
				this.線1CD.不透明度 = value;
				this.線2CD.不透明度 = value;
				this.線3CD.不透明度 = value;
				this.線4CD.不透明度 = value;
				this.線5CD.不透明度 = value;
				this.線6CD.不透明度 = value;
				this.折線1CD.不透明度 = value;
				this.折線2CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			double num = this.右 ? -1.0 : 1.0;
			this.X0Y0_根.AngleBase = num * -38.0;
			this.X0Y1_根.AngleBase = num * -38.0;
			this.本体.JoinPAall();
		}

		public override void 根描画(Are Are)
		{
		}

		public override void 先描画(Are Are)
		{
			this.本体.Draw(Are);
		}

		public void SetBasePoint()
		{
			if (this.接続情報 != 接続情報.基髪_頭頂左_接続 && this.接続情報 != 接続情報.基髪_頭頂右_接続)
			{
				this.X0Y0_根.BasePointBase = this.X0Y0_根.JP[0].Joint;
				this.X0Y1_根.BasePointBase = this.X0Y1_根.JP[0].Joint;
			}
		}

		public override void 色更新()
		{
			if (this.本体.IndexY == 0)
			{
				this.X0Y0_根CP.Update();
				this.X0Y0_線1CP.Update();
				this.X0Y0_線2CP.Update();
				this.X0Y0_線3CP.Update();
				this.X0Y0_線4CP.Update();
				this.X0Y0_線5CP.Update();
				this.X0Y0_線6CP.Update();
				return;
			}
			this.X0Y1_根CP.Update();
			this.X0Y1_折線1CP.Update();
			this.X0Y1_折線2CP.Update();
			this.X0Y1_線1CP.Update();
			this.X0Y1_線2CP.Update();
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
			this.根CD = new ColorD(ref Col.Black, ref 体配色.角0O);
			this.線1CD = new ColorD(ref 体配色.角1O.Col2, ref Color2.Empty);
			this.線2CD = new ColorD(ref 体配色.角1O.Col2, ref Color2.Empty);
			this.線3CD = new ColorD(ref 体配色.角1O.Col2, ref Color2.Empty);
			this.線4CD = new ColorD(ref 体配色.角1O.Col2, ref Color2.Empty);
			this.線5CD = new ColorD(ref 体配色.角1O.Col2, ref Color2.Empty);
			this.線6CD = new ColorD(ref 体配色.角1O.Col2, ref Color2.Empty);
			this.折線1CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.折線2CD = new ColorD(ref Col.Black, ref Color2.Empty);
		}

		private void 配色T0(体配色 体配色)
		{
			this.根CD = new ColorD(ref Col.Black, ref 体配色.角0O);
			this.線1CD = new ColorD(ref 体配色.刺青O.Col2, ref Color2.Empty);
			this.線2CD = new ColorD(ref 体配色.刺青O.Col2, ref Color2.Empty);
			this.線3CD = new ColorD(ref 体配色.刺青O.Col2, ref Color2.Empty);
			this.線4CD = new ColorD(ref 体配色.刺青O.Col2, ref Color2.Empty);
			this.線5CD = new ColorD(ref 体配色.刺青O.Col2, ref Color2.Empty);
			this.線6CD = new ColorD(ref 体配色.刺青O.Col2, ref Color2.Empty);
			this.折線1CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.折線2CD = new ColorD(ref Col.Black, ref Color2.Empty);
		}

		private void 配色T1(体配色 体配色)
		{
			this.根CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.線1CD = new ColorD(ref 体配色.角1O.Col2, ref Color2.Empty);
			this.線2CD = new ColorD(ref 体配色.角1O.Col2, ref Color2.Empty);
			this.線3CD = new ColorD(ref 体配色.角1O.Col2, ref Color2.Empty);
			this.線4CD = new ColorD(ref 体配色.角1O.Col2, ref Color2.Empty);
			this.線5CD = new ColorD(ref 体配色.角1O.Col2, ref Color2.Empty);
			this.線6CD = new ColorD(ref 体配色.角1O.Col2, ref Color2.Empty);
			this.折線1CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.折線2CD = new ColorD(ref Col.Black, ref Color2.Empty);
		}

		public Par X0Y0_根;

		public Par X0Y0_線1;

		public Par X0Y0_線2;

		public Par X0Y0_線3;

		public Par X0Y0_線4;

		public Par X0Y0_線5;

		public Par X0Y0_線6;

		public Par X0Y1_根;

		public Par X0Y1_折線1;

		public Par X0Y1_折線2;

		public Par X0Y1_線1;

		public Par X0Y1_線2;

		public ColorD 根CD;

		public ColorD 線1CD;

		public ColorD 線2CD;

		public ColorD 線3CD;

		public ColorD 線4CD;

		public ColorD 線5CD;

		public ColorD 線6CD;

		public ColorD 折線1CD;

		public ColorD 折線2CD;

		public ColorP X0Y0_根CP;

		public ColorP X0Y0_線1CP;

		public ColorP X0Y0_線2CP;

		public ColorP X0Y0_線3CP;

		public ColorP X0Y0_線4CP;

		public ColorP X0Y0_線5CP;

		public ColorP X0Y0_線6CP;

		public ColorP X0Y1_根CP;

		public ColorP X0Y1_折線1CP;

		public ColorP X0Y1_折線2CP;

		public ColorP X0Y1_線1CP;

		public ColorP X0Y1_線2CP;
	}
}
