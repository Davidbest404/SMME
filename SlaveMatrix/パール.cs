using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class パ\u30FCル : Ele
	{
		public パ\u30FCル(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, パ\u30FCルD e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.カ\u30FCソル["パール"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_軸 = pars["軸"].ToPar();
			this.X0Y0_玉境界 = pars["玉境界"].ToPar();
			this.X0Y0_玉1 = pars["玉1"].ToPar();
			this.X0Y0_玉2 = pars["玉2"].ToPar();
			this.X0Y0_玉3 = pars["玉3"].ToPar();
			this.X0Y0_玉4 = pars["玉4"].ToPar();
			this.X0Y0_玉5 = pars["玉5"].ToPar();
			this.X0Y0_玉6 = pars["玉6"].ToPar();
			this.X0Y0_玉7 = pars["玉7"].ToPar();
			this.X0Y0_輪上 = pars["輪上"].ToPar();
			this.X0Y0_輪下 = pars["輪下"].ToPar();
			pars = this.本体[0][1];
			this.X0Y1_軸 = pars["軸"].ToPar();
			this.X0Y1_玉境界 = pars["玉境界"].ToPar();
			this.X0Y1_玉1 = pars["玉1"].ToPar();
			this.X0Y1_玉2 = pars["玉2"].ToPar();
			this.X0Y1_玉3 = pars["玉3"].ToPar();
			this.X0Y1_玉4 = pars["玉4"].ToPar();
			this.X0Y1_玉5 = pars["玉5"].ToPar();
			this.X0Y1_玉6 = pars["玉6"].ToPar();
			this.X0Y1_玉7 = pars["玉7"].ToPar();
			this.X0Y1_輪上 = pars["輪上"].ToPar();
			this.X0Y1_輪下 = pars["輪下"].ToPar();
			pars = this.本体[0][2];
			this.X0Y2_軸 = pars["軸"].ToPar();
			this.X0Y2_玉境界 = pars["玉境界"].ToPar();
			this.X0Y2_玉1 = pars["玉1"].ToPar();
			this.X0Y2_玉2 = pars["玉2"].ToPar();
			this.X0Y2_玉3 = pars["玉3"].ToPar();
			this.X0Y2_玉4 = pars["玉4"].ToPar();
			this.X0Y2_玉5 = pars["玉5"].ToPar();
			this.X0Y2_玉6 = pars["玉6"].ToPar();
			this.X0Y2_輪上 = pars["輪上"].ToPar();
			this.X0Y2_輪下 = pars["輪下"].ToPar();
			pars = this.本体[0][3];
			this.X0Y3_軸 = pars["軸"].ToPar();
			this.X0Y3_玉境界 = pars["玉境界"].ToPar();
			this.X0Y3_玉1 = pars["玉1"].ToPar();
			this.X0Y3_玉2 = pars["玉2"].ToPar();
			this.X0Y3_玉3 = pars["玉3"].ToPar();
			this.X0Y3_玉4 = pars["玉4"].ToPar();
			this.X0Y3_玉5 = pars["玉5"].ToPar();
			this.X0Y3_玉6 = pars["玉6"].ToPar();
			this.X0Y3_輪上 = pars["輪上"].ToPar();
			this.X0Y3_輪下 = pars["輪下"].ToPar();
			pars = this.本体[0][4];
			this.X0Y4_軸 = pars["軸"].ToPar();
			this.X0Y4_玉境界 = pars["玉境界"].ToPar();
			this.X0Y4_玉1 = pars["玉1"].ToPar();
			this.X0Y4_玉2 = pars["玉2"].ToPar();
			this.X0Y4_玉3 = pars["玉3"].ToPar();
			this.X0Y4_玉4 = pars["玉4"].ToPar();
			this.X0Y4_玉5 = pars["玉5"].ToPar();
			this.X0Y4_輪上 = pars["輪上"].ToPar();
			this.X0Y4_輪下 = pars["輪下"].ToPar();
			pars = this.本体[0][5];
			this.X0Y5_軸 = pars["軸"].ToPar();
			this.X0Y5_玉境界 = pars["玉境界"].ToPar();
			this.X0Y5_玉1 = pars["玉1"].ToPar();
			this.X0Y5_玉2 = pars["玉2"].ToPar();
			this.X0Y5_玉3 = pars["玉3"].ToPar();
			this.X0Y5_玉4 = pars["玉4"].ToPar();
			this.X0Y5_玉5 = pars["玉5"].ToPar();
			this.X0Y5_輪上 = pars["輪上"].ToPar();
			this.X0Y5_輪下 = pars["輪下"].ToPar();
			pars = this.本体[0][6];
			this.X0Y6_軸 = pars["軸"].ToPar();
			this.X0Y6_玉境界 = pars["玉境界"].ToPar();
			this.X0Y6_玉1 = pars["玉1"].ToPar();
			this.X0Y6_玉2 = pars["玉2"].ToPar();
			this.X0Y6_玉3 = pars["玉3"].ToPar();
			this.X0Y6_玉4 = pars["玉4"].ToPar();
			this.X0Y6_輪上 = pars["輪上"].ToPar();
			this.X0Y6_輪下 = pars["輪下"].ToPar();
			pars = this.本体[0][7];
			this.X0Y7_軸 = pars["軸"].ToPar();
			this.X0Y7_玉境界 = pars["玉境界"].ToPar();
			this.X0Y7_玉1 = pars["玉1"].ToPar();
			this.X0Y7_玉2 = pars["玉2"].ToPar();
			this.X0Y7_玉3 = pars["玉3"].ToPar();
			this.X0Y7_玉4 = pars["玉4"].ToPar();
			this.X0Y7_輪上 = pars["輪上"].ToPar();
			this.X0Y7_輪下 = pars["輪下"].ToPar();
			pars = this.本体[0][8];
			this.X0Y8_軸 = pars["軸"].ToPar();
			this.X0Y8_玉境界 = pars["玉境界"].ToPar();
			this.X0Y8_玉1 = pars["玉1"].ToPar();
			this.X0Y8_玉2 = pars["玉2"].ToPar();
			this.X0Y8_玉3 = pars["玉3"].ToPar();
			this.X0Y8_輪上 = pars["輪上"].ToPar();
			this.X0Y8_輪下 = pars["輪下"].ToPar();
			pars = this.本体[0][9];
			this.X0Y9_軸 = pars["軸"].ToPar();
			this.X0Y9_玉境界 = pars["玉境界"].ToPar();
			this.X0Y9_玉1 = pars["玉1"].ToPar();
			this.X0Y9_玉2 = pars["玉2"].ToPar();
			this.X0Y9_玉3 = pars["玉3"].ToPar();
			this.X0Y9_輪上 = pars["輪上"].ToPar();
			this.X0Y9_輪下 = pars["輪下"].ToPar();
			pars = this.本体[0][10];
			this.X0Y10_軸 = pars["軸"].ToPar();
			this.X0Y10_玉境界 = pars["玉境界"].ToPar();
			this.X0Y10_玉1 = pars["玉1"].ToPar();
			this.X0Y10_玉2 = pars["玉2"].ToPar();
			this.X0Y10_輪上 = pars["輪上"].ToPar();
			this.X0Y10_輪下 = pars["輪下"].ToPar();
			pars = this.本体[0][11];
			this.X0Y11_軸 = pars["軸"].ToPar();
			this.X0Y11_玉境界 = pars["玉境界"].ToPar();
			this.X0Y11_玉1 = pars["玉1"].ToPar();
			this.X0Y11_玉2 = pars["玉2"].ToPar();
			this.X0Y11_輪上 = pars["輪上"].ToPar();
			this.X0Y11_輪下 = pars["輪下"].ToPar();
			pars = this.本体[0][12];
			this.X0Y12_軸 = pars["軸"].ToPar();
			this.X0Y12_玉境界 = pars["玉境界"].ToPar();
			this.X0Y12_玉 = pars["玉"].ToPar();
			this.X0Y12_輪上 = pars["輪上"].ToPar();
			this.X0Y12_輪下 = pars["輪下"].ToPar();
			pars = this.本体[0][13];
			this.X0Y13_軸 = pars["軸"].ToPar();
			this.X0Y13_玉境界 = pars["玉境界"].ToPar();
			this.X0Y13_玉 = pars["玉"].ToPar();
			this.X0Y13_輪上 = pars["輪上"].ToPar();
			this.X0Y13_輪下 = pars["輪下"].ToPar();
			pars = this.本体[0][14];
			this.X0Y14_軸 = pars["軸"].ToPar();
			this.X0Y14_玉境界 = pars["玉境界"].ToPar();
			this.X0Y14_輪上 = pars["輪上"].ToPar();
			this.X0Y14_輪下 = pars["輪下"].ToPar();
			pars = this.本体[0][15];
			this.X0Y15_軸 = pars["軸"].ToPar();
			this.X0Y15_玉境界 = pars["玉境界"].ToPar();
			this.X0Y15_輪上 = pars["輪上"].ToPar();
			this.X0Y15_輪下 = pars["輪下"].ToPar();
			pars = this.本体[0][16];
			this.X0Y16_軸 = pars["軸"].ToPar();
			this.X0Y16_輪上境界 = pars["輪上境界"].ToPar();
			this.X0Y16_輪下 = pars["輪下"].ToPar();
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
			this.軸_表示 = e.軸_表示;
			this.玉境界_表示 = e.玉境界_表示;
			this.玉1_表示 = e.玉1_表示;
			this.玉2_表示 = e.玉2_表示;
			this.玉3_表示 = e.玉3_表示;
			this.玉4_表示 = e.玉4_表示;
			this.玉5_表示 = e.玉5_表示;
			this.玉6_表示 = e.玉6_表示;
			this.玉7_表示 = e.玉7_表示;
			this.輪上_表示 = e.輪上_表示;
			this.輪下_表示 = e.輪下_表示;
			this.玉_表示 = e.玉_表示;
			this.輪上境界_表示 = e.輪上境界_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_軸CP = new ColorP(this.X0Y0_軸, this.軸CD, DisUnit, true);
			this.X0Y0_玉境界CP = new ColorP(this.X0Y0_玉境界, this.玉境界CD, DisUnit, true);
			this.X0Y0_玉1CP = new ColorP(this.X0Y0_玉1, this.玉1CD, DisUnit, true);
			this.X0Y0_玉2CP = new ColorP(this.X0Y0_玉2, this.玉2CD, DisUnit, true);
			this.X0Y0_玉3CP = new ColorP(this.X0Y0_玉3, this.玉3CD, DisUnit, true);
			this.X0Y0_玉4CP = new ColorP(this.X0Y0_玉4, this.玉4CD, DisUnit, true);
			this.X0Y0_玉5CP = new ColorP(this.X0Y0_玉5, this.玉5CD, DisUnit, true);
			this.X0Y0_玉6CP = new ColorP(this.X0Y0_玉6, this.玉6CD, DisUnit, true);
			this.X0Y0_玉7CP = new ColorP(this.X0Y0_玉7, this.玉7CD, DisUnit, true);
			this.X0Y0_輪上CP = new ColorP(this.X0Y0_輪上, this.輪上CD, DisUnit, true);
			this.X0Y0_輪下CP = new ColorP(this.X0Y0_輪下, this.輪下CD, DisUnit, true);
			this.X0Y1_軸CP = new ColorP(this.X0Y1_軸, this.軸CD, DisUnit, true);
			this.X0Y1_玉境界CP = new ColorP(this.X0Y1_玉境界, this.玉境界CD, DisUnit, true);
			this.X0Y1_玉1CP = new ColorP(this.X0Y1_玉1, this.玉1CD, DisUnit, true);
			this.X0Y1_玉2CP = new ColorP(this.X0Y1_玉2, this.玉2CD, DisUnit, true);
			this.X0Y1_玉3CP = new ColorP(this.X0Y1_玉3, this.玉3CD, DisUnit, true);
			this.X0Y1_玉4CP = new ColorP(this.X0Y1_玉4, this.玉4CD, DisUnit, true);
			this.X0Y1_玉5CP = new ColorP(this.X0Y1_玉5, this.玉5CD, DisUnit, true);
			this.X0Y1_玉6CP = new ColorP(this.X0Y1_玉6, this.玉6CD, DisUnit, true);
			this.X0Y1_玉7CP = new ColorP(this.X0Y1_玉7, this.玉7CD, DisUnit, true);
			this.X0Y1_輪上CP = new ColorP(this.X0Y1_輪上, this.輪上CD, DisUnit, true);
			this.X0Y1_輪下CP = new ColorP(this.X0Y1_輪下, this.輪下CD, DisUnit, true);
			this.X0Y2_軸CP = new ColorP(this.X0Y2_軸, this.軸CD, DisUnit, true);
			this.X0Y2_玉境界CP = new ColorP(this.X0Y2_玉境界, this.玉境界CD, DisUnit, true);
			this.X0Y2_玉1CP = new ColorP(this.X0Y2_玉1, this.玉1CD, DisUnit, true);
			this.X0Y2_玉2CP = new ColorP(this.X0Y2_玉2, this.玉2CD, DisUnit, true);
			this.X0Y2_玉3CP = new ColorP(this.X0Y2_玉3, this.玉3CD, DisUnit, true);
			this.X0Y2_玉4CP = new ColorP(this.X0Y2_玉4, this.玉4CD, DisUnit, true);
			this.X0Y2_玉5CP = new ColorP(this.X0Y2_玉5, this.玉5CD, DisUnit, true);
			this.X0Y2_玉6CP = new ColorP(this.X0Y2_玉6, this.玉6CD, DisUnit, true);
			this.X0Y2_輪上CP = new ColorP(this.X0Y2_輪上, this.輪上CD, DisUnit, true);
			this.X0Y2_輪下CP = new ColorP(this.X0Y2_輪下, this.輪下CD, DisUnit, true);
			this.X0Y3_軸CP = new ColorP(this.X0Y3_軸, this.軸CD, DisUnit, true);
			this.X0Y3_玉境界CP = new ColorP(this.X0Y3_玉境界, this.玉境界CD, DisUnit, true);
			this.X0Y3_玉1CP = new ColorP(this.X0Y3_玉1, this.玉1CD, DisUnit, true);
			this.X0Y3_玉2CP = new ColorP(this.X0Y3_玉2, this.玉2CD, DisUnit, true);
			this.X0Y3_玉3CP = new ColorP(this.X0Y3_玉3, this.玉3CD, DisUnit, true);
			this.X0Y3_玉4CP = new ColorP(this.X0Y3_玉4, this.玉4CD, DisUnit, true);
			this.X0Y3_玉5CP = new ColorP(this.X0Y3_玉5, this.玉5CD, DisUnit, true);
			this.X0Y3_玉6CP = new ColorP(this.X0Y3_玉6, this.玉6CD, DisUnit, true);
			this.X0Y3_輪上CP = new ColorP(this.X0Y3_輪上, this.輪上CD, DisUnit, true);
			this.X0Y3_輪下CP = new ColorP(this.X0Y3_輪下, this.輪下CD, DisUnit, true);
			this.X0Y4_軸CP = new ColorP(this.X0Y4_軸, this.軸CD, DisUnit, true);
			this.X0Y4_玉境界CP = new ColorP(this.X0Y4_玉境界, this.玉境界CD, DisUnit, true);
			this.X0Y4_玉1CP = new ColorP(this.X0Y4_玉1, this.玉1CD, DisUnit, true);
			this.X0Y4_玉2CP = new ColorP(this.X0Y4_玉2, this.玉2CD, DisUnit, true);
			this.X0Y4_玉3CP = new ColorP(this.X0Y4_玉3, this.玉3CD, DisUnit, true);
			this.X0Y4_玉4CP = new ColorP(this.X0Y4_玉4, this.玉4CD, DisUnit, true);
			this.X0Y4_玉5CP = new ColorP(this.X0Y4_玉5, this.玉5CD, DisUnit, true);
			this.X0Y4_輪上CP = new ColorP(this.X0Y4_輪上, this.輪上CD, DisUnit, true);
			this.X0Y4_輪下CP = new ColorP(this.X0Y4_輪下, this.輪下CD, DisUnit, true);
			this.X0Y5_軸CP = new ColorP(this.X0Y5_軸, this.軸CD, DisUnit, true);
			this.X0Y5_玉境界CP = new ColorP(this.X0Y5_玉境界, this.玉境界CD, DisUnit, true);
			this.X0Y5_玉1CP = new ColorP(this.X0Y5_玉1, this.玉1CD, DisUnit, true);
			this.X0Y5_玉2CP = new ColorP(this.X0Y5_玉2, this.玉2CD, DisUnit, true);
			this.X0Y5_玉3CP = new ColorP(this.X0Y5_玉3, this.玉3CD, DisUnit, true);
			this.X0Y5_玉4CP = new ColorP(this.X0Y5_玉4, this.玉4CD, DisUnit, true);
			this.X0Y5_玉5CP = new ColorP(this.X0Y5_玉5, this.玉5CD, DisUnit, true);
			this.X0Y5_輪上CP = new ColorP(this.X0Y5_輪上, this.輪上CD, DisUnit, true);
			this.X0Y5_輪下CP = new ColorP(this.X0Y5_輪下, this.輪下CD, DisUnit, true);
			this.X0Y6_軸CP = new ColorP(this.X0Y6_軸, this.軸CD, DisUnit, true);
			this.X0Y6_玉境界CP = new ColorP(this.X0Y6_玉境界, this.玉境界CD, DisUnit, true);
			this.X0Y6_玉1CP = new ColorP(this.X0Y6_玉1, this.玉1CD, DisUnit, true);
			this.X0Y6_玉2CP = new ColorP(this.X0Y6_玉2, this.玉2CD, DisUnit, true);
			this.X0Y6_玉3CP = new ColorP(this.X0Y6_玉3, this.玉3CD, DisUnit, true);
			this.X0Y6_玉4CP = new ColorP(this.X0Y6_玉4, this.玉4CD, DisUnit, true);
			this.X0Y6_輪上CP = new ColorP(this.X0Y6_輪上, this.輪上CD, DisUnit, true);
			this.X0Y6_輪下CP = new ColorP(this.X0Y6_輪下, this.輪下CD, DisUnit, true);
			this.X0Y7_軸CP = new ColorP(this.X0Y7_軸, this.軸CD, DisUnit, true);
			this.X0Y7_玉境界CP = new ColorP(this.X0Y7_玉境界, this.玉境界CD, DisUnit, true);
			this.X0Y7_玉1CP = new ColorP(this.X0Y7_玉1, this.玉1CD, DisUnit, true);
			this.X0Y7_玉2CP = new ColorP(this.X0Y7_玉2, this.玉2CD, DisUnit, true);
			this.X0Y7_玉3CP = new ColorP(this.X0Y7_玉3, this.玉3CD, DisUnit, true);
			this.X0Y7_玉4CP = new ColorP(this.X0Y7_玉4, this.玉4CD, DisUnit, true);
			this.X0Y7_輪上CP = new ColorP(this.X0Y7_輪上, this.輪上CD, DisUnit, true);
			this.X0Y7_輪下CP = new ColorP(this.X0Y7_輪下, this.輪下CD, DisUnit, true);
			this.X0Y8_軸CP = new ColorP(this.X0Y8_軸, this.軸CD, DisUnit, true);
			this.X0Y8_玉境界CP = new ColorP(this.X0Y8_玉境界, this.玉境界CD, DisUnit, true);
			this.X0Y8_玉1CP = new ColorP(this.X0Y8_玉1, this.玉1CD, DisUnit, true);
			this.X0Y8_玉2CP = new ColorP(this.X0Y8_玉2, this.玉2CD, DisUnit, true);
			this.X0Y8_玉3CP = new ColorP(this.X0Y8_玉3, this.玉3CD, DisUnit, true);
			this.X0Y8_輪上CP = new ColorP(this.X0Y8_輪上, this.輪上CD, DisUnit, true);
			this.X0Y8_輪下CP = new ColorP(this.X0Y8_輪下, this.輪下CD, DisUnit, true);
			this.X0Y9_軸CP = new ColorP(this.X0Y9_軸, this.軸CD, DisUnit, true);
			this.X0Y9_玉境界CP = new ColorP(this.X0Y9_玉境界, this.玉境界CD, DisUnit, true);
			this.X0Y9_玉1CP = new ColorP(this.X0Y9_玉1, this.玉1CD, DisUnit, true);
			this.X0Y9_玉2CP = new ColorP(this.X0Y9_玉2, this.玉2CD, DisUnit, true);
			this.X0Y9_玉3CP = new ColorP(this.X0Y9_玉3, this.玉3CD, DisUnit, true);
			this.X0Y9_輪上CP = new ColorP(this.X0Y9_輪上, this.輪上CD, DisUnit, true);
			this.X0Y9_輪下CP = new ColorP(this.X0Y9_輪下, this.輪下CD, DisUnit, true);
			this.X0Y10_軸CP = new ColorP(this.X0Y10_軸, this.軸CD, DisUnit, true);
			this.X0Y10_玉境界CP = new ColorP(this.X0Y10_玉境界, this.玉境界CD, DisUnit, true);
			this.X0Y10_玉1CP = new ColorP(this.X0Y10_玉1, this.玉1CD, DisUnit, true);
			this.X0Y10_玉2CP = new ColorP(this.X0Y10_玉2, this.玉2CD, DisUnit, true);
			this.X0Y10_輪上CP = new ColorP(this.X0Y10_輪上, this.輪上CD, DisUnit, true);
			this.X0Y10_輪下CP = new ColorP(this.X0Y10_輪下, this.輪下CD, DisUnit, true);
			this.X0Y11_軸CP = new ColorP(this.X0Y11_軸, this.軸CD, DisUnit, true);
			this.X0Y11_玉境界CP = new ColorP(this.X0Y11_玉境界, this.玉境界CD, DisUnit, true);
			this.X0Y11_玉1CP = new ColorP(this.X0Y11_玉1, this.玉1CD, DisUnit, true);
			this.X0Y11_玉2CP = new ColorP(this.X0Y11_玉2, this.玉2CD, DisUnit, true);
			this.X0Y11_輪上CP = new ColorP(this.X0Y11_輪上, this.輪上CD, DisUnit, true);
			this.X0Y11_輪下CP = new ColorP(this.X0Y11_輪下, this.輪下CD, DisUnit, true);
			this.X0Y12_軸CP = new ColorP(this.X0Y12_軸, this.軸CD, DisUnit, true);
			this.X0Y12_玉境界CP = new ColorP(this.X0Y12_玉境界, this.玉境界CD, DisUnit, true);
			this.X0Y12_玉CP = new ColorP(this.X0Y12_玉, this.玉1CD, DisUnit, true);
			this.X0Y12_輪上CP = new ColorP(this.X0Y12_輪上, this.輪上CD, DisUnit, true);
			this.X0Y12_輪下CP = new ColorP(this.X0Y12_輪下, this.輪下CD, DisUnit, true);
			this.X0Y13_軸CP = new ColorP(this.X0Y13_軸, this.軸CD, DisUnit, true);
			this.X0Y13_玉境界CP = new ColorP(this.X0Y13_玉境界, this.玉境界CD, DisUnit, true);
			this.X0Y13_玉CP = new ColorP(this.X0Y13_玉, this.玉1CD, DisUnit, true);
			this.X0Y13_輪上CP = new ColorP(this.X0Y13_輪上, this.輪上CD, DisUnit, true);
			this.X0Y13_輪下CP = new ColorP(this.X0Y13_輪下, this.輪下CD, DisUnit, true);
			this.X0Y14_軸CP = new ColorP(this.X0Y14_軸, this.軸CD, DisUnit, true);
			this.X0Y14_玉境界CP = new ColorP(this.X0Y14_玉境界, this.玉境界CD, DisUnit, true);
			this.X0Y14_輪上CP = new ColorP(this.X0Y14_輪上, this.輪上CD, DisUnit, true);
			this.X0Y14_輪下CP = new ColorP(this.X0Y14_輪下, this.輪下CD, DisUnit, true);
			this.X0Y15_軸CP = new ColorP(this.X0Y15_軸, this.軸CD, DisUnit, true);
			this.X0Y15_玉境界CP = new ColorP(this.X0Y15_玉境界, this.玉境界CD, DisUnit, true);
			this.X0Y15_輪上CP = new ColorP(this.X0Y15_輪上, this.輪上CD, DisUnit, true);
			this.X0Y15_輪下CP = new ColorP(this.X0Y15_輪下, this.輪下CD, DisUnit, true);
			this.X0Y16_軸CP = new ColorP(this.X0Y16_軸, this.軸CD, DisUnit, true);
			this.X0Y16_輪上境界CP = new ColorP(this.X0Y16_輪上境界, this.輪上境界CD, DisUnit, true);
			this.X0Y16_輪下CP = new ColorP(this.X0Y16_輪下, this.輪下CD, DisUnit, true);
			this.濃度 = e.濃度;
			this.X0Y0_輪下.BasePointBase = this.X0Y0_輪下.ToLocal(this.X0Y0_玉境界.ToGlobal(this.X0Y0_玉境界.JP[0].Joint));
			this.X0Y1_輪下.BasePointBase = this.X0Y1_輪下.ToLocal(this.X0Y1_玉境界.ToGlobal(this.X0Y1_玉境界.JP[0].Joint));
			this.X0Y2_輪下.BasePointBase = this.X0Y2_輪下.ToLocal(this.X0Y2_玉境界.ToGlobal(this.X0Y2_玉境界.JP[0].Joint));
			this.X0Y3_輪下.BasePointBase = this.X0Y3_輪下.ToLocal(this.X0Y3_玉境界.ToGlobal(this.X0Y3_玉境界.JP[0].Joint));
			this.X0Y4_輪下.BasePointBase = this.X0Y4_輪下.ToLocal(this.X0Y4_玉境界.ToGlobal(this.X0Y4_玉境界.JP[0].Joint));
			this.X0Y5_輪下.BasePointBase = this.X0Y5_輪下.ToLocal(this.X0Y5_玉境界.ToGlobal(this.X0Y5_玉境界.JP[0].Joint));
			this.X0Y6_輪下.BasePointBase = this.X0Y6_輪下.ToLocal(this.X0Y6_玉境界.ToGlobal(this.X0Y6_玉境界.JP[0].Joint));
			this.X0Y7_輪下.BasePointBase = this.X0Y7_輪下.ToLocal(this.X0Y7_玉境界.ToGlobal(this.X0Y7_玉境界.JP[0].Joint));
			this.X0Y8_輪下.BasePointBase = this.X0Y8_輪下.ToLocal(this.X0Y8_玉境界.ToGlobal(this.X0Y8_玉境界.JP[0].Joint));
			this.X0Y9_輪下.BasePointBase = this.X0Y9_輪下.ToLocal(this.X0Y9_玉境界.ToGlobal(this.X0Y9_玉境界.JP[0].Joint));
			this.X0Y10_輪下.BasePointBase = this.X0Y10_輪下.ToLocal(this.X0Y10_玉境界.ToGlobal(this.X0Y10_玉境界.JP[0].Joint));
			this.X0Y11_輪下.BasePointBase = this.X0Y11_輪下.ToLocal(this.X0Y11_玉境界.ToGlobal(this.X0Y11_玉境界.JP[0].Joint));
			this.X0Y12_輪下.BasePointBase = this.X0Y12_輪下.ToLocal(this.X0Y12_玉境界.ToGlobal(this.X0Y12_玉境界.JP[0].Joint));
			this.X0Y13_輪下.BasePointBase = this.X0Y13_輪下.ToLocal(this.X0Y13_玉境界.ToGlobal(this.X0Y13_玉境界.JP[0].Joint));
			this.X0Y14_輪下.BasePointBase = this.X0Y14_輪下.ToLocal(this.X0Y14_玉境界.ToGlobal(this.X0Y14_玉境界.JP[0].Joint));
			this.X0Y15_輪下.BasePointBase = this.X0Y15_輪下.ToLocal(this.X0Y15_玉境界.ToGlobal(this.X0Y15_玉境界.JP[0].Joint));
			this.X0Y16_輪下.BasePointBase = this.X0Y16_輪下.ToLocal(this.X0Y16_輪上境界.ToGlobal(this.X0Y16_輪上境界.JP[0].Joint));
			this.尺度B *= 1.07;
			this.尺度B = 1.08;
			this.本体.JoinPAall();
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

		public bool 軸_表示
		{
			get
			{
				return this.X0Y0_軸.Dra;
			}
			set
			{
				this.X0Y0_軸.Dra = value;
				this.X0Y1_軸.Dra = value;
				this.X0Y2_軸.Dra = value;
				this.X0Y3_軸.Dra = value;
				this.X0Y4_軸.Dra = value;
				this.X0Y5_軸.Dra = value;
				this.X0Y6_軸.Dra = value;
				this.X0Y7_軸.Dra = value;
				this.X0Y8_軸.Dra = value;
				this.X0Y9_軸.Dra = value;
				this.X0Y10_軸.Dra = value;
				this.X0Y11_軸.Dra = value;
				this.X0Y12_軸.Dra = value;
				this.X0Y13_軸.Dra = value;
				this.X0Y14_軸.Dra = value;
				this.X0Y15_軸.Dra = value;
				this.X0Y16_軸.Dra = value;
				this.X0Y0_軸.Hit = value;
				this.X0Y1_軸.Hit = value;
				this.X0Y2_軸.Hit = value;
				this.X0Y3_軸.Hit = value;
				this.X0Y4_軸.Hit = value;
				this.X0Y5_軸.Hit = value;
				this.X0Y6_軸.Hit = value;
				this.X0Y7_軸.Hit = value;
				this.X0Y8_軸.Hit = value;
				this.X0Y9_軸.Hit = value;
				this.X0Y10_軸.Hit = value;
				this.X0Y11_軸.Hit = value;
				this.X0Y12_軸.Hit = value;
				this.X0Y13_軸.Hit = value;
				this.X0Y14_軸.Hit = value;
				this.X0Y15_軸.Hit = value;
				this.X0Y16_軸.Hit = value;
			}
		}

		public bool 玉境界_表示
		{
			get
			{
				return this.X0Y0_玉境界.Dra;
			}
			set
			{
				this.X0Y0_玉境界.Dra = value;
				this.X0Y1_玉境界.Dra = value;
				this.X0Y2_玉境界.Dra = value;
				this.X0Y3_玉境界.Dra = value;
				this.X0Y4_玉境界.Dra = value;
				this.X0Y5_玉境界.Dra = value;
				this.X0Y6_玉境界.Dra = value;
				this.X0Y7_玉境界.Dra = value;
				this.X0Y8_玉境界.Dra = value;
				this.X0Y9_玉境界.Dra = value;
				this.X0Y10_玉境界.Dra = value;
				this.X0Y11_玉境界.Dra = value;
				this.X0Y12_玉境界.Dra = value;
				this.X0Y13_玉境界.Dra = value;
				this.X0Y14_玉境界.Dra = value;
				this.X0Y15_玉境界.Dra = value;
				this.X0Y0_玉境界.Hit = value;
				this.X0Y1_玉境界.Hit = value;
				this.X0Y2_玉境界.Hit = value;
				this.X0Y3_玉境界.Hit = value;
				this.X0Y4_玉境界.Hit = value;
				this.X0Y5_玉境界.Hit = value;
				this.X0Y6_玉境界.Hit = value;
				this.X0Y7_玉境界.Hit = value;
				this.X0Y8_玉境界.Hit = value;
				this.X0Y9_玉境界.Hit = value;
				this.X0Y10_玉境界.Hit = value;
				this.X0Y11_玉境界.Hit = value;
				this.X0Y12_玉境界.Hit = value;
				this.X0Y13_玉境界.Hit = value;
				this.X0Y14_玉境界.Hit = value;
				this.X0Y15_玉境界.Hit = value;
			}
		}

		public bool 玉1_表示
		{
			get
			{
				return this.X0Y0_玉1.Dra;
			}
			set
			{
				this.X0Y0_玉1.Dra = value;
				this.X0Y1_玉1.Dra = value;
				this.X0Y2_玉1.Dra = value;
				this.X0Y3_玉1.Dra = value;
				this.X0Y4_玉1.Dra = value;
				this.X0Y5_玉1.Dra = value;
				this.X0Y6_玉1.Dra = value;
				this.X0Y7_玉1.Dra = value;
				this.X0Y8_玉1.Dra = value;
				this.X0Y9_玉1.Dra = value;
				this.X0Y10_玉1.Dra = value;
				this.X0Y11_玉1.Dra = value;
				this.X0Y0_玉1.Hit = value;
				this.X0Y1_玉1.Hit = value;
				this.X0Y2_玉1.Hit = value;
				this.X0Y3_玉1.Hit = value;
				this.X0Y4_玉1.Hit = value;
				this.X0Y5_玉1.Hit = value;
				this.X0Y6_玉1.Hit = value;
				this.X0Y7_玉1.Hit = value;
				this.X0Y8_玉1.Hit = value;
				this.X0Y9_玉1.Hit = value;
				this.X0Y10_玉1.Hit = value;
				this.X0Y11_玉1.Hit = value;
			}
		}

		public bool 玉2_表示
		{
			get
			{
				return this.X0Y0_玉2.Dra;
			}
			set
			{
				this.X0Y0_玉2.Dra = value;
				this.X0Y1_玉2.Dra = value;
				this.X0Y2_玉2.Dra = value;
				this.X0Y3_玉2.Dra = value;
				this.X0Y4_玉2.Dra = value;
				this.X0Y5_玉2.Dra = value;
				this.X0Y6_玉2.Dra = value;
				this.X0Y7_玉2.Dra = value;
				this.X0Y8_玉2.Dra = value;
				this.X0Y9_玉2.Dra = value;
				this.X0Y10_玉2.Dra = value;
				this.X0Y11_玉2.Dra = value;
				this.X0Y0_玉2.Hit = value;
				this.X0Y1_玉2.Hit = value;
				this.X0Y2_玉2.Hit = value;
				this.X0Y3_玉2.Hit = value;
				this.X0Y4_玉2.Hit = value;
				this.X0Y5_玉2.Hit = value;
				this.X0Y6_玉2.Hit = value;
				this.X0Y7_玉2.Hit = value;
				this.X0Y8_玉2.Hit = value;
				this.X0Y9_玉2.Hit = value;
				this.X0Y10_玉2.Hit = value;
				this.X0Y11_玉2.Hit = value;
			}
		}

		public bool 玉3_表示
		{
			get
			{
				return this.X0Y0_玉3.Dra;
			}
			set
			{
				this.X0Y0_玉3.Dra = value;
				this.X0Y1_玉3.Dra = value;
				this.X0Y2_玉3.Dra = value;
				this.X0Y3_玉3.Dra = value;
				this.X0Y4_玉3.Dra = value;
				this.X0Y5_玉3.Dra = value;
				this.X0Y6_玉3.Dra = value;
				this.X0Y7_玉3.Dra = value;
				this.X0Y8_玉3.Dra = value;
				this.X0Y9_玉3.Dra = value;
				this.X0Y0_玉3.Hit = value;
				this.X0Y1_玉3.Hit = value;
				this.X0Y2_玉3.Hit = value;
				this.X0Y3_玉3.Hit = value;
				this.X0Y4_玉3.Hit = value;
				this.X0Y5_玉3.Hit = value;
				this.X0Y6_玉3.Hit = value;
				this.X0Y7_玉3.Hit = value;
				this.X0Y8_玉3.Hit = value;
				this.X0Y9_玉3.Hit = value;
			}
		}

		public bool 玉4_表示
		{
			get
			{
				return this.X0Y0_玉4.Dra;
			}
			set
			{
				this.X0Y0_玉4.Dra = value;
				this.X0Y1_玉4.Dra = value;
				this.X0Y2_玉4.Dra = value;
				this.X0Y3_玉4.Dra = value;
				this.X0Y4_玉4.Dra = value;
				this.X0Y5_玉4.Dra = value;
				this.X0Y6_玉4.Dra = value;
				this.X0Y7_玉4.Dra = value;
				this.X0Y0_玉4.Hit = value;
				this.X0Y1_玉4.Hit = value;
				this.X0Y2_玉4.Hit = value;
				this.X0Y3_玉4.Hit = value;
				this.X0Y4_玉4.Hit = value;
				this.X0Y5_玉4.Hit = value;
				this.X0Y6_玉4.Hit = value;
				this.X0Y7_玉4.Hit = value;
			}
		}

		public bool 玉5_表示
		{
			get
			{
				return this.X0Y0_玉5.Dra;
			}
			set
			{
				this.X0Y0_玉5.Dra = value;
				this.X0Y1_玉5.Dra = value;
				this.X0Y2_玉5.Dra = value;
				this.X0Y3_玉5.Dra = value;
				this.X0Y4_玉5.Dra = value;
				this.X0Y5_玉5.Dra = value;
				this.X0Y0_玉5.Hit = value;
				this.X0Y1_玉5.Hit = value;
				this.X0Y2_玉5.Hit = value;
				this.X0Y3_玉5.Hit = value;
				this.X0Y4_玉5.Hit = value;
				this.X0Y5_玉5.Hit = value;
			}
		}

		public bool 玉6_表示
		{
			get
			{
				return this.X0Y0_玉6.Dra;
			}
			set
			{
				this.X0Y0_玉6.Dra = value;
				this.X0Y1_玉6.Dra = value;
				this.X0Y2_玉6.Dra = value;
				this.X0Y3_玉6.Dra = value;
				this.X0Y0_玉6.Hit = value;
				this.X0Y1_玉6.Hit = value;
				this.X0Y2_玉6.Hit = value;
				this.X0Y3_玉6.Hit = value;
			}
		}

		public bool 玉7_表示
		{
			get
			{
				return this.X0Y0_玉7.Dra;
			}
			set
			{
				this.X0Y0_玉7.Dra = value;
				this.X0Y1_玉7.Dra = value;
				this.X0Y0_玉7.Hit = value;
				this.X0Y1_玉7.Hit = value;
			}
		}

		public bool 輪上_表示
		{
			get
			{
				return this.X0Y0_輪上.Dra;
			}
			set
			{
				this.X0Y0_輪上.Dra = value;
				this.X0Y1_輪上.Dra = value;
				this.X0Y2_輪上.Dra = value;
				this.X0Y3_輪上.Dra = value;
				this.X0Y4_輪上.Dra = value;
				this.X0Y5_輪上.Dra = value;
				this.X0Y6_輪上.Dra = value;
				this.X0Y7_輪上.Dra = value;
				this.X0Y8_輪上.Dra = value;
				this.X0Y9_輪上.Dra = value;
				this.X0Y10_輪上.Dra = value;
				this.X0Y11_輪上.Dra = value;
				this.X0Y12_輪上.Dra = value;
				this.X0Y13_輪上.Dra = value;
				this.X0Y14_輪上.Dra = value;
				this.X0Y15_輪上.Dra = value;
				this.X0Y0_輪上.Hit = value;
				this.X0Y1_輪上.Hit = value;
				this.X0Y2_輪上.Hit = value;
				this.X0Y3_輪上.Hit = value;
				this.X0Y4_輪上.Hit = value;
				this.X0Y5_輪上.Hit = value;
				this.X0Y6_輪上.Hit = value;
				this.X0Y7_輪上.Hit = value;
				this.X0Y8_輪上.Hit = value;
				this.X0Y9_輪上.Hit = value;
				this.X0Y10_輪上.Hit = value;
				this.X0Y11_輪上.Hit = value;
				this.X0Y12_輪上.Hit = value;
				this.X0Y13_輪上.Hit = value;
				this.X0Y14_輪上.Hit = value;
				this.X0Y15_輪上.Hit = value;
			}
		}

		public bool 輪下_表示
		{
			get
			{
				return this.X0Y0_輪下.Dra;
			}
			set
			{
				this.X0Y0_輪下.Dra = value;
				this.X0Y1_輪下.Dra = value;
				this.X0Y2_輪下.Dra = value;
				this.X0Y3_輪下.Dra = value;
				this.X0Y4_輪下.Dra = value;
				this.X0Y5_輪下.Dra = value;
				this.X0Y6_輪下.Dra = value;
				this.X0Y7_輪下.Dra = value;
				this.X0Y8_輪下.Dra = value;
				this.X0Y9_輪下.Dra = value;
				this.X0Y10_輪下.Dra = value;
				this.X0Y11_輪下.Dra = value;
				this.X0Y12_輪下.Dra = value;
				this.X0Y13_輪下.Dra = value;
				this.X0Y14_輪下.Dra = value;
				this.X0Y15_輪下.Dra = value;
				this.X0Y16_輪下.Dra = value;
				this.X0Y0_輪下.Hit = value;
				this.X0Y1_輪下.Hit = value;
				this.X0Y2_輪下.Hit = value;
				this.X0Y3_輪下.Hit = value;
				this.X0Y4_輪下.Hit = value;
				this.X0Y5_輪下.Hit = value;
				this.X0Y6_輪下.Hit = value;
				this.X0Y7_輪下.Hit = value;
				this.X0Y8_輪下.Hit = value;
				this.X0Y9_輪下.Hit = value;
				this.X0Y10_輪下.Hit = value;
				this.X0Y11_輪下.Hit = value;
				this.X0Y12_輪下.Hit = value;
				this.X0Y13_輪下.Hit = value;
				this.X0Y14_輪下.Hit = value;
				this.X0Y15_輪下.Hit = value;
				this.X0Y16_輪下.Hit = value;
			}
		}

		public bool 玉_表示
		{
			get
			{
				return this.X0Y12_玉.Dra;
			}
			set
			{
				this.X0Y12_玉.Dra = value;
				this.X0Y13_玉.Dra = value;
				this.X0Y12_玉.Hit = value;
				this.X0Y13_玉.Hit = value;
			}
		}

		public bool 輪上境界_表示
		{
			get
			{
				return this.X0Y16_輪上境界.Dra;
			}
			set
			{
				this.X0Y16_輪上境界.Dra = value;
				this.X0Y16_輪上境界.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.軸_表示;
			}
			set
			{
				this.軸_表示 = value;
				this.玉境界_表示 = value;
				this.玉1_表示 = value;
				this.玉2_表示 = value;
				this.玉3_表示 = value;
				this.玉4_表示 = value;
				this.玉5_表示 = value;
				this.玉6_表示 = value;
				this.玉7_表示 = value;
				this.輪上_表示 = value;
				this.輪下_表示 = value;
				this.玉_表示 = value;
				this.輪上境界_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.軸CD.不透明度;
			}
			set
			{
				this.軸CD.不透明度 = value;
				this.玉境界CD.不透明度 = value;
				this.玉1CD.不透明度 = value;
				this.玉2CD.不透明度 = value;
				this.玉3CD.不透明度 = value;
				this.玉4CD.不透明度 = value;
				this.玉5CD.不透明度 = value;
				this.玉6CD.不透明度 = value;
				this.玉7CD.不透明度 = value;
				this.輪上CD.不透明度 = value;
				this.輪上境界CD.不透明度 = value;
				this.輪下CD.不透明度 = value;
			}
		}

		public override void 色更新()
		{
			switch (this.本体.IndexY)
			{
			case 0:
				this.X0Y0_軸CP.Update();
				this.X0Y0_玉境界CP.Update();
				this.X0Y0_玉1CP.Update();
				this.X0Y0_玉2CP.Update();
				this.X0Y0_玉3CP.Update();
				this.X0Y0_玉4CP.Update();
				this.X0Y0_玉5CP.Update();
				this.X0Y0_玉6CP.Update();
				this.X0Y0_玉7CP.Update();
				this.X0Y0_輪上CP.Update();
				this.X0Y0_輪下CP.Update();
				return;
			case 1:
				this.X0Y1_軸CP.Update();
				this.X0Y1_玉境界CP.Update();
				this.X0Y1_玉1CP.Update();
				this.X0Y1_玉2CP.Update();
				this.X0Y1_玉3CP.Update();
				this.X0Y1_玉4CP.Update();
				this.X0Y1_玉5CP.Update();
				this.X0Y1_玉6CP.Update();
				this.X0Y1_玉7CP.Update();
				this.X0Y1_輪上CP.Update();
				this.X0Y1_輪下CP.Update();
				return;
			case 2:
				this.X0Y2_軸CP.Update();
				this.X0Y2_玉境界CP.Update();
				this.X0Y2_玉1CP.Update();
				this.X0Y2_玉2CP.Update();
				this.X0Y2_玉3CP.Update();
				this.X0Y2_玉4CP.Update();
				this.X0Y2_玉5CP.Update();
				this.X0Y2_玉6CP.Update();
				this.X0Y2_輪上CP.Update();
				this.X0Y2_輪下CP.Update();
				return;
			case 3:
				this.X0Y3_軸CP.Update();
				this.X0Y3_玉境界CP.Update();
				this.X0Y3_玉1CP.Update();
				this.X0Y3_玉2CP.Update();
				this.X0Y3_玉3CP.Update();
				this.X0Y3_玉4CP.Update();
				this.X0Y3_玉5CP.Update();
				this.X0Y3_玉6CP.Update();
				this.X0Y3_輪上CP.Update();
				this.X0Y3_輪下CP.Update();
				return;
			case 4:
				this.X0Y4_軸CP.Update();
				this.X0Y4_玉境界CP.Update();
				this.X0Y4_玉1CP.Update();
				this.X0Y4_玉2CP.Update();
				this.X0Y4_玉3CP.Update();
				this.X0Y4_玉4CP.Update();
				this.X0Y4_玉5CP.Update();
				this.X0Y4_輪上CP.Update();
				this.X0Y4_輪下CP.Update();
				return;
			case 5:
				this.X0Y5_軸CP.Update();
				this.X0Y5_玉境界CP.Update();
				this.X0Y5_玉1CP.Update();
				this.X0Y5_玉2CP.Update();
				this.X0Y5_玉3CP.Update();
				this.X0Y5_玉4CP.Update();
				this.X0Y5_玉5CP.Update();
				this.X0Y5_輪上CP.Update();
				this.X0Y5_輪下CP.Update();
				return;
			case 6:
				this.X0Y6_軸CP.Update();
				this.X0Y6_玉境界CP.Update();
				this.X0Y6_玉1CP.Update();
				this.X0Y6_玉2CP.Update();
				this.X0Y6_玉3CP.Update();
				this.X0Y6_玉4CP.Update();
				this.X0Y6_輪上CP.Update();
				this.X0Y6_輪下CP.Update();
				return;
			case 7:
				this.X0Y7_軸CP.Update();
				this.X0Y7_玉境界CP.Update();
				this.X0Y7_玉1CP.Update();
				this.X0Y7_玉2CP.Update();
				this.X0Y7_玉3CP.Update();
				this.X0Y7_玉4CP.Update();
				this.X0Y7_輪上CP.Update();
				this.X0Y7_輪下CP.Update();
				return;
			case 8:
				this.X0Y8_軸CP.Update();
				this.X0Y8_玉境界CP.Update();
				this.X0Y8_玉1CP.Update();
				this.X0Y8_玉2CP.Update();
				this.X0Y8_玉3CP.Update();
				this.X0Y8_輪上CP.Update();
				this.X0Y8_輪下CP.Update();
				return;
			case 9:
				this.X0Y9_軸CP.Update();
				this.X0Y9_玉境界CP.Update();
				this.X0Y9_玉1CP.Update();
				this.X0Y9_玉2CP.Update();
				this.X0Y9_玉3CP.Update();
				this.X0Y9_輪上CP.Update();
				this.X0Y9_輪下CP.Update();
				return;
			case 10:
				this.X0Y10_軸CP.Update();
				this.X0Y10_玉境界CP.Update();
				this.X0Y10_玉1CP.Update();
				this.X0Y10_玉2CP.Update();
				this.X0Y10_輪上CP.Update();
				this.X0Y10_輪下CP.Update();
				return;
			case 11:
				this.X0Y11_軸CP.Update();
				this.X0Y11_玉境界CP.Update();
				this.X0Y11_玉1CP.Update();
				this.X0Y11_玉2CP.Update();
				this.X0Y11_輪上CP.Update();
				this.X0Y11_輪下CP.Update();
				return;
			case 12:
				this.X0Y12_軸CP.Update();
				this.X0Y12_玉境界CP.Update();
				this.X0Y12_玉CP.Update();
				this.X0Y12_輪上CP.Update();
				this.X0Y12_輪下CP.Update();
				return;
			case 13:
				this.X0Y13_軸CP.Update();
				this.X0Y13_玉境界CP.Update();
				this.X0Y13_玉CP.Update();
				this.X0Y13_輪上CP.Update();
				this.X0Y13_輪下CP.Update();
				return;
			case 14:
				this.X0Y14_軸CP.Update();
				this.X0Y14_玉境界CP.Update();
				this.X0Y14_輪上CP.Update();
				this.X0Y14_輪下CP.Update();
				return;
			case 15:
				this.X0Y15_軸CP.Update();
				this.X0Y15_玉境界CP.Update();
				this.X0Y15_輪上CP.Update();
				this.X0Y15_輪下CP.Update();
				return;
			default:
				this.X0Y16_軸CP.Update();
				this.X0Y16_輪上境界CP.Update();
				this.X0Y16_輪下CP.Update();
				return;
			}
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			Color2 color;
			Col.GetGrad(ref Col.Pink, out color);
			this.軸CD = new ColorD(ref Col.Black, ref color);
			this.玉境界CD = new ColorD(ref Col.Black, ref color);
			this.玉1CD = new ColorD(ref Col.Black, ref color);
			this.玉2CD = new ColorD(ref Col.Black, ref color);
			this.玉3CD = new ColorD(ref Col.Black, ref color);
			this.玉4CD = new ColorD(ref Col.Black, ref color);
			this.玉5CD = new ColorD(ref Col.Black, ref color);
			this.玉6CD = new ColorD(ref Col.Black, ref color);
			this.玉7CD = new ColorD(ref Col.Black, ref color);
			this.輪上CD = new ColorD(ref Col.Black, ref color);
			this.輪上境界CD = new ColorD(ref Col.Black, ref color);
			this.輪下CD = new ColorD(ref Col.Black, ref color);
		}

		public Par X0Y0_軸;

		public Par X0Y0_玉境界;

		public Par X0Y0_玉1;

		public Par X0Y0_玉2;

		public Par X0Y0_玉3;

		public Par X0Y0_玉4;

		public Par X0Y0_玉5;

		public Par X0Y0_玉6;

		public Par X0Y0_玉7;

		public Par X0Y0_輪上;

		public Par X0Y0_輪下;

		public Par X0Y1_軸;

		public Par X0Y1_玉境界;

		public Par X0Y1_玉1;

		public Par X0Y1_玉2;

		public Par X0Y1_玉3;

		public Par X0Y1_玉4;

		public Par X0Y1_玉5;

		public Par X0Y1_玉6;

		public Par X0Y1_玉7;

		public Par X0Y1_輪上;

		public Par X0Y1_輪下;

		public Par X0Y2_軸;

		public Par X0Y2_玉境界;

		public Par X0Y2_玉1;

		public Par X0Y2_玉2;

		public Par X0Y2_玉3;

		public Par X0Y2_玉4;

		public Par X0Y2_玉5;

		public Par X0Y2_玉6;

		public Par X0Y2_輪上;

		public Par X0Y2_輪下;

		public Par X0Y3_軸;

		public Par X0Y3_玉境界;

		public Par X0Y3_玉1;

		public Par X0Y3_玉2;

		public Par X0Y3_玉3;

		public Par X0Y3_玉4;

		public Par X0Y3_玉5;

		public Par X0Y3_玉6;

		public Par X0Y3_輪上;

		public Par X0Y3_輪下;

		public Par X0Y4_軸;

		public Par X0Y4_玉境界;

		public Par X0Y4_玉1;

		public Par X0Y4_玉2;

		public Par X0Y4_玉3;

		public Par X0Y4_玉4;

		public Par X0Y4_玉5;

		public Par X0Y4_輪上;

		public Par X0Y4_輪下;

		public Par X0Y5_軸;

		public Par X0Y5_玉境界;

		public Par X0Y5_玉1;

		public Par X0Y5_玉2;

		public Par X0Y5_玉3;

		public Par X0Y5_玉4;

		public Par X0Y5_玉5;

		public Par X0Y5_輪上;

		public Par X0Y5_輪下;

		public Par X0Y6_軸;

		public Par X0Y6_玉境界;

		public Par X0Y6_玉1;

		public Par X0Y6_玉2;

		public Par X0Y6_玉3;

		public Par X0Y6_玉4;

		public Par X0Y6_輪上;

		public Par X0Y6_輪下;

		public Par X0Y7_軸;

		public Par X0Y7_玉境界;

		public Par X0Y7_玉1;

		public Par X0Y7_玉2;

		public Par X0Y7_玉3;

		public Par X0Y7_玉4;

		public Par X0Y7_輪上;

		public Par X0Y7_輪下;

		public Par X0Y8_軸;

		public Par X0Y8_玉境界;

		public Par X0Y8_玉1;

		public Par X0Y8_玉2;

		public Par X0Y8_玉3;

		public Par X0Y8_輪上;

		public Par X0Y8_輪下;

		public Par X0Y9_軸;

		public Par X0Y9_玉境界;

		public Par X0Y9_玉1;

		public Par X0Y9_玉2;

		public Par X0Y9_玉3;

		public Par X0Y9_輪上;

		public Par X0Y9_輪下;

		public Par X0Y10_軸;

		public Par X0Y10_玉境界;

		public Par X0Y10_玉1;

		public Par X0Y10_玉2;

		public Par X0Y10_輪上;

		public Par X0Y10_輪下;

		public Par X0Y11_軸;

		public Par X0Y11_玉境界;

		public Par X0Y11_玉1;

		public Par X0Y11_玉2;

		public Par X0Y11_輪上;

		public Par X0Y11_輪下;

		public Par X0Y12_軸;

		public Par X0Y12_玉境界;

		public Par X0Y12_玉;

		public Par X0Y12_輪上;

		public Par X0Y12_輪下;

		public Par X0Y13_軸;

		public Par X0Y13_玉境界;

		public Par X0Y13_玉;

		public Par X0Y13_輪上;

		public Par X0Y13_輪下;

		public Par X0Y14_軸;

		public Par X0Y14_玉境界;

		public Par X0Y14_輪上;

		public Par X0Y14_輪下;

		public Par X0Y15_軸;

		public Par X0Y15_玉境界;

		public Par X0Y15_輪上;

		public Par X0Y15_輪下;

		public Par X0Y16_軸;

		public Par X0Y16_輪上境界;

		public Par X0Y16_輪下;

		public ColorD 軸CD;

		public ColorD 玉境界CD;

		public ColorD 玉1CD;

		public ColorD 玉2CD;

		public ColorD 玉3CD;

		public ColorD 玉4CD;

		public ColorD 玉5CD;

		public ColorD 玉6CD;

		public ColorD 玉7CD;

		public ColorD 輪上CD;

		public ColorD 輪上境界CD;

		public ColorD 輪下CD;

		public ColorP X0Y0_軸CP;

		public ColorP X0Y0_玉境界CP;

		public ColorP X0Y0_玉1CP;

		public ColorP X0Y0_玉2CP;

		public ColorP X0Y0_玉3CP;

		public ColorP X0Y0_玉4CP;

		public ColorP X0Y0_玉5CP;

		public ColorP X0Y0_玉6CP;

		public ColorP X0Y0_玉7CP;

		public ColorP X0Y0_輪上CP;

		public ColorP X0Y0_輪下CP;

		public ColorP X0Y1_軸CP;

		public ColorP X0Y1_玉境界CP;

		public ColorP X0Y1_玉1CP;

		public ColorP X0Y1_玉2CP;

		public ColorP X0Y1_玉3CP;

		public ColorP X0Y1_玉4CP;

		public ColorP X0Y1_玉5CP;

		public ColorP X0Y1_玉6CP;

		public ColorP X0Y1_玉7CP;

		public ColorP X0Y1_輪上CP;

		public ColorP X0Y1_輪下CP;

		public ColorP X0Y2_軸CP;

		public ColorP X0Y2_玉境界CP;

		public ColorP X0Y2_玉1CP;

		public ColorP X0Y2_玉2CP;

		public ColorP X0Y2_玉3CP;

		public ColorP X0Y2_玉4CP;

		public ColorP X0Y2_玉5CP;

		public ColorP X0Y2_玉6CP;

		public ColorP X0Y2_輪上CP;

		public ColorP X0Y2_輪下CP;

		public ColorP X0Y3_軸CP;

		public ColorP X0Y3_玉境界CP;

		public ColorP X0Y3_玉1CP;

		public ColorP X0Y3_玉2CP;

		public ColorP X0Y3_玉3CP;

		public ColorP X0Y3_玉4CP;

		public ColorP X0Y3_玉5CP;

		public ColorP X0Y3_玉6CP;

		public ColorP X0Y3_輪上CP;

		public ColorP X0Y3_輪下CP;

		public ColorP X0Y4_軸CP;

		public ColorP X0Y4_玉境界CP;

		public ColorP X0Y4_玉1CP;

		public ColorP X0Y4_玉2CP;

		public ColorP X0Y4_玉3CP;

		public ColorP X0Y4_玉4CP;

		public ColorP X0Y4_玉5CP;

		public ColorP X0Y4_輪上CP;

		public ColorP X0Y4_輪下CP;

		public ColorP X0Y5_軸CP;

		public ColorP X0Y5_玉境界CP;

		public ColorP X0Y5_玉1CP;

		public ColorP X0Y5_玉2CP;

		public ColorP X0Y5_玉3CP;

		public ColorP X0Y5_玉4CP;

		public ColorP X0Y5_玉5CP;

		public ColorP X0Y5_輪上CP;

		public ColorP X0Y5_輪下CP;

		public ColorP X0Y6_軸CP;

		public ColorP X0Y6_玉境界CP;

		public ColorP X0Y6_玉1CP;

		public ColorP X0Y6_玉2CP;

		public ColorP X0Y6_玉3CP;

		public ColorP X0Y6_玉4CP;

		public ColorP X0Y6_輪上CP;

		public ColorP X0Y6_輪下CP;

		public ColorP X0Y7_軸CP;

		public ColorP X0Y7_玉境界CP;

		public ColorP X0Y7_玉1CP;

		public ColorP X0Y7_玉2CP;

		public ColorP X0Y7_玉3CP;

		public ColorP X0Y7_玉4CP;

		public ColorP X0Y7_輪上CP;

		public ColorP X0Y7_輪下CP;

		public ColorP X0Y8_軸CP;

		public ColorP X0Y8_玉境界CP;

		public ColorP X0Y8_玉1CP;

		public ColorP X0Y8_玉2CP;

		public ColorP X0Y8_玉3CP;

		public ColorP X0Y8_輪上CP;

		public ColorP X0Y8_輪下CP;

		public ColorP X0Y9_軸CP;

		public ColorP X0Y9_玉境界CP;

		public ColorP X0Y9_玉1CP;

		public ColorP X0Y9_玉2CP;

		public ColorP X0Y9_玉3CP;

		public ColorP X0Y9_輪上CP;

		public ColorP X0Y9_輪下CP;

		public ColorP X0Y10_軸CP;

		public ColorP X0Y10_玉境界CP;

		public ColorP X0Y10_玉1CP;

		public ColorP X0Y10_玉2CP;

		public ColorP X0Y10_輪上CP;

		public ColorP X0Y10_輪下CP;

		public ColorP X0Y11_軸CP;

		public ColorP X0Y11_玉境界CP;

		public ColorP X0Y11_玉1CP;

		public ColorP X0Y11_玉2CP;

		public ColorP X0Y11_輪上CP;

		public ColorP X0Y11_輪下CP;

		public ColorP X0Y12_軸CP;

		public ColorP X0Y12_玉境界CP;

		public ColorP X0Y12_玉CP;

		public ColorP X0Y12_輪上CP;

		public ColorP X0Y12_輪下CP;

		public ColorP X0Y13_軸CP;

		public ColorP X0Y13_玉境界CP;

		public ColorP X0Y13_玉CP;

		public ColorP X0Y13_輪上CP;

		public ColorP X0Y13_輪下CP;

		public ColorP X0Y14_軸CP;

		public ColorP X0Y14_玉境界CP;

		public ColorP X0Y14_輪上CP;

		public ColorP X0Y14_輪下CP;

		public ColorP X0Y15_軸CP;

		public ColorP X0Y15_玉境界CP;

		public ColorP X0Y15_輪上CP;

		public ColorP X0Y15_輪下CP;

		public ColorP X0Y16_軸CP;

		public ColorP X0Y16_輪上境界CP;

		public ColorP X0Y16_輪下CP;
	}
}
