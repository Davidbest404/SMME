using System;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 前翅_甲 : 前翅
	{
		public 前翅_甲(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 前翅_甲D e)
		{
			前翅_甲.<>c__DisplayClass108_0 CS$<>8__locals1 = new 前翅_甲.<>c__DisplayClass108_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			Dif dif = new Dif(Sta.肢左["前翅"][0]);
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			Pars pars2 = pars["前翅"].ToPars();
			Pars pars3 = pars2["前翅軸"].ToPars();
			this.X0Y0_前翅_前翅軸_軸1 = pars3["軸1"].ToPar();
			this.X0Y0_前翅_前翅軸_軸2 = pars3["軸2"].ToPar();
			this.X0Y0_前翅_前翅軸_軸3 = pars3["軸3"].ToPar();
			pars3 = pars2["前翅甲"].ToPars();
			this.X0Y0_前翅_前翅甲_甲2 = pars3["甲2"].ToPar();
			this.X0Y0_前翅_前翅甲_甲1 = pars3["甲1"].ToPar();
			this.X0Y0_前翅_前翅甲_紋1 = pars3["紋1"].ToPar();
			this.X0Y0_前翅_前翅甲_紋2 = pars3["紋2"].ToPar();
			this.X0Y0_前翅_前翅甲_紋3 = pars3["紋3"].ToPar();
			this.X0Y0_前翅_前翅甲_紋4 = pars3["紋4"].ToPar();
			this.X0Y0_前翅_前翅甲_紋5 = pars3["紋5"].ToPar();
			this.X0Y0_前翅_前翅甲_紋6 = pars3["紋6"].ToPar();
			this.X0Y0_前翅_前翅甲_紋7 = pars3["紋7"].ToPar();
			pars2 = pars["付根"].ToPars();
			this.X0Y0_付根_付根0 = pars2["付根0"].ToPar();
			this.X0Y0_付根_付根1 = pars2["付根1"].ToPar();
			this.X0Y0_付根_付根2 = pars2["付根2"].ToPar();
			this.X0Y0_甲付根 = pars["甲付根"].ToPar();
			this.X0Y0_紋1 = pars["紋1"].ToPar();
			this.X0Y0_紋2 = pars["紋2"].ToPar();
			pars = this.本体[0][1];
			pars2 = pars["前翅"].ToPars();
			pars3 = pars2["前翅軸"].ToPars();
			this.X0Y1_前翅_前翅軸_軸1 = pars3["軸1"].ToPar();
			this.X0Y1_前翅_前翅軸_軸2 = pars3["軸2"].ToPar();
			this.X0Y1_前翅_前翅軸_軸3 = pars3["軸3"].ToPar();
			this.X0Y1_前翅_前翅軸_罅線 = pars3["罅線"].ToPar();
			pars3 = pars2["前翅甲"].ToPars();
			this.X0Y1_前翅_前翅甲_甲2 = pars3["甲2"].ToPar();
			this.X0Y1_前翅_前翅甲_甲1 = pars3["甲1"].ToPar();
			this.X0Y1_前翅_前翅甲_紋1 = pars3["紋1"].ToPar();
			this.X0Y1_前翅_前翅甲_紋2 = pars3["紋2"].ToPar();
			this.X0Y1_前翅_前翅甲_紋3 = pars3["紋3"].ToPar();
			this.X0Y1_前翅_前翅甲_紋4 = pars3["紋4"].ToPar();
			this.X0Y1_前翅_前翅甲_紋5 = pars3["紋5"].ToPar();
			this.X0Y1_前翅_前翅甲_紋6 = pars3["紋6"].ToPar();
			this.X0Y1_前翅_前翅甲_紋7 = pars3["紋7"].ToPar();
			this.X0Y1_前翅_前翅甲_罅線1 = pars3["罅線1"].ToPar();
			this.X0Y1_前翅_前翅甲_罅線2 = pars3["罅線2"].ToPar();
			pars2 = pars["付根"].ToPars();
			this.X0Y1_付根_付根0 = pars2["付根0"].ToPar();
			this.X0Y1_付根_付根1 = pars2["付根1"].ToPar();
			this.X0Y1_付根_付根2 = pars2["付根2"].ToPar();
			this.X0Y1_甲付根 = pars["甲付根"].ToPar();
			this.X0Y1_紋1 = pars["紋1"].ToPar();
			this.X0Y1_紋2 = pars["紋2"].ToPar();
			this.X0Y1_欠け1 = pars["欠け1"].ToPar();
			this.X0Y1_欠け2 = pars["欠け2"].ToPar();
			this.X0Y1_欠け3 = pars["欠け3"].ToPar();
			this.Xasix = false;
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
			this.前翅_前翅軸_軸1_表示 = e.前翅_前翅軸_軸1_表示;
			this.前翅_前翅軸_軸2_表示 = e.前翅_前翅軸_軸2_表示;
			this.前翅_前翅軸_軸3_表示 = e.前翅_前翅軸_軸3_表示;
			this.前翅_前翅甲_甲2_表示 = e.前翅_前翅甲_甲2_表示;
			this.前翅_前翅甲_甲1_表示 = e.前翅_前翅甲_甲1_表示;
			this.前翅_前翅甲_紋1_表示 = e.前翅_前翅甲_紋1_表示;
			this.前翅_前翅甲_紋2_表示 = e.前翅_前翅甲_紋2_表示;
			this.前翅_前翅甲_紋3_表示 = e.前翅_前翅甲_紋3_表示;
			this.前翅_前翅甲_紋4_表示 = e.前翅_前翅甲_紋4_表示;
			this.前翅_前翅甲_紋5_表示 = e.前翅_前翅甲_紋5_表示;
			this.前翅_前翅甲_紋6_表示 = e.前翅_前翅甲_紋6_表示;
			this.前翅_前翅甲_紋7_表示 = e.前翅_前翅甲_紋7_表示;
			this.付根_付根0_表示 = e.付根_付根0_表示;
			this.付根_付根1_表示 = e.付根_付根1_表示;
			this.付根_付根2_表示 = e.付根_付根2_表示;
			this.甲付根_表示 = e.甲付根_表示;
			this.紋1_表示 = e.紋1_表示;
			this.紋2_表示 = e.紋2_表示;
			this.前翅_前翅軸_罅線_表示 = e.前翅_前翅軸_罅線_表示;
			this.前翅_前翅甲_罅線1_表示 = e.前翅_前翅甲_罅線1_表示;
			this.前翅_前翅甲_罅線2_表示 = e.前翅_前翅甲_罅線2_表示;
			this.欠け1_表示 = e.欠け1_表示;
			this.欠け2_表示 = e.欠け2_表示;
			this.欠け3_表示 = e.欠け3_表示;
			this.展開 = e.展開;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.軸1_接続.Count > 0)
			{
				Ele f;
				this.軸1_接続 = e.軸1_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.前翅_甲_軸1_接続;
					f.接続(CS$<>8__locals1.<>4__this.軸1_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.軸2_接続.Count > 0)
			{
				Ele f;
				this.軸2_接続 = e.軸2_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.前翅_甲_軸2_接続;
					f.接続(CS$<>8__locals1.<>4__this.軸2_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.軸3_接続.Count > 0)
			{
				Ele f;
				this.軸3_接続 = e.軸3_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.前翅_甲_軸3_接続;
					f.接続(CS$<>8__locals1.<>4__this.軸3_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_前翅_前翅軸_軸1CP = new ColorP(this.X0Y0_前翅_前翅軸_軸1, this.前翅_前翅軸_軸1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_前翅_前翅軸_軸2CP = new ColorP(this.X0Y0_前翅_前翅軸_軸2, this.前翅_前翅軸_軸2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_前翅_前翅軸_軸3CP = new ColorP(this.X0Y0_前翅_前翅軸_軸3, this.前翅_前翅軸_軸3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_前翅_前翅甲_甲2CP = new ColorP(this.X0Y0_前翅_前翅甲_甲2, this.前翅_前翅甲_甲2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_前翅_前翅甲_甲1CP = new ColorP(this.X0Y0_前翅_前翅甲_甲1, this.前翅_前翅甲_甲1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_前翅_前翅甲_紋1CP = new ColorP(this.X0Y0_前翅_前翅甲_紋1, this.前翅_前翅甲_紋1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_前翅_前翅甲_紋2CP = new ColorP(this.X0Y0_前翅_前翅甲_紋2, this.前翅_前翅甲_紋2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_前翅_前翅甲_紋3CP = new ColorP(this.X0Y0_前翅_前翅甲_紋3, this.前翅_前翅甲_紋3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_前翅_前翅甲_紋4CP = new ColorP(this.X0Y0_前翅_前翅甲_紋4, this.前翅_前翅甲_紋4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_前翅_前翅甲_紋5CP = new ColorP(this.X0Y0_前翅_前翅甲_紋5, this.前翅_前翅甲_紋5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_前翅_前翅甲_紋6CP = new ColorP(this.X0Y0_前翅_前翅甲_紋6, this.前翅_前翅甲_紋6CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_前翅_前翅甲_紋7CP = new ColorP(this.X0Y0_前翅_前翅甲_紋7, this.前翅_前翅甲_紋7CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_付根_付根0CP = new ColorP(this.X0Y0_付根_付根0, this.付根_付根0CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_付根_付根1CP = new ColorP(this.X0Y0_付根_付根1, this.付根_付根1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_付根_付根2CP = new ColorP(this.X0Y0_付根_付根2, this.付根_付根2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_甲付根CP = new ColorP(this.X0Y0_甲付根, this.甲付根CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_紋1CP = new ColorP(this.X0Y0_紋1, this.紋1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_紋2CP = new ColorP(this.X0Y0_紋2, this.紋2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_前翅_前翅軸_軸1CP = new ColorP(this.X0Y1_前翅_前翅軸_軸1, this.前翅_前翅軸_軸1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_前翅_前翅軸_軸2CP = new ColorP(this.X0Y1_前翅_前翅軸_軸2, this.前翅_前翅軸_軸2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_前翅_前翅軸_軸3CP = new ColorP(this.X0Y1_前翅_前翅軸_軸3, this.前翅_前翅軸_軸3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_前翅_前翅軸_罅線CP = new ColorP(this.X0Y1_前翅_前翅軸_罅線, this.前翅_前翅軸_罅線CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_前翅_前翅甲_甲2CP = new ColorP(this.X0Y1_前翅_前翅甲_甲2, this.前翅_前翅甲_甲2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_前翅_前翅甲_甲1CP = new ColorP(this.X0Y1_前翅_前翅甲_甲1, this.前翅_前翅甲_甲1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_前翅_前翅甲_紋1CP = new ColorP(this.X0Y1_前翅_前翅甲_紋1, this.前翅_前翅甲_紋1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_前翅_前翅甲_紋2CP = new ColorP(this.X0Y1_前翅_前翅甲_紋2, this.前翅_前翅甲_紋2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_前翅_前翅甲_紋3CP = new ColorP(this.X0Y1_前翅_前翅甲_紋3, this.前翅_前翅甲_紋3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_前翅_前翅甲_紋4CP = new ColorP(this.X0Y1_前翅_前翅甲_紋4, this.前翅_前翅甲_紋4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_前翅_前翅甲_紋5CP = new ColorP(this.X0Y1_前翅_前翅甲_紋5, this.前翅_前翅甲_紋5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_前翅_前翅甲_紋6CP = new ColorP(this.X0Y1_前翅_前翅甲_紋6, this.前翅_前翅甲_紋6CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_前翅_前翅甲_紋7CP = new ColorP(this.X0Y1_前翅_前翅甲_紋7, this.前翅_前翅甲_紋7CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_前翅_前翅甲_罅線1CP = new ColorP(this.X0Y1_前翅_前翅甲_罅線1, this.前翅_前翅甲_罅線1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_前翅_前翅甲_罅線2CP = new ColorP(this.X0Y1_前翅_前翅甲_罅線2, this.前翅_前翅甲_罅線2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_付根_付根0CP = new ColorP(this.X0Y1_付根_付根0, this.付根_付根0CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_付根_付根1CP = new ColorP(this.X0Y1_付根_付根1, this.付根_付根1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_付根_付根2CP = new ColorP(this.X0Y1_付根_付根2, this.付根_付根2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_甲付根CP = new ColorP(this.X0Y1_甲付根, this.甲付根CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_紋1CP = new ColorP(this.X0Y1_紋1, this.紋1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_紋2CP = new ColorP(this.X0Y1_紋2, this.紋2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_欠け1CP = new ColorP(this.X0Y1_欠け1, this.欠け1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_欠け2CP = new ColorP(this.X0Y1_欠け2, this.欠け2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_欠け3CP = new ColorP(this.X0Y1_欠け3, this.欠け3CD, CS$<>8__locals1.DisUnit, true);
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
				this.本体.IndexY = (this.欠損_ ? 1 : 0);
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

		public bool 前翅_前翅軸_軸1_表示
		{
			get
			{
				return this.X0Y0_前翅_前翅軸_軸1.Dra;
			}
			set
			{
				this.X0Y0_前翅_前翅軸_軸1.Dra = value;
				this.X0Y1_前翅_前翅軸_軸1.Dra = value;
				this.X0Y0_前翅_前翅軸_軸1.Hit = value;
				this.X0Y1_前翅_前翅軸_軸1.Hit = value;
			}
		}

		public bool 前翅_前翅軸_軸2_表示
		{
			get
			{
				return this.X0Y0_前翅_前翅軸_軸2.Dra;
			}
			set
			{
				this.X0Y0_前翅_前翅軸_軸2.Dra = value;
				this.X0Y1_前翅_前翅軸_軸2.Dra = value;
				this.X0Y0_前翅_前翅軸_軸2.Hit = value;
				this.X0Y1_前翅_前翅軸_軸2.Hit = value;
			}
		}

		public bool 前翅_前翅軸_軸3_表示
		{
			get
			{
				return this.X0Y0_前翅_前翅軸_軸3.Dra;
			}
			set
			{
				this.X0Y0_前翅_前翅軸_軸3.Dra = value;
				this.X0Y1_前翅_前翅軸_軸3.Dra = value;
				this.X0Y0_前翅_前翅軸_軸3.Hit = value;
				this.X0Y1_前翅_前翅軸_軸3.Hit = value;
			}
		}

		public bool 前翅_前翅甲_甲2_表示
		{
			get
			{
				return this.X0Y0_前翅_前翅甲_甲2.Dra;
			}
			set
			{
				this.X0Y0_前翅_前翅甲_甲2.Dra = value;
				this.X0Y1_前翅_前翅甲_甲2.Dra = value;
				this.X0Y0_前翅_前翅甲_甲2.Hit = value;
				this.X0Y1_前翅_前翅甲_甲2.Hit = value;
			}
		}

		public bool 前翅_前翅甲_甲1_表示
		{
			get
			{
				return this.X0Y0_前翅_前翅甲_甲1.Dra;
			}
			set
			{
				this.X0Y0_前翅_前翅甲_甲1.Dra = value;
				this.X0Y1_前翅_前翅甲_甲1.Dra = value;
				this.X0Y0_前翅_前翅甲_甲1.Hit = value;
				this.X0Y1_前翅_前翅甲_甲1.Hit = value;
			}
		}

		public bool 前翅_前翅甲_紋1_表示
		{
			get
			{
				return this.X0Y0_前翅_前翅甲_紋1.Dra;
			}
			set
			{
				this.X0Y0_前翅_前翅甲_紋1.Dra = value;
				this.X0Y1_前翅_前翅甲_紋1.Dra = value;
				this.X0Y0_前翅_前翅甲_紋1.Hit = value;
				this.X0Y1_前翅_前翅甲_紋1.Hit = value;
			}
		}

		public bool 前翅_前翅甲_紋2_表示
		{
			get
			{
				return this.X0Y0_前翅_前翅甲_紋2.Dra;
			}
			set
			{
				this.X0Y0_前翅_前翅甲_紋2.Dra = value;
				this.X0Y1_前翅_前翅甲_紋2.Dra = value;
				this.X0Y0_前翅_前翅甲_紋2.Hit = value;
				this.X0Y1_前翅_前翅甲_紋2.Hit = value;
			}
		}

		public bool 前翅_前翅甲_紋3_表示
		{
			get
			{
				return this.X0Y0_前翅_前翅甲_紋3.Dra;
			}
			set
			{
				this.X0Y0_前翅_前翅甲_紋3.Dra = value;
				this.X0Y1_前翅_前翅甲_紋3.Dra = value;
				this.X0Y0_前翅_前翅甲_紋3.Hit = value;
				this.X0Y1_前翅_前翅甲_紋3.Hit = value;
			}
		}

		public bool 前翅_前翅甲_紋4_表示
		{
			get
			{
				return this.X0Y0_前翅_前翅甲_紋4.Dra;
			}
			set
			{
				this.X0Y0_前翅_前翅甲_紋4.Dra = value;
				this.X0Y1_前翅_前翅甲_紋4.Dra = value;
				this.X0Y0_前翅_前翅甲_紋4.Hit = value;
				this.X0Y1_前翅_前翅甲_紋4.Hit = value;
			}
		}

		public bool 前翅_前翅甲_紋5_表示
		{
			get
			{
				return this.X0Y0_前翅_前翅甲_紋5.Dra;
			}
			set
			{
				this.X0Y0_前翅_前翅甲_紋5.Dra = value;
				this.X0Y1_前翅_前翅甲_紋5.Dra = value;
				this.X0Y0_前翅_前翅甲_紋5.Hit = value;
				this.X0Y1_前翅_前翅甲_紋5.Hit = value;
			}
		}

		public bool 前翅_前翅甲_紋6_表示
		{
			get
			{
				return this.X0Y0_前翅_前翅甲_紋6.Dra;
			}
			set
			{
				this.X0Y0_前翅_前翅甲_紋6.Dra = value;
				this.X0Y1_前翅_前翅甲_紋6.Dra = value;
				this.X0Y0_前翅_前翅甲_紋6.Hit = value;
				this.X0Y1_前翅_前翅甲_紋6.Hit = value;
			}
		}

		public bool 前翅_前翅甲_紋7_表示
		{
			get
			{
				return this.X0Y0_前翅_前翅甲_紋7.Dra;
			}
			set
			{
				this.X0Y0_前翅_前翅甲_紋7.Dra = value;
				this.X0Y1_前翅_前翅甲_紋7.Dra = value;
				this.X0Y0_前翅_前翅甲_紋7.Hit = value;
				this.X0Y1_前翅_前翅甲_紋7.Hit = value;
			}
		}

		public bool 付根_付根0_表示
		{
			get
			{
				return this.X0Y0_付根_付根0.Dra;
			}
			set
			{
				this.X0Y0_付根_付根0.Dra = value;
				this.X0Y1_付根_付根0.Dra = value;
				this.X0Y0_付根_付根0.Hit = value;
				this.X0Y1_付根_付根0.Hit = value;
			}
		}

		public bool 付根_付根1_表示
		{
			get
			{
				return this.X0Y0_付根_付根1.Dra;
			}
			set
			{
				this.X0Y0_付根_付根1.Dra = value;
				this.X0Y1_付根_付根1.Dra = value;
				this.X0Y0_付根_付根1.Hit = value;
				this.X0Y1_付根_付根1.Hit = value;
			}
		}

		public bool 付根_付根2_表示
		{
			get
			{
				return this.X0Y0_付根_付根2.Dra;
			}
			set
			{
				this.X0Y0_付根_付根2.Dra = value;
				this.X0Y1_付根_付根2.Dra = value;
				this.X0Y0_付根_付根2.Hit = value;
				this.X0Y1_付根_付根2.Hit = value;
			}
		}

		public bool 甲付根_表示
		{
			get
			{
				return this.X0Y0_甲付根.Dra;
			}
			set
			{
				this.X0Y0_甲付根.Dra = value;
				this.X0Y1_甲付根.Dra = value;
				this.X0Y0_甲付根.Hit = value;
				this.X0Y1_甲付根.Hit = value;
			}
		}

		public bool 紋1_表示
		{
			get
			{
				return this.X0Y0_紋1.Dra;
			}
			set
			{
				this.X0Y0_紋1.Dra = value;
				this.X0Y1_紋1.Dra = value;
				this.X0Y0_紋1.Hit = value;
				this.X0Y1_紋1.Hit = value;
			}
		}

		public bool 紋2_表示
		{
			get
			{
				return this.X0Y0_紋2.Dra;
			}
			set
			{
				this.X0Y0_紋2.Dra = value;
				this.X0Y1_紋2.Dra = value;
				this.X0Y0_紋2.Hit = value;
				this.X0Y1_紋2.Hit = value;
			}
		}

		public bool 前翅_前翅軸_罅線_表示
		{
			get
			{
				return this.X0Y1_前翅_前翅軸_罅線.Dra;
			}
			set
			{
				this.X0Y1_前翅_前翅軸_罅線.Dra = value;
				this.X0Y1_前翅_前翅軸_罅線.Hit = value;
			}
		}

		public bool 前翅_前翅甲_罅線1_表示
		{
			get
			{
				return this.X0Y1_前翅_前翅甲_罅線1.Dra;
			}
			set
			{
				this.X0Y1_前翅_前翅甲_罅線1.Dra = value;
				this.X0Y1_前翅_前翅甲_罅線1.Hit = value;
			}
		}

		public bool 前翅_前翅甲_罅線2_表示
		{
			get
			{
				return this.X0Y1_前翅_前翅甲_罅線2.Dra;
			}
			set
			{
				this.X0Y1_前翅_前翅甲_罅線2.Dra = value;
				this.X0Y1_前翅_前翅甲_罅線2.Hit = value;
			}
		}

		public bool 欠け1_表示
		{
			get
			{
				return this.X0Y1_欠け1.Dra;
			}
			set
			{
				this.X0Y1_欠け1.Dra = value;
				this.X0Y1_欠け1.Hit = value;
			}
		}

		public bool 欠け2_表示
		{
			get
			{
				return this.X0Y1_欠け2.Dra;
			}
			set
			{
				this.X0Y1_欠け2.Dra = value;
				this.X0Y1_欠け2.Hit = value;
			}
		}

		public bool 欠け3_表示
		{
			get
			{
				return this.X0Y1_欠け3.Dra;
			}
			set
			{
				this.X0Y1_欠け3.Dra = value;
				this.X0Y1_欠け3.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.前翅_前翅軸_軸1_表示;
			}
			set
			{
				this.前翅_前翅軸_軸1_表示 = value;
				this.前翅_前翅軸_軸2_表示 = value;
				this.前翅_前翅軸_軸3_表示 = value;
				this.前翅_前翅甲_甲2_表示 = value;
				this.前翅_前翅甲_甲1_表示 = value;
				this.前翅_前翅甲_紋1_表示 = value;
				this.前翅_前翅甲_紋2_表示 = value;
				this.前翅_前翅甲_紋3_表示 = value;
				this.前翅_前翅甲_紋4_表示 = value;
				this.前翅_前翅甲_紋5_表示 = value;
				this.前翅_前翅甲_紋6_表示 = value;
				this.前翅_前翅甲_紋7_表示 = value;
				this.付根_付根0_表示 = value;
				this.付根_付根1_表示 = value;
				this.付根_付根2_表示 = value;
				this.甲付根_表示 = value;
				this.紋1_表示 = value;
				this.紋2_表示 = value;
				this.前翅_前翅軸_罅線_表示 = value;
				this.前翅_前翅甲_罅線1_表示 = value;
				this.前翅_前翅甲_罅線2_表示 = value;
				this.欠け1_表示 = value;
				this.欠け2_表示 = value;
				this.欠け3_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.前翅_前翅軸_軸1CD.不透明度;
			}
			set
			{
				this.前翅_前翅軸_軸1CD.不透明度 = value;
				this.前翅_前翅軸_軸2CD.不透明度 = value;
				this.前翅_前翅軸_軸3CD.不透明度 = value;
				this.前翅_前翅軸_罅線CD.不透明度 = value;
				this.前翅_前翅甲_甲2CD.不透明度 = value;
				this.前翅_前翅甲_甲1CD.不透明度 = value;
				this.前翅_前翅甲_紋1CD.不透明度 = value;
				this.前翅_前翅甲_紋2CD.不透明度 = value;
				this.前翅_前翅甲_紋3CD.不透明度 = value;
				this.前翅_前翅甲_紋4CD.不透明度 = value;
				this.前翅_前翅甲_紋5CD.不透明度 = value;
				this.前翅_前翅甲_紋6CD.不透明度 = value;
				this.前翅_前翅甲_紋7CD.不透明度 = value;
				this.前翅_前翅甲_罅線1CD.不透明度 = value;
				this.前翅_前翅甲_罅線2CD.不透明度 = value;
				this.付根_付根0CD.不透明度 = value;
				this.付根_付根1CD.不透明度 = value;
				this.付根_付根2CD.不透明度 = value;
				this.甲付根CD.不透明度 = value;
				this.紋1CD.不透明度 = value;
				this.紋2CD.不透明度 = value;
				this.欠け1CD.不透明度 = value;
				this.欠け2CD.不透明度 = value;
				this.欠け3CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			double num = this.右 ? -1.0 : 1.0;
			this.X0Y0_付根_付根0.AngleBase = num * 21.0;
			this.X0Y1_付根_付根0.AngleBase = num * 21.0;
			this.X0Y0_前翅_前翅軸_軸1.AngleBase = num * 18.0;
			this.X0Y1_前翅_前翅軸_軸1.AngleBase = num * 18.0;
			this.X0Y0_前翅_前翅軸_軸2.AngleBase = num * -24.0;
			this.X0Y1_前翅_前翅軸_軸2.AngleBase = num * -24.0;
			this.X0Y0_前翅_前翅軸_軸3.AngleBase = num * 13.0;
			this.X0Y1_前翅_前翅軸_軸3.AngleBase = num * 13.0;
			this.X0Y0_前翅_前翅甲_甲1.AngleBase = num * -4.0;
			this.X0Y1_前翅_前翅甲_甲1.AngleBase = num * -4.0;
			this.X0Y0_甲付根.AngleBase = num * 5.0;
			this.X0Y1_甲付根.AngleBase = num * 5.0;
			this.本体.JoinPAall();
		}

		public double 展開
		{
			set
			{
				double num = value.Inverse();
				double num2 = this.右 ? -1.0 : 1.0;
				this.X0Y0_前翅_前翅軸_軸1.AngleCont = num2 * -95.0 * num;
				this.X0Y0_前翅_前翅軸_軸2.AngleCont = num2 * -28.0 * num;
				this.X0Y0_前翅_前翅軸_軸3.AngleCont = num2 * -178.0 * num;
				this.X0Y0_前翅_前翅甲_甲1.AngleCont = num2 * -45.0 * num;
				this.X0Y0_甲付根.AngleCont = num2 * 6.0 * num;
				this.X0Y0_前翅_前翅軸_軸3.SizeXCont = 0.7 + 0.3 * value;
				this.X0Y1_前翅_前翅軸_軸1.AngleCont = num2 * -95.0 * num;
				this.X0Y1_前翅_前翅軸_軸2.AngleCont = num2 * -28.0 * num;
				this.X0Y1_前翅_前翅軸_軸3.AngleCont = num2 * -178.0 * num;
				this.X0Y1_前翅_前翅甲_甲1.AngleCont = num2 * -45.0 * num;
				this.X0Y1_甲付根.AngleCont = num2 * 6.0 * num;
				this.X0Y1_前翅_前翅軸_軸3.SizeXCont = 0.7 + 0.3 * value;
			}
		}

		public JointS 軸1_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_付根_付根0, 0);
			}
		}

		public JointS 軸2_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_前翅_前翅軸_軸1, 0);
			}
		}

		public JointS 軸3_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_前翅_前翅軸_軸2, 0);
			}
		}

		public override void 色更新()
		{
			if (this.本体.IndexY == 0)
			{
				this.X0Y0_前翅_前翅軸_軸1CP.Update();
				this.X0Y0_前翅_前翅軸_軸2CP.Update();
				this.X0Y0_前翅_前翅軸_軸3CP.Update();
				this.X0Y0_前翅_前翅甲_甲2CP.Update();
				this.X0Y0_前翅_前翅甲_甲1CP.Update();
				this.X0Y0_前翅_前翅甲_紋1CP.Update();
				this.X0Y0_前翅_前翅甲_紋2CP.Update();
				this.X0Y0_前翅_前翅甲_紋3CP.Update();
				this.X0Y0_前翅_前翅甲_紋4CP.Update();
				this.X0Y0_前翅_前翅甲_紋5CP.Update();
				this.X0Y0_前翅_前翅甲_紋6CP.Update();
				this.X0Y0_前翅_前翅甲_紋7CP.Update();
				this.X0Y0_付根_付根0CP.Update();
				this.X0Y0_付根_付根1CP.Update();
				this.X0Y0_付根_付根2CP.Update();
				this.X0Y0_甲付根CP.Update();
				this.X0Y0_紋1CP.Update();
				this.X0Y0_紋2CP.Update();
				return;
			}
			this.X0Y1_前翅_前翅軸_軸1CP.Update();
			this.X0Y1_前翅_前翅軸_軸2CP.Update();
			this.X0Y1_前翅_前翅軸_軸3CP.Update();
			this.X0Y1_前翅_前翅軸_罅線CP.Update();
			this.X0Y1_前翅_前翅甲_甲2CP.Update();
			this.X0Y1_前翅_前翅甲_甲1CP.Update();
			this.X0Y1_前翅_前翅甲_紋1CP.Update();
			this.X0Y1_前翅_前翅甲_紋2CP.Update();
			this.X0Y1_前翅_前翅甲_紋3CP.Update();
			this.X0Y1_前翅_前翅甲_紋4CP.Update();
			this.X0Y1_前翅_前翅甲_紋5CP.Update();
			this.X0Y1_前翅_前翅甲_紋6CP.Update();
			this.X0Y1_前翅_前翅甲_紋7CP.Update();
			this.X0Y1_前翅_前翅甲_罅線1CP.Update();
			this.X0Y1_前翅_前翅甲_罅線2CP.Update();
			this.X0Y1_付根_付根0CP.Update();
			this.X0Y1_付根_付根1CP.Update();
			this.X0Y1_付根_付根2CP.Update();
			this.X0Y1_甲付根CP.Update();
			this.X0Y1_紋1CP.Update();
			this.X0Y1_紋2CP.Update();
			this.X0Y1_欠け1CP.Update();
			this.X0Y1_欠け2CP.Update();
			this.X0Y1_欠け3CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.前翅_前翅軸_軸1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.前翅_前翅軸_軸2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.前翅_前翅軸_軸3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.前翅_前翅軸_罅線CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.前翅_前翅甲_甲2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.前翅_前翅甲_甲1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.前翅_前翅甲_紋1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.前翅_前翅甲_紋2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.前翅_前翅甲_紋3CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.前翅_前翅甲_紋4CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.前翅_前翅甲_紋5CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.前翅_前翅甲_紋6CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.前翅_前翅甲_紋7CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.前翅_前翅甲_罅線1CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.前翅_前翅甲_罅線2CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.付根_付根0CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.付根_付根1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.付根_付根2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.甲付根CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.紋1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.紋2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.欠け1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.欠け2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.欠け3CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
		}

		public Par X0Y0_前翅_前翅軸_軸1;

		public Par X0Y0_前翅_前翅軸_軸2;

		public Par X0Y0_前翅_前翅軸_軸3;

		public Par X0Y0_前翅_前翅甲_甲2;

		public Par X0Y0_前翅_前翅甲_甲1;

		public Par X0Y0_前翅_前翅甲_紋1;

		public Par X0Y0_前翅_前翅甲_紋2;

		public Par X0Y0_前翅_前翅甲_紋3;

		public Par X0Y0_前翅_前翅甲_紋4;

		public Par X0Y0_前翅_前翅甲_紋5;

		public Par X0Y0_前翅_前翅甲_紋6;

		public Par X0Y0_前翅_前翅甲_紋7;

		public Par X0Y0_付根_付根0;

		public Par X0Y0_付根_付根1;

		public Par X0Y0_付根_付根2;

		public Par X0Y0_甲付根;

		public Par X0Y0_紋1;

		public Par X0Y0_紋2;

		public Par X0Y1_前翅_前翅軸_軸1;

		public Par X0Y1_前翅_前翅軸_軸2;

		public Par X0Y1_前翅_前翅軸_軸3;

		public Par X0Y1_前翅_前翅軸_罅線;

		public Par X0Y1_前翅_前翅甲_甲2;

		public Par X0Y1_前翅_前翅甲_甲1;

		public Par X0Y1_前翅_前翅甲_紋1;

		public Par X0Y1_前翅_前翅甲_紋2;

		public Par X0Y1_前翅_前翅甲_紋3;

		public Par X0Y1_前翅_前翅甲_紋4;

		public Par X0Y1_前翅_前翅甲_紋5;

		public Par X0Y1_前翅_前翅甲_紋6;

		public Par X0Y1_前翅_前翅甲_紋7;

		public Par X0Y1_前翅_前翅甲_罅線1;

		public Par X0Y1_前翅_前翅甲_罅線2;

		public Par X0Y1_付根_付根0;

		public Par X0Y1_付根_付根1;

		public Par X0Y1_付根_付根2;

		public Par X0Y1_甲付根;

		public Par X0Y1_紋1;

		public Par X0Y1_紋2;

		public Par X0Y1_欠け1;

		public Par X0Y1_欠け2;

		public Par X0Y1_欠け3;

		public ColorD 前翅_前翅軸_軸1CD;

		public ColorD 前翅_前翅軸_軸2CD;

		public ColorD 前翅_前翅軸_軸3CD;

		public ColorD 前翅_前翅軸_罅線CD;

		public ColorD 前翅_前翅甲_甲2CD;

		public ColorD 前翅_前翅甲_甲1CD;

		public ColorD 前翅_前翅甲_紋1CD;

		public ColorD 前翅_前翅甲_紋2CD;

		public ColorD 前翅_前翅甲_紋3CD;

		public ColorD 前翅_前翅甲_紋4CD;

		public ColorD 前翅_前翅甲_紋5CD;

		public ColorD 前翅_前翅甲_紋6CD;

		public ColorD 前翅_前翅甲_紋7CD;

		public ColorD 前翅_前翅甲_罅線1CD;

		public ColorD 前翅_前翅甲_罅線2CD;

		public ColorD 付根_付根0CD;

		public ColorD 付根_付根1CD;

		public ColorD 付根_付根2CD;

		public ColorD 甲付根CD;

		public ColorD 紋1CD;

		public ColorD 紋2CD;

		public ColorD 欠け1CD;

		public ColorD 欠け2CD;

		public ColorD 欠け3CD;

		public ColorP X0Y0_前翅_前翅軸_軸1CP;

		public ColorP X0Y0_前翅_前翅軸_軸2CP;

		public ColorP X0Y0_前翅_前翅軸_軸3CP;

		public ColorP X0Y0_前翅_前翅甲_甲2CP;

		public ColorP X0Y0_前翅_前翅甲_甲1CP;

		public ColorP X0Y0_前翅_前翅甲_紋1CP;

		public ColorP X0Y0_前翅_前翅甲_紋2CP;

		public ColorP X0Y0_前翅_前翅甲_紋3CP;

		public ColorP X0Y0_前翅_前翅甲_紋4CP;

		public ColorP X0Y0_前翅_前翅甲_紋5CP;

		public ColorP X0Y0_前翅_前翅甲_紋6CP;

		public ColorP X0Y0_前翅_前翅甲_紋7CP;

		public ColorP X0Y0_付根_付根0CP;

		public ColorP X0Y0_付根_付根1CP;

		public ColorP X0Y0_付根_付根2CP;

		public ColorP X0Y0_甲付根CP;

		public ColorP X0Y0_紋1CP;

		public ColorP X0Y0_紋2CP;

		public ColorP X0Y1_前翅_前翅軸_軸1CP;

		public ColorP X0Y1_前翅_前翅軸_軸2CP;

		public ColorP X0Y1_前翅_前翅軸_軸3CP;

		public ColorP X0Y1_前翅_前翅軸_罅線CP;

		public ColorP X0Y1_前翅_前翅甲_甲2CP;

		public ColorP X0Y1_前翅_前翅甲_甲1CP;

		public ColorP X0Y1_前翅_前翅甲_紋1CP;

		public ColorP X0Y1_前翅_前翅甲_紋2CP;

		public ColorP X0Y1_前翅_前翅甲_紋3CP;

		public ColorP X0Y1_前翅_前翅甲_紋4CP;

		public ColorP X0Y1_前翅_前翅甲_紋5CP;

		public ColorP X0Y1_前翅_前翅甲_紋6CP;

		public ColorP X0Y1_前翅_前翅甲_紋7CP;

		public ColorP X0Y1_前翅_前翅甲_罅線1CP;

		public ColorP X0Y1_前翅_前翅甲_罅線2CP;

		public ColorP X0Y1_付根_付根0CP;

		public ColorP X0Y1_付根_付根1CP;

		public ColorP X0Y1_付根_付根2CP;

		public ColorP X0Y1_甲付根CP;

		public ColorP X0Y1_紋1CP;

		public ColorP X0Y1_紋2CP;

		public ColorP X0Y1_欠け1CP;

		public ColorP X0Y1_欠け2CP;

		public ColorP X0Y1_欠け3CP;

		public Ele[] 軸1_接続;

		public Ele[] 軸2_接続;

		public Ele[] 軸3_接続;
	}
}
