using System;

namespace SlaveMatrix
{
	[Serializable]
	public struct ピアス情報
	{
		public void SetDefault()
		{
			this.ピアス_表示 = true;
			this.色.SetDefault();
		}

		public static ピアス情報 GetDefault()
		{
			ピアス情報 result = default(ピアス情報);
			result.SetDefault();
			return result;
		}

		public bool ピアス_表示;

		public ピアス色 色;
	}
}
