using System;

namespace Terraria.GameContent.LootSimulation.LootSimulatorConditionSetterTypes
{
	// Token: 0x02000863 RID: 2147
	public class LuckyCoinConditionSetter : ISimulationConditionSetter
	{
		// Token: 0x060043A0 RID: 17312 RVA: 0x0024E5C8 File Offset: 0x0024C7C8
		public LuckyCoinConditionSetter(int timesToRunMultiplier)
		{
			this._timesToRun = timesToRunMultiplier;
		}

		// Token: 0x060043A1 RID: 17313 RVA: 0x0024E5E4 File Offset: 0x0024C7E4
		public int GetTimesToRunMultiplier(SimulatorInfo info)
		{
			int netID = info.npcVictim.netID;
			return this._timesToRun;
		}

		// Token: 0x060043A2 RID: 17314 RVA: 0x0024E608 File Offset: 0x0024C808
		public void Setup(SimulatorInfo info)
		{
		}

		// Token: 0x060043A3 RID: 17315 RVA: 0x0024E618 File Offset: 0x0024C818
		public void TearDown(SimulatorInfo info)
		{
		}

		// Token: 0x04008196 RID: 33174
		private int _timesToRun;
	}
}
