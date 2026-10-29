using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class Generator
	{
		public int Count
		{
			get
			{
				return this.Buf.Count;
			}
		}

		public Generator(int Capacity, 系統 系統)
		{
			this.Capacity = Capacity;
			this.系統 = 系統;
			switch (系統)
			{
			case 系統.鳥系:
				this.g = new Func<Unit>(this.Get鳥系);
				break;
			case 系統.蛇系:
				this.g = new Func<Unit>(this.Get蛇系);
				break;
			case 系統.獣系:
				this.g = new Func<Unit>(this.Get獣系);
				break;
			case 系統.水系:
				this.g = new Func<Unit>(this.Get水系);
				break;
			case 系統.虫系:
				this.g = new Func<Unit>(this.Get虫系);
				break;
			case 系統.人型:
				this.g = new Func<Unit>(this.Get人型);
				break;
			case 系統.幻獣:
				this.g = new Func<Unit>(this.Get幻獣);
				break;
			case 系統.魔獣:
				this.g = new Func<Unit>(this.Get魔獣);
				break;
			case 系統.竜系:
				this.g = new Func<Unit>(this.Get竜系);
				break;
			}
			this.Refresh();
		}

		private static Unit Generate(ChaD ChaD1, ChaD ChaD2, int 妊娠進行期間, string 種族)
		{
			妊娠進行期間 = (int)((double)妊娠進行期間 * 0.5).LimitM(0.0, 5.0);
			Unit unit = Generator.GetUnit(ChaD1, 妊娠進行期間, 種族).Mix(Generator.GetUnit(ChaD2, 妊娠進行期間, 種族), true);
			unit.処女フラグ = false;
			if (種族 != tex.バイコ\u30FCン)
			{
				unit.処女フラグ = (種族 == tex.ユニコ\u30FCン || 種族 == tex.モノケロス || 0.3.Lot());
			}
			if (!(種族 == tex.スライム) && !(種族 == tex.フェニックス) && !(種族 == tex.ウロボロス))
			{
				unit.傷物フラグ = 0.05.Lot();
			}
			return unit;
		}

		private static Unit GetUnit(ChaD ChaD, int 妊娠進行期間, string 種族)
		{
			Unit unit = new Unit();
			unit.ChaD = ChaD;
			unit.種族 = 種族;
			unit.Name = 種族;
			unit.妊娠進行期間 = 妊娠進行期間;
			種族情報 種族情報 = Def.種族情報[種族];
			unit.種族情報 = new 種族情報(種族情報.希少, 種族情報.需要, 種族情報.危険, ((int)((double)(種族情報.一般 + 1) * unit.ChaD.固有値)).LimitM(1, 9), ((int)((double)(種族情報.娼婦 + 1) * unit.ChaD.固有値)).LimitM(1, 9));
			unit.Set原種素質();
			unit.Set種族特性();
			unit.Set構成特性();
			unit.買値 = (ulong)(unit.GetPrice() * ((Sta.GameData.祝福 == Sta.GameData.ヴィオラ) ? 0.6 : 1.0));
			return unit;
		}

		public static Unit 娼婦労働妊娠父方()
		{
			switch (Oth.GetRandomIndex(new double[]
			{
				7.0,
				5.0,
				3.0,
				1.0
			}))
			{
			case 0:
				return Generator.Generate(原種.Getヒュ\u30FCマン(), 原種.Getヒュ\u30FCマン(), 2, tex.ヒュ\u30FCマン);
			case 1:
			{
				bool b = OthN.XS.NextBool();
				return Generator.Generate(原種.Getオ\u30FCグリス(b), 原種.Getオ\u30FCグリス(b), 2, tex.オ\u30FCグリス);
			}
			case 2:
				return Generator.Generate(原種.Getドワ\u30FCフ(), 原種.Getドワ\u30FCフ(), 2, tex.ドワ\u30FCフ);
			case 3:
				return Generator.Generate(原種.Getサイクロプス(), 原種.Getサイクロプス(), 2, tex.サイクロプス);
			default:
				return null;
			}
		}

		public static Unit プレ\u30FCヤ\u30FC()
		{
			Unit unit = new Unit();
			unit.ChaD = 原種.Getプレ\u30FCヤ\u30FC();
			unit.種族 = tex.ヒュ\u30FCマン;
			unit.Name = unit.種族;
			unit.妊娠進行期間 = 2;
			unit.種族情報 = Def.種族情報[unit.種族];
			腰肌D eleD = unit.ChaD.構成.肌_接続.GetEleD<腰肌D>();
			unit.無毛フラグ = ((!eleD.陰毛_表示 && !eleD.獣性_獣毛_表示) || unit.ChaD.最陰毛濃度 == 0.0);
			unit.母方 = unit;
			unit.父方 = unit;
			return unit;
		}

		protected Unit Get鳥系()
		{
			switch (Oth.GetRandomIndex(new double[]
			{
				tex.ハ\u30FCピ\u30FC.GetRareWeight(),
				tex.ハルピュイア.GetRareWeight(),
				tex.フェニックス.GetRareWeight()
			}))
			{
			case 0:
				return Generator.Generate(原種.Getハ\u30FCピ\u30FC(), 原種.Getハ\u30FCピ\u30FC(), 2, tex.ハ\u30FCピ\u30FC);
			case 1:
				return Generator.Generate(原種.Getハルピュイア(), 原種.Getハルピュイア(), 2, tex.ハルピュイア);
			case 2:
				return Generator.Generate(原種.Getフェニックス(), 原種.Getフェニックス(), 4, tex.フェニックス);
			default:
				return null;
			}
		}

		protected Unit Get蛇系()
		{
			switch (Oth.GetRandomIndex(new double[]
			{
				tex.ラミア.GetRareWeight(),
				tex.ヒュドラ.GetRareWeight(),
				tex.エキドナ.GetRareWeight(),
				tex.ウロボロス.GetRareWeight()
			}))
			{
			case 0:
				return Generator.Generate(原種.Getラミア(), 原種.Getラミア(), 2, tex.ラミア);
			case 1:
				return Generator.Generate(原種.Getヒュドラ(), 原種.Getヒュドラ(), 3, tex.ヒュドラ);
			case 2:
				return Generator.Generate(原種.Getエキドナ(), 原種.Getエキドナ(), 3, tex.エキドナ);
			case 3:
				return Generator.Generate(原種.Getウロボロス(), 原種.Getウロボロス(), 4, tex.ウロボロス);
			default:
				return null;
			}
		}

		protected Unit Get獣系()
		{
			switch (Oth.GetRandomIndex(new double[]
			{
				tex.ウェアキャット.GetRareWeight(),
				tex.ウェアウルフ.GetRareWeight(),
				tex.ウェアフォックス.GetRareWeight(),
				tex.ミノタウロス.GetRareWeight(),
				tex.アフ\u30FCル.GetRareWeight(),
				tex.オノケンタウレ.GetRareWeight(),
				tex.ヒッポケンタウレ.GetRareWeight(),
				tex.ブケンタウレ.GetRareWeight(),
				tex.カプラケンタウレ.GetRareWeight(),
				tex.レオントケンタウレ.GetRareWeight(),
				tex.ティグリスケンタウレ.GetRareWeight(),
				tex.パンテ\u30FCラケンタウレ.GetRareWeight(),
				tex.チ\u30FCタケンタウレ.GetRareWeight()
			}))
			{
			case 0:
				return Generator.Generate(原種.Getウェアキャット(), 原種.Getウェアキャット(), 2, tex.ウェアキャット);
			case 1:
				return Generator.Generate(原種.Getウェアウルフ(), 原種.Getウェアウルフ(), 2, tex.ウェアウルフ);
			case 2:
				return Generator.Generate(原種.Getウェアフォックス(), 原種.Getウェアフォックス(), 2, tex.ウェアフォックス);
			case 3:
				return Generator.Generate(原種.Getミノタウロス(), 原種.Getミノタウロス(), 2, tex.ミノタウロス);
			case 4:
				return Generator.Generate(原種.Getアフ\u30FCル(), 原種.Getアフ\u30FCル(), 2, tex.アフ\u30FCル);
			case 5:
				return Generator.Generate(原種.Getオノケンタウレ(), 原種.Getオノケンタウレ(), 2, tex.オノケンタウレ);
			case 6:
				return Generator.Generate(原種.Getヒッポケンタウレ(), 原種.Getヒッポケンタウレ(), 3, tex.ヒッポケンタウレ);
			case 7:
				return Generator.Generate(原種.Getブケンタウレ(), 原種.Getブケンタウレ(), 3, tex.ブケンタウレ);
			case 8:
				return Generator.Generate(原種.Getカプラケンタウレ(), 原種.Getカプラケンタウレ(), 3, tex.カプラケンタウレ);
			case 9:
				return Generator.Generate(原種.Getレオントケンタウレ(), 原種.Getレオントケンタウレ(), 3, tex.レオントケンタウレ);
			case 10:
				return Generator.Generate(原種.Getティグリスケンタウレ(), 原種.Getティグリスケンタウレ(), 3, tex.ティグリスケンタウレ);
			case 11:
				return Generator.Generate(原種.Getパンテ\u30FCラケンタウレ(), 原種.Getパンテ\u30FCラケンタウレ(), 3, tex.パンテ\u30FCラケンタウレ);
			case 12:
				return Generator.Generate(原種.Getチ\u30FCタケンタウレ(), 原種.Getチ\u30FCタケンタウレ(), 3, tex.チ\u30FCタケンタウレ);
			default:
				return null;
			}
		}

		protected Unit Get水系()
		{
			switch (Oth.GetRandomIndex(new double[]
			{
				tex.カッパ.GetRareWeight(),
				tex.マ\u30FCメイド.GetRareWeight(),
				tex.オ\u30FCルドマ\u30FCメイド.GetRareWeight(),
				tex.ドルフィンマ\u30FCメイド.GetRareWeight(),
				tex.イクテュオケンタウレ.GetRareWeight(),
				tex.デルピヌスケンタウレ.GetRareWeight(),
				tex.シ\u30FCラミア.GetRareWeight(),
				tex.セイレ\u30FCン.GetRareWeight(),
				tex.スキュラ.GetRareWeight(),
				tex.カリュブディス.GetRareWeight(),
				tex.クラ\u30FCケン.GetRareWeight(),
				tex.オ\u30FCルドスキュラ.GetRareWeight()
			}))
			{
			case 0:
				return Generator.Generate(原種.Getカッパ(), 原種.Getカッパ(), 2, tex.カッパ);
			case 1:
				return Generator.Generate(原種.Getマ\u30FCメイド(), 原種.Getマ\u30FCメイド(), 2, tex.マ\u30FCメイド);
			case 2:
				return Generator.Generate(原種.Getオ\u30FCルドマ\u30FCメイド(), 原種.Getオ\u30FCルドマ\u30FCメイド(), 2, tex.オ\u30FCルドマ\u30FCメイド);
			case 3:
				return Generator.Generate(原種.Getドルフィンマ\u30FCメイド(), 原種.Getドルフィンマ\u30FCメイド(), 2, tex.ドルフィンマ\u30FCメイド);
			case 4:
			{
				bool b = OthN.XS.NextBool();
				return Generator.Generate(原種.Getイクテュオケンタウレ(b), 原種.Getイクテュオケンタウレ(b), 3, tex.イクテュオケンタウレ);
			}
			case 5:
				return Generator.Generate(原種.Getデルピヌスケンタウレ(), 原種.Getデルピヌスケンタウレ(), 3, tex.デルピヌスケンタウレ);
			case 6:
				return Generator.Generate(原種.Getシ\u30FCラミア(), 原種.Getシ\u30FCラミア(), 2, tex.シ\u30FCラミア);
			case 7:
			{
				int num = OthN.XS.Next(3);
				return Generator.Generate(原種.Getセイレ\u30FCン(num), 原種.Getセイレ\u30FCン(num), 2, tex.セイレ\u30FCン);
			}
			case 8:
				return Generator.Generate(原種.Getスキュラ(), 原種.Getスキュラ(), 2, tex.スキュラ);
			case 9:
				return Generator.Generate(原種.Getカリュブディス(), 原種.Getカリュブディス(), 3, tex.カリュブディス);
			case 10:
				return Generator.Generate(原種.Getクラ\u30FCケン(), 原種.Getクラ\u30FCケン(), 3, tex.クラ\u30FCケン);
			case 11:
			{
				bool b = OthN.XS.NextBool();
				return Generator.Generate(原種.Getオ\u30FCルドスキュラ(b), 原種.Getオ\u30FCルドスキュラ(b), 4, tex.オ\u30FCルドスキュラ);
			}
			default:
				return null;
			}
		}

		protected Unit Get虫系()
		{
			switch (Oth.GetRandomIndex(new double[]
			{
				tex.ウェアマンティス.GetRareWeight(),
				tex.ウェアドラゴンフライ.GetRareWeight(),
				tex.ウェアビ\u30FCトル.GetRareWeight(),
				tex.ウェアスタッグビ\u30FCトル.GetRareWeight(),
				tex.アラクネ.GetRareWeight(),
				tex.ギルタブリル.GetRareWeight(),
				tex.ギルタブルル.GetRareWeight(),
				tex.ムカデジョウロウ.GetRareWeight(),
				tex.サンドワ\u30FCム.GetRareWeight(),
				tex.フェアリ\u30FC.GetRareWeight()
			}))
			{
			case 0:
				return Generator.Generate(原種.Getウェアマンティス(), 原種.Getウェアマンティス(), 1, tex.ウェアマンティス);
			case 1:
				return Generator.Generate(原種.Getウェアドラゴンフライ(), 原種.Getウェアドラゴンフライ(), 1, tex.ウェアドラゴンフライ);
			case 2:
				return Generator.Generate(原種.Getウェアビ\u30FCトル(), 原種.Getウェアビ\u30FCトル(), 1, tex.ウェアビ\u30FCトル);
			case 3:
				return Generator.Generate(原種.Getウェアスタッグビ\u30FCトル(), 原種.Getウェアスタッグビ\u30FCトル(), 1, tex.ウェアスタッグビ\u30FCトル);
			case 4:
			{
				bool flag = OthN.XS.NextBool();
				return Generator.Generate(原種.Getアラクネ(flag), 原種.Getアラクネ(flag), 2, tex.アラクネ);
			}
			case 5:
				return Generator.Generate(原種.Getギルタブリル(), 原種.Getギルタブリル(), 2, tex.ギルタブリル);
			case 6:
				return Generator.Generate(原種.Getギルタブルル(), 原種.Getギルタブルル(), 2, tex.ギルタブルル);
			case 7:
				return Generator.Generate(原種.Getムカデジョウロウ(), 原種.Getムカデジョウロウ(), 2, tex.ムカデジョウロウ);
			case 8:
				return Generator.Generate(原種.Getサンドワ\u30FCム(), 原種.Getサンドワ\u30FCム(), 2, tex.サンドワ\u30FCム);
			case 9:
			{
				bool flag = OthN.XS.NextBool();
				bool b = OthN.XS.NextBool();
				return Generator.Generate(原種.Getフェアリ\u30FC(flag, b), 原種.Getフェアリ\u30FC(flag, b), 1, tex.フェアリ\u30FC);
			}
			default:
				return null;
			}
		}

		protected Unit Get人型()
		{
			switch (Oth.GetRandomIndex(new double[]
			{
				tex.リリン.GetRareWeight(),
				tex.エルフ.GetRareWeight(),
				tex.ドワ\u30FCフ.GetRareWeight(),
				tex.オ\u30FCグリス.GetRareWeight(),
				tex.サイクロプス.GetRareWeight(),
				tex.デビル.GetRareWeight(),
				tex.エンジェル.GetRareWeight(),
				tex.サキュバス.GetRareWeight(),
				tex.アルラウネ.GetRareWeight(),
				tex.スライム.GetRareWeight(),
				tex.エイリアン.GetRareWeight(),
				tex.ヒュ\u30FCマン.GetRareWeight()
			}))
			{
			case 0:
				return Generator.Generate(原種.Getリリン(), 原種.Getリリン(), 2, tex.リリン);
			case 1:
				return Generator.Generate(原種.Getエルフ(), 原種.Getエルフ(), 2, tex.エルフ);
			case 2:
				return Generator.Generate(原種.Getドワ\u30FCフ(), 原種.Getドワ\u30FCフ(), 2, tex.ドワ\u30FCフ);
			case 3:
			{
				bool b = OthN.XS.NextBool();
				return Generator.Generate(原種.Getオ\u30FCグリス(b), 原種.Getオ\u30FCグリス(b), 2, tex.オ\u30FCグリス);
			}
			case 4:
				return Generator.Generate(原種.Getサイクロプス(), 原種.Getサイクロプス(), 2, tex.サイクロプス);
			case 5:
				return Generator.Generate(原種.Getデビル(), 原種.Getデビル(), 2, tex.デビル);
			case 6:
			{
				bool b2 = OthN.XS.NextBool();
				return Generator.Generate(原種.Getエンジェル(b2), 原種.Getエンジェル(b2), 2, tex.エンジェル);
			}
			case 7:
				return Generator.Generate(原種.Getサキュバス(), 原種.Getサキュバス(), 2, tex.サキュバス);
			case 8:
				return Generator.Generate(原種.Getアルラウネ(), 原種.Getアルラウネ(), 2, tex.アルラウネ);
			case 9:
				return Generator.Generate(原種.Getスライム(), 原種.Getスライム(), 0, tex.スライム);
			case 10:
				return Generator.Generate(原種.Getエイリアン(), 原種.Getエイリアン(), 3, tex.エイリアン);
			case 11:
				if (!Sta.HumanInStore)
				{
					return this.Get人型();
				}
				return Generator.Generate(原種.Getヒュ\u30FCマン(), 原種.Getヒュ\u30FCマン(), 2, tex.ヒュ\u30FCマン);
			default:
				return null;
			}
		}

		protected Unit Get幻獣()
		{
			switch (Oth.GetRandomIndex(new double[]
			{
				tex.カ\u30FCバンクル.GetRareWeight(),
				tex.ペガサス.GetRareWeight(),
				tex.ユニコ\u30FCン.GetRareWeight(),
				tex.バイコ\u30FCン.GetRareWeight(),
				tex.アリコ\u30FCン.GetRareWeight(),
				tex.グリフォン.GetRareWeight(),
				tex.モノケロス.GetRareWeight(),
				tex.ヒッポグリフ.GetRareWeight()
			}))
			{
			case 0:
				return Generator.Generate(原種.Getカ\u30FCバンクル(), 原種.Getカ\u30FCバンクル(), 2, tex.カ\u30FCバンクル);
			case 1:
				return Generator.Generate(原種.Getペガサス(), 原種.Getペガサス(), 3, tex.ペガサス);
			case 2:
				return Generator.Generate(原種.Getユニコ\u30FCン(), 原種.Getユニコ\u30FCン(), 3, tex.ユニコ\u30FCン);
			case 3:
				return Generator.Generate(原種.Getバイコ\u30FCン(), 原種.Getバイコ\u30FCン(), 3, tex.バイコ\u30FCン);
			case 4:
				return Generator.Generate(原種.Getアリコ\u30FCン(), 原種.Getアリコ\u30FCン(), 3, tex.アリコ\u30FCン);
			case 5:
				return Generator.Generate(原種.Getグリフォン(), 原種.Getグリフォン(), 3, tex.グリフォン);
			case 6:
				return Generator.Generate(原種.Getモノケロス(), 原種.Getモノケロス(), 3, tex.モノケロス);
			case 7:
				return Generator.Generate(原種.Getヒッポグリフ(), 原種.Getヒッポグリフ(), 3, tex.ヒッポグリフ);
			default:
				return null;
			}
		}

		protected Unit Get魔獣()
		{
			switch (Oth.GetRandomIndex(new double[]
			{
				tex.キマイラ.GetRareWeight(),
				tex.スフィンクス.GetRareWeight(),
				tex.カトブレパス.GetRareWeight(),
				tex.バジリスク.GetRareWeight(),
				tex.コカトリス.GetRareWeight(),
				tex.ゴルゴン.GetRareWeight()
			}))
			{
			case 0:
				return Generator.Generate(原種.Getキマイラ(), 原種.Getキマイラ(), 3, tex.キマイラ);
			case 1:
			{
				bool b = OthN.XS.NextBool();
				return Generator.Generate(原種.Getスフィンクス(b), 原種.Getスフィンクス(b), 3, tex.スフィンクス);
			}
			case 2:
				return Generator.Generate(原種.Getカトブレパス(), 原種.Getカトブレパス(), 3, tex.カトブレパス);
			case 3:
				return Generator.Generate(原種.Getバジリスク(), 原種.Getバジリスク(), 3, tex.バジリスク);
			case 4:
				return Generator.Generate(原種.Getコカトリス(), 原種.Getコカトリス(), 3, tex.コカトリス);
			case 5:
				return Generator.Generate(原種.Getゴルゴン(), 原種.Getゴルゴン(), 3, tex.ゴルゴン);
			default:
				return null;
			}
		}

		protected Unit Get竜系()
		{
			switch (Oth.GetRandomIndex(new double[]
			{
				tex.リザ\u30FCドマン.GetRareWeight(),
				tex.ドラゴニュ\u30FCト.GetRareWeight(),
				tex.ワ\u30FCム.GetRareWeight(),
				tex.リュウ.GetRareWeight(),
				tex.ワイバ\u30FCン.GetRareWeight(),
				tex.ドラコケンタウレ.GetRareWeight(),
				tex.ドラゴン.GetRareWeight()
			}))
			{
			case 0:
				return Generator.Generate(原種.Getリザ\u30FCドマン(), 原種.Getリザ\u30FCドマン(), 2, tex.リザ\u30FCドマン);
			case 1:
				return Generator.Generate(原種.Getドラゴニュ\u30FCト(), 原種.Getドラゴニュ\u30FCト(), 3, tex.ドラゴニュ\u30FCト);
			case 2:
				return Generator.Generate(原種.Getワ\u30FCム(), 原種.Getワ\u30FCム(), 4, tex.ワ\u30FCム);
			case 3:
				return Generator.Generate(原種.Getリュウ(), 原種.Getリュウ(), 5, tex.リュウ);
			case 4:
				return Generator.Generate(原種.Getワイバ\u30FCン(), 原種.Getワイバ\u30FCン(), 4, tex.ワイバ\u30FCン);
			case 5:
				return Generator.Generate(原種.Getドラコケンタウレ(), 原種.Getドラコケンタウレ(), 4, tex.ドラコケンタウレ);
			case 6:
				return Generator.Generate(原種.Getドラゴン(), 原種.Getドラゴン(), 5, tex.ドラゴン);
			default:
				return null;
			}
		}

		public void Refresh()
		{
			this.i = 0;
			this.Buf.Clear();
			Unit[] a = new Unit[this.Capacity];
			Parallel.For(0, this.Capacity, Sta.po3, delegate(int i)
			{
				a[i] = this.g();
			});
			this.Buf.AddRange(a);
		}

		public void Refresh(int Capacity)
		{
			this.Capacity = Capacity;
			this.i = 0;
			this.Buf.Clear();
			this.Buf.Capacity = Capacity;
			Unit[] a = new Unit[Capacity];
			Parallel.For(0, Capacity, Sta.po3, delegate(int i)
			{
				a[i] = this.g();
			});
			this.Buf.AddRange(a);
		}

		public void Rotation()
		{
			this.i++;
		}

		public Unit RefCharacter()
		{
			if (this.Buf.Count <= 0)
			{
				return null;
			}
			return this.Buf[this.i % this.Buf.Count];
		}

		public Unit GetCharacter()
		{
			if (this.Buf.Count > 0)
			{
				Unit unit = this.Buf[this.i % this.Buf.Count];
				this.Buf.Remove(unit);
				return unit;
			}
			return null;
		}

		public static IEnumerable<Unit> EnumAllMonster()
		{
			yield return Generator.Generate(原種.Getハ\u30FCピ\u30FC(), 原種.Getハ\u30FCピ\u30FC(), 2, tex.ハ\u30FCピ\u30FC);
			yield return Generator.Generate(原種.Getハルピュイア(), 原種.Getハルピュイア(), 2, tex.ハルピュイア);
			yield return Generator.Generate(原種.Getフェニックス(), 原種.Getフェニックス(), 4, tex.フェニックス);
			yield return Generator.Generate(原種.Getラミア(), 原種.Getラミア(), 2, tex.ラミア);
			yield return Generator.Generate(原種.Getヒュドラ(), 原種.Getヒュドラ(), 3, tex.ヒュドラ);
			yield return Generator.Generate(原種.Getエキドナ(), 原種.Getエキドナ(), 3, tex.エキドナ);
			yield return Generator.Generate(原種.Getウロボロス(), 原種.Getウロボロス(), 4, tex.ウロボロス);
			yield return Generator.Generate(原種.Getウェアキャット(), 原種.Getウェアキャット(), 2, tex.ウェアキャット);
			yield return Generator.Generate(原種.Getウェアウルフ(), 原種.Getウェアウルフ(), 2, tex.ウェアウルフ);
			yield return Generator.Generate(原種.Getウェアフォックス(), 原種.Getウェアフォックス(), 2, tex.ウェアフォックス);
			yield return Generator.Generate(原種.Getミノタウロス(), 原種.Getミノタウロス(), 2, tex.ミノタウロス);
			yield return Generator.Generate(原種.Getアフ\u30FCル(), 原種.Getアフ\u30FCル(), 2, tex.アフ\u30FCル);
			yield return Generator.Generate(原種.Getオノケンタウレ(), 原種.Getオノケンタウレ(), 2, tex.オノケンタウレ);
			yield return Generator.Generate(原種.Getヒッポケンタウレ(), 原種.Getヒッポケンタウレ(), 3, tex.ヒッポケンタウレ);
			yield return Generator.Generate(原種.Getブケンタウレ(), 原種.Getブケンタウレ(), 3, tex.ブケンタウレ);
			yield return Generator.Generate(原種.Getカプラケンタウレ(), 原種.Getカプラケンタウレ(), 3, tex.カプラケンタウレ);
			yield return Generator.Generate(原種.Getレオントケンタウレ(), 原種.Getレオントケンタウレ(), 3, tex.レオントケンタウレ);
			yield return Generator.Generate(原種.Getティグリスケンタウレ(), 原種.Getティグリスケンタウレ(), 3, tex.ティグリスケンタウレ);
			yield return Generator.Generate(原種.Getパンテ\u30FCラケンタウレ(), 原種.Getパンテ\u30FCラケンタウレ(), 3, tex.パンテ\u30FCラケンタウレ);
			yield return Generator.Generate(原種.Getチ\u30FCタケンタウレ(), 原種.Getチ\u30FCタケンタウレ(), 3, tex.チ\u30FCタケンタウレ);
			yield return Generator.Generate(原種.Getカッパ(), 原種.Getカッパ(), 2, tex.カッパ);
			yield return Generator.Generate(原種.Getマ\u30FCメイド(), 原種.Getマ\u30FCメイド(), 2, tex.マ\u30FCメイド);
			yield return Generator.Generate(原種.Getオ\u30FCルドマ\u30FCメイド(), 原種.Getオ\u30FCルドマ\u30FCメイド(), 2, tex.オ\u30FCルドマ\u30FCメイド);
			yield return Generator.Generate(原種.Getドルフィンマ\u30FCメイド(), 原種.Getドルフィンマ\u30FCメイド(), 2, tex.ドルフィンマ\u30FCメイド);
			bool flag = OthN.XS.NextBool();
			yield return Generator.Generate(原種.Getイクテュオケンタウレ(flag), 原種.Getイクテュオケンタウレ(flag), 3, tex.イクテュオケンタウレ);
			yield return Generator.Generate(原種.Getデルピヌスケンタウレ(), 原種.Getデルピヌスケンタウレ(), 3, tex.デルピヌスケンタウレ);
			yield return Generator.Generate(原種.Getシ\u30FCラミア(), 原種.Getシ\u30FCラミア(), 2, tex.シ\u30FCラミア);
			int num = OthN.XS.Next(3);
			yield return Generator.Generate(原種.Getセイレ\u30FCン(num), 原種.Getセイレ\u30FCン(num), 2, tex.セイレ\u30FCン);
			yield return Generator.Generate(原種.Getスキュラ(), 原種.Getスキュラ(), 2, tex.スキュラ);
			yield return Generator.Generate(原種.Getカリュブディス(), 原種.Getカリュブディス(), 3, tex.カリュブディス);
			yield return Generator.Generate(原種.Getクラ\u30FCケン(), 原種.Getクラ\u30FCケン(), 3, tex.クラ\u30FCケン);
			flag = OthN.XS.NextBool();
			yield return Generator.Generate(原種.Getオ\u30FCルドスキュラ(flag), 原種.Getオ\u30FCルドスキュラ(flag), 4, tex.オ\u30FCルドスキュラ);
			yield return Generator.Generate(原種.Getウェアマンティス(), 原種.Getウェアマンティス(), 1, tex.ウェアマンティス);
			yield return Generator.Generate(原種.Getウェアドラゴンフライ(), 原種.Getウェアドラゴンフライ(), 1, tex.ウェアドラゴンフライ);
			yield return Generator.Generate(原種.Getウェアビ\u30FCトル(), 原種.Getウェアビ\u30FCトル(), 1, tex.ウェアビ\u30FCトル);
			yield return Generator.Generate(原種.Getウェアスタッグビ\u30FCトル(), 原種.Getウェアスタッグビ\u30FCトル(), 1, tex.ウェアスタッグビ\u30FCトル);
			flag = OthN.XS.NextBool();
			yield return Generator.Generate(原種.Getアラクネ(flag), 原種.Getアラクネ(flag), 2, tex.アラクネ);
			yield return Generator.Generate(原種.Getギルタブリル(), 原種.Getギルタブリル(), 2, tex.ギルタブリル);
			yield return Generator.Generate(原種.Getギルタブルル(), 原種.Getギルタブルル(), 2, tex.ギルタブルル);
			yield return Generator.Generate(原種.Getムカデジョウロウ(), 原種.Getムカデジョウロウ(), 2, tex.ムカデジョウロウ);
			yield return Generator.Generate(原種.Getサンドワ\u30FCム(), 原種.Getサンドワ\u30FCム(), 2, tex.サンドワ\u30FCム);
			flag = OthN.XS.NextBool();
			bool b = OthN.XS.NextBool();
			yield return Generator.Generate(原種.Getフェアリ\u30FC(flag, b), 原種.Getフェアリ\u30FC(flag, b), 1, tex.フェアリ\u30FC);
			yield return Generator.Generate(原種.Getリリン(), 原種.Getリリン(), 2, tex.リリン);
			yield return Generator.Generate(原種.Getエルフ(), 原種.Getエルフ(), 2, tex.エルフ);
			yield return Generator.Generate(原種.Getドワ\u30FCフ(), 原種.Getドワ\u30FCフ(), 2, tex.ドワ\u30FCフ);
			flag = OthN.XS.NextBool();
			yield return Generator.Generate(原種.Getオ\u30FCグリス(flag), 原種.Getオ\u30FCグリス(flag), 2, tex.オ\u30FCグリス);
			yield return Generator.Generate(原種.Getサイクロプス(), 原種.Getサイクロプス(), 2, tex.サイクロプス);
			yield return Generator.Generate(原種.Getデビル(), 原種.Getデビル(), 2, tex.デビル);
			flag = OthN.XS.NextBool();
			yield return Generator.Generate(原種.Getエンジェル(flag), 原種.Getエンジェル(flag), 2, tex.エンジェル);
			yield return Generator.Generate(原種.Getサキュバス(), 原種.Getサキュバス(), 2, tex.サキュバス);
			yield return Generator.Generate(原種.Getアルラウネ(), 原種.Getアルラウネ(), 2, tex.アルラウネ);
			yield return Generator.Generate(原種.Getスライム(), 原種.Getスライム(), 0, tex.スライム);
			yield return Generator.Generate(原種.Getエイリアン(), 原種.Getエイリアン(), 3, tex.エイリアン);
			yield return Generator.Generate(原種.Getカ\u30FCバンクル(), 原種.Getカ\u30FCバンクル(), 2, tex.カ\u30FCバンクル);
			yield return Generator.Generate(原種.Getペガサス(), 原種.Getペガサス(), 3, tex.ペガサス);
			yield return Generator.Generate(原種.Getユニコ\u30FCン(), 原種.Getユニコ\u30FCン(), 3, tex.ユニコ\u30FCン);
			yield return Generator.Generate(原種.Getバイコ\u30FCン(), 原種.Getバイコ\u30FCン(), 3, tex.バイコ\u30FCン);
			yield return Generator.Generate(原種.Getアリコ\u30FCン(), 原種.Getアリコ\u30FCン(), 3, tex.アリコ\u30FCン);
			yield return Generator.Generate(原種.Getグリフォン(), 原種.Getグリフォン(), 3, tex.グリフォン);
			yield return Generator.Generate(原種.Getモノケロス(), 原種.Getモノケロス(), 3, tex.モノケロス);
			yield return Generator.Generate(原種.Getヒッポグリフ(), 原種.Getヒッポグリフ(), 3, tex.ヒッポグリフ);
			yield return Generator.Generate(原種.Getキマイラ(), 原種.Getキマイラ(), 3, tex.キマイラ);
			flag = OthN.XS.NextBool();
			yield return Generator.Generate(原種.Getスフィンクス(flag), 原種.Getスフィンクス(flag), 3, tex.スフィンクス);
			yield return Generator.Generate(原種.Getカトブレパス(), 原種.Getカトブレパス(), 3, tex.カトブレパス);
			yield return Generator.Generate(原種.Getバジリスク(), 原種.Getバジリスク(), 3, tex.バジリスク);
			yield return Generator.Generate(原種.Getコカトリス(), 原種.Getコカトリス(), 3, tex.コカトリス);
			yield return Generator.Generate(原種.Getゴルゴン(), 原種.Getゴルゴン(), 3, tex.ゴルゴン);
			yield return Generator.Generate(原種.Getリザ\u30FCドマン(), 原種.Getリザ\u30FCドマン(), 2, tex.リザ\u30FCドマン);
			yield return Generator.Generate(原種.Getドラゴニュ\u30FCト(), 原種.Getドラゴニュ\u30FCト(), 3, tex.ドラゴニュ\u30FCト);
			yield return Generator.Generate(原種.Getワ\u30FCム(), 原種.Getワ\u30FCム(), 4, tex.ワ\u30FCム);
			yield return Generator.Generate(原種.Getリュウ(), 原種.Getリュウ(), 5, tex.リュウ);
			yield return Generator.Generate(原種.Getワイバ\u30FCン(), 原種.Getワイバ\u30FCン(), 4, tex.ワイバ\u30FCン);
			yield return Generator.Generate(原種.Getドラコケンタウレ(), 原種.Getドラコケンタウレ(), 4, tex.ドラコケンタウレ);
			yield return Generator.Generate(原種.Getドラゴン(), 原種.Getドラゴン(), 5, tex.ドラゴン);
			yield break;
		}

		public List<Unit> Buf = new List<Unit>();

		private int i;

		protected int Capacity;

		protected 系統 系統;

		protected Func<Unit> g;
	}
}
