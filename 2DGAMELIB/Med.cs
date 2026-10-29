using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Input;

namespace _2DGAMELIB
{
	public class Med
	{
		public Med()
		{
			Point dpi = Med.GetDpi();
			Med.dpiX = (double)dpi.X;
			Med.dpiY = (double)dpi.Y;
			Med.DpiX = 96.0 / Med.dpiX;
			Med.DpiY = 96.0 / Med.dpiY;
		}

		public Control BaseControlC
		{
			get
			{
				return this.baseControl;
			}
		}

		public WPFImage BaseControl
		{
			get
			{
				return this.baseControl;
			}
		}

		public double ResMag
		{
			get
			{
				return this.resMag;
			}
		}

		public Vector2D ResVector
		{
			get
			{
				return this.resVector;
			}
		}

		public void SlideR(double Rate)
		{
			this.Sce.SlideR(this.GD, Rate);
		}

		public void SlideL(double Rate)
		{
			this.Sce.SlideL(this.GD, Rate);
		}

		public void SlideD(double Rate)
		{
			this.Sce.SlideD(this.GD, Rate);
		}

		public void SlideU(double Rate)
		{
			this.Sce.SlideU(this.GD, Rate);
		}

		public void TransA(double Rate)
		{
			this.Sce.TransA(this.GD, Rate);
		}

		public void TransD(double Rate)
		{
			this.Sce.TransD(this.GD, Rate);
		}

		public void DrawSta(Are Are)
		{
			this.Sce.DrawSta(Are);
		}

		public void DrawSta(Are Are, double Opacity)
		{
			this.Sce.DrawSta(Are, Opacity);
		}

		public void DrawEnd(Are Are)
		{
			this.Sce.DrawEnd(Are);
		}

		public void DrawEnd(Are Are, double Opacity)
		{
			this.Sce.DrawEnd(Are, Opacity);
		}

		public void DrawSta(AreM AreM)
		{
			this.Sce.DrawSta(AreM);
		}

		public void DrawSta(AreM AreM, double Opacity)
		{
			this.Sce.DrawSta(AreM, Opacity);
		}

		public void DrawEnd(AreM AreM)
		{
			this.Sce.DrawEnd(AreM);
		}

		public void DrawEnd(AreM AreM, double Opacity)
		{
			this.Sce.DrawEnd(AreM, Opacity);
		}

		public void ClearSta(Color ClearColor)
		{
			this.Sce.ClearSta(ref ClearColor);
		}

		public void ClearSta(ref Color ClearColor)
		{
			this.Sce.ClearSta(ref ClearColor);
		}

		public void ClearEnd(Color ClearColor)
		{
			this.Sce.ClearEnd(ref ClearColor);
		}

		public void ClearEnd(ref Color ClearColor)
		{
			this.Sce.ClearEnd(ref ClearColor);
		}

		public Mod Mod
		{
			get
			{
				return this.Modes[this.mode];
			}
		}

		public string Mode
		{
			get
			{
				return this.mode;
			}
			set
			{
				this.Modes[this.mode].Up(MouseButtons.None, Dat.Vec2DZero, Color.Empty);
				this.Modes[this.mode].Move(MouseButtons.None, Dat.Vec2DZero, Color.Empty);
				this.Modeb = this.mode;
				this.mode = value;
				this.Modes[this.mode].Move(MouseButtons.None, Dat.Vec2DZero, Color.Empty);
				this.Modes[this.mode].Setting();
			}
		}

		public void InitializeModes(string Mode, Func<Med, Dictionary<string, Mod>> GetModes)
		{
			this.mode = Mode;
			this.GetModes = GetModes;
		}

		public Size Setting(WPFImage BaseControl)
		{
			this.baseControl = BaseControl;
			this.BaseSize = new Size((int)(this.Base.LocalWidth * this.Unit), (int)(this.Base.LocalHeight * this.Unit));
			this.BD = new Bitmap(this.BaseSize.Width, this.BaseSize.Height);
			this.GD = Graphics.FromImage(this.BD);
			this.GD.InterpolationMode = InterpolationMode.HighQualityBilinear;
			this.BH = new Bitmap((int)((double)this.BaseSize.Width * this.HitAccuracy), (int)((double)this.BaseSize.Height * this.HitAccuracy));
			this.GH = Graphics.FromImage(this.BH);
			this.GH.InterpolationMode = InterpolationMode.Bilinear;
			this.WidthM = this.BH.Width - 1;
			this.HeightM = this.BH.Height - 1;
			this.Clear();
			this.Sce = new Sce(this.BaseSize.Width, this.BaseSize.Height);
			this.Modes = this.GetModes(this);
			BaseControl.Image.MouseDown += delegate(object s, MouseButtonEventArgs e)
			{
				Point position = this.baseControl.PointToClient(System.Windows.Forms.Cursor.Position);
				MouseButtons arg = MouseButtons.None;
				switch (e.ChangedButton)
				{
				case MouseButton.Left:
					arg = MouseButtons.Left;
					break;
				case MouseButton.Middle:
					arg = MouseButtons.Middle;
					break;
				case MouseButton.Right:
					arg = MouseButtons.Right;
					break;
				case MouseButton.XButton1:
					arg = MouseButtons.XButton1;
					break;
				case MouseButton.XButton2:
					arg = MouseButtons.XButton2;
					break;
				}
				this.Modes[this.mode].Down(arg, this.ToBasePosition(position), this.GetHitColor(ref position));
			};
			BaseControl.Image.MouseUp += delegate(object s, MouseButtonEventArgs e)
			{
				Point position = this.baseControl.PointToClient(System.Windows.Forms.Cursor.Position);
				MouseButtons arg = MouseButtons.None;
				switch (e.ChangedButton)
				{
				case MouseButton.Left:
					arg = MouseButtons.Left;
					break;
				case MouseButton.Middle:
					arg = MouseButtons.Middle;
					break;
				case MouseButton.Right:
					arg = MouseButtons.Right;
					break;
				case MouseButton.XButton1:
					arg = MouseButtons.XButton1;
					break;
				case MouseButton.XButton2:
					arg = MouseButtons.XButton2;
					break;
				}
				this.Modes[this.mode].Up(arg, this.ToBasePosition(position), this.GetHitColor(ref position));
			};
			BaseControl.Image.MouseMove += delegate(object s, System.Windows.Input.MouseEventArgs e)
			{
				Point position = this.baseControl.PointToClient(System.Windows.Forms.Cursor.Position);
				this.Modes[this.mode].Move(Control.MouseButtons, this.ToBasePosition(position), this.GetHitColor(ref position));
			};
			BaseControl.Image.MouseLeave += delegate(object s, System.Windows.Input.MouseEventArgs e)
			{
				Point position = this.baseControl.PointToClient(System.Windows.Forms.Cursor.Position);
				this.Modes[this.mode].Leave(Control.MouseButtons, this.ToBasePosition(position), this.GetHitColor(ref position));
			};
			BaseControl.Image.MouseWheel += delegate(object s, MouseWheelEventArgs e)
			{
				Point position = this.baseControl.PointToClient(System.Windows.Forms.Cursor.Position);
				this.Modes[this.mode].Wheel(Control.MouseButtons, this.ToBasePosition(position), e.Delta, this.GetHitColor(ref position));
			};
			BaseControl.Resize += delegate(object s, EventArgs e)
			{
				if (this.BaseSize.Width >= this.BaseSize.Height)
				{
					double num = (double)this.BaseSize.Width / (double)this.BaseSize.Height;
					if ((double)this.baseControl.ClientSize.Width / (double)this.baseControl.ClientSize.Height <= num)
					{
						this.resMag = (double)this.BaseSize.Width / (double)this.baseControl.ClientSize.Width;
						this.resVector.X = 0.0;
						this.resVector.Y = ((double)this.baseControl.ClientSize.Height - (double)this.BaseSize.Height / this.resMag) * 0.5;
						return;
					}
					this.resMag = (double)this.BaseSize.Height / (double)this.baseControl.ClientSize.Height;
					this.resVector.X = ((double)this.baseControl.ClientSize.Width - (double)this.BaseSize.Width / this.resMag) * 0.5;
					this.resVector.Y = 0.0;
					return;
				}
				else
				{
					double num2 = (double)this.BaseSize.Height / (double)this.BaseSize.Width;
					if ((double)this.baseControl.ClientSize.Height / (double)this.baseControl.ClientSize.Width <= num2)
					{
						this.resMag = (double)this.BaseSize.Height / (double)this.baseControl.ClientSize.Height;
						this.resVector.X = ((double)this.baseControl.ClientSize.Width - (double)this.BaseSize.Width / this.resMag) * 0.5;
						this.resVector.Y = 0.0;
						return;
					}
					this.resMag = (double)this.BaseSize.Width / (double)this.baseControl.ClientSize.Width;
					this.resVector.X = 0.0;
					this.resVector.Y = ((double)this.baseControl.ClientSize.Height - (double)this.BaseSize.Height / this.resMag) * 0.5;
					return;
				}
			};
			return this.BaseSize;
		}

		public Vector2D ToBasePosition(Point Position)
		{
			return new Vector2D(((double)Position.X - this.resVector.X) / this.Unit * this.resMag, ((double)Position.Y - this.resVector.Y) / this.Unit * this.resMag);
		}

		public Point FromBasePosition(Vector2D Position)
		{
			return new Point((int)(Position.X / this.resMag * this.Unit + this.resVector.X), (int)(Position.Y / this.resMag * this.Unit + this.resVector.Y));
		}

		public Point FromBasePosition(ref Vector2D Position)
		{
			return new Point((int)(Position.X / this.resMag * this.Unit + this.resVector.X), (int)(Position.Y / this.resMag * this.Unit + this.resVector.Y));
		}

		public Color GetHitColor(Point Position)
		{
			double scale = this.HitAccuracy * this.resMag;
			Point point = ((Position.ToVector2D() - this.resVector) * scale).ToPoint();
			if (point.X < 0)
			{
				point.X = 0;
			}
			if (point.Y < 0)
			{
				point.Y = 0;
			}
			if (point.X > this.WidthM)
			{
				point.X = this.WidthM;
			}
			if (point.Y > this.HeightM)
			{
				point.Y = this.HeightM;
			}
			return this.BH.GetPixel(point.X, point.Y);
		}

		public Color GetHitColor(ref Point Position)
		{
			double scale = this.HitAccuracy * this.resMag;
			Point point = ((Position.ToVector2D() - this.resVector) * scale).ToPoint();
			if (point.X < 0)
			{
				point.X = 0;
			}
			if (point.Y < 0)
			{
				point.Y = 0;
			}
			if (point.X > this.WidthM)
			{
				point.X = this.WidthM;
			}
			if (point.Y > this.HeightM)
			{
				point.Y = this.HeightM;
			}
			return this.BH.GetPixel(point.X, point.Y);
		}

		public void Drawing()
		{
			this.baseControl.BitmapSetting(this.BD);
			this.Modes[this.mode].Setting();
			double FPS = 0.0;
			Action action = delegate()
			{
				FPS = this.FPSF.Value;
				if (FPS > 1.0)
				{
					this.Modes[this.mode].Draw(this.FPSF);
				}
				this.baseControl.SetBitmap(this.BD);
			};
			while (this.Drive)
			{
				try
				{
					this.FPSF.FPSFixed(action);
					if (this.ShowFPS)
					{
						this.baseControl.Parent.Text = this.UITitle + " - FPS: " + Math.Round(this.FPSF.Value, 2).ToString();
					}
					Application.DoEvents();
				}
				catch
				{
				}
			}
		}

		public void Clear()
		{
			this.GD.Clear(this.ClearColor);
			this.GH.Clear(this.ClearColor);
		}

		public void Clear(Color Color)
		{
			this.GD.Clear(Color);
			this.GH.Clear(Color);
		}

		public void Draw(Are Are)
		{
			Are.Draw(this.GD, this.GH);
		}

		public void Draw(Are Are, double Opacity)
		{
			Are.Draw(this.GD, this.GH, Opacity);
		}

		public void Draw(AreM AreM)
		{
			AreM.Draw(this.GD, this.GH);
		}

		public void Draw(AreM AreM, double Opacity)
		{
			AreM.Draw(this.GD, this.GH, Opacity);
		}

		public void CursorHide()
		{
			if (this.cur)
			{
				System.Windows.Forms.Cursor.Hide();
				this.cur = false;
			}
		}

		public void CursorShow()
		{
			if (!this.cur)
			{
				System.Windows.Forms.Cursor.Show();
				this.cur = true;
			}
		}

		public Vector2D CursorPosition
		{
			get
			{
				return this.ToBasePosition(this.baseControl.PointToClient(System.Windows.Forms.Cursor.Position));
			}
		}

		public void InvokeL(Action a)
		{
			this.baseControl.Invoke(a);
		}

		public Color GetUniqueColor()
		{
			Color color;
			Oth.GetRandomColor(out color);
			while (this.HitColors.Contains(color))
			{
				Oth.GetRandomColor(out color);
			}
			this.HitColors.Add(color);
			return color;
		}

		public void GetUniqueColor(out Color c)
		{
			Oth.GetRandomColor(out c);
			while (this.HitColors.Contains(c))
			{
				Oth.GetRandomColor(out c);
			}
			this.HitColors.Add(c);
		}

		public void SetUniqueColor(IEnumerable<Par> ps)
		{
			foreach (Par par in ps)
			{
				par.HitColor = this.GetUniqueColor();
			}
		}

		public void AddUniqueColor(Color Color)
		{
			this.HitColors.Add(Color);
		}

		public void AddUniqueColor(ref Color Color)
		{
			this.HitColors.Add(Color);
		}

		public void RemUniqueColor(Color Color)
		{
			this.HitColors.Remove(Color);
		}

		public void RemUniqueColor(ref Color Color)
		{
			this.HitColors.Remove(Color);
		}

		public void RemUniqueColor(IEnumerable<Par> ps)
		{
			foreach (Par par in ps)
			{
				this.HitColors.Remove(par.HitColor);
			}
		}

		public void ClearColors()
		{
			this.HitColors.Clear();
		}

		public void Dispose()
		{
			this.Drive = false;
			foreach (Mod mod in this.Modes.Values)
			{
				mod.Dispose();
			}
			this.BD.Dispose();
			this.GD.Dispose();
			this.BH.Dispose();
			this.GH.Dispose();
			this.Sce.Dispose();
		}

		[DllImport("user32.dll")]
		private static extern bool SetProcessDPIAware();

		[DllImport("user32.dll")]
		private static extern IntPtr GetWindowDC(IntPtr hwnd);

		[DllImport("gdi32.dll")]
		private static extern int GetDeviceCaps(IntPtr hdc, int index);

		[DllImport("user32.dll")]
		private static extern int ReleaseDC(IntPtr hwnd, IntPtr hdc);

		public static Point GetDpi()
		{
			Med.SetProcessDPIAware();
			IntPtr windowDC = Med.GetWindowDC(IntPtr.Zero);
			Point result = new Point(Med.GetDeviceCaps(windowDC, 88), Med.GetDeviceCaps(windowDC, 90));
			Med.ReleaseDC(IntPtr.Zero, windowDC);
			return result;
		}

		public static object obj = new object();

		private WPFImage baseControl;

		public double Unit = 1762.4;

		public Rec Base = new Rec(4.0, 3.0, 0.4);

		public double DisQuality = 1.0;

		public double HitAccuracy = 0.5;

		public Bitmap BD;

		public Graphics GD;

		public Bitmap BH;

		public Graphics GH;

		private Color ClearColor = Color.Transparent;

		public bool Drive = true;

		private Size BaseSize = Size.Empty;

		private double resMag = 1.0;

		private Vector2D resVector = Dat.Vec2DZero;

		private Sce Sce;

		private string mode;

		public string Modeb;

		private Dictionary<string, Mod> Modes;

		private Func<Med, Dictionary<string, Mod>> GetModes;

		private int WidthM;

		private int HeightM;

		public static double FPS = 60.0;

		public FPS FPSF = new FPS(Med.FPS);

		private bool cur = true;

		public HashSet<Color> HitColors = new HashSet<Color>
		{
			Color.Transparent,
			Color.Black
		};

		private const int LOGPIXELSX = 88;

		private const int LOGPIXELSY = 90;

		public static double dpiX;

		public static double dpiY;

		public static double DpiX;

		public static double DpiY;

		public string UITitle;

		public bool ShowFPS = false;
	}
}
