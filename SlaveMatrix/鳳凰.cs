using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 鳳凰 : 尾
	{
		public 鳳凰(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 鳳凰D e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "鳳凰";
			dif.Add(new Pars(Sta.肢中["尾"][2][0]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			Pars pars2 = pars["羽"].ToPars();
			this.X0Y0_羽_羽 = pars2["羽"].ToPar();
			this.X0Y0_羽_紋1 = pars2["紋1"].ToPar();
			this.X0Y0_羽_紋2 = pars2["紋2"].ToPar();
			pars2 = pars["羽2"].ToPars();
			this.X0Y0_羽2_羽 = pars2["羽"].ToPar();
			this.X0Y0_羽2_紋1 = pars2["紋1"].ToPar();
			this.X0Y0_羽2_紋2 = pars2["紋2"].ToPar();
			pars2 = pars["羽3"].ToPars();
			this.X0Y0_羽3_羽 = pars2["羽"].ToPar();
			this.X0Y0_羽3_紋1 = pars2["紋1"].ToPar();
			this.X0Y0_羽3_紋2 = pars2["紋2"].ToPar();
			pars2 = pars["羽4"].ToPars();
			this.X0Y0_羽4_羽 = pars2["羽"].ToPar();
			this.X0Y0_羽4_紋1 = pars2["紋1"].ToPar();
			this.X0Y0_羽4_紋2 = pars2["紋2"].ToPar();
			pars2 = pars["羽5"].ToPars();
			this.X0Y0_羽5_羽 = pars2["羽"].ToPar();
			this.X0Y0_羽5_紋1 = pars2["紋1"].ToPar();
			this.X0Y0_羽5_紋2 = pars2["紋2"].ToPar();
			pars2 = pars["羽6"].ToPars();
			this.X0Y0_羽6_羽 = pars2["羽"].ToPar();
			this.X0Y0_羽6_紋1 = pars2["紋1"].ToPar();
			this.X0Y0_羽6_紋2 = pars2["紋2"].ToPar();
			pars2 = pars["羽7"].ToPars();
			this.X0Y0_羽7_羽 = pars2["羽"].ToPar();
			this.X0Y0_羽7_紋1 = pars2["紋1"].ToPar();
			this.X0Y0_羽7_紋2 = pars2["紋2"].ToPar();
			pars2 = pars["羽8"].ToPars();
			this.X0Y0_羽8_羽 = pars2["羽"].ToPar();
			this.X0Y0_羽8_紋1 = pars2["紋1"].ToPar();
			this.X0Y0_羽8_紋2 = pars2["紋2"].ToPar();
			pars2 = pars["羽9"].ToPars();
			this.X0Y0_羽9_羽 = pars2["羽"].ToPar();
			this.X0Y0_羽9_紋1 = pars2["紋1"].ToPar();
			this.X0Y0_羽9_紋2 = pars2["紋2"].ToPar();
			pars2 = pars["羽10"].ToPars();
			this.X0Y0_羽10_羽 = pars2["羽"].ToPar();
			this.X0Y0_羽10_紋1 = pars2["紋1"].ToPar();
			this.X0Y0_羽10_紋2 = pars2["紋2"].ToPar();
			pars2 = pars["羽11"].ToPars();
			this.X0Y0_羽11_羽 = pars2["羽"].ToPar();
			this.X0Y0_羽11_紋1 = pars2["紋1"].ToPar();
			this.X0Y0_羽11_紋2 = pars2["紋2"].ToPar();
			pars2 = pars["羽12"].ToPars();
			this.X0Y0_羽12_羽 = pars2["羽"].ToPar();
			this.X0Y0_羽12_紋1 = pars2["紋1"].ToPar();
			this.X0Y0_羽12_紋2 = pars2["紋2"].ToPar();
			pars2 = pars["羽13"].ToPars();
			this.X0Y0_羽13_羽 = pars2["羽"].ToPar();
			this.X0Y0_羽13_紋1 = pars2["紋1"].ToPar();
			this.X0Y0_羽13_紋2 = pars2["紋2"].ToPar();
			pars2 = pars["羽14"].ToPars();
			this.X0Y0_羽14_羽 = pars2["羽"].ToPar();
			this.X0Y0_羽14_紋1 = pars2["紋1"].ToPar();
			this.X0Y0_羽14_紋2 = pars2["紋2"].ToPar();
			pars2 = pars["羽15"].ToPars();
			this.X0Y0_羽15_羽 = pars2["羽"].ToPar();
			this.X0Y0_羽15_紋1 = pars2["紋1"].ToPar();
			this.X0Y0_羽15_紋2 = pars2["紋2"].ToPar();
			pars2 = pars["羽16"].ToPars();
			this.X0Y0_羽16_羽 = pars2["羽"].ToPar();
			this.X0Y0_羽16_紋1 = pars2["紋1"].ToPar();
			this.X0Y0_羽16_紋2 = pars2["紋2"].ToPar();
			pars2 = pars["羽17"].ToPars();
			this.X0Y0_羽17_羽 = pars2["羽"].ToPar();
			this.X0Y0_羽17_紋1 = pars2["紋1"].ToPar();
			this.X0Y0_羽17_紋2 = pars2["紋2"].ToPar();
			pars2 = pars["羽18"].ToPars();
			this.X0Y0_羽18_羽 = pars2["羽"].ToPar();
			this.X0Y0_羽18_紋1 = pars2["紋1"].ToPar();
			this.X0Y0_羽18_紋2 = pars2["紋2"].ToPar();
			pars2 = pars["羽19"].ToPars();
			this.X0Y0_羽19_羽 = pars2["羽"].ToPar();
			this.X0Y0_羽19_紋1 = pars2["紋1"].ToPar();
			this.X0Y0_羽19_紋2 = pars2["紋2"].ToPar();
			pars2 = pars["羽20"].ToPars();
			this.X0Y0_羽20_羽 = pars2["羽"].ToPar();
			this.X0Y0_羽20_紋1 = pars2["紋1"].ToPar();
			this.X0Y0_羽20_紋2 = pars2["紋2"].ToPar();
			pars2 = pars["羽21"].ToPars();
			this.X0Y0_羽21_羽 = pars2["羽"].ToPar();
			this.X0Y0_羽21_紋1 = pars2["紋1"].ToPar();
			this.X0Y0_羽21_紋2 = pars2["紋2"].ToPar();
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
			this.羽_羽_表示 = e.羽_羽_表示;
			this.羽_紋1_表示 = e.羽_紋1_表示;
			this.羽_紋2_表示 = e.羽_紋2_表示;
			this.羽2_羽_表示 = e.羽2_羽_表示;
			this.羽2_紋1_表示 = e.羽2_紋1_表示;
			this.羽2_紋2_表示 = e.羽2_紋2_表示;
			this.羽3_羽_表示 = e.羽3_羽_表示;
			this.羽3_紋1_表示 = e.羽3_紋1_表示;
			this.羽3_紋2_表示 = e.羽3_紋2_表示;
			this.羽4_羽_表示 = e.羽4_羽_表示;
			this.羽4_紋1_表示 = e.羽4_紋1_表示;
			this.羽4_紋2_表示 = e.羽4_紋2_表示;
			this.羽5_羽_表示 = e.羽5_羽_表示;
			this.羽5_紋1_表示 = e.羽5_紋1_表示;
			this.羽5_紋2_表示 = e.羽5_紋2_表示;
			this.羽6_羽_表示 = e.羽6_羽_表示;
			this.羽6_紋1_表示 = e.羽6_紋1_表示;
			this.羽6_紋2_表示 = e.羽6_紋2_表示;
			this.羽7_羽_表示 = e.羽7_羽_表示;
			this.羽7_紋1_表示 = e.羽7_紋1_表示;
			this.羽7_紋2_表示 = e.羽7_紋2_表示;
			this.羽8_羽_表示 = e.羽8_羽_表示;
			this.羽8_紋1_表示 = e.羽8_紋1_表示;
			this.羽8_紋2_表示 = e.羽8_紋2_表示;
			this.羽9_羽_表示 = e.羽9_羽_表示;
			this.羽9_紋1_表示 = e.羽9_紋1_表示;
			this.羽9_紋2_表示 = e.羽9_紋2_表示;
			this.羽10_羽_表示 = e.羽10_羽_表示;
			this.羽10_紋1_表示 = e.羽10_紋1_表示;
			this.羽10_紋2_表示 = e.羽10_紋2_表示;
			this.羽11_羽_表示 = e.羽11_羽_表示;
			this.羽11_紋1_表示 = e.羽11_紋1_表示;
			this.羽11_紋2_表示 = e.羽11_紋2_表示;
			this.羽12_羽_表示 = e.羽12_羽_表示;
			this.羽12_紋1_表示 = e.羽12_紋1_表示;
			this.羽12_紋2_表示 = e.羽12_紋2_表示;
			this.羽13_羽_表示 = e.羽13_羽_表示;
			this.羽13_紋1_表示 = e.羽13_紋1_表示;
			this.羽13_紋2_表示 = e.羽13_紋2_表示;
			this.羽14_羽_表示 = e.羽14_羽_表示;
			this.羽14_紋1_表示 = e.羽14_紋1_表示;
			this.羽14_紋2_表示 = e.羽14_紋2_表示;
			this.羽15_羽_表示 = e.羽15_羽_表示;
			this.羽15_紋1_表示 = e.羽15_紋1_表示;
			this.羽15_紋2_表示 = e.羽15_紋2_表示;
			this.羽16_羽_表示 = e.羽16_羽_表示;
			this.羽16_紋1_表示 = e.羽16_紋1_表示;
			this.羽16_紋2_表示 = e.羽16_紋2_表示;
			this.羽17_羽_表示 = e.羽17_羽_表示;
			this.羽17_紋1_表示 = e.羽17_紋1_表示;
			this.羽17_紋2_表示 = e.羽17_紋2_表示;
			this.羽18_羽_表示 = e.羽18_羽_表示;
			this.羽18_紋1_表示 = e.羽18_紋1_表示;
			this.羽18_紋2_表示 = e.羽18_紋2_表示;
			this.羽19_羽_表示 = e.羽19_羽_表示;
			this.羽19_紋1_表示 = e.羽19_紋1_表示;
			this.羽19_紋2_表示 = e.羽19_紋2_表示;
			this.羽20_羽_表示 = e.羽20_羽_表示;
			this.羽20_紋1_表示 = e.羽20_紋1_表示;
			this.羽20_紋2_表示 = e.羽20_紋2_表示;
			this.羽21_羽_表示 = e.羽21_羽_表示;
			this.羽21_紋1_表示 = e.羽21_紋1_表示;
			this.羽21_紋2_表示 = e.羽21_紋2_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_羽_羽CP = new ColorP(this.X0Y0_羽_羽, this.羽_羽CD, DisUnit, true);
			this.X0Y0_羽_紋1CP = new ColorP(this.X0Y0_羽_紋1, this.羽_紋1CD, DisUnit, true);
			this.X0Y0_羽_紋2CP = new ColorP(this.X0Y0_羽_紋2, this.羽_紋2CD, DisUnit, true);
			this.X0Y0_羽2_羽CP = new ColorP(this.X0Y0_羽2_羽, this.羽2_羽CD, DisUnit, true);
			this.X0Y0_羽2_紋1CP = new ColorP(this.X0Y0_羽2_紋1, this.羽2_紋1CD, DisUnit, true);
			this.X0Y0_羽2_紋2CP = new ColorP(this.X0Y0_羽2_紋2, this.羽2_紋2CD, DisUnit, true);
			this.X0Y0_羽3_羽CP = new ColorP(this.X0Y0_羽3_羽, this.羽3_羽CD, DisUnit, true);
			this.X0Y0_羽3_紋1CP = new ColorP(this.X0Y0_羽3_紋1, this.羽3_紋1CD, DisUnit, true);
			this.X0Y0_羽3_紋2CP = new ColorP(this.X0Y0_羽3_紋2, this.羽3_紋2CD, DisUnit, true);
			this.X0Y0_羽4_羽CP = new ColorP(this.X0Y0_羽4_羽, this.羽4_羽CD, DisUnit, true);
			this.X0Y0_羽4_紋1CP = new ColorP(this.X0Y0_羽4_紋1, this.羽4_紋1CD, DisUnit, true);
			this.X0Y0_羽4_紋2CP = new ColorP(this.X0Y0_羽4_紋2, this.羽4_紋2CD, DisUnit, true);
			this.X0Y0_羽5_羽CP = new ColorP(this.X0Y0_羽5_羽, this.羽5_羽CD, DisUnit, true);
			this.X0Y0_羽5_紋1CP = new ColorP(this.X0Y0_羽5_紋1, this.羽5_紋1CD, DisUnit, true);
			this.X0Y0_羽5_紋2CP = new ColorP(this.X0Y0_羽5_紋2, this.羽5_紋2CD, DisUnit, true);
			this.X0Y0_羽6_羽CP = new ColorP(this.X0Y0_羽6_羽, this.羽6_羽CD, DisUnit, true);
			this.X0Y0_羽6_紋1CP = new ColorP(this.X0Y0_羽6_紋1, this.羽6_紋1CD, DisUnit, true);
			this.X0Y0_羽6_紋2CP = new ColorP(this.X0Y0_羽6_紋2, this.羽6_紋2CD, DisUnit, true);
			this.X0Y0_羽7_羽CP = new ColorP(this.X0Y0_羽7_羽, this.羽7_羽CD, DisUnit, true);
			this.X0Y0_羽7_紋1CP = new ColorP(this.X0Y0_羽7_紋1, this.羽7_紋1CD, DisUnit, true);
			this.X0Y0_羽7_紋2CP = new ColorP(this.X0Y0_羽7_紋2, this.羽7_紋2CD, DisUnit, true);
			this.X0Y0_羽8_羽CP = new ColorP(this.X0Y0_羽8_羽, this.羽8_羽CD, DisUnit, true);
			this.X0Y0_羽8_紋1CP = new ColorP(this.X0Y0_羽8_紋1, this.羽8_紋1CD, DisUnit, true);
			this.X0Y0_羽8_紋2CP = new ColorP(this.X0Y0_羽8_紋2, this.羽8_紋2CD, DisUnit, true);
			this.X0Y0_羽9_羽CP = new ColorP(this.X0Y0_羽9_羽, this.羽9_羽CD, DisUnit, true);
			this.X0Y0_羽9_紋1CP = new ColorP(this.X0Y0_羽9_紋1, this.羽9_紋1CD, DisUnit, true);
			this.X0Y0_羽9_紋2CP = new ColorP(this.X0Y0_羽9_紋2, this.羽9_紋2CD, DisUnit, true);
			this.X0Y0_羽10_羽CP = new ColorP(this.X0Y0_羽10_羽, this.羽10_羽CD, DisUnit, true);
			this.X0Y0_羽10_紋1CP = new ColorP(this.X0Y0_羽10_紋1, this.羽10_紋1CD, DisUnit, true);
			this.X0Y0_羽10_紋2CP = new ColorP(this.X0Y0_羽10_紋2, this.羽10_紋2CD, DisUnit, true);
			this.X0Y0_羽11_羽CP = new ColorP(this.X0Y0_羽11_羽, this.羽11_羽CD, DisUnit, true);
			this.X0Y0_羽11_紋1CP = new ColorP(this.X0Y0_羽11_紋1, this.羽11_紋1CD, DisUnit, true);
			this.X0Y0_羽11_紋2CP = new ColorP(this.X0Y0_羽11_紋2, this.羽11_紋2CD, DisUnit, true);
			this.X0Y0_羽12_羽CP = new ColorP(this.X0Y0_羽12_羽, this.羽12_羽CD, DisUnit, true);
			this.X0Y0_羽12_紋1CP = new ColorP(this.X0Y0_羽12_紋1, this.羽12_紋1CD, DisUnit, true);
			this.X0Y0_羽12_紋2CP = new ColorP(this.X0Y0_羽12_紋2, this.羽12_紋2CD, DisUnit, true);
			this.X0Y0_羽13_羽CP = new ColorP(this.X0Y0_羽13_羽, this.羽13_羽CD, DisUnit, true);
			this.X0Y0_羽13_紋1CP = new ColorP(this.X0Y0_羽13_紋1, this.羽13_紋1CD, DisUnit, true);
			this.X0Y0_羽13_紋2CP = new ColorP(this.X0Y0_羽13_紋2, this.羽13_紋2CD, DisUnit, true);
			this.X0Y0_羽14_羽CP = new ColorP(this.X0Y0_羽14_羽, this.羽14_羽CD, DisUnit, true);
			this.X0Y0_羽14_紋1CP = new ColorP(this.X0Y0_羽14_紋1, this.羽14_紋1CD, DisUnit, true);
			this.X0Y0_羽14_紋2CP = new ColorP(this.X0Y0_羽14_紋2, this.羽14_紋2CD, DisUnit, true);
			this.X0Y0_羽15_羽CP = new ColorP(this.X0Y0_羽15_羽, this.羽15_羽CD, DisUnit, true);
			this.X0Y0_羽15_紋1CP = new ColorP(this.X0Y0_羽15_紋1, this.羽15_紋1CD, DisUnit, true);
			this.X0Y0_羽15_紋2CP = new ColorP(this.X0Y0_羽15_紋2, this.羽15_紋2CD, DisUnit, true);
			this.X0Y0_羽16_羽CP = new ColorP(this.X0Y0_羽16_羽, this.羽16_羽CD, DisUnit, true);
			this.X0Y0_羽16_紋1CP = new ColorP(this.X0Y0_羽16_紋1, this.羽16_紋1CD, DisUnit, true);
			this.X0Y0_羽16_紋2CP = new ColorP(this.X0Y0_羽16_紋2, this.羽16_紋2CD, DisUnit, true);
			this.X0Y0_羽17_羽CP = new ColorP(this.X0Y0_羽17_羽, this.羽17_羽CD, DisUnit, true);
			this.X0Y0_羽17_紋1CP = new ColorP(this.X0Y0_羽17_紋1, this.羽17_紋1CD, DisUnit, true);
			this.X0Y0_羽17_紋2CP = new ColorP(this.X0Y0_羽17_紋2, this.羽17_紋2CD, DisUnit, true);
			this.X0Y0_羽18_羽CP = new ColorP(this.X0Y0_羽18_羽, this.羽18_羽CD, DisUnit, true);
			this.X0Y0_羽18_紋1CP = new ColorP(this.X0Y0_羽18_紋1, this.羽18_紋1CD, DisUnit, true);
			this.X0Y0_羽18_紋2CP = new ColorP(this.X0Y0_羽18_紋2, this.羽18_紋2CD, DisUnit, true);
			this.X0Y0_羽19_羽CP = new ColorP(this.X0Y0_羽19_羽, this.羽19_羽CD, DisUnit, true);
			this.X0Y0_羽19_紋1CP = new ColorP(this.X0Y0_羽19_紋1, this.羽19_紋1CD, DisUnit, true);
			this.X0Y0_羽19_紋2CP = new ColorP(this.X0Y0_羽19_紋2, this.羽19_紋2CD, DisUnit, true);
			this.X0Y0_羽20_羽CP = new ColorP(this.X0Y0_羽20_羽, this.羽20_羽CD, DisUnit, true);
			this.X0Y0_羽20_紋1CP = new ColorP(this.X0Y0_羽20_紋1, this.羽20_紋1CD, DisUnit, true);
			this.X0Y0_羽20_紋2CP = new ColorP(this.X0Y0_羽20_紋2, this.羽20_紋2CD, DisUnit, true);
			this.X0Y0_羽21_羽CP = new ColorP(this.X0Y0_羽21_羽, this.羽21_羽CD, DisUnit, true);
			this.X0Y0_羽21_紋1CP = new ColorP(this.X0Y0_羽21_紋1, this.羽21_紋1CD, DisUnit, true);
			this.X0Y0_羽21_紋2CP = new ColorP(this.X0Y0_羽21_紋2, this.羽21_紋2CD, DisUnit, true);
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

		public bool 羽_羽_表示
		{
			get
			{
				return this.X0Y0_羽_羽.Dra;
			}
			set
			{
				this.X0Y0_羽_羽.Dra = value;
				this.X0Y0_羽_羽.Hit = value;
			}
		}

		public bool 羽_紋1_表示
		{
			get
			{
				return this.X0Y0_羽_紋1.Dra;
			}
			set
			{
				this.X0Y0_羽_紋1.Dra = value;
				this.X0Y0_羽_紋1.Hit = value;
			}
		}

		public bool 羽_紋2_表示
		{
			get
			{
				return this.X0Y0_羽_紋2.Dra;
			}
			set
			{
				this.X0Y0_羽_紋2.Dra = value;
				this.X0Y0_羽_紋2.Hit = value;
			}
		}

		public bool 羽2_羽_表示
		{
			get
			{
				return this.X0Y0_羽2_羽.Dra;
			}
			set
			{
				this.X0Y0_羽2_羽.Dra = value;
				this.X0Y0_羽2_羽.Hit = value;
			}
		}

		public bool 羽2_紋1_表示
		{
			get
			{
				return this.X0Y0_羽2_紋1.Dra;
			}
			set
			{
				this.X0Y0_羽2_紋1.Dra = value;
				this.X0Y0_羽2_紋1.Hit = value;
			}
		}

		public bool 羽2_紋2_表示
		{
			get
			{
				return this.X0Y0_羽2_紋2.Dra;
			}
			set
			{
				this.X0Y0_羽2_紋2.Dra = value;
				this.X0Y0_羽2_紋2.Hit = value;
			}
		}

		public bool 羽3_羽_表示
		{
			get
			{
				return this.X0Y0_羽3_羽.Dra;
			}
			set
			{
				this.X0Y0_羽3_羽.Dra = value;
				this.X0Y0_羽3_羽.Hit = value;
			}
		}

		public bool 羽3_紋1_表示
		{
			get
			{
				return this.X0Y0_羽3_紋1.Dra;
			}
			set
			{
				this.X0Y0_羽3_紋1.Dra = value;
				this.X0Y0_羽3_紋1.Hit = value;
			}
		}

		public bool 羽3_紋2_表示
		{
			get
			{
				return this.X0Y0_羽3_紋2.Dra;
			}
			set
			{
				this.X0Y0_羽3_紋2.Dra = value;
				this.X0Y0_羽3_紋2.Hit = value;
			}
		}

		public bool 羽4_羽_表示
		{
			get
			{
				return this.X0Y0_羽4_羽.Dra;
			}
			set
			{
				this.X0Y0_羽4_羽.Dra = value;
				this.X0Y0_羽4_羽.Hit = value;
			}
		}

		public bool 羽4_紋1_表示
		{
			get
			{
				return this.X0Y0_羽4_紋1.Dra;
			}
			set
			{
				this.X0Y0_羽4_紋1.Dra = value;
				this.X0Y0_羽4_紋1.Hit = value;
			}
		}

		public bool 羽4_紋2_表示
		{
			get
			{
				return this.X0Y0_羽4_紋2.Dra;
			}
			set
			{
				this.X0Y0_羽4_紋2.Dra = value;
				this.X0Y0_羽4_紋2.Hit = value;
			}
		}

		public bool 羽5_羽_表示
		{
			get
			{
				return this.X0Y0_羽5_羽.Dra;
			}
			set
			{
				this.X0Y0_羽5_羽.Dra = value;
				this.X0Y0_羽5_羽.Hit = value;
			}
		}

		public bool 羽5_紋1_表示
		{
			get
			{
				return this.X0Y0_羽5_紋1.Dra;
			}
			set
			{
				this.X0Y0_羽5_紋1.Dra = value;
				this.X0Y0_羽5_紋1.Hit = value;
			}
		}

		public bool 羽5_紋2_表示
		{
			get
			{
				return this.X0Y0_羽5_紋2.Dra;
			}
			set
			{
				this.X0Y0_羽5_紋2.Dra = value;
				this.X0Y0_羽5_紋2.Hit = value;
			}
		}

		public bool 羽6_羽_表示
		{
			get
			{
				return this.X0Y0_羽6_羽.Dra;
			}
			set
			{
				this.X0Y0_羽6_羽.Dra = value;
				this.X0Y0_羽6_羽.Hit = value;
			}
		}

		public bool 羽6_紋1_表示
		{
			get
			{
				return this.X0Y0_羽6_紋1.Dra;
			}
			set
			{
				this.X0Y0_羽6_紋1.Dra = value;
				this.X0Y0_羽6_紋1.Hit = value;
			}
		}

		public bool 羽6_紋2_表示
		{
			get
			{
				return this.X0Y0_羽6_紋2.Dra;
			}
			set
			{
				this.X0Y0_羽6_紋2.Dra = value;
				this.X0Y0_羽6_紋2.Hit = value;
			}
		}

		public bool 羽7_羽_表示
		{
			get
			{
				return this.X0Y0_羽7_羽.Dra;
			}
			set
			{
				this.X0Y0_羽7_羽.Dra = value;
				this.X0Y0_羽7_羽.Hit = value;
			}
		}

		public bool 羽7_紋1_表示
		{
			get
			{
				return this.X0Y0_羽7_紋1.Dra;
			}
			set
			{
				this.X0Y0_羽7_紋1.Dra = value;
				this.X0Y0_羽7_紋1.Hit = value;
			}
		}

		public bool 羽7_紋2_表示
		{
			get
			{
				return this.X0Y0_羽7_紋2.Dra;
			}
			set
			{
				this.X0Y0_羽7_紋2.Dra = value;
				this.X0Y0_羽7_紋2.Hit = value;
			}
		}

		public bool 羽8_羽_表示
		{
			get
			{
				return this.X0Y0_羽8_羽.Dra;
			}
			set
			{
				this.X0Y0_羽8_羽.Dra = value;
				this.X0Y0_羽8_羽.Hit = value;
			}
		}

		public bool 羽8_紋1_表示
		{
			get
			{
				return this.X0Y0_羽8_紋1.Dra;
			}
			set
			{
				this.X0Y0_羽8_紋1.Dra = value;
				this.X0Y0_羽8_紋1.Hit = value;
			}
		}

		public bool 羽8_紋2_表示
		{
			get
			{
				return this.X0Y0_羽8_紋2.Dra;
			}
			set
			{
				this.X0Y0_羽8_紋2.Dra = value;
				this.X0Y0_羽8_紋2.Hit = value;
			}
		}

		public bool 羽9_羽_表示
		{
			get
			{
				return this.X0Y0_羽9_羽.Dra;
			}
			set
			{
				this.X0Y0_羽9_羽.Dra = value;
				this.X0Y0_羽9_羽.Hit = value;
			}
		}

		public bool 羽9_紋1_表示
		{
			get
			{
				return this.X0Y0_羽9_紋1.Dra;
			}
			set
			{
				this.X0Y0_羽9_紋1.Dra = value;
				this.X0Y0_羽9_紋1.Hit = value;
			}
		}

		public bool 羽9_紋2_表示
		{
			get
			{
				return this.X0Y0_羽9_紋2.Dra;
			}
			set
			{
				this.X0Y0_羽9_紋2.Dra = value;
				this.X0Y0_羽9_紋2.Hit = value;
			}
		}

		public bool 羽10_羽_表示
		{
			get
			{
				return this.X0Y0_羽10_羽.Dra;
			}
			set
			{
				this.X0Y0_羽10_羽.Dra = value;
				this.X0Y0_羽10_羽.Hit = value;
			}
		}

		public bool 羽10_紋1_表示
		{
			get
			{
				return this.X0Y0_羽10_紋1.Dra;
			}
			set
			{
				this.X0Y0_羽10_紋1.Dra = value;
				this.X0Y0_羽10_紋1.Hit = value;
			}
		}

		public bool 羽10_紋2_表示
		{
			get
			{
				return this.X0Y0_羽10_紋2.Dra;
			}
			set
			{
				this.X0Y0_羽10_紋2.Dra = value;
				this.X0Y0_羽10_紋2.Hit = value;
			}
		}

		public bool 羽11_羽_表示
		{
			get
			{
				return this.X0Y0_羽11_羽.Dra;
			}
			set
			{
				this.X0Y0_羽11_羽.Dra = value;
				this.X0Y0_羽11_羽.Hit = value;
			}
		}

		public bool 羽11_紋1_表示
		{
			get
			{
				return this.X0Y0_羽11_紋1.Dra;
			}
			set
			{
				this.X0Y0_羽11_紋1.Dra = value;
				this.X0Y0_羽11_紋1.Hit = value;
			}
		}

		public bool 羽11_紋2_表示
		{
			get
			{
				return this.X0Y0_羽11_紋2.Dra;
			}
			set
			{
				this.X0Y0_羽11_紋2.Dra = value;
				this.X0Y0_羽11_紋2.Hit = value;
			}
		}

		public bool 羽12_羽_表示
		{
			get
			{
				return this.X0Y0_羽12_羽.Dra;
			}
			set
			{
				this.X0Y0_羽12_羽.Dra = value;
				this.X0Y0_羽12_羽.Hit = value;
			}
		}

		public bool 羽12_紋1_表示
		{
			get
			{
				return this.X0Y0_羽12_紋1.Dra;
			}
			set
			{
				this.X0Y0_羽12_紋1.Dra = value;
				this.X0Y0_羽12_紋1.Hit = value;
			}
		}

		public bool 羽12_紋2_表示
		{
			get
			{
				return this.X0Y0_羽12_紋2.Dra;
			}
			set
			{
				this.X0Y0_羽12_紋2.Dra = value;
				this.X0Y0_羽12_紋2.Hit = value;
			}
		}

		public bool 羽13_羽_表示
		{
			get
			{
				return this.X0Y0_羽13_羽.Dra;
			}
			set
			{
				this.X0Y0_羽13_羽.Dra = value;
				this.X0Y0_羽13_羽.Hit = value;
			}
		}

		public bool 羽13_紋1_表示
		{
			get
			{
				return this.X0Y0_羽13_紋1.Dra;
			}
			set
			{
				this.X0Y0_羽13_紋1.Dra = value;
				this.X0Y0_羽13_紋1.Hit = value;
			}
		}

		public bool 羽13_紋2_表示
		{
			get
			{
				return this.X0Y0_羽13_紋2.Dra;
			}
			set
			{
				this.X0Y0_羽13_紋2.Dra = value;
				this.X0Y0_羽13_紋2.Hit = value;
			}
		}

		public bool 羽14_羽_表示
		{
			get
			{
				return this.X0Y0_羽14_羽.Dra;
			}
			set
			{
				this.X0Y0_羽14_羽.Dra = value;
				this.X0Y0_羽14_羽.Hit = value;
			}
		}

		public bool 羽14_紋1_表示
		{
			get
			{
				return this.X0Y0_羽14_紋1.Dra;
			}
			set
			{
				this.X0Y0_羽14_紋1.Dra = value;
				this.X0Y0_羽14_紋1.Hit = value;
			}
		}

		public bool 羽14_紋2_表示
		{
			get
			{
				return this.X0Y0_羽14_紋2.Dra;
			}
			set
			{
				this.X0Y0_羽14_紋2.Dra = value;
				this.X0Y0_羽14_紋2.Hit = value;
			}
		}

		public bool 羽15_羽_表示
		{
			get
			{
				return this.X0Y0_羽15_羽.Dra;
			}
			set
			{
				this.X0Y0_羽15_羽.Dra = value;
				this.X0Y0_羽15_羽.Hit = value;
			}
		}

		public bool 羽15_紋1_表示
		{
			get
			{
				return this.X0Y0_羽15_紋1.Dra;
			}
			set
			{
				this.X0Y0_羽15_紋1.Dra = value;
				this.X0Y0_羽15_紋1.Hit = value;
			}
		}

		public bool 羽15_紋2_表示
		{
			get
			{
				return this.X0Y0_羽15_紋2.Dra;
			}
			set
			{
				this.X0Y0_羽15_紋2.Dra = value;
				this.X0Y0_羽15_紋2.Hit = value;
			}
		}

		public bool 羽16_羽_表示
		{
			get
			{
				return this.X0Y0_羽16_羽.Dra;
			}
			set
			{
				this.X0Y0_羽16_羽.Dra = value;
				this.X0Y0_羽16_羽.Hit = value;
			}
		}

		public bool 羽16_紋1_表示
		{
			get
			{
				return this.X0Y0_羽16_紋1.Dra;
			}
			set
			{
				this.X0Y0_羽16_紋1.Dra = value;
				this.X0Y0_羽16_紋1.Hit = value;
			}
		}

		public bool 羽16_紋2_表示
		{
			get
			{
				return this.X0Y0_羽16_紋2.Dra;
			}
			set
			{
				this.X0Y0_羽16_紋2.Dra = value;
				this.X0Y0_羽16_紋2.Hit = value;
			}
		}

		public bool 羽17_羽_表示
		{
			get
			{
				return this.X0Y0_羽17_羽.Dra;
			}
			set
			{
				this.X0Y0_羽17_羽.Dra = value;
				this.X0Y0_羽17_羽.Hit = value;
			}
		}

		public bool 羽17_紋1_表示
		{
			get
			{
				return this.X0Y0_羽17_紋1.Dra;
			}
			set
			{
				this.X0Y0_羽17_紋1.Dra = value;
				this.X0Y0_羽17_紋1.Hit = value;
			}
		}

		public bool 羽17_紋2_表示
		{
			get
			{
				return this.X0Y0_羽17_紋2.Dra;
			}
			set
			{
				this.X0Y0_羽17_紋2.Dra = value;
				this.X0Y0_羽17_紋2.Hit = value;
			}
		}

		public bool 羽18_羽_表示
		{
			get
			{
				return this.X0Y0_羽18_羽.Dra;
			}
			set
			{
				this.X0Y0_羽18_羽.Dra = value;
				this.X0Y0_羽18_羽.Hit = value;
			}
		}

		public bool 羽18_紋1_表示
		{
			get
			{
				return this.X0Y0_羽18_紋1.Dra;
			}
			set
			{
				this.X0Y0_羽18_紋1.Dra = value;
				this.X0Y0_羽18_紋1.Hit = value;
			}
		}

		public bool 羽18_紋2_表示
		{
			get
			{
				return this.X0Y0_羽18_紋2.Dra;
			}
			set
			{
				this.X0Y0_羽18_紋2.Dra = value;
				this.X0Y0_羽18_紋2.Hit = value;
			}
		}

		public bool 羽19_羽_表示
		{
			get
			{
				return this.X0Y0_羽19_羽.Dra;
			}
			set
			{
				this.X0Y0_羽19_羽.Dra = value;
				this.X0Y0_羽19_羽.Hit = value;
			}
		}

		public bool 羽19_紋1_表示
		{
			get
			{
				return this.X0Y0_羽19_紋1.Dra;
			}
			set
			{
				this.X0Y0_羽19_紋1.Dra = value;
				this.X0Y0_羽19_紋1.Hit = value;
			}
		}

		public bool 羽19_紋2_表示
		{
			get
			{
				return this.X0Y0_羽19_紋2.Dra;
			}
			set
			{
				this.X0Y0_羽19_紋2.Dra = value;
				this.X0Y0_羽19_紋2.Hit = value;
			}
		}

		public bool 羽20_羽_表示
		{
			get
			{
				return this.X0Y0_羽20_羽.Dra;
			}
			set
			{
				this.X0Y0_羽20_羽.Dra = value;
				this.X0Y0_羽20_羽.Hit = value;
			}
		}

		public bool 羽20_紋1_表示
		{
			get
			{
				return this.X0Y0_羽20_紋1.Dra;
			}
			set
			{
				this.X0Y0_羽20_紋1.Dra = value;
				this.X0Y0_羽20_紋1.Hit = value;
			}
		}

		public bool 羽20_紋2_表示
		{
			get
			{
				return this.X0Y0_羽20_紋2.Dra;
			}
			set
			{
				this.X0Y0_羽20_紋2.Dra = value;
				this.X0Y0_羽20_紋2.Hit = value;
			}
		}

		public bool 羽21_羽_表示
		{
			get
			{
				return this.X0Y0_羽21_羽.Dra;
			}
			set
			{
				this.X0Y0_羽21_羽.Dra = value;
				this.X0Y0_羽21_羽.Hit = value;
			}
		}

		public bool 羽21_紋1_表示
		{
			get
			{
				return this.X0Y0_羽21_紋1.Dra;
			}
			set
			{
				this.X0Y0_羽21_紋1.Dra = value;
				this.X0Y0_羽21_紋1.Hit = value;
			}
		}

		public bool 羽21_紋2_表示
		{
			get
			{
				return this.X0Y0_羽21_紋2.Dra;
			}
			set
			{
				this.X0Y0_羽21_紋2.Dra = value;
				this.X0Y0_羽21_紋2.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.羽_羽_表示;
			}
			set
			{
				this.羽_羽_表示 = value;
				this.羽_紋1_表示 = value;
				this.羽_紋2_表示 = value;
				this.羽2_羽_表示 = value;
				this.羽2_紋1_表示 = value;
				this.羽2_紋2_表示 = value;
				this.羽3_羽_表示 = value;
				this.羽3_紋1_表示 = value;
				this.羽3_紋2_表示 = value;
				this.羽4_羽_表示 = value;
				this.羽4_紋1_表示 = value;
				this.羽4_紋2_表示 = value;
				this.羽5_羽_表示 = value;
				this.羽5_紋1_表示 = value;
				this.羽5_紋2_表示 = value;
				this.羽6_羽_表示 = value;
				this.羽6_紋1_表示 = value;
				this.羽6_紋2_表示 = value;
				this.羽7_羽_表示 = value;
				this.羽7_紋1_表示 = value;
				this.羽7_紋2_表示 = value;
				this.羽8_羽_表示 = value;
				this.羽8_紋1_表示 = value;
				this.羽8_紋2_表示 = value;
				this.羽9_羽_表示 = value;
				this.羽9_紋1_表示 = value;
				this.羽9_紋2_表示 = value;
				this.羽10_羽_表示 = value;
				this.羽10_紋1_表示 = value;
				this.羽10_紋2_表示 = value;
				this.羽11_羽_表示 = value;
				this.羽11_紋1_表示 = value;
				this.羽11_紋2_表示 = value;
				this.羽12_羽_表示 = value;
				this.羽12_紋1_表示 = value;
				this.羽12_紋2_表示 = value;
				this.羽13_羽_表示 = value;
				this.羽13_紋1_表示 = value;
				this.羽13_紋2_表示 = value;
				this.羽14_羽_表示 = value;
				this.羽14_紋1_表示 = value;
				this.羽14_紋2_表示 = value;
				this.羽15_羽_表示 = value;
				this.羽15_紋1_表示 = value;
				this.羽15_紋2_表示 = value;
				this.羽16_羽_表示 = value;
				this.羽16_紋1_表示 = value;
				this.羽16_紋2_表示 = value;
				this.羽17_羽_表示 = value;
				this.羽17_紋1_表示 = value;
				this.羽17_紋2_表示 = value;
				this.羽18_羽_表示 = value;
				this.羽18_紋1_表示 = value;
				this.羽18_紋2_表示 = value;
				this.羽19_羽_表示 = value;
				this.羽19_紋1_表示 = value;
				this.羽19_紋2_表示 = value;
				this.羽20_羽_表示 = value;
				this.羽20_紋1_表示 = value;
				this.羽20_紋2_表示 = value;
				this.羽21_羽_表示 = value;
				this.羽21_紋1_表示 = value;
				this.羽21_紋2_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.羽_羽CD.不透明度;
			}
			set
			{
				this.羽_羽CD.不透明度 = value;
				this.羽_紋1CD.不透明度 = value;
				this.羽_紋2CD.不透明度 = value;
				this.羽2_羽CD.不透明度 = value;
				this.羽2_紋1CD.不透明度 = value;
				this.羽2_紋2CD.不透明度 = value;
				this.羽3_羽CD.不透明度 = value;
				this.羽3_紋1CD.不透明度 = value;
				this.羽3_紋2CD.不透明度 = value;
				this.羽4_羽CD.不透明度 = value;
				this.羽4_紋1CD.不透明度 = value;
				this.羽4_紋2CD.不透明度 = value;
				this.羽5_羽CD.不透明度 = value;
				this.羽5_紋1CD.不透明度 = value;
				this.羽5_紋2CD.不透明度 = value;
				this.羽6_羽CD.不透明度 = value;
				this.羽6_紋1CD.不透明度 = value;
				this.羽6_紋2CD.不透明度 = value;
				this.羽7_羽CD.不透明度 = value;
				this.羽7_紋1CD.不透明度 = value;
				this.羽7_紋2CD.不透明度 = value;
				this.羽8_羽CD.不透明度 = value;
				this.羽8_紋1CD.不透明度 = value;
				this.羽8_紋2CD.不透明度 = value;
				this.羽9_羽CD.不透明度 = value;
				this.羽9_紋1CD.不透明度 = value;
				this.羽9_紋2CD.不透明度 = value;
				this.羽10_羽CD.不透明度 = value;
				this.羽10_紋1CD.不透明度 = value;
				this.羽10_紋2CD.不透明度 = value;
				this.羽11_羽CD.不透明度 = value;
				this.羽11_紋1CD.不透明度 = value;
				this.羽11_紋2CD.不透明度 = value;
				this.羽12_羽CD.不透明度 = value;
				this.羽12_紋1CD.不透明度 = value;
				this.羽12_紋2CD.不透明度 = value;
				this.羽13_羽CD.不透明度 = value;
				this.羽13_紋1CD.不透明度 = value;
				this.羽13_紋2CD.不透明度 = value;
				this.羽14_羽CD.不透明度 = value;
				this.羽14_紋1CD.不透明度 = value;
				this.羽14_紋2CD.不透明度 = value;
				this.羽15_羽CD.不透明度 = value;
				this.羽15_紋1CD.不透明度 = value;
				this.羽15_紋2CD.不透明度 = value;
				this.羽16_羽CD.不透明度 = value;
				this.羽16_紋1CD.不透明度 = value;
				this.羽16_紋2CD.不透明度 = value;
				this.羽17_羽CD.不透明度 = value;
				this.羽17_紋1CD.不透明度 = value;
				this.羽17_紋2CD.不透明度 = value;
				this.羽18_羽CD.不透明度 = value;
				this.羽18_紋1CD.不透明度 = value;
				this.羽18_紋2CD.不透明度 = value;
				this.羽19_羽CD.不透明度 = value;
				this.羽19_紋1CD.不透明度 = value;
				this.羽19_紋2CD.不透明度 = value;
				this.羽20_羽CD.不透明度 = value;
				this.羽20_紋1CD.不透明度 = value;
				this.羽20_紋2CD.不透明度 = value;
				this.羽21_羽CD.不透明度 = value;
				this.羽21_紋1CD.不透明度 = value;
				this.羽21_紋2CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			bool 右 = this.右;
			double maxAngle = 25.0;
			this.X0Y0_羽_羽.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_羽2_羽.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_羽3_羽.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_羽4_羽.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_羽5_羽.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_羽6_羽.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_羽7_羽.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_羽8_羽.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_羽9_羽.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_羽10_羽.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_羽11_羽.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_羽12_羽.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_羽13_羽.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_羽14_羽.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_羽15_羽.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_羽16_羽.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_羽17_羽.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_羽18_羽.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_羽19_羽.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_羽20_羽.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_羽21_羽.AngleBase = maxAngle.GetRanAngle();
			this.本体.JoinPAall();
		}

		public override double 肥大
		{
			set
			{
			}
		}

		public override double 身長
		{
			set
			{
			}
		}

		public override void 色更新()
		{
			this.X0Y0_羽_羽CP.Update();
			this.X0Y0_羽_紋1CP.Update();
			this.X0Y0_羽_紋2CP.Update();
			this.X0Y0_羽2_羽CP.Update();
			this.X0Y0_羽2_紋1CP.Update();
			this.X0Y0_羽2_紋2CP.Update();
			this.X0Y0_羽3_羽CP.Update();
			this.X0Y0_羽3_紋1CP.Update();
			this.X0Y0_羽3_紋2CP.Update();
			this.X0Y0_羽4_羽CP.Update();
			this.X0Y0_羽4_紋1CP.Update();
			this.X0Y0_羽4_紋2CP.Update();
			this.X0Y0_羽5_羽CP.Update();
			this.X0Y0_羽5_紋1CP.Update();
			this.X0Y0_羽5_紋2CP.Update();
			this.X0Y0_羽6_羽CP.Update();
			this.X0Y0_羽6_紋1CP.Update();
			this.X0Y0_羽6_紋2CP.Update();
			this.X0Y0_羽7_羽CP.Update();
			this.X0Y0_羽7_紋1CP.Update();
			this.X0Y0_羽7_紋2CP.Update();
			this.X0Y0_羽8_羽CP.Update();
			this.X0Y0_羽8_紋1CP.Update();
			this.X0Y0_羽8_紋2CP.Update();
			this.X0Y0_羽9_羽CP.Update();
			this.X0Y0_羽9_紋1CP.Update();
			this.X0Y0_羽9_紋2CP.Update();
			this.X0Y0_羽10_羽CP.Update();
			this.X0Y0_羽10_紋1CP.Update();
			this.X0Y0_羽10_紋2CP.Update();
			this.X0Y0_羽11_羽CP.Update();
			this.X0Y0_羽11_紋1CP.Update();
			this.X0Y0_羽11_紋2CP.Update();
			this.X0Y0_羽12_羽CP.Update();
			this.X0Y0_羽12_紋1CP.Update();
			this.X0Y0_羽12_紋2CP.Update();
			this.X0Y0_羽13_羽CP.Update();
			this.X0Y0_羽13_紋1CP.Update();
			this.X0Y0_羽13_紋2CP.Update();
			this.X0Y0_羽14_羽CP.Update();
			this.X0Y0_羽14_紋1CP.Update();
			this.X0Y0_羽14_紋2CP.Update();
			this.X0Y0_羽15_羽CP.Update();
			this.X0Y0_羽15_紋1CP.Update();
			this.X0Y0_羽15_紋2CP.Update();
			this.X0Y0_羽16_羽CP.Update();
			this.X0Y0_羽16_紋1CP.Update();
			this.X0Y0_羽16_紋2CP.Update();
			this.X0Y0_羽17_羽CP.Update();
			this.X0Y0_羽17_紋1CP.Update();
			this.X0Y0_羽17_紋2CP.Update();
			this.X0Y0_羽18_羽CP.Update();
			this.X0Y0_羽18_紋1CP.Update();
			this.X0Y0_羽18_紋2CP.Update();
			this.X0Y0_羽19_羽CP.Update();
			this.X0Y0_羽19_紋1CP.Update();
			this.X0Y0_羽19_紋2CP.Update();
			this.X0Y0_羽20_羽CP.Update();
			this.X0Y0_羽20_紋1CP.Update();
			this.X0Y0_羽20_紋2CP.Update();
			this.X0Y0_羽21_羽CP.Update();
			this.X0Y0_羽21_紋1CP.Update();
			this.X0Y0_羽21_紋2CP.Update();
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
			this.羽_羽CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
			this.羽_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽2_羽CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
			this.羽2_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽2_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽3_羽CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
			this.羽3_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽3_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽4_羽CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
			this.羽4_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽4_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽5_羽CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
			this.羽5_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽5_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽6_羽CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
			this.羽6_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽6_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽7_羽CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
			this.羽7_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽7_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽8_羽CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
			this.羽8_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽8_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽9_羽CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
			this.羽9_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽9_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽10_羽CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
			this.羽10_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽10_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽11_羽CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
			this.羽11_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽11_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽12_羽CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
			this.羽12_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽12_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽13_羽CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
			this.羽13_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽13_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽14_羽CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
			this.羽14_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽14_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽15_羽CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
			this.羽15_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽15_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽16_羽CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
			this.羽16_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽16_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽17_羽CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
			this.羽17_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽17_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽18_羽CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
			this.羽18_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽18_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽19_羽CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
			this.羽19_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽19_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽20_羽CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
			this.羽20_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽20_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽21_羽CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
			this.羽21_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽21_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
		}

		private void 配色T0(体配色 体配色)
		{
			this.羽_羽CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽2_羽CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽2_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽2_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽3_羽CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽3_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽3_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽4_羽CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽4_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽4_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽5_羽CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽5_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽5_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽6_羽CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽6_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽6_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽7_羽CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽7_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽7_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽8_羽CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽8_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽8_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽9_羽CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽9_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽9_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽10_羽CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽10_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽10_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽11_羽CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽11_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽11_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽12_羽CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽12_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽12_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽13_羽CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽13_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽13_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽14_羽CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽14_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽14_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽15_羽CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽15_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽15_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽16_羽CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽16_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽16_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽17_羽CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽17_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽17_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽18_羽CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽18_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽18_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽19_羽CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽19_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽19_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽20_羽CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽20_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽20_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽21_羽CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽21_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽21_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
		}

		private void 配色T1(体配色 体配色)
		{
			this.羽_羽CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽2_羽CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽2_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽2_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽3_羽CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽3_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽3_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽4_羽CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽4_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽4_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽5_羽CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽5_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽5_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽6_羽CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽6_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽6_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽7_羽CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽7_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽7_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽8_羽CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽8_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽8_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽9_羽CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽9_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽9_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽10_羽CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽10_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽10_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽11_羽CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽11_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽11_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽12_羽CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽12_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽12_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽13_羽CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽13_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽13_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽14_羽CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽14_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽14_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽15_羽CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽15_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽15_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽16_羽CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽16_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽16_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽17_羽CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽17_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽17_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽18_羽CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽18_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽18_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽19_羽CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽19_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽19_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽20_羽CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽20_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽20_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.羽21_羽CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽21_紋1CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.羽21_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
		}

		public Par X0Y0_羽_羽;

		public Par X0Y0_羽_紋1;

		public Par X0Y0_羽_紋2;

		public Par X0Y0_羽2_羽;

		public Par X0Y0_羽2_紋1;

		public Par X0Y0_羽2_紋2;

		public Par X0Y0_羽3_羽;

		public Par X0Y0_羽3_紋1;

		public Par X0Y0_羽3_紋2;

		public Par X0Y0_羽4_羽;

		public Par X0Y0_羽4_紋1;

		public Par X0Y0_羽4_紋2;

		public Par X0Y0_羽5_羽;

		public Par X0Y0_羽5_紋1;

		public Par X0Y0_羽5_紋2;

		public Par X0Y0_羽6_羽;

		public Par X0Y0_羽6_紋1;

		public Par X0Y0_羽6_紋2;

		public Par X0Y0_羽7_羽;

		public Par X0Y0_羽7_紋1;

		public Par X0Y0_羽7_紋2;

		public Par X0Y0_羽8_羽;

		public Par X0Y0_羽8_紋1;

		public Par X0Y0_羽8_紋2;

		public Par X0Y0_羽9_羽;

		public Par X0Y0_羽9_紋1;

		public Par X0Y0_羽9_紋2;

		public Par X0Y0_羽10_羽;

		public Par X0Y0_羽10_紋1;

		public Par X0Y0_羽10_紋2;

		public Par X0Y0_羽11_羽;

		public Par X0Y0_羽11_紋1;

		public Par X0Y0_羽11_紋2;

		public Par X0Y0_羽12_羽;

		public Par X0Y0_羽12_紋1;

		public Par X0Y0_羽12_紋2;

		public Par X0Y0_羽13_羽;

		public Par X0Y0_羽13_紋1;

		public Par X0Y0_羽13_紋2;

		public Par X0Y0_羽14_羽;

		public Par X0Y0_羽14_紋1;

		public Par X0Y0_羽14_紋2;

		public Par X0Y0_羽15_羽;

		public Par X0Y0_羽15_紋1;

		public Par X0Y0_羽15_紋2;

		public Par X0Y0_羽16_羽;

		public Par X0Y0_羽16_紋1;

		public Par X0Y0_羽16_紋2;

		public Par X0Y0_羽17_羽;

		public Par X0Y0_羽17_紋1;

		public Par X0Y0_羽17_紋2;

		public Par X0Y0_羽18_羽;

		public Par X0Y0_羽18_紋1;

		public Par X0Y0_羽18_紋2;

		public Par X0Y0_羽19_羽;

		public Par X0Y0_羽19_紋1;

		public Par X0Y0_羽19_紋2;

		public Par X0Y0_羽20_羽;

		public Par X0Y0_羽20_紋1;

		public Par X0Y0_羽20_紋2;

		public Par X0Y0_羽21_羽;

		public Par X0Y0_羽21_紋1;

		public Par X0Y0_羽21_紋2;

		public ColorD 羽_羽CD;

		public ColorD 羽_紋1CD;

		public ColorD 羽_紋2CD;

		public ColorD 羽2_羽CD;

		public ColorD 羽2_紋1CD;

		public ColorD 羽2_紋2CD;

		public ColorD 羽3_羽CD;

		public ColorD 羽3_紋1CD;

		public ColorD 羽3_紋2CD;

		public ColorD 羽4_羽CD;

		public ColorD 羽4_紋1CD;

		public ColorD 羽4_紋2CD;

		public ColorD 羽5_羽CD;

		public ColorD 羽5_紋1CD;

		public ColorD 羽5_紋2CD;

		public ColorD 羽6_羽CD;

		public ColorD 羽6_紋1CD;

		public ColorD 羽6_紋2CD;

		public ColorD 羽7_羽CD;

		public ColorD 羽7_紋1CD;

		public ColorD 羽7_紋2CD;

		public ColorD 羽8_羽CD;

		public ColorD 羽8_紋1CD;

		public ColorD 羽8_紋2CD;

		public ColorD 羽9_羽CD;

		public ColorD 羽9_紋1CD;

		public ColorD 羽9_紋2CD;

		public ColorD 羽10_羽CD;

		public ColorD 羽10_紋1CD;

		public ColorD 羽10_紋2CD;

		public ColorD 羽11_羽CD;

		public ColorD 羽11_紋1CD;

		public ColorD 羽11_紋2CD;

		public ColorD 羽12_羽CD;

		public ColorD 羽12_紋1CD;

		public ColorD 羽12_紋2CD;

		public ColorD 羽13_羽CD;

		public ColorD 羽13_紋1CD;

		public ColorD 羽13_紋2CD;

		public ColorD 羽14_羽CD;

		public ColorD 羽14_紋1CD;

		public ColorD 羽14_紋2CD;

		public ColorD 羽15_羽CD;

		public ColorD 羽15_紋1CD;

		public ColorD 羽15_紋2CD;

		public ColorD 羽16_羽CD;

		public ColorD 羽16_紋1CD;

		public ColorD 羽16_紋2CD;

		public ColorD 羽17_羽CD;

		public ColorD 羽17_紋1CD;

		public ColorD 羽17_紋2CD;

		public ColorD 羽18_羽CD;

		public ColorD 羽18_紋1CD;

		public ColorD 羽18_紋2CD;

		public ColorD 羽19_羽CD;

		public ColorD 羽19_紋1CD;

		public ColorD 羽19_紋2CD;

		public ColorD 羽20_羽CD;

		public ColorD 羽20_紋1CD;

		public ColorD 羽20_紋2CD;

		public ColorD 羽21_羽CD;

		public ColorD 羽21_紋1CD;

		public ColorD 羽21_紋2CD;

		public ColorP X0Y0_羽_羽CP;

		public ColorP X0Y0_羽_紋1CP;

		public ColorP X0Y0_羽_紋2CP;

		public ColorP X0Y0_羽2_羽CP;

		public ColorP X0Y0_羽2_紋1CP;

		public ColorP X0Y0_羽2_紋2CP;

		public ColorP X0Y0_羽3_羽CP;

		public ColorP X0Y0_羽3_紋1CP;

		public ColorP X0Y0_羽3_紋2CP;

		public ColorP X0Y0_羽4_羽CP;

		public ColorP X0Y0_羽4_紋1CP;

		public ColorP X0Y0_羽4_紋2CP;

		public ColorP X0Y0_羽5_羽CP;

		public ColorP X0Y0_羽5_紋1CP;

		public ColorP X0Y0_羽5_紋2CP;

		public ColorP X0Y0_羽6_羽CP;

		public ColorP X0Y0_羽6_紋1CP;

		public ColorP X0Y0_羽6_紋2CP;

		public ColorP X0Y0_羽7_羽CP;

		public ColorP X0Y0_羽7_紋1CP;

		public ColorP X0Y0_羽7_紋2CP;

		public ColorP X0Y0_羽8_羽CP;

		public ColorP X0Y0_羽8_紋1CP;

		public ColorP X0Y0_羽8_紋2CP;

		public ColorP X0Y0_羽9_羽CP;

		public ColorP X0Y0_羽9_紋1CP;

		public ColorP X0Y0_羽9_紋2CP;

		public ColorP X0Y0_羽10_羽CP;

		public ColorP X0Y0_羽10_紋1CP;

		public ColorP X0Y0_羽10_紋2CP;

		public ColorP X0Y0_羽11_羽CP;

		public ColorP X0Y0_羽11_紋1CP;

		public ColorP X0Y0_羽11_紋2CP;

		public ColorP X0Y0_羽12_羽CP;

		public ColorP X0Y0_羽12_紋1CP;

		public ColorP X0Y0_羽12_紋2CP;

		public ColorP X0Y0_羽13_羽CP;

		public ColorP X0Y0_羽13_紋1CP;

		public ColorP X0Y0_羽13_紋2CP;

		public ColorP X0Y0_羽14_羽CP;

		public ColorP X0Y0_羽14_紋1CP;

		public ColorP X0Y0_羽14_紋2CP;

		public ColorP X0Y0_羽15_羽CP;

		public ColorP X0Y0_羽15_紋1CP;

		public ColorP X0Y0_羽15_紋2CP;

		public ColorP X0Y0_羽16_羽CP;

		public ColorP X0Y0_羽16_紋1CP;

		public ColorP X0Y0_羽16_紋2CP;

		public ColorP X0Y0_羽17_羽CP;

		public ColorP X0Y0_羽17_紋1CP;

		public ColorP X0Y0_羽17_紋2CP;

		public ColorP X0Y0_羽18_羽CP;

		public ColorP X0Y0_羽18_紋1CP;

		public ColorP X0Y0_羽18_紋2CP;

		public ColorP X0Y0_羽19_羽CP;

		public ColorP X0Y0_羽19_紋1CP;

		public ColorP X0Y0_羽19_紋2CP;

		public ColorP X0Y0_羽20_羽CP;

		public ColorP X0Y0_羽20_紋1CP;

		public ColorP X0Y0_羽20_紋2CP;

		public ColorP X0Y0_羽21_羽CP;

		public ColorP X0Y0_羽21_紋1CP;

		public ColorP X0Y0_羽21_紋2CP;
	}
}
