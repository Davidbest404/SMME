using System;

namespace SlaveMatrix
{
	public class 蝙隣接
	{
		public 蝙隣接(上腕_蝙 上腕, 手_蝙 手)
		{
			this.上腕 = 上腕;
			this.手 = 手;
		}

		public void 接続()
		{
			this.上腕.飛膜.接続(this.上腕, null, this.手, this.上腕.接着());
			this.手.飛膜.接続(this.上腕, null, this.手, this.手.カ\u30FCブ);
		}

		public 上腕_蝙 上腕;

		public 手_蝙 手;
	}
}
