using System;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 横髪_肢系 : 横髪
	{
		public 横髪_肢系(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 横髪_肢系D e)
		{
			横髪_肢系.<>c__DisplayClass3_0 CS$<>8__locals1 = new 横髪_肢系.<>c__DisplayClass3_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "肢系";
			dif.Add(new Pars(Sta.胴体["横髪左"][0][5]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_髪 = pars["髪"].ToPar();
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
			this.髪_表示 = e.髪_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.肢_接続.Count > 0)
			{
				Ele f;
				this.肢_接続 = e.肢_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.横髪_肢系_肢_接続;
					f.接続(CS$<>8__locals1.<>4__this.肢_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_髪CP = new ColorP(this.X0Y0_髪, this.髪CD, CS$<>8__locals1.DisUnit, false);
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

		public bool 髪_表示
		{
			get
			{
				return this.X0Y0_髪.Dra;
			}
			set
			{
				this.X0Y0_髪.Dra = value;
				this.X0Y0_髪.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.髪_表示;
			}
			set
			{
				this.髪_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.髪CD.不透明度;
			}
			set
			{
				this.髪CD.不透明度 = value;
			}
		}

		public JointS 肢_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_髪, 0);
			}
		}

		public override void 色更新()
		{
			this.X0Y0_髪CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.髪CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
		}

		public Par X0Y0_髪;

		public ColorD 髪CD;

		public ColorP X0Y0_髪CP;

		public Ele[] 肢_接続;
	}
}
