using System;
using System.Collections.Generic;

namespace _2DGAMELIB
{
	[Serializable]
	public class Joints
	{
		public void JoinP()
		{
			foreach (Joint joint in this.Joins)
			{
				joint.JoinP();
			}
		}

		public void JoinPA()
		{
			foreach (Joint joint in this.Joins)
			{
				joint.JoinPA();
			}
		}

		public List<Joint> Joins = new List<Joint>();
	}
}
