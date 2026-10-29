using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 花_百 : 花
	{
		public 花_百(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 花_百D e)
		{
			this.ThisType = base.GetType();
			Pars pars = new Pars();
			pars.Tag = "ユリ";
			Pars pars2 = Sta.肢左["植"][0][0];
			pars.Add("ユリ", new Pars(pars2["花"].ToPars()["ユリ"].ToPars()));
			pars.Add("萼", new Pars(pars2["萼"].ToPars()));
			Dif dif = new Dif();
			dif.Tag = "花";
			dif.Add(new Pars(pars));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars3 = this.本体[0][0];
			Pars pars4 = pars3["ユリ"].ToPars();
			Pars pars5 = pars4["通常"].ToPars();
			this.X0Y0_花_ユリ_通常_萼2 = pars5["萼2"].ToPar();
			this.X0Y0_花_ユリ_通常_萼3 = pars5["萼3"].ToPar();
			this.X0Y0_花_ユリ_通常_花弁1 = pars5["花弁1"].ToPar();
			Pars pars6 = pars5["蕊"].ToPars();
			Pars pars7 = pars6["雄蕊中後"].ToPars();
			this.X0Y0_花_ユリ_通常_蕊_雄蕊中後_葯 = pars7["葯"].ToPar();
			this.X0Y0_花_ユリ_通常_蕊_雄蕊中後_雄蕊 = pars7["雄蕊"].ToPar();
			pars7 = pars6["雌蕊"].ToPars();
			this.X0Y0_花_ユリ_通常_蕊_雌蕊_雌蕊 = pars7["雌蕊"].ToPar();
			this.X0Y0_花_ユリ_通常_蕊_雌蕊_柱頭 = pars7["柱頭"].ToPar();
			pars7 = pars6["雄蕊左2"].ToPars();
			this.X0Y0_花_ユリ_通常_蕊_雄蕊左2_葯 = pars7["葯"].ToPar();
			this.X0Y0_花_ユリ_通常_蕊_雄蕊左2_雄蕊 = pars7["雄蕊"].ToPar();
			pars7 = pars6["雄蕊右2"].ToPars();
			this.X0Y0_花_ユリ_通常_蕊_雄蕊右2_葯 = pars7["葯"].ToPar();
			this.X0Y0_花_ユリ_通常_蕊_雄蕊右2_雄蕊 = pars7["雄蕊"].ToPar();
			pars7 = pars6["雄蕊左1"].ToPars();
			this.X0Y0_花_ユリ_通常_蕊_雄蕊左1_雄蕊 = pars7["雄蕊"].ToPar();
			this.X0Y0_花_ユリ_通常_蕊_雄蕊左1_葯 = pars7["葯"].ToPar();
			pars7 = pars6["雄蕊右1"].ToPars();
			this.X0Y0_花_ユリ_通常_蕊_雄蕊右1_雄蕊 = pars7["雄蕊"].ToPar();
			this.X0Y0_花_ユリ_通常_蕊_雄蕊右1_葯 = pars7["葯"].ToPar();
			pars7 = pars6["雄蕊中前"].ToPars();
			this.X0Y0_花_ユリ_通常_蕊_雄蕊中前_雄蕊 = pars7["雄蕊"].ToPar();
			this.X0Y0_花_ユリ_通常_蕊_雄蕊中前_葯 = pars7["葯"].ToPar();
			this.X0Y0_花_ユリ_通常_花弁2 = pars5["花弁2"].ToPar();
			this.X0Y0_花_ユリ_通常_花弁3 = pars5["花弁3"].ToPar();
			pars6 = pars5["萼1"].ToPars();
			this.X0Y0_花_ユリ_通常_萼1_萼2 = pars6["萼2"].ToPar();
			this.X0Y0_花_ユリ_通常_萼1_萼1 = pars6["萼1"].ToPar();
			pars5 = pars4["欠損"].ToPars();
			this.X0Y0_花_ユリ_欠損_萼2 = pars5["萼2"].ToPar();
			this.X0Y0_花_ユリ_欠損_萼3 = pars5["萼3"].ToPar();
			this.X0Y0_花_ユリ_欠損_花弁1 = pars5["花弁1"].ToPar();
			pars6 = pars5["蕊"].ToPars();
			pars7 = pars6["雄蕊中後"].ToPars();
			this.X0Y0_花_ユリ_欠損_蕊_雄蕊中後_葯 = pars7["葯"].ToPar();
			this.X0Y0_花_ユリ_欠損_蕊_雄蕊中後_雄蕊 = pars7["雄蕊"].ToPar();
			pars7 = pars6["雌蕊"].ToPars();
			this.X0Y0_花_ユリ_欠損_蕊_雌蕊_雌蕊 = pars7["雌蕊"].ToPar();
			this.X0Y0_花_ユリ_欠損_蕊_雌蕊_柱頭 = pars7["柱頭"].ToPar();
			pars7 = pars6["雄蕊左2"].ToPars();
			this.X0Y0_花_ユリ_欠損_蕊_雄蕊左2_葯 = pars7["葯"].ToPar();
			this.X0Y0_花_ユリ_欠損_蕊_雄蕊左2_雄蕊 = pars7["雄蕊"].ToPar();
			pars7 = pars6["雄蕊右2"].ToPars();
			this.X0Y0_花_ユリ_欠損_蕊_雄蕊右2_葯 = pars7["葯"].ToPar();
			this.X0Y0_花_ユリ_欠損_蕊_雄蕊右2_雄蕊 = pars7["雄蕊"].ToPar();
			pars7 = pars6["雄蕊左1"].ToPars();
			this.X0Y0_花_ユリ_欠損_蕊_雄蕊左1_雄蕊 = pars7["雄蕊"].ToPar();
			this.X0Y0_花_ユリ_欠損_蕊_雄蕊左1_葯 = pars7["葯"].ToPar();
			pars7 = pars6["雄蕊右1"].ToPars();
			this.X0Y0_花_ユリ_欠損_蕊_雄蕊右1_雄蕊 = pars7["雄蕊"].ToPar();
			this.X0Y0_花_ユリ_欠損_蕊_雄蕊右1_葯 = pars7["葯"].ToPar();
			pars7 = pars6["雄蕊中前"].ToPars();
			this.X0Y0_花_ユリ_欠損_蕊_雄蕊中前_雄蕊 = pars7["雄蕊"].ToPar();
			this.X0Y0_花_ユリ_欠損_蕊_雄蕊中前_葯 = pars7["葯"].ToPar();
			this.X0Y0_花_ユリ_欠損_花弁2 = pars5["花弁2"].ToPar();
			this.X0Y0_花_ユリ_欠損_花弁3 = pars5["花弁3"].ToPar();
			pars6 = pars5["萼1"].ToPars();
			this.X0Y0_花_ユリ_欠損_萼1_萼2 = pars6["萼2"].ToPar();
			this.X0Y0_花_ユリ_欠損_萼1_萼1 = pars6["萼1"].ToPar();
			Pars pars8 = pars3["萼"].ToPars();
			pars5 = pars8["通常"].ToPars();
			this.X0Y0_萼_通常_萼 = pars5["萼"].ToPar();
			pars5 = pars8["欠損"].ToPars();
			this.X0Y0_萼_欠損_萼 = pars5["萼"].ToPar();
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
			this.花_ユリ_通常_萼2_表示 = e.花_ユリ_通常_萼2_表示;
			this.花_ユリ_通常_萼3_表示 = e.花_ユリ_通常_萼3_表示;
			this.花_ユリ_通常_花弁1_表示 = e.花_ユリ_通常_花弁1_表示;
			this.花_ユリ_通常_蕊_雄蕊中後_葯_表示 = e.花_ユリ_通常_蕊_雄蕊中後_葯_表示;
			this.花_ユリ_通常_蕊_雄蕊中後_雄蕊_表示 = e.花_ユリ_通常_蕊_雄蕊中後_雄蕊_表示;
			this.花_ユリ_通常_蕊_雌蕊_雌蕊_表示 = e.花_ユリ_通常_蕊_雌蕊_雌蕊_表示;
			this.花_ユリ_通常_蕊_雌蕊_柱頭_表示 = e.花_ユリ_通常_蕊_雌蕊_柱頭_表示;
			this.花_ユリ_通常_蕊_雄蕊左2_葯_表示 = e.花_ユリ_通常_蕊_雄蕊左2_葯_表示;
			this.花_ユリ_通常_蕊_雄蕊左2_雄蕊_表示 = e.花_ユリ_通常_蕊_雄蕊左2_雄蕊_表示;
			this.花_ユリ_通常_蕊_雄蕊右2_葯_表示 = e.花_ユリ_通常_蕊_雄蕊右2_葯_表示;
			this.花_ユリ_通常_蕊_雄蕊右2_雄蕊_表示 = e.花_ユリ_通常_蕊_雄蕊右2_雄蕊_表示;
			this.花_ユリ_通常_蕊_雄蕊左1_雄蕊_表示 = e.花_ユリ_通常_蕊_雄蕊左1_雄蕊_表示;
			this.花_ユリ_通常_蕊_雄蕊左1_葯_表示 = e.花_ユリ_通常_蕊_雄蕊左1_葯_表示;
			this.花_ユリ_通常_蕊_雄蕊右1_雄蕊_表示 = e.花_ユリ_通常_蕊_雄蕊右1_雄蕊_表示;
			this.花_ユリ_通常_蕊_雄蕊右1_葯_表示 = e.花_ユリ_通常_蕊_雄蕊右1_葯_表示;
			this.花_ユリ_通常_蕊_雄蕊中前_雄蕊_表示 = e.花_ユリ_通常_蕊_雄蕊中前_雄蕊_表示;
			this.花_ユリ_通常_蕊_雄蕊中前_葯_表示 = e.花_ユリ_通常_蕊_雄蕊中前_葯_表示;
			this.花_ユリ_通常_花弁2_表示 = e.花_ユリ_通常_花弁2_表示;
			this.花_ユリ_通常_花弁3_表示 = e.花_ユリ_通常_花弁3_表示;
			this.花_ユリ_通常_萼1_萼2_表示 = e.花_ユリ_通常_萼1_萼2_表示;
			this.花_ユリ_通常_萼1_萼1_表示 = e.花_ユリ_通常_萼1_萼1_表示;
			this.花_ユリ_欠損_萼2_表示 = e.花_ユリ_欠損_萼2_表示;
			this.花_ユリ_欠損_萼3_表示 = e.花_ユリ_欠損_萼3_表示;
			this.花_ユリ_欠損_花弁1_表示 = e.花_ユリ_欠損_花弁1_表示;
			this.花_ユリ_欠損_蕊_雄蕊中後_葯_表示 = e.花_ユリ_欠損_蕊_雄蕊中後_葯_表示;
			this.花_ユリ_欠損_蕊_雄蕊中後_雄蕊_表示 = e.花_ユリ_欠損_蕊_雄蕊中後_雄蕊_表示;
			this.花_ユリ_欠損_蕊_雌蕊_雌蕊_表示 = e.花_ユリ_欠損_蕊_雌蕊_雌蕊_表示;
			this.花_ユリ_欠損_蕊_雌蕊_柱頭_表示 = e.花_ユリ_欠損_蕊_雌蕊_柱頭_表示;
			this.花_ユリ_欠損_蕊_雄蕊左2_葯_表示 = e.花_ユリ_欠損_蕊_雄蕊左2_葯_表示;
			this.花_ユリ_欠損_蕊_雄蕊左2_雄蕊_表示 = e.花_ユリ_欠損_蕊_雄蕊左2_雄蕊_表示;
			this.花_ユリ_欠損_蕊_雄蕊右2_葯_表示 = e.花_ユリ_欠損_蕊_雄蕊右2_葯_表示;
			this.花_ユリ_欠損_蕊_雄蕊右2_雄蕊_表示 = e.花_ユリ_欠損_蕊_雄蕊右2_雄蕊_表示;
			this.花_ユリ_欠損_蕊_雄蕊左1_雄蕊_表示 = e.花_ユリ_欠損_蕊_雄蕊左1_雄蕊_表示;
			this.花_ユリ_欠損_蕊_雄蕊左1_葯_表示 = e.花_ユリ_欠損_蕊_雄蕊左1_葯_表示;
			this.花_ユリ_欠損_蕊_雄蕊右1_雄蕊_表示 = e.花_ユリ_欠損_蕊_雄蕊右1_雄蕊_表示;
			this.花_ユリ_欠損_蕊_雄蕊右1_葯_表示 = e.花_ユリ_欠損_蕊_雄蕊右1_葯_表示;
			this.花_ユリ_欠損_蕊_雄蕊中前_雄蕊_表示 = e.花_ユリ_欠損_蕊_雄蕊中前_雄蕊_表示;
			this.花_ユリ_欠損_蕊_雄蕊中前_葯_表示 = e.花_ユリ_欠損_蕊_雄蕊中前_葯_表示;
			this.花_ユリ_欠損_花弁2_表示 = e.花_ユリ_欠損_花弁2_表示;
			this.花_ユリ_欠損_花弁3_表示 = e.花_ユリ_欠損_花弁3_表示;
			this.花_ユリ_欠損_萼1_萼2_表示 = e.花_ユリ_欠損_萼1_萼2_表示;
			this.花_ユリ_欠損_萼1_萼1_表示 = e.花_ユリ_欠損_萼1_萼1_表示;
			this.萼_通常_萼_表示 = e.萼_通常_萼_表示;
			this.萼_欠損_萼_表示 = e.萼_欠損_萼_表示;
			this.花_ユリ_萼2_表示 = e.花_ユリ_萼2_表示;
			this.花_ユリ_萼3_表示 = e.花_ユリ_萼3_表示;
			this.花_ユリ_花弁1_表示 = e.花_ユリ_花弁1_表示;
			this.花_ユリ_蕊_雄蕊中後_葯_表示 = e.花_ユリ_蕊_雄蕊中後_葯_表示;
			this.花_ユリ_蕊_雄蕊中後_雄蕊_表示 = e.花_ユリ_蕊_雄蕊中後_雄蕊_表示;
			this.花_ユリ_蕊_雌蕊_雌蕊_表示 = e.花_ユリ_蕊_雌蕊_雌蕊_表示;
			this.花_ユリ_蕊_雌蕊_柱頭_表示 = e.花_ユリ_蕊_雌蕊_柱頭_表示;
			this.花_ユリ_蕊_雄蕊左2_葯_表示 = e.花_ユリ_蕊_雄蕊左2_葯_表示;
			this.花_ユリ_蕊_雄蕊左2_雄蕊_表示 = e.花_ユリ_蕊_雄蕊左2_雄蕊_表示;
			this.花_ユリ_蕊_雄蕊右2_葯_表示 = e.花_ユリ_蕊_雄蕊右2_葯_表示;
			this.花_ユリ_蕊_雄蕊右2_雄蕊_表示 = e.花_ユリ_蕊_雄蕊右2_雄蕊_表示;
			this.花_ユリ_蕊_雄蕊左1_雄蕊_表示 = e.花_ユリ_蕊_雄蕊左1_雄蕊_表示;
			this.花_ユリ_蕊_雄蕊左1_葯_表示 = e.花_ユリ_蕊_雄蕊左1_葯_表示;
			this.花_ユリ_蕊_雄蕊右1_雄蕊_表示 = e.花_ユリ_蕊_雄蕊右1_雄蕊_表示;
			this.花_ユリ_蕊_雄蕊右1_葯_表示 = e.花_ユリ_蕊_雄蕊右1_葯_表示;
			this.花_ユリ_蕊_雄蕊中前_雄蕊_表示 = e.花_ユリ_蕊_雄蕊中前_雄蕊_表示;
			this.花_ユリ_蕊_雄蕊中前_葯_表示 = e.花_ユリ_蕊_雄蕊中前_葯_表示;
			this.花_ユリ_花弁2_表示 = e.花_ユリ_花弁2_表示;
			this.花_ユリ_花弁3_表示 = e.花_ユリ_花弁3_表示;
			this.花_ユリ_萼1_萼2_表示 = e.花_ユリ_萼1_萼2_表示;
			this.花_ユリ_萼1_萼1_表示 = e.花_ユリ_萼1_萼1_表示;
			this.萼_萼_表示 = e.萼_萼_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_花_ユリ_通常_萼2CP = new ColorP(this.X0Y0_花_ユリ_通常_萼2, this.花_ユリ_萼2CD, DisUnit, true);
			this.X0Y0_花_ユリ_通常_萼3CP = new ColorP(this.X0Y0_花_ユリ_通常_萼3, this.花_ユリ_萼3CD, DisUnit, true);
			this.X0Y0_花_ユリ_通常_花弁1CP = new ColorP(this.X0Y0_花_ユリ_通常_花弁1, this.花_ユリ_花弁1CD, DisUnit, true);
			this.X0Y0_花_ユリ_通常_蕊_雄蕊中後_葯CP = new ColorP(this.X0Y0_花_ユリ_通常_蕊_雄蕊中後_葯, this.花_ユリ_蕊_雄蕊中後_葯CD, DisUnit, true);
			this.X0Y0_花_ユリ_通常_蕊_雄蕊中後_雄蕊CP = new ColorP(this.X0Y0_花_ユリ_通常_蕊_雄蕊中後_雄蕊, this.花_ユリ_蕊_雄蕊中後_雄蕊CD, DisUnit, true);
			this.X0Y0_花_ユリ_通常_蕊_雌蕊_雌蕊CP = new ColorP(this.X0Y0_花_ユリ_通常_蕊_雌蕊_雌蕊, this.花_ユリ_蕊_雌蕊_雌蕊CD, DisUnit, true);
			this.X0Y0_花_ユリ_通常_蕊_雌蕊_柱頭CP = new ColorP(this.X0Y0_花_ユリ_通常_蕊_雌蕊_柱頭, this.花_ユリ_蕊_雌蕊_柱頭CD, DisUnit, true);
			this.X0Y0_花_ユリ_通常_蕊_雄蕊左2_葯CP = new ColorP(this.X0Y0_花_ユリ_通常_蕊_雄蕊左2_葯, this.花_ユリ_蕊_雄蕊左2_葯CD, DisUnit, true);
			this.X0Y0_花_ユリ_通常_蕊_雄蕊左2_雄蕊CP = new ColorP(this.X0Y0_花_ユリ_通常_蕊_雄蕊左2_雄蕊, this.花_ユリ_蕊_雄蕊左2_雄蕊CD, DisUnit, true);
			this.X0Y0_花_ユリ_通常_蕊_雄蕊右2_葯CP = new ColorP(this.X0Y0_花_ユリ_通常_蕊_雄蕊右2_葯, this.花_ユリ_蕊_雄蕊右2_葯CD, DisUnit, true);
			this.X0Y0_花_ユリ_通常_蕊_雄蕊右2_雄蕊CP = new ColorP(this.X0Y0_花_ユリ_通常_蕊_雄蕊右2_雄蕊, this.花_ユリ_蕊_雄蕊右2_雄蕊CD, DisUnit, true);
			this.X0Y0_花_ユリ_通常_蕊_雄蕊左1_雄蕊CP = new ColorP(this.X0Y0_花_ユリ_通常_蕊_雄蕊左1_雄蕊, this.花_ユリ_蕊_雄蕊左1_雄蕊CD, DisUnit, true);
			this.X0Y0_花_ユリ_通常_蕊_雄蕊左1_葯CP = new ColorP(this.X0Y0_花_ユリ_通常_蕊_雄蕊左1_葯, this.花_ユリ_蕊_雄蕊左1_葯CD, DisUnit, true);
			this.X0Y0_花_ユリ_通常_蕊_雄蕊右1_雄蕊CP = new ColorP(this.X0Y0_花_ユリ_通常_蕊_雄蕊右1_雄蕊, this.花_ユリ_蕊_雄蕊右1_雄蕊CD, DisUnit, true);
			this.X0Y0_花_ユリ_通常_蕊_雄蕊右1_葯CP = new ColorP(this.X0Y0_花_ユリ_通常_蕊_雄蕊右1_葯, this.花_ユリ_蕊_雄蕊右1_葯CD, DisUnit, true);
			this.X0Y0_花_ユリ_通常_蕊_雄蕊中前_雄蕊CP = new ColorP(this.X0Y0_花_ユリ_通常_蕊_雄蕊中前_雄蕊, this.花_ユリ_蕊_雄蕊中前_雄蕊CD, DisUnit, true);
			this.X0Y0_花_ユリ_通常_蕊_雄蕊中前_葯CP = new ColorP(this.X0Y0_花_ユリ_通常_蕊_雄蕊中前_葯, this.花_ユリ_蕊_雄蕊中前_葯CD, DisUnit, true);
			this.X0Y0_花_ユリ_通常_花弁2CP = new ColorP(this.X0Y0_花_ユリ_通常_花弁2, this.花_ユリ_花弁2CD, DisUnit, true);
			this.X0Y0_花_ユリ_通常_花弁3CP = new ColorP(this.X0Y0_花_ユリ_通常_花弁3, this.花_ユリ_花弁3CD, DisUnit, true);
			this.X0Y0_花_ユリ_通常_萼1_萼2CP = new ColorP(this.X0Y0_花_ユリ_通常_萼1_萼2, this.花_ユリ_萼1_萼2CD, DisUnit, true);
			this.X0Y0_花_ユリ_通常_萼1_萼1CP = new ColorP(this.X0Y0_花_ユリ_通常_萼1_萼1, this.花_ユリ_萼1_萼1CD, DisUnit, true);
			this.X0Y0_花_ユリ_欠損_萼2CP = new ColorP(this.X0Y0_花_ユリ_欠損_萼2, this.花_ユリ_萼2CD, DisUnit, true);
			this.X0Y0_花_ユリ_欠損_萼3CP = new ColorP(this.X0Y0_花_ユリ_欠損_萼3, this.花_ユリ_萼3CD, DisUnit, true);
			this.X0Y0_花_ユリ_欠損_花弁1CP = new ColorP(this.X0Y0_花_ユリ_欠損_花弁1, this.花_ユリ_花弁1CD, DisUnit, true);
			this.X0Y0_花_ユリ_欠損_蕊_雄蕊中後_葯CP = new ColorP(this.X0Y0_花_ユリ_欠損_蕊_雄蕊中後_葯, this.花_ユリ_蕊_雄蕊中後_葯CD, DisUnit, true);
			this.X0Y0_花_ユリ_欠損_蕊_雄蕊中後_雄蕊CP = new ColorP(this.X0Y0_花_ユリ_欠損_蕊_雄蕊中後_雄蕊, this.花_ユリ_蕊_雄蕊中後_雄蕊CD, DisUnit, true);
			this.X0Y0_花_ユリ_欠損_蕊_雌蕊_雌蕊CP = new ColorP(this.X0Y0_花_ユリ_欠損_蕊_雌蕊_雌蕊, this.花_ユリ_蕊_雌蕊_雌蕊CD, DisUnit, true);
			this.X0Y0_花_ユリ_欠損_蕊_雌蕊_柱頭CP = new ColorP(this.X0Y0_花_ユリ_欠損_蕊_雌蕊_柱頭, this.花_ユリ_蕊_雌蕊_柱頭CD, DisUnit, true);
			this.X0Y0_花_ユリ_欠損_蕊_雄蕊左2_葯CP = new ColorP(this.X0Y0_花_ユリ_欠損_蕊_雄蕊左2_葯, this.花_ユリ_蕊_雄蕊左2_葯CD, DisUnit, true);
			this.X0Y0_花_ユリ_欠損_蕊_雄蕊左2_雄蕊CP = new ColorP(this.X0Y0_花_ユリ_欠損_蕊_雄蕊左2_雄蕊, this.花_ユリ_蕊_雄蕊左2_雄蕊CD, DisUnit, true);
			this.X0Y0_花_ユリ_欠損_蕊_雄蕊右2_葯CP = new ColorP(this.X0Y0_花_ユリ_欠損_蕊_雄蕊右2_葯, this.花_ユリ_蕊_雄蕊右2_葯CD, DisUnit, true);
			this.X0Y0_花_ユリ_欠損_蕊_雄蕊右2_雄蕊CP = new ColorP(this.X0Y0_花_ユリ_欠損_蕊_雄蕊右2_雄蕊, this.花_ユリ_蕊_雄蕊右2_雄蕊CD, DisUnit, true);
			this.X0Y0_花_ユリ_欠損_蕊_雄蕊左1_雄蕊CP = new ColorP(this.X0Y0_花_ユリ_欠損_蕊_雄蕊左1_雄蕊, this.花_ユリ_蕊_雄蕊左1_雄蕊CD, DisUnit, true);
			this.X0Y0_花_ユリ_欠損_蕊_雄蕊左1_葯CP = new ColorP(this.X0Y0_花_ユリ_欠損_蕊_雄蕊左1_葯, this.花_ユリ_蕊_雄蕊左1_葯CD, DisUnit, true);
			this.X0Y0_花_ユリ_欠損_蕊_雄蕊右1_雄蕊CP = new ColorP(this.X0Y0_花_ユリ_欠損_蕊_雄蕊右1_雄蕊, this.花_ユリ_蕊_雄蕊右1_雄蕊CD, DisUnit, true);
			this.X0Y0_花_ユリ_欠損_蕊_雄蕊右1_葯CP = new ColorP(this.X0Y0_花_ユリ_欠損_蕊_雄蕊右1_葯, this.花_ユリ_蕊_雄蕊右1_葯CD, DisUnit, true);
			this.X0Y0_花_ユリ_欠損_蕊_雄蕊中前_雄蕊CP = new ColorP(this.X0Y0_花_ユリ_欠損_蕊_雄蕊中前_雄蕊, this.花_ユリ_蕊_雄蕊中前_雄蕊CD, DisUnit, true);
			this.X0Y0_花_ユリ_欠損_蕊_雄蕊中前_葯CP = new ColorP(this.X0Y0_花_ユリ_欠損_蕊_雄蕊中前_葯, this.花_ユリ_蕊_雄蕊中前_葯CD, DisUnit, true);
			this.X0Y0_花_ユリ_欠損_花弁2CP = new ColorP(this.X0Y0_花_ユリ_欠損_花弁2, this.花_ユリ_花弁2CD, DisUnit, true);
			this.X0Y0_花_ユリ_欠損_花弁3CP = new ColorP(this.X0Y0_花_ユリ_欠損_花弁3, this.花_ユリ_花弁3CD, DisUnit, true);
			this.X0Y0_花_ユリ_欠損_萼1_萼2CP = new ColorP(this.X0Y0_花_ユリ_欠損_萼1_萼2, this.花_ユリ_萼1_萼2CD, DisUnit, true);
			this.X0Y0_花_ユリ_欠損_萼1_萼1CP = new ColorP(this.X0Y0_花_ユリ_欠損_萼1_萼1, this.花_ユリ_萼1_萼1CD, DisUnit, true);
			this.X0Y0_萼_通常_萼CP = new ColorP(this.X0Y0_萼_通常_萼, this.萼_萼CD, DisUnit, true);
			this.X0Y0_萼_欠損_萼CP = new ColorP(this.X0Y0_萼_欠損_萼, this.萼_萼CD, DisUnit, true);
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
				this.花_ユリ_萼2_表示 = this.花_ユリ_萼2_表示;
				this.花_ユリ_萼3_表示 = this.花_ユリ_萼3_表示;
				this.花_ユリ_花弁1_表示 = this.花_ユリ_花弁1_表示;
				this.花_ユリ_蕊_雄蕊中後_葯_表示 = this.花_ユリ_蕊_雄蕊中後_葯_表示;
				this.花_ユリ_蕊_雄蕊中後_雄蕊_表示 = this.花_ユリ_蕊_雄蕊中後_雄蕊_表示;
				this.花_ユリ_蕊_雌蕊_雌蕊_表示 = this.花_ユリ_蕊_雌蕊_雌蕊_表示;
				this.花_ユリ_蕊_雌蕊_柱頭_表示 = this.花_ユリ_蕊_雌蕊_柱頭_表示;
				this.花_ユリ_蕊_雄蕊左2_葯_表示 = this.花_ユリ_蕊_雄蕊左2_葯_表示;
				this.花_ユリ_蕊_雄蕊左2_雄蕊_表示 = this.花_ユリ_蕊_雄蕊左2_雄蕊_表示;
				this.花_ユリ_蕊_雄蕊右2_葯_表示 = this.花_ユリ_蕊_雄蕊右2_葯_表示;
				this.花_ユリ_蕊_雄蕊右2_雄蕊_表示 = this.花_ユリ_蕊_雄蕊右2_雄蕊_表示;
				this.花_ユリ_蕊_雄蕊左1_雄蕊_表示 = this.花_ユリ_蕊_雄蕊左1_雄蕊_表示;
				this.花_ユリ_蕊_雄蕊左1_葯_表示 = this.花_ユリ_蕊_雄蕊左1_葯_表示;
				this.花_ユリ_蕊_雄蕊右1_雄蕊_表示 = this.花_ユリ_蕊_雄蕊右1_雄蕊_表示;
				this.花_ユリ_蕊_雄蕊右1_葯_表示 = this.花_ユリ_蕊_雄蕊右1_葯_表示;
				this.花_ユリ_蕊_雄蕊中前_雄蕊_表示 = this.花_ユリ_蕊_雄蕊中前_雄蕊_表示;
				this.花_ユリ_蕊_雄蕊中前_葯_表示 = this.花_ユリ_蕊_雄蕊中前_葯_表示;
				this.花_ユリ_花弁2_表示 = this.花_ユリ_花弁2_表示;
				this.花_ユリ_花弁3_表示 = this.花_ユリ_花弁3_表示;
				this.花_ユリ_萼1_萼2_表示 = this.花_ユリ_萼1_萼2_表示;
				this.花_ユリ_萼1_萼1_表示 = this.花_ユリ_萼1_萼1_表示;
				this.萼_萼_表示 = this.萼_萼_表示;
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

		public bool 花_ユリ_通常_萼2_表示
		{
			get
			{
				return this.X0Y0_花_ユリ_通常_萼2.Dra;
			}
			set
			{
				this.X0Y0_花_ユリ_通常_萼2.Dra = value;
				this.X0Y0_花_ユリ_通常_萼2.Hit = value;
			}
		}

		public bool 花_ユリ_通常_萼3_表示
		{
			get
			{
				return this.X0Y0_花_ユリ_通常_萼3.Dra;
			}
			set
			{
				this.X0Y0_花_ユリ_通常_萼3.Dra = value;
				this.X0Y0_花_ユリ_通常_萼3.Hit = value;
			}
		}

		public bool 花_ユリ_通常_花弁1_表示
		{
			get
			{
				return this.X0Y0_花_ユリ_通常_花弁1.Dra;
			}
			set
			{
				this.X0Y0_花_ユリ_通常_花弁1.Dra = value;
				this.X0Y0_花_ユリ_通常_花弁1.Hit = value;
			}
		}

		public bool 花_ユリ_通常_蕊_雄蕊中後_葯_表示
		{
			get
			{
				return this.X0Y0_花_ユリ_通常_蕊_雄蕊中後_葯.Dra;
			}
			set
			{
				this.X0Y0_花_ユリ_通常_蕊_雄蕊中後_葯.Dra = value;
				this.X0Y0_花_ユリ_通常_蕊_雄蕊中後_葯.Hit = value;
			}
		}

		public bool 花_ユリ_通常_蕊_雄蕊中後_雄蕊_表示
		{
			get
			{
				return this.X0Y0_花_ユリ_通常_蕊_雄蕊中後_雄蕊.Dra;
			}
			set
			{
				this.X0Y0_花_ユリ_通常_蕊_雄蕊中後_雄蕊.Dra = value;
				this.X0Y0_花_ユリ_通常_蕊_雄蕊中後_雄蕊.Hit = value;
			}
		}

		public bool 花_ユリ_通常_蕊_雌蕊_雌蕊_表示
		{
			get
			{
				return this.X0Y0_花_ユリ_通常_蕊_雌蕊_雌蕊.Dra;
			}
			set
			{
				this.X0Y0_花_ユリ_通常_蕊_雌蕊_雌蕊.Dra = value;
				this.X0Y0_花_ユリ_通常_蕊_雌蕊_雌蕊.Hit = value;
			}
		}

		public bool 花_ユリ_通常_蕊_雌蕊_柱頭_表示
		{
			get
			{
				return this.X0Y0_花_ユリ_通常_蕊_雌蕊_柱頭.Dra;
			}
			set
			{
				this.X0Y0_花_ユリ_通常_蕊_雌蕊_柱頭.Dra = value;
				this.X0Y0_花_ユリ_通常_蕊_雌蕊_柱頭.Hit = value;
			}
		}

		public bool 花_ユリ_通常_蕊_雄蕊左2_葯_表示
		{
			get
			{
				return this.X0Y0_花_ユリ_通常_蕊_雄蕊左2_葯.Dra;
			}
			set
			{
				this.X0Y0_花_ユリ_通常_蕊_雄蕊左2_葯.Dra = value;
				this.X0Y0_花_ユリ_通常_蕊_雄蕊左2_葯.Hit = value;
			}
		}

		public bool 花_ユリ_通常_蕊_雄蕊左2_雄蕊_表示
		{
			get
			{
				return this.X0Y0_花_ユリ_通常_蕊_雄蕊左2_雄蕊.Dra;
			}
			set
			{
				this.X0Y0_花_ユリ_通常_蕊_雄蕊左2_雄蕊.Dra = value;
				this.X0Y0_花_ユリ_通常_蕊_雄蕊左2_雄蕊.Hit = value;
			}
		}

		public bool 花_ユリ_通常_蕊_雄蕊右2_葯_表示
		{
			get
			{
				return this.X0Y0_花_ユリ_通常_蕊_雄蕊右2_葯.Dra;
			}
			set
			{
				this.X0Y0_花_ユリ_通常_蕊_雄蕊右2_葯.Dra = value;
				this.X0Y0_花_ユリ_通常_蕊_雄蕊右2_葯.Hit = value;
			}
		}

		public bool 花_ユリ_通常_蕊_雄蕊右2_雄蕊_表示
		{
			get
			{
				return this.X0Y0_花_ユリ_通常_蕊_雄蕊右2_雄蕊.Dra;
			}
			set
			{
				this.X0Y0_花_ユリ_通常_蕊_雄蕊右2_雄蕊.Dra = value;
				this.X0Y0_花_ユリ_通常_蕊_雄蕊右2_雄蕊.Hit = value;
			}
		}

		public bool 花_ユリ_通常_蕊_雄蕊左1_雄蕊_表示
		{
			get
			{
				return this.X0Y0_花_ユリ_通常_蕊_雄蕊左1_雄蕊.Dra;
			}
			set
			{
				this.X0Y0_花_ユリ_通常_蕊_雄蕊左1_雄蕊.Dra = value;
				this.X0Y0_花_ユリ_通常_蕊_雄蕊左1_雄蕊.Hit = value;
			}
		}

		public bool 花_ユリ_通常_蕊_雄蕊左1_葯_表示
		{
			get
			{
				return this.X0Y0_花_ユリ_通常_蕊_雄蕊左1_葯.Dra;
			}
			set
			{
				this.X0Y0_花_ユリ_通常_蕊_雄蕊左1_葯.Dra = value;
				this.X0Y0_花_ユリ_通常_蕊_雄蕊左1_葯.Hit = value;
			}
		}

		public bool 花_ユリ_通常_蕊_雄蕊右1_雄蕊_表示
		{
			get
			{
				return this.X0Y0_花_ユリ_通常_蕊_雄蕊右1_雄蕊.Dra;
			}
			set
			{
				this.X0Y0_花_ユリ_通常_蕊_雄蕊右1_雄蕊.Dra = value;
				this.X0Y0_花_ユリ_通常_蕊_雄蕊右1_雄蕊.Hit = value;
			}
		}

		public bool 花_ユリ_通常_蕊_雄蕊右1_葯_表示
		{
			get
			{
				return this.X0Y0_花_ユリ_通常_蕊_雄蕊右1_葯.Dra;
			}
			set
			{
				this.X0Y0_花_ユリ_通常_蕊_雄蕊右1_葯.Dra = value;
				this.X0Y0_花_ユリ_通常_蕊_雄蕊右1_葯.Hit = value;
			}
		}

		public bool 花_ユリ_通常_蕊_雄蕊中前_雄蕊_表示
		{
			get
			{
				return this.X0Y0_花_ユリ_通常_蕊_雄蕊中前_雄蕊.Dra;
			}
			set
			{
				this.X0Y0_花_ユリ_通常_蕊_雄蕊中前_雄蕊.Dra = value;
				this.X0Y0_花_ユリ_通常_蕊_雄蕊中前_雄蕊.Hit = value;
			}
		}

		public bool 花_ユリ_通常_蕊_雄蕊中前_葯_表示
		{
			get
			{
				return this.X0Y0_花_ユリ_通常_蕊_雄蕊中前_葯.Dra;
			}
			set
			{
				this.X0Y0_花_ユリ_通常_蕊_雄蕊中前_葯.Dra = value;
				this.X0Y0_花_ユリ_通常_蕊_雄蕊中前_葯.Hit = value;
			}
		}

		public bool 花_ユリ_通常_花弁2_表示
		{
			get
			{
				return this.X0Y0_花_ユリ_通常_花弁2.Dra;
			}
			set
			{
				this.X0Y0_花_ユリ_通常_花弁2.Dra = value;
				this.X0Y0_花_ユリ_通常_花弁2.Hit = value;
			}
		}

		public bool 花_ユリ_通常_花弁3_表示
		{
			get
			{
				return this.X0Y0_花_ユリ_通常_花弁3.Dra;
			}
			set
			{
				this.X0Y0_花_ユリ_通常_花弁3.Dra = value;
				this.X0Y0_花_ユリ_通常_花弁3.Hit = value;
			}
		}

		public bool 花_ユリ_通常_萼1_萼2_表示
		{
			get
			{
				return this.X0Y0_花_ユリ_通常_萼1_萼2.Dra;
			}
			set
			{
				this.X0Y0_花_ユリ_通常_萼1_萼2.Dra = value;
				this.X0Y0_花_ユリ_通常_萼1_萼2.Hit = value;
			}
		}

		public bool 花_ユリ_通常_萼1_萼1_表示
		{
			get
			{
				return this.X0Y0_花_ユリ_通常_萼1_萼1.Dra;
			}
			set
			{
				this.X0Y0_花_ユリ_通常_萼1_萼1.Dra = value;
				this.X0Y0_花_ユリ_通常_萼1_萼1.Hit = value;
			}
		}

		public bool 花_ユリ_欠損_萼2_表示
		{
			get
			{
				return this.X0Y0_花_ユリ_欠損_萼2.Dra;
			}
			set
			{
				this.X0Y0_花_ユリ_欠損_萼2.Dra = value;
				this.X0Y0_花_ユリ_欠損_萼2.Hit = value;
			}
		}

		public bool 花_ユリ_欠損_萼3_表示
		{
			get
			{
				return this.X0Y0_花_ユリ_欠損_萼3.Dra;
			}
			set
			{
				this.X0Y0_花_ユリ_欠損_萼3.Dra = value;
				this.X0Y0_花_ユリ_欠損_萼3.Hit = value;
			}
		}

		public bool 花_ユリ_欠損_花弁1_表示
		{
			get
			{
				return this.X0Y0_花_ユリ_欠損_花弁1.Dra;
			}
			set
			{
				this.X0Y0_花_ユリ_欠損_花弁1.Dra = value;
				this.X0Y0_花_ユリ_欠損_花弁1.Hit = value;
			}
		}

		public bool 花_ユリ_欠損_蕊_雄蕊中後_葯_表示
		{
			get
			{
				return this.X0Y0_花_ユリ_欠損_蕊_雄蕊中後_葯.Dra;
			}
			set
			{
				this.X0Y0_花_ユリ_欠損_蕊_雄蕊中後_葯.Dra = value;
				this.X0Y0_花_ユリ_欠損_蕊_雄蕊中後_葯.Hit = value;
			}
		}

		public bool 花_ユリ_欠損_蕊_雄蕊中後_雄蕊_表示
		{
			get
			{
				return this.X0Y0_花_ユリ_欠損_蕊_雄蕊中後_雄蕊.Dra;
			}
			set
			{
				this.X0Y0_花_ユリ_欠損_蕊_雄蕊中後_雄蕊.Dra = value;
				this.X0Y0_花_ユリ_欠損_蕊_雄蕊中後_雄蕊.Hit = value;
			}
		}

		public bool 花_ユリ_欠損_蕊_雌蕊_雌蕊_表示
		{
			get
			{
				return this.X0Y0_花_ユリ_欠損_蕊_雌蕊_雌蕊.Dra;
			}
			set
			{
				this.X0Y0_花_ユリ_欠損_蕊_雌蕊_雌蕊.Dra = value;
				this.X0Y0_花_ユリ_欠損_蕊_雌蕊_雌蕊.Hit = value;
			}
		}

		public bool 花_ユリ_欠損_蕊_雌蕊_柱頭_表示
		{
			get
			{
				return this.X0Y0_花_ユリ_欠損_蕊_雌蕊_柱頭.Dra;
			}
			set
			{
				this.X0Y0_花_ユリ_欠損_蕊_雌蕊_柱頭.Dra = value;
				this.X0Y0_花_ユリ_欠損_蕊_雌蕊_柱頭.Hit = value;
			}
		}

		public bool 花_ユリ_欠損_蕊_雄蕊左2_葯_表示
		{
			get
			{
				return this.X0Y0_花_ユリ_欠損_蕊_雄蕊左2_葯.Dra;
			}
			set
			{
				this.X0Y0_花_ユリ_欠損_蕊_雄蕊左2_葯.Dra = value;
				this.X0Y0_花_ユリ_欠損_蕊_雄蕊左2_葯.Hit = value;
			}
		}

		public bool 花_ユリ_欠損_蕊_雄蕊左2_雄蕊_表示
		{
			get
			{
				return this.X0Y0_花_ユリ_欠損_蕊_雄蕊左2_雄蕊.Dra;
			}
			set
			{
				this.X0Y0_花_ユリ_欠損_蕊_雄蕊左2_雄蕊.Dra = value;
				this.X0Y0_花_ユリ_欠損_蕊_雄蕊左2_雄蕊.Hit = value;
			}
		}

		public bool 花_ユリ_欠損_蕊_雄蕊右2_葯_表示
		{
			get
			{
				return this.X0Y0_花_ユリ_欠損_蕊_雄蕊右2_葯.Dra;
			}
			set
			{
				this.X0Y0_花_ユリ_欠損_蕊_雄蕊右2_葯.Dra = value;
				this.X0Y0_花_ユリ_欠損_蕊_雄蕊右2_葯.Hit = value;
			}
		}

		public bool 花_ユリ_欠損_蕊_雄蕊右2_雄蕊_表示
		{
			get
			{
				return this.X0Y0_花_ユリ_欠損_蕊_雄蕊右2_雄蕊.Dra;
			}
			set
			{
				this.X0Y0_花_ユリ_欠損_蕊_雄蕊右2_雄蕊.Dra = value;
				this.X0Y0_花_ユリ_欠損_蕊_雄蕊右2_雄蕊.Hit = value;
			}
		}

		public bool 花_ユリ_欠損_蕊_雄蕊左1_雄蕊_表示
		{
			get
			{
				return this.X0Y0_花_ユリ_欠損_蕊_雄蕊左1_雄蕊.Dra;
			}
			set
			{
				this.X0Y0_花_ユリ_欠損_蕊_雄蕊左1_雄蕊.Dra = value;
				this.X0Y0_花_ユリ_欠損_蕊_雄蕊左1_雄蕊.Hit = value;
			}
		}

		public bool 花_ユリ_欠損_蕊_雄蕊左1_葯_表示
		{
			get
			{
				return this.X0Y0_花_ユリ_欠損_蕊_雄蕊左1_葯.Dra;
			}
			set
			{
				this.X0Y0_花_ユリ_欠損_蕊_雄蕊左1_葯.Dra = value;
				this.X0Y0_花_ユリ_欠損_蕊_雄蕊左1_葯.Hit = value;
			}
		}

		public bool 花_ユリ_欠損_蕊_雄蕊右1_雄蕊_表示
		{
			get
			{
				return this.X0Y0_花_ユリ_欠損_蕊_雄蕊右1_雄蕊.Dra;
			}
			set
			{
				this.X0Y0_花_ユリ_欠損_蕊_雄蕊右1_雄蕊.Dra = value;
				this.X0Y0_花_ユリ_欠損_蕊_雄蕊右1_雄蕊.Hit = value;
			}
		}

		public bool 花_ユリ_欠損_蕊_雄蕊右1_葯_表示
		{
			get
			{
				return this.X0Y0_花_ユリ_欠損_蕊_雄蕊右1_葯.Dra;
			}
			set
			{
				this.X0Y0_花_ユリ_欠損_蕊_雄蕊右1_葯.Dra = value;
				this.X0Y0_花_ユリ_欠損_蕊_雄蕊右1_葯.Hit = value;
			}
		}

		public bool 花_ユリ_欠損_蕊_雄蕊中前_雄蕊_表示
		{
			get
			{
				return this.X0Y0_花_ユリ_欠損_蕊_雄蕊中前_雄蕊.Dra;
			}
			set
			{
				this.X0Y0_花_ユリ_欠損_蕊_雄蕊中前_雄蕊.Dra = value;
				this.X0Y0_花_ユリ_欠損_蕊_雄蕊中前_雄蕊.Hit = value;
			}
		}

		public bool 花_ユリ_欠損_蕊_雄蕊中前_葯_表示
		{
			get
			{
				return this.X0Y0_花_ユリ_欠損_蕊_雄蕊中前_葯.Dra;
			}
			set
			{
				this.X0Y0_花_ユリ_欠損_蕊_雄蕊中前_葯.Dra = value;
				this.X0Y0_花_ユリ_欠損_蕊_雄蕊中前_葯.Hit = value;
			}
		}

		public bool 花_ユリ_欠損_花弁2_表示
		{
			get
			{
				return this.X0Y0_花_ユリ_欠損_花弁2.Dra;
			}
			set
			{
				this.X0Y0_花_ユリ_欠損_花弁2.Dra = value;
				this.X0Y0_花_ユリ_欠損_花弁2.Hit = value;
			}
		}

		public bool 花_ユリ_欠損_花弁3_表示
		{
			get
			{
				return this.X0Y0_花_ユリ_欠損_花弁3.Dra;
			}
			set
			{
				this.X0Y0_花_ユリ_欠損_花弁3.Dra = value;
				this.X0Y0_花_ユリ_欠損_花弁3.Hit = value;
			}
		}

		public bool 花_ユリ_欠損_萼1_萼2_表示
		{
			get
			{
				return this.X0Y0_花_ユリ_欠損_萼1_萼2.Dra;
			}
			set
			{
				this.X0Y0_花_ユリ_欠損_萼1_萼2.Dra = value;
				this.X0Y0_花_ユリ_欠損_萼1_萼2.Hit = value;
			}
		}

		public bool 花_ユリ_欠損_萼1_萼1_表示
		{
			get
			{
				return this.X0Y0_花_ユリ_欠損_萼1_萼1.Dra;
			}
			set
			{
				this.X0Y0_花_ユリ_欠損_萼1_萼1.Dra = value;
				this.X0Y0_花_ユリ_欠損_萼1_萼1.Hit = value;
			}
		}

		public bool 萼_通常_萼_表示
		{
			get
			{
				return this.X0Y0_萼_通常_萼.Dra;
			}
			set
			{
				this.X0Y0_萼_通常_萼.Dra = value;
				this.X0Y0_萼_通常_萼.Hit = value;
			}
		}

		public bool 萼_欠損_萼_表示
		{
			get
			{
				return this.X0Y0_萼_欠損_萼.Dra;
			}
			set
			{
				this.X0Y0_萼_欠損_萼.Dra = value;
				this.X0Y0_萼_欠損_萼.Hit = value;
			}
		}

		public bool 花_ユリ_萼2_表示
		{
			get
			{
				return this.花_ユリ_通常_萼2_表示 || this.花_ユリ_欠損_萼2_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.花_ユリ_通常_萼2_表示 = false;
					this.花_ユリ_欠損_萼2_表示 = value;
					return;
				}
				this.花_ユリ_通常_萼2_表示 = value;
				this.花_ユリ_欠損_萼2_表示 = false;
			}
		}

		public bool 花_ユリ_萼3_表示
		{
			get
			{
				return this.花_ユリ_通常_萼3_表示 || this.花_ユリ_欠損_萼3_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.花_ユリ_通常_萼3_表示 = false;
					this.花_ユリ_欠損_萼3_表示 = value;
					return;
				}
				this.花_ユリ_通常_萼3_表示 = value;
				this.花_ユリ_欠損_萼3_表示 = false;
			}
		}

		public bool 花_ユリ_花弁1_表示
		{
			get
			{
				return this.花_ユリ_通常_花弁1_表示 || this.花_ユリ_欠損_花弁1_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.花_ユリ_通常_花弁1_表示 = false;
					this.花_ユリ_欠損_花弁1_表示 = value;
					return;
				}
				this.花_ユリ_通常_花弁1_表示 = value;
				this.花_ユリ_欠損_花弁1_表示 = false;
			}
		}

		public bool 花_ユリ_蕊_雄蕊中後_葯_表示
		{
			get
			{
				return this.花_ユリ_通常_蕊_雄蕊中後_葯_表示 || this.花_ユリ_欠損_蕊_雄蕊中後_葯_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.花_ユリ_通常_蕊_雄蕊中後_葯_表示 = false;
					this.花_ユリ_欠損_蕊_雄蕊中後_葯_表示 = value;
					return;
				}
				this.花_ユリ_通常_蕊_雄蕊中後_葯_表示 = value;
				this.花_ユリ_欠損_蕊_雄蕊中後_葯_表示 = false;
			}
		}

		public bool 花_ユリ_蕊_雄蕊中後_雄蕊_表示
		{
			get
			{
				return this.花_ユリ_通常_蕊_雄蕊中後_雄蕊_表示 || this.花_ユリ_欠損_蕊_雄蕊中後_雄蕊_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.花_ユリ_通常_蕊_雄蕊中後_雄蕊_表示 = false;
					this.花_ユリ_欠損_蕊_雄蕊中後_雄蕊_表示 = value;
					return;
				}
				this.花_ユリ_通常_蕊_雄蕊中後_雄蕊_表示 = value;
				this.花_ユリ_欠損_蕊_雄蕊中後_雄蕊_表示 = false;
			}
		}

		public bool 花_ユリ_蕊_雌蕊_雌蕊_表示
		{
			get
			{
				return this.花_ユリ_通常_蕊_雌蕊_雌蕊_表示 || this.花_ユリ_欠損_蕊_雌蕊_雌蕊_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.花_ユリ_通常_蕊_雌蕊_雌蕊_表示 = false;
					this.花_ユリ_欠損_蕊_雌蕊_雌蕊_表示 = value;
					return;
				}
				this.花_ユリ_通常_蕊_雌蕊_雌蕊_表示 = value;
				this.花_ユリ_欠損_蕊_雌蕊_雌蕊_表示 = false;
			}
		}

		public bool 花_ユリ_蕊_雌蕊_柱頭_表示
		{
			get
			{
				return this.花_ユリ_通常_蕊_雌蕊_柱頭_表示 || this.花_ユリ_欠損_蕊_雌蕊_柱頭_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.花_ユリ_通常_蕊_雌蕊_柱頭_表示 = false;
					this.花_ユリ_欠損_蕊_雌蕊_柱頭_表示 = value;
					return;
				}
				this.花_ユリ_通常_蕊_雌蕊_柱頭_表示 = value;
				this.花_ユリ_欠損_蕊_雌蕊_柱頭_表示 = false;
			}
		}

		public bool 花_ユリ_蕊_雄蕊左2_葯_表示
		{
			get
			{
				return this.花_ユリ_通常_蕊_雄蕊左2_葯_表示 || this.花_ユリ_欠損_蕊_雄蕊左2_葯_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.花_ユリ_通常_蕊_雄蕊左2_葯_表示 = false;
					this.花_ユリ_欠損_蕊_雄蕊左2_葯_表示 = value;
					return;
				}
				this.花_ユリ_通常_蕊_雄蕊左2_葯_表示 = value;
				this.花_ユリ_欠損_蕊_雄蕊左2_葯_表示 = false;
			}
		}

		public bool 花_ユリ_蕊_雄蕊左2_雄蕊_表示
		{
			get
			{
				return this.花_ユリ_通常_蕊_雄蕊左2_雄蕊_表示 || this.花_ユリ_欠損_蕊_雄蕊左2_雄蕊_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.花_ユリ_通常_蕊_雄蕊左2_雄蕊_表示 = false;
					this.花_ユリ_欠損_蕊_雄蕊左2_雄蕊_表示 = value;
					return;
				}
				this.花_ユリ_通常_蕊_雄蕊左2_雄蕊_表示 = value;
				this.花_ユリ_欠損_蕊_雄蕊左2_雄蕊_表示 = false;
			}
		}

		public bool 花_ユリ_蕊_雄蕊右2_葯_表示
		{
			get
			{
				return this.花_ユリ_通常_蕊_雄蕊右2_葯_表示 || this.花_ユリ_欠損_蕊_雄蕊右2_葯_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.花_ユリ_通常_蕊_雄蕊右2_葯_表示 = false;
					this.花_ユリ_欠損_蕊_雄蕊右2_葯_表示 = value;
					return;
				}
				this.花_ユリ_通常_蕊_雄蕊右2_葯_表示 = value;
				this.花_ユリ_欠損_蕊_雄蕊右2_葯_表示 = false;
			}
		}

		public bool 花_ユリ_蕊_雄蕊右2_雄蕊_表示
		{
			get
			{
				return this.花_ユリ_通常_蕊_雄蕊右2_雄蕊_表示 || this.花_ユリ_欠損_蕊_雄蕊右2_雄蕊_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.花_ユリ_通常_蕊_雄蕊右2_雄蕊_表示 = false;
					this.花_ユリ_欠損_蕊_雄蕊右2_雄蕊_表示 = value;
					return;
				}
				this.花_ユリ_通常_蕊_雄蕊右2_雄蕊_表示 = value;
				this.花_ユリ_欠損_蕊_雄蕊右2_雄蕊_表示 = false;
			}
		}

		public bool 花_ユリ_蕊_雄蕊左1_雄蕊_表示
		{
			get
			{
				return this.花_ユリ_通常_蕊_雄蕊左1_雄蕊_表示 || this.花_ユリ_欠損_蕊_雄蕊左1_雄蕊_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.花_ユリ_通常_蕊_雄蕊左1_雄蕊_表示 = false;
					this.花_ユリ_欠損_蕊_雄蕊左1_雄蕊_表示 = value;
					return;
				}
				this.花_ユリ_通常_蕊_雄蕊左1_雄蕊_表示 = value;
				this.花_ユリ_欠損_蕊_雄蕊左1_雄蕊_表示 = false;
			}
		}

		public bool 花_ユリ_蕊_雄蕊左1_葯_表示
		{
			get
			{
				return this.花_ユリ_通常_蕊_雄蕊左1_葯_表示 || this.花_ユリ_欠損_蕊_雄蕊左1_葯_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.花_ユリ_通常_蕊_雄蕊左1_葯_表示 = false;
					this.花_ユリ_欠損_蕊_雄蕊左1_葯_表示 = value;
					return;
				}
				this.花_ユリ_通常_蕊_雄蕊左1_葯_表示 = value;
				this.花_ユリ_欠損_蕊_雄蕊左1_葯_表示 = false;
			}
		}

		public bool 花_ユリ_蕊_雄蕊右1_雄蕊_表示
		{
			get
			{
				return this.花_ユリ_通常_蕊_雄蕊右1_雄蕊_表示 || this.花_ユリ_欠損_蕊_雄蕊右1_雄蕊_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.花_ユリ_通常_蕊_雄蕊右1_雄蕊_表示 = false;
					this.花_ユリ_欠損_蕊_雄蕊右1_雄蕊_表示 = value;
					return;
				}
				this.花_ユリ_通常_蕊_雄蕊右1_雄蕊_表示 = value;
				this.花_ユリ_欠損_蕊_雄蕊右1_雄蕊_表示 = false;
			}
		}

		public bool 花_ユリ_蕊_雄蕊右1_葯_表示
		{
			get
			{
				return this.花_ユリ_通常_蕊_雄蕊右1_葯_表示 || this.花_ユリ_欠損_蕊_雄蕊右1_葯_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.花_ユリ_通常_蕊_雄蕊右1_葯_表示 = false;
					this.花_ユリ_欠損_蕊_雄蕊右1_葯_表示 = value;
					return;
				}
				this.花_ユリ_通常_蕊_雄蕊右1_葯_表示 = value;
				this.花_ユリ_欠損_蕊_雄蕊右1_葯_表示 = false;
			}
		}

		public bool 花_ユリ_蕊_雄蕊中前_雄蕊_表示
		{
			get
			{
				return this.花_ユリ_通常_蕊_雄蕊中前_雄蕊_表示 || this.花_ユリ_欠損_蕊_雄蕊中前_雄蕊_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.花_ユリ_通常_蕊_雄蕊中前_雄蕊_表示 = false;
					this.花_ユリ_欠損_蕊_雄蕊中前_雄蕊_表示 = value;
					return;
				}
				this.花_ユリ_通常_蕊_雄蕊中前_雄蕊_表示 = value;
				this.花_ユリ_欠損_蕊_雄蕊中前_雄蕊_表示 = false;
			}
		}

		public bool 花_ユリ_蕊_雄蕊中前_葯_表示
		{
			get
			{
				return this.花_ユリ_通常_蕊_雄蕊中前_葯_表示 || this.花_ユリ_欠損_蕊_雄蕊中前_葯_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.花_ユリ_通常_蕊_雄蕊中前_葯_表示 = false;
					this.花_ユリ_欠損_蕊_雄蕊中前_葯_表示 = value;
					return;
				}
				this.花_ユリ_通常_蕊_雄蕊中前_葯_表示 = value;
				this.花_ユリ_欠損_蕊_雄蕊中前_葯_表示 = false;
			}
		}

		public bool 花_ユリ_花弁2_表示
		{
			get
			{
				return this.花_ユリ_通常_花弁2_表示 || this.花_ユリ_欠損_花弁2_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.花_ユリ_通常_花弁2_表示 = false;
					this.花_ユリ_欠損_花弁2_表示 = value;
					return;
				}
				this.花_ユリ_通常_花弁2_表示 = value;
				this.花_ユリ_欠損_花弁2_表示 = false;
			}
		}

		public bool 花_ユリ_花弁3_表示
		{
			get
			{
				return this.花_ユリ_通常_花弁3_表示 || this.花_ユリ_欠損_花弁3_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.花_ユリ_通常_花弁3_表示 = false;
					this.花_ユリ_欠損_花弁3_表示 = value;
					return;
				}
				this.花_ユリ_通常_花弁3_表示 = value;
				this.花_ユリ_欠損_花弁3_表示 = false;
			}
		}

		public bool 花_ユリ_萼1_萼2_表示
		{
			get
			{
				return this.花_ユリ_通常_萼1_萼2_表示 || this.花_ユリ_欠損_萼1_萼2_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.花_ユリ_通常_萼1_萼2_表示 = false;
					this.花_ユリ_欠損_萼1_萼2_表示 = value;
					return;
				}
				this.花_ユリ_通常_萼1_萼2_表示 = value;
				this.花_ユリ_欠損_萼1_萼2_表示 = false;
			}
		}

		public bool 花_ユリ_萼1_萼1_表示
		{
			get
			{
				return this.花_ユリ_通常_萼1_萼1_表示 || this.花_ユリ_欠損_萼1_萼1_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.花_ユリ_通常_萼1_萼1_表示 = false;
					this.花_ユリ_欠損_萼1_萼1_表示 = value;
					return;
				}
				this.花_ユリ_通常_萼1_萼1_表示 = value;
				this.花_ユリ_欠損_萼1_萼1_表示 = false;
			}
		}

		public bool 萼_萼_表示
		{
			get
			{
				return this.萼_通常_萼_表示 || this.萼_欠損_萼_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.萼_通常_萼_表示 = false;
					this.萼_欠損_萼_表示 = value;
					return;
				}
				this.萼_通常_萼_表示 = value;
				this.萼_欠損_萼_表示 = false;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.花_ユリ_通常_萼2_表示;
			}
			set
			{
				this.花_ユリ_通常_萼2_表示 = value;
				this.花_ユリ_通常_萼3_表示 = value;
				this.花_ユリ_通常_花弁1_表示 = value;
				this.花_ユリ_通常_蕊_雄蕊中後_葯_表示 = value;
				this.花_ユリ_通常_蕊_雄蕊中後_雄蕊_表示 = value;
				this.花_ユリ_通常_蕊_雌蕊_雌蕊_表示 = value;
				this.花_ユリ_通常_蕊_雌蕊_柱頭_表示 = value;
				this.花_ユリ_通常_蕊_雄蕊左2_葯_表示 = value;
				this.花_ユリ_通常_蕊_雄蕊左2_雄蕊_表示 = value;
				this.花_ユリ_通常_蕊_雄蕊右2_葯_表示 = value;
				this.花_ユリ_通常_蕊_雄蕊右2_雄蕊_表示 = value;
				this.花_ユリ_通常_蕊_雄蕊左1_雄蕊_表示 = value;
				this.花_ユリ_通常_蕊_雄蕊左1_葯_表示 = value;
				this.花_ユリ_通常_蕊_雄蕊右1_雄蕊_表示 = value;
				this.花_ユリ_通常_蕊_雄蕊右1_葯_表示 = value;
				this.花_ユリ_通常_蕊_雄蕊中前_雄蕊_表示 = value;
				this.花_ユリ_通常_蕊_雄蕊中前_葯_表示 = value;
				this.花_ユリ_通常_花弁2_表示 = value;
				this.花_ユリ_通常_花弁3_表示 = value;
				this.花_ユリ_通常_萼1_萼2_表示 = value;
				this.花_ユリ_通常_萼1_萼1_表示 = value;
				this.花_ユリ_欠損_萼2_表示 = value;
				this.花_ユリ_欠損_萼3_表示 = value;
				this.花_ユリ_欠損_花弁1_表示 = value;
				this.花_ユリ_欠損_蕊_雄蕊中後_葯_表示 = value;
				this.花_ユリ_欠損_蕊_雄蕊中後_雄蕊_表示 = value;
				this.花_ユリ_欠損_蕊_雌蕊_雌蕊_表示 = value;
				this.花_ユリ_欠損_蕊_雌蕊_柱頭_表示 = value;
				this.花_ユリ_欠損_蕊_雄蕊左2_葯_表示 = value;
				this.花_ユリ_欠損_蕊_雄蕊左2_雄蕊_表示 = value;
				this.花_ユリ_欠損_蕊_雄蕊右2_葯_表示 = value;
				this.花_ユリ_欠損_蕊_雄蕊右2_雄蕊_表示 = value;
				this.花_ユリ_欠損_蕊_雄蕊左1_雄蕊_表示 = value;
				this.花_ユリ_欠損_蕊_雄蕊左1_葯_表示 = value;
				this.花_ユリ_欠損_蕊_雄蕊右1_雄蕊_表示 = value;
				this.花_ユリ_欠損_蕊_雄蕊右1_葯_表示 = value;
				this.花_ユリ_欠損_蕊_雄蕊中前_雄蕊_表示 = value;
				this.花_ユリ_欠損_蕊_雄蕊中前_葯_表示 = value;
				this.花_ユリ_欠損_花弁2_表示 = value;
				this.花_ユリ_欠損_花弁3_表示 = value;
				this.花_ユリ_欠損_萼1_萼2_表示 = value;
				this.花_ユリ_欠損_萼1_萼1_表示 = value;
				this.萼_通常_萼_表示 = value;
				this.萼_欠損_萼_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.花_ユリ_萼2CD.不透明度;
			}
			set
			{
				this.花_ユリ_萼2CD.不透明度 = value;
				this.花_ユリ_萼3CD.不透明度 = value;
				this.花_ユリ_花弁1CD.不透明度 = value;
				this.花_ユリ_蕊_雄蕊中後_葯CD.不透明度 = value;
				this.花_ユリ_蕊_雄蕊中後_雄蕊CD.不透明度 = value;
				this.花_ユリ_蕊_雌蕊_雌蕊CD.不透明度 = value;
				this.花_ユリ_蕊_雌蕊_柱頭CD.不透明度 = value;
				this.花_ユリ_蕊_雄蕊左2_葯CD.不透明度 = value;
				this.花_ユリ_蕊_雄蕊左2_雄蕊CD.不透明度 = value;
				this.花_ユリ_蕊_雄蕊右2_葯CD.不透明度 = value;
				this.花_ユリ_蕊_雄蕊右2_雄蕊CD.不透明度 = value;
				this.花_ユリ_蕊_雄蕊左1_雄蕊CD.不透明度 = value;
				this.花_ユリ_蕊_雄蕊左1_葯CD.不透明度 = value;
				this.花_ユリ_蕊_雄蕊右1_雄蕊CD.不透明度 = value;
				this.花_ユリ_蕊_雄蕊右1_葯CD.不透明度 = value;
				this.花_ユリ_蕊_雄蕊中前_雄蕊CD.不透明度 = value;
				this.花_ユリ_蕊_雄蕊中前_葯CD.不透明度 = value;
				this.花_ユリ_花弁2CD.不透明度 = value;
				this.花_ユリ_花弁3CD.不透明度 = value;
				this.花_ユリ_萼1_萼2CD.不透明度 = value;
				this.花_ユリ_萼1_萼1CD.不透明度 = value;
				this.萼_萼CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			double num = this.右 ? -1.0 : 1.0;
			this.X0Y0_萼_通常_萼.AngleBase = num * -81.0;
			this.本体.JoinPAall();
		}

		public override void 色更新()
		{
			this.X0Y0_花_ユリ_通常_萼2CP.Update();
			this.X0Y0_花_ユリ_通常_萼3CP.Update();
			this.X0Y0_花_ユリ_通常_花弁1CP.Update();
			this.X0Y0_花_ユリ_通常_蕊_雄蕊中後_葯CP.Update();
			this.X0Y0_花_ユリ_通常_蕊_雄蕊中後_雄蕊CP.Update();
			this.X0Y0_花_ユリ_通常_蕊_雌蕊_雌蕊CP.Update();
			this.X0Y0_花_ユリ_通常_蕊_雌蕊_柱頭CP.Update();
			this.X0Y0_花_ユリ_通常_蕊_雄蕊左2_葯CP.Update();
			this.X0Y0_花_ユリ_通常_蕊_雄蕊左2_雄蕊CP.Update();
			this.X0Y0_花_ユリ_通常_蕊_雄蕊右2_葯CP.Update();
			this.X0Y0_花_ユリ_通常_蕊_雄蕊右2_雄蕊CP.Update();
			this.X0Y0_花_ユリ_通常_蕊_雄蕊左1_雄蕊CP.Update();
			this.X0Y0_花_ユリ_通常_蕊_雄蕊左1_葯CP.Update();
			this.X0Y0_花_ユリ_通常_蕊_雄蕊右1_雄蕊CP.Update();
			this.X0Y0_花_ユリ_通常_蕊_雄蕊右1_葯CP.Update();
			this.X0Y0_花_ユリ_通常_蕊_雄蕊中前_雄蕊CP.Update();
			this.X0Y0_花_ユリ_通常_蕊_雄蕊中前_葯CP.Update();
			this.X0Y0_花_ユリ_通常_花弁2CP.Update();
			this.X0Y0_花_ユリ_通常_花弁3CP.Update();
			this.X0Y0_花_ユリ_通常_萼1_萼2CP.Update();
			this.X0Y0_花_ユリ_通常_萼1_萼1CP.Update();
			this.X0Y0_花_ユリ_欠損_萼2CP.Update();
			this.X0Y0_花_ユリ_欠損_萼3CP.Update();
			this.X0Y0_花_ユリ_欠損_花弁1CP.Update();
			this.X0Y0_花_ユリ_欠損_蕊_雄蕊中後_葯CP.Update();
			this.X0Y0_花_ユリ_欠損_蕊_雄蕊中後_雄蕊CP.Update();
			this.X0Y0_花_ユリ_欠損_蕊_雌蕊_雌蕊CP.Update();
			this.X0Y0_花_ユリ_欠損_蕊_雌蕊_柱頭CP.Update();
			this.X0Y0_花_ユリ_欠損_蕊_雄蕊左2_葯CP.Update();
			this.X0Y0_花_ユリ_欠損_蕊_雄蕊左2_雄蕊CP.Update();
			this.X0Y0_花_ユリ_欠損_蕊_雄蕊右2_葯CP.Update();
			this.X0Y0_花_ユリ_欠損_蕊_雄蕊右2_雄蕊CP.Update();
			this.X0Y0_花_ユリ_欠損_蕊_雄蕊左1_雄蕊CP.Update();
			this.X0Y0_花_ユリ_欠損_蕊_雄蕊左1_葯CP.Update();
			this.X0Y0_花_ユリ_欠損_蕊_雄蕊右1_雄蕊CP.Update();
			this.X0Y0_花_ユリ_欠損_蕊_雄蕊右1_葯CP.Update();
			this.X0Y0_花_ユリ_欠損_蕊_雄蕊中前_雄蕊CP.Update();
			this.X0Y0_花_ユリ_欠損_蕊_雄蕊中前_葯CP.Update();
			this.X0Y0_花_ユリ_欠損_花弁2CP.Update();
			this.X0Y0_花_ユリ_欠損_花弁3CP.Update();
			this.X0Y0_花_ユリ_欠損_萼1_萼2CP.Update();
			this.X0Y0_花_ユリ_欠損_萼1_萼1CP.Update();
			this.X0Y0_萼_通常_萼CP.Update();
			this.X0Y0_萼_欠損_萼CP.Update();
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
			this.花_ユリ_萼2CD = new ColorD(ref Col.Black, ref 体配色.百O);
			this.花_ユリ_萼3CD = new ColorD(ref Col.Black, ref 体配色.百O);
			this.花_ユリ_花弁1CD = new ColorD(ref Col.Black, ref 体配色.百O);
			this.花_ユリ_蕊_雄蕊中後_葯CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.花_ユリ_蕊_雄蕊中後_雄蕊CD = new ColorD(ref Col.Black, ref 体配色.百O);
			this.花_ユリ_蕊_雌蕊_雌蕊CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.花_ユリ_蕊_雌蕊_柱頭CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.花_ユリ_蕊_雄蕊左2_葯CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.花_ユリ_蕊_雄蕊左2_雄蕊CD = new ColorD(ref Col.Black, ref 体配色.百O);
			this.花_ユリ_蕊_雄蕊右2_葯CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.花_ユリ_蕊_雄蕊右2_雄蕊CD = new ColorD(ref Col.Black, ref 体配色.百O);
			this.花_ユリ_蕊_雄蕊左1_雄蕊CD = new ColorD(ref Col.Black, ref 体配色.百O);
			this.花_ユリ_蕊_雄蕊左1_葯CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.花_ユリ_蕊_雄蕊右1_雄蕊CD = new ColorD(ref Col.Black, ref 体配色.百O);
			this.花_ユリ_蕊_雄蕊右1_葯CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.花_ユリ_蕊_雄蕊中前_雄蕊CD = new ColorD(ref Col.Black, ref 体配色.百O);
			this.花_ユリ_蕊_雄蕊中前_葯CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.花_ユリ_花弁2CD = new ColorD(ref Col.Black, ref 体配色.百O);
			this.花_ユリ_花弁3CD = new ColorD(ref Col.Black, ref 体配色.百O);
			this.花_ユリ_萼1_萼2CD = new ColorD(ref Col.Black, ref 体配色.百O);
			this.花_ユリ_萼1_萼1CD = new ColorD(ref Col.Black, ref 体配色.百O);
			this.萼_萼CD = new ColorD(ref Col.Black, ref 体配色.植1O);
		}

		private void 配色T0(体配色 体配色)
		{
			this.花_ユリ_萼2CD = new ColorD(ref Col.Black, ref 体配色.百O);
			this.花_ユリ_萼3CD = new ColorD(ref Col.Black, ref 体配色.百O);
			this.花_ユリ_花弁1CD = new ColorD(ref Col.Black, ref 体配色.百O);
			this.花_ユリ_蕊_雄蕊中後_葯CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.花_ユリ_蕊_雄蕊中後_雄蕊CD = new ColorD(ref Col.Black, ref 体配色.百O);
			this.花_ユリ_蕊_雌蕊_雌蕊CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.花_ユリ_蕊_雌蕊_柱頭CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.花_ユリ_蕊_雄蕊左2_葯CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.花_ユリ_蕊_雄蕊左2_雄蕊CD = new ColorD(ref Col.Black, ref 体配色.百O);
			this.花_ユリ_蕊_雄蕊右2_葯CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.花_ユリ_蕊_雄蕊右2_雄蕊CD = new ColorD(ref Col.Black, ref 体配色.百O);
			this.花_ユリ_蕊_雄蕊左1_雄蕊CD = new ColorD(ref Col.Black, ref 体配色.百O);
			this.花_ユリ_蕊_雄蕊左1_葯CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.花_ユリ_蕊_雄蕊右1_雄蕊CD = new ColorD(ref Col.Black, ref 体配色.百O);
			this.花_ユリ_蕊_雄蕊右1_葯CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.花_ユリ_蕊_雄蕊中前_雄蕊CD = new ColorD(ref Col.Black, ref 体配色.百O);
			this.花_ユリ_蕊_雄蕊中前_葯CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.花_ユリ_花弁2CD = new ColorD(ref Col.Black, ref 体配色.百O);
			this.花_ユリ_花弁3CD = new ColorD(ref Col.Black, ref 体配色.百O);
			this.花_ユリ_萼1_萼2CD = new ColorD(ref Col.Black, ref 体配色.百O);
			this.花_ユリ_萼1_萼1CD = new ColorD(ref Col.Black, ref 体配色.百O);
			this.萼_萼CD = new ColorD(ref Col.Black, ref 体配色.植1O);
		}

		private void 配色T1(体配色 体配色)
		{
			this.花_ユリ_萼2CD = new ColorD(ref Col.Black, ref 体配色.百O);
			this.花_ユリ_萼3CD = new ColorD(ref Col.Black, ref 体配色.百O);
			this.花_ユリ_花弁1CD = new ColorD(ref Col.Black, ref 体配色.百O);
			this.花_ユリ_蕊_雄蕊中後_葯CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.花_ユリ_蕊_雄蕊中後_雄蕊CD = new ColorD(ref Col.Black, ref 体配色.百O);
			this.花_ユリ_蕊_雌蕊_雌蕊CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.花_ユリ_蕊_雌蕊_柱頭CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.花_ユリ_蕊_雄蕊左2_葯CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.花_ユリ_蕊_雄蕊左2_雄蕊CD = new ColorD(ref Col.Black, ref 体配色.百O);
			this.花_ユリ_蕊_雄蕊右2_葯CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.花_ユリ_蕊_雄蕊右2_雄蕊CD = new ColorD(ref Col.Black, ref 体配色.百O);
			this.花_ユリ_蕊_雄蕊左1_雄蕊CD = new ColorD(ref Col.Black, ref 体配色.百O);
			this.花_ユリ_蕊_雄蕊左1_葯CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.花_ユリ_蕊_雄蕊右1_雄蕊CD = new ColorD(ref Col.Black, ref 体配色.百O);
			this.花_ユリ_蕊_雄蕊右1_葯CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.花_ユリ_蕊_雄蕊中前_雄蕊CD = new ColorD(ref Col.Black, ref 体配色.百O);
			this.花_ユリ_蕊_雄蕊中前_葯CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.花_ユリ_花弁2CD = new ColorD(ref Col.Black, ref 体配色.百O);
			this.花_ユリ_花弁3CD = new ColorD(ref Col.Black, ref 体配色.百O);
			this.花_ユリ_萼1_萼2CD = new ColorD(ref Col.Black, ref 体配色.百O);
			this.花_ユリ_萼1_萼1CD = new ColorD(ref Col.Black, ref 体配色.百O);
			this.萼_萼CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
		}

		public Par X0Y0_花_ユリ_通常_萼2;

		public Par X0Y0_花_ユリ_通常_萼3;

		public Par X0Y0_花_ユリ_通常_花弁1;

		public Par X0Y0_花_ユリ_通常_蕊_雄蕊中後_葯;

		public Par X0Y0_花_ユリ_通常_蕊_雄蕊中後_雄蕊;

		public Par X0Y0_花_ユリ_通常_蕊_雌蕊_雌蕊;

		public Par X0Y0_花_ユリ_通常_蕊_雌蕊_柱頭;

		public Par X0Y0_花_ユリ_通常_蕊_雄蕊左2_葯;

		public Par X0Y0_花_ユリ_通常_蕊_雄蕊左2_雄蕊;

		public Par X0Y0_花_ユリ_通常_蕊_雄蕊右2_葯;

		public Par X0Y0_花_ユリ_通常_蕊_雄蕊右2_雄蕊;

		public Par X0Y0_花_ユリ_通常_蕊_雄蕊左1_雄蕊;

		public Par X0Y0_花_ユリ_通常_蕊_雄蕊左1_葯;

		public Par X0Y0_花_ユリ_通常_蕊_雄蕊右1_雄蕊;

		public Par X0Y0_花_ユリ_通常_蕊_雄蕊右1_葯;

		public Par X0Y0_花_ユリ_通常_蕊_雄蕊中前_雄蕊;

		public Par X0Y0_花_ユリ_通常_蕊_雄蕊中前_葯;

		public Par X0Y0_花_ユリ_通常_花弁2;

		public Par X0Y0_花_ユリ_通常_花弁3;

		public Par X0Y0_花_ユリ_通常_萼1_萼2;

		public Par X0Y0_花_ユリ_通常_萼1_萼1;

		public Par X0Y0_花_ユリ_欠損_萼2;

		public Par X0Y0_花_ユリ_欠損_萼3;

		public Par X0Y0_花_ユリ_欠損_花弁1;

		public Par X0Y0_花_ユリ_欠損_蕊_雄蕊中後_葯;

		public Par X0Y0_花_ユリ_欠損_蕊_雄蕊中後_雄蕊;

		public Par X0Y0_花_ユリ_欠損_蕊_雌蕊_雌蕊;

		public Par X0Y0_花_ユリ_欠損_蕊_雌蕊_柱頭;

		public Par X0Y0_花_ユリ_欠損_蕊_雄蕊左2_葯;

		public Par X0Y0_花_ユリ_欠損_蕊_雄蕊左2_雄蕊;

		public Par X0Y0_花_ユリ_欠損_蕊_雄蕊右2_葯;

		public Par X0Y0_花_ユリ_欠損_蕊_雄蕊右2_雄蕊;

		public Par X0Y0_花_ユリ_欠損_蕊_雄蕊左1_雄蕊;

		public Par X0Y0_花_ユリ_欠損_蕊_雄蕊左1_葯;

		public Par X0Y0_花_ユリ_欠損_蕊_雄蕊右1_雄蕊;

		public Par X0Y0_花_ユリ_欠損_蕊_雄蕊右1_葯;

		public Par X0Y0_花_ユリ_欠損_蕊_雄蕊中前_雄蕊;

		public Par X0Y0_花_ユリ_欠損_蕊_雄蕊中前_葯;

		public Par X0Y0_花_ユリ_欠損_花弁2;

		public Par X0Y0_花_ユリ_欠損_花弁3;

		public Par X0Y0_花_ユリ_欠損_萼1_萼2;

		public Par X0Y0_花_ユリ_欠損_萼1_萼1;

		public Par X0Y0_萼_通常_萼;

		public Par X0Y0_萼_欠損_萼;

		public ColorD 花_ユリ_萼2CD;

		public ColorD 花_ユリ_萼3CD;

		public ColorD 花_ユリ_花弁1CD;

		public ColorD 花_ユリ_蕊_雄蕊中後_葯CD;

		public ColorD 花_ユリ_蕊_雄蕊中後_雄蕊CD;

		public ColorD 花_ユリ_蕊_雌蕊_雌蕊CD;

		public ColorD 花_ユリ_蕊_雌蕊_柱頭CD;

		public ColorD 花_ユリ_蕊_雄蕊左2_葯CD;

		public ColorD 花_ユリ_蕊_雄蕊左2_雄蕊CD;

		public ColorD 花_ユリ_蕊_雄蕊右2_葯CD;

		public ColorD 花_ユリ_蕊_雄蕊右2_雄蕊CD;

		public ColorD 花_ユリ_蕊_雄蕊左1_雄蕊CD;

		public ColorD 花_ユリ_蕊_雄蕊左1_葯CD;

		public ColorD 花_ユリ_蕊_雄蕊右1_雄蕊CD;

		public ColorD 花_ユリ_蕊_雄蕊右1_葯CD;

		public ColorD 花_ユリ_蕊_雄蕊中前_雄蕊CD;

		public ColorD 花_ユリ_蕊_雄蕊中前_葯CD;

		public ColorD 花_ユリ_花弁2CD;

		public ColorD 花_ユリ_花弁3CD;

		public ColorD 花_ユリ_萼1_萼2CD;

		public ColorD 花_ユリ_萼1_萼1CD;

		public ColorD 萼_萼CD;

		public ColorP X0Y0_花_ユリ_通常_萼2CP;

		public ColorP X0Y0_花_ユリ_通常_萼3CP;

		public ColorP X0Y0_花_ユリ_通常_花弁1CP;

		public ColorP X0Y0_花_ユリ_通常_蕊_雄蕊中後_葯CP;

		public ColorP X0Y0_花_ユリ_通常_蕊_雄蕊中後_雄蕊CP;

		public ColorP X0Y0_花_ユリ_通常_蕊_雌蕊_雌蕊CP;

		public ColorP X0Y0_花_ユリ_通常_蕊_雌蕊_柱頭CP;

		public ColorP X0Y0_花_ユリ_通常_蕊_雄蕊左2_葯CP;

		public ColorP X0Y0_花_ユリ_通常_蕊_雄蕊左2_雄蕊CP;

		public ColorP X0Y0_花_ユリ_通常_蕊_雄蕊右2_葯CP;

		public ColorP X0Y0_花_ユリ_通常_蕊_雄蕊右2_雄蕊CP;

		public ColorP X0Y0_花_ユリ_通常_蕊_雄蕊左1_雄蕊CP;

		public ColorP X0Y0_花_ユリ_通常_蕊_雄蕊左1_葯CP;

		public ColorP X0Y0_花_ユリ_通常_蕊_雄蕊右1_雄蕊CP;

		public ColorP X0Y0_花_ユリ_通常_蕊_雄蕊右1_葯CP;

		public ColorP X0Y0_花_ユリ_通常_蕊_雄蕊中前_雄蕊CP;

		public ColorP X0Y0_花_ユリ_通常_蕊_雄蕊中前_葯CP;

		public ColorP X0Y0_花_ユリ_通常_花弁2CP;

		public ColorP X0Y0_花_ユリ_通常_花弁3CP;

		public ColorP X0Y0_花_ユリ_通常_萼1_萼2CP;

		public ColorP X0Y0_花_ユリ_通常_萼1_萼1CP;

		public ColorP X0Y0_花_ユリ_欠損_萼2CP;

		public ColorP X0Y0_花_ユリ_欠損_萼3CP;

		public ColorP X0Y0_花_ユリ_欠損_花弁1CP;

		public ColorP X0Y0_花_ユリ_欠損_蕊_雄蕊中後_葯CP;

		public ColorP X0Y0_花_ユリ_欠損_蕊_雄蕊中後_雄蕊CP;

		public ColorP X0Y0_花_ユリ_欠損_蕊_雌蕊_雌蕊CP;

		public ColorP X0Y0_花_ユリ_欠損_蕊_雌蕊_柱頭CP;

		public ColorP X0Y0_花_ユリ_欠損_蕊_雄蕊左2_葯CP;

		public ColorP X0Y0_花_ユリ_欠損_蕊_雄蕊左2_雄蕊CP;

		public ColorP X0Y0_花_ユリ_欠損_蕊_雄蕊右2_葯CP;

		public ColorP X0Y0_花_ユリ_欠損_蕊_雄蕊右2_雄蕊CP;

		public ColorP X0Y0_花_ユリ_欠損_蕊_雄蕊左1_雄蕊CP;

		public ColorP X0Y0_花_ユリ_欠損_蕊_雄蕊左1_葯CP;

		public ColorP X0Y0_花_ユリ_欠損_蕊_雄蕊右1_雄蕊CP;

		public ColorP X0Y0_花_ユリ_欠損_蕊_雄蕊右1_葯CP;

		public ColorP X0Y0_花_ユリ_欠損_蕊_雄蕊中前_雄蕊CP;

		public ColorP X0Y0_花_ユリ_欠損_蕊_雄蕊中前_葯CP;

		public ColorP X0Y0_花_ユリ_欠損_花弁2CP;

		public ColorP X0Y0_花_ユリ_欠損_花弁3CP;

		public ColorP X0Y0_花_ユリ_欠損_萼1_萼2CP;

		public ColorP X0Y0_花_ユリ_欠損_萼1_萼1CP;

		public ColorP X0Y0_萼_通常_萼CP;

		public ColorP X0Y0_萼_欠損_萼CP;
	}
}
