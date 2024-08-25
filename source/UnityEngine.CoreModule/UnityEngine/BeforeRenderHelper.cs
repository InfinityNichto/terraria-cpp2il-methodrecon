using System;
using System.Collections.Generic;
using UnityEngine.Events;

namespace UnityEngine
{
	// Token: 0x0200005F RID: 95
	internal static class BeforeRenderHelper
	{
		// Token: 0x060001B7 RID: 439 RVA: 0x00004768 File Offset: 0x00002968
		public static void Invoke()
		{
			int num = 1;
			if (num == 0)
			{
			}
			long num2 = 0L;
			if (num == 0)
			{
			}
			if (num2 != 0L)
			{
			}
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0000479C File Offset: 0x0000299C
		// Note: this type is marked as 'beforefieldinit'.
		static BeforeRenderHelper()
		{
		}

		// Token: 0x0400022E RID: 558
		private static List<BeforeRenderHelper.OrderBlock> s_OrderBlocks;

		// Token: 0x02000060 RID: 96
		private struct OrderBlock
		{
			// Token: 0x0400022F RID: 559
			internal int order;

			// Token: 0x04000230 RID: 560
			internal UnityAction callback;
		}
	}
}
