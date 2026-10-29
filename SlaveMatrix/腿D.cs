using System;
using System.Collections.Generic;

namespace SlaveMatrix
{
	[Serializable]
	public class 腿D : EleD
	{
		public virtual void 脚接続(EleD e)
		{
		}

		public List<EleD> 脚_接続 = new List<EleD>();
	}
}
