using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class バイブ_アナルD : EleD
	{
		public バイブ_アナルD()
		{
			this.ThisType = base.GetType();
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new バイブ_アナル(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool ヘッド_表示 = true;

		public bool ユニット_ユニット_表示 = true;

		public bool ユニット_ユニット線上_表示 = true;

		public bool ユニット_ユニット線下_表示 = true;

		public bool ユニット_ボタン上_表示 = true;

		public bool ユニット_ボタン下_表示 = true;

		public bool ユニット_パワ\u30FC根_表示 = true;

		public bool ユニット_パワ\u30FC1_表示 = true;

		public bool ユニット_パワ\u30FC2_表示 = true;

		public bool ユニット_パワ\u30FC3_表示 = true;

		public bool ユニット_パワ\u30FC4_表示 = true;
	}
}
