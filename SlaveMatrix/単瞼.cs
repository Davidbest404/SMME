using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 単瞼 : Ele
	{
		public 単瞼(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 単瞼D e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.胴体["単眼瞼"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_瞼下 = pars["瞼下"].ToPar();
			this.X0Y0_瞼上 = pars["瞼上"].ToPar();
			this.X0Y0_二重 = pars["二重"].ToPar();
			this.X0Y0_睫毛上上左 = pars["睫毛上上左"].ToPar();
			this.X0Y0_睫毛上中左 = pars["睫毛上中左"].ToPar();
			this.X0Y0_睫毛上下左 = pars["睫毛上下左"].ToPar();
			this.X0Y0_睫毛上上右 = pars["睫毛上上右"].ToPar();
			this.X0Y0_睫毛上中右 = pars["睫毛上中右"].ToPar();
			this.X0Y0_睫毛上下右 = pars["睫毛上下右"].ToPar();
			this.X0Y0_睫毛下上左 = pars["睫毛下上左"].ToPar();
			this.X0Y0_睫毛下下左 = pars["睫毛下下左"].ToPar();
			this.X0Y0_睫毛下上右 = pars["睫毛下上右"].ToPar();
			this.X0Y0_睫毛下下右 = pars["睫毛下下右"].ToPar();
			pars = this.本体[0][1];
			this.X0Y1_瞼下 = pars["瞼下"].ToPar();
			this.X0Y1_瞼上 = pars["瞼上"].ToPar();
			this.X0Y1_二重 = pars["二重"].ToPar();
			this.X0Y1_睫毛上上左 = pars["睫毛上上左"].ToPar();
			this.X0Y1_睫毛上中左 = pars["睫毛上中左"].ToPar();
			this.X0Y1_睫毛上下左 = pars["睫毛上下左"].ToPar();
			this.X0Y1_睫毛上上右 = pars["睫毛上上右"].ToPar();
			this.X0Y1_睫毛上中右 = pars["睫毛上中右"].ToPar();
			this.X0Y1_睫毛上下右 = pars["睫毛上下右"].ToPar();
			this.X0Y1_睫毛下上左 = pars["睫毛下上左"].ToPar();
			this.X0Y1_睫毛下下左 = pars["睫毛下下左"].ToPar();
			this.X0Y1_睫毛下上右 = pars["睫毛下上右"].ToPar();
			this.X0Y1_睫毛下下右 = pars["睫毛下下右"].ToPar();
			pars = this.本体[0][2];
			this.X0Y2_瞼下 = pars["瞼下"].ToPar();
			this.X0Y2_瞼上 = pars["瞼上"].ToPar();
			this.X0Y2_二重 = pars["二重"].ToPar();
			this.X0Y2_睫毛上上左 = pars["睫毛上上左"].ToPar();
			this.X0Y2_睫毛上中左 = pars["睫毛上中左"].ToPar();
			this.X0Y2_睫毛上下左 = pars["睫毛上下左"].ToPar();
			this.X0Y2_睫毛上上右 = pars["睫毛上上右"].ToPar();
			this.X0Y2_睫毛上中右 = pars["睫毛上中右"].ToPar();
			this.X0Y2_睫毛上下右 = pars["睫毛上下右"].ToPar();
			this.X0Y2_睫毛下上左 = pars["睫毛下上左"].ToPar();
			this.X0Y2_睫毛下下左 = pars["睫毛下下左"].ToPar();
			this.X0Y2_睫毛下上右 = pars["睫毛下上右"].ToPar();
			this.X0Y2_睫毛下下右 = pars["睫毛下下右"].ToPar();
			pars = this.本体[0][3];
			this.X0Y3_瞼下 = pars["瞼下"].ToPar();
			this.X0Y3_瞼上 = pars["瞼上"].ToPar();
			this.X0Y3_二重 = pars["二重"].ToPar();
			this.X0Y3_睫毛上上左 = pars["睫毛上上左"].ToPar();
			this.X0Y3_睫毛上中左 = pars["睫毛上中左"].ToPar();
			this.X0Y3_睫毛上下左 = pars["睫毛上下左"].ToPar();
			this.X0Y3_睫毛上上右 = pars["睫毛上上右"].ToPar();
			this.X0Y3_睫毛上中右 = pars["睫毛上中右"].ToPar();
			this.X0Y3_睫毛上下右 = pars["睫毛上下右"].ToPar();
			this.X0Y3_睫毛下上左 = pars["睫毛下上左"].ToPar();
			this.X0Y3_睫毛下下左 = pars["睫毛下下左"].ToPar();
			this.X0Y3_睫毛下上右 = pars["睫毛下上右"].ToPar();
			this.X0Y3_睫毛下下右 = pars["睫毛下下右"].ToPar();
			pars = this.本体[0][4];
			this.X0Y4_瞼下 = pars["瞼下"].ToPar();
			this.X0Y4_瞼上 = pars["瞼上"].ToPar();
			this.X0Y4_二重 = pars["二重"].ToPar();
			this.X0Y4_睫毛上上左 = pars["睫毛上上左"].ToPar();
			this.X0Y4_睫毛上中左 = pars["睫毛上中左"].ToPar();
			this.X0Y4_睫毛上下左 = pars["睫毛上下左"].ToPar();
			this.X0Y4_睫毛上上右 = pars["睫毛上上右"].ToPar();
			this.X0Y4_睫毛上中右 = pars["睫毛上中右"].ToPar();
			this.X0Y4_睫毛上下右 = pars["睫毛上下右"].ToPar();
			this.X0Y4_睫毛下上左 = pars["睫毛下上左"].ToPar();
			this.X0Y4_睫毛下下左 = pars["睫毛下下左"].ToPar();
			this.X0Y4_睫毛下上右 = pars["睫毛下上右"].ToPar();
			this.X0Y4_睫毛下下右 = pars["睫毛下下右"].ToPar();
			pars = this.本体[1][0];
			this.X1Y0_瞼下 = pars["瞼下"].ToPar();
			this.X1Y0_瞼上 = pars["瞼上"].ToPar();
			this.X1Y0_二重 = pars["二重"].ToPar();
			this.X1Y0_睫毛上上左 = pars["睫毛上上左"].ToPar();
			this.X1Y0_睫毛上中左 = pars["睫毛上中左"].ToPar();
			this.X1Y0_睫毛上下左 = pars["睫毛上下左"].ToPar();
			this.X1Y0_睫毛上上右 = pars["睫毛上上右"].ToPar();
			this.X1Y0_睫毛上中右 = pars["睫毛上中右"].ToPar();
			this.X1Y0_睫毛上下右 = pars["睫毛上下右"].ToPar();
			this.X1Y0_睫毛下上左 = pars["睫毛下上左"].ToPar();
			this.X1Y0_睫毛下下左 = pars["睫毛下下左"].ToPar();
			this.X1Y0_睫毛下上右 = pars["睫毛下上右"].ToPar();
			this.X1Y0_睫毛下下右 = pars["睫毛下下右"].ToPar();
			pars = this.本体[1][1];
			this.X1Y1_瞼下 = pars["瞼下"].ToPar();
			this.X1Y1_瞼上 = pars["瞼上"].ToPar();
			this.X1Y1_二重 = pars["二重"].ToPar();
			this.X1Y1_睫毛上上左 = pars["睫毛上上左"].ToPar();
			this.X1Y1_睫毛上中左 = pars["睫毛上中左"].ToPar();
			this.X1Y1_睫毛上下左 = pars["睫毛上下左"].ToPar();
			this.X1Y1_睫毛上上右 = pars["睫毛上上右"].ToPar();
			this.X1Y1_睫毛上中右 = pars["睫毛上中右"].ToPar();
			this.X1Y1_睫毛上下右 = pars["睫毛上下右"].ToPar();
			this.X1Y1_睫毛下上左 = pars["睫毛下上左"].ToPar();
			this.X1Y1_睫毛下下左 = pars["睫毛下下左"].ToPar();
			this.X1Y1_睫毛下上右 = pars["睫毛下上右"].ToPar();
			this.X1Y1_睫毛下下右 = pars["睫毛下下右"].ToPar();
			pars = this.本体[1][2];
			this.X1Y2_瞼下 = pars["瞼下"].ToPar();
			this.X1Y2_瞼上 = pars["瞼上"].ToPar();
			this.X1Y2_二重 = pars["二重"].ToPar();
			this.X1Y2_睫毛上上左 = pars["睫毛上上左"].ToPar();
			this.X1Y2_睫毛上中左 = pars["睫毛上中左"].ToPar();
			this.X1Y2_睫毛上下左 = pars["睫毛上下左"].ToPar();
			this.X1Y2_睫毛上上右 = pars["睫毛上上右"].ToPar();
			this.X1Y2_睫毛上中右 = pars["睫毛上中右"].ToPar();
			this.X1Y2_睫毛上下右 = pars["睫毛上下右"].ToPar();
			this.X1Y2_睫毛下上左 = pars["睫毛下上左"].ToPar();
			this.X1Y2_睫毛下下左 = pars["睫毛下下左"].ToPar();
			this.X1Y2_睫毛下上右 = pars["睫毛下上右"].ToPar();
			this.X1Y2_睫毛下下右 = pars["睫毛下下右"].ToPar();
			pars = this.本体[1][3];
			this.X1Y3_瞼下 = pars["瞼下"].ToPar();
			this.X1Y3_瞼上 = pars["瞼上"].ToPar();
			this.X1Y3_二重 = pars["二重"].ToPar();
			this.X1Y3_睫毛上上左 = pars["睫毛上上左"].ToPar();
			this.X1Y3_睫毛上中左 = pars["睫毛上中左"].ToPar();
			this.X1Y3_睫毛上下左 = pars["睫毛上下左"].ToPar();
			this.X1Y3_睫毛上上右 = pars["睫毛上上右"].ToPar();
			this.X1Y3_睫毛上中右 = pars["睫毛上中右"].ToPar();
			this.X1Y3_睫毛上下右 = pars["睫毛上下右"].ToPar();
			this.X1Y3_睫毛下上左 = pars["睫毛下上左"].ToPar();
			this.X1Y3_睫毛下下左 = pars["睫毛下下左"].ToPar();
			this.X1Y3_睫毛下上右 = pars["睫毛下上右"].ToPar();
			this.X1Y3_睫毛下下右 = pars["睫毛下下右"].ToPar();
			pars = this.本体[1][4];
			this.X1Y4_瞼下 = pars["瞼下"].ToPar();
			this.X1Y4_瞼上 = pars["瞼上"].ToPar();
			this.X1Y4_二重 = pars["二重"].ToPar();
			this.X1Y4_睫毛上上左 = pars["睫毛上上左"].ToPar();
			this.X1Y4_睫毛上中左 = pars["睫毛上中左"].ToPar();
			this.X1Y4_睫毛上下左 = pars["睫毛上下左"].ToPar();
			this.X1Y4_睫毛上上右 = pars["睫毛上上右"].ToPar();
			this.X1Y4_睫毛上中右 = pars["睫毛上中右"].ToPar();
			this.X1Y4_睫毛上下右 = pars["睫毛上下右"].ToPar();
			this.X1Y4_睫毛下上左 = pars["睫毛下上左"].ToPar();
			this.X1Y4_睫毛下下左 = pars["睫毛下下左"].ToPar();
			this.X1Y4_睫毛下上右 = pars["睫毛下上右"].ToPar();
			this.X1Y4_睫毛下下右 = pars["睫毛下下右"].ToPar();
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
			this.瞼下_表示 = e.瞼下_表示;
			this.瞼上_表示 = e.瞼上_表示;
			this.二重_表示 = e.二重_表示;
			this.睫毛上上左_表示 = e.睫毛上上左_表示;
			this.睫毛上中左_表示 = e.睫毛上中左_表示;
			this.睫毛上下左_表示 = e.睫毛上下左_表示;
			this.睫毛上上右_表示 = e.睫毛上上右_表示;
			this.睫毛上中右_表示 = e.睫毛上中右_表示;
			this.睫毛上下右_表示 = e.睫毛上下右_表示;
			this.睫毛下上左_表示 = e.睫毛下上左_表示;
			this.睫毛下下左_表示 = e.睫毛下下左_表示;
			this.睫毛下上右_表示 = e.睫毛下上右_表示;
			this.睫毛下下右_表示 = e.睫毛下下右_表示;
			this.外線 = e.外線;
			this.睫毛上上左_長さ = e.睫毛上上左_長さ;
			this.睫毛上中左_長さ = e.睫毛上中左_長さ;
			this.睫毛上下左_長さ = e.睫毛上下左_長さ;
			this.睫毛上上右_長さ = e.睫毛上上右_長さ;
			this.睫毛上中右_長さ = e.睫毛上中右_長さ;
			this.睫毛上下右_長さ = e.睫毛上下右_長さ;
			this.睫毛下上左_長さ = e.睫毛下上左_長さ;
			this.睫毛下下左_長さ = e.睫毛下下左_長さ;
			this.睫毛下上右_長さ = e.睫毛下上右_長さ;
			this.睫毛下下右_長さ = e.睫毛下下右_長さ;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_瞼下CP = new ColorP(this.X0Y0_瞼下, this.瞼下CD, DisUnit, true);
			this.X0Y0_瞼上CP = new ColorP(this.X0Y0_瞼上, this.瞼上CD, DisUnit, true);
			this.X0Y0_二重CP = new ColorP(this.X0Y0_二重, this.二重CD, DisUnit, true);
			this.X0Y0_睫毛上上左CP = new ColorP(this.X0Y0_睫毛上上左, this.睫毛上上左CD, DisUnit, true);
			this.X0Y0_睫毛上中左CP = new ColorP(this.X0Y0_睫毛上中左, this.睫毛上中左CD, DisUnit, true);
			this.X0Y0_睫毛上下左CP = new ColorP(this.X0Y0_睫毛上下左, this.睫毛上下左CD, DisUnit, true);
			this.X0Y0_睫毛上上右CP = new ColorP(this.X0Y0_睫毛上上右, this.睫毛上上右CD, DisUnit, true);
			this.X0Y0_睫毛上中右CP = new ColorP(this.X0Y0_睫毛上中右, this.睫毛上中右CD, DisUnit, true);
			this.X0Y0_睫毛上下右CP = new ColorP(this.X0Y0_睫毛上下右, this.睫毛上下右CD, DisUnit, true);
			this.X0Y0_睫毛下上左CP = new ColorP(this.X0Y0_睫毛下上左, this.睫毛下上左CD, DisUnit, true);
			this.X0Y0_睫毛下下左CP = new ColorP(this.X0Y0_睫毛下下左, this.睫毛下下左CD, DisUnit, true);
			this.X0Y0_睫毛下上右CP = new ColorP(this.X0Y0_睫毛下上右, this.睫毛下上右CD, DisUnit, true);
			this.X0Y0_睫毛下下右CP = new ColorP(this.X0Y0_睫毛下下右, this.睫毛下下右CD, DisUnit, true);
			this.X0Y1_瞼下CP = new ColorP(this.X0Y1_瞼下, this.瞼下CD, DisUnit, true);
			this.X0Y1_瞼上CP = new ColorP(this.X0Y1_瞼上, this.瞼上CD, DisUnit, true);
			this.X0Y1_二重CP = new ColorP(this.X0Y1_二重, this.二重CD, DisUnit, true);
			this.X0Y1_睫毛上上左CP = new ColorP(this.X0Y1_睫毛上上左, this.睫毛上上左CD, DisUnit, true);
			this.X0Y1_睫毛上中左CP = new ColorP(this.X0Y1_睫毛上中左, this.睫毛上中左CD, DisUnit, true);
			this.X0Y1_睫毛上下左CP = new ColorP(this.X0Y1_睫毛上下左, this.睫毛上下左CD, DisUnit, true);
			this.X0Y1_睫毛上上右CP = new ColorP(this.X0Y1_睫毛上上右, this.睫毛上上右CD, DisUnit, true);
			this.X0Y1_睫毛上中右CP = new ColorP(this.X0Y1_睫毛上中右, this.睫毛上中右CD, DisUnit, true);
			this.X0Y1_睫毛上下右CP = new ColorP(this.X0Y1_睫毛上下右, this.睫毛上下右CD, DisUnit, true);
			this.X0Y1_睫毛下上左CP = new ColorP(this.X0Y1_睫毛下上左, this.睫毛下上左CD, DisUnit, true);
			this.X0Y1_睫毛下下左CP = new ColorP(this.X0Y1_睫毛下下左, this.睫毛下下左CD, DisUnit, true);
			this.X0Y1_睫毛下上右CP = new ColorP(this.X0Y1_睫毛下上右, this.睫毛下上右CD, DisUnit, true);
			this.X0Y1_睫毛下下右CP = new ColorP(this.X0Y1_睫毛下下右, this.睫毛下下右CD, DisUnit, true);
			this.X0Y2_瞼下CP = new ColorP(this.X0Y2_瞼下, this.瞼下CD, DisUnit, true);
			this.X0Y2_瞼上CP = new ColorP(this.X0Y2_瞼上, this.瞼上CD, DisUnit, true);
			this.X0Y2_二重CP = new ColorP(this.X0Y2_二重, this.二重CD, DisUnit, true);
			this.X0Y2_睫毛上上左CP = new ColorP(this.X0Y2_睫毛上上左, this.睫毛上上左CD, DisUnit, true);
			this.X0Y2_睫毛上中左CP = new ColorP(this.X0Y2_睫毛上中左, this.睫毛上中左CD, DisUnit, true);
			this.X0Y2_睫毛上下左CP = new ColorP(this.X0Y2_睫毛上下左, this.睫毛上下左CD, DisUnit, true);
			this.X0Y2_睫毛上上右CP = new ColorP(this.X0Y2_睫毛上上右, this.睫毛上上右CD, DisUnit, true);
			this.X0Y2_睫毛上中右CP = new ColorP(this.X0Y2_睫毛上中右, this.睫毛上中右CD, DisUnit, true);
			this.X0Y2_睫毛上下右CP = new ColorP(this.X0Y2_睫毛上下右, this.睫毛上下右CD, DisUnit, true);
			this.X0Y2_睫毛下上左CP = new ColorP(this.X0Y2_睫毛下上左, this.睫毛下上左CD, DisUnit, true);
			this.X0Y2_睫毛下下左CP = new ColorP(this.X0Y2_睫毛下下左, this.睫毛下下左CD, DisUnit, true);
			this.X0Y2_睫毛下上右CP = new ColorP(this.X0Y2_睫毛下上右, this.睫毛下上右CD, DisUnit, true);
			this.X0Y2_睫毛下下右CP = new ColorP(this.X0Y2_睫毛下下右, this.睫毛下下右CD, DisUnit, true);
			this.X0Y3_瞼下CP = new ColorP(this.X0Y3_瞼下, this.瞼下CD, DisUnit, true);
			this.X0Y3_瞼上CP = new ColorP(this.X0Y3_瞼上, this.瞼上CD, DisUnit, true);
			this.X0Y3_二重CP = new ColorP(this.X0Y3_二重, this.二重CD, DisUnit, true);
			this.X0Y3_睫毛上上左CP = new ColorP(this.X0Y3_睫毛上上左, this.睫毛上上左CD, DisUnit, true);
			this.X0Y3_睫毛上中左CP = new ColorP(this.X0Y3_睫毛上中左, this.睫毛上中左CD, DisUnit, true);
			this.X0Y3_睫毛上下左CP = new ColorP(this.X0Y3_睫毛上下左, this.睫毛上下左CD, DisUnit, true);
			this.X0Y3_睫毛上上右CP = new ColorP(this.X0Y3_睫毛上上右, this.睫毛上上右CD, DisUnit, true);
			this.X0Y3_睫毛上中右CP = new ColorP(this.X0Y3_睫毛上中右, this.睫毛上中右CD, DisUnit, true);
			this.X0Y3_睫毛上下右CP = new ColorP(this.X0Y3_睫毛上下右, this.睫毛上下右CD, DisUnit, true);
			this.X0Y3_睫毛下上左CP = new ColorP(this.X0Y3_睫毛下上左, this.睫毛下上左CD, DisUnit, true);
			this.X0Y3_睫毛下下左CP = new ColorP(this.X0Y3_睫毛下下左, this.睫毛下下左CD, DisUnit, true);
			this.X0Y3_睫毛下上右CP = new ColorP(this.X0Y3_睫毛下上右, this.睫毛下上右CD, DisUnit, true);
			this.X0Y3_睫毛下下右CP = new ColorP(this.X0Y3_睫毛下下右, this.睫毛下下右CD, DisUnit, true);
			this.X0Y4_瞼下CP = new ColorP(this.X0Y4_瞼下, this.瞼下CD, DisUnit, true);
			this.X0Y4_瞼上CP = new ColorP(this.X0Y4_瞼上, this.瞼上CD, DisUnit, true);
			this.X0Y4_二重CP = new ColorP(this.X0Y4_二重, this.二重CD, DisUnit, true);
			this.X0Y4_睫毛上上左CP = new ColorP(this.X0Y4_睫毛上上左, this.睫毛上上左CD, DisUnit, true);
			this.X0Y4_睫毛上中左CP = new ColorP(this.X0Y4_睫毛上中左, this.睫毛上中左CD, DisUnit, true);
			this.X0Y4_睫毛上下左CP = new ColorP(this.X0Y4_睫毛上下左, this.睫毛上下左CD, DisUnit, true);
			this.X0Y4_睫毛上上右CP = new ColorP(this.X0Y4_睫毛上上右, this.睫毛上上右CD, DisUnit, true);
			this.X0Y4_睫毛上中右CP = new ColorP(this.X0Y4_睫毛上中右, this.睫毛上中右CD, DisUnit, true);
			this.X0Y4_睫毛上下右CP = new ColorP(this.X0Y4_睫毛上下右, this.睫毛上下右CD, DisUnit, true);
			this.X0Y4_睫毛下上左CP = new ColorP(this.X0Y4_睫毛下上左, this.睫毛下上左CD, DisUnit, true);
			this.X0Y4_睫毛下下左CP = new ColorP(this.X0Y4_睫毛下下左, this.睫毛下下左CD, DisUnit, true);
			this.X0Y4_睫毛下上右CP = new ColorP(this.X0Y4_睫毛下上右, this.睫毛下上右CD, DisUnit, true);
			this.X0Y4_睫毛下下右CP = new ColorP(this.X0Y4_睫毛下下右, this.睫毛下下右CD, DisUnit, true);
			this.X1Y0_瞼下CP = new ColorP(this.X1Y0_瞼下, this.瞼下CD, DisUnit, true);
			this.X1Y0_瞼上CP = new ColorP(this.X1Y0_瞼上, this.瞼上CD, DisUnit, true);
			this.X1Y0_二重CP = new ColorP(this.X1Y0_二重, this.二重CD, DisUnit, true);
			this.X1Y0_睫毛上上左CP = new ColorP(this.X1Y0_睫毛上上左, this.睫毛上上左CD, DisUnit, true);
			this.X1Y0_睫毛上中左CP = new ColorP(this.X1Y0_睫毛上中左, this.睫毛上中左CD, DisUnit, true);
			this.X1Y0_睫毛上下左CP = new ColorP(this.X1Y0_睫毛上下左, this.睫毛上下左CD, DisUnit, true);
			this.X1Y0_睫毛上上右CP = new ColorP(this.X1Y0_睫毛上上右, this.睫毛上上右CD, DisUnit, true);
			this.X1Y0_睫毛上中右CP = new ColorP(this.X1Y0_睫毛上中右, this.睫毛上中右CD, DisUnit, true);
			this.X1Y0_睫毛上下右CP = new ColorP(this.X1Y0_睫毛上下右, this.睫毛上下右CD, DisUnit, true);
			this.X1Y0_睫毛下上左CP = new ColorP(this.X1Y0_睫毛下上左, this.睫毛下上左CD, DisUnit, true);
			this.X1Y0_睫毛下下左CP = new ColorP(this.X1Y0_睫毛下下左, this.睫毛下下左CD, DisUnit, true);
			this.X1Y0_睫毛下上右CP = new ColorP(this.X1Y0_睫毛下上右, this.睫毛下上右CD, DisUnit, true);
			this.X1Y0_睫毛下下右CP = new ColorP(this.X1Y0_睫毛下下右, this.睫毛下下右CD, DisUnit, true);
			this.X1Y1_瞼下CP = new ColorP(this.X1Y1_瞼下, this.瞼下CD, DisUnit, true);
			this.X1Y1_瞼上CP = new ColorP(this.X1Y1_瞼上, this.瞼上CD, DisUnit, true);
			this.X1Y1_二重CP = new ColorP(this.X1Y1_二重, this.二重CD, DisUnit, true);
			this.X1Y1_睫毛上上左CP = new ColorP(this.X1Y1_睫毛上上左, this.睫毛上上左CD, DisUnit, true);
			this.X1Y1_睫毛上中左CP = new ColorP(this.X1Y1_睫毛上中左, this.睫毛上中左CD, DisUnit, true);
			this.X1Y1_睫毛上下左CP = new ColorP(this.X1Y1_睫毛上下左, this.睫毛上下左CD, DisUnit, true);
			this.X1Y1_睫毛上上右CP = new ColorP(this.X1Y1_睫毛上上右, this.睫毛上上右CD, DisUnit, true);
			this.X1Y1_睫毛上中右CP = new ColorP(this.X1Y1_睫毛上中右, this.睫毛上中右CD, DisUnit, true);
			this.X1Y1_睫毛上下右CP = new ColorP(this.X1Y1_睫毛上下右, this.睫毛上下右CD, DisUnit, true);
			this.X1Y1_睫毛下上左CP = new ColorP(this.X1Y1_睫毛下上左, this.睫毛下上左CD, DisUnit, true);
			this.X1Y1_睫毛下下左CP = new ColorP(this.X1Y1_睫毛下下左, this.睫毛下下左CD, DisUnit, true);
			this.X1Y1_睫毛下上右CP = new ColorP(this.X1Y1_睫毛下上右, this.睫毛下上右CD, DisUnit, true);
			this.X1Y1_睫毛下下右CP = new ColorP(this.X1Y1_睫毛下下右, this.睫毛下下右CD, DisUnit, true);
			this.X1Y2_瞼下CP = new ColorP(this.X1Y2_瞼下, this.瞼下CD, DisUnit, true);
			this.X1Y2_瞼上CP = new ColorP(this.X1Y2_瞼上, this.瞼上CD, DisUnit, true);
			this.X1Y2_二重CP = new ColorP(this.X1Y2_二重, this.二重CD, DisUnit, true);
			this.X1Y2_睫毛上上左CP = new ColorP(this.X1Y2_睫毛上上左, this.睫毛上上左CD, DisUnit, true);
			this.X1Y2_睫毛上中左CP = new ColorP(this.X1Y2_睫毛上中左, this.睫毛上中左CD, DisUnit, true);
			this.X1Y2_睫毛上下左CP = new ColorP(this.X1Y2_睫毛上下左, this.睫毛上下左CD, DisUnit, true);
			this.X1Y2_睫毛上上右CP = new ColorP(this.X1Y2_睫毛上上右, this.睫毛上上右CD, DisUnit, true);
			this.X1Y2_睫毛上中右CP = new ColorP(this.X1Y2_睫毛上中右, this.睫毛上中右CD, DisUnit, true);
			this.X1Y2_睫毛上下右CP = new ColorP(this.X1Y2_睫毛上下右, this.睫毛上下右CD, DisUnit, true);
			this.X1Y2_睫毛下上左CP = new ColorP(this.X1Y2_睫毛下上左, this.睫毛下上左CD, DisUnit, true);
			this.X1Y2_睫毛下下左CP = new ColorP(this.X1Y2_睫毛下下左, this.睫毛下下左CD, DisUnit, true);
			this.X1Y2_睫毛下上右CP = new ColorP(this.X1Y2_睫毛下上右, this.睫毛下上右CD, DisUnit, true);
			this.X1Y2_睫毛下下右CP = new ColorP(this.X1Y2_睫毛下下右, this.睫毛下下右CD, DisUnit, true);
			this.X1Y3_瞼下CP = new ColorP(this.X1Y3_瞼下, this.瞼下CD, DisUnit, true);
			this.X1Y3_瞼上CP = new ColorP(this.X1Y3_瞼上, this.瞼上CD, DisUnit, true);
			this.X1Y3_二重CP = new ColorP(this.X1Y3_二重, this.二重CD, DisUnit, true);
			this.X1Y3_睫毛上上左CP = new ColorP(this.X1Y3_睫毛上上左, this.睫毛上上左CD, DisUnit, true);
			this.X1Y3_睫毛上中左CP = new ColorP(this.X1Y3_睫毛上中左, this.睫毛上中左CD, DisUnit, true);
			this.X1Y3_睫毛上下左CP = new ColorP(this.X1Y3_睫毛上下左, this.睫毛上下左CD, DisUnit, true);
			this.X1Y3_睫毛上上右CP = new ColorP(this.X1Y3_睫毛上上右, this.睫毛上上右CD, DisUnit, true);
			this.X1Y3_睫毛上中右CP = new ColorP(this.X1Y3_睫毛上中右, this.睫毛上中右CD, DisUnit, true);
			this.X1Y3_睫毛上下右CP = new ColorP(this.X1Y3_睫毛上下右, this.睫毛上下右CD, DisUnit, true);
			this.X1Y3_睫毛下上左CP = new ColorP(this.X1Y3_睫毛下上左, this.睫毛下上左CD, DisUnit, true);
			this.X1Y3_睫毛下下左CP = new ColorP(this.X1Y3_睫毛下下左, this.睫毛下下左CD, DisUnit, true);
			this.X1Y3_睫毛下上右CP = new ColorP(this.X1Y3_睫毛下上右, this.睫毛下上右CD, DisUnit, true);
			this.X1Y3_睫毛下下右CP = new ColorP(this.X1Y3_睫毛下下右, this.睫毛下下右CD, DisUnit, true);
			this.X1Y4_瞼下CP = new ColorP(this.X1Y4_瞼下, this.瞼下CD, DisUnit, true);
			this.X1Y4_瞼上CP = new ColorP(this.X1Y4_瞼上, this.瞼上CD, DisUnit, true);
			this.X1Y4_二重CP = new ColorP(this.X1Y4_二重, this.二重CD, DisUnit, true);
			this.X1Y4_睫毛上上左CP = new ColorP(this.X1Y4_睫毛上上左, this.睫毛上上左CD, DisUnit, true);
			this.X1Y4_睫毛上中左CP = new ColorP(this.X1Y4_睫毛上中左, this.睫毛上中左CD, DisUnit, true);
			this.X1Y4_睫毛上下左CP = new ColorP(this.X1Y4_睫毛上下左, this.睫毛上下左CD, DisUnit, true);
			this.X1Y4_睫毛上上右CP = new ColorP(this.X1Y4_睫毛上上右, this.睫毛上上右CD, DisUnit, true);
			this.X1Y4_睫毛上中右CP = new ColorP(this.X1Y4_睫毛上中右, this.睫毛上中右CD, DisUnit, true);
			this.X1Y4_睫毛上下右CP = new ColorP(this.X1Y4_睫毛上下右, this.睫毛上下右CD, DisUnit, true);
			this.X1Y4_睫毛下上左CP = new ColorP(this.X1Y4_睫毛下上左, this.睫毛下上左CD, DisUnit, true);
			this.X1Y4_睫毛下下左CP = new ColorP(this.X1Y4_睫毛下下左, this.睫毛下下左CD, DisUnit, true);
			this.X1Y4_睫毛下上右CP = new ColorP(this.X1Y4_睫毛下上右, this.睫毛下上右CD, DisUnit, true);
			this.X1Y4_睫毛下下右CP = new ColorP(this.X1Y4_睫毛下下右, this.睫毛下下右CD, DisUnit, true);
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

		public bool 瞼下_表示
		{
			get
			{
				return this.X0Y0_瞼下.Dra;
			}
			set
			{
				this.X0Y0_瞼下.Dra = value;
				this.X0Y1_瞼下.Dra = value;
				this.X0Y2_瞼下.Dra = value;
				this.X0Y3_瞼下.Dra = value;
				this.X0Y4_瞼下.Dra = value;
				this.X1Y0_瞼下.Dra = value;
				this.X1Y1_瞼下.Dra = value;
				this.X1Y2_瞼下.Dra = value;
				this.X1Y3_瞼下.Dra = value;
				this.X1Y4_瞼下.Dra = value;
				this.X0Y0_瞼下.Hit = value;
				this.X0Y1_瞼下.Hit = value;
				this.X0Y2_瞼下.Hit = value;
				this.X0Y3_瞼下.Hit = value;
				this.X0Y4_瞼下.Hit = value;
				this.X1Y0_瞼下.Hit = value;
				this.X1Y1_瞼下.Hit = value;
				this.X1Y2_瞼下.Hit = value;
				this.X1Y3_瞼下.Hit = value;
				this.X1Y4_瞼下.Hit = value;
			}
		}

		public bool 瞼上_表示
		{
			get
			{
				return this.X0Y0_瞼上.Dra;
			}
			set
			{
				this.X0Y0_瞼上.Dra = value;
				this.X0Y1_瞼上.Dra = value;
				this.X0Y2_瞼上.Dra = value;
				this.X0Y3_瞼上.Dra = value;
				this.X0Y4_瞼上.Dra = value;
				this.X1Y0_瞼上.Dra = value;
				this.X1Y1_瞼上.Dra = value;
				this.X1Y2_瞼上.Dra = value;
				this.X1Y3_瞼上.Dra = value;
				this.X1Y4_瞼上.Dra = value;
				this.X0Y0_瞼上.Hit = value;
				this.X0Y1_瞼上.Hit = value;
				this.X0Y2_瞼上.Hit = value;
				this.X0Y3_瞼上.Hit = value;
				this.X0Y4_瞼上.Hit = value;
				this.X1Y0_瞼上.Hit = value;
				this.X1Y1_瞼上.Hit = value;
				this.X1Y2_瞼上.Hit = value;
				this.X1Y3_瞼上.Hit = value;
				this.X1Y4_瞼上.Hit = value;
			}
		}

		public bool 二重_表示
		{
			get
			{
				return this.X0Y0_二重.Dra;
			}
			set
			{
				this.X0Y0_二重.Dra = value;
				this.X0Y1_二重.Dra = value;
				this.X0Y2_二重.Dra = value;
				this.X0Y3_二重.Dra = value;
				this.X0Y4_二重.Dra = value;
				this.X1Y0_二重.Dra = value;
				this.X1Y1_二重.Dra = value;
				this.X1Y2_二重.Dra = value;
				this.X1Y3_二重.Dra = value;
				this.X1Y4_二重.Dra = value;
				this.X0Y0_二重.Hit = value;
				this.X0Y1_二重.Hit = value;
				this.X0Y2_二重.Hit = value;
				this.X0Y3_二重.Hit = value;
				this.X0Y4_二重.Hit = value;
				this.X1Y0_二重.Hit = value;
				this.X1Y1_二重.Hit = value;
				this.X1Y2_二重.Hit = value;
				this.X1Y3_二重.Hit = value;
				this.X1Y4_二重.Hit = value;
			}
		}

		public bool 睫毛上上左_表示
		{
			get
			{
				return this.X0Y0_睫毛上上左.Dra;
			}
			set
			{
				this.X0Y0_睫毛上上左.Dra = value;
				this.X0Y1_睫毛上上左.Dra = value;
				this.X0Y2_睫毛上上左.Dra = value;
				this.X0Y3_睫毛上上左.Dra = value;
				this.X0Y4_睫毛上上左.Dra = value;
				this.X1Y0_睫毛上上左.Dra = value;
				this.X1Y1_睫毛上上左.Dra = value;
				this.X1Y2_睫毛上上左.Dra = value;
				this.X1Y3_睫毛上上左.Dra = value;
				this.X1Y4_睫毛上上左.Dra = value;
				this.X0Y0_睫毛上上左.Hit = value;
				this.X0Y1_睫毛上上左.Hit = value;
				this.X0Y2_睫毛上上左.Hit = value;
				this.X0Y3_睫毛上上左.Hit = value;
				this.X0Y4_睫毛上上左.Hit = value;
				this.X1Y0_睫毛上上左.Hit = value;
				this.X1Y1_睫毛上上左.Hit = value;
				this.X1Y2_睫毛上上左.Hit = value;
				this.X1Y3_睫毛上上左.Hit = value;
				this.X1Y4_睫毛上上左.Hit = value;
			}
		}

		public bool 睫毛上中左_表示
		{
			get
			{
				return this.X0Y0_睫毛上中左.Dra;
			}
			set
			{
				this.X0Y0_睫毛上中左.Dra = value;
				this.X0Y1_睫毛上中左.Dra = value;
				this.X0Y2_睫毛上中左.Dra = value;
				this.X0Y3_睫毛上中左.Dra = value;
				this.X0Y4_睫毛上中左.Dra = value;
				this.X1Y0_睫毛上中左.Dra = value;
				this.X1Y1_睫毛上中左.Dra = value;
				this.X1Y2_睫毛上中左.Dra = value;
				this.X1Y3_睫毛上中左.Dra = value;
				this.X1Y4_睫毛上中左.Dra = value;
				this.X0Y0_睫毛上中左.Hit = value;
				this.X0Y1_睫毛上中左.Hit = value;
				this.X0Y2_睫毛上中左.Hit = value;
				this.X0Y3_睫毛上中左.Hit = value;
				this.X0Y4_睫毛上中左.Hit = value;
				this.X1Y0_睫毛上中左.Hit = value;
				this.X1Y1_睫毛上中左.Hit = value;
				this.X1Y2_睫毛上中左.Hit = value;
				this.X1Y3_睫毛上中左.Hit = value;
				this.X1Y4_睫毛上中左.Hit = value;
			}
		}

		public bool 睫毛上下左_表示
		{
			get
			{
				return this.X0Y0_睫毛上下左.Dra;
			}
			set
			{
				this.X0Y0_睫毛上下左.Dra = value;
				this.X0Y1_睫毛上下左.Dra = value;
				this.X0Y2_睫毛上下左.Dra = value;
				this.X0Y3_睫毛上下左.Dra = value;
				this.X0Y4_睫毛上下左.Dra = value;
				this.X1Y0_睫毛上下左.Dra = value;
				this.X1Y1_睫毛上下左.Dra = value;
				this.X1Y2_睫毛上下左.Dra = value;
				this.X1Y3_睫毛上下左.Dra = value;
				this.X1Y4_睫毛上下左.Dra = value;
				this.X0Y0_睫毛上下左.Hit = value;
				this.X0Y1_睫毛上下左.Hit = value;
				this.X0Y2_睫毛上下左.Hit = value;
				this.X0Y3_睫毛上下左.Hit = value;
				this.X0Y4_睫毛上下左.Hit = value;
				this.X1Y0_睫毛上下左.Hit = value;
				this.X1Y1_睫毛上下左.Hit = value;
				this.X1Y2_睫毛上下左.Hit = value;
				this.X1Y3_睫毛上下左.Hit = value;
				this.X1Y4_睫毛上下左.Hit = value;
			}
		}

		public bool 睫毛上上右_表示
		{
			get
			{
				return this.X0Y0_睫毛上上右.Dra;
			}
			set
			{
				this.X0Y0_睫毛上上右.Dra = value;
				this.X0Y1_睫毛上上右.Dra = value;
				this.X0Y2_睫毛上上右.Dra = value;
				this.X0Y3_睫毛上上右.Dra = value;
				this.X0Y4_睫毛上上右.Dra = value;
				this.X1Y0_睫毛上上右.Dra = value;
				this.X1Y1_睫毛上上右.Dra = value;
				this.X1Y2_睫毛上上右.Dra = value;
				this.X1Y3_睫毛上上右.Dra = value;
				this.X1Y4_睫毛上上右.Dra = value;
				this.X0Y0_睫毛上上右.Hit = value;
				this.X0Y1_睫毛上上右.Hit = value;
				this.X0Y2_睫毛上上右.Hit = value;
				this.X0Y3_睫毛上上右.Hit = value;
				this.X0Y4_睫毛上上右.Hit = value;
				this.X1Y0_睫毛上上右.Hit = value;
				this.X1Y1_睫毛上上右.Hit = value;
				this.X1Y2_睫毛上上右.Hit = value;
				this.X1Y3_睫毛上上右.Hit = value;
				this.X1Y4_睫毛上上右.Hit = value;
			}
		}

		public bool 睫毛上中右_表示
		{
			get
			{
				return this.X0Y0_睫毛上中右.Dra;
			}
			set
			{
				this.X0Y0_睫毛上中右.Dra = value;
				this.X0Y1_睫毛上中右.Dra = value;
				this.X0Y2_睫毛上中右.Dra = value;
				this.X0Y3_睫毛上中右.Dra = value;
				this.X0Y4_睫毛上中右.Dra = value;
				this.X1Y0_睫毛上中右.Dra = value;
				this.X1Y1_睫毛上中右.Dra = value;
				this.X1Y2_睫毛上中右.Dra = value;
				this.X1Y3_睫毛上中右.Dra = value;
				this.X1Y4_睫毛上中右.Dra = value;
				this.X0Y0_睫毛上中右.Hit = value;
				this.X0Y1_睫毛上中右.Hit = value;
				this.X0Y2_睫毛上中右.Hit = value;
				this.X0Y3_睫毛上中右.Hit = value;
				this.X0Y4_睫毛上中右.Hit = value;
				this.X1Y0_睫毛上中右.Hit = value;
				this.X1Y1_睫毛上中右.Hit = value;
				this.X1Y2_睫毛上中右.Hit = value;
				this.X1Y3_睫毛上中右.Hit = value;
				this.X1Y4_睫毛上中右.Hit = value;
			}
		}

		public bool 睫毛上下右_表示
		{
			get
			{
				return this.X0Y0_睫毛上下右.Dra;
			}
			set
			{
				this.X0Y0_睫毛上下右.Dra = value;
				this.X0Y1_睫毛上下右.Dra = value;
				this.X0Y2_睫毛上下右.Dra = value;
				this.X0Y3_睫毛上下右.Dra = value;
				this.X0Y4_睫毛上下右.Dra = value;
				this.X1Y0_睫毛上下右.Dra = value;
				this.X1Y1_睫毛上下右.Dra = value;
				this.X1Y2_睫毛上下右.Dra = value;
				this.X1Y3_睫毛上下右.Dra = value;
				this.X1Y4_睫毛上下右.Dra = value;
				this.X0Y0_睫毛上下右.Hit = value;
				this.X0Y1_睫毛上下右.Hit = value;
				this.X0Y2_睫毛上下右.Hit = value;
				this.X0Y3_睫毛上下右.Hit = value;
				this.X0Y4_睫毛上下右.Hit = value;
				this.X1Y0_睫毛上下右.Hit = value;
				this.X1Y1_睫毛上下右.Hit = value;
				this.X1Y2_睫毛上下右.Hit = value;
				this.X1Y3_睫毛上下右.Hit = value;
				this.X1Y4_睫毛上下右.Hit = value;
			}
		}

		public bool 睫毛下上左_表示
		{
			get
			{
				return this.X0Y0_睫毛下上左.Dra;
			}
			set
			{
				this.X0Y0_睫毛下上左.Dra = value;
				this.X0Y1_睫毛下上左.Dra = value;
				this.X0Y2_睫毛下上左.Dra = value;
				this.X0Y3_睫毛下上左.Dra = value;
				this.X0Y4_睫毛下上左.Dra = value;
				this.X1Y0_睫毛下上左.Dra = value;
				this.X1Y1_睫毛下上左.Dra = value;
				this.X1Y2_睫毛下上左.Dra = value;
				this.X1Y3_睫毛下上左.Dra = value;
				this.X1Y4_睫毛下上左.Dra = value;
				this.X0Y0_睫毛下上左.Hit = value;
				this.X0Y1_睫毛下上左.Hit = value;
				this.X0Y2_睫毛下上左.Hit = value;
				this.X0Y3_睫毛下上左.Hit = value;
				this.X0Y4_睫毛下上左.Hit = value;
				this.X1Y0_睫毛下上左.Hit = value;
				this.X1Y1_睫毛下上左.Hit = value;
				this.X1Y2_睫毛下上左.Hit = value;
				this.X1Y3_睫毛下上左.Hit = value;
				this.X1Y4_睫毛下上左.Hit = value;
			}
		}

		public bool 睫毛下下左_表示
		{
			get
			{
				return this.X0Y0_睫毛下下左.Dra;
			}
			set
			{
				this.X0Y0_睫毛下下左.Dra = value;
				this.X0Y1_睫毛下下左.Dra = value;
				this.X0Y2_睫毛下下左.Dra = value;
				this.X0Y3_睫毛下下左.Dra = value;
				this.X0Y4_睫毛下下左.Dra = value;
				this.X1Y0_睫毛下下左.Dra = value;
				this.X1Y1_睫毛下下左.Dra = value;
				this.X1Y2_睫毛下下左.Dra = value;
				this.X1Y3_睫毛下下左.Dra = value;
				this.X1Y4_睫毛下下左.Dra = value;
				this.X0Y0_睫毛下下左.Hit = value;
				this.X0Y1_睫毛下下左.Hit = value;
				this.X0Y2_睫毛下下左.Hit = value;
				this.X0Y3_睫毛下下左.Hit = value;
				this.X0Y4_睫毛下下左.Hit = value;
				this.X1Y0_睫毛下下左.Hit = value;
				this.X1Y1_睫毛下下左.Hit = value;
				this.X1Y2_睫毛下下左.Hit = value;
				this.X1Y3_睫毛下下左.Hit = value;
				this.X1Y4_睫毛下下左.Hit = value;
			}
		}

		public bool 睫毛下上右_表示
		{
			get
			{
				return this.X0Y0_睫毛下上右.Dra;
			}
			set
			{
				this.X0Y0_睫毛下上右.Dra = value;
				this.X0Y1_睫毛下上右.Dra = value;
				this.X0Y2_睫毛下上右.Dra = value;
				this.X0Y3_睫毛下上右.Dra = value;
				this.X0Y4_睫毛下上右.Dra = value;
				this.X1Y0_睫毛下上右.Dra = value;
				this.X1Y1_睫毛下上右.Dra = value;
				this.X1Y2_睫毛下上右.Dra = value;
				this.X1Y3_睫毛下上右.Dra = value;
				this.X1Y4_睫毛下上右.Dra = value;
				this.X0Y0_睫毛下上右.Hit = value;
				this.X0Y1_睫毛下上右.Hit = value;
				this.X0Y2_睫毛下上右.Hit = value;
				this.X0Y3_睫毛下上右.Hit = value;
				this.X0Y4_睫毛下上右.Hit = value;
				this.X1Y0_睫毛下上右.Hit = value;
				this.X1Y1_睫毛下上右.Hit = value;
				this.X1Y2_睫毛下上右.Hit = value;
				this.X1Y3_睫毛下上右.Hit = value;
				this.X1Y4_睫毛下上右.Hit = value;
			}
		}

		public bool 睫毛下下右_表示
		{
			get
			{
				return this.X0Y0_睫毛下下右.Dra;
			}
			set
			{
				this.X0Y0_睫毛下下右.Dra = value;
				this.X0Y1_睫毛下下右.Dra = value;
				this.X0Y2_睫毛下下右.Dra = value;
				this.X0Y3_睫毛下下右.Dra = value;
				this.X0Y4_睫毛下下右.Dra = value;
				this.X1Y0_睫毛下下右.Dra = value;
				this.X1Y1_睫毛下下右.Dra = value;
				this.X1Y2_睫毛下下右.Dra = value;
				this.X1Y3_睫毛下下右.Dra = value;
				this.X1Y4_睫毛下下右.Dra = value;
				this.X0Y0_睫毛下下右.Hit = value;
				this.X0Y1_睫毛下下右.Hit = value;
				this.X0Y2_睫毛下下右.Hit = value;
				this.X0Y3_睫毛下下右.Hit = value;
				this.X0Y4_睫毛下下右.Hit = value;
				this.X1Y0_睫毛下下右.Hit = value;
				this.X1Y1_睫毛下下右.Hit = value;
				this.X1Y2_睫毛下下右.Hit = value;
				this.X1Y3_睫毛下下右.Hit = value;
				this.X1Y4_睫毛下下右.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.瞼下_表示;
			}
			set
			{
				this.瞼下_表示 = value;
				this.瞼上_表示 = value;
				this.二重_表示 = value;
				this.睫毛上上左_表示 = value;
				this.睫毛上中左_表示 = value;
				this.睫毛上下左_表示 = value;
				this.睫毛上上右_表示 = value;
				this.睫毛上中右_表示 = value;
				this.睫毛上下右_表示 = value;
				this.睫毛下上左_表示 = value;
				this.睫毛下下左_表示 = value;
				this.睫毛下上右_表示 = value;
				this.睫毛下下右_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.瞼下CD.不透明度;
			}
			set
			{
				this.瞼下CD.不透明度 = value;
				this.瞼上CD.不透明度 = value;
				this.二重CD.不透明度 = value;
				this.睫毛上上左CD.不透明度 = value;
				this.睫毛上中左CD.不透明度 = value;
				this.睫毛上下左CD.不透明度 = value;
				this.睫毛上上右CD.不透明度 = value;
				this.睫毛上中右CD.不透明度 = value;
				this.睫毛上下右CD.不透明度 = value;
				this.睫毛下上左CD.不透明度 = value;
				this.睫毛下下左CD.不透明度 = value;
				this.睫毛下上右CD.不透明度 = value;
				this.睫毛下下右CD.不透明度 = value;
			}
		}

		public double 外線
		{
			set
			{
				double num = 0.9 + 0.55 * value;
				this.X0Y0_瞼上.PenWidth *= num;
				this.X0Y1_瞼上.PenWidth *= num;
				this.X0Y2_瞼上.PenWidth *= num;
				this.X0Y3_瞼上.PenWidth *= num;
				this.X0Y4_瞼上.PenWidth *= num;
				this.X1Y0_瞼上.PenWidth *= num;
				this.X1Y1_瞼上.PenWidth *= num;
				this.X1Y2_瞼上.PenWidth *= num;
				this.X1Y3_瞼上.PenWidth *= num;
				this.X1Y4_瞼上.PenWidth *= num;
				this.X0Y0_瞼下.PenWidth *= num;
				this.X0Y1_瞼下.PenWidth *= num;
				this.X0Y2_瞼下.PenWidth *= num;
				this.X0Y3_瞼下.PenWidth *= num;
				this.X0Y4_瞼下.PenWidth *= num;
				this.X1Y0_瞼下.PenWidth *= num;
				this.X1Y1_瞼下.PenWidth *= num;
				this.X1Y2_瞼下.PenWidth *= num;
				this.X1Y3_瞼下.PenWidth *= num;
				this.X1Y4_瞼下.PenWidth *= num;
			}
		}

		private void 睫毛長さ(Par p, double d)
		{
			double num = 0.0;
			double num2 = 1.5;
			Vector2D value = p.BasePointBase + (p.OP[0].ps[0] - p.BasePointBase) * (num + (num2 - num) * d);
			p.OP[2].ps[2] = value;
			p.OP[0].ps[0] = value;
		}

		public double 睫毛上上左_長さ
		{
			set
			{
				this.睫毛長さ(this.X0Y0_睫毛上上左, value);
				this.睫毛長さ(this.X0Y1_睫毛上上左, value);
				this.睫毛長さ(this.X0Y2_睫毛上上左, value);
				this.睫毛長さ(this.X0Y3_睫毛上上左, value);
				this.睫毛長さ(this.X0Y4_睫毛上上左, value);
				this.睫毛長さ(this.X1Y0_睫毛上上左, value);
				this.睫毛長さ(this.X1Y1_睫毛上上左, value);
				this.睫毛長さ(this.X1Y2_睫毛上上左, value);
				this.睫毛長さ(this.X1Y3_睫毛上上左, value);
				this.睫毛長さ(this.X1Y4_睫毛上上左, value);
			}
		}

		public double 睫毛上中左_長さ
		{
			set
			{
				this.睫毛長さ(this.X0Y0_睫毛上中左, value);
				this.睫毛長さ(this.X0Y1_睫毛上中左, value);
				this.睫毛長さ(this.X0Y2_睫毛上中左, value);
				this.睫毛長さ(this.X0Y3_睫毛上中左, value);
				this.睫毛長さ(this.X0Y4_睫毛上中左, value);
				this.睫毛長さ(this.X1Y0_睫毛上中左, value);
				this.睫毛長さ(this.X1Y1_睫毛上中左, value);
				this.睫毛長さ(this.X1Y2_睫毛上中左, value);
				this.睫毛長さ(this.X1Y3_睫毛上中左, value);
				this.睫毛長さ(this.X1Y4_睫毛上中左, value);
			}
		}

		public double 睫毛上下左_長さ
		{
			set
			{
				this.睫毛長さ(this.X0Y0_睫毛上下左, value);
				this.睫毛長さ(this.X0Y1_睫毛上下左, value);
				this.睫毛長さ(this.X0Y2_睫毛上下左, value);
				this.睫毛長さ(this.X0Y3_睫毛上下左, value);
				this.睫毛長さ(this.X0Y4_睫毛上下左, value);
				this.睫毛長さ(this.X1Y0_睫毛上下左, value);
				this.睫毛長さ(this.X1Y1_睫毛上下左, value);
				this.睫毛長さ(this.X1Y2_睫毛上下左, value);
				this.睫毛長さ(this.X1Y3_睫毛上下左, value);
				this.睫毛長さ(this.X1Y4_睫毛上下左, value);
			}
		}

		public double 睫毛上上右_長さ
		{
			set
			{
				this.睫毛長さ(this.X0Y0_睫毛上上右, value);
				this.睫毛長さ(this.X0Y1_睫毛上上右, value);
				this.睫毛長さ(this.X0Y2_睫毛上上右, value);
				this.睫毛長さ(this.X0Y3_睫毛上上右, value);
				this.睫毛長さ(this.X0Y4_睫毛上上右, value);
				this.睫毛長さ(this.X1Y0_睫毛上上右, value);
				this.睫毛長さ(this.X1Y1_睫毛上上右, value);
				this.睫毛長さ(this.X1Y2_睫毛上上右, value);
				this.睫毛長さ(this.X1Y3_睫毛上上右, value);
				this.睫毛長さ(this.X1Y4_睫毛上上右, value);
			}
		}

		public double 睫毛上中右_長さ
		{
			set
			{
				this.睫毛長さ(this.X0Y0_睫毛上中右, value);
				this.睫毛長さ(this.X0Y1_睫毛上中右, value);
				this.睫毛長さ(this.X0Y2_睫毛上中右, value);
				this.睫毛長さ(this.X0Y3_睫毛上中右, value);
				this.睫毛長さ(this.X0Y4_睫毛上中右, value);
				this.睫毛長さ(this.X1Y0_睫毛上中右, value);
				this.睫毛長さ(this.X1Y1_睫毛上中右, value);
				this.睫毛長さ(this.X1Y2_睫毛上中右, value);
				this.睫毛長さ(this.X1Y3_睫毛上中右, value);
				this.睫毛長さ(this.X1Y4_睫毛上中右, value);
			}
		}

		public double 睫毛上下右_長さ
		{
			set
			{
				this.睫毛長さ(this.X0Y0_睫毛上下右, value);
				this.睫毛長さ(this.X0Y1_睫毛上下右, value);
				this.睫毛長さ(this.X0Y2_睫毛上下右, value);
				this.睫毛長さ(this.X0Y3_睫毛上下右, value);
				this.睫毛長さ(this.X0Y4_睫毛上下右, value);
				this.睫毛長さ(this.X1Y0_睫毛上下右, value);
				this.睫毛長さ(this.X1Y1_睫毛上下右, value);
				this.睫毛長さ(this.X1Y2_睫毛上下右, value);
				this.睫毛長さ(this.X1Y3_睫毛上下右, value);
				this.睫毛長さ(this.X1Y4_睫毛上下右, value);
			}
		}

		public double 睫毛下上左_長さ
		{
			set
			{
				this.睫毛長さ(this.X0Y0_睫毛下上左, value);
				this.睫毛長さ(this.X0Y1_睫毛下上左, value);
				this.睫毛長さ(this.X0Y2_睫毛下上左, value);
				this.睫毛長さ(this.X0Y3_睫毛下上左, value);
				this.睫毛長さ(this.X0Y4_睫毛下上左, value);
				this.睫毛長さ(this.X1Y0_睫毛下上左, value);
				this.睫毛長さ(this.X1Y1_睫毛下上左, value);
				this.睫毛長さ(this.X1Y2_睫毛下上左, value);
				this.睫毛長さ(this.X1Y3_睫毛下上左, value);
				this.睫毛長さ(this.X1Y4_睫毛下上左, value);
			}
		}

		public double 睫毛下下左_長さ
		{
			set
			{
				this.睫毛長さ(this.X0Y0_睫毛下下左, value);
				this.睫毛長さ(this.X0Y1_睫毛下下左, value);
				this.睫毛長さ(this.X0Y2_睫毛下下左, value);
				this.睫毛長さ(this.X0Y3_睫毛下下左, value);
				this.睫毛長さ(this.X0Y4_睫毛下下左, value);
				this.睫毛長さ(this.X1Y0_睫毛下下左, value);
				this.睫毛長さ(this.X1Y1_睫毛下下左, value);
				this.睫毛長さ(this.X1Y2_睫毛下下左, value);
				this.睫毛長さ(this.X1Y3_睫毛下下左, value);
				this.睫毛長さ(this.X1Y4_睫毛下下左, value);
			}
		}

		public double 睫毛下上右_長さ
		{
			set
			{
				this.睫毛長さ(this.X0Y0_睫毛下上右, value);
				this.睫毛長さ(this.X0Y1_睫毛下上右, value);
				this.睫毛長さ(this.X0Y2_睫毛下上右, value);
				this.睫毛長さ(this.X0Y3_睫毛下上右, value);
				this.睫毛長さ(this.X0Y4_睫毛下上右, value);
				this.睫毛長さ(this.X1Y0_睫毛下上右, value);
				this.睫毛長さ(this.X1Y1_睫毛下上右, value);
				this.睫毛長さ(this.X1Y2_睫毛下上右, value);
				this.睫毛長さ(this.X1Y3_睫毛下上右, value);
				this.睫毛長さ(this.X1Y4_睫毛下上右, value);
			}
		}

		public double 睫毛下下右_長さ
		{
			set
			{
				this.睫毛長さ(this.X0Y0_睫毛下下右, value);
				this.睫毛長さ(this.X0Y1_睫毛下下右, value);
				this.睫毛長さ(this.X0Y2_睫毛下下右, value);
				this.睫毛長さ(this.X0Y3_睫毛下下右, value);
				this.睫毛長さ(this.X0Y4_睫毛下下右, value);
				this.睫毛長さ(this.X1Y0_睫毛下下右, value);
				this.睫毛長さ(this.X1Y1_睫毛下下右, value);
				this.睫毛長さ(this.X1Y2_睫毛下下右, value);
				this.睫毛長さ(this.X1Y3_睫毛下下右, value);
				this.睫毛長さ(this.X1Y4_睫毛下下右, value);
			}
		}

		public override double 肥大
		{
			set
			{
			}
		}

		public override double 身長
		{
			set
			{
			}
		}

		public override double サイズ
		{
			get
			{
				return this.サイズ_;
			}
			set
			{
				this.サイズ_ = value;
				double rate = 0.98 + 0.06 * this.サイズ_;
				foreach (Par par in this.本体.EnumAllPar())
				{
					Vector2D center = par.OP.GetCenter();
					par.OP.ScalingXY(center, rate);
					par.JP.ScalingXY(center, rate);
				}
			}
		}

		public override void 色更新()
		{
			if (this.本体.IndexX == 0)
			{
				switch (this.本体.IndexY)
				{
				case 0:
					this.X0Y0_瞼下CP.Update();
					this.X0Y0_瞼上CP.Update();
					this.X0Y0_二重CP.Update();
					this.X0Y0_睫毛上上左CP.Update();
					this.X0Y0_睫毛上中左CP.Update();
					this.X0Y0_睫毛上下左CP.Update();
					this.X0Y0_睫毛上上右CP.Update();
					this.X0Y0_睫毛上中右CP.Update();
					this.X0Y0_睫毛上下右CP.Update();
					this.X0Y0_睫毛下上左CP.Update();
					this.X0Y0_睫毛下下左CP.Update();
					this.X0Y0_睫毛下上右CP.Update();
					this.X0Y0_睫毛下下右CP.Update();
					return;
				case 1:
					this.X0Y1_瞼下CP.Update();
					this.X0Y1_瞼上CP.Update();
					this.X0Y1_二重CP.Update();
					this.X0Y1_睫毛上上左CP.Update();
					this.X0Y1_睫毛上中左CP.Update();
					this.X0Y1_睫毛上下左CP.Update();
					this.X0Y1_睫毛上上右CP.Update();
					this.X0Y1_睫毛上中右CP.Update();
					this.X0Y1_睫毛上下右CP.Update();
					this.X0Y1_睫毛下上左CP.Update();
					this.X0Y1_睫毛下下左CP.Update();
					this.X0Y1_睫毛下上右CP.Update();
					this.X0Y1_睫毛下下右CP.Update();
					return;
				case 2:
					this.X0Y2_瞼下CP.Update();
					this.X0Y2_瞼上CP.Update();
					this.X0Y2_二重CP.Update();
					this.X0Y2_睫毛上上左CP.Update();
					this.X0Y2_睫毛上中左CP.Update();
					this.X0Y2_睫毛上下左CP.Update();
					this.X0Y2_睫毛上上右CP.Update();
					this.X0Y2_睫毛上中右CP.Update();
					this.X0Y2_睫毛上下右CP.Update();
					this.X0Y2_睫毛下上左CP.Update();
					this.X0Y2_睫毛下下左CP.Update();
					this.X0Y2_睫毛下上右CP.Update();
					this.X0Y2_睫毛下下右CP.Update();
					return;
				case 3:
					this.X0Y3_瞼下CP.Update();
					this.X0Y3_瞼上CP.Update();
					this.X0Y3_二重CP.Update();
					this.X0Y3_睫毛上上左CP.Update();
					this.X0Y3_睫毛上中左CP.Update();
					this.X0Y3_睫毛上下左CP.Update();
					this.X0Y3_睫毛上上右CP.Update();
					this.X0Y3_睫毛上中右CP.Update();
					this.X0Y3_睫毛上下右CP.Update();
					this.X0Y3_睫毛下上左CP.Update();
					this.X0Y3_睫毛下下左CP.Update();
					this.X0Y3_睫毛下上右CP.Update();
					this.X0Y3_睫毛下下右CP.Update();
					return;
				default:
					this.X0Y4_瞼下CP.Update();
					this.X0Y4_瞼上CP.Update();
					this.X0Y4_二重CP.Update();
					this.X0Y4_睫毛上上左CP.Update();
					this.X0Y4_睫毛上中左CP.Update();
					this.X0Y4_睫毛上下左CP.Update();
					this.X0Y4_睫毛上上右CP.Update();
					this.X0Y4_睫毛上中右CP.Update();
					this.X0Y4_睫毛上下右CP.Update();
					this.X0Y4_睫毛下上左CP.Update();
					this.X0Y4_睫毛下下左CP.Update();
					this.X0Y4_睫毛下上右CP.Update();
					this.X0Y4_睫毛下下右CP.Update();
					return;
				}
			}
			else
			{
				switch (this.本体.IndexY)
				{
				case 0:
					this.X1Y0_瞼下CP.Update();
					this.X1Y0_瞼上CP.Update();
					this.X1Y0_二重CP.Update();
					this.X1Y0_睫毛上上左CP.Update();
					this.X1Y0_睫毛上中左CP.Update();
					this.X1Y0_睫毛上下左CP.Update();
					this.X1Y0_睫毛上上右CP.Update();
					this.X1Y0_睫毛上中右CP.Update();
					this.X1Y0_睫毛上下右CP.Update();
					this.X1Y0_睫毛下上左CP.Update();
					this.X1Y0_睫毛下下左CP.Update();
					this.X1Y0_睫毛下上右CP.Update();
					this.X1Y0_睫毛下下右CP.Update();
					return;
				case 1:
					this.X1Y1_瞼下CP.Update();
					this.X1Y1_瞼上CP.Update();
					this.X1Y1_二重CP.Update();
					this.X1Y1_睫毛上上左CP.Update();
					this.X1Y1_睫毛上中左CP.Update();
					this.X1Y1_睫毛上下左CP.Update();
					this.X1Y1_睫毛上上右CP.Update();
					this.X1Y1_睫毛上中右CP.Update();
					this.X1Y1_睫毛上下右CP.Update();
					this.X1Y1_睫毛下上左CP.Update();
					this.X1Y1_睫毛下下左CP.Update();
					this.X1Y1_睫毛下上右CP.Update();
					this.X1Y1_睫毛下下右CP.Update();
					return;
				case 2:
					this.X1Y2_瞼下CP.Update();
					this.X1Y2_瞼上CP.Update();
					this.X1Y2_二重CP.Update();
					this.X1Y2_睫毛上上左CP.Update();
					this.X1Y2_睫毛上中左CP.Update();
					this.X1Y2_睫毛上下左CP.Update();
					this.X1Y2_睫毛上上右CP.Update();
					this.X1Y2_睫毛上中右CP.Update();
					this.X1Y2_睫毛上下右CP.Update();
					this.X1Y2_睫毛下上左CP.Update();
					this.X1Y2_睫毛下下左CP.Update();
					this.X1Y2_睫毛下上右CP.Update();
					this.X1Y2_睫毛下下右CP.Update();
					return;
				case 3:
					this.X1Y3_瞼下CP.Update();
					this.X1Y3_瞼上CP.Update();
					this.X1Y3_二重CP.Update();
					this.X1Y3_睫毛上上左CP.Update();
					this.X1Y3_睫毛上中左CP.Update();
					this.X1Y3_睫毛上下左CP.Update();
					this.X1Y3_睫毛上上右CP.Update();
					this.X1Y3_睫毛上中右CP.Update();
					this.X1Y3_睫毛上下右CP.Update();
					this.X1Y3_睫毛下上左CP.Update();
					this.X1Y3_睫毛下下左CP.Update();
					this.X1Y3_睫毛下上右CP.Update();
					this.X1Y3_睫毛下下右CP.Update();
					return;
				default:
					this.X1Y4_瞼下CP.Update();
					this.X1Y4_瞼上CP.Update();
					this.X1Y4_二重CP.Update();
					this.X1Y4_睫毛上上左CP.Update();
					this.X1Y4_睫毛上中左CP.Update();
					this.X1Y4_睫毛上下左CP.Update();
					this.X1Y4_睫毛上上右CP.Update();
					this.X1Y4_睫毛上中右CP.Update();
					this.X1Y4_睫毛上下右CP.Update();
					this.X1Y4_睫毛下上左CP.Update();
					this.X1Y4_睫毛下下左CP.Update();
					this.X1Y4_睫毛下上右CP.Update();
					this.X1Y4_睫毛下下右CP.Update();
					return;
				}
			}
		}

		public override void 色更新(Vector2D[] mm)
		{
			if (this.本体.IndexX == 0)
			{
				switch (this.本体.IndexY)
				{
				case 0:
					this.X0Y0_瞼下CP.Update(mm);
					this.X0Y0_瞼上CP.Update(mm);
					this.X0Y0_二重CP.Update();
					this.X0Y0_睫毛上上左CP.Update();
					this.X0Y0_睫毛上中左CP.Update();
					this.X0Y0_睫毛上下左CP.Update();
					this.X0Y0_睫毛上上右CP.Update();
					this.X0Y0_睫毛上中右CP.Update();
					this.X0Y0_睫毛上下右CP.Update();
					this.X0Y0_睫毛下上左CP.Update();
					this.X0Y0_睫毛下下左CP.Update();
					this.X0Y0_睫毛下上右CP.Update();
					this.X0Y0_睫毛下下右CP.Update();
					return;
				case 1:
					this.X0Y1_瞼下CP.Update(mm);
					this.X0Y1_瞼上CP.Update(mm);
					this.X0Y1_二重CP.Update();
					this.X0Y1_睫毛上上左CP.Update();
					this.X0Y1_睫毛上中左CP.Update();
					this.X0Y1_睫毛上下左CP.Update();
					this.X0Y1_睫毛上上右CP.Update();
					this.X0Y1_睫毛上中右CP.Update();
					this.X0Y1_睫毛上下右CP.Update();
					this.X0Y1_睫毛下上左CP.Update();
					this.X0Y1_睫毛下下左CP.Update();
					this.X0Y1_睫毛下上右CP.Update();
					this.X0Y1_睫毛下下右CP.Update();
					return;
				case 2:
					this.X0Y2_瞼下CP.Update(mm);
					this.X0Y2_瞼上CP.Update(mm);
					this.X0Y2_二重CP.Update();
					this.X0Y2_睫毛上上左CP.Update();
					this.X0Y2_睫毛上中左CP.Update();
					this.X0Y2_睫毛上下左CP.Update();
					this.X0Y2_睫毛上上右CP.Update();
					this.X0Y2_睫毛上中右CP.Update();
					this.X0Y2_睫毛上下右CP.Update();
					this.X0Y2_睫毛下上左CP.Update();
					this.X0Y2_睫毛下下左CP.Update();
					this.X0Y2_睫毛下上右CP.Update();
					this.X0Y2_睫毛下下右CP.Update();
					return;
				case 3:
					this.X0Y3_瞼下CP.Update(mm);
					this.X0Y3_瞼上CP.Update(mm);
					this.X0Y3_二重CP.Update();
					this.X0Y3_睫毛上上左CP.Update();
					this.X0Y3_睫毛上中左CP.Update();
					this.X0Y3_睫毛上下左CP.Update();
					this.X0Y3_睫毛上上右CP.Update();
					this.X0Y3_睫毛上中右CP.Update();
					this.X0Y3_睫毛上下右CP.Update();
					this.X0Y3_睫毛下上左CP.Update();
					this.X0Y3_睫毛下下左CP.Update();
					this.X0Y3_睫毛下上右CP.Update();
					this.X0Y3_睫毛下下右CP.Update();
					return;
				default:
					this.X0Y4_瞼下CP.Update(mm);
					this.X0Y4_瞼上CP.Update(mm);
					this.X0Y4_二重CP.Update();
					this.X0Y4_睫毛上上左CP.Update();
					this.X0Y4_睫毛上中左CP.Update();
					this.X0Y4_睫毛上下左CP.Update();
					this.X0Y4_睫毛上上右CP.Update();
					this.X0Y4_睫毛上中右CP.Update();
					this.X0Y4_睫毛上下右CP.Update();
					this.X0Y4_睫毛下上左CP.Update();
					this.X0Y4_睫毛下下左CP.Update();
					this.X0Y4_睫毛下上右CP.Update();
					this.X0Y4_睫毛下下右CP.Update();
					return;
				}
			}
			else
			{
				switch (this.本体.IndexY)
				{
				case 0:
					this.X1Y0_瞼下CP.Update(mm);
					this.X1Y0_瞼上CP.Update(mm);
					this.X1Y0_二重CP.Update();
					this.X1Y0_睫毛上上左CP.Update();
					this.X1Y0_睫毛上中左CP.Update();
					this.X1Y0_睫毛上下左CP.Update();
					this.X1Y0_睫毛上上右CP.Update();
					this.X1Y0_睫毛上中右CP.Update();
					this.X1Y0_睫毛上下右CP.Update();
					this.X1Y0_睫毛下上左CP.Update();
					this.X1Y0_睫毛下下左CP.Update();
					this.X1Y0_睫毛下上右CP.Update();
					this.X1Y0_睫毛下下右CP.Update();
					return;
				case 1:
					this.X1Y1_瞼下CP.Update(mm);
					this.X1Y1_瞼上CP.Update(mm);
					this.X1Y1_二重CP.Update();
					this.X1Y1_睫毛上上左CP.Update();
					this.X1Y1_睫毛上中左CP.Update();
					this.X1Y1_睫毛上下左CP.Update();
					this.X1Y1_睫毛上上右CP.Update();
					this.X1Y1_睫毛上中右CP.Update();
					this.X1Y1_睫毛上下右CP.Update();
					this.X1Y1_睫毛下上左CP.Update();
					this.X1Y1_睫毛下下左CP.Update();
					this.X1Y1_睫毛下上右CP.Update();
					this.X1Y1_睫毛下下右CP.Update();
					return;
				case 2:
					this.X1Y2_瞼下CP.Update(mm);
					this.X1Y2_瞼上CP.Update(mm);
					this.X1Y2_二重CP.Update();
					this.X1Y2_睫毛上上左CP.Update();
					this.X1Y2_睫毛上中左CP.Update();
					this.X1Y2_睫毛上下左CP.Update();
					this.X1Y2_睫毛上上右CP.Update();
					this.X1Y2_睫毛上中右CP.Update();
					this.X1Y2_睫毛上下右CP.Update();
					this.X1Y2_睫毛下上左CP.Update();
					this.X1Y2_睫毛下下左CP.Update();
					this.X1Y2_睫毛下上右CP.Update();
					this.X1Y2_睫毛下下右CP.Update();
					return;
				case 3:
					this.X1Y3_瞼下CP.Update(mm);
					this.X1Y3_瞼上CP.Update(mm);
					this.X1Y3_二重CP.Update();
					this.X1Y3_睫毛上上左CP.Update();
					this.X1Y3_睫毛上中左CP.Update();
					this.X1Y3_睫毛上下左CP.Update();
					this.X1Y3_睫毛上上右CP.Update();
					this.X1Y3_睫毛上中右CP.Update();
					this.X1Y3_睫毛上下右CP.Update();
					this.X1Y3_睫毛下上左CP.Update();
					this.X1Y3_睫毛下下左CP.Update();
					this.X1Y3_睫毛下上右CP.Update();
					this.X1Y3_睫毛下下右CP.Update();
					return;
				default:
					this.X1Y4_瞼下CP.Update(mm);
					this.X1Y4_瞼上CP.Update(mm);
					this.X1Y4_二重CP.Update();
					this.X1Y4_睫毛上上左CP.Update();
					this.X1Y4_睫毛上中左CP.Update();
					this.X1Y4_睫毛上下左CP.Update();
					this.X1Y4_睫毛上上右CP.Update();
					this.X1Y4_睫毛上中右CP.Update();
					this.X1Y4_睫毛上下右CP.Update();
					this.X1Y4_睫毛下上左CP.Update();
					this.X1Y4_睫毛下下左CP.Update();
					this.X1Y4_睫毛下上右CP.Update();
					this.X1Y4_睫毛下下右CP.Update();
					return;
				}
			}
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.瞼下CD = new ColorD(ref 体配色.睫毛.Col1, ref 体配色.人肌O);
			this.瞼上CD = new ColorD(ref 体配色.睫毛.Col1, ref 体配色.人肌O);
			this.二重CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.睫毛上上左CD = new ColorD(ref 体配色.睫毛.Col1, ref 体配色.睫毛);
			this.睫毛上中左CD = new ColorD(ref 体配色.睫毛.Col1, ref 体配色.睫毛);
			this.睫毛上下左CD = new ColorD(ref 体配色.睫毛.Col1, ref 体配色.睫毛);
			this.睫毛上上右CD = new ColorD(ref 体配色.睫毛.Col1, ref 体配色.睫毛);
			this.睫毛上中右CD = new ColorD(ref 体配色.睫毛.Col1, ref 体配色.睫毛);
			this.睫毛上下右CD = new ColorD(ref 体配色.睫毛.Col1, ref 体配色.睫毛);
			this.睫毛下上左CD = new ColorD(ref 体配色.睫毛.Col1, ref 体配色.睫毛);
			this.睫毛下下左CD = new ColorD(ref 体配色.睫毛.Col1, ref 体配色.睫毛);
			this.睫毛下上右CD = new ColorD(ref 体配色.睫毛.Col1, ref 体配色.睫毛);
			this.睫毛下下右CD = new ColorD(ref 体配色.睫毛.Col1, ref 体配色.睫毛);
		}

		public Par X0Y0_瞼下;

		public Par X0Y0_瞼上;

		public Par X0Y0_二重;

		public Par X0Y0_睫毛上上左;

		public Par X0Y0_睫毛上中左;

		public Par X0Y0_睫毛上下左;

		public Par X0Y0_睫毛上上右;

		public Par X0Y0_睫毛上中右;

		public Par X0Y0_睫毛上下右;

		public Par X0Y0_睫毛下上左;

		public Par X0Y0_睫毛下下左;

		public Par X0Y0_睫毛下上右;

		public Par X0Y0_睫毛下下右;

		public Par X0Y1_瞼下;

		public Par X0Y1_瞼上;

		public Par X0Y1_二重;

		public Par X0Y1_睫毛上上左;

		public Par X0Y1_睫毛上中左;

		public Par X0Y1_睫毛上下左;

		public Par X0Y1_睫毛上上右;

		public Par X0Y1_睫毛上中右;

		public Par X0Y1_睫毛上下右;

		public Par X0Y1_睫毛下上左;

		public Par X0Y1_睫毛下下左;

		public Par X0Y1_睫毛下上右;

		public Par X0Y1_睫毛下下右;

		public Par X0Y2_瞼下;

		public Par X0Y2_瞼上;

		public Par X0Y2_二重;

		public Par X0Y2_睫毛上上左;

		public Par X0Y2_睫毛上中左;

		public Par X0Y2_睫毛上下左;

		public Par X0Y2_睫毛上上右;

		public Par X0Y2_睫毛上中右;

		public Par X0Y2_睫毛上下右;

		public Par X0Y2_睫毛下上左;

		public Par X0Y2_睫毛下下左;

		public Par X0Y2_睫毛下上右;

		public Par X0Y2_睫毛下下右;

		public Par X0Y3_瞼下;

		public Par X0Y3_瞼上;

		public Par X0Y3_二重;

		public Par X0Y3_睫毛上上左;

		public Par X0Y3_睫毛上中左;

		public Par X0Y3_睫毛上下左;

		public Par X0Y3_睫毛上上右;

		public Par X0Y3_睫毛上中右;

		public Par X0Y3_睫毛上下右;

		public Par X0Y3_睫毛下上左;

		public Par X0Y3_睫毛下下左;

		public Par X0Y3_睫毛下上右;

		public Par X0Y3_睫毛下下右;

		public Par X0Y4_瞼下;

		public Par X0Y4_瞼上;

		public Par X0Y4_二重;

		public Par X0Y4_睫毛上上左;

		public Par X0Y4_睫毛上中左;

		public Par X0Y4_睫毛上下左;

		public Par X0Y4_睫毛上上右;

		public Par X0Y4_睫毛上中右;

		public Par X0Y4_睫毛上下右;

		public Par X0Y4_睫毛下上左;

		public Par X0Y4_睫毛下下左;

		public Par X0Y4_睫毛下上右;

		public Par X0Y4_睫毛下下右;

		public Par X1Y0_瞼下;

		public Par X1Y0_瞼上;

		public Par X1Y0_二重;

		public Par X1Y0_睫毛上上左;

		public Par X1Y0_睫毛上中左;

		public Par X1Y0_睫毛上下左;

		public Par X1Y0_睫毛上上右;

		public Par X1Y0_睫毛上中右;

		public Par X1Y0_睫毛上下右;

		public Par X1Y0_睫毛下上左;

		public Par X1Y0_睫毛下下左;

		public Par X1Y0_睫毛下上右;

		public Par X1Y0_睫毛下下右;

		public Par X1Y1_瞼下;

		public Par X1Y1_瞼上;

		public Par X1Y1_二重;

		public Par X1Y1_睫毛上上左;

		public Par X1Y1_睫毛上中左;

		public Par X1Y1_睫毛上下左;

		public Par X1Y1_睫毛上上右;

		public Par X1Y1_睫毛上中右;

		public Par X1Y1_睫毛上下右;

		public Par X1Y1_睫毛下上左;

		public Par X1Y1_睫毛下下左;

		public Par X1Y1_睫毛下上右;

		public Par X1Y1_睫毛下下右;

		public Par X1Y2_瞼下;

		public Par X1Y2_瞼上;

		public Par X1Y2_二重;

		public Par X1Y2_睫毛上上左;

		public Par X1Y2_睫毛上中左;

		public Par X1Y2_睫毛上下左;

		public Par X1Y2_睫毛上上右;

		public Par X1Y2_睫毛上中右;

		public Par X1Y2_睫毛上下右;

		public Par X1Y2_睫毛下上左;

		public Par X1Y2_睫毛下下左;

		public Par X1Y2_睫毛下上右;

		public Par X1Y2_睫毛下下右;

		public Par X1Y3_瞼下;

		public Par X1Y3_瞼上;

		public Par X1Y3_二重;

		public Par X1Y3_睫毛上上左;

		public Par X1Y3_睫毛上中左;

		public Par X1Y3_睫毛上下左;

		public Par X1Y3_睫毛上上右;

		public Par X1Y3_睫毛上中右;

		public Par X1Y3_睫毛上下右;

		public Par X1Y3_睫毛下上左;

		public Par X1Y3_睫毛下下左;

		public Par X1Y3_睫毛下上右;

		public Par X1Y3_睫毛下下右;

		public Par X1Y4_瞼下;

		public Par X1Y4_瞼上;

		public Par X1Y4_二重;

		public Par X1Y4_睫毛上上左;

		public Par X1Y4_睫毛上中左;

		public Par X1Y4_睫毛上下左;

		public Par X1Y4_睫毛上上右;

		public Par X1Y4_睫毛上中右;

		public Par X1Y4_睫毛上下右;

		public Par X1Y4_睫毛下上左;

		public Par X1Y4_睫毛下下左;

		public Par X1Y4_睫毛下上右;

		public Par X1Y4_睫毛下下右;

		public ColorD 瞼下CD;

		public ColorD 瞼上CD;

		public ColorD 二重CD;

		public ColorD 睫毛上上左CD;

		public ColorD 睫毛上中左CD;

		public ColorD 睫毛上下左CD;

		public ColorD 睫毛上上右CD;

		public ColorD 睫毛上中右CD;

		public ColorD 睫毛上下右CD;

		public ColorD 睫毛下上左CD;

		public ColorD 睫毛下下左CD;

		public ColorD 睫毛下上右CD;

		public ColorD 睫毛下下右CD;

		public ColorP X0Y0_瞼下CP;

		public ColorP X0Y0_瞼上CP;

		public ColorP X0Y0_二重CP;

		public ColorP X0Y0_睫毛上上左CP;

		public ColorP X0Y0_睫毛上中左CP;

		public ColorP X0Y0_睫毛上下左CP;

		public ColorP X0Y0_睫毛上上右CP;

		public ColorP X0Y0_睫毛上中右CP;

		public ColorP X0Y0_睫毛上下右CP;

		public ColorP X0Y0_睫毛下上左CP;

		public ColorP X0Y0_睫毛下下左CP;

		public ColorP X0Y0_睫毛下上右CP;

		public ColorP X0Y0_睫毛下下右CP;

		public ColorP X0Y1_瞼下CP;

		public ColorP X0Y1_瞼上CP;

		public ColorP X0Y1_二重CP;

		public ColorP X0Y1_睫毛上上左CP;

		public ColorP X0Y1_睫毛上中左CP;

		public ColorP X0Y1_睫毛上下左CP;

		public ColorP X0Y1_睫毛上上右CP;

		public ColorP X0Y1_睫毛上中右CP;

		public ColorP X0Y1_睫毛上下右CP;

		public ColorP X0Y1_睫毛下上左CP;

		public ColorP X0Y1_睫毛下下左CP;

		public ColorP X0Y1_睫毛下上右CP;

		public ColorP X0Y1_睫毛下下右CP;

		public ColorP X0Y2_瞼下CP;

		public ColorP X0Y2_瞼上CP;

		public ColorP X0Y2_二重CP;

		public ColorP X0Y2_睫毛上上左CP;

		public ColorP X0Y2_睫毛上中左CP;

		public ColorP X0Y2_睫毛上下左CP;

		public ColorP X0Y2_睫毛上上右CP;

		public ColorP X0Y2_睫毛上中右CP;

		public ColorP X0Y2_睫毛上下右CP;

		public ColorP X0Y2_睫毛下上左CP;

		public ColorP X0Y2_睫毛下下左CP;

		public ColorP X0Y2_睫毛下上右CP;

		public ColorP X0Y2_睫毛下下右CP;

		public ColorP X0Y3_瞼下CP;

		public ColorP X0Y3_瞼上CP;

		public ColorP X0Y3_二重CP;

		public ColorP X0Y3_睫毛上上左CP;

		public ColorP X0Y3_睫毛上中左CP;

		public ColorP X0Y3_睫毛上下左CP;

		public ColorP X0Y3_睫毛上上右CP;

		public ColorP X0Y3_睫毛上中右CP;

		public ColorP X0Y3_睫毛上下右CP;

		public ColorP X0Y3_睫毛下上左CP;

		public ColorP X0Y3_睫毛下下左CP;

		public ColorP X0Y3_睫毛下上右CP;

		public ColorP X0Y3_睫毛下下右CP;

		public ColorP X0Y4_瞼下CP;

		public ColorP X0Y4_瞼上CP;

		public ColorP X0Y4_二重CP;

		public ColorP X0Y4_睫毛上上左CP;

		public ColorP X0Y4_睫毛上中左CP;

		public ColorP X0Y4_睫毛上下左CP;

		public ColorP X0Y4_睫毛上上右CP;

		public ColorP X0Y4_睫毛上中右CP;

		public ColorP X0Y4_睫毛上下右CP;

		public ColorP X0Y4_睫毛下上左CP;

		public ColorP X0Y4_睫毛下下左CP;

		public ColorP X0Y4_睫毛下上右CP;

		public ColorP X0Y4_睫毛下下右CP;

		public ColorP X1Y0_瞼下CP;

		public ColorP X1Y0_瞼上CP;

		public ColorP X1Y0_二重CP;

		public ColorP X1Y0_睫毛上上左CP;

		public ColorP X1Y0_睫毛上中左CP;

		public ColorP X1Y0_睫毛上下左CP;

		public ColorP X1Y0_睫毛上上右CP;

		public ColorP X1Y0_睫毛上中右CP;

		public ColorP X1Y0_睫毛上下右CP;

		public ColorP X1Y0_睫毛下上左CP;

		public ColorP X1Y0_睫毛下下左CP;

		public ColorP X1Y0_睫毛下上右CP;

		public ColorP X1Y0_睫毛下下右CP;

		public ColorP X1Y1_瞼下CP;

		public ColorP X1Y1_瞼上CP;

		public ColorP X1Y1_二重CP;

		public ColorP X1Y1_睫毛上上左CP;

		public ColorP X1Y1_睫毛上中左CP;

		public ColorP X1Y1_睫毛上下左CP;

		public ColorP X1Y1_睫毛上上右CP;

		public ColorP X1Y1_睫毛上中右CP;

		public ColorP X1Y1_睫毛上下右CP;

		public ColorP X1Y1_睫毛下上左CP;

		public ColorP X1Y1_睫毛下下左CP;

		public ColorP X1Y1_睫毛下上右CP;

		public ColorP X1Y1_睫毛下下右CP;

		public ColorP X1Y2_瞼下CP;

		public ColorP X1Y2_瞼上CP;

		public ColorP X1Y2_二重CP;

		public ColorP X1Y2_睫毛上上左CP;

		public ColorP X1Y2_睫毛上中左CP;

		public ColorP X1Y2_睫毛上下左CP;

		public ColorP X1Y2_睫毛上上右CP;

		public ColorP X1Y2_睫毛上中右CP;

		public ColorP X1Y2_睫毛上下右CP;

		public ColorP X1Y2_睫毛下上左CP;

		public ColorP X1Y2_睫毛下下左CP;

		public ColorP X1Y2_睫毛下上右CP;

		public ColorP X1Y2_睫毛下下右CP;

		public ColorP X1Y3_瞼下CP;

		public ColorP X1Y3_瞼上CP;

		public ColorP X1Y3_二重CP;

		public ColorP X1Y3_睫毛上上左CP;

		public ColorP X1Y3_睫毛上中左CP;

		public ColorP X1Y3_睫毛上下左CP;

		public ColorP X1Y3_睫毛上上右CP;

		public ColorP X1Y3_睫毛上中右CP;

		public ColorP X1Y3_睫毛上下右CP;

		public ColorP X1Y3_睫毛下上左CP;

		public ColorP X1Y3_睫毛下下左CP;

		public ColorP X1Y3_睫毛下上右CP;

		public ColorP X1Y3_睫毛下下右CP;

		public ColorP X1Y4_瞼下CP;

		public ColorP X1Y4_瞼上CP;

		public ColorP X1Y4_二重CP;

		public ColorP X1Y4_睫毛上上左CP;

		public ColorP X1Y4_睫毛上中左CP;

		public ColorP X1Y4_睫毛上下左CP;

		public ColorP X1Y4_睫毛上上右CP;

		public ColorP X1Y4_睫毛上中右CP;

		public ColorP X1Y4_睫毛上下右CP;

		public ColorP X1Y4_睫毛下上左CP;

		public ColorP X1Y4_睫毛下下左CP;

		public ColorP X1Y4_睫毛下上右CP;

		public ColorP X1Y4_睫毛下下右CP;
	}
}
