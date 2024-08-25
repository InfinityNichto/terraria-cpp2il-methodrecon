using System;
using Terraria.DataStructures;

namespace Terraria.GameContent.UI.ResourceSets
{
	// Token: 0x02000A82 RID: 2690
	public interface IPlayerResourcesDisplaySet : IConfigKeyHolder
	{
		// Token: 0x06004F8D RID: 20365
		void Draw();

		// Token: 0x06004F8E RID: 20366
		void TryToHover();
	}
}
