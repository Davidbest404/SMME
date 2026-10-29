using System;
using System.Collections.Generic;

namespace _2DGAMELIB
{
	[Serializable]
	public class JointS
	{
		public JointS()
		{
		}

		public JointS(Difs Difs, Par Par, int Index)
		{
			this.Difs = Difs;
			this.Path = Par.GetPath();
			this.Index = Index;
		}

		public Difs Difs;

		public List<int> Path;

		public int Index;
	}
}
