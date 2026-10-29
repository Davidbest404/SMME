using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public struct 接触D
	{
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				("接触:" + this.c).ToString(),
				"\r\n",
				("Ele:" + ((this.e == null) ? "null" : this.e.ToString())).ToString(),
				"\r\n",
				("Par:" + ((this.p == null) ? "null" : this.p.ToString())).ToString()
			});
		}

		public 接触 c;

		public Ele e;

		public Par p;
	}
}
