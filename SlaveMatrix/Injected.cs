using System;

namespace SlaveMatrix
{
	public static class Injected
	{
		public static string TranslateState(感情 state)
		{
			string result = "";
			switch (state)
			{
			case 感情.否定:
				result = "denial";
				break;
			case 感情.屈辱:
				result = "disgrace";
				break;
			case 感情.羞恥:
				result = "shame";
				break;
			case 感情.受容:
				result = "acceptance";
				break;
			case 感情.欲望:
				result = "desire";
				break;
			case 感情.興奮:
				result = "excitement";
				break;
			case 感情.余裕:
				result = "allowance";
				break;
			case 感情.幸福:
				result = "happiness";
				break;
			case 感情.喜悦:
				result = "delight";
				break;
			case 感情.淫乱:
				result = "horny";
				break;
			case 感情.其他:
				result = "other";
				break;
			}
			return result;
		}

		public static string TouchTranslation(接触 part)
		{
			string result = "";
			switch (part)
			{
			case 接触.none:
				result = "null ";
				break;
			case 接触.頭:
				result = "head ";
				break;
			case 接触.顔:
				result = "face ";
				break;
			case 接触.耳:
				result = "ear  ";
				break;
			case 接触.口:
				result = "mouth";
				break;
			case 接触.髪:
				result = "hair ";
				break;
			case 接触.首:
				result = "neck ";
				break;
			case 接触.肩:
				result = "shoul";
				break;
			case 接触.胸:
				result = "breas";
				break;
			case 接触.乳:
				result = "nippl";
				break;
			case 接触.脇:
				result = "armpi";
				break;
			case 接触.腹:
				result = "belly";
				break;
			case 接触.股:
				result = "crotc";
				break;
			case 接触.性:
				result = "sex  ";
				break;
			case 接触.膣:
				result = "vag  ";
				break;
			case 接触.核:
				result = "clit ";
				break;
			case 接触.肛:
				result = "anus ";
				break;
			case 接触.糸:
				result = "spinn";
				break;
			case 接触.腿:
				result = "thigh";
				break;
			case 接触.足:
				result = "feet ";
				break;
			case 接触.手:
				result = "hands";
				break;
			case 接触.覚:
				result = "t.eye";
				break;
			case 接触.触:
				result = "tenta";
				break;
			case 接触.尾:
				result = "tail ";
				break;
			case 接触.翼:
				result = "wings";
				break;
			case 接触.鰭:
				result = "fin  ";
				break;
			case 接触.他:
				result = "other";
				break;
			}
			return result;
		}

		public static bool showSenses;
	}
}
