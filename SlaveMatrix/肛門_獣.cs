using System;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 肛門_獣 : 肛門
	{
		public 肛門_獣(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 肛門_獣D e)
		{
			肛門_獣.<>c__DisplayClass9_0 CS$<>8__locals1 = new 肛門_獣.<>c__DisplayClass9_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.半身["四足肛門"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_肛門3 = pars["肛門3"].ToPar();
			this.X0Y0_肛門2 = pars["肛門2"].ToPar();
			this.X0Y0_肛門1 = pars["肛門1"].ToPar();
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
			this.肛門3_表示 = e.肛門3_表示;
			this.肛門2_表示 = e.肛門2_表示;
			this.肛門1_表示 = e.肛門1_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.肛門精液_接続.Count > 0)
			{
				Ele f;
				this.肛門精液_接続 = e.肛門精液_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.肛門_獣_肛門精液_接続;
					f.接続(CS$<>8__locals1.<>4__this.肛門精液_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_肛門3CP = new ColorP(this.X0Y0_肛門3, this.肛門3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_肛門2CP = new ColorP(this.X0Y0_肛門2, this.肛門2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_肛門1CP = new ColorP(this.X0Y0_肛門1, this.肛門1CD, CS$<>8__locals1.DisUnit, true);
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

		public bool 肛門3_表示
		{
			get
			{
				return this.X0Y0_肛門3.Dra;
			}
			set
			{
				this.X0Y0_肛門3.Dra = value;
				this.X0Y0_肛門3.Hit = value;
			}
		}

		public bool 肛門2_表示
		{
			get
			{
				return this.X0Y0_肛門2.Dra;
			}
			set
			{
				this.X0Y0_肛門2.Dra = value;
				this.X0Y0_肛門2.Hit = value;
			}
		}

		public bool 肛門1_表示
		{
			get
			{
				return this.X0Y0_肛門1.Dra;
			}
			set
			{
				this.X0Y0_肛門1.Dra = value;
				this.X0Y0_肛門1.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.肛門3_表示;
			}
			set
			{
				this.肛門3_表示 = value;
				this.肛門2_表示 = value;
				this.肛門1_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.肛門3CD.不透明度;
			}
			set
			{
				this.肛門3CD.不透明度 = value;
				this.肛門2CD.不透明度 = value;
				this.肛門1CD.不透明度 = value;
			}
		}

		public JointS 肛門精液_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_肛門2, 0);
			}
		}

		public override void 色更新()
		{
			this.X0Y0_肛門3CP.Update();
			this.X0Y0_肛門2CP.Update();
			this.X0Y0_肛門1CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			Color2 color;
			Col.Alpha(ref 体配色.粘膜, 180, out color);
			this.肛門3CD = new ColorD(ref Col.Empty, ref color);
			this.肛門2CD = new ColorD(ref 体配色.粘膜線, ref this.肛門3CD.c2);
			this.肛門1CD = new ColorD(ref 体配色.粘膜線, ref 体配色.粘膜穴);
		}

		public Par X0Y0_肛門3;

		public Par X0Y0_肛門2;

		public Par X0Y0_肛門1;

		public ColorD 肛門3CD;

		public ColorD 肛門2CD;

		public ColorD 肛門1CD;

		public ColorP X0Y0_肛門3CP;

		public ColorP X0Y0_肛門2CP;

		public ColorP X0Y0_肛門1CP;

		public Ele[] 肛門精液_接続;
	}
}
