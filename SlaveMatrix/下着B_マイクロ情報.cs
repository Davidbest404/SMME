using System;

namespace SlaveMatrix
{
	[Serializable]
	public struct 下着B_マイクロ情報
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

		public void SetDefault()
		{
			this.ベ\u30FCス表示 = true;
			this.紐輪表示 = false;
			this.紐表示 = false;
			this.縁1表示 = true;
			this.縁2表示 = true;
			this.縁3表示 = true;
			this.縁4表示 = true;
			this.ヴィオラ表示 = false;
			this.染み表示 = true;
			this.色.SetDefault();
		}

		public void Set紐付き()
		{
			this.ベ\u30FCス表示 = true;
			this.紐輪表示 = true;
			this.紐表示 = true;
			this.縁1表示 = true;
			this.縁2表示 = true;
			this.縁3表示 = true;
			this.縁4表示 = true;
			this.ヴィオラ表示 = false;
			this.染み表示 = true;
			this.色.SetDefault();
		}

		public void Setヴィオラ()
		{
			this.ベ\u30FCス表示 = true;
			this.紐輪表示 = false;
			this.紐表示 = false;
			this.縁1表示 = true;
			this.縁2表示 = true;
			this.縁3表示 = true;
			this.縁4表示 = true;
			this.ヴィオラ表示 = true;
			this.染み表示 = false;
			this.色.Setヴィオラ();
		}

		public static 下着B_マイクロ情報 Getマイクロ()
		{
			下着B_マイクロ情報 result = default(下着B_マイクロ情報);
			result.SetDefault();
			return result;
		}

		public static 下着B_マイクロ情報 Getマイクロ紐付き()
		{
			下着B_マイクロ情報 result = default(下着B_マイクロ情報);
			result.Set紐付き();
			return result;
		}

		public static 下着B_マイクロ情報 Getヴィオラ()
		{
			下着B_マイクロ情報 result = default(下着B_マイクロ情報);
			result.Setヴィオラ();
			return result;
		}

		public bool IsShow
		{
			get
			{
				return this.ベ\u30FCス表示 || this.紐輪表示 || this.紐表示 || this.縁1表示 || this.縁2表示 || this.縁3表示 || this.縁4表示 || this.ヴィオラ表示 || this.染み表示;
			}
		}

		public bool ベ\u30FCス表示;

		public bool 紐輪表示;

		public bool 紐表示;

		public bool 縁1表示;

		public bool 縁2表示;

		public bool 縁3表示;

		public bool 縁4表示;

		public bool ヴィオラ表示;

		public bool 染み表示;

		public マイクロB色 色;
	}
}
