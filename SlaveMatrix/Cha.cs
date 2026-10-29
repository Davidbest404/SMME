using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class Cha
	{
		public double 呼吸速度
		{
			get
			{
				return this.呼吸速度_;
			}
			set
			{
				this.呼吸速度_ = value;
				this.呼吸.BaseSpeed = 6.0 * this.呼吸速度_;
			}
		}

		public bool 泣き
		{
			get
			{
				return this.泣き_;
			}
			set
			{
				this.泣き_ = value;
				if (!this.泣き_)
				{
					this.涙ひき.Sta();
				}
			}
		}

		public void 放尿強制終了()
		{
			this.放尿強制終了_();
		}

		public double 呼吸値
		{
			get
			{
				return this.呼吸_;
			}
			set
			{
				this.呼吸_ = value;
				this.Bod.胸.尺度C = 0.99 + 0.02 * this.呼吸_;
				this.Bod.胸肌_人.尺度C = this.Bod.胸.尺度C;
				this.p.Y = this.y * this.呼吸_ * 0.5;
				if (this.Bod.Is髪)
				{
					this.Bod.EI髪.Position = this.p;
				}
				if (this.Bod.Is腕前)
				{
					this.Bod.EI腕前.Position = this.p;
				}
				this.p.Y = this.y * this.呼吸_ * 0.28;
				if (this.Bod.Is胸)
				{
					this.Bod.EI胸.Position = this.p;
				}
				this.p.Y = -this.p.Y;
				this.Bod.腰.位置C = this.p;
				if (this.Bod.Is腰)
				{
					this.Bod.EI腰.Position = this.p;
				}
				if (this.Bod.Is半後)
				{
					this.Bod.EI半後.Position = this.p;
				}
				if (this.Bod.Is半中1)
				{
					this.Bod.EI半中1.Position = this.p;
				}
				if (this.Bod.Is半中2)
				{
					this.Bod.EI半中2.Position = this.p;
				}
				if (this.Bod.Is半前)
				{
					this.Bod.EI半前.Position = this.p;
				}
				if (this.Bod.Is腿)
				{
					this.Bod.EI腿.Position = this.p;
				}
			}
		}

		public double 中出度
		{
			get
			{
				if (this.Bod.カ\u30FCソル != null)
				{
					return (1.0 / (double)(this.Bod.カ\u30FCソル.ペニス処理.中出しCount + 1)).Inverse();
				}
				return 0.0;
			}
		}

		public Cha(Med Med, Are Are, ChaD ChaD)
		{
			Cha.<>c__DisplayClass77_0 CS$<>8__locals1 = new Cha.<>c__DisplayClass77_0();
			CS$<>8__locals1.ChaD = ChaD;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			Cha.<>c__DisplayClass77_1 CS$<>8__locals2 = new Cha.<>c__DisplayClass77_1();
			CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
			this.Med = Med;
			this.Are = Are;
			this.ChaD = CS$<>8__locals2.CS$<>8__locals1.ChaD;
			this.配色 = new 体配色(CS$<>8__locals2.CS$<>8__locals1.ChaD.体色);
			double disUnit = Are.DisUnit;
			this.Bod = new Bod(Med, Are, this);
			this.重髪 = (this.Bod.Is髪 && this.Bod.EI髪.IsHeavy());
			this.重胸 = (this.Bod.Is胸 && this.Bod.EI胸.IsHeavy());
			this.重腰 = (this.Bod.Is腰 && this.Bod.EI腰.IsHeavy());
			this.重腕前 = (this.Bod.Is腕前 && this.Bod.EI腕前.IsHeavy());
			this.重半後 = (this.Bod.Is半後 && this.Bod.EI半後.IsHeavy());
			this.重半中1 = (this.Bod.Is半中1 && this.Bod.EI半中1.IsHeavy());
			this.重半中2 = (this.Bod.Is半中2 && this.Bod.EI半中2.IsHeavy());
			this.重半前 = (this.Bod.Is半前 && this.Bod.EI半前.IsHeavy());
			this.重腿 = (this.Bod.Is腿 && this.Bod.EI腿.IsHeavy());
			double 尺度C = this.Bod.胸.尺度C;
			this.Bod.胸.尺度C = 0.99;
			double num = this.Bod.胸.X0Y0_胸郭.ToGlobal(this.Bod.胸.X0Y0_胸郭.JP[0].Joint).Y;
			this.Bod.胸.尺度C = 1.01;
			double num2 = this.Bod.胸.X0Y0_胸郭.ToGlobal(this.Bod.胸.X0Y0_胸郭.JP[0].Joint).Y;
			this.Bod.胸.尺度C = 尺度C;
			this.y = num2 - num;
			Mot mot = new Mot(0.0, 1.0);
			mot.LowestIncrease = 0.25;
			mot.BaseSpeed = 6.0 * this.呼吸速度_;
			mot.Staing = delegate(Mot m)
			{
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.呼気.濃度 = 0.0;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.呼気.表示 = true;
			};
			mot.Runing = delegate(Mot m)
			{
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.呼気.濃度 = m.Value.Inverse() * CS$<>8__locals2.CS$<>8__locals1.<>4__this.呼吸速度_;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.呼吸値 = m.Value;
			};
			mot.Reaing = delegate(Mot m)
			{
			};
			mot.Rouing = delegate(Mot m)
			{
			};
			mot.Ending = delegate(Mot m)
			{
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.呼気.表示 = false;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.呼気.濃度 = 1.0;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.呼吸値 = 0.0;
			};
			this.呼吸 = mot;
			this.Mots.Add(this.呼吸.GetHashCode().ToString(), this.呼吸);
			this.呼吸速度 = 0.2;
			this.呼吸.Sta();
			bool go = true;
			bool 涙左 = this.Bod.涙左 != null;
			bool 涙右 = this.Bod.涙右 != null;
			Mot mot2 = new Mot(0.0, 1.0);
			mot2.BaseSpeed = 3.0;
			mot2.Staing = delegate(Mot m)
			{
				go = true;
				if (涙左)
				{
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is双眼)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.目左.黒目_ハイライト下_表示 = true;
					}
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is頬眼)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.頬目左.黒目_ハイライト下_表示 = true;
					}
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is単眼)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.単眼目.黒目_ハイライト下_表示 = true;
					}
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is額眼)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.額目.黒目_ハイライト下_表示 = true;
					}
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涙左.涙0流れ0_表示 = (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涙左.涙0流れ1_表示 || CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涙左.涙0_表示);
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涙左.涙0流れ1_表示 = CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涙左.涙0_表示;
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涙左.涙0_表示 = !CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涙左.涙0_表示;
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涙左.涙ハイライト_表示 = CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涙左.涙0_表示;
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涙左.Yv = 0.0;
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涙左.涙0流れ1CD.不透明度 = 1.0;
				}
				if (涙右)
				{
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is双眼)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.目右.黒目_ハイライト下_表示 = true;
					}
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is頬眼)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.頬目右.黒目_ハイライト下_表示 = true;
					}
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涙右.涙0流れ0_表示 = (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涙右.涙0流れ1_表示 || CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涙右.涙0_表示);
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涙右.涙0流れ1_表示 = CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涙右.涙0_表示;
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涙右.涙0_表示 = !CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涙右.涙0_表示;
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涙右.涙ハイライト_表示 = CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涙右.涙0_表示;
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涙右.Yv = 0.0;
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涙右.涙0流れ1CD.不透明度 = 1.0;
				}
			};
			mot2.Runing = delegate(Mot m)
			{
				if (go)
				{
					if (涙左)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涙左.Yv = m.Value;
					}
					if (涙右)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涙右.Yv = m.Value;
						return;
					}
				}
				else
				{
					if (涙左)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涙左.涙0流れ1CD.不透明度 = m.Value;
					}
					if (涙右)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涙右.涙0流れ1CD.不透明度 = m.Value;
					}
				}
			};
			mot2.Reaing = delegate(Mot m)
			{
				go = false;
				if (涙左)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涙左.Yv = 1.0;
				}
				if (涙右)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涙右.Yv = 1.0;
				}
			};
			mot2.Rouing = delegate(Mot m)
			{
				m.End();
			};
			mot2.Ending = delegate(Mot m)
			{
			};
			this.涙流し = mot2;
			this.Mots.Add(this.涙流し.GetHashCode().ToString(), this.涙流し);
			Mot mot3 = new Mot(0.0, 1.0);
			mot3.BaseSpeed = 1.0;
			mot3.Staing = delegate(Mot m)
			{
			};
			double vi;
			mot3.Runing = delegate(Mot m)
			{
				vi = m.Value.Inverse();
				if (涙左)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涙左.濃度 *= vi;
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is双眼)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.目左.黒目_ハイライト下CD.不透明度 *= vi;
					}
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is頬眼)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.頬目左.黒目_ハイライト下CD.不透明度 *= vi;
					}
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is単眼)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.単眼目.黒目_ハイライト下CD.不透明度 *= vi;
					}
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is額眼)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.額目.黒目_ハイライト下CD.不透明度 *= vi;
					}
				}
				if (涙右)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涙右.濃度 *= vi;
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is双眼)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.目右.黒目_ハイライト下CD.不透明度 *= vi;
					}
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is頬眼)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.頬目右.黒目_ハイライト下CD.不透明度 *= vi;
					}
				}
			};
			mot3.Reaing = delegate(Mot m)
			{
				m.End();
				m.ResetValue();
				if (涙左)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涙左.表示 = false;
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涙左.濃度 = 1.0;
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is双眼)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.目左.黒目_ハイライト下_表示 = false;
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.目左.黒目_ハイライト下CD.不透明度 = 1.0;
					}
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is頬眼)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.頬目左.黒目_ハイライト下_表示 = false;
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.頬目左.黒目_ハイライト下CD.不透明度 = 1.0;
					}
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is単眼)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.単眼目.黒目_ハイライト下_表示 = false;
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.単眼目.黒目_ハイライト下CD.不透明度 = 1.0;
					}
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is額眼)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.額目.黒目_ハイライト下_表示 = false;
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.額目.黒目_ハイライト下CD.不透明度 = 1.0;
					}
				}
				if (涙右)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涙右.表示 = false;
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涙右.濃度 = 1.0;
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is双眼)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.目右.黒目_ハイライト下_表示 = false;
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.目右.黒目_ハイライト下CD.不透明度 = 1.0;
					}
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is頬眼)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.頬目右.黒目_ハイライト下_表示 = false;
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.頬目右.黒目_ハイライト下CD.不透明度 = 1.0;
					}
				}
			};
			mot3.Rouing = delegate(Mot m)
			{
			};
			mot3.Ending = delegate(Mot m)
			{
			};
			this.涙ひき = mot3;
			this.Mots.Add(this.涙ひき.GetHashCode().ToString(), this.涙ひき);
			if (this.Bod.Is双眼 || this.Bod.Is単眼)
			{
				Mot mot4 = new Mot(0.0, 1.0);
				mot4.BaseSpeed = 10.0;
				mot4.GotoSpeed = 8.0;
				mot4.RetuSpeed = 0.5;
				mot4.LowestIncrease = 1.0;
				mot4.Interval = 1000.0;
				mot4.Staing = delegate(Mot m)
				{
				};
				mot4.Runing = delegate(Mot m)
				{
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is双眼)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.瞼左v = m.Value.LimitM(CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is瞼宇 ? 0.0 : CS$<>8__locals2.CS$<>8__locals1.<>4__this.瞼基準左, 1.0);
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.瞼右v = m.Value.LimitM(CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is瞼宇 ? 0.0 : CS$<>8__locals2.CS$<>8__locals1.<>4__this.瞼基準右, 1.0);
					}
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is単眼)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.単眼瞼.Yv = m.Value.LimitM(CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is瞼宇 ? 0.0 : CS$<>8__locals2.CS$<>8__locals1.<>4__this.瞼基準単, 1.0);
					}
				};
				mot4.Reaing = delegate(Mot m)
				{
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.泣き_)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.涙流し.Sta();
					}
				};
				mot4.Rouing = delegate(Mot m)
				{
					m.Interval = 5000.0 * OthN.XS.NextDouble();
				};
				mot4.Ending = delegate(Mot m)
				{
				};
				this.瞬き1 = mot4;
				this.Mots.Add(this.瞬き1.GetHashCode().ToString(), this.瞬き1);
				this.瞬き1.Sta();
			}
			if (this.Bod.Is頬眼 || this.Bod.Is額眼)
			{
				Mot mot5 = new Mot(0.0, 1.0);
				mot5.BaseSpeed = 10.0;
				mot5.GotoSpeed = 8.0;
				mot5.RetuSpeed = 0.5;
				mot5.LowestIncrease = 1.0;
				mot5.Interval = 1000.0;
				mot5.Staing = delegate(Mot m)
				{
				};
				mot5.Runing = delegate(Mot m)
				{
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is頬眼)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.頬瞼左.Yv = m.Value.LimitM(CS$<>8__locals2.CS$<>8__locals1.<>4__this.瞼基準頬左, 1.0);
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.頬瞼右.Yv = m.Value.LimitM(CS$<>8__locals2.CS$<>8__locals1.<>4__this.瞼基準頬右, 1.0);
					}
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is額眼)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.額瞼.Yv = m.Value.LimitM(CS$<>8__locals2.CS$<>8__locals1.<>4__this.瞼基準額, 1.0);
					}
				};
				mot5.Reaing = delegate(Mot m)
				{
				};
				mot5.Rouing = delegate(Mot m)
				{
					m.Interval = 5000.0 * OthN.XS.NextDouble();
				};
				mot5.Ending = delegate(Mot m)
				{
				};
				this.瞬き2 = mot5;
				this.Mots.Add(this.瞬き2.GetHashCode().ToString(), this.瞬き2);
				this.瞬き2.Sta();
			}
			CS$<>8__locals2.o = false;
			CS$<>8__locals2.ov = 0.0;
			Mot mot6 = new Mot(0.0, 1.0);
			mot6.BaseSpeed = 0.8;
			mot6.Staing = delegate(Mot m)
			{
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.口精液.Yi = 0;
				CS$<>8__locals2.ov = CS$<>8__locals2.CS$<>8__locals1.<>4__this.中出度;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.口精液.濃度 = 1.0 * CS$<>8__locals2.ov;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.口精液.精液_表示 = true;
				CS$<>8__locals2.o = true;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.口精液.右 = OthN.XS.NextBool();
			};
			mot6.Runing = delegate(Mot m)
			{
				if (CS$<>8__locals2.o)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.口精液.Yv = m.Value;
					return;
				}
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.口精液.濃度 = m.Value * CS$<>8__locals2.ov;
			};
			mot6.Reaing = delegate(Mot m)
			{
				CS$<>8__locals2.o = false;
			};
			mot6.Rouing = delegate(Mot m)
			{
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.口精液.表示 = false;
				m.End();
			};
			mot6.Ending = delegate(Mot m)
			{
			};
			this.口腔精液垂れ = mot6;
			this.Mots.Add(this.口腔精液垂れ.GetHashCode().ToString(), this.口腔精液垂れ);
			CS$<>8__locals2.v = false;
			CS$<>8__locals2.vv = 0.0;
			CS$<>8__locals2.zd = this.Bod.膣内精液.精液濃度;
			Mot mot7 = new Mot(0.0, 1.0);
			mot7.BaseSpeed = 0.8;
			mot7.Staing = delegate(Mot m)
			{
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.性器精液.Yi = 0;
				CS$<>8__locals2.vv = CS$<>8__locals2.CS$<>8__locals1.<>4__this.中出度;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.性器精液.濃度 = 1.0 * CS$<>8__locals2.vv;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.性器精液.精液_表示 = true;
				CS$<>8__locals2.v = true;
				CS$<>8__locals2.zd = CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.膣内精液.精液濃度;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.性器精液.右 = OthN.XS.NextBool();
			};
			mot7.Runing = delegate(Mot m)
			{
				if (CS$<>8__locals2.v)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.性器精液.Yv = m.Value;
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.膣内精液.精液濃度 = CS$<>8__locals2.zd * m.Value.Inverse();
					return;
				}
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.性器精液.濃度 = m.Value * CS$<>8__locals2.vv;
			};
			mot7.Reaing = delegate(Mot m)
			{
				CS$<>8__locals2.v = false;
			};
			mot7.Rouing = delegate(Mot m)
			{
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.性器精液.表示 = false;
				m.End();
			};
			mot7.Ending = delegate(Mot m)
			{
			};
			this.性器精液垂れ = mot7;
			this.Mots.Add(this.性器精液垂れ.GetHashCode().ToString(), this.性器精液垂れ);
			CS$<>8__locals2.a = false;
			CS$<>8__locals2.av = 0.0;
			Mot mot8 = new Mot(0.0, 1.0);
			mot8.BaseSpeed = 0.8;
			mot8.Staing = delegate(Mot m)
			{
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.肛門精液.Yi = 0;
				CS$<>8__locals2.av = CS$<>8__locals2.CS$<>8__locals1.<>4__this.中出度;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.肛門精液.濃度 = 1.0 * CS$<>8__locals2.av;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.肛門精液.精液_表示 = true;
				CS$<>8__locals2.a = true;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.肛門精液.右 = OthN.XS.NextBool();
			};
			mot8.Runing = delegate(Mot m)
			{
				if (CS$<>8__locals2.a)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.肛門精液.Yv = m.Value;
					return;
				}
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.肛門精液.濃度 = m.Value * CS$<>8__locals2.av;
			};
			mot8.Reaing = delegate(Mot m)
			{
				CS$<>8__locals2.a = false;
			};
			mot8.Rouing = delegate(Mot m)
			{
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.肛門精液.表示 = false;
				m.End();
			};
			mot8.Ending = delegate(Mot m)
			{
			};
			this.肛門精液垂れ = mot8;
			this.Mots.Add(this.肛門精液垂れ.GetHashCode().ToString(), this.肛門精液垂れ);
			CS$<>8__locals2.z = false;
			CS$<>8__locals2.zv = 0.0;
			Mot mot9 = new Mot(0.0, 1.0);
			mot9.BaseSpeed = 0.8;
			mot9.Staing = delegate(Mot m)
			{
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.出糸精液.Yi = 0;
				CS$<>8__locals2.zv = CS$<>8__locals2.CS$<>8__locals1.<>4__this.中出度;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.出糸精液.濃度 = 1.0 * CS$<>8__locals2.zv;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.出糸精液.精液_表示 = true;
				CS$<>8__locals2.z = true;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.出糸精液.右 = OthN.XS.NextBool();
			};
			mot9.Runing = delegate(Mot m)
			{
				if (CS$<>8__locals2.z)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.出糸精液.Yv = m.Value;
					return;
				}
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.出糸精液.濃度 = m.Value * CS$<>8__locals2.zv;
			};
			mot9.Reaing = delegate(Mot m)
			{
				CS$<>8__locals2.z = false;
			};
			mot9.Rouing = delegate(Mot m)
			{
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.出糸精液.表示 = false;
				m.End();
			};
			mot9.Ending = delegate(Mot m)
			{
			};
			this.出糸精液垂れ = mot9;
			this.Mots.Add(this.出糸精液垂れ.GetHashCode().ToString(), this.出糸精液垂れ);
			Mot mot10 = new Mot(0.0, 1.0);
			mot10.BaseSpeed = 4.0;
			mot10.Staing = delegate(Mot m)
			{
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.潮吹_小.Yv = 0.0;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.潮吹_小.表示 = true;
			};
			mot10.Runing = delegate(Mot m)
			{
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.潮吹_小.Yv = m.Value;
			};
			mot10.Reaing = delegate(Mot m)
			{
				m.End();
			};
			mot10.Rouing = delegate(Mot m)
			{
			};
			mot10.Ending = delegate(Mot m)
			{
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.潮吹_小.表示 = false;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.飛沫濃度 = (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.飛沫濃度 + 0.01).LimitM(0.0, 1.0);
			};
			this.潮吹小 = mot10;
			this.Mots.Add(this.潮吹小.GetHashCode().ToString(), this.潮吹小);
			Mot mot11 = new Mot(0.0, 1.0);
			mot11.BaseSpeed = 4.0;
			mot11.Staing = delegate(Mot m)
			{
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.潮吹_大.Yv = 0.0;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.潮吹_大.表示 = true;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.潮吹_大.右 = OthN.XS.NextBool();
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.潮吹擬音 != null)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.潮吹擬音();
				}
			};
			mot11.Runing = delegate(Mot m)
			{
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.潮吹_大.Yv = m.Value;
			};
			mot11.Reaing = delegate(Mot m)
			{
				m.End();
			};
			mot11.Rouing = delegate(Mot m)
			{
			};
			mot11.Ending = delegate(Mot m)
			{
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.潮吹_大.表示 = false;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.潮染み濃度 = (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.潮染み濃度 + 0.2).LimitM(0.0, 1.0);
			};
			this.潮吹大 = mot11;
			this.Mots.Add(this.潮吹大.GetHashCode().ToString(), this.潮吹大);
			Mot mot12 = new Mot(0.0, 1.0);
			mot12.BaseSpeed = 4.0;
			mot12.Staing = delegate(Mot m)
			{
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.飛沫.Yv = 0.0;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.飛沫.表示 = true;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.飛沫.右 = OthN.XS.NextBool();
			};
			mot12.Runing = delegate(Mot m)
			{
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.飛沫.Yv = m.Value;
			};
			mot12.Reaing = delegate(Mot m)
			{
				m.End();
			};
			mot12.Rouing = delegate(Mot m)
			{
			};
			mot12.Ending = delegate(Mot m)
			{
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.飛沫.表示 = false;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.飛沫濃度 = (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.飛沫濃度 + 0.03).LimitM(0.0, 1.0);
			};
			this.飛沫 = mot12;
			this.Mots.Add(this.飛沫.GetHashCode().ToString(), this.飛沫);
			Mot mot13 = new Mot(0.0, 1.0);
			mot13.BaseSpeed = 3.0;
			mot13.Staing = delegate(Mot m)
			{
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.咳.Yv = 0.0;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.咳.表示 = true;
			};
			mot13.Runing = delegate(Mot m)
			{
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.咳.Yv = m.Value;
			};
			mot13.Reaing = delegate(Mot m)
			{
				m.End();
			};
			mot13.Rouing = delegate(Mot m)
			{
			};
			mot13.Ending = delegate(Mot m)
			{
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.咳.表示 = false;
			};
			this.唾散 = mot13;
			this.Mots.Add(this.唾散.GetHashCode().ToString(), this.唾散);
			Cha.<>c__DisplayClass77_1 CS$<>8__locals4 = CS$<>8__locals2;
			Mot mot14 = new Mot(0.0, 1.0);
			mot14.BaseSpeed = 0.1;
			mot14.Staing = delegate(Mot m)
			{
			};
			mot14.Runing = delegate(Mot m)
			{
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.尿染み濃度 = m.Value;
			};
			mot14.Reaing = delegate(Mot m)
			{
				m.End();
			};
			mot14.Rouing = delegate(Mot m)
			{
			};
			mot14.Ending = delegate(Mot m)
			{
			};
			CS$<>8__locals4.染み = mot14;
			this.Mots.Add(CS$<>8__locals2.染み.GetHashCode().ToString(), CS$<>8__locals2.染み);
			CS$<>8__locals2.放尿1 = null;
			Cha.<>c__DisplayClass77_1 CS$<>8__locals5 = CS$<>8__locals2;
			Mot mot15 = new Mot(0.0, 1.0);
			mot15.BaseSpeed = 1.0;
			mot15.Staing = delegate(Mot m)
			{
			};
			mot15.Runing = delegate(Mot m)
			{
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.放尿.濃度 = m.Value.Inverse();
				CS$<>8__locals2.CS$<>8__locals1.ChaD.羞恥 = (CS$<>8__locals2.CS$<>8__locals1.ChaD.羞恥 + 0.002).LimitM(0.0, 1.0);
			};
			mot15.Reaing = delegate(Mot m)
			{
				m.End();
			};
			mot15.Rouing = delegate(Mot m)
			{
			};
			mot15.Ending = delegate(Mot m)
			{
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.放尿.表示 = false;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.放尿.濃度 = 1.0;
				CS$<>8__locals2.放尿1.End();
			};
			CS$<>8__locals5.放尿2 = mot15;
			this.Mots.Add(CS$<>8__locals2.放尿2.GetHashCode().ToString(), CS$<>8__locals2.放尿2);
			CS$<>8__locals2.sw = new Stopwatch();
			Cha.<>c__DisplayClass77_1 CS$<>8__locals6 = CS$<>8__locals2;
			Mot mot16 = new Mot(8.0, 10.0);
			mot16.BaseSpeed = 10.0;
			mot16.Staing = delegate(Mot m)
			{
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.放尿.Yi = 8;
				CS$<>8__locals2.sw.Start();
			};
			mot16.Runing = delegate(Mot m)
			{
				if (CS$<>8__locals2.sw.ElapsedMilliseconds > 4000L)
				{
					CS$<>8__locals2.放尿2.Sta();
				}
				else if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.放尿擬音 != null)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.放尿擬音();
				}
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.放尿.Yi = (int)m.Value;
				CS$<>8__locals2.CS$<>8__locals1.ChaD.羞恥 = (CS$<>8__locals2.CS$<>8__locals1.ChaD.羞恥 + 0.002).LimitM(0.0, 1.0);
			};
			mot16.Reaing = delegate(Mot m)
			{
			};
			mot16.Rouing = delegate(Mot m)
			{
			};
			mot16.Ending = delegate(Mot m)
			{
				CS$<>8__locals2.sw.Reset();
			};
			CS$<>8__locals6.放尿1 = mot16;
			this.Mots.Add(CS$<>8__locals2.放尿1.GetHashCode().ToString(), CS$<>8__locals2.放尿1);
			Cha.<>c__DisplayClass77_1 CS$<>8__locals7 = CS$<>8__locals2;
			Mot mot17 = new Mot(0.0, 1.0);
			mot17.BaseSpeed = 0.2;
			mot17.Staing = delegate(Mot m)
			{
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.湯気左濃度 = 0.0;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.湯気右濃度 = 0.0;
			};
			mot17.Runing = delegate(Mot m)
			{
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.湯気左濃度 = m.Value;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.湯気右濃度 = m.Value;
			};
			mot17.Reaing = delegate(Mot m)
			{
			};
			mot17.Rouing = delegate(Mot m)
			{
				m.End();
			};
			mot17.Ending = delegate(Mot m)
			{
			};
			CS$<>8__locals7.湯気 = mot17;
			this.Mots.Add(CS$<>8__locals2.湯気.GetHashCode().ToString(), CS$<>8__locals2.湯気);
			Mot mot18 = new Mot(0.0, 1.0);
			mot18.BaseSpeed = 0.6;
			mot18.Staing = delegate(Mot m)
			{
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.放尿.Yv = 0.0;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.放尿.表示 = true;
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.尿染み濃度 != 1.0)
				{
					CS$<>8__locals2.染み.Sta();
				}
				Sou.放尿.Play();
			};
			mot18.Runing = delegate(Mot m)
			{
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.放尿.Yv = m.Value;
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.放尿擬音 != null)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.放尿擬音();
				}
				CS$<>8__locals2.CS$<>8__locals1.ChaD.羞恥 = (CS$<>8__locals2.CS$<>8__locals1.ChaD.羞恥 + 0.002).LimitM(0.0, 1.0);
			};
			mot18.Reaing = delegate(Mot m)
			{
				m.End();
			};
			mot18.Rouing = delegate(Mot m)
			{
			};
			mot18.Ending = delegate(Mot m)
			{
				CS$<>8__locals2.放尿1.Sta();
				CS$<>8__locals2.湯気.Sta();
			};
			this.放尿 = mot18;
			this.Mots.Add(this.放尿.GetHashCode().ToString(), this.放尿);
			this.放尿強制終了_ = delegate()
			{
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.放尿.End();
				CS$<>8__locals2.放尿1.End();
				CS$<>8__locals2.湯気.End();
				CS$<>8__locals2.放尿2.End();
				CS$<>8__locals2.染み.End();
			};
			this.Is放尿 = (() => CS$<>8__locals2.CS$<>8__locals1.<>4__this.放尿.Run || CS$<>8__locals2.放尿1.Run || CS$<>8__locals2.放尿2.Run);
			Mot mot19 = new Mot(0.0, 1.0);
			mot19.BaseSpeed = 2.0;
			mot19.Staing = delegate(Mot m)
			{
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.噴乳左.Yi = 0;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.噴乳右.Yi = 0;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.噴乳左.母乳1_表示 = true;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.噴乳左.母乳2_表示 = true;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.噴乳左.母乳3_表示 = true;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.噴乳左.母乳4_表示 = true;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.噴乳右.母乳1_表示 = true;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.噴乳右.母乳2_表示 = true;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.噴乳右.母乳3_表示 = true;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.噴乳右.母乳4_表示 = true;
			};
			mot19.Runing = delegate(Mot m)
			{
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.噴乳左.Yv = m.Value;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.噴乳右.Yv = m.Value;
			};
			mot19.Reaing = delegate(Mot m)
			{
				m.End();
			};
			mot19.Rouing = delegate(Mot m)
			{
			};
			mot19.Ending = delegate(Mot m)
			{
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.噴乳左.母乳1_表示 = false;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.噴乳左.母乳2_表示 = false;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.噴乳左.母乳3_表示 = false;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.噴乳左.母乳4_表示 = false;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.噴乳左.母乳垂れ1_表示 = true;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.噴乳左.母乳垂れ2_表示 = true;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.噴乳右.母乳1_表示 = false;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.噴乳右.母乳2_表示 = false;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.噴乳右.母乳3_表示 = false;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.噴乳右.母乳4_表示 = false;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.噴乳右.母乳垂れ1_表示 = true;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.噴乳右.母乳垂れ2_表示 = true;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.噴乳染み = (CS$<>8__locals2.CS$<>8__locals1.<>4__this.噴乳染み + 0.03).LimitM(0.0, 1.0);
			};
			this.噴乳 = mot19;
			this.Mots.Add(this.噴乳.GetHashCode().ToString(), this.噴乳);
			CS$<>8__locals2.hm = false;
			CS$<>8__locals2.鼻水左 = (this.Bod.鼻水左 != null);
			CS$<>8__locals2.鼻水右 = (this.Bod.鼻水右 != null);
			Mot mot20 = new Mot(0.0, 1.0);
			mot20.BaseSpeed = 3.0;
			mot20.Staing = delegate(Mot m)
			{
				CS$<>8__locals2.hm = OthN.XS.NextBool();
				if ((CS$<>8__locals2.鼻水左 & CS$<>8__locals2.hm) && CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.鼻水左.Yv != 1.0 && CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.鼻水右.Yv != 1.0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.鼻水左.Yv = 0.0;
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.鼻水左.表示 = true;
				}
				if (CS$<>8__locals2.鼻水右 && !CS$<>8__locals2.hm && CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.鼻水左.Yv != 1.0 && CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.鼻水右.Yv != 1.0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.鼻水右.Yv = 0.0;
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.鼻水右.表示 = true;
				}
			};
			mot20.Runing = delegate(Mot m)
			{
				if ((CS$<>8__locals2.鼻水左 & CS$<>8__locals2.hm) && CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.鼻水左.Yv != 1.0 && CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.鼻水右.Yv != 1.0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.鼻水左.Yv = m.Value;
				}
				if (CS$<>8__locals2.鼻水右 && !CS$<>8__locals2.hm && CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.鼻水左.Yv != 1.0 && CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.鼻水右.Yv != 1.0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.鼻水右.Yv = m.Value;
				}
			};
			mot20.Reaing = delegate(Mot m)
			{
				m.End();
			};
			mot20.Rouing = delegate(Mot m)
			{
			};
			mot20.Ending = delegate(Mot m)
			{
			};
			this.鼻水 = mot20;
			this.Mots.Add(this.鼻水.GetHashCode().ToString(), this.鼻水);
			CS$<>8__locals2.yb = false;
			CS$<>8__locals2.涎左 = (this.Bod.涎左 != null);
			CS$<>8__locals2.涎右 = (this.Bod.涎右 != null);
			Mot mot21 = new Mot(0.0, 1.0);
			mot21.BaseSpeed = 3.0;
			mot21.Staing = delegate(Mot m)
			{
				CS$<>8__locals2.yb = OthN.XS.NextBool();
				if ((CS$<>8__locals2.涎左 & CS$<>8__locals2.yb) && CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涎左.Yv != 1.0 && CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涎右.Yv != 1.0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涎左.Yv = 0.0;
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涎左.表示 = true;
				}
				if (CS$<>8__locals2.涎右 && !CS$<>8__locals2.yb && CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涎左.Yv != 1.0 && CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涎右.Yv != 1.0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涎右.Yv = 0.0;
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涎右.表示 = true;
				}
			};
			mot21.Runing = delegate(Mot m)
			{
				if ((CS$<>8__locals2.涎左 & CS$<>8__locals2.yb) && CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涎左.Yv != 1.0 && CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涎右.Yv != 1.0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涎左.Yv = m.Value;
				}
				if (CS$<>8__locals2.涎右 && !CS$<>8__locals2.yb && CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涎左.Yv != 1.0 && CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涎右.Yv != 1.0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.涎右.Yv = m.Value;
				}
			};
			mot21.Reaing = delegate(Mot m)
			{
				m.End();
			};
			mot21.Rouing = delegate(Mot m)
			{
			};
			mot21.Ending = delegate(Mot m)
			{
			};
			this.涎 = mot21;
			this.Mots.Add(this.涎.GetHashCode().ToString(), this.涎);
			Mot mot22 = new Mot(0.0, 1.0);
			mot22.BaseSpeed = 0.1;
			mot22.Staing = delegate(Mot m)
			{
			};
			mot22.Runing = delegate(Mot m)
			{
				CS$<>8__locals2.s = (CS$<>8__locals2.CS$<>8__locals1.<>4__this.目逸し ? -1 : 1);
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.目逸し)
				{
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is双眼)
					{
						CS$<>8__locals2.ev = (double)CS$<>8__locals2.s * (CS$<>8__locals2.CS$<>8__locals1.<>4__this.CP - (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.目左.位置 + CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.目右.位置) * 0.5).newNormalize() * 0.002;
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.目左.視線 = CS$<>8__locals2.ev;
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.目右.視線 = CS$<>8__locals2.ev;
					}
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is頬眼)
					{
						CS$<>8__locals2.ev = (double)CS$<>8__locals2.s * (CS$<>8__locals2.CS$<>8__locals1.<>4__this.CP - (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.頬目左.位置 + CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.頬目右.位置) * 0.5).newNormalize() * 0.00089;
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.頬目左.視線 = CS$<>8__locals2.ev;
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.頬目右.視線 = CS$<>8__locals2.ev;
					}
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is額眼)
					{
						CS$<>8__locals2.ev = (double)CS$<>8__locals2.s * (CS$<>8__locals2.CS$<>8__locals1.<>4__this.CP - CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.額目.位置).newNormalize() * 0.00089;
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.額目.視線 = CS$<>8__locals2.ev;
					}
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is単眼)
					{
						CS$<>8__locals2.ev = (double)CS$<>8__locals2.s * (CS$<>8__locals2.CS$<>8__locals1.<>4__this.CP - CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.単眼目.位置).newNormalize() * 0.003;
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.単眼目.視線 = CS$<>8__locals2.ev;
						return;
					}
				}
				else
				{
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is双眼)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.目左.視線 = (double)CS$<>8__locals2.s * (CS$<>8__locals2.CS$<>8__locals1.<>4__this.CP - CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.目左.位置).newNormalize() * 0.002;
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.目右.視線 = (double)CS$<>8__locals2.s * (CS$<>8__locals2.CS$<>8__locals1.<>4__this.CP - CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.目右.位置).newNormalize() * 0.002;
					}
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is頬眼)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.頬目左.視線 = (double)CS$<>8__locals2.s * (CS$<>8__locals2.CS$<>8__locals1.<>4__this.CP - CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.頬目左.位置).newNormalize() * 0.00089;
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.頬目右.視線 = (double)CS$<>8__locals2.s * (CS$<>8__locals2.CS$<>8__locals1.<>4__this.CP - CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.頬目右.位置).newNormalize() * 0.00089;
					}
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is額眼)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.額目.視線 = (double)CS$<>8__locals2.s * (CS$<>8__locals2.CS$<>8__locals1.<>4__this.CP - CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.額目.位置).newNormalize() * 0.00089;
					}
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is単眼)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.単眼目.視線 = (double)CS$<>8__locals2.s * (CS$<>8__locals2.CS$<>8__locals1.<>4__this.CP - CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.単眼目.位置).newNormalize() * 0.003;
					}
				}
			};
			mot22.Reaing = delegate(Mot m)
			{
			};
			mot22.Rouing = delegate(Mot m)
			{
			};
			mot22.Ending = delegate(Mot m)
			{
			};
			this.目_追い = mot22;
			this.Mots.Add(this.目_追い.GetHashCode().ToString(), this.目_追い);
			CS$<>8__locals2.l = 1.0;
			Mot mot23 = new Mot(0.0, 1.0);
			mot23.BaseSpeed = 0.2 - 0.15 * this.絶頂時間;
			mot23.Staing = delegate(Mot m)
			{
				m.BaseSpeed = 0.2 - 0.15 * CS$<>8__locals2.CS$<>8__locals1.<>4__this.絶頂時間;
				CS$<>8__locals2.l = 1.0;
			};
			mot23.Runing = delegate(Mot m)
			{
				CS$<>8__locals2.l = m.Value.Inverse();
			};
			mot23.Reaing = delegate(Mot m)
			{
				m.End();
			};
			mot23.Rouing = delegate(Mot m)
			{
			};
			mot23.Ending = delegate(Mot m)
			{
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.絶頂.End();
				Act.絶頂終了処理();
			};
			this.絶頂終了 = mot23;
			this.Mots.Add(this.絶頂終了.GetHashCode().ToString(), this.絶頂終了);
			CS$<>8__locals2.kv = 0.0;
			CS$<>8__locals2.pa = this.Bod.腰.本体.CurJoinRoot;
			CS$<>8__locals2.pb = null;
			CS$<>8__locals2.vec = Dat.Vec2DZero;
			CS$<>8__locals2.腰接続 = delegate()
			{
				CS$<>8__locals2.pb = CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.腰.本体.CurJoinRoot;
				CS$<>8__locals2.vec = CS$<>8__locals2.pb.ToGlobal(CS$<>8__locals2.pb.JP[5].Joint) - CS$<>8__locals2.pa.ToGlobal(CS$<>8__locals2.pa.JP[5].Joint);
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is腰)
				{
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.重腰)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI腰.PositionCont = CS$<>8__locals2.vec;
					}
					else
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI腰.Updatef = true;
					}
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is半後)
				{
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.重半後)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI半後.PositionCont = CS$<>8__locals2.vec;
					}
					else
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI半後.Updatef = true;
					}
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is半中1)
				{
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.重半中1)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI半中1.PositionCont = CS$<>8__locals2.vec;
					}
					else
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI半中1.Updatef = true;
					}
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is半中2)
				{
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.重半中2)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI半中2.PositionCont = CS$<>8__locals2.vec;
					}
					else
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI半中2.Updatef = true;
					}
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is半前)
				{
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.重半前)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI半前.PositionCont = CS$<>8__locals2.vec;
					}
					else
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI半前.Updatef = true;
					}
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is腿)
				{
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.重腿)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI腿.PositionCont = CS$<>8__locals2.vec;
						return;
					}
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI腿.Updatef = true;
				}
			};
			Mot mot24 = new Mot(0.0, 1.0);
			mot24.BaseSpeed = 20.0;
			mot24.Staing = delegate(Mot m)
			{
				CS$<>8__locals2.kv = CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.腰.Yv;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.絶頂終了.Sta();
			};
			mot24.Runing = delegate(Mot m)
			{
				CS$<>8__locals2.d = 5.0 * (0.15 + CS$<>8__locals2.CS$<>8__locals1.<>4__this.絶頂激しさ) * m.Value.Sin() * OthN.XS.NextDouble() * CS$<>8__locals2.l;
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.腕人n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.腕人絶頂(CS$<>8__locals2.d);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.腕翼鳥n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.腕翼鳥絶頂(CS$<>8__locals2.d);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.腕翼獣n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.腕翼獣絶頂(CS$<>8__locals2.d);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.腕獣n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.腕獣絶頂(CS$<>8__locals2.d);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is触覚他)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.触覚絶頂(CS$<>8__locals2.d);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is触覚甲)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.触覚甲絶頂(CS$<>8__locals2.d);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.大顎n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.大顎絶頂(CS$<>8__locals2.d);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.虫顎n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.虫顎絶頂(CS$<>8__locals2.d);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.鰭n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.鰭絶頂(CS$<>8__locals2.d);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.葉n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.葉絶頂(CS$<>8__locals2.d);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.前翅1n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.前翅絶頂(CS$<>8__locals2.d);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.後翅1n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.後翅絶頂(CS$<>8__locals2.d);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.触肢蜘n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.触肢蜘絶頂(CS$<>8__locals2.d);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.触肢蠍n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.触肢蠍絶頂(CS$<>8__locals2.d);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.節足蜘n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.節足蜘絶頂(CS$<>8__locals2.d);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.節足蠍n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.節足蠍絶頂(CS$<>8__locals2.d);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.節足百n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.節足百絶頂(CS$<>8__locals2.d);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.節尾曳n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.節尾曳絶頂(CS$<>8__locals2.d);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.節尾鋏n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.節尾鋏絶頂(CS$<>8__locals2.d);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.虫鎌n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.虫鎌絶頂(CS$<>8__locals2.d);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.触手n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.触手絶頂(CS$<>8__locals2.d);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.触手犬n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.触手犬絶頂(CS$<>8__locals2.d);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.尾n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.尾絶頂(CS$<>8__locals2.d);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is植)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.植絶頂(CS$<>8__locals2.d);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.脚人n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.脚人絶頂(CS$<>8__locals2.d);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.脚獣n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.脚獣絶頂(CS$<>8__locals2.d);
				}
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.腰振りv = CS$<>8__locals2.d * OthN.XS.NextDouble();
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.腰.位置C = new Vector2D(0.0, 0.0005 * CS$<>8__locals2.d);
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.乳房左.位置C = CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.腰.位置C;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.乳房右.位置C = CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.腰.位置C;
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is腕前)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI腕前.Updatef = true;
				}
				CS$<>8__locals2.腰接続();
				Act.絶頂中処理();
				if (0.3.Lot())
				{
					Act.奴体力消費中();
				}
			};
			mot24.Reaing = delegate(Mot m)
			{
			};
			mot24.Rouing = delegate(Mot m)
			{
			};
			mot24.Ending = delegate(Mot m)
			{
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.腰振り_人v = CS$<>8__locals2.kv;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.腰.位置C = Dat.Vec2DZero;
				if (!CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.乳房左.着衣)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.乳房左.位置C = Dat.Vec2DZero;
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.乳房右.位置C = Dat.Vec2DZero;
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is腰)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI腰.PositionCont = Dat.Vec2DZero;
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is半後)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI半後.PositionCont = Dat.Vec2DZero;
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is半中1)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI半中1.PositionCont = Dat.Vec2DZero;
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is半中2)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI半中2.PositionCont = Dat.Vec2DZero;
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is半前)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI半前.PositionCont = Dat.Vec2DZero;
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is腿)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI腿.PositionCont = Dat.Vec2DZero;
				}
			};
			this.絶頂 = mot24;
			this.Mots.Add(this.絶頂.GetHashCode().ToString(), this.絶頂);
			CS$<>8__locals2.肛sw = new Stopwatch();
			Mot mot25 = new Mot(0.0, 1.0);
			mot25.BaseSpeed = 1.0;
			mot25.Staing = delegate(Mot m)
			{
				CS$<>8__locals2.肛sw.Restart();
			};
			mot25.Runing = delegate(Mot m)
			{
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.肛門C = 0.5 + m.Value.Sin() * OthN.XS.NextDouble() * 0.5;
				if (CS$<>8__locals2.肛sw.ElapsedMilliseconds > 5000L)
				{
					m.End();
				}
			};
			mot25.Reaing = delegate(Mot m)
			{
			};
			mot25.Rouing = delegate(Mot m)
			{
			};
			mot25.Ending = delegate(Mot m)
			{
				CS$<>8__locals2.肛sw.Stop();
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.肛門C = 1.0;
			};
			this.肛ヒク = mot25;
			this.Mots.Add(this.肛ヒク.GetHashCode().ToString(), this.肛ヒク);
			CS$<>8__locals2.膣sw = new Stopwatch();
			Mot mot26 = new Mot(0.0, 1.0);
			mot26.BaseSpeed = 1.0;
			mot26.Staing = delegate(Mot m)
			{
				CS$<>8__locals2.膣sw.Restart();
			};
			mot26.Runing = delegate(Mot m)
			{
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.膣腔C = 1.0 + m.Value.Sin() * OthN.XS.NextDouble() * 0.5;
				if (CS$<>8__locals2.膣sw.ElapsedMilliseconds > 5000L)
				{
					m.End();
				}
			};
			mot26.Reaing = delegate(Mot m)
			{
			};
			mot26.Rouing = delegate(Mot m)
			{
			};
			mot26.Ending = delegate(Mot m)
			{
				CS$<>8__locals2.膣sw.Stop();
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.膣腔C = 1.0;
			};
			this.膣ヒク = mot26;
			this.Mots.Add(this.膣ヒク.GetHashCode().ToString(), this.膣ヒク);
			CS$<>8__locals2.糸sw = new Stopwatch();
			Mot mot27 = new Mot(0.0, 1.0);
			mot27.BaseSpeed = 0.1;
			mot27.Staing = delegate(Mot m)
			{
				CS$<>8__locals2.糸sw.Restart();
			};
			mot27.Runing = delegate(Mot m)
			{
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is蜘尾)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.出糸C = m.Value.Sin() * 30.0;
				}
				if (CS$<>8__locals2.糸sw.ElapsedMilliseconds > 5000L)
				{
					m.End();
				}
			};
			mot27.Reaing = delegate(Mot m)
			{
			};
			mot27.Rouing = delegate(Mot m)
			{
			};
			mot27.Ending = delegate(Mot m)
			{
				CS$<>8__locals2.糸sw.Stop();
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is蜘尾)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.出糸C = 0.0;
				}
			};
			this.糸ヒク = mot27;
			this.Mots.Add(this.糸ヒク.GetHashCode().ToString(), this.糸ヒク);
			CS$<>8__locals2.顔面開き = false;
			CS$<>8__locals2.Is展開 = (this.Bod.Is顔面 || this.Bod.Is大顎基);
			CS$<>8__locals2.顔面 = this.Bod.顔面;
			CS$<>8__locals2.大顎 = this.Bod.頭.大顎基_接続.GetEle<大顎基>();
			CS$<>8__locals2.虫角 = this.Bod.頭.額_接続.GetEle<角1_虫>();
			CS$<>8__locals2.o_ = 0.0;
			Mot mot28 = new Mot(0.0, 1.0);
			mot28.BaseSpeed = 5.0;
			mot28.Staing = delegate(Mot m)
			{
				if (CS$<>8__locals2.Is展開)
				{
					CS$<>8__locals2.顔面開き = (CS$<>8__locals2.o_ == 1.0);
				}
			};
			mot28.Runing = delegate(Mot m)
			{
				if (CS$<>8__locals2.Is展開)
				{
					if (CS$<>8__locals2.顔面開き)
					{
						CS$<>8__locals2.o_ = m.Value.Inverse();
					}
					else
					{
						CS$<>8__locals2.o_ = m.Value;
					}
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is顔面)
					{
						CS$<>8__locals2.顔面.展開0 = CS$<>8__locals2.o_;
						CS$<>8__locals2.顔面.展開1 = CS$<>8__locals2.o_;
					}
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is大顎基)
					{
						CS$<>8__locals2.大顎.展開 = CS$<>8__locals2.o_;
					}
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is虫角)
					{
						CS$<>8__locals2.虫角.展開 = CS$<>8__locals2.o_;
					}
				}
			};
			mot28.Reaing = delegate(Mot m)
			{
				m.End();
			};
			mot28.Rouing = delegate(Mot m)
			{
			};
			mot28.Ending = delegate(Mot m)
			{
			};
			this.顔面展開 = mot28;
			this.Mots.Add(this.顔面展開.GetHashCode().ToString(), this.顔面展開);
			CS$<>8__locals2.p_ = Dat.Vec2DZero;
			Mot mot29 = new Mot(0.0, 1.0);
			mot29.BaseSpeed = 7.0;
			mot29.Staing = delegate(Mot m)
			{
			};
			mot29.Runing = delegate(Mot m)
			{
				CS$<>8__locals2.d_ = 2.0 * m.Value;
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.腕人n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.腕人絶頂(CS$<>8__locals2.d_);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.腕翼鳥n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.腕翼鳥絶頂(CS$<>8__locals2.d_);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.腕翼獣n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.腕翼獣絶頂(CS$<>8__locals2.d_);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.腕獣n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.腕獣絶頂(CS$<>8__locals2.d_);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is触覚他)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.触覚絶頂(CS$<>8__locals2.d_);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is触覚甲)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.触覚甲絶頂(CS$<>8__locals2.d_);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.大顎n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.大顎絶頂(CS$<>8__locals2.d_);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.虫顎n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.虫顎絶頂(CS$<>8__locals2.d_);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.鰭n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.鰭絶頂(CS$<>8__locals2.d_);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.葉n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.葉絶頂(CS$<>8__locals2.d_);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.前翅1n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.前翅絶頂(-CS$<>8__locals2.d_);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.後翅1n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.後翅絶頂(-CS$<>8__locals2.d_);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.触肢蜘n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.触肢蜘絶頂(CS$<>8__locals2.d_);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.触肢蠍n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.触肢蠍絶頂(CS$<>8__locals2.d_);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.節足蜘n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.節足蜘絶頂(CS$<>8__locals2.d_);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.節足蠍n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.節足蠍絶頂(CS$<>8__locals2.d_);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.節足百n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.節足百絶頂(CS$<>8__locals2.d_);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.節尾曳n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.節尾曳絶頂(CS$<>8__locals2.d_);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.節尾鋏n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.節尾鋏絶頂(CS$<>8__locals2.d_);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.虫鎌n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.虫鎌絶頂(CS$<>8__locals2.d_);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.触手n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.触手絶頂(CS$<>8__locals2.d_);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.触手犬n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.触手犬絶頂(CS$<>8__locals2.d_);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.尾n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.尾絶頂(CS$<>8__locals2.d_);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is植)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.植絶頂(CS$<>8__locals2.d_);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.脚人n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.脚人絶頂(CS$<>8__locals2.d_);
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.脚獣n > 0)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.脚獣絶頂(CS$<>8__locals2.d_);
				}
				CS$<>8__locals2.p_.Y = -0.001 * m.Value;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.腰.位置C = CS$<>8__locals2.p_;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.乳房左.位置C = CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.腰.位置C;
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.乳房右.位置C = CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.腰.位置C;
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is髪)
				{
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.重髪)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI髪.Position = CS$<>8__locals2.p_;
					}
					else
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI髪.Updatef = true;
					}
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is胸)
				{
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.重胸)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI胸.Position = CS$<>8__locals2.p_;
					}
					else
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI胸.Updatef = true;
					}
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is腰)
				{
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.重腰)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI腰.Position = CS$<>8__locals2.p_;
					}
					else
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI腰.Updatef = true;
					}
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is腕前)
				{
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.重腕前)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI腕前.Position = CS$<>8__locals2.p_;
					}
					else
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI腕前.Updatef = true;
					}
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is半後)
				{
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.重半後)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI半後.Position = CS$<>8__locals2.p_;
					}
					else
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI半後.Updatef = true;
					}
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is半中1)
				{
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.重半中1)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI半中1.Position = CS$<>8__locals2.p_;
					}
					else
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI半中1.Updatef = true;
					}
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is半中2)
				{
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.重半中2)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI半中2.Position = CS$<>8__locals2.p_;
					}
					else
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI半中2.Updatef = true;
					}
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is半前)
				{
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.重半前)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI半前.Position = CS$<>8__locals2.p_;
					}
					else
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI半前.Updatef = true;
					}
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is腿)
				{
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.重腿)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI腿.Position = CS$<>8__locals2.p_;
						return;
					}
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI腿.Updatef = true;
				}
			};
			mot29.Reaing = delegate(Mot m)
			{
			};
			mot29.Rouing = delegate(Mot m)
			{
				m.End();
			};
			mot29.Ending = delegate(Mot m)
			{
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.腰.位置C = Dat.Vec2DZero;
				if (!CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.乳房左.着衣)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.乳房左.位置C = Dat.Vec2DZero;
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.乳房右.位置C = Dat.Vec2DZero;
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is髪)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI髪.Position = Dat.Vec2DZero;
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is胸)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI胸.Position = Dat.Vec2DZero;
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is腰)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI腰.Position = Dat.Vec2DZero;
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is腕前)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI腕前.Position = Dat.Vec2DZero;
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is半後)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI半後.Position = Dat.Vec2DZero;
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is半中1)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI半中1.Position = Dat.Vec2DZero;
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is半中2)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI半中2.Position = Dat.Vec2DZero;
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is半前)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI半前.Position = Dat.Vec2DZero;
				}
				if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is腿)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.EI腿.Position = Dat.Vec2DZero;
				}
			};
			this.体揺れ = mot29;
			this.Mots.Add(this.体揺れ.GetHashCode().ToString(), this.体揺れ);
			CS$<>8__locals2.c_ = 0;
			CS$<>8__locals2.咳込み数 = 1;
			this.咳込み = new Mot(0.0, 1.0)
			{
				BaseSpeed = 10.0,
				GotoSpeed = 0.5,
				RetuSpeed = 2.0,
				Staing = delegate(Mot m)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Set表情変化();
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is双眼)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.両瞼_1(OthN.XS.Next(1, 4), OthN.XS.Next(1, 4));
					}
					else if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is単眼)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.単瞼_1(OthN.XS.Next(1, 4));
					}
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is頬眼)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.両頬瞼_1(OthN.XS.Next(1, 4), OthN.XS.Next(1, 4));
					}
					if (CS$<>8__locals2.CS$<>8__locals1.<>4__this.Bod.Is額眼)
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.額瞼_1(OthN.XS.Next(1, 4));
					}
					CS$<>8__locals2.c_ = 0;
					CS$<>8__locals2.咳込み数 = OthN.XS.NextM(1, 2) + Act.UI.ペニス処理.中出しCount / 2;
				},
				Runing = delegate(Mot m)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.呼吸値 = m.Value;
				},
				Reaing = delegate(Mot m)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.唾散.Sta();
					if ((Act.UI.ペニス処理.中出し || CS$<>8__locals2.CS$<>8__locals1.<>4__this.泣き) && 0.18.Lot())
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.鼻水.Sta();
					}
					if (Act.UI.ペニス処理.中出し && 0.25.Lot())
					{
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.涎.Sta();
					}
				},
				Rouing = delegate(Mot m)
				{
					int c_ = CS$<>8__locals2.c_;
					CS$<>8__locals2.c_ = c_ + 1;
					if (CS$<>8__locals2.c_ >= CS$<>8__locals2.咳込み数)
					{
						m.End();
					}
				},
				Ending = delegate(Mot m)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.Set表情初期化();
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.口();
				}
			};
			this.Mots.Add(this.咳込み.GetHashCode().ToString(), this.咳込み);
			CS$<>8__locals2.中出度_ = 0.0;
			Mot mot30 = new Mot(0.0, 1.0);
			mot30.BaseSpeed = 1.0;
			mot30.Staing = delegate(Mot m)
			{
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.Set表情変化();
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.口_紡ぎ();
				CS$<>8__locals2.中出度_ = CS$<>8__locals2.CS$<>8__locals1.<>4__this.中出度;
			};
			mot30.Runing = delegate(Mot m)
			{
				CS$<>8__locals2.CS$<>8__locals1.<>4__this.呼吸値 = m.Value;
			};
			mot30.Reaing = delegate(Mot m)
			{
			};
			mot30.Rouing = delegate(Mot m)
			{
				m.End();
			};
			mot30.Ending = delegate(Mot m)
			{
				if (OthN.XS.NextBool())
				{
					Sou.挿抜口1.Play();
				}
				else
				{
					Sou.挿抜口2.Play();
				}
				CS$<>8__locals2.CS$<>8__locals1.ChaD.体力 = (CS$<>8__locals2.CS$<>8__locals1.ChaD.体力 + 0.3 * CS$<>8__locals2.中出度_).LimitM(0.0, 1.0);
			};
			this.ごっくん = mot30;
			this.Mots.Add(this.ごっくん.GetHashCode().ToString(), this.ごっくん);
			this.Mots.Drive(Med.FPSF);
			Med.SetUniqueColor((from e in this.Bod.全要素
			select e.本体.EnumAllPar()).JoinEnum<Par>());
			this.汗掻き = new 汗掻き(Med, Are, this, this.Mots);
			this.汗かき = this.汗掻き.汗かき;
			this.Bod.汗掻き = this.汗掻き;
			this.Set初期角度();
		}

		public void Draw(Are Are, FPS FPS)
		{
			this.FPS = FPS.Value;
			this.Mots.Drive(FPS);
			this.Bod.描画(Are);
		}

		public void Dispose()
		{
			this.Bod.Dispose();
			this.汗掻き.Dispose();
			this.Med.RemUniqueColor((from e in this.Bod.全要素
			select e.本体.EnumAllPar()).JoinEnum<Par>());
		}

		public void Set衣装(IEnumerable<object> 衣装)
		{
			this.Bod.脱衣();
			Dictionary<Type, int> dictionary = new Dictionary<Type, int>();
			Dictionary<Type, PropertyInfo[]> dictionary2 = new Dictionary<Type, PropertyInfo[]>();
			string ts;
			Func<PropertyInfo, bool> <>9__0;
			foreach (object obj in 衣装)
			{
				Type type = obj.GetType();
				ts = type.ToString();
				if (dictionary.ContainsKey(type))
				{
					dictionary2[type][dictionary[type]].SetValue(this.Bod, obj, null);
					Dictionary<Type, int> dictionary3 = dictionary;
					Type key = type;
					int num = dictionary3[key];
					dictionary3[key] = num + 1;
				}
				else
				{
					dictionary.Add(type, 0);
					Dictionary<Type, PropertyInfo[]> dictionary4 = dictionary2;
					Type key2 = type;
					IEnumerable<PropertyInfo> properties = Sta.Bodt.GetProperties();
					Func<PropertyInfo, bool> predicate;
					if ((predicate = <>9__0) == null)
					{
						predicate = (<>9__0 = ((PropertyInfo e) => e.PropertyType.ToString() == ts));
					}
					dictionary4.Add(key2, properties.Where(predicate).ToArray<PropertyInfo>());
					dictionary2[type][dictionary[type]].SetValue(this.Bod, obj, null);
					Dictionary<Type, int> dictionary5 = dictionary;
					Type key = type;
					int num = dictionary5[key];
					dictionary5[key] = num + 1;
				}
			}
			if (!this.ChaD.股施術 && this.Bod.Is股防御())
			{
				this.Bod.Setピアス = Sta.ピアス初期化;
			}
			if (!this.ChaD.胸施術 && this.Bod.Is胸甲殻())
			{
				this.Bod.Setピアス左 = Sta.ピアス初期化;
				this.Bod.Setピアス右 = Sta.ピアス初期化;
			}
		}

		public void Setヴィオラ()
		{
			this.Bod.Setドレス首 = ドレス首情報.GetDefault();
			this.Bod.Set下着B_マイクロ = 下着B_マイクロ情報.Getマイクロ();
			this.Bod.Set下着B_マイクロ = 下着B_マイクロ情報.Getヴィオラ();
			this.Bod.Setドレス = ドレス情報.GetDefault();
			this.Bod.Setブ\u30FCツ = ブ\u30FCツ情報.GetDefault();
		}

		public Med Med;

		public Are Are;

		public Bod Bod;

		public ChaD ChaD;

		public 体配色 配色;

		public double FPS;

		public Vector2D CP;

		private Mot 呼吸;

		private double 呼吸速度_;

		private Mot 涙流し;

		private Mot 涙ひき;

		private bool 泣き_;

		private Mot 瞬き1;

		private Mot 瞬き2;

		public Mot 汗かき;

		public Mot 口腔精液垂れ;

		public Mot 性器精液垂れ;

		public Mot 肛門精液垂れ;

		public Mot 出糸精液垂れ;

		public Mot 潮吹小;

		public Mot 潮吹大;

		public Mot 飛沫;

		public Mot 唾散;

		public Mot 放尿;

		public Action 放尿強制終了_ = delegate()
		{
		};

		public Func<bool> Is放尿 = () => false;

		public Mot 噴乳;

		public double 噴乳染み;

		public Mot 鼻水;

		public Mot 涎;

		public Mot 目_追い;

		public bool 目逸し;

		public double 絶頂激しさ;

		public double 絶頂時間;

		public Mot 絶頂終了;

		public Mot 絶頂;

		public Mot 肛ヒク;

		public Mot 膣ヒク;

		public Mot 糸ヒク;

		public Mot 顔面展開;

		public Mot 体揺れ;

		public Mot 咳込み;

		public Mot ごっくん;

		private 汗掻き 汗掻き;

		public double 瞼基準単;

		public double 瞼基準左;

		public double 瞼基準右;

		public double 瞼基準額;

		public double 瞼基準頬左;

		public double 瞼基準頬右;

		public Action 潮吹擬音;

		public Action 放尿擬音;

		private double 呼吸_;

		private double y;

		private bool 重髪;

		private bool 重耳;

		private bool 重胸;

		private bool 重腰;

		private bool 重腕前;

		private bool 重半後;

		private bool 重半中1;

		private bool 重半中2;

		private bool 重半前;

		private bool 重腿;

		private Vector2D p = Dat.Vec2DZero;

		public Mots Mots = new Mots();
	}
}
