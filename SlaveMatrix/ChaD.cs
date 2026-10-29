using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class ChaD
	{
		public bool Is胸甲殻()
		{
			return this.構成.EnumEleD().GetEleD<乳房D>().虫性_甲殻_表示;
		}

		public bool Is股防御()
		{
			半身D eleD = this.構成.半身_接続.GetEleD<半身D>();
			if (eleD is 長物_蛇D)
			{
				return ((長物_蛇D)eleD).ガ\u30FCド;
			}
			if (eleD is 多足_蠍D)
			{
				return true;
			}
			腰肌D eleD2 = this.構成.肌_接続.GetEleD<腰肌D>();
			return eleD2.竜性_鱗1_表示 || eleD2.竜性_鱗2_表示 || eleD2.竜性_鱗3_表示 || eleD2.竜性_鱗4_表示;
		}

		public bool Isタトゥ()
		{
			四足腰D eleD = this.構成.EnumEleD().GetEleD<四足腰D>();
			if (eleD != null)
			{
				腰肌D eleD2 = eleD.EnumEleD().GetEleD<腰肌D>();
				return eleD2.淫タトゥ_タトゥ1右_表示 && eleD2.淫タトゥ_タトゥ1左_表示 && eleD2.淫タトゥ_タトゥ2右_表示 && eleD2.淫タトゥ_タトゥ2左_表示 && eleD2.淫タトゥ_ハ\u30FCト_タトゥ右1_表示 && eleD2.淫タトゥ_ハ\u30FCト_タトゥ右2_表示 && eleD2.淫タトゥ_ハ\u30FCト_タトゥ左1_表示 && eleD2.淫タトゥ_ハ\u30FCト_タトゥ左2_表示;
			}
			腰肌D eleD3 = this.構成.EnumEleD().GetEleD<腰肌D>();
			return eleD3.淫タトゥ_タトゥ1右_表示 && eleD3.淫タトゥ_タトゥ1左_表示 && eleD3.淫タトゥ_タトゥ2右_表示 && eleD3.淫タトゥ_タトゥ2左_表示 && eleD3.淫タトゥ_ハ\u30FCト_タトゥ右1_表示 && eleD3.淫タトゥ_ハ\u30FCト_タトゥ右2_表示 && eleD3.淫タトゥ_ハ\u30FCト_タトゥ左1_表示 && eleD3.淫タトゥ_ハ\u30FCト_タトゥ左2_表示;
		}

		public ChaD(腰D 構成, 体色 体色)
		{
			this.構成 = 構成;
			this.体色 = 体色;
			this.抵抗値 = OthN.XS.NextDouble();
			this.欲望度 = OthN.XS.NextDouble(0.6);
			this.情愛度 = OthN.XS.NextDouble(0.6);
			this.卑屈度 = OthN.XS.NextDouble(0.6);
			this.技巧度 = OthN.XS.NextDouble(0.6);
			this.部位感度 = new Dictionary<接触, double>
			{
				{
					接触.頭,
					OthN.XS.NextDouble(0.6)
				},
				{
					接触.顔,
					OthN.XS.NextDouble(0.6)
				},
				{
					接触.耳,
					OthN.XS.NextDouble(0.6)
				},
				{
					接触.口,
					OthN.XS.NextDouble(0.6)
				},
				{
					接触.髪,
					OthN.XS.NextDouble(0.6)
				},
				{
					接触.首,
					OthN.XS.NextDouble(0.6)
				},
				{
					接触.肩,
					OthN.XS.NextDouble(0.6)
				},
				{
					接触.胸,
					OthN.XS.NextDouble(0.6)
				},
				{
					接触.乳,
					OthN.XS.NextDouble(0.6)
				},
				{
					接触.脇,
					OthN.XS.NextDouble(0.6)
				},
				{
					接触.腹,
					OthN.XS.NextDouble(0.6)
				},
				{
					接触.股,
					OthN.XS.NextDouble(0.6)
				},
				{
					接触.性,
					OthN.XS.NextDouble(0.6)
				},
				{
					接触.膣,
					OthN.XS.NextDouble(0.6)
				},
				{
					接触.核,
					OthN.XS.NextDouble(0.6)
				},
				{
					接触.肛,
					OthN.XS.NextDouble(0.6)
				},
				{
					接触.糸,
					OthN.XS.NextDouble(0.6)
				},
				{
					接触.腿,
					OthN.XS.NextDouble(0.6)
				},
				{
					接触.足,
					OthN.XS.NextDouble(0.6)
				},
				{
					接触.手,
					OthN.XS.NextDouble(0.6)
				},
				{
					接触.覚,
					OthN.XS.NextDouble(0.6)
				},
				{
					接触.触,
					OthN.XS.NextDouble(0.6)
				},
				{
					接触.尾,
					OthN.XS.NextDouble(0.6)
				},
				{
					接触.翼,
					OthN.XS.NextDouble(0.6)
				},
				{
					接触.鰭,
					OthN.XS.NextDouble(0.6)
				},
				{
					接触.他,
					OthN.XS.NextDouble(0.6)
				}
			};
			this.最乳首 = OthN.XS.NextDouble();
			this.最乳房 = 構成.EnumEleD().GetEleD<乳房D>().バスト;
			this.最陰核 = OthN.XS.NextDouble();
			this.素乳首濃度 = 0.3 + OthN.XS.NextDouble(0.5);
			this.最乳首濃度 = OthN.XS.NextDouble(0.19999999999999996);
			this.素性器濃度 = 0.3 + OthN.XS.NextDouble(0.5);
			this.最性器濃度 = OthN.XS.NextDouble(0.19999999999999996);
			this.素肛門濃度 = 0.3 + OthN.XS.NextDouble(0.5);
			this.最肛門濃度 = OthN.XS.NextDouble(0.19999999999999996);
			this.最陰毛濃度 = OthN.XS.NextDouble();
			this.固有値 = OthN.XS.NextDouble();
			this.魔力濃度 = OthN.XS.NextDouble();
			腰肌D eleD = 構成.EnumEleD().GetEleD<腰肌D>();
			if (!eleD.陰毛_表示 && !eleD.獣性_獣毛_表示)
			{
				this.現陰毛 = 0.0;
			}
			this.状態 = 感情.否定;
		}

		public void Setヴィオラ()
		{
			this.抵抗値 = 1.0;
			this.欲望度 = 0.8;
			this.情愛度 = 0.1;
			this.卑屈度 = 0.1;
			this.技巧度 = 0.8;
			this.部位感度 = new Dictionary<接触, double>
			{
				{
					接触.頭,
					0.01
				},
				{
					接触.顔,
					0.01
				},
				{
					接触.耳,
					0.03
				},
				{
					接触.口,
					0.01
				},
				{
					接触.髪,
					0.01
				},
				{
					接触.首,
					0.02
				},
				{
					接触.肩,
					0.01
				},
				{
					接触.胸,
					0.03
				},
				{
					接触.乳,
					0.04
				},
				{
					接触.脇,
					0.01
				},
				{
					接触.腹,
					0.01
				},
				{
					接触.股,
					0.03
				},
				{
					接触.性,
					0.05
				},
				{
					接触.膣,
					0.04
				},
				{
					接触.核,
					0.1
				},
				{
					接触.肛,
					0.01
				},
				{
					接触.糸,
					0.0
				},
				{
					接触.腿,
					0.02
				},
				{
					接触.足,
					0.01
				},
				{
					接触.手,
					0.01
				},
				{
					接触.覚,
					0.0
				},
				{
					接触.触,
					0.01
				},
				{
					接触.尾,
					0.0
				},
				{
					接触.翼,
					0.02
				},
				{
					接触.鰭,
					0.0
				},
				{
					接触.他,
					0.01
				}
			};
			this.現陰毛 = 0.0;
			this.最乳首 = 0.85;
			this.最乳房 = 0.85;
			this.最陰核 = 0.85;
			this.素乳首濃度 = 0.5;
			this.最乳首濃度 = 0.5;
			this.素性器濃度 = 0.5;
			this.最性器濃度 = 0.5;
			this.素肛門濃度 = 0.5;
			this.最肛門濃度 = 0.5;
			this.最陰毛濃度 = 0.8;
			this.固有値 = 0.99;
			this.魔力濃度 = 1.0;
		}

		public void 娼婦調教(double 技巧最大値)
		{
			this.欲望度 = (this.欲望度 + 0.01 * OthN.XS.NextDouble()).LimitM(0.0, 1.0);
			this.卑屈度 = (this.卑屈度 + 0.01 * OthN.XS.NextDouble()).LimitM(0.0, 1.0);
			this.技巧度 = (this.技巧度 + 0.01 * OthN.XS.NextDouble()).LimitM(0.0, 技巧最大値);
		}

		public void 欲望補正()
		{
			this.欲望度 = (this.欲望度 + OthN.XS.NextDouble(this.欲望度)).LimitM(0.0, 1.0);
		}

		public void 情愛補正()
		{
			this.情愛度 = (this.情愛度 + OthN.XS.NextDouble(this.情愛度)).LimitM(0.0, 1.0);
		}

		public void 卑屈補正()
		{
			this.卑屈度 = (this.卑屈度 + OthN.XS.NextDouble(this.卑屈度)).LimitM(0.0, 1.0);
		}

		public void 技巧補正()
		{
			this.技巧度 = (this.技巧度 + OthN.XS.NextDouble(this.技巧度)).LimitM(0.0, 1.0);
		}

		public Unit Parent;

		public 腰D 構成;

		public 体色 体色;

		public double 体力 = 1.0;

		public double 感度;

		public double 興奮;

		public double 潤滑;

		public double 緊張 = 1.0;

		public double 羞恥;

		public double 抵抗値;

		public double 欲望度;

		public double 情愛度;

		public double 卑屈度;

		public double 技巧度;

		public Dictionary<接触, double> 部位感度;

		public double 現乳首;

		public double 現乳房;

		public double 現陰核;

		public double 現性器;

		public double 現肛門;

		public double 現陰毛 = 1.0;

		public double 最乳首;

		public double 最乳房;

		public double 最陰核;

		public double 素乳首濃度;

		public double 最乳首濃度;

		public double 素性器濃度;

		public double 最性器濃度;

		public double 素肛門濃度;

		public double 最肛門濃度;

		public double 最陰毛濃度;

		public double 固有値;

		public double 魔力濃度;

		public 感情 状態;

		public bool 撮影ピ\u30FCス経験;

		public double 放尿経験値;

		public bool 胸施術;

		public bool 股施術;

		public bool タトゥ;
	}
}
