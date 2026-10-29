using System;

namespace SlaveMatrix
{
	[Serializable]
	public struct 拘束具情報
	{
		public void SetDefault()
		{
			this.表示 = true;
			this.色.SetDefault();
		}

		public static 拘束具情報 GetDefault()
		{
			拘束具情報 result = default(拘束具情報);
			result.SetDefault();
			return result;
		}

		public bool 表示;

		public 拘束具色 色;
	}
}
