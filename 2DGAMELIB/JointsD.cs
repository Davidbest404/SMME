using System;
using System.Collections.Generic;

namespace _2DGAMELIB
{
	[Serializable]
	public class JointsD
	{
		public void JoinP()
		{
			foreach (JointD jointD in this.Joins)
			{
				jointD.JoinP();
			}
		}

		public void JoinPA()
		{
			foreach (JointD jointD in this.Joins)
			{
				jointD.JoinPA();
			}
		}

		public void JoinPall()
		{
			foreach (JointD jointD in this.Joins)
			{
				jointD.JoinPall();
			}
		}

		public void JoinPAall()
		{
			foreach (JointD jointD in this.Joins)
			{
				jointD.JoinPAall();
			}
		}

		public List<JointD> Joins = new List<JointD>();
	}
}
