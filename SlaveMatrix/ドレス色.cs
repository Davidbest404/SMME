using System;
using System.Drawing;

namespace SlaveMatrix
{
	[Serializable]
	public struct ドレス色
	{
		public void SetDefault()
		{
			Col.Add(ref Col.DarkGreen, 0, 0, -50, out this.生地);
			this.柄 = Color.Gold;
			this.縁 = Color.Gold;
			this.紐 = Col.Black;
			this.SetColor2();
		}

		public void SetRandom()
		{
			Col.GetRandomClothesColor(out this.生地);
			Col.GetRandomClothesColor(out this.柄);
			this.縁 = this.柄;
			Col.GetRandomClothesColor(out this.紐);
			this.SetColor2();
		}

		public void SetColor2()
		{
			Col.GetGrad(ref this.生地, out this.生地色);
			Col.GetGrad(ref this.柄, out this.柄色);
			Col.GetGrad(ref this.縁, out this.縁色);
			Col.GetGrad(ref this.紐, out this.紐色);
		}

		public Color 生地;

		public Color 柄;

		public Color 縁;

		public Color 紐;

		public Color2 生地色;

		public Color2 柄色;

		public Color2 縁色;

		public Color2 紐色;
	}
}
