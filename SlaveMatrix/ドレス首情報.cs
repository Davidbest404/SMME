using System;

namespace SlaveMatrix
{
	[Serializable]
	public struct ドレス首情報
	{
		public void SetDefault()
		{
			this.ヴィオラ襟ベ\u30FCス表示 = true;
			this.ヴィオラ縁表示 = true;
			this.色.SetDefault();
		}

		public static ドレス首情報 GetDefault()
		{
			ドレス首情報 result = default(ドレス首情報);
			result.SetDefault();
			return result;
		}

		public bool ヴィオラ襟ベ\u30FCス表示;

		public bool ヴィオラ縁表示;

		public ドレス首色 色;
	}
}
