using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Terraria.GameContent.Bestiary;

namespace Terraria.ID
{
	// Token: 0x020005BD RID: 1469
	public static class ContentSamples
	{
		// Token: 0x06003512 RID: 13586 RVA: 0x0020ABE4 File Offset: 0x00208DE4
		public static void Initialize()
		{
			if (!true)
			{
			}
			ContentSamples.ModifyNPCIds();
		}

		// Token: 0x06003513 RID: 13587 RVA: 0x0020AC28 File Offset: 0x00208E28
		public static void ResetItemTooltips()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003514 RID: 13588 RVA: 0x0020AC4C File Offset: 0x00208E4C
		public static void RefreshItemsOnWorldLoad()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003515 RID: 13589 RVA: 0x0020AC70 File Offset: 0x00208E70
		private static void FillResearchItemOverrides()
		{
			if (5325 == 0)
			{
			}
		}

		// Token: 0x06003516 RID: 13590 RVA: 0x0020AC84 File Offset: 0x00208E84
		private static void AddItemResearchOverride(int itemTypeToUnlock, params int[] itemsThatWillResearchTheItemToUnlock)
		{
			if (!true)
			{
			}
			ContentSamples.AddItemResearchOverride_Inner(43147264, itemTypeToUnlock);
		}

		// Token: 0x06003517 RID: 13591 RVA: 0x0020ACA4 File Offset: 0x00208EA4
		private static void AddItemResearchOverride_Inner(int itemTypeToSacrifice, int itemTypeToUnlock)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003518 RID: 13592 RVA: 0x0020ACB4 File Offset: 0x00208EB4
		public static void FixItemsAfterRecipesAreAdded()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06003519 RID: 13593 RVA: 0x0020ACE0 File Offset: 0x00208EE0
		public static void RebuildBestiarySortingIDsByBestiaryDatabaseContents(BestiaryDatabase database)
		{
			if (!true)
			{
			}
			ContentSamples.CreateBestiarySortingIds(database);
		}

		// Token: 0x0600351A RID: 13594 RVA: 0x0020ACF8 File Offset: 0x00208EF8
		public static void RebuildItemCreativeSortingIDsAfterRecipesAreSetUp()
		{
			if (!true)
			{
			}
			ContentSamples.CreateCreativeItemSortingIds();
		}

		// Token: 0x0600351B RID: 13595 RVA: 0x0020AD10 File Offset: 0x00208F10
		private static void ModifyNPCIds()
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600351C RID: 13596 RVA: 0x0020AD28 File Offset: 0x00208F28
		private static void CreateBestiarySortingIds(BestiaryDatabase database)
		{
			int num = 1;
			List<KeyValuePair<int, NPC>> sortedBestiaryEntriesList = ContentSamples.BestiaryHelper.GetSortedBestiaryEntriesList(database);
			if (num == 0)
			{
			}
		}

		// Token: 0x0600351D RID: 13597 RVA: 0x0020AD58 File Offset: 0x00208F58
		private static void FillNpcRarities()
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
		}

		// Token: 0x0600351E RID: 13598 RVA: 0x0020AD70 File Offset: 0x00208F70
		private static int GetNPCBestiaryRarityStarsCount(NPC npc)
		{
		}

		// Token: 0x0600351F RID: 13599 RVA: 0x0020AD88 File Offset: 0x00208F88
		private static void CreateCreativeItemSortingIds()
		{
			if (!true)
			{
			}
			ContentSamples.CreativeHelper.SetCreativeMenuOrder();
		}

		// Token: 0x06003520 RID: 13600 RVA: 0x0020ADA0 File Offset: 0x00208FA0
		// Note: this type is marked as 'beforefieldinit'.
		static ContentSamples()
		{
		}

		// Token: 0x0400476E RID: 18286
		public static Dictionary<int, NPC> NpcsByNetId;

		// Token: 0x0400476F RID: 18287
		public static Dictionary<int, Item> ItemsByType;

		// Token: 0x04004770 RID: 18288
		public static Dictionary<string, int> ItemNetIdsByPersistentIds;

		// Token: 0x04004771 RID: 18289
		public static Dictionary<int, string> ItemPersistentIdsByNetIds;

		// Token: 0x04004772 RID: 18290
		public static Dictionary<int, int> CreativeResearchItemPersistentIdOverride;

		// Token: 0x04004773 RID: 18291
		public static Dictionary<string, int> NpcNetIdsByPersistentIds;

		// Token: 0x04004774 RID: 18292
		public static Dictionary<int, string> NpcPersistentIdsByNetIds;

		// Token: 0x04004775 RID: 18293
		public static Dictionary<int, int> NpcBestiarySortingId;

		// Token: 0x04004776 RID: 18294
		public static Dictionary<int, int> NpcBestiaryRarityStars;

		// Token: 0x04004777 RID: 18295
		public static Dictionary<int, string> NpcBestiaryCreditIdsByNpcNetIds;

		// Token: 0x04004778 RID: 18296
		public static Dictionary<int, ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup> ItemCreativeSortingId;

		// Token: 0x020005BE RID: 1470
		public static class CommonlyUsedContentSamples
		{
			// Token: 0x06003521 RID: 13601 RVA: 0x0020ADB0 File Offset: 0x00208FB0
			public static void PrepareAfterEverythingElseLoaded()
			{
				if (!true)
				{
				}
			}

			// Token: 0x06003522 RID: 13602 RVA: 0x0020ADC0 File Offset: 0x00208FC0
			// Note: this type is marked as 'beforefieldinit'.
			static CommonlyUsedContentSamples()
			{
			}

			// Token: 0x04004779 RID: 18297
			public static int TeamDyeShaderIndex;

			// Token: 0x0400477A RID: 18298
			public static int ColorOnlyShaderIndex;
		}

		// Token: 0x020005BF RID: 1471
		public static class CreativeHelper
		{
			// Token: 0x06003523 RID: 13603 RVA: 0x0020ADD0 File Offset: 0x00208FD0
			public static ContentSamples.CreativeHelper.ItemGroup GetItemGroup(Item item, [Out] int orderInGroup)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				if (4410 == 0)
				{
				}
				int num2 = 720;
				int num3 = 710;
				if (num2 == 0)
				{
				}
				int num4;
				if (num2 != 0)
				{
					if (num2 == 0)
					{
					}
					if (num3 == 0)
					{
						if (num3 == 0)
						{
						}
						num4 = 50;
						if (num4 != 0)
						{
							goto IL_011D;
						}
					}
				}
				if (num4 == 0)
				{
				}
				int num5 = 10;
				int num6 = 5;
				if (20 == 0)
				{
				}
				IL_011D:
				int num7 = 40;
				if (num7 == 0)
				{
				}
				if (num5 == 0)
				{
				}
				int num8;
				if (num5 != 0)
				{
					if (num7 == 0)
					{
						goto IL_017A;
					}
					num8 = 20;
					if (num8 != 0)
					{
						if (num5 == 0)
						{
						}
						if (num8 != 0)
						{
						}
					}
				}
				int num9 = 4870;
				if (num8 == 0)
				{
					goto IL_01C4;
				}
				if (num9 == 0)
				{
				}
				if (num6 == 0)
				{
					goto IL_01B1;
				}
				IL_017A:
				if (19 == 0)
				{
					goto IL_01B9;
				}
				if (72 != 0 && 40 != 0)
				{
					if (50 == 0 || 80 == 0 || 70 == 0)
					{
						goto IL_01B9;
					}
					int num10 = 30;
					if (num10 == 0 || num10 == 0)
					{
						goto IL_01B9;
					}
				}
				IL_01B1:
				if (num9 != 0)
				{
				}
				IL_01B9:
				if (num9 == 0)
				{
				}
				IL_01C4:
				int num11;
				if (num9 != 0)
				{
					num11 = 34464;
				}
				int num12;
				if (num11 != 0)
				{
					num12 = 34464;
				}
				if (num12 != 0)
				{
				}
				int num13 = true.ToInt();
				int num14 = true.ToInt();
				if (62144 != 0)
				{
				}
				if (2 == 0)
				{
				}
				int num15 = 1;
				if (num15 != 0)
				{
				}
				int num16;
				if (num15 != 0)
				{
					num16 = 10;
				}
				if (num16 != 0)
				{
				}
				if (num16 != 0)
				{
				}
				if (num16 != 0)
				{
					return;
				}
			}

			// Token: 0x06003524 RID: 13604 RVA: 0x0020B084 File Offset: 0x00209284
			public static void SetCreativeMenuOrder()
			{
			}

			// Token: 0x06003525 RID: 13605 RVA: 0x0020B100 File Offset: 0x00209300
			public static bool ShouldRemoveFromList(Item item)
			{
				/*
An exception occurred when decompiling this method (06003525)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.ID.ContentSamples/CreativeHelper::ShouldRemoveFromList(Terraria.Item)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}

			// Token: 0x06003526 RID: 13606 RVA: 0x0020B110 File Offset: 0x00209310
			// Note: this type is marked as 'beforefieldinit'.
			static CreativeHelper()
			{
			}

			// Token: 0x0400477B RID: 18299
			private static List<int> _manualEventItemsOrder;

			// Token: 0x0400477C RID: 18300
			private static List<int> _manualBossSpawnItemsOrder;

			// Token: 0x0400477D RID: 18301
			public static List<int> _manualCraftingStations;

			// Token: 0x0400477E RID: 18302
			private static List<int> _manualGolfItemsOrder;

			// Token: 0x020005C0 RID: 1472
			public enum ItemGroup
			{
				// Token: 0x04004780 RID: 18304
				Coin = 10,
				// Token: 0x04004781 RID: 18305
				CraftingObjects,
				// Token: 0x04004782 RID: 18306
				Torches = 20,
				// Token: 0x04004783 RID: 18307
				Glowsticks = 25,
				// Token: 0x04004784 RID: 18308
				Wood = 30,
				// Token: 0x04004785 RID: 18309
				Bombs = 40,
				// Token: 0x04004786 RID: 18310
				LifePotions = 50,
				// Token: 0x04004787 RID: 18311
				ManaPotions,
				// Token: 0x04004788 RID: 18312
				BuffPotion,
				// Token: 0x04004789 RID: 18313
				Flask,
				// Token: 0x0400478A RID: 18314
				Food,
				// Token: 0x0400478B RID: 18315
				Crates = 60,
				// Token: 0x0400478C RID: 18316
				BossBags = 70,
				// Token: 0x0400478D RID: 18317
				GoodieBags = 80,
				// Token: 0x0400478E RID: 18318
				AlchemyPlants = 83,
				// Token: 0x0400478F RID: 18319
				AlchemySeeds,
				// Token: 0x04004790 RID: 18320
				DyeMaterial = 87,
				// Token: 0x04004791 RID: 18321
				BossItem = 90,
				// Token: 0x04004792 RID: 18322
				EventItem,
				// Token: 0x04004793 RID: 18323
				ConsumableThatDoesNotDamage = 94,
				// Token: 0x04004794 RID: 18324
				Solutions,
				// Token: 0x04004795 RID: 18325
				Ammo,
				// Token: 0x04004796 RID: 18326
				ConsumableThatDamages,
				// Token: 0x04004797 RID: 18327
				PlacableObjects = 100,
				// Token: 0x04004798 RID: 18328
				Blocks = 120,
				// Token: 0x04004799 RID: 18329
				Wands = 130,
				// Token: 0x0400479A RID: 18330
				Rope = 140,
				// Token: 0x0400479B RID: 18331
				Walls = 150,
				// Token: 0x0400479C RID: 18332
				Wiring = 200,
				// Token: 0x0400479D RID: 18333
				Pickaxe = 500,
				// Token: 0x0400479E RID: 18334
				Axe = 510,
				// Token: 0x0400479F RID: 18335
				Hammer = 520,
				// Token: 0x040047A0 RID: 18336
				MeleeWeapon = 530,
				// Token: 0x040047A1 RID: 18337
				RangedWeapon = 540,
				// Token: 0x040047A2 RID: 18338
				MagicWeapon = 550,
				// Token: 0x040047A3 RID: 18339
				SummonWeapon = 560,
				// Token: 0x040047A4 RID: 18340
				Headgear = 600,
				// Token: 0x040047A5 RID: 18341
				Torso = 610,
				// Token: 0x040047A6 RID: 18342
				Pants = 620,
				// Token: 0x040047A7 RID: 18343
				Accessories = 630,
				// Token: 0x040047A8 RID: 18344
				Hook = 700,
				// Token: 0x040047A9 RID: 18345
				Mount = 710,
				// Token: 0x040047AA RID: 18346
				Minecart = 720,
				// Token: 0x040047AB RID: 18347
				VanityPet = 800,
				// Token: 0x040047AC RID: 18348
				LightPet = 810,
				// Token: 0x040047AD RID: 18349
				Golf = 900,
				// Token: 0x040047AE RID: 18350
				BossSpawners,
				// Token: 0x040047AF RID: 18351
				Dye = 910,
				// Token: 0x040047B0 RID: 18352
				HairDye = 920,
				// Token: 0x040047B1 RID: 18353
				Paint = 930,
				// Token: 0x040047B2 RID: 18354
				FishingRods = 1000,
				// Token: 0x040047B3 RID: 18355
				FishingQuestFish = 1010,
				// Token: 0x040047B4 RID: 18356
				Fish = 1015,
				// Token: 0x040047B5 RID: 18357
				FishingBait = 1020,
				// Token: 0x040047B6 RID: 18358
				Critters = 1030,
				// Token: 0x040047B7 RID: 18359
				Keys = 2000,
				// Token: 0x040047B8 RID: 18360
				RemainingUseItems = 5000,
				// Token: 0x040047B9 RID: 18361
				Material = 10000,
				// Token: 0x040047BA RID: 18362
				EverythingElse = 11000
			}

			// Token: 0x020005C1 RID: 1473
			public struct ItemGroupAndOrderInGroup
			{
				// Token: 0x06003527 RID: 13607 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public ItemGroupAndOrderInGroup(Item item)
				{
				}

				// Token: 0x040047BB RID: 18363
				public int ItemType;

				// Token: 0x040047BC RID: 18364
				public ContentSamples.CreativeHelper.ItemGroup Group;

				// Token: 0x040047BD RID: 18365
				public int OrderInGroup;
			}

			// Token: 0x020005C2 RID: 1474
			[CompilerGenerated]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x06003528 RID: 13608 RVA: 0x00003BB6 File Offset: 0x00001DB6
				// Note: this type is marked as 'beforefieldinit'.
				static <>c()
				{
				}

				// Token: 0x06003529 RID: 13609 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c()
				{
				}

				// Token: 0x0600352A RID: 13610 RVA: 0x0020B194 File Offset: 0x00209394
				internal ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup <SetCreativeMenuOrder>b__7_0(Item x)
				{
					return default(ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup);
				}

				// Token: 0x0600352B RID: 13611 RVA: 0x0020B1AC File Offset: 0x002093AC
				internal ContentSamples.CreativeHelper.ItemGroup <SetCreativeMenuOrder>b__7_1(ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup x)
				{
					return (ContentSamples.CreativeHelper.ItemGroup)0;
				}

				// Token: 0x0600352C RID: 13612 RVA: 0x0020B1C4 File Offset: 0x002093C4
				internal int <SetCreativeMenuOrder>b__7_2(IGrouping<ContentSamples.CreativeHelper.ItemGroup, ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup> group)
				{
					return 0;
				}

				// Token: 0x0600352D RID: 13613 RVA: 0x00003B83 File Offset: 0x00001D83
				internal IEnumerable<ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup> <SetCreativeMenuOrder>b__7_3(IGrouping<ContentSamples.CreativeHelper.ItemGroup, ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup> group)
				{
					return null;
				}

				// Token: 0x040047BE RID: 18366
				public static readonly ContentSamples.CreativeHelper.<>c <>9;

				// Token: 0x040047BF RID: 18367
				public static Func<Item, ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup> <>9__7_0;

				// Token: 0x040047C0 RID: 18368
				public static Func<ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup, ContentSamples.CreativeHelper.ItemGroup> <>9__7_1;

				// Token: 0x040047C1 RID: 18369
				public static Func<IGrouping<ContentSamples.CreativeHelper.ItemGroup, ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup>, int> <>9__7_2;

				// Token: 0x040047C2 RID: 18370
				public static Func<IGrouping<ContentSamples.CreativeHelper.ItemGroup, ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup>, IEnumerable<ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup>> <>9__7_3;
			}
		}

		// Token: 0x020005C3 RID: 1475
		public static class BestiaryHelper
		{
			// Token: 0x0600352E RID: 13614 RVA: 0x0020B1DC File Offset: 0x002093DC
			public static List<KeyValuePair<int, NPC>> GetSortedBestiaryEntriesList(BestiaryDatabase database)
			{
				List<IBestiaryInfoElement> commonInfoElementsForFilters = BestiaryDatabaseNPCsPopulator.CommonTags.GetCommonInfoElementsForFilters();
				if (!true)
				{
				}
				IOrderedEnumerable orderedEnumerable;
				if (orderedEnumerable == null)
				{
				}
				return Enumerable.ToList(orderedEnumerable);
			}

			// Token: 0x0600352F RID: 13615 RVA: 0x0020B200 File Offset: 0x00209400
			public static int GetLowestBiomeGroupIndex(NPC npc, BestiaryDatabase database, List<IBestiaryInfoElement> commonElements)
			{
				/*
An exception occurred when decompiling this method (0600352F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.ID.ContentSamples/BestiaryHelper::GetLowestBiomeGroupIndex(Terraria.NPC,Terraria.GameContent.Bestiary.BestiaryDatabase,System.Collections.Generic.List`1<Terraria.GameContent.Bestiary.IBestiaryInfoElement>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.List`1<class Terraria.GameContent.Bestiary.IBestiaryInfoElement>(var_1_06, ldfld:class [mscorlib]System.Collections.Generic.List`1<class Terraria.GameContent.Bestiary.IBestiaryInfoElement>(BestiaryEntry::<Info>k__BackingField, ldloc:BestiaryEntry(var_0)))
	stloc:class [mscorlib]System.Collections.Generic.List`1<class Terraria.GameContent.Bestiary.IBestiaryEntryFilter>(var_2_0D, ldfld:class [mscorlib]System.Collections.Generic.List`1<class Terraria.GameContent.Bestiary.IBestiaryEntryFilter>(BestiaryDatabase::_filters, ldloc:BestiaryDatabase(database)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}

			// Token: 0x06003530 RID: 13616 RVA: 0x0020B21C File Offset: 0x0020941C
			public static bool ShouldHideBestiaryEntry(NPC npc)
			{
				if (!true)
				{
					return;
				}
			}

			// Token: 0x06003531 RID: 13617 RVA: 0x000021DB File Offset: 0x000003DB
			public static float GetBestiaryPowerLevel(NPC npc)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06003532 RID: 13618 RVA: 0x0020B230 File Offset: 0x00209430
			public static int GetBestiaryTownPriority(NPC npc)
			{
				/*
An exception occurred when decompiling this method (06003532)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.ID.ContentSamples/BestiaryHelper::GetBestiaryTownPriority(Terraria.NPC)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}

			// Token: 0x06003533 RID: 13619 RVA: 0x0020B240 File Offset: 0x00209440
			public static int GetBestiaryNormalGoldCritterPriority(NPC npc)
			{
				/*
An exception occurred when decompiling this method (06003533)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.ID.ContentSamples/BestiaryHelper::GetBestiaryNormalGoldCritterPriority(Terraria.NPC)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}

			// Token: 0x06003534 RID: 13620 RVA: 0x0020B250 File Offset: 0x00209450
			public static int GetBestiaryBossPriority(NPC npc)
			{
				if ("AnyAtomicType" == null)
				{
				}
				return 41730048;
			}

			// Token: 0x06003535 RID: 13621 RVA: 0x0020B26C File Offset: 0x0020946C
			public static int GetBestiaryStarsPriority(NPC npc)
			{
				/*
An exception occurred when decompiling this method (06003535)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.ID.ContentSamples/BestiaryHelper::GetBestiaryStarsPriority(Terraria.NPC)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}

			// Token: 0x020005C4 RID: 1476
			[CompilerGenerated]
			private sealed class <>c__DisplayClass0_0
			{
				// Token: 0x06003536 RID: 13622 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c__DisplayClass0_0()
				{
				}

				// Token: 0x06003537 RID: 13623 RVA: 0x0020B27C File Offset: 0x0020947C
				internal int <GetSortedBestiaryEntriesList>b__6(KeyValuePair<int, NPC> x)
				{
					return 0;
				}

				// Token: 0x040047C3 RID: 18371
				public BestiaryDatabase database;

				// Token: 0x040047C4 RID: 18372
				public List<IBestiaryInfoElement> commonFilters;
			}

			// Token: 0x020005C5 RID: 1477
			[CompilerGenerated]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x06003538 RID: 13624 RVA: 0x00003BB6 File Offset: 0x00001DB6
				// Note: this type is marked as 'beforefieldinit'.
				static <>c()
				{
				}

				// Token: 0x06003539 RID: 13625 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c()
				{
				}

				// Token: 0x0600353A RID: 13626 RVA: 0x0020B294 File Offset: 0x00209494
				internal int <GetSortedBestiaryEntriesList>b__0_0(KeyValuePair<int, NPC> x)
				{
					return 0;
				}

				// Token: 0x0600353B RID: 13627 RVA: 0x0020B2AC File Offset: 0x002094AC
				internal bool <GetSortedBestiaryEntriesList>b__0_1(KeyValuePair<int, NPC> x)
				{
					return default(bool);
				}

				// Token: 0x0600353C RID: 13628 RVA: 0x0020B2C4 File Offset: 0x002094C4
				internal int <GetSortedBestiaryEntriesList>b__0_2(KeyValuePair<int, NPC> x)
				{
					return 0;
				}

				// Token: 0x0600353D RID: 13629 RVA: 0x0020B2DC File Offset: 0x002094DC
				internal bool <GetSortedBestiaryEntriesList>b__0_3(KeyValuePair<int, NPC> x)
				{
					return default(bool);
				}

				// Token: 0x0600353E RID: 13630 RVA: 0x0020B2F4 File Offset: 0x002094F4
				internal int <GetSortedBestiaryEntriesList>b__0_4(KeyValuePair<int, NPC> x)
				{
					return 0;
				}

				// Token: 0x0600353F RID: 13631 RVA: 0x0020B30C File Offset: 0x0020950C
				internal bool <GetSortedBestiaryEntriesList>b__0_5(KeyValuePair<int, NPC> x)
				{
					return default(bool);
				}

				// Token: 0x06003540 RID: 13632 RVA: 0x0020B324 File Offset: 0x00209524
				internal int <GetSortedBestiaryEntriesList>b__0_7(KeyValuePair<int, NPC> x)
				{
					return 0;
				}

				// Token: 0x06003541 RID: 13633 RVA: 0x0020B33C File Offset: 0x0020953C
				internal float <GetSortedBestiaryEntriesList>b__0_8(KeyValuePair<int, NPC> x)
				{
					return 0f;
				}

				// Token: 0x06003542 RID: 13634 RVA: 0x0020B354 File Offset: 0x00209554
				internal int <GetSortedBestiaryEntriesList>b__0_9(KeyValuePair<int, NPC> x)
				{
					return 0;
				}

				// Token: 0x06003543 RID: 13635 RVA: 0x0020B36C File Offset: 0x0020956C
				internal bool <GetSortedBestiaryEntriesList>b__0_10(KeyValuePair<int, NPC> x)
				{
					return default(bool);
				}

				// Token: 0x040047C5 RID: 18373
				public static readonly ContentSamples.BestiaryHelper.<>c <>9;

				// Token: 0x040047C6 RID: 18374
				public static Func<KeyValuePair<int, NPC>, int> <>9__0_0;

				// Token: 0x040047C7 RID: 18375
				public static Func<KeyValuePair<int, NPC>, bool> <>9__0_1;

				// Token: 0x040047C8 RID: 18376
				public static Func<KeyValuePair<int, NPC>, int> <>9__0_2;

				// Token: 0x040047C9 RID: 18377
				public static Func<KeyValuePair<int, NPC>, bool> <>9__0_3;

				// Token: 0x040047CA RID: 18378
				public static Func<KeyValuePair<int, NPC>, int> <>9__0_4;

				// Token: 0x040047CB RID: 18379
				public static Func<KeyValuePair<int, NPC>, bool> <>9__0_5;

				// Token: 0x040047CC RID: 18380
				public static Func<KeyValuePair<int, NPC>, int> <>9__0_7;

				// Token: 0x040047CD RID: 18381
				public static Func<KeyValuePair<int, NPC>, float> <>9__0_8;

				// Token: 0x040047CE RID: 18382
				public static Func<KeyValuePair<int, NPC>, int> <>9__0_9;

				// Token: 0x040047CF RID: 18383
				public static Predicate<KeyValuePair<int, NPC>> <>9__0_10;
			}
		}
	}
}
