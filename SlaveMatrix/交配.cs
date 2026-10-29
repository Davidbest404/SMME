using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public static class 交配
	{
		private static 体色 Mix(体色 母方, 体色 父方, double 変異率, 腰D d)
		{
			体色 体色 = new 体色();
			switch (OthN.XS.Next(4))
			{
			case 0:
				using (IEnumerator<FieldInfo> enumerator = (from e in 交配.体色t.GetFields()
				where e.FieldType.ToString() == Sta.ct
				select e).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						FieldInfo fieldInfo = enumerator.Current;
						fieldInfo.SetValue(体色, OthN.XS.NextBool() ? fieldInfo.GetValue(母方) : fieldInfo.GetValue(父方));
					}
					goto IL_2B5;
				}
				break;
			case 1:
				break;
			case 2:
				goto IL_150;
			default:
				goto IL_1FC;
			}
			using (IEnumerator<FieldInfo> enumerator = (from e in 交配.体色t.GetFields()
			where e.FieldType.ToString() == Sta.ct
			select e).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					FieldInfo fieldInfo2 = enumerator.Current;
					Color color = (Color)fieldInfo2.GetValue(母方);
					Color color2 = (Color)fieldInfo2.GetValue(父方);
					if (!color.IsEmpty && !color2.IsEmpty)
					{
						fieldInfo2.SetValue(体色, Oth.GetInter(ref color, ref color2));
					}
					else
					{
						fieldInfo2.SetValue(体色, color);
					}
				}
				goto IL_2B5;
			}
			IL_150:
			using (IEnumerator<FieldInfo> enumerator = (from e in 交配.体色t.GetFields()
			where e.FieldType.ToString() == Sta.ct
			select e).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					FieldInfo fieldInfo3 = enumerator.Current;
					Color color3 = (Color)fieldInfo3.GetValue(母方);
					Color color4 = (Color)fieldInfo3.GetValue(父方);
					if (!color3.IsEmpty && !color4.IsEmpty)
					{
						fieldInfo3.SetValue(体色, Oth.GetInter(ref color3, ref color4));
					}
					else
					{
						fieldInfo3.SetValue(体色, color4);
					}
				}
				goto IL_2B5;
			}
			IL_1FC:
			foreach (FieldInfo fieldInfo4 in from e in 交配.体色t.GetFields()
			where e.FieldType.ToString() == Sta.ct
			select e)
			{
				Color color5 = (Color)fieldInfo4.GetValue(母方);
				Color color6 = (Color)fieldInfo4.GetValue(父方);
				if (!color5.IsEmpty && !color6.IsEmpty)
				{
					fieldInfo4.SetValue(体色, Oth.GetInter(ref color5, ref color6));
				}
				else
				{
					fieldInfo4.SetValue(体色, OthN.XS.NextBool() ? color5 : color6);
				}
			}
			IL_2B5:
			if (母方.血統.Contains(tex.アルビノ) && 父方.血統.Contains(tex.アルビノ))
			{
				体色.血統.Add(tex.アルビノ);
			}
			else if (母方.血統.Contains(tex.メラニス) && 父方.血統.Contains(tex.メラニス))
			{
				体色.血統.Add(tex.メラニス);
			}
			else if (母方.血統.Any((string e) => e.StartsWith(tex.ルチノ\u30FC)))
			{
				if (父方.血統.Any((string e) => e.StartsWith(tex.ルチノ\u30FC)))
				{
					string text = 母方.血統.First((string e) => e.StartsWith(tex.ルチノ\u30FC));
					string text2 = 父方.血統.First((string e) => e.StartsWith(tex.ルチノ\u30FC));
					if (text == text2)
					{
						体色.血統.Add(text);
					}
					else
					{
						double rutinohWeight = text.GetRutinohWeight();
						double rutinohWeight2 = text2.GetRutinohWeight();
						if (rutinohWeight < rutinohWeight2)
						{
							体色.血統.Add(text);
						}
						else if (rutinohWeight > rutinohWeight2)
						{
							体色.血統.Add(text2);
						}
						else
						{
							体色.血統.Add(OthN.XS.NextBool() ? text : text2);
						}
					}
				}
			}
			if (変異率.Lot())
			{
				double[] array = new double[]
				{
					1.0,
					2.0,
					8.0,
					0.0
				};
				array[3] = 500.0 * ((Sta.GameData.祝福 != null && Sta.GameData.祝福.種族 == tex.カ\u30FCバンクル) ? 0.5 : 1.0);
				switch (Oth.GetRandomIndex(array))
				{
				case 0:
					if (!体色.血統.Contains(tex.アルビノ))
					{
						foreach (FieldInfo fieldInfo5 in from e in 交配.体色t.GetFields()
						where 体色.変異色.Contains(e.Name) && e.FieldType.ToString() == Sta.ct
						select e)
						{
							Color color7 = (Color)fieldInfo5.GetValue(体色);
							if (color7 != Col.Empty)
							{
								if (fieldInfo5.Name == "人肌")
								{
									color7 = Color.FromArgb((int)color7.A, 255, 255, 255);
									Col.GetLimitSkin(ref color7, out color7);
									fieldInfo5.SetValue(体色, color7);
								}
								else if (fieldInfo5.Name.Contains("目") || fieldInfo5.Name.Contains("眼") || fieldInfo5.Name.Contains("秘石") || fieldInfo5.Name.Contains("コア"))
								{
									fieldInfo5.SetValue(体色, Color.FromArgb((int)color7.A, 255, 0, 0));
								}
								else
								{
									fieldInfo5.SetValue(体色, Color.FromArgb((int)color7.A, 255, 255, 255));
								}
							}
						}
						体色.血統.Add(tex.アルビノ);
					}
					break;
				case 1:
					if (!体色.血統.Contains(tex.メラニス))
					{
						foreach (FieldInfo fieldInfo6 in from e in 交配.体色t.GetFields()
						where 体色.変異色.Contains(e.Name) && e.FieldType.ToString() == Sta.ct
						select e)
						{
							Color color7 = (Color)fieldInfo6.GetValue(体色);
							if (color7 != Col.Empty)
							{
								if (fieldInfo6.Name == "人肌")
								{
									color7 = Color.FromArgb((int)color7.A, 0, 0, 0);
									Col.GetLimitSkin(ref color7, out color7);
									fieldInfo6.SetValue(体色, color7);
								}
								else if (fieldInfo6.Name.Contains("目") || fieldInfo6.Name.Contains("眼") || fieldInfo6.Name.Contains("秘石") || fieldInfo6.Name.Contains("コア"))
								{
									fieldInfo6.SetValue(体色, Color.FromArgb((int)color7.A, 0, 127, 255));
								}
								else
								{
									fieldInfo6.SetValue(体色, Color.FromArgb((int)color7.A, 0, 0, 0));
								}
							}
						}
						体色.血統.Add(tex.メラニス);
					}
					break;
				case 2:
					if (!体色.血統.Any((string e) => e.StartsWith(tex.ルチノ\u30FC)))
					{
						int num = OthN.XS.Next(3);
						int num2 = OthN.XS.Next(3);
						int num3 = OthN.XS.Next(3);
						foreach (FieldInfo fieldInfo7 in from e in 交配.体色t.GetFields()
						where 体色.変異色.Contains(e.Name) && e.FieldType.ToString() == Sta.ct
						select e)
						{
							Color color7 = (Color)fieldInfo7.GetValue(体色);
							if (color7 != Col.Empty)
							{
								if (fieldInfo7.Name == "人肌")
								{
									color7 = Color.FromArgb((int)color7.A, 交配.GetVal((int)color7.R, num), 交配.GetVal((int)color7.G, num2), 交配.GetVal((int)color7.B, num3));
									Col.GetLimitSkin(ref color7, out color7);
									fieldInfo7.SetValue(体色, color7);
								}
								else
								{
									color7 = Color.FromArgb((int)color7.A, 交配.GetVal((int)color7.R, num), 交配.GetVal((int)color7.G, num2), 交配.GetVal((int)color7.B, num3));
									Col.GetLimit(ref color7, out color7);
									fieldInfo7.SetValue(体色, color7);
								}
							}
						}
						if (num != 2 || num2 != 2 || num3 != 2)
						{
							体色.血統.Add(string.Concat(new object[]
							{
								tex.ルチノ\u30FC,
								num,
								num2,
								num3
							}));
						}
					}
					break;
				}
				if (0.05.Lot())
				{
					bool flag = false;
					bool flag2 = false;
					bool flag3 = false;
					foreach (EleD eleD in d.EnumEleD())
					{
						if (!flag && eleD is 双目D)
						{
							flag = true;
						}
						if (!flag2 && eleD is 頬目D)
						{
							flag2 = true;
						}
						if (!flag3 && eleD is 縦目D)
						{
							flag3 = true;
						}
					}
					if ((flag2 && 体色.頬目左 != 体色.頬目右) || (flag && 体色.目左 != 体色.目右) || (flag3 && (体色.目左 != 体色.縦目 || 体色.目右 != 体色.縦目)))
					{
						体色.血統.Add(tex.オッドアイ);
					}
				}
				else
				{
					switch (OthN.XS.Next(6))
					{
					case 0:
						体色.縦目 = 体色.目左;
						体色.頬目左 = 体色.目左;
						体色.頬目右 = 体色.目左;
						体色.目右 = 体色.目左;
						break;
					case 1:
						体色.縦目 = 体色.目右;
						体色.頬目左 = 体色.目右;
						体色.頬目右 = 体色.目右;
						体色.目左 = 体色.目右;
						break;
					case 2:
						Oth.GetInter(ref 体色.目左, ref 体色.目右, out 体色.縦目);
						体色.頬目左 = 体色.目左;
						体色.頬目右 = 体色.目左;
						体色.目右 = 体色.目左;
						break;
					case 3:
						Oth.GetInter(ref 体色.目左, ref 体色.目右, out 体色.縦目);
						体色.頬目左 = 体色.目右;
						体色.頬目右 = 体色.目右;
						体色.目左 = 体色.目右;
						break;
					case 4:
						体色.頬目左 = 体色.目左;
						体色.頬目右 = 体色.目左;
						体色.目右 = 体色.目左;
						break;
					default:
						体色.頬目左 = 体色.目右;
						体色.頬目右 = 体色.目右;
						体色.目左 = 体色.目右;
						break;
					}
				}
			}
			else if (母方.血統.Contains(tex.オッドアイ) && 父方.血統.Contains(tex.オッドアイ))
			{
				bool flag4 = false;
				bool flag5 = false;
				bool flag6 = false;
				foreach (EleD eleD2 in d.EnumEleD())
				{
					if (!flag4 && eleD2 is 双目D)
					{
						flag4 = true;
					}
					if (!flag5 && eleD2 is 頬目D)
					{
						flag5 = true;
					}
					if (!flag6 && eleD2 is 縦目D)
					{
						flag6 = true;
					}
				}
				if ((flag5 && 体色.頬目左 != 体色.頬目右) || (flag4 && 体色.目左 != 体色.目右) || (flag6 && (体色.目左 != 体色.縦目 || 体色.目右 != 体色.縦目)))
				{
					体色.血統.Add(tex.オッドアイ);
				}
			}
			else
			{
				switch (OthN.XS.Next(6))
				{
				case 0:
					体色.縦目 = 体色.目左;
					体色.頬目左 = 体色.目左;
					体色.頬目右 = 体色.目左;
					体色.目右 = 体色.目左;
					break;
				case 1:
					体色.縦目 = 体色.目右;
					体色.頬目左 = 体色.目右;
					体色.頬目右 = 体色.目右;
					体色.目左 = 体色.目右;
					break;
				case 2:
					Oth.GetInter(ref 体色.目左, ref 体色.目右, out 体色.縦目);
					体色.頬目左 = 体色.目左;
					体色.頬目右 = 体色.目左;
					体色.目右 = 体色.目左;
					break;
				case 3:
					Oth.GetInter(ref 体色.目左, ref 体色.目右, out 体色.縦目);
					体色.頬目左 = 体色.目右;
					体色.頬目右 = 体色.目右;
					体色.目左 = 体色.目右;
					break;
				case 4:
					体色.頬目左 = 体色.目左;
					体色.頬目右 = 体色.目左;
					体色.目右 = 体色.目左;
					break;
				default:
					体色.頬目左 = 体色.目右;
					体色.頬目右 = 体色.目右;
					体色.目左 = 体色.目右;
					break;
				}
			}
			return 体色;
		}

		private static int GetVal(int i, int v)
		{
			if (v == 0)
			{
				return 0;
			}
			if (v != 1)
			{
				return i;
			}
			return 255;
		}

		private static 腰D Mix(腰D 母方, 腰D 父方, double 変異率, bool 原種モ\u30FCド)
		{
			int i = 原種モ\u30FCド ? OthN.XS.Next(3) : OthN.XS.Next(7);
			Dictionary<接続情報, List<Type>> 接続構成 = 交配.Get接続構成(母方, 父方);
			Type[] 要素構成 = 交配.Get要素構成(母方, 父方);
			頭D 頭D = 交配.Mix<頭D>(母方, 父方, i, 原種モ\u30FCド);
			基髪D 基髪D = new 基髪D();
			頭D.基髪接続(基髪D);
			頭D.目左接続(new 目傷D());
			頭D.目右接続(new 目傷D
			{
				右 = true
			});
			頭D.目左接続(new 目尻影D());
			頭D.目右接続(new 目尻影D
			{
				右 = true
			});
			鼻肌D 鼻肌D;
			頭D.鼻肌接続(鼻肌D = 交配.Mix<鼻肌D>(母方, 父方, i, 原種モ\u30FCド));
			頭D.鼻肌接続(new 紅潮D());
			頬肌D 頬肌D = 交配.Mix<頬肌D>(母方, 父方, false, i, 原種モ\u30FCド);
			頭D.頬肌左接続(頬肌D);
			頭D.頬肌右接続(頬肌D.Get逆());
			顔ハイライトD 顔ハイライトD = 交配.Mix<顔ハイライトD>(母方, 父方, false, i, 原種モ\u30FCド);
			頭D.頬左接続(顔ハイライトD);
			頭D.頬右接続(顔ハイライトD.Get逆());
			頭D.単眼目接続(new 目隠帯D());
			頭D.口接続(new 玉口枷D());
			頭D.AlignC();
			首D 首D = 交配.Mix<首D>(母方, 父方, i, 原種モ\u30FCド);
			首D.頭接続(頭D);
			胸D 胸D = 交配.Mix<胸D>(母方, 父方, i, 原種モ\u30FCド);
			乳房D 乳房D = 交配.Mix<乳房D>(母方, 父方, false, i, 原種モ\u30FCド);
			乳房D.噴乳接続(new 噴乳D());
			乳房D.噴乳接続(new ピアスD());
			乳房D.噴乳接続(new キャップ2D());
			乳房D.噴乳接続(new 下着乳首D());
			胸D.胸左接続(乳房D);
			胸D.胸右接続(乳房D.Get逆());
			胸D.肌接続(交配.Mix<胸毛D>(母方, 父方, i, 原種モ\u30FCド));
			胸D.肌接続(交配.Mix<胸肌D>(母方, 父方, i, 原種モ\u30FCド));
			胸腹板D 胸腹板D;
			胸D.肌接続(胸腹板D = 交配.Mix<胸腹板D>(母方, 父方, i, 原種モ\u30FCド));
			胸D.肌接続(new 下着トップ_チュ\u30FCブD());
			胸D.肌接続(new 下着トップ_クロスD());
			胸D.肌接続(new 下着トップ_ビキニD());
			胸D.肌接続(new 下着トップ_マイクロD());
			胸D.肌接続(new 下着トップ_ブラD());
			胸D.肌接続(new 上着トップ_ドレスD());
			胸D.AlignC();
			胸D.首接続(首D);
			胴D 胴D = 交配.Mix<胴D>(母方, 父方, i, 原種モ\u30FCド);
			胴腹板D 胴腹板D;
			胴D.肌接続(胴腹板D = 交配.Mix<胴腹板D>(母方, 父方, i, 原種モ\u30FCド));
			胴D.肌接続(交配.Mix<胴肌D>(母方, 父方, i, 原種モ\u30FCド));
			胴D.肌接続(new 上着ミドル_ドレスD());
			胴D.AlignC();
			胴D.胸接続(胸D);
			腰D 腰 = 交配.Mix<腰D>(母方, 父方, i, 原種モ\u30FCド);
			腰.膣基接続(new 膣基_人D());
			腰.膣基接続(new 膣内精液_人D());
			腰.膣基接続(new 断面_人D());
			腰.膣基接続(Uni.性器());
			腰.肛門接続(Uni.肛門());
			腰.肌接続(Uni.ボテ腹());
			腰肌D 腰肌;
			腰.肌接続(腰肌 = 交配.Mix<腰肌D>(母方, 父方, i, 原種モ\u30FCド));
			腰.肌接続(new 下着ボトム_ノ\u30FCマルD());
			腰.肌接続(new 下着ボトム_マイクロD());
			上着ボトム_クロスD 上着ボトム_クロスD = new 上着ボトム_クロスD();
			上着ボトム_クロスD.上着ボトム後接続(new 上着ボトム_クロス後D());
			腰.上着接続(上着ボトム_クロスD);
			腰.上着接続(new 上着ボトム_前掛けD());
			腰.AlignC();
			腰.胴接続(胴D);
			胴D.肥大 = 腰.肥大;
			if (OthN.XS.NextBool())
			{
				EleD eleD = Con.Get後髪0R();
				基髪D.後髪接続(eleD);
				eleD.AlignR();
				if (eleD is 後髪0_肢系D && 変異率.Lot())
				{
					eleD.接続(母方, 父方, i, 接続情報.後髪0_肢系_左2_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
					eleD.接続(母方, 父方, i, 接続情報.後髪0_肢系_左3_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
					eleD.接続(母方, 父方, i, 接続情報.後髪0_肢系_左4_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
					eleD.接続(母方, 父方, i, 接続情報.後髪0_肢系_左5_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
				}
				if ((eleD is 後髪0_ジグD || eleD is 後髪0_ハネD || eleD is 後髪0_パツD || eleD is 後髪0_カルD || eleD is 後髪0_肢系D) && OthN.XS.NextBool())
				{
					EleD e6 = Con.Get後髪1R();
					基髪D.後髪接続(e6);
					e6.AlignR();
				}
				EleD eleD2 = Con.Get横髪R(false);
				基髪D.横髪左接続(eleD2);
				eleD2.AlignR();
				基髪D.横髪右接続(eleD2.Get逆());
				EleD e2 = Con.Get前髪R();
				基髪D.前髪接続(e2);
				e2.AlignR();
			}
			else
			{
				後髪0D 後髪0D = 交配.Mix<後髪0D>(母方, 父方, i, 原種モ\u30FCド);
				if (後髪0D != null)
				{
					基髪D.後髪接続(後髪0D);
					後髪0D.AlignR();
					if (後髪0D is 後髪0_肢系D && 変異率.Lot())
					{
						後髪0D.接続(母方, 父方, i, 接続情報.後髪0_肢系_左2_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
						後髪0D.接続(母方, 父方, i, 接続情報.後髪0_肢系_左3_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
						後髪0D.接続(母方, 父方, i, 接続情報.後髪0_肢系_左4_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
						後髪0D.接続(母方, 父方, i, 接続情報.後髪0_肢系_左5_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
					}
					if ((後髪0D is 後髪0_ジグD || 後髪0D is 後髪0_ハネD || 後髪0D is 後髪0_パツD || 後髪0D is 後髪0_カルD || 後髪0D is 後髪0_肢系D) && OthN.XS.NextBool())
					{
						後髪1D 後髪1D = 交配.Mix<後髪1D>(母方, 父方, i, 原種モ\u30FCド);
						if (後髪1D != null)
						{
							基髪D.後髪接続(後髪1D);
							後髪1D.AlignR();
						}
					}
				}
				else if (OthN.XS.NextBool())
				{
					後髪1D 後髪1D2 = 交配.Mix<後髪1D>(母方, 父方, i, 原種モ\u30FCド);
					if (後髪1D2 != null)
					{
						基髪D.後髪接続(後髪1D2);
						後髪1D2.AlignR();
					}
				}
				横髪D 横髪D = 交配.Mix<横髪D>(母方, 父方, false, i, 原種モ\u30FCド);
				基髪D.横髪左接続(横髪D);
				横髪D.AlignR();
				基髪D.横髪右接続(横髪D.Get逆());
				前髪D e3 = 交配.Mix<前髪D>(母方, 父方, i, 原種モ\u30FCド);
				基髪D.前髪接続(e3);
				e3.AlignR();
			}
			双目D 双目D = null;
			双目D 双目D2 = null;
			頬目D 頬目D = null;
			頬目D 頬目D2 = null;
			縦目D 縦目D = null;
			単目D 単目D = null;
			縦瞼D 縦瞼D = null;
			単瞼D 単瞼D = null;
			bool flag = 母方.EnumEleD().IsEleD<双目D>() || 父方.EnumEleD().IsEleD<双目D>();
			bool flag2 = 母方.EnumEleD().IsEleD<単目D>() || 父方.EnumEleD().IsEleD<単目D>();
			if (!原種モ\u30FCド && 変異率.Lot() && 0.05.Lot())
			{
				flag2 = true;
			}
			if (flag && flag2)
			{
				if (OthN.XS.NextBool())
				{
					双目D = 交配.Mix<双目D>(母方, 父方, false, i, 原種モ\u30FCド);
					双瞼D 双瞼D = 交配.Mix<双瞼D>(母方, 父方, false, i, 原種モ\u30FCド);
					眉D 眉D = 交配.Mix<眉D>(母方, 父方, false, i, 原種モ\u30FCド);
					if (双目D != null && 双瞼D != null && 眉D != null)
					{
						if (原種モ\u30FCド || !変異率.Lot() || !0.05.Lot())
						{
							双目D.瞼接続(双瞼D);
							双目D.瞼接続(new 涙D());
							頭D.目左接続(双目D);
							頭D.目右接続(双目D2 = (双目D)双目D.Get逆());
						}
						頭D.眉左接続(眉D);
						頭D.眉右接続(眉D.Get逆());
					}
					else
					{
						双目D = Con.Get双眼R(false);
						頭D.目左接続(双目D);
						頭D.目右接続(双目D2 = (双目D)双目D.Get逆());
						眉D 眉D2 = Con.Get眉R(false);
						頭D.眉左接続(眉D2);
						頭D.眉右接続(眉D2.Get逆());
					}
					縦目D = 交配.Mix<縦目D>(母方, 父方, i, 原種モ\u30FCド);
					縦瞼D = 交配.Mix<縦瞼D>(母方, 父方, i, 原種モ\u30FCド);
					if (縦目D != null && 縦瞼D != null)
					{
						縦目D.瞼接続(縦瞼D);
						頭D.額接続(縦目D);
					}
					else if (!原種モ\u30FCド && 変異率.Lot() && 0.05.Lot())
					{
						頭D.額接続(縦目D = Con.Get縦眼R());
						縦瞼D = 縦目D.瞼_接続.GetEleD<縦瞼D>();
					}
					頬目D = 交配.Mix<頬目D>(母方, 父方, false, i, 原種モ\u30FCド);
					頬瞼D 頬瞼D = 交配.Mix<頬瞼D>(母方, 父方, false, i, 原種モ\u30FCド);
					if (頬目D != null && 頬瞼D != null)
					{
						頬目D.瞼接続(頬瞼D);
						頭D.頬肌左接続(頬目D);
						頭D.頬肌右接続(頬目D2 = (頬目D)頬目D.Get逆());
					}
					else if (!原種モ\u30FCド && 変異率.Lot() && 0.05.Lot())
					{
						頬目D = Con.Get頬眼R(false);
						頭D.頬肌左接続(頬目D);
						頭D.頬肌右接続(頬目D2 = (頬目D)頬目D.Get逆());
					}
				}
				else
				{
					単目D = 交配.Mix<単目D>(母方, 父方, i, 原種モ\u30FCド);
					単瞼D = 交配.Mix<単瞼D>(母方, 父方, i, 原種モ\u30FCド);
					単眼眉D 単眼眉D = 交配.Mix<単眼眉D>(母方, 父方, i, 原種モ\u30FCド);
					if (単目D != null && 単瞼D != null && 単眼眉D != null)
					{
						単目D.瞼接続(単瞼D);
						単目D.瞼接続(new 涙D
						{
							基準C = new Vector2D(0.01, 0.0)
						});
						単目D.瞼接続(new 涙D
						{
							右 = true,
							基準C = new Vector2D(-0.01, 0.0)
						});
						頭D.単眼目接続(単目D);
						頭D.単眼眉接続(単眼眉D);
					}
					else
					{
						頭D.単眼目接続(単目D = Con.Get単眼R());
						単瞼D = 単目D.瞼_接続.GetEleD<単瞼D>();
						頭D.単眼眉接続(Con.Get単眼眉R());
					}
				}
			}
			else if (flag)
			{
				双目D = 交配.Mix<双目D>(母方, 父方, false, i, 原種モ\u30FCド);
				双瞼D 双瞼D2 = 交配.Mix<双瞼D>(母方, 父方, false, i, 原種モ\u30FCド);
				眉D 眉D3 = 交配.Mix<眉D>(母方, 父方, false, i, 原種モ\u30FCド);
				if (双目D != null && 双瞼D2 != null && 眉D3 != null)
				{
					if (原種モ\u30FCド || !変異率.Lot() || !0.05.Lot())
					{
						双目D.瞼接続(双瞼D2);
						双目D.瞼接続(new 涙D());
						頭D.目左接続(双目D);
						頭D.目右接続(双目D2 = (双目D)双目D.Get逆());
					}
					頭D.眉左接続(眉D3);
					頭D.眉右接続(眉D3.Get逆());
				}
				else
				{
					双目D = Con.Get双眼R(false);
					頭D.目左接続(双目D);
					頭D.目右接続(双目D2 = (双目D)双目D.Get逆());
					眉D 眉D4 = Con.Get眉R(false);
					頭D.眉左接続(眉D4);
					頭D.眉右接続(眉D4.Get逆());
				}
				縦目D = 交配.Mix<縦目D>(母方, 父方, i, 原種モ\u30FCド);
				縦瞼D = 交配.Mix<縦瞼D>(母方, 父方, i, 原種モ\u30FCド);
				if (縦目D != null && 縦瞼D != null)
				{
					縦目D.瞼接続(縦瞼D);
					頭D.額接続(縦目D);
				}
				else if (!原種モ\u30FCド && 変異率.Lot() && 0.05.Lot())
				{
					頭D.額接続(縦目D = Con.Get縦眼R());
					縦瞼D = 縦目D.瞼_接続.GetEleD<縦瞼D>();
				}
				頬目D = 交配.Mix<頬目D>(母方, 父方, false, i, 原種モ\u30FCド);
				頬瞼D 頬瞼D2 = 交配.Mix<頬瞼D>(母方, 父方, false, i, 原種モ\u30FCド);
				if (頬目D != null && 頬瞼D2 != null)
				{
					頬目D.瞼接続(頬瞼D2);
					頭D.頬肌左接続(頬目D);
					頭D.頬肌右接続(頬目D2 = (頬目D)頬目D.Get逆());
				}
				else if (!原種モ\u30FCド && 変異率.Lot() && 0.05.Lot())
				{
					頬目D = Con.Get頬眼R(false);
					頭D.頬肌左接続(頬目D);
					頭D.頬肌右接続(頬目D2 = (頬目D)頬目D.Get逆());
				}
			}
			else if (flag2)
			{
				単目D = 交配.Mix<単目D>(母方, 父方, i, 原種モ\u30FCド);
				単瞼D = 交配.Mix<単瞼D>(母方, 父方, i, 原種モ\u30FCド);
				単眼眉D 単眼眉D2 = 交配.Mix<単眼眉D>(母方, 父方, i, 原種モ\u30FCド);
				if (単目D != null && 単瞼D != null && 単眼眉D2 != null)
				{
					単目D.瞼接続(単瞼D);
					単目D.瞼接続(new 涙D
					{
						基準C = new Vector2D(0.01, 0.0)
					});
					単目D.瞼接続(new 涙D
					{
						右 = true,
						基準C = new Vector2D(-0.01, 0.0)
					});
					頭D.単眼目接続(単目D);
					頭D.単眼眉接続(単眼眉D2);
				}
				else
				{
					頭D.単眼目接続(単目D = Con.Get単眼R());
					単瞼D = 単目D.瞼_接続.GetEleD<単瞼D>();
					頭D.単眼眉接続(Con.Get単眼眉R());
				}
			}
			鼻D 鼻D = 交配.Mix<鼻D>(母方, 父方, i, 原種モ\u30FCド);
			if (鼻D != null)
			{
				鼻D.鼻水左接続(new 鼻水D());
				鼻D.鼻水右接続(new 鼻水D
				{
					右 = true
				});
				頭D.鼻接続(鼻D);
			}
			口D 口D = 交配.Mix<口D>(母方, 父方, i, 原種モ\u30FCド);
			if (口D != null)
			{
				if (口D is 口_通常D)
				{
					頭D.口接続(口D);
					頭D.口接続(new 涎_通常D());
					頭D.口接続(new 涎_通常D
					{
						右 = true
					});
				}
				else if (口D is 口_裂けD)
				{
					頭D.口接続(口D);
					頭D.口接続(new 涎_裂けD());
					頭D.口接続(new 涎_裂けD
					{
						右 = true
					});
				}
				頭D.口接続(new 性器精液_人D());
				頭D.口接続(new 咳D());
				頭D.口接続(new 呼気D());
				舌D 舌D = 交配.Mix<舌D>(母方, 父方, i, 原種モ\u30FCド);
				if (舌D != null)
				{
					頭D.口接続(舌D);
				}
			}
			頭D.接続(母方, 父方, i, 接続情報.頭_耳左_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
			基髪D.接続(母方, 父方, i, 接続情報.基髪_頭頂左_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
			頭D.接続(母方, 父方, i, 接続情報.頭_頬左_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
			頭D.接続(母方, 父方, i, 接続情報.頭_大顎基_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
			頭D.接続(母方, 父方, i, 接続情報.頭_顔面_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
			頭D.接続(母方, 父方, i, 接続情報.頭_頭頂_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
			頭D.接続(母方, 父方, i, 接続情報.頭_触覚左_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
			胸D.接続(母方, 父方, i, 接続情報.胸_肩左_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
			頭D.接続(母方, 父方, i, 接続情報.頭_額_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
			胸D.接続(母方, 父方, i, 接続情報.胸_翼上左_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
			胸D.接続(母方, 父方, i, 接続情報.胸_翼下左_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
			胴D.接続(母方, 父方, i, 接続情報.胴_翼左_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
			腰.接続(母方, 父方, i, 接続情報.腰_翼左_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
			if (原種モ\u30FCド)
			{
				胸D.接続(母方, 父方, i, 接続情報.胸_背中_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
			}
			else
			{
				EleD eleD3 = 交配.Mix<背中D>(母方, 父方, i, 原種モ\u30FCド);
				if (eleD3 != null)
				{
					string t = eleD3.GetType().ToString();
					if (!胸D.背中_接続.Any((EleD e) => e.GetType().ToString() == t) && OthN.XS.NextBool())
					{
						胸D.背中接続(eleD3);
					}
				}
				eleD3 = 交配.Mix<背中D>(母方, 父方, i, 原種モ\u30FCド);
				if (eleD3 != null)
				{
					string t = eleD3.GetType().ToString();
					if (!胸D.背中_接続.Any((EleD e) => e.GetType().ToString() == t) && OthN.XS.NextBool())
					{
						胸D.背中接続(eleD3);
					}
				}
				eleD3 = 交配.Mix<背中D>(母方, 父方, i, 原種モ\u30FCド);
				if (eleD3 != null)
				{
					string t = eleD3.GetType().ToString();
					if (!胸D.背中_接続.Any((EleD e) => e.GetType().ToString() == t) && OthN.XS.NextBool())
					{
						胸D.背中接続(eleD3);
					}
				}
			}
			半身D 半身 = 交配.Mix<半身D>(母方, 父方, i, 原種モ\u30FCド);
			Action action = delegate()
			{
				腰.半身接続(半身);
				半身.AlignR();
				if (半身 is 長物_魚D)
				{
					長物_魚D 長物_魚D = (長物_魚D)半身;
					長物_魚D.接続(母方, 父方, i, 接続情報.長物_魚_左0_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
					長物_魚D.接続(母方, 父方, i, 接続情報.長物_魚_左6_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
					長物_魚D.接続(母方, 父方, i, 接続情報.長物_魚_尾_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
					if (長物_魚D.尾_接続.Count > 0)
					{
						foreach (EleD e7 in 長物_魚D.尾_接続)
						{
							e7.AlignR();
						}
					}
					double num4 = 長物_魚D.尺度B;
					foreach (EleD eleD147 in 長物_魚D.左0_接続)
					{
						eleD147.尺度B = num4;
					}
					foreach (EleD eleD148 in 長物_魚D.右0_接続)
					{
						eleD148.尺度B = num4;
					}
					num4 *= 0.9;
					num4 *= 0.9;
					num4 *= 0.9;
					num4 *= 0.9;
					num4 *= 0.9;
					num4 *= 0.9;
					foreach (EleD eleD149 in 長物_魚D.左6_接続)
					{
						eleD149.尺度B = num4;
					}
					foreach (EleD eleD150 in 長物_魚D.右6_接続)
					{
						eleD150.尺度B = num4;
					}
					腰.接続(母方, 父方, i, 接続情報.腰_腿左_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
					for (int k = 腰.腿左_接続.Count - 1; k > -1; k--)
					{
						if (!(腰.腿左_接続[k] is 触手_犬D))
						{
							腰.腿左_接続.RemoveAt(k);
						}
					}
					for (int l = 腰.腿右_接続.Count - 1; l > -1; l--)
					{
						if (!(腰.腿右_接続[l] is 触手_犬D))
						{
							腰.腿右_接続.RemoveAt(l);
						}
					}
					if (腰.腿左_接続.IsEleD<触手_犬D>())
					{
						for (int m = 腰.翼左_接続.Count - 1; m > -1; m--)
						{
							if (腰.翼左_接続[m] is 四足脇D)
							{
								腰.翼左_接続.RemoveAt(m);
							}
						}
						for (int n = 腰.翼右_接続.Count - 1; n > -1; n--)
						{
							if (腰.翼右_接続[n] is 四足脇D)
							{
								腰.翼右_接続.RemoveAt(n);
							}
						}
						return;
					}
				}
				else if (半身 is 長物_鯨D)
				{
					長物_鯨D 鯨 = (長物_鯨D)半身;
					鯨.接続(母方, 父方, i, 接続情報.長物_鯨_左0_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
					鯨.接続(母方, 父方, i, 接続情報.長物_鯨_左6_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
					鯨.接続(母方, 父方, i, 接続情報.長物_鯨_尾_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
					if (鯨.尾_接続.Count > 0)
					{
						foreach (EleD e8 in 鯨.尾_接続)
						{
							e8.AlignR();
						}
					}
					鯨.尾_接続.SetEleD(delegate(尾_鯨D e)
					{
						e.柄 = 鯨.柄;
					});
					double num5 = 鯨.尺度B;
					foreach (EleD eleD151 in 鯨.左0_接続)
					{
						eleD151.尺度B = num5;
					}
					foreach (EleD eleD152 in 鯨.右0_接続)
					{
						eleD152.尺度B = num5;
					}
					num5 *= 0.9;
					num5 *= 0.9;
					num5 *= 0.9;
					num5 *= 0.9;
					num5 *= 0.9;
					num5 *= 0.9;
					foreach (EleD eleD153 in 鯨.左6_接続)
					{
						eleD153.尺度B = num5;
					}
					foreach (EleD eleD154 in 鯨.右6_接続)
					{
						eleD154.尺度B = num5;
					}
					腰.接続(母方, 父方, i, 接続情報.腰_腿左_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
					for (int num6 = 腰.腿左_接続.Count - 1; num6 > -1; num6--)
					{
						if (!(腰.腿左_接続[num6] is 触手_犬D))
						{
							腰.腿左_接続.RemoveAt(num6);
						}
					}
					for (int num7 = 腰.腿右_接続.Count - 1; num7 > -1; num7--)
					{
						if (!(腰.腿右_接続[num7] is 触手_犬D))
						{
							腰.腿右_接続.RemoveAt(num7);
						}
					}
					if (腰.腿左_接続.IsEleD<触手_犬D>())
					{
						for (int num8 = 腰.翼左_接続.Count - 1; num8 > -1; num8--)
						{
							if (腰.翼左_接続[num8] is 四足脇D)
							{
								腰.翼左_接続.RemoveAt(num8);
							}
						}
						for (int num9 = 腰.翼右_接続.Count - 1; num9 > -1; num9--)
						{
							if (腰.翼右_接続[num9] is 四足脇D)
							{
								腰.翼右_接続.RemoveAt(num9);
							}
						}
						return;
					}
				}
				else if (半身 is 長物_蛇D)
				{
					長物_蛇D 長物_蛇D = (長物_蛇D)半身;
					長物_蛇D.接続(母方, 父方, i, 接続情報.長物_蛇_左_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
					胴_蛇D 胴_蛇D = 交配.Mix<胴_蛇D>(母方, 父方, i, 原種モ\u30FCド);
					if (胴_蛇D != null)
					{
						胴_蛇D.接続(母方, 父方, i, 接続情報.胴_蛇_左_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
						長胴D 長胴D = (長胴D)胴_蛇D.Copy();
						長物_蛇D.胴接続(胴_蛇D);
						int num10 = 2;
						int num11 = 母方.EnumEleD().Count((EleD e) => e is 長胴D);
						int num12 = 父方.EnumEleD().Count((EleD e) => e is 長胴D);
						if (OthN.XS.NextBool())
						{
							num10 = (int)((double)(num11 + num12) * 0.5);
						}
						else if (OthN.XS.NextBool())
						{
							num10 = num11;
						}
						else
						{
							num10 = num12;
						}
						num10 = (num10 + OthN.XS.NextSign() * OthN.XS.Next(4)).LimitM(0, 50);
						for (int num13 = 0; num13 < num10; num13++)
						{
							胴_蛇D.胴接続(胴_蛇D = (胴_蛇D)長胴D.Copy());
						}
						胴_蛇D.接続(母方, 父方, i, 接続情報.胴_蛇_胴_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
						if (胴_蛇D.EnumEleD().IsEleD<腿D>())
						{
							IEnumerable<胴_蛇D> eleDs = 長物_蛇D.EnumEleD().Skip(1).GetEleDs<胴_蛇D>();
							foreach (胴_蛇D 胴_蛇D2 in eleDs.Take(eleDs.Count<胴_蛇D>() - 1))
							{
								胴_蛇D2.左_接続.Clear();
								胴_蛇D2.右_接続.Clear();
							}
							if (num10 < 2)
							{
								胴_蛇D 胴_蛇D3 = eleDs.Last<胴_蛇D>();
								胴_蛇D3.左_接続.Clear();
								胴_蛇D3.右_接続.Clear();
								goto IL_AD3;
							}
							goto IL_AD3;
						}
						else
						{
							int num14 = 0;
							using (IEnumerator<胴_蛇D> enumerator5 = 長物_蛇D.EnumEleD().Skip(1).GetEleDs<胴_蛇D>().GetEnumerator())
							{
								while (enumerator5.MoveNext())
								{
									胴_蛇D 胴_蛇D4 = enumerator5.Current;
									if (num14 % 3 != 1)
									{
										胴_蛇D4.左_接続.Clear();
										胴_蛇D4.右_接続.Clear();
									}
									num14++;
								}
								goto IL_AD3;
							}
						}
					}
					長物_蛇D.接続(母方, 父方, i, 接続情報.長物_蛇_胴_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
					IL_AD3:
					長物_蛇D.AlignC();
					if (長物_蛇D.ガ\u30FCド)
					{
						腰肌.竜性_鱗1_表示 = false;
						腰肌.竜性_鱗2_表示 = false;
						腰肌.竜性_鱗3_表示 = false;
						腰肌.竜性_鱗4_表示 = false;
						腰肌.獣性_獣毛_表示 = false;
						腰肌.陰毛_表示 = false;
					}
					腰.接続(母方, 父方, i, 接続情報.腰_腿左_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
					for (int num15 = 腰.腿左_接続.Count - 1; num15 > -1; num15--)
					{
						if (!(腰.腿左_接続[num15] is 触手_犬D))
						{
							腰.腿左_接続.RemoveAt(num15);
						}
					}
					for (int num16 = 腰.腿右_接続.Count - 1; num16 > -1; num16--)
					{
						if (!(腰.腿右_接続[num16] is 触手_犬D))
						{
							腰.腿右_接続.RemoveAt(num16);
						}
					}
					if (腰.腿左_接続.IsEleD<触手_犬D>())
					{
						for (int num17 = 腰.翼左_接続.Count - 1; num17 > -1; num17--)
						{
							if (腰.翼左_接続[num17] is 四足脇D)
							{
								腰.翼左_接続.RemoveAt(num17);
							}
						}
						for (int num18 = 腰.翼右_接続.Count - 1; num18 > -1; num18--)
						{
							if (腰.翼右_接続[num18] is 四足脇D)
							{
								腰.翼右_接続.RemoveAt(num18);
							}
						}
						return;
					}
				}
				else
				{
					if (半身 is 長物_蟲D)
					{
						長物_蟲D 長物_蟲D = (長物_蟲D)半身;
						長物_蟲D.接続(母方, 父方, i, 接続情報.長物_蟲_左0_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
						長物_蟲D.接続(母方, 父方, i, 接続情報.長物_蟲_左1_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
						胴_蟲D 胴_蟲D = 交配.Mix<胴_蟲D>(母方, 父方, i, 原種モ\u30FCド);
						if (胴_蟲D != null)
						{
							胴_蟲D.接続(母方, 父方, i, 接続情報.胴_蟲_左_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
							長胴D 長胴D2 = (長胴D)胴_蟲D.Copy();
							長物_蟲D.胴接続(胴_蟲D);
							int num19 = 母方.EnumEleD().Count((EleD e) => e is 長胴D);
							int num20 = 父方.EnumEleD().Count((EleD e) => e is 長胴D);
							int num21;
							if (OthN.XS.NextBool())
							{
								num21 = (int)((double)(num19 + num20) * 0.5);
							}
							else if (OthN.XS.NextBool())
							{
								num21 = num19;
							}
							else
							{
								num21 = num20;
							}
							num21 = (num21 + OthN.XS.NextSign() * OthN.XS.Next(4)).LimitM(0, 50);
							for (int num22 = 0; num22 < num21; num22++)
							{
								胴_蟲D.胴接続(胴_蟲D = (胴_蟲D)長胴D2.Copy());
							}
							胴_蟲D.接続(母方, 父方, i, 接続情報.胴_蟲_胴_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
						}
						else
						{
							長物_蟲D.接続(母方, 父方, i, 接続情報.長物_蟲_胴_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
						}
						長物_蟲D.AlignC();
						腰.翼左_接続.RemoveAll((EleD e) => e is 四足脇D);
						腰.翼右_接続.RemoveAll((EleD e) => e is 四足脇D);
						return;
					}
					if (半身 is 四足胸D)
					{
						四足胸D 四足胸D = (四足胸D)半身;
						胸毛D 胸毛D;
						四足胸D.肌接続(胸毛D = 交配.Mix<胸毛D>(母方, 父方, i, 原種モ\u30FCド));
						胸肌D 胸肌D;
						四足胸D.肌接続(胸肌D = 交配.Mix<胸肌D>(母方, 父方, i, 原種モ\u30FCド));
						四足胸D.AlignC();
						if (胸毛D != null)
						{
							胸毛D.尺度B *= 1.4;
						}
						if (胸肌D != null)
						{
							胸肌D.尺度B *= 1.3;
							胸肌D.蜘蛛_眼左2_基_表示 = false;
							胸肌D.蜘蛛_眼左2_眼_表示 = false;
							胸肌D.蜘蛛_眼左2_ハイライト_表示 = false;
							胸肌D.蜘蛛_眼右2_基_表示 = false;
							胸肌D.蜘蛛_眼右2_眼_表示 = false;
							胸肌D.蜘蛛_眼右2_ハイライト_表示 = false;
						}
						四足胸D.肥大 = 腰.肥大;
						四足胴D 四足胴D = 交配.Mix<四足胴D>(母方, 父方, i, 原種モ\u30FCド);
						if (四足胴D != null)
						{
							胴肌D 胴肌D;
							四足胴D.肌接続(胴肌D = 交配.Mix<胴肌D>(母方, 父方, i, 原種モ\u30FCド));
							四足胴D.AlignC();
							if (胴肌D != null)
							{
								胴肌D.尺度B *= 1.35;
							}
							四足胸D.胴接続(四足胴D);
							四足胴D.肥大 = 腰.肥大;
						}
						四足腰D 四足腰D = 交配.Mix<四足腰D>(母方, 父方, i, 原種モ\u30FCド);
						if (四足腰D != null)
						{
							四足腰D.膣基接続(new 膣基_獣D());
							四足腰D.膣基接続(new 膣内精液_獣D());
							四足腰D.膣基接続(new 断面_獣D());
							四足腰D.膣基接続(Uni.四足性器());
							四足腰D.肛門接続(Uni.四足肛門());
							四足腰D.肌接続(new ボテ腹_獣D());
							腰肌D 腰肌D;
							四足腰D.肌接続(腰肌D = 交配.Mix<腰肌D>(母方, 父方, i, 原種モ\u30FCド));
							腰.膣基_接続.SetEleD(delegate(性器_人D e)
							{
								e.表示 = false;
							});
							腰.肛門_接続.SetEleD(delegate(肛門_人D e)
							{
								e.表示 = false;
							});
							四足腰D.肌_接続.SetEleD(delegate(腰肌D e)
							{
								e.陰毛_表示 = false;
							});
							四足腰D.AlignC();
							if (腰肌D != null)
							{
								腰肌D.尺度B *= 1.4;
								腰肌D.虫性_腹板1_腹板_表示 = false;
								腰肌D.虫性_腹板2_腹板_表示 = false;
								腰肌D.虫性_腹板1_縦線_表示 = false;
								腰肌D.虫性_腹板2_縦線_表示 = false;
								腰肌D.陰毛_表示 = false;
							}
							四足胴D.腰接続(四足腰D);
							四足腰D.肥大 = 腰.肥大;
							if ((腰肌D.淫タトゥ_ハ\u30FCト_タトゥ右1_表示 || 腰肌D.淫タトゥ_ハ\u30FCト_タトゥ右2_表示 || 腰肌D.淫タトゥ_ハ\u30FCト_タトゥ左1_表示 || 腰肌D.淫タトゥ_ハ\u30FCト_タトゥ左2_表示) && (腰肌D.植タトゥ_タトゥ左_表示 || 腰肌D.植タトゥ_タトゥ右_表示))
							{
								if (OthN.XS.NextBool())
								{
									腰肌D.淫タトゥ_ハ\u30FCト_タトゥ右1_表示 = true;
									腰肌D.淫タトゥ_ハ\u30FCト_タトゥ右2_表示 = true;
									腰肌D.淫タトゥ_ハ\u30FCト_タトゥ左1_表示 = true;
									腰肌D.淫タトゥ_ハ\u30FCト_タトゥ左2_表示 = true;
									腰肌D.植タトゥ_タトゥ左_表示 = false;
									腰肌D.植タトゥ_タトゥ右_表示 = false;
								}
								else
								{
									腰肌D.淫タトゥ_ハ\u30FCト_タトゥ右1_表示 = false;
									腰肌D.淫タトゥ_ハ\u30FCト_タトゥ右2_表示 = false;
									腰肌D.淫タトゥ_ハ\u30FCト_タトゥ左1_表示 = false;
									腰肌D.淫タトゥ_ハ\u30FCト_タトゥ左2_表示 = false;
									腰肌D.植タトゥ_タトゥ左_表示 = true;
									腰肌D.植タトゥ_タトゥ右_表示 = true;
								}
							}
						}
						四足胸D.接続(母方, 父方, i, 接続情報.四足胸_脇左_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
						四足胸D.接続(母方, 父方, i, 接続情報.四足胸_翼上左_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
						四足胸D.接続(母方, 父方, i, 接続情報.四足胸_翼下左_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
						四足胴D.接続(母方, 父方, i, 接続情報.四足胴_翼左_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
						四足腰D.接続(母方, 父方, i, 接続情報.四足腰_翼左_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
						四足胸D.接続(母方, 父方, i, 接続情報.四足胸_背中_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
						四足腰D.接続(母方, 父方, i, 接続情報.四足腰_腿左_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
						四足腰D.接続(母方, 父方, i, 接続情報.四足腰_尾_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
						腰.翼左_接続.RemoveAll((EleD e) => e is 四足脇D);
						腰.翼右_接続.RemoveAll((EleD e) => e is 四足脇D);
						return;
					}
					if (半身 is 多足_蛸D)
					{
						多足_蛸D 多足_蛸D = (多足_蛸D)半身;
						多足_蛸D.接続(母方, 父方, i, 接続情報.多足_蛸_軟体外左_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
						多足_蛸D.接続(母方, 父方, i, 接続情報.多足_蛸_軟体内左_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
						多足_蛸D.軟体内左_接続.SetEleDs(delegate(触手_軟D e)
						{
							e.前足 = false;
							e.後足 = true;
						});
						多足_蛸D.軟体内右_接続.SetEleDs(delegate(触手_軟D e)
						{
							e.前足 = false;
							e.後足 = true;
						});
						多足_蛸D.軟体外左_接続.SetEleDs(delegate(触手_軟D e)
						{
							e.前足 = true;
							e.後足 = false;
						});
						多足_蛸D.軟体外右_接続.SetEleDs(delegate(触手_軟D e)
						{
							e.前足 = true;
							e.後足 = false;
						});
						腰.接続(母方, 父方, i, 接続情報.腰_腿左_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
						腰.接続(母方, 父方, i, 接続情報.腰_尾_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
						for (int num23 = 腰.腿左_接続.Count - 1; num23 > -1; num23--)
						{
							if (!(腰.腿左_接続[num23] is 触手_犬D))
							{
								腰.腿左_接続.RemoveAt(num23);
							}
						}
						for (int num24 = 腰.腿右_接続.Count - 1; num24 > -1; num24--)
						{
							if (!(腰.腿右_接続[num24] is 触手_犬D))
							{
								腰.腿右_接続.RemoveAt(num24);
							}
						}
						if (腰.腿左_接続.IsEleD<触手_犬D>())
						{
							for (int num25 = 腰.翼左_接続.Count - 1; num25 > -1; num25--)
							{
								if (腰.翼左_接続[num25] is 四足脇D)
								{
									腰.翼左_接続.RemoveAt(num25);
								}
							}
							for (int num26 = 腰.翼右_接続.Count - 1; num26 > -1; num26--)
							{
								if (腰.翼右_接続[num26] is 四足脇D)
								{
									腰.翼右_接続.RemoveAt(num26);
								}
							}
							return;
						}
					}
					else
					{
						if (半身 is 多足_蜘D)
						{
							多足_蜘D 多足_蜘D = (多足_蜘D)半身;
							多足_蜘D.接続(母方, 父方, i, 接続情報.多足_蜘_触肢左_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
							多足_蜘D.接続(母方, 父方, i, 接続情報.多足_蜘_節足左1_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
							多足_蜘D.接続(母方, 父方, i, 接続情報.多足_蜘_節足左2_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
							多足_蜘D.接続(母方, 父方, i, 接続情報.多足_蜘_節足左3_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
							多足_蜘D.接続(母方, 父方, i, 接続情報.多足_蜘_節足左4_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
							多足_蜘D.接続(母方, 父方, i, 接続情報.多足_蜘_尾_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
							節足_足蜘D 節足_足蜘D = 多足_蜘D.節足左1_接続.GetEleD<節足_足蜘D>();
							bool 柄1_表示 = 節足_足蜘D != null && 節足_足蜘D.柄1_表示;
							bool 柄2_表示 = 節足_足蜘D != null && 節足_足蜘D.柄2_表示;
							bool 爪 = 節足_足蜘D != null && 節足_足蜘D.爪;
							foreach (EleD eleD155 in 多足_蜘D.触肢左_接続)
							{
								if (eleD155 is 節尾_鋏D || eleD155 is 大顎D)
								{
									eleD155.反転Y = true;
								}
								else
								{
									eleD155.反転Y = false;
								}
							}
							foreach (EleD eleD156 in 多足_蜘D.触肢右_接続)
							{
								if (eleD156 is 節尾_鋏D || eleD156 is 大顎D)
								{
									eleD156.反転Y = true;
								}
								else
								{
									eleD156.反転Y = false;
								}
							}
							foreach (EleD eleD157 in 多足_蜘D.節足左1_接続)
							{
								if (eleD157 is 節足_足蜘D)
								{
									節足_足蜘D = (節足_足蜘D)eleD157;
									節足_足蜘D.柄1_表示 = 柄1_表示;
									節足_足蜘D.柄2_表示 = 柄2_表示;
									節足_足蜘D.爪 = 爪;
									eleD157.反転Y = false;
								}
								else if (eleD157 is 節足_足百D)
								{
									eleD157.反転Y = true;
								}
								else
								{
									eleD157.反転Y = false;
								}
							}
							foreach (EleD eleD158 in 多足_蜘D.節足右1_接続)
							{
								if (eleD158 is 節足_足蜘D)
								{
									節足_足蜘D = (節足_足蜘D)eleD158;
									節足_足蜘D.柄1_表示 = 柄1_表示;
									節足_足蜘D.柄2_表示 = 柄2_表示;
									節足_足蜘D.爪 = 爪;
									eleD158.反転Y = false;
								}
								else if (eleD158 is 節足_足百D)
								{
									eleD158.反転Y = true;
								}
								else
								{
									eleD158.反転Y = false;
								}
							}
							foreach (EleD eleD159 in 多足_蜘D.節足左2_接続)
							{
								if (eleD159 is 節足_足蜘D)
								{
									節足_足蜘D = (節足_足蜘D)eleD159;
									節足_足蜘D.柄1_表示 = 柄1_表示;
									節足_足蜘D.柄2_表示 = 柄2_表示;
									節足_足蜘D.爪 = 爪;
									eleD159.反転Y = false;
								}
								else if (eleD159 is 節足_足百D)
								{
									eleD159.反転Y = true;
								}
								else
								{
									eleD159.反転Y = false;
								}
							}
							foreach (EleD eleD160 in 多足_蜘D.節足右2_接続)
							{
								if (eleD160 is 節足_足蜘D)
								{
									節足_足蜘D = (節足_足蜘D)eleD160;
									節足_足蜘D.柄1_表示 = 柄1_表示;
									節足_足蜘D.柄2_表示 = 柄2_表示;
									節足_足蜘D.爪 = 爪;
									eleD160.反転Y = false;
								}
								else if (eleD160 is 節足_足百D)
								{
									eleD160.反転Y = true;
								}
								else
								{
									eleD160.反転Y = false;
								}
							}
							bool 反転Y = 多足_蜘D.節足左3_接続.Count > 0 && 多足_蜘D.節足左3_接続.First<EleD>().反転Y;
							foreach (EleD eleD161 in 多足_蜘D.節足左3_接続)
							{
								if (eleD161 is 節足_足蜘D)
								{
									節足_足蜘D = (節足_足蜘D)eleD161;
									節足_足蜘D.柄1_表示 = 柄1_表示;
									節足_足蜘D.柄2_表示 = 柄2_表示;
									節足_足蜘D.爪 = 爪;
									eleD161.反転Y = 反転Y;
								}
								else if (eleD161 is 節足_足百D)
								{
									eleD161.反転Y = true;
								}
								else
								{
									eleD161.反転Y = 反転Y;
								}
							}
							foreach (EleD eleD162 in 多足_蜘D.節足右3_接続)
							{
								if (eleD162 is 節足_足蜘D)
								{
									節足_足蜘D = (節足_足蜘D)eleD162;
									節足_足蜘D.柄1_表示 = 柄1_表示;
									節足_足蜘D.柄2_表示 = 柄2_表示;
									節足_足蜘D.爪 = 爪;
									eleD162.反転Y = 反転Y;
								}
								else if (eleD162 is 節足_足百D)
								{
									eleD162.反転Y = true;
								}
								else
								{
									eleD162.反転Y = 反転Y;
								}
							}
							foreach (EleD eleD163 in 多足_蜘D.節足左4_接続)
							{
								if (eleD163 is 節足_足蜘D)
								{
									節足_足蜘D = (節足_足蜘D)eleD163;
									節足_足蜘D.柄1_表示 = 柄1_表示;
									節足_足蜘D.柄2_表示 = 柄2_表示;
									節足_足蜘D.爪 = 爪;
									eleD163.反転Y = 反転Y;
								}
								else if (eleD163 is 節足_足百D)
								{
									eleD163.反転Y = true;
								}
								else
								{
									eleD163.反転Y = 反転Y;
								}
							}
							foreach (EleD eleD164 in 多足_蜘D.節足右4_接続)
							{
								if (eleD164 is 節足_足蜘D)
								{
									節足_足蜘D = (節足_足蜘D)eleD164;
									節足_足蜘D.柄1_表示 = 柄1_表示;
									節足_足蜘D.柄2_表示 = 柄2_表示;
									節足_足蜘D.爪 = 爪;
									eleD164.反転Y = 反転Y;
								}
								else if (eleD164 is 節足_足百D)
								{
									eleD164.反転Y = true;
								}
								else
								{
									eleD164.反転Y = 反転Y;
								}
							}
							腰.翼左_接続.RemoveAll((EleD e) => e is 四足脇D);
							腰.翼右_接続.RemoveAll((EleD e) => e is 四足脇D);
							return;
						}
						if (半身 is 多足_蠍D)
						{
							多足_蠍D 多足_蠍D = (多足_蠍D)半身;
							多足_蠍D.接続(母方, 父方, i, 接続情報.多足_蠍_触肢左_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
							多足_蠍D.接続(母方, 父方, i, 接続情報.多足_蠍_節足左1_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
							多足_蠍D.接続(母方, 父方, i, 接続情報.多足_蠍_節足左2_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
							多足_蠍D.接続(母方, 父方, i, 接続情報.多足_蠍_節足左3_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
							多足_蠍D.接続(母方, 父方, i, 接続情報.多足_蠍_節足左4_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
							多足_蠍D.接続(母方, 父方, i, 接続情報.多足_蠍_櫛状板左_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
							多足_蠍D.接続(母方, 父方, i, 接続情報.多足_蠍_尾_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
							節足_足蠍D 節足_足蠍D = 多足_蠍D.節足左1_接続.GetEleD<節足_足蠍D>();
							bool 柄1_表示2 = 節足_足蠍D != null && 節足_足蠍D.柄1_表示;
							bool 爪2 = 節足_足蠍D != null && 節足_足蠍D.爪;
							foreach (EleD eleD165 in 多足_蠍D.触肢左_接続)
							{
								if (eleD165 is 節尾_鋏D || eleD165 is 大顎D)
								{
									eleD165.反転Y = true;
								}
								else
								{
									eleD165.反転Y = false;
								}
							}
							foreach (EleD eleD166 in 多足_蠍D.触肢右_接続)
							{
								if (eleD166 is 節尾_鋏D || eleD166 is 大顎D)
								{
									eleD166.反転Y = true;
								}
								else
								{
									eleD166.反転Y = false;
								}
							}
							foreach (EleD eleD167 in 多足_蠍D.節足左1_接続)
							{
								if (eleD167 is 節足_足蠍D)
								{
									節足_足蠍D = (節足_足蠍D)eleD167;
									節足_足蠍D.柄1_表示 = 柄1_表示2;
									節足_足蠍D.爪 = 爪2;
								}
								else if (eleD167 is 節足_足百D)
								{
									eleD167.反転Y = true;
								}
							}
							foreach (EleD eleD168 in 多足_蠍D.節足右1_接続)
							{
								if (eleD168 is 節足_足蠍D)
								{
									節足_足蠍D = (節足_足蠍D)eleD168;
									節足_足蠍D.柄1_表示 = 柄1_表示2;
									節足_足蠍D.爪 = 爪2;
								}
								else if (eleD168 is 節足_足百D)
								{
									eleD168.反転Y = true;
								}
							}
							foreach (EleD eleD169 in 多足_蠍D.節足左2_接続)
							{
								if (eleD169 is 節足_足蠍D)
								{
									節足_足蠍D = (節足_足蠍D)eleD169;
									節足_足蠍D.柄1_表示 = 柄1_表示2;
									節足_足蠍D.爪 = 爪2;
								}
								else if (eleD169 is 節足_足百D)
								{
									eleD169.反転Y = true;
								}
							}
							foreach (EleD eleD170 in 多足_蠍D.節足右2_接続)
							{
								if (eleD170 is 節足_足蠍D)
								{
									節足_足蠍D = (節足_足蠍D)eleD170;
									節足_足蠍D.柄1_表示 = 柄1_表示2;
									節足_足蠍D.爪 = 爪2;
								}
								else if (eleD170 is 節足_足百D)
								{
									eleD170.反転Y = true;
								}
							}
							foreach (EleD eleD171 in 多足_蠍D.節足左3_接続)
							{
								if (eleD171 is 節足_足蠍D)
								{
									節足_足蠍D = (節足_足蠍D)eleD171;
									節足_足蠍D.柄1_表示 = 柄1_表示2;
									節足_足蠍D.爪 = 爪2;
								}
								else if (eleD171 is 節足_足百D)
								{
									eleD171.反転Y = true;
								}
							}
							foreach (EleD eleD172 in 多足_蠍D.節足右3_接続)
							{
								if (eleD172 is 節足_足蠍D)
								{
									節足_足蠍D = (節足_足蠍D)eleD172;
									節足_足蠍D.柄1_表示 = 柄1_表示2;
									節足_足蠍D.爪 = 爪2;
								}
								else if (eleD172 is 節足_足百D)
								{
									eleD172.反転Y = true;
								}
							}
							foreach (EleD eleD173 in 多足_蠍D.節足左4_接続)
							{
								if (eleD173 is 節足_足蠍D)
								{
									節足_足蠍D = (節足_足蠍D)eleD173;
									節足_足蠍D.柄1_表示 = 柄1_表示2;
									節足_足蠍D.爪 = 爪2;
								}
								else if (eleD173 is 節足_足百D)
								{
									eleD173.反転Y = true;
								}
							}
							foreach (EleD eleD174 in 多足_蠍D.節足右4_接続)
							{
								if (eleD174 is 節足_足蠍D)
								{
									節足_足蠍D = (節足_足蠍D)eleD174;
									節足_足蠍D.柄1_表示 = 柄1_表示2;
									節足_足蠍D.爪 = 爪2;
								}
								else if (eleD174 is 節足_足百D)
								{
									eleD174.反転Y = true;
								}
							}
							腰.翼左_接続.RemoveAll((EleD e) => e is 四足脇D);
							腰.翼右_接続.RemoveAll((EleD e) => e is 四足脇D);
							return;
						}
						if (半身 is 単足_植D)
						{
							単足_植D e9 = (単足_植D)半身;
							e9.接続(母方, 父方, i, 接続情報.単足_植_根外左_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
							e9.接続(母方, 父方, i, 接続情報.単足_植_根内左_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
							e9.接続(母方, 父方, i, 接続情報.単足_植_根中央_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
							腰.接続(母方, 父方, i, 接続情報.腰_腿左_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
							for (int num27 = 腰.腿左_接続.Count - 1; num27 > -1; num27--)
							{
								if (!(腰.腿左_接続[num27] is 触手_犬D))
								{
									腰.腿左_接続.RemoveAt(num27);
								}
							}
							for (int num28 = 腰.腿右_接続.Count - 1; num28 > -1; num28--)
							{
								if (!(腰.腿右_接続[num28] is 触手_犬D))
								{
									腰.腿右_接続.RemoveAt(num28);
								}
							}
							if (腰.腿左_接続.IsEleD<触手_犬D>())
							{
								for (int num29 = 腰.翼左_接続.Count - 1; num29 > -1; num29--)
								{
									if (腰.翼左_接続[num29] is 四足脇D)
									{
										腰.翼左_接続.RemoveAt(num29);
									}
								}
								for (int num30 = 腰.翼右_接続.Count - 1; num30 > -1; num30--)
								{
									if (腰.翼右_接続[num30] is 四足脇D)
									{
										腰.翼右_接続.RemoveAt(num30);
									}
								}
							}
							腿_人D 腿_人D = 交配.Mix<腿_人D>(母方, 父方, false, i, 原種モ\u30FCド);
							if (腿_人D != null)
							{
								腰.腿左接続(腿_人D);
								腰.腿右接続(腿_人D.Get逆());
							}
							腰.接続(母方, 父方, i, 接続情報.腰_尾_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
							return;
						}
						if (半身 is 単足_粘D)
						{
							単足_粘D 単足_粘D = (単足_粘D)半身;
							腰.接続(母方, 父方, i, 接続情報.腰_腿左_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
							for (int num31 = 腰.腿左_接続.Count - 1; num31 > -1; num31--)
							{
								if (!(腰.腿左_接続[num31] is 触手_犬D))
								{
									腰.腿左_接続.RemoveAt(num31);
								}
							}
							for (int num32 = 腰.腿右_接続.Count - 1; num32 > -1; num32--)
							{
								if (!(腰.腿右_接続[num32] is 触手_犬D))
								{
									腰.腿右_接続.RemoveAt(num32);
								}
							}
							if (腰.腿左_接続.IsEleD<触手_犬D>())
							{
								for (int num33 = 腰.翼左_接続.Count - 1; num33 > -1; num33--)
								{
									if (腰.翼左_接続[num33] is 四足脇D)
									{
										腰.翼左_接続.RemoveAt(num33);
									}
								}
								for (int num34 = 腰.翼右_接続.Count - 1; num34 > -1; num34--)
								{
									if (腰.翼右_接続[num34] is 四足脇D)
									{
										腰.翼右_接続.RemoveAt(num34);
									}
								}
							}
							腿_人D 腿_人D2 = 交配.Mix<腿_人D>(母方, 父方, false, i, 原種モ\u30FCド);
							if (腿_人D2 != null)
							{
								腰.腿左接続(腿_人D2);
								腰.腿右接続(腿_人D2.Get逆());
							}
							腰.接続(母方, 父方, i, 接続情報.腰_尾_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
						}
					}
				}
			};
			Action action2 = delegate()
			{
				腰.接続(母方, 父方, i, 接続情報.腰_腿左_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
				腰.接続(母方, 父方, i, 接続情報.腰_尾_接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド);
			};
			if (半身 != null)
			{
				if (原種モ\u30FCド || OthN.XS.NextBool() || 半身 is 単足_植D || 半身 is 単足_粘D)
				{
					action();
				}
				else
				{
					action2();
					腿D eleD4 = 腰.腿左_接続.GetEleD<腿D>();
					if (eleD4 == null || eleD4.EnumEleD().Count<EleD>() == 1 || 腰.翼左_接続.IsEleD<四足脇D>())
					{
						腰.腿左_接続.Clear();
						腰.腿右_接続.Clear();
						腰.尾_接続.Clear();
						action();
					}
				}
			}
			else
			{
				action2();
			}
			bool flag3 = false;
			顔面D 顔面D = null;
			foreach (EleD eleD5 in 腰.EnumEleD())
			{
				if (顔面D == null && eleD5 is 顔面D)
				{
					顔面D = (顔面D)eleD5;
				}
				else if (eleD5 is 尾_魚D)
				{
					尾_魚D 尾_魚D = (尾_魚D)eleD5;
					double num = 尾_魚D.尺度B;
					for (int i2 = 0; i2 < 7; i2++)
					{
						num *= 0.9;
					}
					foreach (EleD eleD6 in 尾_魚D.左1_接続)
					{
						eleD6.尺度B = num;
					}
					foreach (EleD eleD7 in 尾_魚D.右1_接続)
					{
						eleD7.尺度B = num;
					}
					num *= 0.9;
					foreach (EleD eleD8 in 尾_魚D.左2_接続)
					{
						eleD8.尺度B = num;
					}
					foreach (EleD eleD9 in 尾_魚D.右2_接続)
					{
						eleD9.尺度B = num;
					}
					num *= 0.9;
					foreach (EleD eleD10 in 尾_魚D.左3_接続)
					{
						eleD10.尺度B = num;
					}
					foreach (EleD eleD11 in 尾_魚D.右3_接続)
					{
						eleD11.尺度B = num;
					}
					num *= 0.9;
					foreach (EleD eleD12 in 尾_魚D.左4_接続)
					{
						eleD12.尺度B = num;
					}
					foreach (EleD eleD13 in 尾_魚D.右4_接続)
					{
						eleD13.尺度B = num;
					}
					num *= 0.9;
					foreach (EleD eleD14 in 尾_魚D.左5_接続)
					{
						eleD14.尺度B = num;
					}
					foreach (EleD eleD15 in 尾_魚D.右5_接続)
					{
						eleD15.尺度B = num;
					}
					num *= 0.9;
					foreach (EleD eleD16 in 尾_魚D.左6_接続)
					{
						eleD16.尺度B = num;
					}
					foreach (EleD eleD17 in 尾_魚D.右6_接続)
					{
						eleD17.尺度B = num;
					}
					num *= 0.9;
					foreach (EleD eleD18 in 尾_魚D.左7_接続)
					{
						eleD18.尺度B = num;
					}
					foreach (EleD eleD19 in 尾_魚D.右7_接続)
					{
						eleD19.尺度B = num;
					}
					num *= 0.9;
					foreach (EleD eleD20 in 尾_魚D.左8_接続)
					{
						eleD20.尺度B = num;
					}
					foreach (EleD eleD21 in 尾_魚D.右8_接続)
					{
						eleD21.尺度B = num;
					}
					num *= 0.9;
					foreach (EleD eleD22 in 尾_魚D.左9_接続)
					{
						eleD22.尺度B = num;
					}
					foreach (EleD eleD23 in 尾_魚D.右9_接続)
					{
						eleD23.尺度B = num;
					}
					num *= 0.9;
					foreach (EleD eleD24 in 尾_魚D.左10_接続)
					{
						eleD24.尺度B = num;
					}
					foreach (EleD eleD25 in 尾_魚D.右10_接続)
					{
						eleD25.尺度B = num;
					}
					num *= 0.9;
					foreach (EleD eleD26 in 尾_魚D.左11_接続)
					{
						eleD26.尺度B = num;
					}
					foreach (EleD eleD27 in 尾_魚D.右11_接続)
					{
						eleD27.尺度B = num;
					}
					num *= 0.9;
					foreach (EleD eleD28 in 尾_魚D.左12_接続)
					{
						eleD28.尺度B = num;
					}
					foreach (EleD eleD29 in 尾_魚D.右12_接続)
					{
						eleD29.尺度B = num;
					}
					num *= 0.9;
					foreach (EleD eleD30 in 尾_魚D.左13_接続)
					{
						eleD30.尺度B = num;
					}
					foreach (EleD eleD31 in 尾_魚D.右13_接続)
					{
						eleD31.尺度B = num;
					}
					num *= 0.9;
					foreach (EleD eleD32 in 尾_魚D.左14_接続)
					{
						eleD32.尺度B = num;
					}
					foreach (EleD eleD33 in 尾_魚D.右14_接続)
					{
						eleD33.尺度B = num;
					}
					num *= 0.9;
					foreach (EleD eleD34 in 尾_魚D.左15_接続)
					{
						eleD34.尺度B = num;
					}
					foreach (EleD eleD35 in 尾_魚D.右15_接続)
					{
						eleD35.尺度B = num;
					}
					num *= 0.9;
					foreach (EleD eleD36 in 尾_魚D.左16_接続)
					{
						eleD36.尺度B = num;
					}
					foreach (EleD eleD37 in 尾_魚D.右16_接続)
					{
						eleD37.尺度B = num;
					}
					num *= 0.9;
					foreach (EleD eleD38 in 尾_魚D.左17_接続)
					{
						eleD38.尺度B = num;
					}
					foreach (EleD eleD39 in 尾_魚D.右17_接続)
					{
						eleD39.尺度B = num;
					}
					num *= 0.9;
					foreach (EleD eleD40 in 尾_魚D.左18_接続)
					{
						eleD40.尺度B = num;
					}
					foreach (EleD eleD41 in 尾_魚D.右18_接続)
					{
						eleD41.尺度B = num;
					}
					num *= 0.9;
					foreach (EleD eleD42 in 尾_魚D.左19_接続)
					{
						eleD42.尺度B = num;
					}
					foreach (EleD eleD43 in 尾_魚D.右19_接続)
					{
						eleD43.尺度B = num;
					}
					num *= 0.9;
					foreach (EleD eleD44 in 尾_魚D.左20_接続)
					{
						eleD44.尺度B = num;
					}
					foreach (EleD eleD45 in 尾_魚D.右20_接続)
					{
						eleD45.尺度B = num;
					}
					num *= 0.9;
					foreach (EleD eleD46 in 尾_魚D.左21_接続)
					{
						eleD46.尺度B = num;
					}
					foreach (EleD eleD47 in 尾_魚D.右21_接続)
					{
						eleD47.尺度B = num;
					}
					num *= 0.9;
					foreach (EleD eleD48 in 尾_魚D.左22_接続)
					{
						eleD48.尺度B = num;
					}
					foreach (EleD eleD49 in 尾_魚D.右22_接続)
					{
						eleD49.尺度B = num;
					}
					num *= 0.9;
					foreach (EleD eleD50 in 尾_魚D.左23_接続)
					{
						eleD50.尺度B = num;
					}
					foreach (EleD eleD51 in 尾_魚D.右23_接続)
					{
						eleD51.尺度B = num;
					}
					num *= 0.9;
					foreach (EleD eleD52 in 尾_魚D.左24_接続)
					{
						eleD52.尺度B = num;
					}
					foreach (EleD eleD53 in 尾_魚D.右24_接続)
					{
						eleD53.尺度B = num;
					}
					num *= 0.9;
					foreach (EleD eleD54 in 尾_魚D.左25_接続)
					{
						eleD54.尺度B = num;
					}
					foreach (EleD eleD55 in 尾_魚D.右25_接続)
					{
						eleD55.尺度B = num;
					}
					num *= 0.9;
					foreach (EleD eleD56 in 尾_魚D.左27_接続)
					{
						eleD56.尺度B = num;
					}
					foreach (EleD eleD57 in 尾_魚D.右27_接続)
					{
						eleD57.尺度B = num;
					}
					num *= 0.9;
					foreach (EleD eleD58 in 尾_魚D.左28_接続)
					{
						eleD58.尺度B = num;
					}
					foreach (EleD eleD59 in 尾_魚D.右28_接続)
					{
						eleD59.尺度B = num;
					}
					num *= 0.9;
					foreach (EleD eleD60 in 尾_魚D.左29_接続)
					{
						eleD60.尺度B = num;
					}
					foreach (EleD eleD61 in 尾_魚D.右29_接続)
					{
						eleD61.尺度B = num;
					}
					num *= 0.9;
					foreach (EleD eleD62 in 尾_魚D.左30_接続)
					{
						eleD62.尺度B = num;
					}
					foreach (EleD eleD63 in 尾_魚D.右30_接続)
					{
						eleD63.尺度B = num;
					}
					num *= 0.9;
					foreach (EleD eleD64 in 尾_魚D.左31_接続)
					{
						eleD64.尺度B = num;
					}
					foreach (EleD eleD65 in 尾_魚D.右31_接続)
					{
						eleD65.尺度B = num;
					}
					num *= 0.9;
					foreach (EleD eleD66 in 尾_魚D.左32_接続)
					{
						eleD66.尺度B = num;
					}
					foreach (EleD eleD67 in 尾_魚D.右32_接続)
					{
						eleD67.尺度B = num;
					}
					num *= 0.9;
					foreach (EleD eleD68 in 尾_魚D.左33_接続)
					{
						eleD68.尺度B = num;
					}
					foreach (EleD eleD69 in 尾_魚D.右33_接続)
					{
						eleD69.尺度B = num;
					}
					num *= 0.9;
					foreach (EleD eleD70 in 尾_魚D.左34_接続)
					{
						eleD70.尺度B = num;
					}
					foreach (EleD eleD71 in 尾_魚D.右34_接続)
					{
						eleD71.尺度B = num;
					}
					if (eleD5.接続情報 != 接続情報.腰_腿左_接続 && eleD5.接続情報 != 接続情報.腰_腿右_接続)
					{
						尾_魚D.尾0_表示 = true;
						尾_魚D.尾0_鱗右_鱗1_表示 = true;
						尾_魚D.尾0_鱗右_鱗2_表示 = true;
					}
					else
					{
						尾_魚D.尾0_表示 = false;
						尾_魚D.尾0_鱗右_鱗1_表示 = false;
						尾_魚D.尾0_鱗右_鱗2_表示 = false;
					}
				}
				else
				{
					if (eleD5 is 尾_鯨D)
					{
						尾_鯨D 尾_鯨D = (尾_鯨D)eleD5;
						double num2 = 尾_鯨D.尺度B;
						for (int j = 0; j < 7; j++)
						{
							num2 *= 0.9;
						}
						foreach (EleD eleD72 in 尾_鯨D.左1_接続)
						{
							eleD72.尺度B = num2;
						}
						foreach (EleD eleD73 in 尾_鯨D.右1_接続)
						{
							eleD73.尺度B = num2;
						}
						num2 *= 0.9;
						foreach (EleD eleD74 in 尾_鯨D.左2_接続)
						{
							eleD74.尺度B = num2;
						}
						foreach (EleD eleD75 in 尾_鯨D.右2_接続)
						{
							eleD75.尺度B = num2;
						}
						num2 *= 0.9;
						foreach (EleD eleD76 in 尾_鯨D.左3_接続)
						{
							eleD76.尺度B = num2;
						}
						foreach (EleD eleD77 in 尾_鯨D.右3_接続)
						{
							eleD77.尺度B = num2;
						}
						num2 *= 0.9;
						foreach (EleD eleD78 in 尾_鯨D.左4_接続)
						{
							eleD78.尺度B = num2;
						}
						foreach (EleD eleD79 in 尾_鯨D.右4_接続)
						{
							eleD79.尺度B = num2;
						}
						num2 *= 0.9;
						foreach (EleD eleD80 in 尾_鯨D.左5_接続)
						{
							eleD80.尺度B = num2;
						}
						foreach (EleD eleD81 in 尾_鯨D.右5_接続)
						{
							eleD81.尺度B = num2;
						}
						num2 *= 0.9;
						foreach (EleD eleD82 in 尾_鯨D.左6_接続)
						{
							eleD82.尺度B = num2;
						}
						foreach (EleD eleD83 in 尾_鯨D.右6_接続)
						{
							eleD83.尺度B = num2;
						}
						num2 *= 0.9;
						foreach (EleD eleD84 in 尾_鯨D.左7_接続)
						{
							eleD84.尺度B = num2;
						}
						foreach (EleD eleD85 in 尾_鯨D.右7_接続)
						{
							eleD85.尺度B = num2;
						}
						num2 *= 0.9;
						foreach (EleD eleD86 in 尾_鯨D.左8_接続)
						{
							eleD86.尺度B = num2;
						}
						foreach (EleD eleD87 in 尾_鯨D.右8_接続)
						{
							eleD87.尺度B = num2;
						}
						num2 *= 0.9;
						foreach (EleD eleD88 in 尾_鯨D.左9_接続)
						{
							eleD88.尺度B = num2;
						}
						foreach (EleD eleD89 in 尾_鯨D.右9_接続)
						{
							eleD89.尺度B = num2;
						}
						num2 *= 0.9;
						foreach (EleD eleD90 in 尾_鯨D.左10_接続)
						{
							eleD90.尺度B = num2;
						}
						foreach (EleD eleD91 in 尾_鯨D.右10_接続)
						{
							eleD91.尺度B = num2;
						}
						num2 *= 0.9;
						foreach (EleD eleD92 in 尾_鯨D.左11_接続)
						{
							eleD92.尺度B = num2;
						}
						foreach (EleD eleD93 in 尾_鯨D.右11_接続)
						{
							eleD93.尺度B = num2;
						}
						num2 *= 0.9;
						foreach (EleD eleD94 in 尾_鯨D.左12_接続)
						{
							eleD94.尺度B = num2;
						}
						foreach (EleD eleD95 in 尾_鯨D.右12_接続)
						{
							eleD95.尺度B = num2;
						}
						num2 *= 0.9;
						foreach (EleD eleD96 in 尾_鯨D.左13_接続)
						{
							eleD96.尺度B = num2;
						}
						foreach (EleD eleD97 in 尾_鯨D.右13_接続)
						{
							eleD97.尺度B = num2;
						}
						num2 *= 0.9;
						foreach (EleD eleD98 in 尾_鯨D.左14_接続)
						{
							eleD98.尺度B = num2;
						}
						foreach (EleD eleD99 in 尾_鯨D.右14_接続)
						{
							eleD99.尺度B = num2;
						}
						num2 *= 0.9;
						foreach (EleD eleD100 in 尾_鯨D.左15_接続)
						{
							eleD100.尺度B = num2;
						}
						foreach (EleD eleD101 in 尾_鯨D.右15_接続)
						{
							eleD101.尺度B = num2;
						}
						num2 *= 0.9;
						foreach (EleD eleD102 in 尾_鯨D.左16_接続)
						{
							eleD102.尺度B = num2;
						}
						foreach (EleD eleD103 in 尾_鯨D.右16_接続)
						{
							eleD103.尺度B = num2;
						}
						num2 *= 0.9;
						foreach (EleD eleD104 in 尾_鯨D.左17_接続)
						{
							eleD104.尺度B = num2;
						}
						foreach (EleD eleD105 in 尾_鯨D.右17_接続)
						{
							eleD105.尺度B = num2;
						}
						num2 *= 0.9;
						foreach (EleD eleD106 in 尾_鯨D.左18_接続)
						{
							eleD106.尺度B = num2;
						}
						foreach (EleD eleD107 in 尾_鯨D.右18_接続)
						{
							eleD107.尺度B = num2;
						}
						num2 *= 0.9;
						foreach (EleD eleD108 in 尾_鯨D.左19_接続)
						{
							eleD108.尺度B = num2;
						}
						foreach (EleD eleD109 in 尾_鯨D.右19_接続)
						{
							eleD109.尺度B = num2;
						}
						num2 *= 0.9;
						foreach (EleD eleD110 in 尾_鯨D.左20_接続)
						{
							eleD110.尺度B = num2;
						}
						foreach (EleD eleD111 in 尾_鯨D.右20_接続)
						{
							eleD111.尺度B = num2;
						}
						num2 *= 0.9;
						foreach (EleD eleD112 in 尾_鯨D.左21_接続)
						{
							eleD112.尺度B = num2;
						}
						foreach (EleD eleD113 in 尾_鯨D.右21_接続)
						{
							eleD113.尺度B = num2;
						}
						num2 *= 0.9;
						foreach (EleD eleD114 in 尾_鯨D.左22_接続)
						{
							eleD114.尺度B = num2;
						}
						foreach (EleD eleD115 in 尾_鯨D.右22_接続)
						{
							eleD115.尺度B = num2;
						}
						num2 *= 0.9;
						foreach (EleD eleD116 in 尾_鯨D.左23_接続)
						{
							eleD116.尺度B = num2;
						}
						foreach (EleD eleD117 in 尾_鯨D.右23_接続)
						{
							eleD117.尺度B = num2;
						}
						num2 *= 0.9;
						foreach (EleD eleD118 in 尾_鯨D.左24_接続)
						{
							eleD118.尺度B = num2;
						}
						foreach (EleD eleD119 in 尾_鯨D.右24_接続)
						{
							eleD119.尺度B = num2;
						}
						num2 *= 0.9;
						foreach (EleD eleD120 in 尾_鯨D.左25_接続)
						{
							eleD120.尺度B = num2;
						}
						foreach (EleD eleD121 in 尾_鯨D.右25_接続)
						{
							eleD121.尺度B = num2;
						}
						num2 *= 0.9;
						foreach (EleD eleD122 in 尾_鯨D.左27_接続)
						{
							eleD122.尺度B = num2;
						}
						foreach (EleD eleD123 in 尾_鯨D.右27_接続)
						{
							eleD123.尺度B = num2;
						}
						num2 *= 0.9;
						foreach (EleD eleD124 in 尾_鯨D.左28_接続)
						{
							eleD124.尺度B = num2;
						}
						foreach (EleD eleD125 in 尾_鯨D.右28_接続)
						{
							eleD125.尺度B = num2;
						}
						num2 *= 0.9;
						foreach (EleD eleD126 in 尾_鯨D.左29_接続)
						{
							eleD126.尺度B = num2;
						}
						foreach (EleD eleD127 in 尾_鯨D.右29_接続)
						{
							eleD127.尺度B = num2;
						}
						num2 *= 0.9;
						foreach (EleD eleD128 in 尾_鯨D.左30_接続)
						{
							eleD128.尺度B = num2;
						}
						foreach (EleD eleD129 in 尾_鯨D.右30_接続)
						{
							eleD129.尺度B = num2;
						}
						num2 *= 0.9;
						foreach (EleD eleD130 in 尾_鯨D.左31_接続)
						{
							eleD130.尺度B = num2;
						}
						foreach (EleD eleD131 in 尾_鯨D.右31_接続)
						{
							eleD131.尺度B = num2;
						}
						num2 *= 0.9;
						foreach (EleD eleD132 in 尾_鯨D.左32_接続)
						{
							eleD132.尺度B = num2;
						}
						foreach (EleD eleD133 in 尾_鯨D.右32_接続)
						{
							eleD133.尺度B = num2;
						}
						num2 *= 0.9;
						foreach (EleD eleD134 in 尾_鯨D.左33_接続)
						{
							eleD134.尺度B = num2;
						}
						foreach (EleD eleD135 in 尾_鯨D.右33_接続)
						{
							eleD135.尺度B = num2;
						}
						num2 *= 0.9;
						foreach (EleD eleD136 in 尾_鯨D.左34_接続)
						{
							eleD136.尺度B = num2;
						}
						using (List<EleD>.Enumerator enumerator2 = 尾_鯨D.右34_接続.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								EleD eleD137 = enumerator2.Current;
								eleD137.尺度B = num2;
							}
							goto IL_3B31;
						}
					}
					if (eleD5 is 触手_蔦D)
					{
						触手_蔦D 触手_蔦D = (触手_蔦D)eleD5;
						double num3 = 触手_蔦D.尺度B;
						foreach (EleD eleD138 in 触手_蔦D.節3_接続)
						{
							eleD138.尺度B = num3;
						}
						num3 *= 原種.葉倍率;
						foreach (EleD eleD139 in 触手_蔦D.節5_接続)
						{
							eleD139.尺度B = num3;
						}
						num3 *= 原種.葉倍率;
						foreach (EleD eleD140 in 触手_蔦D.節7_接続)
						{
							eleD140.尺度B = num3;
						}
						num3 *= 原種.葉倍率;
						foreach (EleD eleD141 in 触手_蔦D.節9_接続)
						{
							eleD141.尺度B = num3;
						}
						num3 *= 原種.葉倍率;
						foreach (EleD eleD142 in 触手_蔦D.節11_接続)
						{
							eleD142.尺度B = num3;
						}
						num3 *= 原種.葉倍率;
						foreach (EleD eleD143 in 触手_蔦D.節13_接続)
						{
							eleD143.尺度B = num3;
						}
						num3 *= 原種.葉倍率;
						foreach (EleD eleD144 in 触手_蔦D.節15_接続)
						{
							eleD144.尺度B = num3;
						}
						num3 *= 原種.葉倍率;
						foreach (EleD eleD145 in 触手_蔦D.節17_接続)
						{
							eleD145.尺度B = num3;
						}
						num3 *= 原種.葉倍率;
						using (List<EleD>.Enumerator enumerator2 = 触手_蔦D.節19_接続.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								EleD eleD146 = enumerator2.Current;
								eleD146.尺度B = num3;
							}
							goto IL_3B31;
						}
					}
					if (eleD5 is 触手_軟D)
					{
						((触手_軟D)eleD5).節1_鎧_表示 = false;
					}
					else if (eleD5 is 触手_犬D)
					{
						触手_犬D 触手_犬D = (触手_犬D)eleD5;
						bool flag4 = 触手_犬D.脚後_鰭_鰭膜1_表示 || 触手_犬D.脚後_鰭_鰭条1_表示 || 触手_犬D.脚後_鰭_鰭膜2_表示 || 触手_犬D.脚後_鰭_鰭条2_表示 || 触手_犬D.脚後_鰭_鰭膜3_表示;
						触手_犬D.脚後_鰭_鰭膜1_表示 = flag4;
						触手_犬D.脚後_鰭_鰭条1_表示 = flag4;
						触手_犬D.脚後_鰭_鰭膜2_表示 = flag4;
						触手_犬D.脚後_鰭_鰭条2_表示 = flag4;
						触手_犬D.脚後_鰭_鰭膜3_表示 = flag4;
						触手_犬D.脚前_鰭_鰭膜1_表示 = flag4;
						触手_犬D.脚前_鰭_鰭条1_表示 = flag4;
						触手_犬D.脚前_鰭_鰭膜2_表示 = flag4;
						触手_犬D.脚前_鰭_鰭条2_表示 = flag4;
						触手_犬D.脚前_鰭_鰭膜3_表示 = flag4;
					}
					else if (eleD5 is 背中_光D || eleD5 is 頭頂_天D)
					{
						eleD5.尺度YB = 1.0;
					}
					else if (eleD5 is 上腕_蝙D && (eleD5.接続情報 == 接続情報.基髪_頭頂左_接続 || eleD5.接続情報 == 接続情報.基髪_頭頂右_接続))
					{
						((上腕_蝙D)eleD5).竜性_鱗1_表示 = false;
					}
					else if (eleD5 is 上腕D && eleD5.Par is 肩D)
					{
						eleD5.AlignR();
					}
				}
				IL_3B31:
				if (!flag3)
				{
					flag3 |= eleD5.筋肉;
				}
			}
			if (頭D.額_接続.Count > 1)
			{
				頭D.額_接続.Remove(頭D.額_接続[OthN.XS.Next(頭D.額_接続.Count)]);
			}
			bool flag5 = false;
			flag5 |= 胸腹板D.虫性_腹板_表示;
			flag5 |= 胴腹板D.虫性_腹板_表示;
			flag5 |= (腰肌.虫性_腹板1_腹板_表示 || 腰肌.虫性_腹板2_腹板_表示);
			bool flag6 = false;
			flag6 |= 胸腹板D.虫性_縦線_表示;
			flag6 |= 胴腹板D.虫性_縦線_表示;
			flag6 |= (腰肌.虫性_腹板1_縦線_表示 || 腰肌.虫性_腹板2_縦線_表示);
			flag6 = (flag6 && flag5);
			if (flag6)
			{
				flag6 = OthN.XS.NextBool();
			}
			胸腹板D.虫性_腹板_表示 = flag5;
			胸腹板D.虫性_縦線_表示 = flag6;
			胴腹板D.虫性_腹板_表示 = flag5;
			胴腹板D.虫性_縦線_表示 = flag6;
			腰肌.虫性_腹板1_腹板_表示 = flag5;
			腰肌.虫性_腹板2_腹板_表示 = flag5;
			腰肌.虫性_腹板1_縦線_表示 = flag6;
			腰肌.虫性_腹板2_縦線_表示 = flag6;
			if (OthN.XS.NextBool())
			{
				bool flag7 = false;
				bool flag8 = true;
				bool flag9 = false;
				if (双目D != null)
				{
					flag7 |= 双目D.蛸目;
					flag8 &= 双目D.黒目_瞳孔_表示;
					flag9 |= 双目D.猫目;
				}
				if (双目D2 != null)
				{
					flag7 |= 双目D2.蛸目;
					flag8 &= 双目D2.黒目_瞳孔_表示;
					flag9 |= 双目D2.猫目;
				}
				if (頬目D != null)
				{
					flag7 |= 頬目D.蛸目;
					flag8 &= 頬目D.黒目_瞳孔_表示;
					flag9 |= 頬目D.猫目;
				}
				if (頬目D2 != null)
				{
					flag7 |= 頬目D2.蛸目;
					flag8 &= 頬目D2.黒目_瞳孔_表示;
					flag9 |= 頬目D2.猫目;
				}
				if (縦目D != null)
				{
					flag7 |= 縦目D.蛸目;
					flag8 &= 縦目D.黒目_瞳孔_表示;
					flag9 |= 縦目D.猫目;
				}
				if (単目D != null)
				{
					flag7 |= 単目D.蛸目;
					flag8 &= 単目D.黒目_瞳孔_表示;
					flag9 |= 単目D.猫目;
				}
				bool flag10 = OthN.XS.NextBool();
				bool flag11 = OthN.XS.NextBool();
				bool flag12 = OthN.XS.NextBool();
				if (双目D != null)
				{
					双目D.蛸目 = (flag10 ? flag7 : 双目D.蛸目);
					双目D.黒目_瞳孔_表示 = (flag11 ? flag8 : 双目D.黒目_瞳孔_表示);
					双目D.猫目 = (flag12 ? flag9 : 双目D.猫目);
				}
				if (双目D2 != null)
				{
					双目D2.蛸目 = (flag10 ? flag7 : 双目D2.蛸目);
					双目D2.黒目_瞳孔_表示 = (flag11 ? flag8 : 双目D2.黒目_瞳孔_表示);
					双目D2.猫目 = (flag12 ? flag9 : 双目D2.猫目);
				}
				if (頬目D != null)
				{
					頬目D.蛸目 = (flag10 ? flag7 : 頬目D.蛸目);
					頬目D.黒目_瞳孔_表示 = (flag11 ? flag8 : 頬目D.黒目_瞳孔_表示);
					頬目D.猫目 = (flag12 ? flag9 : 頬目D.猫目);
				}
				if (頬目D2 != null)
				{
					頬目D2.蛸目 = (flag10 ? flag7 : 頬目D2.蛸目);
					頬目D2.黒目_瞳孔_表示 = (flag11 ? flag8 : 頬目D2.黒目_瞳孔_表示);
					頬目D2.猫目 = (flag12 ? flag9 : 頬目D2.猫目);
				}
				if (縦目D != null)
				{
					縦目D.蛸目 = (flag10 ? flag7 : 縦目D.蛸目);
					縦目D.黒目_瞳孔_表示 = (flag11 ? flag8 : 縦目D.黒目_瞳孔_表示);
					縦目D.猫目 = (flag12 ? flag9 : 縦目D.猫目);
				}
				if (単目D != null)
				{
					単目D.蛸目 = (flag10 ? flag7 : 単目D.蛸目);
					単目D.黒目_瞳孔_表示 = (flag11 ? flag8 : 単目D.黒目_瞳孔_表示);
					単目D.猫目 = (flag12 ? flag9 : 単目D.猫目);
				}
			}
			if (単目D != null)
			{
				鼻肌D.紋柄_紋左_紋1_表示 = false;
				鼻肌D.紋柄_紋左_紋2_表示 = false;
				鼻肌D.紋柄_紋左_紋3_表示 = false;
				鼻肌D.紋柄_紋左_紋4_表示 = false;
				鼻肌D.紋柄_紋右_紋1_表示 = false;
				鼻肌D.紋柄_紋右_紋2_表示 = false;
				鼻肌D.紋柄_紋右_紋3_表示 = false;
				鼻肌D.紋柄_紋右_紋4_表示 = false;
			}
			bool flag13 = 顔面D != null && 顔面D.触覚左_接続.IsEleD<触覚D>();
			bool flag14 = 頭D.触覚左_接続.IsEleD<触覚D>();
			bool flag15 = 基髪D.頭頂左_接続.IsEleD<触覚D>();
			if (!flag13 && flag14 && flag15)
			{
				if (OthN.XS.NextBool())
				{
					頭D.触覚左_接続.RemoveAll((EleD e) => e is 触覚D);
					頭D.触覚右_接続.RemoveAll((EleD e) => e is 触覚D);
				}
				else
				{
					基髪D.頭頂左_接続.RemoveAll((EleD e) => e is 触覚D);
					基髪D.頭頂右_接続.RemoveAll((EleD e) => e is 触覚D);
				}
			}
			else if (flag13 && !flag14 && flag15)
			{
				if (OthN.XS.NextBool())
				{
					顔面D.触覚左_接続.RemoveAll((EleD e) => e is 触覚D);
					顔面D.触覚右_接続.RemoveAll((EleD e) => e is 触覚D);
				}
				else
				{
					基髪D.頭頂左_接続.RemoveAll((EleD e) => e is 触覚D);
					基髪D.頭頂右_接続.RemoveAll((EleD e) => e is 触覚D);
				}
			}
			else if (flag13 && flag14 && !flag15)
			{
				if (OthN.XS.NextBool())
				{
					顔面D.触覚左_接続.RemoveAll((EleD e) => e is 触覚D);
					顔面D.触覚右_接続.RemoveAll((EleD e) => e is 触覚D);
				}
				else
				{
					頭D.触覚左_接続.RemoveAll((EleD e) => e is 触覚D);
					頭D.触覚右_接続.RemoveAll((EleD e) => e is 触覚D);
				}
			}
			else if (flag13 && flag14 && flag15)
			{
				switch (OthN.XS.Next(2))
				{
				case 0:
					頭D.触覚左_接続.RemoveAll((EleD e) => e is 触覚D);
					頭D.触覚右_接続.RemoveAll((EleD e) => e is 触覚D);
					基髪D.頭頂左_接続.RemoveAll((EleD e) => e is 触覚D);
					基髪D.頭頂右_接続.RemoveAll((EleD e) => e is 触覚D);
					break;
				case 1:
					顔面D.触覚左_接続.RemoveAll((EleD e) => e is 触覚D);
					顔面D.触覚右_接続.RemoveAll((EleD e) => e is 触覚D);
					基髪D.頭頂左_接続.RemoveAll((EleD e) => e is 触覚D);
					基髪D.頭頂右_接続.RemoveAll((EleD e) => e is 触覚D);
					break;
				case 2:
					顔面D.触覚左_接続.RemoveAll((EleD e) => e is 触覚D);
					顔面D.触覚右_接続.RemoveAll((EleD e) => e is 触覚D);
					頭D.触覚左_接続.RemoveAll((EleD e) => e is 触覚D);
					頭D.触覚右_接続.RemoveAll((EleD e) => e is 触覚D);
					break;
				}
			}
			if (顔面D != null && flag14)
			{
				foreach (触覚D e4 in 頭D.触覚左_接続.GetEleDs<触覚D>())
				{
					顔面D.触覚左接続(e4);
				}
				foreach (触覚D e5 in 頭D.触覚右_接続.GetEleDs<触覚D>())
				{
					顔面D.触覚右接続(e5);
				}
				頭D.触覚左_接続.RemoveAll((EleD e) => e is 触覚D);
				頭D.触覚右_接続.RemoveAll((EleD e) => e is 触覚D);
			}
			if (腰肌.陰毛_表示 && 腰肌.獣性_獣毛_表示)
			{
				if (OthN.XS.NextBool())
				{
					腰肌.陰毛_表示 = false;
				}
				else
				{
					腰肌.獣性_獣毛_表示 = false;
				}
			}
			if (縦瞼D != null)
			{
				if (OthN.XS.NextBool())
				{
					縦瞼D.瞼左_睫毛1_表示 = 縦瞼D.瞼右_睫毛1_表示;
					縦瞼D.瞼左_睫毛2_表示 = 縦瞼D.瞼右_睫毛2_表示;
				}
				else
				{
					縦瞼D.瞼右_睫毛1_表示 = 縦瞼D.瞼左_睫毛1_表示;
					縦瞼D.瞼右_睫毛2_表示 = 縦瞼D.瞼左_睫毛2_表示;
				}
				if (OthN.XS.NextBool())
				{
					縦瞼D.瞼左_睫毛1_長さ = 縦瞼D.瞼右_睫毛1_長さ;
					縦瞼D.瞼左_睫毛2_長さ = 縦瞼D.瞼右_睫毛2_長さ;
				}
				else
				{
					縦瞼D.瞼右_睫毛1_長さ = 縦瞼D.瞼左_睫毛1_長さ;
					縦瞼D.瞼右_睫毛2_長さ = 縦瞼D.瞼左_睫毛2_長さ;
				}
			}
			if (単瞼D != null)
			{
				if (OthN.XS.NextBool())
				{
					単瞼D.睫毛上上左_表示 = 単瞼D.睫毛上上右_表示;
					単瞼D.睫毛上中左_表示 = 単瞼D.睫毛上中右_表示;
					単瞼D.睫毛上下左_表示 = 単瞼D.睫毛上下右_表示;
					単瞼D.睫毛下上左_表示 = 単瞼D.睫毛下上右_表示;
					単瞼D.睫毛下下左_表示 = 単瞼D.睫毛下下右_表示;
				}
				else
				{
					単瞼D.睫毛上上右_表示 = 単瞼D.睫毛上上左_表示;
					単瞼D.睫毛上中右_表示 = 単瞼D.睫毛上中左_表示;
					単瞼D.睫毛上下右_表示 = 単瞼D.睫毛上下左_表示;
					単瞼D.睫毛下上右_表示 = 単瞼D.睫毛下上左_表示;
					単瞼D.睫毛下下右_表示 = 単瞼D.睫毛下下左_表示;
				}
				if (OthN.XS.NextBool())
				{
					単瞼D.睫毛上上左_長さ = 単瞼D.睫毛上上右_長さ;
					単瞼D.睫毛上中左_長さ = 単瞼D.睫毛上中右_長さ;
					単瞼D.睫毛上下左_長さ = 単瞼D.睫毛上下右_長さ;
					単瞼D.睫毛下上左_長さ = 単瞼D.睫毛下上右_長さ;
					単瞼D.睫毛下下左_長さ = 単瞼D.睫毛下下右_長さ;
				}
				else
				{
					単瞼D.睫毛上上右_長さ = 単瞼D.睫毛上上左_長さ;
					単瞼D.睫毛上中右_長さ = 単瞼D.睫毛上中左_長さ;
					単瞼D.睫毛上下右_長さ = 単瞼D.睫毛上下左_長さ;
					単瞼D.睫毛下上右_長さ = 単瞼D.睫毛下上左_長さ;
					単瞼D.睫毛下下右_長さ = 単瞼D.睫毛下下左_長さ;
				}
			}
			if ((腰肌.淫タトゥ_ハ\u30FCト_タトゥ右1_表示 || 腰肌.淫タトゥ_ハ\u30FCト_タトゥ右2_表示 || 腰肌.淫タトゥ_ハ\u30FCト_タトゥ左1_表示 || 腰肌.淫タトゥ_ハ\u30FCト_タトゥ左2_表示) && (腰肌.植タトゥ_タトゥ左_表示 || 腰肌.植タトゥ_タトゥ右_表示))
			{
				if (OthN.XS.NextBool())
				{
					腰肌.淫タトゥ_ハ\u30FCト_タトゥ右1_表示 = true;
					腰肌.淫タトゥ_ハ\u30FCト_タトゥ右2_表示 = true;
					腰肌.淫タトゥ_ハ\u30FCト_タトゥ左1_表示 = true;
					腰肌.淫タトゥ_ハ\u30FCト_タトゥ左2_表示 = true;
					腰肌.植タトゥ_タトゥ左_表示 = false;
					腰肌.植タトゥ_タトゥ右_表示 = false;
				}
				else
				{
					腰肌.淫タトゥ_ハ\u30FCト_タトゥ右1_表示 = false;
					腰肌.淫タトゥ_ハ\u30FCト_タトゥ右2_表示 = false;
					腰肌.淫タトゥ_ハ\u30FCト_タトゥ左1_表示 = false;
					腰肌.淫タトゥ_ハ\u30FCト_タトゥ左2_表示 = false;
					腰肌.植タトゥ_タトゥ左_表示 = true;
					腰肌.植タトゥ_タトゥ右_表示 = true;
				}
			}
			if (flag3)
			{
				腰.EnumEleD().SetValuesD("筋肉", true);
			}
			return 腰;
		}

		public static EleD GetEleD(this IEnumerable<EleD> src, Type t)
		{
			if (src == null)
			{
				return null;
			}
			return src.FirstOrDefault((EleD e) => e.GetType().IsAssignableFrom(t));
		}

		public static EleD GetEleD(this IEnumerable<EleD> src, bool 右, Type t)
		{
			if (src == null)
			{
				return null;
			}
			return src.FirstOrDefault((EleD e) => e.GetType().IsAssignableFrom(t) && e.右 == 右);
		}

		public static EleD GetEleD(this IEnumerable<EleD> src, Func<EleD, bool> con, Type t)
		{
			if (src == null)
			{
				return null;
			}
			return src.FirstOrDefault((EleD e) => e.GetType().IsAssignableFrom(t) && con(e));
		}

		private static void Dou<T>(this T e)
		{
			foreach (FieldInfo fieldInfo in e.GetType().GetFields())
			{
				if (fieldInfo.FieldType.ToString() == Sta.dt && 交配.実数対象.Contains(fieldInfo.Name))
				{
					fieldInfo.SetValue(e, ((double)fieldInfo.GetValue(e) + (double)OthN.XS.NextSign() * OthN.XS.NextDouble(0.15)).LimitM(0.0, 1.0));
				}
			}
		}

		private static void Dou<T>(this T e0, T e1)
		{
			int i = OthN.XS.Next(3);
			if (i == 0)
			{
				Type type = e1.GetType();
				foreach (FieldInfo fieldInfo in e0.GetType().GetFields())
				{
					if (fieldInfo.FieldType.ToString() == Sta.dt && 交配.実数対象.Contains(fieldInfo.Name))
					{
						FieldInfo field = type.GetField(fieldInfo.Name);
						if (field != null && field.FieldType.ToString() == Sta.dt)
						{
							fieldInfo.SetValue(e0, OthN.XS.NextBool() ? fieldInfo.GetValue(e0) : field.GetValue(e1));
						}
					}
				}
				return;
			}
			if (i != 1)
			{
				foreach (FieldInfo fieldInfo2 in e0.GetType().GetFields())
				{
					if (fieldInfo2.FieldType.ToString() == Sta.dt && 交配.実数対象.Contains(fieldInfo2.Name))
					{
						fieldInfo2.SetValue(e0, ((double)fieldInfo2.GetValue(e0) + (double)OthN.XS.NextSign() * OthN.XS.NextDouble(0.15)).LimitM(0.0, 1.0));
					}
				}
				return;
			}
			Type type2 = e1.GetType();
			foreach (FieldInfo fieldInfo3 in e0.GetType().GetFields())
			{
				if (fieldInfo3.FieldType.ToString() == Sta.dt && 交配.実数対象.Contains(fieldInfo3.Name))
				{
					FieldInfo field2 = type2.GetField(fieldInfo3.Name);
					if (field2 != null && field2.FieldType.ToString() == Sta.dt)
					{
						fieldInfo3.SetValue(e0, ((double)fieldInfo3.GetValue(e0) + (double)field2.GetValue(e1)) * 0.5);
					}
				}
			}
		}

		private static T Sub<T>(T e0, T e1) where T : EleD
		{
			object obj = e0.GetType().GetConstructor(交配.bi, Type.DefaultBinder, 交配.t0, null).Invoke(null);
			EleD eleD = e0.Copy_以下無();
			Type type = e1.GetType();
			foreach (FieldInfo fieldInfo in e0.GetType().GetFields())
			{
				if (fieldInfo.Name.EndsWith("_表示"))
				{
					FieldInfo field = type.GetField(fieldInfo.Name);
					if (field != null && field.FieldType.ToString() == Sta.bt)
					{
						bool flag;
						fieldInfo.SetValue(eleD, ((flag = (bool)fieldInfo.GetValue(e0)) && (bool)field.GetValue(e1)) ? fieldInfo.GetValue(obj) : flag);
					}
				}
			}
			return (T)((object)eleD);
		}

		private static T Syn<T>(T e0, T e1) where T : EleD
		{
			e0.GetType().GetConstructor(交配.bi, Type.DefaultBinder, 交配.t0, null).Invoke(null);
			EleD eleD = e0.Copy_以下無();
			Type type = e1.GetType();
			foreach (FieldInfo fieldInfo in e0.GetType().GetFields())
			{
				if (fieldInfo.Name.EndsWith("_表示"))
				{
					FieldInfo field = type.GetField(fieldInfo.Name);
					if (field != null && field.FieldType.ToString() == Sta.bt)
					{
						fieldInfo.SetValue(eleD, (bool)fieldInfo.GetValue(e0) || (bool)field.GetValue(e1));
					}
				}
			}
			return (T)((object)eleD);
		}

		private static T Mix<T>(T 母, T 父, int i, bool 原種モ\u30FCド) where T : EleD
		{
			T t = default(T);
			if (母 == null && 父 != null)
			{
				t = (T)((object)父.Copy_以下無());
				t.Dou<T>();
			}
			else if (母 != null && 父 == null)
			{
				t = (T)((object)母.Copy_以下無());
				t.Dou<T>();
			}
			else if (母 != null && 父 != null)
			{
				if (原種モ\u30FCド)
				{
					if (i != 0)
					{
						if (i != 1)
						{
							bool flag = OthN.XS.NextBool();
							t = (T)((object)(flag ? 母 : 父).Copy_以下無());
							t.Dou(flag ? 父 : 母);
						}
						else
						{
							t = (T)((object)父.Copy_以下無());
							t.Dou(母);
						}
					}
					else
					{
						t = (T)((object)母.Copy_以下無());
						t.Dou(父);
					}
				}
				else
				{
					switch (i)
					{
					case 0:
						t = (T)((object)母.Copy_以下無());
						t.Dou(父);
						break;
					case 1:
						t = (T)((object)父.Copy_以下無());
						t.Dou(母);
						break;
					case 2:
						t = 交配.Sub<T>(母, 父);
						t.Dou(父);
						break;
					case 3:
						t = 交配.Sub<T>(父, 母);
						t.Dou(母);
						break;
					case 4:
						t = 交配.Syn<T>(母, 父);
						t.Dou(父);
						break;
					case 5:
						t = 交配.Syn<T>(父, 母);
						t.Dou(母);
						break;
					default:
					{
						bool flag2 = OthN.XS.NextBool();
						t = (T)((object)(flag2 ? 母 : 父).Copy_以下無());
						t.Dou(flag2 ? 父 : 母);
						break;
					}
					}
				}
			}
			return t;
		}

		private static T Mix<T>(腰D 母方, 腰D 父方, int i, bool 原種モ\u30FCド) where T : EleD
		{
			T eleD = (from e in 母方.EnumEleD()
			orderby OthN.XS.Next()
			select e).GetEleD<T>();
			T eleD2 = (from e in 父方.EnumEleD()
			orderby OthN.XS.Next()
			select e).GetEleD<T>();
			return 交配.Mix<T>(eleD, eleD2, i, 原種モ\u30FCド);
		}

		private static T Mix<T>(腰D 母方, 腰D 父方, bool 右, int i, bool 原種モ\u30FCド) where T : EleD
		{
			T eleD = (from e in 母方.EnumEleD()
			orderby OthN.XS.Next()
			select e).GetEleD(右);
			T eleD2 = (from e in 父方.EnumEleD()
			orderby OthN.XS.Next()
			select e).GetEleD(右);
			return 交配.Mix<T>(eleD, eleD2, i, 原種モ\u30FCド);
		}

		private static T Mix<T>(腰D 母方, 腰D 父方, Func<T, bool> con, int i, bool 原種モ\u30FCド) where T : EleD
		{
			T eleD = (from e in 母方.EnumEleD()
			orderby OthN.XS.Next()
			select e).GetEleD(con);
			T eleD2 = (from e in 父方.EnumEleD()
			orderby OthN.XS.Next()
			select e).GetEleD(con);
			return 交配.Mix<T>(eleD, eleD2, i, 原種モ\u30FCド);
		}

		private static EleD Mix(腰D 母方, 腰D 父方, int i, Type t, bool 原種モ\u30FCド)
		{
			EleD eleD = (from e in 母方.EnumEleD()
			orderby OthN.XS.Next()
			select e).GetEleD(t);
			EleD eleD2 = (from e in 父方.EnumEleD()
			orderby OthN.XS.Next()
			select e).GetEleD(t);
			return 交配.Mix<EleD>(eleD, eleD2, i, 原種モ\u30FCド);
		}

		private static EleD Mix(腰D 母方, 腰D 父方, bool 右, int i, Type t, bool 原種モ\u30FCド)
		{
			EleD eleD = (from e in 母方.EnumEleD()
			orderby OthN.XS.Next()
			select e).GetEleD(右, t);
			EleD eleD2 = (from e in 父方.EnumEleD()
			orderby OthN.XS.Next()
			select e).GetEleD(右, t);
			return 交配.Mix<EleD>(eleD, eleD2, i, 原種モ\u30FCド);
		}

		private static EleD Mix(腰D 母方, 腰D 父方, Func<EleD, bool> con, int i, Type t, bool 原種モ\u30FCド)
		{
			EleD eleD = (from e in 母方.EnumEleD()
			orderby OthN.XS.Next()
			select e).GetEleD(con, t);
			EleD eleD2 = (from e in 父方.EnumEleD()
			orderby OthN.XS.Next()
			select e).GetEleD(con, t);
			return 交配.Mix<EleD>(eleD, eleD2, i, 原種モ\u30FCド);
		}

		public static void AlignR(this EleD e)
		{
			if (e != null)
			{
				foreach (FieldInfo fieldInfo in Sta.EleDt.GetFields())
				{
					if (fieldInfo.FieldType.ToString() == Sta.dt)
					{
						fieldInfo.SetValue(e, fieldInfo.GetValue(e.Par));
					}
				}
			}
		}

		public static void AlignC(this EleD e)
		{
			if (e != null)
			{
				foreach (EleD obj in e.EnumEleD())
				{
					foreach (FieldInfo fieldInfo in Sta.EleDt.GetFields())
					{
						if (fieldInfo.FieldType.ToString() == Sta.dt)
						{
							fieldInfo.SetValue(obj, fieldInfo.GetValue(e));
						}
					}
				}
			}
		}

		private static Dictionary<接続情報, List<Type>> Get接続構成(腰D 母方, 腰D 父方)
		{
			Dictionary<接続情報, List<Type>> dictionary = new Dictionary<接続情報, List<Type>>();
			foreach (EleD eleD in 母方.EnumEleD().Concat(父方.EnumEleD()))
			{
				Type type = eleD.GetType();
				if (!(eleD is 長胴D) && 交配.接続範囲.ContainsKey(eleD.接続情報) && 交配.接続範囲[eleD.接続情報].Contains(type.ToString()))
				{
					if (dictionary.ContainsKey(eleD.接続情報))
					{
						dictionary[eleD.接続情報].Add(type);
					}
					else
					{
						dictionary[eleD.接続情報] = new List<Type>
						{
							type
						};
					}
				}
			}
			return dictionary;
		}

		private static Type[] Get要素構成(腰D 母方, 腰D 父方)
		{
			return (from e in 母方.EnumEleD().Concat(父方.EnumEleD())
			where 交配.接続範囲.ContainsKey(e.接続情報) && 交配.接続範囲[e.接続情報].Contains(e.GetType().ToString())
			select e.GetType()).ToArray<Type>();
		}

		public static void 接続(this EleD e, 腰D 母方, 腰D 父方, int i, 接続情報 接続, Type[] 要素構成, Dictionary<接続情報, List<Type>> 接続構成, double 変異率, bool 原種モ\u30FCド)
		{
			string text = 接続.ToString();
			if (text.Contains("左"))
			{
				接続情報 接続情報 = 接続;
				接続情報 接続情報2 = text.Replace("左", "右").To接続情報();
				using (IEnumerator<EleD> enumerator = 交配.Enum接続肢(母方, 父方, false, i, 接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						EleD eleD = enumerator.Current;
						if (eleD != null)
						{
							e.接続(接続情報, eleD);
							e.接続(接続情報2, eleD.Get逆());
						}
					}
					return;
				}
			}
			if (!text.Contains("右"))
			{
				foreach (EleD eleD2 in 交配.Enum接続肢(母方, 父方, false, i, 接続, 要素構成, 接続構成, 変異率, 原種モ\u30FCド).Reverse<EleD>())
				{
					if (eleD2 != null)
					{
						e.接続(接続, eleD2);
					}
				}
			}
		}

		public static IEnumerable<EleD> Enum接続肢(腰D 母方, 腰D 父方, bool 右, int i, 接続情報 接続, Type[] 要素構成, Dictionary<接続情報, List<Type>> 接続構成, double 変異率, bool 原種モ\u30FCド)
		{
			double j = (double)((接続.接続数(母方, 父方) + 接続.接続数(母方, 父方) + 接続.接続数(母方, 父方)) / 3);
			double num = 1.0 / ((double)接続構成.Count * 0.5);
			if (!原種モ\u30FCド)
			{
				string text = 接続.ToString();
				if (text.Contains("肩") || text.Contains("脇") || text.Contains("翼"))
				{
					if (num.Lot())
					{
						j += (double)((int)(3.0 * 変異率 * OthN.XS.NextDouble()));
					}
					if (j > 3.0)
					{
						j = 3.0;
					}
				}
				else if (接続 == 接続情報.腰_尾_接続 || 接続 == 接続情報.四足腰_尾_接続)
				{
					if (num.Lot())
					{
						j += (double)((int)(9.0 * 変異率 * OthN.XS.NextDouble()));
					}
					if (j > 9.0)
					{
						j = 9.0;
					}
				}
				if ((num * 変異率 * 0.5).Lot())
				{
					j = 0.0;
				}
			}
			if (j == 0.0 && (接続 == 接続情報.四足脇_上腕_接続 || 接続 == 接続情報.腰_腿左_接続 || 接続 == 接続情報.腰_腿左_接続 || 接続 == 接続情報.四足腰_腿左_接続 || 接続 == 接続情報.四足腰_腿左_接続 || 接続 == 接続情報.長物_魚_尾_接続 || 接続 == 接続情報.長物_鯨_尾_接続 || 接続 == 接続情報.長物_蛇_胴_接続 || 接続 == 接続情報.長物_蟲_胴_接続 || 接続 == 接続情報.胴_蛇_胴_接続 || 接続 == 接続情報.胴_蟲_胴_接続 || 接続 == 接続情報.多足_蛸_軟体外左_接続 || 接続 == 接続情報.多足_蛸_軟体外右_接続 || 接続 == 接続情報.多足_蛸_軟体内左_接続 || 接続 == 接続情報.多足_蛸_軟体内右_接続 || 接続 == 接続情報.単足_植_根外左_接続 || 接続 == 接続情報.単足_植_根内左_接続 || 接続 == 接続情報.単足_植_根中央_接続 || 接続 == 接続情報.単足_植_根内右_接続 || 接続 == 接続情報.単足_植_根外右_接続 || 接続 == 接続情報.頭頂_宇_頭部後_接続 || (num * 1.1).Lot()))
			{
				j = 1.0;
			}
			int k = 0;
			while ((double)k < j)
			{
				EleD e = 交配.Get接続肢(母方, 父方, 右, i, 接続, 要素構成, 接続構成, 変異率, k, 原種モ\u30FCド);
				if (e != null)
				{
					yield return e;
				}
				if (e is 角1D || e is 耳D || e is 触覚D || e is 腿D || e is 尾_蜘D || e is 尾_鳥D)
				{
					break;
				}
				e = null;
				int num2 = k;
				k = num2 + 1;
			}
			yield break;
		}

		public static int 接続数(this 接続情報 接続情報, 腰D 母方, 腰D 父方)
		{
			if (!交配.接続範囲.ContainsKey(接続情報))
			{
				return 0;
			}
			IEnumerable<EleD> source = from e in 母方.EnumEleD().Concat(父方.EnumEleD())
			where e.Enum接続情報().Contains(接続情報)
			select e;
			int num = source.Count<EleD>();
			if (num != 0)
			{
				return source.ElementAt(OthN.XS.Next(num)).Get接続(接続情報).Count((EleD e) => 交配.接続範囲[接続情報].Contains(e.GetType().ToString()));
			}
			return 1;
		}

		public static EleD Get接続肢(腰D 母方, 腰D 父方, bool 右, int i, 接続情報 接続, Type[] 要素構成, Dictionary<接続情報, List<Type>> 接続構成, double 変異率, int j, bool 原種モ\u30FCド)
		{
			EleD eleD = 交配.Get要素(母方, 父方, 右, i, 接続, 要素構成, 接続構成, 変異率, j, 原種モ\u30FCド);
			if (eleD != null)
			{
				foreach (接続情報 接続情報 in eleD.Enum接続情報())
				{
					string text = 接続情報.ToString();
					if (text.Contains("左"))
					{
						接続情報 接続情報2 = 接続情報;
						接続情報 接続情報3 = text.Replace("左", "右").To接続情報();
						using (IEnumerator<EleD> enumerator2 = 交配.Enum接続肢(母方, 父方, false, i, 接続情報, 要素構成, 接続構成, 変異率, 原種モ\u30FCド).GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								EleD eleD2 = enumerator2.Current;
								if (eleD2 != null)
								{
									eleD.接続(接続情報2, eleD2);
									eleD.接続(接続情報3, eleD2.Get逆());
								}
							}
							continue;
						}
					}
					if (!text.Contains("右"))
					{
						EleD eleD3 = 交配.Get接続肢(母方, 父方, 右, i, 接続情報, 要素構成, 接続構成, 変異率, j, 原種モ\u30FCド);
						if (eleD3 != null)
						{
							eleD.接続(接続情報, eleD3);
						}
					}
				}
			}
			return eleD;
		}

		public static EleD Get要素(腰D 母方, 腰D 父方, bool 右, int i, 接続情報 接続, Type[] 要素構成, Dictionary<接続情報, List<Type>> 接続構成, double 変異率, int j, bool 原種モ\u30FCド)
		{
			if (!原種モ\u30FCド && 変異率.Lot())
			{
				return 交配.Get要素1(母方, 父方, 右, i, 接続, 要素構成, j, 原種モ\u30FCド);
			}
			return 交配.Get要素0(母方, 父方, 右, i, 接続, 接続構成, j, 原種モ\u30FCド);
		}

		public static EleD Get要素1(腰D 母方, 腰D 父方, bool 右, int i, 接続情報 接続, Type[] 要素構成, int j, bool 原種モ\u30FCド)
		{
			if (交配.接続範囲.ContainsKey(接続))
			{
				IEnumerable<Type> source = from e in 要素構成
				where 交配.接続範囲[接続].Contains(e.ToString())
				select e;
				int num = source.Count<Type>();
				if (num > j && j > -1)
				{
					return 交配.Mix(母方, 父方, 右, i, source.ElementAt(j), 原種モ\u30FCド);
				}
				if (num > 0)
				{
					return 交配.Mix(母方, 父方, 右, i, source.ElementAt(OthN.XS.Next(num)), 原種モ\u30FCド);
				}
			}
			return null;
		}

		public static EleD Get要素0(腰D 母方, 腰D 父方, bool 右, int i, 接続情報 接続, Dictionary<接続情報, List<Type>> 接続構成, int j, bool 原種モ\u30FCド)
		{
			if (接続構成.ContainsKey(接続))
			{
				List<Type> list = 接続構成[接続];
				int count = list.Count;
				if (count > j && j > -1)
				{
					return 交配.Mix(母方, 父方, 右, i, list[j], 原種モ\u30FCド);
				}
				if (count > 0)
				{
					return 交配.Mix(母方, 父方, 右, i, list[OthN.XS.Next(count)], 原種モ\u30FCド);
				}
			}
			return null;
		}

		public static ChaD Mix(this ChaD 母方, ChaD 父方, bool 原種モ\u30FCド)
		{
			double num = 交配.Mix(母方.魔力濃度, 父方.魔力濃度, 1.0);
			腰D d;
			return new ChaD(d = 交配.Mix(母方.構成, 父方.構成, num, 原種モ\u30FCド), 交配.Mix(母方.体色, 父方.体色, num, d))
			{
				欲望度 = 交配.Mix(母方.欲望度, 父方.欲望度, 0.6),
				情愛度 = 交配.Mix(母方.情愛度, 父方.情愛度, 0.6),
				卑屈度 = 交配.Mix(母方.卑屈度, 父方.卑屈度, 0.6),
				技巧度 = 交配.Mix(母方.技巧度, 父方.技巧度, 0.6),
				部位感度 = new Dictionary<接触, double>
				{
					{
						接触.頭,
						交配.Mix(母方.部位感度[接触.頭], 父方.部位感度[接触.頭], 0.6)
					},
					{
						接触.顔,
						交配.Mix(母方.部位感度[接触.顔], 父方.部位感度[接触.顔], 0.6)
					},
					{
						接触.耳,
						交配.Mix(母方.部位感度[接触.耳], 父方.部位感度[接触.耳], 0.6)
					},
					{
						接触.口,
						交配.Mix(母方.部位感度[接触.口], 父方.部位感度[接触.口], 0.6)
					},
					{
						接触.髪,
						交配.Mix(母方.部位感度[接触.髪], 父方.部位感度[接触.髪], 0.6)
					},
					{
						接触.首,
						交配.Mix(母方.部位感度[接触.首], 父方.部位感度[接触.首], 0.6)
					},
					{
						接触.肩,
						交配.Mix(母方.部位感度[接触.肩], 父方.部位感度[接触.肩], 0.6)
					},
					{
						接触.胸,
						交配.Mix(母方.部位感度[接触.胸], 父方.部位感度[接触.胸], 0.6)
					},
					{
						接触.乳,
						交配.Mix(母方.部位感度[接触.乳], 父方.部位感度[接触.乳], 0.6)
					},
					{
						接触.脇,
						交配.Mix(母方.部位感度[接触.脇], 父方.部位感度[接触.脇], 0.6)
					},
					{
						接触.腹,
						交配.Mix(母方.部位感度[接触.腹], 父方.部位感度[接触.腹], 0.6)
					},
					{
						接触.股,
						交配.Mix(母方.部位感度[接触.股], 父方.部位感度[接触.股], 0.6)
					},
					{
						接触.性,
						交配.Mix(母方.部位感度[接触.性], 父方.部位感度[接触.性], 0.6)
					},
					{
						接触.膣,
						交配.Mix(母方.部位感度[接触.膣], 父方.部位感度[接触.膣], 0.6)
					},
					{
						接触.核,
						交配.Mix(母方.部位感度[接触.核], 父方.部位感度[接触.核], 0.6)
					},
					{
						接触.肛,
						交配.Mix(母方.部位感度[接触.肛], 父方.部位感度[接触.肛], 0.6)
					},
					{
						接触.糸,
						交配.Mix(母方.部位感度[接触.糸], 父方.部位感度[接触.糸], 0.6)
					},
					{
						接触.腿,
						交配.Mix(母方.部位感度[接触.腿], 父方.部位感度[接触.腿], 0.6)
					},
					{
						接触.足,
						交配.Mix(母方.部位感度[接触.足], 父方.部位感度[接触.足], 0.6)
					},
					{
						接触.手,
						交配.Mix(母方.部位感度[接触.手], 父方.部位感度[接触.手], 0.6)
					},
					{
						接触.覚,
						交配.Mix(母方.部位感度[接触.覚], 父方.部位感度[接触.覚], 0.6)
					},
					{
						接触.触,
						交配.Mix(母方.部位感度[接触.触], 父方.部位感度[接触.触], 0.6)
					},
					{
						接触.尾,
						交配.Mix(母方.部位感度[接触.尾], 父方.部位感度[接触.尾], 0.6)
					},
					{
						接触.翼,
						交配.Mix(母方.部位感度[接触.翼], 父方.部位感度[接触.翼], 0.6)
					},
					{
						接触.鰭,
						交配.Mix(母方.部位感度[接触.鰭], 父方.部位感度[接触.鰭], 0.6)
					},
					{
						接触.他,
						交配.Mix(母方.部位感度[接触.他], 父方.部位感度[接触.他], 0.6)
					}
				},
				最乳首 = 交配.Mix(母方.最乳首, 父方.最乳首, 1.0),
				最乳房 = 交配.Mix(母方.最乳房, 父方.最乳房, 1.0),
				最陰核 = 交配.Mix(母方.最陰核, 父方.最陰核, 1.0),
				素乳首濃度 = 0.3 + 交配.Mix(母方.素乳首濃度, 父方.素乳首濃度, 0.5),
				最乳首濃度 = 交配.Mix(母方.最乳首濃度, 父方.最乳首濃度, 0.19999999999999996),
				素性器濃度 = 0.3 + 交配.Mix(母方.素性器濃度, 父方.素性器濃度, 0.5),
				最性器濃度 = 交配.Mix(母方.最性器濃度, 父方.最性器濃度, 0.19999999999999996),
				素肛門濃度 = 0.3 + 交配.Mix(母方.素肛門濃度, 父方.素肛門濃度, 0.5),
				最肛門濃度 = 交配.Mix(母方.最肛門濃度, 父方.最肛門濃度, 0.19999999999999996),
				最陰毛濃度 = 交配.Mix(母方.最陰毛濃度, 父方.最陰毛濃度, 1.0),
				固有値 = 交配.Mix(母方.固有値, 父方.固有値, 1.0),
				魔力濃度 = num
			};
		}

		private static double Mix(double 母方, double 父方, double max)
		{
			switch (OthN.XS.Next(4))
			{
			case 0:
				return (母方 + (double)OthN.XS.NextSign() * OthN.XS.NextDouble(0.15)).LimitM(0.0, max);
			case 1:
				return (父方 + (double)OthN.XS.NextSign() * OthN.XS.NextDouble(0.15)).LimitM(0.0, max);
			case 2:
				return ((母方 + 父方) * 0.5 + (double)OthN.XS.NextSign() * OthN.XS.NextDouble(0.15)).LimitM(0.0, max);
			default:
				return OthN.XS.NextDouble(max);
			}
		}

		public static Unit Mix(this Unit 母方, Unit 父方, bool 原種モ\u30FCド)
		{
			Unit unit = new Unit();
			unit.母方 = 母方;
			unit.父方 = 父方;
			unit.ChaD = 母方.ChaD.Mix(父方.ChaD, 原種モ\u30FCド);
			if (母方.種族 != 父方.種族)
			{
				unit.種族 = tex.ミックス;
			}
			else
			{
				unit.種族 = 母方.種族;
			}
			unit.Name = unit.種族;
			unit.種族情報 = 母方.種族情報.Mix(父方.種族情報);
			unit.妊娠進行期間 = (母方.妊娠進行期間 + 父方.妊娠進行期間) / 2;
			foreach (EleD eleD in unit.ChaD.構成.EnumEleD())
			{
				eleD.SetValuesD("傷", false);
				eleD.欠損 = false;
			}
			unit.Set衣装();
			unit.Set交配素質();
			unit.Set構成特性();
			return unit;
		}

		public static 種族情報 Mix(this 種族情報 母方, 種族情報 父方)
		{
			return new 種族情報((母方.希少 + 父方.希少) / 2, (母方.需要 + 父方.需要) / 2, (母方.危険 + 父方.危険) / 2, 交配.Mix(母方.一般, 父方.一般, 9), 交配.Mix(母方.娼婦, 父方.娼婦, 9));
		}

		private static int Mix(int 母方, int 父方, int max)
		{
			switch (OthN.XS.Next(4))
			{
			case 0:
				return (母方 + OthN.XS.NextSign()).LimitM(1, max);
			case 1:
				return (父方 + OthN.XS.NextSign()).LimitM(1, max);
			case 2:
				return ((母方 + 父方) / 2 + OthN.XS.NextSign()).LimitM(1, max);
			default:
				return OthN.XS.NextM(max).LimitM(1, max);
			}
		}

		private static HashSet<string> 頭頂 = new HashSet<string>
		{
			Sta.頭頂_宇Dt.ToString(),
			Sta.頭頂_皿Dt.ToString(),
			Sta.頭頂_天Dt.ToString()
		};

		private static HashSet<string> 額 = new HashSet<string>
		{
			Sta.角1_一Dt.ToString(),
			Sta.角1_鬼Dt.ToString(),
			Sta.角1_虫Dt.ToString()
		};

		private static HashSet<string> 側頭 = new HashSet<string>
		{
			Sta.角1_鬼Dt.ToString(),
			Sta.角2_山1Dt.ToString(),
			Sta.角2_山2Dt.ToString(),
			Sta.角2_山3Dt.ToString(),
			Sta.角2_巻Dt.ToString(),
			Sta.角2_牛1Dt.ToString(),
			Sta.角2_牛2Dt.ToString(),
			Sta.角2_牛3Dt.ToString(),
			Sta.角2_牛4Dt.ToString(),
			Sta.角2_鬼Dt.ToString(),
			Sta.角2_虫Dt.ToString(),
			Sta.触覚_線Dt.ToString(),
			Sta.触覚_節Dt.ToString(),
			Sta.触覚_甲Dt.ToString(),
			Sta.触覚_蝶Dt.ToString(),
			Sta.触覚_蛾Dt.ToString(),
			Sta.上腕_鳥Dt.ToString(),
			Sta.上腕_蝙Dt.ToString(),
			Sta.獣耳Dt.ToString(),
			Sta.植Dt.ToString()
		};

		private static HashSet<string> 触覚 = new HashSet<string>
		{
			Sta.触覚_線Dt.ToString(),
			Sta.触覚_節Dt.ToString(),
			Sta.触覚_甲Dt.ToString(),
			Sta.触覚_蝶Dt.ToString(),
			Sta.触覚_蛾Dt.ToString()
		};

		private static HashSet<string> 耳 = new HashSet<string>
		{
			Sta.耳_人Dt.ToString(),
			Sta.耳_尖Dt.ToString(),
			Sta.耳_長Dt.ToString(),
			Sta.耳_鰭Dt.ToString(),
			Sta.耳_羽Dt.ToString(),
			Sta.耳_獣Dt.ToString()
		};

		private static HashSet<string> 頬 = new HashSet<string>
		{
			Sta.虫顎Dt.ToString()
		};

		private static HashSet<string> 後髪 = new HashSet<string>
		{
			Sta.尾_龍Dt.ToString(),
			Sta.尾_竜Dt.ToString(),
			Sta.尾_悪Dt.ToString(),
			Sta.尾_淫Dt.ToString(),
			Sta.尾_虫Dt.ToString(),
			Sta.尾_蠍Dt.ToString(),
			Sta.尾_蛇Dt.ToString(),
			Sta.尾_腓Dt.ToString(),
			Sta.尾_根Dt.ToString(),
			Sta.節尾_曳航Dt.ToString(),
			Sta.触手_軟Dt.ToString(),
			Sta.触手_触Dt.ToString(),
			Sta.触手_蔦Dt.ToString(),
			Sta.鳳凰Dt.ToString()
		};

		private static HashSet<string> 肩人 = new HashSet<string>
		{
			Sta.肩Dt.ToString()
		};

		private static HashSet<string> 胸翼上人 = new HashSet<string>
		{
			Sta.前翅_甲Dt.ToString(),
			Sta.前翅_羽Dt.ToString(),
			Sta.前翅_蝶Dt.ToString(),
			Sta.前翅_草Dt.ToString(),
			Sta.後翅_甲Dt.ToString(),
			Sta.後翅_草Dt.ToString(),
			Sta.上腕_鳥Dt.ToString(),
			Sta.上腕_蝙Dt.ToString()
		};

		private static HashSet<string> 胸翼下人 = new HashSet<string>
		{
			Sta.後翅_羽Dt.ToString(),
			Sta.後翅_蝶Dt.ToString()
		};

		private static HashSet<string> 胴翼人 = new HashSet<string>
		{
			Sta.尾_蠍Dt.ToString(),
			Sta.前翅_甲Dt.ToString(),
			Sta.前翅_羽Dt.ToString(),
			Sta.前翅_蝶Dt.ToString(),
			Sta.前翅_草Dt.ToString(),
			Sta.後翅_甲Dt.ToString(),
			Sta.後翅_草Dt.ToString(),
			Sta.触肢_肢蜘Dt.ToString(),
			Sta.触肢_肢蠍Dt.ToString(),
			Sta.節足_足蜘Dt.ToString(),
			Sta.節足_足蠍Dt.ToString(),
			Sta.節足_足百Dt.ToString(),
			Sta.節尾_曳航Dt.ToString(),
			Sta.触手_軟Dt.ToString(),
			Sta.触手_触Dt.ToString(),
			Sta.触手_蔦Dt.ToString(),
			Sta.上腕_鳥Dt.ToString(),
			Sta.上腕_蝙Dt.ToString()
		};

		private static HashSet<string> 腰翼人 = new HashSet<string>
		{
			Sta.後翅_羽Dt.ToString(),
			Sta.後翅_蝶Dt.ToString(),
			Sta.触肢_肢蜘Dt.ToString(),
			Sta.触肢_肢蠍Dt.ToString(),
			Sta.節足_足蜘Dt.ToString(),
			Sta.節足_足蠍Dt.ToString(),
			Sta.節足_足百Dt.ToString(),
			Sta.節尾_曳航Dt.ToString(),
			Sta.触手_軟Dt.ToString(),
			Sta.触手_触Dt.ToString(),
			Sta.触手_蔦Dt.ToString(),
			Sta.四足脇Dt.ToString()
		};

		private static HashSet<string> 腿人 = new HashSet<string>
		{
			Sta.尾_魚Dt.ToString(),
			Sta.触手_犬Dt.ToString(),
			Sta.腿_人Dt.ToString(),
			Sta.腿_獣Dt.ToString(),
			Sta.腿_蹄Dt.ToString(),
			Sta.腿_鳥Dt.ToString(),
			Sta.腿_竜Dt.ToString()
		};

		private static HashSet<string> 肩獣 = new HashSet<string>
		{
			Sta.四足脇Dt.ToString()
		};

		private static HashSet<string> 胸翼上獣 = new HashSet<string>
		{
			Sta.前翅_甲Dt.ToString(),
			Sta.前翅_羽Dt.ToString(),
			Sta.前翅_蝶Dt.ToString(),
			Sta.前翅_草Dt.ToString(),
			Sta.後翅_甲Dt.ToString(),
			Sta.後翅_草Dt.ToString(),
			Sta.上腕_鳥Dt.ToString(),
			Sta.上腕_蝙Dt.ToString()
		};

		private static HashSet<string> 胸翼下獣 = new HashSet<string>
		{
			Sta.後翅_羽Dt.ToString(),
			Sta.後翅_蝶Dt.ToString()
		};

		private static HashSet<string> 胴翼獣 = new HashSet<string>();

		private static HashSet<string> 腰翼獣 = new HashSet<string>();

		private static HashSet<string> 腿獣 = new HashSet<string>
		{
			Sta.腿_獣Dt.ToString(),
			Sta.腿_蹄Dt.ToString(),
			Sta.腿_鳥Dt.ToString(),
			Sta.腿_竜Dt.ToString()
		};

		private static HashSet<string> 蛸外 = new HashSet<string>
		{
			Sta.尾_魚Dt.ToString(),
			Sta.触手_軟Dt.ToString(),
			Sta.触手_触Dt.ToString(),
			Sta.触手_犬Dt.ToString()
		};

		private static HashSet<string> 蛸内 = new HashSet<string>
		{
			Sta.尾_魚Dt.ToString(),
			Sta.節尾_曳航Dt.ToString(),
			Sta.節尾_鋏Dt.ToString(),
			Sta.触手_軟Dt.ToString(),
			Sta.触手_触Dt.ToString(),
			Sta.触手_犬Dt.ToString()
		};

		private static HashSet<string> 蜘触肢 = new HashSet<string>
		{
			Sta.触肢_肢蜘Dt.ToString(),
			Sta.触肢_肢蠍Dt.ToString(),
			Sta.節足_足蠍Dt.ToString(),
			Sta.節足_足百Dt.ToString(),
			Sta.節尾_曳航Dt.ToString(),
			Sta.節尾_鋏Dt.ToString()
		};

		private static HashSet<string> 蜘節足1 = new HashSet<string>
		{
			Sta.節足_足蜘Dt.ToString(),
			Sta.節足_足蠍Dt.ToString(),
			Sta.節足_足百Dt.ToString()
		};

		private static HashSet<string> 蜘節足2 = new HashSet<string>
		{
			Sta.節足_足蜘Dt.ToString(),
			Sta.節足_足蠍Dt.ToString(),
			Sta.節足_足百Dt.ToString()
		};

		private static HashSet<string> 蜘節足3 = new HashSet<string>
		{
			Sta.節足_足蜘Dt.ToString(),
			Sta.節足_足蠍Dt.ToString(),
			Sta.節足_足百Dt.ToString()
		};

		private static HashSet<string> 蜘節足4 = new HashSet<string>
		{
			Sta.節足_足蜘Dt.ToString(),
			Sta.節足_足蠍Dt.ToString(),
			Sta.節足_足百Dt.ToString()
		};

		private static HashSet<string> 蠍触肢 = new HashSet<string>
		{
			Sta.触肢_肢蜘Dt.ToString(),
			Sta.触肢_肢蠍Dt.ToString(),
			Sta.節足_足蜘Dt.ToString(),
			Sta.節足_足百Dt.ToString(),
			Sta.節尾_曳航Dt.ToString(),
			Sta.節尾_鋏Dt.ToString()
		};

		private static HashSet<string> 蠍節足1 = new HashSet<string>
		{
			Sta.節足_足蜘Dt.ToString(),
			Sta.節足_足蠍Dt.ToString(),
			Sta.節足_足百Dt.ToString()
		};

		private static HashSet<string> 蠍節足2 = new HashSet<string>
		{
			Sta.節足_足蜘Dt.ToString(),
			Sta.節足_足蠍Dt.ToString(),
			Sta.節足_足百Dt.ToString()
		};

		private static HashSet<string> 蠍節足3 = new HashSet<string>
		{
			Sta.節足_足蜘Dt.ToString(),
			Sta.節足_足蠍Dt.ToString(),
			Sta.節足_足百Dt.ToString()
		};

		private static HashSet<string> 蠍節足4 = new HashSet<string>
		{
			Sta.節足_足蜘Dt.ToString(),
			Sta.節足_足蠍Dt.ToString(),
			Sta.節足_足百Dt.ToString()
		};

		private static HashSet<string> 蠍櫛状板 = new HashSet<string>
		{
			Sta.触覚_蠍Dt.ToString(),
			Sta.鰭_魚Dt.ToString(),
			Sta.鰭_豚Dt.ToString(),
			Sta.鰭_鯨Dt.ToString(),
			Sta.節尾_曳航Dt.ToString()
		};

		private static HashSet<string> 植外 = new HashSet<string>
		{
			Sta.尾_猫Dt.ToString(),
			Sta.尾_悪Dt.ToString(),
			Sta.尾_淫Dt.ToString(),
			Sta.尾_根Dt.ToString(),
			Sta.節尾_曳航Dt.ToString()
		};

		private static HashSet<string> 植内 = new HashSet<string>
		{
			Sta.尾_猫Dt.ToString(),
			Sta.尾_悪Dt.ToString(),
			Sta.尾_淫Dt.ToString(),
			Sta.尾_根Dt.ToString(),
			Sta.節尾_曳航Dt.ToString()
		};

		private static HashSet<string> 魚 = new HashSet<string>
		{
			Sta.鰭_魚Dt.ToString(),
			Sta.鰭_豚Dt.ToString(),
			Sta.鰭_鯨Dt.ToString()
		};

		private static HashSet<string> 鯨 = new HashSet<string>
		{
			Sta.鰭_魚Dt.ToString(),
			Sta.鰭_豚Dt.ToString(),
			Sta.鰭_鯨Dt.ToString()
		};

		private static HashSet<string> 蛇 = new HashSet<string>
		{
			Sta.鰭_魚Dt.ToString(),
			Sta.鰭_豚Dt.ToString(),
			Sta.鰭_鯨Dt.ToString(),
			Sta.節足_足蜘Dt.ToString(),
			Sta.節足_足蠍Dt.ToString(),
			Sta.節足_足百Dt.ToString(),
			Sta.腿_竜Dt.ToString()
		};

		private static HashSet<string> 蟲 = new HashSet<string>
		{
			Sta.鰭_魚Dt.ToString(),
			Sta.鰭_豚Dt.ToString(),
			Sta.鰭_鯨Dt.ToString(),
			Sta.節足_足蜘Dt.ToString(),
			Sta.節足_足蠍Dt.ToString(),
			Sta.節足_足百Dt.ToString()
		};

		private static HashSet<string> 蟲尾 = new HashSet<string>
		{
			Sta.節足_足百Dt.ToString()
		};

		private static HashSet<string> 蟲尾先 = new HashSet<string>
		{
			Sta.節尾_曳航Dt.ToString(),
			Sta.節尾_鋏Dt.ToString(),
			Sta.鳳凰Dt.ToString(),
			Sta.大顎Dt.ToString()
		};

		private static HashSet<string> 触覚甲 = new HashSet<string>
		{
			Sta.触覚_線Dt.ToString(),
			Sta.触覚_節Dt.ToString(),
			Sta.触覚_甲Dt.ToString(),
			Sta.触覚_蝶Dt.ToString(),
			Sta.触覚_蛾Dt.ToString()
		};

		private static HashSet<string> 触覚虫 = new HashSet<string>
		{
			Sta.触覚_線Dt.ToString(),
			Sta.触覚_節Dt.ToString(),
			Sta.触覚_甲Dt.ToString(),
			Sta.触覚_蝶Dt.ToString(),
			Sta.触覚_蛾Dt.ToString()
		};

		private static HashSet<string> 触覚蟲 = new HashSet<string>
		{
			Sta.触覚_線Dt.ToString(),
			Sta.触覚_節Dt.ToString(),
			Sta.触覚_甲Dt.ToString(),
			Sta.触覚_蝶Dt.ToString(),
			Sta.触覚_蛾Dt.ToString()
		};

		private static HashSet<string> 背中人 = new HashSet<string>
		{
			Sta.背中_羽Dt.ToString(),
			Sta.背中_甲Dt.ToString(),
			Sta.背中_光Dt.ToString()
		};

		private static HashSet<string> 背中獣 = new HashSet<string>
		{
			Sta.背中_羽Dt.ToString()
		};

		private static HashSet<string> 尾人 = new HashSet<string>
		{
			Sta.尾_猫Dt.ToString(),
			Sta.尾_犬Dt.ToString(),
			Sta.尾_狐Dt.ToString(),
			Sta.尾_馬Dt.ToString(),
			Sta.尾_牛Dt.ToString(),
			Sta.尾_龍Dt.ToString(),
			Sta.尾_竜Dt.ToString(),
			Sta.尾_悪Dt.ToString(),
			Sta.尾_淫Dt.ToString(),
			Sta.尾_鳥Dt.ToString(),
			Sta.尾_虫Dt.ToString(),
			Sta.尾_蜘Dt.ToString(),
			Sta.尾_蠍Dt.ToString(),
			Sta.尾_蛇Dt.ToString(),
			Sta.尾_腓Dt.ToString(),
			Sta.尾_短Dt.ToString(),
			Sta.尾_ヘDt.ToString(),
			Sta.尾_ガDt.ToString(),
			Sta.尾_ウDt.ToString(),
			Sta.尾_魚Dt.ToString(),
			Sta.尾_鯨Dt.ToString(),
			Sta.尾_蟲Dt.ToString(),
			Sta.尾_根Dt.ToString(),
			Sta.鳳凰Dt.ToString()
		};

		private static HashSet<string> 尾獣 = new HashSet<string>
		{
			Sta.尾_猫Dt.ToString(),
			Sta.尾_犬Dt.ToString(),
			Sta.尾_狐Dt.ToString(),
			Sta.尾_馬Dt.ToString(),
			Sta.尾_牛Dt.ToString(),
			Sta.尾_龍Dt.ToString(),
			Sta.尾_竜Dt.ToString(),
			Sta.尾_悪Dt.ToString(),
			Sta.尾_淫Dt.ToString(),
			Sta.尾_鳥Dt.ToString(),
			Sta.尾_虫Dt.ToString(),
			Sta.尾_蜘Dt.ToString(),
			Sta.尾_蠍Dt.ToString(),
			Sta.尾_蛇Dt.ToString(),
			Sta.尾_腓Dt.ToString(),
			Sta.尾_短Dt.ToString(),
			Sta.尾_ヘDt.ToString(),
			Sta.尾_ガDt.ToString(),
			Sta.尾_ウDt.ToString(),
			Sta.尾_魚Dt.ToString(),
			Sta.尾_鯨Dt.ToString(),
			Sta.尾_蟲Dt.ToString(),
			Sta.尾_根Dt.ToString(),
			Sta.鳳凰Dt.ToString()
		};

		private static HashSet<string> 尾蜘 = new HashSet<string>
		{
			Sta.尾_猫Dt.ToString(),
			Sta.尾_犬Dt.ToString(),
			Sta.尾_狐Dt.ToString(),
			Sta.尾_馬Dt.ToString(),
			Sta.尾_牛Dt.ToString(),
			Sta.尾_龍Dt.ToString(),
			Sta.尾_竜Dt.ToString(),
			Sta.尾_悪Dt.ToString(),
			Sta.尾_淫Dt.ToString(),
			Sta.尾_鳥Dt.ToString(),
			Sta.尾_虫Dt.ToString(),
			Sta.尾_蜘Dt.ToString(),
			Sta.尾_蠍Dt.ToString(),
			Sta.尾_蛇Dt.ToString(),
			Sta.尾_腓Dt.ToString(),
			Sta.尾_短Dt.ToString(),
			Sta.尾_ヘDt.ToString(),
			Sta.尾_ガDt.ToString(),
			Sta.尾_ウDt.ToString(),
			Sta.尾_魚Dt.ToString(),
			Sta.尾_鯨Dt.ToString(),
			Sta.尾_蟲Dt.ToString(),
			Sta.尾_根Dt.ToString()
		};

		private static HashSet<string> 尾蠍 = new HashSet<string>
		{
			Sta.尾_猫Dt.ToString(),
			Sta.尾_犬Dt.ToString(),
			Sta.尾_狐Dt.ToString(),
			Sta.尾_馬Dt.ToString(),
			Sta.尾_牛Dt.ToString(),
			Sta.尾_龍Dt.ToString(),
			Sta.尾_竜Dt.ToString(),
			Sta.尾_悪Dt.ToString(),
			Sta.尾_淫Dt.ToString(),
			Sta.尾_鳥Dt.ToString(),
			Sta.尾_虫Dt.ToString(),
			Sta.尾_蜘Dt.ToString(),
			Sta.尾_蠍Dt.ToString(),
			Sta.尾_蛇Dt.ToString(),
			Sta.尾_腓Dt.ToString(),
			Sta.尾_短Dt.ToString(),
			Sta.尾_ヘDt.ToString(),
			Sta.尾_ガDt.ToString(),
			Sta.尾_ウDt.ToString(),
			Sta.尾_魚Dt.ToString(),
			Sta.尾_鯨Dt.ToString(),
			Sta.尾_蟲Dt.ToString(),
			Sta.尾_根Dt.ToString()
		};

		private static HashSet<string> 尾魚 = new HashSet<string>
		{
			Sta.尾_龍Dt.ToString(),
			Sta.尾_竜Dt.ToString(),
			Sta.尾_鳥Dt.ToString(),
			Sta.尾_虫Dt.ToString(),
			Sta.尾_蜘Dt.ToString(),
			Sta.尾_魚Dt.ToString(),
			Sta.尾_鯨Dt.ToString()
		};

		private static HashSet<string> 尾鯨 = new HashSet<string>
		{
			Sta.尾_鯨Dt.ToString()
		};

		private static HashSet<string> 尾蛇 = new HashSet<string>
		{
			Sta.尾_ヘDt.ToString(),
			Sta.尾_ガDt.ToString(),
			Sta.尾_ウDt.ToString(),
			Sta.尾_蟲Dt.ToString()
		};

		private static HashSet<string> 尾蟲 = new HashSet<string>
		{
			Sta.尾_ヘDt.ToString(),
			Sta.尾_ガDt.ToString(),
			Sta.尾_ウDt.ToString(),
			Sta.尾_蟲Dt.ToString()
		};

		private static HashSet<string> 根中 = new HashSet<string>
		{
			Sta.尾_猫Dt.ToString(),
			Sta.尾_悪Dt.ToString(),
			Sta.尾_淫Dt.ToString(),
			Sta.尾_根Dt.ToString()
		};

		private static HashSet<string> 尾先ヘ = new HashSet<string>
		{
			Sta.尾鰭_魚Dt.ToString(),
			Sta.尾鰭_鯨Dt.ToString()
		};

		private static HashSet<string> 尾先ウ = new HashSet<string>
		{
			Sta.尾鰭_魚Dt.ToString(),
			Sta.尾鰭_鯨Dt.ToString()
		};

		private static HashSet<string> 尾先魚 = new HashSet<string>
		{
			Sta.尾鰭_魚Dt.ToString(),
			Sta.尾鰭_鯨Dt.ToString()
		};

		private static HashSet<string> 尾先鯨 = new HashSet<string>
		{
			Sta.尾鰭_魚Dt.ToString(),
			Sta.尾鰭_鯨Dt.ToString()
		};

		private static HashSet<string> 頭頂後 = new HashSet<string>
		{
			Sta.頭頂後_宇Dt.ToString()
		};

		private static HashSet<string> 上腕人 = new HashSet<string>
		{
			Sta.鰭_魚Dt.ToString(),
			Sta.鰭_豚Dt.ToString(),
			Sta.鰭_鯨Dt.ToString(),
			Sta.触肢_肢蠍Dt.ToString(),
			Sta.上腕_人Dt.ToString(),
			Sta.上腕_鳥Dt.ToString(),
			Sta.上腕_蝙Dt.ToString()
		};

		private static HashSet<string> 上腕獣 = new HashSet<string>
		{
			Sta.触肢_肢蠍Dt.ToString(),
			Sta.上腕_獣Dt.ToString(),
			Sta.上腕_蹄Dt.ToString(),
			Sta.脚_鳥Dt.ToString(),
			Sta.脚_竜Dt.ToString()
		};

		private static HashSet<string> 下腕人 = new HashSet<string>
		{
			Sta.下腕_人Dt.ToString(),
			Sta.下腕_獣Dt.ToString()
		};

		private static HashSet<string> 下腕鳥 = new HashSet<string>
		{
			Sta.下腕_鳥Dt.ToString()
		};

		private static HashSet<string> 下腕蝙 = new HashSet<string>
		{
			Sta.下腕_蝙Dt.ToString()
		};

		private static HashSet<string> 下腕獣 = new HashSet<string>
		{
			Sta.下腕_獣Dt.ToString()
		};

		private static HashSet<string> 下腕蹄 = new HashSet<string>
		{
			Sta.下腕_蹄Dt.ToString()
		};

		private static HashSet<string> 手人 = new HashSet<string>
		{
			Sta.手_人Dt.ToString()
		};

		private static HashSet<string> 手鳥 = new HashSet<string>
		{
			Sta.手_鳥Dt.ToString()
		};

		private static HashSet<string> 手蝙 = new HashSet<string>
		{
			Sta.手_蝙Dt.ToString()
		};

		private static HashSet<string> 手獣 = new HashSet<string>
		{
			Sta.手_獣Dt.ToString()
		};

		private static HashSet<string> 手蹄 = new HashSet<string>
		{
			Sta.手_馬Dt.ToString(),
			Sta.手_牛Dt.ToString()
		};

		private static HashSet<string> 虫鎌 = new HashSet<string>
		{
			Sta.虫鎌Dt.ToString()
		};

		private static HashSet<string> 脚人 = new HashSet<string>
		{
			Sta.脚_人Dt.ToString()
		};

		private static HashSet<string> 脚獣 = new HashSet<string>
		{
			Sta.脚_獣Dt.ToString(),
			Sta.脚_蹄Dt.ToString(),
			Sta.脚_鳥Dt.ToString(),
			Sta.脚_竜Dt.ToString()
		};

		private static HashSet<string> 脚蹄 = new HashSet<string>
		{
			Sta.脚_獣Dt.ToString(),
			Sta.脚_蹄Dt.ToString(),
			Sta.脚_鳥Dt.ToString(),
			Sta.脚_竜Dt.ToString()
		};

		private static HashSet<string> 脚鳥 = new HashSet<string>
		{
			Sta.脚_獣Dt.ToString(),
			Sta.脚_蹄Dt.ToString(),
			Sta.脚_鳥Dt.ToString(),
			Sta.脚_竜Dt.ToString()
		};

		private static HashSet<string> 脚竜 = new HashSet<string>
		{
			Sta.脚_獣Dt.ToString(),
			Sta.脚_蹄Dt.ToString(),
			Sta.脚_鳥Dt.ToString(),
			Sta.脚_竜Dt.ToString()
		};

		private static HashSet<string> 足人 = new HashSet<string>
		{
			Sta.足_人Dt.ToString()
		};

		private static HashSet<string> 足獣 = new HashSet<string>
		{
			Sta.足_獣Dt.ToString(),
			Sta.足_馬Dt.ToString(),
			Sta.足_牛Dt.ToString(),
			Sta.足_鳥Dt.ToString(),
			Sta.足_竜Dt.ToString()
		};

		private static HashSet<string> 足蹄 = new HashSet<string>
		{
			Sta.足_獣Dt.ToString(),
			Sta.足_馬Dt.ToString(),
			Sta.足_牛Dt.ToString(),
			Sta.足_鳥Dt.ToString(),
			Sta.足_竜Dt.ToString()
		};

		private static HashSet<string> 足鳥 = new HashSet<string>
		{
			Sta.足_獣Dt.ToString(),
			Sta.足_馬Dt.ToString(),
			Sta.足_牛Dt.ToString(),
			Sta.足_鳥Dt.ToString(),
			Sta.足_竜Dt.ToString()
		};

		private static HashSet<string> 足竜 = new HashSet<string>
		{
			Sta.足_獣Dt.ToString(),
			Sta.足_馬Dt.ToString(),
			Sta.足_牛Dt.ToString(),
			Sta.足_鳥Dt.ToString(),
			Sta.足_竜Dt.ToString()
		};

		private static HashSet<string> 前翅甲軸1 = new HashSet<string>();

		private static HashSet<string> 前翅甲軸2 = new HashSet<string>();

		private static HashSet<string> 前翅甲軸3 = new HashSet<string>();

		private static HashSet<string> 犬頭 = new HashSet<string>();

		private static HashSet<string> 犬上腕 = new HashSet<string>();

		private static HashSet<string> 犬下腕 = new HashSet<string>();

		private static HashSet<string> 犬手 = new HashSet<string>();

		private static HashSet<string> 蔦 = new HashSet<string>
		{
			Sta.葉_披Dt.ToString(),
			Sta.葉_心Dt.ToString()
		};

		private static HashSet<string> 蔦先 = new HashSet<string>
		{
			Sta.虫鎌Dt.ToString()
		};

		private static HashSet<string> 顔面 = new HashSet<string>
		{
			Sta.顔面_甲Dt.ToString(),
			Sta.顔面_虫Dt.ToString(),
			Sta.顔面_蟲Dt.ToString()
		};

		private static HashSet<string> 大顎基 = new HashSet<string>
		{
			Sta.大顎基Dt.ToString()
		};

		private static HashSet<string> 大顎 = new HashSet<string>
		{
			Sta.大顎Dt.ToString()
		};

		private static HashSet<string> 花 = new HashSet<string>
		{
			Sta.花_薔Dt.ToString(),
			Sta.花_百Dt.ToString()
		};

		public static Dictionary<接続情報, HashSet<string>> 接続範囲 = new Dictionary<接続情報, HashSet<string>>
		{
			{
				接続情報.基髪_頭頂左_接続,
				交配.側頭
			},
			{
				接続情報.基髪_頭頂右_接続,
				交配.側頭
			},
			{
				接続情報.頭_触覚左_接続,
				交配.触覚
			},
			{
				接続情報.頭_触覚右_接続,
				交配.触覚
			},
			{
				接続情報.頭_耳左_接続,
				交配.耳
			},
			{
				接続情報.頭_耳右_接続,
				交配.耳
			},
			{
				接続情報.頭_頬左_接続,
				交配.頬
			},
			{
				接続情報.頭_頬右_接続,
				交配.頬
			},
			{
				接続情報.後髪0_肢系_左5_接続,
				交配.後髪
			},
			{
				接続情報.後髪0_肢系_右5_接続,
				交配.後髪
			},
			{
				接続情報.後髪0_肢系_左4_接続,
				交配.後髪
			},
			{
				接続情報.後髪0_肢系_右4_接続,
				交配.後髪
			},
			{
				接続情報.後髪0_肢系_左3_接続,
				交配.後髪
			},
			{
				接続情報.後髪0_肢系_右3_接続,
				交配.後髪
			},
			{
				接続情報.後髪0_肢系_左2_接続,
				交配.後髪
			},
			{
				接続情報.後髪0_肢系_右2_接続,
				交配.後髪
			},
			{
				接続情報.後髪0_肢系_左1_接続,
				交配.後髪
			},
			{
				接続情報.後髪0_肢系_右1_接続,
				交配.後髪
			},
			{
				接続情報.胸_肩左_接続,
				交配.肩人
			},
			{
				接続情報.胸_肩右_接続,
				交配.肩人
			},
			{
				接続情報.胸_翼上左_接続,
				交配.胸翼上人
			},
			{
				接続情報.胸_翼上右_接続,
				交配.胸翼上人
			},
			{
				接続情報.胸_翼下左_接続,
				交配.胸翼下人
			},
			{
				接続情報.胸_翼下右_接続,
				交配.胸翼下人
			},
			{
				接続情報.胴_翼左_接続,
				交配.胴翼人
			},
			{
				接続情報.胴_翼右_接続,
				交配.胴翼人
			},
			{
				接続情報.腰_翼左_接続,
				交配.腰翼人
			},
			{
				接続情報.腰_翼右_接続,
				交配.腰翼人
			},
			{
				接続情報.腰_腿左_接続,
				交配.腿人
			},
			{
				接続情報.腰_腿右_接続,
				交配.腿人
			},
			{
				接続情報.四足胸_脇左_接続,
				交配.肩獣
			},
			{
				接続情報.四足胸_脇右_接続,
				交配.肩獣
			},
			{
				接続情報.四足胸_翼上左_接続,
				交配.胸翼上獣
			},
			{
				接続情報.四足胸_翼上右_接続,
				交配.胸翼上獣
			},
			{
				接続情報.四足胸_翼下左_接続,
				交配.胸翼下獣
			},
			{
				接続情報.四足胸_翼下右_接続,
				交配.胸翼下獣
			},
			{
				接続情報.四足胴_翼左_接続,
				交配.胴翼獣
			},
			{
				接続情報.四足胴_翼右_接続,
				交配.胴翼獣
			},
			{
				接続情報.四足腰_翼左_接続,
				交配.腰翼獣
			},
			{
				接続情報.四足腰_翼右_接続,
				交配.腰翼獣
			},
			{
				接続情報.四足腰_腿左_接続,
				交配.腿獣
			},
			{
				接続情報.四足腰_腿右_接続,
				交配.腿獣
			},
			{
				接続情報.多足_蛸_軟体外左_接続,
				交配.蛸外
			},
			{
				接続情報.多足_蛸_軟体外右_接続,
				交配.蛸外
			},
			{
				接続情報.多足_蛸_軟体内左_接続,
				交配.蛸内
			},
			{
				接続情報.多足_蛸_軟体内右_接続,
				交配.蛸内
			},
			{
				接続情報.多足_蜘_触肢左_接続,
				交配.蜘触肢
			},
			{
				接続情報.多足_蜘_触肢右_接続,
				交配.蜘触肢
			},
			{
				接続情報.多足_蜘_節足左1_接続,
				交配.蜘節足1
			},
			{
				接続情報.多足_蜘_節足右1_接続,
				交配.蜘節足1
			},
			{
				接続情報.多足_蜘_節足左2_接続,
				交配.蜘節足2
			},
			{
				接続情報.多足_蜘_節足右2_接続,
				交配.蜘節足2
			},
			{
				接続情報.多足_蜘_節足左3_接続,
				交配.蜘節足3
			},
			{
				接続情報.多足_蜘_節足右3_接続,
				交配.蜘節足3
			},
			{
				接続情報.多足_蜘_節足左4_接続,
				交配.蜘節足4
			},
			{
				接続情報.多足_蜘_節足右4_接続,
				交配.蜘節足4
			},
			{
				接続情報.多足_蠍_触肢左_接続,
				交配.蠍触肢
			},
			{
				接続情報.多足_蠍_触肢右_接続,
				交配.蠍触肢
			},
			{
				接続情報.多足_蠍_節足左1_接続,
				交配.蠍節足1
			},
			{
				接続情報.多足_蠍_節足右1_接続,
				交配.蠍節足1
			},
			{
				接続情報.多足_蠍_節足左2_接続,
				交配.蠍節足2
			},
			{
				接続情報.多足_蠍_節足右2_接続,
				交配.蠍節足2
			},
			{
				接続情報.多足_蠍_節足左3_接続,
				交配.蠍節足3
			},
			{
				接続情報.多足_蠍_節足右3_接続,
				交配.蠍節足3
			},
			{
				接続情報.多足_蠍_節足左4_接続,
				交配.蠍節足4
			},
			{
				接続情報.多足_蠍_節足右4_接続,
				交配.蠍節足4
			},
			{
				接続情報.多足_蠍_櫛状板左_接続,
				交配.蠍櫛状板
			},
			{
				接続情報.多足_蠍_櫛状板右_接続,
				交配.蠍櫛状板
			},
			{
				接続情報.単足_植_根外左_接続,
				交配.植外
			},
			{
				接続情報.単足_植_根外右_接続,
				交配.植外
			},
			{
				接続情報.単足_植_根内左_接続,
				交配.植内
			},
			{
				接続情報.単足_植_根内右_接続,
				交配.植内
			},
			{
				接続情報.長物_魚_左0_接続,
				交配.魚
			},
			{
				接続情報.長物_魚_右0_接続,
				交配.魚
			},
			{
				接続情報.長物_魚_左6_接続,
				交配.魚
			},
			{
				接続情報.長物_魚_右6_接続,
				交配.魚
			},
			{
				接続情報.長物_鯨_左0_接続,
				交配.鯨
			},
			{
				接続情報.長物_鯨_右0_接続,
				交配.鯨
			},
			{
				接続情報.長物_鯨_左6_接続,
				交配.鯨
			},
			{
				接続情報.長物_鯨_右6_接続,
				交配.鯨
			},
			{
				接続情報.長物_蛇_左_接続,
				交配.蛇
			},
			{
				接続情報.長物_蛇_右_接続,
				交配.蛇
			},
			{
				接続情報.胴_蛇_左_接続,
				交配.蛇
			},
			{
				接続情報.胴_蛇_右_接続,
				交配.蛇
			},
			{
				接続情報.長物_蟲_左0_接続,
				交配.蟲
			},
			{
				接続情報.長物_蟲_右0_接続,
				交配.蟲
			},
			{
				接続情報.長物_蟲_左1_接続,
				交配.蟲
			},
			{
				接続情報.長物_蟲_右1_接続,
				交配.蟲
			},
			{
				接続情報.尾_蟲_左1_接続,
				交配.蟲尾
			},
			{
				接続情報.尾_蟲_右1_接続,
				交配.蟲尾
			},
			{
				接続情報.尾_蟲_左2_接続,
				交配.蟲尾
			},
			{
				接続情報.尾_蟲_右2_接続,
				交配.蟲尾
			},
			{
				接続情報.尾_蟲_左3_接続,
				交配.蟲尾
			},
			{
				接続情報.尾_蟲_右3_接続,
				交配.蟲尾
			},
			{
				接続情報.尾_蟲_左4_接続,
				交配.蟲尾
			},
			{
				接続情報.尾_蟲_右4_接続,
				交配.蟲尾
			},
			{
				接続情報.尾_蟲_左5_接続,
				交配.蟲尾
			},
			{
				接続情報.尾_蟲_右5_接続,
				交配.蟲尾
			},
			{
				接続情報.尾_蟲_尾左_接続,
				交配.蟲尾先
			},
			{
				接続情報.尾_蟲_尾右_接続,
				交配.蟲尾先
			},
			{
				接続情報.胴_蟲_左_接続,
				交配.蟲
			},
			{
				接続情報.胴_蟲_右_接続,
				交配.蟲
			},
			{
				接続情報.顔面_甲_触覚左_接続,
				交配.触覚甲
			},
			{
				接続情報.顔面_甲_触覚右_接続,
				交配.触覚甲
			},
			{
				接続情報.顔面_虫_触覚左_接続,
				交配.触覚虫
			},
			{
				接続情報.顔面_虫_触覚右_接続,
				交配.触覚虫
			},
			{
				接続情報.顔面_蟲_触覚左_接続,
				交配.触覚蟲
			},
			{
				接続情報.顔面_蟲_触覚右_接続,
				交配.触覚蟲
			},
			{
				接続情報.頭_頭頂_接続,
				交配.頭頂
			},
			{
				接続情報.頭_額_接続,
				交配.額
			},
			{
				接続情報.胸_背中_接続,
				交配.背中人
			},
			{
				接続情報.四足胸_背中_接続,
				交配.背中獣
			},
			{
				接続情報.腰_尾_接続,
				交配.尾人
			},
			{
				接続情報.四足腰_尾_接続,
				交配.尾獣
			},
			{
				接続情報.多足_蜘_尾_接続,
				交配.尾蜘
			},
			{
				接続情報.多足_蠍_尾_接続,
				交配.尾蠍
			},
			{
				接続情報.長物_魚_尾_接続,
				交配.尾魚
			},
			{
				接続情報.長物_鯨_尾_接続,
				交配.尾鯨
			},
			{
				接続情報.長物_蛇_胴_接続,
				交配.尾蛇
			},
			{
				接続情報.長物_蟲_胴_接続,
				交配.尾蟲
			},
			{
				接続情報.胴_蛇_胴_接続,
				交配.尾蛇
			},
			{
				接続情報.胴_蟲_胴_接続,
				交配.尾蟲
			},
			{
				接続情報.単足_植_根中央_接続,
				交配.根中
			},
			{
				接続情報.尾_ヘ_尾先_接続,
				交配.尾先ヘ
			},
			{
				接続情報.尾_ウ_尾先_接続,
				交配.尾先ウ
			},
			{
				接続情報.尾_魚_尾先_接続,
				交配.尾先魚
			},
			{
				接続情報.尾_鯨_尾先_接続,
				交配.尾先鯨
			},
			{
				接続情報.頭頂_宇_頭部後_接続,
				交配.頭頂後
			},
			{
				接続情報.頭_大顎基_接続,
				交配.大顎基
			},
			{
				接続情報.頭_顔面_接続,
				交配.顔面
			},
			{
				接続情報.肩_上腕_接続,
				交配.上腕人
			},
			{
				接続情報.四足脇_上腕_接続,
				交配.上腕獣
			},
			{
				接続情報.上腕_人_下腕_接続,
				交配.下腕人
			},
			{
				接続情報.上腕_鳥_下腕_接続,
				交配.下腕鳥
			},
			{
				接続情報.上腕_蝙_下腕_接続,
				交配.下腕蝙
			},
			{
				接続情報.上腕_獣_下腕_接続,
				交配.下腕獣
			},
			{
				接続情報.上腕_蹄_下腕_接続,
				交配.下腕蹄
			},
			{
				接続情報.下腕_人_手_接続,
				交配.手人
			},
			{
				接続情報.下腕_鳥_手_接続,
				交配.手鳥
			},
			{
				接続情報.下腕_蝙_手_接続,
				交配.手蝙
			},
			{
				接続情報.下腕_獣_手_接続,
				交配.手獣
			},
			{
				接続情報.下腕_蹄_手_接続,
				交配.手蹄
			},
			{
				接続情報.下腕_人_虫鎌_接続,
				交配.虫鎌
			},
			{
				接続情報.腿_人_脚_接続,
				交配.脚人
			},
			{
				接続情報.腿_獣_脚_接続,
				交配.脚獣
			},
			{
				接続情報.腿_蹄_脚_接続,
				交配.脚蹄
			},
			{
				接続情報.腿_鳥_脚_接続,
				交配.脚鳥
			},
			{
				接続情報.腿_竜_脚_接続,
				交配.脚竜
			},
			{
				接続情報.脚_人_足_接続,
				交配.足人
			},
			{
				接続情報.脚_獣_足_接続,
				交配.足獣
			},
			{
				接続情報.脚_蹄_足_接続,
				交配.足蹄
			},
			{
				接続情報.脚_鳥_足_接続,
				交配.足鳥
			},
			{
				接続情報.脚_竜_足_接続,
				交配.足竜
			},
			{
				接続情報.前翅_甲_軸1_接続,
				交配.前翅甲軸1
			},
			{
				接続情報.前翅_甲_軸2_接続,
				交配.前翅甲軸2
			},
			{
				接続情報.前翅_甲_軸3_接続,
				交配.前翅甲軸3
			},
			{
				接続情報.触手_犬_頭_接続,
				交配.犬頭
			},
			{
				接続情報.触手_犬_上腕左_接続,
				交配.犬上腕
			},
			{
				接続情報.触手_犬_上腕右_接続,
				交配.犬上腕
			},
			{
				接続情報.触手_犬_下腕左_接続,
				交配.犬下腕
			},
			{
				接続情報.触手_犬_下腕右_接続,
				交配.犬下腕
			},
			{
				接続情報.触手_犬_手左_接続,
				交配.犬手
			},
			{
				接続情報.触手_犬_手右_接続,
				交配.犬手
			},
			{
				接続情報.触手_蔦_節3_接続,
				交配.蔦
			},
			{
				接続情報.触手_蔦_節5_接続,
				交配.蔦
			},
			{
				接続情報.触手_蔦_節7_接続,
				交配.蔦
			},
			{
				接続情報.触手_蔦_節9_接続,
				交配.蔦
			},
			{
				接続情報.触手_蔦_節11_接続,
				交配.蔦
			},
			{
				接続情報.触手_蔦_節13_接続,
				交配.蔦
			},
			{
				接続情報.触手_蔦_節15_接続,
				交配.蔦
			},
			{
				接続情報.触手_蔦_節17_接続,
				交配.蔦
			},
			{
				接続情報.触手_蔦_節19_接続,
				交配.蔦
			},
			{
				接続情報.触手_蔦_先端_接続,
				交配.蔦先
			},
			{
				接続情報.大顎基_顎左_接続,
				交配.大顎
			},
			{
				接続情報.大顎基_顎右_接続,
				交配.大顎
			},
			{
				接続情報.植_花_接続,
				交配.花
			}
		};

		private static Type 体色t = typeof(体色);

		private static HashSet<string> 実数対象 = new HashSet<string>
		{
			"肥大",
			"身長",
			"サイズ",
			"サイズX",
			"サイズY",
			"目高",
			"目間",
			"眉間",
			"髪長0",
			"髪長1",
			"毛量",
			"広がり",
			"髪長",
			"高さ",
			"髪長2",
			"傾き",
			"外線",
			"睫毛_睫毛3_長さ",
			"睫毛_睫毛1_長さ",
			"睫毛_睫毛2_長さ",
			"睫毛_睫毛4_長さ",
			"睫毛上上左_長さ",
			"睫毛上中左_長さ",
			"睫毛上下左_長さ",
			"睫毛上上右_長さ",
			"睫毛上中右_長さ",
			"睫毛上下右_長さ",
			"睫毛下上左_長さ",
			"睫毛下下左_長さ",
			"睫毛下上右_長さ",
			"睫毛下下右_長さ",
			"瞼左_睫毛1_長さ",
			"瞼左_睫毛2_長さ",
			"瞼右_睫毛1_長さ",
			"瞼右_睫毛2_長さ",
			"口紅濃度",
			"バスト",
			"縁側角",
			"シャープ",
			"鋭爪"
		};

		private static BindingFlags bi = BindingFlags.Instance | BindingFlags.Public;

		private static Type[] t0 = new Type[0];
	}
}
