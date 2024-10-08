﻿using System;

namespace Terraria.IO
{
	// Token: 0x0200056A RID: 1386
	public static class ItemConversion_OldMobile
	{
		// Token: 0x060033CA RID: 13258 RVA: 0x00200704 File Offset: 0x001FE904
		public static bool ModifyItem(short itemId, short itemStack, byte prefix, bool chestConversion = false)
		{
			/*
An exception occurred when decompiling this method (060033CA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.IO.ItemConversion_OldMobile::ModifyItem(System.Int16,System.Int16,System.Byte,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_02, ldc.i4:int32(60))
	stfld:int16(int16::m_value, ldloc:int16[exp:int16&](itemStack), ldloc:int32[exp:int16](var_0_02))
	call:void(ItemConversion_OldMobile::GetCoinItem, ldc.i4:int32(0), ldloc:int16(itemId), ldloc:int16(itemId))
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

		// Token: 0x060033CB RID: 13259 RVA: 0x00200740 File Offset: 0x001FE940
		private static void GetCoinItem(int coinValue, short itemId, short itemStack)
		{
			int num = 74;
			itemId.m_value = (short)num;
		}

		// Token: 0x060033CC RID: 13260 RVA: 0x002007AC File Offset: 0x001FE9AC
		public static bool ModifyBodySlot(int slot)
		{
		}

		// Token: 0x060033CD RID: 13261 RVA: 0x002007C0 File Offset: 0x001FE9C0
		public static bool ModifyHeadSlot(int slot)
		{
		}

		// Token: 0x060033CE RID: 13262 RVA: 0x002007D4 File Offset: 0x001FE9D4
		public static bool ModifyLegSlot(int slot)
		{
		}

		// Token: 0x04003C6B RID: 15467
		public static int CompensatedCurrency;

		// Token: 0x0200056B RID: 1387
		private enum ARMOR_BODY_SLOTS
		{
			// Token: 0x04003C6D RID: 15469
			COPPER_CHAINMAIL = 1,
			// Token: 0x04003C6E RID: 15470
			IRON_CHAINMAIL,
			// Token: 0x04003C6F RID: 15471
			SILVER_CHAINMAIL,
			// Token: 0x04003C70 RID: 15472
			GOLD_CHAINMAIL,
			// Token: 0x04003C71 RID: 15473
			SHADOW_SCALEMAIL,
			// Token: 0x04003C72 RID: 15474
			METEOR_SUIT,
			// Token: 0x04003C73 RID: 15475
			NECRO_BREASTPLATE,
			// Token: 0x04003C74 RID: 15476
			JUNGLE_SHIRT,
			// Token: 0x04003C75 RID: 15477
			MOLTEN_BREASTPLATE,
			// Token: 0x04003C76 RID: 15478
			TUXEDO_SHIRT,
			// Token: 0x04003C77 RID: 15479
			PLUMBERS_SHIRT,
			// Token: 0x04003C78 RID: 15480
			HEROS_SHIRT,
			// Token: 0x04003C79 RID: 15481
			ARCHAEOLOGISTS_JACKET,
			// Token: 0x04003C7A RID: 15482
			NINJA_SHIRT,
			// Token: 0x04003C7B RID: 15483
			ROBE,
			// Token: 0x04003C7C RID: 15484
			THE_DOCTORS_SHIRT,
			// Token: 0x04003C7D RID: 15485
			COBALT_BREASTPLATE,
			// Token: 0x04003C7E RID: 15486
			MYTHRIL_CHAINMAIL,
			// Token: 0x04003C7F RID: 15487
			ADAMANTITE_BREASTPLATE,
			// Token: 0x04003C80 RID: 15488
			MINING_SHIRT,
			// Token: 0x04003C81 RID: 15489
			WEREWOLF,
			// Token: 0x04003C82 RID: 15490
			MERMAN,
			// Token: 0x04003C83 RID: 15491
			CLOWN_SHIRT,
			// Token: 0x04003C84 RID: 15492
			HALLOWED_PLATE_MAIL,
			// Token: 0x04003C85 RID: 15493
			SANTA_SHIRT,
			// Token: 0x04003C86 RID: 15494
			REDS_BREASTPLATE,
			// Token: 0x04003C87 RID: 15495
			FROST_BREASTPLATE,
			// Token: 0x04003C88 RID: 15496
			TIN_CHAINMAIL,
			// Token: 0x04003C89 RID: 15497
			LEAD_CHAINMAIL,
			// Token: 0x04003C8A RID: 15498
			TUNGSTEN_CHAINMAIL,
			// Token: 0x04003C8B RID: 15499
			PLATINUM_CHAINMAIL,
			// Token: 0x04003C8C RID: 15500
			WOOD_BREASTPLATE,
			// Token: 0x04003C8D RID: 15501
			EBONWOOD_BREASTPLATE,
			// Token: 0x04003C8E RID: 15502
			RICH_MAHOGANY_BREASTPLATE,
			// Token: 0x04003C8F RID: 15503
			PEARLWOOD_BREASTPLATE,
			// Token: 0x04003C90 RID: 15504
			RUNE_ROBE,
			// Token: 0x04003C91 RID: 15505
			CRIMSON_SCALEMAIL,
			// Token: 0x04003C92 RID: 15506
			ESKIMO_COAT,
			// Token: 0x04003C93 RID: 15507
			STEAMPUNK_SHIRT,
			// Token: 0x04003C94 RID: 15508
			BEE_SHIRT,
			// Token: 0x04003C95 RID: 15509
			PRINCESS_DRESS,
			// Token: 0x04003C96 RID: 15510
			PHARAOHS_ROBE,
			// Token: 0x04003C97 RID: 15511
			MUMMY_SHIRT,
			// Token: 0x04003C98 RID: 15512
			COWBOY_JACKET,
			// Token: 0x04003C99 RID: 15513
			PIRATE_SHIRT,
			// Token: 0x04003C9A RID: 15514
			CACTUS_BREASTPLATE,
			// Token: 0x04003C9B RID: 15515
			SHADEWOOD_BREASTPLATE,
			// Token: 0x04003C9C RID: 15516
			ANCIENT_SHADOW_SCALEMAIL,
			// Token: 0x04003C9D RID: 15517
			ANCIENT_COBALT_BREASTPLATE,
			// Token: 0x04003C9E RID: 15518
			PINK_ESKIMO_COAT,
			// Token: 0x04003C9F RID: 15519
			CHLOROPHYTE_PLATE_MAIL,
			// Token: 0x04003CA0 RID: 15520
			RAIN_COAT,
			// Token: 0x04003CA1 RID: 15521
			TIKI_SHIRT,
			// Token: 0x04003CA2 RID: 15522
			PALLADIUM_BREASTPLATE,
			// Token: 0x04003CA3 RID: 15523
			ORICHALCUM_BREASTPLATE,
			// Token: 0x04003CA4 RID: 15524
			TITANIUM_BREASTPLATE,
			// Token: 0x04003CA5 RID: 15525
			SAILOR_SHIRT,
			// Token: 0x04003CA6 RID: 15526
			AMETHYST_ROBE,
			// Token: 0x04003CA7 RID: 15527
			TOPAZ_ROBE,
			// Token: 0x04003CA8 RID: 15528
			SAPPHIRE_ROBE,
			// Token: 0x04003CA9 RID: 15529
			EMERALD_ROBE,
			// Token: 0x04003CAA RID: 15530
			RUBY_ROBE,
			// Token: 0x04003CAB RID: 15531
			DIAMOND_ROBE,
			// Token: 0x04003CAC RID: 15532
			WHITE_TUXEDO_SHIRT,
			// Token: 0x04003CAD RID: 15533
			TURTLE_SCALE_MAIL,
			// Token: 0x04003CAE RID: 15534
			SPECTRE_ROBE,
			// Token: 0x04003CAF RID: 15535
			SHROOMITE_BREASTPLATE,
			// Token: 0x04003CB0 RID: 15536
			CENXS_BREASTPLATE,
			// Token: 0x04003CB1 RID: 15537
			CROWNOS_BREASTPLATE,
			// Token: 0x04003CB2 RID: 15538
			WILLS_BREASTPLATE,
			// Token: 0x04003CB3 RID: 15539
			JIMS_BREASTPLATE,
			// Token: 0x04003CB4 RID: 15540
			AARONS_BREASTPLATE,
			// Token: 0x04003CB5 RID: 15541
			D_TOWNS_BREASTPLATE,
			// Token: 0x04003CB6 RID: 15542
			CENXS_DRESS,
			// Token: 0x04003CB7 RID: 15543
			PUMPKIN_BREASTPLATE,
			// Token: 0x04003CB8 RID: 15544
			NURSE_SHIRT,
			// Token: 0x04003CB9 RID: 15545
			DYE_TRADER_ROBE,
			// Token: 0x04003CBA RID: 15546
			CYBORG_SHIRT,
			// Token: 0x04003CBB RID: 15547
			CREEPER_SHIRT,
			// Token: 0x04003CBC RID: 15548
			CAT_SHIRT,
			// Token: 0x04003CBD RID: 15549
			GHOST_SHIRT,
			// Token: 0x04003CBE RID: 15550
			PUMPKIN_SHIRT,
			// Token: 0x04003CBF RID: 15551
			ROBOT_SHIRT,
			// Token: 0x04003CC0 RID: 15552
			UNICORN_SHIRT,
			// Token: 0x04003CC1 RID: 15553
			VAMPIRE_SHIRT,
			// Token: 0x04003CC2 RID: 15554
			LEPRECHAUN_SHIRT,
			// Token: 0x04003CC3 RID: 15555
			PIXIE_SHIRT,
			// Token: 0x04003CC4 RID: 15556
			PRINCESS_DRESS_HALLOWEEN,
			// Token: 0x04003CC5 RID: 15557
			WITCH_DRESS,
			// Token: 0x04003CC6 RID: 15558
			BRIDE_OF_FRANKENSTEIN_DRESS,
			// Token: 0x04003CC7 RID: 15559
			KARATE_TORTOISE_SHIRT,
			// Token: 0x04003CC8 RID: 15560
			SCARECROW_SHIRT,
			// Token: 0x04003CC9 RID: 15561
			REAPER_ROBE,
			// Token: 0x04003CCA RID: 15562
			FOX_SHIRT,
			// Token: 0x04003CCB RID: 15563
			SPOOKY_BREASTPLATE,
			// Token: 0x04003CCC RID: 15564
			SPACE_CREATURE_SHIRT,
			// Token: 0x04003CCD RID: 15565
			WOLF_SHIRT,
			// Token: 0x04003CCE RID: 15566
			TREASURE_HUNTER_SHIRT,
			// Token: 0x04003CCF RID: 15567
			DRYAD_COVERINGS,
			// Token: 0x04003CD0 RID: 15568
			DRAGON_BREASTPLATE,
			// Token: 0x04003CD1 RID: 15569
			TITAN_MAIL,
			// Token: 0x04003CD2 RID: 15570
			SPECTRAL_ARMOR,
			// Token: 0x04003CD3 RID: 15571
			FABULOUS_TUTU,
			// Token: 0x04003CD4 RID: 15572
			GEORGES_TUXEDO_SHIRT,
			// Token: 0x04003CD5 RID: 15573
			DIRNDL,
			// Token: 0x04003CD6 RID: 15574
			TIROLER,
			// Token: 0x04003CD7 RID: 15575
			MRS_CLAUSE_SHIRT,
			// Token: 0x04003CD8 RID: 15576
			TREE_SHIRT,
			// Token: 0x04003CD9 RID: 15577
			PARKA_COAT,
			// Token: 0x04003CDA RID: 15578
			UGLY_SWEATER,
			// Token: 0x04003CDB RID: 15579
			ELF_SHIRT,
			// Token: 0x04003CDC RID: 15580
			BEETLE_SCALE_MAIL,
			// Token: 0x04003CDD RID: 15581
			BEETLE_SHELL,
			// Token: 0x04003CDE RID: 15582
			GI,
			// Token: 0x04003CDF RID: 15583
			KIMONO,
			// Token: 0x04003CE0 RID: 15584
			GYPSY_ROBE,
			// Token: 0x04003CE1 RID: 15585
			BEE_BREASTPLATE,
			// Token: 0x04003CE2 RID: 15586
			ANGLER_VEST,
			// Token: 0x04003CE3 RID: 15587
			SPIDER_BREASTPLATE,
			// Token: 0x04003CE4 RID: 15588
			MERMAID_ADORNMENT,
			// Token: 0x04003CE5 RID: 15589
			FISH_COSTUME_SHIRT,
			// Token: 0x04003CE6 RID: 15590
			BOREAL_WOOD_BREASTPLATE,
			// Token: 0x04003CE7 RID: 15591
			PALM_WOOD_BREASTPLATE,
			// Token: 0x04003CE8 RID: 15592
			MYTHICALROBE
		}

		// Token: 0x0200056C RID: 1388
		private enum ARMOR_HEAD_SLOTS
		{
			// Token: 0x04003CEA RID: 15594
			COPPER_HELMET = 1,
			// Token: 0x04003CEB RID: 15595
			IRON_HELMET,
			// Token: 0x04003CEC RID: 15596
			SILVER_HELMET,
			// Token: 0x04003CED RID: 15597
			GOLD_HELMET,
			// Token: 0x04003CEE RID: 15598
			SHADOW_HELMET,
			// Token: 0x04003CEF RID: 15599
			METEOR_HELMET,
			// Token: 0x04003CF0 RID: 15600
			NECRO_HELMET,
			// Token: 0x04003CF1 RID: 15601
			JUNGLE_HAT,
			// Token: 0x04003CF2 RID: 15602
			MOLTEN_HELMET,
			// Token: 0x04003CF3 RID: 15603
			GOGGLES,
			// Token: 0x04003CF4 RID: 15604
			MINING_HELMET,
			// Token: 0x04003CF5 RID: 15605
			SUNGLASSES,
			// Token: 0x04003CF6 RID: 15606
			EMPTY_BUCKET,
			// Token: 0x04003CF7 RID: 15607
			WIZARD_HAT,
			// Token: 0x04003CF8 RID: 15608
			TOP_HAT,
			// Token: 0x04003CF9 RID: 15609
			SUMMER_HAT,
			// Token: 0x04003CFA RID: 15610
			BUNNY_HOOD,
			// Token: 0x04003CFB RID: 15611
			PLUMBERS_HAT,
			// Token: 0x04003CFC RID: 15612
			HEROS_HAT,
			// Token: 0x04003CFD RID: 15613
			FISH_BOWL,
			// Token: 0x04003CFE RID: 15614
			ARCHAEOLOGISTS_HAT,
			// Token: 0x04003CFF RID: 15615
			NINJA_HOOD,
			// Token: 0x04003D00 RID: 15616
			JUNGLE_ROSE,
			// Token: 0x04003D01 RID: 15617
			RED_HAT,
			// Token: 0x04003D02 RID: 15618
			ROBOT_HAT,
			// Token: 0x04003D03 RID: 15619
			GOLD_CROWN,
			// Token: 0x04003D04 RID: 15620
			DIVING_HELMET,
			// Token: 0x04003D05 RID: 15621
			MIME_MASK,
			// Token: 0x04003D06 RID: 15622
			COBALT_HAT,
			// Token: 0x04003D07 RID: 15623
			COBALT_HELMET,
			// Token: 0x04003D08 RID: 15624
			COBALT_MASK,
			// Token: 0x04003D09 RID: 15625
			MYTHRIL_HOOD,
			// Token: 0x04003D0A RID: 15626
			MYTHRIL_HELMET,
			// Token: 0x04003D0B RID: 15627
			MYTHRIL_HAT,
			// Token: 0x04003D0C RID: 15628
			ADAMANTITE_HEADGEAR,
			// Token: 0x04003D0D RID: 15629
			ADAMANTITE_HELMET,
			// Token: 0x04003D0E RID: 15630
			ADAMANTITE_MASK,
			// Token: 0x04003D0F RID: 15631
			WEREWOLF,
			// Token: 0x04003D10 RID: 15632
			MERMAN,
			// Token: 0x04003D11 RID: 15633
			CLOWN_HAT,
			// Token: 0x04003D12 RID: 15634
			HALLOWED_HELMET,
			// Token: 0x04003D13 RID: 15635
			HALLOWED_HEADGEAR,
			// Token: 0x04003D14 RID: 15636
			HALLOWED_MASK,
			// Token: 0x04003D15 RID: 15637
			SANTA_HAT,
			// Token: 0x04003D16 RID: 15638
			REDS_HELMET,
			// Token: 0x04003D17 RID: 15639
			FROST_HELMET,
			// Token: 0x04003D18 RID: 15640
			TIN_HELMET,
			// Token: 0x04003D19 RID: 15641
			LEAD_HELMET,
			// Token: 0x04003D1A RID: 15642
			TUNGSTEN_HELMET,
			// Token: 0x04003D1B RID: 15643
			PLATINUM_HELMET,
			// Token: 0x04003D1C RID: 15644
			PLATINUM_CROWN,
			// Token: 0x04003D1D RID: 15645
			WOOD_HELMET,
			// Token: 0x04003D1E RID: 15646
			EBONWOOD_HELMET,
			// Token: 0x04003D1F RID: 15647
			RICH_MAHOGANY_HELMET,
			// Token: 0x04003D20 RID: 15648
			PEARLWOOD_HELMET,
			// Token: 0x04003D21 RID: 15649
			RUNE_HAT,
			// Token: 0x04003D22 RID: 15650
			CRIMSON_HELMET,
			// Token: 0x04003D23 RID: 15651
			ESKIMO_HOOD,
			// Token: 0x04003D24 RID: 15652
			STEAMPUNK_HAT,
			// Token: 0x04003D25 RID: 15653
			BEE_HAT,
			// Token: 0x04003D26 RID: 15654
			PHARAOHS_MASK,
			// Token: 0x04003D27 RID: 15655
			TIARA,
			// Token: 0x04003D28 RID: 15656
			GREEN_CAP,
			// Token: 0x04003D29 RID: 15657
			MUSHROOM_CAP,
			// Token: 0x04003D2A RID: 15658
			TAM_O_SHANTER,
			// Token: 0x04003D2B RID: 15659
			MUMMY_MASK,
			// Token: 0x04003D2C RID: 15660
			COWBOY_HAT,
			// Token: 0x04003D2D RID: 15661
			PIRATE_HAT,
			// Token: 0x04003D2E RID: 15662
			VIKING_HELMET,
			// Token: 0x04003D2F RID: 15663
			CACTUS_HELMET,
			// Token: 0x04003D30 RID: 15664
			SHADEWOOD_HELMET,
			// Token: 0x04003D31 RID: 15665
			ANCIENT_IRON_HELMET,
			// Token: 0x04003D32 RID: 15666
			ANCIENT_GOLD_HELMET,
			// Token: 0x04003D33 RID: 15667
			ANCIENT_SHADOW_HELMET,
			// Token: 0x04003D34 RID: 15668
			ANCIENT_NECRO_HELMET,
			// Token: 0x04003D35 RID: 15669
			ANCIENT_COBALT_HELMET,
			// Token: 0x04003D36 RID: 15670
			PINK_ESKIMO_HOOD,
			// Token: 0x04003D37 RID: 15671
			CHLOROPHYTE_MASK,
			// Token: 0x04003D38 RID: 15672
			CHLOROPHYTE_HELMET,
			// Token: 0x04003D39 RID: 15673
			CHLOROPHYTE_HEADGEAR,
			// Token: 0x04003D3A RID: 15674
			RAIN_HAT,
			// Token: 0x04003D3B RID: 15675
			TIKI_MASK,
			// Token: 0x04003D3C RID: 15676
			PALLADIUM_MASK,
			// Token: 0x04003D3D RID: 15677
			PALLADIUM_HELMET,
			// Token: 0x04003D3E RID: 15678
			PALLADIUM_HEADGEAR,
			// Token: 0x04003D3F RID: 15679
			ORICHALCUM_MASK,
			// Token: 0x04003D40 RID: 15680
			ORICHALCUM_HELMET,
			// Token: 0x04003D41 RID: 15681
			ORICHALCUM_HEADGEAR,
			// Token: 0x04003D42 RID: 15682
			TITANIUM_MASK,
			// Token: 0x04003D43 RID: 15683
			TITANIUM_HELMET,
			// Token: 0x04003D44 RID: 15684
			TITANIUM_HEADGEAR,
			// Token: 0x04003D45 RID: 15685
			UMBRELLA_HAT,
			// Token: 0x04003D46 RID: 15686
			SKULL,
			// Token: 0x04003D47 RID: 15687
			BALLA_HAT,
			// Token: 0x04003D48 RID: 15688
			GANGSTA_HAT,
			// Token: 0x04003D49 RID: 15689
			SAILOR_HAT,
			// Token: 0x04003D4A RID: 15690
			EYE_PATCH,
			// Token: 0x04003D4B RID: 15691
			SKELETRON_MASK,
			// Token: 0x04003D4C RID: 15692
			TURTLE_HELMET,
			// Token: 0x04003D4D RID: 15693
			BEANIE,
			// Token: 0x04003D4E RID: 15694
			SPECTRE_HOOD,
			// Token: 0x04003D4F RID: 15695
			SWAT_HELMET,
			// Token: 0x04003D50 RID: 15696
			SHROOMITE_HEADGEAR,
			// Token: 0x04003D51 RID: 15697
			SHROOMITE_MASK,
			// Token: 0x04003D52 RID: 15698
			SHROOMITE_HELMET,
			// Token: 0x04003D53 RID: 15699
			CENXS_TIARA,
			// Token: 0x04003D54 RID: 15700
			CROWNOS_MASK,
			// Token: 0x04003D55 RID: 15701
			WILLS_HELMET,
			// Token: 0x04003D56 RID: 15702
			JIMS_HELMET,
			// Token: 0x04003D57 RID: 15703
			AARONS_HELMET,
			// Token: 0x04003D58 RID: 15704
			D_TOWNS_HELMET,
			// Token: 0x04003D59 RID: 15705
			PUMPKIN_HELMET,
			// Token: 0x04003D5A RID: 15706
			NURSE_HAT,
			// Token: 0x04003D5B RID: 15707
			WIZARDS_HAT,
			// Token: 0x04003D5C RID: 15708
			GUY_FAWKES_MASK,
			// Token: 0x04003D5D RID: 15709
			STEAM_PUNK_GOGGLES,
			// Token: 0x04003D5E RID: 15710
			CYBORG_HELMET,
			// Token: 0x04003D5F RID: 15711
			CREEPER_MASK,
			// Token: 0x04003D60 RID: 15712
			CAT_MASK,
			// Token: 0x04003D61 RID: 15713
			GHOST_MASK,
			// Token: 0x04003D62 RID: 15714
			PUMPKIN_MASK,
			// Token: 0x04003D63 RID: 15715
			ROBOT_MASK,
			// Token: 0x04003D64 RID: 15716
			UNICORN_MASK,
			// Token: 0x04003D65 RID: 15717
			VAMPIRE_MASK,
			// Token: 0x04003D66 RID: 15718
			WITCH_HAT,
			// Token: 0x04003D67 RID: 15719
			LEPRECHAUN_HAT,
			// Token: 0x04003D68 RID: 15720
			PRINCESS_HAT_HALLOWEEN,
			// Token: 0x04003D69 RID: 15721
			BRIDE_OF_FRANKENSTEIN_MASK,
			// Token: 0x04003D6A RID: 15722
			KARATE_TORTOISE_MASK,
			// Token: 0x04003D6B RID: 15723
			SCARECROW_HAT,
			// Token: 0x04003D6C RID: 15724
			REAPER_HOOD,
			// Token: 0x04003D6D RID: 15725
			FOX_MASK,
			// Token: 0x04003D6E RID: 15726
			CAT_EARS,
			// Token: 0x04003D6F RID: 15727
			SPOOKY_HELMET,
			// Token: 0x04003D70 RID: 15728
			SPACE_CREATURE_MASK,
			// Token: 0x04003D71 RID: 15729
			WOLF_MASK,
			// Token: 0x04003D72 RID: 15730
			JACK_O_LANTERN_MASK,
			// Token: 0x04003D73 RID: 15731
			DRAGON_MASK,
			// Token: 0x04003D74 RID: 15732
			TITAN_HELMET,
			// Token: 0x04003D75 RID: 15733
			SPECTRAL_HEADGEAR,
			// Token: 0x04003D76 RID: 15734
			FABULOUS_RIBBON,
			// Token: 0x04003D77 RID: 15735
			GEORGES_HAT,
			// Token: 0x04003D78 RID: 15736
			NEWYEARS_HAT,
			// Token: 0x04003D79 RID: 15737
			DIRNDL,
			// Token: 0x04003D7A RID: 15738
			TIROLER,
			// Token: 0x04003D7B RID: 15739
			GIANT_BOW,
			// Token: 0x04003D7C RID: 15740
			REINDEER_ANTLERS,
			// Token: 0x04003D7D RID: 15741
			MRS_CLAUSE_HAT,
			// Token: 0x04003D7E RID: 15742
			PARKA_HOOD,
			// Token: 0x04003D7F RID: 15743
			TREE_MASK,
			// Token: 0x04003D80 RID: 15744
			SNOW_HAT,
			// Token: 0x04003D81 RID: 15745
			ELF_HAT,
			// Token: 0x04003D82 RID: 15746
			FEZ,
			// Token: 0x04003D83 RID: 15747
			BEETLE_HELMET,
			// Token: 0x04003D84 RID: 15748
			BRAIN_MASK,
			// Token: 0x04003D85 RID: 15749
			FLESH_MASK,
			// Token: 0x04003D86 RID: 15750
			TWIN_MASK,
			// Token: 0x04003D87 RID: 15751
			SKELETRON_PRIME_MASK,
			// Token: 0x04003D88 RID: 15752
			BEE_MASK,
			// Token: 0x04003D89 RID: 15753
			PLANTERA_MASK,
			// Token: 0x04003D8A RID: 15754
			GOLEM_MASK,
			// Token: 0x04003D8B RID: 15755
			EATER_MASK,
			// Token: 0x04003D8C RID: 15756
			EYE_MASK,
			// Token: 0x04003D8D RID: 15757
			DESTROYER_MASK,
			// Token: 0x04003D8E RID: 15758
			MAGIC_HAT,
			// Token: 0x04003D8F RID: 15759
			SPECTRE_MASK,
			// Token: 0x04003D90 RID: 15760
			PEDDLERS_HAT,
			// Token: 0x04003D91 RID: 15761
			BEE_HEADGEAR,
			// Token: 0x04003D92 RID: 15762
			ANGLER_HAT,
			// Token: 0x04003D93 RID: 15763
			SPIDER_MASK,
			// Token: 0x04003D94 RID: 15764
			SEASHELL_HAIRPIN,
			// Token: 0x04003D95 RID: 15765
			KING_SLIME_MASK,
			// Token: 0x04003D96 RID: 15766
			FISH_COSTUME_MASK,
			// Token: 0x04003D97 RID: 15767
			BOREAL_WOOD_HELMET,
			// Token: 0x04003D98 RID: 15768
			PALM_WOOD_HELMET,
			// Token: 0x04003D99 RID: 15769
			DUKE_FISHRON_MASK,
			// Token: 0x04003D9A RID: 15770
			MYTHICAL_LION_MASK
		}

		// Token: 0x0200056D RID: 1389
		private enum ARMOR_LEG_SLOTS
		{
			// Token: 0x04003D9C RID: 15772
			COPPER_GREAVES = 1,
			// Token: 0x04003D9D RID: 15773
			IRON_GREAVES,
			// Token: 0x04003D9E RID: 15774
			SILVER_GREAVES,
			// Token: 0x04003D9F RID: 15775
			GOLD_GREAVES,
			// Token: 0x04003DA0 RID: 15776
			SHADOW_GREAVES,
			// Token: 0x04003DA1 RID: 15777
			METEOR_LEGGINGS,
			// Token: 0x04003DA2 RID: 15778
			NECRO_GREAVES,
			// Token: 0x04003DA3 RID: 15779
			JUNGLE_PANTS,
			// Token: 0x04003DA4 RID: 15780
			MOLTEN_GREAVES,
			// Token: 0x04003DA5 RID: 15781
			TUXEDO_PANTS,
			// Token: 0x04003DA6 RID: 15782
			PLUMBERS_PANTS,
			// Token: 0x04003DA7 RID: 15783
			HEROS_PANTS,
			// Token: 0x04003DA8 RID: 15784
			ARCHAEOLOGISTS_PANTS,
			// Token: 0x04003DA9 RID: 15785
			NINJA_PANTS,
			// Token: 0x04003DAA RID: 15786
			THE_DOCTORS_PANTS,
			// Token: 0x04003DAB RID: 15787
			COBALT_LEGGINGS,
			// Token: 0x04003DAC RID: 15788
			MYTHRIL_GREAVES,
			// Token: 0x04003DAD RID: 15789
			ADAMANTITE_LEGGINGS,
			// Token: 0x04003DAE RID: 15790
			MINING_PANTS,
			// Token: 0x04003DAF RID: 15791
			WEREWOLF,
			// Token: 0x04003DB0 RID: 15792
			MERMAN,
			// Token: 0x04003DB1 RID: 15793
			CLOWN_PANTS,
			// Token: 0x04003DB2 RID: 15794
			HALLOWED_GREAVES,
			// Token: 0x04003DB3 RID: 15795
			SANTA_PANTS,
			// Token: 0x04003DB4 RID: 15796
			REDS_LEGGINGS,
			// Token: 0x04003DB5 RID: 15797
			FROST_LEGGINGS,
			// Token: 0x04003DB6 RID: 15798
			TIN_GREAVES,
			// Token: 0x04003DB7 RID: 15799
			LEAD_GREAVES,
			// Token: 0x04003DB8 RID: 15800
			TUNGSTEN_GREAVES,
			// Token: 0x04003DB9 RID: 15801
			PLATINUM_GREAVES,
			// Token: 0x04003DBA RID: 15802
			WOOD_GREAVES,
			// Token: 0x04003DBB RID: 15803
			EBONWOOD_GREAVES,
			// Token: 0x04003DBC RID: 15804
			RICH_MAHOGANY_GREAVES,
			// Token: 0x04003DBD RID: 15805
			PEARLWOOD_GREAVES,
			// Token: 0x04003DBE RID: 15806
			CRIMSON_GREAVES,
			// Token: 0x04003DBF RID: 15807
			ESKIMO_PANTS,
			// Token: 0x04003DC0 RID: 15808
			STEAMPUNK_PANTS,
			// Token: 0x04003DC1 RID: 15809
			BEE_PANTS,
			// Token: 0x04003DC2 RID: 15810
			MUMMY_PANTS,
			// Token: 0x04003DC3 RID: 15811
			COWBOY_PANTS,
			// Token: 0x04003DC4 RID: 15812
			PIRATE_PANTS,
			// Token: 0x04003DC5 RID: 15813
			CACTUS_LEGGINGS,
			// Token: 0x04003DC6 RID: 15814
			SHADEWOOD_GREAVES,
			// Token: 0x04003DC7 RID: 15815
			ANCIENT_SHADOW_GREAVES,
			// Token: 0x04003DC8 RID: 15816
			ANCIENT_COBALT_LEGGINGS,
			// Token: 0x04003DC9 RID: 15817
			PINK_ESKIMO_PANTS,
			// Token: 0x04003DCA RID: 15818
			CHLOROPHYTE_GREAVES,
			// Token: 0x04003DCB RID: 15819
			TIKI_PANTS,
			// Token: 0x04003DCC RID: 15820
			PALLADIUM_LEGGINGS,
			// Token: 0x04003DCD RID: 15821
			ORICHALCUM_LEGGINGS,
			// Token: 0x04003DCE RID: 15822
			TITANIUM_LEGGINGS,
			// Token: 0x04003DCF RID: 15823
			SAILOR_PANTS,
			// Token: 0x04003DD0 RID: 15824
			WHITE_TUXEDO_PANTS,
			// Token: 0x04003DD1 RID: 15825
			TURTLE_LEGGINGS,
			// Token: 0x04003DD2 RID: 15826
			SPECTRE_PANTS,
			// Token: 0x04003DD3 RID: 15827
			SHROOMITE_LEGGINGS,
			// Token: 0x04003DD4 RID: 15828
			CENXS_LEGGINGS,
			// Token: 0x04003DD5 RID: 15829
			CROWNOS_LEGGINGS,
			// Token: 0x04003DD6 RID: 15830
			WILLS_LEGGINGS,
			// Token: 0x04003DD7 RID: 15831
			JIMS_LEGGINGS,
			// Token: 0x04003DD8 RID: 15832
			AARONS_LEGGINGS,
			// Token: 0x04003DD9 RID: 15833
			D_TOWNS_LEGGINGS,
			// Token: 0x04003DDA RID: 15834
			CENXS_DRESS_PANTS,
			// Token: 0x04003DDB RID: 15835
			PUMPKIN_LEGGINGS,
			// Token: 0x04003DDC RID: 15836
			NURSE_PANTS,
			// Token: 0x04003DDD RID: 15837
			CYBORG_PANTS,
			// Token: 0x04003DDE RID: 15838
			CREEPER_PANTS,
			// Token: 0x04003DDF RID: 15839
			CAT_PANTS,
			// Token: 0x04003DE0 RID: 15840
			PUMPKIN_PANTS,
			// Token: 0x04003DE1 RID: 15841
			ROBOT_PANTS,
			// Token: 0x04003DE2 RID: 15842
			UNICORN_PANTS,
			// Token: 0x04003DE3 RID: 15843
			VAMPIRE_PANTS,
			// Token: 0x04003DE4 RID: 15844
			LEPRECHAUN_PANTS,
			// Token: 0x04003DE5 RID: 15845
			PIXIE_PANTS,
			// Token: 0x04003DE6 RID: 15846
			WITCH_BOOTS,
			// Token: 0x04003DE7 RID: 15847
			KARATE_TORTOISE_PANTS,
			// Token: 0x04003DE8 RID: 15848
			SCARECROW_PANTS,
			// Token: 0x04003DE9 RID: 15849
			FOX_PANTS,
			// Token: 0x04003DEA RID: 15850
			SPOOKY_LEGGINGS,
			// Token: 0x04003DEB RID: 15851
			SPACE_CREATURE_PANTS,
			// Token: 0x04003DEC RID: 15852
			WOLF_PANTS,
			// Token: 0x04003DED RID: 15853
			TREASURE_HUNTER_PANTS,
			// Token: 0x04003DEE RID: 15854
			DRYAD_LOINCLOTH,
			// Token: 0x04003DEF RID: 15855
			MRS_CLAUSE_HEELS,
			// Token: 0x04003DF0 RID: 15856
			TREE_TRUNKS,
			// Token: 0x04003DF1 RID: 15857
			PARKA_PANTS,
			// Token: 0x04003DF2 RID: 15858
			ELF_PANTS,
			// Token: 0x04003DF3 RID: 15859
			ROBE,
			// Token: 0x04003DF4 RID: 15860
			RUNE_ROBE,
			// Token: 0x04003DF5 RID: 15861
			PHARAOHS_ROBE,
			// Token: 0x04003DF6 RID: 15862
			AMETHYST_ROBE,
			// Token: 0x04003DF7 RID: 15863
			TOPAZ_ROBE,
			// Token: 0x04003DF8 RID: 15864
			SAPPHIRE_ROBE,
			// Token: 0x04003DF9 RID: 15865
			EMERALD_ROBE,
			// Token: 0x04003DFA RID: 15866
			RUBY_ROBE,
			// Token: 0x04003DFB RID: 15867
			DIAMOND_ROBE,
			// Token: 0x04003DFC RID: 15868
			PRINCESS_DRESS,
			// Token: 0x04003DFD RID: 15869
			BEETLE_LEGGINGS,
			// Token: 0x04003DFE RID: 15870
			GI,
			// Token: 0x04003DFF RID: 15871
			KIMONO,
			// Token: 0x04003E00 RID: 15872
			GYPSY_ROBE,
			// Token: 0x04003E01 RID: 15873
			BEE_GREAVES,
			// Token: 0x04003E02 RID: 15874
			ANGLER_PANTS,
			// Token: 0x04003E03 RID: 15875
			SPIDER_GREAVES,
			// Token: 0x04003E04 RID: 15876
			MERMAID_TAIL,
			// Token: 0x04003E05 RID: 15877
			FISH_COSTUME_FINSKIRT,
			// Token: 0x04003E06 RID: 15878
			BOREAL_WOOD_GREAVES,
			// Token: 0x04003E07 RID: 15879
			PALM_WOOD_GREAVES,
			// Token: 0x04003E08 RID: 15880
			DRAGON_GREAVES,
			// Token: 0x04003E09 RID: 15881
			TITAN_LEGGINGS,
			// Token: 0x04003E0A RID: 15882
			SPECTRAL_SUBLIGAR,
			// Token: 0x04003E0B RID: 15883
			FABULOUS_SLIPPERS,
			// Token: 0x04003E0C RID: 15884
			GEORGES_TUXEDO_PANTS,
			// Token: 0x04003E0D RID: 15885
			DIRNDL,
			// Token: 0x04003E0E RID: 15886
			TIROLER,
			// Token: 0x04003E0F RID: 15887
			OSTARA_BOOTS,
			// Token: 0x04003E10 RID: 15888
			MYTHICALROBE
		}
	}
}
