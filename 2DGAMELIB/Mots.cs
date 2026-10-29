using System;
using System.Collections.Generic;

namespace _2DGAMELIB
{
	public class Mots
	{
		public Mot this[string Name]
		{
			get
			{
				return this.ms[Name];
			}
			set
			{
				this.ms[Name] = value;
			}
		}

		public Mots()
		{
			this.ms = new Dictionary<string, Mot>();
		}

		public void Add(string Name, Mot Mot)
		{
			this.ms.Add(Name, Mot);
		}

		public void Rem(string Name)
		{
			this.ms.Remove(Name);
		}

		public void Drive(FPS FPS)
		{
			foreach (Mot mot in this.ms.Values)
			{
				mot.GetValue(FPS);
			}
		}

		public Dictionary<string, Mot> ms;
	}
}
