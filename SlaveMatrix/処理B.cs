using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 処理B
	{
		public double 強度
		{
			get
			{
				return (double)this.強さ / 3.0;
			}
		}

		public 処理B(調教UI 調教UI)
		{
			this.調教UI = 調教UI;
			this.Med = 調教UI.Med;
			this.Are = 調教UI.Are;
			this.ip = 調教UI.ip;
		}

		public 処理B(調教UI 調教UI, CM 対象)
		{
			this.調教UI = 調教UI;
			this.Med = 調教UI.Med;
			this.Are = 調教UI.Are;
			this.ip = 調教UI.ip;
			this.対象 = 対象;
		}

		public void Reset()
		{
			this.強さ = 1;
			this.選択 = false;
		}

		public 調教UI 調教UI;

		public Med Med;

		public Are Are;

		public Cha Cha;

		public Bod Bod;

		public 情報パネル ip;

		public CM 対象;

		public const int MaxLv = 3;

		public int 強さ = 1;

		public bool 選択;
	}
}
