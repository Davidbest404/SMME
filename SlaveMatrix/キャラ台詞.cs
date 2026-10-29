using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class キャラ台詞
	{
		public キャラ台詞(Med Med, 吹き出し hd)
		{
			this.Med = Med;
			this.hd = hd;
		}

		public void Set()
		{
			string text = this.hd.Text;
			this.hd.Text = text;
		}

		public void Set状態()
		{
			string 点6ハ_u30FCト = tex.点6ハ\u30FCト;
			this.hd.Text = 点6ハ_u30FCト;
		}

		private Med Med;

		private 吹き出し hd;
	}
}
