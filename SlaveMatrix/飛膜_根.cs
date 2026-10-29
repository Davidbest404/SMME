using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 飛膜_根 : Ele
	{
		public 飛膜_根(double DisUnit, 配色指定 配色指定, 体配色 体配色)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.腕左["飛膜根"]);
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

		public void 接続(上腕_蝙 上腕, 下腕_蝙 下腕, 手_蝙 手, Vector2D 接着点)
		{
			if (this.本体.IndexY == 0)
			{
				if (this.右 || this.反転X_ || this.反転Y_)
				{
					this.通常接続右(上腕, 下腕, 手, 接着点);
					return;
				}
				this.通常接続左(上腕, 下腕, 手, 接着点);
				return;
			}
			else
			{
				if (this.右 || this.反転X_ || this.反転Y_)
				{
					this.欠損接続右(上腕, 下腕, 手, 接着点);
					return;
				}
				this.欠損接続左(上腕, 下腕, 手, 接着点);
				return;
			}
		}

		private void 通常接続左(上腕_蝙 上腕, 下腕_蝙 下腕, 手_蝙 手, Vector2D 接着点)
		{
			Vector2D vector2D = this.X0Y0_飛膜.ToLocal(上腕.X0Y0_獣翼上腕.ToGlobal(上腕.X0Y0_獣翼上腕.JP[0].Joint));
			Vector2D vector2D2 = this.X0Y0_飛膜.ToLocal(上腕.X0Y0_獣翼上腕.ToGlobal(上腕.X0Y0_獣翼上腕.OP[3].ps[1]));
			this.X0Y0_飛膜.OP[0].ps[0] = vector2D;
			this.X0Y0_飛膜.OP[0].ps[2] = vector2D2;
			this.X0Y0_飛膜.OP[0].ps[1] = (this.X0Y0_飛膜.OP[0].ps[0] + this.X0Y0_飛膜.OP[0].ps[2]) * 0.5;
			this.X0Y0_飛膜.OP[1].ps[0] = this.X0Y0_飛膜.OP[0].ps[2];
			this.X0Y0_飛膜.OP[1].ps[2] = this.X0Y0_飛膜.ToLocal(接着点);
			this.X0Y0_飛膜.OP[1].ps[1] = (this.X0Y0_飛膜.OP[1].ps[0] + this.X0Y0_飛膜.OP[1].ps[2]) * 0.5;
			this.X0Y0_飛膜.OP[2].ps[0] = this.X0Y0_飛膜.OP[1].ps[2];
			List<Vector2D> ps;
			if (手 == null)
			{
				if (下腕 == null)
				{
					this.X0Y0_飛膜.OP[2].ps[2] = vector2D;
					this.X0Y0_飛膜.OP[2].ps[1] = (this.X0Y0_飛膜.OP[2].ps[0] + this.X0Y0_飛膜.OP[2].ps[2]) * 0.5;
					ps = this.X0Y0_飛膜.OP[2].ps;
					ps[1] = ps[1] + (vector2D2 - this.X0Y0_飛膜.OP[2].ps[1]) * 0.2;
				}
				else
				{
					this.X0Y0_飛膜.OP[2].ps[2] = this.X0Y0_飛膜.ToLocal(下腕.X0Y0_獣翼下腕.ToGlobal(下腕.X0Y0_獣翼下腕.JP[0].Joint));
					this.X0Y0_飛膜.OP[2].ps[1] = (this.X0Y0_飛膜.OP[2].ps[0] + this.X0Y0_飛膜.OP[2].ps[2]) * 0.5;
					ps = this.X0Y0_飛膜.OP[2].ps;
					ps[1] = ps[1] + (vector2D - this.X0Y0_飛膜.OP[2].ps[1]) * 0.2;
				}
				this.X0Y0_飛膜.OP[3].ps[0] = this.X0Y0_飛膜.OP[2].ps[2];
				this.X0Y0_飛膜.OP[3].ps[2] = vector2D;
				this.X0Y0_飛膜.OP[3].ps[1] = (this.X0Y0_飛膜.OP[3].ps[0] + this.X0Y0_飛膜.OP[3].ps[2]) * 0.5;
				return;
			}
			this.X0Y0_飛膜.OP[2].ps[2] = this.X0Y0_飛膜.ToLocal(手.X0Y0_小指_指3.ToGlobal(手.X0Y0_小指_指3.OP[0].ps[0]));
			this.X0Y0_飛膜.OP[2].ps[1] = (this.X0Y0_飛膜.OP[2].ps[0] + this.X0Y0_飛膜.OP[2].ps[2]) * 0.5;
			ps = this.X0Y0_飛膜.OP[2].ps;
			ps[1] = ps[1] + (this.X0Y0_飛膜.ToLocal(手.X0Y0_小指_指1.Position) - this.X0Y0_飛膜.OP[2].ps[1]) * 0.1;
			this.X0Y0_飛膜.OP[3].ps[0] = this.X0Y0_飛膜.OP[2].ps[2];
			this.X0Y0_飛膜.OP[3].ps[2] = vector2D;
			this.X0Y0_飛膜.OP[3].ps[1] = this.X0Y0_飛膜.ToLocal(手.X0Y0_小指_指2.Position);
		}

		private void 通常接続右(上腕_蝙 上腕, 下腕_蝙 下腕, 手_蝙 手, Vector2D 接着点)
		{
			Vector2D vector2D = this.X0Y0_飛膜.ToLocal(上腕.X0Y0_獣翼上腕.ToGlobal(上腕.X0Y0_獣翼上腕.JP[0].Joint));
			Vector2D vector2D2 = this.X0Y0_飛膜.ToLocal(上腕.X0Y0_獣翼上腕.ToGlobal(上腕.X0Y0_獣翼上腕.OP[0].ps[4]));
			this.X0Y0_飛膜.OP[3].ps[2] = vector2D;
			this.X0Y0_飛膜.OP[3].ps[0] = vector2D2;
			this.X0Y0_飛膜.OP[3].ps[1] = (this.X0Y0_飛膜.OP[3].ps[2] + this.X0Y0_飛膜.OP[3].ps[0]) * 0.5;
			this.X0Y0_飛膜.OP[2].ps[2] = this.X0Y0_飛膜.OP[3].ps[0];
			this.X0Y0_飛膜.OP[2].ps[0] = this.X0Y0_飛膜.ToLocal(接着点);
			this.X0Y0_飛膜.OP[2].ps[1] = (this.X0Y0_飛膜.OP[2].ps[2] + this.X0Y0_飛膜.OP[2].ps[0]) * 0.5;
			this.X0Y0_飛膜.OP[1].ps[2] = this.X0Y0_飛膜.OP[2].ps[0];
			List<Vector2D> ps;
			if (手 == null)
			{
				if (下腕 == null)
				{
					this.X0Y0_飛膜.OP[1].ps[0] = vector2D;
					this.X0Y0_飛膜.OP[1].ps[1] = (this.X0Y0_飛膜.OP[1].ps[2] + this.X0Y0_飛膜.OP[1].ps[0]) * 0.5;
					ps = this.X0Y0_飛膜.OP[1].ps;
					ps[1] = ps[1] + (vector2D2 - this.X0Y0_飛膜.OP[1].ps[1]) * 0.2;
				}
				else
				{
					this.X0Y0_飛膜.OP[1].ps[0] = this.X0Y0_飛膜.ToLocal(下腕.X0Y0_獣翼下腕.ToGlobal(下腕.X0Y0_獣翼下腕.JP[0].Joint));
					this.X0Y0_飛膜.OP[1].ps[1] = (this.X0Y0_飛膜.OP[1].ps[2] + this.X0Y0_飛膜.OP[1].ps[0]) * 0.5;
					ps = this.X0Y0_飛膜.OP[1].ps;
					ps[1] = ps[1] + (vector2D - this.X0Y0_飛膜.OP[1].ps[1]) * 0.2;
				}
				this.X0Y0_飛膜.OP[0].ps[2] = this.X0Y0_飛膜.OP[1].ps[0];
				this.X0Y0_飛膜.OP[0].ps[0] = vector2D;
				this.X0Y0_飛膜.OP[0].ps[1] = (this.X0Y0_飛膜.OP[0].ps[2] + this.X0Y0_飛膜.OP[0].ps[0]) * 0.5;
				return;
			}
			this.X0Y0_飛膜.OP[1].ps[0] = this.X0Y0_飛膜.ToLocal(手.X0Y0_小指_指3.ToGlobal(手.X0Y0_小指_指3.OP[2].ps[2]));
			this.X0Y0_飛膜.OP[1].ps[1] = (this.X0Y0_飛膜.OP[1].ps[2] + this.X0Y0_飛膜.OP[1].ps[0]) * 0.5;
			ps = this.X0Y0_飛膜.OP[1].ps;
			ps[1] = ps[1] + (this.X0Y0_飛膜.ToLocal(手.X0Y0_小指_指1.Position) - this.X0Y0_飛膜.OP[1].ps[1]) * 0.1;
			this.X0Y0_飛膜.OP[0].ps[2] = this.X0Y0_飛膜.OP[1].ps[0];
			this.X0Y0_飛膜.OP[0].ps[0] = vector2D;
			this.X0Y0_飛膜.OP[0].ps[1] = this.X0Y0_飛膜.ToLocal(手.X0Y0_小指_指2.Position);
		}

		private void 欠損接続左(上腕_蝙 上腕, 下腕_蝙 下腕, 手_蝙 手, Vector2D 接着点)
		{
			Vector2D vector2D = this.X0Y1_飛膜.ToLocal(上腕.X0Y0_獣翼上腕.ToGlobal(上腕.X0Y0_獣翼上腕.JP[0].Joint));
			Vector2D value = this.X0Y0_飛膜.ToLocal(上腕.X0Y0_獣翼上腕.ToGlobal(上腕.X0Y0_獣翼上腕.OP[3].ps[1]));
			this.X0Y1_飛膜.OP[0].ps[0] = vector2D;
			this.X0Y1_飛膜.OP[0].ps[2] = value;
			this.X0Y1_飛膜.OP[0].ps[1] = (this.X0Y1_飛膜.OP[0].ps[0] + this.X0Y1_飛膜.OP[0].ps[2]) * 0.5;
			this.X0Y1_飛膜.OP[1].ps[0] = this.X0Y1_飛膜.OP[0].ps[2];
			this.X0Y1_飛膜.OP[1].ps[2] = this.X0Y1_飛膜.ToLocal(接着点);
			this.X0Y1_飛膜.OP[1].ps[1] = (this.X0Y1_飛膜.OP[1].ps[0] + this.X0Y1_飛膜.OP[1].ps[2]) * 0.5;
			Vector2D vector2D2 = this.X0Y1_飛膜.OP[1].ps[2];
			Vector2D vector2D3 = (手 == null) ? ((下腕 == null) ? vector2D : this.X0Y1_飛膜.ToLocal(下腕.X0Y0_獣翼下腕.ToGlobal(下腕.X0Y0_獣翼下腕.JP[0].Joint))) : this.X0Y1_飛膜.ToLocal(手.X0Y0_小指_指3.ToGlobal(手.X0Y0_小指_指3.OP[0].ps[0]));
			Vector2D left = (vector2D2 + vector2D3) * 0.5;
			Vector2D v = vector2D2 - vector2D3;
			double num = v.LengthSquared();
			Vector2D vector2D4 = (this.X0Y1_飛膜.OP[2].ps[0] + this.X0Y1_飛膜.OP[9].ps[2]) * 0.5;
			Vector2D v2 = this.X0Y1_飛膜.OP[2].ps[0] - this.X0Y1_飛膜.OP[9].ps[2];
			double num2 = v2.LengthSquared();
			double num3 = v2.Angle02π(Dat.Vec2DUnitX);
			QuaternionD rotation = num3.RotationZQ();
			QuaternionD rotation2 = (v2.Angle02π(v) - num3).RotationZQ();
			double num4 = num / num2;
			double num5 = vector2D4.X - vector2D4.X * num4;
			Vector2D right = left - vector2D4;
			for (int i = 0; i < 8; i++)
			{
				int index = i + 2;
				for (int j = 0; j < this.X0Y1_飛膜.OP[index].ps.Count; j++)
				{
					Vector2D vector2D5 = this.X0Y1_飛膜.OP[index].ps[j].TransformCoordinateBP(vector2D4, rotation);
					vector2D5.X = vector2D5.X * num4 + num5;
					this.X0Y1_飛膜.OP[index].ps[j] = vector2D5.TransformCoordinateBP(vector2D4, rotation2) + right;
				}
			}
			this.X0Y1_飛膜.OP[2].ps[0] = vector2D2;
			this.X0Y1_飛膜.OP[9].ps[2] = vector2D3;
			this.X0Y1_飛膜.OP[10].ps[0] = vector2D3;
			this.X0Y1_飛膜.OP[10].ps[2] = vector2D;
			if (手 == null)
			{
				this.X0Y1_飛膜.OP[10].ps[1] = (this.X0Y1_飛膜.OP[10].ps[0] + this.X0Y1_飛膜.OP[10].ps[2]) * 0.5;
				return;
			}
			this.X0Y1_飛膜.OP[10].ps[1] = this.X0Y0_飛膜.ToLocal(手.X0Y0_小指_指2.Position);
		}

		private void 欠損接続右(上腕_蝙 上腕, 下腕_蝙 下腕, 手_蝙 手, Vector2D 接着点)
		{
			Vector2D vector2D = this.X0Y1_飛膜.ToLocal(上腕.X0Y0_獣翼上腕.ToGlobal(上腕.X0Y0_獣翼上腕.JP[0].Joint));
			Vector2D value = this.X0Y0_飛膜.ToLocal(上腕.X0Y0_獣翼上腕.ToGlobal(上腕.X0Y0_獣翼上腕.OP[0].ps[4]));
			this.X0Y1_飛膜.OP[10].ps[2] = vector2D;
			this.X0Y1_飛膜.OP[10].ps[0] = value;
			this.X0Y1_飛膜.OP[10].ps[1] = (this.X0Y1_飛膜.OP[10].ps[2] + this.X0Y1_飛膜.OP[10].ps[0]) * 0.5;
			this.X0Y1_飛膜.OP[9].ps[2] = this.X0Y1_飛膜.OP[10].ps[0];
			this.X0Y1_飛膜.OP[9].ps[0] = this.X0Y1_飛膜.ToLocal(接着点);
			this.X0Y1_飛膜.OP[9].ps[1] = (this.X0Y1_飛膜.OP[9].ps[2] + this.X0Y1_飛膜.OP[9].ps[0]) * 0.5;
			Vector2D vector2D2 = this.X0Y1_飛膜.OP[9].ps[0];
			Vector2D vector2D3 = (手 == null) ? ((下腕 == null) ? vector2D : this.X0Y1_飛膜.ToLocal(下腕.X0Y0_獣翼下腕.ToGlobal(下腕.X0Y0_獣翼下腕.JP[0].Joint))) : this.X0Y1_飛膜.ToLocal(手.X0Y0_小指_指3.ToGlobal(手.X0Y0_小指_指3.OP[2].ps[2]));
			Vector2D left = (vector2D2 + vector2D3) * 0.5;
			Vector2D v = vector2D2 - vector2D3;
			double num = v.LengthSquared();
			Vector2D vector2D4 = (this.X0Y1_飛膜.OP[8].ps[2] + this.X0Y1_飛膜.OP[1].ps[0]) * 0.5;
			Vector2D v2 = this.X0Y1_飛膜.OP[8].ps[2] - this.X0Y1_飛膜.OP[1].ps[0];
			double num2 = v2.LengthSquared();
			double num3 = v2.Angle02π(-Dat.Vec2DUnitX);
			QuaternionD rotation = num3.RotationZQ();
			QuaternionD rotation2 = (v2.Angle02π(v) - num3).RotationZQ();
			double num4 = num / num2;
			double num5 = vector2D4.X - vector2D4.X * num4;
			Vector2D right = left - vector2D4;
			for (int i = 0; i < 8; i++)
			{
				int index = 10 - (i + 2);
				for (int j = 0; j < this.X0Y1_飛膜.OP[index].ps.Count; j++)
				{
					Vector2D vector2D5 = this.X0Y1_飛膜.OP[index].ps[j].TransformCoordinateBP(vector2D4, rotation);
					vector2D5.X = vector2D5.X * num4 + num5;
					this.X0Y1_飛膜.OP[index].ps[j] = vector2D5.TransformCoordinateBP(vector2D4, rotation2) + right;
				}
			}
			this.X0Y1_飛膜.OP[8].ps[2] = vector2D2;
			this.X0Y1_飛膜.OP[1].ps[0] = vector2D3;
			this.X0Y1_飛膜.OP[0].ps[2] = vector2D3;
			this.X0Y1_飛膜.OP[0].ps[0] = vector2D;
			if (手 == null)
			{
				this.X0Y1_飛膜.OP[0].ps[1] = (this.X0Y1_飛膜.OP[0].ps[2] + this.X0Y1_飛膜.OP[0].ps[0]) * 0.5;
				return;
			}
			this.X0Y1_飛膜.OP[0].ps[1] = this.X0Y0_飛膜.ToLocal(手.X0Y0_小指_指2.Position);
		}

		public bool 接部_外線
		{
			get
			{
				return this.X0Y0_飛膜.OP[this.右 ? 0 : 3].Outline;
			}
			set
			{
				this.X0Y0_飛膜.OP[this.右 ? 0 : 3].Outline = value;
				this.X0Y1_飛膜.OP[this.右 ? 0 : 10].Outline = value;
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
