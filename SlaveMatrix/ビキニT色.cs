using System;
using System.Drawing;

namespace SlaveMatrix
{
	[Serializable]
	public struct ビキニT色
	{
		public void SetDefault()
		{
			this.生地 = Color.DarkRed;
			this.縁 = Col.White;
			this.紐 = Col.White;
			this.SetColor2();
		}

		public void SetRandom()
		{
			Col.GetRandomClothesColor(out this.生地);
			Col.GetRandomClothesColor(out this.縁);
			this.紐 = this.縁;
			this.SetColor2();
		}

		public void SetColor2()
		{
			Col.GetGrad(ref this.生地, out this.生地色);
			Col.GetGrad(ref this.縁, out this.縁色);
			Col.GetGrad(ref this.紐, out this.紐色);
		}

		public Color 生地;

		public Color 縁;

		public Color 紐;

		public Color2 生地色;

		public Color2 縁色;

		public Color2 紐色;
	}
}
