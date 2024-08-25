using System;

namespace Terraria.ID
{
	// Token: 0x020005E4 RID: 1508
	public static class PlayerItemSlotID
	{
		// Token: 0x0600356E RID: 13678 RVA: 0x0020FBAC File Offset: 0x0020DDAC
		static PlayerItemSlotID()
		{
			int num = PlayerItemSlotID.AllocateSlots(58, true);
			int num2 = PlayerItemSlotID.AllocateSlots(1, true);
			int num3 = PlayerItemSlotID.AllocateSlots(20, true);
			int num4 = PlayerItemSlotID.AllocateSlots(10, true);
			int num5 = PlayerItemSlotID.AllocateSlots(5, true);
			int num6 = PlayerItemSlotID.AllocateSlots(5, true);
			long num7 = 0L;
			int num8 = PlayerItemSlotID.AllocateSlots(40, num7 != 0L);
			long num9 = 0L;
			int num10 = PlayerItemSlotID.AllocateSlots(40, num9 != 0L);
			long num11 = 0L;
			int num12 = PlayerItemSlotID.AllocateSlots(1, num11 != 0L);
			long num13 = 0L;
			int num14 = PlayerItemSlotID.AllocateSlots(40, num13 != 0L);
			int num15 = PlayerItemSlotID.AllocateSlots(40, true);
			int num16 = PlayerItemSlotID.AllocateSlots(20, true);
			int num17 = PlayerItemSlotID.AllocateSlots(10, true);
			int num18 = PlayerItemSlotID.AllocateSlots(20, true);
			int num19 = PlayerItemSlotID.AllocateSlots(10, true);
			int num20 = PlayerItemSlotID.AllocateSlots(20, true);
			int num21 = PlayerItemSlotID.AllocateSlots(10, true);
		}

		// Token: 0x0600356F RID: 13679 RVA: 0x0020FC70 File Offset: 0x0020DE70
		private static int AllocateSlots(int amount, bool canNetRelay)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			return 43147264;
		}

		// Token: 0x040068CB RID: 26827
		public static readonly int Inventory0;

		// Token: 0x040068CC RID: 26828
		public static readonly int InventoryMouseItem;

		// Token: 0x040068CD RID: 26829
		public static readonly int Armor0;

		// Token: 0x040068CE RID: 26830
		public static readonly int Dye0;

		// Token: 0x040068CF RID: 26831
		public static readonly int Misc0;

		// Token: 0x040068D0 RID: 26832
		public static readonly int MiscDye0;

		// Token: 0x040068D1 RID: 26833
		public static readonly int Bank1_0;

		// Token: 0x040068D2 RID: 26834
		public static readonly int Bank2_0;

		// Token: 0x040068D3 RID: 26835
		public static readonly int TrashItem;

		// Token: 0x040068D4 RID: 26836
		public static readonly int Bank3_0;

		// Token: 0x040068D5 RID: 26837
		public static readonly int Bank4_0;

		// Token: 0x040068D6 RID: 26838
		public static readonly int Loadout1_Armor_0;

		// Token: 0x040068D7 RID: 26839
		public static readonly int Loadout1_Dye_0;

		// Token: 0x040068D8 RID: 26840
		public static readonly int Loadout2_Armor_0;

		// Token: 0x040068D9 RID: 26841
		public static readonly int Loadout2_Dye_0;

		// Token: 0x040068DA RID: 26842
		public static readonly int Loadout3_Armor_0;

		// Token: 0x040068DB RID: 26843
		public static readonly int Loadout3_Dye_0;

		// Token: 0x040068DC RID: 26844
		public static bool[] CanRelay;

		// Token: 0x040068DD RID: 26845
		private static int _nextSlotId;
	}
}
