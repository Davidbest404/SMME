using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 下着トップ_ブラD : 下着トップD
	{
		public 下着トップ_ブラD()
		{
			this.ThisType = base.GetType();
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new 下着トップ_ブラ(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool バンド_バンド_表示;

		public bool バンド_縁_下_表示;

		public bool バンド_縁_上_表示;

		public bool バンド_縁_左_表示;

		public bool バンド_縁_右_表示;

		public bool カップ左_紐_表示;

		public bool カップ左_ジャスタ\u30FC_ジャスタ\u30FC1_表示;

		public bool カップ左_ジャスタ\u30FC_ジャスタ\u30FC2_表示;

		public bool カップ左_ジャスタ\u30FC_ジャスタ\u30FC3_表示;

		public bool カップ左_ジャスタ\u30FC_ジャスタ\u30FC4_表示;

		public bool カップ左_カップ2_表示;

		public bool カップ左_レ\u30FCス_レ\u30FCス1_表示;

		public bool カップ左_レ\u30FCス_レ\u30FCス2_表示;

		public bool カップ左_レ\u30FCス_レ\u30FCス3_表示;

		public bool カップ左_レ\u30FCス_レ\u30FCス4_表示;

		public bool カップ左_レ\u30FCス_レ\u30FCス5_表示;

		public bool カップ左_レ\u30FCス_レ\u30FCス6_表示;

		public bool カップ左_レ\u30FCス_レ\u30FCス7_表示;

		public bool カップ左_レ\u30FCス_レ\u30FCス8_表示;

		public bool カップ左_レ\u30FCス_レ\u30FCス9_表示;

		public bool カップ左_レ\u30FCス_レ\u30FCス10_表示;

		public bool カップ左_レ\u30FCス_レ\u30FCス11_表示;

		public bool カップ左_レ\u30FCス_レ\u30FCス12_表示;

		public bool カップ左_カップ1_表示;

		public bool カップ左_柄_柄1_柄1_表示;

		public bool カップ左_柄_柄1_柄2_表示;

		public bool カップ左_柄_柄2_柄1_表示;

		public bool カップ左_柄_柄2_柄2_表示;

		public bool カップ左_柄_柄3_柄1_表示;

		public bool カップ左_柄_柄3_柄2_表示;

		public bool カップ左_柄_柄4_柄1_表示;

		public bool カップ左_柄_柄4_柄2_表示;

		public bool カップ左_柄_柄5_柄1_表示;

		public bool カップ左_柄_柄5_柄2_表示;

		public bool カップ左_柄_柄6_柄1_表示;

		public bool カップ左_柄_柄6_柄2_表示;

		public bool カップ左_柄_柄7_柄1_表示;

		public bool カップ左_柄_柄7_柄2_表示;

		public bool カップ左_縁_縁1_表示;

		public bool カップ左_縁_縁2_表示;

		public bool カップ左_縁_縁3_表示;

		public bool カップ左_縁_縁4_表示;

		public bool カップ右_紐_表示;

		public bool カップ右_ジャスタ\u30FC_ジャスタ\u30FC1_表示;

		public bool カップ右_ジャスタ\u30FC_ジャスタ\u30FC2_表示;

		public bool カップ右_ジャスタ\u30FC_ジャスタ\u30FC3_表示;

		public bool カップ右_ジャスタ\u30FC_ジャスタ\u30FC4_表示;

		public bool カップ右_カップ2_表示;

		public bool カップ右_レ\u30FCス_レ\u30FCス1_表示;

		public bool カップ右_レ\u30FCス_レ\u30FCス2_表示;

		public bool カップ右_レ\u30FCス_レ\u30FCス3_表示;

		public bool カップ右_レ\u30FCス_レ\u30FCス4_表示;

		public bool カップ右_レ\u30FCス_レ\u30FCス5_表示;

		public bool カップ右_レ\u30FCス_レ\u30FCス6_表示;

		public bool カップ右_レ\u30FCス_レ\u30FCス7_表示;

		public bool カップ右_レ\u30FCス_レ\u30FCス8_表示;

		public bool カップ右_レ\u30FCス_レ\u30FCス9_表示;

		public bool カップ右_レ\u30FCス_レ\u30FCス10_表示;

		public bool カップ右_レ\u30FCス_レ\u30FCス11_表示;

		public bool カップ右_レ\u30FCス_レ\u30FCス12_表示;

		public bool カップ右_カップ1_表示;

		public bool カップ右_柄_柄1_柄1_表示;

		public bool カップ右_柄_柄1_柄2_表示;

		public bool カップ右_柄_柄2_柄1_表示;

		public bool カップ右_柄_柄2_柄2_表示;

		public bool カップ右_柄_柄3_柄1_表示;

		public bool カップ右_柄_柄3_柄2_表示;

		public bool カップ右_柄_柄4_柄1_表示;

		public bool カップ右_柄_柄4_柄2_表示;

		public bool カップ右_柄_柄5_柄1_表示;

		public bool カップ右_柄_柄5_柄2_表示;

		public bool カップ右_柄_柄6_柄1_表示;

		public bool カップ右_柄_柄6_柄2_表示;

		public bool カップ右_柄_柄7_柄1_表示;

		public bool カップ右_柄_柄7_柄2_表示;

		public bool カップ右_縁_縁1_表示;

		public bool カップ右_縁_縁2_表示;

		public bool カップ右_縁_縁3_表示;

		public bool カップ右_縁_縁4_表示;

		public bool リボン_リボン_表示;

		public bool リボン_結び目_表示;

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

		public double バスト;
	}
}
