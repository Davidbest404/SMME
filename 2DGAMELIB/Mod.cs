using System;
using System.Drawing;
using System.Windows.Forms;

namespace _2DGAMELIB
{
	public class Mod
	{
		public Action<MouseButtons, Vector2D, Color> Down = delegate(MouseButtons m, Vector2D v, Color c)
		{
		};

		public Action<MouseButtons, Vector2D, Color> Up = delegate(MouseButtons m, Vector2D v, Color c)
		{
		};

		public Action<MouseButtons, Vector2D, Color> Move = delegate(MouseButtons m, Vector2D v, Color c)
		{
		};

		public Action<MouseButtons, Vector2D, Color> Leave = delegate(MouseButtons m, Vector2D v, Color c)
		{
		};

		public Action<MouseButtons, Vector2D, int, Color> Wheel = delegate(MouseButtons m, Vector2D v, int i, Color c)
		{
		};

		public Action<FPS> Draw = delegate(FPS FPS)
		{
		};

		public Action Dispose = delegate()
		{
		};

		public Action Setting = delegate()
		{
		};
	}
}
