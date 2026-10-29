using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 飛膜_先 : Ele
	{
		public 飛膜_先(double DisUnit, 配色指定 配色指定, 体配色 体配色)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.腕左["飛膜先"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_飛膜 = pars["飛膜"].ToPar();
			pars = this.本体[0][1];
			this.X0Y1_飛膜 = pars["飛膜"].ToPar();
			this.Xasix = false;
			this.本体.SetJoints();
			this.接続根 = new JointD(this.本体);
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_飛膜CP = new ColorP(this.X0Y0_飛膜, this.飛膜CD, DisUnit, true);
			this.X0Y1_飛膜CP = new ColorP(this.X0Y1_飛膜, this.飛膜CD, DisUnit, true);
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

		public bool 飛膜_表示
		{
			get
			{
				return this.X0Y0_飛膜.Dra;
			}
			set
			{
				this.X0Y0_飛膜.Dra = value;
				this.X0Y1_飛膜.Dra = value;
				this.X0Y0_飛膜.Hit = value;
				this.X0Y1_飛膜.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.飛膜_表示;
			}
			set
			{
				this.飛膜_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.飛膜CD.不透明度;
			}
			set
			{
				this.飛膜CD.不透明度 = value;
			}
		}

		public void 接続(上腕_蝙 上腕, 下腕_蝙 下腕, 手_蝙 手, bool カ\u30FCブ)
		{
			if (this.本体.IndexY == 0)
			{
				if (this.右 || this.反転X_ || this.反転Y_)
				{
					this.通常接続右(上腕, 下腕, 手, カ\u30FCブ);
					return;
				}
				this.通常接続左(上腕, 下腕, 手, カ\u30FCブ);
				return;
			}
			else
			{
				if (this.右 || this.反転X_ || this.反転Y_)
				{
					this.欠損接続右(上腕, 下腕, 手, カ\u30FCブ);
					return;
				}
				this.欠損接続左(上腕, 下腕, 手, カ\u30FCブ);
				return;
			}
		}

		private void 通常接続左(上腕_蝙 上腕, 下腕_蝙 下腕, 手_蝙 手, bool カ\u30FCブ)
		{
			Vector2D value = this.X0Y0_飛膜.ToLocal(手.X0Y0_人指_指3.Position);
			Vector2D left = this.X0Y0_飛膜.ToLocal(手.X0Y0_親指_指1.Position);
			this.X0Y0_飛膜.OP[0].ps[0] = value;
			this.X0Y0_飛膜.OP[0].ps[2] = this.X0Y0_飛膜.ToLocal(手.X0Y0_人指_指2.Position);
			this.X0Y0_飛膜.OP[0].ps[1] = (this.X0Y0_飛膜.OP[0].ps[0] + this.X0Y0_飛膜.OP[0].ps[2]) * 0.5;
			this.X0Y0_飛膜.OP[1].ps[0] = this.X0Y0_飛膜.OP[0].ps[2];
			this.X0Y0_飛膜.OP[1].ps[2] = this.X0Y0_飛膜.ToLocal(手.X0Y0_親指_指2.Position);
			this.X0Y0_飛膜.OP[1].ps[1] = (this.X0Y0_飛膜.OP[1].ps[0] + this.X0Y0_飛膜.OP[1].ps[2]) * 0.5;
			List<Vector2D> ps = this.X0Y0_飛膜.OP[1].ps;
			ps[1] = ps[1] + (left - this.X0Y0_飛膜.OP[1].ps[1]) * 0.3;
			this.X0Y0_飛膜.OP[2].ps[0] = this.X0Y0_飛膜.OP[1].ps[2];
			if (上腕 == null)
			{
				if (下腕 == null)
				{
					this.X0Y0_飛膜.OP[2].ps[3] = this.X0Y0_飛膜.ToLocal(手.X0Y0_獣翼手.Position);
				}
				else
				{
					this.X0Y0_飛膜.OP[2].ps[3] = this.X0Y0_飛膜.ToLocal(下腕.X0Y0_獣翼下腕.Position);
				}
				Vector2D left2 = (this.X0Y0_飛膜.OP[2].ps[0] + this.X0Y0_飛膜.OP[2].ps[3]) * 0.5;
				this.X0Y0_飛膜.OP[2].ps[1] = left2 + (this.X0Y0_飛膜.OP[2].ps[0] - this.X0Y0_飛膜.OP[2].ps[3]) * 0.8;
				this.X0Y0_飛膜.OP[2].ps[2] = left2 + (this.X0Y0_飛膜.OP[2].ps[0] - this.X0Y0_飛膜.OP[2].ps[3]) * 0.4;
				ps = this.X0Y0_飛膜.OP[2].ps;
				ps[1] = ps[1] + (left - this.X0Y0_飛膜.OP[2].ps[1]) * 0.3;
				ps = this.X0Y0_飛膜.OP[2].ps;
				ps[2] = ps[2] + (left - this.X0Y0_飛膜.OP[2].ps[2]) * 0.3;
			}
			else
			{
				if (上腕.接続情報 == 接続情報.肩_上腕_接続)
				{
					this.X0Y0_飛膜.OP[2].ps[3] = this.X0Y0_飛膜.ToLocal(上腕.X0Y0_獣翼上腕.ToGlobal(上腕.X0Y0_獣翼上腕.OP[3].ps[1]));
				}
				else
				{
					this.X0Y0_飛膜.OP[2].ps[3] = this.X0Y0_飛膜.ToLocal(上腕.X0Y0_獣翼上腕.ToGlobal(上腕.X0Y0_獣翼上腕.OP[3].ps[1].AddY(0.003)));
				}
				Vector2D vector2D = (this.X0Y0_飛膜.OP[2].ps[0] + this.X0Y0_飛膜.OP[2].ps[3]) * 0.5;
				this.X0Y0_飛膜.OP[2].ps[1] = (this.X0Y0_飛膜.OP[2].ps[0] + vector2D) * 0.5;
				this.X0Y0_飛膜.OP[2].ps[2] = (vector2D + this.X0Y0_飛膜.OP[2].ps[3]) * 0.5;
			}
			if (下腕 == null)
			{
				Vector2D left3 = this.X0Y0_飛膜.ToLocal(手.X0Y0_獣翼手.Position);
				ps = this.X0Y0_飛膜.OP[2].ps;
				ps[1] = ps[1] + (left3 - this.X0Y0_飛膜.OP[2].ps[1]) * 0.3;
				ps = this.X0Y0_飛膜.OP[2].ps;
				ps[2] = ps[2] + (left3 - this.X0Y0_飛膜.OP[2].ps[2]) * 0.3;
			}
			else
			{
				Vector2D left4 = this.X0Y0_飛膜.ToLocal(下腕.X0Y0_獣翼下腕.Position);
				ps = this.X0Y0_飛膜.OP[2].ps;
				ps[1] = ps[1] + (left4 - this.X0Y0_飛膜.OP[2].ps[1]) * 0.3;
				ps = this.X0Y0_飛膜.OP[2].ps;
				ps[2] = ps[2] + (left4 - this.X0Y0_飛膜.OP[2].ps[2]) * 0.3;
			}
			if (上腕.接続情報 != 接続情報.肩_上腕_接続)
			{
				this.X0Y0_飛膜.OP[3].ps[0] = this.X0Y0_飛膜.OP[2].ps[3];
			}
			else
			{
				this.X0Y0_飛膜.OP[3].ps[0] = this.X0Y0_飛膜.OP[2].ps[3].AddY(0.05);
			}
			this.X0Y0_飛膜.OP[3].ps[2] = this.X0Y0_飛膜.ToLocal(手.X0Y0_小指_指3.ToGlobal(手.X0Y0_小指_指3.OP[0].ps[0]));
			this.X0Y0_飛膜.OP[3].ps[1] = (this.X0Y0_飛膜.OP[3].ps[0] + this.X0Y0_飛膜.OP[3].ps[2]) * 0.5;
			ps = this.X0Y0_飛膜.OP[3].ps;
			ps[1] = ps[1] + (this.X0Y0_飛膜.ToLocal(手.X0Y0_人指_指1.Position) - this.X0Y0_飛膜.OP[3].ps[1]) * 0.07;
			if (カ\u30FCブ)
			{
				this.X0Y0_飛膜.OP[3].ps[1] = (this.X0Y0_飛膜.OP[3].ps[0] + this.X0Y0_飛膜.OP[3].ps[2]) * 0.5;
				ps = this.X0Y0_飛膜.OP[3].ps;
				ps[1] = ps[1] + (this.X0Y0_飛膜.ToLocal(手.X0Y0_小指_指1.ToGlobal(手.X0Y0_小指_指1.JP[0].Joint)) - this.X0Y0_飛膜.OP[3].ps[1]) * 0.4;
			}
			this.X0Y0_飛膜.OP[4].ps[0] = this.X0Y0_飛膜.OP[3].ps[2];
			this.X0Y0_飛膜.OP[4].ps[2] = this.X0Y0_飛膜.ToLocal(手.X0Y0_薬指_指3.ToGlobal(手.X0Y0_薬指_指3.OP[0].ps[0]));
			this.X0Y0_飛膜.OP[4].ps[1] = (this.X0Y0_飛膜.OP[4].ps[0] + this.X0Y0_飛膜.OP[4].ps[2]) * 0.5;
			ps = this.X0Y0_飛膜.OP[4].ps;
			ps[1] = ps[1] + (this.X0Y0_飛膜.ToLocal(手.X0Y0_薬指_指1.Position) - this.X0Y0_飛膜.OP[4].ps[1]) * 0.08;
			this.X0Y0_飛膜.OP[5].ps[0] = this.X0Y0_飛膜.OP[4].ps[2];
			this.X0Y0_飛膜.OP[5].ps[2] = this.X0Y0_飛膜.ToLocal(手.X0Y0_中指_指3.ToGlobal(手.X0Y0_中指_指3.OP[0].ps[0]));
			this.X0Y0_飛膜.OP[5].ps[1] = (this.X0Y0_飛膜.OP[5].ps[0] + this.X0Y0_飛膜.OP[5].ps[2]) * 0.5;
			ps = this.X0Y0_飛膜.OP[5].ps;
			ps[1] = ps[1] + (this.X0Y0_飛膜.ToLocal(手.X0Y0_中指_指1.Position) - this.X0Y0_飛膜.OP[5].ps[1]) * 0.07;
			this.X0Y0_飛膜.OP[6].ps[0] = this.X0Y0_飛膜.OP[5].ps[2];
			this.X0Y0_飛膜.OP[6].ps[2] = this.X0Y0_飛膜.ToLocal(手.X0Y0_中指_指3.Position);
			this.X0Y0_飛膜.OP[6].ps[1] = this.X0Y0_飛膜.ToLocal(手.X0Y0_中指_指3.ToGlobal(手.X0Y0_中指_指3.OP[0].ps[1]));
			this.X0Y0_飛膜.OP[7].ps[0] = this.X0Y0_飛膜.OP[6].ps[2];
			this.X0Y0_飛膜.OP[7].ps[2] = this.X0Y0_飛膜.ToLocal(手.X0Y0_人指_指3.ToGlobal(手.X0Y0_人指_指3.OP[0].ps[0]));
			this.X0Y0_飛膜.OP[7].ps[1] = (this.X0Y0_飛膜.OP[7].ps[0] + this.X0Y0_飛膜.OP[7].ps[2]) * 0.5;
			ps = this.X0Y0_飛膜.OP[7].ps;
			ps[1] = ps[1] + (this.X0Y0_飛膜.ToLocal(手.X0Y0_人指_指1.Position) - this.X0Y0_飛膜.OP[7].ps[1]) * 0.08;
			this.X0Y0_飛膜.OP[8].ps[0] = this.X0Y0_飛膜.OP[7].ps[2];
			this.X0Y0_飛膜.OP[8].ps[2] = value;
			this.X0Y0_飛膜.OP[8].ps[1] = this.X0Y0_飛膜.ToLocal(手.X0Y0_人指_指3.ToGlobal(手.X0Y0_人指_指3.OP[0].ps[1]));
		}

		private void 通常接続右(上腕_蝙 上腕, 下腕_蝙 下腕, 手_蝙 手, bool カ\u30FCブ)
		{
			Vector2D value = this.X0Y0_飛膜.ToLocal(手.X0Y0_人指_指3.Position);
			Vector2D left = this.X0Y0_飛膜.ToLocal(手.X0Y0_親指_指1.Position);
			this.X0Y0_飛膜.OP[8].ps[2] = value;
			this.X0Y0_飛膜.OP[8].ps[0] = this.X0Y0_飛膜.ToLocal(手.X0Y0_人指_指2.Position);
			this.X0Y0_飛膜.OP[8].ps[1] = (this.X0Y0_飛膜.OP[8].ps[2] + this.X0Y0_飛膜.OP[8].ps[0]) * 0.5;
			this.X0Y0_飛膜.OP[7].ps[2] = this.X0Y0_飛膜.OP[8].ps[0];
			this.X0Y0_飛膜.OP[7].ps[0] = this.X0Y0_飛膜.ToLocal(手.X0Y0_親指_指2.Position);
			this.X0Y0_飛膜.OP[7].ps[1] = (this.X0Y0_飛膜.OP[7].ps[2] + this.X0Y0_飛膜.OP[7].ps[0]) * 0.5;
			List<Vector2D> ps = this.X0Y0_飛膜.OP[7].ps;
			ps[1] = ps[1] + (left - this.X0Y0_飛膜.OP[7].ps[1]) * 0.3;
			this.X0Y0_飛膜.OP[6].ps[3] = this.X0Y0_飛膜.OP[7].ps[0];
			if (上腕 == null)
			{
				if (下腕 == null)
				{
					this.X0Y0_飛膜.OP[6].ps[0] = this.X0Y0_飛膜.ToLocal(手.X0Y0_獣翼手.Position);
				}
				else
				{
					this.X0Y0_飛膜.OP[6].ps[0] = this.X0Y0_飛膜.ToLocal(下腕.X0Y0_獣翼下腕.Position);
				}
				Vector2D left2 = (this.X0Y0_飛膜.OP[6].ps[3] + this.X0Y0_飛膜.OP[6].ps[0]) * 0.5;
				this.X0Y0_飛膜.OP[6].ps[2] = left2 + (this.X0Y0_飛膜.OP[6].ps[3] - this.X0Y0_飛膜.OP[6].ps[0]) * 0.8;
				this.X0Y0_飛膜.OP[6].ps[1] = left2 + (this.X0Y0_飛膜.OP[6].ps[3] - this.X0Y0_飛膜.OP[6].ps[0]) * 0.4;
				ps = this.X0Y0_飛膜.OP[6].ps;
				ps[2] = ps[2] + (left - this.X0Y0_飛膜.OP[6].ps[2]) * 0.3;
				ps = this.X0Y0_飛膜.OP[6].ps;
				ps[1] = ps[1] + (left - this.X0Y0_飛膜.OP[6].ps[1]) * 0.3;
			}
			else
			{
				if (上腕.接続情報 == 接続情報.肩_上腕_接続)
				{
					this.X0Y0_飛膜.OP[6].ps[0] = this.X0Y0_飛膜.ToLocal(上腕.X0Y0_獣翼上腕.ToGlobal(上腕.X0Y0_獣翼上腕.OP[0].ps[4]));
				}
				else
				{
					this.X0Y0_飛膜.OP[6].ps[0] = this.X0Y0_飛膜.ToLocal(上腕.X0Y0_獣翼上腕.ToGlobal(上腕.X0Y0_獣翼上腕.OP[0].ps[4].AddY(0.003)));
				}
				Vector2D vector2D = (this.X0Y0_飛膜.OP[6].ps[3] + this.X0Y0_飛膜.OP[6].ps[0]) * 0.5;
				this.X0Y0_飛膜.OP[6].ps[2] = (this.X0Y0_飛膜.OP[6].ps[3] + vector2D) * 0.5;
				this.X0Y0_飛膜.OP[6].ps[1] = (vector2D + this.X0Y0_飛膜.OP[6].ps[0]) * 0.5;
			}
			if (下腕 == null)
			{
				Vector2D left3 = this.X0Y0_飛膜.ToLocal(手.X0Y0_獣翼手.Position);
				ps = this.X0Y0_飛膜.OP[6].ps;
				ps[2] = ps[2] + (left3 - this.X0Y0_飛膜.OP[6].ps[2]) * 0.3;
				ps = this.X0Y0_飛膜.OP[6].ps;
				ps[1] = ps[1] + (left3 - this.X0Y0_飛膜.OP[6].ps[1]) * 0.3;
			}
			else
			{
				Vector2D left4 = this.X0Y0_飛膜.ToLocal(下腕.X0Y0_獣翼下腕.Position);
				ps = this.X0Y0_飛膜.OP[6].ps;
				ps[2] = ps[2] + (left4 - this.X0Y0_飛膜.OP[6].ps[2]) * 0.3;
				ps = this.X0Y0_飛膜.OP[6].ps;
				ps[1] = ps[1] + (left4 - this.X0Y0_飛膜.OP[6].ps[1]) * 0.3;
			}
			if (上腕.接続情報 != 接続情報.肩_上腕_接続)
			{
				this.X0Y0_飛膜.OP[5].ps[2] = this.X0Y0_飛膜.OP[6].ps[0];
			}
			else
			{
				this.X0Y0_飛膜.OP[5].ps[2] = this.X0Y0_飛膜.OP[6].ps[0].AddY(0.05);
			}
			this.X0Y0_飛膜.OP[5].ps[0] = this.X0Y0_飛膜.ToLocal(手.X0Y0_小指_指3.ToGlobal(手.X0Y0_小指_指3.OP[2].ps[2]));
			this.X0Y0_飛膜.OP[5].ps[1] = (this.X0Y0_飛膜.OP[5].ps[2] + this.X0Y0_飛膜.OP[5].ps[0]) * 0.5;
			ps = this.X0Y0_飛膜.OP[5].ps;
			ps[1] = ps[1] + (this.X0Y0_飛膜.ToLocal(手.X0Y0_人指_指1.Position) - this.X0Y0_飛膜.OP[5].ps[1]) * 0.07;
			if (カ\u30FCブ)
			{
				this.X0Y0_飛膜.OP[5].ps[1] = (this.X0Y0_飛膜.OP[5].ps[2] + this.X0Y0_飛膜.OP[5].ps[0]) * 0.5;
				ps = this.X0Y0_飛膜.OP[5].ps;
				ps[1] = ps[1] + (this.X0Y0_飛膜.ToLocal(手.X0Y0_小指_指1.ToGlobal(手.X0Y0_小指_指1.JP[0].Joint)) - this.X0Y0_飛膜.OP[5].ps[1]) * 0.4;
			}
			this.X0Y0_飛膜.OP[4].ps[2] = this.X0Y0_飛膜.OP[5].ps[0];
			this.X0Y0_飛膜.OP[4].ps[0] = this.X0Y0_飛膜.ToLocal(手.X0Y0_薬指_指3.ToGlobal(手.X0Y0_薬指_指3.OP[2].ps[2]));
			this.X0Y0_飛膜.OP[4].ps[1] = (this.X0Y0_飛膜.OP[4].ps[2] + this.X0Y0_飛膜.OP[4].ps[0]) * 0.5;
			ps = this.X0Y0_飛膜.OP[4].ps;
			ps[1] = ps[1] + (this.X0Y0_飛膜.ToLocal(手.X0Y0_薬指_指1.Position) - this.X0Y0_飛膜.OP[4].ps[1]) * 0.08;
			this.X0Y0_飛膜.OP[3].ps[2] = this.X0Y0_飛膜.OP[4].ps[0];
			this.X0Y0_飛膜.OP[3].ps[0] = this.X0Y0_飛膜.ToLocal(手.X0Y0_中指_指3.ToGlobal(手.X0Y0_中指_指3.OP[2].ps[2]));
			this.X0Y0_飛膜.OP[3].ps[1] = (this.X0Y0_飛膜.OP[3].ps[2] + this.X0Y0_飛膜.OP[3].ps[0]) * 0.5;
			ps = this.X0Y0_飛膜.OP[3].ps;
			ps[1] = ps[1] + (this.X0Y0_飛膜.ToLocal(手.X0Y0_中指_指1.Position) - this.X0Y0_飛膜.OP[3].ps[1]) * 0.07;
			this.X0Y0_飛膜.OP[2].ps[2] = this.X0Y0_飛膜.OP[3].ps[0];
			this.X0Y0_飛膜.OP[2].ps[0] = this.X0Y0_飛膜.ToLocal(手.X0Y0_中指_指3.Position);
			this.X0Y0_飛膜.OP[2].ps[1] = this.X0Y0_飛膜.ToLocal(手.X0Y0_中指_指3.ToGlobal(手.X0Y0_中指_指3.OP[2].ps[1]));
			this.X0Y0_飛膜.OP[1].ps[2] = this.X0Y0_飛膜.OP[2].ps[0];
			this.X0Y0_飛膜.OP[1].ps[0] = this.X0Y0_飛膜.ToLocal(手.X0Y0_人指_指3.ToGlobal(手.X0Y0_人指_指3.OP[2].ps[2]));
			this.X0Y0_飛膜.OP[1].ps[1] = (this.X0Y0_飛膜.OP[1].ps[2] + this.X0Y0_飛膜.OP[1].ps[0]) * 0.5;
			ps = this.X0Y0_飛膜.OP[1].ps;
			ps[1] = ps[1] + (this.X0Y0_飛膜.ToLocal(手.X0Y0_人指_指1.Position) - this.X0Y0_飛膜.OP[1].ps[1]) * 0.08;
			this.X0Y0_飛膜.OP[0].ps[2] = this.X0Y0_飛膜.OP[1].ps[0];
			this.X0Y0_飛膜.OP[0].ps[0] = value;
			this.X0Y0_飛膜.OP[0].ps[1] = this.X0Y0_飛膜.ToLocal(手.X0Y0_人指_指3.ToGlobal(手.X0Y0_人指_指3.OP[2].ps[1]));
		}

		private void 欠損接続左(上腕_蝙 上腕, 下腕_蝙 下腕, 手_蝙 手, bool カ\u30FCブ)
		{
			Vector2D value = this.X0Y1_飛膜.ToLocal(手.X0Y0_人指_指3.Position);
			Vector2D left = this.X0Y1_飛膜.ToLocal(手.X0Y0_親指_指1.Position);
			this.X0Y1_飛膜.OP[0].ps[0] = value;
			this.X0Y1_飛膜.OP[0].ps[2] = this.X0Y1_飛膜.ToLocal(手.X0Y0_人指_指2.Position);
			this.X0Y1_飛膜.OP[0].ps[1] = (this.X0Y1_飛膜.OP[0].ps[0] + this.X0Y1_飛膜.OP[0].ps[2]) * 0.5;
			this.X0Y1_飛膜.OP[1].ps[0] = this.X0Y1_飛膜.OP[0].ps[2];
			this.X0Y1_飛膜.OP[1].ps[2] = this.X0Y1_飛膜.ToLocal(手.X0Y0_親指_指2.Position);
			this.X0Y1_飛膜.OP[1].ps[1] = (this.X0Y1_飛膜.OP[1].ps[0] + this.X0Y1_飛膜.OP[1].ps[2]) * 0.5;
			List<Vector2D> ps = this.X0Y1_飛膜.OP[1].ps;
			ps[1] = ps[1] + (left - this.X0Y1_飛膜.OP[1].ps[1]) * 0.3;
			this.X0Y1_飛膜.OP[2].ps[0] = this.X0Y1_飛膜.OP[1].ps[2];
			if (上腕 == null)
			{
				if (下腕 == null)
				{
					this.X0Y1_飛膜.OP[2].ps[3] = this.X0Y1_飛膜.ToLocal(手.X0Y0_獣翼手.Position);
				}
				else
				{
					this.X0Y1_飛膜.OP[2].ps[3] = this.X0Y1_飛膜.ToLocal(下腕.X0Y0_獣翼下腕.Position);
				}
				Vector2D left2 = (this.X0Y1_飛膜.OP[2].ps[0] + this.X0Y1_飛膜.OP[2].ps[3]) * 0.5;
				this.X0Y1_飛膜.OP[2].ps[1] = left2 + (this.X0Y1_飛膜.OP[2].ps[0] - this.X0Y1_飛膜.OP[2].ps[3]) * 0.8;
				this.X0Y1_飛膜.OP[2].ps[2] = left2 + (this.X0Y1_飛膜.OP[2].ps[0] - this.X0Y1_飛膜.OP[2].ps[3]) * 0.4;
				ps = this.X0Y1_飛膜.OP[2].ps;
				ps[1] = ps[1] + (left - this.X0Y1_飛膜.OP[2].ps[1]) * 0.3;
				ps = this.X0Y1_飛膜.OP[2].ps;
				ps[2] = ps[2] + (left - this.X0Y1_飛膜.OP[2].ps[2]) * 0.3;
			}
			else
			{
				if (上腕.接続情報 == 接続情報.肩_上腕_接続)
				{
					this.X0Y1_飛膜.OP[2].ps[3] = this.X0Y0_飛膜.ToLocal(上腕.X0Y0_獣翼上腕.ToGlobal(上腕.X0Y0_獣翼上腕.OP[3].ps[1]));
				}
				else
				{
					this.X0Y1_飛膜.OP[2].ps[3] = this.X0Y0_飛膜.ToLocal(上腕.X0Y0_獣翼上腕.ToGlobal(上腕.X0Y0_獣翼上腕.OP[3].ps[1].AddY(0.003)));
				}
				Vector2D vector2D = (this.X0Y1_飛膜.OP[2].ps[0] + this.X0Y1_飛膜.OP[2].ps[3]) * 0.5;
				this.X0Y1_飛膜.OP[2].ps[1] = (this.X0Y1_飛膜.OP[2].ps[0] + vector2D) * 0.5;
				this.X0Y1_飛膜.OP[2].ps[2] = (vector2D + this.X0Y1_飛膜.OP[2].ps[3]) * 0.5;
			}
			if (下腕 == null)
			{
				Vector2D left3 = this.X0Y1_飛膜.ToLocal(手.X0Y0_獣翼手.Position);
				ps = this.X0Y1_飛膜.OP[2].ps;
				ps[1] = ps[1] + (left3 - this.X0Y1_飛膜.OP[2].ps[1]) * 0.3;
				ps = this.X0Y1_飛膜.OP[2].ps;
				ps[2] = ps[2] + (left3 - this.X0Y1_飛膜.OP[2].ps[2]) * 0.3;
			}
			else
			{
				Vector2D left4 = this.X0Y1_飛膜.ToLocal(下腕.X0Y0_獣翼下腕.Position);
				ps = this.X0Y1_飛膜.OP[2].ps;
				ps[1] = ps[1] + (left4 - this.X0Y1_飛膜.OP[2].ps[1]) * 0.3;
				ps = this.X0Y1_飛膜.OP[2].ps;
				ps[2] = ps[2] + (left4 - this.X0Y1_飛膜.OP[2].ps[2]) * 0.3;
			}
			if (上腕.接続情報 != 接続情報.肩_上腕_接続)
			{
				this.X0Y1_飛膜.OP[3].ps[0] = this.X0Y1_飛膜.OP[2].ps[3];
			}
			else
			{
				this.X0Y1_飛膜.OP[3].ps[0] = this.X0Y1_飛膜.OP[2].ps[3].AddY(0.05);
			}
			this.X0Y1_飛膜.OP[3].ps[2] = this.X0Y1_飛膜.ToLocal(手.X0Y0_小指_指3.ToGlobal(手.X0Y0_小指_指3.OP[0].ps[0]));
			this.X0Y1_飛膜.OP[3].ps[1] = (this.X0Y1_飛膜.OP[3].ps[0] + this.X0Y1_飛膜.OP[3].ps[2]) * 0.5;
			ps = this.X0Y1_飛膜.OP[3].ps;
			ps[1] = ps[1] + (this.X0Y1_飛膜.ToLocal(手.X0Y0_小指_指3.Position) - this.X0Y1_飛膜.OP[3].ps[1]) * 0.85;
			if (カ\u30FCブ)
			{
				this.X0Y1_飛膜.OP[3].ps[1] = (this.X0Y1_飛膜.OP[3].ps[0] + this.X0Y1_飛膜.OP[3].ps[2]) * 0.5;
				ps = this.X0Y1_飛膜.OP[3].ps;
				ps[1] = ps[1] + (this.X0Y1_飛膜.ToLocal(手.X0Y0_小指_指1.ToGlobal(手.X0Y0_小指_指1.JP[0].Joint)) - this.X0Y1_飛膜.OP[3].ps[1]) * 0.3;
			}
			Vector2D vector2D2 = this.X0Y1_飛膜.OP[3].ps[2];
			Vector2D vector2D3 = this.X0Y1_飛膜.ToLocal(手.X0Y0_薬指_指3.ToGlobal(手.X0Y0_薬指_指3.OP[0].ps[0]));
			Vector2D vector2D4 = (vector2D2 + vector2D3) * 0.5;
			double num = vector2D2.DistanceSquared(vector2D3);
			Vector2D vector2D5 = (this.X0Y1_飛膜.OP[4].ps[0] + this.X0Y1_飛膜.OP[19].ps[2]) * 0.5;
			double num2 = this.X0Y1_飛膜.OP[4].ps[0].DistanceSquared(this.X0Y1_飛膜.OP[19].ps[2]);
			Vector2D v = this.X0Y1_飛膜.OP[11].ps[2] - vector2D5;
			Vector2D v2 = this.X0Y1_飛膜.ToLocal(手.X0Y0_人指_指2.Position) - vector2D4;
			double num3 = v.Angle02π(Dat.Vec2DUnitY);
			MatrixD transform = num3.RotationZ();
			MatrixD transform2 = (v.Angle02π(v2) - num3).RotationZ();
			Vector2D right = vector2D4 - vector2D5;
			double num4 = num / num2;
			double num5 = vector2D5.X - vector2D5.X * num4;
			for (int i = 0; i < 16; i++)
			{
				int index = i + 4;
				for (int j = 0; j < this.X0Y1_飛膜.OP[index].ps.Count; j++)
				{
					Vector2D vector2D6 = this.X0Y1_飛膜.OP[index].ps[j].TransformCoordinateBP(vector2D5, transform);
					vector2D6.X = vector2D6.X * num4 + num5;
					this.X0Y1_飛膜.OP[index].ps[j] = vector2D6.TransformCoordinateBP(vector2D5, transform2) + right;
				}
			}
			this.X0Y1_飛膜.OP[4].ps[0] = vector2D2;
			this.X0Y1_飛膜.OP[19].ps[2] = vector2D3;
			vector2D2 = this.X0Y1_飛膜.OP[19].ps[2];
			vector2D3 = this.X0Y1_飛膜.ToLocal(手.X0Y0_中指_指3.ToGlobal(手.X0Y0_中指_指3.OP[0].ps[0]));
			vector2D4 = (vector2D2 + vector2D3) * 0.5;
			double num6 = vector2D2.DistanceSquared(vector2D3);
			vector2D5 = (this.X0Y1_飛膜.OP[20].ps[0] + this.X0Y1_飛膜.OP[39].ps[2]) * 0.5;
			num2 = this.X0Y1_飛膜.OP[20].ps[0].DistanceSquared(this.X0Y1_飛膜.OP[39].ps[2]);
			Vector2D v3 = this.X0Y1_飛膜.OP[29].ps[2] - vector2D5;
			v2 = this.X0Y1_飛膜.ToLocal(手.X0Y0_中指_指2.Position) - vector2D4;
			num3 = v3.Angle02π(Dat.Vec2DUnitY);
			transform = num3.RotationZ();
			transform2 = (v3.Angle02π(v2) - num3).RotationZ();
			right = vector2D4 - vector2D5;
			num4 = num6 / num2;
			num5 = vector2D5.X - vector2D5.X * num4;
			for (int k = 0; k < 20; k++)
			{
				int index = k + 20;
				for (int l = 0; l < this.X0Y1_飛膜.OP[index].ps.Count; l++)
				{
					Vector2D vector2D6 = this.X0Y1_飛膜.OP[index].ps[l].TransformCoordinateBP(vector2D5, transform);
					vector2D6.X = vector2D6.X * num4 + num5;
					this.X0Y1_飛膜.OP[index].ps[l] = vector2D6.TransformCoordinateBP(vector2D5, transform2) + right;
				}
			}
			this.X0Y1_飛膜.OP[20].ps[0] = vector2D2;
			this.X0Y1_飛膜.OP[39].ps[2] = vector2D3;
			this.X0Y1_飛膜.OP[40].ps[0] = vector2D3;
			this.X0Y1_飛膜.OP[40].ps[2] = this.X0Y1_飛膜.ToLocal(手.X0Y0_中指_指3.Position);
			this.X0Y1_飛膜.OP[40].ps[1] = this.X0Y1_飛膜.ToLocal(手.X0Y0_中指_指3.ToGlobal(手.X0Y0_中指_指3.OP[0].ps[1]));
			this.X0Y1_飛膜.OP[41].ps[0] = this.X0Y1_飛膜.OP[40].ps[2];
			this.X0Y1_飛膜.OP[41].ps[2] = this.X0Y1_飛膜.ToLocal(手.X0Y0_人指_指3.ToGlobal(手.X0Y0_人指_指3.OP[0].ps[0]));
			this.X0Y1_飛膜.OP[41].ps[1] = (this.X0Y1_飛膜.OP[41].ps[0] + this.X0Y1_飛膜.OP[41].ps[2]) * 0.5;
			ps = this.X0Y1_飛膜.OP[41].ps;
			ps[1] = ps[1] + (this.X0Y1_飛膜.ToLocal(手.X0Y0_人指_指1.Position) - this.X0Y1_飛膜.OP[41].ps[1]) * 0.08;
			this.X0Y1_飛膜.OP[42].ps[0] = this.X0Y1_飛膜.OP[41].ps[2];
			this.X0Y1_飛膜.OP[42].ps[2] = value;
			this.X0Y1_飛膜.OP[42].ps[1] = this.X0Y1_飛膜.ToLocal(手.X0Y0_人指_指3.ToGlobal(手.X0Y0_人指_指3.OP[0].ps[1]));
		}

		private void 欠損接続右(上腕_蝙 上腕, 下腕_蝙 下腕, 手_蝙 手, bool カ\u30FCブ)
		{
			Vector2D value = this.X0Y1_飛膜.ToLocal(手.X0Y0_人指_指3.Position);
			Vector2D left = this.X0Y1_飛膜.ToLocal(手.X0Y0_親指_指1.Position);
			this.X0Y1_飛膜.OP[42].ps[2] = value;
			this.X0Y1_飛膜.OP[42].ps[0] = this.X0Y1_飛膜.ToLocal(手.X0Y0_人指_指2.Position);
			this.X0Y1_飛膜.OP[42].ps[1] = (this.X0Y1_飛膜.OP[42].ps[2] + this.X0Y1_飛膜.OP[42].ps[0]) * 0.5;
			this.X0Y1_飛膜.OP[41].ps[2] = this.X0Y1_飛膜.OP[42].ps[0];
			this.X0Y1_飛膜.OP[41].ps[0] = this.X0Y1_飛膜.ToLocal(手.X0Y0_親指_指2.Position);
			this.X0Y1_飛膜.OP[41].ps[1] = (this.X0Y1_飛膜.OP[41].ps[2] + this.X0Y1_飛膜.OP[41].ps[0]) * 0.5;
			List<Vector2D> ps = this.X0Y1_飛膜.OP[41].ps;
			ps[1] = ps[1] + (left - this.X0Y1_飛膜.OP[41].ps[1]) * 0.3;
			this.X0Y1_飛膜.OP[40].ps[3] = this.X0Y1_飛膜.OP[41].ps[0];
			if (上腕 == null)
			{
				if (下腕 == null)
				{
					this.X0Y1_飛膜.OP[40].ps[0] = this.X0Y1_飛膜.ToLocal(手.X0Y0_獣翼手.Position);
				}
				else
				{
					this.X0Y1_飛膜.OP[40].ps[0] = this.X0Y1_飛膜.ToLocal(下腕.X0Y0_獣翼下腕.Position);
				}
				Vector2D left2 = (this.X0Y1_飛膜.OP[40].ps[3] + this.X0Y1_飛膜.OP[40].ps[0]) * 0.5;
				this.X0Y1_飛膜.OP[40].ps[2] = left2 + (this.X0Y1_飛膜.OP[40].ps[3] - this.X0Y1_飛膜.OP[40].ps[0]) * 0.8;
				this.X0Y1_飛膜.OP[40].ps[1] = left2 + (this.X0Y1_飛膜.OP[40].ps[3] - this.X0Y1_飛膜.OP[40].ps[0]) * 0.4;
				ps = this.X0Y1_飛膜.OP[40].ps;
				ps[2] = ps[2] + (left - this.X0Y1_飛膜.OP[40].ps[2]) * 0.3;
				ps = this.X0Y1_飛膜.OP[40].ps;
				ps[1] = ps[1] + (left - this.X0Y1_飛膜.OP[40].ps[1]) * 0.3;
			}
			else
			{
				if (上腕.接続情報 == 接続情報.肩_上腕_接続)
				{
					this.X0Y1_飛膜.OP[40].ps[0] = this.X0Y0_飛膜.ToLocal(上腕.X0Y0_獣翼上腕.ToGlobal(上腕.X0Y0_獣翼上腕.OP[0].ps[4]));
				}
				else
				{
					this.X0Y1_飛膜.OP[40].ps[0] = this.X0Y0_飛膜.ToLocal(上腕.X0Y0_獣翼上腕.ToGlobal(上腕.X0Y0_獣翼上腕.OP[0].ps[4].AddY(0.003)));
				}
				Vector2D vector2D = (this.X0Y1_飛膜.OP[40].ps[3] + this.X0Y1_飛膜.OP[40].ps[0]) * 0.5;
				this.X0Y1_飛膜.OP[40].ps[2] = (this.X0Y1_飛膜.OP[40].ps[3] + vector2D) * 0.5;
				this.X0Y1_飛膜.OP[40].ps[1] = (vector2D + this.X0Y1_飛膜.OP[40].ps[0]) * 0.5;
			}
			if (下腕 == null)
			{
				Vector2D left3 = this.X0Y1_飛膜.ToLocal(手.X0Y0_獣翼手.Position);
				ps = this.X0Y1_飛膜.OP[40].ps;
				ps[2] = ps[2] + (left3 - this.X0Y1_飛膜.OP[40].ps[2]) * 0.3;
				ps = this.X0Y1_飛膜.OP[40].ps;
				ps[1] = ps[1] + (left3 - this.X0Y1_飛膜.OP[40].ps[1]) * 0.3;
			}
			else
			{
				Vector2D left4 = this.X0Y1_飛膜.ToLocal(下腕.X0Y0_獣翼下腕.Position);
				ps = this.X0Y1_飛膜.OP[40].ps;
				ps[2] = ps[2] + (left4 - this.X0Y1_飛膜.OP[40].ps[2]) * 0.3;
				ps = this.X0Y1_飛膜.OP[40].ps;
				ps[1] = ps[1] + (left4 - this.X0Y1_飛膜.OP[40].ps[1]) * 0.3;
			}
			if (上腕.接続情報 != 接続情報.肩_上腕_接続)
			{
				this.X0Y1_飛膜.OP[39].ps[2] = this.X0Y1_飛膜.OP[40].ps[0];
			}
			else
			{
				this.X0Y1_飛膜.OP[39].ps[2] = this.X0Y1_飛膜.OP[40].ps[0].AddY(0.05);
			}
			this.X0Y1_飛膜.OP[39].ps[0] = this.X0Y1_飛膜.ToLocal(手.X0Y0_小指_指3.ToGlobal(手.X0Y0_小指_指3.OP[2].ps[2]));
			this.X0Y1_飛膜.OP[39].ps[1] = (this.X0Y1_飛膜.OP[39].ps[2] + this.X0Y1_飛膜.OP[39].ps[0]) * 0.5;
			ps = this.X0Y1_飛膜.OP[39].ps;
			ps[1] = ps[1] + (this.X0Y1_飛膜.ToLocal(手.X0Y0_小指_指3.Position) - this.X0Y1_飛膜.OP[39].ps[1]) * 0.85;
			if (カ\u30FCブ)
			{
				this.X0Y1_飛膜.OP[39].ps[1] = (this.X0Y1_飛膜.OP[39].ps[2] + this.X0Y1_飛膜.OP[39].ps[0]) * 0.5;
				ps = this.X0Y1_飛膜.OP[39].ps;
				ps[1] = ps[1] + (this.X0Y1_飛膜.ToLocal(手.X0Y0_小指_指1.ToGlobal(手.X0Y0_小指_指1.JP[0].Joint)) - this.X0Y1_飛膜.OP[39].ps[1]) * 0.3;
			}
			Vector2D vector2D2 = this.X0Y1_飛膜.OP[39].ps[0];
			Vector2D vector2D3 = this.X0Y1_飛膜.ToLocal(手.X0Y0_薬指_指3.ToGlobal(手.X0Y0_薬指_指3.OP[2].ps[2]));
			Vector2D vector2D4 = (vector2D2 + vector2D3) * 0.5;
			double num = vector2D2.DistanceSquared(vector2D3);
			Vector2D vector2D5 = (this.X0Y1_飛膜.OP[38].ps[2] + this.X0Y1_飛膜.OP[23].ps[0]) * 0.5;
			double num2 = this.X0Y1_飛膜.OP[38].ps[2].DistanceSquared(this.X0Y1_飛膜.OP[23].ps[0]);
			Vector2D v = this.X0Y1_飛膜.OP[31].ps[0] - vector2D5;
			Vector2D v2 = this.X0Y1_飛膜.ToLocal(手.X0Y0_人指_指2.Position) - vector2D4;
			double num3 = v.Angle02π(Dat.Vec2DUnitY);
			MatrixD transform = num3.RotationZ();
			MatrixD transform2 = (v.Angle02π(v2) - num3).RotationZ();
			Vector2D right = vector2D4 - vector2D5;
			double num4 = num / num2;
			double num5 = vector2D5.X - vector2D5.X * num4;
			for (int i = 0; i < 16; i++)
			{
				int index = 42 - (i + 4);
				for (int j = 0; j < this.X0Y1_飛膜.OP[index].ps.Count; j++)
				{
					Vector2D vector2D6 = this.X0Y1_飛膜.OP[index].ps[j].TransformCoordinateBP(vector2D5, transform);
					vector2D6.X = vector2D6.X * num4 + num5;
					this.X0Y1_飛膜.OP[index].ps[j] = vector2D6.TransformCoordinateBP(vector2D5, transform2) + right;
				}
			}
			this.X0Y1_飛膜.OP[38].ps[2] = vector2D2;
			this.X0Y1_飛膜.OP[23].ps[0] = vector2D3;
			vector2D2 = this.X0Y1_飛膜.OP[23].ps[0];
			vector2D3 = this.X0Y1_飛膜.ToLocal(手.X0Y0_中指_指3.ToGlobal(手.X0Y0_中指_指3.OP[2].ps[2]));
			vector2D4 = (vector2D2 + vector2D3) * 0.5;
			double num6 = vector2D2.DistanceSquared(vector2D3);
			vector2D5 = (this.X0Y1_飛膜.OP[22].ps[2] + this.X0Y1_飛膜.OP[3].ps[0]) * 0.5;
			num2 = this.X0Y1_飛膜.OP[22].ps[2].DistanceSquared(this.X0Y1_飛膜.OP[3].ps[0]);
			Vector2D v3 = this.X0Y1_飛膜.OP[13].ps[0] - vector2D5;
			v2 = this.X0Y1_飛膜.ToLocal(手.X0Y0_中指_指2.Position) - vector2D4;
			num3 = v3.Angle02π(Dat.Vec2DUnitY);
			transform = num3.RotationZ();
			transform2 = (v3.Angle02π(v2) - num3).RotationZ();
			right = vector2D4 - vector2D5;
			num4 = num6 / num2;
			num5 = vector2D5.X - vector2D5.X * num4;
			for (int k = 0; k < 20; k++)
			{
				int index = 42 - (k + 20);
				for (int l = 0; l < this.X0Y1_飛膜.OP[index].ps.Count; l++)
				{
					Vector2D vector2D6 = this.X0Y1_飛膜.OP[index].ps[l].TransformCoordinateBP(vector2D5, transform);
					vector2D6.X = vector2D6.X * num4 + num5;
					this.X0Y1_飛膜.OP[index].ps[l] = vector2D6.TransformCoordinateBP(vector2D5, transform2) + right;
				}
			}
			this.X0Y1_飛膜.OP[22].ps[2] = vector2D2;
			this.X0Y1_飛膜.OP[3].ps[0] = vector2D3;
			this.X0Y1_飛膜.OP[2].ps[2] = vector2D3;
			this.X0Y1_飛膜.OP[2].ps[0] = this.X0Y1_飛膜.ToLocal(手.X0Y0_中指_指3.Position);
			this.X0Y1_飛膜.OP[2].ps[1] = this.X0Y1_飛膜.ToLocal(手.X0Y0_中指_指3.ToGlobal(手.X0Y0_中指_指3.OP[2].ps[1]));
			this.X0Y1_飛膜.OP[1].ps[2] = this.X0Y1_飛膜.OP[2].ps[0];
			this.X0Y1_飛膜.OP[1].ps[0] = this.X0Y1_飛膜.ToLocal(手.X0Y0_人指_指3.ToGlobal(手.X0Y0_人指_指3.OP[2].ps[2]));
			this.X0Y1_飛膜.OP[1].ps[1] = (this.X0Y1_飛膜.OP[1].ps[2] + this.X0Y1_飛膜.OP[1].ps[0]) * 0.5;
			ps = this.X0Y1_飛膜.OP[1].ps;
			ps[1] = ps[1] + (this.X0Y1_飛膜.ToLocal(手.X0Y0_人指_指1.Position) - this.X0Y1_飛膜.OP[1].ps[1]) * 0.08;
			this.X0Y1_飛膜.OP[0].ps[2] = this.X0Y1_飛膜.OP[1].ps[0];
			this.X0Y1_飛膜.OP[0].ps[0] = value;
			this.X0Y1_飛膜.OP[0].ps[1] = this.X0Y1_飛膜.ToLocal(手.X0Y0_人指_指3.ToGlobal(手.X0Y0_人指_指3.OP[2].ps[1]));
		}

		public bool 接部_外線
		{
			get
			{
				return this.X0Y0_飛膜.OP[this.右 ? 5 : 3].Outline;
			}
			set
			{
				this.X0Y0_飛膜.OP[this.右 ? 5 : 3].Outline = value;
				this.X0Y1_飛膜.OP[this.右 ? 39 : 3].Outline = value;
			}
		}

		public override void 色更新()
		{
			if (this.本体.IndexY == 0)
			{
				this.X0Y0_飛膜CP.Update();
				return;
			}
			this.X0Y1_飛膜CP.Update();
		}

		public override void 色更新(Vector2D[] mm)
		{
			if (this.本体.IndexY == 0)
			{
				this.X0Y0_飛膜CP.Update(mm);
				return;
			}
			this.X0Y1_飛膜CP.Update(mm);
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
			this.飛膜CD = new ColorD(ref Col.Black, ref 体配色.膜R);
		}

		private void 配色T0(体配色 体配色)
		{
			this.飛膜CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
		}

		private void 配色T1(体配色 体配色)
		{
			this.飛膜CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
		}

		public Par X0Y0_飛膜;

		public Par X0Y1_飛膜;

		public ColorD 飛膜CD;

		public ColorP X0Y0_飛膜CP;

		public ColorP X0Y1_飛膜CP;
	}
}
