using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2DGAMELIB
{
	public static class MyC
	{
		public static void Setting()
		{
			MyC.tl = new TextLine();
			MyC.tl.Text = Process.GetCurrentProcess().ProcessName + " - Editor";
			MyC.tl.richTextBoxCustom1.Font = new Font(MyC.tl.richTextBoxCustom1.Font.FontFamily, 14f);
			MyC.tl.richTextBoxCustom1.ForeColor = Color.Black;
			MyC.tl.richTextBoxCustom1.BackColor = Color.White;
			MyC.tl.StartPosition = FormStartPosition.Manual;
			MyC.tl.Location = new Point(0, 0);
			MyC.tl.Width = 600;
			MyC.tl.Height = 500;
			MyC.tl.Show();
		}

		public static void Setting(Action Action)
		{
			MyC.Setting();
			Task.Factory.StartNew(delegate()
			{
				Action();
			});
			MyC.EndStopper();
		}

		public static bool TopMost
		{
			get
			{
				bool b = false;
				if (MyC.tl != null)
				{
					MyC.tl.Invoke(new MethodInvoker(delegate()
					{
						b = MyC.tl.TopMost;
					}));
				}
				return b;
			}
			set
			{
				if (MyC.tl != null)
				{
					MyC.tl.Invoke(new MethodInvoker(delegate()
					{
						MyC.tl.TopMost = value;
					}));
				}
			}
		}

		public static Point Location
		{
			get
			{
				Point p = Point.Empty;
				if (MyC.tl != null)
				{
					MyC.tl.Invoke(new MethodInvoker(delegate()
					{
						p = MyC.tl.Location;
					}));
				}
				return p;
			}
			set
			{
				if (MyC.tl != null)
				{
					MyC.tl.Invoke(new MethodInvoker(delegate()
					{
						MyC.tl.Location = value;
					}));
				}
			}
		}

		public static Size Size
		{
			get
			{
				Size s = Size.Empty;
				if (MyC.tl != null)
				{
					MyC.tl.Invoke(new MethodInvoker(delegate()
					{
						s = MyC.tl.Size;
					}));
				}
				return s;
			}
			set
			{
				if (MyC.tl != null)
				{
					MyC.tl.Invoke(new MethodInvoker(delegate()
					{
						MyC.tl.Size = value;
					}));
				}
			}
		}

		public static Rectangle Bounds
		{
			get
			{
				Rectangle r = Rectangle.Empty;
				if (MyC.tl != null)
				{
					MyC.tl.Invoke(new MethodInvoker(delegate()
					{
						r = MyC.tl.Bounds;
					}));
				}
				return r;
			}
			set
			{
				if (MyC.tl != null)
				{
					MyC.tl.Invoke(new MethodInvoker(delegate()
					{
						MyC.tl.Bounds = value;
					}));
				}
			}
		}

		public static string Text
		{
			get
			{
				string str = "";
				if (MyC.tl != null)
				{
					MyC.tl.Invoke(new MethodInvoker(delegate()
					{
						str = MyC.tl.richTextBoxCustom1.Text;
					}));
				}
				return str;
			}
			set
			{
				if (MyC.tl != null)
				{
					MyC.tl.Invoke(new MethodInvoker(delegate()
					{
						MyC.tl.richTextBoxCustom1.Text = value;
					}));
				}
			}
		}

		public static void ToConsole(this object obj)
		{
			string text = obj.ToStrings<object>();
			if (obj != null)
			{
				Type type = obj.GetType();
				if (type != typeof(string))
				{
					if (type.GetInterfaces().Any((Type t) => t.Name.Contains("IEnumerable")))
					{
						text = text.Fairing();
					}
				}
			}
			MyC.ToConsoleOri(text);
		}

		private static void ToConsoleOri(object obj)
		{
			try
			{
				if (MyC.tl != null)
				{
					MyC.tl.Invoke(new MethodInvoker(delegate()
					{
						MyC.StopDrawing();
						RichTextBoxEx richTextBoxCustom = MyC.tl.richTextBoxCustom1;
						richTextBoxCustom.Text = richTextBoxCustom.Text + obj + "\n";
						MyC.tl.richTextBoxCustom1.Select(MyC.tl.richTextBoxCustom1.TextLength, 0);
						MyC.tl.richTextBoxCustom1.ScrollToCaret();
						MyC.DrawingResume();
					}));
				}
			}
			catch
			{
			}
		}

		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

		public static void StopDrawing()
		{
			MyC.SendMessage(MyC.tl.richTextBoxCustom1.Handle, 11, 0, 0);
		}

		public static void DrawingResume()
		{
			MyC.SendMessage(MyC.tl.richTextBoxCustom1.Handle, 11, 1, 0);
			MyC.tl.richTextBoxCustom1.Refresh();
		}

		public static void DriveConfirmation()
		{
			if (MyC.tl != null)
			{
				MyC.tl.Invoke(new MethodInvoker(delegate()
				{
					char c = MyC.tl.Text.Last<char>();
					if (c <= '―')
					{
						if (c == '|')
						{
							MyC.tl.Text = MyC.tl.Text.Replace(" |", " ／");
							return;
						}
						if (c == '―')
						{
							MyC.tl.Text = MyC.tl.Text.Replace(" ―", " ＼");
							return;
						}
					}
					else
					{
						if (c == '／')
						{
							MyC.tl.Text = MyC.tl.Text.Replace(" ／", " ―");
							return;
						}
						if (c == '＼')
						{
							MyC.tl.Text = MyC.tl.Text.Replace(" ＼", " |");
							return;
						}
					}
					TextLine textLine = MyC.tl;
					textLine.Text += " ―";
				}));
			}
		}

		public static void EndStopper()
		{
			if (MyC.tl != null)
			{
				MyC.tl.Invoke(new MethodInvoker(delegate()
				{
					while (MyC.tl.Visible)
					{
						Application.DoEvents();
						Thread.Sleep(1);
					}
				}));
			}
		}

		public static void Close()
		{
			if (MyC.tl != null)
			{
				MyC.tl.Invoke(new MethodInvoker(delegate()
				{
					MyC.tl.Close();
				}));
			}
		}

		public static TextLine tl;

		public const int WM_SETREDRAW = 11;

		public const int Win32False = 0;

		public const int Win32True = 1;
	}
}
