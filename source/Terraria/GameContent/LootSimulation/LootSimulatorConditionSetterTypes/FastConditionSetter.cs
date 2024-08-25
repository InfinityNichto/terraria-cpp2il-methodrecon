using System;

namespace Terraria.GameContent.LootSimulation.LootSimulatorConditionSetterTypes
{
	// Token: 0x02000860 RID: 2144
	public class FastConditionSetter : ISimulationConditionSetter
	{
		// Token: 0x06004394 RID: 17300 RVA: 0x0024E498 File Offset: 0x0024C698
		public FastConditionSetter(Action<SimulatorInfo> setup, Action<SimulatorInfo> tearDown)
		{
			this._setup = setup;
			this._tearDown = tearDown;
		}

		// Token: 0x06004395 RID: 17301 RVA: 0x0024E4BC File Offset: 0x0024C6BC
		public void Setup(SimulatorInfo info)
		{
			if (this._setup != null)
			{
				return;
			}
		}

		// Token: 0x06004396 RID: 17302 RVA: 0x0024E4D4 File Offset: 0x0024C6D4
		public void TearDown(SimulatorInfo info)
		{
			if (this._tearDown != null)
			{
				return;
			}
		}

		// Token: 0x06004397 RID: 17303 RVA: 0x0024E4EC File Offset: 0x0024C6EC
		public int GetTimesToRunMultiplier(SimulatorInfo info)
		{
			return 1;
		}

		// Token: 0x04008192 RID: 33170
		private Action<SimulatorInfo> _setup;

		// Token: 0x04008193 RID: 33171
		private Action<SimulatorInfo> _tearDown;
	}
}
