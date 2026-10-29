using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 頭頂_皿 : 頭頂
	{
		public 頭頂_皿(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 頭頂_皿D e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "皿";
			dif.Add(new Pars(Sta.肢中["頭部前"][0][1]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_皿1 = pars["皿1"].ToPar();
			this.X0Y0_皿2 = pars["皿2"].ToPar();
			Pars pars2 = pars["甲殻"].ToPars();
			this.X0Y0_甲殻_甲殻4 = pars2["甲殻4"].ToPar();
			this.X0Y0_甲殻_甲殻3 = pars2["甲殻3"].ToPar();
			this.X0Y0_甲殻_甲殻2 = pars2["甲殻2"].ToPar();
			this.X0Y0_甲殻_甲殻1 = pars2["甲殻1"].ToPar();
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
			this.皿1_表示 = e.皿1_表示;
			this.皿2_表示 = e.皿2_表示;
			this.甲殻_甲殻4_表示 = e.甲殻_甲殻4_表示;
			this.甲殻_甲殻3_表示 = e.甲殻_甲殻3_表示;
			this.甲殻_甲殻2_表示 = e.甲殻_甲殻2_表示;
			this.甲殻_甲殻1_表示 = e.甲殻_甲殻1_表示;
			this.甲殻 = e.甲殻;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_皿1CP = new ColorP(this.X0Y0_皿1, this.皿1CD, DisUnit, true);
			this.X0Y0_皿2CP = new ColorP(this.X0Y0_皿2, this.皿2CD, DisUnit, true);
			this.X0Y0_甲殻_甲殻4CP = new ColorP(this.X0Y0_甲殻_甲殻4, this.甲殻_甲殻4CD, DisUnit, true);
			this.X0Y0_甲殻_甲殻3CP = new ColorP(this.X0Y0_甲殻_甲殻3, this.甲殻_甲殻3CD, DisUnit, true);
			this.X0Y0_甲殻_甲殻2CP = new ColorP(this.X0Y0_甲殻_甲殻2, this.甲殻_甲殻2CD, DisUnit, true);
			this.X0Y0_甲殻_甲殻1CP = new ColorP(this.X0Y0_甲殻_甲殻1, this.甲殻_甲殻1CD, DisUnit, true);
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

		public bool 皿1_表示
		{
			get
			{
				return this.X0Y0_皿1.Dra;
			}
			set
			{
				this.X0Y0_皿1.Dra = value;
				this.X0Y0_皿1.Hit = value;
			}
		}

		public bool 皿2_表示
		{
			get
			{
				return this.X0Y0_皿2.Dra;
			}
			set
			{
				this.X0Y0_皿2.Dra = value;
				this.X0Y0_皿2.Hit = value;
			}
		}

		public bool 甲殻_甲殻4_表示
		{
			get
			{
				return this.X0Y0_甲殻_甲殻4.Dra;
			}
			set
			{
				this.X0Y0_甲殻_甲殻4.Dra = value;
				this.X0Y0_甲殻_甲殻4.Hit = value;
			}
		}

		public bool 甲殻_甲殻3_表示
		{
			get
			{
				return this.X0Y0_甲殻_甲殻3.Dra;
			}
			set
			{
				this.X0Y0_甲殻_甲殻3.Dra = value;
				this.X0Y0_甲殻_甲殻3.Hit = value;
			}
		}

		public bool 甲殻_甲殻2_表示
		{
			get
			{
				return this.X0Y0_甲殻_甲殻2.Dra;
			}
			set
			{
				this.X0Y0_甲殻_甲殻2.Dra = value;
				this.X0Y0_甲殻_甲殻2.Hit = value;
			}
		}

		public bool 甲殻_甲殻1_表示
		{
			get
			{
				return this.X0Y0_甲殻_甲殻1.Dra;
			}
			set
			{
				this.X0Y0_甲殻_甲殻1.Dra = value;
				this.X0Y0_甲殻_甲殻1.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.皿1_表示;
			}
			set
			{
				this.皿1_表示 = value;
				this.皿2_表示 = value;
				this.甲殻_甲殻4_表示 = value;
				this.甲殻_甲殻3_表示 = value;
				this.甲殻_甲殻2_表示 = value;
				this.甲殻_甲殻1_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.皿1CD.不透明度;
			}
			set
			{
				this.皿1CD.不透明度 = value;
				this.皿2CD.不透明度 = value;
				this.甲殻_甲殻4CD.不透明度 = value;
				this.甲殻_甲殻3CD.不透明度 = value;
				this.甲殻_甲殻2CD.不透明度 = value;
				this.甲殻_甲殻1CD.不透明度 = value;
			}
		}

		public bool 甲殻
		{
			get
			{
				return this.甲殻_;
			}
			set
			{
				this.甲殻_ = value;
				this.甲殻_甲殻4_表示 = this.甲殻_;
				this.甲殻_甲殻3_表示 = this.甲殻_;
				this.甲殻_甲殻2_表示 = this.甲殻_;
				this.甲殻_甲殻1_表示 = this.甲殻_;
			}
		}

		public override void 色更新()
		{
			this.X0Y0_皿1CP.Update();
			this.X0Y0_皿2CP.Update();
			this.X0Y0_甲殻_甲殻4CP.Update();
			this.X0Y0_甲殻_甲殻3CP.Update();
			this.X0Y0_甲殻_甲殻2CP.Update();
			this.X0Y0_甲殻_甲殻1CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.皿1CD = new ColorD(ref Col.Black, ref 体配色.歯);
			this.皿2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.甲殻_甲殻4CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.甲殻_甲殻3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.甲殻_甲殻2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.甲殻_甲殻1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
		}

		public Par X0Y0_皿1;

		public Par X0Y0_皿2;

		public Par X0Y0_甲殻_甲殻4;

		public Par X0Y0_甲殻_甲殻3;

		public Par X0Y0_甲殻_甲殻2;

		public Par X0Y0_甲殻_甲殻1;

		public ColorD 皿1CD;

		public ColorD 皿2CD;

		public ColorD 甲殻_甲殻4CD;

		public ColorD 甲殻_甲殻3CD;

		public ColorD 甲殻_甲殻2CD;

		public ColorD 甲殻_甲殻1CD;

		public ColorP X0Y0_皿1CP;

		public ColorP X0Y0_皿2CP;

		public ColorP X0Y0_甲殻_甲殻4CP;

		public ColorP X0Y0_甲殻_甲殻3CP;

		public ColorP X0Y0_甲殻_甲殻2CP;

		public ColorP X0Y0_甲殻_甲殻1CP;

		private bool 甲殻_;
	}
}
