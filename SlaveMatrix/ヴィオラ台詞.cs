using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class ヴィオラ台詞
	{
		public ヴィオラ台詞(Med Med, 吹き出し hd)
		{
			this.Med = Med;
			this.hd = hd;
		}

		public void Set()
		{
			string text = "";
			string mode = this.Med.Mode;
			if (!(mode == "事務所"))
			{
				if (mode == "借金")
				{
					text = tex.今日借りれる金額はあと + Sta.GameData.日借金可能額.ToString("#,0") + tex.よ;
				}
			}
			else if (Sta.GameData.初事務所フラグ)
			{
				text = tex.いらっしゃい待っていたわ;
			}
			else
			{
				text = tex.今日はどうしたの;
			}
			this.hd.Text = text;
		}

		private Med Med;

		private 吹き出し hd;
	}
}
