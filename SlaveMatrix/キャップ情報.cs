using System;

namespace SlaveMatrix
{
	[Serializable]
	public struct キャップ情報
	{
		public void SetDefault()
		{
			this.根本_表示 = true;
			this.先端_表示 = true;
			this.色.SetDefault();
		}

		public static キャップ情報 GetDefault()
		{
			キャップ情報 result = default(キャップ情報);
			result.SetDefault();
			return result;
		}

		public bool 根本_表示;

		public bool 先端_表示;

		public キャップ色 色;
	}
}
