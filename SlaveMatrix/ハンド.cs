using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class ハンド : Ele
	{
		public ハンド(double DisUnit, 配色指定 配色指定, 主人公配色 体配色, Med Med, ハンドD e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.カ\u30FCソル["ハンド"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_親指 = pars["親指"].ToPar();
			this.X0Y0_手 = pars["手"].ToPar();
			this.X0Y0_小指 = pars["小指"].ToPar();
			this.X0Y0_薬指 = pars["薬指"].ToPar();
			this.X0Y0_中指 = pars["中指"].ToPar();
			this.X0Y0_人指 = pars["人指"].ToPar();
			Pars pars2 = pars["呪印"].ToPars();
			Pars pars3 = pars2["輪1"].ToPars();
			this.X0Y0_呪印_輪1_輪外 = pars3["輪外"].ToPar();
			this.X0Y0_呪印_輪1_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X0Y0_呪印_輪2_輪外 = pars3["輪外"].ToPar();
			this.X0Y0_呪印_輪2_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪3"].ToPars();
			this.X0Y0_呪印_輪3_輪外 = pars3["輪外"].ToPar();
			this.X0Y0_呪印_輪3_輪内 = pars3["輪内"].ToPar();
			this.X0Y0_呪印_鎖1 = pars2["鎖1"].ToPar();
			this.X0Y0_呪印_鎖2 = pars2["鎖2"].ToPar();
			this.X0Y0_呪印_鎖3 = pars2["鎖3"].ToPar();
			pars = this.本体[1][0];
			this.X1Y0_親指 = pars["親指"].ToPar();
			this.X1Y0_手 = pars["手"].ToPar();
			this.X1Y0_小指 = pars["小指"].ToPar();
			this.X1Y0_薬指 = pars["薬指"].ToPar();
			this.X1Y0_中指 = pars["中指"].ToPar();
			this.X1Y0_人指 = pars["人指"].ToPar();
			pars2 = pars["呪印"].ToPars();
			pars3 = pars2["輪1"].ToPars();
			this.X1Y0_呪印_輪1_輪外 = pars3["輪外"].ToPar();
			this.X1Y0_呪印_輪1_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X1Y0_呪印_輪2_輪外 = pars3["輪外"].ToPar();
			this.X1Y0_呪印_輪2_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪3"].ToPars();
			this.X1Y0_呪印_輪3_輪外 = pars3["輪外"].ToPar();
			this.X1Y0_呪印_輪3_輪内 = pars3["輪内"].ToPar();
			this.X1Y0_呪印_鎖1 = pars2["鎖1"].ToPar();
			this.X1Y0_呪印_鎖2 = pars2["鎖2"].ToPar();
			this.X1Y0_呪印_鎖3 = pars2["鎖3"].ToPar();
			pars = this.本体[2][0];
			this.X2Y0_親指 = pars["親指"].ToPar();
			this.X2Y0_手 = pars["手"].ToPar();
			this.X2Y0_小指 = pars["小指"].ToPar();
			this.X2Y0_薬指 = pars["薬指"].ToPar();
			this.X2Y0_中指 = pars["中指"].ToPar();
			this.X2Y0_人指 = pars["人指"].ToPar();
			pars2 = pars["呪印"].ToPars();
			pars3 = pars2["輪1"].ToPars();
			this.X2Y0_呪印_輪1_輪外 = pars3["輪外"].ToPar();
			this.X2Y0_呪印_輪1_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X2Y0_呪印_輪2_輪外 = pars3["輪外"].ToPar();
			this.X2Y0_呪印_輪2_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪3"].ToPars();
			this.X2Y0_呪印_輪3_輪外 = pars3["輪外"].ToPar();
			this.X2Y0_呪印_輪3_輪内 = pars3["輪内"].ToPar();
			this.X2Y0_呪印_鎖1 = pars2["鎖1"].ToPar();
			this.X2Y0_呪印_鎖2 = pars2["鎖2"].ToPar();
			this.X2Y0_呪印_鎖3 = pars2["鎖3"].ToPar();
			pars = this.本体[2][1];
			this.X2Y1_親指 = pars["親指"].ToPar();
			this.X2Y1_手 = pars["手"].ToPar();
			this.X2Y1_小指 = pars["小指"].ToPar();
			this.X2Y1_薬指 = pars["薬指"].ToPar();
			this.X2Y1_中指 = pars["中指"].ToPar();
			this.X2Y1_人指 = pars["人指"].ToPar();
			pars2 = pars["呪印"].ToPars();
			pars3 = pars2["輪1"].ToPars();
			this.X2Y1_呪印_輪1_輪外 = pars3["輪外"].ToPar();
			this.X2Y1_呪印_輪1_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X2Y1_呪印_輪2_輪外 = pars3["輪外"].ToPar();
			this.X2Y1_呪印_輪2_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪3"].ToPars();
			this.X2Y1_呪印_輪3_輪外 = pars3["輪外"].ToPar();
			this.X2Y1_呪印_輪3_輪内 = pars3["輪内"].ToPar();
			this.X2Y1_呪印_鎖1 = pars2["鎖1"].ToPar();
			this.X2Y1_呪印_鎖2 = pars2["鎖2"].ToPar();
			this.X2Y1_呪印_鎖3 = pars2["鎖3"].ToPar();
			pars = this.本体[2][2];
			this.X2Y2_親指 = pars["親指"].ToPar();
			this.X2Y2_手 = pars["手"].ToPar();
			this.X2Y2_小指 = pars["小指"].ToPar();
			this.X2Y2_薬指 = pars["薬指"].ToPar();
			this.X2Y2_中指 = pars["中指"].ToPar();
			this.X2Y2_人指 = pars["人指"].ToPar();
			pars2 = pars["呪印"].ToPars();
			pars3 = pars2["輪1"].ToPars();
			this.X2Y2_呪印_輪1_輪外 = pars3["輪外"].ToPar();
			this.X2Y2_呪印_輪1_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X2Y2_呪印_輪2_輪外 = pars3["輪外"].ToPar();
			this.X2Y2_呪印_輪2_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪3"].ToPars();
			this.X2Y2_呪印_輪3_輪外 = pars3["輪外"].ToPar();
			this.X2Y2_呪印_輪3_輪内 = pars3["輪内"].ToPar();
			this.X2Y2_呪印_鎖1 = pars2["鎖1"].ToPar();
			this.X2Y2_呪印_鎖2 = pars2["鎖2"].ToPar();
			this.X2Y2_呪印_鎖3 = pars2["鎖3"].ToPar();
			pars = this.本体[2][3];
			this.X2Y3_親指 = pars["親指"].ToPar();
			this.X2Y3_手 = pars["手"].ToPar();
			this.X2Y3_小指 = pars["小指"].ToPar();
			this.X2Y3_薬指 = pars["薬指"].ToPar();
			this.X2Y3_中指 = pars["中指"].ToPar();
			this.X2Y3_人指 = pars["人指"].ToPar();
			pars2 = pars["呪印"].ToPars();
			pars3 = pars2["輪1"].ToPars();
			this.X2Y3_呪印_輪1_輪外 = pars3["輪外"].ToPar();
			this.X2Y3_呪印_輪1_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X2Y3_呪印_輪2_輪外 = pars3["輪外"].ToPar();
			this.X2Y3_呪印_輪2_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪3"].ToPars();
			this.X2Y3_呪印_輪3_輪外 = pars3["輪外"].ToPar();
			this.X2Y3_呪印_輪3_輪内 = pars3["輪内"].ToPar();
			this.X2Y3_呪印_鎖1 = pars2["鎖1"].ToPar();
			this.X2Y3_呪印_鎖2 = pars2["鎖2"].ToPar();
			this.X2Y3_呪印_鎖3 = pars2["鎖3"].ToPar();
			pars = this.本体[2][4];
			this.X2Y4_親指 = pars["親指"].ToPar();
			this.X2Y4_手 = pars["手"].ToPar();
			this.X2Y4_小指 = pars["小指"].ToPar();
			this.X2Y4_薬指 = pars["薬指"].ToPar();
			this.X2Y4_中指 = pars["中指"].ToPar();
			this.X2Y4_人指 = pars["人指"].ToPar();
			pars2 = pars["呪印"].ToPars();
			pars3 = pars2["輪1"].ToPars();
			this.X2Y4_呪印_輪1_輪外 = pars3["輪外"].ToPar();
			this.X2Y4_呪印_輪1_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X2Y4_呪印_輪2_輪外 = pars3["輪外"].ToPar();
			this.X2Y4_呪印_輪2_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪3"].ToPars();
			this.X2Y4_呪印_輪3_輪外 = pars3["輪外"].ToPar();
			this.X2Y4_呪印_輪3_輪内 = pars3["輪内"].ToPar();
			this.X2Y4_呪印_鎖1 = pars2["鎖1"].ToPar();
			this.X2Y4_呪印_鎖2 = pars2["鎖2"].ToPar();
			this.X2Y4_呪印_鎖3 = pars2["鎖3"].ToPar();
			pars = this.本体[3][0];
			this.X3Y0_親指 = pars["親指"].ToPar();
			this.X3Y0_手 = pars["手"].ToPar();
			this.X3Y0_小指 = pars["小指"].ToPar();
			this.X3Y0_薬指 = pars["薬指"].ToPar();
			this.X3Y0_中指 = pars["中指"].ToPar();
			this.X3Y0_人指 = pars["人指"].ToPar();
			pars2 = pars["呪印"].ToPars();
			pars3 = pars2["輪1"].ToPars();
			this.X3Y0_呪印_輪1_輪外 = pars3["輪外"].ToPar();
			this.X3Y0_呪印_輪1_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X3Y0_呪印_輪2_輪外 = pars3["輪外"].ToPar();
			this.X3Y0_呪印_輪2_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪3"].ToPars();
			this.X3Y0_呪印_輪3_輪外 = pars3["輪外"].ToPar();
			this.X3Y0_呪印_輪3_輪内 = pars3["輪内"].ToPar();
			this.X3Y0_呪印_鎖1 = pars2["鎖1"].ToPar();
			this.X3Y0_呪印_鎖2 = pars2["鎖2"].ToPar();
			this.X3Y0_呪印_鎖3 = pars2["鎖3"].ToPar();
			pars = this.本体[4][0];
			this.X4Y0_親指 = pars["親指"].ToPar();
			this.X4Y0_手 = pars["手"].ToPar();
			this.X4Y0_小指 = pars["小指"].ToPar();
			this.X4Y0_薬指 = pars["薬指"].ToPar();
			this.X4Y0_中指 = pars["中指"].ToPar();
			this.X4Y0_人指 = pars["人指"].ToPar();
			pars2 = pars["呪印"].ToPars();
			pars3 = pars2["輪1"].ToPars();
			this.X4Y0_呪印_輪1_輪外 = pars3["輪外"].ToPar();
			this.X4Y0_呪印_輪1_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X4Y0_呪印_輪2_輪外 = pars3["輪外"].ToPar();
			this.X4Y0_呪印_輪2_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪3"].ToPars();
			this.X4Y0_呪印_輪3_輪外 = pars3["輪外"].ToPar();
			this.X4Y0_呪印_輪3_輪内 = pars3["輪内"].ToPar();
			this.X4Y0_呪印_鎖1 = pars2["鎖1"].ToPar();
			this.X4Y0_呪印_鎖2 = pars2["鎖2"].ToPar();
			this.X4Y0_呪印_鎖3 = pars2["鎖3"].ToPar();
			pars = this.本体[5][0];
			this.X5Y0_親指 = pars["親指"].ToPar();
			this.X5Y0_手 = pars["手"].ToPar();
			this.X5Y0_小指 = pars["小指"].ToPar();
			this.X5Y0_薬指 = pars["薬指"].ToPar();
			this.X5Y0_中指 = pars["中指"].ToPar();
			this.X5Y0_人指 = pars["人指"].ToPar();
			pars2 = pars["呪印"].ToPars();
			pars3 = pars2["輪1"].ToPars();
			this.X5Y0_呪印_輪1_輪外 = pars3["輪外"].ToPar();
			this.X5Y0_呪印_輪1_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X5Y0_呪印_輪2_輪外 = pars3["輪外"].ToPar();
			this.X5Y0_呪印_輪2_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪3"].ToPars();
			this.X5Y0_呪印_輪3_輪外 = pars3["輪外"].ToPar();
			this.X5Y0_呪印_輪3_輪内 = pars3["輪内"].ToPar();
			this.X5Y0_呪印_鎖1 = pars2["鎖1"].ToPar();
			this.X5Y0_呪印_鎖2 = pars2["鎖2"].ToPar();
			this.X5Y0_呪印_鎖3 = pars2["鎖3"].ToPar();
			pars = this.本体[5][1];
			this.X5Y1_親指 = pars["親指"].ToPar();
			this.X5Y1_手 = pars["手"].ToPar();
			this.X5Y1_小指 = pars["小指"].ToPar();
			this.X5Y1_薬指 = pars["薬指"].ToPar();
			this.X5Y1_中指 = pars["中指"].ToPar();
			this.X5Y1_人指 = pars["人指"].ToPar();
			pars2 = pars["呪印"].ToPars();
			pars3 = pars2["輪1"].ToPars();
			this.X5Y1_呪印_輪1_輪外 = pars3["輪外"].ToPar();
			this.X5Y1_呪印_輪1_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X5Y1_呪印_輪2_輪外 = pars3["輪外"].ToPar();
			this.X5Y1_呪印_輪2_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪3"].ToPars();
			this.X5Y1_呪印_輪3_輪外 = pars3["輪外"].ToPar();
			this.X5Y1_呪印_輪3_輪内 = pars3["輪内"].ToPar();
			this.X5Y1_呪印_鎖1 = pars2["鎖1"].ToPar();
			this.X5Y1_呪印_鎖2 = pars2["鎖2"].ToPar();
			this.X5Y1_呪印_鎖3 = pars2["鎖3"].ToPar();
			pars = this.本体[5][2];
			this.X5Y2_親指 = pars["親指"].ToPar();
			this.X5Y2_手 = pars["手"].ToPar();
			this.X5Y2_小指 = pars["小指"].ToPar();
			this.X5Y2_薬指 = pars["薬指"].ToPar();
			this.X5Y2_中指 = pars["中指"].ToPar();
			this.X5Y2_人指 = pars["人指"].ToPar();
			pars2 = pars["呪印"].ToPars();
			pars3 = pars2["輪1"].ToPars();
			this.X5Y2_呪印_輪1_輪外 = pars3["輪外"].ToPar();
			this.X5Y2_呪印_輪1_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X5Y2_呪印_輪2_輪外 = pars3["輪外"].ToPar();
			this.X5Y2_呪印_輪2_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪3"].ToPars();
			this.X5Y2_呪印_輪3_輪外 = pars3["輪外"].ToPar();
			this.X5Y2_呪印_輪3_輪内 = pars3["輪内"].ToPar();
			this.X5Y2_呪印_鎖1 = pars2["鎖1"].ToPar();
			this.X5Y2_呪印_鎖2 = pars2["鎖2"].ToPar();
			this.X5Y2_呪印_鎖3 = pars2["鎖3"].ToPar();
			pars = this.本体[5][3];
			this.X5Y3_親指 = pars["親指"].ToPar();
			this.X5Y3_手 = pars["手"].ToPar();
			this.X5Y3_小指 = pars["小指"].ToPar();
			this.X5Y3_薬指 = pars["薬指"].ToPar();
			this.X5Y3_中指 = pars["中指"].ToPar();
			this.X5Y3_人指 = pars["人指"].ToPar();
			pars2 = pars["呪印"].ToPars();
			pars3 = pars2["輪1"].ToPars();
			this.X5Y3_呪印_輪1_輪外 = pars3["輪外"].ToPar();
			this.X5Y3_呪印_輪1_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X5Y3_呪印_輪2_輪外 = pars3["輪外"].ToPar();
			this.X5Y3_呪印_輪2_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪3"].ToPars();
			this.X5Y3_呪印_輪3_輪外 = pars3["輪外"].ToPar();
			this.X5Y3_呪印_輪3_輪内 = pars3["輪内"].ToPar();
			this.X5Y3_呪印_鎖1 = pars2["鎖1"].ToPar();
			this.X5Y3_呪印_鎖2 = pars2["鎖2"].ToPar();
			this.X5Y3_呪印_鎖3 = pars2["鎖3"].ToPar();
			pars = this.本体[5][4];
			this.X5Y4_親指 = pars["親指"].ToPar();
			this.X5Y4_手 = pars["手"].ToPar();
			this.X5Y4_小指 = pars["小指"].ToPar();
			this.X5Y4_薬指 = pars["薬指"].ToPar();
			this.X5Y4_中指 = pars["中指"].ToPar();
			this.X5Y4_人指 = pars["人指"].ToPar();
			pars2 = pars["呪印"].ToPars();
			pars3 = pars2["輪1"].ToPars();
			this.X5Y4_呪印_輪1_輪外 = pars3["輪外"].ToPar();
			this.X5Y4_呪印_輪1_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X5Y4_呪印_輪2_輪外 = pars3["輪外"].ToPar();
			this.X5Y4_呪印_輪2_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪3"].ToPars();
			this.X5Y4_呪印_輪3_輪外 = pars3["輪外"].ToPar();
			this.X5Y4_呪印_輪3_輪内 = pars3["輪内"].ToPar();
			this.X5Y4_呪印_鎖1 = pars2["鎖1"].ToPar();
			this.X5Y4_呪印_鎖2 = pars2["鎖2"].ToPar();
			this.X5Y4_呪印_鎖3 = pars2["鎖3"].ToPar();
			pars = this.本体[6][0];
			this.X6Y0_親指 = pars["親指"].ToPar();
			this.X6Y0_手 = pars["手"].ToPar();
			this.X6Y0_小指 = pars["小指"].ToPar();
			this.X6Y0_薬指 = pars["薬指"].ToPar();
			this.X6Y0_中指 = pars["中指"].ToPar();
			this.X6Y0_人指 = pars["人指"].ToPar();
			pars2 = pars["呪印"].ToPars();
			pars3 = pars2["輪1"].ToPars();
			this.X6Y0_呪印_輪1_輪外 = pars3["輪外"].ToPar();
			this.X6Y0_呪印_輪1_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X6Y0_呪印_輪2_輪外 = pars3["輪外"].ToPar();
			this.X6Y0_呪印_輪2_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪3"].ToPars();
			this.X6Y0_呪印_輪3_輪外 = pars3["輪外"].ToPar();
			this.X6Y0_呪印_輪3_輪内 = pars3["輪内"].ToPar();
			this.X6Y0_呪印_鎖1 = pars2["鎖1"].ToPar();
			this.X6Y0_呪印_鎖2 = pars2["鎖2"].ToPar();
			this.X6Y0_呪印_鎖3 = pars2["鎖3"].ToPar();
			pars = this.本体[6][1];
			this.X6Y1_親指 = pars["親指"].ToPar();
			this.X6Y1_手 = pars["手"].ToPar();
			this.X6Y1_小指 = pars["小指"].ToPar();
			this.X6Y1_薬指 = pars["薬指"].ToPar();
			this.X6Y1_中指 = pars["中指"].ToPar();
			this.X6Y1_人指 = pars["人指"].ToPar();
			pars2 = pars["呪印"].ToPars();
			pars3 = pars2["輪1"].ToPars();
			this.X6Y1_呪印_輪1_輪外 = pars3["輪外"].ToPar();
			this.X6Y1_呪印_輪1_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X6Y1_呪印_輪2_輪外 = pars3["輪外"].ToPar();
			this.X6Y1_呪印_輪2_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪3"].ToPars();
			this.X6Y1_呪印_輪3_輪外 = pars3["輪外"].ToPar();
			this.X6Y1_呪印_輪3_輪内 = pars3["輪内"].ToPar();
			this.X6Y1_呪印_鎖1 = pars2["鎖1"].ToPar();
			this.X6Y1_呪印_鎖2 = pars2["鎖2"].ToPar();
			this.X6Y1_呪印_鎖3 = pars2["鎖3"].ToPar();
			pars = this.本体[6][2];
			this.X6Y2_親指 = pars["親指"].ToPar();
			this.X6Y2_手 = pars["手"].ToPar();
			this.X6Y2_小指 = pars["小指"].ToPar();
			this.X6Y2_薬指 = pars["薬指"].ToPar();
			this.X6Y2_中指 = pars["中指"].ToPar();
			this.X6Y2_人指 = pars["人指"].ToPar();
			pars2 = pars["呪印"].ToPars();
			pars3 = pars2["輪1"].ToPars();
			this.X6Y2_呪印_輪1_輪外 = pars3["輪外"].ToPar();
			this.X6Y2_呪印_輪1_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X6Y2_呪印_輪2_輪外 = pars3["輪外"].ToPar();
			this.X6Y2_呪印_輪2_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪3"].ToPars();
			this.X6Y2_呪印_輪3_輪外 = pars3["輪外"].ToPar();
			this.X6Y2_呪印_輪3_輪内 = pars3["輪内"].ToPar();
			this.X6Y2_呪印_鎖1 = pars2["鎖1"].ToPar();
			this.X6Y2_呪印_鎖2 = pars2["鎖2"].ToPar();
			this.X6Y2_呪印_鎖3 = pars2["鎖3"].ToPar();
			pars = this.本体[6][3];
			this.X6Y3_親指 = pars["親指"].ToPar();
			this.X6Y3_手 = pars["手"].ToPar();
			this.X6Y3_小指 = pars["小指"].ToPar();
			this.X6Y3_薬指 = pars["薬指"].ToPar();
			this.X6Y3_中指 = pars["中指"].ToPar();
			this.X6Y3_人指 = pars["人指"].ToPar();
			pars2 = pars["呪印"].ToPars();
			pars3 = pars2["輪1"].ToPars();
			this.X6Y3_呪印_輪1_輪外 = pars3["輪外"].ToPar();
			this.X6Y3_呪印_輪1_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X6Y3_呪印_輪2_輪外 = pars3["輪外"].ToPar();
			this.X6Y3_呪印_輪2_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪3"].ToPars();
			this.X6Y3_呪印_輪3_輪外 = pars3["輪外"].ToPar();
			this.X6Y3_呪印_輪3_輪内 = pars3["輪内"].ToPar();
			this.X6Y3_呪印_鎖1 = pars2["鎖1"].ToPar();
			this.X6Y3_呪印_鎖2 = pars2["鎖2"].ToPar();
			this.X6Y3_呪印_鎖3 = pars2["鎖3"].ToPar();
			pars = this.本体[6][4];
			this.X6Y4_親指 = pars["親指"].ToPar();
			this.X6Y4_手 = pars["手"].ToPar();
			this.X6Y4_小指 = pars["小指"].ToPar();
			this.X6Y4_薬指 = pars["薬指"].ToPar();
			this.X6Y4_中指 = pars["中指"].ToPar();
			this.X6Y4_人指 = pars["人指"].ToPar();
			pars2 = pars["呪印"].ToPars();
			pars3 = pars2["輪1"].ToPars();
			this.X6Y4_呪印_輪1_輪外 = pars3["輪外"].ToPar();
			this.X6Y4_呪印_輪1_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X6Y4_呪印_輪2_輪外 = pars3["輪外"].ToPar();
			this.X6Y4_呪印_輪2_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪3"].ToPars();
			this.X6Y4_呪印_輪3_輪外 = pars3["輪外"].ToPar();
			this.X6Y4_呪印_輪3_輪内 = pars3["輪内"].ToPar();
			this.X6Y4_呪印_鎖1 = pars2["鎖1"].ToPar();
			this.X6Y4_呪印_鎖2 = pars2["鎖2"].ToPar();
			this.X6Y4_呪印_鎖3 = pars2["鎖3"].ToPar();
			pars = this.本体[7][0];
			this.X7Y0_小指 = pars["小指"].ToPar();
			this.X7Y0_薬指 = pars["薬指"].ToPar();
			this.X7Y0_中指 = pars["中指"].ToPar();
			this.X7Y0_親指 = pars["親指"].ToPar();
			this.X7Y0_手 = pars["手"].ToPar();
			this.X7Y0_人指 = pars["人指"].ToPar();
			pars2 = pars["呪印"].ToPars();
			pars3 = pars2["輪1"].ToPars();
			this.X7Y0_呪印_輪1_輪外 = pars3["輪外"].ToPar();
			this.X7Y0_呪印_輪1_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X7Y0_呪印_輪2_輪外 = pars3["輪外"].ToPar();
			this.X7Y0_呪印_輪2_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪3"].ToPars();
			this.X7Y0_呪印_輪3_輪外 = pars3["輪外"].ToPar();
			this.X7Y0_呪印_輪3_輪内 = pars3["輪内"].ToPar();
			this.X7Y0_呪印_鎖1 = pars2["鎖1"].ToPar();
			this.X7Y0_呪印_鎖2 = pars2["鎖2"].ToPar();
			this.X7Y0_呪印_鎖3 = pars2["鎖3"].ToPar();
			pars = this.本体[7][1];
			this.X7Y1_小指 = pars["小指"].ToPar();
			this.X7Y1_薬指 = pars["薬指"].ToPar();
			this.X7Y1_中指 = pars["中指"].ToPar();
			this.X7Y1_親指 = pars["親指"].ToPar();
			this.X7Y1_手 = pars["手"].ToPar();
			this.X7Y1_人指 = pars["人指"].ToPar();
			pars2 = pars["呪印"].ToPars();
			pars3 = pars2["輪1"].ToPars();
			this.X7Y1_呪印_輪1_輪外 = pars3["輪外"].ToPar();
			this.X7Y1_呪印_輪1_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X7Y1_呪印_輪2_輪外 = pars3["輪外"].ToPar();
			this.X7Y1_呪印_輪2_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪3"].ToPars();
			this.X7Y1_呪印_輪3_輪外 = pars3["輪外"].ToPar();
			this.X7Y1_呪印_輪3_輪内 = pars3["輪内"].ToPar();
			this.X7Y1_呪印_鎖1 = pars2["鎖1"].ToPar();
			this.X7Y1_呪印_鎖2 = pars2["鎖2"].ToPar();
			this.X7Y1_呪印_鎖3 = pars2["鎖3"].ToPar();
			pars = this.本体[7][2];
			this.X7Y2_小指 = pars["小指"].ToPar();
			this.X7Y2_薬指 = pars["薬指"].ToPar();
			this.X7Y2_中指 = pars["中指"].ToPar();
			this.X7Y2_親指 = pars["親指"].ToPar();
			this.X7Y2_手 = pars["手"].ToPar();
			this.X7Y2_人指 = pars["人指"].ToPar();
			pars2 = pars["呪印"].ToPars();
			pars3 = pars2["輪1"].ToPars();
			this.X7Y2_呪印_輪1_輪外 = pars3["輪外"].ToPar();
			this.X7Y2_呪印_輪1_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X7Y2_呪印_輪2_輪外 = pars3["輪外"].ToPar();
			this.X7Y2_呪印_輪2_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪3"].ToPars();
			this.X7Y2_呪印_輪3_輪外 = pars3["輪外"].ToPar();
			this.X7Y2_呪印_輪3_輪内 = pars3["輪内"].ToPar();
			this.X7Y2_呪印_鎖1 = pars2["鎖1"].ToPar();
			this.X7Y2_呪印_鎖2 = pars2["鎖2"].ToPar();
			this.X7Y2_呪印_鎖3 = pars2["鎖3"].ToPar();
			pars = this.本体[7][3];
			this.X7Y3_小指 = pars["小指"].ToPar();
			this.X7Y3_薬指 = pars["薬指"].ToPar();
			this.X7Y3_中指 = pars["中指"].ToPar();
			this.X7Y3_親指 = pars["親指"].ToPar();
			this.X7Y3_手 = pars["手"].ToPar();
			this.X7Y3_人指 = pars["人指"].ToPar();
			pars2 = pars["呪印"].ToPars();
			pars3 = pars2["輪1"].ToPars();
			this.X7Y3_呪印_輪1_輪外 = pars3["輪外"].ToPar();
			this.X7Y3_呪印_輪1_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X7Y3_呪印_輪2_輪外 = pars3["輪外"].ToPar();
			this.X7Y3_呪印_輪2_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪3"].ToPars();
			this.X7Y3_呪印_輪3_輪外 = pars3["輪外"].ToPar();
			this.X7Y3_呪印_輪3_輪内 = pars3["輪内"].ToPar();
			this.X7Y3_呪印_鎖1 = pars2["鎖1"].ToPar();
			this.X7Y3_呪印_鎖2 = pars2["鎖2"].ToPar();
			this.X7Y3_呪印_鎖3 = pars2["鎖3"].ToPar();
			pars = this.本体[7][4];
			this.X7Y4_小指 = pars["小指"].ToPar();
			this.X7Y4_薬指 = pars["薬指"].ToPar();
			this.X7Y4_中指 = pars["中指"].ToPar();
			this.X7Y4_親指 = pars["親指"].ToPar();
			this.X7Y4_手 = pars["手"].ToPar();
			this.X7Y4_人指 = pars["人指"].ToPar();
			pars2 = pars["呪印"].ToPars();
			pars3 = pars2["輪1"].ToPars();
			this.X7Y4_呪印_輪1_輪外 = pars3["輪外"].ToPar();
			this.X7Y4_呪印_輪1_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X7Y4_呪印_輪2_輪外 = pars3["輪外"].ToPar();
			this.X7Y4_呪印_輪2_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪3"].ToPars();
			this.X7Y4_呪印_輪3_輪外 = pars3["輪外"].ToPar();
			this.X7Y4_呪印_輪3_輪内 = pars3["輪内"].ToPar();
			this.X7Y4_呪印_鎖1 = pars2["鎖1"].ToPar();
			this.X7Y4_呪印_鎖2 = pars2["鎖2"].ToPar();
			this.X7Y4_呪印_鎖3 = pars2["鎖3"].ToPar();
			pars = this.本体[8][0];
			this.X8Y0_手 = pars["手"].ToPar();
			this.X8Y0_小指 = pars["小指"].ToPar();
			this.X8Y0_薬指 = pars["薬指"].ToPar();
			this.X8Y0_中指 = pars["中指"].ToPar();
			this.X8Y0_人指 = pars["人指"].ToPar();
			this.X8Y0_親指 = pars["親指"].ToPar();
			pars = this.本体[8][1];
			this.X8Y1_手 = pars["手"].ToPar();
			this.X8Y1_小指 = pars["小指"].ToPar();
			this.X8Y1_薬指 = pars["薬指"].ToPar();
			this.X8Y1_中指 = pars["中指"].ToPar();
			this.X8Y1_人指 = pars["人指"].ToPar();
			this.X8Y1_親指 = pars["親指"].ToPar();
			pars = this.本体[8][2];
			this.X8Y2_手 = pars["手"].ToPar();
			this.X8Y2_小指 = pars["小指"].ToPar();
			this.X8Y2_薬指 = pars["薬指"].ToPar();
			this.X8Y2_中指 = pars["中指"].ToPar();
			this.X8Y2_人指 = pars["人指"].ToPar();
			this.X8Y2_親指 = pars["親指"].ToPar();
			pars = this.本体[8][3];
			this.X8Y3_手 = pars["手"].ToPar();
			this.X8Y3_小指 = pars["小指"].ToPar();
			this.X8Y3_薬指 = pars["薬指"].ToPar();
			this.X8Y3_中指 = pars["中指"].ToPar();
			this.X8Y3_人指 = pars["人指"].ToPar();
			this.X8Y3_親指 = pars["親指"].ToPar();
			pars = this.本体[8][4];
			this.X8Y4_手 = pars["手"].ToPar();
			this.X8Y4_小指 = pars["小指"].ToPar();
			this.X8Y4_薬指 = pars["薬指"].ToPar();
			this.X8Y4_中指 = pars["中指"].ToPar();
			this.X8Y4_人指 = pars["人指"].ToPar();
			this.X8Y4_親指 = pars["親指"].ToPar();
			pars = this.本体[9][0];
			this.X9Y0_手 = pars["手"].ToPar();
			this.X9Y0_小指 = pars["小指"].ToPar();
			this.X9Y0_薬指 = pars["薬指"].ToPar();
			this.X9Y0_中指 = pars["中指"].ToPar();
			this.X9Y0_人指 = pars["人指"].ToPar();
			this.X9Y0_親指 = pars["親指"].ToPar();
			pars = this.本体[9][1];
			this.X9Y1_手 = pars["手"].ToPar();
			this.X9Y1_小指 = pars["小指"].ToPar();
			this.X9Y1_薬指 = pars["薬指"].ToPar();
			this.X9Y1_中指 = pars["中指"].ToPar();
			this.X9Y1_人指 = pars["人指"].ToPar();
			this.X9Y1_親指 = pars["親指"].ToPar();
			pars = this.本体[9][2];
			this.X9Y2_手 = pars["手"].ToPar();
			this.X9Y2_小指 = pars["小指"].ToPar();
			this.X9Y2_薬指 = pars["薬指"].ToPar();
			this.X9Y2_中指 = pars["中指"].ToPar();
			this.X9Y2_人指 = pars["人指"].ToPar();
			this.X9Y2_親指 = pars["親指"].ToPar();
			pars = this.本体[9][3];
			this.X9Y3_手 = pars["手"].ToPar();
			this.X9Y3_小指 = pars["小指"].ToPar();
			this.X9Y3_薬指 = pars["薬指"].ToPar();
			this.X9Y3_中指 = pars["中指"].ToPar();
			this.X9Y3_人指 = pars["人指"].ToPar();
			this.X9Y3_親指 = pars["親指"].ToPar();
			pars = this.本体[9][4];
			this.X9Y4_手 = pars["手"].ToPar();
			this.X9Y4_小指 = pars["小指"].ToPar();
			this.X9Y4_薬指 = pars["薬指"].ToPar();
			this.X9Y4_中指 = pars["中指"].ToPar();
			this.X9Y4_人指 = pars["人指"].ToPar();
			this.X9Y4_親指 = pars["親指"].ToPar();
			pars = this.本体[10][0];
			this.X10Y0_親指 = pars["親指"].ToPar();
			this.X10Y0_手 = pars["手"].ToPar();
			this.X10Y0_小指 = pars["小指"].ToPar();
			this.X10Y0_薬指 = pars["薬指"].ToPar();
			this.X10Y0_中指 = pars["中指"].ToPar();
			this.X10Y0_人指 = pars["人指"].ToPar();
			pars2 = pars["呪印"].ToPars();
			pars3 = pars2["輪1"].ToPars();
			this.X10Y0_呪印_輪1_輪外 = pars3["輪外"].ToPar();
			this.X10Y0_呪印_輪1_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X10Y0_呪印_輪2_輪外 = pars3["輪外"].ToPar();
			this.X10Y0_呪印_輪2_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪3"].ToPars();
			this.X10Y0_呪印_輪3_輪外 = pars3["輪外"].ToPar();
			this.X10Y0_呪印_輪3_輪内 = pars3["輪内"].ToPar();
			this.X10Y0_呪印_鎖1 = pars2["鎖1"].ToPar();
			this.X10Y0_呪印_鎖2 = pars2["鎖2"].ToPar();
			this.X10Y0_呪印_鎖3 = pars2["鎖3"].ToPar();
			pars = this.本体[10][1];
			this.X10Y1_親指 = pars["親指"].ToPar();
			this.X10Y1_手 = pars["手"].ToPar();
			this.X10Y1_小指 = pars["小指"].ToPar();
			this.X10Y1_薬指 = pars["薬指"].ToPar();
			this.X10Y1_中指 = pars["中指"].ToPar();
			this.X10Y1_人指 = pars["人指"].ToPar();
			pars2 = pars["呪印"].ToPars();
			pars3 = pars2["輪1"].ToPars();
			this.X10Y1_呪印_輪1_輪外 = pars3["輪外"].ToPar();
			this.X10Y1_呪印_輪1_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X10Y1_呪印_輪2_輪外 = pars3["輪外"].ToPar();
			this.X10Y1_呪印_輪2_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪3"].ToPars();
			this.X10Y1_呪印_輪3_輪外 = pars3["輪外"].ToPar();
			this.X10Y1_呪印_輪3_輪内 = pars3["輪内"].ToPar();
			this.X10Y1_呪印_鎖1 = pars2["鎖1"].ToPar();
			this.X10Y1_呪印_鎖2 = pars2["鎖2"].ToPar();
			this.X10Y1_呪印_鎖3 = pars2["鎖3"].ToPar();
			pars = this.本体[10][2];
			this.X10Y2_親指 = pars["親指"].ToPar();
			this.X10Y2_手 = pars["手"].ToPar();
			this.X10Y2_小指 = pars["小指"].ToPar();
			this.X10Y2_薬指 = pars["薬指"].ToPar();
			this.X10Y2_中指 = pars["中指"].ToPar();
			this.X10Y2_人指 = pars["人指"].ToPar();
			pars2 = pars["呪印"].ToPars();
			pars3 = pars2["輪1"].ToPars();
			this.X10Y2_呪印_輪1_輪外 = pars3["輪外"].ToPar();
			this.X10Y2_呪印_輪1_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X10Y2_呪印_輪2_輪外 = pars3["輪外"].ToPar();
			this.X10Y2_呪印_輪2_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪3"].ToPars();
			this.X10Y2_呪印_輪3_輪外 = pars3["輪外"].ToPar();
			this.X10Y2_呪印_輪3_輪内 = pars3["輪内"].ToPar();
			this.X10Y2_呪印_鎖1 = pars2["鎖1"].ToPar();
			this.X10Y2_呪印_鎖2 = pars2["鎖2"].ToPar();
			this.X10Y2_呪印_鎖3 = pars2["鎖3"].ToPar();
			pars = this.本体[10][3];
			this.X10Y3_親指 = pars["親指"].ToPar();
			this.X10Y3_手 = pars["手"].ToPar();
			this.X10Y3_小指 = pars["小指"].ToPar();
			this.X10Y3_薬指 = pars["薬指"].ToPar();
			this.X10Y3_中指 = pars["中指"].ToPar();
			this.X10Y3_人指 = pars["人指"].ToPar();
			pars2 = pars["呪印"].ToPars();
			pars3 = pars2["輪1"].ToPars();
			this.X10Y3_呪印_輪1_輪外 = pars3["輪外"].ToPar();
			this.X10Y3_呪印_輪1_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X10Y3_呪印_輪2_輪外 = pars3["輪外"].ToPar();
			this.X10Y3_呪印_輪2_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪3"].ToPars();
			this.X10Y3_呪印_輪3_輪外 = pars3["輪外"].ToPar();
			this.X10Y3_呪印_輪3_輪内 = pars3["輪内"].ToPar();
			this.X10Y3_呪印_鎖1 = pars2["鎖1"].ToPar();
			this.X10Y3_呪印_鎖2 = pars2["鎖2"].ToPar();
			this.X10Y3_呪印_鎖3 = pars2["鎖3"].ToPar();
			pars = this.本体[10][4];
			this.X10Y4_親指 = pars["親指"].ToPar();
			this.X10Y4_手 = pars["手"].ToPar();
			this.X10Y4_小指 = pars["小指"].ToPar();
			this.X10Y4_薬指 = pars["薬指"].ToPar();
			this.X10Y4_中指 = pars["中指"].ToPar();
			this.X10Y4_人指 = pars["人指"].ToPar();
			pars2 = pars["呪印"].ToPars();
			pars3 = pars2["輪1"].ToPars();
			this.X10Y4_呪印_輪1_輪外 = pars3["輪外"].ToPar();
			this.X10Y4_呪印_輪1_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X10Y4_呪印_輪2_輪外 = pars3["輪外"].ToPar();
			this.X10Y4_呪印_輪2_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪3"].ToPars();
			this.X10Y4_呪印_輪3_輪外 = pars3["輪外"].ToPar();
			this.X10Y4_呪印_輪3_輪内 = pars3["輪内"].ToPar();
			this.X10Y4_呪印_鎖1 = pars2["鎖1"].ToPar();
			this.X10Y4_呪印_鎖2 = pars2["鎖2"].ToPar();
			this.X10Y4_呪印_鎖3 = pars2["鎖3"].ToPar();
			pars = this.本体[11][0];
			this.X11Y0_小指 = pars["小指"].ToPar();
			this.X11Y0_薬指 = pars["薬指"].ToPar();
			this.X11Y0_中指 = pars["中指"].ToPar();
			this.X11Y0_人指 = pars["人指"].ToPar();
			this.X11Y0_手 = pars["手"].ToPar();
			this.X11Y0_親指 = pars["親指"].ToPar();
			pars2 = pars["呪印"].ToPars();
			pars3 = pars2["輪1"].ToPars();
			this.X11Y0_呪印_輪1_輪外 = pars3["輪外"].ToPar();
			this.X11Y0_呪印_輪1_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X11Y0_呪印_輪2_輪外 = pars3["輪外"].ToPar();
			this.X11Y0_呪印_輪2_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪3"].ToPars();
			this.X11Y0_呪印_輪3_輪外 = pars3["輪外"].ToPar();
			this.X11Y0_呪印_輪3_輪内 = pars3["輪内"].ToPar();
			this.X11Y0_呪印_鎖1 = pars2["鎖1"].ToPar();
			this.X11Y0_呪印_鎖3 = pars2["鎖3"].ToPar();
			pars = this.本体[12][0];
			this.X12Y0_親指 = pars["親指"].ToPar();
			this.X12Y0_手 = pars["手"].ToPar();
			this.X12Y0_小指 = pars["小指"].ToPar();
			this.X12Y0_薬指 = pars["薬指"].ToPar();
			this.X12Y0_中指 = pars["中指"].ToPar();
			this.X12Y0_人指 = pars["人指"].ToPar();
			pars2 = pars["呪印"].ToPars();
			pars3 = pars2["輪1"].ToPars();
			this.X12Y0_呪印_輪1_輪外 = pars3["輪外"].ToPar();
			this.X12Y0_呪印_輪1_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X12Y0_呪印_輪2_輪外 = pars3["輪外"].ToPar();
			this.X12Y0_呪印_輪2_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪3"].ToPars();
			this.X12Y0_呪印_輪3_輪外 = pars3["輪外"].ToPar();
			this.X12Y0_呪印_輪3_輪内 = pars3["輪内"].ToPar();
			this.X12Y0_呪印_鎖1 = pars2["鎖1"].ToPar();
			this.X12Y0_呪印_鎖2 = pars2["鎖2"].ToPar();
			this.X12Y0_呪印_鎖3 = pars2["鎖3"].ToPar();
			pars = this.本体[13][0];
			this.X13Y0_中指 = pars["中指"].ToPar();
			this.X13Y0_人指 = pars["人指"].ToPar();
			this.X13Y0_手 = pars["手"].ToPar();
			this.X13Y0_親指 = pars["親指"].ToPar();
			pars2 = pars["呪印"].ToPars();
			pars3 = pars2["輪1"].ToPars();
			this.X13Y0_呪印_輪1_輪外 = pars3["輪外"].ToPar();
			this.X13Y0_呪印_輪1_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X13Y0_呪印_輪2_輪外 = pars3["輪外"].ToPar();
			this.X13Y0_呪印_輪2_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪3"].ToPars();
			this.X13Y0_呪印_輪3_輪外 = pars3["輪外"].ToPar();
			this.X13Y0_呪印_輪3_輪内 = pars3["輪内"].ToPar();
			this.X13Y0_呪印_鎖1 = pars2["鎖1"].ToPar();
			this.X13Y0_呪印_鎖3 = pars2["鎖3"].ToPar();
			pars = this.本体[14][0];
			this.X14Y0_親指 = pars["親指"].ToPar();
			this.X14Y0_手 = pars["手"].ToPar();
			this.X14Y0_小指 = pars["小指"].ToPar();
			this.X14Y0_薬指 = pars["薬指"].ToPar();
			this.X14Y0_中指 = pars["中指"].ToPar();
			this.X14Y0_人指 = pars["人指"].ToPar();
			pars2 = pars["呪印"].ToPars();
			pars3 = pars2["輪1"].ToPars();
			this.X14Y0_呪印_輪1_輪外 = pars3["輪外"].ToPar();
			this.X14Y0_呪印_輪1_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X14Y0_呪印_輪2_輪外 = pars3["輪外"].ToPar();
			this.X14Y0_呪印_輪2_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪3"].ToPars();
			this.X14Y0_呪印_輪3_輪外 = pars3["輪外"].ToPar();
			this.X14Y0_呪印_輪3_輪内 = pars3["輪内"].ToPar();
			this.X14Y0_呪印_鎖1 = pars2["鎖1"].ToPar();
			this.X14Y0_呪印_鎖2 = pars2["鎖2"].ToPar();
			this.X14Y0_呪印_鎖3 = pars2["鎖3"].ToPar();
			pars = this.本体[14][1];
			this.X14Y1_親指 = pars["親指"].ToPar();
			this.X14Y1_手 = pars["手"].ToPar();
			this.X14Y1_小指 = pars["小指"].ToPar();
			this.X14Y1_薬指 = pars["薬指"].ToPar();
			this.X14Y1_中指 = pars["中指"].ToPar();
			this.X14Y1_人指 = pars["人指"].ToPar();
			pars2 = pars["呪印"].ToPars();
			pars3 = pars2["輪1"].ToPars();
			this.X14Y1_呪印_輪1_輪外 = pars3["輪外"].ToPar();
			this.X14Y1_呪印_輪1_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X14Y1_呪印_輪2_輪外 = pars3["輪外"].ToPar();
			this.X14Y1_呪印_輪2_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪3"].ToPars();
			this.X14Y1_呪印_輪3_輪外 = pars3["輪外"].ToPar();
			this.X14Y1_呪印_輪3_輪内 = pars3["輪内"].ToPar();
			this.X14Y1_呪印_鎖1 = pars2["鎖1"].ToPar();
			this.X14Y1_呪印_鎖2 = pars2["鎖2"].ToPar();
			this.X14Y1_呪印_鎖3 = pars2["鎖3"].ToPar();
			pars = this.本体[14][2];
			this.X14Y2_親指 = pars["親指"].ToPar();
			this.X14Y2_手 = pars["手"].ToPar();
			this.X14Y2_小指 = pars["小指"].ToPar();
			this.X14Y2_薬指 = pars["薬指"].ToPar();
			this.X14Y2_中指 = pars["中指"].ToPar();
			this.X14Y2_人指 = pars["人指"].ToPar();
			pars2 = pars["呪印"].ToPars();
			pars3 = pars2["輪1"].ToPars();
			this.X14Y2_呪印_輪1_輪外 = pars3["輪外"].ToPar();
			this.X14Y2_呪印_輪1_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪2"].ToPars();
			this.X14Y2_呪印_輪2_輪外 = pars3["輪外"].ToPar();
			this.X14Y2_呪印_輪2_輪内 = pars3["輪内"].ToPar();
			pars3 = pars2["輪3"].ToPars();
			this.X14Y2_呪印_輪3_輪外 = pars3["輪外"].ToPar();
			this.X14Y2_呪印_輪3_輪内 = pars3["輪内"].ToPar();
			this.X14Y2_呪印_鎖1 = pars2["鎖1"].ToPar();
			this.X14Y2_呪印_鎖2 = pars2["鎖2"].ToPar();
			this.X14Y2_呪印_鎖3 = pars2["鎖3"].ToPar();
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
			this.親指_表示 = e.親指_表示;
			this.手_表示 = e.手_表示;
			this.小指_表示 = e.小指_表示;
			this.薬指_表示 = e.薬指_表示;
			this.中指_表示 = e.中指_表示;
			this.人指_表示 = e.人指_表示;
			this.呪印_輪1_輪外_表示 = e.呪印_輪1_輪外_表示;
			this.呪印_輪1_輪内_表示 = e.呪印_輪1_輪内_表示;
			this.呪印_輪2_輪外_表示 = e.呪印_輪2_輪外_表示;
			this.呪印_輪2_輪内_表示 = e.呪印_輪2_輪内_表示;
			this.呪印_輪3_輪外_表示 = e.呪印_輪3_輪外_表示;
			this.呪印_輪3_輪内_表示 = e.呪印_輪3_輪内_表示;
			this.呪印_鎖1_表示 = e.呪印_鎖1_表示;
			this.呪印_鎖2_表示 = e.呪印_鎖2_表示;
			this.呪印_鎖3_表示 = e.呪印_鎖3_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X6Y0Pars = new Par[]
			{
				this.X6Y0_手,
				this.X6Y0_人指
			};
			this.X6Y1Pars = new Par[]
			{
				this.X6Y1_手,
				this.X6Y1_人指
			};
			this.X6Y2Pars = new Par[]
			{
				this.X6Y2_手,
				this.X6Y2_人指
			};
			this.X6Y3Pars = new Par[]
			{
				this.X6Y3_手,
				this.X6Y3_人指
			};
			this.X6Y4Pars = new Par[]
			{
				this.X6Y4_手,
				this.X6Y4_人指
			};
			this.X7Y0Pars = new Par[]
			{
				this.X7Y0_手,
				this.X7Y0_人指
			};
			this.X7Y1Pars = new Par[]
			{
				this.X7Y1_手,
				this.X7Y1_人指
			};
			this.X7Y2Pars = new Par[]
			{
				this.X7Y2_手,
				this.X7Y2_人指
			};
			this.X7Y3Pars = new Par[]
			{
				this.X7Y3_手,
				this.X7Y3_人指
			};
			this.X7Y4Pars = new Par[]
			{
				this.X7Y4_手,
				this.X7Y4_人指
			};
			this.X0Y0_親指CP = new ColorP(this.X0Y0_親指, this.親指CD, DisUnit, true);
			this.X0Y0_手CP = new ColorP(this.X0Y0_手, this.手CD, DisUnit, true);
			this.X0Y0_小指CP = new ColorP(this.X0Y0_小指, this.小指CD, DisUnit, true);
			this.X0Y0_薬指CP = new ColorP(this.X0Y0_薬指, this.薬指CD, DisUnit, true);
			this.X0Y0_中指CP = new ColorP(this.X0Y0_中指, this.中指CD, DisUnit, true);
			this.X0Y0_人指CP = new ColorP(this.X0Y0_人指, this.人指CD, DisUnit, true);
			this.X0Y0_呪印_輪1_輪外CP = new ColorP(this.X0Y0_呪印_輪1_輪外, this.呪印_輪1_輪外CD, DisUnit, true);
			this.X0Y0_呪印_輪1_輪内CP = new ColorP(this.X0Y0_呪印_輪1_輪内, this.呪印_輪1_輪内CD, DisUnit, true);
			this.X0Y0_呪印_輪2_輪外CP = new ColorP(this.X0Y0_呪印_輪2_輪外, this.呪印_輪2_輪外CD, DisUnit, true);
			this.X0Y0_呪印_輪2_輪内CP = new ColorP(this.X0Y0_呪印_輪2_輪内, this.呪印_輪2_輪内CD, DisUnit, true);
			this.X0Y0_呪印_輪3_輪外CP = new ColorP(this.X0Y0_呪印_輪3_輪外, this.呪印_輪3_輪外CD, DisUnit, true);
			this.X0Y0_呪印_輪3_輪内CP = new ColorP(this.X0Y0_呪印_輪3_輪内, this.呪印_輪3_輪内CD, DisUnit, true);
			this.X0Y0_呪印_鎖1CP = new ColorP(this.X0Y0_呪印_鎖1, this.呪印_鎖1CD, DisUnit, true);
			this.X0Y0_呪印_鎖2CP = new ColorP(this.X0Y0_呪印_鎖2, this.呪印_鎖2CD, DisUnit, true);
			this.X0Y0_呪印_鎖3CP = new ColorP(this.X0Y0_呪印_鎖3, this.呪印_鎖3CD, DisUnit, true);
			this.X1Y0_親指CP = new ColorP(this.X1Y0_親指, this.親指CD, DisUnit, true);
			this.X1Y0_手CP = new ColorP(this.X1Y0_手, this.手CD, DisUnit, true);
			this.X1Y0_小指CP = new ColorP(this.X1Y0_小指, this.小指CD, DisUnit, true);
			this.X1Y0_薬指CP = new ColorP(this.X1Y0_薬指, this.薬指CD, DisUnit, true);
			this.X1Y0_中指CP = new ColorP(this.X1Y0_中指, this.中指CD, DisUnit, true);
			this.X1Y0_人指CP = new ColorP(this.X1Y0_人指, this.人指CD, DisUnit, true);
			this.X1Y0_呪印_輪1_輪外CP = new ColorP(this.X1Y0_呪印_輪1_輪外, this.呪印_輪1_輪外CD, DisUnit, true);
			this.X1Y0_呪印_輪1_輪内CP = new ColorP(this.X1Y0_呪印_輪1_輪内, this.呪印_輪1_輪内CD, DisUnit, true);
			this.X1Y0_呪印_輪2_輪外CP = new ColorP(this.X1Y0_呪印_輪2_輪外, this.呪印_輪2_輪外CD, DisUnit, true);
			this.X1Y0_呪印_輪2_輪内CP = new ColorP(this.X1Y0_呪印_輪2_輪内, this.呪印_輪2_輪内CD, DisUnit, true);
			this.X1Y0_呪印_輪3_輪外CP = new ColorP(this.X1Y0_呪印_輪3_輪外, this.呪印_輪3_輪外CD, DisUnit, true);
			this.X1Y0_呪印_輪3_輪内CP = new ColorP(this.X1Y0_呪印_輪3_輪内, this.呪印_輪3_輪内CD, DisUnit, true);
			this.X1Y0_呪印_鎖1CP = new ColorP(this.X1Y0_呪印_鎖1, this.呪印_鎖1CD, DisUnit, true);
			this.X1Y0_呪印_鎖2CP = new ColorP(this.X1Y0_呪印_鎖2, this.呪印_鎖2CD, DisUnit, true);
			this.X1Y0_呪印_鎖3CP = new ColorP(this.X1Y0_呪印_鎖3, this.呪印_鎖3CD, DisUnit, true);
			this.X2Y0_親指CP = new ColorP(this.X2Y0_親指, this.親指CD, DisUnit, true);
			this.X2Y0_手CP = new ColorP(this.X2Y0_手, this.手CD, DisUnit, true);
			this.X2Y0_小指CP = new ColorP(this.X2Y0_小指, this.小指CD, DisUnit, true);
			this.X2Y0_薬指CP = new ColorP(this.X2Y0_薬指, this.薬指CD, DisUnit, true);
			this.X2Y0_中指CP = new ColorP(this.X2Y0_中指, this.中指CD, DisUnit, true);
			this.X2Y0_人指CP = new ColorP(this.X2Y0_人指, this.人指CD, DisUnit, true);
			this.X2Y0_呪印_輪1_輪外CP = new ColorP(this.X2Y0_呪印_輪1_輪外, this.呪印_輪1_輪外CD, DisUnit, true);
			this.X2Y0_呪印_輪1_輪内CP = new ColorP(this.X2Y0_呪印_輪1_輪内, this.呪印_輪1_輪内CD, DisUnit, true);
			this.X2Y0_呪印_輪2_輪外CP = new ColorP(this.X2Y0_呪印_輪2_輪外, this.呪印_輪2_輪外CD, DisUnit, true);
			this.X2Y0_呪印_輪2_輪内CP = new ColorP(this.X2Y0_呪印_輪2_輪内, this.呪印_輪2_輪内CD, DisUnit, true);
			this.X2Y0_呪印_輪3_輪外CP = new ColorP(this.X2Y0_呪印_輪3_輪外, this.呪印_輪3_輪外CD, DisUnit, true);
			this.X2Y0_呪印_輪3_輪内CP = new ColorP(this.X2Y0_呪印_輪3_輪内, this.呪印_輪3_輪内CD, DisUnit, true);
			this.X2Y0_呪印_鎖1CP = new ColorP(this.X2Y0_呪印_鎖1, this.呪印_鎖1CD, DisUnit, true);
			this.X2Y0_呪印_鎖2CP = new ColorP(this.X2Y0_呪印_鎖2, this.呪印_鎖2CD, DisUnit, true);
			this.X2Y0_呪印_鎖3CP = new ColorP(this.X2Y0_呪印_鎖3, this.呪印_鎖3CD, DisUnit, true);
			this.X2Y1_親指CP = new ColorP(this.X2Y1_親指, this.親指CD, DisUnit, true);
			this.X2Y1_手CP = new ColorP(this.X2Y1_手, this.手CD, DisUnit, true);
			this.X2Y1_小指CP = new ColorP(this.X2Y1_小指, this.小指CD, DisUnit, true);
			this.X2Y1_薬指CP = new ColorP(this.X2Y1_薬指, this.薬指CD, DisUnit, true);
			this.X2Y1_中指CP = new ColorP(this.X2Y1_中指, this.中指CD, DisUnit, true);
			this.X2Y1_人指CP = new ColorP(this.X2Y1_人指, this.人指CD, DisUnit, true);
			this.X2Y1_呪印_輪1_輪外CP = new ColorP(this.X2Y1_呪印_輪1_輪外, this.呪印_輪1_輪外CD, DisUnit, true);
			this.X2Y1_呪印_輪1_輪内CP = new ColorP(this.X2Y1_呪印_輪1_輪内, this.呪印_輪1_輪内CD, DisUnit, true);
			this.X2Y1_呪印_輪2_輪外CP = new ColorP(this.X2Y1_呪印_輪2_輪外, this.呪印_輪2_輪外CD, DisUnit, true);
			this.X2Y1_呪印_輪2_輪内CP = new ColorP(this.X2Y1_呪印_輪2_輪内, this.呪印_輪2_輪内CD, DisUnit, true);
			this.X2Y1_呪印_輪3_輪外CP = new ColorP(this.X2Y1_呪印_輪3_輪外, this.呪印_輪3_輪外CD, DisUnit, true);
			this.X2Y1_呪印_輪3_輪内CP = new ColorP(this.X2Y1_呪印_輪3_輪内, this.呪印_輪3_輪内CD, DisUnit, true);
			this.X2Y1_呪印_鎖1CP = new ColorP(this.X2Y1_呪印_鎖1, this.呪印_鎖1CD, DisUnit, true);
			this.X2Y1_呪印_鎖2CP = new ColorP(this.X2Y1_呪印_鎖2, this.呪印_鎖2CD, DisUnit, true);
			this.X2Y1_呪印_鎖3CP = new ColorP(this.X2Y1_呪印_鎖3, this.呪印_鎖3CD, DisUnit, true);
			this.X2Y2_親指CP = new ColorP(this.X2Y2_親指, this.親指CD, DisUnit, true);
			this.X2Y2_手CP = new ColorP(this.X2Y2_手, this.手CD, DisUnit, true);
			this.X2Y2_小指CP = new ColorP(this.X2Y2_小指, this.小指CD, DisUnit, true);
			this.X2Y2_薬指CP = new ColorP(this.X2Y2_薬指, this.薬指CD, DisUnit, true);
			this.X2Y2_中指CP = new ColorP(this.X2Y2_中指, this.中指CD, DisUnit, true);
			this.X2Y2_人指CP = new ColorP(this.X2Y2_人指, this.人指CD, DisUnit, true);
			this.X2Y2_呪印_輪1_輪外CP = new ColorP(this.X2Y2_呪印_輪1_輪外, this.呪印_輪1_輪外CD, DisUnit, true);
			this.X2Y2_呪印_輪1_輪内CP = new ColorP(this.X2Y2_呪印_輪1_輪内, this.呪印_輪1_輪内CD, DisUnit, true);
			this.X2Y2_呪印_輪2_輪外CP = new ColorP(this.X2Y2_呪印_輪2_輪外, this.呪印_輪2_輪外CD, DisUnit, true);
			this.X2Y2_呪印_輪2_輪内CP = new ColorP(this.X2Y2_呪印_輪2_輪内, this.呪印_輪2_輪内CD, DisUnit, true);
			this.X2Y2_呪印_輪3_輪外CP = new ColorP(this.X2Y2_呪印_輪3_輪外, this.呪印_輪3_輪外CD, DisUnit, true);
			this.X2Y2_呪印_輪3_輪内CP = new ColorP(this.X2Y2_呪印_輪3_輪内, this.呪印_輪3_輪内CD, DisUnit, true);
			this.X2Y2_呪印_鎖1CP = new ColorP(this.X2Y2_呪印_鎖1, this.呪印_鎖1CD, DisUnit, true);
			this.X2Y2_呪印_鎖2CP = new ColorP(this.X2Y2_呪印_鎖2, this.呪印_鎖2CD, DisUnit, true);
			this.X2Y2_呪印_鎖3CP = new ColorP(this.X2Y2_呪印_鎖3, this.呪印_鎖3CD, DisUnit, true);
			this.X2Y3_親指CP = new ColorP(this.X2Y3_親指, this.親指CD, DisUnit, true);
			this.X2Y3_手CP = new ColorP(this.X2Y3_手, this.手CD, DisUnit, true);
			this.X2Y3_小指CP = new ColorP(this.X2Y3_小指, this.小指CD, DisUnit, true);
			this.X2Y3_薬指CP = new ColorP(this.X2Y3_薬指, this.薬指CD, DisUnit, true);
			this.X2Y3_中指CP = new ColorP(this.X2Y3_中指, this.中指CD, DisUnit, true);
			this.X2Y3_人指CP = new ColorP(this.X2Y3_人指, this.人指CD, DisUnit, true);
			this.X2Y3_呪印_輪1_輪外CP = new ColorP(this.X2Y3_呪印_輪1_輪外, this.呪印_輪1_輪外CD, DisUnit, true);
			this.X2Y3_呪印_輪1_輪内CP = new ColorP(this.X2Y3_呪印_輪1_輪内, this.呪印_輪1_輪内CD, DisUnit, true);
			this.X2Y3_呪印_輪2_輪外CP = new ColorP(this.X2Y3_呪印_輪2_輪外, this.呪印_輪2_輪外CD, DisUnit, true);
			this.X2Y3_呪印_輪2_輪内CP = new ColorP(this.X2Y3_呪印_輪2_輪内, this.呪印_輪2_輪内CD, DisUnit, true);
			this.X2Y3_呪印_輪3_輪外CP = new ColorP(this.X2Y3_呪印_輪3_輪外, this.呪印_輪3_輪外CD, DisUnit, true);
			this.X2Y3_呪印_輪3_輪内CP = new ColorP(this.X2Y3_呪印_輪3_輪内, this.呪印_輪3_輪内CD, DisUnit, true);
			this.X2Y3_呪印_鎖1CP = new ColorP(this.X2Y3_呪印_鎖1, this.呪印_鎖1CD, DisUnit, true);
			this.X2Y3_呪印_鎖2CP = new ColorP(this.X2Y3_呪印_鎖2, this.呪印_鎖2CD, DisUnit, true);
			this.X2Y3_呪印_鎖3CP = new ColorP(this.X2Y3_呪印_鎖3, this.呪印_鎖3CD, DisUnit, true);
			this.X2Y4_親指CP = new ColorP(this.X2Y4_親指, this.親指CD, DisUnit, true);
			this.X2Y4_手CP = new ColorP(this.X2Y4_手, this.手CD, DisUnit, true);
			this.X2Y4_小指CP = new ColorP(this.X2Y4_小指, this.小指CD, DisUnit, true);
			this.X2Y4_薬指CP = new ColorP(this.X2Y4_薬指, this.薬指CD, DisUnit, true);
			this.X2Y4_中指CP = new ColorP(this.X2Y4_中指, this.中指CD, DisUnit, true);
			this.X2Y4_人指CP = new ColorP(this.X2Y4_人指, this.人指CD, DisUnit, true);
			this.X2Y4_呪印_輪1_輪外CP = new ColorP(this.X2Y4_呪印_輪1_輪外, this.呪印_輪1_輪外CD, DisUnit, true);
			this.X2Y4_呪印_輪1_輪内CP = new ColorP(this.X2Y4_呪印_輪1_輪内, this.呪印_輪1_輪内CD, DisUnit, true);
			this.X2Y4_呪印_輪2_輪外CP = new ColorP(this.X2Y4_呪印_輪2_輪外, this.呪印_輪2_輪外CD, DisUnit, true);
			this.X2Y4_呪印_輪2_輪内CP = new ColorP(this.X2Y4_呪印_輪2_輪内, this.呪印_輪2_輪内CD, DisUnit, true);
			this.X2Y4_呪印_輪3_輪外CP = new ColorP(this.X2Y4_呪印_輪3_輪外, this.呪印_輪3_輪外CD, DisUnit, true);
			this.X2Y4_呪印_輪3_輪内CP = new ColorP(this.X2Y4_呪印_輪3_輪内, this.呪印_輪3_輪内CD, DisUnit, true);
			this.X2Y4_呪印_鎖1CP = new ColorP(this.X2Y4_呪印_鎖1, this.呪印_鎖1CD, DisUnit, true);
			this.X2Y4_呪印_鎖2CP = new ColorP(this.X2Y4_呪印_鎖2, this.呪印_鎖2CD, DisUnit, true);
			this.X2Y4_呪印_鎖3CP = new ColorP(this.X2Y4_呪印_鎖3, this.呪印_鎖3CD, DisUnit, true);
			this.X3Y0_親指CP = new ColorP(this.X3Y0_親指, this.親指CD, DisUnit, true);
			this.X3Y0_手CP = new ColorP(this.X3Y0_手, this.手CD, DisUnit, true);
			this.X3Y0_小指CP = new ColorP(this.X3Y0_小指, this.小指CD, DisUnit, true);
			this.X3Y0_薬指CP = new ColorP(this.X3Y0_薬指, this.薬指CD, DisUnit, true);
			this.X3Y0_中指CP = new ColorP(this.X3Y0_中指, this.中指CD, DisUnit, true);
			this.X3Y0_人指CP = new ColorP(this.X3Y0_人指, this.人指CD, DisUnit, true);
			this.X3Y0_呪印_輪1_輪外CP = new ColorP(this.X3Y0_呪印_輪1_輪外, this.呪印_輪1_輪外CD, DisUnit, true);
			this.X3Y0_呪印_輪1_輪内CP = new ColorP(this.X3Y0_呪印_輪1_輪内, this.呪印_輪1_輪内CD, DisUnit, true);
			this.X3Y0_呪印_輪2_輪外CP = new ColorP(this.X3Y0_呪印_輪2_輪外, this.呪印_輪2_輪外CD, DisUnit, true);
			this.X3Y0_呪印_輪2_輪内CP = new ColorP(this.X3Y0_呪印_輪2_輪内, this.呪印_輪2_輪内CD, DisUnit, true);
			this.X3Y0_呪印_輪3_輪外CP = new ColorP(this.X3Y0_呪印_輪3_輪外, this.呪印_輪3_輪外CD, DisUnit, true);
			this.X3Y0_呪印_輪3_輪内CP = new ColorP(this.X3Y0_呪印_輪3_輪内, this.呪印_輪3_輪内CD, DisUnit, true);
			this.X3Y0_呪印_鎖1CP = new ColorP(this.X3Y0_呪印_鎖1, this.呪印_鎖1CD, DisUnit, true);
			this.X3Y0_呪印_鎖2CP = new ColorP(this.X3Y0_呪印_鎖2, this.呪印_鎖2CD, DisUnit, true);
			this.X3Y0_呪印_鎖3CP = new ColorP(this.X3Y0_呪印_鎖3, this.呪印_鎖3CD, DisUnit, true);
			this.X4Y0_親指CP = new ColorP(this.X4Y0_親指, this.親指CD, DisUnit, true);
			this.X4Y0_手CP = new ColorP(this.X4Y0_手, this.手CD, DisUnit, true);
			this.X4Y0_小指CP = new ColorP(this.X4Y0_小指, this.小指CD, DisUnit, true);
			this.X4Y0_薬指CP = new ColorP(this.X4Y0_薬指, this.薬指CD, DisUnit, true);
			this.X4Y0_中指CP = new ColorP(this.X4Y0_中指, this.中指CD, DisUnit, true);
			this.X4Y0_人指CP = new ColorP(this.X4Y0_人指, this.人指CD, DisUnit, true);
			this.X4Y0_呪印_輪1_輪外CP = new ColorP(this.X4Y0_呪印_輪1_輪外, this.呪印_輪1_輪外CD, DisUnit, true);
			this.X4Y0_呪印_輪1_輪内CP = new ColorP(this.X4Y0_呪印_輪1_輪内, this.呪印_輪1_輪内CD, DisUnit, true);
			this.X4Y0_呪印_輪2_輪外CP = new ColorP(this.X4Y0_呪印_輪2_輪外, this.呪印_輪2_輪外CD, DisUnit, true);
			this.X4Y0_呪印_輪2_輪内CP = new ColorP(this.X4Y0_呪印_輪2_輪内, this.呪印_輪2_輪内CD, DisUnit, true);
			this.X4Y0_呪印_輪3_輪外CP = new ColorP(this.X4Y0_呪印_輪3_輪外, this.呪印_輪3_輪外CD, DisUnit, true);
			this.X4Y0_呪印_輪3_輪内CP = new ColorP(this.X4Y0_呪印_輪3_輪内, this.呪印_輪3_輪内CD, DisUnit, true);
			this.X4Y0_呪印_鎖1CP = new ColorP(this.X4Y0_呪印_鎖1, this.呪印_鎖1CD, DisUnit, true);
			this.X4Y0_呪印_鎖2CP = new ColorP(this.X4Y0_呪印_鎖2, this.呪印_鎖2CD, DisUnit, true);
			this.X4Y0_呪印_鎖3CP = new ColorP(this.X4Y0_呪印_鎖3, this.呪印_鎖3CD, DisUnit, true);
			this.X5Y0_親指CP = new ColorP(this.X5Y0_親指, this.親指CD, DisUnit, true);
			this.X5Y0_手CP = new ColorP(this.X5Y0_手, this.手CD, DisUnit, true);
			this.X5Y0_小指CP = new ColorP(this.X5Y0_小指, this.小指CD, DisUnit, true);
			this.X5Y0_薬指CP = new ColorP(this.X5Y0_薬指, this.薬指CD, DisUnit, true);
			this.X5Y0_中指CP = new ColorP(this.X5Y0_中指, this.中指CD, DisUnit, true);
			this.X5Y0_人指CP = new ColorP(this.X5Y0_人指, this.人指CD, DisUnit, true);
			this.X5Y0_呪印_輪1_輪外CP = new ColorP(this.X5Y0_呪印_輪1_輪外, this.呪印_輪1_輪外CD, DisUnit, true);
			this.X5Y0_呪印_輪1_輪内CP = new ColorP(this.X5Y0_呪印_輪1_輪内, this.呪印_輪1_輪内CD, DisUnit, true);
			this.X5Y0_呪印_輪2_輪外CP = new ColorP(this.X5Y0_呪印_輪2_輪外, this.呪印_輪2_輪外CD, DisUnit, true);
			this.X5Y0_呪印_輪2_輪内CP = new ColorP(this.X5Y0_呪印_輪2_輪内, this.呪印_輪2_輪内CD, DisUnit, true);
			this.X5Y0_呪印_輪3_輪外CP = new ColorP(this.X5Y0_呪印_輪3_輪外, this.呪印_輪3_輪外CD, DisUnit, true);
			this.X5Y0_呪印_輪3_輪内CP = new ColorP(this.X5Y0_呪印_輪3_輪内, this.呪印_輪3_輪内CD, DisUnit, true);
			this.X5Y0_呪印_鎖1CP = new ColorP(this.X5Y0_呪印_鎖1, this.呪印_鎖1CD, DisUnit, true);
			this.X5Y0_呪印_鎖2CP = new ColorP(this.X5Y0_呪印_鎖2, this.呪印_鎖2CD, DisUnit, true);
			this.X5Y0_呪印_鎖3CP = new ColorP(this.X5Y0_呪印_鎖3, this.呪印_鎖3CD, DisUnit, true);
			this.X5Y1_親指CP = new ColorP(this.X5Y1_親指, this.親指CD, DisUnit, true);
			this.X5Y1_手CP = new ColorP(this.X5Y1_手, this.手CD, DisUnit, true);
			this.X5Y1_小指CP = new ColorP(this.X5Y1_小指, this.小指CD, DisUnit, true);
			this.X5Y1_薬指CP = new ColorP(this.X5Y1_薬指, this.薬指CD, DisUnit, true);
			this.X5Y1_中指CP = new ColorP(this.X5Y1_中指, this.中指CD, DisUnit, true);
			this.X5Y1_人指CP = new ColorP(this.X5Y1_人指, this.人指CD, DisUnit, true);
			this.X5Y1_呪印_輪1_輪外CP = new ColorP(this.X5Y1_呪印_輪1_輪外, this.呪印_輪1_輪外CD, DisUnit, true);
			this.X5Y1_呪印_輪1_輪内CP = new ColorP(this.X5Y1_呪印_輪1_輪内, this.呪印_輪1_輪内CD, DisUnit, true);
			this.X5Y1_呪印_輪2_輪外CP = new ColorP(this.X5Y1_呪印_輪2_輪外, this.呪印_輪2_輪外CD, DisUnit, true);
			this.X5Y1_呪印_輪2_輪内CP = new ColorP(this.X5Y1_呪印_輪2_輪内, this.呪印_輪2_輪内CD, DisUnit, true);
			this.X5Y1_呪印_輪3_輪外CP = new ColorP(this.X5Y1_呪印_輪3_輪外, this.呪印_輪3_輪外CD, DisUnit, true);
			this.X5Y1_呪印_輪3_輪内CP = new ColorP(this.X5Y1_呪印_輪3_輪内, this.呪印_輪3_輪内CD, DisUnit, true);
			this.X5Y1_呪印_鎖1CP = new ColorP(this.X5Y1_呪印_鎖1, this.呪印_鎖1CD, DisUnit, true);
			this.X5Y1_呪印_鎖2CP = new ColorP(this.X5Y1_呪印_鎖2, this.呪印_鎖2CD, DisUnit, true);
			this.X5Y1_呪印_鎖3CP = new ColorP(this.X5Y1_呪印_鎖3, this.呪印_鎖3CD, DisUnit, true);
			this.X5Y2_親指CP = new ColorP(this.X5Y2_親指, this.親指CD, DisUnit, true);
			this.X5Y2_手CP = new ColorP(this.X5Y2_手, this.手CD, DisUnit, true);
			this.X5Y2_小指CP = new ColorP(this.X5Y2_小指, this.小指CD, DisUnit, true);
			this.X5Y2_薬指CP = new ColorP(this.X5Y2_薬指, this.薬指CD, DisUnit, true);
			this.X5Y2_中指CP = new ColorP(this.X5Y2_中指, this.中指CD, DisUnit, true);
			this.X5Y2_人指CP = new ColorP(this.X5Y2_人指, this.人指CD, DisUnit, true);
			this.X5Y2_呪印_輪1_輪外CP = new ColorP(this.X5Y2_呪印_輪1_輪外, this.呪印_輪1_輪外CD, DisUnit, true);
			this.X5Y2_呪印_輪1_輪内CP = new ColorP(this.X5Y2_呪印_輪1_輪内, this.呪印_輪1_輪内CD, DisUnit, true);
			this.X5Y2_呪印_輪2_輪外CP = new ColorP(this.X5Y2_呪印_輪2_輪外, this.呪印_輪2_輪外CD, DisUnit, true);
			this.X5Y2_呪印_輪2_輪内CP = new ColorP(this.X5Y2_呪印_輪2_輪内, this.呪印_輪2_輪内CD, DisUnit, true);
			this.X5Y2_呪印_輪3_輪外CP = new ColorP(this.X5Y2_呪印_輪3_輪外, this.呪印_輪3_輪外CD, DisUnit, true);
			this.X5Y2_呪印_輪3_輪内CP = new ColorP(this.X5Y2_呪印_輪3_輪内, this.呪印_輪3_輪内CD, DisUnit, true);
			this.X5Y2_呪印_鎖1CP = new ColorP(this.X5Y2_呪印_鎖1, this.呪印_鎖1CD, DisUnit, true);
			this.X5Y2_呪印_鎖2CP = new ColorP(this.X5Y2_呪印_鎖2, this.呪印_鎖2CD, DisUnit, true);
			this.X5Y2_呪印_鎖3CP = new ColorP(this.X5Y2_呪印_鎖3, this.呪印_鎖3CD, DisUnit, true);
			this.X5Y3_親指CP = new ColorP(this.X5Y3_親指, this.親指CD, DisUnit, true);
			this.X5Y3_手CP = new ColorP(this.X5Y3_手, this.手CD, DisUnit, true);
			this.X5Y3_小指CP = new ColorP(this.X5Y3_小指, this.小指CD, DisUnit, true);
			this.X5Y3_薬指CP = new ColorP(this.X5Y3_薬指, this.薬指CD, DisUnit, true);
			this.X5Y3_中指CP = new ColorP(this.X5Y3_中指, this.中指CD, DisUnit, true);
			this.X5Y3_人指CP = new ColorP(this.X5Y3_人指, this.人指CD, DisUnit, true);
			this.X5Y3_呪印_輪1_輪外CP = new ColorP(this.X5Y3_呪印_輪1_輪外, this.呪印_輪1_輪外CD, DisUnit, true);
			this.X5Y3_呪印_輪1_輪内CP = new ColorP(this.X5Y3_呪印_輪1_輪内, this.呪印_輪1_輪内CD, DisUnit, true);
			this.X5Y3_呪印_輪2_輪外CP = new ColorP(this.X5Y3_呪印_輪2_輪外, this.呪印_輪2_輪外CD, DisUnit, true);
			this.X5Y3_呪印_輪2_輪内CP = new ColorP(this.X5Y3_呪印_輪2_輪内, this.呪印_輪2_輪内CD, DisUnit, true);
			this.X5Y3_呪印_輪3_輪外CP = new ColorP(this.X5Y3_呪印_輪3_輪外, this.呪印_輪3_輪外CD, DisUnit, true);
			this.X5Y3_呪印_輪3_輪内CP = new ColorP(this.X5Y3_呪印_輪3_輪内, this.呪印_輪3_輪内CD, DisUnit, true);
			this.X5Y3_呪印_鎖1CP = new ColorP(this.X5Y3_呪印_鎖1, this.呪印_鎖1CD, DisUnit, true);
			this.X5Y3_呪印_鎖2CP = new ColorP(this.X5Y3_呪印_鎖2, this.呪印_鎖2CD, DisUnit, true);
			this.X5Y3_呪印_鎖3CP = new ColorP(this.X5Y3_呪印_鎖3, this.呪印_鎖3CD, DisUnit, true);
			this.X5Y4_親指CP = new ColorP(this.X5Y4_親指, this.親指CD, DisUnit, true);
			this.X5Y4_手CP = new ColorP(this.X5Y4_手, this.手CD, DisUnit, true);
			this.X5Y4_小指CP = new ColorP(this.X5Y4_小指, this.小指CD, DisUnit, true);
			this.X5Y4_薬指CP = new ColorP(this.X5Y4_薬指, this.薬指CD, DisUnit, true);
			this.X5Y4_中指CP = new ColorP(this.X5Y4_中指, this.中指CD, DisUnit, true);
			this.X5Y4_人指CP = new ColorP(this.X5Y4_人指, this.人指CD, DisUnit, true);
			this.X5Y4_呪印_輪1_輪外CP = new ColorP(this.X5Y4_呪印_輪1_輪外, this.呪印_輪1_輪外CD, DisUnit, true);
			this.X5Y4_呪印_輪1_輪内CP = new ColorP(this.X5Y4_呪印_輪1_輪内, this.呪印_輪1_輪内CD, DisUnit, true);
			this.X5Y4_呪印_輪2_輪外CP = new ColorP(this.X5Y4_呪印_輪2_輪外, this.呪印_輪2_輪外CD, DisUnit, true);
			this.X5Y4_呪印_輪2_輪内CP = new ColorP(this.X5Y4_呪印_輪2_輪内, this.呪印_輪2_輪内CD, DisUnit, true);
			this.X5Y4_呪印_輪3_輪外CP = new ColorP(this.X5Y4_呪印_輪3_輪外, this.呪印_輪3_輪外CD, DisUnit, true);
			this.X5Y4_呪印_輪3_輪内CP = new ColorP(this.X5Y4_呪印_輪3_輪内, this.呪印_輪3_輪内CD, DisUnit, true);
			this.X5Y4_呪印_鎖1CP = new ColorP(this.X5Y4_呪印_鎖1, this.呪印_鎖1CD, DisUnit, true);
			this.X5Y4_呪印_鎖2CP = new ColorP(this.X5Y4_呪印_鎖2, this.呪印_鎖2CD, DisUnit, true);
			this.X5Y4_呪印_鎖3CP = new ColorP(this.X5Y4_呪印_鎖3, this.呪印_鎖3CD, DisUnit, true);
			this.X6Y0_親指CP = new ColorP(this.X6Y0_親指, this.親指CD, DisUnit, true);
			this.X6Y0_手CP = new ColorP(this.X6Y0_手, this.手CD, DisUnit, true);
			this.X6Y0_小指CP = new ColorP(this.X6Y0_小指, this.小指CD, DisUnit, true);
			this.X6Y0_薬指CP = new ColorP(this.X6Y0_薬指, this.薬指CD, DisUnit, true);
			this.X6Y0_中指CP = new ColorP(this.X6Y0_中指, this.中指CD, DisUnit, true);
			this.X6Y0_人指CP = new ColorP(this.X6Y0_人指, this.人指CD, DisUnit, true);
			this.X6Y0_呪印_輪1_輪外CP = new ColorP(this.X6Y0_呪印_輪1_輪外, this.呪印_輪1_輪外CD, DisUnit, true);
			this.X6Y0_呪印_輪1_輪内CP = new ColorP(this.X6Y0_呪印_輪1_輪内, this.呪印_輪1_輪内CD, DisUnit, true);
			this.X6Y0_呪印_輪2_輪外CP = new ColorP(this.X6Y0_呪印_輪2_輪外, this.呪印_輪2_輪外CD, DisUnit, true);
			this.X6Y0_呪印_輪2_輪内CP = new ColorP(this.X6Y0_呪印_輪2_輪内, this.呪印_輪2_輪内CD, DisUnit, true);
			this.X6Y0_呪印_輪3_輪外CP = new ColorP(this.X6Y0_呪印_輪3_輪外, this.呪印_輪3_輪外CD, DisUnit, true);
			this.X6Y0_呪印_輪3_輪内CP = new ColorP(this.X6Y0_呪印_輪3_輪内, this.呪印_輪3_輪内CD, DisUnit, true);
			this.X6Y0_呪印_鎖1CP = new ColorP(this.X6Y0_呪印_鎖1, this.呪印_鎖1CD, DisUnit, true);
			this.X6Y0_呪印_鎖2CP = new ColorP(this.X6Y0_呪印_鎖2, this.呪印_鎖2CD, DisUnit, true);
			this.X6Y0_呪印_鎖3CP = new ColorP(this.X6Y0_呪印_鎖3, this.呪印_鎖3CD, DisUnit, true);
			this.X6Y1_親指CP = new ColorP(this.X6Y1_親指, this.親指CD, DisUnit, true);
			this.X6Y1_手CP = new ColorP(this.X6Y1_手, this.手CD, DisUnit, true);
			this.X6Y1_小指CP = new ColorP(this.X6Y1_小指, this.小指CD, DisUnit, true);
			this.X6Y1_薬指CP = new ColorP(this.X6Y1_薬指, this.薬指CD, DisUnit, true);
			this.X6Y1_中指CP = new ColorP(this.X6Y1_中指, this.中指CD, DisUnit, true);
			this.X6Y1_人指CP = new ColorP(this.X6Y1_人指, this.人指CD, DisUnit, true);
			this.X6Y1_呪印_輪1_輪外CP = new ColorP(this.X6Y1_呪印_輪1_輪外, this.呪印_輪1_輪外CD, DisUnit, true);
			this.X6Y1_呪印_輪1_輪内CP = new ColorP(this.X6Y1_呪印_輪1_輪内, this.呪印_輪1_輪内CD, DisUnit, true);
			this.X6Y1_呪印_輪2_輪外CP = new ColorP(this.X6Y1_呪印_輪2_輪外, this.呪印_輪2_輪外CD, DisUnit, true);
			this.X6Y1_呪印_輪2_輪内CP = new ColorP(this.X6Y1_呪印_輪2_輪内, this.呪印_輪2_輪内CD, DisUnit, true);
			this.X6Y1_呪印_輪3_輪外CP = new ColorP(this.X6Y1_呪印_輪3_輪外, this.呪印_輪3_輪外CD, DisUnit, true);
			this.X6Y1_呪印_輪3_輪内CP = new ColorP(this.X6Y1_呪印_輪3_輪内, this.呪印_輪3_輪内CD, DisUnit, true);
			this.X6Y1_呪印_鎖1CP = new ColorP(this.X6Y1_呪印_鎖1, this.呪印_鎖1CD, DisUnit, true);
			this.X6Y1_呪印_鎖2CP = new ColorP(this.X6Y1_呪印_鎖2, this.呪印_鎖2CD, DisUnit, true);
			this.X6Y1_呪印_鎖3CP = new ColorP(this.X6Y1_呪印_鎖3, this.呪印_鎖3CD, DisUnit, true);
			this.X6Y2_親指CP = new ColorP(this.X6Y2_親指, this.親指CD, DisUnit, true);
			this.X6Y2_手CP = new ColorP(this.X6Y2_手, this.手CD, DisUnit, true);
			this.X6Y2_小指CP = new ColorP(this.X6Y2_小指, this.小指CD, DisUnit, true);
			this.X6Y2_薬指CP = new ColorP(this.X6Y2_薬指, this.薬指CD, DisUnit, true);
			this.X6Y2_中指CP = new ColorP(this.X6Y2_中指, this.中指CD, DisUnit, true);
			this.X6Y2_人指CP = new ColorP(this.X6Y2_人指, this.人指CD, DisUnit, true);
			this.X6Y2_呪印_輪1_輪外CP = new ColorP(this.X6Y2_呪印_輪1_輪外, this.呪印_輪1_輪外CD, DisUnit, true);
			this.X6Y2_呪印_輪1_輪内CP = new ColorP(this.X6Y2_呪印_輪1_輪内, this.呪印_輪1_輪内CD, DisUnit, true);
			this.X6Y2_呪印_輪2_輪外CP = new ColorP(this.X6Y2_呪印_輪2_輪外, this.呪印_輪2_輪外CD, DisUnit, true);
			this.X6Y2_呪印_輪2_輪内CP = new ColorP(this.X6Y2_呪印_輪2_輪内, this.呪印_輪2_輪内CD, DisUnit, true);
			this.X6Y2_呪印_輪3_輪外CP = new ColorP(this.X6Y2_呪印_輪3_輪外, this.呪印_輪3_輪外CD, DisUnit, true);
			this.X6Y2_呪印_輪3_輪内CP = new ColorP(this.X6Y2_呪印_輪3_輪内, this.呪印_輪3_輪内CD, DisUnit, true);
			this.X6Y2_呪印_鎖1CP = new ColorP(this.X6Y2_呪印_鎖1, this.呪印_鎖1CD, DisUnit, true);
			this.X6Y2_呪印_鎖2CP = new ColorP(this.X6Y2_呪印_鎖2, this.呪印_鎖2CD, DisUnit, true);
			this.X6Y2_呪印_鎖3CP = new ColorP(this.X6Y2_呪印_鎖3, this.呪印_鎖3CD, DisUnit, true);
			this.X6Y3_親指CP = new ColorP(this.X6Y3_親指, this.親指CD, DisUnit, true);
			this.X6Y3_手CP = new ColorP(this.X6Y3_手, this.手CD, DisUnit, true);
			this.X6Y3_小指CP = new ColorP(this.X6Y3_小指, this.小指CD, DisUnit, true);
			this.X6Y3_薬指CP = new ColorP(this.X6Y3_薬指, this.薬指CD, DisUnit, true);
			this.X6Y3_中指CP = new ColorP(this.X6Y3_中指, this.中指CD, DisUnit, true);
			this.X6Y3_人指CP = new ColorP(this.X6Y3_人指, this.人指CD, DisUnit, true);
			this.X6Y3_呪印_輪1_輪外CP = new ColorP(this.X6Y3_呪印_輪1_輪外, this.呪印_輪1_輪外CD, DisUnit, true);
			this.X6Y3_呪印_輪1_輪内CP = new ColorP(this.X6Y3_呪印_輪1_輪内, this.呪印_輪1_輪内CD, DisUnit, true);
			this.X6Y3_呪印_輪2_輪外CP = new ColorP(this.X6Y3_呪印_輪2_輪外, this.呪印_輪2_輪外CD, DisUnit, true);
			this.X6Y3_呪印_輪2_輪内CP = new ColorP(this.X6Y3_呪印_輪2_輪内, this.呪印_輪2_輪内CD, DisUnit, true);
			this.X6Y3_呪印_輪3_輪外CP = new ColorP(this.X6Y3_呪印_輪3_輪外, this.呪印_輪3_輪外CD, DisUnit, true);
			this.X6Y3_呪印_輪3_輪内CP = new ColorP(this.X6Y3_呪印_輪3_輪内, this.呪印_輪3_輪内CD, DisUnit, true);
			this.X6Y3_呪印_鎖1CP = new ColorP(this.X6Y3_呪印_鎖1, this.呪印_鎖1CD, DisUnit, true);
			this.X6Y3_呪印_鎖2CP = new ColorP(this.X6Y3_呪印_鎖2, this.呪印_鎖2CD, DisUnit, true);
			this.X6Y3_呪印_鎖3CP = new ColorP(this.X6Y3_呪印_鎖3, this.呪印_鎖3CD, DisUnit, true);
			this.X6Y4_親指CP = new ColorP(this.X6Y4_親指, this.親指CD, DisUnit, true);
			this.X6Y4_手CP = new ColorP(this.X6Y4_手, this.手CD, DisUnit, true);
			this.X6Y4_小指CP = new ColorP(this.X6Y4_小指, this.小指CD, DisUnit, true);
			this.X6Y4_薬指CP = new ColorP(this.X6Y4_薬指, this.薬指CD, DisUnit, true);
			this.X6Y4_中指CP = new ColorP(this.X6Y4_中指, this.中指CD, DisUnit, true);
			this.X6Y4_人指CP = new ColorP(this.X6Y4_人指, this.人指CD, DisUnit, true);
			this.X6Y4_呪印_輪1_輪外CP = new ColorP(this.X6Y4_呪印_輪1_輪外, this.呪印_輪1_輪外CD, DisUnit, true);
			this.X6Y4_呪印_輪1_輪内CP = new ColorP(this.X6Y4_呪印_輪1_輪内, this.呪印_輪1_輪内CD, DisUnit, true);
			this.X6Y4_呪印_輪2_輪外CP = new ColorP(this.X6Y4_呪印_輪2_輪外, this.呪印_輪2_輪外CD, DisUnit, true);
			this.X6Y4_呪印_輪2_輪内CP = new ColorP(this.X6Y4_呪印_輪2_輪内, this.呪印_輪2_輪内CD, DisUnit, true);
			this.X6Y4_呪印_輪3_輪外CP = new ColorP(this.X6Y4_呪印_輪3_輪外, this.呪印_輪3_輪外CD, DisUnit, true);
			this.X6Y4_呪印_輪3_輪内CP = new ColorP(this.X6Y4_呪印_輪3_輪内, this.呪印_輪3_輪内CD, DisUnit, true);
			this.X6Y4_呪印_鎖1CP = new ColorP(this.X6Y4_呪印_鎖1, this.呪印_鎖1CD, DisUnit, true);
			this.X6Y4_呪印_鎖2CP = new ColorP(this.X6Y4_呪印_鎖2, this.呪印_鎖2CD, DisUnit, true);
			this.X6Y4_呪印_鎖3CP = new ColorP(this.X6Y4_呪印_鎖3, this.呪印_鎖3CD, DisUnit, true);
			this.X7Y0_小指CP = new ColorP(this.X7Y0_小指, this.小指CD, DisUnit, true);
			this.X7Y0_薬指CP = new ColorP(this.X7Y0_薬指, this.薬指CD, DisUnit, true);
			this.X7Y0_中指CP = new ColorP(this.X7Y0_中指, this.中指CD, DisUnit, true);
			this.X7Y0_親指CP = new ColorP(this.X7Y0_親指, this.親指CD, DisUnit, true);
			this.X7Y0_手CP = new ColorP(this.X7Y0_手, this.手CD, DisUnit, true);
			this.X7Y0_人指CP = new ColorP(this.X7Y0_人指, this.人指CD, DisUnit, true);
			this.X7Y0_呪印_輪1_輪外CP = new ColorP(this.X7Y0_呪印_輪1_輪外, this.呪印_輪1_輪外CD, DisUnit, true);
			this.X7Y0_呪印_輪1_輪内CP = new ColorP(this.X7Y0_呪印_輪1_輪内, this.呪印_輪1_輪内CD, DisUnit, true);
			this.X7Y0_呪印_輪2_輪外CP = new ColorP(this.X7Y0_呪印_輪2_輪外, this.呪印_輪2_輪外CD, DisUnit, true);
			this.X7Y0_呪印_輪2_輪内CP = new ColorP(this.X7Y0_呪印_輪2_輪内, this.呪印_輪2_輪内CD, DisUnit, true);
			this.X7Y0_呪印_輪3_輪外CP = new ColorP(this.X7Y0_呪印_輪3_輪外, this.呪印_輪3_輪外CD, DisUnit, true);
			this.X7Y0_呪印_輪3_輪内CP = new ColorP(this.X7Y0_呪印_輪3_輪内, this.呪印_輪3_輪内CD, DisUnit, true);
			this.X7Y0_呪印_鎖1CP = new ColorP(this.X7Y0_呪印_鎖1, this.呪印_鎖1CD, DisUnit, true);
			this.X7Y0_呪印_鎖2CP = new ColorP(this.X7Y0_呪印_鎖2, this.呪印_鎖2CD, DisUnit, true);
			this.X7Y0_呪印_鎖3CP = new ColorP(this.X7Y0_呪印_鎖3, this.呪印_鎖3CD, DisUnit, true);
			this.X7Y1_小指CP = new ColorP(this.X7Y1_小指, this.小指CD, DisUnit, true);
			this.X7Y1_薬指CP = new ColorP(this.X7Y1_薬指, this.薬指CD, DisUnit, true);
			this.X7Y1_中指CP = new ColorP(this.X7Y1_中指, this.中指CD, DisUnit, true);
			this.X7Y1_親指CP = new ColorP(this.X7Y1_親指, this.親指CD, DisUnit, true);
			this.X7Y1_手CP = new ColorP(this.X7Y1_手, this.手CD, DisUnit, true);
			this.X7Y1_人指CP = new ColorP(this.X7Y1_人指, this.人指CD, DisUnit, true);
			this.X7Y1_呪印_輪1_輪外CP = new ColorP(this.X7Y1_呪印_輪1_輪外, this.呪印_輪1_輪外CD, DisUnit, true);
			this.X7Y1_呪印_輪1_輪内CP = new ColorP(this.X7Y1_呪印_輪1_輪内, this.呪印_輪1_輪内CD, DisUnit, true);
			this.X7Y1_呪印_輪2_輪外CP = new ColorP(this.X7Y1_呪印_輪2_輪外, this.呪印_輪2_輪外CD, DisUnit, true);
			this.X7Y1_呪印_輪2_輪内CP = new ColorP(this.X7Y1_呪印_輪2_輪内, this.呪印_輪2_輪内CD, DisUnit, true);
			this.X7Y1_呪印_輪3_輪外CP = new ColorP(this.X7Y1_呪印_輪3_輪外, this.呪印_輪3_輪外CD, DisUnit, true);
			this.X7Y1_呪印_輪3_輪内CP = new ColorP(this.X7Y1_呪印_輪3_輪内, this.呪印_輪3_輪内CD, DisUnit, true);
			this.X7Y1_呪印_鎖1CP = new ColorP(this.X7Y1_呪印_鎖1, this.呪印_鎖1CD, DisUnit, true);
			this.X7Y1_呪印_鎖2CP = new ColorP(this.X7Y1_呪印_鎖2, this.呪印_鎖2CD, DisUnit, true);
			this.X7Y1_呪印_鎖3CP = new ColorP(this.X7Y1_呪印_鎖3, this.呪印_鎖3CD, DisUnit, true);
			this.X7Y2_小指CP = new ColorP(this.X7Y2_小指, this.小指CD, DisUnit, true);
			this.X7Y2_薬指CP = new ColorP(this.X7Y2_薬指, this.薬指CD, DisUnit, true);
			this.X7Y2_中指CP = new ColorP(this.X7Y2_中指, this.中指CD, DisUnit, true);
			this.X7Y2_親指CP = new ColorP(this.X7Y2_親指, this.親指CD, DisUnit, true);
			this.X7Y2_手CP = new ColorP(this.X7Y2_手, this.手CD, DisUnit, true);
			this.X7Y2_人指CP = new ColorP(this.X7Y2_人指, this.人指CD, DisUnit, true);
			this.X7Y2_呪印_輪1_輪外CP = new ColorP(this.X7Y2_呪印_輪1_輪外, this.呪印_輪1_輪外CD, DisUnit, true);
			this.X7Y2_呪印_輪1_輪内CP = new ColorP(this.X7Y2_呪印_輪1_輪内, this.呪印_輪1_輪内CD, DisUnit, true);
			this.X7Y2_呪印_輪2_輪外CP = new ColorP(this.X7Y2_呪印_輪2_輪外, this.呪印_輪2_輪外CD, DisUnit, true);
			this.X7Y2_呪印_輪2_輪内CP = new ColorP(this.X7Y2_呪印_輪2_輪内, this.呪印_輪2_輪内CD, DisUnit, true);
			this.X7Y2_呪印_輪3_輪外CP = new ColorP(this.X7Y2_呪印_輪3_輪外, this.呪印_輪3_輪外CD, DisUnit, true);
			this.X7Y2_呪印_輪3_輪内CP = new ColorP(this.X7Y2_呪印_輪3_輪内, this.呪印_輪3_輪内CD, DisUnit, true);
			this.X7Y2_呪印_鎖1CP = new ColorP(this.X7Y2_呪印_鎖1, this.呪印_鎖1CD, DisUnit, true);
			this.X7Y2_呪印_鎖2CP = new ColorP(this.X7Y2_呪印_鎖2, this.呪印_鎖2CD, DisUnit, true);
			this.X7Y2_呪印_鎖3CP = new ColorP(this.X7Y2_呪印_鎖3, this.呪印_鎖3CD, DisUnit, true);
			this.X7Y3_小指CP = new ColorP(this.X7Y3_小指, this.小指CD, DisUnit, true);
			this.X7Y3_薬指CP = new ColorP(this.X7Y3_薬指, this.薬指CD, DisUnit, true);
			this.X7Y3_中指CP = new ColorP(this.X7Y3_中指, this.中指CD, DisUnit, true);
			this.X7Y3_親指CP = new ColorP(this.X7Y3_親指, this.親指CD, DisUnit, true);
			this.X7Y3_手CP = new ColorP(this.X7Y3_手, this.手CD, DisUnit, true);
			this.X7Y3_人指CP = new ColorP(this.X7Y3_人指, this.人指CD, DisUnit, true);
			this.X7Y3_呪印_輪1_輪外CP = new ColorP(this.X7Y3_呪印_輪1_輪外, this.呪印_輪1_輪外CD, DisUnit, true);
			this.X7Y3_呪印_輪1_輪内CP = new ColorP(this.X7Y3_呪印_輪1_輪内, this.呪印_輪1_輪内CD, DisUnit, true);
			this.X7Y3_呪印_輪2_輪外CP = new ColorP(this.X7Y3_呪印_輪2_輪外, this.呪印_輪2_輪外CD, DisUnit, true);
			this.X7Y3_呪印_輪2_輪内CP = new ColorP(this.X7Y3_呪印_輪2_輪内, this.呪印_輪2_輪内CD, DisUnit, true);
			this.X7Y3_呪印_輪3_輪外CP = new ColorP(this.X7Y3_呪印_輪3_輪外, this.呪印_輪3_輪外CD, DisUnit, true);
			this.X7Y3_呪印_輪3_輪内CP = new ColorP(this.X7Y3_呪印_輪3_輪内, this.呪印_輪3_輪内CD, DisUnit, true);
			this.X7Y3_呪印_鎖1CP = new ColorP(this.X7Y3_呪印_鎖1, this.呪印_鎖1CD, DisUnit, true);
			this.X7Y3_呪印_鎖2CP = new ColorP(this.X7Y3_呪印_鎖2, this.呪印_鎖2CD, DisUnit, true);
			this.X7Y3_呪印_鎖3CP = new ColorP(this.X7Y3_呪印_鎖3, this.呪印_鎖3CD, DisUnit, true);
			this.X7Y4_小指CP = new ColorP(this.X7Y4_小指, this.小指CD, DisUnit, true);
			this.X7Y4_薬指CP = new ColorP(this.X7Y4_薬指, this.薬指CD, DisUnit, true);
			this.X7Y4_中指CP = new ColorP(this.X7Y4_中指, this.中指CD, DisUnit, true);
			this.X7Y4_親指CP = new ColorP(this.X7Y4_親指, this.親指CD, DisUnit, true);
			this.X7Y4_手CP = new ColorP(this.X7Y4_手, this.手CD, DisUnit, true);
			this.X7Y4_人指CP = new ColorP(this.X7Y4_人指, this.人指CD, DisUnit, true);
			this.X7Y4_呪印_輪1_輪外CP = new ColorP(this.X7Y4_呪印_輪1_輪外, this.呪印_輪1_輪外CD, DisUnit, true);
			this.X7Y4_呪印_輪1_輪内CP = new ColorP(this.X7Y4_呪印_輪1_輪内, this.呪印_輪1_輪内CD, DisUnit, true);
			this.X7Y4_呪印_輪2_輪外CP = new ColorP(this.X7Y4_呪印_輪2_輪外, this.呪印_輪2_輪外CD, DisUnit, true);
			this.X7Y4_呪印_輪2_輪内CP = new ColorP(this.X7Y4_呪印_輪2_輪内, this.呪印_輪2_輪内CD, DisUnit, true);
			this.X7Y4_呪印_輪3_輪外CP = new ColorP(this.X7Y4_呪印_輪3_輪外, this.呪印_輪3_輪外CD, DisUnit, true);
			this.X7Y4_呪印_輪3_輪内CP = new ColorP(this.X7Y4_呪印_輪3_輪内, this.呪印_輪3_輪内CD, DisUnit, true);
			this.X7Y4_呪印_鎖1CP = new ColorP(this.X7Y4_呪印_鎖1, this.呪印_鎖1CD, DisUnit, true);
			this.X7Y4_呪印_鎖2CP = new ColorP(this.X7Y4_呪印_鎖2, this.呪印_鎖2CD, DisUnit, true);
			this.X7Y4_呪印_鎖3CP = new ColorP(this.X7Y4_呪印_鎖3, this.呪印_鎖3CD, DisUnit, true);
			this.X8Y0_手CP = new ColorP(this.X8Y0_手, this.手CD, DisUnit, true);
			this.X8Y0_小指CP = new ColorP(this.X8Y0_小指, this.小指CD, DisUnit, true);
			this.X8Y0_薬指CP = new ColorP(this.X8Y0_薬指, this.薬指CD, DisUnit, true);
			this.X8Y0_中指CP = new ColorP(this.X8Y0_中指, this.中指CD, DisUnit, true);
			this.X8Y0_人指CP = new ColorP(this.X8Y0_人指, this.人指CD, DisUnit, true);
			this.X8Y0_親指CP = new ColorP(this.X8Y0_親指, this.親指CD, DisUnit, true);
			this.X8Y1_手CP = new ColorP(this.X8Y1_手, this.手CD, DisUnit, true);
			this.X8Y1_小指CP = new ColorP(this.X8Y1_小指, this.小指CD, DisUnit, true);
			this.X8Y1_薬指CP = new ColorP(this.X8Y1_薬指, this.薬指CD, DisUnit, true);
			this.X8Y1_中指CP = new ColorP(this.X8Y1_中指, this.中指CD, DisUnit, true);
			this.X8Y1_人指CP = new ColorP(this.X8Y1_人指, this.人指CD, DisUnit, true);
			this.X8Y1_親指CP = new ColorP(this.X8Y1_親指, this.親指CD, DisUnit, true);
			this.X8Y2_手CP = new ColorP(this.X8Y2_手, this.手CD, DisUnit, true);
			this.X8Y2_小指CP = new ColorP(this.X8Y2_小指, this.小指CD, DisUnit, true);
			this.X8Y2_薬指CP = new ColorP(this.X8Y2_薬指, this.薬指CD, DisUnit, true);
			this.X8Y2_中指CP = new ColorP(this.X8Y2_中指, this.中指CD, DisUnit, true);
			this.X8Y2_人指CP = new ColorP(this.X8Y2_人指, this.人指CD, DisUnit, true);
			this.X8Y2_親指CP = new ColorP(this.X8Y2_親指, this.親指CD, DisUnit, true);
			this.X8Y3_手CP = new ColorP(this.X8Y3_手, this.手CD, DisUnit, true);
			this.X8Y3_小指CP = new ColorP(this.X8Y3_小指, this.小指CD, DisUnit, true);
			this.X8Y3_薬指CP = new ColorP(this.X8Y3_薬指, this.薬指CD, DisUnit, true);
			this.X8Y3_中指CP = new ColorP(this.X8Y3_中指, this.中指CD, DisUnit, true);
			this.X8Y3_人指CP = new ColorP(this.X8Y3_人指, this.人指CD, DisUnit, true);
			this.X8Y3_親指CP = new ColorP(this.X8Y3_親指, this.親指CD, DisUnit, true);
			this.X8Y4_手CP = new ColorP(this.X8Y4_手, this.手CD, DisUnit, true);
			this.X8Y4_小指CP = new ColorP(this.X8Y4_小指, this.小指CD, DisUnit, true);
			this.X8Y4_薬指CP = new ColorP(this.X8Y4_薬指, this.薬指CD, DisUnit, true);
			this.X8Y4_中指CP = new ColorP(this.X8Y4_中指, this.中指CD, DisUnit, true);
			this.X8Y4_人指CP = new ColorP(this.X8Y4_人指, this.人指CD, DisUnit, true);
			this.X8Y4_親指CP = new ColorP(this.X8Y4_親指, this.親指CD, DisUnit, true);
			this.X9Y0_手CP = new ColorP(this.X9Y0_手, this.手CD, DisUnit, true);
			this.X9Y0_小指CP = new ColorP(this.X9Y0_小指, this.小指CD, DisUnit, true);
			this.X9Y0_薬指CP = new ColorP(this.X9Y0_薬指, this.薬指CD, DisUnit, true);
			this.X9Y0_中指CP = new ColorP(this.X9Y0_中指, this.中指CD, DisUnit, true);
			this.X9Y0_人指CP = new ColorP(this.X9Y0_人指, this.人指CD, DisUnit, true);
			this.X9Y0_親指CP = new ColorP(this.X9Y0_親指, this.親指CD, DisUnit, true);
			this.X9Y1_手CP = new ColorP(this.X9Y1_手, this.手CD, DisUnit, true);
			this.X9Y1_小指CP = new ColorP(this.X9Y1_小指, this.小指CD, DisUnit, true);
			this.X9Y1_薬指CP = new ColorP(this.X9Y1_薬指, this.薬指CD, DisUnit, true);
			this.X9Y1_中指CP = new ColorP(this.X9Y1_中指, this.中指CD, DisUnit, true);
			this.X9Y1_人指CP = new ColorP(this.X9Y1_人指, this.人指CD, DisUnit, true);
			this.X9Y1_親指CP = new ColorP(this.X9Y1_親指, this.親指CD, DisUnit, true);
			this.X9Y2_手CP = new ColorP(this.X9Y2_手, this.手CD, DisUnit, true);
			this.X9Y2_小指CP = new ColorP(this.X9Y2_小指, this.小指CD, DisUnit, true);
			this.X9Y2_薬指CP = new ColorP(this.X9Y2_薬指, this.薬指CD, DisUnit, true);
			this.X9Y2_中指CP = new ColorP(this.X9Y2_中指, this.中指CD, DisUnit, true);
			this.X9Y2_人指CP = new ColorP(this.X9Y2_人指, this.人指CD, DisUnit, true);
			this.X9Y2_親指CP = new ColorP(this.X9Y2_親指, this.親指CD, DisUnit, true);
			this.X9Y3_手CP = new ColorP(this.X9Y3_手, this.手CD, DisUnit, true);
			this.X9Y3_小指CP = new ColorP(this.X9Y3_小指, this.小指CD, DisUnit, true);
			this.X9Y3_薬指CP = new ColorP(this.X9Y3_薬指, this.薬指CD, DisUnit, true);
			this.X9Y3_中指CP = new ColorP(this.X9Y3_中指, this.中指CD, DisUnit, true);
			this.X9Y3_人指CP = new ColorP(this.X9Y3_人指, this.人指CD, DisUnit, true);
			this.X9Y3_親指CP = new ColorP(this.X9Y3_親指, this.親指CD, DisUnit, true);
			this.X9Y4_手CP = new ColorP(this.X9Y4_手, this.手CD, DisUnit, true);
			this.X9Y4_小指CP = new ColorP(this.X9Y4_小指, this.小指CD, DisUnit, true);
			this.X9Y4_薬指CP = new ColorP(this.X9Y4_薬指, this.薬指CD, DisUnit, true);
			this.X9Y4_中指CP = new ColorP(this.X9Y4_中指, this.中指CD, DisUnit, true);
			this.X9Y4_人指CP = new ColorP(this.X9Y4_人指, this.人指CD, DisUnit, true);
			this.X9Y4_親指CP = new ColorP(this.X9Y4_親指, this.親指CD, DisUnit, true);
			this.X10Y0_親指CP = new ColorP(this.X10Y0_親指, this.親指CD, DisUnit, true);
			this.X10Y0_手CP = new ColorP(this.X10Y0_手, this.手CD, DisUnit, true);
			this.X10Y0_小指CP = new ColorP(this.X10Y0_小指, this.小指CD, DisUnit, true);
			this.X10Y0_薬指CP = new ColorP(this.X10Y0_薬指, this.薬指CD, DisUnit, true);
			this.X10Y0_中指CP = new ColorP(this.X10Y0_中指, this.中指CD, DisUnit, true);
			this.X10Y0_人指CP = new ColorP(this.X10Y0_人指, this.人指CD, DisUnit, true);
			this.X10Y0_呪印_輪1_輪外CP = new ColorP(this.X10Y0_呪印_輪1_輪外, this.呪印_輪1_輪外CD, DisUnit, true);
			this.X10Y0_呪印_輪1_輪内CP = new ColorP(this.X10Y0_呪印_輪1_輪内, this.呪印_輪1_輪内CD, DisUnit, true);
			this.X10Y0_呪印_輪2_輪外CP = new ColorP(this.X10Y0_呪印_輪2_輪外, this.呪印_輪2_輪外CD, DisUnit, true);
			this.X10Y0_呪印_輪2_輪内CP = new ColorP(this.X10Y0_呪印_輪2_輪内, this.呪印_輪2_輪内CD, DisUnit, true);
			this.X10Y0_呪印_輪3_輪外CP = new ColorP(this.X10Y0_呪印_輪3_輪外, this.呪印_輪3_輪外CD, DisUnit, true);
			this.X10Y0_呪印_輪3_輪内CP = new ColorP(this.X10Y0_呪印_輪3_輪内, this.呪印_輪3_輪内CD, DisUnit, true);
			this.X10Y0_呪印_鎖1CP = new ColorP(this.X10Y0_呪印_鎖1, this.呪印_鎖1CD, DisUnit, true);
			this.X10Y0_呪印_鎖2CP = new ColorP(this.X10Y0_呪印_鎖2, this.呪印_鎖2CD, DisUnit, true);
			this.X10Y0_呪印_鎖3CP = new ColorP(this.X10Y0_呪印_鎖3, this.呪印_鎖3CD, DisUnit, true);
			this.X10Y1_親指CP = new ColorP(this.X10Y1_親指, this.親指CD, DisUnit, true);
			this.X10Y1_手CP = new ColorP(this.X10Y1_手, this.手CD, DisUnit, true);
			this.X10Y1_小指CP = new ColorP(this.X10Y1_小指, this.小指CD, DisUnit, true);
			this.X10Y1_薬指CP = new ColorP(this.X10Y1_薬指, this.薬指CD, DisUnit, true);
			this.X10Y1_中指CP = new ColorP(this.X10Y1_中指, this.中指CD, DisUnit, true);
			this.X10Y1_人指CP = new ColorP(this.X10Y1_人指, this.人指CD, DisUnit, true);
			this.X10Y1_呪印_輪1_輪外CP = new ColorP(this.X10Y1_呪印_輪1_輪外, this.呪印_輪1_輪外CD, DisUnit, true);
			this.X10Y1_呪印_輪1_輪内CP = new ColorP(this.X10Y1_呪印_輪1_輪内, this.呪印_輪1_輪内CD, DisUnit, true);
			this.X10Y1_呪印_輪2_輪外CP = new ColorP(this.X10Y1_呪印_輪2_輪外, this.呪印_輪2_輪外CD, DisUnit, true);
			this.X10Y1_呪印_輪2_輪内CP = new ColorP(this.X10Y1_呪印_輪2_輪内, this.呪印_輪2_輪内CD, DisUnit, true);
			this.X10Y1_呪印_輪3_輪外CP = new ColorP(this.X10Y1_呪印_輪3_輪外, this.呪印_輪3_輪外CD, DisUnit, true);
			this.X10Y1_呪印_輪3_輪内CP = new ColorP(this.X10Y1_呪印_輪3_輪内, this.呪印_輪3_輪内CD, DisUnit, true);
			this.X10Y1_呪印_鎖1CP = new ColorP(this.X10Y1_呪印_鎖1, this.呪印_鎖1CD, DisUnit, true);
			this.X10Y1_呪印_鎖2CP = new ColorP(this.X10Y1_呪印_鎖2, this.呪印_鎖2CD, DisUnit, true);
			this.X10Y1_呪印_鎖3CP = new ColorP(this.X10Y1_呪印_鎖3, this.呪印_鎖3CD, DisUnit, true);
			this.X10Y2_親指CP = new ColorP(this.X10Y2_親指, this.親指CD, DisUnit, true);
			this.X10Y2_手CP = new ColorP(this.X10Y2_手, this.手CD, DisUnit, true);
			this.X10Y2_小指CP = new ColorP(this.X10Y2_小指, this.小指CD, DisUnit, true);
			this.X10Y2_薬指CP = new ColorP(this.X10Y2_薬指, this.薬指CD, DisUnit, true);
			this.X10Y2_中指CP = new ColorP(this.X10Y2_中指, this.中指CD, DisUnit, true);
			this.X10Y2_人指CP = new ColorP(this.X10Y2_人指, this.人指CD, DisUnit, true);
			this.X10Y2_呪印_輪1_輪外CP = new ColorP(this.X10Y2_呪印_輪1_輪外, this.呪印_輪1_輪外CD, DisUnit, true);
			this.X10Y2_呪印_輪1_輪内CP = new ColorP(this.X10Y2_呪印_輪1_輪内, this.呪印_輪1_輪内CD, DisUnit, true);
			this.X10Y2_呪印_輪2_輪外CP = new ColorP(this.X10Y2_呪印_輪2_輪外, this.呪印_輪2_輪外CD, DisUnit, true);
			this.X10Y2_呪印_輪2_輪内CP = new ColorP(this.X10Y2_呪印_輪2_輪内, this.呪印_輪2_輪内CD, DisUnit, true);
			this.X10Y2_呪印_輪3_輪外CP = new ColorP(this.X10Y2_呪印_輪3_輪外, this.呪印_輪3_輪外CD, DisUnit, true);
			this.X10Y2_呪印_輪3_輪内CP = new ColorP(this.X10Y2_呪印_輪3_輪内, this.呪印_輪3_輪内CD, DisUnit, true);
			this.X10Y2_呪印_鎖1CP = new ColorP(this.X10Y2_呪印_鎖1, this.呪印_鎖1CD, DisUnit, true);
			this.X10Y2_呪印_鎖2CP = new ColorP(this.X10Y2_呪印_鎖2, this.呪印_鎖2CD, DisUnit, true);
			this.X10Y2_呪印_鎖3CP = new ColorP(this.X10Y2_呪印_鎖3, this.呪印_鎖3CD, DisUnit, true);
			this.X10Y3_親指CP = new ColorP(this.X10Y3_親指, this.親指CD, DisUnit, true);
			this.X10Y3_手CP = new ColorP(this.X10Y3_手, this.手CD, DisUnit, true);
			this.X10Y3_小指CP = new ColorP(this.X10Y3_小指, this.小指CD, DisUnit, true);
			this.X10Y3_薬指CP = new ColorP(this.X10Y3_薬指, this.薬指CD, DisUnit, true);
			this.X10Y3_中指CP = new ColorP(this.X10Y3_中指, this.中指CD, DisUnit, true);
			this.X10Y3_人指CP = new ColorP(this.X10Y3_人指, this.人指CD, DisUnit, true);
			this.X10Y3_呪印_輪1_輪外CP = new ColorP(this.X10Y3_呪印_輪1_輪外, this.呪印_輪1_輪外CD, DisUnit, true);
			this.X10Y3_呪印_輪1_輪内CP = new ColorP(this.X10Y3_呪印_輪1_輪内, this.呪印_輪1_輪内CD, DisUnit, true);
			this.X10Y3_呪印_輪2_輪外CP = new ColorP(this.X10Y3_呪印_輪2_輪外, this.呪印_輪2_輪外CD, DisUnit, true);
			this.X10Y3_呪印_輪2_輪内CP = new ColorP(this.X10Y3_呪印_輪2_輪内, this.呪印_輪2_輪内CD, DisUnit, true);
			this.X10Y3_呪印_輪3_輪外CP = new ColorP(this.X10Y3_呪印_輪3_輪外, this.呪印_輪3_輪外CD, DisUnit, true);
			this.X10Y3_呪印_輪3_輪内CP = new ColorP(this.X10Y3_呪印_輪3_輪内, this.呪印_輪3_輪内CD, DisUnit, true);
			this.X10Y3_呪印_鎖1CP = new ColorP(this.X10Y3_呪印_鎖1, this.呪印_鎖1CD, DisUnit, true);
			this.X10Y3_呪印_鎖2CP = new ColorP(this.X10Y3_呪印_鎖2, this.呪印_鎖2CD, DisUnit, true);
			this.X10Y3_呪印_鎖3CP = new ColorP(this.X10Y3_呪印_鎖3, this.呪印_鎖3CD, DisUnit, true);
			this.X10Y4_親指CP = new ColorP(this.X10Y4_親指, this.親指CD, DisUnit, true);
			this.X10Y4_手CP = new ColorP(this.X10Y4_手, this.手CD, DisUnit, true);
			this.X10Y4_小指CP = new ColorP(this.X10Y4_小指, this.小指CD, DisUnit, true);
			this.X10Y4_薬指CP = new ColorP(this.X10Y4_薬指, this.薬指CD, DisUnit, true);
			this.X10Y4_中指CP = new ColorP(this.X10Y4_中指, this.中指CD, DisUnit, true);
			this.X10Y4_人指CP = new ColorP(this.X10Y4_人指, this.人指CD, DisUnit, true);
			this.X10Y4_呪印_輪1_輪外CP = new ColorP(this.X10Y4_呪印_輪1_輪外, this.呪印_輪1_輪外CD, DisUnit, true);
			this.X10Y4_呪印_輪1_輪内CP = new ColorP(this.X10Y4_呪印_輪1_輪内, this.呪印_輪1_輪内CD, DisUnit, true);
			this.X10Y4_呪印_輪2_輪外CP = new ColorP(this.X10Y4_呪印_輪2_輪外, this.呪印_輪2_輪外CD, DisUnit, true);
			this.X10Y4_呪印_輪2_輪内CP = new ColorP(this.X10Y4_呪印_輪2_輪内, this.呪印_輪2_輪内CD, DisUnit, true);
			this.X10Y4_呪印_輪3_輪外CP = new ColorP(this.X10Y4_呪印_輪3_輪外, this.呪印_輪3_輪外CD, DisUnit, true);
			this.X10Y4_呪印_輪3_輪内CP = new ColorP(this.X10Y4_呪印_輪3_輪内, this.呪印_輪3_輪内CD, DisUnit, true);
			this.X10Y4_呪印_鎖1CP = new ColorP(this.X10Y4_呪印_鎖1, this.呪印_鎖1CD, DisUnit, true);
			this.X10Y4_呪印_鎖2CP = new ColorP(this.X10Y4_呪印_鎖2, this.呪印_鎖2CD, DisUnit, true);
			this.X10Y4_呪印_鎖3CP = new ColorP(this.X10Y4_呪印_鎖3, this.呪印_鎖3CD, DisUnit, true);
			this.X11Y0_小指CP = new ColorP(this.X11Y0_小指, this.小指CD, DisUnit, true);
			this.X11Y0_薬指CP = new ColorP(this.X11Y0_薬指, this.薬指CD, DisUnit, true);
			this.X11Y0_中指CP = new ColorP(this.X11Y0_中指, this.中指CD, DisUnit, true);
			this.X11Y0_人指CP = new ColorP(this.X11Y0_人指, this.人指CD, DisUnit, true);
			this.X11Y0_手CP = new ColorP(this.X11Y0_手, this.手CD, DisUnit, true);
			this.X11Y0_親指CP = new ColorP(this.X11Y0_親指, this.親指CD, DisUnit, true);
			this.X11Y0_呪印_輪1_輪外CP = new ColorP(this.X11Y0_呪印_輪1_輪外, this.呪印_輪1_輪外CD, DisUnit, true);
			this.X11Y0_呪印_輪1_輪内CP = new ColorP(this.X11Y0_呪印_輪1_輪内, this.呪印_輪1_輪内CD, DisUnit, true);
			this.X11Y0_呪印_輪2_輪外CP = new ColorP(this.X11Y0_呪印_輪2_輪外, this.呪印_輪2_輪外CD, DisUnit, true);
			this.X11Y0_呪印_輪2_輪内CP = new ColorP(this.X11Y0_呪印_輪2_輪内, this.呪印_輪2_輪内CD, DisUnit, true);
			this.X11Y0_呪印_輪3_輪外CP = new ColorP(this.X11Y0_呪印_輪3_輪外, this.呪印_輪3_輪外CD, DisUnit, true);
			this.X11Y0_呪印_輪3_輪内CP = new ColorP(this.X11Y0_呪印_輪3_輪内, this.呪印_輪3_輪内CD, DisUnit, true);
			this.X11Y0_呪印_鎖1CP = new ColorP(this.X11Y0_呪印_鎖1, this.呪印_鎖1CD, DisUnit, true);
			this.X11Y0_呪印_鎖3CP = new ColorP(this.X11Y0_呪印_鎖3, this.呪印_鎖3CD, DisUnit, true);
			this.X12Y0_親指CP = new ColorP(this.X12Y0_親指, this.親指CD, DisUnit, true);
			this.X12Y0_手CP = new ColorP(this.X12Y0_手, this.手CD, DisUnit, true);
			this.X12Y0_小指CP = new ColorP(this.X12Y0_小指, this.小指CD, DisUnit, true);
			this.X12Y0_薬指CP = new ColorP(this.X12Y0_薬指, this.薬指CD, DisUnit, true);
			this.X12Y0_中指CP = new ColorP(this.X12Y0_中指, this.中指CD, DisUnit, true);
			this.X12Y0_人指CP = new ColorP(this.X12Y0_人指, this.人指CD, DisUnit, true);
			this.X12Y0_呪印_輪1_輪外CP = new ColorP(this.X12Y0_呪印_輪1_輪外, this.呪印_輪1_輪外CD, DisUnit, true);
			this.X12Y0_呪印_輪1_輪内CP = new ColorP(this.X12Y0_呪印_輪1_輪内, this.呪印_輪1_輪内CD, DisUnit, true);
			this.X12Y0_呪印_輪2_輪外CP = new ColorP(this.X12Y0_呪印_輪2_輪外, this.呪印_輪2_輪外CD, DisUnit, true);
			this.X12Y0_呪印_輪2_輪内CP = new ColorP(this.X12Y0_呪印_輪2_輪内, this.呪印_輪2_輪内CD, DisUnit, true);
			this.X12Y0_呪印_輪3_輪外CP = new ColorP(this.X12Y0_呪印_輪3_輪外, this.呪印_輪3_輪外CD, DisUnit, true);
			this.X12Y0_呪印_輪3_輪内CP = new ColorP(this.X12Y0_呪印_輪3_輪内, this.呪印_輪3_輪内CD, DisUnit, true);
			this.X12Y0_呪印_鎖1CP = new ColorP(this.X12Y0_呪印_鎖1, this.呪印_鎖1CD, DisUnit, true);
			this.X12Y0_呪印_鎖2CP = new ColorP(this.X12Y0_呪印_鎖2, this.呪印_鎖2CD, DisUnit, true);
			this.X12Y0_呪印_鎖3CP = new ColorP(this.X12Y0_呪印_鎖3, this.呪印_鎖3CD, DisUnit, true);
			this.X13Y0_中指CP = new ColorP(this.X13Y0_中指, this.中指CD, DisUnit, true);
			this.X13Y0_人指CP = new ColorP(this.X13Y0_人指, this.人指CD, DisUnit, true);
			this.X13Y0_手CP = new ColorP(this.X13Y0_手, this.手CD, DisUnit, true);
			this.X13Y0_親指CP = new ColorP(this.X13Y0_親指, this.親指CD, DisUnit, true);
			this.X13Y0_呪印_輪1_輪外CP = new ColorP(this.X13Y0_呪印_輪1_輪外, this.呪印_輪1_輪外CD, DisUnit, true);
			this.X13Y0_呪印_輪1_輪内CP = new ColorP(this.X13Y0_呪印_輪1_輪内, this.呪印_輪1_輪内CD, DisUnit, true);
			this.X13Y0_呪印_輪2_輪外CP = new ColorP(this.X13Y0_呪印_輪2_輪外, this.呪印_輪2_輪外CD, DisUnit, true);
			this.X13Y0_呪印_輪2_輪内CP = new ColorP(this.X13Y0_呪印_輪2_輪内, this.呪印_輪2_輪内CD, DisUnit, true);
			this.X13Y0_呪印_輪3_輪外CP = new ColorP(this.X13Y0_呪印_輪3_輪外, this.呪印_輪3_輪外CD, DisUnit, true);
			this.X13Y0_呪印_輪3_輪内CP = new ColorP(this.X13Y0_呪印_輪3_輪内, this.呪印_輪3_輪内CD, DisUnit, true);
			this.X13Y0_呪印_鎖1CP = new ColorP(this.X13Y0_呪印_鎖1, this.呪印_鎖1CD, DisUnit, true);
			this.X13Y0_呪印_鎖3CP = new ColorP(this.X13Y0_呪印_鎖3, this.呪印_鎖3CD, DisUnit, true);
			this.X14Y0_親指CP = new ColorP(this.X14Y0_親指, this.親指CD, DisUnit, true);
			this.X14Y0_手CP = new ColorP(this.X14Y0_手, this.手CD, DisUnit, true);
			this.X14Y0_小指CP = new ColorP(this.X14Y0_小指, this.小指CD, DisUnit, true);
			this.X14Y0_薬指CP = new ColorP(this.X14Y0_薬指, this.薬指CD, DisUnit, true);
			this.X14Y0_中指CP = new ColorP(this.X14Y0_中指, this.中指CD, DisUnit, true);
			this.X14Y0_人指CP = new ColorP(this.X14Y0_人指, this.人指CD, DisUnit, true);
			this.X14Y0_呪印_輪1_輪外CP = new ColorP(this.X14Y0_呪印_輪1_輪外, this.呪印_輪1_輪外CD, DisUnit, true);
			this.X14Y0_呪印_輪1_輪内CP = new ColorP(this.X14Y0_呪印_輪1_輪内, this.呪印_輪1_輪内CD, DisUnit, true);
			this.X14Y0_呪印_輪2_輪外CP = new ColorP(this.X14Y0_呪印_輪2_輪外, this.呪印_輪2_輪外CD, DisUnit, true);
			this.X14Y0_呪印_輪2_輪内CP = new ColorP(this.X14Y0_呪印_輪2_輪内, this.呪印_輪2_輪内CD, DisUnit, true);
			this.X14Y0_呪印_輪3_輪外CP = new ColorP(this.X14Y0_呪印_輪3_輪外, this.呪印_輪3_輪外CD, DisUnit, true);
			this.X14Y0_呪印_輪3_輪内CP = new ColorP(this.X14Y0_呪印_輪3_輪内, this.呪印_輪3_輪内CD, DisUnit, true);
			this.X14Y0_呪印_鎖1CP = new ColorP(this.X14Y0_呪印_鎖1, this.呪印_鎖1CD, DisUnit, true);
			this.X14Y0_呪印_鎖2CP = new ColorP(this.X14Y0_呪印_鎖2, this.呪印_鎖2CD, DisUnit, true);
			this.X14Y0_呪印_鎖3CP = new ColorP(this.X14Y0_呪印_鎖3, this.呪印_鎖3CD, DisUnit, true);
			this.X14Y1_親指CP = new ColorP(this.X14Y1_親指, this.親指CD, DisUnit, true);
			this.X14Y1_手CP = new ColorP(this.X14Y1_手, this.手CD, DisUnit, true);
			this.X14Y1_小指CP = new ColorP(this.X14Y1_小指, this.小指CD, DisUnit, true);
			this.X14Y1_薬指CP = new ColorP(this.X14Y1_薬指, this.薬指CD, DisUnit, true);
			this.X14Y1_中指CP = new ColorP(this.X14Y1_中指, this.中指CD, DisUnit, true);
			this.X14Y1_人指CP = new ColorP(this.X14Y1_人指, this.人指CD, DisUnit, true);
			this.X14Y1_呪印_輪1_輪外CP = new ColorP(this.X14Y1_呪印_輪1_輪外, this.呪印_輪1_輪外CD, DisUnit, true);
			this.X14Y1_呪印_輪1_輪内CP = new ColorP(this.X14Y1_呪印_輪1_輪内, this.呪印_輪1_輪内CD, DisUnit, true);
			this.X14Y1_呪印_輪2_輪外CP = new ColorP(this.X14Y1_呪印_輪2_輪外, this.呪印_輪2_輪外CD, DisUnit, true);
			this.X14Y1_呪印_輪2_輪内CP = new ColorP(this.X14Y1_呪印_輪2_輪内, this.呪印_輪2_輪内CD, DisUnit, true);
			this.X14Y1_呪印_輪3_輪外CP = new ColorP(this.X14Y1_呪印_輪3_輪外, this.呪印_輪3_輪外CD, DisUnit, true);
			this.X14Y1_呪印_輪3_輪内CP = new ColorP(this.X14Y1_呪印_輪3_輪内, this.呪印_輪3_輪内CD, DisUnit, true);
			this.X14Y1_呪印_鎖1CP = new ColorP(this.X14Y1_呪印_鎖1, this.呪印_鎖1CD, DisUnit, true);
			this.X14Y1_呪印_鎖2CP = new ColorP(this.X14Y1_呪印_鎖2, this.呪印_鎖2CD, DisUnit, true);
			this.X14Y1_呪印_鎖3CP = new ColorP(this.X14Y1_呪印_鎖3, this.呪印_鎖3CD, DisUnit, true);
			this.X14Y2_親指CP = new ColorP(this.X14Y2_親指, this.親指CD, DisUnit, true);
			this.X14Y2_手CP = new ColorP(this.X14Y2_手, this.手CD, DisUnit, true);
			this.X14Y2_小指CP = new ColorP(this.X14Y2_小指, this.小指CD, DisUnit, true);
			this.X14Y2_薬指CP = new ColorP(this.X14Y2_薬指, this.薬指CD, DisUnit, true);
			this.X14Y2_中指CP = new ColorP(this.X14Y2_中指, this.中指CD, DisUnit, true);
			this.X14Y2_人指CP = new ColorP(this.X14Y2_人指, this.人指CD, DisUnit, true);
			this.X14Y2_呪印_輪1_輪外CP = new ColorP(this.X14Y2_呪印_輪1_輪外, this.呪印_輪1_輪外CD, DisUnit, true);
			this.X14Y2_呪印_輪1_輪内CP = new ColorP(this.X14Y2_呪印_輪1_輪内, this.呪印_輪1_輪内CD, DisUnit, true);
			this.X14Y2_呪印_輪2_輪外CP = new ColorP(this.X14Y2_呪印_輪2_輪外, this.呪印_輪2_輪外CD, DisUnit, true);
			this.X14Y2_呪印_輪2_輪内CP = new ColorP(this.X14Y2_呪印_輪2_輪内, this.呪印_輪2_輪内CD, DisUnit, true);
			this.X14Y2_呪印_輪3_輪外CP = new ColorP(this.X14Y2_呪印_輪3_輪外, this.呪印_輪3_輪外CD, DisUnit, true);
			this.X14Y2_呪印_輪3_輪内CP = new ColorP(this.X14Y2_呪印_輪3_輪内, this.呪印_輪3_輪内CD, DisUnit, true);
			this.X14Y2_呪印_鎖1CP = new ColorP(this.X14Y2_呪印_鎖1, this.呪印_鎖1CD, DisUnit, true);
			this.X14Y2_呪印_鎖2CP = new ColorP(this.X14Y2_呪印_鎖2, this.呪印_鎖2CD, DisUnit, true);
			this.X14Y2_呪印_鎖3CP = new ColorP(this.X14Y2_呪印_鎖3, this.呪印_鎖3CD, DisUnit, true);
			this.濃度 = e.濃度;
			this.尺度B *= 1.1;
			double y = 0.0015;
			this.X6Y0_手.BasePointBase = this.X6Y0_手.ToLocal(this.X6Y0_人指.ToGlobal(this.X6Y0_人指.JP[0].Joint.AddY(y)));
			this.X6Y1_手.BasePointBase = this.X6Y1_手.ToLocal(this.X6Y1_人指.ToGlobal(this.X6Y1_人指.JP[0].Joint.AddY(y)));
			this.X6Y2_手.BasePointBase = this.X6Y2_手.ToLocal(this.X6Y2_人指.ToGlobal(this.X6Y2_人指.JP[0].Joint.AddY(y)));
			this.X6Y3_手.BasePointBase = this.X6Y3_手.ToLocal(this.X6Y3_人指.ToGlobal(this.X6Y3_人指.JP[0].Joint.AddY(y)));
			this.X6Y4_手.BasePointBase = this.X6Y4_手.ToLocal(this.X6Y4_人指.ToGlobal(this.X6Y4_人指.JP[0].Joint.AddY(y)));
			this.X7Y0_手.BasePointBase = this.X7Y0_手.ToLocal(this.X7Y0_人指.ToGlobal(this.X7Y0_人指.JP[0].Joint.AddY(y)));
			this.X7Y1_手.BasePointBase = this.X7Y1_手.ToLocal(this.X7Y1_人指.ToGlobal(this.X7Y1_人指.JP[0].Joint.AddY(y)));
			this.X7Y2_手.BasePointBase = this.X7Y2_手.ToLocal(this.X7Y2_人指.ToGlobal(this.X7Y2_人指.JP[0].Joint.AddY(y)));
			this.X7Y3_手.BasePointBase = this.X7Y3_手.ToLocal(this.X7Y3_人指.ToGlobal(this.X7Y3_人指.JP[0].Joint.AddY(y)));
			this.X7Y4_手.BasePointBase = this.X7Y4_手.ToLocal(this.X7Y4_人指.ToGlobal(this.X7Y4_人指.JP[0].Joint.AddY(y)));
			this.X8Y0_手.BasePointBase = this.X8Y0_手.ToLocal(this.X8Y0_中指.ToGlobal(this.X8Y0_中指.JP[0].Joint));
			this.X8Y1_手.BasePointBase = this.X8Y1_手.ToLocal(this.X8Y1_中指.ToGlobal(this.X8Y1_中指.JP[0].Joint));
			this.X8Y2_手.BasePointBase = this.X8Y2_手.ToLocal(this.X8Y2_中指.ToGlobal(this.X8Y2_中指.JP[0].Joint));
			this.X8Y3_手.BasePointBase = this.X8Y3_手.ToLocal(this.X8Y3_中指.ToGlobal(this.X8Y3_中指.JP[0].Joint));
			this.X8Y4_手.BasePointBase = this.X8Y4_手.ToLocal(this.X8Y4_中指.ToGlobal(this.X8Y4_中指.JP[0].Joint));
			this.尺度B = 1.075;
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

		public bool 親指_表示
		{
			get
			{
				return this.X0Y0_親指.Dra;
			}
			set
			{
				this.X0Y0_親指.Dra = value;
				this.X1Y0_親指.Dra = value;
				this.X2Y0_親指.Dra = value;
				this.X2Y1_親指.Dra = value;
				this.X2Y2_親指.Dra = value;
				this.X2Y3_親指.Dra = value;
				this.X2Y4_親指.Dra = value;
				this.X3Y0_親指.Dra = value;
				this.X4Y0_親指.Dra = value;
				this.X5Y0_親指.Dra = value;
				this.X5Y1_親指.Dra = value;
				this.X5Y2_親指.Dra = value;
				this.X5Y3_親指.Dra = value;
				this.X5Y4_親指.Dra = value;
				this.X6Y0_親指.Dra = value;
				this.X6Y1_親指.Dra = value;
				this.X6Y2_親指.Dra = value;
				this.X6Y3_親指.Dra = value;
				this.X6Y4_親指.Dra = value;
				this.X7Y0_親指.Dra = value;
				this.X7Y1_親指.Dra = value;
				this.X7Y2_親指.Dra = value;
				this.X7Y3_親指.Dra = value;
				this.X7Y4_親指.Dra = value;
				this.X8Y0_親指.Dra = value;
				this.X8Y1_親指.Dra = value;
				this.X8Y2_親指.Dra = value;
				this.X8Y3_親指.Dra = value;
				this.X8Y4_親指.Dra = value;
				this.X9Y0_親指.Dra = value;
				this.X9Y1_親指.Dra = value;
				this.X9Y2_親指.Dra = value;
				this.X9Y3_親指.Dra = value;
				this.X9Y4_親指.Dra = value;
				this.X10Y0_親指.Dra = value;
				this.X10Y1_親指.Dra = value;
				this.X10Y2_親指.Dra = value;
				this.X10Y3_親指.Dra = value;
				this.X10Y4_親指.Dra = value;
				this.X11Y0_親指.Dra = value;
				this.X12Y0_親指.Dra = value;
				this.X13Y0_親指.Dra = value;
				this.X14Y0_親指.Dra = value;
				this.X14Y1_親指.Dra = value;
				this.X14Y2_親指.Dra = value;
				this.X0Y0_親指.Hit = value;
				this.X1Y0_親指.Hit = value;
				this.X2Y0_親指.Hit = value;
				this.X2Y1_親指.Hit = value;
				this.X2Y2_親指.Hit = value;
				this.X2Y3_親指.Hit = value;
				this.X2Y4_親指.Hit = value;
				this.X3Y0_親指.Hit = value;
				this.X4Y0_親指.Hit = value;
				this.X5Y0_親指.Hit = value;
				this.X5Y1_親指.Hit = value;
				this.X5Y2_親指.Hit = value;
				this.X5Y3_親指.Hit = value;
				this.X5Y4_親指.Hit = value;
				this.X6Y0_親指.Hit = value;
				this.X6Y1_親指.Hit = value;
				this.X6Y2_親指.Hit = value;
				this.X6Y3_親指.Hit = value;
				this.X6Y4_親指.Hit = value;
				this.X7Y0_親指.Hit = value;
				this.X7Y1_親指.Hit = value;
				this.X7Y2_親指.Hit = value;
				this.X7Y3_親指.Hit = value;
				this.X7Y4_親指.Hit = value;
				this.X8Y0_親指.Hit = value;
				this.X8Y1_親指.Hit = value;
				this.X8Y2_親指.Hit = value;
				this.X8Y3_親指.Hit = value;
				this.X8Y4_親指.Hit = value;
				this.X9Y0_親指.Hit = value;
				this.X9Y1_親指.Hit = value;
				this.X9Y2_親指.Hit = value;
				this.X9Y3_親指.Hit = value;
				this.X9Y4_親指.Hit = value;
				this.X10Y0_親指.Hit = value;
				this.X10Y1_親指.Hit = value;
				this.X10Y2_親指.Hit = value;
				this.X10Y3_親指.Hit = value;
				this.X10Y4_親指.Hit = value;
				this.X11Y0_親指.Hit = value;
				this.X12Y0_親指.Hit = value;
				this.X13Y0_親指.Hit = value;
				this.X14Y0_親指.Hit = value;
				this.X14Y1_親指.Hit = value;
				this.X14Y2_親指.Hit = value;
			}
		}

		public bool 手_表示
		{
			get
			{
				return this.X0Y0_手.Dra;
			}
			set
			{
				this.X0Y0_手.Dra = value;
				this.X1Y0_手.Dra = value;
				this.X2Y0_手.Dra = value;
				this.X2Y1_手.Dra = value;
				this.X2Y2_手.Dra = value;
				this.X2Y3_手.Dra = value;
				this.X2Y4_手.Dra = value;
				this.X3Y0_手.Dra = value;
				this.X4Y0_手.Dra = value;
				this.X5Y0_手.Dra = value;
				this.X5Y1_手.Dra = value;
				this.X5Y2_手.Dra = value;
				this.X5Y3_手.Dra = value;
				this.X5Y4_手.Dra = value;
				this.X6Y0_手.Dra = value;
				this.X6Y1_手.Dra = value;
				this.X6Y2_手.Dra = value;
				this.X6Y3_手.Dra = value;
				this.X6Y4_手.Dra = value;
				this.X7Y0_手.Dra = value;
				this.X7Y1_手.Dra = value;
				this.X7Y2_手.Dra = value;
				this.X7Y3_手.Dra = value;
				this.X7Y4_手.Dra = value;
				this.X8Y0_手.Dra = value;
				this.X8Y1_手.Dra = value;
				this.X8Y2_手.Dra = value;
				this.X8Y3_手.Dra = value;
				this.X8Y4_手.Dra = value;
				this.X9Y0_手.Dra = value;
				this.X9Y1_手.Dra = value;
				this.X9Y2_手.Dra = value;
				this.X9Y3_手.Dra = value;
				this.X9Y4_手.Dra = value;
				this.X10Y0_手.Dra = value;
				this.X10Y1_手.Dra = value;
				this.X10Y2_手.Dra = value;
				this.X10Y3_手.Dra = value;
				this.X10Y4_手.Dra = value;
				this.X11Y0_手.Dra = value;
				this.X12Y0_手.Dra = value;
				this.X13Y0_手.Dra = value;
				this.X14Y0_手.Dra = value;
				this.X14Y1_手.Dra = value;
				this.X14Y2_手.Dra = value;
				this.X0Y0_手.Hit = value;
				this.X1Y0_手.Hit = value;
				this.X2Y0_手.Hit = value;
				this.X2Y1_手.Hit = value;
				this.X2Y2_手.Hit = value;
				this.X2Y3_手.Hit = value;
				this.X2Y4_手.Hit = value;
				this.X3Y0_手.Hit = value;
				this.X4Y0_手.Hit = value;
				this.X5Y0_手.Hit = value;
				this.X5Y1_手.Hit = value;
				this.X5Y2_手.Hit = value;
				this.X5Y3_手.Hit = value;
				this.X5Y4_手.Hit = value;
				this.X6Y0_手.Hit = value;
				this.X6Y1_手.Hit = value;
				this.X6Y2_手.Hit = value;
				this.X6Y3_手.Hit = value;
				this.X6Y4_手.Hit = value;
				this.X7Y0_手.Hit = value;
				this.X7Y1_手.Hit = value;
				this.X7Y2_手.Hit = value;
				this.X7Y3_手.Hit = value;
				this.X7Y4_手.Hit = value;
				this.X8Y0_手.Hit = value;
				this.X8Y1_手.Hit = value;
				this.X8Y2_手.Hit = value;
				this.X8Y3_手.Hit = value;
				this.X8Y4_手.Hit = value;
				this.X9Y0_手.Hit = value;
				this.X9Y1_手.Hit = value;
				this.X9Y2_手.Hit = value;
				this.X9Y3_手.Hit = value;
				this.X9Y4_手.Hit = value;
				this.X10Y0_手.Hit = value;
				this.X10Y1_手.Hit = value;
				this.X10Y2_手.Hit = value;
				this.X10Y3_手.Hit = value;
				this.X10Y4_手.Hit = value;
				this.X11Y0_手.Hit = value;
				this.X12Y0_手.Hit = value;
				this.X13Y0_手.Hit = value;
				this.X14Y0_手.Hit = value;
				this.X14Y1_手.Hit = value;
				this.X14Y2_手.Hit = value;
			}
		}

		public bool 小指_表示
		{
			get
			{
				return this.X0Y0_小指.Dra;
			}
			set
			{
				this.X0Y0_小指.Dra = value;
				this.X1Y0_小指.Dra = value;
				this.X2Y0_小指.Dra = value;
				this.X2Y1_小指.Dra = value;
				this.X2Y2_小指.Dra = value;
				this.X2Y3_小指.Dra = value;
				this.X2Y4_小指.Dra = value;
				this.X3Y0_小指.Dra = value;
				this.X4Y0_小指.Dra = value;
				this.X5Y0_小指.Dra = value;
				this.X5Y1_小指.Dra = value;
				this.X5Y2_小指.Dra = value;
				this.X5Y3_小指.Dra = value;
				this.X5Y4_小指.Dra = value;
				this.X6Y0_小指.Dra = value;
				this.X6Y1_小指.Dra = value;
				this.X6Y2_小指.Dra = value;
				this.X6Y3_小指.Dra = value;
				this.X6Y4_小指.Dra = value;
				this.X7Y0_小指.Dra = value;
				this.X7Y1_小指.Dra = value;
				this.X7Y2_小指.Dra = value;
				this.X7Y3_小指.Dra = value;
				this.X7Y4_小指.Dra = value;
				this.X8Y0_小指.Dra = value;
				this.X8Y1_小指.Dra = value;
				this.X8Y2_小指.Dra = value;
				this.X8Y3_小指.Dra = value;
				this.X8Y4_小指.Dra = value;
				this.X9Y0_小指.Dra = value;
				this.X9Y1_小指.Dra = value;
				this.X9Y2_小指.Dra = value;
				this.X9Y3_小指.Dra = value;
				this.X9Y4_小指.Dra = value;
				this.X10Y0_小指.Dra = value;
				this.X10Y1_小指.Dra = value;
				this.X10Y2_小指.Dra = value;
				this.X10Y3_小指.Dra = value;
				this.X10Y4_小指.Dra = value;
				this.X11Y0_小指.Dra = value;
				this.X12Y0_小指.Dra = value;
				this.X14Y0_小指.Dra = value;
				this.X14Y1_小指.Dra = value;
				this.X14Y2_小指.Dra = value;
				this.X0Y0_小指.Hit = value;
				this.X1Y0_小指.Hit = value;
				this.X2Y0_小指.Hit = value;
				this.X2Y1_小指.Hit = value;
				this.X2Y2_小指.Hit = value;
				this.X2Y3_小指.Hit = value;
				this.X2Y4_小指.Hit = value;
				this.X3Y0_小指.Hit = value;
				this.X4Y0_小指.Hit = value;
				this.X5Y0_小指.Hit = value;
				this.X5Y1_小指.Hit = value;
				this.X5Y2_小指.Hit = value;
				this.X5Y3_小指.Hit = value;
				this.X5Y4_小指.Hit = value;
				this.X6Y0_小指.Hit = value;
				this.X6Y1_小指.Hit = value;
				this.X6Y2_小指.Hit = value;
				this.X6Y3_小指.Hit = value;
				this.X6Y4_小指.Hit = value;
				this.X7Y0_小指.Hit = value;
				this.X7Y1_小指.Hit = value;
				this.X7Y2_小指.Hit = value;
				this.X7Y3_小指.Hit = value;
				this.X7Y4_小指.Hit = value;
				this.X8Y0_小指.Hit = value;
				this.X8Y1_小指.Hit = value;
				this.X8Y2_小指.Hit = value;
				this.X8Y3_小指.Hit = value;
				this.X8Y4_小指.Hit = value;
				this.X9Y0_小指.Hit = value;
				this.X9Y1_小指.Hit = value;
				this.X9Y2_小指.Hit = value;
				this.X9Y3_小指.Hit = value;
				this.X9Y4_小指.Hit = value;
				this.X10Y0_小指.Hit = value;
				this.X10Y1_小指.Hit = value;
				this.X10Y2_小指.Hit = value;
				this.X10Y3_小指.Hit = value;
				this.X10Y4_小指.Hit = value;
				this.X11Y0_小指.Hit = value;
				this.X12Y0_小指.Hit = value;
				this.X14Y0_小指.Hit = value;
				this.X14Y1_小指.Hit = value;
				this.X14Y2_小指.Hit = value;
			}
		}

		public bool 薬指_表示
		{
			get
			{
				return this.X0Y0_薬指.Dra;
			}
			set
			{
				this.X0Y0_薬指.Dra = value;
				this.X1Y0_薬指.Dra = value;
				this.X2Y0_薬指.Dra = value;
				this.X2Y1_薬指.Dra = value;
				this.X2Y2_薬指.Dra = value;
				this.X2Y3_薬指.Dra = value;
				this.X2Y4_薬指.Dra = value;
				this.X3Y0_薬指.Dra = value;
				this.X4Y0_薬指.Dra = value;
				this.X5Y0_薬指.Dra = value;
				this.X5Y1_薬指.Dra = value;
				this.X5Y2_薬指.Dra = value;
				this.X5Y3_薬指.Dra = value;
				this.X5Y4_薬指.Dra = value;
				this.X6Y0_薬指.Dra = value;
				this.X6Y1_薬指.Dra = value;
				this.X6Y2_薬指.Dra = value;
				this.X6Y3_薬指.Dra = value;
				this.X6Y4_薬指.Dra = value;
				this.X7Y0_薬指.Dra = value;
				this.X7Y1_薬指.Dra = value;
				this.X7Y2_薬指.Dra = value;
				this.X7Y3_薬指.Dra = value;
				this.X7Y4_薬指.Dra = value;
				this.X8Y0_薬指.Dra = value;
				this.X8Y1_薬指.Dra = value;
				this.X8Y2_薬指.Dra = value;
				this.X8Y3_薬指.Dra = value;
				this.X8Y4_薬指.Dra = value;
				this.X9Y0_薬指.Dra = value;
				this.X9Y1_薬指.Dra = value;
				this.X9Y2_薬指.Dra = value;
				this.X9Y3_薬指.Dra = value;
				this.X9Y4_薬指.Dra = value;
				this.X10Y0_薬指.Dra = value;
				this.X10Y1_薬指.Dra = value;
				this.X10Y2_薬指.Dra = value;
				this.X10Y3_薬指.Dra = value;
				this.X10Y4_薬指.Dra = value;
				this.X11Y0_薬指.Dra = value;
				this.X12Y0_薬指.Dra = value;
				this.X14Y0_薬指.Dra = value;
				this.X14Y1_薬指.Dra = value;
				this.X14Y2_薬指.Dra = value;
				this.X0Y0_薬指.Hit = value;
				this.X1Y0_薬指.Hit = value;
				this.X2Y0_薬指.Hit = value;
				this.X2Y1_薬指.Hit = value;
				this.X2Y2_薬指.Hit = value;
				this.X2Y3_薬指.Hit = value;
				this.X2Y4_薬指.Hit = value;
				this.X3Y0_薬指.Hit = value;
				this.X4Y0_薬指.Hit = value;
				this.X5Y0_薬指.Hit = value;
				this.X5Y1_薬指.Hit = value;
				this.X5Y2_薬指.Hit = value;
				this.X5Y3_薬指.Hit = value;
				this.X5Y4_薬指.Hit = value;
				this.X6Y0_薬指.Hit = value;
				this.X6Y1_薬指.Hit = value;
				this.X6Y2_薬指.Hit = value;
				this.X6Y3_薬指.Hit = value;
				this.X6Y4_薬指.Hit = value;
				this.X7Y0_薬指.Hit = value;
				this.X7Y1_薬指.Hit = value;
				this.X7Y2_薬指.Hit = value;
				this.X7Y3_薬指.Hit = value;
				this.X7Y4_薬指.Hit = value;
				this.X8Y0_薬指.Hit = value;
				this.X8Y1_薬指.Hit = value;
				this.X8Y2_薬指.Hit = value;
				this.X8Y3_薬指.Hit = value;
				this.X8Y4_薬指.Hit = value;
				this.X9Y0_薬指.Hit = value;
				this.X9Y1_薬指.Hit = value;
				this.X9Y2_薬指.Hit = value;
				this.X9Y3_薬指.Hit = value;
				this.X9Y4_薬指.Hit = value;
				this.X10Y0_薬指.Hit = value;
				this.X10Y1_薬指.Hit = value;
				this.X10Y2_薬指.Hit = value;
				this.X10Y3_薬指.Hit = value;
				this.X10Y4_薬指.Hit = value;
				this.X11Y0_薬指.Hit = value;
				this.X12Y0_薬指.Hit = value;
				this.X14Y0_薬指.Hit = value;
				this.X14Y1_薬指.Hit = value;
				this.X14Y2_薬指.Hit = value;
			}
		}

		public bool 中指_表示
		{
			get
			{
				return this.X0Y0_中指.Dra;
			}
			set
			{
				this.X0Y0_中指.Dra = value;
				this.X1Y0_中指.Dra = value;
				this.X2Y0_中指.Dra = value;
				this.X2Y1_中指.Dra = value;
				this.X2Y2_中指.Dra = value;
				this.X2Y3_中指.Dra = value;
				this.X2Y4_中指.Dra = value;
				this.X3Y0_中指.Dra = value;
				this.X4Y0_中指.Dra = value;
				this.X5Y0_中指.Dra = value;
				this.X5Y1_中指.Dra = value;
				this.X5Y2_中指.Dra = value;
				this.X5Y3_中指.Dra = value;
				this.X5Y4_中指.Dra = value;
				this.X6Y0_中指.Dra = value;
				this.X6Y1_中指.Dra = value;
				this.X6Y2_中指.Dra = value;
				this.X6Y3_中指.Dra = value;
				this.X6Y4_中指.Dra = value;
				this.X7Y0_中指.Dra = value;
				this.X7Y1_中指.Dra = value;
				this.X7Y2_中指.Dra = value;
				this.X7Y3_中指.Dra = value;
				this.X7Y4_中指.Dra = value;
				this.X8Y0_中指.Dra = value;
				this.X8Y1_中指.Dra = value;
				this.X8Y2_中指.Dra = value;
				this.X8Y3_中指.Dra = value;
				this.X8Y4_中指.Dra = value;
				this.X9Y0_中指.Dra = value;
				this.X9Y1_中指.Dra = value;
				this.X9Y2_中指.Dra = value;
				this.X9Y3_中指.Dra = value;
				this.X9Y4_中指.Dra = value;
				this.X10Y0_中指.Dra = value;
				this.X10Y1_中指.Dra = value;
				this.X10Y2_中指.Dra = value;
				this.X10Y3_中指.Dra = value;
				this.X10Y4_中指.Dra = value;
				this.X11Y0_中指.Dra = value;
				this.X12Y0_中指.Dra = value;
				this.X13Y0_中指.Dra = value;
				this.X14Y0_中指.Dra = value;
				this.X14Y1_中指.Dra = value;
				this.X14Y2_中指.Dra = value;
				this.X0Y0_中指.Hit = value;
				this.X1Y0_中指.Hit = value;
				this.X2Y0_中指.Hit = value;
				this.X2Y1_中指.Hit = value;
				this.X2Y2_中指.Hit = value;
				this.X2Y3_中指.Hit = value;
				this.X2Y4_中指.Hit = value;
				this.X3Y0_中指.Hit = value;
				this.X4Y0_中指.Hit = value;
				this.X5Y0_中指.Hit = value;
				this.X5Y1_中指.Hit = value;
				this.X5Y2_中指.Hit = value;
				this.X5Y3_中指.Hit = value;
				this.X5Y4_中指.Hit = value;
				this.X6Y0_中指.Hit = value;
				this.X6Y1_中指.Hit = value;
				this.X6Y2_中指.Hit = value;
				this.X6Y3_中指.Hit = value;
				this.X6Y4_中指.Hit = value;
				this.X7Y0_中指.Hit = value;
				this.X7Y1_中指.Hit = value;
				this.X7Y2_中指.Hit = value;
				this.X7Y3_中指.Hit = value;
				this.X7Y4_中指.Hit = value;
				this.X8Y0_中指.Hit = value;
				this.X8Y1_中指.Hit = value;
				this.X8Y2_中指.Hit = value;
				this.X8Y3_中指.Hit = value;
				this.X8Y4_中指.Hit = value;
				this.X9Y0_中指.Hit = value;
				this.X9Y1_中指.Hit = value;
				this.X9Y2_中指.Hit = value;
				this.X9Y3_中指.Hit = value;
				this.X9Y4_中指.Hit = value;
				this.X10Y0_中指.Hit = value;
				this.X10Y1_中指.Hit = value;
				this.X10Y2_中指.Hit = value;
				this.X10Y3_中指.Hit = value;
				this.X10Y4_中指.Hit = value;
				this.X11Y0_中指.Hit = value;
				this.X12Y0_中指.Hit = value;
				this.X13Y0_中指.Hit = value;
				this.X14Y0_中指.Hit = value;
				this.X14Y1_中指.Hit = value;
				this.X14Y2_中指.Hit = value;
			}
		}

		public bool 人指_表示
		{
			get
			{
				return this.X0Y0_人指.Dra;
			}
			set
			{
				this.X0Y0_人指.Dra = value;
				this.X1Y0_人指.Dra = value;
				this.X2Y0_人指.Dra = value;
				this.X2Y1_人指.Dra = value;
				this.X2Y2_人指.Dra = value;
				this.X2Y3_人指.Dra = value;
				this.X2Y4_人指.Dra = value;
				this.X3Y0_人指.Dra = value;
				this.X4Y0_人指.Dra = value;
				this.X5Y0_人指.Dra = value;
				this.X5Y1_人指.Dra = value;
				this.X5Y2_人指.Dra = value;
				this.X5Y3_人指.Dra = value;
				this.X5Y4_人指.Dra = value;
				this.X6Y0_人指.Dra = value;
				this.X6Y1_人指.Dra = value;
				this.X6Y2_人指.Dra = value;
				this.X6Y3_人指.Dra = value;
				this.X6Y4_人指.Dra = value;
				this.X7Y0_人指.Dra = value;
				this.X7Y1_人指.Dra = value;
				this.X7Y2_人指.Dra = value;
				this.X7Y3_人指.Dra = value;
				this.X7Y4_人指.Dra = value;
				this.X8Y0_人指.Dra = value;
				this.X8Y1_人指.Dra = value;
				this.X8Y2_人指.Dra = value;
				this.X8Y3_人指.Dra = value;
				this.X8Y4_人指.Dra = value;
				this.X9Y0_人指.Dra = value;
				this.X9Y1_人指.Dra = value;
				this.X9Y2_人指.Dra = value;
				this.X9Y3_人指.Dra = value;
				this.X9Y4_人指.Dra = value;
				this.X10Y0_人指.Dra = value;
				this.X10Y1_人指.Dra = value;
				this.X10Y2_人指.Dra = value;
				this.X10Y3_人指.Dra = value;
				this.X10Y4_人指.Dra = value;
				this.X11Y0_人指.Dra = value;
				this.X12Y0_人指.Dra = value;
				this.X13Y0_人指.Dra = value;
				this.X14Y0_人指.Dra = value;
				this.X14Y1_人指.Dra = value;
				this.X14Y2_人指.Dra = value;
				this.X0Y0_人指.Hit = value;
				this.X1Y0_人指.Hit = value;
				this.X2Y0_人指.Hit = value;
				this.X2Y1_人指.Hit = value;
				this.X2Y2_人指.Hit = value;
				this.X2Y3_人指.Hit = value;
				this.X2Y4_人指.Hit = value;
				this.X3Y0_人指.Hit = value;
				this.X4Y0_人指.Hit = value;
				this.X5Y0_人指.Hit = value;
				this.X5Y1_人指.Hit = value;
				this.X5Y2_人指.Hit = value;
				this.X5Y3_人指.Hit = value;
				this.X5Y4_人指.Hit = value;
				this.X6Y0_人指.Hit = value;
				this.X6Y1_人指.Hit = value;
				this.X6Y2_人指.Hit = value;
				this.X6Y3_人指.Hit = value;
				this.X6Y4_人指.Hit = value;
				this.X7Y0_人指.Hit = value;
				this.X7Y1_人指.Hit = value;
				this.X7Y2_人指.Hit = value;
				this.X7Y3_人指.Hit = value;
				this.X7Y4_人指.Hit = value;
				this.X8Y0_人指.Hit = value;
				this.X8Y1_人指.Hit = value;
				this.X8Y2_人指.Hit = value;
				this.X8Y3_人指.Hit = value;
				this.X8Y4_人指.Hit = value;
				this.X9Y0_人指.Hit = value;
				this.X9Y1_人指.Hit = value;
				this.X9Y2_人指.Hit = value;
				this.X9Y3_人指.Hit = value;
				this.X9Y4_人指.Hit = value;
				this.X10Y0_人指.Hit = value;
				this.X10Y1_人指.Hit = value;
				this.X10Y2_人指.Hit = value;
				this.X10Y3_人指.Hit = value;
				this.X10Y4_人指.Hit = value;
				this.X11Y0_人指.Hit = value;
				this.X12Y0_人指.Hit = value;
				this.X13Y0_人指.Hit = value;
				this.X14Y0_人指.Hit = value;
				this.X14Y1_人指.Hit = value;
				this.X14Y2_人指.Hit = value;
			}
		}

		public bool 呪印_輪1_輪外_表示
		{
			get
			{
				return this.X0Y0_呪印_輪1_輪外.Dra;
			}
			set
			{
				this.X0Y0_呪印_輪1_輪外.Dra = value;
				this.X1Y0_呪印_輪1_輪外.Dra = value;
				this.X2Y0_呪印_輪1_輪外.Dra = value;
				this.X2Y1_呪印_輪1_輪外.Dra = value;
				this.X2Y2_呪印_輪1_輪外.Dra = value;
				this.X2Y3_呪印_輪1_輪外.Dra = value;
				this.X2Y4_呪印_輪1_輪外.Dra = value;
				this.X3Y0_呪印_輪1_輪外.Dra = value;
				this.X4Y0_呪印_輪1_輪外.Dra = value;
				this.X5Y0_呪印_輪1_輪外.Dra = value;
				this.X5Y1_呪印_輪1_輪外.Dra = value;
				this.X5Y2_呪印_輪1_輪外.Dra = value;
				this.X5Y3_呪印_輪1_輪外.Dra = value;
				this.X5Y4_呪印_輪1_輪外.Dra = value;
				this.X6Y0_呪印_輪1_輪外.Dra = value;
				this.X6Y1_呪印_輪1_輪外.Dra = value;
				this.X6Y2_呪印_輪1_輪外.Dra = value;
				this.X6Y3_呪印_輪1_輪外.Dra = value;
				this.X6Y4_呪印_輪1_輪外.Dra = value;
				this.X7Y0_呪印_輪1_輪外.Dra = value;
				this.X7Y1_呪印_輪1_輪外.Dra = value;
				this.X7Y2_呪印_輪1_輪外.Dra = value;
				this.X7Y3_呪印_輪1_輪外.Dra = value;
				this.X7Y4_呪印_輪1_輪外.Dra = value;
				this.X10Y0_呪印_輪1_輪外.Dra = value;
				this.X10Y1_呪印_輪1_輪外.Dra = value;
				this.X10Y2_呪印_輪1_輪外.Dra = value;
				this.X10Y3_呪印_輪1_輪外.Dra = value;
				this.X10Y4_呪印_輪1_輪外.Dra = value;
				this.X11Y0_呪印_輪1_輪外.Dra = value;
				this.X12Y0_呪印_輪1_輪外.Dra = value;
				this.X13Y0_呪印_輪1_輪外.Dra = value;
				this.X14Y0_呪印_輪1_輪外.Dra = value;
				this.X14Y1_呪印_輪1_輪外.Dra = value;
				this.X14Y2_呪印_輪1_輪外.Dra = value;
				this.X0Y0_呪印_輪1_輪外.Hit = value;
				this.X1Y0_呪印_輪1_輪外.Hit = value;
				this.X2Y0_呪印_輪1_輪外.Hit = value;
				this.X2Y1_呪印_輪1_輪外.Hit = value;
				this.X2Y2_呪印_輪1_輪外.Hit = value;
				this.X2Y3_呪印_輪1_輪外.Hit = value;
				this.X2Y4_呪印_輪1_輪外.Hit = value;
				this.X3Y0_呪印_輪1_輪外.Hit = value;
				this.X4Y0_呪印_輪1_輪外.Hit = value;
				this.X5Y0_呪印_輪1_輪外.Hit = value;
				this.X5Y1_呪印_輪1_輪外.Hit = value;
				this.X5Y2_呪印_輪1_輪外.Hit = value;
				this.X5Y3_呪印_輪1_輪外.Hit = value;
				this.X5Y4_呪印_輪1_輪外.Hit = value;
				this.X6Y0_呪印_輪1_輪外.Hit = value;
				this.X6Y1_呪印_輪1_輪外.Hit = value;
				this.X6Y2_呪印_輪1_輪外.Hit = value;
				this.X6Y3_呪印_輪1_輪外.Hit = value;
				this.X6Y4_呪印_輪1_輪外.Hit = value;
				this.X7Y0_呪印_輪1_輪外.Hit = value;
				this.X7Y1_呪印_輪1_輪外.Hit = value;
				this.X7Y2_呪印_輪1_輪外.Hit = value;
				this.X7Y3_呪印_輪1_輪外.Hit = value;
				this.X7Y4_呪印_輪1_輪外.Hit = value;
				this.X10Y0_呪印_輪1_輪外.Hit = value;
				this.X10Y1_呪印_輪1_輪外.Hit = value;
				this.X10Y2_呪印_輪1_輪外.Hit = value;
				this.X10Y3_呪印_輪1_輪外.Hit = value;
				this.X10Y4_呪印_輪1_輪外.Hit = value;
				this.X11Y0_呪印_輪1_輪外.Hit = value;
				this.X12Y0_呪印_輪1_輪外.Hit = value;
				this.X13Y0_呪印_輪1_輪外.Hit = value;
				this.X14Y0_呪印_輪1_輪外.Hit = value;
				this.X14Y1_呪印_輪1_輪外.Hit = value;
				this.X14Y2_呪印_輪1_輪外.Hit = value;
			}
		}

		public bool 呪印_輪1_輪内_表示
		{
			get
			{
				return this.X0Y0_呪印_輪1_輪内.Dra;
			}
			set
			{
				this.X0Y0_呪印_輪1_輪内.Dra = value;
				this.X1Y0_呪印_輪1_輪内.Dra = value;
				this.X2Y0_呪印_輪1_輪内.Dra = value;
				this.X2Y1_呪印_輪1_輪内.Dra = value;
				this.X2Y2_呪印_輪1_輪内.Dra = value;
				this.X2Y3_呪印_輪1_輪内.Dra = value;
				this.X2Y4_呪印_輪1_輪内.Dra = value;
				this.X3Y0_呪印_輪1_輪内.Dra = value;
				this.X4Y0_呪印_輪1_輪内.Dra = value;
				this.X5Y0_呪印_輪1_輪内.Dra = value;
				this.X5Y1_呪印_輪1_輪内.Dra = value;
				this.X5Y2_呪印_輪1_輪内.Dra = value;
				this.X5Y3_呪印_輪1_輪内.Dra = value;
				this.X5Y4_呪印_輪1_輪内.Dra = value;
				this.X6Y0_呪印_輪1_輪内.Dra = value;
				this.X6Y1_呪印_輪1_輪内.Dra = value;
				this.X6Y2_呪印_輪1_輪内.Dra = value;
				this.X6Y3_呪印_輪1_輪内.Dra = value;
				this.X6Y4_呪印_輪1_輪内.Dra = value;
				this.X7Y0_呪印_輪1_輪内.Dra = value;
				this.X7Y1_呪印_輪1_輪内.Dra = value;
				this.X7Y2_呪印_輪1_輪内.Dra = value;
				this.X7Y3_呪印_輪1_輪内.Dra = value;
				this.X7Y4_呪印_輪1_輪内.Dra = value;
				this.X10Y0_呪印_輪1_輪内.Dra = value;
				this.X10Y1_呪印_輪1_輪内.Dra = value;
				this.X10Y2_呪印_輪1_輪内.Dra = value;
				this.X10Y3_呪印_輪1_輪内.Dra = value;
				this.X10Y4_呪印_輪1_輪内.Dra = value;
				this.X11Y0_呪印_輪1_輪内.Dra = value;
				this.X12Y0_呪印_輪1_輪内.Dra = value;
				this.X13Y0_呪印_輪1_輪内.Dra = value;
				this.X14Y0_呪印_輪1_輪内.Dra = value;
				this.X14Y1_呪印_輪1_輪内.Dra = value;
				this.X14Y2_呪印_輪1_輪内.Dra = value;
				this.X0Y0_呪印_輪1_輪内.Hit = value;
				this.X1Y0_呪印_輪1_輪内.Hit = value;
				this.X2Y0_呪印_輪1_輪内.Hit = value;
				this.X2Y1_呪印_輪1_輪内.Hit = value;
				this.X2Y2_呪印_輪1_輪内.Hit = value;
				this.X2Y3_呪印_輪1_輪内.Hit = value;
				this.X2Y4_呪印_輪1_輪内.Hit = value;
				this.X3Y0_呪印_輪1_輪内.Hit = value;
				this.X4Y0_呪印_輪1_輪内.Hit = value;
				this.X5Y0_呪印_輪1_輪内.Hit = value;
				this.X5Y1_呪印_輪1_輪内.Hit = value;
				this.X5Y2_呪印_輪1_輪内.Hit = value;
				this.X5Y3_呪印_輪1_輪内.Hit = value;
				this.X5Y4_呪印_輪1_輪内.Hit = value;
				this.X6Y0_呪印_輪1_輪内.Hit = value;
				this.X6Y1_呪印_輪1_輪内.Hit = value;
				this.X6Y2_呪印_輪1_輪内.Hit = value;
				this.X6Y3_呪印_輪1_輪内.Hit = value;
				this.X6Y4_呪印_輪1_輪内.Hit = value;
				this.X7Y0_呪印_輪1_輪内.Hit = value;
				this.X7Y1_呪印_輪1_輪内.Hit = value;
				this.X7Y2_呪印_輪1_輪内.Hit = value;
				this.X7Y3_呪印_輪1_輪内.Hit = value;
				this.X7Y4_呪印_輪1_輪内.Hit = value;
				this.X10Y0_呪印_輪1_輪内.Hit = value;
				this.X10Y1_呪印_輪1_輪内.Hit = value;
				this.X10Y2_呪印_輪1_輪内.Hit = value;
				this.X10Y3_呪印_輪1_輪内.Hit = value;
				this.X10Y4_呪印_輪1_輪内.Hit = value;
				this.X11Y0_呪印_輪1_輪内.Hit = value;
				this.X12Y0_呪印_輪1_輪内.Hit = value;
				this.X13Y0_呪印_輪1_輪内.Hit = value;
				this.X13Y0_呪印_輪1_輪内.Hit = value;
				this.X14Y1_呪印_輪1_輪内.Hit = value;
				this.X14Y2_呪印_輪1_輪内.Hit = value;
			}
		}

		public bool 呪印_輪2_輪外_表示
		{
			get
			{
				return this.X0Y0_呪印_輪2_輪外.Dra;
			}
			set
			{
				this.X0Y0_呪印_輪2_輪外.Dra = value;
				this.X1Y0_呪印_輪2_輪外.Dra = value;
				this.X2Y0_呪印_輪2_輪外.Dra = value;
				this.X2Y1_呪印_輪2_輪外.Dra = value;
				this.X2Y2_呪印_輪2_輪外.Dra = value;
				this.X2Y3_呪印_輪2_輪外.Dra = value;
				this.X2Y4_呪印_輪2_輪外.Dra = value;
				this.X3Y0_呪印_輪2_輪外.Dra = value;
				this.X4Y0_呪印_輪2_輪外.Dra = value;
				this.X5Y0_呪印_輪2_輪外.Dra = value;
				this.X5Y1_呪印_輪2_輪外.Dra = value;
				this.X5Y2_呪印_輪2_輪外.Dra = value;
				this.X5Y3_呪印_輪2_輪外.Dra = value;
				this.X5Y4_呪印_輪2_輪外.Dra = value;
				this.X6Y0_呪印_輪2_輪外.Dra = value;
				this.X6Y1_呪印_輪2_輪外.Dra = value;
				this.X6Y2_呪印_輪2_輪外.Dra = value;
				this.X6Y3_呪印_輪2_輪外.Dra = value;
				this.X6Y4_呪印_輪2_輪外.Dra = value;
				this.X7Y0_呪印_輪2_輪外.Dra = value;
				this.X7Y1_呪印_輪2_輪外.Dra = value;
				this.X7Y2_呪印_輪2_輪外.Dra = value;
				this.X7Y3_呪印_輪2_輪外.Dra = value;
				this.X7Y4_呪印_輪2_輪外.Dra = value;
				this.X10Y0_呪印_輪2_輪外.Dra = value;
				this.X10Y1_呪印_輪2_輪外.Dra = value;
				this.X10Y2_呪印_輪2_輪外.Dra = value;
				this.X10Y3_呪印_輪2_輪外.Dra = value;
				this.X10Y4_呪印_輪2_輪外.Dra = value;
				this.X11Y0_呪印_輪2_輪外.Dra = value;
				this.X12Y0_呪印_輪2_輪外.Dra = value;
				this.X13Y0_呪印_輪2_輪外.Dra = value;
				this.X14Y0_呪印_輪2_輪外.Dra = value;
				this.X14Y1_呪印_輪2_輪外.Dra = value;
				this.X14Y2_呪印_輪2_輪外.Dra = value;
				this.X0Y0_呪印_輪2_輪外.Hit = value;
				this.X1Y0_呪印_輪2_輪外.Hit = value;
				this.X2Y0_呪印_輪2_輪外.Hit = value;
				this.X2Y1_呪印_輪2_輪外.Hit = value;
				this.X2Y2_呪印_輪2_輪外.Hit = value;
				this.X2Y3_呪印_輪2_輪外.Hit = value;
				this.X2Y4_呪印_輪2_輪外.Hit = value;
				this.X3Y0_呪印_輪2_輪外.Hit = value;
				this.X4Y0_呪印_輪2_輪外.Hit = value;
				this.X5Y0_呪印_輪2_輪外.Hit = value;
				this.X5Y1_呪印_輪2_輪外.Hit = value;
				this.X5Y2_呪印_輪2_輪外.Hit = value;
				this.X5Y3_呪印_輪2_輪外.Hit = value;
				this.X5Y4_呪印_輪2_輪外.Hit = value;
				this.X6Y0_呪印_輪2_輪外.Hit = value;
				this.X6Y1_呪印_輪2_輪外.Hit = value;
				this.X6Y2_呪印_輪2_輪外.Hit = value;
				this.X6Y3_呪印_輪2_輪外.Hit = value;
				this.X6Y4_呪印_輪2_輪外.Hit = value;
				this.X7Y0_呪印_輪2_輪外.Hit = value;
				this.X7Y1_呪印_輪2_輪外.Hit = value;
				this.X7Y2_呪印_輪2_輪外.Hit = value;
				this.X7Y3_呪印_輪2_輪外.Hit = value;
				this.X7Y4_呪印_輪2_輪外.Hit = value;
				this.X10Y0_呪印_輪2_輪外.Hit = value;
				this.X10Y1_呪印_輪2_輪外.Hit = value;
				this.X10Y2_呪印_輪2_輪外.Hit = value;
				this.X10Y3_呪印_輪2_輪外.Hit = value;
				this.X10Y4_呪印_輪2_輪外.Hit = value;
				this.X11Y0_呪印_輪2_輪外.Hit = value;
				this.X12Y0_呪印_輪2_輪外.Hit = value;
				this.X13Y0_呪印_輪2_輪外.Hit = value;
				this.X14Y0_呪印_輪2_輪外.Hit = value;
				this.X14Y1_呪印_輪2_輪外.Hit = value;
				this.X14Y2_呪印_輪2_輪外.Hit = value;
			}
		}

		public bool 呪印_輪2_輪内_表示
		{
			get
			{
				return this.X0Y0_呪印_輪2_輪内.Dra;
			}
			set
			{
				this.X0Y0_呪印_輪2_輪内.Dra = value;
				this.X1Y0_呪印_輪2_輪内.Dra = value;
				this.X2Y0_呪印_輪2_輪内.Dra = value;
				this.X2Y1_呪印_輪2_輪内.Dra = value;
				this.X2Y2_呪印_輪2_輪内.Dra = value;
				this.X2Y3_呪印_輪2_輪内.Dra = value;
				this.X2Y4_呪印_輪2_輪内.Dra = value;
				this.X3Y0_呪印_輪2_輪内.Dra = value;
				this.X4Y0_呪印_輪2_輪内.Dra = value;
				this.X5Y0_呪印_輪2_輪内.Dra = value;
				this.X5Y1_呪印_輪2_輪内.Dra = value;
				this.X5Y2_呪印_輪2_輪内.Dra = value;
				this.X5Y3_呪印_輪2_輪内.Dra = value;
				this.X5Y4_呪印_輪2_輪内.Dra = value;
				this.X6Y0_呪印_輪2_輪内.Dra = value;
				this.X6Y1_呪印_輪2_輪内.Dra = value;
				this.X6Y2_呪印_輪2_輪内.Dra = value;
				this.X6Y3_呪印_輪2_輪内.Dra = value;
				this.X6Y4_呪印_輪2_輪内.Dra = value;
				this.X7Y0_呪印_輪2_輪内.Dra = value;
				this.X7Y1_呪印_輪2_輪内.Dra = value;
				this.X7Y2_呪印_輪2_輪内.Dra = value;
				this.X7Y3_呪印_輪2_輪内.Dra = value;
				this.X7Y4_呪印_輪2_輪内.Dra = value;
				this.X10Y0_呪印_輪2_輪内.Dra = value;
				this.X10Y1_呪印_輪2_輪内.Dra = value;
				this.X10Y2_呪印_輪2_輪内.Dra = value;
				this.X10Y3_呪印_輪2_輪内.Dra = value;
				this.X10Y4_呪印_輪2_輪内.Dra = value;
				this.X11Y0_呪印_輪2_輪内.Dra = value;
				this.X12Y0_呪印_輪2_輪内.Dra = value;
				this.X13Y0_呪印_輪2_輪内.Dra = value;
				this.X14Y0_呪印_輪2_輪内.Dra = value;
				this.X14Y1_呪印_輪2_輪内.Dra = value;
				this.X14Y2_呪印_輪2_輪内.Dra = value;
				this.X0Y0_呪印_輪2_輪内.Hit = value;
				this.X1Y0_呪印_輪2_輪内.Hit = value;
				this.X2Y0_呪印_輪2_輪内.Hit = value;
				this.X2Y1_呪印_輪2_輪内.Hit = value;
				this.X2Y2_呪印_輪2_輪内.Hit = value;
				this.X2Y3_呪印_輪2_輪内.Hit = value;
				this.X2Y4_呪印_輪2_輪内.Hit = value;
				this.X3Y0_呪印_輪2_輪内.Hit = value;
				this.X4Y0_呪印_輪2_輪内.Hit = value;
				this.X5Y0_呪印_輪2_輪内.Hit = value;
				this.X5Y1_呪印_輪2_輪内.Hit = value;
				this.X5Y2_呪印_輪2_輪内.Hit = value;
				this.X5Y3_呪印_輪2_輪内.Hit = value;
				this.X5Y4_呪印_輪2_輪内.Hit = value;
				this.X6Y0_呪印_輪2_輪内.Hit = value;
				this.X6Y1_呪印_輪2_輪内.Hit = value;
				this.X6Y2_呪印_輪2_輪内.Hit = value;
				this.X6Y3_呪印_輪2_輪内.Hit = value;
				this.X6Y4_呪印_輪2_輪内.Hit = value;
				this.X7Y0_呪印_輪2_輪内.Hit = value;
				this.X7Y1_呪印_輪2_輪内.Hit = value;
				this.X7Y2_呪印_輪2_輪内.Hit = value;
				this.X7Y3_呪印_輪2_輪内.Hit = value;
				this.X7Y4_呪印_輪2_輪内.Hit = value;
				this.X10Y0_呪印_輪2_輪内.Hit = value;
				this.X10Y1_呪印_輪2_輪内.Hit = value;
				this.X10Y2_呪印_輪2_輪内.Hit = value;
				this.X10Y3_呪印_輪2_輪内.Hit = value;
				this.X10Y4_呪印_輪2_輪内.Hit = value;
				this.X11Y0_呪印_輪2_輪内.Hit = value;
				this.X12Y0_呪印_輪2_輪内.Hit = value;
				this.X13Y0_呪印_輪2_輪内.Hit = value;
				this.X14Y0_呪印_輪2_輪内.Hit = value;
				this.X14Y1_呪印_輪2_輪内.Hit = value;
				this.X14Y2_呪印_輪2_輪内.Hit = value;
			}
		}

		public bool 呪印_輪3_輪外_表示
		{
			get
			{
				return this.X0Y0_呪印_輪3_輪外.Dra;
			}
			set
			{
				this.X0Y0_呪印_輪3_輪外.Dra = value;
				this.X1Y0_呪印_輪3_輪外.Dra = value;
				this.X2Y0_呪印_輪3_輪外.Dra = value;
				this.X2Y1_呪印_輪3_輪外.Dra = value;
				this.X2Y2_呪印_輪3_輪外.Dra = value;
				this.X2Y3_呪印_輪3_輪外.Dra = value;
				this.X2Y4_呪印_輪3_輪外.Dra = value;
				this.X3Y0_呪印_輪3_輪外.Dra = value;
				this.X4Y0_呪印_輪3_輪外.Dra = value;
				this.X5Y0_呪印_輪3_輪外.Dra = value;
				this.X5Y1_呪印_輪3_輪外.Dra = value;
				this.X5Y2_呪印_輪3_輪外.Dra = value;
				this.X5Y3_呪印_輪3_輪外.Dra = value;
				this.X5Y4_呪印_輪3_輪外.Dra = value;
				this.X6Y0_呪印_輪3_輪外.Dra = value;
				this.X6Y1_呪印_輪3_輪外.Dra = value;
				this.X6Y2_呪印_輪3_輪外.Dra = value;
				this.X6Y3_呪印_輪3_輪外.Dra = value;
				this.X6Y4_呪印_輪3_輪外.Dra = value;
				this.X7Y0_呪印_輪3_輪外.Dra = value;
				this.X7Y1_呪印_輪3_輪外.Dra = value;
				this.X7Y2_呪印_輪3_輪外.Dra = value;
				this.X7Y3_呪印_輪3_輪外.Dra = value;
				this.X7Y4_呪印_輪3_輪外.Dra = value;
				this.X10Y0_呪印_輪3_輪外.Dra = value;
				this.X10Y1_呪印_輪3_輪外.Dra = value;
				this.X10Y2_呪印_輪3_輪外.Dra = value;
				this.X10Y3_呪印_輪3_輪外.Dra = value;
				this.X10Y4_呪印_輪3_輪外.Dra = value;
				this.X11Y0_呪印_輪3_輪外.Dra = value;
				this.X12Y0_呪印_輪3_輪外.Dra = value;
				this.X13Y0_呪印_輪3_輪外.Dra = value;
				this.X14Y0_呪印_輪3_輪外.Dra = value;
				this.X14Y1_呪印_輪3_輪外.Dra = value;
				this.X14Y2_呪印_輪3_輪外.Dra = value;
				this.X0Y0_呪印_輪3_輪外.Hit = value;
				this.X1Y0_呪印_輪3_輪外.Hit = value;
				this.X2Y0_呪印_輪3_輪外.Hit = value;
				this.X2Y1_呪印_輪3_輪外.Hit = value;
				this.X2Y2_呪印_輪3_輪外.Hit = value;
				this.X2Y3_呪印_輪3_輪外.Hit = value;
				this.X2Y4_呪印_輪3_輪外.Hit = value;
				this.X3Y0_呪印_輪3_輪外.Hit = value;
				this.X4Y0_呪印_輪3_輪外.Hit = value;
				this.X5Y0_呪印_輪3_輪外.Hit = value;
				this.X5Y1_呪印_輪3_輪外.Hit = value;
				this.X5Y2_呪印_輪3_輪外.Hit = value;
				this.X5Y3_呪印_輪3_輪外.Hit = value;
				this.X5Y4_呪印_輪3_輪外.Hit = value;
				this.X6Y0_呪印_輪3_輪外.Hit = value;
				this.X6Y1_呪印_輪3_輪外.Hit = value;
				this.X6Y2_呪印_輪3_輪外.Hit = value;
				this.X6Y3_呪印_輪3_輪外.Hit = value;
				this.X6Y4_呪印_輪3_輪外.Hit = value;
				this.X7Y0_呪印_輪3_輪外.Hit = value;
				this.X7Y1_呪印_輪3_輪外.Hit = value;
				this.X7Y2_呪印_輪3_輪外.Hit = value;
				this.X7Y3_呪印_輪3_輪外.Hit = value;
				this.X7Y4_呪印_輪3_輪外.Hit = value;
				this.X10Y0_呪印_輪3_輪外.Hit = value;
				this.X10Y1_呪印_輪3_輪外.Hit = value;
				this.X10Y2_呪印_輪3_輪外.Hit = value;
				this.X10Y3_呪印_輪3_輪外.Hit = value;
				this.X10Y4_呪印_輪3_輪外.Hit = value;
				this.X11Y0_呪印_輪3_輪外.Hit = value;
				this.X12Y0_呪印_輪3_輪外.Hit = value;
				this.X13Y0_呪印_輪3_輪外.Hit = value;
				this.X14Y0_呪印_輪3_輪外.Hit = value;
				this.X14Y1_呪印_輪3_輪外.Hit = value;
				this.X14Y2_呪印_輪3_輪外.Hit = value;
			}
		}

		public bool 呪印_輪3_輪内_表示
		{
			get
			{
				return this.X0Y0_呪印_輪3_輪内.Dra;
			}
			set
			{
				this.X0Y0_呪印_輪3_輪内.Dra = value;
				this.X1Y0_呪印_輪3_輪内.Dra = value;
				this.X2Y0_呪印_輪3_輪内.Dra = value;
				this.X2Y1_呪印_輪3_輪内.Dra = value;
				this.X2Y2_呪印_輪3_輪内.Dra = value;
				this.X2Y3_呪印_輪3_輪内.Dra = value;
				this.X2Y4_呪印_輪3_輪内.Dra = value;
				this.X3Y0_呪印_輪3_輪内.Dra = value;
				this.X4Y0_呪印_輪3_輪内.Dra = value;
				this.X5Y0_呪印_輪3_輪内.Dra = value;
				this.X5Y1_呪印_輪3_輪内.Dra = value;
				this.X5Y2_呪印_輪3_輪内.Dra = value;
				this.X5Y3_呪印_輪3_輪内.Dra = value;
				this.X5Y4_呪印_輪3_輪内.Dra = value;
				this.X6Y0_呪印_輪3_輪内.Dra = value;
				this.X6Y1_呪印_輪3_輪内.Dra = value;
				this.X6Y2_呪印_輪3_輪内.Dra = value;
				this.X6Y3_呪印_輪3_輪内.Dra = value;
				this.X6Y4_呪印_輪3_輪内.Dra = value;
				this.X7Y0_呪印_輪3_輪内.Dra = value;
				this.X7Y1_呪印_輪3_輪内.Dra = value;
				this.X7Y2_呪印_輪3_輪内.Dra = value;
				this.X7Y3_呪印_輪3_輪内.Dra = value;
				this.X7Y4_呪印_輪3_輪内.Dra = value;
				this.X10Y0_呪印_輪3_輪内.Dra = value;
				this.X10Y1_呪印_輪3_輪内.Dra = value;
				this.X10Y2_呪印_輪3_輪内.Dra = value;
				this.X10Y3_呪印_輪3_輪内.Dra = value;
				this.X10Y4_呪印_輪3_輪内.Dra = value;
				this.X11Y0_呪印_輪3_輪内.Dra = value;
				this.X12Y0_呪印_輪3_輪内.Dra = value;
				this.X13Y0_呪印_輪3_輪内.Dra = value;
				this.X14Y0_呪印_輪3_輪内.Dra = value;
				this.X14Y1_呪印_輪3_輪内.Dra = value;
				this.X14Y2_呪印_輪3_輪内.Dra = value;
				this.X0Y0_呪印_輪3_輪内.Hit = value;
				this.X1Y0_呪印_輪3_輪内.Hit = value;
				this.X2Y0_呪印_輪3_輪内.Hit = value;
				this.X2Y1_呪印_輪3_輪内.Hit = value;
				this.X2Y2_呪印_輪3_輪内.Hit = value;
				this.X2Y3_呪印_輪3_輪内.Hit = value;
				this.X2Y4_呪印_輪3_輪内.Hit = value;
				this.X3Y0_呪印_輪3_輪内.Hit = value;
				this.X4Y0_呪印_輪3_輪内.Hit = value;
				this.X5Y0_呪印_輪3_輪内.Hit = value;
				this.X5Y1_呪印_輪3_輪内.Hit = value;
				this.X5Y2_呪印_輪3_輪内.Hit = value;
				this.X5Y3_呪印_輪3_輪内.Hit = value;
				this.X5Y4_呪印_輪3_輪内.Hit = value;
				this.X6Y0_呪印_輪3_輪内.Hit = value;
				this.X6Y1_呪印_輪3_輪内.Hit = value;
				this.X6Y2_呪印_輪3_輪内.Hit = value;
				this.X6Y3_呪印_輪3_輪内.Hit = value;
				this.X6Y4_呪印_輪3_輪内.Hit = value;
				this.X7Y0_呪印_輪3_輪内.Hit = value;
				this.X7Y1_呪印_輪3_輪内.Hit = value;
				this.X7Y2_呪印_輪3_輪内.Hit = value;
				this.X7Y3_呪印_輪3_輪内.Hit = value;
				this.X7Y4_呪印_輪3_輪内.Hit = value;
				this.X10Y0_呪印_輪3_輪内.Hit = value;
				this.X10Y1_呪印_輪3_輪内.Hit = value;
				this.X10Y2_呪印_輪3_輪内.Hit = value;
				this.X10Y3_呪印_輪3_輪内.Hit = value;
				this.X10Y4_呪印_輪3_輪内.Hit = value;
				this.X11Y0_呪印_輪3_輪内.Hit = value;
				this.X12Y0_呪印_輪3_輪内.Hit = value;
				this.X13Y0_呪印_輪3_輪内.Hit = value;
				this.X14Y0_呪印_輪3_輪内.Hit = value;
				this.X14Y1_呪印_輪3_輪内.Hit = value;
				this.X14Y2_呪印_輪3_輪内.Hit = value;
			}
		}

		public bool 呪印_鎖1_表示
		{
			get
			{
				return this.X0Y0_呪印_鎖1.Dra;
			}
			set
			{
				this.X0Y0_呪印_鎖1.Dra = value;
				this.X1Y0_呪印_鎖1.Dra = value;
				this.X2Y0_呪印_鎖1.Dra = value;
				this.X2Y1_呪印_鎖1.Dra = value;
				this.X2Y2_呪印_鎖1.Dra = value;
				this.X2Y3_呪印_鎖1.Dra = value;
				this.X2Y4_呪印_鎖1.Dra = value;
				this.X3Y0_呪印_鎖1.Dra = value;
				this.X4Y0_呪印_鎖1.Dra = value;
				this.X5Y0_呪印_鎖1.Dra = value;
				this.X5Y1_呪印_鎖1.Dra = value;
				this.X5Y2_呪印_鎖1.Dra = value;
				this.X5Y3_呪印_鎖1.Dra = value;
				this.X5Y4_呪印_鎖1.Dra = value;
				this.X6Y0_呪印_鎖1.Dra = value;
				this.X6Y1_呪印_鎖1.Dra = value;
				this.X6Y2_呪印_鎖1.Dra = value;
				this.X6Y3_呪印_鎖1.Dra = value;
				this.X6Y4_呪印_鎖1.Dra = value;
				this.X7Y0_呪印_鎖1.Dra = value;
				this.X7Y1_呪印_鎖1.Dra = value;
				this.X7Y2_呪印_鎖1.Dra = value;
				this.X7Y3_呪印_鎖1.Dra = value;
				this.X7Y4_呪印_鎖1.Dra = value;
				this.X10Y0_呪印_鎖1.Dra = value;
				this.X10Y1_呪印_鎖1.Dra = value;
				this.X10Y2_呪印_鎖1.Dra = value;
				this.X10Y3_呪印_鎖1.Dra = value;
				this.X10Y4_呪印_鎖1.Dra = value;
				this.X11Y0_呪印_鎖1.Dra = value;
				this.X12Y0_呪印_鎖1.Dra = value;
				this.X13Y0_呪印_鎖1.Dra = value;
				this.X14Y0_呪印_鎖1.Dra = value;
				this.X14Y1_呪印_鎖1.Dra = value;
				this.X14Y2_呪印_鎖1.Dra = value;
				this.X0Y0_呪印_鎖1.Hit = value;
				this.X1Y0_呪印_鎖1.Hit = value;
				this.X2Y0_呪印_鎖1.Hit = value;
				this.X2Y1_呪印_鎖1.Hit = value;
				this.X2Y2_呪印_鎖1.Hit = value;
				this.X2Y3_呪印_鎖1.Hit = value;
				this.X2Y4_呪印_鎖1.Hit = value;
				this.X3Y0_呪印_鎖1.Hit = value;
				this.X4Y0_呪印_鎖1.Hit = value;
				this.X5Y0_呪印_鎖1.Hit = value;
				this.X5Y1_呪印_鎖1.Hit = value;
				this.X5Y2_呪印_鎖1.Hit = value;
				this.X5Y3_呪印_鎖1.Hit = value;
				this.X5Y4_呪印_鎖1.Hit = value;
				this.X6Y0_呪印_鎖1.Hit = value;
				this.X6Y1_呪印_鎖1.Hit = value;
				this.X6Y2_呪印_鎖1.Hit = value;
				this.X6Y3_呪印_鎖1.Hit = value;
				this.X6Y4_呪印_鎖1.Hit = value;
				this.X7Y0_呪印_鎖1.Hit = value;
				this.X7Y1_呪印_鎖1.Hit = value;
				this.X7Y2_呪印_鎖1.Hit = value;
				this.X7Y3_呪印_鎖1.Hit = value;
				this.X7Y4_呪印_鎖1.Hit = value;
				this.X10Y0_呪印_鎖1.Hit = value;
				this.X10Y1_呪印_鎖1.Hit = value;
				this.X10Y2_呪印_鎖1.Hit = value;
				this.X10Y3_呪印_鎖1.Hit = value;
				this.X10Y4_呪印_鎖1.Hit = value;
				this.X11Y0_呪印_鎖1.Hit = value;
				this.X12Y0_呪印_鎖1.Hit = value;
				this.X13Y0_呪印_鎖1.Hit = value;
				this.X14Y0_呪印_鎖1.Hit = value;
				this.X14Y1_呪印_鎖1.Hit = value;
				this.X14Y2_呪印_鎖1.Hit = value;
			}
		}

		public bool 呪印_鎖2_表示
		{
			get
			{
				return this.X0Y0_呪印_鎖2.Dra;
			}
			set
			{
				this.X0Y0_呪印_鎖2.Dra = value;
				this.X1Y0_呪印_鎖2.Dra = value;
				this.X2Y0_呪印_鎖2.Dra = value;
				this.X2Y1_呪印_鎖2.Dra = value;
				this.X2Y2_呪印_鎖2.Dra = value;
				this.X2Y3_呪印_鎖2.Dra = value;
				this.X2Y4_呪印_鎖2.Dra = value;
				this.X3Y0_呪印_鎖2.Dra = value;
				this.X4Y0_呪印_鎖2.Dra = value;
				this.X5Y0_呪印_鎖2.Dra = value;
				this.X5Y1_呪印_鎖2.Dra = value;
				this.X5Y2_呪印_鎖2.Dra = value;
				this.X5Y3_呪印_鎖2.Dra = value;
				this.X5Y4_呪印_鎖2.Dra = value;
				this.X6Y0_呪印_鎖2.Dra = value;
				this.X6Y1_呪印_鎖2.Dra = value;
				this.X6Y2_呪印_鎖2.Dra = value;
				this.X6Y3_呪印_鎖2.Dra = value;
				this.X6Y4_呪印_鎖2.Dra = value;
				this.X7Y0_呪印_鎖2.Dra = value;
				this.X7Y1_呪印_鎖2.Dra = value;
				this.X7Y2_呪印_鎖2.Dra = value;
				this.X7Y3_呪印_鎖2.Dra = value;
				this.X7Y4_呪印_鎖2.Dra = value;
				this.X10Y0_呪印_鎖2.Dra = value;
				this.X10Y1_呪印_鎖2.Dra = value;
				this.X10Y2_呪印_鎖2.Dra = value;
				this.X10Y3_呪印_鎖2.Dra = value;
				this.X10Y4_呪印_鎖2.Dra = value;
				this.X12Y0_呪印_鎖2.Dra = value;
				this.X14Y0_呪印_鎖2.Dra = value;
				this.X14Y1_呪印_鎖2.Dra = value;
				this.X14Y2_呪印_鎖2.Dra = value;
				this.X0Y0_呪印_鎖2.Hit = value;
				this.X1Y0_呪印_鎖2.Hit = value;
				this.X2Y0_呪印_鎖2.Hit = value;
				this.X2Y1_呪印_鎖2.Hit = value;
				this.X2Y2_呪印_鎖2.Hit = value;
				this.X2Y3_呪印_鎖2.Hit = value;
				this.X2Y4_呪印_鎖2.Hit = value;
				this.X3Y0_呪印_鎖2.Hit = value;
				this.X4Y0_呪印_鎖2.Hit = value;
				this.X5Y0_呪印_鎖2.Hit = value;
				this.X5Y1_呪印_鎖2.Hit = value;
				this.X5Y2_呪印_鎖2.Hit = value;
				this.X5Y3_呪印_鎖2.Hit = value;
				this.X5Y4_呪印_鎖2.Hit = value;
				this.X6Y0_呪印_鎖2.Hit = value;
				this.X6Y1_呪印_鎖2.Hit = value;
				this.X6Y2_呪印_鎖2.Hit = value;
				this.X6Y3_呪印_鎖2.Hit = value;
				this.X6Y4_呪印_鎖2.Hit = value;
				this.X7Y0_呪印_鎖2.Hit = value;
				this.X7Y1_呪印_鎖2.Hit = value;
				this.X7Y2_呪印_鎖2.Hit = value;
				this.X7Y3_呪印_鎖2.Hit = value;
				this.X7Y4_呪印_鎖2.Hit = value;
				this.X10Y0_呪印_鎖2.Hit = value;
				this.X10Y1_呪印_鎖2.Hit = value;
				this.X10Y2_呪印_鎖2.Hit = value;
				this.X10Y3_呪印_鎖2.Hit = value;
				this.X10Y4_呪印_鎖2.Hit = value;
				this.X12Y0_呪印_鎖2.Hit = value;
				this.X14Y0_呪印_鎖2.Hit = value;
				this.X14Y1_呪印_鎖2.Hit = value;
				this.X14Y2_呪印_鎖2.Hit = value;
			}
		}

		public bool 呪印_鎖3_表示
		{
			get
			{
				return this.X0Y0_呪印_鎖3.Dra;
			}
			set
			{
				this.X0Y0_呪印_鎖3.Dra = value;
				this.X1Y0_呪印_鎖3.Dra = value;
				this.X2Y0_呪印_鎖3.Dra = value;
				this.X2Y1_呪印_鎖3.Dra = value;
				this.X2Y2_呪印_鎖3.Dra = value;
				this.X2Y3_呪印_鎖3.Dra = value;
				this.X2Y4_呪印_鎖3.Dra = value;
				this.X3Y0_呪印_鎖3.Dra = value;
				this.X4Y0_呪印_鎖3.Dra = value;
				this.X5Y0_呪印_鎖3.Dra = value;
				this.X5Y1_呪印_鎖3.Dra = value;
				this.X5Y2_呪印_鎖3.Dra = value;
				this.X5Y3_呪印_鎖3.Dra = value;
				this.X5Y4_呪印_鎖3.Dra = value;
				this.X6Y0_呪印_鎖3.Dra = value;
				this.X6Y1_呪印_鎖3.Dra = value;
				this.X6Y2_呪印_鎖3.Dra = value;
				this.X6Y3_呪印_鎖3.Dra = value;
				this.X6Y4_呪印_鎖3.Dra = value;
				this.X7Y0_呪印_鎖3.Dra = value;
				this.X7Y1_呪印_鎖3.Dra = value;
				this.X7Y2_呪印_鎖3.Dra = value;
				this.X7Y3_呪印_鎖3.Dra = value;
				this.X7Y4_呪印_鎖3.Dra = value;
				this.X10Y0_呪印_鎖3.Dra = value;
				this.X10Y1_呪印_鎖3.Dra = value;
				this.X10Y2_呪印_鎖3.Dra = value;
				this.X10Y3_呪印_鎖3.Dra = value;
				this.X10Y4_呪印_鎖3.Dra = value;
				this.X11Y0_呪印_鎖3.Dra = value;
				this.X12Y0_呪印_鎖3.Dra = value;
				this.X13Y0_呪印_鎖3.Dra = value;
				this.X14Y0_呪印_鎖3.Dra = value;
				this.X14Y1_呪印_鎖3.Dra = value;
				this.X14Y2_呪印_鎖3.Dra = value;
				this.X0Y0_呪印_鎖3.Hit = value;
				this.X1Y0_呪印_鎖3.Hit = value;
				this.X2Y0_呪印_鎖3.Hit = value;
				this.X2Y1_呪印_鎖3.Hit = value;
				this.X2Y2_呪印_鎖3.Hit = value;
				this.X2Y3_呪印_鎖3.Hit = value;
				this.X2Y4_呪印_鎖3.Hit = value;
				this.X3Y0_呪印_鎖3.Hit = value;
				this.X4Y0_呪印_鎖3.Hit = value;
				this.X5Y0_呪印_鎖3.Hit = value;
				this.X5Y1_呪印_鎖3.Hit = value;
				this.X5Y2_呪印_鎖3.Hit = value;
				this.X5Y3_呪印_鎖3.Hit = value;
				this.X5Y4_呪印_鎖3.Hit = value;
				this.X6Y0_呪印_鎖3.Hit = value;
				this.X6Y1_呪印_鎖3.Hit = value;
				this.X6Y2_呪印_鎖3.Hit = value;
				this.X6Y3_呪印_鎖3.Hit = value;
				this.X6Y4_呪印_鎖3.Hit = value;
				this.X7Y0_呪印_鎖3.Hit = value;
				this.X7Y1_呪印_鎖3.Hit = value;
				this.X7Y2_呪印_鎖3.Hit = value;
				this.X7Y3_呪印_鎖3.Hit = value;
				this.X7Y4_呪印_鎖3.Hit = value;
				this.X10Y0_呪印_鎖3.Hit = value;
				this.X10Y1_呪印_鎖3.Hit = value;
				this.X10Y2_呪印_鎖3.Hit = value;
				this.X10Y3_呪印_鎖3.Hit = value;
				this.X10Y4_呪印_鎖3.Hit = value;
				this.X11Y0_呪印_鎖3.Hit = value;
				this.X12Y0_呪印_鎖3.Hit = value;
				this.X13Y0_呪印_鎖3.Hit = value;
				this.X14Y0_呪印_鎖3.Hit = value;
				this.X14Y1_呪印_鎖3.Hit = value;
				this.X14Y2_呪印_鎖3.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.親指_表示;
			}
			set
			{
				this.親指_表示 = value;
				this.手_表示 = value;
				this.小指_表示 = value;
				this.薬指_表示 = value;
				this.中指_表示 = value;
				this.人指_表示 = value;
				this.呪印_輪1_輪外_表示 = value;
				this.呪印_輪1_輪内_表示 = value;
				this.呪印_輪2_輪外_表示 = value;
				this.呪印_輪2_輪内_表示 = value;
				this.呪印_輪3_輪外_表示 = value;
				this.呪印_輪3_輪内_表示 = value;
				this.呪印_鎖1_表示 = value;
				this.呪印_鎖2_表示 = value;
				this.呪印_鎖3_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.親指CD.不透明度;
			}
			set
			{
				this.親指CD.不透明度 = value;
				this.手CD.不透明度 = value;
				this.小指CD.不透明度 = value;
				this.薬指CD.不透明度 = value;
				this.中指CD.不透明度 = value;
				this.人指CD.不透明度 = value;
				this.呪印_輪1_輪外CD.不透明度 = value;
				this.呪印_輪1_輪内CD.不透明度 = value;
				this.呪印_輪2_輪外CD.不透明度 = value;
				this.呪印_輪2_輪内CD.不透明度 = value;
				this.呪印_輪3_輪外CD.不透明度 = value;
				this.呪印_輪3_輪内CD.不透明度 = value;
				this.呪印_鎖1CD.不透明度 = value;
				this.呪印_鎖2CD.不透明度 = value;
				this.呪印_鎖3CD.不透明度 = value;
			}
		}

		public override void 描画0(Are Are)
		{
			switch (this.本体.IndexX)
			{
			case 0:
				Are.Draw(this.X0Y0_親指);
				Are.Draw(this.X0Y0_手);
				Are.Draw(this.X0Y0_小指);
				Are.Draw(this.X0Y0_薬指);
				Are.Draw(this.X0Y0_中指);
				Are.Draw(this.X0Y0_人指);
				Are.Draw(this.X0Y0_呪印_輪1_輪外);
				Are.Draw(this.X0Y0_呪印_輪1_輪内);
				Are.Draw(this.X0Y0_呪印_輪2_輪外);
				Are.Draw(this.X0Y0_呪印_輪2_輪内);
				Are.Draw(this.X0Y0_呪印_輪3_輪外);
				Are.Draw(this.X0Y0_呪印_輪3_輪内);
				Are.Draw(this.X0Y0_呪印_鎖1);
				Are.Draw(this.X0Y0_呪印_鎖2);
				Are.Draw(this.X0Y0_呪印_鎖3);
				return;
			case 1:
				Are.Draw(this.X1Y0_親指);
				Are.Draw(this.X1Y0_手);
				Are.Draw(this.X1Y0_小指);
				Are.Draw(this.X1Y0_薬指);
				Are.Draw(this.X1Y0_中指);
				Are.Draw(this.X1Y0_人指);
				Are.Draw(this.X1Y0_呪印_輪1_輪外);
				Are.Draw(this.X1Y0_呪印_輪1_輪内);
				Are.Draw(this.X1Y0_呪印_輪2_輪外);
				Are.Draw(this.X1Y0_呪印_輪2_輪内);
				Are.Draw(this.X1Y0_呪印_輪3_輪外);
				Are.Draw(this.X1Y0_呪印_輪3_輪内);
				Are.Draw(this.X1Y0_呪印_鎖1);
				Are.Draw(this.X1Y0_呪印_鎖2);
				Are.Draw(this.X1Y0_呪印_鎖3);
				return;
			case 2:
				switch (this.本体.IndexY)
				{
				case 0:
					Are.Draw(this.X2Y0_親指);
					Are.Draw(this.X2Y0_手);
					Are.Draw(this.X2Y0_小指);
					Are.Draw(this.X2Y0_薬指);
					Are.Draw(this.X2Y0_中指);
					Are.Draw(this.X2Y0_人指);
					Are.Draw(this.X2Y0_呪印_輪1_輪外);
					Are.Draw(this.X2Y0_呪印_輪1_輪内);
					Are.Draw(this.X2Y0_呪印_輪2_輪外);
					Are.Draw(this.X2Y0_呪印_輪2_輪内);
					Are.Draw(this.X2Y0_呪印_輪3_輪外);
					Are.Draw(this.X2Y0_呪印_輪3_輪内);
					Are.Draw(this.X2Y0_呪印_鎖1);
					Are.Draw(this.X2Y0_呪印_鎖2);
					Are.Draw(this.X2Y0_呪印_鎖3);
					return;
				case 1:
					Are.Draw(this.X2Y1_親指);
					Are.Draw(this.X2Y1_手);
					Are.Draw(this.X2Y1_小指);
					Are.Draw(this.X2Y1_薬指);
					Are.Draw(this.X2Y1_中指);
					Are.Draw(this.X2Y1_人指);
					Are.Draw(this.X2Y1_呪印_輪1_輪外);
					Are.Draw(this.X2Y1_呪印_輪1_輪内);
					Are.Draw(this.X2Y1_呪印_輪2_輪外);
					Are.Draw(this.X2Y1_呪印_輪2_輪内);
					Are.Draw(this.X2Y1_呪印_輪3_輪外);
					Are.Draw(this.X2Y1_呪印_輪3_輪内);
					Are.Draw(this.X2Y1_呪印_鎖1);
					Are.Draw(this.X2Y1_呪印_鎖2);
					Are.Draw(this.X2Y1_呪印_鎖3);
					return;
				case 2:
					Are.Draw(this.X2Y2_親指);
					Are.Draw(this.X2Y2_手);
					Are.Draw(this.X2Y2_小指);
					Are.Draw(this.X2Y2_薬指);
					Are.Draw(this.X2Y2_中指);
					Are.Draw(this.X2Y2_人指);
					Are.Draw(this.X2Y2_呪印_輪1_輪外);
					Are.Draw(this.X2Y2_呪印_輪1_輪内);
					Are.Draw(this.X2Y2_呪印_輪2_輪外);
					Are.Draw(this.X2Y2_呪印_輪2_輪内);
					Are.Draw(this.X2Y2_呪印_輪3_輪外);
					Are.Draw(this.X2Y2_呪印_輪3_輪内);
					Are.Draw(this.X2Y2_呪印_鎖1);
					Are.Draw(this.X2Y2_呪印_鎖2);
					Are.Draw(this.X2Y2_呪印_鎖3);
					return;
				case 3:
					Are.Draw(this.X2Y3_親指);
					Are.Draw(this.X2Y3_手);
					Are.Draw(this.X2Y3_小指);
					Are.Draw(this.X2Y3_薬指);
					Are.Draw(this.X2Y3_中指);
					Are.Draw(this.X2Y3_人指);
					Are.Draw(this.X2Y3_呪印_輪1_輪外);
					Are.Draw(this.X2Y3_呪印_輪1_輪内);
					Are.Draw(this.X2Y3_呪印_輪2_輪外);
					Are.Draw(this.X2Y3_呪印_輪2_輪内);
					Are.Draw(this.X2Y3_呪印_輪3_輪外);
					Are.Draw(this.X2Y3_呪印_輪3_輪内);
					Are.Draw(this.X2Y3_呪印_鎖1);
					Are.Draw(this.X2Y3_呪印_鎖2);
					Are.Draw(this.X2Y3_呪印_鎖3);
					return;
				default:
					Are.Draw(this.X2Y4_親指);
					Are.Draw(this.X2Y4_手);
					Are.Draw(this.X2Y4_小指);
					Are.Draw(this.X2Y4_薬指);
					Are.Draw(this.X2Y4_中指);
					Are.Draw(this.X2Y4_人指);
					Are.Draw(this.X2Y4_呪印_輪1_輪外);
					Are.Draw(this.X2Y4_呪印_輪1_輪内);
					Are.Draw(this.X2Y4_呪印_輪2_輪外);
					Are.Draw(this.X2Y4_呪印_輪2_輪内);
					Are.Draw(this.X2Y4_呪印_輪3_輪外);
					Are.Draw(this.X2Y4_呪印_輪3_輪内);
					Are.Draw(this.X2Y4_呪印_鎖1);
					Are.Draw(this.X2Y4_呪印_鎖2);
					Are.Draw(this.X2Y4_呪印_鎖3);
					return;
				}
				break;
			case 3:
				Are.Draw(this.X3Y0_親指);
				Are.Draw(this.X3Y0_手);
				Are.Draw(this.X3Y0_小指);
				Are.Draw(this.X3Y0_薬指);
				Are.Draw(this.X3Y0_中指);
				Are.Draw(this.X3Y0_人指);
				Are.Draw(this.X3Y0_呪印_輪1_輪外);
				Are.Draw(this.X3Y0_呪印_輪1_輪内);
				Are.Draw(this.X3Y0_呪印_輪2_輪外);
				Are.Draw(this.X3Y0_呪印_輪2_輪内);
				Are.Draw(this.X3Y0_呪印_輪3_輪外);
				Are.Draw(this.X3Y0_呪印_輪3_輪内);
				Are.Draw(this.X3Y0_呪印_鎖1);
				Are.Draw(this.X3Y0_呪印_鎖2);
				Are.Draw(this.X3Y0_呪印_鎖3);
				return;
			case 4:
				Are.Draw(this.X4Y0_親指);
				Are.Draw(this.X4Y0_手);
				Are.Draw(this.X4Y0_小指);
				Are.Draw(this.X4Y0_薬指);
				Are.Draw(this.X4Y0_中指);
				Are.Draw(this.X4Y0_人指);
				Are.Draw(this.X4Y0_呪印_輪1_輪外);
				Are.Draw(this.X4Y0_呪印_輪1_輪内);
				Are.Draw(this.X4Y0_呪印_輪2_輪外);
				Are.Draw(this.X4Y0_呪印_輪2_輪内);
				Are.Draw(this.X4Y0_呪印_輪3_輪外);
				Are.Draw(this.X4Y0_呪印_輪3_輪内);
				Are.Draw(this.X4Y0_呪印_鎖1);
				Are.Draw(this.X4Y0_呪印_鎖2);
				Are.Draw(this.X4Y0_呪印_鎖3);
				return;
			case 5:
				switch (this.本体.IndexY)
				{
				case 0:
					Are.Draw(this.X5Y0_親指);
					Are.Draw(this.X5Y0_手);
					Are.Draw(this.X5Y0_小指);
					Are.Draw(this.X5Y0_薬指);
					Are.Draw(this.X5Y0_中指);
					Are.Draw(this.X5Y0_人指);
					Are.Draw(this.X5Y0_呪印_輪1_輪外);
					Are.Draw(this.X5Y0_呪印_輪1_輪内);
					Are.Draw(this.X5Y0_呪印_輪2_輪外);
					Are.Draw(this.X5Y0_呪印_輪2_輪内);
					Are.Draw(this.X5Y0_呪印_輪3_輪外);
					Are.Draw(this.X5Y0_呪印_輪3_輪内);
					Are.Draw(this.X5Y0_呪印_鎖1);
					Are.Draw(this.X5Y0_呪印_鎖2);
					Are.Draw(this.X5Y0_呪印_鎖3);
					return;
				case 1:
					Are.Draw(this.X5Y1_親指);
					Are.Draw(this.X5Y1_手);
					Are.Draw(this.X5Y1_小指);
					Are.Draw(this.X5Y1_薬指);
					Are.Draw(this.X5Y1_中指);
					Are.Draw(this.X5Y1_人指);
					Are.Draw(this.X5Y1_呪印_輪1_輪外);
					Are.Draw(this.X5Y1_呪印_輪1_輪内);
					Are.Draw(this.X5Y1_呪印_輪2_輪外);
					Are.Draw(this.X5Y1_呪印_輪2_輪内);
					Are.Draw(this.X5Y1_呪印_輪3_輪外);
					Are.Draw(this.X5Y1_呪印_輪3_輪内);
					Are.Draw(this.X5Y1_呪印_鎖1);
					Are.Draw(this.X5Y1_呪印_鎖2);
					Are.Draw(this.X5Y1_呪印_鎖3);
					return;
				case 2:
					Are.Draw(this.X5Y2_親指);
					Are.Draw(this.X5Y2_手);
					Are.Draw(this.X5Y2_小指);
					Are.Draw(this.X5Y2_薬指);
					Are.Draw(this.X5Y2_中指);
					Are.Draw(this.X5Y2_人指);
					Are.Draw(this.X5Y2_呪印_輪1_輪外);
					Are.Draw(this.X5Y2_呪印_輪1_輪内);
					Are.Draw(this.X5Y2_呪印_輪2_輪外);
					Are.Draw(this.X5Y2_呪印_輪2_輪内);
					Are.Draw(this.X5Y2_呪印_輪3_輪外);
					Are.Draw(this.X5Y2_呪印_輪3_輪内);
					Are.Draw(this.X5Y2_呪印_鎖1);
					Are.Draw(this.X5Y2_呪印_鎖2);
					Are.Draw(this.X5Y2_呪印_鎖3);
					return;
				case 3:
					Are.Draw(this.X5Y3_親指);
					Are.Draw(this.X5Y3_手);
					Are.Draw(this.X5Y3_小指);
					Are.Draw(this.X5Y3_薬指);
					Are.Draw(this.X5Y3_中指);
					Are.Draw(this.X5Y3_人指);
					Are.Draw(this.X5Y3_呪印_輪1_輪外);
					Are.Draw(this.X5Y3_呪印_輪1_輪内);
					Are.Draw(this.X5Y3_呪印_輪2_輪外);
					Are.Draw(this.X5Y3_呪印_輪2_輪内);
					Are.Draw(this.X5Y3_呪印_輪3_輪外);
					Are.Draw(this.X5Y3_呪印_輪3_輪内);
					Are.Draw(this.X5Y3_呪印_鎖1);
					Are.Draw(this.X5Y3_呪印_鎖2);
					Are.Draw(this.X5Y3_呪印_鎖3);
					return;
				default:
					Are.Draw(this.X5Y4_親指);
					Are.Draw(this.X5Y4_手);
					Are.Draw(this.X5Y4_小指);
					Are.Draw(this.X5Y4_薬指);
					Are.Draw(this.X5Y4_中指);
					Are.Draw(this.X5Y4_人指);
					Are.Draw(this.X5Y4_呪印_輪1_輪外);
					Are.Draw(this.X5Y4_呪印_輪1_輪内);
					Are.Draw(this.X5Y4_呪印_輪2_輪外);
					Are.Draw(this.X5Y4_呪印_輪2_輪内);
					Are.Draw(this.X5Y4_呪印_輪3_輪外);
					Are.Draw(this.X5Y4_呪印_輪3_輪内);
					Are.Draw(this.X5Y4_呪印_鎖1);
					Are.Draw(this.X5Y4_呪印_鎖2);
					Are.Draw(this.X5Y4_呪印_鎖3);
					return;
				}
				break;
			case 6:
				switch (this.本体.IndexY)
				{
				case 0:
					Are.Draw(this.X6Y0_人指);
					return;
				case 1:
					Are.Draw(this.X6Y1_人指);
					return;
				case 2:
					Are.Draw(this.X6Y2_人指);
					return;
				case 3:
					Are.Draw(this.X6Y3_人指);
					return;
				default:
					Are.Draw(this.X6Y4_人指);
					return;
				}
				break;
			case 7:
				switch (this.本体.IndexY)
				{
				case 0:
					Are.Draw(this.X7Y0_人指);
					return;
				case 1:
					Are.Draw(this.X7Y1_人指);
					return;
				case 2:
					Are.Draw(this.X7Y2_人指);
					return;
				case 3:
					Are.Draw(this.X7Y3_人指);
					return;
				default:
					Are.Draw(this.X7Y4_人指);
					return;
				}
				break;
			case 8:
				switch (this.本体.IndexY)
				{
				case 0:
					Are.Draw(this.X8Y0_薬指);
					Are.Draw(this.X8Y0_中指);
					return;
				case 1:
					Are.Draw(this.X8Y1_薬指);
					Are.Draw(this.X8Y1_中指);
					return;
				case 2:
					Are.Draw(this.X8Y2_薬指);
					Are.Draw(this.X8Y2_中指);
					return;
				case 3:
					Are.Draw(this.X8Y3_薬指);
					Are.Draw(this.X8Y3_中指);
					return;
				default:
					Are.Draw(this.X8Y4_薬指);
					Are.Draw(this.X8Y4_中指);
					return;
				}
				break;
			case 9:
				switch (this.本体.IndexY)
				{
				case 0:
					Are.Draw(this.X9Y0_手);
					Are.Draw(this.X9Y0_小指);
					Are.Draw(this.X9Y0_薬指);
					Are.Draw(this.X9Y0_中指);
					Are.Draw(this.X9Y0_人指);
					Are.Draw(this.X9Y0_親指);
					return;
				case 1:
					Are.Draw(this.X9Y1_手);
					Are.Draw(this.X9Y1_小指);
					Are.Draw(this.X9Y1_薬指);
					Are.Draw(this.X9Y1_中指);
					Are.Draw(this.X9Y1_人指);
					Are.Draw(this.X9Y1_親指);
					return;
				case 2:
					Are.Draw(this.X9Y2_手);
					Are.Draw(this.X9Y2_小指);
					Are.Draw(this.X9Y2_薬指);
					Are.Draw(this.X9Y2_中指);
					Are.Draw(this.X9Y2_人指);
					Are.Draw(this.X9Y2_親指);
					return;
				case 3:
					Are.Draw(this.X9Y3_手);
					Are.Draw(this.X9Y3_小指);
					Are.Draw(this.X9Y3_薬指);
					Are.Draw(this.X9Y3_中指);
					Are.Draw(this.X9Y3_人指);
					Are.Draw(this.X9Y3_親指);
					return;
				default:
					Are.Draw(this.X9Y4_手);
					Are.Draw(this.X9Y4_小指);
					Are.Draw(this.X9Y4_薬指);
					Are.Draw(this.X9Y4_中指);
					Are.Draw(this.X9Y4_人指);
					Are.Draw(this.X9Y4_親指);
					return;
				}
				break;
			case 10:
				switch (this.本体.IndexY)
				{
				case 0:
					Are.Draw(this.X10Y0_親指);
					Are.Draw(this.X10Y0_手);
					Are.Draw(this.X10Y0_小指);
					Are.Draw(this.X10Y0_薬指);
					Are.Draw(this.X10Y0_中指);
					Are.Draw(this.X10Y0_人指);
					Are.Draw(this.X10Y0_呪印_輪1_輪外);
					Are.Draw(this.X10Y0_呪印_輪1_輪内);
					Are.Draw(this.X10Y0_呪印_輪2_輪外);
					Are.Draw(this.X10Y0_呪印_輪2_輪内);
					Are.Draw(this.X10Y0_呪印_輪3_輪外);
					Are.Draw(this.X10Y0_呪印_輪3_輪内);
					Are.Draw(this.X10Y0_呪印_鎖1);
					Are.Draw(this.X10Y0_呪印_鎖2);
					Are.Draw(this.X10Y0_呪印_鎖3);
					return;
				case 1:
					Are.Draw(this.X10Y1_親指);
					Are.Draw(this.X10Y1_手);
					Are.Draw(this.X10Y1_小指);
					Are.Draw(this.X10Y1_薬指);
					Are.Draw(this.X10Y1_中指);
					Are.Draw(this.X10Y1_人指);
					Are.Draw(this.X10Y1_呪印_輪1_輪外);
					Are.Draw(this.X10Y1_呪印_輪1_輪内);
					Are.Draw(this.X10Y1_呪印_輪2_輪外);
					Are.Draw(this.X10Y1_呪印_輪2_輪内);
					Are.Draw(this.X10Y1_呪印_輪3_輪外);
					Are.Draw(this.X10Y1_呪印_輪3_輪内);
					Are.Draw(this.X10Y1_呪印_鎖1);
					Are.Draw(this.X10Y1_呪印_鎖2);
					Are.Draw(this.X10Y1_呪印_鎖3);
					return;
				case 2:
					Are.Draw(this.X10Y2_親指);
					Are.Draw(this.X10Y2_手);
					Are.Draw(this.X10Y2_小指);
					Are.Draw(this.X10Y2_薬指);
					Are.Draw(this.X10Y2_中指);
					Are.Draw(this.X10Y2_人指);
					Are.Draw(this.X10Y2_呪印_輪1_輪外);
					Are.Draw(this.X10Y2_呪印_輪1_輪内);
					Are.Draw(this.X10Y2_呪印_輪2_輪外);
					Are.Draw(this.X10Y2_呪印_輪2_輪内);
					Are.Draw(this.X10Y2_呪印_輪3_輪外);
					Are.Draw(this.X10Y2_呪印_輪3_輪内);
					Are.Draw(this.X10Y2_呪印_鎖1);
					Are.Draw(this.X10Y2_呪印_鎖2);
					Are.Draw(this.X10Y2_呪印_鎖3);
					return;
				case 3:
					Are.Draw(this.X10Y3_親指);
					Are.Draw(this.X10Y3_手);
					Are.Draw(this.X10Y3_小指);
					Are.Draw(this.X10Y3_薬指);
					Are.Draw(this.X10Y3_中指);
					Are.Draw(this.X10Y3_人指);
					Are.Draw(this.X10Y3_呪印_輪1_輪外);
					Are.Draw(this.X10Y3_呪印_輪1_輪内);
					Are.Draw(this.X10Y3_呪印_輪2_輪外);
					Are.Draw(this.X10Y3_呪印_輪2_輪内);
					Are.Draw(this.X10Y3_呪印_輪3_輪外);
					Are.Draw(this.X10Y3_呪印_輪3_輪内);
					Are.Draw(this.X10Y3_呪印_鎖1);
					Are.Draw(this.X10Y3_呪印_鎖2);
					Are.Draw(this.X10Y3_呪印_鎖3);
					return;
				default:
					Are.Draw(this.X10Y4_親指);
					Are.Draw(this.X10Y4_手);
					Are.Draw(this.X10Y4_小指);
					Are.Draw(this.X10Y4_薬指);
					Are.Draw(this.X10Y4_中指);
					Are.Draw(this.X10Y4_人指);
					Are.Draw(this.X10Y4_呪印_輪1_輪外);
					Are.Draw(this.X10Y4_呪印_輪1_輪内);
					Are.Draw(this.X10Y4_呪印_輪2_輪外);
					Are.Draw(this.X10Y4_呪印_輪2_輪内);
					Are.Draw(this.X10Y4_呪印_輪3_輪外);
					Are.Draw(this.X10Y4_呪印_輪3_輪内);
					Are.Draw(this.X10Y4_呪印_鎖1);
					Are.Draw(this.X10Y4_呪印_鎖2);
					Are.Draw(this.X10Y4_呪印_鎖3);
					return;
				}
				break;
			case 11:
				Are.Draw(this.X11Y0_小指);
				Are.Draw(this.X11Y0_薬指);
				Are.Draw(this.X11Y0_中指);
				Are.Draw(this.X11Y0_人指);
				Are.Draw(this.X11Y0_手);
				Are.Draw(this.X11Y0_親指);
				Are.Draw(this.X11Y0_呪印_輪1_輪外);
				Are.Draw(this.X11Y0_呪印_輪1_輪内);
				Are.Draw(this.X11Y0_呪印_輪2_輪外);
				Are.Draw(this.X11Y0_呪印_輪2_輪内);
				Are.Draw(this.X11Y0_呪印_輪3_輪外);
				Are.Draw(this.X11Y0_呪印_輪3_輪内);
				Are.Draw(this.X11Y0_呪印_鎖1);
				Are.Draw(this.X11Y0_呪印_鎖3);
				return;
			case 12:
				Are.Draw(this.X12Y0_親指);
				Are.Draw(this.X12Y0_手);
				Are.Draw(this.X12Y0_小指);
				Are.Draw(this.X12Y0_薬指);
				Are.Draw(this.X12Y0_中指);
				Are.Draw(this.X12Y0_人指);
				Are.Draw(this.X12Y0_呪印_輪1_輪外);
				Are.Draw(this.X12Y0_呪印_輪1_輪内);
				Are.Draw(this.X12Y0_呪印_輪2_輪外);
				Are.Draw(this.X12Y0_呪印_輪2_輪内);
				Are.Draw(this.X12Y0_呪印_輪3_輪外);
				Are.Draw(this.X12Y0_呪印_輪3_輪内);
				Are.Draw(this.X12Y0_呪印_鎖1);
				Are.Draw(this.X12Y0_呪印_鎖2);
				Are.Draw(this.X12Y0_呪印_鎖3);
				return;
			case 13:
				Are.Draw(this.X13Y0_中指);
				Are.Draw(this.X13Y0_人指);
				Are.Draw(this.X13Y0_手);
				Are.Draw(this.X13Y0_親指);
				Are.Draw(this.X13Y0_呪印_輪1_輪外);
				Are.Draw(this.X13Y0_呪印_輪1_輪内);
				Are.Draw(this.X13Y0_呪印_輪2_輪外);
				Are.Draw(this.X13Y0_呪印_輪2_輪内);
				Are.Draw(this.X13Y0_呪印_輪3_輪外);
				Are.Draw(this.X13Y0_呪印_輪3_輪内);
				Are.Draw(this.X13Y0_呪印_鎖1);
				Are.Draw(this.X13Y0_呪印_鎖3);
				return;
			default:
			{
				int indexY = this.本体.IndexY;
				if (indexY == 0)
				{
					Are.Draw(this.X14Y0_親指);
					Are.Draw(this.X14Y0_手);
					Are.Draw(this.X14Y0_小指);
					Are.Draw(this.X14Y0_薬指);
					Are.Draw(this.X14Y0_中指);
					Are.Draw(this.X14Y0_人指);
					Are.Draw(this.X14Y0_呪印_輪1_輪外);
					Are.Draw(this.X14Y0_呪印_輪1_輪内);
					Are.Draw(this.X14Y0_呪印_輪2_輪外);
					Are.Draw(this.X14Y0_呪印_輪2_輪内);
					Are.Draw(this.X14Y0_呪印_輪3_輪外);
					Are.Draw(this.X14Y0_呪印_輪3_輪内);
					Are.Draw(this.X14Y0_呪印_鎖1);
					Are.Draw(this.X14Y0_呪印_鎖2);
					Are.Draw(this.X14Y0_呪印_鎖3);
					return;
				}
				if (indexY != 1)
				{
					Are.Draw(this.X14Y2_親指);
					Are.Draw(this.X14Y2_手);
					Are.Draw(this.X14Y2_小指);
					Are.Draw(this.X14Y2_薬指);
					Are.Draw(this.X14Y2_中指);
					Are.Draw(this.X14Y2_人指);
					Are.Draw(this.X14Y2_呪印_輪1_輪外);
					Are.Draw(this.X14Y2_呪印_輪1_輪内);
					Are.Draw(this.X14Y2_呪印_輪2_輪外);
					Are.Draw(this.X14Y2_呪印_輪2_輪内);
					Are.Draw(this.X14Y2_呪印_輪3_輪外);
					Are.Draw(this.X14Y2_呪印_輪3_輪内);
					Are.Draw(this.X14Y2_呪印_鎖1);
					Are.Draw(this.X14Y2_呪印_鎖2);
					Are.Draw(this.X14Y2_呪印_鎖3);
					return;
				}
				Are.Draw(this.X14Y1_親指);
				Are.Draw(this.X14Y1_手);
				Are.Draw(this.X14Y1_小指);
				Are.Draw(this.X14Y1_薬指);
				Are.Draw(this.X14Y1_中指);
				Are.Draw(this.X14Y1_人指);
				Are.Draw(this.X14Y1_呪印_輪1_輪外);
				Are.Draw(this.X14Y1_呪印_輪1_輪内);
				Are.Draw(this.X14Y1_呪印_輪2_輪外);
				Are.Draw(this.X14Y1_呪印_輪2_輪内);
				Are.Draw(this.X14Y1_呪印_輪3_輪外);
				Are.Draw(this.X14Y1_呪印_輪3_輪内);
				Are.Draw(this.X14Y1_呪印_鎖1);
				Are.Draw(this.X14Y1_呪印_鎖2);
				Are.Draw(this.X14Y1_呪印_鎖3);
				return;
			}
			}
		}

		public override void 描画1(Are Are)
		{
			switch (this.本体.IndexX)
			{
			case 6:
				switch (this.本体.IndexY)
				{
				case 0:
					Are.Draw(this.X6Y0_親指);
					Are.Draw(this.X6Y0_手);
					Are.Draw(this.X6Y0_小指);
					Are.Draw(this.X6Y0_薬指);
					Are.Draw(this.X6Y0_中指);
					Are.Draw(this.X6Y0_呪印_輪1_輪外);
					Are.Draw(this.X6Y0_呪印_輪1_輪内);
					Are.Draw(this.X6Y0_呪印_輪2_輪外);
					Are.Draw(this.X6Y0_呪印_輪2_輪内);
					Are.Draw(this.X6Y0_呪印_輪3_輪外);
					Are.Draw(this.X6Y0_呪印_輪3_輪内);
					Are.Draw(this.X6Y0_呪印_鎖1);
					Are.Draw(this.X6Y0_呪印_鎖2);
					Are.Draw(this.X6Y0_呪印_鎖3);
					return;
				case 1:
					Are.Draw(this.X6Y1_親指);
					Are.Draw(this.X6Y1_手);
					Are.Draw(this.X6Y1_小指);
					Are.Draw(this.X6Y1_薬指);
					Are.Draw(this.X6Y1_中指);
					Are.Draw(this.X6Y1_呪印_輪1_輪外);
					Are.Draw(this.X6Y1_呪印_輪1_輪内);
					Are.Draw(this.X6Y1_呪印_輪2_輪外);
					Are.Draw(this.X6Y1_呪印_輪2_輪内);
					Are.Draw(this.X6Y1_呪印_輪3_輪外);
					Are.Draw(this.X6Y1_呪印_輪3_輪内);
					Are.Draw(this.X6Y1_呪印_鎖1);
					Are.Draw(this.X6Y1_呪印_鎖2);
					Are.Draw(this.X6Y1_呪印_鎖3);
					return;
				case 2:
					Are.Draw(this.X6Y2_親指);
					Are.Draw(this.X6Y2_手);
					Are.Draw(this.X6Y2_小指);
					Are.Draw(this.X6Y2_薬指);
					Are.Draw(this.X6Y2_中指);
					Are.Draw(this.X6Y2_呪印_輪1_輪外);
					Are.Draw(this.X6Y2_呪印_輪1_輪内);
					Are.Draw(this.X6Y2_呪印_輪2_輪外);
					Are.Draw(this.X6Y2_呪印_輪2_輪内);
					Are.Draw(this.X6Y2_呪印_輪3_輪外);
					Are.Draw(this.X6Y2_呪印_輪3_輪内);
					Are.Draw(this.X6Y2_呪印_鎖1);
					Are.Draw(this.X6Y2_呪印_鎖2);
					Are.Draw(this.X6Y2_呪印_鎖3);
					return;
				case 3:
					Are.Draw(this.X6Y3_親指);
					Are.Draw(this.X6Y3_手);
					Are.Draw(this.X6Y3_小指);
					Are.Draw(this.X6Y3_薬指);
					Are.Draw(this.X6Y3_中指);
					Are.Draw(this.X6Y3_呪印_輪1_輪外);
					Are.Draw(this.X6Y3_呪印_輪1_輪内);
					Are.Draw(this.X6Y3_呪印_輪2_輪外);
					Are.Draw(this.X6Y3_呪印_輪2_輪内);
					Are.Draw(this.X6Y3_呪印_輪3_輪外);
					Are.Draw(this.X6Y3_呪印_輪3_輪内);
					Are.Draw(this.X6Y3_呪印_鎖1);
					Are.Draw(this.X6Y3_呪印_鎖2);
					Are.Draw(this.X6Y3_呪印_鎖3);
					return;
				default:
					Are.Draw(this.X6Y4_親指);
					Are.Draw(this.X6Y4_手);
					Are.Draw(this.X6Y4_小指);
					Are.Draw(this.X6Y4_薬指);
					Are.Draw(this.X6Y4_中指);
					Are.Draw(this.X6Y4_呪印_輪1_輪外);
					Are.Draw(this.X6Y4_呪印_輪1_輪内);
					Are.Draw(this.X6Y4_呪印_輪2_輪外);
					Are.Draw(this.X6Y4_呪印_輪2_輪内);
					Are.Draw(this.X6Y4_呪印_輪3_輪外);
					Are.Draw(this.X6Y4_呪印_輪3_輪内);
					Are.Draw(this.X6Y4_呪印_鎖1);
					Are.Draw(this.X6Y4_呪印_鎖2);
					Are.Draw(this.X6Y4_呪印_鎖3);
					return;
				}
				break;
			case 7:
				switch (this.本体.IndexY)
				{
				case 0:
					Are.Draw(this.X7Y0_小指);
					Are.Draw(this.X7Y0_薬指);
					Are.Draw(this.X7Y0_中指);
					Are.Draw(this.X7Y0_親指);
					Are.Draw(this.X7Y0_手);
					Are.Draw(this.X7Y0_呪印_輪1_輪外);
					Are.Draw(this.X7Y0_呪印_輪1_輪内);
					Are.Draw(this.X7Y0_呪印_輪2_輪外);
					Are.Draw(this.X7Y0_呪印_輪2_輪内);
					Are.Draw(this.X7Y0_呪印_輪3_輪外);
					Are.Draw(this.X7Y0_呪印_輪3_輪内);
					Are.Draw(this.X7Y0_呪印_鎖1);
					Are.Draw(this.X7Y0_呪印_鎖2);
					Are.Draw(this.X7Y0_呪印_鎖3);
					return;
				case 1:
					Are.Draw(this.X7Y1_小指);
					Are.Draw(this.X7Y1_薬指);
					Are.Draw(this.X7Y1_中指);
					Are.Draw(this.X7Y1_親指);
					Are.Draw(this.X7Y1_手);
					Are.Draw(this.X7Y1_呪印_輪1_輪外);
					Are.Draw(this.X7Y1_呪印_輪1_輪内);
					Are.Draw(this.X7Y1_呪印_輪2_輪外);
					Are.Draw(this.X7Y1_呪印_輪2_輪内);
					Are.Draw(this.X7Y1_呪印_輪3_輪外);
					Are.Draw(this.X7Y1_呪印_輪3_輪内);
					Are.Draw(this.X7Y1_呪印_鎖1);
					Are.Draw(this.X7Y1_呪印_鎖2);
					Are.Draw(this.X7Y1_呪印_鎖3);
					return;
				case 2:
					Are.Draw(this.X7Y2_小指);
					Are.Draw(this.X7Y2_薬指);
					Are.Draw(this.X7Y2_中指);
					Are.Draw(this.X7Y2_親指);
					Are.Draw(this.X7Y2_手);
					Are.Draw(this.X7Y2_呪印_輪1_輪外);
					Are.Draw(this.X7Y2_呪印_輪1_輪内);
					Are.Draw(this.X7Y2_呪印_輪2_輪外);
					Are.Draw(this.X7Y2_呪印_輪2_輪内);
					Are.Draw(this.X7Y2_呪印_輪3_輪外);
					Are.Draw(this.X7Y2_呪印_輪3_輪内);
					Are.Draw(this.X7Y2_呪印_鎖1);
					Are.Draw(this.X7Y2_呪印_鎖2);
					Are.Draw(this.X7Y2_呪印_鎖3);
					return;
				case 3:
					Are.Draw(this.X7Y3_小指);
					Are.Draw(this.X7Y3_薬指);
					Are.Draw(this.X7Y3_中指);
					Are.Draw(this.X7Y3_親指);
					Are.Draw(this.X7Y3_手);
					Are.Draw(this.X7Y3_呪印_輪1_輪外);
					Are.Draw(this.X7Y3_呪印_輪1_輪内);
					Are.Draw(this.X7Y3_呪印_輪2_輪外);
					Are.Draw(this.X7Y3_呪印_輪2_輪内);
					Are.Draw(this.X7Y3_呪印_輪3_輪外);
					Are.Draw(this.X7Y3_呪印_輪3_輪内);
					Are.Draw(this.X7Y3_呪印_鎖1);
					Are.Draw(this.X7Y3_呪印_鎖2);
					Are.Draw(this.X7Y3_呪印_鎖3);
					return;
				default:
					Are.Draw(this.X7Y4_小指);
					Are.Draw(this.X7Y4_薬指);
					Are.Draw(this.X7Y4_中指);
					Are.Draw(this.X7Y4_親指);
					Are.Draw(this.X7Y4_手);
					Are.Draw(this.X7Y4_呪印_輪1_輪外);
					Are.Draw(this.X7Y4_呪印_輪1_輪内);
					Are.Draw(this.X7Y4_呪印_輪2_輪外);
					Are.Draw(this.X7Y4_呪印_輪2_輪内);
					Are.Draw(this.X7Y4_呪印_輪3_輪外);
					Are.Draw(this.X7Y4_呪印_輪3_輪内);
					Are.Draw(this.X7Y4_呪印_鎖1);
					Are.Draw(this.X7Y4_呪印_鎖2);
					Are.Draw(this.X7Y4_呪印_鎖3);
					return;
				}
				break;
			case 8:
				switch (this.本体.IndexY)
				{
				case 0:
					Are.Draw(this.X8Y0_手);
					Are.Draw(this.X8Y0_小指);
					Are.Draw(this.X8Y0_人指);
					Are.Draw(this.X8Y0_親指);
					return;
				case 1:
					Are.Draw(this.X8Y1_手);
					Are.Draw(this.X8Y1_小指);
					Are.Draw(this.X8Y1_人指);
					Are.Draw(this.X8Y1_親指);
					return;
				case 2:
					Are.Draw(this.X8Y2_手);
					Are.Draw(this.X8Y2_小指);
					Are.Draw(this.X8Y2_人指);
					Are.Draw(this.X8Y2_親指);
					return;
				case 3:
					Are.Draw(this.X8Y3_手);
					Are.Draw(this.X8Y3_小指);
					Are.Draw(this.X8Y3_人指);
					Are.Draw(this.X8Y3_親指);
					return;
				default:
					Are.Draw(this.X8Y4_手);
					Are.Draw(this.X8Y4_小指);
					Are.Draw(this.X8Y4_人指);
					Are.Draw(this.X8Y4_親指);
					return;
				}
				break;
			default:
				return;
			}
		}

		public override void 色更新()
		{
			switch (this.本体.IndexX)
			{
			case 0:
				this.X0Y0_親指CP.Update();
				this.X0Y0_手CP.Update();
				this.X0Y0_小指CP.Update();
				this.X0Y0_薬指CP.Update();
				this.X0Y0_中指CP.Update();
				this.X0Y0_人指CP.Update();
				this.X0Y0_呪印_輪1_輪外CP.Update();
				this.X0Y0_呪印_輪1_輪内CP.Update();
				this.X0Y0_呪印_輪2_輪外CP.Update();
				this.X0Y0_呪印_輪2_輪内CP.Update();
				this.X0Y0_呪印_輪3_輪外CP.Update();
				this.X0Y0_呪印_輪3_輪内CP.Update();
				this.X0Y0_呪印_鎖1CP.Update();
				this.X0Y0_呪印_鎖2CP.Update();
				this.X0Y0_呪印_鎖3CP.Update();
				return;
			case 1:
				this.X1Y0_親指CP.Update();
				this.X1Y0_手CP.Update();
				this.X1Y0_小指CP.Update();
				this.X1Y0_薬指CP.Update();
				this.X1Y0_中指CP.Update();
				this.X1Y0_人指CP.Update();
				this.X1Y0_呪印_輪1_輪外CP.Update();
				this.X1Y0_呪印_輪1_輪内CP.Update();
				this.X1Y0_呪印_輪2_輪外CP.Update();
				this.X1Y0_呪印_輪2_輪内CP.Update();
				this.X1Y0_呪印_輪3_輪外CP.Update();
				this.X1Y0_呪印_輪3_輪内CP.Update();
				this.X1Y0_呪印_鎖1CP.Update();
				this.X1Y0_呪印_鎖2CP.Update();
				this.X1Y0_呪印_鎖3CP.Update();
				return;
			case 2:
				switch (this.本体.IndexY)
				{
				case 0:
					this.X2Y0_親指CP.Update();
					this.X2Y0_手CP.Update();
					this.X2Y0_小指CP.Update();
					this.X2Y0_薬指CP.Update();
					this.X2Y0_中指CP.Update();
					this.X2Y0_人指CP.Update();
					this.X2Y0_呪印_輪1_輪外CP.Update();
					this.X2Y0_呪印_輪1_輪内CP.Update();
					this.X2Y0_呪印_輪2_輪外CP.Update();
					this.X2Y0_呪印_輪2_輪内CP.Update();
					this.X2Y0_呪印_輪3_輪外CP.Update();
					this.X2Y0_呪印_輪3_輪内CP.Update();
					this.X2Y0_呪印_鎖1CP.Update();
					this.X2Y0_呪印_鎖2CP.Update();
					this.X2Y0_呪印_鎖3CP.Update();
					return;
				case 1:
					this.X2Y1_親指CP.Update();
					this.X2Y1_手CP.Update();
					this.X2Y1_小指CP.Update();
					this.X2Y1_薬指CP.Update();
					this.X2Y1_中指CP.Update();
					this.X2Y1_人指CP.Update();
					this.X2Y1_呪印_輪1_輪外CP.Update();
					this.X2Y1_呪印_輪1_輪内CP.Update();
					this.X2Y1_呪印_輪2_輪外CP.Update();
					this.X2Y1_呪印_輪2_輪内CP.Update();
					this.X2Y1_呪印_輪3_輪外CP.Update();
					this.X2Y1_呪印_輪3_輪内CP.Update();
					this.X2Y1_呪印_鎖1CP.Update();
					this.X2Y1_呪印_鎖2CP.Update();
					this.X2Y1_呪印_鎖3CP.Update();
					return;
				case 2:
					this.X2Y2_親指CP.Update();
					this.X2Y2_手CP.Update();
					this.X2Y2_小指CP.Update();
					this.X2Y2_薬指CP.Update();
					this.X2Y2_中指CP.Update();
					this.X2Y2_人指CP.Update();
					this.X2Y2_呪印_輪1_輪外CP.Update();
					this.X2Y2_呪印_輪1_輪内CP.Update();
					this.X2Y2_呪印_輪2_輪外CP.Update();
					this.X2Y2_呪印_輪2_輪内CP.Update();
					this.X2Y2_呪印_輪3_輪外CP.Update();
					this.X2Y2_呪印_輪3_輪内CP.Update();
					this.X2Y2_呪印_鎖1CP.Update();
					this.X2Y2_呪印_鎖2CP.Update();
					this.X2Y2_呪印_鎖3CP.Update();
					return;
				case 3:
					this.X2Y3_親指CP.Update();
					this.X2Y3_手CP.Update();
					this.X2Y3_小指CP.Update();
					this.X2Y3_薬指CP.Update();
					this.X2Y3_中指CP.Update();
					this.X2Y3_人指CP.Update();
					this.X2Y3_呪印_輪1_輪外CP.Update();
					this.X2Y3_呪印_輪1_輪内CP.Update();
					this.X2Y3_呪印_輪2_輪外CP.Update();
					this.X2Y3_呪印_輪2_輪内CP.Update();
					this.X2Y3_呪印_輪3_輪外CP.Update();
					this.X2Y3_呪印_輪3_輪内CP.Update();
					this.X2Y3_呪印_鎖1CP.Update();
					this.X2Y3_呪印_鎖2CP.Update();
					this.X2Y3_呪印_鎖3CP.Update();
					return;
				default:
					this.X2Y4_親指CP.Update();
					this.X2Y4_手CP.Update();
					this.X2Y4_小指CP.Update();
					this.X2Y4_薬指CP.Update();
					this.X2Y4_中指CP.Update();
					this.X2Y4_人指CP.Update();
					this.X2Y4_呪印_輪1_輪外CP.Update();
					this.X2Y4_呪印_輪1_輪内CP.Update();
					this.X2Y4_呪印_輪2_輪外CP.Update();
					this.X2Y4_呪印_輪2_輪内CP.Update();
					this.X2Y4_呪印_輪3_輪外CP.Update();
					this.X2Y4_呪印_輪3_輪内CP.Update();
					this.X2Y4_呪印_鎖1CP.Update();
					this.X2Y4_呪印_鎖2CP.Update();
					this.X2Y4_呪印_鎖3CP.Update();
					return;
				}
				break;
			case 3:
				this.X3Y0_親指CP.Update();
				this.X3Y0_手CP.Update();
				this.X3Y0_小指CP.Update();
				this.X3Y0_薬指CP.Update();
				this.X3Y0_中指CP.Update();
				this.X3Y0_人指CP.Update();
				this.X3Y0_呪印_輪1_輪外CP.Update();
				this.X3Y0_呪印_輪1_輪内CP.Update();
				this.X3Y0_呪印_輪2_輪外CP.Update();
				this.X3Y0_呪印_輪2_輪内CP.Update();
				this.X3Y0_呪印_輪3_輪外CP.Update();
				this.X3Y0_呪印_輪3_輪内CP.Update();
				this.X3Y0_呪印_鎖1CP.Update();
				this.X3Y0_呪印_鎖2CP.Update();
				this.X3Y0_呪印_鎖3CP.Update();
				return;
			case 4:
				this.X4Y0_親指CP.Update();
				this.X4Y0_手CP.Update();
				this.X4Y0_小指CP.Update();
				this.X4Y0_薬指CP.Update();
				this.X4Y0_中指CP.Update();
				this.X4Y0_人指CP.Update();
				this.X4Y0_呪印_輪1_輪外CP.Update();
				this.X4Y0_呪印_輪1_輪内CP.Update();
				this.X4Y0_呪印_輪2_輪外CP.Update();
				this.X4Y0_呪印_輪2_輪内CP.Update();
				this.X4Y0_呪印_輪3_輪外CP.Update();
				this.X4Y0_呪印_輪3_輪内CP.Update();
				this.X4Y0_呪印_鎖1CP.Update();
				this.X4Y0_呪印_鎖2CP.Update();
				this.X4Y0_呪印_鎖3CP.Update();
				return;
			case 5:
				switch (this.本体.IndexY)
				{
				case 0:
					this.X5Y0_親指CP.Update();
					this.X5Y0_手CP.Update();
					this.X5Y0_小指CP.Update();
					this.X5Y0_薬指CP.Update();
					this.X5Y0_中指CP.Update();
					this.X5Y0_人指CP.Update();
					this.X5Y0_呪印_輪1_輪外CP.Update();
					this.X5Y0_呪印_輪1_輪内CP.Update();
					this.X5Y0_呪印_輪2_輪外CP.Update();
					this.X5Y0_呪印_輪2_輪内CP.Update();
					this.X5Y0_呪印_輪3_輪外CP.Update();
					this.X5Y0_呪印_輪3_輪内CP.Update();
					this.X5Y0_呪印_鎖1CP.Update();
					this.X5Y0_呪印_鎖2CP.Update();
					this.X5Y0_呪印_鎖3CP.Update();
					return;
				case 1:
					this.X5Y1_親指CP.Update();
					this.X5Y1_手CP.Update();
					this.X5Y1_小指CP.Update();
					this.X5Y1_薬指CP.Update();
					this.X5Y1_中指CP.Update();
					this.X5Y1_人指CP.Update();
					this.X5Y1_呪印_輪1_輪外CP.Update();
					this.X5Y1_呪印_輪1_輪内CP.Update();
					this.X5Y1_呪印_輪2_輪外CP.Update();
					this.X5Y1_呪印_輪2_輪内CP.Update();
					this.X5Y1_呪印_輪3_輪外CP.Update();
					this.X5Y1_呪印_輪3_輪内CP.Update();
					this.X5Y1_呪印_鎖1CP.Update();
					this.X5Y1_呪印_鎖2CP.Update();
					this.X5Y1_呪印_鎖3CP.Update();
					return;
				case 2:
					this.X5Y2_親指CP.Update();
					this.X5Y2_手CP.Update();
					this.X5Y2_小指CP.Update();
					this.X5Y2_薬指CP.Update();
					this.X5Y2_中指CP.Update();
					this.X5Y2_人指CP.Update();
					this.X5Y2_呪印_輪1_輪外CP.Update();
					this.X5Y2_呪印_輪1_輪内CP.Update();
					this.X5Y2_呪印_輪2_輪外CP.Update();
					this.X5Y2_呪印_輪2_輪内CP.Update();
					this.X5Y2_呪印_輪3_輪外CP.Update();
					this.X5Y2_呪印_輪3_輪内CP.Update();
					this.X5Y2_呪印_鎖1CP.Update();
					this.X5Y2_呪印_鎖2CP.Update();
					this.X5Y2_呪印_鎖3CP.Update();
					return;
				case 3:
					this.X5Y3_親指CP.Update();
					this.X5Y3_手CP.Update();
					this.X5Y3_小指CP.Update();
					this.X5Y3_薬指CP.Update();
					this.X5Y3_中指CP.Update();
					this.X5Y3_人指CP.Update();
					this.X5Y3_呪印_輪1_輪外CP.Update();
					this.X5Y3_呪印_輪1_輪内CP.Update();
					this.X5Y3_呪印_輪2_輪外CP.Update();
					this.X5Y3_呪印_輪2_輪内CP.Update();
					this.X5Y3_呪印_輪3_輪外CP.Update();
					this.X5Y3_呪印_輪3_輪内CP.Update();
					this.X5Y3_呪印_鎖1CP.Update();
					this.X5Y3_呪印_鎖2CP.Update();
					this.X5Y3_呪印_鎖3CP.Update();
					return;
				default:
					this.X5Y4_親指CP.Update();
					this.X5Y4_手CP.Update();
					this.X5Y4_小指CP.Update();
					this.X5Y4_薬指CP.Update();
					this.X5Y4_中指CP.Update();
					this.X5Y4_人指CP.Update();
					this.X5Y4_呪印_輪1_輪外CP.Update();
					this.X5Y4_呪印_輪1_輪内CP.Update();
					this.X5Y4_呪印_輪2_輪外CP.Update();
					this.X5Y4_呪印_輪2_輪内CP.Update();
					this.X5Y4_呪印_輪3_輪外CP.Update();
					this.X5Y4_呪印_輪3_輪内CP.Update();
					this.X5Y4_呪印_鎖1CP.Update();
					this.X5Y4_呪印_鎖2CP.Update();
					this.X5Y4_呪印_鎖3CP.Update();
					return;
				}
				break;
			case 6:
				switch (this.本体.IndexY)
				{
				case 0:
					this.X6Y0Pars.GetMiY_MaY(out this.mm);
					this.X6Y0_親指CP.Update();
					this.X6Y0_手CP.Update(this.mm);
					this.X6Y0_小指CP.Update();
					this.X6Y0_薬指CP.Update();
					this.X6Y0_中指CP.Update();
					this.X6Y0_人指CP.Update(this.mm);
					this.X6Y0_呪印_輪1_輪外CP.Update();
					this.X6Y0_呪印_輪1_輪内CP.Update();
					this.X6Y0_呪印_輪2_輪外CP.Update();
					this.X6Y0_呪印_輪2_輪内CP.Update();
					this.X6Y0_呪印_輪3_輪外CP.Update();
					this.X6Y0_呪印_輪3_輪内CP.Update();
					this.X6Y0_呪印_鎖1CP.Update();
					this.X6Y0_呪印_鎖2CP.Update();
					this.X6Y0_呪印_鎖3CP.Update();
					return;
				case 1:
					this.X6Y1Pars.GetMiY_MaY(out this.mm);
					this.X6Y1_親指CP.Update();
					this.X6Y1_手CP.Update(this.mm);
					this.X6Y1_小指CP.Update();
					this.X6Y1_薬指CP.Update();
					this.X6Y1_中指CP.Update();
					this.X6Y1_人指CP.Update(this.mm);
					this.X6Y1_呪印_輪1_輪外CP.Update();
					this.X6Y1_呪印_輪1_輪内CP.Update();
					this.X6Y1_呪印_輪2_輪外CP.Update();
					this.X6Y1_呪印_輪2_輪内CP.Update();
					this.X6Y1_呪印_輪3_輪外CP.Update();
					this.X6Y1_呪印_輪3_輪内CP.Update();
					this.X6Y1_呪印_鎖1CP.Update();
					this.X6Y1_呪印_鎖2CP.Update();
					this.X6Y1_呪印_鎖3CP.Update();
					return;
				case 2:
					this.X6Y2Pars.GetMiY_MaY(out this.mm);
					this.X6Y2_親指CP.Update();
					this.X6Y2_手CP.Update(this.mm);
					this.X6Y2_小指CP.Update();
					this.X6Y2_薬指CP.Update();
					this.X6Y2_中指CP.Update();
					this.X6Y2_人指CP.Update(this.mm);
					this.X6Y2_呪印_輪1_輪外CP.Update();
					this.X6Y2_呪印_輪1_輪内CP.Update();
					this.X6Y2_呪印_輪2_輪外CP.Update();
					this.X6Y2_呪印_輪2_輪内CP.Update();
					this.X6Y2_呪印_輪3_輪外CP.Update();
					this.X6Y2_呪印_輪3_輪内CP.Update();
					this.X6Y2_呪印_鎖1CP.Update();
					this.X6Y2_呪印_鎖2CP.Update();
					this.X6Y2_呪印_鎖3CP.Update();
					return;
				case 3:
					this.X6Y3Pars.GetMiY_MaY(out this.mm);
					this.X6Y3_親指CP.Update();
					this.X6Y3_手CP.Update(this.mm);
					this.X6Y3_小指CP.Update();
					this.X6Y3_薬指CP.Update();
					this.X6Y3_中指CP.Update();
					this.X6Y3_人指CP.Update(this.mm);
					this.X6Y3_呪印_輪1_輪外CP.Update();
					this.X6Y3_呪印_輪1_輪内CP.Update();
					this.X6Y3_呪印_輪2_輪外CP.Update();
					this.X6Y3_呪印_輪2_輪内CP.Update();
					this.X6Y3_呪印_輪3_輪外CP.Update();
					this.X6Y3_呪印_輪3_輪内CP.Update();
					this.X6Y3_呪印_鎖1CP.Update();
					this.X6Y3_呪印_鎖2CP.Update();
					this.X6Y3_呪印_鎖3CP.Update();
					return;
				default:
					this.X6Y4Pars.GetMiY_MaY(out this.mm);
					this.X6Y4_親指CP.Update();
					this.X6Y4_手CP.Update(this.mm);
					this.X6Y4_小指CP.Update();
					this.X6Y4_薬指CP.Update();
					this.X6Y4_中指CP.Update();
					this.X6Y4_人指CP.Update(this.mm);
					this.X6Y4_呪印_輪1_輪外CP.Update();
					this.X6Y4_呪印_輪1_輪内CP.Update();
					this.X6Y4_呪印_輪2_輪外CP.Update();
					this.X6Y4_呪印_輪2_輪内CP.Update();
					this.X6Y4_呪印_輪3_輪外CP.Update();
					this.X6Y4_呪印_輪3_輪内CP.Update();
					this.X6Y4_呪印_鎖1CP.Update();
					this.X6Y4_呪印_鎖2CP.Update();
					this.X6Y4_呪印_鎖3CP.Update();
					return;
				}
				break;
			case 7:
				switch (this.本体.IndexY)
				{
				case 0:
					this.X7Y0Pars.GetMiY_MaY(out this.mm);
					this.X7Y0_小指CP.Update();
					this.X7Y0_薬指CP.Update();
					this.X7Y0_中指CP.Update();
					this.X7Y0_親指CP.Update();
					this.X7Y0_手CP.Update(this.mm);
					this.X7Y0_人指CP.Update(this.mm);
					this.X7Y0_呪印_輪1_輪外CP.Update();
					this.X7Y0_呪印_輪1_輪内CP.Update();
					this.X7Y0_呪印_輪2_輪外CP.Update();
					this.X7Y0_呪印_輪2_輪内CP.Update();
					this.X7Y0_呪印_輪3_輪外CP.Update();
					this.X7Y0_呪印_輪3_輪内CP.Update();
					this.X7Y0_呪印_鎖1CP.Update();
					this.X7Y0_呪印_鎖2CP.Update();
					this.X7Y0_呪印_鎖3CP.Update();
					return;
				case 1:
					this.X7Y1Pars.GetMiY_MaY(out this.mm);
					this.X7Y1_小指CP.Update();
					this.X7Y1_薬指CP.Update();
					this.X7Y1_中指CP.Update();
					this.X7Y1_親指CP.Update();
					this.X7Y1_手CP.Update(this.mm);
					this.X7Y1_人指CP.Update(this.mm);
					this.X7Y1_呪印_輪1_輪外CP.Update();
					this.X7Y1_呪印_輪1_輪内CP.Update();
					this.X7Y1_呪印_輪2_輪外CP.Update();
					this.X7Y1_呪印_輪2_輪内CP.Update();
					this.X7Y1_呪印_輪3_輪外CP.Update();
					this.X7Y1_呪印_輪3_輪内CP.Update();
					this.X7Y1_呪印_鎖1CP.Update();
					this.X7Y1_呪印_鎖2CP.Update();
					this.X7Y1_呪印_鎖3CP.Update();
					return;
				case 2:
					this.X7Y2Pars.GetMiY_MaY(out this.mm);
					this.X7Y2_小指CP.Update();
					this.X7Y2_薬指CP.Update();
					this.X7Y2_中指CP.Update();
					this.X7Y2_親指CP.Update();
					this.X7Y2_手CP.Update(this.mm);
					this.X7Y2_人指CP.Update(this.mm);
					this.X7Y2_呪印_輪1_輪外CP.Update();
					this.X7Y2_呪印_輪1_輪内CP.Update();
					this.X7Y2_呪印_輪2_輪外CP.Update();
					this.X7Y2_呪印_輪2_輪内CP.Update();
					this.X7Y2_呪印_輪3_輪外CP.Update();
					this.X7Y2_呪印_輪3_輪内CP.Update();
					this.X7Y2_呪印_鎖1CP.Update();
					this.X7Y2_呪印_鎖2CP.Update();
					this.X7Y2_呪印_鎖3CP.Update();
					return;
				case 3:
					this.X7Y3Pars.GetMiY_MaY(out this.mm);
					this.X7Y3_小指CP.Update();
					this.X7Y3_薬指CP.Update();
					this.X7Y3_中指CP.Update();
					this.X7Y3_親指CP.Update();
					this.X7Y3_手CP.Update(this.mm);
					this.X7Y3_人指CP.Update(this.mm);
					this.X7Y3_呪印_輪1_輪外CP.Update();
					this.X7Y3_呪印_輪1_輪内CP.Update();
					this.X7Y3_呪印_輪2_輪外CP.Update();
					this.X7Y3_呪印_輪2_輪内CP.Update();
					this.X7Y3_呪印_輪3_輪外CP.Update();
					this.X7Y3_呪印_輪3_輪内CP.Update();
					this.X7Y3_呪印_鎖1CP.Update();
					this.X7Y3_呪印_鎖2CP.Update();
					this.X7Y3_呪印_鎖3CP.Update();
					return;
				default:
					this.X7Y4Pars.GetMiY_MaY(out this.mm);
					this.X7Y4_小指CP.Update();
					this.X7Y4_薬指CP.Update();
					this.X7Y4_中指CP.Update();
					this.X7Y4_親指CP.Update();
					this.X7Y4_手CP.Update(this.mm);
					this.X7Y4_人指CP.Update(this.mm);
					this.X7Y4_呪印_輪1_輪外CP.Update();
					this.X7Y4_呪印_輪1_輪内CP.Update();
					this.X7Y4_呪印_輪2_輪外CP.Update();
					this.X7Y4_呪印_輪2_輪内CP.Update();
					this.X7Y4_呪印_輪3_輪外CP.Update();
					this.X7Y4_呪印_輪3_輪内CP.Update();
					this.X7Y4_呪印_鎖1CP.Update();
					this.X7Y4_呪印_鎖2CP.Update();
					this.X7Y4_呪印_鎖3CP.Update();
					return;
				}
				break;
			case 8:
				switch (this.本体.IndexY)
				{
				case 0:
					this.X8Y0_手CP.Update();
					this.X8Y0_小指CP.Update();
					this.X8Y0_薬指CP.Update();
					this.X8Y0_中指CP.Update();
					this.X8Y0_人指CP.Update();
					this.X8Y0_親指CP.Update();
					return;
				case 1:
					this.X8Y1_手CP.Update();
					this.X8Y1_小指CP.Update();
					this.X8Y1_薬指CP.Update();
					this.X8Y1_中指CP.Update();
					this.X8Y1_人指CP.Update();
					this.X8Y1_親指CP.Update();
					return;
				case 2:
					this.X8Y2_手CP.Update();
					this.X8Y2_小指CP.Update();
					this.X8Y2_薬指CP.Update();
					this.X8Y2_中指CP.Update();
					this.X8Y2_人指CP.Update();
					this.X8Y2_親指CP.Update();
					return;
				case 3:
					this.X8Y3_手CP.Update();
					this.X8Y3_小指CP.Update();
					this.X8Y3_薬指CP.Update();
					this.X8Y3_中指CP.Update();
					this.X8Y3_人指CP.Update();
					this.X8Y3_親指CP.Update();
					return;
				default:
					this.X8Y4_手CP.Update();
					this.X8Y4_小指CP.Update();
					this.X8Y4_薬指CP.Update();
					this.X8Y4_中指CP.Update();
					this.X8Y4_人指CP.Update();
					this.X8Y4_親指CP.Update();
					return;
				}
				break;
			case 9:
				switch (this.本体.IndexY)
				{
				case 0:
					this.X9Y0_手CP.Update();
					this.X9Y0_小指CP.Update();
					this.X9Y0_薬指CP.Update();
					this.X9Y0_中指CP.Update();
					this.X9Y0_人指CP.Update();
					this.X9Y0_親指CP.Update();
					return;
				case 1:
					this.X9Y1_手CP.Update();
					this.X9Y1_小指CP.Update();
					this.X9Y1_薬指CP.Update();
					this.X9Y1_中指CP.Update();
					this.X9Y1_人指CP.Update();
					this.X9Y1_親指CP.Update();
					return;
				case 2:
					this.X9Y2_手CP.Update();
					this.X9Y2_小指CP.Update();
					this.X9Y2_薬指CP.Update();
					this.X9Y2_中指CP.Update();
					this.X9Y2_人指CP.Update();
					this.X9Y2_親指CP.Update();
					return;
				case 3:
					this.X9Y3_手CP.Update();
					this.X9Y3_小指CP.Update();
					this.X9Y3_薬指CP.Update();
					this.X9Y3_中指CP.Update();
					this.X9Y3_人指CP.Update();
					this.X9Y3_親指CP.Update();
					return;
				default:
					this.X9Y4_手CP.Update();
					this.X9Y4_小指CP.Update();
					this.X9Y4_薬指CP.Update();
					this.X9Y4_中指CP.Update();
					this.X9Y4_人指CP.Update();
					this.X9Y4_親指CP.Update();
					return;
				}
				break;
			case 10:
				switch (this.本体.IndexY)
				{
				case 0:
					this.X10Y0_親指CP.Update();
					this.X10Y0_手CP.Update();
					this.X10Y0_小指CP.Update();
					this.X10Y0_薬指CP.Update();
					this.X10Y0_中指CP.Update();
					this.X10Y0_人指CP.Update();
					this.X10Y0_呪印_輪1_輪外CP.Update();
					this.X10Y0_呪印_輪1_輪内CP.Update();
					this.X10Y0_呪印_輪2_輪外CP.Update();
					this.X10Y0_呪印_輪2_輪内CP.Update();
					this.X10Y0_呪印_輪3_輪外CP.Update();
					this.X10Y0_呪印_輪3_輪内CP.Update();
					this.X10Y0_呪印_鎖1CP.Update();
					this.X10Y0_呪印_鎖2CP.Update();
					this.X10Y0_呪印_鎖3CP.Update();
					return;
				case 1:
					this.X10Y1_親指CP.Update();
					this.X10Y1_手CP.Update();
					this.X10Y1_小指CP.Update();
					this.X10Y1_薬指CP.Update();
					this.X10Y1_中指CP.Update();
					this.X10Y1_人指CP.Update();
					this.X10Y1_呪印_輪1_輪外CP.Update();
					this.X10Y1_呪印_輪1_輪内CP.Update();
					this.X10Y1_呪印_輪2_輪外CP.Update();
					this.X10Y1_呪印_輪2_輪内CP.Update();
					this.X10Y1_呪印_輪3_輪外CP.Update();
					this.X10Y1_呪印_輪3_輪内CP.Update();
					this.X10Y1_呪印_鎖1CP.Update();
					this.X10Y1_呪印_鎖2CP.Update();
					this.X10Y1_呪印_鎖3CP.Update();
					return;
				case 2:
					this.X10Y2_親指CP.Update();
					this.X10Y2_手CP.Update();
					this.X10Y2_小指CP.Update();
					this.X10Y2_薬指CP.Update();
					this.X10Y2_中指CP.Update();
					this.X10Y2_人指CP.Update();
					this.X10Y2_呪印_輪1_輪外CP.Update();
					this.X10Y2_呪印_輪1_輪内CP.Update();
					this.X10Y2_呪印_輪2_輪外CP.Update();
					this.X10Y2_呪印_輪2_輪内CP.Update();
					this.X10Y2_呪印_輪3_輪外CP.Update();
					this.X10Y2_呪印_輪3_輪内CP.Update();
					this.X10Y2_呪印_鎖1CP.Update();
					this.X10Y2_呪印_鎖2CP.Update();
					this.X10Y2_呪印_鎖3CP.Update();
					return;
				case 3:
					this.X10Y3_親指CP.Update();
					this.X10Y3_手CP.Update();
					this.X10Y3_小指CP.Update();
					this.X10Y3_薬指CP.Update();
					this.X10Y3_中指CP.Update();
					this.X10Y3_人指CP.Update();
					this.X10Y3_呪印_輪1_輪外CP.Update();
					this.X10Y3_呪印_輪1_輪内CP.Update();
					this.X10Y3_呪印_輪2_輪外CP.Update();
					this.X10Y3_呪印_輪2_輪内CP.Update();
					this.X10Y3_呪印_輪3_輪外CP.Update();
					this.X10Y3_呪印_輪3_輪内CP.Update();
					this.X10Y3_呪印_鎖1CP.Update();
					this.X10Y3_呪印_鎖2CP.Update();
					this.X10Y3_呪印_鎖3CP.Update();
					return;
				default:
					this.X10Y4_親指CP.Update();
					this.X10Y4_手CP.Update();
					this.X10Y4_小指CP.Update();
					this.X10Y4_薬指CP.Update();
					this.X10Y4_中指CP.Update();
					this.X10Y4_人指CP.Update();
					this.X10Y4_呪印_輪1_輪外CP.Update();
					this.X10Y4_呪印_輪1_輪内CP.Update();
					this.X10Y4_呪印_輪2_輪外CP.Update();
					this.X10Y4_呪印_輪2_輪内CP.Update();
					this.X10Y4_呪印_輪3_輪外CP.Update();
					this.X10Y4_呪印_輪3_輪内CP.Update();
					this.X10Y4_呪印_鎖1CP.Update();
					this.X10Y4_呪印_鎖2CP.Update();
					this.X10Y4_呪印_鎖3CP.Update();
					return;
				}
				break;
			case 11:
				this.X11Y0_小指CP.Update();
				this.X11Y0_薬指CP.Update();
				this.X11Y0_中指CP.Update();
				this.X11Y0_人指CP.Update();
				this.X11Y0_手CP.Update();
				this.X11Y0_親指CP.Update();
				this.X11Y0_呪印_輪1_輪外CP.Update();
				this.X11Y0_呪印_輪1_輪内CP.Update();
				this.X11Y0_呪印_輪2_輪外CP.Update();
				this.X11Y0_呪印_輪2_輪内CP.Update();
				this.X11Y0_呪印_輪3_輪外CP.Update();
				this.X11Y0_呪印_輪3_輪内CP.Update();
				this.X11Y0_呪印_鎖1CP.Update();
				this.X11Y0_呪印_鎖3CP.Update();
				return;
			case 12:
				this.X12Y0_親指CP.Update();
				this.X12Y0_手CP.Update();
				this.X12Y0_小指CP.Update();
				this.X12Y0_薬指CP.Update();
				this.X12Y0_中指CP.Update();
				this.X12Y0_人指CP.Update();
				this.X12Y0_呪印_輪1_輪外CP.Update();
				this.X12Y0_呪印_輪1_輪内CP.Update();
				this.X12Y0_呪印_輪2_輪外CP.Update();
				this.X12Y0_呪印_輪2_輪内CP.Update();
				this.X12Y0_呪印_輪3_輪外CP.Update();
				this.X12Y0_呪印_輪3_輪内CP.Update();
				this.X12Y0_呪印_鎖1CP.Update();
				this.X12Y0_呪印_鎖2CP.Update();
				this.X12Y0_呪印_鎖3CP.Update();
				return;
			case 13:
				this.X13Y0_中指CP.Update();
				this.X13Y0_人指CP.Update();
				this.X13Y0_手CP.Update();
				this.X13Y0_親指CP.Update();
				this.X13Y0_呪印_輪1_輪外CP.Update();
				this.X13Y0_呪印_輪1_輪内CP.Update();
				this.X13Y0_呪印_輪2_輪外CP.Update();
				this.X13Y0_呪印_輪2_輪内CP.Update();
				this.X13Y0_呪印_輪3_輪外CP.Update();
				this.X13Y0_呪印_輪3_輪内CP.Update();
				this.X13Y0_呪印_鎖1CP.Update();
				this.X13Y0_呪印_鎖3CP.Update();
				return;
			default:
			{
				int indexY = this.本体.IndexY;
				if (indexY == 0)
				{
					this.X14Y0_親指CP.Update();
					this.X14Y0_手CP.Update();
					this.X14Y0_小指CP.Update();
					this.X14Y0_薬指CP.Update();
					this.X14Y0_中指CP.Update();
					this.X14Y0_人指CP.Update();
					this.X14Y0_呪印_輪1_輪外CP.Update();
					this.X14Y0_呪印_輪1_輪内CP.Update();
					this.X14Y0_呪印_輪2_輪外CP.Update();
					this.X14Y0_呪印_輪2_輪内CP.Update();
					this.X14Y0_呪印_輪3_輪外CP.Update();
					this.X14Y0_呪印_輪3_輪内CP.Update();
					this.X14Y0_呪印_鎖1CP.Update();
					this.X14Y0_呪印_鎖2CP.Update();
					this.X14Y0_呪印_鎖3CP.Update();
					return;
				}
				if (indexY != 1)
				{
					this.X14Y2_親指CP.Update();
					this.X14Y2_手CP.Update();
					this.X14Y2_小指CP.Update();
					this.X14Y2_薬指CP.Update();
					this.X14Y2_中指CP.Update();
					this.X14Y2_人指CP.Update();
					this.X14Y2_呪印_輪1_輪外CP.Update();
					this.X14Y2_呪印_輪1_輪内CP.Update();
					this.X14Y2_呪印_輪2_輪外CP.Update();
					this.X14Y2_呪印_輪2_輪内CP.Update();
					this.X14Y2_呪印_輪3_輪外CP.Update();
					this.X14Y2_呪印_輪3_輪内CP.Update();
					this.X14Y2_呪印_鎖1CP.Update();
					this.X14Y2_呪印_鎖2CP.Update();
					this.X14Y2_呪印_鎖3CP.Update();
					return;
				}
				this.X14Y1_親指CP.Update();
				this.X14Y1_手CP.Update();
				this.X14Y1_小指CP.Update();
				this.X14Y1_薬指CP.Update();
				this.X14Y1_中指CP.Update();
				this.X14Y1_人指CP.Update();
				this.X14Y1_呪印_輪1_輪外CP.Update();
				this.X14Y1_呪印_輪1_輪内CP.Update();
				this.X14Y1_呪印_輪2_輪外CP.Update();
				this.X14Y1_呪印_輪2_輪内CP.Update();
				this.X14Y1_呪印_輪3_輪外CP.Update();
				this.X14Y1_呪印_輪3_輪内CP.Update();
				this.X14Y1_呪印_鎖1CP.Update();
				this.X14Y1_呪印_鎖2CP.Update();
				this.X14Y1_呪印_鎖3CP.Update();
				return;
			}
			}
		}

		private void 配色(主人公配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(主人公配色 体配色)
		{
			this.親指CD = new ColorD(ref Col.Black, ref 体配色.肌色);
			this.手CD = new ColorD(ref Col.Black, ref 体配色.肌色);
			this.小指CD = new ColorD(ref Col.Black, ref 体配色.肌色);
			this.薬指CD = new ColorD(ref Col.Black, ref 体配色.肌色);
			this.中指CD = new ColorD(ref Col.Black, ref 体配色.肌色);
			this.人指CD = new ColorD(ref Col.Black, ref 体配色.肌色);
			this.呪印_輪1_輪外CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.呪印_輪1_輪内CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.呪印_輪2_輪外CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.呪印_輪2_輪内CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.呪印_輪3_輪外CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.呪印_輪3_輪内CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.呪印_鎖1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.呪印_鎖2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.呪印_鎖3CD = new ColorD(ref Col.Black, ref 体配色.刺青);
		}

		public void 再配色(主人公配色 体配色)
		{
			this.親指CD.線 = Col.Black;
			this.親指CD.色 = 体配色.肌色;
			this.手CD.線 = Col.Black;
			this.手CD.色 = 体配色.肌色;
			this.小指CD.線 = Col.Black;
			this.小指CD.色 = 体配色.肌色;
			this.薬指CD.線 = Col.Black;
			this.薬指CD.色 = 体配色.肌色;
			this.中指CD.線 = Col.Black;
			this.中指CD.色 = 体配色.肌色;
			this.人指CD.線 = Col.Black;
			this.人指CD.色 = 体配色.肌色;
			this.呪印_輪1_輪外CD.線 = Col.Black;
			this.呪印_輪1_輪外CD.色 = 体配色.刺青;
			this.呪印_輪1_輪内CD.線 = Col.Black;
			this.呪印_輪1_輪内CD.色 = 体配色.刺青;
			this.呪印_輪2_輪外CD.線 = Col.Black;
			this.呪印_輪2_輪外CD.色 = 体配色.刺青;
			this.呪印_輪2_輪内CD.線 = Col.Black;
			this.呪印_輪2_輪内CD.色 = 体配色.刺青;
			this.呪印_輪3_輪外CD.線 = Col.Black;
			this.呪印_輪3_輪外CD.色 = 体配色.刺青;
			this.呪印_輪3_輪内CD.線 = Col.Black;
			this.呪印_輪3_輪内CD.色 = 体配色.刺青;
			this.呪印_鎖1CD.線 = Col.Black;
			this.呪印_鎖1CD.色 = 体配色.刺青;
			this.呪印_鎖2CD.線 = Col.Black;
			this.呪印_鎖2CD.色 = 体配色.刺青;
			this.呪印_鎖3CD.線 = Col.Black;
			this.呪印_鎖3CD.色 = 体配色.刺青;
			this.X0Y0_親指CP.Setting();
			this.X0Y0_手CP.Setting();
			this.X0Y0_小指CP.Setting();
			this.X0Y0_薬指CP.Setting();
			this.X0Y0_中指CP.Setting();
			this.X0Y0_人指CP.Setting();
			this.X0Y0_呪印_輪1_輪外CP.Setting();
			this.X0Y0_呪印_輪1_輪内CP.Setting();
			this.X0Y0_呪印_輪2_輪外CP.Setting();
			this.X0Y0_呪印_輪2_輪内CP.Setting();
			this.X0Y0_呪印_輪3_輪外CP.Setting();
			this.X0Y0_呪印_輪3_輪内CP.Setting();
			this.X0Y0_呪印_鎖1CP.Setting();
			this.X0Y0_呪印_鎖2CP.Setting();
			this.X0Y0_呪印_鎖3CP.Setting();
			this.X1Y0_親指CP.Setting();
			this.X1Y0_手CP.Setting();
			this.X1Y0_小指CP.Setting();
			this.X1Y0_薬指CP.Setting();
			this.X1Y0_中指CP.Setting();
			this.X1Y0_人指CP.Setting();
			this.X1Y0_呪印_輪1_輪外CP.Setting();
			this.X1Y0_呪印_輪1_輪内CP.Setting();
			this.X1Y0_呪印_輪2_輪外CP.Setting();
			this.X1Y0_呪印_輪2_輪内CP.Setting();
			this.X1Y0_呪印_輪3_輪外CP.Setting();
			this.X1Y0_呪印_輪3_輪内CP.Setting();
			this.X1Y0_呪印_鎖1CP.Setting();
			this.X1Y0_呪印_鎖2CP.Setting();
			this.X1Y0_呪印_鎖3CP.Setting();
			this.X2Y0_親指CP.Setting();
			this.X2Y0_手CP.Setting();
			this.X2Y0_小指CP.Setting();
			this.X2Y0_薬指CP.Setting();
			this.X2Y0_中指CP.Setting();
			this.X2Y0_人指CP.Setting();
			this.X2Y0_呪印_輪1_輪外CP.Setting();
			this.X2Y0_呪印_輪1_輪内CP.Setting();
			this.X2Y0_呪印_輪2_輪外CP.Setting();
			this.X2Y0_呪印_輪2_輪内CP.Setting();
			this.X2Y0_呪印_輪3_輪外CP.Setting();
			this.X2Y0_呪印_輪3_輪内CP.Setting();
			this.X2Y0_呪印_鎖1CP.Setting();
			this.X2Y0_呪印_鎖2CP.Setting();
			this.X2Y0_呪印_鎖3CP.Setting();
			this.X2Y1_親指CP.Setting();
			this.X2Y1_手CP.Setting();
			this.X2Y1_小指CP.Setting();
			this.X2Y1_薬指CP.Setting();
			this.X2Y1_中指CP.Setting();
			this.X2Y1_人指CP.Setting();
			this.X2Y1_呪印_輪1_輪外CP.Setting();
			this.X2Y1_呪印_輪1_輪内CP.Setting();
			this.X2Y1_呪印_輪2_輪外CP.Setting();
			this.X2Y1_呪印_輪2_輪内CP.Setting();
			this.X2Y1_呪印_輪3_輪外CP.Setting();
			this.X2Y1_呪印_輪3_輪内CP.Setting();
			this.X2Y1_呪印_鎖1CP.Setting();
			this.X2Y1_呪印_鎖2CP.Setting();
			this.X2Y1_呪印_鎖3CP.Setting();
			this.X2Y2_親指CP.Setting();
			this.X2Y2_手CP.Setting();
			this.X2Y2_小指CP.Setting();
			this.X2Y2_薬指CP.Setting();
			this.X2Y2_中指CP.Setting();
			this.X2Y2_人指CP.Setting();
			this.X2Y2_呪印_輪1_輪外CP.Setting();
			this.X2Y2_呪印_輪1_輪内CP.Setting();
			this.X2Y2_呪印_輪2_輪外CP.Setting();
			this.X2Y2_呪印_輪2_輪内CP.Setting();
			this.X2Y2_呪印_輪3_輪外CP.Setting();
			this.X2Y2_呪印_輪3_輪内CP.Setting();
			this.X2Y2_呪印_鎖1CP.Setting();
			this.X2Y2_呪印_鎖2CP.Setting();
			this.X2Y2_呪印_鎖3CP.Setting();
			this.X2Y3_親指CP.Setting();
			this.X2Y3_手CP.Setting();
			this.X2Y3_小指CP.Setting();
			this.X2Y3_薬指CP.Setting();
			this.X2Y3_中指CP.Setting();
			this.X2Y3_人指CP.Setting();
			this.X2Y3_呪印_輪1_輪外CP.Setting();
			this.X2Y3_呪印_輪1_輪内CP.Setting();
			this.X2Y3_呪印_輪2_輪外CP.Setting();
			this.X2Y3_呪印_輪2_輪内CP.Setting();
			this.X2Y3_呪印_輪3_輪外CP.Setting();
			this.X2Y3_呪印_輪3_輪内CP.Setting();
			this.X2Y3_呪印_鎖1CP.Setting();
			this.X2Y3_呪印_鎖2CP.Setting();
			this.X2Y3_呪印_鎖3CP.Setting();
			this.X2Y4_親指CP.Setting();
			this.X2Y4_手CP.Setting();
			this.X2Y4_小指CP.Setting();
			this.X2Y4_薬指CP.Setting();
			this.X2Y4_中指CP.Setting();
			this.X2Y4_人指CP.Setting();
			this.X2Y4_呪印_輪1_輪外CP.Setting();
			this.X2Y4_呪印_輪1_輪内CP.Setting();
			this.X2Y4_呪印_輪2_輪外CP.Setting();
			this.X2Y4_呪印_輪2_輪内CP.Setting();
			this.X2Y4_呪印_輪3_輪外CP.Setting();
			this.X2Y4_呪印_輪3_輪内CP.Setting();
			this.X2Y4_呪印_鎖1CP.Setting();
			this.X2Y4_呪印_鎖2CP.Setting();
			this.X2Y4_呪印_鎖3CP.Setting();
			this.X3Y0_親指CP.Setting();
			this.X3Y0_手CP.Setting();
			this.X3Y0_小指CP.Setting();
			this.X3Y0_薬指CP.Setting();
			this.X3Y0_中指CP.Setting();
			this.X3Y0_人指CP.Setting();
			this.X3Y0_呪印_輪1_輪外CP.Setting();
			this.X3Y0_呪印_輪1_輪内CP.Setting();
			this.X3Y0_呪印_輪2_輪外CP.Setting();
			this.X3Y0_呪印_輪2_輪内CP.Setting();
			this.X3Y0_呪印_輪3_輪外CP.Setting();
			this.X3Y0_呪印_輪3_輪内CP.Setting();
			this.X3Y0_呪印_鎖1CP.Setting();
			this.X3Y0_呪印_鎖2CP.Setting();
			this.X3Y0_呪印_鎖3CP.Setting();
			this.X4Y0_親指CP.Setting();
			this.X4Y0_手CP.Setting();
			this.X4Y0_小指CP.Setting();
			this.X4Y0_薬指CP.Setting();
			this.X4Y0_中指CP.Setting();
			this.X4Y0_人指CP.Setting();
			this.X4Y0_呪印_輪1_輪外CP.Setting();
			this.X4Y0_呪印_輪1_輪内CP.Setting();
			this.X4Y0_呪印_輪2_輪外CP.Setting();
			this.X4Y0_呪印_輪2_輪内CP.Setting();
			this.X4Y0_呪印_輪3_輪外CP.Setting();
			this.X4Y0_呪印_輪3_輪内CP.Setting();
			this.X4Y0_呪印_鎖1CP.Setting();
			this.X4Y0_呪印_鎖2CP.Setting();
			this.X4Y0_呪印_鎖3CP.Setting();
			this.X5Y0_親指CP.Setting();
			this.X5Y0_手CP.Setting();
			this.X5Y0_小指CP.Setting();
			this.X5Y0_薬指CP.Setting();
			this.X5Y0_中指CP.Setting();
			this.X5Y0_人指CP.Setting();
			this.X5Y0_呪印_輪1_輪外CP.Setting();
			this.X5Y0_呪印_輪1_輪内CP.Setting();
			this.X5Y0_呪印_輪2_輪外CP.Setting();
			this.X5Y0_呪印_輪2_輪内CP.Setting();
			this.X5Y0_呪印_輪3_輪外CP.Setting();
			this.X5Y0_呪印_輪3_輪内CP.Setting();
			this.X5Y0_呪印_鎖1CP.Setting();
			this.X5Y0_呪印_鎖2CP.Setting();
			this.X5Y0_呪印_鎖3CP.Setting();
			this.X5Y1_親指CP.Setting();
			this.X5Y1_手CP.Setting();
			this.X5Y1_小指CP.Setting();
			this.X5Y1_薬指CP.Setting();
			this.X5Y1_中指CP.Setting();
			this.X5Y1_人指CP.Setting();
			this.X5Y1_呪印_輪1_輪外CP.Setting();
			this.X5Y1_呪印_輪1_輪内CP.Setting();
			this.X5Y1_呪印_輪2_輪外CP.Setting();
			this.X5Y1_呪印_輪2_輪内CP.Setting();
			this.X5Y1_呪印_輪3_輪外CP.Setting();
			this.X5Y1_呪印_輪3_輪内CP.Setting();
			this.X5Y1_呪印_鎖1CP.Setting();
			this.X5Y1_呪印_鎖2CP.Setting();
			this.X5Y1_呪印_鎖3CP.Setting();
			this.X5Y2_親指CP.Setting();
			this.X5Y2_手CP.Setting();
			this.X5Y2_小指CP.Setting();
			this.X5Y2_薬指CP.Setting();
			this.X5Y2_中指CP.Setting();
			this.X5Y2_人指CP.Setting();
			this.X5Y2_呪印_輪1_輪外CP.Setting();
			this.X5Y2_呪印_輪1_輪内CP.Setting();
			this.X5Y2_呪印_輪2_輪外CP.Setting();
			this.X5Y2_呪印_輪2_輪内CP.Setting();
			this.X5Y2_呪印_輪3_輪外CP.Setting();
			this.X5Y2_呪印_輪3_輪内CP.Setting();
			this.X5Y2_呪印_鎖1CP.Setting();
			this.X5Y2_呪印_鎖2CP.Setting();
			this.X5Y2_呪印_鎖3CP.Setting();
			this.X5Y3_親指CP.Setting();
			this.X5Y3_手CP.Setting();
			this.X5Y3_小指CP.Setting();
			this.X5Y3_薬指CP.Setting();
			this.X5Y3_中指CP.Setting();
			this.X5Y3_人指CP.Setting();
			this.X5Y3_呪印_輪1_輪外CP.Setting();
			this.X5Y3_呪印_輪1_輪内CP.Setting();
			this.X5Y3_呪印_輪2_輪外CP.Setting();
			this.X5Y3_呪印_輪2_輪内CP.Setting();
			this.X5Y3_呪印_輪3_輪外CP.Setting();
			this.X5Y3_呪印_輪3_輪内CP.Setting();
			this.X5Y3_呪印_鎖1CP.Setting();
			this.X5Y3_呪印_鎖2CP.Setting();
			this.X5Y3_呪印_鎖3CP.Setting();
			this.X5Y4_親指CP.Setting();
			this.X5Y4_手CP.Setting();
			this.X5Y4_小指CP.Setting();
			this.X5Y4_薬指CP.Setting();
			this.X5Y4_中指CP.Setting();
			this.X5Y4_人指CP.Setting();
			this.X5Y4_呪印_輪1_輪外CP.Setting();
			this.X5Y4_呪印_輪1_輪内CP.Setting();
			this.X5Y4_呪印_輪2_輪外CP.Setting();
			this.X5Y4_呪印_輪2_輪内CP.Setting();
			this.X5Y4_呪印_輪3_輪外CP.Setting();
			this.X5Y4_呪印_輪3_輪内CP.Setting();
			this.X5Y4_呪印_鎖1CP.Setting();
			this.X5Y4_呪印_鎖2CP.Setting();
			this.X5Y4_呪印_鎖3CP.Setting();
			this.X6Y0_親指CP.Setting();
			this.X6Y0_手CP.Setting();
			this.X6Y0_小指CP.Setting();
			this.X6Y0_薬指CP.Setting();
			this.X6Y0_中指CP.Setting();
			this.X6Y0_人指CP.Setting();
			this.X6Y0_呪印_輪1_輪外CP.Setting();
			this.X6Y0_呪印_輪1_輪内CP.Setting();
			this.X6Y0_呪印_輪2_輪外CP.Setting();
			this.X6Y0_呪印_輪2_輪内CP.Setting();
			this.X6Y0_呪印_輪3_輪外CP.Setting();
			this.X6Y0_呪印_輪3_輪内CP.Setting();
			this.X6Y0_呪印_鎖1CP.Setting();
			this.X6Y0_呪印_鎖2CP.Setting();
			this.X6Y0_呪印_鎖3CP.Setting();
			this.X6Y1_親指CP.Setting();
			this.X6Y1_手CP.Setting();
			this.X6Y1_小指CP.Setting();
			this.X6Y1_薬指CP.Setting();
			this.X6Y1_中指CP.Setting();
			this.X6Y1_人指CP.Setting();
			this.X6Y1_呪印_輪1_輪外CP.Setting();
			this.X6Y1_呪印_輪1_輪内CP.Setting();
			this.X6Y1_呪印_輪2_輪外CP.Setting();
			this.X6Y1_呪印_輪2_輪内CP.Setting();
			this.X6Y1_呪印_輪3_輪外CP.Setting();
			this.X6Y1_呪印_輪3_輪内CP.Setting();
			this.X6Y1_呪印_鎖1CP.Setting();
			this.X6Y1_呪印_鎖2CP.Setting();
			this.X6Y1_呪印_鎖3CP.Setting();
			this.X6Y2_親指CP.Setting();
			this.X6Y2_手CP.Setting();
			this.X6Y2_小指CP.Setting();
			this.X6Y2_薬指CP.Setting();
			this.X6Y2_中指CP.Setting();
			this.X6Y2_人指CP.Setting();
			this.X6Y2_呪印_輪1_輪外CP.Setting();
			this.X6Y2_呪印_輪1_輪内CP.Setting();
			this.X6Y2_呪印_輪2_輪外CP.Setting();
			this.X6Y2_呪印_輪2_輪内CP.Setting();
			this.X6Y2_呪印_輪3_輪外CP.Setting();
			this.X6Y2_呪印_輪3_輪内CP.Setting();
			this.X6Y2_呪印_鎖1CP.Setting();
			this.X6Y2_呪印_鎖2CP.Setting();
			this.X6Y2_呪印_鎖3CP.Setting();
			this.X6Y3_親指CP.Setting();
			this.X6Y3_手CP.Setting();
			this.X6Y3_小指CP.Setting();
			this.X6Y3_薬指CP.Setting();
			this.X6Y3_中指CP.Setting();
			this.X6Y3_人指CP.Setting();
			this.X6Y3_呪印_輪1_輪外CP.Setting();
			this.X6Y3_呪印_輪1_輪内CP.Setting();
			this.X6Y3_呪印_輪2_輪外CP.Setting();
			this.X6Y3_呪印_輪2_輪内CP.Setting();
			this.X6Y3_呪印_輪3_輪外CP.Setting();
			this.X6Y3_呪印_輪3_輪内CP.Setting();
			this.X6Y3_呪印_鎖1CP.Setting();
			this.X6Y3_呪印_鎖2CP.Setting();
			this.X6Y3_呪印_鎖3CP.Setting();
			this.X6Y4_親指CP.Setting();
			this.X6Y4_手CP.Setting();
			this.X6Y4_小指CP.Setting();
			this.X6Y4_薬指CP.Setting();
			this.X6Y4_中指CP.Setting();
			this.X6Y4_人指CP.Setting();
			this.X6Y4_呪印_輪1_輪外CP.Setting();
			this.X6Y4_呪印_輪1_輪内CP.Setting();
			this.X6Y4_呪印_輪2_輪外CP.Setting();
			this.X6Y4_呪印_輪2_輪内CP.Setting();
			this.X6Y4_呪印_輪3_輪外CP.Setting();
			this.X6Y4_呪印_輪3_輪内CP.Setting();
			this.X6Y4_呪印_鎖1CP.Setting();
			this.X6Y4_呪印_鎖2CP.Setting();
			this.X6Y4_呪印_鎖3CP.Setting();
			this.X7Y0_小指CP.Setting();
			this.X7Y0_薬指CP.Setting();
			this.X7Y0_中指CP.Setting();
			this.X7Y0_親指CP.Setting();
			this.X7Y0_手CP.Setting();
			this.X7Y0_人指CP.Setting();
			this.X7Y0_呪印_輪1_輪外CP.Setting();
			this.X7Y0_呪印_輪1_輪内CP.Setting();
			this.X7Y0_呪印_輪2_輪外CP.Setting();
			this.X7Y0_呪印_輪2_輪内CP.Setting();
			this.X7Y0_呪印_輪3_輪外CP.Setting();
			this.X7Y0_呪印_輪3_輪内CP.Setting();
			this.X7Y0_呪印_鎖1CP.Setting();
			this.X7Y0_呪印_鎖2CP.Setting();
			this.X7Y0_呪印_鎖3CP.Setting();
			this.X7Y1_小指CP.Setting();
			this.X7Y1_薬指CP.Setting();
			this.X7Y1_中指CP.Setting();
			this.X7Y1_親指CP.Setting();
			this.X7Y1_手CP.Setting();
			this.X7Y1_人指CP.Setting();
			this.X7Y1_呪印_輪1_輪外CP.Setting();
			this.X7Y1_呪印_輪1_輪内CP.Setting();
			this.X7Y1_呪印_輪2_輪外CP.Setting();
			this.X7Y1_呪印_輪2_輪内CP.Setting();
			this.X7Y1_呪印_輪3_輪外CP.Setting();
			this.X7Y1_呪印_輪3_輪内CP.Setting();
			this.X7Y1_呪印_鎖1CP.Setting();
			this.X7Y1_呪印_鎖2CP.Setting();
			this.X7Y1_呪印_鎖3CP.Setting();
			this.X7Y2_小指CP.Setting();
			this.X7Y2_薬指CP.Setting();
			this.X7Y2_中指CP.Setting();
			this.X7Y2_親指CP.Setting();
			this.X7Y2_手CP.Setting();
			this.X7Y2_人指CP.Setting();
			this.X7Y2_呪印_輪1_輪外CP.Setting();
			this.X7Y2_呪印_輪1_輪内CP.Setting();
			this.X7Y2_呪印_輪2_輪外CP.Setting();
			this.X7Y2_呪印_輪2_輪内CP.Setting();
			this.X7Y2_呪印_輪3_輪外CP.Setting();
			this.X7Y2_呪印_輪3_輪内CP.Setting();
			this.X7Y2_呪印_鎖1CP.Setting();
			this.X7Y2_呪印_鎖2CP.Setting();
			this.X7Y2_呪印_鎖3CP.Setting();
			this.X7Y3_小指CP.Setting();
			this.X7Y3_薬指CP.Setting();
			this.X7Y3_中指CP.Setting();
			this.X7Y3_親指CP.Setting();
			this.X7Y3_手CP.Setting();
			this.X7Y3_人指CP.Setting();
			this.X7Y3_呪印_輪1_輪外CP.Setting();
			this.X7Y3_呪印_輪1_輪内CP.Setting();
			this.X7Y3_呪印_輪2_輪外CP.Setting();
			this.X7Y3_呪印_輪2_輪内CP.Setting();
			this.X7Y3_呪印_輪3_輪外CP.Setting();
			this.X7Y3_呪印_輪3_輪内CP.Setting();
			this.X7Y3_呪印_鎖1CP.Setting();
			this.X7Y3_呪印_鎖2CP.Setting();
			this.X7Y3_呪印_鎖3CP.Setting();
			this.X7Y4_小指CP.Setting();
			this.X7Y4_薬指CP.Setting();
			this.X7Y4_中指CP.Setting();
			this.X7Y4_親指CP.Setting();
			this.X7Y4_手CP.Setting();
			this.X7Y4_人指CP.Setting();
			this.X7Y4_呪印_輪1_輪外CP.Setting();
			this.X7Y4_呪印_輪1_輪内CP.Setting();
			this.X7Y4_呪印_輪2_輪外CP.Setting();
			this.X7Y4_呪印_輪2_輪内CP.Setting();
			this.X7Y4_呪印_輪3_輪外CP.Setting();
			this.X7Y4_呪印_輪3_輪内CP.Setting();
			this.X7Y4_呪印_鎖1CP.Setting();
			this.X7Y4_呪印_鎖2CP.Setting();
			this.X7Y4_呪印_鎖3CP.Setting();
			this.X8Y0_手CP.Setting();
			this.X8Y0_小指CP.Setting();
			this.X8Y0_薬指CP.Setting();
			this.X8Y0_中指CP.Setting();
			this.X8Y0_人指CP.Setting();
			this.X8Y0_親指CP.Setting();
			this.X8Y1_手CP.Setting();
			this.X8Y1_小指CP.Setting();
			this.X8Y1_薬指CP.Setting();
			this.X8Y1_中指CP.Setting();
			this.X8Y1_人指CP.Setting();
			this.X8Y1_親指CP.Setting();
			this.X8Y2_手CP.Setting();
			this.X8Y2_小指CP.Setting();
			this.X8Y2_薬指CP.Setting();
			this.X8Y2_中指CP.Setting();
			this.X8Y2_人指CP.Setting();
			this.X8Y2_親指CP.Setting();
			this.X8Y3_手CP.Setting();
			this.X8Y3_小指CP.Setting();
			this.X8Y3_薬指CP.Setting();
			this.X8Y3_中指CP.Setting();
			this.X8Y3_人指CP.Setting();
			this.X8Y3_親指CP.Setting();
			this.X8Y4_手CP.Setting();
			this.X8Y4_小指CP.Setting();
			this.X8Y4_薬指CP.Setting();
			this.X8Y4_中指CP.Setting();
			this.X8Y4_人指CP.Setting();
			this.X8Y4_親指CP.Setting();
			this.X9Y0_手CP.Setting();
			this.X9Y0_小指CP.Setting();
			this.X9Y0_薬指CP.Setting();
			this.X9Y0_中指CP.Setting();
			this.X9Y0_人指CP.Setting();
			this.X9Y0_親指CP.Setting();
			this.X9Y1_手CP.Setting();
			this.X9Y1_小指CP.Setting();
			this.X9Y1_薬指CP.Setting();
			this.X9Y1_中指CP.Setting();
			this.X9Y1_人指CP.Setting();
			this.X9Y1_親指CP.Setting();
			this.X9Y2_手CP.Setting();
			this.X9Y2_小指CP.Setting();
			this.X9Y2_薬指CP.Setting();
			this.X9Y2_中指CP.Setting();
			this.X9Y2_人指CP.Setting();
			this.X9Y2_親指CP.Setting();
			this.X9Y3_手CP.Setting();
			this.X9Y3_小指CP.Setting();
			this.X9Y3_薬指CP.Setting();
			this.X9Y3_中指CP.Setting();
			this.X9Y3_人指CP.Setting();
			this.X9Y3_親指CP.Setting();
			this.X9Y4_手CP.Setting();
			this.X9Y4_小指CP.Setting();
			this.X9Y4_薬指CP.Setting();
			this.X9Y4_中指CP.Setting();
			this.X9Y4_人指CP.Setting();
			this.X9Y4_親指CP.Setting();
			this.X10Y0_親指CP.Setting();
			this.X10Y0_手CP.Setting();
			this.X10Y0_小指CP.Setting();
			this.X10Y0_薬指CP.Setting();
			this.X10Y0_中指CP.Setting();
			this.X10Y0_人指CP.Setting();
			this.X10Y0_呪印_輪1_輪外CP.Setting();
			this.X10Y0_呪印_輪1_輪内CP.Setting();
			this.X10Y0_呪印_輪2_輪外CP.Setting();
			this.X10Y0_呪印_輪2_輪内CP.Setting();
			this.X10Y0_呪印_輪3_輪外CP.Setting();
			this.X10Y0_呪印_輪3_輪内CP.Setting();
			this.X10Y0_呪印_鎖1CP.Setting();
			this.X10Y0_呪印_鎖2CP.Setting();
			this.X10Y0_呪印_鎖3CP.Setting();
			this.X10Y1_親指CP.Setting();
			this.X10Y1_手CP.Setting();
			this.X10Y1_小指CP.Setting();
			this.X10Y1_薬指CP.Setting();
			this.X10Y1_中指CP.Setting();
			this.X10Y1_人指CP.Setting();
			this.X10Y1_呪印_輪1_輪外CP.Setting();
			this.X10Y1_呪印_輪1_輪内CP.Setting();
			this.X10Y1_呪印_輪2_輪外CP.Setting();
			this.X10Y1_呪印_輪2_輪内CP.Setting();
			this.X10Y1_呪印_輪3_輪外CP.Setting();
			this.X10Y1_呪印_輪3_輪内CP.Setting();
			this.X10Y1_呪印_鎖1CP.Setting();
			this.X10Y1_呪印_鎖2CP.Setting();
			this.X10Y1_呪印_鎖3CP.Setting();
			this.X10Y2_親指CP.Setting();
			this.X10Y2_手CP.Setting();
			this.X10Y2_小指CP.Setting();
			this.X10Y2_薬指CP.Setting();
			this.X10Y2_中指CP.Setting();
			this.X10Y2_人指CP.Setting();
			this.X10Y2_呪印_輪1_輪外CP.Setting();
			this.X10Y2_呪印_輪1_輪内CP.Setting();
			this.X10Y2_呪印_輪2_輪外CP.Setting();
			this.X10Y2_呪印_輪2_輪内CP.Setting();
			this.X10Y2_呪印_輪3_輪外CP.Setting();
			this.X10Y2_呪印_輪3_輪内CP.Setting();
			this.X10Y2_呪印_鎖1CP.Setting();
			this.X10Y2_呪印_鎖2CP.Setting();
			this.X10Y2_呪印_鎖3CP.Setting();
			this.X10Y3_親指CP.Setting();
			this.X10Y3_手CP.Setting();
			this.X10Y3_小指CP.Setting();
			this.X10Y3_薬指CP.Setting();
			this.X10Y3_中指CP.Setting();
			this.X10Y3_人指CP.Setting();
			this.X10Y3_呪印_輪1_輪外CP.Setting();
			this.X10Y3_呪印_輪1_輪内CP.Setting();
			this.X10Y3_呪印_輪2_輪外CP.Setting();
			this.X10Y3_呪印_輪2_輪内CP.Setting();
			this.X10Y3_呪印_輪3_輪外CP.Setting();
			this.X10Y3_呪印_輪3_輪内CP.Setting();
			this.X10Y3_呪印_鎖1CP.Setting();
			this.X10Y3_呪印_鎖2CP.Setting();
			this.X10Y3_呪印_鎖3CP.Setting();
			this.X10Y4_親指CP.Setting();
			this.X10Y4_手CP.Setting();
			this.X10Y4_小指CP.Setting();
			this.X10Y4_薬指CP.Setting();
			this.X10Y4_中指CP.Setting();
			this.X10Y4_人指CP.Setting();
			this.X10Y4_呪印_輪1_輪外CP.Setting();
			this.X10Y4_呪印_輪1_輪内CP.Setting();
			this.X10Y4_呪印_輪2_輪外CP.Setting();
			this.X10Y4_呪印_輪2_輪内CP.Setting();
			this.X10Y4_呪印_輪3_輪外CP.Setting();
			this.X10Y4_呪印_輪3_輪内CP.Setting();
			this.X10Y4_呪印_鎖1CP.Setting();
			this.X10Y4_呪印_鎖2CP.Setting();
			this.X10Y4_呪印_鎖3CP.Setting();
			this.X11Y0_小指CP.Setting();
			this.X11Y0_薬指CP.Setting();
			this.X11Y0_中指CP.Setting();
			this.X11Y0_人指CP.Setting();
			this.X11Y0_手CP.Setting();
			this.X11Y0_親指CP.Setting();
			this.X11Y0_呪印_輪1_輪外CP.Setting();
			this.X11Y0_呪印_輪1_輪内CP.Setting();
			this.X11Y0_呪印_輪2_輪外CP.Setting();
			this.X11Y0_呪印_輪2_輪内CP.Setting();
			this.X11Y0_呪印_輪3_輪外CP.Setting();
			this.X11Y0_呪印_輪3_輪内CP.Setting();
			this.X11Y0_呪印_鎖1CP.Setting();
			this.X11Y0_呪印_鎖3CP.Setting();
			this.X12Y0_親指CP.Setting();
			this.X12Y0_手CP.Setting();
			this.X12Y0_小指CP.Setting();
			this.X12Y0_薬指CP.Setting();
			this.X12Y0_中指CP.Setting();
			this.X12Y0_人指CP.Setting();
			this.X12Y0_呪印_輪1_輪外CP.Setting();
			this.X12Y0_呪印_輪1_輪内CP.Setting();
			this.X12Y0_呪印_輪2_輪外CP.Setting();
			this.X12Y0_呪印_輪2_輪内CP.Setting();
			this.X12Y0_呪印_輪3_輪外CP.Setting();
			this.X12Y0_呪印_輪3_輪内CP.Setting();
			this.X12Y0_呪印_鎖1CP.Setting();
			this.X12Y0_呪印_鎖2CP.Setting();
			this.X12Y0_呪印_鎖3CP.Setting();
			this.X13Y0_中指CP.Setting();
			this.X13Y0_人指CP.Setting();
			this.X13Y0_手CP.Setting();
			this.X13Y0_親指CP.Setting();
			this.X13Y0_呪印_輪1_輪外CP.Setting();
			this.X13Y0_呪印_輪1_輪内CP.Setting();
			this.X13Y0_呪印_輪2_輪外CP.Setting();
			this.X13Y0_呪印_輪2_輪内CP.Setting();
			this.X13Y0_呪印_輪3_輪外CP.Setting();
			this.X13Y0_呪印_輪3_輪内CP.Setting();
			this.X13Y0_呪印_鎖1CP.Setting();
			this.X13Y0_呪印_鎖3CP.Setting();
			this.X14Y0_親指CP.Setting();
			this.X14Y0_手CP.Setting();
			this.X14Y0_小指CP.Setting();
			this.X14Y0_薬指CP.Setting();
			this.X14Y0_中指CP.Setting();
			this.X14Y0_人指CP.Setting();
			this.X14Y0_呪印_輪1_輪外CP.Setting();
			this.X14Y0_呪印_輪1_輪内CP.Setting();
			this.X14Y0_呪印_輪2_輪外CP.Setting();
			this.X14Y0_呪印_輪2_輪内CP.Setting();
			this.X14Y0_呪印_輪3_輪外CP.Setting();
			this.X14Y0_呪印_輪3_輪内CP.Setting();
			this.X14Y0_呪印_鎖1CP.Setting();
			this.X14Y0_呪印_鎖2CP.Setting();
			this.X14Y0_呪印_鎖3CP.Setting();
			this.X14Y1_親指CP.Setting();
			this.X14Y1_手CP.Setting();
			this.X14Y1_小指CP.Setting();
			this.X14Y1_薬指CP.Setting();
			this.X14Y1_中指CP.Setting();
			this.X14Y1_人指CP.Setting();
			this.X14Y1_呪印_輪1_輪外CP.Setting();
			this.X14Y1_呪印_輪1_輪内CP.Setting();
			this.X14Y1_呪印_輪2_輪外CP.Setting();
			this.X14Y1_呪印_輪2_輪内CP.Setting();
			this.X14Y1_呪印_輪3_輪外CP.Setting();
			this.X14Y1_呪印_輪3_輪内CP.Setting();
			this.X14Y1_呪印_鎖1CP.Setting();
			this.X14Y1_呪印_鎖2CP.Setting();
			this.X14Y1_呪印_鎖3CP.Setting();
			this.X14Y2_親指CP.Setting();
			this.X14Y2_手CP.Setting();
			this.X14Y2_小指CP.Setting();
			this.X14Y2_薬指CP.Setting();
			this.X14Y2_中指CP.Setting();
			this.X14Y2_人指CP.Setting();
			this.X14Y2_呪印_輪1_輪外CP.Setting();
			this.X14Y2_呪印_輪1_輪内CP.Setting();
			this.X14Y2_呪印_輪2_輪外CP.Setting();
			this.X14Y2_呪印_輪2_輪内CP.Setting();
			this.X14Y2_呪印_輪3_輪外CP.Setting();
			this.X14Y2_呪印_輪3_輪内CP.Setting();
			this.X14Y2_呪印_鎖1CP.Setting();
			this.X14Y2_呪印_鎖2CP.Setting();
			this.X14Y2_呪印_鎖3CP.Setting();
		}

		public Par X0Y0_親指;

		public Par X0Y0_手;

		public Par X0Y0_小指;

		public Par X0Y0_薬指;

		public Par X0Y0_中指;

		public Par X0Y0_人指;

		public Par X0Y0_呪印_輪1_輪外;

		public Par X0Y0_呪印_輪1_輪内;

		public Par X0Y0_呪印_輪2_輪外;

		public Par X0Y0_呪印_輪2_輪内;

		public Par X0Y0_呪印_輪3_輪外;

		public Par X0Y0_呪印_輪3_輪内;

		public Par X0Y0_呪印_鎖1;

		public Par X0Y0_呪印_鎖2;

		public Par X0Y0_呪印_鎖3;

		public Par X1Y0_親指;

		public Par X1Y0_手;

		public Par X1Y0_小指;

		public Par X1Y0_薬指;

		public Par X1Y0_中指;

		public Par X1Y0_人指;

		public Par X1Y0_呪印_輪1_輪外;

		public Par X1Y0_呪印_輪1_輪内;

		public Par X1Y0_呪印_輪2_輪外;

		public Par X1Y0_呪印_輪2_輪内;

		public Par X1Y0_呪印_輪3_輪外;

		public Par X1Y0_呪印_輪3_輪内;

		public Par X1Y0_呪印_鎖1;

		public Par X1Y0_呪印_鎖2;

		public Par X1Y0_呪印_鎖3;

		public Par X2Y0_親指;

		public Par X2Y0_手;

		public Par X2Y0_小指;

		public Par X2Y0_薬指;

		public Par X2Y0_中指;

		public Par X2Y0_人指;

		public Par X2Y0_呪印_輪1_輪外;

		public Par X2Y0_呪印_輪1_輪内;

		public Par X2Y0_呪印_輪2_輪外;

		public Par X2Y0_呪印_輪2_輪内;

		public Par X2Y0_呪印_輪3_輪外;

		public Par X2Y0_呪印_輪3_輪内;

		public Par X2Y0_呪印_鎖1;

		public Par X2Y0_呪印_鎖2;

		public Par X2Y0_呪印_鎖3;

		public Par X2Y1_親指;

		public Par X2Y1_手;

		public Par X2Y1_小指;

		public Par X2Y1_薬指;

		public Par X2Y1_中指;

		public Par X2Y1_人指;

		public Par X2Y1_呪印_輪1_輪外;

		public Par X2Y1_呪印_輪1_輪内;

		public Par X2Y1_呪印_輪2_輪外;

		public Par X2Y1_呪印_輪2_輪内;

		public Par X2Y1_呪印_輪3_輪外;

		public Par X2Y1_呪印_輪3_輪内;

		public Par X2Y1_呪印_鎖1;

		public Par X2Y1_呪印_鎖2;

		public Par X2Y1_呪印_鎖3;

		public Par X2Y2_親指;

		public Par X2Y2_手;

		public Par X2Y2_小指;

		public Par X2Y2_薬指;

		public Par X2Y2_中指;

		public Par X2Y2_人指;

		public Par X2Y2_呪印_輪1_輪外;

		public Par X2Y2_呪印_輪1_輪内;

		public Par X2Y2_呪印_輪2_輪外;

		public Par X2Y2_呪印_輪2_輪内;

		public Par X2Y2_呪印_輪3_輪外;

		public Par X2Y2_呪印_輪3_輪内;

		public Par X2Y2_呪印_鎖1;

		public Par X2Y2_呪印_鎖2;

		public Par X2Y2_呪印_鎖3;

		public Par X2Y3_親指;

		public Par X2Y3_手;

		public Par X2Y3_小指;

		public Par X2Y3_薬指;

		public Par X2Y3_中指;

		public Par X2Y3_人指;

		public Par X2Y3_呪印_輪1_輪外;

		public Par X2Y3_呪印_輪1_輪内;

		public Par X2Y3_呪印_輪2_輪外;

		public Par X2Y3_呪印_輪2_輪内;

		public Par X2Y3_呪印_輪3_輪外;

		public Par X2Y3_呪印_輪3_輪内;

		public Par X2Y3_呪印_鎖1;

		public Par X2Y3_呪印_鎖2;

		public Par X2Y3_呪印_鎖3;

		public Par X2Y4_親指;

		public Par X2Y4_手;

		public Par X2Y4_小指;

		public Par X2Y4_薬指;

		public Par X2Y4_中指;

		public Par X2Y4_人指;

		public Par X2Y4_呪印_輪1_輪外;

		public Par X2Y4_呪印_輪1_輪内;

		public Par X2Y4_呪印_輪2_輪外;

		public Par X2Y4_呪印_輪2_輪内;

		public Par X2Y4_呪印_輪3_輪外;

		public Par X2Y4_呪印_輪3_輪内;

		public Par X2Y4_呪印_鎖1;

		public Par X2Y4_呪印_鎖2;

		public Par X2Y4_呪印_鎖3;

		public Par X3Y0_親指;

		public Par X3Y0_手;

		public Par X3Y0_小指;

		public Par X3Y0_薬指;

		public Par X3Y0_中指;

		public Par X3Y0_人指;

		public Par X3Y0_呪印_輪1_輪外;

		public Par X3Y0_呪印_輪1_輪内;

		public Par X3Y0_呪印_輪2_輪外;

		public Par X3Y0_呪印_輪2_輪内;

		public Par X3Y0_呪印_輪3_輪外;

		public Par X3Y0_呪印_輪3_輪内;

		public Par X3Y0_呪印_鎖1;

		public Par X3Y0_呪印_鎖2;

		public Par X3Y0_呪印_鎖3;

		public Par X4Y0_親指;

		public Par X4Y0_手;

		public Par X4Y0_小指;

		public Par X4Y0_薬指;

		public Par X4Y0_中指;

		public Par X4Y0_人指;

		public Par X4Y0_呪印_輪1_輪外;

		public Par X4Y0_呪印_輪1_輪内;

		public Par X4Y0_呪印_輪2_輪外;

		public Par X4Y0_呪印_輪2_輪内;

		public Par X4Y0_呪印_輪3_輪外;

		public Par X4Y0_呪印_輪3_輪内;

		public Par X4Y0_呪印_鎖1;

		public Par X4Y0_呪印_鎖2;

		public Par X4Y0_呪印_鎖3;

		public Par X5Y0_親指;

		public Par X5Y0_手;

		public Par X5Y0_小指;

		public Par X5Y0_薬指;

		public Par X5Y0_中指;

		public Par X5Y0_人指;

		public Par X5Y0_呪印_輪1_輪外;

		public Par X5Y0_呪印_輪1_輪内;

		public Par X5Y0_呪印_輪2_輪外;

		public Par X5Y0_呪印_輪2_輪内;

		public Par X5Y0_呪印_輪3_輪外;

		public Par X5Y0_呪印_輪3_輪内;

		public Par X5Y0_呪印_鎖1;

		public Par X5Y0_呪印_鎖2;

		public Par X5Y0_呪印_鎖3;

		public Par X5Y1_親指;

		public Par X5Y1_手;

		public Par X5Y1_小指;

		public Par X5Y1_薬指;

		public Par X5Y1_中指;

		public Par X5Y1_人指;

		public Par X5Y1_呪印_輪1_輪外;

		public Par X5Y1_呪印_輪1_輪内;

		public Par X5Y1_呪印_輪2_輪外;

		public Par X5Y1_呪印_輪2_輪内;

		public Par X5Y1_呪印_輪3_輪外;

		public Par X5Y1_呪印_輪3_輪内;

		public Par X5Y1_呪印_鎖1;

		public Par X5Y1_呪印_鎖2;

		public Par X5Y1_呪印_鎖3;

		public Par X5Y2_親指;

		public Par X5Y2_手;

		public Par X5Y2_小指;

		public Par X5Y2_薬指;

		public Par X5Y2_中指;

		public Par X5Y2_人指;

		public Par X5Y2_呪印_輪1_輪外;

		public Par X5Y2_呪印_輪1_輪内;

		public Par X5Y2_呪印_輪2_輪外;

		public Par X5Y2_呪印_輪2_輪内;

		public Par X5Y2_呪印_輪3_輪外;

		public Par X5Y2_呪印_輪3_輪内;

		public Par X5Y2_呪印_鎖1;

		public Par X5Y2_呪印_鎖2;

		public Par X5Y2_呪印_鎖3;

		public Par X5Y3_親指;

		public Par X5Y3_手;

		public Par X5Y3_小指;

		public Par X5Y3_薬指;

		public Par X5Y3_中指;

		public Par X5Y3_人指;

		public Par X5Y3_呪印_輪1_輪外;

		public Par X5Y3_呪印_輪1_輪内;

		public Par X5Y3_呪印_輪2_輪外;

		public Par X5Y3_呪印_輪2_輪内;

		public Par X5Y3_呪印_輪3_輪外;

		public Par X5Y3_呪印_輪3_輪内;

		public Par X5Y3_呪印_鎖1;

		public Par X5Y3_呪印_鎖2;

		public Par X5Y3_呪印_鎖3;

		public Par X5Y4_親指;

		public Par X5Y4_手;

		public Par X5Y4_小指;

		public Par X5Y4_薬指;

		public Par X5Y4_中指;

		public Par X5Y4_人指;

		public Par X5Y4_呪印_輪1_輪外;

		public Par X5Y4_呪印_輪1_輪内;

		public Par X5Y4_呪印_輪2_輪外;

		public Par X5Y4_呪印_輪2_輪内;

		public Par X5Y4_呪印_輪3_輪外;

		public Par X5Y4_呪印_輪3_輪内;

		public Par X5Y4_呪印_鎖1;

		public Par X5Y4_呪印_鎖2;

		public Par X5Y4_呪印_鎖3;

		public Par X6Y0_親指;

		public Par X6Y0_手;

		public Par X6Y0_小指;

		public Par X6Y0_薬指;

		public Par X6Y0_中指;

		public Par X6Y0_人指;

		public Par X6Y0_呪印_輪1_輪外;

		public Par X6Y0_呪印_輪1_輪内;

		public Par X6Y0_呪印_輪2_輪外;

		public Par X6Y0_呪印_輪2_輪内;

		public Par X6Y0_呪印_輪3_輪外;

		public Par X6Y0_呪印_輪3_輪内;

		public Par X6Y0_呪印_鎖1;

		public Par X6Y0_呪印_鎖2;

		public Par X6Y0_呪印_鎖3;

		public Par X6Y1_親指;

		public Par X6Y1_手;

		public Par X6Y1_小指;

		public Par X6Y1_薬指;

		public Par X6Y1_中指;

		public Par X6Y1_人指;

		public Par X6Y1_呪印_輪1_輪外;

		public Par X6Y1_呪印_輪1_輪内;

		public Par X6Y1_呪印_輪2_輪外;

		public Par X6Y1_呪印_輪2_輪内;

		public Par X6Y1_呪印_輪3_輪外;

		public Par X6Y1_呪印_輪3_輪内;

		public Par X6Y1_呪印_鎖1;

		public Par X6Y1_呪印_鎖2;

		public Par X6Y1_呪印_鎖3;

		public Par X6Y2_親指;

		public Par X6Y2_手;

		public Par X6Y2_小指;

		public Par X6Y2_薬指;

		public Par X6Y2_中指;

		public Par X6Y2_人指;

		public Par X6Y2_呪印_輪1_輪外;

		public Par X6Y2_呪印_輪1_輪内;

		public Par X6Y2_呪印_輪2_輪外;

		public Par X6Y2_呪印_輪2_輪内;

		public Par X6Y2_呪印_輪3_輪外;

		public Par X6Y2_呪印_輪3_輪内;

		public Par X6Y2_呪印_鎖1;

		public Par X6Y2_呪印_鎖2;

		public Par X6Y2_呪印_鎖3;

		public Par X6Y3_親指;

		public Par X6Y3_手;

		public Par X6Y3_小指;

		public Par X6Y3_薬指;

		public Par X6Y3_中指;

		public Par X6Y3_人指;

		public Par X6Y3_呪印_輪1_輪外;

		public Par X6Y3_呪印_輪1_輪内;

		public Par X6Y3_呪印_輪2_輪外;

		public Par X6Y3_呪印_輪2_輪内;

		public Par X6Y3_呪印_輪3_輪外;

		public Par X6Y3_呪印_輪3_輪内;

		public Par X6Y3_呪印_鎖1;

		public Par X6Y3_呪印_鎖2;

		public Par X6Y3_呪印_鎖3;

		public Par X6Y4_親指;

		public Par X6Y4_手;

		public Par X6Y4_小指;

		public Par X6Y4_薬指;

		public Par X6Y4_中指;

		public Par X6Y4_人指;

		public Par X6Y4_呪印_輪1_輪外;

		public Par X6Y4_呪印_輪1_輪内;

		public Par X6Y4_呪印_輪2_輪外;

		public Par X6Y4_呪印_輪2_輪内;

		public Par X6Y4_呪印_輪3_輪外;

		public Par X6Y4_呪印_輪3_輪内;

		public Par X6Y4_呪印_鎖1;

		public Par X6Y4_呪印_鎖2;

		public Par X6Y4_呪印_鎖3;

		public Par X7Y0_小指;

		public Par X7Y0_薬指;

		public Par X7Y0_中指;

		public Par X7Y0_親指;

		public Par X7Y0_手;

		public Par X7Y0_人指;

		public Par X7Y0_呪印_輪1_輪外;

		public Par X7Y0_呪印_輪1_輪内;

		public Par X7Y0_呪印_輪2_輪外;

		public Par X7Y0_呪印_輪2_輪内;

		public Par X7Y0_呪印_輪3_輪外;

		public Par X7Y0_呪印_輪3_輪内;

		public Par X7Y0_呪印_鎖1;

		public Par X7Y0_呪印_鎖2;

		public Par X7Y0_呪印_鎖3;

		public Par X7Y1_小指;

		public Par X7Y1_薬指;

		public Par X7Y1_中指;

		public Par X7Y1_親指;

		public Par X7Y1_手;

		public Par X7Y1_人指;

		public Par X7Y1_呪印_輪1_輪外;

		public Par X7Y1_呪印_輪1_輪内;

		public Par X7Y1_呪印_輪2_輪外;

		public Par X7Y1_呪印_輪2_輪内;

		public Par X7Y1_呪印_輪3_輪外;

		public Par X7Y1_呪印_輪3_輪内;

		public Par X7Y1_呪印_鎖1;

		public Par X7Y1_呪印_鎖2;

		public Par X7Y1_呪印_鎖3;

		public Par X7Y2_小指;

		public Par X7Y2_薬指;

		public Par X7Y2_中指;

		public Par X7Y2_親指;

		public Par X7Y2_手;

		public Par X7Y2_人指;

		public Par X7Y2_呪印_輪1_輪外;

		public Par X7Y2_呪印_輪1_輪内;

		public Par X7Y2_呪印_輪2_輪外;

		public Par X7Y2_呪印_輪2_輪内;

		public Par X7Y2_呪印_輪3_輪外;

		public Par X7Y2_呪印_輪3_輪内;

		public Par X7Y2_呪印_鎖1;

		public Par X7Y2_呪印_鎖2;

		public Par X7Y2_呪印_鎖3;

		public Par X7Y3_小指;

		public Par X7Y3_薬指;

		public Par X7Y3_中指;

		public Par X7Y3_親指;

		public Par X7Y3_手;

		public Par X7Y3_人指;

		public Par X7Y3_呪印_輪1_輪外;

		public Par X7Y3_呪印_輪1_輪内;

		public Par X7Y3_呪印_輪2_輪外;

		public Par X7Y3_呪印_輪2_輪内;

		public Par X7Y3_呪印_輪3_輪外;

		public Par X7Y3_呪印_輪3_輪内;

		public Par X7Y3_呪印_鎖1;

		public Par X7Y3_呪印_鎖2;

		public Par X7Y3_呪印_鎖3;

		public Par X7Y4_小指;

		public Par X7Y4_薬指;

		public Par X7Y4_中指;

		public Par X7Y4_親指;

		public Par X7Y4_手;

		public Par X7Y4_人指;

		public Par X7Y4_呪印_輪1_輪外;

		public Par X7Y4_呪印_輪1_輪内;

		public Par X7Y4_呪印_輪2_輪外;

		public Par X7Y4_呪印_輪2_輪内;

		public Par X7Y4_呪印_輪3_輪外;

		public Par X7Y4_呪印_輪3_輪内;

		public Par X7Y4_呪印_鎖1;

		public Par X7Y4_呪印_鎖2;

		public Par X7Y4_呪印_鎖3;

		public Par X8Y0_手;

		public Par X8Y0_小指;

		public Par X8Y0_薬指;

		public Par X8Y0_中指;

		public Par X8Y0_人指;

		public Par X8Y0_親指;

		public Par X8Y1_手;

		public Par X8Y1_小指;

		public Par X8Y1_薬指;

		public Par X8Y1_中指;

		public Par X8Y1_人指;

		public Par X8Y1_親指;

		public Par X8Y2_手;

		public Par X8Y2_小指;

		public Par X8Y2_薬指;

		public Par X8Y2_中指;

		public Par X8Y2_人指;

		public Par X8Y2_親指;

		public Par X8Y3_手;

		public Par X8Y3_小指;

		public Par X8Y3_薬指;

		public Par X8Y3_中指;

		public Par X8Y3_人指;

		public Par X8Y3_親指;

		public Par X8Y4_手;

		public Par X8Y4_小指;

		public Par X8Y4_薬指;

		public Par X8Y4_中指;

		public Par X8Y4_人指;

		public Par X8Y4_親指;

		public Par X9Y0_手;

		public Par X9Y0_小指;

		public Par X9Y0_薬指;

		public Par X9Y0_中指;

		public Par X9Y0_人指;

		public Par X9Y0_親指;

		public Par X9Y1_手;

		public Par X9Y1_小指;

		public Par X9Y1_薬指;

		public Par X9Y1_中指;

		public Par X9Y1_人指;

		public Par X9Y1_親指;

		public Par X9Y2_手;

		public Par X9Y2_小指;

		public Par X9Y2_薬指;

		public Par X9Y2_中指;

		public Par X9Y2_人指;

		public Par X9Y2_親指;

		public Par X9Y3_手;

		public Par X9Y3_小指;

		public Par X9Y3_薬指;

		public Par X9Y3_中指;

		public Par X9Y3_人指;

		public Par X9Y3_親指;

		public Par X9Y4_手;

		public Par X9Y4_小指;

		public Par X9Y4_薬指;

		public Par X9Y4_中指;

		public Par X9Y4_人指;

		public Par X9Y4_親指;

		public Par X10Y0_親指;

		public Par X10Y0_手;

		public Par X10Y0_小指;

		public Par X10Y0_薬指;

		public Par X10Y0_中指;

		public Par X10Y0_人指;

		public Par X10Y0_呪印_輪1_輪外;

		public Par X10Y0_呪印_輪1_輪内;

		public Par X10Y0_呪印_輪2_輪外;

		public Par X10Y0_呪印_輪2_輪内;

		public Par X10Y0_呪印_輪3_輪外;

		public Par X10Y0_呪印_輪3_輪内;

		public Par X10Y0_呪印_鎖1;

		public Par X10Y0_呪印_鎖2;

		public Par X10Y0_呪印_鎖3;

		public Par X10Y1_親指;

		public Par X10Y1_手;

		public Par X10Y1_小指;

		public Par X10Y1_薬指;

		public Par X10Y1_中指;

		public Par X10Y1_人指;

		public Par X10Y1_呪印_輪1_輪外;

		public Par X10Y1_呪印_輪1_輪内;

		public Par X10Y1_呪印_輪2_輪外;

		public Par X10Y1_呪印_輪2_輪内;

		public Par X10Y1_呪印_輪3_輪外;

		public Par X10Y1_呪印_輪3_輪内;

		public Par X10Y1_呪印_鎖1;

		public Par X10Y1_呪印_鎖2;

		public Par X10Y1_呪印_鎖3;

		public Par X10Y2_親指;

		public Par X10Y2_手;

		public Par X10Y2_小指;

		public Par X10Y2_薬指;

		public Par X10Y2_中指;

		public Par X10Y2_人指;

		public Par X10Y2_呪印_輪1_輪外;

		public Par X10Y2_呪印_輪1_輪内;

		public Par X10Y2_呪印_輪2_輪外;

		public Par X10Y2_呪印_輪2_輪内;

		public Par X10Y2_呪印_輪3_輪外;

		public Par X10Y2_呪印_輪3_輪内;

		public Par X10Y2_呪印_鎖1;

		public Par X10Y2_呪印_鎖2;

		public Par X10Y2_呪印_鎖3;

		public Par X10Y3_親指;

		public Par X10Y3_手;

		public Par X10Y3_小指;

		public Par X10Y3_薬指;

		public Par X10Y3_中指;

		public Par X10Y3_人指;

		public Par X10Y3_呪印_輪1_輪外;

		public Par X10Y3_呪印_輪1_輪内;

		public Par X10Y3_呪印_輪2_輪外;

		public Par X10Y3_呪印_輪2_輪内;

		public Par X10Y3_呪印_輪3_輪外;

		public Par X10Y3_呪印_輪3_輪内;

		public Par X10Y3_呪印_鎖1;

		public Par X10Y3_呪印_鎖2;

		public Par X10Y3_呪印_鎖3;

		public Par X10Y4_親指;

		public Par X10Y4_手;

		public Par X10Y4_小指;

		public Par X10Y4_薬指;

		public Par X10Y4_中指;

		public Par X10Y4_人指;

		public Par X10Y4_呪印_輪1_輪外;

		public Par X10Y4_呪印_輪1_輪内;

		public Par X10Y4_呪印_輪2_輪外;

		public Par X10Y4_呪印_輪2_輪内;

		public Par X10Y4_呪印_輪3_輪外;

		public Par X10Y4_呪印_輪3_輪内;

		public Par X10Y4_呪印_鎖1;

		public Par X10Y4_呪印_鎖2;

		public Par X10Y4_呪印_鎖3;

		public Par X11Y0_小指;

		public Par X11Y0_薬指;

		public Par X11Y0_中指;

		public Par X11Y0_人指;

		public Par X11Y0_手;

		public Par X11Y0_親指;

		public Par X11Y0_呪印_輪1_輪外;

		public Par X11Y0_呪印_輪1_輪内;

		public Par X11Y0_呪印_輪2_輪外;

		public Par X11Y0_呪印_輪2_輪内;

		public Par X11Y0_呪印_輪3_輪外;

		public Par X11Y0_呪印_輪3_輪内;

		public Par X11Y0_呪印_鎖1;

		public Par X11Y0_呪印_鎖3;

		public Par X12Y0_親指;

		public Par X12Y0_手;

		public Par X12Y0_小指;

		public Par X12Y0_薬指;

		public Par X12Y0_中指;

		public Par X12Y0_人指;

		public Par X12Y0_呪印_輪1_輪外;

		public Par X12Y0_呪印_輪1_輪内;

		public Par X12Y0_呪印_輪2_輪外;

		public Par X12Y0_呪印_輪2_輪内;

		public Par X12Y0_呪印_輪3_輪外;

		public Par X12Y0_呪印_輪3_輪内;

		public Par X12Y0_呪印_鎖1;

		public Par X12Y0_呪印_鎖2;

		public Par X12Y0_呪印_鎖3;

		public Par X13Y0_中指;

		public Par X13Y0_人指;

		public Par X13Y0_手;

		public Par X13Y0_親指;

		public Par X13Y0_呪印_輪1_輪外;

		public Par X13Y0_呪印_輪1_輪内;

		public Par X13Y0_呪印_輪2_輪外;

		public Par X13Y0_呪印_輪2_輪内;

		public Par X13Y0_呪印_輪3_輪外;

		public Par X13Y0_呪印_輪3_輪内;

		public Par X13Y0_呪印_鎖1;

		public Par X13Y0_呪印_鎖3;

		public Par X14Y0_親指;

		public Par X14Y0_手;

		public Par X14Y0_小指;

		public Par X14Y0_薬指;

		public Par X14Y0_中指;

		public Par X14Y0_人指;

		public Par X14Y0_呪印_輪1_輪外;

		public Par X14Y0_呪印_輪1_輪内;

		public Par X14Y0_呪印_輪2_輪外;

		public Par X14Y0_呪印_輪2_輪内;

		public Par X14Y0_呪印_輪3_輪外;

		public Par X14Y0_呪印_輪3_輪内;

		public Par X14Y0_呪印_鎖1;

		public Par X14Y0_呪印_鎖2;

		public Par X14Y0_呪印_鎖3;

		public Par X14Y1_親指;

		public Par X14Y1_手;

		public Par X14Y1_小指;

		public Par X14Y1_薬指;

		public Par X14Y1_中指;

		public Par X14Y1_人指;

		public Par X14Y1_呪印_輪1_輪外;

		public Par X14Y1_呪印_輪1_輪内;

		public Par X14Y1_呪印_輪2_輪外;

		public Par X14Y1_呪印_輪2_輪内;

		public Par X14Y1_呪印_輪3_輪外;

		public Par X14Y1_呪印_輪3_輪内;

		public Par X14Y1_呪印_鎖1;

		public Par X14Y1_呪印_鎖2;

		public Par X14Y1_呪印_鎖3;

		public Par X14Y2_親指;

		public Par X14Y2_手;

		public Par X14Y2_小指;

		public Par X14Y2_薬指;

		public Par X14Y2_中指;

		public Par X14Y2_人指;

		public Par X14Y2_呪印_輪1_輪外;

		public Par X14Y2_呪印_輪1_輪内;

		public Par X14Y2_呪印_輪2_輪外;

		public Par X14Y2_呪印_輪2_輪内;

		public Par X14Y2_呪印_輪3_輪外;

		public Par X14Y2_呪印_輪3_輪内;

		public Par X14Y2_呪印_鎖1;

		public Par X14Y2_呪印_鎖2;

		public Par X14Y2_呪印_鎖3;

		public ColorD 親指CD;

		public ColorD 手CD;

		public ColorD 小指CD;

		public ColorD 薬指CD;

		public ColorD 中指CD;

		public ColorD 人指CD;

		public ColorD 呪印_輪1_輪外CD;

		public ColorD 呪印_輪1_輪内CD;

		public ColorD 呪印_輪2_輪外CD;

		public ColorD 呪印_輪2_輪内CD;

		public ColorD 呪印_輪3_輪外CD;

		public ColorD 呪印_輪3_輪内CD;

		public ColorD 呪印_鎖1CD;

		public ColorD 呪印_鎖2CD;

		public ColorD 呪印_鎖3CD;

		public ColorP X0Y0_親指CP;

		public ColorP X0Y0_手CP;

		public ColorP X0Y0_小指CP;

		public ColorP X0Y0_薬指CP;

		public ColorP X0Y0_中指CP;

		public ColorP X0Y0_人指CP;

		public ColorP X0Y0_呪印_輪1_輪外CP;

		public ColorP X0Y0_呪印_輪1_輪内CP;

		public ColorP X0Y0_呪印_輪2_輪外CP;

		public ColorP X0Y0_呪印_輪2_輪内CP;

		public ColorP X0Y0_呪印_輪3_輪外CP;

		public ColorP X0Y0_呪印_輪3_輪内CP;

		public ColorP X0Y0_呪印_鎖1CP;

		public ColorP X0Y0_呪印_鎖2CP;

		public ColorP X0Y0_呪印_鎖3CP;

		public ColorP X1Y0_親指CP;

		public ColorP X1Y0_手CP;

		public ColorP X1Y0_小指CP;

		public ColorP X1Y0_薬指CP;

		public ColorP X1Y0_中指CP;

		public ColorP X1Y0_人指CP;

		public ColorP X1Y0_呪印_輪1_輪外CP;

		public ColorP X1Y0_呪印_輪1_輪内CP;

		public ColorP X1Y0_呪印_輪2_輪外CP;

		public ColorP X1Y0_呪印_輪2_輪内CP;

		public ColorP X1Y0_呪印_輪3_輪外CP;

		public ColorP X1Y0_呪印_輪3_輪内CP;

		public ColorP X1Y0_呪印_鎖1CP;

		public ColorP X1Y0_呪印_鎖2CP;

		public ColorP X1Y0_呪印_鎖3CP;

		public ColorP X2Y0_親指CP;

		public ColorP X2Y0_手CP;

		public ColorP X2Y0_小指CP;

		public ColorP X2Y0_薬指CP;

		public ColorP X2Y0_中指CP;

		public ColorP X2Y0_人指CP;

		public ColorP X2Y0_呪印_輪1_輪外CP;

		public ColorP X2Y0_呪印_輪1_輪内CP;

		public ColorP X2Y0_呪印_輪2_輪外CP;

		public ColorP X2Y0_呪印_輪2_輪内CP;

		public ColorP X2Y0_呪印_輪3_輪外CP;

		public ColorP X2Y0_呪印_輪3_輪内CP;

		public ColorP X2Y0_呪印_鎖1CP;

		public ColorP X2Y0_呪印_鎖2CP;

		public ColorP X2Y0_呪印_鎖3CP;

		public ColorP X2Y1_親指CP;

		public ColorP X2Y1_手CP;

		public ColorP X2Y1_小指CP;

		public ColorP X2Y1_薬指CP;

		public ColorP X2Y1_中指CP;

		public ColorP X2Y1_人指CP;

		public ColorP X2Y1_呪印_輪1_輪外CP;

		public ColorP X2Y1_呪印_輪1_輪内CP;

		public ColorP X2Y1_呪印_輪2_輪外CP;

		public ColorP X2Y1_呪印_輪2_輪内CP;

		public ColorP X2Y1_呪印_輪3_輪外CP;

		public ColorP X2Y1_呪印_輪3_輪内CP;

		public ColorP X2Y1_呪印_鎖1CP;

		public ColorP X2Y1_呪印_鎖2CP;

		public ColorP X2Y1_呪印_鎖3CP;

		public ColorP X2Y2_親指CP;

		public ColorP X2Y2_手CP;

		public ColorP X2Y2_小指CP;

		public ColorP X2Y2_薬指CP;

		public ColorP X2Y2_中指CP;

		public ColorP X2Y2_人指CP;

		public ColorP X2Y2_呪印_輪1_輪外CP;

		public ColorP X2Y2_呪印_輪1_輪内CP;

		public ColorP X2Y2_呪印_輪2_輪外CP;

		public ColorP X2Y2_呪印_輪2_輪内CP;

		public ColorP X2Y2_呪印_輪3_輪外CP;

		public ColorP X2Y2_呪印_輪3_輪内CP;

		public ColorP X2Y2_呪印_鎖1CP;

		public ColorP X2Y2_呪印_鎖2CP;

		public ColorP X2Y2_呪印_鎖3CP;

		public ColorP X2Y3_親指CP;

		public ColorP X2Y3_手CP;

		public ColorP X2Y3_小指CP;

		public ColorP X2Y3_薬指CP;

		public ColorP X2Y3_中指CP;

		public ColorP X2Y3_人指CP;

		public ColorP X2Y3_呪印_輪1_輪外CP;

		public ColorP X2Y3_呪印_輪1_輪内CP;

		public ColorP X2Y3_呪印_輪2_輪外CP;

		public ColorP X2Y3_呪印_輪2_輪内CP;

		public ColorP X2Y3_呪印_輪3_輪外CP;

		public ColorP X2Y3_呪印_輪3_輪内CP;

		public ColorP X2Y3_呪印_鎖1CP;

		public ColorP X2Y3_呪印_鎖2CP;

		public ColorP X2Y3_呪印_鎖3CP;

		public ColorP X2Y4_親指CP;

		public ColorP X2Y4_手CP;

		public ColorP X2Y4_小指CP;

		public ColorP X2Y4_薬指CP;

		public ColorP X2Y4_中指CP;

		public ColorP X2Y4_人指CP;

		public ColorP X2Y4_呪印_輪1_輪外CP;

		public ColorP X2Y4_呪印_輪1_輪内CP;

		public ColorP X2Y4_呪印_輪2_輪外CP;

		public ColorP X2Y4_呪印_輪2_輪内CP;

		public ColorP X2Y4_呪印_輪3_輪外CP;

		public ColorP X2Y4_呪印_輪3_輪内CP;

		public ColorP X2Y4_呪印_鎖1CP;

		public ColorP X2Y4_呪印_鎖2CP;

		public ColorP X2Y4_呪印_鎖3CP;

		public ColorP X3Y0_親指CP;

		public ColorP X3Y0_手CP;

		public ColorP X3Y0_小指CP;

		public ColorP X3Y0_薬指CP;

		public ColorP X3Y0_中指CP;

		public ColorP X3Y0_人指CP;

		public ColorP X3Y0_呪印_輪1_輪外CP;

		public ColorP X3Y0_呪印_輪1_輪内CP;

		public ColorP X3Y0_呪印_輪2_輪外CP;

		public ColorP X3Y0_呪印_輪2_輪内CP;

		public ColorP X3Y0_呪印_輪3_輪外CP;

		public ColorP X3Y0_呪印_輪3_輪内CP;

		public ColorP X3Y0_呪印_鎖1CP;

		public ColorP X3Y0_呪印_鎖2CP;

		public ColorP X3Y0_呪印_鎖3CP;

		public ColorP X4Y0_親指CP;

		public ColorP X4Y0_手CP;

		public ColorP X4Y0_小指CP;

		public ColorP X4Y0_薬指CP;

		public ColorP X4Y0_中指CP;

		public ColorP X4Y0_人指CP;

		public ColorP X4Y0_呪印_輪1_輪外CP;

		public ColorP X4Y0_呪印_輪1_輪内CP;

		public ColorP X4Y0_呪印_輪2_輪外CP;

		public ColorP X4Y0_呪印_輪2_輪内CP;

		public ColorP X4Y0_呪印_輪3_輪外CP;

		public ColorP X4Y0_呪印_輪3_輪内CP;

		public ColorP X4Y0_呪印_鎖1CP;

		public ColorP X4Y0_呪印_鎖2CP;

		public ColorP X4Y0_呪印_鎖3CP;

		public ColorP X5Y0_親指CP;

		public ColorP X5Y0_手CP;

		public ColorP X5Y0_小指CP;

		public ColorP X5Y0_薬指CP;

		public ColorP X5Y0_中指CP;

		public ColorP X5Y0_人指CP;

		public ColorP X5Y0_呪印_輪1_輪外CP;

		public ColorP X5Y0_呪印_輪1_輪内CP;

		public ColorP X5Y0_呪印_輪2_輪外CP;

		public ColorP X5Y0_呪印_輪2_輪内CP;

		public ColorP X5Y0_呪印_輪3_輪外CP;

		public ColorP X5Y0_呪印_輪3_輪内CP;

		public ColorP X5Y0_呪印_鎖1CP;

		public ColorP X5Y0_呪印_鎖2CP;

		public ColorP X5Y0_呪印_鎖3CP;

		public ColorP X5Y1_親指CP;

		public ColorP X5Y1_手CP;

		public ColorP X5Y1_小指CP;

		public ColorP X5Y1_薬指CP;

		public ColorP X5Y1_中指CP;

		public ColorP X5Y1_人指CP;

		public ColorP X5Y1_呪印_輪1_輪外CP;

		public ColorP X5Y1_呪印_輪1_輪内CP;

		public ColorP X5Y1_呪印_輪2_輪外CP;

		public ColorP X5Y1_呪印_輪2_輪内CP;

		public ColorP X5Y1_呪印_輪3_輪外CP;

		public ColorP X5Y1_呪印_輪3_輪内CP;

		public ColorP X5Y1_呪印_鎖1CP;

		public ColorP X5Y1_呪印_鎖2CP;

		public ColorP X5Y1_呪印_鎖3CP;

		public ColorP X5Y2_親指CP;

		public ColorP X5Y2_手CP;

		public ColorP X5Y2_小指CP;

		public ColorP X5Y2_薬指CP;

		public ColorP X5Y2_中指CP;

		public ColorP X5Y2_人指CP;

		public ColorP X5Y2_呪印_輪1_輪外CP;

		public ColorP X5Y2_呪印_輪1_輪内CP;

		public ColorP X5Y2_呪印_輪2_輪外CP;

		public ColorP X5Y2_呪印_輪2_輪内CP;

		public ColorP X5Y2_呪印_輪3_輪外CP;

		public ColorP X5Y2_呪印_輪3_輪内CP;

		public ColorP X5Y2_呪印_鎖1CP;

		public ColorP X5Y2_呪印_鎖2CP;

		public ColorP X5Y2_呪印_鎖3CP;

		public ColorP X5Y3_親指CP;

		public ColorP X5Y3_手CP;

		public ColorP X5Y3_小指CP;

		public ColorP X5Y3_薬指CP;

		public ColorP X5Y3_中指CP;

		public ColorP X5Y3_人指CP;

		public ColorP X5Y3_呪印_輪1_輪外CP;

		public ColorP X5Y3_呪印_輪1_輪内CP;

		public ColorP X5Y3_呪印_輪2_輪外CP;

		public ColorP X5Y3_呪印_輪2_輪内CP;

		public ColorP X5Y3_呪印_輪3_輪外CP;

		public ColorP X5Y3_呪印_輪3_輪内CP;

		public ColorP X5Y3_呪印_鎖1CP;

		public ColorP X5Y3_呪印_鎖2CP;

		public ColorP X5Y3_呪印_鎖3CP;

		public ColorP X5Y4_親指CP;

		public ColorP X5Y4_手CP;

		public ColorP X5Y4_小指CP;

		public ColorP X5Y4_薬指CP;

		public ColorP X5Y4_中指CP;

		public ColorP X5Y4_人指CP;

		public ColorP X5Y4_呪印_輪1_輪外CP;

		public ColorP X5Y4_呪印_輪1_輪内CP;

		public ColorP X5Y4_呪印_輪2_輪外CP;

		public ColorP X5Y4_呪印_輪2_輪内CP;

		public ColorP X5Y4_呪印_輪3_輪外CP;

		public ColorP X5Y4_呪印_輪3_輪内CP;

		public ColorP X5Y4_呪印_鎖1CP;

		public ColorP X5Y4_呪印_鎖2CP;

		public ColorP X5Y4_呪印_鎖3CP;

		public ColorP X6Y0_親指CP;

		public ColorP X6Y0_手CP;

		public ColorP X6Y0_小指CP;

		public ColorP X6Y0_薬指CP;

		public ColorP X6Y0_中指CP;

		public ColorP X6Y0_人指CP;

		public ColorP X6Y0_呪印_輪1_輪外CP;

		public ColorP X6Y0_呪印_輪1_輪内CP;

		public ColorP X6Y0_呪印_輪2_輪外CP;

		public ColorP X6Y0_呪印_輪2_輪内CP;

		public ColorP X6Y0_呪印_輪3_輪外CP;

		public ColorP X6Y0_呪印_輪3_輪内CP;

		public ColorP X6Y0_呪印_鎖1CP;

		public ColorP X6Y0_呪印_鎖2CP;

		public ColorP X6Y0_呪印_鎖3CP;

		public ColorP X6Y1_親指CP;

		public ColorP X6Y1_手CP;

		public ColorP X6Y1_小指CP;

		public ColorP X6Y1_薬指CP;

		public ColorP X6Y1_中指CP;

		public ColorP X6Y1_人指CP;

		public ColorP X6Y1_呪印_輪1_輪外CP;

		public ColorP X6Y1_呪印_輪1_輪内CP;

		public ColorP X6Y1_呪印_輪2_輪外CP;

		public ColorP X6Y1_呪印_輪2_輪内CP;

		public ColorP X6Y1_呪印_輪3_輪外CP;

		public ColorP X6Y1_呪印_輪3_輪内CP;

		public ColorP X6Y1_呪印_鎖1CP;

		public ColorP X6Y1_呪印_鎖2CP;

		public ColorP X6Y1_呪印_鎖3CP;

		public ColorP X6Y2_親指CP;

		public ColorP X6Y2_手CP;

		public ColorP X6Y2_小指CP;

		public ColorP X6Y2_薬指CP;

		public ColorP X6Y2_中指CP;

		public ColorP X6Y2_人指CP;

		public ColorP X6Y2_呪印_輪1_輪外CP;

		public ColorP X6Y2_呪印_輪1_輪内CP;

		public ColorP X6Y2_呪印_輪2_輪外CP;

		public ColorP X6Y2_呪印_輪2_輪内CP;

		public ColorP X6Y2_呪印_輪3_輪外CP;

		public ColorP X6Y2_呪印_輪3_輪内CP;

		public ColorP X6Y2_呪印_鎖1CP;

		public ColorP X6Y2_呪印_鎖2CP;

		public ColorP X6Y2_呪印_鎖3CP;

		public ColorP X6Y3_親指CP;

		public ColorP X6Y3_手CP;

		public ColorP X6Y3_小指CP;

		public ColorP X6Y3_薬指CP;

		public ColorP X6Y3_中指CP;

		public ColorP X6Y3_人指CP;

		public ColorP X6Y3_呪印_輪1_輪外CP;

		public ColorP X6Y3_呪印_輪1_輪内CP;

		public ColorP X6Y3_呪印_輪2_輪外CP;

		public ColorP X6Y3_呪印_輪2_輪内CP;

		public ColorP X6Y3_呪印_輪3_輪外CP;

		public ColorP X6Y3_呪印_輪3_輪内CP;

		public ColorP X6Y3_呪印_鎖1CP;

		public ColorP X6Y3_呪印_鎖2CP;

		public ColorP X6Y3_呪印_鎖3CP;

		public ColorP X6Y4_親指CP;

		public ColorP X6Y4_手CP;

		public ColorP X6Y4_小指CP;

		public ColorP X6Y4_薬指CP;

		public ColorP X6Y4_中指CP;

		public ColorP X6Y4_人指CP;

		public ColorP X6Y4_呪印_輪1_輪外CP;

		public ColorP X6Y4_呪印_輪1_輪内CP;

		public ColorP X6Y4_呪印_輪2_輪外CP;

		public ColorP X6Y4_呪印_輪2_輪内CP;

		public ColorP X6Y4_呪印_輪3_輪外CP;

		public ColorP X6Y4_呪印_輪3_輪内CP;

		public ColorP X6Y4_呪印_鎖1CP;

		public ColorP X6Y4_呪印_鎖2CP;

		public ColorP X6Y4_呪印_鎖3CP;

		public ColorP X7Y0_小指CP;

		public ColorP X7Y0_薬指CP;

		public ColorP X7Y0_中指CP;

		public ColorP X7Y0_親指CP;

		public ColorP X7Y0_手CP;

		public ColorP X7Y0_人指CP;

		public ColorP X7Y0_呪印_輪1_輪外CP;

		public ColorP X7Y0_呪印_輪1_輪内CP;

		public ColorP X7Y0_呪印_輪2_輪外CP;

		public ColorP X7Y0_呪印_輪2_輪内CP;

		public ColorP X7Y0_呪印_輪3_輪外CP;

		public ColorP X7Y0_呪印_輪3_輪内CP;

		public ColorP X7Y0_呪印_鎖1CP;

		public ColorP X7Y0_呪印_鎖2CP;

		public ColorP X7Y0_呪印_鎖3CP;

		public ColorP X7Y1_小指CP;

		public ColorP X7Y1_薬指CP;

		public ColorP X7Y1_中指CP;

		public ColorP X7Y1_親指CP;

		public ColorP X7Y1_手CP;

		public ColorP X7Y1_人指CP;

		public ColorP X7Y1_呪印_輪1_輪外CP;

		public ColorP X7Y1_呪印_輪1_輪内CP;

		public ColorP X7Y1_呪印_輪2_輪外CP;

		public ColorP X7Y1_呪印_輪2_輪内CP;

		public ColorP X7Y1_呪印_輪3_輪外CP;

		public ColorP X7Y1_呪印_輪3_輪内CP;

		public ColorP X7Y1_呪印_鎖1CP;

		public ColorP X7Y1_呪印_鎖2CP;

		public ColorP X7Y1_呪印_鎖3CP;

		public ColorP X7Y2_小指CP;

		public ColorP X7Y2_薬指CP;

		public ColorP X7Y2_中指CP;

		public ColorP X7Y2_親指CP;

		public ColorP X7Y2_手CP;

		public ColorP X7Y2_人指CP;

		public ColorP X7Y2_呪印_輪1_輪外CP;

		public ColorP X7Y2_呪印_輪1_輪内CP;

		public ColorP X7Y2_呪印_輪2_輪外CP;

		public ColorP X7Y2_呪印_輪2_輪内CP;

		public ColorP X7Y2_呪印_輪3_輪外CP;

		public ColorP X7Y2_呪印_輪3_輪内CP;

		public ColorP X7Y2_呪印_鎖1CP;

		public ColorP X7Y2_呪印_鎖2CP;

		public ColorP X7Y2_呪印_鎖3CP;

		public ColorP X7Y3_小指CP;

		public ColorP X7Y3_薬指CP;

		public ColorP X7Y3_中指CP;

		public ColorP X7Y3_親指CP;

		public ColorP X7Y3_手CP;

		public ColorP X7Y3_人指CP;

		public ColorP X7Y3_呪印_輪1_輪外CP;

		public ColorP X7Y3_呪印_輪1_輪内CP;

		public ColorP X7Y3_呪印_輪2_輪外CP;

		public ColorP X7Y3_呪印_輪2_輪内CP;

		public ColorP X7Y3_呪印_輪3_輪外CP;

		public ColorP X7Y3_呪印_輪3_輪内CP;

		public ColorP X7Y3_呪印_鎖1CP;

		public ColorP X7Y3_呪印_鎖2CP;

		public ColorP X7Y3_呪印_鎖3CP;

		public ColorP X7Y4_小指CP;

		public ColorP X7Y4_薬指CP;

		public ColorP X7Y4_中指CP;

		public ColorP X7Y4_親指CP;

		public ColorP X7Y4_手CP;

		public ColorP X7Y4_人指CP;

		public ColorP X7Y4_呪印_輪1_輪外CP;

		public ColorP X7Y4_呪印_輪1_輪内CP;

		public ColorP X7Y4_呪印_輪2_輪外CP;

		public ColorP X7Y4_呪印_輪2_輪内CP;

		public ColorP X7Y4_呪印_輪3_輪外CP;

		public ColorP X7Y4_呪印_輪3_輪内CP;

		public ColorP X7Y4_呪印_鎖1CP;

		public ColorP X7Y4_呪印_鎖2CP;

		public ColorP X7Y4_呪印_鎖3CP;

		public ColorP X8Y0_手CP;

		public ColorP X8Y0_小指CP;

		public ColorP X8Y0_薬指CP;

		public ColorP X8Y0_中指CP;

		public ColorP X8Y0_人指CP;

		public ColorP X8Y0_親指CP;

		public ColorP X8Y1_手CP;

		public ColorP X8Y1_小指CP;

		public ColorP X8Y1_薬指CP;

		public ColorP X8Y1_中指CP;

		public ColorP X8Y1_人指CP;

		public ColorP X8Y1_親指CP;

		public ColorP X8Y2_手CP;

		public ColorP X8Y2_小指CP;

		public ColorP X8Y2_薬指CP;

		public ColorP X8Y2_中指CP;

		public ColorP X8Y2_人指CP;

		public ColorP X8Y2_親指CP;

		public ColorP X8Y3_手CP;

		public ColorP X8Y3_小指CP;

		public ColorP X8Y3_薬指CP;

		public ColorP X8Y3_中指CP;

		public ColorP X8Y3_人指CP;

		public ColorP X8Y3_親指CP;

		public ColorP X8Y4_手CP;

		public ColorP X8Y4_小指CP;

		public ColorP X8Y4_薬指CP;

		public ColorP X8Y4_中指CP;

		public ColorP X8Y4_人指CP;

		public ColorP X8Y4_親指CP;

		public ColorP X9Y0_手CP;

		public ColorP X9Y0_小指CP;

		public ColorP X9Y0_薬指CP;

		public ColorP X9Y0_中指CP;

		public ColorP X9Y0_人指CP;

		public ColorP X9Y0_親指CP;

		public ColorP X9Y1_手CP;

		public ColorP X9Y1_小指CP;

		public ColorP X9Y1_薬指CP;

		public ColorP X9Y1_中指CP;

		public ColorP X9Y1_人指CP;

		public ColorP X9Y1_親指CP;

		public ColorP X9Y2_手CP;

		public ColorP X9Y2_小指CP;

		public ColorP X9Y2_薬指CP;

		public ColorP X9Y2_中指CP;

		public ColorP X9Y2_人指CP;

		public ColorP X9Y2_親指CP;

		public ColorP X9Y3_手CP;

		public ColorP X9Y3_小指CP;

		public ColorP X9Y3_薬指CP;

		public ColorP X9Y3_中指CP;

		public ColorP X9Y3_人指CP;

		public ColorP X9Y3_親指CP;

		public ColorP X9Y4_手CP;

		public ColorP X9Y4_小指CP;

		public ColorP X9Y4_薬指CP;

		public ColorP X9Y4_中指CP;

		public ColorP X9Y4_人指CP;

		public ColorP X9Y4_親指CP;

		public ColorP X10Y0_親指CP;

		public ColorP X10Y0_手CP;

		public ColorP X10Y0_小指CP;

		public ColorP X10Y0_薬指CP;

		public ColorP X10Y0_中指CP;

		public ColorP X10Y0_人指CP;

		public ColorP X10Y0_呪印_輪1_輪外CP;

		public ColorP X10Y0_呪印_輪1_輪内CP;

		public ColorP X10Y0_呪印_輪2_輪外CP;

		public ColorP X10Y0_呪印_輪2_輪内CP;

		public ColorP X10Y0_呪印_輪3_輪外CP;

		public ColorP X10Y0_呪印_輪3_輪内CP;

		public ColorP X10Y0_呪印_鎖1CP;

		public ColorP X10Y0_呪印_鎖2CP;

		public ColorP X10Y0_呪印_鎖3CP;

		public ColorP X10Y1_親指CP;

		public ColorP X10Y1_手CP;

		public ColorP X10Y1_小指CP;

		public ColorP X10Y1_薬指CP;

		public ColorP X10Y1_中指CP;

		public ColorP X10Y1_人指CP;

		public ColorP X10Y1_呪印_輪1_輪外CP;

		public ColorP X10Y1_呪印_輪1_輪内CP;

		public ColorP X10Y1_呪印_輪2_輪外CP;

		public ColorP X10Y1_呪印_輪2_輪内CP;

		public ColorP X10Y1_呪印_輪3_輪外CP;

		public ColorP X10Y1_呪印_輪3_輪内CP;

		public ColorP X10Y1_呪印_鎖1CP;

		public ColorP X10Y1_呪印_鎖2CP;

		public ColorP X10Y1_呪印_鎖3CP;

		public ColorP X10Y2_親指CP;

		public ColorP X10Y2_手CP;

		public ColorP X10Y2_小指CP;

		public ColorP X10Y2_薬指CP;

		public ColorP X10Y2_中指CP;

		public ColorP X10Y2_人指CP;

		public ColorP X10Y2_呪印_輪1_輪外CP;

		public ColorP X10Y2_呪印_輪1_輪内CP;

		public ColorP X10Y2_呪印_輪2_輪外CP;

		public ColorP X10Y2_呪印_輪2_輪内CP;

		public ColorP X10Y2_呪印_輪3_輪外CP;

		public ColorP X10Y2_呪印_輪3_輪内CP;

		public ColorP X10Y2_呪印_鎖1CP;

		public ColorP X10Y2_呪印_鎖2CP;

		public ColorP X10Y2_呪印_鎖3CP;

		public ColorP X10Y3_親指CP;

		public ColorP X10Y3_手CP;

		public ColorP X10Y3_小指CP;

		public ColorP X10Y3_薬指CP;

		public ColorP X10Y3_中指CP;

		public ColorP X10Y3_人指CP;

		public ColorP X10Y3_呪印_輪1_輪外CP;

		public ColorP X10Y3_呪印_輪1_輪内CP;

		public ColorP X10Y3_呪印_輪2_輪外CP;

		public ColorP X10Y3_呪印_輪2_輪内CP;

		public ColorP X10Y3_呪印_輪3_輪外CP;

		public ColorP X10Y3_呪印_輪3_輪内CP;

		public ColorP X10Y3_呪印_鎖1CP;

		public ColorP X10Y3_呪印_鎖2CP;

		public ColorP X10Y3_呪印_鎖3CP;

		public ColorP X10Y4_親指CP;

		public ColorP X10Y4_手CP;

		public ColorP X10Y4_小指CP;

		public ColorP X10Y4_薬指CP;

		public ColorP X10Y4_中指CP;

		public ColorP X10Y4_人指CP;

		public ColorP X10Y4_呪印_輪1_輪外CP;

		public ColorP X10Y4_呪印_輪1_輪内CP;

		public ColorP X10Y4_呪印_輪2_輪外CP;

		public ColorP X10Y4_呪印_輪2_輪内CP;

		public ColorP X10Y4_呪印_輪3_輪外CP;

		public ColorP X10Y4_呪印_輪3_輪内CP;

		public ColorP X10Y4_呪印_鎖1CP;

		public ColorP X10Y4_呪印_鎖2CP;

		public ColorP X10Y4_呪印_鎖3CP;

		public ColorP X11Y0_小指CP;

		public ColorP X11Y0_薬指CP;

		public ColorP X11Y0_中指CP;

		public ColorP X11Y0_人指CP;

		public ColorP X11Y0_手CP;

		public ColorP X11Y0_親指CP;

		public ColorP X11Y0_呪印_輪1_輪外CP;

		public ColorP X11Y0_呪印_輪1_輪内CP;

		public ColorP X11Y0_呪印_輪2_輪外CP;

		public ColorP X11Y0_呪印_輪2_輪内CP;

		public ColorP X11Y0_呪印_輪3_輪外CP;

		public ColorP X11Y0_呪印_輪3_輪内CP;

		public ColorP X11Y0_呪印_鎖1CP;

		public ColorP X11Y0_呪印_鎖3CP;

		public ColorP X12Y0_親指CP;

		public ColorP X12Y0_手CP;

		public ColorP X12Y0_小指CP;

		public ColorP X12Y0_薬指CP;

		public ColorP X12Y0_中指CP;

		public ColorP X12Y0_人指CP;

		public ColorP X12Y0_呪印_輪1_輪外CP;

		public ColorP X12Y0_呪印_輪1_輪内CP;

		public ColorP X12Y0_呪印_輪2_輪外CP;

		public ColorP X12Y0_呪印_輪2_輪内CP;

		public ColorP X12Y0_呪印_輪3_輪外CP;

		public ColorP X12Y0_呪印_輪3_輪内CP;

		public ColorP X12Y0_呪印_鎖1CP;

		public ColorP X12Y0_呪印_鎖2CP;

		public ColorP X12Y0_呪印_鎖3CP;

		public ColorP X13Y0_中指CP;

		public ColorP X13Y0_人指CP;

		public ColorP X13Y0_手CP;

		public ColorP X13Y0_親指CP;

		public ColorP X13Y0_呪印_輪1_輪外CP;

		public ColorP X13Y0_呪印_輪1_輪内CP;

		public ColorP X13Y0_呪印_輪2_輪外CP;

		public ColorP X13Y0_呪印_輪2_輪内CP;

		public ColorP X13Y0_呪印_輪3_輪外CP;

		public ColorP X13Y0_呪印_輪3_輪内CP;

		public ColorP X13Y0_呪印_鎖1CP;

		public ColorP X13Y0_呪印_鎖3CP;

		public ColorP X14Y0_親指CP;

		public ColorP X14Y0_手CP;

		public ColorP X14Y0_小指CP;

		public ColorP X14Y0_薬指CP;

		public ColorP X14Y0_中指CP;

		public ColorP X14Y0_人指CP;

		public ColorP X14Y0_呪印_輪1_輪外CP;

		public ColorP X14Y0_呪印_輪1_輪内CP;

		public ColorP X14Y0_呪印_輪2_輪外CP;

		public ColorP X14Y0_呪印_輪2_輪内CP;

		public ColorP X14Y0_呪印_輪3_輪外CP;

		public ColorP X14Y0_呪印_輪3_輪内CP;

		public ColorP X14Y0_呪印_鎖1CP;

		public ColorP X14Y0_呪印_鎖2CP;

		public ColorP X14Y0_呪印_鎖3CP;

		public ColorP X14Y1_親指CP;

		public ColorP X14Y1_手CP;

		public ColorP X14Y1_小指CP;

		public ColorP X14Y1_薬指CP;

		public ColorP X14Y1_中指CP;

		public ColorP X14Y1_人指CP;

		public ColorP X14Y1_呪印_輪1_輪外CP;

		public ColorP X14Y1_呪印_輪1_輪内CP;

		public ColorP X14Y1_呪印_輪2_輪外CP;

		public ColorP X14Y1_呪印_輪2_輪内CP;

		public ColorP X14Y1_呪印_輪3_輪外CP;

		public ColorP X14Y1_呪印_輪3_輪内CP;

		public ColorP X14Y1_呪印_鎖1CP;

		public ColorP X14Y1_呪印_鎖2CP;

		public ColorP X14Y1_呪印_鎖3CP;

		public ColorP X14Y2_親指CP;

		public ColorP X14Y2_手CP;

		public ColorP X14Y2_小指CP;

		public ColorP X14Y2_薬指CP;

		public ColorP X14Y2_中指CP;

		public ColorP X14Y2_人指CP;

		public ColorP X14Y2_呪印_輪1_輪外CP;

		public ColorP X14Y2_呪印_輪1_輪内CP;

		public ColorP X14Y2_呪印_輪2_輪外CP;

		public ColorP X14Y2_呪印_輪2_輪内CP;

		public ColorP X14Y2_呪印_輪3_輪外CP;

		public ColorP X14Y2_呪印_輪3_輪内CP;

		public ColorP X14Y2_呪印_鎖1CP;

		public ColorP X14Y2_呪印_鎖2CP;

		public ColorP X14Y2_呪印_鎖3CP;

		private Vector2D[] mm;

		private Par[] X6Y0Pars;

		private Par[] X6Y1Pars;

		private Par[] X6Y2Pars;

		private Par[] X6Y3Pars;

		private Par[] X6Y4Pars;

		private Par[] X7Y0Pars;

		private Par[] X7Y1Pars;

		private Par[] X7Y2Pars;

		private Par[] X7Y3Pars;

		private Par[] X7Y4Pars;
	}
}
