using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class ドレス色更新
	{
		public ドレス色更新(上着トップ_ドレス トップ, 上着ミドル_ドレス ミドル)
		{
			this.トップ = トップ;
			this.ミドル = ミドル;
			this.ドレス = new Par[]
			{
				トップ.X0Y0_左_服,
				トップ.X0Y0_左_バスト,
				トップ.X0Y0_右_服,
				トップ.X0Y0_右_バスト,
				ミドル.X0Y0_服
			};
			this.縁左 = new Par[]
			{
				トップ.X0Y0_左_縁,
				ミドル.X0Y0_縁_縁左
			};
			this.縁右 = new Par[]
			{
				トップ.X0Y0_右_縁,
				ミドル.X0Y0_縁_縁右
			};
		}

		public void 色更新()
		{
			this.ドレス.GetMiY_MaY(out this.ドレスm);
			this.縁左.GetMiY_MaY(out this.縁左m);
			this.縁右.GetMiY_MaY(out this.縁右m);
			this.トップ.色更新(this.ドレスm, this.縁左m, this.縁右m);
			this.ミドル.色更新(this.ドレスm, this.縁左m, this.縁右m);
		}

		public bool Contains(Ele e)
		{
			return this.トップ == e || this.ミドル == e;
		}

		public 上着トップ_ドレス トップ;

		public 上着ミドル_ドレス ミドル;

		private Par[] ドレス;

		private Par[] 縁左;

		private Par[] 縁右;

		private Vector2D[] ドレスm;

		private Vector2D[] 縁左m;

		private Vector2D[] 縁右m;
	}
}
