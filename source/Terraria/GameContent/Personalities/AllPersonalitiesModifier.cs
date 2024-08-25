using System;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x02000841 RID: 2113
	public class AllPersonalitiesModifier : IShopPersonalityTrait
	{
		// Token: 0x0600430C RID: 17164 RVA: 0x0024D0B4 File Offset: 0x0024B2B4
		public void ModifyShopPrice(HelperInfo info, ShopHelper shopHelperInstance)
		{
			Player player = info.player;
		}

		// Token: 0x0600430D RID: 17165 RVA: 0x0024D0C8 File Offset: 0x0024B2C8
		private static void ModifyShopPrice_Relationships(HelperInfo info, ShopHelper shopHelperInstance)
		{
			NPC npc = info.npc;
			bool[] nearbyNPCsByType = info.nearbyNPCsByType;
			int type = npc.type;
		}

		// Token: 0x0600430E RID: 17166 RVA: 0x0024D608 File Offset: 0x0024B808
		public AllPersonalitiesModifier()
		{
		}
	}
}
