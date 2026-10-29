using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace _2DGAMELIB
{
	[Serializable]
	public class Difs
	{
		public List<Dif> Difss
		{
			get
			{
				return this.difs;
			}
		}

		public int CountX
		{
			get
			{
				return this.difs.Count;
			}
		}

		public int CountY
		{
			get
			{
				if (this.difs.Count > 0)
				{
					return this.difs[this.IndexX].Count;
				}
				return 0;
			}
		}

		public int IndexX
		{
			get
			{
				if (this.ValueX < 1.0)
				{
					return (int)((double)this.CountX * this.ValueX);
				}
				return this.CountX - 1;
			}
			set
			{
				this.ValueX = (double)value / (double)this.CountX;
			}
		}

		public int IndexY
		{
			get
			{
				if (this.ValueY < 1.0)
				{
					return (int)((double)this.CountY * this.ValueY);
				}
				return this.CountY - 1;
			}
			set
			{
				this.ValueY = (double)value / (double)this.CountY;
			}
		}

		public IEnumerable<Par> EnumAllPar()
		{
			foreach (Dif dif in this.difs)
			{
				foreach (Par par in dif.EnumAllPar())
				{
					yield return par;
				}
				IEnumerator<Par> enumerator2 = null;
			}
			List<Dif>.Enumerator enumerator = default(List<Dif>.Enumerator);
			yield break;
			yield break;
		}

		public IEnumerable<Pars> EnumAllPars()
		{
			foreach (Dif dif in this.difs)
			{
				foreach (Pars pars in dif.Parss)
				{
					yield return pars;
				}
				List<Pars>.Enumerator enumerator2 = default(List<Pars>.Enumerator);
			}
			List<Dif>.Enumerator enumerator = default(List<Dif>.Enumerator);
			yield break;
			yield break;
		}

		public Dif this[int Index]
		{
			get
			{
				return this.difs[Index];
			}
			set
			{
				this.difs[Index] = value;
			}
		}

		public Pars Current
		{
			get
			{
				return this.difs[this.IndexX][this.IndexY];
			}
		}

		public double PositionSize
		{
			set
			{
				foreach (Dif dif in this.difs)
				{
					dif.PositionSize = value;
				}
			}
		}

		public Vector2D PositionVector
		{
			set
			{
				foreach (Dif dif in this.difs)
				{
					dif.PositionVector = value;
				}
			}
		}

		public double AngleBase
		{
			set
			{
				foreach (Dif dif in this.difs)
				{
					dif.AngleBase = value;
				}
			}
		}

		public double AngleCont
		{
			set
			{
				foreach (Dif dif in this.difs)
				{
					dif.AngleCont = value;
				}
			}
		}

		public double SizeBase
		{
			set
			{
				foreach (Dif dif in this.difs)
				{
					dif.SizeBase = value;
				}
			}
		}

		public double SizeCont
		{
			set
			{
				foreach (Dif dif in this.difs)
				{
					dif.SizeCont = value;
				}
			}
		}

		public double SizeXBase
		{
			set
			{
				foreach (Dif dif in this.difs)
				{
					dif.SizeXBase = value;
				}
			}
		}

		public double SizeXCont
		{
			set
			{
				foreach (Dif dif in this.difs)
				{
					dif.SizeXCont = value;
				}
			}
		}

		public double SizeYBase
		{
			set
			{
				foreach (Dif dif in this.difs)
				{
					dif.SizeYBase = value;
				}
			}
		}

		public double SizeYCont
		{
			set
			{
				foreach (Dif dif in this.difs)
				{
					dif.SizeYCont = value;
				}
			}
		}

		public bool Dra
		{
			set
			{
				foreach (Dif dif in this.difs)
				{
					dif.Dra = value;
				}
			}
		}

		public bool Hit
		{
			set
			{
				foreach (Dif dif in this.difs)
				{
					dif.Hit = value;
				}
			}
		}

		public void SetDefault()
		{
			foreach (Dif dif in this.difs)
			{
				dif.SetDefault();
			}
		}

		public Difs()
		{
		}

		public Difs(Difs Difs)
		{
			this.Copy(Difs);
		}

		private void Copy(Difs Difs)
		{
			this.Tag = Difs.Tag;
			this.ValueX = Difs.ValueX;
			this.ValueY = Difs.ValueY;
			foreach (Dif dif in Difs.difs)
			{
				this.difs.Add(new Dif(dif));
			}
		}

		public void Add(Dif Dif)
		{
			this.difs.Add(Dif);
		}

		public void Insert(int Index, Dif Dif)
		{
			this.difs.Insert(Index, Dif);
		}

		public void Remove(Dif Dif)
		{
			this.difs.Remove(Dif);
		}

		public void RemoveAt(int Index)
		{
			this.difs.RemoveAt(Index);
		}

		public void Draw(Are Are)
		{
			Are.Draw(this.Current);
		}

		public void Draws(Are Are)
		{
			foreach (Dif dif in this.difs)
			{
				dif.Draws(Are);
			}
		}

		public void Draw(AreM AreM)
		{
			AreM.Draw(this.Current);
		}

		public void Draws(AreM AreM)
		{
			foreach (Dif dif in this.difs)
			{
				dif.Draws(AreM);
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
			for (int i = this.difs.Count - 1; i > 0; i--)
			{
				Dif dif = this.difs[i - 1];
				Dif dif2 = this.difs[i];
				Dif dif3 = new Dif();
				dif3.Tag = dif.Tag;
				for (int j = 0; j < dif.Count; j++)
				{
					dif3.Add(dif[j].GetInter(dif2[j]));
				}
				this.difs.Insert(i, dif3);
			}
		}

		private Par GetJoinRoot(Pars ps)
		{
			Par[] array = ps.EnumAllPar().ToArray<Par>();
			if (array.Length <= 1)
			{
				return array.FirstOrDefault<Par>();
			}
			Par[] array2 = array;
			Vector2D p;
			for (int i = 0; i < array2.Length; i++)
			{
				Par p0 = array2[i];
				p = p0.Position;
				if (array.All((Par p1) => p0 == p1 || p1.JP.All((Joi j) => p1.ToGlobal(j.Joint).DistanceSquared(p) > Join.IdentityDistance)))
				{
					return p0;
				}
			}
			Par par = array.FirstOrDefault((Par e) => e.JP.Count > 0);
			if (par != null)
			{
				return par;
			}
			return array.First<Par>();
		}

		public void SetJoints()
		{
			this.pj = new Dictionary<Pars, Joints>();
			this.pr = new Dictionary<Pars, Par>();
			foreach (Pars pars in this.EnumAllPars())
			{
				Par joinRoot = this.GetJoinRoot(pars);
				if (joinRoot != null)
				{
					this.pj.Add(pars, joinRoot.GetJoints(pars.EnumAllPar()));
					this.pr.Add(pars, joinRoot);
				}
			}
		}

		public void JoinP()
		{
			this.pj[this.Current].JoinP();
		}

		public void JoinPA()
		{
			this.pj[this.Current].JoinPA();
		}

		public void JoinPall()
		{
			foreach (Joints joints in this.pj.Values)
			{
				joints.JoinP();
			}
		}

		public void JoinPAall()
		{
			foreach (Joints joints in this.pj.Values)
			{
				joints.JoinPA();
			}
		}

		public void JoinP(Pars ps)
		{
			if (this.pj.ContainsKey(ps))
			{
				this.pj[ps].JoinP();
			}
		}

		public void JoinPA(Pars ps)
		{
			if (this.pj.ContainsKey(ps))
			{
				this.pj[ps].JoinPA();
			}
		}

		public Par CurJoinRoot
		{
			get
			{
				Pars key = this.Current;
				if (this.pr.ContainsKey(key))
				{
					return this.pr[key];
				}
				return null;
			}
		}

		public IEnumerable<Par> EnumJoinRoot
		{
			get
			{
				return this.pr.Values;
			}
		}

		public Par GetHitPar_(Color HitColor)
		{
			return this.difs.FirstOrDefault((Dif d) => d.IsHit(ref HitColor)).Parss.FirstOrDefault((Pars ps) => ps.IsHit(ref HitColor)).EnumAllPar().FirstOrDefault((Par e) => e.HitColor == HitColor);
		}

		public List<string> GetHitTags(ref Color HitColor)
		{
			List<string> list = new List<string>();
			foreach (Dif dif in this.difs)
			{
				list.AddRange(dif.GetHitTags(ref HitColor));
			}
			return list;
		}

		public List<Par> GetHitPars(ref Color HitColor)
		{
			List<Par> list = new List<Par>();
			foreach (Dif dif in this.difs)
			{
				list.AddRange(dif.GetHitPars(ref HitColor));
			}
			return list;
		}

		public bool IsHit(ref Color HitColor)
		{
			using (List<Dif>.Enumerator enumerator = this.difs.GetEnumerator())
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
			this.SetJoints();
			foreach (Dif dif in this.difs)
			{
				dif.ReverseX();
			}
			this.JoinP();
		}

		public void ReverseY()
		{
			this.SetJoints();
			foreach (Dif dif in this.difs)
			{
				dif.ReverseY();
			}
			this.JoinP();
		}

		public void Dispose()
		{
			foreach (Dif dif in this.difs)
			{
				dif.Dispose();
			}
		}

		public string Tag = "";

		public double ValueX;

		public double ValueY;

		private List<Dif> difs = new List<Dif>();

		public Dictionary<Pars, Joints> pj;

		public Dictionary<Pars, Par> pr;
	}
}
