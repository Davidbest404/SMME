using System;
using System.Collections.Generic;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 多足_蠍 : 半身
	{
		public 多足_蠍(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 多足_蠍D e)
		{
			多足_蠍.<>c__DisplayClass120_0 CS$<>8__locals1 = new 多足_蠍.<>c__DisplayClass120_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "蠍";
			dif.Add(new Pars(Sta.半身["多足"][0][2]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			Pars pars2 = pars["前腹"].ToPars();
			Pars pars3 = pars2["腹節7"].ToPars();
			this.X0Y0_前腹_腹節7_節0 = pars3["節0"].ToPar();
			this.X0Y0_前腹_腹節7_節1 = pars3["節1"].ToPar();
			pars3 = pars2["腹節6"].ToPars();
			this.X0Y0_前腹_腹節6_節0 = pars3["節0"].ToPar();
			this.X0Y0_前腹_腹節6_節1 = pars3["節1"].ToPar();
			this.X0Y0_前腹_腹節6_節線 = pars3["節線"].ToPar();
			this.X0Y0_前腹_腹節6_気門左 = pars3["気門左"].ToPar();
			this.X0Y0_前腹_腹節6_気門右 = pars3["気門右"].ToPar();
			pars3 = pars2["腹節5"].ToPars();
			this.X0Y0_前腹_腹節5_節0 = pars3["節0"].ToPar();
			this.X0Y0_前腹_腹節5_節1 = pars3["節1"].ToPar();
			this.X0Y0_前腹_腹節5_節線 = pars3["節線"].ToPar();
			this.X0Y0_前腹_腹節5_気門左 = pars3["気門左"].ToPar();
			this.X0Y0_前腹_腹節5_気門右 = pars3["気門右"].ToPar();
			pars3 = pars2["腹節4"].ToPars();
			this.X0Y0_前腹_腹節4_節0 = pars3["節0"].ToPar();
			this.X0Y0_前腹_腹節4_節1 = pars3["節1"].ToPar();
			this.X0Y0_前腹_腹節4_節線 = pars3["節線"].ToPar();
			this.X0Y0_前腹_腹節4_気門左 = pars3["気門左"].ToPar();
			this.X0Y0_前腹_腹節4_気門右 = pars3["気門右"].ToPar();
			pars3 = pars2["腹節3"].ToPars();
			this.X0Y0_前腹_腹節3_節0 = pars3["節0"].ToPar();
			this.X0Y0_前腹_腹節3_節1 = pars3["節1"].ToPar();
			this.X0Y0_前腹_腹節3_節線 = pars3["節線"].ToPar();
			this.X0Y0_前腹_腹節3_気門左 = pars3["気門左"].ToPar();
			this.X0Y0_前腹_腹節3_気門右 = pars3["気門右"].ToPar();
			pars3 = pars2["腹節2"].ToPars();
			this.X0Y0_前腹_腹節2_節0 = pars3["節0"].ToPar();
			this.X0Y0_頭胸 = pars["頭胸"].ToPar();
			pars2 = pars["基節"].ToPars();
			this.X0Y0_基節_基節左0 = pars2["基節左0"].ToPar();
			this.X0Y0_基節_基節左1 = pars2["基節左1"].ToPar();
			this.X0Y0_基節_肢内突起左 = pars2["肢内突起左"].ToPar();
			this.X0Y0_基節_基節左2 = pars2["基節左2"].ToPar();
			this.X0Y0_基節_基節左3 = pars2["基節左3"].ToPar();
			this.X0Y0_基節_基節左4 = pars2["基節左4"].ToPar();
			this.X0Y0_基節_基節右0 = pars2["基節右0"].ToPar();
			this.X0Y0_基節_基節右1 = pars2["基節右1"].ToPar();
			this.X0Y0_基節_肢内突起右 = pars2["肢内突起右"].ToPar();
			this.X0Y0_基節_基節右2 = pars2["基節右2"].ToPar();
			this.X0Y0_基節_基節右3 = pars2["基節右3"].ToPar();
			this.X0Y0_基節_基節右4 = pars2["基節右4"].ToPar();
			this.X0Y0_生殖口蓋左 = pars["生殖口蓋左"].ToPar();
			this.X0Y0_生殖口蓋右 = pars["生殖口蓋右"].ToPar();
			pars2 = pars["生殖口"].ToPars();
			this.X0Y0_生殖口_生殖口0 = pars2["生殖口0"].ToPar();
			this.X0Y0_生殖口_生殖口1 = pars2["生殖口1"].ToPar();
			this.本体.SetJoints();
			this.接続根 = new JointD(this.本体);
			this.右 = e.右;
			this.反転X = e.反転X;
			this.反転Y = e.反転Y;
			this.基準C = e.基準C;
			this.位置C = e.位置C;
			this.角度B = e.角度B;
			this.角度C = e.角度C;
			this.尺度B = e.尺度B;
			this.尺度C = e.尺度C;
			this.尺度XB = e.尺度XB;
			this.尺度XC = e.尺度XC;
			this.尺度YB = e.尺度YB;
			this.尺度YC = e.尺度YC;
			this.肥大 = e.肥大;
			this.身長 = e.身長;
			this.Xv = e.Xv;
			this.Yv = e.Yv;
			this.Xi = e.Xi;
			this.Yi = e.Yi;
			this.サイズ = e.サイズ;
			this.サイズX = e.サイズX;
			this.サイズY = e.サイズY;
			this.前腹_腹節7_節0_表示 = e.前腹_腹節7_節0_表示;
			this.前腹_腹節7_節1_表示 = e.前腹_腹節7_節1_表示;
			this.前腹_腹節6_節0_表示 = e.前腹_腹節6_節0_表示;
			this.前腹_腹節6_節1_表示 = e.前腹_腹節6_節1_表示;
			this.前腹_腹節6_節線_表示 = e.前腹_腹節6_節線_表示;
			this.前腹_腹節6_気門左_表示 = e.前腹_腹節6_気門左_表示;
			this.前腹_腹節6_気門右_表示 = e.前腹_腹節6_気門右_表示;
			this.前腹_腹節5_節0_表示 = e.前腹_腹節5_節0_表示;
			this.前腹_腹節5_節1_表示 = e.前腹_腹節5_節1_表示;
			this.前腹_腹節5_節線_表示 = e.前腹_腹節5_節線_表示;
			this.前腹_腹節5_気門左_表示 = e.前腹_腹節5_気門左_表示;
			this.前腹_腹節5_気門右_表示 = e.前腹_腹節5_気門右_表示;
			this.前腹_腹節4_節0_表示 = e.前腹_腹節4_節0_表示;
			this.前腹_腹節4_節1_表示 = e.前腹_腹節4_節1_表示;
			this.前腹_腹節4_節線_表示 = e.前腹_腹節4_節線_表示;
			this.前腹_腹節4_気門左_表示 = e.前腹_腹節4_気門左_表示;
			this.前腹_腹節4_気門右_表示 = e.前腹_腹節4_気門右_表示;
			this.前腹_腹節3_節0_表示 = e.前腹_腹節3_節0_表示;
			this.前腹_腹節3_節1_表示 = e.前腹_腹節3_節1_表示;
			this.前腹_腹節3_節線_表示 = e.前腹_腹節3_節線_表示;
			this.前腹_腹節3_気門左_表示 = e.前腹_腹節3_気門左_表示;
			this.前腹_腹節3_気門右_表示 = e.前腹_腹節3_気門右_表示;
			this.前腹_腹節2_節0_表示 = e.前腹_腹節2_節0_表示;
			this.頭胸_表示 = e.頭胸_表示;
			this.基節_基節左0_表示 = e.基節_基節左0_表示;
			this.基節_基節左1_表示 = e.基節_基節左1_表示;
			this.基節_肢内突起左_表示 = e.基節_肢内突起左_表示;
			this.基節_基節左2_表示 = e.基節_基節左2_表示;
			this.基節_基節左3_表示 = e.基節_基節左3_表示;
			this.基節_基節左4_表示 = e.基節_基節左4_表示;
			this.基節_基節右0_表示 = e.基節_基節右0_表示;
			this.基節_基節右1_表示 = e.基節_基節右1_表示;
			this.基節_肢内突起右_表示 = e.基節_肢内突起右_表示;
			this.基節_基節右2_表示 = e.基節_基節右2_表示;
			this.基節_基節右3_表示 = e.基節_基節右3_表示;
			this.基節_基節右4_表示 = e.基節_基節右4_表示;
			this.生殖口蓋左_表示 = e.生殖口蓋左_表示;
			this.生殖口蓋右_表示 = e.生殖口蓋右_表示;
			this.生殖口_生殖口0_表示 = e.生殖口_生殖口0_表示;
			this.生殖口_生殖口1_表示 = e.生殖口_生殖口1_表示;
			this.くぱぁ = e.くぱぁ;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.触肢左_接続.Count > 0)
			{
				Ele f;
				this.触肢左_接続 = e.触肢左_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.多足_蠍_触肢左_接続;
					f.接続(CS$<>8__locals1.<>4__this.触肢左_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.節足左1_接続.Count > 0)
			{
				Ele f;
				this.節足左1_接続 = e.節足左1_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.多足_蠍_節足左1_接続;
					f.接続(CS$<>8__locals1.<>4__this.節足左1_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.節足左2_接続.Count > 0)
			{
				Ele f;
				this.節足左2_接続 = e.節足左2_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.多足_蠍_節足左2_接続;
					f.接続(CS$<>8__locals1.<>4__this.節足左2_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.節足左3_接続.Count > 0)
			{
				Ele f;
				this.節足左3_接続 = e.節足左3_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.多足_蠍_節足左3_接続;
					f.接続(CS$<>8__locals1.<>4__this.節足左3_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.節足左4_接続.Count > 0)
			{
				Ele f;
				this.節足左4_接続 = e.節足左4_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.多足_蠍_節足左4_接続;
					f.接続(CS$<>8__locals1.<>4__this.節足左4_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.触肢右_接続.Count > 0)
			{
				Ele f;
				this.触肢右_接続 = e.触肢右_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.多足_蠍_触肢右_接続;
					f.接続(CS$<>8__locals1.<>4__this.触肢右_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.節足右1_接続.Count > 0)
			{
				Ele f;
				this.節足右1_接続 = e.節足右1_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.多足_蠍_節足右1_接続;
					f.接続(CS$<>8__locals1.<>4__this.節足右1_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.節足右2_接続.Count > 0)
			{
				Ele f;
				this.節足右2_接続 = e.節足右2_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.多足_蠍_節足右2_接続;
					f.接続(CS$<>8__locals1.<>4__this.節足右2_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.節足右3_接続.Count > 0)
			{
				Ele f;
				this.節足右3_接続 = e.節足右3_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.多足_蠍_節足右3_接続;
					f.接続(CS$<>8__locals1.<>4__this.節足右3_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.節足右4_接続.Count > 0)
			{
				Ele f;
				this.節足右4_接続 = e.節足右4_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.多足_蠍_節足右4_接続;
					f.接続(CS$<>8__locals1.<>4__this.節足右4_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.櫛状板左_接続.Count > 0)
			{
				Ele f;
				this.櫛状板左_接続 = e.櫛状板左_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.多足_蠍_櫛状板左_接続;
					f.接続(CS$<>8__locals1.<>4__this.櫛状板左_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.櫛状板右_接続.Count > 0)
			{
				Ele f;
				this.櫛状板右_接続 = e.櫛状板右_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.多足_蠍_櫛状板右_接続;
					f.接続(CS$<>8__locals1.<>4__this.櫛状板右_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.尾_接続.Count > 0)
			{
				Ele f;
				this.尾_接続 = e.尾_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.多足_蠍_尾_接続;
					f.接続(CS$<>8__locals1.<>4__this.尾_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_前腹_腹節7_節0CP = new ColorP(this.X0Y0_前腹_腹節7_節0, this.前腹_腹節7_節0CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_前腹_腹節7_節1CP = new ColorP(this.X0Y0_前腹_腹節7_節1, this.前腹_腹節7_節1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_前腹_腹節6_節0CP = new ColorP(this.X0Y0_前腹_腹節6_節0, this.前腹_腹節6_節0CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_前腹_腹節6_節1CP = new ColorP(this.X0Y0_前腹_腹節6_節1, this.前腹_腹節6_節1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_前腹_腹節6_節線CP = new ColorP(this.X0Y0_前腹_腹節6_節線, this.前腹_腹節6_節線CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_前腹_腹節6_気門左CP = new ColorP(this.X0Y0_前腹_腹節6_気門左, this.前腹_腹節6_気門左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_前腹_腹節6_気門右CP = new ColorP(this.X0Y0_前腹_腹節6_気門右, this.前腹_腹節6_気門右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_前腹_腹節5_節0CP = new ColorP(this.X0Y0_前腹_腹節5_節0, this.前腹_腹節5_節0CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_前腹_腹節5_節1CP = new ColorP(this.X0Y0_前腹_腹節5_節1, this.前腹_腹節5_節1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_前腹_腹節5_節線CP = new ColorP(this.X0Y0_前腹_腹節5_節線, this.前腹_腹節5_節線CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_前腹_腹節5_気門左CP = new ColorP(this.X0Y0_前腹_腹節5_気門左, this.前腹_腹節5_気門左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_前腹_腹節5_気門右CP = new ColorP(this.X0Y0_前腹_腹節5_気門右, this.前腹_腹節5_気門右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_前腹_腹節4_節0CP = new ColorP(this.X0Y0_前腹_腹節4_節0, this.前腹_腹節4_節0CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_前腹_腹節4_節1CP = new ColorP(this.X0Y0_前腹_腹節4_節1, this.前腹_腹節4_節1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_前腹_腹節4_節線CP = new ColorP(this.X0Y0_前腹_腹節4_節線, this.前腹_腹節4_節線CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_前腹_腹節4_気門左CP = new ColorP(this.X0Y0_前腹_腹節4_気門左, this.前腹_腹節4_気門左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_前腹_腹節4_気門右CP = new ColorP(this.X0Y0_前腹_腹節4_気門右, this.前腹_腹節4_気門右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_前腹_腹節3_節0CP = new ColorP(this.X0Y0_前腹_腹節3_節0, this.前腹_腹節3_節0CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_前腹_腹節3_節1CP = new ColorP(this.X0Y0_前腹_腹節3_節1, this.前腹_腹節3_節1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_前腹_腹節3_節線CP = new ColorP(this.X0Y0_前腹_腹節3_節線, this.前腹_腹節3_節線CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_前腹_腹節3_気門左CP = new ColorP(this.X0Y0_前腹_腹節3_気門左, this.前腹_腹節3_気門左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_前腹_腹節3_気門右CP = new ColorP(this.X0Y0_前腹_腹節3_気門右, this.前腹_腹節3_気門右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_前腹_腹節2_節0CP = new ColorP(this.X0Y0_前腹_腹節2_節0, this.前腹_腹節2_節0CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭胸CP = new ColorP(this.X0Y0_頭胸, this.頭胸CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_基節_基節左0CP = new ColorP(this.X0Y0_基節_基節左0, this.基節_基節左0CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_基節_基節左1CP = new ColorP(this.X0Y0_基節_基節左1, this.基節_基節左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_基節_肢内突起左CP = new ColorP(this.X0Y0_基節_肢内突起左, this.基節_肢内突起左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_基節_基節左2CP = new ColorP(this.X0Y0_基節_基節左2, this.基節_基節左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_基節_基節左3CP = new ColorP(this.X0Y0_基節_基節左3, this.基節_基節左3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_基節_基節左4CP = new ColorP(this.X0Y0_基節_基節左4, this.基節_基節左4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_基節_基節右0CP = new ColorP(this.X0Y0_基節_基節右0, this.基節_基節右0CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_基節_基節右1CP = new ColorP(this.X0Y0_基節_基節右1, this.基節_基節右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_基節_肢内突起右CP = new ColorP(this.X0Y0_基節_肢内突起右, this.基節_肢内突起右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_基節_基節右2CP = new ColorP(this.X0Y0_基節_基節右2, this.基節_基節右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_基節_基節右3CP = new ColorP(this.X0Y0_基節_基節右3, this.基節_基節右3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_基節_基節右4CP = new ColorP(this.X0Y0_基節_基節右4, this.基節_基節右4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_生殖口蓋左CP = new ColorP(this.X0Y0_生殖口蓋左, this.生殖口蓋左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_生殖口蓋右CP = new ColorP(this.X0Y0_生殖口蓋右, this.生殖口蓋右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_生殖口_生殖口0CP = new ColorP(this.X0Y0_生殖口_生殖口0, this.生殖口_生殖口0CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_生殖口_生殖口1CP = new ColorP(this.X0Y0_生殖口_生殖口1, this.生殖口_生殖口1CD, CS$<>8__locals1.DisUnit, true);
			this.濃度 = e.濃度;
		}

		public override bool 欠損
		{
			get
			{
				return this.欠損_;
			}
			set
			{
				this.欠損_ = value;
			}
		}

		public override bool 筋肉
		{
			get
			{
				return this.筋肉_;
			}
			set
			{
				this.筋肉_ = value;
			}
		}

		public override bool 拘束
		{
			get
			{
				return this.拘束_;
			}
			set
			{
				this.拘束_ = value;
			}
		}

		public bool 前腹_腹節7_節0_表示
		{
			get
			{
				return this.X0Y0_前腹_腹節7_節0.Dra;
			}
			set
			{
				this.X0Y0_前腹_腹節7_節0.Dra = value;
				this.X0Y0_前腹_腹節7_節0.Hit = value;
			}
		}

		public bool 前腹_腹節7_節1_表示
		{
			get
			{
				return this.X0Y0_前腹_腹節7_節1.Dra;
			}
			set
			{
				this.X0Y0_前腹_腹節7_節1.Dra = value;
				this.X0Y0_前腹_腹節7_節1.Hit = value;
			}
		}

		public bool 前腹_腹節6_節0_表示
		{
			get
			{
				return this.X0Y0_前腹_腹節6_節0.Dra;
			}
			set
			{
				this.X0Y0_前腹_腹節6_節0.Dra = value;
				this.X0Y0_前腹_腹節6_節0.Hit = value;
			}
		}

		public bool 前腹_腹節6_節1_表示
		{
			get
			{
				return this.X0Y0_前腹_腹節6_節1.Dra;
			}
			set
			{
				this.X0Y0_前腹_腹節6_節1.Dra = value;
				this.X0Y0_前腹_腹節6_節1.Hit = value;
			}
		}

		public bool 前腹_腹節6_節線_表示
		{
			get
			{
				return this.X0Y0_前腹_腹節6_節線.Dra;
			}
			set
			{
				this.X0Y0_前腹_腹節6_節線.Dra = value;
				this.X0Y0_前腹_腹節6_節線.Hit = value;
			}
		}

		public bool 前腹_腹節6_気門左_表示
		{
			get
			{
				return this.X0Y0_前腹_腹節6_気門左.Dra;
			}
			set
			{
				this.X0Y0_前腹_腹節6_気門左.Dra = value;
				this.X0Y0_前腹_腹節6_気門左.Hit = value;
			}
		}

		public bool 前腹_腹節6_気門右_表示
		{
			get
			{
				return this.X0Y0_前腹_腹節6_気門右.Dra;
			}
			set
			{
				this.X0Y0_前腹_腹節6_気門右.Dra = value;
				this.X0Y0_前腹_腹節6_気門右.Hit = value;
			}
		}

		public bool 前腹_腹節5_節0_表示
		{
			get
			{
				return this.X0Y0_前腹_腹節5_節0.Dra;
			}
			set
			{
				this.X0Y0_前腹_腹節5_節0.Dra = value;
				this.X0Y0_前腹_腹節5_節0.Hit = value;
			}
		}

		public bool 前腹_腹節5_節1_表示
		{
			get
			{
				return this.X0Y0_前腹_腹節5_節1.Dra;
			}
			set
			{
				this.X0Y0_前腹_腹節5_節1.Dra = value;
				this.X0Y0_前腹_腹節5_節1.Hit = value;
			}
		}

		public bool 前腹_腹節5_節線_表示
		{
			get
			{
				return this.X0Y0_前腹_腹節5_節線.Dra;
			}
			set
			{
				this.X0Y0_前腹_腹節5_節線.Dra = value;
				this.X0Y0_前腹_腹節5_節線.Hit = value;
			}
		}

		public bool 前腹_腹節5_気門左_表示
		{
			get
			{
				return this.X0Y0_前腹_腹節5_気門左.Dra;
			}
			set
			{
				this.X0Y0_前腹_腹節5_気門左.Dra = value;
				this.X0Y0_前腹_腹節5_気門左.Hit = value;
			}
		}

		public bool 前腹_腹節5_気門右_表示
		{
			get
			{
				return this.X0Y0_前腹_腹節5_気門右.Dra;
			}
			set
			{
				this.X0Y0_前腹_腹節5_気門右.Dra = value;
				this.X0Y0_前腹_腹節5_気門右.Hit = value;
			}
		}

		public bool 前腹_腹節4_節0_表示
		{
			get
			{
				return this.X0Y0_前腹_腹節4_節0.Dra;
			}
			set
			{
				this.X0Y0_前腹_腹節4_節0.Dra = value;
				this.X0Y0_前腹_腹節4_節0.Hit = value;
			}
		}

		public bool 前腹_腹節4_節1_表示
		{
			get
			{
				return this.X0Y0_前腹_腹節4_節1.Dra;
			}
			set
			{
				this.X0Y0_前腹_腹節4_節1.Dra = value;
				this.X0Y0_前腹_腹節4_節1.Hit = value;
			}
		}

		public bool 前腹_腹節4_節線_表示
		{
			get
			{
				return this.X0Y0_前腹_腹節4_節線.Dra;
			}
			set
			{
				this.X0Y0_前腹_腹節4_節線.Dra = value;
				this.X0Y0_前腹_腹節4_節線.Hit = value;
			}
		}

		public bool 前腹_腹節4_気門左_表示
		{
			get
			{
				return this.X0Y0_前腹_腹節4_気門左.Dra;
			}
			set
			{
				this.X0Y0_前腹_腹節4_気門左.Dra = value;
				this.X0Y0_前腹_腹節4_気門左.Hit = value;
			}
		}

		public bool 前腹_腹節4_気門右_表示
		{
			get
			{
				return this.X0Y0_前腹_腹節4_気門右.Dra;
			}
			set
			{
				this.X0Y0_前腹_腹節4_気門右.Dra = value;
				this.X0Y0_前腹_腹節4_気門右.Hit = value;
			}
		}

		public bool 前腹_腹節3_節0_表示
		{
			get
			{
				return this.X0Y0_前腹_腹節3_節0.Dra;
			}
			set
			{
				this.X0Y0_前腹_腹節3_節0.Dra = value;
				this.X0Y0_前腹_腹節3_節0.Hit = value;
			}
		}

		public bool 前腹_腹節3_節1_表示
		{
			get
			{
				return this.X0Y0_前腹_腹節3_節1.Dra;
			}
			set
			{
				this.X0Y0_前腹_腹節3_節1.Dra = value;
				this.X0Y0_前腹_腹節3_節1.Hit = value;
			}
		}

		public bool 前腹_腹節3_節線_表示
		{
			get
			{
				return this.X0Y0_前腹_腹節3_節線.Dra;
			}
			set
			{
				this.X0Y0_前腹_腹節3_節線.Dra = value;
				this.X0Y0_前腹_腹節3_節線.Hit = value;
			}
		}

		public bool 前腹_腹節3_気門左_表示
		{
			get
			{
				return this.X0Y0_前腹_腹節3_気門左.Dra;
			}
			set
			{
				this.X0Y0_前腹_腹節3_気門左.Dra = value;
				this.X0Y0_前腹_腹節3_気門左.Hit = value;
			}
		}

		public bool 前腹_腹節3_気門右_表示
		{
			get
			{
				return this.X0Y0_前腹_腹節3_気門右.Dra;
			}
			set
			{
				this.X0Y0_前腹_腹節3_気門右.Dra = value;
				this.X0Y0_前腹_腹節3_気門右.Hit = value;
			}
		}

		public bool 前腹_腹節2_節0_表示
		{
			get
			{
				return this.X0Y0_前腹_腹節2_節0.Dra;
			}
			set
			{
				this.X0Y0_前腹_腹節2_節0.Dra = value;
				this.X0Y0_前腹_腹節2_節0.Hit = value;
			}
		}

		public bool 頭胸_表示
		{
			get
			{
				return this.X0Y0_頭胸.Dra;
			}
			set
			{
				this.X0Y0_頭胸.Dra = value;
				this.X0Y0_頭胸.Hit = value;
			}
		}

		public bool 基節_基節左0_表示
		{
			get
			{
				return this.X0Y0_基節_基節左0.Dra;
			}
			set
			{
				this.X0Y0_基節_基節左0.Dra = value;
				this.X0Y0_基節_基節左0.Hit = value;
			}
		}

		public bool 基節_基節左1_表示
		{
			get
			{
				return this.X0Y0_基節_基節左1.Dra;
			}
			set
			{
				this.X0Y0_基節_基節左1.Dra = value;
				this.X0Y0_基節_基節左1.Hit = value;
			}
		}

		public bool 基節_肢内突起左_表示
		{
			get
			{
				return this.X0Y0_基節_肢内突起左.Dra;
			}
			set
			{
				this.X0Y0_基節_肢内突起左.Dra = value;
				this.X0Y0_基節_肢内突起左.Hit = value;
			}
		}

		public bool 基節_基節左2_表示
		{
			get
			{
				return this.X0Y0_基節_基節左2.Dra;
			}
			set
			{
				this.X0Y0_基節_基節左2.Dra = value;
				this.X0Y0_基節_基節左2.Hit = value;
			}
		}

		public bool 基節_基節左3_表示
		{
			get
			{
				return this.X0Y0_基節_基節左3.Dra;
			}
			set
			{
				this.X0Y0_基節_基節左3.Dra = value;
				this.X0Y0_基節_基節左3.Hit = value;
			}
		}

		public bool 基節_基節左4_表示
		{
			get
			{
				return this.X0Y0_基節_基節左4.Dra;
			}
			set
			{
				this.X0Y0_基節_基節左4.Dra = value;
				this.X0Y0_基節_基節左4.Hit = value;
			}
		}

		public bool 基節_基節右0_表示
		{
			get
			{
				return this.X0Y0_基節_基節右0.Dra;
			}
			set
			{
				this.X0Y0_基節_基節右0.Dra = value;
				this.X0Y0_基節_基節右0.Hit = value;
			}
		}

		public bool 基節_基節右1_表示
		{
			get
			{
				return this.X0Y0_基節_基節右1.Dra;
			}
			set
			{
				this.X0Y0_基節_基節右1.Dra = value;
				this.X0Y0_基節_基節右1.Hit = value;
			}
		}

		public bool 基節_肢内突起右_表示
		{
			get
			{
				return this.X0Y0_基節_肢内突起右.Dra;
			}
			set
			{
				this.X0Y0_基節_肢内突起右.Dra = value;
				this.X0Y0_基節_肢内突起右.Hit = value;
			}
		}

		public bool 基節_基節右2_表示
		{
			get
			{
				return this.X0Y0_基節_基節右2.Dra;
			}
			set
			{
				this.X0Y0_基節_基節右2.Dra = value;
				this.X0Y0_基節_基節右2.Hit = value;
			}
		}

		public bool 基節_基節右3_表示
		{
			get
			{
				return this.X0Y0_基節_基節右3.Dra;
			}
			set
			{
				this.X0Y0_基節_基節右3.Dra = value;
				this.X0Y0_基節_基節右3.Hit = value;
			}
		}

		public bool 基節_基節右4_表示
		{
			get
			{
				return this.X0Y0_基節_基節右4.Dra;
			}
			set
			{
				this.X0Y0_基節_基節右4.Dra = value;
				this.X0Y0_基節_基節右4.Hit = value;
			}
		}

		public bool 生殖口蓋左_表示
		{
			get
			{
				return this.X0Y0_生殖口蓋左.Dra;
			}
			set
			{
				this.X0Y0_生殖口蓋左.Dra = value;
				this.X0Y0_生殖口蓋左.Hit = value;
			}
		}

		public bool 生殖口蓋右_表示
		{
			get
			{
				return this.X0Y0_生殖口蓋右.Dra;
			}
			set
			{
				this.X0Y0_生殖口蓋右.Dra = value;
				this.X0Y0_生殖口蓋右.Hit = value;
			}
		}

		public bool 生殖口_生殖口0_表示
		{
			get
			{
				return this.X0Y0_生殖口_生殖口0.Dra;
			}
			set
			{
				this.X0Y0_生殖口_生殖口0.Dra = value;
				this.X0Y0_生殖口_生殖口0.Hit = value;
			}
		}

		public bool 生殖口_生殖口1_表示
		{
			get
			{
				return this.X0Y0_生殖口_生殖口1.Dra;
			}
			set
			{
				this.X0Y0_生殖口_生殖口1.Dra = value;
				this.X0Y0_生殖口_生殖口1.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.前腹_腹節7_節0_表示;
			}
			set
			{
				this.前腹_腹節7_節0_表示 = value;
				this.前腹_腹節7_節1_表示 = value;
				this.前腹_腹節6_節0_表示 = value;
				this.前腹_腹節6_節1_表示 = value;
				this.前腹_腹節6_節線_表示 = value;
				this.前腹_腹節6_気門左_表示 = value;
				this.前腹_腹節6_気門右_表示 = value;
				this.前腹_腹節5_節0_表示 = value;
				this.前腹_腹節5_節1_表示 = value;
				this.前腹_腹節5_節線_表示 = value;
				this.前腹_腹節5_気門左_表示 = value;
				this.前腹_腹節5_気門右_表示 = value;
				this.前腹_腹節4_節0_表示 = value;
				this.前腹_腹節4_節1_表示 = value;
				this.前腹_腹節4_節線_表示 = value;
				this.前腹_腹節4_気門左_表示 = value;
				this.前腹_腹節4_気門右_表示 = value;
				this.前腹_腹節3_節0_表示 = value;
				this.前腹_腹節3_節1_表示 = value;
				this.前腹_腹節3_節線_表示 = value;
				this.前腹_腹節3_気門左_表示 = value;
				this.前腹_腹節3_気門右_表示 = value;
				this.前腹_腹節2_節0_表示 = value;
				this.頭胸_表示 = value;
				this.基節_基節左0_表示 = value;
				this.基節_基節左1_表示 = value;
				this.基節_肢内突起左_表示 = value;
				this.基節_基節左2_表示 = value;
				this.基節_基節左3_表示 = value;
				this.基節_基節左4_表示 = value;
				this.基節_基節右0_表示 = value;
				this.基節_基節右1_表示 = value;
				this.基節_肢内突起右_表示 = value;
				this.基節_基節右2_表示 = value;
				this.基節_基節右3_表示 = value;
				this.基節_基節右4_表示 = value;
				this.生殖口蓋左_表示 = value;
				this.生殖口蓋右_表示 = value;
				this.生殖口_生殖口0_表示 = value;
				this.生殖口_生殖口1_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.前腹_腹節7_節0CD.不透明度;
			}
			set
			{
				this.前腹_腹節7_節0CD.不透明度 = value;
				this.前腹_腹節7_節1CD.不透明度 = value;
				this.前腹_腹節6_節0CD.不透明度 = value;
				this.前腹_腹節6_節1CD.不透明度 = value;
				this.前腹_腹節6_節線CD.不透明度 = value;
				this.前腹_腹節6_気門左CD.不透明度 = value;
				this.前腹_腹節6_気門右CD.不透明度 = value;
				this.前腹_腹節5_節0CD.不透明度 = value;
				this.前腹_腹節5_節1CD.不透明度 = value;
				this.前腹_腹節5_節線CD.不透明度 = value;
				this.前腹_腹節5_気門左CD.不透明度 = value;
				this.前腹_腹節5_気門右CD.不透明度 = value;
				this.前腹_腹節4_節0CD.不透明度 = value;
				this.前腹_腹節4_節1CD.不透明度 = value;
				this.前腹_腹節4_節線CD.不透明度 = value;
				this.前腹_腹節4_気門左CD.不透明度 = value;
				this.前腹_腹節4_気門右CD.不透明度 = value;
				this.前腹_腹節3_節0CD.不透明度 = value;
				this.前腹_腹節3_節1CD.不透明度 = value;
				this.前腹_腹節3_節線CD.不透明度 = value;
				this.前腹_腹節3_気門左CD.不透明度 = value;
				this.前腹_腹節3_気門右CD.不透明度 = value;
				this.前腹_腹節2_節0CD.不透明度 = value;
				this.頭胸CD.不透明度 = value;
				this.基節_基節左0CD.不透明度 = value;
				this.基節_基節左1CD.不透明度 = value;
				this.基節_肢内突起左CD.不透明度 = value;
				this.基節_基節左2CD.不透明度 = value;
				this.基節_基節左3CD.不透明度 = value;
				this.基節_基節左4CD.不透明度 = value;
				this.基節_基節右0CD.不透明度 = value;
				this.基節_基節右1CD.不透明度 = value;
				this.基節_肢内突起右CD.不透明度 = value;
				this.基節_基節右2CD.不透明度 = value;
				this.基節_基節右3CD.不透明度 = value;
				this.基節_基節右4CD.不透明度 = value;
				this.生殖口蓋左CD.不透明度 = value;
				this.生殖口蓋右CD.不透明度 = value;
				this.生殖口_生殖口0CD.不透明度 = value;
				this.生殖口_生殖口1CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			double num = this.右 ? -1.0 : 1.0;
			this.X0Y0_基節_基節左0.AngleBase = num * 39.0;
			this.X0Y0_基節_基節左1.AngleBase = num * 22.0;
			this.X0Y0_基節_基節左2.AngleBase = num * -11.0;
			this.X0Y0_基節_基節左3.AngleBase = num * -36.0;
			this.X0Y0_基節_基節左4.AngleBase = num * -45.0;
			this.X0Y0_基節_基節右0.AngleBase = num * -39.0;
			this.X0Y0_基節_基節右1.AngleBase = num * -22.0;
			this.X0Y0_基節_基節右2.AngleBase = num * 11.0;
			this.X0Y0_基節_基節右3.AngleBase = num * 36.0;
			this.X0Y0_基節_基節右4.AngleBase = num * 45.0;
			double maxAngle = 10.0;
			this.X0Y0_前腹_腹節7_節0.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_前腹_腹節6_節0.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_前腹_腹節5_節0.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_前腹_腹節4_節0.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_前腹_腹節3_節0.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_前腹_腹節2_節0.AngleBase = maxAngle.GetRanAngle();
			this.本体.JoinPAall();
		}

		public IEnumerable<Par> 軸列挙()
		{
			yield return this.X0Y0_前腹_腹節2_節0;
			yield return this.X0Y0_前腹_腹節3_節0;
			yield return this.X0Y0_前腹_腹節4_節0;
			yield return this.X0Y0_前腹_腹節5_節0;
			yield return this.X0Y0_前腹_腹節6_節0;
			yield return this.X0Y0_前腹_腹節7_節0;
			yield break;
		}

		public double くぱぁ
		{
			get
			{
				return this.くぱぁ_;
			}
			set
			{
				this.くぱぁ_ = value;
				this.X0Y0_生殖口蓋左.AngleBase = 18.0 * this.くぱぁ_;
				this.X0Y0_生殖口蓋右.AngleBase = -18.0 * this.くぱぁ_;
			}
		}

		public override void 描画0(Are Are)
		{
			Are.Draw(this.X0Y0_前腹_腹節7_節0);
			Are.Draw(this.X0Y0_前腹_腹節7_節1);
			Are.Draw(this.X0Y0_前腹_腹節6_節0);
			Are.Draw(this.X0Y0_前腹_腹節6_節1);
			Are.Draw(this.X0Y0_前腹_腹節6_節線);
			Are.Draw(this.X0Y0_前腹_腹節6_気門左);
			Are.Draw(this.X0Y0_前腹_腹節6_気門右);
			Are.Draw(this.X0Y0_前腹_腹節5_節0);
			Are.Draw(this.X0Y0_前腹_腹節5_節1);
			Are.Draw(this.X0Y0_前腹_腹節5_節線);
			Are.Draw(this.X0Y0_前腹_腹節5_気門左);
			Are.Draw(this.X0Y0_前腹_腹節5_気門右);
			Are.Draw(this.X0Y0_前腹_腹節4_節0);
			Are.Draw(this.X0Y0_前腹_腹節4_節1);
			Are.Draw(this.X0Y0_前腹_腹節4_節線);
			Are.Draw(this.X0Y0_前腹_腹節4_気門左);
			Are.Draw(this.X0Y0_前腹_腹節4_気門右);
			Are.Draw(this.X0Y0_前腹_腹節3_節0);
			Are.Draw(this.X0Y0_前腹_腹節3_節1);
			Are.Draw(this.X0Y0_前腹_腹節3_節線);
			Are.Draw(this.X0Y0_前腹_腹節3_気門左);
			Are.Draw(this.X0Y0_前腹_腹節3_気門右);
			Are.Draw(this.X0Y0_前腹_腹節2_節0);
			Are.Draw(this.X0Y0_頭胸);
			Are.Draw(this.X0Y0_基節_基節左0);
			Are.Draw(this.X0Y0_基節_基節左1);
			Are.Draw(this.X0Y0_基節_基節左2);
			Are.Draw(this.X0Y0_基節_基節左3);
			Are.Draw(this.X0Y0_基節_基節左4);
			Are.Draw(this.X0Y0_基節_基節右0);
			Are.Draw(this.X0Y0_基節_基節右1);
			Are.Draw(this.X0Y0_基節_基節右2);
			Are.Draw(this.X0Y0_基節_基節右3);
			Are.Draw(this.X0Y0_基節_基節右4);
			Are.Draw(this.X0Y0_生殖口_生殖口0);
			Are.Draw(this.X0Y0_生殖口_生殖口1);
		}

		public void 前描画(Are Are)
		{
			Are.Draw(this.X0Y0_基節_肢内突起左);
			Are.Draw(this.X0Y0_基節_肢内突起右);
			Are.Draw(this.X0Y0_生殖口蓋左);
			Are.Draw(this.X0Y0_生殖口蓋右);
		}

		public JointS 触肢左_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_基節_基節左0, 0);
			}
		}

		public JointS 節足左1_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_基節_基節左1, 0);
			}
		}

		public JointS 節足左2_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_基節_基節左2, 0);
			}
		}

		public JointS 節足左3_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_基節_基節左3, 0);
			}
		}

		public JointS 節足左4_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_基節_基節左4, 0);
			}
		}

		public JointS 触肢右_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_基節_基節右0, 0);
			}
		}

		public JointS 節足右1_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_基節_基節右1, 0);
			}
		}

		public JointS 節足右2_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_基節_基節右2, 0);
			}
		}

		public JointS 節足右3_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_基節_基節右3, 0);
			}
		}

		public JointS 節足右4_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_基節_基節右4, 0);
			}
		}

		public JointS 櫛状板左_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_生殖口_生殖口1, 0);
			}
		}

		public JointS 櫛状板右_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_生殖口_生殖口1, 1);
			}
		}

		public JointS 尾_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_前腹_腹節7_節0, 2);
			}
		}

		public override void 色更新()
		{
			this.X0Y0_前腹_腹節7_節0CP.Update();
			this.X0Y0_前腹_腹節7_節1CP.Update();
			this.X0Y0_前腹_腹節6_節0CP.Update();
			this.X0Y0_前腹_腹節6_節1CP.Update();
			this.X0Y0_前腹_腹節6_節線CP.Update();
			this.X0Y0_前腹_腹節6_気門左CP.Update();
			this.X0Y0_前腹_腹節6_気門右CP.Update();
			this.X0Y0_前腹_腹節5_節0CP.Update();
			this.X0Y0_前腹_腹節5_節1CP.Update();
			this.X0Y0_前腹_腹節5_節線CP.Update();
			this.X0Y0_前腹_腹節5_気門左CP.Update();
			this.X0Y0_前腹_腹節5_気門右CP.Update();
			this.X0Y0_前腹_腹節4_節0CP.Update();
			this.X0Y0_前腹_腹節4_節1CP.Update();
			this.X0Y0_前腹_腹節4_節線CP.Update();
			this.X0Y0_前腹_腹節4_気門左CP.Update();
			this.X0Y0_前腹_腹節4_気門右CP.Update();
			this.X0Y0_前腹_腹節3_節0CP.Update();
			this.X0Y0_前腹_腹節3_節1CP.Update();
			this.X0Y0_前腹_腹節3_節線CP.Update();
			this.X0Y0_前腹_腹節3_気門左CP.Update();
			this.X0Y0_前腹_腹節3_気門右CP.Update();
			this.X0Y0_前腹_腹節2_節0CP.Update();
			this.X0Y0_頭胸CP.Update();
			this.X0Y0_基節_基節左0CP.Update();
			this.X0Y0_基節_基節左1CP.Update();
			this.X0Y0_基節_肢内突起左CP.Update();
			this.X0Y0_基節_基節左2CP.Update();
			this.X0Y0_基節_基節左3CP.Update();
			this.X0Y0_基節_基節左4CP.Update();
			this.X0Y0_基節_基節右0CP.Update();
			this.X0Y0_基節_基節右1CP.Update();
			this.X0Y0_基節_肢内突起右CP.Update();
			this.X0Y0_基節_基節右2CP.Update();
			this.X0Y0_基節_基節右3CP.Update();
			this.X0Y0_基節_基節右4CP.Update();
			this.X0Y0_生殖口蓋左CP.Update();
			this.X0Y0_生殖口蓋右CP.Update();
			this.X0Y0_生殖口_生殖口0CP.Update();
			this.X0Y0_生殖口_生殖口1CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			switch (this.配色指定)
			{
			case 配色指定.N0:
				this.配色N0(体配色);
				return;
			case 配色指定.T0:
				this.配色T0(体配色);
				return;
			case 配色指定.T1:
				this.配色T1(体配色);
				return;
			default:
				this.配色N0(体配色);
				return;
			}
		}

		private void 配色N0(体配色 体配色)
		{
			this.前腹_腹節7_節0CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.前腹_腹節7_節1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.前腹_腹節6_節0CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.前腹_腹節6_節1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.前腹_腹節6_節線CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.前腹_腹節6_気門左CD = new ColorD(ref Col.Black, ref 体配色.甲1R);
			this.前腹_腹節6_気門右CD = new ColorD(ref Col.Black, ref 体配色.甲1R);
			this.前腹_腹節5_節0CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.前腹_腹節5_節1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.前腹_腹節5_節線CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.前腹_腹節5_気門左CD = new ColorD(ref Col.Black, ref 体配色.甲1R);
			this.前腹_腹節5_気門右CD = new ColorD(ref Col.Black, ref 体配色.甲1R);
			this.前腹_腹節4_節0CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.前腹_腹節4_節1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.前腹_腹節4_節線CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.前腹_腹節4_気門左CD = new ColorD(ref Col.Black, ref 体配色.甲1R);
			this.前腹_腹節4_気門右CD = new ColorD(ref Col.Black, ref 体配色.甲1R);
			this.前腹_腹節3_節0CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.前腹_腹節3_節1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.前腹_腹節3_節線CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.前腹_腹節3_気門左CD = new ColorD(ref Col.Black, ref 体配色.甲1R);
			this.前腹_腹節3_気門右CD = new ColorD(ref Col.Black, ref 体配色.甲1R);
			this.前腹_腹節2_節0CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.頭胸CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.基節_基節左0CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.基節_基節左1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.基節_肢内突起左CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.基節_基節左2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.基節_基節左3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.基節_基節左4CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.基節_基節右0CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.基節_基節右1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.基節_肢内突起右CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.基節_基節右2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.基節_基節右3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.基節_基節右4CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.生殖口蓋左CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.生殖口蓋右CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.生殖口_生殖口0CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.生殖口_生殖口1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
		}

		private void 配色T0(体配色 体配色)
		{
			this.前腹_腹節7_節0CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.前腹_腹節7_節1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.前腹_腹節6_節0CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.前腹_腹節6_節1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.前腹_腹節6_節線CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.前腹_腹節6_気門左CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.前腹_腹節6_気門右CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.前腹_腹節5_節0CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.前腹_腹節5_節1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.前腹_腹節5_節線CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.前腹_腹節5_気門左CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.前腹_腹節5_気門右CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.前腹_腹節4_節0CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.前腹_腹節4_節1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.前腹_腹節4_節線CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.前腹_腹節4_気門左CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.前腹_腹節4_気門右CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.前腹_腹節3_節0CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.前腹_腹節3_節1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.前腹_腹節3_節線CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.前腹_腹節3_気門左CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.前腹_腹節3_気門右CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.前腹_腹節2_節0CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.頭胸CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.基節_基節左0CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.基節_基節左1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.基節_肢内突起左CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.基節_基節左2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.基節_基節左3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.基節_基節左4CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.基節_基節右0CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.基節_基節右1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.基節_肢内突起右CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.基節_基節右2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.基節_基節右3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.基節_基節右4CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.生殖口蓋左CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.生殖口蓋右CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.生殖口_生殖口0CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.生殖口_生殖口1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
		}

		private void 配色T1(体配色 体配色)
		{
			this.前腹_腹節7_節0CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.前腹_腹節7_節1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.前腹_腹節6_節0CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.前腹_腹節6_節1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.前腹_腹節6_節線CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.前腹_腹節6_気門左CD = new ColorD(ref Col.Black, ref 体配色.甲1R);
			this.前腹_腹節6_気門右CD = new ColorD(ref Col.Black, ref 体配色.甲1R);
			this.前腹_腹節5_節0CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.前腹_腹節5_節1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.前腹_腹節5_節線CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.前腹_腹節5_気門左CD = new ColorD(ref Col.Black, ref 体配色.甲1R);
			this.前腹_腹節5_気門右CD = new ColorD(ref Col.Black, ref 体配色.甲1R);
			this.前腹_腹節4_節0CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.前腹_腹節4_節1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.前腹_腹節4_節線CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.前腹_腹節4_気門左CD = new ColorD(ref Col.Black, ref 体配色.甲1R);
			this.前腹_腹節4_気門右CD = new ColorD(ref Col.Black, ref 体配色.甲1R);
			this.前腹_腹節3_節0CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.前腹_腹節3_節1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.前腹_腹節3_節線CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.前腹_腹節3_気門左CD = new ColorD(ref Col.Black, ref 体配色.甲1R);
			this.前腹_腹節3_気門右CD = new ColorD(ref Col.Black, ref 体配色.甲1R);
			this.前腹_腹節2_節0CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.頭胸CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.基節_基節左0CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.基節_基節左1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.基節_肢内突起左CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.基節_基節左2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.基節_基節左3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.基節_基節左4CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.基節_基節右0CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.基節_基節右1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.基節_肢内突起右CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.基節_基節右2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.基節_基節右3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.基節_基節右4CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.生殖口蓋左CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.生殖口蓋右CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.生殖口_生殖口0CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.生殖口_生殖口1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
		}

		public override IEnumerable<Ele> EnumEle()
		{
			yield return this;
			if (this.尾_接続 != null)
			{
				foreach (Ele ele in (from e in this.尾_接続
				select e.EnumEle()).JoinEnum<Ele>())
				{
					yield return ele;
				}
				IEnumerator<Ele> enumerator = null;
			}
			if (this.櫛状板左_接続 != null)
			{
				foreach (Ele ele2 in (from e in this.櫛状板左_接続
				select e.EnumEle()).JoinEnum<Ele>())
				{
					yield return ele2;
				}
				IEnumerator<Ele> enumerator = null;
			}
			if (this.櫛状板右_接続 != null)
			{
				foreach (Ele ele3 in (from e in this.櫛状板右_接続
				select e.EnumEle()).JoinEnum<Ele>())
				{
					yield return ele3;
				}
				IEnumerator<Ele> enumerator = null;
			}
			if (this.節足左4_接続 != null)
			{
				foreach (Ele ele4 in (from e in this.節足左4_接続
				select e.EnumEle()).JoinEnum<Ele>())
				{
					yield return ele4;
				}
				IEnumerator<Ele> enumerator = null;
			}
			if (this.節足右4_接続 != null)
			{
				foreach (Ele ele5 in (from e in this.節足右4_接続
				select e.EnumEle()).JoinEnum<Ele>())
				{
					yield return ele5;
				}
				IEnumerator<Ele> enumerator = null;
			}
			if (this.節足左3_接続 != null)
			{
				foreach (Ele ele6 in (from e in this.節足左3_接続
				select e.EnumEle()).JoinEnum<Ele>())
				{
					yield return ele6;
				}
				IEnumerator<Ele> enumerator = null;
			}
			if (this.節足右3_接続 != null)
			{
				foreach (Ele ele7 in (from e in this.節足右3_接続
				select e.EnumEle()).JoinEnum<Ele>())
				{
					yield return ele7;
				}
				IEnumerator<Ele> enumerator = null;
			}
			if (this.節足左2_接続 != null)
			{
				foreach (Ele ele8 in (from e in this.節足左2_接続
				select e.EnumEle()).JoinEnum<Ele>())
				{
					yield return ele8;
				}
				IEnumerator<Ele> enumerator = null;
			}
			if (this.節足右2_接続 != null)
			{
				foreach (Ele ele9 in (from e in this.節足右2_接続
				select e.EnumEle()).JoinEnum<Ele>())
				{
					yield return ele9;
				}
				IEnumerator<Ele> enumerator = null;
			}
			if (this.節足左1_接続 != null)
			{
				foreach (Ele ele10 in (from e in this.節足左1_接続
				select e.EnumEle()).JoinEnum<Ele>())
				{
					yield return ele10;
				}
				IEnumerator<Ele> enumerator = null;
			}
			if (this.節足右1_接続 != null)
			{
				foreach (Ele ele11 in (from e in this.節足右1_接続
				select e.EnumEle()).JoinEnum<Ele>())
				{
					yield return ele11;
				}
				IEnumerator<Ele> enumerator = null;
			}
			if (this.触肢左_接続 != null)
			{
				foreach (Ele ele12 in (from e in this.触肢左_接続
				select e.EnumEle()).JoinEnum<Ele>())
				{
					yield return ele12;
				}
				IEnumerator<Ele> enumerator = null;
			}
			if (this.触肢右_接続 != null)
			{
				foreach (Ele ele13 in (from e in this.触肢右_接続
				select e.EnumEle()).JoinEnum<Ele>())
				{
					yield return ele13;
				}
				IEnumerator<Ele> enumerator = null;
			}
			yield break;
			yield break;
		}

		public Par X0Y0_前腹_腹節7_節0;

		public Par X0Y0_前腹_腹節7_節1;

		public Par X0Y0_前腹_腹節6_節0;

		public Par X0Y0_前腹_腹節6_節1;

		public Par X0Y0_前腹_腹節6_節線;

		public Par X0Y0_前腹_腹節6_気門左;

		public Par X0Y0_前腹_腹節6_気門右;

		public Par X0Y0_前腹_腹節5_節0;

		public Par X0Y0_前腹_腹節5_節1;

		public Par X0Y0_前腹_腹節5_節線;

		public Par X0Y0_前腹_腹節5_気門左;

		public Par X0Y0_前腹_腹節5_気門右;

		public Par X0Y0_前腹_腹節4_節0;

		public Par X0Y0_前腹_腹節4_節1;

		public Par X0Y0_前腹_腹節4_節線;

		public Par X0Y0_前腹_腹節4_気門左;

		public Par X0Y0_前腹_腹節4_気門右;

		public Par X0Y0_前腹_腹節3_節0;

		public Par X0Y0_前腹_腹節3_節1;

		public Par X0Y0_前腹_腹節3_節線;

		public Par X0Y0_前腹_腹節3_気門左;

		public Par X0Y0_前腹_腹節3_気門右;

		public Par X0Y0_前腹_腹節2_節0;

		public Par X0Y0_頭胸;

		public Par X0Y0_基節_基節左0;

		public Par X0Y0_基節_基節左1;

		public Par X0Y0_基節_肢内突起左;

		public Par X0Y0_基節_基節左2;

		public Par X0Y0_基節_基節左3;

		public Par X0Y0_基節_基節左4;

		public Par X0Y0_基節_基節右0;

		public Par X0Y0_基節_基節右1;

		public Par X0Y0_基節_肢内突起右;

		public Par X0Y0_基節_基節右2;

		public Par X0Y0_基節_基節右3;

		public Par X0Y0_基節_基節右4;

		public Par X0Y0_生殖口蓋左;

		public Par X0Y0_生殖口蓋右;

		public Par X0Y0_生殖口_生殖口0;

		public Par X0Y0_生殖口_生殖口1;

		public ColorD 前腹_腹節7_節0CD;

		public ColorD 前腹_腹節7_節1CD;

		public ColorD 前腹_腹節6_節0CD;

		public ColorD 前腹_腹節6_節1CD;

		public ColorD 前腹_腹節6_節線CD;

		public ColorD 前腹_腹節6_気門左CD;

		public ColorD 前腹_腹節6_気門右CD;

		public ColorD 前腹_腹節5_節0CD;

		public ColorD 前腹_腹節5_節1CD;

		public ColorD 前腹_腹節5_節線CD;

		public ColorD 前腹_腹節5_気門左CD;

		public ColorD 前腹_腹節5_気門右CD;

		public ColorD 前腹_腹節4_節0CD;

		public ColorD 前腹_腹節4_節1CD;

		public ColorD 前腹_腹節4_節線CD;

		public ColorD 前腹_腹節4_気門左CD;

		public ColorD 前腹_腹節4_気門右CD;

		public ColorD 前腹_腹節3_節0CD;

		public ColorD 前腹_腹節3_節1CD;

		public ColorD 前腹_腹節3_節線CD;

		public ColorD 前腹_腹節3_気門左CD;

		public ColorD 前腹_腹節3_気門右CD;

		public ColorD 前腹_腹節2_節0CD;

		public ColorD 頭胸CD;

		public ColorD 基節_基節左0CD;

		public ColorD 基節_基節左1CD;

		public ColorD 基節_肢内突起左CD;

		public ColorD 基節_基節左2CD;

		public ColorD 基節_基節左3CD;

		public ColorD 基節_基節左4CD;

		public ColorD 基節_基節右0CD;

		public ColorD 基節_基節右1CD;

		public ColorD 基節_肢内突起右CD;

		public ColorD 基節_基節右2CD;

		public ColorD 基節_基節右3CD;

		public ColorD 基節_基節右4CD;

		public ColorD 生殖口蓋左CD;

		public ColorD 生殖口蓋右CD;

		public ColorD 生殖口_生殖口0CD;

		public ColorD 生殖口_生殖口1CD;

		public ColorP X0Y0_前腹_腹節7_節0CP;

		public ColorP X0Y0_前腹_腹節7_節1CP;

		public ColorP X0Y0_前腹_腹節6_節0CP;

		public ColorP X0Y0_前腹_腹節6_節1CP;

		public ColorP X0Y0_前腹_腹節6_節線CP;

		public ColorP X0Y0_前腹_腹節6_気門左CP;

		public ColorP X0Y0_前腹_腹節6_気門右CP;

		public ColorP X0Y0_前腹_腹節5_節0CP;

		public ColorP X0Y0_前腹_腹節5_節1CP;

		public ColorP X0Y0_前腹_腹節5_節線CP;

		public ColorP X0Y0_前腹_腹節5_気門左CP;

		public ColorP X0Y0_前腹_腹節5_気門右CP;

		public ColorP X0Y0_前腹_腹節4_節0CP;

		public ColorP X0Y0_前腹_腹節4_節1CP;

		public ColorP X0Y0_前腹_腹節4_節線CP;

		public ColorP X0Y0_前腹_腹節4_気門左CP;

		public ColorP X0Y0_前腹_腹節4_気門右CP;

		public ColorP X0Y0_前腹_腹節3_節0CP;

		public ColorP X0Y0_前腹_腹節3_節1CP;

		public ColorP X0Y0_前腹_腹節3_節線CP;

		public ColorP X0Y0_前腹_腹節3_気門左CP;

		public ColorP X0Y0_前腹_腹節3_気門右CP;

		public ColorP X0Y0_前腹_腹節2_節0CP;

		public ColorP X0Y0_頭胸CP;

		public ColorP X0Y0_基節_基節左0CP;

		public ColorP X0Y0_基節_基節左1CP;

		public ColorP X0Y0_基節_肢内突起左CP;

		public ColorP X0Y0_基節_基節左2CP;

		public ColorP X0Y0_基節_基節左3CP;

		public ColorP X0Y0_基節_基節左4CP;

		public ColorP X0Y0_基節_基節右0CP;

		public ColorP X0Y0_基節_基節右1CP;

		public ColorP X0Y0_基節_肢内突起右CP;

		public ColorP X0Y0_基節_基節右2CP;

		public ColorP X0Y0_基節_基節右3CP;

		public ColorP X0Y0_基節_基節右4CP;

		public ColorP X0Y0_生殖口蓋左CP;

		public ColorP X0Y0_生殖口蓋右CP;

		public ColorP X0Y0_生殖口_生殖口0CP;

		public ColorP X0Y0_生殖口_生殖口1CP;

		private double くぱぁ_;

		public Ele[] 触肢左_接続;

		public Ele[] 節足左1_接続;

		public Ele[] 節足左2_接続;

		public Ele[] 節足左3_接続;

		public Ele[] 節足左4_接続;

		public Ele[] 触肢右_接続;

		public Ele[] 節足右1_接続;

		public Ele[] 節足右2_接続;

		public Ele[] 節足右3_接続;

		public Ele[] 節足右4_接続;

		public Ele[] 櫛状板左_接続;

		public Ele[] 櫛状板右_接続;

		public Ele[] 尾_接続;
	}
}
