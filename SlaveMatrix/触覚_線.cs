using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 触覚_線 : 触覚
	{
		public 触覚_線(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 触覚_線D e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "線";
			dif.Add(new Pars(Sta.肢左["触覚"][0][0]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_節1 = pars["節1"].ToPar();
			this.X0Y0_節2 = pars["節2"].ToPar();
			this.X0Y0_節3 = pars["節3"].ToPar();
			this.X0Y0_節4 = pars["節4"].ToPar();
			this.X0Y0_節5 = pars["節5"].ToPar();
			this.X0Y0_節6 = pars["節6"].ToPar();
			this.X0Y0_節7 = pars["節7"].ToPar();
			this.X0Y0_節8 = pars["節8"].ToPar();
			this.X0Y0_節9 = pars["節9"].ToPar();
			this.X0Y0_節10 = pars["節10"].ToPar();
			this.X0Y0_節11 = pars["節11"].ToPar();
			this.X0Y0_節12 = pars["節12"].ToPar();
			this.X0Y0_節13 = pars["節13"].ToPar();
			this.X0Y0_節14 = pars["節14"].ToPar();
			this.X0Y0_節15 = pars["節15"].ToPar();
			this.X0Y0_節16 = pars["節16"].ToPar();
			this.X0Y0_節17 = pars["節17"].ToPar();
			this.X0Y0_節18 = pars["節18"].ToPar();
			this.X0Y0_節19 = pars["節19"].ToPar();
			this.X0Y0_節20 = pars["節20"].ToPar();
			this.X0Y0_節21 = pars["節21"].ToPar();
			this.X0Y0_節22 = pars["節22"].ToPar();
			this.X0Y0_節23 = pars["節23"].ToPar();
			this.X0Y0_節24 = pars["節24"].ToPar();
			this.X0Y0_節25 = pars["節25"].ToPar();
			this.X0Y0_節26 = pars["節26"].ToPar();
			this.X0Y0_節27 = pars["節27"].ToPar();
			this.X0Y0_節28 = pars["節28"].ToPar();
			this.X0Y0_節29 = pars["節29"].ToPar();
			this.X0Y0_節30 = pars["節30"].ToPar();
			this.X0Y0_節31 = pars["節31"].ToPar();
			this.X0Y0_節32 = pars["節32"].ToPar();
			this.X0Y0_節33 = pars["節33"].ToPar();
			this.X0Y0_節34 = pars["節34"].ToPar();
			this.X0Y0_節35 = pars["節35"].ToPar();
			this.X0Y0_節36 = pars["節36"].ToPar();
			this.X0Y0_節37 = pars["節37"].ToPar();
			this.X0Y0_節38 = pars["節38"].ToPar();
			this.X0Y0_節39 = pars["節39"].ToPar();
			this.X0Y0_節40 = pars["節40"].ToPar();
			this.X0Y0_節41 = pars["節41"].ToPar();
			this.X0Y0_節42 = pars["節42"].ToPar();
			this.X0Y0_節43 = pars["節43"].ToPar();
			this.X0Y0_節44 = pars["節44"].ToPar();
			this.X0Y0_節45 = pars["節45"].ToPar();
			this.X0Y0_節46 = pars["節46"].ToPar();
			this.X0Y0_節47 = pars["節47"].ToPar();
			this.X0Y0_節48 = pars["節48"].ToPar();
			this.X0Y0_節49 = pars["節49"].ToPar();
			this.X0Y0_節50 = pars["節50"].ToPar();
			this.X0Y0_節51 = pars["節51"].ToPar();
			this.X0Y0_節52 = pars["節52"].ToPar();
			this.X0Y0_節53 = pars["節53"].ToPar();
			this.X0Y0_節54 = pars["節54"].ToPar();
			this.X0Y0_節55 = pars["節55"].ToPar();
			this.X0Y0_節56 = pars["節56"].ToPar();
			this.X0Y0_節57 = pars["節57"].ToPar();
			this.X0Y0_節58 = pars["節58"].ToPar();
			this.X0Y0_節59 = pars["節59"].ToPar();
			this.X0Y0_節60 = pars["節60"].ToPar();
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
			this.節1_表示 = e.節1_表示;
			this.節2_表示 = e.節2_表示;
			this.節3_表示 = e.節3_表示;
			this.節4_表示 = e.節4_表示;
			this.節5_表示 = e.節5_表示;
			this.節6_表示 = e.節6_表示;
			this.節7_表示 = e.節7_表示;
			this.節8_表示 = e.節8_表示;
			this.節9_表示 = e.節9_表示;
			this.節10_表示 = e.節10_表示;
			this.節11_表示 = e.節11_表示;
			this.節12_表示 = e.節12_表示;
			this.節13_表示 = e.節13_表示;
			this.節14_表示 = e.節14_表示;
			this.節15_表示 = e.節15_表示;
			this.節16_表示 = e.節16_表示;
			this.節17_表示 = e.節17_表示;
			this.節18_表示 = e.節18_表示;
			this.節19_表示 = e.節19_表示;
			this.節20_表示 = e.節20_表示;
			this.節21_表示 = e.節21_表示;
			this.節22_表示 = e.節22_表示;
			this.節23_表示 = e.節23_表示;
			this.節24_表示 = e.節24_表示;
			this.節25_表示 = e.節25_表示;
			this.節26_表示 = e.節26_表示;
			this.節27_表示 = e.節27_表示;
			this.節28_表示 = e.節28_表示;
			this.節29_表示 = e.節29_表示;
			this.節30_表示 = e.節30_表示;
			this.節31_表示 = e.節31_表示;
			this.節32_表示 = e.節32_表示;
			this.節33_表示 = e.節33_表示;
			this.節34_表示 = e.節34_表示;
			this.節35_表示 = e.節35_表示;
			this.節36_表示 = e.節36_表示;
			this.節37_表示 = e.節37_表示;
			this.節38_表示 = e.節38_表示;
			this.節39_表示 = e.節39_表示;
			this.節40_表示 = e.節40_表示;
			this.節41_表示 = e.節41_表示;
			this.節42_表示 = e.節42_表示;
			this.節43_表示 = e.節43_表示;
			this.節44_表示 = e.節44_表示;
			this.節45_表示 = e.節45_表示;
			this.節46_表示 = e.節46_表示;
			this.節47_表示 = e.節47_表示;
			this.節48_表示 = e.節48_表示;
			this.節49_表示 = e.節49_表示;
			this.節50_表示 = e.節50_表示;
			this.節51_表示 = e.節51_表示;
			this.節52_表示 = e.節52_表示;
			this.節53_表示 = e.節53_表示;
			this.節54_表示 = e.節54_表示;
			this.節55_表示 = e.節55_表示;
			this.節56_表示 = e.節56_表示;
			this.節57_表示 = e.節57_表示;
			this.節58_表示 = e.節58_表示;
			this.節59_表示 = e.節59_表示;
			this.節60_表示 = e.節60_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_節1CP = new ColorP(this.X0Y0_節1, this.節1CD, DisUnit, true);
			this.X0Y0_節2CP = new ColorP(this.X0Y0_節2, this.節2CD, DisUnit, true);
			this.X0Y0_節3CP = new ColorP(this.X0Y0_節3, this.節3CD, DisUnit, true);
			this.X0Y0_節4CP = new ColorP(this.X0Y0_節4, this.節4CD, DisUnit, true);
			this.X0Y0_節5CP = new ColorP(this.X0Y0_節5, this.節5CD, DisUnit, true);
			this.X0Y0_節6CP = new ColorP(this.X0Y0_節6, this.節6CD, DisUnit, true);
			this.X0Y0_節7CP = new ColorP(this.X0Y0_節7, this.節7CD, DisUnit, true);
			this.X0Y0_節8CP = new ColorP(this.X0Y0_節8, this.節8CD, DisUnit, true);
			this.X0Y0_節9CP = new ColorP(this.X0Y0_節9, this.節9CD, DisUnit, true);
			this.X0Y0_節10CP = new ColorP(this.X0Y0_節10, this.節10CD, DisUnit, true);
			this.X0Y0_節11CP = new ColorP(this.X0Y0_節11, this.節11CD, DisUnit, true);
			this.X0Y0_節12CP = new ColorP(this.X0Y0_節12, this.節12CD, DisUnit, true);
			this.X0Y0_節13CP = new ColorP(this.X0Y0_節13, this.節13CD, DisUnit, true);
			this.X0Y0_節14CP = new ColorP(this.X0Y0_節14, this.節14CD, DisUnit, true);
			this.X0Y0_節15CP = new ColorP(this.X0Y0_節15, this.節15CD, DisUnit, true);
			this.X0Y0_節16CP = new ColorP(this.X0Y0_節16, this.節16CD, DisUnit, true);
			this.X0Y0_節17CP = new ColorP(this.X0Y0_節17, this.節17CD, DisUnit, true);
			this.X0Y0_節18CP = new ColorP(this.X0Y0_節18, this.節18CD, DisUnit, true);
			this.X0Y0_節19CP = new ColorP(this.X0Y0_節19, this.節19CD, DisUnit, true);
			this.X0Y0_節20CP = new ColorP(this.X0Y0_節20, this.節20CD, DisUnit, true);
			this.X0Y0_節21CP = new ColorP(this.X0Y0_節21, this.節21CD, DisUnit, true);
			this.X0Y0_節22CP = new ColorP(this.X0Y0_節22, this.節22CD, DisUnit, true);
			this.X0Y0_節23CP = new ColorP(this.X0Y0_節23, this.節23CD, DisUnit, true);
			this.X0Y0_節24CP = new ColorP(this.X0Y0_節24, this.節24CD, DisUnit, true);
			this.X0Y0_節25CP = new ColorP(this.X0Y0_節25, this.節25CD, DisUnit, true);
			this.X0Y0_節26CP = new ColorP(this.X0Y0_節26, this.節26CD, DisUnit, true);
			this.X0Y0_節27CP = new ColorP(this.X0Y0_節27, this.節27CD, DisUnit, true);
			this.X0Y0_節28CP = new ColorP(this.X0Y0_節28, this.節28CD, DisUnit, true);
			this.X0Y0_節29CP = new ColorP(this.X0Y0_節29, this.節29CD, DisUnit, true);
			this.X0Y0_節30CP = new ColorP(this.X0Y0_節30, this.節30CD, DisUnit, true);
			this.X0Y0_節31CP = new ColorP(this.X0Y0_節31, this.節31CD, DisUnit, true);
			this.X0Y0_節32CP = new ColorP(this.X0Y0_節32, this.節32CD, DisUnit, true);
			this.X0Y0_節33CP = new ColorP(this.X0Y0_節33, this.節33CD, DisUnit, true);
			this.X0Y0_節34CP = new ColorP(this.X0Y0_節34, this.節34CD, DisUnit, true);
			this.X0Y0_節35CP = new ColorP(this.X0Y0_節35, this.節35CD, DisUnit, true);
			this.X0Y0_節36CP = new ColorP(this.X0Y0_節36, this.節36CD, DisUnit, true);
			this.X0Y0_節37CP = new ColorP(this.X0Y0_節37, this.節37CD, DisUnit, true);
			this.X0Y0_節38CP = new ColorP(this.X0Y0_節38, this.節38CD, DisUnit, true);
			this.X0Y0_節39CP = new ColorP(this.X0Y0_節39, this.節39CD, DisUnit, true);
			this.X0Y0_節40CP = new ColorP(this.X0Y0_節40, this.節40CD, DisUnit, true);
			this.X0Y0_節41CP = new ColorP(this.X0Y0_節41, this.節41CD, DisUnit, true);
			this.X0Y0_節42CP = new ColorP(this.X0Y0_節42, this.節42CD, DisUnit, true);
			this.X0Y0_節43CP = new ColorP(this.X0Y0_節43, this.節43CD, DisUnit, true);
			this.X0Y0_節44CP = new ColorP(this.X0Y0_節44, this.節44CD, DisUnit, true);
			this.X0Y0_節45CP = new ColorP(this.X0Y0_節45, this.節45CD, DisUnit, true);
			this.X0Y0_節46CP = new ColorP(this.X0Y0_節46, this.節46CD, DisUnit, true);
			this.X0Y0_節47CP = new ColorP(this.X0Y0_節47, this.節47CD, DisUnit, true);
			this.X0Y0_節48CP = new ColorP(this.X0Y0_節48, this.節48CD, DisUnit, true);
			this.X0Y0_節49CP = new ColorP(this.X0Y0_節49, this.節49CD, DisUnit, true);
			this.X0Y0_節50CP = new ColorP(this.X0Y0_節50, this.節50CD, DisUnit, true);
			this.X0Y0_節51CP = new ColorP(this.X0Y0_節51, this.節51CD, DisUnit, true);
			this.X0Y0_節52CP = new ColorP(this.X0Y0_節52, this.節52CD, DisUnit, true);
			this.X0Y0_節53CP = new ColorP(this.X0Y0_節53, this.節53CD, DisUnit, true);
			this.X0Y0_節54CP = new ColorP(this.X0Y0_節54, this.節54CD, DisUnit, true);
			this.X0Y0_節55CP = new ColorP(this.X0Y0_節55, this.節55CD, DisUnit, true);
			this.X0Y0_節56CP = new ColorP(this.X0Y0_節56, this.節56CD, DisUnit, true);
			this.X0Y0_節57CP = new ColorP(this.X0Y0_節57, this.節57CD, DisUnit, true);
			this.X0Y0_節58CP = new ColorP(this.X0Y0_節58, this.節58CD, DisUnit, true);
			this.X0Y0_節59CP = new ColorP(this.X0Y0_節59, this.節59CD, DisUnit, true);
			this.X0Y0_節60CP = new ColorP(this.X0Y0_節60, this.節60CD, DisUnit, true);
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

		public bool 節1_表示
		{
			get
			{
				return this.X0Y0_節1.Dra;
			}
			set
			{
				this.X0Y0_節1.Dra = value;
				this.X0Y0_節1.Hit = value;
			}
		}

		public bool 節2_表示
		{
			get
			{
				return this.X0Y0_節2.Dra;
			}
			set
			{
				this.X0Y0_節2.Dra = value;
				this.X0Y0_節2.Hit = value;
			}
		}

		public bool 節3_表示
		{
			get
			{
				return this.X0Y0_節3.Dra;
			}
			set
			{
				this.X0Y0_節3.Dra = value;
				this.X0Y0_節3.Hit = value;
			}
		}

		public bool 節4_表示
		{
			get
			{
				return this.X0Y0_節4.Dra;
			}
			set
			{
				this.X0Y0_節4.Dra = value;
				this.X0Y0_節4.Hit = value;
			}
		}

		public bool 節5_表示
		{
			get
			{
				return this.X0Y0_節5.Dra;
			}
			set
			{
				this.X0Y0_節5.Dra = value;
				this.X0Y0_節5.Hit = value;
			}
		}

		public bool 節6_表示
		{
			get
			{
				return this.X0Y0_節6.Dra;
			}
			set
			{
				this.X0Y0_節6.Dra = value;
				this.X0Y0_節6.Hit = value;
			}
		}

		public bool 節7_表示
		{
			get
			{
				return this.X0Y0_節7.Dra;
			}
			set
			{
				this.X0Y0_節7.Dra = value;
				this.X0Y0_節7.Hit = value;
			}
		}

		public bool 節8_表示
		{
			get
			{
				return this.X0Y0_節8.Dra;
			}
			set
			{
				this.X0Y0_節8.Dra = value;
				this.X0Y0_節8.Hit = value;
			}
		}

		public bool 節9_表示
		{
			get
			{
				return this.X0Y0_節9.Dra;
			}
			set
			{
				this.X0Y0_節9.Dra = value;
				this.X0Y0_節9.Hit = value;
			}
		}

		public bool 節10_表示
		{
			get
			{
				return this.X0Y0_節10.Dra;
			}
			set
			{
				this.X0Y0_節10.Dra = value;
				this.X0Y0_節10.Hit = value;
			}
		}

		public bool 節11_表示
		{
			get
			{
				return this.X0Y0_節11.Dra;
			}
			set
			{
				this.X0Y0_節11.Dra = value;
				this.X0Y0_節11.Hit = value;
			}
		}

		public bool 節12_表示
		{
			get
			{
				return this.X0Y0_節12.Dra;
			}
			set
			{
				this.X0Y0_節12.Dra = value;
				this.X0Y0_節12.Hit = value;
			}
		}

		public bool 節13_表示
		{
			get
			{
				return this.X0Y0_節13.Dra;
			}
			set
			{
				this.X0Y0_節13.Dra = value;
				this.X0Y0_節13.Hit = value;
			}
		}

		public bool 節14_表示
		{
			get
			{
				return this.X0Y0_節14.Dra;
			}
			set
			{
				this.X0Y0_節14.Dra = value;
				this.X0Y0_節14.Hit = value;
			}
		}

		public bool 節15_表示
		{
			get
			{
				return this.X0Y0_節15.Dra;
			}
			set
			{
				this.X0Y0_節15.Dra = value;
				this.X0Y0_節15.Hit = value;
			}
		}

		public bool 節16_表示
		{
			get
			{
				return this.X0Y0_節16.Dra;
			}
			set
			{
				this.X0Y0_節16.Dra = value;
				this.X0Y0_節16.Hit = value;
			}
		}

		public bool 節17_表示
		{
			get
			{
				return this.X0Y0_節17.Dra;
			}
			set
			{
				this.X0Y0_節17.Dra = value;
				this.X0Y0_節17.Hit = value;
			}
		}

		public bool 節18_表示
		{
			get
			{
				return this.X0Y0_節18.Dra;
			}
			set
			{
				this.X0Y0_節18.Dra = value;
				this.X0Y0_節18.Hit = value;
			}
		}

		public bool 節19_表示
		{
			get
			{
				return this.X0Y0_節19.Dra;
			}
			set
			{
				this.X0Y0_節19.Dra = value;
				this.X0Y0_節19.Hit = value;
			}
		}

		public bool 節20_表示
		{
			get
			{
				return this.X0Y0_節20.Dra;
			}
			set
			{
				this.X0Y0_節20.Dra = value;
				this.X0Y0_節20.Hit = value;
			}
		}

		public bool 節21_表示
		{
			get
			{
				return this.X0Y0_節21.Dra;
			}
			set
			{
				this.X0Y0_節21.Dra = value;
				this.X0Y0_節21.Hit = value;
			}
		}

		public bool 節22_表示
		{
			get
			{
				return this.X0Y0_節22.Dra;
			}
			set
			{
				this.X0Y0_節22.Dra = value;
				this.X0Y0_節22.Hit = value;
			}
		}

		public bool 節23_表示
		{
			get
			{
				return this.X0Y0_節23.Dra;
			}
			set
			{
				this.X0Y0_節23.Dra = value;
				this.X0Y0_節23.Hit = value;
			}
		}

		public bool 節24_表示
		{
			get
			{
				return this.X0Y0_節24.Dra;
			}
			set
			{
				this.X0Y0_節24.Dra = value;
				this.X0Y0_節24.Hit = value;
			}
		}

		public bool 節25_表示
		{
			get
			{
				return this.X0Y0_節25.Dra;
			}
			set
			{
				this.X0Y0_節25.Dra = value;
				this.X0Y0_節25.Hit = value;
			}
		}

		public bool 節26_表示
		{
			get
			{
				return this.X0Y0_節26.Dra;
			}
			set
			{
				this.X0Y0_節26.Dra = value;
				this.X0Y0_節26.Hit = value;
			}
		}

		public bool 節27_表示
		{
			get
			{
				return this.X0Y0_節27.Dra;
			}
			set
			{
				this.X0Y0_節27.Dra = value;
				this.X0Y0_節27.Hit = value;
			}
		}

		public bool 節28_表示
		{
			get
			{
				return this.X0Y0_節28.Dra;
			}
			set
			{
				this.X0Y0_節28.Dra = value;
				this.X0Y0_節28.Hit = value;
			}
		}

		public bool 節29_表示
		{
			get
			{
				return this.X0Y0_節29.Dra;
			}
			set
			{
				this.X0Y0_節29.Dra = value;
				this.X0Y0_節29.Hit = value;
			}
		}

		public bool 節30_表示
		{
			get
			{
				return this.X0Y0_節30.Dra;
			}
			set
			{
				this.X0Y0_節30.Dra = value;
				this.X0Y0_節30.Hit = value;
			}
		}

		public bool 節31_表示
		{
			get
			{
				return this.X0Y0_節31.Dra;
			}
			set
			{
				this.X0Y0_節31.Dra = value;
				this.X0Y0_節31.Hit = value;
			}
		}

		public bool 節32_表示
		{
			get
			{
				return this.X0Y0_節32.Dra;
			}
			set
			{
				this.X0Y0_節32.Dra = value;
				this.X0Y0_節32.Hit = value;
			}
		}

		public bool 節33_表示
		{
			get
			{
				return this.X0Y0_節33.Dra;
			}
			set
			{
				this.X0Y0_節33.Dra = value;
				this.X0Y0_節33.Hit = value;
			}
		}

		public bool 節34_表示
		{
			get
			{
				return this.X0Y0_節34.Dra;
			}
			set
			{
				this.X0Y0_節34.Dra = value;
				this.X0Y0_節34.Hit = value;
			}
		}

		public bool 節35_表示
		{
			get
			{
				return this.X0Y0_節35.Dra;
			}
			set
			{
				this.X0Y0_節35.Dra = value;
				this.X0Y0_節35.Hit = value;
			}
		}

		public bool 節36_表示
		{
			get
			{
				return this.X0Y0_節36.Dra;
			}
			set
			{
				this.X0Y0_節36.Dra = value;
				this.X0Y0_節36.Hit = value;
			}
		}

		public bool 節37_表示
		{
			get
			{
				return this.X0Y0_節37.Dra;
			}
			set
			{
				this.X0Y0_節37.Dra = value;
				this.X0Y0_節37.Hit = value;
			}
		}

		public bool 節38_表示
		{
			get
			{
				return this.X0Y0_節38.Dra;
			}
			set
			{
				this.X0Y0_節38.Dra = value;
				this.X0Y0_節38.Hit = value;
			}
		}

		public bool 節39_表示
		{
			get
			{
				return this.X0Y0_節39.Dra;
			}
			set
			{
				this.X0Y0_節39.Dra = value;
				this.X0Y0_節39.Hit = value;
			}
		}

		public bool 節40_表示
		{
			get
			{
				return this.X0Y0_節40.Dra;
			}
			set
			{
				this.X0Y0_節40.Dra = value;
				this.X0Y0_節40.Hit = value;
			}
		}

		public bool 節41_表示
		{
			get
			{
				return this.X0Y0_節41.Dra;
			}
			set
			{
				this.X0Y0_節41.Dra = value;
				this.X0Y0_節41.Hit = value;
			}
		}

		public bool 節42_表示
		{
			get
			{
				return this.X0Y0_節42.Dra;
			}
			set
			{
				this.X0Y0_節42.Dra = value;
				this.X0Y0_節42.Hit = value;
			}
		}

		public bool 節43_表示
		{
			get
			{
				return this.X0Y0_節43.Dra;
			}
			set
			{
				this.X0Y0_節43.Dra = value;
				this.X0Y0_節43.Hit = value;
			}
		}

		public bool 節44_表示
		{
			get
			{
				return this.X0Y0_節44.Dra;
			}
			set
			{
				this.X0Y0_節44.Dra = value;
				this.X0Y0_節44.Hit = value;
			}
		}

		public bool 節45_表示
		{
			get
			{
				return this.X0Y0_節45.Dra;
			}
			set
			{
				this.X0Y0_節45.Dra = value;
				this.X0Y0_節45.Hit = value;
			}
		}

		public bool 節46_表示
		{
			get
			{
				return this.X0Y0_節46.Dra;
			}
			set
			{
				this.X0Y0_節46.Dra = value;
				this.X0Y0_節46.Hit = value;
			}
		}

		public bool 節47_表示
		{
			get
			{
				return this.X0Y0_節47.Dra;
			}
			set
			{
				this.X0Y0_節47.Dra = value;
				this.X0Y0_節47.Hit = value;
			}
		}

		public bool 節48_表示
		{
			get
			{
				return this.X0Y0_節48.Dra;
			}
			set
			{
				this.X0Y0_節48.Dra = value;
				this.X0Y0_節48.Hit = value;
			}
		}

		public bool 節49_表示
		{
			get
			{
				return this.X0Y0_節49.Dra;
			}
			set
			{
				this.X0Y0_節49.Dra = value;
				this.X0Y0_節49.Hit = value;
			}
		}

		public bool 節50_表示
		{
			get
			{
				return this.X0Y0_節50.Dra;
			}
			set
			{
				this.X0Y0_節50.Dra = value;
				this.X0Y0_節50.Hit = value;
			}
		}

		public bool 節51_表示
		{
			get
			{
				return this.X0Y0_節51.Dra;
			}
			set
			{
				this.X0Y0_節51.Dra = value;
				this.X0Y0_節51.Hit = value;
			}
		}

		public bool 節52_表示
		{
			get
			{
				return this.X0Y0_節52.Dra;
			}
			set
			{
				this.X0Y0_節52.Dra = value;
				this.X0Y0_節52.Hit = value;
			}
		}

		public bool 節53_表示
		{
			get
			{
				return this.X0Y0_節53.Dra;
			}
			set
			{
				this.X0Y0_節53.Dra = value;
				this.X0Y0_節53.Hit = value;
			}
		}

		public bool 節54_表示
		{
			get
			{
				return this.X0Y0_節54.Dra;
			}
			set
			{
				this.X0Y0_節54.Dra = value;
				this.X0Y0_節54.Hit = value;
			}
		}

		public bool 節55_表示
		{
			get
			{
				return this.X0Y0_節55.Dra;
			}
			set
			{
				this.X0Y0_節55.Dra = value;
				this.X0Y0_節55.Hit = value;
			}
		}

		public bool 節56_表示
		{
			get
			{
				return this.X0Y0_節56.Dra;
			}
			set
			{
				this.X0Y0_節56.Dra = value;
				this.X0Y0_節56.Hit = value;
			}
		}

		public bool 節57_表示
		{
			get
			{
				return this.X0Y0_節57.Dra;
			}
			set
			{
				this.X0Y0_節57.Dra = value;
				this.X0Y0_節57.Hit = value;
			}
		}

		public bool 節58_表示
		{
			get
			{
				return this.X0Y0_節58.Dra;
			}
			set
			{
				this.X0Y0_節58.Dra = value;
				this.X0Y0_節58.Hit = value;
			}
		}

		public bool 節59_表示
		{
			get
			{
				return this.X0Y0_節59.Dra;
			}
			set
			{
				this.X0Y0_節59.Dra = value;
				this.X0Y0_節59.Hit = value;
			}
		}

		public bool 節60_表示
		{
			get
			{
				return this.X0Y0_節60.Dra;
			}
			set
			{
				this.X0Y0_節60.Dra = value;
				this.X0Y0_節60.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.節1_表示;
			}
			set
			{
				this.節1_表示 = value;
				this.節2_表示 = value;
				this.節3_表示 = value;
				this.節4_表示 = value;
				this.節5_表示 = value;
				this.節6_表示 = value;
				this.節7_表示 = value;
				this.節8_表示 = value;
				this.節9_表示 = value;
				this.節10_表示 = value;
				this.節11_表示 = value;
				this.節12_表示 = value;
				this.節13_表示 = value;
				this.節14_表示 = value;
				this.節15_表示 = value;
				this.節16_表示 = value;
				this.節17_表示 = value;
				this.節18_表示 = value;
				this.節19_表示 = value;
				this.節20_表示 = value;
				this.節21_表示 = value;
				this.節22_表示 = value;
				this.節23_表示 = value;
				this.節24_表示 = value;
				this.節25_表示 = value;
				this.節26_表示 = value;
				this.節27_表示 = value;
				this.節28_表示 = value;
				this.節29_表示 = value;
				this.節30_表示 = value;
				this.節31_表示 = value;
				this.節32_表示 = value;
				this.節33_表示 = value;
				this.節34_表示 = value;
				this.節35_表示 = value;
				this.節36_表示 = value;
				this.節37_表示 = value;
				this.節38_表示 = value;
				this.節39_表示 = value;
				this.節40_表示 = value;
				this.節41_表示 = value;
				this.節42_表示 = value;
				this.節43_表示 = value;
				this.節44_表示 = value;
				this.節45_表示 = value;
				this.節46_表示 = value;
				this.節47_表示 = value;
				this.節48_表示 = value;
				this.節49_表示 = value;
				this.節50_表示 = value;
				this.節51_表示 = value;
				this.節52_表示 = value;
				this.節53_表示 = value;
				this.節54_表示 = value;
				this.節55_表示 = value;
				this.節56_表示 = value;
				this.節57_表示 = value;
				this.節58_表示 = value;
				this.節59_表示 = value;
				this.節60_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.節1CD.不透明度;
			}
			set
			{
				this.節1CD.不透明度 = value;
				this.節2CD.不透明度 = value;
				this.節3CD.不透明度 = value;
				this.節4CD.不透明度 = value;
				this.節5CD.不透明度 = value;
				this.節6CD.不透明度 = value;
				this.節7CD.不透明度 = value;
				this.節8CD.不透明度 = value;
				this.節9CD.不透明度 = value;
				this.節10CD.不透明度 = value;
				this.節11CD.不透明度 = value;
				this.節12CD.不透明度 = value;
				this.節13CD.不透明度 = value;
				this.節14CD.不透明度 = value;
				this.節15CD.不透明度 = value;
				this.節16CD.不透明度 = value;
				this.節17CD.不透明度 = value;
				this.節18CD.不透明度 = value;
				this.節19CD.不透明度 = value;
				this.節20CD.不透明度 = value;
				this.節21CD.不透明度 = value;
				this.節22CD.不透明度 = value;
				this.節23CD.不透明度 = value;
				this.節24CD.不透明度 = value;
				this.節25CD.不透明度 = value;
				this.節26CD.不透明度 = value;
				this.節27CD.不透明度 = value;
				this.節28CD.不透明度 = value;
				this.節29CD.不透明度 = value;
				this.節30CD.不透明度 = value;
				this.節31CD.不透明度 = value;
				this.節32CD.不透明度 = value;
				this.節33CD.不透明度 = value;
				this.節34CD.不透明度 = value;
				this.節35CD.不透明度 = value;
				this.節36CD.不透明度 = value;
				this.節37CD.不透明度 = value;
				this.節38CD.不透明度 = value;
				this.節39CD.不透明度 = value;
				this.節40CD.不透明度 = value;
				this.節41CD.不透明度 = value;
				this.節42CD.不透明度 = value;
				this.節43CD.不透明度 = value;
				this.節44CD.不透明度 = value;
				this.節45CD.不透明度 = value;
				this.節46CD.不透明度 = value;
				this.節47CD.不透明度 = value;
				this.節48CD.不透明度 = value;
				this.節49CD.不透明度 = value;
				this.節50CD.不透明度 = value;
				this.節51CD.不透明度 = value;
				this.節52CD.不透明度 = value;
				this.節53CD.不透明度 = value;
				this.節54CD.不透明度 = value;
				this.節55CD.不透明度 = value;
				this.節56CD.不透明度 = value;
				this.節57CD.不透明度 = value;
				this.節58CD.不透明度 = value;
				this.節59CD.不透明度 = value;
				this.節60CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			double num = this.右 ? -1.0 : 1.0;
			int num2 = -2;
			double num3 = 1.0;
			double num4 = 0.01;
			this.X0Y0_節1.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節2.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節3.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節4.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節5.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節6.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節7.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節8.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節9.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節10.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節11.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節12.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節13.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節14.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節15.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節16.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節17.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節18.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節19.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節20.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節21.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節22.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節23.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節24.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節25.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節26.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節27.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節28.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節29.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節30.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節31.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節32.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節33.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節34.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節35.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節36.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節37.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節38.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節39.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節40.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節41.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節42.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節43.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節44.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節45.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節46.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節47.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節48.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節49.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節50.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節51.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節52.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節53.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節54.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節55.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節56.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節57.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節58.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節59.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節60.AngleBase = num * (double)num2 * num3;
			this.本体.JoinPAall();
		}

		public override IEnumerable<Par> Enum軸()
		{
			yield return this.X0Y0_節1;
			yield return this.X0Y0_節2;
			yield return this.X0Y0_節3;
			yield return this.X0Y0_節4;
			yield return this.X0Y0_節5;
			yield return this.X0Y0_節6;
			yield return this.X0Y0_節7;
			yield return this.X0Y0_節8;
			yield return this.X0Y0_節9;
			yield return this.X0Y0_節10;
			yield return this.X0Y0_節11;
			yield return this.X0Y0_節12;
			yield return this.X0Y0_節13;
			yield return this.X0Y0_節14;
			yield return this.X0Y0_節15;
			yield return this.X0Y0_節16;
			yield return this.X0Y0_節17;
			yield return this.X0Y0_節18;
			yield return this.X0Y0_節19;
			yield return this.X0Y0_節20;
			yield return this.X0Y0_節21;
			yield return this.X0Y0_節22;
			yield return this.X0Y0_節23;
			yield return this.X0Y0_節24;
			yield return this.X0Y0_節25;
			yield return this.X0Y0_節26;
			yield return this.X0Y0_節27;
			yield return this.X0Y0_節28;
			yield return this.X0Y0_節29;
			yield return this.X0Y0_節30;
			yield return this.X0Y0_節31;
			yield return this.X0Y0_節32;
			yield return this.X0Y0_節33;
			yield return this.X0Y0_節34;
			yield return this.X0Y0_節35;
			yield return this.X0Y0_節36;
			yield return this.X0Y0_節37;
			yield return this.X0Y0_節38;
			yield return this.X0Y0_節39;
			yield return this.X0Y0_節40;
			yield return this.X0Y0_節41;
			yield return this.X0Y0_節42;
			yield return this.X0Y0_節43;
			yield return this.X0Y0_節44;
			yield return this.X0Y0_節45;
			yield return this.X0Y0_節46;
			yield return this.X0Y0_節47;
			yield return this.X0Y0_節48;
			yield return this.X0Y0_節49;
			yield return this.X0Y0_節50;
			yield return this.X0Y0_節51;
			yield return this.X0Y0_節52;
			yield return this.X0Y0_節53;
			yield return this.X0Y0_節54;
			yield return this.X0Y0_節55;
			yield return this.X0Y0_節56;
			yield return this.X0Y0_節57;
			yield return this.X0Y0_節58;
			yield return this.X0Y0_節59;
			yield return this.X0Y0_節60;
			yield break;
		}

		public override void 色更新()
		{
			this.X0Y0_節1CP.Update();
			this.X0Y0_節2CP.Update();
			this.X0Y0_節3CP.Update();
			this.X0Y0_節4CP.Update();
			this.X0Y0_節5CP.Update();
			this.X0Y0_節6CP.Update();
			this.X0Y0_節7CP.Update();
			this.X0Y0_節8CP.Update();
			this.X0Y0_節9CP.Update();
			this.X0Y0_節10CP.Update();
			this.X0Y0_節11CP.Update();
			this.X0Y0_節12CP.Update();
			this.X0Y0_節13CP.Update();
			this.X0Y0_節14CP.Update();
			this.X0Y0_節15CP.Update();
			this.X0Y0_節16CP.Update();
			this.X0Y0_節17CP.Update();
			this.X0Y0_節18CP.Update();
			this.X0Y0_節19CP.Update();
			this.X0Y0_節20CP.Update();
			this.X0Y0_節21CP.Update();
			this.X0Y0_節22CP.Update();
			this.X0Y0_節23CP.Update();
			this.X0Y0_節24CP.Update();
			this.X0Y0_節25CP.Update();
			this.X0Y0_節26CP.Update();
			this.X0Y0_節27CP.Update();
			this.X0Y0_節28CP.Update();
			this.X0Y0_節29CP.Update();
			this.X0Y0_節30CP.Update();
			this.X0Y0_節31CP.Update();
			this.X0Y0_節32CP.Update();
			this.X0Y0_節33CP.Update();
			this.X0Y0_節34CP.Update();
			this.X0Y0_節35CP.Update();
			this.X0Y0_節36CP.Update();
			this.X0Y0_節37CP.Update();
			this.X0Y0_節38CP.Update();
			this.X0Y0_節39CP.Update();
			this.X0Y0_節40CP.Update();
			this.X0Y0_節41CP.Update();
			this.X0Y0_節42CP.Update();
			this.X0Y0_節43CP.Update();
			this.X0Y0_節44CP.Update();
			this.X0Y0_節45CP.Update();
			this.X0Y0_節46CP.Update();
			this.X0Y0_節47CP.Update();
			this.X0Y0_節48CP.Update();
			this.X0Y0_節49CP.Update();
			this.X0Y0_節50CP.Update();
			this.X0Y0_節51CP.Update();
			this.X0Y0_節52CP.Update();
			this.X0Y0_節53CP.Update();
			this.X0Y0_節54CP.Update();
			this.X0Y0_節55CP.Update();
			this.X0Y0_節56CP.Update();
			this.X0Y0_節57CP.Update();
			this.X0Y0_節58CP.Update();
			this.X0Y0_節59CP.Update();
			this.X0Y0_節60CP.Update();
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
			this.節1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節3CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節4CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節5CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節6CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節7CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節8CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節9CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節10CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節11CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節12CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節13CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節14CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節15CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節16CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節17CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節18CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節19CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節20CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節21CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節22CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節23CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節24CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節25CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節26CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節27CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節28CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節29CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節30CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節31CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節32CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節33CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節34CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節35CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節36CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節37CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節38CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節39CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節40CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節41CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節42CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節43CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節44CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節45CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節46CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節47CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節48CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節49CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節50CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節51CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節52CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節53CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節54CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節55CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節56CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節57CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節58CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節59CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節60CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
		}

		private void 配色T0(体配色 体配色)
		{
			this.配色T(0, "節", ref 体配色.甲1O, ref 体配色.刺青O);
		}

		private void 配色T1(体配色 体配色)
		{
			this.配色T(1, "節", ref 体配色.甲1O, ref 体配色.刺青O);
		}

		public Par X0Y0_節1;

		public Par X0Y0_節2;

		public Par X0Y0_節3;

		public Par X0Y0_節4;

		public Par X0Y0_節5;

		public Par X0Y0_節6;

		public Par X0Y0_節7;

		public Par X0Y0_節8;

		public Par X0Y0_節9;

		public Par X0Y0_節10;

		public Par X0Y0_節11;

		public Par X0Y0_節12;

		public Par X0Y0_節13;

		public Par X0Y0_節14;

		public Par X0Y0_節15;

		public Par X0Y0_節16;

		public Par X0Y0_節17;

		public Par X0Y0_節18;

		public Par X0Y0_節19;

		public Par X0Y0_節20;

		public Par X0Y0_節21;

		public Par X0Y0_節22;

		public Par X0Y0_節23;

		public Par X0Y0_節24;

		public Par X0Y0_節25;

		public Par X0Y0_節26;

		public Par X0Y0_節27;

		public Par X0Y0_節28;

		public Par X0Y0_節29;

		public Par X0Y0_節30;

		public Par X0Y0_節31;

		public Par X0Y0_節32;

		public Par X0Y0_節33;

		public Par X0Y0_節34;

		public Par X0Y0_節35;

		public Par X0Y0_節36;

		public Par X0Y0_節37;

		public Par X0Y0_節38;

		public Par X0Y0_節39;

		public Par X0Y0_節40;

		public Par X0Y0_節41;

		public Par X0Y0_節42;

		public Par X0Y0_節43;

		public Par X0Y0_節44;

		public Par X0Y0_節45;

		public Par X0Y0_節46;

		public Par X0Y0_節47;

		public Par X0Y0_節48;

		public Par X0Y0_節49;

		public Par X0Y0_節50;

		public Par X0Y0_節51;

		public Par X0Y0_節52;

		public Par X0Y0_節53;

		public Par X0Y0_節54;

		public Par X0Y0_節55;

		public Par X0Y0_節56;

		public Par X0Y0_節57;

		public Par X0Y0_節58;

		public Par X0Y0_節59;

		public Par X0Y0_節60;

		public ColorD 節1CD;

		public ColorD 節2CD;

		public ColorD 節3CD;

		public ColorD 節4CD;

		public ColorD 節5CD;

		public ColorD 節6CD;

		public ColorD 節7CD;

		public ColorD 節8CD;

		public ColorD 節9CD;

		public ColorD 節10CD;

		public ColorD 節11CD;

		public ColorD 節12CD;

		public ColorD 節13CD;

		public ColorD 節14CD;

		public ColorD 節15CD;

		public ColorD 節16CD;

		public ColorD 節17CD;

		public ColorD 節18CD;

		public ColorD 節19CD;

		public ColorD 節20CD;

		public ColorD 節21CD;

		public ColorD 節22CD;

		public ColorD 節23CD;

		public ColorD 節24CD;

		public ColorD 節25CD;

		public ColorD 節26CD;

		public ColorD 節27CD;

		public ColorD 節28CD;

		public ColorD 節29CD;

		public ColorD 節30CD;

		public ColorD 節31CD;

		public ColorD 節32CD;

		public ColorD 節33CD;

		public ColorD 節34CD;

		public ColorD 節35CD;

		public ColorD 節36CD;

		public ColorD 節37CD;

		public ColorD 節38CD;

		public ColorD 節39CD;

		public ColorD 節40CD;

		public ColorD 節41CD;

		public ColorD 節42CD;

		public ColorD 節43CD;

		public ColorD 節44CD;

		public ColorD 節45CD;

		public ColorD 節46CD;

		public ColorD 節47CD;

		public ColorD 節48CD;

		public ColorD 節49CD;

		public ColorD 節50CD;

		public ColorD 節51CD;

		public ColorD 節52CD;

		public ColorD 節53CD;

		public ColorD 節54CD;

		public ColorD 節55CD;

		public ColorD 節56CD;

		public ColorD 節57CD;

		public ColorD 節58CD;

		public ColorD 節59CD;

		public ColorD 節60CD;

		public ColorP X0Y0_節1CP;

		public ColorP X0Y0_節2CP;

		public ColorP X0Y0_節3CP;

		public ColorP X0Y0_節4CP;

		public ColorP X0Y0_節5CP;

		public ColorP X0Y0_節6CP;

		public ColorP X0Y0_節7CP;

		public ColorP X0Y0_節8CP;

		public ColorP X0Y0_節9CP;

		public ColorP X0Y0_節10CP;

		public ColorP X0Y0_節11CP;

		public ColorP X0Y0_節12CP;

		public ColorP X0Y0_節13CP;

		public ColorP X0Y0_節14CP;

		public ColorP X0Y0_節15CP;

		public ColorP X0Y0_節16CP;

		public ColorP X0Y0_節17CP;

		public ColorP X0Y0_節18CP;

		public ColorP X0Y0_節19CP;

		public ColorP X0Y0_節20CP;

		public ColorP X0Y0_節21CP;

		public ColorP X0Y0_節22CP;

		public ColorP X0Y0_節23CP;

		public ColorP X0Y0_節24CP;

		public ColorP X0Y0_節25CP;

		public ColorP X0Y0_節26CP;

		public ColorP X0Y0_節27CP;

		public ColorP X0Y0_節28CP;

		public ColorP X0Y0_節29CP;

		public ColorP X0Y0_節30CP;

		public ColorP X0Y0_節31CP;

		public ColorP X0Y0_節32CP;

		public ColorP X0Y0_節33CP;

		public ColorP X0Y0_節34CP;

		public ColorP X0Y0_節35CP;

		public ColorP X0Y0_節36CP;

		public ColorP X0Y0_節37CP;

		public ColorP X0Y0_節38CP;

		public ColorP X0Y0_節39CP;

		public ColorP X0Y0_節40CP;

		public ColorP X0Y0_節41CP;

		public ColorP X0Y0_節42CP;

		public ColorP X0Y0_節43CP;

		public ColorP X0Y0_節44CP;

		public ColorP X0Y0_節45CP;

		public ColorP X0Y0_節46CP;

		public ColorP X0Y0_節47CP;

		public ColorP X0Y0_節48CP;

		public ColorP X0Y0_節49CP;

		public ColorP X0Y0_節50CP;

		public ColorP X0Y0_節51CP;

		public ColorP X0Y0_節52CP;

		public ColorP X0Y0_節53CP;

		public ColorP X0Y0_節54CP;

		public ColorP X0Y0_節55CP;

		public ColorP X0Y0_節56CP;

		public ColorP X0Y0_節57CP;

		public ColorP X0Y0_節58CP;

		public ColorP X0Y0_節59CP;

		public ColorP X0Y0_節60CP;
	}
}
