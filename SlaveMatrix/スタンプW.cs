using System;
using System.Drawing;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class スタンプW : スタンプ
	{
		public override void Draw(Are Are)
		{
			try
			{
				if (this.sta.Count > 0)
				{
					foreach (sep sep in this.sta)
					{
						this.p = sep.Ele.本体.Current.GetPar(sep.Path);
						sep.Sta.角度B = this.p.AngleBase - sep.Par.AngleBase;
						sep.Sta.位置B = this.p.ToGlobal(sep.Pos);
						sep.Sta.色更新();
						sep.Sta.本体.Draw(Are);
					}
				}
			}
			catch
			{
			}
		}

		public bool Add(Vector2D cp, Color hc, Ele he)
		{
			if (base.チェック2(he) && he == this.Par)
			{
				this.p = he.本体.GetHitPar_(hc);
				this.c2 = he.GetParOfColorP(this.p).ColorD.色;
				if (this.c2.Col1 == this.Cha.配色.人肌O.Col1 || this.c2.Col2 == this.Cha.配色.人肌O.Col1)
				{
					if (this.sta.Count >= 33)
					{
						this.sep = this.sta[0];
						this.sta.RemoveAt(0);
						this.sep.Sta.Dispose();
					}
					this.sep = default(sep);
					this.sep.Sta = this.EleD.GetEle(this.Are.DisUnit, this.Med, this.Cha.配色);
					this.sep.Sta.SetHitFalse();
					this.sep.Sta.角度C = 45.0 * (double)(OthN.XS.NextBool() ? 1 : -1) * OthN.XS.NextDouble();
					this.sep.Ele = he;
					this.sep.Par = this.p;
					this.sep.Path = this.sep.Par.GetPath();
					this.sep.Pos = this.sep.Par.ToLocal(cp + (he.位置 - cp).newNormalize() * 0.01);
					this.sta.Add(this.sep);
				}
				return true;
			}
			return false;
		}

		public スタンプW(Med Med, Are Are, Cha Cha, Bod Bod, EleD EleD, Ele Par) : base(Med, Are, Cha, Bod, EleD)
		{
			this.Par = Par;
			EleD.尺度B = 0.9;
		}

		private Ele Par;
	}
}
