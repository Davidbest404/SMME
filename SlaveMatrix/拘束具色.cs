using System;
using System.Drawing;

namespace SlaveMatrix
{
	[Serializable]
	public struct 拘束具色
	{
		public void SetDefault()
		{
			this.革部 = Col.Black;
			this.金具 = Color.Gray;
			this.SetColor2();
		}

		public void SetRandom()
		{
			Col.GetRandomClothesColor(out this.革部);
			Col.GetRandomClothesColor(out this.金具);
			this.SetColor2();
		}

		public void SetColor2()
		{
			Col.GetGrad(ref this.革部, out this.革部色);
			Col.GetMetal(ref this.金具, out this.金具色);
		}

		public Color 革部;

		public Color 金具;

		public Color2 革部色;

		public Color2 金具色;
	}
}
