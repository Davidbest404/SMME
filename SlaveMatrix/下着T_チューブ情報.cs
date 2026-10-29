using System;

namespace SlaveMatrix
{
	[Serializable]
	public struct 下着T_チュ\u30FCブ情報
	{
		public bool 縁
		{
			get
			{
				return this.縁1表示 && this.縁2表示 && this.縁3表示 && this.縁4表示;
			}
			set
			{
				this.縁1表示 = value;
				this.縁2表示 = value;
				this.縁3表示 = value;
				this.縁4表示 = value;
			}
		}

		public void SetDefault()
		{
			this.ベ\u30FCス表示 = true;
			this.皺1表示 = true;
			this.皺2表示 = true;
			this.皺3表示 = true;
			this.皺4表示 = true;
			this.縁1表示 = true;
			this.縁2表示 = true;
			this.縁3表示 = true;
			this.縁4表示 = true;
			this.色.SetDefault();
		}

		public static 下着T_チュ\u30FCブ情報 GetDefault()
		{
			下着T_チュ\u30FCブ情報 result = default(下着T_チュ\u30FCブ情報);
			result.SetDefault();
			return result;
		}

		public bool IsShow
		{
			get
			{
				return this.ベ\u30FCス表示 || this.皺1表示 || this.皺2表示 || this.皺3表示 || this.皺4表示 || this.縁1表示 || this.縁2表示 || this.縁3表示 || this.縁4表示;
			}
		}

		public bool ベ\u30FCス表示;

		public bool 皺1表示;

		public bool 皺2表示;

		public bool 皺3表示;

		public bool 皺4表示;

		public bool 縁1表示;

		public bool 縁2表示;

		public bool 縁3表示;

		public bool 縁4表示;

		public チュ\u30FCブT色 色;
	}
}
