using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x0200086E RID: 2158
	public struct DropRateInfo
	{
		// Token: 0x060043D5 RID: 17365 RVA: 0x0024E980 File Offset: 0x0024CB80
		public DropRateInfo(int itemId, int stackMin, int stackMax, float dropRate, [Optional] List<IItemDropRuleCondition> conditions)
		{
			this.itemId = itemId;
			this.stackMax = stackMin;
			this.stackMax = stackMax;
			if (conditions != null)
			{
				int size = conditions._size;
			}
		}

		// Token: 0x060043D6 RID: 17366 RVA: 0x0024E9B0 File Offset: 0x0024CBB0
		public void AddCondition(IItemDropRuleCondition condition)
		{
			if (this.conditions == null)
			{
			}
		}

		// Token: 0x040081AF RID: 33199
		public int itemId;

		// Token: 0x040081B0 RID: 33200
		public int stackMin;

		// Token: 0x040081B1 RID: 33201
		public int stackMax;

		// Token: 0x040081B2 RID: 33202
		public float dropRate;

		// Token: 0x040081B3 RID: 33203
		public List<IItemDropRuleCondition> conditions;
	}
}
