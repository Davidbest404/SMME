using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 調教背景
	{
		public 調教背景()
		{
			this.Reset();
		}

		public void Reset()
		{
			for (int i = 0; i < 調教背景.L; i++)
			{
				this.Yv[i] = OthN.XS.NextDouble();
				this.An[i] = (double)OthN.XS.Next(4) * 90.0;
			}
		}

		public void 描画(Are Are)
		{
			double sizeBase = 0.7;
			if (Sta.BigWindow && !Sta.NoScaling)
			{
				sizeBase = 0.945;
			}
			調教背景.c = 0;
			調教背景.y = 0;
			while (調教背景.y < 10)
			{
				調教背景.x = 0;
				while (調教背景.x < 10)
				{
					Sta.タイル.SizeBase = sizeBase;
					Sta.タイル.JoinRoot.ValueY = this.Yv[調教背景.c];
					Sta.タイル.AngleBase = this.An[調教背景.c];
					Sta.タイル.JoinRoot.CurJoinRoot.PositionBase = Are.GetPosition(new Vector2D(調教背景.o.X + (double)調教背景.x * 調教背景.r / Are.XRatio, 調教背景.o.Y + (double)調教背景.y * 調教背景.r / Are.YRatio));
					Sta.タイル.JoinPA();
					Sta.タイル.Draw(Are);
					調教背景.c++;
					調教背景.x++;
				}
				調教背景.y++;
			}
		}

		private const int X = 10;

		private const int Y = 10;

		private static int L = 100;

		private const double s = 0.7;

		private double[] Yv = new double[調教背景.L];

		private double[] An = new double[調教背景.L];

		private static int c = 0;

		private static int x;

		private static int y;

		private static double r = 0.147;

		private static Vector2D o = new Vector2D(0.053 - 0.055 * OthN.XS.NextDouble(), 0.07 - 0.0735 * OthN.XS.NextDouble());
	}
}
