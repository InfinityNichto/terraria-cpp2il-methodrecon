using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.ObjectInteractions
{
	// Token: 0x02000842 RID: 2114
	public abstract class AHoverInteractionChecker
	{
		// Token: 0x0600430F RID: 17167 RVA: 0x000021DB File Offset: 0x000003DB
		internal AHoverInteractionChecker.HoverStatus AttemptInteraction(Player player, Rectangle Hitbox)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004310 RID: 17168
		internal abstract bool? AttemptOverridingHoverStatus(Player player, Rectangle rectangle);

		// Token: 0x06004311 RID: 17169
		internal abstract void DoHoverEffect(Player player, Rectangle hitbox);

		// Token: 0x06004312 RID: 17170
		internal abstract bool ShouldBlockInteraction(Player player, Rectangle hitbox);

		// Token: 0x06004313 RID: 17171
		internal abstract void PerformInteraction(Player player, Rectangle hitbox);

		// Token: 0x06004314 RID: 17172 RVA: 0x0024D61C File Offset: 0x0024B81C
		protected AHoverInteractionChecker()
		{
		}

		// Token: 0x02000843 RID: 2115
		internal enum HoverStatus
		{
			// Token: 0x04008140 RID: 33088
			NotSelectable,
			// Token: 0x04008141 RID: 33089
			SelectableButNotSelected,
			// Token: 0x04008142 RID: 33090
			Selected
		}
	}
}
