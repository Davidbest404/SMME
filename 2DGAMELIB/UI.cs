using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Forms;

namespace _2DGAMELIB
{
	public partial class UI : Form
	{
		public UI(Med Med)
		{
			this.InitializeComponent();
			if (File.Exists("Position.xml"))
			{
				this.Position = "Position.xml".FromXml<Point>();
			}
			this.Med = Med;
		}

		private void UI_Load(object sender, EventArgs e)
		{
			base.ClientSize = this.Med.Setting(this.wpfImage1);
			base.ClientSize = new Size(1024, 768);
			try
			{
				if (!File.Exists(this.ConfigPath))
				{
					this.BigWindow = false;
				}
				else
				{
					string[] source = this.ConfigPath.ReadLines();
					this.BigWindow = (source.First((string s) => s.StartsWith("BigWindow:")).Last<char>() == '1');
				}
			}
			catch
			{
				this.BigWindow = false;
			}
			if (this.BigWindow)
			{
				base.ClientSize = new Size(1280, 960);
			}
			this.UI_Resize(null, null);
			if (this.Position == Point.Empty)
			{
				this.Position = (Screen.PrimaryScreen.Bounds.Size.ToVector2D() * 0.5 - base.Size.ToVector2D() * 0.5).ToPoint();
			}
			base.Location = this.Position;
		}

		private void UI_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Med.Drive = false;
			this.Position.ToXml("Position.xml");
		}

		private void UI_Move(object sender, EventArgs e)
		{
			this.Position = base.Location;
		}

		private void UI_Resize(object sender, EventArgs e)
		{
			this.wpfImage1.ImageSetting();
			this.wpfImage1.Image.Width = (double)base.ClientSize.Width * Med.DpiX;
			this.wpfImage1.Image.Height = (double)base.ClientSize.Height * Med.DpiY;
		}

		private const string PositionSavePath = "Position.xml";

		private Point Position = Point.Empty;

		private Med Med;

		private string ConfigPath = Directory.GetCurrentDirectory() + "\\Config.ini";

		private bool BigWindow;
	}
}
