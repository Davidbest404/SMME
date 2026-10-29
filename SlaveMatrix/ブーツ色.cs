using System;
using System.Drawing;

namespace SlaveMatrix
{
	[Serializable]
	public struct ブ\u30FCツ色
	{
		public void SetDefault()
		{
			Col.Add(ref Col.DarkGreen, 0, 0, -50, out this.生地1);
			Col.Add(ref Col.Indigo, 0, 0, -50, out this.生地2);
			this.縁 = Color.Gold;
			this.柄 = Color.Gold;
			this.紐 = Col.Black;
			this.金具 = Color.Gray;
			this.穴 = Col.Black;
			this.靴底 = Col.Black;
			this.踵 = Col.Black;
			this.SetColor2();
		}

		public void SetRandom()
		{
			Col.GetRandomClothesColor(out this.生地1);
			Col.GetRandomClothesColor(out this.生地2);
			Col.GetRandomClothesColor(out this.縁);
			this.柄 = this.縁;
			Col.GetRandomClothesColor(out this.紐);
			Col.GetRandomClothesColor(out this.金具);
			this.穴 = this.紐;
			this.靴底 = this.紐;
			this.踵 = this.紐;
			this.SetColor2();
		}

		public void SetColor2()
		{
			Col.GetGrad(ref this.生地1, out this.生地1色);
			Col.GetGrad(ref this.生地2, out this.生地2色);
			Col.GetGrad(ref this.縁, out this.縁色);
			Col.GetGrad(ref this.柄, out this.柄色);
			Col.GetGrad(ref this.紐, out this.紐色);
			Col.GetMetal(ref this.金具, out this.金具色);
			Col.GetGrad(ref this.穴, out this.穴色);
			Col.GetGrad(ref this.靴底, out this.靴底色);
			Col.GetGrad(ref this.踵, out this.踵色);
		}

		public Color 生地1;

		public Color 生地2;

		public Color 縁;

		public Color 柄;

		public Color 紐;

		public Color 金具;

		public Color 穴;

		public Color 靴底;

		public Color 踵;

		public Color2 生地1色;

		public Color2 生地2色;

		public Color2 縁色;

		public Color2 柄色;

		public Color2 紐色;

		public Color2 金具色;

		public Color2 穴色;

		public Color2 靴底色;

		public Color2 踵色;
	}
}
