using System;
using System.Drawing;

namespace SlaveMatrix
{
	[Serializable]
	public struct キャップ色
	{
		public void SetDefault()
		{
			this.根本 = Color.HotPink;
			this.先端 = Color.HotPink;
			this.SetColor2();
		}

		public void SetRandom()
		{
			Col.GetRandomClothesColor(out this.根本);
			this.先端 = this.根本;
			this.SetColor2();
		}

		public void SetColor2()
		{
			Col.GetGrad(ref this.根本, out this.根本色);
			Col.GetGrad(ref this.先端, out this.先端色);
		}

		public Color 根本;

		public Color 先端;

		public Color2 根本色;

		public Color2 先端色;
	}
}
