using System;
using System.Drawing;

namespace SlaveMatrix
{
	public class 体配色
	{
		public 体配色(体色 色)
		{
			if (色.粘膜 == Col.Empty)
			{
				Col.GetMucosaColor(ref 色.人肌, out 色.粘膜);
			}
			if (色.口紅 == Col.Empty)
			{
				色.口紅 = 色.粘膜;
			}
			Col.GetGrad(ref 色.髪, out this.髪O);
			this.髪O.GetRep(out this.髪R);
			Col.GetGrad(ref 色.眉, out this.眉O);
			this.眉O.GetRep(out this.眉R);
			Col.GetGrad(ref 色.髭, out this.髭O);
			this.髭O.GetRep(out this.髭R);
			Col.GetGrad(ref 色.膜, out this.膜O);
			this.膜O.GetRep(out this.膜R);
			this.目左O = new Color2(ref Col.Black, ref 色.目左);
			this.目左O.GetRep(out this.目左R);
			this.目右O = new Color2(ref Col.Black, ref 色.目右);
			this.目右O.GetRep(out this.目右R);
			this.縦目O = new Color2(ref Col.Black, ref 色.縦目);
			this.縦目O.GetRep(out this.縦目R);
			this.頬目左O = new Color2(ref Col.Black, ref 色.頬目左);
			this.頬目左O.GetRep(out this.頬目左R);
			this.頬目右O = new Color2(ref Col.Black, ref 色.頬目右);
			this.頬目右O.GetRep(out this.頬目右R);
			Col.GetSkinGrad(ref 色.人肌, out this.人肌O);
			this.人肌O.GetRep(out this.人肌R);
			Col.GetGrad(ref 色.白部, out this.白部O);
			this.白部O.GetRep(out this.白部R);
			Col.GetGrad(ref 色.爪, out this.爪O);
			this.爪O.GetRep(out this.爪R);
			Col.GetGrad(ref 色.角0, out this.角0O);
			this.角0O.GetRep(out this.角0R);
			Col.GetGrad(ref 色.角1, out this.角1O);
			this.角1O.GetRep(out this.角1R);
			Col.GetGrad(ref 色.体0, out this.体0O);
			this.体0O.GetRep(out this.体0R);
			Col.GetGrad(ref 色.体1, out this.体1O);
			this.体1O.GetRep(out this.体1R);
			Col.GetGrad(ref 色.毛0, out this.毛0O);
			this.毛0O.GetRep(out this.毛0R);
			Col.GetGrad(ref 色.毛1, out this.毛1O);
			this.毛1O.GetRep(out this.毛1R);
			Col.GetGrad(ref 色.羽0, out this.羽0O);
			this.羽0O.GetRep(out this.羽0R);
			Col.GetGrad(ref 色.羽1, out this.羽1O);
			this.羽1O.GetRep(out this.羽1R);
			Col.GetGrad(ref 色.鱗0, out this.鱗0O);
			this.鱗0O.GetRep(out this.鱗0R);
			Col.GetGrad(ref 色.鱗1, out this.鱗1O);
			this.鱗1O.GetRep(out this.鱗1R);
			Col.GetGrad(ref 色.甲0, out this.甲0O);
			this.甲0O.GetRep(out this.甲0R);
			Col.GetGrad(ref 色.甲1, out this.甲1O);
			this.甲1O.GetRep(out this.甲1R);
			Col.GetGrad(ref 色.植0, out this.植0O);
			this.植0O.GetRep(out this.植0R);
			Col.GetGrad(ref 色.植1, out this.植1O);
			this.植1O.GetRep(out this.植1R);
			Col.GetGrad(ref 色.薔, out this.薔O);
			this.薔O.GetRep(out this.薔R);
			Col.GetGrad(ref 色.百, out this.百O);
			this.百O.GetRep(out this.百R);
			Col.GetGrad(ref 色.柄, out this.柄O);
			this.柄O.GetRep(out this.柄R);
			Col.GetGrad(ref 色.紋, out this.紋O);
			this.紋O.GetRep(out this.紋R);
			this.眼0O = new Color2(ref Col.Black, ref 色.眼0);
			this.眼0O.GetRep(out this.眼0R);
			this.眼1O = new Color2(ref Col.Black, ref 色.眼1);
			this.眼1O.GetRep(out this.眼1R);
			this.眼2O = new Color2(ref Col.Black, ref 色.眼2);
			this.眼2O.GetRep(out this.眼2R);
			this.コアO = new Color2(ref Col.Black, ref 色.コア);
			this.コアO.GetRep(out this.コアR);
			this.秘石O = new Color2(ref Col.Black, ref 色.秘石);
			this.秘石O.GetRep(out this.秘石R);
			this.後光O = new Color2(ref Col.White, ref 色.後光);
			this.後光O.GetRep(out this.後光R);
			if (色.血 == Col.Empty)
			{
				Col.Add(ref 色.粘膜, 0, 255, -50, out 色.血);
			}
			Col.GetGrad(ref 色.血, out this.血液O);
			this.血液O.GetRep(out this.血液R);
			Col.GetGrad(ref 色.粘膜, out this.ハ\u30FCトO);
			this.ハ\u30FCトO.GetRep(out this.ハ\u30FCトR);
			this.影O = new Color2(ref Col.Gray, ref Col.DarkGray);
			Col.Alpha(ref this.影O, 50, out this.影O);
			this.影O.GetRep(out this.影R);
			this.ハイライト = new Color2(ref Col.White, ref Col.Empty);
			this.ハイライト2O.Col1 = Col.White;
			this.ハイライト2O.Col2 = Color.FromArgb(0, Col.White);
			this.ハイライト2O.GetRep(out this.ハイライト2R);
			this.睫毛 = new Color2(ref 色.睫, ref Col.Empty);
			this.瞳孔 = new Color2(ref Col.Black, ref Col.Empty);
			Col.GetSkinColor2(ref 色.人肌, out this.肌濃.Col1);
			this.肌濃.Col1 = Color.FromArgb(90, this.肌濃.Col1);
			this.肌濃.Col2 = Col.Empty;
			Col.GetSkinColor2(ref 色.毛0, out this.毛濃.Col1);
			this.毛濃.Col1 = Color.FromArgb(90, this.毛濃.Col1);
			this.毛濃.Col2 = Col.Empty;
			this.粘膜 = new Color2(ref 色.粘膜, ref Col.Empty);
			this.粘膜穴.Col1 = Color.FromArgb(80, Col.Black);
			this.粘膜穴.Col2 = this.粘膜.Col2;
			Col.GetGrad(ref 色.粘膜, out this.舌);
			this.紅潮.Col1 = Color.FromArgb(60, 色.粘膜);
			this.紅潮.Col2 = Col.Empty;
			this.口紅.Col1 = Color.FromArgb(100, 色.口紅);
			this.口紅.Col2 = Col.Empty;
			this.刺青 = new Color2(ref 色.刺青, ref Col.Empty);
			this.刺青O = new Color2(ref 色.刺青, ref 色.刺青);
			this.刺青R = new Color2(ref 色.刺青, ref 色.刺青);
			this.歯 = new Color2(ref 色.歯, ref Col.Empty);
			this.体液.Col1 = 色.体液;
			this.体液.Col2 = Color.FromArgb(0, 色.体液);
			this.母乳 = new Color2(ref 色.母乳, ref Col.Empty);
			this.尿.Col1 = Color.FromArgb(160, 色.尿);
			this.尿.Col2 = Col.Empty;
			this.呼気.Col1 = Color.FromArgb(50, Col.White);
			this.呼気.Col2 = Col.Empty;
			this.湯気.Col1 = Color.FromArgb(50, Col.White);
			this.湯気.Col2 = Col.Empty;
			this.染み.Col1 = Color.FromArgb(50, Col.Black);
			this.染み.Col2 = Col.Empty;
			Col.Mul(ref 色.粘膜, 1.0, 2.0, 1.0, out this.紅潮線);
			this.紅潮線 = Color.FromArgb(180, this.紅潮線);
			Col.Mul(ref 色.粘膜, 1.0, 2.0, 0.5, out this.粘膜線);
			this.粘膜線 = Color.FromArgb(80, this.粘膜線);
			this.髪線 = Color.FromArgb(100, Col.Black);
			this.薄線 = Color.FromArgb(45, Col.Black);
			this.体液線 = Color.FromArgb(60, 色.体液);
			this.母乳線 = Color.FromArgb(80, 色.母乳);
			this.尿線 = Color.FromArgb(80, 色.尿);
		}

		public Color2 髪O;

		public Color2 髪R;

		public Color2 眉O;

		public Color2 眉R;

		public Color2 髭O;

		public Color2 髭R;

		public Color2 膜O;

		public Color2 膜R;

		public Color2 目左O;

		public Color2 目左R;

		public Color2 目右O;

		public Color2 目右R;

		public Color2 縦目O;

		public Color2 縦目R;

		public Color2 頬目左O;

		public Color2 頬目左R;

		public Color2 頬目右O;

		public Color2 頬目右R;

		public Color2 人肌O;

		public Color2 人肌R;

		public Color2 白部O;

		public Color2 白部R;

		public Color2 爪O;

		public Color2 爪R;

		public Color2 角0O;

		public Color2 角0R;

		public Color2 角1O;

		public Color2 角1R;

		public Color2 体0O;

		public Color2 体0R;

		public Color2 体1O;

		public Color2 体1R;

		public Color2 毛0O;

		public Color2 毛0R;

		public Color2 毛1O;

		public Color2 毛1R;

		public Color2 羽0O;

		public Color2 羽0R;

		public Color2 羽1O;

		public Color2 羽1R;

		public Color2 鱗0O;

		public Color2 鱗0R;

		public Color2 鱗1O;

		public Color2 鱗1R;

		public Color2 甲0O;

		public Color2 甲0R;

		public Color2 甲1O;

		public Color2 甲1R;

		public Color2 植0O;

		public Color2 植0R;

		public Color2 植1O;

		public Color2 植1R;

		public Color2 薔O;

		public Color2 薔R;

		public Color2 百O;

		public Color2 百R;

		public Color2 柄O;

		public Color2 柄R;

		public Color2 紋O;

		public Color2 紋R;

		public Color2 眼0O;

		public Color2 眼0R;

		public Color2 眼1O;

		public Color2 眼1R;

		public Color2 眼2O;

		public Color2 眼2R;

		public Color2 コアO;

		public Color2 コアR;

		public Color2 秘石O;

		public Color2 秘石R;

		public Color2 後光O;

		public Color2 後光R;

		public Color2 血液O;

		public Color2 血液R;

		public Color2 ハ\u30FCトO;

		public Color2 ハ\u30FCトR;

		public Color2 影O;

		public Color2 影R;

		public Color2 ハイライト;

		public Color2 ハイライト2O;

		public Color2 ハイライト2R;

		public Color2 睫毛;

		public Color2 瞳孔;

		public Color2 肌濃;

		public Color2 毛濃;

		public Color2 粘膜;

		public Color2 粘膜穴;

		public Color2 舌;

		public Color2 紅潮;

		public Color2 口紅;

		public Color2 刺青;

		public Color2 刺青O;

		public Color2 刺青R;

		public Color2 歯;

		public Color2 体液;

		public Color2 母乳;

		public Color2 尿;

		public Color2 呼気;

		public Color2 湯気;

		public Color2 染み;

		public Color 紅潮線;

		public Color 粘膜線;

		public Color 髪線;

		public Color 薄線;

		public Color 体液線;

		public Color 母乳線;

		public Color 尿線;
	}
}
