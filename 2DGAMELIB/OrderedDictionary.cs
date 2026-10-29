using System;
using System.Collections.Generic;
using System.Linq;

namespace _2DGAMELIB
{
	[Serializable]
	public class OrderedDictionary<T1, T2>
	{
		public OrderedDictionary()
		{
			this.keys = new List<T1>();
			this.values = new Dictionary<T1, T2>();
		}

		public OrderedDictionary(int capacity)
		{
			this.keys = new List<T1>(capacity);
			this.values = new Dictionary<T1, T2>(capacity);
		}

		public int IndexOf(T1 Key)
		{
			return this.keys.IndexOf(Key);
		}

		public int IndexOf(ref T1 Key)
		{
			return this.keys.IndexOf(Key);
		}

		public int IndexOf(T2 Value)
		{
			int num = 0;
			foreach (T2 t in this.Values)
			{
				if (t.Equals(Value))
				{
					return num;
				}
				num++;
			}
			return -1;
		}

		public int IndexOf(ref T2 Value)
		{
			int num = 0;
			foreach (T2 t in this.Values)
			{
				if (t.Equals(Value))
				{
					return num;
				}
				num++;
			}
			return -1;
		}

		public int LastIndexOf(T1 Key)
		{
			return this.keys.LastIndexOf(Key);
		}

		public int LastIndexOf(ref T1 Key)
		{
			return this.keys.LastIndexOf(Key);
		}

		public int LastIndexOf(T2 Value)
		{
			int num = this.keys.Count - 1;
			foreach (T2 t in this.Values.Reverse<T2>())
			{
				if (t.Equals(Value))
				{
					return num;
				}
				num--;
			}
			return -1;
		}

		public int LastIndexOf(ref T2 Value)
		{
			int num = this.keys.Count - 1;
			foreach (T2 t in this.Values.Reverse<T2>())
			{
				if (t.Equals(Value))
				{
					return num;
				}
				num--;
			}
			return -1;
		}

		public T2 this[T1 Key]
		{
			get
			{
				return this.values[Key];
			}
			set
			{
				this.values[Key] = value;
			}
		}

		public T2 this[int Index]
		{
			get
			{
				return this.values[this.keys[Index]];
			}
			set
			{
				this.values[this.keys[Index]] = value;
			}
		}

		public IEnumerable<T1> Keys
		{
			get
			{
				return this.keys;
			}
		}

		public IEnumerable<T2> Values
		{
			get
			{
				foreach (T1 key in this.keys)
				{
					yield return this.values[key];
				}
				List<T1>.Enumerator enumerator = default(List<T1>.Enumerator);
				yield break;
				yield break;
			}
		}

		public int Count
		{
			get
			{
				return this.keys.Count;
			}
		}

		public void Add(T1 Key, T2 Value)
		{
			this.keys.Add(Key);
			this.values.Add(Key, Value);
		}

		public void Add(ref T1 Key, ref T2 Value)
		{
			this.keys.Add(Key);
			this.values.Add(Key, Value);
		}

		public void Insert(int Index, T1 Key, T2 Value)
		{
			this.keys.Insert(Index, Key);
			this.values.Add(Key, Value);
		}

		public void Insert(int Index, ref T1 Key, ref T2 Value)
		{
			this.keys.Insert(Index, Key);
			this.values.Add(Key, Value);
		}

		public void Remove(T1 Key)
		{
			this.keys.Remove(Key);
			this.values.Remove(Key);
		}

		public void Remove(ref T1 Key)
		{
			this.keys.Remove(Key);
			this.values.Remove(Key);
		}

		public void Reverse()
		{
			this.keys.Reverse();
		}

		public void Reverse(int Index, int Count)
		{
			this.keys.Reverse(Index, Count);
		}

		public bool ContainsKey(T1 Key)
		{
			return this.values.ContainsKey(Key);
		}

		public bool ContainsKey(ref T1 Key)
		{
			return this.values.ContainsKey(Key);
		}

		public bool ContainsValue(T2 Value)
		{
			return this.values.ContainsValue(Value);
		}

		public bool ContainsValue(ref T2 Value)
		{
			return this.values.ContainsValue(Value);
		}

		private List<T1> keys;

		private Dictionary<T1, T2> values;
	}
}
