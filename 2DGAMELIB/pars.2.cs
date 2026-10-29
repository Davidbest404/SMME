using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace _2DGAMELIB
{
	public static class pars
	{
		public static bool IsPars(this object obj)
		{
			return obj is Pars;
		}

		public static bool IsParT(this object obj)
		{
			return obj is ParT;
		}

		public static bool IsPar(this object obj)
		{
			return obj is Par;
		}

		public static Pars ToPars(this object obj)
		{
			return (Pars)obj;
		}

		public static ParT ToParT(this object obj)
		{
			return (ParT)obj;
		}

		public static Par ToPar(this object obj)
		{
			return (Par)obj;
		}

		public static Pen Copy(this Pen Pen)
		{
			return new Pen(Pen.Color, Pen.Width)
			{
				EndCap = Pen.EndCap,
				StartCap = Pen.StartCap
			};
		}

		public static Brush Copy(this Brush Brush)
		{
			if (Brush is SolidBrush)
			{
				return new SolidBrush(((SolidBrush)Brush).Color);
			}
			if (Brush is LinearGradientBrush)
			{
				LinearGradientBrush linearGradientBrush = (LinearGradientBrush)Brush;
				LinearGradientBrush linearGradientBrush2 = new LinearGradientBrush(linearGradientBrush.Rectangle, Color.Black, Color.White, 0f);
				linearGradientBrush2.Blend = linearGradientBrush.Blend;
				linearGradientBrush2.GammaCorrection = linearGradientBrush.GammaCorrection;
				linearGradientBrush2.InterpolationColors = linearGradientBrush.InterpolationColors;
				linearGradientBrush2.LinearColors = new Color[linearGradientBrush.LinearColors.Length];
				linearGradientBrush.LinearColors.CopyTo(linearGradientBrush2.LinearColors, 0);
				linearGradientBrush2.Transform = linearGradientBrush.Transform;
				linearGradientBrush2.WrapMode = linearGradientBrush.WrapMode;
				return linearGradientBrush2;
			}
			if (Brush is PathGradientBrush)
			{
				PathGradientBrush pathGradientBrush = (PathGradientBrush)Brush;
				PathGradientBrush pathGradientBrush2 = new PathGradientBrush(new GraphicsPath());
				pathGradientBrush2.Blend = pathGradientBrush.Blend;
				pathGradientBrush2.CenterColor = pathGradientBrush.CenterColor;
				pathGradientBrush2.CenterPoint = pathGradientBrush.CenterPoint;
				pathGradientBrush2.FocusScales = pathGradientBrush.FocusScales;
				pathGradientBrush2.InterpolationColors = pathGradientBrush.InterpolationColors;
				pathGradientBrush2.SurroundColors = new Color[pathGradientBrush.SurroundColors.Length];
				pathGradientBrush.SurroundColors.CopyTo(pathGradientBrush2.SurroundColors, 0);
				pathGradientBrush2.Transform = pathGradientBrush.Transform;
				pathGradientBrush2.WrapMode = pathGradientBrush.WrapMode;
				return pathGradientBrush2;
			}
			if (Brush is TextureBrush)
			{
				TextureBrush textureBrush = (TextureBrush)Brush;
				return new TextureBrush(textureBrush.Image)
				{
					Transform = textureBrush.Transform,
					WrapMode = textureBrush.WrapMode
				};
			}
			if (Brush is HatchBrush)
			{
				HatchBrush hatchBrush = (HatchBrush)Brush;
				return new HatchBrush(hatchBrush.HatchStyle, hatchBrush.ForegroundColor, hatchBrush.BackgroundColor);
			}
			return null;
		}

		public static Font Copy(this Font Font)
		{
			return new Font(Font.FontFamily, Font.Size, Font.Style, Font.Unit, Font.GdiCharSet, Font.GdiVerticalFont);
		}

		public static StringFormat Copy(this StringFormat StringFormat)
		{
			return new StringFormat(StringFormat);
		}
	}
}
