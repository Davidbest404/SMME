using System;
using System.Drawing;

namespace SlaveMatrix
{
	[Serializable]
	public class 主人公配色
	{
		public 主人公配色(主人公色 色)
		{
			Col.GetSkinGrad(ref 色.肌色, out this.肌色);
			Col.GetGrad(ref 色.血液, out this.血液);
			this.刺青 = new Color2(ref 色.刺青, ref Col.Empty);
			this.精液ぶっかけ.Col1 = Color.FromArgb(125, 色.精液);
			this.精液ぶっかけ.Col2 = Col.Empty;
			this.精液垂れ.Col1 = Color.FromArgb(200, 色.精液);
			this.精液垂れ.Col2 = Col.Empty;
			Color baseColor;
			Col.GetMucosaColor(ref 色.肌色, out baseColor);
			Col.GetGrad(ref baseColor, out this.粘膜);
			Col.GetSkinColor2(ref 色.肌色, out baseColor);
			this.肌線 = Color.FromArgb(100, baseColor);
			Col.GetMucosaColor(ref 色.肌色, out baseColor);
			Col.Mul(ref baseColor, 1.0, 2.0, 0.5, out baseColor);
			this.粘線 = Color.FromArgb(80, baseColor);
			this.精線 = Color.FromArgb(80, Col.White);
		}

		public 主人公配色(主人公配色 s)
		{
			this.肌色 = new Color2(ref s.肌色.Col1, ref s.肌色.Col2);
			this.血液 = new Color2(ref s.血液.Col1, ref s.血液.Col2);
			this.刺青 = new Color2(ref s.刺青.Col1, ref s.刺青.Col2);
			this.精液ぶっかけ = new Color2(ref s.精液ぶっかけ.Col1, ref s.精液ぶっかけ.Col2);
			this.精液垂れ = new Color2(ref s.精液垂れ.Col1, ref s.精液垂れ.Col2);
			this.粘膜 = new Color2(ref s.粘膜.Col1, ref s.粘膜.Col2);
			this.肌線 = s.肌線;
			this.粘線 = s.粘線;
			this.精線 = s.精線;
		}

		public Color2 肌色;

		public Color2 血液;

		public Color2 刺青;

		public Color2 精液ぶっかけ;

		public Color2 精液垂れ;

		public Color2 粘膜;

		public Color 肌線;

		public Color 粘線;

		public Color 精線;
	}
}
