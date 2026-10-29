using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class ボテ腹板 : Ele
	{
		public ボテ腹板(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, ボテ腹板D e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.胴体["ボテ腹板"]);
			Pars pars = this.本体[0][0];
			Pars pars2 = pars["腹板4"].ToPars();
			this.X0Y0_腹板4_腹板 = pars2["腹板"].ToPar();
			this.X0Y0_腹板4_縦線 = pars2["縦線"].ToPar();
			pars2 = pars["腹板3"].ToPars();
			this.X0Y0_腹板3_腹板 = pars2["腹板"].ToPar();
			this.X0Y0_腹板3_縦線 = pars2["縦線"].ToPar();
			pars2 = pars["腹板2"].ToPars();
			this.X0Y0_腹板2_腹板 = pars2["腹板"].ToPar();
			this.X0Y0_腹板2_縦線 = pars2["縦線"].ToPar();
			pars2 = pars["腹板1"].ToPars();
			this.X0Y0_腹板1_腹板 = pars2["腹板"].ToPar();
			this.X0Y0_腹板1_縦線 = pars2["縦線"].ToPar();
			Pars pars3 = this.本体[0][1];
			pars2 = pars3["腹板4"].ToPars();
			this.X0Y1_腹板4_腹板 = pars2["腹板"].ToPar();
			this.X0Y1_腹板4_縦線 = pars2["縦線"].ToPar();
			pars2 = pars3["腹板3"].ToPars();
			this.X0Y1_腹板3_腹板 = pars2["腹板"].ToPar();
			this.X0Y1_腹板3_縦線 = pars2["縦線"].ToPar();
			pars2 = pars3["腹板2"].ToPars();
			this.X0Y1_腹板2_腹板 = pars2["腹板"].ToPar();
			this.X0Y1_腹板2_縦線 = pars2["縦線"].ToPar();
			pars2 = pars3["腹板1"].ToPars();
			this.X0Y1_腹板1_腹板 = pars2["腹板"].ToPar();
			this.X0Y1_腹板1_縦線 = pars2["縦線"].ToPar();
			Pars pars4 = this.本体[0][2];
			pars2 = pars4["腹板4"].ToPars();
			this.X0Y2_腹板4_腹板 = pars2["腹板"].ToPar();
			this.X0Y2_腹板4_縦線 = pars2["縦線"].ToPar();
			pars2 = pars4["腹板3"].ToPars();
			this.X0Y2_腹板3_腹板 = pars2["腹板"].ToPar();
			this.X0Y2_腹板3_縦線 = pars2["縦線"].ToPar();
			pars2 = pars4["腹板2"].ToPars();
			this.X0Y2_腹板2_腹板 = pars2["腹板"].ToPar();
			this.X0Y2_腹板2_縦線 = pars2["縦線"].ToPar();
			pars2 = pars4["腹板1"].ToPars();
			this.X0Y2_腹板1_腹板 = pars2["腹板"].ToPar();
			this.X0Y2_腹板1_縦線 = pars2["縦線"].ToPar();
			Pars pars5 = this.本体[0][3];
			pars2 = pars5["腹板4"].ToPars();
			this.X0Y3_腹板4_腹板 = pars2["腹板"].ToPar();
			this.X0Y3_腹板4_縦線 = pars2["縦線"].ToPar();
			pars2 = pars5["腹板3"].ToPars();
			this.X0Y3_腹板3_腹板 = pars2["腹板"].ToPar();
			this.X0Y3_腹板3_縦線 = pars2["縦線"].ToPar();
			pars2 = pars5["腹板2"].ToPars();
			this.X0Y3_腹板2_腹板 = pars2["腹板"].ToPar();
			this.X0Y3_腹板2_縦線 = pars2["縦線"].ToPar();
			pars2 = pars5["腹板1"].ToPars();
			this.X0Y3_腹板1_腹板 = pars2["腹板"].ToPar();
			this.X0Y3_腹板1_縦線 = pars2["縦線"].ToPar();
			Pars pars6 = this.本体[0][4];
			pars2 = pars6["腹板4"].ToPars();
			this.X0Y4_腹板4_腹板 = pars2["腹板"].ToPar();
			this.X0Y4_腹板4_縦線 = pars2["縦線"].ToPar();
			pars2 = pars6["腹板3"].ToPars();
			this.X0Y4_腹板3_腹板 = pars2["腹板"].ToPar();
			this.X0Y4_腹板3_縦線 = pars2["縦線"].ToPar();
			pars2 = pars6["腹板2"].ToPars();
			this.X0Y4_腹板2_腹板 = pars2["腹板"].ToPar();
			this.X0Y4_腹板2_縦線 = pars2["縦線"].ToPar();
			pars2 = pars6["腹板1"].ToPars();
			this.X0Y4_腹板1_腹板 = pars2["腹板"].ToPar();
			this.X0Y4_腹板1_縦線 = pars2["縦線"].ToPar();
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
			this.腹板4_腹板_表示 = e.腹板4_腹板_表示;
			this.腹板4_縦線_表示 = e.腹板4_縦線_表示;
			this.腹板3_腹板_表示 = e.腹板3_腹板_表示;
			this.腹板3_縦線_表示 = e.腹板3_縦線_表示;
			this.腹板2_腹板_表示 = e.腹板2_腹板_表示;
			this.腹板2_縦線_表示 = e.腹板2_縦線_表示;
			this.腹板1_腹板_表示 = e.腹板1_腹板_表示;
			this.腹板1_縦線_表示 = e.腹板1_縦線_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_腹板4_腹板CP = new ColorP(this.X0Y0_腹板4_腹板, this.腹板4_腹板CD, DisUnit, true);
			this.X0Y0_腹板4_縦線CP = new ColorP(this.X0Y0_腹板4_縦線, this.腹板4_縦線CD, DisUnit, true);
			this.X0Y0_腹板3_腹板CP = new ColorP(this.X0Y0_腹板3_腹板, this.腹板3_腹板CD, DisUnit, true);
			this.X0Y0_腹板3_縦線CP = new ColorP(this.X0Y0_腹板3_縦線, this.腹板3_縦線CD, DisUnit, true);
			this.X0Y0_腹板2_腹板CP = new ColorP(this.X0Y0_腹板2_腹板, this.腹板2_腹板CD, DisUnit, true);
			this.X0Y0_腹板2_縦線CP = new ColorP(this.X0Y0_腹板2_縦線, this.腹板2_縦線CD, DisUnit, true);
			this.X0Y0_腹板1_腹板CP = new ColorP(this.X0Y0_腹板1_腹板, this.腹板1_腹板CD, DisUnit, true);
			this.X0Y0_腹板1_縦線CP = new ColorP(this.X0Y0_腹板1_縦線, this.腹板1_縦線CD, DisUnit, true);
			this.X0Y1_腹板4_腹板CP = new ColorP(this.X0Y1_腹板4_腹板, this.腹板4_腹板CD, DisUnit, true);
			this.X0Y1_腹板4_縦線CP = new ColorP(this.X0Y1_腹板4_縦線, this.腹板4_縦線CD, DisUnit, true);
			this.X0Y1_腹板3_腹板CP = new ColorP(this.X0Y1_腹板3_腹板, this.腹板3_腹板CD, DisUnit, true);
			this.X0Y1_腹板3_縦線CP = new ColorP(this.X0Y1_腹板3_縦線, this.腹板3_縦線CD, DisUnit, true);
			this.X0Y1_腹板2_腹板CP = new ColorP(this.X0Y1_腹板2_腹板, this.腹板2_腹板CD, DisUnit, true);
			this.X0Y1_腹板2_縦線CP = new ColorP(this.X0Y1_腹板2_縦線, this.腹板2_縦線CD, DisUnit, true);
			this.X0Y1_腹板1_腹板CP = new ColorP(this.X0Y1_腹板1_腹板, this.腹板1_腹板CD, DisUnit, true);
			this.X0Y1_腹板1_縦線CP = new ColorP(this.X0Y1_腹板1_縦線, this.腹板1_縦線CD, DisUnit, true);
			this.X0Y2_腹板4_腹板CP = new ColorP(this.X0Y2_腹板4_腹板, this.腹板4_腹板CD, DisUnit, true);
			this.X0Y2_腹板4_縦線CP = new ColorP(this.X0Y2_腹板4_縦線, this.腹板4_縦線CD, DisUnit, true);
			this.X0Y2_腹板3_腹板CP = new ColorP(this.X0Y2_腹板3_腹板, this.腹板3_腹板CD, DisUnit, true);
			this.X0Y2_腹板3_縦線CP = new ColorP(this.X0Y2_腹板3_縦線, this.腹板3_縦線CD, DisUnit, true);
			this.X0Y2_腹板2_腹板CP = new ColorP(this.X0Y2_腹板2_腹板, this.腹板2_腹板CD, DisUnit, true);
			this.X0Y2_腹板2_縦線CP = new ColorP(this.X0Y2_腹板2_縦線, this.腹板2_縦線CD, DisUnit, true);
			this.X0Y2_腹板1_腹板CP = new ColorP(this.X0Y2_腹板1_腹板, this.腹板1_腹板CD, DisUnit, true);
			this.X0Y2_腹板1_縦線CP = new ColorP(this.X0Y2_腹板1_縦線, this.腹板1_縦線CD, DisUnit, true);
			this.X0Y3_腹板4_腹板CP = new ColorP(this.X0Y3_腹板4_腹板, this.腹板4_腹板CD, DisUnit, true);
			this.X0Y3_腹板4_縦線CP = new ColorP(this.X0Y3_腹板4_縦線, this.腹板4_縦線CD, DisUnit, true);
			this.X0Y3_腹板3_腹板CP = new ColorP(this.X0Y3_腹板3_腹板, this.腹板3_腹板CD, DisUnit, true);
			this.X0Y3_腹板3_縦線CP = new ColorP(this.X0Y3_腹板3_縦線, this.腹板3_縦線CD, DisUnit, true);
			this.X0Y3_腹板2_腹板CP = new ColorP(this.X0Y3_腹板2_腹板, this.腹板2_腹板CD, DisUnit, true);
			this.X0Y3_腹板2_縦線CP = new ColorP(this.X0Y3_腹板2_縦線, this.腹板2_縦線CD, DisUnit, true);
			this.X0Y3_腹板1_腹板CP = new ColorP(this.X0Y3_腹板1_腹板, this.腹板1_腹板CD, DisUnit, true);
			this.X0Y3_腹板1_縦線CP = new ColorP(this.X0Y3_腹板1_縦線, this.腹板1_縦線CD, DisUnit, true);
			this.X0Y4_腹板4_腹板CP = new ColorP(this.X0Y4_腹板4_腹板, this.腹板4_腹板CD, DisUnit, true);
			this.X0Y4_腹板4_縦線CP = new ColorP(this.X0Y4_腹板4_縦線, this.腹板4_縦線CD, DisUnit, true);
			this.X0Y4_腹板3_腹板CP = new ColorP(this.X0Y4_腹板3_腹板, this.腹板3_腹板CD, DisUnit, true);
			this.X0Y4_腹板3_縦線CP = new ColorP(this.X0Y4_腹板3_縦線, this.腹板3_縦線CD, DisUnit, true);
			this.X0Y4_腹板2_腹板CP = new ColorP(this.X0Y4_腹板2_腹板, this.腹板2_腹板CD, DisUnit, true);
			this.X0Y4_腹板2_縦線CP = new ColorP(this.X0Y4_腹板2_縦線, this.腹板2_縦線CD, DisUnit, true);
			this.X0Y4_腹板1_腹板CP = new ColorP(this.X0Y4_腹板1_腹板, this.腹板1_腹板CD, DisUnit, true);
			this.X0Y4_腹板1_縦線CP = new ColorP(this.X0Y4_腹板1_縦線, this.腹板1_縦線CD, DisUnit, true);
			this.濃度 = e.濃度;
			this.尺度YB = 0.95;
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

		public bool 腹板4_腹板_表示
		{
			get
			{
				return this.X0Y0_腹板4_腹板.Dra;
			}
			set
			{
				this.X0Y0_腹板4_腹板.Dra = value;
				this.X0Y1_腹板4_腹板.Dra = value;
				this.X0Y2_腹板4_腹板.Dra = value;
				this.X0Y3_腹板4_腹板.Dra = value;
				this.X0Y4_腹板4_腹板.Dra = value;
				this.X0Y0_腹板4_腹板.Hit = value;
				this.X0Y1_腹板4_腹板.Hit = value;
				this.X0Y2_腹板4_腹板.Hit = value;
				this.X0Y3_腹板4_腹板.Hit = value;
				this.X0Y4_腹板4_腹板.Hit = value;
			}
		}

		public bool 腹板4_縦線_表示
		{
			get
			{
				return this.X0Y0_腹板4_縦線.Dra;
			}
			set
			{
				this.X0Y0_腹板4_縦線.Dra = value;
				this.X0Y1_腹板4_縦線.Dra = value;
				this.X0Y2_腹板4_縦線.Dra = value;
				this.X0Y3_腹板4_縦線.Dra = value;
				this.X0Y4_腹板4_縦線.Dra = value;
				this.X0Y0_腹板4_縦線.Hit = value;
				this.X0Y1_腹板4_縦線.Hit = value;
				this.X0Y2_腹板4_縦線.Hit = value;
				this.X0Y3_腹板4_縦線.Hit = value;
				this.X0Y4_腹板4_縦線.Hit = value;
			}
		}

		public bool 腹板3_腹板_表示
		{
			get
			{
				return this.X0Y0_腹板3_腹板.Dra;
			}
			set
			{
				this.X0Y0_腹板3_腹板.Dra = value;
				this.X0Y1_腹板3_腹板.Dra = value;
				this.X0Y2_腹板3_腹板.Dra = value;
				this.X0Y3_腹板3_腹板.Dra = value;
				this.X0Y4_腹板3_腹板.Dra = value;
				this.X0Y0_腹板3_腹板.Hit = value;
				this.X0Y1_腹板3_腹板.Hit = value;
				this.X0Y2_腹板3_腹板.Hit = value;
				this.X0Y3_腹板3_腹板.Hit = value;
				this.X0Y4_腹板3_腹板.Hit = value;
			}
		}

		public bool 腹板3_縦線_表示
		{
			get
			{
				return this.X0Y0_腹板3_縦線.Dra;
			}
			set
			{
				this.X0Y0_腹板3_縦線.Dra = value;
				this.X0Y1_腹板3_縦線.Dra = value;
				this.X0Y2_腹板3_縦線.Dra = value;
				this.X0Y3_腹板3_縦線.Dra = value;
				this.X0Y4_腹板3_縦線.Dra = value;
				this.X0Y0_腹板3_縦線.Hit = value;
				this.X0Y1_腹板3_縦線.Hit = value;
				this.X0Y2_腹板3_縦線.Hit = value;
				this.X0Y3_腹板3_縦線.Hit = value;
				this.X0Y4_腹板3_縦線.Hit = value;
			}
		}

		public bool 腹板2_腹板_表示
		{
			get
			{
				return this.X0Y0_腹板2_腹板.Dra;
			}
			set
			{
				this.X0Y0_腹板2_腹板.Dra = value;
				this.X0Y1_腹板2_腹板.Dra = value;
				this.X0Y2_腹板2_腹板.Dra = value;
				this.X0Y3_腹板2_腹板.Dra = value;
				this.X0Y4_腹板2_腹板.Dra = value;
				this.X0Y0_腹板2_腹板.Hit = value;
				this.X0Y1_腹板2_腹板.Hit = value;
				this.X0Y2_腹板2_腹板.Hit = value;
				this.X0Y3_腹板2_腹板.Hit = value;
				this.X0Y4_腹板2_腹板.Hit = value;
			}
		}

		public bool 腹板2_縦線_表示
		{
			get
			{
				return this.X0Y0_腹板2_縦線.Dra;
			}
			set
			{
				this.X0Y0_腹板2_縦線.Dra = value;
				this.X0Y1_腹板2_縦線.Dra = value;
				this.X0Y2_腹板2_縦線.Dra = value;
				this.X0Y3_腹板2_縦線.Dra = value;
				this.X0Y4_腹板2_縦線.Dra = value;
				this.X0Y0_腹板2_縦線.Hit = value;
				this.X0Y1_腹板2_縦線.Hit = value;
				this.X0Y2_腹板2_縦線.Hit = value;
				this.X0Y3_腹板2_縦線.Hit = value;
				this.X0Y4_腹板2_縦線.Hit = value;
			}
		}

		public bool 腹板1_腹板_表示
		{
			get
			{
				return this.X0Y0_腹板1_腹板.Dra;
			}
			set
			{
				this.X0Y0_腹板1_腹板.Dra = value;
				this.X0Y1_腹板1_腹板.Dra = value;
				this.X0Y2_腹板1_腹板.Dra = value;
				this.X0Y3_腹板1_腹板.Dra = value;
				this.X0Y4_腹板1_腹板.Dra = value;
				this.X0Y0_腹板1_腹板.Hit = value;
				this.X0Y1_腹板1_腹板.Hit = value;
				this.X0Y2_腹板1_腹板.Hit = value;
				this.X0Y3_腹板1_腹板.Hit = value;
				this.X0Y4_腹板1_腹板.Hit = value;
			}
		}

		public bool 腹板1_縦線_表示
		{
			get
			{
				return this.X0Y0_腹板1_縦線.Dra;
			}
			set
			{
				this.X0Y0_腹板1_縦線.Dra = value;
				this.X0Y1_腹板1_縦線.Dra = value;
				this.X0Y2_腹板1_縦線.Dra = value;
				this.X0Y3_腹板1_縦線.Dra = value;
				this.X0Y4_腹板1_縦線.Dra = value;
				this.X0Y0_腹板1_縦線.Hit = value;
				this.X0Y1_腹板1_縦線.Hit = value;
				this.X0Y2_腹板1_縦線.Hit = value;
				this.X0Y3_腹板1_縦線.Hit = value;
				this.X0Y4_腹板1_縦線.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.腹板4_腹板_表示;
			}
			set
			{
				this.腹板4_腹板_表示 = value;
				this.腹板4_縦線_表示 = value;
				this.腹板3_腹板_表示 = value;
				this.腹板3_縦線_表示 = value;
				this.腹板2_腹板_表示 = value;
				this.腹板2_縦線_表示 = value;
				this.腹板1_腹板_表示 = value;
				this.腹板1_縦線_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.腹板4_腹板CD.不透明度;
			}
			set
			{
				this.腹板4_腹板CD.不透明度 = value;
				this.腹板4_縦線CD.不透明度 = value;
				this.腹板3_腹板CD.不透明度 = value;
				this.腹板3_縦線CD.不透明度 = value;
				this.腹板2_腹板CD.不透明度 = value;
				this.腹板2_縦線CD.不透明度 = value;
				this.腹板1_腹板CD.不透明度 = value;
				this.腹板1_縦線CD.不透明度 = value;
			}
		}

		public override void 色更新()
		{
			switch (this.本体.IndexY)
			{
			case 0:
				this.X0Y0_腹板4_腹板CP.Update();
				this.X0Y0_腹板4_縦線CP.Update();
				this.X0Y0_腹板3_腹板CP.Update();
				this.X0Y0_腹板3_縦線CP.Update();
				this.X0Y0_腹板2_腹板CP.Update();
				this.X0Y0_腹板2_縦線CP.Update();
				this.X0Y0_腹板1_腹板CP.Update();
				this.X0Y0_腹板1_縦線CP.Update();
				return;
			case 1:
				this.X0Y1_腹板4_腹板CP.Update();
				this.X0Y1_腹板4_縦線CP.Update();
				this.X0Y1_腹板3_腹板CP.Update();
				this.X0Y1_腹板3_縦線CP.Update();
				this.X0Y1_腹板2_腹板CP.Update();
				this.X0Y1_腹板2_縦線CP.Update();
				this.X0Y1_腹板1_腹板CP.Update();
				this.X0Y1_腹板1_縦線CP.Update();
				return;
			case 2:
				this.X0Y2_腹板4_腹板CP.Update();
				this.X0Y2_腹板4_縦線CP.Update();
				this.X0Y2_腹板3_腹板CP.Update();
				this.X0Y2_腹板3_縦線CP.Update();
				this.X0Y2_腹板2_腹板CP.Update();
				this.X0Y2_腹板2_縦線CP.Update();
				this.X0Y2_腹板1_腹板CP.Update();
				this.X0Y2_腹板1_縦線CP.Update();
				return;
			case 3:
				this.X0Y3_腹板4_腹板CP.Update();
				this.X0Y3_腹板4_縦線CP.Update();
				this.X0Y3_腹板3_腹板CP.Update();
				this.X0Y3_腹板3_縦線CP.Update();
				this.X0Y3_腹板2_腹板CP.Update();
				this.X0Y3_腹板2_縦線CP.Update();
				this.X0Y3_腹板1_腹板CP.Update();
				this.X0Y3_腹板1_縦線CP.Update();
				return;
			default:
				this.X0Y4_腹板4_腹板CP.Update();
				this.X0Y4_腹板4_縦線CP.Update();
				this.X0Y4_腹板3_腹板CP.Update();
				this.X0Y4_腹板3_縦線CP.Update();
				this.X0Y4_腹板2_腹板CP.Update();
				this.X0Y4_腹板2_縦線CP.Update();
				this.X0Y4_腹板1_腹板CP.Update();
				this.X0Y4_腹板1_縦線CP.Update();
				return;
			}
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.腹板4_腹板CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.腹板4_縦線CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.腹板3_腹板CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.腹板3_縦線CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.腹板2_腹板CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.腹板2_縦線CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.腹板1_腹板CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.腹板1_縦線CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
		}

		public Par X0Y0_腹板4_腹板;

		public Par X0Y0_腹板4_縦線;

		public Par X0Y0_腹板3_腹板;

		public Par X0Y0_腹板3_縦線;

		public Par X0Y0_腹板2_腹板;

		public Par X0Y0_腹板2_縦線;

		public Par X0Y0_腹板1_腹板;

		public Par X0Y0_腹板1_縦線;

		public Par X0Y1_腹板4_腹板;

		public Par X0Y1_腹板4_縦線;

		public Par X0Y1_腹板3_腹板;

		public Par X0Y1_腹板3_縦線;

		public Par X0Y1_腹板2_腹板;

		public Par X0Y1_腹板2_縦線;

		public Par X0Y1_腹板1_腹板;

		public Par X0Y1_腹板1_縦線;

		public Par X0Y2_腹板4_腹板;

		public Par X0Y2_腹板4_縦線;

		public Par X0Y2_腹板3_腹板;

		public Par X0Y2_腹板3_縦線;

		public Par X0Y2_腹板2_腹板;

		public Par X0Y2_腹板2_縦線;

		public Par X0Y2_腹板1_腹板;

		public Par X0Y2_腹板1_縦線;

		public Par X0Y3_腹板4_腹板;

		public Par X0Y3_腹板4_縦線;

		public Par X0Y3_腹板3_腹板;

		public Par X0Y3_腹板3_縦線;

		public Par X0Y3_腹板2_腹板;

		public Par X0Y3_腹板2_縦線;

		public Par X0Y3_腹板1_腹板;

		public Par X0Y3_腹板1_縦線;

		public Par X0Y4_腹板4_腹板;

		public Par X0Y4_腹板4_縦線;

		public Par X0Y4_腹板3_腹板;

		public Par X0Y4_腹板3_縦線;

		public Par X0Y4_腹板2_腹板;

		public Par X0Y4_腹板2_縦線;

		public Par X0Y4_腹板1_腹板;

		public Par X0Y4_腹板1_縦線;

		public ColorD 腹板4_腹板CD;

		public ColorD 腹板4_縦線CD;

		public ColorD 腹板3_腹板CD;

		public ColorD 腹板3_縦線CD;

		public ColorD 腹板2_腹板CD;

		public ColorD 腹板2_縦線CD;

		public ColorD 腹板1_腹板CD;

		public ColorD 腹板1_縦線CD;

		public ColorP X0Y0_腹板4_腹板CP;

		public ColorP X0Y0_腹板4_縦線CP;

		public ColorP X0Y0_腹板3_腹板CP;

		public ColorP X0Y0_腹板3_縦線CP;

		public ColorP X0Y0_腹板2_腹板CP;

		public ColorP X0Y0_腹板2_縦線CP;

		public ColorP X0Y0_腹板1_腹板CP;

		public ColorP X0Y0_腹板1_縦線CP;

		public ColorP X0Y1_腹板4_腹板CP;

		public ColorP X0Y1_腹板4_縦線CP;

		public ColorP X0Y1_腹板3_腹板CP;

		public ColorP X0Y1_腹板3_縦線CP;

		public ColorP X0Y1_腹板2_腹板CP;

		public ColorP X0Y1_腹板2_縦線CP;

		public ColorP X0Y1_腹板1_腹板CP;

		public ColorP X0Y1_腹板1_縦線CP;

		public ColorP X0Y2_腹板4_腹板CP;

		public ColorP X0Y2_腹板4_縦線CP;

		public ColorP X0Y2_腹板3_腹板CP;

		public ColorP X0Y2_腹板3_縦線CP;

		public ColorP X0Y2_腹板2_腹板CP;

		public ColorP X0Y2_腹板2_縦線CP;

		public ColorP X0Y2_腹板1_腹板CP;

		public ColorP X0Y2_腹板1_縦線CP;

		public ColorP X0Y3_腹板4_腹板CP;

		public ColorP X0Y3_腹板4_縦線CP;

		public ColorP X0Y3_腹板3_腹板CP;

		public ColorP X0Y3_腹板3_縦線CP;

		public ColorP X0Y3_腹板2_腹板CP;

		public ColorP X0Y3_腹板2_縦線CP;

		public ColorP X0Y3_腹板1_腹板CP;

		public ColorP X0Y3_腹板1_縦線CP;

		public ColorP X0Y4_腹板4_腹板CP;

		public ColorP X0Y4_腹板4_縦線CP;

		public ColorP X0Y4_腹板3_腹板CP;

		public ColorP X0Y4_腹板3_縦線CP;

		public ColorP X0Y4_腹板2_腹板CP;

		public ColorP X0Y4_腹板2_縦線CP;

		public ColorP X0Y4_腹板1_腹板CP;

		public ColorP X0Y4_腹板1_縦線CP;
	}
}
