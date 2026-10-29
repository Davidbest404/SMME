using System;
using System.Collections.Generic;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 頭色更新
	{
		public 頭色更新(頭 頭, 単瞼 単瞼, 双瞼 瞼左, 双瞼 瞼右, 縦瞼 額瞼, 頬瞼 頬左, 頬瞼 頬右)
		{
			this.頭 = 頭;
			this.瞼 = this.EnumNoNull(単瞼, 瞼左, 瞼右, 額瞼, 頬左, 頬右).ToArray<Ele>();
		}

		private IEnumerable<Ele> EnumNoNull(単瞼 単瞼, 双瞼 瞼左, 双瞼 瞼右, 縦瞼 額瞼, 頬瞼 頬左, 頬瞼 頬右)
		{
			if (this.瞼 != null)
			{
				yield return 単瞼;
			}
			if (瞼左 != null)
			{
				yield return 瞼左;
			}
			if (瞼右 != null)
			{
				yield return 瞼右;
			}
			if (額瞼 != null)
			{
				yield return 額瞼;
			}
			if (頬左 != null)
			{
				yield return 頬左;
			}
			if (頬右 != null)
			{
				yield return 頬右;
			}
			yield break;
		}

		public void 色更新()
		{
			this.頭.X0Y0_頭.GetMiY_MaY(out this.mm);
			this.頭.色更新(this.mm);
			Ele[] array = this.瞼;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].色更新(this.mm);
			}
		}

		public bool Contains(Ele e)
		{
			return e == this.頭 || this.瞼.Contains(e);
		}

		public 頭 頭;

		private Ele[] 瞼;

		private Vector2D[] mm;
	}
}
