using System;
using System.Drawing;
using System.Linq;
using System.Reflection;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public static class 原種
	{
		public static void 尺度調整(this 腰D 腰, 頭D 頭)
		{
			foreach (EleD eleD in 頭.EnumEleD())
			{
				if (!(eleD is 後髪0D) && !(eleD is 後髪1D) && !(eleD is 横髪D) && !(eleD is 前髪D))
				{
					eleD.尺度B *= 0.98;
				}
			}
			foreach (EleD eleD2 in 腰.EnumEleD())
			{
				eleD2.尺度B *= 1.065;
			}
		}

		public static MethodInfo Get原種()
		{
			string rt = typeof(ChaD).ToString();
			return (from e in typeof(原種).GetMethods()
			where !(e.Name == "Get原種") && !(e.Name == "Get本体") && !(e.Name == "GetAll") && e.ReturnType.ToString() == rt
			orderby OthN.XS.Next()
			select e).First<MethodInfo>();
		}

		public static ChaD Get本体(this MethodInfo m)
		{
			return (ChaD)m.Invoke(typeof(原種), null);
		}

		public static void Set下毛(this 腰D 腰)
		{
			腰肌D eleD = 腰.肌_接続.GetEleD<腰肌D>();
			if (eleD.獣性_獣毛_表示)
			{
				if (OthN.XS.NextBool())
				{
					eleD.獣性_獣毛_表示 = false;
					eleD.陰毛_表示 = true;
					return;
				}
			}
			else if (eleD.陰毛_表示)
			{
				if (0.023.Lot())
				{
					eleD.陰毛_表示 = false;
					return;
				}
			}
			else if (0.023.Inverse().Lot())
			{
				eleD.陰毛_表示 = true;
			}
		}

		public static ChaD Getハ\u30FCピ\u30FC()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			switch (OthN.XS.Next(4))
			{
			case 0:
				頭D.Set耳人();
				break;
			case 1:
				頭D.Set耳尖();
				break;
			case 2:
				頭D.Set耳獣();
				break;
			default:
				頭D.Set耳羽();
				break;
			}
			手_鳥D 手_鳥D = new 手_鳥D
			{
				シャ\u30FCプ = OthN.XS.NextDouble()
			};
			下腕_鳥D 下腕_鳥D = new 下腕_鳥D
			{
				シャ\u30FCプ = 手_鳥D.シャ\u30FCプ
			};
			下腕_鳥D.手接続(手_鳥D);
			上腕_鳥D 上腕_鳥D = new 上腕_鳥D
			{
				シャ\u30FCプ = 下腕_鳥D.シャ\u30FCプ
			};
			上腕_鳥D.下腕接続(下腕_鳥D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_鳥D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			胸D.背中接続(new 背中_羽D());
			足_鳥D e = new 足_鳥D();
			脚_鳥D 脚_鳥D = new 脚_鳥D();
			脚_鳥D.足接続(e);
			腿_鳥D 腿_鳥D = new 腿_鳥D();
			腿_鳥D.脚接続(脚_鳥D);
			腰D.腿左接続(腿_鳥D);
			腰D.腿右接続(腿_鳥D.Get逆());
			腰D.尾接続(new 尾_鳥D());
			bool flag = 頭D.EnumEleD().IsEleD<耳_羽D>() || 頭D.EnumEleD().IsEleD<耳_獣D>();
			腰D.EnumEleD().SetValuesD("獣性", flag);
			腰D.EnumEleD().SetValuesD("髭", false);
			if (flag)
			{
				腰D.EnumEleD().SetValuesD("表示", OthN.XS.NextBool());
			}
			else
			{
				腰D.EnumEleD().SetValuesD("表示", false);
			}
			腰D.EnumEleD().SetValuesD("獣性", true);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(OthN.XS.NextBool()));
		}

		public static ChaD Getアフ\u30FCル()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			基髪D eleD = 頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻R();
			頭D.Set口人();
			頭D.Set舌短();
			EleD eleD2 = new 獣耳D
			{
				尺度B = 1.2
			};
			eleD.頭頂左接続(eleD2);
			eleD.頭頂右接続(eleD2.Get逆());
			手_蝙D e = new 手_蝙D();
			下腕_蝙D 下腕_蝙D = new 下腕_蝙D();
			下腕_蝙D.手接続(e);
			上腕_蝙D 上腕_蝙D = new 上腕_蝙D();
			上腕_蝙D.下腕接続(下腕_蝙D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_蝙D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			足_獣D e2 = new 足_獣D();
			脚_獣D 脚_獣D = new 脚_獣D();
			脚_獣D.足接続(e2);
			腿_獣D 腿_獣D = new 腿_獣D();
			腿_獣D.脚接続(脚_獣D);
			腰D.腿左接続(腿_獣D);
			腰D.腿右接続(腿_獣D.Get逆());
			腰D.尾接続(new 尾_悪D());
			腰D.EnumEleD().SetValuesD("獣性", true);
			腰D.EnumEleD().SetValuesD("髭", false);
			腰D.EnumEleD().SetValuesD("表示", OthN.XS.NextBool());
			腰D.EnumEleD().SetValuesD("牙", true);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(false));
		}

		public static ChaD Getハルピュイア()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			if (OthN.XS.NextBool())
			{
				頭D.Set耳人();
			}
			else
			{
				頭D.Set耳尖();
			}
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			手_蝙D e2 = new 手_蝙D
			{
				シャ\u30FCプ = 1.0
			};
			下腕_蝙D 下腕_蝙D = new 下腕_蝙D();
			下腕_蝙D.手接続(e2);
			上腕_蝙D 上腕_蝙D = new 上腕_蝙D();
			上腕_蝙D.下腕接続(下腕_蝙D);
			胸D.翼上左接続(上腕_蝙D);
			胸D.翼上右接続(上腕_蝙D.Get逆());
			長物_鯨D 長物_鯨D = new 長物_鯨D();
			腰D.半身接続(長物_鯨D);
			長物_鯨D.尾接続(new 尾_鯨D());
			腰D.EnumEleD().SetValuesD("獣毛1", true);
			腰D.EnumEleD().SetValuesD("獣腕", true);
			腰D.EnumEleD().SetValuesD("獣性", true);
			腰D.EnumEleD().SetValuesD("肉球", false);
			腰D.EnumEleD().SetValuesD("配色指定", 配色指定.B0);
			腰D.EnumEleD().SetValuesD("配色指定", 配色指定.B0);
			腰D.EnumEleD().SetValuesD("柄", false);
			腰D.EnumEleD().SetValuesD("紋柄", true);
			腰D.EnumEleD().SetValuesD("紋柄", false);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(OthN.XS.NextBool()));
		}

		public static ChaD Getフェニックス()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			頭D.Set耳羽();
			手_鳥D 手_鳥D = new 手_鳥D
			{
				シャ\u30FCプ = OthN.XS.NextDouble()
			};
			下腕_鳥D 下腕_鳥D = new 下腕_鳥D
			{
				シャ\u30FCプ = 手_鳥D.シャ\u30FCプ
			};
			下腕_鳥D.手接続(手_鳥D);
			上腕_鳥D 上腕_鳥D = new 上腕_鳥D
			{
				シャ\u30FCプ = 下腕_鳥D.シャ\u30FCプ
			};
			上腕_鳥D.下腕接続(下腕_鳥D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_鳥D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			胸D.背中接続(new 背中_羽D());
			足_鳥D e = new 足_鳥D();
			脚_鳥D 脚_鳥D = new 脚_鳥D();
			脚_鳥D.足接続(e);
			腿_鳥D 腿_鳥D = new 腿_鳥D();
			腿_鳥D.脚接続(脚_鳥D);
			腰D.腿左接続(腿_鳥D);
			腰D.腿右接続(腿_鳥D.Get逆());
			腰D.尾接続(new 鳳凰D());
			腰D.尾接続(new 鳳凰D());
			腰D.尾接続(new 鳳凰D());
			腰D.尾接続(new 鳳凰D());
			腰D.尾接続(new 鳳凰D());
			腰D.尾接続(new 尾_鳥D());
			腰D.EnumEleD().SetValuesD("獣性", true);
			腰D.EnumEleD().SetValuesD("髭", false);
			腰D.EnumEleD().SetValuesD("隈取", true);
			頭D.隈取_タトゥ_表示 = false;
			腰D.EnumEleD().SetValuesD("淫", true);
			腰D.EnumEleD().SetValuesD("ハート", false);
			腰D.SetValuesD("悪", true);
			腰D.EnumEleD().SetValuesD("植", true);
			腰D.EnumEleD().SetValuesD("竜性", true);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(false));
		}

		public static ChaD Getラミア()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌長();
			if (OthN.XS.NextBool())
			{
				頭D.Set耳人();
			}
			else
			{
				頭D.Set耳尖();
			}
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			長物_蛇D 長物_蛇D = new 長物_蛇D();
			腰D.半身接続(長物_蛇D);
			長物_蛇D.くぱぁ = 1.0;
			長物_蛇D.ガ\u30FCド = false;
			胴_蛇D 胴_蛇D = new 胴_蛇D();
			長物_蛇D.胴接続(胴_蛇D);
			for (int i = 0; i < 40; i++)
			{
				胴_蛇D.胴接続(胴_蛇D = new 胴_蛇D());
			}
			胴_蛇D.胴接続(new 尾_ヘD());
			腰D.EnumEleD().SetValuesD("牙", true);
			腰D.EnumEleD().SetValuesD("股舌表示", true);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(OthN.XS.NextBool()));
		}

		public static ChaD Getシ\u30FCラミア()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌長();
			頭D.Set耳鰭();
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			長物_蛇D 長物_蛇D = new 長物_蛇D();
			腰D.半身接続(長物_蛇D);
			if (OthN.XS.NextBool())
			{
				長物_蛇D.くぱぁ = 1.0;
				長物_蛇D.ガ\u30FCド = false;
			}
			胴_蛇D 胴_蛇D = new 胴_蛇D();
			長物_蛇D.胴接続(胴_蛇D);
			for (int i = 0; i < 40; i++)
			{
				胴_蛇D.胴接続(胴_蛇D = new 胴_蛇D());
			}
			胴_蛇D.胴接続(new 尾_ウD());
			腰D.EnumEleD().SetValuesD("牙", true);
			腰D.EnumEleD().SetValuesD("股舌表示", true);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(OthN.XS.NextBool()));
		}

		public static ChaD Getオノケンタウレ()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			頭D.Set耳獣();
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			四足胸D 四足胸D = Uni.四足胸();
			腰D.半身接続(四足胸D);
			四足胴D 四足胴D = Uni.四足胴();
			四足胸D.胴接続(四足胴D);
			四足腰D 四足腰D = Uni.四足腰();
			四足胴D.腰接続(四足腰D);
			手_馬D e2 = new 手_馬D();
			下腕_蹄D 下腕_蹄D = new 下腕_蹄D();
			下腕_蹄D.手接続(e2);
			上腕_蹄D 上腕_蹄D = new 上腕_蹄D();
			上腕_蹄D.下腕接続(下腕_蹄D);
			四足脇D 四足脇D = new 四足脇D();
			四足脇D.上腕接続(上腕_蹄D);
			四足胸D.脇左接続(四足脇D);
			四足胸D.脇右接続(四足脇D.Get逆());
			足_馬D e3 = new 足_馬D();
			脚_蹄D 脚_蹄D = new 脚_蹄D();
			脚_蹄D.足接続(e3);
			腿_蹄D 腿_蹄D = new 腿_蹄D();
			腿_蹄D.脚接続(脚_蹄D);
			四足腰D.腿左接続(腿_蹄D);
			四足腰D.腿右接続(腿_蹄D.Get逆());
			四足腰D.尾接続(new 尾_牛D());
			腰D.EnumEleD().SetValuesD("表示", false);
			腰D.EnumEleD().SetValuesD("表示", false);
			腰D.EnumEleD().SetValuesD("獣性", true);
			四足腰D.EnumEleD().SetValuesD("獣性", false);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 0.0);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(OthN.XS.NextBool()));
		}

		public static ChaD Getヒッポケンタウレ()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			if (OthN.XS.Next(2) == 0)
			{
				頭D.Set耳人();
			}
			else
			{
				頭D.Set耳尖();
			}
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			四足胸D 四足胸D = Uni.四足胸();
			腰D.半身接続(四足胸D);
			四足胴D 四足胴D = Uni.四足胴();
			四足胸D.胴接続(四足胴D);
			四足腰D 四足腰D = Uni.四足腰();
			四足胴D.腰接続(四足腰D);
			手_馬D e2 = new 手_馬D();
			下腕_蹄D 下腕_蹄D = new 下腕_蹄D();
			下腕_蹄D.手接続(e2);
			上腕_蹄D 上腕_蹄D = new 上腕_蹄D();
			上腕_蹄D.下腕接続(下腕_蹄D);
			四足脇D 四足脇D = new 四足脇D();
			四足脇D.上腕接続(上腕_蹄D);
			四足胸D.脇左接続(四足脇D);
			四足胸D.脇右接続(四足脇D.Get逆());
			足_馬D e3 = new 足_馬D();
			脚_蹄D 脚_蹄D = new 脚_蹄D();
			脚_蹄D.足接続(e3);
			腿_蹄D 腿_蹄D = new 腿_蹄D();
			腿_蹄D.脚接続(脚_蹄D);
			四足腰D.腿左接続(腿_蹄D);
			四足腰D.腿右接続(腿_蹄D.Get逆());
			四足腰D.尾接続(new 尾_馬D());
			if (OthN.XS.NextBool())
			{
				腰D.EnumEleD().SetValuesD("馬", OthN.XS.NextBool());
			}
			腰D.EnumEleD().SetValuesD("表示", false);
			腰D.EnumEleD().SetValuesD("表示", false);
			腰D.EnumEleD().SetValuesD("獣性", true);
			四足腰D.EnumEleD().SetValuesD("獣性", false);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(OthN.XS.NextBool()));
		}

		public static ChaD Getブケンタウレ()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			基髪D eleD = 頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			頭D.Set耳獣();
			EleD eleD2;
			switch (OthN.XS.Next(4))
			{
			case 0:
				eleD2 = new 角2_牛1D();
				break;
			case 1:
				eleD2 = new 角2_牛2D();
				break;
			case 2:
				eleD2 = new 角2_牛3D();
				break;
			default:
				eleD2 = new 角2_牛4D();
				break;
			}
			eleD.頭頂左接続(eleD2);
			eleD.頭頂右接続(eleD2.Get逆());
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			四足胸D 四足胸D = Uni.四足胸();
			腰D.半身接続(四足胸D);
			四足胴D 四足胴D = Uni.四足胴();
			四足胸D.胴接続(四足胴D);
			四足腰D 四足腰D = Uni.四足腰();
			四足胴D.腰接続(四足腰D);
			手_牛D e2 = new 手_牛D();
			下腕_蹄D 下腕_蹄D = new 下腕_蹄D();
			下腕_蹄D.手接続(e2);
			上腕_蹄D 上腕_蹄D = new 上腕_蹄D();
			上腕_蹄D.下腕接続(下腕_蹄D);
			四足脇D 四足脇D = new 四足脇D();
			四足脇D.上腕接続(上腕_蹄D);
			四足胸D.脇左接続(四足脇D);
			四足胸D.脇右接続(四足脇D.Get逆());
			足_牛D e3 = new 足_牛D();
			脚_蹄D 脚_蹄D = new 脚_蹄D();
			脚_蹄D.足接続(e3);
			腿_蹄D 腿_蹄D = new 腿_蹄D();
			腿_蹄D.脚接続(脚_蹄D);
			四足腰D.腿左接続(腿_蹄D);
			四足腰D.腿右接続(腿_蹄D.Get逆());
			四足腰D.尾接続(new 尾_牛D());
			if (OthN.XS.NextBool())
			{
				腰D.EnumEleD().SetValuesD("牛", true);
				腰D.EnumEleD().SetValuesD("配色指定", 配色指定.H0);
			}
			腰D.EnumEleD().SetValuesD("表示", false);
			腰D.EnumEleD().SetValuesD("表示", false);
			腰D.EnumEleD().SetValuesD("獣性", true);
			四足腰D.EnumEleD().SetValuesD("獣性", false);
			腰D.EnumEleD().SetValuesD("バスト", 1.0);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(OthN.XS.NextBool()));
		}

		public static ChaD Getカプラケンタウレ()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			基髪D eleD = 頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			頭D.Set耳獣();
			EleD eleD2;
			switch (OthN.XS.Next(4))
			{
			case 0:
				eleD2 = new 角2_山1D();
				break;
			case 1:
				eleD2 = new 角2_山2D();
				break;
			case 2:
				eleD2 = new 角2_山3D();
				break;
			default:
				eleD2 = new 角2_巻D();
				break;
			}
			eleD.頭頂左接続(eleD2);
			eleD.頭頂右接続(eleD2.Get逆());
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			四足胸D 四足胸D = Uni.四足胸();
			腰D.半身接続(四足胸D);
			四足胴D 四足胴D = Uni.四足胴();
			四足胸D.胴接続(四足胴D);
			四足腰D 四足腰D = Uni.四足腰();
			四足胴D.腰接続(四足腰D);
			四足胸D.背中接続(new 背中_羽D
			{
				毛 = true
			});
			手_牛D e2 = new 手_牛D();
			下腕_蹄D 下腕_蹄D = new 下腕_蹄D();
			下腕_蹄D.手接続(e2);
			上腕_蹄D 上腕_蹄D = new 上腕_蹄D();
			上腕_蹄D.下腕接続(下腕_蹄D);
			四足脇D 四足脇D = new 四足脇D();
			四足脇D.上腕接続(上腕_蹄D);
			四足胸D.脇左接続(四足脇D);
			四足胸D.脇右接続(四足脇D.Get逆());
			足_牛D e3 = new 足_牛D();
			脚_蹄D 脚_蹄D = new 脚_蹄D();
			脚_蹄D.足接続(e3);
			腿_蹄D 腿_蹄D = new 腿_蹄D();
			腿_蹄D.脚接続(脚_蹄D);
			四足腰D.腿左接続(腿_蹄D);
			四足腰D.腿右接続(腿_蹄D.Get逆());
			四足腰D.尾接続(new 尾_犬D());
			四足胴D.SetValuesD("獣毛", true);
			腰D.EnumEleD().SetValuesD("胸毛", true);
			腰D.EnumEleD().SetValuesD("獣毛", true);
			腰D.EnumEleD().SetValuesD("表示", false);
			腰D.EnumEleD().SetValuesD("表示", false);
			腰D.EnumEleD().SetValuesD("蛸目", OthN.XS.NextBool());
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(OthN.XS.NextBool()));
		}

		public static ChaD Getマ\u30FCメイド()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			頭D.Set耳人();
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			長物_魚D 長物_魚D = new 長物_魚D();
			腰D.半身接続(長物_魚D);
			尾_魚D 尾_魚D = new 尾_魚D();
			長物_魚D.尾接続(尾_魚D);
			尾_魚D.尾先接続(new 尾鰭_魚D());
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(OthN.XS.NextBool()));
		}

		public static ChaD Getドルフィンマ\u30FCメイド()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			頭D.Set耳尖();
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			長物_鯨D 長物_鯨D = new 長物_鯨D();
			腰D.半身接続(長物_鯨D);
			尾_鯨D 尾_鯨D = new 尾_鯨D();
			長物_鯨D.尾接続(尾_鯨D);
			尾_鯨D.尾先接続(new 尾鰭_鯨D());
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(OthN.XS.NextBool()));
		}

		public static ChaD Getオ\u30FCルドマ\u30FCメイド()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			頭D.Set耳人();
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			尾_魚D 尾_魚D = new 尾_魚D();
			尾_魚D.尺度B = 1.2;
			尾_魚D.尺度YB = 1.5;
			尾_魚D.尾0_表示 = false;
			尾_魚D.尾0_鱗右_鱗1_表示 = false;
			尾_魚D.尾0_鱗右_鱗2_表示 = false;
			尾_魚D.尾先接続(new 尾鰭_魚D());
			腰D.腿左接続(尾_魚D);
			腰D.腿右接続(尾_魚D.Get逆());
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(OthN.XS.NextBool()));
		}

		public static ChaD Getイクテュオケンタウレ(bool b)
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			頭D.Set耳鰭();
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			if (b)
			{
				長物_魚D 長物_魚D = new 長物_魚D();
				腰D.半身接続(長物_魚D);
				EleD eleD = new 鰭_魚D();
				長物_魚D.左0接続(eleD);
				長物_魚D.右0接続(eleD.Get逆());
				尾_魚D 尾_魚D = new 尾_魚D();
				長物_魚D.尾接続(尾_魚D);
				尾_魚D.尾先接続(new 尾鰭_魚D());
			}
			else
			{
				長物_蛇D 長物_蛇D = new 長物_蛇D();
				腰D.半身接続(長物_蛇D);
				if (OthN.XS.NextBool())
				{
					長物_蛇D.くぱぁ = 1.0;
					長物_蛇D.ガ\u30FCド = false;
				}
				EleD eleD = new 鰭_魚D();
				長物_蛇D.左接続(eleD);
				長物_蛇D.右接続(eleD.Get逆());
				胴_蛇D 胴_蛇D = new 胴_蛇D();
				長物_蛇D.胴接続(胴_蛇D);
				尾_ヘD 尾_ヘD = new 尾_ヘD();
				胴_蛇D.胴接続(尾_ヘD);
				尾_ヘD.尾先接続(new 尾鰭_魚D());
			}
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(OthN.XS.NextBool()));
		}

		public static ChaD Getデルピヌスケンタウレ()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			頭D.Set耳尖();
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			長物_鯨D 長物_鯨D = new 長物_鯨D();
			腰D.半身接続(長物_鯨D);
			EleD eleD = new 鰭_豚D();
			長物_鯨D.左0接続(eleD);
			長物_鯨D.右0接続(eleD.Get逆());
			尾_鯨D 尾_鯨D = new 尾_鯨D();
			長物_鯨D.尾接続(尾_鯨D);
			尾_鯨D.尾先接続(new 尾鰭_鯨D());
			腰D.EnumEleD().SetValuesD("豹", true);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(OthN.XS.NextBool()));
		}

		public static ChaD Getスキュラ()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			if (OthN.XS.NextBool())
			{
				頭D.Set耳尖();
			}
			else
			{
				頭D.Set耳人();
			}
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			多足_蛸D 多足_蛸D = new 多足_蛸D();
			腰D.半身接続(多足_蛸D);
			触手_軟D 触手_軟D = new 触手_軟D
			{
				後足 = true
			};
			触手_軟D 触手_軟D2 = new 触手_軟D
			{
				前足 = true
			};
			if (OthN.XS.NextBool())
			{
				触手_軟D.SetValuesD("鎧", true);
				触手_軟D2.SetValuesD("鎧", true);
			}
			多足_蛸D.軟体内左接続(触手_軟D.Copy());
			多足_蛸D.軟体内右接続(触手_軟D.Get逆());
			多足_蛸D.軟体外左接続(触手_軟D2.Copy());
			多足_蛸D.軟体外右接続(触手_軟D2.Get逆());
			多足_蛸D.軟体外左接続(触手_軟D2.Copy());
			多足_蛸D.軟体外右接続(触手_軟D2.Get逆());
			多足_蛸D.軟体外左接続(触手_軟D2.Copy());
			多足_蛸D.軟体外右接続(触手_軟D2.Get逆());
			if (OthN.XS.NextBool())
			{
				腰D.EnumEleD().SetValuesD("紋柄", true);
			}
			if (OthN.XS.NextBool())
			{
				腰D.EnumEleD().SetValuesD("紋柄", false);
			}
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(OthN.XS.NextBool()));
		}

		public static ChaD Getオ\u30FCルドスキュラ(bool b)
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			if (OthN.XS.NextBool())
			{
				頭D.Set耳尖();
			}
			else
			{
				頭D.Set耳人();
			}
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			触手_犬D 触手_犬D = new 触手_犬D();
			触手_犬D.SetValuesD("脚", b);
			if (b)
			{
				触手_犬D.SetValuesD("鰭", OthN.XS.NextBool());
			}
			腰D.腿左接続(触手_犬D.Copy());
			腰D.腿右接続(触手_犬D.Get逆());
			腰D.腿左接続(触手_犬D.Copy());
			腰D.腿右接続(触手_犬D.Get逆());
			腰D.腿左接続(触手_犬D.Copy());
			腰D.腿右接続(触手_犬D.Get逆());
			長物_魚D 長物_魚D = new 長物_魚D();
			腰D.半身接続(長物_魚D);
			尾_魚D 尾_魚D = new 尾_魚D();
			長物_魚D.尾接続(尾_魚D);
			尾_魚D.尾先接続(new 尾鰭_魚D());
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(OthN.XS.NextBool()));
		}

		public static ChaD Getカリュブディス()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			基髪D eleD = 頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口裂();
			頭D.Set舌長();
			頭D.Set耳鰭();
			EleD eleD2;
			switch (OthN.XS.Next(4))
			{
			case 0:
				eleD2 = new 角2_牛1D();
				break;
			case 1:
				eleD2 = new 角2_牛2D();
				break;
			case 2:
				eleD2 = new 角2_牛3D();
				break;
			default:
				eleD2 = new 角2_牛4D();
				break;
			}
			eleD.頭頂左接続(eleD2);
			eleD.頭頂右接続(eleD2.Get逆());
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			長物_鯨D 長物_鯨D = new 長物_鯨D();
			腰D.半身接続(長物_鯨D);
			eleD2 = new 鰭_鯨D();
			長物_鯨D.左0接続(eleD2);
			長物_鯨D.右0接続(eleD2.Get逆());
			尾_鯨D 尾_鯨D = new 尾_鯨D();
			長物_鯨D.尾接続(尾_鯨D);
			尾_鯨D.尾先接続(new 尾鰭_鯨D());
			腰D.EnumEleD().SetValuesD("水掻", true);
			腰D.EnumEleD().SetValuesD("竜性", true);
			腰D.EnumEleD().SetValuesD("獣毛", true);
			腰D.EnumEleD().SetValuesD("表示", true);
			腰D.EnumEleD().SetValuesD("悪", true);
			腰D.EnumEleD().SetValuesD("悪", false);
			腰D.EnumEleD().SetValuesD("悪", false);
			腰D.EnumEleD().SetValuesD("逆十字", false);
			腰D.EnumEleD().SetValuesD("淫", true);
			腰D.EnumEleD().SetValuesD("鱗", false);
			腰D.EnumEleD().SetValuesD("毛", false);
			腰D.EnumEleD().SetValuesD("鱗", false);
			腰D.EnumEleD().SetValuesD("毛", false);
			腰D.EnumEleD().SetValuesD("配色", 配色指定.S0);
			腰D.EnumEleD().SetValuesD("肥大", 1.0);
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(false));
		}

		public static ChaD Getアラクネ(bool b)
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			if (OthN.XS.NextBool())
			{
				頭D.Set耳尖();
			}
			else
			{
				頭D.Set耳人();
			}
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			if (OthN.XS.NextBool())
			{
				EleD eleD = new 虫顎D();
				頭D.頬左接続(eleD);
				頭D.頬右接続(eleD.Get逆());
			}
			多足_蜘D 多足_蜘D = new 多足_蜘D();
			腰D.半身接続(多足_蜘D);
			尾_蜘D 尾_蜘D = new 尾_蜘D();
			尾_蜘D.出糸 = OthN.XS.NextBool();
			多足_蜘D.尾接続(尾_蜘D);
			触肢_肢蜘D 触肢_肢蜘D = new 触肢_肢蜘D();
			節足_足蜘D 節足_足蜘D = new 節足_足蜘D();
			節足_足蜘D.爪 = b;
			EleD eleD2 = 節足_足蜘D.Copy();
			EleD eleD3 = 節足_足蜘D.Copy();
			eleD3.反転Y = !尾_蜘D.出糸;
			EleD eleD4 = 節足_足蜘D.Copy();
			eleD4.反転Y = eleD3.反転Y;
			多足_蜘D.触肢左接続(触肢_肢蜘D);
			多足_蜘D.節足左1接続(節足_足蜘D);
			多足_蜘D.節足左2接続(eleD2);
			多足_蜘D.節足左3接続(eleD3);
			多足_蜘D.節足左4接続(eleD4);
			多足_蜘D.触肢右接続(触肢_肢蜘D.Get逆());
			多足_蜘D.節足右1接続(節足_足蜘D.Get逆());
			多足_蜘D.節足右2接続(eleD2.Get逆());
			多足_蜘D.節足右3接続(eleD3.Get逆());
			多足_蜘D.節足右4接続(eleD4.Get逆());
			if (OthN.XS.NextBool())
			{
				腰D.EnumEleD().SetValuesD("牙", true);
			}
			if (OthN.XS.NextBool())
			{
				多足_蜘D.EnumEleD().SetValuesD("柄", true);
			}
			腰D.EnumEleD().SetValuesD("蜘", 頭D.頬左_接続.IsEleD<虫顎D>() || OthN.XS.NextBool());
			腰D.EnumEleD().SetValuesD("蜘", OthN.XS.NextBool());
			腰D.EnumEleD().SetValuesD("蜘", OthN.XS.NextBool());
			if (頭D.頬左_接続.IsEleD<虫顎D>())
			{
				腰D.EnumEleD().SetValuesD("蜘", false);
			}
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(OthN.XS.NextBool()));
		}

		public static ChaD Getギルタブリル()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			if (OthN.XS.NextBool())
			{
				頭D.Set耳尖();
			}
			else
			{
				頭D.Set耳人();
			}
			if (OthN.XS.NextBool())
			{
				EleD eleD = new 虫顎D();
				頭D.頬左接続(eleD);
				頭D.頬右接続(eleD.Get逆());
			}
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			多足_蠍D 多足_蠍D = new 多足_蠍D();
			腰D.半身接続(多足_蠍D);
			多足_蠍D.前腹_腹節3_節線_表示 = OthN.XS.NextBool();
			多足_蠍D.前腹_腹節4_節線_表示 = 多足_蠍D.前腹_腹節3_節線_表示;
			多足_蠍D.前腹_腹節5_節線_表示 = 多足_蠍D.前腹_腹節3_節線_表示;
			多足_蠍D.前腹_腹節6_節線_表示 = 多足_蠍D.前腹_腹節3_節線_表示;
			触肢_肢蠍D 触肢_肢蠍D = new 触肢_肢蠍D();
			節足_足蠍D 節足_足蠍D = new 節足_足蠍D();
			節足_足蠍D.爪 = OthN.XS.NextBool();
			EleD eleD2 = 節足_足蠍D.Copy();
			EleD eleD3 = 節足_足蠍D.Copy();
			EleD eleD4 = 節足_足蠍D.Copy();
			多足_蠍D.触肢左接続(触肢_肢蠍D);
			多足_蠍D.節足左1接続(節足_足蠍D);
			多足_蠍D.節足左2接続(eleD2);
			多足_蠍D.節足左3接続(eleD3);
			多足_蠍D.節足左4接続(eleD4);
			多足_蠍D.触肢右接続(触肢_肢蠍D.Get逆());
			多足_蠍D.節足右1接続(節足_足蠍D.Get逆());
			多足_蠍D.節足右2接続(eleD2.Get逆());
			多足_蠍D.節足右3接続(eleD3.Get逆());
			多足_蠍D.節足右4接続(eleD4.Get逆());
			if (OthN.XS.NextBool())
			{
				EleD eleD = new 触覚_蠍D();
				多足_蠍D.櫛状板左接続(eleD);
				多足_蠍D.櫛状板右接続(eleD.Get逆());
			}
			多足_蠍D.尾接続(new 尾_蠍D());
			腰D.EnumEleD().SetValuesD("タトゥ", true);
			腰D.EnumEleD().SetValuesD("ハート", false);
			腰D.EnumEleD().SetValuesD("逆十字", false);
			腰D.EnumEleD().SetValuesD("淫", false);
			腰D.EnumEleD().SetValuesD("植", false);
			腰D.EnumEleD().SetValuesD("タトゥ", false);
			腰D.EnumEleD().SetValuesD("植", false);
			腰D.EnumEleD().SetValuesD("悪", false);
			if (OthN.XS.NextBool())
			{
				腰D.EnumEleD().SetValuesD("牙", true);
			}
			if (OthN.XS.NextBool())
			{
				多足_蠍D.EnumEleD().SetValuesD("柄", true);
			}
			腰D.EnumEleD().SetValuesD("蜘", 頭D.頬左_接続.IsEleD<虫顎D>() || OthN.XS.NextBool());
			腰D.EnumEleD().SetValuesD("蜘", OthN.XS.NextBool());
			if (頭D.頬左_接続.IsEleD<虫顎D>())
			{
				腰D.EnumEleD().SetValuesD("蜘", false);
			}
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(OthN.XS.NextBool()));
		}

		public static ChaD Getギルタブルル()
		{
			腰D 腰D = Uni.腰();
			胴D 胴D = 腰D.Set胴();
			胸D 胸D = 胴D.Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			基髪D eleD = 頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			頭D.Set耳尖();
			頭D.額接続(new 角1_虫D());
			EleD eleD2 = new 角2_虫D();
			eleD2.SetValuesD("棘", true);
			eleD.頭頂左接続(eleD2);
			eleD.頭頂右接続(eleD2.Get逆());
			顔面_甲D e = new 顔面_甲D();
			頭D.顔面接続(e);
			手_人D e2 = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e2);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			if (OthN.XS.NextBool())
			{
				手_鳥D e3 = new 手_鳥D();
				下腕_鳥D 下腕_鳥D = new 下腕_鳥D();
				下腕_鳥D.手接続(e3);
				上腕_鳥D 上腕_鳥D = new 上腕_鳥D();
				上腕_鳥D.下腕接続(下腕_鳥D);
				胸D.翼上左接続(上腕_鳥D);
				胸D.翼上右接続(上腕_鳥D.Get逆());
			}
			足_鳥D e4 = new 足_鳥D();
			脚_鳥D 脚_鳥D = new 脚_鳥D();
			脚_鳥D.足接続(e4);
			腿_鳥D 腿_鳥D = new 腿_鳥D();
			腿_鳥D.脚接続(脚_鳥D);
			腰D.腿左接続(腿_鳥D);
			腰D.腿右接続(腿_鳥D.Get逆());
			腰D.尾接続(new 尾_鳥D());
			腰D.尾接続(new 尾_蛇D());
			eleD2 = new 尾_蠍D();
			胴D.翼左接続(eleD2);
			胴D.翼右接続(eleD2.Get逆());
			腰D.EnumEleD().SetValuesD("タトゥ", true);
			腰D.EnumEleD().SetValuesD("ハート", false);
			腰D.EnumEleD().SetValuesD("タトゥ", false);
			腰D.EnumEleD().SetValuesD("植", false);
			腰D.EnumEleD().SetValuesD("植", false);
			腰D.EnumEleD().SetValuesD("逆十字", false);
			腰D.EnumEleD().SetValuesD("顎下", true);
			腰D.EnumEleD().SetValuesD("獣", true);
			腰D.EnumEleD().SetValuesD("獣", true);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(false));
		}

		public static ChaD Getアルラウネ()
		{
			腰D 腰D = Uni.腰();
			胴D 胴D = 腰D.Set胴();
			胸D 胸D = 胴D.Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			基髪D eleD = 頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			頭D.Set耳尖();
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			植D 植D = new 植D();
			EleD eleD2 = Con.Get花R(false);
			植D.花接続(eleD2);
			bool flag = OthN.XS.NextBool();
			if (eleD2 is 花_百D)
			{
				((花_百D)eleD2).萼_萼_表示 = !flag;
			}
			植D.披針葉1_葉_表示 = flag;
			植D.披針葉1_葉脈_表示 = flag;
			植D.披針葉2_葉_表示 = flag;
			植D.披針葉2_葉脈_表示 = flag;
			植D.披針葉3_葉_表示 = flag;
			植D.披針葉3_葉脈_表示 = flag;
			植D.披針葉4_葉_表示 = flag;
			植D.披針葉4_葉脈_表示 = flag;
			植D.心臓葉1_葉_表示 = !flag;
			植D.心臓葉1_葉脈_表示 = !flag;
			植D.心臓葉2_葉_表示 = !flag;
			植D.心臓葉2_葉脈_表示 = !flag;
			植D.心臓葉3_葉_表示 = !flag;
			植D.心臓葉3_葉脈_表示 = !flag;
			植D.心臓葉4_葉_表示 = !flag;
			植D.心臓葉4_葉脈_表示 = !flag;
			eleD.頭頂左接続(植D);
			eleD.頭頂右接続(植D.Get逆());
			触手_蔦D 触手_蔦D = new 触手_蔦D();
			触手_蔦D.先端表示 = OthN.XS.NextBool();
			触手_蔦D.SetValuesD("棘", OthN.XS.NextBool());
			EleD eleD3 = flag ? new 葉_披D() : new 葉_心D();
			eleD3.尺度B *= 1.2;
			触手_蔦D.節3接続(eleD3);
			eleD3.尺度B *= 原種.葉倍率;
			触手_蔦D.節5接続(eleD3 = eleD3.Copy());
			eleD3.尺度B *= 原種.葉倍率;
			触手_蔦D.節7接続(eleD3 = eleD3.Copy());
			eleD3.尺度B *= 原種.葉倍率;
			触手_蔦D.節9接続(eleD3 = eleD3.Copy());
			eleD3.尺度B *= 原種.葉倍率;
			触手_蔦D.節11接続(eleD3 = eleD3.Copy());
			eleD3.尺度B *= 原種.葉倍率;
			触手_蔦D.節13接続(eleD3 = eleD3.Copy());
			eleD3.尺度B *= 原種.葉倍率;
			触手_蔦D.節15接続(eleD3 = eleD3.Copy());
			eleD3.尺度B *= 原種.葉倍率;
			触手_蔦D.節17接続(eleD3 = eleD3.Copy());
			eleD3.尺度B *= 原種.葉倍率;
			触手_蔦D.節19接続(eleD3 = eleD3.Copy());
			eleD3.尺度B *= 原種.葉倍率;
			EleD eleD4 = 触手_蔦D.Copy();
			胴D.翼左接続(触手_蔦D);
			胴D.翼右接続(触手_蔦D.Get逆());
			腰D.翼左接続(eleD4);
			腰D.翼右接続(eleD4.Get逆());
			腿_人D 腿_人D = new 腿_人D();
			腰D.腿左接続(腿_人D);
			腰D.腿右接続(腿_人D.Get逆());
			単足_植D 単足_植D = new 単足_植D();
			腰D.半身接続(単足_植D);
			EleD eleD5 = new 尾_根D();
			単足_植D.根外左接続(eleD5);
			単足_植D.根外右接続(eleD5.Copy());
			単足_植D.根内左接続(eleD5.Copy());
			単足_植D.根内右接続(eleD5.Copy());
			単足_植D.根中央接続(eleD5.Copy());
			単足_植D.根外左接続(eleD5.Copy());
			単足_植D.根外右接続(eleD5.Copy());
			単足_植D.根内左接続(eleD5.Copy());
			単足_植D.根内右接続(eleD5.Copy());
			単足_植D.根中央接続(eleD5.Copy());
			腰D.EnumEleD().SetValuesD("植", true);
			腰D.EnumEleD().SetValuesD("淫", true);
			腰D.EnumEleD().SetValuesD("淫", false);
			腰D.EnumEleD().SetValuesD("ハート", false);
			腰D.EnumEleD().SetValuesD("隈取", true);
			腰D.EnumEleD().SetValuesD("隈取", false);
			腰D.EnumEleD().SetValuesD("悪", true);
			腰D.EnumEleD().SetValuesD("葉1", false);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(false));
		}

		public static ChaD Getサキュバス()
		{
			腰D 腰D = Uni.腰();
			胴D 胴D = 腰D.Set胴();
			胸D 胸D = 胴D.Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			基髪D eleD = 頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			頭D.Set耳長();
			EleD eleD2;
			switch (OthN.XS.Next(5))
			{
			case 0:
				eleD2 = new 角2_山2D
				{
					尺度B = 0.9
				};
				break;
			case 1:
				eleD2 = new 角2_巻D
				{
					尺度B = 0.9
				};
				break;
			case 2:
				eleD2 = new 角2_牛1D
				{
					尺度B = 0.9
				};
				break;
			case 3:
				eleD2 = new 角2_牛2D
				{
					尺度B = 0.9
				};
				break;
			default:
				eleD2 = new 角2_牛4D
				{
					尺度B = 0.9
				};
				break;
			}
			eleD.頭頂左接続(eleD2);
			eleD.頭頂右接続(eleD2.Get逆());
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			手_蝙D e2 = new 手_蝙D
			{
				シャ\u30FCプ = 1.0
			};
			下腕_蝙D 下腕_蝙D = new 下腕_蝙D();
			下腕_蝙D.手接続(e2);
			上腕_蝙D 上腕_蝙D = new 上腕_蝙D();
			上腕_蝙D.下腕接続(下腕_蝙D);
			胴D.翼左接続(上腕_蝙D);
			胴D.翼右接続(上腕_蝙D.Get逆());
			足_人D e3 = new 足_人D();
			脚_人D 脚_人D = new 脚_人D();
			脚_人D.足接続(e3);
			腿_人D 腿_人D = new 腿_人D();
			腿_人D.脚接続(脚_人D);
			腰D.腿左接続(腿_人D);
			腰D.腿右接続(腿_人D.Get逆());
			腰D.尾接続(new 尾_淫D());
			腰D.EnumEleD().SetValuesD("淫", true);
			腰D.EnumEleD().SetValuesD("植", true);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(OthN.XS.NextBool()))
			{
				現陰毛 = 0.0
			};
		}

		public static ChaD Getデビル()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			基髪D eleD = 頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口R();
			頭D.Set舌短();
			if (OthN.XS.NextBool())
			{
				頭D.Set耳尖();
			}
			else
			{
				頭D.Set耳長();
			}
			EleD eleD2;
			switch (OthN.XS.Next(8))
			{
			case 0:
				eleD2 = new 角2_山1D();
				break;
			case 1:
				eleD2 = new 角2_山2D();
				break;
			case 2:
				eleD2 = new 角2_山3D();
				break;
			case 3:
				eleD2 = new 角2_牛1D();
				break;
			case 4:
				eleD2 = new 角2_牛2D();
				break;
			case 5:
				eleD2 = new 角2_牛3D();
				break;
			case 6:
				eleD2 = new 角2_牛4D();
				break;
			default:
				eleD2 = new 角2_鬼D();
				break;
			}
			eleD.頭頂左接続(eleD2);
			eleD.頭頂右接続(eleD2.Get逆());
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			if (OthN.XS.NextBool())
			{
				手_蝙D e2 = new 手_蝙D
				{
					シャ\u30FCプ = OthN.XS.NextDouble()
				};
				下腕_蝙D 下腕_蝙D = new 下腕_蝙D();
				下腕_蝙D.手接続(e2);
				上腕_蝙D 上腕_蝙D = new 上腕_蝙D();
				上腕_蝙D.下腕接続(下腕_蝙D);
				胸D.翼上左接続(上腕_蝙D);
				胸D.翼上右接続(上腕_蝙D.Get逆());
			}
			else
			{
				手_鳥D e3 = new 手_鳥D();
				下腕_鳥D 下腕_鳥D = new 下腕_鳥D();
				下腕_鳥D.手接続(e3);
				上腕_鳥D 上腕_鳥D = new 上腕_鳥D();
				上腕_鳥D.下腕接続(下腕_鳥D);
				胸D.翼上左接続(上腕_鳥D);
				胸D.翼上右接続(上腕_鳥D.Get逆());
			}
			if (OthN.XS.NextBool())
			{
				足_人D e4 = new 足_人D();
				脚_人D 脚_人D = new 脚_人D();
				脚_人D.足接続(e4);
				腿_人D 腿_人D = new 腿_人D();
				腿_人D.脚接続(脚_人D);
				腰D.腿左接続(腿_人D);
				腰D.腿右接続(腿_人D.Get逆());
			}
			else
			{
				足_牛D e5 = new 足_牛D();
				脚_蹄D 脚_蹄D = new 脚_蹄D();
				脚_蹄D.足接続(e5);
				腿_蹄D 腿_蹄D = new 腿_蹄D();
				腿_蹄D.脚接続(脚_蹄D);
				腰D.腿左接続(腿_蹄D);
				腰D.腿右接続(腿_蹄D.Get逆());
				腰D.EnumEleD().SetValuesD("獣性", true);
				腰D.EnumEleD().SetValuesD("髭", false);
			}
			switch (OthN.XS.NextM(4))
			{
			case 0:
				eleD2 = new 尾_犬D();
				break;
			case 1:
				eleD2 = new 尾_馬D();
				break;
			case 2:
				eleD2 = new 尾_牛D();
				break;
			default:
				eleD2 = new 尾_悪D();
				break;
			}
			腰D.尾接続(eleD2);
			腰D.EnumEleD().SetValuesD("悪", true);
			腰D.EnumEleD().SetValuesD("牙", true);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(false));
		}

		public static ChaD Getエンジェル(bool b)
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			頭D.Set耳人();
			if (b)
			{
				頭D.頭頂接続(new 頭頂_天D());
			}
			else
			{
				胸D.背中接続(new 背中_光D());
			}
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			手_鳥D 手_鳥D = new 手_鳥D
			{
				シャ\u30FCプ = OthN.XS.NextDouble()
			};
			下腕_鳥D 下腕_鳥D = new 下腕_鳥D
			{
				シャ\u30FCプ = 手_鳥D.シャ\u30FCプ
			};
			下腕_鳥D.手接続(手_鳥D);
			上腕_鳥D 上腕_鳥D = new 上腕_鳥D
			{
				シャ\u30FCプ = 下腕_鳥D.シャ\u30FCプ
			};
			上腕_鳥D.下腕接続(下腕_鳥D);
			for (int i = 0; i < OthN.XS.Next(2) + 1; i++)
			{
				胸D.翼上左接続(上腕_鳥D.Copy());
				胸D.翼上右接続(上腕_鳥D.Get逆());
			}
			足_人D e2 = new 足_人D();
			脚_人D 脚_人D = new 脚_人D();
			脚_人D.足接続(e2);
			腿_人D 腿_人D = new 腿_人D();
			腿_人D.脚接続(脚_人D);
			腰D.腿左接続(腿_人D);
			腰D.腿右接続(腿_人D.Get逆());
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(OthN.XS.NextBool()));
		}

		public static ChaD Getウェアキャット()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			基髪D eleD = 頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻R();
			頭D.Set口人();
			頭D.Set舌短();
			EleD eleD2 = new 獣耳D();
			eleD.頭頂左接続(eleD2);
			eleD.頭頂右接続(eleD2.Get逆());
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			足_人D e2 = new 足_人D();
			脚_人D 脚_人D = new 脚_人D();
			脚_人D.足接続(e2);
			腿_人D 腿_人D = new 腿_人D();
			腿_人D.脚接続(脚_人D);
			腰D.腿左接続(腿_人D);
			腰D.腿右接続(腿_人D.Get逆());
			腰D.尾接続(new 尾_猫D());
			腰D.EnumEleD().SetValuesD("獣性", true);
			腰D.EnumEleD().SetValuesD("獣腕", false);
			腰D.EnumEleD().SetValuesD("獣性", false);
			腰D.EnumEleD().SetValuesD("獣毛", true);
			腰D.EnumEleD().SetValuesD("肉球", true);
			腰D.EnumEleD().SetValuesD("胸毛", false);
			腰D.EnumEleD().SetValuesD("髭", 頭D.鼻_接続.IsEleD<鼻_獣D>());
			腰D.EnumEleD().SetValuesD("猫目", true);
			腰D.EnumEleD().SetValuesD("牙", true);
			腰D.EnumEleD().SetValuesD("配色指定", 配色指定.B0);
			腰D.EnumEleD().SetValuesD("配色指定", 配色指定.B0);
			腰D.EnumEleD().SetValuesD("配色指定", 配色指定.B0);
			腰D.EnumEleD().SetValuesD("配色指定", 配色指定.B0);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(OthN.XS.NextBool()));
		}

		public static ChaD Getウェアフォックス()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			基髪D eleD = 頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻R();
			頭D.Set口人();
			頭D.Set舌短();
			EleD eleD2 = new 獣耳D
			{
				尺度YB = 1.2
			};
			eleD.頭頂左接続(eleD2);
			eleD.頭頂右接続(eleD2.Get逆());
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			足_人D e2 = new 足_人D();
			脚_人D 脚_人D = new 脚_人D();
			脚_人D.足接続(e2);
			腿_人D 腿_人D = new 腿_人D();
			腿_人D.脚接続(脚_人D);
			腰D.腿左接続(腿_人D);
			腰D.腿右接続(腿_人D.Get逆());
			腰D.尾接続(new 尾_狐D());
			腰D.EnumEleD().SetValuesD("獣性", true);
			腰D.EnumEleD().SetValuesD("獣腕", false);
			腰D.EnumEleD().SetValuesD("獣性", false);
			腰D.EnumEleD().SetValuesD("獣毛", true);
			腰D.EnumEleD().SetValuesD("肉球", true);
			腰D.EnumEleD().SetValuesD("髭", 頭D.鼻_接続.IsEleD<鼻_獣D>());
			腰D.EnumEleD().SetValuesD("猫目", true);
			腰D.EnumEleD().SetValuesD("牙", true);
			腰D.EnumEleD().SetValuesD("配色指定", 配色指定.B0);
			腰D.EnumEleD().SetValuesD("配色指定", 配色指定.B0);
			腰D.EnumEleD().SetValuesD("配色指定", 配色指定.B0);
			腰D.EnumEleD().SetValuesD("配色指定", 配色指定.B0);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(OthN.XS.NextBool()));
		}

		public static ChaD Getウェアウルフ()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			基髪D eleD = 頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻R();
			頭D.Set口人();
			頭D.Set舌短();
			EleD eleD2 = new 獣耳D();
			eleD.頭頂左接続(eleD2);
			eleD.頭頂右接続(eleD2.Get逆());
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			足_人D e2 = new 足_人D();
			脚_人D 脚_人D = new 脚_人D();
			脚_人D.足接続(e2);
			腿_人D 腿_人D = new 腿_人D();
			腿_人D.脚接続(脚_人D);
			腰D.腿左接続(腿_人D);
			腰D.腿右接続(腿_人D.Get逆());
			腰D.尾接続(new 尾_犬D());
			腰D.EnumEleD().SetValuesD("獣性", true);
			腰D.EnumEleD().SetValuesD("髭", false);
			腰D.EnumEleD().SetValuesD("牙", true);
			腰D.EnumEleD().SetValuesD("配色指定", 配色指定.B0);
			腰D.EnumEleD().SetValuesD("配色指定", 配色指定.B0);
			腰D.EnumEleD().SetValuesD("配色指定", 配色指定.B0);
			腰D.EnumEleD().SetValuesD("配色指定", 配色指定.B0);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(OthN.XS.NextBool()));
		}

		public static ChaD Getリザ\u30FCドマン()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口R();
			頭D.Set舌短();
			頭D.Set耳尖();
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			足_人D e2 = new 足_人D();
			脚_人D 脚_人D = new 脚_人D();
			脚_人D.足接続(e2);
			腿_人D 腿_人D = new 腿_人D();
			腿_人D.脚接続(脚_人D);
			腰D.腿左接続(腿_人D);
			腰D.腿右接続(腿_人D.Get逆());
			EleD eleD;
			if (OthN.XS.Next(2) == 0)
			{
				eleD = new 尾_ヘD();
				eleD.尺度B = 0.6;
			}
			else
			{
				eleD = new 尾_龍D();
			}
			腰D.尾接続(eleD);
			腰D.EnumEleD().SetValuesD("竜性", true);
			腰D.EnumEleD().SetValuesD("棘", false);
			腰D.EnumEleD().SetValuesD("肘2", false);
			腰D.EnumEleD().SetValuesD("鱗", true);
			腰D.EnumEleD().SetEleDs(delegate(手_人D f)
			{
				f.竜性 = false;
			});
			腰D.EnumEleD().SetValuesD("棘", false);
			腰D.EnumEleD().SetValuesD("猫目", true);
			腰D.EnumEleD().SetValuesD("牙", true);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(OthN.XS.NextBool()));
		}

		public static ChaD Getドラゴニュ\u30FCト()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			基髪D eleD = 頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			EleD eleD2;
			if (OthN.XS.NextBool())
			{
				if (OthN.XS.Next(2) == 0)
				{
					eleD2 = new 角1_一D();
				}
				else
				{
					eleD2 = new 角1_鬼D();
				}
				頭D.額接続(eleD2);
			}
			switch (OthN.XS.Next(8))
			{
			case 0:
				eleD2 = new 角2_山1D();
				break;
			case 1:
				eleD2 = new 角2_山2D();
				break;
			case 2:
				eleD2 = new 角2_山3D();
				break;
			case 3:
				eleD2 = new 角2_巻D();
				break;
			case 4:
				eleD2 = new 角2_牛1D();
				break;
			case 5:
				eleD2 = new 角2_牛2D();
				break;
			case 6:
				eleD2 = new 角2_牛3D();
				break;
			default:
				eleD2 = new 角2_牛4D();
				break;
			}
			eleD.頭頂左接続(eleD2);
			eleD.頭頂右接続(eleD2.Get逆());
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			if (OthN.XS.NextBool())
			{
				if (OthN.XS.NextBool())
				{
					手_蝙D e2 = new 手_蝙D
					{
						シャ\u30FCプ = OthN.XS.NextDouble()
					};
					下腕_蝙D 下腕_蝙D = new 下腕_蝙D();
					下腕_蝙D.手接続(e2);
					上腕_蝙D 上腕_蝙D = new 上腕_蝙D();
					上腕_蝙D.下腕接続(下腕_蝙D);
					胸D.翼上左接続(上腕_蝙D);
					胸D.翼上右接続(上腕_蝙D.Get逆());
					頭D.Set耳長();
				}
				else
				{
					手_鳥D 手_鳥D = new 手_鳥D
					{
						シャ\u30FCプ = OthN.XS.NextDouble()
					};
					下腕_鳥D 下腕_鳥D = new 下腕_鳥D
					{
						シャ\u30FCプ = 手_鳥D.シャ\u30FCプ
					};
					下腕_鳥D.手接続(手_鳥D);
					上腕_鳥D 上腕_鳥D = new 上腕_鳥D
					{
						シャ\u30FCプ = 下腕_鳥D.シャ\u30FCプ
					};
					上腕_鳥D.下腕接続(下腕_鳥D);
					胸D.翼上左接続(上腕_鳥D);
					胸D.翼上右接続(上腕_鳥D.Get逆());
					頭D.Set耳獣();
				}
			}
			else
			{
				頭D.Set耳尖();
			}
			足_人D e3 = new 足_人D();
			脚_人D 脚_人D = new 脚_人D();
			脚_人D.足接続(e3);
			腿_人D 腿_人D = new 腿_人D();
			腿_人D.脚接続(脚_人D);
			腰D.腿左接続(腿_人D);
			腰D.腿右接続(腿_人D.Get逆());
			int num = OthN.XS.Next(3);
			if (num != 0)
			{
				if (num != 1)
				{
					eleD2 = new 尾_龍D();
				}
				else
				{
					eleD2 = new 尾_竜D();
				}
			}
			else
			{
				eleD2 = new 尾_ヘD();
				eleD2.尺度B = 0.6;
			}
			腰D.尾接続(eleD2);
			腰D.EnumEleD().SetValuesD("竜性", true);
			腰D.EnumEleD().SetValuesD("竜性", false);
			腰D.EnumEleD().SetValuesD("鱗", true);
			腰D.EnumEleD().SetValuesD("猫目", OthN.XS.NextBool());
			腰D.EnumEleD().SetValuesD("牙", true);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(OthN.XS.NextBool()));
		}

		public static ChaD Getドラゴン()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			基髪D eleD = 頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口R();
			頭D.Set舌短();
			EleD eleD2;
			if (OthN.XS.NextBool())
			{
				if (OthN.XS.Next(2) == 0)
				{
					eleD2 = new 角1_一D();
				}
				else
				{
					eleD2 = new 角1_鬼D();
				}
				頭D.額接続(eleD2);
			}
			switch (OthN.XS.Next(8))
			{
			case 0:
				eleD2 = new 角2_山1D();
				break;
			case 1:
				eleD2 = new 角2_山2D();
				break;
			case 2:
				eleD2 = new 角2_山3D();
				break;
			case 3:
				eleD2 = new 角2_巻D();
				break;
			case 4:
				eleD2 = new 角2_牛1D();
				break;
			case 5:
				eleD2 = new 角2_牛2D();
				break;
			case 6:
				eleD2 = new 角2_牛3D();
				break;
			default:
				eleD2 = new 角2_牛4D();
				break;
			}
			eleD.頭頂左接続(eleD2);
			eleD.頭頂右接続(eleD2.Get逆());
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			四足胸D 四足胸D = Uni.四足胸();
			腰D.半身接続(四足胸D);
			四足胴D 四足胴D = Uni.四足胴();
			四足胸D.胴接続(四足胴D);
			四足腰D 四足腰D = Uni.四足腰();
			四足胴D.腰接続(四足腰D);
			if (OthN.XS.NextBool())
			{
				手_蝙D e2 = new 手_蝙D();
				下腕_蝙D 下腕_蝙D = new 下腕_蝙D();
				下腕_蝙D.手接続(e2);
				上腕_蝙D 上腕_蝙D = new 上腕_蝙D();
				上腕_蝙D.下腕接続(下腕_蝙D);
				四足胸D.翼上左接続(上腕_蝙D);
				四足胸D.翼上右接続(上腕_蝙D.Get逆());
				頭D.Set耳鰭();
			}
			else
			{
				手_鳥D e3 = new 手_鳥D();
				下腕_鳥D 下腕_鳥D = new 下腕_鳥D();
				下腕_鳥D.手接続(e3);
				上腕_鳥D 上腕_鳥D = new 上腕_鳥D();
				上腕_鳥D.下腕接続(下腕_鳥D);
				四足胸D.翼上左接続(上腕_鳥D);
				四足胸D.翼上右接続(上腕_鳥D.Get逆());
				腰D.EnumEleD().SetValuesD("獣毛", true);
				頭D.Set耳羽();
			}
			手_獣D e4 = new 手_獣D();
			下腕_獣D 下腕_獣D = new 下腕_獣D();
			下腕_獣D.手接続(e4);
			上腕_獣D 上腕_獣D = new 上腕_獣D();
			上腕_獣D.下腕接続(下腕_獣D);
			四足脇D 四足脇D = new 四足脇D();
			四足脇D.上腕接続(上腕_獣D);
			四足胸D.脇左接続(四足脇D);
			四足胸D.脇右接続(四足脇D.Get逆());
			足_竜D e5 = new 足_竜D();
			脚_竜D 脚_竜D = new 脚_竜D();
			脚_竜D.足接続(e5);
			腿_竜D 腿_竜D = new 腿_竜D();
			腿_竜D.脚接続(脚_竜D);
			四足腰D.腿左接続(腿_竜D);
			四足腰D.腿右接続(腿_竜D.Get逆());
			switch (OthN.XS.Next(5))
			{
			case 0:
				eleD2 = new 尾_ヘD();
				eleD2.尺度B = 0.6;
				break;
			case 1:
				eleD2 = new 尾_竜D();
				break;
			case 2:
				eleD2 = new 尾_龍D();
				break;
			default:
				eleD2 = new 尾_悪D();
				break;
			}
			四足腰D.尾接続(eleD2);
			腰D.EnumEleD().SetValuesD("竜性", true);
			四足胸D.EnumEleD().SetValuesD("鱗", false);
			腰D.EnumEleD().SetValuesD("配色", 配色指定.S0);
			腰D.EnumEleD().SetValuesD("猫目", true);
			腰D.EnumEleD().SetValuesD("牙", true);
			腰D.EnumEleD().SetValuesD("表示", false);
			腰D.EnumEleD().SetValuesD("表示", false);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(false));
		}

		public static ChaD Getドラコケンタウレ()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			基髪D eleD = 頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口R();
			頭D.Set舌短();
			EleD eleD2;
			if (OthN.XS.NextBool())
			{
				if (OthN.XS.Next(2) == 0)
				{
					eleD2 = new 角1_一D();
				}
				else
				{
					eleD2 = new 角1_鬼D();
				}
				頭D.額接続(eleD2);
			}
			switch (OthN.XS.Next(8))
			{
			case 0:
				eleD2 = new 角2_山1D();
				break;
			case 1:
				eleD2 = new 角2_山2D();
				break;
			case 2:
				eleD2 = new 角2_山3D();
				break;
			case 3:
				eleD2 = new 角2_巻D();
				break;
			case 4:
				eleD2 = new 角2_牛1D();
				break;
			case 5:
				eleD2 = new 角2_牛2D();
				break;
			case 6:
				eleD2 = new 角2_牛3D();
				break;
			default:
				eleD2 = new 角2_牛4D();
				break;
			}
			eleD.頭頂左接続(eleD2);
			eleD.頭頂右接続(eleD2.Get逆());
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			四足胸D 四足胸D = Uni.四足胸();
			腰D.半身接続(四足胸D);
			四足胴D 四足胴D = Uni.四足胴();
			四足胸D.胴接続(四足胴D);
			四足腰D 四足腰D = Uni.四足腰();
			四足胴D.腰接続(四足腰D);
			頭D.Set耳長();
			手_獣D e2 = new 手_獣D();
			下腕_獣D 下腕_獣D = new 下腕_獣D();
			下腕_獣D.手接続(e2);
			上腕_獣D 上腕_獣D = new 上腕_獣D();
			上腕_獣D.下腕接続(下腕_獣D);
			四足脇D 四足脇D = new 四足脇D();
			四足脇D.上腕接続(上腕_獣D);
			四足胸D.脇左接続(四足脇D);
			四足胸D.脇右接続(四足脇D.Get逆());
			足_竜D e3 = new 足_竜D();
			脚_竜D 脚_竜D = new 脚_竜D();
			脚_竜D.足接続(e3);
			腿_竜D 腿_竜D = new 腿_竜D();
			腿_竜D.脚接続(脚_竜D);
			四足腰D.腿左接続(腿_竜D);
			四足腰D.腿右接続(腿_竜D.Get逆());
			switch (OthN.XS.Next(5))
			{
			case 0:
				eleD2 = new 尾_ヘD();
				eleD2.尺度B = 0.6;
				break;
			case 1:
				eleD2 = new 尾_竜D();
				break;
			case 2:
				eleD2 = new 尾_龍D();
				break;
			default:
				eleD2 = new 尾_悪D();
				break;
			}
			四足腰D.尾接続(eleD2);
			腰D.EnumEleD().SetValuesD("竜性", true);
			四足胸D.EnumEleD().SetValuesD("鱗", false);
			腰D.EnumEleD().SetValuesD("配色", 配色指定.S0);
			腰D.EnumEleD().SetValuesD("猫目", true);
			腰D.EnumEleD().SetValuesD("牙", true);
			腰D.EnumEleD().SetValuesD("表示", false);
			腰D.EnumEleD().SetValuesD("表示", false);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(OthN.XS.NextBool()));
		}

		public static ChaD Getワイバ\u30FCン()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			基髪D eleD = 頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口R();
			頭D.Set舌短();
			EleD eleD2;
			if (OthN.XS.NextBool())
			{
				if (OthN.XS.Next(2) == 0)
				{
					eleD2 = new 角1_一D();
				}
				else
				{
					eleD2 = new 角1_鬼D();
				}
				頭D.額接続(eleD2);
			}
			switch (OthN.XS.Next(6))
			{
			case 0:
				eleD2 = new 角2_山1D();
				break;
			case 1:
				eleD2 = new 角2_山2D();
				break;
			case 2:
				eleD2 = new 角2_山3D();
				break;
			case 3:
				eleD2 = new 角2_牛2D();
				break;
			case 4:
				eleD2 = new 角2_牛3D();
				break;
			default:
				eleD2 = new 角2_牛4D();
				break;
			}
			eleD.頭頂左接続(eleD2);
			eleD.頭頂右接続(eleD2.Get逆());
			if (OthN.XS.NextBool())
			{
				手_蝙D e = new 手_蝙D
				{
					尺度B = 1.1
				};
				下腕_蝙D 下腕_蝙D = new 下腕_蝙D
				{
					尺度B = 1.1
				};
				下腕_蝙D.手接続(e);
				上腕_蝙D 上腕_蝙D = new 上腕_蝙D
				{
					尺度B = 1.1
				};
				上腕_蝙D.下腕接続(下腕_蝙D);
				肩D 肩D = new 肩D();
				肩D.上腕接続(上腕_蝙D);
				胸D.肩左接続(肩D);
				胸D.肩右接続(肩D.Get逆());
				頭D.Set耳長();
			}
			else
			{
				手_鳥D e2 = new 手_鳥D
				{
					尺度B = 1.1,
					指_表示 = true
				};
				下腕_鳥D 下腕_鳥D = new 下腕_鳥D
				{
					尺度B = 1.1
				};
				下腕_鳥D.手接続(e2);
				上腕_鳥D 上腕_鳥D = new 上腕_鳥D
				{
					尺度B = 1.1
				};
				上腕_鳥D.下腕接続(下腕_鳥D);
				肩D 肩D2 = new 肩D();
				肩D2.上腕接続(上腕_鳥D);
				胸D.肩左接続(肩D2);
				胸D.肩右接続(肩D2.Get逆());
				胸D.背中接続(new 背中_羽D());
				頭D.Set耳獣();
			}
			足_鳥D e3 = new 足_鳥D();
			脚_竜D 脚_竜D = new 脚_竜D();
			脚_竜D.足接続(e3);
			腿_竜D 腿_竜D = new 腿_竜D();
			腿_竜D.脚接続(脚_竜D);
			腰D.腿左接続(腿_竜D);
			腰D.腿右接続(腿_竜D.Get逆());
			switch (OthN.XS.Next(5))
			{
			case 0:
				eleD2 = new 尾_ヘD
				{
					尺度B = 0.6
				};
				break;
			case 1:
				eleD2 = new 尾_竜D();
				break;
			case 2:
				eleD2 = new 尾_龍D();
				break;
			case 3:
				eleD2 = new 尾_蠍D
				{
					尺度B = 1.3
				};
				break;
			default:
				eleD2 = new 尾_悪D
				{
					尺度B = 1.5
				};
				break;
			}
			腰D.尾接続(eleD2);
			腰D.EnumEleD().SetValuesD("竜性", true);
			腰D.EnumEleD().SetValuesD("猫目", true);
			腰D.EnumEleD().SetValuesD("牙", true);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(false));
		}

		public static ChaD Getワ\u30FCム()
		{
			腰D 腰D = Uni.腰();
			頭D 頭D = 腰D.Set胴().Set胸R().Set首().Set頭R();
			基髪D eleD = 頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口裂();
			頭D.Set舌長();
			頭D.Set耳鰭();
			頭D.Set耳尖();
			EleD eleD2;
			if (OthN.XS.NextBool())
			{
				if (OthN.XS.Next(2) == 0)
				{
					eleD2 = new 角1_一D();
				}
				else
				{
					eleD2 = new 角1_鬼D();
				}
				頭D.額接続(eleD2);
			}
			switch (OthN.XS.Next(5))
			{
			case 0:
				eleD2 = new 角2_山1D();
				break;
			case 1:
				eleD2 = new 角2_山2D();
				break;
			case 2:
				eleD2 = new 角2_牛2D();
				break;
			case 3:
				eleD2 = new 角2_牛4D();
				break;
			default:
				eleD2 = new 角2_鬼D();
				break;
			}
			eleD.頭頂左接続(eleD2);
			eleD.頭頂右接続(eleD2.Get逆());
			長物_蛇D 長物_蛇D = new 長物_蛇D();
			腰D.半身接続(長物_蛇D);
			胴_蛇D 胴_蛇D = new 胴_蛇D();
			長物_蛇D.胴接続(胴_蛇D);
			for (int i = 0; i < 40; i++)
			{
				胴_蛇D.胴接続(胴_蛇D = new 胴_蛇D());
			}
			胴_蛇D.胴接続(new 尾_ヘD());
			腰D.EnumEleD().SetValuesD("竜性", true);
			腰D.EnumEleD().SetValuesD("竜性", false);
			腰D.EnumEleD().SetValuesD("猫目", OthN.XS.NextBool());
			腰D.EnumEleD().SetValuesD("股舌表示", true);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(false));
		}

		public static ChaD Getサンドワ\u30FCム()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			基髪D eleD = 頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口裂();
			頭D.Set舌短();
			頭D.Set耳人();
			EleD eleD2;
			switch (OthN.XS.Next(5))
			{
			case 0:
				eleD2 = new 角2_山1D();
				break;
			case 1:
				eleD2 = new 角2_山2D();
				break;
			case 2:
				eleD2 = new 角2_牛2D();
				break;
			case 3:
				eleD2 = new 角2_牛4D();
				break;
			default:
				eleD2 = new 角2_鬼D();
				break;
			}
			eleD.頭頂左接続(eleD2);
			eleD.頭頂右接続(eleD2.Get逆());
			頭D.頭頂接続(new 頭頂_皿D
			{
				甲殻 = true
			});
			大顎基D 大顎基D = new 大顎基D();
			eleD2 = new 大顎D();
			大顎基D.顎左接続(eleD2);
			大顎基D.顎右接続(eleD2.Get逆());
			頭D.大顎基接続(大顎基D);
			顔面_蟲D e = new 顔面_蟲D();
			頭D.顔面接続(e);
			if (OthN.XS.NextBool())
			{
				eleD2 = new 虫顎D
				{
					尺度B = 1.1
				};
				頭D.頬左接続(eleD2);
				頭D.頬右接続(eleD2.Get逆());
			}
			下腕_人D 下腕_人D = new 下腕_人D();
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			下腕_人D.虫鎌接続(new 虫鎌D());
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			胸D.肩左接続(肩D.Copy());
			胸D.肩右接続(肩D.Get逆());
			胸D.肩左接続(肩D.Copy());
			胸D.肩右接続(肩D.Get逆());
			長物_蟲D 長物_蟲D = new 長物_蟲D();
			腰D.半身接続(長物_蟲D);
			胴_蟲D 胴_蟲D = new 胴_蟲D();
			長物_蟲D.胴接続(胴_蟲D);
			for (int i = 0; i < 21; i++)
			{
				胴_蟲D.胴接続(胴_蟲D = new 胴_蟲D());
			}
			尾_蟲D 尾_蟲D = new 尾_蟲D();
			節D 節D = OthN.XS.NextBool() ? new 節尾_曳航D() : new 節尾_鋏D();
			尾_蟲D.尾左接続(節D);
			尾_蟲D.尾右接続(節D.Get逆());
			胴_蟲D.胴接続(尾_蟲D);
			腰D.EnumEleD().SetValuesD("虫性", true);
			腰D.EnumEleD().SetValuesD("配色", 配色指定.C0);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(false));
		}

		public static ChaD Getリュウ()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			基髪D eleD = 頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口裂();
			頭D.Set舌長();
			頭D.Set耳鰭();
			頭D.Set耳尖();
			EleD eleD2 = new 角2_山2D();
			eleD.頭頂左接続(eleD2);
			eleD.頭頂右接続(eleD2.Get逆());
			長物_蛇D 長物_蛇D = new 長物_蛇D();
			腰D.半身接続(長物_蛇D);
			足_鳥D e = new 足_鳥D
			{
				尺度B = 1.1
			};
			脚_竜D 脚_竜D = new 脚_竜D
			{
				尺度B = 1.1
			};
			脚_竜D.足接続(e);
			四足脇D 四足脇D = new 四足脇D
			{
				尺度B = 1.1
			};
			四足脇D.上腕接続(脚_竜D);
			腰D.翼左接続(四足脇D);
			腰D.翼右接続(四足脇D.Get逆());
			胴_蛇D 胴_蛇D = new 胴_蛇D();
			長物_蛇D.胴接続(胴_蛇D);
			for (int i = 0; i < 50; i++)
			{
				胴_蛇D.胴接続(胴_蛇D = new 胴_蛇D());
			}
			e = new 足_鳥D();
			脚_竜D = new 脚_竜D();
			脚_竜D.足接続(e);
			腿_竜D 腿_竜D = new 腿_竜D();
			腿_竜D.脚接続(脚_竜D);
			胴_蛇D.左接続(腿_竜D);
			胴_蛇D.右接続(腿_竜D.Get逆());
			尾_ヘD 尾_ヘD = new 尾_ヘD();
			尾_ヘD.尾先接続(new 尾鰭_魚D());
			胴_蛇D.胴接続(尾_ヘD);
			腰D.EnumEleD().SetValuesD("馬", true);
			胸D.肌_接続.SetValuesD("表示", true);
			腰D.EnumEleD().SetValuesD("竜性", true);
			腰D.EnumEleD().SetValuesD("竜性", false);
			腰D.EnumEleD().SetValuesD("猫目", true);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(false));
		}

		public static ChaD Getスライム()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set口人();
			頭D.Set舌短();
			頭D.Set耳人();
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			腿_人D 腿_人D = new 腿_人D();
			腿_人D.スライム = true;
			腰D.腿左接続(腿_人D);
			腰D.腿右接続(腿_人D.Get逆());
			腰D.半身接続(new 単足_粘D());
			腰D.EnumEleD().SetValuesD("スライム", true);
			腰D.EnumEleD().SetValuesD("ハイライト", true);
			腰D.EnumEleD().SetValuesD("表示", false);
			腰D.EnumEleD().SetValuesD("眼", false);
			腰D.EnumEleD().SetValuesD("コア", false);
			腰D.EnumEleD().SetValuesD("秘石", false);
			腰D.EnumEleD().SetValuesD("ハイライト下", false);
			腰D.EnumEleD().SetValuesD("コア1", OthN.XS.NextBool());
			腰D.EnumEleD().SetValuesD("コア2", OthN.XS.NextBool());
			腰D.EnumEleD().SetValuesD("瞳孔", false);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(false));
		}

		public static ChaD Getフェアリ\u30FC(bool b1, bool b2)
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			基髪D eleD = 頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			int num = OthN.XS.Next(3);
			if (num != 0)
			{
				if (num != 1)
				{
					頭D.Set耳長();
				}
				else
				{
					頭D.Set耳尖();
				}
			}
			else
			{
				頭D.Set耳人();
			}
			植D 植D = new 植D();
			EleD eleD2 = Con.Get花R(false);
			植D.花接続(eleD2);
			bool flag = OthN.XS.NextBool();
			if (eleD2 is 花_百D)
			{
				((花_百D)eleD2).萼_萼_表示 = !flag;
			}
			植D.披針葉1_葉_表示 = flag;
			植D.披針葉1_葉脈_表示 = flag;
			植D.披針葉2_葉_表示 = flag;
			植D.披針葉2_葉脈_表示 = flag;
			植D.披針葉3_葉_表示 = flag;
			植D.披針葉3_葉脈_表示 = flag;
			植D.披針葉4_葉_表示 = flag;
			植D.披針葉4_葉脈_表示 = flag;
			植D.心臓葉1_葉_表示 = !flag;
			植D.心臓葉1_葉脈_表示 = !flag;
			植D.心臓葉2_葉_表示 = !flag;
			植D.心臓葉2_葉脈_表示 = !flag;
			植D.心臓葉3_葉_表示 = !flag;
			植D.心臓葉3_葉脈_表示 = !flag;
			植D.心臓葉4_葉_表示 = !flag;
			植D.心臓葉4_葉脈_表示 = !flag;
			eleD.頭頂左接続(植D);
			eleD.頭頂右接続(植D.Get逆());
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			if (b1)
			{
				EleD eleD3 = new 前翅_羽D
				{
					尺度B = 0.9
				};
				胸D.翼上左接続(eleD3);
				胸D.翼上右接続(eleD3.Get逆());
				eleD3 = new 後翅_羽D
				{
					尺度B = 0.9
				};
				胸D.翼下左接続(eleD3);
				胸D.翼下右接続(eleD3.Get逆());
			}
			else
			{
				EleD eleD3 = new 前翅_蝶D
				{
					尺度B = 0.9,
					水青 = b2
				};
				胸D.翼上左接続(eleD3);
				胸D.翼上右接続(eleD3.Get逆());
				eleD3 = new 後翅_蝶D
				{
					尺度B = 0.9,
					水青 = b2
				};
				胸D.翼下左接続(eleD3);
				胸D.翼下右接続(eleD3.Get逆());
			}
			if (OthN.XS.NextBool())
			{
				if (b1)
				{
					EleD eleD3 = new 触覚_線D();
					eleD3.尺度YB = 0.4;
					頭D.触覚左接続(eleD3);
					頭D.触覚右接続(eleD3.Get逆());
				}
				else if (b2)
				{
					EleD eleD3 = new 触覚_蛾D();
					頭D.触覚左接続(eleD3);
					頭D.触覚右接続(eleD3.Get逆());
				}
				else
				{
					EleD eleD3 = new 触覚_蝶D();
					頭D.触覚左接続(eleD3);
					頭D.触覚右接続(eleD3.Get逆());
				}
			}
			足_人D e2 = new 足_人D();
			脚_人D 脚_人D = new 脚_人D();
			脚_人D.足接続(e2);
			腿_人D 腿_人D = new 腿_人D();
			腿_人D.脚接続(脚_人D);
			腰D.腿左接続(腿_人D);
			腰D.腿右接続(腿_人D.Get逆());
			腰D.EnumEleD().SetValuesD("肥大", 0.0);
			腰D.EnumEleD().SetValuesD("身長", 0.0);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(OthN.XS.NextBool()));
		}

		public static ChaD Getオ\u30FCグリス(bool b)
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			首D 首 = 胸D.Set首();
			頭D 頭D;
			if (b)
			{
				頭D = 首.Set頭R1();
				頭D.EnumEleD().GetEleD<基髪D>();
				頭D.額接続(new 角1_鬼D());
			}
			else
			{
				頭D = 首.Set頭R();
				基髪D eleD = 頭D.EnumEleD().GetEleD<基髪D>();
				EleD eleD2 = new 角2_鬼D();
				eleD.頭頂左接続(eleD2);
				eleD.頭頂右接続(eleD2.Get逆());
			}
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			if (OthN.XS.NextBool())
			{
				頭D.Set耳人();
			}
			else
			{
				頭D.Set耳尖();
			}
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			足_人D e2 = new 足_人D();
			脚_人D 脚_人D = new 脚_人D();
			脚_人D.足接続(e2);
			腿_人D 腿_人D = new 腿_人D();
			腿_人D.脚接続(脚_人D);
			腰D.腿左接続(腿_人D);
			腰D.腿右接続(腿_人D.Get逆());
			if (OthN.XS.NextBool())
			{
				腰D.EnumEleD().SetValuesD("隈取", true);
				頭D.隈取_タトゥ_表示 = false;
				腰D.EnumEleD().SetValuesD("豹", true);
				腰D.EnumEleD().SetValuesD("淫", true);
				腰D.EnumEleD().SetValuesD("ハート", false);
				腰D.SetValuesD("悪", true);
				腰D.EnumEleD().SetValuesD("植", true);
				腰D.EnumEleD().SetValuesD("植", true);
				腰D.EnumEleD().SetValuesD("タトゥ2", false);
				腰D.EnumEleD().SetValuesD("手首", false);
				腰D.EnumEleD().SetValuesD("足首", false);
			}
			腰D.EnumEleD().SetValuesD("牙", true);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(OthN.XS.NextBool()));
		}

		public static ChaD Getサイクロプス()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R1();
			頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set単目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			if (OthN.XS.NextBool())
			{
				頭D.Set耳人();
			}
			else
			{
				頭D.Set耳尖();
			}
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			足_人D e2 = new 足_人D();
			脚_人D 脚_人D = new 脚_人D();
			脚_人D.足接続(e2);
			腿_人D 腿_人D = new 腿_人D();
			腿_人D.脚接続(脚_人D);
			腰D.腿左接続(腿_人D);
			腰D.腿右接続(腿_人D.Get逆());
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 1.0);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(OthN.XS.NextBool()));
		}

		public static ChaD Getエイリアン()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set目宇R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			頭D.Set耳尖();
			頭頂_宇D 頭頂_宇D = new 頭頂_宇D();
			頭頂_宇D.頭部後接続(new 頭頂後_宇D());
			頭D.頭頂接続(頭頂_宇D);
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			下腕_人D.虫鎌接続(new 虫鎌D());
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			多足_蛸D 多足_蛸D = new 多足_蛸D();
			腰D.半身接続(多足_蛸D);
			触手_軟D 触手_軟D = new 触手_軟D
			{
				後足 = true
			};
			触手_軟D 触手_軟D2 = new 触手_軟D
			{
				前足 = true
			};
			多足_蛸D.軟体内左接続(触手_軟D.Copy());
			多足_蛸D.軟体内右接続(触手_軟D.Get逆());
			多足_蛸D.軟体外左接続(触手_軟D2.Copy());
			多足_蛸D.軟体外右接続(触手_軟D2.Get逆());
			多足_蛸D.軟体外左接続(触手_軟D2.Copy());
			多足_蛸D.軟体外右接続(触手_軟D2.Get逆());
			多足_蛸D.軟体外左接続(触手_軟D2.Copy());
			多足_蛸D.軟体外右接続(触手_軟D2.Get逆());
			腰D.EnumEleD().SetValuesD("コア1", true);
			腰D.EnumEleD().SetValuesD("虫性", true);
			腰D.EnumEleD().SetValuesD("虫性", false);
			腰D.EnumEleD().SetValuesD("器官", false);
			腰D.EnumEleD().SetValuesD("宇手", true);
			if (OthN.XS.NextBool())
			{
				腰D.EnumEleD().SetValuesD("紋柄", true);
			}
			腰D.EnumEleD().SetValuesD("吸盤", false);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(false));
		}

		public static ChaD Getクラ\u30FCケン()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口裂();
			頭D.Set舌短();
			頭D.Set耳長();
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			多足_蛸D 多足_蛸D = new 多足_蛸D();
			腰D.半身接続(多足_蛸D);
			触手_軟D 触手_軟D = new 触手_軟D
			{
				後足 = true
			};
			触手_軟D 触手_軟D2 = new 触手_軟D
			{
				前足 = true
			};
			触手_触D 触手_触D = new 触手_触D();
			触手_触D.SetValuesD("爪", OthN.XS.NextBool());
			多足_蛸D.軟体内左接続(触手_軟D.Copy());
			多足_蛸D.軟体内右接続(触手_軟D.Get逆());
			多足_蛸D.軟体内左接続(触手_触D.Copy());
			多足_蛸D.軟体内右接続(触手_触D.Get逆());
			多足_蛸D.軟体外左接続(触手_軟D2.Copy());
			多足_蛸D.軟体外右接続(触手_軟D2.Get逆());
			多足_蛸D.軟体外左接続(触手_軟D2.Copy());
			多足_蛸D.軟体外右接続(触手_軟D2.Get逆());
			多足_蛸D.軟体外左接続(触手_軟D2.Copy());
			多足_蛸D.軟体外右接続(触手_軟D2.Get逆());
			if (OthN.XS.NextBool())
			{
				腰D.EnumEleD().SetValuesD("紋柄", true);
				多足_蛸D.EnumEleD().SetValuesD("柄", OthN.XS.NextBool());
			}
			腰D.EnumEleD().SetValuesD("蛸目", OthN.XS.NextBool());
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(false));
		}

		public static ChaD Getセイレ\u30FCン(int i)
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口R();
			頭D.Set舌短();
			頭D.Set耳尖();
			if (i != 0)
			{
				if (i != 1)
				{
					腰D.EnumEleD().SetValuesD("獣毛", true);
					手_人D e = new 手_人D();
					下腕_人D 下腕_人D = new 下腕_人D();
					下腕_人D.手接続(e);
					上腕_人D 上腕_人D = new 上腕_人D();
					上腕_人D.下腕接続(下腕_人D);
					肩D 肩D = new 肩D();
					肩D.上腕接続(上腕_人D);
					胸D.肩左接続(肩D);
					胸D.肩右接続(肩D.Get逆());
					四足胸D 四足胸D = Uni.四足胸();
					腰D.半身接続(四足胸D);
					四足胴D 四足胴D = Uni.四足胴();
					四足胸D.胴接続(四足胴D);
					四足腰D 四足腰D = Uni.四足腰();
					四足胴D.腰接続(四足腰D);
					四足腰D.SetValuesD("尺度YB", 0.9);
					四足胴D.SetValuesD("尺度YB", 0.8);
					四足胸D.SetValuesD("尺度YB", 0.8);
					手_鳥D 手_鳥D = new 手_鳥D();
					手_鳥D.シャ\u30FCプ = 1.0;
					下腕_鳥D 下腕_鳥D = new 下腕_鳥D();
					下腕_鳥D.手接続(手_鳥D);
					下腕_鳥D.シャ\u30FCプ = 1.0;
					上腕_鳥D 上腕_鳥D = new 上腕_鳥D();
					上腕_鳥D.下腕接続(下腕_鳥D);
					上腕_鳥D.シャ\u30FCプ = 1.0;
					四足胸D.翼上左接続(上腕_鳥D);
					四足胸D.翼上右接続(上腕_鳥D.Get逆());
					足_鳥D e2 = new 足_鳥D();
					脚_鳥D 脚_鳥D = new 脚_鳥D();
					脚_鳥D.足接続(e2);
					腿_鳥D 腿_鳥D = new 腿_鳥D();
					腿_鳥D.脚接続(脚_鳥D);
					四足腰D.腿左接続(腿_鳥D);
					四足腰D.腿右接続(腿_鳥D.Get逆());
					四足腰D.尾接続(new 尾_鳥D());
					四足胴D.SetValuesD("獣毛", true);
					腰D.EnumEleD().SetValuesD("表示", false);
					腰D.EnumEleD().SetValuesD("表示", false);
				}
				else
				{
					手_人D e3 = new 手_人D();
					下腕_人D 下腕_人D2 = new 下腕_人D();
					下腕_人D2.手接続(e3);
					上腕_人D 上腕_人D2 = new 上腕_人D();
					上腕_人D2.下腕接続(下腕_人D2);
					肩D 肩D2 = new 肩D();
					肩D2.上腕接続(上腕_人D2);
					胸D.肩左接続(肩D2);
					胸D.肩右接続(肩D2.Get逆());
					尾_魚D 尾_魚D = new 尾_魚D
					{
						尺度B = 1.2,
						尺度YB = 1.5
					};
					尾_魚D.尾0_表示 = false;
					尾_魚D.尾0_鱗右_鱗1_表示 = false;
					尾_魚D.尾0_鱗右_鱗2_表示 = false;
					尾_魚D.尾先接続(new 尾鰭_魚D());
					腰D.腿左接続(尾_魚D);
					腰D.腿右接続(尾_魚D.Get逆());
					腰D.EnumEleD().SetValuesD("鱗", true);
					腰D.EnumEleD().SetValuesD("鱗", true);
				}
			}
			else
			{
				if (OthN.XS.NextBool())
				{
					手_人D e4 = new 手_人D();
					下腕_人D 下腕_人D3 = new 下腕_人D();
					下腕_人D3.手接続(e4);
					上腕_人D 上腕_人D3 = new 上腕_人D();
					上腕_人D3.下腕接続(下腕_人D3);
					肩D 肩D3 = new 肩D();
					肩D3.上腕接続(上腕_人D3);
					胸D.肩左接続(肩D3);
					胸D.肩右接続(肩D3.Get逆());
				}
				手_鳥D e5 = new 手_鳥D
				{
					シャ\u30FCプ = 1.0
				};
				下腕_鳥D 下腕_鳥D2 = new 下腕_鳥D
				{
					シャ\u30FCプ = 1.0
				};
				下腕_鳥D2.手接続(e5);
				上腕_鳥D 上腕_鳥D2 = new 上腕_鳥D
				{
					シャ\u30FCプ = 1.0
				};
				上腕_鳥D2.下腕接続(下腕_鳥D2);
				胸D.翼上左接続(上腕_鳥D2);
				胸D.翼上右接続(上腕_鳥D2.Get逆());
				足_鳥D e6 = new 足_鳥D();
				脚_鳥D 脚_鳥D2 = new 脚_鳥D();
				脚_鳥D2.足接続(e6);
				腿_鳥D 腿_鳥D2 = new 腿_鳥D();
				腿_鳥D2.脚接続(脚_鳥D2);
				腰D.腿左接続(腿_鳥D2);
				腰D.腿右接続(腿_鳥D2.Get逆());
				腰D.EnumEleD().SetValuesD("獣毛", true);
				腰D.尾接続(new 尾_鳥D());
			}
			腰D.EnumEleD().SetValuesD("牙", true);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(OthN.XS.NextBool()));
		}

		public static ChaD Getユニコ\u30FCン()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R1();
			頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			頭D.Set耳獣();
			頭D.額接続(new 角1_一D());
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			四足胸D 四足胸D = Uni.四足胸();
			腰D.半身接続(四足胸D);
			四足胴D 四足胴D = Uni.四足胴();
			四足胸D.胴接続(四足胴D);
			四足腰D 四足腰D = Uni.四足腰();
			四足胴D.腰接続(四足腰D);
			手_馬D e2 = new 手_馬D();
			下腕_蹄D 下腕_蹄D = new 下腕_蹄D();
			下腕_蹄D.手接続(e2);
			上腕_蹄D 上腕_蹄D = new 上腕_蹄D();
			上腕_蹄D.下腕接続(下腕_蹄D);
			四足脇D 四足脇D = new 四足脇D();
			四足脇D.上腕接続(上腕_蹄D);
			四足胸D.脇左接続(四足脇D);
			四足胸D.脇右接続(四足脇D.Get逆());
			足_馬D e3 = new 足_馬D();
			脚_蹄D 脚_蹄D = new 脚_蹄D();
			脚_蹄D.足接続(e3);
			腿_蹄D 腿_蹄D = new 腿_蹄D();
			腿_蹄D.脚接続(脚_蹄D);
			四足腰D.腿左接続(腿_蹄D);
			四足腰D.腿右接続(腿_蹄D.Get逆());
			四足腰D.尾接続(new 尾_馬D());
			腰D.EnumEleD().SetValuesD("馬", OthN.XS.NextBool());
			腰D.EnumEleD().SetValuesD("表示", false);
			腰D.EnumEleD().SetValuesD("表示", false);
			腰D.EnumEleD().SetValuesD("獣性", true);
			四足腰D.EnumEleD().SetValuesD("獣性", false);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(OthN.XS.NextBool()));
		}

		public static ChaD Getモノケロス()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R1();
			頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			頭D.Set耳獣();
			頭D.額接続(new 角1_一D
			{
				尺度YB = 2.0
			});
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			四足胸D 四足胸D = Uni.四足胸();
			腰D.半身接続(四足胸D);
			四足胴D 四足胴D = Uni.四足胴();
			四足胸D.胴接続(四足胴D);
			四足腰D 四足腰D = Uni.四足腰();
			四足胴D.腰接続(四足腰D);
			四足胸D.背中接続(new 背中_羽D
			{
				毛 = true
			});
			手_牛D e2 = new 手_牛D();
			下腕_蹄D 下腕_蹄D = new 下腕_蹄D();
			下腕_蹄D.手接続(e2);
			上腕_蹄D 上腕_蹄D = new 上腕_蹄D();
			上腕_蹄D.下腕接続(下腕_蹄D);
			四足脇D 四足脇D = new 四足脇D();
			四足脇D.上腕接続(上腕_蹄D);
			四足胸D.脇左接続(四足脇D);
			四足胸D.脇右接続(四足脇D.Get逆());
			足_牛D e3 = new 足_牛D();
			脚_蹄D 脚_蹄D = new 脚_蹄D();
			脚_蹄D.足接続(e3);
			腿_蹄D 腿_蹄D = new 腿_蹄D();
			腿_蹄D.脚接続(脚_蹄D);
			四足腰D.腿左接続(腿_蹄D);
			四足腰D.腿右接続(腿_蹄D.Get逆());
			四足腰D.尾接続(new 尾_牛D());
			腰D.EnumEleD().SetValuesD("馬", true);
			腰D.EnumEleD().SetValuesD("胸毛", true);
			腰D.EnumEleD().SetValuesD("獣毛", true);
			腰D.EnumEleD().SetValuesD("獣毛", true);
			腰D.EnumEleD().SetValuesD("獣毛", true);
			腰D.EnumEleD().SetValuesD("表示", false);
			腰D.EnumEleD().SetValuesD("表示", false);
			腰D.EnumEleD().SetValuesD("獣性", true);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(false));
		}

		public static ChaD Getアリコ\u30FCン()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R1();
			頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			頭D.Set耳獣();
			頭D.額接続(new 角1_一D());
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			四足胸D 四足胸D = Uni.四足胸();
			腰D.半身接続(四足胸D);
			四足胴D 四足胴D = Uni.四足胴();
			四足胸D.胴接続(四足胴D);
			四足腰D 四足腰D = Uni.四足腰();
			四足胴D.腰接続(四足腰D);
			手_鳥D 手_鳥D = new 手_鳥D
			{
				シャ\u30FCプ = OthN.XS.NextDouble()
			};
			下腕_鳥D 下腕_鳥D = new 下腕_鳥D
			{
				シャ\u30FCプ = 手_鳥D.シャ\u30FCプ
			};
			下腕_鳥D.手接続(手_鳥D);
			上腕_鳥D 上腕_鳥D = new 上腕_鳥D
			{
				シャ\u30FCプ = 下腕_鳥D.シャ\u30FCプ
			};
			上腕_鳥D.下腕接続(下腕_鳥D);
			四足胸D.翼上左接続(上腕_鳥D);
			四足胸D.翼上右接続(上腕_鳥D.Get逆());
			手_馬D e2 = new 手_馬D();
			下腕_蹄D 下腕_蹄D = new 下腕_蹄D();
			下腕_蹄D.手接続(e2);
			上腕_蹄D 上腕_蹄D = new 上腕_蹄D();
			上腕_蹄D.下腕接続(下腕_蹄D);
			四足脇D 四足脇D = new 四足脇D();
			四足脇D.上腕接続(上腕_蹄D);
			四足胸D.脇左接続(四足脇D);
			四足胸D.脇右接続(四足脇D.Get逆());
			足_馬D e3 = new 足_馬D();
			脚_蹄D 脚_蹄D = new 脚_蹄D();
			脚_蹄D.足接続(e3);
			腿_蹄D 腿_蹄D = new 腿_蹄D();
			腿_蹄D.脚接続(脚_蹄D);
			四足腰D.腿左接続(腿_蹄D);
			四足腰D.腿右接続(腿_蹄D.Get逆());
			四足腰D.尾接続(new 尾_馬D());
			腰D.EnumEleD().SetValuesD("馬", OthN.XS.NextBool());
			腰D.EnumEleD().SetValuesD("表示", false);
			腰D.EnumEleD().SetValuesD("表示", false);
			腰D.EnumEleD().SetValuesD("獣性", true);
			四足腰D.EnumEleD().SetValuesD("獣性", false);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(false));
		}

		public static ChaD Getバイコ\u30FCン()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			基髪D eleD = 頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			頭D.Set耳獣();
			EleD eleD2 = new 角2_山2D();
			eleD2.尺度YB = 1.5;
			eleD.頭頂左接続(eleD2);
			eleD.頭頂右接続(eleD2.Get逆());
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			四足胸D 四足胸D = Uni.四足胸();
			腰D.半身接続(四足胸D);
			四足胴D 四足胴D = Uni.四足胴();
			四足胸D.胴接続(四足胴D);
			四足腰D 四足腰D = Uni.四足腰();
			四足胴D.腰接続(四足腰D);
			手_馬D e2 = new 手_馬D();
			下腕_蹄D 下腕_蹄D = new 下腕_蹄D();
			下腕_蹄D.手接続(e2);
			上腕_蹄D 上腕_蹄D = new 上腕_蹄D();
			上腕_蹄D.下腕接続(下腕_蹄D);
			四足脇D 四足脇D = new 四足脇D();
			四足脇D.上腕接続(上腕_蹄D);
			四足胸D.脇左接続(四足脇D);
			四足胸D.脇右接続(四足脇D.Get逆());
			足_馬D e3 = new 足_馬D();
			脚_蹄D 脚_蹄D = new 脚_蹄D();
			脚_蹄D.足接続(e3);
			腿_蹄D 腿_蹄D = new 腿_蹄D();
			腿_蹄D.脚接続(脚_蹄D);
			四足腰D.腿左接続(腿_蹄D);
			四足腰D.腿右接続(腿_蹄D.Get逆());
			四足腰D.尾接続(new 尾_馬D());
			腰D.EnumEleD().SetValuesD("馬", OthN.XS.NextBool());
			胸D.肌_接続.SetValuesD("胸毛", true);
			腰D.EnumEleD().SetValuesD("表示", false);
			腰D.EnumEleD().SetValuesD("表示", false);
			腰D.EnumEleD().SetValuesD("獣性", true);
			四足腰D.EnumEleD().SetValuesD("獣性", false);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(false));
		}

		public static ChaD Getペガサス()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			頭D.Set耳獣();
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			四足胸D 四足胸D = Uni.四足胸();
			腰D.半身接続(四足胸D);
			四足胴D 四足胴D = Uni.四足胴();
			四足胸D.胴接続(四足胴D);
			四足腰D 四足腰D = Uni.四足腰();
			四足胴D.腰接続(四足腰D);
			手_鳥D 手_鳥D = new 手_鳥D
			{
				シャ\u30FCプ = OthN.XS.NextDouble()
			};
			下腕_鳥D 下腕_鳥D = new 下腕_鳥D
			{
				シャ\u30FCプ = 手_鳥D.シャ\u30FCプ
			};
			下腕_鳥D.手接続(手_鳥D);
			上腕_鳥D 上腕_鳥D = new 上腕_鳥D
			{
				シャ\u30FCプ = 下腕_鳥D.シャ\u30FCプ
			};
			上腕_鳥D.下腕接続(下腕_鳥D);
			四足胸D.翼上左接続(上腕_鳥D);
			四足胸D.翼上右接続(上腕_鳥D.Get逆());
			手_馬D e2 = new 手_馬D();
			下腕_蹄D 下腕_蹄D = new 下腕_蹄D();
			下腕_蹄D.手接続(e2);
			上腕_蹄D 上腕_蹄D = new 上腕_蹄D();
			上腕_蹄D.下腕接続(下腕_蹄D);
			四足脇D 四足脇D = new 四足脇D();
			四足脇D.上腕接続(上腕_蹄D);
			四足胸D.脇左接続(四足脇D);
			四足胸D.脇右接続(四足脇D.Get逆());
			足_馬D e3 = new 足_馬D();
			脚_蹄D 脚_蹄D = new 脚_蹄D();
			脚_蹄D.足接続(e3);
			腿_蹄D 腿_蹄D = new 腿_蹄D();
			腿_蹄D.脚接続(脚_蹄D);
			四足腰D.腿左接続(腿_蹄D);
			四足腰D.腿右接続(腿_蹄D.Get逆());
			四足腰D.尾接続(new 尾_馬D());
			腰D.EnumEleD().SetValuesD("馬", OthN.XS.NextBool());
			腰D.EnumEleD().SetValuesD("表示", false);
			腰D.EnumEleD().SetValuesD("表示", false);
			腰D.EnumEleD().SetValuesD("獣性", true);
			四足腰D.EnumEleD().SetValuesD("獣性", false);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(OthN.XS.NextBool()));
		}

		public static ChaD Getグリフォン()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			頭D.Set耳羽();
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			四足胸D 四足胸D = Uni.四足胸();
			腰D.半身接続(四足胸D);
			四足胴D 四足胴D = Uni.四足胴();
			四足胸D.胴接続(四足胴D);
			四足腰D 四足腰D = Uni.四足腰();
			四足胴D.腰接続(四足腰D);
			四足胸D.背中接続(new 背中_羽D
			{
				毛 = true
			});
			手_鳥D 手_鳥D = new 手_鳥D();
			下腕_鳥D 下腕_鳥D = new 下腕_鳥D();
			下腕_鳥D.手接続(手_鳥D);
			上腕_鳥D 上腕_鳥D = new 上腕_鳥D();
			上腕_鳥D.下腕接続(下腕_鳥D);
			if (OthN.XS.NextBool())
			{
				手_鳥D.シャ\u30FCプ = 1.0;
				下腕_鳥D.シャ\u30FCプ = 1.0;
				上腕_鳥D.シャ\u30FCプ = 1.0;
			}
			四足胸D.翼上左接続(上腕_鳥D);
			四足胸D.翼上右接続(上腕_鳥D.Get逆());
			四足胸D.背中接続(new 背中_羽D());
			足_鳥D e2 = new 足_鳥D();
			脚_鳥D 脚_鳥D = new 脚_鳥D();
			脚_鳥D.足接続(e2);
			脚_鳥D.尺度B = 1.3;
			四足脇D 四足脇D = new 四足脇D();
			四足脇D.上腕接続(脚_鳥D);
			四足胸D.脇左接続(四足脇D);
			四足胸D.脇右接続(四足脇D.Get逆());
			足_獣D e3 = new 足_獣D();
			脚_獣D 脚_獣D = new 脚_獣D();
			脚_獣D.足接続(e3);
			腿_獣D 腿_獣D = new 腿_獣D();
			腿_獣D.脚接続(脚_獣D);
			四足腰D.腿左接続(腿_獣D);
			四足腰D.腿右接続(腿_獣D.Get逆());
			四足腰D.尾接続(new 尾_牛D());
			四足胴D.SetValuesD("獣毛", true);
			腰D.EnumEleD().SetValuesD("獣毛", true);
			腰D.EnumEleD().SetValuesD("表示", true);
			腰D.EnumEleD().SetValuesD("表示", false);
			腰D.EnumEleD().SetValuesD("表示", false);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(false));
		}

		public static ChaD Getヒッポグリフ()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			頭D.Set耳羽();
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			四足胸D 四足胸D = Uni.四足胸();
			腰D.半身接続(四足胸D);
			四足胴D 四足胴D = Uni.四足胴();
			四足胸D.胴接続(四足胴D);
			四足腰D 四足腰D = Uni.四足腰();
			四足胴D.腰接続(四足腰D);
			四足胸D.背中接続(new 背中_羽D
			{
				毛 = true
			});
			手_鳥D 手_鳥D = new 手_鳥D();
			下腕_鳥D 下腕_鳥D = new 下腕_鳥D();
			下腕_鳥D.手接続(手_鳥D);
			上腕_鳥D 上腕_鳥D = new 上腕_鳥D();
			上腕_鳥D.下腕接続(下腕_鳥D);
			if (OthN.XS.NextBool())
			{
				手_鳥D.シャ\u30FCプ = 1.0;
				下腕_鳥D.シャ\u30FCプ = 1.0;
				上腕_鳥D.シャ\u30FCプ = 1.0;
			}
			四足胸D.翼上左接続(上腕_鳥D);
			四足胸D.翼上右接続(上腕_鳥D.Get逆());
			四足胸D.背中接続(new 背中_羽D());
			足_鳥D e2 = new 足_鳥D();
			脚_鳥D 脚_鳥D = new 脚_鳥D
			{
				尺度B = 1.3
			};
			脚_鳥D.足接続(e2);
			四足脇D 四足脇D = new 四足脇D();
			四足脇D.上腕接続(脚_鳥D);
			四足胸D.脇左接続(四足脇D);
			四足胸D.脇右接続(四足脇D.Get逆());
			足_馬D e3 = new 足_馬D();
			脚_蹄D 脚_蹄D = new 脚_蹄D();
			脚_蹄D.足接続(e3);
			腿_蹄D 腿_蹄D = new 腿_蹄D();
			腿_蹄D.脚接続(脚_蹄D);
			四足腰D.腿左接続(腿_蹄D);
			四足腰D.腿右接続(腿_蹄D.Get逆());
			四足腰D.尾接続(new 尾_馬D());
			腰D.EnumEleD().SetValuesD("馬", OthN.XS.NextBool());
			四足胴D.SetValuesD("獣毛", true);
			腰D.EnumEleD().SetValuesD("獣毛", true);
			腰D.EnumEleD().SetValuesD("表示", true);
			腰D.EnumEleD().SetValuesD("表示", false);
			腰D.EnumEleD().SetValuesD("表示", false);
			四足胴D.SetValuesD("獣性", false);
			四足腰D.EnumEleD().SetValuesD("獣性", false);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(false));
		}

		public static ChaD Getキマイラ()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			基髪D eleD = 頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻R();
			頭D.Set口人();
			頭D.Set舌短();
			EleD eleD2 = new 獣耳D();
			eleD.頭頂左接続(eleD2);
			eleD.頭頂右接続(eleD2.Get逆());
			int num = OthN.XS.Next(3);
			if (num != 0)
			{
				if (num != 1)
				{
					eleD2 = new 角2_山3D();
				}
				else
				{
					eleD2 = new 角2_山2D();
				}
			}
			else
			{
				eleD2 = new 角2_山1D();
			}
			eleD.頭頂左接続(eleD2);
			eleD.頭頂右接続(eleD2.Get逆());
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			四足胸D 四足胸D = Uni.四足胸();
			腰D.半身接続(四足胸D);
			四足胴D 四足胴D = Uni.四足胴();
			四足胸D.胴接続(四足胴D);
			四足腰D 四足腰D = Uni.四足腰();
			四足胴D.腰接続(四足腰D);
			四足胸D.背中接続(new 背中_羽D
			{
				毛 = true
			});
			手_獣D e2 = new 手_獣D();
			下腕_獣D 下腕_獣D = new 下腕_獣D();
			下腕_獣D.手接続(e2);
			上腕_獣D 上腕_獣D = new 上腕_獣D();
			上腕_獣D.下腕接続(下腕_獣D);
			四足脇D 四足脇D = new 四足脇D();
			四足脇D.上腕接続(上腕_獣D);
			四足胸D.脇左接続(四足脇D);
			四足胸D.脇右接続(四足脇D.Get逆());
			足_牛D e3 = new 足_牛D();
			脚_蹄D 脚_蹄D = new 脚_蹄D();
			脚_蹄D.足接続(e3);
			腿_蹄D 腿_蹄D = new 腿_蹄D();
			腿_蹄D.脚接続(脚_蹄D);
			四足腰D.腿左接続(腿_蹄D);
			四足腰D.腿右接続(腿_蹄D.Get逆());
			四足腰D.尾接続(new 尾_蛇D());
			腰D.EnumEleD().SetValuesD("獣性", true);
			腰D.EnumEleD().SetValuesD("配色指定", 配色指定.B0);
			腰D.EnumEleD().SetValuesD("髭", 頭D.鼻_接続.IsEleD<鼻_獣D>());
			腰D.EnumEleD().SetValuesD("牙", true);
			腰D.EnumEleD().SetValuesD("表示", false);
			腰D.EnumEleD().SetValuesD("表示", false);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(false));
		}

		public static ChaD Getスフィンクス(bool b)
		{
			腰D 腰D = Uni.腰();
			胴D 胴D = 腰D.Set胴();
			胸D 胸D = 胴D.Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			頭D.Set耳人();
			if (b)
			{
				EleD e = OthN.XS.NextBool() ? new 尾_牛D() : new 尾_蛇D();
				腰D.尾接続(e);
				胸D.背中接続(new 背中_羽D
				{
					毛 = true
				});
				手_鳥D e2 = new 手_鳥D();
				下腕_鳥D 下腕_鳥D = new 下腕_鳥D();
				下腕_鳥D.手接続(e2);
				上腕_鳥D 上腕_鳥D = new 上腕_鳥D();
				上腕_鳥D.下腕接続(下腕_鳥D);
				肩D 肩D = new 肩D();
				肩D.上腕接続(上腕_鳥D);
				胸D.肩左接続(肩D);
				胸D.肩右接続(肩D.Get逆());
				手_獣D e3 = new 手_獣D
				{
					尺度B = 0.9
				};
				下腕_獣D 下腕_獣D = new 下腕_獣D
				{
					尺度B = 0.9
				};
				下腕_獣D.手接続(e3);
				上腕_人D 上腕_人D = new 上腕_人D();
				上腕_人D.下腕接続(下腕_獣D);
				肩D 肩D2 = new 肩D();
				肩D2.上腕接続(上腕_人D);
				上腕_人D.EnumEleD().SetValuesD("獣性", true);
				胸D.肩左接続(肩D2);
				胸D.肩右接続(肩D2.Get逆());
				足_獣D e4 = new 足_獣D();
				脚_獣D 脚_獣D = new 脚_獣D();
				脚_獣D.足接続(e4);
				腿_獣D 腿_獣D = new 腿_獣D();
				腿_獣D.脚接続(脚_獣D);
				腰D.腿左接続(腿_獣D);
				腰D.腿右接続(腿_獣D.Get逆());
				胸D.肌_接続.SetValuesD("表示", true);
				胸D.SetValuesD("獣性", true);
				胴D.SetValuesD("獣性", true);
				腰D.SetValuesD("獣性", true);
			}
			else
			{
				手_鳥D e5 = new 手_鳥D();
				下腕_鳥D 下腕_鳥D2 = new 下腕_鳥D();
				下腕_鳥D2.手接続(e5);
				上腕_鳥D 上腕_鳥D2 = new 上腕_鳥D();
				上腕_鳥D2.下腕接続(下腕_鳥D2);
				肩D 肩D3 = new 肩D();
				肩D3.上腕接続(上腕_鳥D2);
				胸D.肩左接続(肩D3);
				胸D.肩右接続(肩D3.Get逆());
				四足胸D 四足胸D = Uni.四足胸();
				腰D.半身接続(四足胸D);
				四足胴D 四足胴D = Uni.四足胴();
				四足胸D.胴接続(四足胴D);
				四足腰D 四足腰D = Uni.四足腰();
				四足胴D.腰接続(四足腰D);
				四足胸D.背中接続(new 背中_羽D
				{
					毛 = true
				});
				手_獣D e6 = new 手_獣D();
				下腕_獣D 下腕_獣D2 = new 下腕_獣D();
				下腕_獣D2.手接続(e6);
				上腕_獣D 上腕_獣D = new 上腕_獣D();
				上腕_獣D.下腕接続(下腕_獣D2);
				四足脇D 四足脇D = new 四足脇D();
				四足脇D.上腕接続(上腕_獣D);
				四足胸D.脇左接続(四足脇D);
				四足胸D.脇右接続(四足脇D.Get逆());
				足_獣D e7 = new 足_獣D();
				脚_獣D 脚_獣D2 = new 脚_獣D();
				脚_獣D2.足接続(e7);
				腿_獣D 腿_獣D2 = new 腿_獣D();
				腿_獣D2.脚接続(脚_獣D2);
				四足腰D.腿左接続(腿_獣D2);
				四足腰D.腿右接続(腿_獣D2.Get逆());
				EleD e = OthN.XS.NextBool() ? new 尾_牛D() : new 尾_蛇D();
				四足腰D.尾接続(e);
				四足胴D.SetValuesD("獣毛", true);
				四足胸D.肌_接続.SetValuesD("表示", true);
				腰D.EnumEleD().SetValuesD("表示", false);
				腰D.EnumEleD().SetValuesD("表示", false);
			}
			腰D.EnumEleD().SetValuesD("牙", true);
			腰D.EnumEleD().SetValuesD("獣性", true);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(OthN.XS.NextBool()));
		}

		public static ChaD Getレオントケンタウレ()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			基髪D eleD = 頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻R();
			頭D.Set口人();
			頭D.Set舌短();
			EleD eleD2 = new 獣耳D();
			eleD.頭頂左接続(eleD2);
			eleD.頭頂右接続(eleD2.Get逆());
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			四足胸D 四足胸D = Uni.四足胸();
			腰D.半身接続(四足胸D);
			四足胴D 四足胴D = Uni.四足胴();
			四足胸D.胴接続(四足胴D);
			四足腰D 四足腰D = Uni.四足腰();
			四足胴D.腰接続(四足腰D);
			四足胸D.背中接続(new 背中_羽D
			{
				毛 = true
			});
			手_獣D e2 = new 手_獣D();
			下腕_獣D 下腕_獣D = new 下腕_獣D();
			下腕_獣D.手接続(e2);
			上腕_獣D 上腕_獣D = new 上腕_獣D();
			上腕_獣D.下腕接続(下腕_獣D);
			四足脇D 四足脇D = new 四足脇D();
			四足脇D.上腕接続(上腕_獣D);
			四足胸D.脇左接続(四足脇D);
			四足胸D.脇右接続(四足脇D.Get逆());
			足_獣D e3 = new 足_獣D();
			脚_獣D 脚_獣D = new 脚_獣D();
			脚_獣D.足接続(e3);
			腿_獣D 腿_獣D = new 腿_獣D();
			腿_獣D.脚接続(脚_獣D);
			四足腰D.腿左接続(腿_獣D);
			四足腰D.腿右接続(腿_獣D.Get逆());
			四足腰D.尾接続(new 尾_牛D());
			腰D.EnumEleD().SetValuesD("獣性", true);
			腰D.EnumEleD().SetValuesD("配色指定", 配色指定.B0);
			腰D.EnumEleD().SetValuesD("配色指定", 配色指定.B0);
			胸D.肌_接続.SetValuesD("胸毛", false);
			腰D.EnumEleD().SetValuesD("髭", 頭D.鼻_接続.IsEleD<鼻_獣D>());
			腰D.EnumEleD().SetValuesD("牙", true);
			腰D.EnumEleD().SetValuesD("表示", false);
			腰D.EnumEleD().SetValuesD("表示", false);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(OthN.XS.NextBool()));
		}

		public static ChaD Getティグリスケンタウレ()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			基髪D eleD = 頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻R();
			頭D.Set口人();
			頭D.Set舌短();
			EleD eleD2 = new 獣耳D();
			eleD.頭頂左接続(eleD2);
			eleD.頭頂右接続(eleD2.Get逆());
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			四足胸D 四足胸D = Uni.四足胸();
			腰D.半身接続(四足胸D);
			四足胴D 四足胴D = Uni.四足胴();
			四足胸D.胴接続(四足胴D);
			四足腰D 四足腰D = Uni.四足腰();
			四足胴D.腰接続(四足腰D);
			手_獣D e2 = new 手_獣D();
			下腕_獣D 下腕_獣D = new 下腕_獣D();
			下腕_獣D.手接続(e2);
			上腕_獣D 上腕_獣D = new 上腕_獣D();
			上腕_獣D.下腕接続(下腕_獣D);
			四足脇D 四足脇D = new 四足脇D();
			四足脇D.上腕接続(上腕_獣D);
			四足胸D.脇左接続(四足脇D);
			四足胸D.脇右接続(四足脇D.Get逆());
			足_獣D e3 = new 足_獣D();
			脚_獣D 脚_獣D = new 脚_獣D();
			脚_獣D.足接続(e3);
			腿_獣D 腿_獣D = new 腿_獣D();
			腿_獣D.脚接続(脚_獣D);
			四足腰D.腿左接続(腿_獣D);
			四足腰D.腿右接続(腿_獣D.Get逆());
			四足腰D.尾接続(new 尾_猫D());
			腰D.EnumEleD().SetValuesD("獣性", true);
			腰D.EnumEleD().SetValuesD("配色指定", 配色指定.B0);
			腰D.EnumEleD().SetValuesD("配色指定", 配色指定.B0);
			if (OthN.XS.NextBool())
			{
				腰D.EnumEleD().SetValuesD("配色指定", 配色指定.T0);
				腰D.EnumEleD().SetValuesD("配色指定", 配色指定.T0);
			}
			else
			{
				腰D.EnumEleD().SetValuesD("配色指定", 配色指定.T1);
				腰D.EnumEleD().SetValuesD("配色指定", 配色指定.T1);
			}
			四足胸D.肌_接続.SetValuesD("胸毛", false);
			腰D.EnumEleD().SetValuesD("虎", true);
			腰D.EnumEleD().SetValuesD("隈取", true);
			腰D.EnumEleD().SetValuesD("獣性", false);
			腰D.EnumEleD().SetValuesD("淫", true);
			腰D.EnumEleD().SetValuesD("ハート", false);
			腰D.EnumEleD().SetValuesD("髭", 頭D.鼻_接続.IsEleD<鼻_獣D>());
			腰D.EnumEleD().SetValuesD("牙", true);
			腰D.EnumEleD().SetValuesD("表示", false);
			腰D.EnumEleD().SetValuesD("表示", false);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(OthN.XS.NextBool()));
		}

		public static ChaD Getパンテ\u30FCラケンタウレ()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			基髪D eleD = 頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻R();
			頭D.Set口人();
			頭D.Set舌短();
			EleD eleD2 = new 獣耳D();
			eleD.頭頂左接続(eleD2);
			eleD.頭頂右接続(eleD2.Get逆());
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			四足胸D 四足胸D = Uni.四足胸();
			腰D.半身接続(四足胸D);
			四足胴D 四足胴D = Uni.四足胴();
			四足胸D.胴接続(四足胴D);
			四足腰D 四足腰D = Uni.四足腰();
			四足胴D.腰接続(四足腰D);
			手_獣D e2 = new 手_獣D();
			下腕_獣D 下腕_獣D = new 下腕_獣D();
			下腕_獣D.手接続(e2);
			上腕_獣D 上腕_獣D = new 上腕_獣D();
			上腕_獣D.下腕接続(下腕_獣D);
			四足脇D 四足脇D = new 四足脇D();
			四足脇D.上腕接続(上腕_獣D);
			四足胸D.脇左接続(四足脇D);
			四足胸D.脇右接続(四足脇D.Get逆());
			足_獣D e3 = new 足_獣D();
			脚_獣D 脚_獣D = new 脚_獣D();
			脚_獣D.足接続(e3);
			腿_獣D 腿_獣D = new 腿_獣D();
			腿_獣D.脚接続(脚_獣D);
			四足腰D.腿左接続(腿_獣D);
			四足腰D.腿右接続(腿_獣D.Get逆());
			四足腰D.尾接続(new 尾_猫D());
			腰D.EnumEleD().SetValuesD("獣性", true);
			腰D.EnumEleD().SetValuesD("配色指定", 配色指定.B0);
			腰D.EnumEleD().SetValuesD("配色指定", 配色指定.B0);
			腰D.EnumEleD().SetValuesD("胸毛", false);
			腰D.EnumEleD().SetValuesD("紋柄", true);
			腰D.EnumEleD().SetValuesD("紋柄", false);
			腰D.EnumEleD().SetValuesD("獣性", false);
			腰D.EnumEleD().SetValuesD("髭", 頭D.鼻_接続.IsEleD<鼻_獣D>());
			腰D.EnumEleD().SetValuesD("牙", true);
			腰D.EnumEleD().SetValuesD("表示", false);
			腰D.EnumEleD().SetValuesD("表示", false);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(OthN.XS.NextBool()));
		}

		public static ChaD Getチ\u30FCタケンタウレ()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			基髪D eleD = 頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻R();
			頭D.Set口人();
			頭D.Set舌短();
			EleD eleD2 = new 獣耳D();
			eleD.頭頂左接続(eleD2);
			eleD.頭頂右接続(eleD2.Get逆());
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			double num = 0.95;
			四足胸D 四足胸D = Uni.四足胸();
			腰D.半身接続(四足胸D);
			四足胴D 四足胴D = Uni.四足胴();
			四足胸D.胴接続(四足胴D);
			四足腰D 四足腰D = Uni.四足腰();
			四足胴D.腰接続(四足腰D);
			四足胸D.EnumEleD().SetValuesD("尺度XB", num);
			手_獣D e2 = new 手_獣D();
			下腕_獣D 下腕_獣D = new 下腕_獣D();
			下腕_獣D.手接続(e2);
			上腕_獣D 上腕_獣D = new 上腕_獣D();
			上腕_獣D.下腕接続(下腕_獣D);
			四足脇D 四足脇D = new 四足脇D();
			四足脇D.上腕接続(上腕_獣D);
			num = 1.035;
			下腕_獣D.EnumEleD().SetValuesD("尺度YB", num);
			上腕_獣D.尺度XB = num;
			四足胸D.脇左接続(四足脇D);
			四足胸D.脇右接続(四足脇D.Get逆());
			足_獣D e3 = new 足_獣D();
			脚_獣D 脚_獣D = new 脚_獣D();
			脚_獣D.足接続(e3);
			腿_獣D 腿_獣D = new 腿_獣D();
			腿_獣D.脚接続(脚_獣D);
			脚_獣D.EnumEleD().SetValuesD("尺度YB", num);
			腿_獣D.尺度XB = num;
			四足腰D.腿左接続(腿_獣D);
			四足腰D.腿右接続(腿_獣D.Get逆());
			四足腰D.尾接続(new 尾_猫D());
			四足腰D.EnumEleD().SetValuesD("肥大", 0.5);
			腰D.EnumEleD().SetValuesD("獣性", true);
			腰D.EnumEleD().SetValuesD("獣腕", false);
			腰D.EnumEleD().SetValuesD("獣性", false);
			腰D.EnumEleD().SetValuesD("獣毛", true);
			腰D.EnumEleD().SetValuesD("肉球", true);
			腰D.EnumEleD().SetValuesD("配色指定", 配色指定.B0);
			腰D.EnumEleD().SetValuesD("配色指定", 配色指定.B0);
			腰D.EnumEleD().SetValuesD("胸毛", false);
			腰D.EnumEleD().SetValuesD("紋柄", true);
			腰D.EnumEleD().SetValuesD("紋柄", false);
			腰D.EnumEleD().SetValuesD("獣性", false);
			腰D.EnumEleD().SetValuesD("豹", true);
			腰D.EnumEleD().SetValuesD("髭", 頭D.鼻_接続.IsEleD<鼻_獣D>());
			腰D.EnumEleD().SetValuesD("牙", true);
			腰D.EnumEleD().SetValuesD("表示", false);
			腰D.EnumEleD().SetValuesD("表示", false);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(OthN.XS.NextBool()));
		}

		public static ChaD Getウェアドラゴンフライ()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口R();
			頭D.Set舌短();
			頭D.Set耳尖();
			EleD eleD = new 虫顎D();
			頭D.頬左接続(eleD);
			頭D.頬右接続(eleD.Get逆());
			顔面_虫D 顔面_虫D = new 顔面_虫D();
			eleD = new 触覚_線D();
			eleD.尺度YB = 0.4;
			顔面_虫D.触覚左接続(eleD);
			顔面_虫D.触覚右接続(eleD.Get逆());
			頭D.顔面接続(顔面_虫D);
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			胸D.肩左接続(肩D.Copy());
			胸D.肩右接続(肩D.Get逆());
			eleD = new 前翅_羽D();
			胸D.翼上左接続(eleD);
			胸D.翼上右接続(eleD.Get逆());
			eleD = new 後翅_羽D();
			胸D.翼下左接続(eleD);
			胸D.翼下右接続(eleD.Get逆());
			足_人D e2 = new 足_人D();
			脚_人D 脚_人D = new 脚_人D();
			脚_人D.足接続(e2);
			腿_人D 腿_人D = new 腿_人D();
			腿_人D.脚接続(脚_人D);
			腰D.腿左接続(腿_人D);
			腰D.腿右接続(腿_人D.Get逆());
			eleD = new 尾_竜D();
			腰D.尾接続(eleD);
			腰D.EnumEleD().SetValuesD("虫性", true);
			腰D.EnumEleD().SetValuesD("虫手", true);
			腰D.EnumEleD().SetValuesD("虫足", true);
			腰D.EnumEleD().SetValuesD("虫鎌節", false);
			腰D.EnumEleD().SetValuesD("鱗", true);
			腰D.EnumEleD().SetValuesD("鱗", true);
			腰D.EnumEleD().SetValuesD("配色", 配色指定.C0);
			腰D.EnumEleD().SetValuesD("瞳孔", false);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(false));
		}

		public static ChaD Getウェアビ\u30FCトル()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			頭D.Set耳尖();
			頭D.額接続(new 角1_虫D());
			EleD eleD = new 虫顎D();
			頭D.頬左接続(eleD);
			頭D.頬右接続(eleD.Get逆());
			顔面_甲D 顔面_甲D = new 顔面_甲D();
			eleD = new 触覚_甲D();
			顔面_甲D.触覚左接続(eleD);
			顔面_甲D.触覚右接続(eleD.Get逆());
			頭D.顔面接続(顔面_甲D);
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			胸D.肩左接続(肩D.Copy());
			胸D.肩右接続(肩D.Get逆());
			eleD = new 後翅_甲D();
			胸D.翼上左接続(eleD);
			胸D.翼上右接続(eleD.Get逆());
			eleD = new 前翅_甲D();
			eleD.SetValuesD("紋", OthN.XS.NextBool());
			胸D.翼上左接続(eleD);
			胸D.翼上右接続(eleD.Get逆());
			足_人D e2 = new 足_人D();
			脚_人D 脚_人D = new 脚_人D();
			脚_人D.足接続(e2);
			腿_人D 腿_人D = new 腿_人D();
			腿_人D.脚接続(脚_人D);
			腰D.腿左接続(腿_人D);
			腰D.腿右接続(腿_人D.Get逆());
			腰D.EnumEleD().SetValuesD("虫性", true);
			腰D.EnumEleD().SetValuesD("虫手", true);
			腰D.EnumEleD().SetValuesD("虫足", true);
			腰D.EnumEleD().SetValuesD("虫鎌節", false);
			腰D.EnumEleD().SetValuesD("鱗", true);
			腰D.EnumEleD().SetValuesD("鱗", true);
			腰D.EnumEleD().SetValuesD("配色", 配色指定.C0);
			腰D.EnumEleD().SetValuesD("棘3", false);
			腰D.EnumEleD().SetValuesD("棘4", false);
			腰D.EnumEleD().SetValuesD("瞳孔", false);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(false));
		}

		public static ChaD Getウェアスタッグビ\u30FCトル()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			頭D.Set耳尖();
			EleD eleD = new 耳_尖D();
			頭D.耳左接続(eleD);
			頭D.耳右接続(eleD.Get逆());
			大顎基D 大顎基D = new 大顎基D();
			eleD = new 大顎D();
			大顎基D.顎左接続(eleD);
			大顎基D.顎右接続(eleD.Get逆());
			頭D.大顎基接続(大顎基D);
			顔面_甲D 顔面_甲D = new 顔面_甲D();
			eleD = new 触覚_甲D();
			顔面_甲D.触覚左接続(eleD);
			顔面_甲D.触覚右接続(eleD.Get逆());
			頭D.顔面接続(顔面_甲D);
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			胸D.肩左接続(肩D.Copy());
			胸D.肩右接続(肩D.Get逆());
			eleD = new 後翅_甲D();
			胸D.翼上左接続(eleD);
			胸D.翼上右接続(eleD.Get逆());
			eleD = new 前翅_甲D();
			eleD.SetValuesD("紋", OthN.XS.NextBool());
			胸D.翼上左接続(eleD);
			胸D.翼上右接続(eleD.Get逆());
			足_人D e2 = new 足_人D();
			脚_人D 脚_人D = new 脚_人D();
			脚_人D.足接続(e2);
			腿_人D 腿_人D = new 腿_人D();
			腿_人D.脚接続(脚_人D);
			腰D.腿左接続(腿_人D);
			腰D.腿右接続(腿_人D.Get逆());
			腰D.EnumEleD().SetValuesD("虫性", true);
			腰D.EnumEleD().SetValuesD("虫手", true);
			腰D.EnumEleD().SetValuesD("虫足", true);
			腰D.EnumEleD().SetValuesD("虫鎌節", false);
			腰D.EnumEleD().SetValuesD("鱗", true);
			腰D.EnumEleD().SetValuesD("鱗", true);
			腰D.EnumEleD().SetValuesD("配色", 配色指定.C0);
			腰D.EnumEleD().SetValuesD("棘", false);
			腰D.EnumEleD().SetValuesD("瞳孔", false);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(false));
		}

		public static ChaD Getウェアマンティス()
		{
			腰D 腰D = Uni.腰();
			胴D 胴D = 腰D.Set胴();
			胸D 胸D = 胴D.Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口R();
			頭D.Set舌短();
			頭D.Set耳尖();
			EleD eleD = new 虫顎D();
			頭D.頬左接続(eleD);
			頭D.頬右接続(eleD.Get逆());
			顔面_虫D 顔面_虫D = new 顔面_虫D();
			eleD = new 触覚_線D();
			顔面_虫D.触覚左接続(eleD);
			顔面_虫D.触覚右接続(eleD.Get逆());
			頭D.顔面接続(顔面_虫D);
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			下腕_人D.虫鎌接続(new 虫鎌D());
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			eleD = new 前翅_草D();
			eleD.SetValuesD("紋", OthN.XS.NextBool());
			胴D.翼左接続(eleD);
			胴D.翼右接続(eleD.Get逆());
			eleD = new 後翅_草D();
			胴D.翼左接続(eleD);
			胴D.翼右接続(eleD.Get逆());
			足_人D e2 = new 足_人D();
			脚_人D 脚_人D = new 脚_人D();
			脚_人D.足接続(e2);
			腿_人D 腿_人D = new 腿_人D();
			腿_人D.脚接続(脚_人D);
			腰D.腿左接続(腿_人D);
			腰D.腿右接続(腿_人D.Get逆());
			eleD = new 尾_虫D();
			腰D.尾接続(eleD);
			腰D.EnumEleD().SetValuesD("虫性", true);
			腰D.EnumEleD().SetValuesD("虫手", true);
			腰D.EnumEleD().SetValuesD("虫足", true);
			腰D.EnumEleD().SetValuesD("鱗", true);
			腰D.EnumEleD().SetValuesD("鱗", true);
			腰D.EnumEleD().SetValuesD("配色", 配色指定.C0);
			腰D.EnumEleD().SetValuesD("棘2", false);
			腰D.EnumEleD().SetValuesD("棘3", false);
			腰D.EnumEleD().SetValuesD("瞳孔", false);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(false));
		}

		public static ChaD Getエキドナ()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌長();
			if (OthN.XS.NextBool())
			{
				頭D.Set耳人();
			}
			else
			{
				頭D.Set耳尖();
			}
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			手_鳥D 手_鳥D = new 手_鳥D
			{
				シャ\u30FCプ = OthN.XS.NextDouble()
			};
			下腕_鳥D 下腕_鳥D = new 下腕_鳥D
			{
				シャ\u30FCプ = 手_鳥D.シャ\u30FCプ
			};
			下腕_鳥D.手接続(手_鳥D);
			上腕_鳥D 上腕_鳥D = new 上腕_鳥D
			{
				シャ\u30FCプ = 下腕_鳥D.シャ\u30FCプ
			};
			上腕_鳥D.下腕接続(下腕_鳥D);
			胸D.翼上左接続(上腕_鳥D);
			胸D.翼上右接続(上腕_鳥D.Get逆());
			長物_蛇D 長物_蛇D = new 長物_蛇D();
			腰D.半身接続(長物_蛇D);
			胴_蛇D 胴_蛇D = new 胴_蛇D();
			長物_蛇D.胴接続(胴_蛇D);
			for (int i = 0; i < 45; i++)
			{
				胴_蛇D.胴接続(胴_蛇D = new 胴_蛇D());
			}
			胴_蛇D.胴接続(OthN.XS.NextBool() ? new 尾_ヘD() : new 尾_ガD());
			腰D.EnumEleD().SetValuesD("牙", true);
			腰D.EnumEleD().SetValuesD("股舌表示", true);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(false));
		}

		public static ChaD Getゴルゴン()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			基髪D eleD = 頭D.EnumEleD().GetEleD<基髪D>();
			後髪0_肢系D 後髪0_肢系D = new 後髪0_肢系D();
			EleD eleD2 = new 尾_蛇D();
			後髪0_肢系D.左5接続(eleD2);
			後髪0_肢系D.左4接続(eleD2.Copy());
			後髪0_肢系D.左3接続(eleD2.Copy());
			後髪0_肢系D.左2接続(eleD2.Copy());
			後髪0_肢系D.左1接続(eleD2.Copy());
			後髪0_肢系D.右1接続(eleD2.Copy());
			後髪0_肢系D.右2接続(eleD2.Copy());
			後髪0_肢系D.右3接続(eleD2.Copy());
			後髪0_肢系D.右4接続(eleD2.Copy());
			後髪0_肢系D.右5接続(eleD2.Copy());
			eleD.後髪_接続.RemoveAt(0);
			eleD.後髪_接続.Insert(0, 後髪0_肢系D);
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口裂();
			頭D.Set舌長();
			頭D.Set耳尖();
			頭D.額接続(Con.Get縦眼R());
			eleD2 = Con.Get頬眼R(false);
			頭D.頬肌左接続(eleD2);
			頭D.頬肌右接続(eleD2.Get逆());
			int num = OthN.XS.Next(3);
			if (num != 0)
			{
				if (num != 1)
				{
					eleD2 = new 角2_鬼D();
				}
				else
				{
					eleD2 = new 角2_牛4D();
				}
			}
			else
			{
				eleD2 = new 角2_牛1D();
			}
			eleD.頭頂左接続(eleD2);
			eleD.頭頂右接続(eleD2.Get逆());
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			四足胸D 四足胸D = Uni.四足胸();
			腰D.半身接続(四足胸D);
			四足胴D 四足胴D = Uni.四足胴();
			四足胸D.胴接続(四足胴D);
			四足腰D 四足腰D = Uni.四足腰();
			四足胴D.腰接続(四足腰D);
			手_鳥D 手_鳥D = new 手_鳥D
			{
				シャ\u30FCプ = OthN.XS.NextDouble()
			};
			下腕_鳥D 下腕_鳥D = new 下腕_鳥D
			{
				シャ\u30FCプ = 手_鳥D.シャ\u30FCプ
			};
			下腕_鳥D.手接続(手_鳥D);
			上腕_鳥D 上腕_鳥D = new 上腕_鳥D
			{
				シャ\u30FCプ = 下腕_鳥D.シャ\u30FCプ
			};
			上腕_鳥D.下腕接続(下腕_鳥D);
			四足胸D.翼上左接続(上腕_鳥D);
			四足胸D.翼上右接続(上腕_鳥D.Get逆());
			足_馬D e2 = new 足_馬D();
			脚_蹄D 脚_蹄D = new 脚_蹄D();
			脚_蹄D.足接続(e2);
			腿_蹄D 腿_蹄D = new 腿_蹄D();
			腿_蹄D.脚接続(脚_蹄D);
			四足腰D.腿左接続(腿_蹄D);
			四足腰D.腿右接続(腿_蹄D.Get逆());
			四足腰D.尾接続(new 尾_馬D());
			腰D.EnumEleD().SetValuesD("竜性", true);
			腰D.EnumEleD().SetValuesD("竜性", true);
			腰D.EnumEleD().SetValuesD("鱗", true);
			腰D.EnumEleD().SetValuesD("配色", 配色指定.S0);
			腰D.EnumEleD().SetValuesD("表示", false);
			腰D.EnumEleD().SetValuesD("表示", false);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(false));
		}

		public static ChaD Getヒュドラ()
		{
			腰D 腰D = Uni.腰();
			頭D 頭D = 腰D.Set胴().Set胸R().Set首().Set頭R();
			基髪D eleD = 頭D.EnumEleD().GetEleD<基髪D>();
			後髪0_肢系D 後髪0_肢系D = new 後髪0_肢系D();
			EleD eleD2 = new 尾_蛇D();
			後髪0_肢系D.左5接続(eleD2);
			後髪0_肢系D.左4接続(eleD2.Copy());
			後髪0_肢系D.左3接続(eleD2.Copy());
			後髪0_肢系D.左2接続(eleD2.Copy());
			後髪0_肢系D.左1接続(eleD2.Copy());
			後髪0_肢系D.右1接続(eleD2.Copy());
			後髪0_肢系D.右2接続(eleD2.Copy());
			後髪0_肢系D.右3接続(eleD2.Copy());
			後髪0_肢系D.右4接続(eleD2.Copy());
			後髪0_肢系D.右5接続(eleD2.Copy());
			eleD.後髪_接続.RemoveAt(0);
			eleD.後髪_接続.Insert(0, 後髪0_肢系D);
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口裂();
			頭D.Set舌長();
			頭D.Set耳人();
			頭頂_宇D 頭頂_宇D = new 頭頂_宇D
			{
				鱗 = true
			};
			頭頂_宇D.頭部後接続(new 頭頂後_宇D());
			頭D.頭頂接続(頭頂_宇D);
			長物_蛇D 長物_蛇D = new 長物_蛇D();
			腰D.半身接続(長物_蛇D);
			胴_蛇D 胴_蛇D = new 胴_蛇D();
			長物_蛇D.胴接続(胴_蛇D);
			for (int i = 0; i < 45; i++)
			{
				胴_蛇D.胴接続(胴_蛇D = new 胴_蛇D());
			}
			胴_蛇D.胴接続(new 尾_ヘD());
			腰D.EnumEleD().SetValuesD("竜性", true);
			腰D.EnumEleD().SetValuesD("竜性", false);
			腰D.EnumEleD().SetValuesD("股舌表示", true);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(false));
		}

		public static ChaD Getウロボロス()
		{
			腰D 腰D = Uni.腰();
			頭D 頭D = 腰D.Set胴().Set胸R().Set首().Set頭R();
			基髪D eleD = 頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口裂();
			頭D.Set舌長();
			頭D.Set耳人();
			頭D.額接続(new 角1_虫D());
			EleD eleD2 = new 角2_虫D();
			eleD.頭頂左接続(eleD2);
			eleD.頭頂右接続(eleD2.Get逆());
			顔面_甲D e = new 顔面_甲D();
			頭D.顔面接続(e);
			長物_蛇D 長物_蛇D = new 長物_蛇D();
			腰D.半身接続(長物_蛇D);
			胴_蛇D 胴_蛇D = new 胴_蛇D();
			長物_蛇D.胴接続(胴_蛇D);
			for (int i = 0; i < 40; i++)
			{
				胴_蛇D.胴接続(胴_蛇D = new 胴_蛇D());
			}
			胴_蛇D.胴接続(new 尾_ヘD());
			腰D.EnumEleD().SetValuesD("竜性", true);
			腰D.EnumEleD().SetValuesD("竜性", false);
			腰D.EnumEleD().SetValuesD("コア1", true);
			腰D.EnumEleD().SetValuesD("股舌表示", true);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(false));
		}

		public static ChaD Getカッパ()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			頭D.Set耳尖();
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			頭D.頭頂接続(new 頭頂_皿D());
			胸D.背中接続(new 背中_甲D
			{
				縁側角 = OthN.XS.NextDouble()
			});
			足_人D e2 = new 足_人D();
			脚_人D 脚_人D = new 脚_人D();
			脚_人D.足接続(e2);
			腿_人D 腿_人D = new 腿_人D();
			腿_人D.脚接続(脚_人D);
			腰D.腿左接続(腿_人D);
			腰D.腿右接続(腿_人D.Get逆());
			if (OthN.XS.NextBool())
			{
				EleD e3 = new 尾_短D();
				腰D.尾接続(e3);
			}
			腰D.EnumEleD().SetValuesD("腹板", true);
			腰D.EnumEleD().SetValuesD("表示", true);
			腰D.EnumEleD().SetValuesD("表示", true);
			腰D.EnumEleD().SetValuesD("表示", false);
			腰D.EnumEleD().SetValuesD("水掻", true);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(false));
		}

		public static ChaD Getムカデジョウロウ()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口R();
			頭D.Set舌短();
			頭D.Set耳人();
			EleD eleD;
			if (OthN.XS.NextBool())
			{
				eleD = new 虫顎D
				{
					尺度B = 1.1
				};
				頭D.頬左接続(eleD);
				頭D.頬右接続(eleD.Get逆());
			}
			if (OthN.XS.NextBool())
			{
				eleD = new 触覚_節D
				{
					尺度B = 1.4
				};
				頭D.触覚左接続(eleD);
				頭D.触覚右接続(eleD.Get逆());
			}
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			if (OthN.XS.NextBool())
			{
				胸D.肩左接続(肩D.Copy());
				胸D.肩右接続(肩D.Get逆());
				胸D.肩左接続(肩D.Copy());
				胸D.肩右接続(肩D.Get逆());
			}
			長物_蟲D 長物_蟲D = new 長物_蟲D();
			腰D.半身接続(長物_蟲D);
			eleD = new 節足_足百D();
			長物_蟲D.左0接続(eleD);
			長物_蟲D.右0接続(eleD.Get逆());
			長物_蟲D.左1接続(eleD.Copy());
			長物_蟲D.右1接続(eleD.Get逆());
			胴_蟲D 胴_蟲D = new 胴_蟲D();
			長物_蟲D.胴接続(胴_蟲D);
			胴_蟲D.左接続(eleD.Copy());
			胴_蟲D.右接続(eleD.Get逆());
			for (int i = 0; i < 21; i++)
			{
				胴_蟲D.胴接続(胴_蟲D = new 胴_蟲D());
				胴_蟲D.左接続(eleD.Copy());
				胴_蟲D.右接続(eleD.Get逆());
			}
			尾_蟲D 尾_蟲D = new 尾_蟲D();
			節尾_曳航D 節尾_曳航D = new 節尾_曳航D();
			尾_蟲D.左1接続(eleD.Copy());
			尾_蟲D.右1接続(eleD.Get逆());
			尾_蟲D.左2接続(eleD.Copy());
			尾_蟲D.右2接続(eleD.Get逆());
			尾_蟲D.左3接続(eleD.Copy());
			尾_蟲D.右3接続(eleD.Get逆());
			尾_蟲D.左4接続(eleD.Copy());
			尾_蟲D.右4接続(eleD.Get逆());
			尾_蟲D.左5接続(eleD.Copy());
			尾_蟲D.右5接続(eleD.Get逆());
			尾_蟲D.尾左接続(節尾_曳航D);
			尾_蟲D.尾右接続(節尾_曳航D.Get逆());
			胴_蟲D.胴接続(尾_蟲D);
			腰D.EnumEleD().SetValuesD("牙", true);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(OthN.XS.NextBool()));
		}

		public static ChaD Getカ\u30FCバンクル()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R1();
			基髪D eleD = 頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			EleD eleD2 = new 獣耳D
			{
				尺度B = 1.1,
				尺度YB = 1.2
			};
			eleD.頭頂左接続(eleD2);
			eleD.頭頂右接続(eleD2.Get逆());
			腰D.尾接続(new 尾_馬D());
			胸D.背中接続(new 背中_羽D
			{
				毛 = true
			});
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			足_獣D e2 = new 足_獣D();
			脚_獣D 脚_獣D = new 脚_獣D();
			脚_獣D.足接続(e2);
			腿_獣D 腿_獣D = new 腿_獣D();
			腿_獣D.脚接続(脚_獣D);
			腰D.腿左接続(腿_獣D);
			腰D.腿右接続(腿_獣D.Get逆());
			腰D.EnumEleD().SetValuesD("獣性", true);
			腰D.EnumEleD().SetValuesD("秘石", true);
			腰D.EnumEleD().SetValuesD("配色指定", 配色指定.B0);
			腰D.EnumEleD().SetValuesD("配色指定", 配色指定.B0);
			腰D.EnumEleD().SetValuesD("髭", 頭D.鼻_接続.IsEleD<鼻_獣D>());
			腰D.EnumEleD().SetValuesD("牙", true);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(false));
		}

		public static ChaD Getバジリスク()
		{
			腰D 腰D = Uni.腰();
			胴D 胴D = 腰D.Set胴();
			頭D 頭D = 胴D.Set胸R().Set首().Set頭R();
			頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌長();
			頭D.Set耳人();
			頭頂_宇D 頭頂_宇D = new 頭頂_宇D
			{
				鱗 = true
			};
			頭頂_宇D.頭部後接続(new 頭頂後_宇D());
			頭D.頭頂接続(頭頂_宇D);
			頭D.額接続(new 角1_虫D());
			手_鳥D 手_鳥D = new 手_鳥D
			{
				シャ\u30FCプ = OthN.XS.NextDouble()
			};
			下腕_鳥D 下腕_鳥D = new 下腕_鳥D
			{
				シャ\u30FCプ = 手_鳥D.シャ\u30FCプ
			};
			下腕_鳥D.手接続(手_鳥D);
			上腕_鳥D 上腕_鳥D = new 上腕_鳥D
			{
				シャ\u30FCプ = 下腕_鳥D.シャ\u30FCプ
			};
			上腕_鳥D.下腕接続(下腕_鳥D);
			胴D.翼左接続(上腕_鳥D);
			胴D.翼右接続(上腕_鳥D.Get逆());
			長物_蛇D 長物_蛇D = new 長物_蛇D();
			腰D.半身接続(長物_蛇D);
			足_鳥D e = new 足_鳥D
			{
				尺度B = 1.1
			};
			脚_竜D 脚_竜D = new 脚_竜D
			{
				尺度B = 1.1
			};
			脚_竜D.足接続(e);
			四足脇D 四足脇D = new 四足脇D
			{
				尺度B = 1.1
			};
			四足脇D.上腕接続(脚_竜D);
			腰D.翼左接続(四足脇D);
			腰D.翼右接続(四足脇D.Get逆());
			胴_蛇D 胴_蛇D = new 胴_蛇D();
			長物_蛇D.胴接続(胴_蛇D);
			for (int i = 0; i < 30; i++)
			{
				胴_蛇D.胴接続(胴_蛇D = new 胴_蛇D());
			}
			胴_蛇D.胴接続(new 尾_ヘD());
			腰D.EnumEleD().SetValuesD("竜性", true);
			腰D.EnumEleD().SetValuesD("竜性", false);
			腰D.EnumEleD().SetValuesD("牙", true);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(false));
		}

		public static ChaD Getコカトリス()
		{
			腰D 腰D = Uni.腰();
			胴D 胴D = 腰D.Set胴();
			胸D 胸D = 胴D.Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌長();
			頭D.Set耳羽();
			手_蝙D e = new 手_蝙D();
			下腕_蝙D 下腕_蝙D = new 下腕_蝙D();
			下腕_蝙D.手接続(e);
			上腕_蝙D 上腕_蝙D = new 上腕_蝙D();
			上腕_蝙D.下腕接続(下腕_蝙D);
			胴D.翼左接続(上腕_蝙D);
			胴D.翼右接続(上腕_蝙D.Get逆());
			胸D.背中接続(new 背中_羽D
			{
				毛 = true
			});
			長物_蛇D 長物_蛇D = new 長物_蛇D();
			腰D.半身接続(長物_蛇D);
			足_鳥D e2 = new 足_鳥D
			{
				尺度B = 1.1
			};
			脚_竜D 脚_竜D = new 脚_竜D
			{
				尺度B = 1.1
			};
			脚_竜D.足接続(e2);
			四足脇D 四足脇D = new 四足脇D
			{
				尺度B = 1.1
			};
			四足脇D.上腕接続(脚_竜D);
			腰D.翼左接続(四足脇D);
			腰D.翼右接続(四足脇D.Get逆());
			胴_蛇D 胴_蛇D = new 胴_蛇D();
			長物_蛇D.胴接続(胴_蛇D);
			for (int i = 0; i < 30; i++)
			{
				胴_蛇D.胴接続(胴_蛇D = new 胴_蛇D());
			}
			胴_蛇D.胴接続(new 尾_ヘD());
			腰D.EnumEleD().SetValuesD("獣性", true);
			腰D.EnumEleD().SetValuesD("竜性", true);
			腰D.EnumEleD().SetValuesD("竜性", false);
			腰D.EnumEleD().SetValuesD("髭", false);
			腰D.EnumEleD().SetValuesD("牙", true);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(false));
		}

		public static ChaD Getカトブレパス()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			基髪D eleD = 頭D.EnumEleD().GetEleD<基髪D>();
			eleD.前髪_接続.RemoveAt(0);
			eleD.前髪接続(new 前髪_目隠れ1D());
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			頭D.Set耳獣();
			頭D.額接続(Con.Get縦眼R());
			EleD eleD2 = new 角2_牛2D();
			eleD.頭頂左接続(eleD2);
			eleD.頭頂右接続(eleD2.Get逆());
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			四足胸D 四足胸D = Uni.四足胸();
			腰D.半身接続(四足胸D);
			四足胴D 四足胴D = Uni.四足胴();
			四足胸D.胴接続(四足胴D);
			四足腰D 四足腰D = Uni.四足腰();
			四足胴D.腰接続(四足腰D);
			手_牛D e2 = new 手_牛D();
			下腕_蹄D 下腕_蹄D = new 下腕_蹄D();
			下腕_蹄D.手接続(e2);
			上腕_蹄D 上腕_蹄D = new 上腕_蹄D();
			上腕_蹄D.下腕接続(下腕_蹄D);
			四足脇D 四足脇D = new 四足脇D();
			四足脇D.上腕接続(上腕_蹄D);
			四足胸D.脇左接続(四足脇D);
			四足胸D.脇右接続(四足脇D.Get逆());
			足_牛D e3 = new 足_牛D();
			脚_蹄D 脚_蹄D = new 脚_蹄D();
			脚_蹄D.足接続(e3);
			腿_蹄D 腿_蹄D = new 腿_蹄D();
			腿_蹄D.脚接続(脚_蹄D);
			四足腰D.腿左接続(腿_蹄D);
			四足腰D.腿右接続(腿_蹄D.Get逆());
			四足腰D.尾接続(new 尾_牛D());
			腰D.EnumEleD().SetValuesD("獣性", true);
			腰D.EnumEleD().SetValuesD("髭", false);
			腰D.EnumEleD().SetValuesD("猫目", true);
			腰D.EnumEleD().SetValuesD("表示", false);
			腰D.EnumEleD().SetValuesD("表示", false);
			腰D.EnumEleD().SetValuesD("肉球", false);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(false));
		}

		public static ChaD Getミノタウロス()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			基髪D eleD = 頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			頭D.Set耳獣();
			EleD eleD2;
			switch (OthN.XS.Next(4))
			{
			case 0:
				eleD2 = new 角2_牛1D();
				break;
			case 1:
				eleD2 = new 角2_牛2D();
				break;
			case 2:
				eleD2 = new 角2_牛3D();
				break;
			default:
				eleD2 = new 角2_牛4D();
				break;
			}
			eleD.頭頂左接続(eleD2);
			eleD.頭頂右接続(eleD2.Get逆());
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			足_人D e2 = new 足_人D();
			脚_人D 脚_人D = new 脚_人D();
			脚_人D.足接続(e2);
			腿_人D 腿_人D = new 腿_人D();
			腿_人D.脚接続(脚_人D);
			腰D.腿左接続(腿_人D);
			腰D.腿右接続(腿_人D.Get逆());
			腰D.尾接続(new 尾_牛D());
			腰D.EnumEleD().SetValuesD("獣性", true);
			腰D.EnumEleD().SetValuesD("髭", false);
			腰D.EnumEleD().SetValuesD("肉球", false);
			腰D.EnumEleD().SetValuesD("獣毛2", false);
			腰D.EnumEleD().SetValuesD("配色指定", 配色指定.B0);
			腰D.EnumEleD().SetValuesD("配色指定", 配色指定.B0);
			腰D.EnumEleD().SetValuesD("配色指定", 配色指定.B0);
			腰D.EnumEleD().SetValuesD("バスト", 1.0);
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(OthN.XS.NextBool()));
		}

		public static ChaD Getリリン()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			頭D.Set耳人();
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			足_人D e2 = new 足_人D();
			脚_人D 脚_人D = new 脚_人D();
			脚_人D.足接続(e2);
			腿_人D 腿_人D = new 腿_人D();
			腿_人D.脚接続(脚_人D);
			腰D.腿左接続(腿_人D);
			腰D.腿右接続(腿_人D.Get逆());
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 頭D.目高);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(OthN.XS.NextBool()));
		}

		public static ChaD Getエルフ()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			頭D.Set耳長();
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			足_人D e2 = new 足_人D();
			脚_人D 脚_人D = new 脚_人D();
			脚_人D.足接続(e2);
			腿_人D 腿_人D = new 腿_人D();
			腿_人D.脚接続(脚_人D);
			腰D.腿左接続(腿_人D);
			腰D.腿右接続(腿_人D.Get逆());
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", 1.0);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(true));
		}

		public static ChaD Getドワ\u30FCフ()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			頭D.Set耳尖();
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			足_人D e2 = new 足_人D();
			脚_人D 脚_人D = new 脚_人D();
			脚_人D.足接続(e2);
			腿_人D 腿_人D = new 腿_人D();
			腿_人D.脚接続(脚_人D);
			腰D.腿左接続(腿_人D);
			腰D.腿右接続(腿_人D.Get逆());
			腰D.EnumEleD().SetValuesD("肥大", 1.0);
			腰D.EnumEleD().SetValuesD("身長", 0.0);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.2 + OthN.XS.NextDouble(0.8));
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(true));
		}

		public static ChaD Getヴィオラ()
		{
			腰D 腰D = Uni.腰();
			胴D 胴D = 腰D.Set胴();
			胸D 胸D = 胴D.Set胸R();
			首D 首D = 胸D.Set首();
			頭D 頭D = Uni.頭();
			首D.頭接続(頭D);
			頭D.目高 = 0.85;
			基髪D 基髪D = (基髪D)頭D.基髪_接続[0];
			後髪0_カルD e = new 後髪0_カルD
			{
				髪長0 = 1.0,
				髪長1 = 1.0,
				毛量 = 1.0,
				広がり = 1.0
			};
			基髪D.後髪接続(e);
			横髪_カルD 横髪_カルD = new 横髪_カルD
			{
				髪長1 = 1.0,
				髪長2 = 1.0,
				毛量 = 1.0,
				広がり = 1.0
			};
			基髪D.横髪左接続(横髪_カルD);
			基髪D.横髪右接続(横髪_カルD.Get逆());
			基髪D.前髪接続(new 前髪_目隠れ2D
			{
				髪長 = 1.0,
				髪ハネ左_表示 = false,
				髪ハネ右_表示 = false,
				編み左表示 = false,
				編み右表示 = false
			});
			双目D 双目D = Uni.魔中目(false);
			瞼_中D 瞼_中D = (瞼_中D)双目D.瞼_接続[0];
			瞼_中D.サイズ = 0.5;
			瞼_中D.サイズX = 0.8;
			瞼_中D.サイズY = 0.5;
			瞼_中D.外線 = 0.5;
			瞼_中D.睫毛_睫毛3_長さ = 0.5;
			瞼_中D.睫毛_睫毛4_長さ = 0.5;
			瞼_中D.睫毛_睫毛1_長さ = 0.5;
			瞼_中D.睫毛_睫毛2_長さ = 0.5;
			瞼_中D.傾き = 0.8;
			頭D.目左接続(双目D);
			頭D.目右接続(双目D.Get逆());
			眉D 眉D = new 眉D
			{
				サイズY = 0.4
			};
			頭D.眉左接続(眉D);
			頭D.眉右接続(眉D.Get逆());
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			頭D.Set耳尖();
			手_人D e2 = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e2);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			EleD eleD = new 角2_牛4D();
			基髪D.頭頂左接続(eleD);
			基髪D.頭頂右接続(eleD.Get逆());
			植D 植D = new 植D();
			花_薔D 花_薔D = new 花_薔D();
			植D.花接続(花_薔D);
			花_薔D.SetValuesD("表示", false);
			花_薔D.萼_萼_表示 = true;
			花_薔D.表示 = true;
			bool flag = true;
			植D.披針葉1_葉_表示 = flag;
			植D.披針葉1_葉脈_表示 = flag;
			植D.披針葉2_葉_表示 = flag;
			植D.披針葉2_葉脈_表示 = flag;
			植D.披針葉3_葉_表示 = flag;
			植D.披針葉3_葉脈_表示 = flag;
			植D.披針葉4_葉_表示 = flag;
			植D.披針葉4_葉脈_表示 = flag;
			植D.心臓葉1_葉_表示 = !flag;
			植D.心臓葉1_葉脈_表示 = !flag;
			植D.心臓葉2_葉_表示 = !flag;
			植D.心臓葉2_葉脈_表示 = !flag;
			植D.心臓葉3_葉_表示 = !flag;
			植D.心臓葉3_葉脈_表示 = !flag;
			植D.心臓葉4_葉_表示 = !flag;
			植D.心臓葉4_葉脈_表示 = !flag;
			基髪D.頭頂左接続(植D);
			基髪D.頭頂右接続(植D.Get逆());
			手_蝙D e3 = new 手_蝙D
			{
				シャ\u30FCプ = 1.0
			};
			下腕_蝙D 下腕_蝙D = new 下腕_蝙D();
			下腕_蝙D.手接続(e3);
			上腕_蝙D 上腕_蝙D = new 上腕_蝙D();
			上腕_蝙D.下腕接続(下腕_蝙D);
			胸D.翼上左接続(上腕_蝙D);
			胸D.翼上右接続(上腕_蝙D.Get逆());
			触手_蔦D 触手_蔦D = new 触手_蔦D();
			触手_蔦D.先端表示 = true;
			触手_蔦D.SetValuesD("棘", true);
			EleD eleD2 = new 葉_披D();
			eleD2.尺度B *= 1.25;
			触手_蔦D.節3接続(eleD2 = eleD2.Copy());
			eleD2.尺度B *= 原種.葉倍率;
			触手_蔦D.節5接続(eleD2 = eleD2.Copy());
			eleD2.尺度B *= 原種.葉倍率;
			触手_蔦D.節7接続(eleD2 = eleD2.Copy());
			eleD2.尺度B *= 原種.葉倍率;
			触手_蔦D.節9接続(eleD2 = eleD2.Copy());
			eleD2.尺度B *= 原種.葉倍率;
			触手_蔦D.節11接続(eleD2 = eleD2.Copy());
			eleD2.尺度B *= 原種.葉倍率;
			触手_蔦D.節13接続(eleD2 = eleD2.Copy());
			eleD2.尺度B *= 原種.葉倍率;
			触手_蔦D.節15接続(eleD2 = eleD2.Copy());
			eleD2.尺度B *= 原種.葉倍率;
			触手_蔦D.節17接続(eleD2 = eleD2.Copy());
			eleD2.尺度B *= 原種.葉倍率;
			触手_蔦D.節19接続(eleD2 = eleD2.Copy());
			eleD2.尺度B *= 原種.葉倍率;
			EleD eleD3 = 触手_蔦D.Copy();
			胴D.翼左接続(触手_蔦D);
			胴D.翼右接続(触手_蔦D.Get逆());
			腰D.翼左接続(eleD3);
			腰D.翼右接続(eleD3.Get逆());
			足_人D e4 = new 足_人D();
			脚_人D 脚_人D = new 脚_人D();
			脚_人D.足接続(e4);
			腿_人D 腿_人D = new 腿_人D();
			腿_人D.脚接続(脚_人D);
			腰D.腿左接続(腿_人D);
			腰D.腿右接続(腿_人D.Get逆());
			腰D.EnumEleD().SetValuesD("陰毛", true);
			腰D.EnumEleD().SetValuesD("植", true);
			腰D.EnumEleD().SetValuesD("淫", true);
			腰D.EnumEleD().SetValuesD("植タトゥ", false);
			腰D.EnumEleD().SetValuesD("植タトゥ", false);
			腰D.EnumEleD().SetValuesD("淫", false);
			腰D.EnumEleD().SetValuesD("ハート", false);
			腰D.EnumEleD().SetValuesD("ハート", false);
			腰D.EnumEleD().SetValuesD("隈取", true);
			腰D.EnumEleD().SetValuesD("悪", true);
			腰D.EnumEleD().SetValuesD("悪", true);
			腰D.EnumEleD().SetValuesD("葉1", false);
			腰D.EnumEleD().SetValuesD("猫目", true);
			腰D.EnumEleD().SetValuesD("バスト", 0.85);
			腰D.EnumEleD().SetValuesD("肥大", 0.3);
			腰D.EnumEleD().SetValuesD("身長", 0.9);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.6);
			ChaD chaD = new ChaD(腰D, new 体色(false)
			{
				髪 = Color.FromArgb(255, 239, 241, 194).Add(0, 128, 0),
				眉 = Color.FromArgb(255, 239, 241, 194).Add(0, 128, 0),
				毛0 = Color.DarkGreen,
				体1 = Color.Violet,
				植0 = Color.DarkGreen.Add(0, 0, -50),
				植1 = Color.DarkGreen,
				人肌 = Color.FromArgb(255, 121, 200, 162),
				目左 = Color.LightPink,
				目右 = Color.LightPink,
				白部 = Color.FromArgb(255, 238, 248, 238),
				膜 = Color.Purple,
				刺青 = Color.FromArgb(255, 134, 0, 62),
				口紅 = Color.FromArgb(255, 134, 0, 62)
			});
			chaD.Setヴィオラ();
			腰D.尺度調整(頭D);
			return chaD;
		}

		public static ChaD Getサダヨミ()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			首D 首D = 胸D.Set首();
			頭D 頭D = Uni.頭();
			首D.頭接続(頭D);
			頭D.目高 = 0.9;
			基髪D 基髪D = (基髪D)頭D.基髪_接続[0];
			後髪0_パツD e = new 後髪0_パツD
			{
				髪長0 = 0.5,
				髪長1 = 0.75,
				毛量 = 0.5,
				広がり = 0.3
			};
			基髪D.後髪接続(e);
			横髪_ジグD 横髪_ジグD = new 横髪_ジグD
			{
				髪長1 = 1.0,
				髪長2 = 1.0,
				毛量 = 0.5,
				広がり = 0.0
			};
			基髪D.横髪左接続(横髪_ジグD);
			基髪D.横髪右接続(横髪_ジグD.Get逆());
			基髪D.前髪接続(new 前髪_中分け2D
			{
				髪長 = 0.5,
				髪ハネ左_表示 = false,
				髪ハネ右_表示 = false,
				編み左表示 = false,
				編み右表示 = false
			});
			眉D 眉D = new 眉D
			{
				サイズY = 0.3
			};
			頭D.眉左接続(眉D);
			頭D.眉右接続(眉D.Get逆());
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			頭D.Set耳人();
			縦目D 縦目D = Uni.縦目();
			縦瞼D 縦瞼D = (縦瞼D)縦目D.瞼_接続[0];
			縦瞼D.サイズX = 0.5;
			縦瞼D.瞼左_睫毛1_表示 = true;
			縦瞼D.瞼左_睫毛2_表示 = true;
			縦瞼D.瞼右_睫毛1_表示 = 縦瞼D.瞼左_睫毛1_表示;
			縦瞼D.瞼右_睫毛2_表示 = 縦瞼D.瞼左_睫毛2_表示;
			縦瞼D.外線 = 0.5;
			縦瞼D.瞼左_睫毛1_長さ = 0.5;
			縦瞼D.瞼左_睫毛2_長さ = 0.9;
			縦瞼D.瞼右_睫毛1_長さ = 縦瞼D.瞼左_睫毛1_長さ;
			縦瞼D.瞼右_睫毛2_長さ = 縦瞼D.瞼左_睫毛2_長さ;
			頭D.額接続(縦目D);
			頬目D 頬目D = Uni.頬目(false);
			頬瞼D 頬瞼D = (頬瞼D)頬目D.瞼_接続[0];
			頬瞼D.サイズY = 0.5;
			頬瞼D.瞼左_睫毛1_表示 = true;
			頬瞼D.瞼左_睫毛2_表示 = true;
			頬瞼D.瞼右_睫毛1_表示 = true;
			頬瞼D.瞼右_睫毛2_表示 = true;
			頬瞼D.外線 = 0.5;
			頬瞼D.瞼左_睫毛1_長さ = 0.5;
			頬瞼D.瞼左_睫毛2_長さ = 0.9;
			頬瞼D.瞼右_睫毛1_長さ = 0.5;
			頬瞼D.瞼右_睫毛2_長さ = 0.9;
			頬瞼D.傾き = 0.5;
			頭D.頬肌左接続(頬目D);
			頭D.頬肌右接続(頬目D.Get逆());
			手_人D e2 = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e2);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			胸D.肩左接続(肩D.Copy());
			胸D.肩右接続(肩D.Get逆());
			胸D.肩左接続(肩D.Copy());
			胸D.肩右接続(肩D.Get逆());
			足_人D e3 = new 足_人D();
			脚_人D 脚_人D = new 脚_人D();
			脚_人D.足接続(e3);
			腿_人D 腿_人D = new 腿_人D();
			腿_人D.脚接続(脚_人D);
			腰D.腿左接続(腿_人D);
			腰D.腿右接続(腿_人D.Get逆());
			腰D.EnumEleD().SetValuesD("陰毛", true);
			腰D.EnumEleD().SetValuesD("バスト", 0.65);
			腰D.EnumEleD().SetValuesD("肥大", 0.3);
			腰D.EnumEleD().SetValuesD("身長", 0.7);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.0);
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(false)
			{
				髪 = Color.FromArgb(255, 87, 100, 158),
				眉 = Color.FromArgb(255, 87, 100, 158),
				毛0 = Color.FromArgb(255, 87, 100, 158),
				人肌 = Color.FromArgb(255, 121, 168, 200).Add(0, -100, 35),
				爪 = Color.FromArgb(255, 121, 168, 200).Add(0, -100, 35),
				粘膜 = Color.Red,
				口紅 = Color.DarkRed,
				目左 = Color.FromArgb(255, 250, 114, 111),
				目右 = Color.FromArgb(255, 250, 114, 111),
				縦目 = Color.FromArgb(255, 250, 114, 111),
				頬目左 = Color.FromArgb(255, 250, 114, 111),
				頬目右 = Color.FromArgb(255, 250, 114, 111),
				白部 = Color.FromArgb(255, 252, 50, 201)
			});
		}

		public static ChaD Getメアリ\u30FC()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			首D 首D = 胸D.Set首();
			頭D 頭D = Uni.頭();
			首D.頭接続(頭D);
			頭D.目高 = 0.5;
			基髪D 基髪D = (基髪D)頭D.基髪_接続[0];
			後髪0_ジグD e = new 後髪0_ジグD
			{
				髪長0 = 0.1,
				髪長1 = 0.2,
				毛量 = 0.5,
				広がり = 0.0
			};
			基髪D.後髪接続(e);
			横髪_ジグD 横髪_ジグD = new 横髪_ジグD
			{
				髪長1 = 1.0,
				髪長2 = 1.0,
				毛量 = 0.5,
				広がり = 0.0
			};
			基髪D.横髪左接続(横髪_ジグD);
			基髪D.横髪右接続(横髪_ジグD.Get逆());
			基髪D.前髪接続(new 前髪_ジグ分けD
			{
				髪長 = 0.5,
				髪ハネ左_表示 = true,
				髪ハネ右_表示 = true,
				編み左表示 = true,
				編み右表示 = true,
				髪頭頂横左1_表示 = false,
				髪頭頂横左2_表示 = false,
				髪頭頂横右1_表示 = false,
				髪頭頂横右2_表示 = false,
				サイズ = 0.8
			});
			双目D 双目D = Uni.獣性目(false);
			瞼_獣D 瞼_獣D = (瞼_獣D)双目D.瞼_接続[0];
			瞼_獣D.サイズ = 0.5;
			瞼_獣D.サイズX = 0.5;
			瞼_獣D.サイズY = 0.5;
			瞼_獣D.外線 = 0.5;
			瞼_獣D.睫毛_睫毛3_長さ = 0.5;
			瞼_獣D.睫毛_睫毛1_長さ = 0.5;
			瞼_獣D.睫毛_睫毛2_長さ = 0.5;
			瞼_獣D.傾き = 0.5;
			頭D.目左接続(双目D);
			頭D.目右接続(双目D.Get逆());
			眉D 眉D = new 眉D
			{
				サイズY = 0.5
			};
			頭D.眉左接続(眉D);
			頭D.眉右接続(眉D.Get逆());
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			頭D.Set耳長();
			EleD eleD = new 角2_牛1D();
			基髪D.頭頂左接続(eleD);
			基髪D.頭頂右接続(eleD.Get逆());
			手_人D e2 = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e2);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			足_人D e3 = new 足_人D
			{
				サイズ = 0.45
			};
			脚_人D 脚_人D = new 脚_人D();
			脚_人D.足接続(e3);
			腿_人D 腿_人D = new 腿_人D();
			腿_人D.脚接続(脚_人D);
			腰D.腿左接続(腿_人D);
			腰D.腿右接続(腿_人D.Get逆());
			腰D.尾接続(new 尾_淫D());
			腰D.EnumEleD().SetValuesD("牙", true);
			腰D.EnumEleD().SetValuesD("手首_ハート", true);
			腰D.EnumEleD().SetValuesD("手首_タトゥ", true);
			腰D.EnumEleD().SetValuesD("陰毛", true);
			腰D.EnumEleD().SetValuesD("バスト", 0.1);
			腰D.EnumEleD().SetValuesD("肥大", 0.1);
			腰D.EnumEleD().SetValuesD("身長", 0.6);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.4);
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(false)
			{
				髪 = Color.Orange,
				眉 = Color.Orange,
				毛0 = Color.Orange,
				体0 = Color.FromArgb(255, 255, 150, 106),
				人肌 = Color.FromArgb(255, 255, 207, 169),
				爪 = Col.White,
				目左 = Color.Gold,
				目右 = Color.Gold,
				白部 = Col.White,
				刺青 = Color.DeepPink
			});
		}

		public static ChaD Getヒュ\u30FCマン()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set双目R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			頭D.Set耳人();
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			足_人D e2 = new 足_人D();
			脚_人D 脚_人D = new 脚_人D();
			脚_人D.足接続(e2);
			腿_人D 腿_人D = new 腿_人D();
			腿_人D.脚接続(脚_人D);
			腰D.腿左接続(腿_人D);
			腰D.腿右接続(腿_人D.Get逆());
			腰D.EnumEleD().SetValuesD("肥大", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("身長", OthN.XS.NextDouble());
			腰D.EnumEleD().SetValuesD("鋭爪", 0.0);
			腰D.Set下毛();
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(true));
		}

		public static ChaD Getプレ\u30FCヤ\u30FC()
		{
			腰D 腰D = Uni.腰();
			胸D 胸D = 腰D.Set胴().Set胸R();
			頭D 頭D = 胸D.Set首().Set頭R();
			頭D.EnumEleD().GetEleD<基髪D>();
			頭D.Set目弱R();
			頭D.Set鼻人();
			頭D.Set口人();
			頭D.Set舌短();
			頭D.Set耳人();
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D = new 下腕_人D();
			下腕_人D.手接続(e);
			上腕_人D 上腕_人D = new 上腕_人D();
			上腕_人D.下腕接続(下腕_人D);
			肩D 肩D = new 肩D();
			肩D.上腕接続(上腕_人D);
			胸D.肩左接続(肩D);
			胸D.肩右接続(肩D.Get逆());
			足_人D e2 = new 足_人D();
			脚_人D 脚_人D = new 脚_人D();
			脚_人D.足接続(e2);
			腿_人D 腿_人D = new 腿_人D();
			腿_人D.脚接続(脚_人D);
			腰D.腿左接続(腿_人D);
			腰D.腿右接続(腿_人D.Get逆());
			腰D.EnumEleD().SetValuesD("肥大", Sta.GameData.体重);
			腰D.EnumEleD().SetValuesD("身長", Sta.GameData.身長);
			腰D.EnumEleD().SetValuesD("鋭爪", 0.0);
			腰D.肌_接続.GetEleD<腰肌D>().陰毛_表示 = true;
			腰D.尺度調整(頭D);
			return new ChaD(腰D, new 体色(true)
			{
				目左 = Sta.GameData.色.瞳色,
				目右 = Sta.GameData.色.瞳色,
				縦目 = Sta.GameData.色.瞳色,
				頬目左 = Sta.GameData.色.瞳色,
				頬目右 = Sta.GameData.色.瞳色,
				髪 = Sta.GameData.色.髪色,
				眉 = Sta.GameData.色.髪色,
				毛0 = Sta.GameData.色.髪色,
				睫 = Sta.GameData.色.髪色,
				人肌 = Sta.GameData.色.肌色,
				爪 = Color.PapayaWhip
			});
		}

		public static double 葉倍率 = 0.8;
	}
}
