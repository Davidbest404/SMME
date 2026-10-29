using System;
using System.Collections.Generic;
using System.Windows.Forms;
using _2DGAMELIB;

namespace SlaveMatrix
{
	internal static class Program
	{
		[STAThread]
		private static void Main(string[] A_0)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Med med = new Med();
			med.UITitle = tex.スレイブマトリクス;
			med.Unit = 1101.5;
			double percent = 35.0;
			Sta.LoadConfig();
			if (Sta.HighQuality)
			{
				med.Unit = 2203.0;
			}
			if (Sta.BigWindow)
			{
				percent = 47.0;
				Program.biggerWindow = true;
			}
			if (Sta.FixInfo)
			{
				Program.fixInfo = true;
			}
			if (Sta.ShowFPS)
			{
				med.ShowFPS = true;
			}
			med.Base = new Rec(4.0, 3.0, percent.ToRate());
			med.DisQuality = 1.0;
			med.HitAccuracy = 0.3;
			med.InitializeModes("Start", new Func<Med, Dictionary<string, Mod>>(Mods.GetMods));
			new UI(med)
			{
				Text = tex.スレイブマトリクス
			}.Show();
			med.Drawing();
			if (Mods.t1 != null)
			{
				Mods.t1.Wait();
			}
			med.Dispose();
			Sta.Disposes();
			if (Sta.EditorButton)
			{
				MyC.EndStopper();
			}
		}

		public static bool biggerWindow;

		public static bool fixInfo;
	}
}
