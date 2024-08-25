using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Events
{
	// Token: 0x02000A55 RID: 2645
	public class MysticLogFairiesEvent
	{
		// Token: 0x06004E1D RID: 19997 RVA: 0x00275BE8 File Offset: 0x00273DE8
		public void WorldClear()
		{
			List<Point> stumpCoords = this._stumpCoords;
			int version = stumpCoords._version;
			stumpCoords._syncRoot = version;
		}

		// Token: 0x06004E1E RID: 19998 RVA: 0x00275C0C File Offset: 0x00273E0C
		public void StartWorld()
		{
			if (!true)
			{
			}
			bool netClient = Main.NetClient;
		}

		// Token: 0x06004E1F RID: 19999 RVA: 0x00275C2C File Offset: 0x00273E2C
		public void StartNight()
		{
			if (!true)
			{
			}
			bool netClient = Main.NetClient;
		}

		// Token: 0x06004E20 RID: 20000 RVA: 0x00275C54 File Offset: 0x00273E54
		public void UpdateTime()
		{
			if (!true)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
			bool canSpawnFairies = this._canSpawnFairies;
			if (canSpawnFairies)
			{
				int delayUntilNextAttempt = this._delayUntilNextAttempt;
				if (!canSpawnFairies)
				{
				}
				int num;
				this._delayUntilNextAttempt = num;
				if (num == 0)
				{
					int num2 = 60;
					this._delayUntilNextAttempt = num2;
					this.TrySpawningFairies();
					return;
				}
			}
		}

		// Token: 0x06004E21 RID: 20001 RVA: 0x00275CA4 File Offset: 0x00273EA4
		private bool IsAGoodTime()
		{
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x06004E22 RID: 20002 RVA: 0x00275CB8 File Offset: 0x00273EB8
		private void TrySpawningFairies()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06004E23 RID: 20003 RVA: 0x00275D30 File Offset: 0x00273F30
		public void FallenLogDestroyed()
		{
			if (!true)
			{
			}
			bool netClient = Main.NetClient;
		}

		// Token: 0x06004E24 RID: 20004 RVA: 0x000021DB File Offset: 0x000003DB
		private void ScanWholeOverworldForLogs()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004E25 RID: 20005 RVA: 0x00275D50 File Offset: 0x00273F50
		private Point GetStumpTopLeft(Point stumpRandomPoint)
		{
			if (!true)
			{
			}
			Tile tile;
			short frameX = tile.frameX;
			return stumpRandomPoint;
		}

		// Token: 0x06004E26 RID: 20006 RVA: 0x00275D68 File Offset: 0x00273F68
		private int GetOneOverSpawnChance()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (true)
			{
			}
			return 60;
		}

		// Token: 0x06004E27 RID: 20007 RVA: 0x00275D80 File Offset: 0x00273F80
		public MysticLogFairiesEvent()
		{
		}

		// Token: 0x040086D6 RID: 34518
		private bool _canSpawnFairies;

		// Token: 0x040086D7 RID: 34519
		private int _delayUntilNextAttempt;

		// Token: 0x040086D8 RID: 34520
		private const int DELAY_BETWEEN_ATTEMPTS = 60;

		// Token: 0x040086D9 RID: 34521
		private List<Point> _stumpCoords;
	}
}
