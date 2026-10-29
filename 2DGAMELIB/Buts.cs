using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace _2DGAMELIB
{
	public class Buts
	{
		public But this[string Name]
		{
			get
			{
				return this.buts[Name];
			}
		}

		public IEnumerable<But> EnumBut
		{
			get
			{
				return this.buts.Values;
			}
		}

		public void Add(string Name, But But)
		{
			this.buts.Add(Name, But);
		}

		public void Down(ref Color HitColor)
		{
			using (IEnumerator<But> enumerator = this.buts.Values.GetEnumerator())
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
			using (IEnumerator<But> enumerator = this.buts.Values.GetEnumerator())
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

		public void Move(ref Color HitColor)
		{
			foreach (But but in this.buts.Values)
			{
				but.Move(ref HitColor);
			}
		}

		public void Leave()
		{
			using (IEnumerator<But> enumerator = this.buts.Values.GetEnumerator())
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

		public void SetHitColor(Med Med)
		{
			foreach (But but in this.EnumBut)
			{
				but.SetHitColor(Med);
			}
		}

		public void Draw(Are Are)
		{
			foreach (But but in this.buts.Values)
			{
				but.Draw(Are);
			}
		}

		public void Draw(AreM AreM)
		{
			foreach (But but in this.buts.Values)
			{
				but.Draw(AreM);
			}
		}

		public void Dispose()
		{
			foreach (But but in this.buts.Values)
			{
				but.Dispose();
			}
		}

		public bool IsHit(Color hc)
		{
			return this.EnumBut.Any((But e) => e.Pars.Values.First<object>().ToPar().HitColor == hc);
		}

		private OrderedDictionary<string, But> buts = new OrderedDictionary<string, But>();
	}
}
