using System;
using System.Drawing;

namespace SlaveMatrix
{
	[Serializable]
	public struct クロスB色
	{
		public void SetDefault()
		{
			this.生地1 = Color.OldLace;
			this.生地2 = Color.OldLace;
			this.SetColor2();
		}

		public void SetRandom()
		{
			Col.GetRandomClothesColor(out this.生地1);
			this.生地2 = this.生地1;
			this.SetColor2();
		}

		public void SetColor2()
		{
			Col.GetGrad(ref this.生地1, out this.生地1色);
			Col.GetGrad(ref this.生地2, out this.生地2色);
		}

		public Color 生地1;

		public Color 生地2;

		public Color2 生地1色;

		public Color2 生地2色;
	}
}
