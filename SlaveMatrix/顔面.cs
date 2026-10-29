using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 顔面 : Ele
	{
		public double 展開0
		{
			get
			{
				return this.展開;
			}
			set
			{
				this.展開 = value;
				this.位置C = new Vector2D(this.位置C.X, -0.013 * value);
				this.尺度YC = 1.0 - 0.05 * value;
			}
		}

		public virtual double 展開1 { get; set; }

		private double 展開;

		public Ele[] 触覚左_接続;

		public Ele[] 触覚右_接続;
	}
}
