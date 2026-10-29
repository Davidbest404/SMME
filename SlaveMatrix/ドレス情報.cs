using System;

namespace SlaveMatrix
{
	[Serializable]
	public struct ドレス情報
	{
		public void SetDefault()
		{
			this.T.SetDefault();
			this.M.SetDefault();
			this.色.SetDefault();
		}

		public static ドレス情報 GetDefault()
		{
			ドレス情報 result = default(ドレス情報);
			result.SetDefault();
			return result;
		}

		public bool IsShow
		{
			get
			{
				return this.T.IsShow || this.M.IsShow;
			}
		}

		public 上着T_ドレス情報 T;

		public 上着M_ドレス情報 M;

		public ドレス色 色;
	}
}
