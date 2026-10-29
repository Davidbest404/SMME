using System;
using System.Drawing;

namespace SlaveMatrix
{
	public static class Tra
	{
		public static 接触D GetContact(this Cha Cha, ref Color HitColor)
		{
			接触D 接触D = new 接触D
			{
				e = Cha.Bod.GetHitEle(HitColor)
			};
			if (接触D.e != null)
			{
				接触D.p = 接触D.e.本体.GetHitPar_(HitColor);
				bool flag = 接触D.e is 肩 || 接触D.e is 上腕 || 接触D.e is 下腕 || 接触D.e is 手 || 接触D.e is 四足脇 || 接触D.e is 腿 || 接触D.e is 脚 || 接触D.e is 足 || 接触D.e is 鰭 || 接触D.e is 葉 || 接触D.e is 前翅 || 接触D.e is 後翅 || 接触D.e is 触肢 || 接触D.e is 節足 || 接触D.e is 節尾 || 接触D.e is 大顎 || 接触D.e is 虫顎 || 接触D.e is 虫鎌 || 接触D.e is 触手;
				bool flag2;
				if (接触D.e is 前髪 || 接触D.e is 頭頂)
				{
					接触D.c = 接触.頭;
				}
				else if (接触D.e is 耳 || 接触D.e is 獣耳)
				{
					接触D.c = 接触.耳;
				}
				else if (Cha.Bod.Is口腔())
				{
					接触D.c = 接触.口;
				}
				else if (接触D.e is 頭)
				{
					接触D.c = 接触.顔;
				}
				else if (接触D.e is 横髪 || 接触D.e is 後髪0 || 接触D.e is 後髪1 || 接触D.e is 基髪)
				{
					接触D.c = 接触.髪;
				}
				else if (接触D.e is 首)
				{
					接触D.c = 接触.首;
				}
				else if (接触D.e is 肩)
				{
					接触D.c = 接触.肩;
				}
				else if (!flag && !Cha.Bod.乳房左.虫性_甲殻_表示 && !(接触D.p.Tag == "乳房") && Cha.Bod.Is乳首())
				{
					接触D.c = 接触.乳;
				}
				else if (接触D.e is 乳房)
				{
					接触D.c = 接触.胸;
				}
				else if (接触D.e is 胸)
				{
					接触D.c = 接触.脇;
				}
				else if (((接触D.e is 腰 || 接触D.e is 四足腰) && 接触D.p != null && 接触D.p.Tag == "下腹") || 接触D.e is ボテ腹)
				{
					接触D.c = 接触.腹;
				}
				else if ((flag2 = (!flag && Cha.Bod.Isくぱぁ())) && 接触D.e is 肛門)
				{
					接触D.c = 接触.肛;
				}
				else if (flag2 && Cha.Bod.Is陰核())
				{
					接触D.c = 接触.核;
				}
				else if (flag2 && Cha.Bod.Is膣口())
				{
					接触D.c = 接触.膣;
				}
				else if (flag2 && 接触D.e is 性器)
				{
					接触D.c = 接触.性;
				}
				else if (flag2 && Cha.Bod.Is局部())
				{
					接触D.c = 接触.股;
				}
				else if (接触D.e is 尾_蜘 && (接触D.p.Tag.Contains("出糸突起左") || 接触D.p.Tag.Contains("出糸突起中") || 接触D.p.Tag.Contains("出糸突起右")))
				{
					接触D.c = 接触.糸;
				}
				else if (接触D.e.接続情報.ToString().Contains("腿") && !接触D.e.接続情報.Is左右無し())
				{
					接触D.c = 接触.腿;
				}
				else if (接触D.e is 足_人)
				{
					接触D.c = 接触.足;
				}
				else if (接触D.e is 手_人)
				{
					接触D.c = 接触.手;
				}
				else if (接触D.e is 触覚)
				{
					接触D.c = 接触.覚;
				}
				else if (接触D.e is 触手)
				{
					接触D.c = 接触.触;
				}
				else if (接触D.e.接続情報.ToString().Contains("尾"))
				{
					接触D.c = 接触.尾;
				}
				else if (接触D.e is 前翅 || 接触D.e is 後翅 || 接触D.e is 上腕_鳥 || 接触D.e is 下腕_鳥 || 接触D.e is 手_鳥 || 接触D.e is 上腕_蝙 || 接触D.e is 下腕_蝙 || 接触D.e is 手_蝙)
				{
					接触D.c = 接触.翼;
				}
				else if (接触D.e is 鰭)
				{
					接触D.c = 接触.鰭;
				}
				else
				{
					接触D.c = 接触.他;
				}
			}
			return 接触D;
		}
	}
}
