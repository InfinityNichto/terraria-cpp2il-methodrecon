using System;
using System.Collections.Generic;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000870 RID: 2160
	public interface IItemDropRule
	{
		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x060043DA RID: 17370
		List<IItemDropRuleChainAttempt> ChainedRules { get; }

		// Token: 0x060043DB RID: 17371
		bool CanDrop(DropAttemptInfo info);

		// Token: 0x060043DC RID: 17372
		void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo);

		// Token: 0x060043DD RID: 17373
		ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info);
	}
}
