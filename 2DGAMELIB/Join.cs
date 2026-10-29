using System;
using System.Collections.Generic;
using System.Linq;

namespace _2DGAMELIB
{
	public static class Join
	{
		public static Joints GetJoints(this Par JoinRoot, IEnumerable<Par> EnumPar)
		{
			Joints joints = new Joints();
			int num = 0;
			List<int> list = new List<int>();
			List<Par> list2 = EnumPar.ToList<Par>();
			foreach (Joi joi in JoinRoot.JP)
			{
				Vector2D v = JoinRoot.ToGlobal(joi.Joint);
				int num2 = 0;
				list.Clear();
				foreach (Par par in list2)
				{
					if (JoinRoot != par)
					{
						if (v.DistanceSquared(par.Position) <= Join.IdentityDistance)
						{
							joints.Joins.Add(new Joint(JoinRoot, num, par));
							if (!list.Contains(num2))
							{
								list.Add(num2);
							}
						}
					}
					else if (!list.Contains(num2))
					{
						list.Add(num2);
					}
					num2++;
				}
				for (int i = list.Count - 1; i > -1; i--)
				{
					list2.RemoveAt(list[i]);
				}
				num++;
			}
			Join.GetJoints(list2, joints, list);
			return joints;
		}

		private static void GetJoints(List<Par> pl, Joints js, List<int> del)
		{
			int num = -1;
			int num2 = 0;
			while (num != js.Joins.Count)
			{
				num = js.Joins.Count;
				for (int i = num2; i < num; i++)
				{
					Par par = js.Joins[i].Par1;
					int num3 = 0;
					foreach (Joi joi in par.JP)
					{
						Vector2D v = par.ToGlobal(joi.Joint);
						int num4 = 0;
						del.Clear();
						foreach (Par par2 in pl)
						{
							if (par != par2)
							{
								if (v.DistanceSquared(par2.Position) <= Join.IdentityDistance)
								{
									js.Joins.Add(new Joint(par, num3, par2));
									if (!del.Contains(num4))
									{
										del.Add(num4);
									}
								}
							}
							else if (!del.Contains(num4))
							{
								del.Add(num4);
							}
							num4++;
						}
						for (int j = del.Count - 1; j > -1; j--)
						{
							pl.RemoveAt(del[j]);
						}
						num3++;
					}
				}
				num2 = num;
			}
		}

		public static JointsD GetJointsD(this Difs JoinRoot, IEnumerable<Difs> EnumDifs)
		{
			JointsD jointsD = new JointsD();
			List<int> list = new List<int>();
			List<Difs> list2 = EnumDifs.ToList<Difs>();
			foreach (Par par in JoinRoot.EnumAllPar())
			{
				int num = 0;
				list.Clear();
				foreach (Difs difs in list2)
				{
					if (JoinRoot != difs)
					{
						int num2 = 0;
						using (List<Joi>.Enumerator enumerator3 = par.JP.GetEnumerator())
						{
							while (enumerator3.MoveNext())
							{
								Joi joi = enumerator3.Current;
								Vector2D v = par.ToGlobal(joi.Joint);
								foreach (Par par2 in difs.EnumJoinRoot)
								{
									if (v.DistanceSquared(par2.Position) <= Join.IdentityDistance)
									{
										jointsD.Joins.Add(new JointD(JoinRoot, par, num2, difs));
										if (!list.Contains(num))
										{
											list.Add(num);
											break;
										}
										break;
									}
								}
								num2++;
							}
							goto IL_125;
						}
						goto IL_113;
					}
					goto IL_113;
					IL_125:
					num++;
					continue;
					IL_113:
					if (!list.Contains(num))
					{
						list.Add(num);
						goto IL_125;
					}
					goto IL_125;
				}
				for (int i = list.Count - 1; i > -1; i--)
				{
					list2.RemoveAt(list[i]);
				}
			}
			Join.GetJointsD(list2, jointsD, list);
			return jointsD;
		}

		private static void GetJointsD(List<Difs> dl, JointsD jsd, List<int> del)
		{
			int num = -1;
			int num2 = 0;
			while (num != jsd.Joins.Count)
			{
				num = jsd.Joins.Count;
				for (int i = num2; i < num; i++)
				{
					Difs difs = jsd.Joins[i].Difs1;
					foreach (Par par in difs.EnumAllPar())
					{
						int num3 = 0;
						del.Clear();
						foreach (Difs difs2 in dl)
						{
							if (difs != difs2)
							{
								int num4 = 0;
								using (List<Joi>.Enumerator enumerator3 = par.JP.GetEnumerator())
								{
									while (enumerator3.MoveNext())
									{
										Joi joi = enumerator3.Current;
										Vector2D v = par.ToGlobal(joi.Joint);
										foreach (Par par2 in difs2.EnumJoinRoot)
										{
											if (v.DistanceSquared(par2.Position) <= Join.IdentityDistance)
											{
												jsd.Joins.Add(new JointD(difs, par, num4, difs2));
												if (!del.Contains(num3))
												{
													del.Add(num3);
													break;
												}
												break;
											}
										}
										num4++;
									}
									goto IL_140;
								}
								goto IL_130;
							}
							goto IL_130;
							IL_140:
							num3++;
							continue;
							IL_130:
							if (!del.Contains(num3))
							{
								del.Add(num3);
								goto IL_140;
							}
							goto IL_140;
						}
						for (int j = del.Count - 1; j > -1; j--)
						{
							dl.RemoveAt(del[j]);
						}
					}
				}
				num2 = num;
			}
		}

		public static double IdentityDistance = Math.Pow(5E-05, 2.0);
	}
}
