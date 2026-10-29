using System;
using System.Drawing;

namespace SlaveMatrix
{
	[Serializable]
	public class 主人公色
	{
		public 主人公色()
		{
			this.肌色 = Color.FromArgb(255, 255, 207, 169);
			Col.Add(ref this.肌色, -10, -10, 0, out this.肌色);
		}

		public Color 肌色;

		public Color 髪色 = Col.Black;

		public Color 瞳色 = Color.FromArgb(57, 32, 0);

		public Color 血液 = Color.Red;

		public Color 刺青 = Col.Black;

		public Color 精液 = Color.PapayaWhip;
	}
}
