using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class スタンプ
	{
		public virtual void Draw(Are Are)
		{
		}

		public virtual void Add(Vector2D cp, Color hc)
		{
		}

		public スタンプ()
		{
		}

		public スタンプ(Med Med, Are Are, Cha Cha, Bod Bod, EleD EleD)
		{
			this.Med = Med;
			this.Are = Are;
			this.Cha = Cha;
			this.Bod = Bod;
			this.EleD = EleD;
		}

		public virtual void Dispose()
		{
			foreach (sep sep in this.sta)
			{
				sep.Sta.Dispose();
			}
		}

		public void Clear()
		{
			foreach (sep sep in this.sta)
			{
				sep.Sta.Dispose();
			}
			this.sta.Clear();
		}

		public void 脚Clear()
		{
			foreach (sep sep in (from e in this.sta
			where e.Ele is 腿_人 || e.Ele is 脚_人 || e.Ele is 足_人
			select e).ToArray<sep>())
			{
				sep.Sta.Dispose();
				this.sta.Remove(sep);
			}
		}

		public bool チェック1(Ele e)
		{
			return e != null && !(e is 性器) && !(e is 肛門) && !(e is 首);
		}

		public bool チェック2(Ele e)
		{
			return e != null && !(e is 手_人) && !(e is 性器) && !(e is 肛門) && !(e is 首);
		}

		public Med Med;

		public Are Are;

		public Cha Cha;

		public Bod Bod;

		protected EleD EleD;

		protected List<sep> sta = new List<sep>();

		protected const int Max = 33;

		protected Par p;

		protected Color2 c2;

		protected Ele he;

		protected sep sep;
	}
}
