using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 体色
	{
		public 体色()
		{
		}

		public 体色(bool b0)
		{
			int num = OthN.XS.Next(360);
			foreach (FieldInfo fieldInfo in from e in base.GetType().GetFields()
			where e.FieldType.ToString() == Sta.ct
			select e)
			{
				Color color;
				HSV.ToRGB(num + OthN.XS.Next(5), OthN.XS.NextM(0, 223), OthN.XS.NextM(128, 255), out color);
				fieldInfo.SetValue(this, color);
			}
			Col.GetRandomColor(out this.目左);
			this.目右 = this.目左;
			this.縦目 = this.目左;
			this.頬目左 = this.目左;
			this.頬目右 = this.目左;
			this.眉 = this.髪;
			this.毛0 = this.眉;
			this.睫 = Col.Black;
			Hsv hsv;
			if (b0)
			{
				Col.GetSkinColor(out this.人肌);
				this.血 = Color.FromArgb(255, 184, 6, 18);
			}
			else
			{
				Col.GetRandomSkinColor(out this.人肌);
				hsv = new Hsv(ref this.人肌);
				hsv.H = num;
				hsv.GetColor(out this.人肌);
				this.血 = Color.Empty;
			}
			this.粘膜 = Col.Empty;
			if (b0)
			{
				this.白部 = Col.White;
			}
			else if (0.1.Lot())
			{
				this.白部 = Col.Black;
			}
			else
			{
				this.白部 = Col.White;
			}
			this.歯 = Color.PapayaWhip;
			this.爪 = (OthN.XS.NextBool() ? Color.PapayaWhip : Col.Black);
			this.角0 = Color.LightGray;
			this.角1 = Col.DarkGray;
			this.口紅 = Col.Empty;
			this.刺青 = Color.FromArgb((int)(byte.MaxValue - this.人肌.R), (int)(byte.MaxValue - this.人肌.G), (int)(byte.MaxValue - this.人肌.B));
			hsv = new Hsv(ref this.刺青);
			hsv.S = 255;
			hsv.GetColor(out this.刺青);
			this.後光 = Color.Yellow;
			this.体液 = Col.White;
			this.母乳 = Color.PapayaWhip;
			this.尿 = Color.Gold;
			this.紋 = this.刺青;
		}

		public List<string> 血統 = new List<string>();

		public Color 髪 = Color.Orange;

		public Color 眉 = Color.Orange;

		public Color 睫 = Col.Black;

		public Color 髭 = Col.White;

		public Color 体0 = Color.Orange;

		public Color 体1 = Color.Yellow;

		public Color 毛0 = Color.Orange;

		public Color 毛1 = Col.White;

		public Color 羽0 = Color.Orange;

		public Color 羽1 = Col.White;

		public Color 鱗0 = Color.OrangeRed;

		public Color 鱗1 = Color.Yellow;

		public Color 甲0 = Color.Orange;

		public Color 甲1 = Color.Yellow;

		public Color 植0 = Color.Orange;

		public Color 植1 = Color.Yellow;

		public Color 薔 = Color.Red;

		public Color 百 = Col.White;

		public Color 柄 = Color.Brown;

		public Color 紋 = Color.OrangeRed;

		public Color 人肌 = Color.FromArgb(255, 255, 207, 169);

		public Color 粘膜 = Col.Empty;

		public Color 目左 = Color.Yellow;

		public Color 目右 = Color.Yellow;

		public Color 縦目 = Color.Yellow;

		public Color 頬目左 = Color.Yellow;

		public Color 頬目右 = Color.Yellow;

		public Color 白部 = Col.White;

		public Color 歯 = Col.White;

		public Color 爪 = Col.White;

		public Color 角0 = Col.White;

		public Color 角1 = Col.White;

		public Color 膜 = Color.OrangeRed;

		public Color 眼0 = Color.Red;

		public Color 眼1 = Color.Red;

		public Color 眼2 = Color.Red;

		public Color コア = Color.Red;

		public Color 秘石 = Color.Red;

		public Color 後光 = Color.Yellow;

		public Color 口紅 = Col.Empty;

		public Color 刺青 = Col.Black;

		public Color 尿 = Color.Gold;

		public Color 体液 = Col.White;

		public Color 母乳 = Color.PapayaWhip;

		public Color 血 = Color.FromArgb(255, 184, 6, 18);

		public static HashSet<string> 変異色 = new HashSet<string>(new string[]
		{
			"髪",
			"眉",
			"睫",
			"髭",
			"体0",
			"体1",
			"毛0",
			"毛1",
			"羽0",
			"羽1",
			"鱗0",
			"鱗1",
			"甲0",
			"甲1",
			"植0",
			"植1",
			"薔",
			"百",
			"柄",
			"紋",
			"人肌",
			"粘膜",
			"目左",
			"目右",
			"縦目",
			"頬目左",
			"頬目右",
			"白部",
			"爪",
			"角0",
			"角1",
			"膜",
			"眼0",
			"眼1",
			"眼2",
			"コア",
			"秘石",
			"後光",
			"口紅",
			"刺青"
		});
	}
}
