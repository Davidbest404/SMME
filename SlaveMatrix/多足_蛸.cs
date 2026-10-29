using System;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 多足_蛸 : 半身
	{
		public 多足_蛸(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 多足_蛸D e)
		{
			多足_蛸.<>c__DisplayClass3_0 CS$<>8__locals1 = new 多足_蛸.<>c__DisplayClass3_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "蛸";
			dif.Add(new Pars(Sta.半身["多足"][0][0]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_胴 = pars["胴"].ToPar();
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
			this.胴_表示 = e.胴_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.軟体外左_接続.Count > 0)
			{
				Ele f;
				this.軟体外左_接続 = e.軟体外左_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.多足_蛸_軟体外左_接続;
					f.接続(CS$<>8__locals1.<>4__this.軟体外左_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.軟体外右_接続.Count > 0)
			{
				Ele f;
				this.軟体外右_接続 = e.軟体外右_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.多足_蛸_軟体外右_接続;
					f.接続(CS$<>8__locals1.<>4__this.軟体外右_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.軟体内左_接続.Count > 0)
			{
				Ele f;
				this.軟体内左_接続 = e.軟体内左_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.多足_蛸_軟体内左_接続;
					f.接続(CS$<>8__locals1.<>4__this.軟体内左_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.軟体内右_接続.Count > 0)
			{
				Ele f;
				this.軟体内右_接続 = e.軟体内右_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.多足_蛸_軟体内右_接続;
					f.接続(CS$<>8__locals1.<>4__this.軟体内右_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_胴CP = new ColorP(this.X0Y0_胴, this.胴CD, CS$<>8__locals1.DisUnit, true);
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

		public bool 胴_表示
		{
			get
			{
				return this.X0Y0_胴.Dra;
			}
			set
			{
				this.X0Y0_胴.Dra = value;
				this.X0Y0_胴.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.胴_表示;
			}
			set
			{
				this.胴_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.胴CD.不透明度;
			}
			set
			{
				this.胴CD.不透明度 = value;
			}
		}

		public JointS 軟体外左_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴, 0);
			}
		}

		public JointS 軟体外右_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴, 3);
			}
		}

		public JointS 軟体内左_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴, 1);
			}
		}

		public JointS 軟体内右_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴, 2);
			}
		}

		public override void 色更新()
		{
			this.X0Y0_胴CP.Update();
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
			this.胴CD = new ColorD(ref Col.Black, ref 体配色.体0O);
		}

		private void 配色T0(体配色 体配色)
		{
			this.胴CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
		}

		private void 配色T1(体配色 体配色)
		{
			this.胴CD = new ColorD(ref Col.Black, ref 体配色.体0O);
		}

		public Par X0Y0_胴;

		public ColorD 胴CD;

		public ColorP X0Y0_胴CP;

		public Ele[] 軟体外左_接続;

		public Ele[] 軟体外右_接続;

		public Ele[] 軟体内左_接続;

		public Ele[] 軟体内右_接続;
	}
}
