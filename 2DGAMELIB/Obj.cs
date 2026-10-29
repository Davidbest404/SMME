using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace _2DGAMELIB
{
	[Serializable]
	public class Obj
	{
		public IEnumerable<string> Keys
		{
			get
			{
				return this.Difss.Keys;
			}
		}

		public IEnumerable<Difs> Values
		{
			get
			{
				return this.Difss.Values;
			}
		}

		public IEnumerable<Par> EnumAllPar()
		{
			foreach (Difs difs in this.Difss.Values)
			{
				foreach (Par par in difs.EnumAllPar())
				{
					yield return par;
				}
				IEnumerator<Par> enumerator2 = null;
			}
			IEnumerator<Difs> enumerator = null;
			yield break;
			yield break;
		}

		public Difs this[string Name]
		{
			get
			{
				return this.Difss[Name];
			}
			set
			{
				this.Difss[Name] = value;
			}
		}

		public Difs this[int Index]
		{
			get
			{
				return this.Difss[Index];
			}
			set
			{
				this.Difss[Index] = value;
			}
		}

		public double PositionSize
		{
			set
			{
				foreach (Difs difs in this.Difss.Values)
				{
					difs.PositionSize = value;
				}
			}
		}

		public Vector2D PositionVector
		{
			set
			{
				foreach (Difs difs in this.Difss.Values)
				{
					difs.PositionVector = value;
				}
			}
		}

		public double AngleBase
		{
			set
			{
				foreach (Difs difs in this.Difss.Values)
				{
					difs.AngleBase = value;
				}
			}
		}

		public double AngleCont
		{
			set
			{
				foreach (Difs difs in this.Difss.Values)
				{
					difs.AngleCont = value;
				}
			}
		}

		public double SizeBase
		{
			set
			{
				foreach (Difs difs in this.Difss.Values)
				{
					difs.SizeBase = value;
				}
			}
		}

		public double SizeCont
		{
			set
			{
				foreach (Difs difs in this.Difss.Values)
				{
					difs.SizeCont = value;
				}
			}
		}

		public double SizeXBase
		{
			set
			{
				foreach (Difs difs in this.Difss.Values)
				{
					difs.SizeXBase = value;
				}
			}
		}

		public double SizeXCont
		{
			set
			{
				foreach (Difs difs in this.Difss.Values)
				{
					difs.SizeXCont = value;
				}
			}
		}

		public double SizeYBase
		{
			set
			{
				foreach (Difs difs in this.Difss.Values)
				{
					difs.SizeYBase = value;
				}
			}
		}

		public double SizeYCont
		{
			set
			{
				foreach (Difs difs in this.Difss.Values)
				{
					difs.SizeYCont = value;
				}
			}
		}

		public bool Dra
		{
			set
			{
				foreach (Difs difs in this.Difss.Values)
				{
					difs.Dra = value;
				}
			}
		}

		public bool Hit
		{
			set
			{
				foreach (Difs difs in this.Difss.Values)
				{
					difs.Hit = value;
				}
			}
		}

		public void SetDefault()
		{
			foreach (Difs difs in this.Difss.Values)
			{
				difs.SetDefault();
			}
		}

		public Obj SetDefaultR()
		{
			foreach (Difs difs in this.Difss.Values)
			{
				difs.SetDefault();
			}
			return this;
		}

		public Obj()
		{
		}

		public Obj(Obj Obj)
		{
			this.Copy(Obj);
		}

		private void Copy(Obj Obj)
		{
			this.Tag = Obj.Tag;
			foreach (string key in Obj.Difss.Keys)
			{
				this.Difss.Add(key, new Difs(Obj.Difss[key]));
			}
		}

		public void Add(string Name, Difs Difs)
		{
			this.Difss.Add(Name, Difs);
		}

		public void Add(Difs Difs)
		{
			this.Difss.Add(Difs.Tag, Difs);
		}

		public void Insert(int Index, string Name, Difs Difs)
		{
			this.Difss.Insert(Index, Name, Difs);
		}

		public void Remove(string Name)
		{
			this.Difss.Remove(Name);
		}

		public void Draw(Are Are)
		{
			foreach (Difs difs in this.Difss.Values)
			{
				difs.Draw(Are);
			}
		}

		public void Draws(Are Are)
		{
			foreach (Difs difs in this.Difss.Values)
			{
				difs.Draws(Are);
			}
		}

		public void Draw(AreM AreM)
		{
			foreach (Difs difs in this.Difss.Values)
			{
				difs.Draw(AreM);
			}
		}

		public void Draws(AreM AreM)
		{
			foreach (Difs difs in this.Difss.Values)
			{
				difs.Draws(AreM);
			}
		}

		public Difs JoinRoot
		{
			get
			{
				return this.r;
			}
		}

		private Difs GetJoinRootDifs()
		{
			Difs[] array = this.Difss.Values.ToArray<Difs>();
			if (array.Length <= 1)
			{
				return array.FirstOrDefault<Difs>();
			}
			Par[] pa = this.EnumAllPar().ToArray<Par>();
			Vector2D p;
			Func<Par, bool> <>9__0;
			foreach (Difs difs in array)
			{
				IEnumerable<Par> enumJoinRoot = difs.EnumJoinRoot;
				Func<Par, bool> predicate;
				if ((predicate = <>9__0) == null)
				{
					predicate = (<>9__0 = delegate(Par p0)
					{
						p = p0.Position;
						return pa.All((Par p1) => p0 == p1 || p1.JP.All((Joi j) => p1.ToGlobal(j.Joint).DistanceSquared(p) > Join.IdentityDistance));
					});
				}
				if (enumJoinRoot.All(predicate))
				{
					return difs;
				}
			}
			return array.First<Difs>();
		}

		public void SetJoints()
		{
			Difs[] array = this.Difss.Values.ToArray<Difs>();
			Difs[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].SetJoints();
			}
			this.r = this.GetJoinRootDifs();
			if (this.r != null)
			{
				this.jsd = this.r.GetJointsD(array);
			}
		}

		public void SetJoints(string Name)
		{
			Difs[] array = this.Difss.Values.ToArray<Difs>();
			Difs[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].SetJoints();
			}
			this.r = this.Difss[Name];
			if (this.r != null)
			{
				this.jsd = this.r.GetJointsD(array);
			}
		}

		public void JoinP()
		{
			if (this.r != null)
			{
				this.r.JoinPA();
				this.jsd.JoinP();
			}
		}

		public void JoinPA()
		{
			if (this.r != null)
			{
				this.r.JoinPA();
				this.jsd.JoinPA();
			}
		}

		public void JoinPall()
		{
			if (this.r != null)
			{
				this.r.JoinPA();
				this.jsd.JoinPall();
			}
		}

		public void JoinPAall()
		{
			if (this.r != null)
			{
				this.r.JoinPA();
				this.jsd.JoinPAall();
			}
		}

		public HashSet<string> GetHitDifsTagsCur(ref Color HitColor)
		{
			HashSet<string> hashSet = new HashSet<string>();
			foreach (Difs difs in this.Values)
			{
				if (difs.Current.IsHit(ref HitColor))
				{
					hashSet.Add(difs.Tag);
				}
			}
			return hashSet;
		}

		public List<Difs> GetHitDifssCur(ref Color HitColor)
		{
			List<Difs> list = new List<Difs>();
			foreach (Difs difs in this.Values)
			{
				if (difs.Current.IsHit(ref HitColor))
				{
					list.Add(difs);
				}
			}
			return list;
		}

		public HashSet<string> GetHitParTagsCur(ref Color HitColor)
		{
			HashSet<string> hashSet = new HashSet<string>();
			foreach (Difs difs in this.Values)
			{
				foreach (string item in difs.Current.GetHitTags(ref HitColor))
				{
					hashSet.Add(item);
				}
			}
			return hashSet;
		}

		public List<Par> GetHitParsCur(ref Color HitColor)
		{
			List<Par> list = new List<Par>();
			foreach (Difs difs in this.Values)
			{
				list.AddRange(difs.Current.GetHitPars(ref HitColor));
			}
			return list;
		}

		public bool IsHitCur(ref Color HitColor)
		{
			using (IEnumerator<Difs> enumerator = this.Values.GetEnumerator())
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

		public HashSet<string> GetHitDifsTags(ref Color HitColor)
		{
			HashSet<string> hashSet = new HashSet<string>();
			foreach (Difs difs in this.Values)
			{
				if (difs.IsHit(ref HitColor))
				{
					hashSet.Add(difs.Tag);
				}
			}
			return hashSet;
		}

		public List<Difs> GetHitDifss(ref Color HitColor)
		{
			List<Difs> list = new List<Difs>();
			foreach (Difs difs in this.Values)
			{
				if (difs.IsHit(ref HitColor))
				{
					list.Add(difs);
				}
			}
			return list;
		}

		public HashSet<string> GetHitParTags(ref Color HitColor)
		{
			HashSet<string> hashSet = new HashSet<string>();
			foreach (Difs difs in this.Values)
			{
				foreach (string item in difs.GetHitTags(ref HitColor))
				{
					hashSet.Add(item);
				}
			}
			return hashSet;
		}

		public List<Par> GetHitPars(ref Color HitColor)
		{
			List<Par> list = new List<Par>();
			foreach (Difs difs in this.Values)
			{
				list.AddRange(difs.GetHitPars(ref HitColor));
			}
			return list;
		}

		public bool IsHit(ref Color HitColor)
		{
			using (IEnumerator<Difs> enumerator = this.Values.GetEnumerator())
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

		public void Symmetrization(string[] Names)
		{
			Difs[] array = this.Difss.Values.ToArray<Difs>();
			Difs[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].SetJoints();
			}
			JointsD jointsD = this.GetJoinRootDifs().GetJointsD(array);
			foreach (string name in Names)
			{
				this.symmetrization(name, array, jointsD);
			}
		}

		public void Symmetrization(string Name, string[] Names)
		{
			Difs[] array = this.Difss.Values.ToArray<Difs>();
			Difs[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].SetJoints();
			}
			JointsD jointsD = this.Difss[Name].GetJointsD(array);
			foreach (string name in Names)
			{
				this.symmetrization(name, array, jointsD);
			}
		}

		private void symmetrization(string Name, Difs[] da, JointsD jsdb)
		{
			Difs difs = this.Difss[Name];
			JointsD jointsD = difs.GetJointsD(da);
			Difs difs2 = new Difs(difs);
			difs2.SetJoints();
			difs2.ReverseX();
			this.TagReplace(difs2);
			this.SetPos(difs2, this.GetSymPos(difs, jsdb) - difs2.CurJoinRoot.Position);
			foreach (Pars ps in difs2.EnumAllPars())
			{
				difs2.JoinP(ps);
			}
			this.Difss.Add(difs2.Tag, difs2);
			string key = null;
			foreach (JointD jointD in jointsD.Joins)
			{
				difs2 = new Difs(jointD.Difs1);
				difs2.SetJoints();
				difs2.ReverseX();
				this.TagReplace(difs2);
				if (jointD.Difs0.Tag.Contains("左"))
				{
					key = jointD.Difs0.Tag.Replace("左", "右");
				}
				else if (jointD.Difs0.Tag.Contains("右"))
				{
					key = jointD.Difs0.Tag.Replace("右", "左");
				}
				Par par = this.Difss[key].Current.GetPar(jointD.Path0);
				this.SetPos(difs2, par.ToGlobal(par.JP[jointD.Index].Joint) - difs2.CurJoinRoot.Position);
				foreach (Pars ps2 in difs2.EnumAllPars())
				{
					difs2.JoinP(ps2);
				}
				this.Difss.Add(difs2.Tag, difs2);
			}
		}

		private void TagReplace(Difs ds)
		{
			if (ds.Tag.Contains("左"))
			{
				ds.Tag = ds.Tag.Replace("左", "右");
				return;
			}
			if (ds.Tag.Contains("右"))
			{
				ds.Tag = ds.Tag.Replace("右", "左");
			}
		}

		private Vector2D GetSymPos(Difs r, JointsD jsdb)
		{
			JointD jointD = null;
			foreach (JointD jointD2 in jsdb.Joins)
			{
				if (jointD2.Difs1 == r)
				{
					jointD = jointD2;
					break;
				}
			}
			Vector2D position = r.CurJoinRoot.Position;
			Par par = jointD.Difs0.Current.GetPar(jointD.Path0);
			Joi joi = par.JP[jointD.Index];
			foreach (Joi joi2 in par.JP)
			{
				Vector2D vector2D = par.ToGlobal(joi2.Joint);
				if (joi2 != joi && Math.Abs(vector2D.Y - position.Y) < 1E-06)
				{
					return vector2D;
				}
			}
			return Dat.Vec2DZero;
		}

		private void SetPos(Difs ds, Vector2D v)
		{
			foreach (Par par in ds.EnumAllPar())
			{
				par.PositionBase += v;
			}
		}

		public void Dispose()
		{
			foreach (Difs difs in this.Difss.Values)
			{
				difs.Dispose();
			}
		}

		public string Tag = "";

		private OrderedDictionary<string, Difs> Difss = new OrderedDictionary<string, Difs>();

		private Difs r;

		private JointsD jsd;
	}
}
