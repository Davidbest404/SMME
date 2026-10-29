using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class Unit
	{
		public Unit 母方
		{
			get
			{
				return this.母;
			}
			set
			{
				this.母 = value.DeepCopy<Unit>();
				this.母.母 = null;
				this.母.父 = null;
			}
		}

		public Unit 父方
		{
			get
			{
				return this.父;
			}
			set
			{
				this.父 = value.DeepCopy<Unit>();
				this.父.母 = null;
				this.父.父 = null;
			}
		}

		public ChaD ChaD
		{
			get
			{
				return this.cd;
			}
			set
			{
				this.cd = value;
				this.cd.Parent = this;
			}
		}

		public string GetStatus()
		{
			string[] array = new string[33];
			array[0] = tex.種族;
			array[1] = "/ ";
			array[2] = this.種族;
			array[3] = " ";
			array[4] = tex.価格;
			array[5] = "/ ";
			array[6] = this.GetPrice().ToString("#,0");
			array[7] = "\r\n";
			array[8] = tex.抵抗値;
			array[9] = "/";
			array[10] = this.ChaD.抵抗値.Numf1();
			array[11] = " ";
			array[12] = tex.魔力濃度;
			array[13] = "/";
			array[14] = this.ChaD.魔力濃度.Numf1();
			array[15] = "\r\n";
			array[16] = tex.欲望度;
			array[17] = "/";
			array[18] = this.ChaD.欲望度.Numf1();
			array[19] = " ";
			array[20] = tex.情愛度;
			array[21] = "/";
			array[22] = this.ChaD.情愛度.Numf1();
			array[23] = "\r\n";
			array[24] = tex.卑屈度;
			array[25] = "/";
			array[26] = this.ChaD.卑屈度.Numf1();
			array[27] = " ";
			array[28] = tex.技巧度;
			array[29] = "/";
			array[30] = this.ChaD.技巧度.Numf1();
			array[31] = "\r\n";
			array[32] = string.Join("", (from e in this.ChaD.体色.血統
			select "[" + e + "]").Reverse<string>());
			return string.Concat(array);
		}

		public string GetPriceInfo()
		{
			string[] array = new string[69];
			array[0] = "(\r\n(1,000,000 * (1 - ";
			array[1] = tex.抵抗値;
			array[2] = "[";
			array[3] = string.Format("{0:0.00}", this.ChaD.抵抗値);
			array[4] = "])) +\r\n(1,000,000 * (";
			array[5] = tex.欲望度;
			array[6] = "[";
			array[7] = string.Format("{0:0.00}", this.ChaD.欲望度);
			array[8] = "])) +\r\n(1,000,000 * (";
			array[9] = tex.情愛度;
			array[10] = "[";
			array[11] = string.Format("{0:0.00}", this.ChaD.情愛度);
			array[12] = "] * 0.5)) +\r\n(1,000,000 * (";
			array[13] = tex.卑屈度;
			array[14] = "[";
			array[15] = string.Format("{0:0.00}", this.ChaD.卑屈度);
			array[16] = "])) +\r\n(1,000,000 * (";
			array[17] = tex.技巧度;
			array[18] = "[";
			array[19] = string.Format("{0:0.00}", this.ChaD.技巧度);
			array[20] = "] * 4)) +\r\n(  100,000 * (";
			array[21] = tex.部位感度合計;
			array[22] = "[";
			array[23] = string.Format("{0:0.00}", this.ChaD.部位感度.Values.Sum());
			array[24] = "]) +\r\n(1,000,000 * (";
			array[25] = tex.バストサイズ;
			array[26] = "[";
			array[27] = string.Format("{0:0.00}", this.ChaD.構成.EnumEleD().GetEleD<乳房D>().バスト);
			array[28] = "])\r\n(1,000,000 * (";
			array[29] = tex.一般労働;
			array[30] = "[";
			array[31] = string.Format("{0:0.00}", (double)this.種族情報.一般 / 9.0);
			array[32] = "])) +\r\n(1,000,000 * (";
			array[33] = tex.娼婦労働;
			array[34] = "[";
			array[35] = string.Format("{0:0.00}", (double)this.種族情報.娼婦 / 9.0);
			array[36] = "])) +\r\n) *\r\n\r\n";
			array[37] = tex.種族;
			array[38] = "[";
			array[39] = string.Format("{0:0.00}", this.種族情報.GetPriceWeight());
			array[40] = "] *\r\n";
			array[41] = tex.需給;
			array[42] = "[";
			array[43] = string.Format("{0:0.00}", Sta.GameData.需給[this.種族]);
			array[44] = "]";
			array[45] = (this.ChaD.体色.血統.Contains(tex.調教済) ? (" *\r\n" + tex.調教済 + "[1.6]") : "");
			array[46] = (this.ChaD.体色.血統.Contains(tex.無毛) ? (" *\r\n" + tex.無毛 + "[2]") : "");
			array[47] = (this.ChaD.体色.血統.Contains(tex.処女) ? (" *\r\n" + tex.処女 + "[1.5]") : "");
			array[48] = (this.ChaD.体色.血統.Contains(tex.発情) ? (" *\r\n" + tex.発情 + "[1.2]") : "");
			array[49] = (this.ChaD.体色.血統.Contains(tex.妊娠) ? (" *\r\n" + tex.妊娠 + "[1.5]") : "");
			array[50] = (this.ChaD.体色.血統.Contains(tex.強靭) ? (" *\r\n" + tex.強靭 + "[1.4]") : "");
			array[51] = (this.ChaD.体色.血統.Contains(tex.傷物) ? (" *\r\n" + tex.傷物 + "[0.1]") : "");
			array[52] = (this.ChaD.体色.血統.Contains(tex.オッドアイ) ? (" *\r\n" + tex.オッドアイ + "[5]") : "");
			string text;
			array[53] = (((text = this.ChaD.体色.血統.FirstOrDefault((string e) => e.StartsWith(tex.ルチノ\u30FC))) != null) ? string.Concat(new object[]
			{
				" *\r\n",
				text,
				"[",
				text.GetRutinohWeight(),
				"]"
			}) : "");
			array[54] = (this.ChaD.体色.血統.Contains(tex.メラニス) ? (" *\r\n" + tex.メラニス + "[30]") : "");
			array[55] = (this.ChaD.体色.血統.Contains(tex.アルビノ) ? (" *\r\n" + tex.アルビノ + "[50]") : "");
			array[56] = "\r\n\r\n= ";
			array[57] = tex.売値;
			array[58] = "[";
			int num = 59;
			ulong price;
			ulong num2 = price = this.GetPrice();
			array[num] = price.ToString("#,0");
			array[60] = "] - ";
			array[61] = tex.買値;
			array[62] = "[";
			array[63] = this.買値.ToString("#,0");
			array[64] = "]\r\n\r\n= ";
			array[65] = tex.利益;
			array[66] = "[";
			array[67] = ((num2 >= this.買値) ? (num2 - this.買値).ToString("#,0") : ("-" + (this.買値 - num2).ToString("#,0")));
			array[68] = "]";
			return string.Concat(array);
		}

		public ulong GetPrice()
		{
			ulong result;
			try
			{
				result = checked((ulong)(unchecked((1000000.0 * this.ChaD.抵抗値.Inverse() + 1000000.0 * this.ChaD.欲望度 + 1000000.0 * (this.ChaD.情愛度 * 0.5) + 1000000.0 * this.ChaD.卑屈度 + 1000000.0 * (this.ChaD.技巧度 * 4.0) + 100000.0 * this.ChaD.部位感度.Values.Sum() + 1000000.0 * this.ChaD.構成.EnumEleD().GetEleD<乳房D>().バスト + 1000000.0 * ((double)this.種族情報.一般 / 9.0) + 1000000.0 * ((double)this.種族情報.娼婦 / 9.0)) * this.種族情報.GetPriceWeight() * Sta.GameData.需給[this.種族] * (this.ChaD.体色.血統.Contains(tex.調教済) ? 1.6 : 1.0) * (this.ChaD.体色.血統.Contains(tex.無毛) ? 2.0 : 1.0) * (this.ChaD.体色.血統.Contains(tex.処女) ? 1.5 : 1.0) * (this.ChaD.体色.血統.Contains(tex.発情) ? 1.2 : 1.0) * (this.ChaD.体色.血統.Contains(tex.妊娠) ? 1.5 : 1.0) * (this.ChaD.体色.血統.Contains(tex.強靭) ? 1.4 : 1.0) * (this.ChaD.体色.血統.Contains(tex.傷物) ? 0.1 : 1.0) * (this.ChaD.体色.血統.Contains(tex.オッドアイ) ? 5.0 : 1.0) * this.ChaD.体色.血統.FirstOrDefault((string e) => e.StartsWith(tex.ルチノ\u30FC)).GetRutinohWeight() * (this.ChaD.体色.血統.Contains(tex.メラニス) ? 30.0 : 1.0) * (this.ChaD.体色.血統.Contains(tex.アルビノ) ? 50.0 : 1.0))));
			}
			catch
			{
				result = 9999999999999UL;
			}
			return result;
		}

		public bool 無毛フラグ
		{
			get
			{
				return this.無毛;
			}
			set
			{
				this.無毛 = value;
				if (value)
				{
					if (!this.ChaD.体色.血統.Contains(tex.無毛))
					{
						this.ChaD.体色.血統.Add(tex.無毛);
						return;
					}
				}
				else if (this.ChaD.体色.血統.Contains(tex.無毛))
				{
					this.ChaD.体色.血統.Remove(tex.無毛);
				}
			}
		}

		public bool 処女フラグ
		{
			get
			{
				return this.処女;
			}
			set
			{
				this.処女 = value;
				if (value)
				{
					if (!this.ChaD.体色.血統.Contains(tex.処女))
					{
						this.ChaD.体色.血統.Add(tex.処女);
						return;
					}
				}
				else if (this.ChaD.体色.血統.Contains(tex.処女))
				{
					this.ChaD.体色.血統.Remove(tex.処女);
				}
			}
		}

		public bool 発情フラグ
		{
			get
			{
				return this.発情;
			}
			set
			{
				this.発情 = value;
				if (value)
				{
					if (!this.ChaD.体色.血統.Contains(tex.発情))
					{
						this.ChaD.体色.血統.Add(tex.発情);
						return;
					}
				}
				else if (this.ChaD.体色.血統.Contains(tex.発情))
				{
					this.ChaD.体色.血統.Remove(tex.発情);
				}
			}
		}

		public bool 妊娠フラグ
		{
			get
			{
				return this.妊娠;
			}
			set
			{
				this.妊娠 = value;
				if (value)
				{
					if (!this.ChaD.体色.血統.Contains(tex.妊娠))
					{
						this.ChaD.体色.血統.Add(tex.妊娠);
					}
					Task.Factory.StartNew(delegate()
					{
						Unit unit = (Sta.GameData.祝福 == null || Sta.GameData.祝福 == this) ? Sta.GameData.プレ\u30FCヤ\u30FC : Sta.GameData.祝福;
						if (Sta.SimpleMating)
						{
							this.子 = this.Mix(unit, this.原種モ\u30FCド(this, unit));
							this.子.母方 = this;
							this.子.父方 = unit;
							return;
						}
						Unit 母方 = this.母方.Mix(this.父方, this.原種モ\u30FCド(this.母方, this.父方));
						Unit 父方 = unit.母方.Mix(unit.父方, this.原種モ\u30FCド(unit.母方, unit.父方));
						if (Sta.ComplexMating)
						{
							Unit 母方2 = 母方.Mix(父方, this.原種モ\u30FCド(母方, 父方));
							Unit 父方2 = this.Mix(unit, this.原種モ\u30FCド(this, unit));
							this.子 = 母方2.Mix(父方2, this.原種モ\u30FCド(母方2, 父方2));
							this.子.母方 = this;
							this.子.父方 = unit;
							return;
						}
						this.子 = 母方.Mix(父方, this.原種モ\u30FCド(母方, 父方));
						this.子.母方 = this;
						this.子.父方 = unit;
					});
					return;
				}
				if (this.ChaD.体色.血統.Contains(tex.妊娠))
				{
					this.ChaD.体色.血統.Remove(tex.妊娠);
				}
				this.子 = null;
			}
		}

		public void 娼婦妊娠()
		{
			this.妊娠 = true;
			if (!this.ChaD.体色.血統.Contains(tex.妊娠))
			{
				this.ChaD.体色.血統.Add(tex.妊娠);
			}
			Unit unit = Generator.娼婦労働妊娠父方();
			if (Sta.SimpleMating)
			{
				this.子 = this.Mix(unit, this.原種モ\u30FCド(this, unit));
				this.子.母方 = this;
				this.子.父方 = unit;
				return;
			}
			Unit 母方 = this.母方.Mix(this.父方, this.原種モ\u30FCド(this.母方, this.父方));
			Unit 父方 = unit.母方.Mix(unit.父方, this.原種モ\u30FCド(unit.母方, unit.父方));
			if (Sta.ComplexMating)
			{
				Unit 母方2 = 母方.Mix(父方, this.原種モ\u30FCド(母方, 父方));
				Unit 父方2 = this.Mix(unit, this.原種モ\u30FCド(this, unit));
				this.子 = 母方2.Mix(父方2, this.原種モ\u30FCド(母方2, 父方2));
				this.子.母方 = this;
				this.子.父方 = unit;
				return;
			}
			this.子 = 母方.Mix(父方, this.原種モ\u30FCド(母方, 父方));
			this.子.母方 = this;
			this.子.父方 = unit;
		}

		private bool 原種モ\u30FCド(Unit 母方, Unit 父方)
		{
			return 母方.種族 != tex.ミックス && 父方.種族 != tex.ミックス && 母方.種族 == 父方.種族;
		}

		public bool 強靭フラグ
		{
			get
			{
				return this.強靭;
			}
			set
			{
				this.強靭 = value;
				if (value)
				{
					if (!this.ChaD.体色.血統.Contains(tex.強靭))
					{
						this.ChaD.体色.血統.Add(tex.強靭);
					}
					this.ChaD.構成.EnumEleD().SetValuesD("筋肉", true);
					return;
				}
				if (this.ChaD.体色.血統.Contains(tex.強靭))
				{
					this.ChaD.体色.血統.Remove(tex.強靭);
				}
				this.ChaD.構成.EnumEleD().SetValuesD("筋肉", false);
			}
		}

		public bool 傷物フラグ
		{
			get
			{
				return this.傷物;
			}
			set
			{
				if (Sta.DontScar)
				{
					this.傷物 = value;
					if (value && !this.ChaD.体色.血統.Contains(tex.傷物))
					{
						this.ChaD.体色.血統.Add(tex.傷物);
						return;
					}
					if (!value && this.ChaD.体色.血統.Contains(tex.傷物))
					{
						this.ChaD.体色.血統.Remove(tex.傷物);
						return;
					}
				}
				else
				{
					this.傷物 = value;
					if (value)
					{
						if (!this.ChaD.体色.血統.Contains(tex.傷物))
						{
							this.ChaD.体色.血統.Add(tex.傷物);
						}
						bool flag = false;
						while (!flag)
						{
							foreach (EleD eleD in this.ChaD.構成.EnumEleD())
							{
								flag |= eleD.傷物処理();
							}
						}
						using (IEnumerator<EleD> enumerator2 = this.ChaD.構成.EnumEleD().GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								EleD eleD2 = enumerator2.Current;
								eleD2.欠損 = 0.3.Lot();
							}
							return;
						}
					}
					if (this.ChaD.体色.血統.Contains(tex.傷物))
					{
						this.ChaD.体色.血統.Remove(tex.傷物);
					}
					foreach (EleD eleD3 in this.ChaD.構成.EnumEleD())
					{
						eleD3.SetValuesD("傷", false);
						eleD3.欠損 = false;
					}
				}
			}
		}

		public bool 調教済フラグ
		{
			get
			{
				return this.調教済;
			}
			set
			{
				this.調教済 = value;
				if (value)
				{
					if (!this.ChaD.体色.血統.Contains(tex.調教済))
					{
						this.ChaD.体色.血統.Add(tex.調教済);
						return;
					}
				}
				else if (this.ChaD.体色.血統.Contains(tex.調教済))
				{
					this.ChaD.体色.血統.Remove(tex.調教済);
				}
			}
		}

		public bool Is調教完了()
		{
			if (this.調教済)
			{
				return false;
			}
			if (this.ChaD.抵抗値 == 0.0 && this.ChaD.欲望度 + this.ChaD.情愛度 + this.ChaD.卑屈度 > 1.5 && this.ChaD.技巧度 > 0.2)
			{
				this.調教済フラグ = true;
				return true;
			}
			return false;
		}

		public void Set原種素質()
		{
			半身D eleD = this.ChaD.構成.半身_接続.GetEleD<半身D>();
			腰肌D eleD2 = this.ChaD.構成.肌_接続.GetEleD<腰肌D>();
			this.無毛フラグ = (!(eleD is 単足_粘D) && !(eleD is 四足胸D) && (!(eleD is 長物_蛇D) || !((長物_蛇D)eleD).ガ\u30FCド) && !this.ChaD.構成.虫性_甲殻1_表示 && !this.ChaD.構成.虫性_甲殻2_表示 && !eleD2.竜性_鱗1_表示 && !eleD2.竜性_鱗2_表示 && !eleD2.竜性_鱗3_表示 && !eleD2.竜性_鱗4_表示 && ((!eleD2.陰毛_表示 && !eleD2.獣性_獣毛_表示) || this.ChaD.最陰毛濃度 == 0.0));
			if (!(this.種族 == tex.スライム) && !(this.種族 == tex.フェニックス) && !(this.種族 == tex.ウロボロス))
			{
				this.傷物フラグ = 0.05.Lot();
			}
			if (this.種族 == tex.ウェアウルフ)
			{
				this.強靭フラグ = 0.03.Lot();
				return;
			}
			if (this.種族 == tex.リザ\u30FCドマン)
			{
				this.強靭フラグ = 0.03.Lot();
				return;
			}
			if (this.種族 == tex.サイクロプス)
			{
				this.強靭フラグ = 0.03.Lot();
				return;
			}
			if (this.種族 == tex.ワ\u30FCム)
			{
				this.強靭フラグ = 0.1.Lot();
				return;
			}
			if (this.種族 == tex.ワイバ\u30FCン)
			{
				this.強靭フラグ = 0.1.Lot();
				return;
			}
			if (this.種族 == tex.ドラコケンタウレ)
			{
				this.強靭フラグ = 0.1.Lot();
				return;
			}
			if (this.種族 == tex.ドラゴン)
			{
				this.強靭フラグ = 0.1.Lot();
				return;
			}
			if (this.種族 == tex.リュウ)
			{
				this.強靭フラグ = 0.1.Lot();
				return;
			}
			if (this.種族 == tex.ドラゴニュ\u30FCト)
			{
				this.強靭フラグ = 0.1.Lot();
				return;
			}
			if (this.種族 == tex.ドワ\u30FCフ)
			{
				this.強靭フラグ = 0.8.Lot();
				return;
			}
			if (this.種族 == tex.オ\u30FCグリス)
			{
				this.強靭フラグ = 0.9.Lot();
				return;
			}
			if (this.種族 == tex.ミノタウロス)
			{
				this.強靭フラグ = 0.9.Lot();
				return;
			}
			if (this.種族 == tex.カトブレパス)
			{
				this.強靭フラグ = 1.0.Lot();
				return;
			}
			this.強靭フラグ = 0.005.Lot();
		}

		public void Set交配素質()
		{
			半身D eleD = this.ChaD.構成.半身_接続.GetEleD<半身D>();
			腰肌D eleD2 = this.ChaD.構成.肌_接続.GetEleD<腰肌D>();
			this.無毛フラグ = (!(eleD is 単足_粘D) && !(eleD is 四足胸D) && (!(eleD is 長物_蛇D) || !((長物_蛇D)eleD).ガ\u30FCド) && !this.ChaD.構成.虫性_甲殻1_表示 && !this.ChaD.構成.虫性_甲殻2_表示 && !eleD2.竜性_鱗1_表示 && !eleD2.竜性_鱗2_表示 && !eleD2.竜性_鱗3_表示 && !eleD2.竜性_鱗4_表示 && ((!eleD2.陰毛_表示 && !eleD2.獣性_獣毛_表示) || this.ChaD.最陰毛濃度 == 0.0));
			this.処女フラグ = true;
			this.強靭フラグ = this.ChaD.構成.筋肉;
		}

		public void Setヴィオラ(Med Med, Are Are)
		{
			this.階層位置 = 0;
			this.部屋位置 = 0;
			this.Number = "000";
			this.Name = tex.ヴィオランテ;
			this.子 = null;
			this.ChaD = 原種.Getヴィオラ();
			this.種族 = tex.ヴィオランテ;
			this.保守 = false;
			this.一般労働 = false;
			this.娼婦労働 = false;
			this.一般労働Count = 0;
			this.娼婦労働Count = 0;
			this.妊娠状態変数 = -1;
			this.妊娠進行期間 = 4;
			this.非妊娠 = true;
			this.無毛フラグ = false;
			this.処女フラグ = false;
			this.発情フラグ = false;
			this.妊娠フラグ = false;
			this.強靭フラグ = false;
			this.傷物フラグ = false;
			this.調教済フラグ = false;
			this.着衣番号 = 8;
			this.着衣 = 衣装.Getヴィオラ服0(this.ChaD).ToArray<object>();
			種族情報 種族情報 = Def.種族情報[this.種族];
			this.種族情報 = new 種族情報(種族情報.希少, 種族情報.需要, 種族情報.危険, ((int)((double)(種族情報.一般 + 1) * this.ChaD.固有値)).LimitM(1, 9), ((int)((double)(種族情報.娼婦 + 1) * this.ChaD.固有値)).LimitM(1, 9));
			this.Set種族特性();
			this.Set構成特性();
			this.買値 = this.GetPrice();
			this.母方 = this;
			this.父方 = this;
		}

		public Unit 増殖時Reset()
		{
			this.買値 = 0UL;
			this.保守 = false;
			this.一般労働 = false;
			this.娼婦労働 = false;
			this.一般労働Count = 0;
			this.娼婦労働Count = 0;
			this.非妊娠 = true;
			this.Set衣装();
			return this;
		}

		public void Set種族特性()
		{
			if (this.種族 == tex.ハ\u30FCピ\u30FC)
			{
				this.ChaD.欲望補正();
				return;
			}
			if (this.種族 == tex.ハルピュイア)
			{
				this.ChaD.欲望補正();
				return;
			}
			if (this.種族 == tex.フェニックス)
			{
				this.ChaD.情愛補正();
				return;
			}
			if (this.種族 == tex.ラミア)
			{
				this.ChaD.欲望補正();
				return;
			}
			if (!(this.種族 == tex.ヒュドラ))
			{
				if (this.種族 == tex.エキドナ)
				{
					this.ChaD.欲望補正();
					this.ChaD.情愛補正();
					return;
				}
				if (!(this.種族 == tex.ウロボロス))
				{
					if (this.種族 == tex.ウェアキャット)
					{
						this.ChaD.情愛補正();
						return;
					}
					if (this.種族 == tex.ウェアウルフ)
					{
						this.ChaD.卑屈補正();
						return;
					}
					if (!(this.種族 == tex.アフ\u30FCル))
					{
						if (this.種族 == tex.ウェアフォックス)
						{
							this.ChaD.情愛補正();
							this.ChaD.卑屈補正();
							return;
						}
						if (this.種族 == tex.カプラケンタウレ)
						{
							this.ChaD.欲望補正();
							this.ChaD.卑屈補正();
							return;
						}
						if (this.種族 == tex.オノケンタウレ)
						{
							this.ChaD.卑屈補正();
							return;
						}
						if (this.種族 == tex.ミノタウロス)
						{
							this.ChaD.欲望補正();
							this.ChaD.情愛補正();
							return;
						}
						if (this.種族 == tex.ヒッポケンタウレ)
						{
							this.ChaD.欲望補正();
							return;
						}
						if (this.種族 == tex.ブケンタウレ)
						{
							this.ChaD.欲望補正();
							this.ChaD.情愛補正();
							return;
						}
						if (this.種族 == tex.レオントケンタウレ)
						{
							this.ChaD.情愛補正();
							return;
						}
						if (this.種族 == tex.ティグリスケンタウレ)
						{
							this.ChaD.欲望補正();
							this.ChaD.情愛補正();
							return;
						}
						if (this.種族 == tex.パンテ\u30FCラケンタウレ)
						{
							this.ChaD.情愛補正();
							return;
						}
						if (this.種族 == tex.チ\u30FCタケンタウレ)
						{
							this.ChaD.情愛補正();
							return;
						}
						if (this.種族 == tex.シ\u30FCラミア)
						{
							this.ChaD.欲望補正();
							this.ChaD.情愛補正();
							return;
						}
						if (this.種族 == tex.マ\u30FCメイド)
						{
							this.ChaD.情愛補正();
							this.ChaD.卑屈補正();
							return;
						}
						if (this.種族 == tex.セイレ\u30FCン)
						{
							this.ChaD.欲望補正();
							return;
						}
						if (this.種族 == tex.ドルフィンマ\u30FCメイド)
						{
							this.ChaD.欲望補正();
							this.ChaD.情愛補正();
							return;
						}
						if (this.種族 == tex.イクテュオケンタウレ)
						{
							this.ChaD.欲望補正();
							return;
						}
						if (this.種族 == tex.デルピヌスケンタウレ)
						{
							this.ChaD.情愛補正();
							return;
						}
						if (this.種族 == tex.カッパ)
						{
							this.ChaD.欲望補正();
							this.ChaD.情愛補正();
							return;
						}
						if (this.種族 == tex.クラ\u30FCケン)
						{
							this.ChaD.欲望補正();
							return;
						}
						if (!(this.種族 == tex.スキュラ))
						{
							if (this.種族 == tex.オ\u30FCルドマ\u30FCメイド)
							{
								this.ChaD.情愛補正();
								return;
							}
							if (this.種族 == tex.カリュブディス)
							{
								this.ChaD.欲望補正();
								return;
							}
							if (!(this.種族 == tex.オ\u30FCルドスキュラ))
							{
								if (this.種族 == tex.ウェアマンティス)
								{
									this.ChaD.欲望補正();
									return;
								}
								if (this.種族 == tex.ウェアドラゴンフライ)
								{
									this.ChaD.欲望補正();
									return;
								}
								if (!(this.種族 == tex.ウェアビ\u30FCトル) && !(this.種族 == tex.ウェアスタッグビ\u30FCトル))
								{
									if (this.種族 == tex.アラクネ)
									{
										this.ChaD.技巧補正();
										return;
									}
									if (this.種族 == tex.サンドワ\u30FCム)
									{
										this.ChaD.欲望補正();
										return;
									}
									if (this.種族 == tex.ムカデジョウロウ)
									{
										this.ChaD.欲望補正();
										this.ChaD.情愛補正();
										return;
									}
									if (this.種族 == tex.ギルタブリル)
									{
										this.ChaD.欲望補正();
										this.ChaD.情愛補正();
										return;
									}
									if (!(this.種族 == tex.ギルタブルル))
									{
										if (this.種族 == tex.フェアリ\u30FC)
										{
											this.ChaD.情愛補正();
											return;
										}
										if (this.種族 == tex.スライム)
										{
											this.ChaD.欲望補正();
											return;
										}
										if (this.種族 == tex.リリン)
										{
											this.ChaD.魔力濃度 *= 0.5;
											return;
										}
										if (this.種族 == tex.ドワ\u30FCフ)
										{
											this.ChaD.技巧補正();
											return;
										}
										if (this.種族 == tex.エルフ)
										{
											this.ChaD.情愛補正();
											return;
										}
										if (this.種族 == tex.オ\u30FCグリス)
										{
											this.ChaD.欲望補正();
											return;
										}
										if (this.種族 == tex.デビル)
										{
											this.ChaD.欲望補正();
											return;
										}
										if (this.種族 == tex.アルラウネ)
										{
											this.ChaD.欲望補正();
											this.ChaD.情愛補正();
											return;
										}
										if (this.種族 == tex.サイクロプス)
										{
											this.ChaD.技巧補正();
											return;
										}
										if (this.種族 == tex.エンジェル)
										{
											this.ChaD.情愛補正();
											return;
										}
										if (this.種族 == tex.サキュバス)
										{
											this.ChaD.欲望補正();
											this.ChaD.技巧補正();
											return;
										}
										if (this.種族 == tex.エイリアン)
										{
											this.ChaD.技巧補正();
											return;
										}
										if (this.種族 == tex.カ\u30FCバンクル)
										{
											this.ChaD.卑屈補正();
											this.ChaD.情愛補正();
											return;
										}
										if (!(this.種族 == tex.ペガサス))
										{
											if (this.種族 == tex.ユニコ\u30FCン)
											{
												this.ChaD.情愛補正();
												return;
											}
											if (this.種族 == tex.バイコ\u30FCン)
											{
												this.ChaD.欲望補正();
												return;
											}
											if (this.種族 == tex.アリコ\u30FCン)
											{
												this.ChaD.情愛補正();
												return;
											}
											if (this.種族 == tex.グリフォン)
											{
												this.ChaD.情愛補正();
												return;
											}
											if (this.種族 == tex.ヒッポグリフ)
											{
												this.ChaD.欲望補正();
												return;
											}
											if (this.種族 == tex.モノケロス)
											{
												this.ChaD.欲望補正();
												this.ChaD.情愛補正();
												return;
											}
											if (this.種族 == tex.キマイラ)
											{
												this.ChaD.欲望補正();
												this.ChaD.情愛補正();
												return;
											}
											if (this.種族 == tex.スフィンクス)
											{
												this.ChaD.情愛補正();
												return;
											}
											if (!(this.種族 == tex.カトブレパス))
											{
												if (this.種族 == tex.バジリスク)
												{
													this.ChaD.欲望補正();
													return;
												}
												if (!(this.種族 == tex.コカトリス))
												{
													if (this.種族 == tex.ゴルゴン)
													{
														this.ChaD.欲望補正();
														this.ChaD.情愛補正();
														this.ChaD.卑屈補正();
														return;
													}
													if (this.種族 == tex.リザ\u30FCドマン)
													{
														this.ChaD.欲望補正();
														this.ChaD.情愛補正();
														return;
													}
													if (this.種族 == tex.ワ\u30FCム)
													{
														this.ChaD.欲望補正();
														return;
													}
													if (this.種族 == tex.ドラコケンタウレ)
													{
														this.ChaD.欲望補正();
														return;
													}
													if (this.種族 == tex.ワイバ\u30FCン)
													{
														this.ChaD.欲望補正();
														return;
													}
													if (this.種族 == tex.ドラゴニュ\u30FCト)
													{
														this.ChaD.情愛補正();
														return;
													}
													if (!(this.種族 == tex.ドラゴン) && !(this.種族 == tex.リュウ) && !(this.種族 == tex.ヴィオランテ) && this.種族 == tex.ヒュ\u30FCマン)
													{
														this.ChaD.魔力濃度 *= 0.2;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		public void Set構成特性()
		{
			EleD[] array = this.ChaD.構成.EnumEleD().ToArray<EleD>();
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			this.一般最大加算値 = 0;
			this.娼婦最大加算値 = 0;
			胸肌D 胸肌D = null;
			胸肌D 胸肌D2 = null;
			this.Is増殖可 = false;
			foreach (EleD eleD in array)
			{
				if (eleD is 手_人D)
				{
					if (!((手_人D)eleD).虫性)
					{
						num++;
					}
					if (((手_人D)eleD).虫性)
					{
						num2++;
					}
				}
				if (eleD is 手_鳥D || eleD is 手_蝙D || eleD is 手_獣D || eleD is 手_牛D || eleD is 手_馬D || eleD is 触手_犬D)
				{
					this.一般最大加算値++;
				}
				if (!(eleD is 触手_犬D) && eleD is 触手D)
				{
					this.娼婦最大加算値++;
				}
				if (eleD is 尾D)
				{
					num3++;
				}
				if (eleD is 鳳凰D)
				{
					num4++;
				}
				if (eleD is 胸肌D)
				{
					if (eleD.接続情報 == 接続情報.胸_肌_接続)
					{
						胸肌D = (胸肌D)eleD;
					}
					else if (eleD.接続情報 == 接続情報.四足胸_肌_接続)
					{
						胸肌D2 = (胸肌D)eleD;
					}
				}
				if (!this.Is増殖可 && eleD is 単足_粘D)
				{
					this.Is増殖可 = true;
				}
			}
			this.技巧最大値 = 0.5 + (double)(num / 2) + (double)(num2 / 2) * 0.5;
			this.一般最大加算値 /= 2;
			this.娼婦最大加算値 /= 2;
			this.消耗乗算値 = 1.0 - ((double)num3 * 0.002 + ((this.種族 == tex.ワ\u30FCム) ? 0.004 : 0.0) + ((this.種族 == tex.ドラコケンタウレ) ? 0.004 : 0.0) + ((this.種族 == tex.ワイバ\u30FCン) ? 0.003 : 0.0) + ((this.種族 == tex.ドラゴニュ\u30FCト) ? 0.003 : 0.0) + ((this.種族 == tex.ドラゴン) ? 0.006 : 0.0) + ((this.種族 == tex.リュウ) ? 0.005 : 0.0));
			bool flag = 胸肌D != null;
			bool flag2 = 胸肌D2 != null;
			this.回復値 = 3.5E-05 * (double)(((flag && 胸肌D.コア_コア1_コア_表示) ? 1 : 0) + ((flag && 胸肌D.コア_コア2_コア_表示) ? 1 : 0) + ((flag2 && 胸肌D2.コア_コア1_コア_表示) ? 1 : 0) + ((flag2 && 胸肌D2.コア_コア2_コア_表示) ? 1 : 0) + num4 + ((this.種族 == tex.ヒュドラ) ? 1 : 0));
			this.ChaD.技巧度 = this.ChaD.技巧度.LimitM(0.0, this.技巧最大値);
		}

		public int 階層位置;

		public int 部屋位置;

		public string Number = "";

		public string Name = "";

		private Unit 母;

		private Unit 父;

		public Unit 子;

		private ChaD cd;

		public ulong 買値;

		public string 種族 = "";

		public bool 保守;

		public bool 一般労働;

		public bool 娼婦労働;

		public int 一般労働Count;

		public int 娼婦労働Count;

		public int 妊娠状態変数 = -1;

		public int 妊娠進行期間 = 2;

		public bool 非妊娠 = true;

		private bool 無毛;

		private bool 処女;

		private bool 発情;

		private bool 妊娠;

		private bool 強靭;

		private bool 傷物;

		private bool 調教済;

		public int 着衣番号;

		public object[] 着衣;

		public 種族情報 種族情報;

		public double 技巧最大値;

		public int 一般最大加算値;

		public int 娼婦最大加算値;

		public double 消耗乗算値;

		public double 回復値;

		public bool Is増殖可;
	}
}
