using System;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 頭 : Ele
	{
		public 頭(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 頭D e)
		{
			頭.<>c__DisplayClass120_0 CS$<>8__locals1 = new 頭.<>c__DisplayClass120_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.胴体["頭"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_頭 = pars["頭"].ToPar();
			Pars pars2 = pars["悪タトゥ"].ToPars();
			Pars pars3 = pars2["逆十字"].ToPars();
			this.X0Y0_悪タトゥ_逆十字_逆十字1 = pars3["逆十字1"].ToPar();
			this.X0Y0_悪タトゥ_逆十字_逆十字2 = pars3["逆十字2"].ToPar();
			pars2 = pars["隈取"].ToPars();
			this.X0Y0_隈取_タトゥ = pars2["タトゥ"].ToPar();
			this.X0Y0_隈取_タトゥ左 = pars2["タトゥ左"].ToPar();
			this.X0Y0_隈取_タトゥ右 = pars2["タトゥ右"].ToPar();
			pars2 = pars["秘石"].ToPars();
			this.X0Y0_秘石_基 = pars2["基"].ToPar();
			this.X0Y0_秘石_秘石 = pars2["秘石"].ToPar();
			this.X0Y0_秘石_ハイライト = pars2["ハイライト"].ToPar();
			pars2 = pars["蜘蛛"].ToPars();
			pars3 = pars2["眼左1"].ToPars();
			this.X0Y0_蜘蛛_眼左1_基 = pars3["基"].ToPar();
			this.X0Y0_蜘蛛_眼左1_眼 = pars3["眼"].ToPar();
			this.X0Y0_蜘蛛_眼左1_ハイライト = pars3["ハイライト"].ToPar();
			pars3 = pars2["眼左2"].ToPars();
			this.X0Y0_蜘蛛_眼左2_基 = pars3["基"].ToPar();
			this.X0Y0_蜘蛛_眼左2_眼 = pars3["眼"].ToPar();
			this.X0Y0_蜘蛛_眼左2_ハイライト = pars3["ハイライト"].ToPar();
			pars3 = pars2["眼右1"].ToPars();
			this.X0Y0_蜘蛛_眼右1_基 = pars3["基"].ToPar();
			this.X0Y0_蜘蛛_眼右1_眼 = pars3["眼"].ToPar();
			this.X0Y0_蜘蛛_眼右1_ハイライト = pars3["ハイライト"].ToPar();
			pars3 = pars2["眼右2"].ToPars();
			this.X0Y0_蜘蛛_眼右2_基 = pars3["基"].ToPar();
			this.X0Y0_蜘蛛_眼右2_眼 = pars3["眼"].ToPar();
			this.X0Y0_蜘蛛_眼右2_ハイライト = pars3["ハイライト"].ToPar();
			pars2 = pars["羽虫"].ToPars();
			pars3 = pars2["眼中"].ToPars();
			this.X0Y0_羽虫_眼中_基 = pars3["基"].ToPar();
			this.X0Y0_羽虫_眼中_眼 = pars3["眼"].ToPar();
			this.X0Y0_羽虫_眼中_ハイライト = pars3["ハイライト"].ToPar();
			pars3 = pars2["眼左"].ToPars();
			this.X0Y0_羽虫_眼左_基 = pars3["基"].ToPar();
			this.X0Y0_羽虫_眼左_眼 = pars3["眼"].ToPar();
			this.X0Y0_羽虫_眼左_ハイライト = pars3["ハイライト"].ToPar();
			pars3 = pars2["眼右"].ToPars();
			this.X0Y0_羽虫_眼右_基 = pars3["基"].ToPar();
			this.X0Y0_羽虫_眼右_眼 = pars3["眼"].ToPar();
			this.X0Y0_羽虫_眼右_ハイライト = pars3["ハイライト"].ToPar();
			pars2 = pars["紋柄"].ToPars();
			this.X0Y0_紋柄_紋 = pars2["紋"].ToPar();
			this.X0Y0_紋柄_紋左1 = pars2["紋左1"].ToPar();
			this.X0Y0_紋柄_紋右1 = pars2["紋右1"].ToPar();
			this.X0Y0_紋柄_紋左2 = pars2["紋左2"].ToPar();
			this.X0Y0_紋柄_紋右2 = pars2["紋右2"].ToPar();
			pars2 = pars["鱗"].ToPars();
			this.X0Y0_竜性_鱗1 = pars2["鱗1"].ToPar();
			this.X0Y0_竜性_鱗2 = pars2["鱗2"].ToPar();
			this.X0Y0_竜性_鱗3 = pars2["鱗3"].ToPar();
			pars2 = pars["牛柄"].ToPars();
			this.X0Y0_馬柄_馬柄 = pars2["牛柄"].ToPar();
			pars2 = pars["虫顎"].ToPars();
			this.X0Y0_虫性_顎下 = pars2["顎下"].ToPar();
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
			this.頭_表示 = e.頭_表示;
			this.悪タトゥ_逆十字_逆十字1_表示 = e.悪タトゥ_逆十字_逆十字1_表示;
			this.悪タトゥ_逆十字_逆十字2_表示 = e.悪タトゥ_逆十字_逆十字2_表示;
			this.隈取_タトゥ_表示 = e.隈取_タトゥ_表示;
			this.隈取_タトゥ左_表示 = e.隈取_タトゥ左_表示;
			this.隈取_タトゥ右_表示 = e.隈取_タトゥ右_表示;
			this.秘石_基_表示 = e.秘石_基_表示;
			this.秘石_秘石_表示 = e.秘石_秘石_表示;
			this.秘石_ハイライト_表示 = e.秘石_ハイライト_表示;
			this.蜘蛛_眼左1_基_表示 = e.蜘蛛_眼左1_基_表示;
			this.蜘蛛_眼左1_眼_表示 = e.蜘蛛_眼左1_眼_表示;
			this.蜘蛛_眼左1_ハイライト_表示 = e.蜘蛛_眼左1_ハイライト_表示;
			this.蜘蛛_眼左2_基_表示 = e.蜘蛛_眼左2_基_表示;
			this.蜘蛛_眼左2_眼_表示 = e.蜘蛛_眼左2_眼_表示;
			this.蜘蛛_眼左2_ハイライト_表示 = e.蜘蛛_眼左2_ハイライト_表示;
			this.蜘蛛_眼右1_基_表示 = e.蜘蛛_眼右1_基_表示;
			this.蜘蛛_眼右1_眼_表示 = e.蜘蛛_眼右1_眼_表示;
			this.蜘蛛_眼右1_ハイライト_表示 = e.蜘蛛_眼右1_ハイライト_表示;
			this.蜘蛛_眼右2_基_表示 = e.蜘蛛_眼右2_基_表示;
			this.蜘蛛_眼右2_眼_表示 = e.蜘蛛_眼右2_眼_表示;
			this.蜘蛛_眼右2_ハイライト_表示 = e.蜘蛛_眼右2_ハイライト_表示;
			this.羽虫_眼中_基_表示 = e.羽虫_眼中_基_表示;
			this.羽虫_眼中_眼_表示 = e.羽虫_眼中_眼_表示;
			this.羽虫_眼中_ハイライト_表示 = e.羽虫_眼中_ハイライト_表示;
			this.羽虫_眼左_基_表示 = e.羽虫_眼左_基_表示;
			this.羽虫_眼左_眼_表示 = e.羽虫_眼左_眼_表示;
			this.羽虫_眼左_ハイライト_表示 = e.羽虫_眼左_ハイライト_表示;
			this.羽虫_眼右_基_表示 = e.羽虫_眼右_基_表示;
			this.羽虫_眼右_眼_表示 = e.羽虫_眼右_眼_表示;
			this.羽虫_眼右_ハイライト_表示 = e.羽虫_眼右_ハイライト_表示;
			this.紋柄_紋_表示 = e.紋柄_紋_表示;
			this.紋柄_紋左1_表示 = e.紋柄_紋左1_表示;
			this.紋柄_紋右1_表示 = e.紋柄_紋右1_表示;
			this.紋柄_紋左2_表示 = e.紋柄_紋左2_表示;
			this.紋柄_紋右2_表示 = e.紋柄_紋右2_表示;
			this.竜性_鱗1_表示 = e.竜性_鱗1_表示;
			this.竜性_鱗2_表示 = e.竜性_鱗2_表示;
			this.竜性_鱗3_表示 = e.竜性_鱗3_表示;
			this.馬柄_馬柄_表示 = e.馬柄_馬柄_表示;
			this.虫性_顎下_表示 = e.虫性_顎下_表示;
			this.目高 = e.目高;
			this.目間 = e.目間;
			this.眉間 = e.眉間;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.基髪_接続.Count > 0)
			{
				Ele f;
				this.基髪_接続 = e.基髪_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.頭_基髪_接続;
					f.接続(CS$<>8__locals1.<>4__this.基髪_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.目左_接続.Count > 0)
			{
				Ele f;
				this.目左_接続 = e.目左_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.頭_目左_接続;
					f.接続(CS$<>8__locals1.<>4__this.目左_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.目右_接続.Count > 0)
			{
				Ele f;
				this.目右_接続 = e.目右_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.頭_目右_接続;
					f.接続(CS$<>8__locals1.<>4__this.目右_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.鼻_接続.Count > 0)
			{
				Ele f;
				this.鼻_接続 = e.鼻_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.頭_鼻_接続;
					f.接続(CS$<>8__locals1.<>4__this.鼻_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.口_接続.Count > 0)
			{
				Ele f;
				this.口_接続 = e.口_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.頭_口_接続;
					f.接続(CS$<>8__locals1.<>4__this.口_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.頬左_接続.Count > 0)
			{
				Ele f;
				this.頬左_接続 = e.頬左_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.頭_頬左_接続;
					f.接続(CS$<>8__locals1.<>4__this.頬左_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.頬右_接続.Count > 0)
			{
				Ele f;
				this.頬右_接続 = e.頬右_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.頭_頬右_接続;
					f.接続(CS$<>8__locals1.<>4__this.頬右_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.額_接続.Count > 0)
			{
				Ele f;
				this.額_接続 = e.額_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.頭_額_接続;
					f.接続(CS$<>8__locals1.<>4__this.額_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.眉左_接続.Count > 0)
			{
				Ele f;
				this.眉左_接続 = e.眉左_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.頭_眉左_接続;
					f.接続(CS$<>8__locals1.<>4__this.眉左_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.眉右_接続.Count > 0)
			{
				Ele f;
				this.眉右_接続 = e.眉右_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.頭_眉右_接続;
					f.接続(CS$<>8__locals1.<>4__this.眉右_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.耳左_接続.Count > 0)
			{
				Ele f;
				this.耳左_接続 = e.耳左_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.頭_耳左_接続;
					f.接続(CS$<>8__locals1.<>4__this.耳左_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.耳右_接続.Count > 0)
			{
				Ele f;
				this.耳右_接続 = e.耳右_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.頭_耳右_接続;
					f.接続(CS$<>8__locals1.<>4__this.耳右_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.鼻肌_接続.Count > 0)
			{
				Ele f;
				this.鼻肌_接続 = e.鼻肌_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.頭_鼻肌_接続;
					f.接続(CS$<>8__locals1.<>4__this.鼻肌_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.単眼目_接続.Count > 0)
			{
				Ele f;
				this.単眼目_接続 = e.単眼目_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.頭_単眼目_接続;
					f.接続(CS$<>8__locals1.<>4__this.単眼目_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.単眼眉_接続.Count > 0)
			{
				Ele f;
				this.単眼眉_接続 = e.単眼眉_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.頭_単眼眉_接続;
					f.接続(CS$<>8__locals1.<>4__this.単眼眉_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.大顎基_接続.Count > 0)
			{
				Ele f;
				this.大顎基_接続 = e.大顎基_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.頭_大顎基_接続;
					f.接続(CS$<>8__locals1.<>4__this.大顎基_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.顔面_接続.Count > 0)
			{
				Ele f;
				this.顔面_接続 = e.顔面_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.頭_顔面_接続;
					f.接続(CS$<>8__locals1.<>4__this.顔面_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.頭頂_接続.Count > 0)
			{
				Ele f;
				this.頭頂_接続 = e.頭頂_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.頭_頭頂_接続;
					f.接続(CS$<>8__locals1.<>4__this.頭頂_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.頬肌左_接続.Count > 0)
			{
				Ele f;
				this.頬肌左_接続 = e.頬肌左_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.頭_頬肌左_接続;
					f.接続(CS$<>8__locals1.<>4__this.頬肌左_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.頬肌右_接続.Count > 0)
			{
				Ele f;
				this.頬肌右_接続 = e.頬肌右_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.頭_頬肌右_接続;
					f.接続(CS$<>8__locals1.<>4__this.頬肌右_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.触覚左_接続.Count > 0)
			{
				Ele f;
				this.触覚左_接続 = e.触覚左_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.頭_触覚左_接続;
					f.接続(CS$<>8__locals1.<>4__this.触覚左_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.触覚右_接続.Count > 0)
			{
				Ele f;
				this.触覚右_接続 = e.触覚右_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.頭_触覚右_接続;
					f.接続(CS$<>8__locals1.<>4__this.触覚右_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_頭CP = new ColorP(this.X0Y0_頭, this.頭CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_逆十字_逆十字1CP = new ColorP(this.X0Y0_悪タトゥ_逆十字_逆十字1, this.悪タトゥ_逆十字_逆十字1CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_悪タトゥ_逆十字_逆十字2CP = new ColorP(this.X0Y0_悪タトゥ_逆十字_逆十字2, this.悪タトゥ_逆十字_逆十字2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_隈取_タトゥCP = new ColorP(this.X0Y0_隈取_タトゥ, this.隈取_タトゥCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_隈取_タトゥ左CP = new ColorP(this.X0Y0_隈取_タトゥ左, this.隈取_タトゥ左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_隈取_タトゥ右CP = new ColorP(this.X0Y0_隈取_タトゥ右, this.隈取_タトゥ右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_秘石_基CP = new ColorP(this.X0Y0_秘石_基, this.秘石_基CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_秘石_秘石CP = new ColorP(this.X0Y0_秘石_秘石, this.秘石_秘石CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_秘石_ハイライトCP = new ColorP(this.X0Y0_秘石_ハイライト, this.秘石_ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_蜘蛛_眼左1_基CP = new ColorP(this.X0Y0_蜘蛛_眼左1_基, this.蜘蛛_眼左1_基CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_蜘蛛_眼左1_眼CP = new ColorP(this.X0Y0_蜘蛛_眼左1_眼, this.蜘蛛_眼左1_眼CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_蜘蛛_眼左1_ハイライトCP = new ColorP(this.X0Y0_蜘蛛_眼左1_ハイライト, this.蜘蛛_眼左1_ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_蜘蛛_眼左2_基CP = new ColorP(this.X0Y0_蜘蛛_眼左2_基, this.蜘蛛_眼左2_基CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_蜘蛛_眼左2_眼CP = new ColorP(this.X0Y0_蜘蛛_眼左2_眼, this.蜘蛛_眼左2_眼CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_蜘蛛_眼左2_ハイライトCP = new ColorP(this.X0Y0_蜘蛛_眼左2_ハイライト, this.蜘蛛_眼左2_ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_蜘蛛_眼右1_基CP = new ColorP(this.X0Y0_蜘蛛_眼右1_基, this.蜘蛛_眼右1_基CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_蜘蛛_眼右1_眼CP = new ColorP(this.X0Y0_蜘蛛_眼右1_眼, this.蜘蛛_眼右1_眼CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_蜘蛛_眼右1_ハイライトCP = new ColorP(this.X0Y0_蜘蛛_眼右1_ハイライト, this.蜘蛛_眼右1_ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_蜘蛛_眼右2_基CP = new ColorP(this.X0Y0_蜘蛛_眼右2_基, this.蜘蛛_眼右2_基CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_蜘蛛_眼右2_眼CP = new ColorP(this.X0Y0_蜘蛛_眼右2_眼, this.蜘蛛_眼右2_眼CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_蜘蛛_眼右2_ハイライトCP = new ColorP(this.X0Y0_蜘蛛_眼右2_ハイライト, this.蜘蛛_眼右2_ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_羽虫_眼中_基CP = new ColorP(this.X0Y0_羽虫_眼中_基, this.羽虫_眼中_基CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_羽虫_眼中_眼CP = new ColorP(this.X0Y0_羽虫_眼中_眼, this.羽虫_眼中_眼CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_羽虫_眼中_ハイライトCP = new ColorP(this.X0Y0_羽虫_眼中_ハイライト, this.羽虫_眼中_ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_羽虫_眼左_基CP = new ColorP(this.X0Y0_羽虫_眼左_基, this.羽虫_眼左_基CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_羽虫_眼左_眼CP = new ColorP(this.X0Y0_羽虫_眼左_眼, this.羽虫_眼左_眼CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_羽虫_眼左_ハイライトCP = new ColorP(this.X0Y0_羽虫_眼左_ハイライト, this.羽虫_眼左_ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_羽虫_眼右_基CP = new ColorP(this.X0Y0_羽虫_眼右_基, this.羽虫_眼右_基CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_羽虫_眼右_眼CP = new ColorP(this.X0Y0_羽虫_眼右_眼, this.羽虫_眼右_眼CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_羽虫_眼右_ハイライトCP = new ColorP(this.X0Y0_羽虫_眼右_ハイライト, this.羽虫_眼右_ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_紋柄_紋CP = new ColorP(this.X0Y0_紋柄_紋, this.紋柄_紋CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_紋柄_紋左1CP = new ColorP(this.X0Y0_紋柄_紋左1, this.紋柄_紋左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_紋柄_紋右1CP = new ColorP(this.X0Y0_紋柄_紋右1, this.紋柄_紋右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_紋柄_紋左2CP = new ColorP(this.X0Y0_紋柄_紋左2, this.紋柄_紋左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_紋柄_紋右2CP = new ColorP(this.X0Y0_紋柄_紋右2, this.紋柄_紋右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_鱗1CP = new ColorP(this.X0Y0_竜性_鱗1, this.竜性_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_鱗2CP = new ColorP(this.X0Y0_竜性_鱗2, this.竜性_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_鱗3CP = new ColorP(this.X0Y0_竜性_鱗3, this.竜性_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_馬柄_馬柄CP = new ColorP(this.X0Y0_馬柄_馬柄, this.馬柄_馬柄CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫性_顎下CP = new ColorP(this.X0Y0_虫性_顎下, this.虫性_顎下CD, CS$<>8__locals1.DisUnit, true);
			this.濃度 = e.濃度;
			this.X0Y0_頭.JP[8].Joint = this.X0Y0_頭.JP[8].Joint.AddX(-0.00012);
			this.X0Y0_頭.JP[9].Joint = this.X0Y0_頭.JP[9].Joint.AddX(0.00012);
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

		public bool 頭_表示
		{
			get
			{
				return this.X0Y0_頭.Dra;
			}
			set
			{
				this.X0Y0_頭.Dra = value;
				this.X0Y0_頭.Hit = value;
			}
		}

		public bool 悪タトゥ_逆十字_逆十字1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_逆十字_逆十字1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_逆十字_逆十字1.Dra = value;
				this.X0Y0_悪タトゥ_逆十字_逆十字1.Hit = value;
			}
		}

		public bool 悪タトゥ_逆十字_逆十字2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_逆十字_逆十字2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_逆十字_逆十字2.Dra = value;
				this.X0Y0_悪タトゥ_逆十字_逆十字2.Hit = value;
			}
		}

		public bool 隈取_タトゥ_表示
		{
			get
			{
				return this.X0Y0_隈取_タトゥ.Dra;
			}
			set
			{
				this.X0Y0_隈取_タトゥ.Dra = value;
				this.X0Y0_隈取_タトゥ.Hit = value;
			}
		}

		public bool 隈取_タトゥ左_表示
		{
			get
			{
				return this.X0Y0_隈取_タトゥ左.Dra;
			}
			set
			{
				this.X0Y0_隈取_タトゥ左.Dra = value;
				this.X0Y0_隈取_タトゥ左.Hit = value;
			}
		}

		public bool 隈取_タトゥ右_表示
		{
			get
			{
				return this.X0Y0_隈取_タトゥ右.Dra;
			}
			set
			{
				this.X0Y0_隈取_タトゥ右.Dra = value;
				this.X0Y0_隈取_タトゥ右.Hit = value;
			}
		}

		public bool 秘石_基_表示
		{
			get
			{
				return this.X0Y0_秘石_基.Dra;
			}
			set
			{
				this.X0Y0_秘石_基.Dra = value;
				this.X0Y0_秘石_基.Hit = value;
			}
		}

		public bool 秘石_秘石_表示
		{
			get
			{
				return this.X0Y0_秘石_秘石.Dra;
			}
			set
			{
				this.X0Y0_秘石_秘石.Dra = value;
				this.X0Y0_秘石_秘石.Hit = value;
			}
		}

		public bool 秘石_ハイライト_表示
		{
			get
			{
				return this.X0Y0_秘石_ハイライト.Dra;
			}
			set
			{
				this.X0Y0_秘石_ハイライト.Dra = value;
				this.X0Y0_秘石_ハイライト.Hit = value;
			}
		}

		public bool 蜘蛛_眼左1_基_表示
		{
			get
			{
				return this.X0Y0_蜘蛛_眼左1_基.Dra;
			}
			set
			{
				this.X0Y0_蜘蛛_眼左1_基.Dra = value;
				this.X0Y0_蜘蛛_眼左1_基.Hit = value;
			}
		}

		public bool 蜘蛛_眼左1_眼_表示
		{
			get
			{
				return this.X0Y0_蜘蛛_眼左1_眼.Dra;
			}
			set
			{
				this.X0Y0_蜘蛛_眼左1_眼.Dra = value;
				this.X0Y0_蜘蛛_眼左1_眼.Hit = value;
			}
		}

		public bool 蜘蛛_眼左1_ハイライト_表示
		{
			get
			{
				return this.X0Y0_蜘蛛_眼左1_ハイライト.Dra;
			}
			set
			{
				this.X0Y0_蜘蛛_眼左1_ハイライト.Dra = value;
				this.X0Y0_蜘蛛_眼左1_ハイライト.Hit = value;
			}
		}

		public bool 蜘蛛_眼左2_基_表示
		{
			get
			{
				return this.X0Y0_蜘蛛_眼左2_基.Dra;
			}
			set
			{
				this.X0Y0_蜘蛛_眼左2_基.Dra = value;
				this.X0Y0_蜘蛛_眼左2_基.Hit = value;
			}
		}

		public bool 蜘蛛_眼左2_眼_表示
		{
			get
			{
				return this.X0Y0_蜘蛛_眼左2_眼.Dra;
			}
			set
			{
				this.X0Y0_蜘蛛_眼左2_眼.Dra = value;
				this.X0Y0_蜘蛛_眼左2_眼.Hit = value;
			}
		}

		public bool 蜘蛛_眼左2_ハイライト_表示
		{
			get
			{
				return this.X0Y0_蜘蛛_眼左2_ハイライト.Dra;
			}
			set
			{
				this.X0Y0_蜘蛛_眼左2_ハイライト.Dra = value;
				this.X0Y0_蜘蛛_眼左2_ハイライト.Hit = value;
			}
		}

		public bool 蜘蛛_眼右1_基_表示
		{
			get
			{
				return this.X0Y0_蜘蛛_眼右1_基.Dra;
			}
			set
			{
				this.X0Y0_蜘蛛_眼右1_基.Dra = value;
				this.X0Y0_蜘蛛_眼右1_基.Hit = value;
			}
		}

		public bool 蜘蛛_眼右1_眼_表示
		{
			get
			{
				return this.X0Y0_蜘蛛_眼右1_眼.Dra;
			}
			set
			{
				this.X0Y0_蜘蛛_眼右1_眼.Dra = value;
				this.X0Y0_蜘蛛_眼右1_眼.Hit = value;
			}
		}

		public bool 蜘蛛_眼右1_ハイライト_表示
		{
			get
			{
				return this.X0Y0_蜘蛛_眼右1_ハイライト.Dra;
			}
			set
			{
				this.X0Y0_蜘蛛_眼右1_ハイライト.Dra = value;
				this.X0Y0_蜘蛛_眼右1_ハイライト.Hit = value;
			}
		}

		public bool 蜘蛛_眼右2_基_表示
		{
			get
			{
				return this.X0Y0_蜘蛛_眼右2_基.Dra;
			}
			set
			{
				this.X0Y0_蜘蛛_眼右2_基.Dra = value;
				this.X0Y0_蜘蛛_眼右2_基.Hit = value;
			}
		}

		public bool 蜘蛛_眼右2_眼_表示
		{
			get
			{
				return this.X0Y0_蜘蛛_眼右2_眼.Dra;
			}
			set
			{
				this.X0Y0_蜘蛛_眼右2_眼.Dra = value;
				this.X0Y0_蜘蛛_眼右2_眼.Hit = value;
			}
		}

		public bool 蜘蛛_眼右2_ハイライト_表示
		{
			get
			{
				return this.X0Y0_蜘蛛_眼右2_ハイライト.Dra;
			}
			set
			{
				this.X0Y0_蜘蛛_眼右2_ハイライト.Dra = value;
				this.X0Y0_蜘蛛_眼右2_ハイライト.Hit = value;
			}
		}

		public bool 羽虫_眼中_基_表示
		{
			get
			{
				return this.X0Y0_羽虫_眼中_基.Dra;
			}
			set
			{
				this.X0Y0_羽虫_眼中_基.Dra = value;
				this.X0Y0_羽虫_眼中_基.Hit = value;
			}
		}

		public bool 羽虫_眼中_眼_表示
		{
			get
			{
				return this.X0Y0_羽虫_眼中_眼.Dra;
			}
			set
			{
				this.X0Y0_羽虫_眼中_眼.Dra = value;
				this.X0Y0_羽虫_眼中_眼.Hit = value;
			}
		}

		public bool 羽虫_眼中_ハイライト_表示
		{
			get
			{
				return this.X0Y0_羽虫_眼中_ハイライト.Dra;
			}
			set
			{
				this.X0Y0_羽虫_眼中_ハイライト.Dra = value;
				this.X0Y0_羽虫_眼中_ハイライト.Hit = value;
			}
		}

		public bool 羽虫_眼左_基_表示
		{
			get
			{
				return this.X0Y0_羽虫_眼左_基.Dra;
			}
			set
			{
				this.X0Y0_羽虫_眼左_基.Dra = value;
				this.X0Y0_羽虫_眼左_基.Hit = value;
			}
		}

		public bool 羽虫_眼左_眼_表示
		{
			get
			{
				return this.X0Y0_羽虫_眼左_眼.Dra;
			}
			set
			{
				this.X0Y0_羽虫_眼左_眼.Dra = value;
				this.X0Y0_羽虫_眼左_眼.Hit = value;
			}
		}

		public bool 羽虫_眼左_ハイライト_表示
		{
			get
			{
				return this.X0Y0_羽虫_眼左_ハイライト.Dra;
			}
			set
			{
				this.X0Y0_羽虫_眼左_ハイライト.Dra = value;
				this.X0Y0_羽虫_眼左_ハイライト.Hit = value;
			}
		}

		public bool 羽虫_眼右_基_表示
		{
			get
			{
				return this.X0Y0_羽虫_眼右_基.Dra;
			}
			set
			{
				this.X0Y0_羽虫_眼右_基.Dra = value;
				this.X0Y0_羽虫_眼右_基.Hit = value;
			}
		}

		public bool 羽虫_眼右_眼_表示
		{
			get
			{
				return this.X0Y0_羽虫_眼右_眼.Dra;
			}
			set
			{
				this.X0Y0_羽虫_眼右_眼.Dra = value;
				this.X0Y0_羽虫_眼右_眼.Hit = value;
			}
		}

		public bool 羽虫_眼右_ハイライト_表示
		{
			get
			{
				return this.X0Y0_羽虫_眼右_ハイライト.Dra;
			}
			set
			{
				this.X0Y0_羽虫_眼右_ハイライト.Dra = value;
				this.X0Y0_羽虫_眼右_ハイライト.Hit = value;
			}
		}

		public bool 紋柄_紋_表示
		{
			get
			{
				return this.X0Y0_紋柄_紋.Dra;
			}
			set
			{
				this.X0Y0_紋柄_紋.Dra = value;
				this.X0Y0_紋柄_紋.Hit = value;
			}
		}

		public bool 紋柄_紋左1_表示
		{
			get
			{
				return this.X0Y0_紋柄_紋左1.Dra;
			}
			set
			{
				this.X0Y0_紋柄_紋左1.Dra = value;
				this.X0Y0_紋柄_紋左1.Hit = value;
			}
		}

		public bool 紋柄_紋右1_表示
		{
			get
			{
				return this.X0Y0_紋柄_紋右1.Dra;
			}
			set
			{
				this.X0Y0_紋柄_紋右1.Dra = value;
				this.X0Y0_紋柄_紋右1.Hit = value;
			}
		}

		public bool 紋柄_紋左2_表示
		{
			get
			{
				return this.X0Y0_紋柄_紋左2.Dra;
			}
			set
			{
				this.X0Y0_紋柄_紋左2.Dra = value;
				this.X0Y0_紋柄_紋左2.Hit = value;
			}
		}

		public bool 紋柄_紋右2_表示
		{
			get
			{
				return this.X0Y0_紋柄_紋右2.Dra;
			}
			set
			{
				this.X0Y0_紋柄_紋右2.Dra = value;
				this.X0Y0_紋柄_紋右2.Hit = value;
			}
		}

		public bool 竜性_鱗1_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗1.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗1.Dra = value;
				this.X0Y0_竜性_鱗1.Hit = value;
			}
		}

		public bool 竜性_鱗2_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗2.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗2.Dra = value;
				this.X0Y0_竜性_鱗2.Hit = value;
			}
		}

		public bool 竜性_鱗3_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗3.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗3.Dra = value;
				this.X0Y0_竜性_鱗3.Hit = value;
			}
		}

		public bool 馬柄_馬柄_表示
		{
			get
			{
				return this.X0Y0_馬柄_馬柄.Dra;
			}
			set
			{
				this.X0Y0_馬柄_馬柄.Dra = value;
				this.X0Y0_馬柄_馬柄.Hit = value;
			}
		}

		public bool 虫性_顎下_表示
		{
			get
			{
				return this.X0Y0_虫性_顎下.Dra;
			}
			set
			{
				this.X0Y0_虫性_顎下.Dra = value;
				this.X0Y0_虫性_顎下.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.頭_表示;
			}
			set
			{
				this.頭_表示 = value;
				this.悪タトゥ_逆十字_逆十字1_表示 = value;
				this.悪タトゥ_逆十字_逆十字2_表示 = value;
				this.隈取_タトゥ_表示 = value;
				this.隈取_タトゥ左_表示 = value;
				this.隈取_タトゥ右_表示 = value;
				this.秘石_基_表示 = value;
				this.秘石_秘石_表示 = value;
				this.秘石_ハイライト_表示 = value;
				this.蜘蛛_眼左1_基_表示 = value;
				this.蜘蛛_眼左1_眼_表示 = value;
				this.蜘蛛_眼左1_ハイライト_表示 = value;
				this.蜘蛛_眼左2_基_表示 = value;
				this.蜘蛛_眼左2_眼_表示 = value;
				this.蜘蛛_眼左2_ハイライト_表示 = value;
				this.蜘蛛_眼右1_基_表示 = value;
				this.蜘蛛_眼右1_眼_表示 = value;
				this.蜘蛛_眼右1_ハイライト_表示 = value;
				this.蜘蛛_眼右2_基_表示 = value;
				this.蜘蛛_眼右2_眼_表示 = value;
				this.蜘蛛_眼右2_ハイライト_表示 = value;
				this.羽虫_眼中_基_表示 = value;
				this.羽虫_眼中_眼_表示 = value;
				this.羽虫_眼中_ハイライト_表示 = value;
				this.羽虫_眼左_基_表示 = value;
				this.羽虫_眼左_眼_表示 = value;
				this.羽虫_眼左_ハイライト_表示 = value;
				this.羽虫_眼右_基_表示 = value;
				this.羽虫_眼右_眼_表示 = value;
				this.羽虫_眼右_ハイライト_表示 = value;
				this.紋柄_紋_表示 = value;
				this.紋柄_紋左1_表示 = value;
				this.紋柄_紋右1_表示 = value;
				this.紋柄_紋左2_表示 = value;
				this.紋柄_紋右2_表示 = value;
				this.竜性_鱗1_表示 = value;
				this.竜性_鱗2_表示 = value;
				this.竜性_鱗3_表示 = value;
				this.馬柄_馬柄_表示 = value;
				this.虫性_顎下_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.頭CD.不透明度;
			}
			set
			{
				this.頭CD.不透明度 = value;
				this.悪タトゥ_逆十字_逆十字1CD.不透明度 = value;
				this.悪タトゥ_逆十字_逆十字2CD.不透明度 = value;
				this.隈取_タトゥCD.不透明度 = value;
				this.隈取_タトゥ左CD.不透明度 = value;
				this.隈取_タトゥ右CD.不透明度 = value;
				this.秘石_基CD.不透明度 = value;
				this.秘石_秘石CD.不透明度 = value;
				this.秘石_ハイライトCD.不透明度 = value;
				this.蜘蛛_眼左1_基CD.不透明度 = value;
				this.蜘蛛_眼左1_眼CD.不透明度 = value;
				this.蜘蛛_眼左1_ハイライトCD.不透明度 = value;
				this.蜘蛛_眼左2_基CD.不透明度 = value;
				this.蜘蛛_眼左2_眼CD.不透明度 = value;
				this.蜘蛛_眼左2_ハイライトCD.不透明度 = value;
				this.蜘蛛_眼右1_基CD.不透明度 = value;
				this.蜘蛛_眼右1_眼CD.不透明度 = value;
				this.蜘蛛_眼右1_ハイライトCD.不透明度 = value;
				this.蜘蛛_眼右2_基CD.不透明度 = value;
				this.蜘蛛_眼右2_眼CD.不透明度 = value;
				this.蜘蛛_眼右2_ハイライトCD.不透明度 = value;
				this.羽虫_眼中_基CD.不透明度 = value;
				this.羽虫_眼中_眼CD.不透明度 = value;
				this.羽虫_眼中_ハイライトCD.不透明度 = value;
				this.羽虫_眼左_基CD.不透明度 = value;
				this.羽虫_眼左_眼CD.不透明度 = value;
				this.羽虫_眼左_ハイライトCD.不透明度 = value;
				this.羽虫_眼右_基CD.不透明度 = value;
				this.羽虫_眼右_眼CD.不透明度 = value;
				this.羽虫_眼右_ハイライトCD.不透明度 = value;
				this.紋柄_紋CD.不透明度 = value;
				this.紋柄_紋左1CD.不透明度 = value;
				this.紋柄_紋右1CD.不透明度 = value;
				this.紋柄_紋左2CD.不透明度 = value;
				this.紋柄_紋右2CD.不透明度 = value;
				this.竜性_鱗1CD.不透明度 = value;
				this.竜性_鱗2CD.不透明度 = value;
				this.竜性_鱗3CD.不透明度 = value;
				this.馬柄_馬柄CD.不透明度 = value;
				this.虫性_顎下CD.不透明度 = value;
			}
		}

		public override void 描画0(Are Are)
		{
			Are.Draw(this.X0Y0_頭);
		}

		public override void 描画1(Are Are)
		{
			Are.Draw(this.X0Y0_悪タトゥ_逆十字_逆十字1);
			Are.Draw(this.X0Y0_悪タトゥ_逆十字_逆十字2);
			Are.Draw(this.X0Y0_隈取_タトゥ);
			Are.Draw(this.X0Y0_隈取_タトゥ左);
			Are.Draw(this.X0Y0_隈取_タトゥ右);
			Are.Draw(this.X0Y0_馬柄_馬柄);
			Are.Draw(this.X0Y0_紋柄_紋);
			Are.Draw(this.X0Y0_紋柄_紋左1);
			Are.Draw(this.X0Y0_紋柄_紋右1);
			Are.Draw(this.X0Y0_紋柄_紋左2);
			Are.Draw(this.X0Y0_紋柄_紋右2);
			Are.Draw(this.X0Y0_竜性_鱗1);
			Are.Draw(this.X0Y0_竜性_鱗2);
			Are.Draw(this.X0Y0_竜性_鱗3);
			Are.Draw(this.X0Y0_秘石_基);
			Are.Draw(this.X0Y0_秘石_秘石);
			Are.Draw(this.X0Y0_秘石_ハイライト);
			Are.Draw(this.X0Y0_蜘蛛_眼左1_基);
			Are.Draw(this.X0Y0_蜘蛛_眼左1_眼);
			Are.Draw(this.X0Y0_蜘蛛_眼左1_ハイライト);
			Are.Draw(this.X0Y0_蜘蛛_眼左2_基);
			Are.Draw(this.X0Y0_蜘蛛_眼左2_眼);
			Are.Draw(this.X0Y0_蜘蛛_眼左2_ハイライト);
			Are.Draw(this.X0Y0_蜘蛛_眼右1_基);
			Are.Draw(this.X0Y0_蜘蛛_眼右1_眼);
			Are.Draw(this.X0Y0_蜘蛛_眼右1_ハイライト);
			Are.Draw(this.X0Y0_蜘蛛_眼右2_基);
			Are.Draw(this.X0Y0_蜘蛛_眼右2_眼);
			Are.Draw(this.X0Y0_蜘蛛_眼右2_ハイライト);
			Are.Draw(this.X0Y0_羽虫_眼中_基);
			Are.Draw(this.X0Y0_羽虫_眼中_眼);
			Are.Draw(this.X0Y0_羽虫_眼中_ハイライト);
			Are.Draw(this.X0Y0_羽虫_眼左_基);
			Are.Draw(this.X0Y0_羽虫_眼左_眼);
			Are.Draw(this.X0Y0_羽虫_眼左_ハイライト);
			Are.Draw(this.X0Y0_羽虫_眼右_基);
			Are.Draw(this.X0Y0_羽虫_眼右_眼);
			Are.Draw(this.X0Y0_羽虫_眼右_ハイライト);
		}

		public override void 描画2(Are Are)
		{
			Are.Draw(this.X0Y0_虫性_顎下);
		}

		private void 開顎(double Rate)
		{
			double y = 0.0003 * Rate;
			Par par = Sta.胴体["頭"][0][0]["頭"].ToPar();
			Par x0Y0_頭 = this.X0Y0_頭;
			x0Y0_頭.OP[0].ps[3] = par.OP[0].ps[3].AddY(y);
			x0Y0_頭.OP[0].ps[4] = par.OP[0].ps[4].AddY(y);
			x0Y0_頭.OP[1].ps[0] = par.OP[1].ps[0].AddY(y);
			x0Y0_頭.OP[1].ps[1] = par.OP[1].ps[1].AddY(y);
			x0Y0_頭.OP[1].ps[2] = par.OP[1].ps[2].AddY(y);
			x0Y0_頭.OP[1].ps[3] = par.OP[1].ps[3].AddY(y);
			x0Y0_頭.OP[2].ps[0] = par.OP[2].ps[0].AddY(y);
			x0Y0_頭.OP[2].ps[1] = par.OP[2].ps[1].AddY(y);
		}

		public void 開顎(口 口)
		{
			if (口.Yi == 0)
			{
				this.開顎(0.5);
				return;
			}
			if (口.Yi == 1)
			{
				this.開顎(0.8);
				return;
			}
			if (口.Yi == 2)
			{
				this.開顎(0.0);
				return;
			}
			if (口.Yi == 3)
			{
				this.開顎(0.0);
				return;
			}
			if (口.Yi == 4)
			{
				this.開顎(0.0);
				return;
			}
			if (口.Yi == 5)
			{
				this.開顎(0.5);
				return;
			}
			if (口.Yi == 6)
			{
				this.開顎(0.5);
				return;
			}
			if (口.Yi == 7)
			{
				this.開顎(0.0);
				return;
			}
			if (口.Yi == 8)
			{
				this.開顎(0.0);
				return;
			}
			if (口.Yi == 9)
			{
				this.開顎(0.8);
				return;
			}
			if (口.Yi == 10)
			{
				this.開顎(0.0);
				return;
			}
			if (口.Yi == 11)
			{
				this.開顎(0.0);
				return;
			}
			if (口.Yi == 12)
			{
				this.開顎(1.0);
				return;
			}
			if (口.Yi == 13)
			{
				this.開顎(1.0);
			}
		}

		public double 目高
		{
			set
			{
				double y = 0.9975 + 0.004 * value.Inverse();
				this.X0Y0_頭.JP[0].Joint = this.X0Y0_頭.JP[0].Joint.MulY(y);
				this.X0Y0_頭.JP[1].Joint = this.X0Y0_頭.JP[1].Joint.MulY(y);
				this.X0Y0_頭.JP[2].Joint = this.X0Y0_頭.JP[2].Joint.MulY(y);
				this.X0Y0_頭.JP[8].Joint = this.X0Y0_頭.JP[8].Joint.MulY(y);
				this.X0Y0_頭.JP[9].Joint = this.X0Y0_頭.JP[9].Joint.MulY(y);
				this.X0Y0_頭.JP[12].Joint = this.X0Y0_頭.JP[12].Joint.MulY(y);
				this.X0Y0_頭.JP[13].Joint = this.X0Y0_頭.JP[13].Joint.MulY(y);
				this.X0Y0_頭.JP[14].Joint = this.X0Y0_頭.JP[14].Joint.MulY(y);
				this.X0Y0_頭.JP[10].Joint = this.X0Y0_頭.JP[10].Joint.MulY(y);
				this.X0Y0_頭.JP[11].Joint = this.X0Y0_頭.JP[11].Joint.MulY(y);
				this.X0Y0_頭.JP[15].Joint = this.X0Y0_頭.JP[15].Joint.MulY(y);
				this.X0Y0_頭.JP[16].Joint = this.X0Y0_頭.JP[16].Joint.MulY(y);
			}
		}

		public double 目間
		{
			set
			{
				double num = 0.0007 * value;
				this.X0Y0_頭.JP[1].Joint = this.X0Y0_頭.JP[1].Joint.AddX(-num);
				this.X0Y0_頭.JP[2].Joint = this.X0Y0_頭.JP[2].Joint.AddX(num);
				this.X0Y0_頭.JP[15].Joint = this.X0Y0_頭.JP[15].Joint.AddX(-num);
				this.X0Y0_頭.JP[16].Joint = this.X0Y0_頭.JP[16].Joint.AddX(num);
			}
		}

		public double 眉間
		{
			set
			{
				double num = 0.001 * value;
				this.X0Y0_頭.JP[8].Joint = this.X0Y0_頭.JP[8].Joint.AddX(-num);
				this.X0Y0_頭.JP[9].Joint = this.X0Y0_頭.JP[9].Joint.AddX(num);
			}
		}

		public JointS 基髪_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_頭, 0);
			}
		}

		public JointS 目左_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_頭, 1);
			}
		}

		public JointS 目右_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_頭, 2);
			}
		}

		public JointS 鼻_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_頭, 3);
			}
		}

		public JointS 口_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_頭, 4);
			}
		}

		public JointS 頬左_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_頭, 5);
			}
		}

		public JointS 頬右_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_頭, 6);
			}
		}

		public JointS 額_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_頭, 7);
			}
		}

		public JointS 眉左_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_頭, 8);
			}
		}

		public JointS 眉右_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_頭, 9);
			}
		}

		public JointS 耳左_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_頭, 10);
			}
		}

		public JointS 耳右_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_頭, 11);
			}
		}

		public JointS 鼻肌_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_頭, 12);
			}
		}

		public JointS 単眼目_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_頭, 13);
			}
		}

		public JointS 単眼眉_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_頭, 14);
			}
		}

		public JointS 大顎基_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_頭, 14);
			}
		}

		public JointS 顔面_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_頭, 13);
			}
		}

		public JointS 頭頂_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_頭, 14);
			}
		}

		public JointS 頬肌左_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_頭, 15);
			}
		}

		public JointS 頬肌右_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_頭, 16);
			}
		}

		public JointS 触覚左_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_頭, 17);
			}
		}

		public JointS 触覚右_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_頭, 18);
			}
		}

		public override void 色更新()
		{
			this.X0Y0_頭CP.Update();
			this.X0Y0_悪タトゥ_逆十字_逆十字1CP.Update();
			this.X0Y0_悪タトゥ_逆十字_逆十字2CP.Update();
			this.X0Y0_隈取_タトゥCP.Update();
			this.X0Y0_隈取_タトゥ左CP.Update();
			this.X0Y0_隈取_タトゥ右CP.Update();
			this.X0Y0_秘石_基CP.Update();
			this.X0Y0_秘石_秘石CP.Update();
			this.X0Y0_秘石_ハイライトCP.Update();
			this.X0Y0_蜘蛛_眼左1_基CP.Update();
			this.X0Y0_蜘蛛_眼左1_眼CP.Update();
			this.X0Y0_蜘蛛_眼左1_ハイライトCP.Update();
			this.X0Y0_蜘蛛_眼左2_基CP.Update();
			this.X0Y0_蜘蛛_眼左2_眼CP.Update();
			this.X0Y0_蜘蛛_眼左2_ハイライトCP.Update();
			this.X0Y0_蜘蛛_眼右1_基CP.Update();
			this.X0Y0_蜘蛛_眼右1_眼CP.Update();
			this.X0Y0_蜘蛛_眼右1_ハイライトCP.Update();
			this.X0Y0_蜘蛛_眼右2_基CP.Update();
			this.X0Y0_蜘蛛_眼右2_眼CP.Update();
			this.X0Y0_蜘蛛_眼右2_ハイライトCP.Update();
			this.X0Y0_羽虫_眼中_基CP.Update();
			this.X0Y0_羽虫_眼中_眼CP.Update();
			this.X0Y0_羽虫_眼中_ハイライトCP.Update();
			this.X0Y0_羽虫_眼左_基CP.Update();
			this.X0Y0_羽虫_眼左_眼CP.Update();
			this.X0Y0_羽虫_眼左_ハイライトCP.Update();
			this.X0Y0_羽虫_眼右_基CP.Update();
			this.X0Y0_羽虫_眼右_眼CP.Update();
			this.X0Y0_羽虫_眼右_ハイライトCP.Update();
			this.X0Y0_紋柄_紋CP.Update();
			this.X0Y0_紋柄_紋左1CP.Update();
			this.X0Y0_紋柄_紋右1CP.Update();
			this.X0Y0_紋柄_紋左2CP.Update();
			this.X0Y0_紋柄_紋右2CP.Update();
			this.X0Y0_竜性_鱗1CP.Update();
			this.X0Y0_竜性_鱗2CP.Update();
			this.X0Y0_竜性_鱗3CP.Update();
			this.X0Y0_馬柄_馬柄CP.Update();
			this.X0Y0_虫性_顎下CP.Update();
		}

		public override void 色更新(Vector2D[] mm)
		{
			this.X0Y0_頭CP.Update(mm);
			this.X0Y0_悪タトゥ_逆十字_逆十字1CP.Update();
			this.X0Y0_悪タトゥ_逆十字_逆十字2CP.Update();
			this.X0Y0_隈取_タトゥCP.Update();
			this.X0Y0_隈取_タトゥ左CP.Update();
			this.X0Y0_隈取_タトゥ右CP.Update();
			this.X0Y0_秘石_基CP.Update();
			this.X0Y0_秘石_秘石CP.Update();
			this.X0Y0_秘石_ハイライトCP.Update();
			this.X0Y0_蜘蛛_眼左1_基CP.Update();
			this.X0Y0_蜘蛛_眼左1_眼CP.Update();
			this.X0Y0_蜘蛛_眼左1_ハイライトCP.Update();
			this.X0Y0_蜘蛛_眼左2_基CP.Update();
			this.X0Y0_蜘蛛_眼左2_眼CP.Update();
			this.X0Y0_蜘蛛_眼左2_ハイライトCP.Update();
			this.X0Y0_蜘蛛_眼右1_基CP.Update();
			this.X0Y0_蜘蛛_眼右1_眼CP.Update();
			this.X0Y0_蜘蛛_眼右1_ハイライトCP.Update();
			this.X0Y0_蜘蛛_眼右2_基CP.Update();
			this.X0Y0_蜘蛛_眼右2_眼CP.Update();
			this.X0Y0_蜘蛛_眼右2_ハイライトCP.Update();
			this.X0Y0_羽虫_眼中_基CP.Update();
			this.X0Y0_羽虫_眼中_眼CP.Update();
			this.X0Y0_羽虫_眼中_ハイライトCP.Update();
			this.X0Y0_羽虫_眼左_基CP.Update();
			this.X0Y0_羽虫_眼左_眼CP.Update();
			this.X0Y0_羽虫_眼左_ハイライトCP.Update();
			this.X0Y0_羽虫_眼右_基CP.Update();
			this.X0Y0_羽虫_眼右_眼CP.Update();
			this.X0Y0_羽虫_眼右_ハイライトCP.Update();
			this.X0Y0_紋柄_紋CP.Update();
			this.X0Y0_紋柄_紋左1CP.Update();
			this.X0Y0_紋柄_紋右1CP.Update();
			this.X0Y0_紋柄_紋左2CP.Update();
			this.X0Y0_紋柄_紋右2CP.Update();
			this.X0Y0_竜性_鱗1CP.Update();
			this.X0Y0_竜性_鱗2CP.Update();
			this.X0Y0_竜性_鱗3CP.Update();
			this.X0Y0_馬柄_馬柄CP.Update();
			this.X0Y0_虫性_顎下CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.頭CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.悪タトゥ_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_逆十字_逆十字2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.隈取_タトゥCD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.隈取_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.隈取_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.秘石_基CD = new ColorD(ref Col.Black, ref 体配色.秘石O);
			this.秘石_秘石CD = new ColorD(ref Col.Black, ref 体配色.秘石O);
			this.秘石_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
			this.蜘蛛_眼左1_基CD = new ColorD(ref Col.Black, ref 体配色.眼2O);
			this.蜘蛛_眼左1_眼CD = new ColorD(ref Col.Black, ref 体配色.眼2O);
			this.蜘蛛_眼左1_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
			this.蜘蛛_眼左2_基CD = new ColorD(ref Col.Black, ref 体配色.眼2O);
			this.蜘蛛_眼左2_眼CD = new ColorD(ref Col.Black, ref 体配色.眼2O);
			this.蜘蛛_眼左2_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
			this.蜘蛛_眼右1_基CD = new ColorD(ref Col.Black, ref 体配色.眼2O);
			this.蜘蛛_眼右1_眼CD = new ColorD(ref Col.Black, ref 体配色.眼2O);
			this.蜘蛛_眼右1_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
			this.蜘蛛_眼右2_基CD = new ColorD(ref Col.Black, ref 体配色.眼2O);
			this.蜘蛛_眼右2_眼CD = new ColorD(ref Col.Black, ref 体配色.眼2O);
			this.蜘蛛_眼右2_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
			this.羽虫_眼中_基CD = new ColorD(ref Col.Black, ref 体配色.眼1O);
			this.羽虫_眼中_眼CD = new ColorD(ref Col.Black, ref 体配色.眼1O);
			this.羽虫_眼中_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
			this.羽虫_眼左_基CD = new ColorD(ref Col.Black, ref 体配色.眼1O);
			this.羽虫_眼左_眼CD = new ColorD(ref Col.Black, ref 体配色.眼1O);
			this.羽虫_眼左_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
			this.羽虫_眼右_基CD = new ColorD(ref Col.Black, ref 体配色.眼1O);
			this.羽虫_眼右_眼CD = new ColorD(ref Col.Black, ref 体配色.眼1O);
			this.羽虫_眼右_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
			this.紋柄_紋CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋左1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋右1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋左2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋右2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.馬柄_馬柄CD = new ColorD(ref Col.Empty, ref 体配色.毛0O);
			this.虫性_顎下CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
		}

		public Par X0Y0_頭;

		public Par X0Y0_悪タトゥ_逆十字_逆十字1;

		public Par X0Y0_悪タトゥ_逆十字_逆十字2;

		public Par X0Y0_隈取_タトゥ;

		public Par X0Y0_隈取_タトゥ左;

		public Par X0Y0_隈取_タトゥ右;

		public Par X0Y0_秘石_基;

		public Par X0Y0_秘石_秘石;

		public Par X0Y0_秘石_ハイライト;

		public Par X0Y0_蜘蛛_眼左1_基;

		public Par X0Y0_蜘蛛_眼左1_眼;

		public Par X0Y0_蜘蛛_眼左1_ハイライト;

		public Par X0Y0_蜘蛛_眼左2_基;

		public Par X0Y0_蜘蛛_眼左2_眼;

		public Par X0Y0_蜘蛛_眼左2_ハイライト;

		public Par X0Y0_蜘蛛_眼右1_基;

		public Par X0Y0_蜘蛛_眼右1_眼;

		public Par X0Y0_蜘蛛_眼右1_ハイライト;

		public Par X0Y0_蜘蛛_眼右2_基;

		public Par X0Y0_蜘蛛_眼右2_眼;

		public Par X0Y0_蜘蛛_眼右2_ハイライト;

		public Par X0Y0_羽虫_眼中_基;

		public Par X0Y0_羽虫_眼中_眼;

		public Par X0Y0_羽虫_眼中_ハイライト;

		public Par X0Y0_羽虫_眼左_基;

		public Par X0Y0_羽虫_眼左_眼;

		public Par X0Y0_羽虫_眼左_ハイライト;

		public Par X0Y0_羽虫_眼右_基;

		public Par X0Y0_羽虫_眼右_眼;

		public Par X0Y0_羽虫_眼右_ハイライト;

		public Par X0Y0_紋柄_紋;

		public Par X0Y0_紋柄_紋左1;

		public Par X0Y0_紋柄_紋右1;

		public Par X0Y0_紋柄_紋左2;

		public Par X0Y0_紋柄_紋右2;

		public Par X0Y0_竜性_鱗1;

		public Par X0Y0_竜性_鱗2;

		public Par X0Y0_竜性_鱗3;

		public Par X0Y0_馬柄_馬柄;

		public Par X0Y0_虫性_顎下;

		public ColorD 頭CD;

		public ColorD 悪タトゥ_逆十字_逆十字1CD;

		public ColorD 悪タトゥ_逆十字_逆十字2CD;

		public ColorD 隈取_タトゥCD;

		public ColorD 隈取_タトゥ左CD;

		public ColorD 隈取_タトゥ右CD;

		public ColorD 秘石_基CD;

		public ColorD 秘石_秘石CD;

		public ColorD 秘石_ハイライトCD;

		public ColorD 蜘蛛_眼左1_基CD;

		public ColorD 蜘蛛_眼左1_眼CD;

		public ColorD 蜘蛛_眼左1_ハイライトCD;

		public ColorD 蜘蛛_眼左2_基CD;

		public ColorD 蜘蛛_眼左2_眼CD;

		public ColorD 蜘蛛_眼左2_ハイライトCD;

		public ColorD 蜘蛛_眼右1_基CD;

		public ColorD 蜘蛛_眼右1_眼CD;

		public ColorD 蜘蛛_眼右1_ハイライトCD;

		public ColorD 蜘蛛_眼右2_基CD;

		public ColorD 蜘蛛_眼右2_眼CD;

		public ColorD 蜘蛛_眼右2_ハイライトCD;

		public ColorD 羽虫_眼中_基CD;

		public ColorD 羽虫_眼中_眼CD;

		public ColorD 羽虫_眼中_ハイライトCD;

		public ColorD 羽虫_眼左_基CD;

		public ColorD 羽虫_眼左_眼CD;

		public ColorD 羽虫_眼左_ハイライトCD;

		public ColorD 羽虫_眼右_基CD;

		public ColorD 羽虫_眼右_眼CD;

		public ColorD 羽虫_眼右_ハイライトCD;

		public ColorD 紋柄_紋CD;

		public ColorD 紋柄_紋左1CD;

		public ColorD 紋柄_紋右1CD;

		public ColorD 紋柄_紋左2CD;

		public ColorD 紋柄_紋右2CD;

		public ColorD 竜性_鱗1CD;

		public ColorD 竜性_鱗2CD;

		public ColorD 竜性_鱗3CD;

		public ColorD 馬柄_馬柄CD;

		public ColorD 虫性_顎下CD;

		public ColorP X0Y0_頭CP;

		public ColorP X0Y0_悪タトゥ_逆十字_逆十字1CP;

		public ColorP X0Y0_悪タトゥ_逆十字_逆十字2CP;

		public ColorP X0Y0_隈取_タトゥCP;

		public ColorP X0Y0_隈取_タトゥ左CP;

		public ColorP X0Y0_隈取_タトゥ右CP;

		public ColorP X0Y0_秘石_基CP;

		public ColorP X0Y0_秘石_秘石CP;

		public ColorP X0Y0_秘石_ハイライトCP;

		public ColorP X0Y0_蜘蛛_眼左1_基CP;

		public ColorP X0Y0_蜘蛛_眼左1_眼CP;

		public ColorP X0Y0_蜘蛛_眼左1_ハイライトCP;

		public ColorP X0Y0_蜘蛛_眼左2_基CP;

		public ColorP X0Y0_蜘蛛_眼左2_眼CP;

		public ColorP X0Y0_蜘蛛_眼左2_ハイライトCP;

		public ColorP X0Y0_蜘蛛_眼右1_基CP;

		public ColorP X0Y0_蜘蛛_眼右1_眼CP;

		public ColorP X0Y0_蜘蛛_眼右1_ハイライトCP;

		public ColorP X0Y0_蜘蛛_眼右2_基CP;

		public ColorP X0Y0_蜘蛛_眼右2_眼CP;

		public ColorP X0Y0_蜘蛛_眼右2_ハイライトCP;

		public ColorP X0Y0_羽虫_眼中_基CP;

		public ColorP X0Y0_羽虫_眼中_眼CP;

		public ColorP X0Y0_羽虫_眼中_ハイライトCP;

		public ColorP X0Y0_羽虫_眼左_基CP;

		public ColorP X0Y0_羽虫_眼左_眼CP;

		public ColorP X0Y0_羽虫_眼左_ハイライトCP;

		public ColorP X0Y0_羽虫_眼右_基CP;

		public ColorP X0Y0_羽虫_眼右_眼CP;

		public ColorP X0Y0_羽虫_眼右_ハイライトCP;

		public ColorP X0Y0_紋柄_紋CP;

		public ColorP X0Y0_紋柄_紋左1CP;

		public ColorP X0Y0_紋柄_紋右1CP;

		public ColorP X0Y0_紋柄_紋左2CP;

		public ColorP X0Y0_紋柄_紋右2CP;

		public ColorP X0Y0_竜性_鱗1CP;

		public ColorP X0Y0_竜性_鱗2CP;

		public ColorP X0Y0_竜性_鱗3CP;

		public ColorP X0Y0_馬柄_馬柄CP;

		public ColorP X0Y0_虫性_顎下CP;

		public Ele[] 基髪_接続;

		public Ele[] 目左_接続;

		public Ele[] 目右_接続;

		public Ele[] 鼻_接続;

		public Ele[] 口_接続;

		public Ele[] 頬左_接続;

		public Ele[] 頬右_接続;

		public Ele[] 額_接続;

		public Ele[] 眉左_接続;

		public Ele[] 眉右_接続;

		public Ele[] 耳左_接続;

		public Ele[] 耳右_接続;

		public Ele[] 鼻肌_接続;

		public Ele[] 単眼目_接続;

		public Ele[] 単眼眉_接続;

		public Ele[] 大顎基_接続;

		public Ele[] 顔面_接続;

		public Ele[] 頭頂_接続;

		public Ele[] 頬肌左_接続;

		public Ele[] 頬肌右_接続;

		public Ele[] 触覚左_接続;

		public Ele[] 触覚右_接続;
	}
}
