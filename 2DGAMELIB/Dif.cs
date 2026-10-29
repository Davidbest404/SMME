using System;
using System.Collections.Generic;
using System.Drawing;

namespace _2DGAMELIB
{
	[Serializable]
	public class Dif
	{
		public List<Pars> Parss
		{
			get
			{
				return this.parss;
			}
		}

		public int Count
		{
			get
			{
				return this.parss.Count;
			}
		}

		public IEnumerable<Par> EnumAllPar()
		{
			foreach (Pars pars in this.parss)
			{
				foreach (Par par in pars.EnumAllPar())
				{
					yield return par;
				}
				IEnumerator<Par> enumerator2 = null;
			}
			List<Pars>.Enumerator enumerator = default(List<Pars>.Enumerator);
			yield break;
			yield break;
		}

		public Pars this[int Index]
		{
			get
			{
				return this.parss[Index];
			}
			set
			{
				this.parss[Index] = value;
			}
		}

		public double PositionSize
		{
			set
			{
				foreach (Pars pars in this.parss)
				{
					pars.PositionSize = value;
				}
			}
		}

		public Vector2D PositionVector
		{
			set
			{
				foreach (Pars pars in this.parss)
				{
					pars.PositionVector = value;
				}
			}
		}

		public double AngleBase
		{
			set
			{
				foreach (Pars pars in this.parss)
				{
					pars.AngleBase = value;
				}
			}
		}

		public double AngleCont
		{
			set
			{
				foreach (Pars pars in this.parss)
				{
					pars.AngleCont = value;
				}
			}
		}

		public double SizeBase
		{
			set
			{
				foreach (Pars pars in this.parss)
				{
					pars.SizeBase = value;
				}
			}
		}

		public double SizeCont
		{
			set
			{
				foreach (Pars pars in this.parss)
				{
					pars.SizeCont = value;
				}
			}
		}

		public double SizeXBase
		{
			set
			{
				foreach (Pars pars in this.parss)
				{
					pars.SizeXBase = value;
				}
			}
		}

		public double SizeXCont
		{
			set
			{
				foreach (Pars pars in this.parss)
				{
					pars.SizeXCont = value;
				}
			}
		}

		public double SizeYBase
		{
			set
			{
				foreach (Pars pars in this.parss)
				{
					pars.SizeYBase = value;
				}
			}
		}

		public double SizeYCont
		{
			set
			{
				foreach (Pars pars in this.parss)
				{
					pars.SizeYCont = value;
				}
			}
		}

		public bool Dra
		{
			set
			{
				foreach (Pars pars in this.parss)
				{
					pars.Dra = value;
				}
			}
		}

		public bool Hit
		{
			set
			{
				foreach (Pars pars in this.parss)
				{
					pars.Hit = value;
				}
			}
		}

		public void SetDefault()
		{
			foreach (Pars pars in this.parss)
			{
				pars.SetDefault();
			}
		}

		public Dif()
		{
		}

		public Dif(Dif Dif)
		{
			this.Copy(Dif);
		}

		private void Copy(Dif Dif)
		{
			this.Tag = Dif.Tag;
			foreach (Pars pars in Dif.parss)
			{
				this.parss.Add(new Pars(pars));
			}
		}

		public void Add(Pars Pars)
		{
			this.parss.Add(Pars);
		}

		public void Insert(int Index, Pars Pars)
		{
			this.parss.Insert(Index, Pars);
		}

		public void Remove(Pars Pars)
		{
			this.parss.Remove(Pars);
		}

		public void RemoveAt(int Index)
		{
			this.parss.RemoveAt(Index);
		}

		public void Draws(Are Are)
		{
			foreach (Pars pars in this.parss)
			{
				Are.Draw(pars);
			}
		}

		public void Draws(AreM AreM)
		{
			foreach (Pars pars in this.parss)
			{
				AreM.Draw(pars);
			}
		}

		public void Inter(int Num)
		{
			for (int i = 0; i < Num; i++)
			{
				this.Inter();
			}
		}

		private void Inter()
		{
			for (int i = this.parss.Count - 1; i > 0; i--)
			{
				this.parss.Insert(i, this.parss[i - 1].GetInter(this.parss[i]));
			}
		}

		public List<string> GetHitTags(ref Color HitColor)
		{
			List<string> list = new List<string>();
			foreach (Pars pars in this.parss)
			{
				list.AddRange(pars.GetHitTags(ref HitColor));
			}
			return list;
		}

		public List<Par> GetHitPars(ref Color HitColor)
		{
			List<Par> list = new List<Par>();
			foreach (Pars pars in this.parss)
			{
				list.AddRange(pars.GetHitPars(ref HitColor));
			}
			return list;
		}

		public bool IsHit(ref Color HitColor)
		{
			using (List<Pars>.Enumerator enumerator = this.parss.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsHit(ref HitColor))
					{
						return true;
					}
				}
			}
			return false;
		}

		public void ReverseX()
		{
			foreach (Pars pars in this.parss)
			{
				pars.ReverseX();
			}
		}

		public void ReverseY()
		{
			foreach (Pars pars in this.parss)
			{
				pars.ReverseY();
			}
		}

		public void Dispose()
		{
			foreach (Pars pars in this.parss)
			{
				pars.Dispose();
			}
		}

		public string Tag = "";

		private List<Pars> parss = new List<Pars>();
	}
}
