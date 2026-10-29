using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 鼻肌 : Ele
	{
		public 鼻肌(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 鼻肌D e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.胴体["鼻肌"]);
			Pars pars = this.本体[0][0];
			Pars pars2 = pars["紋柄"].ToPars();
			Pars pars3 = pars2["紋左"].ToPars();
			this.X0Y0_紋柄_紋左_紋1 = pars3["紋1"].ToPar();
			this.X0Y0_紋柄_紋左_紋2 = pars3["紋2"].ToPar();
			this.X0Y0_紋柄_紋左_紋3 = pars3["紋3"].ToPar();
			this.X0Y0_紋柄_紋左_紋4 = pars3["紋4"].ToPar();
			this.X0Y0_紋柄_紋左_紋5 = pars3["紋5"].ToPar();
			pars3 = pars2["紋右"].ToPars();
			this.X0Y0_紋柄_紋右_紋1 = pars3["紋1"].ToPar();
			this.X0Y0_紋柄_紋右_紋2 = pars3["紋2"].ToPar();
			this.X0Y0_紋柄_紋右_紋3 = pars3["紋3"].ToPar();
			this.X0Y0_紋柄_紋右_紋4 = pars3["紋4"].ToPar();
			this.X0Y0_紋柄_紋右_紋5 = pars3["紋5"].ToPar();
			this.X0Y0_傷I = pars["傷I"].ToPar();
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
			this.紋柄_紋左_紋1_表示 = e.紋柄_紋左_紋1_表示;
			this.紋柄_紋左_紋2_表示 = e.紋柄_紋左_紋2_表示;
			this.紋柄_紋左_紋3_表示 = e.紋柄_紋左_紋3_表示;
			this.紋柄_紋左_紋4_表示 = e.紋柄_紋左_紋4_表示;
			this.紋柄_紋左_紋5_表示 = e.紋柄_紋左_紋5_表示;
			this.紋柄_紋右_紋1_表示 = e.紋柄_紋右_紋1_表示;
			this.紋柄_紋右_紋2_表示 = e.紋柄_紋右_紋2_表示;
			this.紋柄_紋右_紋3_表示 = e.紋柄_紋右_紋3_表示;
			this.紋柄_紋右_紋4_表示 = e.紋柄_紋右_紋4_表示;
			this.紋柄_紋右_紋5_表示 = e.紋柄_紋右_紋5_表示;
			this.傷I_表示 = e.傷I_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_紋柄_紋左_紋1CP = new ColorP(this.X0Y0_紋柄_紋左_紋1, this.紋柄_紋左_紋1CD, DisUnit, true);
			this.X0Y0_紋柄_紋左_紋2CP = new ColorP(this.X0Y0_紋柄_紋左_紋2, this.紋柄_紋左_紋2CD, DisUnit, true);
			this.X0Y0_紋柄_紋左_紋3CP = new ColorP(this.X0Y0_紋柄_紋左_紋3, this.紋柄_紋左_紋3CD, DisUnit, true);
			this.X0Y0_紋柄_紋左_紋4CP = new ColorP(this.X0Y0_紋柄_紋左_紋4, this.紋柄_紋左_紋4CD, DisUnit, true);
			this.X0Y0_紋柄_紋左_紋5CP = new ColorP(this.X0Y0_紋柄_紋左_紋5, this.紋柄_紋左_紋5CD, DisUnit, true);
			this.X0Y0_紋柄_紋右_紋1CP = new ColorP(this.X0Y0_紋柄_紋右_紋1, this.紋柄_紋右_紋1CD, DisUnit, true);
			this.X0Y0_紋柄_紋右_紋2CP = new ColorP(this.X0Y0_紋柄_紋右_紋2, this.紋柄_紋右_紋2CD, DisUnit, true);
			this.X0Y0_紋柄_紋右_紋3CP = new ColorP(this.X0Y0_紋柄_紋右_紋3, this.紋柄_紋右_紋3CD, DisUnit, true);
			this.X0Y0_紋柄_紋右_紋4CP = new ColorP(this.X0Y0_紋柄_紋右_紋4, this.紋柄_紋右_紋4CD, DisUnit, true);
			this.X0Y0_紋柄_紋右_紋5CP = new ColorP(this.X0Y0_紋柄_紋右_紋5, this.紋柄_紋右_紋5CD, DisUnit, true);
			this.X0Y0_傷ICP = new ColorP(this.X0Y0_傷I, this.傷ICD, DisUnit, true);
			this.傷I右濃度 = e.傷I右濃度;
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

		public bool 紋柄_紋左_紋1_表示
		{
			get
			{
				return this.X0Y0_紋柄_紋左_紋1.Dra;
			}
			set
			{
				this.X0Y0_紋柄_紋左_紋1.Dra = value;
				this.X0Y0_紋柄_紋左_紋1.Hit = value;
			}
		}

		public bool 紋柄_紋左_紋2_表示
		{
			get
			{
				return this.X0Y0_紋柄_紋左_紋2.Dra;
			}
			set
			{
				this.X0Y0_紋柄_紋左_紋2.Dra = value;
				this.X0Y0_紋柄_紋左_紋2.Hit = value;
			}
		}

		public bool 紋柄_紋左_紋3_表示
		{
			get
			{
				return this.X0Y0_紋柄_紋左_紋3.Dra;
			}
			set
			{
				this.X0Y0_紋柄_紋左_紋3.Dra = value;
				this.X0Y0_紋柄_紋左_紋3.Hit = value;
			}
		}

		public bool 紋柄_紋左_紋4_表示
		{
			get
			{
				return this.X0Y0_紋柄_紋左_紋4.Dra;
			}
			set
			{
				this.X0Y0_紋柄_紋左_紋4.Dra = value;
				this.X0Y0_紋柄_紋左_紋4.Hit = value;
			}
		}

		public bool 紋柄_紋左_紋5_表示
		{
			get
			{
				return this.X0Y0_紋柄_紋左_紋5.Dra;
			}
			set
			{
				this.X0Y0_紋柄_紋左_紋5.Dra = value;
				this.X0Y0_紋柄_紋左_紋5.Hit = value;
			}
		}

		public bool 紋柄_紋右_紋1_表示
		{
			get
			{
				return this.X0Y0_紋柄_紋右_紋1.Dra;
			}
			set
			{
				this.X0Y0_紋柄_紋右_紋1.Dra = value;
				this.X0Y0_紋柄_紋右_紋1.Hit = value;
			}
		}

		public bool 紋柄_紋右_紋2_表示
		{
			get
			{
				return this.X0Y0_紋柄_紋右_紋2.Dra;
			}
			set
			{
				this.X0Y0_紋柄_紋右_紋2.Dra = value;
				this.X0Y0_紋柄_紋右_紋2.Hit = value;
			}
		}

		public bool 紋柄_紋右_紋3_表示
		{
			get
			{
				return this.X0Y0_紋柄_紋右_紋3.Dra;
			}
			set
			{
				this.X0Y0_紋柄_紋右_紋3.Dra = value;
				this.X0Y0_紋柄_紋右_紋3.Hit = value;
			}
		}

		public bool 紋柄_紋右_紋4_表示
		{
			get
			{
				return this.X0Y0_紋柄_紋右_紋4.Dra;
			}
			set
			{
				this.X0Y0_紋柄_紋右_紋4.Dra = value;
				this.X0Y0_紋柄_紋右_紋4.Hit = value;
			}
		}

		public bool 紋柄_紋右_紋5_表示
		{
			get
			{
				return this.X0Y0_紋柄_紋右_紋5.Dra;
			}
			set
			{
				this.X0Y0_紋柄_紋右_紋5.Dra = value;
				this.X0Y0_紋柄_紋右_紋5.Hit = value;
			}
		}

		public bool 傷I_表示
		{
			get
			{
				return this.X0Y0_傷I.Dra;
			}
			set
			{
				this.X0Y0_傷I.Dra = value;
				this.X0Y0_傷I.Hit = value;
			}
		}

		public double 傷I右濃度
		{
			get
			{
				return this.傷ICD.不透明度;
			}
			set
			{
				this.傷ICD.不透明度 = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.紋柄_紋左_紋1_表示;
			}
			set
			{
				this.紋柄_紋左_紋1_表示 = value;
				this.紋柄_紋左_紋2_表示 = value;
				this.紋柄_紋左_紋3_表示 = value;
				this.紋柄_紋左_紋4_表示 = value;
				this.紋柄_紋左_紋5_表示 = value;
				this.紋柄_紋右_紋1_表示 = value;
				this.紋柄_紋右_紋2_表示 = value;
				this.紋柄_紋右_紋3_表示 = value;
				this.紋柄_紋右_紋4_表示 = value;
				this.紋柄_紋右_紋5_表示 = value;
				this.傷I_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.紋柄_紋左_紋1CD.不透明度;
			}
			set
			{
				this.紋柄_紋左_紋1CD.不透明度 = value;
				this.紋柄_紋左_紋2CD.不透明度 = value;
				this.紋柄_紋左_紋3CD.不透明度 = value;
				this.紋柄_紋左_紋4CD.不透明度 = value;
				this.紋柄_紋左_紋5CD.不透明度 = value;
				this.紋柄_紋右_紋1CD.不透明度 = value;
				this.紋柄_紋右_紋2CD.不透明度 = value;
				this.紋柄_紋右_紋3CD.不透明度 = value;
				this.紋柄_紋右_紋4CD.不透明度 = value;
				this.紋柄_紋右_紋5CD.不透明度 = value;
				this.傷ICD.不透明度 = value;
			}
		}

		public override void 色更新()
		{
			this.X0Y0_紋柄_紋左_紋1CP.Update();
			this.X0Y0_紋柄_紋左_紋2CP.Update();
			this.X0Y0_紋柄_紋左_紋3CP.Update();
			this.X0Y0_紋柄_紋左_紋4CP.Update();
			this.X0Y0_紋柄_紋左_紋5CP.Update();
			this.X0Y0_紋柄_紋右_紋1CP.Update();
			this.X0Y0_紋柄_紋右_紋2CP.Update();
			this.X0Y0_紋柄_紋右_紋3CP.Update();
			this.X0Y0_紋柄_紋右_紋4CP.Update();
			this.X0Y0_紋柄_紋右_紋5CP.Update();
			this.X0Y0_傷ICP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.紋柄_紋左_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋左_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋左_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋左_紋4CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋左_紋5CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋右_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋右_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋右_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋右_紋4CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋右_紋5CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.傷ICD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
		}

		public Par X0Y0_紋柄_紋左_紋1;

		public Par X0Y0_紋柄_紋左_紋2;

		public Par X0Y0_紋柄_紋左_紋3;

		public Par X0Y0_紋柄_紋左_紋4;

		public Par X0Y0_紋柄_紋左_紋5;

		public Par X0Y0_紋柄_紋右_紋1;

		public Par X0Y0_紋柄_紋右_紋2;

		public Par X0Y0_紋柄_紋右_紋3;

		public Par X0Y0_紋柄_紋右_紋4;

		public Par X0Y0_紋柄_紋右_紋5;

		public Par X0Y0_傷I;

		public ColorD 紋柄_紋左_紋1CD;

		public ColorD 紋柄_紋左_紋2CD;

		public ColorD 紋柄_紋左_紋3CD;

		public ColorD 紋柄_紋左_紋4CD;

		public ColorD 紋柄_紋左_紋5CD;

		public ColorD 紋柄_紋右_紋1CD;

		public ColorD 紋柄_紋右_紋2CD;

		public ColorD 紋柄_紋右_紋3CD;

		public ColorD 紋柄_紋右_紋4CD;

		public ColorD 紋柄_紋右_紋5CD;

		public ColorD 傷ICD;

		public ColorP X0Y0_紋柄_紋左_紋1CP;

		public ColorP X0Y0_紋柄_紋左_紋2CP;

		public ColorP X0Y0_紋柄_紋左_紋3CP;

		public ColorP X0Y0_紋柄_紋左_紋4CP;

		public ColorP X0Y0_紋柄_紋左_紋5CP;

		public ColorP X0Y0_紋柄_紋右_紋1CP;

		public ColorP X0Y0_紋柄_紋右_紋2CP;

		public ColorP X0Y0_紋柄_紋右_紋3CP;

		public ColorP X0Y0_紋柄_紋右_紋4CP;

		public ColorP X0Y0_紋柄_紋右_紋5CP;

		public ColorP X0Y0_傷ICP;
	}
}
