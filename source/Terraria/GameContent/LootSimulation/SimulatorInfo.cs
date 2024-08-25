using System;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.LootSimulation
{
	// Token: 0x02000859 RID: 2137
	public class SimulatorInfo
	{
		// Token: 0x06004369 RID: 17257 RVA: 0x0024E160 File Offset: 0x0024C360
		public SimulatorInfo()
		{
			Player player;
			if (!true)
			{
				player = this.player;
			}
			this._originalDayTimeFlag = true;
			Vector2 position = player.position;
		}

		// Token: 0x0600436A RID: 17258 RVA: 0x0024E18C File Offset: 0x0024C38C
		public void ReturnToOriginalDaytime()
		{
			bool originalDayTimeFlag = this._originalDayTimeFlag;
			if (!true)
			{
			}
			double originalDayTimeCounter = this._originalDayTimeCounter;
		}

		// Token: 0x0600436B RID: 17259 RVA: 0x0024E1AC File Offset: 0x0024C3AC
		public void AddItem(int itemId, int amount)
		{
			bool flag = this.runningExpertMode;
			LootSimulationItemCounter lootSimulationItemCounter = this.itemCounter;
		}

		// Token: 0x0600436C RID: 17260 RVA: 0x0024E1CC File Offset: 0x0024C3CC
		public void ReturnToOriginalPlayerPosition()
		{
			Player player = this.player;
		}

		// Token: 0x04008171 RID: 33137
		public Player player;

		// Token: 0x04008172 RID: 33138
		private double _originalDayTimeCounter;

		// Token: 0x04008173 RID: 33139
		private bool _originalDayTimeFlag;

		// Token: 0x04008174 RID: 33140
		private Vector2 _originalPlayerPosition;

		// Token: 0x04008175 RID: 33141
		public bool runningExpertMode;

		// Token: 0x04008176 RID: 33142
		public LootSimulationItemCounter itemCounter;

		// Token: 0x04008177 RID: 33143
		public NPC npcVictim;
	}
}
