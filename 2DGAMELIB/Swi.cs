using System;
using System.Collections.Generic;
using System.Drawing;

namespace _2DGAMELIB
{
	public class Swi
	{
		public bool Flag
		{
			get
			{
				return this.flag;
			}
		}

		public Swi(Color OnColor)
		{
			this.OnColor = OnColor;
		}

		public Swi(ref Color OnColor)
		{
			this.OnColor = OnColor;
		}

		public void OnOff(But But)
		{
			But1 but = (But1)But;
			if (!this.flag)
			{
				this.flag = true;
				if (this.colors == null)
				{
					this.colors = new List<Color>(but.BaseColors);
				}
				int i;
				for (i = 0; i < but.BaseColors.Count; i++)
				{
					but.BaseColors[i] = this.OnColor;
					but.OverColors[i] = but.BaseColors[i].FuncHSV(delegate(Hsv hsv)
					{
						hsv.Hue += 30;
						hsv.Sat -= 30;
						hsv.Val += 100;
						return hsv;
					});
					but.PushColors[i] = but.OverColors[i].FuncHSV(delegate(Hsv hsv)
					{
						hsv.Hue += 30;
						hsv.Sat -= 30;
						hsv.Val += 100;
						return hsv;
					});
				}
				i = 0;
				using (IEnumerator<Par> enumerator = but.Pars.EnumAllPar().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Par par = enumerator.Current;
						par.BrushColor = but.OverColors[i];
						i++;
					}
					return;
				}
			}
			this.flag = false;
			if (this.colors != null)
			{
				but.BaseColors = this.colors;
				this.colors = null;
			}
			int j;
			for (j = 0; j < but.BaseColors.Count; j++)
			{
				but.OverColors[j] = but.BaseColors[j].FuncHSV(delegate(Hsv hsv)
				{
					hsv.Hue += 30;
					hsv.Sat -= 30;
					hsv.Val += 100;
					return hsv;
				});
				but.PushColors[j] = but.OverColors[j].FuncHSV(delegate(Hsv hsv)
				{
					hsv.Hue += 30;
					hsv.Sat -= 30;
					hsv.Val += 100;
					return hsv;
				});
			}
			j = 0;
			foreach (Par par2 in but.Pars.EnumAllPar())
			{
				par2.BrushColor = but.OverColors[j];
				j++;
			}
		}

		public void SetFlag(But But, bool On)
		{
			But1 but = (But1)But;
			if (On)
			{
				this.flag = true;
				if (this.colors == null)
				{
					this.colors = new List<Color>(but.BaseColors);
				}
				int i;
				for (i = 0; i < but.BaseColors.Count; i++)
				{
					but.BaseColors[i] = this.OnColor;
					but.OverColors[i] = but.BaseColors[i].FuncHSV(delegate(Hsv hsv)
					{
						hsv.Hue += 30;
						hsv.Sat -= 30;
						hsv.Val += 100;
						return hsv;
					});
					but.PushColors[i] = but.OverColors[i].FuncHSV(delegate(Hsv hsv)
					{
						hsv.Hue += 30;
						hsv.Sat -= 30;
						hsv.Val += 100;
						return hsv;
					});
				}
				i = 0;
				using (IEnumerator<Par> enumerator = but.Pars.EnumAllPar().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Par par = enumerator.Current;
						par.BrushColor = but.BaseColors[i];
						i++;
					}
					return;
				}
			}
			this.flag = false;
			if (this.colors != null)
			{
				but.BaseColors = this.colors;
				this.colors = null;
			}
			int j;
			for (j = 0; j < but.BaseColors.Count; j++)
			{
				but.OverColors[j] = but.BaseColors[j].FuncHSV(delegate(Hsv hsv)
				{
					hsv.Hue += 30;
					hsv.Sat -= 30;
					hsv.Val += 100;
					return hsv;
				});
				but.PushColors[j] = but.OverColors[j].FuncHSV(delegate(Hsv hsv)
				{
					hsv.Hue += 30;
					hsv.Sat -= 30;
					hsv.Val += 100;
					return hsv;
				});
			}
			j = 0;
			foreach (Par par2 in but.Pars.EnumAllPar())
			{
				par2.BrushColor = but.BaseColors[j];
				j++;
			}
		}

		private bool flag;

		private Color OnColor = Color.Red;

		private List<Color> colors;
	}
}
