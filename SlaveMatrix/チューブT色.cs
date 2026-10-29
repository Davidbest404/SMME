using System;
using System.Drawing;

namespace SlaveMatrix
{
	[Serializable]
	public struct チュ\u30FCブT色
	{
		public void SetDefault()
		{
			this.生地 = Color.OldLace;
			this.縁 = Color.OldLace;
			this.SetColor2();
		}

		public void SetRandom()
		{
			Col.GetRandomClothesColor(out this.生地);
			this.縁 = this.生地;
			this.SetColor2();
		}

		public void SetColor2()
		{
			Col.GetGrad(ref this.生地, out this.生地色);
			Col.GetGrad(ref this.縁, out this.縁色);
		}

		public Color 生地;

		public Color 縁;

		public Color2 生地色;

		public Color2 縁色;
	}
}
