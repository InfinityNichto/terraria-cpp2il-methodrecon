using System;

namespace Terraria.GameContent.LootSimulation
{
	// Token: 0x0200085D RID: 2141
	public interface ISimulationConditionSetter
	{
		// Token: 0x06004379 RID: 17273
		int GetTimesToRunMultiplier(SimulatorInfo info);

		// Token: 0x0600437A RID: 17274
		void Setup(SimulatorInfo info);

		// Token: 0x0600437B RID: 17275
		void TearDown(SimulatorInfo info);
	}
}
