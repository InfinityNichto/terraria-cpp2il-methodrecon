using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x0200091A RID: 2330
	public class BestiaryDatabaseNPCsPopulator
	{
		// Token: 0x060046E7 RID: 18151 RVA: 0x0025B408 File Offset: 0x00259608
		public BestiaryDatabaseNPCsPopulator()
		{
		}

		// Token: 0x060046E8 RID: 18152 RVA: 0x0025B41C File Offset: 0x0025961C
		private BestiaryEntry FindEntryByNPCID(int npcNetId)
		{
			return this._currentDatabase.FindEntryByNPCID(npcNetId);
		}

		// Token: 0x060046E9 RID: 18153 RVA: 0x0025B438 File Offset: 0x00259638
		private BestiaryEntry Register(BestiaryEntry entry)
		{
			return this._currentDatabase.Register(entry);
		}

		// Token: 0x060046EA RID: 18154 RVA: 0x0025B454 File Offset: 0x00259654
		private IBestiaryEntryFilter Register(IBestiaryEntryFilter filter)
		{
			return this._currentDatabase.Register(filter);
		}

		// Token: 0x060046EB RID: 18155 RVA: 0x0025B470 File Offset: 0x00259670
		public void Populate(BestiaryDatabase database)
		{
			this._currentDatabase = database;
			this.AddEmptyEntries_CrittersAndEnemies_Automated();
			this.AddTownNPCs_Manual();
			this.AddNPCBiomeRelationships_Automated();
			this.AddNPCBiomeRelationships_Manual();
			this.AddNPCBiomeRelationships_AddDecorations_Automated();
			this.ModifyEntriesThatNeedIt();
			this.RegisterFilters();
			this.RegisterSortSteps();
		}

		// Token: 0x060046EC RID: 18156 RVA: 0x0025B4B4 File Offset: 0x002596B4
		private void RegisterTestEntries()
		{
			BestiaryEntry bestiaryEntry2;
			BestiaryEntry bestiaryEntry = this._currentDatabase.Register(bestiaryEntry2);
		}

		// Token: 0x060046ED RID: 18157 RVA: 0x0025B4D0 File Offset: 0x002596D0
		private void RegisterSortSteps()
		{
		}

		// Token: 0x060046EE RID: 18158 RVA: 0x0025B504 File Offset: 0x00259704
		private void RegisterFilters()
		{
			BestiaryDatabase currentDatabase = this._currentDatabase;
			BestiaryDatabase currentDatabase2 = this._currentDatabase;
			BestiaryDatabase currentDatabase3 = this._currentDatabase;
			List<IBestiaryInfoElement> commonInfoElementsForFilters = BestiaryDatabaseNPCsPopulator.CommonTags.GetCommonInfoElementsForFilters();
			int size = commonInfoElementsForFilters._size;
			BestiaryDatabase currentDatabase4 = this._currentDatabase;
			int size2 = commonInfoElementsForFilters._size;
		}

		// Token: 0x060046EF RID: 18159 RVA: 0x000021DB File Offset: 0x000003DB
		private void ModifyEntriesThatNeedIt_NameOverride(int npcID, string newNameKey)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060046F0 RID: 18160 RVA: 0x000021DB File Offset: 0x000003DB
		private void ModifyEntriesThatNeedIt()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060046F1 RID: 18161 RVA: 0x0025B550 File Offset: 0x00259750
		private void AdjustEaterOfWorldStats(NPCStatsReportInfoElement element)
		{
			int lifeMax = element.LifeMax;
			if (!true)
			{
			}
			int eaterOfWorldsSegmentsCountByGamemode = NPC.GetEaterOfWorldsSegmentsCountByGamemode(Main.GameMode);
		}

		// Token: 0x060046F2 RID: 18162 RVA: 0x0025B574 File Offset: 0x00259774
		private void AdjustPirateShipStats(NPCStatsReportInfoElement element)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			element.LifeMax = 1;
		}

		// Token: 0x060046F3 RID: 18163 RVA: 0x000021DB File Offset: 0x000003DB
		private void TryGivingEntryFlavorTextIfItIsMissing(BestiaryEntry entry)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060046F4 RID: 18164 RVA: 0x0025B590 File Offset: 0x00259790
		private void AddTownNPCs_Manual()
		{
			BestiaryEntry bestiaryEntry = BestiaryEntry.TownNPC(22);
			BestiaryEntry bestiaryEntry2 = this._currentDatabase.Register(bestiaryEntry);
			BestiaryEntry bestiaryEntry3 = BestiaryEntry.TownNPC(17);
			BestiaryEntry bestiaryEntry4 = this._currentDatabase.Register(bestiaryEntry3);
			BestiaryEntry bestiaryEntry5 = BestiaryEntry.TownNPC(18);
			BestiaryEntry bestiaryEntry6 = this._currentDatabase.Register(bestiaryEntry5);
			BestiaryEntry bestiaryEntry7 = BestiaryEntry.TownNPC(19);
			BestiaryEntry bestiaryEntry8 = this._currentDatabase.Register(bestiaryEntry7);
			BestiaryEntry bestiaryEntry9 = BestiaryEntry.TownNPC(20);
			BestiaryEntry bestiaryEntry10 = this._currentDatabase.Register(bestiaryEntry9);
			BestiaryEntry bestiaryEntry11 = BestiaryEntry.TownNPC(37);
			BestiaryEntry bestiaryEntry12 = this._currentDatabase.Register(bestiaryEntry11);
			BestiaryEntry bestiaryEntry13 = BestiaryEntry.TownNPC(54);
			BestiaryEntry bestiaryEntry14 = this._currentDatabase.Register(bestiaryEntry13);
			BestiaryEntry bestiaryEntry15 = BestiaryEntry.TownNPC(38);
			BestiaryEntry bestiaryEntry16 = this._currentDatabase.Register(bestiaryEntry15);
			BestiaryEntry bestiaryEntry17 = BestiaryEntry.TownNPC(107);
			BestiaryEntry bestiaryEntry18 = this._currentDatabase.Register(bestiaryEntry17);
			BestiaryEntry bestiaryEntry19 = BestiaryEntry.TownNPC(108);
			BestiaryEntry bestiaryEntry20 = this._currentDatabase.Register(bestiaryEntry19);
			BestiaryEntry bestiaryEntry21 = BestiaryEntry.TownNPC(124);
			BestiaryEntry bestiaryEntry22 = this._currentDatabase.Register(bestiaryEntry21);
			BestiaryEntry bestiaryEntry23 = BestiaryEntry.TownNPC(142);
			BestiaryEntry bestiaryEntry24 = this._currentDatabase.Register(bestiaryEntry23);
			BestiaryEntry bestiaryEntry25 = BestiaryEntry.TownNPC(160);
			BestiaryEntry bestiaryEntry26 = this._currentDatabase.Register(bestiaryEntry25);
			BestiaryEntry bestiaryEntry27 = BestiaryEntry.TownNPC(178);
			BestiaryEntry bestiaryEntry28 = this._currentDatabase.Register(bestiaryEntry27);
			BestiaryEntry bestiaryEntry29 = BestiaryEntry.TownNPC(207);
			BestiaryEntry bestiaryEntry30 = this._currentDatabase.Register(bestiaryEntry29);
			BestiaryEntry bestiaryEntry31 = BestiaryEntry.TownNPC(208);
			BestiaryEntry bestiaryEntry32 = this._currentDatabase.Register(bestiaryEntry31);
			BestiaryEntry bestiaryEntry33 = BestiaryEntry.TownNPC(209);
			BestiaryEntry bestiaryEntry34 = this._currentDatabase.Register(bestiaryEntry33);
			BestiaryEntry bestiaryEntry35 = BestiaryEntry.TownNPC(227);
			BestiaryEntry bestiaryEntry36 = this._currentDatabase.Register(bestiaryEntry35);
			BestiaryEntry bestiaryEntry37 = BestiaryEntry.TownNPC(228);
			BestiaryEntry bestiaryEntry38 = this._currentDatabase.Register(bestiaryEntry37);
			BestiaryEntry bestiaryEntry39 = BestiaryEntry.TownNPC(229);
			BestiaryEntry bestiaryEntry40 = this._currentDatabase.Register(bestiaryEntry39);
			BestiaryEntry bestiaryEntry41 = BestiaryEntry.TownNPC(353);
			BestiaryEntry bestiaryEntry42 = this._currentDatabase.Register(bestiaryEntry41);
			BestiaryEntry bestiaryEntry43 = BestiaryEntry.TownNPC(369);
			BestiaryEntry bestiaryEntry44 = this._currentDatabase.Register(bestiaryEntry43);
			BestiaryEntry bestiaryEntry45 = BestiaryEntry.TownNPC(441);
			BestiaryEntry bestiaryEntry46 = this._currentDatabase.Register(bestiaryEntry45);
			BestiaryEntry bestiaryEntry47 = BestiaryEntry.TownNPC(550);
			BestiaryEntry bestiaryEntry48 = this._currentDatabase.Register(bestiaryEntry47);
			BestiaryEntry bestiaryEntry49 = BestiaryEntry.TownNPC(588);
			BestiaryEntry bestiaryEntry50 = this._currentDatabase.Register(bestiaryEntry49);
			BestiaryEntry bestiaryEntry51 = BestiaryEntry.TownNPC(368);
			BestiaryEntry bestiaryEntry52 = this._currentDatabase.Register(bestiaryEntry51);
			BestiaryEntry bestiaryEntry53 = BestiaryEntry.TownNPC(453);
			BestiaryEntry bestiaryEntry54 = this._currentDatabase.Register(bestiaryEntry53);
			BestiaryEntry bestiaryEntry55 = BestiaryEntry.TownNPC(633);
			BestiaryEntry bestiaryEntry56 = this._currentDatabase.Register(bestiaryEntry55);
			BestiaryEntry bestiaryEntry57 = BestiaryEntry.TownNPC(663);
			BestiaryEntry bestiaryEntry58 = this._currentDatabase.Register(bestiaryEntry57);
			BestiaryEntry bestiaryEntry59 = BestiaryEntry.TownNPC(638);
			BestiaryEntry bestiaryEntry60 = this._currentDatabase.Register(bestiaryEntry59);
			BestiaryEntry bestiaryEntry61 = BestiaryEntry.TownNPC(637);
			BestiaryEntry bestiaryEntry62 = this._currentDatabase.Register(bestiaryEntry61);
			BestiaryEntry bestiaryEntry63 = BestiaryEntry.TownNPC(656);
			BestiaryEntry bestiaryEntry64 = this._currentDatabase.Register(bestiaryEntry63);
			BestiaryEntry bestiaryEntry65 = BestiaryEntry.TownNPC(670);
			BestiaryEntry bestiaryEntry66 = this._currentDatabase.Register(bestiaryEntry65);
			BestiaryEntry bestiaryEntry67 = BestiaryEntry.TownNPC(678);
			BestiaryEntry bestiaryEntry68 = this._currentDatabase.Register(bestiaryEntry67);
			BestiaryEntry bestiaryEntry69 = BestiaryEntry.TownNPC(679);
			BestiaryEntry bestiaryEntry70 = this._currentDatabase.Register(bestiaryEntry69);
			BestiaryEntry bestiaryEntry71 = BestiaryEntry.TownNPC(680);
			BestiaryEntry bestiaryEntry72 = this._currentDatabase.Register(bestiaryEntry71);
			BestiaryEntry bestiaryEntry73 = BestiaryEntry.TownNPC(681);
			BestiaryEntry bestiaryEntry74 = this._currentDatabase.Register(bestiaryEntry73);
			BestiaryEntry bestiaryEntry75 = BestiaryEntry.TownNPC(682);
			BestiaryEntry bestiaryEntry76 = this._currentDatabase.Register(bestiaryEntry75);
			BestiaryEntry bestiaryEntry77 = BestiaryEntry.TownNPC(683);
			BestiaryEntry bestiaryEntry78 = this._currentDatabase.Register(bestiaryEntry77);
			BestiaryEntry bestiaryEntry79 = BestiaryEntry.TownNPC(684);
			BestiaryEntry bestiaryEntry80 = this._currentDatabase.Register(bestiaryEntry79);
		}

		// Token: 0x060046F5 RID: 18165 RVA: 0x0025B9B0 File Offset: 0x00259BB0
		private void AddMultiEntryNPCS_Manual()
		{
			BestiaryEntry bestiaryEntry = BestiaryEntry.Enemy(85);
			BestiaryEntry bestiaryEntry2 = this._currentDatabase.Register(bestiaryEntry);
		}

		// Token: 0x060046F6 RID: 18166 RVA: 0x0025B9D4 File Offset: 0x00259BD4
		private void AddEmptyEntries_CrittersAndEnemies_Automated()
		{
			HashSet<int> exclusions = BestiaryDatabaseNPCsPopulator.GetExclusions();
			BestiaryEntry bestiaryEntry = BestiaryEntry.Critter(0);
			BestiaryEntry bestiaryEntry2 = this._currentDatabase.Register(bestiaryEntry);
		}

		// Token: 0x060046F7 RID: 18167 RVA: 0x0025BA30 File Offset: 0x00259C30
		private static HashSet<int> GetExclusions()
		{
			if (!true)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060046F8 RID: 18168 RVA: 0x0025BA60 File Offset: 0x00259C60
		private void AddNPCBiomeRelationships_Automated()
		{
			List<IBestiaryInfoElement> <Info>k__BackingField = this._currentDatabase.FindEntryByNPCID(357).<Info>k__BackingField;
			BestiaryEntry bestiaryEntry;
			List<IBestiaryInfoElement> <Info>k__BackingField2 = bestiaryEntry.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry2;
			List<IBestiaryInfoElement> <Info>k__BackingField3 = bestiaryEntry2.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry3;
			List<IBestiaryInfoElement> <Info>k__BackingField4 = bestiaryEntry3.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry4;
			List<IBestiaryInfoElement> <Info>k__BackingField5 = bestiaryEntry4.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry5;
			List<IBestiaryInfoElement> <Info>k__BackingField6 = bestiaryEntry5.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry6;
			List<IBestiaryInfoElement> <Info>k__BackingField7 = bestiaryEntry6.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry7;
			List<IBestiaryInfoElement> <Info>k__BackingField8 = bestiaryEntry7.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry8;
			List<IBestiaryInfoElement> <Info>k__BackingField9 = bestiaryEntry8.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry9;
			List<IBestiaryInfoElement> <Info>k__BackingField10 = bestiaryEntry9.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry10;
			List<IBestiaryInfoElement> <Info>k__BackingField11 = bestiaryEntry10.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry11;
			List<IBestiaryInfoElement> <Info>k__BackingField12 = bestiaryEntry11.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry12;
			List<IBestiaryInfoElement> <Info>k__BackingField13 = bestiaryEntry12.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry13;
			List<IBestiaryInfoElement> <Info>k__BackingField14 = bestiaryEntry13.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry14;
			List<IBestiaryInfoElement> <Info>k__BackingField15 = bestiaryEntry14.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry15;
			List<IBestiaryInfoElement> <Info>k__BackingField16 = bestiaryEntry15.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry16;
			List<IBestiaryInfoElement> <Info>k__BackingField17 = bestiaryEntry16.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry17;
			List<IBestiaryInfoElement> <Info>k__BackingField18 = bestiaryEntry17.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry18;
			List<IBestiaryInfoElement> <Info>k__BackingField19 = bestiaryEntry18.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry19;
			List<IBestiaryInfoElement> <Info>k__BackingField20 = bestiaryEntry19.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry20;
			List<IBestiaryInfoElement> <Info>k__BackingField21 = bestiaryEntry20.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry21;
			List<IBestiaryInfoElement> <Info>k__BackingField22 = bestiaryEntry21.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry22;
			List<IBestiaryInfoElement> <Info>k__BackingField23 = bestiaryEntry22.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry23;
			List<IBestiaryInfoElement> <Info>k__BackingField24 = bestiaryEntry23.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry24;
			List<IBestiaryInfoElement> <Info>k__BackingField25 = bestiaryEntry24.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry25;
			List<IBestiaryInfoElement> <Info>k__BackingField26 = bestiaryEntry25.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry26;
			List<IBestiaryInfoElement> <Info>k__BackingField27 = bestiaryEntry26.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry27;
			List<IBestiaryInfoElement> <Info>k__BackingField28 = bestiaryEntry27.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry28;
			List<IBestiaryInfoElement> <Info>k__BackingField29 = bestiaryEntry28.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry29;
			List<IBestiaryInfoElement> <Info>k__BackingField30 = bestiaryEntry29.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry30;
			List<IBestiaryInfoElement> <Info>k__BackingField31 = bestiaryEntry30.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry31;
			List<IBestiaryInfoElement> <Info>k__BackingField32 = bestiaryEntry31.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry32;
			List<IBestiaryInfoElement> <Info>k__BackingField33 = bestiaryEntry32.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry33;
			List<IBestiaryInfoElement> <Info>k__BackingField34 = bestiaryEntry33.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry34;
			List<IBestiaryInfoElement> <Info>k__BackingField35 = bestiaryEntry34.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry35;
			List<IBestiaryInfoElement> <Info>k__BackingField36 = bestiaryEntry35.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry36;
			List<IBestiaryInfoElement> <Info>k__BackingField37 = bestiaryEntry36.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry37;
			List<IBestiaryInfoElement> <Info>k__BackingField38 = bestiaryEntry37.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry38;
			List<IBestiaryInfoElement> <Info>k__BackingField39 = bestiaryEntry38.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry39;
			List<IBestiaryInfoElement> <Info>k__BackingField40 = bestiaryEntry39.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry40;
			List<IBestiaryInfoElement> <Info>k__BackingField41 = bestiaryEntry40.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry41;
			List<IBestiaryInfoElement> <Info>k__BackingField42 = bestiaryEntry41.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry42;
			List<IBestiaryInfoElement> <Info>k__BackingField43 = bestiaryEntry42.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry43;
			List<IBestiaryInfoElement> <Info>k__BackingField44 = bestiaryEntry43.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry44;
			List<IBestiaryInfoElement> <Info>k__BackingField45 = bestiaryEntry44.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry45;
			List<IBestiaryInfoElement> <Info>k__BackingField46 = bestiaryEntry45.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry46;
			List<IBestiaryInfoElement> <Info>k__BackingField47 = bestiaryEntry46.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry47;
			List<IBestiaryInfoElement> <Info>k__BackingField48 = bestiaryEntry47.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry48;
			List<IBestiaryInfoElement> <Info>k__BackingField49 = bestiaryEntry48.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry49;
			List<IBestiaryInfoElement> <Info>k__BackingField50 = bestiaryEntry49.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry50;
			List<IBestiaryInfoElement> <Info>k__BackingField51 = bestiaryEntry50.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry51;
			List<IBestiaryInfoElement> <Info>k__BackingField52 = bestiaryEntry51.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry52;
			List<IBestiaryInfoElement> <Info>k__BackingField53 = bestiaryEntry52.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry53;
			List<IBestiaryInfoElement> <Info>k__BackingField54 = bestiaryEntry53.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry54;
			List<IBestiaryInfoElement> <Info>k__BackingField55 = bestiaryEntry54.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry55;
			List<IBestiaryInfoElement> <Info>k__BackingField56 = bestiaryEntry55.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry56;
			List<IBestiaryInfoElement> <Info>k__BackingField57 = bestiaryEntry56.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry57;
			List<IBestiaryInfoElement> <Info>k__BackingField58 = bestiaryEntry57.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry58;
			List<IBestiaryInfoElement> <Info>k__BackingField59 = bestiaryEntry58.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry59;
			List<IBestiaryInfoElement> <Info>k__BackingField60 = bestiaryEntry59.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry60;
			List<IBestiaryInfoElement> <Info>k__BackingField61 = bestiaryEntry60.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry61;
			List<IBestiaryInfoElement> <Info>k__BackingField62 = bestiaryEntry61.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry62;
			List<IBestiaryInfoElement> <Info>k__BackingField63 = bestiaryEntry62.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry63;
			List<IBestiaryInfoElement> <Info>k__BackingField64 = bestiaryEntry63.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry64;
			List<IBestiaryInfoElement> <Info>k__BackingField65 = bestiaryEntry64.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry65;
			List<IBestiaryInfoElement> <Info>k__BackingField66 = bestiaryEntry65.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry66;
			List<IBestiaryInfoElement> <Info>k__BackingField67 = bestiaryEntry66.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry67;
			List<IBestiaryInfoElement> <Info>k__BackingField68 = bestiaryEntry67.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry68;
			List<IBestiaryInfoElement> <Info>k__BackingField69 = bestiaryEntry68.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry69;
			List<IBestiaryInfoElement> <Info>k__BackingField70 = bestiaryEntry69.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry70;
			List<IBestiaryInfoElement> <Info>k__BackingField71 = bestiaryEntry70.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry71;
			List<IBestiaryInfoElement> <Info>k__BackingField72 = bestiaryEntry71.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry72;
			List<IBestiaryInfoElement> <Info>k__BackingField73 = bestiaryEntry72.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry73;
			List<IBestiaryInfoElement> <Info>k__BackingField74 = bestiaryEntry73.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry74;
			List<IBestiaryInfoElement> <Info>k__BackingField75 = bestiaryEntry74.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry75;
			List<IBestiaryInfoElement> <Info>k__BackingField76 = bestiaryEntry75.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry76;
			List<IBestiaryInfoElement> <Info>k__BackingField77 = bestiaryEntry76.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry77;
			List<IBestiaryInfoElement> <Info>k__BackingField78 = bestiaryEntry77.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry78;
			List<IBestiaryInfoElement> <Info>k__BackingField79 = bestiaryEntry78.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry79;
			List<IBestiaryInfoElement> <Info>k__BackingField80 = bestiaryEntry79.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry80;
			List<IBestiaryInfoElement> <Info>k__BackingField81 = bestiaryEntry80.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry81;
			List<IBestiaryInfoElement> <Info>k__BackingField82 = bestiaryEntry81.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry82;
			List<IBestiaryInfoElement> <Info>k__BackingField83 = bestiaryEntry82.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry83;
			List<IBestiaryInfoElement> <Info>k__BackingField84 = bestiaryEntry83.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry84;
			List<IBestiaryInfoElement> <Info>k__BackingField85 = bestiaryEntry84.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry85;
			List<IBestiaryInfoElement> <Info>k__BackingField86 = bestiaryEntry85.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry86;
			List<IBestiaryInfoElement> <Info>k__BackingField87 = bestiaryEntry86.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry87;
			List<IBestiaryInfoElement> <Info>k__BackingField88 = bestiaryEntry87.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry88;
			List<IBestiaryInfoElement> <Info>k__BackingField89 = bestiaryEntry88.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry89;
			List<IBestiaryInfoElement> <Info>k__BackingField90 = bestiaryEntry89.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry90;
			List<IBestiaryInfoElement> <Info>k__BackingField91 = bestiaryEntry90.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry91;
			List<IBestiaryInfoElement> <Info>k__BackingField92 = bestiaryEntry91.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry92;
			List<IBestiaryInfoElement> <Info>k__BackingField93 = bestiaryEntry92.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry93;
			List<IBestiaryInfoElement> <Info>k__BackingField94 = bestiaryEntry93.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry94;
			List<IBestiaryInfoElement> <Info>k__BackingField95 = bestiaryEntry94.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry95;
			List<IBestiaryInfoElement> <Info>k__BackingField96 = bestiaryEntry95.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry96;
			List<IBestiaryInfoElement> <Info>k__BackingField97 = bestiaryEntry96.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry97;
			List<IBestiaryInfoElement> <Info>k__BackingField98 = bestiaryEntry97.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry98;
			List<IBestiaryInfoElement> <Info>k__BackingField99 = bestiaryEntry98.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry99;
			List<IBestiaryInfoElement> <Info>k__BackingField100 = bestiaryEntry99.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry100;
			List<IBestiaryInfoElement> <Info>k__BackingField101 = bestiaryEntry100.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry101;
			List<IBestiaryInfoElement> <Info>k__BackingField102 = bestiaryEntry101.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry102;
			List<IBestiaryInfoElement> <Info>k__BackingField103 = bestiaryEntry102.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry103;
			List<IBestiaryInfoElement> <Info>k__BackingField104 = bestiaryEntry103.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry104;
			List<IBestiaryInfoElement> <Info>k__BackingField105 = bestiaryEntry104.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry105;
			List<IBestiaryInfoElement> <Info>k__BackingField106 = bestiaryEntry105.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry106;
			List<IBestiaryInfoElement> <Info>k__BackingField107 = bestiaryEntry106.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry107;
			List<IBestiaryInfoElement> <Info>k__BackingField108 = bestiaryEntry107.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry108;
			List<IBestiaryInfoElement> <Info>k__BackingField109 = bestiaryEntry108.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry109;
			List<IBestiaryInfoElement> <Info>k__BackingField110 = bestiaryEntry109.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry110;
			List<IBestiaryInfoElement> <Info>k__BackingField111 = bestiaryEntry110.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry111;
			List<IBestiaryInfoElement> <Info>k__BackingField112 = bestiaryEntry111.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry112;
			List<IBestiaryInfoElement> <Info>k__BackingField113 = bestiaryEntry112.<Info>k__BackingField;
			BestiaryEntry bestiaryEntry113;
			List<IBestiaryInfoElement> <Info>k__BackingField114 = bestiaryEntry113.<Info>k__BackingField;
			if (false)
			{
				BestiaryEntry bestiaryEntry114;
				List<IBestiaryInfoElement> <Info>k__BackingField115 = bestiaryEntry114.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry115;
				List<IBestiaryInfoElement> <Info>k__BackingField116 = bestiaryEntry115.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry116;
				List<IBestiaryInfoElement> <Info>k__BackingField117 = bestiaryEntry116.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry117;
				List<IBestiaryInfoElement> <Info>k__BackingField118 = bestiaryEntry117.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry118;
				List<IBestiaryInfoElement> <Info>k__BackingField119 = bestiaryEntry118.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry119;
				List<IBestiaryInfoElement> <Info>k__BackingField120 = bestiaryEntry119.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry120;
				List<IBestiaryInfoElement> <Info>k__BackingField121 = bestiaryEntry120.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry121;
				List<IBestiaryInfoElement> <Info>k__BackingField122 = bestiaryEntry121.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry122;
				List<IBestiaryInfoElement> <Info>k__BackingField123 = bestiaryEntry122.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry123;
				List<IBestiaryInfoElement> <Info>k__BackingField124 = bestiaryEntry123.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry124;
				List<IBestiaryInfoElement> <Info>k__BackingField125 = bestiaryEntry124.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry125;
				List<IBestiaryInfoElement> <Info>k__BackingField126 = bestiaryEntry125.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry126;
				List<IBestiaryInfoElement> <Info>k__BackingField127 = bestiaryEntry126.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry127;
				List<IBestiaryInfoElement> <Info>k__BackingField128 = bestiaryEntry127.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry128;
				List<IBestiaryInfoElement> <Info>k__BackingField129 = bestiaryEntry128.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry129;
				List<IBestiaryInfoElement> <Info>k__BackingField130 = bestiaryEntry129.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry130;
				List<IBestiaryInfoElement> <Info>k__BackingField131 = bestiaryEntry130.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry131;
				List<IBestiaryInfoElement> <Info>k__BackingField132 = bestiaryEntry131.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry132;
				List<IBestiaryInfoElement> <Info>k__BackingField133 = bestiaryEntry132.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry133;
				List<IBestiaryInfoElement> <Info>k__BackingField134 = bestiaryEntry133.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry134;
				List<IBestiaryInfoElement> <Info>k__BackingField135 = bestiaryEntry134.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry135;
				List<IBestiaryInfoElement> <Info>k__BackingField136 = bestiaryEntry135.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry136;
				List<IBestiaryInfoElement> <Info>k__BackingField137 = bestiaryEntry136.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry137;
				List<IBestiaryInfoElement> <Info>k__BackingField138 = bestiaryEntry137.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry138;
				List<IBestiaryInfoElement> <Info>k__BackingField139 = bestiaryEntry138.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry139;
				List<IBestiaryInfoElement> <Info>k__BackingField140 = bestiaryEntry139.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry140;
				List<IBestiaryInfoElement> <Info>k__BackingField141 = bestiaryEntry140.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry141;
				List<IBestiaryInfoElement> <Info>k__BackingField142 = bestiaryEntry141.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry142;
				List<IBestiaryInfoElement> <Info>k__BackingField143 = bestiaryEntry142.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry143;
				List<IBestiaryInfoElement> <Info>k__BackingField144 = bestiaryEntry143.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry144;
				List<IBestiaryInfoElement> <Info>k__BackingField145 = bestiaryEntry144.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry145;
				List<IBestiaryInfoElement> <Info>k__BackingField146 = bestiaryEntry145.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry146;
				List<IBestiaryInfoElement> <Info>k__BackingField147 = bestiaryEntry146.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry147;
				List<IBestiaryInfoElement> <Info>k__BackingField148 = bestiaryEntry147.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry148;
				List<IBestiaryInfoElement> <Info>k__BackingField149 = bestiaryEntry148.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry149;
				List<IBestiaryInfoElement> <Info>k__BackingField150 = bestiaryEntry149.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry150;
				List<IBestiaryInfoElement> <Info>k__BackingField151 = bestiaryEntry150.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry151;
				List<IBestiaryInfoElement> <Info>k__BackingField152 = bestiaryEntry151.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry152;
				List<IBestiaryInfoElement> <Info>k__BackingField153 = bestiaryEntry152.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry153;
				List<IBestiaryInfoElement> <Info>k__BackingField154 = bestiaryEntry153.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry154;
				List<IBestiaryInfoElement> <Info>k__BackingField155 = bestiaryEntry154.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry155;
				List<IBestiaryInfoElement> <Info>k__BackingField156 = bestiaryEntry155.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry156;
				List<IBestiaryInfoElement> <Info>k__BackingField157 = bestiaryEntry156.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry157;
				List<IBestiaryInfoElement> <Info>k__BackingField158 = bestiaryEntry157.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry158;
				List<IBestiaryInfoElement> <Info>k__BackingField159 = bestiaryEntry158.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry159;
				List<IBestiaryInfoElement> <Info>k__BackingField160 = bestiaryEntry159.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry160;
				List<IBestiaryInfoElement> <Info>k__BackingField161 = bestiaryEntry160.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry161;
				List<IBestiaryInfoElement> <Info>k__BackingField162 = bestiaryEntry161.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry162;
				List<IBestiaryInfoElement> <Info>k__BackingField163 = bestiaryEntry162.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry163;
				List<IBestiaryInfoElement> <Info>k__BackingField164 = bestiaryEntry163.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry164;
				List<IBestiaryInfoElement> <Info>k__BackingField165 = bestiaryEntry164.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry165;
				List<IBestiaryInfoElement> <Info>k__BackingField166 = bestiaryEntry165.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry166;
				List<IBestiaryInfoElement> <Info>k__BackingField167 = bestiaryEntry166.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry167;
				List<IBestiaryInfoElement> <Info>k__BackingField168 = bestiaryEntry167.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry168;
				List<IBestiaryInfoElement> <Info>k__BackingField169 = bestiaryEntry168.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry169;
				List<IBestiaryInfoElement> <Info>k__BackingField170 = bestiaryEntry169.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry170;
				List<IBestiaryInfoElement> <Info>k__BackingField171 = bestiaryEntry170.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry171;
				List<IBestiaryInfoElement> <Info>k__BackingField172 = bestiaryEntry171.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry172;
				List<IBestiaryInfoElement> <Info>k__BackingField173 = bestiaryEntry172.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry173;
				List<IBestiaryInfoElement> <Info>k__BackingField174 = bestiaryEntry173.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry174;
				List<IBestiaryInfoElement> <Info>k__BackingField175 = bestiaryEntry174.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry175;
				List<IBestiaryInfoElement> <Info>k__BackingField176 = bestiaryEntry175.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry176;
				List<IBestiaryInfoElement> <Info>k__BackingField177 = bestiaryEntry176.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry177;
				List<IBestiaryInfoElement> <Info>k__BackingField178 = bestiaryEntry177.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry178;
				List<IBestiaryInfoElement> <Info>k__BackingField179 = bestiaryEntry178.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry179;
				List<IBestiaryInfoElement> <Info>k__BackingField180 = bestiaryEntry179.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry180;
				List<IBestiaryInfoElement> <Info>k__BackingField181 = bestiaryEntry180.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry181;
				List<IBestiaryInfoElement> <Info>k__BackingField182 = bestiaryEntry181.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry182;
				List<IBestiaryInfoElement> <Info>k__BackingField183 = bestiaryEntry182.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry183;
				List<IBestiaryInfoElement> <Info>k__BackingField184 = bestiaryEntry183.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry184;
				List<IBestiaryInfoElement> <Info>k__BackingField185 = bestiaryEntry184.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry185;
				List<IBestiaryInfoElement> <Info>k__BackingField186 = bestiaryEntry185.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry186;
				List<IBestiaryInfoElement> <Info>k__BackingField187 = bestiaryEntry186.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry187;
				List<IBestiaryInfoElement> <Info>k__BackingField188 = bestiaryEntry187.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry188;
				List<IBestiaryInfoElement> <Info>k__BackingField189 = bestiaryEntry188.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry189;
				List<IBestiaryInfoElement> <Info>k__BackingField190 = bestiaryEntry189.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry190;
				List<IBestiaryInfoElement> <Info>k__BackingField191 = bestiaryEntry190.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry191;
				List<IBestiaryInfoElement> <Info>k__BackingField192 = bestiaryEntry191.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry192;
				List<IBestiaryInfoElement> <Info>k__BackingField193 = bestiaryEntry192.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry193;
				List<IBestiaryInfoElement> <Info>k__BackingField194 = bestiaryEntry193.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry194;
				List<IBestiaryInfoElement> <Info>k__BackingField195 = bestiaryEntry194.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry195;
				List<IBestiaryInfoElement> <Info>k__BackingField196 = bestiaryEntry195.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry196;
				List<IBestiaryInfoElement> <Info>k__BackingField197 = bestiaryEntry196.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry197;
				List<IBestiaryInfoElement> <Info>k__BackingField198 = bestiaryEntry197.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry198;
				List<IBestiaryInfoElement> <Info>k__BackingField199 = bestiaryEntry198.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry199;
				List<IBestiaryInfoElement> <Info>k__BackingField200 = bestiaryEntry199.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry200;
				List<IBestiaryInfoElement> <Info>k__BackingField201 = bestiaryEntry200.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry201;
				List<IBestiaryInfoElement> <Info>k__BackingField202 = bestiaryEntry201.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry202;
				List<IBestiaryInfoElement> <Info>k__BackingField203 = bestiaryEntry202.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry203;
				List<IBestiaryInfoElement> <Info>k__BackingField204 = bestiaryEntry203.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry204;
				List<IBestiaryInfoElement> <Info>k__BackingField205 = bestiaryEntry204.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry205;
				List<IBestiaryInfoElement> <Info>k__BackingField206 = bestiaryEntry205.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry206;
				List<IBestiaryInfoElement> <Info>k__BackingField207 = bestiaryEntry206.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry207;
				List<IBestiaryInfoElement> <Info>k__BackingField208 = bestiaryEntry207.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry208;
				List<IBestiaryInfoElement> <Info>k__BackingField209 = bestiaryEntry208.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry209;
				List<IBestiaryInfoElement> <Info>k__BackingField210 = bestiaryEntry209.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry210;
				List<IBestiaryInfoElement> <Info>k__BackingField211 = bestiaryEntry210.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry211;
				List<IBestiaryInfoElement> <Info>k__BackingField212 = bestiaryEntry211.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry212;
				List<IBestiaryInfoElement> <Info>k__BackingField213 = bestiaryEntry212.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry213;
				List<IBestiaryInfoElement> <Info>k__BackingField214 = bestiaryEntry213.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry214;
				List<IBestiaryInfoElement> <Info>k__BackingField215 = bestiaryEntry214.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry215;
				List<IBestiaryInfoElement> <Info>k__BackingField216 = bestiaryEntry215.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry216;
				List<IBestiaryInfoElement> <Info>k__BackingField217 = bestiaryEntry216.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry217;
				List<IBestiaryInfoElement> <Info>k__BackingField218 = bestiaryEntry217.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry218;
				List<IBestiaryInfoElement> <Info>k__BackingField219 = bestiaryEntry218.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry219;
				List<IBestiaryInfoElement> <Info>k__BackingField220 = bestiaryEntry219.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry220;
				List<IBestiaryInfoElement> <Info>k__BackingField221 = bestiaryEntry220.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry221;
				List<IBestiaryInfoElement> <Info>k__BackingField222 = bestiaryEntry221.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry222;
				List<IBestiaryInfoElement> <Info>k__BackingField223 = bestiaryEntry222.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry223;
				List<IBestiaryInfoElement> <Info>k__BackingField224 = bestiaryEntry223.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry224;
				List<IBestiaryInfoElement> <Info>k__BackingField225 = bestiaryEntry224.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry225;
				List<IBestiaryInfoElement> <Info>k__BackingField226 = bestiaryEntry225.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry226;
				List<IBestiaryInfoElement> <Info>k__BackingField227 = bestiaryEntry226.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry227;
				List<IBestiaryInfoElement> <Info>k__BackingField228 = bestiaryEntry227.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry228;
				List<IBestiaryInfoElement> <Info>k__BackingField229 = bestiaryEntry228.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry229;
				List<IBestiaryInfoElement> <Info>k__BackingField230 = bestiaryEntry229.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry230;
				List<IBestiaryInfoElement> <Info>k__BackingField231 = bestiaryEntry230.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry231;
				List<IBestiaryInfoElement> <Info>k__BackingField232 = bestiaryEntry231.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry232;
				List<IBestiaryInfoElement> <Info>k__BackingField233 = bestiaryEntry232.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry233;
				List<IBestiaryInfoElement> <Info>k__BackingField234 = bestiaryEntry233.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry234;
				List<IBestiaryInfoElement> <Info>k__BackingField235 = bestiaryEntry234.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry235;
				List<IBestiaryInfoElement> <Info>k__BackingField236 = bestiaryEntry235.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry236;
				List<IBestiaryInfoElement> <Info>k__BackingField237 = bestiaryEntry236.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry237;
				List<IBestiaryInfoElement> <Info>k__BackingField238 = bestiaryEntry237.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry238;
				List<IBestiaryInfoElement> <Info>k__BackingField239 = bestiaryEntry238.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry239;
				List<IBestiaryInfoElement> <Info>k__BackingField240 = bestiaryEntry239.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry240;
				List<IBestiaryInfoElement> <Info>k__BackingField241 = bestiaryEntry240.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry241;
				List<IBestiaryInfoElement> <Info>k__BackingField242 = bestiaryEntry241.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry242;
				List<IBestiaryInfoElement> <Info>k__BackingField243 = bestiaryEntry242.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry243;
				List<IBestiaryInfoElement> <Info>k__BackingField244 = bestiaryEntry243.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry244;
				List<IBestiaryInfoElement> <Info>k__BackingField245 = bestiaryEntry244.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry245;
				List<IBestiaryInfoElement> <Info>k__BackingField246 = bestiaryEntry245.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry246;
				List<IBestiaryInfoElement> <Info>k__BackingField247 = bestiaryEntry246.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry247;
				List<IBestiaryInfoElement> <Info>k__BackingField248 = bestiaryEntry247.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry248;
				List<IBestiaryInfoElement> <Info>k__BackingField249 = bestiaryEntry248.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry249;
				List<IBestiaryInfoElement> <Info>k__BackingField250 = bestiaryEntry249.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry250;
				List<IBestiaryInfoElement> <Info>k__BackingField251 = bestiaryEntry250.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry251;
				List<IBestiaryInfoElement> <Info>k__BackingField252 = bestiaryEntry251.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry252;
				List<IBestiaryInfoElement> <Info>k__BackingField253 = bestiaryEntry252.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry253;
				List<IBestiaryInfoElement> <Info>k__BackingField254 = bestiaryEntry253.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry254;
				List<IBestiaryInfoElement> <Info>k__BackingField255 = bestiaryEntry254.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry255;
				List<IBestiaryInfoElement> <Info>k__BackingField256 = bestiaryEntry255.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry256;
				List<IBestiaryInfoElement> <Info>k__BackingField257 = bestiaryEntry256.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry257;
				List<IBestiaryInfoElement> <Info>k__BackingField258 = bestiaryEntry257.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry258;
				List<IBestiaryInfoElement> <Info>k__BackingField259 = bestiaryEntry258.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry259;
				List<IBestiaryInfoElement> <Info>k__BackingField260 = bestiaryEntry259.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry260;
				List<IBestiaryInfoElement> <Info>k__BackingField261 = bestiaryEntry260.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry261;
				List<IBestiaryInfoElement> <Info>k__BackingField262 = bestiaryEntry261.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry262;
				List<IBestiaryInfoElement> <Info>k__BackingField263 = bestiaryEntry262.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry263;
				List<IBestiaryInfoElement> <Info>k__BackingField264 = bestiaryEntry263.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry264;
				List<IBestiaryInfoElement> <Info>k__BackingField265 = bestiaryEntry264.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry265;
				List<IBestiaryInfoElement> <Info>k__BackingField266 = bestiaryEntry265.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry266;
				List<IBestiaryInfoElement> <Info>k__BackingField267 = bestiaryEntry266.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry267;
				List<IBestiaryInfoElement> <Info>k__BackingField268 = bestiaryEntry267.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry268;
				List<IBestiaryInfoElement> <Info>k__BackingField269 = bestiaryEntry268.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry269;
				List<IBestiaryInfoElement> <Info>k__BackingField270 = bestiaryEntry269.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry270;
				List<IBestiaryInfoElement> <Info>k__BackingField271 = bestiaryEntry270.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry271;
				List<IBestiaryInfoElement> <Info>k__BackingField272 = bestiaryEntry271.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry272;
				List<IBestiaryInfoElement> <Info>k__BackingField273 = bestiaryEntry272.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry273;
				List<IBestiaryInfoElement> <Info>k__BackingField274 = bestiaryEntry273.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry274;
				List<IBestiaryInfoElement> <Info>k__BackingField275 = bestiaryEntry274.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry275;
				List<IBestiaryInfoElement> <Info>k__BackingField276 = bestiaryEntry275.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry276;
				List<IBestiaryInfoElement> <Info>k__BackingField277 = bestiaryEntry276.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry277;
				List<IBestiaryInfoElement> <Info>k__BackingField278 = bestiaryEntry277.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry278;
				List<IBestiaryInfoElement> <Info>k__BackingField279 = bestiaryEntry278.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry279;
				List<IBestiaryInfoElement> <Info>k__BackingField280 = bestiaryEntry279.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry280;
				List<IBestiaryInfoElement> <Info>k__BackingField281 = bestiaryEntry280.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry281;
				List<IBestiaryInfoElement> <Info>k__BackingField282 = bestiaryEntry281.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry282;
				List<IBestiaryInfoElement> <Info>k__BackingField283 = bestiaryEntry282.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry283;
				List<IBestiaryInfoElement> <Info>k__BackingField284 = bestiaryEntry283.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry284;
				List<IBestiaryInfoElement> <Info>k__BackingField285 = bestiaryEntry284.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry285;
				List<IBestiaryInfoElement> <Info>k__BackingField286 = bestiaryEntry285.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry286;
				List<IBestiaryInfoElement> <Info>k__BackingField287 = bestiaryEntry286.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry287;
				List<IBestiaryInfoElement> <Info>k__BackingField288 = bestiaryEntry287.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry288;
				List<IBestiaryInfoElement> <Info>k__BackingField289 = bestiaryEntry288.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry289;
				List<IBestiaryInfoElement> <Info>k__BackingField290 = bestiaryEntry289.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry290;
				List<IBestiaryInfoElement> <Info>k__BackingField291 = bestiaryEntry290.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry291;
				List<IBestiaryInfoElement> <Info>k__BackingField292 = bestiaryEntry291.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry292;
				List<IBestiaryInfoElement> <Info>k__BackingField293 = bestiaryEntry292.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry293;
				List<IBestiaryInfoElement> <Info>k__BackingField294 = bestiaryEntry293.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry294;
				List<IBestiaryInfoElement> <Info>k__BackingField295 = bestiaryEntry294.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry295;
				List<IBestiaryInfoElement> <Info>k__BackingField296 = bestiaryEntry295.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry296;
				List<IBestiaryInfoElement> <Info>k__BackingField297 = bestiaryEntry296.<Info>k__BackingField;
				BestiaryEntry bestiaryEntry297;
				List<IBestiaryInfoElement> <Info>k__BackingField298 = bestiaryEntry297.<Info>k__BackingField;
				if (false)
				{
					BestiaryEntry bestiaryEntry298;
					List<IBestiaryInfoElement> <Info>k__BackingField299 = bestiaryEntry298.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry299;
					List<IBestiaryInfoElement> <Info>k__BackingField300 = bestiaryEntry299.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry300;
					List<IBestiaryInfoElement> <Info>k__BackingField301 = bestiaryEntry300.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry301;
					List<IBestiaryInfoElement> <Info>k__BackingField302 = bestiaryEntry301.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry302;
					List<IBestiaryInfoElement> <Info>k__BackingField303 = bestiaryEntry302.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry303;
					List<IBestiaryInfoElement> <Info>k__BackingField304 = bestiaryEntry303.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry304;
					List<IBestiaryInfoElement> <Info>k__BackingField305 = bestiaryEntry304.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry305;
					List<IBestiaryInfoElement> <Info>k__BackingField306 = bestiaryEntry305.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry306;
					List<IBestiaryInfoElement> <Info>k__BackingField307 = bestiaryEntry306.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry307;
					List<IBestiaryInfoElement> <Info>k__BackingField308 = bestiaryEntry307.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry308;
					List<IBestiaryInfoElement> <Info>k__BackingField309 = bestiaryEntry308.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry309;
					List<IBestiaryInfoElement> <Info>k__BackingField310 = bestiaryEntry309.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry310;
					List<IBestiaryInfoElement> <Info>k__BackingField311 = bestiaryEntry310.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry311;
					List<IBestiaryInfoElement> <Info>k__BackingField312 = bestiaryEntry311.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry312;
					List<IBestiaryInfoElement> <Info>k__BackingField313 = bestiaryEntry312.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry313;
					List<IBestiaryInfoElement> <Info>k__BackingField314 = bestiaryEntry313.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry314;
					List<IBestiaryInfoElement> <Info>k__BackingField315 = bestiaryEntry314.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry315;
					List<IBestiaryInfoElement> <Info>k__BackingField316 = bestiaryEntry315.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry316;
					List<IBestiaryInfoElement> <Info>k__BackingField317 = bestiaryEntry316.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry317;
					List<IBestiaryInfoElement> <Info>k__BackingField318 = bestiaryEntry317.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry318;
					List<IBestiaryInfoElement> <Info>k__BackingField319 = bestiaryEntry318.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry319;
					List<IBestiaryInfoElement> <Info>k__BackingField320 = bestiaryEntry319.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry320;
					List<IBestiaryInfoElement> <Info>k__BackingField321 = bestiaryEntry320.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry321;
					List<IBestiaryInfoElement> <Info>k__BackingField322 = bestiaryEntry321.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry322;
					List<IBestiaryInfoElement> <Info>k__BackingField323 = bestiaryEntry322.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry323;
					List<IBestiaryInfoElement> <Info>k__BackingField324 = bestiaryEntry323.<Info>k__BackingField;
					if (false)
					{
						BestiaryEntry bestiaryEntry324;
						List<IBestiaryInfoElement> <Info>k__BackingField325 = bestiaryEntry324.<Info>k__BackingField;
						BestiaryEntry bestiaryEntry325;
						List<IBestiaryInfoElement> <Info>k__BackingField326 = bestiaryEntry325.<Info>k__BackingField;
						BestiaryEntry bestiaryEntry326;
						List<IBestiaryInfoElement> <Info>k__BackingField327 = bestiaryEntry326.<Info>k__BackingField;
						if (false)
						{
							BestiaryEntry bestiaryEntry327;
							List<IBestiaryInfoElement> <Info>k__BackingField328 = bestiaryEntry327.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry328;
							List<IBestiaryInfoElement> <Info>k__BackingField329 = bestiaryEntry328.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry329;
							List<IBestiaryInfoElement> <Info>k__BackingField330 = bestiaryEntry329.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry330;
							List<IBestiaryInfoElement> <Info>k__BackingField331 = bestiaryEntry330.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry331;
							List<IBestiaryInfoElement> <Info>k__BackingField332 = bestiaryEntry331.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry332;
							List<IBestiaryInfoElement> <Info>k__BackingField333 = bestiaryEntry332.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry333;
							List<IBestiaryInfoElement> <Info>k__BackingField334 = bestiaryEntry333.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry334;
							List<IBestiaryInfoElement> <Info>k__BackingField335 = bestiaryEntry334.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry335;
							List<IBestiaryInfoElement> <Info>k__BackingField336 = bestiaryEntry335.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry336;
							List<IBestiaryInfoElement> <Info>k__BackingField337 = bestiaryEntry336.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry337;
							List<IBestiaryInfoElement> <Info>k__BackingField338 = bestiaryEntry337.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry338;
							List<IBestiaryInfoElement> <Info>k__BackingField339 = bestiaryEntry338.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry339;
							List<IBestiaryInfoElement> <Info>k__BackingField340 = bestiaryEntry339.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry340;
							List<IBestiaryInfoElement> <Info>k__BackingField341 = bestiaryEntry340.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry341;
							List<IBestiaryInfoElement> <Info>k__BackingField342 = bestiaryEntry341.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry342;
							List<IBestiaryInfoElement> <Info>k__BackingField343 = bestiaryEntry342.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry343;
							List<IBestiaryInfoElement> <Info>k__BackingField344 = bestiaryEntry343.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry344;
							List<IBestiaryInfoElement> <Info>k__BackingField345 = bestiaryEntry344.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry345;
							List<IBestiaryInfoElement> <Info>k__BackingField346 = bestiaryEntry345.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry346;
							List<IBestiaryInfoElement> <Info>k__BackingField347 = bestiaryEntry346.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry347;
							List<IBestiaryInfoElement> <Info>k__BackingField348 = bestiaryEntry347.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry348;
							List<IBestiaryInfoElement> <Info>k__BackingField349 = bestiaryEntry348.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry349;
							List<IBestiaryInfoElement> <Info>k__BackingField350 = bestiaryEntry349.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry350;
							List<IBestiaryInfoElement> <Info>k__BackingField351 = bestiaryEntry350.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry351;
							List<IBestiaryInfoElement> <Info>k__BackingField352 = bestiaryEntry351.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry352;
							List<IBestiaryInfoElement> <Info>k__BackingField353 = bestiaryEntry352.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry353;
							List<IBestiaryInfoElement> <Info>k__BackingField354 = bestiaryEntry353.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry354;
							List<IBestiaryInfoElement> <Info>k__BackingField355 = bestiaryEntry354.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry355;
							List<IBestiaryInfoElement> <Info>k__BackingField356 = bestiaryEntry355.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry356;
							List<IBestiaryInfoElement> <Info>k__BackingField357 = bestiaryEntry356.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry357;
							List<IBestiaryInfoElement> <Info>k__BackingField358 = bestiaryEntry357.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry358;
							List<IBestiaryInfoElement> <Info>k__BackingField359 = bestiaryEntry358.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry359;
							List<IBestiaryInfoElement> <Info>k__BackingField360 = bestiaryEntry359.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry360;
							List<IBestiaryInfoElement> <Info>k__BackingField361 = bestiaryEntry360.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry361;
							List<IBestiaryInfoElement> <Info>k__BackingField362 = bestiaryEntry361.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry362;
							List<IBestiaryInfoElement> <Info>k__BackingField363 = bestiaryEntry362.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry363;
							List<IBestiaryInfoElement> <Info>k__BackingField364 = bestiaryEntry363.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry364;
							List<IBestiaryInfoElement> <Info>k__BackingField365 = bestiaryEntry364.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry365;
							List<IBestiaryInfoElement> <Info>k__BackingField366 = bestiaryEntry365.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry366;
							List<IBestiaryInfoElement> <Info>k__BackingField367 = bestiaryEntry366.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry367;
							List<IBestiaryInfoElement> <Info>k__BackingField368 = bestiaryEntry367.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry368;
							List<IBestiaryInfoElement> <Info>k__BackingField369 = bestiaryEntry368.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry369;
							List<IBestiaryInfoElement> <Info>k__BackingField370 = bestiaryEntry369.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry370;
							List<IBestiaryInfoElement> <Info>k__BackingField371 = bestiaryEntry370.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry371;
							List<IBestiaryInfoElement> <Info>k__BackingField372 = bestiaryEntry371.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry372;
							List<IBestiaryInfoElement> <Info>k__BackingField373 = bestiaryEntry372.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry373;
							List<IBestiaryInfoElement> <Info>k__BackingField374 = bestiaryEntry373.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry374;
							List<IBestiaryInfoElement> <Info>k__BackingField375 = bestiaryEntry374.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry375;
							List<IBestiaryInfoElement> <Info>k__BackingField376 = bestiaryEntry375.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry376;
							List<IBestiaryInfoElement> <Info>k__BackingField377 = bestiaryEntry376.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry377;
							List<IBestiaryInfoElement> <Info>k__BackingField378 = bestiaryEntry377.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry378;
							List<IBestiaryInfoElement> <Info>k__BackingField379 = bestiaryEntry378.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry379;
							List<IBestiaryInfoElement> <Info>k__BackingField380 = bestiaryEntry379.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry380;
							List<IBestiaryInfoElement> <Info>k__BackingField381 = bestiaryEntry380.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry381;
							List<IBestiaryInfoElement> <Info>k__BackingField382 = bestiaryEntry381.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry382;
							List<IBestiaryInfoElement> <Info>k__BackingField383 = bestiaryEntry382.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry383;
							List<IBestiaryInfoElement> <Info>k__BackingField384 = bestiaryEntry383.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry384;
							List<IBestiaryInfoElement> <Info>k__BackingField385 = bestiaryEntry384.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry385;
							List<IBestiaryInfoElement> <Info>k__BackingField386 = bestiaryEntry385.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry386;
							List<IBestiaryInfoElement> <Info>k__BackingField387 = bestiaryEntry386.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry387;
							List<IBestiaryInfoElement> <Info>k__BackingField388 = bestiaryEntry387.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry388;
							List<IBestiaryInfoElement> <Info>k__BackingField389 = bestiaryEntry388.<Info>k__BackingField;
							BestiaryEntry bestiaryEntry389;
							List<IBestiaryInfoElement> <Info>k__BackingField390 = bestiaryEntry389.<Info>k__BackingField;
							if (false)
							{
								BestiaryEntry bestiaryEntry390;
								List<IBestiaryInfoElement> <Info>k__BackingField391 = bestiaryEntry390.<Info>k__BackingField;
								BestiaryEntry bestiaryEntry391;
								List<IBestiaryInfoElement> <Info>k__BackingField392 = bestiaryEntry391.<Info>k__BackingField;
								BestiaryEntry bestiaryEntry392;
								List<IBestiaryInfoElement> <Info>k__BackingField393 = bestiaryEntry392.<Info>k__BackingField;
								BestiaryEntry bestiaryEntry393;
								List<IBestiaryInfoElement> <Info>k__BackingField394 = bestiaryEntry393.<Info>k__BackingField;
								BestiaryEntry bestiaryEntry394;
								List<IBestiaryInfoElement> <Info>k__BackingField395 = bestiaryEntry394.<Info>k__BackingField;
								BestiaryEntry bestiaryEntry395;
								List<IBestiaryInfoElement> <Info>k__BackingField396 = bestiaryEntry395.<Info>k__BackingField;
								BestiaryEntry bestiaryEntry396;
								List<IBestiaryInfoElement> <Info>k__BackingField397 = bestiaryEntry396.<Info>k__BackingField;
								BestiaryEntry bestiaryEntry397;
								List<IBestiaryInfoElement> <Info>k__BackingField398 = bestiaryEntry397.<Info>k__BackingField;
								BestiaryEntry bestiaryEntry398;
								List<IBestiaryInfoElement> <Info>k__BackingField399 = bestiaryEntry398.<Info>k__BackingField;
								BestiaryEntry bestiaryEntry399;
								List<IBestiaryInfoElement> <Info>k__BackingField400 = bestiaryEntry399.<Info>k__BackingField;
								BestiaryEntry bestiaryEntry400;
								List<IBestiaryInfoElement> <Info>k__BackingField401 = bestiaryEntry400.<Info>k__BackingField;
								BestiaryEntry bestiaryEntry401;
								List<IBestiaryInfoElement> <Info>k__BackingField402 = bestiaryEntry401.<Info>k__BackingField;
								BestiaryEntry bestiaryEntry402;
								List<IBestiaryInfoElement> <Info>k__BackingField403 = bestiaryEntry402.<Info>k__BackingField;
								BestiaryEntry bestiaryEntry403;
								List<IBestiaryInfoElement> <Info>k__BackingField404 = bestiaryEntry403.<Info>k__BackingField;
								BestiaryEntry bestiaryEntry404;
								List<IBestiaryInfoElement> <Info>k__BackingField405 = bestiaryEntry404.<Info>k__BackingField;
								BestiaryEntry bestiaryEntry405;
								List<IBestiaryInfoElement> <Info>k__BackingField406 = bestiaryEntry405.<Info>k__BackingField;
								BestiaryEntry bestiaryEntry406;
								List<IBestiaryInfoElement> <Info>k__BackingField407 = bestiaryEntry406.<Info>k__BackingField;
								BestiaryEntry bestiaryEntry407;
								List<IBestiaryInfoElement> <Info>k__BackingField408 = bestiaryEntry407.<Info>k__BackingField;
								BestiaryEntry bestiaryEntry408;
								List<IBestiaryInfoElement> <Info>k__BackingField409 = bestiaryEntry408.<Info>k__BackingField;
								BestiaryEntry bestiaryEntry409;
								List<IBestiaryInfoElement> <Info>k__BackingField410 = bestiaryEntry409.<Info>k__BackingField;
								BestiaryEntry bestiaryEntry410;
								List<IBestiaryInfoElement> <Info>k__BackingField411 = bestiaryEntry410.<Info>k__BackingField;
								BestiaryEntry bestiaryEntry411;
								List<IBestiaryInfoElement> <Info>k__BackingField412 = bestiaryEntry411.<Info>k__BackingField;
								BestiaryEntry bestiaryEntry412;
								List<IBestiaryInfoElement> <Info>k__BackingField413 = bestiaryEntry412.<Info>k__BackingField;
								BestiaryEntry bestiaryEntry413;
								List<IBestiaryInfoElement> <Info>k__BackingField414 = bestiaryEntry413.<Info>k__BackingField;
								BestiaryEntry bestiaryEntry414;
								List<IBestiaryInfoElement> <Info>k__BackingField415 = bestiaryEntry414.<Info>k__BackingField;
								BestiaryEntry bestiaryEntry415;
								List<IBestiaryInfoElement> <Info>k__BackingField416 = bestiaryEntry415.<Info>k__BackingField;
								BestiaryEntry bestiaryEntry416;
								List<IBestiaryInfoElement> <Info>k__BackingField417 = bestiaryEntry416.<Info>k__BackingField;
								BestiaryEntry bestiaryEntry417;
								List<IBestiaryInfoElement> <Info>k__BackingField418 = bestiaryEntry417.<Info>k__BackingField;
								if (false)
								{
									BestiaryEntry bestiaryEntry418;
									List<IBestiaryInfoElement> <Info>k__BackingField419 = bestiaryEntry418.<Info>k__BackingField;
									BestiaryEntry bestiaryEntry419;
									List<IBestiaryInfoElement> <Info>k__BackingField420 = bestiaryEntry419.<Info>k__BackingField;
									BestiaryEntry bestiaryEntry420;
									List<IBestiaryInfoElement> <Info>k__BackingField421 = bestiaryEntry420.<Info>k__BackingField;
									BestiaryEntry bestiaryEntry421;
									List<IBestiaryInfoElement> <Info>k__BackingField422 = bestiaryEntry421.<Info>k__BackingField;
									BestiaryEntry bestiaryEntry422;
									List<IBestiaryInfoElement> <Info>k__BackingField423 = bestiaryEntry422.<Info>k__BackingField;
									BestiaryEntry bestiaryEntry423;
									List<IBestiaryInfoElement> <Info>k__BackingField424 = bestiaryEntry423.<Info>k__BackingField;
									BestiaryEntry bestiaryEntry424;
									List<IBestiaryInfoElement> <Info>k__BackingField425 = bestiaryEntry424.<Info>k__BackingField;
									BestiaryEntry bestiaryEntry425;
									List<IBestiaryInfoElement> <Info>k__BackingField426 = bestiaryEntry425.<Info>k__BackingField;
									BestiaryEntry bestiaryEntry426;
									List<IBestiaryInfoElement> <Info>k__BackingField427 = bestiaryEntry426.<Info>k__BackingField;
									BestiaryEntry bestiaryEntry427;
									List<IBestiaryInfoElement> <Info>k__BackingField428 = bestiaryEntry427.<Info>k__BackingField;
									BestiaryEntry bestiaryEntry428;
									List<IBestiaryInfoElement> <Info>k__BackingField429 = bestiaryEntry428.<Info>k__BackingField;
									BestiaryEntry bestiaryEntry429;
									List<IBestiaryInfoElement> <Info>k__BackingField430 = bestiaryEntry429.<Info>k__BackingField;
									BestiaryEntry bestiaryEntry430;
									List<IBestiaryInfoElement> <Info>k__BackingField431 = bestiaryEntry430.<Info>k__BackingField;
									BestiaryEntry bestiaryEntry431;
									List<IBestiaryInfoElement> <Info>k__BackingField432 = bestiaryEntry431.<Info>k__BackingField;
									BestiaryEntry bestiaryEntry432;
									List<IBestiaryInfoElement> <Info>k__BackingField433 = bestiaryEntry432.<Info>k__BackingField;
									BestiaryEntry bestiaryEntry433;
									List<IBestiaryInfoElement> <Info>k__BackingField434 = bestiaryEntry433.<Info>k__BackingField;
									BestiaryEntry bestiaryEntry434;
									List<IBestiaryInfoElement> <Info>k__BackingField435 = bestiaryEntry434.<Info>k__BackingField;
									BestiaryEntry bestiaryEntry435;
									List<IBestiaryInfoElement> <Info>k__BackingField436 = bestiaryEntry435.<Info>k__BackingField;
									BestiaryEntry bestiaryEntry436;
									List<IBestiaryInfoElement> <Info>k__BackingField437 = bestiaryEntry436.<Info>k__BackingField;
									BestiaryEntry bestiaryEntry437;
									List<IBestiaryInfoElement> <Info>k__BackingField438 = bestiaryEntry437.<Info>k__BackingField;
									BestiaryEntry bestiaryEntry438;
									List<IBestiaryInfoElement> <Info>k__BackingField439 = bestiaryEntry438.<Info>k__BackingField;
									if (false)
									{
										BestiaryEntry bestiaryEntry439;
										List<IBestiaryInfoElement> <Info>k__BackingField440 = bestiaryEntry439.<Info>k__BackingField;
										BestiaryEntry bestiaryEntry440;
										List<IBestiaryInfoElement> <Info>k__BackingField441 = bestiaryEntry440.<Info>k__BackingField;
										BestiaryEntry bestiaryEntry441;
										List<IBestiaryInfoElement> <Info>k__BackingField442 = bestiaryEntry441.<Info>k__BackingField;
										BestiaryEntry bestiaryEntry442;
										List<IBestiaryInfoElement> <Info>k__BackingField443 = bestiaryEntry442.<Info>k__BackingField;
										if (false)
										{
											BestiaryEntry bestiaryEntry443;
											List<IBestiaryInfoElement> <Info>k__BackingField444 = bestiaryEntry443.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry444;
											List<IBestiaryInfoElement> <Info>k__BackingField445 = bestiaryEntry444.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry445;
											List<IBestiaryInfoElement> <Info>k__BackingField446 = bestiaryEntry445.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry446;
											List<IBestiaryInfoElement> <Info>k__BackingField447 = bestiaryEntry446.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry447;
											List<IBestiaryInfoElement> <Info>k__BackingField448 = bestiaryEntry447.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry448;
											List<IBestiaryInfoElement> <Info>k__BackingField449 = bestiaryEntry448.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry449;
											List<IBestiaryInfoElement> <Info>k__BackingField450 = bestiaryEntry449.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry450;
											List<IBestiaryInfoElement> <Info>k__BackingField451 = bestiaryEntry450.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry451;
											List<IBestiaryInfoElement> <Info>k__BackingField452 = bestiaryEntry451.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry452;
											List<IBestiaryInfoElement> <Info>k__BackingField453 = bestiaryEntry452.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry453;
											List<IBestiaryInfoElement> <Info>k__BackingField454 = bestiaryEntry453.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry454;
											List<IBestiaryInfoElement> <Info>k__BackingField455 = bestiaryEntry454.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry455;
											List<IBestiaryInfoElement> <Info>k__BackingField456 = bestiaryEntry455.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry456;
											List<IBestiaryInfoElement> <Info>k__BackingField457 = bestiaryEntry456.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry457;
											List<IBestiaryInfoElement> <Info>k__BackingField458 = bestiaryEntry457.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry458;
											List<IBestiaryInfoElement> <Info>k__BackingField459 = bestiaryEntry458.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry459;
											List<IBestiaryInfoElement> <Info>k__BackingField460 = bestiaryEntry459.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry460;
											List<IBestiaryInfoElement> <Info>k__BackingField461 = bestiaryEntry460.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry461;
											List<IBestiaryInfoElement> <Info>k__BackingField462 = bestiaryEntry461.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry462;
											List<IBestiaryInfoElement> <Info>k__BackingField463 = bestiaryEntry462.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry463;
											List<IBestiaryInfoElement> <Info>k__BackingField464 = bestiaryEntry463.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry464;
											List<IBestiaryInfoElement> <Info>k__BackingField465 = bestiaryEntry464.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry465;
											List<IBestiaryInfoElement> <Info>k__BackingField466 = bestiaryEntry465.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry466;
											List<IBestiaryInfoElement> <Info>k__BackingField467 = bestiaryEntry466.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry467;
											List<IBestiaryInfoElement> <Info>k__BackingField468 = bestiaryEntry467.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry468;
											List<IBestiaryInfoElement> <Info>k__BackingField469 = bestiaryEntry468.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry469;
											List<IBestiaryInfoElement> <Info>k__BackingField470 = bestiaryEntry469.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry470;
											List<IBestiaryInfoElement> <Info>k__BackingField471 = bestiaryEntry470.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry471;
											List<IBestiaryInfoElement> <Info>k__BackingField472 = bestiaryEntry471.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry472;
											List<IBestiaryInfoElement> <Info>k__BackingField473 = bestiaryEntry472.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry473;
											List<IBestiaryInfoElement> <Info>k__BackingField474 = bestiaryEntry473.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry474;
											List<IBestiaryInfoElement> <Info>k__BackingField475 = bestiaryEntry474.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry475;
											List<IBestiaryInfoElement> <Info>k__BackingField476 = bestiaryEntry475.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry476;
											List<IBestiaryInfoElement> <Info>k__BackingField477 = bestiaryEntry476.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry477;
											List<IBestiaryInfoElement> <Info>k__BackingField478 = bestiaryEntry477.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry478;
											List<IBestiaryInfoElement> <Info>k__BackingField479 = bestiaryEntry478.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry479;
											List<IBestiaryInfoElement> <Info>k__BackingField480 = bestiaryEntry479.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry480;
											List<IBestiaryInfoElement> <Info>k__BackingField481 = bestiaryEntry480.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry481;
											List<IBestiaryInfoElement> <Info>k__BackingField482 = bestiaryEntry481.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry482;
											List<IBestiaryInfoElement> <Info>k__BackingField483 = bestiaryEntry482.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry483;
											List<IBestiaryInfoElement> <Info>k__BackingField484 = bestiaryEntry483.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry484;
											List<IBestiaryInfoElement> <Info>k__BackingField485 = bestiaryEntry484.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry485;
											List<IBestiaryInfoElement> <Info>k__BackingField486 = bestiaryEntry485.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry486;
											List<IBestiaryInfoElement> <Info>k__BackingField487 = bestiaryEntry486.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry487;
											List<IBestiaryInfoElement> <Info>k__BackingField488 = bestiaryEntry487.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry488;
											List<IBestiaryInfoElement> <Info>k__BackingField489 = bestiaryEntry488.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry489;
											List<IBestiaryInfoElement> <Info>k__BackingField490 = bestiaryEntry489.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry490;
											List<IBestiaryInfoElement> <Info>k__BackingField491 = bestiaryEntry490.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry491;
											List<IBestiaryInfoElement> <Info>k__BackingField492 = bestiaryEntry491.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry492;
											List<IBestiaryInfoElement> <Info>k__BackingField493 = bestiaryEntry492.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry493;
											List<IBestiaryInfoElement> <Info>k__BackingField494 = bestiaryEntry493.<Info>k__BackingField;
											BestiaryEntry bestiaryEntry494;
											List<IBestiaryInfoElement> <Info>k__BackingField495 = bestiaryEntry494.<Info>k__BackingField;
											if (false)
											{
												BestiaryEntry bestiaryEntry495;
												List<IBestiaryInfoElement> <Info>k__BackingField496 = bestiaryEntry495.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry496;
												List<IBestiaryInfoElement> <Info>k__BackingField497 = bestiaryEntry496.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry497;
												List<IBestiaryInfoElement> <Info>k__BackingField498 = bestiaryEntry497.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry498;
												List<IBestiaryInfoElement> <Info>k__BackingField499 = bestiaryEntry498.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry499;
												List<IBestiaryInfoElement> <Info>k__BackingField500 = bestiaryEntry499.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry500;
												List<IBestiaryInfoElement> <Info>k__BackingField501 = bestiaryEntry500.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry501;
												List<IBestiaryInfoElement> <Info>k__BackingField502 = bestiaryEntry501.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry502;
												List<IBestiaryInfoElement> <Info>k__BackingField503 = bestiaryEntry502.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry503;
												List<IBestiaryInfoElement> <Info>k__BackingField504 = bestiaryEntry503.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry504;
												List<IBestiaryInfoElement> <Info>k__BackingField505 = bestiaryEntry504.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry505;
												List<IBestiaryInfoElement> <Info>k__BackingField506 = bestiaryEntry505.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry506;
												List<IBestiaryInfoElement> <Info>k__BackingField507 = bestiaryEntry506.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry507;
												List<IBestiaryInfoElement> <Info>k__BackingField508 = bestiaryEntry507.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry508;
												List<IBestiaryInfoElement> <Info>k__BackingField509 = bestiaryEntry508.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry509;
												List<IBestiaryInfoElement> <Info>k__BackingField510 = bestiaryEntry509.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry510;
												List<IBestiaryInfoElement> <Info>k__BackingField511 = bestiaryEntry510.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry511;
												List<IBestiaryInfoElement> <Info>k__BackingField512 = bestiaryEntry511.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry512;
												List<IBestiaryInfoElement> <Info>k__BackingField513 = bestiaryEntry512.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry513;
												List<IBestiaryInfoElement> <Info>k__BackingField514 = bestiaryEntry513.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry514;
												List<IBestiaryInfoElement> <Info>k__BackingField515 = bestiaryEntry514.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry515;
												List<IBestiaryInfoElement> <Info>k__BackingField516 = bestiaryEntry515.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry516;
												List<IBestiaryInfoElement> <Info>k__BackingField517 = bestiaryEntry516.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry517;
												List<IBestiaryInfoElement> <Info>k__BackingField518 = bestiaryEntry517.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry518;
												List<IBestiaryInfoElement> <Info>k__BackingField519 = bestiaryEntry518.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry519;
												List<IBestiaryInfoElement> <Info>k__BackingField520 = bestiaryEntry519.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry520;
												List<IBestiaryInfoElement> <Info>k__BackingField521 = bestiaryEntry520.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry521;
												List<IBestiaryInfoElement> <Info>k__BackingField522 = bestiaryEntry521.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry522;
												List<IBestiaryInfoElement> <Info>k__BackingField523 = bestiaryEntry522.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry523;
												List<IBestiaryInfoElement> <Info>k__BackingField524 = bestiaryEntry523.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry524;
												List<IBestiaryInfoElement> <Info>k__BackingField525 = bestiaryEntry524.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry525;
												List<IBestiaryInfoElement> <Info>k__BackingField526 = bestiaryEntry525.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry526;
												List<IBestiaryInfoElement> <Info>k__BackingField527 = bestiaryEntry526.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry527;
												List<IBestiaryInfoElement> <Info>k__BackingField528 = bestiaryEntry527.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry528;
												List<IBestiaryInfoElement> <Info>k__BackingField529 = bestiaryEntry528.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry529;
												List<IBestiaryInfoElement> <Info>k__BackingField530 = bestiaryEntry529.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry530;
												List<IBestiaryInfoElement> <Info>k__BackingField531 = bestiaryEntry530.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry531;
												List<IBestiaryInfoElement> <Info>k__BackingField532 = bestiaryEntry531.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry532;
												List<IBestiaryInfoElement> <Info>k__BackingField533 = bestiaryEntry532.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry533;
												List<IBestiaryInfoElement> <Info>k__BackingField534 = bestiaryEntry533.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry534;
												List<IBestiaryInfoElement> <Info>k__BackingField535 = bestiaryEntry534.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry535;
												List<IBestiaryInfoElement> <Info>k__BackingField536 = bestiaryEntry535.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry536;
												List<IBestiaryInfoElement> <Info>k__BackingField537 = bestiaryEntry536.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry537;
												List<IBestiaryInfoElement> <Info>k__BackingField538 = bestiaryEntry537.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry538;
												List<IBestiaryInfoElement> <Info>k__BackingField539 = bestiaryEntry538.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry539;
												List<IBestiaryInfoElement> <Info>k__BackingField540 = bestiaryEntry539.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry540;
												List<IBestiaryInfoElement> <Info>k__BackingField541 = bestiaryEntry540.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry541;
												List<IBestiaryInfoElement> <Info>k__BackingField542 = bestiaryEntry541.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry542;
												List<IBestiaryInfoElement> <Info>k__BackingField543 = bestiaryEntry542.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry543;
												List<IBestiaryInfoElement> <Info>k__BackingField544 = bestiaryEntry543.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry544;
												List<IBestiaryInfoElement> <Info>k__BackingField545 = bestiaryEntry544.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry545;
												List<IBestiaryInfoElement> <Info>k__BackingField546 = bestiaryEntry545.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry546;
												List<IBestiaryInfoElement> <Info>k__BackingField547 = bestiaryEntry546.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry547;
												List<IBestiaryInfoElement> <Info>k__BackingField548 = bestiaryEntry547.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry548;
												List<IBestiaryInfoElement> <Info>k__BackingField549 = bestiaryEntry548.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry549;
												List<IBestiaryInfoElement> <Info>k__BackingField550 = bestiaryEntry549.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry550;
												List<IBestiaryInfoElement> <Info>k__BackingField551 = bestiaryEntry550.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry551;
												List<IBestiaryInfoElement> <Info>k__BackingField552 = bestiaryEntry551.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry552;
												List<IBestiaryInfoElement> <Info>k__BackingField553 = bestiaryEntry552.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry553;
												List<IBestiaryInfoElement> <Info>k__BackingField554 = bestiaryEntry553.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry554;
												List<IBestiaryInfoElement> <Info>k__BackingField555 = bestiaryEntry554.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry555;
												List<IBestiaryInfoElement> <Info>k__BackingField556 = bestiaryEntry555.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry556;
												List<IBestiaryInfoElement> <Info>k__BackingField557 = bestiaryEntry556.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry557;
												List<IBestiaryInfoElement> <Info>k__BackingField558 = bestiaryEntry557.<Info>k__BackingField;
												BestiaryEntry bestiaryEntry558;
												List<IBestiaryInfoElement> <Info>k__BackingField559 = bestiaryEntry558.<Info>k__BackingField;
												if (false)
												{
													BestiaryEntry bestiaryEntry559;
													List<IBestiaryInfoElement> <Info>k__BackingField560 = bestiaryEntry559.<Info>k__BackingField;
													BestiaryEntry bestiaryEntry560;
													List<IBestiaryInfoElement> <Info>k__BackingField561 = bestiaryEntry560.<Info>k__BackingField;
													BestiaryEntry bestiaryEntry561;
													List<IBestiaryInfoElement> <Info>k__BackingField562 = bestiaryEntry561.<Info>k__BackingField;
													if (false)
													{
														BestiaryEntry bestiaryEntry562;
														List<IBestiaryInfoElement> <Info>k__BackingField563 = bestiaryEntry562.<Info>k__BackingField;
														BestiaryEntry bestiaryEntry563;
														List<IBestiaryInfoElement> <Info>k__BackingField564 = bestiaryEntry563.<Info>k__BackingField;
														BestiaryEntry bestiaryEntry564;
														List<IBestiaryInfoElement> <Info>k__BackingField565 = bestiaryEntry564.<Info>k__BackingField;
														BestiaryEntry bestiaryEntry565;
														List<IBestiaryInfoElement> <Info>k__BackingField566 = bestiaryEntry565.<Info>k__BackingField;
														BestiaryEntry bestiaryEntry566;
														List<IBestiaryInfoElement> <Info>k__BackingField567 = bestiaryEntry566.<Info>k__BackingField;
														BestiaryEntry bestiaryEntry567;
														List<IBestiaryInfoElement> <Info>k__BackingField568 = bestiaryEntry567.<Info>k__BackingField;
														BestiaryEntry bestiaryEntry568;
														List<IBestiaryInfoElement> <Info>k__BackingField569 = bestiaryEntry568.<Info>k__BackingField;
														if (false)
														{
															BestiaryEntry bestiaryEntry569;
															List<IBestiaryInfoElement> <Info>k__BackingField570 = bestiaryEntry569.<Info>k__BackingField;
															BestiaryEntry bestiaryEntry570;
															List<IBestiaryInfoElement> <Info>k__BackingField571 = bestiaryEntry570.<Info>k__BackingField;
															BestiaryEntry bestiaryEntry571;
															List<IBestiaryInfoElement> <Info>k__BackingField572 = bestiaryEntry571.<Info>k__BackingField;
															BestiaryEntry bestiaryEntry572;
															List<IBestiaryInfoElement> <Info>k__BackingField573 = bestiaryEntry572.<Info>k__BackingField;
															BestiaryEntry bestiaryEntry573;
															List<IBestiaryInfoElement> <Info>k__BackingField574 = bestiaryEntry573.<Info>k__BackingField;
															BestiaryEntry bestiaryEntry574;
															List<IBestiaryInfoElement> <Info>k__BackingField575 = bestiaryEntry574.<Info>k__BackingField;
															if (!false || false)
															{
																return;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060046F9 RID: 18169 RVA: 0x0025D5FC File Offset: 0x0025B7FC
		private void AddNPCBiomeRelationships_Manual()
		{
			List<IBestiaryInfoElement> <Info>k__BackingField = this._currentDatabase.FindEntryByNPCID(628).<Info>k__BackingField;
			BestiaryEntry bestiaryEntry;
			List<IBestiaryInfoElement> <Info>k__BackingField2 = bestiaryEntry.<Info>k__BackingField;
			if (!false)
			{
			}
			if (!false || false)
			{
				BestiaryEntry bestiaryEntry2;
				List<IBestiaryInfoElement> <Info>k__BackingField3 = bestiaryEntry2.<Info>k__BackingField;
				if (!false || false)
				{
					BestiaryEntry bestiaryEntry3;
					List<IBestiaryInfoElement> <Info>k__BackingField4 = bestiaryEntry3.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry4;
					List<IBestiaryInfoElement> <Info>k__BackingField5 = bestiaryEntry4.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry5;
					List<IBestiaryInfoElement> <Info>k__BackingField6 = bestiaryEntry5.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry6;
					List<IBestiaryInfoElement> <Info>k__BackingField7 = bestiaryEntry6.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry7;
					List<IBestiaryInfoElement> <Info>k__BackingField8 = bestiaryEntry7.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry8;
					List<IBestiaryInfoElement> <Info>k__BackingField9 = bestiaryEntry8.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry9;
					List<IBestiaryInfoElement> <Info>k__BackingField10 = bestiaryEntry9.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry10;
					List<IBestiaryInfoElement> <Info>k__BackingField11 = bestiaryEntry10.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry11;
					List<IBestiaryInfoElement> <Info>k__BackingField12 = bestiaryEntry11.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry12;
					List<IBestiaryInfoElement> <Info>k__BackingField13 = bestiaryEntry12.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry13;
					List<IBestiaryInfoElement> <Info>k__BackingField14 = bestiaryEntry13.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry14;
					List<IBestiaryInfoElement> <Info>k__BackingField15 = bestiaryEntry14.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry15;
					List<IBestiaryInfoElement> <Info>k__BackingField16 = bestiaryEntry15.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry16;
					List<IBestiaryInfoElement> <Info>k__BackingField17 = bestiaryEntry16.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry17;
					List<IBestiaryInfoElement> <Info>k__BackingField18 = bestiaryEntry17.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry18;
					List<IBestiaryInfoElement> <Info>k__BackingField19 = bestiaryEntry18.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry19;
					List<IBestiaryInfoElement> <Info>k__BackingField20 = bestiaryEntry19.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry20;
					List<IBestiaryInfoElement> <Info>k__BackingField21 = bestiaryEntry20.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry21;
					List<IBestiaryInfoElement> <Info>k__BackingField22 = bestiaryEntry21.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry22;
					List<IBestiaryInfoElement> <Info>k__BackingField23 = bestiaryEntry22.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry23;
					List<IBestiaryInfoElement> <Info>k__BackingField24 = bestiaryEntry23.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry24;
					List<IBestiaryInfoElement> <Info>k__BackingField25 = bestiaryEntry24.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry25;
					List<IBestiaryInfoElement> <Info>k__BackingField26 = bestiaryEntry25.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry26;
					List<IBestiaryInfoElement> <Info>k__BackingField27 = bestiaryEntry26.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry27;
					List<IBestiaryInfoElement> <Info>k__BackingField28 = bestiaryEntry27.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry28;
					List<IBestiaryInfoElement> <Info>k__BackingField29 = bestiaryEntry28.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry29;
					List<IBestiaryInfoElement> <Info>k__BackingField30 = bestiaryEntry29.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry30;
					List<IBestiaryInfoElement> <Info>k__BackingField31 = bestiaryEntry30.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry31;
					List<IBestiaryInfoElement> <Info>k__BackingField32 = bestiaryEntry31.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry32;
					List<IBestiaryInfoElement> <Info>k__BackingField33 = bestiaryEntry32.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry33;
					List<IBestiaryInfoElement> <Info>k__BackingField34 = bestiaryEntry33.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry34;
					List<IBestiaryInfoElement> <Info>k__BackingField35 = bestiaryEntry34.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry35;
					List<IBestiaryInfoElement> <Info>k__BackingField36 = bestiaryEntry35.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry36;
					List<IBestiaryInfoElement> <Info>k__BackingField37 = bestiaryEntry36.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry37;
					List<IBestiaryInfoElement> <Info>k__BackingField38 = bestiaryEntry37.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry38;
					List<IBestiaryInfoElement> <Info>k__BackingField39 = bestiaryEntry38.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry39;
					List<IBestiaryInfoElement> <Info>k__BackingField40 = bestiaryEntry39.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry40;
					List<IBestiaryInfoElement> <Info>k__BackingField41 = bestiaryEntry40.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry41;
					List<IBestiaryInfoElement> <Info>k__BackingField42 = bestiaryEntry41.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry42;
					List<IBestiaryInfoElement> <Info>k__BackingField43 = bestiaryEntry42.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry43;
					List<IBestiaryInfoElement> <Info>k__BackingField44 = bestiaryEntry43.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry44;
					List<IBestiaryInfoElement> <Info>k__BackingField45 = bestiaryEntry44.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry45;
					List<IBestiaryInfoElement> <Info>k__BackingField46 = bestiaryEntry45.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry46;
					List<IBestiaryInfoElement> <Info>k__BackingField47 = bestiaryEntry46.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry47;
					List<IBestiaryInfoElement> <Info>k__BackingField48 = bestiaryEntry47.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry48;
					List<IBestiaryInfoElement> <Info>k__BackingField49 = bestiaryEntry48.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry49;
					List<IBestiaryInfoElement> <Info>k__BackingField50 = bestiaryEntry49.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry50;
					List<IBestiaryInfoElement> <Info>k__BackingField51 = bestiaryEntry50.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry51;
					List<IBestiaryInfoElement> <Info>k__BackingField52 = bestiaryEntry51.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry52;
					List<IBestiaryInfoElement> <Info>k__BackingField53 = bestiaryEntry52.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry53;
					List<IBestiaryInfoElement> <Info>k__BackingField54 = bestiaryEntry53.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry54;
					List<IBestiaryInfoElement> <Info>k__BackingField55 = bestiaryEntry54.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry55;
					List<IBestiaryInfoElement> <Info>k__BackingField56 = bestiaryEntry55.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry56;
					List<IBestiaryInfoElement> <Info>k__BackingField57 = bestiaryEntry56.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry57;
					List<IBestiaryInfoElement> <Info>k__BackingField58 = bestiaryEntry57.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry58;
					List<IBestiaryInfoElement> <Info>k__BackingField59 = bestiaryEntry58.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry59;
					List<IBestiaryInfoElement> <Info>k__BackingField60 = bestiaryEntry59.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry60;
					List<IBestiaryInfoElement> <Info>k__BackingField61 = bestiaryEntry60.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry61;
					List<IBestiaryInfoElement> <Info>k__BackingField62 = bestiaryEntry61.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry62;
					List<IBestiaryInfoElement> <Info>k__BackingField63 = bestiaryEntry62.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry63;
					List<IBestiaryInfoElement> <Info>k__BackingField64 = bestiaryEntry63.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry64;
					List<IBestiaryInfoElement> <Info>k__BackingField65 = bestiaryEntry64.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry65;
					List<IBestiaryInfoElement> <Info>k__BackingField66 = bestiaryEntry65.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry66;
					List<IBestiaryInfoElement> <Info>k__BackingField67 = bestiaryEntry66.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry67;
					List<IBestiaryInfoElement> <Info>k__BackingField68 = bestiaryEntry67.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry68;
					List<IBestiaryInfoElement> <Info>k__BackingField69 = bestiaryEntry68.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry69;
					List<IBestiaryInfoElement> <Info>k__BackingField70 = bestiaryEntry69.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry70;
					List<IBestiaryInfoElement> <Info>k__BackingField71 = bestiaryEntry70.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry71;
					List<IBestiaryInfoElement> <Info>k__BackingField72 = bestiaryEntry71.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry72;
					List<IBestiaryInfoElement> <Info>k__BackingField73 = bestiaryEntry72.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry73;
					List<IBestiaryInfoElement> <Info>k__BackingField74 = bestiaryEntry73.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry74;
					List<IBestiaryInfoElement> <Info>k__BackingField75 = bestiaryEntry74.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry75;
					List<IBestiaryInfoElement> <Info>k__BackingField76 = bestiaryEntry75.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry76;
					List<IBestiaryInfoElement> <Info>k__BackingField77 = bestiaryEntry76.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry77;
					List<IBestiaryInfoElement> <Info>k__BackingField78 = bestiaryEntry77.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry78;
					List<IBestiaryInfoElement> <Info>k__BackingField79 = bestiaryEntry78.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry79;
					List<IBestiaryInfoElement> <Info>k__BackingField80 = bestiaryEntry79.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry80;
					List<IBestiaryInfoElement> <Info>k__BackingField81 = bestiaryEntry80.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry81;
					List<IBestiaryInfoElement> <Info>k__BackingField82 = bestiaryEntry81.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry82;
					List<IBestiaryInfoElement> <Info>k__BackingField83 = bestiaryEntry82.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry83;
					List<IBestiaryInfoElement> <Info>k__BackingField84 = bestiaryEntry83.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry84;
					List<IBestiaryInfoElement> <Info>k__BackingField85 = bestiaryEntry84.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry85;
					List<IBestiaryInfoElement> <Info>k__BackingField86 = bestiaryEntry85.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry86;
					List<IBestiaryInfoElement> <Info>k__BackingField87 = bestiaryEntry86.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry87;
					List<IBestiaryInfoElement> <Info>k__BackingField88 = bestiaryEntry87.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry88;
					List<IBestiaryInfoElement> <Info>k__BackingField89 = bestiaryEntry88.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry89;
					List<IBestiaryInfoElement> <Info>k__BackingField90 = bestiaryEntry89.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry90;
					List<IBestiaryInfoElement> <Info>k__BackingField91 = bestiaryEntry90.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry91;
					List<IBestiaryInfoElement> <Info>k__BackingField92 = bestiaryEntry91.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry92;
					List<IBestiaryInfoElement> <Info>k__BackingField93 = bestiaryEntry92.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry93;
					List<IBestiaryInfoElement> <Info>k__BackingField94 = bestiaryEntry93.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry94;
					List<IBestiaryInfoElement> <Info>k__BackingField95 = bestiaryEntry94.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry95;
					List<IBestiaryInfoElement> <Info>k__BackingField96 = bestiaryEntry95.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry96;
					List<IBestiaryInfoElement> <Info>k__BackingField97 = bestiaryEntry96.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry97;
					List<IBestiaryInfoElement> <Info>k__BackingField98 = bestiaryEntry97.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry98;
					List<IBestiaryInfoElement> <Info>k__BackingField99 = bestiaryEntry98.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry99;
					List<IBestiaryInfoElement> <Info>k__BackingField100 = bestiaryEntry99.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry100;
					List<IBestiaryInfoElement> <Info>k__BackingField101 = bestiaryEntry100.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry101;
					List<IBestiaryInfoElement> <Info>k__BackingField102 = bestiaryEntry101.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry102;
					List<IBestiaryInfoElement> <Info>k__BackingField103 = bestiaryEntry102.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry103;
					List<IBestiaryInfoElement> <Info>k__BackingField104 = bestiaryEntry103.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry104;
					List<IBestiaryInfoElement> <Info>k__BackingField105 = bestiaryEntry104.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry105;
					List<IBestiaryInfoElement> <Info>k__BackingField106 = bestiaryEntry105.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry106;
					List<IBestiaryInfoElement> <Info>k__BackingField107 = bestiaryEntry106.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry107;
					List<IBestiaryInfoElement> <Info>k__BackingField108 = bestiaryEntry107.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry108;
					List<IBestiaryInfoElement> <Info>k__BackingField109 = bestiaryEntry108.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry109;
					List<IBestiaryInfoElement> <Info>k__BackingField110 = bestiaryEntry109.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry110;
					List<IBestiaryInfoElement> <Info>k__BackingField111 = bestiaryEntry110.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry111;
					List<IBestiaryInfoElement> <Info>k__BackingField112 = bestiaryEntry111.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry112;
					List<IBestiaryInfoElement> <Info>k__BackingField113 = bestiaryEntry112.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry113;
					List<IBestiaryInfoElement> <Info>k__BackingField114 = bestiaryEntry113.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry114;
					List<IBestiaryInfoElement> <Info>k__BackingField115 = bestiaryEntry114.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry115;
					List<IBestiaryInfoElement> <Info>k__BackingField116 = bestiaryEntry115.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry116;
					List<IBestiaryInfoElement> <Info>k__BackingField117 = bestiaryEntry116.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry117;
					List<IBestiaryInfoElement> <Info>k__BackingField118 = bestiaryEntry117.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry118;
					List<IBestiaryInfoElement> <Info>k__BackingField119 = bestiaryEntry118.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry119;
					List<IBestiaryInfoElement> <Info>k__BackingField120 = bestiaryEntry119.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry120;
					List<IBestiaryInfoElement> <Info>k__BackingField121 = bestiaryEntry120.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry121;
					List<IBestiaryInfoElement> <Info>k__BackingField122 = bestiaryEntry121.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry122;
					List<IBestiaryInfoElement> <Info>k__BackingField123 = bestiaryEntry122.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry123;
					List<IBestiaryInfoElement> <Info>k__BackingField124 = bestiaryEntry123.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry124;
					List<IBestiaryInfoElement> <Info>k__BackingField125 = bestiaryEntry124.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry125;
					List<IBestiaryInfoElement> <Info>k__BackingField126 = bestiaryEntry125.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry126;
					List<IBestiaryInfoElement> <Info>k__BackingField127 = bestiaryEntry126.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry127;
					List<IBestiaryInfoElement> <Info>k__BackingField128 = bestiaryEntry127.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry128;
					List<IBestiaryInfoElement> <Info>k__BackingField129 = bestiaryEntry128.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry129;
					List<IBestiaryInfoElement> <Info>k__BackingField130 = bestiaryEntry129.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry130;
					List<IBestiaryInfoElement> <Info>k__BackingField131 = bestiaryEntry130.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry131;
					List<IBestiaryInfoElement> <Info>k__BackingField132 = bestiaryEntry131.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry132;
					List<IBestiaryInfoElement> <Info>k__BackingField133 = bestiaryEntry132.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry133;
					List<IBestiaryInfoElement> <Info>k__BackingField134 = bestiaryEntry133.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry134;
					List<IBestiaryInfoElement> <Info>k__BackingField135 = bestiaryEntry134.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry135;
					List<IBestiaryInfoElement> <Info>k__BackingField136 = bestiaryEntry135.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry136;
					List<IBestiaryInfoElement> <Info>k__BackingField137 = bestiaryEntry136.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry137;
					List<IBestiaryInfoElement> <Info>k__BackingField138 = bestiaryEntry137.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry138;
					List<IBestiaryInfoElement> <Info>k__BackingField139 = bestiaryEntry138.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry139;
					List<IBestiaryInfoElement> <Info>k__BackingField140 = bestiaryEntry139.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry140;
					List<IBestiaryInfoElement> <Info>k__BackingField141 = bestiaryEntry140.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry141;
					List<IBestiaryInfoElement> <Info>k__BackingField142 = bestiaryEntry141.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry142;
					List<IBestiaryInfoElement> <Info>k__BackingField143 = bestiaryEntry142.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry143;
					List<IBestiaryInfoElement> <Info>k__BackingField144 = bestiaryEntry143.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry144;
					List<IBestiaryInfoElement> <Info>k__BackingField145 = bestiaryEntry144.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry145;
					List<IBestiaryInfoElement> <Info>k__BackingField146 = bestiaryEntry145.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry146;
					List<IBestiaryInfoElement> <Info>k__BackingField147 = bestiaryEntry146.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry147;
					List<IBestiaryInfoElement> <Info>k__BackingField148 = bestiaryEntry147.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry148;
					List<IBestiaryInfoElement> <Info>k__BackingField149 = bestiaryEntry148.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry149;
					List<IBestiaryInfoElement> <Info>k__BackingField150 = bestiaryEntry149.<Info>k__BackingField;
					BestiaryEntry bestiaryEntry150;
					List<IBestiaryInfoElement> <Info>k__BackingField151 = bestiaryEntry150.<Info>k__BackingField;
					if ((!false || false) && (!false || false))
					{
						return;
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060046FA RID: 18170 RVA: 0x0025DBE4 File Offset: 0x0025BDE4
		private void AddNPCBiomeRelationships_AddDecorations_Automated()
		{
			if (!true)
			{
			}
			BestiaryEntry bestiaryEntry = this._currentDatabase.FindEntryByNPCID(0);
			List<IBestiaryInfoElement> <Info>k__BackingField = bestiaryEntry.<Info>k__BackingField;
			if (!false)
			{
			}
			List<IBestiaryInfoElement> <Info>k__BackingField2 = bestiaryEntry.<Info>k__BackingField;
			if (!false)
			{
			}
			if (<Info>k__BackingField2 == null)
			{
			}
		}

		// Token: 0x060046FB RID: 18171 RVA: 0x0025DCC4 File Offset: 0x0025BEC4
		public void AddDropOverrides(BestiaryDatabase bestiaryDatabase)
		{
			List<IBestiaryInfoElement> <Info>k__BackingField = this._currentDatabase.FindEntryByNPCID(121).<Info>k__BackingField;
			IEnumerable enumerable = Enumerable.OfType(this._currentDatabase.FindEntryByNPCID(81).<Info>k__BackingField);
		}

		// Token: 0x040082BD RID: 33469
		private BestiaryDatabase _currentDatabase;

		// Token: 0x0200091B RID: 2331
		public static class CommonTags
		{
			// Token: 0x060046FC RID: 18172 RVA: 0x0025DCFC File Offset: 0x0025BEFC
			public static List<IBestiaryInfoElement> GetCommonInfoElementsForFilters()
			{
				/*
An exception occurred when decompiling this method (060046FC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<Terraria.GameContent.Bestiary.IBestiaryInfoElement> Terraria.GameContent.Bestiary.BestiaryDatabaseNPCsPopulator/CommonTags::GetCommonInfoElementsForFilters()

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

			// Token: 0x0200091C RID: 2332
			public static class SpawnConditions
			{
				// Token: 0x0200091D RID: 2333
				public static class Invasions
				{
					// Token: 0x060046FD RID: 18173 RVA: 0x00003BB6 File Offset: 0x00001DB6
					// Note: this type is marked as 'beforefieldinit'.
					static Invasions()
					{
					}

					// Token: 0x040082BE RID: 33470
					public static SpawnConditionBestiaryInfoElement Goblins;

					// Token: 0x040082BF RID: 33471
					public static SpawnConditionBestiaryInfoElement Pirates;

					// Token: 0x040082C0 RID: 33472
					public static SpawnConditionBestiaryInfoElement Martian;

					// Token: 0x040082C1 RID: 33473
					public static SpawnConditionBestiaryInfoElement OldOnesArmy;

					// Token: 0x040082C2 RID: 33474
					public static SpawnConditionBestiaryInfoElement PumpkinMoon;

					// Token: 0x040082C3 RID: 33475
					public static SpawnConditionBestiaryInfoElement FrostMoon;

					// Token: 0x040082C4 RID: 33476
					public static SpawnConditionBestiaryInfoElement FrostLegion;
				}

				// Token: 0x0200091E RID: 2334
				public static class Events
				{
					// Token: 0x060046FE RID: 18174 RVA: 0x00003BB6 File Offset: 0x00001DB6
					// Note: this type is marked as 'beforefieldinit'.
					static Events()
					{
					}

					// Token: 0x040082C5 RID: 33477
					public static SpawnConditionBestiaryInfoElement SlimeRain;

					// Token: 0x040082C6 RID: 33478
					public static SpawnConditionBestiaryInfoElement WindyDay;

					// Token: 0x040082C7 RID: 33479
					public static SpawnConditionBestiaryInfoElement BloodMoon;

					// Token: 0x040082C8 RID: 33480
					public static SpawnConditionBestiaryInfoElement Halloween;

					// Token: 0x040082C9 RID: 33481
					public static SpawnConditionBestiaryOverlayInfoElement Rain;

					// Token: 0x040082CA RID: 33482
					public static SpawnConditionBestiaryInfoElement Christmas;

					// Token: 0x040082CB RID: 33483
					public static SpawnConditionBestiaryInfoElement Eclipse;

					// Token: 0x040082CC RID: 33484
					public static SpawnConditionBestiaryInfoElement Party;

					// Token: 0x040082CD RID: 33485
					public static SpawnConditionBestiaryOverlayInfoElement Blizzard;

					// Token: 0x040082CE RID: 33486
					public static SpawnConditionBestiaryOverlayInfoElement Sandstorm;
				}

				// Token: 0x0200091F RID: 2335
				public static class Biomes
				{
					// Token: 0x060046FF RID: 18175 RVA: 0x00003BB6 File Offset: 0x00001DB6
					// Note: this type is marked as 'beforefieldinit'.
					static Biomes()
					{
					}

					// Token: 0x040082CF RID: 33487
					public static SpawnConditionBestiaryInfoElement TheCorruption;

					// Token: 0x040082D0 RID: 33488
					public static SpawnConditionBestiaryInfoElement TheCrimson;

					// Token: 0x040082D1 RID: 33489
					public static SpawnConditionBestiaryInfoElement Surface;

					// Token: 0x040082D2 RID: 33490
					public static SpawnConditionBestiaryInfoElement Graveyard;

					// Token: 0x040082D3 RID: 33491
					public static SpawnConditionBestiaryInfoElement UndergroundJungle;

					// Token: 0x040082D4 RID: 33492
					public static SpawnConditionBestiaryInfoElement TheUnderworld;

					// Token: 0x040082D5 RID: 33493
					public static SpawnConditionBestiaryInfoElement TheDungeon;

					// Token: 0x040082D6 RID: 33494
					public static SpawnConditionBestiaryInfoElement Underground;

					// Token: 0x040082D7 RID: 33495
					public static SpawnConditionBestiaryInfoElement TheHallow;

					// Token: 0x040082D8 RID: 33496
					public static SpawnConditionBestiaryInfoElement UndergroundMushroom;

					// Token: 0x040082D9 RID: 33497
					public static SpawnConditionBestiaryInfoElement Jungle;

					// Token: 0x040082DA RID: 33498
					public static SpawnConditionBestiaryInfoElement Caverns;

					// Token: 0x040082DB RID: 33499
					public static SpawnConditionBestiaryInfoElement UndergroundSnow;

					// Token: 0x040082DC RID: 33500
					public static SpawnConditionBestiaryInfoElement Ocean;

					// Token: 0x040082DD RID: 33501
					public static SpawnConditionBestiaryInfoElement SurfaceMushroom;

					// Token: 0x040082DE RID: 33502
					public static SpawnConditionBestiaryInfoElement UndergroundDesert;

					// Token: 0x040082DF RID: 33503
					public static SpawnConditionBestiaryInfoElement Snow;

					// Token: 0x040082E0 RID: 33504
					public static SpawnConditionBestiaryInfoElement Desert;

					// Token: 0x040082E1 RID: 33505
					public static SpawnConditionBestiaryInfoElement Meteor;

					// Token: 0x040082E2 RID: 33506
					public static SpawnConditionBestiaryInfoElement Oasis;

					// Token: 0x040082E3 RID: 33507
					public static SpawnConditionBestiaryInfoElement SpiderNest;

					// Token: 0x040082E4 RID: 33508
					public static SpawnConditionBestiaryInfoElement TheTemple;

					// Token: 0x040082E5 RID: 33509
					public static SpawnConditionBestiaryInfoElement CorruptUndergroundDesert;

					// Token: 0x040082E6 RID: 33510
					public static SpawnConditionBestiaryInfoElement CrimsonUndergroundDesert;

					// Token: 0x040082E7 RID: 33511
					public static SpawnConditionBestiaryInfoElement HallowUndergroundDesert;

					// Token: 0x040082E8 RID: 33512
					public static SpawnConditionBestiaryInfoElement CorruptDesert;

					// Token: 0x040082E9 RID: 33513
					public static SpawnConditionBestiaryInfoElement CrimsonDesert;

					// Token: 0x040082EA RID: 33514
					public static SpawnConditionBestiaryInfoElement HallowDesert;

					// Token: 0x040082EB RID: 33515
					public static SpawnConditionBestiaryInfoElement Granite;

					// Token: 0x040082EC RID: 33516
					public static SpawnConditionBestiaryInfoElement UndergroundCorruption;

					// Token: 0x040082ED RID: 33517
					public static SpawnConditionBestiaryInfoElement UndergroundCrimson;

					// Token: 0x040082EE RID: 33518
					public static SpawnConditionBestiaryInfoElement UndergroundHallow;

					// Token: 0x040082EF RID: 33519
					public static SpawnConditionBestiaryInfoElement Marble;

					// Token: 0x040082F0 RID: 33520
					public static SpawnConditionBestiaryInfoElement CorruptIce;

					// Token: 0x040082F1 RID: 33521
					public static SpawnConditionBestiaryInfoElement HallowIce;

					// Token: 0x040082F2 RID: 33522
					public static SpawnConditionBestiaryInfoElement CrimsonIce;

					// Token: 0x040082F3 RID: 33523
					public static SpawnConditionBestiaryInfoElement Sky;

					// Token: 0x040082F4 RID: 33524
					public static SpawnConditionBestiaryInfoElement NebulaPillar;

					// Token: 0x040082F5 RID: 33525
					public static SpawnConditionBestiaryInfoElement SolarPillar;

					// Token: 0x040082F6 RID: 33526
					public static SpawnConditionBestiaryInfoElement VortexPillar;

					// Token: 0x040082F7 RID: 33527
					public static SpawnConditionBestiaryInfoElement StardustPillar;
				}

				// Token: 0x02000920 RID: 2336
				public static class Times
				{
					// Token: 0x06004700 RID: 18176 RVA: 0x00003BB6 File Offset: 0x00001DB6
					// Note: this type is marked as 'beforefieldinit'.
					static Times()
					{
					}

					// Token: 0x040082F8 RID: 33528
					public static SpawnConditionBestiaryInfoElement DayTime;

					// Token: 0x040082F9 RID: 33529
					public static SpawnConditionBestiaryInfoElement NightTime;
				}

				// Token: 0x02000921 RID: 2337
				public static class Visuals
				{
					// Token: 0x06004701 RID: 18177 RVA: 0x00003BB6 File Offset: 0x00001DB6
					// Note: this type is marked as 'beforefieldinit'.
					static Visuals()
					{
					}

					// Token: 0x040082FA RID: 33530
					public static SpawnConditionDecorativeOverlayInfoElement Sun;

					// Token: 0x040082FB RID: 33531
					public static SpawnConditionDecorativeOverlayInfoElement Moon;

					// Token: 0x040082FC RID: 33532
					public static SpawnConditionDecorativeOverlayInfoElement EclipseSun;

					// Token: 0x040082FD RID: 33533
					public static SpawnConditionDecorativeOverlayInfoElement PumpkinMoon;

					// Token: 0x040082FE RID: 33534
					public static SpawnConditionDecorativeOverlayInfoElement FrostMoon;

					// Token: 0x040082FF RID: 33535
					public static SpawnConditionDecorativeOverlayInfoElement Meteor;

					// Token: 0x04008300 RID: 33536
					public static SpawnConditionDecorativeOverlayInfoElement Rain;

					// Token: 0x04008301 RID: 33537
					public static SpawnConditionDecorativeOverlayInfoElement Blizzard;
				}
			}
		}

		// Token: 0x02000922 RID: 2338
		public static class Conditions
		{
			// Token: 0x06004702 RID: 18178 RVA: 0x0025DD0C File Offset: 0x0025BF0C
			public static bool ReachHardMode()
			{
				/*
An exception occurred when decompiling this method (06004702)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Bestiary.BestiaryDatabaseNPCsPopulator/Conditions::ReachHardMode()

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
		}

		// Token: 0x02000923 RID: 2339
		public static class CrownosIconIndexes
		{
			// Token: 0x04008302 RID: 33538
			public const int Surface = 0;

			// Token: 0x04008303 RID: 33539
			public const int Underground = 1;

			// Token: 0x04008304 RID: 33540
			public const int Cave = 2;

			// Token: 0x04008305 RID: 33541
			public const int Desert = 3;

			// Token: 0x04008306 RID: 33542
			public const int UndergroundDesert = 4;

			// Token: 0x04008307 RID: 33543
			public const int Snow = 5;

			// Token: 0x04008308 RID: 33544
			public const int UndergroundIce = 6;

			// Token: 0x04008309 RID: 33545
			public const int Corruption = 7;

			// Token: 0x0400830A RID: 33546
			public const int CorruptionUnderground = 8;

			// Token: 0x0400830B RID: 33547
			public const int CorruptionDesert = 9;

			// Token: 0x0400830C RID: 33548
			public const int CorruptionUndergroundDesert = 10;

			// Token: 0x0400830D RID: 33549
			public const int CorruptionIce = 11;

			// Token: 0x0400830E RID: 33550
			public const int Crimson = 12;

			// Token: 0x0400830F RID: 33551
			public const int CrimsonUnderground = 13;

			// Token: 0x04008310 RID: 33552
			public const int CrimsonDesert = 14;

			// Token: 0x04008311 RID: 33553
			public const int CrimsonUndergroundDesert = 15;

			// Token: 0x04008312 RID: 33554
			public const int CrimsonIce = 16;

			// Token: 0x04008313 RID: 33555
			public const int Hallow = 17;

			// Token: 0x04008314 RID: 33556
			public const int HallowUnderground = 18;

			// Token: 0x04008315 RID: 33557
			public const int HallowDesert = 19;

			// Token: 0x04008316 RID: 33558
			public const int HallowUndergroundDesert = 20;

			// Token: 0x04008317 RID: 33559
			public const int HallowIce = 21;

			// Token: 0x04008318 RID: 33560
			public const int Jungle = 22;

			// Token: 0x04008319 RID: 33561
			public const int UndergroundJungle = 23;

			// Token: 0x0400831A RID: 33562
			public const int SurfaceMushroom = 24;

			// Token: 0x0400831B RID: 33563
			public const int UndergroundMushroom = 25;

			// Token: 0x0400831C RID: 33564
			public const int Sky = 26;

			// Token: 0x0400831D RID: 33565
			public const int Oasis = 27;

			// Token: 0x0400831E RID: 33566
			public const int Ocean = 28;

			// Token: 0x0400831F RID: 33567
			public const int Marble = 29;

			// Token: 0x04008320 RID: 33568
			public const int Granite = 30;

			// Token: 0x04008321 RID: 33569
			public const int JungleTemple = 31;

			// Token: 0x04008322 RID: 33570
			public const int Dungeon = 32;

			// Token: 0x04008323 RID: 33571
			public const int Underworld = 33;

			// Token: 0x04008324 RID: 33572
			public const int SpiderNest = 34;

			// Token: 0x04008325 RID: 33573
			public const int Graveyard = 35;

			// Token: 0x04008326 RID: 33574
			public const int Day = 36;

			// Token: 0x04008327 RID: 33575
			public const int Night = 37;

			// Token: 0x04008328 RID: 33576
			public const int BloodMoon = 38;

			// Token: 0x04008329 RID: 33577
			public const int Eclipse = 39;

			// Token: 0x0400832A RID: 33578
			public const int Rain = 40;

			// Token: 0x0400832B RID: 33579
			public const int WindyDay = 41;

			// Token: 0x0400832C RID: 33580
			public const int Blizzard = 42;

			// Token: 0x0400832D RID: 33581
			public const int Sandstorm = 43;

			// Token: 0x0400832E RID: 33582
			public const int Meteor = 44;

			// Token: 0x0400832F RID: 33583
			public const int Halloween = 45;

			// Token: 0x04008330 RID: 33584
			public const int Christmas = 46;

			// Token: 0x04008331 RID: 33585
			public const int SlimeRain = 47;

			// Token: 0x04008332 RID: 33586
			public const int Party = 48;

			// Token: 0x04008333 RID: 33587
			public const int GoblinInvasion = 49;

			// Token: 0x04008334 RID: 33588
			public const int PirateInvasion = 50;

			// Token: 0x04008335 RID: 33589
			public const int PumpkinMoon = 51;

			// Token: 0x04008336 RID: 33590
			public const int FrostMoon = 52;

			// Token: 0x04008337 RID: 33591
			public const int AlienInvasion = 53;

			// Token: 0x04008338 RID: 33592
			public const int FrostLegion = 54;

			// Token: 0x04008339 RID: 33593
			public const int OldOnesArmy = 55;

			// Token: 0x0400833A RID: 33594
			public const int SolarTower = 56;

			// Token: 0x0400833B RID: 33595
			public const int VortexTower = 57;

			// Token: 0x0400833C RID: 33596
			public const int NebulaTower = 58;

			// Token: 0x0400833D RID: 33597
			public const int StardustTower = 59;

			// Token: 0x0400833E RID: 33598
			public const int Hardmode = 60;

			// Token: 0x0400833F RID: 33599
			public const int ItemSpawn = 61;
		}

		// Token: 0x02000924 RID: 2340
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004703 RID: 18179 RVA: 0x0025DD1C File Offset: 0x0025BF1C
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06004704 RID: 18180 RVA: 0x0025DD2C File Offset: 0x0025BF2C
			public <>c()
			{
			}

			// Token: 0x06004705 RID: 18181 RVA: 0x0025DD40 File Offset: 0x0025BF40
			internal bool <ModifyEntriesThatNeedIt_NameOverride>b__12_0(IBestiaryInfoElement x)
			{
				if (x != null)
				{
					return;
				}
			}

			// Token: 0x06004706 RID: 18182 RVA: 0x0025DD54 File Offset: 0x0025BF54
			internal bool <ModifyEntriesThatNeedIt>b__13_0(IBestiaryInfoElement x)
			{
				if (x != null)
				{
					return;
				}
			}

			// Token: 0x06004707 RID: 18183 RVA: 0x0025DD68 File Offset: 0x0025BF68
			internal bool <ModifyEntriesThatNeedIt>b__13_1(IBestiaryInfoElement x)
			{
				if (x != null)
				{
					return;
				}
			}

			// Token: 0x06004708 RID: 18184 RVA: 0x0025DD7C File Offset: 0x0025BF7C
			internal bool <ModifyEntriesThatNeedIt>b__13_2(IBestiaryInfoElement x)
			{
				if (x != null)
				{
					return;
				}
			}

			// Token: 0x06004709 RID: 18185 RVA: 0x0025DD90 File Offset: 0x0025BF90
			internal NPCStatsReportInfoElement <ModifyEntriesThatNeedIt>b__13_3(IBestiaryInfoElement x)
			{
				if (x != null)
				{
					return;
				}
			}

			// Token: 0x0600470A RID: 18186 RVA: 0x000021DB File Offset: 0x000003DB
			internal bool <ModifyEntriesThatNeedIt>b__13_4(NPCStatsReportInfoElement x)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0600470B RID: 18187 RVA: 0x0025DDA4 File Offset: 0x0025BFA4
			internal NPCStatsReportInfoElement <ModifyEntriesThatNeedIt>b__13_5(IBestiaryInfoElement x)
			{
				if (x != null)
				{
					return;
				}
			}

			// Token: 0x0600470C RID: 18188 RVA: 0x000021DB File Offset: 0x000003DB
			internal bool <ModifyEntriesThatNeedIt>b__13_6(NPCStatsReportInfoElement x)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0600470D RID: 18189 RVA: 0x0025DDB8 File Offset: 0x0025BFB8
			internal bool <TryGivingEntryFlavorTextIfItIsMissing>b__16_0(IBestiaryInfoElement x)
			{
				if (x != null)
				{
					return;
				}
			}

			// Token: 0x04008340 RID: 33600
			public static readonly BestiaryDatabaseNPCsPopulator.<>c <>9;

			// Token: 0x04008341 RID: 33601
			public static Predicate<IBestiaryInfoElement> <>9__12_0;

			// Token: 0x04008342 RID: 33602
			public static Predicate<IBestiaryInfoElement> <>9__13_0;

			// Token: 0x04008343 RID: 33603
			public static Predicate<IBestiaryInfoElement> <>9__13_1;

			// Token: 0x04008344 RID: 33604
			public static Predicate<IBestiaryInfoElement> <>9__13_2;

			// Token: 0x04008345 RID: 33605
			public static Func<IBestiaryInfoElement, NPCStatsReportInfoElement> <>9__13_3;

			// Token: 0x04008346 RID: 33606
			public static Func<NPCStatsReportInfoElement, bool> <>9__13_4;

			// Token: 0x04008347 RID: 33607
			public static Func<IBestiaryInfoElement, NPCStatsReportInfoElement> <>9__13_5;

			// Token: 0x04008348 RID: 33608
			public static Func<NPCStatsReportInfoElement, bool> <>9__13_6;

			// Token: 0x04008349 RID: 33609
			public static Func<IBestiaryInfoElement, bool> <>9__16_0;
		}
	}
}
