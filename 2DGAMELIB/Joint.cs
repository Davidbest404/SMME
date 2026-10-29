using System;

namespace _2DGAMELIB
{
	[Serializable]
	public class Joint
	{
		public Joint(Par Par0, int Index, Par Par1)
		{
			this.Par0 = Par0;
			this.Index = Index;
			this.Par1 = Par1;
		}

		public void JoinP()
		{
			this.Par0.SetJointP(this.Index, this.Par1);
		}

		public void JoinPA()
		{
			this.Par0.SetJointPA(this.Index, this.Par1);
		}

		public Par Par0;

		public int Index;

		public Par Par1;
	}
}
