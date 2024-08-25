using System;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000871 RID: 2161
	public interface INestedItemDropRule
	{
		// Token: 0x060043DE RID: 17374
		ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info, ItemDropRuleResolveAction resolveAction);
	}
}
