using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 擬音
	{
		public void Sound(Are Are, Vector2D p, string s, Font f, Color c, double d, bool b)
		{
			擬音.<>c__DisplayClass3_0 CS$<>8__locals1 = new 擬音.<>c__DisplayClass3_0();
			CS$<>8__locals1.b = b;
			CS$<>8__locals1.d = d;
			CS$<>8__locals1.Are = Are;
			CS$<>8__locals1.<>4__this = this;
			ParT pt = new ParT
			{
				PositionBase = p,
				Text = s,
				Font = f,
				TextColor = c,
				SizeBase = 0.5 * CS$<>8__locals1.d,
				FontSize = 0.07,
				Closed = true,
				Pen = null,
				Brush = null,
				Hit = false
			};
			pt.SetStringRectOutline(CS$<>8__locals1.Are.Unit, CS$<>8__locals1.Are.GD);
			pt.BasePointBase = pt.OP.GetCenter();
			Mot mot = new Mot(0.0, 1.0);
			string n = mot.GetHashCode().ToString();
			TextRenderingHint tr = CS$<>8__locals1.Are.GD.TextRenderingHint;
			mot.BaseSpeed = 0.1;
			mot.Runing = delegate(Mot m)
			{
				if (CS$<>8__locals1.b)
				{
					pt.PositionCont = Oth.GetRandomVector() * 0.0025 * CS$<>8__locals1.d;
				}
				pt.TextColor = Color.FromArgb((int)((double)pt.TextColor.A * m.Value.Inverse()), pt.TextColor);
				CS$<>8__locals1.Are.GD.TextRenderingHint = TextRenderingHint.AntiAlias;
				CS$<>8__locals1.Are.Draw(pt);
				CS$<>8__locals1.Are.GD.TextRenderingHint = tr;
			};
			mot.Reaing = delegate(Mot m)
			{
				m.End();
			};
			mot.Ending = delegate(Mot m)
			{
				CS$<>8__locals1.Are.GD.TextRenderingHint = tr;
				pt.Dispose();
				CS$<>8__locals1.<>4__this.del.Add(n);
			};
			this.ms.Add(n, mot);
			mot.Sta();
		}

		public void Draw(FPS FPS)
		{
			this.ms.Drive(FPS);
			foreach (string name in this.del)
			{
				this.ms.Rem(name);
			}
			this.del.Clear();
		}

		public void Clear()
		{
			foreach (KeyValuePair<string, Mot> keyValuePair in this.ms.ms)
			{
				keyValuePair.Value.End();
			}
			foreach (string name in this.del)
			{
				this.ms.Rem(name);
			}
			this.del.Clear();
		}

		public void Dispose()
		{
			foreach (Mot mot in this.ms.ms.Values)
			{
				mot.End();
			}
		}

		private Mots ms = new Mots();

		private List<string> del = new List<string>();
	}
}
