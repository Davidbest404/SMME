using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class EleD
	{
		public virtual Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
		{
			return null;
		}

		public virtual Ele GetEle(double DisUnit, Med Med, 主人公配色 体配色)
		{
			return null;
		}

		public bool 傷物処理()
		{
			bool flag = false;
			foreach (FieldInfo fieldInfo in from e in this.ThisType.GetFields()
			where e.Name.EndsWith("_表示") && e.Name.Contains("傷")
			select e)
			{
				bool flag2;
				fieldInfo.SetValue(this, flag2 = 0.3.Lot());
				flag = (flag || flag2);
			}
			return flag;
		}

		public virtual IEnumerable<EleD> EnumEleD()
		{
			yield return this;
			foreach (FieldInfo fieldInfo in from e in this.ThisType.GetFields()
			where e.FieldType.ToString() == Sta.lt
			select e)
			{
				List<EleD> list = (List<EleD>)fieldInfo.GetValue(this);
				if (list != null)
				{
					foreach (EleD eleD in list)
					{
						foreach (EleD eleD2 in eleD.EnumEleD())
						{
							yield return eleD2;
						}
						IEnumerator<EleD> enumerator3 = null;
					}
					List<EleD>.Enumerator enumerator2 = default(List<EleD>.Enumerator);
				}
			}
			IEnumerator<FieldInfo> enumerator = null;
			yield break;
			yield break;
		}

		public EleD Copy()
		{
			EleD.<>c__DisplayClass38_0 CS$<>8__locals1 = new EleD.<>c__DisplayClass38_0();
			CS$<>8__locals1.r = (EleD)Activator.CreateInstance(this.ThisType);
			EleD ec;
			Func<EleD, EleD> <>9__0;
			foreach (FieldInfo fieldInfo in this.ThisType.GetFields())
			{
				if (fieldInfo.FieldType.ToString() == Sta.lt)
				{
					List<EleD> list = (List<EleD>)fieldInfo.GetValue(this);
					if (list != null)
					{
						FieldInfo fieldInfo2 = fieldInfo;
						object r = CS$<>8__locals1.r;
						IEnumerable<EleD> source = list;
						Func<EleD, EleD> selector;
						if ((selector = <>9__0) == null)
						{
							selector = (<>9__0 = delegate(EleD e)
							{
								ec = e.Copy();
								ec.Par = CS$<>8__locals1.r;
								return ec;
							});
						}
						fieldInfo2.SetValue(r, source.Select(selector).ToList<EleD>());
					}
				}
				else
				{
					fieldInfo.SetValue(CS$<>8__locals1.r, fieldInfo.GetValue(this));
				}
			}
			return CS$<>8__locals1.r;
		}

		public EleD Copy_以下無()
		{
			EleD eleD = (EleD)Activator.CreateInstance(this.ThisType);
			foreach (FieldInfo fieldInfo in this.ThisType.GetFields())
			{
				if (!fieldInfo.Name.Contains("_接続"))
				{
					fieldInfo.SetValue(eleD, fieldInfo.GetValue(this));
				}
			}
			return eleD;
		}

		public EleD Get逆()
		{
			EleD eleD = this.Copy();
			foreach (EleD eleD2 in eleD.EnumEleD())
			{
				eleD2.右 = !eleD2.右;
				eleD2.角度B = -eleD2.角度B;
				eleD2.角度C = -eleD2.角度C;
			}
			return eleD;
		}

		public IEnumerable<接続情報> Enum接続情報()
		{
			string h = this.ThisType.Name.Remove(this.ThisType.Name.Length - 1);
			foreach (FieldInfo fieldInfo in this.ThisType.GetFields())
			{
				if (fieldInfo.Name.Contains("_接続"))
				{
					yield return (h + "_" + fieldInfo.Name).To接続情報();
				}
			}
			FieldInfo[] array = null;
			yield break;
		}

		public void 接続(接続情報 接続情報, EleD ed)
		{
			string text = this.ThisType.Name.Remove(this.ThisType.Name.Length - 1);
			MethodBase method = this.ThisType.GetMethod(接続情報.ToString().Remove(0, text.Length).Replace("_", ""));
			object[] parameters = new EleD[]
			{
				ed
			};
			method.Invoke(this, parameters);
		}

		public List<EleD> Get接続(接続情報 接続情報)
		{
			return (List<EleD>)this.ThisType.GetField(接続情報.ToString().Remove(0, this.ThisType.Name.Length)).GetValue(this);
		}

		public EleD Par;

		public 接続情報 接続情報;

		public bool 欠損;

		public bool 筋肉;

		public bool 拘束;

		public Vector2D 基準B = Dat.Vec2DZero;

		public Vector2D 基準C = Dat.Vec2DZero;

		public Vector2D 位置B = Dat.Vec2DZero;

		public Vector2D 位置C = Dat.Vec2DZero;

		public double 角度B;

		public double 角度C;

		public double 尺度B = 1.0;

		public double 尺度C = 1.0;

		public double 尺度XB = 1.0;

		public double 尺度XC = 1.0;

		public double 尺度YB = 1.0;

		public double 尺度YC = 1.0;

		public double 肥大;

		public double 身長;

		public bool 右;

		public bool 反転X;

		public bool 反転Y;

		public double Xv;

		public double Yv;

		public int Xi;

		public int Yi;

		public 配色指定 配色指定;

		public double サイズ = 0.5;

		public double サイズX = 0.5;

		public double サイズY = 0.5;

		public bool 表示 = true;

		public double 濃度 = 1.0;

		public Type ThisType;
	}
}
