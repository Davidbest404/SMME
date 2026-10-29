using System;

namespace _2DGAMELIB
{
	public static class V2n
	{
		public static int SettledMinValue2n(this double Value)
		{
			foreach (int num in V2n.Value2ns)
			{
				if (Value < (double)num)
				{
					return num;
				}
			}
			return 0;
		}

		public const int v2 = 2;

		public const int v4 = 4;

		public const int v8 = 8;

		public const int v16 = 16;

		public const int v32 = 32;

		public const int v64 = 64;

		public const int v128 = 128;

		public const int v256 = 256;

		public const int v512 = 512;

		public const int v1024 = 1024;

		public const int v2048 = 2048;

		public const int v4096 = 4096;

		public const int v8192 = 8192;

		public const int v16384 = 16384;

		public const int v32768 = 32768;

		public const int v65536 = 65536;

		public const int v131072 = 131072;

		public const int v262144 = 262144;

		public const int v524288 = 524288;

		public const int v1048576 = 1048576;

		public const int v2097152 = 2097152;

		public const int v4194304 = 4194304;

		public const int v8388608 = 8388608;

		public const int v16777216 = 16777216;

		public const int v33554432 = 33554432;

		public const int v67108864 = 67108864;

		public const int v134217728 = 134217728;

		public const int v268435456 = 268435456;

		public const int v536870912 = 536870912;

		public const int v1073741824 = 1073741824;

		public static int[] Value2ns = new int[]
		{
			2,
			4,
			8,
			16,
			32,
			64,
			128,
			256,
			512,
			1024,
			2048,
			4096,
			8192,
			16384,
			32768,
			65536,
			131072,
			262144,
			524288,
			1048576,
			2097152,
			4194304,
			8388608,
			16777216,
			33554432,
			67108864,
			134217728,
			268435456,
			536870912,
			1073741824
		};
	}
}
