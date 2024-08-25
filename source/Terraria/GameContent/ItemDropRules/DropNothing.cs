using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x0200087D RID: 2173
	public class DropNothing : IItemDropRule
	{
		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x060043FA RID: 17402 RVA: 0x0024EF78 File Offset: 0x0024D178
		// (set) Token: 0x060043FB RID: 17403 RVA: 0x0024EF8C File Offset: 0x0024D18C
		public List<IItemDropRuleChainAttempt> ChainedRules
		{
			[CompilerGenerated]
			get
			{
				return this.<ChainedRules>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<ChainedRules>k__BackingField = value;
			}
		}

		// Token: 0x060043FC RID: 17404 RVA: 0x0024EFA0 File Offset: 0x0024D1A0
		public DropNothing()
		{
		}

		// Token: 0x060043FD RID: 17405 RVA: 0x0024EFB4 File Offset: 0x0024D1B4
		public bool CanDrop(DropAttemptInfo info)
		{
		}

		// Token: 0x060043FE RID: 17406 RVA: 0x0024EFC4 File Offset: 0x0024D1C4
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
		}

		// Token: 0x060043FF RID: 17407 RVA: 0x0024EFD4 File Offset: 0x0024D1D4
		public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
			List<IItemDropRuleChainAttempt> list = this.<ChainedRules>k__BackingField;
		}

		// Token: 0x040081C5 RID: 33221
		[CompilerGenerated]
		private List<IItemDropRuleChainAttempt> <ChainedRules>k__BackingField;
	}
}
