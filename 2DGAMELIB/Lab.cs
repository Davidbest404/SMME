using System;
using System.Drawing;
using System.Windows.Forms;

namespace _2DGAMELIB
{
	public class Lab
	{
		public ParT ParT
		{
			get
			{
				return this.parT;
			}
		}

		public string Text
		{
			get
			{
				return this.parT.Text;
			}
			set
			{
				if (!this.Med.BaseControl.Contains(this.tb))
				{
					this.SetText(value);
				}
			}
		}

		private void SetText(string Text)
		{
			this.parT.Text = Text;
			this.SetRect();
		}

		public Lab(Med Med, Are Are, string Name, ref Vector2D Position, double Size, double Width, Font Font, double TextSize, string Text, ref Color TextColor, ref Color ShadColor, ref Color BackColor, ref Color FramColor, bool Input)
		{
			this.Setting(Med, Are, Name, ref Position, Size, Width, Font, TextSize, Text, ref TextColor, ref ShadColor, ref BackColor, ref FramColor, Input);
		}

		public Lab(Med Med, Are Are, string Name, Vector2D Position, double Size, double Width, Font Font, double TextSize, string Text, Color TextColor, Color ShadColor, Color BackColor, Color FramColor, bool Input)
		{
			this.Setting(Med, Are, Name, ref Position, Size, Width, Font, TextSize, Text, ref TextColor, ref ShadColor, ref BackColor, ref FramColor, Input);
		}

		private void Setting(Med Med, Are Are, string Name, ref Vector2D Position, double Size, double Width, Font Font, double TextSize, string Text, ref Color TextColor, ref Color ShadColor, ref Color BackColor, ref Color FramColor, bool Input)
		{
			this.Med = Med;
			this.Are = Are;
			this.Width = Width;
			this.Input = Input;
			if (Input)
			{
				this.tb = new TextBox();
				this.tb.WordWrap = true;
				this.tb.Multiline = true;
				this.tb.Text = Text;
				this.tb.ForeColor = TextColor;
				this.tb.BackColor = Color.FromArgb(255, BackColor);
				this.tb.KeyUp += delegate(object s, KeyEventArgs e)
				{
					object obj = Med.obj;
					lock (obj)
					{
						this.SetText(this.tb.Text);
						this.parT.Text = "";
						this.SetRectT();
					}
				};
				this.tb.KeyDown += delegate(object s, KeyEventArgs e)
				{
					object obj = Med.obj;
					lock (obj)
					{
						if (e.KeyCode == Keys.Return)
						{
							this.Med.BaseControl.Controls.Remove(this.tb);
							this.SetText(this.tb.Text);
							e.SuppressKeyPress = true;
						}
					}
				};
				this.tb.PreviewKeyDown += delegate(object s, PreviewKeyDownEventArgs e)
				{
					e.IsInputKey = true;
				};
				Med.BaseControl.Controls.Add(this.tb);
				Med.BaseControl.Controls.Remove(this.tb);
				Med.BaseControl.Resize += this.Lab_Resize;
			}
			Out[] array = new Out[]
			{
				Shas.Get正方形()
			};
			if (FramColor == Color.Empty || FramColor == Color.Transparent)
			{
				array.OutlineFalse();
			}
			this.parT = new ParT
			{
				Tag = Name,
				InitializeOP = array,
				BasePointBase = array[0].ps[0],
				PositionBase = Position,
				SizeBase = Size,
				Closed = true,
				BrushColor = BackColor,
				PenColor = FramColor,
				Font = Font,
				FontSize = TextSize,
				TextColor = TextColor,
				Text = "A"
			};
			if (ShadColor != Color.Empty)
			{
				this.parT.ShadBrush = new SolidBrush(ShadColor);
			}
			this.SetRect();
			this.Min = this.parT.RectSize.Y;
			this.SetText(Text);
		}

		private void Lab_Resize(object sender, EventArgs e)
		{
			this.Med.BaseControl.Controls.Remove(this.tb);
			this.SetText(this.tb.Text);
		}

		public void SetHitColor(Med Med)
		{
			if (this.parT.HitColor != Color.Transparent)
			{
				Med.RemUniqueColor(this.parT.HitColor);
			}
			this.parT.HitColor = Med.GetUniqueColor();
		}

		private void SetRect()
		{
			if (!string.IsNullOrEmpty(this.parT.Text))
			{
				this.parT.RectSize = new Vector2D(this.Width, 10.0);
				Vector2D_2 stringRect = this.parT.GetStringRect(this.Are.DisUnit, this.Are.GD);
				double x = ((stringRect.v2.X > this.Min) ? stringRect.v2.X : this.Min) + 0.07;
				this.parT.RectSize = new Vector2D(x, stringRect.v2.Y);
			}
			else
			{
				double x2 = this.Min + 0.07;
				this.parT.RectSize = new Vector2D(x2, this.Min);
			}
			this.parT.OP[0].ps[0] = new Vector2D(0.0, 0.0);
			this.parT.OP[0].ps[1] = new Vector2D(this.parT.RectSize.X, 0.0);
			this.parT.OP[0].ps[2] = new Vector2D(this.parT.RectSize.X, this.parT.RectSize.Y);
			this.parT.OP[0].ps[3] = new Vector2D(0.0, this.parT.RectSize.Y);
		}

		private void SetRectT()
		{
			double resMag = this.Med.ResMag;
			Vector2D vector2D = (this.parT.Position + this.Are.GetPosition()) * this.Med.Unit / resMag + this.Med.ResVector;
			this.tb.Location = new Point((int)vector2D.X - 1, (int)vector2D.Y - 1);
			double num = this.parT.Size * this.Med.Unit;
			if (this.tb.Font != null)
			{
				this.tb.Font.Dispose();
			}
			this.tb.Font = new Font(this.parT.Font.FontFamily, (float)(this.parT.FontSize * num / resMag));
			Vector2D vector2D2 = this.parT.RectSize * num / resMag;
			this.tb.Size = new Size((int)(vector2D2.X + 2.0), (int)(vector2D2.Y + 10.0));
		}

		public bool Double(ref Color HitColor)
		{
			if (this.Input && this.parT.HitColor == HitColor && !this.Med.BaseControl.Controls.Contains(this.tb))
			{
				this.tb.Text = this.parT.Text;
				this.parT.Text = "";
				this.SetRectT();
				this.Med.BaseControl.Controls.Add(this.tb);
				this.tb.SelectAll();
				this.tb.Focus();
				this.tb.BringToFront();
				return true;
			}
			return false;
		}

		public void Click(ref Color HitColor)
		{
			if (this.Input && this.parT.HitColor != HitColor && this.Med.BaseControl.Controls.Contains(this.tb))
			{
				this.Med.BaseControl.Controls.Remove(this.tb);
				this.SetText(this.tb.Text);
			}
		}

		public void Dispose()
		{
			this.parT.Dispose();
			if (this.Input)
			{
				this.Med.BaseControl.Resize -= this.Lab_Resize;
			}
			if (this.tb != null)
			{
				this.tb.Dispose();
			}
		}

		private ParT parT;

		private Med Med;

		private Are Are;

		private double Width;

		private bool Input;

		private double Min;

		private TextBox tb;
	}
}
