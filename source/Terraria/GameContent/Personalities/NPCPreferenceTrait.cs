using System;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x0200082E RID: 2094
	public class NPCPreferenceTrait : IShopPersonalityTrait
	{
		// Token: 0x060042E7 RID: 17127 RVA: 0x0024CD54 File Offset: 0x0024AF54
		public void ModifyShopPrice(HelperInfo info, ShopHelper shopHelperInstance)
		{
			if (info.nearbyNPCsByType != null)
			{
				AffectionLevel level = this.Level;
				return;
			}
		}

		// Token: 0x060042E8 RID: 17128 RVA: 0x0024CD7C File Offset: 0x0024AF7C
		public NPCPreferenceTrait()
		{
		}

		// Token: 0x0400812F RID: 33071
		public AffectionLevel Level;

		// Token: 0x04008130 RID: 33072
		public int NpcId;
	}
}
