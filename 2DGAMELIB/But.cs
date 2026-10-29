using System;
using System.Drawing;

namespace _2DGAMELIB
{
	public class But
	{
		public bool Dra
		{
			get
			{
				return this.dra;
			}
			set
			{
				this.Move(ref this.hc);
				this.dra = value;
			}
		}

		public Pars Pars
		{
			get
			{
				return this.pars;
			}
		}

		public But(Par Par, Action<But> Action)
		{
			this.pars = new Pars(Par);
			this.Action = Action;
		}

		public But(ParT ParT, Action<But> Action)
		{
			this.pars = new Pars(ParT);
			this.Action = Action;
		}

		public But(Pars Pars, Action<But> Action)
		{
			this.pars = Pars;
			this.Action = Action;
		}

		public bool Move(ref Color HitColor)
		{
			if (this.Dra && !this.f2 && this.pars.IsHit(ref HitColor))
			{
				this.f2 = true;
				this.Over(this);
				return true;
			}
			if (this.Dra && this.f2 && !this.pars.IsHit(ref HitColor))
			{
				this.f1 = false;
				this.f2 = false;
				this.Out(this);
				return true;
			}
			return false;
		}

		public bool Leave()
		{
			if (this.Dra && this.f2)
			{
				this.f1 = false;
				this.f2 = false;
				this.Out(this);
				return true;
			}
			return false;
		}

		public bool Down(ref Color HitColor)
		{
			if (this.Dra && !this.f1 && this.pars.IsHit(ref HitColor))
			{
				this.f1 = true;
				this.Push(this);
				return true;
			}
			return false;
		}

		public bool Up(ref Color HitColor)
		{
			if (this.Dra && this.f1 && this.pars.IsHit(ref HitColor))
			{
				this.f1 = false;
				this.Release(this);
				this.Action(this);
				return true;
			}
			return false;
		}

		public void Draw(Are Are)
		{
			if (this.dra)
			{
				Are.Draw(this.pars);
			}
		}

		public void Draw(AreM AreM)
		{
			if (this.dra)
			{
				AreM.Draw(this.pars);
			}
		}

		public void SetHitColor(Med Med)
		{
			foreach (Par par in this.pars.EnumAllPar())
			{
				if (par.HitColor != Color.Transparent)
				{
					Med.RemUniqueColor(par.HitColor);
				}
				par.HitColor = Med.GetUniqueColor();
			}
		}

		public void Dispose()
		{
			this.pars.Dispose();
		}

		public bool IsBut1()
		{
			return this is But1;
		}

		public But1 ToBut1()
		{
			return (But1)this;
		}

		private bool dra = true;

		private Color hc = Color.Transparent;

		protected Pars pars;

		protected Action<But> Over = delegate(But b)
		{
		};

		protected Action<But> Push = delegate(But b)
		{
		};

		protected Action<But> Release = delegate(But b)
		{
		};

		protected Action<But> Out = delegate(But b)
		{
		};

		public Action<But> Action = delegate(But b)
		{
		};

		private bool f1;

		private bool f2;
	}
}
