using System;

namespace Terraria.GameContent.LootSimulation.LootSimulatorConditionSetterTypes
{
	// Token: 0x02000861 RID: 2145
	public class StackedConditionSetter : ISimulationConditionSetter
	{
		// Token: 0x06004398 RID: 17304 RVA: 0x0024E4FC File Offset: 0x0024C6FC
		public StackedConditionSetter(params ISimulationConditionSetter[] setters)
		{
			this._setters = setters;
		}

		// Token: 0x06004399 RID: 17305 RVA: 0x0024E518 File Offset: 0x0024C718
		public void Setup(SimulatorInfo info)
		{
			ISimulationConditionSetter[] setters = this._setters;
		}

		// Token: 0x0600439A RID: 17306 RVA: 0x0024E538 File Offset: 0x0024C738
		public void TearDown(SimulatorInfo info)
		{
			ISimulationConditionSetter[] setters = this._setters;
		}

		// Token: 0x0600439B RID: 17307 RVA: 0x0024E558 File Offset: 0x0024C758
		public int GetTimesToRunMultiplier(SimulatorInfo info)
		{
			return 1;
		}

		// Token: 0x04008194 RID: 33172
		private ISimulationConditionSetter[] _setters;
	}
}
