using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class GameState
	{
		public ulong 日借金可能額
		{
			get
			{
				return 50000000UL - this.日借金額;
			}
		}

		public ulong 利子額
		{
			get
			{
				return (ulong)(this.借金 * this.利子).RoundDown(0);
			}
		}

		public void 時間進行()
		{
			this.時間 += 1UL;
		}

		public string 時間帯
		{
			get
			{
				ulong num = this.時間 % 3UL;
				ulong num2 = num;
				if (num2 <= 2UL)
				{
					switch ((uint)num2)
					{
					case 0U:
						return tex.朝;
					case 1U:
						return tex.昼;
					case 2U:
						return tex.夜;
					}
				}
				return "";
			}
		}

		public ulong 日数
		{
			get
			{
				return this.時間 / 3UL;
			}
		}

		public string GetSaveDateString()
		{
			return string.Concat(new object[]
			{
				this.日数,
				tex.日目,
				"/",
				this.時間帯
			});
		}

		public bool Is地下室一杯()
		{
			return !this.地下室.Take(Mods.最大部屋数 / 9 * this.フロア数).Any((Unit e) => e == null);
		}

		public void Add地下室(Unit Unit)
		{
			for (int i = 0; i < this.地下室.Length; i++)
			{
				if (this.地下室[i] == null)
				{
					this.地下室[i] = Unit;
					break;
				}
			}
			if (Sta.AutoSort)
			{
				Array.Sort<Unit>(this.地下室, delegate(Unit e1, Unit e2)
				{
					if (e1 == null)
					{
						return int.MaxValue;
					}
					if (e2 != null)
					{
						return e1.種族.CompareTo(e2.種族);
					}
					return int.MinValue;
				});
			}
			for (int j = 0; j < this.地下室.Length; j++)
			{
				if (this.地下室[j] != null)
				{
					Unit unit = this.地下室[j];
					unit.階層位置 = j / 15;
					unit.部屋位置 = j % 15;
					unit.Number = (j + 1).ToString().PadLeft(3, '0');
					this.地下室[j] = unit;
				}
			}
		}

		public Generator 鳥系
		{
			get
			{
				return this.Gen[0];
			}
		}

		public Generator 蛇系
		{
			get
			{
				return this.Gen[1];
			}
		}

		public Generator 獣系
		{
			get
			{
				return this.Gen[2];
			}
		}

		public Generator 水系
		{
			get
			{
				return this.Gen[3];
			}
		}

		public Generator 虫系
		{
			get
			{
				return this.Gen[4];
			}
		}

		public Generator 人型
		{
			get
			{
				return this.Gen[5];
			}
		}

		public Generator 幻獣
		{
			get
			{
				return this.Gen[6];
			}
		}

		public Generator 魔獣
		{
			get
			{
				return this.Gen[7];
			}
		}

		public Generator 竜系
		{
			get
			{
				return this.Gen[8];
			}
		}

		public void GenRefresh()
		{
			this.Refresh = true;
			Parallel.ForEach<Generator>(this.Gen, Sta.po3, delegate(Generator g)
			{
				g.Refresh(3);
			});
			this.Refresh = false;
		}

		public void GenInstance()
		{
			this.Refresh = true;
			for (int i = 0; i < this.Gen.Length; i++)
			{
				this.Gen[i] = new Generator(3, (系統)i);
			}
			this.Refresh = false;
		}

		public string GetPriceInfo(out ulong s)
		{
			s = 0UL;
			foreach (Unit unit in this.地下室)
			{
				if (unit != null && !unit.保守)
				{
					s += unit.GetPrice();
				}
			}
			return "\r\n" + tex.合計売却額 + " +" + s.ToString("#,0");
		}

		public void 地下室詰め()
		{
			Unit[] array = (from e in this.地下室
			where e != null
			select e).ToArray<Unit>();
			for (int i = 0; i < Mods.最大部屋数; i++)
			{
				if (array.Length > i)
				{
					array[i].階層位置 = i / 15;
					array[i].部屋位置 = i % 15;
					array[i].Number = (i + 1).ToString().PadLeft(3, '0');
					this.地下室[i] = array[i];
				}
				else
				{
					this.地下室[i] = null;
				}
			}
		}

		public GameState()
		{
			bool[] array = new bool[9];
			array[0] = true;
			array[1] = true;
			this.系統開放 = array;
			this.購入道具 = new bool[14];
			this.初事務所フラグ = true;
			this.Gen = new Generator[9];
			this.フロア数 = 1;
			this.ガイド = true;
			base..ctor();
			this.配色 = new 主人公配色(this.色);
		}

		public void SetDefault()
		{
			this.ヴィオラ = null;
			this.利子 = 0.002;
			this.日借金額 = 0UL;
			this.身長 = 0.5;
			this.体重 = 0.5;
			this.色 = new 主人公色();
			this.配色 = new 主人公配色(this.色);
			this.精力 = 1.0;
			this.射精 = 0.0;
			this.興奮 = 0.0;
			this.調教力 = 0.0;
			this.時間 = 0UL;
			this.所持金 = 0UL;
			this.借金 = 0UL;
			this.需給初期化();
			this.返済段階 = 0;
			this.調教対象 = null;
			this.地下室 = new Unit[Mods.最大部屋数];
			this.祝福 = null;
			bool[] array = new bool[9];
			array[0] = true;
			array[1] = true;
			this.系統開放 = array;
			this.購入道具 = new bool[14];
			this.初事務所フラグ = true;
			Task.Factory.StartNew(new Action(this.GenInstance));
			this.フロア数 = 1;
			this.拘束具 = false;
			this.目隠帯 = false;
			this.玉口枷 = false;
			this.断面 = false;
			this.ガイド = true;
			this.心眼 = false;
			this.媚薬 = false;
			this.施術 = false;
			this.淫紋 = false;
			this.衣装 = false;
			this.ヴィオラ服 = false;
			this.新日 = false;
		}

		public void 需給初期化()
		{
			this.需給 = new Dictionary<string, double>
			{
				{
					tex.サキュバス,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.バイコ\u30FCン,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.ドワ\u30FCフ,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.アルラウネ,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.スキュラ,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.アラクネ,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.ユニコ\u30FCン,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.エキドナ,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.ムカデジョウロウ,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.オ\u30FCルドスキュラ,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.ドラゴニュ\u30FCト,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.カッパ,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.エルフ,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.リザ\u30FCドマン,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.オ\u30FCグリス,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.デビル,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.オ\u30FCルドマ\u30FCメイド,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.ラミア,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.シ\u30FCラミア,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.サイクロプス,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.ミノタウロス,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.エイリアン,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.ゴルゴン,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.ギルタブリル,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.ウロボロス,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.フェニックス,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.ドラゴン,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.リュウ,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.リリン,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.セイレ\u30FCン,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.ハルピュイア,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.オノケンタウレ,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.カプラケンタウレ,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.チ\u30FCタケンタウレ,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.エンジェル,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.マ\u30FCメイド,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.ドルフィンマ\u30FCメイド,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.ウェアキャット,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.ウェアウルフ,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.ウェアフォックス,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.ヒュドラ,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.クラ\u30FCケン,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.ヒッポケンタウレ,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.ブケンタウレ,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.レオントケンタウレ,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.ティグリスケンタウレ,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.パンテ\u30FCラケンタウレ,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.イクテュオケンタウレ,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.デルピヌスケンタウレ,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.ギルタブルル,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.スフィンクス,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.ペガサス,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.アリコ\u30FCン,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.キマイラ,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.グリフォン,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.ヒッポグリフ,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.モノケロス,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.カリュブディス,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.ドラコケンタウレ,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.カ\u30FCバンクル,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.スライム,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.フェアリ\u30FC,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.ハ\u30FCピ\u30FC,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.アフ\u30FCル,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.ウェアマンティス,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.ウェアドラゴンフライ,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.カトブレパス,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.バジリスク,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.コカトリス,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.ワ\u30FCム,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.ワイバ\u30FCン,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.ウェアビ\u30FCトル,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.ウェアスタッグビ\u30FCトル,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.サンドワ\u30FCム,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.ヴィオランテ,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.ヒュ\u30FCマン,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				},
				{
					tex.ミックス,
					this.NextNormal(OthN.XS, Mods.需給最大幅)
				}
			};
		}

		public void 需給更新()
		{
			foreach (string key in Sta.GameData.需給.Keys.ToArray<string>())
			{
				Sta.GameData.需給[key] = this.NextNormal(OthN.XS, Mods.需給最大幅);
			}
		}

		private double NextNormal(XS r, double mr)
		{
			double num = mr * 0.5 * r.NextNorCos(0.0, 1.0);
			if (num > 0.0)
			{
				return num;
			}
			if (num >= 0.0)
			{
				return 1.0;
			}
			return -(1.0 / num);
		}

		public Unit ヴィオラ;

		public double 利子 = 0.002;

		public ulong 日借金額;

		public double 身長 = 0.5;

		public double 体重 = 0.5;

		public 主人公色 色 = new 主人公色();

		public 主人公配色 配色;

		public double 精力 = 1.0;

		public double 射精;

		public double 興奮;

		public double 調教力;

		public Unit プレ\u30FCヤ\u30FC;

		public ulong 時間;

		public ulong 所持金;

		public ulong 借金;

		public Dictionary<string, double> 需給;

		public int 返済段階;

		public Unit 調教対象;

		public Unit[] 地下室 = new Unit[Mods.最大部屋数];

		public Unit 祝福;

		public bool[] 系統開放;

		public bool[] 購入道具;

		public bool 初事務所フラグ;

		private const int Capacity = 3;

		public Generator[] Gen;

		public bool Refresh;

		public int フロア数;

		public bool 拘束具;

		public bool 目隠帯;

		public bool 玉口枷;

		public bool 断面;

		public bool ガイド;

		public bool 心眼;

		public bool 媚薬;

		public bool 施術;

		public bool 淫紋;

		public bool 衣装;

		public bool ヴィオラ服;

		public bool 新日;
	}
}
