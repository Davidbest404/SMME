using System;
using System.Collections.Generic;
using System.Drawing;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class ListView
	{
		public ListView(Are Are, Vector2D Position, double Space, Font Font, double TextSize, Color TextColor, Color ShadColor, Color BackColor, Color FramColor, params TA[] acts)
		{
			double sizeBase = 0.095;
			if (Sta.BigWindow && !Sta.NoScaling)
			{
				sizeBase = 0.125;
			}
			this.Are = Are;
			this.Space = Space;
			this.pt = new ParT[acts.Length];
			this.bs = new Buts();
			for (int i = 0; i < acts.Length; i++)
			{
				this.pt[i] = new ParT();
				this.pt[i].Text = acts[i].Text;
				this.pt[i].SizeBase = sizeBase;
				this.pt[i].Font = Font;
				this.pt[i].FontSize = TextSize;
				this.pt[i].RectSize = new Vector2D(100.0, 100.0);
				this.pt[i].SetStringRectOutline(Are.Unit, Are.GD);
				this.pt[i].Closed = true;
				this.pt[i].TextColor = TextColor;
				if (!ShadColor.IsEmpty)
				{
					this.pt[i].ShadBrush = new SolidBrush(ShadColor);
				}
				this.pt[i].BrushColor = BackColor;
				this.pt[i].PenColor = FramColor;
				this.bs.Add(i.ToString(), new But1(this.pt[i], acts[i].act));
			}
			this.Position = Position;
			this.LocalHeight = Are.LocalHeight;
		}

		public void SetHitColor(Med Med)
		{
			foreach (ParT parT in this.pt)
			{
				parT.HitColor = Med.GetUniqueColor();
				parT.HitColor = Med.GetUniqueColor();
			}
		}

		public void Down(ref Color HitColor)
		{
			this.bs.Down(ref HitColor);
		}

		public void Leave()
		{
			this.bs.Leave();
		}

		public void Move(ref Color HitColor)
		{
			this.bs.Move(ref HitColor);
		}

		public void Up(ref Color HitColor)
		{
			this.bs.Up(ref HitColor);
		}

		public IEnumerable<TA> Acts
		{
			set
			{
				int num = 0;
				foreach (TA ta in value)
				{
					this.pt[num].Text = ta.Text;
					this.bs[num.ToString()].Action = ta.act;
					num++;
				}
			}
		}

		public Vector2D Position
		{
			get
			{
				return this.p;
			}
			set
			{
				this.p = value;
				double num = 0.0;
				double num2 = this.pt[0].OP[0].ps[3].Y * this.pt[0].SizeBase;
				num2 += num2 * this.Space;
				ParT[] array = this.pt;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].PositionBase = this.p.AddY(num);
					num += num2;
				}
			}
		}

		public void Draw(Are Are)
		{
			this.bs.Draw(Are);
		}

		public void Dispose()
		{
			this.bs.Dispose();
		}

		private Are Are;

		private ParT[] pt;

		public Buts bs;

		private double Space;

		private double LocalHeight;

		private Vector2D p;
	}
}
