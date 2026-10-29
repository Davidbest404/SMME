using System;
using System.Drawing;

namespace SlaveMatrix
{
	[Serializable]
	public struct 鎖色
	{
		public void SetDefault()
		{
			this.金属 = Color.Gray;
			this.SetColor2();
		}

		public void SetRandom()
		{
			Col.GetRandomClothesColor(out this.金属);
			this.SetColor2();
		}

		public void SetColor2()
		{
			Col.GetMetal(ref this.金属, out this.金属色);
		}

		public Color 金属;

		public Color2 金属色;
	}
}
