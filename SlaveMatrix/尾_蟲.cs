using System;
using System.Collections.Generic;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 尾_蟲 : 尾
	{
		public 尾_蟲(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 尾_蟲D e)
		{
			尾_蟲.<>c__DisplayClass184_0 CS$<>8__locals1 = new 尾_蟲.<>c__DisplayClass184_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "蟲尾";
			dif.Add(new Pars(Sta.尻尾["尾"][0][21]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			Pars pars2 = pars["尾5"].ToPars();
			this.X0Y0_尾5_背板 = pars2["背板"].ToPar();
			this.X0Y0_尾5_節 = pars2["節"].ToPar();
			this.X0Y0_尾5_胸板 = pars2["胸板"].ToPar();
			this.X0Y0_尾5_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾5_瘤左2 = pars2["瘤左2"].ToPar();
			this.X0Y0_尾5_瘤左1 = pars2["瘤左1"].ToPar();
			this.X0Y0_尾5_瘤右2 = pars2["瘤右2"].ToPar();
			this.X0Y0_尾5_瘤右1 = pars2["瘤右1"].ToPar();
			pars2 = pars["尾4"].ToPars();
			this.X0Y0_尾4_背板 = pars2["背板"].ToPar();
			this.X0Y0_尾4_節 = pars2["節"].ToPar();
			this.X0Y0_尾4_胸板 = pars2["胸板"].ToPar();
			this.X0Y0_尾4_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾4_瘤左2 = pars2["瘤左2"].ToPar();
			this.X0Y0_尾4_瘤左1 = pars2["瘤左1"].ToPar();
			this.X0Y0_尾4_瘤右2 = pars2["瘤右2"].ToPar();
			this.X0Y0_尾4_瘤右1 = pars2["瘤右1"].ToPar();
			pars2 = pars["尾3"].ToPars();
			this.X0Y0_尾3_背板 = pars2["背板"].ToPar();
			this.X0Y0_尾3_節 = pars2["節"].ToPar();
			this.X0Y0_尾3_胸板 = pars2["胸板"].ToPar();
			this.X0Y0_尾3_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾3_瘤左2 = pars2["瘤左2"].ToPar();
			this.X0Y0_尾3_瘤左1 = pars2["瘤左1"].ToPar();
			this.X0Y0_尾3_瘤右2 = pars2["瘤右2"].ToPar();
			this.X0Y0_尾3_瘤右1 = pars2["瘤右1"].ToPar();
			pars2 = pars["輪2"].ToPars();
			this.X0Y0_輪2_革 = pars2["革"].ToPar();
			this.X0Y0_輪2_金具1 = pars2["金具1"].ToPar();
			this.X0Y0_輪2_金具2 = pars2["金具2"].ToPar();
			this.X0Y0_輪2_金具3 = pars2["金具3"].ToPar();
			this.X0Y0_輪2_金具左 = pars2["金具左"].ToPar();
			this.X0Y0_輪2_金具右 = pars2["金具右"].ToPar();
			pars2 = pars["尾2"].ToPars();
			this.X0Y0_尾2_背板 = pars2["背板"].ToPar();
			this.X0Y0_尾2_節 = pars2["節"].ToPar();
			this.X0Y0_尾2_胸板 = pars2["胸板"].ToPar();
			this.X0Y0_尾2_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾2_瘤左2 = pars2["瘤左2"].ToPar();
			this.X0Y0_尾2_瘤左1 = pars2["瘤左1"].ToPar();
			this.X0Y0_尾2_瘤右2 = pars2["瘤右2"].ToPar();
			this.X0Y0_尾2_瘤右1 = pars2["瘤右1"].ToPar();
			pars2 = pars["尾1"].ToPars();
			this.X0Y0_尾1_背板 = pars2["背板"].ToPar();
			this.X0Y0_尾1_節 = pars2["節"].ToPar();
			this.X0Y0_尾1_胸板 = pars2["胸板"].ToPar();
			this.X0Y0_尾1_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾1_瘤左2 = pars2["瘤左2"].ToPar();
			this.X0Y0_尾1_瘤左1 = pars2["瘤左1"].ToPar();
			this.X0Y0_尾1_瘤右2 = pars2["瘤右2"].ToPar();
			this.X0Y0_尾1_瘤右1 = pars2["瘤右1"].ToPar();
			pars2 = pars["尾0"].ToPars();
			this.X0Y0_尾0_背板 = pars2["背板"].ToPar();
			this.X0Y0_尾0_節 = pars2["節"].ToPar();
			this.X0Y0_尾0_胸板 = pars2["胸板"].ToPar();
			this.X0Y0_尾0_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾0_瘤左2 = pars2["瘤左2"].ToPar();
			this.X0Y0_尾0_瘤左1 = pars2["瘤左1"].ToPar();
			this.X0Y0_尾0_瘤右2 = pars2["瘤右2"].ToPar();
			this.X0Y0_尾0_瘤右1 = pars2["瘤右1"].ToPar();
			pars2 = pars["輪1"].ToPars();
			this.X0Y0_輪1_革 = pars2["革"].ToPar();
			this.X0Y0_輪1_金具1 = pars2["金具1"].ToPar();
			this.X0Y0_輪1_金具2 = pars2["金具2"].ToPar();
			this.X0Y0_輪1_金具3 = pars2["金具3"].ToPar();
			this.X0Y0_輪1_金具左 = pars2["金具左"].ToPar();
			this.X0Y0_輪1_金具右 = pars2["金具右"].ToPar();
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
			this.尾5_背板_表示 = e.尾5_背板_表示;
			this.尾5_節_表示 = e.尾5_節_表示;
			this.尾5_胸板_表示 = e.尾5_胸板_表示;
			this.尾5_表示 = e.尾5_表示;
			this.尾5_瘤左2_表示 = e.尾5_瘤左2_表示;
			this.尾5_瘤左1_表示 = e.尾5_瘤左1_表示;
			this.尾5_瘤右2_表示 = e.尾5_瘤右2_表示;
			this.尾5_瘤右1_表示 = e.尾5_瘤右1_表示;
			this.尾4_背板_表示 = e.尾4_背板_表示;
			this.尾4_節_表示 = e.尾4_節_表示;
			this.尾4_胸板_表示 = e.尾4_胸板_表示;
			this.尾4_表示 = e.尾4_表示;
			this.尾4_瘤左2_表示 = e.尾4_瘤左2_表示;
			this.尾4_瘤左1_表示 = e.尾4_瘤左1_表示;
			this.尾4_瘤右2_表示 = e.尾4_瘤右2_表示;
			this.尾4_瘤右1_表示 = e.尾4_瘤右1_表示;
			this.尾3_背板_表示 = e.尾3_背板_表示;
			this.尾3_節_表示 = e.尾3_節_表示;
			this.尾3_胸板_表示 = e.尾3_胸板_表示;
			this.尾3_表示 = e.尾3_表示;
			this.尾3_瘤左2_表示 = e.尾3_瘤左2_表示;
			this.尾3_瘤左1_表示 = e.尾3_瘤左1_表示;
			this.尾3_瘤右2_表示 = e.尾3_瘤右2_表示;
			this.尾3_瘤右1_表示 = e.尾3_瘤右1_表示;
			this.輪2_革_表示 = e.輪2_革_表示;
			this.輪2_金具1_表示 = e.輪2_金具1_表示;
			this.輪2_金具2_表示 = e.輪2_金具2_表示;
			this.輪2_金具3_表示 = e.輪2_金具3_表示;
			this.輪2_金具左_表示 = e.輪2_金具左_表示;
			this.輪2_金具右_表示 = e.輪2_金具右_表示;
			this.尾2_背板_表示 = e.尾2_背板_表示;
			this.尾2_節_表示 = e.尾2_節_表示;
			this.尾2_胸板_表示 = e.尾2_胸板_表示;
			this.尾2_表示 = e.尾2_表示;
			this.尾2_瘤左2_表示 = e.尾2_瘤左2_表示;
			this.尾2_瘤左1_表示 = e.尾2_瘤左1_表示;
			this.尾2_瘤右2_表示 = e.尾2_瘤右2_表示;
			this.尾2_瘤右1_表示 = e.尾2_瘤右1_表示;
			this.尾1_背板_表示 = e.尾1_背板_表示;
			this.尾1_節_表示 = e.尾1_節_表示;
			this.尾1_胸板_表示 = e.尾1_胸板_表示;
			this.尾1_表示 = e.尾1_表示;
			this.尾1_瘤左2_表示 = e.尾1_瘤左2_表示;
			this.尾1_瘤左1_表示 = e.尾1_瘤左1_表示;
			this.尾1_瘤右2_表示 = e.尾1_瘤右2_表示;
			this.尾1_瘤右1_表示 = e.尾1_瘤右1_表示;
			this.尾0_背板_表示 = e.尾0_背板_表示;
			this.尾0_節_表示 = e.尾0_節_表示;
			this.尾0_胸板_表示 = e.尾0_胸板_表示;
			this.尾0_表示 = e.尾0_表示;
			this.尾0_瘤左2_表示 = e.尾0_瘤左2_表示;
			this.尾0_瘤左1_表示 = e.尾0_瘤左1_表示;
			this.尾0_瘤右2_表示 = e.尾0_瘤右2_表示;
			this.尾0_瘤右1_表示 = e.尾0_瘤右1_表示;
			this.輪1_革_表示 = e.輪1_革_表示;
			this.輪1_金具1_表示 = e.輪1_金具1_表示;
			this.輪1_金具2_表示 = e.輪1_金具2_表示;
			this.輪1_金具3_表示 = e.輪1_金具3_表示;
			this.輪1_金具左_表示 = e.輪1_金具左_表示;
			this.輪1_金具右_表示 = e.輪1_金具右_表示;
			this.輪1表示 = e.輪1表示;
			this.輪2表示 = e.輪2表示;
			this.胸板 = e.胸板;
			this.節 = e.節;
			this.背板 = e.背板;
			this.胴 = e.胴;
			this.瘤 = e.瘤;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.左1_接続.Count > 0)
			{
				Ele f;
				this.左1_接続 = e.左1_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_蟲_左1_接続;
					f.接続(CS$<>8__locals1.<>4__this.左1_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右1_接続.Count > 0)
			{
				Ele f;
				this.右1_接続 = e.右1_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_蟲_右1_接続;
					f.接続(CS$<>8__locals1.<>4__this.右1_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.左2_接続.Count > 0)
			{
				Ele f;
				this.左2_接続 = e.左2_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_蟲_左2_接続;
					f.接続(CS$<>8__locals1.<>4__this.左2_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右2_接続.Count > 0)
			{
				Ele f;
				this.右2_接続 = e.右2_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_蟲_右2_接続;
					f.接続(CS$<>8__locals1.<>4__this.右2_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.左3_接続.Count > 0)
			{
				Ele f;
				this.左3_接続 = e.左3_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_蟲_左3_接続;
					f.接続(CS$<>8__locals1.<>4__this.左3_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右3_接続.Count > 0)
			{
				Ele f;
				this.右3_接続 = e.右3_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_蟲_右3_接続;
					f.接続(CS$<>8__locals1.<>4__this.右3_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.左4_接続.Count > 0)
			{
				Ele f;
				this.左4_接続 = e.左4_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_蟲_左4_接続;
					f.接続(CS$<>8__locals1.<>4__this.左4_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右4_接続.Count > 0)
			{
				Ele f;
				this.右4_接続 = e.右4_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_蟲_右4_接続;
					f.接続(CS$<>8__locals1.<>4__this.右4_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.左5_接続.Count > 0)
			{
				Ele f;
				this.左5_接続 = e.左5_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_蟲_左5_接続;
					f.接続(CS$<>8__locals1.<>4__this.左5_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右5_接続.Count > 0)
			{
				Ele f;
				this.右5_接続 = e.右5_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_蟲_右5_接続;
					f.接続(CS$<>8__locals1.<>4__this.右5_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.尾左_接続.Count > 0)
			{
				Ele f;
				this.尾左_接続 = e.尾左_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_蟲_尾左_接続;
					f.接続(CS$<>8__locals1.<>4__this.尾左_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.尾右_接続.Count > 0)
			{
				Ele f;
				this.尾右_接続 = e.尾右_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_蟲_尾右_接続;
					f.接続(CS$<>8__locals1.<>4__this.尾右_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_尾5_背板CP = new ColorP(this.X0Y0_尾5_背板, this.尾5_背板CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾5_節CP = new ColorP(this.X0Y0_尾5_節, this.尾5_節CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾5_胸板CP = new ColorP(this.X0Y0_尾5_胸板, this.尾5_胸板CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾5_尾CP = new ColorP(this.X0Y0_尾5_尾, this.尾5_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾5_瘤左2CP = new ColorP(this.X0Y0_尾5_瘤左2, this.尾5_瘤左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾5_瘤左1CP = new ColorP(this.X0Y0_尾5_瘤左1, this.尾5_瘤左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾5_瘤右2CP = new ColorP(this.X0Y0_尾5_瘤右2, this.尾5_瘤右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾5_瘤右1CP = new ColorP(this.X0Y0_尾5_瘤右1, this.尾5_瘤右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾4_背板CP = new ColorP(this.X0Y0_尾4_背板, this.尾4_背板CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾4_節CP = new ColorP(this.X0Y0_尾4_節, this.尾4_節CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾4_胸板CP = new ColorP(this.X0Y0_尾4_胸板, this.尾4_胸板CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾4_尾CP = new ColorP(this.X0Y0_尾4_尾, this.尾4_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾4_瘤左2CP = new ColorP(this.X0Y0_尾4_瘤左2, this.尾4_瘤左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾4_瘤左1CP = new ColorP(this.X0Y0_尾4_瘤左1, this.尾4_瘤左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾4_瘤右2CP = new ColorP(this.X0Y0_尾4_瘤右2, this.尾4_瘤右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾4_瘤右1CP = new ColorP(this.X0Y0_尾4_瘤右1, this.尾4_瘤右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾3_背板CP = new ColorP(this.X0Y0_尾3_背板, this.尾3_背板CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾3_節CP = new ColorP(this.X0Y0_尾3_節, this.尾3_節CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾3_胸板CP = new ColorP(this.X0Y0_尾3_胸板, this.尾3_胸板CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾3_尾CP = new ColorP(this.X0Y0_尾3_尾, this.尾3_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾3_瘤左2CP = new ColorP(this.X0Y0_尾3_瘤左2, this.尾3_瘤左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾3_瘤左1CP = new ColorP(this.X0Y0_尾3_瘤左1, this.尾3_瘤左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾3_瘤右2CP = new ColorP(this.X0Y0_尾3_瘤右2, this.尾3_瘤右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾3_瘤右1CP = new ColorP(this.X0Y0_尾3_瘤右1, this.尾3_瘤右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪2_革CP = new ColorP(this.X0Y0_輪2_革, this.輪2_革CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪2_金具1CP = new ColorP(this.X0Y0_輪2_金具1, this.輪2_金具1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪2_金具2CP = new ColorP(this.X0Y0_輪2_金具2, this.輪2_金具2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪2_金具3CP = new ColorP(this.X0Y0_輪2_金具3, this.輪2_金具3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪2_金具左CP = new ColorP(this.X0Y0_輪2_金具左, this.輪2_金具左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪2_金具右CP = new ColorP(this.X0Y0_輪2_金具右, this.輪2_金具右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾2_背板CP = new ColorP(this.X0Y0_尾2_背板, this.尾2_背板CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾2_節CP = new ColorP(this.X0Y0_尾2_節, this.尾2_節CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾2_胸板CP = new ColorP(this.X0Y0_尾2_胸板, this.尾2_胸板CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾2_尾CP = new ColorP(this.X0Y0_尾2_尾, this.尾2_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾2_瘤左2CP = new ColorP(this.X0Y0_尾2_瘤左2, this.尾2_瘤左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾2_瘤左1CP = new ColorP(this.X0Y0_尾2_瘤左1, this.尾2_瘤左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾2_瘤右2CP = new ColorP(this.X0Y0_尾2_瘤右2, this.尾2_瘤右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾2_瘤右1CP = new ColorP(this.X0Y0_尾2_瘤右1, this.尾2_瘤右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾1_背板CP = new ColorP(this.X0Y0_尾1_背板, this.尾1_背板CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾1_節CP = new ColorP(this.X0Y0_尾1_節, this.尾1_節CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾1_胸板CP = new ColorP(this.X0Y0_尾1_胸板, this.尾1_胸板CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾1_尾CP = new ColorP(this.X0Y0_尾1_尾, this.尾1_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾1_瘤左2CP = new ColorP(this.X0Y0_尾1_瘤左2, this.尾1_瘤左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾1_瘤左1CP = new ColorP(this.X0Y0_尾1_瘤左1, this.尾1_瘤左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾1_瘤右2CP = new ColorP(this.X0Y0_尾1_瘤右2, this.尾1_瘤右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾1_瘤右1CP = new ColorP(this.X0Y0_尾1_瘤右1, this.尾1_瘤右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾0_背板CP = new ColorP(this.X0Y0_尾0_背板, this.尾0_背板CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾0_節CP = new ColorP(this.X0Y0_尾0_節, this.尾0_節CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾0_胸板CP = new ColorP(this.X0Y0_尾0_胸板, this.尾0_胸板CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾0_尾CP = new ColorP(this.X0Y0_尾0_尾, this.尾0_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾0_瘤左2CP = new ColorP(this.X0Y0_尾0_瘤左2, this.尾0_瘤左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾0_瘤左1CP = new ColorP(this.X0Y0_尾0_瘤左1, this.尾0_瘤左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾0_瘤右2CP = new ColorP(this.X0Y0_尾0_瘤右2, this.尾0_瘤右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾0_瘤右1CP = new ColorP(this.X0Y0_尾0_瘤右1, this.尾0_瘤右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪1_革CP = new ColorP(this.X0Y0_輪1_革, this.輪1_革CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪1_金具1CP = new ColorP(this.X0Y0_輪1_金具1, this.輪1_金具1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪1_金具2CP = new ColorP(this.X0Y0_輪1_金具2, this.輪1_金具2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪1_金具3CP = new ColorP(this.X0Y0_輪1_金具3, this.輪1_金具3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪1_金具左CP = new ColorP(this.X0Y0_輪1_金具左, this.輪1_金具左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪1_金具右CP = new ColorP(this.X0Y0_輪1_金具右, this.輪1_金具右CD, CS$<>8__locals1.DisUnit, true);
			this.濃度 = e.濃度;
			this.鎖1 = new 拘束鎖(CS$<>8__locals1.DisUnit, this.右, 配色指定, CS$<>8__locals1.体配色, this.Xasix);
			this.鎖2 = new 拘束鎖(CS$<>8__locals1.DisUnit, !this.右, 配色指定, CS$<>8__locals1.体配色, this.Xasix);
			this.鎖3 = new 拘束鎖(CS$<>8__locals1.DisUnit, this.右, 配色指定, CS$<>8__locals1.体配色, this.Xasix);
			this.鎖4 = new 拘束鎖(CS$<>8__locals1.DisUnit, !this.右, 配色指定, CS$<>8__locals1.体配色, this.Xasix);
			this.鎖1.接続(this.鎖1_接続点);
			this.鎖2.接続(this.鎖2_接続点);
			this.鎖3.接続(this.鎖3_接続点);
			this.鎖4.接続(this.鎖4_接続点);
			int num = this.右 ? -10 : 10;
			this.鎖1.角度B -= (double)num;
			this.鎖2.角度B += (double)num;
			this.鎖3.角度B -= (double)num;
			this.鎖4.角度B += (double)num;
			this.鎖表示 = e.鎖表示;
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
				this.輪1表示 = this.拘束_;
				this.輪2表示 = this.拘束_;
			}
		}

		public bool 尾5_背板_表示
		{
			get
			{
				return this.X0Y0_尾5_背板.Dra;
			}
			set
			{
				this.X0Y0_尾5_背板.Dra = value;
				this.X0Y0_尾5_背板.Hit = value;
			}
		}

		public bool 尾5_節_表示
		{
			get
			{
				return this.X0Y0_尾5_節.Dra;
			}
			set
			{
				this.X0Y0_尾5_節.Dra = value;
				this.X0Y0_尾5_節.Hit = value;
			}
		}

		public bool 尾5_胸板_表示
		{
			get
			{
				return this.X0Y0_尾5_胸板.Dra;
			}
			set
			{
				this.X0Y0_尾5_胸板.Dra = value;
				this.X0Y0_尾5_胸板.Hit = value;
			}
		}

		public bool 尾5_表示
		{
			get
			{
				return this.X0Y0_尾5_尾.Dra;
			}
			set
			{
				this.X0Y0_尾5_尾.Dra = value;
				this.X0Y0_尾5_尾.Hit = value;
			}
		}

		public bool 尾5_瘤左2_表示
		{
			get
			{
				return this.X0Y0_尾5_瘤左2.Dra;
			}
			set
			{
				this.X0Y0_尾5_瘤左2.Dra = value;
				this.X0Y0_尾5_瘤左2.Hit = value;
			}
		}

		public bool 尾5_瘤左1_表示
		{
			get
			{
				return this.X0Y0_尾5_瘤左1.Dra;
			}
			set
			{
				this.X0Y0_尾5_瘤左1.Dra = value;
				this.X0Y0_尾5_瘤左1.Hit = value;
			}
		}

		public bool 尾5_瘤右2_表示
		{
			get
			{
				return this.X0Y0_尾5_瘤右2.Dra;
			}
			set
			{
				this.X0Y0_尾5_瘤右2.Dra = value;
				this.X0Y0_尾5_瘤右2.Hit = value;
			}
		}

		public bool 尾5_瘤右1_表示
		{
			get
			{
				return this.X0Y0_尾5_瘤右1.Dra;
			}
			set
			{
				this.X0Y0_尾5_瘤右1.Dra = value;
				this.X0Y0_尾5_瘤右1.Hit = value;
			}
		}

		public bool 尾4_背板_表示
		{
			get
			{
				return this.X0Y0_尾4_背板.Dra;
			}
			set
			{
				this.X0Y0_尾4_背板.Dra = value;
				this.X0Y0_尾4_背板.Hit = value;
			}
		}

		public bool 尾4_節_表示
		{
			get
			{
				return this.X0Y0_尾4_節.Dra;
			}
			set
			{
				this.X0Y0_尾4_節.Dra = value;
				this.X0Y0_尾4_節.Hit = value;
			}
		}

		public bool 尾4_胸板_表示
		{
			get
			{
				return this.X0Y0_尾4_胸板.Dra;
			}
			set
			{
				this.X0Y0_尾4_胸板.Dra = value;
				this.X0Y0_尾4_胸板.Hit = value;
			}
		}

		public bool 尾4_表示
		{
			get
			{
				return this.X0Y0_尾4_尾.Dra;
			}
			set
			{
				this.X0Y0_尾4_尾.Dra = value;
				this.X0Y0_尾4_尾.Hit = value;
			}
		}

		public bool 尾4_瘤左2_表示
		{
			get
			{
				return this.X0Y0_尾4_瘤左2.Dra;
			}
			set
			{
				this.X0Y0_尾4_瘤左2.Dra = value;
				this.X0Y0_尾4_瘤左2.Hit = value;
			}
		}

		public bool 尾4_瘤左1_表示
		{
			get
			{
				return this.X0Y0_尾4_瘤左1.Dra;
			}
			set
			{
				this.X0Y0_尾4_瘤左1.Dra = value;
				this.X0Y0_尾4_瘤左1.Hit = value;
			}
		}

		public bool 尾4_瘤右2_表示
		{
			get
			{
				return this.X0Y0_尾4_瘤右2.Dra;
			}
			set
			{
				this.X0Y0_尾4_瘤右2.Dra = value;
				this.X0Y0_尾4_瘤右2.Hit = value;
			}
		}

		public bool 尾4_瘤右1_表示
		{
			get
			{
				return this.X0Y0_尾4_瘤右1.Dra;
			}
			set
			{
				this.X0Y0_尾4_瘤右1.Dra = value;
				this.X0Y0_尾4_瘤右1.Hit = value;
			}
		}

		public bool 尾3_背板_表示
		{
			get
			{
				return this.X0Y0_尾3_背板.Dra;
			}
			set
			{
				this.X0Y0_尾3_背板.Dra = value;
				this.X0Y0_尾3_背板.Hit = value;
			}
		}

		public bool 尾3_節_表示
		{
			get
			{
				return this.X0Y0_尾3_節.Dra;
			}
			set
			{
				this.X0Y0_尾3_節.Dra = value;
				this.X0Y0_尾3_節.Hit = value;
			}
		}

		public bool 尾3_胸板_表示
		{
			get
			{
				return this.X0Y0_尾3_胸板.Dra;
			}
			set
			{
				this.X0Y0_尾3_胸板.Dra = value;
				this.X0Y0_尾3_胸板.Hit = value;
			}
		}

		public bool 尾3_表示
		{
			get
			{
				return this.X0Y0_尾3_尾.Dra;
			}
			set
			{
				this.X0Y0_尾3_尾.Dra = value;
				this.X0Y0_尾3_尾.Hit = value;
			}
		}

		public bool 尾3_瘤左2_表示
		{
			get
			{
				return this.X0Y0_尾3_瘤左2.Dra;
			}
			set
			{
				this.X0Y0_尾3_瘤左2.Dra = value;
				this.X0Y0_尾3_瘤左2.Hit = value;
			}
		}

		public bool 尾3_瘤左1_表示
		{
			get
			{
				return this.X0Y0_尾3_瘤左1.Dra;
			}
			set
			{
				this.X0Y0_尾3_瘤左1.Dra = value;
				this.X0Y0_尾3_瘤左1.Hit = value;
			}
		}

		public bool 尾3_瘤右2_表示
		{
			get
			{
				return this.X0Y0_尾3_瘤右2.Dra;
			}
			set
			{
				this.X0Y0_尾3_瘤右2.Dra = value;
				this.X0Y0_尾3_瘤右2.Hit = value;
			}
		}

		public bool 尾3_瘤右1_表示
		{
			get
			{
				return this.X0Y0_尾3_瘤右1.Dra;
			}
			set
			{
				this.X0Y0_尾3_瘤右1.Dra = value;
				this.X0Y0_尾3_瘤右1.Hit = value;
			}
		}

		public bool 輪2_革_表示
		{
			get
			{
				return this.X0Y0_輪2_革.Dra;
			}
			set
			{
				this.X0Y0_輪2_革.Dra = value;
				this.X0Y0_輪2_革.Hit = value;
			}
		}

		public bool 輪2_金具1_表示
		{
			get
			{
				return this.X0Y0_輪2_金具1.Dra;
			}
			set
			{
				this.X0Y0_輪2_金具1.Dra = value;
				this.X0Y0_輪2_金具1.Hit = value;
			}
		}

		public bool 輪2_金具2_表示
		{
			get
			{
				return this.X0Y0_輪2_金具2.Dra;
			}
			set
			{
				this.X0Y0_輪2_金具2.Dra = value;
				this.X0Y0_輪2_金具2.Hit = value;
			}
		}

		public bool 輪2_金具3_表示
		{
			get
			{
				return this.X0Y0_輪2_金具3.Dra;
			}
			set
			{
				this.X0Y0_輪2_金具3.Dra = value;
				this.X0Y0_輪2_金具3.Hit = value;
			}
		}

		public bool 輪2_金具左_表示
		{
			get
			{
				return this.X0Y0_輪2_金具左.Dra;
			}
			set
			{
				this.X0Y0_輪2_金具左.Dra = value;
				this.X0Y0_輪2_金具左.Hit = value;
			}
		}

		public bool 輪2_金具右_表示
		{
			get
			{
				return this.X0Y0_輪2_金具右.Dra;
			}
			set
			{
				this.X0Y0_輪2_金具右.Dra = value;
				this.X0Y0_輪2_金具右.Hit = value;
			}
		}

		public bool 尾2_背板_表示
		{
			get
			{
				return this.X0Y0_尾2_背板.Dra;
			}
			set
			{
				this.X0Y0_尾2_背板.Dra = value;
				this.X0Y0_尾2_背板.Hit = value;
			}
		}

		public bool 尾2_節_表示
		{
			get
			{
				return this.X0Y0_尾2_節.Dra;
			}
			set
			{
				this.X0Y0_尾2_節.Dra = value;
				this.X0Y0_尾2_節.Hit = value;
			}
		}

		public bool 尾2_胸板_表示
		{
			get
			{
				return this.X0Y0_尾2_胸板.Dra;
			}
			set
			{
				this.X0Y0_尾2_胸板.Dra = value;
				this.X0Y0_尾2_胸板.Hit = value;
			}
		}

		public bool 尾2_表示
		{
			get
			{
				return this.X0Y0_尾2_尾.Dra;
			}
			set
			{
				this.X0Y0_尾2_尾.Dra = value;
				this.X0Y0_尾2_尾.Hit = value;
			}
		}

		public bool 尾2_瘤左2_表示
		{
			get
			{
				return this.X0Y0_尾2_瘤左2.Dra;
			}
			set
			{
				this.X0Y0_尾2_瘤左2.Dra = value;
				this.X0Y0_尾2_瘤左2.Hit = value;
			}
		}

		public bool 尾2_瘤左1_表示
		{
			get
			{
				return this.X0Y0_尾2_瘤左1.Dra;
			}
			set
			{
				this.X0Y0_尾2_瘤左1.Dra = value;
				this.X0Y0_尾2_瘤左1.Hit = value;
			}
		}

		public bool 尾2_瘤右2_表示
		{
			get
			{
				return this.X0Y0_尾2_瘤右2.Dra;
			}
			set
			{
				this.X0Y0_尾2_瘤右2.Dra = value;
				this.X0Y0_尾2_瘤右2.Hit = value;
			}
		}

		public bool 尾2_瘤右1_表示
		{
			get
			{
				return this.X0Y0_尾2_瘤右1.Dra;
			}
			set
			{
				this.X0Y0_尾2_瘤右1.Dra = value;
				this.X0Y0_尾2_瘤右1.Hit = value;
			}
		}

		public bool 尾1_背板_表示
		{
			get
			{
				return this.X0Y0_尾1_背板.Dra;
			}
			set
			{
				this.X0Y0_尾1_背板.Dra = value;
				this.X0Y0_尾1_背板.Hit = value;
			}
		}

		public bool 尾1_節_表示
		{
			get
			{
				return this.X0Y0_尾1_節.Dra;
			}
			set
			{
				this.X0Y0_尾1_節.Dra = value;
				this.X0Y0_尾1_節.Hit = value;
			}
		}

		public bool 尾1_胸板_表示
		{
			get
			{
				return this.X0Y0_尾1_胸板.Dra;
			}
			set
			{
				this.X0Y0_尾1_胸板.Dra = value;
				this.X0Y0_尾1_胸板.Hit = value;
			}
		}

		public bool 尾1_表示
		{
			get
			{
				return this.X0Y0_尾1_尾.Dra;
			}
			set
			{
				this.X0Y0_尾1_尾.Dra = value;
				this.X0Y0_尾1_尾.Hit = value;
			}
		}

		public bool 尾1_瘤左2_表示
		{
			get
			{
				return this.X0Y0_尾1_瘤左2.Dra;
			}
			set
			{
				this.X0Y0_尾1_瘤左2.Dra = value;
				this.X0Y0_尾1_瘤左2.Hit = value;
			}
		}

		public bool 尾1_瘤左1_表示
		{
			get
			{
				return this.X0Y0_尾1_瘤左1.Dra;
			}
			set
			{
				this.X0Y0_尾1_瘤左1.Dra = value;
				this.X0Y0_尾1_瘤左1.Hit = value;
			}
		}

		public bool 尾1_瘤右2_表示
		{
			get
			{
				return this.X0Y0_尾1_瘤右2.Dra;
			}
			set
			{
				this.X0Y0_尾1_瘤右2.Dra = value;
				this.X0Y0_尾1_瘤右2.Hit = value;
			}
		}

		public bool 尾1_瘤右1_表示
		{
			get
			{
				return this.X0Y0_尾1_瘤右1.Dra;
			}
			set
			{
				this.X0Y0_尾1_瘤右1.Dra = value;
				this.X0Y0_尾1_瘤右1.Hit = value;
			}
		}

		public bool 尾0_背板_表示
		{
			get
			{
				return this.X0Y0_尾0_背板.Dra;
			}
			set
			{
				this.X0Y0_尾0_背板.Dra = value;
				this.X0Y0_尾0_背板.Hit = value;
			}
		}

		public bool 尾0_節_表示
		{
			get
			{
				return this.X0Y0_尾0_節.Dra;
			}
			set
			{
				this.X0Y0_尾0_節.Dra = value;
				this.X0Y0_尾0_節.Hit = value;
			}
		}

		public bool 尾0_胸板_表示
		{
			get
			{
				return this.X0Y0_尾0_胸板.Dra;
			}
			set
			{
				this.X0Y0_尾0_胸板.Dra = value;
				this.X0Y0_尾0_胸板.Hit = value;
			}
		}

		public bool 尾0_表示
		{
			get
			{
				return this.X0Y0_尾0_尾.Dra;
			}
			set
			{
				this.X0Y0_尾0_尾.Dra = value;
				this.X0Y0_尾0_尾.Hit = value;
			}
		}

		public bool 尾0_瘤左2_表示
		{
			get
			{
				return this.X0Y0_尾0_瘤左2.Dra;
			}
			set
			{
				this.X0Y0_尾0_瘤左2.Dra = value;
				this.X0Y0_尾0_瘤左2.Hit = value;
			}
		}

		public bool 尾0_瘤左1_表示
		{
			get
			{
				return this.X0Y0_尾0_瘤左1.Dra;
			}
			set
			{
				this.X0Y0_尾0_瘤左1.Dra = value;
				this.X0Y0_尾0_瘤左1.Hit = value;
			}
		}

		public bool 尾0_瘤右2_表示
		{
			get
			{
				return this.X0Y0_尾0_瘤右2.Dra;
			}
			set
			{
				this.X0Y0_尾0_瘤右2.Dra = value;
				this.X0Y0_尾0_瘤右2.Hit = value;
			}
		}

		public bool 尾0_瘤右1_表示
		{
			get
			{
				return this.X0Y0_尾0_瘤右1.Dra;
			}
			set
			{
				this.X0Y0_尾0_瘤右1.Dra = value;
				this.X0Y0_尾0_瘤右1.Hit = value;
			}
		}

		public bool 輪1_革_表示
		{
			get
			{
				return this.X0Y0_輪1_革.Dra;
			}
			set
			{
				this.X0Y0_輪1_革.Dra = value;
				this.X0Y0_輪1_革.Hit = value;
			}
		}

		public bool 輪1_金具1_表示
		{
			get
			{
				return this.X0Y0_輪1_金具1.Dra;
			}
			set
			{
				this.X0Y0_輪1_金具1.Dra = value;
				this.X0Y0_輪1_金具1.Hit = value;
			}
		}

		public bool 輪1_金具2_表示
		{
			get
			{
				return this.X0Y0_輪1_金具2.Dra;
			}
			set
			{
				this.X0Y0_輪1_金具2.Dra = value;
				this.X0Y0_輪1_金具2.Hit = value;
			}
		}

		public bool 輪1_金具3_表示
		{
			get
			{
				return this.X0Y0_輪1_金具3.Dra;
			}
			set
			{
				this.X0Y0_輪1_金具3.Dra = value;
				this.X0Y0_輪1_金具3.Hit = value;
			}
		}

		public bool 輪1_金具左_表示
		{
			get
			{
				return this.X0Y0_輪1_金具左.Dra;
			}
			set
			{
				this.X0Y0_輪1_金具左.Dra = value;
				this.X0Y0_輪1_金具左.Hit = value;
			}
		}

		public bool 輪1_金具右_表示
		{
			get
			{
				return this.X0Y0_輪1_金具右.Dra;
			}
			set
			{
				this.X0Y0_輪1_金具右.Dra = value;
				this.X0Y0_輪1_金具右.Hit = value;
			}
		}

		public bool 輪1表示
		{
			get
			{
				return this.輪1_革_表示;
			}
			set
			{
				this.輪1_革_表示 = value;
				this.輪1_金具1_表示 = value;
				this.輪1_金具2_表示 = value;
				this.輪1_金具3_表示 = value;
				this.輪1_金具左_表示 = value;
				this.輪1_金具右_表示 = value;
			}
		}

		public bool 輪2表示
		{
			get
			{
				return this.輪2_革_表示;
			}
			set
			{
				this.輪2_革_表示 = value;
				this.輪2_金具1_表示 = value;
				this.輪2_金具2_表示 = value;
				this.輪2_金具3_表示 = value;
				this.輪2_金具左_表示 = value;
				this.輪2_金具右_表示 = value;
			}
		}

		public bool 鎖表示
		{
			get
			{
				return this.鎖1.表示;
			}
			set
			{
				this.鎖1.表示 = value;
				this.鎖2.表示 = value;
				this.鎖3.表示 = value;
				this.鎖4.表示 = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.尾5_背板_表示;
			}
			set
			{
				this.尾5_背板_表示 = value;
				this.尾5_節_表示 = value;
				this.尾5_胸板_表示 = value;
				this.尾5_表示 = value;
				this.尾5_瘤左2_表示 = value;
				this.尾5_瘤左1_表示 = value;
				this.尾5_瘤右2_表示 = value;
				this.尾5_瘤右1_表示 = value;
				this.尾4_背板_表示 = value;
				this.尾4_節_表示 = value;
				this.尾4_胸板_表示 = value;
				this.尾4_表示 = value;
				this.尾4_瘤左2_表示 = value;
				this.尾4_瘤左1_表示 = value;
				this.尾4_瘤右2_表示 = value;
				this.尾4_瘤右1_表示 = value;
				this.尾3_背板_表示 = value;
				this.尾3_節_表示 = value;
				this.尾3_胸板_表示 = value;
				this.尾3_表示 = value;
				this.尾3_瘤左2_表示 = value;
				this.尾3_瘤左1_表示 = value;
				this.尾3_瘤右2_表示 = value;
				this.尾3_瘤右1_表示 = value;
				this.輪2_革_表示 = value;
				this.輪2_金具1_表示 = value;
				this.輪2_金具2_表示 = value;
				this.輪2_金具3_表示 = value;
				this.輪2_金具左_表示 = value;
				this.輪2_金具右_表示 = value;
				this.尾2_背板_表示 = value;
				this.尾2_節_表示 = value;
				this.尾2_胸板_表示 = value;
				this.尾2_表示 = value;
				this.尾2_瘤左2_表示 = value;
				this.尾2_瘤左1_表示 = value;
				this.尾2_瘤右2_表示 = value;
				this.尾2_瘤右1_表示 = value;
				this.尾1_背板_表示 = value;
				this.尾1_節_表示 = value;
				this.尾1_胸板_表示 = value;
				this.尾1_表示 = value;
				this.尾1_瘤左2_表示 = value;
				this.尾1_瘤左1_表示 = value;
				this.尾1_瘤右2_表示 = value;
				this.尾1_瘤右1_表示 = value;
				this.尾0_背板_表示 = value;
				this.尾0_節_表示 = value;
				this.尾0_胸板_表示 = value;
				this.尾0_表示 = value;
				this.尾0_瘤左2_表示 = value;
				this.尾0_瘤左1_表示 = value;
				this.尾0_瘤右2_表示 = value;
				this.尾0_瘤右1_表示 = value;
				this.輪1_革_表示 = value;
				this.輪1_金具1_表示 = value;
				this.輪1_金具2_表示 = value;
				this.輪1_金具3_表示 = value;
				this.輪1_金具左_表示 = value;
				this.輪1_金具右_表示 = value;
				this.鎖1.表示 = value;
				this.鎖2.表示 = value;
				this.鎖3.表示 = value;
				this.鎖4.表示 = value;
			}
		}

		public override void 描画0(Are Are)
		{
			Are.Draw(this.X0Y0_尾5_背板);
			Are.Draw(this.X0Y0_尾5_節);
			Are.Draw(this.X0Y0_尾5_胸板);
			Are.Draw(this.X0Y0_尾5_尾);
			Are.Draw(this.X0Y0_尾5_瘤左2);
			Are.Draw(this.X0Y0_尾5_瘤左1);
			Are.Draw(this.X0Y0_尾5_瘤右2);
			Are.Draw(this.X0Y0_尾5_瘤右1);
			Are.Draw(this.X0Y0_尾4_背板);
			Are.Draw(this.X0Y0_尾4_節);
			Are.Draw(this.X0Y0_尾4_胸板);
			Are.Draw(this.X0Y0_尾4_尾);
			Are.Draw(this.X0Y0_尾4_瘤左2);
			Are.Draw(this.X0Y0_尾4_瘤左1);
			Are.Draw(this.X0Y0_尾4_瘤右2);
			Are.Draw(this.X0Y0_尾4_瘤右1);
			Are.Draw(this.X0Y0_尾3_背板);
			Are.Draw(this.X0Y0_尾3_節);
			Are.Draw(this.X0Y0_尾3_胸板);
			Are.Draw(this.X0Y0_尾3_尾);
			Are.Draw(this.X0Y0_尾3_瘤左2);
			Are.Draw(this.X0Y0_尾3_瘤左1);
			Are.Draw(this.X0Y0_尾3_瘤右2);
			Are.Draw(this.X0Y0_尾3_瘤右1);
			Are.Draw(this.X0Y0_輪2_革);
			Are.Draw(this.X0Y0_輪2_金具1);
			Are.Draw(this.X0Y0_輪2_金具2);
			Are.Draw(this.X0Y0_輪2_金具3);
			Are.Draw(this.X0Y0_輪2_金具左);
			Are.Draw(this.X0Y0_輪2_金具右);
			this.鎖3.描画0(Are);
			this.鎖4.描画0(Are);
			Are.Draw(this.X0Y0_尾2_背板);
			Are.Draw(this.X0Y0_尾2_節);
			Are.Draw(this.X0Y0_尾2_胸板);
			Are.Draw(this.X0Y0_尾2_尾);
			Are.Draw(this.X0Y0_尾2_瘤左2);
			Are.Draw(this.X0Y0_尾2_瘤左1);
			Are.Draw(this.X0Y0_尾2_瘤右2);
			Are.Draw(this.X0Y0_尾2_瘤右1);
			Are.Draw(this.X0Y0_尾1_背板);
			Are.Draw(this.X0Y0_尾1_節);
			Are.Draw(this.X0Y0_尾1_胸板);
			Are.Draw(this.X0Y0_尾1_尾);
			Are.Draw(this.X0Y0_尾1_瘤左2);
			Are.Draw(this.X0Y0_尾1_瘤左1);
			Are.Draw(this.X0Y0_尾1_瘤右2);
			Are.Draw(this.X0Y0_尾1_瘤右1);
			Are.Draw(this.X0Y0_輪1_革);
			Are.Draw(this.X0Y0_輪1_金具1);
			Are.Draw(this.X0Y0_輪1_金具2);
			Are.Draw(this.X0Y0_輪1_金具3);
			Are.Draw(this.X0Y0_輪1_金具左);
			Are.Draw(this.X0Y0_輪1_金具右);
			this.鎖1.描画0(Are);
			this.鎖2.描画0(Are);
			Are.Draw(this.X0Y0_尾0_背板);
			Are.Draw(this.X0Y0_尾0_節);
			Are.Draw(this.X0Y0_尾0_胸板);
			Are.Draw(this.X0Y0_尾0_尾);
			Are.Draw(this.X0Y0_尾0_瘤左2);
			Are.Draw(this.X0Y0_尾0_瘤左1);
			Are.Draw(this.X0Y0_尾0_瘤右2);
			Are.Draw(this.X0Y0_尾0_瘤右1);
		}

		public override void Dispose()
		{
			base.Dispose();
			this.鎖1.Dispose();
			this.鎖2.Dispose();
			this.鎖3.Dispose();
			this.鎖4.Dispose();
		}

		public override double 濃度
		{
			get
			{
				return this.尾5_背板CD.不透明度;
			}
			set
			{
				this.尾5_背板CD.不透明度 = value;
				this.尾5_節CD.不透明度 = value;
				this.尾5_胸板CD.不透明度 = value;
				this.尾5_尾CD.不透明度 = value;
				this.尾5_瘤左2CD.不透明度 = value;
				this.尾5_瘤左1CD.不透明度 = value;
				this.尾5_瘤右2CD.不透明度 = value;
				this.尾5_瘤右1CD.不透明度 = value;
				this.尾4_背板CD.不透明度 = value;
				this.尾4_節CD.不透明度 = value;
				this.尾4_胸板CD.不透明度 = value;
				this.尾4_尾CD.不透明度 = value;
				this.尾4_瘤左2CD.不透明度 = value;
				this.尾4_瘤左1CD.不透明度 = value;
				this.尾4_瘤右2CD.不透明度 = value;
				this.尾4_瘤右1CD.不透明度 = value;
				this.尾3_背板CD.不透明度 = value;
				this.尾3_節CD.不透明度 = value;
				this.尾3_胸板CD.不透明度 = value;
				this.尾3_尾CD.不透明度 = value;
				this.尾3_瘤左2CD.不透明度 = value;
				this.尾3_瘤左1CD.不透明度 = value;
				this.尾3_瘤右2CD.不透明度 = value;
				this.尾3_瘤右1CD.不透明度 = value;
				this.尾2_背板CD.不透明度 = value;
				this.尾2_節CD.不透明度 = value;
				this.尾2_胸板CD.不透明度 = value;
				this.尾2_尾CD.不透明度 = value;
				this.尾2_瘤左2CD.不透明度 = value;
				this.尾2_瘤左1CD.不透明度 = value;
				this.尾2_瘤右2CD.不透明度 = value;
				this.尾2_瘤右1CD.不透明度 = value;
				this.尾1_背板CD.不透明度 = value;
				this.尾1_節CD.不透明度 = value;
				this.尾1_胸板CD.不透明度 = value;
				this.尾1_尾CD.不透明度 = value;
				this.尾1_瘤左2CD.不透明度 = value;
				this.尾1_瘤左1CD.不透明度 = value;
				this.尾1_瘤右2CD.不透明度 = value;
				this.尾1_瘤右1CD.不透明度 = value;
				this.尾0_背板CD.不透明度 = value;
				this.尾0_節CD.不透明度 = value;
				this.尾0_胸板CD.不透明度 = value;
				this.尾0_尾CD.不透明度 = value;
				this.尾0_瘤左2CD.不透明度 = value;
				this.尾0_瘤左1CD.不透明度 = value;
				this.尾0_瘤右2CD.不透明度 = value;
				this.尾0_瘤右1CD.不透明度 = value;
				this.輪1_革CD.不透明度 = value;
				this.輪1_金具1CD.不透明度 = value;
				this.輪1_金具2CD.不透明度 = value;
				this.輪1_金具3CD.不透明度 = value;
				this.輪1_金具左CD.不透明度 = value;
				this.輪1_金具右CD.不透明度 = value;
				this.輪2_革CD.不透明度 = value;
				this.輪2_金具1CD.不透明度 = value;
				this.輪2_金具2CD.不透明度 = value;
				this.輪2_金具3CD.不透明度 = value;
				this.輪2_金具左CD.不透明度 = value;
				this.輪2_金具右CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			bool 右 = this.右;
			double maxAngle = 20.0;
			this.X0Y0_尾5_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾4_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾3_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾2_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾1_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾0_尾.AngleBase = maxAngle.GetRanAngle();
			this.本体.JoinPAall();
		}

		public bool 胸板
		{
			get
			{
				return this.尾5_胸板_表示;
			}
			set
			{
				this.尾5_胸板_表示 = value;
				this.尾4_胸板_表示 = value;
				this.尾3_胸板_表示 = value;
				this.尾2_胸板_表示 = value;
				this.尾1_胸板_表示 = value;
				this.尾0_胸板_表示 = value;
			}
		}

		public bool 節
		{
			get
			{
				return this.尾5_節_表示;
			}
			set
			{
				this.尾5_節_表示 = value;
				this.尾4_節_表示 = value;
				this.尾3_節_表示 = value;
				this.尾2_節_表示 = value;
				this.尾1_節_表示 = value;
				this.尾0_節_表示 = value;
			}
		}

		public bool 背板
		{
			get
			{
				return this.尾5_背板_表示;
			}
			set
			{
				this.尾5_背板_表示 = value;
				this.尾4_背板_表示 = value;
				this.尾3_背板_表示 = value;
				this.尾2_背板_表示 = value;
				this.尾1_背板_表示 = value;
				this.尾0_背板_表示 = value;
			}
		}

		public bool 胴
		{
			get
			{
				return this.尾5_表示;
			}
			set
			{
				this.尾5_表示 = value;
				this.尾4_表示 = value;
				this.尾3_表示 = value;
				this.尾2_表示 = value;
				this.尾1_表示 = value;
				this.尾0_表示 = value;
			}
		}

		public bool 瘤
		{
			get
			{
				return this.尾5_瘤左2_表示;
			}
			set
			{
				this.尾5_瘤左2_表示 = value;
				this.尾5_瘤左1_表示 = value;
				this.尾5_瘤右2_表示 = value;
				this.尾5_瘤右1_表示 = value;
				this.尾4_瘤左2_表示 = value;
				this.尾4_瘤左1_表示 = value;
				this.尾4_瘤右2_表示 = value;
				this.尾4_瘤右1_表示 = value;
				this.尾3_瘤左2_表示 = value;
				this.尾3_瘤左1_表示 = value;
				this.尾3_瘤右2_表示 = value;
				this.尾3_瘤右1_表示 = value;
				this.尾2_瘤左2_表示 = value;
				this.尾2_瘤左1_表示 = value;
				this.尾2_瘤右2_表示 = value;
				this.尾2_瘤右1_表示 = value;
				this.尾1_瘤左2_表示 = value;
				this.尾1_瘤左1_表示 = value;
				this.尾1_瘤右2_表示 = value;
				this.尾1_瘤右1_表示 = value;
				this.尾0_瘤左2_表示 = value;
				this.尾0_瘤左1_表示 = value;
				this.尾0_瘤右2_表示 = value;
				this.尾0_瘤右1_表示 = value;
			}
		}

		public override bool Is革(Par p)
		{
			return p == this.X0Y0_輪2_革 || p == this.X0Y0_輪2_金具1 || p == this.X0Y0_輪2_金具2 || p == this.X0Y0_輪2_金具3 || p == this.X0Y0_輪2_金具左 || p == this.X0Y0_輪2_金具右 || p == this.X0Y0_輪1_革 || p == this.X0Y0_輪1_金具1 || p == this.X0Y0_輪1_金具2 || p == this.X0Y0_輪1_金具3 || p == this.X0Y0_輪1_金具左 || p == this.X0Y0_輪1_金具右;
		}

		public override IEnumerable<Par> Enum軸()
		{
			yield return this.X0Y0_尾0_尾;
			yield return this.X0Y0_尾1_尾;
			yield return this.X0Y0_尾2_尾;
			yield return this.X0Y0_尾3_尾;
			yield return this.X0Y0_尾4_尾;
			yield return this.X0Y0_尾5_尾;
			yield break;
		}

		public JointS 左1_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾0_尾, 0);
			}
		}

		public JointS 右1_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾0_尾, 1);
			}
		}

		public JointS 左2_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾1_尾, 0);
			}
		}

		public JointS 右2_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾1_尾, 1);
			}
		}

		public JointS 左3_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾2_尾, 0);
			}
		}

		public JointS 右3_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾2_尾, 1);
			}
		}

		public JointS 左4_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾3_尾, 0);
			}
		}

		public JointS 右4_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾3_尾, 1);
			}
		}

		public JointS 左5_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾4_尾, 0);
			}
		}

		public JointS 右5_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾4_尾, 1);
			}
		}

		public JointS 尾左_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾5_尾, 0);
			}
		}

		public JointS 尾右_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾5_尾, 1);
			}
		}

		public JointS 鎖1_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_輪1_金具左, 0);
			}
		}

		public JointS 鎖2_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_輪1_金具右, 0);
			}
		}

		public JointS 鎖3_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_輪2_金具左, 0);
			}
		}

		public JointS 鎖4_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_輪2_金具右, 0);
			}
		}

		public override void 色更新()
		{
			this.X0Y0_尾5_背板CP.Update();
			this.X0Y0_尾5_節CP.Update();
			this.X0Y0_尾5_胸板CP.Update();
			this.X0Y0_尾5_尾CP.Update();
			this.X0Y0_尾5_瘤左2CP.Update();
			this.X0Y0_尾5_瘤左1CP.Update();
			this.X0Y0_尾5_瘤右2CP.Update();
			this.X0Y0_尾5_瘤右1CP.Update();
			this.X0Y0_尾4_背板CP.Update();
			this.X0Y0_尾4_節CP.Update();
			this.X0Y0_尾4_胸板CP.Update();
			this.X0Y0_尾4_尾CP.Update();
			this.X0Y0_尾4_瘤左2CP.Update();
			this.X0Y0_尾4_瘤左1CP.Update();
			this.X0Y0_尾4_瘤右2CP.Update();
			this.X0Y0_尾4_瘤右1CP.Update();
			this.X0Y0_尾3_背板CP.Update();
			this.X0Y0_尾3_節CP.Update();
			this.X0Y0_尾3_胸板CP.Update();
			this.X0Y0_尾3_尾CP.Update();
			this.X0Y0_尾3_瘤左2CP.Update();
			this.X0Y0_尾3_瘤左1CP.Update();
			this.X0Y0_尾3_瘤右2CP.Update();
			this.X0Y0_尾3_瘤右1CP.Update();
			this.X0Y0_輪2_革CP.Update();
			this.X0Y0_輪2_金具1CP.Update();
			this.X0Y0_輪2_金具2CP.Update();
			this.X0Y0_輪2_金具3CP.Update();
			this.X0Y0_輪2_金具左CP.Update();
			this.X0Y0_輪2_金具右CP.Update();
			this.X0Y0_尾2_背板CP.Update();
			this.X0Y0_尾2_節CP.Update();
			this.X0Y0_尾2_胸板CP.Update();
			this.X0Y0_尾2_尾CP.Update();
			this.X0Y0_尾2_瘤左2CP.Update();
			this.X0Y0_尾2_瘤左1CP.Update();
			this.X0Y0_尾2_瘤右2CP.Update();
			this.X0Y0_尾2_瘤右1CP.Update();
			this.X0Y0_尾1_背板CP.Update();
			this.X0Y0_尾1_節CP.Update();
			this.X0Y0_尾1_胸板CP.Update();
			this.X0Y0_尾1_尾CP.Update();
			this.X0Y0_尾1_瘤左2CP.Update();
			this.X0Y0_尾1_瘤左1CP.Update();
			this.X0Y0_尾1_瘤右2CP.Update();
			this.X0Y0_尾1_瘤右1CP.Update();
			this.X0Y0_尾0_背板CP.Update();
			this.X0Y0_尾0_節CP.Update();
			this.X0Y0_尾0_胸板CP.Update();
			this.X0Y0_尾0_尾CP.Update();
			this.X0Y0_尾0_瘤左2CP.Update();
			this.X0Y0_尾0_瘤左1CP.Update();
			this.X0Y0_尾0_瘤右2CP.Update();
			this.X0Y0_尾0_瘤右1CP.Update();
			this.X0Y0_輪1_革CP.Update();
			this.X0Y0_輪1_金具1CP.Update();
			this.X0Y0_輪1_金具2CP.Update();
			this.X0Y0_輪1_金具3CP.Update();
			this.X0Y0_輪1_金具左CP.Update();
			this.X0Y0_輪1_金具右CP.Update();
			this.鎖1.接続PA();
			this.鎖2.接続PA();
			this.鎖3.接続PA();
			this.鎖4.接続PA();
			this.鎖1.色更新();
			this.鎖2.色更新();
			this.鎖3.色更新();
			this.鎖4.色更新();
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
			this.尾5_背板CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.尾5_節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾5_胸板CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾5_尾CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾5_瘤左2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾5_瘤左1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾5_瘤右2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾5_瘤右1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾4_背板CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.尾4_節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾4_胸板CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾4_尾CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾4_瘤左2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾4_瘤左1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾4_瘤右2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾4_瘤右1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾3_背板CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.尾3_節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾3_胸板CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾3_尾CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾3_瘤左2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾3_瘤左1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾3_瘤右2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾3_瘤右1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾2_背板CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.尾2_節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾2_胸板CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾2_尾CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾2_瘤左2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾2_瘤左1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾2_瘤右2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾2_瘤右1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾1_背板CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.尾1_節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾1_胸板CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾1_尾CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾1_瘤左2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾1_瘤左1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾1_瘤右2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾1_瘤右1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾0_背板CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.尾0_節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾0_胸板CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾0_尾CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾0_瘤左2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾0_瘤左1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾0_瘤右2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾0_瘤右1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.輪1_革CD = new ColorD();
			this.輪1_金具1CD = new ColorD();
			this.輪1_金具2CD = new ColorD();
			this.輪1_金具3CD = new ColorD();
			this.輪1_金具左CD = new ColorD();
			this.輪1_金具右CD = new ColorD();
			this.輪2_革CD = new ColorD();
			this.輪2_金具1CD = new ColorD();
			this.輪2_金具2CD = new ColorD();
			this.輪2_金具3CD = new ColorD();
			this.輪2_金具左CD = new ColorD();
			this.輪2_金具右CD = new ColorD();
		}

		private void 配色T0(体配色 体配色)
		{
			this.尾5_背板CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.尾5_節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾5_胸板CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾5_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾5_瘤左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾5_瘤左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾5_瘤右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾5_瘤右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾4_背板CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.尾4_節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾4_胸板CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾4_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾4_瘤左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾4_瘤左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾4_瘤右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾4_瘤右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾3_背板CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.尾3_節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾3_胸板CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾3_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾3_瘤左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾3_瘤左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾3_瘤右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾3_瘤右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾2_背板CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.尾2_節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾2_胸板CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾2_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾2_瘤左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾2_瘤左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾2_瘤右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾2_瘤右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾1_背板CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.尾1_節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾1_胸板CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾1_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾1_瘤左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾1_瘤左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾1_瘤右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾1_瘤右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾0_背板CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.尾0_節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾0_胸板CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾0_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾0_瘤左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾0_瘤左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾0_瘤右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾0_瘤右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.輪1_革CD = new ColorD();
			this.輪1_金具1CD = new ColorD();
			this.輪1_金具2CD = new ColorD();
			this.輪1_金具3CD = new ColorD();
			this.輪1_金具左CD = new ColorD();
			this.輪1_金具右CD = new ColorD();
			this.輪2_革CD = new ColorD();
			this.輪2_金具1CD = new ColorD();
			this.輪2_金具2CD = new ColorD();
			this.輪2_金具3CD = new ColorD();
			this.輪2_金具左CD = new ColorD();
			this.輪2_金具右CD = new ColorD();
		}

		private void 配色T1(体配色 体配色)
		{
			this.尾5_背板CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.尾5_節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾5_胸板CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾5_尾CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾5_瘤左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾5_瘤左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾5_瘤右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾5_瘤右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾4_背板CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.尾4_節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾4_胸板CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾4_尾CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾4_瘤左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾4_瘤左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾4_瘤右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾4_瘤右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾3_背板CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.尾3_節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾3_胸板CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾3_尾CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾3_瘤左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾3_瘤左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾3_瘤右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾3_瘤右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾2_背板CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.尾2_節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾2_胸板CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾2_尾CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾2_瘤左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾2_瘤左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾2_瘤右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾2_瘤右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾1_背板CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.尾1_節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾1_胸板CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾1_尾CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾1_瘤左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾1_瘤左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾1_瘤右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾1_瘤右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾0_背板CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.尾0_節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾0_胸板CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾0_尾CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.尾0_瘤左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾0_瘤左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾0_瘤右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾0_瘤右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.輪1_革CD = new ColorD();
			this.輪1_金具1CD = new ColorD();
			this.輪1_金具2CD = new ColorD();
			this.輪1_金具3CD = new ColorD();
			this.輪1_金具左CD = new ColorD();
			this.輪1_金具右CD = new ColorD();
			this.輪2_革CD = new ColorD();
			this.輪2_金具1CD = new ColorD();
			this.輪2_金具2CD = new ColorD();
			this.輪2_金具3CD = new ColorD();
			this.輪2_金具左CD = new ColorD();
			this.輪2_金具右CD = new ColorD();
		}

		public void 輪1配色(拘束具色 配色)
		{
			this.輪1_革CD.色 = 配色.革部色;
			this.輪1_金具1CD.色 = 配色.金具色;
			this.輪1_金具2CD.色 = this.輪1_金具1CD.色;
			this.輪1_金具3CD.色 = this.輪1_金具1CD.色;
			this.輪1_金具左CD.色 = this.輪1_金具1CD.色;
			this.輪1_金具右CD.色 = this.輪1_金具1CD.色;
		}

		public void 輪2配色(拘束具色 配色)
		{
			this.輪2_革CD.色 = 配色.革部色;
			this.輪2_金具1CD.色 = 配色.金具色;
			this.輪2_金具2CD.色 = this.輪2_金具1CD.色;
			this.輪2_金具3CD.色 = this.輪2_金具1CD.色;
			this.輪2_金具左CD.色 = this.輪2_金具1CD.色;
			this.輪2_金具右CD.色 = this.輪2_金具1CD.色;
		}

		public void 鎖配色(鎖色 配色)
		{
			this.鎖1.配色鎖(配色);
			this.鎖2.配色鎖(配色);
			this.鎖3.配色鎖(配色);
			this.鎖4.配色鎖(配色);
		}

		public Par X0Y0_尾5_背板;

		public Par X0Y0_尾5_節;

		public Par X0Y0_尾5_胸板;

		public Par X0Y0_尾5_尾;

		public Par X0Y0_尾5_瘤左2;

		public Par X0Y0_尾5_瘤左1;

		public Par X0Y0_尾5_瘤右2;

		public Par X0Y0_尾5_瘤右1;

		public Par X0Y0_尾4_背板;

		public Par X0Y0_尾4_節;

		public Par X0Y0_尾4_胸板;

		public Par X0Y0_尾4_尾;

		public Par X0Y0_尾4_瘤左2;

		public Par X0Y0_尾4_瘤左1;

		public Par X0Y0_尾4_瘤右2;

		public Par X0Y0_尾4_瘤右1;

		public Par X0Y0_尾3_背板;

		public Par X0Y0_尾3_節;

		public Par X0Y0_尾3_胸板;

		public Par X0Y0_尾3_尾;

		public Par X0Y0_尾3_瘤左2;

		public Par X0Y0_尾3_瘤左1;

		public Par X0Y0_尾3_瘤右2;

		public Par X0Y0_尾3_瘤右1;

		public Par X0Y0_輪2_革;

		public Par X0Y0_輪2_金具1;

		public Par X0Y0_輪2_金具2;

		public Par X0Y0_輪2_金具3;

		public Par X0Y0_輪2_金具左;

		public Par X0Y0_輪2_金具右;

		public Par X0Y0_尾2_背板;

		public Par X0Y0_尾2_節;

		public Par X0Y0_尾2_胸板;

		public Par X0Y0_尾2_尾;

		public Par X0Y0_尾2_瘤左2;

		public Par X0Y0_尾2_瘤左1;

		public Par X0Y0_尾2_瘤右2;

		public Par X0Y0_尾2_瘤右1;

		public Par X0Y0_尾1_背板;

		public Par X0Y0_尾1_節;

		public Par X0Y0_尾1_胸板;

		public Par X0Y0_尾1_尾;

		public Par X0Y0_尾1_瘤左2;

		public Par X0Y0_尾1_瘤左1;

		public Par X0Y0_尾1_瘤右2;

		public Par X0Y0_尾1_瘤右1;

		public Par X0Y0_輪1_革;

		public Par X0Y0_輪1_金具1;

		public Par X0Y0_輪1_金具2;

		public Par X0Y0_輪1_金具3;

		public Par X0Y0_輪1_金具左;

		public Par X0Y0_輪1_金具右;

		public Par X0Y0_尾0_背板;

		public Par X0Y0_尾0_節;

		public Par X0Y0_尾0_胸板;

		public Par X0Y0_尾0_尾;

		public Par X0Y0_尾0_瘤左2;

		public Par X0Y0_尾0_瘤左1;

		public Par X0Y0_尾0_瘤右2;

		public Par X0Y0_尾0_瘤右1;

		public ColorD 尾5_背板CD;

		public ColorD 尾5_節CD;

		public ColorD 尾5_胸板CD;

		public ColorD 尾5_尾CD;

		public ColorD 尾5_瘤左2CD;

		public ColorD 尾5_瘤左1CD;

		public ColorD 尾5_瘤右2CD;

		public ColorD 尾5_瘤右1CD;

		public ColorD 尾4_背板CD;

		public ColorD 尾4_節CD;

		public ColorD 尾4_胸板CD;

		public ColorD 尾4_尾CD;

		public ColorD 尾4_瘤左2CD;

		public ColorD 尾4_瘤左1CD;

		public ColorD 尾4_瘤右2CD;

		public ColorD 尾4_瘤右1CD;

		public ColorD 尾3_背板CD;

		public ColorD 尾3_節CD;

		public ColorD 尾3_胸板CD;

		public ColorD 尾3_尾CD;

		public ColorD 尾3_瘤左2CD;

		public ColorD 尾3_瘤左1CD;

		public ColorD 尾3_瘤右2CD;

		public ColorD 尾3_瘤右1CD;

		public ColorD 尾2_背板CD;

		public ColorD 尾2_節CD;

		public ColorD 尾2_胸板CD;

		public ColorD 尾2_尾CD;

		public ColorD 尾2_瘤左2CD;

		public ColorD 尾2_瘤左1CD;

		public ColorD 尾2_瘤右2CD;

		public ColorD 尾2_瘤右1CD;

		public ColorD 尾1_背板CD;

		public ColorD 尾1_節CD;

		public ColorD 尾1_胸板CD;

		public ColorD 尾1_尾CD;

		public ColorD 尾1_瘤左2CD;

		public ColorD 尾1_瘤左1CD;

		public ColorD 尾1_瘤右2CD;

		public ColorD 尾1_瘤右1CD;

		public ColorD 尾0_背板CD;

		public ColorD 尾0_節CD;

		public ColorD 尾0_胸板CD;

		public ColorD 尾0_尾CD;

		public ColorD 尾0_瘤左2CD;

		public ColorD 尾0_瘤左1CD;

		public ColorD 尾0_瘤右2CD;

		public ColorD 尾0_瘤右1CD;

		public ColorD 輪1_革CD;

		public ColorD 輪1_金具1CD;

		public ColorD 輪1_金具2CD;

		public ColorD 輪1_金具3CD;

		public ColorD 輪1_金具左CD;

		public ColorD 輪1_金具右CD;

		public ColorD 輪2_革CD;

		public ColorD 輪2_金具1CD;

		public ColorD 輪2_金具2CD;

		public ColorD 輪2_金具3CD;

		public ColorD 輪2_金具左CD;

		public ColorD 輪2_金具右CD;

		public ColorP X0Y0_尾5_背板CP;

		public ColorP X0Y0_尾5_節CP;

		public ColorP X0Y0_尾5_胸板CP;

		public ColorP X0Y0_尾5_尾CP;

		public ColorP X0Y0_尾5_瘤左2CP;

		public ColorP X0Y0_尾5_瘤左1CP;

		public ColorP X0Y0_尾5_瘤右2CP;

		public ColorP X0Y0_尾5_瘤右1CP;

		public ColorP X0Y0_尾4_背板CP;

		public ColorP X0Y0_尾4_節CP;

		public ColorP X0Y0_尾4_胸板CP;

		public ColorP X0Y0_尾4_尾CP;

		public ColorP X0Y0_尾4_瘤左2CP;

		public ColorP X0Y0_尾4_瘤左1CP;

		public ColorP X0Y0_尾4_瘤右2CP;

		public ColorP X0Y0_尾4_瘤右1CP;

		public ColorP X0Y0_尾3_背板CP;

		public ColorP X0Y0_尾3_節CP;

		public ColorP X0Y0_尾3_胸板CP;

		public ColorP X0Y0_尾3_尾CP;

		public ColorP X0Y0_尾3_瘤左2CP;

		public ColorP X0Y0_尾3_瘤左1CP;

		public ColorP X0Y0_尾3_瘤右2CP;

		public ColorP X0Y0_尾3_瘤右1CP;

		public ColorP X0Y0_輪2_革CP;

		public ColorP X0Y0_輪2_金具1CP;

		public ColorP X0Y0_輪2_金具2CP;

		public ColorP X0Y0_輪2_金具3CP;

		public ColorP X0Y0_輪2_金具左CP;

		public ColorP X0Y0_輪2_金具右CP;

		public ColorP X0Y0_尾2_背板CP;

		public ColorP X0Y0_尾2_節CP;

		public ColorP X0Y0_尾2_胸板CP;

		public ColorP X0Y0_尾2_尾CP;

		public ColorP X0Y0_尾2_瘤左2CP;

		public ColorP X0Y0_尾2_瘤左1CP;

		public ColorP X0Y0_尾2_瘤右2CP;

		public ColorP X0Y0_尾2_瘤右1CP;

		public ColorP X0Y0_尾1_背板CP;

		public ColorP X0Y0_尾1_節CP;

		public ColorP X0Y0_尾1_胸板CP;

		public ColorP X0Y0_尾1_尾CP;

		public ColorP X0Y0_尾1_瘤左2CP;

		public ColorP X0Y0_尾1_瘤左1CP;

		public ColorP X0Y0_尾1_瘤右2CP;

		public ColorP X0Y0_尾1_瘤右1CP;

		public ColorP X0Y0_尾0_背板CP;

		public ColorP X0Y0_尾0_節CP;

		public ColorP X0Y0_尾0_胸板CP;

		public ColorP X0Y0_尾0_尾CP;

		public ColorP X0Y0_尾0_瘤左2CP;

		public ColorP X0Y0_尾0_瘤左1CP;

		public ColorP X0Y0_尾0_瘤右2CP;

		public ColorP X0Y0_尾0_瘤右1CP;

		public ColorP X0Y0_輪1_革CP;

		public ColorP X0Y0_輪1_金具1CP;

		public ColorP X0Y0_輪1_金具2CP;

		public ColorP X0Y0_輪1_金具3CP;

		public ColorP X0Y0_輪1_金具左CP;

		public ColorP X0Y0_輪1_金具右CP;

		public 拘束鎖 鎖1;

		public 拘束鎖 鎖2;

		public 拘束鎖 鎖3;

		public 拘束鎖 鎖4;

		public Ele[] 左1_接続;

		public Ele[] 右1_接続;

		public Ele[] 左2_接続;

		public Ele[] 右2_接続;

		public Ele[] 左3_接続;

		public Ele[] 右3_接続;

		public Ele[] 左4_接続;

		public Ele[] 右4_接続;

		public Ele[] 左5_接続;

		public Ele[] 右5_接続;

		public Ele[] 尾左_接続;

		public Ele[] 尾右_接続;
	}
}
