using System;
using System.Collections.Generic;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 長物_鯨 : 半身
	{
		public 長物_鯨(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 長物_鯨D e)
		{
			長物_鯨.<>c__DisplayClass94_0 CS$<>8__locals1 = new 長物_鯨.<>c__DisplayClass94_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "鯨";
			dif.Add(new Pars(Sta.半身["長物"][0][1]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			Pars pars2 = pars["胴6"].ToPars();
			this.X0Y0_胴6_胴 = pars2["胴"].ToPar();
			this.X0Y0_胴6_柄 = pars2["柄"].ToPar();
			this.X0Y0_胴6_縦影 = pars2["縦影"].ToPar();
			pars2 = pars["胴5"].ToPars();
			this.X0Y0_胴5_胴 = pars2["胴"].ToPar();
			this.X0Y0_胴5_柄 = pars2["柄"].ToPar();
			this.X0Y0_胴5_縦影 = pars2["縦影"].ToPar();
			pars2 = pars["輪2"].ToPars();
			this.X0Y0_輪2_革 = pars2["革"].ToPar();
			this.X0Y0_輪2_金具1 = pars2["金具1"].ToPar();
			this.X0Y0_輪2_金具2 = pars2["金具2"].ToPar();
			this.X0Y0_輪2_金具3 = pars2["金具3"].ToPar();
			this.X0Y0_輪2_金具左 = pars2["金具左"].ToPar();
			this.X0Y0_輪2_金具右 = pars2["金具右"].ToPar();
			pars2 = pars["胴4"].ToPars();
			this.X0Y0_胴4_胴 = pars2["胴"].ToPar();
			this.X0Y0_胴4_柄 = pars2["柄"].ToPar();
			this.X0Y0_胴4_縦影 = pars2["縦影"].ToPar();
			pars2 = pars["胴3"].ToPars();
			this.X0Y0_胴3_胴 = pars2["胴"].ToPar();
			this.X0Y0_胴3_柄 = pars2["柄"].ToPar();
			this.X0Y0_胴3_縦影 = pars2["縦影"].ToPar();
			pars2 = pars["胴2"].ToPars();
			this.X0Y0_胴2_胴 = pars2["胴"].ToPar();
			this.X0Y0_胴2_柄 = pars2["柄"].ToPar();
			this.X0Y0_胴2_縦影 = pars2["縦影"].ToPar();
			pars2 = pars["胴1"].ToPars();
			this.X0Y0_胴1_胴 = pars2["胴"].ToPar();
			this.X0Y0_胴1_柄 = pars2["柄"].ToPar();
			this.X0Y0_胴1_縦影 = pars2["縦影"].ToPar();
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
			this.胴6_表示 = e.胴6_表示;
			this.胴6_柄_表示 = e.胴6_柄_表示;
			this.胴6_縦影_表示 = e.胴6_縦影_表示;
			this.胴5_表示 = e.胴5_表示;
			this.胴5_柄_表示 = e.胴5_柄_表示;
			this.胴5_縦影_表示 = e.胴5_縦影_表示;
			this.輪2_革_表示 = e.輪2_革_表示;
			this.輪2_金具1_表示 = e.輪2_金具1_表示;
			this.輪2_金具2_表示 = e.輪2_金具2_表示;
			this.輪2_金具3_表示 = e.輪2_金具3_表示;
			this.輪2_金具左_表示 = e.輪2_金具左_表示;
			this.輪2_金具右_表示 = e.輪2_金具右_表示;
			this.胴4_表示 = e.胴4_表示;
			this.胴4_柄_表示 = e.胴4_柄_表示;
			this.胴4_縦影_表示 = e.胴4_縦影_表示;
			this.胴3_表示 = e.胴3_表示;
			this.胴3_柄_表示 = e.胴3_柄_表示;
			this.胴3_縦影_表示 = e.胴3_縦影_表示;
			this.胴2_表示 = e.胴2_表示;
			this.胴2_柄_表示 = e.胴2_柄_表示;
			this.胴2_縦影_表示 = e.胴2_縦影_表示;
			this.胴1_表示 = e.胴1_表示;
			this.胴1_柄_表示 = e.胴1_柄_表示;
			this.胴1_縦影_表示 = e.胴1_縦影_表示;
			this.輪1_革_表示 = e.輪1_革_表示;
			this.輪1_金具1_表示 = e.輪1_金具1_表示;
			this.輪1_金具2_表示 = e.輪1_金具2_表示;
			this.輪1_金具3_表示 = e.輪1_金具3_表示;
			this.輪1_金具左_表示 = e.輪1_金具左_表示;
			this.輪1_金具右_表示 = e.輪1_金具右_表示;
			this.輪1表示 = e.輪1表示;
			this.輪2表示 = e.輪2表示;
			this.柄 = e.柄;
			this.縦影 = e.縦影;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.左0_接続.Count > 0)
			{
				Ele f;
				this.左0_接続 = e.左0_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.長物_鯨_左0_接続;
					f.接続(CS$<>8__locals1.<>4__this.左0_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右0_接続.Count > 0)
			{
				Ele f;
				this.右0_接続 = e.右0_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.長物_鯨_右0_接続;
					f.接続(CS$<>8__locals1.<>4__this.右0_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.左1_接続.Count > 0)
			{
				Ele f;
				this.左1_接続 = e.左1_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.長物_鯨_左1_接続;
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
					f.接続情報 = 接続情報.長物_鯨_右1_接続;
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
					f.接続情報 = 接続情報.長物_鯨_左2_接続;
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
					f.接続情報 = 接続情報.長物_鯨_右2_接続;
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
					f.接続情報 = 接続情報.長物_鯨_左3_接続;
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
					f.接続情報 = 接続情報.長物_鯨_右3_接続;
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
					f.接続情報 = 接続情報.長物_鯨_左4_接続;
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
					f.接続情報 = 接続情報.長物_鯨_右4_接続;
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
					f.接続情報 = 接続情報.長物_鯨_左5_接続;
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
					f.接続情報 = 接続情報.長物_鯨_右5_接続;
					f.接続(CS$<>8__locals1.<>4__this.右5_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.左6_接続.Count > 0)
			{
				Ele f;
				this.左6_接続 = e.左6_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.長物_鯨_左6_接続;
					f.接続(CS$<>8__locals1.<>4__this.左6_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右6_接続.Count > 0)
			{
				Ele f;
				this.右6_接続 = e.右6_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.長物_鯨_右6_接続;
					f.接続(CS$<>8__locals1.<>4__this.右6_接続点);
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
					f.接続情報 = 接続情報.長物_鯨_尾_接続;
					f.接続(CS$<>8__locals1.<>4__this.尾_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.Pars = new Par[]
			{
				this.X0Y0_胴6_胴,
				this.X0Y0_胴5_胴,
				this.X0Y0_胴4_胴,
				this.X0Y0_胴3_胴,
				this.X0Y0_胴2_胴,
				this.X0Y0_胴1_胴
			};
			this.X0Y0_胴6_胴CP = new ColorP(this.X0Y0_胴6_胴, this.胴6_胴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴6_柄CP = new ColorP(this.X0Y0_胴6_柄, this.胴6_柄CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴6_縦影CP = new ColorP(this.X0Y0_胴6_縦影, this.胴6_縦影CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴5_胴CP = new ColorP(this.X0Y0_胴5_胴, this.胴5_胴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴5_柄CP = new ColorP(this.X0Y0_胴5_柄, this.胴5_柄CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴5_縦影CP = new ColorP(this.X0Y0_胴5_縦影, this.胴5_縦影CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪2_革CP = new ColorP(this.X0Y0_輪2_革, this.輪2_革CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪2_金具1CP = new ColorP(this.X0Y0_輪2_金具1, this.輪2_金具1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪2_金具2CP = new ColorP(this.X0Y0_輪2_金具2, this.輪2_金具2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪2_金具3CP = new ColorP(this.X0Y0_輪2_金具3, this.輪2_金具3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪2_金具左CP = new ColorP(this.X0Y0_輪2_金具左, this.輪2_金具左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪2_金具右CP = new ColorP(this.X0Y0_輪2_金具右, this.輪2_金具右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴4_胴CP = new ColorP(this.X0Y0_胴4_胴, this.胴4_胴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴4_柄CP = new ColorP(this.X0Y0_胴4_柄, this.胴4_柄CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴4_縦影CP = new ColorP(this.X0Y0_胴4_縦影, this.胴4_縦影CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴3_胴CP = new ColorP(this.X0Y0_胴3_胴, this.胴3_胴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴3_柄CP = new ColorP(this.X0Y0_胴3_柄, this.胴3_柄CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴3_縦影CP = new ColorP(this.X0Y0_胴3_縦影, this.胴3_縦影CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴2_胴CP = new ColorP(this.X0Y0_胴2_胴, this.胴2_胴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴2_柄CP = new ColorP(this.X0Y0_胴2_柄, this.胴2_柄CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴2_縦影CP = new ColorP(this.X0Y0_胴2_縦影, this.胴2_縦影CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴1_胴CP = new ColorP(this.X0Y0_胴1_胴, this.胴1_胴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴1_柄CP = new ColorP(this.X0Y0_胴1_柄, this.胴1_柄CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴1_縦影CP = new ColorP(this.X0Y0_胴1_縦影, this.胴1_縦影CD, CS$<>8__locals1.DisUnit, true);
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
			this.鎖1.角度B += (double)num;
			this.鎖2.角度B -= (double)num;
			this.鎖3.角度B += (double)num;
			this.鎖4.角度B -= (double)num;
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
				this.輪1表示 = value;
				this.輪2表示 = value;
			}
		}

		public bool 胴6_表示
		{
			get
			{
				return this.X0Y0_胴6_胴.Dra;
			}
			set
			{
				this.X0Y0_胴6_胴.Dra = value;
				this.X0Y0_胴6_胴.Hit = value;
			}
		}

		public bool 胴6_柄_表示
		{
			get
			{
				return this.X0Y0_胴6_柄.Dra;
			}
			set
			{
				this.X0Y0_胴6_柄.Dra = value;
				this.X0Y0_胴6_柄.Hit = value;
			}
		}

		public bool 胴6_縦影_表示
		{
			get
			{
				return this.X0Y0_胴6_縦影.Dra;
			}
			set
			{
				this.X0Y0_胴6_縦影.Dra = value;
				this.X0Y0_胴6_縦影.Hit = value;
			}
		}

		public bool 胴5_表示
		{
			get
			{
				return this.X0Y0_胴5_胴.Dra;
			}
			set
			{
				this.X0Y0_胴5_胴.Dra = value;
				this.X0Y0_胴5_胴.Hit = value;
			}
		}

		public bool 胴5_柄_表示
		{
			get
			{
				return this.X0Y0_胴5_柄.Dra;
			}
			set
			{
				this.X0Y0_胴5_柄.Dra = value;
				this.X0Y0_胴5_柄.Hit = value;
			}
		}

		public bool 胴5_縦影_表示
		{
			get
			{
				return this.X0Y0_胴5_縦影.Dra;
			}
			set
			{
				this.X0Y0_胴5_縦影.Dra = value;
				this.X0Y0_胴5_縦影.Hit = value;
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

		public bool 胴4_表示
		{
			get
			{
				return this.X0Y0_胴4_胴.Dra;
			}
			set
			{
				this.X0Y0_胴4_胴.Dra = value;
				this.X0Y0_胴4_胴.Hit = value;
			}
		}

		public bool 胴4_柄_表示
		{
			get
			{
				return this.X0Y0_胴4_柄.Dra;
			}
			set
			{
				this.X0Y0_胴4_柄.Dra = value;
				this.X0Y0_胴4_柄.Hit = value;
			}
		}

		public bool 胴4_縦影_表示
		{
			get
			{
				return this.X0Y0_胴4_縦影.Dra;
			}
			set
			{
				this.X0Y0_胴4_縦影.Dra = value;
				this.X0Y0_胴4_縦影.Hit = value;
			}
		}

		public bool 胴3_表示
		{
			get
			{
				return this.X0Y0_胴3_胴.Dra;
			}
			set
			{
				this.X0Y0_胴3_胴.Dra = value;
				this.X0Y0_胴3_胴.Hit = value;
			}
		}

		public bool 胴3_柄_表示
		{
			get
			{
				return this.X0Y0_胴3_柄.Dra;
			}
			set
			{
				this.X0Y0_胴3_柄.Dra = value;
				this.X0Y0_胴3_柄.Hit = value;
			}
		}

		public bool 胴3_縦影_表示
		{
			get
			{
				return this.X0Y0_胴3_縦影.Dra;
			}
			set
			{
				this.X0Y0_胴3_縦影.Dra = value;
				this.X0Y0_胴3_縦影.Hit = value;
			}
		}

		public bool 胴2_表示
		{
			get
			{
				return this.X0Y0_胴2_胴.Dra;
			}
			set
			{
				this.X0Y0_胴2_胴.Dra = value;
				this.X0Y0_胴2_胴.Hit = value;
			}
		}

		public bool 胴2_柄_表示
		{
			get
			{
				return this.X0Y0_胴2_柄.Dra;
			}
			set
			{
				this.X0Y0_胴2_柄.Dra = value;
				this.X0Y0_胴2_柄.Hit = value;
			}
		}

		public bool 胴2_縦影_表示
		{
			get
			{
				return this.X0Y0_胴2_縦影.Dra;
			}
			set
			{
				this.X0Y0_胴2_縦影.Dra = value;
				this.X0Y0_胴2_縦影.Hit = value;
			}
		}

		public bool 胴1_表示
		{
			get
			{
				return this.X0Y0_胴1_胴.Dra;
			}
			set
			{
				this.X0Y0_胴1_胴.Dra = value;
				this.X0Y0_胴1_胴.Hit = value;
			}
		}

		public bool 胴1_柄_表示
		{
			get
			{
				return this.X0Y0_胴1_柄.Dra;
			}
			set
			{
				this.X0Y0_胴1_柄.Dra = value;
				this.X0Y0_胴1_柄.Hit = value;
			}
		}

		public bool 胴1_縦影_表示
		{
			get
			{
				return this.X0Y0_胴1_縦影.Dra;
			}
			set
			{
				this.X0Y0_胴1_縦影.Dra = value;
				this.X0Y0_胴1_縦影.Hit = value;
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
				return this.胴6_表示;
			}
			set
			{
				this.胴6_表示 = value;
				this.胴6_柄_表示 = value;
				this.胴6_縦影_表示 = value;
				this.胴5_表示 = value;
				this.胴5_柄_表示 = value;
				this.胴5_縦影_表示 = value;
				this.輪2_革_表示 = value;
				this.輪2_金具1_表示 = value;
				this.輪2_金具2_表示 = value;
				this.輪2_金具3_表示 = value;
				this.輪2_金具左_表示 = value;
				this.輪2_金具右_表示 = value;
				this.胴4_表示 = value;
				this.胴4_柄_表示 = value;
				this.胴4_縦影_表示 = value;
				this.胴3_表示 = value;
				this.胴3_柄_表示 = value;
				this.胴3_縦影_表示 = value;
				this.胴2_表示 = value;
				this.胴2_柄_表示 = value;
				this.胴2_縦影_表示 = value;
				this.胴1_表示 = value;
				this.胴1_柄_表示 = value;
				this.胴1_縦影_表示 = value;
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

		public override double 濃度
		{
			get
			{
				return this.胴6_胴CD.不透明度;
			}
			set
			{
				this.胴6_胴CD.不透明度 = value;
				this.胴6_柄CD.不透明度 = value;
				this.胴6_縦影CD.不透明度 = value;
				this.胴5_胴CD.不透明度 = value;
				this.胴5_柄CD.不透明度 = value;
				this.胴5_縦影CD.不透明度 = value;
				this.胴4_胴CD.不透明度 = value;
				this.胴4_柄CD.不透明度 = value;
				this.胴4_縦影CD.不透明度 = value;
				this.胴3_胴CD.不透明度 = value;
				this.胴3_柄CD.不透明度 = value;
				this.胴3_縦影CD.不透明度 = value;
				this.胴2_胴CD.不透明度 = value;
				this.胴2_柄CD.不透明度 = value;
				this.胴2_縦影CD.不透明度 = value;
				this.胴1_胴CD.不透明度 = value;
				this.胴1_柄CD.不透明度 = value;
				this.胴1_縦影CD.不透明度 = value;
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

		public override void 描画0(Are Are)
		{
			Are.Draw(this.X0Y0_胴6_胴);
			Are.Draw(this.X0Y0_胴6_柄);
			Are.Draw(this.X0Y0_胴6_縦影);
			Are.Draw(this.X0Y0_胴5_胴);
			Are.Draw(this.X0Y0_胴5_柄);
			Are.Draw(this.X0Y0_胴5_縦影);
			Are.Draw(this.X0Y0_胴4_胴);
			Are.Draw(this.X0Y0_胴4_柄);
			Are.Draw(this.X0Y0_胴4_縦影);
			Are.Draw(this.X0Y0_胴3_胴);
			Are.Draw(this.X0Y0_胴3_柄);
			Are.Draw(this.X0Y0_胴3_縦影);
			Are.Draw(this.X0Y0_胴2_胴);
			Are.Draw(this.X0Y0_胴2_柄);
			Are.Draw(this.X0Y0_胴2_縦影);
			Are.Draw(this.X0Y0_胴1_胴);
			Are.Draw(this.X0Y0_胴1_柄);
			Are.Draw(this.X0Y0_胴1_縦影);
			Are.Draw(this.X0Y0_輪1_革);
			Are.Draw(this.X0Y0_輪1_金具1);
			Are.Draw(this.X0Y0_輪1_金具2);
			Are.Draw(this.X0Y0_輪1_金具3);
			Are.Draw(this.X0Y0_輪1_金具左);
			Are.Draw(this.X0Y0_輪1_金具右);
			this.鎖1.描画0(Are);
			this.鎖2.描画0(Are);
		}

		public override void Dispose()
		{
			base.Dispose();
			this.鎖1.Dispose();
			this.鎖2.Dispose();
			this.鎖3.Dispose();
			this.鎖4.Dispose();
		}

		public override void Set角度0()
		{
			bool 右 = this.右;
			double maxAngle = 25.0;
			this.X0Y0_胴6_胴.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_胴5_胴.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_胴4_胴.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_胴3_胴.AngleBase = maxAngle.GetRanAngle();
			this.本体.JoinPAall();
		}

		public IEnumerable<Par> 軸列挙()
		{
			yield return this.X0Y0_胴3_胴;
			yield return this.X0Y0_胴4_胴;
			yield return this.X0Y0_胴5_胴;
			yield return this.X0Y0_胴6_胴;
			yield break;
		}

		public bool 柄
		{
			get
			{
				return this.胴6_柄_表示;
			}
			set
			{
				this.胴6_柄_表示 = value;
				this.胴5_柄_表示 = value;
				this.胴4_柄_表示 = value;
				this.胴3_柄_表示 = value;
				this.胴2_柄_表示 = value;
				this.胴1_柄_表示 = value;
			}
		}

		public bool 縦影
		{
			get
			{
				return this.胴6_縦影_表示;
			}
			set
			{
				this.胴6_縦影_表示 = value;
				this.胴5_縦影_表示 = value;
				this.胴4_縦影_表示 = value;
				this.胴3_縦影_表示 = value;
				this.胴2_縦影_表示 = value;
				this.胴1_縦影_表示 = value;
			}
		}

		public override double サイズY
		{
			get
			{
				return this.サイズY_;
			}
			set
			{
				this.サイズY_ = value;
			}
		}

		public override bool Is革(Par p)
		{
			return p == this.X0Y0_輪2_革 || p == this.X0Y0_輪2_金具1 || p == this.X0Y0_輪2_金具2 || p == this.X0Y0_輪2_金具3 || p == this.X0Y0_輪2_金具左 || p == this.X0Y0_輪2_金具右 || p == this.X0Y0_輪1_革 || p == this.X0Y0_輪1_金具1 || p == this.X0Y0_輪1_金具2 || p == this.X0Y0_輪1_金具3 || p == this.X0Y0_輪1_金具左 || p == this.X0Y0_輪1_金具右;
		}

		public JointS 左0_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴1_胴, 4);
			}
		}

		public JointS 右0_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴1_胴, 5);
			}
		}

		public JointS 左1_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴1_胴, 2);
			}
		}

		public JointS 右1_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴1_胴, 3);
			}
		}

		public JointS 左2_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴2_胴, 2);
			}
		}

		public JointS 右2_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴2_胴, 3);
			}
		}

		public JointS 左3_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴3_胴, 2);
			}
		}

		public JointS 右3_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴3_胴, 3);
			}
		}

		public JointS 左4_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴4_胴, 2);
			}
		}

		public JointS 右4_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴4_胴, 3);
			}
		}

		public JointS 左5_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴5_胴, 2);
			}
		}

		public JointS 右5_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴5_胴, 3);
			}
		}

		public JointS 左6_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴6_胴, 2);
			}
		}

		public JointS 右6_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴6_胴, 3);
			}
		}

		public JointS 尾_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴6_胴, 1);
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
			this.Pars.GetMiY_MaY(out this.mm);
			this.X0Y0_胴6_胴CP.Update(this.mm);
			this.X0Y0_胴6_柄CP.Update(this.mm);
			this.X0Y0_胴6_縦影CP.Update(this.mm);
			this.X0Y0_胴5_胴CP.Update(this.mm);
			this.X0Y0_胴5_柄CP.Update(this.mm);
			this.X0Y0_胴5_縦影CP.Update(this.mm);
			this.X0Y0_輪2_革CP.Update();
			this.X0Y0_輪2_金具1CP.Update();
			this.X0Y0_輪2_金具2CP.Update();
			this.X0Y0_輪2_金具3CP.Update();
			this.X0Y0_輪2_金具左CP.Update();
			this.X0Y0_輪2_金具右CP.Update();
			this.X0Y0_胴4_胴CP.Update(this.mm);
			this.X0Y0_胴4_柄CP.Update(this.mm);
			this.X0Y0_胴4_縦影CP.Update(this.mm);
			this.X0Y0_胴3_胴CP.Update(this.mm);
			this.X0Y0_胴3_柄CP.Update(this.mm);
			this.X0Y0_胴3_縦影CP.Update(this.mm);
			this.X0Y0_胴2_胴CP.Update(this.mm);
			this.X0Y0_胴2_柄CP.Update(this.mm);
			this.X0Y0_胴2_縦影CP.Update(this.mm);
			this.X0Y0_胴1_胴CP.Update(this.mm);
			this.X0Y0_胴1_柄CP.Update(this.mm);
			this.X0Y0_胴1_縦影CP.Update(this.mm);
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

		public override void 色更新(Vector2D[] mm)
		{
			this.X0Y0_胴6_胴CP.Update(mm);
			this.X0Y0_胴6_柄CP.Update(mm);
			this.X0Y0_胴6_縦影CP.Update(mm);
			this.X0Y0_胴5_胴CP.Update(mm);
			this.X0Y0_胴5_柄CP.Update(mm);
			this.X0Y0_胴5_縦影CP.Update(mm);
			this.X0Y0_輪2_革CP.Update();
			this.X0Y0_輪2_金具1CP.Update();
			this.X0Y0_輪2_金具2CP.Update();
			this.X0Y0_輪2_金具3CP.Update();
			this.X0Y0_輪2_金具左CP.Update();
			this.X0Y0_輪2_金具右CP.Update();
			this.X0Y0_胴4_胴CP.Update(mm);
			this.X0Y0_胴4_柄CP.Update(mm);
			this.X0Y0_胴4_縦影CP.Update(mm);
			this.X0Y0_胴3_胴CP.Update(mm);
			this.X0Y0_胴3_柄CP.Update(mm);
			this.X0Y0_胴3_縦影CP.Update(mm);
			this.X0Y0_胴2_胴CP.Update(mm);
			this.X0Y0_胴2_柄CP.Update(mm);
			this.X0Y0_胴2_縦影CP.Update(mm);
			this.X0Y0_胴1_胴CP.Update(mm);
			this.X0Y0_胴1_柄CP.Update(mm);
			this.X0Y0_胴1_縦影CP.Update(mm);
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
			this.胴6_胴CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.胴6_柄CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			Color2 color = new Color2(ref 体配色.体1O.Col2, ref Col.Empty);
			this.胴6_縦影CD = new ColorD(ref Col.Black, ref color);
			this.胴5_胴CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.胴5_柄CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴5_縦影CD = new ColorD(ref Col.Black, ref color);
			this.胴4_胴CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.胴4_柄CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴4_縦影CD = new ColorD(ref Col.Black, ref color);
			this.胴3_胴CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.胴3_柄CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴3_縦影CD = new ColorD(ref Col.Black, ref color);
			this.胴2_胴CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.胴2_柄CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴2_縦影CD = new ColorD(ref Col.Black, ref color);
			this.胴1_胴CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.胴1_柄CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴1_縦影CD = new ColorD(ref Col.Black, ref color);
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
			this.胴6_胴CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.胴6_柄CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴6_縦影CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴5_胴CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.胴5_柄CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴5_縦影CD = new ColorD(ref Col.Black, ref this.胴6_縦影CD.c2);
			this.胴4_胴CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.胴4_柄CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴4_縦影CD = new ColorD(ref Col.Black, ref this.胴6_縦影CD.c2);
			this.胴3_胴CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.胴3_柄CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴3_縦影CD = new ColorD(ref Col.Black, ref this.胴6_縦影CD.c2);
			this.胴2_胴CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.胴2_柄CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴2_縦影CD = new ColorD(ref Col.Black, ref this.胴6_縦影CD.c2);
			this.胴1_胴CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.胴1_柄CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴1_縦影CD = new ColorD(ref Col.Black, ref this.胴6_縦影CD.c2);
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
			this.胴6_胴CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.胴6_柄CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴6_縦影CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴5_胴CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.胴5_柄CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴5_縦影CD = new ColorD(ref Col.Black, ref this.胴6_縦影CD.c2);
			this.胴4_胴CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.胴4_柄CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴4_縦影CD = new ColorD(ref Col.Black, ref this.胴6_縦影CD.c2);
			this.胴3_胴CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.胴3_柄CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴3_縦影CD = new ColorD(ref Col.Black, ref this.胴6_縦影CD.c2);
			this.胴2_胴CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.胴2_柄CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴2_縦影CD = new ColorD(ref Col.Black, ref this.胴6_縦影CD.c2);
			this.胴1_胴CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.胴1_柄CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴1_縦影CD = new ColorD(ref Col.Black, ref this.胴6_縦影CD.c2);
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

		public Par X0Y0_胴6_胴;

		public Par X0Y0_胴6_柄;

		public Par X0Y0_胴6_縦影;

		public Par X0Y0_胴5_胴;

		public Par X0Y0_胴5_柄;

		public Par X0Y0_胴5_縦影;

		public Par X0Y0_輪2_革;

		public Par X0Y0_輪2_金具1;

		public Par X0Y0_輪2_金具2;

		public Par X0Y0_輪2_金具3;

		public Par X0Y0_輪2_金具左;

		public Par X0Y0_輪2_金具右;

		public Par X0Y0_胴4_胴;

		public Par X0Y0_胴4_柄;

		public Par X0Y0_胴4_縦影;

		public Par X0Y0_胴3_胴;

		public Par X0Y0_胴3_柄;

		public Par X0Y0_胴3_縦影;

		public Par X0Y0_胴2_胴;

		public Par X0Y0_胴2_柄;

		public Par X0Y0_胴2_縦影;

		public Par X0Y0_胴1_胴;

		public Par X0Y0_胴1_柄;

		public Par X0Y0_胴1_縦影;

		public Par X0Y0_輪1_革;

		public Par X0Y0_輪1_金具1;

		public Par X0Y0_輪1_金具2;

		public Par X0Y0_輪1_金具3;

		public Par X0Y0_輪1_金具左;

		public Par X0Y0_輪1_金具右;

		public ColorD 胴6_胴CD;

		public ColorD 胴6_柄CD;

		public ColorD 胴6_縦影CD;

		public ColorD 胴5_胴CD;

		public ColorD 胴5_柄CD;

		public ColorD 胴5_縦影CD;

		public ColorD 胴4_胴CD;

		public ColorD 胴4_柄CD;

		public ColorD 胴4_縦影CD;

		public ColorD 胴3_胴CD;

		public ColorD 胴3_柄CD;

		public ColorD 胴3_縦影CD;

		public ColorD 胴2_胴CD;

		public ColorD 胴2_柄CD;

		public ColorD 胴2_縦影CD;

		public ColorD 胴1_胴CD;

		public ColorD 胴1_柄CD;

		public ColorD 胴1_縦影CD;

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

		public ColorP X0Y0_胴6_胴CP;

		public ColorP X0Y0_胴6_柄CP;

		public ColorP X0Y0_胴6_縦影CP;

		public ColorP X0Y0_胴5_胴CP;

		public ColorP X0Y0_胴5_柄CP;

		public ColorP X0Y0_胴5_縦影CP;

		public ColorP X0Y0_輪2_革CP;

		public ColorP X0Y0_輪2_金具1CP;

		public ColorP X0Y0_輪2_金具2CP;

		public ColorP X0Y0_輪2_金具3CP;

		public ColorP X0Y0_輪2_金具左CP;

		public ColorP X0Y0_輪2_金具右CP;

		public ColorP X0Y0_胴4_胴CP;

		public ColorP X0Y0_胴4_柄CP;

		public ColorP X0Y0_胴4_縦影CP;

		public ColorP X0Y0_胴3_胴CP;

		public ColorP X0Y0_胴3_柄CP;

		public ColorP X0Y0_胴3_縦影CP;

		public ColorP X0Y0_胴2_胴CP;

		public ColorP X0Y0_胴2_柄CP;

		public ColorP X0Y0_胴2_縦影CP;

		public ColorP X0Y0_胴1_胴CP;

		public ColorP X0Y0_胴1_柄CP;

		public ColorP X0Y0_胴1_縦影CP;

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

		public Ele[] 左0_接続;

		public Ele[] 右0_接続;

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

		public Ele[] 左6_接続;

		public Ele[] 右6_接続;

		public Ele[] 尾_接続;

		private Par[] Pars;

		private Vector2D[] mm;
	}
}
