using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class 脚_人D : 脚D
	{
		public 脚_人D()
		{
			this.ThisType = base.GetType();
		}

		public override void 足接続(EleD e)
		{
			this.足_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.脚_人_足_接続;
		}

		public void 脚輪下接続(EleD e)
		{
			this.脚輪下_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.脚_人_脚輪下_接続;
		}

		public void 脚輪上接続(EleD e)
		{
			this.脚輪上_接続.Add(e);
			e.Par = this;
			e.接続情報 = 接続情報.脚_人_脚輪上_接続;
		}

		public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return new 脚_人(DisUnit, this.配色指定, 体配色, Med, this);
		}

		public bool 脚_表示 = true;

		public bool 筋_表示;

		public bool 淫タトゥ_足首_タトゥ_表示;

		public bool 淫タトゥ_足首_ハ\u30FCト1_タトゥ左_表示;

		public bool 淫タトゥ_足首_ハ\u30FCト1_タトゥ右_表示;

		public bool 淫タトゥ_足首_ハ\u30FCト3_タトゥ左_表示;

		public bool 淫タトゥ_足首_ハ\u30FCト3_タトゥ右_表示;

		public bool 淫タトゥ_足首_ハ\u30FCト2_タトゥ左_表示;

		public bool 淫タトゥ_足首_ハ\u30FCト2_タトゥ右_表示;

		public bool 淫タトゥ_ハ\u30FCト_タトゥ左_表示;

		public bool 淫タトゥ_ハ\u30FCト_タトゥ右_表示;

		public bool 淫タトゥ_タトゥ左_表示;

		public bool 淫タトゥ_タトゥ右_表示;

		public bool 悪タトゥ_文字1_文字a_枠_表示;

		public bool 悪タトゥ_文字1_文字a_文字タトゥ1_表示;

		public bool 悪タトゥ_文字1_文字a_文字タトゥ2_表示;

		public bool 悪タトゥ_文字1_文字b_枠_表示;

		public bool 悪タトゥ_文字1_文字b_文字タトゥ1_表示;

		public bool 悪タトゥ_文字1_文字b_文字タトゥ2_表示;

		public bool 悪タトゥ_文字1_文字c_枠_表示;

		public bool 悪タトゥ_文字1_文字c_文字タトゥ1_表示;

		public bool 悪タトゥ_文字1_文字c_文字タトゥ2_表示;

		public bool 悪タトゥ_文字1_文字d_枠_表示;

		public bool 悪タトゥ_文字1_文字d_文字タトゥ1_表示;

		public bool 悪タトゥ_文字1_文字d_文字タトゥ2_表示;

		public bool 悪タトゥ_文字1_文字e_枠_表示;

		public bool 悪タトゥ_文字1_文字e_文字タトゥ1_表示;

		public bool 悪タトゥ_文字1_文字e_文字タトゥ2_表示;

		public bool 悪タトゥ_文字1_文字e_文字タトゥ3_表示;

		public bool 悪タトゥ_文字2_文字a_枠_表示;

		public bool 悪タトゥ_文字2_文字a_文字タトゥ1_表示;

		public bool 悪タトゥ_文字2_文字a_文字タトゥ2_表示;

		public bool 悪タトゥ_文字2_文字b_枠_表示;

		public bool 悪タトゥ_文字2_文字b_文字タトゥ1_表示;

		public bool 悪タトゥ_文字2_文字b_文字タトゥ2_表示;

		public bool 悪タトゥ_文字2_文字c_枠_表示;

		public bool 悪タトゥ_文字2_文字c_文字タトゥ1_表示;

		public bool 悪タトゥ_文字2_文字c_文字タトゥ2_表示;

		public bool 悪タトゥ_文字2_文字d_枠_表示;

		public bool 悪タトゥ_文字2_文字d_文字タトゥ1_表示;

		public bool 悪タトゥ_文字2_文字d_文字タトゥ2_表示;

		public bool 悪タトゥ_文字2_文字e_枠_表示;

		public bool 悪タトゥ_文字2_文字e_文字タトゥ1_表示;

		public bool 悪タトゥ_文字2_文字e_文字タトゥ2_表示;

		public bool 悪タトゥ_文字2_文字e_文字タトゥ3_表示;

		public bool 悪タトゥ_タトゥ1_表示;

		public bool 悪タトゥ_タトゥ2_表示;

		public bool 悪タトゥ_逆十字_逆十字1_表示;

		public bool 悪タトゥ_逆十字_逆十字2_表示;

		public bool 悪タトゥ_タトゥ左_表示;

		public bool 悪タトゥ_タトゥ右_表示;

		public bool 紋柄_紋1_表示;

		public bool 紋柄_紋2_表示;

		public bool 紋柄_紋3_表示;

		public bool 紋柄_紋4_表示;

		public bool 獣性_獣毛1_表示;

		public bool 獣性_獣毛2_表示;

		public bool 獣性_獣毛3_表示;

		public bool 獣性_獣毛4_表示;

		public bool 獣性_獣毛5_表示;

		public bool 竜性_鱗_鱗1_表示;

		public bool 竜性_鱗_鱗2_表示;

		public bool 竜性_鱗_鱗3_表示;

		public bool 竜性_鱗_鱗4_表示;

		public bool 竜性_鱗_鱗5_表示;

		public bool 竜性_鱗_鱗6_表示;

		public bool 竜性_鱗_鱗7_表示;

		public bool 竜性_棘_棘1_表示;

		public bool 竜性_棘_棘2_表示;

		public bool 竜性_棘_棘3_表示;

		public bool 竜性_棘_棘4_表示;

		public bool 竜性_棘_棘5_表示;

		public bool 竜性_棘_棘6_表示;

		public bool 虫性_棘_棘1_表示;

		public bool 虫性_棘_棘2_表示;

		public bool 虫性_棘_棘3_表示;

		public bool 虫性_膝_表示;

		public bool 虫性_線_表示;

		public bool 傷X1_表示;

		public bool 傷X2_表示;

		public bool 傷I1_表示;

		public bool 傷I2_表示;

		public bool 傷I3_表示;

		public bool 傷I4_表示;

		public bool 傷I5_表示;

		public bool ハイライト1_表示;

		public bool ハイライト2_表示;

		public bool パンスト_パンスト_表示;

		public bool パンスト_ハイライト1_表示;

		public bool パンスト_ハイライト2_表示;

		public bool ソックス_ソックス_表示;

		public bool ソックス_ハイライト1_表示;

		public bool ソックス_ハイライト2_表示;

		public bool ブ\u30FCツ_タン_タン_表示;

		public bool ブ\u30FCツ_タン_縁_縁1_表示;

		public bool ブ\u30FCツ_タン_縁_縁2_表示;

		public bool ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツ_表示;

		public bool ブ\u30FCツ_ブ\u30FCツ_皺_皺1_表示;

		public bool ブ\u30FCツ_ブ\u30FCツ_皺_皺2_表示;

		public bool ブ\u30FCツ_ブ\u30FCツ_縁_縁1_表示;

		public bool ブ\u30FCツ_ブ\u30FCツ_縁_縁2_表示;

		public bool ブ\u30FCツ_ブ\u30FCツ_縁_縁3_表示;

		public bool ブ\u30FCツ_ブ\u30FCツ_縁_縁4_表示;

		public bool ブ\u30FCツ_柄_表示;

		public bool ブ\u30FCツ_紐_紐_表示;

		public bool ブ\u30FCツ_紐_紐1_紐下_金具上_金具_表示;

		public bool ブ\u30FCツ_紐_紐1_紐下_金具上_穴_表示;

		public bool ブ\u30FCツ_紐_紐1_紐下_紐_表示;

		public bool ブ\u30FCツ_紐_紐1_紐上_金具上_金具_表示;

		public bool ブ\u30FCツ_紐_紐1_紐上_金具上_穴_表示;

		public bool ブ\u30FCツ_紐_紐1_紐上_紐_表示;

		public bool ブ\u30FCツ_紐_紐2_紐下_金具上_金具_表示;

		public bool ブ\u30FCツ_紐_紐2_紐下_金具上_穴_表示;

		public bool ブ\u30FCツ_紐_紐2_紐下_紐_表示;

		public bool ブ\u30FCツ_紐_紐2_紐上_金具上_金具_表示;

		public bool ブ\u30FCツ_紐_紐2_紐上_金具上_穴_表示;

		public bool ブ\u30FCツ_紐_紐2_紐上_紐_表示;

		public bool ブ\u30FCツ_紐_紐3_紐下_金具上_金具_表示;

		public bool ブ\u30FCツ_紐_紐3_紐下_金具上_穴_表示;

		public bool ブ\u30FCツ_紐_紐3_紐下_紐_表示;

		public bool ブ\u30FCツ_紐_紐3_紐上_金具上_金具_表示;

		public bool ブ\u30FCツ_紐_紐3_紐上_金具上_穴_表示;

		public bool ブ\u30FCツ_紐_紐3_紐上_紐_表示;

		public bool ブ\u30FCツ_紐_紐4_紐下_金具上_金具_表示;

		public bool ブ\u30FCツ_紐_紐4_紐下_金具上_穴_表示;

		public bool ブ\u30FCツ_紐_紐4_紐下_紐_表示;

		public bool ブ\u30FCツ_紐_紐4_紐上_金具上_金具_表示;

		public bool ブ\u30FCツ_紐_紐4_紐上_金具上_穴_表示;

		public bool ブ\u30FCツ_紐_紐4_紐上_紐_表示;

		public bool ブ\u30FCツ_紐_紐5_紐下_金具上_金具_表示;

		public bool ブ\u30FCツ_紐_紐5_紐下_金具上_穴_表示;

		public bool ブ\u30FCツ_紐_紐5_紐下_紐_表示;

		public bool ブ\u30FCツ_紐_紐5_紐上_金具上_金具_表示;

		public bool ブ\u30FCツ_紐_紐5_紐上_金具上_穴_表示;

		public bool ブ\u30FCツ_紐_紐5_紐上_紐_表示;

		public bool ブ\u30FCツ_紐_紐6_紐下_金具上_金具_表示;

		public bool ブ\u30FCツ_紐_紐6_紐下_金具上_穴_表示;

		public bool ブ\u30FCツ_紐_紐6_紐下_紐_表示;

		public bool ブ\u30FCツ_紐_紐6_紐上_金具上_金具_表示;

		public bool ブ\u30FCツ_紐_紐6_紐上_金具上_穴_表示;

		public bool ブ\u30FCツ_紐_紐6_紐上_紐_表示;

		public bool ブ\u30FCツ_紐_紐7_紐下_金具上_金具_表示;

		public bool ブ\u30FCツ_紐_紐7_紐下_金具上_穴_表示;

		public bool ブ\u30FCツ_紐_紐7_紐下_紐_表示;

		public bool ブ\u30FCツ_紐_紐7_紐上_金具上_金具_表示;

		public bool ブ\u30FCツ_紐_紐7_紐上_金具上_穴_表示;

		public bool ブ\u30FCツ_紐_紐7_紐上_紐_表示;

		public bool ブ\u30FCツ_紐_紐8_紐下_金具上_金具_表示;

		public bool ブ\u30FCツ_紐_紐8_紐下_金具上_穴_表示;

		public bool ブ\u30FCツ_紐_紐8_紐下_紐_表示;

		public bool ブ\u30FCツ_紐_紐8_紐上_金具上_金具_表示;

		public bool ブ\u30FCツ_紐_紐8_紐上_金具上_穴_表示;

		public bool ブ\u30FCツ_紐_紐8_紐上_紐_表示;

		public bool ブ\u30FCツ_紐_紐9_紐下_金具上_金具_表示;

		public bool ブ\u30FCツ_紐_紐9_紐下_金具上_穴_表示;

		public bool ブ\u30FCツ_紐_紐9_紐下_紐_表示;

		public bool ブ\u30FCツ_紐_紐9_紐上_金具上_金具_表示;

		public bool ブ\u30FCツ_紐_紐9_紐上_金具上_穴_表示;

		public bool ブ\u30FCツ_紐_紐9_紐上_紐_表示;

		public bool ブ\u30FCツ_紐_紐10_紐下_金具上_金具_表示;

		public bool ブ\u30FCツ_紐_紐10_紐下_金具上_穴_表示;

		public bool ブ\u30FCツ_紐_紐10_紐下_紐_表示;

		public bool ブ\u30FCツ_紐_紐10_紐上_金具上_金具_表示;

		public bool ブ\u30FCツ_紐_紐10_紐上_金具上_穴_表示;

		public bool ブ\u30FCツ_紐_紐10_紐上_紐_表示;

		public bool ブ\u30FCツ_紐_紐11_紐下_金具上_金具_表示;

		public bool ブ\u30FCツ_紐_紐11_紐下_金具上_穴_表示;

		public bool ブ\u30FCツ_紐_紐11_紐下_紐_表示;

		public bool ブ\u30FCツ_紐_紐11_紐上_金具上_金具_表示;

		public bool ブ\u30FCツ_紐_紐11_紐上_金具上_穴_表示;

		public bool ブ\u30FCツ_紐_紐11_紐上_紐_表示;

		public bool ブ\u30FCツ_紐_結び_紐左_紐3_表示;

		public bool ブ\u30FCツ_紐_結び_紐左_紐2_表示;

		public bool ブ\u30FCツ_紐_結び_紐左_紐1_表示;

		public bool ブ\u30FCツ_紐_結び_紐右_紐3_表示;

		public bool ブ\u30FCツ_紐_結び_紐右_紐2_表示;

		public bool ブ\u30FCツ_紐_結び_紐右_紐1_表示;

		public bool ブ\u30FCツ_紐_結び_結び目_表示;

		public bool ア\u30FCマ_ベ\u30FCス_表示;

		public bool ア\u30FCマ_脛当_脛当1_表示;

		public bool ア\u30FCマ_脛当_脛当2_表示;

		public bool ア\u30FCマ_膝当_表示;

		public bool ア\u30FCマ_穴_穴1_表示;

		public bool ア\u30FCマ_穴_穴2_表示;

		public bool ア\u30FCマ_穴_穴3_表示;

		public bool ア\u30FCマ_穴_穴4_表示;

		public bool 脚輪上_革_表示;

		public bool 脚輪上_金具1_表示;

		public bool 脚輪上_金具2_表示;

		public bool 脚輪上_金具3_表示;

		public bool 脚輪上_金具左_表示;

		public bool 脚輪上_金具右_表示;

		public bool 脚輪下_革_表示;

		public bool 脚輪下_金具1_表示;

		public bool 脚輪下_金具2_表示;

		public bool 脚輪下_金具3_表示;

		public bool 脚輪下_金具左_表示;

		public bool 脚輪下_金具右_表示;

		public bool ハイライト表示;

		public double 筋肉濃度 = 1.0;

		public double 傷X1濃度 = 1.0;

		public double 傷X2濃度 = 1.0;

		public double 傷I1濃度 = 1.0;

		public double 傷I2濃度 = 1.0;

		public double 傷I3濃度 = 1.0;

		public double 傷I4濃度 = 1.0;

		public double 傷I5濃度 = 1.0;

		public double ハイライト濃度 = 1.0;

		public bool 脚輪上表示;

		public bool 脚輪下表示;

		public bool 虫性;

		public bool パンスト表示;

		public bool ニ\u30FCハイ表示;

		public bool ブ\u30FCツ表示;

		public bool メイル表示;

		public bool 鎖表示;

		public List<EleD> 脚輪下_接続 = new List<EleD>();

		public List<EleD> 脚輪上_接続 = new List<EleD>();
	}
}
