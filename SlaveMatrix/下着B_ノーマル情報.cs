using System;

namespace SlaveMatrix
{
	[Serializable]
	public struct 下着B_ノ\u30FCマル情報
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

		public bool 紐
		{
			get
			{
				return this.紐輪表示 && this.紐表示;
			}
			set
			{
				this.紐輪表示 = value;
				this.紐表示 = value;
			}
		}

		public void Setランジェリ\u30FC()
		{
			this.ベ\u30FCス表示 = true;
			this.紐輪表示 = false;
			this.紐表示 = false;
			this.縁1表示 = true;
			this.縁2表示 = true;
			this.縁3表示 = true;
			this.縁4表示 = true;
			this.リボン表示 = true;
			this.リボン結び目表示 = true;
			this.ライン中表示 = true;
			this.ライン左右表示 = true;
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
			this.染み表示 = true;
			this.色.SetDefault();
		}

		public void Setランジェリ\u30FC紐付き()
		{
			this.ベ\u30FCス表示 = true;
			this.紐輪表示 = true;
			this.紐表示 = true;
			this.縁1表示 = true;
			this.縁2表示 = true;
			this.縁3表示 = true;
			this.縁4表示 = true;
			this.リボン表示 = true;
			this.リボン結び目表示 = true;
			this.ライン中表示 = true;
			this.ライン左右表示 = true;
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
			this.染み表示 = true;
			this.色.SetDefault();
		}

		public void Setビキニ()
		{
			this.ベ\u30FCス表示 = true;
			this.紐輪表示 = false;
			this.紐表示 = false;
			this.縁1表示 = true;
			this.縁2表示 = true;
			this.縁3表示 = true;
			this.縁4表示 = true;
			this.リボン表示 = false;
			this.リボン結び目表示 = false;
			this.ライン中表示 = false;
			this.ライン左右表示 = false;
			this.柄1表示 = false;
			this.柄2表示 = false;
			this.柄3表示 = false;
			this.柄4表示 = false;
			this.柄5表示 = false;
			this.柄6表示 = false;
			this.柄7表示 = false;
			this.柄8表示 = false;
			this.柄9表示 = false;
			this.柄10表示 = false;
			this.染み表示 = true;
			this.色.Setビキニ();
		}

		public void Setビキニ紐付き()
		{
			this.ベ\u30FCス表示 = true;
			this.紐輪表示 = true;
			this.紐表示 = true;
			this.縁1表示 = true;
			this.縁2表示 = true;
			this.縁3表示 = true;
			this.縁4表示 = true;
			this.リボン表示 = false;
			this.リボン結び目表示 = false;
			this.ライン中表示 = false;
			this.ライン左右表示 = false;
			this.柄1表示 = false;
			this.柄2表示 = false;
			this.柄3表示 = false;
			this.柄4表示 = false;
			this.柄5表示 = false;
			this.柄6表示 = false;
			this.柄7表示 = false;
			this.柄8表示 = false;
			this.柄9表示 = false;
			this.柄10表示 = false;
			this.染み表示 = true;
			this.色.Setビキニ();
		}

		public static 下着B_ノ\u30FCマル情報 Getランジェリ\u30FC()
		{
			下着B_ノ\u30FCマル情報 result = default(下着B_ノ\u30FCマル情報);
			result.Setランジェリ\u30FC();
			return result;
		}

		public static 下着B_ノ\u30FCマル情報 Getランジェリ\u30FC紐付き()
		{
			下着B_ノ\u30FCマル情報 result = default(下着B_ノ\u30FCマル情報);
			result.Setランジェリ\u30FC紐付き();
			return result;
		}

		public static 下着B_ノ\u30FCマル情報 Getビキニ()
		{
			下着B_ノ\u30FCマル情報 result = default(下着B_ノ\u30FCマル情報);
			result.Setビキニ();
			return result;
		}

		public static 下着B_ノ\u30FCマル情報 Getビキニ紐付き()
		{
			下着B_ノ\u30FCマル情報 result = default(下着B_ノ\u30FCマル情報);
			result.Setビキニ紐付き();
			return result;
		}

		public bool IsShow
		{
			get
			{
				return this.ベ\u30FCス表示 || this.紐輪表示 || this.紐表示 || this.縁1表示 || this.縁2表示 || this.縁3表示 || this.縁4表示 || this.リボン表示 || this.リボン結び目表示 || this.ライン中表示 || this.ライン左右表示 || this.柄1表示 || this.柄2表示 || this.柄3表示 || this.柄4表示 || this.柄5表示 || this.柄6表示 || this.柄7表示 || this.柄8表示 || this.柄9表示 || this.柄10表示 || this.染み表示;
			}
		}

		public bool ベ\u30FCス表示;

		public bool 紐輪表示;

		public bool 紐表示;

		public bool 縁1表示;

		public bool 縁2表示;

		public bool 縁3表示;

		public bool 縁4表示;

		public bool リボン表示;

		public bool リボン結び目表示;

		public bool ライン中表示;

		public bool ライン左右表示;

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

		public bool 染み表示;

		public ノ\u30FCマルB色 色;
	}
}
