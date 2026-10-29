using System;
using System.Collections.Generic;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 汗掻き
	{
		public void Draw(Are Are)
		{
			if (this.汗かき.Run || this.汗ひき.Run)
			{
				this.i = 0;
				foreach (ryps ryps in this.対象)
				{
					foreach (Vector2D local in ryps.ps)
					{
						this.汗 = this.全体[this.i];
						if (this.汗.濃度 != 0.0)
						{
							this.tp = ryps.r.ToGlobal(local);
							this.汗.本体.CurJoinRoot.PositionBase = this.tp + (ryps.r.ToGlobal(ryps.c) - this.tp) * this.位置[this.i];
							this.汗.本体.JoinPA();
							this.汗.色更新();
							this.汗.本体.Draw(Are);
						}
						this.i++;
					}
				}
			}
		}

		public 汗掻き(Med Med, Are Are, Cha Cha, Mots Mots)
		{
			汗掻き.<>c__DisplayClass11_0 CS$<>8__locals1 = new 汗掻き.<>c__DisplayClass11_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.es = null;
			CS$<>8__locals1.n = null;
			CS$<>8__locals1.re = false;
			汗D e;
			this.汗かき = new Mot(0.0, 1.0)
			{
				BaseSpeed = 1.0,
				Staing = delegate(Mot m)
				{
					if (CS$<>8__locals1.<>4__this.汗だし)
					{
						CS$<>8__locals1.es = (from e in CS$<>8__locals1.<>4__this.全体
						where e.濃度 != 0.0
						select e).ToArray<Ele>();
						Ele[] es = CS$<>8__locals1.es;
						for (int j = 0; j < es.Length; j++)
						{
							es[j].濃度 = 0.0;
						}
					}
				},
				Runing = delegate(Mot m)
				{
					if (CS$<>8__locals1.<>4__this.汗だし)
					{
						Ele[] es = CS$<>8__locals1.es;
						for (int j = 0; j < es.Length; j++)
						{
							es[j].濃度 = m.Value;
						}
						return;
					}
					if (!CS$<>8__locals1.re)
					{
						CS$<>8__locals1.n.Yv = m.Value;
						return;
					}
					CS$<>8__locals1.n.濃度 = m.Value;
				},
				Reaing = delegate(Mot m)
				{
					if (CS$<>8__locals1.<>4__this.汗だし)
					{
						Ele[] es = CS$<>8__locals1.es;
						for (int j = 0; j < es.Length; j++)
						{
							es[j].濃度 = 1.0;
						}
						m.ResetValue();
						CS$<>8__locals1.<>4__this.汗だし = false;
						CS$<>8__locals1.es = (from e in CS$<>8__locals1.<>4__this.全体
						where e.濃度 != 0.0
						select e).ToArray<Ele>();
						CS$<>8__locals1.n = CS$<>8__locals1.es[OthN.XS.Next(CS$<>8__locals1.es.Length)];
						return;
					}
					CS$<>8__locals1.re = true;
				},
				Rouing = delegate(Mot m)
				{
					if (!CS$<>8__locals1.<>4__this.汗だし)
					{
						CS$<>8__locals1.n.Yv = 0.0;
						CS$<>8__locals1.n.濃度 = 0.0;
						CS$<>8__locals1.es = (from e in CS$<>8__locals1.<>4__this.全体
						where e.濃度 != 0.0
						select e).ToArray<Ele>();
						if (CS$<>8__locals1.es.Length != 0)
						{
							CS$<>8__locals1.n = CS$<>8__locals1.es[OthN.XS.Next(CS$<>8__locals1.es.Length)];
						}
						CS$<>8__locals1.es = (from e in CS$<>8__locals1.<>4__this.全体
						where e.濃度 == 0.0
						select e).ToArray<Ele>();
						if (CS$<>8__locals1.es.Length != 0)
						{
							CS$<>8__locals1.es[OthN.XS.Next(CS$<>8__locals1.es.Length)].濃度 = 1.0;
						}
						CS$<>8__locals1.re = false;
						m.ResetValue();
					}
				},
				Ending = delegate(Mot m)
				{
					if (!CS$<>8__locals1.<>4__this.汗だし)
					{
						CS$<>8__locals1.n.Yv = 0.0;
						CS$<>8__locals1.n.濃度 = 0.0;
						CS$<>8__locals1.es = (from e in CS$<>8__locals1.<>4__this.全体
						where e.濃度 != 0.0
						select e).ToArray<Ele>();
						CS$<>8__locals1.n = CS$<>8__locals1.es[OthN.XS.Next(CS$<>8__locals1.es.Length)];
						CS$<>8__locals1.es = (from e in CS$<>8__locals1.<>4__this.全体
						where e.濃度 == 0.0
						select e).ToArray<Ele>();
						CS$<>8__locals1.es[OthN.XS.Next(CS$<>8__locals1.es.Length)].濃度 = 1.0;
						CS$<>8__locals1.re = false;
						m.ResetValue();
						CS$<>8__locals1.<>4__this.汗ひき.Sta();
					}
				}
			};
			Mots.Add(this.汗かき.GetHashCode().ToString(), this.汗かき);
			Mot mot = new Mot(0.0, 1.0);
			mot.BaseSpeed = 1.0;
			mot.Staing = delegate(Mot m)
			{
				CS$<>8__locals1.es = (from e in CS$<>8__locals1.<>4__this.全体
				where e.濃度 != 0.0
				select e).ToArray<Ele>();
			};
			mot.Runing = delegate(Mot m)
			{
				Ele[] es = CS$<>8__locals1.es;
				for (int j = 0; j < es.Length; j++)
				{
					es[j].濃度 = m.Value.Inverse();
				}
			};
			mot.Reaing = delegate(Mot m)
			{
				m.End();
				m.ResetValue();
				Ele[] es = CS$<>8__locals1.es;
				for (int j = 0; j < es.Length; j++)
				{
					es[j].濃度 = 1.0;
				}
				CS$<>8__locals1.<>4__this.汗だし = true;
			};
			mot.Rouing = delegate(Mot m)
			{
			};
			mot.Ending = delegate(Mot m)
			{
			};
			this.汗ひき = mot;
			Mots.Add(this.汗ひき.GetHashCode().ToString(), this.汗ひき);
			List<ryps> list = new List<ryps>();
			int num = 0;
			e = new 汗D();
			foreach (Ele ele in from e in Cha.Bod.全要素
			where this.汗対象.Contains(e.GetType().ToString())
			select e)
			{
				CS$<>8__locals1.ryps = default(ryps);
				CS$<>8__locals1.ryps.r = ele.本体.CurJoinRoot;
				CS$<>8__locals1.ryps.c = CS$<>8__locals1.ryps.r.OP.GetCenter();
				汗掻き.<>c__DisplayClass11_0 CS$<>8__locals2 = CS$<>8__locals1;
				IEnumerable<Vector2D> source = CS$<>8__locals1.ryps.r.OP.EnumPoints();
				Func<Vector2D, bool> predicate;
				if ((predicate = CS$<>8__locals1.<>9__18) == null)
				{
					predicate = (CS$<>8__locals1.<>9__18 = ((Vector2D p) => CS$<>8__locals1.ryps.c.Y > p.Y));
				}
				CS$<>8__locals2.ryps.ps = source.Where(predicate).ToArray<Vector2D>();
				list.Add(CS$<>8__locals1.ryps);
				Vector2D[] ps = CS$<>8__locals1.ryps.ps;
				for (int i = 0; i < ps.Length; i++)
				{
					this.汗 = new 汗(Are.DisUnit, 配色指定.N0, Cha.配色, Med, e);
					this.汗.SetHitFalse();
					this.汗.濃度 = ((OthN.XS.NextDouble() < 0.2) ? 1.0 : 0.0);
					this.位置.Add((num == 0) ? 0.7 : ((num == 1) ? 0.5 : 0.3));
					this.全体.Add(this.汗);
					if (num == 2)
					{
						num = 0;
					}
					else
					{
						num++;
					}
				}
			}
			this.対象 = list.ToArray();
		}

		public void Dispose()
		{
			foreach (Ele ele in this.全体)
			{
				ele.Dispose();
			}
		}

		private HashSet<string> 汗対象 = new HashSet<string>
		{
			Sta.胸t.ToString(),
			Sta.胴t.ToString(),
			Sta.肩t.ToString(),
			Sta.腰t.ToString()
		};

		private ryps[] 対象;

		private List<Ele> 全体 = new List<Ele>();

		private List<double> 位置 = new List<double>();

		public Mot 汗かき;

		private Mot 汗ひき;

		private bool 汗だし = true;

		private int i;

		private Ele 汗;

		private Vector2D tp;
	}
}
