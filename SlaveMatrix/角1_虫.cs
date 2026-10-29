using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 角1_虫 : 角1
	{
		public 角1_虫(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 角1_虫D e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif(Sta.肢中["角"][2]);
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_根 = pars["根"].ToPar();
			Pars pars2 = pars["器官左"].ToPars();
			this.X0Y0_器官左_器官1 = pars2["器官1"].ToPar();
			this.X0Y0_器官左_器官2 = pars2["器官2"].ToPar();
			pars2 = pars["器官右"].ToPars();
			this.X0Y0_器官右_器官1 = pars2["器官1"].ToPar();
			this.X0Y0_器官右_器官2 = pars2["器官2"].ToPar();
			this.X0Y0_線 = pars["線"].ToPar();
			pars = this.本体[0][1];
			this.X0Y1_根 = pars["根"].ToPar();
			pars2 = pars["器官左"].ToPars();
			this.X0Y1_器官左_器官1 = pars2["器官1"].ToPar();
			this.X0Y1_器官左_器官2 = pars2["器官2"].ToPar();
			pars2 = pars["器官右"].ToPars();
			this.X0Y1_器官右_器官1 = pars2["器官1"].ToPar();
			this.X0Y1_器官右_器官2 = pars2["器官2"].ToPar();
			this.X0Y1_線 = pars["線"].ToPar();
			this.X0Y1_折線1 = pars["折線1"].ToPar();
			this.X0Y1_折線2 = pars["折線2"].ToPar();
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
			this.器官左_器官1_表示 = e.器官左_器官1_表示;
			this.器官左_器官2_表示 = e.器官左_器官2_表示;
			this.器官右_器官1_表示 = e.器官右_器官1_表示;
			this.器官右_器官2_表示 = e.器官右_器官2_表示;
			this.線_表示 = e.線_表示;
			this.折線1_表示 = e.折線1_表示;
			this.折線2_表示 = e.折線2_表示;
			this.展開 = e.展開;
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
			this.X0Y0_器官左_器官1CP = new ColorP(this.X0Y0_器官左_器官1, this.器官左_器官1CD, DisUnit, true);
			this.X0Y0_器官左_器官2CP = new ColorP(this.X0Y0_器官左_器官2, this.器官左_器官2CD, DisUnit, true);
			this.X0Y0_器官右_器官1CP = new ColorP(this.X0Y0_器官右_器官1, this.器官右_器官1CD, DisUnit, true);
			this.X0Y0_器官右_器官2CP = new ColorP(this.X0Y0_器官右_器官2, this.器官右_器官2CD, DisUnit, true);
			this.X0Y0_線CP = new ColorP(this.X0Y0_線, this.線CD, DisUnit, true);
			this.X0Y1_根CP = new ColorP(this.X0Y1_根, this.根CD, DisUnit, true);
			this.X0Y1_器官左_器官1CP = new ColorP(this.X0Y1_器官左_器官1, this.器官左_器官1CD, DisUnit, true);
			this.X0Y1_器官左_器官2CP = new ColorP(this.X0Y1_器官左_器官2, this.器官左_器官2CD, DisUnit, true);
			this.X0Y1_器官右_器官1CP = new ColorP(this.X0Y1_器官右_器官1, this.器官右_器官1CD, DisUnit, true);
			this.X0Y1_器官右_器官2CP = new ColorP(this.X0Y1_器官右_器官2, this.器官右_器官2CD, DisUnit, true);
			this.X0Y1_線CP = new ColorP(this.X0Y1_線, this.線CD, DisUnit, true);
			this.X0Y1_折線1CP = new ColorP(this.X0Y1_折線1, this.折線1CD, DisUnit, true);
			this.X0Y1_折線2CP = new ColorP(this.X0Y1_折線2, this.折線2CD, DisUnit, true);
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

		public bool 器官左_器官1_表示
		{
			get
			{
				return this.X0Y0_器官左_器官1.Dra;
			}
			set
			{
				this.X0Y0_器官左_器官1.Dra = value;
				this.X0Y1_器官左_器官1.Dra = value;
				this.X0Y0_器官左_器官1.Hit = value;
				this.X0Y1_器官左_器官1.Hit = value;
			}
		}

		public bool 器官左_器官2_表示
		{
			get
			{
				return this.X0Y0_器官左_器官2.Dra;
			}
			set
			{
				this.X0Y0_器官左_器官2.Dra = value;
				this.X0Y1_器官左_器官2.Dra = value;
				this.X0Y0_器官左_器官2.Hit = value;
				this.X0Y1_器官左_器官2.Hit = value;
			}
		}

		public bool 器官右_器官1_表示
		{
			get
			{
				return this.X0Y0_器官右_器官1.Dra;
			}
			set
			{
				this.X0Y0_器官右_器官1.Dra = value;
				this.X0Y1_器官右_器官1.Dra = value;
				this.X0Y0_器官右_器官1.Hit = value;
				this.X0Y1_器官右_器官1.Hit = value;
			}
		}

		public bool 器官右_器官2_表示
		{
			get
			{
				return this.X0Y0_器官右_器官2.Dra;
			}
			set
			{
				this.X0Y0_器官右_器官2.Dra = value;
				this.X0Y1_器官右_器官2.Dra = value;
				this.X0Y0_器官右_器官2.Hit = value;
				this.X0Y1_器官右_器官2.Hit = value;
			}
		}

		public bool 線_表示
		{
			get
			{
				return this.X0Y0_線.Dra;
			}
			set
			{
				this.X0Y0_線.Dra = value;
				this.X0Y1_線.Dra = value;
				this.X0Y0_線.Hit = value;
				this.X0Y1_線.Hit = value;
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

		public override double 展開
		{
			set
			{
				this.位置C = new Vector2D(this.位置C.X, -0.013 * value);
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
				this.器官左_器官1_表示 = value;
				this.器官左_器官2_表示 = value;
				this.器官右_器官1_表示 = value;
				this.器官右_器官2_表示 = value;
				this.線_表示 = value;
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
				this.器官左_器官1CD.不透明度 = value;
				this.器官左_器官2CD.不透明度 = value;
				this.器官右_器官1CD.不透明度 = value;
				this.器官右_器官2CD.不透明度 = value;
				this.線CD.不透明度 = value;
				this.折線1CD.不透明度 = value;
				this.折線2CD.不透明度 = value;
			}
		}

		public override void 色更新()
		{
			if (this.本体.IndexY == 0)
			{
				this.X0Y0_根CP.Update();
				this.X0Y0_器官左_器官1CP.Update();
				this.X0Y0_器官左_器官2CP.Update();
				this.X0Y0_器官右_器官1CP.Update();
				this.X0Y0_器官右_器官2CP.Update();
				this.X0Y0_線CP.Update();
				return;
			}
			this.X0Y1_根CP.Update();
			this.X0Y1_器官左_器官1CP.Update();
			this.X0Y1_器官左_器官2CP.Update();
			this.X0Y1_器官右_器官1CP.Update();
			this.X0Y1_器官右_器官2CP.Update();
			this.X0Y1_線CP.Update();
			this.X0Y1_折線1CP.Update();
			this.X0Y1_折線2CP.Update();
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
			this.器官左_器官1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.器官左_器官2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.器官右_器官1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.器官右_器官2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.線CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.折線1CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.折線2CD = new ColorD(ref Col.Black, ref Color2.Empty);
		}

		private void 配色T0(体配色 体配色)
		{
			this.根CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.器官左_器官1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.器官左_器官2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.器官右_器官1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.器官右_器官2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.線CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.折線1CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.折線2CD = new ColorD(ref Col.Black, ref Color2.Empty);
		}

		private void 配色T1(体配色 体配色)
		{
			this.根CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.器官左_器官1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.器官左_器官2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.器官右_器官1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.器官右_器官2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.線CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.折線1CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.折線2CD = new ColorD(ref Col.Black, ref Color2.Empty);
		}

		public Par X0Y0_根;

		public Par X0Y0_器官左_器官1;

		public Par X0Y0_器官左_器官2;

		public Par X0Y0_器官右_器官1;

		public Par X0Y0_器官右_器官2;

		public Par X0Y0_線;

		public Par X0Y1_根;

		public Par X0Y1_器官左_器官1;

		public Par X0Y1_器官左_器官2;

		public Par X0Y1_器官右_器官1;

		public Par X0Y1_器官右_器官2;

		public Par X0Y1_線;

		public Par X0Y1_折線1;

		public Par X0Y1_折線2;

		public ColorD 根CD;

		public ColorD 器官左_器官1CD;

		public ColorD 器官左_器官2CD;

		public ColorD 器官右_器官1CD;

		public ColorD 器官右_器官2CD;

		public ColorD 線CD;

		public ColorD 折線1CD;

		public ColorD 折線2CD;

		public ColorP X0Y0_根CP;

		public ColorP X0Y0_器官左_器官1CP;

		public ColorP X0Y0_器官左_器官2CP;

		public ColorP X0Y0_器官右_器官1CP;

		public ColorP X0Y0_器官右_器官2CP;

		public ColorP X0Y0_線CP;

		public ColorP X0Y1_根CP;

		public ColorP X0Y1_器官左_器官1CP;

		public ColorP X0Y1_器官左_器官2CP;

		public ColorP X0Y1_器官右_器官1CP;

		public ColorP X0Y1_器官右_器官2CP;

		public ColorP X0Y1_線CP;

		public ColorP X0Y1_折線1CP;

		public ColorP X0Y1_折線2CP;
	}
}
