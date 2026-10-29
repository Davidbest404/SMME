using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class DE : Ele
	{
		public DE(Ele src, Action<Are> 描画)
		{
			this.Par = src;
			this.本体 = src.本体;
			this.描画 = 描画;
		}

		public override void 描画0(Are Are)
		{
			this.描画(Are);
		}

		public override void 描画1(Are Are)
		{
		}

		public override void 描画2(Are Are)
		{
		}

		public Action<Are> 描画;
	}
}
