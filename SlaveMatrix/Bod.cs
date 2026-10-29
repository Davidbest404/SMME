using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class Bod
	{
		public void スタンプClear()
		{
			スタンプK[] キスマ_u30FCク = this.キスマ\u30FCク;
			for (int i = 0; i < キスマ_u30FCク.Length; i++)
			{
				キスマ_u30FCク[i].Clear();
			}
			スタンプW[] array = this.鞭痕;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Clear();
			}
			this.ぶっかけ小.Clear();
			this.ぶっかけ大.Clear();
		}

		public void スタンプ脚Clear()
		{
			スタンプK[] キスマ_u30FCク = this.キスマ\u30FCク;
			for (int i = 0; i < キスマ_u30FCク.Length; i++)
			{
				キスマ_u30FCク[i].脚Clear();
			}
			スタンプW[] array = this.鞭痕;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].脚Clear();
			}
			this.ぶっかけ小.Clear();
			this.ぶっかけ大.Clear();
		}

		public void Sort(IEnumerable<Ele> ar, List<Ele> li)
		{
			foreach (Ele ele in ar)
			{
				int num;
				if ((num = li.IndexOf(ele.Par)) > -1)
				{
					li.Insert(num + ele.描画前後, ele);
				}
				else
				{
					li.Add(ele);
				}
			}
		}

		public Bod(Med Med, Are Are, Cha Cha)
		{
			Bod.<>c__DisplayClass258_0 CS$<>8__locals1 = new Bod.<>c__DisplayClass258_0();
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.Are = Are;
			CS$<>8__locals1.Cha = Cha;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.Med = CS$<>8__locals1.Med;
			this.Cha = CS$<>8__locals1.Cha;
			double disUnit = CS$<>8__locals1.Are.DisUnit;
			this.腰 = (腰)CS$<>8__locals1.Cha.ChaD.構成.GetEle(disUnit, CS$<>8__locals1.Med, CS$<>8__locals1.Cha.配色);
			this.全要素 = this.腰.EnumEle().ToArray<Ele>();
			List<スタンプK> sk = new List<スタンプK>();
			List<スタンプW> sw = new List<スタンプW>();
			キスマ\u30FCクD kd = new キスマ\u30FCクD
			{
				濃度 = 0.0
			};
			鞭痕D wd = new 鞭痕D();
			this.蝙通常 = new List<蝙通常>();
			腕獣 腕獣;
			腿_人 人腿;
			脚人 脚人;
			脚獣 脚獣;
			腕翼鳥 腕翼鳥;
			肩 人肩;
			腕翼獣 腕翼獣;
			腕人 腕人;
			翼鳥 翼鳥;
			翼獣 翼獣;
			Ele p;
			Ele pp;
			Action<獣手> <>9__83;
			Action<獣下腕> <>9__82;
			Action<獣上腕> <>9__64;
			Action<足_人> <>9__84;
			Action<脚_人> <>9__65;
			Action<獣足> <>9__85;
			Action<獣脚> <>9__66;
			Action<獣足> <>9__67;
			Action<手_鳥> <>9__87;
			Action<下腕_鳥> <>9__86;
			Action<上腕_鳥> <>9__68;
			Action<上腕_蝙> <>9__69;
			Action<上腕_人> <>9__70;
			Action<手_鳥> <>9__94;
			Action<下腕_鳥> <>9__71;
			Func<Vector2D> <>9__103;
			Action<下腕_蝙> <>9__72;
			Action<獣手> <>9__105;
			Action<獣下腕> <>9__104;
			Action<獣上腕> <>9__73;
			Action<足_人> <>9__106;
			Action<脚_人> <>9__74;
			Action<獣足> <>9__107;
			Action<獣脚> <>9__75;
			Action<獣足> <>9__76;
			Action<手_鳥> <>9__109;
			Action<下腕_鳥> <>9__108;
			Action<上腕_鳥> <>9__77;
			Action<上腕_蝙> <>9__78;
			Action<上腕_人> <>9__79;
			Action<手_鳥> <>9__116;
			Action<下腕_鳥> <>9__80;
			Func<Vector2D> <>9__125;
			Action<下腕_蝙> <>9__81;
			foreach (Ele ele in this.全要素.Reverse<Ele>())
			{
				foreach (FieldInfo fieldInfo in ele.ThisType.GetFields())
				{
					if (fieldInfo.FieldType.ToString() == Sta.拘束鎖t)
					{
						((拘束鎖)fieldInfo.GetValue(ele)).SetSize();
					}
				}
				if (ele is 角2_鬼 && ele.接続情報 != 接続情報.基髪_頭頂左_接続 && ele.接続情報 != 接続情報.基髪_頭頂右_接続)
				{
					((角2_鬼)ele).SetBasePoint();
				}
				foreach (Par par in ele.本体.EnumAllPar())
				{
					if (par.Tag.Contains("ハイライト"))
					{
						par.Hit = false;
					}
				}
				if (ele.右)
				{
					if (ele is 肩)
					{
						人肩 = (肩)ele;
						人肩.キスマ\u30FCク = new スタンプK(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, this, kd, 人肩);
						sk.Add(人肩.キスマ\u30FCク);
						人肩.鞭痕 = new スタンプW(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, this, wd, 人肩);
						sw.Add(人肩.鞭痕);
					}
					else if (ele is 四足脇)
					{
						四足脇 四足脇 = (四足脇)ele;
						if (this.腕獣右.Count > 0)
						{
							ele.表示 = false;
						}
						腕獣 = default(腕獣);
						腕獣.肩 = 四足脇;
						IEnumerable<Ele> 上腕_接続 = 四足脇.上腕_接続;
						Action<獣上腕> a19;
						if ((a19 = <>9__64) == null)
						{
							Ele 下腕;
							a19 = (<>9__64 = delegate(獣上腕 上腕)
							{
								腕獣.上腕 = 上腕;
								IEnumerable<Ele> 下腕_接続5 = 上腕.下腕_接続;
								Action<獣下腕> a20;
								if ((a20 = <>9__82) == null)
								{
									a20 = (<>9__82 = delegate(獣下腕 下腕)
									{
										腕獣.下腕 = 下腕;
										IEnumerable<Ele> 手_接続 = 下腕.手_接続;
										Action<獣手> a21;
										if ((a21 = <>9__83) == null)
										{
											a21 = (<>9__83 = delegate(獣手 手)
											{
												腕獣.手 = 手;
											});
										}
										手_接続.SetEle(a21);
									});
								}
								下腕_接続5.SetEle(a20);
							});
						}
						上腕_接続.SetEle(a19);
						this.腕獣右.Add(腕獣);
					}
					else if (ele is 腿_人)
					{
						人腿 = (腿_人)ele;
						人腿.キスマ\u30FCク = new スタンプK(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, this, kd, 人腿);
						sk.Add(人腿.キスマ\u30FCク);
						人腿.鞭痕 = new スタンプW(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, this, wd, 人腿);
						sw.Add(人腿.鞭痕);
						脚人 = default(脚人);
						脚人.腿 = 人腿;
						IEnumerable<Ele> 脚_接続 = 人腿.脚_接続;
						Action<脚_人> a2;
						if ((a2 = <>9__65) == null)
						{
							a2 = (<>9__65 = delegate(脚_人 脚)
							{
								脚.キスマ\u30FCク = new スタンプK(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, CS$<>8__locals1.<>4__this, kd, 脚);
								sk.Add(脚.キスマ\u30FCク);
								脚.鞭痕 = new スタンプW(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, CS$<>8__locals1.<>4__this, wd, 脚);
								sw.Add(脚.鞭痕);
								if (!人腿.X0Y0_腿.OP[0].Outline)
								{
									人腿.腿0CD.c2.Col2 = 脚.脚CD.c2.Col1;
									人腿.腿1CD.c2.Col2 = 脚.脚CD.c2.Col1;
									人腿.腿2CD.c2.Col1 = 脚.脚CD.c2.Col1;
									人腿.腿3CD.c2.Col1 = 脚.脚CD.c2.Col1;
									人腿.腿4CD.c2.Col1 = 脚.脚CD.c2.Col1;
								}
								脚人.脚 = 脚;
								IEnumerable<Ele> 足_接続3 = 脚.足_接続;
								Action<足_人> a20;
								if ((a20 = <>9__84) == null)
								{
									a20 = (<>9__84 = delegate(足_人 足)
									{
										足.キスマ\u30FCク = new スタンプK(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, CS$<>8__locals1.<>4__this, kd, 足);
										sk.Add(足.キスマ\u30FCク);
										足.鞭痕 = new スタンプW(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, CS$<>8__locals1.<>4__this, wd, 足);
										sw.Add(足.鞭痕);
										脚人.足 = 足;
									});
								}
								足_接続3.SetEle(a20);
							});
						}
						脚_接続.SetEle(a2);
						this.脚人右.Add(脚人);
					}
					else if (ele is 獣腿)
					{
						獣腿 獣腿 = (獣腿)ele;
						脚獣 = default(脚獣);
						脚獣.腿 = 獣腿;
						IEnumerable<Ele> 脚_接続2 = 獣腿.脚_接続;
						Action<獣脚> a3;
						if ((a3 = <>9__66) == null)
						{
							a3 = (<>9__66 = delegate(獣脚 脚)
							{
								脚獣.脚 = 脚;
								IEnumerable<Ele> 足_接続3 = 脚.足_接続;
								Action<獣足> a20;
								if ((a20 = <>9__85) == null)
								{
									a20 = (<>9__85 = delegate(獣足 足)
									{
										脚獣.足 = 足;
									});
								}
								足_接続3.SetEle(a20);
							});
						}
						脚_接続2.SetEle(a3);
						this.脚獣右.Add(脚獣);
						if (獣腿.接続情報 == 接続情報.腰_腿右_接続)
						{
							if (ele is 腿_獣)
							{
								腿_獣 腿_獣 = (腿_獣)獣腿;
								腿_獣.腿CD.c2.Col1 = CS$<>8__locals1.Cha.配色.毛0O.Col1;
								腿_獣.腿CD.c2.Col2 = CS$<>8__locals1.Cha.配色.人肌O.Col2;
								腿_獣.筋CD.c2.Col1 = CS$<>8__locals1.Cha.配色.毛0O.Col1;
								腿_獣.筋CD.c2.Col2 = CS$<>8__locals1.Cha.配色.人肌O.Col2;
							}
							if (ele is 腿_蹄)
							{
								腿_蹄 腿_蹄 = (腿_蹄)獣腿;
								腿_蹄.腿CD.c2.Col1 = CS$<>8__locals1.Cha.配色.毛0O.Col1;
								腿_蹄.腿CD.c2.Col2 = CS$<>8__locals1.Cha.配色.人肌O.Col2;
								腿_蹄.筋CD.c2.Col1 = CS$<>8__locals1.Cha.配色.毛0O.Col1;
								腿_蹄.筋CD.c2.Col2 = CS$<>8__locals1.Cha.配色.人肌O.Col2;
							}
							if (ele is 腿_竜)
							{
								腿_竜 腿_竜 = (腿_竜)獣腿;
								腿_竜.腿CD.c2.Col1 = CS$<>8__locals1.Cha.配色.毛0O.Col1;
								腿_竜.腿CD.c2.Col2 = CS$<>8__locals1.Cha.配色.人肌O.Col2;
								腿_竜.筋CD.c2.Col1 = CS$<>8__locals1.Cha.配色.毛0O.Col1;
								腿_竜.筋CD.c2.Col2 = CS$<>8__locals1.Cha.配色.人肌O.Col2;
							}
							if (ele is 腿_鳥)
							{
								腿_鳥 腿_鳥 = (腿_鳥)獣腿;
								腿_鳥.腿CD.c2.Col1 = CS$<>8__locals1.Cha.配色.毛0O.Col1;
								腿_鳥.腿CD.c2.Col2 = CS$<>8__locals1.Cha.配色.人肌O.Col2;
								腿_鳥.筋CD.c2.Col1 = CS$<>8__locals1.Cha.配色.毛0O.Col1;
								腿_鳥.筋CD.c2.Col2 = CS$<>8__locals1.Cha.配色.人肌O.Col2;
							}
						}
					}
					else if (ele is 獣脚 && ele.Par is 四足脇)
					{
						脚獣 = default(脚獣);
						脚獣.腿 = null;
						脚獣.脚 = (獣脚)ele;
						IEnumerable<Ele> 足_接続 = 脚獣.脚.足_接続;
						Action<獣足> a4;
						if ((a4 = <>9__67) == null)
						{
							a4 = (<>9__67 = delegate(獣足 足)
							{
								脚獣.足 = 足;
							});
						}
						足_接続.SetEle(a4);
						this.脚獣右.Add(脚獣);
					}
					else if (ele is 上腕)
					{
						if (ele.接続情報 == 接続情報.肩_上腕_接続)
						{
							人肩 = (肩)ele.Par;
							if (ele is 上腕_鳥)
							{
								腕翼鳥 = default(腕翼鳥);
								腕翼鳥.肩 = 人肩;
								IEnumerable<Ele> 上腕_接続2 = 人肩.上腕_接続;
								Action<上腕_鳥> a5;
								if ((a5 = <>9__68) == null)
								{
									Ele 下腕;
									a5 = (<>9__68 = delegate(上腕_鳥 上腕)
									{
										上腕.キスマ\u30FCク = new スタンプK(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, CS$<>8__locals1.<>4__this, kd, 上腕);
										sk.Add(上腕.キスマ\u30FCク);
										上腕.鞭痕 = new スタンプW(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, CS$<>8__locals1.<>4__this, wd, 上腕);
										sw.Add(上腕.鞭痕);
										上腕.鳥翼上腕CD.c2.Col2 = 上腕.小雨覆CD.c2.Col1;
										腕翼鳥.上腕 = 上腕;
										IEnumerable<Ele> 下腕_接続5 = 上腕.下腕_接続;
										Action<下腕_鳥> a20;
										if ((a20 = <>9__86) == null)
										{
											a20 = (<>9__86 = delegate(下腕_鳥 下腕)
											{
												腕翼鳥.下腕 = 下腕;
												IEnumerable<Ele> 手_接続 = 下腕.手_接続;
												Action<手_鳥> a21;
												if ((a21 = <>9__87) == null)
												{
													a21 = (<>9__87 = delegate(手_鳥 手)
													{
														腕翼鳥.手 = 手;
													});
												}
												手_接続.SetEle(a21);
											});
										}
										下腕_接続5.SetEle(a20);
									});
								}
								上腕_接続2.SetEle(a5);
								this.腕翼鳥右.Add(腕翼鳥);
							}
							else if (ele is 上腕_蝙)
							{
								腕翼獣 = default(腕翼獣);
								腕翼獣.肩 = 人肩;
								IEnumerable<Ele> 上腕_接続3 = 人肩.上腕_接続;
								Action<上腕_蝙> a6;
								if ((a6 = <>9__69) == null)
								{
									Ele 下腕;
									a6 = (<>9__69 = delegate(上腕_蝙 上腕)
									{
										上腕.獣翼上腕CD.c2.Col1 = 人肩.肩_肩CD.c2.Col1;
										腕翼獣.上腕 = 上腕;
										上腕.下腕_接続.SetEle(delegate(下腕_蝙 下腕)
										{
											腕翼獣.下腕 = 下腕;
											下腕.手_接続.SetEle(delegate(手_蝙 手)
											{
												腕翼獣.手 = 手;
												上腕_蝙 上腕 = 上腕;
												Func<Vector2D> 接着;
												if ((接着 = CS$<>8__locals1.<>9__90) == null)
												{
													接着 = (CS$<>8__locals1.<>9__90 = (() => CS$<>8__locals1.<>4__this.腰.X0Y0_腰.ToGlobal(CS$<>8__locals1.<>4__this.腰.X0Y0_腰.BasePointBase)));
												}
												上腕.接着 = 接着;
												CS$<>8__locals1.<>4__this.蝙通常.Add(new 蝙通常(上腕, 下腕, 手));
											});
										});
									});
								}
								上腕_接続3.SetEle(a6);
								this.腕翼獣右.Add(腕翼獣);
							}
							else
							{
								腕人 = default(腕人);
								腕人.肩 = 人肩;
								IEnumerable<Ele> 上腕_接続4 = 人肩.上腕_接続;
								Action<上腕_人> a7;
								if ((a7 = <>9__70) == null)
								{
									Ele 下腕;
									a7 = (<>9__70 = delegate(上腕_人 上腕)
									{
										上腕.キスマ\u30FCク = new スタンプK(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, CS$<>8__locals1.<>4__this, kd, 上腕);
										sk.Add(上腕.キスマ\u30FCク);
										上腕.鞭痕 = new スタンプW(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, CS$<>8__locals1.<>4__this, wd, 上腕);
										sw.Add(上腕.鞭痕);
										腕人.上腕 = 上腕;
										上腕.下腕_接続.SetEle(delegate(下腕_人 下腕)
										{
											下腕.腕輪尺度修正();
											下腕.キスマ\u30FCク = new スタンプK(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, CS$<>8__locals1.<>4__this, kd, 下腕);
											sk.Add(下腕.キスマ\u30FCク);
											下腕.鞭痕 = new スタンプW(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, CS$<>8__locals1.<>4__this, wd, 下腕);
											sw.Add(下腕.鞭痕);
											if (上腕.獣性_獣毛1_表示)
											{
												下腕.下腕CD.c2 = 上腕.獣性_獣毛1CD.c2;
												下腕.筋肉_筋肉上CD.c2 = 上腕.獣性_獣毛1CD.c2;
												下腕.筋肉_筋肉下CD.c2 = 上腕.獣性_獣毛1CD.c2;
											}
											if (上腕.虫性_虫腕_表示 && (!下腕.虫性1_虫腕上_表示 || !下腕.虫性2_虫腕下_表示))
											{
												下腕.下腕CD.c2 = 上腕.虫性_虫腕CD.c2;
												下腕.筋肉_筋肉上CD.c2 = 上腕.虫性_虫腕CD.c2;
												下腕.筋肉_筋肉下CD.c2 = 上腕.虫性_虫腕CD.c2;
											}
											if (下腕.植性2_萼_萼中_表示)
											{
												上腕.上腕CD.c2.Col2 = 下腕.植性2_萼_萼中CD.c2.Col2;
												上腕.筋肉上CD.c2.Col2 = 下腕.植性2_萼_萼中CD.c2.Col2;
												上腕.筋肉下CD.c2.Col2 = 下腕.植性2_萼_萼中CD.c2.Col2;
											}
											else if (下腕.獣性1_獣腕_表示)
											{
												上腕.上腕CD.c2.Col2 = 下腕.獣性1_獣腕CD.c2.Col1;
												上腕.筋肉上CD.c2.Col2 = 下腕.獣性1_獣腕CD.c2.Col1;
												上腕.筋肉下CD.c2.Col2 = 下腕.獣性1_獣腕CD.c2.Col1;
											}
											else
											{
												上腕.上腕CD.c2.Col2 = 下腕.下腕CD.c2.Col1;
												上腕.筋肉上CD.c2.Col2 = 下腕.下腕CD.c2.Col1;
												上腕.筋肉下CD.c2.Col2 = 下腕.下腕CD.c2.Col1;
											}
											腕人.下腕 = 下腕;
											下腕.手_接続.SetEle(delegate(手_人 手)
											{
												if (下腕.獣性1_獣腕_表示 || 下腕.下腕CD.c2.Col1 == 下腕.獣性1_獣腕CD.c2.Col1)
												{
													手.手CD.c2 = 下腕.獣性1_獣腕CD.c2;
													手.親指_親指1CD.c2 = 手.手CD.c2;
												}
												else if (手.X0Y0_手.OP[6].Outline)
												{
													手.手CD.c2 = 下腕.虫性1_虫腕上CD.c2;
													手.親指_親指1CD.c2 = 手.手CD.c2;
												}
												腕人.手 = 手;
											});
										});
										上腕.下腕_接続.SetEle(delegate(下腕_獣 下腕)
										{
											上腕.上腕CD.c2.Col2 = 下腕.下腕CD.c2.Col1;
											上腕.筋肉上CD.c2.Col2 = 下腕.下腕CD.c2.Col1;
											上腕.筋肉下CD.c2.Col2 = 下腕.下腕CD.c2.Col1;
											下腕.X0Y0_下腕.OP[6].Outline = true;
										});
									});
								}
								上腕_接続4.SetEle(a7);
								this.腕人右.Add(腕人);
							}
						}
						else if (ele is 上腕_鳥)
						{
							翼鳥 = default(翼鳥);
							翼鳥.上腕 = (上腕_鳥)ele;
							翼鳥.上腕.鳥翼上腕CD.c2 = 翼鳥.上腕.小雨覆CD.c2;
							翼鳥.上腕.キスマ\u30FCク = new スタンプK(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, this, kd, 翼鳥.上腕);
							sk.Add(翼鳥.上腕.キスマ\u30FCク);
							翼鳥.上腕.鞭痕 = new スタンプW(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, this, wd, 翼鳥.上腕);
							sw.Add(翼鳥.上腕.鞭痕);
							IEnumerable<Ele> 下腕_接続 = 翼鳥.上腕.下腕_接続;
							Action<下腕_鳥> a8;
							if ((a8 = <>9__71) == null)
							{
								Ele 下腕;
								a8 = (<>9__71 = delegate(下腕_鳥 下腕)
								{
									翼鳥.下腕 = 下腕;
									IEnumerable<Ele> 手_接続 = 下腕.手_接続;
									Action<手_鳥> a20;
									if ((a20 = <>9__94) == null)
									{
										a20 = (<>9__94 = delegate(手_鳥 手)
										{
											翼鳥.手 = 手;
										});
									}
									手_接続.SetEle(a20);
								});
							}
							下腕_接続.SetEle(a8);
							this.翼鳥右.Add(翼鳥);
						}
						else if (ele is 上腕_蝙)
						{
							翼獣 = default(翼獣);
							翼獣.上腕 = (上腕_蝙)ele;
							IEnumerable<Ele> 下腕_接続2 = 翼獣.上腕.下腕_接続;
							Action<下腕_蝙> a9;
							if ((a9 = <>9__72) == null)
							{
								Ele 下腕;
								a9 = (<>9__72 = delegate(下腕_蝙 下腕)
								{
									翼獣.下腕 = 下腕;
									下腕.手_接続.SetEle(delegate(手_蝙 手)
									{
										翼獣.手 = 手;
										p = 翼獣.上腕.Par;
										pp = 翼獣.上腕.Par.Par;
										if (p is 基髪)
										{
											上腕_蝙 上腕 = 翼獣.上腕;
											Func<Vector2D> 接着;
											if ((接着 = CS$<>8__locals1.<>9__96) == null)
											{
												接着 = (CS$<>8__locals1.<>9__96 = (() => CS$<>8__locals1.<>4__this.頭.X0Y0_頭.ToGlobal(CS$<>8__locals1.<>4__this.頭.X0Y0_頭.BasePointBase)));
											}
											上腕.接着 = 接着;
										}
										else if (p is 胸)
										{
											上腕_蝙 上腕2 = 翼獣.上腕;
											Func<Vector2D> 接着2;
											if ((接着2 = CS$<>8__locals1.<>9__97) == null)
											{
												接着2 = (CS$<>8__locals1.<>9__97 = (() => CS$<>8__locals1.<>4__this.胴.X0Y0_胴.ToGlobal(CS$<>8__locals1.<>4__this.胴.X0Y0_胴.BasePointBase)));
											}
											上腕2.接着 = 接着2;
										}
										else if (p is 胴 || p is 腰)
										{
											上腕_蝙 上腕3 = 翼獣.上腕;
											Func<Vector2D> 接着3;
											if ((接着3 = CS$<>8__locals1.<>9__98) == null)
											{
												接着3 = (CS$<>8__locals1.<>9__98 = (() => CS$<>8__locals1.<>4__this.腰.X0Y0_腰.ToGlobal(CS$<>8__locals1.<>4__this.腰.X0Y0_腰.JP[4].Joint)));
											}
											上腕3.接着 = 接着3;
										}
										else if (p is 四足胸)
										{
											上腕_蝙 上腕4 = 翼獣.上腕;
											Func<Vector2D> 接着4;
											if ((接着4 = CS$<>8__locals1.<>9__99) == null)
											{
												接着4 = (CS$<>8__locals1.<>9__99 = (() => CS$<>8__locals1.<>4__this.胴_獣.X0Y0_胴.ToGlobal(CS$<>8__locals1.<>4__this.胴_獣.X0Y0_胴.BasePointBase)));
											}
											上腕4.接着 = 接着4;
										}
										else if ((p is 四足胴 || p is 四足腰) && (翼獣.上腕.接続情報 == 接続情報.四足腰_翼左_接続 || 翼獣.上腕.接続情報 == 接続情報.四足腰_翼右_接続))
										{
											上腕_蝙 上腕5 = 翼獣.上腕;
											Func<Vector2D> 接着5;
											if ((接着5 = CS$<>8__locals1.<>9__100) == null)
											{
												接着5 = (CS$<>8__locals1.<>9__100 = (() => CS$<>8__locals1.<>4__this.腰_獣.X0Y0_腰.ToGlobal(CS$<>8__locals1.<>4__this.腰.X0Y0_腰.JP[4].Joint)));
											}
											上腕5.接着 = 接着5;
										}
										else if (pp != null && pp is 胸)
										{
											上腕_蝙 上腕6 = 翼獣.上腕;
											Func<Vector2D> 接着6;
											if ((接着6 = CS$<>8__locals1.<>9__101) == null)
											{
												接着6 = (CS$<>8__locals1.<>9__101 = (() => CS$<>8__locals1.<>4__this.腰.X0Y0_腰.ToGlobal(CS$<>8__locals1.<>4__this.腰.X0Y0_腰.BasePointBase)));
											}
											上腕6.接着 = 接着6;
										}
										else if (pp != null && pp is 四足胸)
										{
											上腕_蝙 上腕7 = 翼獣.上腕;
											Func<Vector2D> 接着7;
											if ((接着7 = CS$<>8__locals1.<>9__102) == null)
											{
												接着7 = (CS$<>8__locals1.<>9__102 = (() => CS$<>8__locals1.<>4__this.腰_獣.X0Y0_腰.ToGlobal(CS$<>8__locals1.<>4__this.腰_獣.X0Y0_腰.BasePointBase)));
											}
											上腕7.接着 = 接着7;
										}
										else
										{
											上腕_蝙 上腕8 = 翼獣.上腕;
											Func<Vector2D> 接着8;
											if ((接着8 = <>9__103) == null)
											{
												接着8 = (<>9__103 = (() => 翼獣.上腕.Get飛膜接続点()));
											}
											上腕8.接着 = 接着8;
										}
										CS$<>8__locals1.<>4__this.蝙通常.Add(new 蝙通常(翼獣.上腕, 下腕, 手));
									});
								});
							}
							下腕_接続2.SetEle(a9);
							this.翼獣右.Add(翼獣);
						}
					}
					else if (ele is 鰭)
					{
						this.鰭右.Add((鰭)ele);
					}
					else if (ele is 葉)
					{
						this.葉右.Add((葉)ele);
					}
					else if (ele is 前翅_羽 || ele is 前翅_蝶)
					{
						this.前翅1右.Add((前翅)ele);
					}
					else if (ele is 後翅_羽 || ele is 後翅_蝶)
					{
						this.後翅1右.Add((後翅)ele);
					}
					else if (ele is 前翅_甲 || ele is 前翅_草)
					{
						this.前翅2右.Add((前翅)ele);
					}
					else if (ele is 後翅_甲 || ele is 後翅_草)
					{
						this.後翅2右.Add((後翅)ele);
					}
					else if (ele is 触肢_肢蜘)
					{
						this.触肢蜘右.Add((触肢_肢蜘)ele);
					}
					else if (ele is 触肢_肢蠍)
					{
						this.触肢蠍右.Add((触肢_肢蠍)ele);
					}
					else if (ele is 節足_足蜘)
					{
						this.節足蜘右.Add((節足_足蜘)ele);
					}
					else if (ele is 節足_足蠍)
					{
						this.節足蠍右.Add((節足_足蠍)ele);
					}
					else if (ele is 節足_足百)
					{
						this.節足百右.Add((節足_足百)ele);
					}
					else if (ele is 節尾_曳航)
					{
						this.節尾曳右.Add((節尾_曳航)ele);
					}
					else if (ele is 節尾_鋏)
					{
						this.節尾鋏右.Add((節尾_鋏)ele);
					}
					else if (ele is 大顎)
					{
						this.大顎右.Add((大顎)ele);
					}
					else if (ele is 虫顎)
					{
						this.虫顎右.Add((虫顎)ele);
					}
					else if (ele is 虫鎌)
					{
						this.虫鎌右.Add((虫鎌)ele);
					}
					else if (ele is 触手_犬)
					{
						this.触手犬右.Add((触手_犬)ele);
					}
					else if (ele is 触手)
					{
						this.触手右.Add((触手)ele);
					}
				}
				else if (ele is 肩)
				{
					人肩 = (肩)ele;
					人肩.キスマ\u30FCク = new スタンプK(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, this, kd, 人肩);
					sk.Add(人肩.キスマ\u30FCク);
					人肩.鞭痕 = new スタンプW(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, this, wd, 人肩);
					sw.Add(人肩.鞭痕);
				}
				else if (ele is 四足脇)
				{
					四足脇 四足脇 = (四足脇)ele;
					if (this.腕獣左.Count > 0)
					{
						ele.表示 = false;
					}
					腕獣 = default(腕獣);
					腕獣.肩 = 四足脇;
					IEnumerable<Ele> 上腕_接続5 = 四足脇.上腕_接続;
					Action<獣上腕> a10;
					if ((a10 = <>9__73) == null)
					{
						Ele 下腕;
						a10 = (<>9__73 = delegate(獣上腕 上腕)
						{
							腕獣.上腕 = 上腕;
							IEnumerable<Ele> 下腕_接続5 = 上腕.下腕_接続;
							Action<獣下腕> a20;
							if ((a20 = <>9__104) == null)
							{
								a20 = (<>9__104 = delegate(獣下腕 下腕)
								{
									腕獣.下腕 = 下腕;
									IEnumerable<Ele> 手_接続 = 下腕.手_接続;
									Action<獣手> a21;
									if ((a21 = <>9__105) == null)
									{
										a21 = (<>9__105 = delegate(獣手 手)
										{
											腕獣.手 = 手;
										});
									}
									手_接続.SetEle(a21);
								});
							}
							下腕_接続5.SetEle(a20);
						});
					}
					上腕_接続5.SetEle(a10);
					this.腕獣左.Add(腕獣);
				}
				else if (ele is 腿_人)
				{
					人腿 = (腿_人)ele;
					人腿.キスマ\u30FCク = new スタンプK(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, this, kd, 人腿);
					sk.Add(人腿.キスマ\u30FCク);
					人腿.鞭痕 = new スタンプW(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, this, wd, 人腿);
					sw.Add(人腿.鞭痕);
					脚人 = default(脚人);
					脚人.腿 = 人腿;
					IEnumerable<Ele> 脚_接続3 = 人腿.脚_接続;
					Action<脚_人> a11;
					if ((a11 = <>9__74) == null)
					{
						a11 = (<>9__74 = delegate(脚_人 脚)
						{
							脚.キスマ\u30FCク = new スタンプK(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, CS$<>8__locals1.<>4__this, kd, 脚);
							sk.Add(脚.キスマ\u30FCク);
							脚.鞭痕 = new スタンプW(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, CS$<>8__locals1.<>4__this, wd, 脚);
							sw.Add(脚.鞭痕);
							if (!人腿.X0Y0_腿.OP[4].Outline)
							{
								人腿.腿0CD.c2.Col2 = 脚.脚CD.c2.Col1;
								人腿.腿1CD.c2.Col2 = 脚.脚CD.c2.Col1;
								人腿.腿2CD.c2.Col1 = 脚.脚CD.c2.Col1;
								人腿.腿3CD.c2.Col1 = 脚.脚CD.c2.Col1;
								人腿.腿4CD.c2.Col1 = 脚.脚CD.c2.Col1;
							}
							脚人.脚 = 脚;
							IEnumerable<Ele> 足_接続3 = 脚.足_接続;
							Action<足_人> a20;
							if ((a20 = <>9__106) == null)
							{
								a20 = (<>9__106 = delegate(足_人 足)
								{
									足.キスマ\u30FCク = new スタンプK(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, CS$<>8__locals1.<>4__this, kd, 足);
									sk.Add(足.キスマ\u30FCク);
									足.鞭痕 = new スタンプW(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, CS$<>8__locals1.<>4__this, wd, 足);
									sw.Add(足.鞭痕);
									脚人.足 = 足;
								});
							}
							足_接続3.SetEle(a20);
						});
					}
					脚_接続3.SetEle(a11);
					this.脚人左.Add(脚人);
				}
				else if (ele is 獣腿)
				{
					獣腿 獣腿 = (獣腿)ele;
					脚獣 = default(脚獣);
					脚獣.腿 = 獣腿;
					IEnumerable<Ele> 脚_接続4 = 獣腿.脚_接続;
					Action<獣脚> a12;
					if ((a12 = <>9__75) == null)
					{
						a12 = (<>9__75 = delegate(獣脚 脚)
						{
							脚獣.脚 = 脚;
							IEnumerable<Ele> 足_接続3 = 脚.足_接続;
							Action<獣足> a20;
							if ((a20 = <>9__107) == null)
							{
								a20 = (<>9__107 = delegate(獣足 足)
								{
									脚獣.足 = 足;
								});
							}
							足_接続3.SetEle(a20);
						});
					}
					脚_接続4.SetEle(a12);
					this.脚獣左.Add(脚獣);
					if (獣腿.接続情報 == 接続情報.腰_腿左_接続)
					{
						if (ele is 腿_獣)
						{
							腿_獣 腿_獣2 = (腿_獣)獣腿;
							腿_獣2.腿CD.c2.Col1 = CS$<>8__locals1.Cha.配色.毛0O.Col1;
							腿_獣2.腿CD.c2.Col2 = CS$<>8__locals1.Cha.配色.人肌O.Col2;
							腿_獣2.筋CD.c2.Col1 = CS$<>8__locals1.Cha.配色.毛0O.Col1;
							腿_獣2.筋CD.c2.Col2 = CS$<>8__locals1.Cha.配色.人肌O.Col2;
						}
						if (ele is 腿_蹄)
						{
							腿_蹄 腿_蹄2 = (腿_蹄)獣腿;
							腿_蹄2.腿CD.c2.Col1 = CS$<>8__locals1.Cha.配色.毛0O.Col1;
							腿_蹄2.腿CD.c2.Col2 = CS$<>8__locals1.Cha.配色.人肌O.Col2;
							腿_蹄2.筋CD.c2.Col1 = CS$<>8__locals1.Cha.配色.毛0O.Col1;
							腿_蹄2.筋CD.c2.Col2 = CS$<>8__locals1.Cha.配色.人肌O.Col2;
						}
						if (ele is 腿_竜)
						{
							腿_竜 腿_竜2 = (腿_竜)獣腿;
							腿_竜2.腿CD.c2.Col1 = CS$<>8__locals1.Cha.配色.毛0O.Col1;
							腿_竜2.腿CD.c2.Col2 = CS$<>8__locals1.Cha.配色.人肌O.Col2;
							腿_竜2.筋CD.c2.Col1 = CS$<>8__locals1.Cha.配色.毛0O.Col1;
							腿_竜2.筋CD.c2.Col2 = CS$<>8__locals1.Cha.配色.人肌O.Col2;
						}
						if (ele is 腿_鳥)
						{
							腿_鳥 腿_鳥2 = (腿_鳥)獣腿;
							腿_鳥2.腿CD.c2.Col1 = CS$<>8__locals1.Cha.配色.毛0O.Col1;
							腿_鳥2.腿CD.c2.Col2 = CS$<>8__locals1.Cha.配色.人肌O.Col2;
							腿_鳥2.筋CD.c2.Col1 = CS$<>8__locals1.Cha.配色.毛0O.Col1;
							腿_鳥2.筋CD.c2.Col2 = CS$<>8__locals1.Cha.配色.人肌O.Col2;
						}
					}
				}
				else if (ele is 獣脚 && ele.Par is 四足脇)
				{
					脚獣 = default(脚獣);
					脚獣.腿 = null;
					脚獣.脚 = (獣脚)ele;
					IEnumerable<Ele> 足_接続2 = 脚獣.脚.足_接続;
					Action<獣足> a13;
					if ((a13 = <>9__76) == null)
					{
						a13 = (<>9__76 = delegate(獣足 足)
						{
							脚獣.足 = 足;
						});
					}
					足_接続2.SetEle(a13);
					this.脚獣左.Add(脚獣);
				}
				else if (ele is 上腕)
				{
					if (ele.接続情報 == 接続情報.肩_上腕_接続)
					{
						人肩 = (肩)ele.Par;
						if (ele is 上腕_鳥)
						{
							腕翼鳥 = default(腕翼鳥);
							腕翼鳥.肩 = 人肩;
							IEnumerable<Ele> 上腕_接続6 = 人肩.上腕_接続;
							Action<上腕_鳥> a14;
							if ((a14 = <>9__77) == null)
							{
								Ele 下腕;
								a14 = (<>9__77 = delegate(上腕_鳥 上腕)
								{
									上腕.キスマ\u30FCク = new スタンプK(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, CS$<>8__locals1.<>4__this, kd, 上腕);
									sk.Add(上腕.キスマ\u30FCク);
									上腕.鞭痕 = new スタンプW(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, CS$<>8__locals1.<>4__this, wd, 上腕);
									sw.Add(上腕.鞭痕);
									上腕.鳥翼上腕CD.c2.Col2 = 上腕.小雨覆CD.c2.Col1;
									腕翼鳥.上腕 = 上腕;
									IEnumerable<Ele> 下腕_接続5 = 上腕.下腕_接続;
									Action<下腕_鳥> a20;
									if ((a20 = <>9__108) == null)
									{
										a20 = (<>9__108 = delegate(下腕_鳥 下腕)
										{
											腕翼鳥.下腕 = 下腕;
											IEnumerable<Ele> 手_接続 = 下腕.手_接続;
											Action<手_鳥> a21;
											if ((a21 = <>9__109) == null)
											{
												a21 = (<>9__109 = delegate(手_鳥 手)
												{
													腕翼鳥.手 = 手;
												});
											}
											手_接続.SetEle(a21);
										});
									}
									下腕_接続5.SetEle(a20);
								});
							}
							上腕_接続6.SetEle(a14);
							this.腕翼鳥左.Add(腕翼鳥);
						}
						else if (ele is 上腕_蝙)
						{
							腕翼獣 = default(腕翼獣);
							腕翼獣.肩 = 人肩;
							IEnumerable<Ele> 上腕_接続7 = 人肩.上腕_接続;
							Action<上腕_蝙> a15;
							if ((a15 = <>9__78) == null)
							{
								Ele 下腕;
								a15 = (<>9__78 = delegate(上腕_蝙 上腕)
								{
									上腕.獣翼上腕CD.c2.Col1 = 人肩.肩_肩CD.c2.Col1;
									腕翼獣.上腕 = 上腕;
									上腕.下腕_接続.SetEle(delegate(下腕_蝙 下腕)
									{
										腕翼獣.下腕 = 下腕;
										下腕.手_接続.SetEle(delegate(手_蝙 手)
										{
											腕翼獣.手 = 手;
											上腕_蝙 上腕 = 上腕;
											Func<Vector2D> 接着;
											if ((接着 = CS$<>8__locals1.<>9__112) == null)
											{
												接着 = (CS$<>8__locals1.<>9__112 = (() => CS$<>8__locals1.<>4__this.腰.X0Y0_腰.ToGlobal(CS$<>8__locals1.<>4__this.腰.X0Y0_腰.BasePointBase)));
											}
											上腕.接着 = 接着;
											CS$<>8__locals1.<>4__this.蝙通常.Add(new 蝙通常(上腕, 下腕, 手));
										});
									});
								});
							}
							上腕_接続7.SetEle(a15);
							this.腕翼獣左.Add(腕翼獣);
						}
						else
						{
							腕人 = default(腕人);
							腕人.肩 = 人肩;
							IEnumerable<Ele> 上腕_接続8 = 人肩.上腕_接続;
							Action<上腕_人> a16;
							if ((a16 = <>9__79) == null)
							{
								Ele 下腕;
								a16 = (<>9__79 = delegate(上腕_人 上腕)
								{
									上腕.キスマ\u30FCク = new スタンプK(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, CS$<>8__locals1.<>4__this, kd, 上腕);
									sk.Add(上腕.キスマ\u30FCク);
									上腕.鞭痕 = new スタンプW(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, CS$<>8__locals1.<>4__this, wd, 上腕);
									sw.Add(上腕.鞭痕);
									腕人.上腕 = 上腕;
									上腕.下腕_接続.SetEle(delegate(下腕_人 下腕)
									{
										下腕.腕輪尺度修正();
										下腕.キスマ\u30FCク = new スタンプK(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, CS$<>8__locals1.<>4__this, kd, 下腕);
										sk.Add(下腕.キスマ\u30FCク);
										下腕.鞭痕 = new スタンプW(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, CS$<>8__locals1.<>4__this, wd, 下腕);
										sw.Add(下腕.鞭痕);
										if (上腕.獣性_獣毛1_表示)
										{
											下腕.下腕CD.c2 = 上腕.獣性_獣毛1CD.c2;
											下腕.筋肉_筋肉上CD.c2 = 上腕.獣性_獣毛1CD.c2;
											下腕.筋肉_筋肉下CD.c2 = 上腕.獣性_獣毛1CD.c2;
										}
										if (上腕.虫性_虫腕_表示 && (!下腕.虫性1_虫腕上_表示 || !下腕.虫性2_虫腕下_表示))
										{
											下腕.下腕CD.c2 = 上腕.虫性_虫腕CD.c2;
											下腕.筋肉_筋肉上CD.c2 = 上腕.虫性_虫腕CD.c2;
											下腕.筋肉_筋肉下CD.c2 = 上腕.虫性_虫腕CD.c2;
										}
										if (下腕.植性2_萼_萼中_表示)
										{
											上腕.上腕CD.c2.Col2 = 下腕.植性2_萼_萼中CD.c2.Col2;
											上腕.筋肉上CD.c2.Col2 = 下腕.植性2_萼_萼中CD.c2.Col2;
											上腕.筋肉下CD.c2.Col2 = 下腕.植性2_萼_萼中CD.c2.Col2;
										}
										else if (下腕.獣性1_獣腕_表示)
										{
											上腕.上腕CD.c2.Col2 = 下腕.獣性1_獣腕CD.c2.Col1;
											上腕.筋肉上CD.c2.Col2 = 下腕.獣性1_獣腕CD.c2.Col1;
											上腕.筋肉下CD.c2.Col2 = 下腕.獣性1_獣腕CD.c2.Col1;
										}
										else
										{
											上腕.上腕CD.c2.Col2 = 下腕.下腕CD.c2.Col1;
											上腕.筋肉上CD.c2.Col2 = 下腕.下腕CD.c2.Col1;
											上腕.筋肉下CD.c2.Col2 = 下腕.下腕CD.c2.Col1;
										}
										腕人.下腕 = 下腕;
										下腕.手_接続.SetEle(delegate(手_人 手)
										{
											if (下腕.獣性1_獣腕_表示 || 下腕.下腕CD.c2.Col1 == 下腕.獣性1_獣腕CD.c2.Col1)
											{
												手.手CD.c2 = 下腕.獣性1_獣腕CD.c2;
												手.親指_親指1CD.c2 = 手.手CD.c2;
											}
											else if (手.X0Y0_手.OP[0].Outline)
											{
												手.手CD.c2 = 下腕.虫性1_虫腕上CD.c2;
												手.親指_親指1CD.c2 = 手.手CD.c2;
											}
											腕人.手 = 手;
										});
									});
									上腕.下腕_接続.SetEle(delegate(下腕_獣 下腕)
									{
										上腕.上腕CD.c2.Col2 = 下腕.下腕CD.c2.Col1;
										上腕.筋肉上CD.c2.Col2 = 下腕.下腕CD.c2.Col1;
										上腕.筋肉下CD.c2.Col2 = 下腕.下腕CD.c2.Col1;
										下腕.X0Y0_下腕.OP[0].Outline = true;
									});
								});
							}
							上腕_接続8.SetEle(a16);
							this.腕人左.Add(腕人);
						}
					}
					else if (ele is 上腕_鳥)
					{
						翼鳥 = default(翼鳥);
						翼鳥.上腕 = (上腕_鳥)ele;
						翼鳥.上腕.鳥翼上腕CD.c2 = 翼鳥.上腕.小雨覆CD.c2;
						翼鳥.上腕.キスマ\u30FCク = new スタンプK(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, this, kd, 翼鳥.上腕);
						sk.Add(翼鳥.上腕.キスマ\u30FCク);
						翼鳥.上腕.鞭痕 = new スタンプW(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, this, wd, 翼鳥.上腕);
						sw.Add(翼鳥.上腕.鞭痕);
						IEnumerable<Ele> 下腕_接続3 = 翼鳥.上腕.下腕_接続;
						Action<下腕_鳥> a17;
						if ((a17 = <>9__80) == null)
						{
							Ele 下腕;
							a17 = (<>9__80 = delegate(下腕_鳥 下腕)
							{
								翼鳥.下腕 = 下腕;
								IEnumerable<Ele> 手_接続 = 下腕.手_接続;
								Action<手_鳥> a20;
								if ((a20 = <>9__116) == null)
								{
									a20 = (<>9__116 = delegate(手_鳥 手)
									{
										翼鳥.手 = 手;
									});
								}
								手_接続.SetEle(a20);
							});
						}
						下腕_接続3.SetEle(a17);
						this.翼鳥左.Add(翼鳥);
					}
					else if (ele is 上腕_蝙)
					{
						翼獣 = default(翼獣);
						翼獣.上腕 = (上腕_蝙)ele;
						IEnumerable<Ele> 下腕_接続4 = 翼獣.上腕.下腕_接続;
						Action<下腕_蝙> a18;
						if ((a18 = <>9__81) == null)
						{
							Ele 下腕;
							a18 = (<>9__81 = delegate(下腕_蝙 下腕)
							{
								翼獣.下腕 = 下腕;
								下腕.手_接続.SetEle(delegate(手_蝙 手)
								{
									翼獣.手 = 手;
									p = 翼獣.上腕.Par;
									pp = 翼獣.上腕.Par.Par;
									if (p is 基髪)
									{
										上腕_蝙 上腕 = 翼獣.上腕;
										Func<Vector2D> 接着;
										if ((接着 = CS$<>8__locals1.<>9__118) == null)
										{
											接着 = (CS$<>8__locals1.<>9__118 = (() => CS$<>8__locals1.<>4__this.頭.X0Y0_頭.ToGlobal(CS$<>8__locals1.<>4__this.頭.X0Y0_頭.BasePointBase)));
										}
										上腕.接着 = 接着;
									}
									else if (p is 胸)
									{
										上腕_蝙 上腕2 = 翼獣.上腕;
										Func<Vector2D> 接着2;
										if ((接着2 = CS$<>8__locals1.<>9__119) == null)
										{
											接着2 = (CS$<>8__locals1.<>9__119 = (() => CS$<>8__locals1.<>4__this.胴.X0Y0_胴.ToGlobal(CS$<>8__locals1.<>4__this.胴.X0Y0_胴.BasePointBase)));
										}
										上腕2.接着 = 接着2;
									}
									else if (p is 胴 || p is 腰)
									{
										上腕_蝙 上腕3 = 翼獣.上腕;
										Func<Vector2D> 接着3;
										if ((接着3 = CS$<>8__locals1.<>9__120) == null)
										{
											接着3 = (CS$<>8__locals1.<>9__120 = (() => CS$<>8__locals1.<>4__this.腰.X0Y0_腰.ToGlobal(CS$<>8__locals1.<>4__this.腰.X0Y0_腰.JP[4].Joint)));
										}
										上腕3.接着 = 接着3;
									}
									else if (p is 四足胸)
									{
										上腕_蝙 上腕4 = 翼獣.上腕;
										Func<Vector2D> 接着4;
										if ((接着4 = CS$<>8__locals1.<>9__121) == null)
										{
											接着4 = (CS$<>8__locals1.<>9__121 = (() => CS$<>8__locals1.<>4__this.胴_獣.X0Y0_胴.ToGlobal(CS$<>8__locals1.<>4__this.胴_獣.X0Y0_胴.BasePointBase)));
										}
										上腕4.接着 = 接着4;
									}
									else if ((p is 四足胴 || p is 四足腰) && (翼獣.上腕.接続情報 == 接続情報.四足腰_翼左_接続 || 翼獣.上腕.接続情報 == 接続情報.四足腰_翼右_接続))
									{
										上腕_蝙 上腕5 = 翼獣.上腕;
										Func<Vector2D> 接着5;
										if ((接着5 = CS$<>8__locals1.<>9__122) == null)
										{
											接着5 = (CS$<>8__locals1.<>9__122 = (() => CS$<>8__locals1.<>4__this.腰_獣.X0Y0_腰.ToGlobal(CS$<>8__locals1.<>4__this.腰.X0Y0_腰.JP[4].Joint)));
										}
										上腕5.接着 = 接着5;
									}
									else if (pp != null && pp is 胸)
									{
										上腕_蝙 上腕6 = 翼獣.上腕;
										Func<Vector2D> 接着6;
										if ((接着6 = CS$<>8__locals1.<>9__123) == null)
										{
											接着6 = (CS$<>8__locals1.<>9__123 = (() => CS$<>8__locals1.<>4__this.腰.X0Y0_腰.ToGlobal(CS$<>8__locals1.<>4__this.腰.X0Y0_腰.BasePointBase)));
										}
										上腕6.接着 = 接着6;
									}
									else if (pp != null && pp is 四足胸)
									{
										上腕_蝙 上腕7 = 翼獣.上腕;
										Func<Vector2D> 接着7;
										if ((接着7 = CS$<>8__locals1.<>9__124) == null)
										{
											接着7 = (CS$<>8__locals1.<>9__124 = (() => CS$<>8__locals1.<>4__this.腰_獣.X0Y0_腰.ToGlobal(CS$<>8__locals1.<>4__this.腰_獣.X0Y0_腰.BasePointBase)));
										}
										上腕7.接着 = 接着7;
									}
									else
									{
										上腕_蝙 上腕8 = 翼獣.上腕;
										Func<Vector2D> 接着8;
										if ((接着8 = <>9__125) == null)
										{
											接着8 = (<>9__125 = (() => 翼獣.上腕.Get飛膜接続点()));
										}
										上腕8.接着 = 接着8;
									}
									CS$<>8__locals1.<>4__this.蝙通常.Add(new 蝙通常(翼獣.上腕, 下腕, 手));
								});
							});
						}
						下腕_接続4.SetEle(a18);
						this.翼獣左.Add(翼獣);
					}
				}
				else if (ele is 鰭)
				{
					this.鰭左.Add((鰭)ele);
				}
				else if (ele is 葉)
				{
					this.葉左.Add((葉)ele);
				}
				else if (ele is 前翅_羽 || ele is 前翅_蝶)
				{
					this.前翅1左.Add((前翅)ele);
				}
				else if (ele is 後翅_羽 || ele is 後翅_蝶)
				{
					this.後翅1左.Add((後翅)ele);
				}
				else if (ele is 前翅_甲 || ele is 前翅_草)
				{
					this.前翅2左.Add((前翅)ele);
				}
				else if (ele is 後翅_甲 || ele is 後翅_草)
				{
					this.後翅2左.Add((後翅)ele);
				}
				else if (ele is 触肢_肢蜘)
				{
					this.触肢蜘左.Add((触肢_肢蜘)ele);
				}
				else if (ele is 触肢_肢蠍)
				{
					this.触肢蠍左.Add((触肢_肢蠍)ele);
				}
				else if (ele is 節足_足蜘)
				{
					this.節足蜘左.Add((節足_足蜘)ele);
				}
				else if (ele is 節足_足蠍)
				{
					this.節足蠍左.Add((節足_足蠍)ele);
				}
				else if (ele is 節足_足百)
				{
					this.節足百左.Add((節足_足百)ele);
				}
				else if (ele is 節尾_曳航)
				{
					this.節尾曳左.Add((節尾_曳航)ele);
				}
				else if (ele is 節尾_鋏)
				{
					this.節尾鋏左.Add((節尾_鋏)ele);
				}
				else if (ele is 大顎)
				{
					this.大顎左.Add((大顎)ele);
				}
				else if (ele is 虫顎)
				{
					this.虫顎左.Add((虫顎)ele);
				}
				else if (ele is 虫鎌)
				{
					this.虫鎌左.Add((虫鎌)ele);
				}
				else if (ele is 触手_犬)
				{
					this.触手犬左.Add((触手_犬)ele);
				}
				else if (ele is 触手)
				{
					this.触手左.Add((触手)ele);
				}
				if (ele is 尾)
				{
					this.尾.Add((尾)ele);
					if (ele is 尾_魚 && !(ele.Par is 長物_魚))
					{
						if (ele.Par is 腰)
						{
							if (ele.右)
							{
								((尾_魚)ele).X0Y0_尾1_尾.OP[5].Outline = false;
							}
							else
							{
								((尾_魚)ele).X0Y0_尾1_尾.OP[0].Outline = false;
							}
						}
						else if (ele.右)
						{
							((尾_魚)ele).X0Y0_尾0_尾.OP[5].Outline = false;
						}
						else
						{
							((尾_魚)ele).X0Y0_尾0_尾.OP[0].Outline = false;
						}
					}
				}
				else if (ele is 長胴)
				{
					this.長胴.Add((長胴)ele);
				}
			}
			this.腕人n = this.腕人左.Count;
			this.腕翼鳥n = this.腕翼鳥左.Count;
			this.腕翼獣n = this.腕翼獣左.Count;
			this.腕獣n = this.腕獣左.Count;
			this.脚人n = this.脚人左.Count;
			this.脚獣n = this.脚獣左.Count;
			this.翼鳥n = this.翼鳥左.Count;
			this.翼獣n = this.翼獣左.Count;
			this.鰭n = this.鰭左.Count;
			this.葉n = this.葉左.Count;
			this.前翅1n = this.前翅1左.Count;
			this.後翅1n = this.後翅1左.Count;
			this.前翅2n = this.前翅2左.Count;
			this.後翅2n = this.後翅2左.Count;
			this.触肢蜘n = this.触肢蜘左.Count;
			this.触肢蠍n = this.触肢蠍左.Count;
			this.節足蜘n = this.節足蜘左.Count;
			this.節足蠍n = this.節足蠍左.Count;
			this.節足百n = this.節足百左.Count;
			this.節尾曳n = this.節尾曳左.Count;
			this.節尾鋏n = this.節尾鋏左.Count;
			this.大顎n = this.大顎左.Count;
			this.虫顎n = this.虫顎左.Count;
			this.虫鎌n = this.虫鎌左.Count;
			this.触手n = this.触手左.Count;
			this.触手犬n = this.触手犬左.Count;
			this.尾n = this.尾.Count;
			this.長胴n = this.長胴.Count;
			if (this.腰 != null)
			{
				this.胴 = this.腰.胴_接続.GetEle<胴>();
				this.ボテ腹_人 = this.腰.肌_接続.GetEle<ボテ腹_人>();
				this.ボテ腹板_人 = this.ボテ腹_人.腹板_接続.GetEle<ボテ腹板>();
				this.ボテ腹板_人.SetHitFalse();
				this.腰肌_人 = this.腰.肌_接続.GetEle<腰肌>();
				this.腰肌_人.X0Y0_陰毛.Hit = true;
				this.腰肌_人.X0Y0_陰毛_ハ\u30FCト.Hit = true;
				this.腰肌_人.X0Y0_獣性_獣毛.Hit = true;
				this.腰肌_人.X0Y1_陰毛.Hit = true;
				this.腰肌_人.X0Y1_陰毛_ハ\u30FCト.Hit = true;
				this.腰肌_人.X0Y1_獣性_獣毛.Hit = true;
				this.腰肌_人.X0Y2_陰毛.Hit = true;
				this.腰肌_人.X0Y2_陰毛_ハ\u30FCト.Hit = true;
				this.腰肌_人.X0Y2_獣性_獣毛.Hit = true;
				this.腰肌_人.X0Y3_陰毛.Hit = true;
				this.腰肌_人.X0Y3_陰毛_ハ\u30FCト.Hit = true;
				this.腰肌_人.X0Y3_獣性_獣毛.Hit = true;
				this.腰肌_人.X0Y4_陰毛.Hit = true;
				this.腰肌_人.X0Y4_陰毛_ハ\u30FCト.Hit = true;
				this.腰肌_人.X0Y4_獣性_獣毛.Hit = true;
				this.肛門_人 = this.腰.肛門_接続.GetEle<肛門_人>();
				this.肛門精液_人 = this.肛門_人.肛門精液_接続.GetEle<肛門精液_人>();
				this.肛門精液_人.SetHitFalse();
				this.膣基_人 = this.腰.膣基_接続.GetEle<膣基_人>();
				this.膣内精液_人 = this.腰.膣基_接続.GetEle<膣内精液_人>();
				this.断面_人 = this.腰.膣基_接続.GetEle<断面_人>();
				this.膣基_人.SetHitFalse();
				this.膣内精液_人.SetHitFalse();
				this.断面_人.SetHitFalse();
				this.性器_人 = this.腰.膣基_接続.GetEle<性器_人>();
				this.性器精液_人 = this.性器_人.膣口_接続.GetEle<性器精液_人>();
				this.飛沫_人 = this.性器_人.膣口_接続.GetEle<飛沫_人>();
				this.潮吹_小_人 = this.性器_人.尿道_接続.GetEle<潮吹_小_人>();
				this.潮吹_大_人 = this.性器_人.尿道_接続.GetEle<潮吹_大_人>();
				this.放尿_人 = this.性器_人.尿道_接続.GetEle<放尿_人>();
				this.ピアス = this.性器_人.陰核_接続.GetEle<ピアス>();
				this.キャップ1 = this.性器_人.陰核_接続.GetEle<キャップ1>();
				this.下着陰核 = this.性器_人.陰核_接続.GetEle<下着陰核>();
				this.性器精液_人.SetHitFalse();
				this.飛沫_人.SetHitFalse();
				this.潮吹_小_人.SetHitFalse();
				this.潮吹_大_人.SetHitFalse();
				this.放尿_人.SetHitFalse();
				this.ピアス.SetHitFalse();
				this.下着陰核.SetHitFalse();
				this.下着B_ノ\u30FCマル = this.腰.肌_接続.GetEle<下着ボトム_ノ\u30FCマル>();
				this.下着B_マイクロ = this.腰.肌_接続.GetEle<下着ボトム_マイクロ>();
				this.下着B_ノ\u30FCマル.SetHitFalse();
				this.下着B_マイクロ.SetHitFalse();
				this.上着B_クロス = this.腰.上着_接続.GetEle<上着ボトム_クロス>();
				this.上着B_クロス後 = (上着ボトム_クロス後)this.上着B_クロス.上着ボトム後_接続[0];
				this.上着B_前掛け = this.腰.上着_接続.GetEle<上着ボトム_前掛け>();
				this.上着B_クロス.SetHitFalse();
				this.上着B_クロス後.SetHitFalse();
				this.上着B_前掛け.SetHitFalse();
			}
			if (this.胴 != null)
			{
				this.胸 = this.胴.胸_接続.GetEle<胸>();
				this.胴腹板_人 = this.胴.肌_接続.GetEle<胴腹板>();
				this.胴肌_人 = this.胴.肌_接続.GetEle<胴肌>();
				this.胴腹板_人.SetHitFalse();
				this.胴肌_人.SetHitFalse();
				this.上着M_ドレス = this.胴.肌_接続.GetEle<上着ミドル_ドレス>();
				this.上着M_ドレス.SetHitFalse();
			}
			if (this.胸 != null)
			{
				this.首 = this.胸.首_接続.GetEle<首>();
				this.胸腹板_人 = this.胸.肌_接続.GetEle<胸腹板>();
				this.胸肌_人 = this.胸.肌_接続.GetEle<胸肌>();
				this.胸毛_人 = this.胸.肌_接続.GetEle<胸毛>();
				this.胸腹板_人.SetHitFalse();
				this.胸肌_人.SetHitFalse();
				this.乳房左 = this.胸.胸左_接続.GetEle<乳房>();
				this.噴乳左 = this.乳房左.噴乳_接続.GetEle<噴乳>();
				this.ピアス左 = this.乳房左.噴乳_接続.GetEle<ピアス>();
				this.キャップ2左 = this.乳房左.噴乳_接続.GetEle<キャップ2>();
				this.下着乳首左 = this.乳房左.噴乳_接続.GetEle<下着乳首>();
				this.噴乳左.SetHitFalse();
				this.ピアス左.SetHitFalse();
				this.下着乳首左.SetHitFalse();
				this.乳房右 = this.胸.胸右_接続.GetEle<乳房>();
				this.噴乳右 = this.乳房右.噴乳_接続.GetEle<噴乳>();
				this.ピアス右 = this.乳房右.噴乳_接続.GetEle<ピアス>();
				this.キャップ2右 = this.乳房右.噴乳_接続.GetEle<キャップ2>();
				this.下着乳首右 = this.乳房右.噴乳_接続.GetEle<下着乳首>();
				this.噴乳右.SetHitFalse();
				this.ピアス右.SetHitFalse();
				this.下着乳首右.SetHitFalse();
				this.下着T_チュ\u30FCブ = this.胸.肌_接続.GetEle<下着トップ_チュ\u30FCブ>();
				this.下着T_クロス = this.胸.肌_接続.GetEle<下着トップ_クロス>();
				this.下着T_ビキニ = this.胸.肌_接続.GetEle<下着トップ_ビキニ>();
				this.下着T_マイクロ = this.胸.肌_接続.GetEle<下着トップ_マイクロ>();
				this.下着T_ブラ = this.胸.肌_接続.GetEle<下着トップ_ブラ>();
				this.下着T_チュ\u30FCブ.SetHitFalse();
				this.下着T_クロス.SetHitFalse();
				this.下着T_ビキニ.SetHitFalse();
				this.下着T_マイクロ.SetHitFalse();
				this.下着T_ブラ.SetHitFalse();
				this.上着T_ドレス = this.胸.肌_接続.GetEle<上着トップ_ドレス>();
				this.上着T_ドレス.SetHitFalse();
			}
			if (this.首 != null)
			{
				this.頭 = this.首.頭_接続.GetEle<頭>();
			}
			if (this.頭 != null)
			{
				this.基髪 = this.頭.基髪_接続.GetEle<基髪>();
				this.単眼目 = this.頭.単眼目_接続.GetEle<単目>();
				if (this.単眼目 != null)
				{
					this.単眼瞼 = this.単眼目.瞼_接続.GetEle<単瞼>();
					this.涙左 = this.単眼目.瞼_接続.GetEle(false);
					this.涙右 = this.単眼目.瞼_接続.GetEle(true);
					this.単眼目.SetHitFalse();
					this.単眼瞼.SetHitFalse();
					this.涙左.SetHitFalse();
					this.涙右.SetHitFalse();
				}
				this.目左 = this.頭.目左_接続.GetEle<双目>();
				this.目右 = this.頭.目右_接続.GetEle<双目>();
				if (this.目左 != null)
				{
					this.瞼左 = this.目左.瞼_接続.GetEle<双瞼>();
					this.涙左 = this.目左.瞼_接続.GetEle<涙>();
					this.目左.SetHitFalse();
					this.瞼左.SetHitFalse();
					this.涙左.SetHitFalse();
				}
				if (this.目右 != null)
				{
					this.瞼右 = this.目右.瞼_接続.GetEle<双瞼>();
					this.涙右 = this.目右.瞼_接続.GetEle<涙>();
					this.目右.SetHitFalse();
					this.瞼右.SetHitFalse();
					this.涙右.SetHitFalse();
				}
				this.額目 = this.頭.額_接続.GetEle<縦目>();
				this.頬目左 = this.頭.頬肌左_接続.GetEle<頬目>();
				this.頬目右 = this.頭.頬肌右_接続.GetEle<頬目>();
				if (this.額目 != null)
				{
					this.額瞼 = this.額目.瞼_接続.GetEle<縦瞼>();
					this.額目.SetHitFalse();
					this.額瞼.SetHitFalse();
				}
				if (this.頬目左 != null)
				{
					this.頬瞼左 = this.頬目左.瞼_接続.GetEle<頬瞼>();
					this.頬目左.SetHitFalse();
					this.頬瞼左.SetHitFalse();
				}
				if (this.頬目右 != null)
				{
					this.頬瞼右 = this.頬目右.瞼_接続.GetEle<頬瞼>();
					this.頬目右.SetHitFalse();
					this.頬瞼右.SetHitFalse();
				}
				this.目隠帯 = this.頭.単眼目_接続.GetEle<目隠帯>();
				this.鼻 = this.頭.鼻_接続.GetEle<鼻>();
				if (this.鼻 != null)
				{
					this.鼻水左 = this.鼻.鼻水左_接続.GetEle<鼻水>();
					this.鼻水右 = this.鼻.鼻水右_接続.GetEle<鼻水>();
					this.鼻.SetHitFalse();
					this.鼻水左.SetHitFalse();
					this.鼻水右.SetHitFalse();
				}
				this.口 = this.頭.口_接続.GetEle<口>();
				this.口.SetHitFalse();
				this.舌 = this.頭.口_接続.GetEle<舌>();
				this.舌.SetHitFalse();
				this.涎左 = this.頭.口_接続.GetEle(false);
				this.涎右 = this.頭.口_接続.GetEle(true);
				this.涎左.SetHitFalse();
				this.涎右.SetHitFalse();
				this.口精液 = this.頭.口_接続.GetEle<性器精液_人>();
				this.口精液.SetHitFalse();
				this.咳 = this.頭.口_接続.GetEle<咳>();
				this.咳.SetHitFalse();
				this.呼気 = this.頭.口_接続.GetEle<呼気>();
				this.呼気.SetHitFalse();
				this.玉口枷 = this.頭.口_接続.GetEle<玉口枷>();
				this.単眼眉 = this.頭.単眼眉_接続.GetEle<単眼眉>();
				if (this.単眼眉 != null)
				{
					this.単眼眉.SetHitFalse();
				}
				this.眉左 = this.頭.眉左_接続.GetEle<眉>();
				this.眉右 = this.頭.眉右_接続.GetEle<眉>();
				if (this.眉左 != null)
				{
					this.眉左.SetHitFalse();
				}
				if (this.眉右 != null)
				{
					this.眉右.SetHitFalse();
				}
				this.頬肌左 = this.頭.頬肌左_接続.GetEle<頬肌>();
				this.頬肌右 = this.頭.頬肌右_接続.GetEle<頬肌>();
				this.頬肌左.SetHitFalse();
				this.頬肌右.SetHitFalse();
				this.鼻肌 = this.頭.鼻肌_接続.GetEle<鼻肌>();
				this.鼻肌.SetHitFalse();
				this.目尻影左 = this.頭.目左_接続.GetEle<目尻影>();
				this.目尻影右 = this.頭.目右_接続.GetEle<目尻影>();
				this.目尻影左.SetHitFalse();
				this.目尻影右.SetHitFalse();
				this.紅潮 = this.頭.鼻肌_接続.GetEle<紅潮>();
				this.紅潮.SetHitFalse();
				this.目傷左 = this.頭.目左_接続.GetEle<目傷>();
				this.目傷右 = this.頭.目右_接続.GetEle<目傷>();
				this.目傷左.SetHitFalse();
				this.目傷右.SetHitFalse();
				this.顔ハイライト左 = this.頭.頬左_接続.GetEle<顔ハイライト>();
				this.顔ハイライト右 = this.頭.頬右_接続.GetEle<顔ハイライト>();
				this.顔ハイライト左.SetHitFalse();
				this.顔ハイライト右.SetHitFalse();
			}
			if (this.基髪 != null)
			{
				this.前髪 = this.基髪.前髪_接続.GetEle<前髪>();
				this.横髪左 = this.基髪.横髪左_接続.GetEle<横髪>();
				this.横髪右 = this.基髪.横髪右_接続.GetEle<横髪>();
				this.後髪1 = this.基髪.後髪_接続.GetEle<後髪1>();
				this.後髪0 = this.基髪.後髪_接続.GetEle<後髪0>();
			}
			this.首.キスマ\u30FCク = new スタンプK(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, this, kd, this.首);
			sk.Add(this.首.キスマ\u30FCク);
			this.首.鞭痕 = new スタンプW(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, this, wd, this.首);
			sw.Add(this.首.鞭痕);
			this.胸.キスマ\u30FCク = new スタンプK(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, this, kd, this.胸);
			sk.Add(this.胸.キスマ\u30FCク);
			this.胸.鞭痕 = new スタンプW(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, this, wd, this.胸);
			sw.Add(this.胸.鞭痕);
			this.胴.キスマ\u30FCク = new スタンプK(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, this, kd, this.胴);
			sk.Add(this.胴.キスマ\u30FCク);
			this.胴.鞭痕 = new スタンプW(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, this, wd, this.胴);
			sw.Add(this.胴.鞭痕);
			this.腰.キスマ\u30FCク = new スタンプK(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, this, kd, this.腰);
			sk.Add(this.腰.キスマ\u30FCク);
			this.腰.鞭痕 = new スタンプW(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, this, wd, this.腰);
			sw.Add(this.腰.鞭痕);
			this.ボテ腹_人.キスマ\u30FCク = new スタンプK(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, this, kd, this.ボテ腹_人);
			sk.Add(this.ボテ腹_人.キスマ\u30FCク);
			this.ボテ腹_人.鞭痕 = new スタンプW(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, this, wd, this.ボテ腹_人);
			sw.Add(this.ボテ腹_人.鞭痕);
			this.乳房左.キスマ\u30FCク = new スタンプK(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, this, kd, this.乳房左);
			sk.Add(this.乳房左.キスマ\u30FCク);
			this.乳房左.鞭痕 = new スタンプW(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, this, wd, this.乳房左);
			sw.Add(this.乳房左.鞭痕);
			this.乳房右.キスマ\u30FCク = new スタンプK(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, this, kd, this.乳房右);
			sk.Add(this.乳房右.キスマ\u30FCク);
			this.乳房右.鞭痕 = new スタンプW(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, this, wd, this.乳房右);
			sw.Add(this.乳房右.鞭痕);
			this.キスマ\u30FCク = sk.ToArray();
			this.鞭痕 = sw.ToArray();
			this.ぶっかけ小 = new スタンプB(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, this, new ぶっかけ_小D(), CS$<>8__locals1.Cha.Mots);
			this.ぶっかけ大 = new スタンプB(CS$<>8__locals1.Med, CS$<>8__locals1.Are, CS$<>8__locals1.Cha, this, new ぶっかけ_大D(), CS$<>8__locals1.Cha.Mots);
			this.Is瞼宇 = (this.瞼左 is 瞼_宇);
			this.涙描画 = (this.涙左 != null);
			this.鼻描画 = (this.鼻 != null);
			if (this.後髪1 != null)
			{
				this.Sort(this.後髪1.EnumEle(), this.後髪接続);
			}
			if (this.後髪0 != null)
			{
				this.Sort(this.後髪0.EnumEle(), this.後髪接続);
			}
			if (this.頭.額_接続 != null)
			{
				this.Sort((from e in this.頭.額_接続
				where !(e is 縦目)
				select e.EnumEle()).JoinEnum<Ele>(), this.額接続);
			}
			if (this.頭.耳左_接続 != null)
			{
				this.Sort((from e in this.頭.耳左_接続
				select e.EnumEle()).JoinEnum<Ele>(), this.耳左接続);
			}
			if (this.頭.耳右_接続 != null)
			{
				this.Sort((from e in this.頭.耳右_接続
				select e.EnumEle()).JoinEnum<Ele>(), this.耳右接続);
			}
			if (this.頭.触覚左_接続 != null)
			{
				this.Sort((from e in this.頭.触覚左_接続
				select e.EnumEle()).JoinEnum<Ele>(), this.触覚左接続);
			}
			if (this.頭.触覚右_接続 != null)
			{
				this.Sort((from e in this.頭.触覚右_接続
				select e.EnumEle()).JoinEnum<Ele>(), this.触覚右接続);
			}
			if (this.頭.頬左_接続 != null)
			{
				this.Sort((from e in this.頭.頬左_接続
				select e.EnumEle()).JoinEnum<Ele>(), this.頬左接続);
			}
			if (this.頭.頬右_接続 != null)
			{
				this.Sort((from e in this.頭.頬右_接続
				select e.EnumEle()).JoinEnum<Ele>(), this.頬右接続);
			}
			if (this.基髪.頭頂左_接続 != null)
			{
				this.角左接続.AddRange(this.基髪.頭頂左_接続.GetEles<角2>());
				this.獣耳左 = this.基髪.頭頂左_接続.GetEle<獣耳>();
				this.Sort((from e in this.基髪.頭頂左_接続.GetEles<植>()
				select e.EnumEle()).JoinEnum<Ele>(), this.植左接続);
				this.Sort((from e in this.基髪.頭頂左_接続
				where !(e is 角2) && !(e is 獣耳) && !(e is 植) && !(e is 横髪)
				select e.EnumEle()).JoinEnum<Ele>(), this.頭頂左後接続);
			}
			if (this.基髪.頭頂右_接続 != null)
			{
				this.角右接続.AddRange(this.基髪.頭頂右_接続.GetEles<角2>());
				this.獣耳右 = this.基髪.頭頂右_接続.GetEle<獣耳>();
				this.Sort((from e in this.基髪.頭頂右_接続.GetEles<植>()
				select e.EnumEle()).JoinEnum<Ele>(), this.植右接続);
				this.Sort((from e in this.基髪.頭頂右_接続
				where !(e is 角2) && !(e is 獣耳) && !(e is 植) && !(e is 横髪)
				select e.EnumEle()).JoinEnum<Ele>(), this.頭頂右後接続);
			}
			if (this.頭.顔面_接続 != null)
			{
				this.顔面 = this.頭.顔面_接続.GetEle<顔面>();
				if (this.顔面 != null)
				{
					if (this.顔面.触覚左_接続 != null)
					{
						this.Sort((from e in this.顔面.触覚左_接続
						select e.EnumEle()).JoinEnum<Ele>(), this.顔触覚左接続);
					}
					if (this.顔面.触覚右_接続 != null)
					{
						this.Sort((from e in this.顔面.触覚右_接続
						select e.EnumEle()).JoinEnum<Ele>(), this.顔触覚右接続);
					}
				}
			}
			if (this.頭.大顎基_接続 != null)
			{
				this.Sort((from e in this.頭.大顎基_接続
				select e.EnumEle()).JoinEnum<Ele>(), this.大顎基接続);
			}
			if (this.頭.頭頂_接続 != null)
			{
				this.頭頂 = this.頭.頭頂_接続.GetEle<頭頂>();
				if (this.Is頭頂_宇 = (this.頭頂 is 頭頂_宇))
				{
					this.頭頂後 = ((頭頂_宇)this.頭頂).頭部後_接続.GetEle<頭頂後_宇>();
				}
			}
			if (this.胸.肩左_接続 != null)
			{
				this.後脇左s = this.胸.肩左_接続.GetEles<肩>().ToArray<肩>();
				this.肩左 = this.後脇左s.LastOrDefault<肩>();
				if (this.後脇左s.Length > 1)
				{
					this.後腕左s = new List<Ele>[this.後脇左s.Length - 1];
					for (int j = 0; j < this.後腕左s.Length; j++)
					{
						this.後腕左s[j] = new List<Ele>();
						this.Sort(this.後脇左s[j].EnumEle(), this.後腕左s[j]);
					}
					if (this.肩左.上腕_接続 != null)
					{
						this.Sort((from e in this.肩左.上腕_接続
						select e.EnumEle()).JoinEnum<Ele>(), this.腕左);
					}
				}
				else if (this.後脇左s.Length == 1 && this.肩左.上腕_接続 != null)
				{
					this.後腕左s = new List<Ele>[this.肩左.上腕_接続.Length - 1];
					for (int k = 0; k < this.後腕左s.Length; k++)
					{
						this.後腕左s[k] = new List<Ele>();
						this.Sort(this.肩左.上腕_接続[k].EnumEle(), this.後腕左s[k]);
					}
					this.Sort(this.肩左.上腕_接続.Last<Ele>().EnumEle(), this.腕左);
				}
				this.後脇左s = this.後脇左s.Take(this.後脇左s.Length - 1).ToArray<肩>();
			}
			this.nsl = new bool[1 + ((this.後腕左s != null) ? this.後腕左s.Length : 0)];
			if (this.胸.肩右_接続 != null)
			{
				this.後脇右s = this.胸.肩右_接続.GetEles<肩>().ToArray<肩>();
				this.肩右 = this.後脇右s.LastOrDefault<肩>();
				if (this.後脇右s.Length > 1)
				{
					this.後腕右s = new List<Ele>[this.後脇右s.Length - 1];
					for (int l = 0; l < this.後腕右s.Length; l++)
					{
						this.後腕右s[l] = new List<Ele>();
						this.Sort(this.後脇右s[l].EnumEle(), this.後腕右s[l]);
					}
					if (this.肩右.上腕_接続 != null)
					{
						this.Sort((from e in this.肩右.上腕_接続
						select e.EnumEle()).JoinEnum<Ele>(), this.腕右);
					}
				}
				else if (this.後脇右s.Length == 1 && this.肩右.上腕_接続 != null)
				{
					this.後腕右s = new List<Ele>[this.肩右.上腕_接続.Length - 1];
					for (int m = 0; m < this.後腕右s.Length; m++)
					{
						this.後腕右s[m] = new List<Ele>();
						this.Sort(this.肩右.上腕_接続[m].EnumEle(), this.後腕右s[m]);
					}
					this.Sort(this.肩右.上腕_接続.Last<Ele>().EnumEle(), this.腕右);
				}
				this.後脇右s = this.後脇右s.Take(this.後脇右s.Length - 1).ToArray<肩>();
			}
			this.nsr = new bool[1 + ((this.後腕右s != null) ? this.後腕右s.Length : 0)];
			if (this.胸.翼上左_接続 != null)
			{
				this.Sort((from e in this.胸.翼上左_接続
				select e.EnumEle()).JoinEnum<Ele>(), this.胸上左接続);
			}
			if (this.胸.翼下左_接続 != null)
			{
				this.Sort((from e in this.胸.翼下左_接続
				select e.EnumEle()).JoinEnum<Ele>(), this.胸下左接続);
			}
			if (this.胸.翼上右_接続 != null)
			{
				this.Sort((from e in this.胸.翼上右_接続
				select e.EnumEle()).JoinEnum<Ele>(), this.胸上右接続);
			}
			if (this.胸.翼下右_接続 != null)
			{
				this.Sort((from e in this.胸.翼下右_接続
				select e.EnumEle()).JoinEnum<Ele>(), this.胸下右接続);
			}
			if (this.胴.翼左_接続 != null)
			{
				this.Sort((from e in this.胴.翼左_接続
				select e.EnumEle()).JoinEnum<Ele>(), this.胴後左接続);
			}
			if (this.胴.翼右_接続 != null)
			{
				this.Sort((from e in this.胴.翼右_接続
				select e.EnumEle()).JoinEnum<Ele>(), this.胴後右接続);
			}
			if (this.腰.翼左_接続 != null)
			{
				this.Sort((from e in this.腰.翼左_接続
				select e.EnumEle()).JoinEnum<Ele>(), this.腰後左接続);
			}
			if (this.腰.翼右_接続 != null)
			{
				this.Sort((from e in this.腰.翼右_接続
				select e.EnumEle()).JoinEnum<Ele>(), this.腰後右接続);
			}
			if (this.胸.背中_接続 != null)
			{
				this.Sort((from e in this.胸.背中_接続
				select e.EnumEle()).JoinEnum<Ele>(), this.背中接続);
			}
			if (this.腰.腿左_接続 != null)
			{
				this.Sort((from e in this.腰.腿左_接続
				where !(e is 腿)
				select e.EnumEle()).JoinEnum<Ele>(), this.腿左接続);
				this.Sort((from e in this.腰.腿左_接続.GetEles<腿>()
				select e.EnumEle()).JoinEnum<Ele>(), this.腿左接続);
			}
			if (this.腰.腿右_接続 != null)
			{
				this.Sort((from e in this.腰.腿右_接続
				where !(e is 腿)
				select e.EnumEle()).JoinEnum<Ele>(), this.腿右接続);
				this.Sort((from e in this.腰.腿右_接続.GetEles<腿>()
				select e.EnumEle()).JoinEnum<Ele>(), this.腿右接続);
			}
			if (this.腰.尾_接続 != null)
			{
				this.Sort((from e in this.腰.尾_接続
				select e.EnumEle()).JoinEnum<Ele>(), this.尾接続);
			}
			if (this.腰.半身_接続 != null)
			{
				半身 ele2 = this.腰.半身_接続.GetEle<半身>();
				if (ele2 is 長物_魚)
				{
					this.Is魚 = true;
					this.魚 = (長物_魚)ele2;
					this.腰.腰CD.c2.Col2 = this.魚.胴1_胴1CD.c2.Col1;
					this.半身中1接続.Add(this.魚);
					if (this.魚.尾_接続 != null)
					{
						this.Sort((from e in this.魚.尾_接続
						select e.EnumEle()).JoinEnum<Ele>(), this.半身後接続);
					}
					if (this.腕獣左.Count > 0 && this.腕獣左.First<腕獣>().肩.上腕_接続.IsEle<獣脚>())
					{
						this.Sort(from e in this.魚.EnumEle().Skip(1)
						where !CS$<>8__locals1.<>4__this.半身後接続.Contains(e)
						select e, this.半身前接続);
					}
					else
					{
						this.Sort(from e in this.魚.EnumEle().Skip(1)
						where !CS$<>8__locals1.<>4__this.半身後接続.Contains(e)
						select e, this.半身中2接続);
						foreach (Ele item in (from e in this.腿左接続
						where !(e is 腿) && !(e.Par is 腿) && !(e.Par is 脚 | e.Par is 足)
						select e).ToArray<Ele>())
						{
							this.腿左接続.Remove(item);
							this.半身前接続.Add(item);
						}
						foreach (Ele item2 in (from e in this.腿右接続
						where !(e is 腿) && !(e.Par is 腿) && !(e.Par is 脚 | e.Par is 足)
						select e).ToArray<Ele>())
						{
							this.腿右接続.Remove(item2);
							this.半身前接続.Add(item2);
						}
					}
				}
				else if (ele2 is 長物_鯨)
				{
					this.Is鯨 = true;
					this.鯨 = (長物_鯨)ele2;
					this.腰.腰CD.c2.Col2 = this.鯨.胴1_胴CD.c2.Col1;
					this.半身中1接続.Add(this.鯨);
					if (this.鯨.尾_接続 != null)
					{
						this.Sort((from e in this.鯨.尾_接続
						select e.EnumEle()).JoinEnum<Ele>(), this.半身後接続);
					}
					if (this.腕獣左.Count > 0 && this.腕獣左.First<腕獣>().肩.上腕_接続.IsEle<獣脚>())
					{
						this.Sort(from e in this.鯨.EnumEle().Skip(1)
						where !CS$<>8__locals1.<>4__this.半身後接続.Contains(e)
						select e, this.半身前接続);
					}
					else
					{
						this.Sort(from e in this.鯨.EnumEle().Skip(1)
						where !CS$<>8__locals1.<>4__this.半身後接続.Contains(e)
						select e, this.半身中2接続);
						foreach (Ele item3 in (from e in this.腿左接続
						where !(e is 腿) && !(e.Par is 腿) && !(e.Par is 脚 | e.Par is 足)
						select e).ToArray<Ele>())
						{
							this.腿左接続.Remove(item3);
							this.半身前接続.Add(item3);
						}
						foreach (Ele item4 in (from e in this.腿右接続
						where !(e is 腿) && !(e.Par is 腿) && !(e.Par is 脚 | e.Par is 足)
						select e).ToArray<Ele>())
						{
							this.腿右接続.Remove(item4);
							this.半身前接続.Add(item4);
						}
					}
				}
				else if (ele2 is 長物_蛇)
				{
					this.Is蛇 = true;
					this.蛇 = (長物_蛇)ele2;
					this.腰.腰CD.c2.Col2 = this.蛇.胴1_鱗1CD.c2.Col1;
					this.半身中1接続.Add(ele2);
					if (this.蛇.胴_接続 != null)
					{
						foreach (胴_蛇 胴_蛇 in this.蛇.EnumEle().GetEles<胴_蛇>().Reverse<胴_蛇>())
						{
							if (胴_蛇.左_接続 != null)
							{
								this.Sort((from e in 胴_蛇.左_接続
								select e.EnumEle()).JoinEnum<Ele>(), this.半身中2接続);
							}
							if (胴_蛇.右_接続 != null)
							{
								this.Sort((from e in 胴_蛇.右_接続
								select e.EnumEle()).JoinEnum<Ele>(), this.半身中2接続);
							}
						}
						this.Sort(from e in (from e in this.蛇.胴_接続
						select e.EnumEle()).JoinEnum<Ele>()
						where !CS$<>8__locals1.<>4__this.半身中2接続.Contains(e)
						select e, this.半身後接続);
					}
					this.蛇前 = new DE(this.蛇, new Action<Are>(this.蛇.前描画));
					if (this.蛇.左_接続 != null)
					{
						this.Sort((from e in this.蛇.左_接続
						select e.EnumEle()).JoinEnum<Ele>(), this.半身前接続);
					}
					if (this.蛇.右_接続 != null)
					{
						this.Sort((from e in this.蛇.右_接続
						select e.EnumEle()).JoinEnum<Ele>(), this.半身前接続);
					}
					節足 ele3 = this.半身中2接続.GetEle<節足>();
					if (ele3 != null && (((ele3 is 節足_足蜘 || ele3 is 節足_足蠍) && !ele3.反転Y) || (ele3 is 節足_足百 && ele3.反転Y)))
					{
						this.半身中2接続.Reverse();
					}
					foreach (Ele item5 in (from e in this.腿左接続
					where !(e is 腿) && !(e.Par is 腿) && !(e.Par is 脚 | e.Par is 足)
					select e).ToArray<Ele>())
					{
						this.腿左接続.Remove(item5);
						this.半身前接続.Add(item5);
					}
					foreach (Ele item6 in (from e in this.腿右接続
					where !(e is 腿) && !(e.Par is 腿) && !(e.Par is 脚 | e.Par is 足)
					select e).ToArray<Ele>())
					{
						this.腿右接続.Remove(item6);
						this.半身前接続.Add(item6);
					}
				}
				else if (ele2 is 長物_蟲)
				{
					this.Is蟲 = true;
					this.蟲 = (長物_蟲)ele2;
					this.腰.腰CD.c2.Col2 = this.蟲.胴1_胴CD.c2.Col1;
					this.半身中1接続.Add(ele2);
					if (this.蟲.胴_接続 != null)
					{
						foreach (胴_蟲 胴_蟲 in this.蟲.EnumEle().GetEles<胴_蟲>().Reverse<胴_蟲>())
						{
							if (胴_蟲.左_接続 != null)
							{
								this.Sort((from e in 胴_蟲.左_接続
								select e.EnumEle()).JoinEnum<Ele>(), this.半身中2接続);
							}
							if (胴_蟲.右_接続 != null)
							{
								this.Sort((from e in 胴_蟲.右_接続
								select e.EnumEle()).JoinEnum<Ele>(), this.半身中2接続);
							}
						}
						this.Sort(from e in (from e in this.蟲.胴_接続
						select e.EnumEle()).JoinEnum<Ele>()
						where !CS$<>8__locals1.<>4__this.半身中2接続.Contains(e)
						select e, this.半身後接続);
					}
					if (this.蟲.左1_接続 != null)
					{
						this.Sort((from e in this.蟲.左1_接続
						select e.EnumEle()).JoinEnum<Ele>(), this.半身前接続);
					}
					if (this.蟲.右1_接続 != null)
					{
						this.Sort((from e in this.蟲.右1_接続
						select e.EnumEle()).JoinEnum<Ele>(), this.半身前接続);
					}
					if (this.蟲.左0_接続 != null)
					{
						this.Sort((from e in this.蟲.左0_接続
						select e.EnumEle()).JoinEnum<Ele>(), this.半身前接続);
					}
					if (this.蟲.右0_接続 != null)
					{
						this.Sort((from e in this.蟲.右0_接続
						select e.EnumEle()).JoinEnum<Ele>(), this.半身前接続);
					}
					節足 ele4 = this.半身中2接続.GetEle<節足>();
					if (ele4 != null && (((ele4 is 節足_足蜘 || ele4 is 節足_足蠍) && !ele4.反転Y) || (ele4 is 節足_足百 && ele4.反転Y)))
					{
						this.半身中2接続.Reverse();
					}
				}
				else if (ele2 is 四足胸)
				{
					this.Is獣 = true;
					foreach (Ele ele5 in ele2.EnumEle())
					{
						if (ele5 is 四足胸)
						{
							this.胸_獣 = (四足胸)ele5;
						}
						else if (ele5 is 四足胴)
						{
							this.胴_獣 = (四足胴)ele5;
						}
						else if (ele5 is 四足腰)
						{
							this.腰_獣 = (四足腰)ele5;
						}
						else if (ele5 is 四足脇)
						{
							if (ele5.右)
							{
								this.脇右_獣.Add((四足脇)ele5);
							}
							else
							{
								this.脇左_獣.Add((四足脇)ele5);
							}
						}
						else if (ele5 is 胸肌)
						{
							this.胸肌_獣 = (胸肌)ele5;
						}
						else if (ele5 is 胴肌)
						{
							this.胴肌_獣 = (胴肌)ele5;
						}
						else if (ele5 is 腰肌)
						{
							this.腰肌_獣 = (腰肌)ele5;
						}
						else if (ele5 is 胸毛)
						{
							this.胸毛_獣 = (胸毛)ele5;
						}
						else if (ele5 is ボテ腹_獣)
						{
							this.ボテ腹_獣 = (ボテ腹_獣)ele5;
						}
						else if (ele5 is 肛門_獣)
						{
							this.肛門_獣 = (肛門_獣)ele5;
						}
						else if (ele5 is 肛門精液_獣)
						{
							this.肛門精液_獣 = (肛門精液_獣)ele5;
						}
						else if (ele5 is 膣基_獣)
						{
							this.膣基_獣 = (膣基_獣)ele5;
						}
						else if (ele5 is 膣内精液_獣)
						{
							this.膣内精液_獣 = (膣内精液_獣)ele5;
						}
						else if (ele5 is 断面_獣)
						{
							this.断面_獣 = (断面_獣)ele5;
						}
						else if (ele5 is 性器_獣)
						{
							this.性器_獣 = (性器_獣)ele5;
						}
						else if (ele5 is 性器精液_獣)
						{
							this.性器精液_獣 = (性器精液_獣)ele5;
						}
						else if (ele5 is 飛沫_獣)
						{
							this.飛沫_獣 = (飛沫_獣)ele5;
						}
						else if (ele5 is 潮吹_小_獣)
						{
							this.潮吹_小_獣 = (潮吹_小_獣)ele5;
						}
						else if (ele5 is 潮吹_大_獣)
						{
							this.潮吹_大_獣 = (潮吹_大_獣)ele5;
						}
						else if (ele5 is 放尿_獣)
						{
							this.放尿_獣 = (放尿_獣)ele5;
						}
						else if (ele5 is ピアス)
						{
							this.ピアス = (ピアス)ele5;
						}
						else if (ele5 is キャップ1)
						{
							this.キャップ1 = (キャップ1)ele5;
						}
					}
					this.胸肌_獣.SetHitFalse();
					this.胴肌_獣.SetHitFalse();
					this.腰肌_獣.SetHitFalse();
					this.腰肌_獣.X0Y0_陰毛.Hit = true;
					this.腰肌_獣.X0Y0_陰毛_ハ\u30FCト.Hit = true;
					this.腰肌_獣.X0Y0_獣性_獣毛.Hit = true;
					this.腰肌_獣.X0Y1_陰毛.Hit = true;
					this.腰肌_獣.X0Y1_陰毛_ハ\u30FCト.Hit = true;
					this.腰肌_獣.X0Y1_獣性_獣毛.Hit = true;
					this.腰肌_獣.X0Y2_陰毛.Hit = true;
					this.腰肌_獣.X0Y2_陰毛_ハ\u30FCト.Hit = true;
					this.腰肌_獣.X0Y2_獣性_獣毛.Hit = true;
					this.腰肌_獣.X0Y3_陰毛.Hit = true;
					this.腰肌_獣.X0Y3_陰毛_ハ\u30FCト.Hit = true;
					this.腰肌_獣.X0Y3_獣性_獣毛.Hit = true;
					this.腰肌_獣.X0Y4_陰毛.Hit = true;
					this.腰肌_獣.X0Y4_陰毛_ハ\u30FCト.Hit = true;
					this.腰肌_獣.X0Y4_獣性_獣毛.Hit = true;
					this.肛門精液_獣.SetHitFalse();
					this.膣基_獣.SetHitFalse();
					this.膣内精液_獣.SetHitFalse();
					this.断面_獣.SetHitFalse();
					this.性器精液_獣.SetHitFalse();
					this.飛沫_獣.SetHitFalse();
					this.潮吹_小_獣.SetHitFalse();
					this.潮吹_大_獣.SetHitFalse();
					this.放尿_獣.SetHitFalse();
					this.ピアス.SetHitFalse();
					this.腰.腰CD.c2.Col2 = this.胸_獣.胸郭CD.c2.Col1;
					if (this.腰_獣 != null)
					{
						this.半身中1接続.Add(this.腰_獣);
					}
					if (this.胴_獣 != null)
					{
						this.半身中1接続.Add(this.胴_獣);
					}
					if (this.胸_獣 != null)
					{
						this.半身中1接続.Add(new DE(this.胸_獣, new Action<Are>(this.胸_獣.胸描画)));
					}
					if (this.胸_獣 != null)
					{
						this.半身中1接続.Add(new DE(this.胸_獣, new Action<Are>(this.胸_獣.肌描画)));
					}
					if (this.ボテ腹_獣 != null)
					{
						this.半身中1接続.Add(this.ボテ腹_獣);
					}
					if (this.腰肌_獣 != null)
					{
						this.半身中1接続.Add(this.腰肌_獣);
					}
					if (this.胴肌_獣 != null)
					{
						this.半身中1接続.Add(this.胴肌_獣);
					}
					if (this.胸肌_獣 != null)
					{
						this.半身中2接続.Add(this.胸肌_獣);
					}
					if (this.脇左_獣 != null)
					{
						this.Sort((from e in this.脇左_獣
						select e.EnumEle().Skip(1)).JoinEnum<Ele>(), this.半身前接続);
					}
					if (this.脇右_獣 != null)
					{
						this.Sort((from e in this.脇右_獣
						select e.EnumEle().Skip(1)).JoinEnum<Ele>(), this.半身前接続);
					}
					if (this.腰_獣 != null)
					{
						if (this.腰_獣.腿左_接続 != null)
						{
							this.Sort((from e in this.腰_獣.腿左_接続
							select e.EnumEle()).JoinEnum<Ele>(), this.半身前接続);
						}
						if (this.腰_獣.腿右_接続 != null)
						{
							this.Sort((from e in this.腰_獣.腿右_接続
							select e.EnumEle()).JoinEnum<Ele>(), this.半身前接続);
						}
						if (this.腰_獣.翼左_接続 != null)
						{
							this.Sort((from e in this.腰_獣.翼左_接続
							select e.EnumEle()).JoinEnum<Ele>(), this.半身後接続);
						}
						if (this.腰_獣.翼右_接続 != null)
						{
							this.Sort((from e in this.腰_獣.翼右_接続
							select e.EnumEle()).JoinEnum<Ele>(), this.半身後接続);
						}
						if (this.腰_獣.尾_接続 != null)
						{
							this.Sort((from e in this.腰_獣.尾_接続
							select e.EnumEle()).JoinEnum<Ele>(), this.半身中1接続);
						}
						if (this.腰_獣.半身_接続 != null)
						{
							this.Sort((from e in this.腰_獣.半身_接続
							select e.EnumEle()).JoinEnum<Ele>(), this.半身中1接続);
						}
					}
					if (this.胴_獣 != null)
					{
						if (this.胴_獣.翼左_接続 != null)
						{
							this.Sort((from e in this.胴_獣.翼左_接続
							select e.EnumEle()).JoinEnum<Ele>(), this.半身後接続);
						}
						if (this.胴_獣.翼右_接続 != null)
						{
							this.Sort((from e in this.胴_獣.翼右_接続
							select e.EnumEle()).JoinEnum<Ele>(), this.半身後接続);
						}
					}
					if (this.胸_獣 != null)
					{
						if (this.胸_獣.背中_接続 != null)
						{
							this.Sort((from e in this.胸_獣.背中_接続
							select e.EnumEle()).JoinEnum<Ele>(), this.半身後接続);
						}
						if (this.胸_獣.翼上左_接続 != null)
						{
							this.Sort((from e in this.胸_獣.翼上左_接続
							select e.EnumEle()).JoinEnum<Ele>(), this.半身後接続);
						}
						if (this.胸_獣.翼下左_接続 != null)
						{
							this.Sort((from e in this.胸_獣.翼下左_接続
							select e.EnumEle()).JoinEnum<Ele>(), this.半身後接続);
						}
						if (this.胸_獣.翼上右_接続 != null)
						{
							this.Sort((from e in this.胸_獣.翼上右_接続
							select e.EnumEle()).JoinEnum<Ele>(), this.半身後接続);
						}
						if (this.胸_獣.翼下右_接続 != null)
						{
							this.Sort((from e in this.胸_獣.翼下右_接続
							select e.EnumEle()).JoinEnum<Ele>(), this.半身後接続);
						}
					}
					if (this.胸毛_獣 != null)
					{
						if (this.捲り判定0)
						{
							this.半身前接続.Add(this.胸毛_獣);
						}
						else
						{
							this.半身中2接続.Add(this.胸毛_獣);
						}
					}
					this.Sort(from e in ele2.EnumEle().Skip(1)
					where !CS$<>8__locals1.<>4__this.半身前接続.Contains(e) && !CS$<>8__locals1.<>4__this.半身中1接続.Contains(e) && !CS$<>8__locals1.<>4__this.半身後接続.Contains(e) && !(e is 四足脇) && e != CS$<>8__locals1.<>4__this.肛門_獣 && e != CS$<>8__locals1.<>4__this.肛門精液_獣 && e != CS$<>8__locals1.<>4__this.膣基_獣 && e != CS$<>8__locals1.<>4__this.膣内精液_獣 && e != CS$<>8__locals1.<>4__this.断面_獣 && e != CS$<>8__locals1.<>4__this.性器_獣 && e != CS$<>8__locals1.<>4__this.性器精液_獣 && e != CS$<>8__locals1.<>4__this.飛沫_獣 && e != CS$<>8__locals1.<>4__this.潮吹_小_獣 && e != CS$<>8__locals1.<>4__this.潮吹_大_獣 && e != CS$<>8__locals1.<>4__this.放尿_獣 && e != CS$<>8__locals1.<>4__this.ピアス && e != CS$<>8__locals1.<>4__this.キャップ1
					select e, this.半身後接続);
				}
				else if (ele2 is 多足_蛸)
				{
					this.Is蛸 = true;
					this.蛸 = (多足_蛸)ele2;
					this.腰.腰CD.c2.Col2 = this.蛸.胴CD.c2.Col1;
					this.半身中1接続.Add(this.蛸);
					if (this.蛸.軟体内左_接続 != null)
					{
						this.Sort((from e in this.蛸.軟体内左_接続
						select e.EnumEle()).JoinEnum<Ele>(), this.半身中2接続);
					}
					if (this.蛸.軟体内右_接続 != null)
					{
						this.Sort((from e in this.蛸.軟体内右_接続
						select e.EnumEle()).JoinEnum<Ele>(), this.半身中2接続);
					}
					if (this.蛸.軟体外左_接続 != null)
					{
						this.Sort((from e in this.蛸.軟体外左_接続
						select e.EnumEle()).JoinEnum<Ele>(), this.半身中2接続);
					}
					if (this.蛸.軟体外右_接続 != null)
					{
						this.Sort((from e in this.蛸.軟体外右_接続
						select e.EnumEle()).JoinEnum<Ele>(), this.半身中2接続);
					}
					foreach (Ele item7 in (from e in this.腿左接続
					where !(e is 腿) && !(e.Par is 腿) && !(e.Par is 脚 | e.Par is 足)
					select e).ToArray<Ele>())
					{
						this.腿左接続.Remove(item7);
						this.半身前接続.Add(item7);
					}
					foreach (Ele item8 in (from e in this.腿右接続
					where !(e is 腿) && !(e.Par is 腿) && !(e.Par is 脚 | e.Par is 足)
					select e).ToArray<Ele>())
					{
						this.腿右接続.Remove(item8);
						this.半身前接続.Add(item8);
					}
				}
				else if (ele2 is 多足_蜘)
				{
					this.Is蜘 = true;
					this.蜘 = (多足_蜘)ele2;
					this.腰.腰CD.c2.Col2 = this.蜘.柄CD.c2.Col2;
					if (this.蜘.尾_接続 != null)
					{
						this.Sort((from e in this.蜘.尾_接続
						select e.EnumEle()).JoinEnum<Ele>(), this.半身後接続);
					}
					this.半身中1接続.Add(this.蜘);
					if (this.蜘.触肢左_接続 != null)
					{
						this.Sort((from e in this.蜘.触肢左_接続
						select e.EnumEle()).JoinEnum<Ele>(), this.半身前接続);
					}
					if (this.蜘.触肢右_接続 != null)
					{
						this.Sort((from e in this.蜘.触肢右_接続
						select e.EnumEle()).JoinEnum<Ele>(), this.半身前接続);
					}
					if (this.蜘.節足左1_接続 != null)
					{
						this.Sort((from e in this.蜘.節足左1_接続
						select e.EnumEle()).JoinEnum<Ele>(), this.半身前接続);
					}
					if (this.蜘.節足右1_接続 != null)
					{
						this.Sort((from e in this.蜘.節足右1_接続
						select e.EnumEle()).JoinEnum<Ele>(), this.半身前接続);
					}
					if (this.蜘.節足左2_接続 != null)
					{
						this.Sort((from e in this.蜘.節足左2_接続
						select e.EnumEle()).JoinEnum<Ele>(), this.半身前接続);
					}
					if (this.蜘.節足右2_接続 != null)
					{
						this.Sort((from e in this.蜘.節足右2_接続
						select e.EnumEle()).JoinEnum<Ele>(), this.半身前接続);
					}
					if (this.蜘.節足左3_接続 != null && !this.蜘.節足左3_接続.IsEle<節足_足百>())
					{
						if (this.蜘.節足左3_接続.Any((Ele e_) => e_.反転Y))
						{
							if (this.蜘.節足左4_接続 != null)
							{
								this.Sort((from e in this.蜘.節足左4_接続
								select e.EnumEle()).JoinEnum<Ele>(), this.半身前接続);
							}
							if (this.蜘.節足右4_接続 != null)
							{
								this.Sort((from e in this.蜘.節足右4_接続
								select e.EnumEle()).JoinEnum<Ele>(), this.半身前接続);
							}
							if (this.蜘.節足左3_接続 != null)
							{
								this.Sort((from e in this.蜘.節足左3_接続
								select e.EnumEle()).JoinEnum<Ele>(), this.半身前接続);
							}
							if (this.蜘.節足右3_接続 != null)
							{
								this.Sort((from e in this.蜘.節足右3_接続
								select e.EnumEle()).JoinEnum<Ele>(), this.半身前接続);
								goto IL_6434;
							}
							goto IL_6434;
						}
					}
					if (this.蜘.節足左3_接続 != null)
					{
						this.Sort((from e in this.蜘.節足左3_接続
						select e.EnumEle()).JoinEnum<Ele>(), this.半身前接続);
					}
					if (this.蜘.節足右3_接続 != null)
					{
						this.Sort((from e in this.蜘.節足右3_接続
						select e.EnumEle()).JoinEnum<Ele>(), this.半身前接続);
					}
					if (this.蜘.節足左4_接続 != null)
					{
						this.Sort((from e in this.蜘.節足左4_接続
						select e.EnumEle()).JoinEnum<Ele>(), this.半身前接続);
					}
					if (this.蜘.節足右4_接続 != null)
					{
						this.Sort((from e in this.蜘.節足右4_接続
						select e.EnumEle()).JoinEnum<Ele>(), this.半身前接続);
					}
				}
				else if (ele2 is 多足_蠍)
				{
					this.Is蠍 = true;
					this.蠍 = (多足_蠍)ele2;
					this.腰.腰CD.c2.Col2 = this.蠍.前腹_腹節3_節0CD.c2.Col1;
					if (this.蠍.尾_接続 != null)
					{
						this.Sort((from e in this.蠍.尾_接続
						select e.EnumEle()).JoinEnum<Ele>(), this.半身後接続);
					}
					this.半身中1接続.Add(this.蠍);
					this.蠍前 = new DE(this.蠍, new Action<Are>(this.蠍.前描画));
					if (this.蠍.触肢左_接続 != null)
					{
						this.Sort((from e in this.蠍.触肢左_接続
						select e.EnumEle()).JoinEnum<Ele>(), this.半身前接続);
					}
					if (this.蠍.節足左1_接続 != null)
					{
						this.Sort((from e in this.蠍.節足左1_接続
						select e.EnumEle()).JoinEnum<Ele>(), this.半身前接続);
					}
					if (this.蠍.節足左2_接続 != null)
					{
						this.Sort((from e in this.蠍.節足左2_接続
						select e.EnumEle()).JoinEnum<Ele>(), this.半身前接続);
					}
					if (this.蠍.節足左3_接続 != null)
					{
						this.Sort((from e in this.蠍.節足左3_接続
						select e.EnumEle()).JoinEnum<Ele>(), this.半身前接続);
					}
					if (this.蠍.節足左4_接続 != null)
					{
						this.Sort((from e in this.蠍.節足左4_接続
						select e.EnumEle()).JoinEnum<Ele>(), this.半身前接続);
					}
					if (this.蠍.櫛状板左_接続 != null)
					{
						this.Sort((from e in this.蠍.櫛状板左_接続
						select e.EnumEle()).JoinEnum<Ele>(), this.半身前接続);
					}
					if (this.蠍.触肢右_接続 != null)
					{
						this.Sort((from e in this.蠍.触肢右_接続
						select e.EnumEle()).JoinEnum<Ele>(), this.半身前接続);
					}
					if (this.蠍.節足右1_接続 != null)
					{
						this.Sort((from e in this.蠍.節足右1_接続
						select e.EnumEle()).JoinEnum<Ele>(), this.半身前接続);
					}
					if (this.蠍.節足右2_接続 != null)
					{
						this.Sort((from e in this.蠍.節足右2_接続
						select e.EnumEle()).JoinEnum<Ele>(), this.半身前接続);
					}
					if (this.蠍.節足右3_接続 != null)
					{
						this.Sort((from e in this.蠍.節足右3_接続
						select e.EnumEle()).JoinEnum<Ele>(), this.半身前接続);
					}
					if (this.蠍.節足右4_接続 != null)
					{
						this.Sort((from e in this.蠍.節足右4_接続
						select e.EnumEle()).JoinEnum<Ele>(), this.半身前接続);
					}
					if (this.蠍.櫛状板右_接続 != null)
					{
						this.Sort((from e in this.蠍.櫛状板右_接続
						select e.EnumEle()).JoinEnum<Ele>(), this.半身前接続);
					}
				}
				else if (ele2 is 単足_植)
				{
					this.Is植 = true;
					this.植 = (単足_植)ele2;
					this.Sort(this.植.EnumEle(), this.半身中1接続);
					foreach (Ele item9 in (from e in this.腿左接続
					where !(e is 腿) && !(e.Par is 腿) && !(e.Par is 脚 | e.Par is 足)
					select e).ToArray<Ele>())
					{
						this.腿左接続.Remove(item9);
						this.半身前接続.Add(item9);
					}
					foreach (Ele item10 in (from e in this.腿右接続
					where !(e is 腿) && !(e.Par is 腿) && !(e.Par is 脚 | e.Par is 足)
					select e).ToArray<Ele>())
					{
						this.腿右接続.Remove(item10);
						this.半身前接続.Add(item10);
					}
				}
				IL_6434:
				if (ele2 is 単足_粘)
				{
					this.Is粘 = true;
					this.粘 = (単足_粘)ele2;
					this.Sort(this.粘.EnumEle(), this.半身後接続);
					foreach (Ele item11 in (from e in this.腿左接続
					where !(e is 腿) && !(e.Par is 腿) && !(e.Par is 脚 | e.Par is 足)
					select e).ToArray<Ele>())
					{
						this.腿左接続.Remove(item11);
						this.半身前接続.Add(item11);
					}
					foreach (Ele item12 in (from e in this.腿右接続
					where !(e is 腿) && !(e.Par is 腿) && !(e.Par is 脚 | e.Par is 足)
					select e).ToArray<Ele>())
					{
						this.腿右接続.Remove(item12);
						this.半身前接続.Add(item12);
					}
				}
			}
			foreach (蝙通常 蝙通常 in this.蝙通常)
			{
				this.Inserts(蝙通常.上腕, 0, 蝙通常.上腕.飛膜);
				this.Inserts(蝙通常.手, -2, 蝙通常.手.飛膜);
				this.Inserts(蝙通常.手.飛膜, 1, new DE(蝙通常.手, new Action<Are>(蝙通常.手.指先描画)));
			}
			大顎基 ele6 = this.大顎基接続.GetEle<大顎基>();
			if (ele6 != null)
			{
				Ele io = ele6;
				int num = 1;
				int num2;
				if (ele6.顎左_接続 == null)
				{
					num2 = 0;
				}
				else
				{
					num2 = (from f in ele6.顎左_接続
					select f.EnumEle()).JoinEnum<Ele>().Count<Ele>();
				}
				int num3 = num + num2;
				int num4;
				if (ele6.顎右_接続 == null)
				{
					num4 = 0;
				}
				else
				{
					num4 = (from f in ele6.顎右_接続
					select f.EnumEle()).JoinEnum<Ele>().Count<Ele>();
				}
				this.Inserts(io, num3 + num4, ele6.大顎上);
			}
			foreach (腕人 腕人3 in this.腕人左)
			{
				if (腕人3.下腕 != null)
				{
					Ele 下腕 = 腕人3.下腕;
					int num5 = 1;
					int num6;
					if (腕人3.下腕.手_接続 == null)
					{
						num6 = 0;
					}
					else
					{
						num6 = (from f in 腕人3.下腕.手_接続
						select f.EnumEle()).JoinEnum<Ele>().Count<Ele>();
					}
					int num7 = num5 + num6;
					int num8;
					if (腕人3.下腕.虫鎌_接続 == null)
					{
						num8 = 0;
					}
					else
					{
						num8 = (from f in 腕人3.下腕.虫鎌_接続
						select f.EnumEle()).JoinEnum<Ele>().Count<Ele>();
					}
					this.Inserts(下腕, num7 + num8, new DE(腕人3.下腕, new Action<Are>(腕人3.下腕.外腕描画)));
				}
			}
			foreach (腕人 腕人2 in this.腕人右)
			{
				if (腕人2.下腕 != null)
				{
					Ele 下腕2 = 腕人2.下腕;
					int num9 = 1;
					int num10;
					if (腕人2.下腕.手_接続 == null)
					{
						num10 = 0;
					}
					else
					{
						num10 = (from f in 腕人2.下腕.手_接続
						select f.EnumEle()).JoinEnum<Ele>().Count<Ele>();
					}
					int num11 = num9 + num10;
					int num12;
					if (腕人2.下腕.虫鎌_接続 == null)
					{
						num12 = 0;
					}
					else
					{
						num12 = (from f in 腕人2.下腕.虫鎌_接続
						select f.EnumEle()).JoinEnum<Ele>().Count<Ele>();
					}
					this.Inserts(下腕2, num11 + num12, new DE(腕人2.下腕, new Action<Are>(腕人2.下腕.外腕描画)));
				}
			}
			foreach (腕翼鳥 腕翼鳥3 in this.腕翼鳥左)
			{
				if (腕翼鳥3.下腕 != null)
				{
					Ele 下腕3 = 腕翼鳥3.下腕;
					int num13 = 1;
					int num14;
					if (腕翼鳥3.下腕.手_接続 == null)
					{
						num14 = 0;
					}
					else
					{
						num14 = (from f in 腕翼鳥3.下腕.手_接続
						select f.EnumEle()).JoinEnum<Ele>().Count<Ele>();
					}
					this.Inserts(下腕3, num13 + num14, new DE(腕翼鳥3.下腕, new Action<Are>(腕翼鳥3.下腕.小雨覆描画)));
				}
			}
			foreach (翼鳥 翼鳥3 in this.翼鳥左)
			{
				if (翼鳥3.下腕 != null)
				{
					Ele 下腕4 = 翼鳥3.下腕;
					int num15 = 1;
					int num16;
					if (翼鳥3.下腕.手_接続 == null)
					{
						num16 = 0;
					}
					else
					{
						num16 = (from f in 翼鳥3.下腕.手_接続
						select f.EnumEle()).JoinEnum<Ele>().Count<Ele>();
					}
					this.Inserts(下腕4, num15 + num16, new DE(翼鳥3.下腕, new Action<Are>(翼鳥3.下腕.小雨覆描画)));
				}
			}
			foreach (腕翼鳥 腕翼鳥2 in this.腕翼鳥右)
			{
				if (腕翼鳥2.下腕 != null)
				{
					Ele 下腕5 = 腕翼鳥2.下腕;
					int num17 = 1;
					int num18;
					if (腕翼鳥2.下腕.手_接続 == null)
					{
						num18 = 0;
					}
					else
					{
						num18 = (from f in 腕翼鳥2.下腕.手_接続
						select f.EnumEle()).JoinEnum<Ele>().Count<Ele>();
					}
					this.Inserts(下腕5, num17 + num18, new DE(腕翼鳥2.下腕, new Action<Are>(腕翼鳥2.下腕.小雨覆描画)));
				}
			}
			foreach (翼鳥 翼鳥2 in this.翼鳥右)
			{
				if (翼鳥2.下腕 != null)
				{
					Ele 下腕6 = 翼鳥2.下腕;
					int num19 = 1;
					int num20;
					if (翼鳥2.下腕.手_接続 == null)
					{
						num20 = 0;
					}
					else
					{
						num20 = (from f in 翼鳥2.下腕.手_接続
						select f.EnumEle()).JoinEnum<Ele>().Count<Ele>();
					}
					this.Inserts(下腕6, num19 + num20, new DE(翼鳥2.下腕, new Action<Are>(翼鳥2.下腕.小雨覆描画)));
				}
			}
			foreach (腕翼獣 腕翼獣3 in this.腕翼獣左)
			{
				if (腕翼獣3.下腕 != null)
				{
					Ele 下腕7 = 腕翼獣3.下腕;
					int num21 = 1;
					int num22;
					if (腕翼獣3.下腕.手_接続 == null)
					{
						num22 = 0;
					}
					else
					{
						num22 = (from f in 腕翼獣3.下腕.手_接続
						select f.EnumEle()).JoinEnum<Ele>().Count<Ele>();
					}
					this.Inserts(下腕7, num21 + num22, new DE(腕翼獣3.下腕, new Action<Are>(腕翼獣3.下腕.腕輪描画)));
				}
			}
			foreach (翼獣 翼獣3 in this.翼獣左)
			{
				if (翼獣3.下腕 != null)
				{
					Ele 下腕8 = 翼獣3.下腕;
					int num23 = 1;
					int num24;
					if (翼獣3.下腕.手_接続 == null)
					{
						num24 = 0;
					}
					else
					{
						num24 = (from f in 翼獣3.下腕.手_接続
						select f.EnumEle()).JoinEnum<Ele>().Count<Ele>();
					}
					this.Inserts(下腕8, num23 + num24, new DE(翼獣3.下腕, new Action<Are>(翼獣3.下腕.腕輪描画)));
				}
			}
			foreach (腕翼獣 腕翼獣2 in this.腕翼獣右)
			{
				if (腕翼獣2.下腕 != null)
				{
					Ele 下腕9 = 腕翼獣2.下腕;
					int num25 = 1;
					int num26;
					if (腕翼獣2.下腕.手_接続 == null)
					{
						num26 = 0;
					}
					else
					{
						num26 = (from f in 腕翼獣2.下腕.手_接続
						select f.EnumEle()).JoinEnum<Ele>().Count<Ele>();
					}
					this.Inserts(下腕9, num25 + num26, new DE(腕翼獣2.下腕, new Action<Are>(腕翼獣2.下腕.腕輪描画)));
				}
			}
			foreach (翼獣 翼獣2 in this.翼獣右)
			{
				if (翼獣2.下腕 != null)
				{
					Ele 下腕10 = 翼獣2.下腕;
					int num27 = 1;
					int num28;
					if (翼獣2.下腕.手_接続 == null)
					{
						num28 = 0;
					}
					else
					{
						num28 = (from f in 翼獣2.下腕.手_接続
						select f.EnumEle()).JoinEnum<Ele>().Count<Ele>();
					}
					this.Inserts(下腕10, num27 + num28, new DE(翼獣2.下腕, new Action<Are>(翼獣2.下腕.腕輪描画)));
				}
			}
			foreach (脚人 脚人5 in this.脚人左)
			{
				if (脚人5.脚 != null)
				{
					Ele 脚3 = 脚人5.脚;
					int num29 = 1;
					int num30;
					if (脚人5.脚.足_接続 == null)
					{
						num30 = 0;
					}
					else
					{
						num30 = (from f in 脚人5.脚.足_接続
						select f.EnumEle()).JoinEnum<Ele>().Count<Ele>();
					}
					this.Inserts(脚3, num29 + num30, new DE(脚人5.脚, new Action<Are>(脚人5.脚.外描画)));
				}
			}
			foreach (脚人 脚人2 in this.脚人右)
			{
				if (脚人2.脚 != null)
				{
					Ele 脚2 = 脚人2.脚;
					int num31 = 1;
					int num32;
					if (脚人2.脚.足_接続 == null)
					{
						num32 = 0;
					}
					else
					{
						num32 = (from f in 脚人2.脚.足_接続
						select f.EnumEle()).JoinEnum<Ele>().Count<Ele>();
					}
					this.Inserts(脚2, num31 + num32, new DE(脚人2.脚, new Action<Are>(脚人2.脚.外描画)));
				}
			}
			foreach (脚人 脚人3 in this.脚人左)
			{
				if (脚人3.足 != null)
				{
					this.Inserts(脚人3.足, -1, new DE(脚人3.足, new Action<Are>(脚人3.足.底描画)));
					this.Inserts(脚人3.足, 2, new DE(脚人3.足, new Action<Are>(脚人3.足.靴描画)));
				}
			}
			foreach (脚人 脚人4 in this.脚人右)
			{
				if (脚人4.足 != null)
				{
					this.Inserts(脚人4.足, -1, new DE(脚人4.足, new Action<Are>(脚人4.足.底描画)));
					this.Inserts(脚人4.足, 2, new DE(脚人4.足, new Action<Are>(脚人4.足.靴描画)));
				}
			}
			using (List<虫鎌>.Enumerator enumerator12 = this.虫鎌左.GetEnumerator())
			{
				while (enumerator12.MoveNext())
				{
					虫鎌 e = enumerator12.Current;
					if (e.接続情報 == 接続情報.下腕_人_虫鎌_接続)
					{
						int num33 = e.Par.EnumEle().Count((Ele f) => f.Par == e.Par);
						List<Ele> list = this.Inserts(e.Par, 2 + num33, e);
						if (list != null)
						{
							list.Remove(e);
						}
					}
				}
			}
			using (List<虫鎌>.Enumerator enumerator12 = this.虫鎌右.GetEnumerator())
			{
				while (enumerator12.MoveNext())
				{
					虫鎌 e = enumerator12.Current;
					if (e.接続情報 == 接続情報.下腕_人_虫鎌_接続)
					{
						int num33 = e.Par.EnumEle().Count((Ele f) => f.Par == e.Par);
						List<Ele> list = this.Inserts(e.Par, 2 + num33, e);
						if (list != null)
						{
							list.Remove(e);
						}
					}
				}
			}
			Ele ele7 = this.腕左.LastOrDefault((Ele e) => e.Par != null && e.Par.Par != null && e.Par.Par.接続情報 == 接続情報.胸_肩左_接続);
			if (ele7 != null)
			{
				this.下腕以降左.Add(ele7);
			}
			HashSet<Ele> hashSet = new HashSet<Ele>();
			foreach (蝙通常 蝙通常2 in from e in this.蝙通常
			where e.上腕.Par != null && e.上腕.Par.接続情報 == 接続情報.胸_肩左_接続
			select e)
			{
				hashSet.Add(蝙通常2.上腕.飛膜);
				hashSet.Add(蝙通常2.手.飛膜);
			}
			foreach (Ele ele8 in this.腕左)
			{
				if (hashSet.Contains(ele8) || (ele8 is DE && ((DE)ele8).Par is 手_蝙))
				{
					this.肩左飛膜.Add(ele8);
				}
				else if (this.下腕以降左.Contains(ele8.Par) || ele8 is 大顎上 || ele8 is 触肢_肢蠍)
				{
					this.下腕以降左.Add(ele8);
				}
			}
			foreach (Ele item13 in this.下腕以降左)
			{
				this.腕左.Remove(item13);
			}
			foreach (Ele item14 in this.肩左飛膜)
			{
				this.腕左.Remove(item14);
			}
			ele7 = this.腕右.LastOrDefault((Ele e) => e.Par != null && e.Par.Par != null && e.Par.Par.接続情報 == 接続情報.胸_肩右_接続);
			if (ele7 != null)
			{
				this.下腕以降右.Add(ele7);
			}
			hashSet.Clear();
			foreach (蝙通常 蝙通常3 in from e in this.蝙通常
			where e.上腕.Par != null && e.上腕.Par.接続情報 == 接続情報.胸_肩右_接続
			select e)
			{
				hashSet.Add(蝙通常3.上腕.飛膜);
				hashSet.Add(蝙通常3.手.飛膜);
			}
			foreach (Ele ele9 in this.腕右)
			{
				if (hashSet.Contains(ele9) || (ele9 is DE && ((DE)ele9).Par is 手_蝙))
				{
					this.肩右飛膜.Add(ele9);
				}
				else if (this.下腕以降右.Contains(ele9.Par) || ele9 is 大顎上 || ele9 is 触肢_肢蠍)
				{
					this.下腕以降右.Add(ele9);
				}
			}
			foreach (Ele item15 in this.下腕以降右)
			{
				this.腕右.Remove(item15);
			}
			foreach (Ele item16 in this.肩右飛膜)
			{
				this.腕右.Remove(item16);
			}
			foreach (飛膜_根 item17 in this.腕左.GetEles<飛膜_根>().ToArray<飛膜_根>())
			{
				this.肩左飛膜.Add(item17);
				this.腕左.Remove(item17);
			}
			foreach (飛膜_根 item18 in this.腕右.GetEles<飛膜_根>().ToArray<飛膜_根>())
			{
				this.肩右飛膜.Add(item18);
				this.腕右.Remove(item18);
			}
			IEnumerable<Ele> source = this.腰後左接続;
			Func<Ele, bool> predicate;
			if ((predicate = CS$<>8__locals1.<>9__225) == null)
			{
				predicate = (CS$<>8__locals1.<>9__225 = ((Ele e) => e.接続情報 == 接続情報.四足脇_上腕_接続 || CS$<>8__locals1.<>4__this.半身前接続.Contains(e.Par)));
			}
			foreach (Ele item19 in source.Where(predicate))
			{
				this.半身前接続.Add(item19);
			}
			IEnumerable<Ele> source2 = this.腰後右接続;
			Func<Ele, bool> predicate2;
			if ((predicate2 = CS$<>8__locals1.<>9__226) == null)
			{
				predicate2 = (CS$<>8__locals1.<>9__226 = ((Ele e) => e.接続情報 == 接続情報.四足脇_上腕_接続 || CS$<>8__locals1.<>4__this.半身前接続.Contains(e.Par)));
			}
			foreach (Ele item20 in source2.Where(predicate2))
			{
				this.半身前接続.Add(item20);
			}
			foreach (Ele item21 in this.半身前接続)
			{
				this.腰後左接続.Remove(item21);
				this.腰後右接続.Remove(item21);
			}
			獣下腕 下腕左l = (this.腕獣左.Count > 0) ? this.腕獣左[0].下腕 : null;
			獣下腕 下腕右l = (this.腕獣右.Count > 0) ? this.腕獣右[0].下腕 : null;
			if (!this.Is蠍 && !this.Is蜘)
			{
				IEnumerable<Ele> source3 = this.半身前接続;
				Func<Ele, bool> <>9__227;
				Func<Ele, bool> predicate3;
				if ((predicate3 = <>9__227) == null)
				{
					predicate3 = (<>9__227 = ((Ele e) => (e is 下腕 && 下腕左l != e && 下腕右l != e) || e is 上腕 || e is 触肢 || (e.接続情報 == 接続情報.四足脇_上腕_接続 && e is 脚)));
				}
				foreach (Ele item22 in source3.Where(predicate3).ToArray<Ele>())
				{
					this.半身前接続.Remove(item22);
					this.半身中2接続.Add(item22);
				}
			}
			if (this.腰.腿左_接続 != null)
			{
				IEnumerable<触手_犬> eles = this.腰.腿左_接続.GetEles<触手_犬>();
				foreach (触手_犬 触手_犬 in eles.Take(eles.Count<触手_犬>() - 1))
				{
					触手_犬.胴_節1_胴_表示 = false;
					触手_犬.胴_節1_鱗1_表示 = false;
					触手_犬.胴_節1_鱗2_表示 = false;
					触手_犬.胴_節1_鱗3_表示 = false;
				}
			}
			if (this.腰.腿右_接続 != null)
			{
				IEnumerable<触手_犬> eles2 = this.腰.腿右_接続.GetEles<触手_犬>();
				foreach (触手_犬 触手_犬2 in eles2.Take(eles2.Count<触手_犬>() - 1))
				{
					触手_犬2.胴_節1_胴_表示 = false;
					触手_犬2.胴_節1_鱗1_表示 = false;
					触手_犬2.胴_節1_鱗2_表示 = false;
					触手_犬2.胴_節1_鱗3_表示 = false;
				}
			}
			foreach (四足脇 item23 in this.腰後右接続.GetEles<四足脇>().ToArray<四足脇>())
			{
				this.腰後右接続.Remove(item23);
				this.半身後接続.Insert(0, item23);
			}
			foreach (四足脇 item24 in this.腰後左接続.GetEles<四足脇>().ToArray<四足脇>())
			{
				this.腰後左接続.Remove(item24);
				this.半身後接続.Insert(0, item24);
			}
			if (CS$<>8__locals1.Cha.ChaD.固有値 > 0.5)
			{
				大顎 ele10 = this.大顎基接続.GetEle<大顎>();
				if (ele10 != null)
				{
					int num34 = this.大顎基接続.IndexOf(ele10);
					this.大顎基接続.Remove(ele10);
					this.大顎基接続.Insert(num34 + 1, ele10);
				}
			}
			this.耳左 = this.頭.耳左_接続.GetEle<耳>();
			this.耳右 = this.頭.耳右_接続.GetEle<耳>();
			IEnumerable<Ele> src = this.顔触覚左接続.Concat(this.触覚左接続);
			IEnumerable<Ele> src2 = this.顔触覚右接続.Concat(this.触覚右接続);
			this.触覚甲左 = src.GetEle<触覚_甲>();
			this.触覚甲右 = src2.GetEle<触覚_甲>();
			if (this.触覚甲左 == null)
			{
				this.触覚左 = src.GetEle<触覚>();
				this.触覚右 = src2.GetEle<触覚>();
			}
			this.頭色更新 = new 頭色更新(this.頭, this.単眼瞼, this.Is瞼宇 ? null : this.瞼左, this.Is瞼宇 ? null : this.瞼右, this.額瞼, this.頬瞼左, this.頬瞼右);
			this.ドレス色更新 = new ドレス色更新(this.上着T_ドレス, this.上着M_ドレス);
			this.鯨色更新 = from e in this.全要素
			where e.Par != null && e.Par is 長物_鯨 && e is 尾_鯨
			select new 鯨色更新((長物_鯨)e.Par, (尾_鯨)e);
			this.飛膜色更新 = from e in this.蝙通常
			select new 飛膜色更新(e.上腕.飛膜, e.手.飛膜);
			this.色更新 = from e in this.全要素
			where !CS$<>8__locals1.<>4__this.頭色更新.Contains(e) && !CS$<>8__locals1.<>4__this.ドレス色更新.Contains(e) && !CS$<>8__locals1.<>4__this.鯨色更新.Any((鯨色更新 f) => f.Contains(e))
			select e;
			this.Is双眉 = (this.眉左 != null);
			this.Is単眉 = (this.単眼眉 != null);
			this.Is人耳 = (this.耳左 != null);
			this.Is獣耳 = (this.獣耳左 != null);
			this.Is虫角 = this.額接続.IsEle<角1_虫>();
			this.Is虫角前 = (this.Is虫角 && (this.顔面 is 顔面_甲 || this.顔面 is 顔面_虫));
			顔面_甲 顔面_甲 = null;
			if (this.頭.顔面_接続 != null)
			{
				顔面_甲 = this.頭.顔面_接続.GetEle<顔面_甲>();
			}
			if (顔面_甲 != null)
			{
				顔面_甲.面額_表示 = (this.Is虫角前 || this.額接続.Count == 0);
			}
			this.Is鬼角 = this.角左接続.IsEle<角2_鬼>();
			this.Is貧乳 = (this.乳房左.バスト <= 0.2);
			this.Is海洋 = (this.Is魚 || this.Is鯨);
			this.Is長物 = (this.Is蛇 || this.Is蟲);
			this.Is多足 = (this.Is蜘 || this.Is蠍);
			this.Is半身 = (this.Is獣 || this.Is海洋 || this.Is長物 || this.Is多足 || this.Is蛸 || this.Is植 || this.Is粘);
			this.Is顔面 = (this.顔面 != null);
			this.Is頭頂 = (this.頭頂 != null);
			this.Is大顎基 = this.大顎基接続.IsEle<大顎基>();
			this.Is額角 = this.額接続.IsEle<角1>();
			this.Is触覚他 = (this.触覚左 != null);
			this.Is触覚甲 = (this.触覚甲左 != null);
			this.Is触覚 = (this.Is触覚他 || this.Is触覚甲);
			this.Is双眼 = (this.目左 != null);
			this.Is単眼 = (this.単眼目 != null);
			this.Is頬眼 = (this.頬目左 != null);
			this.Is額眼 = (this.額目 != null);
			this.Is舌股 = (this.舌 is 舌_長 && ((舌_長)this.舌).舌股右_舌1_表示);
			this.Is最前腕人 = (this.肩左 != null && this.肩左.上腕_接続.IsEle<上腕_人>());
			this.Is最前手人 = (this.肩左 != null && this.肩左.EnumEle().IsEle<手_人>());
			this.Is腕人 = this.下腕以降左.IsEle<下腕_人>();
			this.Is腕鳥 = this.下腕以降左.IsEle<下腕_鳥>();
			this.Is腕蝙 = this.下腕以降左.IsEle<下腕_蝙>();
			this.Is腕獣 = this.下腕以降左.IsEle<下腕_獣>();
			this.Is腕蠍 = this.下腕以降左.IsEle<触肢_肢蠍>();
			this.Is腿人 = this.腰.腿左_接続.IsEle<腿_人>();
			this.Is腿獣 = this.腰.腿左_接続.IsEle<獣腿>();
			this.Is腿魚 = this.腰.腿左_接続.IsEle<尾_魚>();
			this.Is腿犬 = this.腰.腿左_接続.IsEle<触手_犬>();
			this.紅潮.紅潮線左右表示 = false;
			this.舌_表示 = false;
			if (this.Is頭頂_宇)
			{
				foreach (Ele ele11 in this.顔触覚左接続)
				{
					ele11.接続(this.頭.触覚左_接続点);
				}
				foreach (Ele ele12 in this.顔触覚右接続)
				{
					ele12.接続(this.頭.触覚右_接続点);
				}
				this.耳左接続.SetEles(delegate(耳 e)
				{
					e.Yi = 1;
				});
				this.耳右接続.SetEles(delegate(耳 e)
				{
					e.Yi = 1;
				});
			}
			if (this.Is単眼)
			{
				this.頭.X0Y0_頭.JP[7] = new Joi(this.頭.X0Y0_頭.JP[7].Joint.MulY(0.96));
				this.頭.X0Y0_頭.JP[17] = new Joi(this.頭.X0Y0_頭.JP[17].Joint.MulY(0.96));
				this.頭.X0Y0_頭.JP[18] = new Joi(this.頭.X0Y0_頭.JP[18].Joint.MulY(0.96));
				this.紅潮.紅潮1_表示 = false;
				this.紅潮.X0Y0_紅潮左.AngleBase = 20.0;
				this.紅潮.X0Y0_紅潮弱左.AngleBase = 20.0;
				this.紅潮.X0Y0_紅潮線左.AngleBase = 20.0;
				this.紅潮.X0Y0_紅潮右.AngleBase = -20.0;
				this.紅潮.X0Y0_紅潮弱右.AngleBase = -20.0;
				this.紅潮.X0Y0_紅潮線右.AngleBase = -20.0;
			}
			this.染み_人 = new 染み_人(disUnit, 配色指定.N0, CS$<>8__locals1.Cha.配色, CS$<>8__locals1.Med, new 染み_人D());
			this.染み_人.サイズ = this.全要素.Sum((Ele e) => e.サイズ) / (double)this.全要素.Length;
			this.染み_人.濃度 = 0.0;
			Vector2D positionCont = Dat.Vec2DUnitY * -0.03;
			Vector2D positionCont2 = Dat.Vec2DUnitY * 0.03;
			this.染み_人.X0Y0_汗.PositionCont = positionCont;
			this.染み_人.X0Y0_潮1.PositionCont = positionCont2;
			if (this.Is獣)
			{
				this.膣内精液_獣.濃度 = 0.0;
				this.断面_獣.精液CD.不透明度 = 0.0;
				this.膣基 = this.膣基_獣;
				this.膣内精液 = this.膣内精液_獣;
				this.断面 = this.断面_獣;
				this.性器 = this.性器_獣;
				this.性器精液 = this.性器精液_獣;
				this.飛沫 = this.飛沫_獣;
				this.潮吹_小 = this.潮吹_小_獣;
				this.潮吹_大 = this.潮吹_大_獣;
				this.放尿 = this.放尿_獣;
				this.肛門 = this.肛門_獣;
				this.肛門精液 = this.肛門精液_獣;
				this.膣内精液_獣.精液配色(Sta.GameData.配色);
				this.膣内精液_獣.精液濃度 = 0.0;
				this.断面_獣.精液配色(Sta.GameData.配色);
				this.断面_獣.精液濃度 = 0.0;
				this.性器精液_獣.精液配色(Sta.GameData.配色);
				this.肛門精液_獣.精液配色(Sta.GameData.配色);
				this.染み_獣 = new 染み_獣(disUnit, 配色指定.N0, CS$<>8__locals1.Cha.配色, CS$<>8__locals1.Med, new 染み_獣D());
				this.染み_獣.サイズ = this.全要素.Sum((Ele e) => e.サイズ) / (double)this.全要素.Length;
				this.染み_獣.濃度 = 0.0;
				if (this.胸_獣.脇左_接続.IsEle<四足脇>())
				{
					this.胸_獣.X0Y0_胸郭.OP[0].Outline = false;
					this.胸_獣.X0Y0_胸郭.OP[9].Outline = false;
				}
				Vector2D positionCont3 = new Vector2D(0.0, 0.006);
				this.染み_獣.X0Y0_湯気_湯気左1_湯気2.PositionCont = positionCont3;
				this.染み_獣.X0Y0_湯気_湯気左2_湯気2.PositionCont = positionCont3;
				this.染み_獣.X0Y0_湯気_湯気左3_湯気2.PositionCont = positionCont3;
				this.染み_獣.X0Y0_湯気_湯気右1_湯気2.PositionCont = positionCont3;
				this.染み_獣.X0Y0_湯気_湯気右2_湯気2.PositionCont = positionCont3;
				this.染み_獣.X0Y0_湯気_湯気右3_湯気2.PositionCont = positionCont3;
				this.下着陰核.X0Y0_陰核.SizeBase = this.性器_獣.X0Y0_陰核.SizeBase;
				this.csb = this.性器_獣.X0Y0_陰核.SizeBase;
				this.asb1 = this.肛門_獣.X0Y0_肛門2.SizeBase;
				this.asb2 = this.肛門_獣.X0Y0_肛門3.SizeBase;
				this.染み_獣.X0Y0_汗.PositionCont = positionCont;
				this.染み_獣.X0Y0_潮1.PositionCont = positionCont2;
			}
			else
			{
				this.膣内精液_人.濃度 = 0.0;
				this.断面_人.精液CD.不透明度 = 0.0;
				this.膣基 = this.膣基_人;
				this.膣内精液 = this.膣内精液_人;
				this.断面 = this.断面_人;
				this.性器 = this.性器_人;
				this.性器精液 = this.性器精液_人;
				this.飛沫 = this.飛沫_人;
				this.潮吹_小 = this.潮吹_小_人;
				this.潮吹_大 = this.潮吹_大_人;
				this.放尿 = this.放尿_人;
				this.肛門 = this.肛門_人;
				this.肛門精液 = this.肛門精液_人;
				this.膣内精液_人.精液配色(Sta.GameData.配色);
				this.膣内精液_人.精液濃度 = 0.0;
				this.断面_人.精液配色(Sta.GameData.配色);
				this.断面_人.精液濃度 = 0.0;
				this.性器精液_人.精液配色(Sta.GameData.配色);
				this.肛門精液_人.精液配色(Sta.GameData.配色);
				Vector2D positionCont4 = new Vector2D(0.0, 0.006);
				this.染み_人.X0Y0_湯気_湯気左1_湯気2.PositionCont = positionCont4;
				this.染み_人.X0Y0_湯気_湯気左2_湯気2.PositionCont = positionCont4;
				this.染み_人.X0Y0_湯気_湯気左3_湯気2.PositionCont = positionCont4;
				this.染み_人.X0Y0_湯気_湯気右1_湯気2.PositionCont = positionCont4;
				this.染み_人.X0Y0_湯気_湯気右2_湯気2.PositionCont = positionCont4;
				this.染み_人.X0Y0_湯気_湯気右3_湯気2.PositionCont = positionCont4;
				this.下着陰核.X0Y0_陰核.SizeBase = this.性器_人.X0Y0_陰核.SizeBase;
				this.csb = this.性器_人.X0Y0_陰核.SizeBase;
				this.asb1 = this.肛門_人.X0Y0_肛門2.SizeBase;
				this.asb2 = this.肛門_人.X0Y0_肛門3.SizeBase;
				this.ボテ腹_人.X0Y0_ハイライト.Dra = false;
				this.ボテ腹_人.X0Y0_ハイライト左1.Dra = false;
				this.ボテ腹_人.X0Y0_ハイライト左2.Dra = false;
				this.ボテ腹_人.X0Y0_ハイライト右1.Dra = false;
				this.ボテ腹_人.X0Y0_ハイライト右2.Dra = false;
				this.ボテ腹_人.X0Y1_ハイライト.Dra = false;
				this.ボテ腹_人.X0Y1_ハイライト左1.Dra = false;
				this.ボテ腹_人.X0Y1_ハイライト左2.Dra = false;
				this.ボテ腹_人.X0Y1_ハイライト右1.Dra = false;
				this.ボテ腹_人.X0Y1_ハイライト右2.Dra = false;
			}
			this.肛門y = this.肛門.尺度YB;
			this.肛門v = this.肛門.尺度B;
			this.口i = 0;
			this.口精液.精液配色(Sta.GameData.配色);
			this.頬濃度 = 0.3;
			this.下着B_ノ\u30FCマル.染み濃度 = 0.0;
			this.下着B_マイクロ.染み濃度 = 0.0;
			this.蜘尾 = this.全要素.GetEle<尾_蜘>();
			if (this.Is蜘尾 = (this.蜘尾 != null))
			{
				this.出糸精液 = new 性器精液_人(disUnit, 配色指定.N0, CS$<>8__locals1.Cha.配色, CS$<>8__locals1.Med, new 性器精液_人D());
				this.出糸精液.精液配色(Sta.GameData.配色);
				this.出糸精液.接続(this.蜘尾.出糸_接続点);
			}
			this.頬濃度 = 0.0;
			this.汗染み濃度 = 0.0;
			this.尿染み濃度 = 0.0;
			this.飛沫濃度 = 0.0;
			this.潮染み濃度 = 0.0;
			this.湯気左濃度 = 0.0;
			this.湯気右濃度 = 0.0;
			this.下着B染み = 0.0;
			this.下着T染み = 0.0;
			this.上着B染み = 0.0;
			this.陰核勃起 = 0.0;
			this.乳首勃起 = 0.0;
			this.顔紅潮 = 0.0;
			this.体紅潮 = 0.0;
			this.子宮下がり = 0.0;
			this.肛門開き = 0.0;
			this.肛門C = 1.0;
			this.膣腔C = 1.0;
			this.断面_表示 = false;
			if (this.Is粘 && this.腰.腿左_接続 != null)
			{
				foreach (Par par2 in (from e in this.腰.腿左_接続.GetEles<腿>()
				select e.本体.EnumAllPar()).Aggregate((IEnumerable<Par> e1, IEnumerable<Par> e2) => e1.Concat(e2)))
				{
					par2.OP.OutlineFalse();
				}
				foreach (Par par3 in (from e in this.腰.腿右_接続.GetEles<腿>()
				select e.本体.EnumAllPar()).Aggregate((IEnumerable<Par> e1, IEnumerable<Par> e2) => e1.Concat(e2)))
				{
					par3.OP.OutlineFalse();
				}
			}
			this.全要素.SetEle(delegate(胴_蛇 e)
			{
				e.X0Y0_胴_胴.OP[1].ps[3] = e.X0Y0_胴_胴.OP[1].ps[3].AddY(0.04);
				if (e.胴_接続 != null)
				{
					e.胴_接続.SetEle(delegate(胴_蛇 f)
					{
						f.X0Y0_胴_胴.OP[1].ps[3] = f.X0Y0_胴_胴.OP[1].ps[3].AddY(0.04);
					});
				}
			});
			if (this.Is粘)
			{
				this.腿開きi = 1;
				this.断面_表示 = true;
			}
			this.下着乳首左.X0Y0_乳首.SizeBase = this.乳房左.X0Y0_乳首.SizeBase * 1.1;
			this.下着乳首右.X0Y0_乳首.SizeBase = this.乳房右.X0Y0_乳首.SizeBase * 1.1;
			if (this.胸.肩左_接続 == null)
			{
				this.胸肌_人.淫タトゥ_タトゥ左_表示 = false;
				this.胸肌_人.淫タトゥ_タトゥ右_表示 = false;
			}
			if (this.腰肌_人.竜性_鱗1_表示 || this.腰肌_人.竜性_鱗2_表示 || this.腰肌_人.竜性_鱗3_表示 || this.腰肌_人.竜性_鱗4_表示)
			{
				this.腰肌_人.陰毛_ハ\u30FCト_表示 = false;
			}
			尾_魚 ele13 = this.腰.腿左_接続.GetEle<尾_魚>();
			if (ele13 != null)
			{
				this.腰.腰CD.c2.Col2 = ele13.尾0_尾CD.c2.Col1;
			}
			this.nsb1 = this.乳房左.X0Y0_乳首.SizeBase;
			this.nsb2 = this.乳房左.X0Y0_乳輪.SizeBase;
			this.変動ステ\u30FCト更新();
			this.腰.位置B = CS$<>8__locals1.Med.Base.GetPosition(ref Shas.中央中央);
			this.Join();
			this.Set腰();
			if (this.背中接続.Count + this.頭頂左後接続.Count + this.頭頂右後接続.Count + this.胸上左接続.Count + this.胸上右接続.Count + this.胸下左接続.Count + this.胸下右接続.Count + this.胴後左接続.Count + this.胴後右接続.Count + this.後腕左s.Length + this.後腕右s.Length > 0)
			{
				this.EI胸 = new EleI(CS$<>8__locals1.Med);
				this.EI胸.AddRange(this.背中接続);
				this.EI胸.AddRange(this.頭頂左後接続);
				this.EI胸.AddRange(this.頭頂右後接続);
				this.EI胸.AddRange(this.胸上左接続);
				this.EI胸.AddRange(this.胸上右接続);
				this.EI胸.AddRange(this.胸下左接続);
				this.EI胸.AddRange(this.胸下右接続);
				this.EI胸.AddRange(this.胴後左接続);
				this.EI胸.AddRange(this.胴後右接続);
				foreach (List<Ele> es in this.後腕左s)
				{
					this.EI胸.AddRange(es);
				}
				foreach (List<Ele> es2 in this.後腕右s)
				{
					this.EI胸.AddRange(es2);
				}
				this.EI胸.描画処理 = delegate(Are are)
				{
					CS$<>8__locals1.<>4__this.背中接続.描画0(are);
					CS$<>8__locals1.<>4__this.背中接続.描画1(are);
					CS$<>8__locals1.<>4__this.胸上左接続.描画0(are);
					CS$<>8__locals1.<>4__this.胸上左接続.描画1(are);
					CS$<>8__locals1.<>4__this.胸上右接続.描画0(are);
					CS$<>8__locals1.<>4__this.胸上右接続.描画1(are);
					CS$<>8__locals1.<>4__this.胸下左接続.描画0(are);
					CS$<>8__locals1.<>4__this.胸下左接続.描画1(are);
					CS$<>8__locals1.<>4__this.胸下右接続.描画0(are);
					CS$<>8__locals1.<>4__this.胸下右接続.描画1(are);
					CS$<>8__locals1.<>4__this.胴後左接続.描画0(are);
					CS$<>8__locals1.<>4__this.胴後左接続.描画1(are);
					CS$<>8__locals1.<>4__this.胴後右接続.描画0(are);
					CS$<>8__locals1.<>4__this.胴後右接続.描画1(are);
					CS$<>8__locals1.<>4__this.頭頂左後接続.描画0(are);
					CS$<>8__locals1.<>4__this.頭頂左後接続.描画1(are);
					CS$<>8__locals1.<>4__this.頭頂右後接続.描画0(are);
					CS$<>8__locals1.<>4__this.頭頂右後接続.描画1(are);
					肩[] array5 = CS$<>8__locals1.<>4__this.後脇左s;
					for (int n = 0; n < array5.Length; n++)
					{
						array5[n].脇描画(are);
					}
					array5 = CS$<>8__locals1.<>4__this.後脇右s;
					for (int n = 0; n < array5.Length; n++)
					{
						array5[n].脇描画(are);
					}
					foreach (List<Ele> es3 in CS$<>8__locals1.<>4__this.後腕左s)
					{
						es3.描画0(are);
						es3.描画1(are);
					}
					foreach (List<Ele> es4 in CS$<>8__locals1.<>4__this.後腕右s)
					{
						es4.描画0(are);
						es4.描画1(are);
					}
				};
				this.EI胸.Update();
				this.eis.Add(this.EI胸);
			}
			if (this.後髪接続.Count > 0)
			{
				this.EI髪 = new EleI(CS$<>8__locals1.Med);
				this.EI髪.AddRange(this.後髪接続);
				this.EI髪.描画処理 = delegate(Are are)
				{
					CS$<>8__locals1.<>4__this.後髪接続.描画0(are);
					CS$<>8__locals1.<>4__this.後髪接続.描画1(are);
				};
				this.EI髪.Update();
				this.eis.Add(this.EI髪);
			}
			if (this.腰後左接続.Count + this.腰後右接続.Count > 0)
			{
				this.EI腰 = new EleI(CS$<>8__locals1.Med);
				this.EI腰.AddRange(this.腰後左接続);
				this.EI腰.AddRange(this.腰後右接続);
				this.EI腰.描画処理 = delegate(Are are)
				{
					CS$<>8__locals1.<>4__this.腰後左接続.描画0(are);
					CS$<>8__locals1.<>4__this.腰後左接続.描画1(are);
					CS$<>8__locals1.<>4__this.腰後右接続.描画0(are);
					CS$<>8__locals1.<>4__this.腰後右接続.描画1(are);
				};
				this.EI腰.Update();
				this.eis.Add(this.EI腰);
			}
			if (this.尾接続.Count + this.半身後接続.Count > 0)
			{
				this.EI半後 = new EleI(CS$<>8__locals1.Med);
				this.EI半後.AddRange(this.尾接続);
				this.EI半後.AddRange(this.半身後接続);
				this.EI半後.描画処理 = delegate(Are are)
				{
					CS$<>8__locals1.<>4__this.尾接続.描画0(are);
					CS$<>8__locals1.<>4__this.尾接続.描画1(are);
					CS$<>8__locals1.<>4__this.半身後接続.描画0(are);
					CS$<>8__locals1.<>4__this.半身後接続.描画1(are);
				};
				this.EI半後.Update();
				this.eis.Add(this.EI半後);
			}
			if (this.半身中1接続.Count > 0)
			{
				this.EI半中1 = new EleI(CS$<>8__locals1.Med);
				this.EI半中1.AddRange(this.半身中1接続);
				this.EI半中1.描画処理 = delegate(Are are)
				{
					CS$<>8__locals1.<>4__this.半身中1接続.描画0(are);
					CS$<>8__locals1.<>4__this.半身中1接続.描画1(are);
				};
				this.EI半中1.Update();
				this.eis.Add(this.EI半中1);
			}
			if (this.半身中2接続.Count > 0)
			{
				this.EI半中2 = new EleI(CS$<>8__locals1.Med);
				this.EI半中2.AddRange(this.半身中2接続);
				this.EI半中2.描画処理 = delegate(Are are)
				{
					CS$<>8__locals1.<>4__this.半身中2接続.描画0(are);
					CS$<>8__locals1.<>4__this.半身中2接続.描画1(are);
				};
				this.EI半中2.Update();
				this.eis.Add(this.EI半中2);
			}
			if (this.半身前接続.Count > 0)
			{
				this.EI半前 = new EleI(CS$<>8__locals1.Med);
				this.EI半前.AddRange(this.半身前接続);
				this.EI半前.描画処理 = delegate(Are are)
				{
					CS$<>8__locals1.<>4__this.半身前接続.描画0(are);
					CS$<>8__locals1.<>4__this.半身前接続.描画1(are);
				};
				this.EI半前.Update();
				this.eis.Add(this.EI半前);
			}
			if (this.下腕以降左.Count + this.下腕以降右.Count > 0)
			{
				this.EI腕前 = new EleI(CS$<>8__locals1.Med);
				this.EI腕前.AddRange(this.下腕以降左);
				this.EI腕前.AddRange(this.下腕以降右);
				this.EI腕前.描画処理 = delegate(Are are)
				{
					if (CS$<>8__locals1.<>4__this.腕左右前後)
					{
						if (!CS$<>8__locals1.<>4__this.腕右前後_)
						{
							CS$<>8__locals1.<>4__this.下腕以降右.描画0(are);
							CS$<>8__locals1.<>4__this.下腕以降右.描画1(are);
						}
						if (!CS$<>8__locals1.<>4__this.腕左前後_)
						{
							CS$<>8__locals1.<>4__this.下腕以降左.描画0(are);
							CS$<>8__locals1.<>4__this.下腕以降左.描画1(are);
							return;
						}
					}
					else
					{
						if (!CS$<>8__locals1.<>4__this.腕左前後_)
						{
							CS$<>8__locals1.<>4__this.下腕以降左.描画0(are);
							CS$<>8__locals1.<>4__this.下腕以降左.描画1(are);
						}
						if (!CS$<>8__locals1.<>4__this.腕右前後_)
						{
							CS$<>8__locals1.<>4__this.下腕以降右.描画0(are);
							CS$<>8__locals1.<>4__this.下腕以降右.描画1(are);
						}
					}
				};
				this.EI腕前.Update();
				this.eis.Add(this.EI腕前);
			}
			if (this.腿左接続.Count + this.腿右接続.Count > 0)
			{
				this.EI腿 = new EleI(CS$<>8__locals1.Med);
				this.EI腿.AddRange(this.腿左接続);
				this.EI腿.AddRange(this.腿右接続);
				this.EI腿.描画処理 = delegate(Are are)
				{
					if (CS$<>8__locals1.<>4__this.腿左右前後)
					{
						CS$<>8__locals1.<>4__this.腿右接続.描画0(are);
						CS$<>8__locals1.<>4__this.腿右接続.描画1(are);
						CS$<>8__locals1.<>4__this.腿左接続.描画0(are);
						CS$<>8__locals1.<>4__this.腿左接続.描画1(are);
						return;
					}
					CS$<>8__locals1.<>4__this.腿左接続.描画0(are);
					CS$<>8__locals1.<>4__this.腿左接続.描画1(are);
					CS$<>8__locals1.<>4__this.腿右接続.描画0(are);
					CS$<>8__locals1.<>4__this.腿右接続.描画1(are);
				};
				this.EI腿.Update();
				this.eis.Add(this.EI腿);
			}
			this.Is髪 = (this.EI髪 != null);
			this.Is胸 = (this.EI胸 != null);
			this.Is腰 = (this.EI腰 != null);
			this.Is腕前 = (this.EI腕前 != null);
			this.Is半後 = (this.EI半後 != null);
			this.Is半中1 = (this.EI半中1 != null);
			this.Is半中2 = (this.EI半中2 != null);
			this.Is半前 = (this.EI半前 != null);
			this.Is腿 = (this.EI腿 != null);
			this.Update();
			if (this.Is海洋)
			{
				this.Draw = delegate(Are are)
				{
					CS$<>8__locals1.<>4__this.染み_人.色更新();
					CS$<>8__locals1.<>4__this.染み_人.描画0(are);
					if (CS$<>8__locals1.<>4__this.Is胸)
					{
						CS$<>8__locals1.<>4__this.EI胸.描画(are);
					}
					if (CS$<>8__locals1.<>4__this.Is腰)
					{
						CS$<>8__locals1.<>4__this.EI腰.描画(are);
					}
					if (CS$<>8__locals1.<>4__this.Is頭頂_宇)
					{
						CS$<>8__locals1.<>4__this.頭頂後.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is髪)
					{
						CS$<>8__locals1.<>4__this.EI髪.描画(are);
					}
					if (CS$<>8__locals1.<>4__this.Is獣耳)
					{
						foreach (角2 角 in CS$<>8__locals1.<>4__this.角左接続)
						{
							角.根描画(are);
						}
						foreach (角2 角2 in CS$<>8__locals1.<>4__this.角右接続)
						{
							角2.根描画(are);
						}
					}
					CS$<>8__locals1.<>4__this.肩左飛膜.描画0(are);
					CS$<>8__locals1.<>4__this.肩右飛膜.描画0(are);
					if (CS$<>8__locals1.<>4__this.腕左右前後)
					{
						if (CS$<>8__locals1.<>4__this.腕右前後_)
						{
							CS$<>8__locals1.<>4__this.下腕以降右.描画0(are);
							CS$<>8__locals1.<>4__this.下腕以降右.描画1(are);
						}
						if (CS$<>8__locals1.<>4__this.腕左前後_)
						{
							CS$<>8__locals1.<>4__this.下腕以降左.描画0(are);
							CS$<>8__locals1.<>4__this.下腕以降左.描画1(are);
						}
					}
					else
					{
						if (CS$<>8__locals1.<>4__this.腕左前後_)
						{
							CS$<>8__locals1.<>4__this.下腕以降左.描画0(are);
							CS$<>8__locals1.<>4__this.下腕以降左.描画1(are);
						}
						if (CS$<>8__locals1.<>4__this.腕右前後_)
						{
							CS$<>8__locals1.<>4__this.下腕以降右.描画0(are);
							CS$<>8__locals1.<>4__this.下腕以降右.描画1(are);
						}
					}
					CS$<>8__locals1.<>4__this.上着B_クロス後.描画0(are);
					if (CS$<>8__locals1.<>4__this.Is半後)
					{
						CS$<>8__locals1.<>4__this.EI半後.描画(are);
					}
					if (CS$<>8__locals1.<>4__this.Is蜘尾)
					{
						CS$<>8__locals1.<>4__this.出糸精液.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.cb0)
					{
						if (CS$<>8__locals1.<>4__this.カ\u30FCソル.IsSub糸挿入)
						{
							CS$<>8__locals1.<>4__this.カ\u30FCソル.描画糸(CS$<>8__locals1.Are);
						}
						else if (CS$<>8__locals1.<>4__this.カ\u30FCソル.Is糸挿入)
						{
							CS$<>8__locals1.<>4__this.カ\u30FCソル.描画2(CS$<>8__locals1.Are);
						}
					}
					CS$<>8__locals1.<>4__this.耳左接続.描画0(are);
					CS$<>8__locals1.<>4__this.耳右接続.描画0(are);
					if (CS$<>8__locals1.<>4__this.肩左 != null)
					{
						CS$<>8__locals1.<>4__this.肩左.脇描画(are);
					}
					if (CS$<>8__locals1.<>4__this.肩右 != null)
					{
						CS$<>8__locals1.<>4__this.肩右.脇描画(are);
					}
					CS$<>8__locals1.<>4__this.腰.描画0(are);
					CS$<>8__locals1.<>4__this.腰.描画1(are);
					CS$<>8__locals1.<>4__this.胴.描画0(are);
					CS$<>8__locals1.<>4__this.胸.描画0(are);
					CS$<>8__locals1.<>4__this.首.描画0(are);
					if (CS$<>8__locals1.<>4__this.肩左 != null)
					{
						CS$<>8__locals1.<>4__this.肩左.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.肩右 != null)
					{
						CS$<>8__locals1.<>4__this.肩右.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is半中1)
					{
						CS$<>8__locals1.<>4__this.EI半中1.描画(are);
					}
					CS$<>8__locals1.<>4__this.ボテ腹_人.描画0(are);
					CS$<>8__locals1.<>4__this.ボテ腹板_人.描画0(are);
					CS$<>8__locals1.<>4__this.腰肌_人.描画0(are);
					CS$<>8__locals1.<>4__this.胴腹板_人.描画0(are);
					CS$<>8__locals1.<>4__this.胸腹板_人.描画0(are);
					CS$<>8__locals1.<>4__this.胴肌_人.描画0(are);
					CS$<>8__locals1.<>4__this.胸肌_人.描画0(are);
					CS$<>8__locals1.<>4__this.下着T_チュ\u30FCブ.描画0(are);
					CS$<>8__locals1.<>4__this.下着T_クロス.描画0(are);
					CS$<>8__locals1.<>4__this.下着T_ビキニ.描画0(are);
					CS$<>8__locals1.<>4__this.下着T_マイクロ.描画0(are);
					CS$<>8__locals1.<>4__this.下着T_ブラ.描画0(are);
					CS$<>8__locals1.<>4__this.腕左.描画0(are);
					CS$<>8__locals1.<>4__this.腕右.描画0(are);
					CS$<>8__locals1.<>4__this.腕左.描画1(are);
					CS$<>8__locals1.<>4__this.腕右.描画1(are);
					if (CS$<>8__locals1.<>4__this.胸左右前後)
					{
						CS$<>8__locals1.<>4__this.乳房右.描画0(are);
						CS$<>8__locals1.<>4__this.乳房左.描画0(are);
					}
					else
					{
						CS$<>8__locals1.<>4__this.乳房左.描画0(are);
						CS$<>8__locals1.<>4__this.乳房右.描画0(are);
					}
					CS$<>8__locals1.<>4__this.ピアス左.描画0(are);
					CS$<>8__locals1.<>4__this.ピアス右.描画0(are);
					CS$<>8__locals1.<>4__this.噴乳左.描画0(are);
					CS$<>8__locals1.<>4__this.噴乳右.描画0(are);
					CS$<>8__locals1.<>4__this.キャップ2左.描画0(are);
					CS$<>8__locals1.<>4__this.キャップ2右.描画0(are);
					CS$<>8__locals1.<>4__this.胸肌_人.描画1(are);
					if (CS$<>8__locals1.<>4__this.汗掻き != null)
					{
						CS$<>8__locals1.<>4__this.汗掻き.Draw(are);
					}
					CS$<>8__locals1.<>4__this.頭.描画0(are);
					if (CS$<>8__locals1.<>4__this.Is双眼 && !CS$<>8__locals1.<>4__this.Is瞼宇)
					{
						CS$<>8__locals1.<>4__this.目左.描画0(are);
						CS$<>8__locals1.<>4__this.瞼左.描画0(are);
						CS$<>8__locals1.<>4__this.目右.描画0(are);
						CS$<>8__locals1.<>4__this.瞼右.描画0(are);
					}
					CS$<>8__locals1.<>4__this.頭.描画1(are);
					if (CS$<>8__locals1.<>4__this.Is単眼)
					{
						CS$<>8__locals1.<>4__this.単眼目.描画0(are);
						CS$<>8__locals1.<>4__this.単眼瞼.描画0(are);
					}
					CS$<>8__locals1.<>4__this.紅潮.描画0(are);
					CS$<>8__locals1.<>4__this.鼻肌.描画0(are);
					CS$<>8__locals1.<>4__this.目尻影左.描画0(are);
					CS$<>8__locals1.<>4__this.目尻影右.描画0(are);
					CS$<>8__locals1.<>4__this.目傷左.描画0(are);
					CS$<>8__locals1.<>4__this.目傷右.描画0(are);
					CS$<>8__locals1.<>4__this.頬肌左.描画0(are);
					CS$<>8__locals1.<>4__this.頬肌右.描画0(are);
					if (CS$<>8__locals1.<>4__this.Is額眼)
					{
						CS$<>8__locals1.<>4__this.額目.描画0(are);
						CS$<>8__locals1.<>4__this.額瞼.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is頬眼)
					{
						CS$<>8__locals1.<>4__this.頬目左.描画0(are);
						CS$<>8__locals1.<>4__this.頬目右.描画0(are);
						CS$<>8__locals1.<>4__this.頬瞼左.描画0(are);
						CS$<>8__locals1.<>4__this.頬瞼右.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is瞼宇)
					{
						CS$<>8__locals1.<>4__this.瞼左.描画0(are);
						CS$<>8__locals1.<>4__this.瞼右.描画0(are);
					}
					CS$<>8__locals1.<>4__this.涎左.描画0(are);
					CS$<>8__locals1.<>4__this.涎右.描画0(are);
					CS$<>8__locals1.<>4__this.口.描画0(are);
					if (CS$<>8__locals1.<>4__this.鼻描画)
					{
						CS$<>8__locals1.<>4__this.鼻.描画0(are);
						CS$<>8__locals1.<>4__this.鼻水左.描画0(are);
						CS$<>8__locals1.<>4__this.鼻水右.描画0(are);
					}
					CS$<>8__locals1.<>4__this.頭.描画2(are);
					CS$<>8__locals1.<>4__this.玉口枷.描画0(are);
					CS$<>8__locals1.<>4__this.基髪.描画0(are);
					CS$<>8__locals1.<>4__this.横髪左.描画0(are);
					CS$<>8__locals1.<>4__this.横髪右.描画0(are);
					CS$<>8__locals1.<>4__this.頬左接続.描画0(are);
					CS$<>8__locals1.<>4__this.頬左接続.描画1(are);
					CS$<>8__locals1.<>4__this.頬右接続.描画0(are);
					CS$<>8__locals1.<>4__this.頬右接続.描画1(are);
					CS$<>8__locals1.<>4__this.頬肌左.描画1(are);
					CS$<>8__locals1.<>4__this.頬肌右.描画1(are);
					if (CS$<>8__locals1.<>4__this.涙描画)
					{
						CS$<>8__locals1.<>4__this.涙左.描画0(are);
						CS$<>8__locals1.<>4__this.涙右.描画0(are);
					}
					if (!CS$<>8__locals1.<>4__this.Is頭頂_宇 && !CS$<>8__locals1.<>4__this.Is顔面 && !CS$<>8__locals1.<>4__this.Is額角 && !CS$<>8__locals1.<>4__this.Is触覚)
					{
						CS$<>8__locals1.<>4__this.目隠帯.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is腕前 && !CS$<>8__locals1.<>4__this.Is最前腕人 && (!CS$<>8__locals1.<>4__this.腕左前後_ || !CS$<>8__locals1.<>4__this.腕右前後_))
					{
						CS$<>8__locals1.<>4__this.EI腕前.描画(are);
					}
					if (CS$<>8__locals1.<>4__this.Is半中2)
					{
						CS$<>8__locals1.<>4__this.EI半中2.描画(are);
					}
					CS$<>8__locals1.<>4__this.肛門_人.描画0(are);
					CS$<>8__locals1.<>4__this.肛門精液_人.描画0(are);
					if (CS$<>8__locals1.<>4__this.cb1)
					{
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画肛(are);
					}
					CS$<>8__locals1.<>4__this.膣基_人.描画0(are);
					if (CS$<>8__locals1.<>4__this.断面_表示 && CS$<>8__locals1.<>4__this.cb1)
					{
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画0(are);
					}
					CS$<>8__locals1.<>4__this.膣内精液_人.描画0(are);
					CS$<>8__locals1.<>4__this.断面_人.描画0(are);
					CS$<>8__locals1.<>4__this.性器_人.描画0(are);
					if (!CS$<>8__locals1.<>4__this.断面_表示 && CS$<>8__locals1.<>4__this.cb1)
					{
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画0(are);
					}
					CS$<>8__locals1.<>4__this.ピアス.描画0(are);
					CS$<>8__locals1.<>4__this.下着T_チュ\u30FCブ.描画1(are);
					CS$<>8__locals1.<>4__this.下着T_クロス.描画1(are);
					CS$<>8__locals1.<>4__this.下着T_ビキニ.描画1(are);
					CS$<>8__locals1.<>4__this.下着T_マイクロ.描画1(are);
					CS$<>8__locals1.<>4__this.下着T_ブラ.描画1(are);
					CS$<>8__locals1.<>4__this.下着乳首左.描画0(are);
					CS$<>8__locals1.<>4__this.下着乳首右.描画0(are);
					CS$<>8__locals1.<>4__this.キャップ1.描画0(are);
					CS$<>8__locals1.<>4__this.上着M_ドレス.描画0(are);
					CS$<>8__locals1.<>4__this.上着T_ドレス.描画0(are);
					CS$<>8__locals1.<>4__this.上着B_前掛け.描画0(are);
					CS$<>8__locals1.<>4__this.上着B_クロス.描画0(are);
					if (CS$<>8__locals1.<>4__this.胸毛_人 != null)
					{
						CS$<>8__locals1.<>4__this.胸毛_人.描画0(are);
					}
					CS$<>8__locals1.<>4__this.舌.描画0(are);
					CS$<>8__locals1.<>4__this.口精液.描画0(are);
					CS$<>8__locals1.<>4__this.咳.描画0(are);
					CS$<>8__locals1.<>4__this.呼気.描画0(are);
					if (CS$<>8__locals1.<>4__this.cb0 && CS$<>8__locals1.<>4__this.カ\u30FCソル.コキ)
					{
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画0(are);
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画1(are);
					}
					CS$<>8__locals1.<>4__this.前髪.描画0(are);
					if (!CS$<>8__locals1.<>4__this.Is獣耳)
					{
						foreach (角2 角3 in CS$<>8__locals1.<>4__this.角左接続)
						{
							角3.根描画(are);
						}
						foreach (角2 角4 in CS$<>8__locals1.<>4__this.角右接続)
						{
							角4.根描画(are);
						}
					}
					if (CS$<>8__locals1.<>4__this.Is単眉)
					{
						CS$<>8__locals1.<>4__this.単眼眉.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is双眉)
					{
						CS$<>8__locals1.<>4__this.眉左.描画0(are);
						CS$<>8__locals1.<>4__this.眉右.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is頭頂_宇)
					{
						CS$<>8__locals1.<>4__this.大顎基接続.描画0(are);
						CS$<>8__locals1.<>4__this.大顎基接続.描画1(are);
						if (CS$<>8__locals1.<>4__this.Is顔面)
						{
							CS$<>8__locals1.<>4__this.顔面.描画0(are);
						}
						if (CS$<>8__locals1.<>4__this.Is頭頂)
						{
							CS$<>8__locals1.<>4__this.頭頂.描画0(are);
						}
						if (CS$<>8__locals1.<>4__this.Is獣耳)
						{
							CS$<>8__locals1.<>4__this.獣耳左.描画0(are);
							CS$<>8__locals1.<>4__this.獣耳右.描画0(are);
						}
						CS$<>8__locals1.<>4__this.植左接続.描画0(are);
						CS$<>8__locals1.<>4__this.植右接続.描画0(are);
						foreach (角2 角5 in CS$<>8__locals1.<>4__this.角左接続)
						{
							角5.先描画(are);
						}
						foreach (角2 角6 in CS$<>8__locals1.<>4__this.角右接続)
						{
							角6.先描画(are);
						}
						CS$<>8__locals1.<>4__this.額接続.描画0(are);
						CS$<>8__locals1.<>4__this.額接続.描画1(are);
						CS$<>8__locals1.<>4__this.触覚左接続.描画0(are);
						CS$<>8__locals1.<>4__this.触覚左接続.描画1(are);
						CS$<>8__locals1.<>4__this.触覚右接続.描画0(are);
						CS$<>8__locals1.<>4__this.触覚右接続.描画1(are);
					}
					else
					{
						if (CS$<>8__locals1.<>4__this.Is獣耳)
						{
							CS$<>8__locals1.<>4__this.獣耳左.描画0(are);
							CS$<>8__locals1.<>4__this.獣耳右.描画0(are);
						}
						if (CS$<>8__locals1.<>4__this.Is頭頂)
						{
							CS$<>8__locals1.<>4__this.頭頂.描画0(are);
						}
						CS$<>8__locals1.<>4__this.植左接続.描画0(are);
						CS$<>8__locals1.<>4__this.植右接続.描画0(are);
						foreach (角2 角7 in CS$<>8__locals1.<>4__this.角左接続)
						{
							角7.先描画(are);
						}
						foreach (角2 角8 in CS$<>8__locals1.<>4__this.角右接続)
						{
							角8.先描画(are);
						}
						if (CS$<>8__locals1.<>4__this.Is虫角前)
						{
							CS$<>8__locals1.<>4__this.触覚左接続.描画0(are);
							CS$<>8__locals1.<>4__this.触覚左接続.描画1(are);
							CS$<>8__locals1.<>4__this.触覚右接続.描画0(are);
							CS$<>8__locals1.<>4__this.触覚右接続.描画1(are);
							CS$<>8__locals1.<>4__this.大顎基接続.描画0(are);
							CS$<>8__locals1.<>4__this.大顎基接続.描画1(are);
							if (CS$<>8__locals1.<>4__this.Is顔面)
							{
								CS$<>8__locals1.<>4__this.顔面.描画0(are);
							}
							CS$<>8__locals1.<>4__this.額接続.描画0(are);
							CS$<>8__locals1.<>4__this.額接続.描画1(are);
						}
						else
						{
							CS$<>8__locals1.<>4__this.額接続.描画0(are);
							CS$<>8__locals1.<>4__this.額接続.描画1(are);
							CS$<>8__locals1.<>4__this.触覚左接続.描画0(are);
							CS$<>8__locals1.<>4__this.触覚左接続.描画1(are);
							CS$<>8__locals1.<>4__this.触覚右接続.描画0(are);
							CS$<>8__locals1.<>4__this.触覚右接続.描画1(are);
							CS$<>8__locals1.<>4__this.大顎基接続.描画0(are);
							CS$<>8__locals1.<>4__this.大顎基接続.描画1(are);
							if (CS$<>8__locals1.<>4__this.Is顔面)
							{
								CS$<>8__locals1.<>4__this.顔面.描画0(are);
							}
						}
					}
					CS$<>8__locals1.<>4__this.顔触覚左接続.描画0(are);
					CS$<>8__locals1.<>4__this.顔触覚左接続.描画1(are);
					CS$<>8__locals1.<>4__this.顔触覚右接続.描画0(are);
					CS$<>8__locals1.<>4__this.顔触覚右接続.描画1(are);
					if (CS$<>8__locals1.<>4__this.Is頭頂_宇 || CS$<>8__locals1.<>4__this.Is顔面 || CS$<>8__locals1.<>4__this.Is額角 || CS$<>8__locals1.<>4__this.Is触覚)
					{
						CS$<>8__locals1.<>4__this.目隠帯.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.cb0 && !(CS$<>8__locals1.<>4__this.fi = CS$<>8__locals1.<>4__this.カ\u30FCソル.Isフォ\u30FCカス膣肛挿入))
					{
						CS$<>8__locals1.<>4__this.性器精液_人.描画0(are);
						CS$<>8__locals1.<>4__this.飛沫_人.描画0(are);
						CS$<>8__locals1.<>4__this.潮吹_小_人.描画0(are);
						CS$<>8__locals1.<>4__this.潮吹_大_人.描画0(are);
						CS$<>8__locals1.<>4__this.放尿_人.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is腕前 && CS$<>8__locals1.<>4__this.Is最前腕人 && (!CS$<>8__locals1.<>4__this.腕左前後_ || !CS$<>8__locals1.<>4__this.腕右前後_))
					{
						CS$<>8__locals1.<>4__this.EI腕前.描画(are);
					}
					if (CS$<>8__locals1.<>4__this.Is半前)
					{
						CS$<>8__locals1.<>4__this.EI半前.描画(are);
					}
					CS$<>8__locals1.<>4__this.染み_人.湯気描画(are);
					if (CS$<>8__locals1.<>4__this.cb0 && CS$<>8__locals1.<>4__this.カ\u30FCソル.Is乳弄り)
					{
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画2(CS$<>8__locals1.Are);
					}
					CS$<>8__locals1.<>4__this.上着B_前掛け.前(are);
					CS$<>8__locals1.<>4__this.ぶっかけ大.Draw(are);
					CS$<>8__locals1.<>4__this.ぶっかけ小.Draw(are);
					if (CS$<>8__locals1.<>4__this.cb1)
					{
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画1(are);
					}
					if (CS$<>8__locals1.<>4__this.cb0 && CS$<>8__locals1.<>4__this.fi)
					{
						CS$<>8__locals1.<>4__this.性器精液_人.描画0(are);
						CS$<>8__locals1.<>4__this.飛沫_人.描画0(are);
						CS$<>8__locals1.<>4__this.潮吹_小_人.描画0(are);
						CS$<>8__locals1.<>4__this.潮吹_大_人.描画0(are);
						CS$<>8__locals1.<>4__this.放尿_人.描画0(are);
					}
				};
				return;
			}
			if (this.Is長物)
			{
				this.Draw = delegate(Are are)
				{
					if (CS$<>8__locals1.<>4__this.Is蛇)
					{
						CS$<>8__locals1.<>4__this.蛇.X0Y0_胴1_鱗右CP.Update();
						CS$<>8__locals1.<>4__this.蛇.X0Y0_胴1_鱗左CP.Update();
						CS$<>8__locals1.<>4__this.蛇.X0Y0_胴1_鱗1CP.Update();
						CS$<>8__locals1.<>4__this.蛇.X0Y0_胴1_鱗左1CP.Update();
						CS$<>8__locals1.<>4__this.蛇.X0Y0_胴1_鱗右1CP.Update();
					}
					CS$<>8__locals1.<>4__this.染み_人.色更新();
					CS$<>8__locals1.<>4__this.染み_人.描画0(are);
					if (CS$<>8__locals1.<>4__this.Is胸)
					{
						CS$<>8__locals1.<>4__this.EI胸.描画(are);
					}
					if (CS$<>8__locals1.<>4__this.Is腰)
					{
						CS$<>8__locals1.<>4__this.EI腰.描画(are);
					}
					if (CS$<>8__locals1.<>4__this.Is頭頂_宇)
					{
						CS$<>8__locals1.<>4__this.頭頂後.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is髪)
					{
						CS$<>8__locals1.<>4__this.EI髪.描画(are);
					}
					if (CS$<>8__locals1.<>4__this.Is獣耳)
					{
						foreach (角2 角 in CS$<>8__locals1.<>4__this.角左接続)
						{
							角.根描画(are);
						}
						foreach (角2 角2 in CS$<>8__locals1.<>4__this.角右接続)
						{
							角2.根描画(are);
						}
					}
					CS$<>8__locals1.<>4__this.肩左飛膜.描画0(are);
					CS$<>8__locals1.<>4__this.肩右飛膜.描画0(are);
					if (CS$<>8__locals1.<>4__this.腕左右前後)
					{
						if (CS$<>8__locals1.<>4__this.腕右前後_)
						{
							CS$<>8__locals1.<>4__this.下腕以降右.描画0(are);
							CS$<>8__locals1.<>4__this.下腕以降右.描画1(are);
						}
						if (CS$<>8__locals1.<>4__this.腕左前後_)
						{
							CS$<>8__locals1.<>4__this.下腕以降左.描画0(are);
							CS$<>8__locals1.<>4__this.下腕以降左.描画1(are);
						}
					}
					else
					{
						if (CS$<>8__locals1.<>4__this.腕左前後_)
						{
							CS$<>8__locals1.<>4__this.下腕以降左.描画0(are);
							CS$<>8__locals1.<>4__this.下腕以降左.描画1(are);
						}
						if (CS$<>8__locals1.<>4__this.腕右前後_)
						{
							CS$<>8__locals1.<>4__this.下腕以降右.描画0(are);
							CS$<>8__locals1.<>4__this.下腕以降右.描画1(are);
						}
					}
					CS$<>8__locals1.<>4__this.上着B_クロス後.描画0(are);
					if (CS$<>8__locals1.<>4__this.Is半後)
					{
						CS$<>8__locals1.<>4__this.EI半後.描画(are);
					}
					if (CS$<>8__locals1.<>4__this.Is蜘尾)
					{
						CS$<>8__locals1.<>4__this.出糸精液.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.cb0)
					{
						if (CS$<>8__locals1.<>4__this.カ\u30FCソル.IsSub糸挿入)
						{
							CS$<>8__locals1.<>4__this.カ\u30FCソル.描画糸(CS$<>8__locals1.Are);
						}
						else if (CS$<>8__locals1.<>4__this.カ\u30FCソル.Is糸挿入)
						{
							CS$<>8__locals1.<>4__this.カ\u30FCソル.描画2(CS$<>8__locals1.Are);
						}
					}
					CS$<>8__locals1.<>4__this.耳左接続.描画0(are);
					CS$<>8__locals1.<>4__this.耳右接続.描画0(are);
					if (CS$<>8__locals1.<>4__this.肩左 != null)
					{
						CS$<>8__locals1.<>4__this.肩左.脇描画(are);
					}
					if (CS$<>8__locals1.<>4__this.肩右 != null)
					{
						CS$<>8__locals1.<>4__this.肩右.脇描画(are);
					}
					CS$<>8__locals1.<>4__this.腰.描画0(are);
					CS$<>8__locals1.<>4__this.腰.描画1(are);
					CS$<>8__locals1.<>4__this.胴.描画0(are);
					CS$<>8__locals1.<>4__this.胸.描画0(are);
					CS$<>8__locals1.<>4__this.首.描画0(are);
					if (CS$<>8__locals1.<>4__this.肩左 != null)
					{
						CS$<>8__locals1.<>4__this.肩左.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.肩右 != null)
					{
						CS$<>8__locals1.<>4__this.肩右.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is半中1)
					{
						CS$<>8__locals1.<>4__this.EI半中1.描画(are);
					}
					CS$<>8__locals1.<>4__this.ボテ腹_人.描画0(are);
					CS$<>8__locals1.<>4__this.ボテ腹板_人.描画0(are);
					CS$<>8__locals1.<>4__this.腰肌_人.描画0(are);
					CS$<>8__locals1.<>4__this.胴腹板_人.描画0(are);
					CS$<>8__locals1.<>4__this.胸腹板_人.描画0(are);
					CS$<>8__locals1.<>4__this.胴肌_人.描画0(are);
					CS$<>8__locals1.<>4__this.胸肌_人.描画0(are);
					CS$<>8__locals1.<>4__this.下着T_チュ\u30FCブ.描画0(are);
					CS$<>8__locals1.<>4__this.下着T_クロス.描画0(are);
					CS$<>8__locals1.<>4__this.下着T_ビキニ.描画0(are);
					CS$<>8__locals1.<>4__this.下着T_マイクロ.描画0(are);
					CS$<>8__locals1.<>4__this.下着T_ブラ.描画0(are);
					CS$<>8__locals1.<>4__this.腕左.描画0(are);
					CS$<>8__locals1.<>4__this.腕右.描画0(are);
					CS$<>8__locals1.<>4__this.腕左.描画1(are);
					CS$<>8__locals1.<>4__this.腕右.描画1(are);
					if (CS$<>8__locals1.<>4__this.胸左右前後)
					{
						CS$<>8__locals1.<>4__this.乳房右.描画0(are);
						CS$<>8__locals1.<>4__this.乳房左.描画0(are);
					}
					else
					{
						CS$<>8__locals1.<>4__this.乳房左.描画0(are);
						CS$<>8__locals1.<>4__this.乳房右.描画0(are);
					}
					CS$<>8__locals1.<>4__this.ピアス左.描画0(are);
					CS$<>8__locals1.<>4__this.ピアス右.描画0(are);
					CS$<>8__locals1.<>4__this.噴乳左.描画0(are);
					CS$<>8__locals1.<>4__this.噴乳右.描画0(are);
					CS$<>8__locals1.<>4__this.キャップ2左.描画0(are);
					CS$<>8__locals1.<>4__this.キャップ2右.描画0(are);
					CS$<>8__locals1.<>4__this.胸肌_人.描画1(are);
					if (CS$<>8__locals1.<>4__this.汗掻き != null)
					{
						CS$<>8__locals1.<>4__this.汗掻き.Draw(are);
					}
					CS$<>8__locals1.<>4__this.頭.描画0(are);
					if (CS$<>8__locals1.<>4__this.Is双眼 && !CS$<>8__locals1.<>4__this.Is瞼宇)
					{
						CS$<>8__locals1.<>4__this.目左.描画0(are);
						CS$<>8__locals1.<>4__this.瞼左.描画0(are);
						CS$<>8__locals1.<>4__this.目右.描画0(are);
						CS$<>8__locals1.<>4__this.瞼右.描画0(are);
					}
					CS$<>8__locals1.<>4__this.頭.描画1(are);
					if (CS$<>8__locals1.<>4__this.Is単眼)
					{
						CS$<>8__locals1.<>4__this.単眼目.描画0(are);
						CS$<>8__locals1.<>4__this.単眼瞼.描画0(are);
					}
					CS$<>8__locals1.<>4__this.紅潮.描画0(are);
					CS$<>8__locals1.<>4__this.鼻肌.描画0(are);
					CS$<>8__locals1.<>4__this.目尻影左.描画0(are);
					CS$<>8__locals1.<>4__this.目尻影右.描画0(are);
					CS$<>8__locals1.<>4__this.目傷左.描画0(are);
					CS$<>8__locals1.<>4__this.目傷右.描画0(are);
					CS$<>8__locals1.<>4__this.頬肌左.描画0(are);
					CS$<>8__locals1.<>4__this.頬肌右.描画0(are);
					if (CS$<>8__locals1.<>4__this.Is額眼)
					{
						CS$<>8__locals1.<>4__this.額目.描画0(are);
						CS$<>8__locals1.<>4__this.額瞼.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is頬眼)
					{
						CS$<>8__locals1.<>4__this.頬目左.描画0(are);
						CS$<>8__locals1.<>4__this.頬目右.描画0(are);
						CS$<>8__locals1.<>4__this.頬瞼左.描画0(are);
						CS$<>8__locals1.<>4__this.頬瞼右.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is瞼宇)
					{
						CS$<>8__locals1.<>4__this.瞼左.描画0(are);
						CS$<>8__locals1.<>4__this.瞼右.描画0(are);
					}
					CS$<>8__locals1.<>4__this.涎左.描画0(are);
					CS$<>8__locals1.<>4__this.涎右.描画0(are);
					CS$<>8__locals1.<>4__this.口.描画0(are);
					if (CS$<>8__locals1.<>4__this.鼻描画)
					{
						CS$<>8__locals1.<>4__this.鼻.描画0(are);
						CS$<>8__locals1.<>4__this.鼻水左.描画0(are);
						CS$<>8__locals1.<>4__this.鼻水右.描画0(are);
					}
					CS$<>8__locals1.<>4__this.頭.描画2(are);
					CS$<>8__locals1.<>4__this.玉口枷.描画0(are);
					CS$<>8__locals1.<>4__this.基髪.描画0(are);
					CS$<>8__locals1.<>4__this.横髪左.描画0(are);
					CS$<>8__locals1.<>4__this.横髪右.描画0(are);
					CS$<>8__locals1.<>4__this.頬左接続.描画0(are);
					CS$<>8__locals1.<>4__this.頬左接続.描画1(are);
					CS$<>8__locals1.<>4__this.頬右接続.描画0(are);
					CS$<>8__locals1.<>4__this.頬右接続.描画1(are);
					CS$<>8__locals1.<>4__this.頬肌左.描画1(are);
					CS$<>8__locals1.<>4__this.頬肌右.描画1(are);
					if (CS$<>8__locals1.<>4__this.涙描画)
					{
						CS$<>8__locals1.<>4__this.涙左.描画0(are);
						CS$<>8__locals1.<>4__this.涙右.描画0(are);
					}
					if (!CS$<>8__locals1.<>4__this.Is頭頂_宇 && !CS$<>8__locals1.<>4__this.Is顔面 && !CS$<>8__locals1.<>4__this.Is額角 && !CS$<>8__locals1.<>4__this.Is触覚)
					{
						CS$<>8__locals1.<>4__this.目隠帯.描画0(are);
					}
					CS$<>8__locals1.<>4__this.肛門_人.描画0(are);
					CS$<>8__locals1.<>4__this.肛門精液_人.描画0(are);
					if (CS$<>8__locals1.<>4__this.cb1)
					{
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画肛(are);
					}
					CS$<>8__locals1.<>4__this.膣基_人.描画0(are);
					if (CS$<>8__locals1.<>4__this.断面_表示 && CS$<>8__locals1.<>4__this.cb1)
					{
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画0(are);
					}
					CS$<>8__locals1.<>4__this.膣内精液_人.描画0(are);
					CS$<>8__locals1.<>4__this.断面_人.描画0(are);
					CS$<>8__locals1.<>4__this.性器_人.描画0(are);
					if (!CS$<>8__locals1.<>4__this.断面_表示 && CS$<>8__locals1.<>4__this.cb1)
					{
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画0(are);
					}
					CS$<>8__locals1.<>4__this.ピアス.描画0(are);
					if (CS$<>8__locals1.<>4__this.蛇前 != null)
					{
						CS$<>8__locals1.<>4__this.蛇前.描画0(are);
					}
					CS$<>8__locals1.<>4__this.下着T_チュ\u30FCブ.描画1(are);
					CS$<>8__locals1.<>4__this.下着T_クロス.描画1(are);
					CS$<>8__locals1.<>4__this.下着T_ビキニ.描画1(are);
					CS$<>8__locals1.<>4__this.下着T_マイクロ.描画1(are);
					CS$<>8__locals1.<>4__this.下着T_ブラ.描画1(are);
					CS$<>8__locals1.<>4__this.下着乳首左.描画0(are);
					CS$<>8__locals1.<>4__this.下着乳首右.描画0(are);
					if (CS$<>8__locals1.<>4__this.Is腕前 && !CS$<>8__locals1.<>4__this.Is最前腕人 && (!CS$<>8__locals1.<>4__this.腕左前後_ || !CS$<>8__locals1.<>4__this.腕右前後_))
					{
						CS$<>8__locals1.<>4__this.EI腕前.描画(are);
					}
					if (CS$<>8__locals1.<>4__this.Is半中2)
					{
						CS$<>8__locals1.<>4__this.EI半中2.描画(are);
					}
					CS$<>8__locals1.<>4__this.キャップ1.描画0(are);
					CS$<>8__locals1.<>4__this.上着M_ドレス.描画0(are);
					CS$<>8__locals1.<>4__this.上着T_ドレス.描画0(are);
					CS$<>8__locals1.<>4__this.上着B_前掛け.描画0(are);
					CS$<>8__locals1.<>4__this.上着B_クロス.描画0(are);
					if (CS$<>8__locals1.<>4__this.胸毛_人 != null)
					{
						CS$<>8__locals1.<>4__this.胸毛_人.描画0(are);
					}
					CS$<>8__locals1.<>4__this.舌.描画0(are);
					CS$<>8__locals1.<>4__this.口精液.描画0(are);
					CS$<>8__locals1.<>4__this.咳.描画0(are);
					CS$<>8__locals1.<>4__this.呼気.描画0(are);
					if (CS$<>8__locals1.<>4__this.cb0 && CS$<>8__locals1.<>4__this.カ\u30FCソル.コキ)
					{
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画0(are);
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画1(are);
					}
					CS$<>8__locals1.<>4__this.前髪.描画0(are);
					if (!CS$<>8__locals1.<>4__this.Is獣耳)
					{
						foreach (角2 角3 in CS$<>8__locals1.<>4__this.角左接続)
						{
							角3.根描画(are);
						}
						foreach (角2 角4 in CS$<>8__locals1.<>4__this.角右接続)
						{
							角4.根描画(are);
						}
					}
					if (CS$<>8__locals1.<>4__this.Is単眉)
					{
						CS$<>8__locals1.<>4__this.単眼眉.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is双眉)
					{
						CS$<>8__locals1.<>4__this.眉左.描画0(are);
						CS$<>8__locals1.<>4__this.眉右.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is頭頂_宇)
					{
						CS$<>8__locals1.<>4__this.大顎基接続.描画0(are);
						CS$<>8__locals1.<>4__this.大顎基接続.描画1(are);
						if (CS$<>8__locals1.<>4__this.Is顔面)
						{
							CS$<>8__locals1.<>4__this.顔面.描画0(are);
						}
						if (CS$<>8__locals1.<>4__this.Is頭頂)
						{
							CS$<>8__locals1.<>4__this.頭頂.描画0(are);
						}
						if (CS$<>8__locals1.<>4__this.Is獣耳)
						{
							CS$<>8__locals1.<>4__this.獣耳左.描画0(are);
							CS$<>8__locals1.<>4__this.獣耳右.描画0(are);
						}
						CS$<>8__locals1.<>4__this.植左接続.描画0(are);
						CS$<>8__locals1.<>4__this.植右接続.描画0(are);
						foreach (角2 角5 in CS$<>8__locals1.<>4__this.角左接続)
						{
							角5.先描画(are);
						}
						foreach (角2 角6 in CS$<>8__locals1.<>4__this.角右接続)
						{
							角6.先描画(are);
						}
						CS$<>8__locals1.<>4__this.額接続.描画0(are);
						CS$<>8__locals1.<>4__this.額接続.描画1(are);
						CS$<>8__locals1.<>4__this.触覚左接続.描画0(are);
						CS$<>8__locals1.<>4__this.触覚左接続.描画1(are);
						CS$<>8__locals1.<>4__this.触覚右接続.描画0(are);
						CS$<>8__locals1.<>4__this.触覚右接続.描画1(are);
					}
					else
					{
						if (CS$<>8__locals1.<>4__this.Is獣耳)
						{
							CS$<>8__locals1.<>4__this.獣耳左.描画0(are);
							CS$<>8__locals1.<>4__this.獣耳右.描画0(are);
						}
						if (CS$<>8__locals1.<>4__this.Is頭頂)
						{
							CS$<>8__locals1.<>4__this.頭頂.描画0(are);
						}
						CS$<>8__locals1.<>4__this.植左接続.描画0(are);
						CS$<>8__locals1.<>4__this.植右接続.描画0(are);
						foreach (角2 角7 in CS$<>8__locals1.<>4__this.角左接続)
						{
							角7.先描画(are);
						}
						foreach (角2 角8 in CS$<>8__locals1.<>4__this.角右接続)
						{
							角8.先描画(are);
						}
						if (CS$<>8__locals1.<>4__this.Is虫角前)
						{
							CS$<>8__locals1.<>4__this.触覚左接続.描画0(are);
							CS$<>8__locals1.<>4__this.触覚左接続.描画1(are);
							CS$<>8__locals1.<>4__this.触覚右接続.描画0(are);
							CS$<>8__locals1.<>4__this.触覚右接続.描画1(are);
							CS$<>8__locals1.<>4__this.大顎基接続.描画0(are);
							CS$<>8__locals1.<>4__this.大顎基接続.描画1(are);
							if (CS$<>8__locals1.<>4__this.Is顔面)
							{
								CS$<>8__locals1.<>4__this.顔面.描画0(are);
							}
							CS$<>8__locals1.<>4__this.額接続.描画0(are);
							CS$<>8__locals1.<>4__this.額接続.描画1(are);
						}
						else
						{
							CS$<>8__locals1.<>4__this.額接続.描画0(are);
							CS$<>8__locals1.<>4__this.額接続.描画1(are);
							CS$<>8__locals1.<>4__this.触覚左接続.描画0(are);
							CS$<>8__locals1.<>4__this.触覚左接続.描画1(are);
							CS$<>8__locals1.<>4__this.触覚右接続.描画0(are);
							CS$<>8__locals1.<>4__this.触覚右接続.描画1(are);
							CS$<>8__locals1.<>4__this.大顎基接続.描画0(are);
							CS$<>8__locals1.<>4__this.大顎基接続.描画1(are);
							if (CS$<>8__locals1.<>4__this.Is顔面)
							{
								CS$<>8__locals1.<>4__this.顔面.描画0(are);
							}
						}
					}
					CS$<>8__locals1.<>4__this.顔触覚左接続.描画0(are);
					CS$<>8__locals1.<>4__this.顔触覚左接続.描画1(are);
					CS$<>8__locals1.<>4__this.顔触覚右接続.描画0(are);
					CS$<>8__locals1.<>4__this.顔触覚右接続.描画1(are);
					if (CS$<>8__locals1.<>4__this.Is頭頂_宇 || CS$<>8__locals1.<>4__this.Is顔面 || CS$<>8__locals1.<>4__this.Is額角 || CS$<>8__locals1.<>4__this.Is触覚)
					{
						CS$<>8__locals1.<>4__this.目隠帯.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.cb0 && !(CS$<>8__locals1.<>4__this.fi = CS$<>8__locals1.<>4__this.カ\u30FCソル.Isフォ\u30FCカス膣肛挿入))
					{
						CS$<>8__locals1.<>4__this.性器精液_人.描画0(are);
						CS$<>8__locals1.<>4__this.飛沫_人.描画0(are);
						CS$<>8__locals1.<>4__this.潮吹_小_人.描画0(are);
						CS$<>8__locals1.<>4__this.潮吹_大_人.描画0(are);
						CS$<>8__locals1.<>4__this.放尿_人.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is腕前 && CS$<>8__locals1.<>4__this.Is最前腕人 && (!CS$<>8__locals1.<>4__this.腕左前後_ || !CS$<>8__locals1.<>4__this.腕右前後_))
					{
						CS$<>8__locals1.<>4__this.EI腕前.描画(are);
					}
					if (CS$<>8__locals1.<>4__this.Is半前)
					{
						CS$<>8__locals1.<>4__this.EI半前.描画(are);
					}
					CS$<>8__locals1.<>4__this.染み_人.湯気描画(are);
					if (CS$<>8__locals1.<>4__this.cb0 && CS$<>8__locals1.<>4__this.カ\u30FCソル.Is乳弄り)
					{
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画2(CS$<>8__locals1.Are);
					}
					CS$<>8__locals1.<>4__this.上着B_前掛け.前(are);
					CS$<>8__locals1.<>4__this.ぶっかけ大.Draw(are);
					CS$<>8__locals1.<>4__this.ぶっかけ小.Draw(are);
					if (CS$<>8__locals1.<>4__this.cb1)
					{
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画1(are);
					}
					if (CS$<>8__locals1.<>4__this.cb0 && CS$<>8__locals1.<>4__this.fi)
					{
						CS$<>8__locals1.<>4__this.性器精液_人.描画0(are);
						CS$<>8__locals1.<>4__this.飛沫_人.描画0(are);
						CS$<>8__locals1.<>4__this.潮吹_小_人.描画0(are);
						CS$<>8__locals1.<>4__this.潮吹_大_人.描画0(are);
						CS$<>8__locals1.<>4__this.放尿_人.描画0(are);
					}
				};
				return;
			}
			if (this.Is獣)
			{
				this.Draw = delegate(Are are)
				{
					CS$<>8__locals1.<>4__this.染み_人.色更新();
					CS$<>8__locals1.<>4__this.染み_人.描画0(are);
					CS$<>8__locals1.<>4__this.染み_獣.色更新();
					CS$<>8__locals1.<>4__this.染み_獣.描画0(are);
					CS$<>8__locals1.<>4__this.上着B_クロス後.描画0(are);
					if (CS$<>8__locals1.<>4__this.Is半後)
					{
						CS$<>8__locals1.<>4__this.EI半後.描画(are);
					}
					if (CS$<>8__locals1.<>4__this.Is蜘尾)
					{
						CS$<>8__locals1.<>4__this.出糸精液.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.cb0)
					{
						if (CS$<>8__locals1.<>4__this.カ\u30FCソル.IsSub糸挿入)
						{
							CS$<>8__locals1.<>4__this.カ\u30FCソル.描画糸(CS$<>8__locals1.Are);
						}
						else if (CS$<>8__locals1.<>4__this.カ\u30FCソル.Is糸挿入)
						{
							CS$<>8__locals1.<>4__this.カ\u30FCソル.描画2(CS$<>8__locals1.Are);
						}
					}
					if (CS$<>8__locals1.<>4__this.Is胸)
					{
						CS$<>8__locals1.<>4__this.EI胸.描画(are);
					}
					if (CS$<>8__locals1.<>4__this.Is腰)
					{
						CS$<>8__locals1.<>4__this.EI腰.描画(are);
					}
					if (CS$<>8__locals1.<>4__this.Is頭頂_宇)
					{
						CS$<>8__locals1.<>4__this.頭頂後.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is髪)
					{
						CS$<>8__locals1.<>4__this.EI髪.描画(are);
					}
					if (CS$<>8__locals1.<>4__this.Is獣耳)
					{
						foreach (角2 角 in CS$<>8__locals1.<>4__this.角左接続)
						{
							角.根描画(are);
						}
						foreach (角2 角2 in CS$<>8__locals1.<>4__this.角右接続)
						{
							角2.根描画(are);
						}
					}
					CS$<>8__locals1.<>4__this.肩左飛膜.描画0(are);
					CS$<>8__locals1.<>4__this.肩右飛膜.描画0(are);
					if (CS$<>8__locals1.<>4__this.腕左右前後)
					{
						if (CS$<>8__locals1.<>4__this.腕右前後_)
						{
							CS$<>8__locals1.<>4__this.下腕以降右.描画0(are);
							CS$<>8__locals1.<>4__this.下腕以降右.描画1(are);
						}
						if (CS$<>8__locals1.<>4__this.腕左前後_)
						{
							CS$<>8__locals1.<>4__this.下腕以降左.描画0(are);
							CS$<>8__locals1.<>4__this.下腕以降左.描画1(are);
						}
					}
					else
					{
						if (CS$<>8__locals1.<>4__this.腕左前後_)
						{
							CS$<>8__locals1.<>4__this.下腕以降左.描画0(are);
							CS$<>8__locals1.<>4__this.下腕以降左.描画1(are);
						}
						if (CS$<>8__locals1.<>4__this.腕右前後_)
						{
							CS$<>8__locals1.<>4__this.下腕以降右.描画0(are);
							CS$<>8__locals1.<>4__this.下腕以降右.描画1(are);
						}
					}
					CS$<>8__locals1.<>4__this.脇左_獣.描画0(are);
					CS$<>8__locals1.<>4__this.脇右_獣.描画0(are);
					CS$<>8__locals1.<>4__this.耳左接続.描画0(are);
					CS$<>8__locals1.<>4__this.耳右接続.描画0(are);
					if (CS$<>8__locals1.<>4__this.肩左 != null)
					{
						CS$<>8__locals1.<>4__this.肩左.脇描画(are);
					}
					if (CS$<>8__locals1.<>4__this.肩右 != null)
					{
						CS$<>8__locals1.<>4__this.肩右.脇描画(are);
					}
					CS$<>8__locals1.<>4__this.腰.描画0(are);
					CS$<>8__locals1.<>4__this.腰.描画1(are);
					CS$<>8__locals1.<>4__this.胴.描画0(are);
					CS$<>8__locals1.<>4__this.胸.描画0(are);
					CS$<>8__locals1.<>4__this.首.描画0(are);
					if (CS$<>8__locals1.<>4__this.肩左 != null)
					{
						CS$<>8__locals1.<>4__this.肩左.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.肩右 != null)
					{
						CS$<>8__locals1.<>4__this.肩右.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is半中1)
					{
						CS$<>8__locals1.<>4__this.EI半中1.描画(are);
					}
					CS$<>8__locals1.<>4__this.ボテ腹_人.描画0(are);
					CS$<>8__locals1.<>4__this.ボテ腹板_人.描画0(are);
					CS$<>8__locals1.<>4__this.腰肌_人.描画0(are);
					CS$<>8__locals1.<>4__this.胴腹板_人.描画0(are);
					CS$<>8__locals1.<>4__this.胸腹板_人.描画0(are);
					CS$<>8__locals1.<>4__this.胴肌_人.描画0(are);
					CS$<>8__locals1.<>4__this.胸肌_人.描画0(are);
					CS$<>8__locals1.<>4__this.下着T_チュ\u30FCブ.描画0(are);
					CS$<>8__locals1.<>4__this.下着T_クロス.描画0(are);
					CS$<>8__locals1.<>4__this.下着T_ビキニ.描画0(are);
					CS$<>8__locals1.<>4__this.下着T_マイクロ.描画0(are);
					CS$<>8__locals1.<>4__this.下着T_ブラ.描画0(are);
					CS$<>8__locals1.<>4__this.腕左.描画0(are);
					CS$<>8__locals1.<>4__this.腕右.描画0(are);
					CS$<>8__locals1.<>4__this.腕左.描画1(are);
					CS$<>8__locals1.<>4__this.腕右.描画1(are);
					if (CS$<>8__locals1.<>4__this.胸左右前後)
					{
						CS$<>8__locals1.<>4__this.乳房右.描画0(are);
						CS$<>8__locals1.<>4__this.乳房左.描画0(are);
					}
					else
					{
						CS$<>8__locals1.<>4__this.乳房左.描画0(are);
						CS$<>8__locals1.<>4__this.乳房右.描画0(are);
					}
					CS$<>8__locals1.<>4__this.ピアス左.描画0(are);
					CS$<>8__locals1.<>4__this.ピアス右.描画0(are);
					CS$<>8__locals1.<>4__this.噴乳左.描画0(are);
					CS$<>8__locals1.<>4__this.噴乳右.描画0(are);
					CS$<>8__locals1.<>4__this.キャップ2左.描画0(are);
					CS$<>8__locals1.<>4__this.キャップ2右.描画0(are);
					CS$<>8__locals1.<>4__this.胸肌_人.描画1(are);
					if (CS$<>8__locals1.<>4__this.汗掻き != null)
					{
						CS$<>8__locals1.<>4__this.汗掻き.Draw(are);
					}
					CS$<>8__locals1.<>4__this.頭.描画0(are);
					if (CS$<>8__locals1.<>4__this.Is双眼 && !CS$<>8__locals1.<>4__this.Is瞼宇)
					{
						CS$<>8__locals1.<>4__this.目左.描画0(are);
						CS$<>8__locals1.<>4__this.瞼左.描画0(are);
						CS$<>8__locals1.<>4__this.目右.描画0(are);
						CS$<>8__locals1.<>4__this.瞼右.描画0(are);
					}
					CS$<>8__locals1.<>4__this.頭.描画1(are);
					if (CS$<>8__locals1.<>4__this.Is単眼)
					{
						CS$<>8__locals1.<>4__this.単眼目.描画0(are);
						CS$<>8__locals1.<>4__this.単眼瞼.描画0(are);
					}
					CS$<>8__locals1.<>4__this.紅潮.描画0(are);
					CS$<>8__locals1.<>4__this.鼻肌.描画0(are);
					CS$<>8__locals1.<>4__this.目尻影左.描画0(are);
					CS$<>8__locals1.<>4__this.目尻影右.描画0(are);
					CS$<>8__locals1.<>4__this.目傷左.描画0(are);
					CS$<>8__locals1.<>4__this.目傷右.描画0(are);
					CS$<>8__locals1.<>4__this.頬肌左.描画0(are);
					CS$<>8__locals1.<>4__this.頬肌右.描画0(are);
					if (CS$<>8__locals1.<>4__this.Is額眼)
					{
						CS$<>8__locals1.<>4__this.額目.描画0(are);
						CS$<>8__locals1.<>4__this.額瞼.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is頬眼)
					{
						CS$<>8__locals1.<>4__this.頬目左.描画0(are);
						CS$<>8__locals1.<>4__this.頬目右.描画0(are);
						CS$<>8__locals1.<>4__this.頬瞼左.描画0(are);
						CS$<>8__locals1.<>4__this.頬瞼右.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is瞼宇)
					{
						CS$<>8__locals1.<>4__this.瞼左.描画0(are);
						CS$<>8__locals1.<>4__this.瞼右.描画0(are);
					}
					CS$<>8__locals1.<>4__this.涎左.描画0(are);
					CS$<>8__locals1.<>4__this.涎右.描画0(are);
					CS$<>8__locals1.<>4__this.口.描画0(are);
					if (CS$<>8__locals1.<>4__this.鼻描画)
					{
						CS$<>8__locals1.<>4__this.鼻.描画0(are);
						CS$<>8__locals1.<>4__this.鼻水左.描画0(are);
						CS$<>8__locals1.<>4__this.鼻水右.描画0(are);
					}
					CS$<>8__locals1.<>4__this.頭.描画2(are);
					CS$<>8__locals1.<>4__this.玉口枷.描画0(are);
					CS$<>8__locals1.<>4__this.基髪.描画0(are);
					CS$<>8__locals1.<>4__this.横髪左.描画0(are);
					CS$<>8__locals1.<>4__this.横髪右.描画0(are);
					CS$<>8__locals1.<>4__this.頬左接続.描画0(are);
					CS$<>8__locals1.<>4__this.頬左接続.描画1(are);
					CS$<>8__locals1.<>4__this.頬右接続.描画0(are);
					CS$<>8__locals1.<>4__this.頬右接続.描画1(are);
					CS$<>8__locals1.<>4__this.頬肌左.描画1(are);
					CS$<>8__locals1.<>4__this.頬肌右.描画1(are);
					if (CS$<>8__locals1.<>4__this.涙描画)
					{
						CS$<>8__locals1.<>4__this.涙左.描画0(are);
						CS$<>8__locals1.<>4__this.涙右.描画0(are);
					}
					if (!CS$<>8__locals1.<>4__this.Is頭頂_宇 && !CS$<>8__locals1.<>4__this.Is顔面 && !CS$<>8__locals1.<>4__this.Is額角 && !CS$<>8__locals1.<>4__this.Is触覚)
					{
						CS$<>8__locals1.<>4__this.目隠帯.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is腕前 && !CS$<>8__locals1.<>4__this.Is最前腕人 && (!CS$<>8__locals1.<>4__this.腕左前後_ || !CS$<>8__locals1.<>4__this.腕右前後_))
					{
						CS$<>8__locals1.<>4__this.EI腕前.描画(are);
					}
					CS$<>8__locals1.<>4__this.肛門_獣.描画0(are);
					CS$<>8__locals1.<>4__this.肛門精液_獣.描画0(are);
					if (CS$<>8__locals1.<>4__this.cb1)
					{
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画肛(are);
					}
					CS$<>8__locals1.<>4__this.膣基_獣.描画0(are);
					if (CS$<>8__locals1.<>4__this.断面_表示 && CS$<>8__locals1.<>4__this.cb1)
					{
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画0(are);
					}
					CS$<>8__locals1.<>4__this.膣内精液_獣.描画0(are);
					CS$<>8__locals1.<>4__this.断面_獣.描画0(are);
					CS$<>8__locals1.<>4__this.性器_獣.描画0(are);
					if (!CS$<>8__locals1.<>4__this.断面_表示 && CS$<>8__locals1.<>4__this.cb1)
					{
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画0(are);
					}
					CS$<>8__locals1.<>4__this.ピアス.描画0(are);
					CS$<>8__locals1.<>4__this.下着T_チュ\u30FCブ.描画1(are);
					CS$<>8__locals1.<>4__this.下着T_クロス.描画1(are);
					CS$<>8__locals1.<>4__this.下着T_ビキニ.描画1(are);
					CS$<>8__locals1.<>4__this.下着T_マイクロ.描画1(are);
					CS$<>8__locals1.<>4__this.下着T_ブラ.描画1(are);
					CS$<>8__locals1.<>4__this.下着乳首左.描画0(are);
					CS$<>8__locals1.<>4__this.下着乳首右.描画0(are);
					CS$<>8__locals1.<>4__this.キャップ1.描画0(are);
					CS$<>8__locals1.<>4__this.上着M_ドレス.描画0(are);
					CS$<>8__locals1.<>4__this.上着T_ドレス.描画0(are);
					CS$<>8__locals1.<>4__this.上着B_前掛け.描画0(are);
					if (CS$<>8__locals1.<>4__this.捲り判定0)
					{
						CS$<>8__locals1.<>4__this.上着B_クロス.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is半中2)
					{
						CS$<>8__locals1.<>4__this.EI半中2.描画(are);
					}
					if (!CS$<>8__locals1.<>4__this.捲り判定0)
					{
						CS$<>8__locals1.<>4__this.上着B_クロス.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.胸毛_人 != null)
					{
						CS$<>8__locals1.<>4__this.胸毛_人.描画0(are);
					}
					CS$<>8__locals1.<>4__this.舌.描画0(are);
					CS$<>8__locals1.<>4__this.口精液.描画0(are);
					CS$<>8__locals1.<>4__this.咳.描画0(are);
					CS$<>8__locals1.<>4__this.呼気.描画0(are);
					if (CS$<>8__locals1.<>4__this.cb0 && CS$<>8__locals1.<>4__this.カ\u30FCソル.コキ)
					{
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画0(are);
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画1(are);
					}
					CS$<>8__locals1.<>4__this.前髪.描画0(are);
					if (!CS$<>8__locals1.<>4__this.Is獣耳)
					{
						foreach (角2 角3 in CS$<>8__locals1.<>4__this.角左接続)
						{
							角3.根描画(are);
						}
						foreach (角2 角4 in CS$<>8__locals1.<>4__this.角右接続)
						{
							角4.根描画(are);
						}
					}
					if (CS$<>8__locals1.<>4__this.Is単眉)
					{
						CS$<>8__locals1.<>4__this.単眼眉.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is双眉)
					{
						CS$<>8__locals1.<>4__this.眉左.描画0(are);
						CS$<>8__locals1.<>4__this.眉右.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is頭頂_宇)
					{
						CS$<>8__locals1.<>4__this.大顎基接続.描画0(are);
						CS$<>8__locals1.<>4__this.大顎基接続.描画1(are);
						if (CS$<>8__locals1.<>4__this.Is顔面)
						{
							CS$<>8__locals1.<>4__this.顔面.描画0(are);
						}
						if (CS$<>8__locals1.<>4__this.Is頭頂)
						{
							CS$<>8__locals1.<>4__this.頭頂.描画0(are);
						}
						if (CS$<>8__locals1.<>4__this.Is獣耳)
						{
							CS$<>8__locals1.<>4__this.獣耳左.描画0(are);
							CS$<>8__locals1.<>4__this.獣耳右.描画0(are);
						}
						CS$<>8__locals1.<>4__this.植左接続.描画0(are);
						CS$<>8__locals1.<>4__this.植右接続.描画0(are);
						foreach (角2 角5 in CS$<>8__locals1.<>4__this.角左接続)
						{
							角5.先描画(are);
						}
						foreach (角2 角6 in CS$<>8__locals1.<>4__this.角右接続)
						{
							角6.先描画(are);
						}
						CS$<>8__locals1.<>4__this.額接続.描画0(are);
						CS$<>8__locals1.<>4__this.額接続.描画1(are);
						CS$<>8__locals1.<>4__this.触覚左接続.描画0(are);
						CS$<>8__locals1.<>4__this.触覚左接続.描画1(are);
						CS$<>8__locals1.<>4__this.触覚右接続.描画0(are);
						CS$<>8__locals1.<>4__this.触覚右接続.描画1(are);
					}
					else
					{
						if (CS$<>8__locals1.<>4__this.Is獣耳)
						{
							CS$<>8__locals1.<>4__this.獣耳左.描画0(are);
							CS$<>8__locals1.<>4__this.獣耳右.描画0(are);
						}
						if (CS$<>8__locals1.<>4__this.Is頭頂)
						{
							CS$<>8__locals1.<>4__this.頭頂.描画0(are);
						}
						CS$<>8__locals1.<>4__this.植左接続.描画0(are);
						CS$<>8__locals1.<>4__this.植右接続.描画0(are);
						foreach (角2 角7 in CS$<>8__locals1.<>4__this.角左接続)
						{
							角7.先描画(are);
						}
						foreach (角2 角8 in CS$<>8__locals1.<>4__this.角右接続)
						{
							角8.先描画(are);
						}
						if (CS$<>8__locals1.<>4__this.Is虫角前)
						{
							CS$<>8__locals1.<>4__this.触覚左接続.描画0(are);
							CS$<>8__locals1.<>4__this.触覚左接続.描画1(are);
							CS$<>8__locals1.<>4__this.触覚右接続.描画0(are);
							CS$<>8__locals1.<>4__this.触覚右接続.描画1(are);
							CS$<>8__locals1.<>4__this.大顎基接続.描画0(are);
							CS$<>8__locals1.<>4__this.大顎基接続.描画1(are);
							if (CS$<>8__locals1.<>4__this.Is顔面)
							{
								CS$<>8__locals1.<>4__this.顔面.描画0(are);
							}
							CS$<>8__locals1.<>4__this.額接続.描画0(are);
							CS$<>8__locals1.<>4__this.額接続.描画1(are);
						}
						else
						{
							CS$<>8__locals1.<>4__this.額接続.描画0(are);
							CS$<>8__locals1.<>4__this.額接続.描画1(are);
							CS$<>8__locals1.<>4__this.触覚左接続.描画0(are);
							CS$<>8__locals1.<>4__this.触覚左接続.描画1(are);
							CS$<>8__locals1.<>4__this.触覚右接続.描画0(are);
							CS$<>8__locals1.<>4__this.触覚右接続.描画1(are);
							CS$<>8__locals1.<>4__this.大顎基接続.描画0(are);
							CS$<>8__locals1.<>4__this.大顎基接続.描画1(are);
							if (CS$<>8__locals1.<>4__this.Is顔面)
							{
								CS$<>8__locals1.<>4__this.顔面.描画0(are);
							}
						}
					}
					CS$<>8__locals1.<>4__this.顔触覚左接続.描画0(are);
					CS$<>8__locals1.<>4__this.顔触覚左接続.描画1(are);
					CS$<>8__locals1.<>4__this.顔触覚右接続.描画0(are);
					CS$<>8__locals1.<>4__this.顔触覚右接続.描画1(are);
					if (CS$<>8__locals1.<>4__this.Is頭頂_宇 || CS$<>8__locals1.<>4__this.Is顔面 || CS$<>8__locals1.<>4__this.Is額角 || CS$<>8__locals1.<>4__this.Is触覚)
					{
						CS$<>8__locals1.<>4__this.目隠帯.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.cb0 && !(CS$<>8__locals1.<>4__this.fi = CS$<>8__locals1.<>4__this.カ\u30FCソル.Isフォ\u30FCカス膣肛挿入))
					{
						CS$<>8__locals1.<>4__this.性器精液_獣.描画0(are);
						CS$<>8__locals1.<>4__this.飛沫_獣.描画0(are);
						CS$<>8__locals1.<>4__this.潮吹_小_獣.描画0(are);
						CS$<>8__locals1.<>4__this.潮吹_大_獣.描画0(are);
						CS$<>8__locals1.<>4__this.放尿_獣.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is腕前 && CS$<>8__locals1.<>4__this.Is最前腕人 && (!CS$<>8__locals1.<>4__this.腕左前後_ || !CS$<>8__locals1.<>4__this.腕右前後_))
					{
						CS$<>8__locals1.<>4__this.EI腕前.描画(are);
					}
					if (CS$<>8__locals1.<>4__this.Is半前)
					{
						CS$<>8__locals1.<>4__this.EI半前.描画(are);
					}
					CS$<>8__locals1.<>4__this.染み_獣.湯気描画(are);
					if (CS$<>8__locals1.<>4__this.cb0 && CS$<>8__locals1.<>4__this.カ\u30FCソル.Is乳弄り)
					{
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画2(CS$<>8__locals1.Are);
					}
					CS$<>8__locals1.<>4__this.上着B_前掛け.前(are);
					CS$<>8__locals1.<>4__this.ぶっかけ大.Draw(are);
					CS$<>8__locals1.<>4__this.ぶっかけ小.Draw(are);
					if (CS$<>8__locals1.<>4__this.cb1)
					{
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画1(are);
					}
					if (CS$<>8__locals1.<>4__this.cb0 && CS$<>8__locals1.<>4__this.fi)
					{
						CS$<>8__locals1.<>4__this.性器精液_獣.描画0(are);
						CS$<>8__locals1.<>4__this.飛沫_獣.描画0(are);
						CS$<>8__locals1.<>4__this.潮吹_小_獣.描画0(are);
						CS$<>8__locals1.<>4__this.潮吹_大_獣.描画0(are);
						CS$<>8__locals1.<>4__this.放尿_獣.描画0(are);
					}
				};
				return;
			}
			if (this.Is蛸)
			{
				this.Draw = delegate(Are are)
				{
					CS$<>8__locals1.<>4__this.染み_人.色更新();
					CS$<>8__locals1.<>4__this.染み_人.描画0(are);
					if (CS$<>8__locals1.<>4__this.Is胸)
					{
						CS$<>8__locals1.<>4__this.EI胸.描画(are);
					}
					if (CS$<>8__locals1.<>4__this.Is腰)
					{
						CS$<>8__locals1.<>4__this.EI腰.描画(are);
					}
					if (CS$<>8__locals1.<>4__this.Is頭頂_宇)
					{
						CS$<>8__locals1.<>4__this.頭頂後.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is髪)
					{
						CS$<>8__locals1.<>4__this.EI髪.描画(are);
					}
					if (CS$<>8__locals1.<>4__this.Is獣耳)
					{
						foreach (角2 角 in CS$<>8__locals1.<>4__this.角左接続)
						{
							角.根描画(are);
						}
						foreach (角2 角2 in CS$<>8__locals1.<>4__this.角右接続)
						{
							角2.根描画(are);
						}
					}
					CS$<>8__locals1.<>4__this.肩左飛膜.描画0(are);
					CS$<>8__locals1.<>4__this.肩右飛膜.描画0(are);
					if (CS$<>8__locals1.<>4__this.腕左右前後)
					{
						if (CS$<>8__locals1.<>4__this.腕右前後_)
						{
							CS$<>8__locals1.<>4__this.下腕以降右.描画0(are);
							CS$<>8__locals1.<>4__this.下腕以降右.描画1(are);
						}
						if (CS$<>8__locals1.<>4__this.腕左前後_)
						{
							CS$<>8__locals1.<>4__this.下腕以降左.描画0(are);
							CS$<>8__locals1.<>4__this.下腕以降左.描画1(are);
						}
					}
					else
					{
						if (CS$<>8__locals1.<>4__this.腕左前後_)
						{
							CS$<>8__locals1.<>4__this.下腕以降左.描画0(are);
							CS$<>8__locals1.<>4__this.下腕以降左.描画1(are);
						}
						if (CS$<>8__locals1.<>4__this.腕右前後_)
						{
							CS$<>8__locals1.<>4__this.下腕以降右.描画0(are);
							CS$<>8__locals1.<>4__this.下腕以降右.描画1(are);
						}
					}
					CS$<>8__locals1.<>4__this.上着B_クロス後.描画0(are);
					if (CS$<>8__locals1.<>4__this.Is半後)
					{
						CS$<>8__locals1.<>4__this.EI半後.描画(are);
					}
					if (CS$<>8__locals1.<>4__this.Is蜘尾)
					{
						CS$<>8__locals1.<>4__this.出糸精液.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.cb0)
					{
						if (CS$<>8__locals1.<>4__this.カ\u30FCソル.IsSub糸挿入)
						{
							CS$<>8__locals1.<>4__this.カ\u30FCソル.描画糸(CS$<>8__locals1.Are);
						}
						else if (CS$<>8__locals1.<>4__this.カ\u30FCソル.Is糸挿入)
						{
							CS$<>8__locals1.<>4__this.カ\u30FCソル.描画2(CS$<>8__locals1.Are);
						}
					}
					CS$<>8__locals1.<>4__this.耳左接続.描画0(are);
					CS$<>8__locals1.<>4__this.耳右接続.描画0(are);
					if (CS$<>8__locals1.<>4__this.肩左 != null)
					{
						CS$<>8__locals1.<>4__this.肩左.脇描画(are);
					}
					if (CS$<>8__locals1.<>4__this.肩右 != null)
					{
						CS$<>8__locals1.<>4__this.肩右.脇描画(are);
					}
					CS$<>8__locals1.<>4__this.腰.描画0(are);
					CS$<>8__locals1.<>4__this.腰.描画1(are);
					CS$<>8__locals1.<>4__this.胴.描画0(are);
					CS$<>8__locals1.<>4__this.胸.描画0(are);
					CS$<>8__locals1.<>4__this.首.描画0(are);
					if (CS$<>8__locals1.<>4__this.肩左 != null)
					{
						CS$<>8__locals1.<>4__this.肩左.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.肩右 != null)
					{
						CS$<>8__locals1.<>4__this.肩右.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is半中1)
					{
						CS$<>8__locals1.<>4__this.EI半中1.描画(are);
					}
					CS$<>8__locals1.<>4__this.下着T_チュ\u30FCブ.描画0(are);
					CS$<>8__locals1.<>4__this.下着T_クロス.描画0(are);
					CS$<>8__locals1.<>4__this.下着T_ビキニ.描画0(are);
					CS$<>8__locals1.<>4__this.下着T_マイクロ.描画0(are);
					CS$<>8__locals1.<>4__this.下着T_ブラ.描画0(are);
					CS$<>8__locals1.<>4__this.腕左.描画0(are);
					CS$<>8__locals1.<>4__this.腕右.描画0(are);
					CS$<>8__locals1.<>4__this.腕左.描画1(are);
					CS$<>8__locals1.<>4__this.腕右.描画1(are);
					if (CS$<>8__locals1.<>4__this.Is半中2)
					{
						CS$<>8__locals1.<>4__this.EI半中2.描画(are);
					}
					CS$<>8__locals1.<>4__this.ボテ腹_人.描画0(are);
					CS$<>8__locals1.<>4__this.ボテ腹板_人.描画0(are);
					CS$<>8__locals1.<>4__this.腰肌_人.描画0(are);
					CS$<>8__locals1.<>4__this.胴腹板_人.描画0(are);
					CS$<>8__locals1.<>4__this.胸腹板_人.描画0(are);
					CS$<>8__locals1.<>4__this.胴肌_人.描画0(are);
					CS$<>8__locals1.<>4__this.胸肌_人.描画0(are);
					if (CS$<>8__locals1.<>4__this.胸左右前後)
					{
						CS$<>8__locals1.<>4__this.乳房右.描画0(are);
						CS$<>8__locals1.<>4__this.乳房左.描画0(are);
					}
					else
					{
						CS$<>8__locals1.<>4__this.乳房左.描画0(are);
						CS$<>8__locals1.<>4__this.乳房右.描画0(are);
					}
					CS$<>8__locals1.<>4__this.ピアス左.描画0(are);
					CS$<>8__locals1.<>4__this.ピアス右.描画0(are);
					CS$<>8__locals1.<>4__this.噴乳左.描画0(are);
					CS$<>8__locals1.<>4__this.噴乳右.描画0(are);
					CS$<>8__locals1.<>4__this.キャップ2左.描画0(are);
					CS$<>8__locals1.<>4__this.キャップ2右.描画0(are);
					CS$<>8__locals1.<>4__this.胸肌_人.描画1(are);
					if (CS$<>8__locals1.<>4__this.汗掻き != null)
					{
						CS$<>8__locals1.<>4__this.汗掻き.Draw(are);
					}
					CS$<>8__locals1.<>4__this.頭.描画0(are);
					if (CS$<>8__locals1.<>4__this.Is双眼 && !CS$<>8__locals1.<>4__this.Is瞼宇)
					{
						CS$<>8__locals1.<>4__this.目左.描画0(are);
						CS$<>8__locals1.<>4__this.瞼左.描画0(are);
						CS$<>8__locals1.<>4__this.目右.描画0(are);
						CS$<>8__locals1.<>4__this.瞼右.描画0(are);
					}
					CS$<>8__locals1.<>4__this.頭.描画1(are);
					if (CS$<>8__locals1.<>4__this.Is単眼)
					{
						CS$<>8__locals1.<>4__this.単眼目.描画0(are);
						CS$<>8__locals1.<>4__this.単眼瞼.描画0(are);
					}
					CS$<>8__locals1.<>4__this.紅潮.描画0(are);
					CS$<>8__locals1.<>4__this.鼻肌.描画0(are);
					CS$<>8__locals1.<>4__this.目尻影左.描画0(are);
					CS$<>8__locals1.<>4__this.目尻影右.描画0(are);
					CS$<>8__locals1.<>4__this.目傷左.描画0(are);
					CS$<>8__locals1.<>4__this.目傷右.描画0(are);
					CS$<>8__locals1.<>4__this.頬肌左.描画0(are);
					CS$<>8__locals1.<>4__this.頬肌右.描画0(are);
					if (CS$<>8__locals1.<>4__this.Is額眼)
					{
						CS$<>8__locals1.<>4__this.額目.描画0(are);
						CS$<>8__locals1.<>4__this.額瞼.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is頬眼)
					{
						CS$<>8__locals1.<>4__this.頬目左.描画0(are);
						CS$<>8__locals1.<>4__this.頬目右.描画0(are);
						CS$<>8__locals1.<>4__this.頬瞼左.描画0(are);
						CS$<>8__locals1.<>4__this.頬瞼右.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is瞼宇)
					{
						CS$<>8__locals1.<>4__this.瞼左.描画0(are);
						CS$<>8__locals1.<>4__this.瞼右.描画0(are);
					}
					CS$<>8__locals1.<>4__this.涎左.描画0(are);
					CS$<>8__locals1.<>4__this.涎右.描画0(are);
					CS$<>8__locals1.<>4__this.口.描画0(are);
					if (CS$<>8__locals1.<>4__this.鼻描画)
					{
						CS$<>8__locals1.<>4__this.鼻.描画0(are);
						CS$<>8__locals1.<>4__this.鼻水左.描画0(are);
						CS$<>8__locals1.<>4__this.鼻水右.描画0(are);
					}
					CS$<>8__locals1.<>4__this.頭.描画2(are);
					CS$<>8__locals1.<>4__this.玉口枷.描画0(are);
					CS$<>8__locals1.<>4__this.基髪.描画0(are);
					CS$<>8__locals1.<>4__this.横髪左.描画0(are);
					CS$<>8__locals1.<>4__this.横髪右.描画0(are);
					CS$<>8__locals1.<>4__this.頬左接続.描画0(are);
					CS$<>8__locals1.<>4__this.頬左接続.描画1(are);
					CS$<>8__locals1.<>4__this.頬右接続.描画0(are);
					CS$<>8__locals1.<>4__this.頬右接続.描画1(are);
					CS$<>8__locals1.<>4__this.頬肌左.描画1(are);
					CS$<>8__locals1.<>4__this.頬肌右.描画1(are);
					if (CS$<>8__locals1.<>4__this.涙描画)
					{
						CS$<>8__locals1.<>4__this.涙左.描画0(are);
						CS$<>8__locals1.<>4__this.涙右.描画0(are);
					}
					if (!CS$<>8__locals1.<>4__this.Is頭頂_宇 && !CS$<>8__locals1.<>4__this.Is顔面 && !CS$<>8__locals1.<>4__this.Is額角 && !CS$<>8__locals1.<>4__this.Is触覚)
					{
						CS$<>8__locals1.<>4__this.目隠帯.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is腕前 && !CS$<>8__locals1.<>4__this.Is最前腕人 && (!CS$<>8__locals1.<>4__this.腕左前後_ || !CS$<>8__locals1.<>4__this.腕右前後_))
					{
						CS$<>8__locals1.<>4__this.EI腕前.描画(are);
					}
					CS$<>8__locals1.<>4__this.肛門_人.描画0(are);
					CS$<>8__locals1.<>4__this.肛門精液_人.描画0(are);
					if (CS$<>8__locals1.<>4__this.cb1)
					{
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画肛(are);
					}
					CS$<>8__locals1.<>4__this.膣基_人.描画0(are);
					if (CS$<>8__locals1.<>4__this.断面_表示 && CS$<>8__locals1.<>4__this.cb1)
					{
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画0(are);
					}
					CS$<>8__locals1.<>4__this.膣内精液_人.描画0(are);
					CS$<>8__locals1.<>4__this.断面_人.描画0(are);
					CS$<>8__locals1.<>4__this.性器_人.描画0(are);
					if (!CS$<>8__locals1.<>4__this.断面_表示 && CS$<>8__locals1.<>4__this.cb1)
					{
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画0(are);
					}
					CS$<>8__locals1.<>4__this.ピアス.描画0(are);
					CS$<>8__locals1.<>4__this.下着T_チュ\u30FCブ.描画1(are);
					CS$<>8__locals1.<>4__this.下着T_クロス.描画1(are);
					CS$<>8__locals1.<>4__this.下着T_ビキニ.描画1(are);
					CS$<>8__locals1.<>4__this.下着T_マイクロ.描画1(are);
					CS$<>8__locals1.<>4__this.下着T_ブラ.描画1(are);
					CS$<>8__locals1.<>4__this.下着乳首左.描画0(are);
					CS$<>8__locals1.<>4__this.下着乳首右.描画0(are);
					CS$<>8__locals1.<>4__this.キャップ1.描画0(are);
					CS$<>8__locals1.<>4__this.上着M_ドレス.描画0(are);
					CS$<>8__locals1.<>4__this.上着T_ドレス.描画0(are);
					CS$<>8__locals1.<>4__this.上着B_前掛け.描画0(are);
					CS$<>8__locals1.<>4__this.上着B_クロス.描画0(are);
					if (CS$<>8__locals1.<>4__this.胸毛_人 != null)
					{
						CS$<>8__locals1.<>4__this.胸毛_人.描画0(are);
					}
					CS$<>8__locals1.<>4__this.舌.描画0(are);
					CS$<>8__locals1.<>4__this.口精液.描画0(are);
					CS$<>8__locals1.<>4__this.咳.描画0(are);
					CS$<>8__locals1.<>4__this.呼気.描画0(are);
					if (CS$<>8__locals1.<>4__this.cb0 && CS$<>8__locals1.<>4__this.カ\u30FCソル.コキ)
					{
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画0(are);
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画1(are);
					}
					CS$<>8__locals1.<>4__this.前髪.描画0(are);
					if (!CS$<>8__locals1.<>4__this.Is獣耳)
					{
						foreach (角2 角3 in CS$<>8__locals1.<>4__this.角左接続)
						{
							角3.根描画(are);
						}
						foreach (角2 角4 in CS$<>8__locals1.<>4__this.角右接続)
						{
							角4.根描画(are);
						}
					}
					if (CS$<>8__locals1.<>4__this.Is単眉)
					{
						CS$<>8__locals1.<>4__this.単眼眉.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is双眉)
					{
						CS$<>8__locals1.<>4__this.眉左.描画0(are);
						CS$<>8__locals1.<>4__this.眉右.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is頭頂_宇)
					{
						CS$<>8__locals1.<>4__this.大顎基接続.描画0(are);
						CS$<>8__locals1.<>4__this.大顎基接続.描画1(are);
						if (CS$<>8__locals1.<>4__this.Is顔面)
						{
							CS$<>8__locals1.<>4__this.顔面.描画0(are);
						}
						if (CS$<>8__locals1.<>4__this.Is頭頂)
						{
							CS$<>8__locals1.<>4__this.頭頂.描画0(are);
						}
						if (CS$<>8__locals1.<>4__this.Is獣耳)
						{
							CS$<>8__locals1.<>4__this.獣耳左.描画0(are);
							CS$<>8__locals1.<>4__this.獣耳右.描画0(are);
						}
						CS$<>8__locals1.<>4__this.植左接続.描画0(are);
						CS$<>8__locals1.<>4__this.植右接続.描画0(are);
						foreach (角2 角5 in CS$<>8__locals1.<>4__this.角左接続)
						{
							角5.先描画(are);
						}
						foreach (角2 角6 in CS$<>8__locals1.<>4__this.角右接続)
						{
							角6.先描画(are);
						}
						CS$<>8__locals1.<>4__this.額接続.描画0(are);
						CS$<>8__locals1.<>4__this.額接続.描画1(are);
						CS$<>8__locals1.<>4__this.触覚左接続.描画0(are);
						CS$<>8__locals1.<>4__this.触覚左接続.描画1(are);
						CS$<>8__locals1.<>4__this.触覚右接続.描画0(are);
						CS$<>8__locals1.<>4__this.触覚右接続.描画1(are);
					}
					else
					{
						if (CS$<>8__locals1.<>4__this.Is獣耳)
						{
							CS$<>8__locals1.<>4__this.獣耳左.描画0(are);
							CS$<>8__locals1.<>4__this.獣耳右.描画0(are);
						}
						if (CS$<>8__locals1.<>4__this.Is頭頂)
						{
							CS$<>8__locals1.<>4__this.頭頂.描画0(are);
						}
						CS$<>8__locals1.<>4__this.植左接続.描画0(are);
						CS$<>8__locals1.<>4__this.植右接続.描画0(are);
						foreach (角2 角7 in CS$<>8__locals1.<>4__this.角左接続)
						{
							角7.先描画(are);
						}
						foreach (角2 角8 in CS$<>8__locals1.<>4__this.角右接続)
						{
							角8.先描画(are);
						}
						if (CS$<>8__locals1.<>4__this.Is虫角前)
						{
							CS$<>8__locals1.<>4__this.触覚左接続.描画0(are);
							CS$<>8__locals1.<>4__this.触覚左接続.描画1(are);
							CS$<>8__locals1.<>4__this.触覚右接続.描画0(are);
							CS$<>8__locals1.<>4__this.触覚右接続.描画1(are);
							CS$<>8__locals1.<>4__this.大顎基接続.描画0(are);
							CS$<>8__locals1.<>4__this.大顎基接続.描画1(are);
							if (CS$<>8__locals1.<>4__this.Is顔面)
							{
								CS$<>8__locals1.<>4__this.顔面.描画0(are);
							}
							CS$<>8__locals1.<>4__this.額接続.描画0(are);
							CS$<>8__locals1.<>4__this.額接続.描画1(are);
						}
						else
						{
							CS$<>8__locals1.<>4__this.額接続.描画0(are);
							CS$<>8__locals1.<>4__this.額接続.描画1(are);
							CS$<>8__locals1.<>4__this.触覚左接続.描画0(are);
							CS$<>8__locals1.<>4__this.触覚左接続.描画1(are);
							CS$<>8__locals1.<>4__this.触覚右接続.描画0(are);
							CS$<>8__locals1.<>4__this.触覚右接続.描画1(are);
							CS$<>8__locals1.<>4__this.大顎基接続.描画0(are);
							CS$<>8__locals1.<>4__this.大顎基接続.描画1(are);
							if (CS$<>8__locals1.<>4__this.Is顔面)
							{
								CS$<>8__locals1.<>4__this.顔面.描画0(are);
							}
						}
					}
					CS$<>8__locals1.<>4__this.顔触覚左接続.描画0(are);
					CS$<>8__locals1.<>4__this.顔触覚左接続.描画1(are);
					CS$<>8__locals1.<>4__this.顔触覚右接続.描画0(are);
					CS$<>8__locals1.<>4__this.顔触覚右接続.描画1(are);
					if (CS$<>8__locals1.<>4__this.Is頭頂_宇 || CS$<>8__locals1.<>4__this.Is顔面 || CS$<>8__locals1.<>4__this.Is額角 || CS$<>8__locals1.<>4__this.Is触覚)
					{
						CS$<>8__locals1.<>4__this.目隠帯.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.cb0 && !(CS$<>8__locals1.<>4__this.fi = CS$<>8__locals1.<>4__this.カ\u30FCソル.Isフォ\u30FCカス膣肛挿入))
					{
						CS$<>8__locals1.<>4__this.性器精液_人.描画0(are);
						CS$<>8__locals1.<>4__this.飛沫_人.描画0(are);
						CS$<>8__locals1.<>4__this.潮吹_小_人.描画0(are);
						CS$<>8__locals1.<>4__this.潮吹_大_人.描画0(are);
						CS$<>8__locals1.<>4__this.放尿_人.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is腕前 && CS$<>8__locals1.<>4__this.Is最前腕人 && (!CS$<>8__locals1.<>4__this.腕左前後_ || !CS$<>8__locals1.<>4__this.腕右前後_))
					{
						CS$<>8__locals1.<>4__this.EI腕前.描画(are);
					}
					if (CS$<>8__locals1.<>4__this.Is半前)
					{
						CS$<>8__locals1.<>4__this.EI半前.描画(are);
					}
					CS$<>8__locals1.<>4__this.染み_人.湯気描画(are);
					if (CS$<>8__locals1.<>4__this.cb0 && CS$<>8__locals1.<>4__this.カ\u30FCソル.Is乳弄り)
					{
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画2(CS$<>8__locals1.Are);
					}
					CS$<>8__locals1.<>4__this.上着B_前掛け.前(are);
					CS$<>8__locals1.<>4__this.ぶっかけ大.Draw(are);
					CS$<>8__locals1.<>4__this.ぶっかけ小.Draw(are);
					if (CS$<>8__locals1.<>4__this.cb1)
					{
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画1(are);
					}
					if (CS$<>8__locals1.<>4__this.cb0 && CS$<>8__locals1.<>4__this.fi)
					{
						CS$<>8__locals1.<>4__this.性器精液_人.描画0(are);
						CS$<>8__locals1.<>4__this.飛沫_人.描画0(are);
						CS$<>8__locals1.<>4__this.潮吹_小_人.描画0(are);
						CS$<>8__locals1.<>4__this.潮吹_大_人.描画0(are);
						CS$<>8__locals1.<>4__this.放尿_人.描画0(are);
					}
				};
				return;
			}
			if (this.Is多足)
			{
				this.Draw = delegate(Are are)
				{
					if (CS$<>8__locals1.<>4__this.Is蠍)
					{
						CS$<>8__locals1.<>4__this.蠍.X0Y0_生殖口蓋左CP.Update();
						CS$<>8__locals1.<>4__this.蠍.X0Y0_生殖口蓋右CP.Update();
					}
					CS$<>8__locals1.<>4__this.染み_人.色更新();
					CS$<>8__locals1.<>4__this.染み_人.描画0(are);
					if (CS$<>8__locals1.<>4__this.Is胸)
					{
						CS$<>8__locals1.<>4__this.EI胸.描画(are);
					}
					if (CS$<>8__locals1.<>4__this.Is腰)
					{
						CS$<>8__locals1.<>4__this.EI腰.描画(are);
					}
					if (CS$<>8__locals1.<>4__this.Is頭頂_宇)
					{
						CS$<>8__locals1.<>4__this.頭頂後.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is髪)
					{
						CS$<>8__locals1.<>4__this.EI髪.描画(are);
					}
					if (CS$<>8__locals1.<>4__this.Is獣耳)
					{
						foreach (角2 角 in CS$<>8__locals1.<>4__this.角左接続)
						{
							角.根描画(are);
						}
						foreach (角2 角2 in CS$<>8__locals1.<>4__this.角右接続)
						{
							角2.根描画(are);
						}
					}
					CS$<>8__locals1.<>4__this.肩左飛膜.描画0(are);
					CS$<>8__locals1.<>4__this.肩右飛膜.描画0(are);
					if (CS$<>8__locals1.<>4__this.腕左右前後)
					{
						if (CS$<>8__locals1.<>4__this.腕右前後_)
						{
							CS$<>8__locals1.<>4__this.下腕以降右.描画0(are);
							CS$<>8__locals1.<>4__this.下腕以降右.描画1(are);
						}
						if (CS$<>8__locals1.<>4__this.腕左前後_)
						{
							CS$<>8__locals1.<>4__this.下腕以降左.描画0(are);
							CS$<>8__locals1.<>4__this.下腕以降左.描画1(are);
						}
					}
					else
					{
						if (CS$<>8__locals1.<>4__this.腕左前後_)
						{
							CS$<>8__locals1.<>4__this.下腕以降左.描画0(are);
							CS$<>8__locals1.<>4__this.下腕以降左.描画1(are);
						}
						if (CS$<>8__locals1.<>4__this.腕右前後_)
						{
							CS$<>8__locals1.<>4__this.下腕以降右.描画0(are);
							CS$<>8__locals1.<>4__this.下腕以降右.描画1(are);
						}
					}
					CS$<>8__locals1.<>4__this.上着B_クロス後.描画0(are);
					if (CS$<>8__locals1.<>4__this.Is半後)
					{
						CS$<>8__locals1.<>4__this.EI半後.描画(are);
					}
					if (CS$<>8__locals1.<>4__this.Is蜘尾)
					{
						CS$<>8__locals1.<>4__this.出糸精液.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.cb0)
					{
						if (CS$<>8__locals1.<>4__this.カ\u30FCソル.IsSub糸挿入)
						{
							CS$<>8__locals1.<>4__this.カ\u30FCソル.描画糸(CS$<>8__locals1.Are);
						}
						else if (CS$<>8__locals1.<>4__this.カ\u30FCソル.Is糸挿入)
						{
							CS$<>8__locals1.<>4__this.カ\u30FCソル.描画2(CS$<>8__locals1.Are);
						}
					}
					CS$<>8__locals1.<>4__this.耳左接続.描画0(are);
					CS$<>8__locals1.<>4__this.耳右接続.描画0(are);
					if (CS$<>8__locals1.<>4__this.肩左 != null)
					{
						CS$<>8__locals1.<>4__this.肩左.脇描画(are);
					}
					if (CS$<>8__locals1.<>4__this.肩右 != null)
					{
						CS$<>8__locals1.<>4__this.肩右.脇描画(are);
					}
					CS$<>8__locals1.<>4__this.腰.描画0(are);
					CS$<>8__locals1.<>4__this.腰.描画1(are);
					CS$<>8__locals1.<>4__this.胴.描画0(are);
					CS$<>8__locals1.<>4__this.胸.描画0(are);
					CS$<>8__locals1.<>4__this.首.描画0(are);
					if (CS$<>8__locals1.<>4__this.肩左 != null)
					{
						CS$<>8__locals1.<>4__this.肩左.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.肩右 != null)
					{
						CS$<>8__locals1.<>4__this.肩右.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is半中2)
					{
						CS$<>8__locals1.<>4__this.EI半中2.描画(are);
					}
					CS$<>8__locals1.<>4__this.ボテ腹_人.描画0(are);
					CS$<>8__locals1.<>4__this.ボテ腹板_人.描画0(are);
					CS$<>8__locals1.<>4__this.腰肌_人.描画0(are);
					CS$<>8__locals1.<>4__this.胴腹板_人.描画0(are);
					CS$<>8__locals1.<>4__this.胸腹板_人.描画0(are);
					CS$<>8__locals1.<>4__this.胴肌_人.描画0(are);
					CS$<>8__locals1.<>4__this.胸肌_人.描画0(are);
					CS$<>8__locals1.<>4__this.下着T_チュ\u30FCブ.描画0(are);
					CS$<>8__locals1.<>4__this.下着T_クロス.描画0(are);
					CS$<>8__locals1.<>4__this.下着T_ビキニ.描画0(are);
					CS$<>8__locals1.<>4__this.下着T_マイクロ.描画0(are);
					CS$<>8__locals1.<>4__this.下着T_ブラ.描画0(are);
					CS$<>8__locals1.<>4__this.腕左.描画0(are);
					CS$<>8__locals1.<>4__this.腕右.描画0(are);
					CS$<>8__locals1.<>4__this.腕左.描画1(are);
					CS$<>8__locals1.<>4__this.腕右.描画1(are);
					if (CS$<>8__locals1.<>4__this.胸左右前後)
					{
						CS$<>8__locals1.<>4__this.乳房右.描画0(are);
						CS$<>8__locals1.<>4__this.乳房左.描画0(are);
					}
					else
					{
						CS$<>8__locals1.<>4__this.乳房左.描画0(are);
						CS$<>8__locals1.<>4__this.乳房右.描画0(are);
					}
					CS$<>8__locals1.<>4__this.ピアス左.描画0(are);
					CS$<>8__locals1.<>4__this.ピアス右.描画0(are);
					CS$<>8__locals1.<>4__this.噴乳左.描画0(are);
					CS$<>8__locals1.<>4__this.噴乳右.描画0(are);
					CS$<>8__locals1.<>4__this.キャップ2左.描画0(are);
					CS$<>8__locals1.<>4__this.キャップ2右.描画0(are);
					CS$<>8__locals1.<>4__this.胸肌_人.描画1(are);
					if (CS$<>8__locals1.<>4__this.汗掻き != null)
					{
						CS$<>8__locals1.<>4__this.汗掻き.Draw(are);
					}
					CS$<>8__locals1.<>4__this.頭.描画0(are);
					if (CS$<>8__locals1.<>4__this.Is双眼 && !CS$<>8__locals1.<>4__this.Is瞼宇)
					{
						CS$<>8__locals1.<>4__this.目左.描画0(are);
						CS$<>8__locals1.<>4__this.瞼左.描画0(are);
						CS$<>8__locals1.<>4__this.目右.描画0(are);
						CS$<>8__locals1.<>4__this.瞼右.描画0(are);
					}
					CS$<>8__locals1.<>4__this.頭.描画1(are);
					if (CS$<>8__locals1.<>4__this.Is単眼)
					{
						CS$<>8__locals1.<>4__this.単眼目.描画0(are);
						CS$<>8__locals1.<>4__this.単眼瞼.描画0(are);
					}
					CS$<>8__locals1.<>4__this.紅潮.描画0(are);
					CS$<>8__locals1.<>4__this.鼻肌.描画0(are);
					CS$<>8__locals1.<>4__this.目尻影左.描画0(are);
					CS$<>8__locals1.<>4__this.目尻影右.描画0(are);
					CS$<>8__locals1.<>4__this.目傷左.描画0(are);
					CS$<>8__locals1.<>4__this.目傷右.描画0(are);
					CS$<>8__locals1.<>4__this.頬肌左.描画0(are);
					CS$<>8__locals1.<>4__this.頬肌右.描画0(are);
					if (CS$<>8__locals1.<>4__this.Is額眼)
					{
						CS$<>8__locals1.<>4__this.額目.描画0(are);
						CS$<>8__locals1.<>4__this.額瞼.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is頬眼)
					{
						CS$<>8__locals1.<>4__this.頬目左.描画0(are);
						CS$<>8__locals1.<>4__this.頬目右.描画0(are);
						CS$<>8__locals1.<>4__this.頬瞼左.描画0(are);
						CS$<>8__locals1.<>4__this.頬瞼右.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is瞼宇)
					{
						CS$<>8__locals1.<>4__this.瞼左.描画0(are);
						CS$<>8__locals1.<>4__this.瞼右.描画0(are);
					}
					CS$<>8__locals1.<>4__this.涎左.描画0(are);
					CS$<>8__locals1.<>4__this.涎右.描画0(are);
					CS$<>8__locals1.<>4__this.口.描画0(are);
					if (CS$<>8__locals1.<>4__this.鼻描画)
					{
						CS$<>8__locals1.<>4__this.鼻.描画0(are);
						CS$<>8__locals1.<>4__this.鼻水左.描画0(are);
						CS$<>8__locals1.<>4__this.鼻水右.描画0(are);
					}
					CS$<>8__locals1.<>4__this.頭.描画2(are);
					CS$<>8__locals1.<>4__this.玉口枷.描画0(are);
					CS$<>8__locals1.<>4__this.基髪.描画0(are);
					CS$<>8__locals1.<>4__this.横髪左.描画0(are);
					CS$<>8__locals1.<>4__this.横髪右.描画0(are);
					CS$<>8__locals1.<>4__this.頬左接続.描画0(are);
					CS$<>8__locals1.<>4__this.頬左接続.描画1(are);
					CS$<>8__locals1.<>4__this.頬右接続.描画0(are);
					CS$<>8__locals1.<>4__this.頬右接続.描画1(are);
					CS$<>8__locals1.<>4__this.頬肌左.描画1(are);
					CS$<>8__locals1.<>4__this.頬肌右.描画1(are);
					if (CS$<>8__locals1.<>4__this.涙描画)
					{
						CS$<>8__locals1.<>4__this.涙左.描画0(are);
						CS$<>8__locals1.<>4__this.涙右.描画0(are);
					}
					if (!CS$<>8__locals1.<>4__this.Is頭頂_宇 && !CS$<>8__locals1.<>4__this.Is顔面 && !CS$<>8__locals1.<>4__this.Is額角 && !CS$<>8__locals1.<>4__this.Is触覚)
					{
						CS$<>8__locals1.<>4__this.目隠帯.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is腕前 && !CS$<>8__locals1.<>4__this.Is最前腕人 && (!CS$<>8__locals1.<>4__this.腕左前後_ || !CS$<>8__locals1.<>4__this.腕右前後_))
					{
						CS$<>8__locals1.<>4__this.EI腕前.描画(are);
					}
					if (CS$<>8__locals1.<>4__this.Is半中1)
					{
						CS$<>8__locals1.<>4__this.EI半中1.描画(are);
					}
					CS$<>8__locals1.<>4__this.肛門_人.描画0(are);
					CS$<>8__locals1.<>4__this.肛門精液_人.描画0(are);
					if (CS$<>8__locals1.<>4__this.cb1)
					{
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画肛(are);
					}
					CS$<>8__locals1.<>4__this.膣基_人.描画0(are);
					if (CS$<>8__locals1.<>4__this.断面_表示 && CS$<>8__locals1.<>4__this.cb1)
					{
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画0(are);
					}
					CS$<>8__locals1.<>4__this.膣内精液_人.描画0(are);
					CS$<>8__locals1.<>4__this.断面_人.描画0(are);
					CS$<>8__locals1.<>4__this.性器_人.描画0(are);
					if (!CS$<>8__locals1.<>4__this.断面_表示 && CS$<>8__locals1.<>4__this.cb1)
					{
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画0(are);
					}
					CS$<>8__locals1.<>4__this.ピアス.描画0(are);
					if (CS$<>8__locals1.<>4__this.蠍前 != null)
					{
						CS$<>8__locals1.<>4__this.蠍前.描画0(are);
					}
					CS$<>8__locals1.<>4__this.下着T_チュ\u30FCブ.描画1(are);
					CS$<>8__locals1.<>4__this.下着T_クロス.描画1(are);
					CS$<>8__locals1.<>4__this.下着T_ビキニ.描画1(are);
					CS$<>8__locals1.<>4__this.下着T_マイクロ.描画1(are);
					CS$<>8__locals1.<>4__this.下着T_ブラ.描画1(are);
					CS$<>8__locals1.<>4__this.下着乳首左.描画0(are);
					CS$<>8__locals1.<>4__this.下着乳首右.描画0(are);
					CS$<>8__locals1.<>4__this.キャップ1.描画0(are);
					CS$<>8__locals1.<>4__this.上着M_ドレス.描画0(are);
					CS$<>8__locals1.<>4__this.上着T_ドレス.描画0(are);
					CS$<>8__locals1.<>4__this.上着B_前掛け.描画0(are);
					CS$<>8__locals1.<>4__this.上着B_クロス.描画0(are);
					if (CS$<>8__locals1.<>4__this.胸毛_人 != null)
					{
						CS$<>8__locals1.<>4__this.胸毛_人.描画0(are);
					}
					CS$<>8__locals1.<>4__this.舌.描画0(are);
					CS$<>8__locals1.<>4__this.口精液.描画0(are);
					CS$<>8__locals1.<>4__this.咳.描画0(are);
					CS$<>8__locals1.<>4__this.呼気.描画0(are);
					if (CS$<>8__locals1.<>4__this.cb0 && CS$<>8__locals1.<>4__this.カ\u30FCソル.コキ)
					{
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画0(are);
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画1(are);
					}
					CS$<>8__locals1.<>4__this.前髪.描画0(are);
					if (!CS$<>8__locals1.<>4__this.Is獣耳)
					{
						foreach (角2 角3 in CS$<>8__locals1.<>4__this.角左接続)
						{
							角3.根描画(are);
						}
						foreach (角2 角4 in CS$<>8__locals1.<>4__this.角右接続)
						{
							角4.根描画(are);
						}
					}
					if (CS$<>8__locals1.<>4__this.Is単眉)
					{
						CS$<>8__locals1.<>4__this.単眼眉.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is双眉)
					{
						CS$<>8__locals1.<>4__this.眉左.描画0(are);
						CS$<>8__locals1.<>4__this.眉右.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is頭頂_宇)
					{
						CS$<>8__locals1.<>4__this.大顎基接続.描画0(are);
						CS$<>8__locals1.<>4__this.大顎基接続.描画1(are);
						if (CS$<>8__locals1.<>4__this.Is顔面)
						{
							CS$<>8__locals1.<>4__this.顔面.描画0(are);
						}
						if (CS$<>8__locals1.<>4__this.Is頭頂)
						{
							CS$<>8__locals1.<>4__this.頭頂.描画0(are);
						}
						if (CS$<>8__locals1.<>4__this.Is獣耳)
						{
							CS$<>8__locals1.<>4__this.獣耳左.描画0(are);
							CS$<>8__locals1.<>4__this.獣耳右.描画0(are);
						}
						CS$<>8__locals1.<>4__this.植左接続.描画0(are);
						CS$<>8__locals1.<>4__this.植右接続.描画0(are);
						foreach (角2 角5 in CS$<>8__locals1.<>4__this.角左接続)
						{
							角5.先描画(are);
						}
						foreach (角2 角6 in CS$<>8__locals1.<>4__this.角右接続)
						{
							角6.先描画(are);
						}
						CS$<>8__locals1.<>4__this.額接続.描画0(are);
						CS$<>8__locals1.<>4__this.額接続.描画1(are);
						CS$<>8__locals1.<>4__this.触覚左接続.描画0(are);
						CS$<>8__locals1.<>4__this.触覚左接続.描画1(are);
						CS$<>8__locals1.<>4__this.触覚右接続.描画0(are);
						CS$<>8__locals1.<>4__this.触覚右接続.描画1(are);
					}
					else
					{
						if (CS$<>8__locals1.<>4__this.Is獣耳)
						{
							CS$<>8__locals1.<>4__this.獣耳左.描画0(are);
							CS$<>8__locals1.<>4__this.獣耳右.描画0(are);
						}
						if (CS$<>8__locals1.<>4__this.Is頭頂)
						{
							CS$<>8__locals1.<>4__this.頭頂.描画0(are);
						}
						CS$<>8__locals1.<>4__this.植左接続.描画0(are);
						CS$<>8__locals1.<>4__this.植右接続.描画0(are);
						foreach (角2 角7 in CS$<>8__locals1.<>4__this.角左接続)
						{
							角7.先描画(are);
						}
						foreach (角2 角8 in CS$<>8__locals1.<>4__this.角右接続)
						{
							角8.先描画(are);
						}
						if (CS$<>8__locals1.<>4__this.Is虫角前)
						{
							CS$<>8__locals1.<>4__this.触覚左接続.描画0(are);
							CS$<>8__locals1.<>4__this.触覚左接続.描画1(are);
							CS$<>8__locals1.<>4__this.触覚右接続.描画0(are);
							CS$<>8__locals1.<>4__this.触覚右接続.描画1(are);
							CS$<>8__locals1.<>4__this.大顎基接続.描画0(are);
							CS$<>8__locals1.<>4__this.大顎基接続.描画1(are);
							if (CS$<>8__locals1.<>4__this.Is顔面)
							{
								CS$<>8__locals1.<>4__this.顔面.描画0(are);
							}
							CS$<>8__locals1.<>4__this.額接続.描画0(are);
							CS$<>8__locals1.<>4__this.額接続.描画1(are);
						}
						else
						{
							CS$<>8__locals1.<>4__this.額接続.描画0(are);
							CS$<>8__locals1.<>4__this.額接続.描画1(are);
							CS$<>8__locals1.<>4__this.触覚左接続.描画0(are);
							CS$<>8__locals1.<>4__this.触覚左接続.描画1(are);
							CS$<>8__locals1.<>4__this.触覚右接続.描画0(are);
							CS$<>8__locals1.<>4__this.触覚右接続.描画1(are);
							CS$<>8__locals1.<>4__this.大顎基接続.描画0(are);
							CS$<>8__locals1.<>4__this.大顎基接続.描画1(are);
							if (CS$<>8__locals1.<>4__this.Is顔面)
							{
								CS$<>8__locals1.<>4__this.顔面.描画0(are);
							}
						}
					}
					CS$<>8__locals1.<>4__this.顔触覚左接続.描画0(are);
					CS$<>8__locals1.<>4__this.顔触覚左接続.描画1(are);
					CS$<>8__locals1.<>4__this.顔触覚右接続.描画0(are);
					CS$<>8__locals1.<>4__this.顔触覚右接続.描画1(are);
					if (CS$<>8__locals1.<>4__this.Is頭頂_宇 || CS$<>8__locals1.<>4__this.Is顔面 || CS$<>8__locals1.<>4__this.Is額角 || CS$<>8__locals1.<>4__this.Is触覚)
					{
						CS$<>8__locals1.<>4__this.目隠帯.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.cb0 && !(CS$<>8__locals1.<>4__this.fi = CS$<>8__locals1.<>4__this.カ\u30FCソル.Isフォ\u30FCカス膣肛挿入))
					{
						CS$<>8__locals1.<>4__this.性器精液_人.描画0(are);
						CS$<>8__locals1.<>4__this.飛沫_人.描画0(are);
						CS$<>8__locals1.<>4__this.潮吹_小_人.描画0(are);
						CS$<>8__locals1.<>4__this.潮吹_大_人.描画0(are);
						CS$<>8__locals1.<>4__this.放尿_人.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is腕前 && CS$<>8__locals1.<>4__this.Is最前腕人 && (!CS$<>8__locals1.<>4__this.腕左前後_ || !CS$<>8__locals1.<>4__this.腕右前後_))
					{
						CS$<>8__locals1.<>4__this.EI腕前.描画(are);
					}
					if (CS$<>8__locals1.<>4__this.Is半前)
					{
						CS$<>8__locals1.<>4__this.EI半前.描画(are);
					}
					CS$<>8__locals1.<>4__this.染み_人.湯気描画(are);
					if (CS$<>8__locals1.<>4__this.cb0 && CS$<>8__locals1.<>4__this.カ\u30FCソル.Is乳弄り)
					{
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画2(CS$<>8__locals1.Are);
					}
					CS$<>8__locals1.<>4__this.上着B_前掛け.前(are);
					CS$<>8__locals1.<>4__this.ぶっかけ大.Draw(are);
					CS$<>8__locals1.<>4__this.ぶっかけ小.Draw(are);
					if (CS$<>8__locals1.<>4__this.cb1)
					{
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画1(are);
					}
					if (CS$<>8__locals1.<>4__this.cb0 && CS$<>8__locals1.<>4__this.fi)
					{
						CS$<>8__locals1.<>4__this.性器精液_人.描画0(are);
						CS$<>8__locals1.<>4__this.飛沫_人.描画0(are);
						CS$<>8__locals1.<>4__this.潮吹_小_人.描画0(are);
						CS$<>8__locals1.<>4__this.潮吹_大_人.描画0(are);
						CS$<>8__locals1.<>4__this.放尿_人.描画0(are);
					}
				};
				return;
			}
			if (this.Is植)
			{
				this.Draw = delegate(Are are)
				{
					CS$<>8__locals1.<>4__this.染み_人.色更新();
					CS$<>8__locals1.<>4__this.染み_人.描画0(are);
					if (CS$<>8__locals1.<>4__this.Is胸)
					{
						CS$<>8__locals1.<>4__this.EI胸.描画(are);
					}
					if (CS$<>8__locals1.<>4__this.Is腰)
					{
						CS$<>8__locals1.<>4__this.EI腰.描画(are);
					}
					if (CS$<>8__locals1.<>4__this.Is頭頂_宇)
					{
						CS$<>8__locals1.<>4__this.頭頂後.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is髪)
					{
						CS$<>8__locals1.<>4__this.EI髪.描画(are);
					}
					if (CS$<>8__locals1.<>4__this.Is獣耳)
					{
						foreach (角2 角 in CS$<>8__locals1.<>4__this.角左接続)
						{
							角.根描画(are);
						}
						foreach (角2 角2 in CS$<>8__locals1.<>4__this.角右接続)
						{
							角2.根描画(are);
						}
					}
					CS$<>8__locals1.<>4__this.肩左飛膜.描画0(are);
					CS$<>8__locals1.<>4__this.肩右飛膜.描画0(are);
					if (CS$<>8__locals1.<>4__this.腕左右前後)
					{
						if (CS$<>8__locals1.<>4__this.腕右前後_)
						{
							CS$<>8__locals1.<>4__this.下腕以降右.描画0(are);
							CS$<>8__locals1.<>4__this.下腕以降右.描画1(are);
						}
						if (CS$<>8__locals1.<>4__this.腕左前後_)
						{
							CS$<>8__locals1.<>4__this.下腕以降左.描画0(are);
							CS$<>8__locals1.<>4__this.下腕以降左.描画1(are);
						}
					}
					else
					{
						if (CS$<>8__locals1.<>4__this.腕左前後_)
						{
							CS$<>8__locals1.<>4__this.下腕以降左.描画0(are);
							CS$<>8__locals1.<>4__this.下腕以降左.描画1(are);
						}
						if (CS$<>8__locals1.<>4__this.腕右前後_)
						{
							CS$<>8__locals1.<>4__this.下腕以降右.描画0(are);
							CS$<>8__locals1.<>4__this.下腕以降右.描画1(are);
						}
					}
					CS$<>8__locals1.<>4__this.上着B_クロス後.描画0(are);
					if (CS$<>8__locals1.<>4__this.Is半後)
					{
						CS$<>8__locals1.<>4__this.EI半後.描画(are);
					}
					if (CS$<>8__locals1.<>4__this.Is蜘尾)
					{
						CS$<>8__locals1.<>4__this.出糸精液.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.cb0)
					{
						if (CS$<>8__locals1.<>4__this.カ\u30FCソル.IsSub糸挿入)
						{
							CS$<>8__locals1.<>4__this.カ\u30FCソル.描画糸(CS$<>8__locals1.Are);
						}
						else if (CS$<>8__locals1.<>4__this.カ\u30FCソル.Is糸挿入)
						{
							CS$<>8__locals1.<>4__this.カ\u30FCソル.描画2(CS$<>8__locals1.Are);
						}
					}
					CS$<>8__locals1.<>4__this.耳左接続.描画0(are);
					CS$<>8__locals1.<>4__this.耳右接続.描画0(are);
					if (CS$<>8__locals1.<>4__this.肩左 != null)
					{
						CS$<>8__locals1.<>4__this.肩左.脇描画(are);
					}
					if (CS$<>8__locals1.<>4__this.肩右 != null)
					{
						CS$<>8__locals1.<>4__this.肩右.脇描画(are);
					}
					CS$<>8__locals1.<>4__this.腰.描画0(are);
					CS$<>8__locals1.<>4__this.腰.描画1(are);
					CS$<>8__locals1.<>4__this.胴.描画0(are);
					CS$<>8__locals1.<>4__this.胸.描画0(are);
					CS$<>8__locals1.<>4__this.首.描画0(are);
					if (CS$<>8__locals1.<>4__this.肩左 != null)
					{
						CS$<>8__locals1.<>4__this.肩左.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.肩右 != null)
					{
						CS$<>8__locals1.<>4__this.肩右.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is半中2)
					{
						CS$<>8__locals1.<>4__this.EI半中2.描画(are);
					}
					CS$<>8__locals1.<>4__this.ボテ腹_人.描画0(are);
					CS$<>8__locals1.<>4__this.ボテ腹板_人.描画0(are);
					CS$<>8__locals1.<>4__this.腰肌_人.描画0(are);
					CS$<>8__locals1.<>4__this.胴腹板_人.描画0(are);
					CS$<>8__locals1.<>4__this.胸腹板_人.描画0(are);
					CS$<>8__locals1.<>4__this.胴肌_人.描画0(are);
					CS$<>8__locals1.<>4__this.胸肌_人.描画0(are);
					CS$<>8__locals1.<>4__this.下着T_チュ\u30FCブ.描画0(are);
					CS$<>8__locals1.<>4__this.下着T_クロス.描画0(are);
					CS$<>8__locals1.<>4__this.下着T_ビキニ.描画0(are);
					CS$<>8__locals1.<>4__this.下着T_マイクロ.描画0(are);
					CS$<>8__locals1.<>4__this.下着T_ブラ.描画0(are);
					CS$<>8__locals1.<>4__this.腕左.描画0(are);
					CS$<>8__locals1.<>4__this.腕右.描画0(are);
					CS$<>8__locals1.<>4__this.腕左.描画1(are);
					CS$<>8__locals1.<>4__this.腕右.描画1(are);
					if (CS$<>8__locals1.<>4__this.胸左右前後)
					{
						CS$<>8__locals1.<>4__this.乳房右.描画0(are);
						CS$<>8__locals1.<>4__this.乳房左.描画0(are);
					}
					else
					{
						CS$<>8__locals1.<>4__this.乳房左.描画0(are);
						CS$<>8__locals1.<>4__this.乳房右.描画0(are);
					}
					CS$<>8__locals1.<>4__this.ピアス左.描画0(are);
					CS$<>8__locals1.<>4__this.ピアス右.描画0(are);
					CS$<>8__locals1.<>4__this.噴乳左.描画0(are);
					CS$<>8__locals1.<>4__this.噴乳右.描画0(are);
					CS$<>8__locals1.<>4__this.キャップ2左.描画0(are);
					CS$<>8__locals1.<>4__this.キャップ2右.描画0(are);
					CS$<>8__locals1.<>4__this.胸肌_人.描画1(are);
					if (CS$<>8__locals1.<>4__this.汗掻き != null)
					{
						CS$<>8__locals1.<>4__this.汗掻き.Draw(are);
					}
					CS$<>8__locals1.<>4__this.頭.描画0(are);
					if (CS$<>8__locals1.<>4__this.Is双眼 && !CS$<>8__locals1.<>4__this.Is瞼宇)
					{
						CS$<>8__locals1.<>4__this.目左.描画0(are);
						CS$<>8__locals1.<>4__this.瞼左.描画0(are);
						CS$<>8__locals1.<>4__this.目右.描画0(are);
						CS$<>8__locals1.<>4__this.瞼右.描画0(are);
					}
					CS$<>8__locals1.<>4__this.頭.描画1(are);
					if (CS$<>8__locals1.<>4__this.Is単眼)
					{
						CS$<>8__locals1.<>4__this.単眼目.描画0(are);
						CS$<>8__locals1.<>4__this.単眼瞼.描画0(are);
					}
					CS$<>8__locals1.<>4__this.紅潮.描画0(are);
					CS$<>8__locals1.<>4__this.鼻肌.描画0(are);
					CS$<>8__locals1.<>4__this.目尻影左.描画0(are);
					CS$<>8__locals1.<>4__this.目尻影右.描画0(are);
					CS$<>8__locals1.<>4__this.目傷左.描画0(are);
					CS$<>8__locals1.<>4__this.目傷右.描画0(are);
					CS$<>8__locals1.<>4__this.頬肌左.描画0(are);
					CS$<>8__locals1.<>4__this.頬肌右.描画0(are);
					if (CS$<>8__locals1.<>4__this.Is額眼)
					{
						CS$<>8__locals1.<>4__this.額目.描画0(are);
						CS$<>8__locals1.<>4__this.額瞼.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is頬眼)
					{
						CS$<>8__locals1.<>4__this.頬目左.描画0(are);
						CS$<>8__locals1.<>4__this.頬目右.描画0(are);
						CS$<>8__locals1.<>4__this.頬瞼左.描画0(are);
						CS$<>8__locals1.<>4__this.頬瞼右.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is瞼宇)
					{
						CS$<>8__locals1.<>4__this.瞼左.描画0(are);
						CS$<>8__locals1.<>4__this.瞼右.描画0(are);
					}
					CS$<>8__locals1.<>4__this.涎左.描画0(are);
					CS$<>8__locals1.<>4__this.涎右.描画0(are);
					CS$<>8__locals1.<>4__this.口.描画0(are);
					if (CS$<>8__locals1.<>4__this.鼻描画)
					{
						CS$<>8__locals1.<>4__this.鼻.描画0(are);
						CS$<>8__locals1.<>4__this.鼻水左.描画0(are);
						CS$<>8__locals1.<>4__this.鼻水右.描画0(are);
					}
					CS$<>8__locals1.<>4__this.頭.描画2(are);
					CS$<>8__locals1.<>4__this.玉口枷.描画0(are);
					CS$<>8__locals1.<>4__this.基髪.描画0(are);
					CS$<>8__locals1.<>4__this.横髪左.描画0(are);
					CS$<>8__locals1.<>4__this.横髪右.描画0(are);
					CS$<>8__locals1.<>4__this.頬左接続.描画0(are);
					CS$<>8__locals1.<>4__this.頬左接続.描画1(are);
					CS$<>8__locals1.<>4__this.頬右接続.描画0(are);
					CS$<>8__locals1.<>4__this.頬右接続.描画1(are);
					CS$<>8__locals1.<>4__this.頬肌左.描画1(are);
					CS$<>8__locals1.<>4__this.頬肌右.描画1(are);
					if (CS$<>8__locals1.<>4__this.涙描画)
					{
						CS$<>8__locals1.<>4__this.涙左.描画0(are);
						CS$<>8__locals1.<>4__this.涙右.描画0(are);
					}
					if (!CS$<>8__locals1.<>4__this.Is頭頂_宇 && !CS$<>8__locals1.<>4__this.Is顔面 && !CS$<>8__locals1.<>4__this.Is額角 && !CS$<>8__locals1.<>4__this.Is触覚)
					{
						CS$<>8__locals1.<>4__this.目隠帯.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is腕前 && !CS$<>8__locals1.<>4__this.Is最前腕人 && (!CS$<>8__locals1.<>4__this.腕左前後_ || !CS$<>8__locals1.<>4__this.腕右前後_))
					{
						CS$<>8__locals1.<>4__this.EI腕前.描画(are);
					}
					CS$<>8__locals1.<>4__this.肛門_人.描画0(are);
					CS$<>8__locals1.<>4__this.肛門精液_人.描画0(are);
					if (!CS$<>8__locals1.<>4__this.Is下着B)
					{
						CS$<>8__locals1.<>4__this.EI腿.描画(are);
						if (CS$<>8__locals1.<>4__this.Is半中1)
						{
							CS$<>8__locals1.<>4__this.EI半中1.描画(are);
						}
					}
					if (CS$<>8__locals1.<>4__this.cb1)
					{
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画肛(are);
					}
					CS$<>8__locals1.<>4__this.膣基_人.描画0(are);
					if (CS$<>8__locals1.<>4__this.断面_表示 && CS$<>8__locals1.<>4__this.cb1)
					{
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画0(are);
					}
					CS$<>8__locals1.<>4__this.膣内精液_人.描画0(are);
					CS$<>8__locals1.<>4__this.断面_人.描画0(are);
					CS$<>8__locals1.<>4__this.性器_人.描画0(are);
					if (!CS$<>8__locals1.<>4__this.断面_表示 && CS$<>8__locals1.<>4__this.cb1)
					{
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画0(are);
					}
					CS$<>8__locals1.<>4__this.ピアス.描画0(are);
					CS$<>8__locals1.<>4__this.下着T_チュ\u30FCブ.描画1(are);
					CS$<>8__locals1.<>4__this.下着T_クロス.描画1(are);
					CS$<>8__locals1.<>4__this.下着T_ビキニ.描画1(are);
					CS$<>8__locals1.<>4__this.下着T_マイクロ.描画1(are);
					CS$<>8__locals1.<>4__this.下着T_ブラ.描画1(are);
					CS$<>8__locals1.<>4__this.下着乳首左.描画0(are);
					CS$<>8__locals1.<>4__this.下着乳首右.描画0(are);
					CS$<>8__locals1.<>4__this.キャップ1.描画0(are);
					CS$<>8__locals1.<>4__this.下着B_ノ\u30FCマル.描画0(are);
					CS$<>8__locals1.<>4__this.下着B_マイクロ.描画0(are);
					CS$<>8__locals1.<>4__this.下着B_ノ\u30FCマル.描画1(are);
					CS$<>8__locals1.<>4__this.下着B_マイクロ.描画1(are);
					CS$<>8__locals1.<>4__this.下着陰核.描画0(are);
					CS$<>8__locals1.<>4__this.上着M_ドレス.描画0(are);
					CS$<>8__locals1.<>4__this.上着T_ドレス.描画0(are);
					if (CS$<>8__locals1.<>4__this.Is下着B)
					{
						CS$<>8__locals1.<>4__this.EI腿.描画(are);
						if (CS$<>8__locals1.<>4__this.Is半中1)
						{
							CS$<>8__locals1.<>4__this.EI半中1.描画(are);
						}
					}
					CS$<>8__locals1.<>4__this.上着B_前掛け.描画0(are);
					CS$<>8__locals1.<>4__this.上着B_クロス.描画0(are);
					if (CS$<>8__locals1.<>4__this.胸毛_人 != null)
					{
						CS$<>8__locals1.<>4__this.胸毛_人.描画0(are);
					}
					CS$<>8__locals1.<>4__this.舌.描画0(are);
					CS$<>8__locals1.<>4__this.口精液.描画0(are);
					CS$<>8__locals1.<>4__this.咳.描画0(are);
					CS$<>8__locals1.<>4__this.呼気.描画0(are);
					if (CS$<>8__locals1.<>4__this.cb0 && CS$<>8__locals1.<>4__this.カ\u30FCソル.コキ)
					{
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画0(are);
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画1(are);
					}
					CS$<>8__locals1.<>4__this.前髪.描画0(are);
					if (!CS$<>8__locals1.<>4__this.Is獣耳)
					{
						foreach (角2 角3 in CS$<>8__locals1.<>4__this.角左接続)
						{
							角3.根描画(are);
						}
						foreach (角2 角4 in CS$<>8__locals1.<>4__this.角右接続)
						{
							角4.根描画(are);
						}
					}
					if (CS$<>8__locals1.<>4__this.Is単眉)
					{
						CS$<>8__locals1.<>4__this.単眼眉.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is双眉)
					{
						CS$<>8__locals1.<>4__this.眉左.描画0(are);
						CS$<>8__locals1.<>4__this.眉右.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is頭頂_宇)
					{
						CS$<>8__locals1.<>4__this.大顎基接続.描画0(are);
						CS$<>8__locals1.<>4__this.大顎基接続.描画1(are);
						if (CS$<>8__locals1.<>4__this.Is顔面)
						{
							CS$<>8__locals1.<>4__this.顔面.描画0(are);
						}
						if (CS$<>8__locals1.<>4__this.Is頭頂)
						{
							CS$<>8__locals1.<>4__this.頭頂.描画0(are);
						}
						if (CS$<>8__locals1.<>4__this.Is獣耳)
						{
							CS$<>8__locals1.<>4__this.獣耳左.描画0(are);
							CS$<>8__locals1.<>4__this.獣耳右.描画0(are);
						}
						CS$<>8__locals1.<>4__this.植左接続.描画0(are);
						CS$<>8__locals1.<>4__this.植右接続.描画0(are);
						foreach (角2 角5 in CS$<>8__locals1.<>4__this.角左接続)
						{
							角5.先描画(are);
						}
						foreach (角2 角6 in CS$<>8__locals1.<>4__this.角右接続)
						{
							角6.先描画(are);
						}
						CS$<>8__locals1.<>4__this.額接続.描画0(are);
						CS$<>8__locals1.<>4__this.額接続.描画1(are);
						CS$<>8__locals1.<>4__this.触覚左接続.描画0(are);
						CS$<>8__locals1.<>4__this.触覚左接続.描画1(are);
						CS$<>8__locals1.<>4__this.触覚右接続.描画0(are);
						CS$<>8__locals1.<>4__this.触覚右接続.描画1(are);
					}
					else
					{
						if (CS$<>8__locals1.<>4__this.Is獣耳)
						{
							CS$<>8__locals1.<>4__this.獣耳左.描画0(are);
							CS$<>8__locals1.<>4__this.獣耳右.描画0(are);
						}
						if (CS$<>8__locals1.<>4__this.Is頭頂)
						{
							CS$<>8__locals1.<>4__this.頭頂.描画0(are);
						}
						CS$<>8__locals1.<>4__this.植左接続.描画0(are);
						CS$<>8__locals1.<>4__this.植右接続.描画0(are);
						foreach (角2 角7 in CS$<>8__locals1.<>4__this.角左接続)
						{
							角7.先描画(are);
						}
						foreach (角2 角8 in CS$<>8__locals1.<>4__this.角右接続)
						{
							角8.先描画(are);
						}
						if (CS$<>8__locals1.<>4__this.Is虫角前)
						{
							CS$<>8__locals1.<>4__this.触覚左接続.描画0(are);
							CS$<>8__locals1.<>4__this.触覚左接続.描画1(are);
							CS$<>8__locals1.<>4__this.触覚右接続.描画0(are);
							CS$<>8__locals1.<>4__this.触覚右接続.描画1(are);
							CS$<>8__locals1.<>4__this.大顎基接続.描画0(are);
							CS$<>8__locals1.<>4__this.大顎基接続.描画1(are);
							if (CS$<>8__locals1.<>4__this.Is顔面)
							{
								CS$<>8__locals1.<>4__this.顔面.描画0(are);
							}
							CS$<>8__locals1.<>4__this.額接続.描画0(are);
							CS$<>8__locals1.<>4__this.額接続.描画1(are);
						}
						else
						{
							CS$<>8__locals1.<>4__this.額接続.描画0(are);
							CS$<>8__locals1.<>4__this.額接続.描画1(are);
							CS$<>8__locals1.<>4__this.触覚左接続.描画0(are);
							CS$<>8__locals1.<>4__this.触覚左接続.描画1(are);
							CS$<>8__locals1.<>4__this.触覚右接続.描画0(are);
							CS$<>8__locals1.<>4__this.触覚右接続.描画1(are);
							CS$<>8__locals1.<>4__this.大顎基接続.描画0(are);
							CS$<>8__locals1.<>4__this.大顎基接続.描画1(are);
							if (CS$<>8__locals1.<>4__this.Is顔面)
							{
								CS$<>8__locals1.<>4__this.顔面.描画0(are);
							}
						}
					}
					CS$<>8__locals1.<>4__this.顔触覚左接続.描画0(are);
					CS$<>8__locals1.<>4__this.顔触覚左接続.描画1(are);
					CS$<>8__locals1.<>4__this.顔触覚右接続.描画0(are);
					CS$<>8__locals1.<>4__this.顔触覚右接続.描画1(are);
					if (CS$<>8__locals1.<>4__this.Is頭頂_宇 || CS$<>8__locals1.<>4__this.Is顔面 || CS$<>8__locals1.<>4__this.Is額角 || CS$<>8__locals1.<>4__this.Is触覚)
					{
						CS$<>8__locals1.<>4__this.目隠帯.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.cb0 && !(CS$<>8__locals1.<>4__this.fi = CS$<>8__locals1.<>4__this.カ\u30FCソル.Isフォ\u30FCカス膣肛挿入))
					{
						CS$<>8__locals1.<>4__this.性器精液_人.描画0(are);
						CS$<>8__locals1.<>4__this.飛沫_人.描画0(are);
						CS$<>8__locals1.<>4__this.潮吹_小_人.描画0(are);
						CS$<>8__locals1.<>4__this.潮吹_大_人.描画0(are);
						CS$<>8__locals1.<>4__this.放尿_人.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is腕前 && CS$<>8__locals1.<>4__this.Is最前腕人 && (!CS$<>8__locals1.<>4__this.腕左前後_ || !CS$<>8__locals1.<>4__this.腕右前後_))
					{
						CS$<>8__locals1.<>4__this.EI腕前.描画(are);
					}
					if (CS$<>8__locals1.<>4__this.Is半前)
					{
						CS$<>8__locals1.<>4__this.EI半前.描画(are);
					}
					CS$<>8__locals1.<>4__this.染み_人.湯気描画(are);
					if (CS$<>8__locals1.<>4__this.cb0 && CS$<>8__locals1.<>4__this.カ\u30FCソル.Is乳弄り)
					{
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画2(CS$<>8__locals1.Are);
					}
					CS$<>8__locals1.<>4__this.上着B_前掛け.前(are);
					CS$<>8__locals1.<>4__this.ぶっかけ大.Draw(are);
					CS$<>8__locals1.<>4__this.ぶっかけ小.Draw(are);
					if (CS$<>8__locals1.<>4__this.cb1)
					{
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画1(are);
					}
					if (CS$<>8__locals1.<>4__this.cb0 && CS$<>8__locals1.<>4__this.fi)
					{
						CS$<>8__locals1.<>4__this.性器精液_人.描画0(are);
						CS$<>8__locals1.<>4__this.飛沫_人.描画0(are);
						CS$<>8__locals1.<>4__this.潮吹_小_人.描画0(are);
						CS$<>8__locals1.<>4__this.潮吹_大_人.描画0(are);
						CS$<>8__locals1.<>4__this.放尿_人.描画0(are);
					}
				};
				return;
			}
			if (this.Is粘)
			{
				this.Draw = delegate(Are are)
				{
					CS$<>8__locals1.<>4__this.染み_人.色更新();
					CS$<>8__locals1.<>4__this.染み_人.描画0(are);
					if (CS$<>8__locals1.<>4__this.Is胸)
					{
						CS$<>8__locals1.<>4__this.EI胸.描画(are);
					}
					if (CS$<>8__locals1.<>4__this.Is腰)
					{
						CS$<>8__locals1.<>4__this.EI腰.描画(are);
					}
					if (CS$<>8__locals1.<>4__this.Is頭頂_宇)
					{
						CS$<>8__locals1.<>4__this.頭頂後.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is髪)
					{
						CS$<>8__locals1.<>4__this.EI髪.描画(are);
					}
					if (CS$<>8__locals1.<>4__this.Is獣耳)
					{
						foreach (角2 角 in CS$<>8__locals1.<>4__this.角左接続)
						{
							角.根描画(are);
						}
						foreach (角2 角2 in CS$<>8__locals1.<>4__this.角右接続)
						{
							角2.根描画(are);
						}
					}
					CS$<>8__locals1.<>4__this.上着B_クロス後.描画0(are);
					if (CS$<>8__locals1.<>4__this.Is半後)
					{
						CS$<>8__locals1.<>4__this.EI半後.描画(are);
					}
					if (CS$<>8__locals1.<>4__this.Is蜘尾)
					{
						CS$<>8__locals1.<>4__this.出糸精液.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.cb0)
					{
						if (CS$<>8__locals1.<>4__this.カ\u30FCソル.IsSub糸挿入)
						{
							CS$<>8__locals1.<>4__this.カ\u30FCソル.描画糸(CS$<>8__locals1.Are);
						}
						else if (CS$<>8__locals1.<>4__this.カ\u30FCソル.Is糸挿入)
						{
							CS$<>8__locals1.<>4__this.カ\u30FCソル.描画2(CS$<>8__locals1.Are);
						}
					}
					CS$<>8__locals1.<>4__this.肩左飛膜.描画0(are);
					CS$<>8__locals1.<>4__this.肩右飛膜.描画0(are);
					if (CS$<>8__locals1.<>4__this.腕左右前後)
					{
						if (CS$<>8__locals1.<>4__this.腕右前後_)
						{
							CS$<>8__locals1.<>4__this.下腕以降右.描画0(are);
							CS$<>8__locals1.<>4__this.下腕以降右.描画1(are);
						}
						if (CS$<>8__locals1.<>4__this.腕左前後_)
						{
							CS$<>8__locals1.<>4__this.下腕以降左.描画0(are);
							CS$<>8__locals1.<>4__this.下腕以降左.描画1(are);
						}
					}
					else
					{
						if (CS$<>8__locals1.<>4__this.腕左前後_)
						{
							CS$<>8__locals1.<>4__this.下腕以降左.描画0(are);
							CS$<>8__locals1.<>4__this.下腕以降左.描画1(are);
						}
						if (CS$<>8__locals1.<>4__this.腕右前後_)
						{
							CS$<>8__locals1.<>4__this.下腕以降右.描画0(are);
							CS$<>8__locals1.<>4__this.下腕以降右.描画1(are);
						}
					}
					CS$<>8__locals1.<>4__this.耳左接続.描画0(are);
					CS$<>8__locals1.<>4__this.耳右接続.描画0(are);
					if (CS$<>8__locals1.<>4__this.肩左 != null)
					{
						CS$<>8__locals1.<>4__this.肩左.脇描画(are);
					}
					if (CS$<>8__locals1.<>4__this.肩右 != null)
					{
						CS$<>8__locals1.<>4__this.肩右.脇描画(are);
					}
					CS$<>8__locals1.<>4__this.腰.描画0(are);
					CS$<>8__locals1.<>4__this.腰.描画1(are);
					if (!Sta.GameData.断面)
					{
						CS$<>8__locals1.<>4__this.肛門_人.描画0(are);
						CS$<>8__locals1.<>4__this.肛門精液_人.描画0(are);
						if (CS$<>8__locals1.<>4__this.cb1)
						{
							CS$<>8__locals1.<>4__this.カ\u30FCソル.描画肛(are);
						}
						CS$<>8__locals1.<>4__this.膣基_人.描画0(are);
						if (CS$<>8__locals1.<>4__this.断面_表示 && CS$<>8__locals1.<>4__this.cb1)
						{
							CS$<>8__locals1.<>4__this.カ\u30FCソル.描画0(are);
						}
						CS$<>8__locals1.<>4__this.膣内精液_人.描画0(are);
						CS$<>8__locals1.<>4__this.断面_人.描画0(are);
					}
					CS$<>8__locals1.<>4__this.胴.描画0(are);
					CS$<>8__locals1.<>4__this.胸.描画0(are);
					CS$<>8__locals1.<>4__this.首.描画0(are);
					if (CS$<>8__locals1.<>4__this.肩左 != null)
					{
						CS$<>8__locals1.<>4__this.肩左.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.肩右 != null)
					{
						CS$<>8__locals1.<>4__this.肩右.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is半中1)
					{
						CS$<>8__locals1.<>4__this.EI半中1.描画(are);
					}
					if (CS$<>8__locals1.<>4__this.Is半中2)
					{
						CS$<>8__locals1.<>4__this.EI半中2.描画(are);
					}
					CS$<>8__locals1.<>4__this.ボテ腹_人.描画0(are);
					CS$<>8__locals1.<>4__this.ボテ腹板_人.描画0(are);
					CS$<>8__locals1.<>4__this.腰肌_人.描画0(are);
					CS$<>8__locals1.<>4__this.胴腹板_人.描画0(are);
					CS$<>8__locals1.<>4__this.胸腹板_人.描画0(are);
					CS$<>8__locals1.<>4__this.胴肌_人.描画0(are);
					CS$<>8__locals1.<>4__this.胸肌_人.描画0(are);
					CS$<>8__locals1.<>4__this.下着T_チュ\u30FCブ.描画0(are);
					CS$<>8__locals1.<>4__this.下着T_クロス.描画0(are);
					CS$<>8__locals1.<>4__this.下着T_ビキニ.描画0(are);
					CS$<>8__locals1.<>4__this.下着T_マイクロ.描画0(are);
					CS$<>8__locals1.<>4__this.下着T_ブラ.描画0(are);
					CS$<>8__locals1.<>4__this.腕左.描画0(are);
					CS$<>8__locals1.<>4__this.腕右.描画0(are);
					CS$<>8__locals1.<>4__this.腕左.描画1(are);
					CS$<>8__locals1.<>4__this.腕右.描画1(are);
					if (CS$<>8__locals1.<>4__this.胸左右前後)
					{
						CS$<>8__locals1.<>4__this.乳房右.描画0(are);
						CS$<>8__locals1.<>4__this.乳房左.描画0(are);
					}
					else
					{
						CS$<>8__locals1.<>4__this.乳房左.描画0(are);
						CS$<>8__locals1.<>4__this.乳房右.描画0(are);
					}
					CS$<>8__locals1.<>4__this.ピアス左.描画0(are);
					CS$<>8__locals1.<>4__this.ピアス右.描画0(are);
					CS$<>8__locals1.<>4__this.噴乳左.描画0(are);
					CS$<>8__locals1.<>4__this.噴乳右.描画0(are);
					CS$<>8__locals1.<>4__this.キャップ2左.描画0(are);
					CS$<>8__locals1.<>4__this.キャップ2右.描画0(are);
					CS$<>8__locals1.<>4__this.胸肌_人.描画1(are);
					if (CS$<>8__locals1.<>4__this.汗掻き != null)
					{
						CS$<>8__locals1.<>4__this.汗掻き.Draw(are);
					}
					CS$<>8__locals1.<>4__this.頭.描画0(are);
					if (CS$<>8__locals1.<>4__this.Is双眼 && !CS$<>8__locals1.<>4__this.Is瞼宇)
					{
						CS$<>8__locals1.<>4__this.目左.描画0(are);
						CS$<>8__locals1.<>4__this.瞼左.描画0(are);
						CS$<>8__locals1.<>4__this.目右.描画0(are);
						CS$<>8__locals1.<>4__this.瞼右.描画0(are);
					}
					CS$<>8__locals1.<>4__this.頭.描画1(are);
					if (CS$<>8__locals1.<>4__this.Is単眼)
					{
						CS$<>8__locals1.<>4__this.単眼目.描画0(are);
						CS$<>8__locals1.<>4__this.単眼瞼.描画0(are);
					}
					CS$<>8__locals1.<>4__this.紅潮.描画0(are);
					CS$<>8__locals1.<>4__this.鼻肌.描画0(are);
					CS$<>8__locals1.<>4__this.目尻影左.描画0(are);
					CS$<>8__locals1.<>4__this.目尻影右.描画0(are);
					CS$<>8__locals1.<>4__this.目傷左.描画0(are);
					CS$<>8__locals1.<>4__this.目傷右.描画0(are);
					CS$<>8__locals1.<>4__this.頬肌左.描画0(are);
					CS$<>8__locals1.<>4__this.頬肌右.描画0(are);
					if (CS$<>8__locals1.<>4__this.Is額眼)
					{
						CS$<>8__locals1.<>4__this.額目.描画0(are);
						CS$<>8__locals1.<>4__this.額瞼.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is頬眼)
					{
						CS$<>8__locals1.<>4__this.頬目左.描画0(are);
						CS$<>8__locals1.<>4__this.頬目右.描画0(are);
						CS$<>8__locals1.<>4__this.頬瞼左.描画0(are);
						CS$<>8__locals1.<>4__this.頬瞼右.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is瞼宇)
					{
						CS$<>8__locals1.<>4__this.瞼左.描画0(are);
						CS$<>8__locals1.<>4__this.瞼右.描画0(are);
					}
					CS$<>8__locals1.<>4__this.涎左.描画0(are);
					CS$<>8__locals1.<>4__this.涎右.描画0(are);
					CS$<>8__locals1.<>4__this.口.描画0(are);
					if (CS$<>8__locals1.<>4__this.鼻描画)
					{
						CS$<>8__locals1.<>4__this.鼻.描画0(are);
						CS$<>8__locals1.<>4__this.鼻水左.描画0(are);
						CS$<>8__locals1.<>4__this.鼻水右.描画0(are);
					}
					CS$<>8__locals1.<>4__this.頭.描画2(are);
					CS$<>8__locals1.<>4__this.玉口枷.描画0(are);
					CS$<>8__locals1.<>4__this.基髪.描画0(are);
					CS$<>8__locals1.<>4__this.横髪左.描画0(are);
					CS$<>8__locals1.<>4__this.横髪右.描画0(are);
					CS$<>8__locals1.<>4__this.頬左接続.描画0(are);
					CS$<>8__locals1.<>4__this.頬左接続.描画1(are);
					CS$<>8__locals1.<>4__this.頬右接続.描画0(are);
					CS$<>8__locals1.<>4__this.頬右接続.描画1(are);
					CS$<>8__locals1.<>4__this.頬肌左.描画1(are);
					CS$<>8__locals1.<>4__this.頬肌右.描画1(are);
					if (CS$<>8__locals1.<>4__this.涙描画)
					{
						CS$<>8__locals1.<>4__this.涙左.描画0(are);
						CS$<>8__locals1.<>4__this.涙右.描画0(are);
					}
					if (!CS$<>8__locals1.<>4__this.Is頭頂_宇 && !CS$<>8__locals1.<>4__this.Is顔面 && !CS$<>8__locals1.<>4__this.Is額角 && !CS$<>8__locals1.<>4__this.Is触覚)
					{
						CS$<>8__locals1.<>4__this.目隠帯.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is腕前 && !CS$<>8__locals1.<>4__this.Is最前腕人 && (!CS$<>8__locals1.<>4__this.腕左前後_ || !CS$<>8__locals1.<>4__this.腕右前後_))
					{
						CS$<>8__locals1.<>4__this.EI腕前.描画(are);
					}
					if (Sta.GameData.断面)
					{
						CS$<>8__locals1.<>4__this.肛門_人.描画0(are);
						CS$<>8__locals1.<>4__this.肛門精液_人.描画0(are);
						if (CS$<>8__locals1.<>4__this.cb1)
						{
							CS$<>8__locals1.<>4__this.カ\u30FCソル.描画肛(are);
						}
						CS$<>8__locals1.<>4__this.膣基_人.描画0(are);
						if (CS$<>8__locals1.<>4__this.断面_表示 && CS$<>8__locals1.<>4__this.cb1)
						{
							CS$<>8__locals1.<>4__this.カ\u30FCソル.描画0(are);
						}
						CS$<>8__locals1.<>4__this.膣内精液_人.描画0(are);
						CS$<>8__locals1.<>4__this.断面_人.描画0(are);
					}
					CS$<>8__locals1.<>4__this.性器_人.描画0(are);
					if (!CS$<>8__locals1.<>4__this.断面_表示 && CS$<>8__locals1.<>4__this.cb1)
					{
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画0(are);
					}
					CS$<>8__locals1.<>4__this.ピアス.描画0(are);
					CS$<>8__locals1.<>4__this.下着T_チュ\u30FCブ.描画1(are);
					CS$<>8__locals1.<>4__this.下着T_クロス.描画1(are);
					CS$<>8__locals1.<>4__this.下着T_ビキニ.描画1(are);
					CS$<>8__locals1.<>4__this.下着T_マイクロ.描画1(are);
					CS$<>8__locals1.<>4__this.下着T_ブラ.描画1(are);
					CS$<>8__locals1.<>4__this.下着乳首左.描画0(are);
					CS$<>8__locals1.<>4__this.下着乳首右.描画0(are);
					CS$<>8__locals1.<>4__this.キャップ1.描画0(are);
					CS$<>8__locals1.<>4__this.下着B_ノ\u30FCマル.描画0(are);
					CS$<>8__locals1.<>4__this.下着B_マイクロ.描画0(are);
					CS$<>8__locals1.<>4__this.下着B_ノ\u30FCマル.描画1(are);
					CS$<>8__locals1.<>4__this.下着B_マイクロ.描画1(are);
					CS$<>8__locals1.<>4__this.下着陰核.描画0(are);
					CS$<>8__locals1.<>4__this.上着M_ドレス.描画0(are);
					CS$<>8__locals1.<>4__this.上着T_ドレス.描画0(are);
					CS$<>8__locals1.<>4__this.上着B_前掛け.描画0(are);
					CS$<>8__locals1.<>4__this.EI腿.描画(are);
					if (CS$<>8__locals1.<>4__this.胸毛_人 != null)
					{
						CS$<>8__locals1.<>4__this.胸毛_人.描画0(are);
					}
					CS$<>8__locals1.<>4__this.舌.描画0(are);
					CS$<>8__locals1.<>4__this.口精液.描画0(are);
					CS$<>8__locals1.<>4__this.咳.描画0(are);
					CS$<>8__locals1.<>4__this.呼気.描画0(are);
					if (CS$<>8__locals1.<>4__this.cb0 && CS$<>8__locals1.<>4__this.カ\u30FCソル.コキ)
					{
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画0(are);
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画1(are);
					}
					CS$<>8__locals1.<>4__this.前髪.描画0(are);
					if (!CS$<>8__locals1.<>4__this.Is獣耳)
					{
						foreach (角2 角3 in CS$<>8__locals1.<>4__this.角左接続)
						{
							角3.根描画(are);
						}
						foreach (角2 角4 in CS$<>8__locals1.<>4__this.角右接続)
						{
							角4.根描画(are);
						}
					}
					if (CS$<>8__locals1.<>4__this.Is単眉)
					{
						CS$<>8__locals1.<>4__this.単眼眉.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is双眉)
					{
						CS$<>8__locals1.<>4__this.眉左.描画0(are);
						CS$<>8__locals1.<>4__this.眉右.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is頭頂_宇)
					{
						CS$<>8__locals1.<>4__this.大顎基接続.描画0(are);
						CS$<>8__locals1.<>4__this.大顎基接続.描画1(are);
						if (CS$<>8__locals1.<>4__this.Is顔面)
						{
							CS$<>8__locals1.<>4__this.顔面.描画0(are);
						}
						if (CS$<>8__locals1.<>4__this.Is頭頂)
						{
							CS$<>8__locals1.<>4__this.頭頂.描画0(are);
						}
						if (CS$<>8__locals1.<>4__this.Is獣耳)
						{
							CS$<>8__locals1.<>4__this.獣耳左.描画0(are);
							CS$<>8__locals1.<>4__this.獣耳右.描画0(are);
						}
						CS$<>8__locals1.<>4__this.植左接続.描画0(are);
						CS$<>8__locals1.<>4__this.植右接続.描画0(are);
						foreach (角2 角5 in CS$<>8__locals1.<>4__this.角左接続)
						{
							角5.先描画(are);
						}
						foreach (角2 角6 in CS$<>8__locals1.<>4__this.角右接続)
						{
							角6.先描画(are);
						}
						CS$<>8__locals1.<>4__this.額接続.描画0(are);
						CS$<>8__locals1.<>4__this.額接続.描画1(are);
						CS$<>8__locals1.<>4__this.触覚左接続.描画0(are);
						CS$<>8__locals1.<>4__this.触覚左接続.描画1(are);
						CS$<>8__locals1.<>4__this.触覚右接続.描画0(are);
						CS$<>8__locals1.<>4__this.触覚右接続.描画1(are);
					}
					else
					{
						if (CS$<>8__locals1.<>4__this.Is獣耳)
						{
							CS$<>8__locals1.<>4__this.獣耳左.描画0(are);
							CS$<>8__locals1.<>4__this.獣耳右.描画0(are);
						}
						if (CS$<>8__locals1.<>4__this.Is頭頂)
						{
							CS$<>8__locals1.<>4__this.頭頂.描画0(are);
						}
						CS$<>8__locals1.<>4__this.植左接続.描画0(are);
						CS$<>8__locals1.<>4__this.植右接続.描画0(are);
						foreach (角2 角7 in CS$<>8__locals1.<>4__this.角左接続)
						{
							角7.先描画(are);
						}
						foreach (角2 角8 in CS$<>8__locals1.<>4__this.角右接続)
						{
							角8.先描画(are);
						}
						if (CS$<>8__locals1.<>4__this.Is虫角前)
						{
							CS$<>8__locals1.<>4__this.触覚左接続.描画0(are);
							CS$<>8__locals1.<>4__this.触覚左接続.描画1(are);
							CS$<>8__locals1.<>4__this.触覚右接続.描画0(are);
							CS$<>8__locals1.<>4__this.触覚右接続.描画1(are);
							CS$<>8__locals1.<>4__this.大顎基接続.描画0(are);
							CS$<>8__locals1.<>4__this.大顎基接続.描画1(are);
							if (CS$<>8__locals1.<>4__this.Is顔面)
							{
								CS$<>8__locals1.<>4__this.顔面.描画0(are);
							}
							CS$<>8__locals1.<>4__this.額接続.描画0(are);
							CS$<>8__locals1.<>4__this.額接続.描画1(are);
						}
						else
						{
							CS$<>8__locals1.<>4__this.額接続.描画0(are);
							CS$<>8__locals1.<>4__this.額接続.描画1(are);
							CS$<>8__locals1.<>4__this.触覚左接続.描画0(are);
							CS$<>8__locals1.<>4__this.触覚左接続.描画1(are);
							CS$<>8__locals1.<>4__this.触覚右接続.描画0(are);
							CS$<>8__locals1.<>4__this.触覚右接続.描画1(are);
							CS$<>8__locals1.<>4__this.大顎基接続.描画0(are);
							CS$<>8__locals1.<>4__this.大顎基接続.描画1(are);
							if (CS$<>8__locals1.<>4__this.Is顔面)
							{
								CS$<>8__locals1.<>4__this.顔面.描画0(are);
							}
						}
					}
					CS$<>8__locals1.<>4__this.顔触覚左接続.描画0(are);
					CS$<>8__locals1.<>4__this.顔触覚左接続.描画1(are);
					CS$<>8__locals1.<>4__this.顔触覚右接続.描画0(are);
					CS$<>8__locals1.<>4__this.顔触覚右接続.描画1(are);
					if (CS$<>8__locals1.<>4__this.Is頭頂_宇 || CS$<>8__locals1.<>4__this.Is顔面 || CS$<>8__locals1.<>4__this.Is額角 || CS$<>8__locals1.<>4__this.Is触覚)
					{
						CS$<>8__locals1.<>4__this.目隠帯.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.cb0 && !(CS$<>8__locals1.<>4__this.fi = CS$<>8__locals1.<>4__this.カ\u30FCソル.Isフォ\u30FCカス膣肛挿入))
					{
						CS$<>8__locals1.<>4__this.性器精液_人.描画0(are);
						CS$<>8__locals1.<>4__this.飛沫_人.描画0(are);
						CS$<>8__locals1.<>4__this.潮吹_小_人.描画0(are);
						CS$<>8__locals1.<>4__this.潮吹_大_人.描画0(are);
						CS$<>8__locals1.<>4__this.放尿_人.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is腕前 && CS$<>8__locals1.<>4__this.Is最前腕人 && (!CS$<>8__locals1.<>4__this.腕左前後_ || !CS$<>8__locals1.<>4__this.腕右前後_))
					{
						CS$<>8__locals1.<>4__this.EI腕前.描画(are);
					}
					CS$<>8__locals1.<>4__this.上着B_クロス.描画0(are);
					if (CS$<>8__locals1.<>4__this.Is半前)
					{
						CS$<>8__locals1.<>4__this.EI半前.描画(are);
					}
					CS$<>8__locals1.<>4__this.染み_人.湯気描画(are);
					if (CS$<>8__locals1.<>4__this.cb0 && CS$<>8__locals1.<>4__this.カ\u30FCソル.Is乳弄り)
					{
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画2(CS$<>8__locals1.Are);
					}
					CS$<>8__locals1.<>4__this.上着B_前掛け.前(are);
					CS$<>8__locals1.<>4__this.ぶっかけ大.Draw(are);
					CS$<>8__locals1.<>4__this.ぶっかけ小.Draw(are);
					if (CS$<>8__locals1.<>4__this.cb1)
					{
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画1(are);
					}
					if (CS$<>8__locals1.<>4__this.cb0 && CS$<>8__locals1.<>4__this.fi)
					{
						CS$<>8__locals1.<>4__this.性器精液_人.描画0(are);
						CS$<>8__locals1.<>4__this.飛沫_人.描画0(are);
						CS$<>8__locals1.<>4__this.潮吹_小_人.描画0(are);
						CS$<>8__locals1.<>4__this.潮吹_大_人.描画0(are);
						CS$<>8__locals1.<>4__this.放尿_人.描画0(are);
					}
				};
				return;
			}
			this.Draw = delegate(Are are)
			{
				CS$<>8__locals1.<>4__this.cb0 = (CS$<>8__locals1.<>4__this.カ\u30FCソル != null);
				CS$<>8__locals1.<>4__this.cb1 = (CS$<>8__locals1.<>4__this.cb0 && !CS$<>8__locals1.<>4__this.カ\u30FCソル.コキ);
				CS$<>8__locals1.<>4__this.染み_人.色更新();
				CS$<>8__locals1.<>4__this.染み_人.描画0(are);
				if (CS$<>8__locals1.<>4__this.Is胸)
				{
					CS$<>8__locals1.<>4__this.EI胸.描画(are);
				}
				if (CS$<>8__locals1.<>4__this.Is腰)
				{
					CS$<>8__locals1.<>4__this.EI腰.描画(are);
				}
				if (CS$<>8__locals1.<>4__this.Is頭頂_宇)
				{
					CS$<>8__locals1.<>4__this.頭頂後.描画0(are);
				}
				if (CS$<>8__locals1.<>4__this.Is髪)
				{
					CS$<>8__locals1.<>4__this.EI髪.描画(are);
				}
				if (CS$<>8__locals1.<>4__this.Is獣耳)
				{
					foreach (角2 角 in CS$<>8__locals1.<>4__this.角左接続)
					{
						角.根描画(are);
					}
					foreach (角2 角2 in CS$<>8__locals1.<>4__this.角右接続)
					{
						角2.根描画(are);
					}
				}
				CS$<>8__locals1.<>4__this.肩左飛膜.描画0(are);
				CS$<>8__locals1.<>4__this.肩右飛膜.描画0(are);
				if (CS$<>8__locals1.<>4__this.腕左右前後)
				{
					if (CS$<>8__locals1.<>4__this.腕右前後_)
					{
						CS$<>8__locals1.<>4__this.下腕以降右.描画0(are);
						CS$<>8__locals1.<>4__this.下腕以降右.描画1(are);
					}
					if (CS$<>8__locals1.<>4__this.腕左前後_)
					{
						CS$<>8__locals1.<>4__this.下腕以降左.描画0(are);
						CS$<>8__locals1.<>4__this.下腕以降左.描画1(are);
					}
				}
				else
				{
					if (CS$<>8__locals1.<>4__this.腕左前後_)
					{
						CS$<>8__locals1.<>4__this.下腕以降左.描画0(are);
						CS$<>8__locals1.<>4__this.下腕以降左.描画1(are);
					}
					if (CS$<>8__locals1.<>4__this.腕右前後_)
					{
						CS$<>8__locals1.<>4__this.下腕以降右.描画0(are);
						CS$<>8__locals1.<>4__this.下腕以降右.描画1(are);
					}
				}
				CS$<>8__locals1.<>4__this.上着B_クロス後.描画0(are);
				if (CS$<>8__locals1.<>4__this.Is半後)
				{
					CS$<>8__locals1.<>4__this.EI半後.描画(are);
				}
				if (CS$<>8__locals1.<>4__this.Is蜘尾)
				{
					CS$<>8__locals1.<>4__this.出糸精液.描画0(are);
				}
				if (CS$<>8__locals1.<>4__this.cb0)
				{
					if (CS$<>8__locals1.<>4__this.カ\u30FCソル.IsSub糸挿入)
					{
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画糸(CS$<>8__locals1.Are);
					}
					else if (CS$<>8__locals1.<>4__this.カ\u30FCソル.Is糸挿入)
					{
						CS$<>8__locals1.<>4__this.カ\u30FCソル.描画2(CS$<>8__locals1.Are);
					}
				}
				CS$<>8__locals1.<>4__this.耳左接続.描画0(are);
				CS$<>8__locals1.<>4__this.耳右接続.描画0(are);
				if (CS$<>8__locals1.<>4__this.肩左 != null)
				{
					CS$<>8__locals1.<>4__this.肩左.脇描画(are);
				}
				if (CS$<>8__locals1.<>4__this.肩右 != null)
				{
					CS$<>8__locals1.<>4__this.肩右.脇描画(are);
				}
				CS$<>8__locals1.<>4__this.腰.描画0(are);
				CS$<>8__locals1.<>4__this.腰.描画1(are);
				CS$<>8__locals1.<>4__this.胴.描画0(are);
				CS$<>8__locals1.<>4__this.胸.描画0(are);
				CS$<>8__locals1.<>4__this.首.描画0(are);
				if (CS$<>8__locals1.<>4__this.肩左 != null)
				{
					CS$<>8__locals1.<>4__this.肩左.描画0(are);
				}
				if (CS$<>8__locals1.<>4__this.肩右 != null)
				{
					CS$<>8__locals1.<>4__this.肩右.描画0(are);
				}
				if (CS$<>8__locals1.<>4__this.Is半中1)
				{
					CS$<>8__locals1.<>4__this.EI半中1.描画(are);
				}
				if (CS$<>8__locals1.<>4__this.Is半中2)
				{
					CS$<>8__locals1.<>4__this.EI半中2.描画(are);
				}
				CS$<>8__locals1.<>4__this.ボテ腹_人.描画0(are);
				CS$<>8__locals1.<>4__this.ボテ腹板_人.描画0(are);
				CS$<>8__locals1.<>4__this.腰肌_人.描画0(are);
				CS$<>8__locals1.<>4__this.胴腹板_人.描画0(are);
				CS$<>8__locals1.<>4__this.胸腹板_人.描画0(are);
				CS$<>8__locals1.<>4__this.胴肌_人.描画0(are);
				CS$<>8__locals1.<>4__this.胸肌_人.描画0(are);
				CS$<>8__locals1.<>4__this.下着T_チュ\u30FCブ.描画0(are);
				CS$<>8__locals1.<>4__this.下着T_クロス.描画0(are);
				CS$<>8__locals1.<>4__this.下着T_ビキニ.描画0(are);
				CS$<>8__locals1.<>4__this.下着T_マイクロ.描画0(are);
				CS$<>8__locals1.<>4__this.下着T_ブラ.描画0(are);
				CS$<>8__locals1.<>4__this.腕左.描画0(are);
				CS$<>8__locals1.<>4__this.腕右.描画0(are);
				CS$<>8__locals1.<>4__this.腕左.描画1(are);
				CS$<>8__locals1.<>4__this.腕右.描画1(are);
				if (CS$<>8__locals1.<>4__this.胸左右前後)
				{
					CS$<>8__locals1.<>4__this.乳房右.描画0(are);
					CS$<>8__locals1.<>4__this.乳房左.描画0(are);
				}
				else
				{
					CS$<>8__locals1.<>4__this.乳房左.描画0(are);
					CS$<>8__locals1.<>4__this.乳房右.描画0(are);
				}
				CS$<>8__locals1.<>4__this.ピアス左.描画0(are);
				CS$<>8__locals1.<>4__this.ピアス右.描画0(are);
				CS$<>8__locals1.<>4__this.噴乳左.描画0(are);
				CS$<>8__locals1.<>4__this.噴乳右.描画0(are);
				CS$<>8__locals1.<>4__this.キャップ2左.描画0(are);
				CS$<>8__locals1.<>4__this.キャップ2右.描画0(are);
				CS$<>8__locals1.<>4__this.胸肌_人.描画1(are);
				if (CS$<>8__locals1.<>4__this.汗掻き != null)
				{
					CS$<>8__locals1.<>4__this.汗掻き.Draw(are);
				}
				CS$<>8__locals1.<>4__this.頭.描画0(are);
				if (CS$<>8__locals1.<>4__this.Is双眼 && !CS$<>8__locals1.<>4__this.Is瞼宇)
				{
					CS$<>8__locals1.<>4__this.目左.描画0(are);
					CS$<>8__locals1.<>4__this.瞼左.描画0(are);
					CS$<>8__locals1.<>4__this.目右.描画0(are);
					CS$<>8__locals1.<>4__this.瞼右.描画0(are);
				}
				CS$<>8__locals1.<>4__this.頭.描画1(are);
				if (CS$<>8__locals1.<>4__this.Is単眼)
				{
					CS$<>8__locals1.<>4__this.単眼目.描画0(are);
					CS$<>8__locals1.<>4__this.単眼瞼.描画0(are);
				}
				CS$<>8__locals1.<>4__this.紅潮.描画0(are);
				CS$<>8__locals1.<>4__this.鼻肌.描画0(are);
				CS$<>8__locals1.<>4__this.目尻影左.描画0(are);
				CS$<>8__locals1.<>4__this.目尻影右.描画0(are);
				CS$<>8__locals1.<>4__this.目傷左.描画0(are);
				CS$<>8__locals1.<>4__this.目傷右.描画0(are);
				CS$<>8__locals1.<>4__this.頬肌左.描画0(are);
				CS$<>8__locals1.<>4__this.頬肌右.描画0(are);
				if (CS$<>8__locals1.<>4__this.Is額眼)
				{
					CS$<>8__locals1.<>4__this.額目.描画0(are);
					CS$<>8__locals1.<>4__this.額瞼.描画0(are);
				}
				if (CS$<>8__locals1.<>4__this.Is頬眼)
				{
					CS$<>8__locals1.<>4__this.頬目左.描画0(are);
					CS$<>8__locals1.<>4__this.頬目右.描画0(are);
					CS$<>8__locals1.<>4__this.頬瞼左.描画0(are);
					CS$<>8__locals1.<>4__this.頬瞼右.描画0(are);
				}
				if (CS$<>8__locals1.<>4__this.Is瞼宇)
				{
					CS$<>8__locals1.<>4__this.瞼左.描画0(are);
					CS$<>8__locals1.<>4__this.瞼右.描画0(are);
				}
				CS$<>8__locals1.<>4__this.涎左.描画0(are);
				CS$<>8__locals1.<>4__this.涎右.描画0(are);
				CS$<>8__locals1.<>4__this.口.描画0(are);
				if (CS$<>8__locals1.<>4__this.鼻描画)
				{
					CS$<>8__locals1.<>4__this.鼻.描画0(are);
					CS$<>8__locals1.<>4__this.鼻水左.描画0(are);
					CS$<>8__locals1.<>4__this.鼻水右.描画0(are);
				}
				CS$<>8__locals1.<>4__this.頭.描画2(are);
				CS$<>8__locals1.<>4__this.玉口枷.描画0(are);
				CS$<>8__locals1.<>4__this.基髪.描画0(are);
				CS$<>8__locals1.<>4__this.横髪左.描画0(are);
				CS$<>8__locals1.<>4__this.横髪右.描画0(are);
				CS$<>8__locals1.<>4__this.頬左接続.描画0(are);
				CS$<>8__locals1.<>4__this.頬左接続.描画1(are);
				CS$<>8__locals1.<>4__this.頬右接続.描画0(are);
				CS$<>8__locals1.<>4__this.頬右接続.描画1(are);
				CS$<>8__locals1.<>4__this.頬肌左.描画1(are);
				CS$<>8__locals1.<>4__this.頬肌右.描画1(are);
				if (CS$<>8__locals1.<>4__this.涙描画)
				{
					CS$<>8__locals1.<>4__this.涙左.描画0(are);
					CS$<>8__locals1.<>4__this.涙右.描画0(are);
				}
				if (!CS$<>8__locals1.<>4__this.Is頭頂_宇 && !CS$<>8__locals1.<>4__this.Is顔面 && !CS$<>8__locals1.<>4__this.Is額角 && !CS$<>8__locals1.<>4__this.Is触覚)
				{
					CS$<>8__locals1.<>4__this.目隠帯.描画0(are);
				}
				if (CS$<>8__locals1.<>4__this.Is腕前 && !CS$<>8__locals1.<>4__this.Is最前腕人 && (!CS$<>8__locals1.<>4__this.腕左前後_ || !CS$<>8__locals1.<>4__this.腕右前後_))
				{
					CS$<>8__locals1.<>4__this.EI腕前.描画(are);
				}
				if (CS$<>8__locals1.<>4__this.Is腿魚 && CS$<>8__locals1.<>4__this.Is腿)
				{
					CS$<>8__locals1.<>4__this.EI腿.描画(are);
				}
				CS$<>8__locals1.<>4__this.肛門_人.描画0(are);
				CS$<>8__locals1.<>4__this.肛門精液_人.描画0(are);
				if (CS$<>8__locals1.<>4__this.cb1)
				{
					CS$<>8__locals1.<>4__this.カ\u30FCソル.描画肛(are);
				}
				CS$<>8__locals1.<>4__this.膣基_人.描画0(are);
				if (CS$<>8__locals1.<>4__this.断面_表示 && CS$<>8__locals1.<>4__this.cb1)
				{
					CS$<>8__locals1.<>4__this.カ\u30FCソル.描画0(are);
				}
				CS$<>8__locals1.<>4__this.膣内精液_人.描画0(are);
				CS$<>8__locals1.<>4__this.断面_人.描画0(are);
				CS$<>8__locals1.<>4__this.性器_人.描画0(are);
				if (!CS$<>8__locals1.<>4__this.断面_表示 && CS$<>8__locals1.<>4__this.cb1)
				{
					CS$<>8__locals1.<>4__this.カ\u30FCソル.描画0(are);
				}
				CS$<>8__locals1.<>4__this.ピアス.描画0(are);
				CS$<>8__locals1.<>4__this.下着T_チュ\u30FCブ.描画1(are);
				CS$<>8__locals1.<>4__this.下着T_クロス.描画1(are);
				CS$<>8__locals1.<>4__this.下着T_ビキニ.描画1(are);
				CS$<>8__locals1.<>4__this.下着T_マイクロ.描画1(are);
				CS$<>8__locals1.<>4__this.下着T_ブラ.描画1(are);
				CS$<>8__locals1.<>4__this.下着乳首左.描画0(are);
				CS$<>8__locals1.<>4__this.下着乳首右.描画0(are);
				CS$<>8__locals1.<>4__this.キャップ1.描画0(are);
				CS$<>8__locals1.<>4__this.下着B_ノ\u30FCマル.描画0(are);
				CS$<>8__locals1.<>4__this.下着B_マイクロ.描画0(are);
				CS$<>8__locals1.<>4__this.下着B_ノ\u30FCマル.描画1(are);
				CS$<>8__locals1.<>4__this.下着B_マイクロ.描画1(are);
				CS$<>8__locals1.<>4__this.下着陰核.描画0(are);
				CS$<>8__locals1.<>4__this.上着M_ドレス.描画0(are);
				CS$<>8__locals1.<>4__this.上着T_ドレス.描画0(are);
				if (!CS$<>8__locals1.<>4__this.Is腿人)
				{
					CS$<>8__locals1.<>4__this.上着B_前掛け.描画0(are);
					CS$<>8__locals1.<>4__this.上着B_クロス.描画0(are);
				}
				if (CS$<>8__locals1.<>4__this.Is腿人)
				{
					CS$<>8__locals1.<>4__this.上着B_前掛け.描画0(are);
				}
				if (CS$<>8__locals1.<>4__this.胸毛_人 != null)
				{
					CS$<>8__locals1.<>4__this.胸毛_人.描画0(are);
				}
				CS$<>8__locals1.<>4__this.舌.描画0(are);
				CS$<>8__locals1.<>4__this.口精液.描画0(are);
				CS$<>8__locals1.<>4__this.咳.描画0(are);
				CS$<>8__locals1.<>4__this.呼気.描画0(are);
				if (CS$<>8__locals1.<>4__this.cb0 && CS$<>8__locals1.<>4__this.カ\u30FCソル.コキ)
				{
					CS$<>8__locals1.<>4__this.カ\u30FCソル.描画0(are);
					CS$<>8__locals1.<>4__this.カ\u30FCソル.描画1(are);
				}
				CS$<>8__locals1.<>4__this.前髪.描画0(are);
				if (!CS$<>8__locals1.<>4__this.Is獣耳)
				{
					foreach (角2 角3 in CS$<>8__locals1.<>4__this.角左接続)
					{
						角3.根描画(are);
					}
					foreach (角2 角4 in CS$<>8__locals1.<>4__this.角右接続)
					{
						角4.根描画(are);
					}
				}
				if (CS$<>8__locals1.<>4__this.Is単眉)
				{
					CS$<>8__locals1.<>4__this.単眼眉.描画0(are);
				}
				if (CS$<>8__locals1.<>4__this.Is双眉)
				{
					CS$<>8__locals1.<>4__this.眉左.描画0(are);
					CS$<>8__locals1.<>4__this.眉右.描画0(are);
				}
				if (CS$<>8__locals1.<>4__this.Is頭頂_宇)
				{
					CS$<>8__locals1.<>4__this.大顎基接続.描画0(are);
					CS$<>8__locals1.<>4__this.大顎基接続.描画1(are);
					if (CS$<>8__locals1.<>4__this.Is顔面)
					{
						CS$<>8__locals1.<>4__this.顔面.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is頭頂)
					{
						CS$<>8__locals1.<>4__this.頭頂.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is獣耳)
					{
						CS$<>8__locals1.<>4__this.獣耳左.描画0(are);
						CS$<>8__locals1.<>4__this.獣耳右.描画0(are);
					}
					CS$<>8__locals1.<>4__this.植左接続.描画0(are);
					CS$<>8__locals1.<>4__this.植右接続.描画0(are);
					foreach (角2 角5 in CS$<>8__locals1.<>4__this.角左接続)
					{
						角5.先描画(are);
					}
					foreach (角2 角6 in CS$<>8__locals1.<>4__this.角右接続)
					{
						角6.先描画(are);
					}
					CS$<>8__locals1.<>4__this.額接続.描画0(are);
					CS$<>8__locals1.<>4__this.額接続.描画1(are);
					CS$<>8__locals1.<>4__this.触覚左接続.描画0(are);
					CS$<>8__locals1.<>4__this.触覚左接続.描画1(are);
					CS$<>8__locals1.<>4__this.触覚右接続.描画0(are);
					CS$<>8__locals1.<>4__this.触覚右接続.描画1(are);
				}
				else
				{
					if (CS$<>8__locals1.<>4__this.Is獣耳)
					{
						CS$<>8__locals1.<>4__this.獣耳左.描画0(are);
						CS$<>8__locals1.<>4__this.獣耳右.描画0(are);
					}
					if (CS$<>8__locals1.<>4__this.Is頭頂)
					{
						CS$<>8__locals1.<>4__this.頭頂.描画0(are);
					}
					CS$<>8__locals1.<>4__this.植左接続.描画0(are);
					CS$<>8__locals1.<>4__this.植右接続.描画0(are);
					foreach (角2 角7 in CS$<>8__locals1.<>4__this.角左接続)
					{
						角7.先描画(are);
					}
					foreach (角2 角8 in CS$<>8__locals1.<>4__this.角右接続)
					{
						角8.先描画(are);
					}
					if (CS$<>8__locals1.<>4__this.Is虫角前)
					{
						CS$<>8__locals1.<>4__this.触覚左接続.描画0(are);
						CS$<>8__locals1.<>4__this.触覚左接続.描画1(are);
						CS$<>8__locals1.<>4__this.触覚右接続.描画0(are);
						CS$<>8__locals1.<>4__this.触覚右接続.描画1(are);
						CS$<>8__locals1.<>4__this.大顎基接続.描画0(are);
						CS$<>8__locals1.<>4__this.大顎基接続.描画1(are);
						if (CS$<>8__locals1.<>4__this.Is顔面)
						{
							CS$<>8__locals1.<>4__this.顔面.描画0(are);
						}
						CS$<>8__locals1.<>4__this.額接続.描画0(are);
						CS$<>8__locals1.<>4__this.額接続.描画1(are);
					}
					else
					{
						CS$<>8__locals1.<>4__this.額接続.描画0(are);
						CS$<>8__locals1.<>4__this.額接続.描画1(are);
						CS$<>8__locals1.<>4__this.触覚左接続.描画0(are);
						CS$<>8__locals1.<>4__this.触覚左接続.描画1(are);
						CS$<>8__locals1.<>4__this.触覚右接続.描画0(are);
						CS$<>8__locals1.<>4__this.触覚右接続.描画1(are);
						CS$<>8__locals1.<>4__this.大顎基接続.描画0(are);
						CS$<>8__locals1.<>4__this.大顎基接続.描画1(are);
						if (CS$<>8__locals1.<>4__this.Is顔面)
						{
							CS$<>8__locals1.<>4__this.顔面.描画0(are);
						}
					}
				}
				CS$<>8__locals1.<>4__this.顔触覚左接続.描画0(are);
				CS$<>8__locals1.<>4__this.顔触覚左接続.描画1(are);
				CS$<>8__locals1.<>4__this.顔触覚右接続.描画0(are);
				CS$<>8__locals1.<>4__this.顔触覚右接続.描画1(are);
				if (CS$<>8__locals1.<>4__this.Is頭頂_宇 || CS$<>8__locals1.<>4__this.Is顔面 || CS$<>8__locals1.<>4__this.Is額角 || CS$<>8__locals1.<>4__this.Is触覚)
				{
					CS$<>8__locals1.<>4__this.目隠帯.描画0(are);
				}
				if (!CS$<>8__locals1.<>4__this.Is腿魚 && CS$<>8__locals1.<>4__this.Is腿 && CS$<>8__locals1.<>4__this.腿開きi != 4)
				{
					CS$<>8__locals1.<>4__this.EI腿.描画(are);
				}
				if (CS$<>8__locals1.<>4__this.Is腕前 && CS$<>8__locals1.<>4__this.Is最前腕人 && (!CS$<>8__locals1.<>4__this.腕左前後_ || !CS$<>8__locals1.<>4__this.腕右前後_))
				{
					CS$<>8__locals1.<>4__this.EI腕前.描画(are);
				}
				if (!CS$<>8__locals1.<>4__this.Is腿魚 && CS$<>8__locals1.<>4__this.Is腿 && CS$<>8__locals1.<>4__this.腿開きi == 4)
				{
					CS$<>8__locals1.<>4__this.EI腿.描画(are);
				}
				if (CS$<>8__locals1.<>4__this.cb0 && !(CS$<>8__locals1.<>4__this.fi = CS$<>8__locals1.<>4__this.カ\u30FCソル.Isフォ\u30FCカス膣肛挿入))
				{
					CS$<>8__locals1.<>4__this.性器精液_人.描画0(are);
					CS$<>8__locals1.<>4__this.飛沫_人.描画0(are);
					CS$<>8__locals1.<>4__this.潮吹_小_人.描画0(are);
					CS$<>8__locals1.<>4__this.潮吹_大_人.描画0(are);
					CS$<>8__locals1.<>4__this.放尿_人.描画0(are);
				}
				if (CS$<>8__locals1.<>4__this.Is腿人)
				{
					CS$<>8__locals1.<>4__this.上着B_クロス.描画0(are);
				}
				if (CS$<>8__locals1.<>4__this.Is半前)
				{
					CS$<>8__locals1.<>4__this.EI半前.描画(are);
				}
				CS$<>8__locals1.<>4__this.染み_人.湯気描画(are);
				if (CS$<>8__locals1.<>4__this.cb0 && CS$<>8__locals1.<>4__this.カ\u30FCソル.Is乳弄り)
				{
					CS$<>8__locals1.<>4__this.カ\u30FCソル.描画2(CS$<>8__locals1.Are);
				}
				CS$<>8__locals1.<>4__this.上着B_前掛け.前(are);
				CS$<>8__locals1.<>4__this.ぶっかけ大.Draw(are);
				CS$<>8__locals1.<>4__this.ぶっかけ小.Draw(are);
				if (CS$<>8__locals1.<>4__this.cb1)
				{
					CS$<>8__locals1.<>4__this.カ\u30FCソル.描画1(are);
				}
				if (CS$<>8__locals1.<>4__this.cb0 && CS$<>8__locals1.<>4__this.fi)
				{
					CS$<>8__locals1.<>4__this.性器精液_人.描画0(are);
					CS$<>8__locals1.<>4__this.飛沫_人.描画0(are);
					CS$<>8__locals1.<>4__this.潮吹_小_人.描画0(are);
					CS$<>8__locals1.<>4__this.潮吹_大_人.描画0(are);
					CS$<>8__locals1.<>4__this.放尿_人.描画0(are);
				}
			};
		}

		public void 変動ステ\u30FCト更新()
		{
			this.Cha.ChaD.現乳首 = this.Cha.ChaD.部位感度[接触.乳];
			this.Cha.ChaD.現陰核 = this.Cha.ChaD.部位感度[接触.核];
			this.Cha.ChaD.現性器 = this.Cha.ChaD.部位感度[接触.膣].Max(this.Cha.ChaD.部位感度[接触.性]);
			this.Cha.ChaD.現肛門 = this.Cha.ChaD.部位感度[接触.肛];
			double バスト = (this.Cha.ChaD.最乳房 - 0.3 * this.Cha.ChaD.現乳房.Inverse()).LimitM(0.0, 1.0);
			this.乳房左.バスト = バスト;
			this.乳房右.バスト = バスト;
			this.下着乳首左.バスト = バスト;
			this.下着乳首右.バスト = バスト;
			this.下着T_チュ\u30FCブ.バスト = バスト;
			this.下着T_クロス.バスト = バスト;
			this.下着T_ビキニ.バスト = バスト;
			this.下着T_マイクロ.バスト = バスト;
			this.下着T_ブラ.バスト = バスト;
			this.上着T_ドレス.バスト = バスト;
			double num = 0.65 * this.Cha.ChaD.最乳首 * this.Cha.ChaD.現乳首;
			this.乳房左.X0Y0_乳首.SizeBase = this.nsb1 + num;
			this.乳房左.X0Y0_乳輪.SizeBase = this.nsb2 + num;
			this.乳房左.X0Y1_乳首.SizeBase = this.nsb1 + num;
			this.乳房左.X0Y1_乳輪.SizeBase = this.nsb2 + num;
			this.乳房左.X0Y2_乳首.SizeBase = this.nsb1 + num;
			this.乳房左.X0Y2_乳輪.SizeBase = this.nsb2 + num;
			this.乳房左.X0Y3_乳首.SizeBase = this.nsb1 + num;
			this.乳房左.X0Y3_乳輪.SizeBase = this.nsb2 + num;
			this.乳房左.X0Y4_乳首.SizeBase = this.nsb1 + num;
			this.乳房左.X0Y4_乳輪.SizeBase = this.nsb2 + num;
			this.乳房右.X0Y0_乳首.SizeBase = this.nsb1 + num;
			this.乳房右.X0Y0_乳輪.SizeBase = this.nsb2 + num;
			this.乳房右.X0Y1_乳首.SizeBase = this.nsb1 + num;
			this.乳房右.X0Y1_乳輪.SizeBase = this.nsb2 + num;
			this.乳房右.X0Y2_乳首.SizeBase = this.nsb1 + num;
			this.乳房右.X0Y2_乳輪.SizeBase = this.nsb2 + num;
			this.乳房右.X0Y3_乳首.SizeBase = this.nsb1 + num;
			this.乳房右.X0Y3_乳輪.SizeBase = this.nsb2 + num;
			this.乳房右.X0Y4_乳首.SizeBase = this.nsb1 + num;
			this.乳房右.X0Y4_乳輪.SizeBase = this.nsb2 + num;
			this.乳房左.乳首CD.不透明度 = this.Cha.ChaD.素乳首濃度 + this.Cha.ChaD.最乳首濃度 * this.Cha.ChaD.現乳首;
			this.乳房左.乳輪CD.不透明度 = this.Cha.ChaD.素乳首濃度 + this.Cha.ChaD.最乳首濃度 * this.Cha.ChaD.現乳首;
			this.乳房右.乳首CD.不透明度 = this.Cha.ChaD.素乳首濃度 + this.Cha.ChaD.最乳首濃度 * this.Cha.ChaD.現乳首;
			this.乳房右.乳輪CD.不透明度 = this.Cha.ChaD.素乳首濃度 + this.Cha.ChaD.最乳首濃度 * this.Cha.ChaD.現乳首;
			num = 0.65 * this.Cha.ChaD.最陰核 * this.Cha.ChaD.現陰核;
			if (this.Is獣)
			{
				this.性器_獣.X0Y0_陰核.SizeBase = this.csb + num;
				this.性器_獣.X0Y1_陰核.SizeBase = this.csb + num;
				this.性器_獣.X0Y2_陰核.SizeBase = this.csb + num;
				this.性器_獣.X0Y3_陰核.SizeBase = this.csb + num;
				this.性器_獣.X0Y4_陰核.SizeBase = this.csb + num;
				this.性器_獣.小陰唇CD.不透明度 = this.Cha.ChaD.素性器濃度 + this.Cha.ChaD.最性器濃度 * this.Cha.ChaD.現性器;
				this.性器_獣.性器基CD.不透明度 = this.Cha.ChaD.素性器濃度 + this.Cha.ChaD.最性器濃度 * this.Cha.ChaD.現性器;
				this.肛門_獣.肛門3CD.不透明度 = this.Cha.ChaD.素肛門濃度 + this.Cha.ChaD.最肛門濃度 * this.Cha.ChaD.現肛門;
				num = 0.3 * this.Cha.ChaD.現肛門;
				this.肛門_獣.X0Y0_肛門2.SizeBase = this.asb1 + num;
				this.肛門_獣.X0Y0_肛門3.SizeBase = this.asb2 + num;
			}
			else
			{
				this.性器_人.X0Y0_陰核.SizeBase = this.csb + num;
				this.性器_人.X0Y1_陰核.SizeBase = this.csb + num;
				this.性器_人.X0Y2_陰核.SizeBase = this.csb + num;
				this.性器_人.X0Y3_陰核.SizeBase = this.csb + num;
				this.性器_人.X0Y4_陰核.SizeBase = this.csb + num;
				this.性器_人.小陰唇CD.不透明度 = this.Cha.ChaD.素性器濃度 + this.Cha.ChaD.最性器濃度 * this.Cha.ChaD.現性器;
				this.性器_人.性器基CD.不透明度 = this.Cha.ChaD.素性器濃度 + this.Cha.ChaD.最性器濃度 * this.Cha.ChaD.現性器;
				this.肛門_人.肛門3CD.不透明度 = this.Cha.ChaD.素肛門濃度 + this.Cha.ChaD.最肛門濃度 * this.Cha.ChaD.現肛門;
				num = 0.3 * this.Cha.ChaD.現肛門;
				this.肛門_人.X0Y0_肛門2.SizeBase = this.asb1 + num;
				this.肛門_人.X0Y0_肛門3.SizeBase = this.asb2 + num;
			}
			this.腰肌_人.陰毛CD.不透明度 = this.Cha.ChaD.現陰毛 * this.Cha.ChaD.最陰毛濃度;
			this.腰肌_人.獣性_獣毛CD.不透明度 = this.Cha.ChaD.現陰毛;
			this.腰肌_人.陰毛_ハ\u30FCトCD.不透明度 = this.Cha.ChaD.現陰毛.Inverse() * this.Cha.ChaD.最陰毛濃度;
		}

		public void SetEle<T>(Action<T> a) where T : Ele
		{
			T ele = this.全要素.GetEle<T>();
			if (ele != null)
			{
				a(ele);
				foreach (EleI eleI in this.eis)
				{
					if (eleI.ElesH.Contains(ele))
					{
						eleI.Updatef = true;
						break;
					}
				}
			}
		}

		public void SetEle<T>(bool 右, Action<T> a) where T : Ele
		{
			T ele = this.全要素.GetEle(右);
			if (ele != null)
			{
				a(ele);
				foreach (EleI eleI in this.eis)
				{
					if (eleI.ElesH.Contains(ele))
					{
						eleI.Updatef = true;
						break;
					}
				}
			}
		}

		public void SetEle<T>(Func<T, bool> con, Action<T> a) where T : Ele
		{
			T ele = this.全要素.GetEle(con);
			if (ele != null)
			{
				a(ele);
				foreach (EleI eleI in this.eis)
				{
					if (eleI.ElesH.Contains(ele))
					{
						eleI.Updatef = true;
						break;
					}
				}
			}
		}

		public void SetEleL<T>(Action<T> a) where T : Ele
		{
			T eleL = this.全要素.GetEleL<T>();
			if (eleL != null)
			{
				a(eleL);
				foreach (EleI eleI in this.eis)
				{
					if (eleI.ElesH.Contains(eleL))
					{
						eleI.Updatef = true;
						break;
					}
				}
			}
		}

		public void SetEleL<T>(bool 右, Action<T> a) where T : Ele
		{
			T eleL = this.全要素.GetEleL(右);
			if (eleL != null)
			{
				a(eleL);
				foreach (EleI eleI in this.eis)
				{
					if (eleI.ElesH.Contains(eleL))
					{
						eleI.Updatef = true;
						break;
					}
				}
			}
		}

		public void SetEleL<T>(Func<T, bool> con, Action<T> a) where T : Ele
		{
			T eleL = this.全要素.GetEleL(con);
			if (eleL != null)
			{
				a(eleL);
				foreach (EleI eleI in this.eis)
				{
					if (eleI.ElesH.Contains(eleL))
					{
						eleI.Updatef = true;
						break;
					}
				}
			}
		}

		public void SetEles<T>(Action<T> a) where T : Ele
		{
			IEnumerable<T> eles;
			foreach (T obj in (eles = this.全要素.GetEles<T>()))
			{
				a(obj);
			}
			using (HashSet<EleI>.Enumerator enumerator2 = this.eis.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					EleI ei = enumerator2.Current;
					if (eles.Any((T e) => ei.ElesH.Contains(e)))
					{
						ei.Updatef = true;
					}
				}
			}
		}

		public void SetEles<T>(bool 右, Action<T> a) where T : Ele
		{
			IEnumerable<T> eles;
			foreach (T obj in (eles = this.全要素.GetEles(右)))
			{
				a(obj);
			}
			using (HashSet<EleI>.Enumerator enumerator2 = this.eis.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					EleI ei = enumerator2.Current;
					if (eles.Any((T e) => ei.ElesH.Contains(e)))
					{
						ei.Updatef = true;
					}
				}
			}
		}

		public void SetEles<T>(Func<T, bool> con, Action<T> a) where T : Ele
		{
			IEnumerable<T> eles;
			foreach (T obj in (eles = this.全要素.GetEles(con)))
			{
				a(obj);
			}
			using (HashSet<EleI>.Enumerator enumerator2 = this.eis.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					EleI ei = enumerator2.Current;
					if (eles.Any((T e) => ei.ElesH.Contains(e)))
					{
						ei.Updatef = true;
					}
				}
			}
		}

		public void SetElesL<T>(Action<T> a) where T : Ele
		{
			IEnumerable<T> elesL;
			foreach (T obj in (elesL = this.全要素.GetElesL<T>()))
			{
				a(obj);
			}
			using (HashSet<EleI>.Enumerator enumerator2 = this.eis.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					EleI ei = enumerator2.Current;
					if (elesL.Any((T e) => ei.ElesH.Contains(e)))
					{
						ei.Updatef = true;
					}
				}
			}
		}

		public void SetElesL<T>(bool 右, Action<T> a) where T : Ele
		{
			IEnumerable<T> elesL;
			foreach (T obj in (elesL = this.全要素.GetElesL(右)))
			{
				a(obj);
			}
			using (HashSet<EleI>.Enumerator enumerator2 = this.eis.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					EleI ei = enumerator2.Current;
					if (elesL.Any((T e) => ei.ElesH.Contains(e)))
					{
						ei.Updatef = true;
					}
				}
			}
		}

		public void SetElesL<T>(Func<T, bool> con, Action<T> a) where T : Ele
		{
			IEnumerable<T> elesL;
			foreach (T obj in (elesL = this.全要素.GetElesL(con)))
			{
				a(obj);
			}
			using (HashSet<EleI>.Enumerator enumerator2 = this.eis.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					EleI ei = enumerator2.Current;
					if (elesL.Any((T e) => ei.ElesH.Contains(e)))
					{
						ei.Updatef = true;
					}
				}
			}
		}

		public List<string> GetHitTags(Color hc)
		{
			return (from e in this.EnumAllEle()
			select e.本体.GetHitTags(ref hc)).Aggregate(delegate(List<string> e0, List<string> e1)
			{
				e0.AddRange(e1);
				return e0;
			});
		}

		public Ele GetHitEle(Color hc)
		{
			return this.EnumAllEle().FirstOrDefault((Ele e) => e.本体.IsHit(ref hc));
		}

		public List<Par> GetHitPars(Color hc)
		{
			return (from e in this.EnumAllEle()
			select e.本体.GetHitPars(ref hc)).Aggregate(delegate(List<Par> e0, List<Par> e1)
			{
				e0.AddRange(e1);
				return e0;
			});
		}

		public bool IsHit(Color hc)
		{
			return this.EnumAllEle().Any((Ele e) => e.本体.IsHit(ref hc));
		}

		public IEnumerable<Ele> EnumAllEle()
		{
			return this.全要素.Concat(from e in this.全要素.GetEles<上腕_蝙>()
			select e.飛膜).Concat(from e in this.全要素.GetEles<手_蝙>()
			select e.飛膜).Concat(from e in this.全要素.GetEles<大顎基>()
			select e.大顎上);
		}

		public void Set染み位置()
		{
		}

		public void Join()
		{
			Ele[] array = this.全要素;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].接続PA();
			}
			foreach (蝙通常 蝙通常 in this.蝙通常)
			{
				蝙通常.接続();
			}
			if (this.頭色更新 != null)
			{
				this.頭色更新.色更新();
			}
			if (this.ドレス色更新 != null)
			{
				this.ドレス色更新.色更新();
			}
			if (this.鯨色更新 != null)
			{
				foreach (鯨色更新 鯨色更新 in this.鯨色更新)
				{
					鯨色更新.色更新();
				}
			}
			if (this.飛膜色更新 != null)
			{
				foreach (飛膜色更新 飛膜色更新 in this.飛膜色更新)
				{
					飛膜色更新.色更新();
				}
			}
			if (this.色更新 != null)
			{
				foreach (Ele ele in this.色更新)
				{
					ele.色更新();
				}
			}
			this.染み_人.位置B = this.腰.位置;
			this.染み_人.本体.JoinP();
			if (this.Is獣)
			{
				this.染み_獣.位置B = this.腰_獣.位置;
				this.染み_獣.本体.JoinP();
			}
			this.腰_人y = this.腰.Yi;
			if (this.Is獣)
			{
				this.腰_獣y = this.腰_獣.Yi;
			}
		}

		public void Update()
		{
			foreach (EleI eleI in this.eis)
			{
				eleI.Updatef = true;
			}
		}

		public bool Contains(Ele e)
		{
			return this.eis.Any((EleI f) => f.ElesH.Contains(e));
		}

		public bool IsUpdate(Ele e)
		{
			return this.eis.Any((EleI f) => f.IsUpdate(e));
		}

		public List<Ele> Inserts(Ele io, int i, Ele e)
		{
			int num;
			if ((num = this.後髪接続.IndexOf(io)) > -1)
			{
				this.後髪接続.Insert((num + i).LimitM(0, this.後髪接続.Count), e);
				return this.後髪接続;
			}
			if ((num = this.額接続.IndexOf(io)) > -1)
			{
				this.額接続.Insert((num + i).LimitM(0, this.額接続.Count), e);
				return this.額接続;
			}
			if ((num = this.耳左接続.IndexOf(io)) > -1)
			{
				this.耳左接続.Insert((num + i).LimitM(0, this.耳左接続.Count), e);
				return this.耳左接続;
			}
			if ((num = this.耳右接続.IndexOf(io)) > -1)
			{
				this.耳右接続.Insert((num + i).LimitM(0, this.耳右接続.Count), e);
				return this.耳右接続;
			}
			if ((num = this.頬左接続.IndexOf(io)) > -1)
			{
				this.頬左接続.Insert((num + i).LimitM(0, this.頬左接続.Count), e);
				return this.頬左接続;
			}
			if ((num = this.頬右接続.IndexOf(io)) > -1)
			{
				this.頬右接続.Insert((num + i).LimitM(0, this.頬右接続.Count), e);
				return this.頬右接続;
			}
			if ((num = this.頭頂左後接続.IndexOf(io)) > -1)
			{
				this.頭頂左後接続.Insert((num + i).LimitM(0, this.頭頂左後接続.Count), e);
				return this.頭頂左後接続;
			}
			if ((num = this.頭頂右後接続.IndexOf(io)) > -1)
			{
				this.頭頂右後接続.Insert((num + i).LimitM(0, this.頭頂右後接続.Count), e);
				return this.頭頂右後接続;
			}
			if ((num = this.植左接続.IndexOf(io)) > -1)
			{
				this.植左接続.Insert((num + i).LimitM(0, this.植左接続.Count), e);
				return this.植左接続;
			}
			if ((num = this.植右接続.IndexOf(io)) > -1)
			{
				this.植右接続.Insert((num + i).LimitM(0, this.植右接続.Count), e);
				return this.植右接続;
			}
			if ((num = this.触覚左接続.IndexOf(io)) > -1)
			{
				this.触覚左接続.Insert((num + i).LimitM(0, this.触覚左接続.Count), e);
				return this.触覚左接続;
			}
			if ((num = this.触覚右接続.IndexOf(io)) > -1)
			{
				this.触覚右接続.Insert((num + i).LimitM(0, this.触覚右接続.Count), e);
				return this.触覚右接続;
			}
			if ((num = this.顔触覚左接続.IndexOf(io)) > -1)
			{
				this.顔触覚左接続.Insert((num + i).LimitM(0, this.顔触覚左接続.Count), e);
				return this.顔触覚左接続;
			}
			if ((num = this.顔触覚右接続.IndexOf(io)) > -1)
			{
				this.顔触覚右接続.Insert((num + i).LimitM(0, this.顔触覚右接続.Count), e);
				return this.顔触覚右接続;
			}
			if ((num = this.大顎基接続.IndexOf(io)) > -1)
			{
				this.大顎基接続.Insert((num + i).LimitM(0, this.大顎基接続.Count), e);
				return this.大顎基接続;
			}
			if ((num = this.腕左.IndexOf(io)) > -1)
			{
				this.腕左.Insert((num + i).LimitM(0, this.腕左.Count), e);
				return this.腕左;
			}
			if ((num = this.腕右.IndexOf(io)) > -1)
			{
				this.腕右.Insert((num + i).LimitM(0, this.腕右.Count), e);
				return this.腕右;
			}
			if ((num = this.胸上左接続.IndexOf(io)) > -1)
			{
				this.胸上左接続.Insert((num + i).LimitM(0, this.胸上左接続.Count), e);
				return this.胸上左接続;
			}
			if ((num = this.胸上右接続.IndexOf(io)) > -1)
			{
				this.胸上右接続.Insert((num + i).LimitM(0, this.胸上右接続.Count), e);
				return this.胸上右接続;
			}
			if ((num = this.胸下左接続.IndexOf(io)) > -1)
			{
				this.胸下左接続.Insert((num + i).LimitM(0, this.胸下左接続.Count), e);
				return this.胸下左接続;
			}
			if ((num = this.胸下右接続.IndexOf(io)) > -1)
			{
				this.胸下右接続.Insert((num + i).LimitM(0, this.胸下右接続.Count), e);
				return this.胸下右接続;
			}
			if ((num = this.胴後左接続.IndexOf(io)) > -1)
			{
				this.胴後左接続.Insert((num + i).LimitM(0, this.胴後左接続.Count), e);
				return this.胴後左接続;
			}
			if ((num = this.胴後右接続.IndexOf(io)) > -1)
			{
				this.胴後右接続.Insert((num + i).LimitM(0, this.胴後右接続.Count), e);
				return this.胴後右接続;
			}
			if ((num = this.腰後左接続.IndexOf(io)) > -1)
			{
				this.腰後左接続.Insert((num + i).LimitM(0, this.腰後左接続.Count), e);
				return this.腰後左接続;
			}
			if ((num = this.腰後右接続.IndexOf(io)) > -1)
			{
				this.腰後右接続.Insert((num + i).LimitM(0, this.腰後右接続.Count), e);
				return this.腰後右接続;
			}
			if ((num = this.背中接続.IndexOf(io)) > -1)
			{
				this.背中接続.Insert((num + i).LimitM(0, this.背中接続.Count), e);
				return this.背中接続;
			}
			if ((num = this.腿左接続.IndexOf(io)) > -1)
			{
				this.腿左接続.Insert((num + i).LimitM(0, this.腿左接続.Count), e);
				return this.腿左接続;
			}
			if ((num = this.腿右接続.IndexOf(io)) > -1)
			{
				this.腿右接続.Insert((num + i).LimitM(0, this.腿右接続.Count), e);
				return this.腿右接続;
			}
			if ((num = this.尾接続.IndexOf(io)) > -1)
			{
				this.尾接続.Insert((num + i).LimitM(0, this.尾接続.Count), e);
				return this.尾接続;
			}
			if ((num = this.半身後接続.IndexOf(io)) > -1)
			{
				this.半身後接続.Insert((num + i).LimitM(0, this.半身後接続.Count), e);
				return this.半身後接続;
			}
			if ((num = this.半身中1接続.IndexOf(io)) > -1)
			{
				this.半身中1接続.Insert((num + i).LimitM(0, this.半身中1接続.Count), e);
				return this.半身中1接続;
			}
			if ((num = this.半身前接続.IndexOf(io)) > -1)
			{
				this.半身前接続.Insert((num + i).LimitM(0, this.半身前接続.Count), e);
				return this.半身前接続;
			}
			foreach (List<Ele> list in this.後腕左s)
			{
				if ((num = list.IndexOf(io)) > -1)
				{
					list.Insert((num + i).LimitM(0, list.Count), e);
					return list;
				}
			}
			foreach (List<Ele> list2 in this.後腕右s)
			{
				if ((num = list2.IndexOf(io)) > -1)
				{
					list2.Insert((num + i).LimitM(0, list2.Count), e);
					return list2;
				}
			}
			return null;
		}

		public キスマ\u30FCク Addキスマ\u30FCク(Vector2D cp, Color hc)
		{
			Ele he = this.GetHitEle(hc);
			スタンプK[] キスマ_u30FCク = this.キスマ\u30FCク;
			Func<EleI, bool> <>9__0;
			for (int i = 0; i < キスマ_u30FCク.Length; i++)
			{
				キスマ\u30FCク result;
				if ((result = キスマ_u30FCク[i].Add(cp, hc, he)) != null)
				{
					IEnumerable<EleI> source = this.eis;
					Func<EleI, bool> predicate;
					if ((predicate = <>9__0) == null)
					{
						predicate = (<>9__0 = ((EleI e) => e.ElesH.Contains(he)));
					}
					EleI eleI = source.FirstOrDefault(predicate);
					if (eleI != null)
					{
						eleI.Updatef = true;
					}
					return result;
				}
			}
			return null;
		}

		public void Add鞭痕(Vector2D cp, Color hc)
		{
			Ele he = this.GetHitEle(hc);
			if (Sta.WhipScars)
			{
				this.AddScars(he.ThisType.Name, he.右);
			}
			if (!(he is 下腕) && !(he is 首))
			{
				スタンプW[] array = this.鞭痕;
				int i = 0;
				Func<EleI, bool> <>9__0;
				while (i < array.Length)
				{
					if (array[i].Add(cp, hc, he))
					{
						IEnumerable<EleI> source = this.eis;
						Func<EleI, bool> predicate;
						if ((predicate = <>9__0) == null)
						{
							predicate = (<>9__0 = ((EleI e) => e.ElesH.Contains(he)));
						}
						EleI eleI = source.FirstOrDefault(predicate);
						if (eleI != null)
						{
							eleI.Updatef = true;
							return;
						}
						break;
					}
					else
					{
						i++;
					}
				}
			}
		}

		public void Addぶっかけ(Vector2D cp, Color hc)
		{
			if (OthN.XS.NextBool())
			{
				this.ぶっかけ小.Add(cp, hc, this.ぶっかけr);
				return;
			}
			this.ぶっかけ大.Add(cp, hc, this.ぶっかけr);
		}

		public void Dispose()
		{
			スタンプK[] キスマ_u30FCク = this.キスマ\u30FCク;
			for (int i = 0; i < キスマ_u30FCク.Length; i++)
			{
				キスマ_u30FCク[i].Dispose();
			}
			スタンプW[] array = this.鞭痕;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Dispose();
			}
			Ele[] array2 = this.全要素;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].Dispose();
			}
			foreach (EleI eleI in this.eis)
			{
				eleI.Dispose();
			}
			if (this.汗掻き != null)
			{
				this.汗掻き.Dispose();
			}
			if (this.ぶっかけ小 != null)
			{
				this.ぶっかけ小.Dispose();
			}
			if (this.ぶっかけ大 != null)
			{
				this.ぶっかけ大.Dispose();
			}
			if (this.染み_人 != null)
			{
				this.染み_人.Dispose();
			}
			if (this.染み_獣 != null)
			{
				this.染み_獣.Dispose();
			}
		}

		public void 描画(Are Are)
		{
			this.cb0 = (this.カ\u30FCソル != null);
			this.cb1 = (this.cb0 && !this.カ\u30FCソル.コキ);
			Ele[] array = this.全要素;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].接続PA();
			}
			foreach (蝙通常 蝙通常 in this.蝙通常)
			{
				if (!this.Contains(蝙通常.上腕) || this.IsUpdate(蝙通常.上腕))
				{
					蝙通常.接続();
				}
			}
			if (this.Is蜘尾)
			{
				this.出糸精液.接続P();
			}
			if (this.cb0)
			{
				this.カ\u30FCソル.Set挿入Position();
			}
			this.頭色更新.色更新();
			this.ドレス色更新.色更新();
			foreach (鯨色更新 鯨色更新 in this.鯨色更新)
			{
				if (!this.Contains(鯨色更新.長物) || this.IsUpdate(鯨色更新.長物))
				{
					鯨色更新.色更新();
				}
			}
			foreach (飛膜色更新 飛膜色更新 in this.飛膜色更新)
			{
				if (!this.Contains(飛膜色更新.根) || this.IsUpdate(飛膜色更新.根))
				{
					飛膜色更新.色更新();
				}
			}
			foreach (Ele ele in this.色更新)
			{
				if (!this.Contains(ele) || this.IsUpdate(ele))
				{
					ele.色更新();
				}
			}
			foreach (EleI eleI in this.eis)
			{
				eleI.Update();
			}
			this.Draw(Are);
		}

		public bool 舌_表示
		{
			get
			{
				return this.舌.表示;
			}
			set
			{
				this.舌.表示 = value;
				this.舌.SetValues("股", value && this.Is舌股);
			}
		}

		public bool 断面_表示
		{
			get
			{
				return this.膣基.表示 || this.膣内精液.表示 || this.断面.表示;
			}
			set
			{
				this.膣基.表示 = value;
				this.膣内精液.精液_表示 = value;
				this.断面.表示 = value;
				if (this.処女喪失)
				{
					this.膣内精液.血液1_表示 = value;
					this.膣内精液.血液2_表示 = value;
				}
				if (value)
				{
					if (this.Is獣)
					{
						this.断面_獣.子宮_表示 = !this.ボテ腹_表示;
						this.断面_獣.子宮口_表示 = !this.ボテ腹_表示;
						this.断面_獣.子宮内_表示 = !this.ボテ腹_表示;
						this.断面_獣.卵管左_表示 = !this.ボテ腹_表示;
						this.断面_獣.卵巣左_表示 = !this.ボテ腹_表示;
						this.断面_獣.卵管右_表示 = !this.ボテ腹_表示;
						this.断面_獣.卵巣右_表示 = !this.ボテ腹_表示;
						this.断面_獣.精液_表示 = !this.ボテ腹_表示;
						return;
					}
					this.断面_人.子宮_表示 = !this.ボテ腹_表示;
					this.断面_人.子宮口_表示 = !this.ボテ腹_表示;
					this.断面_人.子宮内_表示 = !this.ボテ腹_表示;
					this.断面_人.卵管左_表示 = !this.ボテ腹_表示;
					this.断面_人.卵巣左_表示 = !this.ボテ腹_表示;
					this.断面_人.卵管右_表示 = !this.ボテ腹_表示;
					this.断面_人.卵巣右_表示 = !this.ボテ腹_表示;
					this.断面_人.精液_表示 = !this.ボテ腹_表示;
				}
			}
		}

		public bool ボテ腹_表示
		{
			get
			{
				if (!this.Is獣)
				{
					return this.ボテ腹_人.表示;
				}
				return this.ボテ腹_獣.表示;
			}
			set
			{
				if (this.Is獣)
				{
					this.ボテ腹_獣.表示 = value;
					return;
				}
				if (!this.ボテ腹_人.表示 && value)
				{
					this.ボテ腹板_人.腹板1_腹板_表示 = this.胸腹板_人.虫性_腹板_表示;
					this.ボテ腹板_人.腹板1_縦線_表示 = this.胸腹板_人.虫性_縦線_表示;
					this.ボテ腹板_人.腹板2_腹板_表示 = this.胴腹板_人.虫性_腹板_表示;
					this.ボテ腹板_人.腹板2_縦線_表示 = this.胴腹板_人.虫性_縦線_表示;
					this.ボテ腹板_人.腹板3_腹板_表示 = this.腰肌_人.虫性_腹板1_腹板_表示;
					this.ボテ腹板_人.腹板3_縦線_表示 = this.腰肌_人.虫性_腹板1_縦線_表示;
					this.ボテ腹板_人.腹板4_腹板_表示 = this.腰肌_人.虫性_腹板2_腹板_表示;
					this.ボテ腹板_人.腹板4_縦線_表示 = this.腰肌_人.虫性_腹板2_縦線_表示;
					this.胸腹板_人.虫性_腹板_表示 = false;
					this.胸腹板_人.虫性_縦線_表示 = false;
					this.胴腹板_人.虫性_腹板_表示 = false;
					this.胴腹板_人.虫性_縦線_表示 = false;
					this.腰肌_人.虫性_腹板1_腹板_表示 = false;
					this.腰肌_人.虫性_腹板1_縦線_表示 = false;
					this.腰肌_人.虫性_腹板2_腹板_表示 = false;
					this.腰肌_人.虫性_腹板2_縦線_表示 = false;
				}
				else if (this.ボテ腹_人.表示 && !value)
				{
					this.胸腹板_人.虫性_腹板_表示 = this.ボテ腹板_人.腹板1_腹板_表示;
					this.胸腹板_人.虫性_縦線_表示 = this.ボテ腹板_人.腹板1_縦線_表示;
					this.胴腹板_人.虫性_腹板_表示 = this.ボテ腹板_人.腹板2_腹板_表示;
					this.胴腹板_人.虫性_縦線_表示 = this.ボテ腹板_人.腹板2_縦線_表示;
					this.腰肌_人.虫性_腹板1_腹板_表示 = this.ボテ腹板_人.腹板3_腹板_表示;
					this.腰肌_人.虫性_腹板1_縦線_表示 = this.ボテ腹板_人.腹板3_縦線_表示;
					this.腰肌_人.虫性_腹板2_腹板_表示 = this.ボテ腹板_人.腹板4_腹板_表示;
					this.腰肌_人.虫性_腹板2_縦線_表示 = this.ボテ腹板_人.腹板4_縦線_表示;
					this.ボテ腹板_人.腹板1_腹板_表示 = false;
					this.ボテ腹板_人.腹板1_縦線_表示 = false;
					this.ボテ腹板_人.腹板2_腹板_表示 = false;
					this.ボテ腹板_人.腹板2_縦線_表示 = false;
					this.ボテ腹板_人.腹板3_腹板_表示 = false;
					this.ボテ腹板_人.腹板3_縦線_表示 = false;
					this.ボテ腹板_人.腹板4_腹板_表示 = false;
					this.ボテ腹板_人.腹板4_縦線_表示 = false;
				}
				this.ボテ腹_人.表示 = value;
			}
		}

		public Vector2D 胸部位置
		{
			get
			{
				this.胸.接続P();
				return this.胸.X0Y0_胸郭.ToGlobal((this.胸.X0Y0_胸郭.OP[8].ps[2] + this.胸.X0Y0_胸郭.OP[2].ps[2]) * 0.5);
			}
		}

		public Vector2D 局部位置
		{
			get
			{
				this.性器.接続P();
				this.肛門.接続P();
				return (this.性器.位置 + this.肛門.位置) * 0.5;
			}
		}

		public Vector2D 口腔位置
		{
			get
			{
				this.口.接続P();
				return this.口.位置;
			}
		}

		public Vector2D 陰核位置
		{
			get
			{
				Par par = this.性器.本体.Current.EnumAllPar().First((Par e) => e.Tag == "陰核");
				this.性器.接続PA();
				return par.ToGlobal(par.BasePointBase.AddY(-0.003));
			}
		}

		public Vector2D 乳首左位置
		{
			get
			{
				Par par = this.乳房左.本体.Current.EnumAllPar().First((Par e) => e.Tag == "乳首");
				this.乳房左.接続PA();
				return par.ToGlobal(par.BasePointBase);
			}
		}

		public Vector2D 乳首右位置
		{
			get
			{
				Par par = this.乳房右.本体.Current.EnumAllPar().First((Par e) => e.Tag == "乳首");
				this.乳房右.接続PA();
				return par.ToGlobal(par.BasePointBase);
			}
		}

		public Vector2D 尿道位置
		{
			get
			{
				Par par = this.性器.本体.Current.EnumAllPar().First((Par e) => e.Tag == "尿道");
				this.性器.接続PA();
				return par.ToGlobal(par.BasePointBase);
			}
		}

		public Vector2D 膣口位置
		{
			get
			{
				Par par = this.性器.本体.Current.EnumAllPar().First((Par e) => e.Tag == "膣口");
				this.性器.接続PA();
				return par.Position;
			}
		}

		public Vector2D 肛門位置
		{
			get
			{
				this.肛門.接続PA();
				return this.肛門.位置;
			}
		}

		public Vector2D 出糸位置
		{
			get
			{
				this.蜘尾.接続PA();
				return this.蜘尾.X0Y0_出糸突起後_出糸突起基.Position;
			}
		}

		public double 頬濃度
		{
			get
			{
				if (!(this.口 is 口_通常))
				{
					return 0.0;
				}
				return ((口_通常)this.口).頬左CD.不透明度;
			}
			set
			{
				if (this.口 is 口_通常)
				{
					口_通常 口_通常 = (口_通常)this.口;
					口_通常.頬左CD.不透明度 = value;
					口_通常.頬右CD.不透明度 = value;
				}
			}
		}

		public double 汗染み濃度
		{
			get
			{
				return this.染み_人.汗CD.不透明度;
			}
			set
			{
				if (this.染み_人 != null)
				{
					this.染み_人.汗CD.不透明度 = value;
				}
				if (this.Is獣)
				{
					this.染み_獣.汗CD.不透明度 = value;
				}
			}
		}

		public double 尿染み濃度
		{
			get
			{
				if (!this.Is獣)
				{
					return this.染み_人.尿1CD.不透明度;
				}
				return this.染み_獣.尿1CD.不透明度;
			}
			set
			{
				if (this.Is獣)
				{
					this.染み_獣.尿1CD.不透明度 = value;
					this.染み_獣.尿2CD.不透明度 = value;
					return;
				}
				this.染み_人.尿1CD.不透明度 = value;
				this.染み_人.尿2CD.不透明度 = value;
			}
		}

		public double 潮染み濃度
		{
			get
			{
				if (!this.Is獣)
				{
					return this.染み_人.潮3CD.不透明度;
				}
				return this.染み_獣.潮3CD.不透明度;
			}
			set
			{
				if (this.Is獣)
				{
					this.染み_獣.潮3CD.不透明度 = value;
					return;
				}
				this.染み_人.潮3CD.不透明度 = value;
			}
		}

		public double 飛沫濃度
		{
			get
			{
				if (!this.Is獣)
				{
					return this.染み_人.潮2CD.不透明度;
				}
				return this.染み_獣.潮2CD.不透明度;
			}
			set
			{
				if (this.Is獣)
				{
					this.染み_獣.潮1CD.不透明度 = value;
					this.染み_獣.潮2CD.不透明度 = value;
					return;
				}
				this.染み_人.潮1CD.不透明度 = value;
				this.染み_人.潮2CD.不透明度 = value;
			}
		}

		public double 湯気左濃度
		{
			get
			{
				if (!this.Is獣)
				{
					return this.染み_人.湯気_湯気左1_湯気1CD.不透明度;
				}
				return this.染み_獣.湯気_湯気左1_湯気1CD.不透明度;
			}
			set
			{
				if (this.Is獣)
				{
					this.染み_獣.湯気_湯気左1_湯気1CD.不透明度 = value;
					this.染み_獣.湯気_湯気左1_湯気2CD.不透明度 = value;
					this.染み_獣.湯気_湯気左2_湯気1CD.不透明度 = value;
					this.染み_獣.湯気_湯気左2_湯気2CD.不透明度 = value;
					this.染み_獣.湯気_湯気左3_湯気1CD.不透明度 = value;
					this.染み_獣.湯気_湯気左3_湯気2CD.不透明度 = value;
					return;
				}
				this.染み_人.湯気_湯気左1_湯気1CD.不透明度 = value;
				this.染み_人.湯気_湯気左1_湯気2CD.不透明度 = value;
				this.染み_人.湯気_湯気左2_湯気1CD.不透明度 = value;
				this.染み_人.湯気_湯気左2_湯気2CD.不透明度 = value;
				this.染み_人.湯気_湯気左3_湯気1CD.不透明度 = value;
				this.染み_人.湯気_湯気左3_湯気2CD.不透明度 = value;
			}
		}

		public double 湯気右濃度
		{
			get
			{
				if (!this.Is獣)
				{
					return this.染み_人.湯気_湯気右1_湯気1CD.不透明度;
				}
				return this.染み_獣.湯気_湯気右1_湯気1CD.不透明度;
			}
			set
			{
				if (this.Is獣)
				{
					this.染み_獣.湯気_湯気右1_湯気1CD.不透明度 = value;
					this.染み_獣.湯気_湯気右1_湯気2CD.不透明度 = value;
					this.染み_獣.湯気_湯気右2_湯気1CD.不透明度 = value;
					this.染み_獣.湯気_湯気右2_湯気2CD.不透明度 = value;
					this.染み_獣.湯気_湯気右3_湯気1CD.不透明度 = value;
					this.染み_獣.湯気_湯気右3_湯気2CD.不透明度 = value;
					return;
				}
				this.染み_人.湯気_湯気右1_湯気1CD.不透明度 = value;
				this.染み_人.湯気_湯気右1_湯気2CD.不透明度 = value;
				this.染み_人.湯気_湯気右2_湯気1CD.不透明度 = value;
				this.染み_人.湯気_湯気右2_湯気2CD.不透明度 = value;
				this.染み_人.湯気_湯気右3_湯気1CD.不透明度 = value;
				this.染み_人.湯気_湯気右3_湯気2CD.不透明度 = value;
			}
		}

		public double 下着B染み
		{
			get
			{
				return this.下着B_ノ\u30FCマル.染み濃度;
			}
			set
			{
				this.下着B_ノ\u30FCマル.染み濃度 = value;
				this.下着B_マイクロ.染み濃度 = value;
			}
		}

		public double 下着T染み
		{
			get
			{
				return this.下着乳首左.染み濃度;
			}
			set
			{
				this.下着乳首左.染み濃度 = value;
				this.下着乳首右.染み濃度 = value;
			}
		}

		public double 上着B染み
		{
			get
			{
				return this.上着B_クロス後.染み濃度;
			}
			set
			{
				this.上着B_クロス後.染み濃度 = value;
			}
		}

		public double 陰核勃起
		{
			get
			{
				return this.下着陰核.濃度;
			}
			set
			{
				this.下着陰核.濃度 = value;
				double sizeCont = 1.0 + 0.1 * value;
				if (this.Is獣)
				{
					this.性器_獣.X0Y0_陰核.SizeCont = sizeCont;
					this.性器_獣.X0Y1_陰核.SizeCont = sizeCont;
					this.性器_獣.X0Y2_陰核.SizeCont = sizeCont;
					this.性器_獣.X0Y3_陰核.SizeCont = sizeCont;
					this.性器_獣.X0Y4_陰核.SizeCont = sizeCont;
					return;
				}
				this.性器_人.X0Y0_陰核.SizeCont = sizeCont;
				this.性器_人.X0Y1_陰核.SizeCont = sizeCont;
				this.性器_人.X0Y2_陰核.SizeCont = sizeCont;
				this.性器_人.X0Y3_陰核.SizeCont = sizeCont;
				this.性器_人.X0Y4_陰核.SizeCont = sizeCont;
			}
		}

		public double 乳首勃起
		{
			get
			{
				return this.下着乳首左.乳首CD.不透明度;
			}
			set
			{
				this.下着乳首左.乳首CD.不透明度 = value;
				this.下着乳首右.乳首CD.不透明度 = value;
				double sizeCont = 1.0 + 0.1 * value;
				this.乳房左.X0Y0_乳首.SizeCont = sizeCont;
				this.乳房左.X0Y1_乳首.SizeCont = sizeCont;
				this.乳房左.X0Y2_乳首.SizeCont = sizeCont;
				this.乳房左.X0Y3_乳首.SizeCont = sizeCont;
				this.乳房左.X0Y4_乳首.SizeCont = sizeCont;
				this.乳房右.X0Y0_乳首.SizeCont = sizeCont;
				this.乳房右.X0Y1_乳首.SizeCont = sizeCont;
				this.乳房右.X0Y2_乳首.SizeCont = sizeCont;
				this.乳房右.X0Y3_乳首.SizeCont = sizeCont;
				this.乳房右.X0Y4_乳首.SizeCont = sizeCont;
			}
		}

		public double 顔紅潮
		{
			get
			{
				return this.紅潮.濃度;
			}
			set
			{
				this.紅潮.濃度 = value;
				if (this.頬瞼左 != null)
				{
					this.頬瞼左.瞼左_瞼CD.色 = this.Cha.ChaD.体色.人肌.BlendP1(Color.FromArgb((int)(128.0 * value), this.Cha.ChaD.体色.粘膜)).GetSkinGrad();
					this.頬瞼左.瞼右_瞼CD.色 = this.Cha.ChaD.体色.人肌.BlendP1(Color.FromArgb((int)(128.0 * value), this.Cha.ChaD.体色.粘膜)).GetSkinGrad();
				}
				if (this.頬瞼右 != null)
				{
					this.頬瞼右.瞼左_瞼CD.色 = this.Cha.ChaD.体色.人肌.BlendP1(Color.FromArgb((int)(128.0 * value), this.Cha.ChaD.体色.粘膜)).GetSkinGrad();
					this.頬瞼右.瞼右_瞼CD.色 = this.Cha.ChaD.体色.人肌.BlendP1(Color.FromArgb((int)(128.0 * value), this.Cha.ChaD.体色.粘膜)).GetSkinGrad();
				}
			}
		}

		public double 体紅潮
		{
			get
			{
				return this.体紅潮_;
			}
			set
			{
				this.体紅潮_ = value;
				Color cs;
				Col.Alpha(ref this.Cha.ChaD.体色.粘膜, (int)(24.0 * this.体紅潮_), out cs);
				this.Set人肌色(this.Cha.ChaD.体色.人肌.BlendP1(cs));
			}
		}

		private void Set人肌色(Color c)
		{
			Color col = this.頭.頭CD.色.Col1;
			Color col2 = this.頭.頭CD.色.Col2;
			Color2 色;
			Col.GetSkinGrad(ref c, out 色);
			色.Col1 = col;
			Color2 色2;
			色.GetRep(out 色2);
			foreach (Ele ele in this.EnumAllEle())
			{
				foreach (FieldInfo fieldInfo in from f in ele.GetType().GetFields()
				where f.FieldType.ToString() == Sta.cdt
				select f)
				{
					ColorD colorD = (ColorD)fieldInfo.GetValue(ele);
					if (colorD.色.Col1 == col && colorD.色.Col2 == col2)
					{
						colorD.色 = 色;
					}
					else if (colorD.色.Col1 == col2 && colorD.色.Col2 == col)
					{
						colorD.色 = 色2;
					}
				}
			}
		}

		public double 子宮下がり
		{
			get
			{
				return this.子宮下がり_;
			}
			set
			{
				this.子宮下がり_ = value;
				double scale = -0.003;
				if (this.Is獣)
				{
					this.断面_獣.X0Y0_子宮.BasePointCont = Dat.Vec2DUnitY * scale * this.子宮下がり_;
					this.断面_獣.X0Y1_子宮.BasePointCont = Dat.Vec2DUnitY * scale * this.子宮下がり_;
					this.断面_獣.X0Y2_子宮.BasePointCont = Dat.Vec2DUnitY * scale * this.子宮下がり_;
					this.断面_獣.X0Y3_子宮.BasePointCont = Dat.Vec2DUnitY * scale * this.子宮下がり_;
					this.断面_獣.X0Y4_子宮.BasePointCont = Dat.Vec2DUnitY * scale * this.子宮下がり_;
					return;
				}
				this.断面_人.X0Y0_子宮.BasePointCont = Dat.Vec2DUnitY * scale * this.子宮下がり_;
				this.断面_人.X0Y1_子宮.BasePointCont = Dat.Vec2DUnitY * scale * this.子宮下がり_;
				this.断面_人.X0Y2_子宮.BasePointCont = Dat.Vec2DUnitY * scale * this.子宮下がり_;
				this.断面_人.X0Y3_子宮.BasePointCont = Dat.Vec2DUnitY * scale * this.子宮下がり_;
				this.断面_人.X0Y4_子宮.BasePointCont = Dat.Vec2DUnitY * scale * this.子宮下がり_;
			}
		}

		public double 肛門開き
		{
			get
			{
				return this.肛門開き_;
			}
			set
			{
				this.肛門開き_ = value;
				double num = 2.0;
				double num2 = 4.0;
				double num3 = 2.0;
				if (this.Is獣)
				{
					this.肛門_獣.X0Y0_肛門1.SizeYBase = this.肛門y + num * this.肛門開き_;
					this.肛門_獣.X0Y0_肛門1.SizeBase = this.肛門v + num2 * this.肛門開き_;
					this.肛門_獣.X0Y0_肛門2.SizeBase = this.肛門v + num3 * this.肛門開き_;
					return;
				}
				this.肛門_人.X0Y0_肛門1.SizeYBase = this.肛門y + num * this.肛門開き_;
				this.肛門_人.X0Y0_肛門1.SizeBase = this.肛門v + num2 * this.肛門開き_;
				this.肛門_人.X0Y0_肛門2.SizeBase = this.肛門v + num3 * this.肛門開き_;
			}
		}

		public double 肛門C
		{
			set
			{
				if (this.Is獣)
				{
					this.肛門_獣.X0Y0_肛門1.SizeCont = value;
					this.肛門_獣.X0Y0_肛門1.SizeCont = value;
					return;
				}
				this.肛門_人.X0Y0_肛門1.SizeCont = value;
				this.肛門_人.X0Y0_肛門1.SizeCont = value;
			}
		}

		public double 膣腔C
		{
			set
			{
				if (this.Is獣)
				{
					this.性器_獣.X0Y0_膣口.SizeCont = value;
					return;
				}
				this.性器_人.X0Y0_膣口.SizeCont = value;
			}
		}

		public double 出糸C
		{
			set
			{
				if (value != 0.0)
				{
					this.蜘尾.X0Y0_出糸突起後_出糸突起中.SizeYCont = 0.8 + 0.2 * OthN.XS.NextDouble();
				}
				else
				{
					this.蜘尾.X0Y0_出糸突起後_出糸突起中.SizeYCont = 1.0;
				}
				this.蜘尾.X0Y0_出糸突起後_出糸突起左.AngleCont = value * OthN.XS.NextDouble();
				this.蜘尾.X0Y0_出糸突起後_出糸突起右.AngleCont = -value * OthN.XS.NextDouble();
				this.蜘尾.X0Y0_出糸突起左_出糸突起1.AngleCont = value * OthN.XS.NextDouble();
				this.蜘尾.X0Y0_出糸突起右_出糸突起1.AngleCont = -value * OthN.XS.NextDouble();
				this.蜘尾.X0Y0_出糸突起前_出糸突起左.AngleCont = value * OthN.XS.NextDouble();
				this.蜘尾.X0Y0_出糸突起前_出糸突起右.AngleCont = -value * OthN.XS.NextDouble();
				if (this.Is髪 && this.EI髪.ElesH.Contains(this.蜘尾))
				{
					this.EI髪.Updatef = true;
					return;
				}
				if (this.Is胸 && this.EI胸.ElesH.Contains(this.蜘尾))
				{
					this.EI胸.Updatef = true;
					return;
				}
				if (this.Is腰 && this.EI腰.ElesH.Contains(this.蜘尾))
				{
					this.EI腰.Updatef = true;
					return;
				}
				if (this.Is腕前 && this.EI腕前.ElesH.Contains(this.蜘尾))
				{
					this.EI腕前.Updatef = true;
					return;
				}
				if (this.Is半後 && this.EI半後.ElesH.Contains(this.蜘尾))
				{
					this.EI半後.Updatef = true;
					return;
				}
				if (this.Is半中1 && this.EI半中1.ElesH.Contains(this.蜘尾))
				{
					this.EI半中1.Updatef = true;
					return;
				}
				if (this.Is半中2 && this.EI半中2.ElesH.Contains(this.蜘尾))
				{
					this.EI半中2.Updatef = true;
					return;
				}
				if (this.Is半前 && this.EI半前.ElesH.Contains(this.蜘尾))
				{
					this.EI半前.Updatef = true;
				}
			}
		}

		public double くぱぁ0
		{
			get
			{
				return this.性器.くぱぁ;
			}
			set
			{
				this.性器.くぱぁ = value;
			}
		}

		public double くぱぁ1
		{
			get
			{
				if (this.Is蛇)
				{
					return this.蛇.くぱぁ;
				}
				if (!this.Is蠍)
				{
					return 0.0;
				}
				return this.蠍.くぱぁ;
			}
			set
			{
				if (this.Is蛇)
				{
					this.蛇.くぱぁ = value;
					return;
				}
				if (this.Is蠍)
				{
					this.蠍.くぱぁ = value;
				}
			}
		}

		public bool Is口腔()
		{
			return this.口腔位置.DistanceSquared(this.Cha.CP) < this.r17;
		}

		public bool Is陰核()
		{
			return this.陰核位置.DistanceSquared(this.Cha.CP) < this.r10;
		}

		public bool Is乳首()
		{
			return this.乳首左位置.DistanceSquared(this.Cha.CP) < this.r10 || this.乳首右位置.DistanceSquared(this.Cha.CP) < this.r10;
		}

		public bool Is膣口()
		{
			return this.膣口位置.DistanceSquared(this.Cha.CP) < this.r10;
		}

		public bool Is口部()
		{
			return this.口腔位置.DistanceSquared(this.Cha.CP) < this.r35;
		}

		public bool Is胸部()
		{
			return this.胸部位置.DistanceSquared(this.Cha.CP) < this.r17;
		}

		public bool Is局部()
		{
			return this.局部位置.DistanceSquared(this.Cha.CP) < this.r35;
		}

		public bool Isくぱぁ()
		{
			if (this.Is蛇)
			{
				return this.蛇.くぱぁ >= 0.5;
			}
			return !this.Is蠍 || this.蠍.くぱぁ >= 0.5;
		}

		public void 口腔接続()
		{
			this.腰.接続PA();
			this.胴.接続PA();
			this.胸.接続PA();
			this.首.接続PA();
			this.頭.接続PA();
		}

		public void 性器接続()
		{
			this.腰.接続PA();
			if (this.Is獣)
			{
				this.胸_獣.接続PA();
				this.胴_獣.接続PA();
				this.腰_獣.接続PA();
			}
			this.性器.接続PA();
		}

		public void 肛門接続()
		{
			this.腰.接続PA();
			if (this.Is獣)
			{
				this.胸_獣.接続PA();
				this.胴_獣.接続PA();
				this.腰_獣.接続PA();
			}
			this.肛門.接続PA();
		}

		public void 出糸接続()
		{
			foreach (Ele ele in this.腰.EnumEle())
			{
				ele.接続PA();
				if (ele is 尾_蜘)
				{
					break;
				}
			}
		}

		public void 腕前後(bool 右, int n, bool value)
		{
			if (右)
			{
				this.腕右前後(n, value);
				return;
			}
			this.腕左前後(n, value);
		}

		private void 腕左前後(int n, bool value)
		{
			if (this.nsl[n] != value)
			{
				this.nsl[n] = value;
				if (value)
				{
					if (n == 0)
					{
						if (this.Is最前腕人)
						{
							this.腕左前後_ = value;
							return;
						}
					}
					else if (this.後腕左s.Length != 0)
					{
						n = this.後腕左s.Length - n;
						Ele item = this.後腕左s[n][1];
						this.後腕左s[n].RemoveAt(1);
						this.後腕左s[n].Add(item);
						return;
					}
				}
				else if (n == 0)
				{
					if (this.Is最前腕人)
					{
						this.腕左前後_ = value;
						return;
					}
				}
				else if (this.後腕左s.Length != 0)
				{
					n = this.後腕左s.Length - n;
					Ele item2 = this.後腕左s[n].Last<Ele>();
					this.後腕左s[n].RemoveAt(this.後腕左s[n].Count - 1);
					this.後腕左s[n].Insert(1, item2);
				}
			}
		}

		private void 腕右前後(int n, bool value)
		{
			if (this.nsr[n] != value)
			{
				this.nsr[n] = value;
				if (value)
				{
					if (n == 0)
					{
						if (this.Is最前腕人)
						{
							this.腕右前後_ = value;
							return;
						}
					}
					else if (this.後腕右s.Length != 0)
					{
						n = this.後腕左s.Length - n;
						Ele item = this.後腕右s[n][1];
						this.後腕右s[n].RemoveAt(1);
						this.後腕右s[n].Add(item);
						return;
					}
				}
				else if (n == 0)
				{
					if (this.Is最前腕人)
					{
						this.腕右前後_ = value;
						return;
					}
				}
				else if (this.後腕右s.Length != 0)
				{
					n = this.後腕左s.Length - n;
					Ele item2 = this.後腕右s[n].Last<Ele>();
					this.後腕右s[n].RemoveAt(this.後腕右s[n].Count - 1);
					this.後腕右s[n].Insert(1, item2);
				}
			}
		}

		public bool 捲り判定0
		{
			get
			{
				return this.左腿開きi > 0 || this.右腿開きi > 0 || this.Is腿犬 || this.Is腿魚 || this.Is腿獣 || (this.Is獣 && this.胸_獣.脇左_接続 != null && this.胸_獣.脇左_接続.Length != 0) || this.Is蜘 || this.Is蠍 || this.Is蟲;
			}
		}

		public bool 捲り判定1
		{
			get
			{
				return false;
			}
		}

		private void 腰振り_人()
		{
			this.胴.X0Y0_筋肉_筋肉左.PositionCont = Dat.Vec2DUnitY * (this.腰.Yv * -0.004);
			this.胴.X0Y0_筋肉_筋肉右.PositionCont = Dat.Vec2DUnitY * (this.腰.Yv * -0.004);
			this.胴腹板_人.X0Y0_虫性_腹板.PositionCont = Dat.Vec2DUnitY * (this.腰.Yv * -0.002);
			this.胴肌_人.本体.SizeYCont = 0.85 + (1.0 - this.腰.Yv) * 0.15;
		}

		public double 腰振り_人v
		{
			get
			{
				return this.腰.Yv;
			}
			set
			{
				this.腰.Yv = value;
				this.腰肌_人.Yv = value;
				this.下着B_ノ\u30FCマル.Yv = value;
				this.下着B_マイクロ.Yv = value;
				this.性器_人.本体.SizeYCont = 0.65 + this.腰.Yv * 0.35;
				foreach (Par par in this.性器_人.本体.EnumJoinRoot)
				{
					par.PositionCont = Dat.Vec2DUnitY * (this.腰.Yv * 0.001 + 0.001);
				}
				this.肛門_人.本体.SizeYCont = 0.65 + this.腰.Yv * 0.35;
				foreach (Par par2 in this.上着B_クロス.本体.EnumJoinRoot)
				{
					par2.PositionCont = Dat.Vec2DUnitY * (this.腰.Yv * 0.003);
				}
				foreach (Par par3 in this.上着B_前掛け.本体.EnumJoinRoot)
				{
					par3.PositionCont = Dat.Vec2DUnitY * (this.腰.Yv * 0.003);
				}
				this.腰振り_人();
			}
		}

		public int 腰振り_人i
		{
			get
			{
				return this.腰.Yi;
			}
			set
			{
				this.腰.Yi = value;
				this.腰肌_人.Yi = value;
				this.下着B_ノ\u30FCマル.Yi = value;
				this.下着B_マイクロ.Yi = value;
				this.性器_人.本体.SizeYCont = 0.65 + this.腰.Yv * 0.35;
				foreach (Par par in this.性器_人.本体.EnumJoinRoot)
				{
					par.PositionCont = Dat.Vec2DUnitY * (this.腰.Yv * 0.001 + 0.001);
				}
				this.肛門_人.本体.SizeYCont = 0.65 + this.腰.Yv * 0.35;
				foreach (Par par2 in this.上着B_クロス.本体.EnumJoinRoot)
				{
					par2.PositionCont = Dat.Vec2DUnitY * (this.腰.Yv * 0.003);
				}
				foreach (Par par3 in this.上着B_前掛け.本体.EnumJoinRoot)
				{
					par3.PositionCont = Dat.Vec2DUnitY * (this.腰.Yv * 0.003);
				}
				this.腰振り_人();
			}
		}

		private void 腰振り_獣()
		{
			this.胴_獣.X0Y0_筋肉_筋肉左.PositionCont = Dat.Vec2DUnitY * (this.腰_獣.Yv * -0.004);
			this.胴_獣.X0Y0_筋肉_筋肉右.PositionCont = Dat.Vec2DUnitY * (this.腰_獣.Yv * -0.004);
			this.胴肌_獣.本体.SizeYCont = 0.85 + (1.0 - this.腰_獣.Yv) * 0.15;
			if (this.EI半中1 != null)
			{
				this.EI半中1.Updatef = true;
			}
		}

		public double 腰振り_獣v
		{
			get
			{
				return this.腰_獣.Yv;
			}
			set
			{
				this.腰_獣.Yv = value;
				this.腰肌_獣.Yv = value;
				this.性器_獣.本体.SizeYCont = 0.65 + this.腰_獣.Yv * 0.35;
				foreach (Par par in this.性器_獣.本体.EnumJoinRoot)
				{
					par.PositionCont = Dat.Vec2DUnitY * (this.腰_獣.Yv * 0.001 + 0.001);
				}
				this.肛門_獣.本体.SizeYCont = 0.65 + this.腰_獣.Yv * 0.35;
				this.腰振り_獣();
			}
		}

		public int 腰振り_獣i
		{
			get
			{
				return this.腰_獣.Yi;
			}
			set
			{
				this.腰_獣.Yi = value;
				this.腰肌_獣.Yi = value;
				this.性器_獣.本体.SizeYCont = 0.65 + this.腰_獣.Yv * 0.35;
				foreach (Par par in this.性器_獣.本体.EnumJoinRoot)
				{
					par.PositionCont = Dat.Vec2DUnitY * (this.腰_獣.Yv * 0.001 + 0.001);
				}
				this.肛門_獣.本体.SizeYCont = 0.65 + this.腰_獣.Yv * 0.35;
				this.腰振り_獣();
			}
		}

		public double 腰振りv
		{
			get
			{
				if (!this.Is獣)
				{
					return this.腰振り_人v;
				}
				return this.腰振り_獣v;
			}
			set
			{
				if (this.Is獣)
				{
					this.腰振り_獣v = value;
					return;
				}
				this.腰振り_人v = value;
			}
		}

		public int 腰振りi
		{
			get
			{
				if (!this.Is獣)
				{
					return this.腰振り_人i;
				}
				return this.腰振り_獣i;
			}
			set
			{
				if (this.Is獣)
				{
					this.腰振り_獣i = value;
					return;
				}
				this.腰振り_人i = value;
			}
		}

		public void Set腰()
		{
			if (this.Is獣)
			{
				if (this.捲り判定0)
				{
					this.腰振り_人i = 4;
				}
				this.腰振り_獣i = 0;
				return;
			}
			if (this.Is蜘 || this.Is蠍)
			{
				this.腰振り_人i = 4;
				return;
			}
			this.腰振り_人i = 0;
		}

		public bool Is初期腰
		{
			get
			{
				if (this.Is獣)
				{
					return this.腰振り_獣i != 0;
				}
				return this.腰振り_人i != 0;
			}
		}

		public double 腿開きv
		{
			get
			{
				if (this.脚人左.Count > 0)
				{
					return this.脚人左[0].腿.Yv;
				}
				if (this.脚人右.Count > 0)
				{
					return this.脚人右[0].腿.Yv;
				}
				return 0.0;
			}
			set
			{
				if (this.脚人左.Count > 0)
				{
					脚人 脚人 = this.脚人左[0];
					脚人.腿.Yv = value;
					if (脚人.脚 != null)
					{
						脚人.脚.開脚(脚人.腿);
					}
					if (脚人.足 != null)
					{
						脚人.足.開脚(脚人.腿);
					}
				}
				if (this.脚人右.Count > 0)
				{
					脚人 脚人2 = this.脚人右[0];
					脚人2.腿.Yv = value;
					if (脚人2.脚 != null)
					{
						脚人2.脚.開脚(脚人2.腿);
					}
					if (脚人2.足 != null)
					{
						脚人2.足.開脚(脚人2.腿);
					}
				}
				if (this.捲り判定0)
				{
					this.上着B_クロス.Yv = value;
				}
				if (this.捲り判定1)
				{
					this.上着B_前掛け.Yv = value;
				}
				if (this.EI腿 != null)
				{
					this.EI腿.Updatef = true;
				}
			}
		}

		public int 腿開きi
		{
			get
			{
				if (this.脚人左.Count > 0)
				{
					return this.脚人左[0].腿.Yi;
				}
				if (this.脚人右.Count > 0)
				{
					return this.脚人右[0].腿.Yi;
				}
				return 0;
			}
			set
			{
				if (this.脚人左.Count > 0)
				{
					脚人 脚人 = this.脚人左[0];
					脚人.腿.Yi = value;
					if (脚人.脚 != null)
					{
						脚人.脚.開脚(脚人.腿);
					}
					if (脚人.足 != null)
					{
						脚人.足.開脚(脚人.腿);
					}
				}
				if (this.脚人右.Count > 0)
				{
					脚人 脚人2 = this.脚人右[0];
					脚人2.腿.Yi = value;
					if (脚人2.脚 != null)
					{
						脚人2.脚.開脚(脚人2.腿);
					}
					if (脚人2.足 != null)
					{
						脚人2.足.開脚(脚人2.腿);
					}
				}
				if (this.捲り判定0)
				{
					this.上着B_クロス.Yi = value;
				}
				if (this.捲り判定1)
				{
					this.上着B_前掛け.Yi = value;
				}
				if (this.EI腿 != null)
				{
					this.EI腿.Updatef = true;
				}
			}
		}

		public double 左腿開きv
		{
			get
			{
				if (this.脚人左.Count > 0)
				{
					return this.脚人左[0].腿.Yv;
				}
				return 0.0;
			}
			set
			{
				if (this.脚人左.Count > 0)
				{
					脚人 脚人 = this.脚人左[0];
					脚人.腿.Yv = value;
					if (脚人.脚 != null)
					{
						脚人.脚.開脚(脚人.腿);
					}
					if (脚人.足 != null)
					{
						脚人.足.開脚(脚人.腿);
					}
				}
			}
		}

		public int 左腿開きi
		{
			get
			{
				if (this.脚人左.Count > 0)
				{
					return this.脚人左[0].腿.Yi;
				}
				return 0;
			}
			set
			{
				if (this.脚人左.Count > 0)
				{
					脚人 脚人 = this.脚人左[0];
					脚人.腿.Yi = value;
					脚人.脚.開脚(脚人.腿);
					脚人.足.開脚(脚人.腿);
				}
			}
		}

		public double 右腿開きv
		{
			get
			{
				if (this.脚人右.Count > 0)
				{
					return this.脚人右[0].腿.Yv;
				}
				return 0.0;
			}
			set
			{
				if (this.脚人右.Count > 0)
				{
					脚人 脚人 = this.脚人右[0];
					脚人.腿.Yv = value;
					if (脚人.脚 != null)
					{
						脚人.脚.開脚(脚人.腿);
					}
					if (脚人.足 != null)
					{
						脚人.足.開脚(脚人.腿);
					}
				}
			}
		}

		public int 右腿開きi
		{
			get
			{
				if (this.脚人右.Count > 0)
				{
					return this.脚人右[0].腿.Yi;
				}
				return 0;
			}
			set
			{
				if (this.脚人右.Count > 0)
				{
					脚人 脚人 = this.脚人右[0];
					脚人.腿.Yi = value;
					if (脚人.脚 != null)
					{
						脚人.脚.開脚(脚人.腿);
					}
					if (脚人.足 != null)
					{
						脚人.足.開脚(脚人.腿);
					}
				}
			}
		}

		public void 腿Update()
		{
			int yi = (this.左腿開きi > 0 || this.右腿開きi > 0) ? 1 : 0;
			if (this.捲り判定0)
			{
				this.上着B_クロス.Yi = yi;
			}
			if (this.捲り判定1)
			{
				this.上着B_前掛け.Yi = yi;
			}
			if (this.EI腿 != null)
			{
				this.EI腿.Updatef = true;
			}
		}

		public double 口v
		{
			get
			{
				if (this.口 != null)
				{
					return this.口.Yv;
				}
				return 0.0;
			}
			set
			{
				if (this.口 != null)
				{
					this.口.Yv = value;
					this.頭.開顎(this.口);
				}
			}
		}

		public int 口i
		{
			get
			{
				if (this.口 != null)
				{
					return this.口.Yi;
				}
				return 0;
			}
			set
			{
				if (this.口 != null)
				{
					this.口.Yi = value;
					this.頭.開顎(this.口);
				}
			}
		}

		public double ボテ腹v
		{
			get
			{
				if (!this.Is獣)
				{
					return this.ボテ腹_人.Yv;
				}
				return this.ボテ腹_獣.Yv;
			}
			set
			{
				if (this.Is獣)
				{
					this.ボテ腹_獣.Yv = value;
				}
				else
				{
					this.ボテ腹_人.Yv = value;
					this.ボテ腹板_人.Yv = value;
				}
				this.上着B_前掛け.X0Y0_帯.SizeXCont = 1.0 + 0.1 * this.ボテ腹v;
				this.上着B_前掛け.X0Y1_帯.SizeXCont = this.上着B_前掛け.X0Y0_帯.SizeXCont;
			}
		}

		public int ボテ腹i
		{
			get
			{
				if (!this.Is獣)
				{
					return this.ボテ腹_人.Yi;
				}
				return this.ボテ腹_獣.Yi;
			}
			set
			{
				if (this.Is獣)
				{
					this.ボテ腹_獣.Yi = value;
				}
				else
				{
					this.ボテ腹_人.Yi = value;
					this.ボテ腹板_人.Yi = value;
				}
				this.上着B_前掛け.X0Y0_帯.SizeXCont = 1.0 + 0.1 * this.ボテ腹v;
				this.上着B_前掛け.X0Y1_帯.SizeXCont = this.上着B_前掛け.X0Y0_帯.SizeXCont;
			}
		}

		public int 瞼左i
		{
			get
			{
				if (this.瞼左 == null)
				{
					return 0;
				}
				return this.瞼左.Yi;
			}
			set
			{
				if (this.瞼左 != null)
				{
					this.瞼左.Yi = value;
					this.目傷左.Yi = value;
					this.目傷左.Yi = this.目傷左.Yi.Limit(0, 2);
				}
			}
		}

		public double 瞼左v
		{
			get
			{
				if (this.瞼左 == null)
				{
					return 0.0;
				}
				return this.瞼左.Yv;
			}
			set
			{
				if (this.瞼左 != null)
				{
					this.瞼左.Yv = value;
					this.目傷左.Yv = value;
					this.目傷左.Yi = this.目傷左.Yi.Limit(0, 2);
				}
			}
		}

		public int 瞼右i
		{
			get
			{
				if (this.瞼右 == null)
				{
					return 0;
				}
				return this.瞼右.Yi;
			}
			set
			{
				if (this.瞼右 != null)
				{
					this.瞼右.Yi = value;
					this.目傷右.Yi = value;
					this.目傷右.Yi = this.目傷右.Yi.Limit(0, 2);
				}
			}
		}

		public double 瞼右v
		{
			get
			{
				if (this.瞼右 == null)
				{
					return 0.0;
				}
				return this.瞼右.Yv;
			}
			set
			{
				if (this.瞼右 != null)
				{
					this.瞼右.Yv = value;
					this.目傷右.Yv = value;
					this.目傷右.Yi = this.目傷右.Yi.Limit(0, 2);
				}
			}
		}

		public 髪留2情報 Set後髪髪留
		{
			get
			{
				return this.後髪髪留i;
			}
			set
			{
				this.後髪髪留i = value;
				if (this.後髪0 != null)
				{
					if (this.後髪0 is お下げ1)
					{
						お下げ1 お下げ = (お下げ1)this.後髪0;
						お下げ.お下げ_髪縛1_表示 = value.髪留左.髪縛1_表示;
						お下げ.お下げ_髪縛2_表示 = value.髪留左.髪縛2_表示;
						お下げ.髪留配色(value.髪留左.色);
						return;
					}
					if (this.後髪0 is お下げ2)
					{
						お下げ2 お下げ2 = (お下げ2)this.後髪0;
						お下げ2.お下げ左_髪縛1_表示 = value.髪留左.髪縛1_表示;
						お下げ2.お下げ左_髪縛2_表示 = value.髪留左.髪縛2_表示;
						お下げ2.お下げ右_髪縛1_表示 = value.髪留右.髪縛1_表示;
						お下げ2.お下げ右_髪縛2_表示 = value.髪留右.髪縛2_表示;
						お下げ2.髪留配色(value.髪留左.色, value.髪留右.色);
					}
				}
			}
		}

		public 髪留2情報 Set横髪髪留
		{
			get
			{
				return this.横髪髪留i;
			}
			set
			{
				this.横髪髪留i = value;
				if (this.横髪左 != null && this.横髪左 is 横髪_編み)
				{
					横髪_編み 横髪_編み = (横髪_編み)this.横髪左;
					横髪_編み.髪縛1_表示 = value.髪留左.髪縛1_表示;
					横髪_編み.髪縛2_表示 = value.髪留左.髪縛2_表示;
					横髪_編み.髪留配色(value.髪留左.色);
				}
				if (this.横髪右 != null && this.横髪右 is 横髪_編み)
				{
					横髪_編み 横髪_編み2 = (横髪_編み)this.横髪右;
					横髪_編み2.髪縛1_表示 = value.髪留右.髪縛1_表示;
					横髪_編み2.髪縛2_表示 = value.髪留右.髪縛2_表示;
					横髪_編み2.髪留配色(value.髪留右.色);
				}
			}
		}

		private void Set表示(object e, object i)
		{
			Type type = e.GetType();
			foreach (FieldInfo fieldInfo in from e_ in i.GetType().GetFields()
			where e_.FieldType.ToString() == Sta.bt
			select e_)
			{
				type.GetProperty(fieldInfo.Name).SetValue(e, fieldInfo.GetValue(i), null);
			}
		}

		public 玉口枷情報 Set玉口枷
		{
			get
			{
				return this.玉口枷i;
			}
			set
			{
				this.玉口枷i = value;
				if (this.玉口枷 != null)
				{
					this.Set表示(this.玉口枷, this.玉口枷i);
					this.玉口枷.配色(this.玉口枷i.色);
				}
			}
		}

		public 目隠帯情報 Set目隠帯
		{
			get
			{
				return this.目隠帯i;
			}
			set
			{
				this.目隠帯i = value;
				if (this.目隠帯 != null)
				{
					this.Set表示(this.目隠帯, this.目隠帯i);
					this.目隠帯.配色(this.目隠帯i.色);
				}
			}
		}

		public 拘束具情報 Set拘束具
		{
			get
			{
				return this.拘束具i;
			}
			set
			{
				this.拘束具i = value;
				object[] array = new object[1];
				foreach (Ele ele in this.全要素)
				{
					foreach (MethodInfo methodInfo in ele.GetType().GetMethods())
					{
						if (methodInfo.Name.Contains("輪") && methodInfo.Name.Contains("配色"))
						{
							ele.拘束 = this.拘束具i.表示;
							array[0] = this.拘束具i.色;
							methodInfo.Invoke(ele, array);
						}
					}
				}
				this.全要素.SetValues("鎖表示", this.拘束具i.表示);
				if (this.拘束具i.表示)
				{
					if (this.Is蛇)
					{
						int num = 0;
						胴_蛇 ele2 = this.蛇.胴_接続.GetEle<胴_蛇>();
						while (ele2 != null)
						{
							if (num % 4 != 0)
							{
								ele2.拘束 = false;
								ele2.鎖表示 = false;
							}
							ele2 = ele2.胴_接続.GetEle<胴_蛇>();
							num++;
						}
					}
					if (this.Is蟲)
					{
						int num2 = 0;
						胴_蟲 ele3 = this.蟲.胴_接続.GetEle<胴_蟲>();
						while (ele3 != null)
						{
							if (num2 % 2 == 0)
							{
								ele3.拘束 = false;
								ele3.鎖表示 = false;
							}
							ele3 = ele3.胴_接続.GetEle<胴_蟲>();
							num2++;
						}
					}
					foreach (Ele ele4 in this.全要素)
					{
						if (ele4 is 触手_蔦)
						{
							触手_蔦 触手_蔦 = (触手_蔦)ele4;
							触手_蔦.X0Y0_先端_上顎_顎.AngleBase = 0.0;
							触手_蔦.X0Y0_先端_下顎_顎.AngleBase = 0.0;
						}
						else if (ele4 is 触手_犬)
						{
							触手_犬 触手_犬 = (触手_犬)ele4;
							触手_犬.X0Y0_頭_上顎_眼下_眼下.AngleBase = 0.0;
							触手_犬.X0Y0_頭_下顎_眼下_眼下.AngleBase = 0.0;
						}
						else if (ele4 is 触肢_肢蠍)
						{
							((触肢_肢蠍)ele4).X0Y0_爪2.AngleBase = 0.0;
						}
						else if (ele4 is 虫鎌)
						{
							((虫鎌)ele4).Set角度0();
						}
					}
				}
			}
		}

		public ピアス情報 Setピアス
		{
			get
			{
				return this.ピアスi;
			}
			set
			{
				this.ピアスi = value;
				if (this.ピアス != null)
				{
					this.Set表示(this.ピアス, this.ピアスi);
					this.ピアス.配色(this.ピアスi.色);
					this.ピアス.SetHitFalse();
					this.腰肌_人.陰毛_ハ\u30FCト_表示 = ((this.腰肌_人.陰毛_表示 || this.腰肌_人.獣性_獣毛_表示) && this.ピアス.表示);
					this.腰肌_人.陰毛CD.不透明度 = this.Cha.ChaD.現陰毛 * this.Cha.ChaD.最陰毛濃度;
					this.腰肌_人.獣性_獣毛CD.不透明度 = this.Cha.ChaD.現陰毛;
					this.腰肌_人.陰毛_ハ\u30FCトCD.不透明度 = this.Cha.ChaD.現陰毛.Inverse() * this.Cha.ChaD.最陰毛濃度;
				}
			}
		}

		public ピアス情報 Setピアス左
		{
			get
			{
				return this.ピアス左i;
			}
			set
			{
				this.ピアス左i = value;
				if (this.ピアス左 != null)
				{
					this.Set表示(this.ピアス左, this.ピアス左i);
					this.ピアス左.配色(this.ピアス左i.色);
					this.ピアス左.SetHitFalse();
				}
			}
		}

		public ピアス情報 Setピアス右
		{
			get
			{
				return this.ピアス右i;
			}
			set
			{
				this.ピアス右i = value;
				if (this.ピアス右 != null)
				{
					this.Set表示(this.ピアス右, this.ピアス右i);
					this.ピアス右.配色(this.ピアス右i.色);
					this.ピアス右.SetHitFalse();
				}
			}
		}

		public キャップ情報 Setキャップ1
		{
			get
			{
				return this.キャップ1i;
			}
			set
			{
				this.キャップ1i = value;
				if (this.キャップ1 != null)
				{
					this.Set表示(this.キャップ1, this.キャップ1i);
					this.キャップ1.配色(this.キャップ1i.色);
				}
			}
		}

		public キャップ情報 Setキャップ2左
		{
			get
			{
				return this.キャップ2左i;
			}
			set
			{
				this.キャップ2左i = value;
				if (this.キャップ2左 != null)
				{
					this.Set表示(this.キャップ2左, this.キャップ2左i);
					this.キャップ2左.配色(this.キャップ2左i.色);
				}
			}
		}

		public キャップ情報 Setキャップ2右
		{
			get
			{
				return this.キャップ2右i;
			}
			set
			{
				this.キャップ2右i = value;
				if (this.キャップ2右 != null)
				{
					this.Set表示(this.キャップ2右, this.キャップ2右i);
					this.キャップ2右.配色(this.キャップ2右i.色);
				}
			}
		}

		public ドレス首情報 Setドレス首
		{
			get
			{
				return this.ドレス首i;
			}
			set
			{
				this.ドレス首i = value;
				if (this.首 != null)
				{
					this.Set表示(this.首, this.ドレス首i);
					this.首.ドレス配色(this.ドレス首i.色);
				}
			}
		}

		public 下着T_チュ\u30FCブ情報 Set下着T_チュ\u30FCブ
		{
			get
			{
				return this.下着T_チュ\u30FCブi;
			}
			set
			{
				this.下着T_チュ\u30FCブi = value;
				if (this.下着T_チュ\u30FCブ != null)
				{
					this.Set表示(this.下着T_チュ\u30FCブ, this.下着T_チュ\u30FCブi);
					this.下着T_チュ\u30FCブ.配色(this.下着T_チュ\u30FCブi.色);
					bool isShow = this.下着T_チュ\u30FCブi.IsShow;
					this.乳房左.着衣 = isShow;
					this.乳房右.着衣 = isShow;
					this.下着T_チュ\u30FCブ.SetHitFalse();
					this.下着乳首左.表示 = (!this.乳房左.虫性_甲殻_表示 && isShow);
					this.下着乳首右.表示 = (!this.乳房右.虫性_甲殻_表示 && isShow);
					this.下着乳首左.配色(this.下着T_チュ\u30FCブi.色.生地色);
					this.下着乳首右.配色(this.下着T_チュ\u30FCブi.色.生地色);
					this.乳首勃起 = this.乳首勃起;
					if (this.噴乳左.母乳垂れ1_表示)
					{
						this.下着T染み = this.Cha.噴乳染み;
						return;
					}
					this.下着T染み = 0.0;
				}
			}
		}

		public 下着T_クロス情報 Set下着T_クロス
		{
			get
			{
				return this.下着T_クロスi;
			}
			set
			{
				this.下着T_クロスi = value;
				if (this.下着T_クロス != null)
				{
					this.Set表示(this.下着T_クロス, this.下着T_クロスi);
					this.下着T_クロス.配色(this.下着T_クロスi.色);
					bool isShow = this.下着T_クロスi.IsShow;
					this.乳房左.着衣 = isShow;
					this.乳房右.着衣 = isShow;
					this.下着T_クロス.SetHitFalse();
					this.下着乳首左.表示 = (!this.乳房左.虫性_甲殻_表示 && isShow);
					this.下着乳首右.表示 = (!this.乳房右.虫性_甲殻_表示 && isShow);
					this.下着乳首左.配色(this.下着T_クロスi.色.生地色);
					this.下着乳首右.配色(this.下着T_クロスi.色.生地色);
					this.乳首勃起 = this.乳首勃起;
					if (this.噴乳左.母乳垂れ1_表示)
					{
						this.下着T染み = this.Cha.噴乳染み;
						return;
					}
					this.下着T染み = 0.0;
				}
			}
		}

		public 下着T_ビキニ情報 Set下着T_ビキニ
		{
			get
			{
				return this.下着T_ビキニi;
			}
			set
			{
				this.下着T_ビキニi = value;
				if (this.下着T_ビキニ != null)
				{
					this.Set表示(this.下着T_ビキニ, this.下着T_ビキニi);
					this.下着T_ビキニ.配色(this.下着T_ビキニi.色);
					bool isShow = this.下着T_ビキニi.IsShow;
					this.乳房左.着衣 = isShow;
					this.乳房右.着衣 = isShow;
					this.下着T_ビキニ.SetHitFalse();
					this.下着乳首左.表示 = (!this.乳房左.虫性_甲殻_表示 && isShow);
					this.下着乳首右.表示 = (!this.乳房右.虫性_甲殻_表示 && isShow);
					this.下着乳首左.配色(this.下着T_ビキニi.色.生地色);
					this.下着乳首右.配色(this.下着T_ビキニi.色.生地色);
					this.乳首勃起 = this.乳首勃起;
					if (this.噴乳左.母乳垂れ1_表示)
					{
						this.下着T染み = this.Cha.噴乳染み;
						return;
					}
					this.下着T染み = 0.0;
				}
			}
		}

		public 下着T_マイクロ情報 Set下着T_マイクロ
		{
			get
			{
				return this.下着T_マイクロi;
			}
			set
			{
				this.下着T_マイクロi = value;
				if (this.下着T_マイクロ != null)
				{
					this.Set表示(this.下着T_マイクロ, this.下着T_マイクロi);
					this.下着T_マイクロ.配色(this.下着T_マイクロi.色);
					bool isShow = this.下着T_マイクロi.IsShow;
					this.乳房左.着衣 = isShow;
					this.乳房右.着衣 = isShow;
					this.下着T_マイクロ.SetHitFalse();
					this.下着乳首左.表示 = (!this.乳房左.虫性_甲殻_表示 && isShow);
					this.下着乳首右.表示 = (!this.乳房右.虫性_甲殻_表示 && isShow);
					this.下着乳首左.配色(this.下着T_マイクロi.色.生地色);
					this.下着乳首右.配色(this.下着T_マイクロi.色.生地色);
					this.乳首勃起 = this.乳首勃起;
					if (this.噴乳左.母乳垂れ1_表示)
					{
						this.下着T染み = this.Cha.噴乳染み;
						return;
					}
					this.下着T染み = 0.0;
				}
			}
		}

		public 下着T_ブラ情報 Set下着T_ブラ
		{
			get
			{
				return this.下着T_ブラi;
			}
			set
			{
				this.下着T_ブラi = value;
				if (this.下着T_ブラ != null)
				{
					this.Set表示(this.下着T_ブラ, this.下着T_ブラi);
					this.下着T_ブラ.配色(this.下着T_ブラi.色);
					bool isShow = this.下着T_ブラi.IsShow;
					this.乳房左.着衣 = isShow;
					this.乳房右.着衣 = isShow;
					this.下着T_ブラ.SetHitFalse();
					this.下着乳首左.表示 = false;
					this.下着乳首右.表示 = false;
					if (this.噴乳左.母乳垂れ1_表示)
					{
						this.下着T染み = this.Cha.噴乳染み;
						return;
					}
					this.下着T染み = 0.0;
				}
			}
		}

		public 下着B_ノ\u30FCマル情報 Set下着B_ノ\u30FCマル
		{
			get
			{
				return this.下着B_ノ\u30FCマルi;
			}
			set
			{
				this.下着B_ノ\u30FCマルi = value;
				if (this.下着B_ノ\u30FCマル != null)
				{
					this.Set表示(this.下着B_ノ\u30FCマル, this.下着B_ノ\u30FCマルi);
					this.下着B_ノ\u30FCマル.配色(this.下着B_ノ\u30FCマルi.色);
					this.下着B_ノ\u30FCマル.SetHitFalse();
					this.下着陰核.表示 = (this.下着B_ノ\u30FCマルi.IsShow || this.下着B_マイクロi.IsShow);
					this.下着陰核.配色(this.下着B_ノ\u30FCマルi.色.生地色);
					this.陰核勃起 = this.陰核勃起;
				}
			}
		}

		public 下着B_マイクロ情報 Set下着B_マイクロ
		{
			get
			{
				return this.下着B_マイクロi;
			}
			set
			{
				this.下着B_マイクロi = value;
				if (this.下着B_マイクロ != null)
				{
					this.Set表示(this.下着B_マイクロ, this.下着B_マイクロi);
					this.下着B_マイクロ.配色(this.下着B_マイクロi.色);
					this.下着B_マイクロ.SetHitFalse();
					this.下着陰核.表示 = (this.下着B_マイクロi.IsShow || this.下着B_ノ\u30FCマルi.IsShow);
					this.下着陰核.配色(this.下着B_マイクロi.色.生地色);
					this.陰核勃起 = this.陰核勃起;
				}
			}
		}

		public ドレス情報 Setドレス
		{
			get
			{
				return this.ドレスi;
			}
			set
			{
				this.ドレスi = value;
				bool isShow = this.ドレスi.T.IsShow;
				if (this.乳房左 != null)
				{
					this.乳房左.着衣 = isShow;
				}
				if (this.乳房右 != null)
				{
					this.乳房右.着衣 = isShow;
				}
				if (this.上着T_ドレス != null)
				{
					this.Set表示(this.上着T_ドレス, this.ドレスi.T);
					this.上着T_ドレス.配色(this.ドレスi.色);
					this.上着T_ドレス.SetHitFalse();
				}
				if (this.上着M_ドレス != null)
				{
					this.Set表示(this.上着M_ドレス, this.ドレスi.M);
					this.上着M_ドレス.配色(this.ドレスi.色);
					this.上着M_ドレス.SetHitFalse();
				}
			}
		}

		public 上着B_クロス情報 Set上着B_クロス
		{
			get
			{
				return this.上着B_クロスi;
			}
			set
			{
				this.上着B_クロスi = value;
				if (this.上着B_クロス != null)
				{
					this.Set表示(this.上着B_クロス, this.上着B_クロスi);
					this.上着B_クロス.配色(this.上着B_クロスi.色);
					this.上着B_クロス後.配色(this.上着B_クロスi.色);
					this.上着B_クロス.上着ボトム後_接続[0].表示 = this.上着B_クロスi.IsShow;
					this.上着B_クロス.SetHitFalse();
					this.上着B_クロス.Yi = (this.捲り判定0 ? 1 : 0);
					if (this.捲り判定0)
					{
						if (this.上着B_クロスi.IsShow)
						{
							this.上着B_クロス.左_皺1_表示 = false;
							this.上着B_クロス.右_皺1_表示 = false;
						}
					}
					else if (this.上着B_クロスi.IsShow)
					{
						this.上着B_クロス.左_皺1_表示 = true;
						this.上着B_クロス.右_皺1_表示 = true;
					}
				}
				this.下着B_ノ\u30FCマルi.紐 = false;
				this.下着B_マイクロi.紐 = false;
				this.Set下着B_ノ\u30FCマル = this.下着B_ノ\u30FCマルi;
				this.Set下着B_マイクロ = this.下着B_マイクロi;
			}
		}

		public 上着B_前掛け情報 Set上着B_前掛け
		{
			get
			{
				return this.上着B_前掛けi;
			}
			set
			{
				this.上着B_前掛けi = value;
				if (this.上着B_前掛け != null)
				{
					this.Set表示(this.上着B_前掛け, this.上着B_前掛けi);
					this.上着B_前掛け.配色(this.上着B_前掛けi.色);
					this.上着B_前掛け.SetHitFalse();
					this.上着B_前掛け.Yi = (this.捲り判定1 ? 1 : 0);
				}
			}
		}

		public ブ\u30FCツ情報 Setブ\u30FCツ
		{
			get
			{
				return this.ブ\u30FCツi;
			}
			set
			{
				this.ブ\u30FCツi = value;
				foreach (脚人 脚人 in this.脚人左)
				{
					if (脚人.脚 != null)
					{
						this.Set表示(脚人.脚, this.ブ\u30FCツi.脚);
						脚人.脚.ブ\u30FCツ配色(this.ブ\u30FCツi.色);
					}
					if (脚人.足 != null)
					{
						this.Set表示(脚人.足, this.ブ\u30FCツi.足);
						脚人.足.ブ\u30FCツ配色(this.ブ\u30FCツi.色);
					}
				}
				foreach (脚人 脚人2 in this.脚人右)
				{
					if (脚人2.脚 != null)
					{
						this.Set表示(脚人2.脚, this.ブ\u30FCツi.脚);
						脚人2.脚.ブ\u30FCツ配色(this.ブ\u30FCツi.色);
					}
					if (脚人2.足 != null)
					{
						this.Set表示(脚人2.足, this.ブ\u30FCツi.足);
						脚人2.足.ブ\u30FCツ配色(this.ブ\u30FCツi.色);
					}
				}
			}
		}

		public bool Is下着T
		{
			get
			{
				return this.下着T_チュ\u30FCブi.IsShow || this.下着T_クロスi.IsShow || this.下着T_ビキニi.IsShow || this.下着T_マイクロi.IsShow || this.下着T_ブラi.IsShow;
			}
		}

		public bool Is下着B
		{
			get
			{
				return this.下着B_ノ\u30FCマルi.IsShow || this.下着B_マイクロi.IsShow;
			}
		}

		public bool Is上着T
		{
			get
			{
				return this.ドレスi.IsShow;
			}
		}

		public bool Is上着B
		{
			get
			{
				return this.上着B_クロスi.IsShow || this.上着B_前掛けi.IsShow;
			}
		}

		public bool Is拘束
		{
			get
			{
				return this.拘束具i.表示;
			}
		}

		public void 脱衣()
		{
			this.Set後髪髪留 = Sta.髪留2初期化;
			this.Set横髪髪留 = Sta.髪留2初期化;
			this.Set玉口枷 = Sta.玉口枷初期化;
			this.Set目隠帯 = Sta.目隠帯初期化;
			this.Setピアス = Sta.ピアス初期化;
			this.Setピアス左 = Sta.ピアス初期化;
			this.Setピアス右 = Sta.ピアス初期化;
			this.Setキャップ1 = Sta.キャップ初期化;
			this.Setキャップ2左 = Sta.キャップ初期化;
			this.Setキャップ2右 = Sta.キャップ初期化;
			this.Setドレス首 = Sta.ドレス首初期化;
			this.Set下着T_チュ\u30FCブ = Sta.下着T_チュ\u30FCブ初期化;
			this.Set下着T_クロス = Sta.下着T_クロス初期化;
			this.Set下着T_ビキニ = Sta.下着T_ビキニ初期化;
			this.Set下着T_マイクロ = Sta.下着T_マイクロ初期化;
			this.Set下着T_ブラ = Sta.下着T_ブラ初期化;
			this.Set下着B_ノ\u30FCマル = Sta.下着B_ノ\u30FCマル初期化;
			this.Set下着B_マイクロ = Sta.下着B_マイクロ初期化;
			this.Setドレス = Sta.ドレス初期化;
			this.Set上着B_クロス = Sta.上着B_クロス初期化;
			this.Set上着B_前掛け = Sta.上着B_前掛け初期化;
			this.Setブ\u30FCツ = Sta.ブ\u30FCツ初期化;
		}

		public bool 拘束具_表示
		{
			get
			{
				return this.拘束具i.表示;
			}
			set
			{
				if (value)
				{
					this.Set拘束具 = 拘束具情報.GetDefault();
					return;
				}
				this.Set拘束具 = Sta.拘束具初期化;
			}
		}

		public bool 目隠帯_表示
		{
			get
			{
				return this.Set目隠帯.革_表示;
			}
			set
			{
				if (value)
				{
					this.Set目隠帯 = 目隠帯情報.GetDefault();
					this.Cha.瞼();
					return;
				}
				this.Set目隠帯 = Sta.目隠帯初期化;
			}
		}

		public bool 玉口枷_表示
		{
			get
			{
				return this.Set玉口枷.革_表示;
			}
			set
			{
				if (value)
				{
					this.口i = 9;
					this.Cha.舌_無し();
					this.Set玉口枷 = 玉口枷情報.GetDefault();
					return;
				}
				this.Set玉口枷 = Sta.玉口枷初期化;
			}
		}

		public bool 首輪_表示
		{
			get
			{
				return this.首.拘束;
			}
			set
			{
				if (value)
				{
					拘束具情報 @default = 拘束具情報.GetDefault();
					this.首.拘束 = @default.表示;
					this.首.首輪配色(@default.色);
					return;
				}
				拘束具情報 拘束具初期化 = Sta.拘束具初期化;
				this.首.拘束 = 拘束具初期化.表示;
				this.首.首輪配色(拘束具初期化.色);
			}
		}

		public void 胸施術()
		{
			this.乳房左.虫性_甲殻_表示 = false;
			this.乳房右.虫性_甲殻_表示 = false;
		}

		public void 股施術()
		{
			if (this.Is蛇)
			{
				this.蛇.ガ\u30FCド = false;
				this.蛇.くぱぁ = 1.0;
				this.EI半中1.Updatef = true;
				return;
			}
			if (this.Is蠍)
			{
				this.蠍.生殖口蓋左_表示 = false;
				this.蠍.生殖口蓋右_表示 = false;
				this.蠍.基節_肢内突起左_表示 = false;
				this.蠍.基節_肢内突起右_表示 = false;
				this.蠍.くぱぁ = 1.0;
				return;
			}
			if (this.Is獣)
			{
				if (this.腰肌_獣 != null)
				{
					this.腰肌_獣.竜性_鱗1_表示 = false;
					this.腰肌_獣.竜性_鱗2_表示 = false;
					this.腰肌_獣.竜性_鱗3_表示 = false;
					this.腰肌_獣.竜性_鱗4_表示 = false;
					return;
				}
			}
			else
			{
				this.腰肌_人.竜性_鱗1_表示 = false;
				this.腰肌_人.竜性_鱗2_表示 = false;
				this.腰肌_人.竜性_鱗3_表示 = false;
				this.腰肌_人.竜性_鱗4_表示 = false;
			}
		}

		public void タトゥ()
		{
			if (this.Is獣)
			{
				this.腰肌_獣.淫タトゥ_タトゥ1右_表示 = true;
				this.腰肌_獣.淫タトゥ_タトゥ1左_表示 = true;
				this.腰肌_獣.淫タトゥ_タトゥ2右_表示 = true;
				this.腰肌_獣.淫タトゥ_タトゥ2左_表示 = true;
				this.腰肌_獣.淫タトゥ_ハ\u30FCト_タトゥ右1_表示 = true;
				this.腰肌_獣.淫タトゥ_ハ\u30FCト_タトゥ右2_表示 = true;
				this.腰肌_獣.淫タトゥ_ハ\u30FCト_タトゥ左1_表示 = true;
				this.腰肌_獣.淫タトゥ_ハ\u30FCト_タトゥ左2_表示 = true;
				this.腰肌_獣.植タトゥ_タトゥ左_表示 = false;
				this.腰肌_獣.植タトゥ_タトゥ右_表示 = false;
				return;
			}
			this.腰肌_人.淫タトゥ_タトゥ1右_表示 = true;
			this.腰肌_人.淫タトゥ_タトゥ1左_表示 = true;
			this.腰肌_人.淫タトゥ_タトゥ2右_表示 = true;
			this.腰肌_人.淫タトゥ_タトゥ2左_表示 = true;
			this.腰肌_人.淫タトゥ_ハ\u30FCト_タトゥ右1_表示 = true;
			this.腰肌_人.淫タトゥ_ハ\u30FCト_タトゥ右2_表示 = true;
			this.腰肌_人.淫タトゥ_ハ\u30FCト_タトゥ左1_表示 = true;
			this.腰肌_人.淫タトゥ_ハ\u30FCト_タトゥ左2_表示 = true;
			this.腰肌_人.植タトゥ_タトゥ左_表示 = false;
			this.腰肌_人.植タトゥ_タトゥ右_表示 = false;
		}

		public bool Is胸甲殻()
		{
			return this.乳房左.虫性_甲殻_表示;
		}

		public bool Is股防御()
		{
			if (this.Is蛇)
			{
				return this.蛇.ガ\u30FCド;
			}
			if (this.Is蠍)
			{
				return this.蠍.生殖口蓋左_表示;
			}
			if (this.Is獣)
			{
				return this.腰肌_獣 != null && (this.腰肌_獣.竜性_鱗1_表示 || this.腰肌_獣.竜性_鱗2_表示 || this.腰肌_獣.竜性_鱗3_表示 || this.腰肌_獣.竜性_鱗4_表示);
			}
			return this.腰肌_人.竜性_鱗1_表示 || this.腰肌_人.竜性_鱗2_表示 || this.腰肌_人.竜性_鱗3_表示 || this.腰肌_人.竜性_鱗4_表示;
		}

		public void AddScars(string name, bool right)
		{
			bool flag = false;
			if (name.Contains("胴"))
			{
				name = "腰";
			}
			if (name.Contains("首"))
			{
				name = "肩";
			}
			if (name.Contains("頭") || name.Contains("前髪"))
			{
				switch (new Random().Next(1, 4))
				{
				case 1:
					name = "目傷";
					right = 0.5.Lot();
					break;
				case 2:
					name = "鼻肌";
					break;
				case 3:
					name = "頬肌";
					right = 0.5.Lot();
					break;
				default:
					name = "鼻肌";
					break;
				}
			}
			foreach (EleD eleD in Sta.GameData.調教対象.ChaD.構成.EnumEleD())
			{
				if (eleD.ThisType.Name.Contains(name) && eleD.右.ToString() == right.ToString())
				{
					foreach (FieldInfo fieldInfo in from e in eleD.ThisType.GetFields()
					where e.Name.EndsWith("_表示") && e.Name.Contains("傷")
					select e)
					{
						if (!(bool)fieldInfo.GetValue(eleD) && 0.02.Lot())
						{
							fieldInfo.SetValue(eleD, true);
							flag = true;
							break;
						}
					}
					foreach (FieldInfo fieldInfo2 in from e in eleD.ThisType.GetFields()
					where e.Name == "欠損"
					select e)
					{
						if (!(bool)fieldInfo2.GetValue(eleD) && flag)
						{
							fieldInfo2.SetValue(eleD, true);
						}
					}
					if (!Sta.GameData.調教対象.傷物フラグ)
					{
						Sta.DontScar = true;
						Sta.GameData.調教対象.傷物フラグ = true;
						Sta.DontScar = false;
					}
				}
			}
		}

		public Med Med;

		public Cha Cha;

		public Ele[] 全要素;

		private List<蝙通常> 蝙通常;

		private 頭色更新 頭色更新;

		private ドレス色更新 ドレス色更新;

		private IEnumerable<鯨色更新> 鯨色更新;

		private IEnumerable<飛膜色更新> 飛膜色更新;

		private IEnumerable<Ele> 色更新;

		public 腰 腰;

		public 胴 胴;

		public 胸 胸;

		public 首 首;

		public 頭 頭;

		public 基髪 基髪;

		public 前髪 前髪;

		public 横髪 横髪左;

		public 横髪 横髪右;

		public 後髪1 後髪1;

		public 後髪0 後髪0;

		public 単目 単眼目;

		public 単瞼 単眼瞼;

		public 双目 目左;

		public 双目 目右;

		public 双瞼 瞼左;

		public 双瞼 瞼右;

		public 縦目 額目;

		public 縦瞼 額瞼;

		public 頬目 頬目左;

		public 頬目 頬目右;

		public 頬瞼 頬瞼左;

		public 頬瞼 頬瞼右;

		public 涙 涙左;

		public 涙 涙右;

		public 目隠帯 目隠帯;

		public 鼻 鼻;

		public 鼻水 鼻水左;

		public 鼻水 鼻水右;

		public 口 口;

		public 舌 舌;

		public 涎 涎左;

		public 涎 涎右;

		public 性器精液_人 口精液;

		public 咳 咳;

		public 呼気 呼気;

		public 玉口枷 玉口枷;

		public 単眼眉 単眼眉;

		public 眉 眉左;

		public 眉 眉右;

		public 鼻肌 鼻肌;

		public 頬肌 頬肌左;

		public 頬肌 頬肌右;

		public 目尻影 目尻影左;

		public 目尻影 目尻影右;

		public 紅潮 紅潮;

		public 目傷 目傷左;

		public 目傷 目傷右;

		public 顔ハイライト 顔ハイライト左;

		public 顔ハイライト 顔ハイライト右;

		public 胸腹板 胸腹板_人;

		public 胸肌 胸肌_人;

		public 胸毛 胸毛_人;

		public 胴腹板 胴腹板_人;

		public 胴肌 胴肌_人;

		public ボテ腹_人 ボテ腹_人;

		public ボテ腹板 ボテ腹板_人;

		public 腰肌 腰肌_人;

		public 乳房 乳房左;

		public 乳房 乳房右;

		public 噴乳 噴乳左;

		public 噴乳 噴乳右;

		public ピアス ピアス左;

		public ピアス ピアス右;

		public キャップ2 キャップ2左;

		public キャップ2 キャップ2右;

		public 膣基_人 膣基_人;

		public 膣内精液_人 膣内精液_人;

		public 断面_人 断面_人;

		public 性器_人 性器_人;

		public 性器精液_人 性器精液_人;

		public 飛沫_人 飛沫_人;

		public 潮吹_小_人 潮吹_小_人;

		public 潮吹_大_人 潮吹_大_人;

		public 放尿_人 放尿_人;

		public ピアス ピアス;

		public キャップ1 キャップ1;

		public 肛門_人 肛門_人;

		public 肛門精液_人 肛門精液_人;

		public 下着トップ_チュ\u30FCブ 下着T_チュ\u30FCブ;

		public 下着トップ_クロス 下着T_クロス;

		public 下着トップ_ビキニ 下着T_ビキニ;

		public 下着トップ_マイクロ 下着T_マイクロ;

		public 下着トップ_ブラ 下着T_ブラ;

		public 下着乳首 下着乳首左;

		public 下着乳首 下着乳首右;

		public 下着ボトム_ノ\u30FCマル 下着B_ノ\u30FCマル;

		public 下着ボトム_マイクロ 下着B_マイクロ;

		public 下着陰核 下着陰核;

		public 上着ミドル_ドレス 上着M_ドレス;

		public 上着トップ_ドレス 上着T_ドレス;

		public 上着ボトム_クロス 上着B_クロス;

		public 上着ボトム_クロス後 上着B_クロス後;

		public 上着ボトム_前掛け 上着B_前掛け;

		public 長物_魚 魚;

		public 長物_鯨 鯨;

		public 長物_蛇 蛇;

		public DE 蛇前;

		public 長物_蟲 蟲;

		public 四足胸 胸_獣;

		public 四足胴 胴_獣;

		public 四足腰 腰_獣;

		public List<四足脇> 脇左_獣 = new List<四足脇>();

		public List<四足脇> 脇右_獣 = new List<四足脇>();

		public 胸肌 胸肌_獣;

		public 胴肌 胴肌_獣;

		public 腰肌 腰肌_獣;

		public 胸毛 胸毛_獣;

		public ボテ腹_獣 ボテ腹_獣;

		public 肛門_獣 肛門_獣;

		public 肛門精液_獣 肛門精液_獣;

		public 膣基_獣 膣基_獣;

		public 膣内精液_獣 膣内精液_獣;

		public 断面_獣 断面_獣;

		public 性器_獣 性器_獣;

		public 性器精液_獣 性器精液_獣;

		public 飛沫_獣 飛沫_獣;

		public 潮吹_小_獣 潮吹_小_獣;

		public 潮吹_大_獣 潮吹_大_獣;

		public 放尿_獣 放尿_獣;

		public 多足_蛸 蛸;

		public 多足_蜘 蜘;

		public 性器精液_人 出糸精液;

		public 多足_蠍 蠍;

		public DE 蠍前;

		public 単足_植 植;

		public 単足_粘 粘;

		private bool 涙描画;

		private bool 鼻描画;

		private List<Ele> 後髪接続 = new List<Ele>();

		private List<Ele> 額接続 = new List<Ele>();

		private List<Ele> 耳左接続 = new List<Ele>();

		private List<Ele> 耳右接続 = new List<Ele>();

		private List<Ele> 頬左接続 = new List<Ele>();

		private List<Ele> 頬右接続 = new List<Ele>();

		private List<Ele> 頭頂左後接続 = new List<Ele>();

		private List<Ele> 頭頂右後接続 = new List<Ele>();

		private List<角2> 角左接続 = new List<角2>();

		private List<角2> 角右接続 = new List<角2>();

		private List<Ele> 植左接続 = new List<Ele>();

		private List<Ele> 植右接続 = new List<Ele>();

		private List<Ele> 触覚左接続 = new List<Ele>();

		private List<Ele> 触覚右接続 = new List<Ele>();

		private List<Ele> 顔触覚左接続 = new List<Ele>();

		private List<Ele> 顔触覚右接続 = new List<Ele>();

		private List<Ele> 大顎基接続 = new List<Ele>();

		private 肩[] 後脇左s = new 肩[0];

		private 肩[] 後脇右s = new 肩[0];

		public List<Ele>[] 後腕左s = new List<Ele>[0];

		public List<Ele>[] 後腕右s = new List<Ele>[0];

		private 肩 肩左;

		private 肩 肩右;

		private List<Ele> 肩左飛膜 = new List<Ele>();

		private List<Ele> 肩右飛膜 = new List<Ele>();

		private List<Ele> 腕左 = new List<Ele>();

		private List<Ele> 腕右 = new List<Ele>();

		private List<Ele> 下腕以降左 = new List<Ele>();

		private List<Ele> 下腕以降右 = new List<Ele>();

		private List<Ele> 胸上左接続 = new List<Ele>();

		private List<Ele> 胸上右接続 = new List<Ele>();

		private List<Ele> 胸下左接続 = new List<Ele>();

		private List<Ele> 胸下右接続 = new List<Ele>();

		private List<Ele> 胴後左接続 = new List<Ele>();

		private List<Ele> 胴後右接続 = new List<Ele>();

		private List<Ele> 腰後左接続 = new List<Ele>();

		private List<Ele> 腰後右接続 = new List<Ele>();

		private List<Ele> 背中接続 = new List<Ele>();

		private List<Ele> 腿左接続 = new List<Ele>();

		private List<Ele> 腿右接続 = new List<Ele>();

		private List<Ele> 尾接続 = new List<Ele>();

		private List<Ele> 半身後接続 = new List<Ele>();

		private List<Ele> 半身中1接続 = new List<Ele>();

		private List<Ele> 半身中2接続 = new List<Ele>();

		private List<Ele> 半身前接続 = new List<Ele>();

		public 顔面 顔面;

		public 頭頂 頭頂;

		public 頭頂後_宇 頭頂後;

		public 耳 耳左;

		public 耳 耳右;

		public 獣耳 獣耳左;

		public 獣耳 獣耳右;

		public 触覚 触覚左;

		public 触覚 触覚右;

		public 触覚_甲 触覚甲左;

		public 触覚_甲 触覚甲右;

		public List<腕人> 腕人左 = new List<腕人>();

		public List<腕人> 腕人右 = new List<腕人>();

		public List<腕翼鳥> 腕翼鳥左 = new List<腕翼鳥>();

		public List<腕翼鳥> 腕翼鳥右 = new List<腕翼鳥>();

		public List<腕翼獣> 腕翼獣左 = new List<腕翼獣>();

		public List<腕翼獣> 腕翼獣右 = new List<腕翼獣>();

		public List<腕獣> 腕獣左 = new List<腕獣>();

		public List<腕獣> 腕獣右 = new List<腕獣>();

		public List<脚人> 脚人左 = new List<脚人>();

		public List<脚人> 脚人右 = new List<脚人>();

		public List<脚獣> 脚獣左 = new List<脚獣>();

		public List<脚獣> 脚獣右 = new List<脚獣>();

		public List<翼鳥> 翼鳥左 = new List<翼鳥>();

		public List<翼鳥> 翼鳥右 = new List<翼鳥>();

		public List<翼獣> 翼獣左 = new List<翼獣>();

		public List<翼獣> 翼獣右 = new List<翼獣>();

		public List<鰭> 鰭左 = new List<鰭>();

		public List<鰭> 鰭右 = new List<鰭>();

		public List<葉> 葉左 = new List<葉>();

		public List<葉> 葉右 = new List<葉>();

		public List<前翅> 前翅1左 = new List<前翅>();

		public List<前翅> 前翅1右 = new List<前翅>();

		public List<後翅> 後翅1左 = new List<後翅>();

		public List<後翅> 後翅1右 = new List<後翅>();

		public List<前翅> 前翅2左 = new List<前翅>();

		public List<前翅> 前翅2右 = new List<前翅>();

		public List<後翅> 後翅2左 = new List<後翅>();

		public List<後翅> 後翅2右 = new List<後翅>();

		public List<触肢_肢蜘> 触肢蜘左 = new List<触肢_肢蜘>();

		public List<触肢_肢蜘> 触肢蜘右 = new List<触肢_肢蜘>();

		public List<触肢_肢蠍> 触肢蠍左 = new List<触肢_肢蠍>();

		public List<触肢_肢蠍> 触肢蠍右 = new List<触肢_肢蠍>();

		public List<節足_足蜘> 節足蜘左 = new List<節足_足蜘>();

		public List<節足_足蜘> 節足蜘右 = new List<節足_足蜘>();

		public List<節足_足蠍> 節足蠍左 = new List<節足_足蠍>();

		public List<節足_足蠍> 節足蠍右 = new List<節足_足蠍>();

		public List<節足_足百> 節足百左 = new List<節足_足百>();

		public List<節足_足百> 節足百右 = new List<節足_足百>();

		public List<節尾_曳航> 節尾曳左 = new List<節尾_曳航>();

		public List<節尾_曳航> 節尾曳右 = new List<節尾_曳航>();

		public List<節尾_鋏> 節尾鋏左 = new List<節尾_鋏>();

		public List<節尾_鋏> 節尾鋏右 = new List<節尾_鋏>();

		public List<大顎> 大顎左 = new List<大顎>();

		public List<大顎> 大顎右 = new List<大顎>();

		public List<虫顎> 虫顎左 = new List<虫顎>();

		public List<虫顎> 虫顎右 = new List<虫顎>();

		public List<虫鎌> 虫鎌左 = new List<虫鎌>();

		public List<虫鎌> 虫鎌右 = new List<虫鎌>();

		public List<触手> 触手左 = new List<触手>();

		public List<触手> 触手右 = new List<触手>();

		public List<触手_犬> 触手犬左 = new List<触手_犬>();

		public List<触手_犬> 触手犬右 = new List<触手_犬>();

		public List<尾> 尾 = new List<尾>();

		public List<長胴> 長胴 = new List<長胴>();

		public スタンプK[] キスマ\u30FCク;

		public スタンプW[] 鞭痕;

		public 汗掻き 汗掻き;

		public スタンプB ぶっかけ小;

		public スタンプB ぶっかけ大;

		private Dictionary<Ele, List<Ele>> ぶっかけr = new Dictionary<Ele, List<Ele>>();

		public 調教UI カ\u30FCソル;

		private bool cb0;

		private bool cb1;

		private bool fi;

		private double nsb1;

		private double nsb2;

		private double csb;

		private double asb1;

		private double asb2;

		public EleI EI胸;

		public EleI EI髪;

		public EleI EI腰;

		public EleI EI半後;

		public EleI EI半中1;

		public EleI EI半中2;

		public EleI EI半前;

		public EleI EI腕前;

		public EleI EI腿;

		public HashSet<EleI> eis = new HashSet<EleI>();

		public bool Is髪;

		public bool Is胸;

		public bool Is腰;

		public bool Is腕前;

		public bool Is半後;

		public bool Is半中1;

		public bool Is半中2;

		public bool Is半前;

		public bool Is腿;

		public bool Is双眉;

		public bool Is単眉;

		public bool Is瞼宇;

		public bool Is人耳;

		public bool Is獣耳;

		public bool Is頭頂_宇;

		public bool Is虫角;

		public bool Is虫角前;

		public bool Is鬼角;

		public bool Is貧乳;

		public bool Is半身;

		public bool Is獣;

		public bool Is蛇;

		public bool Is魚;

		public bool Is鯨;

		public bool Is蜘;

		public bool Is蠍;

		public bool Is蛸;

		public bool Is蟲;

		public bool Is植;

		public bool Is粘;

		public bool Is長物;

		public bool Is海洋;

		public bool Is多足;

		public bool Is頭頂;

		public bool Is顔面;

		public bool Is大顎基;

		public bool Is額角;

		public bool Is触覚;

		public bool Is触覚他;

		public bool Is触覚甲;

		public bool Is蜘尾;

		public bool Is双眼;

		public bool Is単眼;

		public bool Is頬眼;

		public bool Is額眼;

		public bool Is舌股;

		public bool Is最前腕人;

		public bool Is最前手人;

		public bool Is腕人;

		public bool Is腕鳥;

		public bool Is腕蝙;

		public bool Is腕獣;

		public bool Is腕蠍;

		public bool Is腿人;

		public bool Is腿獣;

		public bool Is腿魚;

		public bool Is腿犬;

		private Action<Are> Draw = delegate(Are a)
		{
		};

		public bool 処女喪失;

		public 膣基 膣基;

		public 膣内精液 膣内精液;

		public 断面 断面;

		public 性器 性器;

		public 性器精液 性器精液;

		public 飛沫 飛沫;

		public 潮吹_小 潮吹_小;

		public 潮吹_大 潮吹_大;

		public 放尿 放尿;

		public 肛門 肛門;

		public 肛門精液 肛門精液;

		public 尾_蜘 蜘尾;

		public 染み_人 染み_人;

		public 染み_獣 染み_獣;

		private double 体紅潮_;

		private double 子宮下がり_;

		private double 肛門y;

		private double 肛門v;

		private double 肛門開き_;

		private double r8 = 0.004.Pow(2.0);

		private double r10 = 0.005.Pow(2.0);

		private double r17 = 0.00875.Pow(2.0);

		private double r35 = 0.0175.Pow(2.0);

		public bool 腕左右前後;

		private bool[] nsl;

		private bool[] nsr;

		private bool 腕左前後_;

		private bool 腕右前後_;

		public bool 胸左右前後;

		public bool 腿左右前後;

		private int 腰_人y;

		private int 腰_獣y;

		private 髪留2情報 後髪髪留i;

		private 髪留2情報 横髪髪留i;

		private 玉口枷情報 玉口枷i;

		private 目隠帯情報 目隠帯i;

		private 拘束具情報 拘束具i;

		private ピアス情報 ピアスi;

		private ピアス情報 ピアス左i;

		private ピアス情報 ピアス右i;

		private キャップ情報 キャップ1i;

		private キャップ情報 キャップ2左i;

		private キャップ情報 キャップ2右i;

		private ドレス首情報 ドレス首i;

		private 下着T_チュ\u30FCブ情報 下着T_チュ\u30FCブi;

		private 下着T_クロス情報 下着T_クロスi;

		private 下着T_ビキニ情報 下着T_ビキニi;

		private 下着T_マイクロ情報 下着T_マイクロi;

		private 下着T_ブラ情報 下着T_ブラi;

		private 下着B_ノ\u30FCマル情報 下着B_ノ\u30FCマルi;

		private 下着B_マイクロ情報 下着B_マイクロi;

		private ドレス情報 ドレスi;

		private 上着B_クロス情報 上着B_クロスi;

		private 上着B_前掛け情報 上着B_前掛けi;

		private ブ\u30FCツ情報 ブ\u30FCツi;

		public int 腕人n;

		public int 腕翼鳥n;

		public int 腕翼獣n;

		public int 腕獣n;

		public int 脚人n;

		public int 脚獣n;

		public int 翼鳥n;

		public int 翼獣n;

		public int 鰭n;

		public int 葉n;

		public int 前翅1n;

		public int 後翅1n;

		public int 前翅2n;

		public int 後翅2n;

		public int 触肢蜘n;

		public int 触肢蠍n;

		public int 節足蜘n;

		public int 節足蠍n;

		public int 節足百n;

		public int 節尾曳n;

		public int 節尾鋏n;

		public int 大顎n;

		public int 虫顎n;

		public int 虫鎌n;

		public int 触手n;

		public int 触手犬n;

		public int 尾n;

		public int 長胴n;
	}
}
