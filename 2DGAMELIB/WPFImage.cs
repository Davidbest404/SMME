using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms.Integration;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace _2DGAMELIB
{
	public class WPFImage : ElementHost
	{
		public System.Windows.Controls.Image Image
		{
			get
			{
				return (System.Windows.Controls.Image)base.Child;
			}
		}

		public WPFImage()
		{
			System.Windows.Controls.Image child = new System.Windows.Controls.Image
			{
				Stretch = Stretch.Uniform
			};
			base.Child = child;
		}

		public void ImageSetting()
		{
			try
			{
				if (!File.Exists(this.ConfigPath))
				{
					this.HighQuality = false;
				}
				else
				{
					string[] source = this.ConfigPath.ReadLines();
					this.HighQuality = (source.First((string s) => s.StartsWith("AntiAliasing:")).Last<char>() == '1');
				}
			}
			catch
			{
				this.HighQuality = false;
			}
			if (this.HighQuality)
			{
				RenderOptions.SetBitmapScalingMode(this.Image, BitmapScalingMode.LowQuality);
			}
			else
			{
				RenderOptions.SetBitmapScalingMode(this.Image, BitmapScalingMode.NearestNeighbor);
			}
			RenderOptions.SetEdgeMode(this.Image, EdgeMode.Aliased);
		}

		public void SetBitmap(Bitmap bmp)
		{
			this.data = bmp.LockBits(this.rect1, ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
			this.wb.Lock();
			WPFImage.CopyMemory(this.wb.BackBuffer, this.data.Scan0, this.ByteSize);
			this.wb.AddDirtyRect(this.rect2);
			this.wb.Unlock();
			bmp.UnlockBits(this.data);
		}

		public void BitmapSetting(Bitmap bmp)
		{
			int width = bmp.Width;
			int height = bmp.Height;
			this.rect1 = new Rectangle(0, 0, width, height);
			this.rect2 = new Int32Rect(0, 0, width, height);
			this.wb = new WriteableBitmap(width, height, (double)bmp.HorizontalResolution, (double)bmp.VerticalResolution, PixelFormats.Bgra32, null);
			this.ByteSize = this.wb.BackBufferStride * height;
			this.Image.Source = this.wb;
		}

		[DllImport("Kernel32.dll")]
		public static extern void CopyMemory(IntPtr Destination, IntPtr Source, int ByteSize);

		private int ByteSize;

		private Rectangle rect1;

		private Int32Rect rect2;

		private BitmapData data;

		public WriteableBitmap wb;

		private bool HighQuality;

		private string ConfigPath = Directory.GetCurrentDirectory() + "\\Config.ini";
	}
}
