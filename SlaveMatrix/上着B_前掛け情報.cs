using System;

namespace SlaveMatrix
{
	[Serializable]
	public struct 上着B_前掛け情報
	{
		public void SetDefault()
		{
			this.ベ\u30FCス表示 = true;
			this.縁表示 = true;
			this.巻縁表示 = true;
			this.色.SetDefault();
		}

		public static 上着B_前掛け情報 GetDefault()
		{
			上着B_前掛け情報 result = default(上着B_前掛け情報);
			result.SetDefault();
			return result;
		}

		public bool IsShow
		{
			get
			{
				return this.ベ\u30FCス表示 || this.縁表示 || this.巻縁表示;
			}
		}

		public bool ベ\u30FCス表示;

		public bool 縁表示;

		public bool 巻縁表示;

		public 前掛けB色 色;
	}
}
