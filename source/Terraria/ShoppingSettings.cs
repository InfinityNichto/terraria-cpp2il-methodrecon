using System;
using Cpp2IlInjected;

namespace Terraria
{
	// Token: 0x02000423 RID: 1059
	public struct ShoppingSettings
	{
		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x0600275F RID: 10079 RVA: 0x000021DB File Offset: 0x000003DB
		public static ShoppingSettings NotInShop
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x04003399 RID: 13209
		public double PriceAdjustment;

		// Token: 0x0400339A RID: 13210
		public string HappinessReport;
	}
}
