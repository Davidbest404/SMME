using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 断面_獣 : 断面
	{
		public 断面_獣(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 断面_獣D e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.半身["四足断面"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_膣基 = pars["膣基"].ToPar();
			this.X0Y0_膣壁左 = pars["膣壁左"].ToPar();
			this.X0Y0_膣壁右 = pars["膣壁右"].ToPar();
			this.X0Y0_卵巣左 = pars["卵巣左"].ToPar();
			this.X0Y0_卵管左 = pars["卵管左"].ToPar();
			this.X0Y0_卵巣右 = pars["卵巣右"].ToPar();
			this.X0Y0_卵管右 = pars["卵管右"].ToPar();
			this.X0Y0_子宮 = pars["子宮"].ToPar();
			this.X0Y0_子宮内 = pars["子宮内"].ToPar();
			this.X0Y0_子宮口 = pars["子宮口"].ToPar();
			this.X0Y0_精液 = pars["精液"].ToPar();
			pars = this.本体[0][1];
			this.X0Y1_膣基 = pars["膣基"].ToPar();
			this.X0Y1_膣壁左 = pars["膣壁左"].ToPar();
			this.X0Y1_膣壁右 = pars["膣壁右"].ToPar();
			this.X0Y1_卵巣左 = pars["卵巣左"].ToPar();
			this.X0Y1_卵管左 = pars["卵管左"].ToPar();
			this.X0Y1_卵巣右 = pars["卵巣右"].ToPar();
			this.X0Y1_卵管右 = pars["卵管右"].ToPar();
			this.X0Y1_子宮 = pars["子宮"].ToPar();
			this.X0Y1_子宮内 = pars["子宮内"].ToPar();
			this.X0Y1_子宮口 = pars["子宮口"].ToPar();
			this.X0Y1_精液 = pars["精液"].ToPar();
			pars = this.本体[0][2];
			this.X0Y2_膣基 = pars["膣基"].ToPar();
			this.X0Y2_膣壁左 = pars["膣壁左"].ToPar();
			this.X0Y2_膣壁右 = pars["膣壁右"].ToPar();
			this.X0Y2_卵巣左 = pars["卵巣左"].ToPar();
			this.X0Y2_卵管左 = pars["卵管左"].ToPar();
			this.X0Y2_卵巣右 = pars["卵巣右"].ToPar();
			this.X0Y2_卵管右 = pars["卵管右"].ToPar();
			this.X0Y2_子宮 = pars["子宮"].ToPar();
			this.X0Y2_子宮内 = pars["子宮内"].ToPar();
			this.X0Y2_子宮口 = pars["子宮口"].ToPar();
			this.X0Y2_精液 = pars["精液"].ToPar();
			pars = this.本体[0][3];
			this.X0Y3_膣基 = pars["膣基"].ToPar();
			this.X0Y3_膣壁左 = pars["膣壁左"].ToPar();
			this.X0Y3_膣壁右 = pars["膣壁右"].ToPar();
			this.X0Y3_卵巣左 = pars["卵巣左"].ToPar();
			this.X0Y3_卵管左 = pars["卵管左"].ToPar();
			this.X0Y3_卵巣右 = pars["卵巣右"].ToPar();
			this.X0Y3_卵管右 = pars["卵管右"].ToPar();
			this.X0Y3_子宮 = pars["子宮"].ToPar();
			this.X0Y3_子宮内 = pars["子宮内"].ToPar();
			this.X0Y3_子宮口 = pars["子宮口"].ToPar();
			this.X0Y3_精液 = pars["精液"].ToPar();
			pars = this.本体[0][4];
			this.X0Y4_膣基 = pars["膣基"].ToPar();
			this.X0Y4_膣壁左 = pars["膣壁左"].ToPar();
			this.X0Y4_膣壁右 = pars["膣壁右"].ToPar();
			this.X0Y4_卵巣左 = pars["卵巣左"].ToPar();
			this.X0Y4_卵管左 = pars["卵管左"].ToPar();
			this.X0Y4_卵巣右 = pars["卵巣右"].ToPar();
			this.X0Y4_卵管右 = pars["卵管右"].ToPar();
			this.X0Y4_子宮 = pars["子宮"].ToPar();
			this.X0Y4_子宮内 = pars["子宮内"].ToPar();
			this.X0Y4_子宮口 = pars["子宮口"].ToPar();
			this.X0Y4_精液 = pars["精液"].ToPar();
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
			this.膣基_表示 = e.膣基_表示;
			this.膣壁左_表示 = e.膣壁左_表示;
			this.膣壁右_表示 = e.膣壁右_表示;
			this.卵巣左_表示 = e.卵巣左_表示;
			this.卵管左_表示 = e.卵管左_表示;
			this.卵巣右_表示 = e.卵巣右_表示;
			this.卵管右_表示 = e.卵管右_表示;
			this.子宮_表示 = e.子宮_表示;
			this.子宮内_表示 = e.子宮内_表示;
			this.子宮口_表示 = e.子宮口_表示;
			this.精液_表示 = e.精液_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_膣基CP = new ColorP(this.X0Y0_膣基, this.膣基CD, DisUnit, true);
			this.X0Y0_膣壁左CP = new ColorP(this.X0Y0_膣壁左, this.膣壁左CD, DisUnit, true);
			this.X0Y0_膣壁右CP = new ColorP(this.X0Y0_膣壁右, this.膣壁右CD, DisUnit, true);
			this.X0Y0_卵巣左CP = new ColorP(this.X0Y0_卵巣左, this.卵巣左CD, DisUnit, true);
			this.X0Y0_卵管左CP = new ColorP(this.X0Y0_卵管左, this.卵管左CD, DisUnit, true);
			this.X0Y0_卵巣右CP = new ColorP(this.X0Y0_卵巣右, this.卵巣右CD, DisUnit, true);
			this.X0Y0_卵管右CP = new ColorP(this.X0Y0_卵管右, this.卵管右CD, DisUnit, true);
			this.X0Y0_子宮CP = new ColorP(this.X0Y0_子宮, this.子宮CD, DisUnit, true);
			this.X0Y0_子宮内CP = new ColorP(this.X0Y0_子宮内, this.子宮内CD, DisUnit, true);
			this.X0Y0_子宮口CP = new ColorP(this.X0Y0_子宮口, this.子宮口CD, DisUnit, true);
			this.X0Y0_精液CP = new ColorP(this.X0Y0_精液, this.精液CD, DisUnit, true);
			this.X0Y1_膣基CP = new ColorP(this.X0Y1_膣基, this.膣基CD, DisUnit, true);
			this.X0Y1_膣壁左CP = new ColorP(this.X0Y1_膣壁左, this.膣壁左CD, DisUnit, true);
			this.X0Y1_膣壁右CP = new ColorP(this.X0Y1_膣壁右, this.膣壁右CD, DisUnit, true);
			this.X0Y1_卵巣左CP = new ColorP(this.X0Y1_卵巣左, this.卵巣左CD, DisUnit, true);
			this.X0Y1_卵管左CP = new ColorP(this.X0Y1_卵管左, this.卵管左CD, DisUnit, true);
			this.X0Y1_卵巣右CP = new ColorP(this.X0Y1_卵巣右, this.卵巣右CD, DisUnit, true);
			this.X0Y1_卵管右CP = new ColorP(this.X0Y1_卵管右, this.卵管右CD, DisUnit, true);
			this.X0Y1_子宮CP = new ColorP(this.X0Y1_子宮, this.子宮CD, DisUnit, true);
			this.X0Y1_子宮内CP = new ColorP(this.X0Y1_子宮内, this.子宮内CD, DisUnit, true);
			this.X0Y1_子宮口CP = new ColorP(this.X0Y1_子宮口, this.子宮口CD, DisUnit, true);
			this.X0Y1_精液CP = new ColorP(this.X0Y1_精液, this.精液CD, DisUnit, true);
			this.X0Y2_膣基CP = new ColorP(this.X0Y2_膣基, this.膣基CD, DisUnit, true);
			this.X0Y2_膣壁左CP = new ColorP(this.X0Y2_膣壁左, this.膣壁左CD, DisUnit, true);
			this.X0Y2_膣壁右CP = new ColorP(this.X0Y2_膣壁右, this.膣壁右CD, DisUnit, true);
			this.X0Y2_卵巣左CP = new ColorP(this.X0Y2_卵巣左, this.卵巣左CD, DisUnit, true);
			this.X0Y2_卵管左CP = new ColorP(this.X0Y2_卵管左, this.卵管左CD, DisUnit, true);
			this.X0Y2_卵巣右CP = new ColorP(this.X0Y2_卵巣右, this.卵巣右CD, DisUnit, true);
			this.X0Y2_卵管右CP = new ColorP(this.X0Y2_卵管右, this.卵管右CD, DisUnit, true);
			this.X0Y2_子宮CP = new ColorP(this.X0Y2_子宮, this.子宮CD, DisUnit, true);
			this.X0Y2_子宮内CP = new ColorP(this.X0Y2_子宮内, this.子宮内CD, DisUnit, true);
			this.X0Y2_子宮口CP = new ColorP(this.X0Y2_子宮口, this.子宮口CD, DisUnit, true);
			this.X0Y2_精液CP = new ColorP(this.X0Y2_精液, this.精液CD, DisUnit, true);
			this.X0Y3_膣基CP = new ColorP(this.X0Y3_膣基, this.膣基CD, DisUnit, true);
			this.X0Y3_膣壁左CP = new ColorP(this.X0Y3_膣壁左, this.膣壁左CD, DisUnit, true);
			this.X0Y3_膣壁右CP = new ColorP(this.X0Y3_膣壁右, this.膣壁右CD, DisUnit, true);
			this.X0Y3_卵巣左CP = new ColorP(this.X0Y3_卵巣左, this.卵巣左CD, DisUnit, true);
			this.X0Y3_卵管左CP = new ColorP(this.X0Y3_卵管左, this.卵管左CD, DisUnit, true);
			this.X0Y3_卵巣右CP = new ColorP(this.X0Y3_卵巣右, this.卵巣右CD, DisUnit, true);
			this.X0Y3_卵管右CP = new ColorP(this.X0Y3_卵管右, this.卵管右CD, DisUnit, true);
			this.X0Y3_子宮CP = new ColorP(this.X0Y3_子宮, this.子宮CD, DisUnit, true);
			this.X0Y3_子宮内CP = new ColorP(this.X0Y3_子宮内, this.子宮内CD, DisUnit, true);
			this.X0Y3_子宮口CP = new ColorP(this.X0Y3_子宮口, this.子宮口CD, DisUnit, true);
			this.X0Y3_精液CP = new ColorP(this.X0Y3_精液, this.精液CD, DisUnit, true);
			this.X0Y4_膣基CP = new ColorP(this.X0Y4_膣基, this.膣基CD, DisUnit, true);
			this.X0Y4_膣壁左CP = new ColorP(this.X0Y4_膣壁左, this.膣壁左CD, DisUnit, true);
			this.X0Y4_膣壁右CP = new ColorP(this.X0Y4_膣壁右, this.膣壁右CD, DisUnit, true);
			this.X0Y4_卵巣左CP = new ColorP(this.X0Y4_卵巣左, this.卵巣左CD, DisUnit, true);
			this.X0Y4_卵管左CP = new ColorP(this.X0Y4_卵管左, this.卵管左CD, DisUnit, true);
			this.X0Y4_卵巣右CP = new ColorP(this.X0Y4_卵巣右, this.卵巣右CD, DisUnit, true);
			this.X0Y4_卵管右CP = new ColorP(this.X0Y4_卵管右, this.卵管右CD, DisUnit, true);
			this.X0Y4_子宮CP = new ColorP(this.X0Y4_子宮, this.子宮CD, DisUnit, true);
			this.X0Y4_子宮内CP = new ColorP(this.X0Y4_子宮内, this.子宮内CD, DisUnit, true);
			this.X0Y4_子宮口CP = new ColorP(this.X0Y4_子宮口, this.子宮口CD, DisUnit, true);
			this.X0Y4_精液CP = new ColorP(this.X0Y4_精液, this.精液CD, DisUnit, true);
			this.濃度 = e.濃度;
			this.精液濃度 = e.精液濃度;
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

		public bool 膣基_表示
		{
			get
			{
				return this.X0Y0_膣基.Dra;
			}
			set
			{
				this.X0Y0_膣基.Dra = value;
				this.X0Y1_膣基.Dra = value;
				this.X0Y2_膣基.Dra = value;
				this.X0Y3_膣基.Dra = value;
				this.X0Y4_膣基.Dra = value;
				this.X0Y0_膣基.Hit = value;
				this.X0Y1_膣基.Hit = value;
				this.X0Y2_膣基.Hit = value;
				this.X0Y3_膣基.Hit = value;
				this.X0Y4_膣基.Hit = value;
			}
		}

		public bool 膣壁左_表示
		{
			get
			{
				return this.X0Y0_膣壁左.Dra;
			}
			set
			{
				this.X0Y0_膣壁左.Dra = value;
				this.X0Y1_膣壁左.Dra = value;
				this.X0Y2_膣壁左.Dra = value;
				this.X0Y3_膣壁左.Dra = value;
				this.X0Y4_膣壁左.Dra = value;
				this.X0Y0_膣壁左.Hit = value;
				this.X0Y1_膣壁左.Hit = value;
				this.X0Y2_膣壁左.Hit = value;
				this.X0Y3_膣壁左.Hit = value;
				this.X0Y4_膣壁左.Hit = value;
			}
		}

		public bool 膣壁右_表示
		{
			get
			{
				return this.X0Y0_膣壁右.Dra;
			}
			set
			{
				this.X0Y0_膣壁右.Dra = value;
				this.X0Y1_膣壁右.Dra = value;
				this.X0Y2_膣壁右.Dra = value;
				this.X0Y3_膣壁右.Dra = value;
				this.X0Y4_膣壁右.Dra = value;
				this.X0Y0_膣壁右.Hit = value;
				this.X0Y1_膣壁右.Hit = value;
				this.X0Y2_膣壁右.Hit = value;
				this.X0Y3_膣壁右.Hit = value;
				this.X0Y4_膣壁右.Hit = value;
			}
		}

		public bool 卵巣左_表示
		{
			get
			{
				return this.X0Y0_卵巣左.Dra;
			}
			set
			{
				this.X0Y0_卵巣左.Dra = value;
				this.X0Y1_卵巣左.Dra = value;
				this.X0Y2_卵巣左.Dra = value;
				this.X0Y3_卵巣左.Dra = value;
				this.X0Y4_卵巣左.Dra = value;
				this.X0Y0_卵巣左.Hit = value;
				this.X0Y1_卵巣左.Hit = value;
				this.X0Y2_卵巣左.Hit = value;
				this.X0Y3_卵巣左.Hit = value;
				this.X0Y4_卵巣左.Hit = value;
			}
		}

		public bool 卵管左_表示
		{
			get
			{
				return this.X0Y0_卵管左.Dra;
			}
			set
			{
				this.X0Y0_卵管左.Dra = value;
				this.X0Y1_卵管左.Dra = value;
				this.X0Y2_卵管左.Dra = value;
				this.X0Y3_卵管左.Dra = value;
				this.X0Y4_卵管左.Dra = value;
				this.X0Y0_卵管左.Hit = value;
				this.X0Y1_卵管左.Hit = value;
				this.X0Y2_卵管左.Hit = value;
				this.X0Y3_卵管左.Hit = value;
				this.X0Y4_卵管左.Hit = value;
			}
		}

		public bool 卵巣右_表示
		{
			get
			{
				return this.X0Y0_卵巣右.Dra;
			}
			set
			{
				this.X0Y0_卵巣右.Dra = value;
				this.X0Y1_卵巣右.Dra = value;
				this.X0Y2_卵巣右.Dra = value;
				this.X0Y3_卵巣右.Dra = value;
				this.X0Y4_卵巣右.Dra = value;
				this.X0Y0_卵巣右.Hit = value;
				this.X0Y1_卵巣右.Hit = value;
				this.X0Y2_卵巣右.Hit = value;
				this.X0Y3_卵巣右.Hit = value;
				this.X0Y4_卵巣右.Hit = value;
			}
		}

		public bool 卵管右_表示
		{
			get
			{
				return this.X0Y0_卵管右.Dra;
			}
			set
			{
				this.X0Y0_卵管右.Dra = value;
				this.X0Y1_卵管右.Dra = value;
				this.X0Y2_卵管右.Dra = value;
				this.X0Y3_卵管右.Dra = value;
				this.X0Y4_卵管右.Dra = value;
				this.X0Y0_卵管右.Hit = value;
				this.X0Y1_卵管右.Hit = value;
				this.X0Y2_卵管右.Hit = value;
				this.X0Y3_卵管右.Hit = value;
				this.X0Y4_卵管右.Hit = value;
			}
		}

		public bool 子宮_表示
		{
			get
			{
				return this.X0Y0_子宮.Dra;
			}
			set
			{
				this.X0Y0_子宮.Dra = value;
				this.X0Y1_子宮.Dra = value;
				this.X0Y2_子宮.Dra = value;
				this.X0Y3_子宮.Dra = value;
				this.X0Y4_子宮.Dra = value;
				this.X0Y0_子宮.Hit = value;
				this.X0Y1_子宮.Hit = value;
				this.X0Y2_子宮.Hit = value;
				this.X0Y3_子宮.Hit = value;
				this.X0Y4_子宮.Hit = value;
			}
		}

		public bool 子宮内_表示
		{
			get
			{
				return this.X0Y0_子宮内.Dra;
			}
			set
			{
				this.X0Y0_子宮内.Dra = value;
				this.X0Y1_子宮内.Dra = value;
				this.X0Y2_子宮内.Dra = value;
				this.X0Y3_子宮内.Dra = value;
				this.X0Y4_子宮内.Dra = value;
				this.X0Y0_子宮内.Hit = value;
				this.X0Y1_子宮内.Hit = value;
				this.X0Y2_子宮内.Hit = value;
				this.X0Y3_子宮内.Hit = value;
				this.X0Y4_子宮内.Hit = value;
			}
		}

		public bool 子宮口_表示
		{
			get
			{
				return this.X0Y0_子宮口.Dra;
			}
			set
			{
				this.X0Y0_子宮口.Dra = value;
				this.X0Y1_子宮口.Dra = value;
				this.X0Y2_子宮口.Dra = value;
				this.X0Y3_子宮口.Dra = value;
				this.X0Y4_子宮口.Dra = value;
				this.X0Y0_子宮口.Hit = value;
				this.X0Y1_子宮口.Hit = value;
				this.X0Y2_子宮口.Hit = value;
				this.X0Y3_子宮口.Hit = value;
				this.X0Y4_子宮口.Hit = value;
			}
		}

		public bool 精液_表示
		{
			get
			{
				return this.X0Y0_精液.Dra;
			}
			set
			{
				this.X0Y0_精液.Dra = value;
				this.X0Y1_精液.Dra = value;
				this.X0Y2_精液.Dra = value;
				this.X0Y3_精液.Dra = value;
				this.X0Y4_精液.Dra = value;
				this.X0Y0_精液.Hit = value;
				this.X0Y1_精液.Hit = value;
				this.X0Y2_精液.Hit = value;
				this.X0Y3_精液.Hit = value;
				this.X0Y4_精液.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.膣基_表示;
			}
			set
			{
				this.膣基_表示 = value;
				this.膣壁左_表示 = value;
				this.膣壁右_表示 = value;
				this.卵巣左_表示 = value;
				this.卵管左_表示 = value;
				this.卵巣右_表示 = value;
				this.卵管右_表示 = value;
				this.子宮_表示 = value;
				this.子宮内_表示 = value;
				this.子宮口_表示 = value;
				this.精液_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.膣基CD.不透明度;
			}
			set
			{
				this.膣基CD.不透明度 = value;
				this.膣壁左CD.不透明度 = value;
				this.膣壁右CD.不透明度 = value;
				this.卵巣左CD.不透明度 = value;
				this.卵管左CD.不透明度 = value;
				this.卵巣右CD.不透明度 = value;
				this.卵管右CD.不透明度 = value;
				this.子宮CD.不透明度 = value;
				this.子宮内CD.不透明度 = value;
				this.子宮口CD.不透明度 = value;
				this.精液CD.不透明度 = value;
			}
		}

		public override double 精液濃度
		{
			get
			{
				return this.精液CD.不透明度;
			}
			set
			{
				this.精液CD.不透明度 = value;
			}
		}

		public override double 膣サイズY
		{
			get
			{
				return this.X0Y0_膣基.SizeYCont;
			}
			set
			{
				this.X0Y0_膣基.SizeYCont = value;
				this.X0Y0_膣壁左.SizeYCont = value;
				this.X0Y0_膣壁右.SizeYCont = value;
				this.X0Y1_膣基.SizeYCont = value;
				this.X0Y1_膣壁左.SizeYCont = value;
				this.X0Y1_膣壁右.SizeYCont = value;
				this.X0Y2_膣基.SizeYCont = value;
				this.X0Y2_膣壁左.SizeYCont = value;
				this.X0Y2_膣壁右.SizeYCont = value;
				this.X0Y3_膣基.SizeYCont = value;
				this.X0Y3_膣壁左.SizeYCont = value;
				this.X0Y3_膣壁右.SizeYCont = value;
				this.X0Y4_膣基.SizeYCont = value;
				this.X0Y4_膣壁左.SizeYCont = value;
				this.X0Y4_膣壁右.SizeYCont = value;
				double sizeYCont = value.Reciprocal();
				this.X0Y0_子宮.SizeYCont = sizeYCont;
				this.X0Y0_子宮内.SizeYCont = sizeYCont;
				this.X0Y0_子宮口.SizeYCont = sizeYCont;
				this.X0Y0_精液.SizeYCont = sizeYCont;
				this.X0Y1_子宮.SizeYCont = sizeYCont;
				this.X0Y1_子宮内.SizeYCont = sizeYCont;
				this.X0Y1_子宮口.SizeYCont = sizeYCont;
				this.X0Y1_精液.SizeYCont = sizeYCont;
				this.X0Y2_子宮.SizeYCont = sizeYCont;
				this.X0Y2_子宮内.SizeYCont = sizeYCont;
				this.X0Y2_子宮口.SizeYCont = sizeYCont;
				this.X0Y2_精液.SizeYCont = sizeYCont;
				this.X0Y3_子宮.SizeYCont = sizeYCont;
				this.X0Y3_子宮内.SizeYCont = sizeYCont;
				this.X0Y3_子宮口.SizeYCont = sizeYCont;
				this.X0Y3_精液.SizeYCont = sizeYCont;
				this.X0Y4_子宮.SizeYCont = sizeYCont;
				this.X0Y4_子宮内.SizeYCont = sizeYCont;
				this.X0Y4_子宮口.SizeYCont = sizeYCont;
				this.X0Y4_精液.SizeYCont = sizeYCont;
			}
		}

		public override void 色更新()
		{
			switch (this.本体.IndexY)
			{
			case 0:
				this.X0Y0_膣基CP.Update();
				this.X0Y0_膣壁左CP.Update();
				this.X0Y0_膣壁右CP.Update();
				this.X0Y0_卵巣左CP.Update();
				this.X0Y0_卵管左CP.Update();
				this.X0Y0_卵巣右CP.Update();
				this.X0Y0_卵管右CP.Update();
				this.X0Y0_子宮CP.Update();
				this.X0Y0_子宮内CP.Update();
				this.X0Y0_子宮口CP.Update();
				this.X0Y0_精液CP.Update();
				return;
			case 1:
				this.X0Y1_膣基CP.Update();
				this.X0Y1_膣壁左CP.Update();
				this.X0Y1_膣壁右CP.Update();
				this.X0Y1_卵巣左CP.Update();
				this.X0Y1_卵管左CP.Update();
				this.X0Y1_卵巣右CP.Update();
				this.X0Y1_卵管右CP.Update();
				this.X0Y1_子宮CP.Update();
				this.X0Y1_子宮内CP.Update();
				this.X0Y1_子宮口CP.Update();
				this.X0Y1_精液CP.Update();
				return;
			case 2:
				this.X0Y2_膣基CP.Update();
				this.X0Y2_膣壁左CP.Update();
				this.X0Y2_膣壁右CP.Update();
				this.X0Y2_卵巣左CP.Update();
				this.X0Y2_卵管左CP.Update();
				this.X0Y2_卵巣右CP.Update();
				this.X0Y2_卵管右CP.Update();
				this.X0Y2_子宮CP.Update();
				this.X0Y2_子宮内CP.Update();
				this.X0Y2_子宮口CP.Update();
				this.X0Y2_精液CP.Update();
				return;
			case 3:
				this.X0Y3_膣基CP.Update();
				this.X0Y3_膣壁左CP.Update();
				this.X0Y3_膣壁右CP.Update();
				this.X0Y3_卵巣左CP.Update();
				this.X0Y3_卵管左CP.Update();
				this.X0Y3_卵巣右CP.Update();
				this.X0Y3_卵管右CP.Update();
				this.X0Y3_子宮CP.Update();
				this.X0Y3_子宮内CP.Update();
				this.X0Y3_子宮口CP.Update();
				this.X0Y3_精液CP.Update();
				return;
			default:
				this.X0Y4_膣基CP.Update();
				this.X0Y4_膣壁左CP.Update();
				this.X0Y4_膣壁右CP.Update();
				this.X0Y4_卵巣左CP.Update();
				this.X0Y4_卵管左CP.Update();
				this.X0Y4_卵巣右CP.Update();
				this.X0Y4_卵管右CP.Update();
				this.X0Y4_子宮CP.Update();
				this.X0Y4_子宮内CP.Update();
				this.X0Y4_子宮口CP.Update();
				this.X0Y4_精液CP.Update();
				return;
			}
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.膣基CD = new ColorD(ref Col.Empty, ref Color2.Empty);
			Color2 color;
			Col.Alpha(ref 体配色.粘膜, 160, out color);
			this.膣壁左CD = new ColorD(ref 体配色.粘膜線, ref color);
			this.膣壁右CD = new ColorD(ref 体配色.粘膜線, ref this.膣壁左CD.c2);
			this.卵巣左CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.卵管左CD = new ColorD(ref 体配色.粘膜線, ref this.膣壁左CD.c2);
			this.卵巣右CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.卵管右CD = new ColorD(ref 体配色.粘膜線, ref this.膣壁左CD.c2);
			this.子宮CD = new ColorD(ref 体配色.粘膜線, ref this.膣壁左CD.c2);
			this.子宮内CD = new ColorD(ref 体配色.粘膜線, ref this.膣壁左CD.c2);
			this.子宮口CD = new ColorD(ref 体配色.粘膜線, ref this.膣壁左CD.c2);
			this.精液CD = new ColorD();
		}

		public void 精液配色(主人公配色 配色)
		{
			this.精液CD.線 = 配色.精線;
			this.精液CD.色 = 配色.精液ぶっかけ;
			this.X0Y0_精液CP.Setting();
			this.X0Y1_精液CP.Setting();
			this.X0Y2_精液CP.Setting();
			this.X0Y3_精液CP.Setting();
			this.X0Y4_精液CP.Setting();
		}

		public Par X0Y0_膣基;

		public Par X0Y0_膣壁左;

		public Par X0Y0_膣壁右;

		public Par X0Y0_卵巣左;

		public Par X0Y0_卵管左;

		public Par X0Y0_卵巣右;

		public Par X0Y0_卵管右;

		public Par X0Y0_子宮;

		public Par X0Y0_子宮内;

		public Par X0Y0_子宮口;

		public Par X0Y0_精液;

		public Par X0Y1_膣基;

		public Par X0Y1_膣壁左;

		public Par X0Y1_膣壁右;

		public Par X0Y1_卵巣左;

		public Par X0Y1_卵管左;

		public Par X0Y1_卵巣右;

		public Par X0Y1_卵管右;

		public Par X0Y1_子宮;

		public Par X0Y1_子宮内;

		public Par X0Y1_子宮口;

		public Par X0Y1_精液;

		public Par X0Y2_膣基;

		public Par X0Y2_膣壁左;

		public Par X0Y2_膣壁右;

		public Par X0Y2_卵巣左;

		public Par X0Y2_卵管左;

		public Par X0Y2_卵巣右;

		public Par X0Y2_卵管右;

		public Par X0Y2_子宮;

		public Par X0Y2_子宮内;

		public Par X0Y2_子宮口;

		public Par X0Y2_精液;

		public Par X0Y3_膣基;

		public Par X0Y3_膣壁左;

		public Par X0Y3_膣壁右;

		public Par X0Y3_卵巣左;

		public Par X0Y3_卵管左;

		public Par X0Y3_卵巣右;

		public Par X0Y3_卵管右;

		public Par X0Y3_子宮;

		public Par X0Y3_子宮内;

		public Par X0Y3_子宮口;

		public Par X0Y3_精液;

		public Par X0Y4_膣基;

		public Par X0Y4_膣壁左;

		public Par X0Y4_膣壁右;

		public Par X0Y4_卵巣左;

		public Par X0Y4_卵管左;

		public Par X0Y4_卵巣右;

		public Par X0Y4_卵管右;

		public Par X0Y4_子宮;

		public Par X0Y4_子宮内;

		public Par X0Y4_子宮口;

		public Par X0Y4_精液;

		public ColorD 膣基CD;

		public ColorD 膣壁左CD;

		public ColorD 膣壁右CD;

		public ColorD 卵巣左CD;

		public ColorD 卵管左CD;

		public ColorD 卵巣右CD;

		public ColorD 卵管右CD;

		public ColorD 子宮CD;

		public ColorD 子宮内CD;

		public ColorD 子宮口CD;

		public ColorD 精液CD;

		public ColorP X0Y0_膣基CP;

		public ColorP X0Y0_膣壁左CP;

		public ColorP X0Y0_膣壁右CP;

		public ColorP X0Y0_卵巣左CP;

		public ColorP X0Y0_卵管左CP;

		public ColorP X0Y0_卵巣右CP;

		public ColorP X0Y0_卵管右CP;

		public ColorP X0Y0_子宮CP;

		public ColorP X0Y0_子宮内CP;

		public ColorP X0Y0_子宮口CP;

		public ColorP X0Y0_精液CP;

		public ColorP X0Y1_膣基CP;

		public ColorP X0Y1_膣壁左CP;

		public ColorP X0Y1_膣壁右CP;

		public ColorP X0Y1_卵巣左CP;

		public ColorP X0Y1_卵管左CP;

		public ColorP X0Y1_卵巣右CP;

		public ColorP X0Y1_卵管右CP;

		public ColorP X0Y1_子宮CP;

		public ColorP X0Y1_子宮内CP;

		public ColorP X0Y1_子宮口CP;

		public ColorP X0Y1_精液CP;

		public ColorP X0Y2_膣基CP;

		public ColorP X0Y2_膣壁左CP;

		public ColorP X0Y2_膣壁右CP;

		public ColorP X0Y2_卵巣左CP;

		public ColorP X0Y2_卵管左CP;

		public ColorP X0Y2_卵巣右CP;

		public ColorP X0Y2_卵管右CP;

		public ColorP X0Y2_子宮CP;

		public ColorP X0Y2_子宮内CP;

		public ColorP X0Y2_子宮口CP;

		public ColorP X0Y2_精液CP;

		public ColorP X0Y3_膣基CP;

		public ColorP X0Y3_膣壁左CP;

		public ColorP X0Y3_膣壁右CP;

		public ColorP X0Y3_卵巣左CP;

		public ColorP X0Y3_卵管左CP;

		public ColorP X0Y3_卵巣右CP;

		public ColorP X0Y3_卵管右CP;

		public ColorP X0Y3_子宮CP;

		public ColorP X0Y3_子宮内CP;

		public ColorP X0Y3_子宮口CP;

		public ColorP X0Y3_精液CP;

		public ColorP X0Y4_膣基CP;

		public ColorP X0Y4_膣壁左CP;

		public ColorP X0Y4_膣壁右CP;

		public ColorP X0Y4_卵巣左CP;

		public ColorP X0Y4_卵管左CP;

		public ColorP X0Y4_卵巣右CP;

		public ColorP X0Y4_卵管右CP;

		public ColorP X0Y4_子宮CP;

		public ColorP X0Y4_子宮内CP;

		public ColorP X0Y4_子宮口CP;

		public ColorP X0Y4_精液CP;
	}
}
