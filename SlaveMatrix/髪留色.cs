using System;
using System.Drawing;

namespace SlaveMatrix
{
	[Serializable]
	public struct 髪留色
	{
		public void SetDefault()
		{
			this.髪留1 = Color.DarkRed;
			this.髪留2 = Color.DarkRed;
			this.SetColor2();
		}

		public void SetRandom()
		{
			Col.GetRandomClothesColor(out this.髪留1);
			this.髪留2 = this.髪留1;
			this.SetColor2();
		}

		public void SetColor2()
		{
			Col.GetGrad(ref this.髪留1, out this.髪留1色);
			Col.GetGrad(ref this.髪留2, out this.髪留2色);
		}

		public Color 髪留1;

		public Color 髪留2;

		public Color2 髪留1色;

		public Color2 髪留2色;
	}
}
