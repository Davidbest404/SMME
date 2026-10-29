using System;
using System.Collections.Generic;
using System.Drawing;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public static class Act
	{
		public static double 主精力
		{
			get
			{
				return Sta.GameData.精力;
			}
			set
			{
				Sta.GameData.精力 = value;
			}
		}

		public static double 主射精
		{
			get
			{
				return Sta.GameData.射精;
			}
			set
			{
				Sta.GameData.射精 = value;
				Sta.GameData.射精 = Sta.GameData.射精.LimitM(0.0, 1.0);
			}
		}

		public static double 主興奮
		{
			get
			{
				return Sta.GameData.興奮;
			}
			set
			{
				Sta.GameData.興奮 = value;
				Sta.GameData.興奮 = Sta.GameData.興奮.LimitM(0.0, 1.0);
			}
		}

		public static double 調教力
		{
			get
			{
				return Sta.GameData.調教力;
			}
			set
			{
				Sta.GameData.調教力 = value;
			}
		}

		public static double 体力
		{
			get
			{
				return Sta.GameData.調教対象.ChaD.体力;
			}
			set
			{
				Sta.GameData.調教対象.ChaD.体力 = value;
			}
		}

		public static double 感度
		{
			get
			{
				return Sta.GameData.調教対象.ChaD.感度;
			}
			set
			{
				Sta.GameData.調教対象.ChaD.感度 = value;
				Sta.GameData.調教対象.ChaD.感度 = Sta.GameData.調教対象.ChaD.感度.LimitM(0.0, 1.0);
			}
		}

		public static double 興奮
		{
			get
			{
				return Sta.GameData.調教対象.ChaD.興奮;
			}
			set
			{
				Sta.GameData.調教対象.ChaD.興奮 = value;
				Sta.GameData.調教対象.ChaD.興奮 = Sta.GameData.調教対象.ChaD.興奮.LimitM(0.0, 1.0);
			}
		}

		public static double 潤滑
		{
			get
			{
				return Sta.GameData.調教対象.ChaD.潤滑;
			}
			set
			{
				Sta.GameData.調教対象.ChaD.潤滑 = value;
			}
		}

		public static double 緊張
		{
			get
			{
				return Sta.GameData.調教対象.ChaD.緊張;
			}
			set
			{
				Sta.GameData.調教対象.ChaD.緊張 = value;
			}
		}

		public static double 羞恥
		{
			get
			{
				return Sta.GameData.調教対象.ChaD.羞恥;
			}
			set
			{
				Sta.GameData.調教対象.ChaD.羞恥 = value;
			}
		}

		public static double 抵抗値
		{
			get
			{
				return Sta.GameData.調教対象.ChaD.抵抗値;
			}
			set
			{
				Sta.GameData.調教対象.ChaD.抵抗値 = value;
			}
		}

		public static double 欲望度
		{
			get
			{
				return Sta.GameData.調教対象.ChaD.欲望度;
			}
			set
			{
				Sta.GameData.調教対象.ChaD.欲望度 = value;
			}
		}

		public static double 情愛度
		{
			get
			{
				return Sta.GameData.調教対象.ChaD.情愛度;
			}
			set
			{
				Sta.GameData.調教対象.ChaD.情愛度 = value;
			}
		}

		public static double 卑屈度
		{
			get
			{
				return Sta.GameData.調教対象.ChaD.卑屈度;
			}
			set
			{
				Sta.GameData.調教対象.ChaD.卑屈度 = value;
			}
		}

		public static double 技巧度
		{
			get
			{
				return Sta.GameData.調教対象.ChaD.技巧度;
			}
			set
			{
				Sta.GameData.調教対象.ChaD.技巧度 = value;
			}
		}

		public static Dictionary<接触, double> 部位感度
		{
			get
			{
				return Sta.GameData.調教対象.ChaD.部位感度;
			}
			set
			{
				Sta.GameData.調教対象.ChaD.部位感度 = value;
			}
		}

		public static double 現乳首
		{
			get
			{
				return Sta.GameData.調教対象.ChaD.現乳首;
			}
			set
			{
				Sta.GameData.調教対象.ChaD.現乳首 = value;
			}
		}

		public static double 現乳房
		{
			get
			{
				return Sta.GameData.調教対象.ChaD.現乳房;
			}
			set
			{
				Sta.GameData.調教対象.ChaD.現乳房 = value;
			}
		}

		public static double 現陰核
		{
			get
			{
				return Sta.GameData.調教対象.ChaD.現陰核;
			}
			set
			{
				Sta.GameData.調教対象.ChaD.現陰核 = value;
			}
		}

		public static double 現性器
		{
			get
			{
				return Sta.GameData.調教対象.ChaD.現性器;
			}
			set
			{
				Sta.GameData.調教対象.ChaD.現性器 = value;
			}
		}

		public static double 現肛門
		{
			get
			{
				return Sta.GameData.調教対象.ChaD.現肛門;
			}
			set
			{
				Sta.GameData.調教対象.ChaD.現肛門 = value;
			}
		}

		public static double 現陰毛
		{
			get
			{
				return Sta.GameData.調教対象.ChaD.現陰毛;
			}
			set
			{
				Sta.GameData.調教対象.ChaD.現陰毛 = value;
			}
		}

		public static double 放尿経験値
		{
			get
			{
				return Sta.GameData.調教対象.ChaD.放尿経験値;
			}
			set
			{
				Sta.GameData.調教対象.ChaD.放尿経験値 = value;
			}
		}

		public static 感情 状態
		{
			get
			{
				return Sta.GameData.調教対象.ChaD.状態;
			}
			set
			{
				Sta.GameData.調教対象.ChaD.状態 = value;
			}
		}

		public static bool パイズリRun
		{
			get
			{
				return Act.UI.ペニス処理.パイズリ.Run;
			}
		}

		public static bool フェラRun
		{
			get
			{
				return Act.UI.ペニス処理.フェラ.Run;
			}
		}

		public static void 精力回復()
		{
			Act.主精力 = (Act.主精力 + (0.05 + Act.主精力 * OthN.XS.NextDouble())).LimitM(0.0, 1.0);
		}

		public static void 体力回復(this Unit u)
		{
			u.ChaD.体力 = (u.ChaD.体力 + (0.05 + u.ChaD.体力 * OthN.XS.NextDouble())).LimitM(0.0, 1.0);
		}

		public static void 体力消費(this Unit u)
		{
			u.ChaD.体力 = (u.ChaD.体力 - 0.5 * OthN.XS.NextDouble() * u.消耗乗算値).LimitM(0.0, 1.0);
		}

		public static void SetState()
		{
			Act.感度 = (1.0 * Act.抵抗値.Inverse() * Act.欲望度 * Act.情愛度 * OthN.XS.NextDouble()).LimitM(0.0, 1.0);
			Act.興奮 = (1.0 * Act.抵抗値.Inverse() * Act.欲望度 * Act.情愛度 * OthN.XS.NextDouble()).LimitM(0.0, 1.0);
			Act.潤滑 = (2.0 * Act.抵抗値.Inverse() * Act.欲望度 * Act.情愛度).LimitM(0.0, 1.0);
			Act.緊張 = (2.0 * Act.抵抗値 * Act.欲望度.Inverse() * Act.情愛度.Inverse()).LimitM(0.0, 1.0);
			Act.羞恥 = (1.0 * Act.抵抗値.Inverse() * Act.情愛度).LimitM(0.0, 1.0);
		}

		public static void SetState奴隷()
		{
			if (Sta.GameData.調教対象 != null && Act.Cha != null)
			{
				Act.精力回復();
				Sta.GameData.調教対象.体力回復();
				Act.主射精 = 0.0;
				Act.主興奮 = 0.0;
				Act.SetState();
				Act.調教前抵抗値 = Act.抵抗値;
				Act.調教前欲望度 = Act.欲望度;
				Act.調教前情愛度 = Act.情愛度;
				Act.調教前卑屈度 = Act.卑屈度;
				Act.調教前技巧度 = Act.技巧度;
				Act.調教前調教力 = Act.調教力;
				Act.無毛 = Sta.GameData.調教対象.無毛フラグ;
				Act.処女 = Sta.GameData.調教対象.処女フラグ;
				Act.発情 = Sta.GameData.調教対象.発情フラグ;
				Act.妊娠 = Sta.GameData.調教対象.妊娠フラグ;
				Act.強靭 = Sta.GameData.調教対象.強靭フラグ;
				Act.傷物 = Sta.GameData.調教対象.傷物フラグ;
				Act.調教済 = Sta.GameData.調教対象.調教済フラグ;
				Act.絶頂回数 = 0;
				Act.初回 = true;
				Act.反応度 = 1.0;
				Act.Cha.Set初期角度();
				Act.Cha.Set表情初期化();
				Act.Cha.Set姿勢初期化();
				Act.Cha.情動();
				Act.Cha.Set表情変化();
				Act.Cha.Set姿勢変化();
				Act.Cha.Bod.処女喪失 = false;
				Act.Cha.Bod.膣内精液.血液1_表示 = false;
				Act.Cha.Bod.膣内精液.血液2_表示 = false;
				Act.Cha.Bod.性器精液.血液1_表示 = false;
				Act.Cha.Bod.性器精液.血液2_表示 = false;
				Act.Cha.Bod.飛沫濃度 = 0.0;
				Act.Cha.Bod.潮染み濃度 = 0.0;
				Act.Cha.Bod.尿染み濃度 = 0.0;
				Act.Cha.Bod.湯気左濃度 = 0.0;
				Act.Cha.Bod.湯気右濃度 = 0.0;
				Act.放尿率 = 1.0;
				Act.Cha.Bod.噴乳左.母乳垂れ1_表示 = false;
				Act.Cha.Bod.噴乳左.母乳垂れ2_表示 = false;
				Act.Cha.Bod.噴乳右.母乳垂れ1_表示 = false;
				Act.Cha.Bod.噴乳右.母乳垂れ2_表示 = false;
				Act.表示ステ\u30FCト更新();
				Act.強制終了 = false;
				Act.ModBox();
				Act.SensBox();
			}
		}

		public static void Result1()
		{
			Act.UI.ip.TextIm = string.Concat(new string[]
			{
				tex.抵抗値,
				" -",
				(Act.調教前抵抗値 - Act.抵抗値).Numf2(),
				"\r\n",
				tex.欲望度,
				" +",
				(Act.欲望度 - Act.調教前欲望度).Numf2(),
				" ",
				tex.情愛度,
				" + ",
				(Act.情愛度 - Act.調教前情愛度).Numf2(),
				"\r\n",
				tex.卑屈度,
				" +",
				(Act.卑屈度 - Act.調教前卑屈度).Numf2(),
				" ",
				tex.技巧度,
				" + ",
				(Act.技巧度 - Act.調教前技巧度).Numf2(),
				"\r\n\r\n",
				tex.調教力,
				" +",
				(Act.調教力 - Act.調教前調教力).Numf2()
			});
		}

		public static void Result2()
		{
			Act.UI.ip.TextIm = string.Concat(new string[]
			{
				tex.抵抗値,
				Act.抵抗値.Numf2(),
				"\r\n",
				tex.欲望度,
				Act.欲望度.Numf2(),
				" ",
				tex.情愛度,
				Act.情愛度.Numf2(),
				"\r\n",
				tex.卑屈度,
				Act.卑屈度.Numf2(),
				" ",
				tex.技巧度,
				Act.技巧度.Numf2(),
				"\r\n\r\n",
				tex.調教力,
				Act.調教力.Numf2()
			});
			Act.Cha.Bod.変動ステ\u30FCト更新();
		}

		public static bool 加算前提
		{
			get
			{
				return !Act.強制終了 && Sta.GameData.調教対象 != null && Act.Cha != null && Act.Cha.Med.Mode == "調教";
			}
		}

		public static void アクション入力(接触 接触, アクション情報 アクション情報, タイミング情報 タイミング情報, アイテム情報 アイテム情報, int 挿入Lv, int 強さ, bool 機械, bool 射精)
		{
			Act.接触o = Act.接触n;
			Act.アクション情報o = Act.アクション情報n;
			Act.タイミング情報o = Act.タイミング情報n;
			Act.アイテム情報o = Act.アイテム情報n;
			Act.挿入Lvo = Act.挿入Lvn;
			Act.強さo = Act.強さn;
			Act.機械o = Act.機械n;
			Act.射精o = Act.射精n;
			Act.接触n = 接触;
			Act.アクション情報n = アクション情報;
			Act.タイミング情報n = タイミング情報;
			Act.アイテム情報n = アイテム情報;
			Act.挿入Lvn = 挿入Lv;
			Act.強さn = 強さ;
			Act.機械n = 機械;
			Act.射精n = 射精;
			if (Act.加算前提)
			{
				Act.奴隷ゲ\u30FCジ上昇();
				if (アイテム情報 == アイテム情報.ペニス)
				{
					Act.主人ゲ\u30FCジ上昇();
				}
				Act.入力反応0();
			}
		}

		public static void 自コキ処理()
		{
			if (Act.加算前提)
			{
				Act.アクション情報n = アクション情報.none;
				Act.射精n = false;
				Act.主人ゲ\u30FCジ上昇();
			}
		}

		public static void 主人ゲ\u30FCジ上昇()
		{
			Act.主感度加算();
			Act.射精直前処理();
			Act.射精開始処理();
			if (!Act.射精n)
			{
				Act.射精処理();
			}
		}

		public static void 奴隷ゲ\u30FCジ上昇()
		{
			Act.慣れ計算();
			Act.部位計算();
			Act.緊張計算();
			Act.羞恥計算();
			Act.潤滑計算();
			Act.感度加算();
			Act.欲望度計算();
			Act.情愛度計算();
			Act.卑屈度計算();
			Act.技巧度計算();
			Act.抵抗値計算();
			Act.調教力計算();
			Act.絶頂直前処理();
			Act.絶頂開始処理();
		}

		public static void 調教強制終了()
		{
			if (Act.体力 == 0.0 || Act.主精力 == 0.0)
			{
				Act.UI.ip.MaiShow = true;
				Act.強制終了 = true;
				Act.UI.ip.TextIm = tex.体力が限界です調教を終了します;
			}
		}

		public static void 調教終了時()
		{
		}

		public static void 絶頂直前処理()
		{
			if (!Act.絶頂中 && Act.感度 > 0.85)
			{
				if (0.1.Lot())
				{
					Act.Cha.Set表情変化();
				}
				if (0.1.Lot())
				{
					Act.Cha.Set姿勢変化();
				}
				if (0.05.Lot())
				{
					if (Act.Cha.Bod.Is双眉)
					{
						Act.Cha.両眉_0(OthN.XS.NextBool(), OthN.XS.NextM(3, 4), OthN.XS.NextM(3, 4));
					}
					if (Act.Cha.Bod.Is単眉)
					{
						Act.Cha.単眉_顰();
					}
				}
				if (0.015.Lot())
				{
					Act.発声();
				}
			}
		}

		public static void 絶頂開始処理()
		{
			if (!Act.絶頂中 && Act.感度 >= 1.0)
			{
				Act.絶頂中 = true;
				double value = 4.0 * Act.興奮 * Act.緊張.Inverse() * Act.羞恥 * Act.抵抗値.Inverse() * Act.欲望度 * Act.情愛度;
				Act.Cha.絶頂激しさ = value.LimitM(0.0, 1.0);
				Act.Cha.絶頂時間 = value.LimitM(0.0, 0.85);
				Act.UI.絶頂ゲ\u30FCジ点滅.Sta();
				Act.Cha.絶頂.Sta();
				if (Act.UI.ペニス処理.手コキ.Run)
				{
					Act.UI.ペニス処理.手コキ.End();
				}
				if (Act.UI.ペニス処理.足コキ.Run)
				{
					Act.UI.ペニス処理.足コキ.End();
				}
				if (Act.UI.ペニス処理.パイズリ.Run)
				{
					Act.UI.ペニス処理.パイズリ.End();
				}
				if (Act.UI.ペニス処理.フェラ.Run)
				{
					Act.UI.ペニス処理.フェラ.End();
				}
				Act.絶頂回数++;
				Act.初回 = true;
				Act.入力反応0();
				if (0.05.Lot())
				{
					if (Act.Cha.Bod.Is双眉)
					{
						Act.Cha.両眉_0(OthN.XS.NextBool(), OthN.XS.NextM(3, 4), OthN.XS.NextM(3, 4));
					}
					if (Act.Cha.Bod.Is単眉)
					{
						Act.Cha.単眉_顰();
					}
				}
			}
		}

		public static void 絶頂中処理()
		{
			if (Act.加算前提)
			{
				Act.絶頂部位計算();
				Act.絶頂欲望度計算();
				Act.絶頂情愛度計算();
				Act.絶頂卑屈度計算();
				Act.絶頂抵抗値計算();
				Act.調教力計算();
				if (0.1.Lot())
				{
					Act.Cha.Set表情変化();
				}
				if (Act.絶頂回数 > 1 && Act.欲望度 > 0.6 && 0.1.Lot())
				{
					if (Act.Cha.Bod.Is双眼)
					{
						Act.Cha.目_上転左();
						Act.Cha.目_上転右();
					}
					if (Act.Cha.Bod.Is単眼)
					{
						Act.Cha.単目_上転();
					}
					if (Act.Cha.Bod.Is頬眼)
					{
						Act.Cha.頬目_上転左();
						Act.Cha.頬目_上転右();
					}
					if (Act.Cha.Bod.Is額眼)
					{
						Act.Cha.額目_上転();
					}
				}
				if (OthN.XS.NextBool())
				{
					if (0.1.Lot())
					{
						if (Act.Cha.Bod.Is双眼)
						{
							Act.Cha.瞼_瞑左();
							Act.Cha.瞼_瞑右();
						}
						if (Act.Cha.Bod.Is単眼)
						{
							Act.Cha.単瞼_瞑();
						}
						if (Act.Cha.Bod.Is頬眼)
						{
							Act.Cha.頬瞼_瞑左();
							Act.Cha.頬瞼_瞑右();
						}
						if (Act.Cha.Bod.Is額眼)
						{
							Act.Cha.額瞼_瞑();
						}
					}
				}
				else if (0.1.Lot())
				{
					if (Act.Cha.Bod.Is双眼)
					{
						Act.Cha.瞼_半1左();
						Act.Cha.瞼_半1右();
					}
					if (Act.Cha.Bod.Is単眼)
					{
						Act.Cha.単瞼_半1();
					}
					if (Act.Cha.Bod.Is頬眼)
					{
						Act.Cha.頬瞼_半1左();
						Act.Cha.頬瞼_半1右();
					}
					if (Act.Cha.Bod.Is額眼)
					{
						Act.Cha.額瞼_半1();
					}
				}
				if (Act.手膣 && Act.体力 > 0.1 && Act.潤滑 > 0.6 && Act.緊張 == 0.0 && Act.欲望度 > 0.7 && Act.情愛度 > 0.7 && (Act.興奮 * 0.05).Lot())
				{
					Act.Cha.潮吹大.Sta();
				}
				else if (Act.潤滑 > 0.5 && Act.緊張 == 0.0 && Act.欲望度 > 0.5 && Act.情愛度 > 0.5 && (Act.興奮 * 0.05).Lot())
				{
					Act.Cha.潮吹小.Sta();
				}
				if (Act.Cha.泣き && Act.Cha.Bod.舌_表示 && (Act.Cha.絶頂激しさ * 0.0008).Lot())
				{
					Act.Cha.鼻水.Sta();
				}
				if ((Act.Cha.Bod.舌_表示 || Act.Cha.Bod.玉口枷_表示) && (Act.Cha.絶頂激しさ * 0.001).Lot())
				{
					Act.Cha.涎.Sta();
				}
				if (0.05.Lot())
				{
					if (Act.Cha.Bod.Is双眉)
					{
						Act.Cha.両眉_0(OthN.XS.NextBool(), OthN.XS.NextM(3, 4), OthN.XS.NextM(3, 4));
					}
					if (Act.Cha.Bod.Is単眉)
					{
						Act.Cha.単眉_顰();
					}
				}
				if (0.01.Lot())
				{
					Act.発声();
				}
			}
		}

		public static void 絶頂終了処理()
		{
			if (Act.加算前提)
			{
				Act.絶頂終了処理_();
				if (Act.Cha.Bod.くぱぁ0 > 0.5 && (0.1 + Act.放尿率 * Act.放尿経験値 * Act.緊張.Inverse() * 0.5).Lot() && !Sta.NoPissing)
				{
					Act.Cha.放尿.Sta();
					Act.放尿率 = (Act.放尿率 - 0.1).LimitM(0.0, 1.0);
					Act.放尿経験値 = (Act.放尿経験値 + 0.03 * OthN.XS.NextDouble()).LimitM(0.0, 1.0);
				}
				Act.発声();
			}
		}

		public static void 絶頂終了処理_()
		{
			Act.UI.絶頂ゲ\u30FCジ点滅.End();
			Act.絶頂中 = false;
			Act.感度 -= Act.Cha.絶頂激しさ.Inverse() * 0.5;
			Act.興奮 -= Act.Cha.絶頂激しさ.Inverse() * 0.5;
		}

		public static void 射精処理()
		{
			if (Act.射精中 && (Act.主精力 * 0.05).Lot())
			{
				Act.UI.ペニス処理.精液発射();
			}
		}

		public static void 射精直前処理()
		{
			if (!Act.射精中 && Act.主射精 > 0.85 && (Act.アクション情報n == アクション情報.手コ || Act.アクション情報n == アクション情報.パイ) && Act.欲望度 > 0.6 && Act.技巧度 > 0.5 * Sta.GameData.調教対象.技巧最大値)
			{
				if (((Act.技巧度 + Act.欲望度) * 0.05).Lot())
				{
					if (Act.Cha.Bod.Is双眼)
					{
						Act.Cha.目_見つめ左();
						Act.Cha.目_見つめ右();
					}
					if (Act.Cha.Bod.Is頬眼)
					{
						Act.Cha.頬目_見つめ左();
						Act.Cha.頬目_見つめ右();
					}
					if (Act.Cha.Bod.Is単眼)
					{
						Act.Cha.単目_見つめ();
					}
					if (Act.Cha.Bod.Is額眼)
					{
						Act.Cha.額目_見つめ();
					}
				}
				if (!Act.Cha.Bod.玉口枷_表示 && !Act.Cha.Bod.舌_表示 && ((Act.技巧度 + Act.欲望度) * 0.05).Lot())
				{
					Act.Cha.口_開き();
					Act.Cha.舌_出し();
				}
			}
		}

		public static void 射精開始処理()
		{
			if (Act.加算前提 && !Act.射精中 && Act.主射精 >= 1.0)
			{
				Act.射精中 = true;
				double 射精時間 = (1.1 * Act.主興奮 * Act.技巧度影響値).LimitM(0.0, 0.85);
				Act.UI.ペニス処理.射精時間 = 射精時間;
				Act.UI.射精ゲ\u30FCジ点滅.Sta();
				Act.UI.ペニス処理.射精終了.Sta();
			}
		}

		public static void 射精中処理()
		{
			if (Act.加算前提)
			{
				if (Act.アクション情報n != アクション情報.none)
				{
					Act.絶頂技巧度計算();
				}
				if ((Act.アクション情報n == アクション情報.手コ || Act.アクション情報n == アクション情報.パイ) && Act.欲望度 > 0.6 && Act.技巧度 > 0.5 * Sta.GameData.調教対象.技巧最大値)
				{
					if (((Act.技巧度 + Act.欲望度) * 0.05).Lot())
					{
						if (Act.Cha.Bod.Is双眼)
						{
							Act.Cha.目_見つめ左();
							Act.Cha.目_見つめ右();
						}
						if (Act.Cha.Bod.Is頬眼)
						{
							Act.Cha.頬目_見つめ左();
							Act.Cha.頬目_見つめ右();
						}
						if (Act.Cha.Bod.Is単眼)
						{
							Act.Cha.単目_見つめ();
						}
						if (Act.Cha.Bod.Is額眼)
						{
							Act.Cha.額目_見つめ();
						}
					}
					if (!Act.Cha.Bod.玉口枷_表示 && !Act.Cha.Bod.舌_表示 && ((Act.技巧度 + Act.欲望度) * 0.05).Lot())
					{
						Act.Cha.口_開き();
						Act.Cha.舌_出し();
					}
				}
			}
		}

		public static void 射精終了処理()
		{
			if (Act.加算前提)
			{
				Act.射精終了処理_();
			}
		}

		public static void 射精終了処理_()
		{
			Act.UI.射精ゲ\u30FCジ点滅.End();
			Act.射精中 = false;
			Act.主射精 -= Act.UI.ペニス処理.射精時間.Inverse() * 0.6;
			Act.主興奮 -= Act.UI.ペニス処理.射精時間.Inverse() * 0.6;
		}

		public static void 中出し処理()
		{
			if (Act.加算前提)
			{
				if (Act.接触n != 接触.口)
				{
					Act.潤滑計算();
				}
				Act.欲望度計算();
				Act.情愛度計算();
				if (Act.接触n == 接触.膣 && !Sta.GameData.調教対象.妊娠フラグ)
				{
					Sta.GameData.調教対象.妊娠フラグ = (0.04 * Act.調教力 + 0.01 * Act.発情1_5w * ((Sta.GameData.調教対象.種族 == tex.エキドナ) ? 2.0 : 1.0)).Lot();
				}
			}
		}

		public static void ぶっかけ処理()
		{
			if (Act.加算前提)
			{
				Act.羞恥計算();
				Act.卑屈度計算();
				if (Act.接触n == 接触.頭 || Act.接触n == 接触.顔 || Act.接触n == 接触.髪 || Act.接触n == 接触.口)
				{
					if (0.7.Lot())
					{
						if (Act.Cha.Bod.Is双眼)
						{
							Act.Cha.瞼_瞑左();
							Act.Cha.瞼_瞑右();
						}
						if (Act.Cha.Bod.Is単眼)
						{
							Act.Cha.単瞼_瞑();
						}
						if (Act.Cha.Bod.Is頬眼)
						{
							Act.Cha.頬瞼_瞑左();
							Act.Cha.頬瞼_瞑右();
						}
						if (Act.Cha.Bod.Is額眼)
						{
							Act.Cha.額瞼_瞑();
							return;
						}
					}
					else
					{
						if (Act.Cha.Bod.Is双眼)
						{
							Act.Cha.瞼_半2左();
							Act.Cha.瞼_半2右();
						}
						if (Act.Cha.Bod.Is単眼)
						{
							Act.Cha.単瞼_半2();
						}
						if (Act.Cha.Bod.Is頬眼)
						{
							Act.Cha.頬瞼_半2左();
							Act.Cha.頬瞼_半2右();
						}
						if (Act.Cha.Bod.Is額眼)
						{
							Act.Cha.額瞼_半2();
						}
					}
				}
			}
		}

		public static double 調教力影響値
		{
			get
			{
				return 0.1 + 0.9 * Act.調教力;
			}
		}

		public static double 技巧度影響値
		{
			get
			{
				return 0.3 + 0.7 * (Act.技巧度 / Sta.GameData.調教対象.技巧最大値);
			}
		}

		public static double 主消費影響値
		{
			get
			{
				return (Act.主人a + Act.調教力影響値.Inverse()) * 0.5 * ((Sta.GameData.祝福 != null) ? Sta.GameData.祝福.消耗乗算値 : 1.0);
			}
		}

		public static void 主精力消費大()
		{
			if (Act.加算前提)
			{
				double num = 0.02;
				Act.主精力 = (Act.主精力 - (num * 0.11 + num * 1.5 * Act.主消費影響値)).LimitM(0.0, 1.0);
			}
			Act.調教強制終了();
		}

		public static void 主精力消費中()
		{
			if (Act.加算前提)
			{
				double num = 0.01;
				Act.主精力 = (Act.主精力 - (num * 0.11 + num * 1.5 * Act.主消費影響値)).LimitM(0.0, 1.0);
			}
			Act.調教強制終了();
		}

		public static void 主精力消費小()
		{
			if (Act.加算前提)
			{
				double num = 0.0004;
				Act.主精力 = (Act.主精力 - (num * 0.11 + num * 1.5 * Act.主消費影響値)).LimitM(0.0, 1.0);
			}
			Act.調教強制終了();
		}

		public static double 奴消費影響値
		{
			get
			{
				return Act.調教力.Inverse() * Act.強靭0_7w * Act.傷物1_2w * Act.調教済0_9w * Sta.GameData.調教対象.消耗乗算値;
			}
		}

		public static void 奴体力消費大()
		{
			if (Act.加算前提)
			{
				double num = 0.02 * (1.0 - 0.6 * Act.調教力);
				Act.体力 = (Act.体力 - (num + num * ((Act.奴隷a + Act.抵抗値 + Act.緊張) / 3.0) * Act.奴消費影響値 + num * (Act.機械n ? Act.刺激値 : 0.0) * Act.奴消費影響値)).LimitM(0.0, 1.0);
				Act.調教強制終了();
			}
		}

		public static void 奴体力消費中()
		{
			if (Act.加算前提)
			{
				double num = 0.01 * (1.0 - 0.6 * Act.調教力);
				Act.体力 = (Act.体力 - (num + num * ((Act.奴隷a + Act.抵抗値 + Act.緊張) / 3.0) * Act.奴消費影響値 + num * (Act.機械n ? Act.刺激値 : 0.0) * Act.奴消費影響値)).LimitM(0.0, 1.0);
				Act.調教強制終了();
			}
		}

		public static void 奴体力消費小()
		{
			if (Act.加算前提)
			{
				double num = 0.0004 * (1.0 - 0.6 * Act.調教力);
				Act.体力 = (Act.体力 - (num + num * ((Act.奴隷a + Act.抵抗値 + Act.緊張) / 3.0) * Act.奴消費影響値 + num * (Act.機械n ? Act.刺激値 : 0.0) * Act.奴消費影響値)).LimitM(0.0, 1.0);
				Act.調教強制終了();
			}
		}

		public static double 主射精値
		{
			get
			{
				return (Act.主射精 + Act.主興奮) / 2.0;
			}
		}

		public static double 主興奮値
		{
			get
			{
				return (Act.主射精 + Act.主興奮 + Act.興奮) / 3.0;
			}
		}

		public static double 主アクション値
		{
			get
			{
				アクション情報 アクション情報 = Act.アクション情報n;
				if (アクション情報 != アクション情報.none)
				{
					switch (アクション情報)
					{
					case アクション情報.挿入:
						return 0.8 + ((Act.接触n == 接触.膣) ? Act.潤滑 : Act.興奮) * 0.2;
					case アクション情報.接触:
						return 0.25;
					case アクション情報.パイ:
						return 0.6;
					case アクション情報.手コ:
						return 0.35;
					case アクション情報.足コ:
						return 0.3;
					}
					return 0.0;
				}
				return 0.8;
			}
		}

		private static double 主感度興奮差
		{
			get
			{
				return (Act.主射精 - Act.主興奮).Abs().Inverse();
			}
		}

		public static double 主刺激値
		{
			get
			{
				return Act.主アクション値 * Act.主感度興奮差;
			}
		}

		public static void 主回復()
		{
			Act.主精力 = (Act.主精力 + ((Sta.GameData.祝福 != null) ? Sta.GameData.祝福.回復値 : 0.0)).LimitM(0.0, 1.0);
		}

		public static double 主感度確率
		{
			get
			{
				アクション情報 アクション情報 = Act.アクション情報n;
				double result;
				if (アクション情報 != アクション情報.none)
				{
					switch (アクション情報)
					{
					case アクション情報.挿入:
						return 0.2;
					case アクション情報.接触:
						return 0.2;
					case アクション情報.パイ:
						if (Act.パイズリRun)
						{
							return 0.6;
						}
						return 0.2;
					case アクション情報.手コ:
						return 0.6;
					case アクション情報.足コ:
						return 0.6;
					}
					result = 0.0;
				}
				else
				{
					result = 1.0;
				}
				return result;
			}
		}

		public static void 主感度加算()
		{
			double num = 0.0025;
			double num2 = 0.0095 - num;
			Act.主人ao = Act.主人a;
			Act.主人a = num + num2 * Act.主刺激値 * Act.主射精値 * Act.技巧度影響値;
			if (Act.主感度確率.Lot())
			{
				Act.主射精 = (Act.主射精 + Act.主人a).LimitM(0.0, 1.0);
			}
		}

		public static void 主感度減算()
		{
			double num = 0.0003;
			Act.主射精 = (Act.主射精 - (num + Act.主人a * Act.主射精 * Act.主興奮.Inverse() * Act.技巧度影響値.Inverse())).LimitM(0.0, 1.0);
		}

		public static void 主興奮計算()
		{
			double num = 0.0025;
			double num2 = 0.05 - num;
			Act.主興奮 = (Act.主興奮 + (Act.主射精 - Act.主興奮) * (num + num2 * Act.主興奮値 * Act.技巧度影響値)).LimitM(0.0, 1.0);
		}

		public static void 主興奮計算2()
		{
			if (Act.興奮 > Act.主興奮)
			{
				double num = 0.0025;
				double num2 = 0.05 - num;
				Act.主興奮 = (Act.主興奮 + (Act.興奮 - Act.主興奮) * (num + num2 * Act.主興奮値 * Act.技巧度影響値)).LimitM(0.0, 1.0);
			}
		}

		public static double 感度値
		{
			get
			{
				return (Act.感度 + Act.興奮 + Act.緊張.Inverse() + Act.羞恥) / 4.0 * Act.欲望度 * Act.情愛度 * Act.発情1_5w * Act.調教済1_1w * Act.目隠帯補正増;
			}
		}

		public static double 興奮値
		{
			get
			{
				return (Act.感度 + Act.興奮 + Act.主興奮 + Act.羞恥) / 4.0 * Act.欲望度 * Act.発情1_5w * Act.調教済1_1w * Act.拘束具補正増 * Act.玉口枷補正増;
			}
		}

		public static double 潤滑値
		{
			get
			{
				return (Act.感度 + Act.興奮) / 2.0 * Act.欲望度 * Act.情愛度 * Act.処女0_8w * Act.発情1_5w * Act.調教済1_1w;
			}
		}

		public static double 緊張値
		{
			get
			{
				return (Act.感度 + Act.緊張.Inverse() + Act.羞恥.Inverse()) / 3.0 * Act.欲望度 * Act.情愛度 * Act.処女0_8w * Act.傷物0_8w * Act.調教済1_1w * Act.拘束具補正減 * Act.目隠帯補正減;
			}
		}

		public static double 羞恥値
		{
			get
			{
				return (Act.感度 + Act.興奮 + Act.主興奮 + Act.羞恥 + Act.Cha.Bod.くぱぁ0) / 5.0 * Act.情愛度 * Act.無毛1_5w * Act.処女1_5w * Act.発情0_5w * Act.調教済1_1w * Act.目隠帯補正減 * Act.玉口枷補正増;
			}
		}

		public static double 奉仕補正
		{
			get
			{
				if (Act.パイズリRun || Act.フェラRun)
				{
					return 1.0 - 0.5 * (Act.技巧度 / Sta.GameData.調教対象.技巧最大値);
				}
				return 1.0;
			}
		}

		public static double 性感補正値
		{
			get
			{
				double num = 0.4;
				switch (Act.接触n)
				{
				case 接触.耳:
					return num * 0.6;
				case 接触.口:
					return num * 0.5;
				case 接触.首:
					return num * 0.65;
				case 接触.胸:
					return num * 0.6;
				case 接触.乳:
					return num * 0.7;
				case 接触.脇:
					return num * 0.4;
				case 接触.腹:
					return num * 0.2;
				case 接触.股:
					return num * 0.65;
				case 接触.性:
					return num * 0.9;
				case 接触.膣:
					return num * 0.85;
				case 接触.核:
					return num * 1.1;
				case 接触.肛:
					return num * 0.8;
				case 接触.腿:
					return num * 0.4;
				case 接触.覚:
					return num * 1.1;
				}
				return 0.0;
			}
		}

		public static double 部位値
		{
			get
			{
				double num = 0.0;
				if (Act.接触n != 接触.none)
				{
					num = Act.部位感度[Act.接触n];
				}
				return (num + Act.性感補正値).LimitM(0.0, 1.0);
			}
		}

		public static double アクション値
		{
			get
			{
				switch (Act.アクション情報n)
				{
				case アクション情報.乳摘:
					return 0.65;
				case アクション情報.乳繰:
					return 0.7;
				case アクション情報.乳捏:
					return 0.6;
				case アクション情報.核捏:
					return 0.75;
				case アクション情報.挿入:
					return 0.8 + ((Act.接触n == 接触.膣) ? Act.潤滑 : Act.興奮) * 0.2;
				case アクション情報.接触:
					return 0.25;
				case アクション情報.鞭打:
					return 1.0;
				case アクション情報.剃り:
					return 0.15;
				case アクション情報.擽り:
					return 0.3;
				case アクション情報.くぱ:
					return 0.1;
				case アクション情報.パイ:
					return 0.6;
				case アクション情報.吸引:
					return 0.5;
				case アクション情報.舐り:
					return 0.45;
				}
				return 0.0;
			}
		}

		public static double アイテム値
		{
			get
			{
				switch (Act.アイテム情報n)
				{
				case アイテム情報.ハンド:
					return 0.2;
				case アイテム情報.マウス:
					return 0.3;
				case アイテム情報.ペニス:
					return 0.4;
				case アイテム情報.ディル:
					return 0.35;
				case アイテム情報.コモン:
					return 0.45;
				case アイテム情報.ドリル:
					return 0.5;
				case アイテム情報.デンマ:
					return 0.9;
				case アイテム情報.アナル:
					if (Act.接触n != 接触.肛)
					{
						return 0.35;
					}
					return 0.7;
				case アイテム情報.ロ\u30FCタ:
					return 0.3;
				case アイテム情報.パ\u30FCル:
					if (Act.接触n != 接触.肛)
					{
						return 0.2;
					}
					return 0.4;
				case アイテム情報.調教鞭:
					return 1.0;
				case アイテム情報.羽根箒:
					return 0.25;
				case アイテム情報.Ｔ剃刀:
					return 0.1;
				case アイテム情報.キャプ:
					return 0.3;
				default:
					return 0.0;
				}
			}
		}

		public static double 慣れ値
		{
			get
			{
				double num = 0.5.Sqrt();
				double num2 = 1.0 - num;
				return (num + num2 * Act.奴隷接触慣れ.Inverse()) * (num + num2 * Act.奴隷アクション慣れ.Inverse());
			}
		}

		private static double 感度興奮差
		{
			get
			{
				return (Act.感度 - Act.興奮).Abs().Inverse();
			}
		}

		public static double 刺激値
		{
			get
			{
				return Act.部位値 * Act.慣れ値 * Act.アイテム値 * Act.アクション値 * (double)Act.強さn * Act.感度興奮差 * Act.発情1_5w;
			}
		}

		public static double 拘束具補正増
		{
			get
			{
				if (!Act.Cha.Bod.拘束具_表示)
				{
					return 1.0;
				}
				return 1.3;
			}
		}

		public static double 拘束具補正減
		{
			get
			{
				if (!Act.Cha.Bod.拘束具_表示)
				{
					return 1.0;
				}
				return 1.3.Reciprocal();
			}
		}

		public static double 目隠帯補正増
		{
			get
			{
				if (!Act.Cha.Bod.目隠帯_表示)
				{
					return 1.0;
				}
				return 1.3;
			}
		}

		public static double 目隠帯補正減
		{
			get
			{
				if (!Act.Cha.Bod.目隠帯_表示)
				{
					return 1.0;
				}
				return 1.3.Reciprocal();
			}
		}

		public static double 玉口枷補正増
		{
			get
			{
				if (!Act.Cha.Bod.玉口枷_表示)
				{
					return 1.0;
				}
				return 1.3;
			}
		}

		public static double 玉口枷補正減
		{
			get
			{
				if (!Act.Cha.Bod.玉口枷_表示)
				{
					return 1.0;
				}
				return 1.3.Reciprocal();
			}
		}

		public static void 回復()
		{
			Act.体力 = (Act.体力 + Sta.GameData.調教対象.回復値).LimitM(0.0, 1.0);
		}

		public static void 慣れ計算()
		{
			double num = 0.0001;
			double num2 = 0.0005 - num;
			if (Act.接触o == Act.接触n && Act.強さo == Act.強さn)
			{
				Act.奴隷接触慣れ = (Act.奴隷接触慣れ + (num + num2 * Act.Cha.ChaD.固有値 * Act.調教力.Inverse())).LimitM(0.0, 1.0);
			}
			else
			{
				Act.奴隷接触慣れ = 0.0;
			}
			if (Act.アクション情報o == Act.アクション情報n && Act.強さo == Act.強さn)
			{
				Act.奴隷アクション慣れ = (Act.奴隷アクション慣れ + (num + num2 * Act.Cha.ChaD.固有値 * Act.調教力.Inverse())).LimitM(0.0, 1.0);
				return;
			}
			Act.奴隷アクション慣れ = 0.0;
		}

		public static double 奴感度確率
		{
			get
			{
				switch (Act.アクション情報n)
				{
				case アクション情報.乳摘:
					return 0.3;
				case アクション情報.乳繰:
					return 0.35;
				case アクション情報.乳捏:
					return 0.3;
				case アクション情報.核捏:
					return 0.4;
				case アクション情報.挿入:
					return 0.3;
				case アクション情報.接触:
					return 0.2 * Act.感度.Inverse().Pow(2.0);
				case アクション情報.鞭打:
					return 1.0;
				case アクション情報.剃り:
					return 0.2 * Act.感度.Inverse().Pow(2.0);
				case アクション情報.擽り:
					return 0.6 * Act.感度.Inverse().Pow(2.0);
				case アクション情報.くぱ:
					return 0.2;
				case アクション情報.パイ:
					if (Act.パイズリRun)
					{
						return 0.6;
					}
					return 0.2;
				case アクション情報.吸引:
					return 0.6;
				case アクション情報.舐り:
					return 0.6;
				}
				return 0.0;
			}
		}

		public static void 感度加算()
		{
			double num = 0.0025;
			double num2 = 0.005 - num;
			Act.奴隷ao = Act.奴隷a;
			Act.奴隷a = num + num2 * Act.刺激値 * Act.感度値 * Act.調教力影響値;
			if (Act.機械n)
			{
				Act.奴隷a *= (Act.抵抗値 * Act.調教力影響値.Inverse()).Inverse();
			}
			Act.奴隷a -= Act.奴隷a * Act.感度 * (Act.抵抗値 + Act.緊張) * Act.調教力.Inverse();
			if (Act.奴感度確率.Lot())
			{
				Act.感度 = (Act.感度 + Act.奴隷a * Act.奉仕補正).LimitM(0.0, 1.0);
			}
		}

		public static void 感度減算()
		{
			double num = 0.0003;
			Act.感度 = (Act.感度 - (num + Act.奴隷a * Act.感度 * Act.興奮.Inverse() * Act.調教力影響値.Inverse())).LimitM(0.0, 1.0);
		}

		public static void 興奮計算()
		{
			double num = 0.0025;
			double num2 = 0.05 - num;
			Act.興奮 = (Act.興奮 + (Act.感度 - Act.興奮) * (num + num2 * Act.興奮値 * Act.調教力影響値)).LimitM(0.0, 1.0);
		}

		public static void 興奮計算2()
		{
			if (Act.主興奮 > Act.興奮)
			{
				double num = 0.0025;
				double num2 = 0.05 - num;
				Act.興奮 = (Act.興奮 + (Act.主興奮 - Act.興奮) * (num + num2 * Act.興奮値 * Act.調教力影響値)).LimitM(0.0, 1.0);
			}
		}

		public static void 潤滑計算()
		{
			double num = 2E-05;
			double num2 = 0.3 - num;
			if (Act.接触n == 接触.膣 && Act.アクション情報n == アクション情報.挿入)
			{
				Act.潤滑 = (Act.潤滑 + (0.0005 + num2 * Act.奴隷a * Act.潤滑値)).LimitM(0.0, 1.0);
			}
			Act.潤滑 = (Act.潤滑 + (num + num2 * Act.奴隷a * Act.潤滑値)).LimitM(0.0, 1.0);
		}

		public static bool 苦痛条件(this Cha c)
		{
			return (Act.機械n && c.ChaD.欲望度 < 0.5 && c.ChaD.情愛度 < 0.5) || (Act.アクション情報n == アクション情報.鞭打 && c.ChaD.欲望度 < 0.65) || (Act.アクション情報n == アクション情報.挿入 && (c.ChaD.潤滑 < 0.5 || Act.処女 || (Act.接触n != 接触.none && c.ChaD.部位感度[Act.接触n] < 0.5)));
		}

		public static void 緊張計算()
		{
			double num = 1E-05;
			double num2 = 0.3 - num;
			if (0.5.Lot())
			{
				Act.緊張 = (Act.緊張 + 2E-05 * Act.抵抗値).LimitM(0.0, 1.0);
			}
			if (Act.Cha.苦痛条件())
			{
				Act.緊張 = (Act.緊張 + (num + num2 * Act.奴隷a * Act.緊張値.Inverse() * Act.調教力影響値.Inverse())).LimitM(0.0, 1.0);
			}
			else if (Act.アクション情報n == アクション情報.擽り)
			{
				Act.緊張 = (Act.緊張 - (num + num2 * Act.奴隷a * Act.緊張値 * Act.調教力影響値 * 4.5) * ((Act.アイテム情報n == アイテム情報.羽根箒) ? 2.0 : 1.0)).LimitM(0.0, 1.0);
			}
			if (Act.アイテム情報n == アイテム情報.ハンド || Act.アイテム情報n == アイテム情報.マウス || Act.アイテム情報n == アイテム情報.ペニス)
			{
				Act.緊張 = (Act.緊張 - (num + num2 * Act.奴隷a * Act.緊張値 * Act.調教力影響値 * 0.5)).LimitM(0.0, 1.0);
			}
		}

		public static void 羞恥計算()
		{
			double num = 7.5E-05;
			double num2 = 0.4 - num;
			if (Act.アクション情報n == アクション情報.くぱ)
			{
				Act.羞恥 = (Act.羞恥 + (num + num2 * Act.奴隷a * Act.羞恥値 * Act.調教力影響値 * OthN.XS.NextDouble())).LimitM(0.0, 1.0);
			}
			else if (Act.アクション情報n == アクション情報.剃り)
			{
				Act.羞恥 = (Act.羞恥 + (num + num2 * Act.奴隷a * Act.羞恥値 * Act.調教力影響値 * Act.現陰毛 * 4.0)).LimitM(0.0, 1.0);
			}
			Act.羞恥 = (Act.羞恥 + (num + num2 * Act.奴隷a * Act.羞恥値 * Act.調教力影響値 * OthN.XS.NextDouble())).LimitM(0.0, 1.0);
		}

		public static void 調教力計算()
		{
			if (!Act.機械n)
			{
				double num = 1E-05;
				double num2 = 2E-05 - num;
				Act.調教力 = (Act.調教力 + (num + num2 * Act.奴隷a * Act.感度興奮差 * Act.調教力影響値)).LimitM(0.0, 1.0);
			}
		}

		public static void 部位計算()
		{
			if (Act.接触n != 接触.none)
			{
				Act.部位感度[Act.接触n] = (Act.部位感度[Act.接触n] + 0.015 * Act.奴隷a * Act.調教力影響値 * Act.発情1_5w * Act.調教済1_1w).LimitM(0.0, 1.0);
			}
			if (Act.Cha.Bod.玉口枷_表示 && Act.部位感度.ContainsKey(接触.口))
			{
				Act.部位感度[接触.口] = (Act.部位感度[接触.口] + 0.005 * Act.奴隷a * Act.調教力影響値 * Act.発情1_5w * Act.調教済1_1w).LimitM(0.0, 1.0);
			}
		}

		public static void 抵抗値計算()
		{
			Act.抵抗値 = (Act.抵抗値 - 0.02 * Act.奴隷a * Act.卑屈度 * Act.調教力影響値 * Act.処女0_8w * Act.発情1_5w * Act.傷物0_8w).LimitM(0.0, 1.0);
		}

		public static void 欲望度計算()
		{
			Act.欲望度 = (Act.欲望度 + 0.0075 * Act.奴隷a * Act.調教力影響値 * Act.処女0_8w * Act.発情1_5w * Act.調教済1_1w * Act.目隠帯補正増).LimitM(0.0, 1.0);
		}

		public static void 情愛度計算()
		{
			if (Act.アイテム情報n == アイテム情報.ハンド || Act.アイテム情報n == アイテム情報.マウス || Act.アイテム情報n == アイテム情報.ペニス || Act.情愛度 > 0.5)
			{
				Act.情愛度 = (Act.情愛度 + 0.015 * Act.奴隷a * Act.調教力影響値 * Act.処女1_5w * Act.傷物1_2w * Act.調教済1_1w * Act.拘束具補正減 * Act.目隠帯補正減 * Act.玉口枷補正減).LimitM(0.0, 1.0);
			}
		}

		public static void 卑屈度計算()
		{
			if (Act.アクション情報n == アクション情報.鞭打)
			{
				Act.卑屈度 = (Act.卑屈度 + 0.5 * Act.奴隷a * Act.調教力影響値 * Act.傷物1_2w * Act.拘束具補正増 * Act.玉口枷補正増).LimitM(0.0, 1.0);
			}
			if ((0.1 * OthN.XS.NextDouble() * Act.Cha.ChaD.固有値).Lot())
			{
				Act.卑屈度 = (Act.卑屈度 + 0.2 * Act.奴隷a * Act.調教力影響値 * Act.傷物1_2w * Act.拘束具補正増 * Act.玉口枷補正増).LimitM(0.0, 1.0);
			}
			Act.卑屈度 = (Act.卑屈度 + 0.0005 * Act.奴隷a * Act.調教力影響値 * Act.傷物1_2w * Act.拘束具補正増 * Act.玉口枷補正増).LimitM(0.0, 1.0);
			if (Act.接触n == 接触.肛)
			{
				Act.卑屈度 = (Act.卑屈度 + 0.0005 * Act.奴隷a * Act.調教力影響値 * Act.傷物1_2w * Act.拘束具補正増 * Act.玉口枷補正増).LimitM(0.0, 1.0);
			}
		}

		public static void 技巧度計算()
		{
			if ((Act.アクション情報n == アクション情報.挿入 && Act.アイテム情報n == アイテム情報.ペニス) || Act.アクション情報n == アクション情報.パイ || Act.アクション情報n == アクション情報.手コ || Act.アクション情報n == アクション情報.足コ)
			{
				Act.技巧度 = (Act.技巧度 + 0.0035 * Act.主人a * Act.調教力影響値).LimitM(0.0, Sta.GameData.調教対象.技巧最大値);
			}
		}

		public static void 絶頂部位計算()
		{
			if (Act.接触n != 接触.none)
			{
				Act.部位感度[Act.接触n] = (Act.部位感度[Act.接触n] + 0.03 * Act.奴隷a * Act.感度興奮差 * Act.調教力影響値 * Act.発情1_5w * Act.調教済1_1w * OthN.XS.NextDouble()).LimitM(0.0, 1.0);
			}
			if (Act.Cha.Bod.玉口枷_表示 && Act.部位感度.ContainsKey(接触.口))
			{
				Act.部位感度[接触.口] = (Act.部位感度[接触.口] + 0.01 * Act.奴隷a * Act.調教力影響値 * Act.発情1_5w * Act.調教済1_1w).LimitM(0.0, 1.0);
			}
		}

		public static void 絶頂抵抗値計算()
		{
			Act.抵抗値 = (Act.抵抗値 - 0.04 * Act.奴隷a * Act.感度興奮差 * Act.調教力影響値 * Act.処女0_8w * Act.発情1_5w * OthN.XS.NextDouble()).LimitM(0.0, 1.0);
		}

		public static void 絶頂欲望度計算()
		{
			Act.欲望度 = (Act.欲望度 + 0.015 * Act.奴隷a * Act.感度興奮差 * Act.調教力影響値 * Act.処女0_8w * Act.発情1_5w * Act.調教済1_1w * Act.目隠帯補正増 * OthN.XS.NextDouble()).LimitM(0.0, 1.0);
		}

		public static void 絶頂情愛度計算()
		{
			Act.情愛度 = (Act.情愛度 + 0.03 * Act.奴隷a * Act.感度興奮差 * Act.調教力影響値 * Act.処女1_5w * Act.発情1_5w * Act.傷物1_2w * Act.調教済1_1w * Act.拘束具補正減 * Act.目隠帯補正減 * Act.玉口枷補正減 * OthN.XS.NextDouble()).LimitM(0.0, 1.0);
		}

		public static void 絶頂卑屈度計算()
		{
			Act.卑屈度 = (Act.卑屈度 + 0.001 * Act.奴隷a * Act.感度興奮差 * Act.調教力影響値 * Act.傷物1_2w * Act.拘束具補正増 * Act.玉口枷補正増 * OthN.XS.NextDouble()).LimitM(0.0, 1.0);
		}

		public static void 絶頂技巧度計算()
		{
			if ((Act.アクション情報n == アクション情報.挿入 && Act.アイテム情報n == アイテム情報.ペニス) || Act.アクション情報n == アクション情報.パイ || Act.アクション情報n == アクション情報.手コ || Act.アクション情報n == アクション情報.足コ)
			{
				Act.技巧度 = (Act.技巧度 + 0.007 * Act.主人a * Act.主感度興奮差 * Act.調教力影響値 * OthN.XS.NextDouble()).LimitM(0.0, Sta.GameData.調教対象.技巧最大値);
			}
		}

		public static bool 奉仕0
		{
			get
			{
				return !Act.絶頂中 && !Act.Cha.Bod.Is拘束 && Act.抵抗値 == 0.0 && (Act.欲望度 > 0.5 || Act.情愛度 > 0.5 || Act.卑屈度 > 0.5);
			}
		}

		public static bool 奉仕1
		{
			get
			{
				return Act.抵抗値 == 0.0 && (Act.欲望度 > 0.5 || Act.情愛度 > 0.5 || Act.卑屈度 > 0.5);
			}
		}

		public static bool 手コキ
		{
			get
			{
				return Act.Cha.Bod.Is最前手人 && Act.奉仕0 && Act.技巧度 > 0.1 * Sta.GameData.調教対象.技巧最大値;
			}
		}

		public static bool 足コキ
		{
			get
			{
				return Act.奉仕0 && Act.技巧度 > 0.2 * Sta.GameData.調教対象.技巧最大値;
			}
		}

		public static bool パイズリ1
		{
			get
			{
				return Act.Cha.Bod.Is最前手人 && Act.奉仕0 && Act.技巧度 > 0.2 * Sta.GameData.調教対象.技巧最大値;
			}
		}

		public static bool パイズリ2
		{
			get
			{
				return Act.Cha.Bod.Is最前手人 && Act.奉仕0 && Act.技巧度 > 0.4 * Sta.GameData.調教対象.技巧最大値;
			}
		}

		public static bool パイズリ3
		{
			get
			{
				return Act.Cha.Bod.Is最前手人 && Act.奉仕0 && Act.技巧度 > 0.6 * Sta.GameData.調教対象.技巧最大値;
			}
		}

		public static bool フェラ1
		{
			get
			{
				return Act.奉仕1 && !Act.Cha.Bod.玉口枷_表示 && Act.技巧度 > 0.15 * Sta.GameData.調教対象.技巧最大値;
			}
		}

		public static bool フェラ2
		{
			get
			{
				return !Act.絶頂中 && Act.奉仕1 && !Act.Cha.Bod.玉口枷_表示 && Act.技巧度 > 0.5 * Sta.GameData.調教対象.技巧最大値 && Act.アイテム情報n == アイテム情報.ペニス;
			}
		}

		public static double 口挿入度
		{
			get
			{
				return (0.05 + Act.部位感度[接触.口] * Act.緊張.Inverse() * (Act.技巧度 / Sta.GameData.調教対象.技巧最大値)).Sqrt();
			}
		}

		public static double 膣挿入度
		{
			get
			{
				return (0.05 + Act.部位感度[接触.膣] * Act.緊張.Inverse() * Act.潤滑).Sqrt();
			}
		}

		public static double 肛挿入度
		{
			get
			{
				return (0.05 + Act.部位感度[接触.肛] * Act.緊張.Inverse()).Sqrt();
			}
		}

		public static double 糸挿入度
		{
			get
			{
				return (0.05 + Act.部位感度[接触.糸] * Act.緊張.Inverse()).Sqrt();
			}
		}

		public static bool 手口
		{
			get
			{
				return Act.口挿入度 >= 0.6;
			}
		}

		public static bool 手膣
		{
			get
			{
				return !Act.処女 && Act.膣挿入度 >= 0.6;
			}
		}

		public static bool 手肛
		{
			get
			{
				return Act.肛挿入度 >= 0.6;
			}
		}

		public static bool 手糸
		{
			get
			{
				return Act.糸挿入度 >= 0.6;
			}
		}

		public static void 表示ステ\u30FCト更新()
		{
			if (Sta.GameData.調教対象 != null)
			{
				Act.UI.体力sゲ\u30FCジ.Value = Act.体力;
				Act.UI.絶頂sゲ\u30FCジ.Value = Act.感度;
				Act.UI.興奮sゲ\u30FCジ.Value = Act.興奮;
				Act.UI.精力mゲ\u30FCジ.Value = Act.主精力;
				Act.UI.射精mゲ\u30FCジ.Value = Act.主射精;
				Act.UI.興奮mゲ\u30FCジ.Value = Act.主興奮;
				Act.Cha.Bod.下着B染み = Act.潤滑;
				Act.Cha.Bod.陰核勃起 = Act.興奮;
				Act.Cha.Bod.乳首勃起 = Act.興奮;
				Act.Cha.Bod.顔紅潮 = Act.興奮.Max(Act.羞恥);
				Act.Cha.Bod.体紅潮 = Act.興奮;
				Act.Cha.呼吸速度 = 0.2 + 0.8 * Act.興奮;
				if (Act.欲望度 > 0.5 && Act.情愛度 > 0.5)
				{
					Act.Cha.Bod.子宮下がり = Act.興奮;
				}
				if (Act.欲望度 > 0.5 && Act.部位感度[接触.肛] > 0.75)
				{
					Act.Cha.Bod.肛門開き = Act.興奮;
				}
				if (Act.欲望度 > 0.3)
				{
					if (!Act.UI.ハンド処理.Isくぱぁ && (!Act.UI.Is挿入 || Act.UI.ハンド左.Xi == 7))
					{
						Act.Cha.Bod.くぱぁ0 = Act.興奮;
					}
					if (!Act.Cha.ChaD.股施術 && (Act.Cha.Bod.Is蠍 || (Act.Cha.Bod.Is蛇 && Act.Cha.Bod.蛇.ガ\u30FCド)))
					{
						Act.Cha.Bod.くぱぁ1 = Act.興奮;
						if (Act.Cha.Bod.くぱぁ1 < 0.3)
						{
							Act.UI.くぱぁ閉じ時();
						}
					}
				}
				if (!Act.Cha.汗かき.Run && Act.欲望度 > 0.5 && Act.興奮 > 0.75)
				{
					Act.Cha.汗かき.Sta();
				}
				else if (Act.Cha.汗かき.Run && Act.興奮 < 0.4)
				{
					Act.Cha.汗かき.End();
				}
				if (Act.UI.ハンド処理.Isくぱぁ)
				{
					Act.UI.Set_くぱぁ(Act.UI.ハンド右, true);
					Act.UI.Set_くぱぁ(Act.UI.ハンド左, false);
				}
				if (Act.UI.ステ\u30FCト描画)
				{
					Act.UI.ステ\u30FCト.TextIm = string.Concat(new string[]
					{
						tex.体力,
						"/",
						Act.体力.Numf1(),
						"\r\n",
						tex.感度,
						"/",
						Act.感度.Numf1(),
						"\r\n",
						tex.興奮,
						"/",
						Act.興奮.Numf1(),
						"\r\n",
						tex.潤滑,
						"/",
						Act.潤滑.Numf1(),
						"\r\n",
						tex.緊張,
						"/",
						Act.緊張.Numf1(),
						"\r\n",
						tex.羞恥,
						"/",
						Act.羞恥.Numf1(),
						"\r\n\r\n",
						tex.抵抗値,
						"/",
						Act.抵抗値.Numf1(),
						"\r\n",
						tex.欲望度,
						"/",
						Act.欲望度.Numf1(),
						"\r\n",
						tex.情愛度,
						"/",
						Act.情愛度.Numf1(),
						"\r\n",
						tex.卑屈度,
						"/",
						Act.卑屈度.Numf1(),
						"\r\n",
						tex.技巧度,
						"/",
						Act.技巧度.Numf1()
					});
				}
			}
		}

		public static double 変化V_射精
		{
			get
			{
				return Act.主精力 * Act.主興奮;
			}
		}

		public static double 変化V_潮吹
		{
			get
			{
				return Math.Max(Act.欲望度, Act.感度 * Act.興奮);
			}
		}

		public static double 変化V_放尿
		{
			get
			{
				return Math.Max(Math.Max(Act.欲望度, Act.卑屈度), Act.興奮 * Act.羞恥.Inverse());
			}
		}

		public static double 変化V_口
		{
			get
			{
				return Act.口挿入度;
			}
		}

		public static double 変化V_膣
		{
			get
			{
				return Act.膣挿入度;
			}
		}

		public static double 変化V_肛
		{
			get
			{
				return Act.肛挿入度;
			}
		}

		public static double 変化V_糸
		{
			get
			{
				return Act.糸挿入度;
			}
		}

		public static double 変化V_固有値乱数
		{
			get
			{
				return Act.Cha.ChaD.固有値 * OthN.XS.NextDouble();
			}
		}

		public static double 無毛1_5w
		{
			get
			{
				if (!Act.無毛)
				{
					return 1.5 * Act.現陰毛.Inverse().LimitM(0.1, 1.0);
				}
				return 1.5;
			}
		}

		public static double 処女0_8w
		{
			get
			{
				if (!Act.処女)
				{
					return 1.0;
				}
				return 0.8;
			}
		}

		public static double 処女1_5w
		{
			get
			{
				if (!Act.処女)
				{
					return 1.0;
				}
				return 1.5;
			}
		}

		public static double 発情0_5w
		{
			get
			{
				if (!Act.発情)
				{
					return 1.0;
				}
				return 0.5;
			}
		}

		public static double 発情1_5w
		{
			get
			{
				if (!Act.発情)
				{
					return 1.0;
				}
				return 1.5;
			}
		}

		public static double 強靭0_7w
		{
			get
			{
				if (!Act.強靭)
				{
					return 1.0;
				}
				return 0.7;
			}
		}

		public static double 傷物0_8w
		{
			get
			{
				if (!Act.傷物)
				{
					return 1.0;
				}
				return 0.8;
			}
		}

		public static double 傷物1_2w
		{
			get
			{
				if (!Act.傷物)
				{
					return 1.0;
				}
				return 1.2;
			}
		}

		public static double 調教済0_9w
		{
			get
			{
				if (!Act.調教済)
				{
					return 1.0;
				}
				return 0.9;
			}
		}

		public static double 調教済1_1w
		{
			get
			{
				if (!Act.調教済)
				{
					return 1.0;
				}
				return 1.1;
			}
		}

		public static void ShowInfo()
		{
			if (Sta.GameData.調教対象 != null && Act.Cha != null)
			{
				MyC.Text = (string.Concat(new object[]
				{
					tex.体力,
					" / ",
					Act.体力.RoundDown(3),
					"\r\n",
					tex.感度,
					" / ",
					Act.感度.RoundDown(3),
					"\r\n",
					tex.興奮,
					" / ",
					Act.興奮.RoundDown(3),
					"\r\n",
					tex.潤滑,
					" / ",
					Act.潤滑.RoundDown(3),
					"\r\n",
					tex.緊張,
					" / ",
					Act.緊張.RoundDown(3),
					"\r\n",
					tex.羞恥,
					" / ",
					Act.羞恥.RoundDown(3),
					"\r\n\r\n",
					tex.抵抗値,
					" / ",
					Act.抵抗値.RoundDown(3),
					"\r\n",
					tex.欲望度,
					" / ",
					Act.欲望度.RoundDown(3),
					"\r\n",
					tex.情愛度,
					" / ",
					Act.情愛度.RoundDown(3),
					"\r\n",
					tex.卑屈度,
					" / ",
					Act.卑屈度.RoundDown(3),
					"\r\n",
					tex.技巧度,
					" / ",
					Act.技巧度.RoundDown(3),
					"\r\n"
				}) ?? "");
			}
		}

		public static double 否定_(this Cha c)
		{
			return c.ChaD.抵抗値;
		}

		public static double 屈辱_(this Cha c)
		{
			return c.ChaD.感度 * c.ChaD.抵抗値 * c.ChaD.卑屈度;
		}

		public static double 羞恥_(this Cha c)
		{
			return c.ChaD.羞恥;
		}

		public static double 受容_(this Cha c)
		{
			return c.ChaD.緊張.Inverse() * c.ChaD.抵抗値.Inverse() * c.ChaD.情愛度;
		}

		public static double 欲望_(this Cha c)
		{
			return c.ChaD.緊張.Inverse() * c.ChaD.抵抗値.Inverse() * c.ChaD.欲望度;
		}

		public static double 興奮_(this Cha c)
		{
			return c.ChaD.緊張.Inverse() * c.ChaD.抵抗値.Inverse() * c.ChaD.興奮 * c.ChaD.欲望度;
		}

		public static double 余裕_(this Cha c)
		{
			return c.ChaD.緊張.Inverse() * c.ChaD.体力 * c.ChaD.感度.Inverse() * c.ChaD.卑屈度.Inverse() * c.ChaD.技巧度;
		}

		public static double 幸福_(this Cha c)
		{
			return c.ChaD.緊張.Inverse() * c.ChaD.抵抗値.Inverse() * c.ChaD.緊張.Inverse() * c.ChaD.情愛度;
		}

		public static double 喜悦_(this Cha c)
		{
			return c.ChaD.緊張.Inverse() * c.ChaD.抵抗値.Inverse() * c.ChaD.感度 * c.ChaD.情愛度 * c.ChaD.欲望度;
		}

		public static double 淫乱_(this Cha c)
		{
			return c.ChaD.緊張.Inverse() * c.ChaD.抵抗値.Inverse() * c.ChaD.感度 * c.ChaD.興奮 * c.ChaD.欲望度 * c.ChaD.卑屈度;
		}

		public static double 其他_(this Cha c)
		{
			return 0.2;
		}

		public static void 情動(this Cha c)
		{
			switch (c.ChaD.状態)
			{
			case 感情.none:
				switch (Oth.GetRandomIndex(new double[]
				{
					c.否定_(),
					c.屈辱_(),
					c.羞恥_(),
					c.受容_(),
					c.欲望_(),
					c.興奮_(),
					c.余裕_(),
					c.幸福_(),
					c.喜悦_(),
					c.淫乱_(),
					c.其他_()
				}))
				{
				case 0:
					c.ChaD.状態 = 感情.否定;
					break;
				case 1:
					c.ChaD.状態 = 感情.屈辱;
					break;
				case 2:
					c.ChaD.状態 = 感情.羞恥;
					break;
				case 3:
					c.ChaD.状態 = 感情.受容;
					break;
				case 4:
					c.ChaD.状態 = 感情.欲望;
					break;
				case 5:
					c.ChaD.状態 = 感情.興奮;
					break;
				case 6:
					c.ChaD.状態 = 感情.余裕;
					break;
				case 7:
					c.ChaD.状態 = 感情.幸福;
					break;
				case 8:
					c.ChaD.状態 = 感情.喜悦;
					break;
				case 9:
					c.ChaD.状態 = 感情.淫乱;
					break;
				case 10:
					c.ChaD.状態 = 感情.其他;
					break;
				}
				break;
			case 感情.否定:
				switch (Oth.GetRandomIndex(new double[]
				{
					c.否定_(),
					c.屈辱_(),
					c.羞恥_(),
					c.喜悦_()
				}))
				{
				case 0:
					c.ChaD.状態 = 感情.否定;
					break;
				case 1:
					c.ChaD.状態 = 感情.屈辱;
					break;
				case 2:
					c.ChaD.状態 = 感情.羞恥;
					break;
				case 3:
					c.ChaD.状態 = 感情.喜悦;
					break;
				}
				break;
			case 感情.屈辱:
				switch (Oth.GetRandomIndex(new double[]
				{
					c.否定_(),
					c.屈辱_(),
					c.羞恥_(),
					c.興奮_()
				}))
				{
				case 0:
					c.ChaD.状態 = 感情.否定;
					break;
				case 1:
					c.ChaD.状態 = 感情.屈辱;
					break;
				case 2:
					c.ChaD.状態 = 感情.羞恥;
					break;
				case 3:
					c.ChaD.状態 = 感情.興奮;
					break;
				}
				break;
			case 感情.羞恥:
				switch (Oth.GetRandomIndex(new double[]
				{
					c.屈辱_(),
					c.羞恥_(),
					c.興奮_()
				}))
				{
				case 0:
					c.ChaD.状態 = 感情.屈辱;
					break;
				case 1:
					c.ChaD.状態 = 感情.羞恥;
					break;
				case 2:
					c.ChaD.状態 = 感情.興奮;
					break;
				}
				break;
			case 感情.受容:
				switch (Oth.GetRandomIndex(new double[]
				{
					c.羞恥_(),
					c.受容_(),
					c.欲望_(),
					c.興奮_(),
					c.余裕_()
				}))
				{
				case 0:
					c.ChaD.状態 = 感情.羞恥;
					break;
				case 1:
					c.ChaD.状態 = 感情.受容;
					break;
				case 2:
					c.ChaD.状態 = 感情.欲望;
					break;
				case 3:
					c.ChaD.状態 = 感情.興奮;
					break;
				case 4:
					c.ChaD.状態 = 感情.余裕;
					break;
				}
				break;
			case 感情.欲望:
				switch (Oth.GetRandomIndex(new double[]
				{
					c.受容_(),
					c.欲望_(),
					c.興奮_(),
					c.喜悦_(),
					c.淫乱_()
				}))
				{
				case 0:
					c.ChaD.状態 = 感情.受容;
					break;
				case 1:
					c.ChaD.状態 = 感情.欲望;
					break;
				case 2:
					c.ChaD.状態 = 感情.興奮;
					break;
				case 3:
					c.ChaD.状態 = 感情.喜悦;
					break;
				case 4:
					c.ChaD.状態 = 感情.淫乱;
					break;
				}
				break;
			case 感情.興奮:
				switch (Oth.GetRandomIndex(new double[]
				{
					c.羞恥_(),
					c.欲望_(),
					c.興奮_(),
					c.喜悦_(),
					c.淫乱_()
				}))
				{
				case 0:
					c.ChaD.状態 = 感情.羞恥;
					break;
				case 1:
					c.ChaD.状態 = 感情.欲望;
					break;
				case 2:
					c.ChaD.状態 = 感情.興奮;
					break;
				case 3:
					c.ChaD.状態 = 感情.喜悦;
					break;
				case 4:
					c.ChaD.状態 = 感情.淫乱;
					break;
				}
				break;
			case 感情.余裕:
				switch (Oth.GetRandomIndex(new double[]
				{
					c.受容_(),
					c.欲望_(),
					c.興奮_(),
					c.余裕_(),
					c.幸福_()
				}))
				{
				case 0:
					c.ChaD.状態 = 感情.受容;
					break;
				case 1:
					c.ChaD.状態 = 感情.欲望;
					break;
				case 2:
					c.ChaD.状態 = 感情.興奮;
					break;
				case 3:
					c.ChaD.状態 = 感情.余裕;
					break;
				case 4:
					c.ChaD.状態 = 感情.幸福;
					break;
				}
				break;
			case 感情.幸福:
				switch (Oth.GetRandomIndex(new double[]
				{
					c.受容_(),
					c.欲望_(),
					c.余裕_(),
					c.幸福_(),
					c.喜悦_()
				}))
				{
				case 0:
					c.ChaD.状態 = 感情.受容;
					break;
				case 1:
					c.ChaD.状態 = 感情.欲望;
					break;
				case 2:
					c.ChaD.状態 = 感情.余裕;
					break;
				case 3:
					c.ChaD.状態 = 感情.幸福;
					break;
				case 4:
					c.ChaD.状態 = 感情.喜悦;
					break;
				}
				break;
			case 感情.喜悦:
				switch (Oth.GetRandomIndex(new double[]
				{
					c.羞恥_(),
					c.受容_(),
					c.欲望_(),
					c.興奮_(),
					c.幸福_(),
					c.喜悦_(),
					c.淫乱_()
				}))
				{
				case 0:
					c.ChaD.状態 = 感情.羞恥;
					break;
				case 1:
					c.ChaD.状態 = 感情.受容;
					break;
				case 2:
					c.ChaD.状態 = 感情.欲望;
					break;
				case 3:
					c.ChaD.状態 = 感情.興奮;
					break;
				case 4:
					c.ChaD.状態 = 感情.幸福;
					break;
				case 5:
					c.ChaD.状態 = 感情.喜悦;
					break;
				case 6:
					c.ChaD.状態 = 感情.淫乱;
					break;
				}
				break;
			case 感情.淫乱:
				switch (Oth.GetRandomIndex(new double[]
				{
					c.屈辱_(),
					c.羞恥_(),
					c.欲望_(),
					c.興奮_(),
					c.幸福_(),
					c.喜悦_(),
					c.淫乱_()
				}))
				{
				case 0:
					c.ChaD.状態 = 感情.屈辱;
					break;
				case 1:
					c.ChaD.状態 = 感情.羞恥;
					break;
				case 2:
					c.ChaD.状態 = 感情.欲望;
					break;
				case 3:
					c.ChaD.状態 = 感情.興奮;
					break;
				case 4:
					c.ChaD.状態 = 感情.幸福;
					break;
				case 5:
					c.ChaD.状態 = 感情.喜悦;
					break;
				case 6:
					c.ChaD.状態 = 感情.淫乱;
					break;
				}
				break;
			case 感情.其他:
				switch (Oth.GetRandomIndex(new double[]
				{
					c.羞恥_(),
					c.受容_(),
					c.余裕_(),
					c.幸福_(),
					c.其他_()
				}))
				{
				case 0:
					c.ChaD.状態 = 感情.羞恥;
					break;
				case 1:
					c.ChaD.状態 = 感情.受容;
					break;
				case 2:
					c.ChaD.状態 = 感情.余裕;
					break;
				case 3:
					c.ChaD.状態 = 感情.幸福;
					break;
				case 4:
					c.ChaD.状態 = 感情.其他;
					break;
				}
				break;
			}
			if (c.苦痛条件())
			{
				c.ChaD.状態 = 感情.屈辱;
			}
			if (c.放尿.Run)
			{
				c.ChaD.状態 = 感情.羞恥;
			}
		}

		public static void 待機状態0()
		{
			if (0.02.Lot())
			{
				Act.待機状態1();
			}
		}

		public static void 待機状態1()
		{
			if ((Act.興奮.Inverse() * 0.05).Lot())
			{
				Act.Cha.泣き = false;
			}
			if (Act.Cha.Bod.Is初期腰)
			{
				Act.Cha.Bod.Set腰();
			}
			Act.Cha.情動();
			Act.Cha.Set表情変化();
			Act.Cha.Set姿勢変化();
		}

		public static void 入力反応0()
		{
			if (Act.Cha != null && Act.Cha.目_追い.Run)
			{
				Act.Cha.目_追い.End();
			}
			if (Act.処女 && Act.アクション情報n == アクション情報.挿入 && (Act.アイテム情報n == アイテム情報.ペニス || Act.アイテム情報n == アイテム情報.ディル || Act.アイテム情報n == アイテム情報.コモン || Act.アイテム情報n == アイテム情報.ドリル || Act.アイテム情報n == アイテム情報.デンマ || Act.アイテム情報n == アイテム情報.アナル) && Act.接触n == 接触.膣 && Act.挿入Lvn > 2)
			{
				Act.入力反応2();
				Act.Cha.Bod.腰.位置B += Oth.GetRandomVector() * 0.0004;
				Act.Cha.Bod.腰振りv = OthN.XS.NextDouble();
				int num = OthN.XS.Next(2);
				if (num != 0)
				{
					if (num == 1)
					{
						Act.Cha.ChaD.状態 = 感情.羞恥;
					}
				}
				else
				{
					Act.Cha.ChaD.状態 = 感情.屈辱;
				}
				Act.Cha.Set表情初期化();
				Act.Cha.Set姿勢変化();
				Act.処女 = false;
				Sta.GameData.調教対象.処女フラグ = false;
				Act.UI.発音(Act.Cha.Bod.膣口位置.GetAreaPoint(0.04), Sta.処女喪失, Color.Red, 0.3, true);
				Act.Cha.Bod.処女喪失 = true;
				if (Act.Cha.Bod.断面_表示)
				{
					Act.Cha.Bod.膣内精液.血液1_表示 = true;
					Act.Cha.Bod.膣内精液.血液2_表示 = true;
				}
				Act.Cha.Bod.性器精液.血液1_表示 = true;
				Act.Cha.Bod.性器精液.血液2_表示 = true;
				Act.Cha.Bod.性器精液.血液濃度 = 0.0;
				Act.発声();
				return;
			}
			if (!Act.射精n && (Act.初回 || Act.タイミング情報n == タイミング情報.開始 || Act.アクション情報n == アクション情報.鞭打 || (Act.接触n == 接触.膣 && Act.アクション情報n == アクション情報.挿入 && Act.挿入Lvn == (int)(5.0 * Act.Cha.ChaD.固有値) && 0.2.Lot())))
			{
				Act.入力反応1();
				Act.初回 = false;
				return;
			}
			if (Act.反応度 > 0.0)
			{
				if ((Act.反応度 * 0.25).Lot())
				{
					Act.入力反応1();
				}
				Act.反応度 = (Act.反応度 - 0.05).LimitM(0.0, 1.0);
				return;
			}
			if ((0.02 + 0.03 * Act.感度).Lot())
			{
				Act.入力反応1();
				return;
			}
			if (Act.タイミング情報n == タイミング情報.終了)
			{
				Act.待機状態1();
				Act.初回 = true;
				Act.反応度 = 1.0;
				if (Act.アクション情報n == アクション情報.挿入 && Act.接触n == 接触.口 && Act.技巧度 < 0.5 * Sta.GameData.調教対象.技巧最大値 && Rea.舌可能.Contains(Act.Cha.Bod.口i) && ((Act.アイテム情報n == アイテム情報.ハンド && Act.手口) || Act.アイテム情報n == アイテム情報.ペニス || Act.アイテム情報n == アイテム情報.ディル || Act.アイテム情報n == アイテム情報.コモン || Act.アイテム情報n == アイテム情報.ドリル || Act.アイテム情報n == アイテム情報.デンマ || Act.アイテム情報n == アイテム情報.アナル) && (Act.技巧度.Inverse() * 0.8).Lot())
				{
					Act.Cha.咳込み.Sta();
					return;
				}
				Act.Cha.Set表情初期化();
				Act.Cha.口();
			}
		}

		public static void 入力反応1()
		{
			Act.入力反応2();
			Act.Cha.Bod.腰.位置B += Oth.GetRandomVector() * 0.0004;
			Act.Cha.Bod.腰振りv = OthN.XS.NextDouble();
			Act.Cha.情動();
			Act.Cha.Set表情変化();
			Act.Cha.Set姿勢変化();
			if (Act.Cha.苦痛条件())
			{
				if (0.7.Lot())
				{
					if (Act.Cha.Bod.Is双眼)
					{
						Act.Cha.瞼_瞑左();
						Act.Cha.瞼_瞑右();
					}
					if (Act.Cha.Bod.Is単眼)
					{
						Act.Cha.単瞼_瞑();
					}
					if (Act.Cha.Bod.Is頬眼)
					{
						Act.Cha.頬瞼_瞑左();
						Act.Cha.頬瞼_瞑右();
					}
					if (Act.Cha.Bod.Is額眼)
					{
						Act.Cha.額瞼_瞑();
					}
				}
				else
				{
					if (Act.Cha.Bod.Is双眼)
					{
						Act.Cha.瞼_半2左();
						Act.Cha.瞼_半2右();
					}
					if (Act.Cha.Bod.Is単眼)
					{
						Act.Cha.単瞼_半2();
					}
					if (Act.Cha.Bod.Is頬眼)
					{
						Act.Cha.頬瞼_半2左();
						Act.Cha.頬瞼_半2右();
					}
					if (Act.Cha.Bod.Is額眼)
					{
						Act.Cha.額瞼_半2();
					}
				}
			}
			if (0.15.Lot() || Act.アクション情報n == アクション情報.鞭打 || Act.初回)
			{
				Act.発声();
			}
		}

		public static void 入力反応2()
		{
			if ((Act.情愛度 > 0.8 && Act.興奮 > 0.8 && (Act.興奮 * 0.04).Lot()) || (Act.Cha.苦痛条件() && (Act.興奮 * (double)Act.強さn * 0.013333333333333334).Lot()))
			{
				Act.Cha.泣き = true;
			}
			if (Act.アイテム情報n == アイテム情報.ハンド && Act.アクション情報n == アクション情報.接触 && Act.接触n == 接触.頭 && (Act.興奮.Inverse() * 0.04).Lot())
			{
				Act.Cha.泣き = false;
			}
			if ((Act.Cha.Bod.玉口枷_表示 && Act.感度.Lot()) || (Act.アクション情報n == アクション情報.挿入 && Act.接触n == 接触.口 && Act.感度 > 0.5 && Act.興奮 > 0.5 && Act.欲望度 > 0.8 && Act.感度.Lot() && ((Act.アイテム情報n == アイテム情報.ハンド && Act.手膣) || Act.アイテム情報n == アイテム情報.ペニス || Act.アイテム情報n == アイテム情報.ディル || Act.アイテム情報n == アイテム情報.コモン || Act.アイテム情報n == アイテム情報.ドリル || Act.アイテム情報n == アイテム情報.デンマ || Act.アイテム情報n == アイテム情報.アナル)))
			{
				Act.Cha.涎.Sta();
			}
			if (Act.体力 > 0.1 && Act.感度 > 0.5 && Act.潤滑 > 0.6 && Act.緊張 == 0.0 && Act.欲望度 > 0.7 && Act.情愛度 > 0.7 && (Act.興奮 * 0.05).Lot())
			{
				Act.Cha.潮吹小.Sta();
			}
			if (Act.アクション情報n == アクション情報.挿入 && Act.接触n == 接触.膣 && Act.感度 > 0.4 && Act.潤滑 == 1.0 && Act.欲望度 > 0.7 && Act.情愛度 > 0.7 && Act.感度.Lot() && ((Act.アイテム情報n == アイテム情報.ハンド && Act.手膣) || Act.アイテム情報n == アイテム情報.ペニス || Act.アイテム情報n == アイテム情報.ディル || Act.アイテム情報n == アイテム情報.コモン || Act.アイテム情報n == アイテム情報.ドリル || Act.アイテム情報n == アイテム情報.デンマ || Act.アイテム情報n == アイテム情報.アナル))
			{
				Act.Cha.飛沫.Sta();
			}
			if (Sta.GameData.調教対象.妊娠状態変数 > 2 && !Act.Cha.Bod.乳房左.虫性_甲殻_表示 && (Act.アクション情報n == アクション情報.乳捏 || Act.アクション情報n == アクション情報.パイ || ((double)Sta.GameData.調教対象.妊娠状態変数 * 0.1).Lot()))
			{
				Act.Cha.噴乳.Sta();
			}
			if (!Act.Cha.膣ヒク.Run && (Act.接触n == 接触.股 || Act.接触n == 接触.性 || Act.接触n == 接触.核 || Act.接触n == 接触.膣 || OthN.XS.NextBool()) && Act.部位感度[接触.膣] > 0.4)
			{
				Act.Cha.膣ヒク.Sta();
			}
			if (!Act.Cha.肛ヒク.Run && (Act.接触n == 接触.肛 || Act.接触n == 接触.膣 || OthN.XS.NextBool()) && Act.部位感度[接触.肛] > 0.4)
			{
				Act.Cha.肛ヒク.Sta();
			}
			if (!Act.Cha.糸ヒク.Run && (Act.接触n == 接触.糸 || OthN.XS.NextBool()))
			{
				Act.Cha.糸ヒク.Sta();
			}
		}

		public static void 発声()
		{
			int num;
			if (Act.接触n == 接触.口)
			{
				num = 4;
			}
			else if (Act.Cha.苦痛条件())
			{
				num = 0;
			}
			else
			{
				double num2 = (Act.緊張 + Act.抵抗値) * 0.5;
				num = 1 + Oth.GetRandomIndex(new double[]
				{
					(Act.羞恥 + Act.緊張 + Act.卑屈度 + Act.抵抗値) / 4.0,
					(Act.感度 + Act.情愛度 + Act.欲望度) / 3.0 - num2,
					(Act.感度 + Act.興奮 + Act.情愛度 + Act.欲望度 + Act.卑屈度) / 5.0 - num2
				});
			}
			string s;
			if (Act.Cha.Bod.口i == 4 || Act.Cha.Bod.口i == 10 || Act.Cha.Bod.口i == 11)
			{
				string[][] array = Sta.n;
				s = array[num][OthN.XS.Next(array[num].Length)];
			}
			else if (Act.Cha.Bod.玉口枷_表示)
			{
				s = Sta.o[3][OthN.XS.Next(Sta.o[3].Length)];
			}
			else
			{
				string[][] array;
				do
				{
					array = Act.GetRandomTable();
				}
				while (array[num].Length < 1 || string.IsNullOrWhiteSpace(s = array[num][OthN.XS.Next(array[num].Length)]));
			}
			Act.UI.発音(Act.Cha.Bod.口腔位置.GetAreaPoint(0.05), s.語尾() + " ", Color.Pink, 0.3 + 0.1 * Act.興奮, true);
		}

		public static string 語尾(this string s)
		{
			switch (Oth.GetRandomIndex(new double[]
			{
				(Act.羞恥 + Act.緊張) * 0.5,
				Act.Cha.苦痛条件() ? 1.0 : ((Act.感度 + Act.興奮 + Act.欲望度) / 3.0),
				(Act.情愛度 + Act.欲望度) * 0.4 - Act.抵抗値
			}))
			{
			case 0:
				return s + Sta.end[OthN.XS.NextBool() ? 0 : 1];
			case 1:
				if (s.EndsWith(Sta.end[2]))
				{
					return s + Sta.end[3];
				}
				return s + Sta.end[OthN.XS.NextBool() ? 2 : 3];
			case 2:
				return s + Sta.end[4];
			default:
				return s + Sta.end[0];
			}
		}

		public static string[][] GetRandomTable()
		{
			switch (OthN.XS.Next(6))
			{
			case 0:
				return Sta.a;
			case 1:
				return Sta.i;
			case 2:
				return Sta.u;
			case 3:
				return Sta.e;
			case 4:
				return Sta.o;
			case 5:
				return Sta.n;
			default:
				return null;
			}
		}

		public static bool Is性器接触
		{
			get
			{
				return Act.接触n == 接触.股 || Act.接触n == 接触.性 || Act.接触n == 接触.核 || Act.接触n == 接触.膣;
			}
		}

		public static void ModBox()
		{
			if (Sta.GameData.調教対象 == null)
			{
				return;
			}
			ChaD chaD = Sta.GameData.調教対象.ChaD;
			List<string> list = new List<string>();
			foreach (KeyValuePair<接触, double> keyValuePair in chaD.部位感度)
			{
				list.Add(Injected.TouchTranslation(keyValuePair.Key) + ": " + keyValuePair.Value.Numf1());
			}
			for (int i = 0; i < list.Count; i++)
			{
				if (i % 2 == 1)
				{
					list.Insert(i, "\r\n");
				}
			}
			Act.UI.InfoBox.TextIm = string.Concat(new string[]
			{
				"Sizes:",
				"\r\n Breasts : ",
				chaD.最乳房.Numf1(),
				"\r\n Nipples : ",
				chaD.最乳首.Numf1(),
				"\r\n Clit    : ",
				chaD.現陰核.Numf1(),
				"\r\n Vagina  : ",
				chaD.現性器.Numf1(),
				"\r\n Anus    : ",
				chaD.現肛門.Numf1(),
				"\r\nMood : ",
				Injected.TranslateState(chaD.状態),
				"\r\nTouching : ",
				Injected.TouchTranslation(Act.接触n)
			});
		}

		public static void SensBox()
		{
			if (Sta.GameData.調教対象 == null)
			{
				return;
			}
			ChaD chaD = Sta.GameData.調教対象.ChaD;
			Act.UI.SensitivityBox.TextIm = "Sensitivities:\r\n";
			foreach (KeyValuePair<接触, double> keyValuePair in chaD.部位感度)
			{
				Tex sensitivityBox = Act.UI.SensitivityBox;
				sensitivityBox.TextIm = string.Concat(new string[]
				{
					sensitivityBox.TextIm,
					" ",
					Injected.TouchTranslation(keyValuePair.Key),
					": ",
					keyValuePair.Value.Numf1(),
					"\r\n"
				});
			}
		}

		public static Cha Cha;

		public static 調教UI UI;

		public static 接触 接触n;

		public static アクション情報 アクション情報n;

		public static タイミング情報 タイミング情報n;

		public static アイテム情報 アイテム情報n;

		public static int 挿入Lvn;

		public static int 強さn;

		public static bool 機械n;

		public static bool 射精n;

		public static 接触 接触o;

		public static アクション情報 アクション情報o;

		public static タイミング情報 タイミング情報o;

		public static アイテム情報 アイテム情報o;

		public static int 挿入Lvo;

		public static int 強さo;

		public static bool 機械o;

		public static bool 射精o;

		private static double 奴隷a;

		private static double 奴隷ao;

		private static double 主人a;

		private static double 主人ao;

		private static double 奴隷接触慣れ;

		private static double 奴隷アクション慣れ;

		public static bool 絶頂中 = false;

		public static bool 射精中 = false;

		private static int 絶頂回数;

		private static double 放尿率;

		public static double 調教前抵抗値;

		public static double 調教前欲望度;

		public static double 調教前情愛度;

		public static double 調教前卑屈度;

		public static double 調教前技巧度;

		public static double 調教前調教力;

		public static Mot ゲ\u30FCジ降下処理 = new Mot(0.0, 1.0)
		{
			BaseSpeed = 1.0,
			Staing = delegate(Mot m)
			{
			},
			Runing = delegate(Mot m)
			{
				if (Act.加算前提)
				{
					if (Act.感度 > 0.0 && !Act.絶頂中)
					{
						Act.感度減算();
					}
					Act.興奮計算();
					Act.興奮計算2();
					Act.回復();
					if (Act.主射精 > 0.0 && !Act.射精中)
					{
						Act.主感度減算();
					}
					Act.主興奮計算();
					Act.主興奮計算2();
					Act.主回復();
					Act.待機状態0();
				}
			},
			Reaing = delegate(Mot m)
			{
			},
			Rouing = delegate(Mot m)
			{
			},
			Ending = delegate(Mot m)
			{
			}
		};

		public static bool 強制終了 = false;

		public static bool 無毛;

		public static bool 処女;

		public static bool 発情;

		public static bool 妊娠;

		public static bool 強靭;

		public static bool 傷物;

		public static bool 調教済;

		private static bool 初回 = false;

		private static double 反応度 = 0.0;
	}
}
