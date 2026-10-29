using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 手_蝙 : 翼手
	{
		public 手_蝙(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 手_蝙D e)
		{
			this.飛膜 = new 飛膜_先(DisUnit, 配色指定, 体配色);
			this.飛膜.Par = this;
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.腕左["獣翼手"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_獣翼手 = pars["獣翼手"].ToPar();
			Pars pars2 = pars["小指"].ToPars();
			this.X0Y0_小指_指1 = pars2["指1"].ToPar();
			this.X0Y0_小指_指2 = pars2["指2"].ToPar();
			this.X0Y0_小指_指3 = pars2["指3"].ToPar();
			pars2 = pars["薬指"].ToPars();
			this.X0Y0_薬指_指1 = pars2["指1"].ToPar();
			this.X0Y0_薬指_指2 = pars2["指2"].ToPar();
			this.X0Y0_薬指_指3 = pars2["指3"].ToPar();
			pars2 = pars["中指"].ToPars();
			this.X0Y0_中指_指1 = pars2["指1"].ToPar();
			this.X0Y0_中指_指2 = pars2["指2"].ToPar();
			this.X0Y0_中指_指3 = pars2["指3"].ToPar();
			pars2 = pars["人指"].ToPars();
			this.X0Y0_人指_指1 = pars2["指1"].ToPar();
			this.X0Y0_人指_指2 = pars2["指2"].ToPar();
			this.X0Y0_人指_指3 = pars2["指3"].ToPar();
			pars2 = pars["親指"].ToPars();
			this.X0Y0_親指_指1 = pars2["指1"].ToPar();
			this.X0Y0_親指_指2 = pars2["指2"].ToPar();
			this.X0Y0_親指_指3 = pars2["指3"].ToPar();
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
			this.獣翼手_表示 = e.獣翼手_表示;
			this.小指_指1_表示 = e.小指_指1_表示;
			this.小指_指2_表示 = e.小指_指2_表示;
			this.小指_指3_表示 = e.小指_指3_表示;
			this.薬指_指1_表示 = e.薬指_指1_表示;
			this.薬指_指2_表示 = e.薬指_指2_表示;
			this.薬指_指3_表示 = e.薬指_指3_表示;
			this.中指_指1_表示 = e.中指_指1_表示;
			this.中指_指2_表示 = e.中指_指2_表示;
			this.中指_指3_表示 = e.中指_指3_表示;
			this.人指_指1_表示 = e.人指_指1_表示;
			this.人指_指2_表示 = e.人指_指2_表示;
			this.人指_指3_表示 = e.人指_指3_表示;
			this.親指_指1_表示 = e.親指_指1_表示;
			this.親指_指2_表示 = e.親指_指2_表示;
			this.親指_指3_表示 = e.親指_指3_表示;
			this.飛膜_表示 = e.飛膜_表示;
			this.展開 = e.展開;
			this.シャ\u30FCプ = e.シャ\u30FCプ;
			this.下部_外線 = e.下部_外線;
			this.接部_外線 = e.接部_外線;
			this.カ\u30FCブ = e.カ\u30FCブ;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_獣翼手CP = new ColorP(this.X0Y0_獣翼手, this.獣翼手CD, DisUnit, true);
			this.Pars1 = new Par[]
			{
				this.X0Y0_小指_指1,
				this.X0Y0_小指_指2,
				this.X0Y0_小指_指3
			};
			this.X0Y0_小指_指1CP = new ColorP(this.X0Y0_小指_指1, this.小指_指1CD, DisUnit, true);
			this.X0Y0_小指_指2CP = new ColorP(this.X0Y0_小指_指2, this.小指_指2CD, DisUnit, true);
			this.X0Y0_小指_指3CP = new ColorP(this.X0Y0_小指_指3, this.小指_指3CD, DisUnit, true);
			this.Pars2 = new Par[]
			{
				this.X0Y0_薬指_指1,
				this.X0Y0_薬指_指2,
				this.X0Y0_薬指_指3
			};
			this.X0Y0_薬指_指1CP = new ColorP(this.X0Y0_薬指_指1, this.薬指_指1CD, DisUnit, true);
			this.X0Y0_薬指_指2CP = new ColorP(this.X0Y0_薬指_指2, this.薬指_指2CD, DisUnit, true);
			this.X0Y0_薬指_指3CP = new ColorP(this.X0Y0_薬指_指3, this.薬指_指3CD, DisUnit, true);
			this.Pars3 = new Par[]
			{
				this.X0Y0_中指_指1,
				this.X0Y0_中指_指2,
				this.X0Y0_中指_指3
			};
			this.X0Y0_中指_指1CP = new ColorP(this.X0Y0_中指_指1, this.中指_指1CD, DisUnit, true);
			this.X0Y0_中指_指2CP = new ColorP(this.X0Y0_中指_指2, this.中指_指2CD, DisUnit, true);
			this.X0Y0_中指_指3CP = new ColorP(this.X0Y0_中指_指3, this.中指_指3CD, DisUnit, true);
			this.Pars4 = new Par[]
			{
				this.X0Y0_人指_指1,
				this.X0Y0_人指_指2,
				this.X0Y0_人指_指3
			};
			this.X0Y0_人指_指1CP = new ColorP(this.X0Y0_人指_指1, this.人指_指1CD, DisUnit, true);
			this.X0Y0_人指_指2CP = new ColorP(this.X0Y0_人指_指2, this.人指_指2CD, DisUnit, true);
			this.X0Y0_人指_指3CP = new ColorP(this.X0Y0_人指_指3, this.人指_指3CD, DisUnit, true);
			this.Pars5 = new Par[]
			{
				this.X0Y0_親指_指1,
				this.X0Y0_親指_指2
			};
			this.X0Y0_親指_指1CP = new ColorP(this.X0Y0_親指_指1, this.親指_指1CD, DisUnit, true);
			this.X0Y0_親指_指2CP = new ColorP(this.X0Y0_親指_指2, this.親指_指2CD, DisUnit, true);
			this.X0Y0_親指_指3CP = new ColorP(this.X0Y0_親指_指3, this.親指_指3CD, DisUnit, true);
			this.尺度B = 1.02;
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
				this.飛膜.欠損 = value;
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
				this.飛膜.筋肉 = value;
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
				this.飛膜.拘束 = value;
			}
		}

		public bool 獣翼手_表示
		{
			get
			{
				return this.X0Y0_獣翼手.Dra;
			}
			set
			{
				this.X0Y0_獣翼手.Dra = value;
				this.X0Y0_獣翼手.Hit = value;
			}
		}

		public bool 小指_指1_表示
		{
			get
			{
				return this.X0Y0_小指_指1.Dra;
			}
			set
			{
				this.X0Y0_小指_指1.Dra = value;
				this.X0Y0_小指_指1.Hit = value;
			}
		}

		public bool 小指_指2_表示
		{
			get
			{
				return this.X0Y0_小指_指2.Dra;
			}
			set
			{
				this.X0Y0_小指_指2.Dra = value;
				this.X0Y0_小指_指2.Hit = value;
			}
		}

		public bool 小指_指3_表示
		{
			get
			{
				return this.X0Y0_小指_指3.Dra;
			}
			set
			{
				this.X0Y0_小指_指3.Dra = value;
				this.X0Y0_小指_指3.Hit = value;
			}
		}

		public bool 薬指_指1_表示
		{
			get
			{
				return this.X0Y0_薬指_指1.Dra;
			}
			set
			{
				this.X0Y0_薬指_指1.Dra = value;
				this.X0Y0_薬指_指1.Hit = value;
			}
		}

		public bool 薬指_指2_表示
		{
			get
			{
				return this.X0Y0_薬指_指2.Dra;
			}
			set
			{
				this.X0Y0_薬指_指2.Dra = value;
				this.X0Y0_薬指_指2.Hit = value;
			}
		}

		public bool 薬指_指3_表示
		{
			get
			{
				return this.X0Y0_薬指_指3.Dra;
			}
			set
			{
				this.X0Y0_薬指_指3.Dra = value;
				this.X0Y0_薬指_指3.Hit = value;
			}
		}

		public bool 中指_指1_表示
		{
			get
			{
				return this.X0Y0_中指_指1.Dra;
			}
			set
			{
				this.X0Y0_中指_指1.Dra = value;
				this.X0Y0_中指_指1.Hit = value;
			}
		}

		public bool 中指_指2_表示
		{
			get
			{
				return this.X0Y0_中指_指2.Dra;
			}
			set
			{
				this.X0Y0_中指_指2.Dra = value;
				this.X0Y0_中指_指2.Hit = value;
			}
		}

		public bool 中指_指3_表示
		{
			get
			{
				return this.X0Y0_中指_指3.Dra;
			}
			set
			{
				this.X0Y0_中指_指3.Dra = value;
				this.X0Y0_中指_指3.Hit = value;
			}
		}

		public bool 人指_指1_表示
		{
			get
			{
				return this.X0Y0_人指_指1.Dra;
			}
			set
			{
				this.X0Y0_人指_指1.Dra = value;
				this.X0Y0_人指_指1.Hit = value;
			}
		}

		public bool 人指_指2_表示
		{
			get
			{
				return this.X0Y0_人指_指2.Dra;
			}
			set
			{
				this.X0Y0_人指_指2.Dra = value;
				this.X0Y0_人指_指2.Hit = value;
			}
		}

		public bool 人指_指3_表示
		{
			get
			{
				return this.X0Y0_人指_指3.Dra;
			}
			set
			{
				this.X0Y0_人指_指3.Dra = value;
				this.X0Y0_人指_指3.Hit = value;
			}
		}

		public bool 親指_指1_表示
		{
			get
			{
				return this.X0Y0_親指_指1.Dra;
			}
			set
			{
				this.X0Y0_親指_指1.Dra = value;
				this.X0Y0_親指_指1.Hit = value;
			}
		}

		public bool 親指_指2_表示
		{
			get
			{
				return this.X0Y0_親指_指2.Dra;
			}
			set
			{
				this.X0Y0_親指_指2.Dra = value;
				this.X0Y0_親指_指2.Hit = value;
			}
		}

		public bool 親指_指3_表示
		{
			get
			{
				return this.X0Y0_親指_指3.Dra;
			}
			set
			{
				this.X0Y0_親指_指3.Dra = value;
				this.X0Y0_親指_指3.Hit = value;
			}
		}

		public bool 飛膜_表示
		{
			get
			{
				return this.飛膜.飛膜_表示;
			}
			set
			{
				this.飛膜.飛膜_表示 = value;
				this.飛膜.飛膜_表示 = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.獣翼手_表示;
			}
			set
			{
				this.獣翼手_表示 = value;
				this.小指_指1_表示 = value;
				this.小指_指2_表示 = value;
				this.小指_指3_表示 = value;
				this.薬指_指1_表示 = value;
				this.薬指_指2_表示 = value;
				this.薬指_指3_表示 = value;
				this.中指_指1_表示 = value;
				this.中指_指2_表示 = value;
				this.中指_指3_表示 = value;
				this.人指_指1_表示 = value;
				this.人指_指2_表示 = value;
				this.人指_指3_表示 = value;
				this.親指_指1_表示 = value;
				this.親指_指2_表示 = value;
				this.親指_指3_表示 = value;
				this.飛膜_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.獣翼手CD.不透明度;
			}
			set
			{
				this.獣翼手CD.不透明度 = value;
				this.小指_指1CD.不透明度 = value;
				this.小指_指2CD.不透明度 = value;
				this.小指_指3CD.不透明度 = value;
				this.薬指_指1CD.不透明度 = value;
				this.薬指_指2CD.不透明度 = value;
				this.薬指_指3CD.不透明度 = value;
				this.中指_指1CD.不透明度 = value;
				this.中指_指2CD.不透明度 = value;
				this.中指_指3CD.不透明度 = value;
				this.人指_指1CD.不透明度 = value;
				this.人指_指2CD.不透明度 = value;
				this.人指_指3CD.不透明度 = value;
				this.親指_指1CD.不透明度 = value;
				this.親指_指2CD.不透明度 = value;
				this.親指_指3CD.不透明度 = value;
				this.飛膜.飛膜CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			double num = this.右 ? -1.0 : 1.0;
			this.X0Y0_獣翼手.AngleBase = num * -31.0000000000001;
			this.X0Y0_小指_指1.AngleBase = num * -79.3474786285473;
			this.X0Y0_小指_指2.AngleBase = num * -6.63284583292149;
			this.X0Y0_小指_指3.AngleBase = num * -5.51444226587368;
			this.X0Y0_薬指_指1.AngleBase = num * -29.8986006733114;
			this.X0Y0_薬指_指2.AngleBase = num * -9.09381595653455;
			this.X0Y0_薬指_指3.AngleBase = num * -15.3232033633539;
			this.X0Y0_中指_指1.AngleBase = num * -2.25244077487218;
			this.X0Y0_中指_指2.AngleBase = num * -349.728279240711;
			this.X0Y0_中指_指3.AngleBase = num * 330.298790583483;
			this.X0Y0_人指_指1.AngleBase = num * -340.637781414332;
			this.X0Y0_人指_指2.AngleBase = num * -14.7669119107363;
			this.X0Y0_人指_指3.AngleBase = num * 347.37149883769;
			this.X0Y0_親指_指1.AngleBase = num * -257.575894274218;
			this.X0Y0_親指_指2.AngleBase = num * 328.764949390357;
			this.X0Y0_親指_指3.AngleBase = num * 15.8109448838614;
			this.本体.JoinPAall();
		}

		public override double 展開
		{
			set
			{
				double num = value.Inverse();
				double num2 = this.右 ? -1.0 : 1.0;
				this.X0Y0_獣翼手.AngleCont = num2 * -74.0 * num;
				this.X0Y0_小指_指1.AngleCont = num2 * 10.0 * num;
				this.X0Y0_小指_指2.AngleCont = num2 * 0.0 * num;
				this.X0Y0_小指_指3.AngleCont = num2 * -1.0 * num;
				this.X0Y0_薬指_指1.AngleCont = num2 * -38.0 * num;
				this.X0Y0_薬指_指2.AngleCont = num2 * 2.0 * num;
				this.X0Y0_薬指_指3.AngleCont = num2 * 4.0 * num;
				this.X0Y0_中指_指1.AngleCont = num2 * -63.0 * num;
				this.X0Y0_中指_指2.AngleCont = num2 * -20.0 * num;
				this.X0Y0_中指_指3.AngleCont = num2 * 12.0 * num;
				this.X0Y0_人指_指1.AngleCont = num2 * -83.0 * num;
				this.X0Y0_人指_指2.AngleCont = num2 * 9.0 * num;
				this.X0Y0_人指_指3.AngleCont = num2 * 4.0 * num;
				this.X0Y0_親指_指1.AngleCont = num2 * -10.0 * num;
				this.X0Y0_親指_指2.AngleCont = num2 * -22.0 * num;
				this.X0Y0_親指_指3.AngleCont = num2 * -45.0 * num;
			}
		}

		public double シャ\u30FCプ
		{
			set
			{
				this.X0Y0_小指_指1.SizeXBase *= 1.0 - 0.4 * value;
				this.X0Y0_小指_指2.SizeXBase *= 1.0 - 0.4 * value;
				this.X0Y0_小指_指3.SizeXBase *= 1.0 - 0.4 * value;
				this.X0Y0_薬指_指1.SizeXBase *= 1.0 - 0.25 * value;
				this.X0Y0_薬指_指2.SizeXBase *= 1.0 - 0.25 * value;
				this.X0Y0_薬指_指3.SizeXBase *= 1.0 - 0.25 * value;
			}
		}

		public bool 下部_外線
		{
			get
			{
				return this.X0Y0_獣翼手.OP[this.右 ? 5 : 1].Outline;
			}
			set
			{
				this.X0Y0_獣翼手.OP[this.右 ? 5 : 1].Outline = value;
				this.X0Y0_小指_指1.OP[this.右 ? 0 : 3].Outline = value;
				this.X0Y0_小指_指2.OP[this.右 ? 0 : 3].Outline = value;
				this.X0Y0_小指_指3.OP[this.右 ? 0 : 2].Outline = value;
				this.X0Y0_薬指_指1.OP[this.右 ? 0 : 3].Outline = value;
				this.X0Y0_薬指_指2.OP[this.右 ? 0 : 3].Outline = value;
				this.X0Y0_薬指_指3.OP[this.右 ? 0 : 2].Outline = value;
				this.X0Y0_中指_指1.OP[this.右 ? 0 : 3].Outline = value;
				this.X0Y0_中指_指2.OP[this.右 ? 0 : 3].Outline = value;
				this.X0Y0_中指_指3.OP[this.右 ? 0 : 2].Outline = value;
				this.X0Y0_人指_指1.OP[this.右 ? 0 : 3].Outline = value;
				this.X0Y0_人指_指2.OP[this.右 ? 0 : 3].Outline = value;
				this.X0Y0_人指_指3.OP[this.右 ? 0 : 2].Outline = value;
			}
		}

		public bool 接部_外線
		{
			get
			{
				return this.飛膜.接部_外線;
			}
			set
			{
				this.飛膜.接部_外線 = value;
			}
		}

		public override void 描画0(Are Are)
		{
			Are.Draw(this.X0Y0_獣翼手);
			Are.Draw(this.X0Y0_小指_指1);
			Are.Draw(this.X0Y0_薬指_指1);
			Are.Draw(this.X0Y0_中指_指1);
			Are.Draw(this.X0Y0_人指_指1);
			Are.Draw(this.X0Y0_人指_指2);
			Are.Draw(this.X0Y0_親指_指1);
			Are.Draw(this.X0Y0_親指_指2);
			Are.Draw(this.X0Y0_親指_指3);
		}

		public void 指先描画(Are Are)
		{
			Are.Draw(this.X0Y0_小指_指2);
			Are.Draw(this.X0Y0_小指_指3);
			Are.Draw(this.X0Y0_薬指_指2);
			Are.Draw(this.X0Y0_薬指_指3);
			Are.Draw(this.X0Y0_中指_指2);
			Are.Draw(this.X0Y0_中指_指3);
			Are.Draw(this.X0Y0_人指_指3);
		}

		public override double 尺度B
		{
			get
			{
				return base.尺度B;
			}
			set
			{
				base.尺度B = value;
				this.飛膜.尺度B = value;
			}
		}

		public override double 尺度C
		{
			get
			{
				return base.尺度C;
			}
			set
			{
				base.尺度C = value;
				this.飛膜.尺度C = value;
			}
		}

		public override double 尺度XB
		{
			get
			{
				return base.尺度XB;
			}
			set
			{
				base.尺度XB = value;
				this.飛膜.尺度XB = value;
			}
		}

		public override double 尺度XC
		{
			get
			{
				return base.尺度XC;
			}
			set
			{
				base.尺度XC = value;
				this.飛膜.尺度XC = value;
			}
		}

		public override double 尺度YB
		{
			get
			{
				return base.尺度YB;
			}
			set
			{
				base.尺度YB = value;
				this.飛膜.尺度YB = value;
			}
		}

		public override double 尺度YC
		{
			get
			{
				return base.尺度YC;
			}
			set
			{
				base.尺度YC = value;
				this.飛膜.尺度YC = value;
			}
		}

		public override double 肥大
		{
			set
			{
				base.肥大 = value;
				this.飛膜.肥大 = value;
			}
		}

		public override double 身長
		{
			set
			{
				base.身長 = value;
				this.飛膜.身長 = value;
			}
		}

		public override bool 右
		{
			get
			{
				return base.右;
			}
			set
			{
				base.右 = value;
				this.飛膜.右 = value;
			}
		}

		public override bool 反転X
		{
			get
			{
				return base.反転X;
			}
			set
			{
				base.反転X = value;
				this.飛膜.反転X = value;
			}
		}

		public override bool 反転Y
		{
			get
			{
				return base.反転Y;
			}
			set
			{
				base.反転Y = value;
				this.飛膜.反転Y = value;
			}
		}

		public override double Xv
		{
			get
			{
				return base.Xv;
			}
			set
			{
				base.Xv = value;
				this.飛膜.Xv = value;
			}
		}

		public override double Yv
		{
			get
			{
				return base.Yv;
			}
			set
			{
				base.Yv = value;
				this.飛膜.Yv = value;
			}
		}

		public override int Xi
		{
			get
			{
				return base.Xi;
			}
			set
			{
				base.Xi = value;
				this.飛膜.Xi = value;
			}
		}

		public override int Yi
		{
			get
			{
				return base.Yi;
			}
			set
			{
				base.Yi = value;
				this.飛膜.Yi = value;
			}
		}

		public override void Dispose()
		{
			base.Dispose();
			this.飛膜.Dispose();
		}

		public override double サイズ
		{
			get
			{
				return this.サイズ_;
			}
			set
			{
				base.サイズ = value;
				this.飛膜.サイズ = value;
			}
		}

		public override double サイズX
		{
			get
			{
				return this.サイズX_;
			}
			set
			{
				base.サイズX = value;
				this.飛膜.サイズX = value;
			}
		}

		public override double サイズY
		{
			get
			{
				return this.サイズY_;
			}
			set
			{
				base.サイズY = value;
				this.飛膜.サイズY = value;
			}
		}

		public void 接続(上腕_蝙 上腕, 下腕_蝙 下腕, bool カ\u30FCブ)
		{
			this.飛膜.接続(上腕, 下腕, this, カ\u30FCブ);
		}

		public override void 色更新()
		{
			this.X0Y0_獣翼手CP.Update();
			this.Pars1.GetMiY_MaY(out this.mm);
			this.X0Y0_小指_指1CP.Update(this.mm);
			this.X0Y0_小指_指2CP.Update(this.mm);
			this.X0Y0_小指_指3CP.Update(this.mm);
			this.Pars2.GetMiY_MaY(out this.mm);
			this.X0Y0_薬指_指1CP.Update(this.mm);
			this.X0Y0_薬指_指2CP.Update(this.mm);
			this.X0Y0_薬指_指3CP.Update(this.mm);
			this.Pars3.GetMiY_MaY(out this.mm);
			this.X0Y0_中指_指1CP.Update(this.mm);
			this.X0Y0_中指_指2CP.Update(this.mm);
			this.X0Y0_中指_指3CP.Update(this.mm);
			this.Pars4.GetMiY_MaY(out this.mm);
			this.X0Y0_人指_指1CP.Update(this.mm);
			this.X0Y0_人指_指2CP.Update(this.mm);
			this.X0Y0_人指_指3CP.Update(this.mm);
			this.Pars5.GetMiY_MaY(out this.mm);
			this.X0Y0_親指_指1CP.Update(this.mm);
			this.X0Y0_親指_指2CP.Update(this.mm);
			this.X0Y0_親指_指3CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.獣翼手CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.小指_指1CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
			this.小指_指2CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
			this.小指_指3CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
			this.薬指_指1CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
			this.薬指_指2CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
			this.薬指_指3CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
			this.中指_指1CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
			this.中指_指2CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
			this.中指_指3CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
			this.人指_指1CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
			this.人指_指2CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
			this.人指_指3CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
			this.親指_指1CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
			this.親指_指2CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
			this.親指_指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
		}

		public Par X0Y0_獣翼手;

		public Par X0Y0_小指_指1;

		public Par X0Y0_小指_指2;

		public Par X0Y0_小指_指3;

		public Par X0Y0_薬指_指1;

		public Par X0Y0_薬指_指2;

		public Par X0Y0_薬指_指3;

		public Par X0Y0_中指_指1;

		public Par X0Y0_中指_指2;

		public Par X0Y0_中指_指3;

		public Par X0Y0_人指_指1;

		public Par X0Y0_人指_指2;

		public Par X0Y0_人指_指3;

		public Par X0Y0_親指_指1;

		public Par X0Y0_親指_指2;

		public Par X0Y0_親指_指3;

		public 飛膜_先 飛膜;

		public ColorD 獣翼手CD;

		public ColorD 小指_指1CD;

		public ColorD 小指_指2CD;

		public ColorD 小指_指3CD;

		public ColorD 薬指_指1CD;

		public ColorD 薬指_指2CD;

		public ColorD 薬指_指3CD;

		public ColorD 中指_指1CD;

		public ColorD 中指_指2CD;

		public ColorD 中指_指3CD;

		public ColorD 人指_指1CD;

		public ColorD 人指_指2CD;

		public ColorD 人指_指3CD;

		public ColorD 親指_指1CD;

		public ColorD 親指_指2CD;

		public ColorD 親指_指3CD;

		public ColorP X0Y0_獣翼手CP;

		public ColorP X0Y0_小指_指1CP;

		public ColorP X0Y0_小指_指2CP;

		public ColorP X0Y0_小指_指3CP;

		public ColorP X0Y0_薬指_指1CP;

		public ColorP X0Y0_薬指_指2CP;

		public ColorP X0Y0_薬指_指3CP;

		public ColorP X0Y0_中指_指1CP;

		public ColorP X0Y0_中指_指2CP;

		public ColorP X0Y0_中指_指3CP;

		public ColorP X0Y0_人指_指1CP;

		public ColorP X0Y0_人指_指2CP;

		public ColorP X0Y0_人指_指3CP;

		public ColorP X0Y0_親指_指1CP;

		public ColorP X0Y0_親指_指2CP;

		public ColorP X0Y0_親指_指3CP;

		public bool カ\u30FCブ;

		public Par[] Pars1;

		public Par[] Pars2;

		public Par[] Pars3;

		public Par[] Pars4;

		public Par[] Pars5;

		private Vector2D[] mm;
	}
}
