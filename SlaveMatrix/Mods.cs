using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using SlaveMatrix.Properties;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public static class Mods
	{
		public static Dictionary<string, Mod> GetMods(Med Med)
		{
			Sta.LoadConfig();
			Sta.タイル準備();
			Sta.Set擬音();
			Sta.Set喘ぎ();
			Mods.da = new Are(Med, false);
			Mods.da.Setting();
			Mods.描画バッファ = new Are(Med, true);
			Mods.描画バッファ.Setting();
			Mods.黒背景 = new Are(Med, true);
			Mods.黒背景.Setting();
			Mods.黒背景.Clear(Col.Black);
			Mods.地下室背景 = new Are(Med, true);
			Mods.地下室背景.Setting();
			using (Bitmap dangeon01_ex = Resources.dangeon01_ex2)
			{
				Mods.地下室背景.GD.DrawImage(dangeon01_ex, Mods.地下室背景.Dis.GetRect());
			}
			Mods.事務室背景 = new Are(Med, true);
			Mods.事務室背景.Setting();
			using (Bitmap li_room10a_c_ex = Resources.li_room10a_c_ex2)
			{
				Mods.事務室背景.GD.DrawImage(li_room10a_c_ex, Mods.事務室背景.Dis.GetRect());
			}
			Mods.セ\u30FCブデ\u30FCタ = new ListView(Mods.描画バッファ, Dat.Vec2DZero.AddY(0.0025), 0.25, new Font("MS Gothic", 1f), 0.11, Col.White, Col.Empty, Col.Black, Col.Empty, Enumerable.Repeat<TA>(new TA(new string('A', 15), delegate(But b)
			{
			}), 10).ToArray<TA>());
			Mods.セ\u30FCブデ\u30FCタ.SetHitColor(Med);
			Mods.dbs = new Buts();
			ParT parT = new ParT();
			double y = 0.9075;
			if (Program.biggerWindow)
			{
				y = 0.932;
			}
			parT.Font = new Font("MS Gothic", 0.1f);
			parT.PositionBase = Mods.描画バッファ.GetPosition(-0.001, y);
			parT.Text = "Player";
			parT.FontSize = 0.14;
			parT.SizeBase = 0.05;
			parT.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT.OP.ScalingXY(parT.OP.GetCenter(), 0.87, 0.23);
			parT.Closed = true;
			parT.TextColor = Col.White;
			parT.BrushColor = Color.FromArgb(160, Col.Black);
			parT.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT.StringFormat.Alignment = StringAlignment.Center;
			parT.StringFormat.LineAlignment = StringAlignment.Center;
			Action <>9__7;
			Action <>9__6;
			Mods.dbs.Add("プレイヤー", new But1(parT, delegate(But a)
			{
				if (Sta.GameData.所持金 < 10000000UL)
				{
					Mods.ip.SubInfoIm = tex.所持金が足りません;
					return;
				}
				Sou.精算.Play();
				Sta.GameData.所持金 -= 10000000UL;
				Mods.ip.UpdateSub2();
				TaskFactory factory = Task.Factory;
				Action action;
				if ((action = <>9__6) == null)
				{
					action = (<>9__6 = delegate()
					{
						Thread.Sleep(50);
						Med med = Med;
						Action a;
						if ((a = <>9__7) == null)
						{
							a = (<>9__7 = delegate()
							{
								Med.映転("情報設定", Mods.描画バッファ, Mods.情報設定描画);
							});
						}
						med.InvokeL(a);
					});
				}
				factory.StartNew(action);
			}));
			ParT parT2 = new ParT();
			parT2.Font = new Font("MS Gothic", 0.1f);
			double x = 0.699;
			if (Program.biggerWindow)
			{
				x = 0.77;
			}
			parT2.PositionBase = Mods.描画バッファ.GetPosition(x, y);
			parT2.Text = "Title";
			parT2.FontSize = 0.14;
			parT2.SizeBase = 0.05;
			parT2.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT2.OP.ScalingXY(parT2.OP.GetCenter(), 0.87, 0.23);
			parT2.Closed = true;
			parT2.TextColor = Col.White;
			parT2.BrushColor = Color.FromArgb(160, Col.Black);
			parT2.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT2.StringFormat.Alignment = StringAlignment.Center;
			parT2.StringFormat.LineAlignment = StringAlignment.Center;
			Action<But> <>9__8;
			Mods.dbs.Add("タイトル", new But1(parT2, delegate(But a)
			{
				Sou.操作.Play();
				string tb = (Mods.ip.TextIm == "") ? " " : Mods.ip.TextIm;
				bool sb = Mods.ip.MaiShow;
				Mods.ip.MaiShow = true;
				Mods.ip.TextIm = tex.タイトル画面に戻りますか;
				情報パネル 情報パネル = Mods.ip;
				Action<But> 選択yAct;
				if ((選択yAct = <>9__8) == null)
				{
					選択yAct = (<>9__8 = delegate(But b)
					{
						Sou.操作.Play();
						Med.Mode = "Title";
						Color empty = Col.Empty;
						Mods.dbs.Move(ref empty);
						Mods.ip.選択肢表示 = false;
					});
				}
				情報パネル.選択yAct = 選択yAct;
				Mods.ip.選択nAct = delegate(But b)
				{
					Sou.操作.Play();
					Mods.ip.TextIm = tb;
					Mods.ip.MaiShow = sb;
					Color empty = Col.Empty;
					Mods.dbs.Move(ref empty);
					Mods.ip.選択肢表示 = false;
				};
				Mods.ip.選択肢表示 = true;
			}));
			ParT parT3 = new ParT();
			parT3.Font = new Font("MS Gothic", 0.1f);
			x = 0.895;
			if (Program.biggerWindow)
			{
				x = 0.92;
			}
			parT3.PositionBase = Mods.描画バッファ.GetPosition(x, y);
			parT3.Text = "Save";
			parT3.FontSize = 0.14;
			parT3.SizeBase = 0.05;
			parT3.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT3.OP.ScalingXY(parT3.OP.GetCenter(), 0.87, 0.23);
			parT3.Closed = true;
			parT3.TextColor = Col.White;
			parT3.BrushColor = Color.FromArgb(160, Col.Black);
			parT3.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT3.StringFormat.Alignment = StringAlignment.Center;
			parT3.StringFormat.LineAlignment = StringAlignment.Center;
			Mods.dbs.Add("セーブ", new But1(parT3, delegate(But a)
			{
				Sou.操作.Play();
				Mods.セ\u30FCブデ\u30FCタ.bs["0"].Dra = false;
				Mods.save = true;
				Mods.SetSLlv(Med);
				Color empty = Col.Empty;
				Mods.セ\u30FCブデ\u30FCタ.Move(ref empty);
				Mods.SDShow = true;
				Mods.ip.SubInfoIm = "RCl:" + tex.戻る;
			}));
			ParT parT4 = new ParT();
			parT4.Font = new Font("MS Gothic", 0.1f);
			x = 0.797;
			if (Program.biggerWindow)
			{
				x = 0.845;
			}
			parT4.PositionBase = Mods.描画バッファ.GetPosition(x, y);
			parT4.Text = "Load";
			parT4.FontSize = 0.14;
			parT4.SizeBase = 0.05;
			parT4.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT4.OP.ScalingXY(parT4.OP.GetCenter(), 0.87, 0.23);
			parT4.Closed = true;
			parT4.TextColor = Col.White;
			parT4.BrushColor = Color.FromArgb(160, Col.Black);
			parT4.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT4.HitColor = Med.GetUniqueColor();
			parT4.StringFormat.Alignment = StringAlignment.Center;
			parT4.StringFormat.LineAlignment = StringAlignment.Center;
			Mods.dbs.Add("ロード", new But1(parT4, delegate(But a)
			{
				Sou.操作.Play();
				Mods.セ\u30FCブデ\u30FCタ.bs["0"].Dra = true;
				Mods.save = false;
				Mods.title = false;
				Mods.SetSLlv(Med);
				Color empty = Col.Empty;
				Mods.セ\u30FCブデ\u30FCタ.Move(ref empty);
				Mods.SDShow = true;
				Mods.ip.SubInfoIm = "RCl:" + tex.戻る;
			}));
			Mods.NewButtons(Med);
			Mods.dbs.SetHitColor(Med);
			Mods.ip = new 情報パネル(Med, Mods.描画バッファ);
			Mods.ip.SetHitColor(Med);
			Mods.ヴィオラ吹出し = new 吹き出し(Mods.描画バッファ, false, new Font("MS Gothic", 1f), 0.08, " ", Col.White, Col.Black, Color.FromArgb(160, Col.Black), 19.0, false, Col.White, delegate(Tex sp)
			{
			});
			Mods.ヴィオラ吹出し.SetHitColor(Med);
			Mods.キャラ吹出し = new 吹き出し(Mods.描画バッファ, false, new Font("MS Gothic", 1f), 0.08, " ", Col.White, Col.Black, Color.FromArgb(160, Col.Black), 19.0, true);
			Mods.キャラ吹出し.SetHitColor(Med);
			Mods.si = new SubInnfo(Med, Mods.ip);
			Mods.ヴィオラ台詞 = new ヴィオラ台詞(Med, Mods.ヴィオラ吹出し);
			Mods.キャラ台詞 = new キャラ台詞(Med, Mods.キャラ吹出し);
			double size = 0.1;
			if (Sta.BigWindow && !Sta.NoScaling)
			{
				size = 0.15;
			}
			Mods.npl = new Lab(Med, Mods.描画バッファ, "ラベル1", new Vector2D(Mods.ip.MaiB.Position.X, 0.026), size, 1.5, new Font("MS Gothic", 1f), 0.085, "No Slave", Col.White, Col.Black, Mods.ip.MaiB.BrushColor, Col.Black, false);
			return new Dictionary<string, Mod>
			{
				{
					"Start",
					Mods.Start(Med)
				},
				{
					"Credit",
					Mods.Credit(Med)
				},
				{
					"Title",
					Mods.Title(Med)
				},
				{
					"メインフォーム",
					Mods.メインフォ\u30FCム(Med)
				},
				{
					"対象",
					Mods.対象(Med)
				},
				{
					"調教",
					Mods.調教(Med)
				},
				{
					"祝福",
					Mods.祝福(Med)
				},
				{
					"事務所",
					Mods.事務所(Med)
				},
				{
					"借金",
					Mods.借金(Med)
				},
				{
					"奴隷購入",
					Mods.奴隷購入(Med)
				},
				{
					"道具購入",
					Mods.道具購入(Med)
				},
				{
					"調教中継行",
					Mods.調教中継行(Med)
				},
				{
					"調教中継帰",
					Mods.調教中継帰(Med)
				},
				{
					"日数進行",
					Mods.日数進行(Med)
				},
				{
					"情報設定",
					Mods.情報設定(Med)
				},
				{
					"OP0",
					Mods.OP0(Med)
				},
				{
					"OP1",
					Mods.OP1(Med)
				},
				{
					"説明",
					Mods.説明(Med)
				},
				{
					"初事務所",
					Mods.初事務所(Med)
				},
				{
					"返済イベント1",
					Mods.返済イベント1(Med)
				},
				{
					"返済イベント2",
					Mods.返済イベント2(Med)
				},
				{
					"返済イベント3",
					Mods.返済イベント3(Med)
				},
				{
					"ヴィオラ祝福",
					Mods.ヴィオラ祝福(Med)
				}
			};
		}

		public static void Dispose()
		{
			Mods.da.Dispose();
			Mods.描画バッファ.Dispose();
			Mods.黒背景.Dispose();
			Mods.地下室背景.Dispose();
			Mods.事務室背景.Dispose();
			if (Mods.調教対象 != null)
			{
				Mods.調教対象.Dispose();
			}
			Mods.キャラ吹出し.Dispose();
			if (Mods.ヴィオラ != null)
			{
				Mods.ヴィオラ.Dispose();
			}
			Mods.ヴィオラ吹出し.Dispose();
			Mods.セ\u30FCブデ\u30FCタ.Dispose();
			Mods.ip.Dispose();
			Mods.dbs.Dispose();
			Mods.npl.Dispose();
		}

		private static void 映転(Med Med, Are Are, FPS FPS, Action<Are, FPS> 描画)
		{
			if (Mods.sta)
			{
				if (Mods.v >= Mods.mv.Max)
				{
					Mods.sta = false;
					Mods.v = 0.0;
					Mods.mv.ResetValue();
					return;
				}
				Mods.mv.GetValue(FPS);
				Mods.v = Mods.mv.Value;
				if (Mods.sta)
				{
					Med.TransA(Mods.v);
					return;
				}
			}
			else
			{
				描画(Are, FPS);
			}
		}

		public static void 映転(this Med Med, string Mode, Are Are)
		{
			Med.Mode = Mode;
			Med.DrawSta(Are);
			Med.DrawEnd(Mods.黒背景);
			Mods.sta = true;
		}

		public static void 映転(this Med Med, string Mode, Are Are, Action<Are, FPS> 描画)
		{
			Med.Mode = Mode;
			描画(Mods.da, Med.FPSF);
			Med.DrawSta(Are);
			Med.DrawEnd(Mods.da);
			Mods.sta = true;
		}

		public static void Set需給最大幅()
		{
			if (Sta.GameData.返済段階 == 0)
			{
				Mods.需給最大幅 = 8.0;
				return;
			}
			if (Sta.GameData.返済段階 == 1)
			{
				Mods.需給最大幅 = 9.0;
				return;
			}
			if (Sta.GameData.返済段階 == 2)
			{
				Mods.需給最大幅 = 10.0;
				return;
			}
			Mods.需給最大幅 = 11.0;
		}

		public static ulong 加算(this ulong u0, ulong u1)
		{
			checked
			{
				ulong result;
				try
				{
					if (u0 + u1 > 9999999999999UL)
					{
						result = 9999999999999UL;
					}
					else
					{
						result = u0 + u1;
					}
				}
				catch
				{
					result = 9999999999999UL;
				}
				return result;
			}
		}

		public static ulong 減算(this ulong u0, ulong u1)
		{
			if (u0 < u1)
			{
				return 0UL;
			}
			return u0 - u1;
		}

		public static void SetSLlv(Med Med)
		{
			Mods.セ\u30FCブデ\u30FCタ.Acts = Mods.sllv(Med);
		}

		private static IEnumerable<TA> sllv(Med Med)
		{
			int k = 0;
			string[] array = Sta.SDPaths();
			for (int j = 0; j < array.Length; j++)
			{
				string path2 = array[j];
				string path = path2;
				int i = k;
				bool f = path == null;
				yield return new TA(f ? (i + ": No data") : Path.GetFileNameWithoutExtension(path).Replace("：", ":").Replace("_", "/"), delegate(But b)
				{
					if (!Mods.processing)
					{
						Sou.操作.Play();
						if (Mods.save)
						{
							Mods.processing = true;
							Mods.Save(path, i, Med);
							return;
						}
						if (!f)
						{
							Mods.processing = true;
							Mods.Load(path, i, Med);
						}
					}
				});
				int num = k;
				k = num + 1;
			}
			array = null;
			yield break;
		}

		private static void AutoSave()
		{
			string s = Sta.SavePath + "\\0： ";
			IEnumerable<string> source = Directory.EnumerateFiles(Sta.SavePath);
			Func<string, bool> <>9__0;
			Func<string, bool> predicate;
			if ((predicate = <>9__0) == null)
			{
				predicate = (<>9__0 = ((string e) => e.StartsWith(s)));
			}
			foreach (string file in source.Where(predicate))
			{
				FileSystem.DeleteFile(file);
			}
			Sta.GDSave(0);
		}

		private static void Save(string Path, int i, Med Med)
		{
			Mods.ip.SubInfoIm = tex.セ\u30FCブ中です + "\r\n" + tex.しばらくお待ちください;
			Task.Factory.StartNew(delegate()
			{
				if (Path != null)
				{
					FileSystem.DeleteFile(Path);
				}
				Sta.GDSave(i);
				Mods.SetSLlv(Med);
				Mods.SDShow = false;
				Mods.ip.SubInfoIm = string.Concat(new object[]
				{
					i,
					": ",
					Sta.GameData.GetSaveDateString(),
					"\r\n",
					tex.セ\u30FCブしました
				});
				Mods.processing = false;
				Med.InvokeL(new Action(Sou.完了.Play));
			});
		}

		private static void Load(string Path, int i, Med Med)
		{
			Mods.cts.Cancel();
			Mods.ip.SubInfoIm = tex.ロ\u30FCド中です + "\r\n" + tex.しばらくお待ちください;
			Task.Factory.StartNew(delegate()
			{
				if (!Sta.DecryptLoad)
				{
					Sta.GameData = Path.LoadExMod<GameState>();
				}
				else
				{
					Sta.GameData = Path.LoadEx<GameState>();
				}
				Cha d = Mods.ヴィオラ;
				Mods.ヴィオラ = new Cha(Med, Mods.描画バッファ, Sta.GameData.ヴィオラ.ChaD);
				Mods.ヴィオラ.Set衣装(Sta.GameData.ヴィオラ.着衣);
				Mods.ヴィオラ吹出し.接続(Mods.ヴィオラ.Bod.頭.口_接続点);
				Med.InvokeL(delegate
				{
					Mods.初期化処理();
					if (d != null)
					{
						d.Dispose();
					}
					if (Mods.調教対象 != null)
					{
						Mods.調教対象.Dispose();
						Mods.調教対象 = null;
					}
					Mods.SDShow = false;
					if (Mods.title)
					{
						Med.映転("メインフォーム", Mods.描画バッファ, Mods.メインフォ\u30FCム描画);
					}
					else
					{
						Med.Mode = "メインフォーム";
						Mods.ip.SubInfoIm = string.Concat(new object[]
						{
							i,
							": ",
							Sta.GameData.GetSaveDateString(),
							"\r\n",
							tex.ロ\u30FCドしました
						});
					}
					Mods.processing = false;
					Mods.Set需給最大幅();
					if (Sta.GameData.地下室.Length < Mods.最大部屋数)
					{
						Unit[] array = new Unit[Mods.最大部屋数];
						Array.Copy(Sta.GameData.地下室, array, Sta.GameData.地下室.Length);
						Sta.GameData.地下室 = array;
					}
					Med.InvokeL(new Action(Sou.完了.Play));
				});
			});
		}

		private static void 初期化処理()
		{
			Mods.ロ\u30FCド時初期化();
			Mods.対象UI初期化();
			Mods.奴隷UI初期化();
		}

		private static void al(string s, int i)
		{
			string[] array = Mods.日終了ログa;
			array[i] = array[i] + s + "\r\n";
		}

		public static void 日終了()
		{
			Act.精力回復();
			Act.精力回復();
			Sta.GameData.日借金額 = 0UL;
			Mods.労働利益 = 0UL;
			Mods.日利益額 = 0UL;
			Mods.日利子額 = Sta.GameData.利子額;
			Mods.日終了ログa = new string[Mods.最大部屋数];
			int num = 0;
			foreach (Unit unit in Sta.GameData.地下室)
			{
				if (unit != null)
				{
					unit.体力回復();
					unit.体力回復();
					unit.ChaD.現陰毛 = (unit.ChaD.現陰毛 + 0.05).LimitM(0.0, 1.0);
					int num2 = (unit.妊娠進行期間 > 0) ? unit.妊娠進行期間 : 1;
					bool flag = Sta.GameData.日数 % (ulong)((long)(num2 * 2)) == 0UL;
					if (unit.発情フラグ && flag && !unit.ChaD.タトゥ)
					{
						unit.発情フラグ = false;
					}
					else if (flag)
					{
						unit.発情フラグ = true;
					}
					checked
					{
						if (unit.妊娠フラグ)
						{
							if (unit.非妊娠)
							{
								Mods.al(string.Concat(new string[]
								{
									tex.収容番号,
									unit.Number,
									"/",
									unit.Name,
									tex.が妊娠しました,
									(unit.一般労働 || unit.娼婦労働) ? ("\r\n" + tex.労働が解除されます) : ""
								}), num);
								unit.非妊娠 = false;
							}
							if (Sta.GameData.日数 % (ulong)(unchecked((long)num2)) == 0UL)
							{
								if (unit.妊娠状態変数 == 4)
								{
									unit.体力消費();
									unit.体力消費();
									unit.体力消費();
									Mods.al(string.Concat(new string[]
									{
										tex.収容番号,
										unit.Number,
										"/",
										unit.Name,
										tex.が出産しました
									}), num);
									if (Sta.GameData.Is地下室一杯())
									{
										ulong price = unit.子.GetPrice();
										Mods.al(tex.収容できないので子は売却されます + "+" + price.ToString("#,0"), num);
										try
										{
											Mods.日利益額 += price;
											goto IL_270;
										}
										catch
										{
											Mods.日利益額 = 9999999999999UL;
											goto IL_270;
										}
										goto IL_254;
									}
									goto IL_254;
									IL_270:
									unit.子 = null;
									unit.妊娠状態変数 = -1;
									unit.ChaD.現乳房 = 0.0;
									unit.妊娠フラグ = false;
									unit.非妊娠 = true;
									goto IL_3E8;
									IL_254:
									Mods.al(tex.子を奴隷として収容します, num);
									Sta.GameData.Add地下室(unit.子);
									goto IL_270;
								}
								unchecked
								{
									unit.妊娠状態変数++;
									unit.ChaD.現乳房 += 0.2;
								}
							}
						}
						else if (unit.調教済フラグ && unit.Is増殖可 && unit.ChaD.体力 == 1.0 && 0.3.Lot())
						{
							unit.体力消費();
							unit.体力消費();
							unit.体力消費();
							Mods.al(string.Concat(new string[]
							{
								tex.収容番号,
								unit.Number,
								"/",
								unit.Name,
								tex.が増殖しました
							}), num);
							if (Sta.GameData.Is地下室一杯())
							{
								ulong price2 = unit.GetPrice();
								Mods.al(tex.収容できないので子は売却されます + "+" + price2.ToString("#,0"), num);
								try
								{
									Mods.日利益額 += price2;
									goto IL_3E8;
								}
								catch
								{
									Mods.日利益額 = 9999999999999UL;
									goto IL_3E8;
								}
							}
							Mods.al(tex.子を奴隷として収容します, num);
							Sta.GameData.Add地下室(unit.DeepCopy<Unit>().増殖時Reset());
						}
						IL_3E8:
						if (unit.非妊娠)
						{
							try
							{
								if (unit.一般労働)
								{
									Mods.労働利益 += (ulong)unchecked(500000.0 * ((double)unit.種族情報.一般 / 9.0) * (double)unit.一般労働Count * unit.一般労働倍率()).RoundDown(0);
								}
								else if (unit.娼婦労働)
								{
									Mods.労働利益 += (ulong)unchecked(unit.GetPrice() * 0.012 * ((double)unit.種族情報.娼婦 / 9.0 + unit.ChaD.欲望度 + unit.ChaD.情愛度 + unit.ChaD.卑屈度 + unit.ChaD.技巧度) * (double)unit.娼婦労働Count * unit.娼婦労働倍率() * (unit.処女フラグ ? 0.4 : 1.0)).RoundDown(0);
								}
							}
							catch
							{
								Mods.労働利益 = 9999999999999UL;
							}
						}
						unit.一般労働Count = 0;
						unit.娼婦労働Count = 0;
					}
				}
				num++;
			}
			checked
			{
				try
				{
					Mods.日利益額 += Mods.労働利益;
				}
				catch
				{
					Mods.日利益額 = 9999999999999UL;
				}
				Mods.dayp = false;
				Sta.GameData.新日 = true;
			}
		}

		public static void 時進行()
		{
			Act.精力回復();
			Parallel.ForEach<Unit>(Sta.GameData.地下室, Sta.po3, delegate(Unit u)
			{
				if (u != null)
				{
					if (u.非妊娠 && u.一般労働 && u.ChaD.体力 > 0.333)
					{
						u.一般労働Count++;
						u.体力消費();
						u.種族情報.一般成長(u.一般最大加算値);
						return;
					}
					if (u.非妊娠 && u.娼婦労働 && u.ChaD.体力 > 0.333)
					{
						u.娼婦労働Count++;
						u.体力消費();
						u.種族情報.娼婦成長(u.娼婦最大加算値);
						u.ChaD.娼婦調教(u.技巧最大値);
						if (!u.妊娠フラグ && (0.002 * (u.発情フラグ ? 1.5 : 1.0) * ((u.種族 == tex.エキドナ) ? 2.0 : 1.0)).Lot())
						{
							u.処女フラグ = false;
							u.娼婦妊娠();
							return;
						}
					}
					else
					{
						u.体力回復();
					}
				}
			});
		}

		private static void 並列処理()
		{
			Mods.日終了();
			Mods.AutoSave();
		}

		public static bool 時間進行(Med Med)
		{
			bool flag = Sta.GameData.時間帯 == tex.夜;
			Mods.時進行();
			if (flag)
			{
				while (Mods.dayp)
				{
				}
				Mods.dayp = true;
				Mods.cts.Cancel();
				Sta.GameData.Refresh = false;
				Mods.cts = new CancellationTokenSource();
				Mods.t1 = Task.Factory.StartNew(new Action(Mods.並列処理), Mods.cts.Token);
				Med.映転("日数進行", Mods.描画バッファ, Mods.日数進行描画);
			}
			else
			{
				Sta.GameData.時間進行();
			}
			return flag;
		}

		public static void 日付進行(Med Med)
		{
			while (!Mods.時間進行(Med))
			{
			}
		}

		public static void ロ\u30FCド時初期化()
		{
			while (Mods.dayp)
			{
			}
			Mods.cts.Cancel();
			Sta.GameData.Refresh = false;
		}

		public static void 妊娠状態反映()
		{
			if (Sta.GameData.調教対象.妊娠状態変数 > -1)
			{
				Mods.調教対象.Bod.ボテ腹i = Sta.GameData.調教対象.妊娠状態変数;
				Mods.調教対象.Bod.ボテ腹_表示 = true;
				if (!Mods.調教対象.Bod.Is獣)
				{
					Mods.調教対象.Bod.ボテ腹_人.ハイライト表示 = (Sta.GameData.調教対象.妊娠状態変数 > 2);
				}
			}
			else
			{
				Mods.調教対象.Bod.ボテ腹i = 0;
				Mods.調教対象.Bod.ボテ腹_表示 = false;
			}
			Mods.調教対象.Bod.断面_表示 = Mods.調教対象.Bod.断面_表示;
			Mods.調教対象.Bod.変動ステ\u30FCト更新();
		}

		public static void Setnpl(Unit u)
		{
			Mods.npl.Text = tex.収容番号 + u.Number + "\r\n" + (Sta.AlwaysUseName ? u.Name : (u.調教済フラグ ? u.Name : u.種族));
		}

		public static void Res調教対象()
		{
			Act.Cha = Mods.調教対象;
			Act.SetState();
			Act.表示ステ\u30FCト更新();
			Act.ModBox();
			Act.SensBox();
			Mods.妊娠状態反映();
			Mods.調教対象.Set表情初期化();
			Mods.調教対象.情動();
			Mods.調教対象.Set表情変化();
			Mods.調教対象.口修正();
			if (Sta.GameData.調教対象.調教済フラグ)
			{
				Mods.調教対象.Bod.拘束具_表示 = false;
				Mods.調教対象.Bod.首輪_表示 = true;
				Mods.調教対象.Set基本姿勢();
			}
			else
			{
				Mods.調教対象.Bod.拘束具_表示 = true;
				Mods.調教対象.Set拘束姿勢();
			}
			if (Sta.GameData.調教対象.ChaD.胸施術)
			{
				Mods.調教対象.Bod.胸施術();
			}
			if (Sta.GameData.調教対象.ChaD.股施術)
			{
				Mods.調教対象.Bod.股施術();
			}
			if (Sta.GameData.調教対象.ChaD.タトゥ)
			{
				Mods.調教対象.Bod.タトゥ();
			}
			if (Sta.GameData.調教対象.着衣 != null)
			{
				Mods.調教対象.Set衣装(Sta.GameData.調教対象.着衣);
			}
			Mods.調教対象.Bod.Join();
			Mods.調教対象.Bod.Update();
		}

		public static void Set調教対象(Med Med, Unit u)
		{
			Sta.GameData.調教対象 = u;
			if (Mods.調教対象 != null)
			{
				Mods.調教対象.Dispose();
			}
			Mods.調教対象 = new Cha(Med, Mods.描画バッファ, Sta.GameData.調教対象.ChaD);
			Mods.キャラ吹出し.接続(Mods.調教対象.Bod.頭.口_接続点);
			Mods.Setnpl(u);
			double d = (u.調教済フラグ && Sta.MoveInsectMask) ? 1.0 : 0.0;
			if (Mods.調教対象.Bod.Is顔面)
			{
				Mods.調教対象.Bod.頭.顔面_接続.SetEle(delegate(顔面 顔面)
				{
					顔面.展開0 = d;
					顔面.展開1 = d;
				});
				Mods.調教対象.Bod.頭.大顎基_接続.SetEle(delegate(大顎基 大顎)
				{
					大顎.展開 = d;
				});
				Mods.調教対象.Bod.頭.額_接続.SetEle(delegate(角1_虫 虫角)
				{
					虫角.展開 = d;
				});
			}
			Mods.Res調教対象();
		}

		public static void 対象状態初期化()
		{
			Act.SetState();
			Mods.調教対象.泣き = false;
			if (Mods.調教対象.Bod.鼻水左 != null)
			{
				Mods.調教対象.Bod.鼻水左.表示 = false;
				Mods.調教対象.Bod.鼻水右.表示 = false;
			}
			if (Mods.調教対象.Bod.涎左 != null)
			{
				Mods.調教対象.Bod.涎左.表示 = false;
				Mods.調教対象.Bod.涎右.表示 = false;
			}
			Mods.調教対象.Bod.噴乳左.表示 = false;
			Mods.調教対象.Bod.噴乳右.表示 = false;
			Mods.調教対象.噴乳染み = 0.0;
			Mods.調教対象.Bod.下着T染み = 0.0;
			Mods.調教対象.Set表情初期化();
			Mods.調教対象.情動();
			Mods.調教対象.Set表情変化();
			if (Sta.GameData.調教対象.調教済フラグ)
			{
				Mods.調教対象.Set基本姿勢();
			}
			else
			{
				Mods.調教対象.Set拘束姿勢();
			}
			Act.表示ステ\u30FCト更新();
			Act.ModBox();
			Act.SensBox();
		}

		public static void Player説明(ref Color hc, Action Reset)
		{
			if (Mods.dbs["プレイヤー"].Pars.Values.First<object>().ToPar().HitColor == hc)
			{
				Mods.ip.SubInfoIm = tex.プレイヤ\u30FCの遺伝情報を設定します + "(-" + 10000000UL.ToString("#,0") + ")";
				return;
			}
			if (Mods.ip.SubInfoIm == tex.プレイヤ\u30FCの遺伝情報を設定します + "(-" + 10000000UL.ToString("#,0") + ")")
			{
				Reset();
			}
		}

		public static int 最大部屋数
		{
			get
			{
				return 135;
			}
		}

		public static void フラッシュ(this Med Med)
		{
			Mods.調教描画(Mods.da, Med.FPSF);
			Med.ClearSta(Color.FromArgb(128, Color.White));
			Med.DrawEnd(Mods.da);
			Mods.sta = true;
		}

		public static Mod Start(Med Med)
		{
			Action <>9__2;
			return new Mod
			{
				Setting = delegate()
				{
					TaskFactory factory = Task.Factory;
					Action action;
					if ((action = <>9__2) == null)
					{
						action = (<>9__2 = delegate()
						{
							Thread.Sleep(900);
							if (Med.Mode != "Credit")
							{
								Med.Mode = "Credit";
							}
						});
					}
					factory.StartNew(action);
				},
				Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
				{
					Med.Mode = "Credit";
				}
			};
		}

		public static Mod Credit(Med Med)
		{
			Mods.<>c__DisplayClass92_0 CS$<>8__locals1 = new Mods.<>c__DisplayClass92_0();
			CS$<>8__locals1.Med = Med;
			Mod mod = new Mod();
			MotV mv = new MotV(0.0, 1.0)
			{
				BaseSpeed = 0.5
			};
			double v = 0.0;
			bool b1 = true;
			bool b2 = false;
			bool b3 = false;
			double num = 0.15;
			Lab l = new Lab(CS$<>8__locals1.Med, Mods.描画バッファ, "クレジット", Mods.描画バッファ.GetPosition(ref Shas.中央中央), num, 1.0, new Font("", 1f), 0.06, "Auto Eden Presents.", Col.White, Col.Empty, Col.Empty, Col.Empty, false);
			l.ParT.PositionBase -= new Vector2D(l.ParT.RectSize.X - 0.07, l.ParT.RectSize.Y * 3.0) * 0.5 * num;
			Action <>9__4;
			mod.Setting = delegate()
			{
				Mods.描画バッファ.Clear(Col.Black);
				Mods.描画バッファ.Draw(l.ParT);
				CS$<>8__locals1.Med.DrawSta(Mods.黒背景);
				CS$<>8__locals1.Med.DrawEnd(Mods.描画バッファ);
				v = 0.0;
				b1 = true;
				b2 = false;
				b3 = false;
				mv.ResetValue();
				TaskFactory factory = Task.Factory;
				Action action;
				if ((action = <>9__4) == null)
				{
					action = (<>9__4 = delegate()
					{
						while (!b3)
						{
						}
						if (CS$<>8__locals1.Med.Mode != "Title")
						{
							Med med = CS$<>8__locals1.Med;
							Action a;
							if ((a = CS$<>8__locals1.<>9__5) == null)
							{
								a = (CS$<>8__locals1.<>9__5 = delegate()
								{
									CS$<>8__locals1.Med.Mode = "Title";
								});
							}
							med.InvokeL(a);
						}
					});
				}
				factory.StartNew(action);
			};
			mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				v = 0.0;
				b1 = false;
				b2 = false;
				mv.ResetValue();
				CS$<>8__locals1.Med.Mode = "Title";
			};
			mod.Draw = delegate(FPS FPS)
			{
				if (b1 | b2)
				{
					if (v < mv.Max)
					{
						mv.GetValue(FPS);
						v = mv.Value;
						if (b1)
						{
							CS$<>8__locals1.Med.TransA(v);
						}
						if (b2)
						{
							CS$<>8__locals1.Med.TransD(v);
							return;
						}
					}
					else
					{
						if (b2)
						{
							v = 0.0;
							b2 = false;
							mv.ResetValue();
							CS$<>8__locals1.Med.Draw(Mods.黒背景);
						}
						if (b1)
						{
							v = 0.0;
							b1 = false;
							mv.ResetValue();
							CS$<>8__locals1.Med.Draw(Mods.描画バッファ);
							b2 = true;
							CS$<>8__locals1.Med.DrawSta(Mods.描画バッファ);
							CS$<>8__locals1.Med.DrawEnd(Mods.黒背景);
							return;
						}
					}
				}
				else
				{
					CS$<>8__locals1.Med.Draw(Mods.黒背景);
					b3 = true;
				}
			};
			mod.Dispose = delegate()
			{
				l.Dispose();
			};
			return mod;
		}

		public static Mod Title(Med Med)
		{
			Mods.<>c__DisplayClass93_0 CS$<>8__locals1 = new Mods.<>c__DisplayClass93_0();
			CS$<>8__locals1.Med = Med;
			Mod mod = new Mod();
			bool ll = false;
			MotV mv = new MotV(0.0, 1.0)
			{
				BaseSpeed = 0.5
			};
			double v = 0.0;
			bool b1 = true;
			double num = 0.2;
			Lab l = new Lab(CS$<>8__locals1.Med, Mods.描画バッファ, "タイトル", Mods.描画バッファ.GetPosition(ref Shas.中央中央), num, 1.0, new Font("", 1f), 0.07, "Slave Matrix", Col.White, Col.Empty, Col.Empty, Col.Empty, false);
			l.ParT.PositionBase -= new Vector2D(l.ParT.RectSize.X - 0.07, l.ParT.RectSize.Y * 3.0) * 0.5 * num;
			TA ta = new TA("Start", delegate(But b)
			{
				Sou.操作.Play();
				Sta.GameData.SetDefault();
				if (Mods.ヴィオラ != null)
				{
					Mods.ヴィオラ.Dispose();
				}
				if (Mods.調教対象 != null)
				{
					Mods.調教対象.Dispose();
					Mods.調教対象 = null;
				}
				Mods.初期化処理();
				Mods.start = true;
				Mods.Set需給最大幅();
				CS$<>8__locals1.Med.映転("情報設定", Mods.描画バッファ, Mods.情報設定描画);
			});
			TA ta2 = new TA("Load", delegate(But b)
			{
				Sou.操作.Play();
				Mods.セ\u30FCブデ\u30FCタ.bs["0"].Dra = true;
				Mods.save = false;
				Mods.title = true;
				Mods.SetSLlv(CS$<>8__locals1.Med);
				ll = true;
				Mods.ip.SubInfoIm = "RCl:" + tex.戻る;
			});
			TA[] acts = new TA[]
			{
				ta,
				ta2
			};
			ListView lv = new ListView(Mods.描画バッファ, l.ParT.PositionBase.MulXY(1.015, 1.2), 0.25, new Font("MS Gothic", 1f), 0.09, Col.White, Col.Empty, Col.Empty, Col.Empty, acts);
			lv.SetHitColor(CS$<>8__locals1.Med);
			mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				if (!Mods.processing)
				{
					if (mb == MouseButtons.Left)
					{
						if (ll)
						{
							Mods.セ\u30FCブデ\u30FCタ.Down(ref hc);
							return;
						}
						lv.Down(ref hc);
						return;
					}
					else if (ll && mb == MouseButtons.Right)
					{
						ll = false;
					}
				}
			};
			mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				if (!Mods.processing && mb == MouseButtons.Left)
				{
					if (ll)
					{
						Mods.セ\u30FCブデ\u30FCタ.Up(ref hc);
						return;
					}
					lv.Up(ref hc);
				}
			};
			mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				if (!Mods.processing)
				{
					Mods.セ\u30FCブデ\u30FCタ.Move(ref hc);
					lv.Move(ref hc);
				}
			};
			mod.Leave = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				if (!Mods.processing)
				{
					if (ll)
					{
						Mods.セ\u30FCブデ\u30FCタ.Leave();
						return;
					}
					lv.Leave();
				}
			};
			mod.Setting = delegate()
			{
				Mods.ip.MaiShow = false;
				Mods.ip.Mai2Show = false;
				Mods.ip.SubShow = true;
				Mods.ip.Sub2Show = false;
				ll = false;
				Mods.描画バッファ.Clear(Col.Black);
				Mods.描画バッファ.Draw(l.ParT);
				CS$<>8__locals1.Med.DrawSta(Mods.黒背景);
				CS$<>8__locals1.Med.DrawEnd(Mods.描画バッファ);
				v = 0.0;
				b1 = true;
				mv.ResetValue();
				Sou.日常BGM.Stop();
				Sou.OPBGM.Play();
			};
			mod.Draw = delegate(FPS FPS)
			{
				if (b1)
				{
					if (v >= mv.Max)
					{
						v = 0.0;
						b1 = false;
						mv.ResetValue();
						CS$<>8__locals1.Med.Draw(Mods.描画バッファ);
						return;
					}
					mv.GetValue(FPS);
					v = mv.Value;
					if (b1)
					{
						CS$<>8__locals1.Med.TransA(v);
						return;
					}
				}
				else
				{
					Mods.描画バッファ.Draw(Mods.黒背景);
					if (ll)
					{
						Mods.ip.Draw(Mods.描画バッファ, FPS);
						Mods.セ\u30FCブデ\u30FCタ.Draw(Mods.描画バッファ);
					}
					else
					{
						Mods.描画バッファ.Draw(l.ParT);
						lv.Draw(Mods.描画バッファ);
					}
					CS$<>8__locals1.Med.Draw(Mods.描画バッファ);
				}
			};
			mod.Dispose = delegate()
			{
				l.Dispose();
				lv.Dispose();
			};
			return mod;
		}

		public static Mod メインフォ\u30FCム(Med Med)
		{
			Mods.<>c__DisplayClass94_0 CS$<>8__locals1 = new Mods.<>c__DisplayClass94_0();
			CS$<>8__locals1.Med = Med;
			Mod mod = new Mod();
			Buts bs = new Buts();
			double sizeBase = 0.05;
			if (Sta.BigWindow && !Sta.NoScaling)
			{
				sizeBase = 0.068;
			}
			ParT parT = new ParT();
			parT.Font = new Font("MS Gothic", 0.1f);
			parT.PositionBase = Mods.描画バッファ.GetPosition(0.85, 0.02);
			parT.Text = tex.事務所;
			parT.FontSize = 0.15;
			parT.SizeBase = sizeBase;
			parT.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT.OP.ScalingY(parT.OP.GetCenter(), 0.47);
			parT.OP.Rotation(parT.OP.GetCenter(), -26.0);
			parT.Closed = true;
			parT.TextColor = Col.White;
			parT.BrushColor = Color.FromArgb(160, Col.Black);
			parT.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT.StringFormat.Alignment = StringAlignment.Center;
			parT.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("ボタン1", new But1(parT, delegate(But a)
			{
				Sou.操作.Play();
				CS$<>8__locals1.Med.映転("事務所", Mods.描画バッファ, Mods.事務所描画);
			}));
			ParT parT2 = new ParT();
			parT2.Font = new Font("MS Gothic", 0.1f);
			parT2.PositionBase = Mods.描画バッファ.GetPosition(0.85, 0.1);
			parT2.Text = tex.調教;
			parT2.FontSize = 0.15;
			parT2.SizeBase = sizeBase;
			parT2.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT2.OP.ScalingY(parT2.OP.GetCenter(), 0.47);
			parT2.OP.Rotation(parT2.OP.GetCenter(), -26.0);
			parT2.Closed = true;
			parT2.TextColor = Col.White;
			parT2.BrushColor = Color.FromArgb(160, Col.Black);
			parT2.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT2.StringFormat.Alignment = StringAlignment.Center;
			parT2.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("ボタン2", new But1(parT2, delegate(But bu)
			{
				Sou.操作.Play();
				CS$<>8__locals1.Med.映転("調教中継行", Mods.描画バッファ, Mods.中継描画);
			}));
			ParT parT3 = new ParT();
			parT3.Font = new Font("MS Gothic", 0.1f);
			parT3.PositionBase = Mods.描画バッファ.GetPosition(0.85, 0.18);
			parT3.Text = tex.対象;
			parT3.FontSize = 0.15;
			parT3.SizeBase = sizeBase;
			parT3.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT3.OP.ScalingY(parT3.OP.GetCenter(), 0.47);
			parT3.OP.Rotation(parT3.OP.GetCenter(), -26.0);
			parT3.Closed = true;
			parT3.TextColor = Col.White;
			parT3.BrushColor = Color.FromArgb(160, Col.Black);
			parT3.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT3.StringFormat.Alignment = StringAlignment.Center;
			parT3.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("ボタン3", new But1(parT3, delegate(But bu)
			{
				Sou.操作.Play();
				CS$<>8__locals1.Med.Mode = "対象";
			}));
			ParT parT4 = new ParT();
			parT4.Font = new Font("MS Gothic", 0.1f);
			parT4.PositionBase = Mods.描画バッファ.GetPosition(0.85, 0.26);
			parT4.Text = tex.休む;
			parT4.FontSize = 0.15;
			parT4.SizeBase = sizeBase;
			parT4.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT4.OP.ScalingY(parT4.OP.GetCenter(), 0.47);
			parT4.OP.Rotation(parT4.OP.GetCenter(), -26.0);
			parT4.Closed = true;
			parT4.TextColor = Col.White;
			parT4.BrushColor = Color.FromArgb(160, Col.Black);
			parT4.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT4.StringFormat.Alignment = StringAlignment.Center;
			parT4.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("ボタン4", new But1(parT4, delegate(But bu)
			{
				Sou.操作.Play();
				Mods.si.Set(true);
				Mods.時間進行(CS$<>8__locals1.Med);
				Mods.ip.UpdateSub2();
			}));
			ParT parT5 = new ParT();
			parT5.Font = new Font("MS Gothic", 0.1f);
			parT5.PositionBase = Mods.描画バッファ.GetPosition(0.85, 0.34);
			parT5.Text = tex.眠る;
			parT5.FontSize = 0.15;
			parT5.SizeBase = sizeBase;
			parT5.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT5.OP.ScalingY(parT5.OP.GetCenter(), 0.47);
			parT5.OP.Rotation(parT5.OP.GetCenter(), -26.0);
			parT5.Closed = true;
			parT5.TextColor = Col.White;
			parT5.BrushColor = Color.FromArgb(160, Col.Black);
			parT5.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT5.StringFormat.Alignment = StringAlignment.Center;
			parT5.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("ボタン5", new But1(parT5, delegate(But bu)
			{
				Sou.操作.Play();
				Mods.日付進行(CS$<>8__locals1.Med);
			}));
			ParT parT6 = new ParT();
			parT6.Font = new Font("MS Gothic", 0.1f);
			parT6.PositionBase = Mods.描画バッファ.GetPosition(0.85, 0.42);
			parT6.Text = tex.祝福;
			parT6.FontSize = 0.15;
			parT6.SizeBase = sizeBase;
			parT6.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT6.OP.ScalingY(parT6.OP.GetCenter(), 0.47);
			parT6.OP.Rotation(parT6.OP.GetCenter(), -26.0);
			parT6.Closed = true;
			parT6.TextColor = Col.White;
			parT6.BrushColor = Color.FromArgb(160, Col.Black);
			parT6.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT6.StringFormat.Alignment = StringAlignment.Center;
			parT6.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("ボタン6", new But1(parT6, delegate(But bu)
			{
				Sou.操作.Play();
				CS$<>8__locals1.Med.Mode = "祝福";
			}));
			ParT parT7 = new ParT();
			parT7.Font = new Font("MS Gothic", 0.1f);
			parT7.PositionBase = Mods.描画バッファ.GetPosition(0.85, 0.58);
			parT7.Text = tex.チェンジ;
			parT7.FontSize = 0.15;
			parT7.SizeBase = sizeBase;
			parT7.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT7.OP.ScalingY(parT7.OP.GetCenter(), 0.47);
			parT7.OP.Rotation(parT7.OP.GetCenter(), -26.0);
			parT7.Closed = true;
			parT7.TextColor = Col.White;
			parT7.BrushColor = Color.FromArgb(160, Col.Black);
			parT7.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT7.StringFormat.Alignment = StringAlignment.Center;
			parT7.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("ボタン7", new But1(parT7, delegate(But bu)
			{
				Unit unit;
				if (Sta.GameData.調教対象 != null)
				{
					unit = (from e in Sta.GameData.地下室
					where e != null && e != Sta.GameData.調教対象
					orderby OthN.XS.Next()
					select e).FirstOrDefault<Unit>();
				}
				else
				{
					unit = (from e in Sta.GameData.地下室
					where e != null
					orderby OthN.XS.Next()
					select e).First<Unit>();
				}
				if (unit != null)
				{
					if (unit.調教済フラグ)
					{
						Sou.変更3.Play();
					}
					else
					{
						Sou.変更Play();
					}
					Mods.Set調教対象(CS$<>8__locals1.Med, unit);
					bs["ボタン2"].Dra = true;
					return;
				}
				Sou.操作.Play();
				Mods.ip.SubInfoIm = tex.他の奴隷がいません;
			}));
			bs.SetHitColor(CS$<>8__locals1.Med);
			mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				if (!Mods.processing)
				{
					if (Mods.SDShow)
					{
						Mods.セ\u30FCブデ\u30FCタ.Down(ref hc);
						if (mb == MouseButtons.Right)
						{
							Sou.操作.Play();
							Mods.SDShow = false;
							Mods.ip.Up(ref hc);
							Mods.dbs.Move(ref hc);
							return;
						}
					}
					else
					{
						if (mb == MouseButtons.Left)
						{
							if (!Mods.ip.選択肢表示)
							{
								Mods.dbs.Down(ref hc);
								bs.Down(ref hc);
							}
							Mods.ip.Down(ref hc);
							return;
						}
						if (mb == MouseButtons.Right && Mods.ip.TextIm == tex.タイトル画面に戻りますか)
						{
							Mods.ip.nb.Action(Mods.ip.nb);
						}
					}
				}
			};
			mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				if (!Mods.processing)
				{
					if (Mods.SDShow)
					{
						Mods.セ\u30FCブデ\u30FCタ.Up(ref hc);
						return;
					}
					if (mb == MouseButtons.Left)
					{
						if (!Mods.ip.選択肢表示)
						{
							Mods.dbs.Up(ref hc);
							bs.Up(ref hc);
						}
						Mods.ip.Up(ref hc);
					}
				}
			};
			mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				if (!Mods.processing)
				{
					if (Mods.SDShow)
					{
						Mods.セ\u30FCブデ\u30FCタ.Move(ref hc);
						return;
					}
					if (!Mods.ip.選択肢表示)
					{
						if (Mods.調教対象 != null)
						{
							Mods.調教対象.CP = cp;
						}
						Mods.dbs.Move(ref hc);
						bs.Move(ref hc);
						if (bs["ボタン7"].Pars.Values.First<object>().ToPar().HitColor == hc)
						{
							Mods.ip.SubInfoIm = tex.奴隷をランダムに選択します;
						}
						else if (Mods.ip.SubInfoIm == tex.奴隷をランダムに選択します)
						{
							Mods.si.Set(false);
						}
						Mods.Player説明(ref hc, delegate
						{
							Mods.si.Set(false);
						});
					}
					Mods.ip.Move(ref hc);
				}
			};
			mod.Leave = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				if (!Mods.processing)
				{
					if (Mods.SDShow)
					{
						Mods.セ\u30FCブデ\u30FCタ.Leave();
						return;
					}
					if (!Mods.ip.選択肢表示)
					{
						Mods.dbs.Leave();
						bs.Leave();
					}
				}
			};
			mod.Wheel = delegate(MouseButtons mb, Vector2D cp, int dt, Color hc)
			{
			};
			mod.Setting = delegate()
			{
				if (CS$<>8__locals1.Med.Modeb != "情報設定")
				{
					Mods.ip.UpdateSub2();
					Mods.ip.MaiShow = false;
					Mods.ip.Mai.Feed.Dra = false;
					Mods.ip.Mai2Show = false;
					Mods.ip.SubShow = true;
					Mods.ip.Sub2Show = true;
					Act.UI.ステ\u30FCト描画 = Sta.GameData.心眼;
					if (Mods.調教対象 == null && Sta.GameData.調教対象 != null)
					{
						Mods.Set調教対象(CS$<>8__locals1.Med, Sta.GameData.調教対象);
					}
					bs["ボタン2"].Dra = (Sta.GameData.調教対象 != null);
					But but = bs["ボタン3"];
					bool dra;
					if (!Sta.GameData.初事務所フラグ)
					{
						dra = (Sta.GameData.地下室.Count((Unit e) => e != null) > 0);
					}
					else
					{
						dra = false;
					}
					but.Dra = dra;
					bs["ボタン4"].Dra = !Sta.GameData.初事務所フラグ;
					bs["ボタン5"].Dra = !Sta.GameData.初事務所フラグ;
					bs["ボタン6"].Dra = !Sta.GameData.初事務所フラグ;
					But but2 = bs["ボタン7"];
					bool dra2;
					if (!Sta.GameData.初事務所フラグ)
					{
						dra2 = (Sta.GameData.地下室.Count((Unit e) => e != null) > 0);
					}
					else
					{
						dra2 = false;
					}
					but2.Dra = dra2;
					Mods.si.Set(false);
					Color empty = Col.Empty;
					Mods.ip.Up(ref empty);
					Sou.OPBGM.Stop();
					Sou.日常BGM.Play();
					Mods.npl.ParT.PositionBase = new Vector2D(Act.UI.ステ\u30FCト.Position.X, 0.026);
				}
			};
			Mods.メインフォ\u30FCム描画 = delegate(Are a, FPS FPS)
			{
				CS$<>8__locals1.Med.GH.Clear(Col.Transparent);
				if (a.GH != null)
				{
					a.GH.Clear(Col.Transparent);
				}
				a.Draw(Mods.地下室背景);
				if (Mods.調教対象 != null)
				{
					Mods.調教対象.Draw(a, FPS);
					Act.UI.DrawState(a);
					a.Draw(Mods.npl.ParT);
				}
				bs.Draw(a);
				Mods.dbs.Draw(a);
				Mods.ip.Draw(a, FPS);
				if (Mods.SDShow)
				{
					Mods.セ\u30FCブデ\u30FCタ.Draw(a);
				}
				CS$<>8__locals1.Med.Draw(a);
			};
			mod.Draw = delegate(FPS FPS)
			{
				Mods.映転(CS$<>8__locals1.Med, Mods.描画バッファ, FPS, Mods.メインフォ\u30FCム描画);
			};
			mod.Dispose = delegate()
			{
				bs.Dispose();
			};
			return mod;
		}

		public static Mod 調教(Med Med)
		{
			Mods.<>c__DisplayClass95_0 CS$<>8__locals1 = new Mods.<>c__DisplayClass95_0();
			CS$<>8__locals1.Med = Med;
			Mod mod = new Mod();
			調教背景 背景描画 = new 調教背景();
			Are 調教背景 = new Are(CS$<>8__locals1.Med, false);
			調教背景.Setting();
			調教背景.GD.Clear(Color.Gray);
			Act.UI = new 調教UI(CS$<>8__locals1.Med, Mods.描画バッファ, Mods.ip);
			Act.UI.調教終了.Action = delegate(But a)
			{
				Sou.操作.Play();
				CS$<>8__locals1.Med.映転("調教中継帰", Mods.描画バッファ, Mods.中継描画);
			};
			bool 調教完了 = false;
			bool 調教済みチェック = true;
			Action 調教完了表情 = delegate()
			{
				if (Mods.調教対象.目_追い.Run)
				{
					Mods.調教対象.目_追い.End();
				}
				if (Mods.調教対象.Bod.Is双眉)
				{
					Mods.調教対象.Bod.眉左.眉間_表示 = false;
					Mods.調教対象.Bod.眉右.眉間_表示 = false;
				}
				if (Mods.調教対象.Bod.Is双眼)
				{
					Mods.調教対象.瞼_半1左();
					Mods.調教対象.瞼_半1右();
					Mods.調教対象.目_見つめ左();
					Mods.調教対象.目_見つめ右();
				}
				if (Mods.調教対象.Bod.Is頬眼)
				{
					Mods.調教対象.頬瞼_半1左();
					Mods.調教対象.頬瞼_半1右();
					Mods.調教対象.頬目_見つめ左();
					Mods.調教対象.頬目_見つめ右();
				}
				if (Mods.調教対象.Bod.Is単眼)
				{
					Mods.調教対象.単瞼_半1();
					Mods.調教対象.単目_見つめ();
				}
				if (Mods.調教対象.Bod.Is額眼)
				{
					Mods.調教対象.額瞼_半1();
					Mods.調教対象.額目_見つめ();
				}
				if (!Mods.調教対象.Bod.玉口枷_表示)
				{
					Mods.調教対象.口_閉笑();
				}
			};
			mod.Setting = delegate()
			{
				調教背景.GD.Clear(Color.Gray);
				背景描画.Reset();
				背景描画.描画(調教背景);
				Mods.ip.MaiShow = false;
				Mods.ip.Mai.Feed.Dra = true;
				Mods.ip.Mai2Show = false;
				Mods.ip.SubShow = true;
				Mods.ip.Sub2Show = false;
				CS$<>8__locals1.Med.CursorHide();
				Act.UI.ディルCM.Show = Sta.GameData.購入道具[0];
				Act.UI.コモンCM.Show = Sta.GameData.購入道具[1];
				Act.UI.ドリルCM.Show = Sta.GameData.購入道具[2];
				Act.UI.デンマCM.Show = Sta.GameData.購入道具[3];
				Act.UI.アナルCM.Show = Sta.GameData.購入道具[4];
				Act.UI.調教鞭CM.Show = Sta.GameData.購入道具[5];
				Act.UI.羽根箒CM.Show = Sta.GameData.購入道具[6];
				Act.UI.T剃刀CM.Show = Sta.GameData.購入道具[7];
				Act.UI.キャップ1CM.Show = Sta.GameData.購入道具[8];
				Act.UI.キャップ2CM.Show = Sta.GameData.購入道具[8];
				Act.UI.キャップ3CM.Show = Sta.GameData.購入道具[8];
				Act.UI.ロ\u30FCタCM.Show = Sta.GameData.購入道具[9];
				Act.UI.パ\u30FCルCM.Show = Sta.GameData.購入道具[10];
				Act.UI.目隠帯.Dra = Sta.GameData.購入道具[11];
				Act.UI.玉口枷.Dra = Sta.GameData.購入道具[12];
				Act.UI.撮影.Dra = Sta.GameData.購入道具[13];
				Act.表示ステ\u30FCト更新();
				Act.ModBox();
				Act.SensBox();
				if (Mods.調教対象.Bod.Is獣)
				{
					Mods.調教対象.Bod.腰.位置B = CS$<>8__locals1.Med.Base.GetPosition(ref Shas.中央中央).AddY(-0.03);
				}
				else if (Mods.調教対象.Bod.Is半身)
				{
					Mods.調教対象.Bod.腰.位置B = CS$<>8__locals1.Med.Base.GetPosition(ref Shas.中央中央).AddY(-0.02);
				}
				Mods.調教対象.Bod.Join();
				Mods.調教対象.Bod.Update();
				Mods.キャラ吹出し.接続();
				Mods.調教対象.Bod.汗染み濃度 = 1.0;
				調教済みチェック = true;
				Mods.調教前調教済みフラグ = Sta.GameData.調教対象.調教済フラグ;
				if (調教完了 = Sta.GameData.調教対象.Is調教完了())
				{
					調教完了表情();
				}
			};
			接触D cd = default(接触D);
			Vector2D op = Dat.Vec2DZero;
			mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				Act.UI.Down(ref mb, ref cp, ref op, ref hc, ref cd);
				Mods.ip.Down(ref hc);
			};
			mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				Act.UI.Up(ref mb, ref cp, ref hc, ref cd);
				Mods.ip.Up(ref hc);
			};
			mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				Mods.調教対象.CP = cp;
				cd = Mods.調教対象.GetContact(ref hc);
				Act.UI.Move(ref mb, ref cp, ref op, ref hc, ref cd);
				Mods.ip.Move(ref hc);
				op = cp;
			};
			mod.Leave = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				Act.UI.Leave(ref mb, ref cp, ref hc);
			};
			mod.Wheel = delegate(MouseButtons mb, Vector2D cp, int dt, Color hc)
			{
				Act.UI.Wheel(ref mb, ref cp, ref dt, ref hc, ref cd);
			};
			Mods.調教描画 = delegate(Are a, FPS FPS)
			{
				Act.UI.Mots.Drive(FPS);
				CS$<>8__locals1.Med.GH.Clear(Col.Transparent);
				if (a.GH != null)
				{
					a.GH.Clear(Col.Transparent);
				}
				a.Draw(調教背景);
				Mods.調教対象.Draw(a, FPS);
				Mods.キャラ吹出し.Draw(a, FPS);
				Act.UI.StaDraw(a, FPS);
				Mods.ip.Draw(a, FPS);
				CS$<>8__locals1.Med.Draw(a);
				if (調教済みチェック)
				{
					if (調教完了)
					{
						調教完了表情();
						Mods.キャラ台詞.Set状態();
						if (Mods.調教対象.Bod.Is顔面)
						{
							Task.Factory.StartNew(delegate()
							{
								while (Mods.キャラ吹出し.Tex.IsPlaing)
								{
								}
								Mods.調教対象.顔面展開.Sta();
							});
						}
					}
					調教済みチェック = false;
				}
			};
			Mods.撮影描画 = delegate(Are a, FPS FPS)
			{
				a.Draw(調教背景);
				Mods.調教対象.Draw(a, FPS);
			};
			mod.Draw = delegate(FPS FPS)
			{
				Mods.映転(CS$<>8__locals1.Med, Mods.描画バッファ, FPS, Mods.調教描画);
			};
			mod.Dispose = delegate()
			{
				調教背景.Dispose();
				Act.UI.Dispose();
			};
			return mod;
		}

		public static Mod 調教中継行(Med Med)
		{
			Mod mod = new Mod();
			mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				Med.映転("調教", Mods.描画バッファ, Mods.調教描画);
			};
			mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
			};
			mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
			};
			mod.Leave = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
			};
			mod.Wheel = delegate(MouseButtons mb, Vector2D cp, int dt, Color hc)
			{
			};
			mod.Setting = delegate()
			{
				Mods.ip.MaiShow = true;
				Mods.ip.Mai.Feed.Dra = true;
				Mods.ip.Mai2Show = false;
				Mods.ip.SubShow = true;
				Mods.ip.Sub2Show = false;
				Mods.ip.Text = tex.点6;
				if (!Mods.調教対象.Bod.Setピアス.ピアス_表示)
				{
					Mods.調教対象.Bod.脱衣();
				}
				Act.UI.SetTarget(Sta.GameData.調教対象, Mods.調教対象);
				Act.SetState奴隷();
				Act.表示ステ\u30FCト更新();
				Act.ModBox();
				Act.SensBox();
				Mods.調教対象.Bod.首輪_表示 = true;
				Mods.si.Set(false);
				Act.UI.Reset();
				Act.UI.擬音キュ\u30FC.Clear();
				Act.UI.擬音.Clear();
			};
			Mods.中継描画 = delegate(Are a, FPS FPS)
			{
				Med.GH.Clear(Col.Transparent);
				if (a.GH != null)
				{
					a.GH.Clear(Col.Transparent);
				}
				a.Draw(Mods.黒背景);
				Mods.ip.Draw(a, FPS);
				Med.Draw(a);
			};
			mod.Draw = delegate(FPS FPS)
			{
				Mods.映転(Med, Mods.描画バッファ, FPS, Mods.中継描画);
			};
			mod.Dispose = delegate()
			{
			};
			return mod;
		}

		public static Mod 調教中継帰(Med Med)
		{
			Mods.<>c__DisplayClass97_0 CS$<>8__locals1 = new Mods.<>c__DisplayClass97_0();
			CS$<>8__locals1.Med = Med;
			Mod mod = new Mod();
			bool Result2 = false;
			bool Result3 = false;
			bool b1 = false;
			bool b2 = false;
			bool b3 = false;
			mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				if (!Result2)
				{
					Act.Result2();
					Result2 = true;
					b1 = (Sta.GameData.調教対象.妊娠フラグ && Sta.GameData.調教対象.非妊娠);
					b2 = (!Mods.調教前調教済みフラグ && Sta.GameData.調教対象.調教済フラグ);
					b3 = (Sta.GameData.調教対象.調教済フラグ && Sta.GameData.祝福 == null);
					Result3 = !(b1 | b2 | b3);
					return;
				}
				if (Sta.WhipScars)
				{
					Mods.Set調教対象(CS$<>8__locals1.Med, Sta.GameData.調教対象);
				}
				if (!Result3)
				{
					Mods.ip.TextIm = "";
					if (b1)
					{
						情報パネル 情報パネル = Mods.ip;
						情報パネル.TextIm = string.Concat(new string[]
						{
							情報パネル.TextIm,
							tex.収容番号,
							Sta.GameData.調教対象.Number,
							"/",
							Sta.GameData.調教対象.Name,
							tex.が妊娠しました,
							(Sta.GameData.調教対象.一般労働 || Sta.GameData.調教対象.娼婦労働) ? ("\r\n" + tex.労働が解除されます) : "",
							"\r\n"
						});
						Sta.GameData.調教対象.非妊娠 = false;
					}
					if (b2)
					{
						情報パネル 情報パネル = Mods.ip;
						情報パネル.TextIm = string.Concat(new string[]
						{
							情報パネル.TextIm,
							tex.収容番号,
							Sta.GameData.調教対象.Number,
							"/",
							Sta.GameData.調教対象.Name,
							tex.の調教が完了しました,
							"\r\n"
						});
					}
					if (b3)
					{
						Sta.GameData.祝福 = Sta.GameData.調教対象;
						情報パネル 情報パネル = Mods.ip;
						情報パネル.TextIm = string.Concat(new string[]
						{
							情報パネル.TextIm,
							tex.収容番号,
							Sta.GameData.調教対象.Number,
							"/",
							Sta.GameData.調教対象.Name,
							tex.から祝福を受けました
						});
						Sou.祝福.Play();
					}
					Result3 = true;
					return;
				}
				if (!Mods.時間進行(CS$<>8__locals1.Med))
				{
					Act.UI.Reset();
					CS$<>8__locals1.Med.映転("メインフォーム", Mods.描画バッファ, Mods.メインフォ\u30FCム描画);
				}
			};
			mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
			};
			mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
			};
			mod.Leave = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
			};
			mod.Wheel = delegate(MouseButtons mb, Vector2D cp, int dt, Color hc)
			{
			};
			mod.Setting = delegate()
			{
				Mods.ip.MaiShow = true;
				Mods.ip.Mai.Feed.Dra = true;
				Mods.ip.Mai2Show = false;
				Mods.ip.SubShow = true;
				Mods.ip.Sub2Show = false;
				CS$<>8__locals1.Med.CursorShow();
				Color empty = Col.Empty;
				Act.UI.調教終了.Up(ref empty);
				Act.Result1();
				if (Act.UI.強制拘束)
				{
					Sta.GameData.拘束具 = Act.UI.拘束bu;
				}
				Sta.GameData.調教対象.発情フラグ = Act.UI.発情bu;
				Act.調教終了時();
				Mods.調教対象.絶頂.End();
				Mods.調教対象.体揺れ.End();
				Mods.調教対象.放尿強制終了();
				Act.絶頂終了処理_();
				Act.射精終了処理_();
				Mods.調教対象.Bod.膣内精液.精液濃度 = 0.0;
				Mods.調教対象.Bod.断面.精液濃度 = 0.0;
				Mods.調教対象.Bod.スタンプClear();
				Mods.調教対象.Bod.腰.位置B = CS$<>8__locals1.Med.Base.GetPosition(ref Shas.中央中央);
				Mods.調教対象.Bod.汗染み濃度 = 0.0;
				Mods.調教対象.Bod.飛沫濃度 = 0.0;
				Mods.調教対象.Bod.潮染み濃度 = 0.0;
				Mods.調教対象.Bod.尿染み濃度 = 0.0;
				if (!Mods.調教対象.Bod.Is粘)
				{
					Mods.調教対象.Bod.断面_表示 = false;
				}
				Mods.調教対象.目_追い.End();
				Mods.調教対象.口腔精液垂れ.End();
				Mods.調教対象.性器精液垂れ.End();
				Mods.調教対象.肛門精液垂れ.End();
				Mods.調教対象.出糸精液垂れ.End();
				Mods.調教対象.Bod.Set腰();
				if (Sta.GameData.調教対象.調教済フラグ)
				{
					Mods.調教対象.Bod.拘束具_表示 = false;
					Mods.調教対象.Bod.首輪_表示 = true;
					Mods.調教対象.Set基本姿勢();
				}
				else
				{
					Mods.調教対象.Bod.拘束具_表示 = true;
					Mods.調教対象.Set拘束姿勢();
				}
				Mods.調教対象.情動();
				Mods.調教対象.Set表情初期化();
				Mods.調教対象.口修正();
				Mods.調教対象.舌_無し();
				Mods.調教対象.Set衣装(Sta.GameData.調教対象.着衣);
				Act.SetState();
				Act.表示ステ\u30FCト更新();
				Act.ModBox();
				Act.SensBox();
				Mods.調教対象.Bod.カ\u30FCソル = null;
				Mods.調教対象.Bod.Join();
				Mods.調教対象.Bod.Update();
				Mods.キャラ吹出し.接続();
				Mods.キャラ吹出し.消失.End();
				Result2 = false;
				Result3 = false;
				Mods.si.Set(false);
				Sta.GameData.目隠帯 = false;
				Sta.GameData.玉口枷 = false;
				Sta.GameData.拘束具 = false;
				Sta.GameData.断面 = false;
			};
			mod.Draw = delegate(FPS FPS)
			{
				Mods.映転(CS$<>8__locals1.Med, Mods.描画バッファ, FPS, Mods.中継描画);
			};
			mod.Dispose = delegate()
			{
			};
			return mod;
		}

		public static Mod 対象(Med Med)
		{
			Mods.<>c__DisplayClass98_0 CS$<>8__locals1 = new Mods.<>c__DisplayClass98_0();
			CS$<>8__locals1.Med = Med;
			Mod result;
			try
			{
				Mods.<>c__DisplayClass98_1 CS$<>8__locals2 = new Mods.<>c__DisplayClass98_1();
				CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
				CS$<>8__locals2.胸施術価格 = 10000000U;
				CS$<>8__locals2.股施術価格 = 10000000U;
				CS$<>8__locals2.淫紋価格 = 10000000U;
				CS$<>8__locals2.衣装変更価格 = 10000000U;
				CS$<>8__locals2.d = false;
				Mod mod = new Mod();
				Buts bs = new Buts();
				Swi 保守sw = new Swi(Color.DarkRed);
				Swi 一般sw = new Swi(Color.DarkRed);
				Swi 娼婦sw = new Swi(Color.DarkRed);
				int i = 0;
				int f = 0;
				ListView lv = new ListView(Mods.描画バッファ, Mods.描画バッファ.GetPosition(0.01, 0.08), 0.4, new Font("MS Gothic", 1f), 0.08, Col.White, Col.Empty, Color.FromArgb(160, Col.Black), Col.Black, Enumerable.Repeat<TA>(new TA("No Slave".PadLeft(15, ' '), delegate(But b)
				{
				}), 15).ToArray<TA>());
				Color lv初期縁色 = Col.Black;
				Action lv縁色初期化 = delegate()
				{
					foreach (But but in lv.bs.EnumBut)
					{
						but.Pars.Values.First<object>().ToParT().PenColor = lv初期縁色;
					}
				};
				Action<Unit> SetUI = delegate(Unit u)
				{
					if (u != null)
					{
						Mods.ip.TextIm = u.GetStatus();
						bs["MoveRoomDown"].Dra = Sta.MoveButton;
						bs["MoveRoomUp"].Dra = Sta.MoveButton;
						bs["MoveFloorDown"].Dra = Sta.MoveButton;
						bs["MoveFloorUp"].Dra = Sta.MoveButton;
						bs["子"].Dra = true;
						bs["親形質1"].Dra = true;
						bs["親形質2"].Dra = true;
						保守sw.SetFlag(bs["保守"], u.保守);
						一般sw.SetFlag(bs["一般労働"], u.一般労働);
						娼婦sw.SetFlag(bs["娼婦労働"], u.娼婦労働);
						bs["保守"].Dra = true;
						bs["一般労働"].Dra = (u.非妊娠 && u.調教済フラグ);
						bs["娼婦労働"].Dra = (u.非妊娠 && u.調教済フラグ);
						bs["売却"].Dra = !u.保守;
						bs["胸施術"].Dra = (Sta.GameData.施術 && !u.ChaD.胸施術 && u.ChaD.Is胸甲殻());
						bs["股施術"].Dra = (Sta.GameData.施術 && !u.ChaD.股施術 && u.ChaD.Is股防御());
						bs["淫紋"].Dra = (Sta.GameData.淫紋 && u.調教済フラグ && !u.ChaD.タトゥ && !u.ChaD.Isタトゥ());
						bs["衣装"].Dra = (Sta.GameData.衣装 && u.調教済フラグ);
						return;
					}
					Mods.npl.Text = "No Slave";
					Mods.ip.TextIm = " ";
					bs["MoveRoomDown"].Dra = false;
					bs["MoveRoomUp"].Dra = false;
					bs["MoveFloorDown"].Dra = false;
					bs["MoveFloorUp"].Dra = false;
					bs["子"].Dra = false;
					bs["親形質1"].Dra = false;
					bs["親形質2"].Dra = false;
					bs["保守"].Dra = false;
					bs["一般労働"].Dra = false;
					bs["娼婦労働"].Dra = false;
					bs["売却"].Dra = false;
					bs["胸施術"].Dra = false;
					bs["股施術"].Dra = false;
					bs["淫紋"].Dra = false;
					bs["衣装"].Dra = false;
				};
				Action<But> <>9__45;
				Action<int> set = delegate(int n)
				{
					i = 0;
					lv.Acts = Enumerable.Repeat<TA>(new TA("", delegate(But b)
					{
					}), 15).Select(delegate(TA e)
					{
						int i;
						Unit u = Sta.GameData.地下室[n + i];
						if (u == null)
						{
							e.Text = "No Slave";
							Action<But> act;
							if ((act = <>9__45) == null)
							{
								act = (<>9__45 = delegate(But b)
								{
									lv縁色初期化();
									b.Pars.Values.First<object>().ToParT().PenColor = Color.Red;
									Sta.GameData.調教対象 = null;
									if (Mods.調教対象 != null)
									{
										Mods.調教対象.Dispose();
										Mods.調教対象 = null;
									}
									SetUI(null);
								});
							}
							e.act = act;
						}
						else
						{
							e.Text = tex.収容番号 + u.Number;
							e.act = delegate(But b)
							{
								lv縁色初期化();
								b.Pars.Values.First<object>().ToParT().PenColor = Color.Red;
								Sta.GameData.調教対象 = u;
								bs["子"].Action(bs["子"]);
								if (Mods.ip.Mai2Show)
								{
									if (Sta.GameData.調教対象 == null)
									{
										Mods.ip.Mai2Im = " ";
										Mods.ip.選択肢表示 = false;
										return;
									}
									CS$<>8__locals2.d = false;
									bs["売却"].Action(bs["売却"]);
									CS$<>8__locals2.d = true;
								}
							};
						}
						i = i;
						i++;
						return e;
					});
				};
				double sizeBase = 0.05;
				if (Sta.BigWindow && !Sta.NoScaling)
				{
					sizeBase = 0.068;
				}
				lv.SetHitColor(CS$<>8__locals2.CS$<>8__locals1.Med);
				ParT parT = new ParT();
				parT.Font = new Font("MS Gothic", 0.1f);
				parT.PositionBase = Mods.描画バッファ.GetPosition(0.85, 0.02);
				parT.Text = tex.戻る;
				parT.FontSize = 0.15;
				parT.SizeBase = sizeBase;
				parT.OP.AddRange(new Out[]
				{
					Shas.Get正方形()
				});
				parT.OP.ScalingY(parT.OP.GetCenter(), 0.47);
				parT.OP.Rotation(parT.OP.GetCenter(), -26.0);
				parT.Closed = true;
				parT.TextColor = Col.White;
				parT.BrushColor = Color.FromArgb(160, Col.Black);
				parT.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
				parT.StringFormat.Alignment = StringAlignment.Center;
				parT.StringFormat.LineAlignment = StringAlignment.Center;
				bs.Add("ボタン0", new But1(parT, delegate(But a)
				{
					Sou.操作.Play();
					if (Sta.GameData.調教対象 != null && bs["子"].Pars.Values.First<object>().ToParT().PenColor != Color.Red)
					{
						Mods.Set調教対象(CS$<>8__locals2.CS$<>8__locals1.Med, Sta.GameData.調教対象);
						SetUI(Sta.GameData.調教対象);
					}
					CS$<>8__locals2.CS$<>8__locals1.Med.Mode = "メインフォーム";
				}));
				Color bs初期縁色 = Col.Black;
				Action bs縁色初期化 = delegate()
				{
					foreach (But but in bs.EnumBut.Skip(1).Take(3))
					{
						but.Pars.Values.First<object>().ToParT().PenColor = bs初期縁色;
					}
				};
				ParT parT2 = new ParT();
				parT2.Font = new Font("MS Gothic", 0.1f);
				parT2.PositionBase = Mods.描画バッファ.GetPosition(0.85, 0.1);
				parT2.Text = tex.子;
				parT2.FontSize = 0.15;
				parT2.SizeBase = sizeBase;
				parT2.OP.AddRange(new Out[]
				{
					Shas.Get正方形()
				});
				parT2.OP.ScalingY(parT2.OP.GetCenter(), 0.47);
				parT2.OP.Rotation(parT2.OP.GetCenter(), -26.0);
				parT2.Closed = true;
				parT2.TextColor = Col.White;
				parT2.BrushColor = Color.FromArgb(160, Col.Black);
				parT2.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
				parT2.StringFormat.Alignment = StringAlignment.Center;
				parT2.StringFormat.LineAlignment = StringAlignment.Center;
				parT2.PenColor = Color.Red;
				bs.Add("子", new But1(parT2, delegate(But b)
				{
					if (CS$<>8__locals2.d)
					{
						Sou.操作.Play();
					}
					bs縁色初期化();
					b.Pars.Values.First<object>().ToParT().PenColor = Color.Red;
					if (Sta.GameData.調教対象 != null)
					{
						if (Mods.調教対象 == null || Mods.調教対象.ChaD != Sta.GameData.調教対象.ChaD)
						{
							Mods.Set調教対象(CS$<>8__locals2.CS$<>8__locals1.Med, Sta.GameData.調教対象);
						}
						SetUI(Sta.GameData.調教対象);
						bs["胸施術"].Dra = (Sta.GameData.施術 && !Sta.GameData.調教対象.ChaD.胸施術 && Sta.GameData.調教対象.ChaD.Is胸甲殻());
						bs["股施術"].Dra = (Sta.GameData.施術 && !Sta.GameData.調教対象.ChaD.股施術 && Sta.GameData.調教対象.ChaD.Is股防御());
						bs["淫紋"].Dra = (Sta.GameData.淫紋 && Sta.GameData.調教対象.調教済フラグ && !Sta.GameData.調教対象.ChaD.タトゥ && !Sta.GameData.調教対象.ChaD.Isタトゥ());
						bs["衣装"].Dra = (Sta.GameData.衣装 && Sta.GameData.調教対象.調教済フラグ);
					}
				}));
				ParT parT3 = new ParT();
				parT3.Font = new Font("MS Gothic", 0.1f);
				parT3.PositionBase = Mods.描画バッファ.GetPosition(0.85, 0.18);
				parT3.Text = tex.親形質1;
				parT3.FontSize = 0.15;
				parT3.SizeBase = sizeBase;
				parT3.OP.AddRange(new Out[]
				{
					Shas.Get正方形()
				});
				parT3.OP.ScalingY(parT3.OP.GetCenter(), 0.47);
				parT3.OP.Rotation(parT3.OP.GetCenter(), -26.0);
				parT3.Closed = true;
				parT3.TextColor = Col.White;
				parT3.BrushColor = Color.FromArgb(160, Col.Black);
				parT3.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
				parT3.StringFormat.Alignment = StringAlignment.Center;
				parT3.StringFormat.LineAlignment = StringAlignment.Center;
				bs.Add("親形質1", new But1(parT3, delegate(But b)
				{
					Sou.操作.Play();
					bs縁色初期化();
					b.Pars.Values.First<object>().ToParT().PenColor = Color.Red;
					if (Sta.GameData.調教対象 != null)
					{
						if (Mods.調教対象 != null)
						{
							Mods.調教対象.Dispose();
						}
						Mods.調教対象 = new Cha(CS$<>8__locals2.CS$<>8__locals1.Med, Mods.描画バッファ, Sta.GameData.調教対象.母方.ChaD);
						if (Mods.調教対象.Bod.Is双眼)
						{
							Mods.調教対象.両目_見つめ();
						}
						if (Mods.調教対象.Bod.Is頬眼)
						{
							Mods.調教対象.両頬目_見つめ();
						}
						if (Mods.調教対象.Bod.Is単眼)
						{
							Mods.調教対象.単目_見つめ();
						}
						if (Mods.調教対象.Bod.Is額眼)
						{
							Mods.調教対象.額目_見つめ();
						}
						if (Sta.GameData.調教対象.母方.種族 == tex.ヴィオランテ)
						{
							Mods.調教対象.両瞼_卑();
							Mods.調教対象.両瞼_半1();
						}
						Mods.調教対象.口_閉笑();
						Mods.調教対象.Set基本姿勢();
						Mods.npl.Text = tex.収容番号 + Sta.GameData.調教対象.Number + "\r\n" + tex.親形質1;
						Mods.ip.TextIm = Sta.GameData.調教対象.母方.GetStatus();
						bs["胸施術"].Dra = false;
						bs["股施術"].Dra = false;
						bs["淫紋"].Dra = false;
						bs["衣装"].Dra = false;
					}
				}));
				ParT parT4 = new ParT();
				parT4.Font = new Font("MS Gothic", 0.1f);
				parT4.PositionBase = Mods.描画バッファ.GetPosition(0.85, 0.26);
				parT4.Text = tex.親形質2;
				parT4.FontSize = 0.15;
				parT4.SizeBase = sizeBase;
				parT4.OP.AddRange(new Out[]
				{
					Shas.Get正方形()
				});
				parT4.OP.ScalingY(parT4.OP.GetCenter(), 0.47);
				parT4.OP.Rotation(parT4.OP.GetCenter(), -26.0);
				parT4.Closed = true;
				parT4.TextColor = Col.White;
				parT4.BrushColor = Color.FromArgb(160, Col.Black);
				parT4.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
				parT4.StringFormat.Alignment = StringAlignment.Center;
				parT4.StringFormat.LineAlignment = StringAlignment.Center;
				bs.Add("親形質2", new But1(parT4, delegate(But b)
				{
					Sou.操作.Play();
					bs縁色初期化();
					b.Pars.Values.First<object>().ToParT().PenColor = Color.Red;
					if (Sta.GameData.調教対象 != null)
					{
						if (Mods.調教対象 != null)
						{
							Mods.調教対象.Dispose();
						}
						Mods.調教対象 = new Cha(CS$<>8__locals2.CS$<>8__locals1.Med, Mods.描画バッファ, Sta.GameData.調教対象.父方.ChaD);
						if (Mods.調教対象.Bod.Is双眼)
						{
							Mods.調教対象.両目_見つめ();
						}
						if (Mods.調教対象.Bod.Is頬眼)
						{
							Mods.調教対象.両頬目_見つめ();
						}
						if (Mods.調教対象.Bod.Is単眼)
						{
							Mods.調教対象.単目_見つめ();
						}
						if (Mods.調教対象.Bod.Is額眼)
						{
							Mods.調教対象.額目_見つめ();
						}
						if (Sta.GameData.調教対象.父方.種族 == tex.ヴィオランテ)
						{
							Mods.調教対象.両瞼_卑();
							Mods.調教対象.両瞼_半1();
						}
						Mods.調教対象.口_閉笑();
						Mods.調教対象.Set基本姿勢();
						Mods.npl.Text = tex.収容番号 + Sta.GameData.調教対象.Number + "\r\n" + tex.親形質2;
						Mods.ip.TextIm = Sta.GameData.調教対象.父方.GetStatus();
						bs["胸施術"].Dra = false;
						bs["股施術"].Dra = false;
						bs["淫紋"].Dra = false;
						bs["衣装"].Dra = false;
					}
				}));
				ParT parT5 = new ParT();
				parT5.Font = new Font("MS Gothic", 0.1f);
				parT5.PositionBase = Mods.描画バッファ.GetPosition(0.85, 0.34);
				parT5.Text = tex.保守;
				parT5.FontSize = 0.15;
				parT5.SizeBase = sizeBase;
				parT5.OP.AddRange(new Out[]
				{
					Shas.Get正方形()
				});
				parT5.OP.ScalingY(parT5.OP.GetCenter(), 0.47);
				parT5.OP.Rotation(parT5.OP.GetCenter(), -26.0);
				parT5.Closed = true;
				parT5.TextColor = Col.White;
				parT5.BrushColor = Color.FromArgb(160, Col.Black);
				parT5.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
				parT5.StringFormat.Alignment = StringAlignment.Center;
				parT5.StringFormat.LineAlignment = StringAlignment.Center;
				bs.Add("保守", new But1(parT5, delegate(But b)
				{
					Sou.操作.Play();
					if (Sta.GameData.調教対象 != null)
					{
						保守sw.OnOff(b);
						Sta.GameData.調教対象.保守 = 保守sw.Flag;
						bs["売却"].Dra = !Sta.GameData.調教対象.保守;
						Mods.ip.SubInfoIm = (Sta.GameData.調教対象.保守 ? tex.奴隷を保守対象に設定しました : tex.奴隷の保守設定を解除しました);
					}
				}));
				ParT parT6 = new ParT();
				parT6.Font = new Font("MS Gothic", 0.1f);
				parT6.PositionBase = Mods.描画バッファ.GetPosition(0.85, 0.42);
				parT6.Text = tex.一般労働;
				parT6.FontSize = 0.15;
				parT6.SizeBase = sizeBase;
				parT6.OP.AddRange(new Out[]
				{
					Shas.Get正方形()
				});
				parT6.OP.ScalingY(parT6.OP.GetCenter(), 0.47);
				parT6.OP.Rotation(parT6.OP.GetCenter(), -26.0);
				parT6.Closed = true;
				parT6.TextColor = Col.White;
				parT6.BrushColor = Color.FromArgb(160, Col.Black);
				parT6.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
				parT6.StringFormat.Alignment = StringAlignment.Center;
				parT6.StringFormat.LineAlignment = StringAlignment.Center;
				bs.Add("一般労働", new But1(parT6, delegate(But b)
				{
					Sou.操作.Play();
					if (Sta.GameData.調教対象 != null)
					{
						一般sw.OnOff(b);
						Sta.GameData.調教対象.一般労働 = 一般sw.Flag;
						if (一般sw.Flag && 娼婦sw.Flag)
						{
							娼婦sw.SetFlag(bs["娼婦労働"], false);
						}
						Sta.GameData.調教対象.娼婦労働 = 娼婦sw.Flag;
						Mods.ip.SubInfoIm = (Sta.GameData.調教対象.一般労働 ? tex.奴隷を一般労働に設定しました : tex.奴隷の一般労働を解除しました);
					}
				}));
				ParT parT7 = new ParT();
				parT7.Font = new Font("MS Gothic", 0.1f);
				parT7.PositionBase = Mods.描画バッファ.GetPosition(0.85, 0.5);
				parT7.Text = tex.娼婦労働;
				parT7.FontSize = 0.15;
				parT7.SizeBase = sizeBase;
				parT7.OP.AddRange(new Out[]
				{
					Shas.Get正方形()
				});
				parT7.OP.ScalingY(parT7.OP.GetCenter(), 0.47);
				parT7.OP.Rotation(parT7.OP.GetCenter(), -26.0);
				parT7.Closed = true;
				parT7.TextColor = Col.White;
				parT7.BrushColor = Color.FromArgb(160, Col.Black);
				parT7.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
				parT7.StringFormat.Alignment = StringAlignment.Center;
				parT7.StringFormat.LineAlignment = StringAlignment.Center;
				bs.Add("娼婦労働", new But1(parT7, delegate(But b)
				{
					Sou.操作.Play();
					if (Sta.GameData.調教対象 != null)
					{
						娼婦sw.OnOff(b);
						Sta.GameData.調教対象.娼婦労働 = 娼婦sw.Flag;
						if (娼婦sw.Flag && 一般sw.Flag)
						{
							一般sw.SetFlag(bs["一般労働"], false);
						}
						Sta.GameData.調教対象.一般労働 = 一般sw.Flag;
						Mods.ip.SubInfoIm = (Sta.GameData.調教対象.娼婦労働 ? tex.奴隷を娼婦労働に設定しました : tex.奴隷の娼婦労働を解除しました);
					}
				}));
				ParT parT8 = new ParT();
				parT8.Font = new Font("MS Gothic", 0.1f);
				parT8.PositionBase = Mods.描画バッファ.GetPosition(0.75, 0.405);
				parT8.Text = tex.全一般;
				parT8.FontSize = 0.15;
				parT8.SizeBase = sizeBase;
				parT8.OP.AddRange(new Out[]
				{
					Shas.Get正方形()
				});
				parT8.OP.ScalingY(parT8.OP.GetCenter(), 0.47);
				parT8.OP.Rotation(parT8.OP.GetCenter(), -26.0);
				parT8.Closed = true;
				parT8.TextColor = Col.White;
				parT8.BrushColor = Color.FromArgb(160, Col.Black);
				parT8.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
				parT8.StringFormat.Alignment = StringAlignment.Center;
				parT8.StringFormat.LineAlignment = StringAlignment.Center;
				bs.Add("全一般", new But1(parT8, delegate(But b)
				{
					Sou.操作.Play();
					if (Sta.GameData.調教対象 != null)
					{
						一般sw.SetFlag(bs["一般労働"], true);
						娼婦sw.SetFlag(bs["娼婦労働"], false);
					}
					foreach (Unit unit in Sta.GameData.地下室)
					{
						if (unit != null && unit.調教済フラグ && unit.非妊娠)
						{
							unit.一般労働 = true;
							unit.娼婦労働 = false;
						}
					}
					Mods.ip.SubInfoIm = tex.労働可能な全ての奴隷に一般労働を設定しました;
				}));
				ParT parT9 = new ParT();
				parT9.Font = new Font("MS Gothic", 0.1f);
				parT9.PositionBase = Mods.描画バッファ.GetPosition(0.75, 0.485);
				parT9.Text = tex.全娼婦;
				parT9.FontSize = 0.15;
				parT9.SizeBase = sizeBase;
				parT9.OP.AddRange(new Out[]
				{
					Shas.Get正方形()
				});
				parT9.OP.ScalingY(parT9.OP.GetCenter(), 0.47);
				parT9.OP.Rotation(parT9.OP.GetCenter(), -26.0);
				parT9.Closed = true;
				parT9.TextColor = Col.White;
				parT9.BrushColor = Color.FromArgb(160, Col.Black);
				parT9.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
				parT9.StringFormat.Alignment = StringAlignment.Center;
				parT9.StringFormat.LineAlignment = StringAlignment.Center;
				bs.Add("全娼婦", new But1(parT9, delegate(But b)
				{
					Sou.操作.Play();
					if (Sta.GameData.調教対象 != null)
					{
						一般sw.SetFlag(bs["一般労働"], false);
						娼婦sw.SetFlag(bs["娼婦労働"], true);
					}
					foreach (Unit unit in Sta.GameData.地下室)
					{
						if (unit != null && unit.調教済フラグ && unit.非妊娠)
						{
							unit.一般労働 = false;
							unit.娼婦労働 = true;
						}
					}
					Mods.ip.SubInfoIm = tex.労働可能な全ての奴隷に娼婦労働を設定しました;
				}));
				ParT parT10 = new ParT();
				parT10.Font = new Font("MS Gothic", 0.1f);
				parT10.PositionBase = Mods.描画バッファ.GetPosition(0.75, 0.565);
				parT10.Text = tex.全解除;
				parT10.FontSize = 0.15;
				parT10.SizeBase = sizeBase;
				parT10.OP.AddRange(new Out[]
				{
					Shas.Get正方形()
				});
				parT10.OP.ScalingY(parT10.OP.GetCenter(), 0.47);
				parT10.OP.Rotation(parT10.OP.GetCenter(), -26.0);
				parT10.Closed = true;
				parT10.TextColor = Col.White;
				parT10.BrushColor = Color.FromArgb(160, Col.Black);
				parT10.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
				parT10.StringFormat.Alignment = StringAlignment.Center;
				parT10.StringFormat.LineAlignment = StringAlignment.Center;
				bs.Add("全解除", new But1(parT10, delegate(But b)
				{
					Sou.操作.Play();
					if (Sta.GameData.調教対象 != null)
					{
						一般sw.SetFlag(bs["一般労働"], false);
						娼婦sw.SetFlag(bs["娼婦労働"], false);
					}
					foreach (Unit unit in Sta.GameData.地下室)
					{
						if (unit != null && unit.調教済フラグ)
						{
							unit.一般労働 = false;
							unit.娼婦労働 = false;
						}
					}
					Mods.ip.SubInfoIm = tex.労働中の全ての奴隷の労働を解除しました;
				}));
				ParT parT11 = new ParT();
				parT11.Font = new Font("MS Gothic", 0.1f);
				parT11.PositionBase = Mods.描画バッファ.GetPosition(0.85, 0.58);
				parT11.Text = tex.売却;
				parT11.FontSize = 0.15;
				parT11.SizeBase = sizeBase;
				parT11.OP.AddRange(new Out[]
				{
					Shas.Get正方形()
				});
				parT11.OP.ScalingY(parT11.OP.GetCenter(), 0.47);
				parT11.OP.Rotation(parT11.OP.GetCenter(), -26.0);
				parT11.Closed = true;
				parT11.TextColor = Col.White;
				parT11.BrushColor = Color.FromArgb(160, Col.Black);
				parT11.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
				parT11.StringFormat.Alignment = StringAlignment.Center;
				parT11.StringFormat.LineAlignment = StringAlignment.Center;
				Action<But> <>9__47;
				Action<But> <>9__48;
				bs.Add("売却", new But1(parT11, delegate(But b)
				{
					if (CS$<>8__locals2.d)
					{
						Sou.操作.Play();
					}
					Mods.ip.Mai2Im = Sta.GameData.調教対象.GetPriceInfo();
					Mods.ip.Mai2Show = true;
					if (!Sta.GameData.調教対象.保守)
					{
						Mods.ip.TextIm = tex.売却しますか;
					}
					情報パネル 情報パネル = Mods.ip;
					Action<But> 選択yAct;
					if ((選択yAct = <>9__47) == null)
					{
						選択yAct = (<>9__47 = delegate(But t)
						{
							Color empty = Col.Empty;
							bs.Move(ref empty);
							ulong price = Sta.GameData.調教対象.GetPrice();
							Sta.GameData.所持金 = Sta.GameData.所持金.加算(price);
							Sou.精算.Play();
							Mods.ip.UpdateSub2();
							for (int i = 0; i < Sta.GameData.地下室.Length; i++)
							{
								if (Sta.GameData.地下室[i] == Sta.GameData.調教対象)
								{
									Sta.GameData.地下室[i] = null;
									break;
								}
							}
							Sta.GameData.地下室詰め();
							set(f);
							Mods.ip.SubInfoIm = string.Concat(new string[]
							{
								tex.収容番号,
								Sta.GameData.調教対象.Number,
								tex.を売却しました,
								" \r\n+",
								price.ToString("#,0")
							});
							CS$<>8__locals2.d = false;
							But but = bs["ボタン" + (Sta.GameData.調教対象.階層位置 + 1)];
							but.Action(but);
							But but2 = lv.bs.EnumBut.ToArray<But>()[Sta.GameData.調教対象.部屋位置];
							but2.Action(but2);
							if (Sta.GameData.調教対象 == null)
							{
								Mods.ip.Mai2Im = " ";
								Mods.ip.選択肢表示 = false;
							}
							else
							{
								CS$<>8__locals2.d = false;
								bs["売却"].Action(bs["売却"]);
							}
							CS$<>8__locals2.d = true;
						});
					}
					情報パネル.選択yAct = 選択yAct;
					情報パネル 情報パネル2 = Mods.ip;
					Action<But> 選択nAct;
					if ((選択nAct = <>9__48) == null)
					{
						選択nAct = (<>9__48 = delegate(But t_)
						{
							Sou.操作.Play();
							Color empty = Col.Empty;
							bs.Move(ref empty);
							Mods.ip.Mai2Show = false;
							if (Sta.GameData.調教対象 == null)
							{
								Mods.ip.TextIm = " ";
							}
							else
							{
								Mods.ip.TextIm = Sta.GameData.調教対象.GetStatus();
							}
							Mods.ip.SubInfoIm = tex.売却をキャンセルしました;
							Mods.ip.選択肢表示 = false;
						});
					}
					情報パネル2.選択nAct = 選択nAct;
					Mods.ip.選択肢表示 = !Sta.GameData.調教対象.保守;
				}));
				ParT parT12 = new ParT();
				parT12.Font = new Font("MS Gothic", 0.1f);
				parT12.PositionBase = Mods.描画バッファ.GetPosition(0.75, 0.645);
				parT12.Text = tex.全売却;
				parT12.FontSize = 0.15;
				parT12.SizeBase = sizeBase;
				parT12.OP.AddRange(new Out[]
				{
					Shas.Get正方形()
				});
				parT12.OP.ScalingY(parT12.OP.GetCenter(), 0.47);
				parT12.OP.Rotation(parT12.OP.GetCenter(), -26.0);
				parT12.Closed = true;
				parT12.TextColor = Col.White;
				parT12.BrushColor = Color.FromArgb(160, Col.Black);
				parT12.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
				parT12.StringFormat.Alignment = StringAlignment.Center;
				parT12.StringFormat.LineAlignment = StringAlignment.Center;
				bs.Add("全売却", new But1(parT12, delegate(But b)
				{
					Sou.操作.Play();
					string tb = Mods.ip.TextIm;
					ulong p;
					Mods.ip.Mai2Im = Sta.GameData.GetPriceInfo(out p);
					Mods.ip.Mai2Show = true;
					Mods.ip.TextIm = tex.保守以外の全ての奴隷を売却しますか;
					Mods.ip.選択yAct = delegate(But t)
					{
						Color empty = Col.Empty;
						bs.Move(ref empty);
						Mods.ip.Mai2Show = false;
						Sta.GameData.所持金 = Sta.GameData.所持金.加算(p);
						Sou.精算.Play();
						Mods.ip.UpdateSub2();
						for (int i = 0; i < Sta.GameData.地下室.Length; i++)
						{
							if (Sta.GameData.地下室[i] != null && !Sta.GameData.地下室[i].保守)
							{
								Sta.GameData.地下室[i] = null;
							}
						}
						Sta.GameData.地下室詰め();
						set(f);
						CS$<>8__locals2.d = false;
						if (Sta.GameData.調教対象 != null)
						{
							if (!Sta.GameData.調教対象.保守)
							{
								But but = bs["ボタン" + (Sta.GameData.調教対象.階層位置 + 1)];
								but.Action(but);
								But but2 = lv.bs.EnumBut.ToArray<But>()[Sta.GameData.調教対象.部屋位置];
								but2.Action(but2);
							}
							else if (Sta.AlwaysUseName)
							{
								Mods.setName();
							}
							else
							{
								Mods.npl.Text = tex.収容番号 + Sta.GameData.調教対象.Number + (Sta.GameData.調教対象.調教済フラグ ? ("\r\n" + Sta.GameData.調教対象.Name) : Sta.GameData.調教対象.種族);
							}
						}
						Mods.ip.SubInfoIm = tex.保守以外の全ての奴隷を売却しました + " \r\n+" + p.ToString("#,0");
						Mods.ip.TextIm = " ";
						CS$<>8__locals2.d = true;
						Mods.ip.選択肢表示 = false;
					};
					Mods.ip.選択nAct = delegate(But t_)
					{
						Sou.操作.Play();
						Color empty = Col.Empty;
						bs.Move(ref empty);
						Mods.ip.Mai2Show = false;
						Mods.ip.TextIm = tb;
						Mods.ip.SubInfoIm = tex.全売却をキャンセルしました;
						Mods.ip.選択肢表示 = false;
					};
					Mods.ip.選択肢表示 = true;
				}));
				Color f初期縁色 = Col.Black;
				Action f縁色初期化 = delegate()
				{
					foreach (But but in bs.EnumBut.Skip(10))
					{
						but.Pars.Values.First<object>().ToParT().PenColor = f初期縁色;
					}
				};
				Action<But, int> 階層選択 = delegate(But b, int o)
				{
					f縁色初期化();
					b.Pars.Values.First<object>().ToParT().PenColor = Color.Red;
					set(o);
				};
				Action 部屋選択 = delegate()
				{
					lv縁色初期化();
					if (Sta.GameData.調教対象 != null && f == Sta.GameData.調教対象.階層位置 * 15)
					{
						lv.bs[Sta.GameData.調教対象.部屋位置.ToString()].Pars.Values.First<object>().ToParT().PenColor = Color.Red;
					}
				};
				ParT parT13 = new ParT();
				parT13.Font = new Font("MS Gothic", 0.1f);
				parT13.PositionBase = Mods.描画バッファ.GetPosition(0.03, 0.03);
				parT13.Text = "1F";
				parT13.FontSize = 0.15;
				parT13.SizeBase = sizeBase;
				parT13.OP.AddRange(new Out[]
				{
					Shas.Get正方形()
				});
				parT13.BasePointBase = parT13.OP.GetCenter();
				parT13.OP.ScalingXY(parT13.BasePointBase, 0.3);
				parT13.Closed = true;
				parT13.TextColor = Col.White;
				parT13.BrushColor = Color.FromArgb(160, Col.Black);
				parT13.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
				parT13.StringFormat.Alignment = StringAlignment.Center;
				parT13.StringFormat.LineAlignment = StringAlignment.Center;
				parT13.PenColor = Color.Red;
				bs.Add("ボタン1", new But1(parT13, delegate(But b)
				{
					if (CS$<>8__locals2.d)
					{
						Sou.操作.Play();
					}
					階層選択(b, f = 0);
					部屋選択();
				}));
				ParT parT14 = new ParT();
				parT14.Font = new Font("MS Gothic", 0.1f);
				parT14.PositionBase = Mods.描画バッファ.GetPosition(0.07, 0.03);
				parT14.Text = "2F";
				parT14.FontSize = 0.15;
				parT14.SizeBase = sizeBase;
				parT14.OP.AddRange(new Out[]
				{
					Shas.Get正方形()
				});
				parT14.BasePointBase = parT14.OP.GetCenter();
				parT14.OP.ScalingXY(parT14.BasePointBase, 0.3);
				parT14.Closed = true;
				parT14.TextColor = Col.White;
				parT14.BrushColor = Color.FromArgb(160, Col.Black);
				parT14.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
				parT14.StringFormat.Alignment = StringAlignment.Center;
				parT14.StringFormat.LineAlignment = StringAlignment.Center;
				bs.Add("ボタン2", new But1(parT14, delegate(But b)
				{
					if (CS$<>8__locals2.d)
					{
						Sou.操作.Play();
					}
					階層選択(b, f = 15);
					部屋選択();
				}));
				ParT parT15 = new ParT();
				parT15.Font = new Font("MS Gothic", 0.1f);
				parT15.PositionBase = Mods.描画バッファ.GetPosition(0.11, 0.03);
				parT15.Text = "3F";
				parT15.FontSize = 0.15;
				parT15.SizeBase = sizeBase;
				parT15.OP.AddRange(new Out[]
				{
					Shas.Get正方形()
				});
				parT15.BasePointBase = parT15.OP.GetCenter();
				parT15.OP.ScalingXY(parT15.BasePointBase, 0.3);
				parT15.Closed = true;
				parT15.TextColor = Col.White;
				parT15.BrushColor = Color.FromArgb(160, Col.Black);
				parT15.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
				parT15.StringFormat.Alignment = StringAlignment.Center;
				parT15.StringFormat.LineAlignment = StringAlignment.Center;
				bs.Add("ボタン3", new But1(parT15, delegate(But b)
				{
					if (CS$<>8__locals2.d)
					{
						Sou.操作.Play();
					}
					階層選択(b, f = 30);
					部屋選択();
				}));
				ParT parT16 = new ParT();
				parT16.Font = new Font("MS Gothic", 0.1f);
				parT16.PositionBase = Mods.描画バッファ.GetPosition(0.15, 0.03);
				parT16.Text = "4F";
				parT16.FontSize = 0.15;
				parT16.SizeBase = sizeBase;
				parT16.OP.AddRange(new Out[]
				{
					Shas.Get正方形()
				});
				parT16.BasePointBase = parT16.OP.GetCenter();
				parT16.OP.ScalingXY(parT16.BasePointBase, 0.3);
				parT16.Closed = true;
				parT16.TextColor = Col.White;
				parT16.BrushColor = Color.FromArgb(160, Col.Black);
				parT16.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
				parT16.StringFormat.Alignment = StringAlignment.Center;
				parT16.StringFormat.LineAlignment = StringAlignment.Center;
				bs.Add("ボタン4", new But1(parT16, delegate(But b)
				{
					if (CS$<>8__locals2.d)
					{
						Sou.操作.Play();
					}
					階層選択(b, f = 45);
					部屋選択();
				}));
				ParT parT17 = new ParT();
				parT17.Font = new Font("MS Gothic", 0.1f);
				parT17.PositionBase = Mods.描画バッファ.GetPosition(0.19, 0.03);
				parT17.Text = "5F";
				parT17.FontSize = 0.15;
				parT17.SizeBase = sizeBase;
				parT17.OP.AddRange(new Out[]
				{
					Shas.Get正方形()
				});
				parT17.BasePointBase = parT17.OP.GetCenter();
				parT17.OP.ScalingXY(parT17.BasePointBase, 0.3);
				parT17.Closed = true;
				parT17.TextColor = Col.White;
				parT17.BrushColor = Color.FromArgb(160, Col.Black);
				parT17.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
				parT17.StringFormat.Alignment = StringAlignment.Center;
				parT17.StringFormat.LineAlignment = StringAlignment.Center;
				bs.Add("ボタン5", new But1(parT17, delegate(But b)
				{
					if (CS$<>8__locals2.d)
					{
						Sou.操作.Play();
					}
					階層選択(b, f = 60);
					部屋選択();
				}));
				ParT parT18 = new ParT();
				parT18.Font = new Font("MS Gothic", 0.1f);
				parT18.PositionBase = Mods.描画バッファ.GetPosition(0.23, 0.03);
				parT18.Text = "6F";
				parT18.FontSize = 0.15;
				parT18.SizeBase = sizeBase;
				parT18.OP.AddRange(new Out[]
				{
					Shas.Get正方形()
				});
				parT18.BasePointBase = parT18.OP.GetCenter();
				parT18.OP.ScalingXY(parT18.BasePointBase, 0.3);
				parT18.Closed = true;
				parT18.TextColor = Col.White;
				parT18.BrushColor = Color.FromArgb(160, Col.Black);
				parT18.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
				parT18.StringFormat.Alignment = StringAlignment.Center;
				parT18.StringFormat.LineAlignment = StringAlignment.Center;
				bs.Add("ボタン6", new But1(parT18, delegate(But b)
				{
					if (CS$<>8__locals2.d)
					{
						Sou.操作.Play();
					}
					階層選択(b, f = 75);
					部屋選択();
				}));
				ParT parT19 = new ParT();
				parT19.Font = new Font("MS Gothic", 0.1f);
				parT19.PositionBase = Mods.描画バッファ.GetPosition(0.27, 0.03);
				parT19.Text = "7F";
				parT19.FontSize = 0.15;
				parT19.SizeBase = sizeBase;
				parT19.OP.AddRange(new Out[]
				{
					Shas.Get正方形()
				});
				parT19.BasePointBase = parT19.OP.GetCenter();
				parT19.OP.ScalingXY(parT19.BasePointBase, 0.3);
				parT19.Closed = true;
				parT19.TextColor = Col.White;
				parT19.BrushColor = Color.FromArgb(160, Col.Black);
				parT19.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
				parT19.StringFormat.Alignment = StringAlignment.Center;
				parT19.StringFormat.LineAlignment = StringAlignment.Center;
				bs.Add("ボタン7", new But1(parT19, delegate(But b)
				{
					if (CS$<>8__locals2.d)
					{
						Sou.操作.Play();
					}
					階層選択(b, f = 90);
					部屋選択();
				}));
				ParT parT20 = new ParT();
				parT20.Font = new Font("MS Gothic", 0.1f);
				parT20.PositionBase = Mods.描画バッファ.GetPosition(0.31, 0.03);
				parT20.Text = "8F";
				parT20.FontSize = 0.15;
				parT20.SizeBase = sizeBase;
				parT20.OP.AddRange(new Out[]
				{
					Shas.Get正方形()
				});
				parT20.BasePointBase = parT20.OP.GetCenter();
				parT20.OP.ScalingXY(parT20.BasePointBase, 0.3);
				parT20.Closed = true;
				parT20.TextColor = Col.White;
				parT20.BrushColor = Color.FromArgb(160, Col.Black);
				parT20.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
				parT20.StringFormat.Alignment = StringAlignment.Center;
				parT20.StringFormat.LineAlignment = StringAlignment.Center;
				bs.Add("ボタン8", new But1(parT20, delegate(But b)
				{
					if (CS$<>8__locals2.d)
					{
						Sou.操作.Play();
					}
					階層選択(b, f = 105);
					部屋選択();
				}));
				ParT parT21 = new ParT();
				parT21.Font = new Font("MS Gothic", 0.1f);
				parT21.PositionBase = Mods.描画バッファ.GetPosition(0.35, 0.03);
				parT21.Text = "9F";
				parT21.FontSize = 0.15;
				parT21.SizeBase = sizeBase;
				parT21.OP.AddRange(new Out[]
				{
					Shas.Get正方形()
				});
				parT21.BasePointBase = parT21.OP.GetCenter();
				parT21.OP.ScalingXY(parT21.BasePointBase, 0.3);
				parT21.Closed = true;
				parT21.TextColor = Col.White;
				parT21.BrushColor = Color.FromArgb(160, Col.Black);
				parT21.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
				parT21.StringFormat.Alignment = StringAlignment.Center;
				parT21.StringFormat.LineAlignment = StringAlignment.Center;
				bs.Add("ボタン9", new But1(parT21, delegate(But b)
				{
					if (CS$<>8__locals2.d)
					{
						Sou.操作.Play();
					}
					階層選択(b, f = 120);
					部屋選択();
				}));
				ParT parT22 = new ParT();
				parT22.Font = new Font("MS Gothic", 0.1f);
				parT22.PositionBase = Mods.描画バッファ.GetPosition(0.75, 0.085);
				parT22.Text = tex.胸施術;
				parT22.FontSize = 0.15;
				parT22.SizeBase = sizeBase;
				parT22.OP.AddRange(new Out[]
				{
					Shas.Get正方形()
				});
				parT22.OP.ScalingY(parT8.OP.GetCenter(), 0.47);
				parT22.OP.Rotation(parT8.OP.GetCenter(), -26.0);
				parT22.Closed = true;
				parT22.TextColor = Col.White;
				parT22.BrushColor = Color.FromArgb(160, Col.Black);
				parT22.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
				parT22.StringFormat.Alignment = StringAlignment.Center;
				parT22.StringFormat.LineAlignment = StringAlignment.Center;
				bs.Add("胸施術", new But1(parT22, delegate(But b)
				{
					if (Sta.GameData.所持金 < (ulong)CS$<>8__locals2.胸施術価格)
					{
						Sou.操作.Play();
						Mods.ip.SubInfoIm = tex.所持金が足りません;
						return;
					}
					Sta.GameData.所持金 -= (ulong)CS$<>8__locals2.胸施術価格;
					Sou.精算.Play();
					Mods.ip.UpdateSub2();
					Sta.GameData.調教対象.ChaD.胸施術 = true;
					Mods.調教対象.Bod.胸施術();
					if (Sta.GameData.調教対象.着衣 != null)
					{
						Mods.調教対象.Set衣装(Sta.GameData.調教対象.着衣);
					}
					Sta.GameData.調教対象.体力消費();
					bs["胸施術"].Dra = false;
					Mods.ip.SubInfoIm = tex.胸の甲殻を切除しました;
					Mods.調教対象.Set表情初期化();
					Mods.調教対象.情動();
					Mods.調教対象.Set表情変化();
					if (Sta.GameData.調教対象.調教済フラグ)
					{
						Mods.調教対象.Bod.拘束具_表示 = false;
						Mods.調教対象.Bod.首輪_表示 = true;
						Mods.調教対象.Set基本姿勢();
						return;
					}
					Mods.調教対象.Bod.拘束具_表示 = true;
					Mods.調教対象.Set拘束姿勢();
				}));
				ParT parT23 = new ParT();
				parT23.Font = new Font("MS Gothic", 0.1f);
				parT23.PositionBase = Mods.描画バッファ.GetPosition(0.75, 0.165);
				parT23.Text = tex.股施術;
				parT23.FontSize = 0.15;
				parT23.SizeBase = sizeBase;
				parT23.OP.AddRange(new Out[]
				{
					Shas.Get正方形()
				});
				parT23.OP.ScalingY(parT8.OP.GetCenter(), 0.47);
				parT23.OP.Rotation(parT8.OP.GetCenter(), -26.0);
				parT23.Closed = true;
				parT23.TextColor = Col.White;
				parT23.BrushColor = Color.FromArgb(160, Col.Black);
				parT23.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
				parT23.StringFormat.Alignment = StringAlignment.Center;
				parT23.StringFormat.LineAlignment = StringAlignment.Center;
				bs.Add("股施術", new But1(parT23, delegate(But b)
				{
					if (Sta.GameData.所持金 < (ulong)CS$<>8__locals2.股施術価格)
					{
						Sou.操作.Play();
						Mods.ip.SubInfoIm = tex.所持金が足りません;
						return;
					}
					Sta.GameData.所持金 -= (ulong)CS$<>8__locals2.股施術価格;
					Sou.精算.Play();
					Mods.ip.UpdateSub2();
					Sta.GameData.調教対象.ChaD.股施術 = true;
					Mods.調教対象.Bod.股施術();
					if (Sta.GameData.調教対象.着衣 != null)
					{
						Mods.調教対象.Set衣装(Sta.GameData.調教対象.着衣);
					}
					Sta.GameData.調教対象.体力消費();
					bs["股施術"].Dra = false;
					Mods.ip.SubInfoIm = tex.股の + (Mods.調教対象.Bod.Is蠍 ? tex.甲殻 : tex.鱗) + tex.を切除しました;
					Mods.調教対象.Set表情初期化();
					Mods.調教対象.情動();
					Mods.調教対象.Set表情変化();
					if (Sta.GameData.調教対象.調教済フラグ)
					{
						Mods.調教対象.Bod.拘束具_表示 = false;
						Mods.調教対象.Bod.首輪_表示 = true;
						Mods.調教対象.Set基本姿勢();
						return;
					}
					Mods.調教対象.Bod.拘束具_表示 = true;
					Mods.調教対象.Set拘束姿勢();
				}));
				ParT parT24 = new ParT();
				parT24.Font = new Font("MS Gothic", 0.1f);
				parT24.PositionBase = Mods.描画バッファ.GetPosition(0.75, 0.245);
				parT24.Text = tex.淫紋;
				parT24.FontSize = 0.15;
				parT24.SizeBase = sizeBase;
				parT24.OP.AddRange(new Out[]
				{
					Shas.Get正方形()
				});
				parT24.OP.ScalingY(parT8.OP.GetCenter(), 0.47);
				parT24.OP.Rotation(parT8.OP.GetCenter(), -26.0);
				parT24.Closed = true;
				parT24.TextColor = Col.White;
				parT24.BrushColor = Color.FromArgb(160, Col.Black);
				parT24.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
				parT24.StringFormat.Alignment = StringAlignment.Center;
				parT24.StringFormat.LineAlignment = StringAlignment.Center;
				bs.Add("淫紋", new But1(parT24, delegate(But b)
				{
					if (Sta.GameData.所持金 < (ulong)CS$<>8__locals2.淫紋価格)
					{
						Sou.操作.Play();
						Mods.ip.SubInfoIm = tex.所持金が足りません;
						return;
					}
					Sta.GameData.所持金 -= (ulong)CS$<>8__locals2.淫紋価格;
					Sou.精算.Play();
					Mods.ip.UpdateSub2();
					Sta.GameData.調教対象.ChaD.タトゥ = true;
					Mods.調教対象.Bod.タトゥ();
					Sta.GameData.調教対象.発情フラグ = true;
					Sta.GameData.調教対象.体力消費();
					bs["淫紋"].Dra = false;
					Mods.ip.SubInfoIm = tex.淫紋を刻みました;
					Mods.調教対象.Set表情初期化();
					Mods.調教対象.情動();
					Mods.調教対象.Set表情変化();
					if (Sta.GameData.調教対象.調教済フラグ)
					{
						Mods.調教対象.Bod.拘束具_表示 = false;
						Mods.調教対象.Bod.首輪_表示 = true;
						Mods.調教対象.Set基本姿勢();
					}
					else
					{
						Mods.調教対象.Bod.拘束具_表示 = true;
						Mods.調教対象.Set拘束姿勢();
					}
					if (Mods.調教対象.Bod.Is獣)
					{
						Mods.調教対象.Bod.EI半中1.Updatef = true;
					}
				}));
				ParT parT25 = new ParT();
				parT25.Font = new Font("MS Gothic", 0.1f);
				parT25.PositionBase = Mods.描画バッファ.GetPosition(0.75, 0.325);
				parT25.Text = tex.衣装;
				parT25.FontSize = 0.15;
				parT25.SizeBase = sizeBase;
				parT25.OP.AddRange(new Out[]
				{
					Shas.Get正方形()
				});
				parT25.OP.ScalingY(parT9.OP.GetCenter(), 0.47);
				parT25.OP.Rotation(parT9.OP.GetCenter(), -26.0);
				parT25.Closed = true;
				parT25.TextColor = Col.White;
				parT25.BrushColor = Color.FromArgb(160, Col.Black);
				parT25.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
				parT25.StringFormat.Alignment = StringAlignment.Center;
				parT25.StringFormat.LineAlignment = StringAlignment.Center;
				bs.Add("衣装", new But1(parT25, delegate(But b)
				{
					if (Sta.GameData.所持金 < (ulong)CS$<>8__locals2.衣装変更価格)
					{
						Sou.操作.Play();
						Mods.ip.SubInfoIm = tex.所持金が足りません;
						return;
					}
					Sta.GameData.所持金 -= (ulong)CS$<>8__locals2.衣装変更価格;
					Sou.精算.Play();
					Mods.ip.UpdateSub2();
					Sta.GameData.調教対象.Change衣装();
					Mods.調教対象.Set衣装(Sta.GameData.調教対象.着衣);
					Mods.ip.SubInfoIm = tex.衣装を変更しました;
					Mods.調教対象.Set表情初期化();
					Mods.調教対象.情動();
					Mods.調教対象.Set表情変化();
					if (Sta.GameData.調教対象.調教済フラグ)
					{
						Mods.調教対象.Bod.拘束具_表示 = false;
						Mods.調教対象.Bod.首輪_表示 = true;
						Mods.調教対象.Set基本姿勢();
						return;
					}
					Mods.調教対象.Bod.拘束具_表示 = true;
					Mods.調教対象.Set拘束姿勢();
				}));
				bs.Add("MoveRoomDown", Mods.MoveRoomDownButton(mod));
				bs.Add("MoveRoomUp", Mods.MoveRoomUpButton(mod));
				bs.Add("MoveFloorDown", Mods.MoveFloorDownButton(mod));
				bs.Add("MoveFloorUp", Mods.MoveFloorUpButton(mod));
				bs.SetHitColor(CS$<>8__locals2.CS$<>8__locals1.Med);
				mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
				{
					if (!Mods.processing)
					{
						if (Mods.SDShow)
						{
							Mods.セ\u30FCブデ\u30FCタ.Down(ref hc);
							if (mb == MouseButtons.Right && !Mods.processing)
							{
								Sou.操作.Play();
								Mods.SDShow = false;
								Mods.ip.Up(ref hc);
								Mods.dbs.Move(ref hc);
								return;
							}
						}
						else
						{
							if (mb == MouseButtons.Left)
							{
								if (!Mods.ip.Mai2Show)
								{
									Mods.dbs.Down(ref hc);
									bs.Down(ref hc);
								}
								lv.Down(ref hc);
								Mods.ip.Down(ref hc);
								return;
							}
							if (mb == MouseButtons.Right)
							{
								if (!Mods.ip.Mai2Show)
								{
									bs["ボタン0"].Action(bs["ボタン0"]);
									return;
								}
								Mods.ip.nb.Action(Mods.ip.nb);
							}
						}
					}
				};
				mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
				{
					if (!Mods.processing)
					{
						if (Mods.SDShow)
						{
							Mods.セ\u30FCブデ\u30FCタ.Up(ref hc);
							return;
						}
						if (mb == MouseButtons.Left)
						{
							if (!Mods.ip.Mai2Show)
							{
								Mods.dbs.Up(ref hc);
								bs.Up(ref hc);
							}
							lv.Up(ref hc);
							Mods.ip.Up(ref hc);
						}
					}
				};
				mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
				{
					if (!Mods.processing)
					{
						if (Mods.SDShow)
						{
							Mods.セ\u30FCブデ\u30FCタ.Move(ref hc);
							return;
						}
						if (!Mods.ip.Mai2Show)
						{
							Mods.dbs.Move(ref hc);
							bs.Move(ref hc);
							if (bs["胸施術"].Pars.Values.First<object>().ToPar().HitColor == hc && !(Mods.ip.SubInfoIm == tex.胸の甲殻を切除しました) && !(Mods.ip.SubInfoIm == tex.所持金が足りません))
							{
								Mods.ip.SubInfoIm = tex.胸の甲殻を切除します + "(-" + CS$<>8__locals2.胸施術価格.ToString("#,0") + ")";
							}
							else if (Mods.ip.SubInfoIm == tex.胸の甲殻を切除します + "(-" + CS$<>8__locals2.胸施術価格.ToString("#,0") + ")")
							{
								Mods.si.Set(false);
							}
							if (Mods.調教対象 != null)
							{
								if (bs["股施術"].Pars.Values.First<object>().ToPar().HitColor == hc && !(Mods.ip.SubInfoIm == tex.股の + (Mods.調教対象.Bod.Is蛇 ? tex.鱗 : tex.甲殻) + tex.を切除しました) && !(Mods.ip.SubInfoIm == tex.所持金が足りません))
								{
									Mods.ip.SubInfoIm = string.Concat(new string[]
									{
										tex.股の,
										Mods.調教対象.Bod.Is蛇 ? tex.鱗 : tex.甲殻,
										tex.を切除します,
										"(-",
										CS$<>8__locals2.股施術価格.ToString("#,0"),
										")"
									});
								}
								else if (Mods.ip.SubInfoIm == string.Concat(new string[]
								{
									tex.股の,
									Mods.調教対象.Bod.Is蛇 ? tex.鱗 : tex.甲殻,
									tex.を切除します,
									"(-",
									CS$<>8__locals2.股施術価格.ToString("#,0"),
									")"
								}))
								{
									Mods.si.Set(false);
								}
							}
							if (bs["淫紋"].Pars.Values.First<object>().ToPar().HitColor == hc && !(Mods.ip.SubInfoIm == tex.淫紋を刻みました) && !(Mods.ip.SubInfoIm == tex.所持金が足りません))
							{
								Mods.ip.SubInfoIm = tex.淫紋を刻みます + "(-" + CS$<>8__locals2.淫紋価格.ToString("#,0") + ")";
							}
							else if (Mods.ip.SubInfoIm == tex.淫紋を刻みます + "(-" + CS$<>8__locals2.淫紋価格.ToString("#,0") + ")")
							{
								Mods.si.Set(false);
							}
							if (bs["衣装"].Pars.Values.First<object>().ToPar().HitColor == hc && !(Mods.ip.SubInfoIm == tex.衣装を変更しました) && !(Mods.ip.SubInfoIm == tex.所持金が足りません))
							{
								Mods.ip.SubInfoIm = tex.衣装を変更します + "(-" + CS$<>8__locals2.衣装変更価格.ToString("#,0") + ")";
							}
							else if (Mods.ip.SubInfoIm == tex.衣装を変更します + "(-" + CS$<>8__locals2.衣装変更価格.ToString("#,0") + ")")
							{
								Mods.si.Set(false);
							}
							if (bs["保守"].Pars.Values.First<object>().ToPar().HitColor == hc && !(Mods.ip.SubInfoIm == tex.奴隷を保守対象に設定しました) && !(Mods.ip.SubInfoIm == tex.奴隷の保守設定を解除しました))
							{
								Mods.ip.SubInfoIm = tex.奴隷の保守設定を切り替えます;
							}
							else if (Mods.ip.SubInfoIm == tex.奴隷の保守設定を切り替えます)
							{
								Mods.si.Set(false);
							}
							if (bs["一般労働"].Pars.Values.First<object>().ToPar().HitColor == hc && !(Mods.ip.SubInfoIm == tex.奴隷を一般労働に設定しました) && !(Mods.ip.SubInfoIm == tex.奴隷の一般労働を解除しました))
							{
								Mods.ip.SubInfoIm = tex.奴隷の一般労働設定を切り替えます;
							}
							else if (Mods.ip.SubInfoIm == tex.奴隷の一般労働設定を切り替えます)
							{
								Mods.si.Set(false);
							}
							if (bs["娼婦労働"].Pars.Values.First<object>().ToPar().HitColor == hc && !(Mods.ip.SubInfoIm == tex.奴隷を娼婦労働に設定しました) && !(Mods.ip.SubInfoIm == tex.奴隷の娼婦労働を解除しました))
							{
								Mods.ip.SubInfoIm = tex.奴隷の娼婦労働設定を切り替えます;
							}
							else if (Mods.ip.SubInfoIm == tex.奴隷の娼婦労働設定を切り替えます)
							{
								Mods.si.Set(false);
							}
							if (bs["売却"].Pars.Values.First<object>().ToPar().HitColor == hc)
							{
								Mods.ip.SubInfoIm = tex.奴隷を売却します;
							}
							else if (Mods.ip.SubInfoIm == tex.奴隷を売却します)
							{
								Mods.si.Set(false);
							}
							if (bs["全一般"].Pars.Values.First<object>().ToPar().HitColor == hc && !(Mods.ip.SubInfoIm == tex.労働可能な全ての奴隷に一般労働を設定しました))
							{
								Mods.ip.SubInfoIm = tex.労働可能な全ての奴隷を働かせます;
							}
							else if (Mods.ip.SubInfoIm == tex.労働可能な全ての奴隷を働かせます)
							{
								Mods.si.Set(false);
							}
							if (bs["全娼婦"].Pars.Values.First<object>().ToPar().HitColor == hc && !(Mods.ip.SubInfoIm == tex.労働可能な全ての奴隷に娼婦労働を設定しました))
							{
								Mods.ip.SubInfoIm = tex.労働可能な全ての奴隷を娼婦として働かせます;
							}
							else if (Mods.ip.SubInfoIm == tex.労働可能な全ての奴隷を娼婦として働かせます)
							{
								Mods.si.Set(false);
							}
							if (bs["全解除"].Pars.Values.First<object>().ToPar().HitColor == hc && !(Mods.ip.SubInfoIm == tex.労働中の全ての奴隷の労働を解除しました))
							{
								Mods.ip.SubInfoIm = tex.全ての奴隷の労働を解除します;
							}
							else if (Mods.ip.SubInfoIm == tex.全ての奴隷の労働を解除します)
							{
								Mods.si.Set(false);
							}
							if (bs["全売却"].Pars.Values.First<object>().ToPar().HitColor == hc && !Mods.ip.SubInfoIm.StartsWith(tex.保守以外の全ての奴隷を売却しました) && !(Mods.ip.SubInfoIm == tex.全売却をキャンセルしました))
							{
								Mods.ip.SubInfoIm = tex.保守以外の全ての奴隷を売却します;
							}
							else if (Mods.ip.SubInfoIm == tex.保守以外の全ての奴隷を売却します)
							{
								Mods.si.Set(false);
							}
							Mods.Player説明(ref hc, delegate
							{
								Mods.si.Set(false);
							});
						}
						lv.Move(ref hc);
						Mods.ip.Move(ref hc);
					}
				};
				mod.Leave = delegate(MouseButtons mb, Vector2D cp, Color hc)
				{
					if (!Mods.processing)
					{
						if (Mods.SDShow)
						{
							Mods.セ\u30FCブデ\u30FCタ.Leave();
							return;
						}
						if (!Mods.ip.Mai2Show)
						{
							Mods.dbs.Leave();
							bs.Leave();
						}
						lv.Leave();
					}
				};
				mod.Wheel = delegate(MouseButtons mb, Vector2D cp, int dt, Color hc)
				{
					int num = 0;
					using (IEnumerator<But> enumerator = bs.EnumBut.Skip(12).GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (enumerator.Current.Pars.Values.First<object>().ToParT().PenColor == Color.Red)
							{
								break;
							}
							num++;
						}
					}
					int num2 = 0;
					using (IEnumerator<But> enumerator = lv.bs.EnumBut.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (enumerator.Current.Pars.Values.First<object>().ToParT().PenColor == Color.Red)
							{
								break;
							}
							num2++;
						}
					}
					int num3 = num2 - dt.Sign();
					CS$<>8__locals2.d = false;
					if (num3 < 0 && num > 0)
					{
						But but = bs["ボタン" + num];
						but.Action(but);
						num3 = 14;
					}
					else if (num3 > 14 && num < Sta.GameData.フロア数 - 1)
					{
						But but2 = bs["ボタン" + (num + 2)];
						but2.Action(but2);
						num3 = 0;
					}
					CS$<>8__locals2.d = true;
					But but3 = lv.bs[num3.Limit(0, 15).ToString()];
					but3.Action(but3);
					if (Mods.ip.Mai2Show)
					{
						if (Sta.GameData.調教対象 == null)
						{
							Mods.ip.Mai2Im = " ";
							Mods.ip.選択肢表示 = false;
							return;
						}
						CS$<>8__locals2.d = false;
						bs["売却"].Action(bs["売却"]);
						CS$<>8__locals2.d = true;
					}
				};
				mod.Setting = delegate()
				{
					if (CS$<>8__locals2.CS$<>8__locals1.Med.Modeb != "情報設定")
					{
						for (int i = 1; i <= 9; i++)
						{
							bs["ボタン" + i].Dra = false;
						}
						for (int j = 1; j <= Sta.GameData.フロア数; j++)
						{
							bs["ボタン" + j].Dra = true;
						}
						Mods.ip.UpdateSub2();
						Mods.ip.MaiShow = true;
						Mods.ip.Mai.Feed.Dra = false;
						Mods.ip.Mai2Show = false;
						Mods.ip.SubShow = true;
						Mods.ip.Sub2Show = true;
						CS$<>8__locals2.d = false;
						Act.UI.ステ\u30FCト描画 = false;
						if (Sta.GameData.調教対象 != null)
						{
							But but = bs["ボタン" + (Sta.GameData.調教対象.階層位置 + 1)];
							but.Action(but);
							lv縁色初期化();
							lv.bs[Sta.GameData.調教対象.部屋位置.ToString()].Pars.Values.First<object>().ToParT().PenColor = Color.Red;
							bs["子"].Action(bs["子"]);
						}
						else
						{
							Mods.ip.TextIm = tex.対象が設定されていません;
							階層選択(bs["ボタン" + (f / 15 + 1)], f);
							SetUI(null);
							int num = 0;
							using (IEnumerator<But> enumerator = lv.bs.EnumBut.GetEnumerator())
							{
								while (enumerator.MoveNext())
								{
									if (enumerator.Current.Pars.Values.First<object>().ToParT().PenColor == Color.Red)
									{
										break;
									}
									num++;
								}
							}
							But but2 = lv.bs[num.Limit(0, 15).ToString()];
							but2.Action(but2);
						}
						CS$<>8__locals2.d = true;
						Mods.si.Set(false);
						if (Sta.BigWindow && !Sta.NoScaling)
						{
							Mods.npl.ParT.PositionBase = new Vector2D(0.125, 0.035);
						}
						else if (Sta.BigWindow)
						{
							Mods.npl.ParT.PositionBase = new Vector2D(0.095, 0.035);
						}
						else
						{
							Mods.npl.ParT.PositionBase = new Vector2D(Mods.ip.MaiB.Position.X, 0.026);
						}
					}
				};
				Mods.対象描画 = delegate(Are a, FPS FPS)
				{
					CS$<>8__locals2.CS$<>8__locals1.Med.GH.Clear(Col.Transparent);
					if (a.GH != null)
					{
						a.GH.Clear(Col.Transparent);
					}
					a.Draw(Mods.地下室背景);
					if (Mods.調教対象 != null)
					{
						Mods.調教対象.Draw(a, FPS);
						Act.UI.DrawState(a);
					}
					a.Draw(Mods.npl.ParT);
					lv.Draw(a);
					bs.Draw(a);
					Mods.dbs.Draw(a);
					Mods.ip.Draw(a, FPS);
					if (Mods.SDShow)
					{
						Mods.セ\u30FCブデ\u30FCタ.Draw(a);
					}
					CS$<>8__locals2.CS$<>8__locals1.Med.Draw(a);
				};
				mod.Draw = delegate(FPS FPS)
				{
					Mods.映転(CS$<>8__locals2.CS$<>8__locals1.Med, Mods.描画バッファ, FPS, Mods.対象描画);
				};
				mod.Dispose = delegate()
				{
					lv.Dispose();
					bs.Dispose();
				};
				Mods.対象UI初期化 = delegate()
				{
					f = 0;
					Mods.npl.Text = "No Slave";
					lv縁色初期化();
				};
				result = mod;
			}
			catch (Exception)
			{
				result = null;
			}
			return result;
		}

		public static Mod 祝福(Med Med)
		{
			Mods.<>c__DisplayClass99_0 CS$<>8__locals1 = new Mods.<>c__DisplayClass99_0();
			CS$<>8__locals1.Med = Med;
			Mod mod = new Mod();
			Mods.<>c__DisplayClass99_1 CS$<>8__locals2 = new Mods.<>c__DisplayClass99_1();
			CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
			CS$<>8__locals2.祝福 = null;
			CS$<>8__locals2.d = false;
			CS$<>8__locals2.l = new Lab(CS$<>8__locals2.CS$<>8__locals1.Med, Mods.描画バッファ, "ラベル1", new Vector2D(Mods.ip.MaiB.Position.X, 0.026), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "No blessing", Col.White, Col.Black, Mods.ip.MaiB.BrushColor, Col.Black, false);
			CS$<>8__locals2.bs = new Buts();
			CS$<>8__locals2.祝福なし = delegate()
			{
				CS$<>8__locals2.bs["子"].Dra = false;
				CS$<>8__locals2.bs["親形質1"].Dra = false;
				CS$<>8__locals2.bs["親形質2"].Dra = false;
				CS$<>8__locals2.bs["祝福解除"].Dra = false;
				CS$<>8__locals2.l.Text = "No blessing";
				Mods.ip.MaiShow = false;
				if (CS$<>8__locals2.祝福 != null)
				{
					CS$<>8__locals2.祝福.Dispose();
					CS$<>8__locals2.祝福 = null;
				}
			};
			double sizeBase = 0.05;
			if (Sta.BigWindow && !Sta.NoScaling)
			{
				sizeBase = 0.068;
			}
			ParT parT = new ParT();
			parT.Font = new Font("MS Gothic", 0.1f);
			parT.PositionBase = Mods.描画バッファ.GetPosition(0.85, 0.02);
			parT.Text = tex.戻る;
			parT.FontSize = 0.15;
			parT.SizeBase = sizeBase;
			parT.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT.OP.ScalingY(parT.OP.GetCenter(), 0.47);
			parT.OP.Rotation(parT.OP.GetCenter(), -26.0);
			parT.Closed = true;
			parT.TextColor = Col.White;
			parT.BrushColor = Color.FromArgb(160, Col.Black);
			parT.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT.StringFormat.Alignment = StringAlignment.Center;
			parT.StringFormat.LineAlignment = StringAlignment.Center;
			CS$<>8__locals2.bs.Add("ボタン0", new But1(parT, delegate(But a)
			{
				Sou.操作.Play();
				CS$<>8__locals2.CS$<>8__locals1.Med.Mode = "メインフォーム";
			}));
			Action<Buts> rs1 = delegate(Buts bs_)
			{
				Color penColor = bs_["ボタン0"].Pars.Values.First<object>().ToParT().PenColor;
				foreach (But but in bs_.EnumBut.Skip(1))
				{
					but.Pars.Values.First<object>().ToParT().PenColor = penColor;
				}
			};
			ParT parT2 = new ParT();
			parT2.Font = new Font("MS Gothic", 0.1f);
			parT2.PositionBase = Mods.描画バッファ.GetPosition(0.85, 0.1);
			parT2.Text = tex.子;
			parT2.FontSize = 0.15;
			parT2.SizeBase = sizeBase;
			parT2.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT2.OP.ScalingY(parT2.OP.GetCenter(), 0.47);
			parT2.OP.Rotation(parT2.OP.GetCenter(), -26.0);
			parT2.Closed = true;
			parT2.TextColor = Col.White;
			parT2.BrushColor = Color.FromArgb(160, Col.Black);
			parT2.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT2.StringFormat.Alignment = StringAlignment.Center;
			parT2.StringFormat.LineAlignment = StringAlignment.Center;
			parT2.PenColor = Color.Red;
			CS$<>8__locals2.bs.Add("子", new But1(parT2, delegate(But bu)
			{
				if (CS$<>8__locals2.d)
				{
					Sou.操作.Play();
				}
				rs1(CS$<>8__locals2.bs);
				bu.Pars.Values.First<object>().ToParT().PenColor = Color.Red;
				if (Sta.GameData.祝福 != null)
				{
					CS$<>8__locals2.l.Text = Sta.GameData.祝福.Name;
					Mods.ip.TextIm = Sta.GameData.祝福.GetStatus();
					if (CS$<>8__locals2.祝福 != null)
					{
						CS$<>8__locals2.祝福.Dispose();
					}
					CS$<>8__locals2.祝福 = new Cha(CS$<>8__locals2.CS$<>8__locals1.Med, Mods.描画バッファ, Sta.GameData.祝福.ChaD);
					if (CS$<>8__locals2.祝福.Bod.Is双眼)
					{
						CS$<>8__locals2.祝福.両目_見つめ();
					}
					if (CS$<>8__locals2.祝福.Bod.Is頬眼)
					{
						CS$<>8__locals2.祝福.両頬目_見つめ();
					}
					if (CS$<>8__locals2.祝福.Bod.Is単眼)
					{
						CS$<>8__locals2.祝福.単目_見つめ();
					}
					if (CS$<>8__locals2.祝福.Bod.Is額眼)
					{
						CS$<>8__locals2.祝福.額目_見つめ();
					}
					if (Sta.GameData.祝福.種族 == tex.ヴィオランテ)
					{
						CS$<>8__locals2.祝福.両瞼_卑();
						CS$<>8__locals2.祝福.両瞼_半1();
					}
					CS$<>8__locals2.祝福.口_閉笑();
					CS$<>8__locals2.祝福.Set基本姿勢();
				}
			}));
			ParT parT3 = new ParT();
			parT3.Font = new Font("MS Gothic", 0.1f);
			parT3.PositionBase = Mods.描画バッファ.GetPosition(0.85, 0.18);
			parT3.Text = tex.親形質1;
			parT3.FontSize = 0.15;
			parT3.SizeBase = sizeBase;
			parT3.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT3.OP.ScalingY(parT3.OP.GetCenter(), 0.47);
			parT3.OP.Rotation(parT3.OP.GetCenter(), -26.0);
			parT3.Closed = true;
			parT3.TextColor = Col.White;
			parT3.BrushColor = Color.FromArgb(160, Col.Black);
			parT3.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT3.StringFormat.Alignment = StringAlignment.Center;
			parT3.StringFormat.LineAlignment = StringAlignment.Center;
			CS$<>8__locals2.bs.Add("親形質1", new But1(parT3, delegate(But bu)
			{
				Sou.操作.Play();
				rs1(CS$<>8__locals2.bs);
				bu.Pars.Values.First<object>().ToParT().PenColor = Color.Red;
				if (Sta.GameData.祝福 != null)
				{
					CS$<>8__locals2.l.Text = tex.親形質1;
					Mods.ip.TextIm = Sta.GameData.祝福.母方.GetStatus();
					if (CS$<>8__locals2.祝福 != null)
					{
						CS$<>8__locals2.祝福.Dispose();
					}
					CS$<>8__locals2.祝福 = new Cha(CS$<>8__locals2.CS$<>8__locals1.Med, Mods.描画バッファ, Sta.GameData.祝福.母方.ChaD);
					if (CS$<>8__locals2.祝福.Bod.Is双眼)
					{
						CS$<>8__locals2.祝福.両目_見つめ();
					}
					if (CS$<>8__locals2.祝福.Bod.Is頬眼)
					{
						CS$<>8__locals2.祝福.両頬目_見つめ();
					}
					if (CS$<>8__locals2.祝福.Bod.Is単眼)
					{
						CS$<>8__locals2.祝福.単目_見つめ();
					}
					if (CS$<>8__locals2.祝福.Bod.Is額眼)
					{
						CS$<>8__locals2.祝福.額目_見つめ();
					}
					if (Sta.GameData.祝福.母方.種族 == tex.ヴィオランテ)
					{
						CS$<>8__locals2.祝福.両瞼_卑();
						CS$<>8__locals2.祝福.両瞼_半1();
					}
					CS$<>8__locals2.祝福.口_閉笑();
					CS$<>8__locals2.祝福.Set基本姿勢();
				}
			}));
			ParT parT4 = new ParT();
			parT4.Font = new Font("MS Gothic", 0.1f);
			parT4.PositionBase = Mods.描画バッファ.GetPosition(0.85, 0.26);
			parT4.Text = tex.親形質2;
			parT4.FontSize = 0.15;
			parT4.SizeBase = sizeBase;
			parT4.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT4.OP.ScalingY(parT4.OP.GetCenter(), 0.47);
			parT4.OP.Rotation(parT4.OP.GetCenter(), -26.0);
			parT4.Closed = true;
			parT4.TextColor = Col.White;
			parT4.BrushColor = Color.FromArgb(160, Col.Black);
			parT4.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT4.StringFormat.Alignment = StringAlignment.Center;
			parT4.StringFormat.LineAlignment = StringAlignment.Center;
			CS$<>8__locals2.bs.Add("親形質2", new But1(parT4, delegate(But bu)
			{
				Sou.操作.Play();
				rs1(CS$<>8__locals2.bs);
				bu.Pars.Values.First<object>().ToParT().PenColor = Color.Red;
				if (Sta.GameData.祝福 != null)
				{
					CS$<>8__locals2.l.Text = tex.親形質2;
					Mods.ip.TextIm = Sta.GameData.祝福.父方.GetStatus();
					if (CS$<>8__locals2.祝福 != null)
					{
						CS$<>8__locals2.祝福.Dispose();
					}
					CS$<>8__locals2.祝福 = new Cha(CS$<>8__locals2.CS$<>8__locals1.Med, Mods.描画バッファ, Sta.GameData.祝福.父方.ChaD);
					if (CS$<>8__locals2.祝福.Bod.Is双眼)
					{
						CS$<>8__locals2.祝福.両目_見つめ();
					}
					if (CS$<>8__locals2.祝福.Bod.Is頬眼)
					{
						CS$<>8__locals2.祝福.両頬目_見つめ();
					}
					if (CS$<>8__locals2.祝福.Bod.Is単眼)
					{
						CS$<>8__locals2.祝福.単目_見つめ();
					}
					if (CS$<>8__locals2.祝福.Bod.Is額眼)
					{
						CS$<>8__locals2.祝福.額目_見つめ();
					}
					if (Sta.GameData.祝福.父方.種族 == tex.ヴィオランテ)
					{
						CS$<>8__locals2.祝福.両瞼_卑();
						CS$<>8__locals2.祝福.両瞼_半1();
					}
					CS$<>8__locals2.祝福.口_閉笑();
					CS$<>8__locals2.祝福.Set基本姿勢();
				}
			}));
			ParT parT5 = new ParT();
			parT5.Font = new Font("MS Gothic", 0.1f);
			parT5.PositionBase = Mods.描画バッファ.GetPosition(0.85, 0.34);
			parT5.Text = tex.祝福解除;
			parT5.FontSize = 0.15;
			parT5.SizeBase = sizeBase;
			parT5.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT5.OP.ScalingY(parT5.OP.GetCenter(), 0.47);
			parT5.OP.Rotation(parT5.OP.GetCenter(), -26.0);
			parT5.Closed = true;
			parT5.TextColor = Col.White;
			parT5.BrushColor = Color.FromArgb(160, Col.Black);
			parT5.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT5.StringFormat.Alignment = StringAlignment.Center;
			parT5.StringFormat.LineAlignment = StringAlignment.Center;
			CS$<>8__locals2.bs.Add("祝福解除", new But1(parT5, delegate(But bu)
			{
				Sou.解除.Play();
				Sta.GameData.祝福 = null;
				CS$<>8__locals2.祝福なし();
				Mods.ip.SubInfoIm = tex.祝福を解除しました;
			}));
			CS$<>8__locals2.bs.SetHitColor(CS$<>8__locals2.CS$<>8__locals1.Med);
			CS$<>8__locals2.subinfo = delegate()
			{
				if (Sta.GameData.祝福 != null)
				{
					Mods.ip.SubInfoIm = Sta.GameData.祝福.Name + tex.から祝福を受けています;
					return;
				}
				Mods.ip.SubInfoIm = tex.祝福されていません;
			};
			mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				if (!Mods.processing)
				{
					if (Mods.SDShow)
					{
						Mods.セ\u30FCブデ\u30FCタ.Down(ref hc);
						if (mb == MouseButtons.Right && !Mods.processing)
						{
							Sou.操作.Play();
							Mods.SDShow = false;
							Mods.ip.Up(ref hc);
							Mods.dbs.Move(ref hc);
							return;
						}
					}
					else
					{
						if (mb == MouseButtons.Left)
						{
							if (!Mods.ip.選択肢表示)
							{
								Mods.dbs.Down(ref hc);
								CS$<>8__locals2.bs.Down(ref hc);
							}
							Mods.ip.Down(ref hc);
							return;
						}
						if (mb == MouseButtons.Right)
						{
							if (!Mods.ip.選択肢表示)
							{
								CS$<>8__locals2.bs["ボタン0"].Action(CS$<>8__locals2.bs["ボタン0"]);
								return;
							}
							Mods.ip.nb.Action(Mods.ip.nb);
						}
					}
				}
			};
			mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				if (!Mods.processing)
				{
					if (Mods.SDShow)
					{
						Mods.セ\u30FCブデ\u30FCタ.Up(ref hc);
						return;
					}
					if (mb == MouseButtons.Left)
					{
						if (!Mods.ip.選択肢表示)
						{
							Mods.dbs.Up(ref hc);
							CS$<>8__locals2.bs.Up(ref hc);
						}
						Mods.ip.Up(ref hc);
					}
				}
			};
			mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				if (!Mods.processing)
				{
					if (Mods.SDShow)
					{
						Mods.セ\u30FCブデ\u30FCタ.Move(ref hc);
						return;
					}
					if (!Mods.ip.選択肢表示)
					{
						Mods.dbs.Move(ref hc);
						CS$<>8__locals2.bs.Move(ref hc);
						Mods.Player説明(ref hc, CS$<>8__locals2.subinfo);
					}
					Mods.ip.Move(ref hc);
				}
			};
			mod.Leave = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				if (!Mods.processing)
				{
					if (Mods.SDShow)
					{
						Mods.セ\u30FCブデ\u30FCタ.Leave();
						return;
					}
					if (!Mods.ip.選択肢表示)
					{
						Mods.dbs.Leave();
						CS$<>8__locals2.bs.Leave();
					}
				}
			};
			mod.Wheel = delegate(MouseButtons mb, Vector2D cp, int dt, Color hc)
			{
			};
			mod.Setting = delegate()
			{
				if (CS$<>8__locals2.CS$<>8__locals1.Med.Modeb != "情報設定")
				{
					Mods.ip.UpdateSub2();
					Mods.ip.MaiShow = true;
					Mods.ip.Mai.Feed.Dra = false;
					Mods.ip.Mai2Show = false;
					Mods.ip.SubShow = true;
					Mods.ip.Sub2Show = true;
					if (Sta.GameData.祝福 != null)
					{
						CS$<>8__locals2.bs["子"].Dra = true;
						CS$<>8__locals2.bs["親形質1"].Dra = true;
						CS$<>8__locals2.bs["親形質2"].Dra = true;
						CS$<>8__locals2.bs["祝福解除"].Dra = true;
						Mods.ip.MaiShow = true;
					}
					else
					{
						CS$<>8__locals2.祝福なし();
					}
					CS$<>8__locals2.subinfo();
					CS$<>8__locals2.d = false;
					CS$<>8__locals2.bs["子"].Action(CS$<>8__locals2.bs["子"]);
					CS$<>8__locals2.d = true;
				}
			};
			Mods.祝福描画 = delegate(Are a, FPS FPS)
			{
				CS$<>8__locals2.CS$<>8__locals1.Med.GH.Clear(Col.Transparent);
				if (a.GH != null)
				{
					a.GH.Clear(Col.Transparent);
				}
				a.Draw(Mods.地下室背景);
				if (CS$<>8__locals2.祝福 != null)
				{
					CS$<>8__locals2.祝福.Draw(a, FPS);
				}
				a.Draw(CS$<>8__locals2.l.ParT);
				CS$<>8__locals2.bs.Draw(a);
				Mods.dbs.Draw(a);
				Mods.ip.Draw(a, FPS);
				if (Mods.SDShow)
				{
					Mods.セ\u30FCブデ\u30FCタ.Draw(a);
				}
				CS$<>8__locals2.CS$<>8__locals1.Med.Draw(a);
			};
			mod.Draw = delegate(FPS FPS)
			{
				Mods.映転(CS$<>8__locals2.CS$<>8__locals1.Med, Mods.描画バッファ, FPS, Mods.祝福描画);
			};
			mod.Dispose = delegate()
			{
				if (CS$<>8__locals2.祝福 != null)
				{
					CS$<>8__locals2.祝福.Dispose();
				}
				CS$<>8__locals2.l.Dispose();
				CS$<>8__locals2.bs.Dispose();
			};
			return mod;
		}

		public static Mod 事務所(Med Med)
		{
			Mods.<>c__DisplayClass100_0 CS$<>8__locals1 = new Mods.<>c__DisplayClass100_0();
			CS$<>8__locals1.Med = Med;
			Mod mod = new Mod();
			Buts bs = new Buts();
			double sizeBase = 0.05;
			if (Sta.BigWindow && !Sta.NoScaling)
			{
				sizeBase = 0.068;
			}
			ParT parT = new ParT();
			parT.Font = new Font("MS Gothic", 0.1f);
			parT.PositionBase = Mods.描画バッファ.GetPosition(0.85, 0.02);
			parT.Text = tex.戻る;
			parT.FontSize = 0.15;
			parT.SizeBase = sizeBase;
			parT.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT.OP.ScalingY(parT.OP.GetCenter(), 0.47);
			parT.OP.Rotation(parT.OP.GetCenter(), -26.0);
			parT.Closed = true;
			parT.TextColor = Col.White;
			parT.BrushColor = Color.FromArgb(160, Col.Black);
			parT.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT.StringFormat.Alignment = StringAlignment.Center;
			parT.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("ボタン0", new But1(parT, delegate(But a)
			{
				Sou.操作.Play();
				if (!Mods.時間進行(CS$<>8__locals1.Med))
				{
					CS$<>8__locals1.Med.映転("メインフォーム", Mods.描画バッファ, Mods.メインフォ\u30FCム描画);
				}
			}));
			ParT parT2 = new ParT();
			parT2.Font = new Font("MS Gothic", 0.1f);
			parT2.PositionBase = Mods.描画バッファ.GetPosition(0.85, 0.1);
			parT2.Text = tex.借金;
			parT2.FontSize = 0.15;
			parT2.SizeBase = sizeBase;
			parT2.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT2.OP.ScalingY(parT2.OP.GetCenter(), 0.47);
			parT2.OP.Rotation(parT2.OP.GetCenter(), -26.0);
			parT2.Closed = true;
			parT2.TextColor = Col.White;
			parT2.BrushColor = Color.FromArgb(160, Col.Black);
			parT2.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT2.StringFormat.Alignment = StringAlignment.Center;
			parT2.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("ボタン1", new But1(parT2, delegate(But bu)
			{
				Sou.操作.Play();
				CS$<>8__locals1.Med.Mode = "借金";
			}));
			ParT parT3 = new ParT();
			parT3.Font = new Font("MS Gothic", 0.1f);
			parT3.PositionBase = Mods.描画バッファ.GetPosition(0.85, 0.18);
			parT3.Text = tex.購入;
			parT3.FontSize = 0.15;
			parT3.SizeBase = sizeBase;
			parT3.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT3.OP.ScalingY(parT3.OP.GetCenter(), 0.47);
			parT3.OP.Rotation(parT3.OP.GetCenter(), -26.0);
			parT3.Closed = true;
			parT3.TextColor = Col.White;
			parT3.BrushColor = Color.FromArgb(160, Col.Black);
			parT3.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT3.StringFormat.Alignment = StringAlignment.Center;
			parT3.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("ボタン2", new But1(parT3, delegate(But bu)
			{
				Sou.操作.Play();
				CS$<>8__locals1.Med.Mode = "奴隷購入";
			}));
			ParT parT4 = new ParT();
			parT4.Font = new Font("MS Gothic", 0.1f);
			parT4.PositionBase = Mods.描画バッファ.GetPosition(0.85, 0.58);
			parT4.Text = tex.祝福;
			parT4.FontSize = 0.15;
			parT4.SizeBase = sizeBase;
			parT4.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT4.OP.ScalingY(parT4.OP.GetCenter(), 0.47);
			parT4.OP.Rotation(parT4.OP.GetCenter(), -26.0);
			parT4.Closed = true;
			parT4.TextColor = Col.White;
			parT4.BrushColor = Color.FromArgb(160, Col.Black);
			parT4.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT4.StringFormat.Alignment = StringAlignment.Center;
			parT4.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("ボタン3", new But1(parT4, delegate(But bu)
			{
				Sou.操作.Play();
				CS$<>8__locals1.Med.映転("ヴィオラ祝福", Mods.描画バッファ, Mods.返済イベント描画);
			}));
			bs.SetHitColor(CS$<>8__locals1.Med);
			mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				if (!Mods.processing)
				{
					if (Mods.SDShow)
					{
						Mods.セ\u30FCブデ\u30FCタ.Down(ref hc);
						if (mb == MouseButtons.Right && !Mods.processing)
						{
							Sou.操作.Play();
							Mods.SDShow = false;
							Mods.ip.Up(ref hc);
							Mods.dbs.Move(ref hc);
							return;
						}
					}
					else
					{
						if (mb == MouseButtons.Left)
						{
							if (!Mods.ip.選択肢表示)
							{
								Mods.dbs.Down(ref hc);
								bs.Down(ref hc);
							}
							Mods.ip.Down(ref hc);
							return;
						}
						if (mb == MouseButtons.Right)
						{
							if (!Mods.ip.選択肢表示)
							{
								bs["ボタン0"].Action(bs["ボタン0"]);
								return;
							}
							Mods.ip.nb.Action(Mods.ip.nb);
						}
					}
				}
			};
			mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				if (!Mods.processing)
				{
					if (Mods.SDShow)
					{
						Mods.セ\u30FCブデ\u30FCタ.Up(ref hc);
						return;
					}
					if (mb == MouseButtons.Left)
					{
						if (!Mods.ip.選択肢表示)
						{
							Mods.dbs.Up(ref hc);
							bs.Up(ref hc);
						}
						Mods.ip.Up(ref hc);
					}
				}
			};
			mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				if (!Mods.processing)
				{
					if (Mods.SDShow)
					{
						Mods.セ\u30FCブデ\u30FCタ.Move(ref hc);
						return;
					}
					if (!Mods.ip.選択肢表示)
					{
						Mods.dbs.Move(ref hc);
						bs.Move(ref hc);
						Mods.Player説明(ref hc, delegate
						{
							Mods.si.Set(false);
						});
					}
					Mods.ip.Move(ref hc);
				}
			};
			mod.Leave = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				if (!Mods.processing)
				{
					if (Mods.SDShow)
					{
						Mods.セ\u30FCブデ\u30FCタ.Leave();
						return;
					}
					if (!Mods.ip.選択肢表示)
					{
						Mods.dbs.Leave();
						bs.Leave();
					}
				}
			};
			mod.Wheel = delegate(MouseButtons mb, Vector2D cp, int dt, Color hc)
			{
			};
			mod.Setting = delegate()
			{
				if (CS$<>8__locals1.Med.Modeb != "情報設定")
				{
					Mods.ip.UpdateSub2();
					Mods.ip.MaiShow = false;
					Mods.ip.Mai.Feed.Dra = false;
					Mods.ip.Mai2Show = false;
					Mods.ip.SubShow = true;
					Mods.ip.Sub2Show = true;
					Mods.ヴィオラ吹出し.Tex.Feed.Dra = false;
					bs["ボタン1"].Dra = !Sta.GameData.初事務所フラグ;
					bs["ボタン3"].Dra = (Sta.GameData.返済段階 == 3);
					Mods.ヴィオラ.両目_見つめ();
					Mods.ヴィオラ.表情_基本0();
					Mods.ヴィオラ.Set基本姿勢();
					if (Sta.GameData.初事務所フラグ)
					{
						Mods.ヴィオラ.表情_不敵1();
						Mods.ヴィオラ台詞.Set();
					}
					else
					{
						Mods.ヴィオラ台詞.Set();
					}
					Mods.si.Set(false);
					if (Sta.GameData.返済段階 < 3)
					{
						if (Sta.GameData.返済段階 == 0 && Sta.GameData.借金 < Mods.単位返済段階額 * 2UL)
						{
							Sta.GameData.返済段階 = 1;
							Sta.GameData.系統開放[2] = true;
							Sta.GameData.系統開放[3] = true;
							Sta.GameData.心眼 = true;
							CS$<>8__locals1.Med.映転("返済イベント1", Mods.描画バッファ, Mods.返済イベント描画);
							Mods.Set需給最大幅();
							return;
						}
						if (Sta.GameData.返済段階 == 1 && Sta.GameData.借金 < Mods.単位返済段階額)
						{
							Sta.GameData.返済段階 = 2;
							Sta.GameData.系統開放[4] = true;
							Sta.GameData.系統開放[5] = true;
							Sta.GameData.媚薬 = true;
							Sta.GameData.施術 = true;
							Sta.GameData.淫紋 = true;
							Sta.GameData.衣装 = true;
							CS$<>8__locals1.Med.映転("返済イベント2", Mods.描画バッファ, Mods.返済イベント描画);
							Mods.Set需給最大幅();
							return;
						}
						if (Sta.GameData.返済段階 == 2 && Sta.GameData.借金 == 0UL)
						{
							Sta.GameData.返済段階 = 3;
							Sta.GameData.系統開放[6] = true;
							Sta.GameData.系統開放[7] = true;
							Sta.GameData.系統開放[8] = true;
							Sta.GameData.ヴィオラ服 = true;
							CS$<>8__locals1.Med.映転("返済イベント3", Mods.描画バッファ, Mods.返済イベント描画);
							Mods.Set需給最大幅();
						}
					}
				}
			};
			Mods.事務所描画 = delegate(Are a, FPS FPS)
			{
				if (a.GH != null)
				{
					a.GH.Clear(Col.Transparent);
				}
				a.Draw(Mods.事務室背景);
				Mods.ヴィオラ.Draw(a, FPS);
				Mods.ヴィオラ吹出し.Draw(a, FPS);
				bs.Draw(a);
				Mods.dbs.Draw(a);
				Mods.ip.Draw(a, FPS);
				if (Mods.SDShow)
				{
					Mods.セ\u30FCブデ\u30FCタ.Draw(a);
				}
				CS$<>8__locals1.Med.Draw(a);
			};
			mod.Draw = delegate(FPS FPS)
			{
				Mods.映転(CS$<>8__locals1.Med, Mods.描画バッファ, FPS, Mods.事務所描画);
			};
			mod.Dispose = delegate()
			{
				bs.Dispose();
			};
			return mod;
		}

		public static Mod 借金(Med Med)
		{
			Mods.<>c__DisplayClass101_0 CS$<>8__locals1 = new Mods.<>c__DisplayClass101_0();
			CS$<>8__locals1.Med = Med;
			Mod mod = new Mod();
			Vector2D position = Mods.描画バッファ.GetPosition(0.15, 0.37);
			Buts bs = new Buts();
			double sizeBase = 0.05;
			if (Sta.BigWindow && !Sta.NoScaling)
			{
				sizeBase = 0.068;
			}
			ParT parT = new ParT();
			parT.Font = new Font("MS Gothic", 0.1f);
			parT.PositionBase = Mods.描画バッファ.GetPosition(0.85, 0.02);
			parT.Text = tex.戻る;
			parT.FontSize = 0.15;
			parT.SizeBase = sizeBase;
			parT.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT.OP.ScalingY(parT.OP.GetCenter(), 0.47);
			parT.OP.Rotation(parT.OP.GetCenter(), -26.0);
			parT.Closed = true;
			parT.TextColor = Col.White;
			parT.BrushColor = Color.FromArgb(160, Col.Black);
			parT.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT.StringFormat.Alignment = StringAlignment.Center;
			parT.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("ボタン0", new But1(parT, delegate(But a)
			{
				Sou.操作.Play();
				CS$<>8__locals1.Med.Mode = "事務所";
			}));
			ParT parT2 = new ParT();
			sizeBase = 0.07;
			if (Sta.BigWindow && !Sta.NoScaling)
			{
				sizeBase = 0.088;
			}
			parT2.Font = new Font("MS Gothic", 0.1f);
			parT2.PositionBase = position + Mods.描画バッファ.GetPosition(0.0, 0.0);
			parT2.Text = "c";
			parT2.FontSize = 0.15;
			parT2.SizeBase = sizeBase;
			parT2.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT2.OP.ScalingXY(parT2.OP.GetCenter(), 0.3, 0.3);
			parT2.Closed = true;
			parT2.TextColor = Col.White;
			parT2.BrushColor = Color.FromArgb(160, Col.Black);
			parT2.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT2.StringFormat.Alignment = StringAlignment.Center;
			parT2.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("nc", new But1(parT2, delegate(But a)
			{
				Sou.操作.Play();
				Mods.ip.TextIm = "0";
			}));
			ParT parT3 = new ParT();
			parT3.Font = new Font("MS Gothic", 0.1f);
			parT3.PositionBase = position + Mods.描画バッファ.GetPosition(0.06, 0.0);
			parT3.Text = "m";
			parT3.FontSize = 0.15;
			parT3.SizeBase = sizeBase;
			parT3.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT3.OP.ScalingXY(parT3.OP.GetCenter(), 0.3, 0.3);
			parT3.Closed = true;
			parT3.TextColor = Col.White;
			parT3.BrushColor = Color.FromArgb(160, Col.Black);
			parT3.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT3.StringFormat.Alignment = StringAlignment.Center;
			parT3.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("nm", new But1(parT3, delegate(But a)
			{
				Sou.操作.Play();
				Mods.ip.TextIm = 9999999999999UL.ToString("#,0");
			}));
			Action<string> SetNum = delegate(string num)
			{
				if (ulong.Parse(Mods.ip.TextIm, NumberStyles.AllowThousands).ToString().Length < 9999999999999UL.ToString().Length)
				{
					情報パネル 情報パネル = Mods.ip;
					情報パネル.TextIm += num;
					Mods.ip.TextIm = ulong.Parse(Mods.ip.TextIm, NumberStyles.AllowThousands).ToString("#,0");
				}
			};
			ParT parT4 = new ParT();
			parT4.Font = new Font("MS Gothic", 0.1f);
			parT4.PositionBase = position + Mods.描画バッファ.GetPosition(0.0, 0.07);
			parT4.Text = "7";
			parT4.FontSize = 0.15;
			parT4.SizeBase = sizeBase;
			parT4.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT4.OP.ScalingXY(parT4.OP.GetCenter(), 0.3, 0.3);
			parT4.Closed = true;
			parT4.TextColor = Col.White;
			parT4.BrushColor = Color.FromArgb(160, Col.Black);
			parT4.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT4.StringFormat.Alignment = StringAlignment.Center;
			parT4.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("n7", new But1(parT4, delegate(But a)
			{
				Sou.操作.Play();
				SetNum("7");
			}));
			ParT parT5 = new ParT();
			parT5.Font = new Font("MS Gothic", 0.1f);
			parT5.PositionBase = position + Mods.描画バッファ.GetPosition(0.06, 0.07);
			parT5.Text = "8";
			parT5.FontSize = 0.15;
			parT5.SizeBase = sizeBase;
			parT5.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT5.OP.ScalingXY(parT5.OP.GetCenter(), 0.3, 0.3);
			parT5.Closed = true;
			parT5.TextColor = Col.White;
			parT5.BrushColor = Color.FromArgb(160, Col.Black);
			parT5.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT5.StringFormat.Alignment = StringAlignment.Center;
			parT5.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("n8", new But1(parT5, delegate(But a)
			{
				Sou.操作.Play();
				SetNum("8");
			}));
			ParT parT6 = new ParT();
			parT6.Font = new Font("MS Gothic", 0.1f);
			parT6.PositionBase = position + Mods.描画バッファ.GetPosition(0.12, 0.07);
			parT6.Text = "9";
			parT6.FontSize = 0.15;
			parT6.SizeBase = sizeBase;
			parT6.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT6.OP.ScalingXY(parT6.OP.GetCenter(), 0.3, 0.3);
			parT6.Closed = true;
			parT6.TextColor = Col.White;
			parT6.BrushColor = Color.FromArgb(160, Col.Black);
			parT6.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT6.StringFormat.Alignment = StringAlignment.Center;
			parT6.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("n9", new But1(parT6, delegate(But a)
			{
				Sou.操作.Play();
				SetNum("9");
			}));
			ParT parT7 = new ParT();
			parT7.Font = new Font("MS Gothic", 0.1f);
			parT7.PositionBase = position + Mods.描画バッファ.GetPosition(0.0, 0.14);
			parT7.Text = "4";
			parT7.FontSize = 0.15;
			parT7.SizeBase = sizeBase;
			parT7.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT7.OP.ScalingXY(parT7.OP.GetCenter(), 0.3, 0.3);
			parT7.Closed = true;
			parT7.TextColor = Col.White;
			parT7.BrushColor = Color.FromArgb(160, Col.Black);
			parT7.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT7.StringFormat.Alignment = StringAlignment.Center;
			parT7.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("n4", new But1(parT7, delegate(But a)
			{
				Sou.操作.Play();
				SetNum("4");
			}));
			ParT parT8 = new ParT();
			parT8.Font = new Font("MS Gothic", 0.1f);
			parT8.PositionBase = position + Mods.描画バッファ.GetPosition(0.06, 0.14);
			parT8.Text = "5";
			parT8.FontSize = 0.15;
			parT8.SizeBase = sizeBase;
			parT8.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT8.OP.ScalingXY(parT8.OP.GetCenter(), 0.3, 0.3);
			parT8.Closed = true;
			parT8.TextColor = Col.White;
			parT8.BrushColor = Color.FromArgb(160, Col.Black);
			parT8.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT8.StringFormat.Alignment = StringAlignment.Center;
			parT8.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("n5", new But1(parT8, delegate(But a)
			{
				Sou.操作.Play();
				SetNum("5");
			}));
			ParT parT9 = new ParT();
			parT9.Font = new Font("MS Gothic", 0.1f);
			parT9.PositionBase = position + Mods.描画バッファ.GetPosition(0.12, 0.14);
			parT9.Text = "6";
			parT9.FontSize = 0.15;
			parT9.SizeBase = sizeBase;
			parT9.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT9.OP.ScalingXY(parT9.OP.GetCenter(), 0.3, 0.3);
			parT9.Closed = true;
			parT9.TextColor = Col.White;
			parT9.BrushColor = Color.FromArgb(160, Col.Black);
			parT9.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT9.StringFormat.Alignment = StringAlignment.Center;
			parT9.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("n6", new But1(parT9, delegate(But a)
			{
				Sou.操作.Play();
				SetNum("6");
			}));
			ParT parT10 = new ParT();
			parT10.Font = new Font("MS Gothic", 0.1f);
			parT10.PositionBase = position + Mods.描画バッファ.GetPosition(0.0, 0.21);
			parT10.Text = "1";
			parT10.FontSize = 0.15;
			parT10.SizeBase = sizeBase;
			parT10.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT10.OP.ScalingXY(parT10.OP.GetCenter(), 0.3, 0.3);
			parT10.Closed = true;
			parT10.TextColor = Col.White;
			parT10.BrushColor = Color.FromArgb(160, Col.Black);
			parT10.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT10.StringFormat.Alignment = StringAlignment.Center;
			parT10.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("n1", new But1(parT10, delegate(But a)
			{
				Sou.操作.Play();
				SetNum("1");
			}));
			ParT parT11 = new ParT();
			parT11.Font = new Font("MS Gothic", 0.1f);
			parT11.PositionBase = position + Mods.描画バッファ.GetPosition(0.06, 0.21);
			parT11.Text = "2";
			parT11.FontSize = 0.15;
			parT11.SizeBase = sizeBase;
			parT11.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT11.OP.ScalingXY(parT11.OP.GetCenter(), 0.3, 0.3);
			parT11.Closed = true;
			parT11.TextColor = Col.White;
			parT11.BrushColor = Color.FromArgb(160, Col.Black);
			parT11.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT11.StringFormat.Alignment = StringAlignment.Center;
			parT11.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("n2", new But1(parT11, delegate(But a)
			{
				Sou.操作.Play();
				SetNum("2");
			}));
			ParT parT12 = new ParT();
			parT12.Font = new Font("MS Gothic", 0.1f);
			parT12.PositionBase = position + Mods.描画バッファ.GetPosition(0.12, 0.21);
			parT12.Text = "3";
			parT12.FontSize = 0.15;
			parT12.SizeBase = sizeBase;
			parT12.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT12.OP.ScalingXY(parT12.OP.GetCenter(), 0.3, 0.3);
			parT12.Closed = true;
			parT12.TextColor = Col.White;
			parT12.BrushColor = Color.FromArgb(160, Col.Black);
			parT12.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT12.StringFormat.Alignment = StringAlignment.Center;
			parT12.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("n3", new But1(parT12, delegate(But a)
			{
				Sou.操作.Play();
				SetNum("3");
			}));
			ParT parT13 = new ParT();
			parT13.Font = new Font("MS Gothic", 0.1f);
			parT13.PositionBase = position + Mods.描画バッファ.GetPosition(0.0, 0.28);
			parT13.Text = "0";
			parT13.FontSize = 0.15;
			parT13.SizeBase = sizeBase;
			parT13.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT13.OP.ScalingXY(parT13.OP.GetCenter(), 0.3, 0.3);
			parT13.Closed = true;
			parT13.TextColor = Col.White;
			parT13.BrushColor = Color.FromArgb(160, Col.Black);
			parT13.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT13.StringFormat.Alignment = StringAlignment.Center;
			parT13.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("n0", new But1(parT13, delegate(But a)
			{
				Sou.操作.Play();
				SetNum("0");
			}));
			ParT parT14 = new ParT();
			parT14.Font = new Font("MS Gothic", 0.1f);
			parT14.PositionBase = position + Mods.描画バッファ.GetPosition(0.12, 0.28);
			parT14.Text = tex.借;
			parT14.FontSize = 0.15;
			parT14.SizeBase = sizeBase;
			parT14.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT14.OP.ScalingXY(parT14.OP.GetCenter(), 0.3, 0.3);
			parT14.Closed = true;
			parT14.TextColor = Col.White;
			parT14.BrushColor = Color.FromArgb(160, Col.Black);
			parT14.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT14.StringFormat.Alignment = StringAlignment.Center;
			parT14.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("nb", new But1(parT14, delegate(But a)
			{
				if (Sta.GameData.日借金可能額 <= 0UL)
				{
					Sou.操作.Play();
					Mods.ip.SubInfo = tex.今日はこれ以上借りることが出来ません;
					return;
				}
				ulong num = ulong.Parse(Mods.ip.Text, NumberStyles.AllowThousands);
				if (num > 0UL)
				{
					if (num > Sta.GameData.日借金可能額)
					{
						num = Sta.GameData.日借金可能額;
						Mods.ip.SubInfo = tex.借金可能額以上は無視されます;
					}
					Sta.GameData.日借金額 += num;
					Sta.GameData.所持金 = Sta.GameData.所持金.加算(num);
					Sta.GameData.借金 = Sta.GameData.借金.加算(num);
					bs["nr"].Dra = (Sta.GameData.借金 > 0UL);
					Mods.ip.TextIm = "0";
					Sou.精算.Play();
					Mods.ip.UpdateSub2();
					Mods.ヴィオラ台詞.Set();
					return;
				}
				Sou.操作.Play();
			}));
			ParT parT15 = new ParT();
			parT15.Font = new Font("MS Gothic", 0.1f);
			parT15.PositionBase = position + Mods.描画バッファ.GetPosition(0.06, 0.28);
			parT15.Text = tex.返;
			parT15.FontSize = 0.15;
			parT15.SizeBase = sizeBase;
			parT15.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT15.OP.ScalingXY(parT15.OP.GetCenter(), 0.3, 0.3);
			parT15.Closed = true;
			parT15.TextColor = Col.White;
			parT15.BrushColor = Color.FromArgb(160, Col.Black);
			parT15.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT15.StringFormat.Alignment = StringAlignment.Center;
			parT15.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("nr", new But1(parT15, delegate(But a)
			{
				if (Sta.GameData.所持金 <= 0UL)
				{
					Sou.操作.Play();
					Mods.ip.SubInfo = tex.所持金がありません;
					return;
				}
				ulong num = ulong.Parse(Mods.ip.Text, NumberStyles.AllowThousands);
				if (num > 0UL)
				{
					if (num > Sta.GameData.所持金)
					{
						num = Sta.GameData.所持金;
						Mods.ip.SubInfo = tex.返済可能額以上は無視されます;
					}
					if (num > Sta.GameData.借金)
					{
						Sta.GameData.所持金 = Sta.GameData.所持金.減算(Sta.GameData.借金);
						Sta.GameData.借金 = 0UL;
						Mods.ip.SubInfo = tex.返済可能額以上は無視されます;
					}
					else
					{
						Sta.GameData.所持金 = Sta.GameData.所持金.減算(num);
						Sta.GameData.借金 = Sta.GameData.借金.減算(num);
					}
					bs["nr"].Dra = (Sta.GameData.借金 > 0UL);
					Mods.ip.TextIm = "0";
					Sou.精算.Play();
					Mods.ip.UpdateSub2();
					return;
				}
				Sou.操作.Play();
			}));
			bs.SetHitColor(CS$<>8__locals1.Med);
			mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				if (!Mods.processing)
				{
					if (Mods.SDShow)
					{
						Mods.セ\u30FCブデ\u30FCタ.Down(ref hc);
						if (mb == MouseButtons.Right && !Mods.processing)
						{
							Sou.操作.Play();
							Mods.SDShow = false;
							Mods.ip.Up(ref hc);
							Mods.dbs.Move(ref hc);
							return;
						}
					}
					else
					{
						if (mb == MouseButtons.Left)
						{
							if (!Mods.ip.選択肢表示)
							{
								Mods.ヴィオラ吹出し.Down(Mods.ヴィオラ吹出し.GetHitColor);
								Mods.dbs.Down(ref hc);
								bs.Down(ref hc);
							}
							Mods.ip.Down(ref hc);
							return;
						}
						if (mb == MouseButtons.Right)
						{
							if (!Mods.ip.選択肢表示)
							{
								bs["ボタン0"].Action(bs["ボタン0"]);
								return;
							}
							Mods.ip.nb.Action(Mods.ip.nb);
						}
					}
				}
			};
			mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				if (!Mods.processing)
				{
					if (Mods.SDShow)
					{
						Mods.セ\u30FCブデ\u30FCタ.Up(ref hc);
						return;
					}
					if (mb == MouseButtons.Left)
					{
						if (!Mods.ip.選択肢表示)
						{
							Mods.ヴィオラ吹出し.Up(Mods.ヴィオラ吹出し.GetHitColor);
							Mods.dbs.Up(ref hc);
							bs.Up(ref hc);
						}
						Mods.ip.Up(ref hc);
					}
				}
			};
			mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				if (!Mods.processing)
				{
					if (Mods.SDShow)
					{
						Mods.セ\u30FCブデ\u30FCタ.Move(ref hc);
						return;
					}
					if (!Mods.ip.選択肢表示)
					{
						Mods.dbs.Move(ref hc);
						bs.Move(ref hc);
						Mods.Player説明(ref hc, delegate
						{
							Mods.si.Set(false);
						});
					}
					Mods.ip.Move(ref hc);
				}
			};
			mod.Leave = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				if (Mods.SDShow)
				{
					Mods.セ\u30FCブデ\u30FCタ.Leave();
					return;
				}
				if (!Mods.ip.選択肢表示)
				{
					Mods.dbs.Leave();
					bs.Leave();
				}
			};
			mod.Wheel = delegate(MouseButtons mb, Vector2D cp, int dt, Color hc)
			{
			};
			mod.Setting = delegate()
			{
				if (CS$<>8__locals1.Med.Modeb != "情報設定")
				{
					Mods.ip.TextIm = "0";
					Mods.ip.UpdateSub2();
					Mods.ip.MaiShow = true;
					Mods.ip.Mai.Feed.Dra = false;
					Mods.ip.Mai2Show = false;
					Mods.ip.SubShow = true;
					Mods.ip.Sub2Show = true;
					Mods.ヴィオラ.両目_見つめ();
					Mods.ヴィオラ.両瞼_半1();
					Mods.ヴィオラ.両瞼_卑();
					Mods.ヴィオラ.口_薄笑();
					Mods.ヴィオラ.両腕_人_腕下げ(0, false, false);
					Mods.ヴィオラ.両触手_S字(0);
					Mods.ヴィオラ.両触手_S字(1);
					Mods.ヴィオラ.Set触手系対称化();
					Mods.ヴィオラ台詞.Set();
					Mods.si.Set(false);
					bs["nr"].Dra = (Sta.GameData.借金 > 0UL);
					bs["nr"].Dra = (Sta.GameData.借金 > 0UL);
				}
			};
			Mods.借金描画 = delegate(Are a, FPS FPS)
			{
				CS$<>8__locals1.Med.GH.Clear(Col.Transparent);
				if (a.GH != null)
				{
					a.GH.Clear(Col.Transparent);
				}
				a.Draw(Mods.事務室背景);
				Mods.ヴィオラ.Draw(a, FPS);
				Mods.ヴィオラ吹出し.Draw(a, FPS);
				bs.Draw(a);
				Mods.dbs.Draw(a);
				Mods.ip.Draw(a, FPS);
				if (Mods.SDShow)
				{
					Mods.セ\u30FCブデ\u30FCタ.Draw(a);
				}
				CS$<>8__locals1.Med.Draw(a);
			};
			mod.Draw = delegate(FPS FPS)
			{
				Mods.映転(CS$<>8__locals1.Med, Mods.描画バッファ, FPS, Mods.借金描画);
			};
			mod.Dispose = delegate()
			{
				bs.Dispose();
			};
			return mod;
		}

		public static Mod 奴隷購入(Med Med)
		{
			Mods.<>c__DisplayClass102_0 CS$<>8__locals1 = new Mods.<>c__DisplayClass102_0();
			CS$<>8__locals1.Med = Med;
			Mod mod = new Mod();
			Cha 購入対象 = null;
			bool d = false;
			Action Reload = null;
			Unit u = null;
			Generator g = null;
			Buts bs = new Buts();
			double sizeBase = 0.05;
			if (Sta.BigWindow && !Sta.NoScaling)
			{
				sizeBase = 0.068;
			}
			ParT parT = new ParT();
			parT.Font = new Font("MS Gothic", 0.1f);
			parT.PositionBase = Mods.描画バッファ.GetPosition(0.85, 0.02);
			parT.Text = tex.戻る;
			parT.FontSize = 0.15;
			parT.SizeBase = sizeBase;
			parT.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT.OP.ScalingY(parT.OP.GetCenter(), 0.47);
			parT.OP.Rotation(parT.OP.GetCenter(), -26.0);
			parT.Closed = true;
			parT.TextColor = Col.White;
			parT.BrushColor = Color.FromArgb(160, Col.Black);
			parT.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT.StringFormat.Alignment = StringAlignment.Center;
			parT.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("ボタン0", new But1(parT, delegate(But a)
			{
				Sou.操作.Play();
				if (Sta.GameData.初事務所フラグ)
				{
					CS$<>8__locals1.Med.映転("初事務所", Mods.描画バッファ, Mods.初事務所描画);
					return;
				}
				CS$<>8__locals1.Med.Mode = "事務所";
			}));
			ParT parT2 = new ParT();
			parT2.Font = new Font("MS Gothic", 0.1f);
			parT2.PositionBase = Mods.描画バッファ.GetPosition(0.85, 0.1);
			parT2.Text = tex.奴隷;
			parT2.FontSize = 0.15;
			parT2.SizeBase = sizeBase;
			parT2.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT2.OP.ScalingY(parT2.OP.GetCenter(), 0.47);
			parT2.OP.Rotation(parT2.OP.GetCenter(), -26.0);
			parT2.Closed = true;
			parT2.TextColor = Col.White;
			parT2.BrushColor = Color.FromArgb(160, Col.Black);
			parT2.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT2.StringFormat.Alignment = StringAlignment.Center;
			parT2.StringFormat.LineAlignment = StringAlignment.Center;
			parT2.PenColor = Color.Red;
			bs.Add("ボタン1", new But1(parT2, delegate(But bu)
			{
				Sou.操作.Play();
				CS$<>8__locals1.Med.Mode = "奴隷購入";
			}));
			ParT parT3 = new ParT();
			parT3.Font = new Font("MS Gothic", 0.1f);
			parT3.PositionBase = Mods.描画バッファ.GetPosition(0.85, 0.18);
			parT3.Text = tex.道具;
			parT3.FontSize = 0.15;
			parT3.SizeBase = sizeBase;
			parT3.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT3.OP.ScalingY(parT3.OP.GetCenter(), 0.47);
			parT3.OP.Rotation(parT3.OP.GetCenter(), -26.0);
			parT3.Closed = true;
			parT3.TextColor = Col.White;
			parT3.BrushColor = Color.FromArgb(160, Col.Black);
			parT3.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT3.StringFormat.Alignment = StringAlignment.Center;
			parT3.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("ボタン2", new But1(parT3, delegate(But bu)
			{
				Sou.操作.Play();
				CS$<>8__locals1.Med.Mode = "道具購入";
			}));
			Color bs初期縁色 = Col.Black;
			Action bs縁色初期化 = delegate()
			{
				foreach (But but in bs.EnumBut.Skip(3).Take(10))
				{
					but.Pars.Values.First<object>().ToParT().PenColor = bs初期縁色;
				}
			};
			double num = 0.7;
			double num2 = -0.03;
			ParT parT4 = new ParT();
			parT4.Font = new Font("MS Gothic", 0.1f);
			parT4.PositionBase = Mods.描画バッファ.GetPosition(0.01, num2 + 0.02 * num);
			parT4.Text = tex.ランダム;
			parT4.FontSize = 0.15;
			parT4.SizeBase = sizeBase;
			parT4.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT4.OP.ScalingY(parT4.OP.GetCenter(), 0.5 * num);
			parT4.Closed = true;
			parT4.TextColor = Col.White;
			parT4.BrushColor = Color.FromArgb(160, Col.Black);
			parT4.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT4.StringFormat.Alignment = StringAlignment.Center;
			parT4.StringFormat.LineAlignment = StringAlignment.Center;
			parT4.PenColor = Color.Red;
			bs.Add("対象0", new But1(parT4, delegate(But bu)
			{
				if (d)
				{
					Sou.操作.Play();
				}
				d = true;
				bs縁色初期化();
				bu.Pars.Values.First<object>().ToParT().PenColor = Color.Red;
				Reload();
			}));
			ParT parT5 = new ParT();
			parT5.Font = new Font("MS Gothic", 0.1f);
			parT5.PositionBase = Mods.描画バッファ.GetPosition(0.01, num2 + 0.1 * num);
			parT5.Text = tex.鳥系;
			parT5.FontSize = 0.15;
			parT5.SizeBase = sizeBase;
			parT5.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT5.OP.ScalingY(parT5.OP.GetCenter(), 0.5 * num);
			parT5.Closed = true;
			parT5.TextColor = Col.White;
			parT5.BrushColor = Color.FromArgb(160, Col.Black);
			parT5.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT5.StringFormat.Alignment = StringAlignment.Center;
			parT5.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("対象1", new But1(parT5, delegate(But bu)
			{
				Sou.操作.Play();
				bs縁色初期化();
				bu.Pars.Values.First<object>().ToParT().PenColor = Color.Red;
				Reload();
			}));
			ParT parT6 = new ParT();
			parT6.Font = new Font("MS Gothic", 0.1f);
			parT6.PositionBase = Mods.描画バッファ.GetPosition(0.01, num2 + 0.18 * num);
			parT6.Text = tex.蛇系;
			parT6.FontSize = 0.15;
			parT6.SizeBase = sizeBase;
			parT6.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT6.OP.ScalingY(parT6.OP.GetCenter(), 0.5 * num);
			parT6.Closed = true;
			parT6.TextColor = Col.White;
			parT6.BrushColor = Color.FromArgb(160, Col.Black);
			parT6.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT6.StringFormat.Alignment = StringAlignment.Center;
			parT6.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("対象2", new But1(parT6, delegate(But bu)
			{
				Sou.操作.Play();
				bs縁色初期化();
				bu.Pars.Values.First<object>().ToParT().PenColor = Color.Red;
				Reload();
			}));
			ParT parT7 = new ParT();
			parT7.Font = new Font("MS Gothic", 0.1f);
			parT7.PositionBase = Mods.描画バッファ.GetPosition(0.01, num2 + 0.26 * num);
			parT7.Text = tex.獣系;
			parT7.FontSize = 0.15;
			parT7.SizeBase = sizeBase;
			parT7.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT7.OP.ScalingY(parT7.OP.GetCenter(), 0.5 * num);
			parT7.Closed = true;
			parT7.TextColor = Col.White;
			parT7.BrushColor = Color.FromArgb(160, Col.Black);
			parT7.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT7.StringFormat.Alignment = StringAlignment.Center;
			parT7.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("対象3", new But1(parT7, delegate(But bu)
			{
				Sou.操作.Play();
				bs縁色初期化();
				bu.Pars.Values.First<object>().ToParT().PenColor = Color.Red;
				Reload();
			}));
			ParT parT8 = new ParT();
			parT8.Font = new Font("MS Gothic", 0.1f);
			parT8.PositionBase = Mods.描画バッファ.GetPosition(0.01, num2 + 0.34 * num);
			parT8.Text = tex.水系;
			parT8.FontSize = 0.15;
			parT8.SizeBase = sizeBase;
			parT8.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT8.OP.ScalingY(parT8.OP.GetCenter(), 0.5 * num);
			parT8.Closed = true;
			parT8.TextColor = Col.White;
			parT8.BrushColor = Color.FromArgb(160, Col.Black);
			parT8.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT8.StringFormat.Alignment = StringAlignment.Center;
			parT8.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("対象4", new But1(parT8, delegate(But bu)
			{
				Sou.操作.Play();
				bs縁色初期化();
				bu.Pars.Values.First<object>().ToParT().PenColor = Color.Red;
				Reload();
			}));
			ParT parT9 = new ParT();
			parT9.Font = new Font("MS Gothic", 0.1f);
			parT9.PositionBase = Mods.描画バッファ.GetPosition(0.01, num2 + 0.42 * num);
			parT9.Text = tex.虫系;
			parT9.FontSize = 0.15;
			parT9.SizeBase = sizeBase;
			parT9.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT9.OP.ScalingY(parT9.OP.GetCenter(), 0.5 * num);
			parT9.Closed = true;
			parT9.TextColor = Col.White;
			parT9.BrushColor = Color.FromArgb(160, Col.Black);
			parT9.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT9.StringFormat.Alignment = StringAlignment.Center;
			parT9.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("対象5", new But1(parT9, delegate(But bu)
			{
				Sou.操作.Play();
				bs縁色初期化();
				bu.Pars.Values.First<object>().ToParT().PenColor = Color.Red;
				Reload();
			}));
			ParT parT10 = new ParT();
			parT10.Font = new Font("MS Gothic", 0.1f);
			parT10.PositionBase = Mods.描画バッファ.GetPosition(0.01, num2 + 0.5 * num);
			parT10.Text = tex.人型;
			parT10.FontSize = 0.15;
			parT10.SizeBase = sizeBase;
			parT10.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT10.OP.ScalingY(parT10.OP.GetCenter(), 0.5 * num);
			parT10.Closed = true;
			parT10.TextColor = Col.White;
			parT10.BrushColor = Color.FromArgb(160, Col.Black);
			parT10.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT10.StringFormat.Alignment = StringAlignment.Center;
			parT10.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("対象6", new But1(parT10, delegate(But bu)
			{
				Sou.操作.Play();
				bs縁色初期化();
				bu.Pars.Values.First<object>().ToParT().PenColor = Color.Red;
				Reload();
			}));
			ParT parT11 = new ParT();
			parT11.Font = new Font("MS Gothic", 0.1f);
			parT11.PositionBase = Mods.描画バッファ.GetPosition(0.01, num2 + 0.58 * num);
			parT11.Text = tex.幻獣;
			parT11.FontSize = 0.15;
			parT11.SizeBase = sizeBase;
			parT11.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT11.OP.ScalingY(parT11.OP.GetCenter(), 0.5 * num);
			parT11.Closed = true;
			parT11.TextColor = Col.White;
			parT11.BrushColor = Color.FromArgb(160, Col.Black);
			parT11.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT11.StringFormat.Alignment = StringAlignment.Center;
			parT11.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("対象7", new But1(parT11, delegate(But bu)
			{
				Sou.操作.Play();
				bs縁色初期化();
				bu.Pars.Values.First<object>().ToParT().PenColor = Color.Red;
				Reload();
			}));
			ParT parT12 = new ParT();
			parT12.Font = new Font("MS Gothic", 0.1f);
			parT12.PositionBase = Mods.描画バッファ.GetPosition(0.01, num2 + 0.66 * num);
			parT12.Text = tex.魔獣;
			parT12.FontSize = 0.15;
			parT12.SizeBase = sizeBase;
			parT12.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT12.OP.ScalingY(parT12.OP.GetCenter(), 0.5 * num);
			parT12.Closed = true;
			parT12.TextColor = Col.White;
			parT12.BrushColor = Color.FromArgb(160, Col.Black);
			parT12.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT12.StringFormat.Alignment = StringAlignment.Center;
			parT12.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("対象8", new But1(parT12, delegate(But bu)
			{
				Sou.操作.Play();
				bs縁色初期化();
				bu.Pars.Values.First<object>().ToParT().PenColor = Color.Red;
				Reload();
			}));
			ParT parT13 = new ParT();
			parT13.Font = new Font("MS Gothic", 0.1f);
			parT13.PositionBase = Mods.描画バッファ.GetPosition(0.01, num2 + 0.74 * num);
			parT13.Text = tex.竜系;
			parT13.FontSize = 0.15;
			parT13.SizeBase = sizeBase;
			parT13.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT13.OP.ScalingY(parT13.OP.GetCenter(), 0.5 * num);
			parT13.Closed = true;
			parT13.TextColor = Col.White;
			parT13.BrushColor = Color.FromArgb(160, Col.Black);
			parT13.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT13.StringFormat.Alignment = StringAlignment.Center;
			parT13.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("対象9", new But1(parT13, delegate(But bu)
			{
				Sou.操作.Play();
				bs縁色初期化();
				bu.Pars.Values.First<object>().ToParT().PenColor = Color.Red;
				Reload();
			}));
			Action SetGen = delegate()
			{
				if (bs["対象0"].Pars.Values.First<object>().ToParT().PenColor == Color.Red)
				{
					if ((Sta.GameData.鳥系.Count != 0 && Sta.GameData.系統開放[0]) || (Sta.GameData.蛇系.Count != 0 && Sta.GameData.系統開放[1]) || (Sta.GameData.獣系.Count != 0 && Sta.GameData.系統開放[2]) || (Sta.GameData.水系.Count != 0 && Sta.GameData.系統開放[3]) || (Sta.GameData.虫系.Count != 0 && Sta.GameData.系統開放[4]) || (Sta.GameData.人型.Count != 0 && Sta.GameData.系統開放[5]) || (Sta.GameData.幻獣.Count != 0 && Sta.GameData.系統開放[6]) || (Sta.GameData.魔獣.Count != 0 && Sta.GameData.系統開放[7]) || (Sta.GameData.竜系.Count != 0 && Sta.GameData.系統開放[8]))
					{
						do
						{
							Random xs = OthN.XS;
							IEnumerable<bool> 系統開放 = Sta.GameData.系統開放;
							Func<bool, bool> predicate = (bool e) => e;
							switch (xs.Next(系統開放.Count(predicate)))
							{
							case 0:
								g = Sta.GameData.鳥系;
								break;
							case 1:
								g = Sta.GameData.蛇系;
								break;
							case 2:
								g = Sta.GameData.獣系;
								break;
							case 3:
								g = Sta.GameData.水系;
								break;
							case 4:
								g = Sta.GameData.虫系;
								break;
							case 5:
								g = Sta.GameData.人型;
								break;
							case 6:
								g = Sta.GameData.幻獣;
								break;
							case 7:
								g = Sta.GameData.魔獣;
								break;
							case 8:
								g = Sta.GameData.竜系;
								break;
							}
						}
						while (g.Count == 0);
						return;
					}
					Random xs2 = OthN.XS;
					IEnumerable<bool> 系統開放2 = Sta.GameData.系統開放;
					Func<bool, bool> predicate2 = (bool e) => e;
					switch (xs2.Next(系統開放2.Count(predicate2)))
					{
					case 0:
						g = Sta.GameData.鳥系;
						return;
					case 1:
						g = Sta.GameData.蛇系;
						return;
					case 2:
						g = Sta.GameData.獣系;
						return;
					case 3:
						g = Sta.GameData.水系;
						return;
					case 4:
						g = Sta.GameData.虫系;
						return;
					case 5:
						g = Sta.GameData.人型;
						return;
					case 6:
						g = Sta.GameData.幻獣;
						return;
					case 7:
						g = Sta.GameData.魔獣;
						return;
					case 8:
						g = Sta.GameData.竜系;
						return;
					default:
						return;
					}
				}
				else
				{
					if (bs["対象1"].Pars.Values.First<object>().ToParT().PenColor == Color.Red)
					{
						g = Sta.GameData.鳥系;
						return;
					}
					if (bs["対象2"].Pars.Values.First<object>().ToParT().PenColor == Color.Red)
					{
						g = Sta.GameData.蛇系;
						return;
					}
					if (bs["対象3"].Pars.Values.First<object>().ToParT().PenColor == Color.Red)
					{
						g = Sta.GameData.獣系;
						return;
					}
					if (bs["対象4"].Pars.Values.First<object>().ToParT().PenColor == Color.Red)
					{
						g = Sta.GameData.水系;
						return;
					}
					if (bs["対象5"].Pars.Values.First<object>().ToParT().PenColor == Color.Red)
					{
						g = Sta.GameData.虫系;
						return;
					}
					if (bs["対象6"].Pars.Values.First<object>().ToParT().PenColor == Color.Red)
					{
						g = Sta.GameData.人型;
						return;
					}
					if (bs["対象7"].Pars.Values.First<object>().ToParT().PenColor == Color.Red)
					{
						g = Sta.GameData.幻獣;
						return;
					}
					if (bs["対象8"].Pars.Values.First<object>().ToParT().PenColor == Color.Red)
					{
						g = Sta.GameData.魔獣;
						return;
					}
					if (bs["対象9"].Pars.Values.First<object>().ToParT().PenColor == Color.Red)
					{
						g = Sta.GameData.竜系;
					}
					return;
				}
			};
			Reload = delegate()
			{
				SetGen();
				g.Rotation();
				u = g.RefCharacter();
				if (u != null)
				{
					if (購入対象 != null)
					{
						購入対象.Dispose();
					}
					購入対象 = new Cha(CS$<>8__locals1.Med, Mods.描画バッファ, u.ChaD);
					購入対象.Set表情初期化();
					購入対象.情動();
					購入対象.Set表情変化();
					購入対象.Bod.拘束具_表示 = true;
					購入対象.Set拘束姿勢();
					購入対象.Set衣装(u.着衣);
					Mods.ip.TextIm = u.GetStatus();
					return;
				}
				Mods.ip.Mai.TextIm = tex.売り切れです;
			};
			ParT parT14 = new ParT();
			parT14.Font = new Font("MS Gothic", 0.1f);
			parT14.PositionBase = Mods.描画バッファ.GetPosition(0.01, num2 + 0.9 * num);
			parT14.Text = tex.チェンジ;
			parT14.FontSize = 0.15;
			parT14.SizeBase = sizeBase;
			parT14.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT14.OP.ScalingY(parT14.OP.GetCenter(), 0.5 * num);
			parT14.Closed = true;
			parT14.TextColor = Col.White;
			parT14.BrushColor = Color.FromArgb(160, Col.Black);
			parT14.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT14.StringFormat.Alignment = StringAlignment.Center;
			parT14.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("変更", new But1(parT14, delegate(But bu)
			{
				if (!Mods.ip.Mai.TextIm.StartsWith(tex.売り切れです))
				{
					Sou.変更Play();
				}
				else
				{
					Sou.操作.Play();
				}
				Reload();
			}));
			ParT parT15 = new ParT();
			parT15.Font = new Font("MS Gothic", 0.1f);
			parT15.PositionBase = Mods.描画バッファ.GetPosition(0.01, num2 + 0.98 * num);
			parT15.Text = tex.購入;
			parT15.FontSize = 0.15;
			parT15.SizeBase = sizeBase;
			parT15.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT15.OP.ScalingY(parT15.OP.GetCenter(), 0.5 * num);
			parT15.Closed = true;
			parT15.TextColor = Col.White;
			parT15.BrushColor = Color.FromArgb(160, Col.Black);
			parT15.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT15.StringFormat.Alignment = StringAlignment.Center;
			parT15.StringFormat.LineAlignment = StringAlignment.Center;
			ulong 買値;
			bs.Add("購入", new But1(parT15, delegate(But bu)
			{
				if (Sta.GameData.Is地下室一杯())
				{
					Sou.操作.Play();
					Mods.ip.SubInfoIm = tex.これ以上奴隷を収容できません;
					return;
				}
				if (u == null)
				{
					Sou.操作.Play();
					Mods.ip.Mai.TextIm = tex.売り切れです;
					return;
				}
				if (Sta.GameData.所持金 < (買値 = (ulong)(u.GetPrice() * ((Sta.GameData.祝福 == Sta.GameData.ヴィオラ) ? 0.6 : 1.0))))
				{
					Sou.操作.Play();
					Mods.ip.SubInfoIm = tex.所持金が足りません;
					return;
				}
				u.買値 = 買値;
				Sta.GameData.所持金 -= 買値;
				Sou.精算.Play();
				Mods.ip.UpdateSub2();
				Sta.GameData.Add地下室(g.GetCharacter());
				Reload();
			}));
			bs.SetHitColor(CS$<>8__locals1.Med);
			mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				if (!Mods.processing)
				{
					if (Mods.SDShow)
					{
						Mods.セ\u30FCブデ\u30FCタ.Down(ref hc);
						if (mb == MouseButtons.Right && !Mods.processing)
						{
							Sou.操作.Play();
							Mods.SDShow = false;
							Mods.ip.Up(ref hc);
							Mods.dbs.Move(ref hc);
							return;
						}
					}
					else
					{
						if (mb == MouseButtons.Left)
						{
							if (!Mods.ip.選択肢表示)
							{
								Mods.dbs.Down(ref hc);
								bs.Down(ref hc);
							}
							Mods.ip.Down(ref hc);
							return;
						}
						if (mb == MouseButtons.Right)
						{
							if (!Mods.ip.選択肢表示)
							{
								bs["ボタン0"].Action(bs["ボタン0"]);
								return;
							}
							Mods.ip.nb.Action(Mods.ip.nb);
						}
					}
				}
			};
			mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				if (!Mods.processing)
				{
					if (Mods.SDShow)
					{
						Mods.セ\u30FCブデ\u30FCタ.Up(ref hc);
						return;
					}
					if (mb == MouseButtons.Left)
					{
						if (!Mods.ip.選択肢表示)
						{
							Mods.dbs.Up(ref hc);
							bs.Up(ref hc);
						}
						Mods.ip.Up(ref hc);
					}
				}
			};
			mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				if (!Mods.processing)
				{
					if (Mods.SDShow)
					{
						Mods.セ\u30FCブデ\u30FCタ.Move(ref hc);
						return;
					}
					if (!Mods.ip.選択肢表示)
					{
						Mods.dbs.Move(ref hc);
						bs.Move(ref hc);
						Mods.Player説明(ref hc, delegate
						{
							Mods.si.Set(false);
						});
					}
					Mods.ip.Move(ref hc);
				}
			};
			mod.Leave = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				if (!Mods.processing)
				{
					if (Mods.SDShow)
					{
						Mods.セ\u30FCブデ\u30FCタ.Leave();
						return;
					}
					if (!Mods.ip.選択肢表示)
					{
						Mods.dbs.Leave();
						bs.Leave();
					}
				}
			};
			mod.Wheel = delegate(MouseButtons mb, Vector2D cp, int dt, Color hc)
			{
				int num3 = 0;
				using (IEnumerator<But> enumerator = bs.EnumBut.Skip(3).Take(10).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.Pars.Values.First<object>().ToParT().PenColor == Color.Red)
						{
							break;
						}
						num3++;
					}
				}
				int num4 = Sta.GameData.系統開放.Count((bool e) => e) + 1;
				int num5 = num3 - dt.Sign();
				if (num5 < 0)
				{
					num5 = num4 - 1;
				}
				num5 %= num4;
				But but = bs["対象" + num5];
				but.Action(but);
			};
			mod.Setting = delegate()
			{
				if (CS$<>8__locals1.Med.Modeb != "情報設定")
				{
					Mods.ip.UpdateSub2();
					Mods.ip.MaiShow = true;
					Mods.ip.Mai.Feed.Dra = false;
					Mods.ip.Mai2Show = false;
					Mods.ip.SubShow = true;
					Mods.ip.Sub2Show = true;
					bs["対象1"].Dra = Sta.GameData.系統開放[0];
					bs["対象2"].Dra = Sta.GameData.系統開放[1];
					bs["対象3"].Dra = Sta.GameData.系統開放[2];
					bs["対象4"].Dra = Sta.GameData.系統開放[3];
					bs["対象5"].Dra = Sta.GameData.系統開放[4];
					bs["対象6"].Dra = Sta.GameData.系統開放[5];
					bs["対象7"].Dra = Sta.GameData.系統開放[6];
					bs["対象8"].Dra = Sta.GameData.系統開放[7];
					bs["対象9"].Dra = Sta.GameData.系統開放[8];
					if (Sta.RefreshStoreEveryTime)
					{
						Sta.GameData.新日 = true;
					}
					if (Sta.GameData.新日)
					{
						Sta.GameData.GenRefresh();
						Sta.GameData.新日 = false;
					}
					Reload();
					Mods.si.Set(false);
				}
			};
			Mods.奴隷描画 = delegate(Are a, FPS FPS)
			{
				CS$<>8__locals1.Med.GH.Clear(Col.Transparent);
				if (a.GH != null)
				{
					a.GH.Clear(Col.Transparent);
				}
				a.Draw(Mods.事務室背景);
				if (u != null)
				{
					購入対象.Draw(a, FPS);
				}
				bs.Draw(a);
				Mods.dbs.Draw(a);
				Mods.ip.Draw(a, FPS);
				if (Mods.SDShow)
				{
					Mods.セ\u30FCブデ\u30FCタ.Draw(a);
				}
				CS$<>8__locals1.Med.Draw(a);
			};
			mod.Draw = delegate(FPS FPS)
			{
				Mods.映転(CS$<>8__locals1.Med, Mods.描画バッファ, FPS, Mods.奴隷描画);
			};
			mod.Dispose = delegate()
			{
				if (購入対象 != null)
				{
					購入対象.Dispose();
				}
				bs.Dispose();
			};
			Mods.奴隷UI初期化 = delegate()
			{
				d = false;
				bs縁色初期化();
				bs["対象0"].Pars.Values.First<object>().ToParT().PenColor = Color.Red;
			};
			return mod;
		}

		public static Mod 道具購入(Med Med)
		{
			Mods.<>c__DisplayClass103_0 CS$<>8__locals1 = new Mods.<>c__DisplayClass103_0();
			CS$<>8__locals1.Med = Med;
			Mod mod = new Mod();
			Buts bs = new Buts();
			double sizeBase = 0.05;
			if (Sta.BigWindow && !Sta.NoScaling)
			{
				sizeBase = 0.068;
			}
			ParT parT = new ParT();
			parT.Font = new Font("MS Gothic", 0.1f);
			parT.PositionBase = Mods.描画バッファ.GetPosition(0.85, 0.02);
			parT.Text = tex.戻る;
			parT.FontSize = 0.15;
			parT.SizeBase = sizeBase;
			parT.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT.OP.ScalingY(parT.OP.GetCenter(), 0.47);
			parT.OP.Rotation(parT.OP.GetCenter(), -26.0);
			parT.Closed = true;
			parT.TextColor = Col.White;
			parT.BrushColor = Color.FromArgb(160, Col.Black);
			parT.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT.StringFormat.Alignment = StringAlignment.Center;
			parT.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("ボタン0", new But1(parT, delegate(But a)
			{
				Sou.操作.Play();
				if (Sta.GameData.初事務所フラグ)
				{
					CS$<>8__locals1.Med.映転("初事務所", Mods.描画バッファ, Mods.初事務所描画);
					return;
				}
				CS$<>8__locals1.Med.Mode = "事務所";
			}));
			ParT parT2 = new ParT();
			parT2.Font = new Font("MS Gothic", 0.1f);
			parT2.PositionBase = Mods.描画バッファ.GetPosition(0.85, 0.1);
			parT2.Text = tex.奴隷;
			parT2.FontSize = 0.15;
			parT2.SizeBase = sizeBase;
			parT2.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT2.OP.ScalingY(parT2.OP.GetCenter(), 0.47);
			parT2.OP.Rotation(parT2.OP.GetCenter(), -26.0);
			parT2.Closed = true;
			parT2.TextColor = Col.White;
			parT2.BrushColor = Color.FromArgb(160, Col.Black);
			parT2.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT2.StringFormat.Alignment = StringAlignment.Center;
			parT2.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("ボタン1", new But1(parT2, delegate(But bu)
			{
				Sou.操作.Play();
				CS$<>8__locals1.Med.Mode = "奴隷購入";
			}));
			ParT parT3 = new ParT();
			parT3.Font = new Font("MS Gothic", 0.1f);
			parT3.PositionBase = Mods.描画バッファ.GetPosition(0.85, 0.18);
			parT3.Text = tex.道具;
			parT3.FontSize = 0.15;
			parT3.SizeBase = sizeBase;
			parT3.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT3.OP.ScalingY(parT3.OP.GetCenter(), 0.47);
			parT3.OP.Rotation(parT3.OP.GetCenter(), -26.0);
			parT3.Closed = true;
			parT3.TextColor = Col.White;
			parT3.BrushColor = Color.FromArgb(160, Col.Black);
			parT3.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT3.StringFormat.Alignment = StringAlignment.Center;
			parT3.StringFormat.LineAlignment = StringAlignment.Center;
			parT3.PenColor = Color.Red;
			bs.Add("ボタン2", new But1(parT3, delegate(But bu)
			{
				Sou.操作.Play();
				CS$<>8__locals1.Med.Mode = "道具購入";
			}));
			bs.SetHitColor(CS$<>8__locals1.Med);
			ListView lv = null;
			Action<But, int, ulong> buy = delegate(But but, int ind, ulong pri)
			{
				if (Sta.GameData.所持金 >= pri)
				{
					but.Dra = false;
					Sta.GameData.購入道具[ind] = true;
					Sta.GameData.所持金 -= pri;
					Sou.精算.Play();
					Mods.ip.UpdateSub2();
					Mods.ip.TextIm = " ";
					if (!lv.bs.EnumBut.Any((But e) => e.Dra))
					{
						Mods.ip.SubInfo = tex.買える物は何も無い;
						Mods.ip.TextIm = tex.売り切れです;
						return;
					}
				}
				else
				{
					Sou.操作.Play();
					Mods.ip.SubInfoIm = tex.所持金が足りません;
				}
			};
			lv = new ListView(Mods.描画バッファ, Mods.描画バッファ.GetPosition(0.01, 0.03), 0.5, new Font("MS Gothic", 1f), 0.07, Col.White, Col.Empty, Color.FromArgb(160, Col.Black), Col.Black, new TA[]
			{
				new TA(tex.ﾃ\uFF9Eｨﾙﾄ\uFF9Eﾊ\uFF9Eｲﾌ\uFF9E + " 35,000,000", delegate(But b)
				{
					buy(b, 0, 35000000UL);
				}),
				new TA(tex.ﾉ\uFF70ﾏﾙﾊ\uFF9Eｲﾌ\uFF9E + "   40,000,000", delegate(But b)
				{
					buy(b, 1, 40000000UL);
				}),
				new TA(tex.ﾄ\uFF9Eﾘﾙﾊ\uFF9Eｲﾌ\uFF9E + "   60,000,000", delegate(But b)
				{
					buy(b, 2, 60000000UL);
				}),
				new TA(tex.ﾃ\uFF9Eﾝﾏﾊ\uFF9Eｲﾌ\uFF9E + "   50,000,000", delegate(But b)
				{
					buy(b, 3, 50000000UL);
				}),
				new TA(tex.ｱﾅﾙﾊ\uFF9Eｲﾌ\uFF9E + "    45,000,000", delegate(But b)
				{
					buy(b, 4, 45000000UL);
				}),
				new TA(tex.調教鞭 + "      30,000,000", delegate(But b)
				{
					buy(b, 5, 30000000UL);
				}),
				new TA(tex.羽根箒 + "      20,000,000", delegate(But b)
				{
					buy(b, 6, 20000000UL);
				}),
				new TA(tex.T字剃刀 + "     20,000,000", delegate(But b)
				{
					buy(b, 7, 20000000UL);
				}),
				new TA(tex.振動ｷｬｯﾌ\uFF9F + "   30,000,000", delegate(But b)
				{
					buy(b, 8, 30000000UL);
				}),
				new TA(tex.ﾋ\uFF9Fﾝｸﾛ\uFF70ﾀ + "     20,000,000", delegate(But b)
				{
					buy(b, 9, 20000000UL);
				}),
				new TA(tex.ｱﾅﾙﾊ\uFF9F\uFF70ﾙ + "     20,000,000", delegate(But b)
				{
					buy(b, 10, 20000000UL);
				}),
				new TA(tex.目隠帯 + "      25,000,000", delegate(But b)
				{
					buy(b, 11, 25000000UL);
				}),
				new TA(tex.玉口枷 + "      20,000,000", delegate(But b)
				{
					buy(b, 12, 20000000UL);
				}),
				new TA(tex.カメラ + "     100,000,000", delegate(But b)
				{
					buy(b, 13, 100000000UL);
				}),
				new TA(tex.ﾌﾛｱ増設 + "    300,000,000", delegate(But b)
				{
					ulong num = 300000000UL;
					if (Sta.GameData.所持金 >= num)
					{
						Sta.GameData.フロア数++;
						if (Sta.GameData.フロア数 == 9)
						{
							b.Dra = false;
						}
						Sta.GameData.所持金 -= num;
						Sou.精算.Play();
						Mods.ip.UpdateSub2();
						Mods.ip.TextIm = " ";
						if (!lv.bs.EnumBut.Any((But e) => e.Dra))
						{
							Mods.ip.SubInfo = tex.買える物は何も無い;
							Mods.ip.TextIm = tex.売り切れです;
							return;
						}
					}
					else
					{
						Sou.操作.Play();
						Mods.ip.SubInfoIm = tex.所持金が足りません;
					}
				})
			});
			lv.SetHitColor(CS$<>8__locals1.Med);
			Action subinfo = delegate()
			{
				if (lv.bs.EnumBut.Any((But e) => e.Dra))
				{
					Mods.ip.SubInfo = tex.ふざけた値段だ;
					return;
				}
				Mods.ip.SubInfo = tex.買える物は何も無い;
			};
			mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				if (!Mods.processing)
				{
					if (Mods.SDShow)
					{
						Mods.セ\u30FCブデ\u30FCタ.Down(ref hc);
						if (mb == MouseButtons.Right && !Mods.processing)
						{
							Sou.操作.Play();
							Mods.SDShow = false;
							Mods.ip.Up(ref hc);
							Mods.dbs.Move(ref hc);
							return;
						}
					}
					else if (mb == MouseButtons.Left)
					{
						if (!Mods.ip.選択肢表示)
						{
							Mods.dbs.Down(ref hc);
							bs.Down(ref hc);
							lv.Down(ref hc);
							return;
						}
					}
					else if (mb == MouseButtons.Right)
					{
						if (!Mods.ip.選択肢表示)
						{
							bs["ボタン0"].Action(bs["ボタン0"]);
							return;
						}
						Mods.ip.nb.Action(Mods.ip.nb);
					}
				}
			};
			mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				if (!Mods.processing)
				{
					if (Mods.SDShow)
					{
						Mods.セ\u30FCブデ\u30FCタ.Up(ref hc);
						return;
					}
					if (mb == MouseButtons.Left)
					{
						if (!Mods.ip.選択肢表示)
						{
							Mods.dbs.Up(ref hc);
							bs.Up(ref hc);
							lv.Up(ref hc);
						}
						Mods.ip.Up(ref hc);
					}
				}
			};
			mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				if (!Mods.processing)
				{
					if (Mods.SDShow)
					{
						Mods.セ\u30FCブデ\u30FCタ.Move(ref hc);
						return;
					}
					if (!Mods.ip.選択肢表示)
					{
						Mods.dbs.Move(ref hc);
						bs.Move(ref hc);
						lv.Move(ref hc);
						if (lv.bs["0"].Pars.Values.First<object>().ToPar().HitColor == hc)
						{
							Mods.ip.TextIm = tex.ペニスを模したバイブ + "\r\n" + tex.刺激は控えめ;
						}
						if (lv.bs["1"].Pars.Values.First<object>().ToPar().HitColor == hc)
						{
							Mods.ip.TextIm = tex.一般的なバイブ + "\r\n" + tex.ディルドバイブより刺激が強い;
						}
						if (lv.bs["2"].Pars.Values.First<object>().ToPar().HitColor == hc)
						{
							Mods.ip.TextIm = tex.振動と回転の2つの刺激をもたらすバイブ;
						}
						if (lv.bs["3"].Pars.Values.First<object>().ToPar().HitColor == hc)
						{
							Mods.ip.TextIm = tex.強力な振動のバイブ + "\r\n" + tex.刺激が強い;
						}
						if (lv.bs["4"].Pars.Values.First<object>().ToPar().HitColor == hc)
						{
							Mods.ip.TextIm = tex.アナルの調教に適したバイブ;
						}
						if (lv.bs["5"].Pars.Values.First<object>().ToPar().HitColor == hc)
						{
							Mods.ip.TextIm = tex.痛みを与えるための道具;
						}
						if (lv.bs["6"].Pars.Values.First<object>().ToPar().HitColor == hc)
						{
							Mods.ip.TextIm = tex.緊張を解きほぐすために利用する;
						}
						if (lv.bs["7"].Pars.Values.First<object>().ToPar().HitColor == hc)
						{
							Mods.ip.TextIm = tex.陰毛を剃ることが出来る;
						}
						if (lv.bs["8"].Pars.Values.First<object>().ToPar().HitColor == hc)
						{
							Mods.ip.TextIm = tex.吸着振動するキャップ;
						}
						if (lv.bs["9"].Pars.Values.First<object>().ToPar().HitColor == hc)
						{
							Mods.ip.TextIm = tex.刺激の弱いバイブの一種;
						}
						if (lv.bs["10"].Pars.Values.First<object>().ToPar().HitColor == hc)
						{
							Mods.ip.TextIm = tex.アナルの調教に適した道具;
						}
						if (lv.bs["11"].Pars.Values.First<object>().ToPar().HitColor == hc)
						{
							Mods.ip.TextIm = tex.奴隷の視界を遮るための道具;
						}
						if (lv.bs["12"].Pars.Values.First<object>().ToPar().HitColor == hc)
						{
							Mods.ip.TextIm = tex.奴隷の口をふさぐための道具;
						}
						if (lv.bs["13"].Pars.Values.First<object>().ToPar().HitColor == hc)
						{
							Mods.ip.TextIm = tex.写真を撮影することが出来る;
						}
						if (lv.bs["14"].Pars.Values.First<object>().ToPar().HitColor == hc)
						{
							Mods.ip.TextIm = tex.フロアを増設し収容できる奴隷の数を増やす;
						}
						Mods.Player説明(ref hc, subinfo);
					}
					Mods.ip.Move(ref hc);
				}
			};
			mod.Leave = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				if (!Mods.processing)
				{
					if (Mods.SDShow)
					{
						Mods.セ\u30FCブデ\u30FCタ.Leave();
						return;
					}
					if (!Mods.ip.選択肢表示)
					{
						Mods.dbs.Leave();
						bs.Leave();
						lv.Leave();
					}
				}
			};
			mod.Wheel = delegate(MouseButtons mb, Vector2D cp, int dt, Color hc)
			{
			};
			mod.Setting = delegate()
			{
				if (CS$<>8__locals1.Med.Modeb != "情報設定")
				{
					Mods.ip.UpdateSub2();
					Mods.ip.MaiShow = true;
					Mods.ip.Mai.Feed.Dra = false;
					Mods.ip.Mai2Show = false;
					Mods.ip.SubShow = true;
					Mods.ip.Sub2Show = true;
					lv.bs["0"].Dra = !Sta.GameData.購入道具[0];
					lv.bs["1"].Dra = !Sta.GameData.購入道具[1];
					lv.bs["2"].Dra = !Sta.GameData.購入道具[2];
					lv.bs["3"].Dra = !Sta.GameData.購入道具[3];
					lv.bs["4"].Dra = !Sta.GameData.購入道具[4];
					lv.bs["5"].Dra = !Sta.GameData.購入道具[5];
					lv.bs["6"].Dra = !Sta.GameData.購入道具[6];
					lv.bs["7"].Dra = !Sta.GameData.購入道具[7];
					lv.bs["8"].Dra = !Sta.GameData.購入道具[8];
					lv.bs["9"].Dra = !Sta.GameData.購入道具[9];
					lv.bs["10"].Dra = !Sta.GameData.購入道具[10];
					lv.bs["11"].Dra = !Sta.GameData.購入道具[11];
					lv.bs["12"].Dra = !Sta.GameData.購入道具[12];
					lv.bs["13"].Dra = !Sta.GameData.購入道具[13];
					lv.bs["14"].Dra = (Sta.GameData.フロア数 < 9);
					if (Sta.GameData.購入道具.All((bool e) => e) && Sta.GameData.フロア数 == 9)
					{
						Mods.ip.TextIm = tex.売り切れです;
					}
					else
					{
						Mods.ip.TextIm = " ";
					}
					subinfo();
				}
			};
			Mods.道具描画 = delegate(Are a, FPS FPS)
			{
				CS$<>8__locals1.Med.GH.Clear(Col.Transparent);
				if (a.GH != null)
				{
					a.GH.Clear(Col.Transparent);
				}
				a.Draw(Mods.事務室背景);
				lv.Draw(a);
				bs.Draw(a);
				Mods.dbs.Draw(a);
				Mods.ip.Draw(a, FPS);
				if (Mods.SDShow)
				{
					Mods.セ\u30FCブデ\u30FCタ.Draw(a);
				}
				CS$<>8__locals1.Med.Draw(Mods.描画バッファ);
			};
			mod.Draw = delegate(FPS FPS)
			{
				Mods.映転(CS$<>8__locals1.Med, Mods.描画バッファ, FPS, Mods.道具描画);
			};
			mod.Dispose = delegate()
			{
				lv.Dispose();
				bs.Dispose();
			};
			return mod;
		}

		public static Mod 日数進行(Med Med)
		{
			Mod mod = new Mod();
			mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				Sta.GameData.時間進行();
				if (Mods.日利益額 > 0UL || Mods.日利子額 > 0UL)
				{
					if (Mods.日利益額 > 0UL)
					{
						Sta.GameData.所持金 = Sta.GameData.所持金.加算(Mods.日利益額);
					}
					if (Mods.日利子額 > 0UL)
					{
						Sta.GameData.借金 = Sta.GameData.借金.加算(Mods.日利子額);
					}
					Sou.精算.Play();
					Mods.ip.UpdateSub2();
				}
				if (Sta.GameData.日数 >= 10UL)
				{
					Sta.GameData.利子 = 0.002;
				}
				Sta.GameData.需給更新();
				Med.映転("メインフォーム", Mods.描画バッファ, Mods.メインフォ\u30FCム描画);
			};
			mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
			};
			mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
			};
			mod.Leave = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
			};
			mod.Wheel = delegate(MouseButtons mb, Vector2D cp, int dt, Color hc)
			{
			};
			mod.Setting = delegate()
			{
				Mods.ip.UpdateSub2();
				Mods.ip.MaiShow = true;
				Mods.ip.Mai.Feed.Dra = true;
				Mods.ip.Mai2Show = true;
				Mods.ip.SubShow = true;
				Mods.ip.Sub2Show = true;
				while (Mods.dayp)
				{
					Application.DoEvents();
				}
				Mods.ip.Mai2Im = (from e in Mods.日終了ログa
				where !string.IsNullOrWhiteSpace(e)
				select e.Substring(0, e.Length - 2)).Join("\r\n") + ((Mods.労働利益 > 0UL) ? ("\r\n" + tex.労働利益 + " + " + Mods.労働利益.ToString("#,0")) : "");
				Mods.ip.TextIm = ((Mods.日利益額 > 0UL) ? (tex.利益 + " + " + Mods.日利益額.ToString("#,0") + "\r\n") : "") + ((Mods.日利子額 > 0UL) ? (tex.利子 + " + " + Mods.日利子額.ToString("#,0") + "\r\n") : "") + ">> Next days.";
				if (Mods.調教対象 != null && Sta.GameData.調教対象 != null)
				{
					Mods.対象状態初期化();
					Mods.妊娠状態反映();
				}
				Mods.si.Set(false);
			};
			Mods.日数進行描画 = delegate(Are a, FPS FPS)
			{
				if (Mods.調教対象 != null)
				{
					Mods.調教対象.Mots.Drive(FPS);
				}
				Med.GH.Clear(Col.Transparent);
				if (a.GH != null)
				{
					a.GH.Clear(Col.Transparent);
				}
				a.Draw(Mods.黒背景);
				Mods.ip.Draw(a, FPS);
				Med.Draw(a);
			};
			mod.Draw = delegate(FPS FPS)
			{
				Mods.映転(Med, Mods.描画バッファ, FPS, Mods.日数進行描画);
			};
			mod.Dispose = delegate()
			{
			};
			return mod;
		}

		public static Mod 情報設定(Med Med)
		{
			Mods.<>c__DisplayClass105_0 CS$<>8__locals1 = new Mods.<>c__DisplayClass105_0();
			CS$<>8__locals1.Med = Med;
			Mod mod = new Mod();
			double num = 0.2;
			double num2 = 0.039;
			double num3 = 0.15;
			double sizeBase = 0.05;
			if (Sta.BigWindow && !Sta.NoScaling)
			{
				sizeBase = 0.068;
			}
			ParT parT = new ParT();
			parT.Font = new Font("MS Gothic", 0.1f);
			parT.PositionBase = Mods.描画バッファ.GetPosition(new Vector2D(num2 + 0.19, num3 + 0.72));
			parT.Text = tex.完了;
			parT.FontSize = 0.15;
			parT.SizeBase = sizeBase;
			parT.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT.OP.ScalingY(parT.OP.GetCenter(), 0.47);
			parT.Closed = true;
			parT.TextColor = Col.White;
			parT.BrushColor = Color.FromArgb(160, Col.Black);
			parT.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT.HitColor = CS$<>8__locals1.Med.GetUniqueColor();
			parT.StringFormat.Alignment = StringAlignment.Center;
			parT.StringFormat.LineAlignment = StringAlignment.Center;
			But1 完了 = new But1(parT, delegate(But a)
			{
				Sta.GameData.配色 = new 主人公配色(Sta.GameData.色);
				Act.UI.ハンド右.再配色(Sta.GameData.配色);
				Act.UI.ハンド左.再配色(Sta.GameData.配色);
				Act.UI.ペニス.再配色(Sta.GameData.配色);
				Act.UI.マウス.再配色(Sta.GameData.配色);
				Sta.GameData.プレ\u30FCヤ\u30FC = Generator.プレ\u30FCヤ\u30FC();
				Sou.完了.Play();
				if (Mods.start)
				{
					Mods.start = false;
					CS$<>8__locals1.Med.映転("OP0", Mods.描画バッファ, Mods.OP0描画);
					return;
				}
				string modeb = CS$<>8__locals1.Med.Modeb;
				uint num4 = <PrivateImplementationDetails>.ComputeStringHash(modeb);
				if (num4 <= 2021908077U)
				{
					if (num4 != 224776203U)
					{
						if (num4 != 940426623U)
						{
							if (num4 != 2021908077U)
							{
								return;
							}
							if (!(modeb == "借金"))
							{
								return;
							}
							CS$<>8__locals1.Med.映転("借金", Mods.描画バッファ, Mods.借金描画);
							return;
						}
						else
						{
							if (!(modeb == "奴隷購入"))
							{
								return;
							}
							CS$<>8__locals1.Med.映転("奴隷購入", Mods.描画バッファ, Mods.奴隷描画);
							return;
						}
					}
					else
					{
						if (!(modeb == "事務所"))
						{
							return;
						}
						CS$<>8__locals1.Med.映転("事務所", Mods.描画バッファ, Mods.事務所描画);
						return;
					}
				}
				else if (num4 <= 2574348160U)
				{
					if (num4 != 2443263813U)
					{
						if (num4 != 2574348160U)
						{
							return;
						}
						if (!(modeb == "対象"))
						{
							return;
						}
						CS$<>8__locals1.Med.映転("対象", Mods.描画バッファ, Mods.対象描画);
						return;
					}
					else
					{
						if (!(modeb == "祝福"))
						{
							return;
						}
						CS$<>8__locals1.Med.映転("祝福", Mods.描画バッファ, Mods.祝福描画);
						return;
					}
				}
				else if (num4 != 3595923579U)
				{
					if (num4 != 4229701956U)
					{
						return;
					}
					if (!(modeb == "道具購入"))
					{
						return;
					}
					CS$<>8__locals1.Med.映転("道具購入", Mods.描画バッファ, Mods.道具描画);
					return;
				}
				else
				{
					if (!(modeb == "メインフォーム"))
					{
						return;
					}
					CS$<>8__locals1.Med.映転("メインフォーム", Mods.描画バッファ, Mods.メインフォ\u30FCム描画);
					return;
				}
			});
			Labs ls = new Labs(CS$<>8__locals1.Med, Mods.描画バッファ);
			ls.Add("ラベル0", Mods.描画バッファ.GetPosition(new Vector2D(num2 + 0.19, num3 - 0.1)), 0.1, 2.5, new Font("MS Gothic", 1f), 0.085, " ", Col.White, Col.Black, Mods.ip.MaiB.BrushColor, Col.Black, false);
			ls.Add("ラベル1", Mods.描画バッファ.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 0.0 + 0.005)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, tex.肌の色, Col.White, Col.Black, Mods.ip.MaiB.BrushColor, Col.Black, false);
			ls.Add("ラベル2", Mods.描画バッファ.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 0.0 + 0.045)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "H:", Col.White, Col.Black, Mods.ip.MaiB.BrushColor, Col.Black, false);
			ls.Add("ラベル3", Mods.描画バッファ.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 0.0 + 0.086)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "S:", Col.White, Col.Black, Mods.ip.MaiB.BrushColor, Col.Black, false);
			ls.Add("ラベル4", Mods.描画バッファ.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 0.0 + 0.127)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "V:", Col.White, Col.Black, Mods.ip.MaiB.BrushColor, Col.Black, false);
			ls.Add("ラベル5", Mods.描画バッファ.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 1.0 + 0.005)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, tex.髪の色, Col.White, Col.Black, Mods.ip.MaiB.BrushColor, Col.Black, false);
			ls.Add("ラベル6", Mods.描画バッファ.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 1.0 + 0.045)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "H:", Col.White, Col.Black, Mods.ip.MaiB.BrushColor, Col.Black, false);
			ls.Add("ラベル7", Mods.描画バッファ.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 1.0 + 0.086)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "S:", Col.White, Col.Black, Mods.ip.MaiB.BrushColor, Col.Black, false);
			ls.Add("ラベル8", Mods.描画バッファ.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 1.0 + 0.127)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "V:", Col.White, Col.Black, Mods.ip.MaiB.BrushColor, Col.Black, false);
			ls.Add("ラベル9", Mods.描画バッファ.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 2.0 + 0.005)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, tex.瞳の色, Col.White, Col.Black, Mods.ip.MaiB.BrushColor, Col.Black, false);
			ls.Add("ラベル10", Mods.描画バッファ.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 2.0 + 0.045)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "H:", Col.White, Col.Black, Mods.ip.MaiB.BrushColor, Col.Black, false);
			ls.Add("ラベル11", Mods.描画バッファ.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 2.0 + 0.086)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "S:", Col.White, Col.Black, Mods.ip.MaiB.BrushColor, Col.Black, false);
			ls.Add("ラベル12", Mods.描画バッファ.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 2.0 + 0.127)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "V:", Col.White, Col.Black, Mods.ip.MaiB.BrushColor, Col.Black, false);
			ls.Add("ラベル13", Mods.描画バッファ.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 3.0 + 0.005)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, tex.体格, Col.White, Col.Black, Mods.ip.MaiB.BrushColor, Col.Black, false);
			ls.Add("ラベル14", Mods.描画バッファ.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 3.0 + 0.045)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "H:", Col.White, Col.Black, Mods.ip.MaiB.BrushColor, Col.Black, false);
			ls.Add("ラベル15", Mods.描画バッファ.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 3.0 + 0.086)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "W:", Col.White, Col.Black, Mods.ip.MaiB.BrushColor, Col.Black, false);
			Gau H肌 = new Gau("H肌", Mods.描画バッファ.GetPosition(new Vector2D(num2 + 0.532, num3 + num * 0.0 + 0.06)), Mods.描画バッファ.Size, 0.6, 0.03, 0.02, Open.Rig, Range.ZeroOne, Mods.描画バッファ.DisUnit, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Col.Black, true);
			H肌.Gauge.PenColor = Col.White;
			H肌.Frame1.PenColor = Col.White;
			H肌.Knob.PenColor = Col.White;
			H肌.Knob.HitColor = CS$<>8__locals1.Med.GetUniqueColor();
			Gau S肌 = new Gau("S肌", Mods.描画バッファ.GetPosition(new Vector2D(num2 + 0.532, num3 + num * 0.0 + 0.1)), Mods.描画バッファ.Size, 0.6, 0.03, 0.02, Open.Rig, Range.ZeroOne, Mods.描画バッファ.DisUnit, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Col.Black, true);
			S肌.Gauge.PenColor = Col.White;
			S肌.Frame1.PenColor = Col.White;
			S肌.Knob.PenColor = Col.White;
			S肌.Knob.HitColor = CS$<>8__locals1.Med.GetUniqueColor();
			Gau V肌 = new Gau("V肌", Mods.描画バッファ.GetPosition(new Vector2D(num2 + 0.532, num3 + num * 0.0 + 0.14)), Mods.描画バッファ.Size, 0.6, 0.03, 0.02, Open.Rig, Range.ZeroOne, Mods.描画バッファ.DisUnit, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Col.Black, true);
			V肌.Gauge.PenColor = Col.White;
			V肌.Frame1.PenColor = Col.White;
			V肌.Knob.PenColor = Col.White;
			V肌.Knob.HitColor = CS$<>8__locals1.Med.GetUniqueColor();
			Gau H髪 = new Gau("H髪", Mods.描画バッファ.GetPosition(new Vector2D(num2 + 0.532, num3 + num * 1.0 + 0.06)), Mods.描画バッファ.Size, 0.6, 0.03, 0.02, Open.Rig, Range.ZeroOne, Mods.描画バッファ.DisUnit, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Col.Black, true);
			H髪.Gauge.PenColor = Col.White;
			H髪.Frame1.PenColor = Col.White;
			H髪.Knob.PenColor = Col.White;
			H髪.Knob.HitColor = CS$<>8__locals1.Med.GetUniqueColor();
			Gau S髪 = new Gau("S髪", Mods.描画バッファ.GetPosition(new Vector2D(num2 + 0.532, num3 + num * 1.0 + 0.1)), Mods.描画バッファ.Size, 0.6, 0.03, 0.02, Open.Rig, Range.ZeroOne, Mods.描画バッファ.DisUnit, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Col.Black, true);
			S髪.Gauge.PenColor = Col.White;
			S髪.Frame1.PenColor = Col.White;
			S髪.Knob.PenColor = Col.White;
			S髪.Knob.HitColor = CS$<>8__locals1.Med.GetUniqueColor();
			Gau V髪 = new Gau("V髪", Mods.描画バッファ.GetPosition(new Vector2D(num2 + 0.532, num3 + num * 1.0 + 0.14)), Mods.描画バッファ.Size, 0.6, 0.03, 0.02, Open.Rig, Range.ZeroOne, Mods.描画バッファ.DisUnit, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Col.Black, true);
			V髪.Gauge.PenColor = Col.White;
			V髪.Frame1.PenColor = Col.White;
			V髪.Knob.PenColor = Col.White;
			V髪.Knob.HitColor = CS$<>8__locals1.Med.GetUniqueColor();
			Gau H瞳 = new Gau("H瞳", Mods.描画バッファ.GetPosition(new Vector2D(num2 + 0.532, num3 + num * 2.0 + 0.06)), Mods.描画バッファ.Size, 0.6, 0.03, 0.02, Open.Rig, Range.ZeroOne, Mods.描画バッファ.DisUnit, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Col.Black, true);
			H瞳.Gauge.PenColor = Col.White;
			H瞳.Frame1.PenColor = Col.White;
			H瞳.Knob.PenColor = Col.White;
			H瞳.Knob.HitColor = CS$<>8__locals1.Med.GetUniqueColor();
			Gau S瞳 = new Gau("S瞳", Mods.描画バッファ.GetPosition(new Vector2D(num2 + 0.532, num3 + num * 2.0 + 0.1)), Mods.描画バッファ.Size, 0.6, 0.03, 0.02, Open.Rig, Range.ZeroOne, Mods.描画バッファ.DisUnit, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Col.Black, true);
			S瞳.Gauge.PenColor = Col.White;
			S瞳.Frame1.PenColor = Col.White;
			S瞳.Knob.PenColor = Col.White;
			S瞳.Knob.HitColor = CS$<>8__locals1.Med.GetUniqueColor();
			Gau V瞳 = new Gau("V瞳", Mods.描画バッファ.GetPosition(new Vector2D(num2 + 0.532, num3 + num * 2.0 + 0.14)), Mods.描画バッファ.Size, 0.6, 0.03, 0.02, Open.Rig, Range.ZeroOne, Mods.描画バッファ.DisUnit, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Col.Black, true);
			V瞳.Gauge.PenColor = Col.White;
			V瞳.Frame1.PenColor = Col.White;
			V瞳.Knob.PenColor = Col.White;
			V瞳.Knob.HitColor = CS$<>8__locals1.Med.GetUniqueColor();
			Gau 身長 = new Gau("身長", Mods.描画バッファ.GetPosition(new Vector2D(num2 + 0.532, num3 + num * 3.0 + 0.06)), Mods.描画バッファ.Size, 0.6, 0.03, 0.02, Open.Rig, Range.ZeroOne, Mods.描画バッファ.DisUnit, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Col.Black, true);
			身長.Gauge.PenColor = Col.White;
			身長.Frame1.PenColor = Col.White;
			身長.Knob.PenColor = Col.White;
			身長.Knob.HitColor = CS$<>8__locals1.Med.GetUniqueColor();
			Gau 体重 = new Gau("体重", Mods.描画バッファ.GetPosition(new Vector2D(num2 + 0.532, num3 + num * 3.0 + 0.1)), Mods.描画バッファ.Size, 0.6, 0.03, 0.02, Open.Rig, Range.ZeroOne, Mods.描画バッファ.DisUnit, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Col.Black, true);
			体重.Gauge.PenColor = Col.White;
			体重.Frame1.PenColor = Col.White;
			体重.Knob.PenColor = Col.White;
			体重.Knob.HitColor = CS$<>8__locals1.Med.GetUniqueColor();
			Hsv hsv = HSV.ToHSV(ref Sta.GameData.色.肌色);
			H肌.Value = (double)hsv.H / 360.0;
			S肌.Value = (double)hsv.S / 255.0;
			V肌.Value = (double)hsv.V / 255.0;
			H肌.Base.BrushColor = Sta.GameData.色.肌色;
			S肌.Base.BrushColor = Sta.GameData.色.肌色;
			V肌.Base.BrushColor = Sta.GameData.色.肌色;
			ls["ラベル2"].Text = "H:" + hsv.H;
			ls["ラベル3"].Text = "S:" + hsv.S;
			ls["ラベル4"].Text = "V:" + hsv.V;
			hsv = HSV.ToHSV(ref Sta.GameData.色.髪色);
			H髪.Value = (double)hsv.H / 360.0;
			S髪.Value = (double)hsv.S / 255.0;
			V髪.Value = (double)hsv.V / 255.0;
			H髪.Base.BrushColor = Sta.GameData.色.髪色;
			S髪.Base.BrushColor = Sta.GameData.色.髪色;
			V髪.Base.BrushColor = Sta.GameData.色.髪色;
			ls["ラベル6"].Text = "H:" + hsv.H;
			ls["ラベル7"].Text = "S:" + hsv.S;
			ls["ラベル8"].Text = "V:" + hsv.V;
			hsv = HSV.ToHSV(ref Sta.GameData.色.瞳色);
			H瞳.Value = (double)hsv.H / 360.0;
			S瞳.Value = (double)hsv.S / 255.0;
			V瞳.Value = (double)hsv.V / 255.0;
			H瞳.Base.BrushColor = Sta.GameData.色.瞳色;
			S瞳.Base.BrushColor = Sta.GameData.色.瞳色;
			V瞳.Base.BrushColor = Sta.GameData.色.瞳色;
			ls["ラベル10"].Text = "H:" + hsv.H;
			ls["ラベル11"].Text = "S:" + hsv.S;
			ls["ラベル12"].Text = "V:" + hsv.V;
			身長.Value = Sta.GameData.身長;
			体重.Value = Sta.GameData.体重;
			ls["ラベル14"].Text = "H:" + string.Format("{0:0.00}", 身長.Value);
			ls["ラベル15"].Text = "W:" + string.Format("{0:0.00}", 体重.Value);
			mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				if (mb == MouseButtons.Left)
				{
					H肌.Down(ref hc, ref cp);
					S肌.Down(ref hc, ref cp);
					V肌.Down(ref hc, ref cp);
					H髪.Down(ref hc, ref cp);
					S髪.Down(ref hc, ref cp);
					V髪.Down(ref hc, ref cp);
					H瞳.Down(ref hc, ref cp);
					S瞳.Down(ref hc, ref cp);
					V瞳.Down(ref hc, ref cp);
					身長.Down(ref hc, ref cp);
					体重.Down(ref hc, ref cp);
					完了.Down(ref hc);
				}
			};
			mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				if (mb == MouseButtons.Left)
				{
					H肌.Up();
					S肌.Up();
					V肌.Up();
					H髪.Up();
					S髪.Up();
					V髪.Up();
					H瞳.Up();
					S瞳.Up();
					V瞳.Up();
					身長.Up();
					体重.Up();
					完了.Up(ref hc);
				}
			};
			int h;
			int s;
			int v;
			mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				if (mb == MouseButtons.Left)
				{
					H肌.Move(ref cp);
					S肌.Move(ref cp);
					V肌.Move(ref cp);
					h = (int)(360.0 * H肌.Value);
					s = (int)(255.0 * S肌.Value);
					v = (int)(255.0 * V肌.Value);
					HSV.ToRGB(h, s, v, out Sta.GameData.色.肌色);
					H肌.Base.BrushColor = Sta.GameData.色.肌色;
					S肌.Base.BrushColor = Sta.GameData.色.肌色;
					V肌.Base.BrushColor = Sta.GameData.色.肌色;
					ls["ラベル2"].Text = "H:" + h;
					ls["ラベル3"].Text = "S:" + s;
					ls["ラベル4"].Text = "V:" + v;
					H髪.Move(ref cp);
					S髪.Move(ref cp);
					V髪.Move(ref cp);
					h = (int)(360.0 * H髪.Value);
					s = (int)(255.0 * S髪.Value);
					v = (int)(255.0 * V髪.Value);
					HSV.ToRGB(h, s, v, out Sta.GameData.色.髪色);
					H髪.Base.BrushColor = Sta.GameData.色.髪色;
					S髪.Base.BrushColor = Sta.GameData.色.髪色;
					V髪.Base.BrushColor = Sta.GameData.色.髪色;
					ls["ラベル6"].Text = "H:" + h;
					ls["ラベル7"].Text = "S:" + s;
					ls["ラベル8"].Text = "V:" + v;
					H瞳.Move(ref cp);
					S瞳.Move(ref cp);
					V瞳.Move(ref cp);
					h = (int)(360.0 * H瞳.Value);
					s = (int)(255.0 * S瞳.Value);
					v = (int)(255.0 * V瞳.Value);
					HSV.ToRGB(h, s, v, out Sta.GameData.色.瞳色);
					H瞳.Base.BrushColor = Sta.GameData.色.瞳色;
					S瞳.Base.BrushColor = Sta.GameData.色.瞳色;
					V瞳.Base.BrushColor = Sta.GameData.色.瞳色;
					ls["ラベル10"].Text = "H:" + h;
					ls["ラベル11"].Text = "S:" + s;
					ls["ラベル12"].Text = "V:" + v;
					身長.Move(ref cp);
					体重.Move(ref cp);
					ls["ラベル14"].Text = "H:" + string.Format("{0:0.00}", 身長.Value);
					ls["ラベル15"].Text = "W:" + string.Format("{0:0.00}", 体重.Value);
				}
				完了.Move(ref hc);
			};
			mod.Leave = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				H肌.Leave();
				S肌.Leave();
				V肌.Leave();
				H髪.Leave();
				S髪.Leave();
				V髪.Leave();
				H瞳.Leave();
				S瞳.Leave();
				V瞳.Leave();
				身長.Leave();
				体重.Leave();
				完了.Leave();
			};
			mod.Wheel = delegate(MouseButtons mb, Vector2D cp, int dt, Color hc)
			{
			};
			mod.Setting = delegate()
			{
				ls["ラベル0"].Text = tex.プレイヤ\u30FCの遺伝情報を設定してください + (Mods.start ? ("(" + tex.後から変更できます + ")") : "");
				hsv = HSV.ToHSV(ref Sta.GameData.色.肌色);
				H肌.Value = (double)hsv.H / 360.0;
				S肌.Value = (double)hsv.S / 255.0;
				V肌.Value = (double)hsv.V / 255.0;
				H肌.Base.BrushColor = Sta.GameData.色.肌色;
				S肌.Base.BrushColor = Sta.GameData.色.肌色;
				V肌.Base.BrushColor = Sta.GameData.色.肌色;
				ls["ラベル2"].Text = "H:" + hsv.H;
				ls["ラベル3"].Text = "S:" + hsv.S;
				ls["ラベル4"].Text = "V:" + hsv.V;
				hsv = HSV.ToHSV(ref Sta.GameData.色.髪色);
				H髪.Value = (double)hsv.H / 360.0;
				S髪.Value = (double)hsv.S / 255.0;
				V髪.Value = (double)hsv.V / 255.0;
				H髪.Base.BrushColor = Sta.GameData.色.髪色;
				S髪.Base.BrushColor = Sta.GameData.色.髪色;
				V髪.Base.BrushColor = Sta.GameData.色.髪色;
				ls["ラベル6"].Text = "H:" + hsv.H;
				ls["ラベル7"].Text = "S:" + hsv.S;
				ls["ラベル8"].Text = "V:" + hsv.V;
				hsv = HSV.ToHSV(ref Sta.GameData.色.瞳色);
				H瞳.Value = (double)hsv.H / 360.0;
				S瞳.Value = (double)hsv.S / 255.0;
				V瞳.Value = (double)hsv.V / 255.0;
				H瞳.Base.BrushColor = Sta.GameData.色.瞳色;
				S瞳.Base.BrushColor = Sta.GameData.色.瞳色;
				V瞳.Base.BrushColor = Sta.GameData.色.瞳色;
				ls["ラベル10"].Text = "H:" + hsv.H;
				ls["ラベル11"].Text = "S:" + hsv.S;
				ls["ラベル12"].Text = "V:" + hsv.V;
				身長.Value = Sta.GameData.身長;
				体重.Value = Sta.GameData.体重;
				ls["ラベル14"].Text = "H:" + string.Format("{0:0.00}", 身長.Value);
				ls["ラベル15"].Text = "W:" + string.Format("{0:0.00}", 体重.Value);
			};
			Mods.情報設定描画 = delegate(Are a, FPS FPS)
			{
				CS$<>8__locals1.Med.GH.Clear(Col.Transparent);
				if (a.GH != null)
				{
					a.GH.Clear(Col.Transparent);
				}
				a.Draw(Mods.黒背景);
				ls.Draw(a);
				a.Draw(H肌.Pars);
				a.Draw(S肌.Pars);
				a.Draw(V肌.Pars);
				a.Draw(H髪.Pars);
				a.Draw(S髪.Pars);
				a.Draw(V髪.Pars);
				a.Draw(H瞳.Pars);
				a.Draw(S瞳.Pars);
				a.Draw(V瞳.Pars);
				a.Draw(身長.Pars);
				a.Draw(体重.Pars);
				完了.Draw(a);
				CS$<>8__locals1.Med.Draw(a);
			};
			mod.Draw = delegate(FPS FPS)
			{
				Mods.映転(CS$<>8__locals1.Med, Mods.描画バッファ, FPS, Mods.情報設定描画);
			};
			mod.Dispose = delegate()
			{
				ls.Dispose();
				H肌.Dispose();
				S肌.Dispose();
				V肌.Dispose();
				H髪.Dispose();
				S髪.Dispose();
				V髪.Dispose();
				H瞳.Dispose();
				S瞳.Dispose();
				V瞳.Dispose();
				身長.Dispose();
				体重.Dispose();
				完了.Dispose();
			};
			return mod;
		}

		public static Mod OP0(Med Med)
		{
			Mods.<>c__DisplayClass106_0 CS$<>8__locals1 = new Mods.<>c__DisplayClass106_0();
			CS$<>8__locals1.Med = Med;
			Mod mod = new Mod();
			int i = 0;
			int wi = 0;
			string[] tsp = new string[]
			{
				tex.点12,
				tex.点9,
				tex.点6,
				tex.点3
			};
			string[] sub = new string[]
			{
				"",
				tex.闇が揺れる,
				tex.身体が現る,
				tex.意識が宿る
			};
			mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				int i;
				if (!Mods.ip.Mai.IsPlaing && !Mods.ip.Sub.IsPlaing && wi == i)
				{
					i = i;
					i++;
					wi = i;
					if (i < tsp.Length)
					{
						Mods.ip.Text = tsp[i];
						Mods.ip.SubInfo = sub[i];
						return;
					}
					CS$<>8__locals1.Med.映転("OP1", Mods.描画バッファ, Mods.OP1描画);
				}
			};
			mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
			};
			mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
			};
			mod.Leave = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
			};
			mod.Wheel = delegate(MouseButtons mb, Vector2D cp, int dt, Color hc)
			{
			};
			mod.Setting = delegate()
			{
				Mods.ip.UpdateSub2();
				Mods.ip.MaiShow = true;
				Mods.ip.Mai.Feed.Dra = true;
				Mods.ip.Mai2Show = false;
				Mods.ip.SubShow = true;
				Mods.ip.Sub2Show = true;
				Sou.OPBGM.Stop();
				i = 0;
				wi = 0;
				Mods.ip.Text = tsp[i];
				Mods.ip.SubInfo = sub[i];
			};
			Mods.OP0描画 = delegate(Are a, FPS FPS)
			{
				if (a.GH != null)
				{
					a.GH.Clear(Col.Transparent);
				}
				a.Draw(Mods.黒背景);
				Mods.dbs.Draw(a);
				Mods.ip.Draw(a, FPS);
				CS$<>8__locals1.Med.Draw(a);
			};
			mod.Draw = delegate(FPS FPS)
			{
				Mods.映転(CS$<>8__locals1.Med, Mods.描画バッファ, FPS, Mods.OP0描画);
			};
			mod.Dispose = delegate()
			{
			};
			return mod;
		}

		public static Mod OP1(Med Med)
		{
			Mods.<>c__DisplayClass107_0 CS$<>8__locals1 = new Mods.<>c__DisplayClass107_0();
			CS$<>8__locals1.Med = Med;
			Mod mod = new Mod();
			Mods.<>c__DisplayClass107_1 CS$<>8__locals2 = new Mods.<>c__DisplayClass107_1();
			CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
			CS$<>8__locals2.i = 0;
			CS$<>8__locals2.wi = 0;
			Mods.<>c__DisplayClass107_1 CS$<>8__locals3 = CS$<>8__locals2;
			Action[] array = new Action[15];
			array[0] = delegate()
			{
				Mods.ヴィオラ.表情_基本0();
			};
			array[1] = delegate()
			{
				Mods.ヴィオラ.表情_基本1();
			};
			array[2] = delegate()
			{
				Mods.ヴィオラ.表情_困り顔0();
			};
			array[3] = delegate()
			{
				Mods.ヴィオラ.表情_困り顔1();
			};
			array[4] = delegate()
			{
				Mods.ヴィオラ.表情_不敵0();
			};
			array[5] = delegate()
			{
				Mods.ヴィオラ.表情_基本1();
			};
			array[6] = delegate()
			{
				Mods.ヴィオラ.表情_不敵1眉上();
			};
			array[7] = delegate()
			{
				Mods.ヴィオラ.表情_基本1();
			};
			array[8] = delegate()
			{
				Mods.ヴィオラ.表情_不敵0();
			};
			array[9] = delegate()
			{
				Mods.ヴィオラ.表情_不敵0眉上();
			};
			array[10] = delegate()
			{
				Mods.ヴィオラ.表情_基本1眉上();
			};
			array[11] = delegate()
			{
			};
			array[12] = delegate()
			{
				Mods.ヴィオラ.表情_卑屈();
			};
			array[13] = delegate()
			{
				Mods.ヴィオラ.表情_基本1();
			};
			array[14] = delegate()
			{
				Mods.ヴィオラ.表情_不敵0();
			};
			CS$<>8__locals3.sfc = array;
			CS$<>8__locals2.tsc = new string[]
			{
				tex.点6,
				tex.お目覚めかしら,
				tex.話の途中で眠ってしまうんですもの,
				tex.よっぽど疲れていたのね,
				tex.点3,
				tex.誰って顔をしているわね,
				tex.うふふ良いわ + "\r\n" + tex.もう一度自己紹介をしてあげる,
				tex.私の名前はヴィオランテ + "  \r\n" + tex.ここではヴィオラと呼ばれているわ,
				tex.点3,
				tex.それでは話の続きをしましょうか,
				tex.今あなたには全部で + 5000000000UL.ToString("#,0") + tex.の借金が課せられているわ,
				"",
				tex.でも心配しないで,
				tex.そんなあなたにぴったりなお仕事を紹介してあげる,
				tex.とっても儲かる素敵なお仕事をね
			};
			CS$<>8__locals2.tsp = new string[]
			{
				tex.点6ハテナ,
				tex.点6,
				tex.点9,
				tex.点6,
				tex.点9,
				tex.点6,
				tex.点6,
				tex.点6,
				tex.点6,
				tex.点6,
				tex.点6,
				"",
				tex.点9,
				tex.点6,
				tex.点9
			};
			CS$<>8__locals2.sub = new string[]
			{
				tex.光が射す,
				tex.目が眩む,
				tex.見慣れぬ女が立っている,
				tex.良い香りがする,
				tex.空気はぬるい,
				tex.女は語る,
				tex.女は続ける,
				tex.女は名乗る,
				tex.違和感を覚える,
				tex.知らない世界だ,
				"",
				"",
				tex.なんて日だ,
				tex.話が進む,
				tex.事は運ぶ
			};
			CS$<>8__locals2.d = delegate(Tex t)
			{
				Mods.ip.SubInfo = tex.安い額ではない;
				情報パネル 情報パネル = Mods.ip;
				Action<But> 選択yAct;
				if ((選択yAct = CS$<>8__locals2.<>9__25) == null)
				{
					選択yAct = (CS$<>8__locals2.<>9__25 = delegate(But t_)
					{
						Sou.操作.Play();
						Mods.ヴィオラ吹出し.Tex.Done = delegate(Tex tx)
						{
							Sou.精算.Play();
							Sta.GameData.借金 = 5000000000UL;
							Mods.ip.UpdateSub2();
						};
						Mods.ヴィオラ.表情_不敵0眉上();
						Mods.ヴィオラ吹出し.Text = tex.うふふそうよね;
						Mods.ip.Text = tex.点6;
						Mods.ip.SubInfo = tex.身に覚えはない;
						if (CS$<>8__locals2.i == 10)
						{
							int num = CS$<>8__locals2.i;
							CS$<>8__locals2.i = num + 1;
							CS$<>8__locals2.wi = CS$<>8__locals2.i;
						}
						if (CS$<>8__locals2.wi == 10)
						{
							int num = CS$<>8__locals2.wi;
							CS$<>8__locals2.wi = num + 1;
						}
						Mods.ip.選択肢表示 = false;
					});
				}
				情報パネル.選択yAct = 選択yAct;
				情報パネル 情報パネル2 = Mods.ip;
				Action<But> 選択nAct;
				if ((選択nAct = CS$<>8__locals2.<>9__26) == null)
				{
					選択nAct = (CS$<>8__locals2.<>9__26 = delegate(But t_)
					{
						Sou.操作.Play();
						Mods.ヴィオラ吹出し.Tex.Done = delegate(Tex tx)
						{
							Sou.精算.Play();
							Sta.GameData.借金 = 5000000000UL;
							Mods.ip.UpdateSub2();
						};
						Mods.ヴィオラ.表情_素1();
						Mods.ヴィオラ吹出し.Text = tex.関係ないわここに書いてあるもの + "\r\n" + tex.ほらねそうでしょう;
						Mods.ip.Text = tex.点6;
						Mods.ip.SubInfo = tex.身に覚えはない;
						if (CS$<>8__locals2.i == 10)
						{
							int num = CS$<>8__locals2.i;
							CS$<>8__locals2.i = num + 1;
							CS$<>8__locals2.wi = CS$<>8__locals2.i;
						}
						if (CS$<>8__locals2.wi == 10)
						{
							int num = CS$<>8__locals2.wi;
							CS$<>8__locals2.wi = num + 1;
						}
						Mods.ip.選択肢表示 = false;
					});
				}
				情報パネル2.選択nAct = 選択nAct;
				Mods.ip.選択肢表示 = true;
			};
			mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				Mods.ip.DownB(ref hc);
				if (!Mods.ヴィオラ吹出し.Tex.IsPlaing && !Mods.ip.Mai.IsPlaing && !Mods.ip.Sub.IsPlaing)
				{
					if (CS$<>8__locals2.wi == CS$<>8__locals2.i && CS$<>8__locals2.i != 10 && Mods.ヴィオラ吹出し.Tex.Done == null)
					{
						int i = CS$<>8__locals2.i;
						CS$<>8__locals2.i = i + 1;
						CS$<>8__locals2.wi = CS$<>8__locals2.i;
						if (CS$<>8__locals2.i >= CS$<>8__locals2.tsp.Length)
						{
							CS$<>8__locals2.CS$<>8__locals1.Med.映転("説明", Mods.描画バッファ, Mods.説明描画);
							return;
						}
						if (CS$<>8__locals2.i == 10)
						{
							Mods.ヴィオラ吹出し.Tex.Done = CS$<>8__locals2.d;
						}
						else
						{
							Mods.ヴィオラ吹出し.Tex.Done = null;
						}
						if (CS$<>8__locals2.i != 11)
						{
							CS$<>8__locals2.sfc[CS$<>8__locals2.i]();
							Mods.ヴィオラ吹出し.Text = CS$<>8__locals2.tsc[CS$<>8__locals2.i];
							Mods.ip.Text = CS$<>8__locals2.tsp[CS$<>8__locals2.i];
							Mods.ip.SubInfo = CS$<>8__locals2.sub[CS$<>8__locals2.i];
							return;
						}
					}
					else if (CS$<>8__locals2.wi == 12 && CS$<>8__locals2.i == 11)
					{
						CS$<>8__locals2.i += 2;
						CS$<>8__locals2.wi = CS$<>8__locals2.i;
						CS$<>8__locals2.sfc[CS$<>8__locals2.i]();
						Mods.ヴィオラ吹出し.Text = CS$<>8__locals2.tsc[CS$<>8__locals2.i];
						Mods.ip.Text = CS$<>8__locals2.tsp[CS$<>8__locals2.i];
						Mods.ip.SubInfo = CS$<>8__locals2.sub[CS$<>8__locals2.i];
					}
				}
			};
			mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				Mods.ip.Up(ref hc);
			};
			mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				Mods.ip.Move(ref hc);
			};
			mod.Leave = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
			};
			mod.Wheel = delegate(MouseButtons mb, Vector2D cp, int dt, Color hc)
			{
			};
			mod.Setting = delegate()
			{
				Mods.ip.Mai.Feed.Dra = false;
				Sou.日常BGM.Play();
				Sta.GameData.ヴィオラ = new Unit();
				Sta.GameData.ヴィオラ.Setヴィオラ(CS$<>8__locals2.CS$<>8__locals1.Med, Mods.描画バッファ);
				Mods.ヴィオラ = new Cha(CS$<>8__locals2.CS$<>8__locals1.Med, Mods.描画バッファ, Sta.GameData.ヴィオラ.ChaD);
				Mods.ヴィオラ.Set衣装(Sta.GameData.ヴィオラ.着衣);
				Mods.ヴィオラ吹出し.接続(Mods.ヴィオラ.Bod.頭.口_接続点);
				CS$<>8__locals2.i = 0;
				CS$<>8__locals2.wi = 0;
				CS$<>8__locals2.sfc[CS$<>8__locals2.i]();
				Mods.ヴィオラ吹出し.Text = CS$<>8__locals2.tsc[CS$<>8__locals2.i];
				Mods.ip.Text = CS$<>8__locals2.tsp[CS$<>8__locals2.i];
				Mods.ip.SubInfo = CS$<>8__locals2.sub[CS$<>8__locals2.i];
				Mods.ヴィオラ.両目_見つめ();
				Mods.ヴィオラ.Set基本姿勢();
			};
			Mods.OP1描画 = delegate(Are a, FPS FPS)
			{
				a.Draw(Mods.事務室背景);
				Mods.ヴィオラ.Draw(a, FPS);
				Mods.ヴィオラ吹出し.Draw(a, FPS);
				Mods.dbs.Draw(a);
				Mods.ip.Draw(a, FPS);
				CS$<>8__locals2.CS$<>8__locals1.Med.Draw(a);
			};
			mod.Draw = delegate(FPS FPS)
			{
				Mods.映転(CS$<>8__locals2.CS$<>8__locals1.Med, Mods.描画バッファ, FPS, Mods.OP1描画);
			};
			mod.Dispose = delegate()
			{
			};
			return mod;
		}

		public static Mod 説明(Med Med)
		{
			Mods.<>c__DisplayClass108_0 CS$<>8__locals1 = new Mods.<>c__DisplayClass108_0();
			CS$<>8__locals1.Med = Med;
			Mod mod = new Mod();
			Mods.<>c__DisplayClass108_1 CS$<>8__locals2 = new Mods.<>c__DisplayClass108_1();
			CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
			CS$<>8__locals2.i = 0;
			CS$<>8__locals2.wi = 0;
			Mods.<>c__DisplayClass108_1 CS$<>8__locals3 = CS$<>8__locals2;
			Action[] array = new Action[11];
			array[0] = delegate()
			{
				Mods.ヴィオラ.表情_基本0();
			};
			array[1] = delegate()
			{
				Mods.ヴィオラ.表情_基本1();
			};
			array[2] = delegate()
			{
				Mods.ヴィオラ.表情_不敵1();
			};
			array[3] = delegate()
			{
				Mods.ヴィオラ.表情_基本0();
			};
			array[4] = delegate()
			{
				Mods.ヴィオラ.表情_基本1();
			};
			array[5] = delegate()
			{
				Mods.ヴィオラ.表情_不敵0眉上();
			};
			array[6] = delegate()
			{
				Mods.ヴィオラ.表情_基本1眉上();
			};
			array[7] = delegate()
			{
				Mods.ヴィオラ.表情_不敵0眉上();
			};
			array[8] = delegate()
			{
				Mods.ヴィオラ.表情_基本1();
			};
			array[9] = delegate()
			{
				Mods.ヴィオラ.表情_不敵1眉上();
			};
			array[10] = delegate()
			{
				Mods.ヴィオラ.表情_不敵0眉上();
			};
			CS$<>8__locals3.sfc = array;
			CS$<>8__locals2.tsc = new string[]
			{
				tex.点3,
				tex.ここは地下牢よ,
				tex.あなたにはこの場所で調教師として働いてもらうわ,
				tex.仕事の流れを説明するわね,
				tex.まず事務所で奴隷を仕入れて頂戴,
				tex.仕入れたら性奴として使えるようにあなたが躾けるの,
				tex.躾けた分だけ上乗せされた値段で売れるようになるわ,
				tex.それと従順になった奴隷に働いてもらうのもいいわね + "   \r\n" + tex.あと奴隷の転売という手もあるわ,
				tex.まぁこんなところね簡単でしょう,
				tex.それでは頑張って頂戴,
				tex.期待しているわ
			};
			CS$<>8__locals2.tsp = new string[]
			{
				tex.点6,
				tex.点3,
				tex.点6,
				tex.点6,
				tex.点6,
				tex.点6,
				tex.点6,
				tex.点6,
				tex.点6,
				tex.点6,
				tex.点6
			};
			CS$<>8__locals2.sub = new string[]
			{
				tex.冷めた空気が舞い上がる,
				tex.ヴィオラは語る,
				tex.仕事が決まる,
				tex.説明が始まる,
				tex.ヴィオラは語る,
				tex.ヴィオラは続ける,
				tex.説明が続く,
				tex.説明は続く,
				tex.説明が終わる,
				tex.奴隷母体の名の下に,
				tex.物語は動き出す
			};
			mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				Mods.ip.DownB(ref hc);
				if (!Mods.ヴィオラ吹出し.Tex.IsPlaing && !Mods.ip.Mai.IsPlaing && !Mods.ip.Sub.IsPlaing && CS$<>8__locals2.wi == CS$<>8__locals2.i)
				{
					int i = CS$<>8__locals2.i;
					CS$<>8__locals2.i = i + 1;
					CS$<>8__locals2.wi = CS$<>8__locals2.i;
					if (CS$<>8__locals2.i < CS$<>8__locals2.tsp.Length)
					{
						CS$<>8__locals2.sfc[CS$<>8__locals2.i]();
						Mods.ヴィオラ吹出し.Text = CS$<>8__locals2.tsc[CS$<>8__locals2.i];
						Mods.ip.Text = CS$<>8__locals2.tsp[CS$<>8__locals2.i];
						Mods.ip.SubInfo = CS$<>8__locals2.sub[CS$<>8__locals2.i];
						return;
					}
					CS$<>8__locals2.CS$<>8__locals1.Med.映転("メインフォーム", Mods.描画バッファ, Mods.メインフォ\u30FCム描画);
				}
			};
			mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				Mods.ip.Up(ref hc);
			};
			mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				Mods.ip.Move(ref hc);
			};
			mod.Leave = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
			};
			mod.Wheel = delegate(MouseButtons mb, Vector2D cp, int dt, Color hc)
			{
			};
			mod.Setting = delegate()
			{
				Mods.ヴィオラ.両目_見つめ();
				Mods.ヴィオラ.表情_基本1();
				Mods.ヴィオラ.Set基本姿勢();
				CS$<>8__locals2.i = 0;
				CS$<>8__locals2.wi = 0;
				CS$<>8__locals2.sfc[CS$<>8__locals2.i]();
				Mods.ヴィオラ吹出し.Text = CS$<>8__locals2.tsc[CS$<>8__locals2.i];
				Mods.ip.Text = CS$<>8__locals2.tsp[CS$<>8__locals2.i];
				Mods.ip.SubInfo = CS$<>8__locals2.sub[CS$<>8__locals2.i];
			};
			Mods.説明描画 = delegate(Are a, FPS FPS)
			{
				if (a.GH != null)
				{
					a.GH.Clear(Col.Transparent);
				}
				a.Draw(Mods.地下室背景);
				Mods.ヴィオラ.Draw(a, FPS);
				Mods.ヴィオラ吹出し.Draw(a, FPS);
				Mods.dbs.Draw(a);
				Mods.ip.Draw(a, FPS);
				CS$<>8__locals2.CS$<>8__locals1.Med.Draw(a);
			};
			mod.Draw = delegate(FPS FPS)
			{
				Mods.映転(CS$<>8__locals2.CS$<>8__locals1.Med, Mods.描画バッファ, FPS, Mods.説明描画);
			};
			mod.Dispose = delegate()
			{
			};
			return mod;
		}

		public static Mod 初事務所(Med Med)
		{
			Mods.<>c__DisplayClass109_0 CS$<>8__locals1 = new Mods.<>c__DisplayClass109_0();
			CS$<>8__locals1.Med = Med;
			Mod mod = new Mod();
			Mods.<>c__DisplayClass109_1 CS$<>8__locals2 = new Mods.<>c__DisplayClass109_1();
			CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
			CS$<>8__locals2.i = 0;
			CS$<>8__locals2.wi = 0;
			Mods.<>c__DisplayClass109_1 CS$<>8__locals3 = CS$<>8__locals2;
			Action[] array = new Action[11];
			array[0] = delegate()
			{
				Mods.ヴィオラ.表情_基本0();
			};
			array[1] = delegate()
			{
				Mods.ヴィオラ.表情_不敵1();
			};
			array[2] = delegate()
			{
			};
			array[3] = delegate()
			{
				Mods.ヴィオラ.表情_不敵1眉上();
			};
			array[4] = delegate()
			{
				Mods.ヴィオラ.表情_基本1();
			};
			array[5] = delegate()
			{
				Mods.ヴィオラ.表情_不敵1眉上();
			};
			array[6] = delegate()
			{
				Mods.ヴィオラ.表情_基本0();
			};
			array[7] = delegate()
			{
			};
			array[8] = delegate()
			{
				Mods.ヴィオラ.表情_不敵0眉上();
			};
			array[9] = delegate()
			{
				Mods.ヴィオラ.表情_基本0();
			};
			array[10] = delegate()
			{
				Mods.ヴィオラ.表情_不敵0();
			};
			CS$<>8__locals3.sfc = array;
			CS$<>8__locals2.tsc = new string[]
			{
				tex.点6,
				tex.どうかしたの,
				"",
				tex.お金がなければ借りればいいじゃない,
				tex.借金と返済は事務所つまりここで出来るわ,
				string.Concat(new string[]
				{
					tex.借金には1日,
					Sta.GameData.利子.ToPercent().ToString(),
					tex.の利子がつくわよ,
					"  \r\n",
					tex.良心的よねうふふ
				}),
				tex.そうそう言い忘れていたけどあなたは調教師として必要な拘束術が使えるようになっているはずよ,
				"",
				tex.点6,
				tex.私からは以上よ,
				tex.仕事に戻ると良いわ
			};
			CS$<>8__locals2.tsp = new string[]
			{
				tex.点6,
				tex.点3,
				"",
				tex.点6,
				tex.点6,
				tex.点6,
				tex.点6,
				"",
				tex.点6,
				tex.点6,
				tex.点6
			};
			CS$<>8__locals2.sub = new string[]
			{
				tex.ヴィオラは佇む,
				tex.ヴィオラは尋ねる,
				"",
				tex.ヴィオラは返す,
				tex.説明が始まる,
				tex.ヴィオラは語る,
				tex.話は続く,
				"",
				tex.危険な女だ,
				tex.話が終わる,
				tex.話は終わる
			};
			CS$<>8__locals2.d1 = delegate(Tex t)
			{
				Tex mai = Mods.ip.Mai;
				Action<Tex> done;
				if ((done = CS$<>8__locals2.<>9__22) == null)
				{
					done = (CS$<>8__locals2.<>9__22 = delegate(Tex t_)
					{
						情報パネル 情報パネル = Mods.ip;
						Action<But> 選択yAct;
						if ((選択yAct = CS$<>8__locals2.<>9__23) == null)
						{
							選択yAct = (CS$<>8__locals2.<>9__23 = delegate(But te)
							{
								Sou.操作.Play();
								Mods.ヴィオラ.表情_不敵0眉上();
								Mods.ヴィオラ吹出し.Text = tex.うふふそうよね;
								Mods.ip.Text = tex.点6;
								Mods.ip.SubInfo = tex.あなたは答える;
								if (CS$<>8__locals2.i == 1)
								{
									int num = CS$<>8__locals2.i;
									CS$<>8__locals2.i = num + 1;
									CS$<>8__locals2.wi = CS$<>8__locals2.i;
								}
								if (CS$<>8__locals2.wi == 1)
								{
									int num = CS$<>8__locals2.wi;
									CS$<>8__locals2.wi = num + 1;
								}
								Mods.ip.選択肢表示 = false;
							});
						}
						情報パネル.選択yAct = 選択yAct;
						情報パネル 情報パネル2 = Mods.ip;
						Action<But> 選択nAct;
						if ((選択nAct = CS$<>8__locals2.<>9__24) == null)
						{
							選択nAct = (CS$<>8__locals2.<>9__24 = delegate(But te)
							{
								Sou.操作.Play();
								Mods.ヴィオラ.表情_困り顔1();
								Mods.ヴィオラ吹出し.Text = tex.嘘おっしゃい無いのは分かっているわ;
								Mods.ip.Text = tex.点6;
								Mods.ip.SubInfo = tex.あなたは答える;
								if (CS$<>8__locals2.i == 1)
								{
									int num = CS$<>8__locals2.i;
									CS$<>8__locals2.i = num + 1;
									CS$<>8__locals2.wi = CS$<>8__locals2.i;
								}
								if (CS$<>8__locals2.wi == 1)
								{
									int num = CS$<>8__locals2.wi;
									CS$<>8__locals2.wi = num + 1;
								}
								Mods.ip.選択肢表示 = false;
							});
						}
						情報パネル2.選択nAct = 選択nAct;
						Mods.ip.選択肢表示 = true;
					});
				}
				mai.Done = done;
				Mods.ip.Text = tex.金が無い;
			};
			CS$<>8__locals2.d2 = delegate(Tex t)
			{
				Tex mai = Mods.ip.Mai;
				Action<Tex> done;
				if ((done = CS$<>8__locals2.<>9__25) == null)
				{
					done = (CS$<>8__locals2.<>9__25 = delegate(Tex t_)
					{
						情報パネル 情報パネル = Mods.ip;
						Action<But> 選択yAct;
						if ((選択yAct = CS$<>8__locals2.<>9__26) == null)
						{
							選択yAct = (CS$<>8__locals2.<>9__26 = delegate(But te)
							{
								Sou.操作.Play();
								Mods.ip.Sub.Done = delegate(Tex tx)
								{
									Mods.ヴィオラ.Bod.拘束具_表示 = false;
									Mods.ヴィオラ.両翼獣_全開(0);
									Mods.ヴィオラ.両触手_S字(0);
									Mods.ヴィオラ.両触手_S字(1);
									Mods.ヴィオラ.Set触手系対称化();
									Mods.ヴィオラ.Bod.Update();
									Mods.ヴィオラ.表情_不敵1();
									Sou.弾け.Play();
									Mods.ip.Text = tex.エクス2;
									Mods.ip.SubInfo = tex.あなたの鎖は弾け飛ぶ;
									Mods.ヴィオラ吹出し.Text = tex.あらあら今ので利子が上がってしまったわうふふ;
									Mods.ヴィオラ吹出し.Tex.Feed.Dra = true;
									Sta.GameData.利子 *= 2.0;
								};
								Mods.ヴィオラ吹出し.Tex.Feed.Dra = false;
								Mods.ヴィオラ.Bod.拘束具_表示 = true;
								Mods.ヴィオラ.両翼獣_閉じ(0);
								Mods.ヴィオラ.両触手_S字(0);
								Mods.ヴィオラ.両触手_S字(1);
								Mods.ヴィオラ.Set触手系対称化();
								Mods.ヴィオラ.Bod.Update();
								Mods.ヴィオラ.表情_素0眉上();
								Sou.変更1.Play();
								Mods.ヴィオラ吹出し.Text = tex.っ点3;
								Mods.ip.Text = tex.エクス1;
								Mods.ip.SubInfo = tex.鋼の鎖がヴィオラを縛る + "        ";
								if (CS$<>8__locals2.i == 6)
								{
									int num = CS$<>8__locals2.i;
									CS$<>8__locals2.i = num + 1;
									CS$<>8__locals2.wi = CS$<>8__locals2.i;
								}
								if (CS$<>8__locals2.wi == 6)
								{
									int num = CS$<>8__locals2.wi;
									CS$<>8__locals2.wi = num + 1;
								}
								Mods.ip.選択肢表示 = false;
							});
						}
						情報パネル.選択yAct = 選択yAct;
						情報パネル 情報パネル2 = Mods.ip;
						Action<But> 選択nAct;
						if ((選択nAct = CS$<>8__locals2.<>9__27) == null)
						{
							選択nAct = (CS$<>8__locals2.<>9__27 = delegate(But te)
							{
								Sou.操作.Play();
								Mods.ヴィオラ.表情_不敵0();
								Mods.ヴィオラ吹出し.Text = tex.点3うふふ + "\r\n" + tex.慎重なのは良いことよ;
								Mods.ip.Text = tex.点6;
								Mods.ip.SubInfo = tex.ヴィオラは微笑む;
								if (CS$<>8__locals2.i == 6)
								{
									int num = CS$<>8__locals2.i;
									CS$<>8__locals2.i = num + 1;
									CS$<>8__locals2.wi = CS$<>8__locals2.i;
								}
								if (CS$<>8__locals2.wi == 6)
								{
									int num = CS$<>8__locals2.wi;
									CS$<>8__locals2.wi = num + 1;
								}
								Mods.ip.選択肢表示 = false;
							});
						}
						情報パネル2.選択nAct = 選択nAct;
						Mods.ip.選択肢表示 = true;
					});
				}
				mai.Done = done;
				Mods.ip.Text = tex.ヴィオラで試す;
			};
			mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				Mods.ip.DownB(ref hc);
				if (!Mods.ヴィオラ吹出し.Tex.IsPlaing && !Mods.ip.Mai.IsPlaing && !Mods.ip.Sub.IsPlaing)
				{
					if (CS$<>8__locals2.wi == CS$<>8__locals2.i && CS$<>8__locals2.i != 1 && CS$<>8__locals2.i != 6 && Mods.ヴィオラ吹出し.Tex.Done == null)
					{
						int i = CS$<>8__locals2.i;
						CS$<>8__locals2.i = i + 1;
						CS$<>8__locals2.wi = CS$<>8__locals2.i;
						if (CS$<>8__locals2.i >= CS$<>8__locals2.tsp.Length)
						{
							Sta.GameData.初事務所フラグ = false;
							CS$<>8__locals2.CS$<>8__locals1.Med.映転("事務所", Mods.描画バッファ, Mods.事務所描画);
							return;
						}
						if (CS$<>8__locals2.i == 8)
						{
							Mods.ヴィオラ.両翼獣_半開き(0);
							Mods.ヴィオラ.Bod.Update();
						}
						if (CS$<>8__locals2.i == 1)
						{
							Mods.ヴィオラ吹出し.Tex.Done = CS$<>8__locals2.d1;
						}
						else if (CS$<>8__locals2.i == 6)
						{
							Mods.ヴィオラ吹出し.Tex.Done = CS$<>8__locals2.d2;
						}
						else
						{
							Mods.ヴィオラ吹出し.Tex.Done = null;
						}
						if (CS$<>8__locals2.i != 2 && CS$<>8__locals2.i != 7)
						{
							CS$<>8__locals2.sfc[CS$<>8__locals2.i]();
							Mods.ヴィオラ吹出し.Text = CS$<>8__locals2.tsc[CS$<>8__locals2.i];
							Mods.ip.Text = CS$<>8__locals2.tsp[CS$<>8__locals2.i];
							Mods.ip.SubInfo = CS$<>8__locals2.sub[CS$<>8__locals2.i];
							return;
						}
					}
					else if ((CS$<>8__locals2.wi == 3 && CS$<>8__locals2.i == 2) || (CS$<>8__locals2.wi == 8 && CS$<>8__locals2.i == 7))
					{
						CS$<>8__locals2.i += 2;
						CS$<>8__locals2.wi = CS$<>8__locals2.i;
						CS$<>8__locals2.sfc[CS$<>8__locals2.i]();
						Mods.ヴィオラ吹出し.Text = CS$<>8__locals2.tsc[CS$<>8__locals2.i];
						Mods.ip.Text = CS$<>8__locals2.tsp[CS$<>8__locals2.i];
						Mods.ip.SubInfo = CS$<>8__locals2.sub[CS$<>8__locals2.i];
					}
				}
			};
			mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				Mods.ip.Up(ref hc);
			};
			mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				Mods.ip.Move(ref hc);
			};
			mod.Leave = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
			};
			mod.Wheel = delegate(MouseButtons mb, Vector2D cp, int dt, Color hc)
			{
			};
			mod.Setting = delegate()
			{
				Mods.ip.UpdateSub2();
				Mods.ip.MaiShow = true;
				Mods.ip.Mai.Feed.Dra = false;
				Mods.ip.Mai2Show = false;
				Mods.ip.SubShow = true;
				Mods.ip.Sub2Show = true;
				Mods.ヴィオラ吹出し.Tex.Feed.Dra = true;
				Mods.ヴィオラ.両目_見つめ();
				Mods.ヴィオラ.表情_基本0();
				Mods.ヴィオラ.Set基本姿勢();
				CS$<>8__locals2.i = 0;
				CS$<>8__locals2.wi = 0;
				CS$<>8__locals2.sfc[CS$<>8__locals2.i]();
				Mods.ヴィオラ吹出し.Text = CS$<>8__locals2.tsc[CS$<>8__locals2.i];
				Mods.ip.Text = CS$<>8__locals2.tsp[CS$<>8__locals2.i];
				Mods.ip.SubInfo = CS$<>8__locals2.sub[CS$<>8__locals2.i];
			};
			Mods.初事務所描画 = delegate(Are a, FPS FPS)
			{
				if (a.GH != null)
				{
					a.GH.Clear(Col.Transparent);
				}
				a.Draw(Mods.事務室背景);
				Mods.ヴィオラ.Draw(a, FPS);
				Mods.ヴィオラ吹出し.Draw(a, FPS);
				Mods.dbs.Draw(a);
				Mods.ip.Draw(a, FPS);
				CS$<>8__locals2.CS$<>8__locals1.Med.Draw(a);
			};
			mod.Draw = delegate(FPS FPS)
			{
				Mods.映転(CS$<>8__locals2.CS$<>8__locals1.Med, Mods.描画バッファ, FPS, Mods.初事務所描画);
			};
			mod.Dispose = delegate()
			{
			};
			return mod;
		}

		public static Mod 返済イベント1(Med Med)
		{
			Mods.<>c__DisplayClass110_0 CS$<>8__locals1 = new Mods.<>c__DisplayClass110_0();
			CS$<>8__locals1.Med = Med;
			Mod mod = new Mod();
			Mods.<>c__DisplayClass110_1 CS$<>8__locals2 = new Mods.<>c__DisplayClass110_1();
			CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
			CS$<>8__locals2.i = 0;
			CS$<>8__locals2.wi = 0;
			Mods.<>c__DisplayClass110_1 CS$<>8__locals3 = CS$<>8__locals2;
			Action[] array = new Action[3];
			array[0] = delegate()
			{
				Mods.ヴィオラ.表情_不敵0();
			};
			array[1] = delegate()
			{
				Mods.ヴィオラ.表情_基本1();
			};
			array[2] = delegate()
			{
				Mods.ヴィオラ.表情_不敵1();
			};
			CS$<>8__locals3.sfc = array;
			CS$<>8__locals2.tsc = new string[]
			{
				tex.仕事には慣れたかしら,
				tex.あなたが頑張っているおかげで奴隷の仕入元のハンタ\u30FCと話がまとまったの,
				tex.今後もこの調子で頑張って頂戴
			};
			CS$<>8__locals2.tsp = new string[]
			{
				tex.点3,
				tex.点6,
				tex.点6
			};
			CS$<>8__locals2.sub = new string[]
			{
				tex.ヴィオラが尋ねる,
				tex.ヴィオラは語る,
				tex.話が終わる
			};
			mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				Mods.ip.DownB(ref hc);
				if (!Mods.ヴィオラ吹出し.Tex.IsPlaing && !Mods.ip.Mai.IsPlaing && !Mods.ip.Sub.IsPlaing && CS$<>8__locals2.wi == CS$<>8__locals2.i)
				{
					int i = CS$<>8__locals2.i;
					CS$<>8__locals2.i = i + 1;
					CS$<>8__locals2.wi = CS$<>8__locals2.i;
					if (CS$<>8__locals2.i < CS$<>8__locals2.tsp.Length)
					{
						CS$<>8__locals2.sfc[CS$<>8__locals2.i]();
						Mods.ヴィオラ吹出し.Text = CS$<>8__locals2.tsc[CS$<>8__locals2.i];
						Mods.ip.Text = CS$<>8__locals2.tsp[CS$<>8__locals2.i];
						Mods.ip.SubInfo = CS$<>8__locals2.sub[CS$<>8__locals2.i];
						return;
					}
					CS$<>8__locals2.CS$<>8__locals1.Med.映転("事務所", Mods.描画バッファ, Mods.事務所描画);
				}
			};
			mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				Mods.ip.Up(ref hc);
			};
			mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				Mods.ip.Move(ref hc);
			};
			mod.Leave = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
			};
			mod.Wheel = delegate(MouseButtons mb, Vector2D cp, int dt, Color hc)
			{
			};
			mod.Setting = delegate()
			{
				Mods.ip.UpdateSub2();
				Mods.ip.MaiShow = true;
				Mods.ip.Mai.Feed.Dra = false;
				Mods.ip.Mai2Show = false;
				Mods.ip.SubShow = true;
				Mods.ip.Sub2Show = true;
				Mods.ヴィオラ吹出し.Tex.Feed.Dra = true;
				Mods.ヴィオラ.両目_見つめ();
				Mods.ヴィオラ.表情_基本0();
				Mods.ヴィオラ.Set基本姿勢();
				CS$<>8__locals2.i = 0;
				CS$<>8__locals2.wi = 0;
				CS$<>8__locals2.sfc[CS$<>8__locals2.i]();
				Mods.ヴィオラ吹出し.Text = CS$<>8__locals2.tsc[CS$<>8__locals2.i];
				Mods.ip.Text = CS$<>8__locals2.tsp[CS$<>8__locals2.i];
				Mods.ip.SubInfo = CS$<>8__locals2.sub[CS$<>8__locals2.i];
			};
			Mods.返済イベント描画 = delegate(Are a, FPS FPS)
			{
				if (a.GH != null)
				{
					a.GH.Clear(Col.Transparent);
				}
				a.Draw(Mods.事務室背景);
				Mods.ヴィオラ.Draw(a, FPS);
				Mods.ヴィオラ吹出し.Draw(a, FPS);
				Mods.dbs.Draw(a);
				Mods.ip.Draw(a, FPS);
				CS$<>8__locals2.CS$<>8__locals1.Med.Draw(a);
			};
			mod.Draw = delegate(FPS FPS)
			{
				Mods.映転(CS$<>8__locals2.CS$<>8__locals1.Med, Mods.描画バッファ, FPS, Mods.返済イベント描画);
			};
			mod.Dispose = delegate()
			{
			};
			return mod;
		}

		public static Mod 返済イベント2(Med Med)
		{
			Mods.<>c__DisplayClass111_0 CS$<>8__locals1 = new Mods.<>c__DisplayClass111_0();
			CS$<>8__locals1.Med = Med;
			Mod mod = new Mod();
			Mods.<>c__DisplayClass111_1 CS$<>8__locals2 = new Mods.<>c__DisplayClass111_1();
			CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
			CS$<>8__locals2.i = 0;
			CS$<>8__locals2.wi = 0;
			Mods.<>c__DisplayClass111_1 CS$<>8__locals3 = CS$<>8__locals2;
			Action[] array = new Action[3];
			array[0] = delegate()
			{
				Mods.ヴィオラ.表情_不敵1();
			};
			array[1] = delegate()
			{
				Mods.ヴィオラ.表情_不敵0眉上();
			};
			array[2] = delegate()
			{
				Mods.ヴィオラ.表情_基本0();
			};
			CS$<>8__locals3.sfc = array;
			CS$<>8__locals2.tsc = new string[]
			{
				tex.うふふ + "\r\n" + tex.なかなか順調のようね,
				tex.そろそろ奴隷の身嗜みを考えてみてもいいんじゃないかしら,
				tex.身嗜みに手を加えられるように手配しておくわね
			};
			CS$<>8__locals2.tsp = new string[]
			{
				tex.点3,
				tex.点6,
				tex.点3
			};
			CS$<>8__locals2.sub = new string[]
			{
				tex.ヴィオラが語る,
				tex.ヴィオラは語る,
				tex.事は運ぶ
			};
			mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				Mods.ip.DownB(ref hc);
				if (!Mods.ヴィオラ吹出し.Tex.IsPlaing && !Mods.ip.Mai.IsPlaing && !Mods.ip.Sub.IsPlaing && CS$<>8__locals2.wi == CS$<>8__locals2.i)
				{
					int i = CS$<>8__locals2.i;
					CS$<>8__locals2.i = i + 1;
					CS$<>8__locals2.wi = CS$<>8__locals2.i;
					if (CS$<>8__locals2.i < CS$<>8__locals2.tsp.Length)
					{
						CS$<>8__locals2.sfc[CS$<>8__locals2.i]();
						Mods.ヴィオラ吹出し.Text = CS$<>8__locals2.tsc[CS$<>8__locals2.i];
						Mods.ip.Text = CS$<>8__locals2.tsp[CS$<>8__locals2.i];
						Mods.ip.SubInfo = CS$<>8__locals2.sub[CS$<>8__locals2.i];
						return;
					}
					CS$<>8__locals2.CS$<>8__locals1.Med.映転("事務所", Mods.描画バッファ, Mods.事務所描画);
				}
			};
			mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				Mods.ip.Up(ref hc);
			};
			mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				Mods.ip.Move(ref hc);
			};
			mod.Leave = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
			};
			mod.Wheel = delegate(MouseButtons mb, Vector2D cp, int dt, Color hc)
			{
			};
			mod.Setting = delegate()
			{
				Mods.ip.UpdateSub2();
				Mods.ip.MaiShow = true;
				Mods.ip.Mai.Feed.Dra = false;
				Mods.ip.Mai2Show = false;
				Mods.ip.SubShow = true;
				Mods.ip.Sub2Show = true;
				Mods.ヴィオラ吹出し.Tex.Feed.Dra = true;
				Mods.ヴィオラ.両目_見つめ();
				Mods.ヴィオラ.表情_基本0();
				Mods.ヴィオラ.Set基本姿勢();
				CS$<>8__locals2.i = 0;
				CS$<>8__locals2.wi = 0;
				CS$<>8__locals2.sfc[CS$<>8__locals2.i]();
				Mods.ヴィオラ吹出し.Text = CS$<>8__locals2.tsc[CS$<>8__locals2.i];
				Mods.ip.Text = CS$<>8__locals2.tsp[CS$<>8__locals2.i];
				Mods.ip.SubInfo = CS$<>8__locals2.sub[CS$<>8__locals2.i];
			};
			mod.Draw = delegate(FPS FPS)
			{
				Mods.映転(CS$<>8__locals2.CS$<>8__locals1.Med, Mods.描画バッファ, FPS, Mods.返済イベント描画);
			};
			mod.Dispose = delegate()
			{
			};
			return mod;
		}

		public static Mod 返済イベント3(Med Med)
		{
			Mods.<>c__DisplayClass112_0 CS$<>8__locals1 = new Mods.<>c__DisplayClass112_0();
			CS$<>8__locals1.Med = Med;
			Mod mod = new Mod();
			Mods.<>c__DisplayClass112_1 CS$<>8__locals2 = new Mods.<>c__DisplayClass112_1();
			CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
			CS$<>8__locals2.yes = false;
			CS$<>8__locals2.i = 0;
			CS$<>8__locals2.wi = 0;
			Mods.<>c__DisplayClass112_1 CS$<>8__locals3 = CS$<>8__locals2;
			Action[] array = new Action[4];
			array[0] = delegate()
			{
				Mods.ヴィオラ.表情_不敵1眉上();
			};
			array[1] = delegate()
			{
				Mods.ヴィオラ.表情_不敵0();
			};
			array[2] = delegate()
			{
				Mods.ヴィオラ.表情_基本0();
			};
			array[3] = delegate()
			{
			};
			CS$<>8__locals3.sfc = array;
			Mods.<>c__DisplayClass112_1 CS$<>8__locals4 = CS$<>8__locals2;
			Action[] array2 = new Action[5];
			array2[0] = delegate()
			{
				Mods.ヴィオラ.表情_素0();
			};
			array2[1] = delegate()
			{
				Mods.ヴィオラ.表情_不敵1眉上();
			};
			array2[2] = delegate()
			{
				Mods.ヴィオラ.表情_困り顔0();
			};
			array2[3] = delegate()
			{
				Mods.ヴィオラ.表情_困り顔1();
			};
			array2[4] = delegate()
			{
				Mods.ヴィオラ.表情_不敵0眉上();
			};
			CS$<>8__locals4.sfcy = array2;
			Mods.<>c__DisplayClass112_1 CS$<>8__locals5 = CS$<>8__locals2;
			Action[] array3 = new Action[5];
			array3[0] = delegate()
			{
				Mods.ヴィオラ.表情_不敵1();
			};
			array3[1] = delegate()
			{
				Mods.ヴィオラ.表情_不敵0眉上();
			};
			array3[2] = delegate()
			{
				Mods.ヴィオラ.表情_基本0();
			};
			array3[3] = delegate()
			{
				Mods.ヴィオラ.表情_不敵1();
			};
			array3[4] = delegate()
			{
				Mods.ヴィオラ.表情_不敵0();
			};
			CS$<>8__locals5.sfcn = array3;
			CS$<>8__locals2.tsc = new string[]
			{
				tex.うふふ + "\r\n" + tex.まさか本当に完済してくれるとは思わなかったわ,
				tex.もうあなたがここに縛られている理由は何もないわね,
				tex.だから好きになさい,
				""
			};
			CS$<>8__locals2.tscy = new string[]
			{
				tex.点6,
				tex.そんなこと言わずにもっとゆっくりしていくといいわ,
				tex.別にあなたを帰すときのことを考えてなかったとかそういうことではないのよ,
				tex.点6,
				tex.とにかくご苦労様 + "\r\n" + tex.そしてありがとう調教師
			};
			CS$<>8__locals2.tscn = new string[]
			{
				tex.あなたを手放すなんてありえないわ,
				tex.なんてったって + 5000000000UL.ToString("#,0") + tex.もの稼ぎ手ですもの,
				tex.点3,
				tex.点6,
				tex.お勤めご苦労様 + "\r\n" + tex.そしてありがとう調教師
			};
			CS$<>8__locals2.tsp = new string[]
			{
				tex.点3,
				tex.点6,
				tex.点6,
				"",
				tex.点6,
				tex.点6,
				tex.点6,
				tex.点6,
				tex.点6
			};
			CS$<>8__locals2.sub = new string[]
			{
				tex.ヴィオラは語る,
				tex.ヴィオラは続ける,
				tex.あなたは自由だ,
				""
			};
			CS$<>8__locals2.suby = new string[]
			{
				tex.ヴィオラは黙る,
				tex.ヴィオラは慌てる,
				tex.弁解は続く,
				tex.危険な女だ,
				tex.物語は終わった
			};
			CS$<>8__locals2.subn = new string[]
			{
				tex.ヴィオラは語る,
				tex.ヴィオラは続ける,
				tex.余韻が響く,
				tex.余韻に浸る,
				tex.物語は終わった
			};
			CS$<>8__locals2.d1 = delegate(Tex t)
			{
				Tex mai = Mods.ip.Mai;
				Action<Tex> done;
				if ((done = CS$<>8__locals2.<>9__23) == null)
				{
					done = (CS$<>8__locals2.<>9__23 = delegate(Tex t_)
					{
						情報パネル 情報パネル = Mods.ip;
						Action<But> 選択yAct;
						if ((選択yAct = CS$<>8__locals2.<>9__24) == null)
						{
							選択yAct = (CS$<>8__locals2.<>9__24 = delegate(But te)
							{
								CS$<>8__locals2.yes = true;
								Sou.操作.Play();
								Mods.ヴィオラ.表情_基本1眉上();
								Mods.ヴィオラ吹出し.Text = tex.え;
								Mods.ip.Text = tex.点6;
								Mods.ip.SubInfo = tex.あなたは答える;
								if (CS$<>8__locals2.i == 2)
								{
									int num = CS$<>8__locals2.i;
									CS$<>8__locals2.i = num + 1;
									CS$<>8__locals2.wi = CS$<>8__locals2.i;
								}
								if (CS$<>8__locals2.wi == 2)
								{
									int num = CS$<>8__locals2.wi;
									CS$<>8__locals2.wi = num + 1;
								}
								Mods.ip.選択肢表示 = false;
							});
						}
						情報パネル.選択yAct = 選択yAct;
						情報パネル 情報パネル2 = Mods.ip;
						Action<But> 選択nAct;
						if ((選択nAct = CS$<>8__locals2.<>9__25) == null)
						{
							選択nAct = (CS$<>8__locals2.<>9__25 = delegate(But te)
							{
								CS$<>8__locals2.yes = false;
								Sou.操作.Play();
								Mods.ヴィオラ.表情_不敵0();
								Mods.ヴィオラ吹出し.Text = tex.うふふそうよね;
								Mods.ip.Text = tex.点6;
								Mods.ip.SubInfo = tex.あなたは答える;
								if (CS$<>8__locals2.i == 2)
								{
									int num = CS$<>8__locals2.i;
									CS$<>8__locals2.i = num + 1;
									CS$<>8__locals2.wi = CS$<>8__locals2.i;
								}
								if (CS$<>8__locals2.wi == 2)
								{
									int num = CS$<>8__locals2.wi;
									CS$<>8__locals2.wi = num + 1;
								}
								Mods.ip.選択肢表示 = false;
							});
						}
						情報パネル2.選択nAct = 選択nAct;
						Mods.ip.選択肢表示 = true;
					});
				}
				mai.Done = done;
				Mods.ip.Text = tex.家に帰る;
			};
			mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				Mods.ip.DownB(ref hc);
				if (!Mods.ヴィオラ吹出し.Tex.IsPlaing && !Mods.ip.Mai.IsPlaing && !Mods.ip.Sub.IsPlaing)
				{
					if (CS$<>8__locals2.wi == CS$<>8__locals2.i && CS$<>8__locals2.i != 2 && Mods.ヴィオラ吹出し.Tex.Done == null)
					{
						int i = CS$<>8__locals2.i;
						CS$<>8__locals2.i = i + 1;
						CS$<>8__locals2.wi = CS$<>8__locals2.i;
						if (CS$<>8__locals2.i >= CS$<>8__locals2.tsp.Length)
						{
							Sta.GameData.初事務所フラグ = false;
							CS$<>8__locals2.CS$<>8__locals1.Med.映転("事務所", Mods.描画バッファ, Mods.事務所描画);
							return;
						}
						if (CS$<>8__locals2.i == 2)
						{
							Mods.ヴィオラ吹出し.Tex.Done = CS$<>8__locals2.d1;
						}
						else
						{
							Mods.ヴィオラ吹出し.Tex.Done = null;
						}
						if (CS$<>8__locals2.i != 3)
						{
							if (CS$<>8__locals2.i < 4)
							{
								CS$<>8__locals2.sfc[CS$<>8__locals2.i]();
								Mods.ヴィオラ吹出し.Text = CS$<>8__locals2.tsc[CS$<>8__locals2.i];
								Mods.ip.SubInfo = CS$<>8__locals2.sub[CS$<>8__locals2.i];
							}
							else if (CS$<>8__locals2.yes)
							{
								CS$<>8__locals2.sfcy[CS$<>8__locals2.i - 4]();
								Mods.ヴィオラ吹出し.Text = CS$<>8__locals2.tscy[CS$<>8__locals2.i - 4];
								Mods.ip.SubInfo = CS$<>8__locals2.suby[CS$<>8__locals2.i - 4];
							}
							else
							{
								CS$<>8__locals2.sfcn[CS$<>8__locals2.i - 4]();
								Mods.ヴィオラ吹出し.Text = CS$<>8__locals2.tscn[CS$<>8__locals2.i - 4];
								Mods.ip.SubInfo = CS$<>8__locals2.subn[CS$<>8__locals2.i - 4];
							}
							Mods.ip.Text = CS$<>8__locals2.tsp[CS$<>8__locals2.i];
							return;
						}
					}
					else if (CS$<>8__locals2.wi == 4 && CS$<>8__locals2.i == 3)
					{
						CS$<>8__locals2.i += 2;
						CS$<>8__locals2.wi = CS$<>8__locals2.i;
						if (CS$<>8__locals2.i < 4)
						{
							CS$<>8__locals2.sfc[CS$<>8__locals2.i]();
							Mods.ヴィオラ吹出し.Text = CS$<>8__locals2.tsc[CS$<>8__locals2.i];
							Mods.ip.SubInfo = CS$<>8__locals2.sub[CS$<>8__locals2.i];
						}
						else if (CS$<>8__locals2.yes)
						{
							CS$<>8__locals2.sfcy[CS$<>8__locals2.i - 4]();
							Mods.ヴィオラ吹出し.Text = CS$<>8__locals2.tscy[CS$<>8__locals2.i - 4];
							Mods.ip.SubInfo = CS$<>8__locals2.suby[CS$<>8__locals2.i - 4];
						}
						else
						{
							CS$<>8__locals2.sfcn[CS$<>8__locals2.i - 4]();
							Mods.ヴィオラ吹出し.Text = CS$<>8__locals2.tscn[CS$<>8__locals2.i - 4];
							Mods.ip.SubInfo = CS$<>8__locals2.subn[CS$<>8__locals2.i - 4];
						}
						Mods.ip.Text = CS$<>8__locals2.tsp[CS$<>8__locals2.i];
					}
				}
			};
			mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				Mods.ip.Up(ref hc);
			};
			mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				Mods.ip.Move(ref hc);
			};
			mod.Leave = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
			};
			mod.Wheel = delegate(MouseButtons mb, Vector2D cp, int dt, Color hc)
			{
			};
			mod.Setting = delegate()
			{
				Mods.ip.UpdateSub2();
				Mods.ip.MaiShow = true;
				Mods.ip.Mai.Feed.Dra = false;
				Mods.ip.Mai2Show = false;
				Mods.ip.SubShow = true;
				Mods.ip.Sub2Show = true;
				Mods.ヴィオラ吹出し.Tex.Feed.Dra = true;
				Mods.ヴィオラ.両目_見つめ();
				Mods.ヴィオラ.表情_基本0();
				Mods.ヴィオラ.Set基本姿勢();
				CS$<>8__locals2.i = 0;
				CS$<>8__locals2.wi = 0;
				CS$<>8__locals2.sfc[CS$<>8__locals2.i]();
				Mods.ヴィオラ吹出し.Text = CS$<>8__locals2.tsc[CS$<>8__locals2.i];
				Mods.ip.Text = CS$<>8__locals2.tsp[CS$<>8__locals2.i];
				Mods.ip.SubInfo = CS$<>8__locals2.sub[CS$<>8__locals2.i];
			};
			mod.Draw = delegate(FPS FPS)
			{
				Mods.映転(CS$<>8__locals2.CS$<>8__locals1.Med, Mods.描画バッファ, FPS, Mods.返済イベント描画);
			};
			mod.Dispose = delegate()
			{
			};
			return mod;
		}

		public static Mod ヴィオラ祝福(Med Med)
		{
			Mods.<>c__DisplayClass113_0 CS$<>8__locals1 = new Mods.<>c__DisplayClass113_0();
			CS$<>8__locals1.Med = Med;
			Mod mod = new Mod();
			Mods.<>c__DisplayClass113_1 CS$<>8__locals2 = new Mods.<>c__DisplayClass113_1();
			CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
			CS$<>8__locals2.i = 0;
			CS$<>8__locals2.wi = 0;
			Mods.<>c__DisplayClass113_1 CS$<>8__locals3 = CS$<>8__locals2;
			Action[] array = new Action[4];
			array[0] = delegate()
			{
				Mods.ヴィオラ.表情_基本0();
			};
			array[1] = delegate()
			{
				Mods.ヴィオラ.表情_不敵1眉上();
			};
			array[2] = delegate()
			{
				Mods.ヴィオラ.表情_不敵0();
			};
			array[3] = delegate()
			{
				Sou.祝福.Play();
				Mods.ヴィオラ.表情_不敵0眉上();
			};
			CS$<>8__locals3.sfc = array;
			CS$<>8__locals2.tsc = new string[]
			{
				tex.祝福してほしいの,
				tex.そうよね + "\r\n" + tex.あなたはがんばったもの,
				tex.ちゅっ,
				tex.うふふ
			};
			CS$<>8__locals2.tsp = new string[]
			{
				tex.点3,
				tex.点6,
				tex.エクス1,
				tex.点3
			};
			CS$<>8__locals2.sub = new string[]
			{
				tex.ヴィオラに頼む,
				tex.ヴィオラは微笑む,
				tex.キスされる,
				tex.ヴィオラに祝福された
			};
			mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				Mods.ip.DownB(ref hc);
				if (!Mods.ヴィオラ吹出し.Tex.IsPlaing && !Mods.ip.Mai.IsPlaing && !Mods.ip.Sub.IsPlaing && CS$<>8__locals2.wi == CS$<>8__locals2.i)
				{
					int i = CS$<>8__locals2.i;
					CS$<>8__locals2.i = i + 1;
					CS$<>8__locals2.wi = CS$<>8__locals2.i;
					if (CS$<>8__locals2.i < CS$<>8__locals2.tsp.Length)
					{
						CS$<>8__locals2.sfc[CS$<>8__locals2.i]();
						Mods.ヴィオラ吹出し.Text = CS$<>8__locals2.tsc[CS$<>8__locals2.i];
						Mods.ip.Text = CS$<>8__locals2.tsp[CS$<>8__locals2.i];
						Mods.ip.SubInfo = CS$<>8__locals2.sub[CS$<>8__locals2.i];
						return;
					}
					CS$<>8__locals2.CS$<>8__locals1.Med.映転("事務所", Mods.描画バッファ, Mods.事務所描画);
				}
			};
			mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				Mods.ip.Up(ref hc);
			};
			mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				Mods.ip.Move(ref hc);
			};
			mod.Leave = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
			};
			mod.Wheel = delegate(MouseButtons mb, Vector2D cp, int dt, Color hc)
			{
			};
			mod.Setting = delegate()
			{
				Mods.ip.UpdateSub2();
				Mods.ip.MaiShow = true;
				Mods.ip.Mai.Feed.Dra = false;
				Mods.ip.Mai2Show = false;
				Mods.ip.SubShow = true;
				Mods.ip.Sub2Show = true;
				Mods.ヴィオラ吹出し.Tex.Feed.Dra = true;
				Mods.ヴィオラ.両目_見つめ();
				Mods.ヴィオラ.表情_基本0();
				Mods.ヴィオラ.Set基本姿勢();
				CS$<>8__locals2.i = 0;
				CS$<>8__locals2.wi = 0;
				CS$<>8__locals2.sfc[CS$<>8__locals2.i]();
				Mods.ヴィオラ吹出し.Text = CS$<>8__locals2.tsc[CS$<>8__locals2.i];
				Mods.ip.Text = CS$<>8__locals2.tsp[CS$<>8__locals2.i];
				Mods.ip.SubInfo = CS$<>8__locals2.sub[CS$<>8__locals2.i];
				Sta.GameData.祝福 = Sta.GameData.ヴィオラ;
			};
			mod.Draw = delegate(FPS FPS)
			{
				Mods.映転(CS$<>8__locals2.CS$<>8__locals1.Med, Mods.描画バッファ, FPS, Mods.返済イベント描画);
			};
			mod.Dispose = delegate()
			{
			};
			return mod;
		}

		public static void CompleteDataCreate()
		{
			Task.Factory.StartNew(delegate()
			{
				Sta.GameData.所持金 = 9999999999999UL;
				foreach (Unit unit in Generator.EnumAllMonster())
				{
					Sta.GameData.Add地下室(unit);
				}
				foreach (Unit unit2 in Sta.GameData.地下室)
				{
					if (unit2 != null)
					{
						foreach (接触 key in unit2.ChaD.部位感度.Keys.ToArray<接触>())
						{
							unit2.ChaD.部位感度[key] = 1.0;
						}
						unit2.ChaD.抵抗値 = 0.0;
						unit2.ChaD.欲望度 = 1.0;
						unit2.ChaD.情愛度 = 1.0;
						unit2.ChaD.卑屈度 = 1.0;
						unit2.ChaD.技巧度 = unit2.技巧最大値;
						unit2.ChaD.放尿経験値 = 1.0;
					}
				}
				"完了".ToConsole();
			});
		}

		public static void SensesButton()
		{
			double x = 0.6;
			double y = 0.9075;
			if (Program.biggerWindow)
			{
				x = 0.695;
				y = 0.932;
			}
			ParT parT = new ParT();
			parT.Font = new Font("MS Gothic", 0.1f);
			parT.PositionBase = Mods.描画バッファ.GetPosition(x, y);
			parT.Text = "Senses";
			parT.FontSize = 0.14;
			parT.SizeBase = 0.05;
			parT.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT.OP.ScalingXY(parT.OP.GetCenter(), 0.87, 0.23);
			parT.Closed = true;
			parT.TextColor = Col.White;
			parT.BrushColor = Color.FromArgb(160, Col.Black);
			parT.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT.StringFormat.Alignment = StringAlignment.Center;
			parT.StringFormat.LineAlignment = StringAlignment.Center;
			Mods.dbs.Add("Senses", new But1(parT, delegate(But a)
			{
				Sou.操作.Play();
				Injected.showSenses = !Injected.showSenses;
			}));
		}

		public static void ToJsonButton(Med med)
		{
			double x = 0.6;
			double y = 0.9075;
			if (Program.biggerWindow)
			{
				x = 0.695;
				y = 0.932;
				if (Sta.SensesButton)
				{
					x = 0.62;
				}
			}
			if (!Program.biggerWindow && Sta.SensesButton)
			{
				x = 0.5;
			}
			ParT parT = new ParT();
			parT.Font = new Font("MS Gothic", 0.1f);
			parT.PositionBase = Mods.描画バッファ.GetPosition(x, y);
			parT.Text = "SaveJSON";
			parT.FontSize = 0.14;
			parT.SizeBase = 0.05;
			parT.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT.OP.ScalingXY(parT.OP.GetCenter(), 0.87, 0.23);
			parT.Closed = true;
			parT.TextColor = Col.White;
			parT.BrushColor = Color.FromArgb(160, Col.Black);
			parT.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT.StringFormat.Alignment = StringAlignment.Center;
			parT.StringFormat.LineAlignment = StringAlignment.Center;
			Mods.dbs.Add("SaveJSON", new But1(parT, delegate(But a)
			{
				Sou.操作.Play();
				Mods.セ\u30FCブデ\u30FCタ.bs["0"].Dra = false;
				Mods.save = true;
				Mods.SetJSLlv(med);
				Color empty = Col.Empty;
				Mods.セ\u30FCブデ\u30FCタ.Move(ref empty);
				Mods.SDShow = true;
				Mods.ip.SubInfoIm = "RCl:" + tex.戻る;
			}));
		}

		public static void UnJsonButton(Med med)
		{
			double y = 0.9075;
			double x = 0.5;
			if (Program.biggerWindow)
			{
				x = 0.62;
				y = 0.932;
				if (Sta.SensesButton)
				{
					x = 0.545;
				}
			}
			if (!Program.biggerWindow && Sta.SensesButton)
			{
				x = 0.4;
			}
			ParT parT = new ParT();
			parT.Font = new Font("MS Gothic", 0.1f);
			parT.PositionBase = Mods.描画バッファ.GetPosition(x, y);
			parT.Text = "LoadJSON";
			parT.FontSize = 0.14;
			parT.SizeBase = 0.05;
			parT.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT.OP.ScalingXY(parT.OP.GetCenter(), 0.87, 0.23);
			parT.Closed = true;
			parT.TextColor = Col.White;
			parT.BrushColor = Color.FromArgb(160, Col.Black);
			parT.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT.StringFormat.Alignment = StringAlignment.Center;
			parT.StringFormat.LineAlignment = StringAlignment.Center;
			Mods.dbs.Add("LoadJSON", new But1(parT, delegate(But a)
			{
				Sou.操作.Play();
				Mods.セ\u30FCブデ\u30FCタ.bs["0"].Dra = true;
				Mods.save = false;
				Mods.title = false;
				Mods.SetJSLlv(med);
				Color empty = Col.Empty;
				Mods.セ\u30FCブデ\u30FCタ.Move(ref empty);
				Mods.SDShow = true;
				Mods.ip.SubInfoIm = "RCl:" + tex.戻る;
			}));
		}

		public static void NewButtons(Med med)
		{
			if (Sta.SensesButton)
			{
				Mods.SensesButton();
			}
			if (Sta.JsonButton)
			{
				Mods.ToJsonButton(med);
				Mods.UnJsonButton(med);
			}
			if (Sta.EditorButton)
			{
				Mods.EditorButton();
			}
		}

		public static void SetJSLlv(Med med)
		{
			Mods.セ\u30FCブデ\u30FCタ.Acts = Mods.jsllv(med);
		}

		private static IEnumerable<TA> jsllv(Med med)
		{
			int k = 0;
			string[] array = Sta.JSDPaths();
			int num2;
			for (int j = 0; j < array.Length; j = num2 + 1)
			{
				string path2 = array[j];
				string path = path2;
				int i = k;
				bool f = path == null;
				yield return new TA(f ? (i + ": No data") : Path.GetFileNameWithoutExtension(path).Replace("：", ":").Replace("_", "/"), delegate(But b)
				{
					if (!Mods.processing)
					{
						Sou.操作.Play();
						if (Mods.save)
						{
							Mods.processing = true;
							Mods.JsonSave(path, i, med);
							return;
						}
						if (!f)
						{
							Mods.processing = true;
							Mods.JsonLoad(path, i, med);
						}
					}
				});
				int num = k;
				k = num + 1;
				num2 = j;
			}
			array = null;
			yield break;
		}

		private static void JsonSave(string Path, int i, Med med)
		{
			Mods.ip.SubInfoIm = tex.セ\u30FCブ中です + "\r\n" + tex.しばらくお待ちください;
			Task.Factory.StartNew(delegate()
			{
				if (Path != null)
				{
					FileSystem.DeleteFile(Path);
				}
				Sta.GDSaveJson(i);
				Mods.SetJSLlv(med);
				Mods.SDShow = false;
				Mods.ip.SubInfoIm = string.Concat(new object[]
				{
					i,
					": ",
					Sta.GameData.GetSaveDateString(),
					"\r\n",
					tex.セ\u30FCブしました
				});
				Mods.processing = false;
				Sou.完了.Play();
			});
		}

		private static void JsonLoad(string Path, int i, Med med)
		{
			Mods.cts.Cancel();
			Mods.ip.SubInfoIm = tex.ロ\u30FCド中です + "\r\n" + tex.しばらくお待ちください;
			Task.Factory.StartNew(delegate()
			{
				Sta.DontScar = true;
				if (Sta.TranslateJson)
				{
					string path = Sta.Translate(Path, 1);
					Sta.GameData = Ser.UnJson<GameState>(path);
					File.Delete(path);
				}
				else
				{
					Sta.GameData = Ser.UnJson<GameState>(Path);
				}
				Sta.DontScar = false;
				Cha d = Mods.ヴィオラ;
				Mods.ヴィオラ = new Cha(med, Mods.描画バッファ, Sta.GameData.ヴィオラ.ChaD);
				Mods.ヴィオラ.Set衣装(Sta.GameData.ヴィオラ.着衣);
				Mods.ヴィオラ吹出し.接続(Mods.ヴィオラ.Bod.頭.口_接続点);
				med.InvokeL(delegate
				{
					Mods.初期化処理();
					if (d != null)
					{
						d.Dispose();
					}
					if (Mods.調教対象 != null)
					{
						Mods.調教対象.Dispose();
						Mods.調教対象 = null;
					}
					Mods.SDShow = false;
					if (Mods.title)
					{
						med.映転("メインフォーム", Mods.描画バッファ, Mods.メインフォ\u30FCム描画);
					}
					else
					{
						med.Mode = "メインフォーム";
						Mods.ip.SubInfoIm = string.Concat(new object[]
						{
							i,
							": ",
							Sta.GameData.GetSaveDateString(),
							"\r\n",
							tex.ロ\u30FCドしました
						});
					}
					Mods.processing = false;
					Mods.Set需給最大幅();
					if (Sta.GameData.地下室.Length < Mods.最大部屋数)
					{
						Unit[] array = new Unit[Mods.最大部屋数];
						Array.Copy(Sta.GameData.地下室, array, Sta.GameData.地下室.Length);
						Sta.GameData.地下室 = array;
					}
					Sta.GameData.Gen = new Generator[9];
					Sta.GameData.GenInstance();
					Sou.完了.Play();
				});
			});
		}

		public static void MoveRoomDown()
		{
			if (Sta.GameData.調教対象 == null)
			{
				return;
			}
			int num = int.Parse(Sta.GameData.調教対象.Number) - 1;
			if (Sta.GameData.地下室[num + 1] == null)
			{
				return;
			}
			Unit unit = Sta.GameData.地下室[num];
			Unit unit2 = Sta.GameData.地下室[num + 1];
			int[] array = new int[]
			{
				int.Parse(unit.Number),
				unit.階層位置,
				unit.部屋位置
			};
			unit.Number = unit2.Number;
			unit.階層位置 = unit2.階層位置;
			unit.部屋位置 = unit2.部屋位置;
			unit2.Number = array[0].ToString().PadLeft(3, '0');
			unit2.階層位置 = array[1];
			unit2.部屋位置 = array[2];
			Sta.GameData.地下室[num] = unit2;
			Sta.GameData.地下室[num + 1] = unit;
			Sta.GameData.調教対象 = Sta.GameData.地下室[num + 1];
		}

		public static void MoveRoomUp()
		{
			if (Sta.GameData.調教対象 == null)
			{
				return;
			}
			int num = int.Parse(Sta.GameData.調教対象.Number) - 1;
			if (num == 0 || Sta.GameData.地下室[num - 1] == null)
			{
				return;
			}
			Unit unit = Sta.GameData.地下室[num];
			Unit unit2 = Sta.GameData.地下室[num - 1];
			int[] array = new int[]
			{
				int.Parse(unit.Number),
				unit.階層位置,
				unit.部屋位置
			};
			unit.Number = unit2.Number;
			unit.階層位置 = unit2.階層位置;
			unit.部屋位置 = unit2.部屋位置;
			unit2.Number = array[0].ToString().PadLeft(3, '0');
			unit2.階層位置 = array[1];
			unit2.部屋位置 = array[2];
			Sta.GameData.地下室[num] = unit2;
			Sta.GameData.地下室[num - 1] = unit;
			Sta.GameData.調教対象 = Sta.GameData.地下室[num - 1];
		}

		public static void MoveFloorDown()
		{
			if (Sta.GameData.調教対象 == null)
			{
				return;
			}
			for (int i = 0; i < 15; i++)
			{
				int num = int.Parse(Sta.GameData.調教対象.Number) - 1;
				if (Sta.GameData.地下室[num + 1] == null)
				{
					return;
				}
				Unit unit = Sta.GameData.地下室[num];
				Unit unit2 = Sta.GameData.地下室[num + 1];
				int[] array = new int[]
				{
					int.Parse(unit.Number),
					unit.階層位置,
					unit.部屋位置
				};
				unit.Number = unit2.Number;
				unit.階層位置 = unit2.階層位置;
				unit.部屋位置 = unit2.部屋位置;
				unit2.Number = array[0].ToString().PadLeft(3, '0');
				unit2.階層位置 = array[1];
				unit2.部屋位置 = array[2];
				Sta.GameData.地下室[num] = unit2;
				Sta.GameData.地下室[num + 1] = unit;
				Sta.GameData.調教対象 = Sta.GameData.地下室[num + 1];
			}
		}

		public static void MoveFloorUp()
		{
			if (Sta.GameData.調教対象 == null)
			{
				return;
			}
			for (int i = 0; i < 15; i++)
			{
				int num = int.Parse(Sta.GameData.調教対象.Number) - 1;
				if (num == 0 || Sta.GameData.地下室[num - 1] == null)
				{
					return;
				}
				Unit unit = Sta.GameData.地下室[num];
				Unit unit2 = Sta.GameData.地下室[num - 1];
				int[] array = new int[]
				{
					int.Parse(unit.Number),
					unit.階層位置,
					unit.部屋位置
				};
				unit.Number = unit2.Number;
				unit.階層位置 = unit2.階層位置;
				unit.部屋位置 = unit2.部屋位置;
				unit2.Number = array[0].ToString().PadLeft(3, '0');
				unit2.階層位置 = array[1];
				unit2.部屋位置 = array[2];
				Sta.GameData.地下室[num] = unit2;
				Sta.GameData.地下室[num - 1] = unit;
				Sta.GameData.調教対象 = Sta.GameData.地下室[num - 1];
			}
		}

		public static But MoveRoomDownButton(Mod mod)
		{
			double x = 0.195;
			double y = 0.1625;
			if (Program.biggerWindow)
			{
				x = 0.146;
				y = 0.14;
			}
			double sizeBase = 0.05;
			if (Sta.BigWindow && !Sta.NoScaling)
			{
				sizeBase = 0.068;
				x = 0.194;
				y = 0.155;
			}
			ParT parT = new ParT();
			parT.Font = new Font("MS Gothic", 0.1f);
			parT.PositionBase = Mods.描画バッファ.GetPosition(x, y);
			parT.Text = "Room ▼";
			parT.FontSize = 0.14;
			parT.SizeBase = sizeBase;
			parT.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT.OP.ScalingXY(parT.OP.GetCenter(), 0.87, 0.23);
			parT.Closed = true;
			parT.TextColor = Col.White;
			parT.BrushColor = Color.FromArgb(160, Col.Black);
			parT.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT.StringFormat.Alignment = StringAlignment.Center;
			parT.StringFormat.LineAlignment = StringAlignment.Center;
			return new But1(parT, delegate(But a)
			{
				Sou.操作.Play();
				Mods.MoveRoomDown();
				mod.Setting();
				if (Sta.AlwaysUseName)
				{
					Mods.npl.Text = tex.収容番号 + Sta.GameData.調教対象.Number + "\r\n" + Sta.GameData.調教対象.Name;
					return;
				}
				Mods.npl.Text = tex.収容番号 + Sta.GameData.調教対象.Number + (Sta.GameData.調教対象.調教済フラグ ? ("\r\n" + Sta.GameData.調教対象.Name) : ("\r\n" + Sta.GameData.調教対象.種族));
			});
		}

		public static But MoveRoomUpButton(Mod mod)
		{
			double x = 0.195;
			double y = 0.12;
			if (Program.biggerWindow)
			{
				x = 0.146;
				y = 0.11;
			}
			double sizeBase = 0.05;
			if (Sta.BigWindow && !Sta.NoScaling)
			{
				sizeBase = 0.068;
				x = 0.194;
				y = 0.115;
			}
			ParT parT = new ParT();
			parT.Font = new Font("MS Gothic", 0.1f);
			parT.PositionBase = Mods.描画バッファ.GetPosition(x, y);
			parT.Text = "Room ▲";
			parT.FontSize = 0.14;
			parT.SizeBase = sizeBase;
			parT.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT.OP.ScalingXY(parT.OP.GetCenter(), 0.87, 0.23);
			parT.Closed = true;
			parT.TextColor = Col.White;
			parT.BrushColor = Color.FromArgb(160, Col.Black);
			parT.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT.StringFormat.Alignment = StringAlignment.Center;
			parT.StringFormat.LineAlignment = StringAlignment.Center;
			return new But1(parT, delegate(But a)
			{
				Sou.操作.Play();
				Mods.MoveRoomUp();
				mod.Setting();
				if (Sta.AlwaysUseName)
				{
					Mods.npl.Text = tex.収容番号 + Sta.GameData.調教対象.Number + "\r\n" + Sta.GameData.調教対象.Name;
					return;
				}
				Mods.npl.Text = tex.収容番号 + Sta.GameData.調教対象.Number + (Sta.GameData.調教対象.調教済フラグ ? ("\r\n" + Sta.GameData.調教対象.Name) : ("\r\n" + Sta.GameData.調教対象.種族));
			});
		}

		public static But MoveFloorDownButton(Mod mod)
		{
			double x = 0.195;
			double y = 0.2475;
			if (Program.biggerWindow)
			{
				x = 0.146;
				y = 0.2;
			}
			double sizeBase = 0.05;
			if (Sta.BigWindow && !Sta.NoScaling)
			{
				sizeBase = 0.068;
				x = 0.194;
				y = 0.235;
			}
			ParT parT = new ParT();
			parT.Font = new Font("MS Gothic", 0.1f);
			parT.PositionBase = Mods.描画バッファ.GetPosition(x, y);
			parT.Text = "Floor ▼";
			parT.FontSize = 0.14;
			parT.SizeBase = sizeBase;
			parT.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT.OP.ScalingXY(parT.OP.GetCenter(), 0.87, 0.23);
			parT.Closed = true;
			parT.TextColor = Col.White;
			parT.BrushColor = Color.FromArgb(160, Col.Black);
			parT.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT.StringFormat.Alignment = StringAlignment.Center;
			parT.StringFormat.LineAlignment = StringAlignment.Center;
			return new But1(parT, delegate(But a)
			{
				Sou.操作.Play();
				Mods.MoveFloorDown();
				mod.Setting();
				if (Sta.AlwaysUseName)
				{
					Mods.npl.Text = tex.収容番号 + Sta.GameData.調教対象.Number + "\r\n" + Sta.GameData.調教対象.Name;
					return;
				}
				Mods.npl.Text = tex.収容番号 + Sta.GameData.調教対象.Number + (Sta.GameData.調教対象.調教済フラグ ? ("\r\n" + Sta.GameData.調教対象.Name) : ("\r\n" + Sta.GameData.調教対象.種族));
			});
		}

		public static But MoveFloorUpButton(Mod mod)
		{
			double x = 0.195;
			double y = 0.205;
			if (Program.biggerWindow)
			{
				x = 0.146;
				y = 0.17;
			}
			double sizeBase = 0.05;
			if (Sta.BigWindow && !Sta.NoScaling)
			{
				sizeBase = 0.068;
				x = 0.194;
				y = 0.195;
			}
			ParT parT = new ParT();
			parT.Font = new Font("MS Gothic", 0.1f);
			parT.PositionBase = Mods.描画バッファ.GetPosition(x, y);
			parT.Text = "Floor ▲";
			parT.FontSize = 0.14;
			parT.SizeBase = sizeBase;
			parT.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT.OP.ScalingXY(parT.OP.GetCenter(), 0.87, 0.23);
			parT.Closed = true;
			parT.TextColor = Col.White;
			parT.BrushColor = Color.FromArgb(160, Col.Black);
			parT.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT.StringFormat.Alignment = StringAlignment.Center;
			parT.StringFormat.LineAlignment = StringAlignment.Center;
			return new But1(parT, delegate(But a)
			{
				Sou.操作.Play();
				Mods.MoveFloorUp();
				mod.Setting();
				if (Sta.AlwaysUseName)
				{
					Mods.npl.Text = tex.収容番号 + Sta.GameData.調教対象.Number + "\r\n" + Sta.GameData.調教対象.Name;
					return;
				}
				Mods.npl.Text = tex.収容番号 + Sta.GameData.調教対象.Number + (Sta.GameData.調教対象.調教済フラグ ? ("\r\n" + Sta.GameData.調教対象.Name) : ("\r\n" + Sta.GameData.調教対象.種族));
			});
		}

		public static void setName()
		{
			Mods.npl.Text = tex.収容番号 + Sta.GameData.調教対象.Number + "\r\n" + Sta.GameData.調教対象.Name;
		}

		public static void EditorButton()
		{
			double x = 0.098;
			double y = 0.9075;
			if (Program.biggerWindow)
			{
				x = 0.073;
				y = 0.932;
			}
			ParT parT = new ParT();
			parT.Font = new Font("MS Gothic", 0.1f);
			parT.PositionBase = Mods.描画バッファ.GetPosition(x, y);
			parT.Text = "Editor";
			parT.FontSize = 0.14;
			parT.SizeBase = 0.05;
			parT.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			parT.OP.ScalingXY(parT.OP.GetCenter(), 0.87, 0.23);
			parT.Closed = true;
			parT.TextColor = Col.White;
			parT.BrushColor = Color.FromArgb(160, Col.Black);
			parT.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT.StringFormat.Alignment = StringAlignment.Center;
			parT.StringFormat.LineAlignment = StringAlignment.Center;
			Mods.dbs.Add("Editor", new But1(parT, delegate(But a)
			{
				Sou.操作.Play();
				if (MyC.tl != null)
				{
					try
					{
						MyC.Close();
					}
					catch
					{
						MyC.tl = null;
					}
				}
				MyC.Setting();
				MyC.tl.menuGetData.Click += Mods.EditorGet;
				MyC.tl.menuSetData.Click += Mods.EditorSet;
			}));
		}

		public static void EditorGet(object sender, EventArgs e)
		{
			Sou.操作.Play();
			MyC.Text = "My Character";
			MyC.Text += "\r\n      Stats";
			MyC.Text = MyC.Text + "\r\n            Stamina: " + Convert.ToString(Sta.GameData.精力);
			MyC.Text = MyC.Text + "\r\n            Sensitivity: " + Convert.ToString(Sta.GameData.射精);
			MyC.Text = MyC.Text + "\r\n            Excitement: " + Convert.ToString(Sta.GameData.興奮);
			MyC.Text = MyC.Text + "\r\n            SkillLevel: " + Convert.ToString(Sta.GameData.調教力);
			MyC.Text += "\r\n      Appearance";
			MyC.Text = MyC.Text + "\r\n            SkinColor: " + ColorTranslator.ToHtml(Sta.GameData.色.肌色);
			MyC.Text = MyC.Text + "\r\n            HairColor: " + ColorTranslator.ToHtml(Sta.GameData.色.髪色);
			MyC.Text = MyC.Text + "\r\n            EyeColor: " + ColorTranslator.ToHtml(Sta.GameData.色.瞳色);
			MyC.Text = MyC.Text + "\r\n            BloodColor: " + ColorTranslator.ToHtml(Sta.GameData.色.血液);
			MyC.Text = MyC.Text + "\r\n            TattooColor: " + ColorTranslator.ToHtml(Sta.GameData.色.刺青);
			MyC.Text = MyC.Text + "\r\n            SemenColor: " + ColorTranslator.ToHtml(Sta.GameData.色.精液);
			MyC.Text = MyC.Text + "\r\n            Height: " + Convert.ToString(Sta.GameData.身長);
			MyC.Text = MyC.Text + "\r\n            Weight: " + Convert.ToString(Sta.GameData.体重);
			if (Sta.GameData.調教対象 != null)
			{
				MyC.Text += "\r\n\r\nCurrent Slave";
				MyC.Text = MyC.Text + "\r\n      Name: " + Sta.GameData.調教対象.Name;
				MyC.Text += "\r\n      Stats";
				MyC.Text = MyC.Text + "\r\n            Stamina: " + Convert.ToString(Sta.GameData.調教対象.ChaD.体力);
				MyC.Text = MyC.Text + "\r\n            Sensitivity: " + Convert.ToString(Sta.GameData.調教対象.ChaD.感度);
				MyC.Text = MyC.Text + "\r\n            Excitement: " + Convert.ToString(Sta.GameData.調教対象.ChaD.興奮);
				MyC.Text = MyC.Text + "\r\n            Wetness: " + Convert.ToString(Sta.GameData.調教対象.ChaD.潤滑);
				MyC.Text = MyC.Text + "\r\n            Tension: " + Convert.ToString(Sta.GameData.調教対象.ChaD.緊張);
				MyC.Text = MyC.Text + "\r\n            Shame: " + Convert.ToString(Sta.GameData.調教対象.ChaD.羞恥);
				MyC.Text = MyC.Text + "\r\n            Pride: " + Convert.ToString(Sta.GameData.調教対象.ChaD.抵抗値);
				MyC.Text = MyC.Text + "\r\n            Lust: " + Convert.ToString(Sta.GameData.調教対象.ChaD.欲望度);
				MyC.Text = MyC.Text + "\r\n            Affection: " + Convert.ToString(Sta.GameData.調教対象.ChaD.情愛度);
				MyC.Text = MyC.Text + "\r\n            Taming: " + Convert.ToString(Sta.GameData.調教対象.ChaD.卑屈度);
				MyC.Text = MyC.Text + "\r\n            SkillLevel: " + Convert.ToString(Sta.GameData.調教対象.ChaD.技巧度);
				MyC.Text = MyC.Text + "\r\n            MagicCon: " + Convert.ToString(Sta.GameData.調教対象.ChaD.魔力濃度);
				MyC.Text += "\r\n      Sizes";
				MyC.Text = MyC.Text + "\r\n            Breasts: " + Convert.ToString(Sta.GameData.調教対象.ChaD.最乳房);
				MyC.Text = MyC.Text + "\r\n            Nipples: " + Convert.ToString(Sta.GameData.調教対象.ChaD.最乳首);
				MyC.Text = MyC.Text + "\r\n            Clitoris: " + Convert.ToString(Sta.GameData.調教対象.ChaD.現陰核);
				MyC.Text = MyC.Text + "\r\n            Vagina: " + Convert.ToString(Sta.GameData.調教対象.ChaD.現性器);
				MyC.Text = MyC.Text + "\r\n            Anus: " + Convert.ToString(Sta.GameData.調教対象.ChaD.現肛門);
				MyC.Text += "\r\n      Sensitivities";
				MyC.Text = MyC.Text + "\r\n            Head: " + Convert.ToString(Sta.GameData.調教対象.ChaD.部位感度[接触.頭]);
				MyC.Text = MyC.Text + "\r\n            Face: " + Convert.ToString(Sta.GameData.調教対象.ChaD.部位感度[接触.顔]);
				MyC.Text = MyC.Text + "\r\n            Ear: " + Convert.ToString(Sta.GameData.調教対象.ChaD.部位感度[接触.耳]);
				MyC.Text = MyC.Text + "\r\n            Mouth: " + Convert.ToString(Sta.GameData.調教対象.ChaD.部位感度[接触.口]);
				MyC.Text = MyC.Text + "\r\n            Hair: " + Convert.ToString(Sta.GameData.調教対象.ChaD.部位感度[接触.髪]);
				MyC.Text = MyC.Text + "\r\n            Neck: " + Convert.ToString(Sta.GameData.調教対象.ChaD.部位感度[接触.首]);
				MyC.Text = MyC.Text + "\r\n            Shoulder: " + Convert.ToString(Sta.GameData.調教対象.ChaD.部位感度[接触.肩]);
				MyC.Text = MyC.Text + "\r\n            Breast: " + Convert.ToString(Sta.GameData.調教対象.ChaD.部位感度[接触.胸]);
				MyC.Text = MyC.Text + "\r\n            Nipple: " + Convert.ToString(Sta.GameData.調教対象.ChaD.部位感度[接触.乳]);
				MyC.Text = MyC.Text + "\r\n            Armpit: " + Convert.ToString(Sta.GameData.調教対象.ChaD.部位感度[接触.脇]);
				MyC.Text = MyC.Text + "\r\n            Belly: " + Convert.ToString(Sta.GameData.調教対象.ChaD.部位感度[接触.腹]);
				MyC.Text = MyC.Text + "\r\n            Crotch: " + Convert.ToString(Sta.GameData.調教対象.ChaD.部位感度[接触.股]);
				MyC.Text = MyC.Text + "\r\n            Sex: " + Convert.ToString(Sta.GameData.調教対象.ChaD.部位感度[接触.性]);
				MyC.Text = MyC.Text + "\r\n            Vagina: " + Convert.ToString(Sta.GameData.調教対象.ChaD.部位感度[接触.膣]);
				MyC.Text = MyC.Text + "\r\n            Clitoris: " + Convert.ToString(Sta.GameData.調教対象.ChaD.部位感度[接触.核]);
				MyC.Text = MyC.Text + "\r\n            Anus: " + Convert.ToString(Sta.GameData.調教対象.ChaD.部位感度[接触.肛]);
				MyC.Text = MyC.Text + "\r\n            Spinneret: " + Convert.ToString(Sta.GameData.調教対象.ChaD.部位感度[接触.糸]);
				MyC.Text = MyC.Text + "\r\n            Thigh: " + Convert.ToString(Sta.GameData.調教対象.ChaD.部位感度[接触.腿]);
				MyC.Text = MyC.Text + "\r\n            Feet: " + Convert.ToString(Sta.GameData.調教対象.ChaD.部位感度[接触.足]);
				MyC.Text = MyC.Text + "\r\n            Hands: " + Convert.ToString(Sta.GameData.調教対象.ChaD.部位感度[接触.手]);
				MyC.Text = MyC.Text + "\r\n            TopEye: " + Convert.ToString(Sta.GameData.調教対象.ChaD.部位感度[接触.覚]);
				MyC.Text = MyC.Text + "\r\n            Tentacle: " + Convert.ToString(Sta.GameData.調教対象.ChaD.部位感度[接触.触]);
				MyC.Text = MyC.Text + "\r\n            Tail: " + Convert.ToString(Sta.GameData.調教対象.ChaD.部位感度[接触.尾]);
				MyC.Text = MyC.Text + "\r\n            Wings: " + Convert.ToString(Sta.GameData.調教対象.ChaD.部位感度[接触.翼]);
				MyC.Text = MyC.Text + "\r\n            Fin: " + Convert.ToString(Sta.GameData.調教対象.ChaD.部位感度[接触.鰭]);
				MyC.Text = MyC.Text + "\r\n            Other: " + Convert.ToString(Sta.GameData.調教対象.ChaD.部位感度[接触.他]);
				MyC.Text += "\r\n      Flags";
				MyC.Text = MyC.Text + "\r\n            Hairless: " + Convert.ToString(Sta.GameData.調教対象.無毛フラグ);
				MyC.Text = MyC.Text + "\r\n            Virgin: " + Convert.ToString(Sta.GameData.調教対象.処女フラグ);
				MyC.Text = MyC.Text + "\r\n            InHeat: " + Convert.ToString(Sta.GameData.調教対象.発情フラグ);
				MyC.Text = MyC.Text + "\r\n            Pregnant: " + Convert.ToString(Sta.GameData.調教対象.妊娠フラグ);
				MyC.Text = MyC.Text + "\r\n            Muscled: " + Convert.ToString(Sta.GameData.調教対象.強靭フラグ);
				MyC.Text = MyC.Text + "\r\n            Wounded: " + Convert.ToString(Sta.GameData.調教対象.傷物フラグ);
				MyC.Text = MyC.Text + "\r\n            Trained: " + Convert.ToString(Sta.GameData.調教対象.調教済フラグ);
			}
			MyC.Text += "\r\n\r\nMoney";
			MyC.Text = MyC.Text + "\r\n      CurrentMoney: " + Convert.ToString(Sta.GameData.所持金);
			MyC.Text = MyC.Text + "\r\n      Debt: " + Convert.ToString(Sta.GameData.借金);
			MyC.Text = MyC.Text + "\r\n      CurrentDayBorrowDebt: " + Convert.ToString(Sta.GameData.日借金額);
			MyC.Text = MyC.Text + "\r\n      Interest: " + Convert.ToString(Sta.GameData.利子);
			MyC.Text = MyC.Text + "\r\n      RepaymentStage: " + Convert.ToString(Sta.GameData.返済段階);
			MyC.Text += "\r\n\r\nTime";
			MyC.Text = MyC.Text + "\r\n      Time: " + Convert.ToString(Sta.GameData.時間);
			MyC.Text = MyC.Text + "\r\n      NewDay: " + Convert.ToString(Sta.GameData.新日);
			MyC.Text += "\r\n\r\nRaces Unlocked";
			MyC.Text = MyC.Text + "\r\n      Avian: " + Convert.ToString(Sta.GameData.系統開放[0]);
			MyC.Text = MyC.Text + "\r\n      Serpent: " + Convert.ToString(Sta.GameData.系統開放[1]);
			MyC.Text = MyC.Text + "\r\n      Beast: " + Convert.ToString(Sta.GameData.系統開放[2]);
			MyC.Text = MyC.Text + "\r\n      Aquatic: " + Convert.ToString(Sta.GameData.系統開放[3]);
			MyC.Text = MyC.Text + "\r\n      Insect: " + Convert.ToString(Sta.GameData.系統開放[4]);
			MyC.Text = MyC.Text + "\r\n      Humanoid: " + Convert.ToString(Sta.GameData.系統開放[5]);
			MyC.Text = MyC.Text + "\r\n      Eidolon: " + Convert.ToString(Sta.GameData.系統開放[6]);
			MyC.Text = MyC.Text + "\r\n      Mythical: " + Convert.ToString(Sta.GameData.系統開放[7]);
			MyC.Text = MyC.Text + "\r\n      Dragon: " + Convert.ToString(Sta.GameData.系統開放[8]);
			MyC.Text += "\r\n\r\nTools Unlocked";
			MyC.Text = MyC.Text + "\r\n      Dildo: " + Convert.ToString(Sta.GameData.購入道具[0]);
			MyC.Text = MyC.Text + "\r\n      Vibrator: " + Convert.ToString(Sta.GameData.購入道具[1]);
			MyC.Text = MyC.Text + "\r\n      DrillVibe: " + Convert.ToString(Sta.GameData.購入道具[2]);
			MyC.Text = MyC.Text + "\r\n      Massager: " + Convert.ToString(Sta.GameData.購入道具[3]);
			MyC.Text = MyC.Text + "\r\n      AnalVibe: " + Convert.ToString(Sta.GameData.購入道具[4]);
			MyC.Text = MyC.Text + "\r\n      Whip: " + Convert.ToString(Sta.GameData.購入道具[5]);
			MyC.Text = MyC.Text + "\r\n      Feather: " + Convert.ToString(Sta.GameData.購入道具[6]);
			MyC.Text = MyC.Text + "\r\n      Razor: " + Convert.ToString(Sta.GameData.購入道具[7]);
			MyC.Text = MyC.Text + "\r\n      Clamps: " + Convert.ToString(Sta.GameData.購入道具[8]);
			MyC.Text = MyC.Text + "\r\n      PinkRotar: " + Convert.ToString(Sta.GameData.購入道具[9]);
			MyC.Text = MyC.Text + "\r\n      AnalBeads: " + Convert.ToString(Sta.GameData.購入道具[10]);
			MyC.Text = MyC.Text + "\r\n      Eyeband: " + Convert.ToString(Sta.GameData.購入道具[11]);
			MyC.Text = MyC.Text + "\r\n      BallGag: " + Convert.ToString(Sta.GameData.購入道具[12]);
			MyC.Text = MyC.Text + "\r\n      Camera: " + Convert.ToString(Sta.GameData.購入道具[13]);
			MyC.Text = MyC.Text + "\r\n      NumberOfFloors: " + Convert.ToString(Sta.GameData.フロア数);
		}

		public static void EditorSet(object sender, EventArgs e)
		{
			Sou.操作.Play();
			Sta.GameData.利子 = Convert.ToDouble(new Regex("Interest\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
			Sta.GameData.日借金額 = Convert.ToUInt64(new Regex("CurrentDayBorrowDebt\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
			Sta.GameData.色.肌色 = ColorTranslator.FromHtml(new Regex("SkinColor\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
			Sta.GameData.色.髪色 = ColorTranslator.FromHtml(new Regex("HairColor\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
			Sta.GameData.色.瞳色 = ColorTranslator.FromHtml(new Regex("EyeColor\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
			Sta.GameData.色.血液 = ColorTranslator.FromHtml(new Regex("BloodColor\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
			Sta.GameData.色.刺青 = ColorTranslator.FromHtml(new Regex("TattooColor\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
			Sta.GameData.色.精液 = ColorTranslator.FromHtml(new Regex("SemenColor\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
			Sta.GameData.身長 = Convert.ToDouble(new Regex("Height\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
			Sta.GameData.体重 = Convert.ToDouble(new Regex("Weight\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
			Sta.GameData.精力 = Convert.ToDouble(new Regex("Stamina\\: ?(.+)").Matches(MyC.Text)[0].Groups[1].Value);
			Sta.GameData.射精 = Convert.ToDouble(new Regex("Sensitivity\\: ?(.+)").Matches(MyC.Text)[0].Groups[1].Value);
			Sta.GameData.興奮 = Convert.ToDouble(new Regex("Excitement\\: ?(.+)").Matches(MyC.Text)[0].Groups[1].Value);
			Sta.GameData.調教力 = Convert.ToDouble(new Regex("SkillLevel\\: ?(.+)").Matches(MyC.Text)[0].Groups[1].Value);
			Sta.GameData.時間 = Convert.ToUInt64(new Regex("Time\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
			Sta.GameData.所持金 = Convert.ToUInt64(new Regex("CurrentMoney\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
			Sta.GameData.借金 = Convert.ToUInt64(new Regex("Debt\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
			Sta.GameData.返済段階 = Convert.ToInt32(new Regex("RepaymentStage\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
			Sta.GameData.系統開放[0] = Convert.ToBoolean(new Regex("Avian\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
			Sta.GameData.系統開放[1] = Convert.ToBoolean(new Regex("Serpent\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
			Sta.GameData.系統開放[2] = Convert.ToBoolean(new Regex("Beast\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
			Sta.GameData.系統開放[3] = Convert.ToBoolean(new Regex("Aquatic\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
			Sta.GameData.系統開放[4] = Convert.ToBoolean(new Regex("Insect\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
			Sta.GameData.系統開放[5] = Convert.ToBoolean(new Regex("Humanoid\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
			Sta.GameData.系統開放[6] = Convert.ToBoolean(new Regex("Eidolon\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
			Sta.GameData.系統開放[7] = Convert.ToBoolean(new Regex("Mythical\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
			Sta.GameData.系統開放[8] = Convert.ToBoolean(new Regex("Dragon\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
			Sta.GameData.購入道具[0] = Convert.ToBoolean(new Regex("Dildo\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
			Sta.GameData.購入道具[1] = Convert.ToBoolean(new Regex("Vibrator\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
			Sta.GameData.購入道具[2] = Convert.ToBoolean(new Regex("DrillVibe\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
			Sta.GameData.購入道具[3] = Convert.ToBoolean(new Regex("Massager\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
			Sta.GameData.購入道具[4] = Convert.ToBoolean(new Regex("AnalVibe\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
			Sta.GameData.購入道具[5] = Convert.ToBoolean(new Regex("Whip\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
			Sta.GameData.購入道具[6] = Convert.ToBoolean(new Regex("Feather\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
			Sta.GameData.購入道具[7] = Convert.ToBoolean(new Regex("Razor\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
			Sta.GameData.購入道具[8] = Convert.ToBoolean(new Regex("Clamps\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
			Sta.GameData.購入道具[9] = Convert.ToBoolean(new Regex("PinkRotar\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
			Sta.GameData.購入道具[10] = Convert.ToBoolean(new Regex("AnalBeads\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
			Sta.GameData.購入道具[11] = Convert.ToBoolean(new Regex("Eyeband\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
			Sta.GameData.購入道具[12] = Convert.ToBoolean(new Regex("BallGag\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
			Sta.GameData.購入道具[13] = Convert.ToBoolean(new Regex("Camera\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
			Sta.GameData.新日 = Convert.ToBoolean(new Regex("NewDay\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
			if (Sta.GameData.調教対象 != null)
			{
				try
				{
					Sta.GameData.調教対象.Name = new Regex("Name\\: ?(.+)").Match(MyC.Text).Groups[1].Value;
					Sta.GameData.調教対象.ChaD.体力 = Convert.ToDouble(new Regex("Stamina\\: ?(.+)").Matches(MyC.Text)[1].Groups[1].Value);
					Sta.GameData.調教対象.ChaD.感度 = Convert.ToDouble(new Regex("Sensitivity\\: ?(.+)").Matches(MyC.Text)[1].Groups[1].Value);
					Sta.GameData.調教対象.ChaD.興奮 = Convert.ToDouble(new Regex("Excitement\\: ?(.+)").Matches(MyC.Text)[1].Groups[1].Value);
					Sta.GameData.調教対象.ChaD.潤滑 = Convert.ToDouble(new Regex("Wetness\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
					Sta.GameData.調教対象.ChaD.緊張 = Convert.ToDouble(new Regex("Tension\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
					Sta.GameData.調教対象.ChaD.羞恥 = Convert.ToDouble(new Regex("Shame\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
					Sta.GameData.調教対象.ChaD.抵抗値 = Convert.ToDouble(new Regex("Pride\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
					Sta.GameData.調教対象.ChaD.欲望度 = Convert.ToDouble(new Regex("Lust\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
					Sta.GameData.調教対象.ChaD.情愛度 = Convert.ToDouble(new Regex("Affection\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
					Sta.GameData.調教対象.ChaD.卑屈度 = Convert.ToDouble(new Regex("Taming\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
					Sta.GameData.調教対象.ChaD.技巧度 = Convert.ToDouble(new Regex("SkillLevel\\: ?(.+)").Matches(MyC.Text)[1].Groups[1].Value);
					Sta.GameData.調教対象.ChaD.魔力濃度 = Convert.ToDouble(new Regex("MagicCon\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
					Sta.GameData.調教対象.ChaD.最乳房 = Convert.ToDouble(new Regex("Breasts\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
					Sta.GameData.調教対象.ChaD.最乳首 = Convert.ToDouble(new Regex("Nipples\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
					Sta.GameData.調教対象.ChaD.現陰核 = Convert.ToDouble(new Regex("Clitoris\\: ?(.+)").Matches(MyC.Text)[0].Groups[1].Value);
					Sta.GameData.調教対象.ChaD.現性器 = Convert.ToDouble(new Regex("Vagina\\: ?(.+)").Matches(MyC.Text)[0].Groups[1].Value);
					Sta.GameData.調教対象.ChaD.現肛門 = Convert.ToDouble(new Regex("Anus\\: ?(.+)").Matches(MyC.Text)[0].Groups[1].Value);
					Sta.GameData.調教対象.ChaD.部位感度[接触.頭] = Convert.ToDouble(new Regex("Head\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
					Sta.GameData.調教対象.ChaD.部位感度[接触.顔] = Convert.ToDouble(new Regex("Face\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
					Sta.GameData.調教対象.ChaD.部位感度[接触.耳] = Convert.ToDouble(new Regex("Ear\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
					Sta.GameData.調教対象.ChaD.部位感度[接触.口] = Convert.ToDouble(new Regex("Mouth\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
					Sta.GameData.調教対象.ChaD.部位感度[接触.髪] = Convert.ToDouble(new Regex("Hair\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
					Sta.GameData.調教対象.ChaD.部位感度[接触.首] = Convert.ToDouble(new Regex("Neck\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
					Sta.GameData.調教対象.ChaD.部位感度[接触.肩] = Convert.ToDouble(new Regex("Shoulder\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
					Sta.GameData.調教対象.ChaD.部位感度[接触.胸] = Convert.ToDouble(new Regex("Breast\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
					Sta.GameData.調教対象.ChaD.部位感度[接触.乳] = Convert.ToDouble(new Regex("Nipple\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
					Sta.GameData.調教対象.ChaD.部位感度[接触.脇] = Convert.ToDouble(new Regex("Armpit\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
					Sta.GameData.調教対象.ChaD.部位感度[接触.腹] = Convert.ToDouble(new Regex("Belly\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
					Sta.GameData.調教対象.ChaD.部位感度[接触.股] = Convert.ToDouble(new Regex("Crotch\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
					Sta.GameData.調教対象.ChaD.部位感度[接触.性] = Convert.ToDouble(new Regex("Sex\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
					Sta.GameData.調教対象.ChaD.部位感度[接触.膣] = Convert.ToDouble(new Regex("Vagina\\: ?(.+)").Matches(MyC.Text)[1].Groups[1].Value);
					Sta.GameData.調教対象.ChaD.部位感度[接触.核] = Convert.ToDouble(new Regex("Clitoris\\: ?(.+)").Matches(MyC.Text)[1].Groups[1].Value);
					Sta.GameData.調教対象.ChaD.部位感度[接触.肛] = Convert.ToDouble(new Regex("Anus\\: ?(.+)").Matches(MyC.Text)[1].Groups[1].Value);
					Sta.GameData.調教対象.ChaD.部位感度[接触.糸] = Convert.ToDouble(new Regex("Spinneret\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
					Sta.GameData.調教対象.ChaD.部位感度[接触.腿] = Convert.ToDouble(new Regex("Thigh\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
					Sta.GameData.調教対象.ChaD.部位感度[接触.足] = Convert.ToDouble(new Regex("Feet\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
					Sta.GameData.調教対象.ChaD.部位感度[接触.手] = Convert.ToDouble(new Regex("Hands\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
					Sta.GameData.調教対象.ChaD.部位感度[接触.覚] = Convert.ToDouble(new Regex("TopEye\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
					Sta.GameData.調教対象.ChaD.部位感度[接触.触] = Convert.ToDouble(new Regex("Tentacle\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
					Sta.GameData.調教対象.ChaD.部位感度[接触.尾] = Convert.ToDouble(new Regex("Tail\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
					Sta.GameData.調教対象.ChaD.部位感度[接触.翼] = Convert.ToDouble(new Regex("Wings\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
					Sta.GameData.調教対象.ChaD.部位感度[接触.鰭] = Convert.ToDouble(new Regex("Fin\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
					Sta.GameData.調教対象.ChaD.部位感度[接触.他] = Convert.ToDouble(new Regex("Other\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
					Sta.GameData.調教対象.無毛フラグ = Convert.ToBoolean(new Regex("Hairless\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
					Sta.GameData.調教対象.処女フラグ = Convert.ToBoolean(new Regex("Virgin\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
					Sta.GameData.調教対象.発情フラグ = Convert.ToBoolean(new Regex("InHeat\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
					Sta.GameData.調教対象.妊娠フラグ = Convert.ToBoolean(new Regex("Pregnant\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
					Sta.GameData.調教対象.強靭フラグ = Convert.ToBoolean(new Regex("Muscled\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
					Sta.GameData.調教対象.傷物フラグ = Convert.ToBoolean(new Regex("Wounded\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
					Sta.GameData.調教対象.調教済フラグ = Convert.ToBoolean(new Regex("Trained\\: ?(.+)").Match(MyC.Text).Groups[1].Value);
				}
				catch
				{
				}
			}
		}

		private static SubInnfo si;

		public static ヴィオラ台詞 ヴィオラ台詞;

		public static キャラ台詞 キャラ台詞;

		private static ListView セ\u30FCブデ\u30FCタ;

		private static 情報パネル ip;

		private static Buts dbs;

		private static Cha 調教対象 = null;

		public static 吹き出し キャラ吹出し;

		private static Cha ヴィオラ;

		public static 吹き出し ヴィオラ吹出し;

		private static Lab npl;

		public static Are 描画バッファ;

		public static Are 黒背景;

		public static Are 地下室背景;

		public static Are 事務室背景;

		public static Are da;

		private static MotV mv = new MotV(0.0, 1.0)
		{
			BaseSpeed = 2.0
		};

		private static bool sta = false;

		private static double v = 0.0;

		private static Action<Are, FPS> メインフォ\u30FCム描画;

		private static Action<Are, FPS> 調教描画;

		public static Action<Are, FPS> 撮影描画;

		private static Action<Are, FPS> 対象描画;

		private static Action<Are, FPS> 祝福描画;

		private static Action<Are, FPS> 事務所描画;

		private static Action<Are, FPS> 借金描画;

		private static Action<Are, FPS> 奴隷描画;

		private static Action<Are, FPS> 道具描画;

		private static Action<Are, FPS> 中継描画;

		private static Action<Are, FPS> OP0描画;

		private static Action<Are, FPS> OP1描画;

		private static Action<Are, FPS> 説明描画;

		private static Action<Are, FPS> 初事務所描画;

		private static Action<Are, FPS> 返済イベント描画;

		private static Action<Are, FPS> 日数進行描画;

		private static Action<Are, FPS> 情報設定描画;

		public const double 初期利子 = 0.002;

		public const ulong 開始借金額 = 5000000000UL;

		public const ulong 日借金上限 = 50000000UL;

		public static ulong 単位返済段階額 = 1666666666UL;

		public const ulong MaxMoney = 9999999999999UL;

		public const ulong MinMoney = 0UL;

		public static double 需給最大幅 = 8.0;

		public static bool SDShow = false;

		public static bool save = false;

		public static bool title = false;

		public static bool processing = false;

		private static Action 対象UI初期化;

		private static Action 奴隷UI初期化;

		private static string[] 日終了ログa = new string[Mods.最大部屋数];

		public static ulong 労働利益 = 0UL;

		public static ulong 日利益額 = 0UL;

		public static ulong 日利子額 = 0UL;

		private const int ml = 19;

		private static bool dayp = false;

		private static CancellationTokenSource cts = new CancellationTokenSource();

		public static Task t1;

		private static bool start = false;

		private const ulong 遺伝情報変更価格 = 10000000UL;

		public const int 最大フロア数 = 9;

		private static bool 調教前調教済みフラグ;

		public const bool v3 = false;

		public const bool 体験版 = false;
	}
}
