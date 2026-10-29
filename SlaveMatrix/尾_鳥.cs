using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 尾_鳥 : 尾
	{
		public 尾_鳥(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 尾_鳥D e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "鳥尾";
			dif.Add(new Pars(Sta.尻尾["尾"][0][9]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_尾0 = pars["尾0"].ToPar();
			Pars pars2 = pars["風切羽"].ToPars();
			Pars pars3 = pars2["左"].ToPars();
			this.X0Y0_風切羽_左_羽1 = pars3["羽1"].ToPar();
			this.X0Y0_風切羽_左_羽2 = pars3["羽2"].ToPar();
			this.X0Y0_風切羽_左_羽3 = pars3["羽3"].ToPar();
			this.X0Y0_風切羽_左_羽4 = pars3["羽4"].ToPar();
			this.X0Y0_風切羽_左_羽5 = pars3["羽5"].ToPar();
			this.X0Y0_風切羽_左_羽6 = pars3["羽6"].ToPar();
			pars3 = pars2["右"].ToPars();
			this.X0Y0_風切羽_右_羽1 = pars3["羽1"].ToPar();
			this.X0Y0_風切羽_右_羽2 = pars3["羽2"].ToPar();
			this.X0Y0_風切羽_右_羽3 = pars3["羽3"].ToPar();
			this.X0Y0_風切羽_右_羽4 = pars3["羽4"].ToPar();
			this.X0Y0_風切羽_右_羽5 = pars3["羽5"].ToPar();
			this.X0Y0_風切羽_右_羽6 = pars3["羽6"].ToPar();
			Pars pars4 = pars["雨覆羽"].ToPars();
			pars3 = pars4["左"].ToPars();
			this.X0Y0_雨覆羽_左_羽1 = pars3["羽1"].ToPar();
			this.X0Y0_雨覆羽_左_羽2 = pars3["羽2"].ToPar();
			this.X0Y0_雨覆羽_左_羽3 = pars3["羽3"].ToPar();
			this.X0Y0_雨覆羽_左_羽4 = pars3["羽4"].ToPar();
			this.X0Y0_雨覆羽_左_羽5 = pars3["羽5"].ToPar();
			pars3 = pars4["右"].ToPars();
			this.X0Y0_雨覆羽_右_羽1 = pars3["羽1"].ToPar();
			this.X0Y0_雨覆羽_右_羽2 = pars3["羽2"].ToPar();
			this.X0Y0_雨覆羽_右_羽3 = pars3["羽3"].ToPar();
			this.X0Y0_雨覆羽_右_羽4 = pars3["羽4"].ToPar();
			this.X0Y0_雨覆羽_右_羽5 = pars3["羽5"].ToPar();
			this.X0Y0_羽根 = pars["羽根"].ToPar();
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
			this.尾0_表示 = e.尾0_表示;
			this.風切羽_左_羽1_表示 = e.風切羽_左_羽1_表示;
			this.風切羽_左_羽2_表示 = e.風切羽_左_羽2_表示;
			this.風切羽_左_羽3_表示 = e.風切羽_左_羽3_表示;
			this.風切羽_左_羽4_表示 = e.風切羽_左_羽4_表示;
			this.風切羽_左_羽5_表示 = e.風切羽_左_羽5_表示;
			this.風切羽_左_羽6_表示 = e.風切羽_左_羽6_表示;
			this.風切羽_右_羽1_表示 = e.風切羽_右_羽1_表示;
			this.風切羽_右_羽2_表示 = e.風切羽_右_羽2_表示;
			this.風切羽_右_羽3_表示 = e.風切羽_右_羽3_表示;
			this.風切羽_右_羽4_表示 = e.風切羽_右_羽4_表示;
			this.風切羽_右_羽5_表示 = e.風切羽_右_羽5_表示;
			this.風切羽_右_羽6_表示 = e.風切羽_右_羽6_表示;
			this.雨覆羽_左_羽1_表示 = e.雨覆羽_左_羽1_表示;
			this.雨覆羽_左_羽2_表示 = e.雨覆羽_左_羽2_表示;
			this.雨覆羽_左_羽3_表示 = e.雨覆羽_左_羽3_表示;
			this.雨覆羽_左_羽4_表示 = e.雨覆羽_左_羽4_表示;
			this.雨覆羽_左_羽5_表示 = e.雨覆羽_左_羽5_表示;
			this.雨覆羽_右_羽1_表示 = e.雨覆羽_右_羽1_表示;
			this.雨覆羽_右_羽2_表示 = e.雨覆羽_右_羽2_表示;
			this.雨覆羽_右_羽3_表示 = e.雨覆羽_右_羽3_表示;
			this.雨覆羽_右_羽4_表示 = e.雨覆羽_右_羽4_表示;
			this.雨覆羽_右_羽5_表示 = e.雨覆羽_右_羽5_表示;
			this.羽根_表示 = e.羽根_表示;
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
			this.X0Y0_尾0CP = new ColorP(this.X0Y0_尾0, this.尾0CD, DisUnit, true);
			this.X0Y0_風切羽_左_羽1CP = new ColorP(this.X0Y0_風切羽_左_羽1, this.風切羽_左_羽1CD, DisUnit, true);
			this.X0Y0_風切羽_左_羽2CP = new ColorP(this.X0Y0_風切羽_左_羽2, this.風切羽_左_羽2CD, DisUnit, true);
			this.X0Y0_風切羽_左_羽3CP = new ColorP(this.X0Y0_風切羽_左_羽3, this.風切羽_左_羽3CD, DisUnit, true);
			this.X0Y0_風切羽_左_羽4CP = new ColorP(this.X0Y0_風切羽_左_羽4, this.風切羽_左_羽4CD, DisUnit, true);
			this.X0Y0_風切羽_左_羽5CP = new ColorP(this.X0Y0_風切羽_左_羽5, this.風切羽_左_羽5CD, DisUnit, true);
			this.X0Y0_風切羽_左_羽6CP = new ColorP(this.X0Y0_風切羽_左_羽6, this.風切羽_左_羽6CD, DisUnit, true);
			this.X0Y0_風切羽_右_羽1CP = new ColorP(this.X0Y0_風切羽_右_羽1, this.風切羽_右_羽1CD, DisUnit, true);
			this.X0Y0_風切羽_右_羽2CP = new ColorP(this.X0Y0_風切羽_右_羽2, this.風切羽_右_羽2CD, DisUnit, true);
			this.X0Y0_風切羽_右_羽3CP = new ColorP(this.X0Y0_風切羽_右_羽3, this.風切羽_右_羽3CD, DisUnit, true);
			this.X0Y0_風切羽_右_羽4CP = new ColorP(this.X0Y0_風切羽_右_羽4, this.風切羽_右_羽4CD, DisUnit, true);
			this.X0Y0_風切羽_右_羽5CP = new ColorP(this.X0Y0_風切羽_右_羽5, this.風切羽_右_羽5CD, DisUnit, true);
			this.X0Y0_風切羽_右_羽6CP = new ColorP(this.X0Y0_風切羽_右_羽6, this.風切羽_右_羽6CD, DisUnit, true);
			this.X0Y0_雨覆羽_左_羽1CP = new ColorP(this.X0Y0_雨覆羽_左_羽1, this.雨覆羽_左_羽1CD, DisUnit, true);
			this.X0Y0_雨覆羽_左_羽2CP = new ColorP(this.X0Y0_雨覆羽_左_羽2, this.雨覆羽_左_羽2CD, DisUnit, true);
			this.X0Y0_雨覆羽_左_羽3CP = new ColorP(this.X0Y0_雨覆羽_左_羽3, this.雨覆羽_左_羽3CD, DisUnit, true);
			this.X0Y0_雨覆羽_左_羽4CP = new ColorP(this.X0Y0_雨覆羽_左_羽4, this.雨覆羽_左_羽4CD, DisUnit, true);
			this.X0Y0_雨覆羽_左_羽5CP = new ColorP(this.X0Y0_雨覆羽_左_羽5, this.雨覆羽_左_羽5CD, DisUnit, true);
			this.X0Y0_雨覆羽_右_羽1CP = new ColorP(this.X0Y0_雨覆羽_右_羽1, this.雨覆羽_右_羽1CD, DisUnit, true);
			this.X0Y0_雨覆羽_右_羽2CP = new ColorP(this.X0Y0_雨覆羽_右_羽2, this.雨覆羽_右_羽2CD, DisUnit, true);
			this.X0Y0_雨覆羽_右_羽3CP = new ColorP(this.X0Y0_雨覆羽_右_羽3, this.雨覆羽_右_羽3CD, DisUnit, true);
			this.X0Y0_雨覆羽_右_羽4CP = new ColorP(this.X0Y0_雨覆羽_右_羽4, this.雨覆羽_右_羽4CD, DisUnit, true);
			this.X0Y0_雨覆羽_右_羽5CP = new ColorP(this.X0Y0_雨覆羽_右_羽5, this.雨覆羽_右_羽5CD, DisUnit, true);
			this.X0Y0_羽根CP = new ColorP(this.X0Y0_羽根, this.羽根CD, DisUnit, true);
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

		public bool 尾0_表示
		{
			get
			{
				return this.X0Y0_尾0.Dra;
			}
			set
			{
				this.X0Y0_尾0.Dra = value;
				this.X0Y0_尾0.Hit = value;
			}
		}

		public bool 風切羽_左_羽1_表示
		{
			get
			{
				return this.X0Y0_風切羽_左_羽1.Dra;
			}
			set
			{
				this.X0Y0_風切羽_左_羽1.Dra = value;
				this.X0Y0_風切羽_左_羽1.Hit = value;
			}
		}

		public bool 風切羽_左_羽2_表示
		{
			get
			{
				return this.X0Y0_風切羽_左_羽2.Dra;
			}
			set
			{
				this.X0Y0_風切羽_左_羽2.Dra = value;
				this.X0Y0_風切羽_左_羽2.Hit = value;
			}
		}

		public bool 風切羽_左_羽3_表示
		{
			get
			{
				return this.X0Y0_風切羽_左_羽3.Dra;
			}
			set
			{
				this.X0Y0_風切羽_左_羽3.Dra = value;
				this.X0Y0_風切羽_左_羽3.Hit = value;
			}
		}

		public bool 風切羽_左_羽4_表示
		{
			get
			{
				return this.X0Y0_風切羽_左_羽4.Dra;
			}
			set
			{
				this.X0Y0_風切羽_左_羽4.Dra = value;
				this.X0Y0_風切羽_左_羽4.Hit = value;
			}
		}

		public bool 風切羽_左_羽5_表示
		{
			get
			{
				return this.X0Y0_風切羽_左_羽5.Dra;
			}
			set
			{
				this.X0Y0_風切羽_左_羽5.Dra = value;
				this.X0Y0_風切羽_左_羽5.Hit = value;
			}
		}

		public bool 風切羽_左_羽6_表示
		{
			get
			{
				return this.X0Y0_風切羽_左_羽6.Dra;
			}
			set
			{
				this.X0Y0_風切羽_左_羽6.Dra = value;
				this.X0Y0_風切羽_左_羽6.Hit = value;
			}
		}

		public bool 風切羽_右_羽1_表示
		{
			get
			{
				return this.X0Y0_風切羽_右_羽1.Dra;
			}
			set
			{
				this.X0Y0_風切羽_右_羽1.Dra = value;
				this.X0Y0_風切羽_右_羽1.Hit = value;
			}
		}

		public bool 風切羽_右_羽2_表示
		{
			get
			{
				return this.X0Y0_風切羽_右_羽2.Dra;
			}
			set
			{
				this.X0Y0_風切羽_右_羽2.Dra = value;
				this.X0Y0_風切羽_右_羽2.Hit = value;
			}
		}

		public bool 風切羽_右_羽3_表示
		{
			get
			{
				return this.X0Y0_風切羽_右_羽3.Dra;
			}
			set
			{
				this.X0Y0_風切羽_右_羽3.Dra = value;
				this.X0Y0_風切羽_右_羽3.Hit = value;
			}
		}

		public bool 風切羽_右_羽4_表示
		{
			get
			{
				return this.X0Y0_風切羽_右_羽4.Dra;
			}
			set
			{
				this.X0Y0_風切羽_右_羽4.Dra = value;
				this.X0Y0_風切羽_右_羽4.Hit = value;
			}
		}

		public bool 風切羽_右_羽5_表示
		{
			get
			{
				return this.X0Y0_風切羽_右_羽5.Dra;
			}
			set
			{
				this.X0Y0_風切羽_右_羽5.Dra = value;
				this.X0Y0_風切羽_右_羽5.Hit = value;
			}
		}

		public bool 風切羽_右_羽6_表示
		{
			get
			{
				return this.X0Y0_風切羽_右_羽6.Dra;
			}
			set
			{
				this.X0Y0_風切羽_右_羽6.Dra = value;
				this.X0Y0_風切羽_右_羽6.Hit = value;
			}
		}

		public bool 雨覆羽_左_羽1_表示
		{
			get
			{
				return this.X0Y0_雨覆羽_左_羽1.Dra;
			}
			set
			{
				this.X0Y0_雨覆羽_左_羽1.Dra = value;
				this.X0Y0_雨覆羽_左_羽1.Hit = value;
			}
		}

		public bool 雨覆羽_左_羽2_表示
		{
			get
			{
				return this.X0Y0_雨覆羽_左_羽2.Dra;
			}
			set
			{
				this.X0Y0_雨覆羽_左_羽2.Dra = value;
				this.X0Y0_雨覆羽_左_羽2.Hit = value;
			}
		}

		public bool 雨覆羽_左_羽3_表示
		{
			get
			{
				return this.X0Y0_雨覆羽_左_羽3.Dra;
			}
			set
			{
				this.X0Y0_雨覆羽_左_羽3.Dra = value;
				this.X0Y0_雨覆羽_左_羽3.Hit = value;
			}
		}

		public bool 雨覆羽_左_羽4_表示
		{
			get
			{
				return this.X0Y0_雨覆羽_左_羽4.Dra;
			}
			set
			{
				this.X0Y0_雨覆羽_左_羽4.Dra = value;
				this.X0Y0_雨覆羽_左_羽4.Hit = value;
			}
		}

		public bool 雨覆羽_左_羽5_表示
		{
			get
			{
				return this.X0Y0_雨覆羽_左_羽5.Dra;
			}
			set
			{
				this.X0Y0_雨覆羽_左_羽5.Dra = value;
				this.X0Y0_雨覆羽_左_羽5.Hit = value;
			}
		}

		public bool 雨覆羽_右_羽1_表示
		{
			get
			{
				return this.X0Y0_雨覆羽_右_羽1.Dra;
			}
			set
			{
				this.X0Y0_雨覆羽_右_羽1.Dra = value;
				this.X0Y0_雨覆羽_右_羽1.Hit = value;
			}
		}

		public bool 雨覆羽_右_羽2_表示
		{
			get
			{
				return this.X0Y0_雨覆羽_右_羽2.Dra;
			}
			set
			{
				this.X0Y0_雨覆羽_右_羽2.Dra = value;
				this.X0Y0_雨覆羽_右_羽2.Hit = value;
			}
		}

		public bool 雨覆羽_右_羽3_表示
		{
			get
			{
				return this.X0Y0_雨覆羽_右_羽3.Dra;
			}
			set
			{
				this.X0Y0_雨覆羽_右_羽3.Dra = value;
				this.X0Y0_雨覆羽_右_羽3.Hit = value;
			}
		}

		public bool 雨覆羽_右_羽4_表示
		{
			get
			{
				return this.X0Y0_雨覆羽_右_羽4.Dra;
			}
			set
			{
				this.X0Y0_雨覆羽_右_羽4.Dra = value;
				this.X0Y0_雨覆羽_右_羽4.Hit = value;
			}
		}

		public bool 雨覆羽_右_羽5_表示
		{
			get
			{
				return this.X0Y0_雨覆羽_右_羽5.Dra;
			}
			set
			{
				this.X0Y0_雨覆羽_右_羽5.Dra = value;
				this.X0Y0_雨覆羽_右_羽5.Hit = value;
			}
		}

		public bool 羽根_表示
		{
			get
			{
				return this.X0Y0_羽根.Dra;
			}
			set
			{
				this.X0Y0_羽根.Dra = value;
				this.X0Y0_羽根.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.尾0_表示;
			}
			set
			{
				this.尾0_表示 = value;
				this.風切羽_左_羽1_表示 = value;
				this.風切羽_左_羽2_表示 = value;
				this.風切羽_左_羽3_表示 = value;
				this.風切羽_左_羽4_表示 = value;
				this.風切羽_左_羽5_表示 = value;
				this.風切羽_左_羽6_表示 = value;
				this.風切羽_右_羽1_表示 = value;
				this.風切羽_右_羽2_表示 = value;
				this.風切羽_右_羽3_表示 = value;
				this.風切羽_右_羽4_表示 = value;
				this.風切羽_右_羽5_表示 = value;
				this.風切羽_右_羽6_表示 = value;
				this.雨覆羽_左_羽1_表示 = value;
				this.雨覆羽_左_羽2_表示 = value;
				this.雨覆羽_左_羽3_表示 = value;
				this.雨覆羽_左_羽4_表示 = value;
				this.雨覆羽_左_羽5_表示 = value;
				this.雨覆羽_右_羽1_表示 = value;
				this.雨覆羽_右_羽2_表示 = value;
				this.雨覆羽_右_羽3_表示 = value;
				this.雨覆羽_右_羽4_表示 = value;
				this.雨覆羽_右_羽5_表示 = value;
				this.羽根_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.尾0CD.不透明度;
			}
			set
			{
				this.尾0CD.不透明度 = value;
				this.風切羽_左_羽1CD.不透明度 = value;
				this.風切羽_左_羽2CD.不透明度 = value;
				this.風切羽_左_羽3CD.不透明度 = value;
				this.風切羽_左_羽4CD.不透明度 = value;
				this.風切羽_左_羽5CD.不透明度 = value;
				this.風切羽_左_羽6CD.不透明度 = value;
				this.風切羽_右_羽1CD.不透明度 = value;
				this.風切羽_右_羽2CD.不透明度 = value;
				this.風切羽_右_羽3CD.不透明度 = value;
				this.風切羽_右_羽4CD.不透明度 = value;
				this.風切羽_右_羽5CD.不透明度 = value;
				this.風切羽_右_羽6CD.不透明度 = value;
				this.雨覆羽_左_羽1CD.不透明度 = value;
				this.雨覆羽_左_羽2CD.不透明度 = value;
				this.雨覆羽_左_羽3CD.不透明度 = value;
				this.雨覆羽_左_羽4CD.不透明度 = value;
				this.雨覆羽_左_羽5CD.不透明度 = value;
				this.雨覆羽_右_羽1CD.不透明度 = value;
				this.雨覆羽_右_羽2CD.不透明度 = value;
				this.雨覆羽_右_羽3CD.不透明度 = value;
				this.雨覆羽_右_羽4CD.不透明度 = value;
				this.雨覆羽_右_羽5CD.不透明度 = value;
				this.羽根CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			double num = this.右 ? -1.0 : 1.0;
			this.X0Y0_風切羽_左_羽1.AngleBase = num * 12.0;
			this.X0Y0_風切羽_左_羽2.AngleBase = num * 22.0;
			this.X0Y0_風切羽_左_羽3.AngleBase = num * 32.0;
			this.X0Y0_風切羽_左_羽4.AngleBase = num * 42.0;
			this.X0Y0_風切羽_左_羽5.AngleBase = num * 52.0;
			this.X0Y0_風切羽_左_羽6.AngleBase = num * 62.0;
			this.X0Y0_風切羽_右_羽1.AngleBase = num * -12.0;
			this.X0Y0_風切羽_右_羽2.AngleBase = num * -22.0;
			this.X0Y0_風切羽_右_羽3.AngleBase = num * -32.0;
			this.X0Y0_風切羽_右_羽4.AngleBase = num * -42.0;
			this.X0Y0_風切羽_右_羽5.AngleBase = num * -52.0;
			this.X0Y0_風切羽_右_羽6.AngleBase = num * -62.0;
			this.X0Y0_雨覆羽_左_羽1.AngleBase = num * 0.0;
			this.X0Y0_雨覆羽_左_羽2.AngleBase = num * 32.0;
			this.X0Y0_雨覆羽_左_羽3.AngleBase = num * 42.0;
			this.X0Y0_雨覆羽_左_羽4.AngleBase = num * 52.0;
			this.X0Y0_雨覆羽_左_羽5.AngleBase = num * 62.0;
			this.X0Y0_雨覆羽_右_羽1.AngleBase = num * 0.0;
			this.X0Y0_雨覆羽_右_羽2.AngleBase = num * -32.0;
			this.X0Y0_雨覆羽_右_羽3.AngleBase = num * -42.0;
			this.X0Y0_雨覆羽_右_羽4.AngleBase = num * -52.0;
			this.X0Y0_雨覆羽_右_羽5.AngleBase = num * -62.0;
			this.本体.JoinPAall();
		}

		public double 展開
		{
			set
			{
				double num = value.Inverse();
				double num2 = this.右 ? -1.0 : 1.0;
				this.X0Y0_風切羽_左_羽1.AngleCont = num2 * -12.0 * num;
				this.X0Y0_風切羽_左_羽2.AngleCont = num2 * -22.0 * num;
				this.X0Y0_風切羽_左_羽3.AngleCont = num2 * -32.0 * num;
				this.X0Y0_風切羽_左_羽4.AngleCont = num2 * -42.0 * num;
				this.X0Y0_風切羽_左_羽5.AngleCont = num2 * -52.0 * num;
				this.X0Y0_風切羽_左_羽6.AngleCont = num2 * -62.0 * num;
				this.X0Y0_風切羽_右_羽1.AngleCont = num2 * 12.0 * num;
				this.X0Y0_風切羽_右_羽2.AngleCont = num2 * 22.0 * num;
				this.X0Y0_風切羽_右_羽3.AngleCont = num2 * 32.0 * num;
				this.X0Y0_風切羽_右_羽4.AngleCont = num2 * 42.0 * num;
				this.X0Y0_風切羽_右_羽5.AngleCont = num2 * 52.0 * num;
				this.X0Y0_風切羽_右_羽6.AngleCont = num2 * 62.0 * num;
				this.X0Y0_雨覆羽_左_羽1.AngleCont = num2 * -12.0 * num;
				this.X0Y0_雨覆羽_左_羽2.AngleCont = num2 * -32.0 * num;
				this.X0Y0_雨覆羽_左_羽3.AngleCont = num2 * -42.0 * num;
				this.X0Y0_雨覆羽_左_羽4.AngleCont = num2 * -52.0 * num;
				this.X0Y0_雨覆羽_左_羽5.AngleCont = num2 * -62.0 * num;
				this.X0Y0_雨覆羽_右_羽1.AngleCont = num2 * 12.0 * num;
				this.X0Y0_雨覆羽_右_羽2.AngleCont = num2 * 32.0 * num;
				this.X0Y0_雨覆羽_右_羽3.AngleCont = num2 * 42.0 * num;
				this.X0Y0_雨覆羽_右_羽4.AngleCont = num2 * 52.0 * num;
				this.X0Y0_雨覆羽_右_羽5.AngleCont = num2 * 62.0 * num;
			}
		}

		public override IEnumerable<Par> Enum軸()
		{
			yield return this.X0Y0_尾0;
			yield break;
		}

		public override void 色更新()
		{
			this.X0Y0_尾0CP.Update();
			this.X0Y0_風切羽_左_羽1CP.Update();
			this.X0Y0_風切羽_左_羽2CP.Update();
			this.X0Y0_風切羽_左_羽3CP.Update();
			this.X0Y0_風切羽_左_羽4CP.Update();
			this.X0Y0_風切羽_左_羽5CP.Update();
			this.X0Y0_風切羽_左_羽6CP.Update();
			this.X0Y0_風切羽_右_羽1CP.Update();
			this.X0Y0_風切羽_右_羽2CP.Update();
			this.X0Y0_風切羽_右_羽3CP.Update();
			this.X0Y0_風切羽_右_羽4CP.Update();
			this.X0Y0_風切羽_右_羽5CP.Update();
			this.X0Y0_風切羽_右_羽6CP.Update();
			this.X0Y0_雨覆羽_左_羽1CP.Update();
			this.X0Y0_雨覆羽_左_羽2CP.Update();
			this.X0Y0_雨覆羽_左_羽3CP.Update();
			this.X0Y0_雨覆羽_左_羽4CP.Update();
			this.X0Y0_雨覆羽_左_羽5CP.Update();
			this.X0Y0_雨覆羽_右_羽1CP.Update();
			this.X0Y0_雨覆羽_右_羽2CP.Update();
			this.X0Y0_雨覆羽_右_羽3CP.Update();
			this.X0Y0_雨覆羽_右_羽4CP.Update();
			this.X0Y0_雨覆羽_右_羽5CP.Update();
			this.X0Y0_羽根CP.Update();
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
			this.尾0CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.風切羽_左_羽1CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_左_羽2CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_左_羽3CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_左_羽4CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_左_羽5CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_左_羽6CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_右_羽1CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_右_羽2CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_右_羽3CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_右_羽4CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_右_羽5CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_右_羽6CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.雨覆羽_左_羽1CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.雨覆羽_左_羽2CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.雨覆羽_左_羽3CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.雨覆羽_左_羽4CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.雨覆羽_左_羽5CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.雨覆羽_右_羽1CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.雨覆羽_右_羽2CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.雨覆羽_右_羽3CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.雨覆羽_右_羽4CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.雨覆羽_右_羽5CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.羽根CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
		}

		private void 配色T0(体配色 体配色)
		{
			this.尾0CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.風切羽_左_羽1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.風切羽_左_羽2CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_左_羽3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.風切羽_左_羽4CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_左_羽5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.風切羽_左_羽6CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_右_羽1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.風切羽_右_羽2CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_右_羽3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.風切羽_右_羽4CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_右_羽5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.風切羽_右_羽6CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.雨覆羽_左_羽1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.雨覆羽_左_羽2CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.雨覆羽_左_羽3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.雨覆羽_左_羽4CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.雨覆羽_左_羽5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.雨覆羽_右_羽1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.雨覆羽_右_羽2CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.雨覆羽_右_羽3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.雨覆羽_右_羽4CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.雨覆羽_右_羽5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽根CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
		}

		private void 配色T1(体配色 体配色)
		{
			this.尾0CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.風切羽_左_羽1CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_左_羽2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.風切羽_左_羽3CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_左_羽4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.風切羽_左_羽5CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_左_羽6CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.風切羽_右_羽1CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_右_羽2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.風切羽_右_羽3CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_右_羽4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.風切羽_右_羽5CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_右_羽6CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.雨覆羽_左_羽1CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.雨覆羽_左_羽2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.雨覆羽_左_羽3CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.雨覆羽_左_羽4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.雨覆羽_左_羽5CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.雨覆羽_右_羽1CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.雨覆羽_右_羽2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.雨覆羽_右_羽3CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.雨覆羽_右_羽4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.雨覆羽_右_羽5CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.羽根CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
		}

		public Par X0Y0_尾0;

		public Par X0Y0_風切羽_左_羽1;

		public Par X0Y0_風切羽_左_羽2;

		public Par X0Y0_風切羽_左_羽3;

		public Par X0Y0_風切羽_左_羽4;

		public Par X0Y0_風切羽_左_羽5;

		public Par X0Y0_風切羽_左_羽6;

		public Par X0Y0_風切羽_右_羽1;

		public Par X0Y0_風切羽_右_羽2;

		public Par X0Y0_風切羽_右_羽3;

		public Par X0Y0_風切羽_右_羽4;

		public Par X0Y0_風切羽_右_羽5;

		public Par X0Y0_風切羽_右_羽6;

		public Par X0Y0_雨覆羽_左_羽1;

		public Par X0Y0_雨覆羽_左_羽2;

		public Par X0Y0_雨覆羽_左_羽3;

		public Par X0Y0_雨覆羽_左_羽4;

		public Par X0Y0_雨覆羽_左_羽5;

		public Par X0Y0_雨覆羽_右_羽1;

		public Par X0Y0_雨覆羽_右_羽2;

		public Par X0Y0_雨覆羽_右_羽3;

		public Par X0Y0_雨覆羽_右_羽4;

		public Par X0Y0_雨覆羽_右_羽5;

		public Par X0Y0_羽根;

		public ColorD 尾0CD;

		public ColorD 風切羽_左_羽1CD;

		public ColorD 風切羽_左_羽2CD;

		public ColorD 風切羽_左_羽3CD;

		public ColorD 風切羽_左_羽4CD;

		public ColorD 風切羽_左_羽5CD;

		public ColorD 風切羽_左_羽6CD;

		public ColorD 風切羽_右_羽1CD;

		public ColorD 風切羽_右_羽2CD;

		public ColorD 風切羽_右_羽3CD;

		public ColorD 風切羽_右_羽4CD;

		public ColorD 風切羽_右_羽5CD;

		public ColorD 風切羽_右_羽6CD;

		public ColorD 雨覆羽_左_羽1CD;

		public ColorD 雨覆羽_左_羽2CD;

		public ColorD 雨覆羽_左_羽3CD;

		public ColorD 雨覆羽_左_羽4CD;

		public ColorD 雨覆羽_左_羽5CD;

		public ColorD 雨覆羽_右_羽1CD;

		public ColorD 雨覆羽_右_羽2CD;

		public ColorD 雨覆羽_右_羽3CD;

		public ColorD 雨覆羽_右_羽4CD;

		public ColorD 雨覆羽_右_羽5CD;

		public ColorD 羽根CD;

		public ColorP X0Y0_尾0CP;

		public ColorP X0Y0_風切羽_左_羽1CP;

		public ColorP X0Y0_風切羽_左_羽2CP;

		public ColorP X0Y0_風切羽_左_羽3CP;

		public ColorP X0Y0_風切羽_左_羽4CP;

		public ColorP X0Y0_風切羽_左_羽5CP;

		public ColorP X0Y0_風切羽_左_羽6CP;

		public ColorP X0Y0_風切羽_右_羽1CP;

		public ColorP X0Y0_風切羽_右_羽2CP;

		public ColorP X0Y0_風切羽_右_羽3CP;

		public ColorP X0Y0_風切羽_右_羽4CP;

		public ColorP X0Y0_風切羽_右_羽5CP;

		public ColorP X0Y0_風切羽_右_羽6CP;

		public ColorP X0Y0_雨覆羽_左_羽1CP;

		public ColorP X0Y0_雨覆羽_左_羽2CP;

		public ColorP X0Y0_雨覆羽_左_羽3CP;

		public ColorP X0Y0_雨覆羽_左_羽4CP;

		public ColorP X0Y0_雨覆羽_左_羽5CP;

		public ColorP X0Y0_雨覆羽_右_羽1CP;

		public ColorP X0Y0_雨覆羽_右_羽2CP;

		public ColorP X0Y0_雨覆羽_右_羽3CP;

		public ColorP X0Y0_雨覆羽_右_羽4CP;

		public ColorP X0Y0_雨覆羽_右_羽5CP;

		public ColorP X0Y0_羽根CP;
	}
}
