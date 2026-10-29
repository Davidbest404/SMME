using System;
using System.Windows.Media;

namespace _2DGAMELIB
{
	public class SoundPlayer
	{
		public SoundPlayer(string Path)
		{
			this.mp.Open(new Uri(Path));
			this.mp.Volume = 1.0;
		}

		public SoundPlayer(string Path, bool Loop)
		{
			this.mp.Open(new Uri(Path));
			this.Loop = Loop;
			this.mp.Volume = 1.0;
		}

		public bool Loop
		{
			get
			{
				return this.l;
			}
			set
			{
				if (value)
				{
					if (this.l != value)
					{
						this.mp.MediaEnded += this.loop;
					}
				}
				else if (this.l != value)
				{
					this.mp.MediaEnded -= this.loop;
				}
				this.l = value;
			}
		}

		private void loop(object s, EventArgs e)
		{
			this.mp.Position = this.ts;
			this.mp.Play();
		}

		public void Play()
		{
			this.mp.Play();
		}

		public void Stop()
		{
			this.mp.Stop();
		}

		public void Pause()
		{
			this.mp.Pause();
		}

		public void Close()
		{
			this.mp.Close();
		}

		public MediaPlayer mp = new MediaPlayer();

		private bool l;

		private TimeSpan ts = new TimeSpan(0L);
	}
}
