using System;
using System.Collections.Generic;

namespace _2DGAMELIB
{
	[Serializable]
	public class JointD
	{
		public JointD(Difs Difs0, Par Par0, int Index, Difs Difs1)
		{
			this.Difs0 = Difs0;
			this.Path0 = Par0.GetPath();
			this.Index = Index;
			this.Difs1 = Difs1;
		}

		public JointD(Difs Difs1)
		{
			this.Difs1 = Difs1;
		}

		public void JoinP()
		{
			this.Difs0.Current.GetPar(this.Path0).SetJointP(this.Index, this.Difs1.CurJoinRoot);
			this.Difs1.JoinPA();
		}

		public void JoinPA()
		{
			this.Difs0.Current.GetPar(this.Path0).SetJointPA(this.Index, this.Difs1.CurJoinRoot);
			this.Difs1.JoinPA();
		}

		public void JoinPall()
		{
			foreach (Par par in this.Difs1.EnumJoinRoot)
			{
				this.Difs0.Current.GetPar(this.Path0).SetJointP(this.Index, par);
			}
			foreach (Pars ps in this.Difs1.EnumAllPars())
			{
				this.Difs1.JoinPA(ps);
			}
		}

		public void JoinPAall()
		{
			foreach (Par par in this.Difs1.EnumJoinRoot)
			{
				this.Difs0.Current.GetPar(this.Path0).SetJointPA(this.Index, par);
			}
			foreach (Pars ps in this.Difs1.EnumAllPars())
			{
				this.Difs1.JoinPA(ps);
			}
		}

		public void Set(JointS 接続元)
		{
			this.Difs0 = 接続元.Difs;
			this.Path0 = 接続元.Path;
			this.Index = 接続元.Index;
		}

		public Difs Difs0;

		public List<int> Path0;

		public int Index;

		public Difs Difs1;
	}
}
