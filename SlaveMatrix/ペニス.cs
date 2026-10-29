using System;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class ペニス : Ele
	{
		public ペニス(double DisUnit, 配色指定 配色指定, 主人公配色 体配色, Med Med, ペニスD e)
		{
			ペニス.<>c__DisplayClass98_0 CS$<>8__locals1 = new ペニス.<>c__DisplayClass98_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.カ\u30FCソル["ペニス"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_陰嚢 = pars["陰嚢"].ToPar();
			this.X0Y0_陰茎 = pars["陰茎"].ToPar();
			this.X0Y0_血管下 = pars["血管下"].ToPar();
			this.X0Y0_血管上 = pars["血管上"].ToPar();
			this.X0Y0_亀頭 = pars["亀頭"].ToPar();
			pars = this.本体[0][1];
			this.X0Y1_陰嚢 = pars["陰嚢"].ToPar();
			this.X0Y1_陰茎 = pars["陰茎"].ToPar();
			this.X0Y1_血管下 = pars["血管下"].ToPar();
			this.X0Y1_血管上 = pars["血管上"].ToPar();
			this.X0Y1_亀頭 = pars["亀頭"].ToPar();
			pars = this.本体[0][2];
			this.X0Y2_陰嚢 = pars["陰嚢"].ToPar();
			this.X0Y2_陰茎 = pars["陰茎"].ToPar();
			this.X0Y2_血管下 = pars["血管下"].ToPar();
			this.X0Y2_血管上 = pars["血管上"].ToPar();
			this.X0Y2_亀頭 = pars["亀頭"].ToPar();
			pars = this.本体[0][3];
			this.X0Y3_陰嚢 = pars["陰嚢"].ToPar();
			this.X0Y3_陰茎 = pars["陰茎"].ToPar();
			this.X0Y3_血管下 = pars["血管下"].ToPar();
			this.X0Y3_血管上 = pars["血管上"].ToPar();
			this.X0Y3_亀頭 = pars["亀頭"].ToPar();
			pars = this.本体[0][4];
			this.X0Y4_陰嚢 = pars["陰嚢"].ToPar();
			this.X0Y4_陰茎 = pars["陰茎"].ToPar();
			this.X0Y4_血管下 = pars["血管下"].ToPar();
			this.X0Y4_血管上 = pars["血管上"].ToPar();
			this.X0Y4_亀頭 = pars["亀頭"].ToPar();
			pars = this.本体[1][0];
			this.X1Y0_陰嚢 = pars["陰嚢"].ToPar();
			this.X1Y0_陰茎 = pars["陰茎"].ToPar();
			this.X1Y0_血管下 = pars["血管下"].ToPar();
			this.X1Y0_血管上 = pars["血管上"].ToPar();
			this.X1Y0_亀頭 = pars["亀頭"].ToPar();
			pars = this.本体[1][1];
			this.X1Y1_陰嚢 = pars["陰嚢"].ToPar();
			this.X1Y1_陰茎 = pars["陰茎"].ToPar();
			this.X1Y1_血管下 = pars["血管下"].ToPar();
			this.X1Y1_血管上 = pars["血管上"].ToPar();
			this.X1Y1_亀頭 = pars["亀頭"].ToPar();
			pars = this.本体[1][2];
			this.X1Y2_陰嚢 = pars["陰嚢"].ToPar();
			this.X1Y2_陰茎 = pars["陰茎"].ToPar();
			this.X1Y2_血管下 = pars["血管下"].ToPar();
			this.X1Y2_血管上 = pars["血管上"].ToPar();
			pars = this.本体[1][3];
			this.X1Y3_陰嚢 = pars["陰嚢"].ToPar();
			this.X1Y3_陰茎 = pars["陰茎"].ToPar();
			this.X1Y3_血管下 = pars["血管下"].ToPar();
			this.X1Y3_血管上 = pars["血管上"].ToPar();
			pars = this.本体[1][4];
			this.X1Y4_陰嚢 = pars["陰嚢"].ToPar();
			this.X1Y4_陰茎 = pars["陰茎"].ToPar();
			this.X1Y4_血管下 = pars["血管下"].ToPar();
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
			this.陰嚢_表示 = e.陰嚢_表示;
			this.陰茎_表示 = e.陰茎_表示;
			this.血管下_表示 = e.血管下_表示;
			this.血管上_表示 = e.血管上_表示;
			this.亀頭_表示 = e.亀頭_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.尿道_接続.Count > 0)
			{
				Ele f;
				this.尿道_接続 = e.尿道_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.ペニス_尿道_接続;
					f.接続(CS$<>8__locals1.<>4__this.尿道_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_陰嚢CP = new ColorP(this.X0Y0_陰嚢, this.陰嚢CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_陰茎CP = new ColorP(this.X0Y0_陰茎, this.陰茎CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_血管下CP = new ColorP(this.X0Y0_血管下, this.血管下CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_血管上CP = new ColorP(this.X0Y0_血管上, this.血管上CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_亀頭CP = new ColorP(this.X0Y0_亀頭, this.亀頭CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_陰嚢CP = new ColorP(this.X0Y1_陰嚢, this.陰嚢CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_陰茎CP = new ColorP(this.X0Y1_陰茎, this.陰茎CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_血管下CP = new ColorP(this.X0Y1_血管下, this.血管下CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_血管上CP = new ColorP(this.X0Y1_血管上, this.血管上CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_亀頭CP = new ColorP(this.X0Y1_亀頭, this.亀頭CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_陰嚢CP = new ColorP(this.X0Y2_陰嚢, this.陰嚢CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_陰茎CP = new ColorP(this.X0Y2_陰茎, this.陰茎CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_血管下CP = new ColorP(this.X0Y2_血管下, this.血管下CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_血管上CP = new ColorP(this.X0Y2_血管上, this.血管上CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_亀頭CP = new ColorP(this.X0Y2_亀頭, this.亀頭CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_陰嚢CP = new ColorP(this.X0Y3_陰嚢, this.陰嚢CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_陰茎CP = new ColorP(this.X0Y3_陰茎, this.陰茎CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_血管下CP = new ColorP(this.X0Y3_血管下, this.血管下CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_血管上CP = new ColorP(this.X0Y3_血管上, this.血管上CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_亀頭CP = new ColorP(this.X0Y3_亀頭, this.亀頭CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_陰嚢CP = new ColorP(this.X0Y4_陰嚢, this.陰嚢CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_陰茎CP = new ColorP(this.X0Y4_陰茎, this.陰茎CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_血管下CP = new ColorP(this.X0Y4_血管下, this.血管下CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_血管上CP = new ColorP(this.X0Y4_血管上, this.血管上CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_亀頭CP = new ColorP(this.X0Y4_亀頭, this.亀頭CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y0_陰嚢CP = new ColorP(this.X1Y0_陰嚢, this.陰嚢CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y0_陰茎CP = new ColorP(this.X1Y0_陰茎, this.陰茎CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y0_血管下CP = new ColorP(this.X1Y0_血管下, this.血管下CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y0_血管上CP = new ColorP(this.X1Y0_血管上, this.血管上CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y0_亀頭CP = new ColorP(this.X1Y0_亀頭, this.亀頭CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y1_陰嚢CP = new ColorP(this.X1Y1_陰嚢, this.陰嚢CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y1_陰茎CP = new ColorP(this.X1Y1_陰茎, this.陰茎CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y1_血管下CP = new ColorP(this.X1Y1_血管下, this.血管下CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y1_血管上CP = new ColorP(this.X1Y1_血管上, this.血管上CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y1_亀頭CP = new ColorP(this.X1Y1_亀頭, this.亀頭CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y2_陰嚢CP = new ColorP(this.X1Y2_陰嚢, this.陰嚢CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y2_陰茎CP = new ColorP(this.X1Y2_陰茎, this.陰茎CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y2_血管下CP = new ColorP(this.X1Y2_血管下, this.血管下CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y2_血管上CP = new ColorP(this.X1Y2_血管上, this.血管上CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y3_陰嚢CP = new ColorP(this.X1Y3_陰嚢, this.陰嚢CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y3_陰茎CP = new ColorP(this.X1Y3_陰茎, this.陰茎CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y3_血管下CP = new ColorP(this.X1Y3_血管下, this.血管下CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y3_血管上CP = new ColorP(this.X1Y3_血管上, this.血管上CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y4_陰嚢CP = new ColorP(this.X1Y4_陰嚢, this.陰嚢CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y4_陰茎CP = new ColorP(this.X1Y4_陰茎, this.陰茎CD, CS$<>8__locals1.DisUnit, true);
			this.X1Y4_血管下CP = new ColorP(this.X1Y4_血管下, this.血管下CD, CS$<>8__locals1.DisUnit, true);
			this.濃度 = e.濃度;
			this.AreM = new AreM(CS$<>8__locals1.Med.Unit, 3.0, 7.0, 0.07, CS$<>8__locals1.Med.DisQuality, CS$<>8__locals1.Med.HitAccuracy, 0.45);
			this.AreM.Setting();
			this.AreM.BasePoint = new Vector2D(0.5, 0.1);
			this.X0Y0_陰嚢.BasePointBase = this.X0Y0_陰嚢.ToLocal(this.X0Y0_陰茎.ToGlobal(this.X0Y0_陰茎.JP[3].Joint));
			this.X0Y1_陰嚢.BasePointBase = this.X0Y1_陰嚢.ToLocal(this.X0Y1_陰茎.ToGlobal(this.X0Y1_陰茎.JP[3].Joint));
			this.X0Y2_陰嚢.BasePointBase = this.X0Y2_陰嚢.ToLocal(this.X0Y2_陰茎.ToGlobal(this.X0Y2_陰茎.JP[3].Joint));
			this.X0Y3_陰嚢.BasePointBase = this.X0Y3_陰嚢.ToLocal(this.X0Y3_陰茎.ToGlobal(this.X0Y3_陰茎.JP[3].Joint));
			this.X0Y4_陰嚢.BasePointBase = this.X0Y4_陰嚢.ToLocal(this.X0Y4_陰茎.ToGlobal(this.X0Y4_陰茎.JP[3].Joint));
			this.X1Y0_陰嚢.BasePointBase = this.X1Y0_陰嚢.ToLocal(this.X1Y0_陰茎.ToGlobal(this.X1Y0_陰茎.JP[3].Joint));
			this.X1Y1_陰嚢.BasePointBase = this.X1Y1_陰嚢.ToLocal(this.X1Y1_陰茎.ToGlobal(this.X1Y1_陰茎.JP[3].Joint));
			this.X1Y2_陰嚢.BasePointBase = this.X1Y2_陰嚢.ToLocal(this.X1Y2_陰茎.ToGlobal(this.X1Y2_陰茎.JP[2].Joint));
			this.X1Y3_陰嚢.BasePointBase = this.X1Y3_陰嚢.ToLocal(this.X1Y3_陰茎.ToGlobal(this.X1Y3_陰茎.JP[2].Joint));
			this.X1Y4_陰嚢.BasePointBase = this.X1Y4_陰嚢.ToLocal(this.X1Y4_陰茎.ToGlobal(this.X1Y4_陰茎.JP[2].Joint));
			Vector2D position = this.AreM.GetPosition(ref this.AreM.BasePoint);
			foreach (Par par in this.本体.EnumJoinRoot)
			{
				par.PositionBase = position;
			}
			this.本体.JoinPAall();
			this.尺度B *= 1.07;
			this.尺度B = 1.08;
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

		public bool 陰嚢_表示
		{
			get
			{
				return this.X0Y0_陰嚢.Dra;
			}
			set
			{
				this.X0Y0_陰嚢.Dra = value;
				this.X0Y1_陰嚢.Dra = value;
				this.X0Y2_陰嚢.Dra = value;
				this.X0Y3_陰嚢.Dra = value;
				this.X0Y4_陰嚢.Dra = value;
				this.X1Y0_陰嚢.Dra = value;
				this.X1Y1_陰嚢.Dra = value;
				this.X1Y2_陰嚢.Dra = value;
				this.X1Y3_陰嚢.Dra = value;
				this.X1Y4_陰嚢.Dra = value;
				this.X0Y0_陰嚢.Hit = value;
				this.X0Y1_陰嚢.Hit = value;
				this.X0Y2_陰嚢.Hit = value;
				this.X0Y3_陰嚢.Hit = value;
				this.X0Y4_陰嚢.Hit = value;
				this.X1Y0_陰嚢.Hit = value;
				this.X1Y1_陰嚢.Hit = value;
				this.X1Y2_陰嚢.Hit = value;
				this.X1Y3_陰嚢.Hit = value;
				this.X1Y4_陰嚢.Hit = value;
			}
		}

		public bool 陰茎_表示
		{
			get
			{
				return this.X0Y0_陰茎.Dra;
			}
			set
			{
				this.X0Y0_陰茎.Dra = value;
				this.X0Y1_陰茎.Dra = value;
				this.X0Y2_陰茎.Dra = value;
				this.X0Y3_陰茎.Dra = value;
				this.X0Y4_陰茎.Dra = value;
				this.X1Y0_陰茎.Dra = value;
				this.X1Y1_陰茎.Dra = value;
				this.X1Y2_陰茎.Dra = value;
				this.X1Y3_陰茎.Dra = value;
				this.X1Y4_陰茎.Dra = value;
				this.X0Y0_陰茎.Hit = value;
				this.X0Y1_陰茎.Hit = value;
				this.X0Y2_陰茎.Hit = value;
				this.X0Y3_陰茎.Hit = value;
				this.X0Y4_陰茎.Hit = value;
				this.X1Y0_陰茎.Hit = value;
				this.X1Y1_陰茎.Hit = value;
				this.X1Y2_陰茎.Hit = value;
				this.X1Y3_陰茎.Hit = value;
				this.X1Y4_陰茎.Hit = value;
			}
		}

		public bool 血管下_表示
		{
			get
			{
				return this.X0Y0_血管下.Dra;
			}
			set
			{
				this.X0Y0_血管下.Dra = value;
				this.X0Y1_血管下.Dra = value;
				this.X0Y2_血管下.Dra = value;
				this.X0Y3_血管下.Dra = value;
				this.X0Y4_血管下.Dra = value;
				this.X1Y0_血管下.Dra = value;
				this.X1Y1_血管下.Dra = value;
				this.X1Y2_血管下.Dra = value;
				this.X1Y3_血管下.Dra = value;
				this.X1Y4_血管下.Dra = value;
				this.X0Y0_血管下.Hit = value;
				this.X0Y1_血管下.Hit = value;
				this.X0Y2_血管下.Hit = value;
				this.X0Y3_血管下.Hit = value;
				this.X0Y4_血管下.Hit = value;
				this.X1Y0_血管下.Hit = value;
				this.X1Y1_血管下.Hit = value;
				this.X1Y2_血管下.Hit = value;
				this.X1Y3_血管下.Hit = value;
				this.X1Y4_血管下.Hit = value;
			}
		}

		public bool 血管上_表示
		{
			get
			{
				return this.X0Y0_血管上.Dra;
			}
			set
			{
				this.X0Y0_血管上.Dra = value;
				this.X0Y1_血管上.Dra = value;
				this.X0Y2_血管上.Dra = value;
				this.X0Y3_血管上.Dra = value;
				this.X0Y4_血管上.Dra = value;
				this.X1Y0_血管上.Dra = value;
				this.X1Y1_血管上.Dra = value;
				this.X1Y2_血管上.Dra = value;
				this.X1Y3_血管上.Dra = value;
				this.X0Y0_血管上.Hit = value;
				this.X0Y1_血管上.Hit = value;
				this.X0Y2_血管上.Hit = value;
				this.X0Y3_血管上.Hit = value;
				this.X0Y4_血管上.Hit = value;
				this.X1Y0_血管上.Hit = value;
				this.X1Y1_血管上.Hit = value;
				this.X1Y2_血管上.Hit = value;
				this.X1Y3_血管上.Hit = value;
			}
		}

		public bool 亀頭_表示
		{
			get
			{
				return this.X0Y0_亀頭.Dra;
			}
			set
			{
				this.X0Y0_亀頭.Dra = value;
				this.X0Y1_亀頭.Dra = value;
				this.X0Y2_亀頭.Dra = value;
				this.X0Y3_亀頭.Dra = value;
				this.X0Y4_亀頭.Dra = value;
				this.X1Y0_亀頭.Dra = value;
				this.X1Y1_亀頭.Dra = value;
				this.X0Y0_亀頭.Hit = value;
				this.X0Y1_亀頭.Hit = value;
				this.X0Y2_亀頭.Hit = value;
				this.X0Y3_亀頭.Hit = value;
				this.X0Y4_亀頭.Hit = value;
				this.X1Y0_亀頭.Hit = value;
				this.X1Y1_亀頭.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.陰嚢_表示;
			}
			set
			{
				this.陰嚢_表示 = value;
				this.陰茎_表示 = value;
				this.血管下_表示 = value;
				this.血管上_表示 = value;
				this.亀頭_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.陰嚢CD.不透明度;
			}
			set
			{
				this.陰嚢CD.不透明度 = value;
				this.陰茎CD.不透明度 = value;
				this.血管下CD.不透明度 = value;
				this.血管上CD.不透明度 = value;
				this.亀頭CD.不透明度 = value;
			}
		}

		public override Vector2D 位置B
		{
			get
			{
				return this.AreM.Position;
			}
			set
			{
				this.AreM.Position = value;
			}
		}

		public override void Dispose()
		{
			base.Dispose();
			this.AreM.Dispose();
		}

		public override void 描画0(Are Are)
		{
			this.AreM.Clear();
			this.本体.Draw(this.AreM);
			Are.Draw(this.AreM);
		}

		public JointS 尿道_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_陰茎, 3);
			}
		}

		public override void 色更新()
		{
			if (this.本体.IndexX == 0)
			{
				switch (this.本体.IndexY)
				{
				case 0:
					this.X0Y0_陰嚢CP.Update();
					this.X0Y0_陰茎CP.Update();
					this.X0Y0_血管下CP.Update();
					this.X0Y0_血管上CP.Update();
					this.X0Y0_亀頭CP.Update();
					return;
				case 1:
					this.X0Y1_陰嚢CP.Update();
					this.X0Y1_陰茎CP.Update();
					this.X0Y1_血管下CP.Update();
					this.X0Y1_血管上CP.Update();
					this.X0Y1_亀頭CP.Update();
					return;
				case 2:
					this.X0Y2_陰嚢CP.Update();
					this.X0Y2_陰茎CP.Update();
					this.X0Y2_血管下CP.Update();
					this.X0Y2_血管上CP.Update();
					this.X0Y2_亀頭CP.Update();
					return;
				case 3:
					this.X0Y3_陰嚢CP.Update();
					this.X0Y3_陰茎CP.Update();
					this.X0Y3_血管下CP.Update();
					this.X0Y3_血管上CP.Update();
					this.X0Y3_亀頭CP.Update();
					return;
				default:
					this.X0Y4_陰嚢CP.Update();
					this.X0Y4_陰茎CP.Update();
					this.X0Y4_血管下CP.Update();
					this.X0Y4_血管上CP.Update();
					this.X0Y4_亀頭CP.Update();
					return;
				}
			}
			else
			{
				switch (this.本体.IndexY)
				{
				case 0:
					this.X1Y0_陰嚢CP.Update();
					this.X1Y0_陰茎CP.Update();
					this.X1Y0_血管下CP.Update();
					this.X1Y0_血管上CP.Update();
					this.X1Y0_亀頭CP.Update();
					return;
				case 1:
					this.X1Y1_陰嚢CP.Update();
					this.X1Y1_陰茎CP.Update();
					this.X1Y1_血管下CP.Update();
					this.X1Y1_血管上CP.Update();
					this.X1Y1_亀頭CP.Update();
					return;
				case 2:
					this.X1Y2_陰嚢CP.Update();
					this.X1Y2_陰茎CP.Update();
					this.X1Y2_血管下CP.Update();
					this.X1Y2_血管上CP.Update();
					return;
				case 3:
					this.X1Y3_陰嚢CP.Update();
					this.X1Y3_陰茎CP.Update();
					this.X1Y3_血管下CP.Update();
					this.X1Y3_血管上CP.Update();
					return;
				default:
					this.X1Y4_陰嚢CP.Update();
					this.X1Y4_陰茎CP.Update();
					this.X1Y4_血管下CP.Update();
					return;
				}
			}
		}

		private void 配色(主人公配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(主人公配色 体配色)
		{
			this.陰嚢CD = new ColorD(ref 体配色.肌線, ref 体配色.肌色);
			this.陰茎CD = new ColorD(ref 体配色.肌線, ref 体配色.肌色);
			this.血管下CD = new ColorD(ref 体配色.肌線, ref 体配色.肌色);
			this.血管上CD = new ColorD(ref 体配色.肌線, ref 体配色.肌色);
			this.亀頭CD = new ColorD();
			this.亀頭CD.線 = 体配色.粘線;
			this.亀頭CD.色 = new Color2(ref 体配色.粘膜.Col2, ref Col.Empty);
		}

		public void 再配色(主人公配色 体配色)
		{
			this.陰嚢CD.線 = 体配色.粘線;
			this.陰嚢CD.色 = 体配色.肌色;
			this.陰茎CD.線 = 体配色.粘線;
			this.陰茎CD.色 = 体配色.肌色;
			this.血管下CD.線 = 体配色.粘線;
			this.血管下CD.色 = 体配色.肌色;
			this.血管上CD.線 = 体配色.粘線;
			this.血管上CD.色 = 体配色.肌色;
			this.亀頭CD.線 = 体配色.粘線;
			this.亀頭CD.色 = new Color2(ref 体配色.粘膜.Col2, ref Col.Empty);
		}

		public Par X0Y0_陰嚢;

		public Par X0Y0_陰茎;

		public Par X0Y0_血管下;

		public Par X0Y0_血管上;

		public Par X0Y0_亀頭;

		public Par X0Y1_陰嚢;

		public Par X0Y1_陰茎;

		public Par X0Y1_血管下;

		public Par X0Y1_血管上;

		public Par X0Y1_亀頭;

		public Par X0Y2_陰嚢;

		public Par X0Y2_陰茎;

		public Par X0Y2_血管下;

		public Par X0Y2_血管上;

		public Par X0Y2_亀頭;

		public Par X0Y3_陰嚢;

		public Par X0Y3_陰茎;

		public Par X0Y3_血管下;

		public Par X0Y3_血管上;

		public Par X0Y3_亀頭;

		public Par X0Y4_陰嚢;

		public Par X0Y4_陰茎;

		public Par X0Y4_血管下;

		public Par X0Y4_血管上;

		public Par X0Y4_亀頭;

		public Par X1Y0_陰嚢;

		public Par X1Y0_陰茎;

		public Par X1Y0_血管下;

		public Par X1Y0_血管上;

		public Par X1Y0_亀頭;

		public Par X1Y1_陰嚢;

		public Par X1Y1_陰茎;

		public Par X1Y1_血管下;

		public Par X1Y1_血管上;

		public Par X1Y1_亀頭;

		public Par X1Y2_陰嚢;

		public Par X1Y2_陰茎;

		public Par X1Y2_血管下;

		public Par X1Y2_血管上;

		public Par X1Y3_陰嚢;

		public Par X1Y3_陰茎;

		public Par X1Y3_血管下;

		public Par X1Y3_血管上;

		public Par X1Y4_陰嚢;

		public Par X1Y4_陰茎;

		public Par X1Y4_血管下;

		public AreM AreM;

		public ColorD 陰嚢CD;

		public ColorD 陰茎CD;

		public ColorD 血管下CD;

		public ColorD 血管上CD;

		public ColorD 亀頭CD;

		public ColorP X0Y0_陰嚢CP;

		public ColorP X0Y0_陰茎CP;

		public ColorP X0Y0_血管下CP;

		public ColorP X0Y0_血管上CP;

		public ColorP X0Y0_亀頭CP;

		public ColorP X0Y1_陰嚢CP;

		public ColorP X0Y1_陰茎CP;

		public ColorP X0Y1_血管下CP;

		public ColorP X0Y1_血管上CP;

		public ColorP X0Y1_亀頭CP;

		public ColorP X0Y2_陰嚢CP;

		public ColorP X0Y2_陰茎CP;

		public ColorP X0Y2_血管下CP;

		public ColorP X0Y2_血管上CP;

		public ColorP X0Y2_亀頭CP;

		public ColorP X0Y3_陰嚢CP;

		public ColorP X0Y3_陰茎CP;

		public ColorP X0Y3_血管下CP;

		public ColorP X0Y3_血管上CP;

		public ColorP X0Y3_亀頭CP;

		public ColorP X0Y4_陰嚢CP;

		public ColorP X0Y4_陰茎CP;

		public ColorP X0Y4_血管下CP;

		public ColorP X0Y4_血管上CP;

		public ColorP X0Y4_亀頭CP;

		public ColorP X1Y0_陰嚢CP;

		public ColorP X1Y0_陰茎CP;

		public ColorP X1Y0_血管下CP;

		public ColorP X1Y0_血管上CP;

		public ColorP X1Y0_亀頭CP;

		public ColorP X1Y1_陰嚢CP;

		public ColorP X1Y1_陰茎CP;

		public ColorP X1Y1_血管下CP;

		public ColorP X1Y1_血管上CP;

		public ColorP X1Y1_亀頭CP;

		public ColorP X1Y2_陰嚢CP;

		public ColorP X1Y2_陰茎CP;

		public ColorP X1Y2_血管下CP;

		public ColorP X1Y2_血管上CP;

		public ColorP X1Y3_陰嚢CP;

		public ColorP X1Y3_陰茎CP;

		public ColorP X1Y3_血管下CP;

		public ColorP X1Y3_血管上CP;

		public ColorP X1Y4_陰嚢CP;

		public ColorP X1Y4_陰茎CP;

		public ColorP X1Y4_血管下CP;

		public Ele[] 尿道_接続;
	}
}
