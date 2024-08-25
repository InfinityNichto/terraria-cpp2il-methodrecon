using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.Utilities;

namespace Terraria.GameContent
{
	// Token: 0x020007B4 RID: 1972
	public class AmbientWindSystem
	{
		// Token: 0x06004047 RID: 16455 RVA: 0x00242C4C File Offset: 0x00240E4C
		public AmbientWindSystem()
		{
		}

		// Token: 0x06004048 RID: 16456 RVA: 0x00242C68 File Offset: 0x00240E68
		public void Update()
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool zoneGraveyard = Main.LocalPlayer.ZoneGraveyard;
			if (num == 0)
			{
			}
			int updatesCounter = this._updatesCounter;
			this._updatesCounter = updatesCounter;
			this._airSpaceTests = (float)num;
			if (num == 0)
			{
			}
			float airSpaceTests = this._airSpaceTests;
			this._airSpaceTests = airSpaceTests;
		}

		// Token: 0x06004049 RID: 16457 RVA: 0x00242D2C File Offset: 0x00240F2C
		private void SpawnAirborneWind()
		{
			List<Point> spotsForAirboneWind = this._spotsForAirboneWind;
		}

		// Token: 0x0600404A RID: 16458 RVA: 0x00242D6C File Offset: 0x00240F6C
		private Rectangle GetTileWorkSpace()
		{
			int num = 1;
			if (num == 0)
			{
			}
			Vector2 center = Main.LocalPlayer.Center;
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x0600404B RID: 16459 RVA: 0x00242D90 File Offset: 0x00240F90
		private void TrySpawningWind(int x, int y)
		{
			if (!true)
			{
			}
			Tile tile;
			short sTileHeader = tile.sTileHeader;
			int num = 29728;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (num == 0)
				{
				}
				this.SpawnFloorCloud(x, y);
				UnifiedRandom random = this._random;
				int num2 = 3;
				if (random.Next(num2) == 0)
				{
					this.SpawnFloorCloud(x, int.MinValue);
				}
			}
		}

		// Token: 0x0600404C RID: 16460 RVA: 0x00242DE0 File Offset: 0x00240FE0
		private void SpawnAirborneCloud(int x, int y)
		{
			UnifiedRandom random = this._random;
			int num = 2;
			int num2 = 6;
			int num3 = random.Next(num, num2);
			float num4 = this._random.NextFloatDirection();
			float num5 = this._random.NextFloatDirection();
			float num6 = this._random.NextFloatDirection();
			UnifiedRandom random2 = this._random;
			int num7 = 4;
			int num8 = random2.Next(num7);
			UnifiedRandom random3 = this._random;
			if (num8 == 0)
			{
				return;
			}
			int num9 = 4;
			if (random3.Next(num9) != 0)
			{
				return;
			}
			UnifiedRandom random4 = this._random;
			int num10 = 9;
			int num11 = 16;
			int num12 = random4.Next(num10, num11);
			if (random4 == null)
			{
			}
			int num13;
			float num14;
			if (num13 == 0)
			{
				num14 = this._random.NextFloatDirection();
			}
			Vector2 vector = this._random.NextVector2Circular(num14, num14);
			UnifiedRandom random5 = this._random;
			int num15 = 2;
			int num16 = random5.Next(num15);
			UnifiedRandom random6 = this._random;
			float num17 = random6.NextFloat();
			if (random6 == null)
			{
			}
			int myPlayer = Main.myPlayer;
			Gore gore;
			gore.PlayerOnly = myPlayer;
		}

		// Token: 0x0600404D RID: 16461 RVA: 0x00242EF8 File Offset: 0x002410F8
		private void SpawnFloorCloud(int x, int y)
		{
			if (!true)
			{
			}
			UnifiedRandom random = this._random;
			int num = 1087;
			int num2 = 1090;
			int num3 = random.Next(num, num2);
			UnifiedRandom random2 = this._random;
			float num4 = random2.NextFloat();
			UnifiedRandom random3 = this._random;
			if (random2 == null)
			{
			}
			float num5 = random3.NextFloat();
			if (random2 == null)
			{
			}
			if (!true)
			{
			}
			int num6 = 1;
			if (num6 == 0)
			{
			}
			if (num6 == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			Gore gore;
			gore.PlayerOnly = myPlayer;
		}

		// Token: 0x0600404E RID: 16462 RVA: 0x000021DB File Offset: 0x000003DB
		private void TestAirCloud(int x, int y)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600404F RID: 16463 RVA: 0x00242F78 File Offset: 0x00241178
		private bool DoesTileAllowWind(Tile t)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x04007E12 RID: 32274
		private UnifiedRandom _random;

		// Token: 0x04007E13 RID: 32275
		private List<Point> _spotsForAirboneWind;

		// Token: 0x04007E14 RID: 32276
		private int _updatesCounter;

		// Token: 0x04007E15 RID: 32277
		private int _lastFrame = 1;

		// Token: 0x04007E16 RID: 32278
		private float _airSpaceTests;

		// Token: 0x04007E17 RID: 32279
		private float _floorSpaceTests;
	}
}
