using System;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class ボテ腹_獣 : ボテ腹
	{
		public ボテ腹_獣(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, ボテ腹_獣D e)
		{
			ボテ腹_獣.<>c__DisplayClass22_0 CS$<>8__locals1 = new ボテ腹_獣.<>c__DisplayClass22_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.半身["四足ボテ腹"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_腹 = pars["腹"].ToPar();
			this.X0Y0_臍 = pars["臍"].ToPar();
			pars = this.本体[0][1];
			this.X0Y1_腹 = pars["腹"].ToPar();
			this.X0Y1_臍 = pars["臍"].ToPar();
			pars = this.本体[0][2];
			this.X0Y2_腹 = pars["腹"].ToPar();
			this.X0Y2_臍 = pars["臍"].ToPar();
			pars = this.本体[0][3];
			this.X0Y3_腹 = pars["腹"].ToPar();
			this.X0Y3_臍 = pars["臍"].ToPar();
			pars = this.本体[0][4];
			this.X0Y4_腹 = pars["腹"].ToPar();
			this.X0Y4_臍 = pars["臍"].ToPar();
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
			this.腹_表示 = e.腹_表示;
			this.臍_表示 = e.臍_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.腹板_接続.Count > 0)
			{
				Ele f;
				this.腹板_接続 = e.腹板_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.ボテ腹_獣_腹板_接続;
					f.接続(CS$<>8__locals1.<>4__this.腹板_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_腹CP = new ColorP(this.X0Y0_腹, this.腹CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_臍CP = new ColorP(this.X0Y0_臍, this.臍CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y1_腹CP = new ColorP(this.X0Y1_腹, this.腹CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_臍CP = new ColorP(this.X0Y1_臍, this.臍CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y2_腹CP = new ColorP(this.X0Y2_腹, this.腹CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_臍CP = new ColorP(this.X0Y2_臍, this.臍CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y3_腹CP = new ColorP(this.X0Y3_腹, this.腹CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_臍CP = new ColorP(this.X0Y3_臍, this.臍CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y4_腹CP = new ColorP(this.X0Y4_腹, this.腹CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_臍CP = new ColorP(this.X0Y4_臍, this.臍CD, CS$<>8__locals1.DisUnit, false);
			this.濃度 = e.濃度;
			this.X0Y0_臍.BasePointBase = new Vector2D(this.X0Y0_臍.BasePointBase.X, 0.360579157918298);
			this.X0Y1_臍.BasePointBase = new Vector2D(this.X0Y1_臍.BasePointBase.X, 0.360579157918298);
			this.X0Y2_臍.BasePointBase = new Vector2D(this.X0Y2_臍.BasePointBase.X, 0.360579157918298);
			this.X0Y3_臍.BasePointBase = new Vector2D(this.X0Y3_臍.BasePointBase.X, 0.360579157918298);
			this.X0Y4_臍.BasePointBase = new Vector2D(this.X0Y4_臍.BasePointBase.X, 0.360579157918298);
			double num = 1.5;
			this.X0Y0_臍.SizeBase *= num;
			this.X0Y1_臍.SizeBase *= num;
			this.X0Y2_臍.SizeBase *= num;
			this.X0Y3_臍.SizeBase *= num;
			this.X0Y4_臍.SizeBase *= num;
			num = 0.6;
			this.X0Y0_臍.SizeXBase *= num;
			this.X0Y1_臍.SizeXBase *= num;
			this.X0Y2_臍.SizeXBase *= num;
			this.X0Y3_臍.SizeXBase *= num;
			this.X0Y4_臍.SizeXBase *= num;
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

		public bool 腹_表示
		{
			get
			{
				return this.X0Y0_腹.Dra;
			}
			set
			{
				this.X0Y0_腹.Dra = value;
				this.X0Y1_腹.Dra = value;
				this.X0Y2_腹.Dra = value;
				this.X0Y3_腹.Dra = value;
				this.X0Y4_腹.Dra = value;
				this.X0Y0_腹.Hit = value;
				this.X0Y1_腹.Hit = value;
				this.X0Y2_腹.Hit = value;
				this.X0Y3_腹.Hit = value;
				this.X0Y4_腹.Hit = value;
			}
		}

		public bool 臍_表示
		{
			get
			{
				return this.X0Y0_臍.Dra;
			}
			set
			{
				this.X0Y0_臍.Dra = value;
				this.X0Y1_臍.Dra = value;
				this.X0Y2_臍.Dra = value;
				this.X0Y3_臍.Dra = value;
				this.X0Y4_臍.Dra = value;
				this.X0Y0_臍.Hit = value;
				this.X0Y1_臍.Hit = value;
				this.X0Y2_臍.Hit = value;
				this.X0Y3_臍.Hit = value;
				this.X0Y4_臍.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.腹_表示;
			}
			set
			{
				this.腹_表示 = value;
				this.臍_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.腹CD.不透明度;
			}
			set
			{
				this.腹CD.不透明度 = value;
				this.臍CD.不透明度 = value;
			}
		}

		public JointS 腹板_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_腹, 0);
			}
		}

		public override void 色更新()
		{
			switch (this.本体.IndexY)
			{
			case 0:
				this.X0Y0_腹CP.Update();
				this.X0Y0_臍CP.Update();
				return;
			case 1:
				this.X0Y1_腹CP.Update();
				this.X0Y1_臍CP.Update();
				return;
			case 2:
				this.X0Y2_腹CP.Update();
				this.X0Y2_臍CP.Update();
				return;
			case 3:
				this.X0Y3_腹CP.Update();
				this.X0Y3_臍CP.Update();
				return;
			default:
				this.X0Y4_腹CP.Update();
				this.X0Y4_臍CP.Update();
				return;
			}
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.腹CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.臍CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
		}

		public Par X0Y0_腹;

		public Par X0Y0_臍;

		public Par X0Y1_腹;

		public Par X0Y1_臍;

		public Par X0Y2_腹;

		public Par X0Y2_臍;

		public Par X0Y3_腹;

		public Par X0Y3_臍;

		public Par X0Y4_腹;

		public Par X0Y4_臍;

		public ColorD 腹CD;

		public ColorD 臍CD;

		public ColorP X0Y0_腹CP;

		public ColorP X0Y0_臍CP;

		public ColorP X0Y1_腹CP;

		public ColorP X0Y1_臍CP;

		public ColorP X0Y2_腹CP;

		public ColorP X0Y2_臍CP;

		public ColorP X0Y3_腹CP;

		public ColorP X0Y3_臍CP;

		public ColorP X0Y4_腹CP;

		public ColorP X0Y4_臍CP;

		public Ele[] 腹板_接続;
	}
}
