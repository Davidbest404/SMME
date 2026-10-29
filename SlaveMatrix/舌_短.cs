using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 舌_短 : 舌
	{
		public 舌_短(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 舌_短D e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "短";
			dif.Add(new Pars(Sta.胴体["舌"][0][0]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_舌1 = pars["舌1"].ToPar();
			this.X0Y0_舌2 = pars["舌2"].ToPar();
			this.X0Y0_舌3 = pars["舌3"].ToPar();
			this.X0Y0_舌4 = pars["舌4"].ToPar();
			this.X0Y0_舌5 = pars["舌5"].ToPar();
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
			this.舌1_表示 = e.舌1_表示;
			this.舌2_表示 = e.舌2_表示;
			this.舌3_表示 = e.舌3_表示;
			this.舌4_表示 = e.舌4_表示;
			this.舌5_表示 = e.舌5_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.Pars = new Par[]
			{
				this.X0Y0_舌1,
				this.X0Y0_舌2,
				this.X0Y0_舌3,
				this.X0Y0_舌4,
				this.X0Y0_舌5
			};
			this.X0Y0_舌1CP = new ColorP(this.X0Y0_舌1, this.舌1CD, DisUnit, true);
			this.X0Y0_舌2CP = new ColorP(this.X0Y0_舌2, this.舌2CD, DisUnit, true);
			this.X0Y0_舌3CP = new ColorP(this.X0Y0_舌3, this.舌3CD, DisUnit, true);
			this.X0Y0_舌4CP = new ColorP(this.X0Y0_舌4, this.舌4CD, DisUnit, true);
			this.X0Y0_舌5CP = new ColorP(this.X0Y0_舌5, this.舌5CD, DisUnit, true);
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

		public bool 舌1_表示
		{
			get
			{
				return this.X0Y0_舌1.Dra;
			}
			set
			{
				this.X0Y0_舌1.Dra = value;
				this.X0Y0_舌1.Hit = value;
			}
		}

		public bool 舌2_表示
		{
			get
			{
				return this.X0Y0_舌2.Dra;
			}
			set
			{
				this.X0Y0_舌2.Dra = value;
				this.X0Y0_舌2.Hit = value;
			}
		}

		public bool 舌3_表示
		{
			get
			{
				return this.X0Y0_舌3.Dra;
			}
			set
			{
				this.X0Y0_舌3.Dra = value;
				this.X0Y0_舌3.Hit = value;
			}
		}

		public bool 舌4_表示
		{
			get
			{
				return this.X0Y0_舌4.Dra;
			}
			set
			{
				this.X0Y0_舌4.Dra = value;
				this.X0Y0_舌4.Hit = value;
			}
		}

		public bool 舌5_表示
		{
			get
			{
				return this.X0Y0_舌5.Dra;
			}
			set
			{
				this.X0Y0_舌5.Dra = value;
				this.X0Y0_舌5.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.舌1_表示;
			}
			set
			{
				this.舌1_表示 = value;
				this.舌2_表示 = value;
				this.舌3_表示 = value;
				this.舌4_表示 = value;
				this.舌5_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.舌1CD.不透明度;
			}
			set
			{
				this.舌1CD.不透明度 = value;
				this.舌2CD.不透明度 = value;
				this.舌3CD.不透明度 = value;
				this.舌4CD.不透明度 = value;
				this.舌5CD.不透明度 = value;
			}
		}

		public override void 色更新()
		{
			this.Pars.GetMiY_MaY(out this.mm);
			this.X0Y0_舌1CP.Update(this.mm);
			this.X0Y0_舌2CP.Update(this.mm);
			this.X0Y0_舌3CP.Update(this.mm);
			this.X0Y0_舌4CP.Update(this.mm);
			this.X0Y0_舌5CP.Update(this.mm);
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.舌1CD = new ColorD(ref 体配色.粘膜線, ref 体配色.舌);
			this.舌2CD = new ColorD(ref 体配色.粘膜線, ref 体配色.舌);
			this.舌3CD = new ColorD(ref 体配色.粘膜線, ref 体配色.舌);
			this.舌4CD = new ColorD(ref 体配色.粘膜線, ref 体配色.舌);
			this.舌5CD = new ColorD(ref 体配色.粘膜線, ref 体配色.舌);
		}

		public Par X0Y0_舌1;

		public Par X0Y0_舌2;

		public Par X0Y0_舌3;

		public Par X0Y0_舌4;

		public Par X0Y0_舌5;

		public ColorD 舌1CD;

		public ColorD 舌2CD;

		public ColorD 舌3CD;

		public ColorD 舌4CD;

		public ColorD 舌5CD;

		public ColorP X0Y0_舌1CP;

		public ColorP X0Y0_舌2CP;

		public ColorP X0Y0_舌3CP;

		public ColorP X0Y0_舌4CP;

		public ColorP X0Y0_舌5CP;

		public Par[] Pars;

		private Vector2D[] mm;
	}
}
