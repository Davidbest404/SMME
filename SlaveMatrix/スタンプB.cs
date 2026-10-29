using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class スタンプB : スタンプ
	{
		public override void Draw(Are Are)
		{
			try
			{
				if (this.sta.Count > 0)
				{
					foreach (sep sep in this.sta)
					{
						if (sep.Sta.表示)
						{
							this.p = sep.Ele.本体.Current.GetPar(sep.Path);
							sep.Sta.位置B = this.p.ToGlobal(sep.Pos);
							sep.Sta.色更新();
							sep.Sta.本体.Draw(Are);
						}
					}
				}
			}
			catch
			{
			}
		}

		public void Add(Vector2D cp, Color hc, Dictionary<Ele, List<Ele>> 参照)
		{
			this.he = this.Bod.GetHitEle(hc);
			if (base.チェック2(this.he))
			{
				if (this.sta.Count >= 33)
				{
					this.sep = this.sta[0];
					this.sta.RemoveAt(0);
					this.sep.Sta.Dispose();
				}
				this.sep = default(sep);
				this.sep.Sta = this.EleD.GetEle(this.Are.DisUnit, this.Med, Sta.GameData.配色);
				this.sep.Sta.SetHitFalse();
				this.sep.Sta.Xv = OthN.XS.NextDouble();
				this.sep.Sta.右 = OthN.XS.NextBool();
				this.sep.Ele = this.he;
				this.sep.Par = this.he.本体.GetHitPar_(hc);
				this.sep.Path = this.sep.Par.GetPath();
				this.sep.Pos = this.sep.Par.ToLocal(cp);
				if (参照.ContainsKey(this.he))
				{
					参照[this.he].Add(this.sep.Sta);
				}
				else
				{
					参照[this.he] = new List<Ele>
					{
						this.sep.Sta
					};
				}
				this.sta.Add(this.sep);
				this.ぶっかけ垂れ.Sta();
			}
		}

		public スタンプB(Med Med, Are Are, Cha Cha, Bod Bod, EleD EleD, Mots Mots) : base(Med, Are, Cha, Bod, EleD)
		{
			Ele e = null;
			Mot mot = new Mot(0.0, 1.0);
			mot.BaseSpeed = 1.0;
			mot.Staing = delegate(Mot m)
			{
				e = this.sta.Last<sep>().Sta;
				m.Max = OthN.XS.NextDouble();
			};
			mot.Runing = delegate(Mot m)
			{
				e.Yv = m.Value;
			};
			mot.Reaing = delegate(Mot m)
			{
				m.End();
			};
			mot.Rouing = delegate(Mot m)
			{
			};
			mot.Ending = delegate(Mot m)
			{
			};
			this.ぶっかけ垂れ = mot;
			Mots.Add(EleD.GetHashCode().ToString(), this.ぶっかけ垂れ);
		}

		private Mot ぶっかけ垂れ;
	}
}
