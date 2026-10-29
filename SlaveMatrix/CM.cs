using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class CM
	{
		public 使用状態 使用状態
		{
			get
			{
				return this.v;
			}
			set
			{
				this.v = value;
				if (this.v == 使用状態.使用)
				{
					this.Ele.SetHitFalse();
					return;
				}
				this.Ele.SetHitTrue();
			}
		}

		public CM(Med Med, 調教UI 調教UI, Ele Ele)
		{
			this.調教UI = 調教UI;
			this.Ele = Ele;
			foreach (Par par in Ele.本体.EnumAllPar())
			{
				par.HitColor = Med.GetUniqueColor();
			}
		}

		public void Reset()
		{
			this.Ele.Xi = 0;
			this.Ele.Yi = 0;
			this.Ele.濃度 = 0.5;
			this.使用状態 = 使用状態.待機;
			this.Under = false;
			this.描画Show = true;
			this.StaShow = true;
			this.DraShow = true;
			this.Show = true;
			this.bp = default(Vector2D);
		}

		public void 描画0(Are Are)
		{
			if (this.Show && this.Under && this.描画Show)
			{
				this.Ele.本体.JoinPA();
				this.Ele.色更新();
				this.調教UI.持ち手下描画();
				this.Ele.描画0(Are);
			}
		}

		public void 描画1(Are Are)
		{
			if (this.Show && this.Under && this.描画Show)
			{
				this.Ele.描画1(Are);
				this.調教UI.持ち手上描画();
			}
		}

		public void 描画0s(Are Are)
		{
			if (this.Show && this.Under && this.描画Show)
			{
				this.Ele.本体.JoinPA();
				this.Ele.色更新();
				this.Ele.描画0(Are);
			}
		}

		public void 描画1s(Are Are)
		{
			if (this.Show && this.Under && this.描画Show)
			{
				this.Ele.描画1(Are);
			}
		}

		public void 待機描画(Are Are)
		{
			if (this.Show && !this.Under && this.StaShow)
			{
				this.Ele.本体.JoinPA();
				this.Ele.色更新();
				this.Ele.描画0(Are);
				this.Ele.描画1(Are);
			}
		}

		public void Draw(Are Are)
		{
			if (this.Show && !this.Under && this.DraShow)
			{
				this.調教UI.持ち手下描画();
				this.Ele.本体.JoinPA();
				this.Ele.色更新();
				this.Ele.描画0(Are);
				this.Ele.描画1(Are);
				this.調教UI.持ち手上描画();
			}
		}

		public void Draws(Are Are)
		{
			if (this.Show && !this.Under && this.DraShow)
			{
				this.Ele.本体.JoinPA();
				this.Ele.色更新();
				this.Ele.描画0(Are);
				this.Ele.描画1(Are);
			}
		}

		private 調教UI 調教UI;

		public Ele Ele;

		private 使用状態 v;

		public bool Under;

		public bool 描画Show = true;

		public bool StaShow = true;

		public bool DraShow = true;

		public bool Show = true;

		public Vector2D bp;
	}
}
