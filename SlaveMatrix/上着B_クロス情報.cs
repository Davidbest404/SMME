using System;

namespace SlaveMatrix
{
	[Serializable]
	public struct 上着B_クロス情報
	{
		public bool 中
		{
			get
			{
				return this.中表示 && this.中皺1表示 && this.中皺2表示;
			}
			set
			{
				this.中表示 = value;
				this.中皺1表示 = value;
				this.中皺2表示 = value;
			}
		}

		public void SetDefault()
		{
			this.ベ\u30FCス表示 = true;
			this.ベ\u30FCス皺1表示 = true;
			this.ベ\u30FCス皺2表示 = true;
			this.ベ\u30FCス皺3表示 = true;
			this.ベ\u30FCス皺4表示 = true;
			this.ベ\u30FCス皺5表示 = true;
			this.中表示 = true;
			this.中皺1表示 = true;
			this.中皺2表示 = true;
			this.色.SetDefault();
		}

		public static 上着B_クロス情報 GetDefault()
		{
			上着B_クロス情報 result = default(上着B_クロス情報);
			result.SetDefault();
			return result;
		}

		public bool IsShow
		{
			get
			{
				return this.ベ\u30FCス表示 || this.ベ\u30FCス皺1表示 || this.ベ\u30FCス皺2表示 || this.ベ\u30FCス皺3表示 || this.ベ\u30FCス皺4表示 || this.ベ\u30FCス皺5表示 || this.中表示 || this.中皺1表示 || this.中皺2表示;
			}
		}

		public bool ベ\u30FCス表示;

		public bool ベ\u30FCス皺1表示;

		public bool ベ\u30FCス皺2表示;

		public bool ベ\u30FCス皺3表示;

		public bool ベ\u30FCス皺4表示;

		public bool ベ\u30FCス皺5表示;

		public bool 中表示;

		public bool 中皺1表示;

		public bool 中皺2表示;

		public クロスB色 色;
	}
}
