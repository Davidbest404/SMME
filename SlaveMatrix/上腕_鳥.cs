using System;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 上腕_鳥 : 翼上腕
	{
		public 上腕_鳥(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 上腕_鳥D e)
		{
			上腕_鳥.<>c__DisplayClass30_0 CS$<>8__locals1 = new 上腕_鳥.<>c__DisplayClass30_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.腕左["鳥翼上腕"]);
			Pars pars = this.本体[0][0];
			Pars pars2 = pars["風切羽"].ToPars();
			this.X0Y0_風切羽_羽3 = pars2["羽3"].ToPar();
			this.X0Y0_風切羽_羽2 = pars2["羽2"].ToPar();
			this.X0Y0_風切羽_羽1 = pars2["羽1"].ToPar();
			this.X0Y0_羽毛 = pars["羽毛"].ToPar();
			this.X0Y0_鳥翼上腕 = pars["鳥翼上腕"].ToPar();
			this.X0Y0_小雨覆 = pars["小雨覆"].ToPar();
			pars2 = pars["鱗"].ToPars();
			this.X0Y0_竜性_鱗1 = pars2["鱗1"].ToPar();
			this.X0Y0_竜性_鱗2 = pars2["鱗2"].ToPar();
			this.X0Y0_竜性_鱗3 = pars2["鱗3"].ToPar();
			this.X0Y0_竜性_鱗4 = pars2["鱗4"].ToPar();
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
			this.風切羽_羽3_表示 = e.風切羽_羽3_表示;
			this.風切羽_羽2_表示 = e.風切羽_羽2_表示;
			this.風切羽_羽1_表示 = e.風切羽_羽1_表示;
			this.羽毛_表示 = e.羽毛_表示;
			this.鳥翼上腕_表示 = e.鳥翼上腕_表示;
			this.小雨覆_表示 = e.小雨覆_表示;
			this.竜性_鱗1_表示 = e.竜性_鱗1_表示;
			this.竜性_鱗2_表示 = e.竜性_鱗2_表示;
			this.竜性_鱗3_表示 = e.竜性_鱗3_表示;
			this.竜性_鱗4_表示 = e.竜性_鱗4_表示;
			this.展開 = e.展開;
			this.シャ\u30FCプ = e.シャ\u30FCプ;
			this.上腕_外線 = e.上腕_外線;
			this.小雨覆_外線 = e.小雨覆_外線;
			this.羽毛_外線 = e.羽毛_外線;
			this.風切羽_羽1_外線 = e.風切羽_羽1_外線;
			this.風切羽_羽2_外線 = e.風切羽_羽2_外線;
			this.風切羽_羽3_外線 = e.風切羽_羽3_外線;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.下腕_接続.Count > 0)
			{
				Ele f;
				this.下腕_接続 = e.下腕_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.上腕_鳥_下腕_接続;
					f.接続(CS$<>8__locals1.<>4__this.下腕_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_風切羽_羽3CP = new ColorP(this.X0Y0_風切羽_羽3, this.風切羽_羽3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_風切羽_羽2CP = new ColorP(this.X0Y0_風切羽_羽2, this.風切羽_羽2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_風切羽_羽1CP = new ColorP(this.X0Y0_風切羽_羽1, this.風切羽_羽1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_羽毛CP = new ColorP(this.X0Y0_羽毛, this.羽毛CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_鳥翼上腕CP = new ColorP(this.X0Y0_鳥翼上腕, this.鳥翼上腕CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_小雨覆CP = new ColorP(this.X0Y0_小雨覆, this.小雨覆CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_鱗1CP = new ColorP(this.X0Y0_竜性_鱗1, this.竜性_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_鱗2CP = new ColorP(this.X0Y0_竜性_鱗2, this.竜性_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_鱗3CP = new ColorP(this.X0Y0_竜性_鱗3, this.竜性_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_鱗4CP = new ColorP(this.X0Y0_竜性_鱗4, this.竜性_鱗4CD, CS$<>8__locals1.DisUnit, true);
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

		public bool 風切羽_羽3_表示
		{
			get
			{
				return this.X0Y0_風切羽_羽3.Dra;
			}
			set
			{
				this.X0Y0_風切羽_羽3.Dra = value;
				this.X0Y0_風切羽_羽3.Hit = value;
			}
		}

		public bool 風切羽_羽2_表示
		{
			get
			{
				return this.X0Y0_風切羽_羽2.Dra;
			}
			set
			{
				this.X0Y0_風切羽_羽2.Dra = value;
				this.X0Y0_風切羽_羽2.Hit = value;
			}
		}

		public bool 風切羽_羽1_表示
		{
			get
			{
				return this.X0Y0_風切羽_羽1.Dra;
			}
			set
			{
				this.X0Y0_風切羽_羽1.Dra = value;
				this.X0Y0_風切羽_羽1.Hit = value;
			}
		}

		public bool 羽毛_表示
		{
			get
			{
				return this.X0Y0_羽毛.Dra;
			}
			set
			{
				this.X0Y0_羽毛.Dra = value;
				this.X0Y0_羽毛.Hit = value;
			}
		}

		public bool 鳥翼上腕_表示
		{
			get
			{
				return this.X0Y0_鳥翼上腕.Dra;
			}
			set
			{
				this.X0Y0_鳥翼上腕.Dra = value;
				this.X0Y0_鳥翼上腕.Hit = value;
			}
		}

		public bool 小雨覆_表示
		{
			get
			{
				return this.X0Y0_小雨覆.Dra;
			}
			set
			{
				this.X0Y0_小雨覆.Dra = value;
				this.X0Y0_小雨覆.Hit = value;
			}
		}

		public bool 竜性_鱗1_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗1.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗1.Dra = value;
				this.X0Y0_竜性_鱗1.Hit = value;
			}
		}

		public bool 竜性_鱗2_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗2.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗2.Dra = value;
				this.X0Y0_竜性_鱗2.Hit = value;
			}
		}

		public bool 竜性_鱗3_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗3.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗3.Dra = value;
				this.X0Y0_竜性_鱗3.Hit = value;
			}
		}

		public bool 竜性_鱗4_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗4.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗4.Dra = value;
				this.X0Y0_竜性_鱗4.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.風切羽_羽3_表示;
			}
			set
			{
				this.風切羽_羽3_表示 = value;
				this.風切羽_羽2_表示 = value;
				this.風切羽_羽1_表示 = value;
				this.羽毛_表示 = value;
				this.鳥翼上腕_表示 = value;
				this.小雨覆_表示 = value;
				this.竜性_鱗1_表示 = value;
				this.竜性_鱗2_表示 = value;
				this.竜性_鱗3_表示 = value;
				this.竜性_鱗4_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.風切羽_羽3CD.不透明度;
			}
			set
			{
				this.風切羽_羽3CD.不透明度 = value;
				this.風切羽_羽2CD.不透明度 = value;
				this.風切羽_羽1CD.不透明度 = value;
				this.羽毛CD.不透明度 = value;
				this.鳥翼上腕CD.不透明度 = value;
				this.小雨覆CD.不透明度 = value;
				this.竜性_鱗1CD.不透明度 = value;
				this.竜性_鱗2CD.不透明度 = value;
				this.竜性_鱗3CD.不透明度 = value;
				this.竜性_鱗4CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			double num = this.右 ? -1.0 : 1.0;
			this.X0Y0_鳥翼上腕.AngleBase = num * 0.0;
			this.X0Y0_羽毛.AngleBase = num * -122.9677794835592;
			this.X0Y0_風切羽_羽1.AngleBase = num * -100.129973503791;
			this.X0Y0_風切羽_羽2.AngleBase = num * -102.129973503791;
			this.X0Y0_風切羽_羽3.AngleBase = num * -103.129973503791;
			this.本体.JoinPAall();
		}

		public override double 展開
		{
			set
			{
				double num = value.Inverse();
				double num2 = this.右 ? -1.0 : 1.0;
				this.X0Y0_鳥翼上腕.AngleCont = num2 * -60.0 * num;
				this.X0Y0_羽毛.AngleCont = num2 * 100.0 * num;
				this.X0Y0_風切羽_羽1.AngleCont = num2 * 75.0 * num;
				this.X0Y0_風切羽_羽2.AngleCont = num2 * 75.0 * num;
				this.X0Y0_風切羽_羽3.AngleCont = num2 * 75.0 * num;
			}
		}

		public double シャ\u30FCプ
		{
			set
			{
				double num = 0.05;
				this.X0Y0_風切羽_羽3.SizeYBase *= 1.0 - num * value;
				this.X0Y0_風切羽_羽2.SizeYBase *= 1.0 - num * value;
				this.X0Y0_風切羽_羽1.SizeYBase *= 1.0 - num * value;
			}
		}

		public bool 上腕_外線
		{
			get
			{
				return this.X0Y0_鳥翼上腕.OP[this.右 ? 3 : 0].Outline;
			}
			set
			{
				this.X0Y0_鳥翼上腕.OP[this.右 ? 3 : 0].Outline = value;
				this.X0Y0_鳥翼上腕.OP[this.右 ? 2 : 1].Outline = value;
			}
		}

		public bool 小雨覆_外線
		{
			get
			{
				return this.X0Y0_小雨覆.OP[this.右 ? 2 : 3].Outline;
			}
			set
			{
				this.X0Y0_小雨覆.OP[this.右 ? 2 : 3].Outline = value;
				this.X0Y0_小雨覆.OP[this.右 ? 1 : 4].Outline = value;
				this.X0Y0_小雨覆.OP[this.右 ? 0 : 5].Outline = value;
			}
		}

		public bool 羽毛_外線
		{
			get
			{
				return this.X0Y0_羽毛.OP[this.右 ? 4 : 0].Outline;
			}
			set
			{
				this.X0Y0_羽毛.OP[this.右 ? 4 : 0].Outline = value;
				this.X0Y0_羽毛.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_羽毛.OP[this.右 ? 2 : 2].Outline = value;
				this.X0Y0_羽毛.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_羽毛.OP[this.右 ? 0 : 4].Outline = value;
			}
		}

		public bool 風切羽_羽1_外線
		{
			get
			{
				return this.X0Y0_風切羽_羽1.OP[this.右 ? 3 : 1].Outline;
			}
			set
			{
				this.X0Y0_風切羽_羽1.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_風切羽_羽1.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_風切羽_羽1.OP[this.右 ? 0 : 4].Outline = value;
			}
		}

		public bool 風切羽_羽2_外線
		{
			get
			{
				return this.X0Y0_風切羽_羽2.OP[this.右 ? 3 : 1].Outline;
			}
			set
			{
				this.X0Y0_風切羽_羽2.OP[this.右 ? 3 : 1].Outline = value;
				this.X0Y0_風切羽_羽2.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_風切羽_羽2.OP[this.右 ? 0 : 4].Outline = value;
			}
		}

		public bool 風切羽_羽3_外線
		{
			get
			{
				return this.X0Y0_風切羽_羽3.OP[this.右 ? 1 : 3].Outline;
			}
			set
			{
				this.X0Y0_風切羽_羽3.OP[this.右 ? 1 : 3].Outline = value;
				this.X0Y0_風切羽_羽3.OP[this.右 ? 0 : 4].Outline = value;
			}
		}

		public override void 描画0(Are Are)
		{
			Are.Draw(this.X0Y0_風切羽_羽3);
			Are.Draw(this.X0Y0_風切羽_羽2);
			Are.Draw(this.X0Y0_風切羽_羽1);
			Are.Draw(this.X0Y0_羽毛);
			Are.Draw(this.X0Y0_鳥翼上腕);
			Are.Draw(this.X0Y0_小雨覆);
			this.キスマ\u30FCク.Draw(Are);
			this.鞭痕.Draw(Are);
			Are.Draw(this.X0Y0_竜性_鱗1);
			Are.Draw(this.X0Y0_竜性_鱗2);
			Are.Draw(this.X0Y0_竜性_鱗3);
			Are.Draw(this.X0Y0_竜性_鱗4);
		}

		public bool 肘部_外線
		{
			get
			{
				return this.X0Y0_鳥翼上腕.OP[this.右 ? 2 : 1].Outline;
			}
			set
			{
				this.X0Y0_鳥翼上腕.OP[this.右 ? 2 : 1].Outline = value;
			}
		}

		public JointS 下腕_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_鳥翼上腕, 0);
			}
		}

		public override void 色更新()
		{
			this.X0Y0_風切羽_羽3CP.Update();
			this.X0Y0_風切羽_羽2CP.Update();
			this.X0Y0_風切羽_羽1CP.Update();
			this.X0Y0_羽毛CP.Update();
			this.X0Y0_鳥翼上腕CP.Update();
			this.X0Y0_小雨覆CP.Update();
			this.X0Y0_竜性_鱗1CP.Update();
			this.X0Y0_竜性_鱗2CP.Update();
			this.X0Y0_竜性_鱗3CP.Update();
			this.X0Y0_竜性_鱗4CP.Update();
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
			this.風切羽_羽3CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_羽2CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_羽1CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.羽毛CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.鳥翼上腕CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.小雨覆CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
			this.竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
		}

		private void 配色T0(体配色 体配色)
		{
			this.風切羽_羽3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.風切羽_羽2CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_羽1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽毛CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.鳥翼上腕CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.小雨覆CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
			this.竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
		}

		private void 配色T1(体配色 体配色)
		{
			this.風切羽_羽3CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.風切羽_羽2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.風切羽_羽1CD = new ColorD(ref Col.Black, ref 体配色.羽1O);
			this.羽毛CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.鳥翼上腕CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.小雨覆CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
			this.竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
		}

		public Par X0Y0_風切羽_羽3;

		public Par X0Y0_風切羽_羽2;

		public Par X0Y0_風切羽_羽1;

		public Par X0Y0_羽毛;

		public Par X0Y0_鳥翼上腕;

		public Par X0Y0_小雨覆;

		public Par X0Y0_竜性_鱗1;

		public Par X0Y0_竜性_鱗2;

		public Par X0Y0_竜性_鱗3;

		public Par X0Y0_竜性_鱗4;

		public ColorD 風切羽_羽3CD;

		public ColorD 風切羽_羽2CD;

		public ColorD 風切羽_羽1CD;

		public ColorD 羽毛CD;

		public ColorD 鳥翼上腕CD;

		public ColorD 小雨覆CD;

		public ColorD 竜性_鱗1CD;

		public ColorD 竜性_鱗2CD;

		public ColorD 竜性_鱗3CD;

		public ColorD 竜性_鱗4CD;

		public ColorP X0Y0_風切羽_羽3CP;

		public ColorP X0Y0_風切羽_羽2CP;

		public ColorP X0Y0_風切羽_羽1CP;

		public ColorP X0Y0_羽毛CP;

		public ColorP X0Y0_鳥翼上腕CP;

		public ColorP X0Y0_小雨覆CP;

		public ColorP X0Y0_竜性_鱗1CP;

		public ColorP X0Y0_竜性_鱗2CP;

		public ColorP X0Y0_竜性_鱗3CP;

		public ColorP X0Y0_竜性_鱗4CP;

		public スタンプK キスマ\u30FCク;

		public スタンプW 鞭痕;
	}
}
