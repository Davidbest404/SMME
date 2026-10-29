using System;
using System.Drawing;

namespace SlaveMatrix
{
	[Serializable]
	public struct ブラT色
	{
		public void SetDefault()
		{
			this.生地1 = Color.DarkRed;
			this.生地2 = Color.DarkRed;
			this.リボン = Col.Black;
			this.レ\u30FCス = Col.Black;
			this.柄 = Col.Black;
			this.縁 = Color.DarkRed;
			this.紐 = Col.Black;
			this.ジャスタ\u30FC = Color.Gold;
			this.SetColor2();
		}

		public void SetRandom()
		{
			Col.GetRandomClothesColor(out this.生地1);
			this.生地2 = this.生地1;
			Col.GetRandomClothesColor(out this.リボン);
			this.レ\u30FCス = this.リボン;
			this.柄 = this.リボン;
			this.縁 = this.生地1;
			this.紐 = this.リボン;
			Col.GetRandomClothesColor(out this.ジャスタ\u30FC);
			this.SetColor2();
		}

		public void SetColor2()
		{
			Col.GetGrad(ref this.生地1, out this.生地1色);
			Col.GetGrad(ref this.生地2, out this.生地2色);
			Col.GetGrad(ref this.リボン, out this.リボン色);
			Col.GetGrad(ref this.レ\u30FCス, out this.レ\u30FCス色);
			Col.GetGrad(ref this.柄, out this.柄色);
			Col.GetGrad(ref this.縁, out this.縁色);
			Col.GetGrad(ref this.紐, out this.紐色);
			Col.GetGrad(ref this.ジャスタ\u30FC, out this.ジャスタ\u30FC色);
		}

		public Color 生地1;

		public Color 生地2;

		public Color リボン;

		public Color レ\u30FCス;

		public Color 柄;

		public Color 縁;

		public Color 紐;

		public Color ジャスタ\u30FC;

		public Color2 生地1色;

		public Color2 生地2色;

		public Color2 リボン色;

		public Color2 レ\u30FCス色;

		public Color2 柄色;

		public Color2 縁色;

		public Color2 紐色;

		public Color2 ジャスタ\u30FC色;
	}
}
