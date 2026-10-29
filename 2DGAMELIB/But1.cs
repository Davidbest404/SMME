using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace _2DGAMELIB
{
	public class But1 : But
	{
		public But1(Par Par, Action<But> Action) : base(Par, Action)
		{
			this.Setting();
		}

		public But1(ParT ParT, Action<But> Action) : base(ParT, Action)
		{
			this.Setting();
		}

		public But1(Pars Pars, Action<But> Action) : base(Pars, Action)
		{
			this.Setting();
		}

		private void Setting()
		{
			foreach (Par par in this.pars.EnumAllPar())
			{
				this.BaseColors.Add(par.BrushColor);
				this.OverColors.Add(this.BaseColors.Last<Color>().FuncHSV(delegate(Hsv hsv)
				{
					hsv.Hue += 30;
					hsv.Sat -= 30;
					hsv.Val += 100;
					return hsv;
				}));
				this.PushColors.Add(this.OverColors.Last<Color>().FuncHSV(delegate(Hsv hsv)
				{
					hsv.Hue += 30;
					hsv.Sat -= 30;
					hsv.Val += 100;
					return hsv;
				}));
				this.TextColors.Add(par.IsParT() ? par.ToParT().TextColor : Color.Empty);
			}
			this.Over = delegate(But a)
			{
				int num = 0;
				foreach (Par par2 in this.pars.EnumAllPar())
				{
					par2.BrushColor = this.OverColors[num];
					if (par2.IsParT())
					{
						par2.ToParT().TextColor = this.TextColors[num].Reverse();
					}
					num++;
				}
			};
			this.Push = delegate(But a)
			{
				int num = 0;
				foreach (Par par2 in this.pars.EnumAllPar())
				{
					par2.BrushColor = this.PushColors[num];
					if (par2.IsParT())
					{
						par2.ToParT().TextColor = this.TextColors[num].Reverse();
					}
					num++;
				}
			};
			this.Release = delegate(But a)
			{
				int num = 0;
				foreach (Par par2 in this.pars.EnumAllPar())
				{
					par2.BrushColor = this.OverColors[num];
					if (par2.IsParT())
					{
						par2.ToParT().TextColor = this.TextColors[num].Reverse();
					}
					num++;
				}
			};
			this.Out = delegate(But a)
			{
				int num = 0;
				foreach (Par par2 in this.pars.EnumAllPar())
				{
					par2.BrushColor = this.BaseColors[num];
					if (par2.IsParT())
					{
						par2.ToParT().TextColor = this.TextColors[num];
					}
					num++;
				}
			};
		}

		public List<Color> BaseColors = new List<Color>();

		public List<Color> OverColors = new List<Color>();

		public List<Color> PushColors = new List<Color>();

		public List<Color> TextColors = new List<Color>();
	}
}
