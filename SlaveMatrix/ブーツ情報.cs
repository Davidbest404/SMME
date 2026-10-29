using System;

namespace SlaveMatrix
{
	[Serializable]
	public struct ブ\u30FCツ情報
	{
		public void SetDefault()
		{
			this.脚.SetDefault();
			this.足.SetDefault();
			this.色.SetDefault();
		}

		public static ブ\u30FCツ情報 GetDefault()
		{
			ブ\u30FCツ情報 result = default(ブ\u30FCツ情報);
			result.SetDefault();
			return result;
		}

		public ブ\u30FCツ_脚情報 脚;

		public ブ\u30FCツ_足情報 足;

		public ブ\u30FCツ色 色;
	}
}
