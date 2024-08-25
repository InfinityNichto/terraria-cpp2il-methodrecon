using System;
using System.Collections.Generic;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000874 RID: 2164
	public interface IItemDropRuleChainAttempt
	{
		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x060043DF RID: 17375
		IItemDropRule RuleToChain { get; }

		// Token: 0x060043E0 RID: 17376
		bool CanChainIntoRule(ItemDropAttemptResult parentResult);

		// Token: 0x060043E1 RID: 17377
		void ReportDroprates(float personalDropRate, List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo);
	}
}
