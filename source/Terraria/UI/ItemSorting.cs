using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Terraria.UI
{
	// Token: 0x020006E5 RID: 1765
	public class ItemSorting
	{
		// Token: 0x06003B3D RID: 15165 RVA: 0x00234910 File Offset: 0x00232B10
		public static void SetupWhiteLists()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003B3E RID: 15166 RVA: 0x00234928 File Offset: 0x00232B28
		private static void SetupSortingPriorities()
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
		}

		// Token: 0x06003B3F RID: 15167 RVA: 0x00234970 File Offset: 0x00232B70
		private static void Sort(Item[] inv, bool fromChest, params int[] ignoreSlots)
		{
			if (!true)
			{
			}
			ItemSorting.SetupSortingPriorities();
			long entityId = inv.entityId;
		}

		// Token: 0x06003B40 RID: 15168 RVA: 0x002349F4 File Offset: 0x00232BF4
		public static void SortInventory()
		{
			int num = 1;
			if (num == 0)
			{
			}
			Player localPlayer = Main.LocalPlayer;
			int num2 = 905;
			bool flag = localPlayer.HasItem(num2);
			if (num == 0)
			{
			}
			ItemSorting.SortCoins();
			if (num == 0)
			{
			}
			ItemSorting.SortAmmo();
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
		}

		// Token: 0x06003B41 RID: 15169 RVA: 0x00234A40 File Offset: 0x00232C40
		public static void SortChest()
		{
			int num = 1;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			if (num == 0)
			{
			}
			int myPlayer2 = Main.myPlayer;
			if (num == 0)
			{
			}
			int myPlayer3 = Main.myPlayer;
		}

		// Token: 0x06003B42 RID: 15170 RVA: 0x00234AE0 File Offset: 0x00232CE0
		public static void SortAmmo()
		{
			if (!true)
			{
			}
			ItemSorting.ClearAmmoSlotSpaces();
			ItemSorting.FillAmmoFromInventory();
		}

		// Token: 0x06003B43 RID: 15171 RVA: 0x00234AFC File Offset: 0x00232CFC
		public static void FillAmmoFromInventory()
		{
			int num = 1;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			if (num == 0)
			{
			}
		}

		// Token: 0x06003B44 RID: 15172 RVA: 0x00234B2C File Offset: 0x00232D2C
		public static void ClearAmmoSlotSpaces()
		{
			int num = 1;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			if (num == 0)
			{
			}
		}

		// Token: 0x06003B45 RID: 15173 RVA: 0x00234B50 File Offset: 0x00232D50
		private static void SortCoins()
		{
			if (!true)
			{
			}
			Item[] inventory = Main.LocalPlayer.inventory;
			if (58 == 0)
			{
			}
			long num;
			int[] array = Utils.CoinsSplit(num);
		}

		// Token: 0x06003B46 RID: 15174 RVA: 0x00234BD4 File Offset: 0x00232DD4
		private static void RefillItemStack(Item[] inv, Item itemToRefill, int loopStartIndex, int loopEndIndex)
		{
			int stack = itemToRefill.stack;
			int pick = itemToRefill.pick;
			int stack2 = inv.stack;
			int type = inv.type;
			int type2 = itemToRefill.type;
			int stack3 = itemToRefill.stack;
			itemToRefill.stack = stack3;
			int stack4 = inv.stack;
			inv.stack = stack2;
			long num = 0L;
			inv.TurnToAir(num != 0L);
		}

		// Token: 0x06003B47 RID: 15175 RVA: 0x00234C30 File Offset: 0x00232E30
		private static void TrySlidingUp(Item[] inv, int slot, int minimumIndex)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003B48 RID: 15176 RVA: 0x00234C40 File Offset: 0x00232E40
		public ItemSorting()
		{
		}

		// Token: 0x06003B49 RID: 15177 RVA: 0x00234C54 File Offset: 0x00232E54
		// Note: this type is marked as 'beforefieldinit'.
		static ItemSorting()
		{
		}

		// Token: 0x04007B06 RID: 31494
		private static List<ItemSorting.ItemSortingLayer> _layerList;

		// Token: 0x04007B07 RID: 31495
		private static Dictionary<string, List<int>> _layerWhiteLists;

		// Token: 0x020006E6 RID: 1766
		private class ItemSortingLayer
		{
			// Token: 0x06003B4A RID: 15178 RVA: 0x00234C64 File Offset: 0x00232E64
			public ItemSortingLayer(string name, Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>> method)
			{
				this.Name = name;
				this.SortingMethod = method;
			}

			// Token: 0x06003B4B RID: 15179 RVA: 0x00234C88 File Offset: 0x00232E88
			public void Validate(List<int> indexesSortable, Item[] inv)
			{
				if (!true)
				{
				}
				string name = this.Name;
			}

			// Token: 0x06003B4C RID: 15180 RVA: 0x00234CA0 File Offset: 0x00232EA0
			public override string ToString()
			{
				return this.Name;
			}

			// Token: 0x04007B08 RID: 31496
			public readonly string Name;

			// Token: 0x04007B09 RID: 31497
			public readonly Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>> SortingMethod;

			// Token: 0x020006E7 RID: 1767
			[CompilerGenerated]
			private sealed class <>c__DisplayClass3_0
			{
				// Token: 0x06003B4D RID: 15181 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c__DisplayClass3_0()
				{
				}

				// Token: 0x06003B4E RID: 15182 RVA: 0x00234CB4 File Offset: 0x00232EB4
				internal bool <Validate>b__0(int i)
				{
					return default(bool);
				}

				// Token: 0x04007B0A RID: 31498
				public List<int> list;

				// Token: 0x04007B0B RID: 31499
				public Item[] inv;
			}
		}

		// Token: 0x020006E8 RID: 1768
		private class ItemSortingLayers
		{
			// Token: 0x06003B4F RID: 15183 RVA: 0x00234CCC File Offset: 0x00232ECC
			public ItemSortingLayers()
			{
			}

			// Token: 0x06003B50 RID: 15184 RVA: 0x00234CE0 File Offset: 0x00232EE0
			// Note: this type is marked as 'beforefieldinit'.
			static ItemSortingLayers()
			{
				if (!true)
				{
				}
			}

			// Token: 0x04007B0C RID: 31500
			public static ItemSorting.ItemSortingLayer WeaponsMelee;

			// Token: 0x04007B0D RID: 31501
			public static ItemSorting.ItemSortingLayer WeaponsRanged;

			// Token: 0x04007B0E RID: 31502
			public static ItemSorting.ItemSortingLayer WeaponsMagic;

			// Token: 0x04007B0F RID: 31503
			public static ItemSorting.ItemSortingLayer WeaponsMinions;

			// Token: 0x04007B10 RID: 31504
			public static ItemSorting.ItemSortingLayer WeaponsAssorted;

			// Token: 0x04007B11 RID: 31505
			public static ItemSorting.ItemSortingLayer WeaponsAmmo;

			// Token: 0x04007B12 RID: 31506
			public static ItemSorting.ItemSortingLayer ToolsPicksaws;

			// Token: 0x04007B13 RID: 31507
			public static ItemSorting.ItemSortingLayer ToolsHamaxes;

			// Token: 0x04007B14 RID: 31508
			public static ItemSorting.ItemSortingLayer ToolsPickaxes;

			// Token: 0x04007B15 RID: 31509
			public static ItemSorting.ItemSortingLayer ToolsAxes;

			// Token: 0x04007B16 RID: 31510
			public static ItemSorting.ItemSortingLayer ToolsHammers;

			// Token: 0x04007B17 RID: 31511
			public static ItemSorting.ItemSortingLayer ToolsTerraforming;

			// Token: 0x04007B18 RID: 31512
			public static ItemSorting.ItemSortingLayer ToolsAmmoLeftovers;

			// Token: 0x04007B19 RID: 31513
			public static ItemSorting.ItemSortingLayer ArmorCombat;

			// Token: 0x04007B1A RID: 31514
			public static ItemSorting.ItemSortingLayer ArmorVanity;

			// Token: 0x04007B1B RID: 31515
			public static ItemSorting.ItemSortingLayer ArmorAccessories;

			// Token: 0x04007B1C RID: 31516
			public static ItemSorting.ItemSortingLayer EquipGrapple;

			// Token: 0x04007B1D RID: 31517
			public static ItemSorting.ItemSortingLayer EquipMount;

			// Token: 0x04007B1E RID: 31518
			public static ItemSorting.ItemSortingLayer EquipCart;

			// Token: 0x04007B1F RID: 31519
			public static ItemSorting.ItemSortingLayer EquipLightPet;

			// Token: 0x04007B20 RID: 31520
			public static ItemSorting.ItemSortingLayer EquipVanityPet;

			// Token: 0x04007B21 RID: 31521
			public static ItemSorting.ItemSortingLayer PotionsLife;

			// Token: 0x04007B22 RID: 31522
			public static ItemSorting.ItemSortingLayer PotionsMana;

			// Token: 0x04007B23 RID: 31523
			public static ItemSorting.ItemSortingLayer PotionsElixirs;

			// Token: 0x04007B24 RID: 31524
			public static ItemSorting.ItemSortingLayer PotionsBuffs;

			// Token: 0x04007B25 RID: 31525
			public static ItemSorting.ItemSortingLayer PotionsDyes;

			// Token: 0x04007B26 RID: 31526
			public static ItemSorting.ItemSortingLayer PotionsHairDyes;

			// Token: 0x04007B27 RID: 31527
			public static ItemSorting.ItemSortingLayer MiscValuables;

			// Token: 0x04007B28 RID: 31528
			public static ItemSorting.ItemSortingLayer MiscWiring;

			// Token: 0x04007B29 RID: 31529
			public static ItemSorting.ItemSortingLayer MiscMaterials;

			// Token: 0x04007B2A RID: 31530
			public static ItemSorting.ItemSortingLayer MiscExtractinator;

			// Token: 0x04007B2B RID: 31531
			public static ItemSorting.ItemSortingLayer MiscPainting;

			// Token: 0x04007B2C RID: 31532
			public static ItemSorting.ItemSortingLayer MiscRopes;

			// Token: 0x04007B2D RID: 31533
			public static ItemSorting.ItemSortingLayer LastMaterials;

			// Token: 0x04007B2E RID: 31534
			public static ItemSorting.ItemSortingLayer LastTilesImportant;

			// Token: 0x04007B2F RID: 31535
			public static ItemSorting.ItemSortingLayer LastTilesCommon;

			// Token: 0x04007B30 RID: 31536
			public static ItemSorting.ItemSortingLayer LastNotTrash;

			// Token: 0x04007B31 RID: 31537
			public static ItemSorting.ItemSortingLayer LastTrash;

			// Token: 0x020006E9 RID: 1769
			[CompilerGenerated]
			private sealed class <>c__DisplayClass39_0
			{
				// Token: 0x06003B51 RID: 15185 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c__DisplayClass39_0()
				{
				}

				// Token: 0x06003B52 RID: 15186 RVA: 0x00234CF0 File Offset: 0x00232EF0
				internal bool <.cctor>b__38(int i)
				{
					return default(bool);
				}

				// Token: 0x06003B53 RID: 15187 RVA: 0x00234D08 File Offset: 0x00232F08
				internal int <.cctor>b__39(int x, int y)
				{
					return 0;
				}

				// Token: 0x04007B32 RID: 31538
				public Item[] inv;
			}

			// Token: 0x020006EA RID: 1770
			[CompilerGenerated]
			private sealed class <>c__DisplayClass39_1
			{
				// Token: 0x06003B54 RID: 15188 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c__DisplayClass39_1()
				{
				}

				// Token: 0x06003B55 RID: 15189 RVA: 0x00234D20 File Offset: 0x00232F20
				internal bool <.cctor>b__40(int i)
				{
					return default(bool);
				}

				// Token: 0x06003B56 RID: 15190 RVA: 0x00234D38 File Offset: 0x00232F38
				internal int <.cctor>b__41(int x, int y)
				{
					return 0;
				}

				// Token: 0x04007B33 RID: 31539
				public Item[] inv;
			}

			// Token: 0x020006EB RID: 1771
			[CompilerGenerated]
			private sealed class <>c__DisplayClass39_2
			{
				// Token: 0x06003B57 RID: 15191 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c__DisplayClass39_2()
				{
				}

				// Token: 0x06003B58 RID: 15192 RVA: 0x00234D50 File Offset: 0x00232F50
				internal bool <.cctor>b__42(int i)
				{
					return default(bool);
				}

				// Token: 0x06003B59 RID: 15193 RVA: 0x00234D68 File Offset: 0x00232F68
				internal int <.cctor>b__43(int x, int y)
				{
					return 0;
				}

				// Token: 0x04007B34 RID: 31540
				public Item[] inv;
			}

			// Token: 0x020006EC RID: 1772
			[CompilerGenerated]
			private sealed class <>c__DisplayClass39_3
			{
				// Token: 0x06003B5A RID: 15194 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c__DisplayClass39_3()
				{
				}

				// Token: 0x06003B5B RID: 15195 RVA: 0x00234D80 File Offset: 0x00232F80
				internal bool <.cctor>b__44(int i)
				{
					return default(bool);
				}

				// Token: 0x06003B5C RID: 15196 RVA: 0x00234D98 File Offset: 0x00232F98
				internal int <.cctor>b__45(int x, int y)
				{
					return 0;
				}

				// Token: 0x04007B35 RID: 31541
				public Item[] inv;
			}

			// Token: 0x020006ED RID: 1773
			[CompilerGenerated]
			private sealed class <>c__DisplayClass39_4
			{
				// Token: 0x06003B5D RID: 15197 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c__DisplayClass39_4()
				{
				}

				// Token: 0x06003B5E RID: 15198 RVA: 0x00234DB0 File Offset: 0x00232FB0
				internal bool <.cctor>b__46(int i)
				{
					return default(bool);
				}

				// Token: 0x06003B5F RID: 15199 RVA: 0x00234DC8 File Offset: 0x00232FC8
				internal int <.cctor>b__47(int x, int y)
				{
					return 0;
				}

				// Token: 0x04007B36 RID: 31542
				public Item[] inv;
			}

			// Token: 0x020006EE RID: 1774
			[CompilerGenerated]
			private sealed class <>c__DisplayClass39_5
			{
				// Token: 0x06003B60 RID: 15200 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c__DisplayClass39_5()
				{
				}

				// Token: 0x06003B61 RID: 15201 RVA: 0x00234DE0 File Offset: 0x00232FE0
				internal bool <.cctor>b__48(int i)
				{
					return default(bool);
				}

				// Token: 0x06003B62 RID: 15202 RVA: 0x00234DF8 File Offset: 0x00232FF8
				internal int <.cctor>b__49(int x, int y)
				{
					return 0;
				}

				// Token: 0x04007B37 RID: 31543
				public Item[] inv;
			}

			// Token: 0x020006EF RID: 1775
			[CompilerGenerated]
			private sealed class <>c__DisplayClass39_6
			{
				// Token: 0x06003B63 RID: 15203 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c__DisplayClass39_6()
				{
				}

				// Token: 0x06003B64 RID: 15204 RVA: 0x00234E10 File Offset: 0x00233010
				internal bool <.cctor>b__50(int i)
				{
					return default(bool);
				}

				// Token: 0x06003B65 RID: 15205 RVA: 0x00234E28 File Offset: 0x00233028
				internal int <.cctor>b__51(int x, int y)
				{
					return 0;
				}

				// Token: 0x04007B38 RID: 31544
				public Item[] inv;
			}

			// Token: 0x020006F0 RID: 1776
			[CompilerGenerated]
			private sealed class <>c__DisplayClass39_7
			{
				// Token: 0x06003B66 RID: 15206 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c__DisplayClass39_7()
				{
				}

				// Token: 0x06003B67 RID: 15207 RVA: 0x00234E40 File Offset: 0x00233040
				internal bool <.cctor>b__52(int i)
				{
					return default(bool);
				}

				// Token: 0x06003B68 RID: 15208 RVA: 0x00234E58 File Offset: 0x00233058
				internal int <.cctor>b__53(int x, int y)
				{
					return 0;
				}

				// Token: 0x04007B39 RID: 31545
				public Item[] inv;
			}

			// Token: 0x020006F1 RID: 1777
			[CompilerGenerated]
			private sealed class <>c__DisplayClass39_8
			{
				// Token: 0x06003B69 RID: 15209 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c__DisplayClass39_8()
				{
				}

				// Token: 0x06003B6A RID: 15210 RVA: 0x00234E70 File Offset: 0x00233070
				internal bool <.cctor>b__54(int i)
				{
					return default(bool);
				}

				// Token: 0x06003B6B RID: 15211 RVA: 0x00234E88 File Offset: 0x00233088
				internal int <.cctor>b__55(int x, int y)
				{
					return 0;
				}

				// Token: 0x04007B3A RID: 31546
				public Item[] inv;
			}

			// Token: 0x020006F2 RID: 1778
			[CompilerGenerated]
			private sealed class <>c__DisplayClass39_9
			{
				// Token: 0x06003B6C RID: 15212 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c__DisplayClass39_9()
				{
				}

				// Token: 0x06003B6D RID: 15213 RVA: 0x00234EA0 File Offset: 0x002330A0
				internal bool <.cctor>b__56(int i)
				{
					return default(bool);
				}

				// Token: 0x06003B6E RID: 15214 RVA: 0x00234EB8 File Offset: 0x002330B8
				internal int <.cctor>b__57(int x, int y)
				{
					return 0;
				}

				// Token: 0x04007B3B RID: 31547
				public Item[] inv;
			}

			// Token: 0x020006F3 RID: 1779
			[CompilerGenerated]
			private sealed class <>c__DisplayClass39_10
			{
				// Token: 0x06003B6F RID: 15215 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c__DisplayClass39_10()
				{
				}

				// Token: 0x06003B70 RID: 15216 RVA: 0x00234ED0 File Offset: 0x002330D0
				internal bool <.cctor>b__58(int i)
				{
					return default(bool);
				}

				// Token: 0x06003B71 RID: 15217 RVA: 0x00234EE8 File Offset: 0x002330E8
				internal int <.cctor>b__59(int x, int y)
				{
					return 0;
				}

				// Token: 0x04007B3C RID: 31548
				public Item[] inv;
			}

			// Token: 0x020006F4 RID: 1780
			[CompilerGenerated]
			private sealed class <>c__DisplayClass39_11
			{
				// Token: 0x06003B72 RID: 15218 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c__DisplayClass39_11()
				{
				}

				// Token: 0x06003B73 RID: 15219 RVA: 0x00234F00 File Offset: 0x00233100
				internal bool <.cctor>b__60(int i)
				{
					return default(bool);
				}

				// Token: 0x06003B74 RID: 15220 RVA: 0x00234F18 File Offset: 0x00233118
				internal int <.cctor>b__61(int x, int y)
				{
					return 0;
				}

				// Token: 0x04007B3D RID: 31549
				public Item[] inv;
			}

			// Token: 0x020006F5 RID: 1781
			[CompilerGenerated]
			private sealed class <>c__DisplayClass39_12
			{
				// Token: 0x06003B75 RID: 15221 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c__DisplayClass39_12()
				{
				}

				// Token: 0x06003B76 RID: 15222 RVA: 0x00234F30 File Offset: 0x00233130
				internal bool <.cctor>b__62(int i)
				{
					return default(bool);
				}

				// Token: 0x06003B77 RID: 15223 RVA: 0x00234F48 File Offset: 0x00233148
				internal int <.cctor>b__63(int x, int y)
				{
					return 0;
				}

				// Token: 0x04007B3E RID: 31550
				public Item[] inv;
			}

			// Token: 0x020006F6 RID: 1782
			[CompilerGenerated]
			private sealed class <>c__DisplayClass39_13
			{
				// Token: 0x06003B78 RID: 15224 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c__DisplayClass39_13()
				{
				}

				// Token: 0x06003B79 RID: 15225 RVA: 0x00234F60 File Offset: 0x00233160
				internal bool <.cctor>b__64(int i)
				{
					return default(bool);
				}

				// Token: 0x06003B7A RID: 15226 RVA: 0x00234F78 File Offset: 0x00233178
				internal int <.cctor>b__65(int x, int y)
				{
					return 0;
				}

				// Token: 0x04007B3F RID: 31551
				public Item[] inv;
			}

			// Token: 0x020006F7 RID: 1783
			[CompilerGenerated]
			private sealed class <>c__DisplayClass39_14
			{
				// Token: 0x06003B7B RID: 15227 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c__DisplayClass39_14()
				{
				}

				// Token: 0x06003B7C RID: 15228 RVA: 0x00234F90 File Offset: 0x00233190
				internal bool <.cctor>b__66(int i)
				{
					return default(bool);
				}

				// Token: 0x06003B7D RID: 15229 RVA: 0x00234FA8 File Offset: 0x002331A8
				internal int <.cctor>b__67(int x, int y)
				{
					return 0;
				}

				// Token: 0x04007B40 RID: 31552
				public Item[] inv;
			}

			// Token: 0x020006F8 RID: 1784
			[CompilerGenerated]
			private sealed class <>c__DisplayClass39_15
			{
				// Token: 0x06003B7E RID: 15230 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c__DisplayClass39_15()
				{
				}

				// Token: 0x06003B7F RID: 15231 RVA: 0x00234FC0 File Offset: 0x002331C0
				internal bool <.cctor>b__68(int i)
				{
					return default(bool);
				}

				// Token: 0x06003B80 RID: 15232 RVA: 0x00234FD8 File Offset: 0x002331D8
				internal int <.cctor>b__69(int x, int y)
				{
					return 0;
				}

				// Token: 0x04007B41 RID: 31553
				public Item[] inv;
			}

			// Token: 0x020006F9 RID: 1785
			[CompilerGenerated]
			private sealed class <>c__DisplayClass39_16
			{
				// Token: 0x06003B81 RID: 15233 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c__DisplayClass39_16()
				{
				}

				// Token: 0x06003B82 RID: 15234 RVA: 0x00234FF0 File Offset: 0x002331F0
				internal bool <.cctor>b__70(int i)
				{
					return default(bool);
				}

				// Token: 0x06003B83 RID: 15235 RVA: 0x00235008 File Offset: 0x00233208
				internal int <.cctor>b__71(int x, int y)
				{
					return 0;
				}

				// Token: 0x04007B42 RID: 31554
				public Item[] inv;
			}

			// Token: 0x020006FA RID: 1786
			[CompilerGenerated]
			private sealed class <>c__DisplayClass39_17
			{
				// Token: 0x06003B84 RID: 15236 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c__DisplayClass39_17()
				{
				}

				// Token: 0x06003B85 RID: 15237 RVA: 0x00235020 File Offset: 0x00233220
				internal bool <.cctor>b__72(int i)
				{
					return default(bool);
				}

				// Token: 0x06003B86 RID: 15238 RVA: 0x00235038 File Offset: 0x00233238
				internal int <.cctor>b__73(int x, int y)
				{
					return 0;
				}

				// Token: 0x04007B43 RID: 31555
				public Item[] inv;
			}

			// Token: 0x020006FB RID: 1787
			[CompilerGenerated]
			private sealed class <>c__DisplayClass39_18
			{
				// Token: 0x06003B87 RID: 15239 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c__DisplayClass39_18()
				{
				}

				// Token: 0x06003B88 RID: 15240 RVA: 0x00235050 File Offset: 0x00233250
				internal bool <.cctor>b__74(int i)
				{
					return default(bool);
				}

				// Token: 0x06003B89 RID: 15241 RVA: 0x00235068 File Offset: 0x00233268
				internal int <.cctor>b__75(int x, int y)
				{
					return 0;
				}

				// Token: 0x04007B44 RID: 31556
				public Item[] inv;
			}

			// Token: 0x020006FC RID: 1788
			[CompilerGenerated]
			private sealed class <>c__DisplayClass39_19
			{
				// Token: 0x06003B8A RID: 15242 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c__DisplayClass39_19()
				{
				}

				// Token: 0x06003B8B RID: 15243 RVA: 0x00235080 File Offset: 0x00233280
				internal bool <.cctor>b__76(int i)
				{
					return default(bool);
				}

				// Token: 0x06003B8C RID: 15244 RVA: 0x00235098 File Offset: 0x00233298
				internal int <.cctor>b__77(int x, int y)
				{
					return 0;
				}

				// Token: 0x04007B45 RID: 31557
				public Item[] inv;
			}

			// Token: 0x020006FD RID: 1789
			[CompilerGenerated]
			private sealed class <>c__DisplayClass39_20
			{
				// Token: 0x06003B8D RID: 15245 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c__DisplayClass39_20()
				{
				}

				// Token: 0x06003B8E RID: 15246 RVA: 0x002350B0 File Offset: 0x002332B0
				internal bool <.cctor>b__78(int i)
				{
					return default(bool);
				}

				// Token: 0x06003B8F RID: 15247 RVA: 0x002350C8 File Offset: 0x002332C8
				internal int <.cctor>b__79(int x, int y)
				{
					return 0;
				}

				// Token: 0x04007B46 RID: 31558
				public Item[] inv;
			}

			// Token: 0x020006FE RID: 1790
			[CompilerGenerated]
			private sealed class <>c__DisplayClass39_21
			{
				// Token: 0x06003B90 RID: 15248 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c__DisplayClass39_21()
				{
				}

				// Token: 0x06003B91 RID: 15249 RVA: 0x002350E0 File Offset: 0x002332E0
				internal bool <.cctor>b__80(int i)
				{
					return default(bool);
				}

				// Token: 0x06003B92 RID: 15250 RVA: 0x002350F8 File Offset: 0x002332F8
				internal int <.cctor>b__81(int x, int y)
				{
					return 0;
				}

				// Token: 0x04007B47 RID: 31559
				public Item[] inv;
			}

			// Token: 0x020006FF RID: 1791
			[CompilerGenerated]
			private sealed class <>c__DisplayClass39_22
			{
				// Token: 0x06003B93 RID: 15251 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c__DisplayClass39_22()
				{
				}

				// Token: 0x06003B94 RID: 15252 RVA: 0x00235110 File Offset: 0x00233310
				internal bool <.cctor>b__82(int i)
				{
					return default(bool);
				}

				// Token: 0x06003B95 RID: 15253 RVA: 0x00235128 File Offset: 0x00233328
				internal int <.cctor>b__83(int x, int y)
				{
					return 0;
				}

				// Token: 0x04007B48 RID: 31560
				public Item[] inv;
			}

			// Token: 0x02000700 RID: 1792
			[CompilerGenerated]
			private sealed class <>c__DisplayClass39_23
			{
				// Token: 0x06003B96 RID: 15254 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c__DisplayClass39_23()
				{
				}

				// Token: 0x06003B97 RID: 15255 RVA: 0x00235140 File Offset: 0x00233340
				internal bool <.cctor>b__84(int i)
				{
					return default(bool);
				}

				// Token: 0x06003B98 RID: 15256 RVA: 0x00235158 File Offset: 0x00233358
				internal int <.cctor>b__85(int x, int y)
				{
					return 0;
				}

				// Token: 0x04007B49 RID: 31561
				public Item[] inv;
			}

			// Token: 0x02000701 RID: 1793
			[CompilerGenerated]
			private sealed class <>c__DisplayClass39_24
			{
				// Token: 0x06003B99 RID: 15257 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c__DisplayClass39_24()
				{
				}

				// Token: 0x06003B9A RID: 15258 RVA: 0x00235170 File Offset: 0x00233370
				internal bool <.cctor>b__86(int i)
				{
					return default(bool);
				}

				// Token: 0x06003B9B RID: 15259 RVA: 0x00235188 File Offset: 0x00233388
				internal int <.cctor>b__87(int x, int y)
				{
					return 0;
				}

				// Token: 0x04007B4A RID: 31562
				public Item[] inv;
			}

			// Token: 0x02000702 RID: 1794
			[CompilerGenerated]
			private sealed class <>c__DisplayClass39_25
			{
				// Token: 0x06003B9C RID: 15260 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c__DisplayClass39_25()
				{
				}

				// Token: 0x06003B9D RID: 15261 RVA: 0x002351A0 File Offset: 0x002333A0
				internal bool <.cctor>b__88(int i)
				{
					return default(bool);
				}

				// Token: 0x06003B9E RID: 15262 RVA: 0x002351B8 File Offset: 0x002333B8
				internal int <.cctor>b__89(int x, int y)
				{
					return 0;
				}

				// Token: 0x04007B4B RID: 31563
				public Item[] inv;
			}

			// Token: 0x02000703 RID: 1795
			[CompilerGenerated]
			private sealed class <>c__DisplayClass39_26
			{
				// Token: 0x06003B9F RID: 15263 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c__DisplayClass39_26()
				{
				}

				// Token: 0x06003BA0 RID: 15264 RVA: 0x002351D0 File Offset: 0x002333D0
				internal bool <.cctor>b__90(int i)
				{
					return default(bool);
				}

				// Token: 0x06003BA1 RID: 15265 RVA: 0x002351E8 File Offset: 0x002333E8
				internal int <.cctor>b__91(int x, int y)
				{
					return 0;
				}

				// Token: 0x04007B4C RID: 31564
				public Item[] inv;
			}

			// Token: 0x02000704 RID: 1796
			[CompilerGenerated]
			private sealed class <>c__DisplayClass39_27
			{
				// Token: 0x06003BA2 RID: 15266 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c__DisplayClass39_27()
				{
				}

				// Token: 0x06003BA3 RID: 15267 RVA: 0x00235200 File Offset: 0x00233400
				internal bool <.cctor>b__92(int i)
				{
					return default(bool);
				}

				// Token: 0x06003BA4 RID: 15268 RVA: 0x00235218 File Offset: 0x00233418
				internal int <.cctor>b__93(int x, int y)
				{
					return 0;
				}

				// Token: 0x04007B4D RID: 31565
				public Item[] inv;
			}

			// Token: 0x02000705 RID: 1797
			[CompilerGenerated]
			private sealed class <>c__DisplayClass39_28
			{
				// Token: 0x06003BA5 RID: 15269 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c__DisplayClass39_28()
				{
				}

				// Token: 0x06003BA6 RID: 15270 RVA: 0x00235230 File Offset: 0x00233430
				internal bool <.cctor>b__94(int i)
				{
					return default(bool);
				}

				// Token: 0x06003BA7 RID: 15271 RVA: 0x00235248 File Offset: 0x00233448
				internal int <.cctor>b__95(int x, int y)
				{
					return 0;
				}

				// Token: 0x04007B4E RID: 31566
				public Item[] inv;
			}

			// Token: 0x02000706 RID: 1798
			[CompilerGenerated]
			private sealed class <>c__DisplayClass39_29
			{
				// Token: 0x06003BA8 RID: 15272 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c__DisplayClass39_29()
				{
				}

				// Token: 0x06003BA9 RID: 15273 RVA: 0x00235260 File Offset: 0x00233460
				internal bool <.cctor>b__96(int i)
				{
					return default(bool);
				}

				// Token: 0x06003BAA RID: 15274 RVA: 0x00235278 File Offset: 0x00233478
				internal int <.cctor>b__97(int x, int y)
				{
					return 0;
				}

				// Token: 0x04007B4F RID: 31567
				public Item[] inv;
			}

			// Token: 0x02000707 RID: 1799
			[CompilerGenerated]
			private sealed class <>c__DisplayClass39_30
			{
				// Token: 0x06003BAB RID: 15275 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c__DisplayClass39_30()
				{
				}

				// Token: 0x06003BAC RID: 15276 RVA: 0x00235290 File Offset: 0x00233490
				internal bool <.cctor>b__98(int i)
				{
					return default(bool);
				}

				// Token: 0x06003BAD RID: 15277 RVA: 0x002352A8 File Offset: 0x002334A8
				internal int <.cctor>b__99(int x, int y)
				{
					return 0;
				}

				// Token: 0x04007B50 RID: 31568
				public Item[] inv;
			}

			// Token: 0x02000708 RID: 1800
			[CompilerGenerated]
			private sealed class <>c__DisplayClass39_31
			{
				// Token: 0x06003BAE RID: 15278 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c__DisplayClass39_31()
				{
				}

				// Token: 0x06003BAF RID: 15279 RVA: 0x002352C0 File Offset: 0x002334C0
				internal bool <.cctor>b__100(int i)
				{
					return default(bool);
				}

				// Token: 0x06003BB0 RID: 15280 RVA: 0x002352D8 File Offset: 0x002334D8
				internal int <.cctor>b__101(int x, int y)
				{
					return 0;
				}

				// Token: 0x04007B51 RID: 31569
				public Item[] inv;
			}

			// Token: 0x02000709 RID: 1801
			[CompilerGenerated]
			private sealed class <>c__DisplayClass39_32
			{
				// Token: 0x06003BB1 RID: 15281 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c__DisplayClass39_32()
				{
				}

				// Token: 0x06003BB2 RID: 15282 RVA: 0x002352F0 File Offset: 0x002334F0
				internal bool <.cctor>b__102(int i)
				{
					return default(bool);
				}

				// Token: 0x06003BB3 RID: 15283 RVA: 0x00235308 File Offset: 0x00233508
				internal int <.cctor>b__103(int x, int y)
				{
					return 0;
				}

				// Token: 0x04007B52 RID: 31570
				public Item[] inv;
			}

			// Token: 0x0200070A RID: 1802
			[CompilerGenerated]
			private sealed class <>c__DisplayClass39_33
			{
				// Token: 0x06003BB4 RID: 15284 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c__DisplayClass39_33()
				{
				}

				// Token: 0x06003BB5 RID: 15285 RVA: 0x00235320 File Offset: 0x00233520
				internal bool <.cctor>b__104(int i)
				{
					return default(bool);
				}

				// Token: 0x06003BB6 RID: 15286 RVA: 0x00235338 File Offset: 0x00233538
				internal int <.cctor>b__105(int x, int y)
				{
					return 0;
				}

				// Token: 0x04007B53 RID: 31571
				public Item[] inv;
			}

			// Token: 0x0200070B RID: 1803
			[CompilerGenerated]
			private sealed class <>c__DisplayClass39_34
			{
				// Token: 0x06003BB7 RID: 15287 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c__DisplayClass39_34()
				{
				}

				// Token: 0x06003BB8 RID: 15288 RVA: 0x00235350 File Offset: 0x00233550
				internal bool <.cctor>b__106(int i)
				{
					return default(bool);
				}

				// Token: 0x06003BB9 RID: 15289 RVA: 0x00235368 File Offset: 0x00233568
				internal int <.cctor>b__107(int x, int y)
				{
					return 0;
				}

				// Token: 0x04007B54 RID: 31572
				public Item[] inv;
			}

			// Token: 0x0200070C RID: 1804
			[CompilerGenerated]
			private sealed class <>c__DisplayClass39_35
			{
				// Token: 0x06003BBA RID: 15290 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c__DisplayClass39_35()
				{
				}

				// Token: 0x06003BBB RID: 15291 RVA: 0x00235380 File Offset: 0x00233580
				internal bool <.cctor>b__108(int i)
				{
					return default(bool);
				}

				// Token: 0x06003BBC RID: 15292 RVA: 0x00235398 File Offset: 0x00233598
				internal int <.cctor>b__109(int x, int y)
				{
					return 0;
				}

				// Token: 0x04007B55 RID: 31573
				public Item[] inv;
			}

			// Token: 0x0200070D RID: 1805
			[CompilerGenerated]
			private sealed class <>c__DisplayClass39_36
			{
				// Token: 0x06003BBD RID: 15293 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c__DisplayClass39_36()
				{
				}

				// Token: 0x06003BBE RID: 15294 RVA: 0x002353B0 File Offset: 0x002335B0
				internal bool <.cctor>b__110(int i)
				{
					return default(bool);
				}

				// Token: 0x06003BBF RID: 15295 RVA: 0x002353C8 File Offset: 0x002335C8
				internal int <.cctor>b__111(int x, int y)
				{
					return 0;
				}

				// Token: 0x04007B56 RID: 31574
				public Item[] inv;
			}

			// Token: 0x0200070E RID: 1806
			[CompilerGenerated]
			private sealed class <>c__DisplayClass39_37
			{
				// Token: 0x06003BC0 RID: 15296 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c__DisplayClass39_37()
				{
				}

				// Token: 0x06003BC1 RID: 15297 RVA: 0x002353E0 File Offset: 0x002335E0
				internal int <.cctor>b__112(int x, int y)
				{
					return 0;
				}

				// Token: 0x04007B57 RID: 31575
				public Item[] inv;
			}

			// Token: 0x0200070F RID: 1807
			[CompilerGenerated]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x06003BC2 RID: 15298 RVA: 0x00003BB6 File Offset: 0x00001DB6
				// Note: this type is marked as 'beforefieldinit'.
				static <>c()
				{
				}

				// Token: 0x06003BC3 RID: 15299 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c()
				{
				}

				// Token: 0x06003BC4 RID: 15300 RVA: 0x00003B83 File Offset: 0x00001D83
				internal List<int> <.cctor>b__39_0(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06003BC5 RID: 15301 RVA: 0x00003B83 File Offset: 0x00001D83
				internal List<int> <.cctor>b__39_1(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06003BC6 RID: 15302 RVA: 0x00003B83 File Offset: 0x00001D83
				internal List<int> <.cctor>b__39_2(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06003BC7 RID: 15303 RVA: 0x00003B83 File Offset: 0x00001D83
				internal List<int> <.cctor>b__39_3(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06003BC8 RID: 15304 RVA: 0x00003B83 File Offset: 0x00001D83
				internal List<int> <.cctor>b__39_4(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06003BC9 RID: 15305 RVA: 0x00003B83 File Offset: 0x00001D83
				internal List<int> <.cctor>b__39_5(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06003BCA RID: 15306 RVA: 0x00003B83 File Offset: 0x00001D83
				internal List<int> <.cctor>b__39_6(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06003BCB RID: 15307 RVA: 0x00003B83 File Offset: 0x00001D83
				internal List<int> <.cctor>b__39_7(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06003BCC RID: 15308 RVA: 0x00003B83 File Offset: 0x00001D83
				internal List<int> <.cctor>b__39_8(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06003BCD RID: 15309 RVA: 0x00003B83 File Offset: 0x00001D83
				internal List<int> <.cctor>b__39_9(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06003BCE RID: 15310 RVA: 0x00003B83 File Offset: 0x00001D83
				internal List<int> <.cctor>b__39_10(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06003BCF RID: 15311 RVA: 0x00003B83 File Offset: 0x00001D83
				internal List<int> <.cctor>b__39_11(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06003BD0 RID: 15312 RVA: 0x00003B83 File Offset: 0x00001D83
				internal List<int> <.cctor>b__39_12(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06003BD1 RID: 15313 RVA: 0x00003B83 File Offset: 0x00001D83
				internal List<int> <.cctor>b__39_13(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06003BD2 RID: 15314 RVA: 0x00003B83 File Offset: 0x00001D83
				internal List<int> <.cctor>b__39_14(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06003BD3 RID: 15315 RVA: 0x00003B83 File Offset: 0x00001D83
				internal List<int> <.cctor>b__39_15(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06003BD4 RID: 15316 RVA: 0x00003B83 File Offset: 0x00001D83
				internal List<int> <.cctor>b__39_16(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06003BD5 RID: 15317 RVA: 0x00003B83 File Offset: 0x00001D83
				internal List<int> <.cctor>b__39_17(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06003BD6 RID: 15318 RVA: 0x00003B83 File Offset: 0x00001D83
				internal List<int> <.cctor>b__39_18(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06003BD7 RID: 15319 RVA: 0x00003B83 File Offset: 0x00001D83
				internal List<int> <.cctor>b__39_19(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06003BD8 RID: 15320 RVA: 0x00003B83 File Offset: 0x00001D83
				internal List<int> <.cctor>b__39_20(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06003BD9 RID: 15321 RVA: 0x00003B83 File Offset: 0x00001D83
				internal List<int> <.cctor>b__39_21(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06003BDA RID: 15322 RVA: 0x00003B83 File Offset: 0x00001D83
				internal List<int> <.cctor>b__39_22(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06003BDB RID: 15323 RVA: 0x00003B83 File Offset: 0x00001D83
				internal List<int> <.cctor>b__39_23(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06003BDC RID: 15324 RVA: 0x00003B83 File Offset: 0x00001D83
				internal List<int> <.cctor>b__39_24(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06003BDD RID: 15325 RVA: 0x00003B83 File Offset: 0x00001D83
				internal List<int> <.cctor>b__39_25(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06003BDE RID: 15326 RVA: 0x00003B83 File Offset: 0x00001D83
				internal List<int> <.cctor>b__39_26(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06003BDF RID: 15327 RVA: 0x00003B83 File Offset: 0x00001D83
				internal List<int> <.cctor>b__39_27(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06003BE0 RID: 15328 RVA: 0x00003B83 File Offset: 0x00001D83
				internal List<int> <.cctor>b__39_28(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06003BE1 RID: 15329 RVA: 0x00003B83 File Offset: 0x00001D83
				internal List<int> <.cctor>b__39_29(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06003BE2 RID: 15330 RVA: 0x00003B83 File Offset: 0x00001D83
				internal List<int> <.cctor>b__39_30(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06003BE3 RID: 15331 RVA: 0x00003B83 File Offset: 0x00001D83
				internal List<int> <.cctor>b__39_31(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06003BE4 RID: 15332 RVA: 0x00003B83 File Offset: 0x00001D83
				internal List<int> <.cctor>b__39_32(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06003BE5 RID: 15333 RVA: 0x00003B83 File Offset: 0x00001D83
				internal List<int> <.cctor>b__39_33(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06003BE6 RID: 15334 RVA: 0x00003B83 File Offset: 0x00001D83
				internal List<int> <.cctor>b__39_34(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06003BE7 RID: 15335 RVA: 0x00003B83 File Offset: 0x00001D83
				internal List<int> <.cctor>b__39_35(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06003BE8 RID: 15336 RVA: 0x00003B83 File Offset: 0x00001D83
				internal List<int> <.cctor>b__39_36(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06003BE9 RID: 15337 RVA: 0x00003B83 File Offset: 0x00001D83
				internal List<int> <.cctor>b__39_37(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x04007B58 RID: 31576
				public static readonly ItemSorting.ItemSortingLayers.<>c <>9;
			}
		}

		// Token: 0x02000710 RID: 1808
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003BEA RID: 15338 RVA: 0x002353F8 File Offset: 0x002335F8
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06003BEB RID: 15339 RVA: 0x00235408 File Offset: 0x00233608
			public <>c()
			{
			}

			// Token: 0x06003BEC RID: 15340 RVA: 0x0023541C File Offset: 0x0023361C
			internal int <SetupSortingPriorities>b__5_0(float x, float y)
			{
				int num;
				return num;
			}

			// Token: 0x04007B59 RID: 31577
			public static readonly ItemSorting.<>c <>9;

			// Token: 0x04007B5A RID: 31578
			public static Comparison<float> <>9__5_0;
		}
	}
}
