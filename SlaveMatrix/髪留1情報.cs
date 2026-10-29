using System;

namespace SlaveMatrix
{
	[Serializable]
	public struct 髪留1情報
	{
		public void SetDefault()
		{
			this.髪縛1_表示 = true;
			this.髪縛2_表示 = true;
			this.色.SetDefault();
		}

		public bool 髪縛1_表示;

		public bool 髪縛2_表示;

		public 髪留色 色;
	}
}
