using System;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;

namespace _2DGAMELIB
{
	public class SoundPlayer2
	{
		public SoundPlayer2(string Path)
		{
			this.Path = Path;
		}

		public SoundPlayer2(Stream st)
		{
			this.st = st;
		}

		public void Play(AudioPlayMode apm)
		{
			if (this.Path != null)
			{
				this.mp.Play(this.Path, (AudioPlayMode)apm);
				return;
			}
			this.mp.Play(this.st, (AudioPlayMode)apm);
		}

		public void Stop()
		{
			this.mp.Stop();
			if (this.st != null)
			{
				this.st.Dispose();
			}
		}

		private Audio mp = new Audio();

		private string Path;

		private Stream st;
	}
}
