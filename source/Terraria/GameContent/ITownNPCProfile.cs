using System;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent
{
	// Token: 0x020007FB RID: 2043
	public interface ITownNPCProfile
	{
		// Token: 0x06004190 RID: 16784
		int RollVariation();

		// Token: 0x06004191 RID: 16785
		string GetNameForVariant(NPC npc);

		// Token: 0x06004192 RID: 16786
		Asset<Texture2D> GetTextureNPCShouldUse(NPC npc);

		// Token: 0x06004193 RID: 16787
		int GetHeadTextureIndex(NPC npc);
	}
}
