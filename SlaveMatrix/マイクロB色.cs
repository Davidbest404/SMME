using System;
using System.Drawing;

namespace SlaveMatrix
{
	[Serializable]
	public struct マイクロB色
	{
		public void SetDefault()
		{
			this.生地 = Color.DarkRed;
			this.留 = Color.Gold;
			this.縁 = Col.White;
			this.紐 = Col.White;
			this.SetColor2();
		}

		public void SetRandom()
		{
			Col.GetRandomClothesColor(out this.生地);
			Col.GetRandomClothesColor(out this.留);
			Col.GetRandomClothesColor(out this.縁);
			this.紐 = this.縁;
			this.SetColor2();
		}

		public void SetColor2()
		{
			Col.GetGrad(ref this.生地, out this.生地色);
			Col.GetGrad(ref this.留, out this.留色);
			Col.GetGrad(ref this.縁, out this.縁色);
			Col.GetGrad(ref this.紐, out this.紐色);
		}

		public void Setヴィオラ()
		{
			Col.Add(ref Col.DarkGreen, 0, 0, -50, out this.生地);
			this.留 = Color.Gold;
			this.縁 = Color.Gold;
			this.紐 = Col.Black;
			Col.GetGrad(ref this.生地, out this.生地色);
			Col.GetGrad(ref this.留, out this.留色);
			Col.GetGrad(ref this.縁, out this.縁色);
			Col.GetGrad(ref this.紐, out this.紐色);
		}

		public Color 生地;

		public Color 留;

		public Color 縁;

		public Color 紐;

		public Color2 生地色;

		public Color2 留色;

		public Color2 縁色;

		public Color2 紐色;
	}
}
