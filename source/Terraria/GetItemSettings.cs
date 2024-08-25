using System;
using System.Runtime.InteropServices;

namespace Terraria
{
	// Token: 0x0200044D RID: 1101
	public struct GetItemSettings
	{
		// Token: 0x06002967 RID: 10599 RVA: 0x0019B5F8 File Offset: 0x001997F8
		public GetItemSettings(bool LongText = false, bool NoText = false, bool CanGoIntoVoidVault = false, [Optional] Action<Item> StepAfterHandlingSlotNormally)
		{
			this.StepAfterHandlingSlotNormally = StepAfterHandlingSlotNormally;
		}

		// Token: 0x06002968 RID: 10600 RVA: 0x0019B610 File Offset: 0x00199810
		public void HandlePostAction(Item item)
		{
			if (this.StepAfterHandlingSlotNormally != null)
			{
				return;
			}
		}

		// Token: 0x06002969 RID: 10601 RVA: 0x0019B628 File Offset: 0x00199828
		private static void MakeNewAndShiny(Item item)
		{
			item.newAndShiny = true;
		}

		// Token: 0x0600296A RID: 10602 RVA: 0x0019B63C File Offset: 0x0019983C
		// Note: this type is marked as 'beforefieldinit'.
		static GetItemSettings()
		{
		}

		// Token: 0x04003683 RID: 13955
		public static GetItemSettings InventoryEntityToPlayerInventorySettings;

		// Token: 0x04003684 RID: 13956
		public static GetItemSettings NPCEntityToPlayerInventorySettings;

		// Token: 0x04003685 RID: 13957
		public static GetItemSettings LootAllSettings;

		// Token: 0x04003686 RID: 13958
		public static GetItemSettings LootAllSettingsRegularChest;

		// Token: 0x04003687 RID: 13959
		public static GetItemSettings PickupItemFromWorld;

		// Token: 0x04003688 RID: 13960
		public static GetItemSettings GetItemInDropItemCheck;

		// Token: 0x04003689 RID: 13961
		public static GetItemSettings InventoryUIToInventorySettings;

		// Token: 0x0400368A RID: 13962
		public static GetItemSettings InventoryUIToInventorySettingsShowAsNew;

		// Token: 0x0400368B RID: 13963
		public static GetItemSettings ItemCreatedFromItemUsage;

		// Token: 0x0400368C RID: 13964
		public readonly bool LongText;

		// Token: 0x0400368D RID: 13965
		public readonly bool NoText;

		// Token: 0x0400368E RID: 13966
		public readonly bool CanGoIntoVoidVault;

		// Token: 0x0400368F RID: 13967
		public readonly Action<Item> StepAfterHandlingSlotNormally;
	}
}
