using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 上着トップ_ドレス : 上着トップ
	{
		public 上着トップ_ドレス(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 上着トップ_ドレスD e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif(Sta.胴体["上着トップ"][2]);
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_服基 = pars["服基"].ToPar();
			Pars pars2 = pars["紐"].ToPars();
			Pars pars3 = pars2["紐1"].ToPars();
			Pars pars4 = pars3["紐下"].ToPars();
			this.X0Y0_紐_紐1_紐下_紐 = pars4["紐"].ToPar();
			pars4 = pars3["紐上"].ToPars();
			this.X0Y0_紐_紐1_紐上_紐 = pars4["紐"].ToPar();
			pars3 = pars2["紐2"].ToPars();
			pars4 = pars3["紐下"].ToPars();
			this.X0Y0_紐_紐2_紐下_紐 = pars4["紐"].ToPar();
			pars4 = pars3["紐上"].ToPars();
			this.X0Y0_紐_紐2_紐上_紐 = pars4["紐"].ToPar();
			pars3 = pars2["紐3"].ToPars();
			pars4 = pars3["紐下"].ToPars();
			this.X0Y0_紐_紐3_紐下_紐 = pars4["紐"].ToPar();
			pars4 = pars3["紐上"].ToPars();
			this.X0Y0_紐_紐3_紐上_紐 = pars4["紐"].ToPar();
			pars3 = pars2["紐4"].ToPars();
			pars4 = pars3["紐下"].ToPars();
			this.X0Y0_紐_紐4_紐下_紐 = pars4["紐"].ToPar();
			pars4 = pars3["紐上"].ToPars();
			this.X0Y0_紐_紐4_紐上_紐 = pars4["紐"].ToPar();
			pars3 = pars2["紐5"].ToPars();
			pars4 = pars3["紐下"].ToPars();
			this.X0Y0_紐_紐5_紐下_紐 = pars4["紐"].ToPar();
			pars4 = pars3["紐上"].ToPars();
			this.X0Y0_紐_紐5_紐上_紐 = pars4["紐"].ToPar();
			pars3 = pars2["紐6"].ToPars();
			pars4 = pars3["紐下"].ToPars();
			this.X0Y0_紐_紐6_紐下_紐 = pars4["紐"].ToPar();
			pars4 = pars3["紐上"].ToPars();
			this.X0Y0_紐_紐6_紐上_紐 = pars4["紐"].ToPar();
			pars2 = pars["左"].ToPars();
			this.X0Y0_左_服 = pars2["服"].ToPar();
			pars3 = pars2["柄"].ToPars();
			this.X0Y0_左_柄_柄1 = pars3["柄1"].ToPar();
			this.X0Y0_左_柄_柄2 = pars3["柄2"].ToPar();
			this.X0Y0_左_バスト = pars2["バスト"].ToPar();
			this.X0Y0_左_縁 = pars2["縁"].ToPar();
			pars2 = pars["右"].ToPars();
			this.X0Y0_右_服 = pars2["服"].ToPar();
			pars3 = pars2["柄"].ToPars();
			this.X0Y0_右_柄_柄1 = pars3["柄1"].ToPar();
			this.X0Y0_右_柄_柄2 = pars3["柄2"].ToPar();
			this.X0Y0_右_バスト = pars2["バスト"].ToPar();
			this.X0Y0_右_縁 = pars2["縁"].ToPar();
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
			this.尺度YB = 0.95;
			this.sb = this.尺度B;
			this.syb = this.尺度YB;
			this.肥大 = e.肥大;
			this.身長 = e.身長;
			this.Xv = e.Xv;
			this.Yv = e.Yv;
			this.Xi = e.Xi;
			this.Yi = e.Yi;
			this.サイズ = e.サイズ;
			this.サイズX = e.サイズX;
			this.サイズY = e.サイズY;
			this.服基_表示 = e.服基_表示;
			this.紐_紐1_紐下_紐_表示 = e.紐_紐1_紐下_紐_表示;
			this.紐_紐1_紐上_紐_表示 = e.紐_紐1_紐上_紐_表示;
			this.紐_紐2_紐下_紐_表示 = e.紐_紐2_紐下_紐_表示;
			this.紐_紐2_紐上_紐_表示 = e.紐_紐2_紐上_紐_表示;
			this.紐_紐3_紐下_紐_表示 = e.紐_紐3_紐下_紐_表示;
			this.紐_紐3_紐上_紐_表示 = e.紐_紐3_紐上_紐_表示;
			this.紐_紐4_紐下_紐_表示 = e.紐_紐4_紐下_紐_表示;
			this.紐_紐4_紐上_紐_表示 = e.紐_紐4_紐上_紐_表示;
			this.紐_紐5_紐下_紐_表示 = e.紐_紐5_紐下_紐_表示;
			this.紐_紐5_紐上_紐_表示 = e.紐_紐5_紐上_紐_表示;
			this.紐_紐6_紐下_紐_表示 = e.紐_紐6_紐下_紐_表示;
			this.紐_紐6_紐上_紐_表示 = e.紐_紐6_紐上_紐_表示;
			this.左_服_表示 = e.左_服_表示;
			this.左_柄_柄1_表示 = e.左_柄_柄1_表示;
			this.左_柄_柄2_表示 = e.左_柄_柄2_表示;
			this.左_バスト_表示 = e.左_バスト_表示;
			this.左_縁_表示 = e.左_縁_表示;
			this.右_服_表示 = e.右_服_表示;
			this.右_柄_柄1_表示 = e.右_柄_柄1_表示;
			this.右_柄_柄2_表示 = e.右_柄_柄2_表示;
			this.右_バスト_表示 = e.右_バスト_表示;
			this.右_縁_表示 = e.右_縁_表示;
			this.ベ\u30FCス表示 = e.ベ\u30FCス表示;
			this.紐1表示 = e.紐1表示;
			this.紐2表示 = e.紐2表示;
			this.紐3表示 = e.紐3表示;
			this.紐4表示 = e.紐4表示;
			this.紐5表示 = e.紐5表示;
			this.紐6表示 = e.紐6表示;
			this.縁表示 = e.縁表示;
			this.柄1表示 = e.柄1表示;
			this.柄2表示 = e.柄2表示;
			this.バスト = e.バスト;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_服基CP = new ColorP(this.X0Y0_服基, this.服基CD, DisUnit, true);
			this.X0Y0_紐_紐1_紐下_紐CP = new ColorP(this.X0Y0_紐_紐1_紐下_紐, this.紐_紐1_紐下_紐CD, DisUnit, true);
			this.X0Y0_紐_紐1_紐上_紐CP = new ColorP(this.X0Y0_紐_紐1_紐上_紐, this.紐_紐1_紐上_紐CD, DisUnit, true);
			this.X0Y0_紐_紐2_紐下_紐CP = new ColorP(this.X0Y0_紐_紐2_紐下_紐, this.紐_紐2_紐下_紐CD, DisUnit, true);
			this.X0Y0_紐_紐2_紐上_紐CP = new ColorP(this.X0Y0_紐_紐2_紐上_紐, this.紐_紐2_紐上_紐CD, DisUnit, true);
			this.X0Y0_紐_紐3_紐下_紐CP = new ColorP(this.X0Y0_紐_紐3_紐下_紐, this.紐_紐3_紐下_紐CD, DisUnit, true);
			this.X0Y0_紐_紐3_紐上_紐CP = new ColorP(this.X0Y0_紐_紐3_紐上_紐, this.紐_紐3_紐上_紐CD, DisUnit, true);
			this.X0Y0_紐_紐4_紐下_紐CP = new ColorP(this.X0Y0_紐_紐4_紐下_紐, this.紐_紐4_紐下_紐CD, DisUnit, true);
			this.X0Y0_紐_紐4_紐上_紐CP = new ColorP(this.X0Y0_紐_紐4_紐上_紐, this.紐_紐4_紐上_紐CD, DisUnit, true);
			this.X0Y0_紐_紐5_紐下_紐CP = new ColorP(this.X0Y0_紐_紐5_紐下_紐, this.紐_紐5_紐下_紐CD, DisUnit, true);
			this.X0Y0_紐_紐5_紐上_紐CP = new ColorP(this.X0Y0_紐_紐5_紐上_紐, this.紐_紐5_紐上_紐CD, DisUnit, true);
			this.X0Y0_紐_紐6_紐下_紐CP = new ColorP(this.X0Y0_紐_紐6_紐下_紐, this.紐_紐6_紐下_紐CD, DisUnit, true);
			this.X0Y0_紐_紐6_紐上_紐CP = new ColorP(this.X0Y0_紐_紐6_紐上_紐, this.紐_紐6_紐上_紐CD, DisUnit, true);
			this.X0Y0_左_服CP = new ColorP(this.X0Y0_左_服, this.左_服CD, DisUnit, true);
			this.X0Y0_左_柄_柄1CP = new ColorP(this.X0Y0_左_柄_柄1, this.左_柄_柄1CD, DisUnit, true);
			this.X0Y0_左_柄_柄2CP = new ColorP(this.X0Y0_左_柄_柄2, this.左_柄_柄2CD, DisUnit, true);
			this.X0Y0_左_バストCP = new ColorP(this.X0Y0_左_バスト, this.左_バストCD, DisUnit, true);
			this.X0Y0_左_縁CP = new ColorP(this.X0Y0_左_縁, this.左_縁CD, DisUnit, true);
			this.X0Y0_右_服CP = new ColorP(this.X0Y0_右_服, this.右_服CD, DisUnit, true);
			this.X0Y0_右_柄_柄1CP = new ColorP(this.X0Y0_右_柄_柄1, this.右_柄_柄1CD, DisUnit, true);
			this.X0Y0_右_柄_柄2CP = new ColorP(this.X0Y0_右_柄_柄2, this.右_柄_柄2CD, DisUnit, true);
			this.X0Y0_右_バストCP = new ColorP(this.X0Y0_右_バスト, this.右_バストCD, DisUnit, true);
			this.X0Y0_右_縁CP = new ColorP(this.X0Y0_右_縁, this.右_縁CD, DisUnit, true);
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

		public bool 服基_表示
		{
			get
			{
				return this.X0Y0_服基.Dra;
			}
			set
			{
				this.X0Y0_服基.Dra = value;
				this.X0Y0_服基.Hit = false;
			}
		}

		public bool 紐_紐1_紐下_紐_表示
		{
			get
			{
				return this.X0Y0_紐_紐1_紐下_紐.Dra;
			}
			set
			{
				this.X0Y0_紐_紐1_紐下_紐.Dra = value;
				this.X0Y0_紐_紐1_紐下_紐.Hit = false;
			}
		}

		public bool 紐_紐1_紐上_紐_表示
		{
			get
			{
				return this.X0Y0_紐_紐1_紐上_紐.Dra;
			}
			set
			{
				this.X0Y0_紐_紐1_紐上_紐.Dra = value;
				this.X0Y0_紐_紐1_紐上_紐.Hit = false;
			}
		}

		public bool 紐_紐2_紐下_紐_表示
		{
			get
			{
				return this.X0Y0_紐_紐2_紐下_紐.Dra;
			}
			set
			{
				this.X0Y0_紐_紐2_紐下_紐.Dra = value;
				this.X0Y0_紐_紐2_紐下_紐.Hit = false;
			}
		}

		public bool 紐_紐2_紐上_紐_表示
		{
			get
			{
				return this.X0Y0_紐_紐2_紐上_紐.Dra;
			}
			set
			{
				this.X0Y0_紐_紐2_紐上_紐.Dra = value;
				this.X0Y0_紐_紐2_紐上_紐.Hit = false;
			}
		}

		public bool 紐_紐3_紐下_紐_表示
		{
			get
			{
				return this.X0Y0_紐_紐3_紐下_紐.Dra;
			}
			set
			{
				this.X0Y0_紐_紐3_紐下_紐.Dra = value;
				this.X0Y0_紐_紐3_紐下_紐.Hit = false;
			}
		}

		public bool 紐_紐3_紐上_紐_表示
		{
			get
			{
				return this.X0Y0_紐_紐3_紐上_紐.Dra;
			}
			set
			{
				this.X0Y0_紐_紐3_紐上_紐.Dra = value;
				this.X0Y0_紐_紐3_紐上_紐.Hit = false;
			}
		}

		public bool 紐_紐4_紐下_紐_表示
		{
			get
			{
				return this.X0Y0_紐_紐4_紐下_紐.Dra;
			}
			set
			{
				this.X0Y0_紐_紐4_紐下_紐.Dra = value;
				this.X0Y0_紐_紐4_紐下_紐.Hit = false;
			}
		}

		public bool 紐_紐4_紐上_紐_表示
		{
			get
			{
				return this.X0Y0_紐_紐4_紐上_紐.Dra;
			}
			set
			{
				this.X0Y0_紐_紐4_紐上_紐.Dra = value;
				this.X0Y0_紐_紐4_紐上_紐.Hit = false;
			}
		}

		public bool 紐_紐5_紐下_紐_表示
		{
			get
			{
				return this.X0Y0_紐_紐5_紐下_紐.Dra;
			}
			set
			{
				this.X0Y0_紐_紐5_紐下_紐.Dra = value;
				this.X0Y0_紐_紐5_紐下_紐.Hit = false;
			}
		}

		public bool 紐_紐5_紐上_紐_表示
		{
			get
			{
				return this.X0Y0_紐_紐5_紐上_紐.Dra;
			}
			set
			{
				this.X0Y0_紐_紐5_紐上_紐.Dra = value;
				this.X0Y0_紐_紐5_紐上_紐.Hit = false;
			}
		}

		public bool 紐_紐6_紐下_紐_表示
		{
			get
			{
				return this.X0Y0_紐_紐6_紐下_紐.Dra;
			}
			set
			{
				this.X0Y0_紐_紐6_紐下_紐.Dra = value;
				this.X0Y0_紐_紐6_紐下_紐.Hit = false;
			}
		}

		public bool 紐_紐6_紐上_紐_表示
		{
			get
			{
				return this.X0Y0_紐_紐6_紐上_紐.Dra;
			}
			set
			{
				this.X0Y0_紐_紐6_紐上_紐.Dra = value;
				this.X0Y0_紐_紐6_紐上_紐.Hit = false;
			}
		}

		public bool 左_服_表示
		{
			get
			{
				return this.X0Y0_左_服.Dra;
			}
			set
			{
				this.X0Y0_左_服.Dra = value;
				this.X0Y0_左_服.Hit = false;
			}
		}

		public bool 左_柄_柄1_表示
		{
			get
			{
				return this.X0Y0_左_柄_柄1.Dra;
			}
			set
			{
				this.X0Y0_左_柄_柄1.Dra = value;
				this.X0Y0_左_柄_柄1.Hit = false;
			}
		}

		public bool 左_柄_柄2_表示
		{
			get
			{
				return this.X0Y0_左_柄_柄2.Dra;
			}
			set
			{
				this.X0Y0_左_柄_柄2.Dra = value;
				this.X0Y0_左_柄_柄2.Hit = false;
			}
		}

		public bool 左_バスト_表示
		{
			get
			{
				return this.X0Y0_左_バスト.Dra;
			}
			set
			{
				this.X0Y0_左_バスト.Dra = value;
				this.X0Y0_左_バスト.Hit = false;
			}
		}

		public bool 左_縁_表示
		{
			get
			{
				return this.X0Y0_左_縁.Dra;
			}
			set
			{
				this.X0Y0_左_縁.Dra = value;
				this.X0Y0_左_縁.Hit = false;
			}
		}

		public bool 右_服_表示
		{
			get
			{
				return this.X0Y0_右_服.Dra;
			}
			set
			{
				this.X0Y0_右_服.Dra = value;
				this.X0Y0_右_服.Hit = false;
			}
		}

		public bool 右_柄_柄1_表示
		{
			get
			{
				return this.X0Y0_右_柄_柄1.Dra;
			}
			set
			{
				this.X0Y0_右_柄_柄1.Dra = value;
				this.X0Y0_右_柄_柄1.Hit = false;
			}
		}

		public bool 右_柄_柄2_表示
		{
			get
			{
				return this.X0Y0_右_柄_柄2.Dra;
			}
			set
			{
				this.X0Y0_右_柄_柄2.Dra = value;
				this.X0Y0_右_柄_柄2.Hit = false;
			}
		}

		public bool 右_バスト_表示
		{
			get
			{
				return this.X0Y0_右_バスト.Dra;
			}
			set
			{
				this.X0Y0_右_バスト.Dra = value;
				this.X0Y0_右_バスト.Hit = false;
			}
		}

		public bool 右_縁_表示
		{
			get
			{
				return this.X0Y0_右_縁.Dra;
			}
			set
			{
				this.X0Y0_右_縁.Dra = value;
				this.X0Y0_右_縁.Hit = false;
			}
		}

		public bool ベ\u30FCス表示
		{
			get
			{
				return this.左_服_表示;
			}
			set
			{
				this.左_服_表示 = value;
				this.左_バスト_表示 = value;
				this.右_服_表示 = value;
				this.右_バスト_表示 = value;
			}
		}

		public bool 紐1表示
		{
			get
			{
				return this.紐_紐1_紐下_紐_表示;
			}
			set
			{
				this.紐_紐1_紐下_紐_表示 = value;
				this.紐_紐1_紐上_紐_表示 = value;
			}
		}

		public bool 紐2表示
		{
			get
			{
				return this.紐_紐2_紐下_紐_表示;
			}
			set
			{
				this.紐_紐2_紐下_紐_表示 = value;
				this.紐_紐2_紐上_紐_表示 = value;
			}
		}

		public bool 紐3表示
		{
			get
			{
				return this.紐_紐3_紐下_紐_表示;
			}
			set
			{
				this.紐_紐3_紐下_紐_表示 = value;
				this.紐_紐3_紐上_紐_表示 = value;
			}
		}

		public bool 紐4表示
		{
			get
			{
				return this.紐_紐4_紐下_紐_表示;
			}
			set
			{
				this.紐_紐4_紐下_紐_表示 = value;
				this.紐_紐4_紐上_紐_表示 = value;
			}
		}

		public bool 紐5表示
		{
			get
			{
				return this.紐_紐5_紐下_紐_表示;
			}
			set
			{
				this.紐_紐5_紐下_紐_表示 = value;
				this.紐_紐5_紐上_紐_表示 = value;
			}
		}

		public bool 紐6表示
		{
			get
			{
				return this.紐_紐6_紐下_紐_表示;
			}
			set
			{
				this.紐_紐6_紐下_紐_表示 = value;
				this.紐_紐6_紐上_紐_表示 = value;
			}
		}

		public bool 縁表示
		{
			get
			{
				return this.左_縁_表示;
			}
			set
			{
				this.左_縁_表示 = value;
				this.右_縁_表示 = value;
			}
		}

		public bool 柄1表示
		{
			get
			{
				return this.左_柄_柄1_表示;
			}
			set
			{
				this.左_柄_柄1_表示 = value;
				this.右_柄_柄1_表示 = value;
			}
		}

		public bool 柄2表示
		{
			get
			{
				return this.左_柄_柄2_表示;
			}
			set
			{
				this.左_柄_柄2_表示 = value;
				this.右_柄_柄2_表示 = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.服基_表示;
			}
			set
			{
				this.服基_表示 = value;
				this.紐_紐1_紐下_紐_表示 = value;
				this.紐_紐1_紐上_紐_表示 = value;
				this.紐_紐2_紐下_紐_表示 = value;
				this.紐_紐2_紐上_紐_表示 = value;
				this.紐_紐3_紐下_紐_表示 = value;
				this.紐_紐3_紐上_紐_表示 = value;
				this.紐_紐4_紐下_紐_表示 = value;
				this.紐_紐4_紐上_紐_表示 = value;
				this.紐_紐5_紐下_紐_表示 = value;
				this.紐_紐5_紐上_紐_表示 = value;
				this.紐_紐6_紐下_紐_表示 = value;
				this.紐_紐6_紐上_紐_表示 = value;
				this.左_服_表示 = value;
				this.左_柄_柄1_表示 = value;
				this.左_柄_柄2_表示 = value;
				this.左_バスト_表示 = value;
				this.左_縁_表示 = value;
				this.右_服_表示 = value;
				this.右_柄_柄1_表示 = value;
				this.右_柄_柄2_表示 = value;
				this.右_バスト_表示 = value;
				this.右_縁_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.服基CD.不透明度;
			}
			set
			{
				this.服基CD.不透明度 = value;
				this.紐_紐1_紐下_紐CD.不透明度 = value;
				this.紐_紐1_紐上_紐CD.不透明度 = value;
				this.紐_紐2_紐下_紐CD.不透明度 = value;
				this.紐_紐2_紐上_紐CD.不透明度 = value;
				this.紐_紐3_紐下_紐CD.不透明度 = value;
				this.紐_紐3_紐上_紐CD.不透明度 = value;
				this.紐_紐4_紐下_紐CD.不透明度 = value;
				this.紐_紐4_紐上_紐CD.不透明度 = value;
				this.紐_紐5_紐下_紐CD.不透明度 = value;
				this.紐_紐5_紐上_紐CD.不透明度 = value;
				this.紐_紐6_紐下_紐CD.不透明度 = value;
				this.紐_紐6_紐上_紐CD.不透明度 = value;
				this.左_服CD.不透明度 = value;
				this.左_柄_柄1CD.不透明度 = value;
				this.左_柄_柄2CD.不透明度 = value;
				this.左_バストCD.不透明度 = value;
				this.左_縁CD.不透明度 = value;
				this.右_服CD.不透明度 = value;
				this.右_柄_柄1CD.不透明度 = value;
				this.右_柄_柄2CD.不透明度 = value;
				this.右_バストCD.不透明度 = value;
				this.右_縁CD.不透明度 = value;
			}
		}

		public double バスト
		{
			set
			{
				double num = this.sb * (0.9 + 0.25 * value);
				this.X0Y0_左_バスト.SizeBase = num;
				this.X0Y0_右_バスト.SizeBase = num;
				num = this.syb * (1.0 + 0.05 * value);
				this.X0Y0_左_バスト.SizeYBase = num;
				this.X0Y0_右_バスト.SizeYBase = num;
			}
		}

		public override bool Is革(Par p)
		{
			return p == this.X0Y0_服基 || p == this.X0Y0_紐_紐1_紐下_紐 || p == this.X0Y0_紐_紐1_紐上_紐 || p == this.X0Y0_紐_紐2_紐下_紐 || p == this.X0Y0_紐_紐2_紐上_紐 || p == this.X0Y0_紐_紐3_紐下_紐 || p == this.X0Y0_紐_紐3_紐上_紐 || p == this.X0Y0_紐_紐4_紐下_紐 || p == this.X0Y0_紐_紐4_紐上_紐 || p == this.X0Y0_紐_紐5_紐下_紐 || p == this.X0Y0_紐_紐5_紐上_紐 || p == this.X0Y0_紐_紐6_紐下_紐 || p == this.X0Y0_紐_紐6_紐上_紐 || p == this.X0Y0_左_服 || p == this.X0Y0_左_柄_柄1 || p == this.X0Y0_左_柄_柄2 || p == this.X0Y0_左_バスト || p == this.X0Y0_左_縁 || p == this.X0Y0_右_服 || p == this.X0Y0_右_柄_柄1 || p == this.X0Y0_右_柄_柄2 || p == this.X0Y0_右_バスト || p == this.X0Y0_右_縁;
		}

		public override void 色更新()
		{
			this.X0Y0_服基CP.Update();
			this.X0Y0_紐_紐1_紐下_紐CP.Update();
			this.X0Y0_紐_紐1_紐上_紐CP.Update();
			this.X0Y0_紐_紐2_紐下_紐CP.Update();
			this.X0Y0_紐_紐2_紐上_紐CP.Update();
			this.X0Y0_紐_紐3_紐下_紐CP.Update();
			this.X0Y0_紐_紐3_紐上_紐CP.Update();
			this.X0Y0_紐_紐4_紐下_紐CP.Update();
			this.X0Y0_紐_紐4_紐上_紐CP.Update();
			this.X0Y0_紐_紐5_紐下_紐CP.Update();
			this.X0Y0_紐_紐5_紐上_紐CP.Update();
			this.X0Y0_紐_紐6_紐下_紐CP.Update();
			this.X0Y0_紐_紐6_紐上_紐CP.Update();
			this.X0Y0_左_服CP.Update();
			this.X0Y0_左_バストCP.Update();
			this.X0Y0_右_服CP.Update();
			this.X0Y0_右_バストCP.Update();
			this.X0Y0_左_柄_柄1CP.Update();
			this.X0Y0_左_柄_柄2CP.Update();
			this.X0Y0_右_柄_柄1CP.Update();
			this.X0Y0_右_柄_柄2CP.Update();
			this.X0Y0_左_縁CP.Update();
			this.X0Y0_右_縁CP.Update();
		}

		public void 色更新(Vector2D[] ドレス, Vector2D[] 縁左, Vector2D[] 縁右)
		{
			this.X0Y0_服基CP.Update();
			this.X0Y0_紐_紐1_紐下_紐CP.Update();
			this.X0Y0_紐_紐1_紐上_紐CP.Update();
			this.X0Y0_紐_紐2_紐下_紐CP.Update();
			this.X0Y0_紐_紐2_紐上_紐CP.Update();
			this.X0Y0_紐_紐3_紐下_紐CP.Update();
			this.X0Y0_紐_紐3_紐上_紐CP.Update();
			this.X0Y0_紐_紐4_紐下_紐CP.Update();
			this.X0Y0_紐_紐4_紐上_紐CP.Update();
			this.X0Y0_紐_紐5_紐下_紐CP.Update();
			this.X0Y0_紐_紐5_紐上_紐CP.Update();
			this.X0Y0_紐_紐6_紐下_紐CP.Update();
			this.X0Y0_紐_紐6_紐上_紐CP.Update();
			this.X0Y0_左_服CP.Update(ドレス);
			this.X0Y0_左_バストCP.Update(ドレス);
			this.X0Y0_右_服CP.Update(ドレス);
			this.X0Y0_右_バストCP.Update(ドレス);
			this.X0Y0_左_柄_柄1CP.Update();
			this.X0Y0_左_柄_柄2CP.Update();
			this.X0Y0_右_柄_柄1CP.Update();
			this.X0Y0_右_柄_柄2CP.Update();
			this.X0Y0_左_縁CP.Update(縁左);
			this.X0Y0_右_縁CP.Update(縁右);
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.服基CD = new ColorD(ref Col.Empty, ref Color2.Empty);
			this.紐_紐1_紐下_紐CD = new ColorD();
			this.紐_紐1_紐上_紐CD = new ColorD();
			this.紐_紐2_紐下_紐CD = new ColorD();
			this.紐_紐2_紐上_紐CD = new ColorD();
			this.紐_紐3_紐下_紐CD = new ColorD();
			this.紐_紐3_紐上_紐CD = new ColorD();
			this.紐_紐4_紐下_紐CD = new ColorD();
			this.紐_紐4_紐上_紐CD = new ColorD();
			this.紐_紐5_紐下_紐CD = new ColorD();
			this.紐_紐5_紐上_紐CD = new ColorD();
			this.紐_紐6_紐下_紐CD = new ColorD();
			this.紐_紐6_紐上_紐CD = new ColorD();
			this.左_服CD = new ColorD();
			this.左_柄_柄1CD = new ColorD();
			this.左_柄_柄2CD = new ColorD();
			this.左_バストCD = new ColorD();
			this.左_縁CD = new ColorD();
			this.右_服CD = new ColorD();
			this.右_柄_柄1CD = new ColorD();
			this.右_柄_柄2CD = new ColorD();
			this.右_バストCD = new ColorD();
			this.右_縁CD = new ColorD();
		}

		public void 配色(ドレス色 配色)
		{
			this.紐_紐1_紐下_紐CD.色 = 配色.紐色;
			this.紐_紐1_紐上_紐CD.色 = this.紐_紐1_紐下_紐CD.色;
			this.紐_紐2_紐下_紐CD.色 = this.紐_紐1_紐下_紐CD.色;
			this.紐_紐2_紐上_紐CD.色 = this.紐_紐1_紐下_紐CD.色;
			this.紐_紐3_紐下_紐CD.色 = this.紐_紐1_紐下_紐CD.色;
			this.紐_紐3_紐上_紐CD.色 = this.紐_紐1_紐下_紐CD.色;
			this.紐_紐4_紐下_紐CD.色 = this.紐_紐1_紐下_紐CD.色;
			this.紐_紐4_紐上_紐CD.色 = this.紐_紐1_紐下_紐CD.色;
			this.紐_紐5_紐下_紐CD.色 = this.紐_紐1_紐下_紐CD.色;
			this.紐_紐5_紐上_紐CD.色 = this.紐_紐1_紐下_紐CD.色;
			this.紐_紐6_紐下_紐CD.色 = this.紐_紐1_紐下_紐CD.色;
			this.紐_紐6_紐上_紐CD.色 = this.紐_紐1_紐下_紐CD.色;
			this.左_服CD.色 = 配色.生地色;
			this.左_柄_柄1CD.色 = 配色.柄色;
			this.左_柄_柄2CD.色 = this.左_柄_柄1CD.色;
			this.左_バストCD.色 = this.左_服CD.色;
			this.左_縁CD.色 = 配色.縁色;
			this.右_服CD.色 = this.左_服CD.色;
			this.右_柄_柄1CD.色 = this.左_柄_柄1CD.色;
			this.右_柄_柄2CD.色 = this.左_柄_柄1CD.色;
			this.右_バストCD.色 = this.左_服CD.色;
			this.右_縁CD.色 = this.左_縁CD.色;
		}

		public Par X0Y0_服基;

		public Par X0Y0_紐_紐1_紐下_紐;

		public Par X0Y0_紐_紐1_紐上_紐;

		public Par X0Y0_紐_紐2_紐下_紐;

		public Par X0Y0_紐_紐2_紐上_紐;

		public Par X0Y0_紐_紐3_紐下_紐;

		public Par X0Y0_紐_紐3_紐上_紐;

		public Par X0Y0_紐_紐4_紐下_紐;

		public Par X0Y0_紐_紐4_紐上_紐;

		public Par X0Y0_紐_紐5_紐下_紐;

		public Par X0Y0_紐_紐5_紐上_紐;

		public Par X0Y0_紐_紐6_紐下_紐;

		public Par X0Y0_紐_紐6_紐上_紐;

		public Par X0Y0_左_服;

		public Par X0Y0_左_柄_柄1;

		public Par X0Y0_左_柄_柄2;

		public Par X0Y0_左_バスト;

		public Par X0Y0_左_縁;

		public Par X0Y0_右_服;

		public Par X0Y0_右_柄_柄1;

		public Par X0Y0_右_柄_柄2;

		public Par X0Y0_右_バスト;

		public Par X0Y0_右_縁;

		public ColorD 服基CD = new ColorD(ref Col.Empty, ref Color2.Empty);

		public ColorD 紐_紐1_紐下_紐CD;

		public ColorD 紐_紐1_紐上_紐CD;

		public ColorD 紐_紐2_紐下_紐CD;

		public ColorD 紐_紐2_紐上_紐CD;

		public ColorD 紐_紐3_紐下_紐CD;

		public ColorD 紐_紐3_紐上_紐CD;

		public ColorD 紐_紐4_紐下_紐CD;

		public ColorD 紐_紐4_紐上_紐CD;

		public ColorD 紐_紐5_紐下_紐CD;

		public ColorD 紐_紐5_紐上_紐CD;

		public ColorD 紐_紐6_紐下_紐CD;

		public ColorD 紐_紐6_紐上_紐CD;

		public ColorD 左_服CD;

		public ColorD 左_柄_柄1CD;

		public ColorD 左_柄_柄2CD;

		public ColorD 左_バストCD;

		public ColorD 左_縁CD;

		public ColorD 右_服CD;

		public ColorD 右_柄_柄1CD;

		public ColorD 右_柄_柄2CD;

		public ColorD 右_バストCD;

		public ColorD 右_縁CD;

		public ColorP X0Y0_服基CP;

		public ColorP X0Y0_紐_紐1_紐下_紐CP;

		public ColorP X0Y0_紐_紐1_紐上_紐CP;

		public ColorP X0Y0_紐_紐2_紐下_紐CP;

		public ColorP X0Y0_紐_紐2_紐上_紐CP;

		public ColorP X0Y0_紐_紐3_紐下_紐CP;

		public ColorP X0Y0_紐_紐3_紐上_紐CP;

		public ColorP X0Y0_紐_紐4_紐下_紐CP;

		public ColorP X0Y0_紐_紐4_紐上_紐CP;

		public ColorP X0Y0_紐_紐5_紐下_紐CP;

		public ColorP X0Y0_紐_紐5_紐上_紐CP;

		public ColorP X0Y0_紐_紐6_紐下_紐CP;

		public ColorP X0Y0_紐_紐6_紐上_紐CP;

		public ColorP X0Y0_左_服CP;

		public ColorP X0Y0_左_柄_柄1CP;

		public ColorP X0Y0_左_柄_柄2CP;

		public ColorP X0Y0_左_バストCP;

		public ColorP X0Y0_左_縁CP;

		public ColorP X0Y0_右_服CP;

		public ColorP X0Y0_右_柄_柄1CP;

		public ColorP X0Y0_右_柄_柄2CP;

		public ColorP X0Y0_右_バストCP;

		public ColorP X0Y0_右_縁CP;

		private double sb;

		private double syb;
	}
}
