using System;
using System.Collections.Generic;
using System.Drawing;

namespace _2DGAMELIB
{
	public class Texs
	{
		public Tex this[string Name]
		{
			get
			{
				return this.plas[Name];
			}
		}

		public void Add(string Name, Vector2D Position, double Size, double Width, double Height, Font Font, double TextSize, int Space, string Text, Color TextColor, Color ShadColor, Color BackColor, double Speed, Color FeedColor, Action<Tex> Action)
		{
			this.plas.Add(Name, new Tex(Name, ref Position, Size, Width, Height, Font, TextSize, Space, Text, ref TextColor, ref ShadColor, ref BackColor, Speed, ref FeedColor, Action));
		}

		public void Add(string Name, ref Vector2D Position, double Size, double Width, double Height, Font Font, double TextSize, int Space, string Text, ref Color TextColor, ref Color ShadColor, ref Color BackColor, double Speed, ref Color FeedColor, Action<Tex> Action)
		{
			this.plas.Add(Name, new Tex(Name, ref Position, Size, Width, Height, Font, TextSize, Space, Text, ref TextColor, ref ShadColor, ref BackColor, Speed, ref FeedColor, Action));
		}

		public void Add(string Name, Vector2D Position, double Size, double Width, double Height, Font Font, double TextSize, int Space, string Text, Color TextColor, Color ShadColor, Color BackColor, double Speed)
		{
			this.plas.Add(Name, new Tex(Name, ref Position, Size, Width, Height, Font, TextSize, Space, Text, ref TextColor, ref ShadColor, ref BackColor, Speed));
		}

		public void Add(string Name, ref Vector2D Position, double Size, double Width, double Height, Font Font, double TextSize, int Space, string Text, ref Color TextColor, ref Color ShadColor, ref Color BackColor, double Speed)
		{
			this.plas.Add(Name, new Tex(Name, ref Position, Size, Width, Height, Font, TextSize, Space, Text, ref TextColor, ref ShadColor, ref BackColor, Speed));
		}

		public void Down(ref Color HitColor)
		{
			using (IEnumerator<Tex> enumerator = this.plas.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Down(ref HitColor))
					{
						break;
					}
				}
			}
		}

		public void Up(ref Color HitColor)
		{
			using (IEnumerator<Tex> enumerator = this.plas.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Up(ref HitColor))
					{
						break;
					}
				}
			}
		}

		public void Progression(FPS FPS)
		{
			foreach (Tex tex in this.plas.Values)
			{
				tex.Progression(FPS);
			}
		}

		public void SetHitColor(Med Med)
		{
			foreach (Tex tex in this.plas.Values)
			{
				tex.SetHitColor(Med);
			}
		}

		public void Draw(Are Are)
		{
			foreach (Tex tex in this.plas.Values)
			{
				Are.Draw(tex.Pars);
			}
		}

		public void Draw(AreM AreM)
		{
			foreach (Tex tex in this.plas.Values)
			{
				AreM.Draw(tex.Pars);
			}
		}

		public void Draw(Are Are, FPS FPS)
		{
			foreach (Tex tex in this.plas.Values)
			{
				tex.Progression(FPS);
				Are.Draw(tex.Pars);
			}
		}

		public void Draw(AreM AreM, FPS FPS)
		{
			foreach (Tex tex in this.plas.Values)
			{
				tex.Progression(FPS);
				AreM.Draw(tex.Pars);
			}
		}

		public void Dispose()
		{
			foreach (Tex tex in this.plas.Values)
			{
				tex.Dispose();
			}
		}

		private OrderedDictionary<string, Tex> plas = new OrderedDictionary<string, Tex>();
	}
}
