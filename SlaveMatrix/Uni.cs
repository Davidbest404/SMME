using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public static class Uni
	{
		public static 頭D 頭()
		{
			頭D 頭D = new 頭D();
			頭D.基髪接続(new 基髪D());
			頭D.目左接続(new 目傷D());
			頭D.目右接続(new 目傷D
			{
				右 = true
			});
			頭D.目左接続(new 目尻影D());
			頭D.目右接続(new 目尻影D
			{
				右 = true
			});
			頭D.鼻肌接続(new 鼻肌D());
			頭D.鼻肌接続(new 紅潮D());
			頭D.頬肌左接続(new 頬肌D());
			頭D.頬肌右接続(new 頬肌D
			{
				右 = true
			});
			頭D.頬左接続(new 顔ハイライトD());
			頭D.頬右接続(new 顔ハイライトD
			{
				右 = true
			});
			頭D.単眼目接続(new 目隠帯D());
			頭D.口接続(new 玉口枷D());
			return 頭D;
		}

		public static 胸D 胸()
		{
			胸D 胸D = new 胸D();
			胸D.肌接続(new 胸毛D());
			胸D.肌接続(new 胸肌D());
			胸D.肌接続(new 胸腹板D());
			胸D.肌接続(new 下着トップ_チュ\u30FCブD());
			胸D.肌接続(new 下着トップ_クロスD());
			胸D.肌接続(new 下着トップ_ビキニD());
			胸D.肌接続(new 下着トップ_マイクロD());
			胸D.肌接続(new 下着トップ_ブラD());
			胸D.肌接続(new 上着トップ_ドレスD());
			乳房D 乳房D = Uni.乳房();
			胸D.胸左接続(乳房D);
			胸D.胸右接続(乳房D.Get逆());
			return 胸D;
		}

		public static 胴D 胴()
		{
			胴D 胴D = new 胴D();
			胴D.肌接続(new 胴腹板D());
			胴D.肌接続(new 胴肌D());
			胴D.肌接続(new 上着ミドル_ドレスD());
			return 胴D;
		}

		public static 腰D 腰()
		{
			腰D 腰D = new 腰D();
			腰D.膣基接続(new 膣基_人D());
			腰D.膣基接続(new 膣内精液_人D());
			腰D.膣基接続(new 断面_人D());
			腰D.膣基接続(Uni.性器());
			腰D.肛門接続(Uni.肛門());
			腰D.肌接続(Uni.ボテ腹());
			腰D.肌接続(new 腰肌D());
			腰D.肌接続(new 下着ボトム_ノ\u30FCマルD());
			腰D.肌接続(new 下着ボトム_マイクロD());
			上着ボトム_クロスD 上着ボトム_クロスD = new 上着ボトム_クロスD();
			上着ボトム_クロスD.上着ボトム後接続(new 上着ボトム_クロス後D());
			腰D.上着接続(上着ボトム_クロスD);
			腰D.上着接続(new 上着ボトム_前掛けD());
			return 腰D;
		}

		public static 四足胸D 四足胸()
		{
			四足胸D 四足胸D = new 四足胸D();
			四足胸D.肌接続(new 胸毛D
			{
				尺度B = 1.4
			});
			四足胸D.肌接続(new 胸肌D
			{
				尺度B = 1.3
			});
			return 四足胸D;
		}

		public static 四足胴D 四足胴()
		{
			四足胴D 四足胴D = new 四足胴D();
			四足胴D.肌接続(new 胴肌D
			{
				尺度B = 1.35
			});
			return 四足胴D;
		}

		public static 四足腰D 四足腰()
		{
			四足腰D 四足腰D = new 四足腰D();
			四足腰D.膣基接続(new 膣基_獣D());
			四足腰D.膣基接続(new 膣内精液_獣D());
			四足腰D.膣基接続(new 断面_獣D());
			四足腰D.膣基接続(Uni.四足性器());
			四足腰D.肛門接続(Uni.四足肛門());
			四足腰D.肌接続(new ボテ腹_獣D());
			四足腰D.肌接続(new 腰肌D
			{
				尺度B = 1.4,
				虫性_腹板1_縦線_表示 = false,
				虫性_腹板1_腹板_表示 = false,
				虫性_腹板2_縦線_表示 = false,
				虫性_腹板2_腹板_表示 = false
			});
			四足腰D.竜性_中_鱗1_表示 = false;
			四足腰D.竜性_中_鱗2_表示 = false;
			四足腰D.竜性_中_鱗3_表示 = false;
			四足腰D.竜性_中_鱗4_表示 = false;
			return 四足腰D;
		}

		public static 双目D 魔弱目(bool 右)
		{
			双目D 双目D = new 双目D();
			双目D.右 = 右;
			双目D.瞼接続(new 瞼_弱D
			{
				右 = 右
			});
			双目D.瞼接続(new 涙D
			{
				右 = 右
			});
			return 双目D;
		}

		public static 双目D 魔中目(bool 右)
		{
			双目D 双目D = new 双目D();
			双目D.右 = 右;
			双目D.瞼接続(new 瞼_中D
			{
				右 = 右
			});
			双目D.瞼接続(new 涙D
			{
				右 = 右
			});
			return 双目D;
		}

		public static 双目D 魔強目(bool 右)
		{
			双目D 双目D = new 双目D();
			双目D.右 = 右;
			双目D.瞼接続(new 瞼_強D
			{
				右 = 右
			});
			双目D.瞼接続(new 涙D
			{
				右 = 右
			});
			return 双目D;
		}

		public static 双目D 獣性目(bool 右)
		{
			双目D 双目D = new 双目D();
			双目D.右 = 右;
			双目D.瞼接続(new 瞼_獣D
			{
				右 = 右
			});
			双目D.瞼接続(new 涙D
			{
				右 = 右
			});
			return 双目D;
		}

		public static 双目D 宇宙目(bool 右)
		{
			双目D 双目D = new 双目D();
			双目D.右 = 右;
			双目D.瞼接続(new 瞼_宇D
			{
				右 = 右
			});
			双目D.瞼接続(new 涙D
			{
				右 = 右
			});
			return 双目D;
		}

		public static 単目D 単眼目()
		{
			単目D 単目D = new 単目D();
			単目D.瞼接続(new 単瞼D());
			単目D.瞼接続(new 涙D
			{
				基準C = new Vector2D(0.01, 0.0)
			});
			単目D.瞼接続(new 涙D
			{
				右 = true,
				基準C = new Vector2D(-0.01, 0.0)
			});
			return 単目D;
		}

		public static 縦目D 縦目()
		{
			縦目D 縦目D = new 縦目D();
			縦目D.瞼接続(new 縦瞼D());
			return 縦目D;
		}

		public static 頬目D 頬目(bool 右)
		{
			頬目D 頬目D = new 頬目D();
			頬目D.右 = 右;
			頬目D.瞼接続(new 頬瞼D
			{
				右 = 右
			});
			return 頬目D;
		}

		public static 鼻_人D 人鼻D()
		{
			鼻_人D 鼻_人D = new 鼻_人D();
			鼻_人D.鼻水左接続(new 鼻水D());
			鼻_人D.鼻水右接続(new 鼻水D
			{
				右 = true
			});
			return 鼻_人D;
		}

		public static 鼻_獣D 獣鼻D()
		{
			鼻_獣D 鼻_獣D = new 鼻_獣D();
			鼻_獣D.鼻水左接続(new 鼻水D());
			鼻_獣D.鼻水右接続(new 鼻水D
			{
				右 = true
			});
			return 鼻_獣D;
		}

		public static EleD[] 人口D()
		{
			return new EleD[]
			{
				new 口_通常D(),
				new 涎_通常D(),
				new 涎_通常D
				{
					右 = true
				},
				new 性器精液_人D(),
				new 咳D(),
				new 呼気D()
			};
		}

		public static EleD[] 裂口D()
		{
			return new EleD[]
			{
				new 口_裂けD(),
				new 涎_裂けD(),
				new 涎_裂けD
				{
					右 = true
				},
				new 性器精液_人D(),
				new 咳D(),
				new 呼気D()
			};
		}

		public static 乳房D 乳房()
		{
			乳房D 乳房D = new 乳房D();
			乳房D.噴乳接続(new 噴乳D());
			乳房D.噴乳接続(new ピアスD());
			乳房D.噴乳接続(new キャップ2D());
			乳房D.噴乳接続(new 下着乳首D());
			return 乳房D;
		}

		public static ボテ腹_人D ボテ腹()
		{
			ボテ腹_人D ボテ腹_人D = new ボテ腹_人D();
			ボテ腹_人D.腹板接続(new ボテ腹板D());
			return ボテ腹_人D;
		}

		public static 肛門_人D 肛門()
		{
			肛門_人D 肛門_人D = new 肛門_人D();
			肛門_人D.肛門精液接続(new 肛門精液_人D());
			return 肛門_人D;
		}

		public static 肛門_獣D 四足肛門()
		{
			肛門_獣D 肛門_獣D = new 肛門_獣D();
			肛門_獣D.肛門精液接続(new 肛門精液_獣D());
			return 肛門_獣D;
		}

		public static 性器_人D 性器()
		{
			性器_人D 性器_人D = new 性器_人D();
			性器_人D.膣口接続(new 性器精液_人D());
			性器_人D.膣口接続(new 飛沫_人D());
			性器_人D.尿道接続(new 放尿_人D());
			性器_人D.尿道接続(new 潮吹_小_人D());
			性器_人D.尿道接続(new 潮吹_大_人D());
			性器_人D.陰核接続(new ピアスD());
			性器_人D.陰核接続(new キャップ1D());
			性器_人D.陰核接続(new 下着陰核D());
			return 性器_人D;
		}

		public static 性器_獣D 四足性器()
		{
			性器_獣D 性器_獣D = new 性器_獣D();
			性器_獣D.膣口接続(new 性器精液_獣D());
			性器_獣D.膣口接続(new 飛沫_獣D());
			性器_獣D.尿道接続(new 放尿_獣D());
			性器_獣D.尿道接続(new 潮吹_小_獣D());
			性器_獣D.尿道接続(new 潮吹_大_獣D());
			性器_獣D.陰核接続(new ピアスD());
			性器_獣D.陰核接続(new キャップ1D());
			return 性器_獣D;
		}
	}
}
