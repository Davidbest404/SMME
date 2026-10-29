using System;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class ボテ腹_人 : ボテ腹
	{
		public ボテ腹_人(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, ボテ腹_人D e)
		{
			ボテ腹_人.<>c__DisplayClass77_0 CS$<>8__locals1 = new ボテ腹_人.<>c__DisplayClass77_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.胴体["ボテ腹"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_腹 = pars["腹"].ToPar();
			this.X0Y0_ハイライト = pars["ハイライト"].ToPar();
			this.X0Y0_臍 = pars["臍"].ToPar();
			this.X0Y0_ハイライト左1 = pars["ハイライト左1"].ToPar();
			this.X0Y0_ハイライト左2 = pars["ハイライト左2"].ToPar();
			this.X0Y0_ハイライト右1 = pars["ハイライト右1"].ToPar();
			this.X0Y0_ハイライト右2 = pars["ハイライト右2"].ToPar();
			pars = this.本体[0][1];
			this.X0Y1_腹 = pars["腹"].ToPar();
			this.X0Y1_ハイライト = pars["ハイライト"].ToPar();
			this.X0Y1_臍 = pars["臍"].ToPar();
			this.X0Y1_ハイライト左1 = pars["ハイライト左1"].ToPar();
			this.X0Y1_ハイライト左2 = pars["ハイライト左2"].ToPar();
			this.X0Y1_ハイライト右1 = pars["ハイライト右1"].ToPar();
			this.X0Y1_ハイライト右2 = pars["ハイライト右2"].ToPar();
			pars = this.本体[0][2];
			this.X0Y2_腹 = pars["腹"].ToPar();
			this.X0Y2_ハイライト = pars["ハイライト"].ToPar();
			this.X0Y2_臍 = pars["臍"].ToPar();
			this.X0Y2_ハイライト左1 = pars["ハイライト左1"].ToPar();
			this.X0Y2_ハイライト左2 = pars["ハイライト左2"].ToPar();
			this.X0Y2_ハイライト右1 = pars["ハイライト右1"].ToPar();
			this.X0Y2_ハイライト右2 = pars["ハイライト右2"].ToPar();
			pars = this.本体[0][3];
			this.X0Y3_腹 = pars["腹"].ToPar();
			this.X0Y3_ハイライト = pars["ハイライト"].ToPar();
			this.X0Y3_臍 = pars["臍"].ToPar();
			this.X0Y3_ハイライト左1 = pars["ハイライト左1"].ToPar();
			this.X0Y3_ハイライト左2 = pars["ハイライト左2"].ToPar();
			this.X0Y3_ハイライト右1 = pars["ハイライト右1"].ToPar();
			this.X0Y3_ハイライト右2 = pars["ハイライト右2"].ToPar();
			pars = this.本体[0][4];
			this.X0Y4_腹 = pars["腹"].ToPar();
			this.X0Y4_ハイライト = pars["ハイライト"].ToPar();
			this.X0Y4_臍 = pars["臍"].ToPar();
			this.X0Y4_ハイライト左1 = pars["ハイライト左1"].ToPar();
			this.X0Y4_ハイライト左2 = pars["ハイライト左2"].ToPar();
			this.X0Y4_ハイライト右1 = pars["ハイライト右1"].ToPar();
			this.X0Y4_ハイライト右2 = pars["ハイライト右2"].ToPar();
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
			this.腹_表示 = e.腹_表示;
			this.ハイライト_表示 = e.ハイライト_表示;
			this.臍_表示 = e.臍_表示;
			this.ハイライト左1_表示 = e.ハイライト左1_表示;
			this.ハイライト左2_表示 = e.ハイライト左2_表示;
			this.ハイライト右1_表示 = e.ハイライト右1_表示;
			this.ハイライト右2_表示 = e.ハイライト右2_表示;
			this.ハイライト表示 = e.ハイライト表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.腹板_接続.Count > 0)
			{
				Ele f;
				this.腹板_接続 = e.腹板_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.ボテ腹_人_腹板_接続;
					f.接続(CS$<>8__locals1.<>4__this.腹板_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_腹CP = new ColorP(this.X0Y0_腹, this.腹CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ハイライトCP = new ColorP(this.X0Y0_ハイライト, this.ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_臍CP = new ColorP(this.X0Y0_臍, this.臍CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_ハイライト左1CP = new ColorP(this.X0Y0_ハイライト左1, this.ハイライト左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ハイライト左2CP = new ColorP(this.X0Y0_ハイライト左2, this.ハイライト左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ハイライト右1CP = new ColorP(this.X0Y0_ハイライト右1, this.ハイライト右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ハイライト右2CP = new ColorP(this.X0Y0_ハイライト右2, this.ハイライト右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_腹CP = new ColorP(this.X0Y1_腹, this.腹CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ハイライトCP = new ColorP(this.X0Y1_ハイライト, this.ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_臍CP = new ColorP(this.X0Y1_臍, this.臍CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y1_ハイライト左1CP = new ColorP(this.X0Y1_ハイライト左1, this.ハイライト左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ハイライト左2CP = new ColorP(this.X0Y1_ハイライト左2, this.ハイライト左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ハイライト右1CP = new ColorP(this.X0Y1_ハイライト右1, this.ハイライト右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ハイライト右2CP = new ColorP(this.X0Y1_ハイライト右2, this.ハイライト右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_腹CP = new ColorP(this.X0Y2_腹, this.腹CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_ハイライトCP = new ColorP(this.X0Y2_ハイライト, this.ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_臍CP = new ColorP(this.X0Y2_臍, this.臍CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y2_ハイライト左1CP = new ColorP(this.X0Y2_ハイライト左1, this.ハイライト左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_ハイライト左2CP = new ColorP(this.X0Y2_ハイライト左2, this.ハイライト左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_ハイライト右1CP = new ColorP(this.X0Y2_ハイライト右1, this.ハイライト右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_ハイライト右2CP = new ColorP(this.X0Y2_ハイライト右2, this.ハイライト右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_腹CP = new ColorP(this.X0Y3_腹, this.腹CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_ハイライトCP = new ColorP(this.X0Y3_ハイライト, this.ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_臍CP = new ColorP(this.X0Y3_臍, this.臍CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y3_ハイライト左1CP = new ColorP(this.X0Y3_ハイライト左1, this.ハイライト左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_ハイライト左2CP = new ColorP(this.X0Y3_ハイライト左2, this.ハイライト左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_ハイライト右1CP = new ColorP(this.X0Y3_ハイライト右1, this.ハイライト右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_ハイライト右2CP = new ColorP(this.X0Y3_ハイライト右2, this.ハイライト右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_腹CP = new ColorP(this.X0Y4_腹, this.腹CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_ハイライトCP = new ColorP(this.X0Y4_ハイライト, this.ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_臍CP = new ColorP(this.X0Y4_臍, this.臍CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y4_ハイライト左1CP = new ColorP(this.X0Y4_ハイライト左1, this.ハイライト左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_ハイライト左2CP = new ColorP(this.X0Y4_ハイライト左2, this.ハイライト左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_ハイライト右1CP = new ColorP(this.X0Y4_ハイライト右1, this.ハイライト右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_ハイライト右2CP = new ColorP(this.X0Y4_ハイライト右2, this.ハイライト右2CD, CS$<>8__locals1.DisUnit, true);
			this.ハイライト濃度 = e.ハイライト濃度;
			this.濃度 = e.濃度;
			this.尺度YB = 0.95;
			this.X0Y0_臍.BasePointBase = new Vector2D(this.X0Y0_臍.BasePointBase.X, 0.363449439772374);
			this.X0Y1_臍.BasePointBase = new Vector2D(this.X0Y1_臍.BasePointBase.X, 0.363808225004133);
			this.X0Y2_臍.BasePointBase = new Vector2D(this.X0Y2_臍.BasePointBase.X, 0.364167010235893);
			this.X0Y3_臍.BasePointBase = new Vector2D(this.X0Y3_臍.BasePointBase.X, 0.364525795467652);
			this.X0Y4_臍.BasePointBase = new Vector2D(this.X0Y4_臍.BasePointBase.X, 0.364884580699412);
			this.X0Y0_ハイライト.BasePointBase = new Vector2D(this.X0Y0_ハイライト.BasePointBase.X, 0.0219448899681257);
			this.X0Y1_ハイライト.BasePointBase = new Vector2D(this.X0Y1_ハイライト.BasePointBase.X, 0.0223873272658702);
			this.X0Y2_ハイライト.BasePointBase = new Vector2D(this.X0Y2_ハイライト.BasePointBase.X, 0.0228297645636147);
			this.X0Y3_ハイライト.BasePointBase = new Vector2D(this.X0Y3_ハイライト.BasePointBase.X, 0.0232722018613592);
			this.X0Y4_ハイライト.BasePointBase = new Vector2D(this.X0Y4_ハイライト.BasePointBase.X, 0.0237146391591036);
			double num = 1.5;
			this.X0Y0_臍.SizeBase *= num;
			this.X0Y1_臍.SizeBase *= num;
			this.X0Y2_臍.SizeBase *= num;
			this.X0Y3_臍.SizeBase *= num;
			this.X0Y4_臍.SizeBase *= num;
			this.X0Y0_ハイライト.SizeBase *= num;
			this.X0Y1_ハイライト.SizeBase *= num;
			this.X0Y2_ハイライト.SizeBase *= num;
			this.X0Y3_ハイライト.SizeBase *= num;
			this.X0Y4_ハイライト.SizeBase *= num;
			num = 0.6;
			this.X0Y0_臍.SizeXBase *= num;
			this.X0Y1_臍.SizeXBase *= num;
			this.X0Y2_臍.SizeXBase *= num;
			this.X0Y3_臍.SizeXBase *= num;
			this.X0Y4_臍.SizeXBase *= num;
			this.X0Y0_ハイライト.SizeXBase *= num;
			this.X0Y1_ハイライト.SizeXBase *= num;
			this.X0Y2_ハイライト.SizeXBase *= num;
			this.X0Y3_ハイライト.SizeXBase *= num;
			this.X0Y4_ハイライト.SizeXBase *= num;
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

		public bool 腹_表示
		{
			get
			{
				return this.X0Y0_腹.Dra;
			}
			set
			{
				this.X0Y0_腹.Dra = value;
				this.X0Y1_腹.Dra = value;
				this.X0Y2_腹.Dra = value;
				this.X0Y3_腹.Dra = value;
				this.X0Y4_腹.Dra = value;
				this.X0Y0_腹.Hit = value;
				this.X0Y1_腹.Hit = value;
				this.X0Y2_腹.Hit = value;
				this.X0Y3_腹.Hit = value;
				this.X0Y4_腹.Hit = value;
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
				this.X0Y1_ハイライト.Dra = value;
				this.X0Y2_ハイライト.Dra = value;
				this.X0Y3_ハイライト.Dra = value;
				this.X0Y4_ハイライト.Dra = value;
				this.X0Y0_ハイライト.Hit = value;
				this.X0Y1_ハイライト.Hit = value;
				this.X0Y2_ハイライト.Hit = value;
				this.X0Y3_ハイライト.Hit = value;
				this.X0Y4_ハイライト.Hit = value;
			}
		}

		public bool 臍_表示
		{
			get
			{
				return this.X0Y0_臍.Dra;
			}
			set
			{
				this.X0Y0_臍.Dra = value;
				this.X0Y1_臍.Dra = value;
				this.X0Y2_臍.Dra = value;
				this.X0Y3_臍.Dra = value;
				this.X0Y4_臍.Dra = value;
				this.X0Y0_臍.Hit = value;
				this.X0Y1_臍.Hit = value;
				this.X0Y2_臍.Hit = value;
				this.X0Y3_臍.Hit = value;
				this.X0Y4_臍.Hit = value;
			}
		}

		public bool ハイライト左1_表示
		{
			get
			{
				return this.X0Y0_ハイライト左1.Dra;
			}
			set
			{
				this.X0Y0_ハイライト左1.Dra = value;
				this.X0Y1_ハイライト左1.Dra = value;
				this.X0Y2_ハイライト左1.Dra = value;
				this.X0Y3_ハイライト左1.Dra = value;
				this.X0Y4_ハイライト左1.Dra = value;
				this.X0Y0_ハイライト左1.Hit = value;
				this.X0Y1_ハイライト左1.Hit = value;
				this.X0Y2_ハイライト左1.Hit = value;
				this.X0Y3_ハイライト左1.Hit = value;
				this.X0Y4_ハイライト左1.Hit = value;
			}
		}

		public bool ハイライト左2_表示
		{
			get
			{
				return this.X0Y0_ハイライト左2.Dra;
			}
			set
			{
				this.X0Y0_ハイライト左2.Dra = value;
				this.X0Y1_ハイライト左2.Dra = value;
				this.X0Y2_ハイライト左2.Dra = value;
				this.X0Y3_ハイライト左2.Dra = value;
				this.X0Y4_ハイライト左2.Dra = value;
				this.X0Y0_ハイライト左2.Hit = value;
				this.X0Y1_ハイライト左2.Hit = value;
				this.X0Y2_ハイライト左2.Hit = value;
				this.X0Y3_ハイライト左2.Hit = value;
				this.X0Y4_ハイライト左2.Hit = value;
			}
		}

		public bool ハイライト右1_表示
		{
			get
			{
				return this.X0Y0_ハイライト右1.Dra;
			}
			set
			{
				this.X0Y0_ハイライト右1.Dra = value;
				this.X0Y1_ハイライト右1.Dra = value;
				this.X0Y2_ハイライト右1.Dra = value;
				this.X0Y3_ハイライト右1.Dra = value;
				this.X0Y4_ハイライト右1.Dra = value;
				this.X0Y0_ハイライト右1.Hit = value;
				this.X0Y1_ハイライト右1.Hit = value;
				this.X0Y2_ハイライト右1.Hit = value;
				this.X0Y3_ハイライト右1.Hit = value;
				this.X0Y4_ハイライト右1.Hit = value;
			}
		}

		public bool ハイライト右2_表示
		{
			get
			{
				return this.X0Y0_ハイライト右2.Dra;
			}
			set
			{
				this.X0Y0_ハイライト右2.Dra = value;
				this.X0Y1_ハイライト右2.Dra = value;
				this.X0Y2_ハイライト右2.Dra = value;
				this.X0Y3_ハイライト右2.Dra = value;
				this.X0Y4_ハイライト右2.Dra = value;
				this.X0Y0_ハイライト右2.Hit = value;
				this.X0Y1_ハイライト右2.Hit = value;
				this.X0Y2_ハイライト右2.Hit = value;
				this.X0Y3_ハイライト右2.Hit = value;
				this.X0Y4_ハイライト右2.Hit = value;
			}
		}

		public bool ハイライト表示
		{
			get
			{
				return this.ハイライト_表示;
			}
			set
			{
				this.ハイライト_表示 = value;
				this.ハイライト左1_表示 = value;
				this.ハイライト左2_表示 = value;
				this.ハイライト右1_表示 = value;
				this.ハイライト右2_表示 = value;
			}
		}

		public double ハイライト濃度
		{
			get
			{
				return this.ハイライトCD.不透明度;
			}
			set
			{
				this.ハイライトCD.不透明度 = value;
				this.ハイライト左1CD.不透明度 = value;
				this.ハイライト左2CD.不透明度 = value;
				this.ハイライト右1CD.不透明度 = value;
				this.ハイライト右2CD.不透明度 = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.腹_表示;
			}
			set
			{
				this.腹_表示 = value;
				this.ハイライト_表示 = value;
				this.臍_表示 = value;
				this.ハイライト左1_表示 = value;
				this.ハイライト左2_表示 = value;
				this.ハイライト右1_表示 = value;
				this.ハイライト右2_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.腹CD.不透明度;
			}
			set
			{
				this.腹CD.不透明度 = value;
				this.ハイライトCD.不透明度 = value;
				this.臍CD.不透明度 = value;
				this.ハイライト左1CD.不透明度 = value;
				this.ハイライト左2CD.不透明度 = value;
				this.ハイライト右1CD.不透明度 = value;
				this.ハイライト右2CD.不透明度 = value;
			}
		}

		public override void 描画0(Are Are)
		{
			this.本体.Draw(Are);
			this.キスマ\u30FCク.Draw(Are);
			this.鞭痕.Draw(Are);
		}

		public JointS 腹板_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_腹, 0);
			}
		}

		public override void 色更新()
		{
			switch (this.本体.IndexY)
			{
			case 0:
				this.X0Y0_腹CP.Update();
				this.X0Y0_ハイライトCP.Update();
				this.X0Y0_臍CP.Update();
				this.X0Y0_ハイライト左1CP.Update();
				this.X0Y0_ハイライト左2CP.Update();
				this.X0Y0_ハイライト右1CP.Update();
				this.X0Y0_ハイライト右2CP.Update();
				return;
			case 1:
				this.X0Y1_腹CP.Update();
				this.X0Y1_ハイライトCP.Update();
				this.X0Y1_臍CP.Update();
				this.X0Y1_ハイライト左1CP.Update();
				this.X0Y1_ハイライト左2CP.Update();
				this.X0Y1_ハイライト右1CP.Update();
				this.X0Y1_ハイライト右2CP.Update();
				return;
			case 2:
				this.X0Y2_腹CP.Update();
				this.X0Y2_ハイライトCP.Update();
				this.X0Y2_臍CP.Update();
				this.X0Y2_ハイライト左1CP.Update();
				this.X0Y2_ハイライト左2CP.Update();
				this.X0Y2_ハイライト右1CP.Update();
				this.X0Y2_ハイライト右2CP.Update();
				return;
			case 3:
				this.X0Y3_腹CP.Update();
				this.X0Y3_ハイライトCP.Update();
				this.X0Y3_臍CP.Update();
				this.X0Y3_ハイライト左1CP.Update();
				this.X0Y3_ハイライト左2CP.Update();
				this.X0Y3_ハイライト右1CP.Update();
				this.X0Y3_ハイライト右2CP.Update();
				return;
			default:
				this.X0Y4_腹CP.Update();
				this.X0Y4_ハイライトCP.Update();
				this.X0Y4_臍CP.Update();
				this.X0Y4_ハイライト左1CP.Update();
				this.X0Y4_ハイライト左2CP.Update();
				this.X0Y4_ハイライト右1CP.Update();
				this.X0Y4_ハイライト右2CP.Update();
				return;
			}
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.腹CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.臍CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.ハイライト左1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ハイライト左2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2R);
			this.ハイライト右1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ハイライト右2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2R);
		}

		public Par X0Y0_腹;

		public Par X0Y0_ハイライト;

		public Par X0Y0_臍;

		public Par X0Y0_ハイライト左1;

		public Par X0Y0_ハイライト左2;

		public Par X0Y0_ハイライト右1;

		public Par X0Y0_ハイライト右2;

		public Par X0Y1_腹;

		public Par X0Y1_ハイライト;

		public Par X0Y1_臍;

		public Par X0Y1_ハイライト左1;

		public Par X0Y1_ハイライト左2;

		public Par X0Y1_ハイライト右1;

		public Par X0Y1_ハイライト右2;

		public Par X0Y2_腹;

		public Par X0Y2_ハイライト;

		public Par X0Y2_臍;

		public Par X0Y2_ハイライト左1;

		public Par X0Y2_ハイライト左2;

		public Par X0Y2_ハイライト右1;

		public Par X0Y2_ハイライト右2;

		public Par X0Y3_腹;

		public Par X0Y3_ハイライト;

		public Par X0Y3_臍;

		public Par X0Y3_ハイライト左1;

		public Par X0Y3_ハイライト左2;

		public Par X0Y3_ハイライト右1;

		public Par X0Y3_ハイライト右2;

		public Par X0Y4_腹;

		public Par X0Y4_ハイライト;

		public Par X0Y4_臍;

		public Par X0Y4_ハイライト左1;

		public Par X0Y4_ハイライト左2;

		public Par X0Y4_ハイライト右1;

		public Par X0Y4_ハイライト右2;

		public ColorD 腹CD;

		public ColorD ハイライトCD;

		public ColorD 臍CD;

		public ColorD ハイライト左1CD;

		public ColorD ハイライト左2CD;

		public ColorD ハイライト右1CD;

		public ColorD ハイライト右2CD;

		public ColorP X0Y0_腹CP;

		public ColorP X0Y0_ハイライトCP;

		public ColorP X0Y0_臍CP;

		public ColorP X0Y0_ハイライト左1CP;

		public ColorP X0Y0_ハイライト左2CP;

		public ColorP X0Y0_ハイライト右1CP;

		public ColorP X0Y0_ハイライト右2CP;

		public ColorP X0Y1_腹CP;

		public ColorP X0Y1_ハイライトCP;

		public ColorP X0Y1_臍CP;

		public ColorP X0Y1_ハイライト左1CP;

		public ColorP X0Y1_ハイライト左2CP;

		public ColorP X0Y1_ハイライト右1CP;

		public ColorP X0Y1_ハイライト右2CP;

		public ColorP X0Y2_腹CP;

		public ColorP X0Y2_ハイライトCP;

		public ColorP X0Y2_臍CP;

		public ColorP X0Y2_ハイライト左1CP;

		public ColorP X0Y2_ハイライト左2CP;

		public ColorP X0Y2_ハイライト右1CP;

		public ColorP X0Y2_ハイライト右2CP;

		public ColorP X0Y3_腹CP;

		public ColorP X0Y3_ハイライトCP;

		public ColorP X0Y3_臍CP;

		public ColorP X0Y3_ハイライト左1CP;

		public ColorP X0Y3_ハイライト左2CP;

		public ColorP X0Y3_ハイライト右1CP;

		public ColorP X0Y3_ハイライト右2CP;

		public ColorP X0Y4_腹CP;

		public ColorP X0Y4_ハイライトCP;

		public ColorP X0Y4_臍CP;

		public ColorP X0Y4_ハイライト左1CP;

		public ColorP X0Y4_ハイライト左2CP;

		public ColorP X0Y4_ハイライト右1CP;

		public ColorP X0Y4_ハイライト右2CP;

		public スタンプK キスマ\u30FCク;

		public スタンプW 鞭痕;

		public Ele[] 腹板_接続;
	}
}
