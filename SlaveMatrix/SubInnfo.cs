using System;
using System.Collections.Generic;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class SubInnfo
	{
		public SubInnfo(Med Med, 情報パネル ip)
		{
			this.Med = Med;
			this.ip = ip;
			string[] array = (Sta.CurrentDirectory + "\\text\\System\\SubInnfo.txt").FromText().Split(new char[]
			{
				','
			});
			List<string> list = (from e in array[0].Replace("\r", "").Split(new char[]
			{
				'\n'
			})
			where !string.IsNullOrWhiteSpace(e) && !e.StartsWith("//")
			select e).ToList<string>();
			list.Insert(0, "");
			this.メインフォ\u30FCム = list.ToArray();
			list = (from e in array[1].Replace("\r", "").Split(new char[]
			{
				'\n'
			})
			where !string.IsNullOrWhiteSpace(e) && !e.StartsWith("//")
			select e).ToList<string>();
			list.Insert(0, "");
			this.調教中継行 = list.ToArray();
			list = (from e in array[2].Replace("\r", "").Split(new char[]
			{
				'\n'
			})
			where !string.IsNullOrWhiteSpace(e) && !e.StartsWith("//")
			select e).ToList<string>();
			list.Insert(0, "");
			this.調教中継帰 = list.ToArray();
			list = (from e in array[3].Replace("\r", "").Split(new char[]
			{
				'\n'
			})
			where !string.IsNullOrWhiteSpace(e) && !e.StartsWith("//")
			select e).ToList<string>();
			list.Insert(0, "");
			this.休憩 = list.ToArray();
			list = (from e in array[4].Replace("\r", "").Split(new char[]
			{
				'\n'
			})
			where !string.IsNullOrWhiteSpace(e) && !e.StartsWith("//")
			select e).ToList<string>();
			list.Insert(0, "");
			this.事務所 = list.ToArray();
			list = (from e in array[5].Replace("\r", "").Split(new char[]
			{
				'\n'
			})
			where !string.IsNullOrWhiteSpace(e) && !e.StartsWith("//")
			select e).ToList<string>();
			list.Insert(0, "");
			this.奴隷購入 = list.ToArray();
			list = (from e in array[6].Replace("\r", "").Split(new char[]
			{
				'\n'
			})
			where !string.IsNullOrWhiteSpace(e) && !e.StartsWith("//")
			select e).ToList<string>();
			list.Insert(0, "");
			this.日数進行 = list.ToArray();
		}

		public void Set(bool bre)
		{
			if (bre)
			{
				this.ss = this.休憩;
			}
			else
			{
				string mode = this.Med.Mode;
				uint num = <PrivateImplementationDetails>.ComputeStringHash(mode);
				if (num <= 1342768649U)
				{
					if (num <= 258244062U)
					{
						if (num != 224776203U)
						{
							if (num == 258244062U)
							{
								if (mode == "日数進行")
								{
									this.ss = this.日数進行;
									goto IL_19D;
								}
							}
						}
						else if (mode == "事務所")
						{
							this.ss = this.事務所;
							goto IL_19D;
						}
					}
					else if (num != 940426623U)
					{
						if (num == 1342768649U)
						{
							if (mode == "調教中継帰")
							{
								this.ss = this.調教中継帰;
								goto IL_19D;
							}
						}
					}
					else if (mode == "奴隷購入")
					{
						this.ss = this.奴隷購入;
						goto IL_19D;
					}
				}
				else if (num <= 2574348160U)
				{
					if (num != 2021908077U)
					{
						if (num == 2574348160U)
						{
							if (mode == "対象")
							{
								this.ss = this.メインフォ\u30FCム;
								goto IL_19D;
							}
						}
					}
					else if (mode == "借金")
					{
						this.ss = this.事務所;
						goto IL_19D;
					}
				}
				else if (num != 3595923579U)
				{
					if (num == 3981639325U)
					{
						if (mode == "調教中継行")
						{
							this.ss = this.調教中継行;
							goto IL_19D;
						}
					}
				}
				else if (mode == "メインフォーム")
				{
					this.ss = this.メインフォ\u30FCム;
					goto IL_19D;
				}
				this.ss = null;
			}
			IL_19D:
			if (this.ss != null)
			{
				string text = this.ss[OthN.XS.Next(1, this.ss.Length)];
				while (text == this.ss[0])
				{
					text = this.ss[OthN.XS.Next(1, this.ss.Length)];
				}
				this.ss[0] = text;
				this.ip.SubInfo = text;
			}
		}

		private Med Med;

		private 情報パネル ip;

		private string[] ss;

		private string[] メインフォ\u30FCム;

		private string[] 調教中継行;

		private string[] 調教中継帰;

		private string[] 休憩;

		private string[] 事務所;

		private string[] 奴隷購入;

		private string[] 日数進行;
	}
}
