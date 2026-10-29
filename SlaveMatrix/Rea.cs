using System;
using System.Collections.Generic;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public static class Rea
	{
		public static void Set初期角度(this Cha Cha)
		{
			foreach (Ele ele in Cha.Bod.全要素)
			{
				ele.角度All = 0.0;
				ele.Set角度0();
			}
		}

		public static void Set拘束角度(this Cha Cha)
		{
			Ele[] 全要素 = Cha.Bod.全要素;
			for (int i = 0; i < 全要素.Length; i++)
			{
				全要素[i].Set拘束角度();
			}
			Cha.両腕_人_腕上げ(0, false, false);
			Cha.両腕_人_腕上げ(1, false, false);
			Cha.両腕_人_腕上げ(2, false, false);
			Cha.両腕_人_腕上げ(3, false, false);
		}

		public static void Set触手系対称化(this Cha Cha)
		{
			Ele[] 全要素 = Cha.Bod.全要素;
			try
			{
				List<Ele> list = new List<Ele>();
				List<Ele> list2 = new List<Ele>();
				foreach (Ele ele in 全要素)
				{
					string text = ele.接続情報.ToString();
					if (!(ele is 尾_鳥) && !ele.接続情報.Is左右無し())
					{
						if (text.Contains("左") && (ele is 触手 || ele is 尾))
						{
							list.Add(ele);
						}
						else if (text.Contains("右") && (ele is 触手 || ele is 尾))
						{
							list2.Add(ele);
						}
					}
				}
				list.Sort((Ele x, Ele y) => x.接続情報.ToString().CompareTo(y.接続情報.ToString()));
				list2.Sort((Ele x, Ele y) => x.接続情報.ToString().CompareTo(y.接続情報.ToString()));
				if (list.Count <= list2.Count)
				{
					for (int j = 0; j < list.Count; j++)
					{
						list[j].Set角度(list2[j]);
					}
				}
				else if (list.Count >= list2.Count)
				{
					for (int j = 0; j < list2.Count; j++)
					{
						list2[j].Set角度(list[j]);
					}
				}
				list.Clear();
				list2.Clear();
				foreach (Ele ele2 in 全要素)
				{
					string text = ele2.接続情報.ToString();
					if (!(ele2 is 尾_鳥) && !ele2.接続情報.Is左右無し())
					{
						if (!ele2.右 && (ele2 is 触手 || ele2 is 尾))
						{
							list.Add(ele2);
						}
						else if (ele2.右 && (ele2 is 触手 || ele2 is 尾))
						{
							list2.Add(ele2);
						}
					}
				}
				list.Sort((Ele x, Ele y) => x.ToString().CompareTo(y.ToString()));
				list2.Sort((Ele x, Ele y) => x.ToString().CompareTo(y.ToString()));
				if (list.Count <= list2.Count)
				{
					for (int j = 0; j < list.Count; j++)
					{
						list[j].Set角度(list2[j]);
					}
				}
				else if (list.Count >= list2.Count)
				{
					for (int j = 0; j < list2.Count; j++)
					{
						list2[j].Set角度(list[j]);
					}
				}
			}
			catch (Exception)
			{
			}
		}

		public static void 重複角度処理(this Ele e)
		{
			int num = -1;
			int num2 = 0;
			bool flag = true;
			string b = e.GetType().ToString();
			foreach (Ele ele in e.Par.Enum接続要素(e.接続情報))
			{
				if (ele.GetType().ToString() == b)
				{
					if (flag)
					{
						if (ele != e)
						{
							num2++;
						}
						else
						{
							flag = false;
						}
					}
					num++;
				}
			}
			if (num2 < num)
			{
				if (e.右)
				{
					if (e is 四足脇)
					{
						double num3 = (double)(num - num2) * -13.0;
						e.角度B += num3;
						return;
					}
					if (e.Par is 多足_蛸)
					{
						double num4 = (double)num2 * -17.0;
						e.角度B += num4;
						return;
					}
					if (e is 触手_犬)
					{
						double num5 = (double)(num - num2) * 17.0;
						e.角度B += num5;
						触手_犬 触手_犬 = (触手_犬)e;
						触手_犬.X0Y0_脚前_上腕.AngleBase -= num5;
						触手_犬.X0Y0_脚後_上腕.AngleBase -= num5;
						return;
					}
					double num6 = (double)(num - num2) * -17.0;
					e.角度B += num6;
					return;
				}
				else
				{
					if (e is 四足脇)
					{
						double num3 = (double)(num - num2) * 13.0;
						e.角度B += num3;
						return;
					}
					if (e.Par is 多足_蛸)
					{
						double num7 = (double)num2 * 17.0;
						e.角度B += num7;
						return;
					}
					if (e is 触手_犬)
					{
						double num8 = (double)(num - num2) * -17.0;
						e.角度B += num8;
						触手_犬 触手_犬2 = (触手_犬)e;
						触手_犬2.X0Y0_脚前_上腕.AngleBase -= num8;
						触手_犬2.X0Y0_脚後_上腕.AngleBase -= num8;
						return;
					}
					double num9 = (double)(num - num2) * 17.0;
					e.角度B += num9;
				}
			}
		}

		public static double 角度ムラ(this Cha c, int rs1, double ba1, int rs2, double ba2)
		{
			return (double)rs1 * ba1 * c.ChaD.固有値 + (double)rs2 * ba2 * OthN.XS.NextDouble();
		}

		public static void 眉_無左(this Cha Cha, double u1)
		{
			Cha.Bod.眉左.眉間_表示 = false;
			Cha.Bod.眉左.Yi = 0;
			Cha.Bod.眉左.角度B = u1;
		}

		public static void 眉_無右(this Cha Cha, double u1)
		{
			Cha.Bod.眉右.眉間_表示 = false;
			Cha.Bod.眉右.Yi = 0;
			Cha.Bod.眉右.角度B = -u1;
		}

		public static void 眉_吊左(this Cha Cha, bool 眉間, double u1)
		{
			Cha.Bod.眉左.眉間_表示 = 眉間;
			Cha.Bod.眉左.Yi = 1;
			Cha.Bod.眉左.角度B = u1;
		}

		public static void 眉_吊右(this Cha Cha, bool 眉間, double u1)
		{
			Cha.Bod.眉右.眉間_表示 = 眉間;
			Cha.Bod.眉右.Yi = 1;
			Cha.Bod.眉右.角度B = -u1;
		}

		public static void 眉_顰左(this Cha Cha, bool 眉間, double u1)
		{
			Cha.Bod.眉左.眉間_表示 = 眉間;
			Cha.Bod.眉左.Yi = 2;
			Cha.Bod.眉左.角度B = u1;
		}

		public static void 眉_顰右(this Cha Cha, bool 眉間, double u1)
		{
			Cha.Bod.眉右.眉間_表示 = 眉間;
			Cha.Bod.眉右.Yi = 2;
			Cha.Bod.眉右.角度B = -u1;
		}

		public static void 両眉_無(this Cha Cha)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 0.5, OthN.XS.NextSign(), 0.25);
			Cha.眉_無左(u);
			Cha.眉_無右(u);
		}

		public static void 両眉_吊(this Cha Cha)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 0.5, OthN.XS.NextSign(), 0.25);
			bool flag = Cha.ChaD.固有値 * OthN.XS.NextDouble() > 0.5;
			Cha.眉_吊左(flag, u);
			Cha.眉_吊右(!flag, u);
		}

		public static void 両眉_顰(this Cha Cha)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 0.5, OthN.XS.NextSign(), 0.25);
			bool flag = Cha.ChaD.固有値 * OthN.XS.NextDouble() > 0.5;
			Cha.眉_顰左(flag, u);
			Cha.眉_顰右(!flag, u);
		}

		public static void 両眉_0(this Cha Cha, bool 同角, int i1, int i2)
		{
			double num = Cha.角度ムラ(OthN.XS.NextSign(), 1.0, OthN.XS.NextSign(), 0.5);
			double u;
			if (同角)
			{
				u = num;
			}
			else
			{
				u = Cha.角度ムラ(OthN.XS.NextSign(), 1.0, OthN.XS.NextSign(), 0.5);
			}
			Cha.眉左_0(i1, num);
			Cha.眉右_0(i2, u);
		}

		public static void 眉左_0(this Cha c, int i, double u1)
		{
			switch (i)
			{
			case 0:
				c.眉_無左(u1);
				return;
			case 1:
				c.眉_吊左(false, u1);
				return;
			case 2:
				c.眉_吊左(true, u1);
				return;
			case 3:
				c.眉_顰左(false, u1);
				return;
			case 4:
				c.眉_顰左(true, u1);
				return;
			default:
				return;
			}
		}

		public static void 眉右_0(this Cha c, int i, double u1)
		{
			switch (i)
			{
			case 0:
				c.眉_無右(u1);
				return;
			case 1:
				c.眉_吊右(false, u1);
				return;
			case 2:
				c.眉_吊右(true, u1);
				return;
			case 3:
				c.眉_顰右(false, u1);
				return;
			case 4:
				c.眉_顰右(true, u1);
				return;
			default:
				return;
			}
		}

		public static void 眉_下左(this Cha Cha)
		{
			Cha.Bod.眉左.本体.CurJoinRoot.PositionCont = Dat.Vec2DZero;
		}

		public static void 眉_下右(this Cha Cha)
		{
			Cha.Bod.眉右.本体.CurJoinRoot.PositionCont = Dat.Vec2DZero;
		}

		public static void 眉_上左(this Cha Cha)
		{
			Cha.Bod.眉左.本体.CurJoinRoot.PositionCont = -Dat.Vec2DUnitY * 0.003;
		}

		public static void 眉_上右(this Cha Cha)
		{
			Cha.Bod.眉右.本体.CurJoinRoot.PositionCont = -Dat.Vec2DUnitY * 0.003;
		}

		public static void 両眉_下(this Cha Cha)
		{
			Cha.眉_下左();
			Cha.眉_下右();
		}

		public static void 両眉_上(this Cha Cha)
		{
			Cha.眉_上左();
			Cha.眉_上右();
		}

		public static void 両眉_1(this Cha Cha, int i1, int i2)
		{
			Cha.眉左_1(i1);
			Cha.眉右_1(i2);
		}

		public static void 眉左_1(this Cha c, int i)
		{
			if (i == 0)
			{
				c.眉_下左();
				return;
			}
			if (i != 1)
			{
				return;
			}
			c.眉_上左();
		}

		public static void 眉右_1(this Cha c, int i)
		{
			if (i == 0)
			{
				c.眉_下右();
				return;
			}
			if (i != 1)
			{
				return;
			}
			c.眉_上右();
		}

		public static void 単眉_無(this Cha Cha)
		{
			Cha.Bod.単眼眉.Yi = 0;
		}

		public static void 単眉_吊(this Cha Cha)
		{
			Cha.Bod.単眼眉.Yi = 1;
		}

		public static void 単眉_顰(this Cha Cha)
		{
			Cha.Bod.単眼眉.Yi = 2;
		}

		public static void 単眉_0(this Cha c, int i)
		{
			switch (i)
			{
			case 0:
				c.単眉_無();
				return;
			case 1:
				c.単眉_吊();
				return;
			case 2:
				c.単眉_顰();
				return;
			default:
				return;
			}
		}

		public static void 単眉_下(this Cha Cha)
		{
			Cha.Bod.単眼眉.本体.CurJoinRoot.PositionCont = Dat.Vec2DZero;
		}

		public static void 単眉_上(this Cha Cha)
		{
			Cha.Bod.単眼眉.本体.CurJoinRoot.PositionCont = -Dat.Vec2DUnitY * 0.003;
		}

		public static void 単眉_1(this Cha c, int i)
		{
			if (i == 0)
			{
				c.単眉_下();
				return;
			}
			if (i != 1)
			{
				return;
			}
			c.単眉_上();
		}

		public static void 目_見つめ左(this Cha Cha)
		{
			Cha.Bod.目左.視線 = new Vector2D(0.0, -0.00023);
			Cha.Bod.目左.X0Y0_黒目_黒目.SizeXCont = 1.0;
			Cha.Bod.目左.X0Y0_黒目_瞳孔.SizeXCont = 1.0;
		}

		public static void 目_見つめ右(this Cha Cha)
		{
			Cha.Bod.目右.視線 = new Vector2D(0.0, -0.00023);
			Cha.Bod.目右.X0Y0_黒目_黒目.SizeXCont = 1.0;
			Cha.Bod.目右.X0Y0_黒目_瞳孔.SizeXCont = 1.0;
		}

		public static void 目_逸らし左(this Cha Cha, bool b)
		{
			Cha.Bod.目左.視線 = new Vector2D((b ? 1.0 : -1.0) * 0.0015, 0.0);
			Cha.Bod.目左.X0Y0_黒目_黒目.SizeXCont = 0.95;
			Cha.Bod.目左.X0Y0_黒目_瞳孔.SizeXCont = 0.95;
		}

		public static void 目_逸らし右(this Cha Cha, bool b)
		{
			Cha.Bod.目右.視線 = new Vector2D((b ? 1.0 : -1.0) * 0.0015, 0.0);
			Cha.Bod.目右.X0Y0_黒目_黒目.SizeXCont = 0.95;
			Cha.Bod.目右.X0Y0_黒目_瞳孔.SizeXCont = 0.95;
		}

		public static void 目_上転左(this Cha Cha)
		{
			Cha.Bod.目左.視線 = new Vector2D(0.0, -0.0021);
			Cha.Bod.目左.X0Y0_黒目_黒目.SizeXCont = 1.0;
			Cha.Bod.目左.X0Y0_黒目_瞳孔.SizeXCont = 1.0;
		}

		public static void 目_上転右(this Cha Cha)
		{
			Cha.Bod.目右.視線 = new Vector2D(0.0, -0.002);
			Cha.Bod.目右.X0Y0_黒目_黒目.SizeXCont = 1.0;
			Cha.Bod.目右.X0Y0_黒目_瞳孔.SizeXCont = 1.0;
		}

		public static void 両目_見つめ(this Cha Cha)
		{
			Cha.目_見つめ左();
			Cha.目_見つめ右();
		}

		public static void 両目_逸らし(this Cha Cha)
		{
			bool b = OthN.XS.NextBool();
			Cha.目_逸らし左(b);
			Cha.目_逸らし右(b);
		}

		public static void 両目_上転(this Cha Cha)
		{
			Cha.目_上転左();
			Cha.目_上転右();
		}

		public static void 両目_0(this Cha Cha, int i1, int i2)
		{
			Cha.目左_0(i1);
			Cha.目右_0(i2);
		}

		public static void 目左_0(this Cha c, int i)
		{
			switch (i)
			{
			case 0:
				c.目_見つめ左();
				return;
			case 1:
				c.目_逸らし左(false);
				return;
			case 2:
				c.目_逸らし左(true);
				return;
			case 3:
				c.目_上転左();
				return;
			default:
				return;
			}
		}

		public static void 目右_0(this Cha c, int i)
		{
			switch (i)
			{
			case 0:
				c.目_見つめ右();
				return;
			case 1:
				c.目_逸らし右(false);
				return;
			case 2:
				c.目_逸らし右(true);
				return;
			case 3:
				c.目_上転右();
				return;
			default:
				return;
			}
		}

		public static void 頬目_見つめ左(this Cha Cha)
		{
			Cha.Bod.頬目左.視線 = new Vector2D(0.0, -0.00023);
			Cha.Bod.頬目左.X0Y0_黒目_黒目.SizeXCont = 1.0;
			Cha.Bod.頬目左.X0Y0_黒目_瞳孔.SizeXCont = 1.0;
			Cha.Bod.頬目左.X0Y0_黒目_黒目.SizeYCont = 1.0;
			Cha.Bod.頬目左.X0Y0_黒目_瞳孔.SizeYCont = 1.0;
		}

		public static void 頬目_見つめ右(this Cha Cha)
		{
			Cha.Bod.頬目右.視線 = new Vector2D(0.0, -0.00023);
			Cha.Bod.頬目右.X0Y0_黒目_黒目.SizeXCont = 1.0;
			Cha.Bod.頬目右.X0Y0_黒目_瞳孔.SizeXCont = 1.0;
			Cha.Bod.頬目右.X0Y0_黒目_黒目.SizeYCont = 1.0;
			Cha.Bod.頬目右.X0Y0_黒目_瞳孔.SizeYCont = 1.0;
		}

		public static void 頬目_逸らし左(this Cha Cha, bool b)
		{
			Cha.Bod.頬目左.視線 = new Vector2D((b ? 1.0 : -1.0) * 0.0015, 0.0);
			Cha.Bod.頬目左.X0Y0_黒目_黒目.SizeXCont = 0.95;
			Cha.Bod.頬目左.X0Y0_黒目_瞳孔.SizeXCont = 0.95;
			Cha.Bod.頬目左.X0Y0_黒目_黒目.SizeYCont = 1.0;
			Cha.Bod.頬目左.X0Y0_黒目_瞳孔.SizeYCont = 1.0;
		}

		public static void 頬目_逸らし右(this Cha Cha, bool b)
		{
			Cha.Bod.頬目右.視線 = new Vector2D((b ? 1.0 : -1.0) * 0.0015, 0.0);
			Cha.Bod.頬目右.X0Y0_黒目_黒目.SizeXCont = 0.95;
			Cha.Bod.頬目右.X0Y0_黒目_瞳孔.SizeXCont = 0.95;
			Cha.Bod.頬目右.X0Y0_黒目_黒目.SizeYCont = 1.0;
			Cha.Bod.頬目右.X0Y0_黒目_瞳孔.SizeYCont = 1.0;
		}

		public static void 頬目_上転左(this Cha Cha)
		{
			Cha.Bod.頬目左.視線 = new Vector2D(0.0, -0.0016);
			Cha.Bod.頬目左.X0Y0_黒目_黒目.SizeXCont = 1.0;
			Cha.Bod.頬目左.X0Y0_黒目_瞳孔.SizeXCont = 1.0;
			Cha.Bod.頬目左.X0Y0_黒目_黒目.SizeYCont = 0.75;
			Cha.Bod.頬目左.X0Y0_黒目_瞳孔.SizeYCont = 0.75;
		}

		public static void 頬目_上転右(this Cha Cha)
		{
			Cha.Bod.頬目右.視線 = new Vector2D(0.0, -0.0016);
			Cha.Bod.頬目右.X0Y0_黒目_黒目.SizeXCont = 1.0;
			Cha.Bod.頬目右.X0Y0_黒目_瞳孔.SizeXCont = 1.0;
			Cha.Bod.頬目右.X0Y0_黒目_黒目.SizeYCont = 0.75;
			Cha.Bod.頬目右.X0Y0_黒目_瞳孔.SizeYCont = 0.75;
		}

		public static void 両頬目_見つめ(this Cha Cha)
		{
			Cha.頬目_見つめ左();
			Cha.頬目_見つめ右();
		}

		public static void 両頬目_逸らし(this Cha Cha)
		{
			bool b = OthN.XS.NextBool();
			Cha.頬目_逸らし左(b);
			Cha.頬目_逸らし右(b);
		}

		public static void 両頬目_上転(this Cha Cha)
		{
			Cha.頬目_上転左();
			Cha.頬目_上転右();
		}

		public static void 両頬目_0(this Cha Cha, int i1, int i2)
		{
			Cha.頬目左_0(i1);
			Cha.頬目右_0(i2);
		}

		public static void 頬目左_0(this Cha c, int i)
		{
			switch (i)
			{
			case 0:
				c.頬目_見つめ左();
				return;
			case 1:
				c.頬目_逸らし左(false);
				return;
			case 2:
				c.頬目_逸らし左(true);
				return;
			case 3:
				c.頬目_上転左();
				return;
			default:
				return;
			}
		}

		public static void 頬目右_0(this Cha c, int i)
		{
			switch (i)
			{
			case 0:
				c.頬目_見つめ右();
				return;
			case 1:
				c.頬目_逸らし右(false);
				return;
			case 2:
				c.頬目_逸らし右(true);
				return;
			case 3:
				c.頬目_上転右();
				return;
			default:
				return;
			}
		}

		public static void 額目_見つめ(this Cha Cha)
		{
			Cha.Bod.額目.視線 = new Vector2D(0.0, 0.0);
			Cha.Bod.額目.X0Y0_黒目_黒目.SizeXCont = 1.0;
			Cha.Bod.額目.X0Y0_黒目_瞳孔.SizeXCont = 1.0;
			Cha.Bod.額目.X0Y0_黒目_黒目.SizeYCont = 1.0;
			Cha.Bod.額目.X0Y0_黒目_瞳孔.SizeYCont = 1.0;
		}

		public static void 額目_逸らし(this Cha Cha, bool b)
		{
			Cha.Bod.額目.視線 = new Vector2D((b ? 1.0 : -1.0) * 0.0014, 0.0);
			Cha.Bod.額目.X0Y0_黒目_黒目.SizeXCont = 0.9;
			Cha.Bod.額目.X0Y0_黒目_瞳孔.SizeXCont = 0.9;
			Cha.Bod.額目.X0Y0_黒目_黒目.SizeYCont = 1.0;
			Cha.Bod.額目.X0Y0_黒目_瞳孔.SizeYCont = 1.0;
		}

		public static void 額目_上転(this Cha Cha)
		{
			Cha.Bod.額目.視線 = new Vector2D(0.0, -0.0025);
			Cha.Bod.額目.X0Y0_黒目_黒目.SizeXCont = 1.0;
			Cha.Bod.額目.X0Y0_黒目_瞳孔.SizeXCont = 1.0;
			Cha.Bod.額目.X0Y0_黒目_黒目.SizeYCont = 0.95;
			Cha.Bod.額目.X0Y0_黒目_瞳孔.SizeYCont = 0.95;
		}

		public static void 額目_0(this Cha c, int i)
		{
			switch (i)
			{
			case 0:
				c.額目_見つめ();
				return;
			case 1:
				c.額目_逸らし(false);
				return;
			case 2:
				c.額目_逸らし(true);
				return;
			case 3:
				c.額目_上転();
				return;
			default:
				return;
			}
		}

		public static void 単目_見つめ(this Cha Cha)
		{
			Cha.Bod.単眼目.視線 = new Vector2D(0.0, -0.00023);
			Cha.Bod.単眼目.X0Y0_黒目_黒目.SizeXCont = 1.0;
			Cha.Bod.単眼目.X0Y0_黒目_瞳孔.SizeXCont = 1.0;
		}

		public static void 単目_逸らし(this Cha Cha, bool b)
		{
			Cha.Bod.単眼目.視線 = new Vector2D((b ? 1.0 : -1.0) * 0.0025, 0.0);
			Cha.Bod.単眼目.X0Y0_黒目_黒目.SizeXCont = 0.95;
			Cha.Bod.単眼目.X0Y0_黒目_瞳孔.SizeXCont = 0.95;
		}

		public static void 単目_上転(this Cha Cha)
		{
			Cha.Bod.単眼目.視線 = new Vector2D(0.0, -0.0035);
			Cha.Bod.単眼目.X0Y0_黒目_黒目.SizeXCont = 1.0;
			Cha.Bod.単眼目.X0Y0_黒目_瞳孔.SizeXCont = 1.0;
		}

		public static void 単目_0(this Cha c, int i)
		{
			switch (i)
			{
			case 0:
				c.単目_見つめ();
				return;
			case 1:
				c.単目_逸らし(false);
				return;
			case 2:
				c.単目_逸らし(true);
				return;
			case 3:
				c.単目_上転();
				return;
			default:
				return;
			}
		}

		public static void 瞼_普左(this Cha Cha)
		{
			Cha.Bod.瞼左.Xi = 0;
		}

		public static void 瞼_普右(this Cha Cha)
		{
			Cha.Bod.瞼右.Xi = 0;
		}

		public static void 瞼_卑左(this Cha Cha)
		{
			Cha.Bod.瞼左.Xi = 1;
		}

		public static void 瞼_卑右(this Cha Cha)
		{
			Cha.Bod.瞼右.Xi = 1;
		}

		public static void 両瞼_普(this Cha Cha)
		{
			Cha.瞼_普左();
			Cha.瞼_普右();
		}

		public static void 両瞼_卑(this Cha Cha)
		{
			Cha.瞼_卑左();
			Cha.瞼_卑右();
		}

		public static void 両瞼_0(this Cha Cha, int i1, int i2)
		{
			Cha.瞼左_0(i1);
			Cha.瞼右_0(i2);
		}

		public static void 瞼左_0(this Cha c, int i)
		{
			if (i == 0)
			{
				c.瞼_普左();
				return;
			}
			if (i != 1)
			{
				return;
			}
			c.瞼_卑左();
		}

		public static void 瞼右_0(this Cha c, int i)
		{
			if (i == 0)
			{
				c.瞼_普右();
				return;
			}
			if (i != 1)
			{
				return;
			}
			c.瞼_卑右();
		}

		public static void 頬瞼_普左(this Cha Cha)
		{
			Cha.Bod.頬瞼左.Xi = 0;
		}

		public static void 頬瞼_普右(this Cha Cha)
		{
			Cha.Bod.頬瞼右.Xi = 0;
		}

		public static void 頬瞼_卑左(this Cha Cha)
		{
			Cha.Bod.頬瞼左.Xi = 1;
		}

		public static void 頬瞼_卑右(this Cha Cha)
		{
			Cha.Bod.頬瞼右.Xi = 1;
		}

		public static void 両頬瞼_0(this Cha Cha, int i1, int i2)
		{
			Cha.頬瞼左_0(i1);
			Cha.頬瞼右_0(i2);
		}

		public static void 頬瞼左_0(this Cha c, int i)
		{
			if (i == 0)
			{
				c.頬瞼_普左();
				return;
			}
			if (i != 1)
			{
				return;
			}
			c.頬瞼_卑左();
		}

		public static void 頬瞼右_0(this Cha c, int i)
		{
			if (i == 0)
			{
				c.頬瞼_普右();
				return;
			}
			if (i != 1)
			{
				return;
			}
			c.頬瞼_卑右();
		}

		public static void 額瞼_普(this Cha Cha)
		{
			Cha.Bod.額瞼.Xi = 0;
		}

		public static void 額瞼_卑(this Cha Cha)
		{
			Cha.Bod.額瞼.Xi = 1;
		}

		public static void 額瞼_0(this Cha c, int i)
		{
			if (i == 0)
			{
				c.額瞼_普();
				return;
			}
			if (i != 1)
			{
				return;
			}
			c.額瞼_卑();
		}

		public static void 単瞼_普(this Cha Cha)
		{
			Cha.Bod.単眼瞼.Xi = 0;
		}

		public static void 単瞼_卑(this Cha Cha)
		{
			Cha.Bod.単眼瞼.Xi = 1;
		}

		public static void 単瞼_0(this Cha c, int i)
		{
			if (i == 0)
			{
				c.単瞼_普();
				return;
			}
			if (i != 1)
			{
				return;
			}
			c.単瞼_卑();
		}

		public static void 瞼_基左(this Cha Cha)
		{
			Cha.瞼基準左 = 0.0;
		}

		public static void 瞼_基右(this Cha Cha)
		{
			Cha.瞼基準右 = 0.0;
		}

		public static void 瞼_半1左(this Cha Cha)
		{
			Cha.瞼基準左 = 0.2;
		}

		public static void 瞼_半1右(this Cha Cha)
		{
			Cha.瞼基準右 = 0.2;
		}

		public static void 瞼_半2左(this Cha Cha)
		{
			Cha.瞼基準左 = 0.4;
		}

		public static void 瞼_半2右(this Cha Cha)
		{
			Cha.瞼基準右 = 0.4;
		}

		public static void 瞼_瞑左(this Cha Cha)
		{
			Cha.瞼基準左 = 1.0;
		}

		public static void 瞼_瞑右(this Cha Cha)
		{
			Cha.瞼基準右 = 1.0;
		}

		public static void 両瞼_基(this Cha Cha)
		{
			Cha.瞼_基左();
			Cha.瞼_基右();
		}

		public static void 両瞼_半1(this Cha Cha)
		{
			Cha.瞼_半1左();
			Cha.瞼_半1右();
		}

		public static void 両瞼_半2(this Cha Cha)
		{
			Cha.瞼_半2左();
			Cha.瞼_半2右();
		}

		public static void 両瞼_瞑(this Cha Cha)
		{
			Cha.瞼_瞑左();
			Cha.瞼_瞑右();
		}

		public static void 両瞼_1(this Cha Cha, int i1, int i2)
		{
			Cha.瞼左_1(i1);
			Cha.瞼右_1(i2);
		}

		public static void 瞼左_1(this Cha c, int i)
		{
			switch (i)
			{
			case 0:
				c.瞼_基左();
				return;
			case 1:
				c.瞼_半1左();
				return;
			case 2:
				c.瞼_半2左();
				return;
			case 3:
				c.瞼_瞑左();
				return;
			default:
				return;
			}
		}

		public static void 瞼右_1(this Cha c, int i)
		{
			switch (i)
			{
			case 0:
				c.瞼_基右();
				return;
			case 1:
				c.瞼_半1右();
				return;
			case 2:
				c.瞼_半2右();
				return;
			case 3:
				c.瞼_瞑右();
				return;
			default:
				return;
			}
		}

		public static void 頬瞼_基左(this Cha Cha)
		{
			Cha.瞼基準頬左 = 0.0;
		}

		public static void 頬瞼_基右(this Cha Cha)
		{
			Cha.瞼基準頬右 = 0.0;
		}

		public static void 頬瞼_半1左(this Cha Cha)
		{
			Cha.瞼基準頬左 = 0.2;
		}

		public static void 頬瞼_半1右(this Cha Cha)
		{
			Cha.瞼基準頬右 = 0.2;
		}

		public static void 頬瞼_半2左(this Cha Cha)
		{
			Cha.瞼基準頬左 = 0.4;
		}

		public static void 頬瞼_半2右(this Cha Cha)
		{
			Cha.瞼基準頬右 = 0.4;
		}

		public static void 頬瞼_瞑左(this Cha Cha)
		{
			Cha.瞼基準頬左 = 1.0;
		}

		public static void 頬瞼_瞑右(this Cha Cha)
		{
			Cha.瞼基準頬右 = 1.0;
		}

		public static void 両頬瞼_基(this Cha Cha)
		{
			Cha.頬瞼_基左();
			Cha.頬瞼_基右();
		}

		public static void 両頬瞼_半1(this Cha Cha)
		{
			Cha.頬瞼_半1左();
			Cha.頬瞼_半1右();
		}

		public static void 両頬瞼_半2(this Cha Cha)
		{
			Cha.頬瞼_半2左();
			Cha.頬瞼_半2右();
		}

		public static void 両頬瞼_瞑(this Cha Cha)
		{
			Cha.頬瞼_瞑左();
			Cha.頬瞼_瞑右();
		}

		public static void 両頬瞼_1(this Cha Cha, int i1, int i2)
		{
			Cha.頬瞼左_1(i1);
			Cha.頬瞼右_1(i2);
		}

		public static void 頬瞼左_1(this Cha c, int i)
		{
			switch (i)
			{
			case 0:
				c.頬瞼_基左();
				return;
			case 1:
				c.頬瞼_半1左();
				return;
			case 2:
				c.頬瞼_半2左();
				return;
			case 3:
				c.頬瞼_瞑左();
				return;
			default:
				return;
			}
		}

		public static void 頬瞼右_1(this Cha c, int i)
		{
			switch (i)
			{
			case 0:
				c.頬瞼_基右();
				return;
			case 1:
				c.頬瞼_半1右();
				return;
			case 2:
				c.頬瞼_半2右();
				return;
			case 3:
				c.頬瞼_瞑右();
				return;
			default:
				return;
			}
		}

		public static void 額瞼_基(this Cha Cha)
		{
			Cha.瞼基準額 = 0.0;
		}

		public static void 額瞼_半1(this Cha Cha)
		{
			Cha.瞼基準額 = 0.2;
		}

		public static void 額瞼_半2(this Cha Cha)
		{
			Cha.瞼基準額 = 0.4;
		}

		public static void 額瞼_瞑(this Cha Cha)
		{
			Cha.瞼基準額 = 1.0;
		}

		public static void 額瞼_1(this Cha c, int i)
		{
			switch (i)
			{
			case 0:
				c.額瞼_基();
				return;
			case 1:
				c.額瞼_半1();
				return;
			case 2:
				c.額瞼_半2();
				return;
			case 3:
				c.額瞼_瞑();
				return;
			default:
				return;
			}
		}

		public static void 単瞼_基(this Cha Cha)
		{
			Cha.瞼基準単 = 0.0;
		}

		public static void 単瞼_半1(this Cha Cha)
		{
			Cha.瞼基準単 = 0.2;
		}

		public static void 単瞼_半2(this Cha Cha)
		{
			Cha.瞼基準単 = 0.4;
		}

		public static void 単瞼_瞑(this Cha Cha)
		{
			Cha.瞼基準単 = 1.0;
		}

		public static void 単瞼_1(this Cha c, int i)
		{
			switch (i)
			{
			case 0:
				c.単瞼_基();
				return;
			case 1:
				c.単瞼_半1();
				return;
			case 2:
				c.単瞼_半2();
				return;
			case 3:
				c.単瞼_瞑();
				return;
			default:
				return;
			}
		}

		public static void 口_閉じ(this Cha Cha)
		{
			Cha.Bod.口i = 10;
		}

		public static void 口_半開1(this Cha Cha)
		{
			Cha.Bod.口i = 5;
		}

		public static void 口_半開2(this Cha Cha)
		{
			Cha.Bod.口i = 6;
		}

		public static void 口_開き(this Cha Cha)
		{
			Cha.Bod.口i = 9;
		}

		public static void 口_閉笑(this Cha Cha)
		{
			Cha.Bod.口i = 4;
		}

		public static void 口_薄笑(this Cha Cha)
		{
			Cha.Bod.口i = 0;
		}

		public static void 口_笑い(this Cha Cha)
		{
			Cha.Bod.口i = 1;
		}

		public static void 口_薄笑食縛(this Cha Cha)
		{
			Cha.Bod.口i = 2;
		}

		public static void 口_笑い食縛(this Cha Cha)
		{
			Cha.Bod.口i = 3;
		}

		public static void 口_紡ぎ(this Cha Cha)
		{
			Cha.Bod.口i = 11;
		}

		public static void 口_食縛1(this Cha Cha)
		{
			Cha.Bod.口i = 7;
		}

		public static void 口_食縛2(this Cha Cha)
		{
			Cha.Bod.口i = 8;
		}

		public static void 口_咥え(this Cha Cha)
		{
			Cha.Bod.口i = 12;
		}

		public static void 口_しゃぶり(this Cha Cha)
		{
			Cha.Bod.口i = 13;
		}

		public static void 口_0(this Cha c, int i)
		{
			switch (i)
			{
			case 0:
				c.口_閉じ();
				return;
			case 1:
				c.口_半開1();
				return;
			case 2:
				c.口_半開2();
				return;
			case 3:
				c.口_開き();
				return;
			case 4:
				c.口_閉笑();
				return;
			case 5:
				c.口_薄笑();
				return;
			case 6:
				c.口_笑い();
				return;
			case 7:
				c.口_薄笑食縛();
				return;
			case 8:
				c.口_笑い食縛();
				return;
			case 9:
				c.口_紡ぎ();
				return;
			case 10:
				c.口_食縛1();
				return;
			case 11:
				c.口_食縛2();
				return;
			case 12:
				c.口_咥え();
				return;
			case 13:
				c.口_しゃぶり();
				return;
			default:
				return;
			}
		}

		public static void 口修正(this Cha c)
		{
			if (c.Bod.口i == 5 || c.Bod.口i == 6 || c.Bod.口i == 7 || c.Bod.口i == 8 || c.Bod.口i == 9 || c.Bod.口i == 12 || c.Bod.口i == 13)
			{
				if (c.ChaD.状態 < 感情.受容)
				{
					int num = OthN.XS.Next(2);
					if (num == 0)
					{
						c.口_閉じ();
						return;
					}
					if (num != 1)
					{
						return;
					}
					c.口_紡ぎ();
					return;
				}
				else
				{
					switch (OthN.XS.Next(3))
					{
					case 0:
						c.口_閉笑();
						return;
					case 1:
						c.口_薄笑();
						return;
					case 2:
						c.口_笑い();
						break;
					default:
						return;
					}
				}
			}
		}

		public static void 舌_無し(this Cha Cha)
		{
			Cha.Bod.舌_表示 = false;
		}

		public static void 舌_出し(this Cha Cha)
		{
			Cha.Bod.舌_表示 = true;
			Cha.Bod.舌.尺度YC = 0.2 + 0.8 * OthN.XS.NextDouble();
		}

		public static void 舌_0(this Cha c, int i)
		{
			if (i == 0)
			{
				c.舌_無し();
				return;
			}
			if (i != 1)
			{
				return;
			}
			c.舌_出し();
		}

		public static void 耳_人_基左(this Cha Cha)
		{
			Cha.Bod.耳左.Yi = 0;
		}

		public static void 耳_人_基右(this Cha Cha)
		{
			Cha.Bod.耳右.Yi = 0;
		}

		public static void 耳_人_半左(this Cha Cha)
		{
			Cha.Bod.耳左.Yi = 1;
		}

		public static void 耳_人_半右(this Cha Cha)
		{
			Cha.Bod.耳右.Yi = 1;
		}

		public static void 耳_人_伏左(this Cha Cha)
		{
			Cha.Bod.耳左.Yi = 2;
		}

		public static void 耳_人_伏右(this Cha Cha)
		{
			Cha.Bod.耳右.Yi = 2;
		}

		public static void 両耳_0(this Cha Cha, int i1, int i2)
		{
			Cha.耳左_0(i1);
			Cha.耳右_0(i2);
		}

		public static void 耳左_0(this Cha c, int i)
		{
			switch (i)
			{
			case 0:
				c.耳_人_基左();
				return;
			case 1:
				c.耳_人_半左();
				return;
			case 2:
				c.耳_人_伏左();
				return;
			default:
				return;
			}
		}

		public static void 耳右_0(this Cha c, int i)
		{
			switch (i)
			{
			case 0:
				c.耳_人_基右();
				return;
			case 1:
				c.耳_人_半右();
				return;
			case 2:
				c.耳_人_伏右();
				return;
			default:
				return;
			}
		}

		public static void 耳_獣_基左(this Cha Cha)
		{
			Cha.Bod.獣耳左.Yi = 0;
		}

		public static void 耳_獣_基右(this Cha Cha)
		{
			Cha.Bod.獣耳右.Yi = 0;
		}

		public static void 耳_獣_半左(this Cha Cha)
		{
			Cha.Bod.獣耳左.Yi = 1;
		}

		public static void 耳_獣_半右(this Cha Cha)
		{
			Cha.Bod.獣耳右.Yi = 1;
		}

		public static void 耳_獣_伏左(this Cha Cha)
		{
			Cha.Bod.獣耳左.Yi = 2;
		}

		public static void 耳_獣_伏右(this Cha Cha)
		{
			Cha.Bod.獣耳右.Yi = 2;
		}

		public static void 両獣耳_0(this Cha Cha, int i1, int i2)
		{
			Cha.獣耳左_0(i1);
			Cha.獣耳右_0(i2);
		}

		public static void 獣耳左_0(this Cha c, int i)
		{
			switch (i)
			{
			case 0:
				c.耳_獣_基左();
				return;
			case 1:
				c.耳_獣_半左();
				return;
			case 2:
				c.耳_獣_伏左();
				return;
			default:
				return;
			}
		}

		public static void 獣耳右_0(this Cha c, int i)
		{
			switch (i)
			{
			case 0:
				c.耳_獣_基右();
				return;
			case 1:
				c.耳_獣_半右();
				return;
			case 2:
				c.耳_獣_伏右();
				return;
			default:
				return;
			}
		}

		public static void 触覚左(this Cha Cha, double u1, double u2, double 根本角度, params Func<int, double>[] angs)
		{
			Cha.Bod.触覚左.Set角度0();
			if (angs.Length != 0)
			{
				Par[] array = Cha.Bod.触覚左.Enum軸().ToArray<Par>();
				if (array.Length != 0)
				{
					int num = 0;
					int num2 = array.Length / angs.Length;
					double num3 = (double)array.Length * 0.1;
					foreach (Par par in array.Skip(1))
					{
						par.AngleBase = angs[(num / num2).Limit(0, angs.Length)](num) / num3 + u2;
						num++;
					}
					array[0].AngleBase = 根本角度 + u1;
				}
			}
		}

		public static void 触覚右(this Cha Cha, double u1, double u2, double 根本角度, params Func<int, double>[] angs)
		{
			Cha.Bod.触覚右.Set角度0();
			if (angs.Length != 0)
			{
				Par[] array = Cha.Bod.触覚右.Enum軸().ToArray<Par>();
				if (array.Length != 0)
				{
					int num = 0;
					int num2 = array.Length / angs.Length;
					double num3 = (double)array.Length * 0.1;
					foreach (Par par in array.Skip(1))
					{
						par.AngleBase = -(angs[(num / num2).Limit(0, angs.Length)](num) / num3) + -u2;
						num++;
					}
					array[0].AngleBase = -根本角度 + -u1;
				}
			}
		}

		public static void 触覚_基本左(this Cha Cha, double u1, double u2)
		{
			Cha.触覚左(u1, u2, 0.0, new Func<int, double>[0]);
		}

		public static void 触覚_基本右(this Cha Cha, double u1, double u2)
		{
			Cha.触覚右(u1, u2, 0.0, new Func<int, double>[0]);
		}

		public static void 触覚_ピ\u30FCン左(this Cha Cha, double u1, double u2)
		{
			double 根本角度 = -30.0;
			Func<int, double>[] array = new Func<int, double>[1];
			array[0] = ((int i) => 0.0);
			Cha.触覚左(u1, u2, 根本角度, array);
		}

		public static void 触覚_ピ\u30FCン右(this Cha Cha, double u1, double u2)
		{
			double 根本角度 = -30.0;
			Func<int, double>[] array = new Func<int, double>[1];
			array[0] = ((int i) => 0.0);
			Cha.触覚右(u1, u2, 根本角度, array);
		}

		public static void 触覚_下げ左(this Cha Cha, double u1, double u2)
		{
			double 根本角度 = -50.0;
			Func<int, double>[] array = new Func<int, double>[1];
			array[0] = ((int i) => -15.0);
			Cha.触覚左(u1, u2, 根本角度, array);
		}

		public static void 触覚_下げ右(this Cha Cha, double u1, double u2)
		{
			double 根本角度 = -50.0;
			Func<int, double>[] array = new Func<int, double>[1];
			array[0] = ((int i) => -15.0);
			Cha.触覚右(u1, u2, 根本角度, array);
		}

		public static void 触覚_基本(this Cha Cha)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			Cha.触覚_基本左(u, u2);
			Cha.触覚_基本右(u, u2);
		}

		public static void 触覚_ピ\u30FCン(this Cha Cha)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			Cha.触覚_ピ\u30FCン左(u, u2);
			Cha.触覚_ピ\u30FCン右(u, u2);
		}

		public static void 触覚_下げ(this Cha Cha)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			Cha.触覚_下げ左(u, u2);
			Cha.触覚_下げ右(u, u2);
		}

		public static void 両触覚_0(this Cha Cha, bool 同角, int i1, int i2)
		{
			double num = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			double num2 = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			double u;
			double u2;
			if (同角)
			{
				u = num;
				u2 = num2;
			}
			else
			{
				u = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
				u2 = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			}
			Cha.触覚左_0(i1, num, num2);
			Cha.触覚右_0(i2, u, u2);
		}

		public static void 触覚左_0(this Cha c, int i, double u1, double u2)
		{
			switch (i)
			{
			case 0:
				c.触覚_基本左(u1, u2);
				return;
			case 1:
				c.触覚_ピ\u30FCン左(u1, u2);
				return;
			case 2:
				c.触覚_下げ左(u1, u2);
				return;
			default:
				return;
			}
		}

		public static void 触覚右_0(this Cha c, int i, double u1, double u2)
		{
			switch (i)
			{
			case 0:
				c.触覚_基本右(u1, u2);
				return;
			case 1:
				c.触覚_ピ\u30FCン右(u1, u2);
				return;
			case 2:
				c.触覚_下げ右(u1, u2);
				return;
			default:
				return;
			}
		}

		public static void 触覚絶頂(this Cha Cha, double a)
		{
			Cha.Bod.触覚左.角度C = a * OthN.XS.NextDouble();
			Cha.Bod.触覚右.角度C = -a * OthN.XS.NextDouble();
		}

		public static void 触覚甲左(this Cha Cha, double u1, double u2, double 根本角度, double 節角度)
		{
			Cha.Bod.触覚甲左.Set角度0();
			Cha.Bod.触覚甲左.X0Y0_節0.AngleBase += 根本角度 + u1;
			Cha.Bod.触覚甲左.X0Y0_節1.AngleBase += 節角度 + u2;
		}

		public static void 触覚甲右(this Cha Cha, double u1, double u2, double 根本角度, double 節角度)
		{
			Cha.Bod.触覚甲右.Set角度0();
			Cha.Bod.触覚甲右.X0Y0_節0.AngleBase += -根本角度 + -u1;
			Cha.Bod.触覚甲右.X0Y0_節1.AngleBase += -節角度 + -u2;
		}

		public static void 触覚甲_基本左(this Cha Cha, double u1, double u2)
		{
			Cha.触覚甲左(u1, u2, 0.0, 0.0);
		}

		public static void 触覚甲_基本右(this Cha Cha, double u1, double u2)
		{
			Cha.触覚甲右(u1, u2, 0.0, 0.0);
		}

		public static void 触覚甲_ピ\u30FCン左(this Cha Cha, double u1, double u2)
		{
			Cha.触覚甲左(u1, u2, 20.0, -25.0);
		}

		public static void 触覚甲_ピ\u30FCン右(this Cha Cha, double u1, double u2)
		{
			Cha.触覚甲右(u1, u2, 20.0, -25.0);
		}

		public static void 触覚甲_萎縮左(this Cha Cha, double u1, double u2)
		{
			Cha.触覚甲左(u1, u2, -80.0, 100.0);
		}

		public static void 触覚甲_萎縮右(this Cha Cha, double u1, double u2)
		{
			Cha.触覚甲右(u1, u2, -80.0, 100.0);
		}

		public static void 触覚甲_基本(this Cha Cha)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.触覚甲_基本左(u, u2);
			Cha.触覚甲_基本右(u, u2);
		}

		public static void 触覚甲_ピ\u30FCン(this Cha Cha)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.触覚甲_ピ\u30FCン左(u, u2);
			Cha.触覚甲_ピ\u30FCン右(u, u2);
		}

		public static void 触覚甲_萎縮(this Cha Cha)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.触覚甲_萎縮左(u, u2);
			Cha.触覚甲_萎縮右(u, u2);
		}

		public static void 両触覚甲_0(this Cha Cha, bool 同角, int i1, int i2)
		{
			double num = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double num2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u;
			double u2;
			if (同角)
			{
				u = num;
				u2 = num2;
			}
			else
			{
				u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			}
			Cha.触覚甲左_0(i1, num, num2);
			Cha.触覚甲右_0(i2, u, u2);
		}

		public static void 触覚甲左_0(this Cha c, int i, double u1, double u2)
		{
			switch (i)
			{
			case 0:
				c.触覚甲_基本左(u1, u2);
				return;
			case 1:
				c.触覚甲_ピ\u30FCン左(u1, u2);
				return;
			case 2:
				c.触覚甲_萎縮左(u1, u2);
				return;
			default:
				return;
			}
		}

		public static void 触覚甲右_0(this Cha c, int i, double u1, double u2)
		{
			switch (i)
			{
			case 0:
				c.触覚甲_基本右(u1, u2);
				return;
			case 1:
				c.触覚甲_ピ\u30FCン右(u1, u2);
				return;
			case 2:
				c.触覚甲_萎縮右(u1, u2);
				return;
			default:
				return;
			}
		}

		public static void 触覚甲絶頂(this Cha Cha, double a)
		{
			Cha.Bod.触覚甲左.角度C = a * OthN.XS.NextDouble();
			Cha.Bod.触覚甲右.角度C = -a * OthN.XS.NextDouble();
		}

		public static void 大顎左(this Cha Cha, int n, double u1, double 根本角度)
		{
			大顎 大顎 = Cha.Bod.大顎左[n];
			大顎.Set角度0();
			大顎.本体.CurJoinRoot.AngleBase += 根本角度 + u1;
		}

		public static void 大顎右(this Cha Cha, int n, double u1, double 根本角度)
		{
			大顎 大顎 = Cha.Bod.大顎右[n];
			大顎.Set角度0();
			大顎.本体.CurJoinRoot.AngleBase += -根本角度 + -u1;
		}

		public static void 大顎_基本左(this Cha Cha, int n, double u1)
		{
			Cha.大顎左(n, u1, 0.0);
		}

		public static void 大顎_基本右(this Cha Cha, int n, double u1)
		{
			Cha.大顎右(n, u1, 0.0);
		}

		public static void 大顎_開き左(this Cha Cha, int n, double u1)
		{
			Cha.大顎左(n, u1, 25.0);
		}

		public static void 大顎_開き右(this Cha Cha, int n, double u1)
		{
			Cha.大顎右(n, u1, 25.0);
		}

		public static void 大顎_閉じ左(this Cha Cha, int n, double u1)
		{
			Cha.大顎左(n, u1, -15.0);
		}

		public static void 大顎_閉じ右(this Cha Cha, int n, double u1)
		{
			Cha.大顎右(n, u1, -15.0);
		}

		public static void 両大顎_基本(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.大顎_基本左(n, u);
			Cha.大顎_基本右(n, u);
		}

		public static void 両大顎_開き(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.大顎_開き左(n, u);
			Cha.大顎_開き右(n, u);
		}

		public static void 両大顎_閉じ(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.大顎_閉じ左(n, u);
			Cha.大顎_閉じ右(n, u);
		}

		public static void 両大顎_0(this Cha Cha, int n, bool 同角, int i1, int i2)
		{
			double num = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u;
			if (同角)
			{
				u = num;
			}
			else
			{
				u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			}
			Cha.大顎左_0(i1, n, num);
			Cha.大顎右_0(i2, n, u);
		}

		public static void 大顎左_0(this Cha c, int i, int n, double u1)
		{
			switch (i)
			{
			case 0:
				c.大顎_基本左(n, u1);
				return;
			case 1:
				c.大顎_開き左(n, u1);
				return;
			case 2:
				c.大顎_閉じ左(n, u1);
				return;
			default:
				return;
			}
		}

		public static void 大顎右_0(this Cha c, int i, int n, double u1)
		{
			switch (i)
			{
			case 0:
				c.大顎_基本右(n, u1);
				return;
			case 1:
				c.大顎_開き右(n, u1);
				return;
			case 2:
				c.大顎_閉じ右(n, u1);
				return;
			default:
				return;
			}
		}

		public static void 大顎絶頂(this Cha Cha, double a)
		{
			foreach (大顎 大顎 in Cha.Bod.大顎左)
			{
				大顎.角度C = a * OthN.XS.NextDouble();
			}
			foreach (大顎 大顎2 in Cha.Bod.大顎右)
			{
				大顎2.角度C = -a * OthN.XS.NextDouble();
			}
		}

		public static void 虫顎左(this Cha Cha, int n, double u1, double 根本角度)
		{
			虫顎 虫顎 = Cha.Bod.虫顎左[n];
			虫顎.Set角度0();
			虫顎.X0Y0_顎.AngleBase += 根本角度 + u1;
		}

		public static void 虫顎右(this Cha Cha, int n, double u1, double 根本角度)
		{
			虫顎 虫顎 = Cha.Bod.虫顎右[n];
			虫顎.Set角度0();
			虫顎.X0Y0_顎.AngleBase += -根本角度 + -u1;
		}

		public static void 虫顎_基本左(this Cha Cha, int n, double u1)
		{
			Cha.虫顎左(n, u1, 0.0);
		}

		public static void 虫顎_基本右(this Cha Cha, int n, double u1)
		{
			Cha.虫顎右(n, u1, 0.0);
		}

		public static void 虫顎_開き左(this Cha Cha, int n, double u1)
		{
			Cha.虫顎左(n, u1, 25.0);
		}

		public static void 虫顎_開き右(this Cha Cha, int n, double u1)
		{
			Cha.虫顎右(n, u1, 25.0);
		}

		public static void 虫顎_閉じ左(this Cha Cha, int n, double u1)
		{
			Cha.虫顎左(n, u1, -10.0);
		}

		public static void 虫顎_閉じ右(this Cha Cha, int n, double u1)
		{
			Cha.虫顎右(n, u1, -10.0);
		}

		public static void 両虫顎_基本(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.虫顎_基本左(n, u);
			Cha.虫顎_基本右(n, u);
		}

		public static void 両虫顎_開き(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.虫顎_開き左(n, u);
			Cha.虫顎_開き右(n, u);
		}

		public static void 両虫顎_閉じ(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.虫顎_閉じ左(n, u);
			Cha.虫顎_閉じ右(n, u);
		}

		public static void 両虫顎_0(this Cha Cha, int n, bool 同角, int i1, int i2)
		{
			double num = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u;
			if (同角)
			{
				u = num;
			}
			else
			{
				u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			}
			Cha.虫顎左_0(i1, n, num);
			Cha.虫顎右_0(i2, n, u);
		}

		public static void 虫顎左_0(this Cha c, int i, int n, double u1)
		{
			switch (i)
			{
			case 0:
				c.虫顎_基本左(n, u1);
				return;
			case 1:
				c.虫顎_開き左(n, u1);
				return;
			case 2:
				c.虫顎_閉じ左(n, u1);
				return;
			default:
				return;
			}
		}

		public static void 虫顎右_0(this Cha c, int i, int n, double u1)
		{
			switch (i)
			{
			case 0:
				c.虫顎_基本右(n, u1);
				return;
			case 1:
				c.虫顎_開き右(n, u1);
				return;
			case 2:
				c.虫顎_閉じ右(n, u1);
				return;
			default:
				return;
			}
		}

		public static void 虫顎絶頂(this Cha Cha, double a)
		{
			foreach (虫顎 虫顎 in Cha.Bod.虫顎左)
			{
				虫顎.角度C = a * OthN.XS.NextDouble();
			}
			foreach (虫顎 虫顎2 in Cha.Bod.虫顎右)
			{
				虫顎2.角度C = -a * OthN.XS.NextDouble();
			}
		}

		public static void 腕_人左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double 肩角度B, double 上腕角度B, double 下腕角度B, double 手角度B, double 上腕尺度XC, double 下腕尺度XC, double 手尺度XC, double 下腕尺度C, double 手尺度C, bool 上腕外線, bool 下腕外線, bool 下腕反転Y, int 手Yi, bool 前後)
		{
			腕人 腕人 = Cha.Bod.腕人左[n];
			腕人.肩.Set角度0();
			腕人.肩.角度B = 肩角度B + u1;
			if (腕人.上腕 != null)
			{
				腕人.上腕.肘部_外線 = 上腕外線;
				腕人.上腕.尺度XC = 上腕尺度XC;
				腕人.上腕.角度B = 上腕角度B + u2;
				if (腕人.下腕 != null)
				{
					Cha.Bod.腕前後(false, n, 前後);
					腕人.下腕.反転Y = false;
					腕人.下腕.肘部_外線 = 下腕外線;
					腕人.下腕.尺度XC = 下腕尺度XC;
					腕人.下腕.尺度C = 下腕尺度C;
					腕人.下腕.角度B = 下腕角度B + u3;
					腕人.下腕.反転Y = 下腕反転Y;
					腕人.下腕.鎖1.反転Y = 下腕反転Y;
					if (腕人.下腕.虫鎌_接続 != null)
					{
						foreach (Ele ele in 腕人.下腕.虫鎌_接続)
						{
							ele.尺度XC = 下腕尺度XC;
							ele.尺度C = 下腕尺度C;
							ele.反転Y = 下腕反転Y;
						}
					}
					if (腕人.手 != null)
					{
						腕人.手.尺度XC = 手尺度XC;
						腕人.手.尺度C = 手尺度C;
						腕人.手.角度B = 手角度B + u4;
						if (手Yi == 11)
						{
							腕人.手.Yi = 3;
							bool flag = 腕人.下腕.植性1_通常_花弁_花弁_表示 || 腕人.下腕.植性1_欠損_花弁_花弁_表示;
							腕人.手.角度B -= (flag ? 15.0 : 0.0);
							腕人.手.人指_人指3_表示 = false;
							腕人.手.中指_中指3_表示 = false;
							腕人.手.薬指_薬指3_表示 = false;
							腕人.手.小指_小指3_表示 = false;
							if (flag)
							{
								腕人.手.X0Y3_小指_小指2.AngleCont = 20.0;
							}
							else
							{
								腕人.手.X0Y3_小指_小指2.AngleCont = -20.0;
							}
						}
						else
						{
							腕人.手.人指_人指3_表示 = true;
							if (腕人.手.中指_中指2_表示)
							{
								腕人.手.中指_中指3_表示 = true;
							}
							if (腕人.手.薬指_薬指2_表示)
							{
								腕人.手.薬指_薬指3_表示 = true;
							}
							腕人.手.小指_小指3_表示 = true;
							腕人.手.X0Y3_小指_小指2.AngleCont = 0.0;
							腕人.手.Yi = 手Yi;
							if (手Yi == 9)
							{
								if (!腕人.手.中指_中指1_表示)
								{
									腕人.手.X0Y9_小指_小指1.AngleBase = -110.0;
									腕人.手.X0Y9_小指_小指2.AngleBase = -70.0;
									腕人.手.X0Y9_小指_小指3.AngleBase = -105.0;
								}
								else
								{
									腕人.手.X0Y9_小指_小指1.AngleBase = 0.0;
									腕人.手.X0Y9_小指_小指2.AngleBase = 0.0;
									腕人.手.X0Y9_小指_小指3.AngleBase = 0.0;
								}
							}
						}
					}
				}
			}
			腕人.肩.重複角度処理();
		}

		public static void 腕_人右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double 肩角度B, double 上腕角度B, double 下腕角度B, double 手角度B, double 上腕尺度XC, double 下腕尺度XC, double 手尺度XC, double 下腕尺度C, double 手尺度C, bool 上腕外線, bool 下腕外線, bool 下腕反転Y, int 手Yi, bool 前後)
		{
			腕人 腕人 = Cha.Bod.腕人右[n];
			腕人.肩.Set角度0();
			腕人.肩.角度B = -肩角度B + -u1;
			if (腕人.上腕 != null)
			{
				腕人.上腕.肘部_外線 = 上腕外線;
				腕人.上腕.尺度XC = 上腕尺度XC;
				腕人.上腕.角度B = -上腕角度B + -u2;
				if (腕人.下腕 != null)
				{
					Cha.Bod.腕前後(true, n, 前後);
					腕人.下腕.反転Y = false;
					腕人.下腕.肘部_外線 = 下腕外線;
					腕人.下腕.尺度XC = 下腕尺度XC;
					腕人.下腕.尺度C = 下腕尺度C;
					腕人.下腕.角度B = -下腕角度B + -u3;
					腕人.下腕.反転Y = 下腕反転Y;
					腕人.下腕.鎖1.反転Y = 下腕反転Y;
					if (腕人.下腕.虫鎌_接続 != null)
					{
						foreach (Ele ele in 腕人.下腕.虫鎌_接続)
						{
							ele.尺度XC = 下腕尺度XC;
							ele.尺度C = 下腕尺度C;
							ele.反転Y = 下腕反転Y;
						}
					}
					if (腕人.手 != null)
					{
						腕人.手.尺度XC = 手尺度XC;
						腕人.手.尺度C = 手尺度C;
						腕人.手.角度B = -手角度B + -u4;
						if (手Yi == 11)
						{
							腕人.手.Yi = 3;
							bool flag = 腕人.下腕.植性1_通常_花弁_花弁_表示 || 腕人.下腕.植性1_欠損_花弁_花弁_表示;
							腕人.手.角度B -= (flag ? -15.0 : 0.0);
							腕人.手.人指_人指3_表示 = false;
							腕人.手.中指_中指3_表示 = false;
							腕人.手.薬指_薬指3_表示 = false;
							腕人.手.小指_小指3_表示 = false;
							if (flag)
							{
								腕人.手.X0Y3_小指_小指2.AngleCont = -20.0;
							}
							else
							{
								腕人.手.X0Y3_小指_小指2.AngleCont = 20.0;
							}
						}
						else
						{
							腕人.手.人指_人指3_表示 = true;
							if (腕人.手.中指_中指2_表示)
							{
								腕人.手.中指_中指3_表示 = true;
							}
							if (腕人.手.薬指_薬指2_表示)
							{
								腕人.手.薬指_薬指3_表示 = true;
							}
							腕人.手.小指_小指3_表示 = true;
							腕人.手.X0Y3_小指_小指2.AngleCont = 0.0;
							腕人.手.Yi = 手Yi;
							if (手Yi == 9)
							{
								if (!腕人.手.中指_中指1_表示)
								{
									腕人.手.X0Y9_小指_小指1.AngleBase = 110.0;
									腕人.手.X0Y9_小指_小指2.AngleBase = 70.0;
									腕人.手.X0Y9_小指_小指3.AngleBase = 105.0;
								}
								else
								{
									腕人.手.X0Y9_小指_小指1.AngleBase = 0.0;
									腕人.手.X0Y9_小指_小指2.AngleBase = 0.0;
									腕人.手.X0Y9_小指_小指3.AngleBase = 0.0;
								}
							}
						}
					}
				}
			}
			腕人.肩.重複角度処理();
		}

		public static void 腕_人_腕置き左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_人左(n, u1, u2, u3, u4, 0.0, -30.0, 130.0, 0.0, 0.95, 1.0, 1.0, 1.0, 1.0, true, false, false, 0, false);
		}

		public static void 腕_人_腕置き右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_人右(n, u1, u2, u3, u4, 0.0, -30.0, 130.0, 0.0, 0.95, 1.0, 1.0, 1.0, 1.0, true, false, false, 0, false);
		}

		public static void 腕_人_胸庇い左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_人左(n, u1, u2, u3, u4, 0.0, -80.0, -230.0, 35.0, 1.0, 1.0, 1.0, 1.0, 1.0, true, false, true, 1, false);
		}

		public static void 腕_人_胸庇い右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_人右(n, u1, u2, u3, u4, 0.0, -80.0, -230.0, 35.0, 1.0, 1.0, 1.0, 1.0, 1.0, true, false, true, 1, false);
		}

		public static void 腕_人_体支え左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_人左(n, u1, u2, u3, u4, 0.0, -60.0, 360.0, 0.0, 1.0, 1.0, 1.0, 1.0, 1.0, false, false, true, 2, true);
		}

		public static void 腕_人_体支え右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_人右(n, u1, u2, u3, u4, 0.0, -60.0, 360.0, 0.0, 1.0, 1.0, 1.0, 1.0, 1.0, false, false, true, 2, true);
		}

		public static void 腕_人_胸乗せ左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_人左(n, u1, u2, u3, u4, 5.0, -80.0, 185.0, 45.0, 1.0, 0.85, 1.0, 1.0, 1.0, true, false, false, 3, false);
		}

		public static void 腕_人_胸乗せ右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_人右(n, u1, u2, u3, u4, 5.0, -80.0, 185.0, 45.0, 1.0, 0.85, 1.0, 1.0, 1.0, true, false, false, 3, false);
		}

		public static void 腕_人_顔隠し左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_人左(n, u1, u2, u3, u4, 10.0, -109.0, -202.0, -13.0, 0.8, 0.95, 1.0, 1.1, 1.0, true, true, true, 4, false);
		}

		public static void 腕_人_顔隠し右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_人右(n, u1, u2, u3, u4, 10.0, -109.0, -202.0, -13.0, 0.8, 0.95, 1.0, 1.1, 1.0, true, true, true, 4, false);
		}

		public static void 腕_人_チラ見左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_人左(n, u1, u2, u3, u4, 10.0, -109.0, -202.0, -6.0, 1.0, 0.9, 1.0, 1.1, 1.0, true, true, true, 10, false);
		}

		public static void 腕_人_チラ見右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_人右(n, u1, u2, u3, u4, 10.0, -109.0, -202.0, -6.0, 1.0, 0.9, 1.0, 1.1, 1.0, true, true, true, 10, false);
		}

		public static void 腕_人_指咥え左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_人左(n, u1, u2, u3, u4, 10.0, -102.0, -194.0, 39.0, 1.0, 1.0, 1.0, 1.0, 1.0, true, false, true, 5, false);
		}

		public static void 腕_人_指咥え右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_人右(n, u1, u2, u3, u4, 10.0, -102.0, -194.0, 39.0, 1.0, 1.0, 1.0, 1.0, 1.0, true, false, true, 5, false);
		}

		public static void 腕_人_腕下げ左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_人左(n, u1, u2, u3, u4, -5.0, -75.0, 350.0, 0.0, 1.0, 1.0, 1.0, 1.0, 1.0, false, false, true, 6, true);
		}

		public static void 腕_人_腕下げ右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_人右(n, u1, u2, u3, u4, -5.0, -75.0, 350.0, 0.0, 1.0, 1.0, 1.0, 1.0, 1.0, false, false, true, 6, true);
		}

		public static void 腕_人_股隠し左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_人左(n, u1, u2, u3, u4, 0.0, -91.0, -331.0, 23.0, 1.0, 1.0, 1.0, 1.0, 1.0, true, false, true, 4, false);
		}

		public static void 腕_人_股隠し右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_人右(n, u1, u2, u3, u4, 0.0, -91.0, -331.0, 23.0, 1.0, 1.0, 1.0, 1.0, 1.0, true, false, true, 4, false);
		}

		public static void 腕_人_開帳左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_人左(n, u1, u2, u3, u4, 10.0, -101.0, -330.0, 33.0, 1.0, 1.0, 1.0, 1.0, 1.0, true, false, true, 10, false);
		}

		public static void 腕_人_開帳右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_人右(n, u1, u2, u3, u4, 10.0, -101.0, -330.0, 33.0, 1.0, 1.0, 1.0, 1.0, 1.0, true, false, true, 10, false);
		}

		public static void 腕_人_口押さえ1左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_人左(n, u1, u2, u3, u4, 10.0, -102.0, -194.0, 39.0, 1.0, 1.0, 1.0, 1.0, 1.0, true, false, true, 4, false);
		}

		public static void 腕_人_口押さえ1右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_人右(n, u1, u2, u3, u4, 10.0, -102.0, -194.0, 39.0, 1.0, 1.0, 1.0, 1.0, 1.0, true, false, true, 4, false);
		}

		public static void 腕_人_口押さえ2左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.Bod.腕左右前後 = false;
			Cha.腕_人左(n, u1, u2, u3, u4, 10.0, -102.0, -194.0, 39.0, 0.9, 0.9, 1.0, 1.0, 1.0, true, false, true, 4, false);
		}

		public static void 腕_人_口押さえ2右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.Bod.腕左右前後 = true;
			Cha.腕_人右(n, u1, u2, u3, u4, 10.0, -102.0, -194.0, 39.0, 0.9, 0.9, 1.0, 1.0, 1.0, true, false, true, 4, false);
		}

		public static void 腕_人_口押さえ3左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.Bod.腕左右前後 = false;
			Cha.腕_人左(n, u1, u2, u3, u4, 10.0, -102.0, -204.0, -19.0, 1.0, 1.0, 1.0, 1.0, 1.0, true, false, true, 4, false);
		}

		public static void 腕_人_口押さえ3右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.Bod.腕左右前後 = true;
			Cha.腕_人右(n, u1, u2, u3, u4, 10.0, -102.0, -204.0, -19.0, 1.0, 1.0, 1.0, 1.0, 1.0, true, false, true, 4, false);
		}

		public static void 腕_人_脇見せ左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_人左(n, u1, u2, u3, u4, 20.0, 25.0, 135.0, 0.0, 1.0, 1.0, 1.0, 1.0, 1.0, true, false, false, 0, true);
		}

		public static void 腕_人_脇見せ右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_人右(n, u1, u2, u3, u4, 20.0, 25.0, 135.0, 0.0, 1.0, 1.0, 1.0, 1.0, 1.0, true, false, false, 0, true);
		}

		public static void 腕_人_腰手当左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_人左(n, u1, u2, u3, u4, 0.0, -43.0, 90.0, -30.0, 1.0, 0.85, 0.8, 1.0, 1.0, true, false, true, 7, false);
		}

		public static void 腕_人_腰手当右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_人右(n, u1, u2, u3, u4, 0.0, -43.0, 90.0, -30.0, 1.0, 0.85, 0.8, 1.0, 1.0, true, false, true, 7, false);
		}

		public static void 腕_人_ピ\u30FCス左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_人左(n, u1, u2, u3, u4, 0.0, -35.0, 160.0, -50.0, 0.9, 0.9, 1.0, 1.0, 1.05, true, false, false, 9, false);
		}

		public static void 腕_人_ピ\u30FCス右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_人右(n, u1, u2, u3, u4, 0.0, -35.0, 160.0, -50.0, 0.9, 0.9, 1.0, 1.0, 1.05, true, false, false, 9, false);
		}

		public static void 腕_人_手コキ左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_人左(n, u1, u2, u3, u4, 0.0, -60.0, -160.0, 30.0, 0.8, 0.84, 1.0, 1.0, 1.0, true, false, false, 11, false);
		}

		public static void 腕_人_手コキ右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_人右(n, u1, u2, u3, u4, 0.0, -60.0, -160.0, 30.0, 0.8, 0.84, 1.0, 1.0, 1.0, true, false, false, 11, false);
		}

		public static void 腕_人_パイズリ左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_人左(n, u1, u2, u3, u4, 0.0, -45.0, 155.0, 15.0, 1.0, 0.55, 0.6, 1.0, 1.0, true, false, true, 8, false);
		}

		public static void 腕_人_パイズリ右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_人右(n, u1, u2, u3, u4, 0.0, -45.0, 155.0, 15.0, 1.0, 0.55, 0.6, 1.0, 1.0, true, false, true, 8, false);
		}

		public static void 腕_人_腕上げ左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_人左(n, u1, u2, u3, u4, 0.0, -20.0, 120.0, 0.0, 1.0, 1.0, 1.0, 1.0, 1.0, true, false, false, 0, false);
		}

		public static void 腕_人_腕上げ右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_人右(n, u1, u2, u3, u4, 0.0, -20.0, 120.0, 0.0, 1.0, 1.0, 1.0, 1.0, 1.0, true, false, false, 0, false);
		}

		public static void 両腕_人_腕置き(this Cha Cha, int n, bool 左右, bool 前後)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.Bod.腕左右前後 = 前後;
			if (左右)
			{
				Cha.腕_人_腕置き右(n, u, u2, u3, u4);
				Cha.腕_人_腕置き左(n, u, u2, u3, u4);
				return;
			}
			Cha.腕_人_腕置き左(n, u, u2, u3, u4);
			Cha.腕_人_腕置き右(n, u, u2, u3, u4);
		}

		public static void 両腕_人_胸隠し(this Cha Cha, int n, bool 左右, bool 前後)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.Bod.腕左右前後 = 前後;
			if (左右)
			{
				Cha.腕_人_胸庇い右(n, u, u2, u3, u4);
				Cha.腕_人_胸庇い左(n, u, u2, u3, u4);
				return;
			}
			Cha.腕_人_胸庇い左(n, u, u2, u3, u4);
			Cha.腕_人_胸庇い右(n, u, u2, u3, u4);
		}

		public static void 両腕_人_体支え(this Cha Cha, int n, bool 左右, bool 前後)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.Bod.腕左右前後 = 前後;
			if (左右)
			{
				Cha.腕_人_体支え右(n, u, u2, u3, u4);
				Cha.腕_人_体支え左(n, u, u2, u3, u4);
				return;
			}
			Cha.腕_人_体支え左(n, u, u2, u3, u4);
			Cha.腕_人_体支え右(n, u, u2, u3, u4);
		}

		public static void 両腕_人_胸乗せ(this Cha Cha, int n, bool 左右, bool 前後)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.Bod.腕左右前後 = 前後;
			if (左右)
			{
				Cha.腕_人_胸乗せ右(n, u, u2, u3, u4);
				Cha.腕_人_胸乗せ左(n, u, u2, u3, u4);
				return;
			}
			Cha.腕_人_胸乗せ左(n, u, u2, u3, u4);
			Cha.腕_人_胸乗せ右(n, u, u2, u3, u4);
		}

		public static void 両腕_人_顔隠し(this Cha Cha, int n, bool 左右, bool 前後)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.Bod.腕左右前後 = 前後;
			if (左右)
			{
				Cha.腕_人_顔隠し右(n, u, u2, u3, u4);
				Cha.腕_人_顔隠し左(n, u, u2, u3, u4);
				return;
			}
			Cha.腕_人_顔隠し左(n, u, u2, u3, u4);
			Cha.腕_人_顔隠し右(n, u, u2, u3, u4);
		}

		public static void 両腕_人_チラ見(this Cha Cha, int n, bool 左右, bool 前後)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.Bod.腕左右前後 = 前後;
			if (左右)
			{
				Cha.腕_人_チラ見右(n, u, u2, u3, u4);
				Cha.腕_人_チラ見左(n, u, u2, u3, u4);
				return;
			}
			Cha.腕_人_チラ見左(n, u, u2, u3, u4);
			Cha.腕_人_チラ見右(n, u, u2, u3, u4);
		}

		public static void 両腕_人_指咥え(this Cha Cha, int n, bool 左右, bool 前後)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.Bod.腕左右前後 = 前後;
			if (左右)
			{
				Cha.腕_人_指咥え右(n, u, u2, u3, u4);
				Cha.腕_人_胸庇い左(n, u, u2, u3, u4);
				return;
			}
			Cha.腕_人_胸庇い左(n, u, u2, u3, u4);
			Cha.腕_人_指咥え右(n, u, u2, u3, u4);
		}

		public static void 両腕_人_腕下げ(this Cha Cha, int n, bool 左右, bool 前後)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.Bod.腕左右前後 = 前後;
			if (左右)
			{
				Cha.腕_人_腕下げ右(n, u, u2, u3, u4);
				Cha.腕_人_腕下げ左(n, u, u2, u3, u4);
				return;
			}
			Cha.腕_人_腕下げ左(n, u, u2, u3, u4);
			Cha.腕_人_腕下げ右(n, u, u2, u3, u4);
		}

		public static void 両腕_人_体隠し(this Cha Cha, int n, bool 左右, bool 前後)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.Bod.腕左右前後 = 前後;
			if (左右)
			{
				Cha.腕_人_股隠し右(n, u, u2, u3, u4);
				Cha.腕_人_胸庇い左(n, u, u2, u3, u4);
				return;
			}
			Cha.腕_人_胸庇い左(n, u, u2, u3, u4);
			Cha.腕_人_股隠し右(n, u, u2, u3, u4);
		}

		public static void 両腕_人_体隠し開帳(this Cha Cha, int n, bool 左右, bool 前後)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.Bod.腕左右前後 = 前後;
			if (左右)
			{
				Cha.腕_人_開帳右(n, u, u2, u3, u4);
				Cha.腕_人_胸庇い左(n, u, u2, u3, u4);
				return;
			}
			Cha.腕_人_胸庇い左(n, u, u2, u3, u4);
			Cha.腕_人_開帳右(n, u, u2, u3, u4);
		}

		public static void 両腕_人_口押さえ1(this Cha Cha, int n, bool 左右, bool 前後)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.Bod.腕左右前後 = 前後;
			if (左右)
			{
				Cha.腕_人_口押さえ1右(n, u, u2, u3, u4);
				Cha.腕_人_胸庇い左(n, u, u2, u3, u4);
				return;
			}
			Cha.腕_人_胸庇い左(n, u, u2, u3, u4);
			Cha.腕_人_口押さえ1右(n, u, u2, u3, u4);
		}

		public static void 両腕_人_口押さえ2(this Cha Cha, int n, bool 左右, bool 前後)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.Bod.腕左右前後 = 前後;
			if (左右)
			{
				Cha.腕_人_口押さえ2右(n, u, u2, u3, u4);
				Cha.腕_人_口押さえ2左(n, u, u2, u3, u4);
				return;
			}
			Cha.腕_人_口押さえ2左(n, u, u2, u3, u4);
			Cha.腕_人_口押さえ2右(n, u, u2, u3, u4);
		}

		public static void 両腕_人_口押さえ3(this Cha Cha, int n, bool 左右, bool 前後)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.Bod.腕左右前後 = 前後;
			if (左右)
			{
				Cha.腕_人_口押さえ3右(n, u, u2, u3, u4);
				Cha.腕_人_口押さえ3左(n, u, u2, u3, u4);
				return;
			}
			Cha.腕_人_口押さえ3左(n, u, u2, u3, u4);
			Cha.腕_人_口押さえ3右(n, u, u2, u3, u4);
		}

		public static void 両腕_人_脇見せ(this Cha Cha, int n, bool 左右, bool 前後)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.Bod.腕左右前後 = 前後;
			if (左右)
			{
				Cha.腕_人_脇見せ右(n, u, u2, u3, u4);
				Cha.腕_人_脇見せ左(n, u, u2, u3, u4);
				return;
			}
			Cha.腕_人_脇見せ左(n, u, u2, u3, u4);
			Cha.腕_人_脇見せ右(n, u, u2, u3, u4);
		}

		public static void 両腕_人_腰手当(this Cha Cha, int n, bool 左右, bool 前後)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.Bod.腕左右前後 = 前後;
			if (左右)
			{
				Cha.腕_人_腰手当右(n, u, u2, u3, u4);
				Cha.腕_人_腰手当左(n, u, u2, u3, u4);
				return;
			}
			Cha.腕_人_腰手当左(n, u, u2, u3, u4);
			Cha.腕_人_腰手当右(n, u, u2, u3, u4);
		}

		public static void 両腕_人_Wピ\u30FCス(this Cha Cha, int n, bool 左右, bool 前後)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.Bod.腕左右前後 = 前後;
			if (左右)
			{
				Cha.腕_人_ピ\u30FCス右(n, u, u2, u3, u4);
				Cha.腕_人_ピ\u30FCス左(n, u, u2, u3, u4);
				return;
			}
			Cha.腕_人_ピ\u30FCス左(n, u, u2, u3, u4);
			Cha.腕_人_ピ\u30FCス右(n, u, u2, u3, u4);
		}

		public static void 両腕_人_パイズリ(this Cha Cha, int n, bool 左右, bool 前後)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.Bod.腕左右前後 = 前後;
			if (左右)
			{
				Cha.腕_人_パイズリ右(n, u, u2, u3, u4);
				Cha.腕_人_パイズリ左(n, u, u2, u3, u4);
				return;
			}
			Cha.腕_人_パイズリ左(n, u, u2, u3, u4);
			Cha.腕_人_パイズリ右(n, u, u2, u3, u4);
		}

		public static void 両腕_人_腕上げ(this Cha Cha, int n, bool 左右, bool 前後)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.Bod.腕左右前後 = 前後;
			Cha.腕_人_腕上げ右(n, u, u2, u3, u4);
			Cha.腕_人_腕上げ左(n, u, u2, u3, u4);
			if (左右)
			{
				Cha.腕_人_腕上げ右(n, u, u2, u3, u4);
				Cha.腕_人_腕上げ左(n, u, u2, u3, u4);
				return;
			}
			Cha.腕_人_腕上げ左(n, u, u2, u3, u4);
			Cha.腕_人_腕上げ右(n, u, u2, u3, u4);
		}

		public static void 両腕人_0(this Cha Cha, int n, bool 前後, bool 同角, bool 左右, int i1, int i2)
		{
			Cha.Bod.腕左右前後 = 前後;
			double num = Cha.角度ムラ(OthN.XS.NextSign(), 0.25, OthN.XS.NextSign(), 0.125);
			double num2 = Cha.角度ムラ(OthN.XS.NextSign(), 0.25, OthN.XS.NextSign(), 0.125);
			double num3 = Cha.角度ムラ(OthN.XS.NextSign(), 1.5, OthN.XS.NextSign(), 0.75);
			double num4 = Cha.角度ムラ(OthN.XS.NextSign(), 1.5, OthN.XS.NextSign(), 0.75);
			double u;
			double u2;
			double u3;
			double u4;
			if (同角)
			{
				u = num;
				u2 = num2;
				u3 = num3;
				u4 = num4;
			}
			else
			{
				u = Cha.角度ムラ(OthN.XS.NextSign(), 0.25, OthN.XS.NextSign(), 0.125);
				u2 = Cha.角度ムラ(OthN.XS.NextSign(), 0.5, OthN.XS.NextSign(), 0.25);
				u3 = Cha.角度ムラ(OthN.XS.NextSign(), 1.5, OthN.XS.NextSign(), 0.75);
				u4 = Cha.角度ムラ(OthN.XS.NextSign(), 1.5, OthN.XS.NextSign(), 0.75);
			}
			if (左右)
			{
				Cha.腕人右_0(i1, n, num, num2, num3, num4);
				Cha.腕人左_0(i2, n, u, u2, u3, u4);
				return;
			}
			Cha.腕人左_0(i1, n, num, num2, num3, num4);
			Cha.腕人右_0(i2, n, u, u2, u3, u4);
		}

		public static void 腕人左_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4)
		{
			switch (i)
			{
			case 0:
				c.腕_人_腕置き左(n, u1, u2, u3, u4);
				return;
			case 1:
				c.腕_人_胸庇い左(n, u1, u2, u3, u4);
				return;
			case 2:
				c.腕_人_体支え左(n, u1, u2, u3, u4);
				return;
			case 3:
				c.腕_人_胸乗せ左(n, u1, u2, u3, u4);
				return;
			case 4:
				c.腕_人_顔隠し左(n, u1, u2, u3, u4);
				return;
			case 5:
				c.腕_人_チラ見左(n, u1, u2, u3, u4);
				return;
			case 6:
				c.腕_人_指咥え左(n, u1, u2, u3, u4);
				return;
			case 7:
				c.腕_人_腕下げ左(n, u1, u2, u3, u4);
				return;
			case 8:
				c.腕_人_股隠し左(n, u1, u2, u3, u4);
				return;
			case 9:
				c.腕_人_開帳左(n, 0.0, 0.0, 0.0, 0.0);
				return;
			case 10:
				c.腕_人_口押さえ1左(n, u1, u2, u3, u4);
				return;
			case 11:
				c.腕_人_口押さえ2左(n, u1, u2, u3, u4);
				return;
			case 12:
				c.腕_人_口押さえ3左(n, u1, u2, u3, u4);
				return;
			case 13:
				c.腕_人_脇見せ左(n, u1, u2, u3, u4);
				return;
			case 14:
				c.腕_人_腰手当左(n, u1, u2, u3, u4);
				return;
			case 15:
				c.腕_人_ピ\u30FCス左(n, u1, u2, u3, u4);
				return;
			case 16:
				c.腕_人_手コキ左(n, u1, u2, u3, u4);
				return;
			case 17:
				c.腕_人_パイズリ左(n, u1, u2, u3, u4);
				return;
			case 18:
				c.腕_人_腕上げ左(n, u1, u2, u3, u4);
				return;
			default:
				return;
			}
		}

		public static void 腕人右_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4)
		{
			switch (i)
			{
			case 0:
				c.腕_人_腕置き右(n, u1, u2, u3, u4);
				return;
			case 1:
				c.腕_人_胸庇い右(n, u1, u2, u3, u4);
				return;
			case 2:
				c.腕_人_体支え右(n, u1, u2, u3, u4);
				return;
			case 3:
				c.腕_人_胸乗せ右(n, u1, u2, u3, u4);
				return;
			case 4:
				c.腕_人_顔隠し右(n, u1, u2, u3, u4);
				return;
			case 5:
				c.腕_人_チラ見右(n, u1, u2, u3, u4);
				return;
			case 6:
				c.腕_人_指咥え右(n, u1, u2, u3, u4);
				return;
			case 7:
				c.腕_人_腕下げ右(n, u1, u2, u3, u4);
				return;
			case 8:
				c.腕_人_股隠し右(n, u1, u2, u3, u4);
				return;
			case 9:
				c.腕_人_開帳右(n, 0.0, 0.0, 0.0, 0.0);
				return;
			case 10:
				c.腕_人_口押さえ1右(n, u1, u2, u3, u4);
				return;
			case 11:
				c.腕_人_口押さえ2右(n, u1, u2, u3, u4);
				return;
			case 12:
				c.腕_人_口押さえ3右(n, u1, u2, u3, u4);
				return;
			case 13:
				c.腕_人_脇見せ右(n, u1, u2, u3, u4);
				return;
			case 14:
				c.腕_人_腰手当右(n, u1, u2, u3, u4);
				return;
			case 15:
				c.腕_人_ピ\u30FCス右(n, u1, u2, u3, u4);
				return;
			case 16:
				c.腕_人_手コキ右(n, u1, u2, u3, u4);
				return;
			case 17:
				c.腕_人_パイズリ右(n, u1, u2, u3, u4);
				return;
			case 18:
				c.腕_人_腕上げ右(n, u1, u2, u3, u4);
				return;
			default:
				return;
			}
		}

		public static void 腕人絶頂(this Cha Cha, double a)
		{
			foreach (腕人 腕人 in Cha.Bod.腕人左)
			{
				腕人.肩.角度C = a * OthN.XS.NextDouble();
				if (腕人.上腕 != null)
				{
					腕人.上腕.角度C = a * OthN.XS.NextDouble();
					if (腕人.下腕 != null)
					{
						腕人.下腕.角度C = a * OthN.XS.NextDouble();
						if (腕人.手 != null)
						{
							腕人.手.角度C = a * OthN.XS.NextDouble();
						}
					}
				}
			}
			foreach (腕人 腕人2 in Cha.Bod.腕人右)
			{
				腕人2.肩.角度C = -a * OthN.XS.NextDouble();
				if (腕人2.上腕 != null)
				{
					腕人2.上腕.角度C = -a * OthN.XS.NextDouble();
					if (腕人2.下腕 != null)
					{
						腕人2.下腕.角度C = -a * OthN.XS.NextDouble();
						if (腕人2.手 != null)
						{
							腕人2.手.角度C = -a * OthN.XS.NextDouble();
						}
					}
				}
			}
		}

		public static void 腕_翼鳥左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double 上腕展開, double 下腕展開, double 手展開, double 肩角度B, double 上腕角度B, double 下腕角度B, double 手角度B)
		{
			腕翼鳥 腕翼鳥 = Cha.Bod.腕翼鳥左[n];
			腕翼鳥.肩.Set角度0();
			if (n == 0)
			{
				腕翼鳥.肩.角度B = 肩角度B + u1;
			}
			if (腕翼鳥.上腕 != null)
			{
				腕翼鳥.上腕.Set角度0();
				腕翼鳥.上腕.展開 = 上腕展開;
				腕翼鳥.上腕.角度B += 上腕角度B + u2;
				if (腕翼鳥.下腕 != null)
				{
					腕翼鳥.下腕.Set角度0();
					腕翼鳥.下腕.展開 = 下腕展開;
					腕翼鳥.下腕.角度B += 下腕角度B + u3;
					if (腕翼鳥.手 != null)
					{
						腕翼鳥.手.Set角度0();
						腕翼鳥.手.展開 = 手展開;
						腕翼鳥.手.角度B += 手角度B + u4;
					}
				}
			}
			腕翼鳥.肩.重複角度処理();
		}

		public static void 腕_翼鳥右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double 上腕展開, double 下腕展開, double 手展開, double 肩角度B, double 上腕角度B, double 下腕角度B, double 手角度B)
		{
			腕翼鳥 腕翼鳥 = Cha.Bod.腕翼鳥右[n];
			腕翼鳥.肩.Set角度0();
			if (n == 0)
			{
				腕翼鳥.肩.角度B = -肩角度B + -u1;
			}
			if (腕翼鳥.上腕 != null)
			{
				腕翼鳥.上腕.Set角度0();
				腕翼鳥.上腕.展開 = 上腕展開;
				腕翼鳥.上腕.角度B += -上腕角度B + -u2;
				if (腕翼鳥.下腕 != null)
				{
					腕翼鳥.下腕.Set角度0();
					腕翼鳥.下腕.展開 = 下腕展開;
					腕翼鳥.下腕.角度B += -下腕角度B + -u3;
					if (腕翼鳥.手 != null)
					{
						腕翼鳥.手.Set角度0();
						腕翼鳥.手.展開 = 手展開;
						腕翼鳥.手.角度B += -手角度B + -u4;
					}
				}
			}
			腕翼鳥.肩.重複角度処理();
		}

		public static void 腕_翼鳥_脱力左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_翼鳥左(n, u1, u2, u3, u4, 0.0, 0.25, 0.25, 0.0, -1.0, 0.0, 0.0);
		}

		public static void 腕_翼鳥_脱力右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_翼鳥右(n, u1, u2, u3, u4, 0.0, 0.25, 0.25, 0.0, -1.0, 0.0, 0.0);
		}

		public static void 腕_翼鳥_強張り左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_翼鳥左(n, u1, u2, u3, u4, 0.0, 0.0, 0.0, 0.0, -5.0, 10.0, 0.0);
		}

		public static void 腕_翼鳥_強張り右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_翼鳥右(n, u1, u2, u3, u4, 0.0, 0.0, 0.0, 0.0, -5.0, 10.0, 0.0);
		}

		public static void 腕_翼鳥_恥じらい左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_翼鳥左(n, u1, u2, u3, u4, 0.0, 0.0, 0.0, 8.0, -13.0, 13.0, 0.0);
		}

		public static void 腕_翼鳥_恥じらい右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_翼鳥右(n, u1, u2, u3, u4, 0.0, 0.0, 0.0, 8.0, -13.0, 13.0, 0.0);
		}

		public static void 腕_翼鳥_顔隠し左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_翼鳥左(n, u1, u2, u3, u4, 0.0, 0.0, 0.0, 5.0, -10.0, 15.0, 0.0);
		}

		public static void 腕_翼鳥_顔隠し右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_翼鳥右(n, u1, u2, u3, u4, 0.0, 0.0, 0.0, 5.0, -10.0, 15.0, 0.0);
		}

		public static void 腕_翼鳥_閉じ左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_翼鳥左(n, u1, u2, u3, u4, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0);
		}

		public static void 腕_翼鳥_閉じ右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_翼鳥右(n, u1, u2, u3, u4, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0);
		}

		public static void 腕_翼鳥_半開き左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_翼鳥左(n, u1, u2, u3, u4, 0.25, 0.25, 0.25, -3.0, 0.0, 0.0, 0.0);
		}

		public static void 腕_翼鳥_半開き右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_翼鳥右(n, u1, u2, u3, u4, 0.25, 0.25, 0.25, -3.0, 0.0, 0.0, 0.0);
		}

		public static void 腕_翼鳥_全開左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_翼鳥左(n, u1, u2, u3, u4, 1.0, 1.0, 1.0, 6.0, 3.0, 0.0, 0.0);
		}

		public static void 腕_翼鳥_全開右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_翼鳥右(n, u1, u2, u3, u4, 1.0, 1.0, 1.0, 6.0, 3.0, 0.0, 0.0);
		}

		public static void 両腕_翼鳥_脱力(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 1.0, OthN.XS.NextSign(), 0.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 1.0, OthN.XS.NextSign(), 0.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 1.0, OthN.XS.NextSign(), 0.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 1.0, OthN.XS.NextSign(), 0.5);
			Cha.腕_翼鳥_脱力左(n, u, u2, u3, u4);
			Cha.腕_翼鳥_脱力右(n, u, u2, u3, u4);
		}

		public static void 両腕_翼鳥_強張り(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 1.0, OthN.XS.NextSign(), 0.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 1.0, OthN.XS.NextSign(), 0.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 1.0, OthN.XS.NextSign(), 0.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 1.0, OthN.XS.NextSign(), 0.5);
			Cha.腕_翼鳥_強張り左(n, u, u2, u3, u4);
			Cha.腕_翼鳥_強張り右(n, u, u2, u3, u4);
		}

		public static void 両腕_翼鳥_恥じらい(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 1.0, OthN.XS.NextSign(), 0.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 1.0, OthN.XS.NextSign(), 0.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 1.0, OthN.XS.NextSign(), 0.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 1.0, OthN.XS.NextSign(), 0.5);
			Cha.腕_翼鳥_恥じらい左(n, u, u2, u3, u4);
			Cha.腕_翼鳥_恥じらい右(n, u, u2, u3, u4);
		}

		public static void 両腕_翼鳥_顔隠し(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 1.0, OthN.XS.NextSign(), 0.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 1.0, OthN.XS.NextSign(), 0.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 1.0, OthN.XS.NextSign(), 0.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 1.0, OthN.XS.NextSign(), 0.5);
			Cha.腕_翼鳥_顔隠し左(n, u, u2, u3, u4);
			Cha.腕_翼鳥_顔隠し右(n, u, u2, u3, u4);
		}

		public static void 両腕_翼鳥_閉じ(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 1.0, OthN.XS.NextSign(), 0.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 1.0, OthN.XS.NextSign(), 0.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 1.0, OthN.XS.NextSign(), 0.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 1.0, OthN.XS.NextSign(), 0.5);
			Cha.腕_翼鳥_閉じ左(n, u, u2, u3, u4);
			Cha.腕_翼鳥_閉じ右(n, u, u2, u3, u4);
		}

		public static void 両腕_翼鳥_半開き(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 1.0, OthN.XS.NextSign(), 0.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 1.0, OthN.XS.NextSign(), 0.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 1.0, OthN.XS.NextSign(), 0.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 1.0, OthN.XS.NextSign(), 0.5);
			Cha.腕_翼鳥_半開き左(n, u, u2, u3, u4);
			Cha.腕_翼鳥_半開き右(n, u, u2, u3, u4);
		}

		public static void 両腕_翼鳥_全開(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 1.0, OthN.XS.NextSign(), 0.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 1.0, OthN.XS.NextSign(), 0.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 1.0, OthN.XS.NextSign(), 0.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 1.0, OthN.XS.NextSign(), 0.5);
			Cha.腕_翼鳥_全開左(n, u, u2, u3, u4);
			Cha.腕_翼鳥_全開右(n, u, u2, u3, u4);
		}

		public static void 両腕翼鳥_0(this Cha Cha, int n, bool 同角, int i1, int i2)
		{
			double num = Cha.角度ムラ(OthN.XS.NextSign(), 0.5, OthN.XS.NextSign(), 0.25);
			double num2 = Cha.角度ムラ(OthN.XS.NextSign(), 0.5, OthN.XS.NextSign(), 0.25);
			double num3 = Cha.角度ムラ(OthN.XS.NextSign(), 1.0, OthN.XS.NextSign(), 0.5);
			double num4 = Cha.角度ムラ(OthN.XS.NextSign(), 1.0, OthN.XS.NextSign(), 0.5);
			double u;
			double u2;
			double u3;
			double u4;
			if (同角)
			{
				u = num;
				u2 = num2;
				u3 = num3;
				u4 = num4;
			}
			else
			{
				u = Cha.角度ムラ(OthN.XS.NextSign(), 0.5, OthN.XS.NextSign(), 0.25);
				u2 = Cha.角度ムラ(OthN.XS.NextSign(), 0.5, OthN.XS.NextSign(), 0.25);
				u3 = Cha.角度ムラ(OthN.XS.NextSign(), 1.0, OthN.XS.NextSign(), 0.5);
				u4 = Cha.角度ムラ(OthN.XS.NextSign(), 1.0, OthN.XS.NextSign(), 0.5);
			}
			Cha.腕翼鳥左_0(i1, n, num, num2, num3, num4);
			Cha.腕翼鳥右_0(i2, n, u, u2, u3, u4);
		}

		public static void 腕翼鳥左_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4)
		{
			switch (i)
			{
			case 0:
				c.腕_翼鳥_脱力左(n, u1, u2, u3, u4);
				return;
			case 1:
				c.腕_翼鳥_強張り左(n, u1, u2, u3, u4);
				return;
			case 2:
				c.腕_翼鳥_恥じらい左(n, u1, u2, u3, u4);
				return;
			case 3:
				c.腕_翼鳥_顔隠し左(n, u1, u2, u3, u4);
				return;
			case 4:
				c.腕_翼鳥_閉じ左(n, u1, u2, u3, u4);
				return;
			case 5:
				c.腕_翼鳥_半開き左(n, u1, u2, u3, u4);
				return;
			case 6:
				c.腕_翼鳥_全開左(n, u1, u2, u3, u4);
				return;
			default:
				return;
			}
		}

		public static void 腕翼鳥右_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4)
		{
			switch (i)
			{
			case 0:
				c.腕_翼鳥_脱力右(n, u1, u2, u3, u4);
				return;
			case 1:
				c.腕_翼鳥_強張り右(n, u1, u2, u3, u4);
				return;
			case 2:
				c.腕_翼鳥_恥じらい右(n, u1, u2, u3, u4);
				return;
			case 3:
				c.腕_翼鳥_顔隠し右(n, u1, u2, u3, u4);
				return;
			case 4:
				c.腕_翼鳥_閉じ右(n, u1, u2, u3, u4);
				return;
			case 5:
				c.腕_翼鳥_半開き右(n, u1, u2, u3, u4);
				return;
			case 6:
				c.腕_翼鳥_全開右(n, u1, u2, u3, u4);
				return;
			default:
				return;
			}
		}

		public static void 腕翼鳥絶頂(this Cha Cha, double a)
		{
			foreach (腕翼鳥 腕翼鳥 in Cha.Bod.腕翼鳥左)
			{
				腕翼鳥.肩.角度C = a * OthN.XS.NextDouble();
			}
			foreach (腕翼鳥 腕翼鳥2 in Cha.Bod.腕翼鳥右)
			{
				腕翼鳥2.肩.角度C = -a * OthN.XS.NextDouble();
			}
		}

		public static void 腕_翼獣左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double 上腕展開, double 下腕展開, double 手展開, double 肩角度B, double 上腕角度B, double 下腕角度B, double 手角度B)
		{
			腕翼獣 腕翼獣 = Cha.Bod.腕翼獣左[n];
			腕翼獣.肩.Set角度0();
			if (n == 0)
			{
				腕翼獣.肩.角度B = 肩角度B + u1;
			}
			if (腕翼獣.上腕 != null)
			{
				腕翼獣.上腕.Set角度0();
				腕翼獣.上腕.展開 = 上腕展開;
				腕翼獣.上腕.角度B += 上腕角度B + u2;
				if (腕翼獣.下腕 != null)
				{
					腕翼獣.下腕.Set角度0();
					腕翼獣.下腕.展開 = 下腕展開;
					腕翼獣.下腕.角度B += 下腕角度B + u3;
					if (腕翼獣.手 != null)
					{
						腕翼獣.手.Set角度0();
						腕翼獣.手.展開 = 手展開;
						腕翼獣.手.角度B += 手角度B + u4;
					}
				}
			}
			腕翼獣.肩.重複角度処理();
		}

		public static void 腕_翼獣右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double 上腕展開, double 下腕展開, double 手展開, double 肩角度B, double 上腕角度B, double 下腕角度B, double 手角度B)
		{
			腕翼獣 腕翼獣 = Cha.Bod.腕翼獣右[n];
			腕翼獣.肩.Set角度0();
			if (n == 0)
			{
				腕翼獣.肩.角度B = -肩角度B + -u1;
			}
			if (腕翼獣.上腕 != null)
			{
				腕翼獣.上腕.Set角度0();
				腕翼獣.上腕.展開 = 上腕展開;
				腕翼獣.上腕.角度B += -上腕角度B + -u2;
				if (腕翼獣.下腕 != null)
				{
					腕翼獣.下腕.Set角度0();
					腕翼獣.下腕.展開 = 下腕展開;
					腕翼獣.下腕.角度B += -下腕角度B + -u3;
					if (腕翼獣.手 != null)
					{
						腕翼獣.手.Set角度0();
						腕翼獣.手.展開 = 手展開;
						腕翼獣.手.角度B += -手角度B + -u4;
					}
				}
			}
			腕翼獣.肩.重複角度処理();
		}

		public static void 腕_翼獣_脱力左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_翼獣左(n, u1, u2, u3, u4, 0.0, 0.25, 0.25, 0.0, -1.0, 0.0, 0.0);
		}

		public static void 腕_翼獣_脱力右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_翼獣右(n, u1, u2, u3, u4, 0.0, 0.25, 0.25, 0.0, -1.0, 0.0, 0.0);
		}

		public static void 腕_翼獣_強張り左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_翼獣左(n, u1, u2, u3, u4, 0.0, 0.0, 0.0, 0.0, -10.0, 10.0, 0.0);
		}

		public static void 腕_翼獣_強張り右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_翼獣右(n, u1, u2, u3, u4, 0.0, 0.0, 0.0, 0.0, -10.0, 10.0, 0.0);
		}

		public static void 腕_翼獣_閉じ左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_翼獣左(n, u1, u2, u3, u4, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0);
		}

		public static void 腕_翼獣_閉じ右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_翼獣右(n, u1, u2, u3, u4, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0);
		}

		public static void 腕_翼獣_半開き左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_翼獣左(n, u1, u2, u3, u4, 0.25, 0.25, 0.25, -3.0, 0.0, 0.0, 0.0);
		}

		public static void 腕_翼獣_半開き右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_翼獣右(n, u1, u2, u3, u4, 0.25, 0.25, 0.25, -3.0, 0.0, 0.0, 0.0);
		}

		public static void 腕_翼獣_全開左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_翼獣左(n, u1, u2, u3, u4, 1.0, 1.0, 1.0, 6.0, 3.0, 0.0, 0.0);
		}

		public static void 腕_翼獣_全開右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_翼獣右(n, u1, u2, u3, u4, 1.0, 1.0, 1.0, 6.0, 3.0, 0.0, 0.0);
		}

		public static void 両腕_翼獣_脱力(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 0.0, OthN.XS.NextSign(), 0.25);
			Cha.腕_翼獣_脱力左(n, u, u2, u3, u4);
			Cha.腕_翼獣_脱力右(n, u, u2, u3, u4);
		}

		public static void 両腕_翼獣_強張り(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 0.0, OthN.XS.NextSign(), 0.25);
			Cha.腕_翼獣_強張り左(n, u, u2, u3, u4);
			Cha.腕_翼獣_強張り右(n, u, u2, u3, u4);
		}

		public static void 両腕_翼獣_閉じ(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 0.0, OthN.XS.NextSign(), 0.25);
			Cha.腕_翼獣_閉じ左(n, u, u2, u3, u4);
			Cha.腕_翼獣_閉じ右(n, u, u2, u3, u4);
		}

		public static void 両腕_翼獣_半開き(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 0.0, OthN.XS.NextSign(), 0.25);
			Cha.腕_翼獣_半開き左(n, u, u2, u3, u4);
			Cha.腕_翼獣_半開き右(n, u, u2, u3, u4);
		}

		public static void 両腕_翼獣_全開(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 0.0, OthN.XS.NextSign(), 0.25);
			Cha.腕_翼獣_全開左(n, u, u2, u3, u4);
			Cha.腕_翼獣_全開右(n, u, u2, u3, u4);
		}

		public static void 両腕翼獣_0(this Cha Cha, int n, bool 同角, int i1, int i2)
		{
			double num = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			double num2 = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			double num3 = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			double num4 = Cha.角度ムラ(OthN.XS.NextSign(), 0.0, OthN.XS.NextSign(), 0.25);
			double u;
			double u2;
			double u3;
			double u4;
			if (同角)
			{
				u = num;
				u2 = num2;
				u3 = num3;
				u4 = num4;
			}
			else
			{
				u = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
				u2 = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
				u3 = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
				u4 = Cha.角度ムラ(OthN.XS.NextSign(), 0.0, OthN.XS.NextSign(), 0.25);
			}
			Cha.腕翼獣左_0(i1, n, num, num2, num3, num4);
			Cha.腕翼獣右_0(i2, n, u, u2, u3, u4);
		}

		public static void 腕翼獣左_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4)
		{
			switch (i)
			{
			case 0:
				c.腕_翼獣_脱力左(n, u1, u2, u3, u4);
				return;
			case 1:
				c.腕_翼獣_強張り左(n, u1, u2, u3, u4);
				return;
			case 2:
				c.腕_翼獣_閉じ左(n, u1, u2, u3, u4);
				return;
			case 3:
				c.腕_翼獣_半開き左(n, u1, u2, u3, u4);
				return;
			case 4:
				c.腕_翼獣_全開左(n, u1, u2, u3, u4);
				return;
			default:
				return;
			}
		}

		public static void 腕翼獣右_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4)
		{
			switch (i)
			{
			case 0:
				c.腕_翼獣_脱力右(n, u1, u2, u3, u4);
				return;
			case 1:
				c.腕_翼獣_強張り右(n, u1, u2, u3, u4);
				return;
			case 2:
				c.腕_翼獣_閉じ右(n, u1, u2, u3, u4);
				return;
			case 3:
				c.腕_翼獣_半開き右(n, u1, u2, u3, u4);
				return;
			case 4:
				c.腕_翼獣_全開右(n, u1, u2, u3, u4);
				return;
			default:
				return;
			}
		}

		public static void 腕翼獣絶頂(this Cha Cha, double a)
		{
			foreach (腕翼獣 腕翼獣 in Cha.Bod.腕翼獣左)
			{
				腕翼獣.肩.角度C = a * OthN.XS.NextDouble();
			}
			foreach (腕翼獣 腕翼獣2 in Cha.Bod.腕翼獣右)
			{
				腕翼獣2.肩.角度C = -a * OthN.XS.NextDouble();
			}
		}

		public static void 腕_獣左(this Cha Cha, int n, double u2, double u3, double u4, double 上腕角度B, double 下腕角度B, double 手角度B, double 上腕尺度XC, double 下腕尺度XC, double 手尺度XC)
		{
			腕獣 腕獣 = Cha.Bod.腕獣左[n];
			腕獣.肩.Set角度0();
			if (腕獣.上腕 != null)
			{
				腕獣.上腕.Set角度0();
				腕獣.上腕.尺度XC = 上腕尺度XC;
				腕獣.上腕.角度B += 上腕角度B + u2;
				if (腕獣.下腕 != null)
				{
					腕獣.下腕.Set角度0();
					腕獣.下腕.尺度XC = 下腕尺度XC;
					腕獣.下腕.角度B += 下腕角度B + u3;
					if (腕獣.手 != null)
					{
						腕獣.手.Set角度0();
						腕獣.手.尺度XC = 手尺度XC;
						腕獣.手.角度B += 手角度B + u4;
					}
				}
			}
			腕獣.肩.重複角度処理();
		}

		public static void 腕_獣右(this Cha Cha, int n, double u2, double u3, double u4, double 上腕角度B, double 下腕角度B, double 手角度B, double 上腕尺度XC, double 下腕尺度XC, double 手尺度XC)
		{
			腕獣 腕獣 = Cha.Bod.腕獣右[n];
			腕獣.肩.Set角度0();
			if (腕獣.上腕 != null)
			{
				腕獣.上腕.Set角度0();
				腕獣.上腕.尺度XC = 上腕尺度XC;
				腕獣.上腕.角度B += -上腕角度B + -u2;
				if (腕獣.下腕 != null)
				{
					腕獣.下腕.Set角度0();
					腕獣.下腕.尺度XC = 下腕尺度XC;
					腕獣.下腕.角度B += -下腕角度B + -u3;
					if (腕獣.手 != null)
					{
						腕獣.手.Set角度0();
						腕獣.手.尺度XC = 手尺度XC;
						腕獣.手.角度B += -手角度B + -u4;
					}
				}
			}
			腕獣.肩.重複角度処理();
		}

		public static void 腕_獣_基本左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_獣左(n, u2, u3, u4, 0.0, 0.0, 0.0, 1.0, 1.0, 1.0);
		}

		public static void 腕_獣_基本右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_獣右(n, u2, u3, u4, 0.0, 0.0, 0.0, 1.0, 1.0, 1.0);
		}

		public static void 腕_獣_脱力左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_獣左(n, u2, u3, u4, 0.0, -25.0, 30.0, 0.9, 0.8, 1.0);
		}

		public static void 腕_獣_脱力右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_獣右(n, u2, u3, u4, 0.0, -25.0, 30.0, 0.9, 0.8, 1.0);
		}

		public static void 腕_獣_媚び左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_獣左(n, u2, u3, u4, -25.0, 33.0, 0.0, 1.0, 1.0, 1.0);
		}

		public static void 腕_獣_媚び右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.腕_獣右(n, u2, u3, u4, -25.0, 33.0, 0.0, 1.0, 1.0, 1.0);
		}

		public static void 両腕_獣_基本(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.腕_獣_基本左(n, u, u2, u3, u4);
			Cha.腕_獣_基本右(n, u, u2, u3, u4);
		}

		public static void 両腕_獣_脱力(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.腕_獣_脱力左(n, u, u2, u3, u4);
			Cha.腕_獣_脱力右(n, u, u2, u3, u4);
		}

		public static void 両腕_獣_媚び(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.腕_獣_媚び左(n, u, u2, u3, u4);
			Cha.腕_獣_媚び右(n, u, u2, u3, u4);
		}

		public static void 両腕獣_0(this Cha Cha, int n, bool 同角, int i1, int i2)
		{
			double num = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double num2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double num3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double num4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u;
			double u2;
			double u3;
			double u4;
			if (同角)
			{
				u = num;
				u2 = num2;
				u3 = num3;
				u4 = num4;
			}
			else
			{
				u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			}
			Cha.腕獣左_0(i1, n, num, num2, num3, num4);
			Cha.腕獣右_0(i2, n, u, u2, u3, u4);
		}

		public static void 腕獣左_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4)
		{
			switch (i)
			{
			case 0:
				c.腕_獣_基本左(n, u1, u2, u3, u4);
				return;
			case 1:
				c.腕_獣_脱力左(n, u1, u2, u3, u4);
				return;
			case 2:
				c.腕_獣_媚び左(n, u1, u2, u3, u4);
				return;
			default:
				return;
			}
		}

		public static void 腕獣右_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4)
		{
			switch (i)
			{
			case 0:
				c.腕_獣_基本右(n, u1, u2, u3, u4);
				return;
			case 1:
				c.腕_獣_脱力右(n, u1, u2, u3, u4);
				return;
			case 2:
				c.腕_獣_媚び右(n, u1, u2, u3, u4);
				return;
			default:
				return;
			}
		}

		public static void 腕獣絶頂(this Cha Cha, double a)
		{
			foreach (腕獣 腕獣 in Cha.Bod.腕獣左)
			{
				if (腕獣.上腕 != null)
				{
					腕獣.上腕.角度C = a * OthN.XS.NextDouble();
					if (腕獣.下腕 != null)
					{
						腕獣.下腕.角度C = a * OthN.XS.NextDouble();
						if (腕獣.手 != null)
						{
							腕獣.手.角度C = a * OthN.XS.NextDouble();
						}
					}
				}
			}
			foreach (腕獣 腕獣2 in Cha.Bod.腕獣右)
			{
				if (腕獣2.上腕 != null)
				{
					腕獣2.上腕.角度C = -a * OthN.XS.NextDouble();
					if (腕獣2.下腕 != null)
					{
						腕獣2.下腕.角度C = -a * OthN.XS.NextDouble();
						if (腕獣2.手 != null)
						{
							腕獣2.手.角度C = -a * OthN.XS.NextDouble();
						}
					}
				}
			}
		}

		public static void 脚_人左(this Cha Cha, int n, double u1, double u2, double u3, double 腿角度B, double 脚角度B, double 足角度B, double 腿尺度YC, double 脚尺度YC, double 足尺度YC)
		{
			脚人 脚人 = Cha.Bod.脚人左[n];
			脚人.腿.Set角度0();
			脚人.腿.尺度YC = 腿尺度YC;
			脚人.腿.角度B += 腿角度B + u1;
			if (脚人.脚 != null)
			{
				脚人.脚.Set角度0();
				脚人.脚.角度B = -脚人.腿.角度B;
				脚人.脚.尺度YC = 脚尺度YC;
				脚人.脚.角度B += 脚角度B + u2;
				if (脚人.足 != null)
				{
					脚人.足.Set角度0();
					脚人.足.角度B = 0.0;
					脚人.足.尺度YC = 足尺度YC;
					脚人.足.角度B += 足角度B + u3;
				}
			}
		}

		public static void 脚_人右(this Cha Cha, int n, double u1, double u2, double u3, double 腿角度B, double 脚角度B, double 足角度B, double 腿尺度YC, double 脚尺度YC, double 足尺度YC)
		{
			脚人 脚人 = Cha.Bod.脚人右[n];
			脚人.腿.Set角度0();
			脚人.腿.尺度YC = 腿尺度YC;
			脚人.腿.角度B += -腿角度B + -u1;
			if (脚人.脚 != null)
			{
				脚人.脚.Set角度0();
				脚人.脚.角度B = -脚人.腿.角度B;
				脚人.脚.尺度YC = 脚尺度YC;
				脚人.脚.角度B += -脚角度B + -u2;
				if (脚人.足 != null)
				{
					脚人.足.Set角度0();
					脚人.足.角度B = 0.0;
					脚人.足.尺度YC = 足尺度YC;
					脚人.足.角度B += -足角度B + -u3;
				}
			}
		}

		public static void 脚_人_上開き左(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.Bod.左腿開きi = 3;
			Cha.脚_人左(n, u1, u2, u3, 0.0, 5.0, 0.0, 1.0, 1.0, 1.0);
		}

		public static void 脚_人_上開き右(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.Bod.右腿開きi = 3;
			Cha.脚_人右(n, u1, u2, u3, 0.0, 5.0, 0.0, 1.0, 1.0, 1.0);
		}

		public static void 脚_人_上閉じ左(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.Bod.左腿開きi = 4;
			Cha.脚_人左(n, u1, u2, u3, 3.0, 0.0, 0.0, 1.0, 1.0, 1.0);
		}

		public static void 脚_人_上閉じ右(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.Bod.右腿開きi = 4;
			Cha.脚_人右(n, u1, u2, u3, 3.0, 0.0, 0.0, 1.0, 1.0, 1.0);
		}

		public static void 脚_人_上閉じ内左(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.Bod.左腿開きi = 4;
			Cha.脚_人左(n, u1, u2, u3, 3.0, 10.0, -15.0, 1.0, 1.0, 1.0);
		}

		public static void 脚_人_上閉じ内右(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.Bod.右腿開きi = 4;
			Cha.脚_人右(n, u1, u2, u3, 3.0, 10.0, -15.0, 1.0, 1.0, 1.0);
		}

		public static void 脚_人_脱力左(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.Bod.左腿開きi = 1;
			Cha.脚_人左(n, u1, u2, u3, 0.0, -5.0, 0.0, 1.0, 1.0, 1.0);
		}

		public static void 脚_人_脱力右(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.Bod.右腿開きi = 1;
			Cha.脚_人右(n, u1, u2, u3, 0.0, -5.0, 0.0, 1.0, 1.0, 1.0);
		}

		public static void 脚_人_内股左(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.Bod.左腿開きi = 0;
			Cha.脚_人左(n, u1, u2, u3, -5.0, 15.0, 0.0, 1.0, 1.0, 1.0);
		}

		public static void 脚_人_内股右(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.Bod.右腿開きi = 0;
			Cha.脚_人右(n, u1, u2, u3, -5.0, 15.0, 0.0, 1.0, 1.0, 1.0);
		}

		public static void 脚_人_直立左(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.Bod.左腿開きi = 0;
			Cha.脚_人左(n, u1, u2, u3, 0.0, 0.0, 0.0, 1.0, 1.0, 1.0);
		}

		public static void 脚_人_直立右(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.Bod.右腿開きi = 0;
			Cha.脚_人右(n, u1, u2, u3, 0.0, 0.0, 0.0, 1.0, 1.0, 1.0);
		}

		public static void 脚_人_がに股左(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.Bod.左腿開きi = 2;
			Cha.脚_人左(n, u1, u2, u3, 0.0, -10.0, 0.0, 1.0, 1.0, 1.0);
		}

		public static void 脚_人_がに股右(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.Bod.右腿開きi = 2;
			Cha.脚_人右(n, u1, u2, u3, 0.0, -10.0, 0.0, 1.0, 1.0, 1.0);
		}

		public static void 脚_人_おっぴろげ左(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.Bod.左腿開きi = 2;
			Cha.脚_人左(n, u1, u2, u3, 10.0, 10.0, 0.0, 1.0, 1.0, 1.0);
		}

		public static void 脚_人_おっぴろげ右(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.Bod.右腿開きi = 2;
			Cha.脚_人右(n, u1, u2, u3, 10.0, 10.0, 0.0, 1.0, 1.0, 1.0);
		}

		public static void 脚_人_M字開脚左(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.Bod.左腿開きi = 3;
			Cha.脚_人左(n, u1, u2, u3, -10.0, 10.0, 0.0, 1.0, 1.0, 1.0);
		}

		public static void 脚_人_M字開脚右(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.Bod.右腿開きi = 3;
			Cha.脚_人右(n, u1, u2, u3, -10.0, 10.0, 0.0, 1.0, 1.0, 1.0);
		}

		public static void 脚_人_足コキ左(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.Bod.左腿開きi = 2;
			Cha.脚_人左(n, u1, u2, u3, -23.0, -68.0, 47.0, 1.0, 1.0, 1.0);
		}

		public static void 脚_人_足コキ右(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.Bod.右腿開きi = 2;
			Cha.脚_人右(n, u1, u2, u3, -23.0, -68.0, 47.0, 1.0, 1.0, 1.0);
		}

		public static void 両脚_人_上開き(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.脚_人_上開き左(n, u, u2, u3);
			Cha.脚_人_上開き右(n, u, u2, u3);
		}

		public static void 両脚_人_上閉じ(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.脚_人_上閉じ左(n, u, u2, u3);
			Cha.脚_人_上閉じ右(n, u, u2, u3);
		}

		public static void 両脚_人_上閉じ内(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.脚_人_上閉じ内左(n, u, u2, u3);
			Cha.脚_人_上閉じ内右(n, u, u2, u3);
		}

		public static void 両脚_人_脱力(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.Bod.腿開きi = 1;
			Cha.脚_人_脱力左(n, u, u2, u3);
			Cha.脚_人_脱力右(n, u, u2, u3);
		}

		public static void 両脚_人_内股(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.Bod.腿開きi = 0;
			Cha.脚_人_内股左(n, u, u2, u3);
			Cha.脚_人_内股右(n, u, u2, u3);
		}

		public static void 両脚_人_直立(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 1.0, OthN.XS.NextSign(), 1.0);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 1.0, OthN.XS.NextSign(), 1.0);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 1.0, OthN.XS.NextSign(), 1.0);
			Cha.Bod.腿開きi = 0;
			Cha.脚_人_直立左(n, u, u2, u3);
			Cha.脚_人_直立右(n, u, u2, u3);
		}

		public static void 両脚_人_がに股(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.Bod.腿開きi = 2;
			Cha.脚_人_がに股左(n, u, u2, u3);
			Cha.脚_人_がに股右(n, u, u2, u3);
		}

		public static void 両脚_人_おっぴろげ(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.Bod.腿開きi = 2;
			Cha.脚_人_おっぴろげ左(n, u, u2, u3);
			Cha.脚_人_おっぴろげ右(n, u, u2, u3);
		}

		public static void 両脚_人_M字開脚(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.Bod.腿開きi = 3;
			Cha.脚_人_M字開脚左(n, u, u2, u3);
			Cha.脚_人_M字開脚右(n, u, u2, u3);
		}

		public static void 両脚_人_足コキ(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.Bod.腿開きi = 2;
			Cha.脚_人_足コキ左(n, u, u2, u3);
			Cha.脚_人_足コキ右(n, u, u2, u3);
		}

		public static void 両脚人_0(this Cha Cha, int n, bool 同角, int i1, int i2)
		{
			double ba;
			double ba2;
			if (i1 == 5)
			{
				ba = 1.0;
				ba2 = 1.0;
			}
			else
			{
				ba = 3.0;
				ba2 = 1.5;
			}
			double num = Cha.角度ムラ(OthN.XS.NextSign(), ba, OthN.XS.NextSign(), ba2);
			double num2 = Cha.角度ムラ(OthN.XS.NextSign(), ba, OthN.XS.NextSign(), ba2);
			double num3 = Cha.角度ムラ(OthN.XS.NextSign(), ba, OthN.XS.NextSign(), ba2);
			double u;
			double u2;
			double u3;
			if (同角)
			{
				u = num;
				u2 = num2;
				u3 = num3;
			}
			else
			{
				if (i2 == 5)
				{
					ba = 1.0;
					ba2 = 1.0;
				}
				else
				{
					ba = 3.0;
					ba2 = 1.5;
				}
				u = Cha.角度ムラ(OthN.XS.NextSign(), ba, OthN.XS.NextSign(), ba2);
				u2 = Cha.角度ムラ(OthN.XS.NextSign(), ba, OthN.XS.NextSign(), ba2);
				u3 = Cha.角度ムラ(OthN.XS.NextSign(), ba, OthN.XS.NextSign(), ba2);
			}
			Cha.脚人左_0(i1, n, num, num2, num3);
			Cha.脚人右_0(i2, n, u, u2, u3);
		}

		public static void 脚人左_0(this Cha c, int i, int n, double u1, double u2, double u3)
		{
			switch (i)
			{
			case 0:
				c.脚_人_上開き左(n, u1, u2, u3);
				return;
			case 1:
				c.脚_人_上閉じ左(n, u1, u2, u3);
				return;
			case 2:
				c.脚_人_上閉じ内左(n, u1, u2, u3);
				return;
			case 3:
				c.脚_人_脱力左(n, u1, u2, u3);
				return;
			case 4:
				c.脚_人_内股左(n, u1, u2, u3);
				return;
			case 5:
				c.脚_人_直立左(n, u1, u2, u3);
				return;
			case 6:
				c.脚_人_がに股左(n, u1, u2, u3);
				return;
			case 7:
				c.脚_人_おっぴろげ左(n, u1, u2, u3);
				return;
			case 8:
				c.脚_人_M字開脚左(n, u1, u2, u3);
				return;
			case 9:
				c.脚_人_足コキ左(n, u1, u2, u3);
				return;
			default:
				return;
			}
		}

		public static void 脚人右_0(this Cha c, int i, int n, double u1, double u2, double u3)
		{
			switch (i)
			{
			case 0:
				c.脚_人_上開き右(n, u1, u2, u3);
				return;
			case 1:
				c.脚_人_上閉じ右(n, u1, u2, u3);
				return;
			case 2:
				c.脚_人_上閉じ内右(n, u1, u2, u3);
				return;
			case 3:
				c.脚_人_脱力右(n, u1, u2, u3);
				return;
			case 4:
				c.脚_人_内股右(n, u1, u2, u3);
				return;
			case 5:
				c.脚_人_直立右(n, u1, u2, u3);
				return;
			case 6:
				c.脚_人_がに股右(n, u1, u2, u3);
				return;
			case 7:
				c.脚_人_おっぴろげ右(n, u1, u2, u3);
				return;
			case 8:
				c.脚_人_M字開脚右(n, u1, u2, u3);
				return;
			case 9:
				c.脚_人_足コキ右(n, u1, u2, u3);
				return;
			default:
				return;
			}
		}

		public static void 脚人絶頂(this Cha Cha, double a)
		{
			foreach (脚人 脚人 in Cha.Bod.脚人左)
			{
				脚人.腿.角度C = a * OthN.XS.NextDouble();
				if (脚人.脚 != null)
				{
					脚人.脚.角度C = a * OthN.XS.NextDouble();
					if (脚人.足 != null)
					{
						脚人.足.角度C = a * OthN.XS.NextDouble();
					}
				}
			}
			foreach (脚人 脚人2 in Cha.Bod.脚人右)
			{
				脚人2.腿.角度C = -a * OthN.XS.NextDouble();
				if (脚人2.脚 != null)
				{
					脚人2.脚.角度C = -a * OthN.XS.NextDouble();
					if (脚人2.足 != null)
					{
						脚人2.足.角度C = -a * OthN.XS.NextDouble();
					}
				}
			}
		}

		public static void 脚_獣左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double 腿角度B, double 脚角度B, double 足角度B, double 腿尺度YC, double 脚尺度YC, double 足尺度YC)
		{
			脚獣 脚獣 = Cha.Bod.脚獣左[n];
			if (脚獣.腿 != null)
			{
				脚獣.腿.Set角度0();
				脚獣.腿.尺度YC = 腿尺度YC;
				脚獣.腿.角度B += 腿角度B + u1;
			}
			if (脚獣.脚 != null)
			{
				脚獣.脚.Set角度0();
				脚獣.脚.尺度YC = 脚尺度YC;
				if (脚獣.腿 == null)
				{
					脚獣.脚.角度B += 145.0;
				}
				脚獣.脚.角度B += 脚角度B + u2;
				if (脚獣.足 != null)
				{
					脚獣.足.Set角度0();
					脚獣.足.尺度YC = 足尺度YC;
					脚獣.足.角度B += 足角度B + u3;
					if (脚獣.足 is 足_鳥)
					{
						足_鳥 足_鳥 = (足_鳥)脚獣.足;
						足_鳥.X0Y0_足首.AngleCont = -25.0 * u4;
						足_鳥.X0Y0_親指_指1.AngleCont = 45.0 * u4;
						足_鳥.X0Y0_人指_指1.AngleCont = -60.0 * u4;
						足_鳥.X0Y0_人指_指2.AngleCont = -60.0 * u4;
						足_鳥.X0Y0_薬指_指1.AngleCont = -45.0 * u4;
						足_鳥.X0Y0_薬指_指2.AngleCont = -45.0 * u4;
						足_鳥.X0Y0_薬指_指3.AngleCont = -45.0 * u4;
						足_鳥.X0Y0_中指_指1.AngleCont = -45.0 * u4;
						足_鳥.X0Y0_中指_指2.AngleCont = -45.0 * u4;
						足_鳥.X0Y0_中指_指3.AngleCont = -45.0 * u4;
					}
				}
			}
		}

		public static void 脚_獣右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double 腿角度B, double 脚角度B, double 足角度B, double 腿尺度YC, double 脚尺度YC, double 足尺度YC)
		{
			脚獣 脚獣 = Cha.Bod.脚獣右[n];
			if (脚獣.腿 != null)
			{
				脚獣.腿.Set角度0();
				脚獣.腿.尺度YC = 腿尺度YC;
				脚獣.腿.角度B += -腿角度B + -u1;
			}
			if (脚獣.脚 != null)
			{
				脚獣.脚.Set角度0();
				脚獣.脚.尺度YC = 脚尺度YC;
				if (脚獣.腿 == null)
				{
					脚獣.脚.角度B += -145.0;
				}
				脚獣.脚.角度B += -脚角度B + -u2;
				if (脚獣.足 != null)
				{
					脚獣.足.Set角度0();
					脚獣.足.尺度YC = 足尺度YC;
					脚獣.足.角度B += -足角度B + -u3;
					if (脚獣.足 is 足_鳥)
					{
						足_鳥 足_鳥 = (足_鳥)脚獣.足;
						足_鳥.X0Y0_足首.AngleCont = 25.0 * u4;
						足_鳥.X0Y0_親指_指1.AngleCont = -45.0 * u4;
						足_鳥.X0Y0_人指_指1.AngleCont = 60.0 * u4;
						足_鳥.X0Y0_人指_指2.AngleCont = 60.0 * u4;
						足_鳥.X0Y0_薬指_指1.AngleCont = 45.0 * u4;
						足_鳥.X0Y0_薬指_指2.AngleCont = 45.0 * u4;
						足_鳥.X0Y0_薬指_指3.AngleCont = 45.0 * u4;
						足_鳥.X0Y0_中指_指1.AngleCont = 45.0 * u4;
						足_鳥.X0Y0_中指_指2.AngleCont = 45.0 * u4;
						足_鳥.X0Y0_中指_指3.AngleCont = 45.0 * u4;
					}
				}
			}
		}

		public static void 脚_獣_基本左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.脚_獣左(n, u1, u2, u3, u4, 0.0, 0.0, 0.0, 1.0, 1.0, 1.0);
		}

		public static void 脚_獣_基本右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.脚_獣右(n, u1, u2, u3, u4, 0.0, 0.0, 0.0, 1.0, 1.0, 1.0);
		}

		public static void 脚_獣_萎縮左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.脚_獣左(n, u1, u2, u3, u4, 12.0, -12.0, 12.0, 1.0, 1.0, 1.0);
		}

		public static void 脚_獣_萎縮右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.脚_獣右(n, u1, u2, u3, u4, 12.0, -12.0, 12.0, 1.0, 1.0, 1.0);
		}

		public static void 脚_獣_脱力左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.脚_獣左(n, u1, u2, u3, u4, -10.0, 10.0, -10.0, 1.0, 1.0, 1.0);
		}

		public static void 脚_獣_脱力右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
		{
			Cha.脚_獣右(n, u1, u2, u3, u4, -10.0, 10.0, -10.0, 1.0, 1.0, 1.0);
		}

		public static void 両脚_獣_基本(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = OthN.XS.NextDouble();
			Cha.脚_獣_基本左(n, u, u2, u3, u4);
			Cha.脚_獣_基本右(n, u, u2, u3, u4);
		}

		public static void 両脚_獣_萎縮(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = OthN.XS.NextDouble();
			Cha.脚_獣_萎縮左(n, u, u2, u3, u4);
			Cha.脚_獣_萎縮右(n, u, u2, u3, u4);
		}

		public static void 両脚_獣_脱力(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = OthN.XS.NextDouble();
			Cha.脚_獣_脱力左(n, u, u2, u3, u4);
			Cha.脚_獣_脱力右(n, u, u2, u3, u4);
		}

		public static void 両脚獣_0(this Cha Cha, int n, bool 同角, int i1, int i2)
		{
			double num = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double num2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double num3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double num4 = OthN.XS.NextDouble();
			double u;
			double u2;
			double u3;
			double u4;
			if (同角)
			{
				u = num;
				u2 = num2;
				u3 = num3;
				u4 = num4;
			}
			else
			{
				u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				u4 = OthN.XS.NextDouble();
			}
			Cha.脚獣左_0(i1, n, num, num2, num3, num4);
			Cha.脚獣右_0(i2, n, u, u2, u3, u4);
		}

		public static void 脚獣左_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4)
		{
			switch (i)
			{
			case 0:
				c.脚_獣_基本左(n, u1, u2, u3, u4);
				return;
			case 1:
				c.脚_獣_萎縮左(n, u1, u2, u3, u4);
				return;
			case 2:
				c.脚_獣_脱力左(n, u1, u2, u3, u4);
				return;
			default:
				return;
			}
		}

		public static void 脚獣右_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4)
		{
			switch (i)
			{
			case 0:
				c.脚_獣_基本右(n, u1, u2, u3, u4);
				return;
			case 1:
				c.脚_獣_萎縮右(n, u1, u2, u3, u4);
				return;
			case 2:
				c.脚_獣_脱力右(n, u1, u2, u3, u4);
				return;
			default:
				return;
			}
		}

		public static void 脚獣絶頂(this Cha Cha, double a)
		{
			foreach (脚獣 脚獣 in Cha.Bod.脚獣左)
			{
				if (脚獣.腿 != null)
				{
					脚獣.腿.角度C = a * OthN.XS.NextDouble();
				}
				if (脚獣.脚 != null)
				{
					脚獣.脚.角度C = a * OthN.XS.NextDouble();
					if (脚獣.足 != null)
					{
						脚獣.足.角度C = a * OthN.XS.NextDouble();
					}
				}
			}
			foreach (脚獣 脚獣2 in Cha.Bod.脚獣右)
			{
				if (脚獣2.腿 != null)
				{
					脚獣2.腿.角度C = -a * OthN.XS.NextDouble();
				}
				if (脚獣2.脚 != null)
				{
					脚獣2.脚.角度C = -a * OthN.XS.NextDouble();
					if (脚獣2.足 != null)
					{
						脚獣2.足.角度C = -a * OthN.XS.NextDouble();
					}
				}
			}
		}

		public static void 翼鳥左(this Cha Cha, int n, double u1, double u2, double u3, double 上腕展開, double 下腕展開, double 手展開, double 上腕角度B, double 下腕角度B, double 手角度B)
		{
			翼鳥 翼鳥 = Cha.Bod.翼鳥左[n];
			翼鳥.上腕.Set角度0();
			翼鳥.上腕.展開 = 上腕展開;
			翼鳥.上腕.角度B += 上腕角度B + u1;
			if (翼鳥.下腕 != null)
			{
				翼鳥.下腕.Set角度0();
				翼鳥.下腕.展開 = 下腕展開;
				翼鳥.下腕.角度B += 下腕角度B + u2;
				if (翼鳥.手 != null)
				{
					翼鳥.手.Set角度0();
					翼鳥.手.展開 = 手展開;
					翼鳥.手.角度B += 手角度B + u3;
				}
			}
			翼鳥.上腕.重複角度処理();
		}

		public static void 翼鳥右(this Cha Cha, int n, double u1, double u2, double u3, double 上腕展開, double 下腕展開, double 手展開, double 上腕角度B, double 下腕角度B, double 手角度B)
		{
			翼鳥 翼鳥 = Cha.Bod.翼鳥右[n];
			翼鳥.上腕.Set角度0();
			翼鳥.上腕.展開 = 上腕展開;
			翼鳥.上腕.角度B += -上腕角度B + -u1;
			if (翼鳥.下腕 != null)
			{
				翼鳥.下腕.Set角度0();
				翼鳥.下腕.展開 = 下腕展開;
				翼鳥.下腕.角度B += -下腕角度B + -u2;
				if (翼鳥.手 != null)
				{
					翼鳥.手.Set角度0();
					翼鳥.手.展開 = 手展開;
					翼鳥.手.角度B += -手角度B + -u3;
				}
			}
			翼鳥.上腕.重複角度処理();
		}

		public static void 翼鳥_脱力左(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.翼鳥左(n, u1, u2, u3, 0.0, 0.25, 0.25, -1.0, 5.0, 0.0);
		}

		public static void 翼鳥_脱力右(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.翼鳥右(n, u1, u2, u3, 0.0, 0.25, 0.25, -1.0, 5.0, 0.0);
		}

		public static void 翼鳥_強張り左(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.翼鳥左(n, u1, u2, u3, 0.0, 0.0, 0.0, -10.0, 10.0, 0.0);
		}

		public static void 翼鳥_強張り右(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.翼鳥右(n, u1, u2, u3, 0.0, 0.0, 0.0, -10.0, 10.0, 0.0);
		}

		public static void 翼鳥_恥じらい左(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.翼鳥左(n, u1, u2, u3, 0.0, 0.0, 0.0, -20.0, 15.0, 0.0);
		}

		public static void 翼鳥_恥じらい右(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.翼鳥右(n, u1, u2, u3, 0.0, 0.0, 0.0, -20.0, 15.0, 0.0);
		}

		public static void 翼鳥_顔隠し左(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.翼鳥左(n, u1, u2, u3, 0.0, 0.0, 0.0, -20.0, 20.0, 0.0);
		}

		public static void 翼鳥_顔隠し右(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.翼鳥右(n, u1, u2, u3, 0.0, 0.0, 0.0, -20.0, 20.0, 0.0);
		}

		public static void 翼鳥_閉じ左(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.翼鳥左(n, u1, u2, u3, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0);
		}

		public static void 翼鳥_閉じ右(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.翼鳥右(n, u1, u2, u3, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0);
		}

		public static void 翼鳥_半開き左(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.翼鳥左(n, u1, u2, u3, 0.25, 0.25, 0.25, 0.0, 0.0, 0.0);
		}

		public static void 翼鳥_半開き右(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.翼鳥右(n, u1, u2, u3, 0.25, 0.25, 0.25, 0.0, 0.0, 0.0);
		}

		public static void 翼鳥_全開左(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.翼鳥左(n, u1, u2, u3, 1.0, 1.0, 1.0, 3.0, 0.0, 0.0);
		}

		public static void 翼鳥_全開右(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.翼鳥右(n, u1, u2, u3, 1.0, 1.0, 1.0, 3.0, 0.0, 0.0);
		}

		public static void 両翼鳥_脱力(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.翼鳥_脱力左(n, u, u2, u3);
			Cha.翼鳥_脱力右(n, u, u2, u3);
		}

		public static void 両翼鳥_強張り(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.翼鳥_強張り左(n, u, u2, u3);
			Cha.翼鳥_強張り右(n, u, u2, u3);
		}

		public static void 両翼鳥_恥じらい(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.翼鳥_恥じらい左(n, u, u2, u3);
			Cha.翼鳥_恥じらい右(n, u, u2, u3);
		}

		public static void 両翼鳥_顔隠し(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.翼鳥_顔隠し左(n, u, u2, u3);
			Cha.翼鳥_顔隠し右(n, u, u2, u3);
		}

		public static void 両翼鳥_閉じ(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.翼鳥_閉じ左(n, u, u2, u3);
			Cha.翼鳥_閉じ右(n, u, u2, u3);
		}

		public static void 両翼鳥_半開き(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.翼鳥_半開き左(n, u, u2, u3);
			Cha.翼鳥_半開き右(n, u, u2, u3);
		}

		public static void 両翼鳥_全開(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.翼鳥_全開左(n, u, u2, u3);
			Cha.翼鳥_全開右(n, u, u2, u3);
		}

		public static void 両翼鳥_0(this Cha Cha, int n, bool 同角, int i1, int i2)
		{
			double num = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double num2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double num3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u;
			double u2;
			double u3;
			if (同角)
			{
				u = num;
				u2 = num2;
				u3 = num3;
			}
			else
			{
				u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			}
			Cha.翼鳥左_0(i1, n, num, num2, num3);
			Cha.翼鳥右_0(i2, n, u, u2, u3);
		}

		public static void 翼鳥左_0(this Cha c, int i, int n, double u1, double u2, double u3)
		{
			switch (i)
			{
			case 0:
				c.翼鳥_脱力左(n, u1, u2, u3);
				return;
			case 1:
				c.翼鳥_強張り左(n, u1, u2, u3);
				return;
			case 2:
				c.翼鳥_恥じらい左(n, u1, u2, u3);
				return;
			case 3:
				c.翼鳥_顔隠し左(n, u1, u2, u3);
				return;
			case 4:
				c.翼鳥_閉じ左(n, u1, u2, u3);
				return;
			case 5:
				c.翼鳥_半開き左(n, u1, u2, u3);
				return;
			case 6:
				c.翼鳥_全開左(n, u1, u2, u3);
				return;
			default:
				return;
			}
		}

		public static void 翼鳥右_0(this Cha c, int i, int n, double u1, double u2, double u3)
		{
			switch (i)
			{
			case 0:
				c.翼鳥_脱力右(n, u1, u2, u3);
				return;
			case 1:
				c.翼鳥_強張り右(n, u1, u2, u3);
				return;
			case 2:
				c.翼鳥_恥じらい右(n, u1, u2, u3);
				return;
			case 3:
				c.翼鳥_顔隠し右(n, u1, u2, u3);
				return;
			case 4:
				c.翼鳥_閉じ右(n, u1, u2, u3);
				return;
			case 5:
				c.翼鳥_半開き右(n, u1, u2, u3);
				return;
			case 6:
				c.翼鳥_全開右(n, u1, u2, u3);
				return;
			default:
				return;
			}
		}

		public static void 翼獣左(this Cha Cha, int n, double u1, double u2, double u3, double 上腕展開, double 下腕展開, double 手展開, double 上腕角度B, double 下腕角度B, double 手角度B)
		{
			翼獣 翼獣 = Cha.Bod.翼獣左[n];
			翼獣.上腕.Set角度0();
			翼獣.上腕.展開 = 上腕展開;
			翼獣.上腕.角度B += 上腕角度B + u1;
			if (翼獣.下腕 != null)
			{
				翼獣.下腕.Set角度0();
				翼獣.下腕.展開 = 下腕展開;
				翼獣.下腕.角度B += 下腕角度B + u2;
				if (翼獣.手 != null)
				{
					翼獣.手.Set角度0();
					翼獣.手.展開 = 手展開;
					翼獣.手.角度B += 手角度B + u3;
				}
			}
			翼獣.上腕.重複角度処理();
		}

		public static void 翼獣右(this Cha Cha, int n, double u1, double u2, double u3, double 上腕展開, double 下腕展開, double 手展開, double 上腕角度B, double 下腕角度B, double 手角度B)
		{
			翼獣 翼獣 = Cha.Bod.翼獣右[n];
			翼獣.上腕.Set角度0();
			翼獣.上腕.展開 = 上腕展開;
			翼獣.上腕.角度B += -上腕角度B + -u1;
			if (翼獣.下腕 != null)
			{
				翼獣.下腕.Set角度0();
				翼獣.下腕.展開 = 下腕展開;
				翼獣.下腕.角度B += -下腕角度B + -u2;
				if (翼獣.手 != null)
				{
					翼獣.手.Set角度0();
					翼獣.手.展開 = 手展開;
					翼獣.手.角度B += -手角度B + -u3;
				}
			}
			翼獣.上腕.重複角度処理();
		}

		public static void 翼獣_脱力左(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.翼獣左(n, u1, u2, u3, 0.0, 0.25, 0.25, -1.0, 5.0, 0.0);
		}

		public static void 翼獣_脱力右(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.翼獣右(n, u1, u2, u3, 0.0, 0.25, 0.25, -1.0, 5.0, 0.0);
		}

		public static void 翼獣_強張り左(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.翼獣左(n, u1, u2, u3, 0.0, 0.0, 0.0, -10.0, 10.0, 0.0);
		}

		public static void 翼獣_強張り右(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.翼獣右(n, u1, u2, u3, 0.0, 0.0, 0.0, -10.0, 10.0, 0.0);
		}

		public static void 翼獣_恥じらい左(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.翼獣左(n, u1, u2, u3, 0.0, 0.0, 0.0, -20.0, 15.0, 0.0);
		}

		public static void 翼獣_恥じらい右(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.翼獣右(n, u1, u2, u3, 0.0, 0.0, 0.0, -20.0, 15.0, 0.0);
		}

		public static void 翼獣_顔隠し左(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.翼獣左(n, u1, u2, u3, 0.0, 0.0, 0.0, -20.0, 20.0, 0.0);
		}

		public static void 翼獣_顔隠し右(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.翼獣右(n, u1, u2, u3, 0.0, 0.0, 0.0, -20.0, 20.0, 0.0);
		}

		public static void 翼獣_閉じ左(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.翼獣左(n, u1, u2, u3, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0);
		}

		public static void 翼獣_閉じ右(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.翼獣右(n, u1, u2, u3, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0);
		}

		public static void 翼獣_半開き左(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.翼獣左(n, u1, u2, u3, 0.25, 0.25, 0.25, 0.0, 0.0, 0.0);
		}

		public static void 翼獣_半開き右(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.翼獣右(n, u1, u2, u3, 0.25, 0.25, 0.25, 0.0, 0.0, 0.0);
		}

		public static void 翼獣_全開左(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.翼獣左(n, u1, u2, u3, 1.0, 1.0, 1.0, 3.0, 0.0, 0.0);
		}

		public static void 翼獣_全開右(this Cha Cha, int n, double u1, double u2, double u3)
		{
			Cha.翼獣右(n, u1, u2, u3, 1.0, 1.0, 1.0, 3.0, 0.0, 0.0);
		}

		public static void 両翼獣_脱力(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 0.0, OthN.XS.NextSign(), 0.25);
			Cha.翼獣_脱力左(n, u, u2, u3);
			Cha.翼獣_脱力右(n, u, u2, u3);
		}

		public static void 両翼獣_強張り(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 0.0, OthN.XS.NextSign(), 0.25);
			Cha.翼獣_強張り左(n, u, u2, u3);
			Cha.翼獣_強張り右(n, u, u2, u3);
		}

		public static void 両翼獣_恥じらい(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 0.0, OthN.XS.NextSign(), 0.25);
			Cha.翼獣_恥じらい左(n, u, u2, u3);
			Cha.翼獣_恥じらい右(n, u, u2, u3);
		}

		public static void 両翼獣_顔隠し(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 0.0, OthN.XS.NextSign(), 0.25);
			Cha.翼獣_顔隠し左(n, u, u2, u3);
			Cha.翼獣_顔隠し右(n, u, u2, u3);
		}

		public static void 両翼獣_閉じ(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 0.0, OthN.XS.NextSign(), 0.25);
			Cha.翼獣_閉じ左(n, u, u2, u3);
			Cha.翼獣_閉じ右(n, u, u2, u3);
		}

		public static void 両翼獣_半開き(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 0.0, OthN.XS.NextSign(), 0.25);
			Cha.翼獣_半開き左(n, u, u2, u3);
			Cha.翼獣_半開き右(n, u, u2, u3);
		}

		public static void 両翼獣_全開(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 0.0, OthN.XS.NextSign(), 0.25);
			Cha.翼獣_全開左(n, u, u2, u3);
			Cha.翼獣_全開右(n, u, u2, u3);
		}

		public static void 両翼獣_0(this Cha Cha, int n, bool 同角, int i1, int i2)
		{
			double num = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			double num2 = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			double num3 = Cha.角度ムラ(OthN.XS.NextSign(), 0.0, OthN.XS.NextSign(), 0.25);
			double u;
			double u2;
			double u3;
			if (同角)
			{
				u = num;
				u2 = num2;
				u3 = num3;
			}
			else
			{
				u = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
				u2 = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
				u3 = Cha.角度ムラ(OthN.XS.NextSign(), 0.0, OthN.XS.NextSign(), 0.25);
			}
			Cha.翼獣左_0(i1, n, num, num2, num3);
			Cha.翼獣右_0(i2, n, u, u2, u3);
		}

		public static void 翼獣左_0(this Cha c, int i, int n, double u1, double u2, double u3)
		{
			switch (i)
			{
			case 0:
				c.翼獣_脱力左(n, u1, u2, u3);
				return;
			case 1:
				c.翼獣_強張り左(n, u1, u2, u3);
				return;
			case 2:
				c.翼獣_恥じらい左(n, u1, u2, u3);
				return;
			case 3:
				c.翼獣_顔隠し左(n, u1, u2, u3);
				return;
			case 4:
				c.翼獣_閉じ左(n, u1, u2, u3);
				return;
			case 5:
				c.翼獣_半開き左(n, u1, u2, u3);
				return;
			case 6:
				c.翼獣_全開左(n, u1, u2, u3);
				return;
			default:
				return;
			}
		}

		public static void 翼獣右_0(this Cha c, int i, int n, double u1, double u2, double u3)
		{
			switch (i)
			{
			case 0:
				c.翼獣_脱力右(n, u1, u2, u3);
				return;
			case 1:
				c.翼獣_強張り右(n, u1, u2, u3);
				return;
			case 2:
				c.翼獣_恥じらい右(n, u1, u2, u3);
				return;
			case 3:
				c.翼獣_顔隠し右(n, u1, u2, u3);
				return;
			case 4:
				c.翼獣_閉じ右(n, u1, u2, u3);
				return;
			case 5:
				c.翼獣_半開き右(n, u1, u2, u3);
				return;
			case 6:
				c.翼獣_全開右(n, u1, u2, u3);
				return;
			default:
				return;
			}
		}

		public static void 鰭左(this Cha Cha, int n, double u1, double 根本角度)
		{
			鰭 鰭 = Cha.Bod.鰭左[n];
			鰭.Set角度0();
			鰭.角度B += 根本角度 + u1;
			if (鰭 is 鰭_魚 && 根本角度 < 0.0)
			{
				((鰭_魚)鰭).X0Y0_鰭1_鰭膜.AngleBase += -根本角度 * 0.5;
			}
		}

		public static void 鰭右(this Cha Cha, int n, double u1, double 根本角度)
		{
			鰭 鰭 = Cha.Bod.鰭右[n];
			鰭.Set角度0();
			鰭.角度B += -根本角度 + -u1;
			if (鰭 is 鰭_魚 && 根本角度 < 0.0)
			{
				((鰭_魚)鰭).X0Y0_鰭1_鰭膜.AngleBase += 根本角度 * 0.5;
			}
		}

		public static void 鰭_基本左(this Cha Cha, int n, double u1)
		{
			Cha.鰭左(n, 0.0, u1);
		}

		public static void 鰭_基本右(this Cha Cha, int n, double u1)
		{
			Cha.鰭右(n, 0.0, u1);
		}

		public static void 鰭_上げ左(this Cha Cha, int n, double u1)
		{
			Cha.鰭左(n, 25.0, u1);
		}

		public static void 鰭_上げ右(this Cha Cha, int n, double u1)
		{
			Cha.鰭右(n, 25.0, u1);
		}

		public static void 鰭_下げ左(this Cha Cha, int n, double u1)
		{
			Cha.鰭左(n, -25.0, u1);
		}

		public static void 鰭_下げ右(this Cha Cha, int n, double u1)
		{
			Cha.鰭右(n, -25.0, u1);
		}

		public static void 両鰭_基本(this Cha Cha, int n)
		{
			double 根本角度 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.鰭左(n, 0.0, 根本角度);
			Cha.鰭右(n, 0.0, 根本角度);
		}

		public static void 両鰭_上げ(this Cha Cha, int n)
		{
			double 根本角度 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.鰭左(n, 25.0, 根本角度);
			Cha.鰭右(n, 25.0, 根本角度);
		}

		public static void 両鰭_下げ(this Cha Cha, int n)
		{
			double 根本角度 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.鰭左(n, -25.0, 根本角度);
			Cha.鰭右(n, -25.0, 根本角度);
		}

		public static void 両鰭_0(this Cha Cha, int n, bool 同角, int i1, int i2)
		{
			double num = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u;
			if (同角)
			{
				u = num;
			}
			else
			{
				u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			}
			Cha.鰭左_0(i1, n, num);
			Cha.鰭右_0(i2, n, u);
		}

		public static void 鰭左_0(this Cha c, int i, int n, double u1)
		{
			switch (i)
			{
			case 0:
				c.鰭_基本左(n, u1);
				return;
			case 1:
				c.鰭_上げ左(n, u1);
				return;
			case 2:
				c.鰭_下げ左(n, u1);
				return;
			default:
				return;
			}
		}

		public static void 鰭右_0(this Cha c, int i, int n, double u1)
		{
			switch (i)
			{
			case 0:
				c.鰭_基本右(n, u1);
				return;
			case 1:
				c.鰭_上げ右(n, u1);
				return;
			case 2:
				c.鰭_下げ右(n, u1);
				return;
			default:
				return;
			}
		}

		public static void 鰭絶頂(this Cha Cha, double a)
		{
			foreach (鰭 鰭 in Cha.Bod.鰭左)
			{
				鰭.角度C = a * OthN.XS.NextDouble();
			}
			foreach (鰭 鰭2 in Cha.Bod.鰭右)
			{
				鰭2.角度C = -a * OthN.XS.NextDouble();
			}
		}

		public static void 葉左(this Cha Cha, int n, double u1, double 根本角度)
		{
			葉 葉 = Cha.Bod.葉左[n];
			葉.Set角度0();
			葉.角度B += 根本角度 + u1;
		}

		public static void 葉右(this Cha Cha, int n, double u1, double 根本角度)
		{
			葉 葉 = Cha.Bod.葉右[n];
			葉.Set角度0();
			葉.角度B += -根本角度 + -u1;
		}

		public static void 葉_基本左(this Cha Cha, int n, double u1)
		{
			Cha.葉左(n, 0.0, u1);
		}

		public static void 葉_基本右(this Cha Cha, int n, double u1)
		{
			Cha.葉右(n, 0.0, u1);
		}

		public static void 葉_上げ左(this Cha Cha, int n, double u1)
		{
			Cha.葉左(n, 25.0, u1);
		}

		public static void 葉_上げ右(this Cha Cha, int n, double u1)
		{
			Cha.葉右(n, 25.0, u1);
		}

		public static void 葉_下げ左(this Cha Cha, int n, double u1)
		{
			Cha.葉左(n, -25.0, u1);
		}

		public static void 葉_下げ右(this Cha Cha, int n, double u1)
		{
			Cha.葉右(n, -25.0, u1);
		}

		public static void 両葉_基本(this Cha Cha, int n)
		{
			double 根本角度 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.葉左(n, 0.0, 根本角度);
			Cha.葉右(n, 0.0, 根本角度);
		}

		public static void 両葉_上げ(this Cha Cha, int n)
		{
			double 根本角度 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.葉左(n, 25.0, 根本角度);
			Cha.葉右(n, 25.0, 根本角度);
		}

		public static void 両葉_下げ(this Cha Cha, int n)
		{
			double 根本角度 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.葉左(n, -25.0, 根本角度);
			Cha.葉右(n, -25.0, 根本角度);
		}

		public static void 両葉_0(this Cha Cha, int n, bool 同角, int i1, int i2)
		{
			double num = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u;
			if (同角)
			{
				u = num;
			}
			else
			{
				u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			}
			Cha.葉左_0(i1, n, num);
			Cha.葉右_0(i2, n, u);
		}

		public static void 葉左_0(this Cha c, int i, int n, double u1)
		{
			switch (i)
			{
			case 0:
				c.葉_基本左(n, u1);
				return;
			case 1:
				c.葉_上げ左(n, u1);
				return;
			case 2:
				c.葉_下げ左(n, u1);
				return;
			default:
				return;
			}
		}

		public static void 葉右_0(this Cha c, int i, int n, double u1)
		{
			switch (i)
			{
			case 0:
				c.葉_基本右(n, u1);
				return;
			case 1:
				c.葉_上げ右(n, u1);
				return;
			case 2:
				c.葉_下げ右(n, u1);
				return;
			default:
				return;
			}
		}

		public static void 葉絶頂(this Cha Cha, double a)
		{
			foreach (葉 葉 in Cha.Bod.葉左)
			{
				葉.角度C = a * OthN.XS.NextDouble();
			}
			foreach (葉 葉2 in Cha.Bod.葉右)
			{
				葉2.角度C = -a * OthN.XS.NextDouble();
			}
		}

		public static void 前翅1左(this Cha Cha, int n, double u1, double 根本角度)
		{
			前翅 前翅 = Cha.Bod.前翅1左[n];
			前翅.Set角度0();
			前翅.角度B += 根本角度 + u1;
		}

		public static void 前翅1右(this Cha Cha, int n, double u1, double 根本角度)
		{
			前翅 前翅 = Cha.Bod.前翅1右[n];
			前翅.Set角度0();
			前翅.角度B += -根本角度 + -u1;
		}

		public static void 前翅1_基本左(this Cha Cha, int n, double u1)
		{
			Cha.前翅1左(n, 0.0, u1);
		}

		public static void 前翅1_基本右(this Cha Cha, int n, double u1)
		{
			Cha.前翅1右(n, 0.0, u1);
		}

		public static void 前翅1_上げ左(this Cha Cha, int n, double u1)
		{
			Cha.前翅1左(n, 15.0, u1);
		}

		public static void 前翅1_上げ右(this Cha Cha, int n, double u1)
		{
			Cha.前翅1右(n, 15.0, u1);
		}

		public static void 前翅1_下げ左(this Cha Cha, int n, double u1)
		{
			Cha.前翅1左(n, -15.0, u1);
		}

		public static void 前翅1_下げ右(this Cha Cha, int n, double u1)
		{
			Cha.前翅1右(n, -15.0, u1);
		}

		public static void 両前翅1_基本(this Cha Cha, int n)
		{
			double 根本角度 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.前翅1左(n, 0.0, 根本角度);
			Cha.前翅1右(n, 0.0, 根本角度);
		}

		public static void 両前翅1_上げ(this Cha Cha, int n)
		{
			double 根本角度 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.前翅1左(n, 15.0, 根本角度);
			Cha.前翅1右(n, 15.0, 根本角度);
		}

		public static void 両前翅1_下げ(this Cha Cha, int n)
		{
			double 根本角度 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.前翅1左(n, -15.0, 根本角度);
			Cha.前翅1右(n, -15.0, 根本角度);
		}

		public static void 両前翅_0(this Cha Cha, int n, bool 同角, int i1, int i2)
		{
			double num = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u;
			if (同角)
			{
				u = num;
			}
			else
			{
				u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			}
			Cha.前翅左_0(i1, n, num);
			Cha.前翅右_0(i2, n, u);
		}

		public static void 前翅左_0(this Cha c, int i, int n, double u1)
		{
			switch (i)
			{
			case 0:
				c.前翅1_基本左(n, u1);
				return;
			case 1:
				c.前翅1_上げ左(n, u1);
				return;
			case 2:
				c.前翅1_下げ左(n, u1);
				return;
			default:
				return;
			}
		}

		public static void 前翅右_0(this Cha c, int i, int n, double u1)
		{
			switch (i)
			{
			case 0:
				c.前翅1_基本右(n, u1);
				return;
			case 1:
				c.前翅1_上げ右(n, u1);
				return;
			case 2:
				c.前翅1_下げ右(n, u1);
				return;
			default:
				return;
			}
		}

		public static void 前翅絶頂(this Cha Cha, double a)
		{
			foreach (前翅 前翅 in Cha.Bod.前翅1左)
			{
				前翅.角度C = a * OthN.XS.NextDouble();
			}
			foreach (前翅 前翅2 in Cha.Bod.前翅1右)
			{
				前翅2.角度C = -a * OthN.XS.NextDouble();
			}
		}

		public static void 前翅2左(this Cha Cha, int n, double 展開)
		{
			前翅 前翅 = Cha.Bod.前翅2左[n];
			if (前翅 is 前翅_甲)
			{
				if (展開 != 0.5)
				{
					前翅.Set角度0();
					((前翅_甲)前翅).展開 = 展開;
					return;
				}
			}
			else if (前翅 is 前翅_草)
			{
				前翅.Set角度0();
				((前翅_草)前翅).展開 = 展開;
			}
		}

		public static void 前翅2右(this Cha Cha, int n, double 展開)
		{
			前翅 前翅 = Cha.Bod.前翅2右[n];
			if (前翅 is 前翅_甲)
			{
				if (展開 != 0.5)
				{
					前翅.Set角度0();
					((前翅_甲)前翅).展開 = 展開;
					return;
				}
			}
			else if (前翅 is 前翅_草)
			{
				前翅.Set角度0();
				((前翅_草)前翅).展開 = 展開;
			}
		}

		public static void 前翅2_基本左(this Cha Cha, int n)
		{
			Cha.前翅2左(n, 0.0);
		}

		public static void 前翅2_基本右(this Cha Cha, int n)
		{
			Cha.前翅2右(n, 0.0);
		}

		public static void 前翅2_半開左(this Cha Cha, int n)
		{
			Cha.前翅2左(n, 0.5);
		}

		public static void 前翅2_半開右(this Cha Cha, int n)
		{
			Cha.前翅2右(n, 0.5);
		}

		public static void 前翅2_全開左(this Cha Cha, int n)
		{
			Cha.前翅2左(n, 1.0);
		}

		public static void 前翅2_全開右(this Cha Cha, int n)
		{
			Cha.前翅2右(n, 1.0);
		}

		public static void 両前翅2_基本(this Cha Cha, int n)
		{
			Cha.前翅2左(n, 0.0);
			Cha.前翅2右(n, 0.0);
		}

		public static void 両前翅2_半開(this Cha Cha, int n)
		{
			Cha.前翅2左(n, 0.5);
			Cha.前翅2右(n, 0.5);
		}

		public static void 両前翅2_全開(this Cha Cha, int n)
		{
			Cha.前翅2左(n, 1.0);
			Cha.前翅2右(n, 1.0);
		}

		public static void 両前翅_1(this Cha Cha, int n, int i1, int i2)
		{
			Cha.前翅左_1(i1, n);
			Cha.前翅右_1(i2, n);
		}

		public static void 前翅左_1(this Cha c, int i, int n)
		{
			switch (i)
			{
			case 0:
				c.前翅2_基本左(n);
				return;
			case 1:
				c.前翅2_半開左(n);
				return;
			case 2:
				c.前翅2_全開左(n);
				return;
			default:
				return;
			}
		}

		public static void 前翅右_1(this Cha c, int i, int n)
		{
			switch (i)
			{
			case 0:
				c.前翅2_基本右(n);
				return;
			case 1:
				c.前翅2_半開右(n);
				return;
			case 2:
				c.前翅2_全開右(n);
				return;
			default:
				return;
			}
		}

		public static void 後翅1左(this Cha Cha, int n, double u1, double 根本角度)
		{
			後翅 後翅 = Cha.Bod.後翅1左[n];
			後翅.Set角度0();
			後翅.角度B += 根本角度 + u1;
		}

		public static void 後翅1右(this Cha Cha, int n, double u1, double 根本角度)
		{
			後翅 後翅 = Cha.Bod.後翅1右[n];
			後翅.Set角度0();
			後翅.角度B += -根本角度 + -u1;
		}

		public static void 後翅1_基本左(this Cha Cha, int n, double u1)
		{
			Cha.後翅1左(n, 0.0, u1);
		}

		public static void 後翅1_基本右(this Cha Cha, int n, double u1)
		{
			Cha.後翅1右(n, 0.0, u1);
		}

		public static void 後翅1_上げ左(this Cha Cha, int n, double u1)
		{
			Cha.後翅1左(n, 15.0, u1);
		}

		public static void 後翅1_上げ右(this Cha Cha, int n, double u1)
		{
			Cha.後翅1右(n, 15.0, u1);
		}

		public static void 後翅1_下げ左(this Cha Cha, int n, double u1)
		{
			Cha.後翅1左(n, -15.0, u1);
		}

		public static void 後翅1_下げ右(this Cha Cha, int n, double u1)
		{
			Cha.後翅1右(n, -15.0, u1);
		}

		public static void 両後翅1_基本(this Cha Cha, int n)
		{
			double 根本角度 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.後翅1左(n, 0.0, 根本角度);
			Cha.後翅1右(n, 0.0, 根本角度);
		}

		public static void 両後翅1_上げ(this Cha Cha, int n)
		{
			double 根本角度 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.後翅1左(n, 15.0, 根本角度);
			Cha.後翅1右(n, 15.0, 根本角度);
		}

		public static void 両後翅1_下げ(this Cha Cha, int n)
		{
			double 根本角度 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.後翅1左(n, -15.0, 根本角度);
			Cha.後翅1右(n, -15.0, 根本角度);
		}

		public static void 両後翅_0(this Cha Cha, int n, bool 同角, int i1, int i2)
		{
			double num = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u;
			if (同角)
			{
				u = num;
			}
			else
			{
				u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			}
			Cha.後翅左_0(i1, n, num);
			Cha.後翅右_0(i2, n, u);
		}

		public static void 後翅左_0(this Cha c, int i, int n, double u1)
		{
			switch (i)
			{
			case 0:
				c.後翅1_基本左(n, u1);
				return;
			case 1:
				c.後翅1_上げ左(n, u1);
				return;
			case 2:
				c.後翅1_下げ左(n, u1);
				return;
			default:
				return;
			}
		}

		public static void 後翅右_0(this Cha c, int i, int n, double u1)
		{
			switch (i)
			{
			case 0:
				c.後翅1_基本右(n, u1);
				return;
			case 1:
				c.後翅1_上げ右(n, u1);
				return;
			case 2:
				c.後翅1_下げ右(n, u1);
				return;
			default:
				return;
			}
		}

		public static void 後翅絶頂(this Cha Cha, double a)
		{
			foreach (後翅 後翅 in Cha.Bod.後翅1左)
			{
				後翅.角度C = a * OthN.XS.NextDouble();
			}
			foreach (後翅 後翅2 in Cha.Bod.後翅1右)
			{
				後翅2.角度C = -a * OthN.XS.NextDouble();
			}
		}

		public static void 後翅2左(this Cha Cha, int n, double 展開)
		{
			後翅 後翅 = Cha.Bod.後翅2左[n];
			if (後翅 is 後翅_甲)
			{
				if (展開 != 0.5)
				{
					後翅.Set角度0();
					((後翅_甲)後翅).展開 = 展開;
					return;
				}
			}
			else if (後翅 is 後翅_草)
			{
				後翅.Set角度0();
				((後翅_草)後翅).展開 = 展開;
			}
		}

		public static void 後翅2右(this Cha Cha, int n, double 展開)
		{
			後翅 後翅 = Cha.Bod.後翅2右[n];
			if (後翅 is 後翅_甲)
			{
				if (展開 != 0.5)
				{
					後翅.Set角度0();
					((後翅_甲)後翅).展開 = 展開;
					return;
				}
			}
			else if (後翅 is 後翅_草)
			{
				後翅.Set角度0();
				((後翅_草)後翅).展開 = 展開;
			}
		}

		public static void 後翅2_基本左(this Cha Cha, int n)
		{
			Cha.後翅2左(n, 0.0);
		}

		public static void 後翅2_基本右(this Cha Cha, int n)
		{
			Cha.後翅2右(n, 0.0);
		}

		public static void 後翅2_半開左(this Cha Cha, int n)
		{
			Cha.後翅2左(n, 0.5);
		}

		public static void 後翅2_半開右(this Cha Cha, int n)
		{
			Cha.後翅2右(n, 0.5);
		}

		public static void 後翅2_全開左(this Cha Cha, int n)
		{
			Cha.後翅2左(n, 1.0);
		}

		public static void 後翅2_全開右(this Cha Cha, int n)
		{
			Cha.後翅2右(n, 1.0);
		}

		public static void 両後翅2_基本(this Cha Cha, int n)
		{
			Cha.後翅2_基本左(n);
			Cha.後翅2_基本右(n);
		}

		public static void 両後翅2_半開(this Cha Cha, int n)
		{
			Cha.後翅2_半開左(n);
			Cha.後翅2_半開右(n);
		}

		public static void 両後翅2_全開(this Cha Cha, int n)
		{
			Cha.後翅2_全開左(n);
			Cha.後翅2_全開右(n);
		}

		public static void 両後翅_1(this Cha Cha, int n, int i1, int i2)
		{
			Cha.後翅左_1(i1, n);
			Cha.後翅右_1(i2, n);
		}

		public static void 後翅左_1(this Cha c, int i, int n)
		{
			switch (i)
			{
			case 0:
				c.後翅2_基本左(n);
				return;
			case 1:
				c.後翅2_半開左(n);
				return;
			case 2:
				c.後翅2_全開左(n);
				return;
			default:
				return;
			}
		}

		public static void 後翅右_1(this Cha c, int i, int n)
		{
			switch (i)
			{
			case 0:
				c.後翅2_基本右(n);
				return;
			case 1:
				c.後翅2_半開右(n);
				return;
			case 2:
				c.後翅2_全開右(n);
				return;
			default:
				return;
			}
		}

		public static void 触肢蜘左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double 基節角度, double 転節角度, double 腿節角度, double 膝節角度, double 脛節角度, double 蹠節角度)
		{
			触肢_肢蜘 触肢_肢蜘 = Cha.Bod.触肢蜘左[n];
			触肢_肢蜘.Set角度0();
			触肢_肢蜘.X0Y0_基節.AngleBase += 基節角度 + u1;
			触肢_肢蜘.X0Y0_転節.AngleBase += 転節角度 + u2;
			触肢_肢蜘.X0Y0_腿節.AngleBase += 腿節角度 + u3;
			触肢_肢蜘.X0Y0_膝節.AngleBase += 膝節角度 + u4;
			触肢_肢蜘.X0Y0_脛節.AngleBase += 脛節角度 + u5;
			触肢_肢蜘.X0Y0_蹠節.AngleBase += 蹠節角度 + u6;
		}

		public static void 触肢蜘右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double 基節角度, double 転節角度, double 腿節角度, double 膝節角度, double 脛節角度, double 蹠節角度)
		{
			触肢_肢蜘 触肢_肢蜘 = Cha.Bod.触肢蜘右[n];
			触肢_肢蜘.Set角度0();
			触肢_肢蜘.X0Y0_基節.AngleBase += -基節角度 + -u1;
			触肢_肢蜘.X0Y0_転節.AngleBase += -転節角度 + -u2;
			触肢_肢蜘.X0Y0_腿節.AngleBase += -腿節角度 + -u3;
			触肢_肢蜘.X0Y0_膝節.AngleBase += -膝節角度 + -u4;
			触肢_肢蜘.X0Y0_脛節.AngleBase += -脛節角度 + -u5;
			触肢_肢蜘.X0Y0_蹠節.AngleBase += -蹠節角度 + -u6;
		}

		public static void 触肢蜘_基本左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6)
		{
			Cha.触肢蜘左(n, u1, u2, u3, u4, u5, u6, -30.0, 0.0, 0.0, -45.0, 0.0, 30.0);
		}

		public static void 触肢蜘_基本右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6)
		{
			Cha.触肢蜘右(n, u1, u2, u3, u4, u5, u6, -30.0, 0.0, 0.0, -45.0, 0.0, 30.0);
		}

		public static void 触肢蜘_萎縮左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6)
		{
			Cha.触肢蜘左(n, u1, u2, u3, u4, u5, u6, -10.0, 0.0, 0.0, -8.0, 0.0, 25.0);
		}

		public static void 触肢蜘_萎縮右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6)
		{
			Cha.触肢蜘右(n, u1, u2, u3, u4, u5, u6, -10.0, 0.0, 0.0, -8.0, 0.0, 25.0);
		}

		public static void 触肢蜘_開く左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6)
		{
			Cha.触肢蜘左(n, u1, u2, u3, u4, u5, u6, -40.0, 0.0, 0.0, -100.0, 0.0, -30.0);
		}

		public static void 触肢蜘_開く右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6)
		{
			Cha.触肢蜘右(n, u1, u2, u3, u4, u5, u6, -40.0, 0.0, 0.0, -100.0, 0.0, -30.0);
		}

		public static void 両触肢蜘_基本(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u5 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u6 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.触肢蜘_基本左(n, u, u2, u3, u4, u5, u6);
			Cha.触肢蜘_基本右(n, u, u2, u3, u4, u5, u6);
		}

		public static void 両触肢蜘_萎縮(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u5 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u6 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.触肢蜘_萎縮左(n, u, u2, u3, u4, u5, u6);
			Cha.触肢蜘_萎縮右(n, u, u2, u3, u4, u5, u6);
		}

		public static void 両触肢蜘_開く(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u5 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u6 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.触肢蜘_開く左(n, u, u2, u3, u4, u5, u6);
			Cha.触肢蜘_開く右(n, u, u2, u3, u4, u5, u6);
		}

		public static void 両触肢蜘_0(this Cha Cha, int n, bool 同角, int i1, int i2)
		{
			double num = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double num2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double num3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double num4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3;
			double u4;
			double u5;
			double u6;
			if (同角)
			{
				u3 = num;
				u4 = num2;
				u5 = num3;
				u6 = num4;
			}
			else
			{
				u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				u5 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				u6 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			}
			Cha.触肢蜘左_0(i1, n, num, num2, num3, num4, u, u2);
			Cha.触肢蜘右_0(i2, n, u3, u4, u5, u6, u, u2);
		}

		public static void 触肢蜘左_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4, double u5, double u6)
		{
			switch (i)
			{
			case 0:
				c.触肢蜘_基本左(n, u1, u2, u3, u4, u5, u6);
				return;
			case 1:
				c.触肢蜘_萎縮左(n, u1, u2, u3, u4, u5, u6);
				return;
			case 2:
				c.触肢蜘_開く左(n, u1, u2, u3, u4, u5, u6);
				return;
			default:
				return;
			}
		}

		public static void 触肢蜘右_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4, double u5, double u6)
		{
			switch (i)
			{
			case 0:
				c.触肢蜘_基本右(n, u1, u2, u3, u4, u5, u6);
				return;
			case 1:
				c.触肢蜘_萎縮右(n, u1, u2, u3, u4, u5, u6);
				return;
			case 2:
				c.触肢蜘_開く右(n, u1, u2, u3, u4, u5, u6);
				return;
			default:
				return;
			}
		}

		public static void 触肢蜘絶頂(this Cha Cha, double a)
		{
			foreach (触肢_肢蜘 触肢_肢蜘 in Cha.Bod.触肢蜘左)
			{
				触肢_肢蜘.X0Y0_基節.AngleCont = a * OthN.XS.NextDouble();
				触肢_肢蜘.X0Y0_転節.AngleCont = a * OthN.XS.NextDouble();
				触肢_肢蜘.X0Y0_腿節.AngleCont = a * OthN.XS.NextDouble();
				触肢_肢蜘.X0Y0_膝節.AngleCont = a * OthN.XS.NextDouble();
				触肢_肢蜘.X0Y0_脛節.AngleCont = a * OthN.XS.NextDouble();
				触肢_肢蜘.X0Y0_蹠節.AngleCont = a * OthN.XS.NextDouble();
			}
			foreach (触肢_肢蜘 触肢_肢蜘2 in Cha.Bod.触肢蜘右)
			{
				触肢_肢蜘2.X0Y0_基節.AngleCont = -a * OthN.XS.NextDouble();
				触肢_肢蜘2.X0Y0_転節.AngleCont = -a * OthN.XS.NextDouble();
				触肢_肢蜘2.X0Y0_腿節.AngleCont = -a * OthN.XS.NextDouble();
				触肢_肢蜘2.X0Y0_膝節.AngleCont = -a * OthN.XS.NextDouble();
				触肢_肢蜘2.X0Y0_脛節.AngleCont = -a * OthN.XS.NextDouble();
				触肢_肢蜘2.X0Y0_蹠節.AngleCont = -a * OthN.XS.NextDouble();
			}
		}

		public static void 触肢蠍左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double 転節角度, double 腿節角度, double 膝節角度, double 爪1角度, double 爪2角度)
		{
			触肢_肢蠍 触肢_肢蠍 = Cha.Bod.触肢蠍左[n];
			触肢_肢蠍.Set角度0();
			触肢_肢蠍.X0Y0_転節.AngleBase += 転節角度 + u1;
			触肢_肢蠍.X0Y0_腿節.AngleBase += 腿節角度 + u2;
			触肢_肢蠍.X0Y0_膝節.AngleBase += 膝節角度 + u3;
			触肢_肢蠍.X0Y0_爪1.AngleBase += 爪1角度 + u4;
			if (触肢_肢蠍.拘束)
			{
				触肢_肢蠍.X0Y0_爪2.AngleBase = 0.0;
				return;
			}
			触肢_肢蠍.X0Y0_爪2.AngleBase += 爪2角度 + u5;
		}

		public static void 触肢蠍右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double 転節角度, double 腿節角度, double 膝節角度, double 爪1角度, double 爪2角度)
		{
			触肢_肢蠍 触肢_肢蠍 = Cha.Bod.触肢蠍右[n];
			触肢_肢蠍.Set角度0();
			触肢_肢蠍.X0Y0_転節.AngleBase += -転節角度 + -u1;
			触肢_肢蠍.X0Y0_腿節.AngleBase += -腿節角度 + -u2;
			触肢_肢蠍.X0Y0_膝節.AngleBase += -膝節角度 + -u3;
			触肢_肢蠍.X0Y0_爪1.AngleBase += -爪1角度 + -u4;
			if (触肢_肢蠍.拘束)
			{
				触肢_肢蠍.X0Y0_爪2.AngleBase = 0.0;
				return;
			}
			触肢_肢蠍.X0Y0_爪2.AngleBase += -爪2角度 + -u5;
		}

		public static void 触肢蠍_基本左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6)
		{
			Cha.触肢蠍左(n, u1, u2, u3, u4, u5, 0.0, 0.0, -5.0, 20.0, 10.0);
		}

		public static void 触肢蠍_基本右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6)
		{
			Cha.触肢蠍右(n, u1, u2, u3, u4, u5, 0.0, 0.0, -5.0, 20.0, 10.0);
		}

		public static void 触肢蠍_萎縮左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6)
		{
			Cha.触肢蠍左(n, u1, u2, u3, u4, u5, -25.0, 5.0, 5.0, 35.0, 15.0);
		}

		public static void 触肢蠍_萎縮右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6)
		{
			Cha.触肢蠍右(n, u1, u2, u3, u4, u5, -25.0, 5.0, 5.0, 35.0, 15.0);
		}

		public static void 触肢蠍_開く左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6)
		{
			Cha.触肢蠍左(n, u1, u2, u3, u4, u5, 10.0, -5.0, -20.0, -5.0, -10.0);
		}

		public static void 触肢蠍_開く右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6)
		{
			Cha.触肢蠍右(n, u1, u2, u3, u4, u5, 10.0, -5.0, -20.0, -5.0, -10.0);
		}

		public static void 両触肢蠍_基本(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u5 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u6 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.触肢蠍_基本左(n, u, u2, u3, u4, u5, u6);
			Cha.触肢蠍_基本右(n, u, u2, u3, u4, u5, u6);
		}

		public static void 両触肢蠍_萎縮(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u5 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u6 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.触肢蠍_萎縮左(n, u, u2, u3, u4, u5, u6);
			Cha.触肢蠍_萎縮右(n, u, u2, u3, u4, u5, u6);
		}

		public static void 両触肢蠍_開く(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u5 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u6 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.触肢蠍_開く左(n, u, u2, u3, u4, u5, u6);
			Cha.触肢蠍_開く右(n, u, u2, u3, u4, u5, u6);
		}

		public static void 両触肢蠍_0(this Cha Cha, int n, bool 同角, int i1, int i2)
		{
			double num = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double num2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double num3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double num4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3;
			double u4;
			double u5;
			double u6;
			if (同角)
			{
				u3 = num;
				u4 = num2;
				u5 = num3;
				u6 = num4;
			}
			else
			{
				u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				u5 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				u6 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			}
			Cha.触肢蠍左_0(i1, n, num, num2, num3, num4, u, u2);
			Cha.触肢蠍右_0(i2, n, u3, u4, u5, u6, u, u2);
		}

		public static void 触肢蠍左_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4, double u5, double u6)
		{
			switch (i)
			{
			case 0:
				c.触肢蠍_基本左(n, u1, u2, u3, u4, u5, u6);
				return;
			case 1:
				c.触肢蠍_萎縮左(n, u1, u2, u3, u4, u5, u6);
				return;
			case 2:
				c.触肢蠍_開く左(n, u1, u2, u3, u4, u5, u6);
				return;
			default:
				return;
			}
		}

		public static void 触肢蠍右_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4, double u5, double u6)
		{
			switch (i)
			{
			case 0:
				c.触肢蠍_基本右(n, u1, u2, u3, u4, u5, u6);
				return;
			case 1:
				c.触肢蠍_萎縮右(n, u1, u2, u3, u4, u5, u6);
				return;
			case 2:
				c.触肢蠍_開く右(n, u1, u2, u3, u4, u5, u6);
				return;
			default:
				return;
			}
		}

		public static void 触肢蠍絶頂(this Cha Cha, double a)
		{
			foreach (触肢_肢蠍 触肢_肢蠍 in Cha.Bod.触肢蠍左)
			{
				触肢_肢蠍.X0Y0_転節.AngleCont = a * OthN.XS.NextDouble();
				触肢_肢蠍.X0Y0_腿節.AngleCont = a * OthN.XS.NextDouble();
				触肢_肢蠍.X0Y0_膝節.AngleCont = a * OthN.XS.NextDouble();
				触肢_肢蠍.X0Y0_爪1.AngleCont = a * OthN.XS.NextDouble();
				if (!触肢_肢蠍.拘束)
				{
					触肢_肢蠍.X0Y0_爪2.AngleCont = a * OthN.XS.NextDouble();
				}
			}
			foreach (触肢_肢蠍 触肢_肢蠍2 in Cha.Bod.触肢蠍右)
			{
				触肢_肢蠍2.X0Y0_転節.AngleCont = -a * OthN.XS.NextDouble();
				触肢_肢蠍2.X0Y0_腿節.AngleCont = -a * OthN.XS.NextDouble();
				触肢_肢蠍2.X0Y0_膝節.AngleCont = -a * OthN.XS.NextDouble();
				触肢_肢蠍2.X0Y0_爪1.AngleCont = -a * OthN.XS.NextDouble();
				if (!触肢_肢蠍2.拘束)
				{
					触肢_肢蠍2.X0Y0_爪2.AngleCont = -a * OthN.XS.NextDouble();
				}
			}
		}

		public static void 節足蜘左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8, double 基節角度, double 転節角度, double 腿節角度, double 膝節角度, double 脛節角度, double 蹠節角度, double 跗節1角度, double 跗節2角度)
		{
			節足_足蜘 節足_足蜘 = Cha.Bod.節足蜘左[n];
			節足_足蜘.Set角度0();
			switch (節足_足蜘.接続情報)
			{
			case 接続情報.多足_蜘_節足左1_接続:
				節足_足蜘.角度B += 0.0;
				break;
			case 接続情報.多足_蜘_節足左2_接続:
				節足_足蜘.角度B += -20.0;
				break;
			case 接続情報.多足_蜘_節足左3_接続:
				節足_足蜘.角度B += -40.0;
				break;
			case 接続情報.多足_蜘_節足左4_接続:
				節足_足蜘.角度B += -60.0;
				break;
			}
			if (節足_足蜘.反転Y)
			{
				節足_足蜘.X0Y0_基節.AngleBase += -基節角度 + -u1;
				節足_足蜘.X0Y0_転節.AngleBase += -転節角度 + -u2;
				節足_足蜘.X0Y0_腿節.AngleBase += -腿節角度 + -u3;
				節足_足蜘.X0Y0_膝節.AngleBase += -膝節角度 + -u4;
				節足_足蜘.X0Y0_脛節.AngleBase += -脛節角度 + -u5;
				節足_足蜘.X0Y0_蹠節.AngleBase += -蹠節角度 + -u6;
				節足_足蜘.X0Y0_跗節1.AngleBase += -跗節1角度 + -u7;
				節足_足蜘.X0Y0_跗節2.AngleBase += -跗節2角度 + -u8;
				return;
			}
			節足_足蜘.X0Y0_基節.AngleBase += 基節角度 + u1;
			節足_足蜘.X0Y0_転節.AngleBase += 転節角度 + u2;
			節足_足蜘.X0Y0_腿節.AngleBase += 腿節角度 + u3;
			節足_足蜘.X0Y0_膝節.AngleBase += 膝節角度 + u4;
			節足_足蜘.X0Y0_脛節.AngleBase += 脛節角度 + u5;
			節足_足蜘.X0Y0_蹠節.AngleBase += 蹠節角度 + u6;
			節足_足蜘.X0Y0_跗節1.AngleBase += 跗節1角度 + u7;
			節足_足蜘.X0Y0_跗節2.AngleBase += 跗節2角度 + u8;
		}

		public static void 節足蜘右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8, double 基節角度, double 転節角度, double 腿節角度, double 膝節角度, double 脛節角度, double 蹠節角度, double 跗節1角度, double 跗節2角度)
		{
			節足_足蜘 節足_足蜘 = Cha.Bod.節足蜘右[n];
			節足_足蜘.Set角度0();
			switch (節足_足蜘.接続情報)
			{
			case 接続情報.多足_蜘_節足右1_接続:
				節足_足蜘.角度B += 0.0;
				break;
			case 接続情報.多足_蜘_節足右2_接続:
				節足_足蜘.角度B += 20.0;
				break;
			case 接続情報.多足_蜘_節足右3_接続:
				節足_足蜘.角度B += 40.0;
				break;
			case 接続情報.多足_蜘_節足右4_接続:
				節足_足蜘.角度B += 60.0;
				break;
			}
			if (節足_足蜘.反転Y)
			{
				節足_足蜘.X0Y0_基節.AngleBase += 基節角度 + u1;
				節足_足蜘.X0Y0_転節.AngleBase += 転節角度 + u2;
				節足_足蜘.X0Y0_腿節.AngleBase += 腿節角度 + u3;
				節足_足蜘.X0Y0_膝節.AngleBase += 膝節角度 + u4;
				節足_足蜘.X0Y0_脛節.AngleBase += 脛節角度 + u5;
				節足_足蜘.X0Y0_蹠節.AngleBase += 蹠節角度 + u6;
				節足_足蜘.X0Y0_跗節1.AngleBase += 跗節1角度 + u7;
				節足_足蜘.X0Y0_跗節2.AngleBase += 跗節2角度 + u8;
				return;
			}
			節足_足蜘.X0Y0_基節.AngleBase += -基節角度 + -u1;
			節足_足蜘.X0Y0_転節.AngleBase += -転節角度 + -u2;
			節足_足蜘.X0Y0_腿節.AngleBase += -腿節角度 + -u3;
			節足_足蜘.X0Y0_膝節.AngleBase += -膝節角度 + -u4;
			節足_足蜘.X0Y0_脛節.AngleBase += -脛節角度 + -u5;
			節足_足蜘.X0Y0_蹠節.AngleBase += -蹠節角度 + -u6;
			節足_足蜘.X0Y0_跗節1.AngleBase += -跗節1角度 + -u7;
			節足_足蜘.X0Y0_跗節2.AngleBase += -跗節2角度 + -u8;
		}

		public static void 節足蜘_基本左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
		{
			Cha.節足蜘左(n, u1, u2, u3, u4, u5, u6, u7, u8, 0.0, 0.0, 0.0, 15.0, 0.0, 0.0, 0.0, 0.0);
		}

		public static void 節足蜘_基本右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
		{
			Cha.節足蜘右(n, u1, u2, u3, u4, u5, u6, u7, u8, 0.0, 0.0, 0.0, 15.0, 0.0, 0.0, 0.0, 0.0);
		}

		public static void 節足蜘_萎縮左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
		{
			Cha.節足蜘左(n, u1, u2, u3, u4, u5, u6, u7, u8, 0.0, 0.0, 0.0, 45.0, -15.0, 45.0, 0.0, 0.0);
		}

		public static void 節足蜘_萎縮右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
		{
			Cha.節足蜘右(n, u1, u2, u3, u4, u5, u6, u7, u8, 0.0, 0.0, 0.0, 45.0, -15.0, 45.0, 0.0, 0.0);
		}

		public static void 節足蜘_開く左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
		{
			Cha.節足蜘左(n, u1, u2, u3, u4, u5, u6, u7, u8, 20.0, 0.0, 0.0, -25.0, 0.0, 0.0, 0.0, 0.0);
		}

		public static void 節足蜘_開く右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
		{
			Cha.節足蜘右(n, u1, u2, u3, u4, u5, u6, u7, u8, 20.0, 0.0, 0.0, -25.0, 0.0, 0.0, 0.0, 0.0);
		}

		public static void 両節足蜘_基本(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u5 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u6 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u7 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u8 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.節足蜘_基本左(n, u, u2, u3, u4, u5, u6, u7, u8);
			Cha.節足蜘_基本右(n, u, u2, u3, u4, u5, u6, u7, u8);
		}

		public static void 両節足蜘_萎縮(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u5 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u6 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u7 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u8 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.節足蜘_萎縮左(n, u, u2, u3, u4, u5, u6, u7, u8);
			Cha.節足蜘_萎縮右(n, u, u2, u3, u4, u5, u6, u7, u8);
		}

		public static void 両節足蜘_開く(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u5 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u6 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u7 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u8 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.節足蜘_開く左(n, u, u2, u3, u4, u5, u6, u7, u8);
			Cha.節足蜘_開く右(n, u, u2, u3, u4, u5, u6, u7, u8);
		}

		public static void 両節足蜘_0(this Cha Cha, int n, bool 同角, int i1, int i2)
		{
			double num = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double num2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double num3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double num4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u5;
			double u6;
			double u7;
			double u8;
			if (同角)
			{
				u5 = num;
				u6 = num2;
				u7 = num3;
				u8 = num4;
			}
			else
			{
				u5 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				u6 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				u7 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				u8 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			}
			Cha.節足蜘左_0(i1, n, num, num2, num3, num4, u, u2, u3, u4);
			Cha.節足蜘右_0(i2, n, u5, u6, u7, u8, u, u2, u3, u4);
		}

		public static void 節足蜘左_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
		{
			switch (i)
			{
			case 0:
				c.節足蜘_基本左(n, u1, u2, u3, u4, u5, u6, u7, u8);
				return;
			case 1:
				c.節足蜘_萎縮左(n, u1, u2, u3, u4, u5, u6, u7, u8);
				return;
			case 2:
				c.節足蜘_開く左(n, u1, u2, u3, u4, u5, u6, u7, u8);
				return;
			default:
				return;
			}
		}

		public static void 節足蜘右_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
		{
			switch (i)
			{
			case 0:
				c.節足蜘_基本右(n, u1, u2, u3, u4, u5, u6, u7, u8);
				return;
			case 1:
				c.節足蜘_萎縮右(n, u1, u2, u3, u4, u5, u6, u7, u8);
				return;
			case 2:
				c.節足蜘_開く右(n, u1, u2, u3, u4, u5, u6, u7, u8);
				return;
			default:
				return;
			}
		}

		public static void 節足蜘絶頂(this Cha Cha, double a)
		{
			foreach (節足_足蜘 節足_足蜘 in Cha.Bod.節足蜘左)
			{
				節足_足蜘.X0Y0_基節.AngleCont = a * OthN.XS.NextDouble();
				節足_足蜘.X0Y0_転節.AngleCont = a * OthN.XS.NextDouble();
				節足_足蜘.X0Y0_腿節.AngleCont = a * OthN.XS.NextDouble();
				節足_足蜘.X0Y0_膝節.AngleCont = a * OthN.XS.NextDouble();
				節足_足蜘.X0Y0_脛節.AngleCont = a * OthN.XS.NextDouble();
				節足_足蜘.X0Y0_蹠節.AngleCont = a * OthN.XS.NextDouble();
				節足_足蜘.X0Y0_跗節1.AngleCont = a * OthN.XS.NextDouble();
				節足_足蜘.X0Y0_跗節2.AngleCont = a * OthN.XS.NextDouble();
			}
			foreach (節足_足蜘 節足_足蜘2 in Cha.Bod.節足蜘右)
			{
				節足_足蜘2.X0Y0_基節.AngleCont = -a * OthN.XS.NextDouble();
				節足_足蜘2.X0Y0_転節.AngleCont = -a * OthN.XS.NextDouble();
				節足_足蜘2.X0Y0_腿節.AngleCont = -a * OthN.XS.NextDouble();
				節足_足蜘2.X0Y0_膝節.AngleCont = -a * OthN.XS.NextDouble();
				節足_足蜘2.X0Y0_脛節.AngleCont = -a * OthN.XS.NextDouble();
				節足_足蜘2.X0Y0_蹠節.AngleCont = -a * OthN.XS.NextDouble();
				節足_足蜘2.X0Y0_跗節1.AngleCont = -a * OthN.XS.NextDouble();
				節足_足蜘2.X0Y0_跗節2.AngleCont = -a * OthN.XS.NextDouble();
			}
		}

		public static void 節足蠍_蠍左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double 転節角度, double 腿節角度, double 膝節角度, double 脛節角度, double 蹠節角度, double 跗節1角度, double 跗節2角度)
		{
			節足_足蠍 節足_足蠍 = Cha.Bod.節足蠍左[n];
			節足_足蠍.Set角度0();
			switch (節足_足蠍.接続情報)
			{
			case 接続情報.多足_蠍_節足左1_接続:
				節足_足蠍.角度B += 2.0;
				break;
			case 接続情報.多足_蠍_節足左2_接続:
				節足_足蠍.角度B += 16.0;
				break;
			case 接続情報.多足_蠍_節足左3_接続:
				節足_足蠍.角度B += 26.0;
				break;
			case 接続情報.多足_蠍_節足左4_接続:
				節足_足蠍.角度B += 20.0;
				break;
			}
			if (節足_足蠍.反転Y)
			{
				節足_足蠍.X0Y0_転節.AngleBase += -転節角度 + -u1;
				節足_足蠍.X0Y0_腿節.AngleBase += -腿節角度 + -u2;
				節足_足蠍.X0Y0_膝節.AngleBase += -膝節角度 + -u3;
				節足_足蠍.X0Y0_脛節.AngleBase += -脛節角度 + -u4;
				節足_足蠍.X0Y0_蹠節.AngleBase += -蹠節角度 + -u5;
				節足_足蠍.X0Y0_跗節1.AngleBase += -跗節1角度 + -u6;
				節足_足蠍.X0Y0_跗節2.AngleBase += -跗節2角度 + -u7;
				return;
			}
			節足_足蠍.X0Y0_転節.AngleBase += 転節角度 + u1;
			節足_足蠍.X0Y0_腿節.AngleBase += 腿節角度 + u2;
			節足_足蠍.X0Y0_膝節.AngleBase += 膝節角度 + u3;
			節足_足蠍.X0Y0_脛節.AngleBase += 脛節角度 + u4;
			節足_足蠍.X0Y0_蹠節.AngleBase += 蹠節角度 + u5;
			節足_足蠍.X0Y0_跗節1.AngleBase += 跗節1角度 + u6;
			節足_足蠍.X0Y0_跗節2.AngleBase += 跗節2角度 + u7;
		}

		public static void 節足蠍_蠍右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double 転節角度, double 腿節角度, double 膝節角度, double 脛節角度, double 蹠節角度, double 跗節1角度, double 跗節2角度)
		{
			節足_足蠍 節足_足蠍 = Cha.Bod.節足蠍右[n];
			節足_足蠍.Set角度0();
			switch (節足_足蠍.接続情報)
			{
			case 接続情報.多足_蠍_節足右1_接続:
				節足_足蠍.角度B += -2.0;
				break;
			case 接続情報.多足_蠍_節足右2_接続:
				節足_足蠍.角度B += -16.0;
				break;
			case 接続情報.多足_蠍_節足右3_接続:
				節足_足蠍.角度B += -26.0;
				break;
			case 接続情報.多足_蠍_節足右4_接続:
				節足_足蠍.角度B += -20.0;
				break;
			}
			if (節足_足蠍.反転Y)
			{
				節足_足蠍.X0Y0_転節.AngleBase += 転節角度 + u1;
				節足_足蠍.X0Y0_腿節.AngleBase += 腿節角度 + u2;
				節足_足蠍.X0Y0_膝節.AngleBase += 膝節角度 + u3;
				節足_足蠍.X0Y0_脛節.AngleBase += 脛節角度 + u4;
				節足_足蠍.X0Y0_蹠節.AngleBase += 蹠節角度 + u5;
				節足_足蠍.X0Y0_跗節1.AngleBase += 跗節1角度 + u6;
				節足_足蠍.X0Y0_跗節2.AngleBase += 跗節2角度 + u7;
				return;
			}
			節足_足蠍.X0Y0_転節.AngleBase += -転節角度 + -u1;
			節足_足蠍.X0Y0_腿節.AngleBase += -腿節角度 + -u2;
			節足_足蠍.X0Y0_膝節.AngleBase += -膝節角度 + -u3;
			節足_足蠍.X0Y0_脛節.AngleBase += -脛節角度 + -u4;
			節足_足蠍.X0Y0_蹠節.AngleBase += -蹠節角度 + -u5;
			節足_足蠍.X0Y0_跗節1.AngleBase += -跗節1角度 + -u6;
			節足_足蠍.X0Y0_跗節2.AngleBase += -跗節2角度 + -u7;
		}

		public static void 節足蠍_基本左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
		{
			Cha.節足蠍_蠍左(n, u1, u2, u3, u4, u5, u6, u7, -15.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0);
		}

		public static void 節足蠍_基本右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
		{
			Cha.節足蠍_蠍右(n, u1, u2, u3, u4, u5, u6, u7, -15.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0);
		}

		public static void 節足蠍_萎縮左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
		{
			Cha.節足蠍_蠍左(n, u1, u2, u3, u4, u5, u6, u7, -20.0, 0.0, 45.0, 25.0, 0.0, 0.0, 0.0);
		}

		public static void 節足蠍_萎縮右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
		{
			Cha.節足蠍_蠍右(n, u1, u2, u3, u4, u5, u6, u7, -20.0, 0.0, 45.0, 25.0, 0.0, 0.0, 0.0);
		}

		public static void 節足蠍_開く左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
		{
			Cha.節足蠍_蠍左(n, u1, u2, u3, u4, u5, u6, u7, 0.0, 0.0, -15.0, -25.0, 0.0, 0.0, 0.0);
		}

		public static void 節足蠍_開く右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
		{
			Cha.節足蠍_蠍右(n, u1, u2, u3, u4, u5, u6, u7, 0.0, 0.0, -15.0, -25.0, 0.0, 0.0, 0.0);
		}

		public static void 両節足蠍_基本(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u5 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u6 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u7 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u8 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.節足蠍_基本左(n, u, u2, u3, u4, u5, u6, u7, u8);
			Cha.節足蠍_基本右(n, u, u2, u3, u4, u5, u6, u7, u8);
		}

		public static void 両節足蠍_萎縮(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u5 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u6 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u7 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u8 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.節足蠍_萎縮左(n, u, u2, u3, u4, u5, u6, u7, u8);
			Cha.節足蠍_萎縮右(n, u, u2, u3, u4, u5, u6, u7, u8);
		}

		public static void 両節足蠍_開く(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u5 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u6 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u7 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u8 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.節足蠍_開く左(n, u, u2, u3, u4, u5, u6, u7, u8);
			Cha.節足蠍_開く右(n, u, u2, u3, u4, u5, u6, u7, u8);
		}

		public static void 両節足蠍_0(this Cha Cha, int n, bool 同角, int i1, int i2)
		{
			double num = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double num2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double num3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double num4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u5;
			double u6;
			double u7;
			double u8;
			if (同角)
			{
				u5 = num;
				u6 = num2;
				u7 = num3;
				u8 = num4;
			}
			else
			{
				u5 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				u6 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				u7 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				u8 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			}
			Cha.節足蠍左_0(i1, n, num, num2, num3, num4, u, u2, u3, u4);
			Cha.節足蠍右_0(i2, n, u5, u6, u7, u8, u, u2, u3, u4);
		}

		public static void 節足蠍左_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
		{
			switch (i)
			{
			case 0:
				c.節足蠍_基本左(n, u1, u2, u3, u4, u5, u6, u7, u8);
				return;
			case 1:
				c.節足蠍_萎縮左(n, u1, u2, u3, u4, u5, u6, u7, u8);
				return;
			case 2:
				c.節足蠍_開く左(n, u1, u2, u3, u4, u5, u6, u7, u8);
				return;
			default:
				return;
			}
		}

		public static void 節足蠍右_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
		{
			switch (i)
			{
			case 0:
				c.節足蠍_基本右(n, u1, u2, u3, u4, u5, u6, u7, u8);
				return;
			case 1:
				c.節足蠍_萎縮右(n, u1, u2, u3, u4, u5, u6, u7, u8);
				return;
			case 2:
				c.節足蠍_開く右(n, u1, u2, u3, u4, u5, u6, u7, u8);
				return;
			default:
				return;
			}
		}

		public static void 節足蠍絶頂(this Cha Cha, double a)
		{
			foreach (節足_足蠍 節足_足蠍 in Cha.Bod.節足蠍左)
			{
				節足_足蠍.X0Y0_転節.AngleCont = a * OthN.XS.NextDouble();
				節足_足蠍.X0Y0_腿節.AngleCont = a * OthN.XS.NextDouble();
				節足_足蠍.X0Y0_膝節.AngleCont = a * OthN.XS.NextDouble();
				節足_足蠍.X0Y0_脛節.AngleCont = a * OthN.XS.NextDouble();
				節足_足蠍.X0Y0_蹠節.AngleCont = a * OthN.XS.NextDouble();
				節足_足蠍.X0Y0_跗節1.AngleCont = a * OthN.XS.NextDouble();
				節足_足蠍.X0Y0_跗節2.AngleCont = a * OthN.XS.NextDouble();
			}
			foreach (節足_足蠍 節足_足蠍2 in Cha.Bod.節足蠍右)
			{
				節足_足蠍2.X0Y0_転節.AngleCont = -a * OthN.XS.NextDouble();
				節足_足蠍2.X0Y0_腿節.AngleCont = -a * OthN.XS.NextDouble();
				節足_足蠍2.X0Y0_膝節.AngleCont = -a * OthN.XS.NextDouble();
				節足_足蠍2.X0Y0_脛節.AngleCont = -a * OthN.XS.NextDouble();
				節足_足蠍2.X0Y0_蹠節.AngleCont = -a * OthN.XS.NextDouble();
				節足_足蠍2.X0Y0_跗節1.AngleCont = -a * OthN.XS.NextDouble();
				節足_足蠍2.X0Y0_跗節2.AngleCont = -a * OthN.XS.NextDouble();
			}
		}

		public static void 節足百左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double 基節角度, double 転節角度, double 前腿節角度, double 腿節角度, double 脛節角度, double 跗節1角度, double 跗節2角度)
		{
			節足_足百 節足_足百 = Cha.Bod.節足百左[n];
			節足_足百.Set角度0();
			if (節足_足百.反転Y)
			{
				節足_足百.X0Y0_基節.AngleBase += -基節角度 + -u1;
				節足_足百.X0Y0_転節.AngleBase += -転節角度 + -u2;
				節足_足百.X0Y0_前腿節.AngleBase += -前腿節角度 + -u3;
				節足_足百.X0Y0_腿節.AngleBase += -腿節角度 + -u4;
				節足_足百.X0Y0_脛節.AngleBase += -脛節角度 + -u5;
				節足_足百.X0Y0_跗節1.AngleBase += -跗節1角度 + -u6;
				節足_足百.X0Y0_跗節2.AngleBase += -跗節2角度 + -u7;
				return;
			}
			節足_足百.X0Y0_基節.AngleBase += 基節角度 + u1;
			節足_足百.X0Y0_転節.AngleBase += 転節角度 + u2;
			節足_足百.X0Y0_前腿節.AngleBase += 前腿節角度 + u3;
			節足_足百.X0Y0_腿節.AngleBase += 腿節角度 + u4;
			節足_足百.X0Y0_脛節.AngleBase += 脛節角度 + u5;
			節足_足百.X0Y0_跗節1.AngleBase += 跗節1角度 + u6;
			節足_足百.X0Y0_跗節2.AngleBase += 跗節2角度 + u7;
		}

		public static void 節足百右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double 基節角度, double 転節角度, double 前腿節角度, double 腿節角度, double 脛節角度, double 跗節1角度, double 跗節2角度)
		{
			節足_足百 節足_足百 = Cha.Bod.節足百右[n];
			節足_足百.Set角度0();
			if (節足_足百.反転Y)
			{
				節足_足百.X0Y0_基節.AngleBase += 基節角度 + u1;
				節足_足百.X0Y0_転節.AngleBase += 転節角度 + u2;
				節足_足百.X0Y0_前腿節.AngleBase += 前腿節角度 + u3;
				節足_足百.X0Y0_腿節.AngleBase += 腿節角度 + u4;
				節足_足百.X0Y0_脛節.AngleBase += 脛節角度 + u5;
				節足_足百.X0Y0_跗節1.AngleBase += 跗節1角度 + u6;
				節足_足百.X0Y0_跗節2.AngleBase += 跗節2角度 + u7;
				return;
			}
			節足_足百.X0Y0_基節.AngleBase += -基節角度 + -u1;
			節足_足百.X0Y0_転節.AngleBase += -転節角度 + -u2;
			節足_足百.X0Y0_前腿節.AngleBase += -前腿節角度 + -u3;
			節足_足百.X0Y0_腿節.AngleBase += -腿節角度 + -u4;
			節足_足百.X0Y0_脛節.AngleBase += -脛節角度 + -u5;
			節足_足百.X0Y0_跗節1.AngleBase += -跗節1角度 + -u6;
			節足_足百.X0Y0_跗節2.AngleBase += -跗節2角度 + -u7;
		}

		public static void 節足百_基本左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
		{
			Cha.節足百左(n, u1, u2, u3, u4, u5, u6, u7, 0.0, 0.0, 15.0, 0.0, -15.0, 0.0, 0.0);
		}

		public static void 節足百_基本右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
		{
			Cha.節足百右(n, u1, u2, u3, u4, u5, u6, u7, 0.0, 0.0, 15.0, 0.0, -15.0, 0.0, 0.0);
		}

		public static void 節足百_萎縮左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
		{
			Cha.節足百左(n, u1, u2, u3, u4, u5, u6, u7, 0.0, 0.0, 5.0, -25.0, -35.0, -25.0, 0.0);
		}

		public static void 節足百_萎縮右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
		{
			Cha.節足百右(n, u1, u2, u3, u4, u5, u6, u7, 0.0, 0.0, 5.0, -25.0, -35.0, -25.0, 0.0);
		}

		public static void 節足百_開く左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
		{
			Cha.節足百左(n, u1, u2, u3, u4, u5, u6, u7, 0.0, 0.0, 15.0, 5.0, 5.0, 5.0, 0.0);
		}

		public static void 節足百_開く右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
		{
			Cha.節足百右(n, u1, u2, u3, u4, u5, u6, u7, 0.0, 0.0, 15.0, 5.0, 5.0, 5.0, 0.0);
		}

		public static void 両節足百_基本(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u5 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u6 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u7 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u8 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.節足百_基本左(n, u, u2, u3, u4, u5, u6, u7, u8);
			Cha.節足百_基本右(n, u, u2, u3, u4, u5, u6, u7, u8);
		}

		public static void 両節足百_萎縮(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u5 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u6 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u7 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u8 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.節足百_萎縮左(n, u, u2, u3, u4, u5, u6, u7, u8);
			Cha.節足百_萎縮右(n, u, u2, u3, u4, u5, u6, u7, u8);
		}

		public static void 両節足百_開く(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u5 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u6 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u7 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u8 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.節足百_開く左(n, u, u2, u3, u4, u5, u6, u7, u8);
			Cha.節足百_開く右(n, u, u2, u3, u4, u5, u6, u7, u8);
		}

		public static void 両節足百_0(this Cha Cha, int n, bool 同角, int i1, int i2)
		{
			double num = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double num2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double num3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double num4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u5;
			double u6;
			double u7;
			double u8;
			if (同角)
			{
				u5 = num;
				u6 = num2;
				u7 = num3;
				u8 = num4;
			}
			else
			{
				u5 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				u6 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				u7 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				u8 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			}
			Cha.節足百左_0(i1, n, num, num2, num3, num4, u, u2, u3, u4);
			Cha.節足百右_0(i2, n, u5, u6, u7, u8, u, u2, u3, u4);
		}

		public static void 節足百左_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
		{
			switch (i)
			{
			case 0:
				c.節足百_基本左(n, u1, u2, u3, u4, u5, u6, u7, u8);
				return;
			case 1:
				c.節足百_萎縮左(n, u1, u2, u3, u4, u5, u6, u7, u8);
				return;
			case 2:
				c.節足百_開く左(n, u1, u2, u3, u4, u5, u6, u7, u8);
				return;
			default:
				return;
			}
		}

		public static void 節足百右_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
		{
			switch (i)
			{
			case 0:
				c.節足百_基本右(n, u1, u2, u3, u4, u5, u6, u7, u8);
				return;
			case 1:
				c.節足百_萎縮右(n, u1, u2, u3, u4, u5, u6, u7, u8);
				return;
			case 2:
				c.節足百_開く右(n, u1, u2, u3, u4, u5, u6, u7, u8);
				return;
			default:
				return;
			}
		}

		public static void 節足百絶頂(this Cha Cha, double a)
		{
			foreach (節足_足百 節足_足百 in Cha.Bod.節足百左)
			{
				節足_足百.X0Y0_基節.AngleCont = a * OthN.XS.NextDouble();
				節足_足百.X0Y0_転節.AngleCont = a * OthN.XS.NextDouble();
				節足_足百.X0Y0_前腿節.AngleCont = a * OthN.XS.NextDouble();
				節足_足百.X0Y0_腿節.AngleCont = a * OthN.XS.NextDouble();
				節足_足百.X0Y0_脛節.AngleCont = a * OthN.XS.NextDouble();
				節足_足百.X0Y0_跗節1.AngleCont = a * OthN.XS.NextDouble();
				節足_足百.X0Y0_跗節2.AngleCont = a * OthN.XS.NextDouble();
			}
			foreach (節足_足百 節足_足百2 in Cha.Bod.節足百右)
			{
				節足_足百2.X0Y0_基節.AngleCont = -a * OthN.XS.NextDouble();
				節足_足百2.X0Y0_転節.AngleCont = -a * OthN.XS.NextDouble();
				節足_足百2.X0Y0_前腿節.AngleCont = -a * OthN.XS.NextDouble();
				節足_足百2.X0Y0_腿節.AngleCont = -a * OthN.XS.NextDouble();
				節足_足百2.X0Y0_脛節.AngleCont = -a * OthN.XS.NextDouble();
				節足_足百2.X0Y0_跗節1.AngleCont = -a * OthN.XS.NextDouble();
				節足_足百2.X0Y0_跗節2.AngleCont = -a * OthN.XS.NextDouble();
			}
		}

		public static void 節尾曳左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double 根本角度, double 節角度1, double 節角度2, double 節角度3, double 節角度4)
		{
			節尾_曳航 節尾_曳航 = Cha.Bod.節尾曳左[n];
			節尾_曳航.Set角度0();
			節尾_曳航.X0Y0_前腿節.AngleBase += 根本角度 + u1;
			節尾_曳航.X0Y0_腿節.AngleBase += 節角度1 + u2;
			節尾_曳航.X0Y0_脛節.AngleBase += 節角度2 + u3;
			節尾_曳航.X0Y0_付節1.AngleBase += 節角度3 + u4;
			節尾_曳航.X0Y0_付節2.AngleBase += 節角度4 + u5;
		}

		public static void 節尾曳右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double 根本角度, double 節角度1, double 節角度2, double 節角度3, double 節角度4)
		{
			節尾_曳航 節尾_曳航 = Cha.Bod.節尾曳右[n];
			節尾_曳航.Set角度0();
			節尾_曳航.X0Y0_前腿節.AngleBase += -根本角度 + -u1;
			節尾_曳航.X0Y0_腿節.AngleBase += -節角度1 + -u2;
			節尾_曳航.X0Y0_脛節.AngleBase += -節角度2 + -u3;
			節尾_曳航.X0Y0_付節1.AngleBase += -節角度3 + -u4;
			節尾_曳航.X0Y0_付節2.AngleBase += -節角度4 + -u5;
		}

		public static void 節尾曳_基本左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5)
		{
			Cha.節尾曳左(n, u1, u2, u3, u4, u5, 10.0, 0.0, 0.0, 0.0, 0.0);
		}

		public static void 節尾曳_基本右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5)
		{
			Cha.節尾曳右(n, u1, u2, u3, u4, u5, 10.0, 0.0, 0.0, 0.0, 0.0);
		}

		public static void 節尾曳_閉じ左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5)
		{
			Cha.節尾曳左(n, u1, u2, u3, u4, u5, 45.0, -25.0, -45.0, -45.0, 0.0);
		}

		public static void 節尾曳_閉じ右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5)
		{
			Cha.節尾曳右(n, u1, u2, u3, u4, u5, 45.0, -25.0, -45.0, -45.0, 0.0);
		}

		public static void 節尾曳_開き左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5)
		{
			Cha.節尾曳左(n, u1, u2, u3, u4, u5, 25.0, 0.0, 0.0, 0.0, 0.0);
		}

		public static void 節尾曳_開き右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5)
		{
			Cha.節尾曳右(n, u1, u2, u3, u4, u5, 25.0, 0.0, 0.0, 0.0, 0.0);
		}

		public static void 両節尾曳_基本(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u5 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.節尾曳_基本左(n, u, u2, u3, u4, u5);
			Cha.節尾曳_基本右(n, u, u2, u3, u4, u5);
		}

		public static void 両節尾曳_閉じ(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u5 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.節尾曳_閉じ左(n, u, u2, u3, u4, u5);
			Cha.節尾曳_閉じ右(n, u, u2, u3, u4, u5);
		}

		public static void 両節尾曳_開き(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u5 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.節尾曳_開き左(n, u, u2, u3, u4, u5);
			Cha.節尾曳_開き右(n, u, u2, u3, u4, u5);
		}

		public static void 両節尾曳_0(this Cha Cha, int n, bool 同角, int i1, int i2)
		{
			double num = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double num2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double num3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double num4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double num5 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u;
			double u2;
			double u3;
			double u4;
			double u5;
			if (同角)
			{
				u = num;
				u2 = num2;
				u3 = num3;
				u4 = num4;
				u5 = num5;
			}
			else
			{
				u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				u5 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			}
			Cha.節尾曳左_0(i1, n, num, num2, num3, num4, num5);
			Cha.節尾曳右_0(i2, n, u, u2, u3, u4, u5);
		}

		public static void 節尾曳左_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4, double u5)
		{
			switch (i)
			{
			case 0:
				c.節尾曳_基本左(n, u1, u2, u3, u4, u5);
				return;
			case 1:
				c.節尾曳_閉じ左(n, u1, u2, u3, u4, u5);
				return;
			case 2:
				c.節尾曳_開き左(n, u1, u2, u3, u4, u5);
				return;
			default:
				return;
			}
		}

		public static void 節尾曳右_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4, double u5)
		{
			switch (i)
			{
			case 0:
				c.節尾曳_基本右(n, u1, u2, u3, u4, u5);
				return;
			case 1:
				c.節尾曳_閉じ右(n, u1, u2, u3, u4, u5);
				return;
			case 2:
				c.節尾曳_開き右(n, u1, u2, u3, u4, u5);
				return;
			default:
				return;
			}
		}

		public static void 節尾曳絶頂(this Cha Cha, double a)
		{
			foreach (節尾_曳航 節尾_曳航 in Cha.Bod.節尾曳左)
			{
				節尾_曳航.X0Y0_前腿節.AngleCont = a * OthN.XS.NextDouble();
				節尾_曳航.X0Y0_腿節.AngleCont = a * OthN.XS.NextDouble();
				節尾_曳航.X0Y0_脛節.AngleCont = a * OthN.XS.NextDouble();
				節尾_曳航.X0Y0_付節1.AngleCont = a * OthN.XS.NextDouble();
				節尾_曳航.X0Y0_付節2.AngleCont = a * OthN.XS.NextDouble();
			}
			foreach (節尾_曳航 節尾_曳航2 in Cha.Bod.節尾曳右)
			{
				節尾_曳航2.X0Y0_前腿節.AngleCont = -a * OthN.XS.NextDouble();
				節尾_曳航2.X0Y0_腿節.AngleCont = -a * OthN.XS.NextDouble();
				節尾_曳航2.X0Y0_脛節.AngleCont = -a * OthN.XS.NextDouble();
				節尾_曳航2.X0Y0_付節1.AngleCont = -a * OthN.XS.NextDouble();
				節尾_曳航2.X0Y0_付節2.AngleCont = -a * OthN.XS.NextDouble();
			}
		}

		public static void 節尾鋏左(this Cha Cha, int n, double u1, double 根本角度)
		{
			節尾_鋏 節尾_鋏 = Cha.Bod.節尾鋏左[n];
			節尾_鋏.Set角度0();
			節尾_鋏.X0Y0_牙.AngleBase += 根本角度 + u1;
		}

		public static void 節尾鋏右(this Cha Cha, int n, double u1, double 根本角度)
		{
			節尾_鋏 節尾_鋏 = Cha.Bod.節尾鋏右[n];
			節尾_鋏.Set角度0();
			節尾_鋏.X0Y0_牙.AngleBase += -根本角度 + -u1;
		}

		public static void 節尾鋏_基本左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5)
		{
			Cha.節尾鋏左(n, u1, 0.0);
		}

		public static void 節尾鋏_基本右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5)
		{
			Cha.節尾鋏右(n, u1, 0.0);
		}

		public static void 節尾鋏_閉じ左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5)
		{
			Cha.節尾鋏左(n, u1, -15.0);
		}

		public static void 節尾鋏_閉じ右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5)
		{
			Cha.節尾鋏右(n, u1, -15.0);
		}

		public static void 節尾鋏_開き左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5)
		{
			Cha.節尾鋏左(n, u1, 25.0);
		}

		public static void 節尾鋏_開き右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5)
		{
			Cha.節尾鋏右(n, u1, 25.0);
		}

		public static void 両節尾鋏_基本(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u5 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.節尾鋏_基本左(n, u, u2, u3, u4, u5);
			Cha.節尾鋏_基本右(n, u, u2, u3, u4, u5);
		}

		public static void 両節尾鋏_閉じ(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u5 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.節尾鋏_閉じ左(n, u, u2, u3, u4, u5);
			Cha.節尾鋏_閉じ右(n, u, u2, u3, u4, u5);
		}

		public static void 両節尾鋏_開き(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u5 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.節尾鋏_開き左(n, u, u2, u3, u4, u5);
			Cha.節尾鋏_開き右(n, u, u2, u3, u4, u5);
		}

		public static void 両節尾鋏_0(this Cha Cha, int n, bool 同角, int i1, int i2)
		{
			double num = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double num2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double num3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double num4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double num5 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u;
			double u2;
			double u3;
			double u4;
			double u5;
			if (同角)
			{
				u = num;
				u2 = num2;
				u3 = num3;
				u4 = num4;
				u5 = num5;
			}
			else
			{
				u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				u5 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			}
			Cha.節尾鋏左_0(i1, n, num, num2, num3, num4, num5);
			Cha.節尾鋏右_0(i2, n, u, u2, u3, u4, u5);
		}

		public static void 節尾鋏左_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4, double u5)
		{
			switch (i)
			{
			case 0:
				c.節尾鋏_基本左(n, u1, u2, u3, u4, u5);
				return;
			case 1:
				c.節尾鋏_閉じ左(n, u1, u2, u3, u4, u5);
				return;
			case 2:
				c.節尾鋏_開き左(n, u1, u2, u3, u4, u5);
				return;
			default:
				return;
			}
		}

		public static void 節尾鋏右_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4, double u5)
		{
			switch (i)
			{
			case 0:
				c.節尾鋏_基本右(n, u1, u2, u3, u4, u5);
				return;
			case 1:
				c.節尾鋏_閉じ右(n, u1, u2, u3, u4, u5);
				return;
			case 2:
				c.節尾鋏_開き右(n, u1, u2, u3, u4, u5);
				return;
			default:
				return;
			}
		}

		public static void 節尾鋏絶頂(this Cha Cha, double a)
		{
			foreach (節尾_鋏 節尾_鋏 in Cha.Bod.節尾鋏左)
			{
				節尾_鋏.X0Y0_牙.AngleCont = a * OthN.XS.NextDouble();
			}
			foreach (節尾_鋏 節尾_鋏2 in Cha.Bod.節尾鋏右)
			{
				節尾_鋏2.X0Y0_牙.AngleCont = -a * OthN.XS.NextDouble();
			}
		}

		public static void 虫鎌左(this Cha Cha, int n, double u1, double 根本角度)
		{
			虫鎌 虫鎌 = Cha.Bod.虫鎌左[n];
			if (虫鎌.拘束)
			{
				虫鎌.Set角度0();
				return;
			}
			虫鎌.Set角度0();
			if (虫鎌.反転Y)
			{
				虫鎌.X0Y0_虫鎌1.AngleBase += -根本角度 + -u1;
				return;
			}
			虫鎌.X0Y0_虫鎌1.AngleBase += 根本角度 + u1;
		}

		public static void 虫鎌右(this Cha Cha, int n, double u1, double 根本角度)
		{
			虫鎌 虫鎌 = Cha.Bod.虫鎌右[n];
			if (虫鎌.拘束)
			{
				虫鎌.Set角度0();
				return;
			}
			虫鎌.Set角度0();
			if (虫鎌.反転Y)
			{
				虫鎌.X0Y0_虫鎌1.AngleBase += 根本角度 + u1;
				return;
			}
			虫鎌.X0Y0_虫鎌1.AngleBase += -根本角度 + -u1;
		}

		public static void 虫鎌_基本左(this Cha Cha, int n, double u1)
		{
			Cha.虫鎌左(n, u1, 0.0);
		}

		public static void 虫鎌_基本右(this Cha Cha, int n, double u1)
		{
			Cha.虫鎌右(n, u1, 0.0);
		}

		public static void 虫鎌_半開左(this Cha Cha, int n, double u1)
		{
			Cha.虫鎌左(n, u1, 45.0);
		}

		public static void 虫鎌_半開右(this Cha Cha, int n, double u1)
		{
			Cha.虫鎌右(n, u1, 45.0);
		}

		public static void 虫鎌_全開左(this Cha Cha, int n, double u1)
		{
			Cha.虫鎌左(n, u1, 90.0);
		}

		public static void 虫鎌_全開右(this Cha Cha, int n, double u1)
		{
			Cha.虫鎌右(n, u1, 90.0);
		}

		public static void 両虫鎌_基本(this Cha Cha, int n)
		{
			double u = 0.0;
			Cha.虫鎌_基本左(n, u);
			Cha.虫鎌_基本右(n, u);
		}

		public static void 両虫鎌_半開(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.虫鎌_半開左(n, u);
			Cha.虫鎌_半開右(n, u);
		}

		public static void 両虫鎌_全開(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			Cha.虫鎌_全開左(n, u);
			Cha.虫鎌_全開右(n, u);
		}

		public static void 両虫鎌_0(this Cha Cha, int n, bool 同角, int i1, int i2)
		{
			double num = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u;
			if (同角)
			{
				u = num;
			}
			else
			{
				u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			}
			Cha.虫鎌左_0(i1, n, num);
			Cha.虫鎌右_0(i2, n, u);
		}

		public static void 虫鎌左_0(this Cha c, int i, int n, double u1)
		{
			switch (i)
			{
			case 0:
				c.虫鎌_基本左(n, 0.0);
				return;
			case 1:
				c.虫鎌_半開左(n, u1);
				return;
			case 2:
				c.虫鎌_全開左(n, u1);
				return;
			default:
				return;
			}
		}

		public static void 虫鎌右_0(this Cha c, int i, int n, double u1)
		{
			switch (i)
			{
			case 0:
				c.虫鎌_基本右(n, 0.0);
				return;
			case 1:
				c.虫鎌_半開右(n, u1);
				return;
			case 2:
				c.虫鎌_全開右(n, u1);
				return;
			default:
				return;
			}
		}

		public static void 虫鎌絶頂(this Cha Cha, double a)
		{
			foreach (虫鎌 虫鎌 in Cha.Bod.虫鎌左)
			{
				if (!虫鎌.拘束)
				{
					虫鎌.角度C = a * OthN.XS.NextDouble();
				}
			}
			foreach (虫鎌 虫鎌2 in Cha.Bod.虫鎌右)
			{
				if (!虫鎌2.拘束)
				{
					虫鎌2.角度C = -a * OthN.XS.NextDouble();
				}
			}
		}

		public static void 触手左(this Cha Cha, int n, int si, double u1, double u2, double u3, double 根本角度, double 開口, params Func<int, double>[] angs)
		{
			触手 触手 = Cha.Bod.触手左[n];
			触手.Set角度0();
			if (angs.Length != 0)
			{
				Par[] array = 触手.Enum軸().ToArray<Par>();
				if (array.Length != 0)
				{
					int num = 0;
					int num2 = array.Length / angs.Length;
					double num3 = (double)array.Length * 0.1;
					foreach (Par par in array.Skip(1))
					{
						par.AngleBase = (double)si * (angs[(num / num2).Limit(0, angs.Length)](num) / num3 + u2);
						num++;
					}
					array[0].AngleBase = (double)si * (根本角度 + u1);
				}
			}
			if (触手 is 触手_蔦)
			{
				if (触手.拘束)
				{
					触手_蔦 触手_蔦 = (触手_蔦)触手;
					if (触手_蔦.先端_上顎_顎_表示)
					{
						触手_蔦.X0Y0_先端_上顎_顎.AngleBase = 0.0;
					}
					if (触手_蔦.先端_下顎_顎_表示)
					{
						触手_蔦.X0Y0_先端_下顎_顎.AngleBase = 0.0;
					}
				}
				else
				{
					触手_蔦 触手_蔦2 = (触手_蔦)触手;
					if (触手_蔦2.先端_上顎_顎_表示)
					{
						触手_蔦2.X0Y0_先端_上顎_顎.AngleBase = 15.0 * 開口 + u3;
					}
					if (触手_蔦2.先端_下顎_顎_表示)
					{
						触手_蔦2.X0Y0_先端_下顎_顎.AngleBase = -15.0 * 開口 + -u3;
					}
				}
			}
			触手.重複角度処理();
		}

		public static void 触手右(this Cha Cha, int n, int si, double u1, double u2, double u3, double 根本角度, double 開口, params Func<int, double>[] angs)
		{
			触手 触手 = Cha.Bod.触手右[n];
			触手.Set角度0();
			if (angs.Length != 0)
			{
				Par[] array = 触手.Enum軸().ToArray<Par>();
				if (array.Length != 0)
				{
					int num = 0;
					int num2 = array.Length / angs.Length;
					double num3 = (double)array.Length * 0.1;
					foreach (Par par in array.Skip(1))
					{
						par.AngleBase = (double)si * (-angs[(num / num2).Limit(0, angs.Length)](num) / num3 + -u2);
						num++;
					}
					array[0].AngleBase = (double)si * (-根本角度 + -u1);
				}
			}
			if (触手 is 触手_蔦)
			{
				if (触手.拘束)
				{
					触手_蔦 触手_蔦 = (触手_蔦)触手;
					if (触手_蔦.先端_上顎_顎_表示)
					{
						触手_蔦.X0Y0_先端_上顎_顎.AngleBase = 0.0;
					}
					if (触手_蔦.先端_下顎_顎_表示)
					{
						触手_蔦.X0Y0_先端_下顎_顎.AngleBase = 0.0;
					}
				}
				else
				{
					触手_蔦 触手_蔦2 = (触手_蔦)触手;
					if (触手_蔦2.先端_上顎_顎_表示)
					{
						触手_蔦2.X0Y0_先端_上顎_顎.AngleBase = -15.0 * 開口 + -u3;
					}
					if (触手_蔦2.先端_下顎_顎_表示)
					{
						触手_蔦2.X0Y0_先端_下顎_顎.AngleBase = 15.0 * 開口 + u3;
					}
				}
			}
			触手.重複角度処理();
		}

		public static void 触手_基本左(this Cha Cha, int n, int s, double u1, double u2, double u3)
		{
			Cha.触手左(n, s, u1, u2, u3, 20.0.GetRanAngle(), 0.0, new Func<int, double>[0]);
		}

		public static void 触手_基本右(this Cha Cha, int n, int s, double u1, double u2, double u3)
		{
			Cha.触手右(n, s, u1, u2, u3, 20.0.GetRanAngle(), 0.0, new Func<int, double>[0]);
		}

		public static void 触手_S字左(this Cha Cha, int n, int s, double u1, double u2, double u3)
		{
			double ranAngle = 20.0.GetRanAngle();
			double 開口 = 0.25;
			Func<int, double>[] array = new Func<int, double>[2];
			array[0] = ((int i) => 35.0);
			array[1] = ((int i) => -35.0);
			Cha.触手左(n, s, u1, u2, u3, ranAngle, 開口, array);
		}

		public static void 触手_S字右(this Cha Cha, int n, int s, double u1, double u2, double u3)
		{
			double ranAngle = 20.0.GetRanAngle();
			double 開口 = 0.25;
			Func<int, double>[] array = new Func<int, double>[2];
			array[0] = ((int i) => 35.0);
			array[1] = ((int i) => -35.0);
			Cha.触手右(n, s, u1, u2, u3, ranAngle, 開口, array);
		}

		public static void 触手_波左(this Cha Cha, int n, int s, double u1, double u2, double u3)
		{
			double ranAngle = 20.0.GetRanAngle();
			double 開口 = 0.25;
			Func<int, double>[] array = new Func<int, double>[1];
			array[0] = ((int i) => Math.Sin((double)i) * 80.0);
			Cha.触手左(n, s, u1, u2, u3, ranAngle, 開口, array);
		}

		public static void 触手_波右(this Cha Cha, int n, int s, double u1, double u2, double u3)
		{
			double ranAngle = 20.0.GetRanAngle();
			double 開口 = 0.25;
			Func<int, double>[] array = new Func<int, double>[1];
			array[0] = ((int i) => Math.Sin((double)i) * 80.0);
			Cha.触手右(n, s, u1, u2, u3, ranAngle, 開口, array);
		}

		public static void 触手_ピ\u30FCン左(this Cha Cha, int n, int s, double u1, double u2, double u3)
		{
			double ranAngle = 20.0.GetRanAngle();
			double 開口 = 0.0;
			Func<int, double>[] array = new Func<int, double>[2];
			array[0] = ((int i) => 0.0);
			array[1] = ((int i) => 25.0.GetRanAngle());
			Cha.触手左(n, s, u1, u2, u3, ranAngle, 開口, array);
		}

		public static void 触手_ピ\u30FCン右(this Cha Cha, int n, int s, double u1, double u2, double u3)
		{
			double ranAngle = 20.0.GetRanAngle();
			double 開口 = 0.0;
			Func<int, double>[] array = new Func<int, double>[2];
			array[0] = ((int i) => 0.0);
			array[1] = ((int i) => 25.0.GetRanAngle());
			Cha.触手右(n, s, u1, u2, u3, ranAngle, 開口, array);
		}

		public static void 両触手_基本(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 1.5, OthN.XS.NextSign(), 0.75);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 1.5, OthN.XS.NextSign(), 0.75);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 1.5, OthN.XS.NextSign(), 0.75);
			int s = OthN.XS.NextSign();
			Cha.触手_基本左(n, s, u, u2, u3);
			Cha.触手_基本右(n, s, u, u2, u3);
		}

		public static void 両触手_S字(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 1.5, OthN.XS.NextSign(), 0.75);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 1.5, OthN.XS.NextSign(), 0.75);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 1.5, OthN.XS.NextSign(), 0.75);
			int s = OthN.XS.NextSign();
			Cha.触手_S字左(n, s, u, u2, u3);
			Cha.触手_S字右(n, s, u, u2, u3);
		}

		public static void 両触手_波(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 1.5, OthN.XS.NextSign(), 0.75);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 1.5, OthN.XS.NextSign(), 0.75);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 1.5, OthN.XS.NextSign(), 0.75);
			int s = OthN.XS.NextSign();
			Cha.触手_波左(n, s, u, u2, u3);
			Cha.触手_波右(n, s, u, u2, u3);
		}

		public static void 両触手_ピ\u30FCン(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 1.5, OthN.XS.NextSign(), 0.75);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 1.5, OthN.XS.NextSign(), 0.75);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 1.5, OthN.XS.NextSign(), 0.75);
			int s = OthN.XS.NextSign();
			Cha.触手_ピ\u30FCン左(n, s, u, u2, u3);
			Cha.触手_ピ\u30FCン右(n, s, u, u2, u3);
		}

		public static void 両触手_0(this Cha Cha, int n, bool 同角, int i1, int i2)
		{
			double num = Cha.角度ムラ(OthN.XS.NextSign(), 1.5, OthN.XS.NextSign(), 0.25);
			double num2 = Cha.角度ムラ(OthN.XS.NextSign(), 1.5, OthN.XS.NextSign(), 0.25);
			double num3 = Cha.角度ムラ(OthN.XS.NextSign(), 1.5, OthN.XS.NextSign(), 0.25);
			int num4 = OthN.XS.NextSign();
			double u;
			double u2;
			double u3;
			int s;
			if (同角)
			{
				u = num;
				u2 = num2;
				u3 = num3;
				s = num4;
			}
			else
			{
				u = Cha.角度ムラ(OthN.XS.NextSign(), 1.5, OthN.XS.NextSign(), 0.25);
				u2 = Cha.角度ムラ(OthN.XS.NextSign(), 1.5, OthN.XS.NextSign(), 0.25);
				u3 = Cha.角度ムラ(OthN.XS.NextSign(), 1.5, OthN.XS.NextSign(), 0.25);
				s = OthN.XS.NextSign();
			}
			Cha.触手左_0(i1, n, num4, num, num2, num3);
			Cha.触手右_0(i2, n, s, u, u2, u3);
		}

		public static void 両触手_0(this Cha Cha, int n, int i2)
		{
			Cha.触手右_0(i2, n, OthN.XS.NextSign(), Cha.角度ムラ(OthN.XS.NextSign(), 1.5, OthN.XS.NextSign(), 0.25), Cha.角度ムラ(OthN.XS.NextSign(), 1.5, OthN.XS.NextSign(), 0.25), Cha.角度ムラ(OthN.XS.NextSign(), 1.5, OthN.XS.NextSign(), 0.25));
		}

		public static void 触手左_0(this Cha c, int i, int n, int s, double u1, double u2, double u3)
		{
			switch (i)
			{
			case 0:
				c.触手_基本左(n, s, u1, u2, u3);
				return;
			case 1:
				c.触手_S字左(n, s, u1, u2, u3);
				return;
			case 2:
				c.触手_波左(n, s, u1, u2, u3);
				return;
			case 3:
				c.触手_ピ\u30FCン左(n, s, u1, u2, u3);
				return;
			default:
				return;
			}
		}

		public static void 触手右_0(this Cha c, int i, int n, int s, double u1, double u2, double u3)
		{
			switch (i)
			{
			case 0:
				c.触手_基本右(n, s, u1, u2, u3);
				return;
			case 1:
				c.触手_S字右(n, s, u1, u2, u3);
				return;
			case 2:
				c.触手_波右(n, s, u1, u2, u3);
				return;
			case 3:
				c.触手_ピ\u30FCン右(n, s, u1, u2, u3);
				return;
			default:
				return;
			}
		}

		public static void 触手絶頂(this Cha Cha, double a)
		{
			foreach (触手 触手 in Cha.Bod.触手左)
			{
				foreach (Par par in 触手.Enum軸())
				{
					par.AngleCont = a * OthN.XS.NextDouble();
				}
				if (!触手.拘束 && 触手 is 触手_蔦)
				{
					触手_蔦 触手_蔦 = (触手_蔦)触手;
					if (触手_蔦.先端_上顎_顎_表示)
					{
						触手_蔦.X0Y0_先端_上顎_顎.AngleCont = a * OthN.XS.NextDouble();
					}
					if (触手_蔦.先端_下顎_顎_表示)
					{
						触手_蔦.X0Y0_先端_下顎_顎.AngleCont = -a * OthN.XS.NextDouble();
					}
				}
			}
			foreach (触手 触手2 in Cha.Bod.触手右)
			{
				foreach (Par par2 in 触手2.Enum軸())
				{
					par2.AngleCont = -a * OthN.XS.NextDouble();
				}
				if (!触手2.拘束 && 触手2 is 触手_蔦)
				{
					触手_蔦 触手_蔦2 = (触手_蔦)触手2;
					if (触手_蔦2.先端_上顎_顎_表示)
					{
						触手_蔦2.X0Y0_先端_上顎_顎.AngleCont = -a * OthN.XS.NextDouble();
					}
					if (触手_蔦2.先端_下顎_顎_表示)
					{
						触手_蔦2.X0Y0_先端_下顎_顎.AngleCont = a * OthN.XS.NextDouble();
					}
				}
			}
		}

		public static void 触手犬左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double 根本角度, double 上腕角度, double 下腕角度, double 手角度, double 開口, double 開指, params Func<int, double>[] angs)
		{
			触手_犬 触手_犬 = Cha.Bod.触手犬左[n];
			触手_犬.Set角度0();
			触手_犬.X0Y0_脚後_上腕.AngleBase -= 触手_犬.X0Y0_胴_節9_胴.Angle;
			触手_犬.X0Y0_脚前_上腕.AngleBase -= 触手_犬.X0Y0_胴_節9_胴.Angle;
			触手_犬.X0Y0_頭_口膜_口膜1.AngleBase += 17.0;
			触手_犬.X0Y0_脚後_上腕.AngleBase += 上腕角度 + u1;
			触手_犬.X0Y0_脚後_下腕.AngleBase += 下腕角度 + u2;
			触手_犬.X0Y0_脚後_手_手.AngleBase += 手角度 + u3;
			触手_犬.X0Y0_脚前_上腕.AngleBase += 上腕角度 + -u1;
			触手_犬.X0Y0_脚前_下腕.AngleBase += 下腕角度 + -u2;
			触手_犬.X0Y0_脚前_手_手.AngleBase += 手角度 + -u3;
			if (触手_犬.拘束)
			{
				触手_犬.X0Y0_頭_上顎_眼下_眼下.AngleBase = 0.0;
				触手_犬.X0Y0_頭_下顎_眼下_眼下.AngleBase = 0.0;
			}
			else
			{
				触手_犬.X0Y0_頭_上顎_眼下_眼下.AngleBase += 10.0 * 開口 + u4;
				触手_犬.X0Y0_頭_下顎_眼下_眼下.AngleBase += -10.0 * 開口 + -u4;
			}
			触手_犬.X0Y0_脚後_手_親指_爪.AngleBase += -30.0 * 開指 + u5;
			触手_犬.X0Y0_脚後_手_人指_指.AngleBase += -15.0 * 開指 + u5;
			触手_犬.X0Y0_脚後_手_中指_指.AngleBase += 0.0 * 開指 + u5;
			触手_犬.X0Y0_脚後_手_薬指_指.AngleBase += 15.0 * 開指 + u5;
			触手_犬.X0Y0_脚後_手_小指_指.AngleBase += 30.0 * 開指 + u5;
			触手_犬.X0Y0_脚前_手_親指_爪.AngleBase += 30.0 * 開指 + -u5;
			触手_犬.X0Y0_脚前_手_人指_指.AngleBase += 15.0 * 開指 + -u5;
			触手_犬.X0Y0_脚前_手_中指_指.AngleBase += 0.0 * 開指 + -u5;
			触手_犬.X0Y0_脚前_手_薬指_指.AngleBase += -15.0 * 開指 + -u5;
			触手_犬.X0Y0_脚前_手_小指_指.AngleBase += -30.0 * 開指 + -u5;
			if (angs.Length != 0)
			{
				Par[] array = 触手_犬.Enum軸().ToArray<Par>();
				if (array.Length != 0)
				{
					int num = 0;
					int num2 = array.Length / angs.Length;
					double num3 = (double)array.Length * 0.1;
					foreach (Par par in array.Skip(1))
					{
						par.AngleBase += angs[(num / num2).Limit(0, angs.Length)](num) / num3 + u7;
						num++;
					}
					array[0].AngleBase += 根本角度 + u6;
				}
			}
			触手_犬.重複角度処理();
		}

		public static void 触手犬右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double 根本角度, double 上腕角度, double 下腕角度, double 手角度, double 開口, double 開指, params Func<int, double>[] angs)
		{
			触手_犬 触手_犬 = Cha.Bod.触手犬右[n];
			触手_犬.Set角度0();
			触手_犬.X0Y0_脚後_上腕.AngleBase -= 触手_犬.X0Y0_胴_節9_胴.Angle;
			触手_犬.X0Y0_脚前_上腕.AngleBase -= 触手_犬.X0Y0_胴_節9_胴.Angle;
			触手_犬.X0Y0_頭_口膜_口膜1.AngleBase -= 17.0;
			触手_犬.X0Y0_脚後_上腕.AngleBase += -上腕角度 + -u1;
			触手_犬.X0Y0_脚後_下腕.AngleBase += -下腕角度 + -u2;
			触手_犬.X0Y0_脚後_手_手.AngleBase += -手角度 + -u3;
			触手_犬.X0Y0_脚前_上腕.AngleBase += -上腕角度 + u1;
			触手_犬.X0Y0_脚前_下腕.AngleBase += -下腕角度 + u2;
			触手_犬.X0Y0_脚前_手_手.AngleBase += -手角度 + u3;
			if (触手_犬.拘束)
			{
				触手_犬.X0Y0_頭_上顎_眼下_眼下.AngleBase = 0.0;
				触手_犬.X0Y0_頭_下顎_眼下_眼下.AngleBase = 0.0;
			}
			else
			{
				触手_犬.X0Y0_頭_上顎_眼下_眼下.AngleBase += -10.0 * 開口 + -u4;
				触手_犬.X0Y0_頭_下顎_眼下_眼下.AngleBase += 10.0 * 開口 + u4;
			}
			触手_犬.X0Y0_脚後_手_親指_爪.AngleBase += 30.0 * 開指 + -u5;
			触手_犬.X0Y0_脚後_手_人指_指.AngleBase += 15.0 * 開指 + -u5;
			触手_犬.X0Y0_脚後_手_中指_指.AngleBase += --0.0 * 開指 + -u5;
			触手_犬.X0Y0_脚後_手_薬指_指.AngleBase += -15.0 * 開指 + -u5;
			触手_犬.X0Y0_脚後_手_小指_指.AngleBase += -30.0 * 開指 + -u5;
			触手_犬.X0Y0_脚前_手_親指_爪.AngleBase += -30.0 * 開指 + u5;
			触手_犬.X0Y0_脚前_手_人指_指.AngleBase += -15.0 * 開指 + u5;
			触手_犬.X0Y0_脚前_手_中指_指.AngleBase += --0.0 * 開指 + u5;
			触手_犬.X0Y0_脚前_手_薬指_指.AngleBase += 15.0 * 開指 + u5;
			触手_犬.X0Y0_脚前_手_小指_指.AngleBase += 30.0 * 開指 + u5;
			if (angs.Length != 0)
			{
				Par[] array = 触手_犬.Enum軸().ToArray<Par>();
				if (array.Length != 0)
				{
					int num = 0;
					int num2 = array.Length / angs.Length;
					double num3 = (double)array.Length * 0.1;
					foreach (Par par in array.Skip(1))
					{
						par.AngleBase += -angs[(num / num2).Limit(0, angs.Length)](num) / num3 + -u7;
						num++;
					}
					array[0].AngleBase += -根本角度 + -u6;
				}
			}
			触手_犬.重複角度処理();
		}

		public static void 触手犬_基本左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7)
		{
			Cha.触手犬左(n, u1, u2, u3, u4, u5, u6, u7, 5.0.GetRanAngle(), 10.0, 0.0, 0.0, 0.0, 0.0, new Func<int, double>[0]);
		}

		public static void 触手犬_基本右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7)
		{
			Cha.触手犬右(n, u1, u2, u3, u4, u5, u6, u7, 5.0.GetRanAngle(), 10.0, 0.0, 0.0, 0.0, 0.0, new Func<int, double>[0]);
		}

		public static void 触手犬_伏せ左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7)
		{
			double ranAngle = 5.0.GetRanAngle();
			double 上腕角度 = -35.0;
			double 下腕角度 = 130.0;
			double 手角度 = -80.0;
			double 開口 = 0.0;
			double 開指 = 0.0;
			Func<int, double>[] array = new Func<int, double>[2];
			array[0] = ((int i) => 8.0);
			array[1] = ((int i) => -10.0);
			Cha.触手犬左(n, u1, u2, u3, u4, u5, u6, u7, ranAngle, 上腕角度, 下腕角度, 手角度, 開口, 開指, array);
		}

		public static void 触手犬_伏せ右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7)
		{
			double ranAngle = 5.0.GetRanAngle();
			double 上腕角度 = -35.0;
			double 下腕角度 = 130.0;
			double 手角度 = -80.0;
			double 開口 = 0.0;
			double 開指 = 0.0;
			Func<int, double>[] array = new Func<int, double>[2];
			array[0] = ((int i) => 8.0);
			array[1] = ((int i) => -10.0);
			Cha.触手犬右(n, u1, u2, u3, u4, u5, u6, u7, ranAngle, 上腕角度, 下腕角度, 手角度, 開口, 開指, array);
		}

		public static void 触手犬_威嚇左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7)
		{
			double ranAngle = 5.0.GetRanAngle();
			double 上腕角度 = -20.0;
			double 下腕角度 = 65.0;
			double 手角度 = -40.0;
			double 開口 = 1.0;
			double 開指 = 1.0;
			Func<int, double>[] array = new Func<int, double>[1];
			array[0] = ((int i) => 2.5);
			Cha.触手犬左(n, u1, u2, u3, u4, u5, u6, u7, ranAngle, 上腕角度, 下腕角度, 手角度, 開口, 開指, array);
		}

		public static void 触手犬_威嚇右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7)
		{
			double ranAngle = 5.0.GetRanAngle();
			double 上腕角度 = -20.0;
			double 下腕角度 = 65.0;
			double 手角度 = -40.0;
			double 開口 = 1.0;
			double 開指 = 1.0;
			Func<int, double>[] array = new Func<int, double>[1];
			array[0] = ((int i) => 2.5);
			Cha.触手犬右(n, u1, u2, u3, u4, u5, u6, u7, ranAngle, 上腕角度, 下腕角度, 手角度, 開口, 開指, array);
		}

		public static void 触手犬_竦み左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7)
		{
			double ranAngle = 2.0.GetRanAngle();
			double 上腕角度 = -40.0;
			double 下腕角度 = 130.0;
			double 手角度 = -80.0;
			double 開口 = 0.0;
			double 開指 = 0.0;
			Func<int, double>[] array = new Func<int, double>[1];
			array[0] = ((int i) => 8.0);
			Cha.触手犬左(n, u1, u2, u3, u4, u5, u6, u7, ranAngle, 上腕角度, 下腕角度, 手角度, 開口, 開指, array);
		}

		public static void 触手犬_竦み右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7)
		{
			double ranAngle = 2.0.GetRanAngle();
			double 上腕角度 = -40.0;
			double 下腕角度 = 130.0;
			double 手角度 = -80.0;
			double 開口 = 0.0;
			double 開指 = 0.0;
			Func<int, double>[] array = new Func<int, double>[1];
			array[0] = ((int i) => 8.0);
			Cha.触手犬右(n, u1, u2, u3, u4, u5, u6, u7, ranAngle, 上腕角度, 下腕角度, 手角度, 開口, 開指, array);
		}

		public static void 両触手犬_基本(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u5 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u6 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u7 = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			Cha.触手犬_基本左(n, u, u2, u3, u4, u5, u6, u7);
			Cha.触手犬_基本右(n, u, u2, u3, u4, u5, u6, u7);
		}

		public static void 両触手犬_伏せ(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u5 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u6 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u7 = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			Cha.触手犬_伏せ左(n, u, u2, u3, u4, u5, u6, u7);
			Cha.触手犬_伏せ右(n, u, u2, u3, u4, u5, u6, u7);
		}

		public static void 両触手犬_威嚇(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u5 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u6 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u7 = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			Cha.触手犬_威嚇左(n, u, u2, u3, u4, u5, u6, u7);
			Cha.触手犬_威嚇右(n, u, u2, u3, u4, u5, u6, u7);
		}

		public static void 両触手犬_竦み(this Cha Cha, int n)
		{
			double u = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u2 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u3 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u5 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u6 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
			double u7 = Cha.角度ムラ(OthN.XS.NextSign(), 2.0, OthN.XS.NextSign(), 1.0);
			Cha.触手犬_竦み左(n, u, u2, u3, u4, u5, u6, u7);
			Cha.触手犬_竦み右(n, u, u2, u3, u4, u5, u6, u7);
		}

		public static void 両触手犬_0(this Cha Cha, int n, int i2)
		{
			Cha.触手犬右_0(i2, n, Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5), Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5), Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5), Cha.角度ムラ(OthN.XS.NextSign(), 0.5, OthN.XS.NextSign(), 0.5), Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5), Cha.角度ムラ(OthN.XS.NextSign(), 1.0, OthN.XS.NextSign(), 0.5), Cha.角度ムラ(OthN.XS.NextSign(), 1.0, OthN.XS.NextSign(), 0.5));
		}

		public static void 触手犬左_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7)
		{
			switch (i)
			{
			case 0:
				c.触手犬_基本左(n, u1, u2, u3, u4, u5, u6, u7);
				return;
			case 1:
				c.触手犬_伏せ左(n, u1, u2, u3, u4, u5, u6, u7);
				return;
			case 2:
				c.触手犬_威嚇左(n, u1, u2, u3, u4, u5, u6, u7);
				return;
			case 3:
				c.触手犬_竦み左(n, u1, u2, u3, u4, u5, u6, u7);
				return;
			default:
				return;
			}
		}

		public static void 触手犬右_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7)
		{
			switch (i)
			{
			case 0:
				c.触手犬_基本右(n, u1, u2, u3, u4, u5, u6, u7);
				return;
			case 1:
				c.触手犬_伏せ右(n, u1, u2, u3, u4, u5, u6, u7);
				return;
			case 2:
				c.触手犬_威嚇右(n, u1, u2, u3, u4, u5, u6, u7);
				return;
			case 3:
				c.触手犬_竦み右(n, u1, u2, u3, u4, u5, u6, u7);
				return;
			default:
				return;
			}
		}

		public static void 触手犬絶頂(this Cha Cha, double a)
		{
			foreach (触手_犬 触手_犬 in Cha.Bod.触手犬左)
			{
				触手_犬.X0Y0_脚後_上腕.AngleCont = a * OthN.XS.NextDouble();
				触手_犬.X0Y0_脚前_上腕.AngleCont = a * OthN.XS.NextDouble();
				触手_犬.X0Y0_頭_口膜_口膜1.AngleCont = a * OthN.XS.NextDouble();
				触手_犬.X0Y0_脚後_上腕.AngleCont = a * OthN.XS.NextDouble();
				触手_犬.X0Y0_脚後_下腕.AngleCont = a * OthN.XS.NextDouble();
				触手_犬.X0Y0_脚後_手_手.AngleCont = a * OthN.XS.NextDouble();
				触手_犬.X0Y0_脚前_上腕.AngleCont = a * OthN.XS.NextDouble();
				触手_犬.X0Y0_脚前_下腕.AngleCont = a * OthN.XS.NextDouble();
				触手_犬.X0Y0_脚前_手_手.AngleCont = a * OthN.XS.NextDouble();
				if (!触手_犬.拘束)
				{
					触手_犬.X0Y0_頭_上顎_眼下_眼下.AngleCont = a * OthN.XS.NextDouble();
					触手_犬.X0Y0_頭_下顎_眼下_眼下.AngleCont = a * OthN.XS.NextDouble();
				}
				触手_犬.X0Y0_脚後_手_親指_爪.AngleCont = a * OthN.XS.NextDouble();
				触手_犬.X0Y0_脚後_手_人指_指.AngleCont = a * OthN.XS.NextDouble();
				触手_犬.X0Y0_脚後_手_中指_指.AngleCont = a * OthN.XS.NextDouble();
				触手_犬.X0Y0_脚後_手_薬指_指.AngleCont = a * OthN.XS.NextDouble();
				触手_犬.X0Y0_脚後_手_小指_指.AngleCont = a * OthN.XS.NextDouble();
				触手_犬.X0Y0_脚前_手_親指_爪.AngleCont = a * OthN.XS.NextDouble();
				触手_犬.X0Y0_脚前_手_人指_指.AngleCont = a * OthN.XS.NextDouble();
				触手_犬.X0Y0_脚前_手_中指_指.AngleCont = a * OthN.XS.NextDouble();
				触手_犬.X0Y0_脚前_手_薬指_指.AngleCont = a * OthN.XS.NextDouble();
				触手_犬.X0Y0_脚前_手_小指_指.AngleCont = a * OthN.XS.NextDouble();
				foreach (Par par in 触手_犬.Enum軸())
				{
					par.AngleCont = a * OthN.XS.NextDouble();
				}
			}
			foreach (触手_犬 触手_犬2 in Cha.Bod.触手犬右)
			{
				触手_犬2.X0Y0_脚後_上腕.AngleCont = -a * OthN.XS.NextDouble();
				触手_犬2.X0Y0_脚前_上腕.AngleCont = -a * OthN.XS.NextDouble();
				触手_犬2.X0Y0_頭_口膜_口膜1.AngleCont = -a * OthN.XS.NextDouble();
				触手_犬2.X0Y0_脚後_上腕.AngleCont = -a * OthN.XS.NextDouble();
				触手_犬2.X0Y0_脚後_下腕.AngleCont = -a * OthN.XS.NextDouble();
				触手_犬2.X0Y0_脚後_手_手.AngleCont = -a * OthN.XS.NextDouble();
				触手_犬2.X0Y0_脚前_上腕.AngleCont = -a * OthN.XS.NextDouble();
				触手_犬2.X0Y0_脚前_下腕.AngleCont = -a * OthN.XS.NextDouble();
				触手_犬2.X0Y0_脚前_手_手.AngleCont = -a * OthN.XS.NextDouble();
				if (!触手_犬2.拘束)
				{
					触手_犬2.X0Y0_頭_上顎_眼下_眼下.AngleCont = -a * OthN.XS.NextDouble();
					触手_犬2.X0Y0_頭_下顎_眼下_眼下.AngleCont = -a * OthN.XS.NextDouble();
				}
				触手_犬2.X0Y0_脚後_手_親指_爪.AngleCont = -a * OthN.XS.NextDouble();
				触手_犬2.X0Y0_脚後_手_人指_指.AngleCont = -a * OthN.XS.NextDouble();
				触手_犬2.X0Y0_脚後_手_中指_指.AngleCont = -a * OthN.XS.NextDouble();
				触手_犬2.X0Y0_脚後_手_薬指_指.AngleCont = -a * OthN.XS.NextDouble();
				触手_犬2.X0Y0_脚後_手_小指_指.AngleCont = -a * OthN.XS.NextDouble();
				触手_犬2.X0Y0_脚前_手_親指_爪.AngleCont = -a * OthN.XS.NextDouble();
				触手_犬2.X0Y0_脚前_手_人指_指.AngleCont = -a * OthN.XS.NextDouble();
				触手_犬2.X0Y0_脚前_手_中指_指.AngleCont = -a * OthN.XS.NextDouble();
				触手_犬2.X0Y0_脚前_手_薬指_指.AngleCont = -a * OthN.XS.NextDouble();
				触手_犬2.X0Y0_脚前_手_小指_指.AngleCont = -a * OthN.XS.NextDouble();
				foreach (Par par2 in 触手_犬2.Enum軸())
				{
					par2.AngleCont = -a * OthN.XS.NextDouble();
				}
			}
		}

		public static void 尾(this Cha Cha, int n, int s, double 展開, double 根本角度, params Func<int, double>[] angs)
		{
			尾 尾 = Cha.Bod.尾[n];
			string text = 尾.接続情報.ToString();
			if (!text.Contains("左"))
			{
				尾.Set角度0();
				Par[] array = 尾.Enum軸().ToArray<Par>();
				double num = (尾 is 尾_蟲) ? 0.3 : 1.0;
				if (angs.Length != 0 && array.Length != 0)
				{
					int num2 = 0;
					int num3 = array.Length / angs.Length;
					if (num3 == 0)
					{
						num3 = 1;
					}
					double num4 = (double)array.Length * 0.1;
					double num5 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
					Par[] array2 = array;
					for (int i = 0; i < array2.Length; i++)
					{
						array2[i].AngleBase = ((double)s * angs[(num2 / num3).Limit(0, angs.Length)](num2) / num4 + num5) * num;
						num2++;
					}
					if (尾 is 尾_鳥)
					{
						array[0].AngleBase = 0.0;
					}
					else
					{
						array[0].AngleBase = 根本角度 + Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
					}
				}
				if (text.Contains("後髪0_肢系"))
				{
					double num6 = 1.0;
					foreach (Par par in array.Take(array.Length / 2))
					{
						par.AngleBase = par.AngleBase / num6 * num;
						num6 += 1.0;
					}
				}
				尾鰭_魚 ele = 尾.EnumEle().GetEle<尾鰭_魚>();
				if (ele != null)
				{
					ele.展開 = 展開 * Cha.ChaD.固有値 * OthN.XS.NextDouble();
				}
				else if (尾 is 尾_鳥)
				{
					((尾_鳥)尾).展開 = 展開 * Cha.ChaD.固有値 * OthN.XS.NextDouble();
				}
				if (尾.EnumEle().IsEle<尾鰭>())
				{
					尾.Set尾先角度();
				}
			}
		}

		public static void 尾_基本(this Cha Cha, int n)
		{
			Cha.尾(n, OthN.XS.NextSign(), OthN.XS.NextDouble(), 0.0, new Func<int, double>[0]);
		}

		public static void 尾_S字(this Cha Cha, int n)
		{
			int s = OthN.XS.NextSign();
			double 展開 = 0.5;
			double ranAngle = 10.0.GetRanAngle();
			Func<int, double>[] array = new Func<int, double>[2];
			array[0] = ((int i) => 25.0);
			array[1] = ((int i) => -25.0);
			Cha.尾(n, s, 展開, ranAngle, array);
		}

		public static void 尾_波(this Cha Cha, int n)
		{
			int s = OthN.XS.NextSign();
			double 展開 = 0.5;
			double ranAngle = 10.0.GetRanAngle();
			Func<int, double>[] array = new Func<int, double>[1];
			array[0] = ((int i) => Math.Sin((double)i) * 40.0);
			Cha.尾(n, s, 展開, ranAngle, array);
		}

		public static void 尾_ピ\u30FCン(this Cha Cha, int n)
		{
			int s = OthN.XS.NextSign();
			double 展開 = 1.0;
			double ranAngle = 10.0.GetRanAngle();
			Func<int, double>[] array = new Func<int, double>[2];
			array[0] = ((int i) => 0.0);
			array[1] = ((int i) => 25.0.GetRanAngle());
			Cha.尾(n, s, 展開, ranAngle, array);
		}

		public static void 尾_0(this Cha c, int n, int i)
		{
			switch (i)
			{
			case 0:
				c.尾_基本(n);
				return;
			case 1:
				c.尾_S字(n);
				return;
			case 2:
				c.尾_波(n);
				return;
			case 3:
				c.尾_ピ\u30FCン(n);
				return;
			default:
				return;
			}
		}

		public static void 尾絶頂(this Cha Cha, double a)
		{
			double 展開 = a * 0.015 * OthN.XS.NextDouble();
			foreach (尾 尾 in Cha.Bod.尾)
			{
				if (尾.右)
				{
					foreach (Par par in 尾.Enum軸())
					{
						par.AngleCont = -a * OthN.XS.NextDouble();
					}
					尾鰭_魚 ele = 尾.EnumEle().GetEle<尾鰭_魚>();
					if (ele != null)
					{
						ele.展開 = 展開;
					}
					else if (尾 is 尾_鳥)
					{
						((尾_鳥)尾).展開 = 展開;
					}
				}
				else
				{
					foreach (Par par2 in 尾.Enum軸())
					{
						par2.AngleCont = a * OthN.XS.NextDouble();
					}
					尾鰭_魚 ele2 = 尾.EnumEle().GetEle<尾鰭_魚>();
					if (ele2 != null)
					{
						ele2.展開 = 展開;
					}
					else if (尾 is 尾_鳥)
					{
						((尾_鳥)尾).展開 = 展開;
					}
				}
			}
		}

		public static void 長胴(this Cha Cha, int si, params Func<int, double>[] angs)
		{
			if (angs.Length != 0)
			{
				int num = 0;
				int num2 = Cha.Bod.長胴n / angs.Length;
				if (num2 == 0)
				{
					num2 = 1;
				}
				double num3 = (double)Cha.Bod.長胴n * 0.1;
				double num4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				foreach (長胴 長胴 in Cha.Bod.長胴.Skip(1))
				{
					長胴.角度B = (double)si * angs[(num / num2).Limit(0, angs.Length)](num) / num3 + num4;
					num++;
				}
			}
		}

		public static void 長胴_基本(this Cha Cha)
		{
			int si = OthN.XS.NextSign();
			Func<int, double>[] array = new Func<int, double>[1];
			array[0] = ((int i) => 4.0.GetRanAngle());
			Cha.長胴(si, array);
		}

		public static void 魚(this Cha Cha, int s, params Func<int, double>[] angs)
		{
			Par[] array = Cha.Bod.魚.軸列挙().ToArray<Par>();
			if (angs.Length != 0)
			{
				int num = 0;
				int num2 = array.Length / angs.Length;
				double num3 = (double)array.Length * 0.1;
				double num4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				Par[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i].AngleBase = (double)s * angs[(num / num2).Limit(0, angs.Length)](num) / num3 + num4;
					num++;
				}
			}
		}

		public static void 魚_基本(this Cha Cha)
		{
			int s = OthN.XS.NextSign();
			Func<int, double>[] array = new Func<int, double>[1];
			array[0] = ((int i) => 5.0.GetRanAngle());
			Cha.魚(s, array);
		}

		public static void 魚_S字(this Cha Cha)
		{
			int s = OthN.XS.NextSign();
			Func<int, double>[] array = new Func<int, double>[2];
			array[0] = ((int i) => 5.0);
			array[1] = ((int i) => -5.0);
			Cha.魚(s, array);
		}

		public static void 魚_波(this Cha Cha)
		{
			int s = OthN.XS.NextSign();
			Func<int, double>[] array = new Func<int, double>[1];
			array[0] = ((int i) => Math.Sin((double)i) * 5.0);
			Cha.魚(s, array);
		}

		public static void 魚_ピ\u30FCン(this Cha Cha)
		{
			int s = OthN.XS.NextSign();
			Func<int, double>[] array = new Func<int, double>[2];
			array[0] = ((int i) => 0.0);
			array[1] = ((int i) => 5.0.GetRanAngle());
			Cha.魚(s, array);
		}

		public static void 魚_0(this Cha c, int i)
		{
			switch (i)
			{
			case 0:
				c.魚_基本();
				return;
			case 1:
				c.魚_S字();
				return;
			case 2:
				c.魚_波();
				return;
			case 3:
				c.魚_ピ\u30FCン();
				return;
			default:
				return;
			}
		}

		public static void 魚絶頂(this Cha Cha, double a)
		{
			if (Cha.Bod.魚.右)
			{
				using (IEnumerator<Par> enumerator = Cha.Bod.魚.軸列挙().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Par par = enumerator.Current;
						par.AngleCont = -a * OthN.XS.NextDouble();
					}
					return;
				}
			}
			foreach (Par par2 in Cha.Bod.魚.軸列挙())
			{
				par2.AngleCont = a * OthN.XS.NextDouble();
			}
		}

		public static void 鯨(this Cha Cha, int s, params Func<int, double>[] angs)
		{
			Par[] array = Cha.Bod.鯨.軸列挙().ToArray<Par>();
			if (angs.Length != 0)
			{
				int num = 0;
				int num2 = array.Length / angs.Length;
				double num3 = (double)array.Length * 0.1;
				double num4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				Par[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i].AngleBase = (double)s * angs[(num / num2).Limit(0, angs.Length)](num) / num3 + num4;
					num++;
				}
			}
		}

		public static void 鯨_基本(this Cha Cha)
		{
			int s = OthN.XS.NextSign();
			Func<int, double>[] array = new Func<int, double>[1];
			array[0] = ((int i) => 5.0.GetRanAngle());
			Cha.鯨(s, array);
		}

		public static void 鯨_S字(this Cha Cha)
		{
			int s = OthN.XS.NextSign();
			Func<int, double>[] array = new Func<int, double>[2];
			array[0] = ((int i) => 5.0);
			array[1] = ((int i) => -5.0);
			Cha.鯨(s, array);
		}

		public static void 鯨_波(this Cha Cha)
		{
			int s = OthN.XS.NextSign();
			Func<int, double>[] array = new Func<int, double>[1];
			array[0] = ((int i) => Math.Sin((double)i) * 5.0);
			Cha.鯨(s, array);
		}

		public static void 鯨_ピ\u30FCン(this Cha Cha)
		{
			int s = OthN.XS.NextSign();
			Func<int, double>[] array = new Func<int, double>[2];
			array[0] = ((int i) => 0.0);
			array[1] = ((int i) => 5.0.GetRanAngle());
			Cha.鯨(s, array);
		}

		public static void 鯨_0(this Cha c, int i)
		{
			switch (i)
			{
			case 0:
				c.鯨_基本();
				return;
			case 1:
				c.鯨_S字();
				return;
			case 2:
				c.鯨_波();
				return;
			case 3:
				c.鯨_ピ\u30FCン();
				return;
			default:
				return;
			}
		}

		public static void 鯨絶頂(this Cha Cha, double a)
		{
			if (Cha.Bod.鯨.右)
			{
				using (IEnumerator<Par> enumerator = Cha.Bod.鯨.軸列挙().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Par par = enumerator.Current;
						par.AngleCont = -a * OthN.XS.NextDouble();
					}
					return;
				}
			}
			foreach (Par par2 in Cha.Bod.鯨.軸列挙())
			{
				par2.AngleCont = a * OthN.XS.NextDouble();
			}
		}

		public static void 蠍(this Cha Cha, int s, params Func<int, double>[] angs)
		{
			Par[] array = Cha.Bod.蠍.軸列挙().ToArray<Par>();
			if (angs.Length != 0)
			{
				int num = 0;
				int num2 = array.Length / angs.Length;
				double num3 = (double)array.Length * 0.1;
				double num4 = Cha.角度ムラ(OthN.XS.NextSign(), 3.0, OthN.XS.NextSign(), 1.5);
				Par[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i].AngleBase = (double)s * angs[(num / num2).Limit(0, angs.Length)](num) / num3 + num4;
					num++;
				}
			}
		}

		public static void 蠍_基本(this Cha Cha)
		{
			int s = OthN.XS.NextSign();
			Func<int, double>[] array = new Func<int, double>[1];
			array[0] = ((int i) => 5.0.GetRanAngle());
			Cha.蠍(s, array);
		}

		public static void 蠍_S字(this Cha Cha)
		{
			int s = OthN.XS.NextSign();
			Func<int, double>[] array = new Func<int, double>[2];
			array[0] = ((int i) => 5.0);
			array[1] = ((int i) => -5.0);
			Cha.蠍(s, array);
		}

		public static void 蠍_波(this Cha Cha)
		{
			int s = OthN.XS.NextSign();
			Func<int, double>[] array = new Func<int, double>[1];
			array[0] = ((int i) => Math.Sin((double)i) * 5.0);
			Cha.蠍(s, array);
		}

		public static void 蠍_ピ\u30FCン(this Cha Cha)
		{
			int s = OthN.XS.NextSign();
			Func<int, double>[] array = new Func<int, double>[2];
			array[0] = ((int i) => 0.0);
			array[1] = ((int i) => 5.0.GetRanAngle());
			Cha.蠍(s, array);
		}

		public static void 蠍_0(this Cha c, int i)
		{
			switch (i)
			{
			case 0:
				c.蠍_基本();
				return;
			case 1:
				c.蠍_S字();
				return;
			case 2:
				c.蠍_波();
				return;
			case 3:
				c.蠍_ピ\u30FCン();
				return;
			default:
				return;
			}
		}

		public static void 蠍絶頂(this Cha Cha, double a)
		{
			if (Cha.Bod.蠍.右)
			{
				using (IEnumerator<Par> enumerator = Cha.Bod.蠍.軸列挙().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Par par = enumerator.Current;
						par.AngleCont = -a * OthN.XS.NextDouble();
					}
					return;
				}
			}
			foreach (Par par2 in Cha.Bod.蠍.軸列挙())
			{
				par2.AngleCont = a * OthN.XS.NextDouble();
			}
		}

		public static void 植(this Cha Cha, int si, double 角度)
		{
			Cha.Bod.植.X0Y0_幹下.AngleBase = (double)si * 角度 + Cha.角度ムラ(OthN.XS.NextSign(), 10.0, OthN.XS.NextSign(), 5.0);
		}

		public static void 植_基本(this Cha Cha)
		{
			Cha.植(OthN.XS.NextSign(), 5.0.GetRanAngle());
		}

		public static void 植絶頂(this Cha Cha, double a)
		{
			if (Cha.Bod.植.右)
			{
				Cha.Bod.植.X0Y0_幹下.AngleCont = -a * OthN.XS.NextDouble();
				return;
			}
			Cha.Bod.植.X0Y0_幹下.AngleCont = a * OthN.XS.NextDouble();
		}

		public static void 表情_基本0(this Cha c)
		{
			c.両眉_無();
			c.両眉_下();
			c.両瞼_半1();
			c.両瞼_卑();
			c.口_閉笑();
		}

		public static void 表情_基本0眉上(this Cha c)
		{
			c.両眉_無();
			c.両眉_上();
			c.両瞼_半1();
			c.両瞼_卑();
			c.口_閉笑();
		}

		public static void 表情_基本1(this Cha c)
		{
			c.両眉_無();
			c.両眉_下();
			c.両瞼_半1();
			c.両瞼_卑();
			c.口_薄笑();
		}

		public static void 表情_基本1眉上(this Cha c)
		{
			c.両眉_無();
			c.両眉_上();
			c.両瞼_半1();
			c.両瞼_卑();
			c.口_薄笑();
		}

		public static void 表情_不敵0(this Cha c)
		{
			c.両眉_無();
			c.両眉_下();
			c.両瞼_半2();
			c.両瞼_卑();
			c.口_閉笑();
		}

		public static void 表情_不敵0眉上(this Cha c)
		{
			c.両眉_無();
			c.両眉_上();
			c.両瞼_半2();
			c.両瞼_卑();
			c.口_閉笑();
		}

		public static void 表情_不敵1(this Cha c)
		{
			c.両眉_無();
			c.両眉_下();
			c.両瞼_半2();
			c.両瞼_卑();
			c.口_薄笑();
		}

		public static void 表情_不敵1眉上(this Cha c)
		{
			c.両眉_無();
			c.両眉_上();
			c.両瞼_半2();
			c.両瞼_卑();
			c.口_薄笑();
		}

		public static void 表情_困り顔0(this Cha c)
		{
			c.両眉_顰();
			c.両眉_下();
			c.両瞼_半1();
			c.両瞼_卑();
			c.口_閉笑();
		}

		public static void 表情_困り顔1(this Cha c)
		{
			c.両眉_顰();
			c.両眉_下();
			c.両瞼_半1();
			c.両瞼_卑();
			c.口_薄笑();
		}

		public static void 表情_卑屈(this Cha c)
		{
			c.両眉_顰();
			c.両眉_下();
			c.両瞼_半2();
			c.両瞼_卑();
			c.口_薄笑();
		}

		public static void 表情_素0(this Cha c)
		{
			c.両眉_無();
			c.両眉_下();
			c.両瞼_半2();
			c.両瞼_卑();
			c.口_閉じ();
		}

		public static void 表情_素0眉上(this Cha c)
		{
			c.両眉_無();
			c.両眉_上();
			c.両瞼_半2();
			c.両瞼_卑();
			c.口_閉じ();
		}

		public static void 表情_素1(this Cha c)
		{
			c.両眉_無();
			c.両眉_下();
			c.両瞼_半1();
			c.両瞼_卑();
			c.口_半開1();
		}

		public static void 表情_素1眉上(this Cha c)
		{
			c.両眉_無();
			c.両眉_上();
			c.両瞼_半1();
			c.両瞼_卑();
			c.口_半開1();
		}

		public static void テンプレ()
		{
		}

		public static void メモ(Med Med, Cha 調教対象)
		{
			Bod bod = 調教対象.Bod;
			調教対象.Bod.拘束具_表示 = true;
			if (!調教対象.Bod.Setピアス.ピアス_表示)
			{
				調教対象.Bod.脱衣();
			}
		}

		public static IEnumerable<string> Enumパタ\u30FCン(int i1_0, int i2_0, int i1_1, int i2_1)
		{
			yield return string.Concat(new object[]
			{
				"\"",
				i1_0,
				",",
				i2_0,
				",",
				i1_1,
				",",
				i2_1,
				"\""
			});
			yield return string.Concat(new object[]
			{
				"\"",
				i2_0,
				",",
				i1_0,
				",",
				i1_1,
				",",
				i2_1,
				"\""
			});
			yield return string.Concat(new object[]
			{
				"\"",
				i1_0,
				",",
				i2_0,
				",",
				i2_1,
				",",
				i1_1,
				"\""
			});
			yield return string.Concat(new object[]
			{
				"\"",
				i2_0,
				",",
				i1_0,
				",",
				i2_1,
				",",
				i1_1,
				"\""
			});
			yield break;
		}

		public static void Update(this Cha c)
		{
			if (c.Bod.Is髪)
			{
				c.Bod.EI髪.Updatef = true;
			}
			if (c.Bod.Is胸)
			{
				c.Bod.EI胸.Updatef = true;
			}
			if (c.Bod.Is腰)
			{
				c.Bod.EI腰.Updatef = true;
			}
			if (c.Bod.Is腕前)
			{
				c.Bod.EI腕前.Updatef = true;
			}
			if (!c.絶頂.Run)
			{
				if (c.Bod.Is半後)
				{
					c.Bod.EI半後.Updatef = true;
				}
				if (c.Bod.Is半中1)
				{
					c.Bod.EI半中1.Updatef = true;
				}
				if (c.Bod.Is半中2)
				{
					c.Bod.EI半中2.Updatef = true;
				}
				if (c.Bod.Is半前)
				{
					c.Bod.EI半前.Updatef = true;
				}
				if (c.Bod.Is腿)
				{
					c.Bod.EI腿.Updatef = true;
				}
			}
		}

		public static void Set表情初期化(this Cha c)
		{
			c.眉();
			c.目();
			c.瞼();
			c.口();
			c.耳();
			c.顎();
		}

		public static void Set表情変化(this Cha c)
		{
			switch (OthN.XS.Next(6))
			{
			case 0:
				c.眉();
				return;
			case 1:
				c.目();
				return;
			case 2:
				c.瞼();
				return;
			case 3:
				c.口();
				return;
			case 4:
				c.耳();
				return;
			case 5:
				c.顎();
				return;
			default:
				return;
			}
		}

		public static void 眉(this Cha c)
		{
			感情 状態 = c.ChaD.状態;
			if (!c.Bod.Is双眉)
			{
				if (c.Bod.Is単眉)
				{
					c.単眉_0(Rea.単眉_0感情対応[状態][OthN.XS.Next(Rea.単眉_0感情対応[状態].Count)]);
					c.単眉_1(Rea.単眉_1感情対応[状態][OthN.XS.Next(Rea.単眉_1感情対応[状態].Count)]);
				}
				return;
			}
			if (状態 == 感情.受容 || 状態 == 感情.欲望 || 状態 == 感情.興奮 || 状態 == 感情.余裕 || 状態 == 感情.幸福 || 状態 == 感情.喜悦 || 状態 == 感情.淫乱 || 状態 == 感情.其他)
			{
				int num = Rea.眉_0感情対応[状態][OthN.XS.Next(Rea.眉_0感情対応[状態].Count)];
				c.両眉_0(OthN.XS.NextBool(), num, (num == 1) ? 2 : ((num == 2) ? 1 : ((num == 3) ? 4 : ((num == 4) ? 3 : num))));
				num = Rea.眉_1感情対応[状態][OthN.XS.Next(Rea.眉_1感情対応[状態].Count)];
				c.両眉_1(num, num);
				return;
			}
			c.両眉_0(OthN.XS.NextBool(), Rea.眉_0感情対応[状態][OthN.XS.Next(Rea.眉_0感情対応[状態].Count)], Rea.眉_0感情対応[状態][OthN.XS.Next(Rea.眉_0感情対応[状態].Count)]);
			c.両眉_1(Rea.眉_1感情対応[状態][OthN.XS.Next(Rea.眉_1感情対応[状態].Count)], Rea.眉_1感情対応[状態][OthN.XS.Next(Rea.眉_1感情対応[状態].Count)]);
		}

		public static void 目(this Cha c)
		{
			感情 状態 = c.ChaD.状態;
			if (c.Bod.Is双眼 || c.Bod.Is単眼 || c.Bod.Is頬眼 || c.Bod.Is額眼)
			{
				int num = Rea.目_0感情対応[状態][OthN.XS.Next(Rea.目_0感情対応[状態].Count)];
				if (c.ChaD.体力 < 0.3 && c.ChaD.感度 > 0.8 && c.ChaD.興奮 > 0.8 && c.ChaD.卑屈度 > 0.8 && 0.5.Lot())
				{
					num = 3;
				}
				if (c.Bod.Is双眼)
				{
					c.両目_0(num, num);
				}
				else if (c.Bod.Is単眼)
				{
					c.単目_0(num);
				}
				if (c.Bod.Is頬眼)
				{
					c.両頬目_0(num, num);
				}
				if (c.Bod.Is額眼)
				{
					c.額目_0(num);
				}
			}
		}

		public static void 瞼(this Cha c)
		{
			感情 状態 = c.ChaD.状態;
			if (c.Bod.Is双眼)
			{
				int num = Rea.瞼_0感情対応[状態][OthN.XS.Next(Rea.瞼_0感情対応[状態].Count)];
				c.両瞼_0(num, num);
				int num2 = c.Bod.目隠帯_表示 ? 3 : Rea.瞼_1感情対応[状態][OthN.XS.Next(Rea.瞼_1感情対応[状態].Count)];
				c.両瞼_1(num2, num2);
			}
			else if (c.Bod.Is単眼)
			{
				c.単瞼_0(Rea.単瞼_0感情対応[状態][OthN.XS.Next(Rea.単瞼_0感情対応[状態].Count)]);
				c.単瞼_1(c.Bod.目隠帯_表示 ? 3 : Rea.単瞼_1感情対応[状態][OthN.XS.Next(Rea.単瞼_1感情対応[状態].Count)]);
			}
			if (c.Bod.Is頬眼)
			{
				int num = Rea.頬瞼_0感情対応[状態][OthN.XS.Next(Rea.頬瞼_0感情対応[状態].Count)];
				c.両頬瞼_0(num, num);
				int num2 = c.Bod.目隠帯_表示 ? 3 : Rea.頬瞼_1感情対応[状態][OthN.XS.Next(Rea.頬瞼_1感情対応[状態].Count)];
				c.両頬瞼_1(num2, num2);
			}
			if (c.Bod.Is額眼)
			{
				c.額瞼_0(Rea.額瞼_0感情対応[状態][OthN.XS.Next(Rea.額瞼_0感情対応[状態].Count)]);
				c.額瞼_1(c.Bod.目隠帯_表示 ? 3 : Rea.額瞼_1感情対応[状態][OthN.XS.Next(Rea.額瞼_1感情対応[状態].Count)]);
			}
		}

		public static void 口(this Cha c)
		{
			感情 状態 = c.ChaD.状態;
			if (!Act.UI.Is口挿入 && !c.Bod.玉口枷_表示)
			{
				int num = Rea.口_0感情対応[状態][OthN.XS.Next(Rea.口_0感情対応[状態].Count)];
				c.口_0(num);
				if (c.Med.Mode == "調教" && Rea.舌可能.Contains(num) && c.ChaD.部位感度[接触.口] > 0.6 && c.ChaD.感度 > 0.6 && c.ChaD.興奮 > 0.6 && c.ChaD.緊張 < 0.5 && c.ChaD.抵抗値 == 0.0 && c.ChaD.欲望度 > 0.6 && c.ChaD.卑屈度 > 0.5 && 0.5.Lot())
				{
					num = 1;
				}
				else
				{
					num = 0;
				}
				c.舌_0(num);
			}
		}

		public static void 耳(this Cha c)
		{
			感情 状態 = c.ChaD.状態;
			if (c.Bod.Is人耳)
			{
				int num = Rea.耳_0感情対応[状態][OthN.XS.Next(Rea.耳_0感情対応[状態].Count)];
				c.両耳_0(num, num);
				return;
			}
			if (c.Bod.Is獣耳)
			{
				c.両獣耳_0(Rea.獣耳_0感情対応[状態][OthN.XS.Next(Rea.獣耳_0感情対応[状態].Count)], Rea.獣耳_0感情対応[状態][OthN.XS.Next(Rea.獣耳_0感情対応[状態].Count)]);
			}
		}

		public static void 触(this Cha c)
		{
			感情 状態 = c.ChaD.状態;
			if (!c.Bod.Is触覚他)
			{
				if (c.Bod.Is触覚甲)
				{
					if (状態 == 感情.受容 || 状態 == 感情.欲望 || 状態 == 感情.興奮 || 状態 == 感情.余裕 || 状態 == 感情.幸福 || 状態 == 感情.淫乱 || 状態 == 感情.其他)
					{
						int num = Rea.触覚甲_0感情対応[状態][OthN.XS.Next(Rea.触覚甲_0感情対応[状態].Count)];
						c.両触覚甲_0(OthN.XS.NextBool(), num, num);
						return;
					}
					c.両触覚甲_0(OthN.XS.NextBool(), Rea.触覚甲_0感情対応[状態][OthN.XS.Next(Rea.触覚甲_0感情対応[状態].Count)], Rea.触覚甲_0感情対応[状態][OthN.XS.Next(Rea.触覚甲_0感情対応[状態].Count)]);
				}
				return;
			}
			if (状態 == 感情.受容 || 状態 == 感情.欲望 || 状態 == 感情.興奮 || 状態 == 感情.余裕 || 状態 == 感情.幸福 || 状態 == 感情.淫乱 || 状態 == 感情.其他)
			{
				int num2 = Rea.触覚_0感情対応[状態][OthN.XS.Next(Rea.触覚_0感情対応[状態].Count)];
				c.両触覚_0(OthN.XS.NextBool(), num2, num2);
				return;
			}
			c.両触覚_0(OthN.XS.NextBool(), Rea.触覚_0感情対応[状態][OthN.XS.Next(Rea.触覚_0感情対応[状態].Count)], Rea.触覚_0感情対応[状態][OthN.XS.Next(Rea.触覚_0感情対応[状態].Count)]);
		}

		public static void 顎(this Cha c)
		{
			感情 状態 = c.ChaD.状態;
			if (c.Bod.虫顎n > 0)
			{
				int num = Rea.虫顎_0感情対応[状態][OthN.XS.Next(Rea.虫顎_0感情対応[状態].Count)];
				for (int i = 0; i < c.Bod.虫顎n; i++)
				{
					c.両虫顎_0(i, true, num, num);
				}
			}
			if (c.Bod.大顎n > 0)
			{
				int num = Rea.大顎_0感情対応[状態][OthN.XS.Next(Rea.大顎_0感情対応[状態].Count)];
				if (Act.UI.Is口挿入 || c.Bod.Is拘束)
				{
					num = 1;
				}
				for (int i = 0; i < c.Bod.大顎n; i++)
				{
					c.両大顎_0(i, true, num, num);
				}
			}
		}

		public static void Set姿勢初期化(this Cha c)
		{
			if (Sta.GameData.拘束具)
			{
				c.Set調教拘束姿勢(true);
				return;
			}
			c.Bod.腿左右前後 = OthN.XS.NextBool();
			c.腕();
			c.脚();
			c.翼();
			c.鰭();
			c.葉();
			c.翅();
			c.触肢();
			c.節足();
			c.節尾();
			c.虫鎌();
			c.触手();
			c.尾();
			c.半身();
			c.Set触手系対称化();
			c.Bod.Update();
		}

		public static void Set姿勢変化(this Cha c)
		{
			if (Sta.GameData.拘束具)
			{
				c.Set調教拘束姿勢(0.2.Lot());
				return;
			}
			if (0.35.Lot())
			{
				c.Bod.腿左右前後 = OthN.XS.NextBool();
			}
			switch (OthN.XS.Next(13))
			{
			case 0:
				c.腕();
				break;
			case 1:
				c.脚();
				break;
			case 2:
				c.翼();
				break;
			case 3:
				c.鰭();
				break;
			case 4:
				c.葉();
				break;
			case 5:
				c.翅();
				break;
			case 6:
				c.触肢();
				break;
			case 7:
				c.節足();
				break;
			case 8:
				c.節尾();
				break;
			case 9:
				c.虫鎌();
				break;
			case 10:
				if (0.1.Lot())
				{
					c.触手();
					c.Set触手系対称化();
				}
				break;
			case 11:
				c.尾();
				c.Set触手系対称化();
				break;
			case 12:
				c.半身();
				break;
			}
			c.Bod.Update();
		}

		public static void 腕(this Cha c)
		{
			if (!Act.UI.ペニス処理.手コキ.Run && !Act.UI.ペニス処理.Isパイズリ他動)
			{
				感情 状態 = c.ChaD.状態;
				if (c.Bod.腕人n > 0 && !Act.UI.ペニス処理.手固定)
				{
					int[] array;
					if (c.ChaD.撮影ピ\u30FCス経験)
					{
						IEnumerable<int> source;
						if (!c.Bod.Is獣 && !c.Is放尿() && !Act.Is性器接触)
						{
							IEnumerable<int> enumerable = Rea.腕人_0感情対応[状態];
							source = enumerable;
						}
						else
						{
							source = from e in Rea.腕人_0感情対応[状態]
							where e != 8 && e != 9
							select e;
						}
						array = source.ToArray<int>();
					}
					else
					{
						IEnumerable<int> source2;
						if (!c.Bod.Is獣 && !c.Is放尿() && !Act.Is性器接触)
						{
							IEnumerable<int> enumerable = Rea.腕人_0感情対応[状態];
							source2 = enumerable;
						}
						else
						{
							source2 = from e in Rea.腕人_0感情対応[状態]
							where e != 8 && e != 9
							select e;
						}
						array = (from e in source2
						where e != 15
						select e).ToArray<int>();
					}
					bool flag = false;
					if (Act.UI.Is口挿入 || (flag = (Act.UI.ペニス処理.Is手コキ || Act.UI.ペニス処理.Isパイズリ || Act.UI.ハンド処理.Is乳繰り || Act.UI.ハンド処理.Is乳摘み || Act.UI.ハンド処理.Is乳捏ね || Act.接触n == 接触.乳)))
					{
						IEnumerable<int> source3 = from e in array
						where e != 4 && e != 5 && e != 6 && e != 10 && e != 11 && e != 12
						select e;
						if (flag)
						{
							source3 = from e in source3
							where e != 1 && e != 3 && e != 16 && e != 17
							select e;
						}
						array = source3.ToArray<int>();
						if (array.Length == 0)
						{
							if (!flag)
							{
								array = new int[]
								{
									0,
									1,
									2,
									3,
									7,
									13,
									18
								};
							}
							else
							{
								array = new int[]
								{
									0,
									2,
									7,
									13,
									18
								};
							}
						}
					}
					for (int i = 0; i < c.Bod.腕人n; i++)
					{
						c.両腕人_0(i, OthN.XS.NextBool(), OthN.XS.NextBool(), OthN.XS.NextBool(), array[OthN.XS.Next(array.Length)], array[OthN.XS.Next(array.Length)]);
					}
				}
				if (c.Bod.腕翼鳥n > 0)
				{
					int num = Rea.腕翼鳥_0感情対応[状態][OthN.XS.Next(Rea.腕翼鳥_0感情対応[状態].Count)];
					for (int i = 0; i < c.Bod.腕翼鳥n; i++)
					{
						c.両腕翼鳥_0(i, OthN.XS.NextBool(), num, num);
					}
				}
				if (c.Bod.腕翼獣n > 0)
				{
					int num = Rea.腕翼獣_0感情対応[状態][OthN.XS.Next(Rea.腕翼獣_0感情対応[状態].Count)];
					for (int i = 0; i < c.Bod.腕翼獣n; i++)
					{
						c.両腕翼獣_0(i, OthN.XS.NextBool(), num, num);
					}
				}
				if (c.Bod.腕獣n > 0)
				{
					int num = Rea.腕獣_0感情対応[状態][OthN.XS.Next(Rea.腕獣_0感情対応[状態].Count)];
					for (int i = 0; i < c.Bod.腕獣n; i++)
					{
						c.両腕獣_0(i, OthN.XS.NextBool(), num, num);
					}
				}
			}
		}

		public static void 脚(this Cha c)
		{
			if (!Act.UI.ペニス処理.足コキ.Run)
			{
				感情 状態 = c.ChaD.状態;
				int num = 0;
				if (c.Bod.脚人n > 0 && !Act.UI.ペニス処理.足固定 && !c.Bod.Is粘 && !c.Bod.Is植)
				{
					if (Act.UI.Is脚修正1)
					{
						if (Rea.脚人_0感情対応[状態].Any((int e) => e != 1 && e != 2 && e != 4 && e != 5))
						{
							do
							{
								num = Rea.脚人_0感情対応[状態][OthN.XS.Next(Rea.脚人_0感情対応[状態].Count)];
							}
							while (num == 1 || num == 2 || num == 4 || num == 5);
						}
						else
						{
							switch (OthN.XS.Next(5))
							{
							case 0:
								num = 0;
								break;
							case 1:
								num = 3;
								break;
							case 2:
								num = 6;
								break;
							case 3:
								num = 7;
								break;
							case 4:
								num = 8;
								break;
							}
						}
					}
					else if (Act.UI.Is脚修正2)
					{
						if (Rea.脚人_0感情対応[状態].Any((int e) => e != 1 && e != 2))
						{
							do
							{
								num = Rea.脚人_0感情対応[状態][OthN.XS.Next(Rea.脚人_0感情対応[状態].Count)];
							}
							while (num == 1 || num == 2);
						}
						else
						{
							switch (OthN.XS.Next(7))
							{
							case 0:
								num = 0;
								break;
							case 1:
								num = 3;
								break;
							case 2:
								num = 4;
								break;
							case 3:
								num = 5;
								break;
							case 4:
								num = 6;
								break;
							case 5:
								num = 7;
								break;
							case 6:
								num = 8;
								break;
							}
						}
					}
					else
					{
						num = Rea.脚人_0感情対応[状態][OthN.XS.Next(Rea.脚人_0感情対応[状態].Count)];
					}
					for (int i = 0; i < c.Bod.脚人n; i++)
					{
						c.両脚人_0(0, OthN.XS.NextBool(), num, num);
					}
				}
				if (c.Bod.脚獣n > 0)
				{
					num = Rea.脚獣_0感情対応[状態][OthN.XS.Next(Rea.脚獣_0感情対応[状態].Count)];
					for (int i = 0; i < c.Bod.脚獣n; i++)
					{
						c.両脚獣_0(i, OthN.XS.NextBool(), num, num);
					}
				}
			}
		}

		public static void 翼(this Cha c)
		{
			感情 状態 = c.ChaD.状態;
			if (c.Bod.翼鳥n > 0)
			{
				int num = Rea.翼_0感情対応[状態][OthN.XS.Next(Rea.翼_0感情対応[状態].Count)];
				for (int i = 0; i < c.Bod.翼鳥n; i++)
				{
					c.両翼鳥_0(i, OthN.XS.NextBool(), num, num);
				}
			}
			if (c.Bod.翼獣n > 0)
			{
				int num2 = Rea.翼_0感情対応[状態][OthN.XS.Next(Rea.翼_0感情対応[状態].Count)];
				for (int j = 0; j < c.Bod.翼獣n; j++)
				{
					c.両翼獣_0(j, OthN.XS.NextBool(), num2, num2);
				}
			}
		}

		public static void 鰭(this Cha c)
		{
			感情 状態 = c.ChaD.状態;
			if (c.Bod.鰭n > 0)
			{
				int num = Rea.鰭_0感情対応[状態][OthN.XS.Next(Rea.鰭_0感情対応[状態].Count)];
				for (int i = 0; i < c.Bod.鰭n; i++)
				{
					c.両鰭_0(i, OthN.XS.NextBool(), num, num);
				}
			}
		}

		public static void 葉(this Cha c)
		{
			感情 状態 = c.ChaD.状態;
			if (c.Bod.葉n > 0)
			{
				int num = Rea.葉_0感情対応[状態][OthN.XS.Next(Rea.葉_0感情対応[状態].Count)];
				for (int i = 0; i < c.Bod.葉n; i++)
				{
					c.両葉_0(i, OthN.XS.NextBool(), num, num);
				}
			}
		}

		public static void 翅(this Cha c)
		{
			感情 状態 = c.ChaD.状態;
			if (c.Bod.前翅1n > 0 || c.Bod.後翅1n > 0)
			{
				int num = Rea.前翅_0感情対応[状態][OthN.XS.Next(Rea.前翅_0感情対応[状態].Count)];
				if (c.Bod.前翅1n > 0)
				{
					for (int i = 0; i < c.Bod.前翅1n; i++)
					{
						c.両前翅_0(i, true, num, num);
					}
				}
				if (c.Bod.後翅1n > 0)
				{
					for (int i = 0; i < c.Bod.後翅1n; i++)
					{
						c.両後翅_0(i, true, num, num);
					}
				}
			}
			if (c.Bod.前翅2n > 0 || c.Bod.後翅2n > 0)
			{
				int num = Rea.前翅_1感情対応[状態][OthN.XS.Next(Rea.前翅_1感情対応[状態].Count)];
				if (c.Bod.前翅2n > 0)
				{
					for (int i = 0; i < c.Bod.前翅2n; i++)
					{
						c.両前翅_1(i, num, num);
					}
				}
				if (c.Bod.後翅2n > 0)
				{
					for (int i = 0; i < c.Bod.後翅2n; i++)
					{
						c.両後翅_1(i, num, num);
					}
				}
			}
		}

		public static void 触肢(this Cha c)
		{
			感情 状態 = c.ChaD.状態;
			if (c.Bod.触肢蜘n > 0)
			{
				int num = Rea.触肢蜘_0感情対応[状態][OthN.XS.Next(Rea.触肢蜘_0感情対応[状態].Count)];
				for (int i = 0; i < c.Bod.触肢蜘n; i++)
				{
					c.両触肢蜘_0(i, OthN.XS.NextBool(), num, num);
				}
			}
			if (c.Bod.触肢蠍n > 0)
			{
				int num = Rea.触肢蠍_0感情対応[状態][OthN.XS.Next(Rea.触肢蠍_0感情対応[状態].Count)];
				for (int i = 0; i < c.Bod.触肢蠍n; i++)
				{
					c.両触肢蠍_0(i, OthN.XS.NextBool(), num, num);
				}
			}
		}

		public static void 節足(this Cha c)
		{
			感情 状態 = c.ChaD.状態;
			if (c.Bod.節足蜘n > 0)
			{
				int num = Rea.節足蜘_0感情対応[状態][OthN.XS.Next(Rea.節足蜘_0感情対応[状態].Count)];
				for (int i = 0; i < c.Bod.節足蜘n; i++)
				{
					c.両節足蜘_0(i, OthN.XS.NextBool(), num, num);
				}
			}
			if (c.Bod.節足蠍n > 0)
			{
				int num = Rea.節足蠍_0感情対応[状態][OthN.XS.Next(Rea.節足蠍_0感情対応[状態].Count)];
				for (int i = 0; i < c.Bod.節足蠍n; i++)
				{
					c.両節足蠍_0(i, OthN.XS.NextBool(), num, num);
				}
			}
			if (c.Bod.節足百n > 0)
			{
				int num = Rea.節足百_0感情対応[状態][OthN.XS.Next(Rea.節足百_0感情対応[状態].Count)];
				for (int i = 0; i < c.Bod.節足百n; i++)
				{
					c.両節足百_0(i, OthN.XS.NextBool(), num, num);
				}
			}
		}

		public static void 節尾(this Cha c)
		{
			感情 状態 = c.ChaD.状態;
			if (c.Bod.節尾曳n > 0)
			{
				int num = Rea.節尾曳_0感情対応[状態][OthN.XS.Next(Rea.節尾曳_0感情対応[状態].Count)];
				for (int i = 0; i < c.Bod.節尾曳n; i++)
				{
					c.両節尾曳_0(i, OthN.XS.NextBool(), num, num);
				}
			}
			if (c.Bod.節尾鋏n > 0)
			{
				int num = Rea.節尾鋏_0感情対応[状態][OthN.XS.Next(Rea.節尾鋏_0感情対応[状態].Count)];
				for (int i = 0; i < c.Bod.節尾鋏n; i++)
				{
					c.両節尾鋏_0(i, OthN.XS.NextBool(), num, num);
				}
			}
		}

		public static void 虫鎌(this Cha c)
		{
			感情 状態 = c.ChaD.状態;
			if (c.Bod.虫鎌n > 0)
			{
				int num = Rea.虫鎌_0感情対応[状態][OthN.XS.Next(Rea.虫鎌_0感情対応[状態].Count)];
				for (int i = 0; i < c.Bod.虫鎌n; i++)
				{
					c.両虫鎌_0(i, OthN.XS.NextBool(), num, num);
				}
			}
		}

		public static void 触手(this Cha c)
		{
			感情 状態 = c.ChaD.状態;
			if (c.Bod.触手n > 0)
			{
				for (int i = 0; i < c.Bod.触手n; i++)
				{
					c.両触手_0(i, Rea.触手_0感情対応[状態][OthN.XS.Next(Rea.触手_0感情対応[状態].Count)]);
				}
			}
			if (c.Bod.触手犬n > 0)
			{
				for (int i = 0; i < c.Bod.触手犬n; i++)
				{
					c.両触手犬_0(i, Rea.触手犬_0感情対応[状態][OthN.XS.Next(Rea.触手犬_0感情対応[状態].Count)]);
				}
			}
		}

		public static void 尾(this Cha c)
		{
			感情 状態 = c.ChaD.状態;
			if (c.Bod.尾n > 0)
			{
				int i = Rea.尾_0感情対応[状態][OthN.XS.Next(Rea.尾_0感情対応[状態].Count)];
				for (int j = 0; j < c.Bod.尾n; j++)
				{
					c.尾_0(j, i);
				}
			}
		}

		public static void 半身(this Cha c)
		{
			感情 状態 = c.ChaD.状態;
			if (c.Bod.長胴n > 0)
			{
				c.長胴_基本();
			}
			if (c.Bod.Is魚)
			{
				c.魚_0(Rea.魚_0感情対応[状態][OthN.XS.Next(Rea.魚_0感情対応[状態].Count)]);
			}
			if (c.Bod.Is鯨)
			{
				c.鯨_0(Rea.鯨_0感情対応[状態][OthN.XS.Next(Rea.鯨_0感情対応[状態].Count)]);
			}
			if (c.Bod.Is蠍)
			{
				c.蠍_0(Rea.蠍_0感情対応[状態][OthN.XS.Next(Rea.蠍_0感情対応[状態].Count)]);
			}
			if (c.Bod.Is植)
			{
				c.植_基本();
			}
			if (c.Bod.Is粘)
			{
				c.Bod.粘.尺度C = 0.9 + 0.1 * OthN.XS.NextDouble();
			}
		}

		public static void Set基本姿勢(this Cha c)
		{
			if (0.35.Lot())
			{
				c.Bod.腿左右前後 = OthN.XS.NextBool();
			}
			if (c.Bod.腕人n > 0)
			{
				int num = 7;
				for (int i = 0; i < c.Bod.腕人n; i++)
				{
					c.両腕人_0(i, OthN.XS.NextBool(), true, OthN.XS.NextBool(), num, num);
				}
			}
			if (c.Bod.腕翼鳥n > 0)
			{
				int num = Rea.腕翼鳥_0基本[OthN.XS.Next(Rea.腕翼鳥_0基本.Length)];
				for (int j = 0; j < c.Bod.腕翼鳥n; j++)
				{
					c.両腕翼鳥_0(j, true, num, num);
				}
			}
			if (c.Bod.腕翼獣n > 0)
			{
				int num = Rea.腕翼獣_0基本[OthN.XS.Next(Rea.腕翼獣_0基本.Length)];
				for (int k = 0; k < c.Bod.腕翼獣n; k++)
				{
					c.両腕翼獣_0(k, true, num, num);
				}
			}
			if (c.Bod.腕獣n > 0)
			{
				int num = Rea.腕獣_0基本[OthN.XS.Next(Rea.腕獣_0基本.Length)];
				for (int l = 0; l < c.Bod.腕獣n; l++)
				{
					c.両腕獣_0(l, true, num, num);
				}
			}
			if (!c.Bod.Is粘 && !c.Bod.Is植 && c.Bod.脚人n > 0)
			{
				for (int m = 0; m < c.Bod.脚人n; m++)
				{
					c.両脚人_0(0, true, Rea.脚人_0基本[OthN.XS.Next(Rea.脚人_0基本.Length)], Rea.脚人_0基本[OthN.XS.Next(Rea.脚人_0基本.Length)]);
				}
			}
			if (c.Bod.脚獣n > 0)
			{
				int num = Rea.脚獣_0基本[OthN.XS.Next(Rea.脚獣_0基本.Length)];
				for (int n = 0; n < c.Bod.脚獣n; n++)
				{
					c.両脚獣_0(n, true, num, num);
				}
			}
			if (c.Bod.翼鳥n > 0)
			{
				int num = Rea.翼_0基本[OthN.XS.Next(Rea.翼_0基本.Length)];
				for (int num2 = 0; num2 < c.Bod.翼鳥n; num2++)
				{
					c.両翼鳥_0(num2, true, num, num);
				}
			}
			if (c.Bod.翼獣n > 0)
			{
				int num = Rea.翼_0基本[OthN.XS.Next(Rea.翼_0基本.Length)];
				for (int num3 = 0; num3 < c.Bod.翼獣n; num3++)
				{
					c.両翼獣_0(num3, true, num, num);
				}
			}
			if (c.Bod.鰭n > 0)
			{
				int num = Rea.鰭_0基本[OthN.XS.Next(Rea.鰭_0基本.Length)];
				for (int num4 = 0; num4 < c.Bod.鰭n; num4++)
				{
					c.両鰭_0(num4, true, num, num);
				}
			}
			if (c.Bod.葉n > 0)
			{
				int num = Rea.葉_0基本[OthN.XS.Next(Rea.葉_0基本.Length)];
				for (int num5 = 0; num5 < c.Bod.葉n; num5++)
				{
					c.両葉_0(num5, true, num, num);
				}
			}
			if (c.Bod.前翅1n > 0 || c.Bod.後翅1n > 0)
			{
				int num = Rea.前翅_0基本[OthN.XS.Next(Rea.前翅_0基本.Length)];
				if (c.Bod.前翅1n > 0)
				{
					for (int num6 = 0; num6 < c.Bod.前翅1n; num6++)
					{
						c.両前翅_0(num6, true, num, num);
					}
				}
				if (c.Bod.後翅1n > 0)
				{
					for (int num7 = 0; num7 < c.Bod.後翅1n; num7++)
					{
						c.両後翅_0(num7, true, num, num);
					}
				}
			}
			if (c.Bod.前翅2n > 0 || c.Bod.後翅2n > 0)
			{
				int num8 = Rea.前翅_1基本[OthN.XS.Next(Rea.前翅_1基本.Length)];
				if (c.Bod.前翅2n > 0)
				{
					for (int num9 = 0; num9 < c.Bod.前翅2n; num9++)
					{
						c.両前翅_1(num9, num8, num8);
					}
				}
				if (c.Bod.後翅2n > 0)
				{
					for (int num10 = 0; num10 < c.Bod.後翅2n; num10++)
					{
						c.両後翅_1(num10, num8, num8);
					}
				}
			}
			if (c.Bod.触肢蜘n > 0)
			{
				int num = Rea.触肢蜘_0基本[OthN.XS.Next(Rea.触肢蜘_0基本.Length)];
				for (int num11 = 0; num11 < c.Bod.触肢蜘n; num11++)
				{
					c.両触肢蜘_0(num11, true, num, num);
				}
			}
			if (c.Bod.触肢蠍n > 0)
			{
				int num = Rea.触肢蠍_0基本[OthN.XS.Next(Rea.触肢蠍_0基本.Length)];
				for (int num12 = 0; num12 < c.Bod.触肢蠍n; num12++)
				{
					c.両触肢蠍_0(num12, true, num, num);
				}
			}
			if (c.Bod.節足蜘n > 0)
			{
				int num = Rea.節足蜘_0基本[OthN.XS.Next(Rea.節足蜘_0基本.Length)];
				for (int num13 = 0; num13 < c.Bod.節足蜘n; num13++)
				{
					c.両節足蜘_0(num13, true, num, num);
				}
			}
			if (c.Bod.節足蠍n > 0)
			{
				int num = Rea.節足蠍_0基本[OthN.XS.Next(Rea.節足蠍_0基本.Length)];
				for (int num14 = 0; num14 < c.Bod.節足蠍n; num14++)
				{
					c.両節足蠍_0(num14, true, num, num);
				}
			}
			if (c.Bod.節足百n > 0)
			{
				int num = Rea.節足百_0基本[OthN.XS.Next(Rea.節足百_0基本.Length)];
				for (int num15 = 0; num15 < c.Bod.節足百n; num15++)
				{
					c.両節足百_0(num15, true, num, num);
				}
			}
			if (c.Bod.節尾曳n > 0)
			{
				int num = Rea.節尾曳_0基本[OthN.XS.Next(Rea.節尾曳_0基本.Length)];
				for (int num16 = 0; num16 < c.Bod.節尾曳n; num16++)
				{
					c.両節尾曳_0(num16, true, num, num);
				}
			}
			if (c.Bod.節尾鋏n > 0)
			{
				int num = Rea.節尾鋏_0基本[OthN.XS.Next(Rea.節尾鋏_0基本.Length)];
				for (int num17 = 0; num17 < c.Bod.節尾鋏n; num17++)
				{
					c.両節尾鋏_0(num17, true, num, num);
				}
			}
			if (c.Bod.虫鎌n > 0)
			{
				int num = Rea.虫鎌_0基本[OthN.XS.Next(Rea.虫鎌_0基本.Length)];
				for (int num18 = 0; num18 < c.Bod.虫鎌n; num18++)
				{
					c.両虫鎌_0(num18, true, num, num);
				}
			}
			if (c.Bod.触手n > 0)
			{
				for (int num19 = 0; num19 < c.Bod.触手n; num19++)
				{
					c.両触手_0(num19, Rea.触手_0基本[OthN.XS.Next(Rea.触手_0基本.Length)]);
				}
			}
			if (c.Bod.触手犬n > 0)
			{
				for (int num20 = 0; num20 < c.Bod.触手犬n; num20++)
				{
					c.両触手犬_0(num20, Rea.触手犬_0基本[OthN.XS.Next(Rea.触手犬_0基本.Length)]);
				}
			}
			if (c.Bod.尾n > 0)
			{
				int num = Rea.尾_0基本[OthN.XS.Next(Rea.尾_0基本.Length)];
				for (int num21 = 0; num21 < c.Bod.尾n; num21++)
				{
					c.尾_0(num21, num);
				}
			}
			if (c.Bod.触手n > 0 || c.Bod.触手犬n > 0 || c.Bod.尾n > 0)
			{
				c.Set触手系対称化();
			}
			if (c.Bod.長胴n > 0)
			{
				c.長胴_基本();
			}
			if (c.Bod.Is魚)
			{
				c.魚_0(Rea.魚_0基本[OthN.XS.Next(Rea.魚_0基本.Length)]);
			}
			if (c.Bod.Is鯨)
			{
				c.鯨_0(Rea.鯨_0基本[OthN.XS.Next(Rea.鯨_0基本.Length)]);
			}
			if (c.Bod.Is蠍)
			{
				c.蠍_0(Rea.蠍_0基本[OthN.XS.Next(Rea.蠍_0基本.Length)]);
			}
			if (c.Bod.Is植)
			{
				c.植_基本();
			}
			if (c.Bod.Is粘)
			{
				c.Bod.粘.尺度C = 0.9 + 0.1 * OthN.XS.NextDouble();
			}
			c.Bod.Update();
		}

		public static void Set拘束姿勢(this Cha c)
		{
			if (0.35.Lot())
			{
				c.Bod.腿左右前後 = OthN.XS.NextBool();
			}
			if (c.Bod.腕人n > 0)
			{
				int num = 7;
				for (int i = 0; i < c.Bod.腕人n; i++)
				{
					c.両腕人_0(i, OthN.XS.NextBool(), true, OthN.XS.NextBool(), num, num);
				}
			}
			if (c.Bod.腕翼鳥n > 0)
			{
				int num = 4;
				for (int j = 0; j < c.Bod.腕翼鳥n; j++)
				{
					c.両腕翼鳥_0(j, true, num, num);
				}
			}
			if (c.Bod.腕翼獣n > 0)
			{
				int num = 2;
				for (int k = 0; k < c.Bod.腕翼獣n; k++)
				{
					c.両腕翼獣_0(k, true, num, num);
				}
			}
			if (c.Bod.腕獣n > 0)
			{
				int num = Rea.腕獣_0基本[OthN.XS.Next(Rea.腕獣_0基本.Length)];
				for (int l = 0; l < c.Bod.腕獣n; l++)
				{
					c.両腕獣_0(l, true, num, num);
				}
			}
			if (!c.Bod.Is粘 && !c.Bod.Is植 && c.Bod.脚人n > 0)
			{
				for (int m = 0; m < c.Bod.脚人n; m++)
				{
					c.両脚人_0(0, true, Rea.脚人_0基本[OthN.XS.Next(Rea.脚人_0基本.Length)], Rea.脚人_0基本[OthN.XS.Next(Rea.脚人_0基本.Length)]);
				}
			}
			if (c.Bod.脚獣n > 0)
			{
				int num = Rea.脚獣_0基本[OthN.XS.Next(Rea.脚獣_0基本.Length)];
				for (int n = 0; n < c.Bod.脚獣n; n++)
				{
					c.両脚獣_0(n, true, num, num);
				}
			}
			if (c.Bod.翼鳥n > 0)
			{
				int num = 4;
				for (int num2 = 0; num2 < c.Bod.翼鳥n; num2++)
				{
					c.両翼鳥_0(num2, true, num, num);
				}
			}
			if (c.Bod.翼獣n > 0)
			{
				int num = 4;
				for (int num3 = 0; num3 < c.Bod.翼獣n; num3++)
				{
					c.両翼獣_0(num3, true, num, num);
				}
			}
			if (c.Bod.鰭n > 0)
			{
				int num = Rea.鰭_0基本[OthN.XS.Next(Rea.鰭_0基本.Length)];
				for (int num4 = 0; num4 < c.Bod.鰭n; num4++)
				{
					c.両鰭_0(num4, true, num, num);
				}
			}
			if (c.Bod.葉n > 0)
			{
				int num = Rea.葉_0基本[OthN.XS.Next(Rea.葉_0基本.Length)];
				for (int num5 = 0; num5 < c.Bod.葉n; num5++)
				{
					c.両葉_0(num5, true, num, num);
				}
			}
			if (c.Bod.前翅1n > 0 || c.Bod.後翅1n > 0)
			{
				int num = Rea.前翅_0基本[OthN.XS.Next(Rea.前翅_0基本.Length)];
				if (c.Bod.前翅1n > 0)
				{
					for (int num6 = 0; num6 < c.Bod.前翅1n; num6++)
					{
						c.両前翅_0(num6, true, num, num);
					}
				}
				if (c.Bod.後翅1n > 0)
				{
					for (int num7 = 0; num7 < c.Bod.後翅1n; num7++)
					{
						c.両後翅_0(num7, true, num, num);
					}
				}
			}
			if (c.Bod.前翅2n > 0 || c.Bod.後翅2n > 0)
			{
				int num8 = 0;
				if (c.Bod.前翅2n > 0)
				{
					for (int num9 = 0; num9 < c.Bod.前翅2n; num9++)
					{
						c.両前翅_1(num9, num8, num8);
					}
				}
				if (c.Bod.後翅2n > 0)
				{
					for (int num10 = 0; num10 < c.Bod.後翅2n; num10++)
					{
						c.両後翅_1(num10, num8, num8);
					}
				}
			}
			if (c.Bod.触肢蜘n > 0)
			{
				int num = Rea.触肢蜘_0拘束[OthN.XS.Next(Rea.触肢蜘_0拘束.Length)];
				for (int num11 = 0; num11 < c.Bod.触肢蜘n; num11++)
				{
					c.両触肢蜘_0(num11, true, num, num);
				}
			}
			if (c.Bod.触肢蠍n > 0)
			{
				int num = Rea.触肢蠍_0拘束[OthN.XS.Next(Rea.触肢蠍_0拘束.Length)];
				for (int num12 = 0; num12 < c.Bod.触肢蠍n; num12++)
				{
					c.両触肢蠍_0(num12, true, num, num);
				}
			}
			if (c.Bod.節足蜘n > 0)
			{
				int num = Rea.節足蜘_0基本[OthN.XS.Next(Rea.節足蜘_0基本.Length)];
				for (int num13 = 0; num13 < c.Bod.節足蜘n; num13++)
				{
					c.両節足蜘_0(num13, true, num, num);
				}
			}
			if (c.Bod.節足蠍n > 0)
			{
				int num = Rea.節足蠍_0基本[OthN.XS.Next(Rea.節足蠍_0基本.Length)];
				for (int num14 = 0; num14 < c.Bod.節足蠍n; num14++)
				{
					c.両節足蠍_0(num14, true, num, num);
				}
			}
			if (c.Bod.節足百n > 0)
			{
				int num = Rea.節足百_0基本[OthN.XS.Next(Rea.節足百_0基本.Length)];
				for (int num15 = 0; num15 < c.Bod.節足百n; num15++)
				{
					c.両節足百_0(num15, true, num, num);
				}
			}
			if (c.Bod.節尾曳n > 0)
			{
				int num = Rea.節尾曳_0基本[OthN.XS.Next(Rea.節尾曳_0基本.Length)];
				for (int num16 = 0; num16 < c.Bod.節尾曳n; num16++)
				{
					c.両節尾曳_0(num16, true, num, num);
				}
			}
			if (c.Bod.節尾鋏n > 0)
			{
				int num = Rea.節尾鋏_0基本[OthN.XS.Next(Rea.節尾鋏_0基本.Length)];
				for (int num17 = 0; num17 < c.Bod.節尾鋏n; num17++)
				{
					c.両節尾鋏_0(num17, true, num, num);
				}
			}
			if (c.Bod.虫鎌n > 0)
			{
				int num = 0;
				for (int num18 = 0; num18 < c.Bod.虫鎌n; num18++)
				{
					c.両虫鎌_0(num18, true, num, num);
				}
			}
			if (c.Bod.触手n > 0)
			{
				for (int num19 = 0; num19 < c.Bod.触手n; num19++)
				{
					c.両触手_0(num19, Rea.触手_0基本[OthN.XS.Next(Rea.触手_0基本.Length)]);
				}
			}
			if (c.Bod.触手犬n > 0)
			{
				for (int num20 = 0; num20 < c.Bod.触手犬n; num20++)
				{
					c.両触手犬_0(num20, Rea.触手犬_0基本[OthN.XS.Next(Rea.触手犬_0基本.Length)]);
				}
			}
			if (c.Bod.尾n > 0)
			{
				int num = Rea.尾_0基本[OthN.XS.Next(Rea.尾_0基本.Length)];
				for (int num21 = 0; num21 < c.Bod.尾n; num21++)
				{
					c.尾_0(num21, num);
				}
			}
			if (c.Bod.触手n > 0 || c.Bod.触手犬n > 0 || c.Bod.尾n > 0)
			{
				c.Set触手系対称化();
			}
			if (c.Bod.長胴n > 0)
			{
				c.長胴_基本();
			}
			if (c.Bod.Is魚)
			{
				c.魚_0(Rea.魚_0基本[OthN.XS.Next(Rea.魚_0基本.Length)]);
			}
			if (c.Bod.Is鯨)
			{
				c.鯨_0(Rea.鯨_0基本[OthN.XS.Next(Rea.鯨_0基本.Length)]);
			}
			if (c.Bod.Is蠍)
			{
				c.蠍_0(Rea.蠍_0基本[OthN.XS.Next(Rea.蠍_0基本.Length)]);
			}
			if (c.Bod.Is植)
			{
				c.植_基本();
			}
			if (c.Bod.Is粘)
			{
				c.Bod.粘.尺度C = 0.9 + 0.1 * OthN.XS.NextDouble();
			}
			c.Bod.Update();
		}

		public static void Set調教拘束姿勢(this Cha c, bool b)
		{
			if (0.35.Lot())
			{
				c.Bod.腿左右前後 = OthN.XS.NextBool();
			}
			if (c.Bod.腕人n > 0)
			{
				int num = 18;
				for (int i = 0; i < c.Bod.腕人n; i++)
				{
					c.両腕人_0(i, OthN.XS.NextBool(), OthN.XS.NextBool(), OthN.XS.NextBool(), num, num);
				}
			}
			if (c.Bod.腕翼鳥n > 0)
			{
				int num = 4;
				for (int j = 0; j < c.Bod.腕翼鳥n; j++)
				{
					c.両腕翼鳥_0(j, OthN.XS.NextBool(), num, num);
				}
			}
			if (c.Bod.腕翼獣n > 0)
			{
				int num = 2;
				for (int k = 0; k < c.Bod.腕翼獣n; k++)
				{
					c.両腕翼獣_0(k, OthN.XS.NextBool(), num, num);
				}
			}
			if (c.Bod.腕獣n > 0)
			{
				int num = 0;
				for (int l = 0; l < c.Bod.腕獣n; l++)
				{
					c.両腕獣_0(l, OthN.XS.NextBool(), num, num);
				}
			}
			if (!c.Bod.Is粘 && !c.Bod.Is植 && c.Bod.脚人n > 0)
			{
				int num = 8;
				for (int m = 0; m < c.Bod.脚人n; m++)
				{
					c.両脚人_0(0, OthN.XS.NextBool(), num, num);
				}
			}
			if (c.Bod.脚獣n > 0)
			{
				int num = 0;
				for (int n = 0; n < c.Bod.脚獣n; n++)
				{
					c.両脚獣_0(n, OthN.XS.NextBool(), num, num);
				}
			}
			if (c.Bod.翼鳥n > 0)
			{
				int num = 4;
				for (int num2 = 0; num2 < c.Bod.翼鳥n; num2++)
				{
					c.両翼鳥_0(num2, OthN.XS.NextBool(), num, num);
				}
			}
			if (c.Bod.翼獣n > 0)
			{
				int num = 4;
				for (int num3 = 0; num3 < c.Bod.翼獣n; num3++)
				{
					c.両翼獣_0(num3, OthN.XS.NextBool(), num, num);
				}
			}
			if (c.Bod.鰭n > 0)
			{
				int num = Rea.鰭_0基本[OthN.XS.Next(Rea.鰭_0基本.Length)];
				for (int num4 = 0; num4 < c.Bod.鰭n; num4++)
				{
					c.両鰭_0(num4, OthN.XS.NextBool(), num, num);
				}
			}
			if (c.Bod.葉n > 0)
			{
				int num = Rea.葉_0基本[OthN.XS.Next(Rea.葉_0基本.Length)];
				for (int num5 = 0; num5 < c.Bod.葉n; num5++)
				{
					c.両葉_0(num5, OthN.XS.NextBool(), num, num);
				}
			}
			if (c.Bod.前翅1n > 0 || c.Bod.後翅1n > 0)
			{
				int num = Rea.前翅_0基本[OthN.XS.Next(Rea.前翅_0基本.Length)];
				if (c.Bod.前翅1n > 0)
				{
					for (int num6 = 0; num6 < c.Bod.前翅1n; num6++)
					{
						c.両前翅_0(num6, true, num, num);
					}
				}
				if (c.Bod.後翅1n > 0)
				{
					for (int num7 = 0; num7 < c.Bod.後翅1n; num7++)
					{
						c.両後翅_0(num7, true, num, num);
					}
				}
			}
			if (c.Bod.前翅2n > 0 || c.Bod.後翅2n > 0)
			{
				int num8 = 0;
				if (c.Bod.前翅2n > 0)
				{
					for (int num9 = 0; num9 < c.Bod.前翅2n; num9++)
					{
						c.両前翅_1(num9, num8, num8);
					}
				}
				if (c.Bod.後翅2n > 0)
				{
					for (int num10 = 0; num10 < c.Bod.後翅2n; num10++)
					{
						c.両後翅_1(num10, num8, num8);
					}
				}
			}
			if (c.Bod.触肢蜘n > 0)
			{
				int num = 0;
				for (int num11 = 0; num11 < c.Bod.触肢蜘n; num11++)
				{
					c.両触肢蜘_0(num11, OthN.XS.NextBool(), num, num);
				}
			}
			if (c.Bod.触肢蠍n > 0)
			{
				int num = 0;
				for (int num12 = 0; num12 < c.Bod.触肢蠍n; num12++)
				{
					c.両触肢蠍_0(num12, OthN.XS.NextBool(), num, num);
				}
			}
			if (c.Bod.節足蜘n > 0)
			{
				int num = 0;
				for (int num13 = 0; num13 < c.Bod.節足蜘n; num13++)
				{
					c.両節足蜘_0(num13, OthN.XS.NextBool(), num, num);
				}
			}
			if (c.Bod.節足蠍n > 0)
			{
				int num = 0;
				for (int num14 = 0; num14 < c.Bod.節足蠍n; num14++)
				{
					c.両節足蠍_0(num14, OthN.XS.NextBool(), num, num);
				}
			}
			if (c.Bod.節足百n > 0)
			{
				int num = 0;
				for (int num15 = 0; num15 < c.Bod.節足百n; num15++)
				{
					c.両節足百_0(num15, OthN.XS.NextBool(), num, num);
				}
			}
			if (c.Bod.節尾曳n > 0)
			{
				int num = 0;
				for (int num16 = 0; num16 < c.Bod.節尾曳n; num16++)
				{
					c.両節尾曳_0(num16, OthN.XS.NextBool(), num, num);
				}
			}
			if (c.Bod.節尾鋏n > 0)
			{
				int num = 0;
				for (int num17 = 0; num17 < c.Bod.節尾鋏n; num17++)
				{
					c.両節尾鋏_0(num17, OthN.XS.NextBool(), num, num);
				}
			}
			if (c.Bod.虫鎌n > 0)
			{
				int num = 0;
				for (int num18 = 0; num18 < c.Bod.虫鎌n; num18++)
				{
					c.両虫鎌_0(num18, OthN.XS.NextBool(), num, num);
				}
			}
			if (b)
			{
				int 触手n = c.Bod.触手n;
				if (c.Bod.触手犬n > 0)
				{
					for (int num19 = 0; num19 < c.Bod.触手犬n; num19++)
					{
						c.両触手犬_0(num19, Rea.触手犬_0基本[OthN.XS.Next(Rea.触手犬_0基本.Length)]);
					}
				}
				if (c.Bod.尾n > 0)
				{
					int num = Rea.尾_0基本[OthN.XS.Next(Rea.尾_0基本.Length)];
					for (int num20 = 0; num20 < c.Bod.尾n; num20++)
					{
						c.尾_0(num20, num);
					}
				}
			}
			if ((b && (c.Bod.触手n > 0 || c.Bod.触手犬n > 0)) || c.Bod.尾n > 0)
			{
				c.Set触手系対称化();
			}
			if (c.Bod.Is魚)
			{
				c.魚_0(Rea.魚_0基本[OthN.XS.Next(Rea.魚_0基本.Length)]);
			}
			if (c.Bod.Is鯨)
			{
				c.鯨_0(Rea.鯨_0基本[OthN.XS.Next(Rea.鯨_0基本.Length)]);
			}
			if (c.Bod.Is蠍)
			{
				c.蠍_0(Rea.蠍_0基本[OthN.XS.Next(Rea.蠍_0基本.Length)]);
			}
			if (c.Bod.Is植)
			{
				c.植_基本();
			}
			c.Bod.Update();
		}

		public static void Setダブルピ\u30FCス(this Cha c)
		{
			if (c.Bod.腕人n > 0)
			{
				int num = 15;
				for (int i = 0; i < c.Bod.腕人n; i++)
				{
					c.両腕人_0(i, OthN.XS.NextBool(), OthN.XS.NextBool(), OthN.XS.NextBool(), num, num);
				}
			}
		}

		public const int 眉_0数 = 5;

		public static Dictionary<感情, List<int>> 眉_0感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					3,
					4
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					3,
					4
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					0,
					3,
					4
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					0,
					3,
					4
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					0
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					0
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					0,
					3,
					4
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					0,
					3,
					4
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0
				}
			}
		};

		public const int 眉_1数 = 2;

		public static Dictionary<感情, List<int>> 眉_1感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					0
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					0
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					1
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					1
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					1
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					1
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					1
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0,
					1
				}
			}
		};

		public const int 単眉_0数 = 3;

		public static Dictionary<感情, List<int>> 単眉_0感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					1
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					2
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					2
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					0,
					2
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					0,
					2
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					0
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					0
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					0,
					2
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					0,
					2
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0
				}
			}
		};

		public const int 単眉_1数 = 2;

		public static Dictionary<感情, List<int>> 単眉_1感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					0
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					0
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					1
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					1
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					1
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					1
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					1
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0,
					1
				}
			}
		};

		public const int 目_0数 = 4;

		public static Dictionary<感情, List<int>> 目_0感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					0,
					1,
					2
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					0
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					0
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					0
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					0
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					0
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					0
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0
				}
			}
		};

		public const int 頬目_0数 = 4;

		public static Dictionary<感情, List<int>> 頬目_0感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					0,
					1,
					2
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					0
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					0
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					0
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					0
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					0
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					0
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0
				}
			}
		};

		public const int 額目_0数 = 4;

		public static Dictionary<感情, List<int>> 額目_0感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					0,
					1,
					2
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					0
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					0
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					0
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					0
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					0
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					0
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0
				}
			}
		};

		public const int 単目_0数 = 4;

		public static Dictionary<感情, List<int>> 単目_0感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					0,
					1,
					2
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					0
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					0
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					0
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					0
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					0
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					0
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0
				}
			}
		};

		private static HashSet<string> 瞼NGパタ\u30FCン = new HashSet<string>
		{
			"0,1,3,3",
			"1,0,3,3",
			"1,0,1,2",
			"0,1,1,2",
			"1,0,2,1",
			"0,1,2,1",
			"0,1,2,2",
			"1,0,2,2",
			"0,1,2,0",
			"1,0,2,0",
			"0,1,0,2",
			"1,0,0,2",
			"1,0,2,3",
			"0,1,2,3",
			"1,0,3,2",
			"0,1,3,2",
			"0,0,2,0",
			"0,0,0,2",
			"1,0,0,3",
			"0,1,0,3",
			"1,0,3,0",
			"0,1,3,0",
			"0,0,0,3",
			"0,0,3,0",
			"0,0,1,2",
			"0,0,2,1",
			"1,0,1,3",
			"0,1,1,3",
			"1,0,3,1",
			"0,1,3,1",
			"0,0,3,2",
			"0,0,2,3",
			"0,0,3,1",
			"0,0,1,3",
			"1,0,0,0",
			"0,1,0,0"
		};

		public const int 瞼_0数 = 2;

		public static Dictionary<感情, List<int>> 瞼_0感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					1
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					1
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					1
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0,
					1
				}
			}
		};

		public const int 頬瞼_0数 = 2;

		public static Dictionary<感情, List<int>> 頬瞼_0感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					1
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					1
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					1
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0,
					1
				}
			}
		};

		public const int 額瞼_0数 = 2;

		public static Dictionary<感情, List<int>> 額瞼_0感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					1
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					1
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					1
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0,
					1
				}
			}
		};

		public const int 単瞼_0数 = 2;

		public static Dictionary<感情, List<int>> 単瞼_0感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					1
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					1
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					1
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0,
					1
				}
			}
		};

		public const int 瞼_1数 = 4;

		public static Dictionary<感情, List<int>> 瞼_1感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					1
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					1
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					1,
					2,
					3
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					0
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					0,
					1,
					3
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0,
					1
				}
			}
		};

		public const int 頬瞼_1数 = 4;

		public static Dictionary<感情, List<int>> 頬瞼_1感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					1
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					1
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					1,
					2,
					3
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					0
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					0,
					1,
					3
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0,
					1
				}
			}
		};

		public const int 額瞼_1数 = 4;

		public static Dictionary<感情, List<int>> 額瞼_1感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					1
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					1
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					1,
					2,
					3
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					0
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					0,
					1,
					3
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0,
					1
				}
			}
		};

		public const int 単瞼_1数 = 4;

		public static Dictionary<感情, List<int>> 単瞼_1感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					1
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					1
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					1,
					2,
					3
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					0
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					0,
					1,
					3
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0,
					1
				}
			}
		};

		public const int 口_0数 = 14;

		public static Dictionary<感情, List<int>> 口_0感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					0,
					9,
					10
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					9,
					10,
					11
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					0,
					9,
					10,
					11
				}
			},
			{
				感情.受容,
				new List<int>
				{
					4
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					3,
					5,
					6,
					12
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					3,
					6,
					12
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					4,
					5,
					6,
					7
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					4,
					5,
					6
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					5,
					6
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					3,
					5,
					6,
					12
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0,
					4
				}
			}
		};

		public static HashSet<int> 舌可能 = new HashSet<int>
		{
			3,
			6,
			12,
			13
		};

		public const int 舌_0数 = 2;

		public const int 耳_0数 = 3;

		public static Dictionary<感情, List<int>> 耳_0感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					2
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					0
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					0
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					0
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					0
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0,
					1
				}
			}
		};

		public const int 獣耳_0数 = 3;

		public static Dictionary<感情, List<int>> 獣耳_0感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					2
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					0
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					0
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					0
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					0
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0,
					1
				}
			}
		};

		public const int 触覚_0数 = 3;

		public static Dictionary<感情, List<int>> 触覚_0感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					2
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					2
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					2
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					1
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					0
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					1
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0
				}
			}
		};

		public const int 触覚甲_0数 = 3;

		public static Dictionary<感情, List<int>> 触覚甲_0感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					2
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					2
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					2
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					1
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					0
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					1
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0
				}
			}
		};

		public const int 大顎_0数 = 3;

		public static int[] 大顎_0基本 = new int[]
		{
			0,
			1,
			2
		};

		public static Dictionary<感情, List<int>> 大顎_0感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					1
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					2
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					2
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					1
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					0
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					1
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0
				}
			}
		};

		public const int 虫顎_0数 = 3;

		public static int[] 虫顎_0基本 = new int[]
		{
			0,
			1,
			2
		};

		public static Dictionary<感情, List<int>> 虫顎_0感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					1
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					2
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					2
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					1
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					0
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					1
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0
				}
			}
		};

		public const int 腕人_0数 = 19;

		public static int[] 腕人_0基本 = new int[]
		{
			7
		};

		public static Dictionary<感情, List<int>> 腕人_0感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					7
				}
			},
			{
				感情.否定,
				new List<int>
				{
					1,
					8
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					0,
					3,
					6,
					7
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					1,
					4,
					5,
					6,
					8,
					10,
					11,
					12
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0,
					3,
					6,
					7,
					18
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					6,
					9,
					13,
					17
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					2,
					7,
					13,
					18
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					7,
					13,
					14
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					0,
					3,
					7
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					3,
					4,
					5,
					6,
					10,
					11,
					12,
					15,
					18
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					2,
					6,
					9,
					13,
					14,
					15,
					17,
					18
				}
			},
			{
				感情.其他,
				new List<int>
				{
					3,
					6,
					7,
					14
				}
			}
		};

		public const int 腕翼鳥_0数 = 7;

		public static int[] 腕翼鳥_0基本 = new int[]
		{
			4,
			5
		};

		public static Dictionary<感情, List<int>> 腕翼鳥_0感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					4
				}
			},
			{
				感情.否定,
				new List<int>
				{
					1,
					5
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					0,
					2
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					1,
					2,
					3
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0,
					5
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					5,
					6
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					0,
					5,
					6
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					4
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					0,
					4
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					1,
					2,
					5,
					6
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					0,
					1,
					5,
					6
				}
			},
			{
				感情.其他,
				new List<int>
				{
					4,
					5,
					6
				}
			}
		};

		public const int 腕翼獣_0数 = 5;

		public static int[] 腕翼獣_0基本 = new int[]
		{
			2,
			3
		};

		public static Dictionary<感情, List<int>> 腕翼獣_0感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					2
				}
			},
			{
				感情.否定,
				new List<int>
				{
					1,
					3
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					0
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					1
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0,
					3
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					3,
					4
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					0,
					3,
					4
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					2
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					0,
					2
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					1,
					3,
					4
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					0,
					1,
					3,
					4
				}
			},
			{
				感情.其他,
				new List<int>
				{
					2,
					3,
					4
				}
			}
		};

		public const int 腕獣_0数 = 3;

		public static int[] 腕獣_0基本 = new int[]
		{
			0,
			1,
			2
		};

		public static Dictionary<感情, List<int>> 腕獣_0感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					0,
					2
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					1
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					2
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					2
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					0
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					1
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					2
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0,
					2
				}
			}
		};

		public const int 脚人_0数 = 10;

		public static int[] 脚人_0基本 = new int[]
		{
			5
		};

		public static Dictionary<感情, List<int>> 脚人_0感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					5
				}
			},
			{
				感情.否定,
				new List<int>
				{
					1,
					2,
					4
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					0,
					3,
					4
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					1,
					2,
					4
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0,
					3,
					8
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					0,
					7,
					8,
					9
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					6,
					8
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					5,
					8
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					3,
					8
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					0,
					4,
					6,
					8
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					0,
					3,
					6,
					7,
					8,
					9
				}
			},
			{
				感情.其他,
				new List<int>
				{
					4,
					5
				}
			}
		};

		public const int 脚獣_0数 = 3;

		public static int[] 脚獣_0基本 = new int[]
		{
			0,
			1,
			2
		};

		public static Dictionary<感情, List<int>> 脚獣_0感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					1
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0,
					2
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					0,
					2
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					0,
					2
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					2
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					1
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0,
					1
				}
			}
		};

		public const int 翼鳥_0数 = 7;

		public const int 翼獣_0数 = 7;

		public static int[] 翼_0基本 = new int[]
		{
			0,
			5
		};

		public static Dictionary<感情, List<int>> 翼_0感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					4
				}
			},
			{
				感情.否定,
				new List<int>
				{
					1,
					5
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					0,
					1,
					2
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					1,
					2,
					3
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0,
					4,
					5
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					5,
					6
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					0,
					5,
					6
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					0,
					4,
					5
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					0,
					4,
					5
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					1,
					2,
					5,
					6
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					0,
					1,
					5,
					6
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0,
					4,
					5,
					6
				}
			}
		};

		public const int 鰭_0数 = 3;

		public static int[] 鰭_0基本 = new int[]
		{
			0,
			1,
			2
		};

		public static Dictionary<感情, List<int>> 鰭_0感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					0,
					2
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					2
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0,
					2
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					1
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					1
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					2
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					2
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0,
					2
				}
			}
		};

		public const int 葉_0数 = 3;

		public static int[] 葉_0基本 = new int[]
		{
			0,
			1,
			2
		};

		public static Dictionary<感情, List<int>> 葉_0感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					2
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0,
					2
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					1
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					1
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					0,
					2
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					2
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0,
					2
				}
			}
		};

		public const int 前翅_0数 = 3;

		public static int[] 前翅_0基本 = new int[]
		{
			0,
			1,
			2
		};

		public static Dictionary<感情, List<int>> 前翅_0感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					2
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					1
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					1
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					0
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					2
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					1
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0
				}
			}
		};

		public const int 前翅_1数 = 3;

		public static int[] 前翅_1基本 = new int[]
		{
			0,
			1,
			2
		};

		public static Dictionary<感情, List<int>> 前翅_1感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					0,
					2
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					0
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					0
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					2
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					2
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					0
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					2
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					0,
					1,
					2
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0,
					1,
					2
				}
			}
		};

		public const int 後翅_0数 = 3;

		public static int[] 後翅_0基本 = new int[]
		{
			0,
			1,
			2
		};

		public static Dictionary<感情, List<int>> 後翅_0感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					2
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					1
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					1
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					0
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					2
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					1
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0
				}
			}
		};

		public const int 後翅_1数 = 3;

		public static int[] 後翅_1基本 = new int[]
		{
			0,
			1,
			2
		};

		public static Dictionary<感情, List<int>> 後翅_1感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					0,
					2
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					0
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					0
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					2
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					2
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					0
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					2
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					0,
					1,
					2
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0,
					1,
					2
				}
			}
		};

		public const int 触肢蜘_0数 = 3;

		public static int[] 触肢蜘_0基本 = new int[]
		{
			0,
			1,
			2
		};

		public static int[] 触肢蜘_0拘束 = new int[]
		{
			0,
			1
		};

		public static Dictionary<感情, List<int>> 触肢蜘_0感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					0,
					2
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					1
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					2
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					2
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					0
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					2
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0
				}
			}
		};

		public const int 触肢蠍_0数 = 3;

		public static int[] 触肢蠍_0基本 = new int[]
		{
			0,
			1,
			2
		};

		public static int[] 触肢蠍_0拘束 = new int[1];

		public static Dictionary<感情, List<int>> 触肢蠍_0感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					0,
					2
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					1
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					2
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					2
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					0
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					2
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0
				}
			}
		};

		public const int 節足蜘_0数 = 3;

		public static int[] 節足蜘_0基本 = new int[]
		{
			0,
			1,
			2
		};

		public static Dictionary<感情, List<int>> 節足蜘_0感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					1
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					2
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					2
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					0
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0
				}
			}
		};

		public const int 節足蠍_0数 = 3;

		public static int[] 節足蠍_0基本 = new int[]
		{
			0,
			1,
			2
		};

		public static Dictionary<感情, List<int>> 節足蠍_0感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					1
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					2
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					2
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					0
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0
				}
			}
		};

		public const int 節足百_0数 = 3;

		public static int[] 節足百_0基本 = new int[]
		{
			0,
			1,
			2
		};

		public static Dictionary<感情, List<int>> 節足百_0感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					1
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					2
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					2
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					0
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0
				}
			}
		};

		public const int 節尾曳_0数 = 3;

		public static int[] 節尾曳_0基本 = new int[]
		{
			0,
			1,
			2
		};

		public static Dictionary<感情, List<int>> 節尾曳_0感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					1
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					2
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					2
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					0
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0
				}
			}
		};

		public const int 節尾鋏_0数 = 3;

		public static int[] 節尾鋏_0基本 = new int[]
		{
			0,
			1,
			2
		};

		public static Dictionary<感情, List<int>> 節尾鋏_0感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					1
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					2
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					2
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					0
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0
				}
			}
		};

		public const int 虫鎌_0数 = 3;

		public static int[] 虫鎌_0基本 = new int[1];

		public static Dictionary<感情, List<int>> 虫鎌_0感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					2
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					0
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					0,
					2
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					0,
					1,
					2
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0
				}
			}
		};

		public const int 触手_0数 = 4;

		public static int[] 触手_0基本 = new int[]
		{
			1
		};

		public static Dictionary<感情, List<int>> 触手_0感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					1
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					0,
					2
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					0,
					2
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					1
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					0,
					2
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					0,
					2
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					0,
					1,
					2,
					3
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0,
					1
				}
			}
		};

		public const int 触手犬_0数 = 4;

		public static int[] 触手犬_0基本 = new int[]
		{
			0,
			1,
			2,
			3
		};

		public static Dictionary<感情, List<int>> 触手犬_0感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					2
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					1,
					3
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					1,
					3
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					1,
					2,
					3
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					2,
					3
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					0
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					1
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					2,
					3
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					1,
					3
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0,
					1
				}
			}
		};

		public const int 尾_0数 = 4;

		public static int[] 尾_0基本 = new int[]
		{
			0,
			1,
			2,
			3
		};

		public static Dictionary<感情, List<int>> 尾_0感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					2
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					1
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					1,
					2,
					3
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					1,
					2,
					3
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0,
					1
				}
			}
		};

		public const int 長胴_0数 = 1;

		public const int 魚_0数 = 4;

		public static int[] 魚_0基本 = new int[]
		{
			0,
			1,
			2,
			3
		};

		public static Dictionary<感情, List<int>> 魚_0感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					2
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					1
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					1,
					2,
					3
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					1,
					2,
					3
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0,
					1
				}
			}
		};

		public const int 鯨_0数 = 4;

		public static int[] 鯨_0基本 = new int[]
		{
			0,
			1,
			2,
			3
		};

		public static Dictionary<感情, List<int>> 鯨_0感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					2
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					1
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					1,
					2,
					3
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					1,
					2,
					3
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0,
					1
				}
			}
		};

		public const int 蠍_0数 = 4;

		public static int[] 蠍_0基本 = new int[]
		{
			0,
			1,
			2,
			3
		};

		public static Dictionary<感情, List<int>> 蠍_0感情対応 = new Dictionary<感情, List<int>>
		{
			{
				感情.none,
				new List<int>
				{
					0
				}
			},
			{
				感情.否定,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.屈辱,
				new List<int>
				{
					2
				}
			},
			{
				感情.羞恥,
				new List<int>
				{
					1,
					2
				}
			},
			{
				感情.受容,
				new List<int>
				{
					0
				}
			},
			{
				感情.欲望,
				new List<int>
				{
					1
				}
			},
			{
				感情.興奮,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.余裕,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.幸福,
				new List<int>
				{
					0,
					1
				}
			},
			{
				感情.喜悦,
				new List<int>
				{
					1,
					2,
					3
				}
			},
			{
				感情.淫乱,
				new List<int>
				{
					1,
					2,
					3
				}
			},
			{
				感情.其他,
				new List<int>
				{
					0,
					1
				}
			}
		};

		public const int 植_0数 = 1;
	}
}
