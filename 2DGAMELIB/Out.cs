using System;
using System.Collections.Generic;

namespace _2DGAMELIB
{
	[Serializable]
	public class Out
	{
		public Out()
		{
		}

		public Out(Out Out)
		{
			this.ps = new List<Vector2D>(Out.ps);
			this.Tension = Out.Tension;
			this.Outline = Out.Outline;
		}

		public List<Vector2D> ps = new List<Vector2D>();

		public float Tension = 0.5f;

		public bool Outline = true;
	}
}
