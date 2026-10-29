using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Microsoft.CSharp.RuntimeBinder;

namespace _2DGAMELIB
{
	[Serializable]
	public class MABuffer<T>
	{
		public MABuffer()
		{
			this.ran = 0;
			this.buf = new List<T>();
		}

		public MABuffer(int Range)
		{
			this.ran = Range;
			this.buf = new List<T>(Range);
		}

		public MABuffer(ref int Range)
		{
			this.ran = Range;
			this.buf = new List<T>(Range);
		}

		public void Add(T Value)
		{
			this.Add(ref Value);
		}

		public void Add(ref T Value)
		{
			if (this.buf.Count < this.ran)
			{
				this.buf.Add(Value);
				return;
			}
			this.buf.RemoveAt(0);
			this.buf.Add(Value);
		}

		public T GetAverage()
		{
			object arg = default(T);
			foreach (T arg2 in this.buf)
			{
				if (MABuffer<T>.<>o__7.<>p__0 == null)
				{
					MABuffer<T>.<>o__7.<>p__0 = CallSite<Func<CallSite, object, T, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.AddAssign, typeof(MABuffer<T>), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				arg = MABuffer<T>.<>o__7.<>p__0.Target(MABuffer<T>.<>o__7.<>p__0, arg, arg2);
			}
			if (MABuffer<T>.<>o__7.<>p__2 == null)
			{
				MABuffer<T>.<>o__7.<>p__2 = CallSite<Func<CallSite, object, T>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(T), typeof(MABuffer<T>)));
			}
			Func<CallSite, object, T> target = MABuffer<T>.<>o__7.<>p__2.Target;
			CallSite <>p__ = MABuffer<T>.<>o__7.<>p__2;
			if (MABuffer<T>.<>o__7.<>p__1 == null)
			{
				MABuffer<T>.<>o__7.<>p__1 = CallSite<Func<CallSite, object, double, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Divide, typeof(MABuffer<T>), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
				}));
			}
			return target(<>p__, MABuffer<T>.<>o__7.<>p__1.Target(MABuffer<T>.<>o__7.<>p__1, arg, (double)this.buf.Count));
		}

		public void Clear()
		{
			this.buf.Clear();
		}

		public List<T> Buffer
		{
			get
			{
				return this.buf;
			}
		}

		public int Range
		{
			get
			{
				return this.ran;
			}
			set
			{
				while (this.buf.Count > value)
				{
					this.buf.RemoveAt(0);
				}
				this.ran = value;
			}
		}

		private int ran;

		private List<T> buf;
	}
}
