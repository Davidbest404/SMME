using System;
using System.Media;
using SlaveMatrix.Properties;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public static class Sou
	{
		public static void 変更Play()
		{
			int num;
			do
			{
				OthN.XS.Next(3, out num);
			}
			while (Sou.o == num);
			Sou.o = num;
			switch (num)
			{
			case 0:
				Sou.変更1.Play();
				return;
			case 1:
				Sou.変更2.Play();
				return;
			case 2:
				Sou.変更3.Play();
				return;
			default:
				return;
			}
		}

		public static void Close()
		{
			Sou.日常BGM.Stop();
			Sou.日常BGM.Close();
			Sou.OPBGM.Stop();
			Sou.OPBGM.Close();
			Sou.操作.Stop();
			Sou.操作.Dispose();
			Sou.精算.Stop();
			Sou.精算.Dispose();
			Sou.完了.Stop();
			Sou.完了.Dispose();
			Sou.鞭撃.Stop();
			Sou.鞭撃.Dispose();
			Sou.弾け.Stop();
			Sou.弾け.Dispose();
			Sou.撮影.Stop();
			Sou.撮影.Dispose();
			Sou.祝福.Stop();
			Sou.祝福.Dispose();
			Sou.解除.Stop();
			Sou.解除.Dispose();
			Sou.変更1.Stop();
			Sou.変更1.Dispose();
			Sou.変更2.Stop();
			Sou.変更2.Dispose();
			Sou.変更3.Stop();
			Sou.変更3.Dispose();
			Sou.射精.Stop();
			Sou.射精.Dispose();
			Sou.放尿.Stop();
			Sou.放尿.Dispose();
			Sou.挿抜口1.Stop();
			Sou.挿抜口1.Dispose();
			Sou.挿抜口2.Stop();
			Sou.挿抜口2.Dispose();
			Sou.挿抜前1.Stop();
			Sou.挿抜前1.Dispose();
			Sou.挿抜前2.Stop();
			Sou.挿抜前2.Dispose();
			Sou.挿抜前3.Stop();
			Sou.挿抜前3.Dispose();
			Sou.挿抜前4.Stop();
			Sou.挿抜前4.Dispose();
			Sou.挿抜後1.Stop();
			Sou.挿抜後1.Dispose();
			Sou.挿抜後2.Stop();
			Sou.挿抜後2.Dispose();
			Sou.挿抜糸1.Stop();
			Sou.挿抜糸1.Dispose();
			Sou.挿抜糸2.Stop();
			Sou.挿抜糸2.Dispose();
		}

		public static _2DGAMELIB.SoundPlayer 日常BGM = new _2DGAMELIB.SoundPlayer(Sta.CurrentDirectory + "\\bgm\\game_maoudamashii_5_town10.wav", true);

		public static _2DGAMELIB.SoundPlayer OPBGM = new _2DGAMELIB.SoundPlayer(Sta.CurrentDirectory + "\\bgm\\bgm_maoudamashii_neorock60.wav", true);

		public static System.Media.SoundPlayer 操作 = new System.Media.SoundPlayer(Resources.se_maoudamashii_system40);

		public static System.Media.SoundPlayer 精算 = new System.Media.SoundPlayer(Resources.tm2r_coin06);

		public static System.Media.SoundPlayer 完了 = new System.Media.SoundPlayer(Resources.se_maoudamashii_onepoint12);

		public static System.Media.SoundPlayer 鞭撃 = new System.Media.SoundPlayer(Resources.teasi_naguru_keru06);

		public static System.Media.SoundPlayer 弾け = new System.Media.SoundPlayer(Resources.tm2r_crash25r);

		public static System.Media.SoundPlayer 撮影 = new System.Media.SoundPlayer(Resources.camera_shutter03);

		public static System.Media.SoundPlayer 祝福 = new System.Media.SoundPlayer(Resources.se_maoudamashii_onepoint09);

		public static System.Media.SoundPlayer 解除 = new System.Media.SoundPlayer(Resources.se_maoudamashii_onepoint07);

		public static System.Media.SoundPlayer 変更1 = new System.Media.SoundPlayer(Resources.keyholder);

		public static System.Media.SoundPlayer 変更2 = new System.Media.SoundPlayer(Resources.keyholder_catchsuru);

		public static System.Media.SoundPlayer 変更3 = new System.Media.SoundPlayer(Resources.keyholder_nigiru);

		public static System.Media.SoundPlayer 射精 = new System.Media.SoundPlayer(Resources.sei_ge_nukarumu01);

		public static System.Media.SoundPlayer 放尿 = new System.Media.SoundPlayer(Resources.near_a_brook_ex);

		public static System.Media.SoundPlayer 挿抜口1 = new System.Media.SoundPlayer(Resources.hito_ge_goku01);

		public static System.Media.SoundPlayer 挿抜口2 = new System.Media.SoundPlayer(Resources.hito_ge_goku02);

		public static System.Media.SoundPlayer 挿抜前1 = new System.Media.SoundPlayer(Resources.nukarumi1);

		public static System.Media.SoundPlayer 挿抜前2 = new System.Media.SoundPlayer(Resources.nukarumi2);

		public static System.Media.SoundPlayer 挿抜前3 = new System.Media.SoundPlayer(Resources.nukarumi3);

		public static System.Media.SoundPlayer 挿抜前4 = new System.Media.SoundPlayer(Resources.nukarumi6);

		public static System.Media.SoundPlayer 挿抜後1 = new System.Media.SoundPlayer(Resources.hito_ge_onara01);

		public static System.Media.SoundPlayer 挿抜後2 = new System.Media.SoundPlayer(Resources.hito_ge_haramusi07);

		public static System.Media.SoundPlayer 挿抜糸1 = new System.Media.SoundPlayer(Resources.nukarumi4);

		public static System.Media.SoundPlayer 挿抜糸2 = new System.Media.SoundPlayer(Resources.nukarumi5);

		private static int o = -1;
	}
}
