using System;
using System.Drawing;

namespace SlaveMatrix
{
	[Serializable]
	public struct ピアス色
	{
		public void SetDefault()
		{
			this.ピアス = Color.Gold;
			this.SetColor2();
		}

		public void SetRandom()
		{
			Col.GetRandomClothesColor(out this.ピアス);
			this.SetColor2();
		}

		public void SetColor2()
		{
			Col.GetGrad(ref this.ピアス, out this.金具色);
		}

		public Color ピアス;

		public Color2 金具色;
	}
}
