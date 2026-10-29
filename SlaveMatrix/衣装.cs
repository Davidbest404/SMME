using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public static class 衣装
	{
		public static bool Is下着ボトム条件(this ChaD c)
		{
			return !c.構成.半身_接続.IsEleD<長物_魚D>() && !c.構成.半身_接続.IsEleD<長物_鯨D>() && !c.構成.半身_接続.IsEleD<長物_蛇D>() && !c.構成.半身_接続.IsEleD<長物_蟲D>() && !c.構成.半身_接続.IsEleD<四足胸D>() && !c.構成.半身_接続.IsEleD<多足_蛸D>() && !c.構成.半身_接続.IsEleD<多足_蜘D>() && !c.構成.半身_接続.IsEleD<多足_蠍D>();
		}

		public static bool Is上着ボトム条件(this ChaD c)
		{
			return true;
		}

		public static bool Is紐付き条件(this ChaD c)
		{
			return c.構成.半身_接続.IsEleD<単足_植D>() || OthN.XS.NextBool();
		}

		public static bool Is前掛け条件(this ChaD c)
		{
			腿_人D eleD;
			return !c.構成.半身_接続.IsEleD<四足胸D>() && !c.構成.腿左_接続.IsEleD<獣腿D>() && (c.構成.半身_接続.IsEleD<長物_魚D>() || c.構成.半身_接続.IsEleD<長物_鯨D>() || c.構成.半身_接続.IsEleD<長物_蛇D>() || c.構成.半身_接続.IsEleD<長物_蟲D>() || c.構成.半身_接続.IsEleD<多足_蛸D>() || c.構成.半身_接続.IsEleD<多足_蜘D>() || c.構成.半身_接続.IsEleD<単足_粘D>() || c.構成.腿左_接続.IsEleD<尾_魚D>() || c.構成.腿左_接続.IsEleD<触手_犬D>() || ((eleD = c.構成.腿左_接続.GetEleD<腿_人D>()) != null && (eleD.植性_葉1_表示 || eleD.植性_葉2_表示 || eleD.植性_葉3_表示)) || OthN.XS.NextBool());
		}

		public static bool Isブ\u30FCツ条件(this ChaD c)
		{
			return c.構成.EnumEleD().IsEleD<脚_人D>();
		}

		public static IEnumerable<object> Get髪留め(ChaD c)
		{
			髪留2情報 @default = 髪留2情報.GetDefault();
			髪留2情報 横髪 = 髪留2情報.GetDefault();
			switch (OthN.XS.Next(3))
			{
			case 0:
				@default.髪留左.色.SetRandom();
				@default.髪留右.色.髪留1 = @default.髪留左.色.髪留1;
				@default.髪留右.色.髪留2 = @default.髪留左.色.髪留2;
				@default.髪留右.色.SetColor2();
				横髪.髪留左.色.髪留1 = @default.髪留左.色.髪留1;
				横髪.髪留左.色.髪留2 = @default.髪留左.色.髪留2;
				横髪.髪留左.色.SetColor2();
				横髪.髪留右.色.髪留1 = @default.髪留左.色.髪留1;
				横髪.髪留右.色.髪留2 = @default.髪留左.色.髪留2;
				横髪.髪留右.色.SetColor2();
				break;
			case 1:
				@default.髪留左.色.SetRandom();
				@default.髪留右.色.髪留1 = @default.髪留左.色.髪留1;
				@default.髪留右.色.髪留2 = @default.髪留左.色.髪留2;
				@default.髪留右.色.SetColor2();
				横髪.髪留左.色.SetRandom();
				横髪.髪留右.色.髪留1 = @default.髪留左.色.髪留1;
				横髪.髪留右.色.髪留2 = @default.髪留左.色.髪留2;
				横髪.髪留右.色.SetColor2();
				break;
			case 2:
				@default.髪留左.色.SetRandom();
				@default.髪留右.色.SetRandom();
				横髪.髪留左.色.SetRandom();
				横髪.髪留右.色.SetRandom();
				break;
			}
			yield return @default;
			yield return 横髪;
			yield break;
		}

		public static IEnumerable<object> Getビキニ(ChaD c, bool t)
		{
			Color c2;
			Col.GetRandomClothesColor(out c2);
			Color c3;
			Col.GetRandomClothesColor(out c3);
			Color c4;
			Col.GetRandomClothesColor(out c4);
			bool e = OthN.XS.NextBool();
			if (OthN.XS.NextBool())
			{
				if (t)
				{
					下着T_ビキニ情報 @default = 下着T_ビキニ情報.GetDefault();
					@default.縁 = e;
					@default.色.生地 = c2;
					@default.色.縁 = c3;
					@default.色.紐 = c4;
					@default.色.SetColor2();
					yield return @default;
				}
				if (c.Is下着ボトム条件())
				{
					下着B_ノ\u30FCマル情報 下着B_ノ_u30FCマル情報;
					if (c.Is紐付き条件())
					{
						下着B_ノ_u30FCマル情報 = 下着B_ノ\u30FCマル情報.Getビキニ紐付き();
					}
					else
					{
						下着B_ノ_u30FCマル情報 = 下着B_ノ\u30FCマル情報.Getビキニ();
					}
					下着B_ノ_u30FCマル情報.縁 = e;
					下着B_ノ_u30FCマル情報.色.生地 = c2;
					下着B_ノ_u30FCマル情報.色.縁 = c3;
					下着B_ノ_u30FCマル情報.色.紐 = c4;
					下着B_ノ_u30FCマル情報.色.SetColor2();
					yield return 下着B_ノ_u30FCマル情報;
				}
				else if (c.Is上着ボトム条件())
				{
					if (c.Is前掛け条件())
					{
						上着B_前掛け情報 default2 = 上着B_前掛け情報.GetDefault();
						default2.色.生地 = c2;
						default2.色.縁 = c3;
						default2.色.紐 = c4;
						default2.色.SetColor2();
						yield return default2;
					}
					else
					{
						上着B_クロス情報 default3 = 上着B_クロス情報.GetDefault();
						default3.中 = false;
						default3.色.生地1 = c2;
						default3.色.生地2 = c3;
						default3.色.SetColor2();
						yield return default3;
					}
				}
			}
			else
			{
				if (t)
				{
					下着T_マイクロ情報 default4 = 下着T_マイクロ情報.GetDefault();
					default4.縁 = e;
					default4.色.生地 = c2;
					default4.色.縁 = c3;
					default4.色.紐 = c4;
					default4.色.SetColor2();
					yield return default4;
				}
				if (c.Is下着ボトム条件())
				{
					下着B_マイクロ情報 下着B_マイクロ情報;
					if (c.Is紐付き条件())
					{
						下着B_マイクロ情報 = 下着B_マイクロ情報.Getマイクロ紐付き();
					}
					else
					{
						下着B_マイクロ情報 = 下着B_マイクロ情報.Getマイクロ();
					}
					下着B_マイクロ情報.縁 = e;
					下着B_マイクロ情報.色.生地 = c2;
					下着B_マイクロ情報.色.縁 = c3;
					下着B_マイクロ情報.色.紐 = c4;
					下着B_マイクロ情報.色.SetColor2();
					yield return 下着B_マイクロ情報;
				}
				else if (c.Is上着ボトム条件())
				{
					if (c.Is前掛け条件())
					{
						上着B_前掛け情報 default5 = 上着B_前掛け情報.GetDefault();
						default5.色.生地 = c2;
						default5.色.縁 = c3;
						default5.色.紐 = c4;
						default5.色.SetColor2();
						yield return default5;
					}
					else
					{
						上着B_クロス情報 default6 = 上着B_クロス情報.GetDefault();
						default6.中 = false;
						default6.色.生地1 = c2;
						default6.色.生地2 = c3;
						default6.色.SetColor2();
						yield return default6;
					}
				}
			}
			yield break;
		}

		public static IEnumerable<object> Getランジェリ\u30FC(ChaD c, bool t, bool a)
		{
			Color c2;
			Col.GetRandomClothesColor(a ? OthN.XS.Next(32, 256) : 255, out c2);
			Color c3;
			Col.GetRandomClothesColor(a ? OthN.XS.Next(32, 256) : 255, out c3);
			Color c4;
			Col.GetRandomClothesColor(a ? OthN.XS.Next(32, 256) : 255, out c4);
			Color c5;
			Col.GetRandomClothesColor(a ? OthN.XS.Next(32, 256) : 255, out c5);
			Color c6;
			Col.GetRandomClothesColor(a ? OthN.XS.Next(32, 256) : 255, out c6);
			Color c7;
			Col.GetRandomClothesColor(a ? OthN.XS.Next(32, 256) : 255, out c7);
			if (t)
			{
				下着T_ブラ情報 @default = 下着T_ブラ情報.GetDefault();
				@default.色.生地1 = c2;
				@default.色.生地2 = c3;
				@default.色.縁 = c4;
				@default.色.紐 = c5;
				@default.色.柄 = c6;
				@default.色.リボン = c7;
				@default.色.SetColor2();
				yield return @default;
			}
			if (c.Is下着ボトム条件())
			{
				下着B_ノ\u30FCマル情報 下着B_ノ_u30FCマル情報;
				if (c.Is紐付き条件())
				{
					下着B_ノ_u30FCマル情報 = 下着B_ノ\u30FCマル情報.Getランジェリ\u30FC紐付き();
				}
				else
				{
					下着B_ノ_u30FCマル情報 = 下着B_ノ\u30FCマル情報.Getランジェリ\u30FC();
				}
				下着B_ノ_u30FCマル情報.色.生地 = c2;
				下着B_ノ_u30FCマル情報.色.縁 = c4;
				下着B_ノ_u30FCマル情報.色.紐 = c5;
				下着B_ノ_u30FCマル情報.色.柄 = c6;
				下着B_ノ_u30FCマル情報.色.リボン = c7;
				下着B_ノ_u30FCマル情報.色.SetColor2();
				yield return 下着B_ノ_u30FCマル情報;
			}
			else if (c.Is上着ボトム条件())
			{
				if (c.Is前掛け条件())
				{
					上着B_前掛け情報 default2 = 上着B_前掛け情報.GetDefault();
					default2.色.生地 = c2;
					default2.色.縁 = c3;
					default2.色.紐 = c4;
					default2.色.SetColor2();
					yield return default2;
				}
				else
				{
					上着B_クロス情報 default3 = 上着B_クロス情報.GetDefault();
					default3.中 = false;
					default3.色.生地1 = c2;
					default3.色.生地2 = c3;
					default3.色.SetColor2();
					yield return default3;
				}
			}
			yield break;
		}

		public static IEnumerable<object> Getピアス(ChaD c)
		{
			ピアス情報 ピアス中 = ピアス情報.GetDefault();
			ピアス中.色.ピアス = (OthN.XS.NextBool() ? Color.Gold : Color.Silver);
			ピアス中.色.SetColor2();
			yield return ピアス中;
			ピアス情報 @default = ピアス情報.GetDefault();
			@default.色.ピアス = ピアス中.色.ピアス;
			@default.色.SetColor2();
			yield return @default;
			ピアス情報 default2 = ピアス情報.GetDefault();
			default2.色.ピアス = ピアス中.色.ピアス;
			default2.色.SetColor2();
			yield return default2;
			yield break;
		}

		public static IEnumerable<object> Getヴィオラ服0(ChaD c)
		{
			ドレス首情報 ドレス首 = ドレス首情報.GetDefault();
			ドレス首.色.SetDefault();
			yield return ドレス首;
			ドレス情報 @default = ドレス情報.GetDefault();
			@default.色.SetDefault();
			yield return @default;
			if (c.Is下着ボトム条件())
			{
				下着B_マイクロ情報 下着B_マイクロ情報 = 下着B_マイクロ情報.Getヴィオラ();
				下着B_マイクロ情報.色.Setヴィオラ();
				yield return 下着B_マイクロ情報;
			}
			else if (c.Is上着ボトム条件())
			{
				if (c.Is前掛け条件())
				{
					上着B_前掛け情報 default2 = 上着B_前掛け情報.GetDefault();
					default2.色.生地 = ドレス首.色.生地;
					default2.色.縁 = ドレス首.色.縁;
					default2.色.紐 = Col.Black;
					default2.色.SetColor2();
					yield return default2;
				}
				else
				{
					上着B_クロス情報 default3 = 上着B_クロス情報.GetDefault();
					default3.中 = false;
					default3.色.生地1 = ドレス首.色.生地;
					default3.色.生地2 = Col.Black;
					default3.色.SetColor2();
					yield return default3;
				}
			}
			if (c.Isブ\u30FCツ条件())
			{
				ブ\u30FCツ情報 default4 = ブ\u30FCツ情報.GetDefault();
				default4.色.SetDefault();
				yield return default4;
			}
			yield break;
		}

		public static IEnumerable<object> Getヴィオラ服1(ChaD c)
		{
			Color c2;
			Col.GetRandomClothesColor(out c2);
			Color c3;
			Col.GetRandomClothesColor(out c3);
			Color c4;
			Col.GetRandomClothesColor(out c4);
			Color c5;
			Col.GetRandomClothesColor(out c5);
			Color c6;
			Col.GetRandomClothesColor(out c6);
			ドレス首情報 @default = ドレス首情報.GetDefault();
			@default.色.生地 = c2;
			@default.色.縁 = c4;
			@default.色.SetColor2();
			yield return @default;
			ドレス情報 default2 = ドレス情報.GetDefault();
			default2.色.生地 = c2;
			default2.色.柄 = c4;
			default2.色.縁 = c4;
			default2.色.紐 = c5;
			default2.色.SetColor2();
			yield return default2;
			if (c.Is下着ボトム条件())
			{
				下着B_マイクロ情報 下着B_マイクロ情報 = 下着B_マイクロ情報.Getヴィオラ();
				下着B_マイクロ情報.色.生地 = c2;
				下着B_マイクロ情報.色.縁 = c4;
				下着B_マイクロ情報.色.紐 = c5;
				下着B_マイクロ情報.色.SetColor2();
				yield return 下着B_マイクロ情報;
			}
			else if (c.Is上着ボトム条件())
			{
				if (c.Is前掛け条件())
				{
					上着B_前掛け情報 default3 = 上着B_前掛け情報.GetDefault();
					default3.色.生地 = c2;
					default3.色.縁 = c4;
					default3.色.紐 = c5;
					default3.色.SetColor2();
					yield return default3;
				}
				else
				{
					上着B_クロス情報 default4 = 上着B_クロス情報.GetDefault();
					default4.中 = false;
					default4.色.生地1 = c2;
					default4.色.生地2 = c5;
					default4.色.SetColor2();
					yield return default4;
				}
			}
			if (c.Isブ\u30FCツ条件())
			{
				ブ\u30FCツ情報 default5 = ブ\u30FCツ情報.GetDefault();
				default5.色.生地1 = c2;
				default5.色.生地2 = c3;
				default5.色.縁 = c4;
				default5.色.柄 = c4;
				default5.色.紐 = c5;
				default5.色.金具 = c6;
				default5.色.穴 = c5;
				default5.色.靴底 = c5;
				default5.色.踵 = c5;
				default5.色.SetColor2();
				yield return default5;
			}
			yield break;
		}

		public static IEnumerable<object> Get奴隷服(ChaD c, bool b, bool r, bool a)
		{
			Color c2 = Col.Empty;
			Color c3 = Col.Empty;
			Color c4 = Col.Empty;
			if (r)
			{
				Col.GetRandomClothesColor(a ? OthN.XS.Next(32, 256) : 255, out c2);
				Col.GetRandomClothesColor(a ? OthN.XS.Next(32, 256) : 255, out c3);
				Col.GetRandomClothesColor(a ? OthN.XS.Next(32, 256) : 255, out c4);
			}
			if (b && c.Is下着ボトム条件())
			{
				if (r && OthN.XS.NextBool())
				{
					Color 紐;
					Col.GetRandomClothesColor(a ? OthN.XS.Next(32, 256) : 255, out 紐);
					Color 柄;
					Col.GetRandomClothesColor(a ? OthN.XS.Next(32, 256) : 255, out 柄);
					Color リボン;
					Col.GetRandomClothesColor(a ? OthN.XS.Next(32, 256) : 255, out リボン);
					下着B_ノ\u30FCマル情報 下着B_ノ_u30FCマル情報;
					if (c.Is紐付き条件())
					{
						下着B_ノ_u30FCマル情報 = 下着B_ノ\u30FCマル情報.Getランジェリ\u30FC紐付き();
					}
					else
					{
						下着B_ノ_u30FCマル情報 = 下着B_ノ\u30FCマル情報.Getランジェリ\u30FC();
					}
					下着B_ノ_u30FCマル情報.色.生地 = c2;
					下着B_ノ_u30FCマル情報.色.縁 = c4;
					下着B_ノ_u30FCマル情報.色.紐 = 紐;
					下着B_ノ_u30FCマル情報.色.柄 = 柄;
					下着B_ノ_u30FCマル情報.色.リボン = リボン;
					下着B_ノ_u30FCマル情報.色.SetColor2();
					yield return 下着B_ノ_u30FCマル情報;
				}
				else
				{
					下着B_ノ\u30FCマル情報 下着B_ノ_u30FCマル情報2 = 下着B_ノ\u30FCマル情報.Getビキニ();
					下着B_ノ_u30FCマル情報2.縁 = false;
					if (r)
					{
						下着B_ノ_u30FCマル情報2.色.SetRandom();
					}
					else
					{
						下着B_ノ_u30FCマル情報2.色.生地 = Color.OldLace;
						下着B_ノ_u30FCマル情報2.色.リボン = Color.OldLace;
						下着B_ノ_u30FCマル情報2.色.柄 = Color.OldLace;
						下着B_ノ_u30FCマル情報2.色.縁 = Color.OldLace;
						下着B_ノ_u30FCマル情報2.色.紐 = Color.OldLace;
						下着B_ノ_u30FCマル情報2.色.SetColor2();
					}
					yield return 下着B_ノ_u30FCマル情報2;
				}
			}
			if (OthN.XS.NextBool())
			{
				下着T_クロス情報 @default = 下着T_クロス情報.GetDefault();
				if (r)
				{
					@default.色.生地 = c2;
					@default.色.縁 = c3;
					@default.色.SetColor2();
				}
				yield return @default;
			}
			else
			{
				下着T_チュ\u30FCブ情報 default2 = 下着T_チュ\u30FCブ情報.GetDefault();
				default2.縁 = OthN.XS.NextBool();
				if (r)
				{
					default2.色.生地 = c2;
					default2.色.縁 = c3;
					default2.色.SetColor2();
				}
				yield return default2;
			}
			if (c.Is上着ボトム条件())
			{
				if (c.Is前掛け条件())
				{
					上着B_前掛け情報 default3 = 上着B_前掛け情報.GetDefault();
					if (r)
					{
						default3.色.生地 = c2;
						default3.色.縁 = c3;
						default3.色.紐 = c4;
						default3.色.SetColor2();
					}
					yield return default3;
				}
				else
				{
					上着B_クロス情報 default4 = 上着B_クロス情報.GetDefault();
					default4.中 = false;
					if (r)
					{
						default4.色.生地1 = c2;
						default4.色.生地2 = c3;
						default4.色.SetColor2();
					}
					yield return default4;
				}
			}
			yield break;
		}

		public static Unit Set衣装(this Unit u)
		{
			if (u.種族 == tex.サキュバス)
			{
				u.着衣番号 = 4;
				u.着衣 = 衣装.Get髪留め(u.ChaD).Concat(衣装.Getビキニ(u.ChaD, true)).ToArray<object>();
			}
			else
			{
				u.着衣番号 = 0;
				u.着衣 = 衣装.Get髪留め(u.ChaD).Concat(衣装.Get奴隷服(u.ChaD, true, false, false)).ToArray<object>();
			}
			return u;
		}

		public static Unit Change衣装(this Unit u)
		{
			int num;
			if (Sta.GameData.ヴィオラ服)
			{
				do
				{
					num = OthN.XS.Next(10);
				}
				while (u.着衣番号 == num);
			}
			else
			{
				do
				{
					num = OthN.XS.Next(8);
				}
				while (u.着衣番号 == num);
			}
			u.着衣番号 = num;
			switch (num)
			{
			case 0:
				u.着衣 = 衣装.Get髪留め(u.ChaD).Concat(衣装.Get奴隷服(u.ChaD, true, false, false)).ToArray<object>();
				break;
			case 1:
				u.着衣 = 衣装.Get髪留め(u.ChaD).Concat(衣装.Get奴隷服(u.ChaD, true, false, true)).ToArray<object>();
				break;
			case 2:
				u.着衣 = 衣装.Get髪留め(u.ChaD).Concat(衣装.Get奴隷服(u.ChaD, true, true, false)).ToArray<object>();
				break;
			case 3:
				u.着衣 = 衣装.Get髪留め(u.ChaD).Concat(衣装.Get奴隷服(u.ChaD, true, true, true)).ToArray<object>();
				break;
			case 4:
				u.着衣 = 衣装.Get髪留め(u.ChaD).Concat(衣装.Getビキニ(u.ChaD, true)).ToArray<object>();
				break;
			case 5:
				u.着衣 = 衣装.Get髪留め(u.ChaD).Concat(衣装.Getランジェリ\u30FC(u.ChaD, true, false)).ToArray<object>();
				break;
			case 6:
				u.着衣 = 衣装.Get髪留め(u.ChaD).Concat(衣装.Getランジェリ\u30FC(u.ChaD, true, true)).ToArray<object>();
				break;
			case 7:
				u.着衣 = 衣装.Get髪留め(u.ChaD).Concat(衣装.Getピアス(u.ChaD)).ToArray<object>();
				break;
			case 8:
				u.着衣 = 衣装.Get髪留め(u.ChaD).Concat(衣装.Getヴィオラ服0(u.ChaD)).ToArray<object>();
				break;
			case 9:
				u.着衣 = 衣装.Get髪留め(u.ChaD).Concat(衣装.Getヴィオラ服1(u.ChaD)).ToArray<object>();
				break;
			}
			return u;
		}

		public static double 一般労働倍率(this Unit u)
		{
			switch (u.着衣番号)
			{
			case 0:
				return 1.0;
			case 1:
				return 0.8;
			case 2:
				return 1.0;
			case 3:
				return 0.8;
			case 4:
				return 0.8;
			case 5:
				return 0.7;
			case 6:
				return 0.6;
			case 7:
				return 0.5;
			case 8:
				return 1.5;
			case 9:
				return 1.5;
			default:
				return 1.0;
			}
		}

		public static double 娼婦労働倍率(this Unit u)
		{
			switch (u.着衣番号)
			{
			case 0:
				return 1.0;
			case 1:
				return 1.2;
			case 2:
				return 1.1;
			case 3:
				return 1.2;
			case 4:
				return 1.2;
			case 5:
				return 1.3;
			case 6:
				return 1.4;
			case 7:
				return 1.5;
			case 8:
				return 1.5;
			case 9:
				return 1.5;
			default:
				return 1.0;
			}
		}
	}
}
