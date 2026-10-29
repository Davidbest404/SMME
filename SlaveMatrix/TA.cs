using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public struct TA
	{
		public TA(string Text, Action<But> act)
		{
			this.Text = Text;
			this.act = act;
		}

		public string Text;

		public Action<But> act;
	}
}
