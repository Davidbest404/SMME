using System;
using System.Collections.Generic;
using System.Drawing;

namespace _2DGAMELIB
{
	public class Gaus
	{
		public Gau this[string Name]
		{
			get
			{
				return this.gaus[Name];
			}
		}

		public void Add(string Name, Vector2D Position, double Size, double Width, double Height, double Margin, Open Open, Range Range, Color PlusColor, Color MinusColor, Color BackColor, bool Knob)
		{
			this.gaus.Add(Name, new Gau(Name, ref Position, Size, Width, Height, Margin, Open, Range, ref PlusColor, ref MinusColor, ref BackColor, Knob));
		}

		public void Add(string Name, Vector2D Position, double Size, double Width, double Height, double Margin, Open Open, Range Range, double DisUnit, Color PlusColor1, Color PlusColor2, Color MinusColor1, Color MinusColor2, Color BackColor, bool Knob)
		{
			this.gaus.Add(Name, new Gau(Name, ref Position, Size, Width, Height, Margin, Open, Range, DisUnit, ref PlusColor1, ref PlusColor2, ref MinusColor1, ref MinusColor2, ref BackColor, Knob));
		}

		public void SetHitColor(Med Med)
		{
			foreach (Gau gau in this.gaus.Values)
			{
				gau.SetHitColor(Med);
			}
		}

		public void Down(ref Color HitColor, ref Vector2D CursorPosition)
		{
			using (IEnumerator<Gau> enumerator = this.gaus.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Down(ref HitColor, ref CursorPosition))
					{
						break;
					}
				}
			}
		}

		public void Up()
		{
			using (IEnumerator<Gau> enumerator = this.gaus.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Up())
					{
						break;
					}
				}
			}
		}

		public void Move(ref Vector2D CursorPosition)
		{
			using (IEnumerator<Gau> enumerator = this.gaus.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Move(ref CursorPosition))
					{
						break;
					}
				}
			}
		}

		public void Leave()
		{
			using (IEnumerator<Gau> enumerator = this.gaus.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Leave())
					{
						break;
					}
				}
			}
		}

		public void Draw(Are Are)
		{
			foreach (Gau gau in this.gaus.Values)
			{
				Are.Draw(gau.Pars);
			}
		}

		public void Draw(AreM AreM)
		{
			foreach (Gau gau in this.gaus.Values)
			{
				AreM.Draw(gau.Pars);
			}
		}

		public void Dispose()
		{
			foreach (Gau gau in this.gaus.Values)
			{
				gau.Dispose();
			}
		}

		private OrderedDictionary<string, Gau> gaus = new OrderedDictionary<string, Gau>();
	}
}
