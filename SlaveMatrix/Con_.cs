using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public static class Con
	{
		public static 腰D Get胴体R()
		{
			頭D e = Con.Get頭R();
			首D 首D = new 首D();
			首D.頭接続(e);
			胸D 胸D = Con.Get胸R();
			胸D.首接続(首D);
			胴D 胴D = Uni.胴();
			胴D.胸接続(胸D);
			腰D 腰D = Uni.腰();
			腰D.胴接続(胴D);
			return 腰D;
		}

		public static 胸D Get胸R()
		{
			胸D 胸D = Uni.胸();
			double num = OthN.XS.NextDouble();
			胸D.EnumEleD().SetValuesD("バスト", num);
			return 胸D;
		}

		public static 頭D Get頭R()
		{
			頭D 頭D = Uni.頭().SetRandom();
			基髪D 基髪D = (基髪D)頭D.基髪_接続[0];
			EleD eleD = Con.Get後髪0R();
			基髪D.後髪接続(eleD);
			if ((eleD is 後髪0_ジグD || eleD is 後髪0_ハネD || eleD is 後髪0_パツD || eleD is 後髪0_カルD || eleD is 後髪0_肢系D) && OthN.XS.NextBool())
			{
				基髪D.後髪接続(Con.Get後髪1R());
			}
			eleD = Con.Get横髪R(false);
			基髪D.横髪左接続(eleD);
			基髪D.横髪右接続(eleD.Get逆());
			基髪D.前髪接続(Con.Get前髪R());
			return 頭D;
		}

		public static 頭D Get頭R1()
		{
			頭D 頭D = Uni.頭().SetRandom();
			基髪D 基髪D = (基髪D)頭D.基髪_接続[0];
			EleD eleD = Con.Get後髪0R();
			基髪D.後髪接続(eleD);
			if ((eleD is 後髪0_ジグD || eleD is 後髪0_ハネD || eleD is 後髪0_パツD || eleD is 後髪0_カルD || eleD is 後髪0_肢系D) && OthN.XS.NextBool())
			{
				基髪D.後髪接続(Con.Get後髪1R());
			}
			eleD = Con.Get横髪R(false);
			基髪D.横髪左接続(eleD);
			基髪D.横髪右接続(eleD.Get逆());
			基髪D.前髪接続(Con.Get前髪R1());
			return 頭D;
		}

		public static 双目D Get双眼R(bool 右)
		{
			switch (OthN.XS.NextM(3))
			{
			case 0:
			{
				双目D 双目D = Uni.魔弱目(右);
				((瞼_弱D)双目D.瞼_接続[0]).SetRandom();
				return 双目D;
			}
			case 1:
			{
				双目D 双目D2 = Uni.魔中目(右);
				((瞼_中D)双目D2.瞼_接続[0]).SetRandom();
				return 双目D2;
			}
			case 2:
			{
				双目D 双目D3 = Uni.魔強目(右);
				((瞼_強D)双目D3.瞼_接続[0]).SetRandom();
				return 双目D3;
			}
			case 3:
			{
				双目D 双目D4 = Uni.獣性目(右);
				((瞼_獣D)双目D4.瞼_接続[0]).SetRandom();
				return 双目D4;
			}
			default:
			{
				双目D 双目D5 = Uni.宇宙目(右);
				((瞼_宇D)双目D5.瞼_接続[0]).SetRandom();
				return 双目D5;
			}
			}
		}

		public static 眉D Get眉R(bool 右)
		{
			return new 眉D
			{
				右 = 右
			}.SetRandom();
		}

		public static 単目D Get単眼R()
		{
			単目D 単目D = Uni.単眼目();
			((単瞼D)単目D.瞼_接続[0]).SetRandom();
			return 単目D;
		}

		public static 単眼眉D Get単眼眉R()
		{
			return new 単眼眉D().SetRandom();
		}

		public static 縦目D Get縦眼R()
		{
			縦目D 縦目D = Uni.縦目();
			((縦瞼D)縦目D.瞼_接続[0]).SetRandom();
			return 縦目D;
		}

		public static 頬目D Get頬眼R(bool 右)
		{
			頬目D 頬目D = Uni.頬目(右);
			((頬瞼D)頬目D.瞼_接続[0]).SetRandom();
			return 頬目D;
		}

		public static EleD Get鼻R()
		{
			if (OthN.XS.NextM(1) == 0)
			{
				return Uni.人鼻D();
			}
			return Uni.獣鼻D();
		}

		public static EleD[] Get口R()
		{
			if (OthN.XS.NextM(1) == 0)
			{
				return Uni.人口D();
			}
			return Uni.裂口D();
		}

		public static EleD Get舌R()
		{
			if (OthN.XS.NextM(1) == 0)
			{
				return new 舌_短D();
			}
			return new 舌_長D();
		}

		public static EleD Get耳R(bool 右)
		{
			switch (OthN.XS.NextM(5))
			{
			case 0:
				return new 耳_人D
				{
					右 = 右
				};
			case 1:
				return new 耳_尖D
				{
					右 = 右
				};
			case 2:
				return new 耳_長D
				{
					右 = 右
				};
			case 3:
				return new 耳_鰭D
				{
					右 = 右
				};
			case 4:
				return new 耳_羽D
				{
					右 = 右
				};
			default:
				return new 耳_獣D
				{
					右 = 右
				};
			}
		}

		public static EleD Get後髪0R()
		{
			switch (OthN.XS.NextM(20))
			{
			case 0:
				return new 後髪0_ジグD().SetRandom();
			case 1:
				return new 後髪0_ハネD().SetRandom();
			case 2:
				return new 後髪0_パツD().SetRandom();
			case 3:
				return new 後髪0_カルD().SetRandom();
			case 4:
				return new 後髪0_肢系D().SetRandom();
			case 5:
				return new 後髪0_編1ジグD().SetRandom();
			case 6:
				return new 後髪0_編1ハネD().SetRandom();
			case 7:
				return new 後髪0_編1パツD().SetRandom();
			case 8:
				return new 後髪0_編1カルD().SetRandom();
			case 9:
				return new 後髪0_下1ジグD().SetRandom();
			case 10:
				return new 後髪0_下1ハネD().SetRandom();
			case 11:
				return new 後髪0_下1パツD().SetRandom();
			case 12:
				return new 後髪0_下1カルD().SetRandom();
			case 13:
				return new 後髪0_編2ジグD().SetRandom();
			case 14:
				return new 後髪0_編2ハネD().SetRandom();
			case 15:
				return new 後髪0_編2パツD().SetRandom();
			case 16:
				return new 後髪0_編2カルD().SetRandom();
			case 17:
				return new 後髪0_下2ジグD().SetRandom();
			case 18:
				return new 後髪0_下2ハネD().SetRandom();
			case 19:
				return new 後髪0_下2パツD().SetRandom();
			default:
				return new 後髪0_下2カルD().SetRandom();
			}
		}

		public static EleD Get後髪1R()
		{
			switch (OthN.XS.NextM(8))
			{
			case 0:
				return new 後髪1_結1ジグD().SetRandom();
			case 1:
				return new 後髪1_結1ハネD().SetRandom();
			case 2:
				return new 後髪1_結1パツD().SetRandom();
			case 3:
				return new 後髪1_結1カルD().SetRandom();
			case 4:
				return new 後髪1_編結D().SetRandom();
			case 5:
				return new 後髪1_結2ジグD().SetRandom();
			case 6:
				return new 後髪1_結2ハネD().SetRandom();
			case 7:
				return new 後髪1_結2パツD().SetRandom();
			default:
				return new 後髪1_結2カルD().SetRandom();
			}
		}

		public static EleD Get横髪R(bool 右)
		{
			switch (OthN.XS.NextM(5))
			{
			case 0:
				return new 横髪_ジグD
				{
					右 = 右
				}.SetRandom();
			case 1:
				return new 横髪_ハネD
				{
					右 = 右
				}.SetRandom();
			case 2:
				return new 横髪_パツD
				{
					右 = 右
				}.SetRandom();
			case 3:
				return new 横髪_カルD
				{
					右 = 右
				}.SetRandom();
			case 4:
				return new 横髪_編みD
				{
					右 = 右
				}.SetRandom();
			default:
				return new 横髪_肢系D
				{
					右 = 右
				};
			}
		}

		public static EleD Get前髪R()
		{
			switch (OthN.XS.NextM(18))
			{
			case 0:
				return new 前髪_ジグD().SetRandom();
			case 1:
				return new 前髪_ジグ中寄D().SetRandom();
			case 2:
				return new 前髪_ジグ分けD().SetRandom();
			case 3:
				return new 前髪_モジャD().SetRandom();
			case 4:
				return new 前髪_パッツンD().SetRandom();
			case 5:
				return new 前髪_横流しD().SetRandom();
			case 6:
				return new 前髪_二分1D().SetRandom();
			case 7:
				return new 前髪_三分1D().SetRandom();
			case 8:
				return new 前髪_二分2D().SetRandom();
			case 9:
				return new 前髪_三分2D().SetRandom();
			case 10:
				return new 前髪_中分け1D().SetRandom();
			case 11:
				return new 前髪_中分け2D().SetRandom();
			case 12:
				return new 前髪_上げ短1D().SetRandom();
			case 13:
				return new 前髪_上げ短2D().SetRandom();
			case 14:
				return new 前髪_上げ長1D().SetRandom();
			case 15:
				return new 前髪_上げ長2D().SetRandom();
			case 16:
				return new 前髪_上げ片D().SetRandom();
			case 17:
				return new 前髪_目隠れ1D().SetRandom();
			default:
				return new 前髪_目隠れ2D().SetRandom();
			}
		}

		public static EleD Get前髪R1()
		{
			switch (OthN.XS.NextM(12))
			{
			case 0:
				return new 前髪_ジグ分けD().SetRandom();
			case 1:
				return new 前髪_横流しD().SetRandom();
			case 2:
				return new 前髪_二分1D().SetRandom();
			case 3:
				return new 前髪_二分2D().SetRandom();
			case 4:
				return new 前髪_中分け1D().SetRandom();
			case 5:
				return new 前髪_中分け2D().SetRandom();
			case 6:
				return new 前髪_上げ短1D().SetRandom();
			case 7:
				return new 前髪_上げ短2D().SetRandom();
			case 8:
				return new 前髪_上げ長1D().SetRandom();
			case 9:
				return new 前髪_上げ長2D().SetRandom();
			case 10:
				return new 前髪_上げ片D().SetRandom();
			default:
				return new 前髪_目隠れ2D().SetRandom();
			}
		}

		public static EleD Get角1R()
		{
			int num = OthN.XS.NextM(2);
			if (num == 0)
			{
				return new 角1_一D();
			}
			if (num != 1)
			{
				return new 角1_虫D();
			}
			return new 角1_鬼D();
		}

		public static EleD Get角2R(bool 右)
		{
			switch (OthN.XS.NextM(9))
			{
			case 0:
				return new 角2_山1D
				{
					右 = 右
				};
			case 1:
				return new 角2_山2D
				{
					右 = 右
				};
			case 2:
				return new 角2_山3D
				{
					右 = 右
				};
			case 3:
				return new 角2_巻D
				{
					右 = 右
				};
			case 4:
				return new 角2_牛1D
				{
					右 = 右
				};
			case 5:
				return new 角2_牛2D
				{
					右 = 右
				};
			case 6:
				return new 角2_牛3D
				{
					右 = 右
				};
			case 7:
				return new 角2_牛4D
				{
					右 = 右
				};
			case 8:
				return new 角2_鬼D
				{
					右 = 右
				};
			default:
				return new 角2_虫D
				{
					右 = 右
				};
			}
		}

		public static EleD Get花R(bool 右)
		{
			if (OthN.XS.NextM(1) == 0)
			{
				return new 花_薔D
				{
					右 = 右
				};
			}
			return new 花_百D
			{
				右 = 右
			};
		}

		public static EleD Get顔面R()
		{
			int num = OthN.XS.NextM(2);
			if (num == 0)
			{
				return new 顔面_甲D();
			}
			if (num != 1)
			{
				return new 顔面_蟲D();
			}
			return new 顔面_虫D();
		}

		public static EleD Get頭頂R()
		{
			int num = OthN.XS.NextM(2);
			if (num == 0)
			{
				頭頂_宇D 頭頂_宇D = new 頭頂_宇D();
				頭頂_宇D.頭部後接続(new 頭頂後_宇D());
				return 頭頂_宇D;
			}
			if (num != 1)
			{
				return new 頭頂_天D();
			}
			return new 頭頂_皿D();
		}

		public static EleD Get背中R()
		{
			int num = OthN.XS.NextM(2);
			if (num == 0)
			{
				return new 背中_羽D();
			}
			if (num != 1)
			{
				return new 背中_光D();
			}
			return new 背中_甲D();
		}

		public static EleD Get触覚R(bool 右)
		{
			switch (OthN.XS.NextM(4))
			{
			case 0:
				return new 触覚_線D
				{
					右 = 右
				};
			case 1:
				return new 触覚_節D
				{
					右 = 右
				};
			case 2:
				return new 触覚_甲D
				{
					右 = 右
				};
			case 3:
				return new 触覚_蝶D
				{
					右 = 右
				};
			default:
				return new 触覚_蛾D
				{
					右 = 右
				};
			}
		}

		public static EleD Get尾R()
		{
			switch (OthN.XS.NextM(22))
			{
			case 0:
				return new 尾_猫D();
			case 1:
				return new 尾_犬D();
			case 2:
				return new 尾_狐D();
			case 3:
				return new 尾_馬D();
			case 4:
				return new 尾_牛D();
			case 5:
				return new 尾_龍D();
			case 6:
				return new 尾_竜D();
			case 7:
				return new 尾_悪D();
			case 8:
				return new 尾_淫D();
			case 9:
				return new 尾_鳥D();
			case 10:
				return new 尾_虫D();
			case 11:
				return new 尾_蜘D();
			case 12:
				return new 尾_蠍D();
			case 13:
				return new 尾_蛇D();
			case 14:
				return new 尾_腓D();
			case 15:
				return new 尾_短D();
			case 16:
				return new 尾_ヘD();
			case 17:
				return new 尾_ガD();
			case 18:
				return new 尾_ウD();
			case 19:
				return new 尾_魚D();
			case 20:
				return new 尾_鯨D();
			case 21:
				return new 尾_蟲D();
			default:
				return new 尾_根D();
			}
		}

		public static EleD Get尾鰭R()
		{
			if (OthN.XS.NextM(1) == 0)
			{
				return new 尾鰭_魚D();
			}
			return new 尾鰭_鯨D();
		}

		public static EleD Get鰭R(bool 右)
		{
			int num = OthN.XS.NextM(2);
			if (num == 0)
			{
				return new 鰭_魚D
				{
					右 = 右
				};
			}
			if (num != 1)
			{
				return new 鰭_鯨D
				{
					右 = 右
				};
			}
			return new 鰭_豚D
			{
				右 = 右
			};
		}

		public static EleD Get葉R(bool 右)
		{
			if (OthN.XS.NextM(1) == 0)
			{
				return new 葉_披D
				{
					右 = 右
				};
			}
			return new 葉_心D
			{
				右 = 右
			};
		}

		public static EleD Get前翅R(bool 右)
		{
			switch (OthN.XS.NextM(3))
			{
			case 0:
				return new 前翅_甲D
				{
					右 = 右
				};
			case 1:
				return new 前翅_羽D
				{
					右 = 右
				};
			case 2:
				return new 前翅_蝶D
				{
					右 = 右
				};
			default:
				return new 前翅_草D
				{
					右 = 右
				};
			}
		}

		public static EleD Get後翅R(bool 右)
		{
			switch (OthN.XS.NextM(3))
			{
			case 0:
				return new 後翅_甲D
				{
					右 = 右
				};
			case 1:
				return new 後翅_羽D
				{
					右 = 右
				};
			case 2:
				return new 後翅_蝶D
				{
					右 = 右
				};
			default:
				return new 後翅_草D
				{
					右 = 右
				};
			}
		}

		public static EleD Get節足R(bool 右)
		{
			switch (OthN.XS.NextM(6))
			{
			case 0:
				return new 節足_足蜘D
				{
					右 = 右
				};
			case 1:
				return new 触肢_肢蜘D
				{
					右 = 右
				};
			case 2:
				return new 節足_足蠍D
				{
					右 = 右
				};
			case 3:
				return new 触肢_肢蠍D
				{
					右 = 右
				};
			case 4:
				return new 節足_足百D
				{
					右 = 右
				};
			case 5:
				return new 節尾_曳航D
				{
					右 = 右
				};
			default:
				return new 節尾_鋏D
				{
					右 = 右
				};
			}
		}

		public static EleD Get触手R(bool 右)
		{
			switch (OthN.XS.NextM(3))
			{
			case 0:
				return new 触手_軟D
				{
					右 = 右
				};
			case 1:
				return new 触手_触D
				{
					右 = 右
				};
			case 2:
				return new 触手_犬D
				{
					右 = 右
				};
			default:
				return new 触手_蔦D
				{
					右 = 右
				};
			}
		}

		public static EleD Get上腕R(bool 右)
		{
			switch (OthN.XS.NextM(4))
			{
			case 0:
				return new 上腕_人D
				{
					右 = 右
				};
			case 1:
				return new 上腕_鳥D
				{
					右 = 右
				};
			case 2:
				return new 上腕_蝙D
				{
					右 = 右
				};
			case 3:
				return new 上腕_獣D
				{
					右 = 右
				};
			default:
				return new 上腕_蹄D
				{
					右 = 右
				};
			}
		}

		public static EleD Get下腕R(bool 右)
		{
			switch (OthN.XS.NextM(4))
			{
			case 0:
				return new 下腕_人D
				{
					右 = 右
				};
			case 1:
				return new 下腕_鳥D
				{
					右 = 右
				};
			case 2:
				return new 下腕_蝙D
				{
					右 = 右
				};
			case 3:
				return new 下腕_獣D
				{
					右 = 右
				};
			default:
				return new 下腕_蹄D
				{
					右 = 右
				};
			}
		}

		public static EleD Get手R(bool 右)
		{
			switch (OthN.XS.NextM(5))
			{
			case 0:
				return new 手_人D
				{
					右 = 右
				};
			case 1:
				return new 手_鳥D
				{
					右 = 右
				};
			case 2:
				return new 手_蝙D
				{
					右 = 右
				};
			case 3:
				return new 手_獣D
				{
					右 = 右
				};
			case 4:
				return new 手_馬D
				{
					右 = 右
				};
			default:
				return new 手_牛D
				{
					右 = 右
				};
			}
		}

		public static EleD Get腿R(bool 右)
		{
			switch (OthN.XS.NextM(4))
			{
			case 0:
				return new 腿_人D
				{
					右 = 右
				};
			case 1:
				return new 腿_獣D
				{
					右 = 右
				};
			case 2:
				return new 腿_蹄D
				{
					右 = 右
				};
			case 3:
				return new 腿_鳥D
				{
					右 = 右
				};
			default:
				return new 腿_竜D
				{
					右 = 右
				};
			}
		}

		public static EleD Get脚R(bool 右)
		{
			switch (OthN.XS.NextM(4))
			{
			case 0:
				return new 脚_人D
				{
					右 = 右
				};
			case 1:
				return new 脚_獣D
				{
					右 = 右
				};
			case 2:
				return new 脚_蹄D
				{
					右 = 右
				};
			case 3:
				return new 脚_鳥D
				{
					右 = 右
				};
			default:
				return new 脚_竜D
				{
					右 = 右
				};
			}
		}

		public static EleD Get足R(bool 右)
		{
			switch (OthN.XS.NextM(5))
			{
			case 0:
				return new 足_人D
				{
					右 = 右
				};
			case 1:
				return new 足_獣D
				{
					右 = 右
				};
			case 2:
				return new 足_馬D
				{
					右 = 右
				};
			case 3:
				return new 足_牛D
				{
					右 = 右
				};
			case 4:
				return new 足_鳥D
				{
					右 = 右
				};
			default:
				return new 足_竜D
				{
					右 = 右
				};
			}
		}

		public static EleD Get長物R()
		{
			switch (OthN.XS.NextM(3))
			{
			case 0:
				return new 長物_魚D();
			case 1:
				return new 長物_鯨D();
			case 2:
				return new 長物_蛇D();
			default:
				return new 長物_蟲D();
			}
		}

		public static EleD Get多足R()
		{
			int num = OthN.XS.NextM(2);
			if (num == 0)
			{
				return new 多足_蛸D();
			}
			if (num != 1)
			{
				return new 多足_蠍D();
			}
			return new 多足_蜘D();
		}

		public static EleD Get単足R()
		{
			if (OthN.XS.NextM(1) == 0)
			{
				return new 単足_植D();
			}
			return new 単足_粘D();
		}

		public static EleD Get胴R()
		{
			if (OthN.XS.NextM(1) == 0)
			{
				return new 胴_蛇D();
			}
			return new 胴_蟲D();
		}

		public static 胴D Set胴(this 腰D 腰)
		{
			胴D 胴D = Uni.胴();
			腰.胴接続(胴D);
			return 胴D;
		}

		public static 胸D Set胸R(this 胴D 胴)
		{
			胸D 胸D = Con.Get胸R();
			胴.胸接続(胸D);
			return 胸D;
		}

		public static 首D Set首(this 胸D 胸)
		{
			首D 首D = new 首D();
			胸.首接続(首D);
			return 首D;
		}

		public static 頭D Set頭R(this 首D 首)
		{
			頭D 頭D = Con.Get頭R();
			首.頭接続(頭D);
			return 頭D;
		}

		public static 頭D Set頭R1(this 首D 首)
		{
			頭D 頭D = Con.Get頭R1();
			首.頭接続(頭D);
			return 頭D;
		}

		public static void Set双目R(this 頭D 頭)
		{
			双目D 双目D = Con.Get双眼R(false);
			頭.目左接続(双目D);
			頭.目右接続(双目D.Get逆());
			眉D 眉D = Con.Get眉R(false);
			頭.眉左接続(眉D);
			頭.眉右接続(眉D.Get逆());
		}

		public static void Set目弱R(this 頭D 頭)
		{
			双目D 双目D = Uni.魔弱目(false);
			((瞼_弱D)双目D.瞼_接続[0]).SetRandom();
			頭.目左接続(双目D);
			頭.目右接続(双目D.Get逆());
			眉D 眉D = Con.Get眉R(false);
			頭.眉左接続(眉D);
			頭.眉右接続(眉D.Get逆());
		}

		public static void Set目中R(this 頭D 頭)
		{
			双目D 双目D = Uni.魔中目(false);
			((瞼_中D)双目D.瞼_接続[0]).SetRandom();
			頭.目左接続(双目D);
			頭.目右接続(双目D.Get逆());
			眉D 眉D = Con.Get眉R(false);
			頭.眉左接続(眉D);
			頭.眉右接続(眉D.Get逆());
		}

		public static void Set目強R(this 頭D 頭)
		{
			双目D 双目D = Uni.魔強目(false);
			((瞼_強D)双目D.瞼_接続[0]).SetRandom();
			頭.目左接続(双目D);
			頭.目右接続(双目D.Get逆());
			眉D 眉D = Con.Get眉R(false);
			頭.眉左接続(眉D);
			頭.眉右接続(眉D.Get逆());
		}

		public static void Set目獣R(this 頭D 頭)
		{
			双目D 双目D = Uni.獣性目(false);
			((瞼_獣D)双目D.瞼_接続[0]).SetRandom();
			頭.目左接続(双目D);
			頭.目右接続(双目D.Get逆());
			眉D 眉D = Con.Get眉R(false);
			頭.眉左接続(眉D);
			頭.眉右接続(眉D.Get逆());
		}

		public static void Set目宇R(this 頭D 頭)
		{
			双目D 双目D = Uni.宇宙目(false);
			((瞼_宇D)双目D.瞼_接続[0]).SetRandom();
			頭.目左接続(双目D);
			頭.目右接続(双目D.Get逆());
			眉D 眉D = Con.Get眉R(false);
			頭.眉左接続(眉D);
			頭.眉右接続(眉D.Get逆());
		}

		public static void Set単目R(this 頭D 頭)
		{
			頭.単眼目接続(Con.Get単眼R());
			頭.単眼眉接続(Con.Get単眼眉R());
		}

		public static void Set鼻R(this 頭D 頭)
		{
			頭.鼻接続(Con.Get鼻R());
		}

		public static void Set鼻人(this 頭D 頭)
		{
			頭.鼻接続(Uni.人鼻D());
		}

		public static void Set鼻獣(this 頭D 頭)
		{
			頭.鼻接続(Uni.獣鼻D());
		}

		public static void Set口R(this 頭D 頭)
		{
			foreach (EleD e in Con.Get口R())
			{
				頭.口接続(e);
			}
		}

		public static void Set口人(this 頭D 頭)
		{
			foreach (EleD e in Uni.人口D())
			{
				頭.口接続(e);
			}
		}

		public static void Set口裂(this 頭D 頭)
		{
			foreach (EleD e in Uni.裂口D())
			{
				頭.口接続(e);
			}
		}

		public static void Set舌R(this 頭D 頭)
		{
			頭.口接続(Con.Get舌R());
		}

		public static void Set舌短(this 頭D 頭)
		{
			頭.口接続(new 舌_短D());
		}

		public static void Set舌長(this 頭D 頭)
		{
			頭.口接続(new 舌_長D());
		}

		public static void Set耳R(this 頭D 頭)
		{
			EleD eleD = Con.Get耳R(false);
			頭.耳左接続(eleD);
			頭.耳右接続(eleD.Get逆());
		}

		public static void Set耳人(this 頭D 頭)
		{
			耳_人D 耳_人D = new 耳_人D();
			頭.耳左接続(耳_人D);
			頭.耳右接続(耳_人D.Get逆());
		}

		public static void Set耳尖(this 頭D 頭)
		{
			耳_尖D 耳_尖D = new 耳_尖D();
			頭.耳左接続(耳_尖D);
			頭.耳右接続(耳_尖D.Get逆());
		}

		public static void Set耳長(this 頭D 頭)
		{
			耳_長D 耳_長D = new 耳_長D();
			頭.耳左接続(耳_長D);
			頭.耳右接続(耳_長D.Get逆());
		}

		public static void Set耳鰭(this 頭D 頭)
		{
			耳_鰭D 耳_鰭D = new 耳_鰭D();
			頭.耳左接続(耳_鰭D);
			頭.耳右接続(耳_鰭D.Get逆());
		}

		public static void Set耳羽(this 頭D 頭)
		{
			耳_羽D 耳_羽D = new 耳_羽D();
			頭.耳左接続(耳_羽D);
			頭.耳右接続(耳_羽D.Get逆());
		}

		public static void Set耳獣(this 頭D 頭)
		{
			耳_獣D 耳_獣D = new 耳_獣D();
			頭.耳左接続(耳_獣D);
			頭.耳右接続(耳_獣D.Get逆());
		}
	}
}
