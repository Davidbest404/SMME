using System;
using System.Collections.Generic;

namespace SlaveMatrix
{
	public static class Def
	{
		public static double GetRareWeight(this string 種族)
		{
			return 1.0 / Math.Pow((double)(Def.種族情報[種族].希少 - ((Sta.GameData.祝福 != null && Sta.GameData.祝福.種族 == tex.カ\u30FCバンクル) ? (Def.種族情報[種族].希少 / 2) : 0)), 2.0);
		}

		public static double GetRutinohWeight(this string ルチノ\u30FC)
		{
			if (string.IsNullOrWhiteSpace(ルチノ\u30FC))
			{
				return 1.0;
			}
			if (ルチノ\u30FC.Contains("000"))
			{
				return 10.0;
			}
			if (ルチノ\u30FC.Contains("111"))
			{
				return 10.0;
			}
			if (ルチノ\u30FC.Contains("001"))
			{
				return 9.0;
			}
			if (ルチノ\u30FC.Contains("100"))
			{
				return 9.0;
			}
			if (ルチノ\u30FC.Contains("110"))
			{
				return 9.0;
			}
			if (ルチノ\u30FC.Contains("011"))
			{
				return 9.0;
			}
			if (ルチノ\u30FC.Contains("010"))
			{
				return 9.0;
			}
			if (ルチノ\u30FC.Contains("101"))
			{
				return 9.0;
			}
			if (ルチノ\u30FC.Contains("002"))
			{
				return 8.0;
			}
			if (ルチノ\u30FC.Contains("200"))
			{
				return 8.0;
			}
			if (ルチノ\u30FC.Contains("112"))
			{
				return 8.0;
			}
			if (ルチノ\u30FC.Contains("211"))
			{
				return 8.0;
			}
			if (ルチノ\u30FC.Contains("020"))
			{
				return 8.0;
			}
			if (ルチノ\u30FC.Contains("121"))
			{
				return 8.0;
			}
			if (ルチノ\u30FC.Contains("021"))
			{
				return 7.0;
			}
			if (ルチノ\u30FC.Contains("120"))
			{
				return 7.0;
			}
			if (ルチノ\u30FC.Contains("102"))
			{
				return 7.0;
			}
			if (ルチノ\u30FC.Contains("201"))
			{
				return 7.0;
			}
			if (ルチノ\u30FC.Contains("012"))
			{
				return 7.0;
			}
			if (ルチノ\u30FC.Contains("210"))
			{
				return 7.0;
			}
			if (ルチノ\u30FC.Contains("022"))
			{
				return 6.0;
			}
			if (ルチノ\u30FC.Contains("220"))
			{
				return 6.0;
			}
			if (ルチノ\u30FC.Contains("122"))
			{
				return 6.0;
			}
			if (ルチノ\u30FC.Contains("221"))
			{
				return 6.0;
			}
			if (ルチノ\u30FC.Contains("202"))
			{
				return 6.0;
			}
			if (ルチノ\u30FC.Contains("212"))
			{
				return 6.0;
			}
			return 1.0;
		}

		public const double vd = 0.6;

		public const double bd = 0.3;

		public const double nd = 0.5;

		public static Dictionary<string, 種族情報> 種族情報 = new Dictionary<string, 種族情報>
		{
			{
				tex.サキュバス,
				new 種族情報(5, 9, 4, 3, 9)
			},
			{
				tex.バイコ\u30FCン,
				new 種族情報(7, 6, 5, 5, 8)
			},
			{
				tex.ドワ\u30FCフ,
				new 種族情報(4, 6, 3, 4, 7)
			},
			{
				tex.アルラウネ,
				new 種族情報(4, 7, 5, 3, 7)
			},
			{
				tex.スキュラ,
				new 種族情報(6, 7, 6, 5, 7)
			},
			{
				tex.アラクネ,
				new 種族情報(4, 4, 6, 5, 7)
			},
			{
				tex.ユニコ\u30FCン,
				new 種族情報(7, 8, 4, 5, 7)
			},
			{
				tex.エキドナ,
				new 種族情報(7, 4, 6, 6, 7)
			},
			{
				tex.ムカデジョウロウ,
				new 種族情報(4, 4, 7, 6, 7)
			},
			{
				tex.オ\u30FCルドスキュラ,
				new 種族情報(8, 6, 8, 7, 7)
			},
			{
				tex.ドラゴニュ\u30FCト,
				new 種族情報(7, 8, 7, 7, 7)
			},
			{
				tex.カッパ,
				new 種族情報(7, 6, 3, 4, 7)
			},
			{
				tex.エルフ,
				new 種族情報(4, 7, 3, 3, 6)
			},
			{
				tex.リザ\u30FCドマン,
				new 種族情報(4, 5, 5, 4, 6)
			},
			{
				tex.オ\u30FCグリス,
				new 種族情報(4, 5, 5, 4, 6)
			},
			{
				tex.デビル,
				new 種族情報(4, 5, 4, 4, 6)
			},
			{
				tex.オ\u30FCルドマ\u30FCメイド,
				new 種族情報(8, 6, 4, 4, 6)
			},
			{
				tex.ラミア,
				new 種族情報(2, 5, 4, 4, 6)
			},
			{
				tex.シ\u30FCラミア,
				new 種族情報(4, 4, 5, 4, 6)
			},
			{
				tex.サイクロプス,
				new 種族情報(7, 6, 5, 5, 6)
			},
			{
				tex.ミノタウロス,
				new 種族情報(4, 7, 5, 5, 6)
			},
			{
				tex.エイリアン,
				new 種族情報(7, 6, 5, 6, 6)
			},
			{
				tex.ゴルゴン,
				new 種族情報(8, 4, 8, 6, 6)
			},
			{
				tex.ギルタブリル,
				new 種族情報(5, 4, 7, 6, 6)
			},
			{
				tex.ウロボロス,
				new 種族情報(8, 7, 6, 7, 6)
			},
			{
				tex.フェニックス,
				new 種族情報(8, 8, 6, 7, 6)
			},
			{
				tex.ドラゴン,
				new 種族情報(7, 6, 9, 8, 6)
			},
			{
				tex.リュウ,
				new 種族情報(9, 8, 9, 9, 6)
			},
			{
				tex.リリン,
				new 種族情報(3, 5, 3, 3, 5)
			},
			{
				tex.セイレ\u30FCン,
				new 種族情報(4, 5, 4, 4, 5)
			},
			{
				tex.ハルピュイア,
				new 種族情報(6, 5, 4, 4, 5)
			},
			{
				tex.オノケンタウレ,
				new 種族情報(3, 5, 3, 4, 5)
			},
			{
				tex.カプラケンタウレ,
				new 種族情報(3, 5, 4, 4, 5)
			},
			{
				tex.チ\u30FCタケンタウレ,
				new 種族情報(5, 5, 5, 4, 5)
			},
			{
				tex.エンジェル,
				new 種族情報(6, 7, 4, 4, 5)
			},
			{
				tex.マ\u30FCメイド,
				new 種族情報(4, 6, 3, 4, 5)
			},
			{
				tex.ドルフィンマ\u30FCメイド,
				new 種族情報(5, 5, 3, 4, 5)
			},
			{
				tex.ウェアキャット,
				new 種族情報(2, 7, 3, 4, 5)
			},
			{
				tex.ウェアウルフ,
				new 種族情報(2, 7, 4, 4, 5)
			},
			{
				tex.ウェアフォックス,
				new 種族情報(3, 7, 3, 4, 5)
			},
			{
				tex.ヒュドラ,
				new 種族情報(6, 4, 6, 5, 5)
			},
			{
				tex.クラ\u30FCケン,
				new 種族情報(4, 4, 6, 5, 5)
			},
			{
				tex.ヒッポケンタウレ,
				new 種族情報(4, 5, 5, 5, 5)
			},
			{
				tex.ブケンタウレ,
				new 種族情報(4, 6, 6, 5, 5)
			},
			{
				tex.レオントケンタウレ,
				new 種族情報(4, 6, 6, 5, 5)
			},
			{
				tex.ティグリスケンタウレ,
				new 種族情報(5, 6, 7, 5, 5)
			},
			{
				tex.パンテ\u30FCラケンタウレ,
				new 種族情報(5, 5, 6, 5, 5)
			},
			{
				tex.イクテュオケンタウレ,
				new 種族情報(5, 5, 5, 5, 5)
			},
			{
				tex.デルピヌスケンタウレ,
				new 種族情報(5, 5, 5, 5, 5)
			},
			{
				tex.ギルタブルル,
				new 種族情報(8, 4, 7, 6, 5)
			},
			{
				tex.スフィンクス,
				new 種族情報(6, 6, 7, 6, 5)
			},
			{
				tex.ペガサス,
				new 種族情報(6, 6, 4, 6, 5)
			},
			{
				tex.アリコ\u30FCン,
				new 種族情報(8, 6, 5, 6, 5)
			},
			{
				tex.キマイラ,
				new 種族情報(5, 5, 7, 6, 5)
			},
			{
				tex.グリフォン,
				new 種族情報(7, 6, 7, 6, 5)
			},
			{
				tex.ヒッポグリフ,
				new 種族情報(8, 5, 7, 6, 5)
			},
			{
				tex.モノケロス,
				new 種族情報(8, 6, 6, 6, 5)
			},
			{
				tex.カリュブディス,
				new 種族情報(7, 5, 6, 6, 5)
			},
			{
				tex.ドラコケンタウレ,
				new 種族情報(6, 5, 8, 7, 5)
			},
			{
				tex.カ\u30FCバンクル,
				new 種族情報(9, 8, 1, 1, 4)
			},
			{
				tex.スライム,
				new 種族情報(1, 5, 3, 2, 4)
			},
			{
				tex.フェアリ\u30FC,
				new 種族情報(7, 7, 2, 3, 4)
			},
			{
				tex.ハ\u30FCピ\u30FC,
				new 種族情報(2, 5, 3, 3, 4)
			},
			{
				tex.アフ\u30FCル,
				new 種族情報(3, 4, 3, 3, 4)
			},
			{
				tex.ウェアマンティス,
				new 種族情報(2, 3, 5, 4, 4)
			},
			{
				tex.ウェアドラゴンフライ,
				new 種族情報(2, 3, 5, 4, 4)
			},
			{
				tex.カトブレパス,
				new 種族情報(7, 4, 8, 6, 4)
			},
			{
				tex.バジリスク,
				new 種族情報(7, 4, 8, 6, 4)
			},
			{
				tex.コカトリス,
				new 種族情報(7, 4, 8, 6, 4)
			},
			{
				tex.ワ\u30FCム,
				new 種族情報(5, 4, 7, 7, 4)
			},
			{
				tex.ワイバ\u30FCン,
				new 種族情報(6, 5, 8, 7, 4)
			},
			{
				tex.ウェアビ\u30FCトル,
				new 種族情報(3, 3, 5, 5, 3)
			},
			{
				tex.ウェアスタッグビ\u30FCトル,
				new 種族情報(4, 3, 5, 5, 3)
			},
			{
				tex.サンドワ\u30FCム,
				new 種族情報(3, 3, 7, 6, 3)
			},
			{
				tex.ヴィオランテ,
				new 種族情報(8, 8, 8, 8, 8)
			},
			{
				tex.ヒュ\u30FCマン,
				new 種族情報(3, 4, 3, 4, 4)
			}
		};
	}
}
