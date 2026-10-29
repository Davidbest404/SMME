using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class EleI : IDisposable
	{
		public void Add(Ele e)
		{
			this.ElesH.Add(e);
		}

		public void AddRange(IEnumerable<Ele> es)
		{
			foreach (Ele item in es)
			{
				this.ElesH.Add(item);
			}
		}

		public bool IsUpdate(Ele e)
		{
			return this.Updatef && this.ElesH.Contains(e);
		}

		public EleI(Med Med)
		{
			this.Lay = new Are(Med.Unit, Med.Base.XRatio, Med.Base.YRatio, Med.Base.Size + 0.0025, Med.DisQuality, Med.HitAccuracy);
			this.Lay.Setting();
			this.ElesH = new HashSet<Ele>();
		}

		public void 描画(Are Are)
		{
			Vec.Add(ref this.Position, ref this.PositionCont, out this.Lay.Position);
			Are.Draw(this.Lay);
		}

		public void Update()
		{
			if (this.Updatef)
			{
				this.Lay.Clear();
				this.描画処理(this.Lay);
				this.Updatef = false;
			}
		}

		public void Dispose()
		{
			this.Lay.Dispose();
		}

		public bool IsHeavy()
		{
			return this.ElesH.IsEle<触手>() || this.ElesH.IsEle<尾>();
		}

		public Vector2D Position = Dat.Vec2DZero;

		public Vector2D PositionCont = Dat.Vec2DZero;

		public Are Lay;

		public bool Updatef = true;

		public Action<Are> 描画処理;

		public HashSet<Ele> ElesH;
	}
}
