using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 足_人 : 足
	{
		public 足_人(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 足_人D e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.脚左["足"]);
			Pars pars = this.本体[0][0];
			Pars pars2 = pars["ヒール0"].ToPars();
			this.X0Y0_ヒ\u30FCル0_靴底 = pars2["靴底"].ToPar();
			pars2 = pars["サンダル0"].ToPars();
			this.X0Y0_サンダル0_靴底 = pars2["靴底"].ToPar();
			pars2 = pars["ナース0"].ToPars();
			this.X0Y0_ナ\u30FCス0_靴底 = pars2["靴底"].ToPar();
			pars2 = pars["ブーツ0"].ToPars();
			this.X0Y0_ブ\u30FCツ0_靴底 = pars2["靴底"].ToPar();
			pars2 = pars["アーマ0"].ToPars();
			this.X0Y0_ア\u30FCマ0_靴底 = pars2["靴底"].ToPar();
			this.X0Y0_足 = pars["足"].ToPar();
			pars2 = pars["小指"].ToPars();
			this.X0Y0_小指_小指1 = pars2["小指1"].ToPar();
			this.X0Y0_小指_小指2 = pars2["小指2"].ToPar();
			this.X0Y0_小指_小指3 = pars2["小指3"].ToPar();
			pars2 = pars["薬指"].ToPars();
			this.X0Y0_薬指_水掻 = pars2["水掻"].ToPar();
			this.X0Y0_薬指_薬指1 = pars2["薬指1"].ToPar();
			this.X0Y0_薬指_薬指2 = pars2["薬指2"].ToPar();
			this.X0Y0_薬指_薬指3 = pars2["薬指3"].ToPar();
			pars2 = pars["中指"].ToPars();
			this.X0Y0_中指_水掻 = pars2["水掻"].ToPar();
			this.X0Y0_中指_中指1 = pars2["中指1"].ToPar();
			this.X0Y0_中指_中指2 = pars2["中指2"].ToPar();
			this.X0Y0_中指_中指3 = pars2["中指3"].ToPar();
			pars2 = pars["人指"].ToPars();
			this.X0Y0_人指_人指1 = pars2["人指1"].ToPar();
			this.X0Y0_人指_人指2 = pars2["人指2"].ToPar();
			this.X0Y0_人指_人指3 = pars2["人指3"].ToPar();
			this.X0Y0_人指_水掻 = pars2["水掻"].ToPar();
			pars2 = pars["親指"].ToPars();
			this.X0Y0_親指_親指2 = pars2["親指2"].ToPar();
			this.X0Y0_親指_親指3 = pars2["親指3"].ToPar();
			this.X0Y0_親指_水掻 = pars2["水掻"].ToPar();
			pars2 = pars["悪タトゥ"].ToPars();
			Pars pars3 = pars2["五芒星"].ToPars();
			this.X0Y0_悪タトゥ_五芒星_円1 = pars3["円1"].ToPar();
			this.X0Y0_悪タトゥ_五芒星_円2 = pars3["円2"].ToPar();
			this.X0Y0_悪タトゥ_五芒星_星 = pars3["星"].ToPar();
			this.X0Y0_悪タトゥ_五芒星_五角形 = pars3["五角形"].ToPar();
			pars2 = pars["鱗"].ToPars();
			this.X0Y0_竜性_鱗1 = pars2["鱗1"].ToPar();
			this.X0Y0_竜性_鱗2 = pars2["鱗2"].ToPar();
			this.X0Y0_竜性_鱗3 = pars2["鱗3"].ToPar();
			this.X0Y0_竜性_鱗4 = pars2["鱗4"].ToPar();
			this.X0Y0_竜性_鱗5 = pars2["鱗5"].ToPar();
			pars2 = pars["パンスト"].ToPars();
			this.X0Y0_パンスト_パンスト1 = pars2["パンスト1"].ToPar();
			this.X0Y0_パンスト_パンスト2 = pars2["パンスト2"].ToPar();
			pars2 = pars["ソックス"].ToPars();
			this.X0Y0_ソックス_ソックス1 = pars2["ソックス1"].ToPar();
			this.X0Y0_ソックス_ソックス2 = pars2["ソックス2"].ToPar();
			pars2 = pars["ヒール1"].ToPars();
			this.X0Y0_ヒ\u30FCル1_バンプ = pars2["バンプ"].ToPar();
			pars3 = pars2["ストラップ"].ToPars();
			this.X0Y0_ヒ\u30FCル1_ストラップ_ストラップ = pars3["ストラップ"].ToPar();
			Pars pars4 = pars3["金具1"].ToPars();
			this.X0Y0_ヒ\u30FCル1_ストラップ_金具1_金具1 = pars4["金具1"].ToPar();
			this.X0Y0_ヒ\u30FCル1_ストラップ_金具1_金具2 = pars4["金具2"].ToPar();
			this.X0Y0_ヒ\u30FCル1_ストラップ_金具1_金具3 = pars4["金具3"].ToPar();
			this.X0Y0_ヒ\u30FCル1_ストラップ_金具1_金具4 = pars4["金具4"].ToPar();
			pars4 = pars3["金具2"].ToPars();
			this.X0Y0_ヒ\u30FCル1_ストラップ_金具2_金具1 = pars4["金具1"].ToPar();
			this.X0Y0_ヒ\u30FCル1_ストラップ_金具2_金具2 = pars4["金具2"].ToPar();
			this.X0Y0_ヒ\u30FCル1_ストラップ_金具2_金具3 = pars4["金具3"].ToPar();
			this.X0Y0_ヒ\u30FCル1_ストラップ_金具2_金具4 = pars4["金具4"].ToPar();
			this.X0Y0_ヒ\u30FCル1_ハイライト = pars2["ハイライト"].ToPar();
			pars2 = pars["サンダル1"].ToPars();
			this.X0Y0_サンダル1_ストラップ3 = pars2["ストラップ3"].ToPar();
			this.X0Y0_サンダル1_ストラップ2 = pars2["ストラップ2"].ToPar();
			this.X0Y0_サンダル1_ストラップ4 = pars2["ストラップ4"].ToPar();
			this.X0Y0_サンダル1_ストラップ1 = pars2["ストラップ1"].ToPar();
			pars2 = pars["ナース1"].ToPars();
			pars3 = pars2["ストラップ3"].ToPars();
			this.X0Y0_ナ\u30FCス1_ストラップ3_ストラップ = pars3["ストラップ"].ToPar();
			this.X0Y0_ナ\u30FCス1_ストラップ3_縁1 = pars3["縁1"].ToPar();
			this.X0Y0_ナ\u30FCス1_ストラップ3_縁2 = pars3["縁2"].ToPar();
			pars3 = pars2["ストラップ2"].ToPars();
			this.X0Y0_ナ\u30FCス1_ストラップ2_ストラップ = pars3["ストラップ"].ToPar();
			this.X0Y0_ナ\u30FCス1_ストラップ2_縁1 = pars3["縁1"].ToPar();
			this.X0Y0_ナ\u30FCス1_ストラップ2_縁2 = pars3["縁2"].ToPar();
			pars3 = pars2["ストラップ1"].ToPars();
			this.X0Y0_ナ\u30FCス1_ストラップ1_ストラップ = pars3["ストラップ"].ToPar();
			this.X0Y0_ナ\u30FCス1_ストラップ1_縁1 = pars3["縁1"].ToPar();
			this.X0Y0_ナ\u30FCス1_ストラップ1_縁2 = pars3["縁2"].ToPar();
			pars2 = pars["ブーツ1"].ToPars();
			this.X0Y0_ブ\u30FCツ1_タン = pars2["タン"].ToPar();
			pars3 = pars2["バンプ"].ToPars();
			this.X0Y0_ブ\u30FCツ1_バンプ_バンプ = pars3["バンプ"].ToPar();
			pars4 = pars3["縁"].ToPars();
			this.X0Y0_ブ\u30FCツ1_バンプ_縁_縁1 = pars4["縁1"].ToPar();
			this.X0Y0_ブ\u30FCツ1_バンプ_縁_縁2 = pars4["縁2"].ToPar();
			this.X0Y0_ブ\u30FCツ1_バンプ_縁_縁3 = pars4["縁3"].ToPar();
			this.X0Y0_ブ\u30FCツ1_バンプ_縁_縁4 = pars4["縁4"].ToPar();
			this.X0Y0_ブ\u30FCツ1_ハイライト = pars2["ハイライト"].ToPar();
			this.X0Y0_ブ\u30FCツ1_柄 = pars2["柄"].ToPar();
			pars3 = pars2["紐"].ToPars();
			pars4 = pars3["紐1"].ToPars();
			Pars pars5 = pars4["紐下"].ToPars();
			Pars pars6 = pars5["金具上"].ToPars();
			this.X0Y0_ブ\u30FCツ1_紐_紐1_紐下_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y0_ブ\u30FCツ1_紐_紐1_紐下_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y0_ブ\u30FCツ1_紐_紐1_紐下_紐 = pars5["紐"].ToPar();
			pars5 = pars4["紐上"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y0_ブ\u30FCツ1_紐_紐1_紐上_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y0_ブ\u30FCツ1_紐_紐1_紐上_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y0_ブ\u30FCツ1_紐_紐1_紐上_紐 = pars5["紐"].ToPar();
			pars4 = pars3["紐2"].ToPars();
			pars5 = pars4["紐下"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y0_ブ\u30FCツ1_紐_紐2_紐下_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y0_ブ\u30FCツ1_紐_紐2_紐下_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y0_ブ\u30FCツ1_紐_紐2_紐下_紐 = pars5["紐"].ToPar();
			pars5 = pars4["紐上"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y0_ブ\u30FCツ1_紐_紐2_紐上_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y0_ブ\u30FCツ1_紐_紐2_紐上_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y0_ブ\u30FCツ1_紐_紐2_紐上_紐 = pars5["紐"].ToPar();
			pars4 = pars3["紐3"].ToPars();
			pars5 = pars4["紐下"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y0_ブ\u30FCツ1_紐_紐3_紐下_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y0_ブ\u30FCツ1_紐_紐3_紐下_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y0_ブ\u30FCツ1_紐_紐3_紐下_紐 = pars5["紐"].ToPar();
			pars5 = pars4["紐上"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y0_ブ\u30FCツ1_紐_紐3_紐上_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y0_ブ\u30FCツ1_紐_紐3_紐上_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y0_ブ\u30FCツ1_紐_紐3_紐上_紐 = pars5["紐"].ToPar();
			pars4 = pars3["紐4"].ToPars();
			pars5 = pars4["紐下"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y0_ブ\u30FCツ1_紐_紐4_紐下_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y0_ブ\u30FCツ1_紐_紐4_紐下_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y0_ブ\u30FCツ1_紐_紐4_紐下_紐 = pars5["紐"].ToPar();
			pars5 = pars4["紐上"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y0_ブ\u30FCツ1_紐_紐4_紐上_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y0_ブ\u30FCツ1_紐_紐4_紐上_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y0_ブ\u30FCツ1_紐_紐4_紐上_紐 = pars5["紐"].ToPar();
			pars4 = pars3["紐5"].ToPars();
			pars5 = pars4["金具1"].ToPars();
			this.X0Y0_ブ\u30FCツ1_紐_紐5_金具1_金具 = pars5["金具"].ToPar();
			this.X0Y0_ブ\u30FCツ1_紐_紐5_金具1_穴 = pars5["穴"].ToPar();
			pars5 = pars4["金具2"].ToPars();
			this.X0Y0_ブ\u30FCツ1_紐_紐5_金具2_金具 = pars5["金具"].ToPar();
			this.X0Y0_ブ\u30FCツ1_紐_紐5_金具2_穴 = pars5["穴"].ToPar();
			this.X0Y0_ブ\u30FCツ1_紐_紐5_紐 = pars4["紐"].ToPar();
			pars2 = pars["アーマ1"].ToPars();
			this.X0Y0_ア\u30FCマ1_鉄靴1 = pars2["鉄靴1"].ToPar();
			this.X0Y0_ア\u30FCマ1_鉄靴2 = pars2["鉄靴2"].ToPar();
			this.X0Y0_ア\u30FCマ1_鉄靴3 = pars2["鉄靴3"].ToPar();
			pars = this.本体[0][1];
			pars2 = pars["ヒール0"].ToPars();
			this.X0Y1_ヒ\u30FCル0_ヒ\u30FCル = pars2["ヒール"].ToPar();
			this.X0Y1_ヒ\u30FCル0_靴底 = pars2["靴底"].ToPar();
			pars2 = pars["サンダル0"].ToPars();
			this.X0Y1_サンダル0_踵 = pars2["踵"].ToPar();
			this.X0Y1_サンダル0_靴底 = pars2["靴底"].ToPar();
			pars2 = pars["ナース0"].ToPars();
			this.X0Y1_ナ\u30FCス0_踵 = pars2["踵"].ToPar();
			this.X0Y1_ナ\u30FCス0_靴底 = pars2["靴底"].ToPar();
			pars2 = pars["ブーツ0"].ToPars();
			this.X0Y1_ブ\u30FCツ0_ヒ\u30FCル = pars2["ヒール"].ToPar();
			this.X0Y1_ブ\u30FCツ0_靴底 = pars2["靴底"].ToPar();
			pars2 = pars["アーマ0"].ToPars();
			this.X0Y1_ア\u30FCマ0_踵 = pars2["踵"].ToPar();
			this.X0Y1_ア\u30FCマ0_靴底 = pars2["靴底"].ToPar();
			this.X0Y1_足 = pars["足"].ToPar();
			pars2 = pars["小指"].ToPars();
			this.X0Y1_小指_小指1 = pars2["小指1"].ToPar();
			this.X0Y1_小指_小指2 = pars2["小指2"].ToPar();
			this.X0Y1_小指_小指3 = pars2["小指3"].ToPar();
			pars2 = pars["薬指"].ToPars();
			this.X0Y1_薬指_水掻 = pars2["水掻"].ToPar();
			this.X0Y1_薬指_薬指1 = pars2["薬指1"].ToPar();
			this.X0Y1_薬指_薬指2 = pars2["薬指2"].ToPar();
			this.X0Y1_薬指_薬指3 = pars2["薬指3"].ToPar();
			pars2 = pars["中指"].ToPars();
			this.X0Y1_中指_水掻 = pars2["水掻"].ToPar();
			this.X0Y1_中指_中指1 = pars2["中指1"].ToPar();
			this.X0Y1_中指_中指2 = pars2["中指2"].ToPar();
			this.X0Y1_中指_中指3 = pars2["中指3"].ToPar();
			pars2 = pars["人指"].ToPars();
			this.X0Y1_人指_水掻 = pars2["水掻"].ToPar();
			this.X0Y1_人指_人指1 = pars2["人指1"].ToPar();
			this.X0Y1_人指_人指2 = pars2["人指2"].ToPar();
			this.X0Y1_人指_人指3 = pars2["人指3"].ToPar();
			pars2 = pars["親指"].ToPars();
			this.X0Y1_親指_水掻 = pars2["水掻"].ToPar();
			this.X0Y1_親指_親指2 = pars2["親指2"].ToPar();
			this.X0Y1_親指_親指3 = pars2["親指3"].ToPar();
			pars2 = pars["悪タトゥ"].ToPars();
			pars3 = pars2["五芒星"].ToPars();
			this.X0Y1_悪タトゥ_五芒星_円1 = pars3["円1"].ToPar();
			this.X0Y1_悪タトゥ_五芒星_円2 = pars3["円2"].ToPar();
			this.X0Y1_悪タトゥ_五芒星_星 = pars3["星"].ToPar();
			this.X0Y1_悪タトゥ_五芒星_五角形 = pars3["五角形"].ToPar();
			pars2 = pars["鱗"].ToPars();
			this.X0Y1_竜性_鱗1 = pars2["鱗1"].ToPar();
			this.X0Y1_竜性_鱗2 = pars2["鱗2"].ToPar();
			this.X0Y1_竜性_鱗3 = pars2["鱗3"].ToPar();
			this.X0Y1_竜性_鱗4 = pars2["鱗4"].ToPar();
			this.X0Y1_竜性_鱗5 = pars2["鱗5"].ToPar();
			pars2 = pars["パンスト"].ToPars();
			this.X0Y1_パンスト_パンスト1 = pars2["パンスト1"].ToPar();
			this.X0Y1_パンスト_パンスト2 = pars2["パンスト2"].ToPar();
			pars2 = pars["ソックス"].ToPars();
			this.X0Y1_ソックス_ソックス1 = pars2["ソックス1"].ToPar();
			this.X0Y1_ソックス_ソックス2 = pars2["ソックス2"].ToPar();
			pars2 = pars["ヒール1"].ToPars();
			this.X0Y1_ヒ\u30FCル1_バンプ = pars2["バンプ"].ToPar();
			pars3 = pars2["ストラップ"].ToPars();
			this.X0Y1_ヒ\u30FCル1_ストラップ_ストラップ = pars3["ストラップ"].ToPar();
			pars4 = pars3["金具1"].ToPars();
			this.X0Y1_ヒ\u30FCル1_ストラップ_金具1_金具1 = pars4["金具1"].ToPar();
			this.X0Y1_ヒ\u30FCル1_ストラップ_金具1_金具2 = pars4["金具2"].ToPar();
			this.X0Y1_ヒ\u30FCル1_ストラップ_金具1_金具3 = pars4["金具3"].ToPar();
			this.X0Y1_ヒ\u30FCル1_ストラップ_金具1_金具4 = pars4["金具4"].ToPar();
			pars4 = pars3["金具2"].ToPars();
			this.X0Y1_ヒ\u30FCル1_ストラップ_金具2_金具1 = pars4["金具1"].ToPar();
			this.X0Y1_ヒ\u30FCル1_ストラップ_金具2_金具2 = pars4["金具2"].ToPar();
			this.X0Y1_ヒ\u30FCル1_ストラップ_金具2_金具3 = pars4["金具3"].ToPar();
			this.X0Y1_ヒ\u30FCル1_ストラップ_金具2_金具4 = pars4["金具4"].ToPar();
			this.X0Y1_ヒ\u30FCル1_ハイライト = pars2["ハイライト"].ToPar();
			pars2 = pars["サンダル1"].ToPars();
			this.X0Y1_サンダル1_ストラップ3 = pars2["ストラップ3"].ToPar();
			this.X0Y1_サンダル1_ストラップ2 = pars2["ストラップ2"].ToPar();
			this.X0Y1_サンダル1_ストラップ4 = pars2["ストラップ4"].ToPar();
			this.X0Y1_サンダル1_ストラップ1 = pars2["ストラップ1"].ToPar();
			pars2 = pars["ナース1"].ToPars();
			pars3 = pars2["ストラップ4"].ToPars();
			this.X0Y1_ナ\u30FCス1_ストラップ4_ストラップ = pars3["ストラップ"].ToPar();
			this.X0Y1_ナ\u30FCス1_ストラップ4_縁1 = pars3["縁1"].ToPar();
			this.X0Y1_ナ\u30FCス1_ストラップ4_縁2 = pars3["縁2"].ToPar();
			pars3 = pars2["ストラップ3"].ToPars();
			this.X0Y1_ナ\u30FCス1_ストラップ3_ストラップ = pars3["ストラップ"].ToPar();
			this.X0Y1_ナ\u30FCス1_ストラップ3_縁1 = pars3["縁1"].ToPar();
			this.X0Y1_ナ\u30FCス1_ストラップ3_縁2 = pars3["縁2"].ToPar();
			pars3 = pars2["ストラップ2"].ToPars();
			this.X0Y1_ナ\u30FCス1_ストラップ2_ストラップ = pars3["ストラップ"].ToPar();
			this.X0Y1_ナ\u30FCス1_ストラップ2_縁1 = pars3["縁1"].ToPar();
			this.X0Y1_ナ\u30FCス1_ストラップ2_縁2 = pars3["縁2"].ToPar();
			pars3 = pars2["ストラップ1"].ToPars();
			this.X0Y1_ナ\u30FCス1_ストラップ1_ストラップ = pars3["ストラップ"].ToPar();
			this.X0Y1_ナ\u30FCス1_ストラップ1_縁1 = pars3["縁1"].ToPar();
			this.X0Y1_ナ\u30FCス1_ストラップ1_縁2 = pars3["縁2"].ToPar();
			pars2 = pars["ブーツ1"].ToPars();
			this.X0Y1_ブ\u30FCツ1_タン = pars2["タン"].ToPar();
			pars3 = pars2["バンプ"].ToPars();
			this.X0Y1_ブ\u30FCツ1_バンプ_バンプ = pars3["バンプ"].ToPar();
			pars4 = pars3["縁"].ToPars();
			this.X0Y1_ブ\u30FCツ1_バンプ_縁_縁1 = pars4["縁1"].ToPar();
			this.X0Y1_ブ\u30FCツ1_バンプ_縁_縁2 = pars4["縁2"].ToPar();
			this.X0Y1_ブ\u30FCツ1_バンプ_縁_縁3 = pars4["縁3"].ToPar();
			this.X0Y1_ブ\u30FCツ1_バンプ_縁_縁4 = pars4["縁4"].ToPar();
			this.X0Y1_ブ\u30FCツ1_ハイライト = pars2["ハイライト"].ToPar();
			this.X0Y1_ブ\u30FCツ1_柄 = pars2["柄"].ToPar();
			pars3 = pars2["紐"].ToPars();
			pars4 = pars3["紐1"].ToPars();
			pars5 = pars4["紐下"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y1_ブ\u30FCツ1_紐_紐1_紐下_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y1_ブ\u30FCツ1_紐_紐1_紐下_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y1_ブ\u30FCツ1_紐_紐1_紐下_紐 = pars5["紐"].ToPar();
			pars5 = pars4["紐上"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y1_ブ\u30FCツ1_紐_紐1_紐上_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y1_ブ\u30FCツ1_紐_紐1_紐上_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y1_ブ\u30FCツ1_紐_紐1_紐上_紐 = pars5["紐"].ToPar();
			pars4 = pars3["紐2"].ToPars();
			pars5 = pars4["紐下"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y1_ブ\u30FCツ1_紐_紐2_紐下_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y1_ブ\u30FCツ1_紐_紐2_紐下_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y1_ブ\u30FCツ1_紐_紐2_紐下_紐 = pars5["紐"].ToPar();
			pars5 = pars4["紐上"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y1_ブ\u30FCツ1_紐_紐2_紐上_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y1_ブ\u30FCツ1_紐_紐2_紐上_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y1_ブ\u30FCツ1_紐_紐2_紐上_紐 = pars5["紐"].ToPar();
			pars4 = pars3["紐3"].ToPars();
			pars5 = pars4["紐下"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y1_ブ\u30FCツ1_紐_紐3_紐下_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y1_ブ\u30FCツ1_紐_紐3_紐下_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y1_ブ\u30FCツ1_紐_紐3_紐下_紐 = pars5["紐"].ToPar();
			pars5 = pars4["紐上"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y1_ブ\u30FCツ1_紐_紐3_紐上_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y1_ブ\u30FCツ1_紐_紐3_紐上_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y1_ブ\u30FCツ1_紐_紐3_紐上_紐 = pars5["紐"].ToPar();
			pars4 = pars3["紐4"].ToPars();
			pars5 = pars4["紐下"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y1_ブ\u30FCツ1_紐_紐4_紐下_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y1_ブ\u30FCツ1_紐_紐4_紐下_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y1_ブ\u30FCツ1_紐_紐4_紐下_紐 = pars5["紐"].ToPar();
			pars5 = pars4["紐上"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y1_ブ\u30FCツ1_紐_紐4_紐上_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y1_ブ\u30FCツ1_紐_紐4_紐上_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y1_ブ\u30FCツ1_紐_紐4_紐上_紐 = pars5["紐"].ToPar();
			pars4 = pars3["紐5"].ToPars();
			pars5 = pars4["金具1"].ToPars();
			this.X0Y1_ブ\u30FCツ1_紐_紐5_金具1_金具 = pars5["金具"].ToPar();
			this.X0Y1_ブ\u30FCツ1_紐_紐5_金具1_穴 = pars5["穴"].ToPar();
			pars5 = pars4["金具2"].ToPars();
			this.X0Y1_ブ\u30FCツ1_紐_紐5_金具2_金具 = pars5["金具"].ToPar();
			this.X0Y1_ブ\u30FCツ1_紐_紐5_金具2_穴 = pars5["穴"].ToPar();
			this.X0Y1_ブ\u30FCツ1_紐_紐5_紐 = pars4["紐"].ToPar();
			pars2 = pars["アーマ1"].ToPars();
			this.X0Y1_ア\u30FCマ1_鉄靴1 = pars2["鉄靴1"].ToPar();
			this.X0Y1_ア\u30FCマ1_鉄靴2 = pars2["鉄靴2"].ToPar();
			this.X0Y1_ア\u30FCマ1_鉄靴3 = pars2["鉄靴3"].ToPar();
			this.本体.SetJoints();
			this.接続根 = new JointD(this.本体);
			this.右 = e.右;
			this.反転X = e.反転X;
			this.反転Y = e.反転Y;
			this.基準C = e.基準C;
			this.位置C = e.位置C;
			this.角度B = e.角度B;
			this.角度C = e.角度C;
			this.尺度B = e.尺度B;
			this.尺度C = e.尺度C;
			this.尺度XB = e.尺度XB;
			this.尺度XC = e.尺度XC;
			this.尺度YB = e.尺度YB;
			this.尺度YC = e.尺度YC;
			this.肥大 = e.肥大;
			this.身長 = e.身長;
			this.Xv = e.Xv;
			this.Yv = e.Yv;
			this.Xi = e.Xi;
			this.Yi = e.Yi;
			this.サイズ = e.サイズ;
			this.サイズX = e.サイズX;
			this.サイズY = e.サイズY;
			this.ヒ\u30FCル0_靴底_表示 = e.ヒ\u30FCル0_靴底_表示;
			this.ヒ\u30FCル0_ヒ\u30FCル_表示 = e.ヒ\u30FCル0_ヒ\u30FCル_表示;
			this.サンダル0_靴底_表示 = e.サンダル0_靴底_表示;
			this.サンダル0_踵_表示 = e.サンダル0_踵_表示;
			this.ナ\u30FCス0_靴底_表示 = e.ナ\u30FCス0_靴底_表示;
			this.ナ\u30FCス0_踵_表示 = e.ナ\u30FCス0_踵_表示;
			this.ブ\u30FCツ0_靴底_表示 = e.ブ\u30FCツ0_靴底_表示;
			this.ブ\u30FCツ0_ヒ\u30FCル_表示 = e.ブ\u30FCツ0_ヒ\u30FCル_表示;
			this.ア\u30FCマ0_靴底_表示 = e.ア\u30FCマ0_靴底_表示;
			this.ア\u30FCマ0_踵_表示 = e.ア\u30FCマ0_踵_表示;
			this.足_表示 = e.足_表示;
			this.小指_小指1_表示 = e.小指_小指1_表示;
			this.小指_小指2_表示 = e.小指_小指2_表示;
			this.小指_小指3_表示 = e.小指_小指3_表示;
			this.薬指_水掻_表示 = e.薬指_水掻_表示;
			this.薬指_薬指1_表示 = e.薬指_薬指1_表示;
			this.薬指_薬指2_表示 = e.薬指_薬指2_表示;
			this.薬指_薬指3_表示 = e.薬指_薬指3_表示;
			this.中指_水掻_表示 = e.中指_水掻_表示;
			this.中指_中指1_表示 = e.中指_中指1_表示;
			this.中指_中指2_表示 = e.中指_中指2_表示;
			this.中指_中指3_表示 = e.中指_中指3_表示;
			this.人指_人指1_表示 = e.人指_人指1_表示;
			this.人指_人指2_表示 = e.人指_人指2_表示;
			this.人指_人指3_表示 = e.人指_人指3_表示;
			this.人指_水掻_表示 = e.人指_水掻_表示;
			this.親指_親指2_表示 = e.親指_親指2_表示;
			this.親指_親指3_表示 = e.親指_親指3_表示;
			this.親指_水掻_表示 = e.親指_水掻_表示;
			this.悪タトゥ_五芒星_円1_表示 = e.悪タトゥ_五芒星_円1_表示;
			this.悪タトゥ_五芒星_円2_表示 = e.悪タトゥ_五芒星_円2_表示;
			this.悪タトゥ_五芒星_星_表示 = e.悪タトゥ_五芒星_星_表示;
			this.悪タトゥ_五芒星_五角形_表示 = e.悪タトゥ_五芒星_五角形_表示;
			this.竜性_鱗1_表示 = e.竜性_鱗1_表示;
			this.竜性_鱗2_表示 = e.竜性_鱗2_表示;
			this.竜性_鱗3_表示 = e.竜性_鱗3_表示;
			this.竜性_鱗4_表示 = e.竜性_鱗4_表示;
			this.竜性_鱗5_表示 = e.竜性_鱗5_表示;
			this.パンスト_パンスト1_表示 = e.パンスト_パンスト1_表示;
			this.パンスト_パンスト2_表示 = e.パンスト_パンスト2_表示;
			this.ソックス_ソックス1_表示 = e.ソックス_ソックス1_表示;
			this.ソックス_ソックス2_表示 = e.ソックス_ソックス2_表示;
			this.ヒ\u30FCル1_バンプ_表示 = e.ヒ\u30FCル1_バンプ_表示;
			this.ヒ\u30FCル1_ストラップ_ストラップ_表示 = e.ヒ\u30FCル1_ストラップ_ストラップ_表示;
			this.ヒ\u30FCル1_ストラップ_金具1_金具1_表示 = e.ヒ\u30FCル1_ストラップ_金具1_金具1_表示;
			this.ヒ\u30FCル1_ストラップ_金具1_金具2_表示 = e.ヒ\u30FCル1_ストラップ_金具1_金具2_表示;
			this.ヒ\u30FCル1_ストラップ_金具1_金具3_表示 = e.ヒ\u30FCル1_ストラップ_金具1_金具3_表示;
			this.ヒ\u30FCル1_ストラップ_金具1_金具4_表示 = e.ヒ\u30FCル1_ストラップ_金具1_金具4_表示;
			this.ヒ\u30FCル1_ストラップ_金具2_金具1_表示 = e.ヒ\u30FCル1_ストラップ_金具2_金具1_表示;
			this.ヒ\u30FCル1_ストラップ_金具2_金具2_表示 = e.ヒ\u30FCル1_ストラップ_金具2_金具2_表示;
			this.ヒ\u30FCル1_ストラップ_金具2_金具3_表示 = e.ヒ\u30FCル1_ストラップ_金具2_金具3_表示;
			this.ヒ\u30FCル1_ストラップ_金具2_金具4_表示 = e.ヒ\u30FCル1_ストラップ_金具2_金具4_表示;
			this.ヒ\u30FCル1_ハイライト_表示 = e.ヒ\u30FCル1_ハイライト_表示;
			this.サンダル1_ストラップ3_表示 = e.サンダル1_ストラップ3_表示;
			this.サンダル1_ストラップ2_表示 = e.サンダル1_ストラップ2_表示;
			this.サンダル1_ストラップ4_表示 = e.サンダル1_ストラップ4_表示;
			this.サンダル1_ストラップ1_表示 = e.サンダル1_ストラップ1_表示;
			this.ナ\u30FCス1_ストラップ3_ストラップ_表示 = e.ナ\u30FCス1_ストラップ3_ストラップ_表示;
			this.ナ\u30FCス1_ストラップ3_縁1_表示 = e.ナ\u30FCス1_ストラップ3_縁1_表示;
			this.ナ\u30FCス1_ストラップ3_縁2_表示 = e.ナ\u30FCス1_ストラップ3_縁2_表示;
			this.ナ\u30FCス1_ストラップ2_ストラップ_表示 = e.ナ\u30FCス1_ストラップ2_ストラップ_表示;
			this.ナ\u30FCス1_ストラップ2_縁1_表示 = e.ナ\u30FCス1_ストラップ2_縁1_表示;
			this.ナ\u30FCス1_ストラップ2_縁2_表示 = e.ナ\u30FCス1_ストラップ2_縁2_表示;
			this.ナ\u30FCス1_ストラップ1_ストラップ_表示 = e.ナ\u30FCス1_ストラップ1_ストラップ_表示;
			this.ナ\u30FCス1_ストラップ1_縁1_表示 = e.ナ\u30FCス1_ストラップ1_縁1_表示;
			this.ナ\u30FCス1_ストラップ1_縁2_表示 = e.ナ\u30FCス1_ストラップ1_縁2_表示;
			this.ブ\u30FCツ1_タン_表示 = e.ブ\u30FCツ1_タン_表示;
			this.ブ\u30FCツ1_バンプ_バンプ_表示 = e.ブ\u30FCツ1_バンプ_バンプ_表示;
			this.ブ\u30FCツ1_バンプ_縁_縁1_表示 = e.ブ\u30FCツ1_バンプ_縁_縁1_表示;
			this.ブ\u30FCツ1_バンプ_縁_縁2_表示 = e.ブ\u30FCツ1_バンプ_縁_縁2_表示;
			this.ブ\u30FCツ1_バンプ_縁_縁3_表示 = e.ブ\u30FCツ1_バンプ_縁_縁3_表示;
			this.ブ\u30FCツ1_バンプ_縁_縁4_表示 = e.ブ\u30FCツ1_バンプ_縁_縁4_表示;
			this.ブ\u30FCツ1_ハイライト_表示 = e.ブ\u30FCツ1_ハイライト_表示;
			this.ブ\u30FCツ1_柄_表示 = e.ブ\u30FCツ1_柄_表示;
			this.ブ\u30FCツ1_紐_紐1_紐下_金具上_金具_表示 = e.ブ\u30FCツ1_紐_紐1_紐下_金具上_金具_表示;
			this.ブ\u30FCツ1_紐_紐1_紐下_金具上_穴_表示 = e.ブ\u30FCツ1_紐_紐1_紐下_金具上_穴_表示;
			this.ブ\u30FCツ1_紐_紐1_紐下_紐_表示 = e.ブ\u30FCツ1_紐_紐1_紐下_紐_表示;
			this.ブ\u30FCツ1_紐_紐1_紐上_金具上_金具_表示 = e.ブ\u30FCツ1_紐_紐1_紐上_金具上_金具_表示;
			this.ブ\u30FCツ1_紐_紐1_紐上_金具上_穴_表示 = e.ブ\u30FCツ1_紐_紐1_紐上_金具上_穴_表示;
			this.ブ\u30FCツ1_紐_紐1_紐上_紐_表示 = e.ブ\u30FCツ1_紐_紐1_紐上_紐_表示;
			this.ブ\u30FCツ1_紐_紐2_紐下_金具上_金具_表示 = e.ブ\u30FCツ1_紐_紐2_紐下_金具上_金具_表示;
			this.ブ\u30FCツ1_紐_紐2_紐下_金具上_穴_表示 = e.ブ\u30FCツ1_紐_紐2_紐下_金具上_穴_表示;
			this.ブ\u30FCツ1_紐_紐2_紐下_紐_表示 = e.ブ\u30FCツ1_紐_紐2_紐下_紐_表示;
			this.ブ\u30FCツ1_紐_紐2_紐上_金具上_金具_表示 = e.ブ\u30FCツ1_紐_紐2_紐上_金具上_金具_表示;
			this.ブ\u30FCツ1_紐_紐2_紐上_金具上_穴_表示 = e.ブ\u30FCツ1_紐_紐2_紐上_金具上_穴_表示;
			this.ブ\u30FCツ1_紐_紐2_紐上_紐_表示 = e.ブ\u30FCツ1_紐_紐2_紐上_紐_表示;
			this.ブ\u30FCツ1_紐_紐3_紐下_金具上_金具_表示 = e.ブ\u30FCツ1_紐_紐3_紐下_金具上_金具_表示;
			this.ブ\u30FCツ1_紐_紐3_紐下_金具上_穴_表示 = e.ブ\u30FCツ1_紐_紐3_紐下_金具上_穴_表示;
			this.ブ\u30FCツ1_紐_紐3_紐下_紐_表示 = e.ブ\u30FCツ1_紐_紐3_紐下_紐_表示;
			this.ブ\u30FCツ1_紐_紐3_紐上_金具上_金具_表示 = e.ブ\u30FCツ1_紐_紐3_紐上_金具上_金具_表示;
			this.ブ\u30FCツ1_紐_紐3_紐上_金具上_穴_表示 = e.ブ\u30FCツ1_紐_紐3_紐上_金具上_穴_表示;
			this.ブ\u30FCツ1_紐_紐3_紐上_紐_表示 = e.ブ\u30FCツ1_紐_紐3_紐上_紐_表示;
			this.ブ\u30FCツ1_紐_紐4_紐下_金具上_金具_表示 = e.ブ\u30FCツ1_紐_紐4_紐下_金具上_金具_表示;
			this.ブ\u30FCツ1_紐_紐4_紐下_金具上_穴_表示 = e.ブ\u30FCツ1_紐_紐4_紐下_金具上_穴_表示;
			this.ブ\u30FCツ1_紐_紐4_紐下_紐_表示 = e.ブ\u30FCツ1_紐_紐4_紐下_紐_表示;
			this.ブ\u30FCツ1_紐_紐4_紐上_金具上_金具_表示 = e.ブ\u30FCツ1_紐_紐4_紐上_金具上_金具_表示;
			this.ブ\u30FCツ1_紐_紐4_紐上_金具上_穴_表示 = e.ブ\u30FCツ1_紐_紐4_紐上_金具上_穴_表示;
			this.ブ\u30FCツ1_紐_紐4_紐上_紐_表示 = e.ブ\u30FCツ1_紐_紐4_紐上_紐_表示;
			this.ブ\u30FCツ1_紐_紐5_金具1_金具_表示 = e.ブ\u30FCツ1_紐_紐5_金具1_金具_表示;
			this.ブ\u30FCツ1_紐_紐5_金具1_穴_表示 = e.ブ\u30FCツ1_紐_紐5_金具1_穴_表示;
			this.ブ\u30FCツ1_紐_紐5_金具2_金具_表示 = e.ブ\u30FCツ1_紐_紐5_金具2_金具_表示;
			this.ブ\u30FCツ1_紐_紐5_金具2_穴_表示 = e.ブ\u30FCツ1_紐_紐5_金具2_穴_表示;
			this.ブ\u30FCツ1_紐_紐5_紐_表示 = e.ブ\u30FCツ1_紐_紐5_紐_表示;
			this.ア\u30FCマ1_鉄靴1_表示 = e.ア\u30FCマ1_鉄靴1_表示;
			this.ア\u30FCマ1_鉄靴2_表示 = e.ア\u30FCマ1_鉄靴2_表示;
			this.ア\u30FCマ1_鉄靴3_表示 = e.ア\u30FCマ1_鉄靴3_表示;
			this.ナ\u30FCス1_ストラップ4_ストラップ_表示 = e.ナ\u30FCス1_ストラップ4_ストラップ_表示;
			this.ナ\u30FCス1_ストラップ4_縁1_表示 = e.ナ\u30FCス1_ストラップ4_縁1_表示;
			this.ナ\u30FCス1_ストラップ4_縁2_表示 = e.ナ\u30FCス1_ストラップ4_縁2_表示;
			this.鋭爪 = e.鋭爪;
			if (e.虫性)
			{
				this.虫性();
			}
			if (e.虫足)
			{
				this.虫足();
			}
			this.ヒ\u30FCル表示 = e.ヒ\u30FCル表示;
			this.サンダル表示 = e.サンダル表示;
			this.ナ\u30FCス表示 = e.ナ\u30FCス表示;
			this.ブ\u30FCツ表示 = e.ブ\u30FCツ表示;
			this.メイル表示 = e.メイル表示;
			this.パンスト表示 = e.パンスト表示;
			this.ニ\u30FCハイ表示 = e.ニ\u30FCハイ表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_ヒ\u30FCル0_靴底CP = new ColorP(this.X0Y0_ヒ\u30FCル0_靴底, this.ヒ\u30FCル0_靴底CD, DisUnit, true);
			this.X0Y0_サンダル0_靴底CP = new ColorP(this.X0Y0_サンダル0_靴底, this.サンダル0_靴底CD, DisUnit, true);
			this.X0Y0_ナ\u30FCス0_靴底CP = new ColorP(this.X0Y0_ナ\u30FCス0_靴底, this.ナ\u30FCス0_靴底CD, DisUnit, true);
			this.X0Y0_ブ\u30FCツ0_靴底CP = new ColorP(this.X0Y0_ブ\u30FCツ0_靴底, this.ブ\u30FCツ0_靴底CD, DisUnit, true);
			this.X0Y0_ア\u30FCマ0_靴底CP = new ColorP(this.X0Y0_ア\u30FCマ0_靴底, this.ア\u30FCマ0_靴底CD, DisUnit, true);
			this.X0Y0_足CP = new ColorP(this.X0Y0_足, this.足CD, DisUnit, true);
			this.X0Y0_小指_小指1CP = new ColorP(this.X0Y0_小指_小指1, this.小指_小指1CD, DisUnit, true);
			this.X0Y0_小指_小指2CP = new ColorP(this.X0Y0_小指_小指2, this.小指_小指2CD, DisUnit, true);
			this.X0Y0_小指_小指3CP = new ColorP(this.X0Y0_小指_小指3, this.小指_小指3CD, DisUnit, true);
			this.X0Y0_薬指_水掻CP = new ColorP(this.X0Y0_薬指_水掻, this.薬指_水掻CD, DisUnit, true);
			this.X0Y0_薬指_薬指1CP = new ColorP(this.X0Y0_薬指_薬指1, this.薬指_薬指1CD, DisUnit, true);
			this.X0Y0_薬指_薬指2CP = new ColorP(this.X0Y0_薬指_薬指2, this.薬指_薬指2CD, DisUnit, true);
			this.X0Y0_薬指_薬指3CP = new ColorP(this.X0Y0_薬指_薬指3, this.薬指_薬指3CD, DisUnit, true);
			this.X0Y0_中指_水掻CP = new ColorP(this.X0Y0_中指_水掻, this.中指_水掻CD, DisUnit, true);
			this.X0Y0_中指_中指1CP = new ColorP(this.X0Y0_中指_中指1, this.中指_中指1CD, DisUnit, true);
			this.X0Y0_中指_中指2CP = new ColorP(this.X0Y0_中指_中指2, this.中指_中指2CD, DisUnit, true);
			this.X0Y0_中指_中指3CP = new ColorP(this.X0Y0_中指_中指3, this.中指_中指3CD, DisUnit, true);
			this.X0Y0_人指_人指1CP = new ColorP(this.X0Y0_人指_人指1, this.人指_人指1CD, DisUnit, true);
			this.X0Y0_人指_人指2CP = new ColorP(this.X0Y0_人指_人指2, this.人指_人指2CD, DisUnit, true);
			this.X0Y0_人指_人指3CP = new ColorP(this.X0Y0_人指_人指3, this.人指_人指3CD, DisUnit, true);
			this.X0Y0_人指_水掻CP = new ColorP(this.X0Y0_人指_水掻, this.人指_水掻CD, DisUnit, true);
			this.X0Y0_親指_親指2CP = new ColorP(this.X0Y0_親指_親指2, this.親指_親指2CD, DisUnit, true);
			this.X0Y0_親指_親指3CP = new ColorP(this.X0Y0_親指_親指3, this.親指_親指3CD, DisUnit, true);
			this.X0Y0_親指_水掻CP = new ColorP(this.X0Y0_親指_水掻, this.親指_水掻CD, DisUnit, true);
			this.X0Y0_悪タトゥ_五芒星_円1CP = new ColorP(this.X0Y0_悪タトゥ_五芒星_円1, this.悪タトゥ_五芒星_円1CD, DisUnit, false);
			this.X0Y0_悪タトゥ_五芒星_円2CP = new ColorP(this.X0Y0_悪タトゥ_五芒星_円2, this.悪タトゥ_五芒星_円2CD, DisUnit, false);
			this.X0Y0_悪タトゥ_五芒星_星CP = new ColorP(this.X0Y0_悪タトゥ_五芒星_星, this.悪タトゥ_五芒星_星CD, DisUnit, false);
			this.X0Y0_悪タトゥ_五芒星_五角形CP = new ColorP(this.X0Y0_悪タトゥ_五芒星_五角形, this.悪タトゥ_五芒星_五角形CD, DisUnit, false);
			this.X0Y0_竜性_鱗1CP = new ColorP(this.X0Y0_竜性_鱗1, this.竜性_鱗1CD, DisUnit, true);
			this.X0Y0_竜性_鱗2CP = new ColorP(this.X0Y0_竜性_鱗2, this.竜性_鱗2CD, DisUnit, true);
			this.X0Y0_竜性_鱗3CP = new ColorP(this.X0Y0_竜性_鱗3, this.竜性_鱗3CD, DisUnit, true);
			this.X0Y0_竜性_鱗4CP = new ColorP(this.X0Y0_竜性_鱗4, this.竜性_鱗4CD, DisUnit, true);
			this.X0Y0_竜性_鱗5CP = new ColorP(this.X0Y0_竜性_鱗5, this.竜性_鱗5CD, DisUnit, true);
			this.X0Y0_パンスト_パンスト1CP = new ColorP(this.X0Y0_パンスト_パンスト1, this.パンスト_パンスト1CD, DisUnit, false);
			this.X0Y0_パンスト_パンスト2CP = new ColorP(this.X0Y0_パンスト_パンスト2, this.パンスト_パンスト2CD, DisUnit, true);
			this.X0Y0_ソックス_ソックス1CP = new ColorP(this.X0Y0_ソックス_ソックス1, this.ソックス_ソックス1CD, DisUnit, false);
			this.X0Y0_ソックス_ソックス2CP = new ColorP(this.X0Y0_ソックス_ソックス2, this.ソックス_ソックス2CD, DisUnit, true);
			this.X0Y0_ヒ\u30FCル1_バンプCP = new ColorP(this.X0Y0_ヒ\u30FCル1_バンプ, this.ヒ\u30FCル1_バンプCD, DisUnit, true);
			this.X0Y0_ヒ\u30FCル1_ストラップ_ストラップCP = new ColorP(this.X0Y0_ヒ\u30FCル1_ストラップ_ストラップ, this.ヒ\u30FCル1_ストラップ_ストラップCD, DisUnit, true);
			this.X0Y0_ヒ\u30FCル1_ストラップ_金具1_金具1CP = new ColorP(this.X0Y0_ヒ\u30FCル1_ストラップ_金具1_金具1, this.ヒ\u30FCル1_ストラップ_金具1_金具1CD, DisUnit, true);
			this.X0Y0_ヒ\u30FCル1_ストラップ_金具1_金具2CP = new ColorP(this.X0Y0_ヒ\u30FCル1_ストラップ_金具1_金具2, this.ヒ\u30FCル1_ストラップ_金具1_金具2CD, DisUnit, true);
			this.X0Y0_ヒ\u30FCル1_ストラップ_金具1_金具3CP = new ColorP(this.X0Y0_ヒ\u30FCル1_ストラップ_金具1_金具3, this.ヒ\u30FCル1_ストラップ_金具1_金具3CD, DisUnit, true);
			this.X0Y0_ヒ\u30FCル1_ストラップ_金具1_金具4CP = new ColorP(this.X0Y0_ヒ\u30FCル1_ストラップ_金具1_金具4, this.ヒ\u30FCル1_ストラップ_金具1_金具4CD, DisUnit, true);
			this.X0Y0_ヒ\u30FCル1_ストラップ_金具2_金具1CP = new ColorP(this.X0Y0_ヒ\u30FCル1_ストラップ_金具2_金具1, this.ヒ\u30FCル1_ストラップ_金具2_金具1CD, DisUnit, true);
			this.X0Y0_ヒ\u30FCル1_ストラップ_金具2_金具2CP = new ColorP(this.X0Y0_ヒ\u30FCル1_ストラップ_金具2_金具2, this.ヒ\u30FCル1_ストラップ_金具2_金具2CD, DisUnit, true);
			this.X0Y0_ヒ\u30FCル1_ストラップ_金具2_金具3CP = new ColorP(this.X0Y0_ヒ\u30FCル1_ストラップ_金具2_金具3, this.ヒ\u30FCル1_ストラップ_金具2_金具3CD, DisUnit, true);
			this.X0Y0_ヒ\u30FCル1_ストラップ_金具2_金具4CP = new ColorP(this.X0Y0_ヒ\u30FCル1_ストラップ_金具2_金具4, this.ヒ\u30FCル1_ストラップ_金具2_金具4CD, DisUnit, true);
			this.X0Y0_ヒ\u30FCル1_ハイライトCP = new ColorP(this.X0Y0_ヒ\u30FCル1_ハイライト, this.ヒ\u30FCル1_ハイライトCD, DisUnit, true);
			this.X0Y0_サンダル1_ストラップ3CP = new ColorP(this.X0Y0_サンダル1_ストラップ3, this.サンダル1_ストラップ3CD, DisUnit, true);
			this.X0Y0_サンダル1_ストラップ2CP = new ColorP(this.X0Y0_サンダル1_ストラップ2, this.サンダル1_ストラップ2CD, DisUnit, true);
			this.X0Y0_サンダル1_ストラップ4CP = new ColorP(this.X0Y0_サンダル1_ストラップ4, this.サンダル1_ストラップ4CD, DisUnit, true);
			this.X0Y0_サンダル1_ストラップ1CP = new ColorP(this.X0Y0_サンダル1_ストラップ1, this.サンダル1_ストラップ1CD, DisUnit, true);
			this.X0Y0_ナ\u30FCス1_ストラップ3_ストラップCP = new ColorP(this.X0Y0_ナ\u30FCス1_ストラップ3_ストラップ, this.ナ\u30FCス1_ストラップ3_ストラップCD, DisUnit, true);
			this.X0Y0_ナ\u30FCス1_ストラップ3_縁1CP = new ColorP(this.X0Y0_ナ\u30FCス1_ストラップ3_縁1, this.ナ\u30FCス1_ストラップ3_縁1CD, DisUnit, true);
			this.X0Y0_ナ\u30FCス1_ストラップ3_縁2CP = new ColorP(this.X0Y0_ナ\u30FCス1_ストラップ3_縁2, this.ナ\u30FCス1_ストラップ3_縁2CD, DisUnit, true);
			this.X0Y0_ナ\u30FCス1_ストラップ2_ストラップCP = new ColorP(this.X0Y0_ナ\u30FCス1_ストラップ2_ストラップ, this.ナ\u30FCス1_ストラップ2_ストラップCD, DisUnit, true);
			this.X0Y0_ナ\u30FCス1_ストラップ2_縁1CP = new ColorP(this.X0Y0_ナ\u30FCス1_ストラップ2_縁1, this.ナ\u30FCス1_ストラップ2_縁1CD, DisUnit, true);
			this.X0Y0_ナ\u30FCス1_ストラップ2_縁2CP = new ColorP(this.X0Y0_ナ\u30FCス1_ストラップ2_縁2, this.ナ\u30FCス1_ストラップ2_縁2CD, DisUnit, true);
			this.X0Y0_ナ\u30FCス1_ストラップ1_ストラップCP = new ColorP(this.X0Y0_ナ\u30FCス1_ストラップ1_ストラップ, this.ナ\u30FCス1_ストラップ1_ストラップCD, DisUnit, true);
			this.X0Y0_ナ\u30FCス1_ストラップ1_縁1CP = new ColorP(this.X0Y0_ナ\u30FCス1_ストラップ1_縁1, this.ナ\u30FCス1_ストラップ1_縁1CD, DisUnit, true);
			this.X0Y0_ナ\u30FCス1_ストラップ1_縁2CP = new ColorP(this.X0Y0_ナ\u30FCス1_ストラップ1_縁2, this.ナ\u30FCス1_ストラップ1_縁2CD, DisUnit, true);
			this.X0Y0_ブ\u30FCツ1_タンCP = new ColorP(this.X0Y0_ブ\u30FCツ1_タン, this.ブ\u30FCツ1_タンCD, DisUnit, true);
			this.X0Y0_ブ\u30FCツ1_バンプ_バンプCP = new ColorP(this.X0Y0_ブ\u30FCツ1_バンプ_バンプ, this.ブ\u30FCツ1_バンプ_バンプCD, DisUnit, true);
			this.X0Y0_ブ\u30FCツ1_バンプ_縁_縁1CP = new ColorP(this.X0Y0_ブ\u30FCツ1_バンプ_縁_縁1, this.ブ\u30FCツ1_バンプ_縁_縁1CD, DisUnit, true);
			this.X0Y0_ブ\u30FCツ1_バンプ_縁_縁2CP = new ColorP(this.X0Y0_ブ\u30FCツ1_バンプ_縁_縁2, this.ブ\u30FCツ1_バンプ_縁_縁2CD, DisUnit, true);
			this.X0Y0_ブ\u30FCツ1_バンプ_縁_縁3CP = new ColorP(this.X0Y0_ブ\u30FCツ1_バンプ_縁_縁3, this.ブ\u30FCツ1_バンプ_縁_縁3CD, DisUnit, true);
			this.X0Y0_ブ\u30FCツ1_バンプ_縁_縁4CP = new ColorP(this.X0Y0_ブ\u30FCツ1_バンプ_縁_縁4, this.ブ\u30FCツ1_バンプ_縁_縁4CD, DisUnit, true);
			this.X0Y0_ブ\u30FCツ1_ハイライトCP = new ColorP(this.X0Y0_ブ\u30FCツ1_ハイライト, this.ブ\u30FCツ1_ハイライトCD, DisUnit, true);
			this.X0Y0_ブ\u30FCツ1_柄CP = new ColorP(this.X0Y0_ブ\u30FCツ1_柄, this.ブ\u30FCツ1_柄CD, DisUnit, true);
			this.X0Y0_ブ\u30FCツ1_紐_紐1_紐下_金具上_金具CP = new ColorP(this.X0Y0_ブ\u30FCツ1_紐_紐1_紐下_金具上_金具, this.ブ\u30FCツ1_紐_紐1_紐下_金具上_金具CD, DisUnit, true);
			this.X0Y0_ブ\u30FCツ1_紐_紐1_紐下_金具上_穴CP = new ColorP(this.X0Y0_ブ\u30FCツ1_紐_紐1_紐下_金具上_穴, this.ブ\u30FCツ1_紐_紐1_紐下_金具上_穴CD, DisUnit, true);
			this.X0Y0_ブ\u30FCツ1_紐_紐1_紐下_紐CP = new ColorP(this.X0Y0_ブ\u30FCツ1_紐_紐1_紐下_紐, this.ブ\u30FCツ1_紐_紐1_紐下_紐CD, DisUnit, true);
			this.X0Y0_ブ\u30FCツ1_紐_紐1_紐上_金具上_金具CP = new ColorP(this.X0Y0_ブ\u30FCツ1_紐_紐1_紐上_金具上_金具, this.ブ\u30FCツ1_紐_紐1_紐上_金具上_金具CD, DisUnit, true);
			this.X0Y0_ブ\u30FCツ1_紐_紐1_紐上_金具上_穴CP = new ColorP(this.X0Y0_ブ\u30FCツ1_紐_紐1_紐上_金具上_穴, this.ブ\u30FCツ1_紐_紐1_紐上_金具上_穴CD, DisUnit, true);
			this.X0Y0_ブ\u30FCツ1_紐_紐1_紐上_紐CP = new ColorP(this.X0Y0_ブ\u30FCツ1_紐_紐1_紐上_紐, this.ブ\u30FCツ1_紐_紐1_紐上_紐CD, DisUnit, true);
			this.X0Y0_ブ\u30FCツ1_紐_紐2_紐下_金具上_金具CP = new ColorP(this.X0Y0_ブ\u30FCツ1_紐_紐2_紐下_金具上_金具, this.ブ\u30FCツ1_紐_紐2_紐下_金具上_金具CD, DisUnit, true);
			this.X0Y0_ブ\u30FCツ1_紐_紐2_紐下_金具上_穴CP = new ColorP(this.X0Y0_ブ\u30FCツ1_紐_紐2_紐下_金具上_穴, this.ブ\u30FCツ1_紐_紐2_紐下_金具上_穴CD, DisUnit, true);
			this.X0Y0_ブ\u30FCツ1_紐_紐2_紐下_紐CP = new ColorP(this.X0Y0_ブ\u30FCツ1_紐_紐2_紐下_紐, this.ブ\u30FCツ1_紐_紐2_紐下_紐CD, DisUnit, true);
			this.X0Y0_ブ\u30FCツ1_紐_紐2_紐上_金具上_金具CP = new ColorP(this.X0Y0_ブ\u30FCツ1_紐_紐2_紐上_金具上_金具, this.ブ\u30FCツ1_紐_紐2_紐上_金具上_金具CD, DisUnit, true);
			this.X0Y0_ブ\u30FCツ1_紐_紐2_紐上_金具上_穴CP = new ColorP(this.X0Y0_ブ\u30FCツ1_紐_紐2_紐上_金具上_穴, this.ブ\u30FCツ1_紐_紐2_紐上_金具上_穴CD, DisUnit, true);
			this.X0Y0_ブ\u30FCツ1_紐_紐2_紐上_紐CP = new ColorP(this.X0Y0_ブ\u30FCツ1_紐_紐2_紐上_紐, this.ブ\u30FCツ1_紐_紐2_紐上_紐CD, DisUnit, true);
			this.X0Y0_ブ\u30FCツ1_紐_紐3_紐下_金具上_金具CP = new ColorP(this.X0Y0_ブ\u30FCツ1_紐_紐3_紐下_金具上_金具, this.ブ\u30FCツ1_紐_紐3_紐下_金具上_金具CD, DisUnit, true);
			this.X0Y0_ブ\u30FCツ1_紐_紐3_紐下_金具上_穴CP = new ColorP(this.X0Y0_ブ\u30FCツ1_紐_紐3_紐下_金具上_穴, this.ブ\u30FCツ1_紐_紐3_紐下_金具上_穴CD, DisUnit, true);
			this.X0Y0_ブ\u30FCツ1_紐_紐3_紐下_紐CP = new ColorP(this.X0Y0_ブ\u30FCツ1_紐_紐3_紐下_紐, this.ブ\u30FCツ1_紐_紐3_紐下_紐CD, DisUnit, true);
			this.X0Y0_ブ\u30FCツ1_紐_紐3_紐上_金具上_金具CP = new ColorP(this.X0Y0_ブ\u30FCツ1_紐_紐3_紐上_金具上_金具, this.ブ\u30FCツ1_紐_紐3_紐上_金具上_金具CD, DisUnit, true);
			this.X0Y0_ブ\u30FCツ1_紐_紐3_紐上_金具上_穴CP = new ColorP(this.X0Y0_ブ\u30FCツ1_紐_紐3_紐上_金具上_穴, this.ブ\u30FCツ1_紐_紐3_紐上_金具上_穴CD, DisUnit, true);
			this.X0Y0_ブ\u30FCツ1_紐_紐3_紐上_紐CP = new ColorP(this.X0Y0_ブ\u30FCツ1_紐_紐3_紐上_紐, this.ブ\u30FCツ1_紐_紐3_紐上_紐CD, DisUnit, true);
			this.X0Y0_ブ\u30FCツ1_紐_紐4_紐下_金具上_金具CP = new ColorP(this.X0Y0_ブ\u30FCツ1_紐_紐4_紐下_金具上_金具, this.ブ\u30FCツ1_紐_紐4_紐下_金具上_金具CD, DisUnit, true);
			this.X0Y0_ブ\u30FCツ1_紐_紐4_紐下_金具上_穴CP = new ColorP(this.X0Y0_ブ\u30FCツ1_紐_紐4_紐下_金具上_穴, this.ブ\u30FCツ1_紐_紐4_紐下_金具上_穴CD, DisUnit, true);
			this.X0Y0_ブ\u30FCツ1_紐_紐4_紐下_紐CP = new ColorP(this.X0Y0_ブ\u30FCツ1_紐_紐4_紐下_紐, this.ブ\u30FCツ1_紐_紐4_紐下_紐CD, DisUnit, true);
			this.X0Y0_ブ\u30FCツ1_紐_紐4_紐上_金具上_金具CP = new ColorP(this.X0Y0_ブ\u30FCツ1_紐_紐4_紐上_金具上_金具, this.ブ\u30FCツ1_紐_紐4_紐上_金具上_金具CD, DisUnit, true);
			this.X0Y0_ブ\u30FCツ1_紐_紐4_紐上_金具上_穴CP = new ColorP(this.X0Y0_ブ\u30FCツ1_紐_紐4_紐上_金具上_穴, this.ブ\u30FCツ1_紐_紐4_紐上_金具上_穴CD, DisUnit, true);
			this.X0Y0_ブ\u30FCツ1_紐_紐4_紐上_紐CP = new ColorP(this.X0Y0_ブ\u30FCツ1_紐_紐4_紐上_紐, this.ブ\u30FCツ1_紐_紐4_紐上_紐CD, DisUnit, true);
			this.X0Y0_ブ\u30FCツ1_紐_紐5_金具1_金具CP = new ColorP(this.X0Y0_ブ\u30FCツ1_紐_紐5_金具1_金具, this.ブ\u30FCツ1_紐_紐5_金具1_金具CD, DisUnit, true);
			this.X0Y0_ブ\u30FCツ1_紐_紐5_金具1_穴CP = new ColorP(this.X0Y0_ブ\u30FCツ1_紐_紐5_金具1_穴, this.ブ\u30FCツ1_紐_紐5_金具1_穴CD, DisUnit, true);
			this.X0Y0_ブ\u30FCツ1_紐_紐5_金具2_金具CP = new ColorP(this.X0Y0_ブ\u30FCツ1_紐_紐5_金具2_金具, this.ブ\u30FCツ1_紐_紐5_金具2_金具CD, DisUnit, true);
			this.X0Y0_ブ\u30FCツ1_紐_紐5_金具2_穴CP = new ColorP(this.X0Y0_ブ\u30FCツ1_紐_紐5_金具2_穴, this.ブ\u30FCツ1_紐_紐5_金具2_穴CD, DisUnit, true);
			this.X0Y0_ブ\u30FCツ1_紐_紐5_紐CP = new ColorP(this.X0Y0_ブ\u30FCツ1_紐_紐5_紐, this.ブ\u30FCツ1_紐_紐5_紐CD, DisUnit, true);
			this.X0Y0_ア\u30FCマ1_鉄靴1CP = new ColorP(this.X0Y0_ア\u30FCマ1_鉄靴1, this.ア\u30FCマ1_鉄靴1CD, DisUnit, true);
			this.X0Y0_ア\u30FCマ1_鉄靴2CP = new ColorP(this.X0Y0_ア\u30FCマ1_鉄靴2, this.ア\u30FCマ1_鉄靴2CD, DisUnit, true);
			this.X0Y0_ア\u30FCマ1_鉄靴3CP = new ColorP(this.X0Y0_ア\u30FCマ1_鉄靴3, this.ア\u30FCマ1_鉄靴3CD, DisUnit, true);
			this.X0Y1_ヒ\u30FCル0_ヒ\u30FCルCP = new ColorP(this.X0Y1_ヒ\u30FCル0_ヒ\u30FCル, this.ヒ\u30FCル0_ヒ\u30FCルCD, DisUnit, true);
			this.X0Y1_ヒ\u30FCル0_靴底CP = new ColorP(this.X0Y1_ヒ\u30FCル0_靴底, this.ヒ\u30FCル0_靴底CD, DisUnit, true);
			this.X0Y1_サンダル0_踵CP = new ColorP(this.X0Y1_サンダル0_踵, this.サンダル0_踵CD, DisUnit, true);
			this.X0Y1_サンダル0_靴底CP = new ColorP(this.X0Y1_サンダル0_靴底, this.サンダル0_靴底CD, DisUnit, true);
			this.X0Y1_ナ\u30FCス0_踵CP = new ColorP(this.X0Y1_ナ\u30FCス0_踵, this.ナ\u30FCス0_踵CD, DisUnit, true);
			this.X0Y1_ナ\u30FCス0_靴底CP = new ColorP(this.X0Y1_ナ\u30FCス0_靴底, this.ナ\u30FCス0_靴底CD, DisUnit, true);
			this.X0Y1_ブ\u30FCツ0_ヒ\u30FCルCP = new ColorP(this.X0Y1_ブ\u30FCツ0_ヒ\u30FCル, this.ブ\u30FCツ0_ヒ\u30FCルCD, DisUnit, true);
			this.X0Y1_ブ\u30FCツ0_靴底CP = new ColorP(this.X0Y1_ブ\u30FCツ0_靴底, this.ブ\u30FCツ0_靴底CD, DisUnit, true);
			this.X0Y1_ア\u30FCマ0_踵CP = new ColorP(this.X0Y1_ア\u30FCマ0_踵, this.ア\u30FCマ0_踵CD, DisUnit, true);
			this.X0Y1_ア\u30FCマ0_靴底CP = new ColorP(this.X0Y1_ア\u30FCマ0_靴底, this.ア\u30FCマ0_靴底CD, DisUnit, true);
			this.X0Y1_足CP = new ColorP(this.X0Y1_足, this.足CD, DisUnit, true);
			this.X0Y1_小指_小指1CP = new ColorP(this.X0Y1_小指_小指1, this.小指_小指1CD, DisUnit, true);
			this.X0Y1_小指_小指2CP = new ColorP(this.X0Y1_小指_小指2, this.小指_小指2CD, DisUnit, true);
			this.X0Y1_小指_小指3CP = new ColorP(this.X0Y1_小指_小指3, this.小指_小指3CD, DisUnit, true);
			this.X0Y1_薬指_水掻CP = new ColorP(this.X0Y1_薬指_水掻, this.薬指_水掻CD, DisUnit, true);
			this.X0Y1_薬指_薬指1CP = new ColorP(this.X0Y1_薬指_薬指1, this.薬指_薬指1CD, DisUnit, true);
			this.X0Y1_薬指_薬指2CP = new ColorP(this.X0Y1_薬指_薬指2, this.薬指_薬指2CD, DisUnit, true);
			this.X0Y1_薬指_薬指3CP = new ColorP(this.X0Y1_薬指_薬指3, this.薬指_薬指3CD, DisUnit, true);
			this.X0Y1_中指_水掻CP = new ColorP(this.X0Y1_中指_水掻, this.中指_水掻CD, DisUnit, true);
			this.X0Y1_中指_中指1CP = new ColorP(this.X0Y1_中指_中指1, this.中指_中指1CD, DisUnit, true);
			this.X0Y1_中指_中指2CP = new ColorP(this.X0Y1_中指_中指2, this.中指_中指2CD, DisUnit, true);
			this.X0Y1_中指_中指3CP = new ColorP(this.X0Y1_中指_中指3, this.中指_中指3CD, DisUnit, true);
			this.X0Y1_人指_水掻CP = new ColorP(this.X0Y1_人指_水掻, this.人指_水掻CD, DisUnit, true);
			this.X0Y1_人指_人指1CP = new ColorP(this.X0Y1_人指_人指1, this.人指_人指1CD, DisUnit, true);
			this.X0Y1_人指_人指2CP = new ColorP(this.X0Y1_人指_人指2, this.人指_人指2CD, DisUnit, true);
			this.X0Y1_人指_人指3CP = new ColorP(this.X0Y1_人指_人指3, this.人指_人指3CD, DisUnit, true);
			this.X0Y1_親指_水掻CP = new ColorP(this.X0Y1_親指_水掻, this.親指_水掻CD, DisUnit, true);
			this.X0Y1_親指_親指2CP = new ColorP(this.X0Y1_親指_親指2, this.親指_親指2CD, DisUnit, true);
			this.X0Y1_親指_親指3CP = new ColorP(this.X0Y1_親指_親指3, this.親指_親指3CD, DisUnit, true);
			this.X0Y1_悪タトゥ_五芒星_円1CP = new ColorP(this.X0Y1_悪タトゥ_五芒星_円1, this.悪タトゥ_五芒星_円1CD, DisUnit, false);
			this.X0Y1_悪タトゥ_五芒星_円2CP = new ColorP(this.X0Y1_悪タトゥ_五芒星_円2, this.悪タトゥ_五芒星_円2CD, DisUnit, false);
			this.X0Y1_悪タトゥ_五芒星_星CP = new ColorP(this.X0Y1_悪タトゥ_五芒星_星, this.悪タトゥ_五芒星_星CD, DisUnit, false);
			this.X0Y1_悪タトゥ_五芒星_五角形CP = new ColorP(this.X0Y1_悪タトゥ_五芒星_五角形, this.悪タトゥ_五芒星_五角形CD, DisUnit, false);
			this.X0Y1_竜性_鱗1CP = new ColorP(this.X0Y1_竜性_鱗1, this.竜性_鱗1CD, DisUnit, true);
			this.X0Y1_竜性_鱗2CP = new ColorP(this.X0Y1_竜性_鱗2, this.竜性_鱗2CD, DisUnit, true);
			this.X0Y1_竜性_鱗3CP = new ColorP(this.X0Y1_竜性_鱗3, this.竜性_鱗3CD, DisUnit, true);
			this.X0Y1_竜性_鱗4CP = new ColorP(this.X0Y1_竜性_鱗4, this.竜性_鱗4CD, DisUnit, true);
			this.X0Y1_竜性_鱗5CP = new ColorP(this.X0Y1_竜性_鱗5, this.竜性_鱗5CD, DisUnit, true);
			this.X0Y1_パンスト_パンスト1CP = new ColorP(this.X0Y1_パンスト_パンスト1, this.パンスト_パンスト1CD, DisUnit, false);
			this.X0Y1_パンスト_パンスト2CP = new ColorP(this.X0Y1_パンスト_パンスト2, this.パンスト_パンスト2CD, DisUnit, true);
			this.X0Y1_ソックス_ソックス1CP = new ColorP(this.X0Y1_ソックス_ソックス1, this.ソックス_ソックス1CD, DisUnit, false);
			this.X0Y1_ソックス_ソックス2CP = new ColorP(this.X0Y1_ソックス_ソックス2, this.ソックス_ソックス2CD, DisUnit, true);
			this.X0Y1_ヒ\u30FCル1_バンプCP = new ColorP(this.X0Y1_ヒ\u30FCル1_バンプ, this.ヒ\u30FCル1_バンプCD, DisUnit, true);
			this.X0Y1_ヒ\u30FCル1_ストラップ_ストラップCP = new ColorP(this.X0Y1_ヒ\u30FCル1_ストラップ_ストラップ, this.ヒ\u30FCル1_ストラップ_ストラップCD, DisUnit, true);
			this.X0Y1_ヒ\u30FCル1_ストラップ_金具1_金具1CP = new ColorP(this.X0Y1_ヒ\u30FCル1_ストラップ_金具1_金具1, this.ヒ\u30FCル1_ストラップ_金具1_金具1CD, DisUnit, true);
			this.X0Y1_ヒ\u30FCル1_ストラップ_金具1_金具2CP = new ColorP(this.X0Y1_ヒ\u30FCル1_ストラップ_金具1_金具2, this.ヒ\u30FCル1_ストラップ_金具1_金具2CD, DisUnit, true);
			this.X0Y1_ヒ\u30FCル1_ストラップ_金具1_金具3CP = new ColorP(this.X0Y1_ヒ\u30FCル1_ストラップ_金具1_金具3, this.ヒ\u30FCル1_ストラップ_金具1_金具3CD, DisUnit, true);
			this.X0Y1_ヒ\u30FCル1_ストラップ_金具1_金具4CP = new ColorP(this.X0Y1_ヒ\u30FCル1_ストラップ_金具1_金具4, this.ヒ\u30FCル1_ストラップ_金具1_金具4CD, DisUnit, true);
			this.X0Y1_ヒ\u30FCル1_ストラップ_金具2_金具1CP = new ColorP(this.X0Y1_ヒ\u30FCル1_ストラップ_金具2_金具1, this.ヒ\u30FCル1_ストラップ_金具2_金具1CD, DisUnit, true);
			this.X0Y1_ヒ\u30FCル1_ストラップ_金具2_金具2CP = new ColorP(this.X0Y1_ヒ\u30FCル1_ストラップ_金具2_金具2, this.ヒ\u30FCル1_ストラップ_金具2_金具2CD, DisUnit, true);
			this.X0Y1_ヒ\u30FCル1_ストラップ_金具2_金具3CP = new ColorP(this.X0Y1_ヒ\u30FCル1_ストラップ_金具2_金具3, this.ヒ\u30FCル1_ストラップ_金具2_金具3CD, DisUnit, true);
			this.X0Y1_ヒ\u30FCル1_ストラップ_金具2_金具4CP = new ColorP(this.X0Y1_ヒ\u30FCル1_ストラップ_金具2_金具4, this.ヒ\u30FCル1_ストラップ_金具2_金具4CD, DisUnit, true);
			this.X0Y1_ヒ\u30FCル1_ハイライトCP = new ColorP(this.X0Y1_ヒ\u30FCル1_ハイライト, this.ヒ\u30FCル1_ハイライトCD, DisUnit, true);
			this.X0Y1_サンダル1_ストラップ3CP = new ColorP(this.X0Y1_サンダル1_ストラップ3, this.サンダル1_ストラップ3CD, DisUnit, true);
			this.X0Y1_サンダル1_ストラップ2CP = new ColorP(this.X0Y1_サンダル1_ストラップ2, this.サンダル1_ストラップ2CD, DisUnit, true);
			this.X0Y1_サンダル1_ストラップ4CP = new ColorP(this.X0Y1_サンダル1_ストラップ4, this.サンダル1_ストラップ4CD, DisUnit, true);
			this.X0Y1_サンダル1_ストラップ1CP = new ColorP(this.X0Y1_サンダル1_ストラップ1, this.サンダル1_ストラップ1CD, DisUnit, true);
			this.X0Y1_ナ\u30FCス1_ストラップ4_ストラップCP = new ColorP(this.X0Y1_ナ\u30FCス1_ストラップ4_ストラップ, this.ナ\u30FCス1_ストラップ4_ストラップCD, DisUnit, true);
			this.X0Y1_ナ\u30FCス1_ストラップ4_縁1CP = new ColorP(this.X0Y1_ナ\u30FCス1_ストラップ4_縁1, this.ナ\u30FCス1_ストラップ4_縁1CD, DisUnit, true);
			this.X0Y1_ナ\u30FCス1_ストラップ4_縁2CP = new ColorP(this.X0Y1_ナ\u30FCス1_ストラップ4_縁2, this.ナ\u30FCス1_ストラップ4_縁2CD, DisUnit, true);
			this.X0Y1_ナ\u30FCス1_ストラップ3_ストラップCP = new ColorP(this.X0Y1_ナ\u30FCス1_ストラップ3_ストラップ, this.ナ\u30FCス1_ストラップ3_ストラップCD, DisUnit, true);
			this.X0Y1_ナ\u30FCス1_ストラップ3_縁1CP = new ColorP(this.X0Y1_ナ\u30FCス1_ストラップ3_縁1, this.ナ\u30FCス1_ストラップ3_縁1CD, DisUnit, true);
			this.X0Y1_ナ\u30FCス1_ストラップ3_縁2CP = new ColorP(this.X0Y1_ナ\u30FCス1_ストラップ3_縁2, this.ナ\u30FCス1_ストラップ3_縁2CD, DisUnit, true);
			this.X0Y1_ナ\u30FCス1_ストラップ2_ストラップCP = new ColorP(this.X0Y1_ナ\u30FCス1_ストラップ2_ストラップ, this.ナ\u30FCス1_ストラップ2_ストラップCD, DisUnit, true);
			this.X0Y1_ナ\u30FCス1_ストラップ2_縁1CP = new ColorP(this.X0Y1_ナ\u30FCス1_ストラップ2_縁1, this.ナ\u30FCス1_ストラップ2_縁1CD, DisUnit, true);
			this.X0Y1_ナ\u30FCス1_ストラップ2_縁2CP = new ColorP(this.X0Y1_ナ\u30FCス1_ストラップ2_縁2, this.ナ\u30FCス1_ストラップ2_縁2CD, DisUnit, true);
			this.X0Y1_ナ\u30FCス1_ストラップ1_ストラップCP = new ColorP(this.X0Y1_ナ\u30FCス1_ストラップ1_ストラップ, this.ナ\u30FCス1_ストラップ1_ストラップCD, DisUnit, true);
			this.X0Y1_ナ\u30FCス1_ストラップ1_縁1CP = new ColorP(this.X0Y1_ナ\u30FCス1_ストラップ1_縁1, this.ナ\u30FCス1_ストラップ1_縁1CD, DisUnit, true);
			this.X0Y1_ナ\u30FCス1_ストラップ1_縁2CP = new ColorP(this.X0Y1_ナ\u30FCス1_ストラップ1_縁2, this.ナ\u30FCス1_ストラップ1_縁2CD, DisUnit, true);
			this.X0Y1_ブ\u30FCツ1_タンCP = new ColorP(this.X0Y1_ブ\u30FCツ1_タン, this.ブ\u30FCツ1_タンCD, DisUnit, true);
			this.X0Y1_ブ\u30FCツ1_バンプ_バンプCP = new ColorP(this.X0Y1_ブ\u30FCツ1_バンプ_バンプ, this.ブ\u30FCツ1_バンプ_バンプCD, DisUnit, true);
			this.X0Y1_ブ\u30FCツ1_バンプ_縁_縁1CP = new ColorP(this.X0Y1_ブ\u30FCツ1_バンプ_縁_縁1, this.ブ\u30FCツ1_バンプ_縁_縁1CD, DisUnit, true);
			this.X0Y1_ブ\u30FCツ1_バンプ_縁_縁2CP = new ColorP(this.X0Y1_ブ\u30FCツ1_バンプ_縁_縁2, this.ブ\u30FCツ1_バンプ_縁_縁2CD, DisUnit, true);
			this.X0Y1_ブ\u30FCツ1_バンプ_縁_縁3CP = new ColorP(this.X0Y1_ブ\u30FCツ1_バンプ_縁_縁3, this.ブ\u30FCツ1_バンプ_縁_縁3CD, DisUnit, true);
			this.X0Y1_ブ\u30FCツ1_バンプ_縁_縁4CP = new ColorP(this.X0Y1_ブ\u30FCツ1_バンプ_縁_縁4, this.ブ\u30FCツ1_バンプ_縁_縁4CD, DisUnit, true);
			this.X0Y1_ブ\u30FCツ1_ハイライトCP = new ColorP(this.X0Y1_ブ\u30FCツ1_ハイライト, this.ブ\u30FCツ1_ハイライトCD, DisUnit, true);
			this.X0Y1_ブ\u30FCツ1_柄CP = new ColorP(this.X0Y1_ブ\u30FCツ1_柄, this.ブ\u30FCツ1_柄CD, DisUnit, true);
			this.X0Y1_ブ\u30FCツ1_紐_紐1_紐下_金具上_金具CP = new ColorP(this.X0Y1_ブ\u30FCツ1_紐_紐1_紐下_金具上_金具, this.ブ\u30FCツ1_紐_紐1_紐下_金具上_金具CD, DisUnit, true);
			this.X0Y1_ブ\u30FCツ1_紐_紐1_紐下_金具上_穴CP = new ColorP(this.X0Y1_ブ\u30FCツ1_紐_紐1_紐下_金具上_穴, this.ブ\u30FCツ1_紐_紐1_紐下_金具上_穴CD, DisUnit, true);
			this.X0Y1_ブ\u30FCツ1_紐_紐1_紐下_紐CP = new ColorP(this.X0Y1_ブ\u30FCツ1_紐_紐1_紐下_紐, this.ブ\u30FCツ1_紐_紐1_紐下_紐CD, DisUnit, true);
			this.X0Y1_ブ\u30FCツ1_紐_紐1_紐上_金具上_金具CP = new ColorP(this.X0Y1_ブ\u30FCツ1_紐_紐1_紐上_金具上_金具, this.ブ\u30FCツ1_紐_紐1_紐上_金具上_金具CD, DisUnit, true);
			this.X0Y1_ブ\u30FCツ1_紐_紐1_紐上_金具上_穴CP = new ColorP(this.X0Y1_ブ\u30FCツ1_紐_紐1_紐上_金具上_穴, this.ブ\u30FCツ1_紐_紐1_紐上_金具上_穴CD, DisUnit, true);
			this.X0Y1_ブ\u30FCツ1_紐_紐1_紐上_紐CP = new ColorP(this.X0Y1_ブ\u30FCツ1_紐_紐1_紐上_紐, this.ブ\u30FCツ1_紐_紐1_紐上_紐CD, DisUnit, true);
			this.X0Y1_ブ\u30FCツ1_紐_紐2_紐下_金具上_金具CP = new ColorP(this.X0Y1_ブ\u30FCツ1_紐_紐2_紐下_金具上_金具, this.ブ\u30FCツ1_紐_紐2_紐下_金具上_金具CD, DisUnit, true);
			this.X0Y1_ブ\u30FCツ1_紐_紐2_紐下_金具上_穴CP = new ColorP(this.X0Y1_ブ\u30FCツ1_紐_紐2_紐下_金具上_穴, this.ブ\u30FCツ1_紐_紐2_紐下_金具上_穴CD, DisUnit, true);
			this.X0Y1_ブ\u30FCツ1_紐_紐2_紐下_紐CP = new ColorP(this.X0Y1_ブ\u30FCツ1_紐_紐2_紐下_紐, this.ブ\u30FCツ1_紐_紐2_紐下_紐CD, DisUnit, true);
			this.X0Y1_ブ\u30FCツ1_紐_紐2_紐上_金具上_金具CP = new ColorP(this.X0Y1_ブ\u30FCツ1_紐_紐2_紐上_金具上_金具, this.ブ\u30FCツ1_紐_紐2_紐上_金具上_金具CD, DisUnit, true);
			this.X0Y1_ブ\u30FCツ1_紐_紐2_紐上_金具上_穴CP = new ColorP(this.X0Y1_ブ\u30FCツ1_紐_紐2_紐上_金具上_穴, this.ブ\u30FCツ1_紐_紐2_紐上_金具上_穴CD, DisUnit, true);
			this.X0Y1_ブ\u30FCツ1_紐_紐2_紐上_紐CP = new ColorP(this.X0Y1_ブ\u30FCツ1_紐_紐2_紐上_紐, this.ブ\u30FCツ1_紐_紐2_紐上_紐CD, DisUnit, true);
			this.X0Y1_ブ\u30FCツ1_紐_紐3_紐下_金具上_金具CP = new ColorP(this.X0Y1_ブ\u30FCツ1_紐_紐3_紐下_金具上_金具, this.ブ\u30FCツ1_紐_紐3_紐下_金具上_金具CD, DisUnit, true);
			this.X0Y1_ブ\u30FCツ1_紐_紐3_紐下_金具上_穴CP = new ColorP(this.X0Y1_ブ\u30FCツ1_紐_紐3_紐下_金具上_穴, this.ブ\u30FCツ1_紐_紐3_紐下_金具上_穴CD, DisUnit, true);
			this.X0Y1_ブ\u30FCツ1_紐_紐3_紐下_紐CP = new ColorP(this.X0Y1_ブ\u30FCツ1_紐_紐3_紐下_紐, this.ブ\u30FCツ1_紐_紐3_紐下_紐CD, DisUnit, true);
			this.X0Y1_ブ\u30FCツ1_紐_紐3_紐上_金具上_金具CP = new ColorP(this.X0Y1_ブ\u30FCツ1_紐_紐3_紐上_金具上_金具, this.ブ\u30FCツ1_紐_紐3_紐上_金具上_金具CD, DisUnit, true);
			this.X0Y1_ブ\u30FCツ1_紐_紐3_紐上_金具上_穴CP = new ColorP(this.X0Y1_ブ\u30FCツ1_紐_紐3_紐上_金具上_穴, this.ブ\u30FCツ1_紐_紐3_紐上_金具上_穴CD, DisUnit, true);
			this.X0Y1_ブ\u30FCツ1_紐_紐3_紐上_紐CP = new ColorP(this.X0Y1_ブ\u30FCツ1_紐_紐3_紐上_紐, this.ブ\u30FCツ1_紐_紐3_紐上_紐CD, DisUnit, true);
			this.X0Y1_ブ\u30FCツ1_紐_紐4_紐下_金具上_金具CP = new ColorP(this.X0Y1_ブ\u30FCツ1_紐_紐4_紐下_金具上_金具, this.ブ\u30FCツ1_紐_紐4_紐下_金具上_金具CD, DisUnit, true);
			this.X0Y1_ブ\u30FCツ1_紐_紐4_紐下_金具上_穴CP = new ColorP(this.X0Y1_ブ\u30FCツ1_紐_紐4_紐下_金具上_穴, this.ブ\u30FCツ1_紐_紐4_紐下_金具上_穴CD, DisUnit, true);
			this.X0Y1_ブ\u30FCツ1_紐_紐4_紐下_紐CP = new ColorP(this.X0Y1_ブ\u30FCツ1_紐_紐4_紐下_紐, this.ブ\u30FCツ1_紐_紐4_紐下_紐CD, DisUnit, true);
			this.X0Y1_ブ\u30FCツ1_紐_紐4_紐上_金具上_金具CP = new ColorP(this.X0Y1_ブ\u30FCツ1_紐_紐4_紐上_金具上_金具, this.ブ\u30FCツ1_紐_紐4_紐上_金具上_金具CD, DisUnit, true);
			this.X0Y1_ブ\u30FCツ1_紐_紐4_紐上_金具上_穴CP = new ColorP(this.X0Y1_ブ\u30FCツ1_紐_紐4_紐上_金具上_穴, this.ブ\u30FCツ1_紐_紐4_紐上_金具上_穴CD, DisUnit, true);
			this.X0Y1_ブ\u30FCツ1_紐_紐4_紐上_紐CP = new ColorP(this.X0Y1_ブ\u30FCツ1_紐_紐4_紐上_紐, this.ブ\u30FCツ1_紐_紐4_紐上_紐CD, DisUnit, true);
			this.X0Y1_ブ\u30FCツ1_紐_紐5_金具1_金具CP = new ColorP(this.X0Y1_ブ\u30FCツ1_紐_紐5_金具1_金具, this.ブ\u30FCツ1_紐_紐5_金具1_金具CD, DisUnit, true);
			this.X0Y1_ブ\u30FCツ1_紐_紐5_金具1_穴CP = new ColorP(this.X0Y1_ブ\u30FCツ1_紐_紐5_金具1_穴, this.ブ\u30FCツ1_紐_紐5_金具1_穴CD, DisUnit, true);
			this.X0Y1_ブ\u30FCツ1_紐_紐5_金具2_金具CP = new ColorP(this.X0Y1_ブ\u30FCツ1_紐_紐5_金具2_金具, this.ブ\u30FCツ1_紐_紐5_金具2_金具CD, DisUnit, true);
			this.X0Y1_ブ\u30FCツ1_紐_紐5_金具2_穴CP = new ColorP(this.X0Y1_ブ\u30FCツ1_紐_紐5_金具2_穴, this.ブ\u30FCツ1_紐_紐5_金具2_穴CD, DisUnit, true);
			this.X0Y1_ブ\u30FCツ1_紐_紐5_紐CP = new ColorP(this.X0Y1_ブ\u30FCツ1_紐_紐5_紐, this.ブ\u30FCツ1_紐_紐5_紐CD, DisUnit, true);
			this.X0Y1_ア\u30FCマ1_鉄靴1CP = new ColorP(this.X0Y1_ア\u30FCマ1_鉄靴1, this.ア\u30FCマ1_鉄靴1CD, DisUnit, true);
			this.X0Y1_ア\u30FCマ1_鉄靴2CP = new ColorP(this.X0Y1_ア\u30FCマ1_鉄靴2, this.ア\u30FCマ1_鉄靴2CD, DisUnit, true);
			this.X0Y1_ア\u30FCマ1_鉄靴3CP = new ColorP(this.X0Y1_ア\u30FCマ1_鉄靴3, this.ア\u30FCマ1_鉄靴3CD, DisUnit, true);
			this.濃度 = e.濃度;
		}

		public override bool 欠損
		{
			get
			{
				return this.欠損_;
			}
			set
			{
				this.欠損_ = value;
			}
		}

		public override bool 筋肉
		{
			get
			{
				return this.筋肉_;
			}
			set
			{
				this.筋肉_ = value;
			}
		}

		public override bool 拘束
		{
			get
			{
				return this.拘束_;
			}
			set
			{
				this.拘束_ = value;
			}
		}

		public bool ヒ\u30FCル0_靴底_表示
		{
			get
			{
				return this.X0Y0_ヒ\u30FCル0_靴底.Dra;
			}
			set
			{
				this.X0Y0_ヒ\u30FCル0_靴底.Dra = value;
				this.X0Y1_ヒ\u30FCル0_靴底.Dra = value;
				this.X0Y0_ヒ\u30FCル0_靴底.Hit = value;
				this.X0Y1_ヒ\u30FCル0_靴底.Hit = value;
			}
		}

		public bool ヒ\u30FCル0_ヒ\u30FCル_表示
		{
			get
			{
				return this.X0Y1_ヒ\u30FCル0_ヒ\u30FCル.Dra;
			}
			set
			{
				this.X0Y1_ヒ\u30FCル0_ヒ\u30FCル.Dra = value;
				this.X0Y1_ヒ\u30FCル0_ヒ\u30FCル.Hit = value;
			}
		}

		public bool サンダル0_靴底_表示
		{
			get
			{
				return this.X0Y0_サンダル0_靴底.Dra;
			}
			set
			{
				this.X0Y0_サンダル0_靴底.Dra = value;
				this.X0Y1_サンダル0_靴底.Dra = value;
				this.X0Y0_サンダル0_靴底.Hit = value;
				this.X0Y1_サンダル0_靴底.Hit = value;
			}
		}

		public bool サンダル0_踵_表示
		{
			get
			{
				return this.X0Y1_サンダル0_踵.Dra;
			}
			set
			{
				this.X0Y1_サンダル0_踵.Dra = value;
				this.X0Y1_サンダル0_踵.Hit = value;
			}
		}

		public bool ナ\u30FCス0_靴底_表示
		{
			get
			{
				return this.X0Y0_ナ\u30FCス0_靴底.Dra;
			}
			set
			{
				this.X0Y0_ナ\u30FCス0_靴底.Dra = value;
				this.X0Y1_ナ\u30FCス0_靴底.Dra = value;
				this.X0Y0_ナ\u30FCス0_靴底.Hit = value;
				this.X0Y1_ナ\u30FCス0_靴底.Hit = value;
			}
		}

		public bool ナ\u30FCス0_踵_表示
		{
			get
			{
				return this.X0Y1_ナ\u30FCス0_踵.Dra;
			}
			set
			{
				this.X0Y1_ナ\u30FCス0_踵.Dra = value;
				this.X0Y1_ナ\u30FCス0_踵.Hit = value;
			}
		}

		public bool ブ\u30FCツ0_靴底_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ0_靴底.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ0_靴底.Dra = value;
				this.X0Y1_ブ\u30FCツ0_靴底.Dra = value;
				this.X0Y0_ブ\u30FCツ0_靴底.Hit = value;
				this.X0Y1_ブ\u30FCツ0_靴底.Hit = value;
			}
		}

		public bool ブ\u30FCツ0_ヒ\u30FCル_表示
		{
			get
			{
				return this.X0Y1_ブ\u30FCツ0_ヒ\u30FCル.Dra;
			}
			set
			{
				this.X0Y1_ブ\u30FCツ0_ヒ\u30FCル.Dra = value;
				this.X0Y1_ブ\u30FCツ0_ヒ\u30FCル.Hit = value;
			}
		}

		public bool ア\u30FCマ0_靴底_表示
		{
			get
			{
				return this.X0Y0_ア\u30FCマ0_靴底.Dra;
			}
			set
			{
				this.X0Y0_ア\u30FCマ0_靴底.Dra = value;
				this.X0Y1_ア\u30FCマ0_靴底.Dra = value;
				this.X0Y0_ア\u30FCマ0_靴底.Hit = value;
				this.X0Y1_ア\u30FCマ0_靴底.Hit = value;
			}
		}

		public bool ア\u30FCマ0_踵_表示
		{
			get
			{
				return this.X0Y1_ア\u30FCマ0_踵.Dra;
			}
			set
			{
				this.X0Y1_ア\u30FCマ0_踵.Dra = value;
				this.X0Y1_ア\u30FCマ0_踵.Hit = value;
			}
		}

		public bool 足_表示
		{
			get
			{
				return this.X0Y0_足.Dra;
			}
			set
			{
				this.X0Y0_足.Dra = value;
				this.X0Y1_足.Dra = value;
				this.X0Y0_足.Hit = value;
				this.X0Y1_足.Hit = value;
			}
		}

		public bool 小指_小指1_表示
		{
			get
			{
				return this.X0Y0_小指_小指1.Dra;
			}
			set
			{
				this.X0Y0_小指_小指1.Dra = value;
				this.X0Y1_小指_小指1.Dra = value;
				this.X0Y0_小指_小指1.Hit = value;
				this.X0Y1_小指_小指1.Hit = value;
			}
		}

		public bool 小指_小指2_表示
		{
			get
			{
				return this.X0Y0_小指_小指2.Dra;
			}
			set
			{
				this.X0Y0_小指_小指2.Dra = value;
				this.X0Y1_小指_小指2.Dra = value;
				this.X0Y0_小指_小指2.Hit = value;
				this.X0Y1_小指_小指2.Hit = value;
			}
		}

		public bool 小指_小指3_表示
		{
			get
			{
				return this.X0Y0_小指_小指3.Dra;
			}
			set
			{
				this.X0Y0_小指_小指3.Dra = value;
				this.X0Y1_小指_小指3.Dra = value;
				this.X0Y0_小指_小指3.Hit = value;
				this.X0Y1_小指_小指3.Hit = value;
			}
		}

		public bool 薬指_水掻_表示
		{
			get
			{
				return this.X0Y0_薬指_水掻.Dra;
			}
			set
			{
				this.X0Y0_薬指_水掻.Dra = value;
				this.X0Y1_薬指_水掻.Dra = value;
				this.X0Y0_薬指_水掻.Hit = value;
				this.X0Y1_薬指_水掻.Hit = value;
			}
		}

		public bool 薬指_薬指1_表示
		{
			get
			{
				return this.X0Y0_薬指_薬指1.Dra;
			}
			set
			{
				this.X0Y0_薬指_薬指1.Dra = value;
				this.X0Y1_薬指_薬指1.Dra = value;
				this.X0Y0_薬指_薬指1.Hit = value;
				this.X0Y1_薬指_薬指1.Hit = value;
			}
		}

		public bool 薬指_薬指2_表示
		{
			get
			{
				return this.X0Y0_薬指_薬指2.Dra;
			}
			set
			{
				this.X0Y0_薬指_薬指2.Dra = value;
				this.X0Y1_薬指_薬指2.Dra = value;
				this.X0Y0_薬指_薬指2.Hit = value;
				this.X0Y1_薬指_薬指2.Hit = value;
			}
		}

		public bool 薬指_薬指3_表示
		{
			get
			{
				return this.X0Y0_薬指_薬指3.Dra;
			}
			set
			{
				this.X0Y0_薬指_薬指3.Dra = value;
				this.X0Y1_薬指_薬指3.Dra = value;
				this.X0Y0_薬指_薬指3.Hit = value;
				this.X0Y1_薬指_薬指3.Hit = value;
			}
		}

		public bool 中指_水掻_表示
		{
			get
			{
				return this.X0Y0_中指_水掻.Dra;
			}
			set
			{
				this.X0Y0_中指_水掻.Dra = value;
				this.X0Y1_中指_水掻.Dra = value;
				this.X0Y0_中指_水掻.Hit = value;
				this.X0Y1_中指_水掻.Hit = value;
			}
		}

		public bool 中指_中指1_表示
		{
			get
			{
				return this.X0Y0_中指_中指1.Dra;
			}
			set
			{
				this.X0Y0_中指_中指1.Dra = value;
				this.X0Y1_中指_中指1.Dra = value;
				this.X0Y0_中指_中指1.Hit = value;
				this.X0Y1_中指_中指1.Hit = value;
			}
		}

		public bool 中指_中指2_表示
		{
			get
			{
				return this.X0Y0_中指_中指2.Dra;
			}
			set
			{
				this.X0Y0_中指_中指2.Dra = value;
				this.X0Y1_中指_中指2.Dra = value;
				this.X0Y0_中指_中指2.Hit = value;
				this.X0Y1_中指_中指2.Hit = value;
			}
		}

		public bool 中指_中指3_表示
		{
			get
			{
				return this.X0Y0_中指_中指3.Dra;
			}
			set
			{
				this.X0Y0_中指_中指3.Dra = value;
				this.X0Y1_中指_中指3.Dra = value;
				this.X0Y0_中指_中指3.Hit = value;
				this.X0Y1_中指_中指3.Hit = value;
			}
		}

		public bool 人指_人指1_表示
		{
			get
			{
				return this.X0Y0_人指_人指1.Dra;
			}
			set
			{
				this.X0Y0_人指_人指1.Dra = value;
				this.X0Y1_人指_人指1.Dra = value;
				this.X0Y0_人指_人指1.Hit = value;
				this.X0Y1_人指_人指1.Hit = value;
			}
		}

		public bool 人指_人指2_表示
		{
			get
			{
				return this.X0Y0_人指_人指2.Dra;
			}
			set
			{
				this.X0Y0_人指_人指2.Dra = value;
				this.X0Y1_人指_人指2.Dra = value;
				this.X0Y0_人指_人指2.Hit = value;
				this.X0Y1_人指_人指2.Hit = value;
			}
		}

		public bool 人指_人指3_表示
		{
			get
			{
				return this.X0Y0_人指_人指3.Dra;
			}
			set
			{
				this.X0Y0_人指_人指3.Dra = value;
				this.X0Y1_人指_人指3.Dra = value;
				this.X0Y0_人指_人指3.Hit = value;
				this.X0Y1_人指_人指3.Hit = value;
			}
		}

		public bool 人指_水掻_表示
		{
			get
			{
				return this.X0Y0_人指_水掻.Dra;
			}
			set
			{
				this.X0Y0_人指_水掻.Dra = value;
				this.X0Y1_人指_水掻.Dra = value;
				this.X0Y0_人指_水掻.Hit = value;
				this.X0Y1_人指_水掻.Hit = value;
			}
		}

		public bool 親指_親指2_表示
		{
			get
			{
				return this.X0Y0_親指_親指2.Dra;
			}
			set
			{
				this.X0Y0_親指_親指2.Dra = value;
				this.X0Y1_親指_親指2.Dra = value;
				this.X0Y0_親指_親指2.Hit = value;
				this.X0Y1_親指_親指2.Hit = value;
			}
		}

		public bool 親指_親指3_表示
		{
			get
			{
				return this.X0Y0_親指_親指3.Dra;
			}
			set
			{
				this.X0Y0_親指_親指3.Dra = value;
				this.X0Y1_親指_親指3.Dra = value;
				this.X0Y0_親指_親指3.Hit = value;
				this.X0Y1_親指_親指3.Hit = value;
			}
		}

		public bool 親指_水掻_表示
		{
			get
			{
				return this.X0Y0_親指_水掻.Dra;
			}
			set
			{
				this.X0Y0_親指_水掻.Dra = value;
				this.X0Y1_親指_水掻.Dra = value;
				this.X0Y0_親指_水掻.Hit = value;
				this.X0Y1_親指_水掻.Hit = value;
			}
		}

		public bool 悪タトゥ_五芒星_円1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_五芒星_円1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_五芒星_円1.Dra = value;
				this.X0Y1_悪タトゥ_五芒星_円1.Dra = value;
				this.X0Y0_悪タトゥ_五芒星_円1.Hit = value;
				this.X0Y1_悪タトゥ_五芒星_円1.Hit = value;
			}
		}

		public bool 悪タトゥ_五芒星_円2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_五芒星_円2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_五芒星_円2.Dra = value;
				this.X0Y1_悪タトゥ_五芒星_円2.Dra = value;
				this.X0Y0_悪タトゥ_五芒星_円2.Hit = value;
				this.X0Y1_悪タトゥ_五芒星_円2.Hit = value;
			}
		}

		public bool 悪タトゥ_五芒星_星_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_五芒星_星.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_五芒星_星.Dra = value;
				this.X0Y1_悪タトゥ_五芒星_星.Dra = value;
				this.X0Y0_悪タトゥ_五芒星_星.Hit = value;
				this.X0Y1_悪タトゥ_五芒星_星.Hit = value;
			}
		}

		public bool 悪タトゥ_五芒星_五角形_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_五芒星_五角形.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_五芒星_五角形.Dra = value;
				this.X0Y1_悪タトゥ_五芒星_五角形.Dra = value;
				this.X0Y0_悪タトゥ_五芒星_五角形.Hit = value;
				this.X0Y1_悪タトゥ_五芒星_五角形.Hit = value;
			}
		}

		public bool 竜性_鱗1_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗1.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗1.Dra = value;
				this.X0Y1_竜性_鱗1.Dra = value;
				this.X0Y0_竜性_鱗1.Hit = value;
				this.X0Y1_竜性_鱗1.Hit = value;
			}
		}

		public bool 竜性_鱗2_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗2.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗2.Dra = value;
				this.X0Y1_竜性_鱗2.Dra = value;
				this.X0Y0_竜性_鱗2.Hit = value;
				this.X0Y1_竜性_鱗2.Hit = value;
			}
		}

		public bool 竜性_鱗3_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗3.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗3.Dra = value;
				this.X0Y1_竜性_鱗3.Dra = value;
				this.X0Y0_竜性_鱗3.Hit = value;
				this.X0Y1_竜性_鱗3.Hit = value;
			}
		}

		public bool 竜性_鱗4_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗4.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗4.Dra = value;
				this.X0Y1_竜性_鱗4.Dra = value;
				this.X0Y0_竜性_鱗4.Hit = value;
				this.X0Y1_竜性_鱗4.Hit = value;
			}
		}

		public bool 竜性_鱗5_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗5.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗5.Dra = value;
				this.X0Y1_竜性_鱗5.Dra = value;
				this.X0Y0_竜性_鱗5.Hit = value;
				this.X0Y1_竜性_鱗5.Hit = value;
			}
		}

		public bool パンスト_パンスト1_表示
		{
			get
			{
				return this.X0Y0_パンスト_パンスト1.Dra;
			}
			set
			{
				this.X0Y0_パンスト_パンスト1.Dra = value;
				this.X0Y1_パンスト_パンスト1.Dra = value;
				this.X0Y0_パンスト_パンスト1.Hit = value;
				this.X0Y1_パンスト_パンスト1.Hit = value;
			}
		}

		public bool パンスト_パンスト2_表示
		{
			get
			{
				return this.X0Y0_パンスト_パンスト2.Dra;
			}
			set
			{
				this.X0Y0_パンスト_パンスト2.Dra = value;
				this.X0Y1_パンスト_パンスト2.Dra = value;
				this.X0Y0_パンスト_パンスト2.Hit = value;
				this.X0Y1_パンスト_パンスト2.Hit = value;
			}
		}

		public bool ソックス_ソックス1_表示
		{
			get
			{
				return this.X0Y0_ソックス_ソックス1.Dra;
			}
			set
			{
				this.X0Y0_ソックス_ソックス1.Dra = value;
				this.X0Y1_ソックス_ソックス1.Dra = value;
				this.X0Y0_ソックス_ソックス1.Hit = value;
				this.X0Y1_ソックス_ソックス1.Hit = value;
			}
		}

		public bool ソックス_ソックス2_表示
		{
			get
			{
				return this.X0Y0_ソックス_ソックス2.Dra;
			}
			set
			{
				this.X0Y0_ソックス_ソックス2.Dra = value;
				this.X0Y1_ソックス_ソックス2.Dra = value;
				this.X0Y0_ソックス_ソックス2.Hit = value;
				this.X0Y1_ソックス_ソックス2.Hit = value;
			}
		}

		public bool ヒ\u30FCル1_バンプ_表示
		{
			get
			{
				return this.X0Y0_ヒ\u30FCル1_バンプ.Dra;
			}
			set
			{
				this.X0Y0_ヒ\u30FCル1_バンプ.Dra = value;
				this.X0Y1_ヒ\u30FCル1_バンプ.Dra = value;
				this.X0Y0_ヒ\u30FCル1_バンプ.Hit = value;
				this.X0Y1_ヒ\u30FCル1_バンプ.Hit = value;
			}
		}

		public bool ヒ\u30FCル1_ストラップ_ストラップ_表示
		{
			get
			{
				return this.X0Y0_ヒ\u30FCル1_ストラップ_ストラップ.Dra;
			}
			set
			{
				this.X0Y0_ヒ\u30FCル1_ストラップ_ストラップ.Dra = value;
				this.X0Y1_ヒ\u30FCル1_ストラップ_ストラップ.Dra = value;
				this.X0Y0_ヒ\u30FCル1_ストラップ_ストラップ.Hit = value;
				this.X0Y1_ヒ\u30FCル1_ストラップ_ストラップ.Hit = value;
			}
		}

		public bool ヒ\u30FCル1_ストラップ_金具1_金具1_表示
		{
			get
			{
				return this.X0Y0_ヒ\u30FCル1_ストラップ_金具1_金具1.Dra;
			}
			set
			{
				this.X0Y0_ヒ\u30FCル1_ストラップ_金具1_金具1.Dra = value;
				this.X0Y1_ヒ\u30FCル1_ストラップ_金具1_金具1.Dra = value;
				this.X0Y0_ヒ\u30FCル1_ストラップ_金具1_金具1.Hit = value;
				this.X0Y1_ヒ\u30FCル1_ストラップ_金具1_金具1.Hit = value;
			}
		}

		public bool ヒ\u30FCル1_ストラップ_金具1_金具2_表示
		{
			get
			{
				return this.X0Y0_ヒ\u30FCル1_ストラップ_金具1_金具2.Dra;
			}
			set
			{
				this.X0Y0_ヒ\u30FCル1_ストラップ_金具1_金具2.Dra = value;
				this.X0Y1_ヒ\u30FCル1_ストラップ_金具1_金具2.Dra = value;
				this.X0Y0_ヒ\u30FCル1_ストラップ_金具1_金具2.Hit = value;
				this.X0Y1_ヒ\u30FCル1_ストラップ_金具1_金具2.Hit = value;
			}
		}

		public bool ヒ\u30FCル1_ストラップ_金具1_金具3_表示
		{
			get
			{
				return this.X0Y0_ヒ\u30FCル1_ストラップ_金具1_金具3.Dra;
			}
			set
			{
				this.X0Y0_ヒ\u30FCル1_ストラップ_金具1_金具3.Dra = value;
				this.X0Y1_ヒ\u30FCル1_ストラップ_金具1_金具3.Dra = value;
				this.X0Y0_ヒ\u30FCル1_ストラップ_金具1_金具3.Hit = value;
				this.X0Y1_ヒ\u30FCル1_ストラップ_金具1_金具3.Hit = value;
			}
		}

		public bool ヒ\u30FCル1_ストラップ_金具1_金具4_表示
		{
			get
			{
				return this.X0Y0_ヒ\u30FCル1_ストラップ_金具1_金具4.Dra;
			}
			set
			{
				this.X0Y0_ヒ\u30FCル1_ストラップ_金具1_金具4.Dra = value;
				this.X0Y1_ヒ\u30FCル1_ストラップ_金具1_金具4.Dra = value;
				this.X0Y0_ヒ\u30FCル1_ストラップ_金具1_金具4.Hit = value;
				this.X0Y1_ヒ\u30FCル1_ストラップ_金具1_金具4.Hit = value;
			}
		}

		public bool ヒ\u30FCル1_ストラップ_金具2_金具1_表示
		{
			get
			{
				return this.X0Y0_ヒ\u30FCル1_ストラップ_金具2_金具1.Dra;
			}
			set
			{
				this.X0Y0_ヒ\u30FCル1_ストラップ_金具2_金具1.Dra = value;
				this.X0Y1_ヒ\u30FCル1_ストラップ_金具2_金具1.Dra = value;
				this.X0Y0_ヒ\u30FCル1_ストラップ_金具2_金具1.Hit = value;
				this.X0Y1_ヒ\u30FCル1_ストラップ_金具2_金具1.Hit = value;
			}
		}

		public bool ヒ\u30FCル1_ストラップ_金具2_金具2_表示
		{
			get
			{
				return this.X0Y0_ヒ\u30FCル1_ストラップ_金具2_金具2.Dra;
			}
			set
			{
				this.X0Y0_ヒ\u30FCル1_ストラップ_金具2_金具2.Dra = value;
				this.X0Y1_ヒ\u30FCル1_ストラップ_金具2_金具2.Dra = value;
				this.X0Y0_ヒ\u30FCル1_ストラップ_金具2_金具2.Hit = value;
				this.X0Y1_ヒ\u30FCル1_ストラップ_金具2_金具2.Hit = value;
			}
		}

		public bool ヒ\u30FCル1_ストラップ_金具2_金具3_表示
		{
			get
			{
				return this.X0Y0_ヒ\u30FCル1_ストラップ_金具2_金具3.Dra;
			}
			set
			{
				this.X0Y0_ヒ\u30FCル1_ストラップ_金具2_金具3.Dra = value;
				this.X0Y1_ヒ\u30FCル1_ストラップ_金具2_金具3.Dra = value;
				this.X0Y0_ヒ\u30FCル1_ストラップ_金具2_金具3.Hit = value;
				this.X0Y1_ヒ\u30FCル1_ストラップ_金具2_金具3.Hit = value;
			}
		}

		public bool ヒ\u30FCル1_ストラップ_金具2_金具4_表示
		{
			get
			{
				return this.X0Y0_ヒ\u30FCル1_ストラップ_金具2_金具4.Dra;
			}
			set
			{
				this.X0Y0_ヒ\u30FCル1_ストラップ_金具2_金具4.Dra = value;
				this.X0Y1_ヒ\u30FCル1_ストラップ_金具2_金具4.Dra = value;
				this.X0Y0_ヒ\u30FCル1_ストラップ_金具2_金具4.Hit = value;
				this.X0Y1_ヒ\u30FCル1_ストラップ_金具2_金具4.Hit = value;
			}
		}

		public bool ヒ\u30FCル1_ハイライト_表示
		{
			get
			{
				return this.X0Y0_ヒ\u30FCル1_ハイライト.Dra;
			}
			set
			{
				this.X0Y0_ヒ\u30FCル1_ハイライト.Dra = value;
				this.X0Y1_ヒ\u30FCル1_ハイライト.Dra = value;
				this.X0Y0_ヒ\u30FCル1_ハイライト.Hit = value;
				this.X0Y1_ヒ\u30FCル1_ハイライト.Hit = value;
			}
		}

		public bool サンダル1_ストラップ3_表示
		{
			get
			{
				return this.X0Y0_サンダル1_ストラップ3.Dra;
			}
			set
			{
				this.X0Y0_サンダル1_ストラップ3.Dra = value;
				this.X0Y1_サンダル1_ストラップ3.Dra = value;
				this.X0Y0_サンダル1_ストラップ3.Hit = value;
				this.X0Y1_サンダル1_ストラップ3.Hit = value;
			}
		}

		public bool サンダル1_ストラップ2_表示
		{
			get
			{
				return this.X0Y0_サンダル1_ストラップ2.Dra;
			}
			set
			{
				this.X0Y0_サンダル1_ストラップ2.Dra = value;
				this.X0Y1_サンダル1_ストラップ2.Dra = value;
				this.X0Y0_サンダル1_ストラップ2.Hit = value;
				this.X0Y1_サンダル1_ストラップ2.Hit = value;
			}
		}

		public bool サンダル1_ストラップ4_表示
		{
			get
			{
				return this.X0Y0_サンダル1_ストラップ4.Dra;
			}
			set
			{
				this.X0Y0_サンダル1_ストラップ4.Dra = value;
				this.X0Y1_サンダル1_ストラップ4.Dra = value;
				this.X0Y0_サンダル1_ストラップ4.Hit = value;
				this.X0Y1_サンダル1_ストラップ4.Hit = value;
			}
		}

		public bool サンダル1_ストラップ1_表示
		{
			get
			{
				return this.X0Y0_サンダル1_ストラップ1.Dra;
			}
			set
			{
				this.X0Y0_サンダル1_ストラップ1.Dra = value;
				this.X0Y1_サンダル1_ストラップ1.Dra = value;
				this.X0Y0_サンダル1_ストラップ1.Hit = value;
				this.X0Y1_サンダル1_ストラップ1.Hit = value;
			}
		}

		public bool ナ\u30FCス1_ストラップ3_ストラップ_表示
		{
			get
			{
				return this.X0Y0_ナ\u30FCス1_ストラップ3_ストラップ.Dra;
			}
			set
			{
				this.X0Y0_ナ\u30FCス1_ストラップ3_ストラップ.Dra = value;
				this.X0Y1_ナ\u30FCス1_ストラップ3_ストラップ.Dra = value;
				this.X0Y0_ナ\u30FCス1_ストラップ3_ストラップ.Hit = value;
				this.X0Y1_ナ\u30FCス1_ストラップ3_ストラップ.Hit = value;
			}
		}

		public bool ナ\u30FCス1_ストラップ3_縁1_表示
		{
			get
			{
				return this.X0Y0_ナ\u30FCス1_ストラップ3_縁1.Dra;
			}
			set
			{
				this.X0Y0_ナ\u30FCス1_ストラップ3_縁1.Dra = value;
				this.X0Y1_ナ\u30FCス1_ストラップ3_縁1.Dra = value;
				this.X0Y0_ナ\u30FCス1_ストラップ3_縁1.Hit = value;
				this.X0Y1_ナ\u30FCス1_ストラップ3_縁1.Hit = value;
			}
		}

		public bool ナ\u30FCス1_ストラップ3_縁2_表示
		{
			get
			{
				return this.X0Y0_ナ\u30FCス1_ストラップ3_縁2.Dra;
			}
			set
			{
				this.X0Y0_ナ\u30FCス1_ストラップ3_縁2.Dra = value;
				this.X0Y1_ナ\u30FCス1_ストラップ3_縁2.Dra = value;
				this.X0Y0_ナ\u30FCス1_ストラップ3_縁2.Hit = value;
				this.X0Y1_ナ\u30FCス1_ストラップ3_縁2.Hit = value;
			}
		}

		public bool ナ\u30FCス1_ストラップ2_ストラップ_表示
		{
			get
			{
				return this.X0Y0_ナ\u30FCス1_ストラップ2_ストラップ.Dra;
			}
			set
			{
				this.X0Y0_ナ\u30FCス1_ストラップ2_ストラップ.Dra = value;
				this.X0Y1_ナ\u30FCス1_ストラップ2_ストラップ.Dra = value;
				this.X0Y0_ナ\u30FCス1_ストラップ2_ストラップ.Hit = value;
				this.X0Y1_ナ\u30FCス1_ストラップ2_ストラップ.Hit = value;
			}
		}

		public bool ナ\u30FCス1_ストラップ2_縁1_表示
		{
			get
			{
				return this.X0Y0_ナ\u30FCス1_ストラップ2_縁1.Dra;
			}
			set
			{
				this.X0Y0_ナ\u30FCス1_ストラップ2_縁1.Dra = value;
				this.X0Y1_ナ\u30FCス1_ストラップ2_縁1.Dra = value;
				this.X0Y0_ナ\u30FCス1_ストラップ2_縁1.Hit = value;
				this.X0Y1_ナ\u30FCス1_ストラップ2_縁1.Hit = value;
			}
		}

		public bool ナ\u30FCス1_ストラップ2_縁2_表示
		{
			get
			{
				return this.X0Y0_ナ\u30FCス1_ストラップ2_縁2.Dra;
			}
			set
			{
				this.X0Y0_ナ\u30FCス1_ストラップ2_縁2.Dra = value;
				this.X0Y1_ナ\u30FCス1_ストラップ2_縁2.Dra = value;
				this.X0Y0_ナ\u30FCス1_ストラップ2_縁2.Hit = value;
				this.X0Y1_ナ\u30FCス1_ストラップ2_縁2.Hit = value;
			}
		}

		public bool ナ\u30FCス1_ストラップ1_ストラップ_表示
		{
			get
			{
				return this.X0Y0_ナ\u30FCス1_ストラップ1_ストラップ.Dra;
			}
			set
			{
				this.X0Y0_ナ\u30FCス1_ストラップ1_ストラップ.Dra = value;
				this.X0Y1_ナ\u30FCス1_ストラップ1_ストラップ.Dra = value;
				this.X0Y0_ナ\u30FCス1_ストラップ1_ストラップ.Hit = value;
				this.X0Y1_ナ\u30FCス1_ストラップ1_ストラップ.Hit = value;
			}
		}

		public bool ナ\u30FCス1_ストラップ1_縁1_表示
		{
			get
			{
				return this.X0Y0_ナ\u30FCス1_ストラップ1_縁1.Dra;
			}
			set
			{
				this.X0Y0_ナ\u30FCス1_ストラップ1_縁1.Dra = value;
				this.X0Y1_ナ\u30FCス1_ストラップ1_縁1.Dra = value;
				this.X0Y0_ナ\u30FCス1_ストラップ1_縁1.Hit = value;
				this.X0Y1_ナ\u30FCス1_ストラップ1_縁1.Hit = value;
			}
		}

		public bool ナ\u30FCス1_ストラップ1_縁2_表示
		{
			get
			{
				return this.X0Y0_ナ\u30FCス1_ストラップ1_縁2.Dra;
			}
			set
			{
				this.X0Y0_ナ\u30FCス1_ストラップ1_縁2.Dra = value;
				this.X0Y1_ナ\u30FCス1_ストラップ1_縁2.Dra = value;
				this.X0Y0_ナ\u30FCス1_ストラップ1_縁2.Hit = value;
				this.X0Y1_ナ\u30FCス1_ストラップ1_縁2.Hit = value;
			}
		}

		public bool ブ\u30FCツ1_タン_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ1_タン.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ1_タン.Dra = value;
				this.X0Y1_ブ\u30FCツ1_タン.Dra = value;
				this.X0Y0_ブ\u30FCツ1_タン.Hit = value;
				this.X0Y1_ブ\u30FCツ1_タン.Hit = value;
			}
		}

		public bool ブ\u30FCツ1_バンプ_バンプ_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ1_バンプ_バンプ.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ1_バンプ_バンプ.Dra = value;
				this.X0Y1_ブ\u30FCツ1_バンプ_バンプ.Dra = value;
				this.X0Y0_ブ\u30FCツ1_バンプ_バンプ.Hit = value;
				this.X0Y1_ブ\u30FCツ1_バンプ_バンプ.Hit = value;
			}
		}

		public bool ブ\u30FCツ1_バンプ_縁_縁1_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ1_バンプ_縁_縁1.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ1_バンプ_縁_縁1.Dra = value;
				this.X0Y1_ブ\u30FCツ1_バンプ_縁_縁1.Dra = value;
				this.X0Y0_ブ\u30FCツ1_バンプ_縁_縁1.Hit = value;
				this.X0Y1_ブ\u30FCツ1_バンプ_縁_縁1.Hit = value;
			}
		}

		public bool ブ\u30FCツ1_バンプ_縁_縁2_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ1_バンプ_縁_縁2.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ1_バンプ_縁_縁2.Dra = value;
				this.X0Y1_ブ\u30FCツ1_バンプ_縁_縁2.Dra = value;
				this.X0Y0_ブ\u30FCツ1_バンプ_縁_縁2.Hit = value;
				this.X0Y1_ブ\u30FCツ1_バンプ_縁_縁2.Hit = value;
			}
		}

		public bool ブ\u30FCツ1_バンプ_縁_縁3_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ1_バンプ_縁_縁3.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ1_バンプ_縁_縁3.Dra = value;
				this.X0Y1_ブ\u30FCツ1_バンプ_縁_縁3.Dra = value;
				this.X0Y0_ブ\u30FCツ1_バンプ_縁_縁3.Hit = value;
				this.X0Y1_ブ\u30FCツ1_バンプ_縁_縁3.Hit = value;
			}
		}

		public bool ブ\u30FCツ1_バンプ_縁_縁4_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ1_バンプ_縁_縁4.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ1_バンプ_縁_縁4.Dra = value;
				this.X0Y1_ブ\u30FCツ1_バンプ_縁_縁4.Dra = value;
				this.X0Y0_ブ\u30FCツ1_バンプ_縁_縁4.Hit = value;
				this.X0Y1_ブ\u30FCツ1_バンプ_縁_縁4.Hit = value;
			}
		}

		public bool ブ\u30FCツ1_ハイライト_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ1_ハイライト.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ1_ハイライト.Dra = value;
				this.X0Y1_ブ\u30FCツ1_ハイライト.Dra = value;
				this.X0Y0_ブ\u30FCツ1_ハイライト.Hit = value;
				this.X0Y1_ブ\u30FCツ1_ハイライト.Hit = value;
			}
		}

		public bool ブ\u30FCツ1_柄_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ1_柄.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ1_柄.Dra = value;
				this.X0Y1_ブ\u30FCツ1_柄.Dra = value;
				this.X0Y0_ブ\u30FCツ1_柄.Hit = value;
				this.X0Y1_ブ\u30FCツ1_柄.Hit = value;
			}
		}

		public bool ブ\u30FCツ1_紐_紐1_紐下_金具上_金具_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ1_紐_紐1_紐下_金具上_金具.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ1_紐_紐1_紐下_金具上_金具.Dra = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐1_紐下_金具上_金具.Dra = value;
				this.X0Y0_ブ\u30FCツ1_紐_紐1_紐下_金具上_金具.Hit = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐1_紐下_金具上_金具.Hit = value;
			}
		}

		public bool ブ\u30FCツ1_紐_紐1_紐下_金具上_穴_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ1_紐_紐1_紐下_金具上_穴.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ1_紐_紐1_紐下_金具上_穴.Dra = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐1_紐下_金具上_穴.Dra = value;
				this.X0Y0_ブ\u30FCツ1_紐_紐1_紐下_金具上_穴.Hit = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐1_紐下_金具上_穴.Hit = value;
			}
		}

		public bool ブ\u30FCツ1_紐_紐1_紐下_紐_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ1_紐_紐1_紐下_紐.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ1_紐_紐1_紐下_紐.Dra = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐1_紐下_紐.Dra = value;
				this.X0Y0_ブ\u30FCツ1_紐_紐1_紐下_紐.Hit = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐1_紐下_紐.Hit = value;
			}
		}

		public bool ブ\u30FCツ1_紐_紐1_紐上_金具上_金具_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ1_紐_紐1_紐上_金具上_金具.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ1_紐_紐1_紐上_金具上_金具.Dra = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐1_紐上_金具上_金具.Dra = value;
				this.X0Y0_ブ\u30FCツ1_紐_紐1_紐上_金具上_金具.Hit = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐1_紐上_金具上_金具.Hit = value;
			}
		}

		public bool ブ\u30FCツ1_紐_紐1_紐上_金具上_穴_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ1_紐_紐1_紐上_金具上_穴.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ1_紐_紐1_紐上_金具上_穴.Dra = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐1_紐上_金具上_穴.Dra = value;
				this.X0Y0_ブ\u30FCツ1_紐_紐1_紐上_金具上_穴.Hit = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐1_紐上_金具上_穴.Hit = value;
			}
		}

		public bool ブ\u30FCツ1_紐_紐1_紐上_紐_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ1_紐_紐1_紐上_紐.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ1_紐_紐1_紐上_紐.Dra = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐1_紐上_紐.Dra = value;
				this.X0Y0_ブ\u30FCツ1_紐_紐1_紐上_紐.Hit = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐1_紐上_紐.Hit = value;
			}
		}

		public bool ブ\u30FCツ1_紐_紐2_紐下_金具上_金具_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ1_紐_紐2_紐下_金具上_金具.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ1_紐_紐2_紐下_金具上_金具.Dra = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐2_紐下_金具上_金具.Dra = value;
				this.X0Y0_ブ\u30FCツ1_紐_紐2_紐下_金具上_金具.Hit = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐2_紐下_金具上_金具.Hit = value;
			}
		}

		public bool ブ\u30FCツ1_紐_紐2_紐下_金具上_穴_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ1_紐_紐2_紐下_金具上_穴.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ1_紐_紐2_紐下_金具上_穴.Dra = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐2_紐下_金具上_穴.Dra = value;
				this.X0Y0_ブ\u30FCツ1_紐_紐2_紐下_金具上_穴.Hit = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐2_紐下_金具上_穴.Hit = value;
			}
		}

		public bool ブ\u30FCツ1_紐_紐2_紐下_紐_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ1_紐_紐2_紐下_紐.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ1_紐_紐2_紐下_紐.Dra = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐2_紐下_紐.Dra = value;
				this.X0Y0_ブ\u30FCツ1_紐_紐2_紐下_紐.Hit = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐2_紐下_紐.Hit = value;
			}
		}

		public bool ブ\u30FCツ1_紐_紐2_紐上_金具上_金具_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ1_紐_紐2_紐上_金具上_金具.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ1_紐_紐2_紐上_金具上_金具.Dra = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐2_紐上_金具上_金具.Dra = value;
				this.X0Y0_ブ\u30FCツ1_紐_紐2_紐上_金具上_金具.Hit = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐2_紐上_金具上_金具.Hit = value;
			}
		}

		public bool ブ\u30FCツ1_紐_紐2_紐上_金具上_穴_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ1_紐_紐2_紐上_金具上_穴.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ1_紐_紐2_紐上_金具上_穴.Dra = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐2_紐上_金具上_穴.Dra = value;
				this.X0Y0_ブ\u30FCツ1_紐_紐2_紐上_金具上_穴.Hit = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐2_紐上_金具上_穴.Hit = value;
			}
		}

		public bool ブ\u30FCツ1_紐_紐2_紐上_紐_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ1_紐_紐2_紐上_紐.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ1_紐_紐2_紐上_紐.Dra = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐2_紐上_紐.Dra = value;
				this.X0Y0_ブ\u30FCツ1_紐_紐2_紐上_紐.Hit = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐2_紐上_紐.Hit = value;
			}
		}

		public bool ブ\u30FCツ1_紐_紐3_紐下_金具上_金具_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ1_紐_紐3_紐下_金具上_金具.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ1_紐_紐3_紐下_金具上_金具.Dra = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐3_紐下_金具上_金具.Dra = value;
				this.X0Y0_ブ\u30FCツ1_紐_紐3_紐下_金具上_金具.Hit = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐3_紐下_金具上_金具.Hit = value;
			}
		}

		public bool ブ\u30FCツ1_紐_紐3_紐下_金具上_穴_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ1_紐_紐3_紐下_金具上_穴.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ1_紐_紐3_紐下_金具上_穴.Dra = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐3_紐下_金具上_穴.Dra = value;
				this.X0Y0_ブ\u30FCツ1_紐_紐3_紐下_金具上_穴.Hit = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐3_紐下_金具上_穴.Hit = value;
			}
		}

		public bool ブ\u30FCツ1_紐_紐3_紐下_紐_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ1_紐_紐3_紐下_紐.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ1_紐_紐3_紐下_紐.Dra = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐3_紐下_紐.Dra = value;
				this.X0Y0_ブ\u30FCツ1_紐_紐3_紐下_紐.Hit = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐3_紐下_紐.Hit = value;
			}
		}

		public bool ブ\u30FCツ1_紐_紐3_紐上_金具上_金具_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ1_紐_紐3_紐上_金具上_金具.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ1_紐_紐3_紐上_金具上_金具.Dra = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐3_紐上_金具上_金具.Dra = value;
				this.X0Y0_ブ\u30FCツ1_紐_紐3_紐上_金具上_金具.Hit = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐3_紐上_金具上_金具.Hit = value;
			}
		}

		public bool ブ\u30FCツ1_紐_紐3_紐上_金具上_穴_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ1_紐_紐3_紐上_金具上_穴.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ1_紐_紐3_紐上_金具上_穴.Dra = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐3_紐上_金具上_穴.Dra = value;
				this.X0Y0_ブ\u30FCツ1_紐_紐3_紐上_金具上_穴.Hit = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐3_紐上_金具上_穴.Hit = value;
			}
		}

		public bool ブ\u30FCツ1_紐_紐3_紐上_紐_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ1_紐_紐3_紐上_紐.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ1_紐_紐3_紐上_紐.Dra = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐3_紐上_紐.Dra = value;
				this.X0Y0_ブ\u30FCツ1_紐_紐3_紐上_紐.Hit = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐3_紐上_紐.Hit = value;
			}
		}

		public bool ブ\u30FCツ1_紐_紐4_紐下_金具上_金具_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ1_紐_紐4_紐下_金具上_金具.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ1_紐_紐4_紐下_金具上_金具.Dra = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐4_紐下_金具上_金具.Dra = value;
				this.X0Y0_ブ\u30FCツ1_紐_紐4_紐下_金具上_金具.Hit = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐4_紐下_金具上_金具.Hit = value;
			}
		}

		public bool ブ\u30FCツ1_紐_紐4_紐下_金具上_穴_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ1_紐_紐4_紐下_金具上_穴.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ1_紐_紐4_紐下_金具上_穴.Dra = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐4_紐下_金具上_穴.Dra = value;
				this.X0Y0_ブ\u30FCツ1_紐_紐4_紐下_金具上_穴.Hit = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐4_紐下_金具上_穴.Hit = value;
			}
		}

		public bool ブ\u30FCツ1_紐_紐4_紐下_紐_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ1_紐_紐4_紐下_紐.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ1_紐_紐4_紐下_紐.Dra = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐4_紐下_紐.Dra = value;
				this.X0Y0_ブ\u30FCツ1_紐_紐4_紐下_紐.Hit = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐4_紐下_紐.Hit = value;
			}
		}

		public bool ブ\u30FCツ1_紐_紐4_紐上_金具上_金具_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ1_紐_紐4_紐上_金具上_金具.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ1_紐_紐4_紐上_金具上_金具.Dra = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐4_紐上_金具上_金具.Dra = value;
				this.X0Y0_ブ\u30FCツ1_紐_紐4_紐上_金具上_金具.Hit = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐4_紐上_金具上_金具.Hit = value;
			}
		}

		public bool ブ\u30FCツ1_紐_紐4_紐上_金具上_穴_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ1_紐_紐4_紐上_金具上_穴.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ1_紐_紐4_紐上_金具上_穴.Dra = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐4_紐上_金具上_穴.Dra = value;
				this.X0Y0_ブ\u30FCツ1_紐_紐4_紐上_金具上_穴.Hit = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐4_紐上_金具上_穴.Hit = value;
			}
		}

		public bool ブ\u30FCツ1_紐_紐4_紐上_紐_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ1_紐_紐4_紐上_紐.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ1_紐_紐4_紐上_紐.Dra = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐4_紐上_紐.Dra = value;
				this.X0Y0_ブ\u30FCツ1_紐_紐4_紐上_紐.Hit = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐4_紐上_紐.Hit = value;
			}
		}

		public bool ブ\u30FCツ1_紐_紐5_金具1_金具_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ1_紐_紐5_金具1_金具.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ1_紐_紐5_金具1_金具.Dra = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐5_金具1_金具.Dra = value;
				this.X0Y0_ブ\u30FCツ1_紐_紐5_金具1_金具.Hit = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐5_金具1_金具.Hit = value;
			}
		}

		public bool ブ\u30FCツ1_紐_紐5_金具1_穴_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ1_紐_紐5_金具1_穴.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ1_紐_紐5_金具1_穴.Dra = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐5_金具1_穴.Dra = value;
				this.X0Y0_ブ\u30FCツ1_紐_紐5_金具1_穴.Hit = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐5_金具1_穴.Hit = value;
			}
		}

		public bool ブ\u30FCツ1_紐_紐5_金具2_金具_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ1_紐_紐5_金具2_金具.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ1_紐_紐5_金具2_金具.Dra = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐5_金具2_金具.Dra = value;
				this.X0Y0_ブ\u30FCツ1_紐_紐5_金具2_金具.Hit = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐5_金具2_金具.Hit = value;
			}
		}

		public bool ブ\u30FCツ1_紐_紐5_金具2_穴_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ1_紐_紐5_金具2_穴.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ1_紐_紐5_金具2_穴.Dra = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐5_金具2_穴.Dra = value;
				this.X0Y0_ブ\u30FCツ1_紐_紐5_金具2_穴.Hit = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐5_金具2_穴.Hit = value;
			}
		}

		public bool ブ\u30FCツ1_紐_紐5_紐_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ1_紐_紐5_紐.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ1_紐_紐5_紐.Dra = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐5_紐.Dra = value;
				this.X0Y0_ブ\u30FCツ1_紐_紐5_紐.Hit = value;
				this.X0Y1_ブ\u30FCツ1_紐_紐5_紐.Hit = value;
			}
		}

		public bool ア\u30FCマ1_鉄靴1_表示
		{
			get
			{
				return this.X0Y0_ア\u30FCマ1_鉄靴1.Dra;
			}
			set
			{
				this.X0Y0_ア\u30FCマ1_鉄靴1.Dra = value;
				this.X0Y1_ア\u30FCマ1_鉄靴1.Dra = value;
				this.X0Y0_ア\u30FCマ1_鉄靴1.Hit = value;
				this.X0Y1_ア\u30FCマ1_鉄靴1.Hit = value;
			}
		}

		public bool ア\u30FCマ1_鉄靴2_表示
		{
			get
			{
				return this.X0Y0_ア\u30FCマ1_鉄靴2.Dra;
			}
			set
			{
				this.X0Y0_ア\u30FCマ1_鉄靴2.Dra = value;
				this.X0Y1_ア\u30FCマ1_鉄靴2.Dra = value;
				this.X0Y0_ア\u30FCマ1_鉄靴2.Hit = value;
				this.X0Y1_ア\u30FCマ1_鉄靴2.Hit = value;
			}
		}

		public bool ア\u30FCマ1_鉄靴3_表示
		{
			get
			{
				return this.X0Y0_ア\u30FCマ1_鉄靴3.Dra;
			}
			set
			{
				this.X0Y0_ア\u30FCマ1_鉄靴3.Dra = value;
				this.X0Y1_ア\u30FCマ1_鉄靴3.Dra = value;
				this.X0Y0_ア\u30FCマ1_鉄靴3.Hit = value;
				this.X0Y1_ア\u30FCマ1_鉄靴3.Hit = value;
			}
		}

		public bool ナ\u30FCス1_ストラップ4_ストラップ_表示
		{
			get
			{
				return this.X0Y1_ナ\u30FCス1_ストラップ4_ストラップ.Dra;
			}
			set
			{
				this.X0Y1_ナ\u30FCス1_ストラップ4_ストラップ.Dra = value;
				this.X0Y1_ナ\u30FCス1_ストラップ4_ストラップ.Hit = value;
			}
		}

		public bool ナ\u30FCス1_ストラップ4_縁1_表示
		{
			get
			{
				return this.X0Y1_ナ\u30FCス1_ストラップ4_縁1.Dra;
			}
			set
			{
				this.X0Y1_ナ\u30FCス1_ストラップ4_縁1.Dra = value;
				this.X0Y1_ナ\u30FCス1_ストラップ4_縁1.Hit = value;
			}
		}

		public bool ナ\u30FCス1_ストラップ4_縁2_表示
		{
			get
			{
				return this.X0Y1_ナ\u30FCス1_ストラップ4_縁2.Dra;
			}
			set
			{
				this.X0Y1_ナ\u30FCス1_ストラップ4_縁2.Dra = value;
				this.X0Y1_ナ\u30FCス1_ストラップ4_縁2.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.足_表示;
			}
			set
			{
				this.ヒ\u30FCル0_靴底_表示 = value;
				this.ヒ\u30FCル0_ヒ\u30FCル_表示 = value;
				this.サンダル0_靴底_表示 = value;
				this.サンダル0_踵_表示 = value;
				this.ナ\u30FCス0_靴底_表示 = value;
				this.ナ\u30FCス0_踵_表示 = value;
				this.ブ\u30FCツ0_靴底_表示 = value;
				this.ブ\u30FCツ0_ヒ\u30FCル_表示 = value;
				this.ア\u30FCマ0_靴底_表示 = value;
				this.ア\u30FCマ0_踵_表示 = value;
				this.足_表示 = value;
				this.小指_小指1_表示 = value;
				this.小指_小指2_表示 = value;
				this.小指_小指3_表示 = value;
				this.薬指_水掻_表示 = value;
				this.薬指_薬指1_表示 = value;
				this.薬指_薬指2_表示 = value;
				this.薬指_薬指3_表示 = value;
				this.中指_水掻_表示 = value;
				this.中指_中指1_表示 = value;
				this.中指_中指2_表示 = value;
				this.中指_中指3_表示 = value;
				this.人指_人指1_表示 = value;
				this.人指_人指2_表示 = value;
				this.人指_人指3_表示 = value;
				this.人指_水掻_表示 = value;
				this.親指_親指2_表示 = value;
				this.親指_親指3_表示 = value;
				this.親指_水掻_表示 = value;
				this.悪タトゥ_五芒星_円1_表示 = value;
				this.悪タトゥ_五芒星_円2_表示 = value;
				this.悪タトゥ_五芒星_星_表示 = value;
				this.悪タトゥ_五芒星_五角形_表示 = value;
				this.竜性_鱗1_表示 = value;
				this.竜性_鱗2_表示 = value;
				this.竜性_鱗3_表示 = value;
				this.竜性_鱗4_表示 = value;
				this.竜性_鱗5_表示 = value;
				this.パンスト_パンスト1_表示 = value;
				this.パンスト_パンスト2_表示 = value;
				this.ソックス_ソックス1_表示 = value;
				this.ソックス_ソックス2_表示 = value;
				this.ヒ\u30FCル1_バンプ_表示 = value;
				this.ヒ\u30FCル1_ストラップ_ストラップ_表示 = value;
				this.ヒ\u30FCル1_ストラップ_金具1_金具1_表示 = value;
				this.ヒ\u30FCル1_ストラップ_金具1_金具2_表示 = value;
				this.ヒ\u30FCル1_ストラップ_金具1_金具3_表示 = value;
				this.ヒ\u30FCル1_ストラップ_金具1_金具4_表示 = value;
				this.ヒ\u30FCル1_ストラップ_金具2_金具1_表示 = value;
				this.ヒ\u30FCル1_ストラップ_金具2_金具2_表示 = value;
				this.ヒ\u30FCル1_ストラップ_金具2_金具3_表示 = value;
				this.ヒ\u30FCル1_ストラップ_金具2_金具4_表示 = value;
				this.ヒ\u30FCル1_ハイライト_表示 = value;
				this.サンダル1_ストラップ3_表示 = value;
				this.サンダル1_ストラップ2_表示 = value;
				this.サンダル1_ストラップ4_表示 = value;
				this.サンダル1_ストラップ1_表示 = value;
				this.ナ\u30FCス1_ストラップ3_ストラップ_表示 = value;
				this.ナ\u30FCス1_ストラップ3_縁1_表示 = value;
				this.ナ\u30FCス1_ストラップ3_縁2_表示 = value;
				this.ナ\u30FCス1_ストラップ2_ストラップ_表示 = value;
				this.ナ\u30FCス1_ストラップ2_縁1_表示 = value;
				this.ナ\u30FCス1_ストラップ2_縁2_表示 = value;
				this.ナ\u30FCス1_ストラップ1_ストラップ_表示 = value;
				this.ナ\u30FCス1_ストラップ1_縁1_表示 = value;
				this.ナ\u30FCス1_ストラップ1_縁2_表示 = value;
				this.ブ\u30FCツ1_タン_表示 = value;
				this.ブ\u30FCツ1_バンプ_バンプ_表示 = value;
				this.ブ\u30FCツ1_バンプ_縁_縁1_表示 = value;
				this.ブ\u30FCツ1_バンプ_縁_縁2_表示 = value;
				this.ブ\u30FCツ1_バンプ_縁_縁3_表示 = value;
				this.ブ\u30FCツ1_バンプ_縁_縁4_表示 = value;
				this.ブ\u30FCツ1_ハイライト_表示 = value;
				this.ブ\u30FCツ1_柄_表示 = value;
				this.ブ\u30FCツ1_紐_紐1_紐下_金具上_金具_表示 = value;
				this.ブ\u30FCツ1_紐_紐1_紐下_金具上_穴_表示 = value;
				this.ブ\u30FCツ1_紐_紐1_紐下_紐_表示 = value;
				this.ブ\u30FCツ1_紐_紐1_紐上_金具上_金具_表示 = value;
				this.ブ\u30FCツ1_紐_紐1_紐上_金具上_穴_表示 = value;
				this.ブ\u30FCツ1_紐_紐1_紐上_紐_表示 = value;
				this.ブ\u30FCツ1_紐_紐2_紐下_金具上_金具_表示 = value;
				this.ブ\u30FCツ1_紐_紐2_紐下_金具上_穴_表示 = value;
				this.ブ\u30FCツ1_紐_紐2_紐下_紐_表示 = value;
				this.ブ\u30FCツ1_紐_紐2_紐上_金具上_金具_表示 = value;
				this.ブ\u30FCツ1_紐_紐2_紐上_金具上_穴_表示 = value;
				this.ブ\u30FCツ1_紐_紐2_紐上_紐_表示 = value;
				this.ブ\u30FCツ1_紐_紐3_紐下_金具上_金具_表示 = value;
				this.ブ\u30FCツ1_紐_紐3_紐下_金具上_穴_表示 = value;
				this.ブ\u30FCツ1_紐_紐3_紐下_紐_表示 = value;
				this.ブ\u30FCツ1_紐_紐3_紐上_金具上_金具_表示 = value;
				this.ブ\u30FCツ1_紐_紐3_紐上_金具上_穴_表示 = value;
				this.ブ\u30FCツ1_紐_紐3_紐上_紐_表示 = value;
				this.ブ\u30FCツ1_紐_紐4_紐下_金具上_金具_表示 = value;
				this.ブ\u30FCツ1_紐_紐4_紐下_金具上_穴_表示 = value;
				this.ブ\u30FCツ1_紐_紐4_紐下_紐_表示 = value;
				this.ブ\u30FCツ1_紐_紐4_紐上_金具上_金具_表示 = value;
				this.ブ\u30FCツ1_紐_紐4_紐上_金具上_穴_表示 = value;
				this.ブ\u30FCツ1_紐_紐4_紐上_紐_表示 = value;
				this.ブ\u30FCツ1_紐_紐5_金具1_金具_表示 = value;
				this.ブ\u30FCツ1_紐_紐5_金具1_穴_表示 = value;
				this.ブ\u30FCツ1_紐_紐5_金具2_金具_表示 = value;
				this.ブ\u30FCツ1_紐_紐5_金具2_穴_表示 = value;
				this.ブ\u30FCツ1_紐_紐5_紐_表示 = value;
				this.ア\u30FCマ1_鉄靴1_表示 = value;
				this.ア\u30FCマ1_鉄靴2_表示 = value;
				this.ア\u30FCマ1_鉄靴3_表示 = value;
				this.ナ\u30FCス1_ストラップ4_ストラップ_表示 = value;
				this.ナ\u30FCス1_ストラップ4_縁1_表示 = value;
				this.ナ\u30FCス1_ストラップ4_縁2_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.足CD.不透明度;
			}
			set
			{
				this.ヒ\u30FCル0_ヒ\u30FCルCD.不透明度 = value;
				this.ヒ\u30FCル0_靴底CD.不透明度 = value;
				this.サンダル0_踵CD.不透明度 = value;
				this.サンダル0_靴底CD.不透明度 = value;
				this.ナ\u30FCス0_踵CD.不透明度 = value;
				this.ナ\u30FCス0_靴底CD.不透明度 = value;
				this.ブ\u30FCツ0_ヒ\u30FCルCD.不透明度 = value;
				this.ブ\u30FCツ0_靴底CD.不透明度 = value;
				this.ア\u30FCマ0_踵CD.不透明度 = value;
				this.ア\u30FCマ0_靴底CD.不透明度 = value;
				this.足CD.不透明度 = value;
				this.小指_小指1CD.不透明度 = value;
				this.小指_小指2CD.不透明度 = value;
				this.小指_小指3CD.不透明度 = value;
				this.薬指_水掻CD.不透明度 = value;
				this.薬指_薬指1CD.不透明度 = value;
				this.薬指_薬指2CD.不透明度 = value;
				this.薬指_薬指3CD.不透明度 = value;
				this.中指_水掻CD.不透明度 = value;
				this.中指_中指1CD.不透明度 = value;
				this.中指_中指2CD.不透明度 = value;
				this.中指_中指3CD.不透明度 = value;
				this.人指_人指1CD.不透明度 = value;
				this.人指_人指2CD.不透明度 = value;
				this.人指_人指3CD.不透明度 = value;
				this.人指_水掻CD.不透明度 = value;
				this.親指_親指2CD.不透明度 = value;
				this.親指_親指3CD.不透明度 = value;
				this.親指_水掻CD.不透明度 = value;
				this.悪タトゥ_五芒星_円1CD.不透明度 = value;
				this.悪タトゥ_五芒星_円2CD.不透明度 = value;
				this.悪タトゥ_五芒星_星CD.不透明度 = value;
				this.悪タトゥ_五芒星_五角形CD.不透明度 = value;
				this.竜性_鱗1CD.不透明度 = value;
				this.竜性_鱗2CD.不透明度 = value;
				this.竜性_鱗3CD.不透明度 = value;
				this.竜性_鱗4CD.不透明度 = value;
				this.竜性_鱗5CD.不透明度 = value;
				this.パンスト_パンスト1CD.不透明度 = value;
				this.パンスト_パンスト2CD.不透明度 = value;
				this.ソックス_ソックス1CD.不透明度 = value;
				this.ソックス_ソックス2CD.不透明度 = value;
				this.ヒ\u30FCル1_バンプCD.不透明度 = value;
				this.ヒ\u30FCル1_ストラップ_ストラップCD.不透明度 = value;
				this.ヒ\u30FCル1_ストラップ_金具1_金具1CD.不透明度 = value;
				this.ヒ\u30FCル1_ストラップ_金具1_金具2CD.不透明度 = value;
				this.ヒ\u30FCル1_ストラップ_金具1_金具3CD.不透明度 = value;
				this.ヒ\u30FCル1_ストラップ_金具1_金具4CD.不透明度 = value;
				this.ヒ\u30FCル1_ストラップ_金具2_金具1CD.不透明度 = value;
				this.ヒ\u30FCル1_ストラップ_金具2_金具2CD.不透明度 = value;
				this.ヒ\u30FCル1_ストラップ_金具2_金具3CD.不透明度 = value;
				this.ヒ\u30FCル1_ストラップ_金具2_金具4CD.不透明度 = value;
				this.ヒ\u30FCル1_ハイライトCD.不透明度 = value;
				this.サンダル1_ストラップ3CD.不透明度 = value;
				this.サンダル1_ストラップ2CD.不透明度 = value;
				this.サンダル1_ストラップ4CD.不透明度 = value;
				this.サンダル1_ストラップ1CD.不透明度 = value;
				this.ナ\u30FCス1_ストラップ3_ストラップCD.不透明度 = value;
				this.ナ\u30FCス1_ストラップ3_縁1CD.不透明度 = value;
				this.ナ\u30FCス1_ストラップ3_縁2CD.不透明度 = value;
				this.ナ\u30FCス1_ストラップ2_ストラップCD.不透明度 = value;
				this.ナ\u30FCス1_ストラップ2_縁1CD.不透明度 = value;
				this.ナ\u30FCス1_ストラップ2_縁2CD.不透明度 = value;
				this.ナ\u30FCス1_ストラップ1_ストラップCD.不透明度 = value;
				this.ナ\u30FCス1_ストラップ1_縁1CD.不透明度 = value;
				this.ナ\u30FCス1_ストラップ1_縁2CD.不透明度 = value;
				this.ブ\u30FCツ1_タンCD.不透明度 = value;
				this.ブ\u30FCツ1_バンプ_バンプCD.不透明度 = value;
				this.ブ\u30FCツ1_バンプ_縁_縁1CD.不透明度 = value;
				this.ブ\u30FCツ1_バンプ_縁_縁2CD.不透明度 = value;
				this.ブ\u30FCツ1_バンプ_縁_縁3CD.不透明度 = value;
				this.ブ\u30FCツ1_バンプ_縁_縁4CD.不透明度 = value;
				this.ブ\u30FCツ1_ハイライトCD.不透明度 = value;
				this.ブ\u30FCツ1_柄CD.不透明度 = value;
				this.ブ\u30FCツ1_紐_紐1_紐下_金具上_金具CD.不透明度 = value;
				this.ブ\u30FCツ1_紐_紐1_紐下_金具上_穴CD.不透明度 = value;
				this.ブ\u30FCツ1_紐_紐1_紐下_紐CD.不透明度 = value;
				this.ブ\u30FCツ1_紐_紐1_紐上_金具上_金具CD.不透明度 = value;
				this.ブ\u30FCツ1_紐_紐1_紐上_金具上_穴CD.不透明度 = value;
				this.ブ\u30FCツ1_紐_紐1_紐上_紐CD.不透明度 = value;
				this.ブ\u30FCツ1_紐_紐2_紐下_金具上_金具CD.不透明度 = value;
				this.ブ\u30FCツ1_紐_紐2_紐下_金具上_穴CD.不透明度 = value;
				this.ブ\u30FCツ1_紐_紐2_紐下_紐CD.不透明度 = value;
				this.ブ\u30FCツ1_紐_紐2_紐上_金具上_金具CD.不透明度 = value;
				this.ブ\u30FCツ1_紐_紐2_紐上_金具上_穴CD.不透明度 = value;
				this.ブ\u30FCツ1_紐_紐2_紐上_紐CD.不透明度 = value;
				this.ブ\u30FCツ1_紐_紐3_紐下_金具上_金具CD.不透明度 = value;
				this.ブ\u30FCツ1_紐_紐3_紐下_金具上_穴CD.不透明度 = value;
				this.ブ\u30FCツ1_紐_紐3_紐下_紐CD.不透明度 = value;
				this.ブ\u30FCツ1_紐_紐3_紐上_金具上_金具CD.不透明度 = value;
				this.ブ\u30FCツ1_紐_紐3_紐上_金具上_穴CD.不透明度 = value;
				this.ブ\u30FCツ1_紐_紐3_紐上_紐CD.不透明度 = value;
				this.ブ\u30FCツ1_紐_紐4_紐下_金具上_金具CD.不透明度 = value;
				this.ブ\u30FCツ1_紐_紐4_紐下_金具上_穴CD.不透明度 = value;
				this.ブ\u30FCツ1_紐_紐4_紐下_紐CD.不透明度 = value;
				this.ブ\u30FCツ1_紐_紐4_紐上_金具上_金具CD.不透明度 = value;
				this.ブ\u30FCツ1_紐_紐4_紐上_金具上_穴CD.不透明度 = value;
				this.ブ\u30FCツ1_紐_紐4_紐上_紐CD.不透明度 = value;
				this.ブ\u30FCツ1_紐_紐5_金具1_金具CD.不透明度 = value;
				this.ブ\u30FCツ1_紐_紐5_金具1_穴CD.不透明度 = value;
				this.ブ\u30FCツ1_紐_紐5_金具2_金具CD.不透明度 = value;
				this.ブ\u30FCツ1_紐_紐5_金具2_穴CD.不透明度 = value;
				this.ブ\u30FCツ1_紐_紐5_紐CD.不透明度 = value;
				this.ア\u30FCマ1_鉄靴1CD.不透明度 = value;
				this.ア\u30FCマ1_鉄靴2CD.不透明度 = value;
				this.ア\u30FCマ1_鉄靴3CD.不透明度 = value;
				this.ナ\u30FCス1_ストラップ4_ストラップCD.不透明度 = value;
				this.ナ\u30FCス1_ストラップ4_縁1CD.不透明度 = value;
				this.ナ\u30FCス1_ストラップ4_縁2CD.不透明度 = value;
			}
		}

		public override void 描画0(Are Are)
		{
			if (this.本体.IndexY == 0)
			{
				Are.Draw(this.X0Y0_足);
				Are.Draw(this.X0Y0_小指_小指1);
				Are.Draw(this.X0Y0_小指_小指2);
				Are.Draw(this.X0Y0_小指_小指3);
				Are.Draw(this.X0Y0_薬指_水掻);
				Are.Draw(this.X0Y0_薬指_薬指1);
				Are.Draw(this.X0Y0_薬指_薬指2);
				Are.Draw(this.X0Y0_薬指_薬指3);
				Are.Draw(this.X0Y0_中指_水掻);
				Are.Draw(this.X0Y0_中指_中指1);
				Are.Draw(this.X0Y0_中指_中指2);
				Are.Draw(this.X0Y0_中指_中指3);
				Are.Draw(this.X0Y0_人指_人指1);
				Are.Draw(this.X0Y0_人指_人指2);
				Are.Draw(this.X0Y0_人指_人指3);
				Are.Draw(this.X0Y0_人指_水掻);
				Are.Draw(this.X0Y0_親指_親指2);
				Are.Draw(this.X0Y0_親指_親指3);
				Are.Draw(this.X0Y0_親指_水掻);
				Are.Draw(this.X0Y0_竜性_鱗1);
				Are.Draw(this.X0Y0_竜性_鱗2);
				Are.Draw(this.X0Y0_竜性_鱗3);
				Are.Draw(this.X0Y0_竜性_鱗4);
				Are.Draw(this.X0Y0_竜性_鱗5);
				Are.Draw(this.X0Y0_悪タトゥ_五芒星_円1);
				Are.Draw(this.X0Y0_悪タトゥ_五芒星_円2);
				Are.Draw(this.X0Y0_悪タトゥ_五芒星_星);
				Are.Draw(this.X0Y0_悪タトゥ_五芒星_五角形);
				this.キスマ\u30FCク.Draw(Are);
				this.鞭痕.Draw(Are);
				Are.Draw(this.X0Y0_パンスト_パンスト1);
				Are.Draw(this.X0Y0_パンスト_パンスト2);
				Are.Draw(this.X0Y0_ソックス_ソックス1);
				Are.Draw(this.X0Y0_ソックス_ソックス2);
				return;
			}
			Are.Draw(this.X0Y1_足);
			Are.Draw(this.X0Y1_小指_小指1);
			Are.Draw(this.X0Y1_小指_小指2);
			Are.Draw(this.X0Y1_小指_小指3);
			Are.Draw(this.X0Y1_薬指_水掻);
			Are.Draw(this.X0Y1_薬指_薬指1);
			Are.Draw(this.X0Y1_薬指_薬指2);
			Are.Draw(this.X0Y1_薬指_薬指3);
			Are.Draw(this.X0Y1_中指_水掻);
			Are.Draw(this.X0Y1_中指_中指1);
			Are.Draw(this.X0Y1_中指_中指2);
			Are.Draw(this.X0Y1_中指_中指3);
			Are.Draw(this.X0Y1_人指_水掻);
			Are.Draw(this.X0Y1_人指_人指1);
			Are.Draw(this.X0Y1_人指_人指2);
			Are.Draw(this.X0Y1_人指_人指3);
			Are.Draw(this.X0Y1_親指_水掻);
			Are.Draw(this.X0Y1_親指_親指2);
			Are.Draw(this.X0Y1_親指_親指3);
			Are.Draw(this.X0Y1_竜性_鱗1);
			Are.Draw(this.X0Y1_竜性_鱗2);
			Are.Draw(this.X0Y1_竜性_鱗3);
			Are.Draw(this.X0Y1_竜性_鱗4);
			Are.Draw(this.X0Y1_竜性_鱗5);
			Are.Draw(this.X0Y1_悪タトゥ_五芒星_円1);
			Are.Draw(this.X0Y1_悪タトゥ_五芒星_円2);
			Are.Draw(this.X0Y1_悪タトゥ_五芒星_星);
			Are.Draw(this.X0Y1_悪タトゥ_五芒星_五角形);
			this.キスマ\u30FCク.Draw(Are);
			this.鞭痕.Draw(Are);
			Are.Draw(this.X0Y1_パンスト_パンスト1);
			Are.Draw(this.X0Y1_パンスト_パンスト2);
			Are.Draw(this.X0Y1_ソックス_ソックス1);
			Are.Draw(this.X0Y1_ソックス_ソックス2);
		}

		public void 底描画(Are Are)
		{
			if (this.本体.IndexY == 0)
			{
				Are.Draw(this.X0Y0_ヒ\u30FCル0_靴底);
				Are.Draw(this.X0Y0_サンダル0_靴底);
				Are.Draw(this.X0Y0_ナ\u30FCス0_靴底);
				Are.Draw(this.X0Y0_ブ\u30FCツ0_靴底);
				Are.Draw(this.X0Y0_ア\u30FCマ0_靴底);
				return;
			}
			Are.Draw(this.X0Y1_ヒ\u30FCル0_ヒ\u30FCル);
			Are.Draw(this.X0Y1_ヒ\u30FCル0_靴底);
			Are.Draw(this.X0Y1_サンダル0_踵);
			Are.Draw(this.X0Y1_サンダル0_靴底);
			Are.Draw(this.X0Y1_ナ\u30FCス0_踵);
			Are.Draw(this.X0Y1_ナ\u30FCス0_靴底);
			Are.Draw(this.X0Y1_ブ\u30FCツ0_ヒ\u30FCル);
			Are.Draw(this.X0Y1_ブ\u30FCツ0_靴底);
			Are.Draw(this.X0Y1_ア\u30FCマ0_踵);
			Are.Draw(this.X0Y1_ア\u30FCマ0_靴底);
		}

		public void 靴描画(Are Are)
		{
			if (this.本体.IndexY == 0)
			{
				Are.Draw(this.X0Y0_ヒ\u30FCル1_バンプ);
				Are.Draw(this.X0Y0_ヒ\u30FCル1_ストラップ_ストラップ);
				Are.Draw(this.X0Y0_ヒ\u30FCル1_ストラップ_金具1_金具1);
				Are.Draw(this.X0Y0_ヒ\u30FCル1_ストラップ_金具1_金具2);
				Are.Draw(this.X0Y0_ヒ\u30FCル1_ストラップ_金具1_金具3);
				Are.Draw(this.X0Y0_ヒ\u30FCル1_ストラップ_金具1_金具4);
				Are.Draw(this.X0Y0_ヒ\u30FCル1_ストラップ_金具2_金具1);
				Are.Draw(this.X0Y0_ヒ\u30FCル1_ストラップ_金具2_金具2);
				Are.Draw(this.X0Y0_ヒ\u30FCル1_ストラップ_金具2_金具3);
				Are.Draw(this.X0Y0_ヒ\u30FCル1_ストラップ_金具2_金具4);
				Are.Draw(this.X0Y0_ヒ\u30FCル1_ハイライト);
				Are.Draw(this.X0Y0_サンダル1_ストラップ3);
				Are.Draw(this.X0Y0_サンダル1_ストラップ2);
				Are.Draw(this.X0Y0_サンダル1_ストラップ4);
				Are.Draw(this.X0Y0_サンダル1_ストラップ1);
				Are.Draw(this.X0Y0_ナ\u30FCス1_ストラップ3_ストラップ);
				Are.Draw(this.X0Y0_ナ\u30FCス1_ストラップ3_縁1);
				Are.Draw(this.X0Y0_ナ\u30FCス1_ストラップ3_縁2);
				Are.Draw(this.X0Y0_ナ\u30FCス1_ストラップ2_ストラップ);
				Are.Draw(this.X0Y0_ナ\u30FCス1_ストラップ2_縁1);
				Are.Draw(this.X0Y0_ナ\u30FCス1_ストラップ2_縁2);
				Are.Draw(this.X0Y0_ナ\u30FCス1_ストラップ1_ストラップ);
				Are.Draw(this.X0Y0_ナ\u30FCス1_ストラップ1_縁1);
				Are.Draw(this.X0Y0_ナ\u30FCス1_ストラップ1_縁2);
				Are.Draw(this.X0Y0_ブ\u30FCツ1_タン);
				Are.Draw(this.X0Y0_ブ\u30FCツ1_バンプ_バンプ);
				Are.Draw(this.X0Y0_ブ\u30FCツ1_バンプ_縁_縁1);
				Are.Draw(this.X0Y0_ブ\u30FCツ1_バンプ_縁_縁2);
				Are.Draw(this.X0Y0_ブ\u30FCツ1_バンプ_縁_縁3);
				Are.Draw(this.X0Y0_ブ\u30FCツ1_バンプ_縁_縁4);
				Are.Draw(this.X0Y0_ブ\u30FCツ1_ハイライト);
				Are.Draw(this.X0Y0_ブ\u30FCツ1_柄);
				Are.Draw(this.X0Y0_ブ\u30FCツ1_紐_紐1_紐下_金具上_金具);
				Are.Draw(this.X0Y0_ブ\u30FCツ1_紐_紐1_紐下_金具上_穴);
				Are.Draw(this.X0Y0_ブ\u30FCツ1_紐_紐1_紐下_紐);
				Are.Draw(this.X0Y0_ブ\u30FCツ1_紐_紐1_紐上_金具上_金具);
				Are.Draw(this.X0Y0_ブ\u30FCツ1_紐_紐1_紐上_金具上_穴);
				Are.Draw(this.X0Y0_ブ\u30FCツ1_紐_紐1_紐上_紐);
				Are.Draw(this.X0Y0_ブ\u30FCツ1_紐_紐2_紐下_金具上_金具);
				Are.Draw(this.X0Y0_ブ\u30FCツ1_紐_紐2_紐下_金具上_穴);
				Are.Draw(this.X0Y0_ブ\u30FCツ1_紐_紐2_紐下_紐);
				Are.Draw(this.X0Y0_ブ\u30FCツ1_紐_紐2_紐上_金具上_金具);
				Are.Draw(this.X0Y0_ブ\u30FCツ1_紐_紐2_紐上_金具上_穴);
				Are.Draw(this.X0Y0_ブ\u30FCツ1_紐_紐2_紐上_紐);
				Are.Draw(this.X0Y0_ブ\u30FCツ1_紐_紐3_紐下_金具上_金具);
				Are.Draw(this.X0Y0_ブ\u30FCツ1_紐_紐3_紐下_金具上_穴);
				Are.Draw(this.X0Y0_ブ\u30FCツ1_紐_紐3_紐下_紐);
				Are.Draw(this.X0Y0_ブ\u30FCツ1_紐_紐3_紐上_金具上_金具);
				Are.Draw(this.X0Y0_ブ\u30FCツ1_紐_紐3_紐上_金具上_穴);
				Are.Draw(this.X0Y0_ブ\u30FCツ1_紐_紐3_紐上_紐);
				Are.Draw(this.X0Y0_ブ\u30FCツ1_紐_紐4_紐下_金具上_金具);
				Are.Draw(this.X0Y0_ブ\u30FCツ1_紐_紐4_紐下_金具上_穴);
				Are.Draw(this.X0Y0_ブ\u30FCツ1_紐_紐4_紐下_紐);
				Are.Draw(this.X0Y0_ブ\u30FCツ1_紐_紐4_紐上_金具上_金具);
				Are.Draw(this.X0Y0_ブ\u30FCツ1_紐_紐4_紐上_金具上_穴);
				Are.Draw(this.X0Y0_ブ\u30FCツ1_紐_紐4_紐上_紐);
				Are.Draw(this.X0Y0_ブ\u30FCツ1_紐_紐5_金具1_金具);
				Are.Draw(this.X0Y0_ブ\u30FCツ1_紐_紐5_金具1_穴);
				Are.Draw(this.X0Y0_ブ\u30FCツ1_紐_紐5_金具2_金具);
				Are.Draw(this.X0Y0_ブ\u30FCツ1_紐_紐5_金具2_穴);
				Are.Draw(this.X0Y0_ブ\u30FCツ1_紐_紐5_紐);
				Are.Draw(this.X0Y0_ア\u30FCマ1_鉄靴1);
				Are.Draw(this.X0Y0_ア\u30FCマ1_鉄靴2);
				Are.Draw(this.X0Y0_ア\u30FCマ1_鉄靴3);
				return;
			}
			Are.Draw(this.X0Y1_ヒ\u30FCル1_バンプ);
			Are.Draw(this.X0Y1_ヒ\u30FCル1_ストラップ_ストラップ);
			Are.Draw(this.X0Y1_ヒ\u30FCル1_ストラップ_金具1_金具1);
			Are.Draw(this.X0Y1_ヒ\u30FCル1_ストラップ_金具1_金具2);
			Are.Draw(this.X0Y1_ヒ\u30FCル1_ストラップ_金具1_金具3);
			Are.Draw(this.X0Y1_ヒ\u30FCル1_ストラップ_金具1_金具4);
			Are.Draw(this.X0Y1_ヒ\u30FCル1_ストラップ_金具2_金具1);
			Are.Draw(this.X0Y1_ヒ\u30FCル1_ストラップ_金具2_金具2);
			Are.Draw(this.X0Y1_ヒ\u30FCル1_ストラップ_金具2_金具3);
			Are.Draw(this.X0Y1_ヒ\u30FCル1_ストラップ_金具2_金具4);
			Are.Draw(this.X0Y1_ヒ\u30FCル1_ハイライト);
			Are.Draw(this.X0Y1_サンダル1_ストラップ3);
			Are.Draw(this.X0Y1_サンダル1_ストラップ2);
			Are.Draw(this.X0Y1_サンダル1_ストラップ4);
			Are.Draw(this.X0Y1_サンダル1_ストラップ1);
			Are.Draw(this.X0Y1_ナ\u30FCス1_ストラップ4_ストラップ);
			Are.Draw(this.X0Y1_ナ\u30FCス1_ストラップ4_縁1);
			Are.Draw(this.X0Y1_ナ\u30FCス1_ストラップ4_縁2);
			Are.Draw(this.X0Y1_ナ\u30FCス1_ストラップ3_ストラップ);
			Are.Draw(this.X0Y1_ナ\u30FCス1_ストラップ3_縁1);
			Are.Draw(this.X0Y1_ナ\u30FCス1_ストラップ3_縁2);
			Are.Draw(this.X0Y1_ナ\u30FCス1_ストラップ2_ストラップ);
			Are.Draw(this.X0Y1_ナ\u30FCス1_ストラップ2_縁1);
			Are.Draw(this.X0Y1_ナ\u30FCス1_ストラップ2_縁2);
			Are.Draw(this.X0Y1_ナ\u30FCス1_ストラップ1_ストラップ);
			Are.Draw(this.X0Y1_ナ\u30FCス1_ストラップ1_縁1);
			Are.Draw(this.X0Y1_ナ\u30FCス1_ストラップ1_縁2);
			Are.Draw(this.X0Y1_ブ\u30FCツ1_タン);
			Are.Draw(this.X0Y1_ブ\u30FCツ1_バンプ_バンプ);
			Are.Draw(this.X0Y1_ブ\u30FCツ1_バンプ_縁_縁1);
			Are.Draw(this.X0Y1_ブ\u30FCツ1_バンプ_縁_縁2);
			Are.Draw(this.X0Y1_ブ\u30FCツ1_バンプ_縁_縁3);
			Are.Draw(this.X0Y1_ブ\u30FCツ1_バンプ_縁_縁4);
			Are.Draw(this.X0Y1_ブ\u30FCツ1_ハイライト);
			Are.Draw(this.X0Y1_ブ\u30FCツ1_柄);
			Are.Draw(this.X0Y1_ブ\u30FCツ1_紐_紐1_紐下_金具上_金具);
			Are.Draw(this.X0Y1_ブ\u30FCツ1_紐_紐1_紐下_金具上_穴);
			Are.Draw(this.X0Y1_ブ\u30FCツ1_紐_紐1_紐下_紐);
			Are.Draw(this.X0Y1_ブ\u30FCツ1_紐_紐1_紐上_金具上_金具);
			Are.Draw(this.X0Y1_ブ\u30FCツ1_紐_紐1_紐上_金具上_穴);
			Are.Draw(this.X0Y1_ブ\u30FCツ1_紐_紐1_紐上_紐);
			Are.Draw(this.X0Y1_ブ\u30FCツ1_紐_紐2_紐下_金具上_金具);
			Are.Draw(this.X0Y1_ブ\u30FCツ1_紐_紐2_紐下_金具上_穴);
			Are.Draw(this.X0Y1_ブ\u30FCツ1_紐_紐2_紐下_紐);
			Are.Draw(this.X0Y1_ブ\u30FCツ1_紐_紐2_紐上_金具上_金具);
			Are.Draw(this.X0Y1_ブ\u30FCツ1_紐_紐2_紐上_金具上_穴);
			Are.Draw(this.X0Y1_ブ\u30FCツ1_紐_紐2_紐上_紐);
			Are.Draw(this.X0Y1_ブ\u30FCツ1_紐_紐3_紐下_金具上_金具);
			Are.Draw(this.X0Y1_ブ\u30FCツ1_紐_紐3_紐下_金具上_穴);
			Are.Draw(this.X0Y1_ブ\u30FCツ1_紐_紐3_紐下_紐);
			Are.Draw(this.X0Y1_ブ\u30FCツ1_紐_紐3_紐上_金具上_金具);
			Are.Draw(this.X0Y1_ブ\u30FCツ1_紐_紐3_紐上_金具上_穴);
			Are.Draw(this.X0Y1_ブ\u30FCツ1_紐_紐3_紐上_紐);
			Are.Draw(this.X0Y1_ブ\u30FCツ1_紐_紐4_紐下_金具上_金具);
			Are.Draw(this.X0Y1_ブ\u30FCツ1_紐_紐4_紐下_金具上_穴);
			Are.Draw(this.X0Y1_ブ\u30FCツ1_紐_紐4_紐下_紐);
			Are.Draw(this.X0Y1_ブ\u30FCツ1_紐_紐4_紐上_金具上_金具);
			Are.Draw(this.X0Y1_ブ\u30FCツ1_紐_紐4_紐上_金具上_穴);
			Are.Draw(this.X0Y1_ブ\u30FCツ1_紐_紐4_紐上_紐);
			Are.Draw(this.X0Y1_ブ\u30FCツ1_紐_紐5_金具1_金具);
			Are.Draw(this.X0Y1_ブ\u30FCツ1_紐_紐5_金具1_穴);
			Are.Draw(this.X0Y1_ブ\u30FCツ1_紐_紐5_金具2_金具);
			Are.Draw(this.X0Y1_ブ\u30FCツ1_紐_紐5_金具2_穴);
			Are.Draw(this.X0Y1_ブ\u30FCツ1_紐_紐5_紐);
			Are.Draw(this.X0Y1_ア\u30FCマ1_鉄靴1);
			Are.Draw(this.X0Y1_ア\u30FCマ1_鉄靴2);
			Are.Draw(this.X0Y1_ア\u30FCマ1_鉄靴3);
		}

		public double 鋭爪
		{
			set
			{
				double scale = 1.7;
				int num = this.右 ? 1 : 0;
				List<Out> op = this.X0Y0_人指_人指3.OP;
				Out @out = op[(int)((double)(op.Count - num) * 0.5)];
				int num2 = (int)((double)@out.ps.Count * 0.5);
				List<Vector2D> ps = @out.ps;
				int index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y0_人指_人指3.BasePointBase) * scale * value;
				List<Out> op2 = this.X0Y0_中指_中指3.OP;
				@out = op2[(int)((double)(op2.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y0_中指_中指3.BasePointBase) * scale * value;
				List<Out> op3 = this.X0Y0_薬指_薬指3.OP;
				@out = op3[(int)((double)(op3.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y0_薬指_薬指3.BasePointBase) * scale * value;
				List<Out> op4 = this.X0Y0_小指_小指3.OP;
				@out = op4[(int)((double)(op4.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y0_小指_小指3.BasePointBase) * scale * value;
				List<Out> op5 = this.X0Y0_親指_親指3.OP;
				@out = op5[(int)((double)(op5.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y0_親指_親指3.BasePointBase) * scale * 0.65 * value;
				List<Out> op6 = this.X0Y1_人指_人指3.OP;
				@out = op6[(int)((double)(op6.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y1_人指_人指3.BasePointBase) * scale * value;
				List<Out> op7 = this.X0Y1_中指_中指3.OP;
				@out = op7[(int)((double)(op7.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y1_中指_中指3.BasePointBase) * scale * value;
				List<Out> op8 = this.X0Y1_薬指_薬指3.OP;
				@out = op8[(int)((double)(op8.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y1_薬指_薬指3.BasePointBase) * scale * value;
				List<Out> op9 = this.X0Y1_小指_小指3.OP;
				@out = op9[(int)((double)(op9.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y1_小指_小指3.BasePointBase) * scale * value;
				List<Out> op10 = this.X0Y1_親指_親指3.OP;
				@out = op10[(int)((double)(op10.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y1_親指_親指3.BasePointBase) * scale * 0.65 * value;
			}
		}

		public void 虫性()
		{
			this.X0Y0_人指_人指1.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y0_人指_人指2.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y0_人指_人指3.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y0_中指_中指1.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y0_中指_中指2.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y0_中指_中指3.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y0_薬指_薬指1.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y0_薬指_薬指2.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y0_薬指_薬指3.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y0_小指_小指1.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y0_小指_小指2.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y0_小指_小指3.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y0_親指_親指2.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y0_親指_親指3.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y1_人指_人指1.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y1_人指_人指2.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y1_人指_人指3.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y1_中指_中指1.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y1_中指_中指2.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y1_中指_中指3.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y1_薬指_薬指1.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y1_薬指_薬指2.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y1_薬指_薬指3.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y1_小指_小指1.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y1_小指_小指2.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y1_小指_小指3.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y1_親指_親指2.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y1_親指_親指3.OP[this.右 ? 3 : 0].Outline = true;
		}

		public void 虫足()
		{
			this.X0Y0_小指_小指1.SizeBase *= 1.5;
			this.X0Y0_小指_小指2.SizeBase *= 1.5;
			this.X0Y0_小指_小指3.SizeBase *= 1.5;
			this.X0Y0_人指_人指1.SizeBase *= 1.5;
			this.X0Y0_人指_人指2.SizeBase *= 1.5;
			this.X0Y0_人指_人指3.SizeBase *= 1.5;
			this.X0Y0_親指_親指2.SizeBase *= 1.5;
			this.X0Y0_親指_親指3.SizeBase *= 1.5;
			this.X0Y1_小指_小指1.SizeBase *= 1.5;
			this.X0Y1_小指_小指2.SizeBase *= 1.5;
			this.X0Y1_小指_小指3.SizeBase *= 1.5;
			this.X0Y1_人指_人指1.SizeBase *= 1.5;
			this.X0Y1_人指_人指2.SizeBase *= 1.5;
			this.X0Y1_人指_人指3.SizeBase *= 1.5;
			this.X0Y1_親指_親指2.SizeBase *= 1.5;
			this.X0Y1_親指_親指3.SizeBase *= 1.5;
			this.人指_人指1_表示 = false;
			this.人指_人指3_表示 = false;
			this.人指_人指2_表示 = false;
			this.中指_中指1_表示 = false;
			this.中指_中指3_表示 = false;
			this.中指_中指2_表示 = false;
			this.薬指_薬指1_表示 = false;
			this.薬指_薬指3_表示 = false;
			this.薬指_薬指2_表示 = false;
		}

		public void 開脚(腿_人 腿)
		{
			if (腿.本体.IndexY == 0 || 腿.本体.IndexY == 4)
			{
				this.本体.IndexY = 0;
				return;
			}
			if (腿.本体.IndexY == 1 || 腿.本体.IndexY == 2 || 腿.本体.IndexY == 3)
			{
				this.本体.IndexY = 1;
			}
		}

		public bool ヒ\u30FCル表示
		{
			get
			{
				return this.ヒ\u30FCル0_靴底_表示;
			}
			set
			{
				this.ヒ\u30FCル0_靴底_表示 = value;
				this.ヒ\u30FCル0_ヒ\u30FCル_表示 = value;
				this.ヒ\u30FCル1_バンプ_表示 = value;
				this.ヒ\u30FCル1_ストラップ_ストラップ_表示 = value;
				this.ヒ\u30FCル1_ストラップ_金具1_金具1_表示 = value;
				this.ヒ\u30FCル1_ストラップ_金具1_金具2_表示 = value;
				this.ヒ\u30FCル1_ストラップ_金具1_金具3_表示 = value;
				this.ヒ\u30FCル1_ストラップ_金具1_金具4_表示 = value;
				this.ヒ\u30FCル1_ストラップ_金具2_金具1_表示 = value;
				this.ヒ\u30FCル1_ストラップ_金具2_金具2_表示 = value;
				this.ヒ\u30FCル1_ストラップ_金具2_金具3_表示 = value;
				this.ヒ\u30FCル1_ストラップ_金具2_金具4_表示 = value;
				this.ヒ\u30FCル1_ハイライト_表示 = value;
			}
		}

		public bool サンダル表示
		{
			get
			{
				return this.サンダル0_靴底_表示;
			}
			set
			{
				this.サンダル0_靴底_表示 = value;
				this.サンダル0_踵_表示 = value;
				this.サンダル1_ストラップ3_表示 = value;
				this.サンダル1_ストラップ2_表示 = value;
				this.サンダル1_ストラップ4_表示 = value;
				this.サンダル1_ストラップ1_表示 = value;
			}
		}

		public bool ナ\u30FCス表示
		{
			get
			{
				return this.ナ\u30FCス0_靴底_表示;
			}
			set
			{
				this.ナ\u30FCス0_靴底_表示 = value;
				this.ナ\u30FCス0_踵_表示 = value;
				this.ナ\u30FCス1_ストラップ3_ストラップ_表示 = value;
				this.ナ\u30FCス1_ストラップ3_縁1_表示 = value;
				this.ナ\u30FCス1_ストラップ3_縁2_表示 = value;
				this.ナ\u30FCス1_ストラップ2_ストラップ_表示 = value;
				this.ナ\u30FCス1_ストラップ2_縁1_表示 = value;
				this.ナ\u30FCス1_ストラップ2_縁2_表示 = value;
				this.ナ\u30FCス1_ストラップ1_ストラップ_表示 = value;
				this.ナ\u30FCス1_ストラップ1_縁1_表示 = value;
				this.ナ\u30FCス1_ストラップ1_縁2_表示 = value;
				this.ナ\u30FCス1_ストラップ4_ストラップ_表示 = value;
				this.ナ\u30FCス1_ストラップ4_縁1_表示 = value;
				this.ナ\u30FCス1_ストラップ4_縁2_表示 = value;
			}
		}

		public bool ブ\u30FCツ表示
		{
			get
			{
				return this.ブ\u30FCツ0_靴底_表示;
			}
			set
			{
				this.ブ\u30FCツ0_靴底_表示 = value;
				this.ブ\u30FCツ0_ヒ\u30FCル_表示 = value;
				this.ブ\u30FCツ1_タン_表示 = value;
				this.ブ\u30FCツ1_バンプ_バンプ_表示 = value;
				this.ブ\u30FCツ1_バンプ_縁_縁1_表示 = value;
				this.ブ\u30FCツ1_バンプ_縁_縁2_表示 = value;
				this.ブ\u30FCツ1_バンプ_縁_縁3_表示 = value;
				this.ブ\u30FCツ1_バンプ_縁_縁4_表示 = value;
				this.ブ\u30FCツ1_ハイライト_表示 = value;
				this.ブ\u30FCツ1_柄_表示 = value;
				this.ブ\u30FCツ1_紐_紐1_紐下_金具上_金具_表示 = value;
				this.ブ\u30FCツ1_紐_紐1_紐下_金具上_穴_表示 = value;
				this.ブ\u30FCツ1_紐_紐1_紐下_紐_表示 = value;
				this.ブ\u30FCツ1_紐_紐1_紐上_金具上_金具_表示 = value;
				this.ブ\u30FCツ1_紐_紐1_紐上_金具上_穴_表示 = value;
				this.ブ\u30FCツ1_紐_紐1_紐上_紐_表示 = value;
				this.ブ\u30FCツ1_紐_紐2_紐下_金具上_金具_表示 = value;
				this.ブ\u30FCツ1_紐_紐2_紐下_金具上_穴_表示 = value;
				this.ブ\u30FCツ1_紐_紐2_紐下_紐_表示 = value;
				this.ブ\u30FCツ1_紐_紐2_紐上_金具上_金具_表示 = value;
				this.ブ\u30FCツ1_紐_紐2_紐上_金具上_穴_表示 = value;
				this.ブ\u30FCツ1_紐_紐2_紐上_紐_表示 = value;
				this.ブ\u30FCツ1_紐_紐3_紐下_金具上_金具_表示 = value;
				this.ブ\u30FCツ1_紐_紐3_紐下_金具上_穴_表示 = value;
				this.ブ\u30FCツ1_紐_紐3_紐下_紐_表示 = value;
				this.ブ\u30FCツ1_紐_紐3_紐上_金具上_金具_表示 = value;
				this.ブ\u30FCツ1_紐_紐3_紐上_金具上_穴_表示 = value;
				this.ブ\u30FCツ1_紐_紐3_紐上_紐_表示 = value;
				this.ブ\u30FCツ1_紐_紐4_紐下_金具上_金具_表示 = value;
				this.ブ\u30FCツ1_紐_紐4_紐下_金具上_穴_表示 = value;
				this.ブ\u30FCツ1_紐_紐4_紐下_紐_表示 = value;
				this.ブ\u30FCツ1_紐_紐4_紐上_金具上_金具_表示 = value;
				this.ブ\u30FCツ1_紐_紐4_紐上_金具上_穴_表示 = value;
				this.ブ\u30FCツ1_紐_紐4_紐上_紐_表示 = value;
				this.ブ\u30FCツ1_紐_紐5_金具1_金具_表示 = value;
				this.ブ\u30FCツ1_紐_紐5_金具1_穴_表示 = value;
				this.ブ\u30FCツ1_紐_紐5_金具2_金具_表示 = value;
				this.ブ\u30FCツ1_紐_紐5_金具2_穴_表示 = value;
				this.ブ\u30FCツ1_紐_紐5_紐_表示 = value;
			}
		}

		public bool メイル表示
		{
			get
			{
				return this.ア\u30FCマ0_靴底_表示;
			}
			set
			{
				this.ア\u30FCマ0_靴底_表示 = value;
				this.ア\u30FCマ0_踵_表示 = value;
				this.ア\u30FCマ1_鉄靴1_表示 = value;
				this.ア\u30FCマ1_鉄靴2_表示 = value;
				this.ア\u30FCマ1_鉄靴3_表示 = value;
			}
		}

		public bool パンスト表示
		{
			get
			{
				return this.パンスト_パンスト1_表示;
			}
			set
			{
				this.パンスト_パンスト1_表示 = value;
				this.パンスト_パンスト2_表示 = value;
			}
		}

		public bool ニ\u30FCハイ表示
		{
			get
			{
				return this.ソックス_ソックス1_表示;
			}
			set
			{
				this.ソックス_ソックス1_表示 = value;
				this.ソックス_ソックス2_表示 = value;
			}
		}

		public override bool Is布(Par p)
		{
			return p == this.X0Y0_パンスト_パンスト1 || p == this.X0Y0_パンスト_パンスト2 || p == this.X0Y0_ソックス_ソックス1 || p == this.X0Y0_ソックス_ソックス2 || p == this.X0Y1_パンスト_パンスト1 || p == this.X0Y1_パンスト_パンスト2 || p == this.X0Y1_ソックス_ソックス1 || p == this.X0Y1_ソックス_ソックス2;
		}

		public override bool Is革(Par p)
		{
			return p == this.X0Y0_ヒ\u30FCル0_靴底 || p == this.X0Y0_サンダル0_靴底 || p == this.X0Y0_ナ\u30FCス0_靴底 || p == this.X0Y0_ブ\u30FCツ0_靴底 || p == this.X0Y0_ヒ\u30FCル1_バンプ || p == this.X0Y0_ヒ\u30FCル1_ストラップ_ストラップ || p == this.X0Y0_ヒ\u30FCル1_ストラップ_金具1_金具1 || p == this.X0Y0_ヒ\u30FCル1_ストラップ_金具1_金具2 || p == this.X0Y0_ヒ\u30FCル1_ストラップ_金具1_金具3 || p == this.X0Y0_ヒ\u30FCル1_ストラップ_金具1_金具4 || p == this.X0Y0_ヒ\u30FCル1_ストラップ_金具2_金具1 || p == this.X0Y0_ヒ\u30FCル1_ストラップ_金具2_金具2 || p == this.X0Y0_ヒ\u30FCル1_ストラップ_金具2_金具3 || p == this.X0Y0_ヒ\u30FCル1_ストラップ_金具2_金具4 || p == this.X0Y0_ヒ\u30FCル1_ハイライト || p == this.X0Y0_サンダル1_ストラップ3 || p == this.X0Y0_サンダル1_ストラップ2 || p == this.X0Y0_サンダル1_ストラップ4 || p == this.X0Y0_サンダル1_ストラップ1 || p == this.X0Y0_ナ\u30FCス1_ストラップ3_ストラップ || p == this.X0Y0_ナ\u30FCス1_ストラップ3_縁1 || p == this.X0Y0_ナ\u30FCス1_ストラップ3_縁2 || p == this.X0Y0_ナ\u30FCス1_ストラップ2_ストラップ || p == this.X0Y0_ナ\u30FCス1_ストラップ2_縁1 || p == this.X0Y0_ナ\u30FCス1_ストラップ2_縁2 || p == this.X0Y0_ナ\u30FCス1_ストラップ1_ストラップ || p == this.X0Y0_ナ\u30FCス1_ストラップ1_縁1 || p == this.X0Y0_ナ\u30FCス1_ストラップ1_縁2 || p == this.X0Y0_ブ\u30FCツ1_タン || p == this.X0Y0_ブ\u30FCツ1_バンプ_バンプ || p == this.X0Y0_ブ\u30FCツ1_バンプ_縁_縁1 || p == this.X0Y0_ブ\u30FCツ1_バンプ_縁_縁2 || p == this.X0Y0_ブ\u30FCツ1_バンプ_縁_縁3 || p == this.X0Y0_ブ\u30FCツ1_バンプ_縁_縁4 || p == this.X0Y0_ブ\u30FCツ1_ハイライト || p == this.X0Y0_ブ\u30FCツ1_柄 || p == this.X0Y0_ブ\u30FCツ1_紐_紐1_紐下_金具上_金具 || p == this.X0Y0_ブ\u30FCツ1_紐_紐1_紐下_金具上_穴 || p == this.X0Y0_ブ\u30FCツ1_紐_紐1_紐下_紐 || p == this.X0Y0_ブ\u30FCツ1_紐_紐1_紐上_金具上_金具 || p == this.X0Y0_ブ\u30FCツ1_紐_紐1_紐上_金具上_穴 || p == this.X0Y0_ブ\u30FCツ1_紐_紐1_紐上_紐 || p == this.X0Y0_ブ\u30FCツ1_紐_紐2_紐下_金具上_金具 || p == this.X0Y0_ブ\u30FCツ1_紐_紐2_紐下_金具上_穴 || p == this.X0Y0_ブ\u30FCツ1_紐_紐2_紐下_紐 || p == this.X0Y0_ブ\u30FCツ1_紐_紐2_紐上_金具上_金具 || p == this.X0Y0_ブ\u30FCツ1_紐_紐2_紐上_金具上_穴 || p == this.X0Y0_ブ\u30FCツ1_紐_紐2_紐上_紐 || p == this.X0Y0_ブ\u30FCツ1_紐_紐3_紐下_金具上_金具 || p == this.X0Y0_ブ\u30FCツ1_紐_紐3_紐下_金具上_穴 || p == this.X0Y0_ブ\u30FCツ1_紐_紐3_紐下_紐 || p == this.X0Y0_ブ\u30FCツ1_紐_紐3_紐上_金具上_金具 || p == this.X0Y0_ブ\u30FCツ1_紐_紐3_紐上_金具上_穴 || p == this.X0Y0_ブ\u30FCツ1_紐_紐3_紐上_紐 || p == this.X0Y0_ブ\u30FCツ1_紐_紐4_紐下_金具上_金具 || p == this.X0Y0_ブ\u30FCツ1_紐_紐4_紐下_金具上_穴 || p == this.X0Y0_ブ\u30FCツ1_紐_紐4_紐下_紐 || p == this.X0Y0_ブ\u30FCツ1_紐_紐4_紐上_金具上_金具 || p == this.X0Y0_ブ\u30FCツ1_紐_紐4_紐上_金具上_穴 || p == this.X0Y0_ブ\u30FCツ1_紐_紐4_紐上_紐 || p == this.X0Y0_ブ\u30FCツ1_紐_紐5_金具1_金具 || p == this.X0Y0_ブ\u30FCツ1_紐_紐5_金具1_穴 || p == this.X0Y0_ブ\u30FCツ1_紐_紐5_金具2_金具 || p == this.X0Y0_ブ\u30FCツ1_紐_紐5_金具2_穴 || p == this.X0Y0_ブ\u30FCツ1_紐_紐5_紐 || p == this.X0Y1_ヒ\u30FCル0_ヒ\u30FCル || p == this.X0Y1_ヒ\u30FCル0_靴底 || p == this.X0Y1_サンダル0_踵 || p == this.X0Y1_サンダル0_靴底 || p == this.X0Y1_ナ\u30FCス0_踵 || p == this.X0Y1_ナ\u30FCス0_靴底 || p == this.X0Y1_ブ\u30FCツ0_ヒ\u30FCル || p == this.X0Y1_ブ\u30FCツ0_靴底 || p == this.X0Y1_ヒ\u30FCル1_バンプ || p == this.X0Y1_ヒ\u30FCル1_ストラップ_ストラップ || p == this.X0Y1_ヒ\u30FCル1_ストラップ_金具1_金具1 || p == this.X0Y1_ヒ\u30FCル1_ストラップ_金具1_金具2 || p == this.X0Y1_ヒ\u30FCル1_ストラップ_金具1_金具3 || p == this.X0Y1_ヒ\u30FCル1_ストラップ_金具1_金具4 || p == this.X0Y1_ヒ\u30FCル1_ストラップ_金具2_金具1 || p == this.X0Y1_ヒ\u30FCル1_ストラップ_金具2_金具2 || p == this.X0Y1_ヒ\u30FCル1_ストラップ_金具2_金具3 || p == this.X0Y1_ヒ\u30FCル1_ストラップ_金具2_金具4 || p == this.X0Y1_ヒ\u30FCル1_ハイライト || p == this.X0Y1_サンダル1_ストラップ3 || p == this.X0Y1_サンダル1_ストラップ2 || p == this.X0Y1_サンダル1_ストラップ4 || p == this.X0Y1_サンダル1_ストラップ1 || p == this.X0Y1_ナ\u30FCス1_ストラップ4_ストラップ || p == this.X0Y1_ナ\u30FCス1_ストラップ4_縁1 || p == this.X0Y1_ナ\u30FCス1_ストラップ4_縁2 || p == this.X0Y1_ナ\u30FCス1_ストラップ3_ストラップ || p == this.X0Y1_ナ\u30FCス1_ストラップ3_縁1 || p == this.X0Y1_ナ\u30FCス1_ストラップ3_縁2 || p == this.X0Y1_ナ\u30FCス1_ストラップ2_ストラップ || p == this.X0Y1_ナ\u30FCス1_ストラップ2_縁1 || p == this.X0Y1_ナ\u30FCス1_ストラップ2_縁2 || p == this.X0Y1_ナ\u30FCス1_ストラップ1_ストラップ || p == this.X0Y1_ナ\u30FCス1_ストラップ1_縁1 || p == this.X0Y1_ナ\u30FCス1_ストラップ1_縁2 || p == this.X0Y1_ブ\u30FCツ1_タン || p == this.X0Y1_ブ\u30FCツ1_バンプ_バンプ || p == this.X0Y1_ブ\u30FCツ1_バンプ_縁_縁1 || p == this.X0Y1_ブ\u30FCツ1_バンプ_縁_縁2 || p == this.X0Y1_ブ\u30FCツ1_バンプ_縁_縁3 || p == this.X0Y1_ブ\u30FCツ1_バンプ_縁_縁4 || p == this.X0Y1_ブ\u30FCツ1_ハイライト || p == this.X0Y1_ブ\u30FCツ1_柄 || p == this.X0Y1_ブ\u30FCツ1_紐_紐1_紐下_金具上_金具 || p == this.X0Y1_ブ\u30FCツ1_紐_紐1_紐下_金具上_穴 || p == this.X0Y1_ブ\u30FCツ1_紐_紐1_紐下_紐 || p == this.X0Y1_ブ\u30FCツ1_紐_紐1_紐上_金具上_金具 || p == this.X0Y1_ブ\u30FCツ1_紐_紐1_紐上_金具上_穴 || p == this.X0Y1_ブ\u30FCツ1_紐_紐1_紐上_紐 || p == this.X0Y1_ブ\u30FCツ1_紐_紐2_紐下_金具上_金具 || p == this.X0Y1_ブ\u30FCツ1_紐_紐2_紐下_金具上_穴 || p == this.X0Y1_ブ\u30FCツ1_紐_紐2_紐下_紐 || p == this.X0Y1_ブ\u30FCツ1_紐_紐2_紐上_金具上_金具 || p == this.X0Y1_ブ\u30FCツ1_紐_紐2_紐上_金具上_穴 || p == this.X0Y1_ブ\u30FCツ1_紐_紐2_紐上_紐 || p == this.X0Y1_ブ\u30FCツ1_紐_紐3_紐下_金具上_金具 || p == this.X0Y1_ブ\u30FCツ1_紐_紐3_紐下_金具上_穴 || p == this.X0Y1_ブ\u30FCツ1_紐_紐3_紐下_紐 || p == this.X0Y1_ブ\u30FCツ1_紐_紐3_紐上_金具上_金具 || p == this.X0Y1_ブ\u30FCツ1_紐_紐3_紐上_金具上_穴 || p == this.X0Y1_ブ\u30FCツ1_紐_紐3_紐上_紐 || p == this.X0Y1_ブ\u30FCツ1_紐_紐4_紐下_金具上_金具 || p == this.X0Y1_ブ\u30FCツ1_紐_紐4_紐下_金具上_穴 || p == this.X0Y1_ブ\u30FCツ1_紐_紐4_紐下_紐 || p == this.X0Y1_ブ\u30FCツ1_紐_紐4_紐上_金具上_金具 || p == this.X0Y1_ブ\u30FCツ1_紐_紐4_紐上_金具上_穴 || p == this.X0Y1_ブ\u30FCツ1_紐_紐4_紐上_紐 || p == this.X0Y1_ブ\u30FCツ1_紐_紐5_金具1_金具 || p == this.X0Y1_ブ\u30FCツ1_紐_紐5_金具1_穴 || p == this.X0Y1_ブ\u30FCツ1_紐_紐5_金具2_金具 || p == this.X0Y1_ブ\u30FCツ1_紐_紐5_金具2_穴 || p == this.X0Y1_ブ\u30FCツ1_紐_紐5_紐;
		}

		public override bool Is鉄(Par p)
		{
			return p == this.X0Y0_ア\u30FCマ0_靴底 || p == this.X0Y0_ア\u30FCマ1_鉄靴1 || p == this.X0Y0_ア\u30FCマ1_鉄靴2 || p == this.X0Y0_ア\u30FCマ1_鉄靴3 || p == this.X0Y1_ア\u30FCマ0_踵 || p == this.X0Y1_ア\u30FCマ0_靴底 || p == this.X0Y1_ア\u30FCマ1_鉄靴1 || p == this.X0Y1_ア\u30FCマ1_鉄靴2 || p == this.X0Y1_ア\u30FCマ1_鉄靴3;
		}

		public override void 色更新()
		{
			if (this.本体.IndexY == 0)
			{
				this.X0Y0_ヒ\u30FCル0_靴底CP.Update();
				this.X0Y0_サンダル0_靴底CP.Update();
				this.X0Y0_ナ\u30FCス0_靴底CP.Update();
				this.X0Y0_ブ\u30FCツ0_靴底CP.Update();
				this.X0Y0_ア\u30FCマ0_靴底CP.Update();
				this.X0Y0_足CP.Update();
				this.X0Y0_小指_小指1CP.Update();
				this.X0Y0_小指_小指2CP.Update();
				this.X0Y0_小指_小指3CP.Update();
				this.X0Y0_薬指_水掻CP.Update();
				this.X0Y0_薬指_薬指1CP.Update();
				this.X0Y0_薬指_薬指2CP.Update();
				this.X0Y0_薬指_薬指3CP.Update();
				this.X0Y0_中指_水掻CP.Update();
				this.X0Y0_中指_中指1CP.Update();
				this.X0Y0_中指_中指2CP.Update();
				this.X0Y0_中指_中指3CP.Update();
				this.X0Y0_人指_人指1CP.Update();
				this.X0Y0_人指_人指2CP.Update();
				this.X0Y0_人指_人指3CP.Update();
				this.X0Y0_人指_水掻CP.Update();
				this.X0Y0_親指_親指2CP.Update();
				this.X0Y0_親指_親指3CP.Update();
				this.X0Y0_親指_水掻CP.Update();
				this.X0Y0_悪タトゥ_五芒星_円1CP.Update();
				this.X0Y0_悪タトゥ_五芒星_円2CP.Update();
				this.X0Y0_悪タトゥ_五芒星_星CP.Update();
				this.X0Y0_悪タトゥ_五芒星_五角形CP.Update();
				this.X0Y0_竜性_鱗1CP.Update();
				this.X0Y0_竜性_鱗2CP.Update();
				this.X0Y0_竜性_鱗3CP.Update();
				this.X0Y0_竜性_鱗4CP.Update();
				this.X0Y0_竜性_鱗5CP.Update();
				this.X0Y0_パンスト_パンスト1CP.Update();
				this.X0Y0_パンスト_パンスト2CP.Update();
				this.X0Y0_ソックス_ソックス1CP.Update();
				this.X0Y0_ソックス_ソックス2CP.Update();
				this.X0Y0_ヒ\u30FCル1_バンプCP.Update();
				this.X0Y0_ヒ\u30FCル1_ストラップ_ストラップCP.Update();
				this.X0Y0_ヒ\u30FCル1_ストラップ_金具1_金具1CP.Update();
				this.X0Y0_ヒ\u30FCル1_ストラップ_金具1_金具2CP.Update();
				this.X0Y0_ヒ\u30FCル1_ストラップ_金具1_金具3CP.Update();
				this.X0Y0_ヒ\u30FCル1_ストラップ_金具1_金具4CP.Update();
				this.X0Y0_ヒ\u30FCル1_ストラップ_金具2_金具1CP.Update();
				this.X0Y0_ヒ\u30FCル1_ストラップ_金具2_金具2CP.Update();
				this.X0Y0_ヒ\u30FCル1_ストラップ_金具2_金具3CP.Update();
				this.X0Y0_ヒ\u30FCル1_ストラップ_金具2_金具4CP.Update();
				this.X0Y0_ヒ\u30FCル1_ハイライトCP.Update();
				this.X0Y0_サンダル1_ストラップ3CP.Update();
				this.X0Y0_サンダル1_ストラップ2CP.Update();
				this.X0Y0_サンダル1_ストラップ4CP.Update();
				this.X0Y0_サンダル1_ストラップ1CP.Update();
				this.X0Y0_ナ\u30FCス1_ストラップ3_ストラップCP.Update();
				this.X0Y0_ナ\u30FCス1_ストラップ3_縁1CP.Update();
				this.X0Y0_ナ\u30FCス1_ストラップ3_縁2CP.Update();
				this.X0Y0_ナ\u30FCス1_ストラップ2_ストラップCP.Update();
				this.X0Y0_ナ\u30FCス1_ストラップ2_縁1CP.Update();
				this.X0Y0_ナ\u30FCス1_ストラップ2_縁2CP.Update();
				this.X0Y0_ナ\u30FCス1_ストラップ1_ストラップCP.Update();
				this.X0Y0_ナ\u30FCス1_ストラップ1_縁1CP.Update();
				this.X0Y0_ナ\u30FCス1_ストラップ1_縁2CP.Update();
				this.X0Y0_ブ\u30FCツ1_タンCP.Update();
				this.X0Y0_ブ\u30FCツ1_バンプ_バンプCP.Update();
				this.X0Y0_ブ\u30FCツ1_バンプ_縁_縁1CP.Update();
				this.X0Y0_ブ\u30FCツ1_バンプ_縁_縁2CP.Update();
				this.X0Y0_ブ\u30FCツ1_バンプ_縁_縁3CP.Update();
				this.X0Y0_ブ\u30FCツ1_バンプ_縁_縁4CP.Update();
				this.X0Y0_ブ\u30FCツ1_ハイライトCP.Update();
				this.X0Y0_ブ\u30FCツ1_柄CP.Update();
				this.X0Y0_ブ\u30FCツ1_紐_紐1_紐下_金具上_金具CP.Update();
				this.X0Y0_ブ\u30FCツ1_紐_紐1_紐下_金具上_穴CP.Update();
				this.X0Y0_ブ\u30FCツ1_紐_紐1_紐下_紐CP.Update();
				this.X0Y0_ブ\u30FCツ1_紐_紐1_紐上_金具上_金具CP.Update();
				this.X0Y0_ブ\u30FCツ1_紐_紐1_紐上_金具上_穴CP.Update();
				this.X0Y0_ブ\u30FCツ1_紐_紐1_紐上_紐CP.Update();
				this.X0Y0_ブ\u30FCツ1_紐_紐2_紐下_金具上_金具CP.Update();
				this.X0Y0_ブ\u30FCツ1_紐_紐2_紐下_金具上_穴CP.Update();
				this.X0Y0_ブ\u30FCツ1_紐_紐2_紐下_紐CP.Update();
				this.X0Y0_ブ\u30FCツ1_紐_紐2_紐上_金具上_金具CP.Update();
				this.X0Y0_ブ\u30FCツ1_紐_紐2_紐上_金具上_穴CP.Update();
				this.X0Y0_ブ\u30FCツ1_紐_紐2_紐上_紐CP.Update();
				this.X0Y0_ブ\u30FCツ1_紐_紐3_紐下_金具上_金具CP.Update();
				this.X0Y0_ブ\u30FCツ1_紐_紐3_紐下_金具上_穴CP.Update();
				this.X0Y0_ブ\u30FCツ1_紐_紐3_紐下_紐CP.Update();
				this.X0Y0_ブ\u30FCツ1_紐_紐3_紐上_金具上_金具CP.Update();
				this.X0Y0_ブ\u30FCツ1_紐_紐3_紐上_金具上_穴CP.Update();
				this.X0Y0_ブ\u30FCツ1_紐_紐3_紐上_紐CP.Update();
				this.X0Y0_ブ\u30FCツ1_紐_紐4_紐下_金具上_金具CP.Update();
				this.X0Y0_ブ\u30FCツ1_紐_紐4_紐下_金具上_穴CP.Update();
				this.X0Y0_ブ\u30FCツ1_紐_紐4_紐下_紐CP.Update();
				this.X0Y0_ブ\u30FCツ1_紐_紐4_紐上_金具上_金具CP.Update();
				this.X0Y0_ブ\u30FCツ1_紐_紐4_紐上_金具上_穴CP.Update();
				this.X0Y0_ブ\u30FCツ1_紐_紐4_紐上_紐CP.Update();
				this.X0Y0_ブ\u30FCツ1_紐_紐5_金具1_金具CP.Update();
				this.X0Y0_ブ\u30FCツ1_紐_紐5_金具1_穴CP.Update();
				this.X0Y0_ブ\u30FCツ1_紐_紐5_金具2_金具CP.Update();
				this.X0Y0_ブ\u30FCツ1_紐_紐5_金具2_穴CP.Update();
				this.X0Y0_ブ\u30FCツ1_紐_紐5_紐CP.Update();
				this.X0Y0_ア\u30FCマ1_鉄靴1CP.Update();
				this.X0Y0_ア\u30FCマ1_鉄靴2CP.Update();
				this.X0Y0_ア\u30FCマ1_鉄靴3CP.Update();
				return;
			}
			this.X0Y1_ヒ\u30FCル0_ヒ\u30FCルCP.Update();
			this.X0Y1_ヒ\u30FCル0_靴底CP.Update();
			this.X0Y1_サンダル0_踵CP.Update();
			this.X0Y1_サンダル0_靴底CP.Update();
			this.X0Y1_ナ\u30FCス0_踵CP.Update();
			this.X0Y1_ナ\u30FCス0_靴底CP.Update();
			this.X0Y1_ブ\u30FCツ0_ヒ\u30FCルCP.Update();
			this.X0Y1_ブ\u30FCツ0_靴底CP.Update();
			this.X0Y1_ア\u30FCマ0_踵CP.Update();
			this.X0Y1_ア\u30FCマ0_靴底CP.Update();
			this.X0Y1_足CP.Update();
			this.X0Y1_小指_小指1CP.Update();
			this.X0Y1_小指_小指2CP.Update();
			this.X0Y1_小指_小指3CP.Update();
			this.X0Y1_薬指_水掻CP.Update();
			this.X0Y1_薬指_薬指1CP.Update();
			this.X0Y1_薬指_薬指2CP.Update();
			this.X0Y1_薬指_薬指3CP.Update();
			this.X0Y1_中指_水掻CP.Update();
			this.X0Y1_中指_中指1CP.Update();
			this.X0Y1_中指_中指2CP.Update();
			this.X0Y1_中指_中指3CP.Update();
			this.X0Y1_人指_水掻CP.Update();
			this.X0Y1_人指_人指1CP.Update();
			this.X0Y1_人指_人指2CP.Update();
			this.X0Y1_人指_人指3CP.Update();
			this.X0Y1_親指_水掻CP.Update();
			this.X0Y1_親指_親指2CP.Update();
			this.X0Y1_親指_親指3CP.Update();
			this.X0Y1_悪タトゥ_五芒星_円1CP.Update();
			this.X0Y1_悪タトゥ_五芒星_円2CP.Update();
			this.X0Y1_悪タトゥ_五芒星_星CP.Update();
			this.X0Y1_悪タトゥ_五芒星_五角形CP.Update();
			this.X0Y1_竜性_鱗1CP.Update();
			this.X0Y1_竜性_鱗2CP.Update();
			this.X0Y1_竜性_鱗3CP.Update();
			this.X0Y1_竜性_鱗4CP.Update();
			this.X0Y1_竜性_鱗5CP.Update();
			this.X0Y1_パンスト_パンスト1CP.Update();
			this.X0Y1_パンスト_パンスト2CP.Update();
			this.X0Y1_ソックス_ソックス1CP.Update();
			this.X0Y1_ソックス_ソックス2CP.Update();
			this.X0Y1_ヒ\u30FCル1_バンプCP.Update();
			this.X0Y1_ヒ\u30FCル1_ストラップ_ストラップCP.Update();
			this.X0Y1_ヒ\u30FCル1_ストラップ_金具1_金具1CP.Update();
			this.X0Y1_ヒ\u30FCル1_ストラップ_金具1_金具2CP.Update();
			this.X0Y1_ヒ\u30FCル1_ストラップ_金具1_金具3CP.Update();
			this.X0Y1_ヒ\u30FCル1_ストラップ_金具1_金具4CP.Update();
			this.X0Y1_ヒ\u30FCル1_ストラップ_金具2_金具1CP.Update();
			this.X0Y1_ヒ\u30FCル1_ストラップ_金具2_金具2CP.Update();
			this.X0Y1_ヒ\u30FCル1_ストラップ_金具2_金具3CP.Update();
			this.X0Y1_ヒ\u30FCル1_ストラップ_金具2_金具4CP.Update();
			this.X0Y1_ヒ\u30FCル1_ハイライトCP.Update();
			this.X0Y1_サンダル1_ストラップ3CP.Update();
			this.X0Y1_サンダル1_ストラップ2CP.Update();
			this.X0Y1_サンダル1_ストラップ4CP.Update();
			this.X0Y1_サンダル1_ストラップ1CP.Update();
			this.X0Y1_ナ\u30FCス1_ストラップ4_ストラップCP.Update();
			this.X0Y1_ナ\u30FCス1_ストラップ4_縁1CP.Update();
			this.X0Y1_ナ\u30FCス1_ストラップ4_縁2CP.Update();
			this.X0Y1_ナ\u30FCス1_ストラップ3_ストラップCP.Update();
			this.X0Y1_ナ\u30FCス1_ストラップ3_縁1CP.Update();
			this.X0Y1_ナ\u30FCス1_ストラップ3_縁2CP.Update();
			this.X0Y1_ナ\u30FCス1_ストラップ2_ストラップCP.Update();
			this.X0Y1_ナ\u30FCス1_ストラップ2_縁1CP.Update();
			this.X0Y1_ナ\u30FCス1_ストラップ2_縁2CP.Update();
			this.X0Y1_ナ\u30FCス1_ストラップ1_ストラップCP.Update();
			this.X0Y1_ナ\u30FCス1_ストラップ1_縁1CP.Update();
			this.X0Y1_ナ\u30FCス1_ストラップ1_縁2CP.Update();
			this.X0Y1_ブ\u30FCツ1_タンCP.Update();
			this.X0Y1_ブ\u30FCツ1_バンプ_バンプCP.Update();
			this.X0Y1_ブ\u30FCツ1_バンプ_縁_縁1CP.Update();
			this.X0Y1_ブ\u30FCツ1_バンプ_縁_縁2CP.Update();
			this.X0Y1_ブ\u30FCツ1_バンプ_縁_縁3CP.Update();
			this.X0Y1_ブ\u30FCツ1_バンプ_縁_縁4CP.Update();
			this.X0Y1_ブ\u30FCツ1_ハイライトCP.Update();
			this.X0Y1_ブ\u30FCツ1_柄CP.Update();
			this.X0Y1_ブ\u30FCツ1_紐_紐1_紐下_金具上_金具CP.Update();
			this.X0Y1_ブ\u30FCツ1_紐_紐1_紐下_金具上_穴CP.Update();
			this.X0Y1_ブ\u30FCツ1_紐_紐1_紐下_紐CP.Update();
			this.X0Y1_ブ\u30FCツ1_紐_紐1_紐上_金具上_金具CP.Update();
			this.X0Y1_ブ\u30FCツ1_紐_紐1_紐上_金具上_穴CP.Update();
			this.X0Y1_ブ\u30FCツ1_紐_紐1_紐上_紐CP.Update();
			this.X0Y1_ブ\u30FCツ1_紐_紐2_紐下_金具上_金具CP.Update();
			this.X0Y1_ブ\u30FCツ1_紐_紐2_紐下_金具上_穴CP.Update();
			this.X0Y1_ブ\u30FCツ1_紐_紐2_紐下_紐CP.Update();
			this.X0Y1_ブ\u30FCツ1_紐_紐2_紐上_金具上_金具CP.Update();
			this.X0Y1_ブ\u30FCツ1_紐_紐2_紐上_金具上_穴CP.Update();
			this.X0Y1_ブ\u30FCツ1_紐_紐2_紐上_紐CP.Update();
			this.X0Y1_ブ\u30FCツ1_紐_紐3_紐下_金具上_金具CP.Update();
			this.X0Y1_ブ\u30FCツ1_紐_紐3_紐下_金具上_穴CP.Update();
			this.X0Y1_ブ\u30FCツ1_紐_紐3_紐下_紐CP.Update();
			this.X0Y1_ブ\u30FCツ1_紐_紐3_紐上_金具上_金具CP.Update();
			this.X0Y1_ブ\u30FCツ1_紐_紐3_紐上_金具上_穴CP.Update();
			this.X0Y1_ブ\u30FCツ1_紐_紐3_紐上_紐CP.Update();
			this.X0Y1_ブ\u30FCツ1_紐_紐4_紐下_金具上_金具CP.Update();
			this.X0Y1_ブ\u30FCツ1_紐_紐4_紐下_金具上_穴CP.Update();
			this.X0Y1_ブ\u30FCツ1_紐_紐4_紐下_紐CP.Update();
			this.X0Y1_ブ\u30FCツ1_紐_紐4_紐上_金具上_金具CP.Update();
			this.X0Y1_ブ\u30FCツ1_紐_紐4_紐上_金具上_穴CP.Update();
			this.X0Y1_ブ\u30FCツ1_紐_紐4_紐上_紐CP.Update();
			this.X0Y1_ブ\u30FCツ1_紐_紐5_金具1_金具CP.Update();
			this.X0Y1_ブ\u30FCツ1_紐_紐5_金具1_穴CP.Update();
			this.X0Y1_ブ\u30FCツ1_紐_紐5_金具2_金具CP.Update();
			this.X0Y1_ブ\u30FCツ1_紐_紐5_金具2_穴CP.Update();
			this.X0Y1_ブ\u30FCツ1_紐_紐5_紐CP.Update();
			this.X0Y1_ア\u30FCマ1_鉄靴1CP.Update();
			this.X0Y1_ア\u30FCマ1_鉄靴2CP.Update();
			this.X0Y1_ア\u30FCマ1_鉄靴3CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			配色指定 配色指定 = this.配色指定;
			if (配色指定 <= 配色指定.B0)
			{
				if (配色指定 == 配色指定.N0)
				{
					this.配色N0(体配色);
					return;
				}
				if (配色指定 == 配色指定.B0)
				{
					this.配色B0(体配色);
					return;
				}
			}
			else
			{
				if (配色指定 == 配色指定.C0)
				{
					this.配色C0(体配色);
					return;
				}
				if (配色指定 == 配色指定.L0)
				{
					this.配色L0(体配色);
					return;
				}
			}
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.ヒ\u30FCル0_ヒ\u30FCルCD = new ColorD();
			this.ヒ\u30FCル0_靴底CD = new ColorD();
			this.サンダル0_踵CD = new ColorD();
			this.サンダル0_靴底CD = new ColorD();
			this.ナ\u30FCス0_踵CD = new ColorD();
			this.ナ\u30FCス0_靴底CD = new ColorD();
			this.ブ\u30FCツ0_ヒ\u30FCルCD = new ColorD();
			this.ブ\u30FCツ0_靴底CD = new ColorD();
			this.ア\u30FCマ0_踵CD = new ColorD();
			this.ア\u30FCマ0_靴底CD = new ColorD();
			this.足CD = new ColorD(ref Col.Black, ref 体配色.人肌R);
			this.小指_小指1CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.小指_小指2CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.小指_小指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.薬指_水掻CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.薬指_薬指1CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.薬指_薬指2CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.薬指_薬指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.中指_水掻CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.中指_中指1CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.中指_中指2CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.中指_中指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.人指_人指1CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.人指_人指2CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.人指_人指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.人指_水掻CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.親指_親指2CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.親指_親指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.親指_水掻CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.悪タトゥ_五芒星_円1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_五芒星_円2CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_五芒星_星CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_五芒星_五角形CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.パンスト_パンスト1CD = new ColorD();
			this.パンスト_パンスト2CD = new ColorD();
			this.ソックス_ソックス1CD = new ColorD();
			this.ソックス_ソックス2CD = new ColorD();
			this.ヒ\u30FCル1_バンプCD = new ColorD();
			this.ヒ\u30FCル1_ストラップ_ストラップCD = new ColorD();
			this.ヒ\u30FCル1_ストラップ_金具1_金具1CD = new ColorD();
			this.ヒ\u30FCル1_ストラップ_金具1_金具2CD = new ColorD();
			this.ヒ\u30FCル1_ストラップ_金具1_金具3CD = new ColorD();
			this.ヒ\u30FCル1_ストラップ_金具1_金具4CD = new ColorD();
			this.ヒ\u30FCル1_ストラップ_金具2_金具1CD = new ColorD();
			this.ヒ\u30FCル1_ストラップ_金具2_金具2CD = new ColorD();
			this.ヒ\u30FCル1_ストラップ_金具2_金具3CD = new ColorD();
			this.ヒ\u30FCル1_ストラップ_金具2_金具4CD = new ColorD();
			this.ヒ\u30FCル1_ハイライトCD = new ColorD(ref Col.Black, ref 体配色.ハイライト2O);
			this.サンダル1_ストラップ3CD = new ColorD();
			this.サンダル1_ストラップ2CD = new ColorD();
			this.サンダル1_ストラップ4CD = new ColorD();
			this.サンダル1_ストラップ1CD = new ColorD();
			this.ナ\u30FCス1_ストラップ3_ストラップCD = new ColorD();
			this.ナ\u30FCス1_ストラップ3_縁1CD = new ColorD();
			this.ナ\u30FCス1_ストラップ3_縁2CD = new ColorD();
			this.ナ\u30FCス1_ストラップ2_ストラップCD = new ColorD();
			this.ナ\u30FCス1_ストラップ2_縁1CD = new ColorD();
			this.ナ\u30FCス1_ストラップ2_縁2CD = new ColorD();
			this.ナ\u30FCス1_ストラップ1_ストラップCD = new ColorD();
			this.ナ\u30FCス1_ストラップ1_縁1CD = new ColorD();
			this.ナ\u30FCス1_ストラップ1_縁2CD = new ColorD();
			this.ブ\u30FCツ1_タンCD = new ColorD();
			this.ブ\u30FCツ1_バンプ_バンプCD = new ColorD();
			this.ブ\u30FCツ1_バンプ_縁_縁1CD = new ColorD();
			this.ブ\u30FCツ1_バンプ_縁_縁2CD = new ColorD();
			this.ブ\u30FCツ1_バンプ_縁_縁3CD = new ColorD();
			this.ブ\u30FCツ1_バンプ_縁_縁4CD = new ColorD();
			this.ブ\u30FCツ1_ハイライトCD = new ColorD(ref Col.Black, ref 体配色.ハイライト2O);
			this.ブ\u30FCツ1_柄CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐1_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐1_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐1_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐1_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐1_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐1_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐2_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐2_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐2_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐2_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐2_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐2_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐3_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐3_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐3_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐3_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐3_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐3_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐4_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐4_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐4_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐4_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐4_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐4_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐5_金具1_金具CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐5_金具1_穴CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐5_金具2_金具CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐5_金具2_穴CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐5_紐CD = new ColorD();
			this.ア\u30FCマ1_鉄靴1CD = new ColorD();
			this.ア\u30FCマ1_鉄靴2CD = new ColorD();
			this.ア\u30FCマ1_鉄靴3CD = new ColorD();
			this.ナ\u30FCス1_ストラップ4_ストラップCD = new ColorD();
			this.ナ\u30FCス1_ストラップ4_縁1CD = new ColorD();
			this.ナ\u30FCス1_ストラップ4_縁2CD = new ColorD();
		}

		private void 配色B0(体配色 体配色)
		{
			this.ヒ\u30FCル0_ヒ\u30FCルCD = new ColorD();
			this.ヒ\u30FCル0_靴底CD = new ColorD();
			this.サンダル0_踵CD = new ColorD();
			this.サンダル0_靴底CD = new ColorD();
			this.ナ\u30FCス0_踵CD = new ColorD();
			this.ナ\u30FCス0_靴底CD = new ColorD();
			this.ブ\u30FCツ0_ヒ\u30FCルCD = new ColorD();
			this.ブ\u30FCツ0_靴底CD = new ColorD();
			this.ア\u30FCマ0_踵CD = new ColorD();
			this.ア\u30FCマ0_靴底CD = new ColorD();
			this.足CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
			this.小指_小指1CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.小指_小指2CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.小指_小指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.薬指_水掻CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.薬指_薬指1CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.薬指_薬指2CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.薬指_薬指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.中指_水掻CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.中指_中指1CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.中指_中指2CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.中指_中指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.人指_人指1CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.人指_人指2CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.人指_人指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.人指_水掻CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.親指_親指2CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.親指_親指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.親指_水掻CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.悪タトゥ_五芒星_円1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_五芒星_円2CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_五芒星_星CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_五芒星_五角形CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.パンスト_パンスト1CD = new ColorD();
			this.パンスト_パンスト2CD = new ColorD();
			this.ソックス_ソックス1CD = new ColorD();
			this.ソックス_ソックス2CD = new ColorD();
			this.ヒ\u30FCル1_バンプCD = new ColorD();
			this.ヒ\u30FCル1_ストラップ_ストラップCD = new ColorD();
			this.ヒ\u30FCル1_ストラップ_金具1_金具1CD = new ColorD();
			this.ヒ\u30FCル1_ストラップ_金具1_金具2CD = new ColorD();
			this.ヒ\u30FCル1_ストラップ_金具1_金具3CD = new ColorD();
			this.ヒ\u30FCル1_ストラップ_金具1_金具4CD = new ColorD();
			this.ヒ\u30FCル1_ストラップ_金具2_金具1CD = new ColorD();
			this.ヒ\u30FCル1_ストラップ_金具2_金具2CD = new ColorD();
			this.ヒ\u30FCル1_ストラップ_金具2_金具3CD = new ColorD();
			this.ヒ\u30FCル1_ストラップ_金具2_金具4CD = new ColorD();
			this.ヒ\u30FCル1_ハイライトCD = new ColorD(ref Col.Black, ref 体配色.ハイライト2O);
			this.サンダル1_ストラップ3CD = new ColorD();
			this.サンダル1_ストラップ2CD = new ColorD();
			this.サンダル1_ストラップ4CD = new ColorD();
			this.サンダル1_ストラップ1CD = new ColorD();
			this.ナ\u30FCス1_ストラップ3_ストラップCD = new ColorD();
			this.ナ\u30FCス1_ストラップ3_縁1CD = new ColorD();
			this.ナ\u30FCス1_ストラップ3_縁2CD = new ColorD();
			this.ナ\u30FCス1_ストラップ2_ストラップCD = new ColorD();
			this.ナ\u30FCス1_ストラップ2_縁1CD = new ColorD();
			this.ナ\u30FCス1_ストラップ2_縁2CD = new ColorD();
			this.ナ\u30FCス1_ストラップ1_ストラップCD = new ColorD();
			this.ナ\u30FCス1_ストラップ1_縁1CD = new ColorD();
			this.ナ\u30FCス1_ストラップ1_縁2CD = new ColorD();
			this.ブ\u30FCツ1_タンCD = new ColorD();
			this.ブ\u30FCツ1_バンプ_バンプCD = new ColorD();
			this.ブ\u30FCツ1_バンプ_縁_縁1CD = new ColorD();
			this.ブ\u30FCツ1_バンプ_縁_縁2CD = new ColorD();
			this.ブ\u30FCツ1_バンプ_縁_縁3CD = new ColorD();
			this.ブ\u30FCツ1_バンプ_縁_縁4CD = new ColorD();
			this.ブ\u30FCツ1_ハイライトCD = new ColorD(ref Col.Black, ref 体配色.ハイライト2O);
			this.ブ\u30FCツ1_柄CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐1_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐1_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐1_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐1_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐1_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐1_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐2_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐2_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐2_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐2_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐2_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐2_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐3_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐3_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐3_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐3_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐3_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐3_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐4_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐4_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐4_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐4_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐4_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐4_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐5_金具1_金具CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐5_金具1_穴CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐5_金具2_金具CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐5_金具2_穴CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐5_紐CD = new ColorD();
			this.ア\u30FCマ1_鉄靴1CD = new ColorD();
			this.ア\u30FCマ1_鉄靴2CD = new ColorD();
			this.ア\u30FCマ1_鉄靴3CD = new ColorD();
			this.ナ\u30FCス1_ストラップ4_ストラップCD = new ColorD();
			this.ナ\u30FCス1_ストラップ4_縁1CD = new ColorD();
			this.ナ\u30FCス1_ストラップ4_縁2CD = new ColorD();
		}

		private void 配色C0(体配色 体配色)
		{
			this.ヒ\u30FCル0_ヒ\u30FCルCD = new ColorD();
			this.ヒ\u30FCル0_靴底CD = new ColorD();
			this.サンダル0_踵CD = new ColorD();
			this.サンダル0_靴底CD = new ColorD();
			this.ナ\u30FCス0_踵CD = new ColorD();
			this.ナ\u30FCス0_靴底CD = new ColorD();
			this.ブ\u30FCツ0_ヒ\u30FCルCD = new ColorD();
			this.ブ\u30FCツ0_靴底CD = new ColorD();
			this.ア\u30FCマ0_踵CD = new ColorD();
			this.ア\u30FCマ0_靴底CD = new ColorD();
			this.足CD = new ColorD(ref Col.Black, ref 体配色.甲0R);
			this.小指_小指1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.小指_小指2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.小指_小指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.薬指_水掻CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.薬指_薬指1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.薬指_薬指2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.薬指_薬指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.中指_水掻CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.中指_中指1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.中指_中指2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.中指_中指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.人指_人指1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.人指_人指2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.人指_人指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.人指_水掻CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.親指_親指2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.親指_親指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.親指_水掻CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.悪タトゥ_五芒星_円1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_五芒星_円2CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_五芒星_星CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_五芒星_五角形CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.パンスト_パンスト1CD = new ColorD();
			this.パンスト_パンスト2CD = new ColorD();
			this.ソックス_ソックス1CD = new ColorD();
			this.ソックス_ソックス2CD = new ColorD();
			this.ヒ\u30FCル1_バンプCD = new ColorD();
			this.ヒ\u30FCル1_ストラップ_ストラップCD = new ColorD();
			this.ヒ\u30FCル1_ストラップ_金具1_金具1CD = new ColorD();
			this.ヒ\u30FCル1_ストラップ_金具1_金具2CD = new ColorD();
			this.ヒ\u30FCル1_ストラップ_金具1_金具3CD = new ColorD();
			this.ヒ\u30FCル1_ストラップ_金具1_金具4CD = new ColorD();
			this.ヒ\u30FCル1_ストラップ_金具2_金具1CD = new ColorD();
			this.ヒ\u30FCル1_ストラップ_金具2_金具2CD = new ColorD();
			this.ヒ\u30FCル1_ストラップ_金具2_金具3CD = new ColorD();
			this.ヒ\u30FCル1_ストラップ_金具2_金具4CD = new ColorD();
			this.ヒ\u30FCル1_ハイライトCD = new ColorD(ref Col.Black, ref 体配色.ハイライト2O);
			this.サンダル1_ストラップ3CD = new ColorD();
			this.サンダル1_ストラップ2CD = new ColorD();
			this.サンダル1_ストラップ4CD = new ColorD();
			this.サンダル1_ストラップ1CD = new ColorD();
			this.ナ\u30FCス1_ストラップ3_ストラップCD = new ColorD();
			this.ナ\u30FCス1_ストラップ3_縁1CD = new ColorD();
			this.ナ\u30FCス1_ストラップ3_縁2CD = new ColorD();
			this.ナ\u30FCス1_ストラップ2_ストラップCD = new ColorD();
			this.ナ\u30FCス1_ストラップ2_縁1CD = new ColorD();
			this.ナ\u30FCス1_ストラップ2_縁2CD = new ColorD();
			this.ナ\u30FCス1_ストラップ1_ストラップCD = new ColorD();
			this.ナ\u30FCス1_ストラップ1_縁1CD = new ColorD();
			this.ナ\u30FCス1_ストラップ1_縁2CD = new ColorD();
			this.ブ\u30FCツ1_タンCD = new ColorD();
			this.ブ\u30FCツ1_バンプ_バンプCD = new ColorD();
			this.ブ\u30FCツ1_バンプ_縁_縁1CD = new ColorD();
			this.ブ\u30FCツ1_バンプ_縁_縁2CD = new ColorD();
			this.ブ\u30FCツ1_バンプ_縁_縁3CD = new ColorD();
			this.ブ\u30FCツ1_バンプ_縁_縁4CD = new ColorD();
			this.ブ\u30FCツ1_ハイライトCD = new ColorD(ref Col.Black, ref 体配色.ハイライト2O);
			this.ブ\u30FCツ1_柄CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐1_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐1_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐1_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐1_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐1_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐1_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐2_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐2_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐2_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐2_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐2_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐2_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐3_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐3_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐3_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐3_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐3_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐3_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐4_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐4_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐4_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐4_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐4_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐4_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐5_金具1_金具CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐5_金具1_穴CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐5_金具2_金具CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐5_金具2_穴CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐5_紐CD = new ColorD();
			this.ア\u30FCマ1_鉄靴1CD = new ColorD();
			this.ア\u30FCマ1_鉄靴2CD = new ColorD();
			this.ア\u30FCマ1_鉄靴3CD = new ColorD();
			this.ナ\u30FCス1_ストラップ4_ストラップCD = new ColorD();
			this.ナ\u30FCス1_ストラップ4_縁1CD = new ColorD();
			this.ナ\u30FCス1_ストラップ4_縁2CD = new ColorD();
		}

		private void 配色L0(体配色 体配色)
		{
			this.ヒ\u30FCル0_ヒ\u30FCルCD = new ColorD();
			this.ヒ\u30FCル0_靴底CD = new ColorD();
			this.サンダル0_踵CD = new ColorD();
			this.サンダル0_靴底CD = new ColorD();
			this.ナ\u30FCス0_踵CD = new ColorD();
			this.ナ\u30FCス0_靴底CD = new ColorD();
			this.ブ\u30FCツ0_ヒ\u30FCルCD = new ColorD();
			this.ブ\u30FCツ0_靴底CD = new ColorD();
			this.ア\u30FCマ0_踵CD = new ColorD();
			this.ア\u30FCマ0_靴底CD = new ColorD();
			this.足CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.小指_小指1CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.小指_小指2CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.小指_小指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.薬指_水掻CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.薬指_薬指1CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.薬指_薬指2CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.薬指_薬指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.中指_水掻CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.中指_中指1CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.中指_中指2CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.中指_中指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.人指_人指1CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.人指_人指2CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.人指_人指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.人指_水掻CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.親指_親指2CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.親指_親指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.親指_水掻CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.悪タトゥ_五芒星_円1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_五芒星_円2CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_五芒星_星CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_五芒星_五角形CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.パンスト_パンスト1CD = new ColorD();
			this.パンスト_パンスト2CD = new ColorD();
			this.ソックス_ソックス1CD = new ColorD();
			this.ソックス_ソックス2CD = new ColorD();
			this.ヒ\u30FCル1_バンプCD = new ColorD();
			this.ヒ\u30FCル1_ストラップ_ストラップCD = new ColorD();
			this.ヒ\u30FCル1_ストラップ_金具1_金具1CD = new ColorD();
			this.ヒ\u30FCル1_ストラップ_金具1_金具2CD = new ColorD();
			this.ヒ\u30FCル1_ストラップ_金具1_金具3CD = new ColorD();
			this.ヒ\u30FCル1_ストラップ_金具1_金具4CD = new ColorD();
			this.ヒ\u30FCル1_ストラップ_金具2_金具1CD = new ColorD();
			this.ヒ\u30FCル1_ストラップ_金具2_金具2CD = new ColorD();
			this.ヒ\u30FCル1_ストラップ_金具2_金具3CD = new ColorD();
			this.ヒ\u30FCル1_ストラップ_金具2_金具4CD = new ColorD();
			this.ヒ\u30FCル1_ハイライトCD = new ColorD(ref Col.Black, ref 体配色.ハイライト2O);
			this.サンダル1_ストラップ3CD = new ColorD();
			this.サンダル1_ストラップ2CD = new ColorD();
			this.サンダル1_ストラップ4CD = new ColorD();
			this.サンダル1_ストラップ1CD = new ColorD();
			this.ナ\u30FCス1_ストラップ3_ストラップCD = new ColorD();
			this.ナ\u30FCス1_ストラップ3_縁1CD = new ColorD();
			this.ナ\u30FCス1_ストラップ3_縁2CD = new ColorD();
			this.ナ\u30FCス1_ストラップ2_ストラップCD = new ColorD();
			this.ナ\u30FCス1_ストラップ2_縁1CD = new ColorD();
			this.ナ\u30FCス1_ストラップ2_縁2CD = new ColorD();
			this.ナ\u30FCス1_ストラップ1_ストラップCD = new ColorD();
			this.ナ\u30FCス1_ストラップ1_縁1CD = new ColorD();
			this.ナ\u30FCス1_ストラップ1_縁2CD = new ColorD();
			this.ブ\u30FCツ1_タンCD = new ColorD();
			this.ブ\u30FCツ1_バンプ_バンプCD = new ColorD();
			this.ブ\u30FCツ1_バンプ_縁_縁1CD = new ColorD();
			this.ブ\u30FCツ1_バンプ_縁_縁2CD = new ColorD();
			this.ブ\u30FCツ1_バンプ_縁_縁3CD = new ColorD();
			this.ブ\u30FCツ1_バンプ_縁_縁4CD = new ColorD();
			this.ブ\u30FCツ1_ハイライトCD = new ColorD(ref Col.Black, ref 体配色.ハイライト2O);
			this.ブ\u30FCツ1_柄CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐1_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐1_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐1_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐1_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐1_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐1_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐2_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐2_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐2_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐2_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐2_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐2_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐3_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐3_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐3_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐3_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐3_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐3_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐4_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐4_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐4_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐4_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐4_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐4_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐5_金具1_金具CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐5_金具1_穴CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐5_金具2_金具CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐5_金具2_穴CD = new ColorD();
			this.ブ\u30FCツ1_紐_紐5_紐CD = new ColorD();
			this.ア\u30FCマ1_鉄靴1CD = new ColorD();
			this.ア\u30FCマ1_鉄靴2CD = new ColorD();
			this.ア\u30FCマ1_鉄靴3CD = new ColorD();
			this.ナ\u30FCス1_ストラップ4_ストラップCD = new ColorD();
			this.ナ\u30FCス1_ストラップ4_縁1CD = new ColorD();
			this.ナ\u30FCス1_ストラップ4_縁2CD = new ColorD();
		}

		public void ブ\u30FCツ配色(ブ\u30FCツ色 配色)
		{
			this.ブ\u30FCツ0_ヒ\u30FCルCD.色 = 配色.踵色;
			this.ブ\u30FCツ0_靴底CD.色 = 配色.靴底色;
			this.ブ\u30FCツ1_タンCD.色 = 配色.生地2色;
			this.ブ\u30FCツ1_バンプ_バンプCD.色 = 配色.生地1色;
			this.ブ\u30FCツ1_バンプ_縁_縁1CD.色 = 配色.縁色;
			this.ブ\u30FCツ1_バンプ_縁_縁2CD.色 = this.ブ\u30FCツ1_バンプ_縁_縁1CD.色;
			this.ブ\u30FCツ1_バンプ_縁_縁3CD.色 = this.ブ\u30FCツ1_バンプ_縁_縁1CD.色;
			this.ブ\u30FCツ1_バンプ_縁_縁4CD.色 = this.ブ\u30FCツ1_バンプ_縁_縁1CD.色;
			this.ブ\u30FCツ1_柄CD.色 = 配色.柄色;
			this.ブ\u30FCツ1_紐_紐1_紐下_金具上_金具CD.色 = 配色.金具色;
			this.ブ\u30FCツ1_紐_紐1_紐下_金具上_穴CD.色 = 配色.穴色;
			this.ブ\u30FCツ1_紐_紐1_紐下_紐CD.色 = 配色.紐色;
			this.ブ\u30FCツ1_紐_紐1_紐上_金具上_金具CD.色 = this.ブ\u30FCツ1_紐_紐1_紐下_金具上_金具CD.色;
			this.ブ\u30FCツ1_紐_紐1_紐上_金具上_穴CD.色 = this.ブ\u30FCツ1_紐_紐1_紐下_金具上_穴CD.色;
			this.ブ\u30FCツ1_紐_紐1_紐上_紐CD.色 = this.ブ\u30FCツ1_紐_紐1_紐下_紐CD.色;
			this.ブ\u30FCツ1_紐_紐2_紐下_金具上_金具CD.色 = this.ブ\u30FCツ1_紐_紐1_紐下_金具上_金具CD.色;
			this.ブ\u30FCツ1_紐_紐2_紐下_金具上_穴CD.色 = this.ブ\u30FCツ1_紐_紐1_紐下_金具上_穴CD.色;
			this.ブ\u30FCツ1_紐_紐2_紐下_紐CD.色 = this.ブ\u30FCツ1_紐_紐1_紐下_紐CD.色;
			this.ブ\u30FCツ1_紐_紐2_紐上_金具上_金具CD.色 = this.ブ\u30FCツ1_紐_紐1_紐下_金具上_金具CD.色;
			this.ブ\u30FCツ1_紐_紐2_紐上_金具上_穴CD.色 = this.ブ\u30FCツ1_紐_紐1_紐下_金具上_穴CD.色;
			this.ブ\u30FCツ1_紐_紐2_紐上_紐CD.色 = this.ブ\u30FCツ1_紐_紐1_紐下_紐CD.色;
			this.ブ\u30FCツ1_紐_紐3_紐下_金具上_金具CD.色 = this.ブ\u30FCツ1_紐_紐1_紐下_金具上_金具CD.色;
			this.ブ\u30FCツ1_紐_紐3_紐下_金具上_穴CD.色 = this.ブ\u30FCツ1_紐_紐1_紐下_金具上_穴CD.色;
			this.ブ\u30FCツ1_紐_紐3_紐下_紐CD.色 = this.ブ\u30FCツ1_紐_紐1_紐下_紐CD.色;
			this.ブ\u30FCツ1_紐_紐3_紐上_金具上_金具CD.色 = this.ブ\u30FCツ1_紐_紐1_紐下_金具上_金具CD.色;
			this.ブ\u30FCツ1_紐_紐3_紐上_金具上_穴CD.色 = this.ブ\u30FCツ1_紐_紐1_紐下_金具上_穴CD.色;
			this.ブ\u30FCツ1_紐_紐3_紐上_紐CD.色 = this.ブ\u30FCツ1_紐_紐1_紐下_紐CD.色;
			this.ブ\u30FCツ1_紐_紐4_紐下_金具上_金具CD.色 = this.ブ\u30FCツ1_紐_紐1_紐下_金具上_金具CD.色;
			this.ブ\u30FCツ1_紐_紐4_紐下_金具上_穴CD.色 = this.ブ\u30FCツ1_紐_紐1_紐下_金具上_穴CD.色;
			this.ブ\u30FCツ1_紐_紐4_紐下_紐CD.色 = this.ブ\u30FCツ1_紐_紐1_紐下_紐CD.色;
			this.ブ\u30FCツ1_紐_紐4_紐上_金具上_金具CD.色 = this.ブ\u30FCツ1_紐_紐1_紐下_金具上_金具CD.色;
			this.ブ\u30FCツ1_紐_紐4_紐上_金具上_穴CD.色 = this.ブ\u30FCツ1_紐_紐1_紐下_金具上_穴CD.色;
			this.ブ\u30FCツ1_紐_紐4_紐上_紐CD.色 = this.ブ\u30FCツ1_紐_紐1_紐下_紐CD.色;
			this.ブ\u30FCツ1_紐_紐5_金具1_金具CD.色 = this.ブ\u30FCツ1_紐_紐1_紐下_金具上_金具CD.色;
			this.ブ\u30FCツ1_紐_紐5_金具1_穴CD.色 = this.ブ\u30FCツ1_紐_紐1_紐下_金具上_穴CD.色;
			this.ブ\u30FCツ1_紐_紐5_金具2_金具CD.色 = this.ブ\u30FCツ1_紐_紐1_紐下_金具上_金具CD.色;
			this.ブ\u30FCツ1_紐_紐5_金具2_穴CD.色 = this.ブ\u30FCツ1_紐_紐1_紐下_金具上_穴CD.色;
			this.ブ\u30FCツ1_紐_紐5_紐CD.色 = this.ブ\u30FCツ1_紐_紐1_紐下_紐CD.色;
		}

		public Par X0Y0_ヒ\u30FCル0_靴底;

		public Par X0Y0_サンダル0_靴底;

		public Par X0Y0_ナ\u30FCス0_靴底;

		public Par X0Y0_ブ\u30FCツ0_靴底;

		public Par X0Y0_ア\u30FCマ0_靴底;

		public Par X0Y0_足;

		public Par X0Y0_小指_小指1;

		public Par X0Y0_小指_小指2;

		public Par X0Y0_小指_小指3;

		public Par X0Y0_薬指_水掻;

		public Par X0Y0_薬指_薬指1;

		public Par X0Y0_薬指_薬指2;

		public Par X0Y0_薬指_薬指3;

		public Par X0Y0_中指_水掻;

		public Par X0Y0_中指_中指1;

		public Par X0Y0_中指_中指2;

		public Par X0Y0_中指_中指3;

		public Par X0Y0_人指_人指1;

		public Par X0Y0_人指_人指2;

		public Par X0Y0_人指_人指3;

		public Par X0Y0_人指_水掻;

		public Par X0Y0_親指_親指2;

		public Par X0Y0_親指_親指3;

		public Par X0Y0_親指_水掻;

		public Par X0Y0_悪タトゥ_五芒星_円1;

		public Par X0Y0_悪タトゥ_五芒星_円2;

		public Par X0Y0_悪タトゥ_五芒星_星;

		public Par X0Y0_悪タトゥ_五芒星_五角形;

		public Par X0Y0_竜性_鱗1;

		public Par X0Y0_竜性_鱗2;

		public Par X0Y0_竜性_鱗3;

		public Par X0Y0_竜性_鱗4;

		public Par X0Y0_竜性_鱗5;

		public Par X0Y0_パンスト_パンスト1;

		public Par X0Y0_パンスト_パンスト2;

		public Par X0Y0_ソックス_ソックス1;

		public Par X0Y0_ソックス_ソックス2;

		public Par X0Y0_ヒ\u30FCル1_バンプ;

		public Par X0Y0_ヒ\u30FCル1_ストラップ_ストラップ;

		public Par X0Y0_ヒ\u30FCル1_ストラップ_金具1_金具1;

		public Par X0Y0_ヒ\u30FCル1_ストラップ_金具1_金具2;

		public Par X0Y0_ヒ\u30FCル1_ストラップ_金具1_金具3;

		public Par X0Y0_ヒ\u30FCル1_ストラップ_金具1_金具4;

		public Par X0Y0_ヒ\u30FCル1_ストラップ_金具2_金具1;

		public Par X0Y0_ヒ\u30FCル1_ストラップ_金具2_金具2;

		public Par X0Y0_ヒ\u30FCル1_ストラップ_金具2_金具3;

		public Par X0Y0_ヒ\u30FCル1_ストラップ_金具2_金具4;

		public Par X0Y0_ヒ\u30FCル1_ハイライト;

		public Par X0Y0_サンダル1_ストラップ3;

		public Par X0Y0_サンダル1_ストラップ2;

		public Par X0Y0_サンダル1_ストラップ4;

		public Par X0Y0_サンダル1_ストラップ1;

		public Par X0Y0_ナ\u30FCス1_ストラップ3_ストラップ;

		public Par X0Y0_ナ\u30FCス1_ストラップ3_縁1;

		public Par X0Y0_ナ\u30FCス1_ストラップ3_縁2;

		public Par X0Y0_ナ\u30FCス1_ストラップ2_ストラップ;

		public Par X0Y0_ナ\u30FCス1_ストラップ2_縁1;

		public Par X0Y0_ナ\u30FCス1_ストラップ2_縁2;

		public Par X0Y0_ナ\u30FCス1_ストラップ1_ストラップ;

		public Par X0Y0_ナ\u30FCス1_ストラップ1_縁1;

		public Par X0Y0_ナ\u30FCス1_ストラップ1_縁2;

		public Par X0Y0_ブ\u30FCツ1_タン;

		public Par X0Y0_ブ\u30FCツ1_バンプ_バンプ;

		public Par X0Y0_ブ\u30FCツ1_バンプ_縁_縁1;

		public Par X0Y0_ブ\u30FCツ1_バンプ_縁_縁2;

		public Par X0Y0_ブ\u30FCツ1_バンプ_縁_縁3;

		public Par X0Y0_ブ\u30FCツ1_バンプ_縁_縁4;

		public Par X0Y0_ブ\u30FCツ1_ハイライト;

		public Par X0Y0_ブ\u30FCツ1_柄;

		public Par X0Y0_ブ\u30FCツ1_紐_紐1_紐下_金具上_金具;

		public Par X0Y0_ブ\u30FCツ1_紐_紐1_紐下_金具上_穴;

		public Par X0Y0_ブ\u30FCツ1_紐_紐1_紐下_紐;

		public Par X0Y0_ブ\u30FCツ1_紐_紐1_紐上_金具上_金具;

		public Par X0Y0_ブ\u30FCツ1_紐_紐1_紐上_金具上_穴;

		public Par X0Y0_ブ\u30FCツ1_紐_紐1_紐上_紐;

		public Par X0Y0_ブ\u30FCツ1_紐_紐2_紐下_金具上_金具;

		public Par X0Y0_ブ\u30FCツ1_紐_紐2_紐下_金具上_穴;

		public Par X0Y0_ブ\u30FCツ1_紐_紐2_紐下_紐;

		public Par X0Y0_ブ\u30FCツ1_紐_紐2_紐上_金具上_金具;

		public Par X0Y0_ブ\u30FCツ1_紐_紐2_紐上_金具上_穴;

		public Par X0Y0_ブ\u30FCツ1_紐_紐2_紐上_紐;

		public Par X0Y0_ブ\u30FCツ1_紐_紐3_紐下_金具上_金具;

		public Par X0Y0_ブ\u30FCツ1_紐_紐3_紐下_金具上_穴;

		public Par X0Y0_ブ\u30FCツ1_紐_紐3_紐下_紐;

		public Par X0Y0_ブ\u30FCツ1_紐_紐3_紐上_金具上_金具;

		public Par X0Y0_ブ\u30FCツ1_紐_紐3_紐上_金具上_穴;

		public Par X0Y0_ブ\u30FCツ1_紐_紐3_紐上_紐;

		public Par X0Y0_ブ\u30FCツ1_紐_紐4_紐下_金具上_金具;

		public Par X0Y0_ブ\u30FCツ1_紐_紐4_紐下_金具上_穴;

		public Par X0Y0_ブ\u30FCツ1_紐_紐4_紐下_紐;

		public Par X0Y0_ブ\u30FCツ1_紐_紐4_紐上_金具上_金具;

		public Par X0Y0_ブ\u30FCツ1_紐_紐4_紐上_金具上_穴;

		public Par X0Y0_ブ\u30FCツ1_紐_紐4_紐上_紐;

		public Par X0Y0_ブ\u30FCツ1_紐_紐5_金具1_金具;

		public Par X0Y0_ブ\u30FCツ1_紐_紐5_金具1_穴;

		public Par X0Y0_ブ\u30FCツ1_紐_紐5_金具2_金具;

		public Par X0Y0_ブ\u30FCツ1_紐_紐5_金具2_穴;

		public Par X0Y0_ブ\u30FCツ1_紐_紐5_紐;

		public Par X0Y0_ア\u30FCマ1_鉄靴1;

		public Par X0Y0_ア\u30FCマ1_鉄靴2;

		public Par X0Y0_ア\u30FCマ1_鉄靴3;

		public Par X0Y1_ヒ\u30FCル0_ヒ\u30FCル;

		public Par X0Y1_ヒ\u30FCル0_靴底;

		public Par X0Y1_サンダル0_踵;

		public Par X0Y1_サンダル0_靴底;

		public Par X0Y1_ナ\u30FCス0_踵;

		public Par X0Y1_ナ\u30FCス0_靴底;

		public Par X0Y1_ブ\u30FCツ0_ヒ\u30FCル;

		public Par X0Y1_ブ\u30FCツ0_靴底;

		public Par X0Y1_ア\u30FCマ0_踵;

		public Par X0Y1_ア\u30FCマ0_靴底;

		public Par X0Y1_足;

		public Par X0Y1_小指_小指1;

		public Par X0Y1_小指_小指2;

		public Par X0Y1_小指_小指3;

		public Par X0Y1_薬指_水掻;

		public Par X0Y1_薬指_薬指1;

		public Par X0Y1_薬指_薬指2;

		public Par X0Y1_薬指_薬指3;

		public Par X0Y1_中指_水掻;

		public Par X0Y1_中指_中指1;

		public Par X0Y1_中指_中指2;

		public Par X0Y1_中指_中指3;

		public Par X0Y1_人指_水掻;

		public Par X0Y1_人指_人指1;

		public Par X0Y1_人指_人指2;

		public Par X0Y1_人指_人指3;

		public Par X0Y1_親指_水掻;

		public Par X0Y1_親指_親指2;

		public Par X0Y1_親指_親指3;

		public Par X0Y1_悪タトゥ_五芒星_円1;

		public Par X0Y1_悪タトゥ_五芒星_円2;

		public Par X0Y1_悪タトゥ_五芒星_星;

		public Par X0Y1_悪タトゥ_五芒星_五角形;

		public Par X0Y1_竜性_鱗1;

		public Par X0Y1_竜性_鱗2;

		public Par X0Y1_竜性_鱗3;

		public Par X0Y1_竜性_鱗4;

		public Par X0Y1_竜性_鱗5;

		public Par X0Y1_パンスト_パンスト1;

		public Par X0Y1_パンスト_パンスト2;

		public Par X0Y1_ソックス_ソックス1;

		public Par X0Y1_ソックス_ソックス2;

		public Par X0Y1_ヒ\u30FCル1_バンプ;

		public Par X0Y1_ヒ\u30FCル1_ストラップ_ストラップ;

		public Par X0Y1_ヒ\u30FCル1_ストラップ_金具1_金具1;

		public Par X0Y1_ヒ\u30FCル1_ストラップ_金具1_金具2;

		public Par X0Y1_ヒ\u30FCル1_ストラップ_金具1_金具3;

		public Par X0Y1_ヒ\u30FCル1_ストラップ_金具1_金具4;

		public Par X0Y1_ヒ\u30FCル1_ストラップ_金具2_金具1;

		public Par X0Y1_ヒ\u30FCル1_ストラップ_金具2_金具2;

		public Par X0Y1_ヒ\u30FCル1_ストラップ_金具2_金具3;

		public Par X0Y1_ヒ\u30FCル1_ストラップ_金具2_金具4;

		public Par X0Y1_ヒ\u30FCル1_ハイライト;

		public Par X0Y1_サンダル1_ストラップ3;

		public Par X0Y1_サンダル1_ストラップ2;

		public Par X0Y1_サンダル1_ストラップ4;

		public Par X0Y1_サンダル1_ストラップ1;

		public Par X0Y1_ナ\u30FCス1_ストラップ4_ストラップ;

		public Par X0Y1_ナ\u30FCス1_ストラップ4_縁1;

		public Par X0Y1_ナ\u30FCス1_ストラップ4_縁2;

		public Par X0Y1_ナ\u30FCス1_ストラップ3_ストラップ;

		public Par X0Y1_ナ\u30FCス1_ストラップ3_縁1;

		public Par X0Y1_ナ\u30FCス1_ストラップ3_縁2;

		public Par X0Y1_ナ\u30FCス1_ストラップ2_ストラップ;

		public Par X0Y1_ナ\u30FCス1_ストラップ2_縁1;

		public Par X0Y1_ナ\u30FCス1_ストラップ2_縁2;

		public Par X0Y1_ナ\u30FCス1_ストラップ1_ストラップ;

		public Par X0Y1_ナ\u30FCス1_ストラップ1_縁1;

		public Par X0Y1_ナ\u30FCス1_ストラップ1_縁2;

		public Par X0Y1_ブ\u30FCツ1_タン;

		public Par X0Y1_ブ\u30FCツ1_バンプ_バンプ;

		public Par X0Y1_ブ\u30FCツ1_バンプ_縁_縁1;

		public Par X0Y1_ブ\u30FCツ1_バンプ_縁_縁2;

		public Par X0Y1_ブ\u30FCツ1_バンプ_縁_縁3;

		public Par X0Y1_ブ\u30FCツ1_バンプ_縁_縁4;

		public Par X0Y1_ブ\u30FCツ1_ハイライト;

		public Par X0Y1_ブ\u30FCツ1_柄;

		public Par X0Y1_ブ\u30FCツ1_紐_紐1_紐下_金具上_金具;

		public Par X0Y1_ブ\u30FCツ1_紐_紐1_紐下_金具上_穴;

		public Par X0Y1_ブ\u30FCツ1_紐_紐1_紐下_紐;

		public Par X0Y1_ブ\u30FCツ1_紐_紐1_紐上_金具上_金具;

		public Par X0Y1_ブ\u30FCツ1_紐_紐1_紐上_金具上_穴;

		public Par X0Y1_ブ\u30FCツ1_紐_紐1_紐上_紐;

		public Par X0Y1_ブ\u30FCツ1_紐_紐2_紐下_金具上_金具;

		public Par X0Y1_ブ\u30FCツ1_紐_紐2_紐下_金具上_穴;

		public Par X0Y1_ブ\u30FCツ1_紐_紐2_紐下_紐;

		public Par X0Y1_ブ\u30FCツ1_紐_紐2_紐上_金具上_金具;

		public Par X0Y1_ブ\u30FCツ1_紐_紐2_紐上_金具上_穴;

		public Par X0Y1_ブ\u30FCツ1_紐_紐2_紐上_紐;

		public Par X0Y1_ブ\u30FCツ1_紐_紐3_紐下_金具上_金具;

		public Par X0Y1_ブ\u30FCツ1_紐_紐3_紐下_金具上_穴;

		public Par X0Y1_ブ\u30FCツ1_紐_紐3_紐下_紐;

		public Par X0Y1_ブ\u30FCツ1_紐_紐3_紐上_金具上_金具;

		public Par X0Y1_ブ\u30FCツ1_紐_紐3_紐上_金具上_穴;

		public Par X0Y1_ブ\u30FCツ1_紐_紐3_紐上_紐;

		public Par X0Y1_ブ\u30FCツ1_紐_紐4_紐下_金具上_金具;

		public Par X0Y1_ブ\u30FCツ1_紐_紐4_紐下_金具上_穴;

		public Par X0Y1_ブ\u30FCツ1_紐_紐4_紐下_紐;

		public Par X0Y1_ブ\u30FCツ1_紐_紐4_紐上_金具上_金具;

		public Par X0Y1_ブ\u30FCツ1_紐_紐4_紐上_金具上_穴;

		public Par X0Y1_ブ\u30FCツ1_紐_紐4_紐上_紐;

		public Par X0Y1_ブ\u30FCツ1_紐_紐5_金具1_金具;

		public Par X0Y1_ブ\u30FCツ1_紐_紐5_金具1_穴;

		public Par X0Y1_ブ\u30FCツ1_紐_紐5_金具2_金具;

		public Par X0Y1_ブ\u30FCツ1_紐_紐5_金具2_穴;

		public Par X0Y1_ブ\u30FCツ1_紐_紐5_紐;

		public Par X0Y1_ア\u30FCマ1_鉄靴1;

		public Par X0Y1_ア\u30FCマ1_鉄靴2;

		public Par X0Y1_ア\u30FCマ1_鉄靴3;

		public ColorD ヒ\u30FCル0_ヒ\u30FCルCD;

		public ColorD ヒ\u30FCル0_靴底CD;

		public ColorD サンダル0_踵CD;

		public ColorD サンダル0_靴底CD;

		public ColorD ナ\u30FCス0_踵CD;

		public ColorD ナ\u30FCス0_靴底CD;

		public ColorD ブ\u30FCツ0_ヒ\u30FCルCD;

		public ColorD ブ\u30FCツ0_靴底CD;

		public ColorD ア\u30FCマ0_踵CD;

		public ColorD ア\u30FCマ0_靴底CD;

		public ColorD 足CD;

		public ColorD 小指_小指1CD;

		public ColorD 小指_小指2CD;

		public ColorD 小指_小指3CD;

		public ColorD 薬指_水掻CD;

		public ColorD 薬指_薬指1CD;

		public ColorD 薬指_薬指2CD;

		public ColorD 薬指_薬指3CD;

		public ColorD 中指_水掻CD;

		public ColorD 中指_中指1CD;

		public ColorD 中指_中指2CD;

		public ColorD 中指_中指3CD;

		public ColorD 人指_人指1CD;

		public ColorD 人指_人指2CD;

		public ColorD 人指_人指3CD;

		public ColorD 人指_水掻CD;

		public ColorD 親指_親指2CD;

		public ColorD 親指_親指3CD;

		public ColorD 親指_水掻CD;

		public ColorD 悪タトゥ_五芒星_円1CD;

		public ColorD 悪タトゥ_五芒星_円2CD;

		public ColorD 悪タトゥ_五芒星_星CD;

		public ColorD 悪タトゥ_五芒星_五角形CD;

		public ColorD 竜性_鱗1CD;

		public ColorD 竜性_鱗2CD;

		public ColorD 竜性_鱗3CD;

		public ColorD 竜性_鱗4CD;

		public ColorD 竜性_鱗5CD;

		public ColorD パンスト_パンスト1CD;

		public ColorD パンスト_パンスト2CD;

		public ColorD ソックス_ソックス1CD;

		public ColorD ソックス_ソックス2CD;

		public ColorD ヒ\u30FCル1_バンプCD;

		public ColorD ヒ\u30FCル1_ストラップ_ストラップCD;

		public ColorD ヒ\u30FCル1_ストラップ_金具1_金具1CD;

		public ColorD ヒ\u30FCル1_ストラップ_金具1_金具2CD;

		public ColorD ヒ\u30FCル1_ストラップ_金具1_金具3CD;

		public ColorD ヒ\u30FCル1_ストラップ_金具1_金具4CD;

		public ColorD ヒ\u30FCル1_ストラップ_金具2_金具1CD;

		public ColorD ヒ\u30FCル1_ストラップ_金具2_金具2CD;

		public ColorD ヒ\u30FCル1_ストラップ_金具2_金具3CD;

		public ColorD ヒ\u30FCル1_ストラップ_金具2_金具4CD;

		public ColorD ヒ\u30FCル1_ハイライトCD;

		public ColorD サンダル1_ストラップ3CD;

		public ColorD サンダル1_ストラップ2CD;

		public ColorD サンダル1_ストラップ4CD;

		public ColorD サンダル1_ストラップ1CD;

		public ColorD ナ\u30FCス1_ストラップ3_ストラップCD;

		public ColorD ナ\u30FCス1_ストラップ3_縁1CD;

		public ColorD ナ\u30FCス1_ストラップ3_縁2CD;

		public ColorD ナ\u30FCス1_ストラップ2_ストラップCD;

		public ColorD ナ\u30FCス1_ストラップ2_縁1CD;

		public ColorD ナ\u30FCス1_ストラップ2_縁2CD;

		public ColorD ナ\u30FCス1_ストラップ1_ストラップCD;

		public ColorD ナ\u30FCス1_ストラップ1_縁1CD;

		public ColorD ナ\u30FCス1_ストラップ1_縁2CD;

		public ColorD ブ\u30FCツ1_タンCD;

		public ColorD ブ\u30FCツ1_バンプ_バンプCD;

		public ColorD ブ\u30FCツ1_バンプ_縁_縁1CD;

		public ColorD ブ\u30FCツ1_バンプ_縁_縁2CD;

		public ColorD ブ\u30FCツ1_バンプ_縁_縁3CD;

		public ColorD ブ\u30FCツ1_バンプ_縁_縁4CD;

		public ColorD ブ\u30FCツ1_ハイライトCD;

		public ColorD ブ\u30FCツ1_柄CD;

		public ColorD ブ\u30FCツ1_紐_紐1_紐下_金具上_金具CD;

		public ColorD ブ\u30FCツ1_紐_紐1_紐下_金具上_穴CD;

		public ColorD ブ\u30FCツ1_紐_紐1_紐下_紐CD;

		public ColorD ブ\u30FCツ1_紐_紐1_紐上_金具上_金具CD;

		public ColorD ブ\u30FCツ1_紐_紐1_紐上_金具上_穴CD;

		public ColorD ブ\u30FCツ1_紐_紐1_紐上_紐CD;

		public ColorD ブ\u30FCツ1_紐_紐2_紐下_金具上_金具CD;

		public ColorD ブ\u30FCツ1_紐_紐2_紐下_金具上_穴CD;

		public ColorD ブ\u30FCツ1_紐_紐2_紐下_紐CD;

		public ColorD ブ\u30FCツ1_紐_紐2_紐上_金具上_金具CD;

		public ColorD ブ\u30FCツ1_紐_紐2_紐上_金具上_穴CD;

		public ColorD ブ\u30FCツ1_紐_紐2_紐上_紐CD;

		public ColorD ブ\u30FCツ1_紐_紐3_紐下_金具上_金具CD;

		public ColorD ブ\u30FCツ1_紐_紐3_紐下_金具上_穴CD;

		public ColorD ブ\u30FCツ1_紐_紐3_紐下_紐CD;

		public ColorD ブ\u30FCツ1_紐_紐3_紐上_金具上_金具CD;

		public ColorD ブ\u30FCツ1_紐_紐3_紐上_金具上_穴CD;

		public ColorD ブ\u30FCツ1_紐_紐3_紐上_紐CD;

		public ColorD ブ\u30FCツ1_紐_紐4_紐下_金具上_金具CD;

		public ColorD ブ\u30FCツ1_紐_紐4_紐下_金具上_穴CD;

		public ColorD ブ\u30FCツ1_紐_紐4_紐下_紐CD;

		public ColorD ブ\u30FCツ1_紐_紐4_紐上_金具上_金具CD;

		public ColorD ブ\u30FCツ1_紐_紐4_紐上_金具上_穴CD;

		public ColorD ブ\u30FCツ1_紐_紐4_紐上_紐CD;

		public ColorD ブ\u30FCツ1_紐_紐5_金具1_金具CD;

		public ColorD ブ\u30FCツ1_紐_紐5_金具1_穴CD;

		public ColorD ブ\u30FCツ1_紐_紐5_金具2_金具CD;

		public ColorD ブ\u30FCツ1_紐_紐5_金具2_穴CD;

		public ColorD ブ\u30FCツ1_紐_紐5_紐CD;

		public ColorD ア\u30FCマ1_鉄靴1CD;

		public ColorD ア\u30FCマ1_鉄靴2CD;

		public ColorD ア\u30FCマ1_鉄靴3CD;

		public ColorD ナ\u30FCス1_ストラップ4_ストラップCD;

		public ColorD ナ\u30FCス1_ストラップ4_縁1CD;

		public ColorD ナ\u30FCス1_ストラップ4_縁2CD;

		public ColorP X0Y0_ヒ\u30FCル0_靴底CP;

		public ColorP X0Y0_サンダル0_靴底CP;

		public ColorP X0Y0_ナ\u30FCス0_靴底CP;

		public ColorP X0Y0_ブ\u30FCツ0_靴底CP;

		public ColorP X0Y0_ア\u30FCマ0_靴底CP;

		public ColorP X0Y0_足CP;

		public ColorP X0Y0_小指_小指1CP;

		public ColorP X0Y0_小指_小指2CP;

		public ColorP X0Y0_小指_小指3CP;

		public ColorP X0Y0_薬指_水掻CP;

		public ColorP X0Y0_薬指_薬指1CP;

		public ColorP X0Y0_薬指_薬指2CP;

		public ColorP X0Y0_薬指_薬指3CP;

		public ColorP X0Y0_中指_水掻CP;

		public ColorP X0Y0_中指_中指1CP;

		public ColorP X0Y0_中指_中指2CP;

		public ColorP X0Y0_中指_中指3CP;

		public ColorP X0Y0_人指_人指1CP;

		public ColorP X0Y0_人指_人指2CP;

		public ColorP X0Y0_人指_人指3CP;

		public ColorP X0Y0_人指_水掻CP;

		public ColorP X0Y0_親指_親指2CP;

		public ColorP X0Y0_親指_親指3CP;

		public ColorP X0Y0_親指_水掻CP;

		public ColorP X0Y0_悪タトゥ_五芒星_円1CP;

		public ColorP X0Y0_悪タトゥ_五芒星_円2CP;

		public ColorP X0Y0_悪タトゥ_五芒星_星CP;

		public ColorP X0Y0_悪タトゥ_五芒星_五角形CP;

		public ColorP X0Y0_竜性_鱗1CP;

		public ColorP X0Y0_竜性_鱗2CP;

		public ColorP X0Y0_竜性_鱗3CP;

		public ColorP X0Y0_竜性_鱗4CP;

		public ColorP X0Y0_竜性_鱗5CP;

		public ColorP X0Y0_パンスト_パンスト1CP;

		public ColorP X0Y0_パンスト_パンスト2CP;

		public ColorP X0Y0_ソックス_ソックス1CP;

		public ColorP X0Y0_ソックス_ソックス2CP;

		public ColorP X0Y0_ヒ\u30FCル1_バンプCP;

		public ColorP X0Y0_ヒ\u30FCル1_ストラップ_ストラップCP;

		public ColorP X0Y0_ヒ\u30FCル1_ストラップ_金具1_金具1CP;

		public ColorP X0Y0_ヒ\u30FCル1_ストラップ_金具1_金具2CP;

		public ColorP X0Y0_ヒ\u30FCル1_ストラップ_金具1_金具3CP;

		public ColorP X0Y0_ヒ\u30FCル1_ストラップ_金具1_金具4CP;

		public ColorP X0Y0_ヒ\u30FCル1_ストラップ_金具2_金具1CP;

		public ColorP X0Y0_ヒ\u30FCル1_ストラップ_金具2_金具2CP;

		public ColorP X0Y0_ヒ\u30FCル1_ストラップ_金具2_金具3CP;

		public ColorP X0Y0_ヒ\u30FCル1_ストラップ_金具2_金具4CP;

		public ColorP X0Y0_ヒ\u30FCル1_ハイライトCP;

		public ColorP X0Y0_サンダル1_ストラップ3CP;

		public ColorP X0Y0_サンダル1_ストラップ2CP;

		public ColorP X0Y0_サンダル1_ストラップ4CP;

		public ColorP X0Y0_サンダル1_ストラップ1CP;

		public ColorP X0Y0_ナ\u30FCス1_ストラップ3_ストラップCP;

		public ColorP X0Y0_ナ\u30FCス1_ストラップ3_縁1CP;

		public ColorP X0Y0_ナ\u30FCス1_ストラップ3_縁2CP;

		public ColorP X0Y0_ナ\u30FCス1_ストラップ2_ストラップCP;

		public ColorP X0Y0_ナ\u30FCス1_ストラップ2_縁1CP;

		public ColorP X0Y0_ナ\u30FCス1_ストラップ2_縁2CP;

		public ColorP X0Y0_ナ\u30FCス1_ストラップ1_ストラップCP;

		public ColorP X0Y0_ナ\u30FCス1_ストラップ1_縁1CP;

		public ColorP X0Y0_ナ\u30FCス1_ストラップ1_縁2CP;

		public ColorP X0Y0_ブ\u30FCツ1_タンCP;

		public ColorP X0Y0_ブ\u30FCツ1_バンプ_バンプCP;

		public ColorP X0Y0_ブ\u30FCツ1_バンプ_縁_縁1CP;

		public ColorP X0Y0_ブ\u30FCツ1_バンプ_縁_縁2CP;

		public ColorP X0Y0_ブ\u30FCツ1_バンプ_縁_縁3CP;

		public ColorP X0Y0_ブ\u30FCツ1_バンプ_縁_縁4CP;

		public ColorP X0Y0_ブ\u30FCツ1_ハイライトCP;

		public ColorP X0Y0_ブ\u30FCツ1_柄CP;

		public ColorP X0Y0_ブ\u30FCツ1_紐_紐1_紐下_金具上_金具CP;

		public ColorP X0Y0_ブ\u30FCツ1_紐_紐1_紐下_金具上_穴CP;

		public ColorP X0Y0_ブ\u30FCツ1_紐_紐1_紐下_紐CP;

		public ColorP X0Y0_ブ\u30FCツ1_紐_紐1_紐上_金具上_金具CP;

		public ColorP X0Y0_ブ\u30FCツ1_紐_紐1_紐上_金具上_穴CP;

		public ColorP X0Y0_ブ\u30FCツ1_紐_紐1_紐上_紐CP;

		public ColorP X0Y0_ブ\u30FCツ1_紐_紐2_紐下_金具上_金具CP;

		public ColorP X0Y0_ブ\u30FCツ1_紐_紐2_紐下_金具上_穴CP;

		public ColorP X0Y0_ブ\u30FCツ1_紐_紐2_紐下_紐CP;

		public ColorP X0Y0_ブ\u30FCツ1_紐_紐2_紐上_金具上_金具CP;

		public ColorP X0Y0_ブ\u30FCツ1_紐_紐2_紐上_金具上_穴CP;

		public ColorP X0Y0_ブ\u30FCツ1_紐_紐2_紐上_紐CP;

		public ColorP X0Y0_ブ\u30FCツ1_紐_紐3_紐下_金具上_金具CP;

		public ColorP X0Y0_ブ\u30FCツ1_紐_紐3_紐下_金具上_穴CP;

		public ColorP X0Y0_ブ\u30FCツ1_紐_紐3_紐下_紐CP;

		public ColorP X0Y0_ブ\u30FCツ1_紐_紐3_紐上_金具上_金具CP;

		public ColorP X0Y0_ブ\u30FCツ1_紐_紐3_紐上_金具上_穴CP;

		public ColorP X0Y0_ブ\u30FCツ1_紐_紐3_紐上_紐CP;

		public ColorP X0Y0_ブ\u30FCツ1_紐_紐4_紐下_金具上_金具CP;

		public ColorP X0Y0_ブ\u30FCツ1_紐_紐4_紐下_金具上_穴CP;

		public ColorP X0Y0_ブ\u30FCツ1_紐_紐4_紐下_紐CP;

		public ColorP X0Y0_ブ\u30FCツ1_紐_紐4_紐上_金具上_金具CP;

		public ColorP X0Y0_ブ\u30FCツ1_紐_紐4_紐上_金具上_穴CP;

		public ColorP X0Y0_ブ\u30FCツ1_紐_紐4_紐上_紐CP;

		public ColorP X0Y0_ブ\u30FCツ1_紐_紐5_金具1_金具CP;

		public ColorP X0Y0_ブ\u30FCツ1_紐_紐5_金具1_穴CP;

		public ColorP X0Y0_ブ\u30FCツ1_紐_紐5_金具2_金具CP;

		public ColorP X0Y0_ブ\u30FCツ1_紐_紐5_金具2_穴CP;

		public ColorP X0Y0_ブ\u30FCツ1_紐_紐5_紐CP;

		public ColorP X0Y0_ア\u30FCマ1_鉄靴1CP;

		public ColorP X0Y0_ア\u30FCマ1_鉄靴2CP;

		public ColorP X0Y0_ア\u30FCマ1_鉄靴3CP;

		public ColorP X0Y1_ヒ\u30FCル0_ヒ\u30FCルCP;

		public ColorP X0Y1_ヒ\u30FCル0_靴底CP;

		public ColorP X0Y1_サンダル0_踵CP;

		public ColorP X0Y1_サンダル0_靴底CP;

		public ColorP X0Y1_ナ\u30FCス0_踵CP;

		public ColorP X0Y1_ナ\u30FCス0_靴底CP;

		public ColorP X0Y1_ブ\u30FCツ0_ヒ\u30FCルCP;

		public ColorP X0Y1_ブ\u30FCツ0_靴底CP;

		public ColorP X0Y1_ア\u30FCマ0_踵CP;

		public ColorP X0Y1_ア\u30FCマ0_靴底CP;

		public ColorP X0Y1_足CP;

		public ColorP X0Y1_小指_小指1CP;

		public ColorP X0Y1_小指_小指2CP;

		public ColorP X0Y1_小指_小指3CP;

		public ColorP X0Y1_薬指_水掻CP;

		public ColorP X0Y1_薬指_薬指1CP;

		public ColorP X0Y1_薬指_薬指2CP;

		public ColorP X0Y1_薬指_薬指3CP;

		public ColorP X0Y1_中指_水掻CP;

		public ColorP X0Y1_中指_中指1CP;

		public ColorP X0Y1_中指_中指2CP;

		public ColorP X0Y1_中指_中指3CP;

		public ColorP X0Y1_人指_水掻CP;

		public ColorP X0Y1_人指_人指1CP;

		public ColorP X0Y1_人指_人指2CP;

		public ColorP X0Y1_人指_人指3CP;

		public ColorP X0Y1_親指_水掻CP;

		public ColorP X0Y1_親指_親指2CP;

		public ColorP X0Y1_親指_親指3CP;

		public ColorP X0Y1_悪タトゥ_五芒星_円1CP;

		public ColorP X0Y1_悪タトゥ_五芒星_円2CP;

		public ColorP X0Y1_悪タトゥ_五芒星_星CP;

		public ColorP X0Y1_悪タトゥ_五芒星_五角形CP;

		public ColorP X0Y1_竜性_鱗1CP;

		public ColorP X0Y1_竜性_鱗2CP;

		public ColorP X0Y1_竜性_鱗3CP;

		public ColorP X0Y1_竜性_鱗4CP;

		public ColorP X0Y1_竜性_鱗5CP;

		public ColorP X0Y1_パンスト_パンスト1CP;

		public ColorP X0Y1_パンスト_パンスト2CP;

		public ColorP X0Y1_ソックス_ソックス1CP;

		public ColorP X0Y1_ソックス_ソックス2CP;

		public ColorP X0Y1_ヒ\u30FCル1_バンプCP;

		public ColorP X0Y1_ヒ\u30FCル1_ストラップ_ストラップCP;

		public ColorP X0Y1_ヒ\u30FCル1_ストラップ_金具1_金具1CP;

		public ColorP X0Y1_ヒ\u30FCル1_ストラップ_金具1_金具2CP;

		public ColorP X0Y1_ヒ\u30FCル1_ストラップ_金具1_金具3CP;

		public ColorP X0Y1_ヒ\u30FCル1_ストラップ_金具1_金具4CP;

		public ColorP X0Y1_ヒ\u30FCル1_ストラップ_金具2_金具1CP;

		public ColorP X0Y1_ヒ\u30FCル1_ストラップ_金具2_金具2CP;

		public ColorP X0Y1_ヒ\u30FCル1_ストラップ_金具2_金具3CP;

		public ColorP X0Y1_ヒ\u30FCル1_ストラップ_金具2_金具4CP;

		public ColorP X0Y1_ヒ\u30FCル1_ハイライトCP;

		public ColorP X0Y1_サンダル1_ストラップ3CP;

		public ColorP X0Y1_サンダル1_ストラップ2CP;

		public ColorP X0Y1_サンダル1_ストラップ4CP;

		public ColorP X0Y1_サンダル1_ストラップ1CP;

		public ColorP X0Y1_ナ\u30FCス1_ストラップ4_ストラップCP;

		public ColorP X0Y1_ナ\u30FCス1_ストラップ4_縁1CP;

		public ColorP X0Y1_ナ\u30FCス1_ストラップ4_縁2CP;

		public ColorP X0Y1_ナ\u30FCス1_ストラップ3_ストラップCP;

		public ColorP X0Y1_ナ\u30FCス1_ストラップ3_縁1CP;

		public ColorP X0Y1_ナ\u30FCス1_ストラップ3_縁2CP;

		public ColorP X0Y1_ナ\u30FCス1_ストラップ2_ストラップCP;

		public ColorP X0Y1_ナ\u30FCス1_ストラップ2_縁1CP;

		public ColorP X0Y1_ナ\u30FCス1_ストラップ2_縁2CP;

		public ColorP X0Y1_ナ\u30FCス1_ストラップ1_ストラップCP;

		public ColorP X0Y1_ナ\u30FCス1_ストラップ1_縁1CP;

		public ColorP X0Y1_ナ\u30FCス1_ストラップ1_縁2CP;

		public ColorP X0Y1_ブ\u30FCツ1_タンCP;

		public ColorP X0Y1_ブ\u30FCツ1_バンプ_バンプCP;

		public ColorP X0Y1_ブ\u30FCツ1_バンプ_縁_縁1CP;

		public ColorP X0Y1_ブ\u30FCツ1_バンプ_縁_縁2CP;

		public ColorP X0Y1_ブ\u30FCツ1_バンプ_縁_縁3CP;

		public ColorP X0Y1_ブ\u30FCツ1_バンプ_縁_縁4CP;

		public ColorP X0Y1_ブ\u30FCツ1_ハイライトCP;

		public ColorP X0Y1_ブ\u30FCツ1_柄CP;

		public ColorP X0Y1_ブ\u30FCツ1_紐_紐1_紐下_金具上_金具CP;

		public ColorP X0Y1_ブ\u30FCツ1_紐_紐1_紐下_金具上_穴CP;

		public ColorP X0Y1_ブ\u30FCツ1_紐_紐1_紐下_紐CP;

		public ColorP X0Y1_ブ\u30FCツ1_紐_紐1_紐上_金具上_金具CP;

		public ColorP X0Y1_ブ\u30FCツ1_紐_紐1_紐上_金具上_穴CP;

		public ColorP X0Y1_ブ\u30FCツ1_紐_紐1_紐上_紐CP;

		public ColorP X0Y1_ブ\u30FCツ1_紐_紐2_紐下_金具上_金具CP;

		public ColorP X0Y1_ブ\u30FCツ1_紐_紐2_紐下_金具上_穴CP;

		public ColorP X0Y1_ブ\u30FCツ1_紐_紐2_紐下_紐CP;

		public ColorP X0Y1_ブ\u30FCツ1_紐_紐2_紐上_金具上_金具CP;

		public ColorP X0Y1_ブ\u30FCツ1_紐_紐2_紐上_金具上_穴CP;

		public ColorP X0Y1_ブ\u30FCツ1_紐_紐2_紐上_紐CP;

		public ColorP X0Y1_ブ\u30FCツ1_紐_紐3_紐下_金具上_金具CP;

		public ColorP X0Y1_ブ\u30FCツ1_紐_紐3_紐下_金具上_穴CP;

		public ColorP X0Y1_ブ\u30FCツ1_紐_紐3_紐下_紐CP;

		public ColorP X0Y1_ブ\u30FCツ1_紐_紐3_紐上_金具上_金具CP;

		public ColorP X0Y1_ブ\u30FCツ1_紐_紐3_紐上_金具上_穴CP;

		public ColorP X0Y1_ブ\u30FCツ1_紐_紐3_紐上_紐CP;

		public ColorP X0Y1_ブ\u30FCツ1_紐_紐4_紐下_金具上_金具CP;

		public ColorP X0Y1_ブ\u30FCツ1_紐_紐4_紐下_金具上_穴CP;

		public ColorP X0Y1_ブ\u30FCツ1_紐_紐4_紐下_紐CP;

		public ColorP X0Y1_ブ\u30FCツ1_紐_紐4_紐上_金具上_金具CP;

		public ColorP X0Y1_ブ\u30FCツ1_紐_紐4_紐上_金具上_穴CP;

		public ColorP X0Y1_ブ\u30FCツ1_紐_紐4_紐上_紐CP;

		public ColorP X0Y1_ブ\u30FCツ1_紐_紐5_金具1_金具CP;

		public ColorP X0Y1_ブ\u30FCツ1_紐_紐5_金具1_穴CP;

		public ColorP X0Y1_ブ\u30FCツ1_紐_紐5_金具2_金具CP;

		public ColorP X0Y1_ブ\u30FCツ1_紐_紐5_金具2_穴CP;

		public ColorP X0Y1_ブ\u30FCツ1_紐_紐5_紐CP;

		public ColorP X0Y1_ア\u30FCマ1_鉄靴1CP;

		public ColorP X0Y1_ア\u30FCマ1_鉄靴2CP;

		public ColorP X0Y1_ア\u30FCマ1_鉄靴3CP;

		public スタンプK キスマ\u30FCク;

		public スタンプW 鞭痕;
	}
}
