using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 下着トップ_チュ\u30FCブD : 下着トップD
	{
		public 下着トップ_チュ\u30FCブD()
		{
			this.ThisType = base.GetType();
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new 下着トップ_チュ\u30FCブ(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 布_布左_布_表示;

		public bool 布_布左_皺_皺1_表示;

		public bool 布_布左_皺_皺2_表示;

		public bool 布_布左_縁_縁1_表示;

		public bool 布_布左_縁_縁2_表示;

		public bool 布_布右_布_表示;

		public bool 布_布右_皺_皺1_表示;

		public bool 布_布右_皺_皺2_表示;

		public bool 布_布右_縁_縁1_表示;

		public bool 布_布右_縁_縁2_表示;

		public bool 布_布_表示;

		public bool 皺_皺1_表示;

		public bool 皺_皺2_表示;

		public bool 縁_縁1_表示;

		public bool 縁_縁2_表示;

		public bool ベ\u30FCス表示;

		public bool 皺1表示;

		public bool 皺2表示;

		public bool 皺3表示;

		public bool 皺4表示;

		public bool 縁1表示;

		public bool 縁2表示;

		public bool 縁3表示;

		public bool 縁4表示;

		public double バスト;
	}
}
