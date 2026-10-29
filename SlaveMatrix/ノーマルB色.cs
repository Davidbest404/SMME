using System;
using System.Drawing;

namespace SlaveMatrix
{
	[Serializable]
	public struct ノ\u30FCマルB色
	{
		public void SetDefault()
		{
			this.生地 = Color.DarkRed;
			this.リボン = Col.Black;
			this.柄 = Col.Black;
			this.縁 = Color.DarkRed;
			this.紐 = Col.Black;
			this.SetColor2();
		}

		public void SetRandom()
		{
			Col.GetRandomClothesColor(out this.生地);
			Col.GetRandomClothesColor(out this.リボン);
			this.柄 = this.リボン;
			this.縁 = this.生地;
			this.紐 = this.リボン;
			this.SetColor2();
		}

		public void SetColor2()
		{
			Col.GetGrad(ref this.生地, out this.生地色);
			Col.GetGrad(ref this.リボン, out this.リボン色);
			Col.GetGrad(ref this.柄, out this.柄色);
			Col.GetGrad(ref this.縁, out this.縁色);
			Col.GetGrad(ref this.紐, out this.紐色);
		}

		public void Setビキニ()
		{
			this.生地 = Color.DarkRed;
			this.リボン = Col.White;
			this.柄 = Col.White;
			this.縁 = Col.White;
			this.紐 = Col.White;
			Col.GetGrad(ref this.生地, out this.生地色);
			Col.GetGrad(ref this.リボン, out this.リボン色);
			Col.GetGrad(ref this.柄, out this.柄色);
			Col.GetGrad(ref this.縁, out this.縁色);
			Col.GetGrad(ref this.紐, out this.紐色);
		}

		public Color 生地;

		public Color リボン;

		public Color 柄;

		public Color 縁;

		public Color 紐;

		public Color2 生地色;

		public Color2 リボン色;

		public Color2 柄色;

		public Color2 縁色;

		public Color2 紐色;
	}
}
