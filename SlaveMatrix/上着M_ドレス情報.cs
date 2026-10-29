using System;

namespace SlaveMatrix
{
	[Serializable]
	public struct 上着M_ドレス情報
	{
		public void SetDefault()
		{
			this.ベ\u30FCス表示 = true;
			this.縁表示 = true;
			this.柄1表示 = true;
			this.柄2表示 = true;
			this.柄3表示 = true;
		}

		public bool IsShow
		{
			get
			{
				return this.ベ\u30FCス表示 || this.縁表示 || this.柄1表示 || this.柄2表示 || this.柄3表示;
			}
		}

		public bool ベ\u30FCス表示;

		public bool 縁表示;

		public bool 柄1表示;

		public bool 柄2表示;

		public bool 柄3表示;
	}
}
