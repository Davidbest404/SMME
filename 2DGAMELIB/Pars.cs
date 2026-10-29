using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace _2DGAMELIB
{
	[Serializable]
	public class Pars
	{
		public Pars Parent
		{
			get
			{
				return this.parent;
			}
		}

		public void SetParent(Pars Parent)
		{
			this.parent = Parent;
		}

		public IEnumerable<string> Keys
		{
			get
			{
				return this.pars.Keys;
			}
		}

		public IEnumerable<object> Values
		{
			get
			{
				return this.pars.Values;
			}
		}

		public double PositionSize
		{
			set
			{
				foreach (object obj in this.pars.Values)
				{
					if (obj is Pars)
					{
						((Pars)obj).PositionSize = value;
					}
					else if (obj is Par)
					{
						((Par)obj).PositionSize = value;
					}
				}
			}
		}

		public Vector2D PositionVector
		{
			set
			{
				foreach (object obj in this.pars.Values)
				{
					if (obj is Pars)
					{
						((Pars)obj).PositionVector = value;
					}
					else if (obj is Par)
					{
						((Par)obj).PositionVector = value;
					}
				}
			}
		}

		public double AngleBase
		{
			set
			{
				foreach (object obj in this.pars.Values)
				{
					if (obj is Pars)
					{
						((Pars)obj).AngleBase = value;
					}
					else if (obj is Par)
					{
						((Par)obj).AngleBase = value;
					}
				}
			}
		}

		public double AngleCont
		{
			set
			{
				foreach (object obj in this.pars.Values)
				{
					if (obj is Pars)
					{
						((Pars)obj).AngleCont = value;
					}
					else if (obj is Par)
					{
						((Par)obj).AngleCont = value;
					}
				}
			}
		}

		public double SizeBase
		{
			set
			{
				foreach (object obj in this.pars.Values)
				{
					if (obj is Pars)
					{
						((Pars)obj).SizeBase = value;
					}
					else if (obj is Par)
					{
						((Par)obj).SizeBase = value;
					}
				}
			}
		}

		public double SizeCont
		{
			set
			{
				foreach (object obj in this.pars.Values)
				{
					if (obj is Pars)
					{
						((Pars)obj).SizeCont = value;
					}
					else if (obj is Par)
					{
						((Par)obj).SizeCont = value;
					}
				}
			}
		}

		public double SizeXBase
		{
			set
			{
				foreach (object obj in this.pars.Values)
				{
					if (obj is Pars)
					{
						((Pars)obj).SizeXBase = value;
					}
					else if (obj is Par)
					{
						((Par)obj).SizeXBase = value;
					}
				}
			}
		}

		public double SizeXCont
		{
			set
			{
				foreach (object obj in this.pars.Values)
				{
					if (obj is Pars)
					{
						((Pars)obj).SizeXCont = value;
					}
					else if (obj is Par)
					{
						((Par)obj).SizeXCont = value;
					}
				}
			}
		}

		public double SizeYBase
		{
			set
			{
				foreach (object obj in this.pars.Values)
				{
					if (obj is Pars)
					{
						((Pars)obj).SizeYBase = value;
					}
					else if (obj is Par)
					{
						((Par)obj).SizeYBase = value;
					}
				}
			}
		}

		public double SizeYCont
		{
			set
			{
				foreach (object obj in this.pars.Values)
				{
					if (obj is Pars)
					{
						((Pars)obj).SizeYCont = value;
					}
					else if (obj is Par)
					{
						((Par)obj).SizeYCont = value;
					}
				}
			}
		}

		public bool Dra
		{
			set
			{
				foreach (object obj in this.pars.Values)
				{
					if (obj is Pars)
					{
						((Pars)obj).Dra = value;
					}
					else if (obj is Par)
					{
						((Par)obj).Dra = value;
					}
				}
			}
		}

		public bool Hit
		{
			set
			{
				foreach (object obj in this.pars.Values)
				{
					if (obj is Pars)
					{
						((Pars)obj).Hit = value;
					}
					else if (obj is Par)
					{
						((Par)obj).Hit = value;
					}
				}
			}
		}

		public int IndexOf(string Name)
		{
			return this.pars.IndexOf(Name);
		}

		public int IndexOf(object obj)
		{
			return this.pars.IndexOf(obj);
		}

		public int LastIndexOf(string Name)
		{
			return this.pars.LastIndexOf(Name);
		}

		public int LastIndexOf(object obj)
		{
			return this.pars.LastIndexOf(obj);
		}

		public object this[string Name]
		{
			get
			{
				return this.pars[Name];
			}
			set
			{
				this.pars[Name] = value;
			}
		}

		public object this[int Index]
		{
			get
			{
				return this.pars[Index];
			}
			set
			{
				this.pars[Index] = value;
			}
		}

		public void Add(string Name, Par Par)
		{
			Par.SetParent(this);
			this.pars.Add(Name, Par);
		}

		public void Add(string Name, ParT ParT)
		{
			ParT.SetParent(this);
			this.pars.Add(Name, ParT);
		}

		public void Add(string Name, Pars Pars)
		{
			Pars.SetParent(this);
			this.pars.Add(Name, Pars);
		}

		public void Add(string Name, object obj)
		{
			if (obj is Pars)
			{
				((Pars)obj).SetParent(this);
			}
			else if (obj is ParT)
			{
				((ParT)obj).SetParent(this);
			}
			else if (obj is Par)
			{
				((Par)obj).SetParent(this);
			}
			this.pars.Add(Name, obj);
		}

		public void Add(Par Par)
		{
			Par.SetParent(this);
			this.pars.Add(Par.Tag, Par);
		}

		public void Add(ParT ParT)
		{
			ParT.SetParent(this);
			this.pars.Add(ParT.Tag, ParT);
		}

		public void Add(Pars Pars)
		{
			Pars.SetParent(this);
			this.pars.Add(Pars.Tag, Pars);
		}

		public void Add(object obj)
		{
			if (obj is Pars)
			{
				this.Add((Pars)obj);
				return;
			}
			if (obj is ParT)
			{
				this.Add((ParT)obj);
				return;
			}
			if (obj is Par)
			{
				this.Add((Par)obj);
			}
		}

		public void Insert(int Index, string Name, Par Par)
		{
			Par.SetParent(this);
			this.pars.Insert(Index, Name, Par);
		}

		public void Insert(int Index, string Name, ParT ParT)
		{
			ParT.SetParent(this);
			this.pars.Insert(Index, Name, ParT);
		}

		public void Insert(int Index, string Name, Pars Pars)
		{
			Pars.SetParent(this);
			this.pars.Insert(Index, Name, Pars);
		}

		public void Insert(int Index, string Name, object obj)
		{
			if (obj is Pars)
			{
				((Pars)obj).SetParent(this);
			}
			else if (obj is ParT)
			{
				((ParT)obj).SetParent(this);
			}
			else if (obj is Par)
			{
				((Par)obj).SetParent(this);
			}
			this.pars.Insert(Index, Name, obj);
		}

		public void Remove(string Name)
		{
			object obj = this.pars[Name];
			if (obj is Pars)
			{
				((Pars)obj).SetParent(null);
			}
			else if (obj is ParT)
			{
				((ParT)obj).SetParent(null);
			}
			else if (obj is Par)
			{
				((Par)obj).SetParent(null);
			}
			this.pars.Remove(Name);
		}

		public IEnumerable<Par> EnumAllPar()
		{
			foreach (object obj in this.pars.Values)
			{
				if (obj is Pars)
				{
					foreach (Par par in ((Pars)obj).EnumAllPar())
					{
						yield return par;
					}
					IEnumerator<Par> enumerator2 = null;
				}
				else if (obj is Par)
				{
					yield return (Par)obj;
				}
			}
			IEnumerator<object> enumerator = null;
			yield break;
			yield break;
		}

		public void SetDefault()
		{
			foreach (object obj in this.pars.Values)
			{
				if (obj is Pars)
				{
					((Pars)obj).SetDefault();
				}
				else if (obj is ParT)
				{
					((ParT)obj).SetDefault();
				}
				else if (obj is Par)
				{
					((Par)obj).SetDefault();
				}
			}
		}

		public Pars()
		{
		}

		public Pars(Par Par)
		{
			this.Tag = Par.Tag;
			this.Add(Par.Tag, Par);
		}

		public Pars(ParT ParT)
		{
			this.Tag = ParT.Tag;
			this.Add(ParT.Tag, ParT);
		}

		public Pars(Pars Pars)
		{
			this.Copy(Pars);
		}

		private void Copy(Pars Pars)
		{
			this.Tag = Pars.Tag;
			foreach (string text in Pars.pars.Keys)
			{
				object obj = Pars.pars[text];
				if (obj is Pars)
				{
					this.Add(text, ((Pars)obj).Clone());
				}
				else if (obj is ParT)
				{
					this.Add(text, new ParT((ParT)obj));
				}
				else if (obj is Par)
				{
					this.Add(text, new Par((Par)obj));
				}
			}
		}

		private Pars Clone()
		{
			Pars pars = new Pars();
			pars.Tag = this.Tag;
			foreach (string text in this.pars.Keys)
			{
				object obj = this.pars[text];
				if (obj is Pars)
				{
					pars.Add(text, ((Pars)obj).Clone());
				}
				else if (obj is ParT)
				{
					pars.Add(text, new ParT((ParT)obj));
				}
				else if (obj is Par)
				{
					pars.Add(text, new Par((Par)obj));
				}
			}
			return pars;
		}

		public void Draw(double Unit, Graphics Graphics)
		{
			foreach (object obj in this.pars.Values)
			{
				if (obj is Pars)
				{
					((Pars)obj).Draw(Unit, Graphics);
				}
				else if (obj is ParT)
				{
					((ParT)obj).Draw(Unit, Graphics);
				}
				else if (obj is Par)
				{
					((Par)obj).Draw(Unit, Graphics);
				}
			}
		}

		public void DrawH(double Unit, Graphics Graphics)
		{
			foreach (object obj in this.pars.Values)
			{
				if (obj is Pars)
				{
					((Pars)obj).DrawH(Unit, Graphics);
				}
				else if (obj is Par)
				{
					((Par)obj).DrawH(Unit, Graphics);
				}
			}
		}

		public Pars GetInter(Pars Pars)
		{
			Pars pars = new Pars();
			pars.Tag = this.Tag;
			string[] array = this.pars.Keys.ToArray<string>();
			string[] array2 = Pars.pars.Keys.ToArray<string>();
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i];
				string key = array2[i];
				object obj = this.pars[text];
				object obj2 = Pars.pars[key];
				if (obj is Pars)
				{
					pars.Add(text, ((Pars)obj).GetInter((Pars)obj2));
				}
				else if (obj is ParT)
				{
					pars.Add(text, ((ParT)obj).GetInter((ParT)obj2));
				}
				else if (obj is Par)
				{
					pars.Add(text, ((Par)obj).GetInter((Par)obj2));
				}
			}
			return pars;
		}

		public List<string> GetHitTags(ref Color HitColor)
		{
			List<string> list = new List<string>();
			foreach (object obj in this.pars.Values)
			{
				Par par;
				if (obj is Pars)
				{
					list.AddRange(((Pars)obj).GetHitTags(ref HitColor));
				}
				else if (obj is Par && (par = (Par)obj).HitColor == HitColor)
				{
					list.Add(par.Tag);
				}
			}
			return list;
		}

		public List<Par> GetHitPars(ref Color HitColor)
		{
			List<Par> list = new List<Par>();
			foreach (object obj in this.pars.Values)
			{
				Par item;
				if (obj is Pars)
				{
					list.AddRange(((Pars)obj).GetHitPars(ref HitColor));
				}
				else if (obj is Par && (item = (Par)obj).HitColor == HitColor)
				{
					list.Add(item);
				}
			}
			return list;
		}

		public bool IsHit(ref Color HitColor)
		{
			foreach (object obj in this.pars.Values)
			{
				if (obj is Pars && ((Pars)obj).IsHit(ref HitColor))
				{
					return true;
				}
				if (obj is Par && ((Par)obj).HitColor == HitColor)
				{
					return true;
				}
			}
			return false;
		}

		public Par GetPar(List<int> Path)
		{
			return this.GetPar(0, Path);
		}

		private Par GetPar(int l, List<int> Path)
		{
			object obj = this.pars[Path[l]];
			if (obj is Pars)
			{
				return ((Pars)obj).GetPar(l + 1, Path);
			}
			return (Par)obj;
		}

		public Pars GetRoot()
		{
			Pars pars = this.parent;
			while (pars.Parent != null)
			{
				pars = pars.Parent;
			}
			return pars;
		}

		public void ReverseX()
		{
			foreach (object obj in this.pars.Values)
			{
				if (obj is Pars)
				{
					((Pars)obj).ReverseX();
				}
				else if (obj is Par)
				{
					((Par)obj).ReverseX();
				}
			}
		}

		public void ReverseY()
		{
			foreach (object obj in this.pars.Values)
			{
				if (obj is Pars)
				{
					((Pars)obj).ReverseY();
				}
				else if (obj is Par)
				{
					((Par)obj).ReverseY();
				}
			}
		}

		public bool IsParentTag(string Tag)
		{
			return this.Parent != null && this.Parent.Tag == Tag;
		}

		public bool IsRootTag(string Tag)
		{
			Pars root = this.GetRoot();
			return root != null && root.Tag == Tag;
		}

		public bool ContainsParentTag(string Tag)
		{
			return this.Parent != null && this.Parent.Tag.Contains(Tag);
		}

		public bool ContainsRootTag(string Tag)
		{
			Pars root = this.GetRoot();
			return root != null && root.Tag.Contains(Tag);
		}

		public void ScalingXY(double Scale)
		{
			foreach (Par par in this.EnumAllPar())
			{
				par.ScalingXY(Scale);
				par.ScalingXY(Scale);
			}
		}

		public void ScalingX(double Scale)
		{
			foreach (Par par in this.EnumAllPar())
			{
				par.ScalingX(Scale);
				par.ScalingX(Scale);
			}
		}

		public void ScalingY(double Scale)
		{
			foreach (Par par in this.EnumAllPar())
			{
				par.ScalingY(Scale);
				par.ScalingY(Scale);
			}
		}

		public void ExpansionXY(double Rate)
		{
			foreach (Par par in this.EnumAllPar())
			{
				par.ExpansionXY(Rate);
				par.ExpansionXY(Rate);
			}
		}

		public void ExpansionX(double Rate)
		{
			foreach (Par par in this.EnumAllPar())
			{
				par.ExpansionX(Rate);
				par.ExpansionX(Rate);
			}
		}

		public void ExpansionY(double Rate)
		{
			foreach (Par par in this.EnumAllPar())
			{
				par.ExpansionY(Rate);
				par.ExpansionY(Rate);
			}
		}

		public void Dispose()
		{
			foreach (object obj in this.pars.Values)
			{
				if (obj is Pars)
				{
					((Pars)obj).Dispose();
				}
				else if (obj is ParT)
				{
					((ParT)obj).Dispose();
				}
				else if (obj is Par)
				{
					((Par)obj).Dispose();
				}
			}
		}

		private Pars parent;

		public string Tag = "";

		public OrderedDictionary<string, object> pars = new OrderedDictionary<string, object>();
	}
}
