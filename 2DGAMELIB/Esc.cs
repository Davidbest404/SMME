using System;

namespace _2DGAMELIB
{
	public static class Esc
	{
		public static string OctalConstant(this string N)
		{
			return "\\" + N;
		}

		public static string HexadecimalConstant(this string N)
		{
			return "\\x" + N;
		}

		public static string ToEscString(this string str)
		{
			return str.Replace("'", "\\'").Replace("\"", "\\").Replace("\\", "\\\\").Replace("\0", "\\0").Replace("\a", "\\a").Replace("\b", "\\b").Replace("\f", "\\f").Replace("\n", "\\n").Replace("\r", "\\r").Replace("\t", "\\t").Replace("\v", "\\v");
		}

		public static string RemoveEscString(this string str)
		{
			return str.Replace("'", "").Replace("\"", "").Replace("\\", "").Replace("\0", "").Replace("\a", "").Replace("\b", "").Replace("\f", "").Replace("\n", "").Replace("\r", "").Replace("\t", "").Replace("\v", "");
		}

		public const string Alert = "\a";

		public const string BackSpace = "\b";

		public const string FormFeed = "\f";

		public const string NewLine = "\n";

		public const string CarriageReturn = "\r";

		public const string HorizontalTab = "\t";

		public const string VerticalTab = "\v";

		public const string BackSlash = "\\";

		public const string QuestionMark = "\\?";

		public const string SingleQuotation = "'";

		public const string DoubleQuotation = "\"";

		public const string Null = "\0";

		public const string CRLF = "\r\n";
	}
}
