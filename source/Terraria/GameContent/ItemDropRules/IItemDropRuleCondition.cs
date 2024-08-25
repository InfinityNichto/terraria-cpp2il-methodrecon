using System;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000875 RID: 2165
	public interface IItemDropRuleCondition : IProvideItemConditionDescription
	{
		// Token: 0x060043E2 RID: 17378
		bool CanDrop(DropAttemptInfo info);

		// Token: 0x060043E3 RID: 17379
		bool CanShowItemDropInUI();
	}
}
