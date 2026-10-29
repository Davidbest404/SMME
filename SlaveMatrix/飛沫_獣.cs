using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 飛沫_獣 : 飛沫
	{
		public 飛沫_獣(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 飛沫_獣D e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.性器付["四足飛沫"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_飛沫基 = pars["飛沫基"].ToPar();
			this.X0Y0_雫1 = pars["雫1"].ToPar();
			this.X0Y0_雫2 = pars["雫2"].ToPar();
			this.X0Y0_雫3 = pars["雫3"].ToPar();
			this.X0Y0_雫4 = pars["雫4"].ToPar();
			this.X0Y0_雫5 = pars["雫5"].ToPar();
			this.X0Y0_雫6 = pars["雫6"].ToPar();
			this.X0Y0_雫7 = pars["雫7"].ToPar();
			this.X0Y0_雫8 = pars["雫8"].ToPar();
			this.X0Y0_雫9 = pars["雫9"].ToPar();
			this.X0Y0_雫10 = pars["雫10"].ToPar();
			pars = this.本体[0][1];
			this.X0Y1_飛沫基 = pars["飛沫基"].ToPar();
			this.X0Y1_雫1 = pars["雫1"].ToPar();
			this.X0Y1_雫2 = pars["雫2"].ToPar();
			this.X0Y1_雫3 = pars["雫3"].ToPar();
			this.X0Y1_雫4 = pars["雫4"].ToPar();
			this.X0Y1_雫5 = pars["雫5"].ToPar();
			this.X0Y1_雫6 = pars["雫6"].ToPar();
			this.X0Y1_雫7 = pars["雫7"].ToPar();
			this.X0Y1_雫8 = pars["雫8"].ToPar();
			this.X0Y1_雫9 = pars["雫9"].ToPar();
			this.X0Y1_雫10 = pars["雫10"].ToPar();
			pars = this.本体[0][2];
			this.X0Y2_飛沫基 = pars["飛沫基"].ToPar();
			this.X0Y2_雫1 = pars["雫1"].ToPar();
			this.X0Y2_雫2 = pars["雫2"].ToPar();
			this.X0Y2_雫3 = pars["雫3"].ToPar();
			this.X0Y2_雫4 = pars["雫4"].ToPar();
			this.X0Y2_雫5 = pars["雫5"].ToPar();
			this.X0Y2_雫6 = pars["雫6"].ToPar();
			this.X0Y2_雫7 = pars["雫7"].ToPar();
			this.X0Y2_雫8 = pars["雫8"].ToPar();
			this.X0Y2_雫9 = pars["雫9"].ToPar();
			this.X0Y2_雫10 = pars["雫10"].ToPar();
			pars = this.本体[0][3];
			this.X0Y3_飛沫基 = pars["飛沫基"].ToPar();
			this.X0Y3_雫1 = pars["雫1"].ToPar();
			this.X0Y3_雫2 = pars["雫2"].ToPar();
			this.X0Y3_雫3 = pars["雫3"].ToPar();
			this.X0Y3_雫4 = pars["雫4"].ToPar();
			this.X0Y3_雫5 = pars["雫5"].ToPar();
			this.X0Y3_雫6 = pars["雫6"].ToPar();
			this.X0Y3_雫7 = pars["雫7"].ToPar();
			this.X0Y3_雫8 = pars["雫8"].ToPar();
			this.X0Y3_雫9 = pars["雫9"].ToPar();
			this.X0Y3_雫10 = pars["雫10"].ToPar();
			pars = this.本体[0][4];
			this.X0Y4_飛沫基 = pars["飛沫基"].ToPar();
			this.X0Y4_雫1 = pars["雫1"].ToPar();
			this.X0Y4_雫2 = pars["雫2"].ToPar();
			this.X0Y4_雫3 = pars["雫3"].ToPar();
			this.X0Y4_雫4 = pars["雫4"].ToPar();
			this.X0Y4_雫5 = pars["雫5"].ToPar();
			this.X0Y4_雫6 = pars["雫6"].ToPar();
			this.X0Y4_雫7 = pars["雫7"].ToPar();
			this.X0Y4_雫8 = pars["雫8"].ToPar();
			this.X0Y4_雫9 = pars["雫9"].ToPar();
			this.X0Y4_雫10 = pars["雫10"].ToPar();
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
			this.飛沫基_表示 = e.飛沫基_表示;
			this.雫1_表示 = e.雫1_表示;
			this.雫2_表示 = e.雫2_表示;
			this.雫3_表示 = e.雫3_表示;
			this.雫4_表示 = e.雫4_表示;
			this.雫5_表示 = e.雫5_表示;
			this.雫6_表示 = e.雫6_表示;
			this.雫7_表示 = e.雫7_表示;
			this.雫8_表示 = e.雫8_表示;
			this.雫9_表示 = e.雫9_表示;
			this.雫10_表示 = e.雫10_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_飛沫基CP = new ColorP(this.X0Y0_飛沫基, this.飛沫基CD, DisUnit, true);
			this.X0Y0_雫1CP = new ColorP(this.X0Y0_雫1, this.雫1CD, DisUnit, true);
			this.X0Y0_雫2CP = new ColorP(this.X0Y0_雫2, this.雫2CD, DisUnit, true);
			this.X0Y0_雫3CP = new ColorP(this.X0Y0_雫3, this.雫3CD, DisUnit, true);
			this.X0Y0_雫4CP = new ColorP(this.X0Y0_雫4, this.雫4CD, DisUnit, true);
			this.X0Y0_雫5CP = new ColorP(this.X0Y0_雫5, this.雫5CD, DisUnit, true);
			this.X0Y0_雫6CP = new ColorP(this.X0Y0_雫6, this.雫6CD, DisUnit, true);
			this.X0Y0_雫7CP = new ColorP(this.X0Y0_雫7, this.雫7CD, DisUnit, true);
			this.X0Y0_雫8CP = new ColorP(this.X0Y0_雫8, this.雫8CD, DisUnit, true);
			this.X0Y0_雫9CP = new ColorP(this.X0Y0_雫9, this.雫9CD, DisUnit, true);
			this.X0Y0_雫10CP = new ColorP(this.X0Y0_雫10, this.雫10CD, DisUnit, true);
			this.X0Y1_飛沫基CP = new ColorP(this.X0Y1_飛沫基, this.飛沫基CD, DisUnit, true);
			this.X0Y1_雫1CP = new ColorP(this.X0Y1_雫1, this.雫1CD, DisUnit, true);
			this.X0Y1_雫2CP = new ColorP(this.X0Y1_雫2, this.雫2CD, DisUnit, true);
			this.X0Y1_雫3CP = new ColorP(this.X0Y1_雫3, this.雫3CD, DisUnit, true);
			this.X0Y1_雫4CP = new ColorP(this.X0Y1_雫4, this.雫4CD, DisUnit, true);
			this.X0Y1_雫5CP = new ColorP(this.X0Y1_雫5, this.雫5CD, DisUnit, true);
			this.X0Y1_雫6CP = new ColorP(this.X0Y1_雫6, this.雫6CD, DisUnit, true);
			this.X0Y1_雫7CP = new ColorP(this.X0Y1_雫7, this.雫7CD, DisUnit, true);
			this.X0Y1_雫8CP = new ColorP(this.X0Y1_雫8, this.雫8CD, DisUnit, true);
			this.X0Y1_雫9CP = new ColorP(this.X0Y1_雫9, this.雫9CD, DisUnit, true);
			this.X0Y1_雫10CP = new ColorP(this.X0Y1_雫10, this.雫10CD, DisUnit, true);
			this.X0Y2_飛沫基CP = new ColorP(this.X0Y2_飛沫基, this.飛沫基CD, DisUnit, true);
			this.X0Y2_雫1CP = new ColorP(this.X0Y2_雫1, this.雫1CD, DisUnit, true);
			this.X0Y2_雫2CP = new ColorP(this.X0Y2_雫2, this.雫2CD, DisUnit, true);
			this.X0Y2_雫3CP = new ColorP(this.X0Y2_雫3, this.雫3CD, DisUnit, true);
			this.X0Y2_雫4CP = new ColorP(this.X0Y2_雫4, this.雫4CD, DisUnit, true);
			this.X0Y2_雫5CP = new ColorP(this.X0Y2_雫5, this.雫5CD, DisUnit, true);
			this.X0Y2_雫6CP = new ColorP(this.X0Y2_雫6, this.雫6CD, DisUnit, true);
			this.X0Y2_雫7CP = new ColorP(this.X0Y2_雫7, this.雫7CD, DisUnit, true);
			this.X0Y2_雫8CP = new ColorP(this.X0Y2_雫8, this.雫8CD, DisUnit, true);
			this.X0Y2_雫9CP = new ColorP(this.X0Y2_雫9, this.雫9CD, DisUnit, true);
			this.X0Y2_雫10CP = new ColorP(this.X0Y2_雫10, this.雫10CD, DisUnit, true);
			this.X0Y3_飛沫基CP = new ColorP(this.X0Y3_飛沫基, this.飛沫基CD, DisUnit, true);
			this.X0Y3_雫1CP = new ColorP(this.X0Y3_雫1, this.雫1CD, DisUnit, true);
			this.X0Y3_雫2CP = new ColorP(this.X0Y3_雫2, this.雫2CD, DisUnit, true);
			this.X0Y3_雫3CP = new ColorP(this.X0Y3_雫3, this.雫3CD, DisUnit, true);
			this.X0Y3_雫4CP = new ColorP(this.X0Y3_雫4, this.雫4CD, DisUnit, true);
			this.X0Y3_雫5CP = new ColorP(this.X0Y3_雫5, this.雫5CD, DisUnit, true);
			this.X0Y3_雫6CP = new ColorP(this.X0Y3_雫6, this.雫6CD, DisUnit, true);
			this.X0Y3_雫7CP = new ColorP(this.X0Y3_雫7, this.雫7CD, DisUnit, true);
			this.X0Y3_雫8CP = new ColorP(this.X0Y3_雫8, this.雫8CD, DisUnit, true);
			this.X0Y3_雫9CP = new ColorP(this.X0Y3_雫9, this.雫9CD, DisUnit, true);
			this.X0Y3_雫10CP = new ColorP(this.X0Y3_雫10, this.雫10CD, DisUnit, true);
			this.X0Y4_飛沫基CP = new ColorP(this.X0Y4_飛沫基, this.飛沫基CD, DisUnit, true);
			this.X0Y4_雫1CP = new ColorP(this.X0Y4_雫1, this.雫1CD, DisUnit, true);
			this.X0Y4_雫2CP = new ColorP(this.X0Y4_雫2, this.雫2CD, DisUnit, true);
			this.X0Y4_雫3CP = new ColorP(this.X0Y4_雫3, this.雫3CD, DisUnit, true);
			this.X0Y4_雫4CP = new ColorP(this.X0Y4_雫4, this.雫4CD, DisUnit, true);
			this.X0Y4_雫5CP = new ColorP(this.X0Y4_雫5, this.雫5CD, DisUnit, true);
			this.X0Y4_雫6CP = new ColorP(this.X0Y4_雫6, this.雫6CD, DisUnit, true);
			this.X0Y4_雫7CP = new ColorP(this.X0Y4_雫7, this.雫7CD, DisUnit, true);
			this.X0Y4_雫8CP = new ColorP(this.X0Y4_雫8, this.雫8CD, DisUnit, true);
			this.X0Y4_雫9CP = new ColorP(this.X0Y4_雫9, this.雫9CD, DisUnit, true);
			this.X0Y4_雫10CP = new ColorP(this.X0Y4_雫10, this.雫10CD, DisUnit, true);
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

		public bool 飛沫基_表示
		{
			get
			{
				return this.X0Y0_飛沫基.Dra;
			}
			set
			{
				this.X0Y0_飛沫基.Dra = value;
				this.X0Y1_飛沫基.Dra = value;
				this.X0Y2_飛沫基.Dra = value;
				this.X0Y3_飛沫基.Dra = value;
				this.X0Y4_飛沫基.Dra = value;
				this.X0Y0_飛沫基.Hit = value;
				this.X0Y1_飛沫基.Hit = value;
				this.X0Y2_飛沫基.Hit = value;
				this.X0Y3_飛沫基.Hit = value;
				this.X0Y4_飛沫基.Hit = value;
			}
		}

		public bool 雫1_表示
		{
			get
			{
				return this.X0Y0_雫1.Dra;
			}
			set
			{
				this.X0Y0_雫1.Dra = value;
				this.X0Y1_雫1.Dra = value;
				this.X0Y2_雫1.Dra = value;
				this.X0Y3_雫1.Dra = value;
				this.X0Y4_雫1.Dra = value;
				this.X0Y0_雫1.Hit = value;
				this.X0Y1_雫1.Hit = value;
				this.X0Y2_雫1.Hit = value;
				this.X0Y3_雫1.Hit = value;
				this.X0Y4_雫1.Hit = value;
			}
		}

		public bool 雫2_表示
		{
			get
			{
				return this.X0Y0_雫2.Dra;
			}
			set
			{
				this.X0Y0_雫2.Dra = value;
				this.X0Y1_雫2.Dra = value;
				this.X0Y2_雫2.Dra = value;
				this.X0Y3_雫2.Dra = value;
				this.X0Y4_雫2.Dra = value;
				this.X0Y0_雫2.Hit = value;
				this.X0Y1_雫2.Hit = value;
				this.X0Y2_雫2.Hit = value;
				this.X0Y3_雫2.Hit = value;
				this.X0Y4_雫2.Hit = value;
			}
		}

		public bool 雫3_表示
		{
			get
			{
				return this.X0Y0_雫3.Dra;
			}
			set
			{
				this.X0Y0_雫3.Dra = value;
				this.X0Y1_雫3.Dra = value;
				this.X0Y2_雫3.Dra = value;
				this.X0Y3_雫3.Dra = value;
				this.X0Y4_雫3.Dra = value;
				this.X0Y0_雫3.Hit = value;
				this.X0Y1_雫3.Hit = value;
				this.X0Y2_雫3.Hit = value;
				this.X0Y3_雫3.Hit = value;
				this.X0Y4_雫3.Hit = value;
			}
		}

		public bool 雫4_表示
		{
			get
			{
				return this.X0Y0_雫4.Dra;
			}
			set
			{
				this.X0Y0_雫4.Dra = value;
				this.X0Y1_雫4.Dra = value;
				this.X0Y2_雫4.Dra = value;
				this.X0Y3_雫4.Dra = value;
				this.X0Y4_雫4.Dra = value;
				this.X0Y0_雫4.Hit = value;
				this.X0Y1_雫4.Hit = value;
				this.X0Y2_雫4.Hit = value;
				this.X0Y3_雫4.Hit = value;
				this.X0Y4_雫4.Hit = value;
			}
		}

		public bool 雫5_表示
		{
			get
			{
				return this.X0Y0_雫5.Dra;
			}
			set
			{
				this.X0Y0_雫5.Dra = value;
				this.X0Y1_雫5.Dra = value;
				this.X0Y2_雫5.Dra = value;
				this.X0Y3_雫5.Dra = value;
				this.X0Y4_雫5.Dra = value;
				this.X0Y0_雫5.Hit = value;
				this.X0Y1_雫5.Hit = value;
				this.X0Y2_雫5.Hit = value;
				this.X0Y3_雫5.Hit = value;
				this.X0Y4_雫5.Hit = value;
			}
		}

		public bool 雫6_表示
		{
			get
			{
				return this.X0Y0_雫6.Dra;
			}
			set
			{
				this.X0Y0_雫6.Dra = value;
				this.X0Y1_雫6.Dra = value;
				this.X0Y2_雫6.Dra = value;
				this.X0Y3_雫6.Dra = value;
				this.X0Y4_雫6.Dra = value;
				this.X0Y0_雫6.Hit = value;
				this.X0Y1_雫6.Hit = value;
				this.X0Y2_雫6.Hit = value;
				this.X0Y3_雫6.Hit = value;
				this.X0Y4_雫6.Hit = value;
			}
		}

		public bool 雫7_表示
		{
			get
			{
				return this.X0Y0_雫7.Dra;
			}
			set
			{
				this.X0Y0_雫7.Dra = value;
				this.X0Y1_雫7.Dra = value;
				this.X0Y2_雫7.Dra = value;
				this.X0Y3_雫7.Dra = value;
				this.X0Y4_雫7.Dra = value;
				this.X0Y0_雫7.Hit = value;
				this.X0Y1_雫7.Hit = value;
				this.X0Y2_雫7.Hit = value;
				this.X0Y3_雫7.Hit = value;
				this.X0Y4_雫7.Hit = value;
			}
		}

		public bool 雫8_表示
		{
			get
			{
				return this.X0Y0_雫8.Dra;
			}
			set
			{
				this.X0Y0_雫8.Dra = value;
				this.X0Y1_雫8.Dra = value;
				this.X0Y2_雫8.Dra = value;
				this.X0Y3_雫8.Dra = value;
				this.X0Y4_雫8.Dra = value;
				this.X0Y0_雫8.Hit = value;
				this.X0Y1_雫8.Hit = value;
				this.X0Y2_雫8.Hit = value;
				this.X0Y3_雫8.Hit = value;
				this.X0Y4_雫8.Hit = value;
			}
		}

		public bool 雫9_表示
		{
			get
			{
				return this.X0Y0_雫9.Dra;
			}
			set
			{
				this.X0Y0_雫9.Dra = value;
				this.X0Y1_雫9.Dra = value;
				this.X0Y2_雫9.Dra = value;
				this.X0Y3_雫9.Dra = value;
				this.X0Y4_雫9.Dra = value;
				this.X0Y0_雫9.Hit = value;
				this.X0Y1_雫9.Hit = value;
				this.X0Y2_雫9.Hit = value;
				this.X0Y3_雫9.Hit = value;
				this.X0Y4_雫9.Hit = value;
			}
		}

		public bool 雫10_表示
		{
			get
			{
				return this.X0Y0_雫10.Dra;
			}
			set
			{
				this.X0Y0_雫10.Dra = value;
				this.X0Y1_雫10.Dra = value;
				this.X0Y2_雫10.Dra = value;
				this.X0Y3_雫10.Dra = value;
				this.X0Y4_雫10.Dra = value;
				this.X0Y0_雫10.Hit = value;
				this.X0Y1_雫10.Hit = value;
				this.X0Y2_雫10.Hit = value;
				this.X0Y3_雫10.Hit = value;
				this.X0Y4_雫10.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.飛沫基_表示;
			}
			set
			{
				this.飛沫基_表示 = value;
				this.雫1_表示 = value;
				this.雫2_表示 = value;
				this.雫5_表示 = value;
				this.雫6_表示 = value;
				this.雫7_表示 = value;
				this.雫9_表示 = value;
				this.雫10_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.飛沫基CD.不透明度;
			}
			set
			{
				this.飛沫基CD.不透明度 = value;
				this.雫1CD.不透明度 = value;
				this.雫2CD.不透明度 = value;
				this.雫3CD.不透明度 = value;
				this.雫4CD.不透明度 = value;
				this.雫5CD.不透明度 = value;
				this.雫6CD.不透明度 = value;
				this.雫7CD.不透明度 = value;
				this.雫8CD.不透明度 = value;
				this.雫9CD.不透明度 = value;
				this.雫10CD.不透明度 = value;
			}
		}

		public override void 色更新()
		{
			switch (this.本体.IndexY)
			{
			case 0:
				this.X0Y0_飛沫基CP.Update();
				this.X0Y0_雫1CP.Update();
				this.X0Y0_雫2CP.Update();
				this.X0Y0_雫3CP.Update();
				this.X0Y0_雫4CP.Update();
				this.X0Y0_雫5CP.Update();
				this.X0Y0_雫6CP.Update();
				this.X0Y0_雫7CP.Update();
				this.X0Y0_雫8CP.Update();
				this.X0Y0_雫9CP.Update();
				this.X0Y0_雫10CP.Update();
				return;
			case 1:
				this.X0Y1_飛沫基CP.Update();
				this.X0Y1_雫1CP.Update();
				this.X0Y1_雫2CP.Update();
				this.X0Y1_雫3CP.Update();
				this.X0Y1_雫4CP.Update();
				this.X0Y1_雫5CP.Update();
				this.X0Y1_雫6CP.Update();
				this.X0Y1_雫7CP.Update();
				this.X0Y1_雫8CP.Update();
				this.X0Y1_雫9CP.Update();
				this.X0Y1_雫10CP.Update();
				return;
			case 2:
				this.X0Y2_飛沫基CP.Update();
				this.X0Y2_雫1CP.Update();
				this.X0Y2_雫2CP.Update();
				this.X0Y2_雫3CP.Update();
				this.X0Y2_雫4CP.Update();
				this.X0Y2_雫5CP.Update();
				this.X0Y2_雫6CP.Update();
				this.X0Y2_雫7CP.Update();
				this.X0Y2_雫8CP.Update();
				this.X0Y2_雫9CP.Update();
				this.X0Y2_雫10CP.Update();
				return;
			case 3:
				this.X0Y3_飛沫基CP.Update();
				this.X0Y3_雫1CP.Update();
				this.X0Y3_雫2CP.Update();
				this.X0Y3_雫3CP.Update();
				this.X0Y3_雫4CP.Update();
				this.X0Y3_雫5CP.Update();
				this.X0Y3_雫6CP.Update();
				this.X0Y3_雫7CP.Update();
				this.X0Y3_雫8CP.Update();
				this.X0Y3_雫9CP.Update();
				this.X0Y3_雫10CP.Update();
				return;
			default:
				this.X0Y4_飛沫基CP.Update();
				this.X0Y4_雫1CP.Update();
				this.X0Y4_雫2CP.Update();
				this.X0Y4_雫3CP.Update();
				this.X0Y4_雫4CP.Update();
				this.X0Y4_雫5CP.Update();
				this.X0Y4_雫6CP.Update();
				this.X0Y4_雫7CP.Update();
				this.X0Y4_雫8CP.Update();
				this.X0Y4_雫9CP.Update();
				this.X0Y4_雫10CP.Update();
				return;
			}
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.飛沫基CD = new ColorD(ref Col.Empty, ref Color2.Empty);
			this.雫1CD = new ColorD(ref Col.Empty, ref 体配色.体液);
			this.雫2CD = new ColorD(ref Col.Empty, ref 体配色.体液);
			this.雫3CD = new ColorD(ref Col.Empty, ref 体配色.体液);
			this.雫4CD = new ColorD(ref Col.Empty, ref 体配色.体液);
			this.雫5CD = new ColorD(ref Col.Empty, ref 体配色.体液);
			this.雫6CD = new ColorD(ref Col.Empty, ref 体配色.体液);
			this.雫7CD = new ColorD(ref Col.Empty, ref 体配色.体液);
			this.雫8CD = new ColorD(ref Col.Empty, ref 体配色.体液);
			this.雫9CD = new ColorD(ref Col.Empty, ref 体配色.体液);
			this.雫10CD = new ColorD(ref Col.Empty, ref 体配色.体液);
		}

		public Par X0Y0_飛沫基;

		public Par X0Y0_雫1;

		public Par X0Y0_雫2;

		public Par X0Y0_雫3;

		public Par X0Y0_雫4;

		public Par X0Y0_雫5;

		public Par X0Y0_雫6;

		public Par X0Y0_雫7;

		public Par X0Y0_雫8;

		public Par X0Y0_雫9;

		public Par X0Y0_雫10;

		public Par X0Y1_飛沫基;

		public Par X0Y1_雫1;

		public Par X0Y1_雫2;

		public Par X0Y1_雫3;

		public Par X0Y1_雫4;

		public Par X0Y1_雫5;

		public Par X0Y1_雫6;

		public Par X0Y1_雫7;

		public Par X0Y1_雫8;

		public Par X0Y1_雫9;

		public Par X0Y1_雫10;

		public Par X0Y2_飛沫基;

		public Par X0Y2_雫1;

		public Par X0Y2_雫2;

		public Par X0Y2_雫3;

		public Par X0Y2_雫4;

		public Par X0Y2_雫5;

		public Par X0Y2_雫6;

		public Par X0Y2_雫7;

		public Par X0Y2_雫8;

		public Par X0Y2_雫9;

		public Par X0Y2_雫10;

		public Par X0Y3_飛沫基;

		public Par X0Y3_雫1;

		public Par X0Y3_雫2;

		public Par X0Y3_雫3;

		public Par X0Y3_雫4;

		public Par X0Y3_雫5;

		public Par X0Y3_雫6;

		public Par X0Y3_雫7;

		public Par X0Y3_雫8;

		public Par X0Y3_雫9;

		public Par X0Y3_雫10;

		public Par X0Y4_飛沫基;

		public Par X0Y4_雫1;

		public Par X0Y4_雫2;

		public Par X0Y4_雫3;

		public Par X0Y4_雫4;

		public Par X0Y4_雫5;

		public Par X0Y4_雫6;

		public Par X0Y4_雫7;

		public Par X0Y4_雫8;

		public Par X0Y4_雫9;

		public Par X0Y4_雫10;

		public ColorD 飛沫基CD;

		public ColorD 雫1CD;

		public ColorD 雫2CD;

		public ColorD 雫3CD;

		public ColorD 雫4CD;

		public ColorD 雫5CD;

		public ColorD 雫6CD;

		public ColorD 雫7CD;

		public ColorD 雫8CD;

		public ColorD 雫9CD;

		public ColorD 雫10CD;

		public ColorP X0Y0_飛沫基CP;

		public ColorP X0Y0_雫1CP;

		public ColorP X0Y0_雫2CP;

		public ColorP X0Y0_雫3CP;

		public ColorP X0Y0_雫4CP;

		public ColorP X0Y0_雫5CP;

		public ColorP X0Y0_雫6CP;

		public ColorP X0Y0_雫7CP;

		public ColorP X0Y0_雫8CP;

		public ColorP X0Y0_雫9CP;

		public ColorP X0Y0_雫10CP;

		public ColorP X0Y1_飛沫基CP;

		public ColorP X0Y1_雫1CP;

		public ColorP X0Y1_雫2CP;

		public ColorP X0Y1_雫3CP;

		public ColorP X0Y1_雫4CP;

		public ColorP X0Y1_雫5CP;

		public ColorP X0Y1_雫6CP;

		public ColorP X0Y1_雫7CP;

		public ColorP X0Y1_雫8CP;

		public ColorP X0Y1_雫9CP;

		public ColorP X0Y1_雫10CP;

		public ColorP X0Y2_飛沫基CP;

		public ColorP X0Y2_雫1CP;

		public ColorP X0Y2_雫2CP;

		public ColorP X0Y2_雫3CP;

		public ColorP X0Y2_雫4CP;

		public ColorP X0Y2_雫5CP;

		public ColorP X0Y2_雫6CP;

		public ColorP X0Y2_雫7CP;

		public ColorP X0Y2_雫8CP;

		public ColorP X0Y2_雫9CP;

		public ColorP X0Y2_雫10CP;

		public ColorP X0Y3_飛沫基CP;

		public ColorP X0Y3_雫1CP;

		public ColorP X0Y3_雫2CP;

		public ColorP X0Y3_雫3CP;

		public ColorP X0Y3_雫4CP;

		public ColorP X0Y3_雫5CP;

		public ColorP X0Y3_雫6CP;

		public ColorP X0Y3_雫7CP;

		public ColorP X0Y3_雫8CP;

		public ColorP X0Y3_雫9CP;

		public ColorP X0Y3_雫10CP;

		public ColorP X0Y4_飛沫基CP;

		public ColorP X0Y4_雫1CP;

		public ColorP X0Y4_雫2CP;

		public ColorP X0Y4_雫3CP;

		public ColorP X0Y4_雫4CP;

		public ColorP X0Y4_雫5CP;

		public ColorP X0Y4_雫6CP;

		public ColorP X0Y4_雫7CP;

		public ColorP X0Y4_雫8CP;

		public ColorP X0Y4_雫9CP;

		public ColorP X0Y4_雫10CP;
	}
}
