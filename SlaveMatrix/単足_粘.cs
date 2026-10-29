using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 単足_粘 : 半身
	{
		public 単足_粘(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 単足_粘D e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "粘";
			dif.Add(new Pars(Sta.半身["単足"][0][1]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_粘液0 = pars["粘液0"].ToPar();
			this.X0Y0_粘液1 = pars["粘液1"].ToPar();
			Pars pars2 = pars["粘液2"].ToPars();
			this.X0Y0_粘液2_粘液 = pars2["粘液"].ToPar();
			this.X0Y0_粘液2_ハイライト左 = pars2["ハイライト左"].ToPar();
			this.X0Y0_粘液2_ハイライト右 = pars2["ハイライト右"].ToPar();
			this.X0Y0_粘液2_ハイライト下1 = pars2["ハイライト下1"].ToPar();
			this.X0Y0_粘液2_ハイライト下2 = pars2["ハイライト下2"].ToPar();
			pars2 = pars["粘液3"].ToPars();
			this.X0Y0_粘液3_粘液 = pars2["粘液"].ToPar();
			this.X0Y0_粘液3_ハイライト左上 = pars2["ハイライト左上"].ToPar();
			this.X0Y0_粘液3_ハイライト右上 = pars2["ハイライト右上"].ToPar();
			this.X0Y0_粘液3_ハイライト左下1 = pars2["ハイライト左下1"].ToPar();
			this.X0Y0_粘液3_ハイライト左下2 = pars2["ハイライト左下2"].ToPar();
			this.X0Y0_粘液3_ハイライト右下1 = pars2["ハイライト右下1"].ToPar();
			this.X0Y0_粘液3_ハイライト右下2 = pars2["ハイライト右下2"].ToPar();
			this.X0Y0_粘液3_ハイライト下1 = pars2["ハイライト下1"].ToPar();
			this.X0Y0_粘液3_ハイライト下2 = pars2["ハイライト下2"].ToPar();
			pars2 = pars["粘液4"].ToPars();
			this.X0Y0_粘液4_粘液 = pars2["粘液"].ToPar();
			this.X0Y0_粘液4_ハイライト上1 = pars2["ハイライト上1"].ToPar();
			this.X0Y0_粘液4_ハイライト上2 = pars2["ハイライト上2"].ToPar();
			this.X0Y0_粘液4_ハイライト下1 = pars2["ハイライト下1"].ToPar();
			this.X0Y0_粘液4_ハイライト下2 = pars2["ハイライト下2"].ToPar();
			pars2 = pars["粘液下左"].ToPars();
			this.X0Y0_粘液下左_粘液 = pars2["粘液"].ToPar();
			this.X0Y0_粘液下左_ハイライト1 = pars2["ハイライト1"].ToPar();
			this.X0Y0_粘液下左_ハイライト2 = pars2["ハイライト2"].ToPar();
			pars2 = pars["粘液下右"].ToPars();
			this.X0Y0_粘液下右_粘液 = pars2["粘液"].ToPar();
			this.X0Y0_粘液下右_ハイライト1 = pars2["ハイライト1"].ToPar();
			this.X0Y0_粘液下右_ハイライト2 = pars2["ハイライト2"].ToPar();
			pars2 = pars["粘液上左"].ToPars();
			this.X0Y0_粘液上左_粘液 = pars2["粘液"].ToPar();
			this.X0Y0_粘液上左_ハイライト = pars2["ハイライト"].ToPar();
			pars2 = pars["粘液上右"].ToPars();
			this.X0Y0_粘液上右_粘液 = pars2["粘液"].ToPar();
			this.X0Y0_粘液上右_ハイライト = pars2["ハイライト"].ToPar();
			this.X0Y0_ハイライト = pars["ハイライト"].ToPar();
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
			this.粘液0_表示 = e.粘液0_表示;
			this.粘液1_表示 = e.粘液1_表示;
			this.粘液2_粘液_表示 = e.粘液2_粘液_表示;
			this.粘液2_ハイライト左_表示 = e.粘液2_ハイライト左_表示;
			this.粘液2_ハイライト右_表示 = e.粘液2_ハイライト右_表示;
			this.粘液2_ハイライト下1_表示 = e.粘液2_ハイライト下1_表示;
			this.粘液2_ハイライト下2_表示 = e.粘液2_ハイライト下2_表示;
			this.粘液3_粘液_表示 = e.粘液3_粘液_表示;
			this.粘液3_ハイライト左上_表示 = e.粘液3_ハイライト左上_表示;
			this.粘液3_ハイライト右上_表示 = e.粘液3_ハイライト右上_表示;
			this.粘液3_ハイライト左下1_表示 = e.粘液3_ハイライト左下1_表示;
			this.粘液3_ハイライト左下2_表示 = e.粘液3_ハイライト左下2_表示;
			this.粘液3_ハイライト右下1_表示 = e.粘液3_ハイライト右下1_表示;
			this.粘液3_ハイライト右下2_表示 = e.粘液3_ハイライト右下2_表示;
			this.粘液3_ハイライト下1_表示 = e.粘液3_ハイライト下1_表示;
			this.粘液3_ハイライト下2_表示 = e.粘液3_ハイライト下2_表示;
			this.粘液4_粘液_表示 = e.粘液4_粘液_表示;
			this.粘液4_ハイライト上1_表示 = e.粘液4_ハイライト上1_表示;
			this.粘液4_ハイライト上2_表示 = e.粘液4_ハイライト上2_表示;
			this.粘液4_ハイライト下1_表示 = e.粘液4_ハイライト下1_表示;
			this.粘液4_ハイライト下2_表示 = e.粘液4_ハイライト下2_表示;
			this.粘液下左_粘液_表示 = e.粘液下左_粘液_表示;
			this.粘液下左_ハイライト1_表示 = e.粘液下左_ハイライト1_表示;
			this.粘液下左_ハイライト2_表示 = e.粘液下左_ハイライト2_表示;
			this.粘液下右_粘液_表示 = e.粘液下右_粘液_表示;
			this.粘液下右_ハイライト1_表示 = e.粘液下右_ハイライト1_表示;
			this.粘液下右_ハイライト2_表示 = e.粘液下右_ハイライト2_表示;
			this.粘液上左_粘液_表示 = e.粘液上左_粘液_表示;
			this.粘液上左_ハイライト_表示 = e.粘液上左_ハイライト_表示;
			this.粘液上右_粘液_表示 = e.粘液上右_粘液_表示;
			this.粘液上右_ハイライト_表示 = e.粘液上右_ハイライト_表示;
			this.ハイライト_表示 = e.ハイライト_表示;
			this.ハイライト表示 = e.ハイライト表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_粘液0CP = new ColorP(this.X0Y0_粘液0, this.粘液0CD, DisUnit, true);
			this.X0Y0_粘液1CP = new ColorP(this.X0Y0_粘液1, this.粘液1CD, DisUnit, true);
			this.X0Y0_粘液2_粘液CP = new ColorP(this.X0Y0_粘液2_粘液, this.粘液2_粘液CD, DisUnit, true);
			this.X0Y0_粘液2_ハイライト左CP = new ColorP(this.X0Y0_粘液2_ハイライト左, this.粘液2_ハイライト左CD, DisUnit, true);
			this.X0Y0_粘液2_ハイライト右CP = new ColorP(this.X0Y0_粘液2_ハイライト右, this.粘液2_ハイライト右CD, DisUnit, true);
			this.X0Y0_粘液2_ハイライト下1CP = new ColorP(this.X0Y0_粘液2_ハイライト下1, this.粘液2_ハイライト下1CD, DisUnit, true);
			this.X0Y0_粘液2_ハイライト下2CP = new ColorP(this.X0Y0_粘液2_ハイライト下2, this.粘液2_ハイライト下2CD, DisUnit, true);
			this.X0Y0_粘液3_粘液CP = new ColorP(this.X0Y0_粘液3_粘液, this.粘液3_粘液CD, DisUnit, true);
			this.X0Y0_粘液3_ハイライト左上CP = new ColorP(this.X0Y0_粘液3_ハイライト左上, this.粘液3_ハイライト左上CD, DisUnit, true);
			this.X0Y0_粘液3_ハイライト右上CP = new ColorP(this.X0Y0_粘液3_ハイライト右上, this.粘液3_ハイライト右上CD, DisUnit, true);
			this.X0Y0_粘液3_ハイライト左下1CP = new ColorP(this.X0Y0_粘液3_ハイライト左下1, this.粘液3_ハイライト左下1CD, DisUnit, true);
			this.X0Y0_粘液3_ハイライト左下2CP = new ColorP(this.X0Y0_粘液3_ハイライト左下2, this.粘液3_ハイライト左下2CD, DisUnit, true);
			this.X0Y0_粘液3_ハイライト右下1CP = new ColorP(this.X0Y0_粘液3_ハイライト右下1, this.粘液3_ハイライト右下1CD, DisUnit, true);
			this.X0Y0_粘液3_ハイライト右下2CP = new ColorP(this.X0Y0_粘液3_ハイライト右下2, this.粘液3_ハイライト右下2CD, DisUnit, true);
			this.X0Y0_粘液3_ハイライト下1CP = new ColorP(this.X0Y0_粘液3_ハイライト下1, this.粘液3_ハイライト下1CD, DisUnit, true);
			this.X0Y0_粘液3_ハイライト下2CP = new ColorP(this.X0Y0_粘液3_ハイライト下2, this.粘液3_ハイライト下2CD, DisUnit, true);
			this.X0Y0_粘液4_粘液CP = new ColorP(this.X0Y0_粘液4_粘液, this.粘液4_粘液CD, DisUnit, true);
			this.X0Y0_粘液4_ハイライト上1CP = new ColorP(this.X0Y0_粘液4_ハイライト上1, this.粘液4_ハイライト上1CD, DisUnit, true);
			this.X0Y0_粘液4_ハイライト上2CP = new ColorP(this.X0Y0_粘液4_ハイライト上2, this.粘液4_ハイライト上2CD, DisUnit, true);
			this.X0Y0_粘液4_ハイライト下1CP = new ColorP(this.X0Y0_粘液4_ハイライト下1, this.粘液4_ハイライト下1CD, DisUnit, true);
			this.X0Y0_粘液4_ハイライト下2CP = new ColorP(this.X0Y0_粘液4_ハイライト下2, this.粘液4_ハイライト下2CD, DisUnit, true);
			this.X0Y0_粘液下左_粘液CP = new ColorP(this.X0Y0_粘液下左_粘液, this.粘液下左_粘液CD, DisUnit, true);
			this.X0Y0_粘液下左_ハイライト1CP = new ColorP(this.X0Y0_粘液下左_ハイライト1, this.粘液下左_ハイライト1CD, DisUnit, true);
			this.X0Y0_粘液下左_ハイライト2CP = new ColorP(this.X0Y0_粘液下左_ハイライト2, this.粘液下左_ハイライト2CD, DisUnit, true);
			this.X0Y0_粘液下右_粘液CP = new ColorP(this.X0Y0_粘液下右_粘液, this.粘液下右_粘液CD, DisUnit, true);
			this.X0Y0_粘液下右_ハイライト1CP = new ColorP(this.X0Y0_粘液下右_ハイライト1, this.粘液下右_ハイライト1CD, DisUnit, true);
			this.X0Y0_粘液下右_ハイライト2CP = new ColorP(this.X0Y0_粘液下右_ハイライト2, this.粘液下右_ハイライト2CD, DisUnit, true);
			this.X0Y0_粘液上左_粘液CP = new ColorP(this.X0Y0_粘液上左_粘液, this.粘液上左_粘液CD, DisUnit, true);
			this.X0Y0_粘液上左_ハイライトCP = new ColorP(this.X0Y0_粘液上左_ハイライト, this.粘液上左_ハイライトCD, DisUnit, true);
			this.X0Y0_粘液上右_粘液CP = new ColorP(this.X0Y0_粘液上右_粘液, this.粘液上右_粘液CD, DisUnit, true);
			this.X0Y0_粘液上右_ハイライトCP = new ColorP(this.X0Y0_粘液上右_ハイライト, this.粘液上右_ハイライトCD, DisUnit, true);
			this.X0Y0_ハイライトCP = new ColorP(this.X0Y0_ハイライト, this.ハイライトCD, DisUnit, true);
			this.ハイライト濃度 = e.ハイライト濃度;
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

		public bool 粘液0_表示
		{
			get
			{
				return this.X0Y0_粘液0.Dra;
			}
			set
			{
				this.X0Y0_粘液0.Dra = value;
				this.X0Y0_粘液0.Hit = value;
			}
		}

		public bool 粘液1_表示
		{
			get
			{
				return this.X0Y0_粘液1.Dra;
			}
			set
			{
				this.X0Y0_粘液1.Dra = value;
				this.X0Y0_粘液1.Hit = value;
			}
		}

		public bool 粘液2_粘液_表示
		{
			get
			{
				return this.X0Y0_粘液2_粘液.Dra;
			}
			set
			{
				this.X0Y0_粘液2_粘液.Dra = value;
				this.X0Y0_粘液2_粘液.Hit = value;
			}
		}

		public bool 粘液2_ハイライト左_表示
		{
			get
			{
				return this.X0Y0_粘液2_ハイライト左.Dra;
			}
			set
			{
				this.X0Y0_粘液2_ハイライト左.Dra = value;
				this.X0Y0_粘液2_ハイライト左.Hit = value;
			}
		}

		public bool 粘液2_ハイライト右_表示
		{
			get
			{
				return this.X0Y0_粘液2_ハイライト右.Dra;
			}
			set
			{
				this.X0Y0_粘液2_ハイライト右.Dra = value;
				this.X0Y0_粘液2_ハイライト右.Hit = value;
			}
		}

		public bool 粘液2_ハイライト下1_表示
		{
			get
			{
				return this.X0Y0_粘液2_ハイライト下1.Dra;
			}
			set
			{
				this.X0Y0_粘液2_ハイライト下1.Dra = value;
				this.X0Y0_粘液2_ハイライト下1.Hit = value;
			}
		}

		public bool 粘液2_ハイライト下2_表示
		{
			get
			{
				return this.X0Y0_粘液2_ハイライト下2.Dra;
			}
			set
			{
				this.X0Y0_粘液2_ハイライト下2.Dra = value;
				this.X0Y0_粘液2_ハイライト下2.Hit = value;
			}
		}

		public bool 粘液3_粘液_表示
		{
			get
			{
				return this.X0Y0_粘液3_粘液.Dra;
			}
			set
			{
				this.X0Y0_粘液3_粘液.Dra = value;
				this.X0Y0_粘液3_粘液.Hit = value;
			}
		}

		public bool 粘液3_ハイライト左上_表示
		{
			get
			{
				return this.X0Y0_粘液3_ハイライト左上.Dra;
			}
			set
			{
				this.X0Y0_粘液3_ハイライト左上.Dra = value;
				this.X0Y0_粘液3_ハイライト左上.Hit = value;
			}
		}

		public bool 粘液3_ハイライト右上_表示
		{
			get
			{
				return this.X0Y0_粘液3_ハイライト右上.Dra;
			}
			set
			{
				this.X0Y0_粘液3_ハイライト右上.Dra = value;
				this.X0Y0_粘液3_ハイライト右上.Hit = value;
			}
		}

		public bool 粘液3_ハイライト左下1_表示
		{
			get
			{
				return this.X0Y0_粘液3_ハイライト左下1.Dra;
			}
			set
			{
				this.X0Y0_粘液3_ハイライト左下1.Dra = value;
				this.X0Y0_粘液3_ハイライト左下1.Hit = value;
			}
		}

		public bool 粘液3_ハイライト左下2_表示
		{
			get
			{
				return this.X0Y0_粘液3_ハイライト左下2.Dra;
			}
			set
			{
				this.X0Y0_粘液3_ハイライト左下2.Dra = value;
				this.X0Y0_粘液3_ハイライト左下2.Hit = value;
			}
		}

		public bool 粘液3_ハイライト右下1_表示
		{
			get
			{
				return this.X0Y0_粘液3_ハイライト右下1.Dra;
			}
			set
			{
				this.X0Y0_粘液3_ハイライト右下1.Dra = value;
				this.X0Y0_粘液3_ハイライト右下1.Hit = value;
			}
		}

		public bool 粘液3_ハイライト右下2_表示
		{
			get
			{
				return this.X0Y0_粘液3_ハイライト右下2.Dra;
			}
			set
			{
				this.X0Y0_粘液3_ハイライト右下2.Dra = value;
				this.X0Y0_粘液3_ハイライト右下2.Hit = value;
			}
		}

		public bool 粘液3_ハイライト下1_表示
		{
			get
			{
				return this.X0Y0_粘液3_ハイライト下1.Dra;
			}
			set
			{
				this.X0Y0_粘液3_ハイライト下1.Dra = value;
				this.X0Y0_粘液3_ハイライト下1.Hit = value;
			}
		}

		public bool 粘液3_ハイライト下2_表示
		{
			get
			{
				return this.X0Y0_粘液3_ハイライト下2.Dra;
			}
			set
			{
				this.X0Y0_粘液3_ハイライト下2.Dra = value;
				this.X0Y0_粘液3_ハイライト下2.Hit = value;
			}
		}

		public bool 粘液4_粘液_表示
		{
			get
			{
				return this.X0Y0_粘液4_粘液.Dra;
			}
			set
			{
				this.X0Y0_粘液4_粘液.Dra = value;
				this.X0Y0_粘液4_粘液.Hit = value;
			}
		}

		public bool 粘液4_ハイライト上1_表示
		{
			get
			{
				return this.X0Y0_粘液4_ハイライト上1.Dra;
			}
			set
			{
				this.X0Y0_粘液4_ハイライト上1.Dra = value;
				this.X0Y0_粘液4_ハイライト上1.Hit = value;
			}
		}

		public bool 粘液4_ハイライト上2_表示
		{
			get
			{
				return this.X0Y0_粘液4_ハイライト上2.Dra;
			}
			set
			{
				this.X0Y0_粘液4_ハイライト上2.Dra = value;
				this.X0Y0_粘液4_ハイライト上2.Hit = value;
			}
		}

		public bool 粘液4_ハイライト下1_表示
		{
			get
			{
				return this.X0Y0_粘液4_ハイライト下1.Dra;
			}
			set
			{
				this.X0Y0_粘液4_ハイライト下1.Dra = value;
				this.X0Y0_粘液4_ハイライト下1.Hit = value;
			}
		}

		public bool 粘液4_ハイライト下2_表示
		{
			get
			{
				return this.X0Y0_粘液4_ハイライト下2.Dra;
			}
			set
			{
				this.X0Y0_粘液4_ハイライト下2.Dra = value;
				this.X0Y0_粘液4_ハイライト下2.Hit = value;
			}
		}

		public bool 粘液下左_粘液_表示
		{
			get
			{
				return this.X0Y0_粘液下左_粘液.Dra;
			}
			set
			{
				this.X0Y0_粘液下左_粘液.Dra = value;
				this.X0Y0_粘液下左_粘液.Hit = value;
			}
		}

		public bool 粘液下左_ハイライト1_表示
		{
			get
			{
				return this.X0Y0_粘液下左_ハイライト1.Dra;
			}
			set
			{
				this.X0Y0_粘液下左_ハイライト1.Dra = value;
				this.X0Y0_粘液下左_ハイライト1.Hit = value;
			}
		}

		public bool 粘液下左_ハイライト2_表示
		{
			get
			{
				return this.X0Y0_粘液下左_ハイライト2.Dra;
			}
			set
			{
				this.X0Y0_粘液下左_ハイライト2.Dra = value;
				this.X0Y0_粘液下左_ハイライト2.Hit = value;
			}
		}

		public bool 粘液下右_粘液_表示
		{
			get
			{
				return this.X0Y0_粘液下右_粘液.Dra;
			}
			set
			{
				this.X0Y0_粘液下右_粘液.Dra = value;
				this.X0Y0_粘液下右_粘液.Hit = value;
			}
		}

		public bool 粘液下右_ハイライト1_表示
		{
			get
			{
				return this.X0Y0_粘液下右_ハイライト1.Dra;
			}
			set
			{
				this.X0Y0_粘液下右_ハイライト1.Dra = value;
				this.X0Y0_粘液下右_ハイライト1.Hit = value;
			}
		}

		public bool 粘液下右_ハイライト2_表示
		{
			get
			{
				return this.X0Y0_粘液下右_ハイライト2.Dra;
			}
			set
			{
				this.X0Y0_粘液下右_ハイライト2.Dra = value;
				this.X0Y0_粘液下右_ハイライト2.Hit = value;
			}
		}

		public bool 粘液上左_粘液_表示
		{
			get
			{
				return this.X0Y0_粘液上左_粘液.Dra;
			}
			set
			{
				this.X0Y0_粘液上左_粘液.Dra = value;
				this.X0Y0_粘液上左_粘液.Hit = value;
			}
		}

		public bool 粘液上左_ハイライト_表示
		{
			get
			{
				return this.X0Y0_粘液上左_ハイライト.Dra;
			}
			set
			{
				this.X0Y0_粘液上左_ハイライト.Dra = value;
				this.X0Y0_粘液上左_ハイライト.Hit = value;
			}
		}

		public bool 粘液上右_粘液_表示
		{
			get
			{
				return this.X0Y0_粘液上右_粘液.Dra;
			}
			set
			{
				this.X0Y0_粘液上右_粘液.Dra = value;
				this.X0Y0_粘液上右_粘液.Hit = value;
			}
		}

		public bool 粘液上右_ハイライト_表示
		{
			get
			{
				return this.X0Y0_粘液上右_ハイライト.Dra;
			}
			set
			{
				this.X0Y0_粘液上右_ハイライト.Dra = value;
				this.X0Y0_粘液上右_ハイライト.Hit = value;
			}
		}

		public bool ハイライト_表示
		{
			get
			{
				return this.X0Y0_ハイライト.Dra;
			}
			set
			{
				this.X0Y0_ハイライト.Dra = value;
				this.X0Y0_ハイライト.Hit = value;
			}
		}

		public bool ハイライト表示
		{
			get
			{
				return this.粘液2_ハイライト左_表示;
			}
			set
			{
				this.粘液2_ハイライト左_表示 = value;
				this.粘液2_ハイライト右_表示 = value;
				this.粘液2_ハイライト下1_表示 = value;
				this.粘液2_ハイライト下2_表示 = value;
				this.粘液3_ハイライト左上_表示 = value;
				this.粘液3_ハイライト右上_表示 = value;
				this.粘液3_ハイライト左下1_表示 = value;
				this.粘液3_ハイライト左下2_表示 = value;
				this.粘液3_ハイライト右下1_表示 = value;
				this.粘液3_ハイライト右下2_表示 = value;
				this.粘液3_ハイライト下1_表示 = value;
				this.粘液3_ハイライト下2_表示 = value;
				this.粘液4_ハイライト上1_表示 = value;
				this.粘液4_ハイライト上2_表示 = value;
				this.粘液4_ハイライト下1_表示 = value;
				this.粘液4_ハイライト下2_表示 = value;
				this.粘液下左_ハイライト1_表示 = value;
				this.粘液下左_ハイライト2_表示 = value;
				this.粘液下右_ハイライト1_表示 = value;
				this.粘液下右_ハイライト2_表示 = value;
				this.粘液上左_ハイライト_表示 = value;
				this.粘液上右_ハイライト_表示 = value;
				this.ハイライト_表示 = value;
			}
		}

		public double ハイライト濃度
		{
			get
			{
				return this.粘液2_ハイライト左CD.不透明度;
			}
			set
			{
				this.粘液2_ハイライト左CD.不透明度 = value;
				this.粘液2_ハイライト右CD.不透明度 = value;
				this.粘液2_ハイライト下1CD.不透明度 = value;
				this.粘液2_ハイライト下2CD.不透明度 = value;
				this.粘液3_ハイライト左上CD.不透明度 = value;
				this.粘液3_ハイライト右上CD.不透明度 = value;
				this.粘液3_ハイライト左下1CD.不透明度 = value;
				this.粘液3_ハイライト左下2CD.不透明度 = value;
				this.粘液3_ハイライト右下1CD.不透明度 = value;
				this.粘液3_ハイライト右下2CD.不透明度 = value;
				this.粘液3_ハイライト下1CD.不透明度 = value;
				this.粘液3_ハイライト下2CD.不透明度 = value;
				this.粘液4_ハイライト上1CD.不透明度 = value;
				this.粘液4_ハイライト上2CD.不透明度 = value;
				this.粘液4_ハイライト下1CD.不透明度 = value;
				this.粘液4_ハイライト下2CD.不透明度 = value;
				this.粘液下左_ハイライト1CD.不透明度 = value;
				this.粘液下左_ハイライト2CD.不透明度 = value;
				this.粘液下右_ハイライト1CD.不透明度 = value;
				this.粘液下右_ハイライト2CD.不透明度 = value;
				this.粘液上左_ハイライトCD.不透明度 = value;
				this.粘液上右_ハイライトCD.不透明度 = value;
				this.ハイライトCD.不透明度 = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.粘液0_表示;
			}
			set
			{
				this.粘液0_表示 = value;
				this.粘液1_表示 = value;
				this.粘液2_粘液_表示 = value;
				this.粘液2_ハイライト左_表示 = value;
				this.粘液2_ハイライト右_表示 = value;
				this.粘液2_ハイライト下1_表示 = value;
				this.粘液2_ハイライト下2_表示 = value;
				this.粘液3_粘液_表示 = value;
				this.粘液3_ハイライト左上_表示 = value;
				this.粘液3_ハイライト右上_表示 = value;
				this.粘液3_ハイライト左下1_表示 = value;
				this.粘液3_ハイライト左下2_表示 = value;
				this.粘液3_ハイライト右下1_表示 = value;
				this.粘液3_ハイライト右下2_表示 = value;
				this.粘液3_ハイライト下1_表示 = value;
				this.粘液3_ハイライト下2_表示 = value;
				this.粘液4_粘液_表示 = value;
				this.粘液4_ハイライト上1_表示 = value;
				this.粘液4_ハイライト上2_表示 = value;
				this.粘液4_ハイライト下1_表示 = value;
				this.粘液4_ハイライト下2_表示 = value;
				this.粘液下左_粘液_表示 = value;
				this.粘液下左_ハイライト1_表示 = value;
				this.粘液下左_ハイライト2_表示 = value;
				this.粘液下右_粘液_表示 = value;
				this.粘液下右_ハイライト1_表示 = value;
				this.粘液下右_ハイライト2_表示 = value;
				this.粘液上左_粘液_表示 = value;
				this.粘液上左_ハイライト_表示 = value;
				this.粘液上右_粘液_表示 = value;
				this.粘液上右_ハイライト_表示 = value;
				this.ハイライト_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.粘液0CD.不透明度;
			}
			set
			{
				this.粘液0CD.不透明度 = value;
				this.粘液1CD.不透明度 = value;
				this.粘液2_粘液CD.不透明度 = value;
				this.粘液2_ハイライト左CD.不透明度 = value;
				this.粘液2_ハイライト右CD.不透明度 = value;
				this.粘液2_ハイライト下1CD.不透明度 = value;
				this.粘液2_ハイライト下2CD.不透明度 = value;
				this.粘液3_粘液CD.不透明度 = value;
				this.粘液3_ハイライト左上CD.不透明度 = value;
				this.粘液3_ハイライト右上CD.不透明度 = value;
				this.粘液3_ハイライト左下1CD.不透明度 = value;
				this.粘液3_ハイライト左下2CD.不透明度 = value;
				this.粘液3_ハイライト右下1CD.不透明度 = value;
				this.粘液3_ハイライト右下2CD.不透明度 = value;
				this.粘液3_ハイライト下1CD.不透明度 = value;
				this.粘液3_ハイライト下2CD.不透明度 = value;
				this.粘液4_粘液CD.不透明度 = value;
				this.粘液4_ハイライト上1CD.不透明度 = value;
				this.粘液4_ハイライト上2CD.不透明度 = value;
				this.粘液4_ハイライト下1CD.不透明度 = value;
				this.粘液4_ハイライト下2CD.不透明度 = value;
				this.粘液下左_粘液CD.不透明度 = value;
				this.粘液下左_ハイライト1CD.不透明度 = value;
				this.粘液下左_ハイライト2CD.不透明度 = value;
				this.粘液下右_粘液CD.不透明度 = value;
				this.粘液下右_ハイライト1CD.不透明度 = value;
				this.粘液下右_ハイライト2CD.不透明度 = value;
				this.粘液上左_粘液CD.不透明度 = value;
				this.粘液上左_ハイライトCD.不透明度 = value;
				this.粘液上右_粘液CD.不透明度 = value;
				this.粘液上右_ハイライトCD.不透明度 = value;
				this.ハイライトCD.不透明度 = value;
			}
		}

		public override void 色更新()
		{
			this.X0Y0_粘液0CP.Update();
			this.X0Y0_粘液1CP.Update();
			this.X0Y0_粘液2_粘液CP.Update();
			this.X0Y0_粘液2_ハイライト左CP.Update();
			this.X0Y0_粘液2_ハイライト右CP.Update();
			this.X0Y0_粘液2_ハイライト下1CP.Update();
			this.X0Y0_粘液2_ハイライト下2CP.Update();
			this.X0Y0_粘液3_粘液CP.Update();
			this.X0Y0_粘液3_ハイライト左上CP.Update();
			this.X0Y0_粘液3_ハイライト右上CP.Update();
			this.X0Y0_粘液3_ハイライト左下1CP.Update();
			this.X0Y0_粘液3_ハイライト左下2CP.Update();
			this.X0Y0_粘液3_ハイライト右下1CP.Update();
			this.X0Y0_粘液3_ハイライト右下2CP.Update();
			this.X0Y0_粘液3_ハイライト下1CP.Update();
			this.X0Y0_粘液3_ハイライト下2CP.Update();
			this.X0Y0_粘液4_粘液CP.Update();
			this.X0Y0_粘液4_ハイライト上1CP.Update();
			this.X0Y0_粘液4_ハイライト上2CP.Update();
			this.X0Y0_粘液4_ハイライト下1CP.Update();
			this.X0Y0_粘液4_ハイライト下2CP.Update();
			this.X0Y0_粘液下左_粘液CP.Update();
			this.X0Y0_粘液下左_ハイライト1CP.Update();
			this.X0Y0_粘液下左_ハイライト2CP.Update();
			this.X0Y0_粘液下右_粘液CP.Update();
			this.X0Y0_粘液下右_ハイライト1CP.Update();
			this.X0Y0_粘液下右_ハイライト2CP.Update();
			this.X0Y0_粘液上左_粘液CP.Update();
			this.X0Y0_粘液上左_ハイライトCP.Update();
			this.X0Y0_粘液上右_粘液CP.Update();
			this.X0Y0_粘液上右_ハイライトCP.Update();
			this.X0Y0_ハイライトCP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			Color2 color;
			Col.Alpha(ref 体配色.人肌O, 128, out color);
			this.粘液0CD = new ColorD(ref Col.Empty, ref color);
			this.粘液1CD = new ColorD(ref Col.Empty, ref color);
			this.粘液2_粘液CD = new ColorD(ref Col.Empty, ref color);
			this.粘液2_ハイライト左CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.粘液2_ハイライト右CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.粘液2_ハイライト下1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.粘液2_ハイライト下2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.粘液3_粘液CD = new ColorD(ref Col.Empty, ref color);
			this.粘液3_ハイライト左上CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.粘液3_ハイライト右上CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.粘液3_ハイライト左下1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.粘液3_ハイライト左下2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.粘液3_ハイライト右下1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.粘液3_ハイライト右下2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.粘液3_ハイライト下1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.粘液3_ハイライト下2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.粘液4_粘液CD = new ColorD(ref Col.Empty, ref color);
			this.粘液4_ハイライト上1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.粘液4_ハイライト上2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.粘液4_ハイライト下1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.粘液4_ハイライト下2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			color.GetRep(out color);
			this.粘液下左_粘液CD = new ColorD(ref Col.Empty, ref color);
			this.粘液下左_ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.粘液下左_ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.粘液下右_粘液CD = new ColorD(ref Col.Empty, ref color);
			this.粘液下右_ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.粘液下右_ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.粘液上左_粘液CD = new ColorD(ref Col.Empty, ref color);
			this.粘液上左_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.粘液上右_粘液CD = new ColorD(ref Col.Empty, ref color);
			this.粘液上右_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
		}

		public Par X0Y0_粘液0;

		public Par X0Y0_粘液1;

		public Par X0Y0_粘液2_粘液;

		public Par X0Y0_粘液2_ハイライト左;

		public Par X0Y0_粘液2_ハイライト右;

		public Par X0Y0_粘液2_ハイライト下1;

		public Par X0Y0_粘液2_ハイライト下2;

		public Par X0Y0_粘液3_粘液;

		public Par X0Y0_粘液3_ハイライト左上;

		public Par X0Y0_粘液3_ハイライト右上;

		public Par X0Y0_粘液3_ハイライト左下1;

		public Par X0Y0_粘液3_ハイライト左下2;

		public Par X0Y0_粘液3_ハイライト右下1;

		public Par X0Y0_粘液3_ハイライト右下2;

		public Par X0Y0_粘液3_ハイライト下1;

		public Par X0Y0_粘液3_ハイライト下2;

		public Par X0Y0_粘液4_粘液;

		public Par X0Y0_粘液4_ハイライト上1;

		public Par X0Y0_粘液4_ハイライト上2;

		public Par X0Y0_粘液4_ハイライト下1;

		public Par X0Y0_粘液4_ハイライト下2;

		public Par X0Y0_粘液下左_粘液;

		public Par X0Y0_粘液下左_ハイライト1;

		public Par X0Y0_粘液下左_ハイライト2;

		public Par X0Y0_粘液下右_粘液;

		public Par X0Y0_粘液下右_ハイライト1;

		public Par X0Y0_粘液下右_ハイライト2;

		public Par X0Y0_粘液上左_粘液;

		public Par X0Y0_粘液上左_ハイライト;

		public Par X0Y0_粘液上右_粘液;

		public Par X0Y0_粘液上右_ハイライト;

		public Par X0Y0_ハイライト;

		public ColorD 粘液0CD;

		public ColorD 粘液1CD;

		public ColorD 粘液2_粘液CD;

		public ColorD 粘液2_ハイライト左CD;

		public ColorD 粘液2_ハイライト右CD;

		public ColorD 粘液2_ハイライト下1CD;

		public ColorD 粘液2_ハイライト下2CD;

		public ColorD 粘液3_粘液CD;

		public ColorD 粘液3_ハイライト左上CD;

		public ColorD 粘液3_ハイライト右上CD;

		public ColorD 粘液3_ハイライト左下1CD;

		public ColorD 粘液3_ハイライト左下2CD;

		public ColorD 粘液3_ハイライト右下1CD;

		public ColorD 粘液3_ハイライト右下2CD;

		public ColorD 粘液3_ハイライト下1CD;

		public ColorD 粘液3_ハイライト下2CD;

		public ColorD 粘液4_粘液CD;

		public ColorD 粘液4_ハイライト上1CD;

		public ColorD 粘液4_ハイライト上2CD;

		public ColorD 粘液4_ハイライト下1CD;

		public ColorD 粘液4_ハイライト下2CD;

		public ColorD 粘液下左_粘液CD;

		public ColorD 粘液下左_ハイライト1CD;

		public ColorD 粘液下左_ハイライト2CD;

		public ColorD 粘液下右_粘液CD;

		public ColorD 粘液下右_ハイライト1CD;

		public ColorD 粘液下右_ハイライト2CD;

		public ColorD 粘液上左_粘液CD;

		public ColorD 粘液上左_ハイライトCD;

		public ColorD 粘液上右_粘液CD;

		public ColorD 粘液上右_ハイライトCD;

		public ColorD ハイライトCD;

		public ColorP X0Y0_粘液0CP;

		public ColorP X0Y0_粘液1CP;

		public ColorP X0Y0_粘液2_粘液CP;

		public ColorP X0Y0_粘液2_ハイライト左CP;

		public ColorP X0Y0_粘液2_ハイライト右CP;

		public ColorP X0Y0_粘液2_ハイライト下1CP;

		public ColorP X0Y0_粘液2_ハイライト下2CP;

		public ColorP X0Y0_粘液3_粘液CP;

		public ColorP X0Y0_粘液3_ハイライト左上CP;

		public ColorP X0Y0_粘液3_ハイライト右上CP;

		public ColorP X0Y0_粘液3_ハイライト左下1CP;

		public ColorP X0Y0_粘液3_ハイライト左下2CP;

		public ColorP X0Y0_粘液3_ハイライト右下1CP;

		public ColorP X0Y0_粘液3_ハイライト右下2CP;

		public ColorP X0Y0_粘液3_ハイライト下1CP;

		public ColorP X0Y0_粘液3_ハイライト下2CP;

		public ColorP X0Y0_粘液4_粘液CP;

		public ColorP X0Y0_粘液4_ハイライト上1CP;

		public ColorP X0Y0_粘液4_ハイライト上2CP;

		public ColorP X0Y0_粘液4_ハイライト下1CP;

		public ColorP X0Y0_粘液4_ハイライト下2CP;

		public ColorP X0Y0_粘液下左_粘液CP;

		public ColorP X0Y0_粘液下左_ハイライト1CP;

		public ColorP X0Y0_粘液下左_ハイライト2CP;

		public ColorP X0Y0_粘液下右_粘液CP;

		public ColorP X0Y0_粘液下右_ハイライト1CP;

		public ColorP X0Y0_粘液下右_ハイライト2CP;

		public ColorP X0Y0_粘液上左_粘液CP;

		public ColorP X0Y0_粘液上左_ハイライトCP;

		public ColorP X0Y0_粘液上右_粘液CP;

		public ColorP X0Y0_粘液上右_ハイライトCP;

		public ColorP X0Y0_ハイライトCP;
	}
}
