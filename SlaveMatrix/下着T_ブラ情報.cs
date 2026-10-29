using System;

namespace SlaveMatrix
{
	[Serializable]
	public struct 下着T_ブラ情報
	{
		public void SetDefault()
		{
			this.ベ\u30FCス表示 = true;
			this.縁1表示 = true;
			this.縁2表示 = true;
			this.縁3表示 = true;
			this.縁4表示 = true;
			this.縁5表示 = true;
			this.縁6表示 = true;
			this.縁7表示 = true;
			this.ジャスタ\u30FC表示 = true;
			this.レ\u30FCス表示 = true;
			this.柄1表示 = true;
			this.柄2表示 = true;
			this.柄3表示 = true;
			this.柄4表示 = true;
			this.柄5表示 = true;
			this.柄6表示 = true;
			this.柄7表示 = true;
			this.柄8表示 = true;
			this.柄9表示 = true;
			this.柄10表示 = true;
			this.柄11表示 = true;
			this.柄12表示 = true;
			this.柄13表示 = true;
			this.柄14表示 = true;
			this.リボン表示 = true;
			this.リボン結び目表示 = true;
			this.色.SetDefault();
		}

		public static 下着T_ブラ情報 GetDefault()
		{
			下着T_ブラ情報 result = default(下着T_ブラ情報);
			result.SetDefault();
			return result;
		}

		public bool IsShow
		{
			get
			{
				return this.ベ\u30FCス表示 || this.縁1表示 || this.縁2表示 || this.縁3表示 || this.縁4表示 || this.縁5表示 || this.縁6表示 || this.縁7表示 || this.ジャスタ\u30FC表示 || this.レ\u30FCス表示 || this.柄1表示 || this.柄2表示 || this.柄3表示 || this.柄4表示 || this.柄5表示 || this.柄6表示 || this.柄7表示 || this.柄8表示 || this.柄9表示 || this.柄10表示 || this.柄11表示 || this.柄12表示 || this.柄13表示 || this.柄14表示 || this.リボン表示 || this.リボン結び目表示;
			}
		}

		public bool ベ\u30FCス表示;

		public bool 縁1表示;

		public bool 縁2表示;

		public bool 縁3表示;

		public bool 縁4表示;

		public bool 縁5表示;

		public bool 縁6表示;

		public bool 縁7表示;

		public bool ジャスタ\u30FC表示;

		public bool レ\u30FCス表示;

		public bool 柄1表示;

		public bool 柄2表示;

		public bool 柄3表示;

		public bool 柄4表示;

		public bool 柄5表示;

		public bool 柄6表示;

		public bool 柄7表示;

		public bool 柄8表示;

		public bool 柄9表示;

		public bool 柄10表示;

		public bool 柄11表示;

		public bool 柄12表示;

		public bool 柄13表示;

		public bool 柄14表示;

		public bool リボン表示;

		public bool リボン結び目表示;

		public ブラT色 色;
	}
}
