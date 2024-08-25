using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x020008CC RID: 2252
	public class ItemDropDatabase
	{
		// Token: 0x06004551 RID: 17745 RVA: 0x00250EF8 File Offset: 0x0024F0F8
		public void PrepareNPCNetIDsByTypeDictionary()
		{
			Dictionary<int, List<int>> npcNetIdsByType = this._npcNetIdsByType;
		}

		// Token: 0x06004552 RID: 17746 RVA: 0x00250F68 File Offset: 0x0024F168
		public void TrimDuplicateRulesForNegativeIDs()
		{
			Dictionary<int, List<IItemDropRule>> entriesByNpcNetId = this._entriesByNpcNetId;
			Dictionary<int, List<IItemDropRule>> entriesByNpcNetId2 = this._entriesByNpcNetId;
		}

		// Token: 0x06004553 RID: 17747 RVA: 0x00250F84 File Offset: 0x0024F184
		public List<IItemDropRule> GetRulesForNPCID(int npcNetId, bool includeGlobalDrops = true)
		{
			/*
An exception occurred when decompiling this method (06004553)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<Terraria.GameContent.ItemDropRules.IItemDropRule> Terraria.GameContent.ItemDropRules.ItemDropDatabase::GetRulesForNPCID(System.Int32,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.List`1<class Terraria.GameContent.ItemDropRules.IItemDropRule>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.List`1<class Terraria.GameContent.ItemDropRules.IItemDropRule>(ItemDropDatabase::_globalEntries, ldloc:ItemDropDatabase(this)))
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<int32, class [mscorlib]System.Collections.Generic.List`1<class Terraria.GameContent.ItemDropRules.IItemDropRule>>(var_1_0D, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<int32, class [mscorlib]System.Collections.Generic.List`1<class Terraria.GameContent.ItemDropRules.IItemDropRule>>(ItemDropDatabase::_entriesByNpcNetId, ldloc:ItemDropDatabase(this)))
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

		// Token: 0x06004554 RID: 17748 RVA: 0x000021DB File Offset: 0x000003DB
		public IItemDropRule RegisterToGlobal(IItemDropRule entry)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004555 RID: 17749 RVA: 0x00250FA0 File Offset: 0x0024F1A0
		public IItemDropRule RegisterToNPC(int type, IItemDropRule entry)
		{
			this.RegisterToNPCNetId(type, entry);
			Dictionary.Entry[] entries = this._npcNetIdsByType._entries;
			Dictionary<int, List<IItemDropRule>> entriesByNpcNetId = this._entriesByNpcNetId;
			return entry;
		}

		// Token: 0x06004556 RID: 17750 RVA: 0x00250FCC File Offset: 0x0024F1CC
		private void RegisterToNPCNetId(int npcNetId, IItemDropRule entry)
		{
			Dictionary<int, List<IItemDropRule>> entriesByNpcNetId = this._entriesByNpcNetId;
			Dictionary<int, List<IItemDropRule>> entriesByNpcNetId2 = this._entriesByNpcNetId;
			Dictionary<int, List<IItemDropRule>> entriesByNpcNetId3 = this._entriesByNpcNetId;
			Dictionary.Entry[] entries = entriesByNpcNetId3._entries;
			int count = entriesByNpcNetId3._count;
			int[] buckets = entriesByNpcNetId3._buckets;
		}

		// Token: 0x06004557 RID: 17751 RVA: 0x00251008 File Offset: 0x0024F208
		public IItemDropRule RegisterToMultipleNPCs(IItemDropRule entry, params int[] npcNetIds)
		{
			return entry;
		}

		// Token: 0x06004558 RID: 17752 RVA: 0x00251018 File Offset: 0x0024F218
		public IItemDropRule RegisterToMultipleNPCsNotRemixSeed(IItemDropRule entry, params int[] npcNetIds)
		{
			long num = 0L;
			IItemDropRule itemDropRule2;
			IItemDropRule itemDropRule = itemDropRule2.OnSuccess(entry, num != 0L);
			return entry;
		}

		// Token: 0x06004559 RID: 17753 RVA: 0x00251038 File Offset: 0x0024F238
		public IItemDropRule RegisterToMultipleNPCsRemixSeed(IItemDropRule entry, params int[] npcNetIds)
		{
			long num = 0L;
			IItemDropRule itemDropRule2;
			IItemDropRule itemDropRule = itemDropRule2.OnSuccess(entry, num != 0L);
			return entry;
		}

		// Token: 0x0600455A RID: 17754 RVA: 0x00251058 File Offset: 0x0024F258
		private void RemoveFromNPCNetId(int npcNetId, IItemDropRule entry)
		{
			Dictionary<int, List<IItemDropRule>> entriesByNpcNetId = this._entriesByNpcNetId;
			Dictionary<int, List<IItemDropRule>> entriesByNpcNetId2 = this._entriesByNpcNetId;
		}

		// Token: 0x0600455B RID: 17755 RVA: 0x00251074 File Offset: 0x0024F274
		public IItemDropRule RemoveFromNPC(int type, IItemDropRule entry)
		{
			this.RemoveFromNPCNetId(type, entry);
			Dictionary.Entry[] entries = this._npcNetIdsByType._entries;
			Dictionary<int, List<IItemDropRule>> entriesByNpcNetId = this._entriesByNpcNetId;
			return entry;
		}

		// Token: 0x0600455C RID: 17756 RVA: 0x002510A0 File Offset: 0x0024F2A0
		public IItemDropRule RemoveFromMultipleNPCs(IItemDropRule entry, params int[] npcNetIds)
		{
			return entry;
		}

		// Token: 0x0600455D RID: 17757 RVA: 0x002510B0 File Offset: 0x0024F2B0
		public void Populate()
		{
			this.PrepareNPCNetIDsByTypeDictionary();
			this.RegisterGlobalRules();
			this.RegisterFoodDrops();
			this.RegisterWeirdRules();
			this.RegisterTownNPCDrops();
			this.RegisterDD2EventDrops();
			this.RegisterMiscDrops();
			this.RegisterHardmodeFeathers();
			this.RegisterYoyos();
			this.RegisterStatusImmunityItems();
			this.RegisterPirateDrops();
			this.RegisterMartianDrops();
			this.RegisterBossTrophies();
			this.RegisterBosses();
			this.RegisterHardmodeDungeonDrops();
			this.RegisterMimic();
			this.RegisterEclipse();
			this.RegisterBloodMoonFishing();
			this.TrimDuplicateRulesForNegativeIDs();
		}

		// Token: 0x0600455E RID: 17758 RVA: 0x00251130 File Offset: 0x0024F330
		private void RegisterBloodMoonFishing()
		{
			IItemDropRule itemDropRule = ItemDropRule.Common(4608, 2, 4, 6);
			IItemDropRule itemDropRule2 = ItemDropRule.Common(4608, 2, 7, 10);
			IItemDropRule itemDropRule3 = ItemDropRule.Common(3213, 15, 1, 1);
			IItemDropRule itemDropRule4 = ItemDropRule.Common(4270, 8, 1, 1);
			IItemDropRule itemDropRule5 = this.RegisterToNPC(620, itemDropRule4);
			IItemDropRule itemDropRule6 = ItemDropRule.Common(4317, 8, 1, 1);
			IItemDropRule itemDropRule7 = this.RegisterToNPC(620, itemDropRule6);
			IItemDropRule itemDropRule8 = ItemDropRule.Common(4272, 8, 1, 1);
			IItemDropRule itemDropRule9 = this.RegisterToNPC(621, itemDropRule8);
			IItemDropRule itemDropRule10 = ItemDropRule.Common(4317, 8, 1, 1);
			IItemDropRule itemDropRule11 = this.RegisterToNPC(621, itemDropRule10);
			IItemDropRule itemDropRule12 = ItemDropRule.NormalvsExpert(4269, 2, 1);
			IItemDropRule itemDropRule13 = this.RegisterToNPC(618, itemDropRule12);
			IItemDropRule itemDropRule14 = ItemDropRule.Common(4054, 10, 1, 1);
			IItemDropRule itemDropRule15 = this.RegisterToNPC(618, itemDropRule14);
			IItemDropRule itemDropRule16 = ItemDropRule.NormalvsExpert(4271, 2, 1);
			IItemDropRule itemDropRule17 = this.RegisterToNPC(618, itemDropRule16);
			IItemDropRule itemDropRule18 = ItemDropRule.Common(4271, 5, 1, 1);
		}

		// Token: 0x0600455F RID: 17759 RVA: 0x0025124C File Offset: 0x0024F44C
		private void RegisterEclipse()
		{
			IItemDropRule itemDropRule = ItemDropRule.ExpertGetsRerolls(497, 50, 1);
			IItemDropRule itemDropRule2 = this.RegisterToNPC(461, itemDropRule);
			IItemDropRule itemDropRule3 = ItemDropRule.ExpertGetsRerolls(900, 35, 1);
			IItemDropRule itemDropRule4 = ItemDropRule.ExpertGetsRerolls(1311, 15, 1);
			IItemDropRule itemDropRule5 = this.RegisterToNPC(251, itemDropRule4);
			IItemDropRule itemDropRule6 = ItemDropRule.Common(5239, 15, 1, 1);
			IItemDropRule itemDropRule7 = this.RegisterToNPC(251, itemDropRule6);
			IItemDropRule itemDropRule8 = ItemDropRule.Common(5236, 15, 1, 1);
			IItemDropRule itemDropRule9 = this.RegisterToNPC(251, itemDropRule8);
			IItemDropRule itemDropRule10 = ItemDropRule.Common(5237, 15, 1, 1);
			IItemDropRule itemDropRule11 = this.RegisterToNPC(477, itemDropRule10);
			IItemDropRule itemDropRule12 = ItemDropRule.Common(5223, 60, 1, 1);
			IItemDropRule itemDropRule13 = this.RegisterToNPC(253, itemDropRule12);
			IItemDropRule itemDropRule14 = ItemDropRule.Common(5227, 60, 1, 1);
			IItemDropRule itemDropRule15 = this.RegisterToNPC(460, itemDropRule14);
			IItemDropRule itemDropRule16 = ItemDropRule.Common(5260, 60, 1, 1);
			IItemDropRule itemDropRule17 = this.RegisterToNPC(469, itemDropRule16);
			IItemDropRule itemDropRule18 = ItemDropRule.Common(5261, 450, 1, 1);
			IItemDropRule itemDropRule19 = ItemDropRule.Common(5262, 60, 1, 1);
			IItemDropRule itemDropRule20 = this.RegisterToNPC(462, itemDropRule19);
			IItemDropRule itemDropRule21 = ItemDropRule.ExpertGetsRerolls(1570, 4, 1);
			long num = 0L;
			IItemDropRule itemDropRule23;
			IItemDropRule itemDropRule22 = itemDropRule23.OnSuccess(itemDropRule21, num != 0L);
			IItemDropRule itemDropRule24 = ItemDropRule.ExpertGetsRerolls(2770, 20, 1);
			long num2 = 0L;
			IItemDropRule itemDropRule26;
			IItemDropRule itemDropRule25 = itemDropRule26.OnSuccess(itemDropRule24, num2 != 0L);
			IItemDropRule itemDropRule27 = ItemDropRule.ExpertGetsRerolls(3292, 3, 1);
			long num3 = 0L;
			IItemDropRule itemDropRule28 = itemDropRule26.OnSuccess(itemDropRule27, num3 != 0L);
			IItemDropRule itemDropRule29 = ItemDropRule.ExpertGetsRerolls(1327, 40, 1);
			long num4 = 0L;
			IItemDropRule itemDropRule31;
			IItemDropRule itemDropRule30 = itemDropRule31.OnSuccess(itemDropRule29, num4 != 0L);
			IItemDropRule itemDropRule32 = ItemDropRule.ExpertGetsRerolls(3098, 40, 1);
			long num5 = 0L;
			IItemDropRule itemDropRule33 = itemDropRule32.OnSuccess(itemDropRule32, num5 != 0L);
			IItemDropRule itemDropRule34 = ItemDropRule.ExpertGetsRerolls(4740, 50, 1);
			IItemDropRule itemDropRule35 = this.RegisterToNPC(460, itemDropRule34);
			IItemDropRule itemDropRule36 = ItemDropRule.ExpertGetsRerolls(4741, 50, 1);
			IItemDropRule itemDropRule37 = this.RegisterToNPC(460, itemDropRule36);
			IItemDropRule itemDropRule38 = ItemDropRule.ExpertGetsRerolls(4742, 50, 1);
			IItemDropRule itemDropRule39 = this.RegisterToNPC(460, itemDropRule38);
			IItemDropRule itemDropRule40 = ItemDropRule.ExpertGetsRerolls(3105, 40, 1);
			long num6 = 0L;
			IItemDropRule itemDropRule42;
			IItemDropRule itemDropRule41 = itemDropRule42.OnSuccess(itemDropRule40, num6 != 0L);
			IItemDropRule itemDropRule43 = ItemDropRule.ExpertGetsRerolls(4738, 50, 1);
			IItemDropRule itemDropRule44 = this.RegisterToNPC(468, itemDropRule43);
			IItemDropRule itemDropRule45 = ItemDropRule.ExpertGetsRerolls(4739, 50, 1);
			IItemDropRule itemDropRule46 = this.RegisterToNPC(468, itemDropRule45);
			IItemDropRule itemDropRule47 = ItemDropRule.ExpertGetsRerolls(3106, 40, 1);
			long num7 = 0L;
			IItemDropRule itemDropRule49;
			IItemDropRule itemDropRule48 = itemDropRule49.OnSuccess(itemDropRule47, num7 != 0L);
			IItemDropRule itemDropRule50 = ItemDropRule.ExpertGetsRerolls(3249, 30, 1);
			long num8 = 0L;
			IItemDropRule itemDropRule52;
			IItemDropRule itemDropRule51 = itemDropRule52.OnSuccess(itemDropRule50, num8 != 0L);
			IItemDropRule itemDropRule53 = ItemDropRule.Common(3107, 25, 1, 1);
			IItemDropRule itemDropRule54 = ItemDropRule.WithRerolls(3107, 1, 25, 1, 1);
			IItemDropRule itemDropRule55 = ItemDropRule.Common(3108, 1, 100, 200);
			IItemDropRule itemDropRule56 = itemDropRule53.OnSuccess(itemDropRule55, true);
			IItemDropRule itemDropRule57 = ItemDropRule.Common(3108, 1, 100, 200);
			IItemDropRule itemDropRule58 = itemDropRule54.OnSuccess(itemDropRule57, true);
		}

		// Token: 0x06004560 RID: 17760 RVA: 0x0025157C File Offset: 0x0024F77C
		private void RegisterMimic()
		{
			long num = 0L;
			IItemDropRule itemDropRule2;
			IItemDropRule itemDropRule3;
			IItemDropRule itemDropRule = itemDropRule2.OnSuccess(itemDropRule3, num != 0L);
			long num2 = 0L;
			IItemDropRule itemDropRule5;
			IItemDropRule itemDropRule6;
			IItemDropRule itemDropRule4 = itemDropRule5.OnSuccess(itemDropRule6, num2 != 0L);
			long num3 = 0L;
			IItemDropRule itemDropRule8;
			IItemDropRule itemDropRule9;
			IItemDropRule itemDropRule7 = itemDropRule8.OnSuccess(itemDropRule9, num3 != 0L);
			IItemDropRule itemDropRule10 = ItemDropRule.Common(1312, 20, 1, 1);
			long num4 = 0L;
			IItemDropRule itemDropRule12;
			IItemDropRule itemDropRule13;
			IItemDropRule itemDropRule11 = itemDropRule12.OnSuccess(itemDropRule13, num4 != 0L);
			long num5 = 0L;
			IItemDropRule itemDropRule15;
			IItemDropRule itemDropRule16;
			IItemDropRule itemDropRule14 = itemDropRule15.OnSuccess(itemDropRule16, num5 != 0L);
			long num6 = 0L;
			IItemDropRule itemDropRule18;
			IItemDropRule itemDropRule19;
			IItemDropRule itemDropRule17 = itemDropRule18.OnSuccess(itemDropRule19, num6 != 0L);
			IItemDropRule itemDropRule20 = this.RegisterToNPC(629, itemDropRule10);
		}

		// Token: 0x06004561 RID: 17761 RVA: 0x00251604 File Offset: 0x0024F804
		private void RegisterHardmodeDungeonDrops()
		{
			IItemDropRule itemDropRule = ItemDropRule.ExpertGetsRerolls(1513, 15, 1);
			IItemDropRule itemDropRule2 = this.RegisterToNPC(290, itemDropRule);
			IItemDropRule itemDropRule3 = ItemDropRule.ExpertGetsRerolls(938, 10, 1);
			IItemDropRule itemDropRule4 = this.RegisterToNPC(290, itemDropRule3);
			IItemDropRule itemDropRule5 = ItemDropRule.ExpertGetsRerolls(977, 12, 1);
			IItemDropRule itemDropRule6 = this.RegisterToNPC(287, itemDropRule5);
			IItemDropRule itemDropRule7 = ItemDropRule.ExpertGetsRerolls(963, 12, 1);
			IItemDropRule itemDropRule8 = this.RegisterToNPC(287, itemDropRule7);
			IItemDropRule itemDropRule9 = ItemDropRule.ExpertGetsRerolls(1300, 12, 1);
			IItemDropRule itemDropRule10 = this.RegisterToNPC(291, itemDropRule9);
			IItemDropRule itemDropRule11 = ItemDropRule.ExpertGetsRerolls(1254, 12, 1);
			IItemDropRule itemDropRule12 = this.RegisterToNPC(291, itemDropRule11);
			IItemDropRule itemDropRule13 = ItemDropRule.ExpertGetsRerolls(1514, 12, 1);
			IItemDropRule itemDropRule14 = this.RegisterToNPC(292, itemDropRule13);
			IItemDropRule itemDropRule15 = ItemDropRule.ExpertGetsRerolls(679, 12, 1);
			IItemDropRule itemDropRule16 = this.RegisterToNPC(292, itemDropRule15);
			IItemDropRule itemDropRule17 = ItemDropRule.ExpertGetsRerolls(759, 18, 1);
			IItemDropRule itemDropRule18 = this.RegisterToNPC(293, itemDropRule17);
			IItemDropRule itemDropRule19 = ItemDropRule.ExpertGetsRerolls(4789, 25, 1);
			IItemDropRule itemDropRule20 = this.RegisterToNPC(289, itemDropRule19);
			IItemDropRule itemDropRule21 = ItemDropRule.ExpertGetsRerolls(1446, 20, 1);
			IItemDropRule itemDropRule22 = ItemDropRule.ExpertGetsRerolls(1444, 20, 1);
			IItemDropRule itemDropRule23 = ItemDropRule.ExpertGetsRerolls(1445, 20, 1);
			IItemDropRule itemDropRule24 = ItemDropRule.ExpertGetsRerolls(1183, 400, 1);
			IItemDropRule itemDropRule25 = ItemDropRule.ExpertGetsRerolls(1266, 300, 1);
			IItemDropRule itemDropRule26 = ItemDropRule.ExpertGetsRerolls(671, 200, 1);
			IItemDropRule itemDropRule27 = ItemDropRule.ExpertGetsRerolls(2273, 200, 1);
			IItemDropRule itemDropRule28 = ItemDropRule.ExpertGetsRerolls(4679, 200, 1);
			IItemDropRule itemDropRule29 = ItemDropRule.Common(1508, 1, 1, 2);
			IItemDropRule itemDropRule30 = this.RegisterToNPC(288, itemDropRule29);
		}

		// Token: 0x06004562 RID: 17762 RVA: 0x002517DC File Offset: 0x0024F9DC
		private void RegisterBosses()
		{
			this.RegisterBoss_EOC();
			this.RegisterBoss_BOC();
			this.RegisterBoss_EOW();
			this.RegisterBoss_QueenBee();
			this.RegisterBoss_Skeletron();
			this.RegisterBoss_WOF();
			this.RegisterBoss_AncientCultist();
			this.RegisterBoss_MoonLord();
			this.RegisterBoss_LunarTowers();
			this.RegisterBoss_Betsy();
			this.RegisterBoss_Golem();
			this.RegisterBoss_DukeFishron();
			this.RegisterBoss_SkeletronPrime();
			this.RegisterBoss_TheDestroyer();
			this.RegisterBoss_Twins();
			this.RegisterBoss_Plantera();
			this.RegisterBoss_KingSlime();
			this.RegisterBoss_FrostMoon();
			this.RegisterBoss_PumpkinMoon();
			this.RegisterBoss_HallowBoss();
			this.RegisterBoss_QueenSlime();
			this.RegisterBoss_Deerclops();
		}

		// Token: 0x06004563 RID: 17763 RVA: 0x00251870 File Offset: 0x0024FA70
		private void RegisterBoss_QueenSlime()
		{
			IItemDropRule itemDropRule = ItemDropRule.BossBag(4957);
			IItemDropRule itemDropRule2 = this.RegisterToNPC(657, itemDropRule);
			IItemDropRule itemDropRule3 = ItemDropRule.MasterModeCommonDrop(4950);
			IItemDropRule itemDropRule4 = this.RegisterToNPC(657, itemDropRule3);
			int masterModeDropRng = this._masterModeDropRng;
			IItemDropRule itemDropRule5 = ItemDropRule.MasterModeDropOnAllPlayers(4960, masterModeDropRng);
			IItemDropRule itemDropRule6 = this.RegisterToNPC(657, itemDropRule5);
			IItemDropRule itemDropRule7 = ItemDropRule.Common(4986, 1, 25, 75);
			IItemDropRule itemDropRule8 = ItemDropRule.Common(4959, 7, 1, 1);
			IItemDropRule itemDropRule9 = ItemDropRule.Common(4758, 4, 1, 1);
			IItemDropRule itemDropRule10 = ItemDropRule.Common(4981, 4, 1, 1);
			IItemDropRule itemDropRule11 = ItemDropRule.NotScalingWithLuck(4980, 3, 1, 1);
		}

		// Token: 0x06004564 RID: 17764 RVA: 0x00251920 File Offset: 0x0024FB20
		private void RegisterBoss_HallowBoss()
		{
			IItemDropRule itemDropRule = ItemDropRule.BossBag(4782);
			IItemDropRule itemDropRule2 = ItemDropRule.MasterModeCommonDrop(4949);
			IItemDropRule itemDropRule3 = this.RegisterToNPC(636, itemDropRule2);
			int masterModeDropRng = this._masterModeDropRng;
			IItemDropRule itemDropRule4 = ItemDropRule.MasterModeDropOnAllPlayers(4811, masterModeDropRng);
			IItemDropRule itemDropRule5 = this.RegisterToNPC(636, itemDropRule4);
			long num = 0L;
			IItemDropRule itemDropRule7;
			IItemDropRule itemDropRule8;
			IItemDropRule itemDropRule6 = itemDropRule7.OnSuccess(itemDropRule8, num != 0L);
			IItemDropRule itemDropRule9 = ItemDropRule.Common(4823, 15, 1, 1);
			IItemDropRule itemDropRule10 = ItemDropRule.Common(4778, 4, 1, 1);
			IItemDropRule itemDropRule11 = ItemDropRule.Common(4715, 50, 1, 1);
			IItemDropRule itemDropRule12 = ItemDropRule.Common(4784, 7, 1, 1);
			IItemDropRule itemDropRule13 = ItemDropRule.Common(5075, 20, 1, 1);
			IItemDropRule itemDropRule14 = ItemDropRule.Common(5005, 1, 1, 1);
			long num2 = 0L;
			IItemDropRule itemDropRule16;
			IItemDropRule itemDropRule15 = itemDropRule16.OnSuccess(itemDropRule14, num2 != 0L);
		}

		// Token: 0x06004565 RID: 17765 RVA: 0x002519F4 File Offset: 0x0024FBF4
		private void RegisterBoss_PumpkinMoon()
		{
			IItemDropRule itemDropRule2;
			IItemDropRule itemDropRule = this.RegisterToNPC(315, itemDropRule2);
			long num = 0L;
			IItemDropRule itemDropRule4;
			IItemDropRule itemDropRule5;
			IItemDropRule itemDropRule3 = itemDropRule4.OnSuccess(itemDropRule5, num != 0L);
			IItemDropRule itemDropRule6 = ItemDropRule.Common(1835, 1, 1, 1);
			IItemDropRule itemDropRule7 = ItemDropRule.Common(1836, 1, 30, 60);
			IItemDropRule itemDropRule8 = itemDropRule6.OnSuccess(itemDropRule7, true);
			IItemDropRule itemDropRule9 = ItemDropRule.Common(1829, 1, 1, 1);
			if (itemDropRule9 == null || itemDropRule9 != null)
			{
				IItemDropRule itemDropRule10 = ItemDropRule.Common(1831, 1, 1, 1);
				if ((itemDropRule10 == null || itemDropRule10 != null) && (itemDropRule6 == null || itemDropRule6 != null))
				{
					IItemDropRule itemDropRule11 = ItemDropRule.Common(1837, 1, 1, 1);
					if (itemDropRule11 == null || itemDropRule11 != null)
					{
						IItemDropRule itemDropRule12 = ItemDropRule.Common(1845, 1, 1, 1);
						if (itemDropRule12 == null || itemDropRule12 != null)
						{
							long num2 = 0L;
							IItemDropRule itemDropRule14;
							IItemDropRule itemDropRule15;
							IItemDropRule itemDropRule13 = itemDropRule14.OnSuccess(itemDropRule15, num2 != 0L);
							long num3 = 0L;
							IItemDropRule itemDropRule17;
							IItemDropRule itemDropRule16 = itemDropRule14.OnSuccess(itemDropRule17, num3 != 0L);
							IItemDropRule itemDropRule18 = ItemDropRule.MasterModeCommonDrop(4941);
							long num4 = 0L;
							IItemDropRule itemDropRule19 = itemDropRule14.OnSuccess(itemDropRule18, num4 != 0L);
							int masterModeDropRng = this._masterModeDropRng;
							IItemDropRule itemDropRule20 = ItemDropRule.MasterModeDropOnAllPlayers(4793, masterModeDropRng);
							long num5 = 0L;
							IItemDropRule itemDropRule21 = itemDropRule14.OnSuccess(itemDropRule20, num5 != 0L);
							IItemDropRule itemDropRule22 = ItemDropRule.Common(1782, 1, 1, 1);
							IItemDropRule itemDropRule23 = ItemDropRule.Common(1783, 1, 50, 100);
							IItemDropRule itemDropRule24 = itemDropRule22.OnSuccess(itemDropRule23, true);
							IItemDropRule itemDropRule25 = ItemDropRule.Common(1784, 1, 1, 1);
							IItemDropRule itemDropRule26 = ItemDropRule.Common(1785, 1, 25, 50);
							IItemDropRule itemDropRule27 = itemDropRule25.OnSuccess(itemDropRule26, true);
							if ((itemDropRule22 == null || itemDropRule22 != null) && (itemDropRule25 == null || itemDropRule25 != null))
							{
								IItemDropRule itemDropRule28 = ItemDropRule.Common(1811, 1, 1, 1);
								if (itemDropRule28 == null || itemDropRule28 != null)
								{
									IItemDropRule itemDropRule29 = ItemDropRule.Common(1826, 1, 1, 1);
									if (itemDropRule29 == null || itemDropRule29 != null)
									{
										IItemDropRule itemDropRule30 = ItemDropRule.Common(1801, 1, 1, 1);
										if (itemDropRule30 == null || itemDropRule30 != null)
										{
											IItemDropRule itemDropRule31 = ItemDropRule.Common(1802, 1, 1, 1);
											if (itemDropRule31 == null || itemDropRule31 != null)
											{
												IItemDropRule itemDropRule32 = ItemDropRule.Common(4680, 1, 1, 1);
												if (itemDropRule32 == null || itemDropRule32 != null)
												{
													IItemDropRule itemDropRule33 = ItemDropRule.Common(1798, 1, 1, 1);
													if (itemDropRule33 == null || itemDropRule33 != null)
													{
														long num6 = 0L;
														IItemDropRule itemDropRule35;
														IItemDropRule itemDropRule34 = itemDropRule35.OnSuccess(itemDropRule35, num6 != 0L);
														IItemDropRule itemDropRule36 = ItemDropRule.MasterModeCommonDrop(4942);
														long num7 = 0L;
														IItemDropRule itemDropRule38;
														IItemDropRule itemDropRule37 = itemDropRule38.OnSuccess(itemDropRule36, num7 != 0L);
														int masterModeDropRng2 = this._masterModeDropRng;
														IItemDropRule itemDropRule39 = ItemDropRule.MasterModeDropOnAllPlayers(4812, masterModeDropRng2);
														long num8 = 0L;
														IItemDropRule itemDropRule40 = itemDropRule38.OnSuccess(itemDropRule39, num8 != 0L);
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
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06004566 RID: 17766 RVA: 0x00251C7C File Offset: 0x0024FE7C
		private void RegisterBoss_FrostMoon()
		{
			long num = 0L;
			IItemDropRule itemDropRule2;
			IItemDropRule itemDropRule3;
			IItemDropRule itemDropRule = itemDropRule2.OnSuccess(itemDropRule3, num != 0L);
			IItemDropRule itemDropRule4 = ItemDropRule.Common(1871, 15, 1, 1);
			long num2 = 0L;
			IItemDropRule itemDropRule5 = itemDropRule2.OnSuccess(itemDropRule4, num2 != 0L);
			long num3 = 0L;
			IItemDropRule itemDropRule7;
			IItemDropRule itemDropRule6 = itemDropRule5.OnFailedRoll(itemDropRule7, num3 != 0L);
			IItemDropRule itemDropRule8 = ItemDropRule.MasterModeCommonDrop(4944);
			long num4 = 0L;
			IItemDropRule itemDropRule9 = itemDropRule2.OnSuccess(itemDropRule8, num4 != 0L);
			int masterModeDropRng = this._masterModeDropRng;
			IItemDropRule itemDropRule10 = ItemDropRule.MasterModeDropOnAllPlayers(4813, masterModeDropRng);
			long num5 = 0L;
			IItemDropRule itemDropRule11 = itemDropRule2.OnSuccess(itemDropRule10, num5 != 0L);
			long num6 = 0L;
			IItemDropRule itemDropRule13;
			IItemDropRule itemDropRule14;
			IItemDropRule itemDropRule12 = itemDropRule13.OnSuccess(itemDropRule14, num6 != 0L);
			long num7 = 0L;
			IItemDropRule itemDropRule16;
			IItemDropRule itemDropRule15 = itemDropRule13.OnSuccess(itemDropRule16, num7 != 0L);
			IItemDropRule itemDropRule17 = ItemDropRule.Common(1959, 15, 1, 1);
			long num8 = 0L;
			IItemDropRule itemDropRule18 = itemDropRule13.OnSuccess(itemDropRule17, num8 != 0L);
			long num9 = 0L;
			IItemDropRule itemDropRule20;
			IItemDropRule itemDropRule19 = itemDropRule18.OnFailedRoll(itemDropRule20, num9 != 0L);
			IItemDropRule itemDropRule21 = ItemDropRule.MasterModeCommonDrop(4943);
			long num10 = 0L;
			IItemDropRule itemDropRule22 = itemDropRule13.OnSuccess(itemDropRule21, num10 != 0L);
			int masterModeDropRng2 = this._masterModeDropRng;
			IItemDropRule itemDropRule23 = ItemDropRule.MasterModeDropOnAllPlayers(4814, masterModeDropRng2);
			long num11 = 0L;
			IItemDropRule itemDropRule24 = itemDropRule13.OnSuccess(itemDropRule23, num11 != 0L);
			long num12 = 0L;
			IItemDropRule itemDropRule26;
			IItemDropRule itemDropRule27;
			IItemDropRule itemDropRule25 = itemDropRule26.OnSuccess(itemDropRule27, num12 != 0L);
			long num13 = 0L;
			IItemDropRule itemDropRule29;
			IItemDropRule itemDropRule28 = itemDropRule26.OnSuccess(itemDropRule29, num13 != 0L);
			IItemDropRule itemDropRule30 = ItemDropRule.MasterModeCommonDrop(4945);
			long num14 = 0L;
			IItemDropRule itemDropRule31 = itemDropRule26.OnSuccess(itemDropRule30, num14 != 0L);
			int masterModeDropRng3 = this._masterModeDropRng;
			IItemDropRule itemDropRule32 = ItemDropRule.MasterModeDropOnAllPlayers(4794, masterModeDropRng3);
			long num15 = 0L;
			IItemDropRule itemDropRule33 = itemDropRule26.OnSuccess(itemDropRule32, num15 != 0L);
			IItemDropRule itemDropRule35;
			IItemDropRule itemDropRule34 = this.RegisterToNPC(341, itemDropRule35);
		}

		// Token: 0x06004567 RID: 17767 RVA: 0x00251E08 File Offset: 0x00250008
		private void RegisterBoss_KingSlime()
		{
			IItemDropRule itemDropRule = ItemDropRule.BossBag(3318);
			IItemDropRule itemDropRule2 = this.RegisterToNPC(50, itemDropRule);
			IItemDropRule itemDropRule3 = ItemDropRule.MasterModeCommonDrop(4929);
			IItemDropRule itemDropRule4 = this.RegisterToNPC(50, itemDropRule3);
			int masterModeDropRng = this._masterModeDropRng;
			IItemDropRule itemDropRule5 = ItemDropRule.MasterModeDropOnAllPlayers(4797, masterModeDropRng);
			IItemDropRule itemDropRule6 = this.RegisterToNPC(50, itemDropRule5);
			IItemDropRule itemDropRule7 = ItemDropRule.Common(2430, 4, 1, 1);
			IItemDropRule itemDropRule8 = ItemDropRule.Common(2493, 7, 1, 1);
			IItemDropRule itemDropRule9 = ItemDropRule.NotScalingWithLuck(2585, 3, 1, 1);
			IItemDropRule itemDropRule10 = ItemDropRule.Common(2610, 1, 1, 1);
			long num = 0L;
			IItemDropRule itemDropRule12;
			IItemDropRule itemDropRule11 = itemDropRule12.OnFailedRoll(itemDropRule10, num != 0L);
			IItemDropRule itemDropRule13 = ItemDropRule.Common(998, 1, 1, 1);
		}

		// Token: 0x06004568 RID: 17768 RVA: 0x00251EBC File Offset: 0x002500BC
		private void RegisterBoss_Plantera()
		{
			IItemDropRule itemDropRule = ItemDropRule.BossBag(3328);
			IItemDropRule itemDropRule2 = this.RegisterToNPC(262, itemDropRule);
			IItemDropRule itemDropRule3 = ItemDropRule.MasterModeCommonDrop(4934);
			IItemDropRule itemDropRule4 = this.RegisterToNPC(262, itemDropRule3);
			int masterModeDropRng = this._masterModeDropRng;
			IItemDropRule itemDropRule5 = ItemDropRule.MasterModeDropOnAllPlayers(4806, masterModeDropRng);
			IItemDropRule itemDropRule6 = this.RegisterToNPC(262, itemDropRule5);
			IItemDropRule itemDropRule7 = ItemDropRule.Common(2109, 7, 1, 1);
			IItemDropRule itemDropRule8 = ItemDropRule.Common(1141, 1, 1, 1);
			IItemDropRule itemDropRule9 = ItemDropRule.Common(1182, 20, 1, 1);
			IItemDropRule itemDropRule10 = ItemDropRule.Common(1305, 50, 1, 1);
			IItemDropRule itemDropRule11 = ItemDropRule.Common(1157, 4, 1, 1);
			IItemDropRule itemDropRule12 = ItemDropRule.Common(3021, 10, 1, 1);
			IItemDropRule itemDropRule13 = ItemDropRule.Common(758, 1, 1, 1);
			IItemDropRule itemDropRule14 = ItemDropRule.Common(771, 1, 50, 150);
			IItemDropRule itemDropRule15 = itemDropRule13.OnSuccess(itemDropRule14, true);
			if (itemDropRule13 == null || itemDropRule13 != null)
			{
				IItemDropRule itemDropRule16 = ItemDropRule.Common(1255, 1, 1, 1);
				if (itemDropRule16 == null || itemDropRule16 != null)
				{
					IItemDropRule itemDropRule17 = ItemDropRule.Common(788, 1, 1, 1);
					if (itemDropRule17 == null || itemDropRule17 != null)
					{
						IItemDropRule itemDropRule18 = ItemDropRule.Common(1178, 1, 1, 1);
						if (itemDropRule18 == null || itemDropRule18 != null)
						{
							IItemDropRule itemDropRule19 = ItemDropRule.Common(1259, 1, 1, 1);
							if (itemDropRule19 == null || itemDropRule19 != null)
							{
								IItemDropRule itemDropRule20 = ItemDropRule.Common(1155, 1, 1, 1);
								if (itemDropRule20 == null || itemDropRule20 != null)
								{
									IItemDropRule itemDropRule21 = ItemDropRule.Common(3018, 1, 1, 1);
									if (itemDropRule21 == null || itemDropRule21 != null)
									{
										return;
									}
								}
							}
						}
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06004569 RID: 17769 RVA: 0x00252048 File Offset: 0x00250248
		private void RegisterBoss_SkeletronPrime()
		{
			IItemDropRule itemDropRule = ItemDropRule.BossBag(3327);
			IItemDropRule itemDropRule2 = this.RegisterToNPC(127, itemDropRule);
			IItemDropRule itemDropRule3 = ItemDropRule.MasterModeCommonDrop(4933);
			IItemDropRule itemDropRule4 = this.RegisterToNPC(127, itemDropRule3);
			int masterModeDropRng = this._masterModeDropRng;
			IItemDropRule itemDropRule5 = ItemDropRule.MasterModeDropOnAllPlayers(4805, masterModeDropRng);
			IItemDropRule itemDropRule6 = this.RegisterToNPC(127, itemDropRule5);
			IItemDropRule itemDropRule8;
			IItemDropRule itemDropRule7 = this.RegisterToNPC(127, itemDropRule8);
			IItemDropRule itemDropRule10;
			IItemDropRule itemDropRule9 = this.RegisterToNPC(127, itemDropRule10);
			IItemDropRule itemDropRule12;
			IItemDropRule itemDropRule11 = this.RegisterToNPC(127, itemDropRule12);
			IItemDropRule itemDropRule14;
			IItemDropRule itemDropRule13 = this.RegisterToNPC(127, itemDropRule14);
		}

		// Token: 0x0600456A RID: 17770 RVA: 0x002520D4 File Offset: 0x002502D4
		private void RegisterBoss_TheDestroyer()
		{
			IItemDropRule itemDropRule = ItemDropRule.BossBag(3325);
			IItemDropRule itemDropRule2 = this.RegisterToNPC(134, itemDropRule);
			IItemDropRule itemDropRule3 = ItemDropRule.MasterModeCommonDrop(4932);
			IItemDropRule itemDropRule4 = this.RegisterToNPC(134, itemDropRule3);
			int masterModeDropRng = this._masterModeDropRng;
			IItemDropRule itemDropRule5 = ItemDropRule.MasterModeDropOnAllPlayers(4803, masterModeDropRng);
			IItemDropRule itemDropRule6 = this.RegisterToNPC(134, itemDropRule5);
			IItemDropRule itemDropRule8;
			IItemDropRule itemDropRule7 = this.RegisterToNPC(134, itemDropRule8);
			IItemDropRule itemDropRule10;
			IItemDropRule itemDropRule9 = this.RegisterToNPC(134, itemDropRule10);
			IItemDropRule itemDropRule12;
			IItemDropRule itemDropRule11 = this.RegisterToNPC(134, itemDropRule12);
			IItemDropRule itemDropRule14;
			IItemDropRule itemDropRule13 = this.RegisterToNPC(134, itemDropRule14);
		}

		// Token: 0x0600456B RID: 17771 RVA: 0x00252174 File Offset: 0x00250374
		private void RegisterBoss_Twins()
		{
			IItemDropRule itemDropRule = ItemDropRule.BossBag(3326);
			IItemDropRule itemDropRule2 = ItemDropRule.Common(2106, 7, 1, 1);
			IItemDropRule itemDropRule3 = ItemDropRule.Common(1225, 1, 15, 30);
			long num = 0L;
			IItemDropRule itemDropRule4 = itemDropRule3.OnSuccess(itemDropRule3, num != 0L);
			IItemDropRule itemDropRule5 = ItemDropRule.Common(549, 1, 25, 40);
			IItemDropRule itemDropRule6 = ItemDropRule.MasterModeCommonDrop(4931);
			int masterModeDropRng = this._masterModeDropRng;
			IItemDropRule itemDropRule7 = ItemDropRule.MasterModeDropOnAllPlayers(4804, masterModeDropRng);
		}

		// Token: 0x0600456C RID: 17772 RVA: 0x002521F0 File Offset: 0x002503F0
		private void RegisterBoss_EOC()
		{
			IItemDropRule itemDropRule = ItemDropRule.BossBag(3319);
			IItemDropRule itemDropRule2 = this.RegisterToNPC(4, itemDropRule);
			IItemDropRule itemDropRule4;
			IItemDropRule itemDropRule3 = this.RegisterToNPC(4, itemDropRule4);
			IItemDropRule itemDropRule5 = ItemDropRule.MasterModeCommonDrop(3763);
			int masterModeDropRng = this._masterModeDropRng;
			IItemDropRule itemDropRule6 = ItemDropRule.MasterModeDropOnAllPlayers(4798, masterModeDropRng);
			IItemDropRule itemDropRule7 = this.RegisterToNPC(4, itemDropRule6);
			IItemDropRule itemDropRule9;
			IItemDropRule itemDropRule8 = this.RegisterToNPC(4, itemDropRule9);
			IItemDropRule itemDropRule11;
			IItemDropRule itemDropRule10 = this.RegisterToNPC(4, itemDropRule11);
			IItemDropRule itemDropRule13;
			IItemDropRule itemDropRule12 = this.RegisterToNPC(4, itemDropRule13);
			IItemDropRule itemDropRule15;
			IItemDropRule itemDropRule14 = this.RegisterToNPC(4, itemDropRule15);
			IItemDropRule itemDropRule17;
			IItemDropRule itemDropRule16 = this.RegisterToNPC(4, itemDropRule17);
			IItemDropRule itemDropRule19;
			IItemDropRule itemDropRule18 = this.RegisterToNPC(4, itemDropRule19);
			IItemDropRule itemDropRule21;
			IItemDropRule itemDropRule20 = this.RegisterToNPC(4, itemDropRule21);
		}

		// Token: 0x0600456D RID: 17773 RVA: 0x00252294 File Offset: 0x00250494
		private void RegisterBoss_BOC()
		{
			IItemDropRule itemDropRule = ItemDropRule.BossBag(3321);
			IItemDropRule itemDropRule2 = this.RegisterToNPC(266, itemDropRule);
			IItemDropRule itemDropRule3 = ItemDropRule.MasterModeCommonDrop(4926);
			IItemDropRule itemDropRule4 = this.RegisterToNPC(266, itemDropRule3);
			int masterModeDropRng = this._masterModeDropRng;
			IItemDropRule itemDropRule5 = ItemDropRule.MasterModeDropOnAllPlayers(4800, masterModeDropRng);
			IItemDropRule itemDropRule6 = this.RegisterToNPC(266, itemDropRule5);
			IItemDropRule itemDropRule8;
			IItemDropRule itemDropRule7 = this.RegisterToNPC(266, itemDropRule8);
			IItemDropRule itemDropRule10;
			IItemDropRule itemDropRule9 = this.RegisterToNPC(266, itemDropRule10);
		}

		// Token: 0x0600456E RID: 17774 RVA: 0x00252314 File Offset: 0x00250514
		private void RegisterBoss_EOW()
		{
			IItemDropRule itemDropRule = ItemDropRule.Common(86, 2, 1, 2);
			IItemDropRule itemDropRule2 = ItemDropRule.Common(86, 5, 1, 2);
			IItemDropRule itemDropRule3 = ItemDropRule.Common(86, 10, 1, 2);
			IItemDropRule itemDropRule4 = ItemDropRule.Common(56, 2, 2, 5);
			IItemDropRule itemDropRule5 = ItemDropRule.Common(56, 2, 1, 3);
			IItemDropRule itemDropRule6 = ItemDropRule.Common(56, 3, 1, 2);
			IItemDropRule itemDropRule7 = ItemDropRule.MasterModeCommonDrop(4925);
			long num = 0L;
			IItemDropRule itemDropRule9;
			IItemDropRule itemDropRule8 = itemDropRule9.OnSuccess(itemDropRule7, num != 0L);
			int masterModeDropRng = this._masterModeDropRng;
			IItemDropRule itemDropRule10 = ItemDropRule.MasterModeDropOnAllPlayers(4799, masterModeDropRng);
			long num2 = 0L;
			IItemDropRule itemDropRule11 = itemDropRule9.OnSuccess(itemDropRule10, num2 != 0L);
		}

		// Token: 0x0600456F RID: 17775 RVA: 0x002523AC File Offset: 0x002505AC
		private void RegisterBoss_Deerclops()
		{
			IItemDropRule itemDropRule = ItemDropRule.BossBag(5111);
			IItemDropRule itemDropRule2 = this.RegisterToNPC(668, itemDropRule);
			IItemDropRule itemDropRule3 = ItemDropRule.MasterModeCommonDrop(5110);
			IItemDropRule itemDropRule4 = this.RegisterToNPC(668, itemDropRule3);
			int masterModeDropRng = this._masterModeDropRng;
			IItemDropRule itemDropRule5 = ItemDropRule.MasterModeDropOnAllPlayers(5090, masterModeDropRng);
			IItemDropRule itemDropRule6 = this.RegisterToNPC(668, itemDropRule5);
			IItemDropRule itemDropRule8;
			IItemDropRule itemDropRule7 = this.RegisterToNPC(668, itemDropRule8);
			IItemDropRule itemDropRule10;
			IItemDropRule itemDropRule9 = this.RegisterToNPC(5098, itemDropRule10);
			IItemDropRule itemDropRule12;
			IItemDropRule itemDropRule11 = this.RegisterToNPC(668, itemDropRule12);
			IItemDropRule itemDropRule14;
			IItemDropRule itemDropRule13 = this.RegisterToNPC(668, itemDropRule14);
			IItemDropRule itemDropRule16;
			IItemDropRule itemDropRule15 = this.RegisterToNPC(668, itemDropRule16);
			IItemDropRule itemDropRule17;
			if (itemDropRule17 == null || itemDropRule17 != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06004570 RID: 17776 RVA: 0x00252468 File Offset: 0x00250668
		private void RegisterBoss_QueenBee()
		{
			IItemDropRule itemDropRule = ItemDropRule.BossBag(3322);
			IItemDropRule itemDropRule2 = this.RegisterToNPC(222, itemDropRule);
			IItemDropRule itemDropRule3 = ItemDropRule.MasterModeCommonDrop(4928);
			IItemDropRule itemDropRule4 = this.RegisterToNPC(222, itemDropRule3);
			int masterModeDropRng = this._masterModeDropRng;
			IItemDropRule itemDropRule5 = ItemDropRule.MasterModeDropOnAllPlayers(4802, masterModeDropRng);
			IItemDropRule itemDropRule7;
			IItemDropRule itemDropRule6 = this.RegisterToNPC(222, itemDropRule7);
			IItemDropRule itemDropRule8 = ItemDropRule.DropNothing();
			IItemDropRule itemDropRule10;
			IItemDropRule itemDropRule9 = this.RegisterToNPC(222, itemDropRule10);
			IItemDropRule itemDropRule12;
			IItemDropRule itemDropRule11 = this.RegisterToNPC(222, itemDropRule12);
			IItemDropRule itemDropRule14;
			IItemDropRule itemDropRule13 = this.RegisterToNPC(222, itemDropRule14);
			IItemDropRule itemDropRule16;
			IItemDropRule itemDropRule15 = this.RegisterToNPC(222, itemDropRule16);
			long num = 0L;
			IItemDropRule itemDropRule18;
			IItemDropRule itemDropRule17 = itemDropRule15.OnFailedRoll(itemDropRule18, num != 0L);
			IItemDropRule itemDropRule20;
			IItemDropRule itemDropRule19 = this.RegisterToNPC(222, itemDropRule20);
			IItemDropRule itemDropRule22;
			IItemDropRule itemDropRule21 = this.RegisterToNPC(222, itemDropRule22);
		}

		// Token: 0x06004571 RID: 17777 RVA: 0x00252540 File Offset: 0x00250740
		private void RegisterBoss_Skeletron()
		{
			IItemDropRule itemDropRule = ItemDropRule.BossBag(3323);
			IItemDropRule itemDropRule2 = this.RegisterToNPC(35, itemDropRule);
			IItemDropRule itemDropRule3 = ItemDropRule.MasterModeCommonDrop(4927);
			IItemDropRule itemDropRule4 = this.RegisterToNPC(35, itemDropRule3);
			int masterModeDropRng = this._masterModeDropRng;
			IItemDropRule itemDropRule5 = ItemDropRule.MasterModeDropOnAllPlayers(4801, masterModeDropRng);
			IItemDropRule itemDropRule6 = this.RegisterToNPC(35, itemDropRule5);
			IItemDropRule itemDropRule8;
			IItemDropRule itemDropRule7 = this.RegisterToNPC(35, itemDropRule8);
			IItemDropRule itemDropRule9 = ItemDropRule.Common(1273, 7, 1, 1);
			long num = 0L;
			IItemDropRule itemDropRule10 = itemDropRule7.OnFailedRoll(itemDropRule9, num != 0L);
			IItemDropRule itemDropRule11 = ItemDropRule.Common(1313, 7, 1, 1);
			long num2 = 0L;
			IItemDropRule itemDropRule12 = itemDropRule10.OnFailedRoll(itemDropRule11, num2 != 0L);
			IItemDropRule itemDropRule13 = ItemDropRule.Common(4993, 7, 1, 1);
			IItemDropRule itemDropRule14 = this.RegisterToNPC(35, itemDropRule13);
		}

		// Token: 0x06004572 RID: 17778 RVA: 0x00252600 File Offset: 0x00250800
		private void RegisterBoss_WOF()
		{
			IItemDropRule itemDropRule = ItemDropRule.BossBag(3324);
			IItemDropRule itemDropRule2 = this.RegisterToNPC(113, itemDropRule);
			IItemDropRule itemDropRule3 = ItemDropRule.MasterModeCommonDrop(4930);
			IItemDropRule itemDropRule4 = this.RegisterToNPC(113, itemDropRule3);
			int masterModeDropRng = this._masterModeDropRng;
			IItemDropRule itemDropRule5 = ItemDropRule.MasterModeDropOnAllPlayers(4795, masterModeDropRng);
			IItemDropRule itemDropRule6 = this.RegisterToNPC(113, itemDropRule5);
			IItemDropRule itemDropRule8;
			IItemDropRule itemDropRule7 = this.RegisterToNPC(113, itemDropRule8);
			IItemDropRule itemDropRule10;
			IItemDropRule itemDropRule9 = this.RegisterToNPC(113, itemDropRule10);
			long num = 0L;
			IItemDropRule itemDropRule12;
			IItemDropRule itemDropRule13;
			IItemDropRule itemDropRule11 = itemDropRule12.OnSuccess(itemDropRule13, num != 0L);
			long num2 = 0L;
			IItemDropRule itemDropRule15;
			IItemDropRule itemDropRule16;
			IItemDropRule itemDropRule14 = itemDropRule15.OnSuccess(itemDropRule16, num2 != 0L);
		}

		// Token: 0x06004573 RID: 17779 RVA: 0x00252694 File Offset: 0x00250894
		private void RegisterBoss_AncientCultist()
		{
			IItemDropRule itemDropRule = ItemDropRule.MasterModeCommonDrop(4937);
			IItemDropRule itemDropRule2 = this.RegisterToNPC(439, itemDropRule);
			int masterModeDropRng = this._masterModeDropRng;
			IItemDropRule itemDropRule3 = ItemDropRule.MasterModeDropOnAllPlayers(4809, masterModeDropRng);
			IItemDropRule itemDropRule4 = this.RegisterToNPC(439, itemDropRule3);
			IItemDropRule itemDropRule5 = ItemDropRule.Common(3372, 7, 1, 1);
			IItemDropRule itemDropRule6 = this.RegisterToNPC(439, itemDropRule5);
			IItemDropRule itemDropRule7 = ItemDropRule.Common(3549, 1, 1, 1);
			IItemDropRule itemDropRule8 = this.RegisterToNPC(439, itemDropRule7);
		}

		// Token: 0x06004574 RID: 17780 RVA: 0x00252718 File Offset: 0x00250918
		private void RegisterBoss_MoonLord()
		{
			IItemDropRule itemDropRule = ItemDropRule.BossBag(3332);
			IItemDropRule itemDropRule2 = this.RegisterToNPC(398, itemDropRule);
			IItemDropRule itemDropRule3 = ItemDropRule.MasterModeCommonDrop(4938);
			IItemDropRule itemDropRule4 = this.RegisterToNPC(398, itemDropRule3);
			int masterModeDropRng = this._masterModeDropRng;
			IItemDropRule itemDropRule5 = ItemDropRule.MasterModeDropOnAllPlayers(4810, masterModeDropRng);
			IItemDropRule itemDropRule6 = this.RegisterToNPC(398, itemDropRule5);
			IItemDropRule itemDropRule8;
			IItemDropRule itemDropRule7 = this.RegisterToNPC(398, itemDropRule8);
			IItemDropRule itemDropRule10;
			IItemDropRule itemDropRule9 = this.RegisterToNPC(398, itemDropRule10);
			IItemDropRule itemDropRule12;
			IItemDropRule itemDropRule11 = this.RegisterToNPC(398, itemDropRule12);
		}

		// Token: 0x06004575 RID: 17781 RVA: 0x002527A8 File Offset: 0x002509A8
		private void RegisterBoss_LunarTowers()
		{
		}

		// Token: 0x06004576 RID: 17782 RVA: 0x002527B8 File Offset: 0x002509B8
		private void RegisterBoss_Betsy()
		{
			IItemDropRule itemDropRule = ItemDropRule.BossBag(3860);
			IItemDropRule itemDropRule2 = this.RegisterToNPC(551, itemDropRule);
			IItemDropRule itemDropRule3 = ItemDropRule.MasterModeCommonDrop(4948);
			IItemDropRule itemDropRule4 = this.RegisterToNPC(551, itemDropRule3);
			int masterModeDropRng = this._masterModeDropRng;
			IItemDropRule itemDropRule5 = ItemDropRule.MasterModeDropOnAllPlayers(4817, masterModeDropRng);
			IItemDropRule itemDropRule6 = this.RegisterToNPC(551, itemDropRule5);
			IItemDropRule itemDropRule8;
			IItemDropRule itemDropRule7 = this.RegisterToNPC(551, itemDropRule8);
			IItemDropRule itemDropRule10;
			IItemDropRule itemDropRule9 = this.RegisterToNPC(551, itemDropRule10);
			long num = 0L;
			IItemDropRule itemDropRule12;
			IItemDropRule itemDropRule13;
			IItemDropRule itemDropRule11 = itemDropRule12.OnSuccess(itemDropRule13, num != 0L);
		}

		// Token: 0x06004577 RID: 17783 RVA: 0x00252848 File Offset: 0x00250A48
		private void RegisterBoss_Golem()
		{
			IItemDropRule itemDropRule = ItemDropRule.BossBag(3329);
			IItemDropRule itemDropRule2 = this.RegisterToNPC(245, itemDropRule);
			IItemDropRule itemDropRule3 = ItemDropRule.MasterModeCommonDrop(4935);
			IItemDropRule itemDropRule4 = this.RegisterToNPC(245, itemDropRule3);
			int masterModeDropRng = this._masterModeDropRng;
			IItemDropRule itemDropRule5 = ItemDropRule.MasterModeDropOnAllPlayers(4807, masterModeDropRng);
			IItemDropRule itemDropRule6 = this.RegisterToNPC(245, itemDropRule5);
			IItemDropRule itemDropRule8;
			IItemDropRule itemDropRule7 = this.RegisterToNPC(245, itemDropRule8);
			IItemDropRule itemDropRule10;
			IItemDropRule itemDropRule9 = this.RegisterToNPC(245, itemDropRule10);
			IItemDropRule itemDropRule11 = ItemDropRule.Common(1258, 1, 1, 1);
			IItemDropRule itemDropRule12 = ItemDropRule.Common(1261, 1, 60, 180);
			IItemDropRule itemDropRule13 = itemDropRule11.OnSuccess(itemDropRule12, true);
			if (itemDropRule11 == null || itemDropRule11 != null)
			{
				IItemDropRule itemDropRule14 = ItemDropRule.Common(1122, 1, 1, 1);
				if (itemDropRule14 == null || itemDropRule14 != null)
				{
					IItemDropRule itemDropRule15 = ItemDropRule.Common(899, 1, 1, 1);
					if (itemDropRule15 == null || itemDropRule15 != null)
					{
						IItemDropRule itemDropRule16 = ItemDropRule.Common(1248, 1, 1, 1);
						if (itemDropRule16 == null || itemDropRule16 != null)
						{
							IItemDropRule itemDropRule17 = ItemDropRule.Common(1295, 1, 1, 1);
							if (itemDropRule17 == null || itemDropRule17 != null)
							{
								IItemDropRule itemDropRule18 = ItemDropRule.Common(1296, 1, 1, 1);
								if (itemDropRule18 == null || itemDropRule18 != null)
								{
									IItemDropRule itemDropRule19 = ItemDropRule.Common(1297, 1, 1, 1);
									if (itemDropRule19 == null || itemDropRule19 != null)
									{
										IItemDropRule itemDropRule21;
										IItemDropRule itemDropRule20 = this.RegisterToNPC(245, itemDropRule21);
										return;
									}
								}
							}
						}
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06004578 RID: 17784 RVA: 0x002529A8 File Offset: 0x00250BA8
		private void RegisterBoss_DukeFishron()
		{
			IItemDropRule itemDropRule = ItemDropRule.BossBag(3330);
			IItemDropRule itemDropRule2 = this.RegisterToNPC(370, itemDropRule);
			IItemDropRule itemDropRule3 = ItemDropRule.MasterModeCommonDrop(4936);
			IItemDropRule itemDropRule4 = this.RegisterToNPC(370, itemDropRule3);
			int masterModeDropRng = this._masterModeDropRng;
			IItemDropRule itemDropRule5 = ItemDropRule.MasterModeDropOnAllPlayers(4808, masterModeDropRng);
			IItemDropRule itemDropRule6 = this.RegisterToNPC(370, itemDropRule5);
			IItemDropRule itemDropRule8;
			IItemDropRule itemDropRule7 = this.RegisterToNPC(370, itemDropRule8);
			IItemDropRule itemDropRule10;
			IItemDropRule itemDropRule9 = this.RegisterToNPC(370, itemDropRule10);
			long num = 0L;
			IItemDropRule itemDropRule12;
			IItemDropRule itemDropRule13;
			IItemDropRule itemDropRule11 = itemDropRule12.OnSuccess(itemDropRule13, num != 0L);
			long num2 = 0L;
			IItemDropRule itemDropRule15;
			IItemDropRule itemDropRule16;
			IItemDropRule itemDropRule14 = itemDropRule15.OnSuccess(itemDropRule16, num2 != 0L);
		}

		// Token: 0x06004579 RID: 17785 RVA: 0x00252A48 File Offset: 0x00250C48
		private void RegisterWeirdRules()
		{
			IItemDropRule itemDropRule = ItemDropRule.NormalvsExpert(3260, 40, 30);
		}

		// Token: 0x0600457A RID: 17786 RVA: 0x00252A64 File Offset: 0x00250C64
		private void RegisterGlobalRules()
		{
			IItemDropRule itemDropRule2;
			IItemDropRule itemDropRule = this.RegisterToGlobal(itemDropRule2);
			IItemDropRule itemDropRule3 = ItemDropRule.Common(1827, 2000, 1, 1);
			long num = 0L;
			IItemDropRule itemDropRule4 = itemDropRule.OnFailedRoll(itemDropRule3, num != 0L);
			IItemDropRule itemDropRule6;
			IItemDropRule itemDropRule5 = this.RegisterToGlobal(itemDropRule6);
		}

		// Token: 0x0600457B RID: 17787 RVA: 0x00252AA8 File Offset: 0x00250CA8
		private void RegisterFoodDrops()
		{
			IItemDropRule itemDropRule = ItemDropRule.Food(4016, 50, 1, 1);
			IItemDropRule itemDropRule2 = this.RegisterToNPC(48, itemDropRule);
			IItemDropRule itemDropRule3 = ItemDropRule.Food(4021, 50, 1, 1);
			IItemDropRule itemDropRule4 = this.RegisterToNPC(224, itemDropRule3);
			IItemDropRule itemDropRule5 = ItemDropRule.Food(4037, 10, 1, 1);
			IItemDropRule itemDropRule6 = this.RegisterToNPC(44, itemDropRule5);
			IItemDropRule itemDropRule7 = ItemDropRule.Food(4037, 100, 1, 1);
			IItemDropRule itemDropRule8 = this.RegisterToNPC(469, itemDropRule7);
			IItemDropRule itemDropRule9 = ItemDropRule.Food(4020, 30, 1, 1);
			IItemDropRule itemDropRule10 = ItemDropRule.Food(4029, 50, 1, 1);
			IItemDropRule itemDropRule11 = ItemDropRule.Food(4030, 75, 1, 1);
			IItemDropRule itemDropRule12 = ItemDropRule.Food(4036, 50, 1, 1);
			IItemDropRule itemDropRule13 = ItemDropRule.Food(4015, 100, 1, 1);
			IItemDropRule itemDropRule14 = ItemDropRule.Food(4026, 150, 1, 1);
			IItemDropRule itemDropRule15 = ItemDropRule.Food(4027, 75, 1, 1);
			IItemDropRule itemDropRule16 = ItemDropRule.Food(3532, 15, 1, 1);
			IItemDropRule itemDropRule17 = ItemDropRule.Food(4018, 35, 1, 1);
			IItemDropRule itemDropRule18 = this.RegisterToNPC(289, itemDropRule17);
			IItemDropRule itemDropRule19 = ItemDropRule.Food(4018, 70, 1, 1);
			IItemDropRule itemDropRule20 = this.RegisterToNPC(34, itemDropRule19);
			IItemDropRule itemDropRule21 = ItemDropRule.Food(4013, 21, 1, 1);
			IItemDropRule itemDropRule22 = ItemDropRule.Food(5042, 30, 1, 1);
			IItemDropRule itemDropRule23 = ItemDropRule.Food(5042, 10, 1, 1);
			IItemDropRule itemDropRule24 = this.RegisterToNPC(287, itemDropRule23);
			IItemDropRule itemDropRule25 = ItemDropRule.Food(5041, 150, 1, 1);
			IItemDropRule itemDropRule26 = ItemDropRule.Food(4013, 7, 1, 1);
			IItemDropRule itemDropRule27 = this.RegisterToNPC(290, itemDropRule26);
			IItemDropRule itemDropRule28 = ItemDropRule.Food(4025, 30, 1, 1);
			IItemDropRule itemDropRule29 = ItemDropRule.Food(4023, 40, 1, 1);
			IItemDropRule itemDropRule30 = ItemDropRule.Food(4012, 50, 1, 1);
			IItemDropRule itemDropRule31 = ItemDropRule.Food(4028, 30, 1, 1);
			IItemDropRule itemDropRule32 = ItemDropRule.Food(4035, 50, 1, 1);
			IItemDropRule itemDropRule33 = ItemDropRule.Food(4017, 75, 1, 1);
			IItemDropRule itemDropRule34 = this.RegisterToNPC(122, itemDropRule33);
		}

		// Token: 0x0600457C RID: 17788 RVA: 0x00252CC0 File Offset: 0x00250EC0
		private void RegisterTownNPCDrops()
		{
			IItemDropRule itemDropRule = ItemDropRule.Common(3352, 8, 1, 1);
			IItemDropRule itemDropRule2 = this.RegisterToNPC(353, itemDropRule);
			IItemDropRule itemDropRule3 = ItemDropRule.Common(3351, 8, 1, 1);
			IItemDropRule itemDropRule4 = this.RegisterToNPC(441, itemDropRule3);
			IItemDropRule itemDropRule5 = ItemDropRule.Common(3350, 10, 1, 1);
			IItemDropRule itemDropRule6 = this.RegisterToNPC(227, itemDropRule5);
			IItemDropRule itemDropRule7 = ItemDropRule.Common(3821, 6, 1, 1);
			IItemDropRule itemDropRule8 = this.RegisterToNPC(550, itemDropRule7);
			IItemDropRule itemDropRule9 = ItemDropRule.Common(3548, 4, 30, 60);
			IItemDropRule itemDropRule10 = this.RegisterToNPC(208, itemDropRule9);
			IItemDropRule itemDropRule11 = ItemDropRule.Common(3349, 8, 1, 1);
			IItemDropRule itemDropRule12 = this.RegisterToNPC(207, itemDropRule11);
			IItemDropRule itemDropRule13 = ItemDropRule.Common(4818, 8, 1, 1);
			IItemDropRule itemDropRule14 = this.RegisterToNPC(124, itemDropRule13);
			IItemDropRule itemDropRule16;
			IItemDropRule itemDropRule15 = this.RegisterToNPC(663, itemDropRule16);
			IItemDropRule itemDropRule17 = ItemDropRule.Common(260, 1, 1, 1);
			IItemDropRule itemDropRule18 = this.RegisterToNPC(54, itemDropRule17);
			IItemDropRule itemDropRule19 = ItemDropRule.Common(2222, 1, 1, 1);
			IItemDropRule itemDropRule20 = this.RegisterToNPC(368, itemDropRule19);
		}

		// Token: 0x0600457D RID: 17789 RVA: 0x00252DE8 File Offset: 0x00250FE8
		private void RegisterDD2EventDrops()
		{
			IItemDropRule itemDropRule2;
			IItemDropRule itemDropRule = this.RegisterToNPC(576, itemDropRule2);
			IItemDropRule itemDropRule4;
			IItemDropRule itemDropRule3 = this.RegisterToNPC(576, itemDropRule4);
			IItemDropRule itemDropRule5 = ItemDropRule.NormalvsExpertNotScalingWithLuck(3856, 5, 4);
			IItemDropRule itemDropRule6 = this.RegisterToNPC(576, itemDropRule5);
			IItemDropRule itemDropRule7 = ItemDropRule.MasterModeCommonDrop(4947);
			IItemDropRule itemDropRule8 = this.RegisterToNPC(577, itemDropRule7);
			int masterModeDropRng = this._masterModeDropRng;
			IItemDropRule itemDropRule9 = ItemDropRule.MasterModeDropOnAllPlayers(4816, masterModeDropRng);
			IItemDropRule itemDropRule10 = this.RegisterToNPC(577, itemDropRule9);
			IItemDropRule itemDropRule12;
			IItemDropRule itemDropRule11 = this.RegisterToNPC(577, itemDropRule12);
			IItemDropRule itemDropRule14;
			IItemDropRule itemDropRule13 = this.RegisterToNPC(577, itemDropRule14);
			IItemDropRule itemDropRule15 = ItemDropRule.Common(3856, 10, 1, 1);
			IItemDropRule itemDropRule16 = this.RegisterToNPC(577, itemDropRule15);
			IItemDropRule itemDropRule17 = ItemDropRule.Common(3864, 7, 1, 1);
			IItemDropRule itemDropRule18 = this.RegisterToNPC(564, itemDropRule17);
			int masterModeDropRng2 = this._masterModeDropRng;
			IItemDropRule itemDropRule19 = ItemDropRule.MasterModeDropOnAllPlayers(4796, masterModeDropRng2);
			IItemDropRule itemDropRule20 = this.RegisterToNPC(564, itemDropRule19);
			IItemDropRule itemDropRule22;
			IItemDropRule itemDropRule21 = this.RegisterToNPC(564, itemDropRule22);
			IItemDropRule itemDropRule23 = ItemDropRule.NotScalingWithLuck(3814, 2, 1, 1);
			IItemDropRule itemDropRule24 = ItemDropRule.NotScalingWithLuck(3814, 1, 1, 1);
			IItemDropRule itemDropRule25 = ItemDropRule.NotScalingWithLuck(3815, 2, 4, 4);
			IItemDropRule itemDropRule26 = ItemDropRule.NotScalingWithLuck(3815, 1, 4, 4);
			IItemDropRule itemDropRule28;
			IItemDropRule itemDropRule27 = this.RegisterToNPC(564, itemDropRule28);
			IItemDropRule itemDropRule29 = ItemDropRule.Common(3864, 14, 1, 1);
			IItemDropRule itemDropRule30 = this.RegisterToNPC(565, itemDropRule29);
			IItemDropRule itemDropRule31 = ItemDropRule.MasterModeCommonDrop(4946);
			IItemDropRule itemDropRule32 = this.RegisterToNPC(565, itemDropRule31);
			int masterModeDropRng3 = this._masterModeDropRng;
			IItemDropRule itemDropRule33 = ItemDropRule.MasterModeDropOnAllPlayers(4796, masterModeDropRng3);
			IItemDropRule itemDropRule34 = this.RegisterToNPC(565, itemDropRule33);
			IItemDropRule itemDropRule36;
			IItemDropRule itemDropRule35 = this.RegisterToNPC(565, itemDropRule36);
			IItemDropRule itemDropRule37 = ItemDropRule.NotScalingWithLuck(3814, 8, 1, 1);
			IItemDropRule itemDropRule38 = ItemDropRule.NotScalingWithLuck(3814, 4, 1, 1);
			IItemDropRule itemDropRule39 = ItemDropRule.NotScalingWithLuck(3815, 8, 4, 4);
			IItemDropRule itemDropRule40 = ItemDropRule.NotScalingWithLuck(3815, 4, 4, 4);
			IItemDropRule itemDropRule42;
			IItemDropRule itemDropRule41 = this.RegisterToNPC(565, itemDropRule42);
		}

		// Token: 0x0600457E RID: 17790 RVA: 0x00253000 File Offset: 0x00251200
		private void RegisterHardmodeFeathers()
		{
			IItemDropRule itemDropRule = ItemDropRule.Common(1518, 50, 1, 1);
			IItemDropRule itemDropRule2 = this.RegisterToNPC(156, itemDropRule);
			IItemDropRule itemDropRule3 = ItemDropRule.Common(1519, 3, 1, 1);
			IItemDropRule itemDropRule4 = this.RegisterToNPC(243, itemDropRule3);
			IItemDropRule itemDropRule5 = ItemDropRule.Common(1517, 300, 1, 1);
			IItemDropRule itemDropRule6 = ItemDropRule.Common(1520, 40, 1, 1);
			IItemDropRule itemDropRule7 = ItemDropRule.Common(1516, 150, 1, 1);
			IItemDropRule itemDropRule8 = this.RegisterToNPC(48, itemDropRule7);
		}

		// Token: 0x0600457F RID: 17791 RVA: 0x00253088 File Offset: 0x00251288
		private void RegisterYoyos()
		{
		}

		// Token: 0x06004580 RID: 17792 RVA: 0x00253098 File Offset: 0x00251298
		private void RegisterStatusImmunityItems()
		{
			IItemDropRule itemDropRule = ItemDropRule.StatusImmunityItem(885, 100);
			IItemDropRule itemDropRule2 = ItemDropRule.StatusImmunityItem(886, 100);
			IItemDropRule itemDropRule3 = ItemDropRule.StatusImmunityItem(887, 100);
			IItemDropRule itemDropRule4 = ItemDropRule.StatusImmunityItem(888, 100);
			IItemDropRule itemDropRule5 = ItemDropRule.StatusImmunityItem(889, 100);
			IItemDropRule itemDropRule6 = ItemDropRule.StatusImmunityItem(890, 100);
			IItemDropRule itemDropRule7 = ItemDropRule.StatusImmunityItem(891, 100);
			IItemDropRule itemDropRule8 = ItemDropRule.StatusImmunityItem(892, 100);
			IItemDropRule itemDropRule9 = ItemDropRule.StatusImmunityItem(893, 100);
		}

		// Token: 0x06004581 RID: 17793 RVA: 0x00253124 File Offset: 0x00251324
		private void RegisterPirateDrops()
		{
			IItemDropRule itemDropRule = ItemDropRule.Common(905, 4000, 1, 1);
			IItemDropRule itemDropRule2 = ItemDropRule.Common(855, 2000, 1, 1);
			IItemDropRule itemDropRule3 = ItemDropRule.Common(854, 1000, 1, 1);
			IItemDropRule itemDropRule4 = ItemDropRule.Common(2584, 1000, 1, 1);
			IItemDropRule itemDropRule5 = ItemDropRule.Common(3033, 500, 1, 1);
			IItemDropRule itemDropRule6 = ItemDropRule.Common(672, 200, 1, 1);
			IItemDropRule itemDropRule7 = ItemDropRule.Common(1277, 500, 1, 1);
			IItemDropRule itemDropRule8 = ItemDropRule.Common(1278, 500, 1, 1);
			IItemDropRule itemDropRule9 = ItemDropRule.Common(1279, 500, 1, 1);
			IItemDropRule itemDropRule10 = ItemDropRule.Common(1280, 500, 1, 1);
			IItemDropRule itemDropRule11 = ItemDropRule.Common(1704, 300, 1, 1);
			IItemDropRule itemDropRule12 = ItemDropRule.Common(1705, 300, 1, 1);
			IItemDropRule itemDropRule13 = ItemDropRule.Common(1710, 300, 1, 1);
			IItemDropRule itemDropRule14 = ItemDropRule.Common(1716, 300, 1, 1);
			IItemDropRule itemDropRule15 = ItemDropRule.Common(1720, 300, 1, 1);
			IItemDropRule itemDropRule16 = ItemDropRule.Common(2379, 300, 1, 1);
			IItemDropRule itemDropRule17 = ItemDropRule.Common(2389, 300, 1, 1);
			IItemDropRule itemDropRule18 = ItemDropRule.Common(2405, 300, 1, 1);
			IItemDropRule itemDropRule19 = ItemDropRule.Common(2843, 300, 1, 1);
			IItemDropRule itemDropRule20 = ItemDropRule.Common(3885, 300, 1, 1);
			IItemDropRule itemDropRule21 = ItemDropRule.Common(2663, 300, 1, 1);
			IItemDropRule itemDropRule22 = ItemDropRule.Common(3904, 150, 80, 130);
			IItemDropRule itemDropRule23 = ItemDropRule.Common(3910, 300, 1, 1);
			IItemDropRule itemDropRule24 = ItemDropRule.Common(2238, 300, 1, 1);
			IItemDropRule itemDropRule25 = ItemDropRule.Common(2133, 300, 1, 1);
			IItemDropRule itemDropRule26 = ItemDropRule.Common(2137, 300, 1, 1);
			IItemDropRule itemDropRule27 = ItemDropRule.Common(2143, 300, 1, 1);
			IItemDropRule itemDropRule28 = ItemDropRule.Common(2147, 300, 1, 1);
			IItemDropRule itemDropRule29 = ItemDropRule.Common(2151, 300, 1, 1);
			IItemDropRule itemDropRule30 = ItemDropRule.Common(2155, 300, 1, 1);
			IItemDropRule itemDropRule31 = ItemDropRule.Common(3263, 500, 1, 1);
			IItemDropRule itemDropRule32 = ItemDropRule.Common(3264, 500, 1, 1);
			IItemDropRule itemDropRule33 = ItemDropRule.Common(3265, 500, 1, 1);
			IItemDropRule itemDropRule34 = ItemDropRule.Common(905, 1000, 1, 1);
			IItemDropRule itemDropRule35 = this.RegisterToNPC(216, itemDropRule34);
			IItemDropRule itemDropRule36 = ItemDropRule.Common(855, 500, 1, 1);
			IItemDropRule itemDropRule37 = this.RegisterToNPC(216, itemDropRule36);
			IItemDropRule itemDropRule38 = ItemDropRule.Common(854, 250, 1, 1);
			IItemDropRule itemDropRule39 = ItemDropRule.Common(2584, 250, 1, 1);
			IItemDropRule itemDropRule40 = this.RegisterToNPC(216, itemDropRule39);
			IItemDropRule itemDropRule41 = ItemDropRule.Common(3033, 125, 1, 1);
			IItemDropRule itemDropRule42 = this.RegisterToNPC(216, itemDropRule41);
			IItemDropRule itemDropRule43 = ItemDropRule.Common(672, 50, 1, 1);
			IItemDropRule itemDropRule44 = this.RegisterToNPC(216, itemDropRule43);
			IItemDropRule itemDropRule45 = ItemDropRule.Common(905, 50, 1, 1);
			IItemDropRule itemDropRule46 = this.RegisterToNPC(491, itemDropRule45);
			IItemDropRule itemDropRule47 = ItemDropRule.Common(855, 15, 1, 1);
			IItemDropRule itemDropRule48 = this.RegisterToNPC(491, itemDropRule47);
			IItemDropRule itemDropRule49 = ItemDropRule.Common(854, 15, 1, 1);
			IItemDropRule itemDropRule50 = this.RegisterToNPC(491, itemDropRule49);
			IItemDropRule itemDropRule51 = ItemDropRule.Common(2584, 15, 1, 1);
			IItemDropRule itemDropRule52 = this.RegisterToNPC(491, itemDropRule51);
			IItemDropRule itemDropRule53 = ItemDropRule.Common(3033, 15, 1, 1);
			IItemDropRule itemDropRule54 = this.RegisterToNPC(491, itemDropRule53);
			IItemDropRule itemDropRule55 = ItemDropRule.Common(4471, 20, 1, 1);
			IItemDropRule itemDropRule56 = this.RegisterToNPC(491, itemDropRule55);
			IItemDropRule itemDropRule57 = ItemDropRule.Common(672, 10, 1, 1);
			IItemDropRule itemDropRule58 = this.RegisterToNPC(491, itemDropRule57);
			IItemDropRule itemDropRule59 = ItemDropRule.MasterModeCommonDrop(4940);
			IItemDropRule itemDropRule60 = this.RegisterToNPC(491, itemDropRule59);
			int masterModeDropRng = this._masterModeDropRng;
			IItemDropRule itemDropRule61 = ItemDropRule.MasterModeDropOnAllPlayers(4792, masterModeDropRng);
			IItemDropRule itemDropRule62 = this.RegisterToNPC(491, itemDropRule61);
			IItemDropRule itemDropRule64;
			IItemDropRule itemDropRule63 = this.RegisterToNPC(491, itemDropRule64);
		}

		// Token: 0x06004582 RID: 17794 RVA: 0x00253588 File Offset: 0x00251788
		private void RegisterBloodMoonFishingEnemies()
		{
		}

		// Token: 0x06004583 RID: 17795 RVA: 0x00253598 File Offset: 0x00251798
		private void RegisterBossTrophies()
		{
			IItemDropRule itemDropRule2;
			IItemDropRule itemDropRule = this.RegisterToNPC(4, itemDropRule2);
			IItemDropRule itemDropRule4;
			IItemDropRule itemDropRule3 = this.RegisterToNPC(13, itemDropRule4);
			IItemDropRule itemDropRule6;
			IItemDropRule itemDropRule5 = this.RegisterToNPC(14, itemDropRule6);
			IItemDropRule itemDropRule8;
			IItemDropRule itemDropRule7 = this.RegisterToNPC(15, itemDropRule8);
			IItemDropRule itemDropRule10;
			IItemDropRule itemDropRule9 = this.RegisterToNPC(266, itemDropRule10);
			IItemDropRule itemDropRule12;
			IItemDropRule itemDropRule11 = this.RegisterToNPC(35, itemDropRule12);
			IItemDropRule itemDropRule14;
			IItemDropRule itemDropRule13 = this.RegisterToNPC(222, itemDropRule14);
			IItemDropRule itemDropRule16;
			IItemDropRule itemDropRule15 = this.RegisterToNPC(113, itemDropRule16);
			IItemDropRule itemDropRule18;
			IItemDropRule itemDropRule17 = this.RegisterToNPC(134, itemDropRule18);
			IItemDropRule itemDropRule20;
			IItemDropRule itemDropRule19 = this.RegisterToNPC(127, itemDropRule20);
			IItemDropRule itemDropRule22;
			IItemDropRule itemDropRule21 = this.RegisterToNPC(262, itemDropRule22);
			IItemDropRule itemDropRule24;
			IItemDropRule itemDropRule23 = this.RegisterToNPC(245, itemDropRule24);
			IItemDropRule itemDropRule26;
			IItemDropRule itemDropRule25 = this.RegisterToNPC(50, itemDropRule26);
			IItemDropRule itemDropRule28;
			IItemDropRule itemDropRule27 = this.RegisterToNPC(439, itemDropRule28);
			IItemDropRule itemDropRule30;
			IItemDropRule itemDropRule29 = this.RegisterToNPC(395, itemDropRule30);
			IItemDropRule itemDropRule32;
			IItemDropRule itemDropRule31 = this.RegisterToNPC(398, itemDropRule32);
			IItemDropRule itemDropRule34;
			IItemDropRule itemDropRule33 = this.RegisterToNPC(636, itemDropRule34);
			IItemDropRule itemDropRule36;
			IItemDropRule itemDropRule35 = this.RegisterToNPC(657, itemDropRule36);
			IItemDropRule itemDropRule38;
			IItemDropRule itemDropRule37 = this.RegisterToNPC(668, itemDropRule38);
			IItemDropRule itemDropRule39 = ItemDropRule.Common(1368, 10, 1, 1);
			IItemDropRule itemDropRule40 = this.RegisterToNPC(125, itemDropRule39);
			IItemDropRule itemDropRule41 = ItemDropRule.Common(1369, 10, 1, 1);
			IItemDropRule itemDropRule42 = this.RegisterToNPC(126, itemDropRule41);
			IItemDropRule itemDropRule43 = ItemDropRule.Common(3359, 10, 1, 1);
			IItemDropRule itemDropRule44 = this.RegisterToNPC(491, itemDropRule43);
			IItemDropRule itemDropRule45 = ItemDropRule.Common(3866, 10, 1, 1);
			IItemDropRule itemDropRule46 = this.RegisterToNPC(551, itemDropRule45);
			IItemDropRule itemDropRule47 = ItemDropRule.Common(3867, 10, 1, 1);
			IItemDropRule itemDropRule48 = this.RegisterToNPC(564, itemDropRule47);
			IItemDropRule itemDropRule49 = ItemDropRule.Common(3867, 10, 1, 1);
			IItemDropRule itemDropRule50 = this.RegisterToNPC(565, itemDropRule49);
			IItemDropRule itemDropRule51 = ItemDropRule.Common(3868, 10, 1, 1);
			IItemDropRule itemDropRule52 = this.RegisterToNPC(576, itemDropRule51);
			IItemDropRule itemDropRule53 = ItemDropRule.Common(3868, 10, 1, 1);
			IItemDropRule itemDropRule54 = this.RegisterToNPC(577, itemDropRule53);
		}

		// Token: 0x06004584 RID: 17796 RVA: 0x00253798 File Offset: 0x00251998
		private void RegisterMartianDrops()
		{
			IItemDropRule itemDropRule = ItemDropRule.Common(2860, 8, 8, 20);
			IItemDropRule itemDropRule2 = ItemDropRule.Common(2798, 800, 1, 1);
			IItemDropRule itemDropRule3 = ItemDropRule.Common(2800, 800, 1, 1);
			IItemDropRule itemDropRule4 = ItemDropRule.Common(2882, 800, 1, 1);
			IItemDropRule itemDropRule5 = ItemDropRule.Common(2806, 200, 1, 1);
			IItemDropRule itemDropRule6 = ItemDropRule.Common(2807, 200, 1, 1);
			IItemDropRule itemDropRule7 = ItemDropRule.Common(2808, 200, 1, 1);
			IItemDropRule itemDropRule8 = ItemDropRule.Common(2803, 200, 1, 1);
			IItemDropRule itemDropRule9 = ItemDropRule.Common(2804, 200, 1, 1);
			IItemDropRule itemDropRule10 = ItemDropRule.Common(2805, 200, 1, 1);
			IItemDropRule itemDropRule12;
			IItemDropRule itemDropRule11 = this.RegisterToNPC(395, itemDropRule12);
			IItemDropRule itemDropRule13 = ItemDropRule.MasterModeCommonDrop(4939);
			IItemDropRule itemDropRule14 = this.RegisterToNPC(395, itemDropRule13);
			int masterModeDropRng = this._masterModeDropRng;
			IItemDropRule itemDropRule15 = ItemDropRule.MasterModeDropOnAllPlayers(4815, masterModeDropRng);
			IItemDropRule itemDropRule16 = this.RegisterToNPC(395, itemDropRule15);
			IItemDropRule itemDropRule17 = ItemDropRule.Common(2771, 30, 1, 1);
			IItemDropRule itemDropRule18 = this.RegisterToNPC(390, itemDropRule17);
		}

		// Token: 0x06004585 RID: 17797 RVA: 0x002538CC File Offset: 0x00251ACC
		private void RegisterMiscDrops()
		{
			IItemDropRule itemDropRule = ItemDropRule.Common(1169, 1, 1, 1);
			IItemDropRule itemDropRule2 = this.RegisterToNPC(68, itemDropRule);
			IItemDropRule itemDropRule3 = ItemDropRule.Common(3086, 1, 5, 10);
			IItemDropRule itemDropRule4 = ItemDropRule.Common(723, 150, 1, 1);
			IItemDropRule itemDropRule5 = this.RegisterToNPC(77, itemDropRule4);
			IItemDropRule itemDropRule6 = ItemDropRule.NormalvsExpert(3102, 2, 1);
			IItemDropRule itemDropRule8;
			IItemDropRule itemDropRule7 = this.RegisterToNPC(471, itemDropRule8);
			IItemDropRule itemDropRule9 = ItemDropRule.Common(1328, 12, 1, 1);
			IItemDropRule itemDropRule10 = this.RegisterToNPC(153, itemDropRule9);
			IItemDropRule itemDropRule11 = ItemDropRule.Common(23, 1, 1, 2);
			long num = 0L;
			IItemDropRule itemDropRule13;
			IItemDropRule itemDropRule12 = itemDropRule13.OnSuccess(itemDropRule11, num != 0L);
			IItemDropRule itemDropRule14 = ItemDropRule.NormalvsExpert(1309, 8000, 5600);
			long num2 = 0L;
			IItemDropRule itemDropRule16;
			IItemDropRule itemDropRule15 = itemDropRule16.OnSuccess(itemDropRule14, num2 != 0L);
			IItemDropRule itemDropRule17 = ItemDropRule.Common(1326, 100, 1, 1);
			long num3 = 0L;
			IItemDropRule itemDropRule19;
			IItemDropRule itemDropRule18 = itemDropRule19.OnSuccess(itemDropRule17, num3 != 0L);
			IItemDropRule itemDropRule20 = ItemDropRule.NormalvsExpert(1326, 500, 400);
			long num4 = 0L;
			IItemDropRule itemDropRule22;
			IItemDropRule itemDropRule21 = itemDropRule22.OnSuccess(itemDropRule20, num4 != 0L);
			IItemDropRule itemDropRule23 = ItemDropRule.Common(1325, 250, 1, 1);
			long num5 = 0L;
			IItemDropRule itemDropRule25;
			IItemDropRule itemDropRule24 = itemDropRule25.OnSuccess(itemDropRule23, num5 != 0L);
			IItemDropRule itemDropRule26 = ItemDropRule.Common(1314, 250, 1, 1);
			long num6 = 0L;
			IItemDropRule itemDropRule28;
			IItemDropRule itemDropRule27 = itemDropRule28.OnSuccess(itemDropRule26, num6 != 0L);
			IItemDropRule itemDropRule29 = ItemDropRule.Common(1314, 5, 1, 1);
			long num7 = 0L;
			IItemDropRule itemDropRule31;
			IItemDropRule itemDropRule30 = itemDropRule31.OnSuccess(itemDropRule29, num7 != 0L);
			IItemDropRule itemDropRule32 = ItemDropRule.Common(1325, 5, 1, 1);
			long num8 = 0L;
			IItemDropRule itemDropRule34;
			IItemDropRule itemDropRule33 = itemDropRule34.OnSuccess(itemDropRule32, num8 != 0L);
			IItemDropRule itemDropRule35 = ItemDropRule.Common(683, 30, 1, 1);
			long num9 = 0L;
			IItemDropRule itemDropRule37;
			IItemDropRule itemDropRule36 = itemDropRule37.OnSuccess(itemDropRule35, num9 != 0L);
			IItemDropRule itemDropRule38 = ItemDropRule.Common(112, 30, 1, 1);
			long num10 = 0L;
			IItemDropRule itemDropRule40;
			IItemDropRule itemDropRule39 = itemDropRule40.OnSuccess(itemDropRule38, num10 != 0L);
			IItemDropRule itemDropRule41 = ItemDropRule.Common(4764, 40, 1, 1);
			IItemDropRule itemDropRule42 = this.RegisterToNPC(634, itemDropRule41);
			IItemDropRule itemDropRule43 = ItemDropRule.Common(951, 150, 1, 1);
			IItemDropRule itemDropRule44 = this.RegisterToNPC(185, itemDropRule43);
			IItemDropRule itemDropRule45 = ItemDropRule.Common(5070, 1, 1, 2);
			IItemDropRule itemDropRule46 = ItemDropRule.Common(1320, 20, 1, 1);
			IItemDropRule itemDropRule47 = this.RegisterToNPC(44, itemDropRule46);
			IItemDropRule itemDropRule48 = ItemDropRule.Common(88, 20, 1, 1);
			IItemDropRule itemDropRule49 = this.RegisterToNPC(44, itemDropRule48);
			IItemDropRule itemDropRule50 = ItemDropRule.Common(1322, 150, 1, 1);
			IItemDropRule itemDropRule51 = this.RegisterToNPC(60, itemDropRule50);
			IItemDropRule itemDropRule52 = ItemDropRule.Common(1322, 50, 1, 1);
			IItemDropRule itemDropRule53 = this.RegisterToNPC(151, itemDropRule52);
			IItemDropRule itemDropRule54 = ItemDropRule.Common(1323, 20, 1, 1);
			IItemDropRule itemDropRule55 = this.RegisterToNPC(24, itemDropRule54);
			IItemDropRule itemDropRule56 = ItemDropRule.Common(1324, 10, 1, 1);
			IItemDropRule itemDropRule57 = this.RegisterToNPC(109, itemDropRule56);
			IItemDropRule itemDropRule58 = ItemDropRule.Common(4271, 10, 1, 1);
			IItemDropRule itemDropRule59 = this.RegisterToNPC(109, itemDropRule58);
			IItemDropRule itemDropRule60 = ItemDropRule.Common(1308, 40, 1, 1);
			IItemDropRule itemDropRule61 = ItemDropRule.Common(2607, 2, 1, 3);
			IItemDropRule itemDropRule62 = ItemDropRule.Common(1306, 100, 1, 1);
			IItemDropRule itemDropRule63 = ItemDropRule.Common(23, 1, 1, 20);
			IItemDropRule itemDropRule64 = this.RegisterToNPC(244, itemDropRule63);
			IItemDropRule itemDropRule65 = ItemDropRule.Common(662, 1, 30, 60);
			IItemDropRule itemDropRule66 = this.RegisterToNPC(244, itemDropRule65);
			IItemDropRule itemDropRule67 = ItemDropRule.Common(1244, 15, 1, 1);
			IItemDropRule itemDropRule68 = this.RegisterToNPC(250, itemDropRule67);
			IItemDropRule itemDropRule69 = ItemDropRule.Common(754, 1, 1, 1);
			IItemDropRule itemDropRule70 = this.RegisterToNPC(172, itemDropRule69);
			IItemDropRule itemDropRule71 = ItemDropRule.Common(755, 1, 1, 1);
			IItemDropRule itemDropRule72 = this.RegisterToNPC(172, itemDropRule71);
			IItemDropRule itemDropRule73 = ItemDropRule.Common(682, 200, 1, 1);
			IItemDropRule itemDropRule74 = this.RegisterToNPC(110, itemDropRule73);
			IItemDropRule itemDropRule75 = ItemDropRule.Common(1321, 40, 1, 1);
			IItemDropRule itemDropRule76 = this.RegisterToNPC(110, itemDropRule75);
			IItemDropRule itemDropRule77 = ItemDropRule.Common(4428, 100, 1, 1);
			IItemDropRule itemDropRule78 = ItemDropRule.Common(1253, 50, 1, 1);
			IItemDropRule itemDropRule79 = this.RegisterToNPC(154, itemDropRule78);
			IItemDropRule itemDropRule80 = ItemDropRule.Common(726, 50, 1, 1);
			IItemDropRule itemDropRule81 = ItemDropRule.Common(2161, 1, 1, 1);
			IItemDropRule itemDropRule82 = this.RegisterToNPC(243, itemDropRule81);
			IItemDropRule itemDropRule83 = ItemDropRule.NormalvsExpert(5130, 30, 25);
			IItemDropRule itemDropRule84 = this.RegisterToNPC(155, itemDropRule83);
			IItemDropRule itemDropRule85 = ItemDropRule.Common(3269, 25, 1, 1);
			IItemDropRule itemDropRule86 = this.RegisterToNPC(480, itemDropRule85);
			IItemDropRule itemDropRule87 = ItemDropRule.NormalvsExpert(3781, 40, 20);
			IItemDropRule itemDropRule88 = this.RegisterToNPC(480, itemDropRule87);
			IItemDropRule itemDropRule89 = ItemDropRule.Common(1172, 1000, 1, 1);
			IItemDropRule itemDropRule90 = ItemDropRule.Common(1293, 50, 1, 1);
			IItemDropRule itemDropRule91 = ItemDropRule.Common(2766, 7, 1, 2);
			IItemDropRule itemDropRule92 = ItemDropRule.Common(870, 75, 1, 1);
			IItemDropRule itemDropRule93 = ItemDropRule.Common(871, 75, 1, 1);
			IItemDropRule itemDropRule94 = ItemDropRule.Common(872, 75, 1, 1);
			IItemDropRule itemDropRule96;
			IItemDropRule itemDropRule95 = this.RegisterToNPC(473, itemDropRule96);
			IItemDropRule itemDropRule98;
			IItemDropRule itemDropRule97 = this.RegisterToNPC(474, itemDropRule98);
			IItemDropRule itemDropRule100;
			IItemDropRule itemDropRule99 = this.RegisterToNPC(475, itemDropRule100);
			IItemDropRule itemDropRule101 = ItemDropRule.Common(52, 3, 1, 1);
			IItemDropRule itemDropRule102 = this.RegisterToNPC(476, itemDropRule101);
			IItemDropRule itemDropRule103 = ItemDropRule.Common(1724, 3, 1, 1);
			IItemDropRule itemDropRule104 = this.RegisterToNPC(476, itemDropRule103);
			IItemDropRule itemDropRule105 = ItemDropRule.Common(2353, 3, 5, 10);
			IItemDropRule itemDropRule106 = this.RegisterToNPC(476, itemDropRule105);
			IItemDropRule itemDropRule108;
			IItemDropRule itemDropRule107 = this.RegisterToNPC(476, itemDropRule108);
			IItemDropRule itemDropRule109 = ItemDropRule.Common(678, 3, 3, 5);
			IItemDropRule itemDropRule110 = this.RegisterToNPC(476, itemDropRule109);
			IItemDropRule itemDropRule111 = ItemDropRule.Common(1336, 3, 1, 1);
			IItemDropRule itemDropRule112 = this.RegisterToNPC(476, itemDropRule111);
			IItemDropRule itemDropRule113 = ItemDropRule.Common(2676, 3, 2, 4);
			IItemDropRule itemDropRule114 = this.RegisterToNPC(476, itemDropRule113);
			IItemDropRule itemDropRule115 = ItemDropRule.Common(2272, 3, 1, 1);
			IItemDropRule itemDropRule116 = this.RegisterToNPC(476, itemDropRule115);
			IItemDropRule itemDropRule117 = ItemDropRule.Common(5395, 3, 1, 1);
			IItemDropRule itemDropRule118 = this.RegisterToNPC(476, itemDropRule117);
			IItemDropRule itemDropRule119 = ItemDropRule.Common(4986, 3, 69, 69);
			IItemDropRule itemDropRule120 = this.RegisterToNPC(476, itemDropRule119);
			IItemDropRule itemDropRule121 = ItemDropRule.Common(499, 1, 5, 10);
			IItemDropRule itemDropRule122 = ItemDropRule.Common(500, 1, 5, 15);
			IItemDropRule itemDropRule123 = ItemDropRule.Common(575, 1, 5, 10);
			IItemDropRule itemDropRule124 = ItemDropRule.Common(575, 1, 10, 20);
			IItemDropRule itemDropRule125 = ItemDropRule.Common(1115, 1, 1, 1);
			IItemDropRule itemDropRule126 = this.RegisterToNPC(217, itemDropRule125);
			IItemDropRule itemDropRule127 = ItemDropRule.Common(1116, 1, 1, 1);
			IItemDropRule itemDropRule128 = this.RegisterToNPC(218, itemDropRule127);
			IItemDropRule itemDropRule129 = ItemDropRule.Common(1117, 1, 1, 1);
			IItemDropRule itemDropRule130 = this.RegisterToNPC(219, itemDropRule129);
			IItemDropRule itemDropRule131 = ItemDropRule.Common(1118, 1, 1, 1);
			IItemDropRule itemDropRule132 = this.RegisterToNPC(220, itemDropRule131);
			IItemDropRule itemDropRule133 = ItemDropRule.Common(1119, 1, 1, 1);
			IItemDropRule itemDropRule134 = this.RegisterToNPC(221, itemDropRule133);
			IItemDropRule itemDropRule135 = ItemDropRule.Common(879, 50, 1, 1);
			IItemDropRule itemDropRule136 = this.RegisterToNPC(167, itemDropRule135);
			IItemDropRule itemDropRule137 = ItemDropRule.Common(313, 2, 1, 2);
			IItemDropRule itemDropRule138 = this.RegisterToNPC(628, itemDropRule137);
			IItemDropRule itemDropRule139 = ItemDropRule.Common(593, 1, 5, 10);
			IItemDropRule itemDropRule140 = ItemDropRule.Common(527, 10, 1, 1);
			IItemDropRule itemDropRule141 = ItemDropRule.Common(528, 10, 1, 1);
			IItemDropRule itemDropRule142 = this.RegisterToNPC(80, itemDropRule141);
			IItemDropRule itemDropRule143 = ItemDropRule.Common(3794, 10, 1, 3);
			IItemDropRule itemDropRule144 = this.RegisterToNPC(524, itemDropRule143);
			IItemDropRule itemDropRule145 = ItemDropRule.Common(3794, 10, 1, 1);
			IItemDropRule itemDropRule146 = this.RegisterToNPC(525, itemDropRule145);
			IItemDropRule itemDropRule147 = ItemDropRule.Common(522, 3, 1, 3);
			IItemDropRule itemDropRule148 = this.RegisterToNPC(525, itemDropRule147);
			IItemDropRule itemDropRule149 = ItemDropRule.Common(527, 15, 1, 1);
			IItemDropRule itemDropRule150 = this.RegisterToNPC(525, itemDropRule149);
			IItemDropRule itemDropRule151 = ItemDropRule.Common(3794, 10, 1, 1);
			IItemDropRule itemDropRule152 = this.RegisterToNPC(526, itemDropRule151);
			IItemDropRule itemDropRule153 = ItemDropRule.Common(1332, 3, 1, 3);
			IItemDropRule itemDropRule154 = this.RegisterToNPC(526, itemDropRule153);
			IItemDropRule itemDropRule155 = ItemDropRule.Common(527, 15, 1, 1);
			IItemDropRule itemDropRule156 = this.RegisterToNPC(526, itemDropRule155);
			IItemDropRule itemDropRule157 = ItemDropRule.Common(3794, 10, 1, 1);
			IItemDropRule itemDropRule158 = this.RegisterToNPC(527, itemDropRule157);
			IItemDropRule itemDropRule159 = ItemDropRule.Common(528, 15, 1, 1);
			IItemDropRule itemDropRule160 = this.RegisterToNPC(527, itemDropRule159);
			IItemDropRule itemDropRule161 = ItemDropRule.Common(3380, 2, 1, 2);
			IItemDropRule itemDropRule162 = this.RegisterToNPC(513, itemDropRule161);
			IItemDropRule itemDropRule163 = ItemDropRule.Common(3380, 1, 1, 3);
			IItemDropRule itemDropRule164 = this.RegisterToNPC(532, itemDropRule163);
			IItemDropRule itemDropRule165 = ItemDropRule.Common(3771, 50, 1, 1);
			IItemDropRule itemDropRule166 = this.RegisterToNPC(532, itemDropRule165);
			IItemDropRule itemDropRule167 = ItemDropRule.Common(2802, 25, 1, 1);
			IItemDropRule itemDropRule168 = this.RegisterToNPC(528, itemDropRule167);
			IItemDropRule itemDropRule170;
			IItemDropRule itemDropRule169 = this.RegisterToNPC(528, itemDropRule170);
			IItemDropRule itemDropRule171 = ItemDropRule.Common(2801, 25, 1, 1);
			IItemDropRule itemDropRule172 = this.RegisterToNPC(529, itemDropRule171);
			IItemDropRule itemDropRule174;
			IItemDropRule itemDropRule173 = this.RegisterToNPC(529, itemDropRule174);
			IItemDropRule itemDropRule175 = ItemDropRule.Common(18, 100, 1, 1);
			IItemDropRule itemDropRule176 = ItemDropRule.Common(393, 50, 1, 1);
			IItemDropRule itemDropRule177 = ItemDropRule.Common(393, 75, 1, 1);
			IItemDropRule itemDropRule178 = this.RegisterToNPC(58, itemDropRule177);
			IItemDropRule itemDropRule179 = ItemDropRule.Common(18, 80, 1, 1);
			IItemDropRule itemDropRule180 = ItemDropRule.Common(393, 80, 1, 1);
			long num11 = 0L;
			IItemDropRule itemDropRule182;
			IItemDropRule itemDropRule181 = itemDropRule182.OnFailedRoll(itemDropRule180, num11 != 0L);
			IItemDropRule itemDropRule183 = ItemDropRule.Common(3285, 25, 1, 1);
			long num12 = 0L;
			IItemDropRule itemDropRule184 = itemDropRule181.OnFailedRoll(itemDropRule183, num12 != 0L);
			IItemDropRule itemDropRule185 = ItemDropRule.Common(954, 100, 1, 1);
			IItemDropRule itemDropRule186 = ItemDropRule.Common(955, 200, 1, 1);
			long num13 = 0L;
			IItemDropRule itemDropRule188;
			IItemDropRule itemDropRule187 = itemDropRule188.OnFailedRoll(itemDropRule186, num13 != 0L);
			IItemDropRule itemDropRule189 = ItemDropRule.Common(1166, 200, 1, 1);
			long num14 = 0L;
			IItemDropRule itemDropRule190 = itemDropRule187.OnFailedRoll(itemDropRule189, num14 != 0L);
			IItemDropRule itemDropRule191 = ItemDropRule.Common(1274, 500, 1, 1);
			long num15 = 0L;
			IItemDropRule itemDropRule192 = itemDropRule190.OnFailedRoll(itemDropRule191, num15 != 0L);
			IItemDropRule itemDropRule194;
			IItemDropRule itemDropRule193 = this.RegisterToNPC(6, itemDropRule194);
			IItemDropRule itemDropRule195 = ItemDropRule.Common(959, 450, 1, 1);
			IItemDropRule itemDropRule196 = ItemDropRule.Common(1307, 300, 1, 1);
			IItemDropRule itemDropRule197 = ItemDropRule.Common(996, 200, 1, 1);
			IItemDropRule itemDropRule198 = ItemDropRule.Common(522, 1, 2, 5);
			IItemDropRule itemDropRule200;
			IItemDropRule itemDropRule199 = this.RegisterToNPC(98, itemDropRule200);
			IItemDropRule itemDropRule201 = ItemDropRule.Common(526, 1, 1, 1);
			IItemDropRule itemDropRule202 = this.RegisterToNPC(86, itemDropRule201);
			IItemDropRule itemDropRule203 = ItemDropRule.Common(856, 100, 1, 1);
			IItemDropRule itemDropRule204 = this.RegisterToNPC(86, itemDropRule203);
			IItemDropRule itemDropRule206;
			IItemDropRule itemDropRule205 = this.RegisterToNPC(86, itemDropRule206);
			IItemDropRule itemDropRule207 = ItemDropRule.Common(4057, 100, 1, 1);
			IItemDropRule itemDropRule208 = this.RegisterToNPC(224, itemDropRule207);
			IItemDropRule itemDropRule209 = ItemDropRule.Common(40, 1, 1, 9);
			IItemDropRule itemDropRule210 = ItemDropRule.Common(1243, 45, 1, 1);
			IItemDropRule itemDropRule211 = this.RegisterToNPC(225, itemDropRule210);
			IItemDropRule itemDropRule212 = ItemDropRule.Common(23, 1, 2, 6);
			long num16 = 0L;
			IItemDropRule itemDropRule213 = itemDropRule211.OnFailedRoll(itemDropRule212, num16 != 0L);
			IItemDropRule itemDropRule214 = ItemDropRule.Common(23, 1, 2, 3);
			IItemDropRule itemDropRule215 = this.RegisterToNPC(537, itemDropRule214);
			IItemDropRule itemDropRule216 = ItemDropRule.NormalvsExpert(1309, 8000, 5600);
			IItemDropRule itemDropRule217 = this.RegisterToNPC(537, itemDropRule216);
			IItemDropRule itemDropRule218 = ItemDropRule.Common(1906, 20, 1, 1);
			IItemDropRule itemDropRule219 = ItemDropRule.Common(3111, 1, 25, 50);
			IItemDropRule itemDropRule220 = this.RegisterToNPC(1, itemDropRule219);
			IItemDropRule itemDropRule221 = ItemDropRule.NormalvsExpert(1309, 100, 70);
			IItemDropRule itemDropRule222 = this.RegisterToNPC(100, itemDropRule221);
			IItemDropRule itemDropRule223 = ItemDropRule.Common(23, 1, 1, 2);
			IItemDropRule itemDropRule224 = ItemDropRule.Common(23, 1, 2, 5);
			IItemDropRule itemDropRule225 = ItemDropRule.NormalvsExpert(1309, 10000, 7000);
			IItemDropRule itemDropRule226 = ItemDropRule.NormalvsExpert(1309, 10000, 7000);
			IItemDropRule itemDropRule227 = ItemDropRule.Common(501, 1, 1, 3);
			IItemDropRule itemDropRule228 = this.RegisterToNPC(75, itemDropRule227);
			IItemDropRule itemDropRule229 = ItemDropRule.Common(23, 1, 2, 4);
			IItemDropRule itemDropRule230 = ItemDropRule.Common(23, 1, 5, 10);
			IItemDropRule itemDropRule231 = this.RegisterToNPC(122, itemDropRule230);
			IItemDropRule itemDropRule232 = ItemDropRule.Common(327, 1, 1, 1);
			IItemDropRule itemDropRule233 = this.RegisterToNPC(71, itemDropRule232);
			IItemDropRule itemDropRule234 = ItemDropRule.Common(236, 100, 1, 1);
			IItemDropRule itemDropRule235 = ItemDropRule.Common(38, 3, 1, 1);
			long num17 = 0L;
			IItemDropRule itemDropRule237;
			IItemDropRule itemDropRule236 = itemDropRule237.OnFailedRoll(itemDropRule235, num17 != 0L);
			IItemDropRule itemDropRule239;
			IItemDropRule itemDropRule238 = this.RegisterToNPC(133, itemDropRule239);
			IItemDropRule itemDropRule240 = ItemDropRule.Common(485, 60, 1, 1);
			IItemDropRule itemDropRule241 = this.RegisterToNPC(104, itemDropRule240);
			IItemDropRule itemDropRule242 = ItemDropRule.Common(263, 250, 1, 1);
			IItemDropRule itemDropRule243 = this.RegisterToNPC(58, itemDropRule242);
			IItemDropRule itemDropRule244 = ItemDropRule.Common(118, 30, 1, 1);
			long num18 = 0L;
			IItemDropRule itemDropRule245 = itemDropRule243.OnFailedRoll(itemDropRule244, num18 != 0L);
			IItemDropRule itemDropRule246 = ItemDropRule.Common(263, 250, 1, 1);
			IItemDropRule itemDropRule247 = this.RegisterToNPC(102, itemDropRule246);
			IItemDropRule itemDropRule248 = ItemDropRule.Common(216, 50, 1, 1);
			IItemDropRule itemDropRule249 = ItemDropRule.Common(1304, 250, 1, 1);
			IItemDropRule itemDropRule250 = ItemDropRule.Common(5332, 1500, 1, 1);
			IItemDropRule itemDropRule251 = ItemDropRule.NormalvsExpert(3212, 150, 75);
			IItemDropRule itemDropRule252 = ItemDropRule.NormalvsExpert(3213, 200, 100);
			IItemDropRule itemDropRule254;
			IItemDropRule itemDropRule253 = this.RegisterToNPC(223, itemDropRule254);
			IItemDropRule itemDropRule255 = ItemDropRule.Common(267, 1, 1, 1);
			IItemDropRule itemDropRule256 = this.RegisterToNPC(66, itemDropRule255);
			IItemDropRule itemDropRule257 = ItemDropRule.Common(272, 35, 1, 1);
			IItemDropRule itemDropRule258 = ItemDropRule.Common(251, 1, 1, 1);
			IItemDropRule itemDropRule259 = this.RegisterToNPC(52, itemDropRule258);
			IItemDropRule itemDropRule260 = ItemDropRule.Common(239, 1, 1, 1);
			IItemDropRule itemDropRule261 = this.RegisterToNPC(53, itemDropRule260);
			IItemDropRule itemDropRule262 = ItemDropRule.Common(3478, 1, 1, 1);
			IItemDropRule itemDropRule263 = this.RegisterToNPC(536, itemDropRule262);
			IItemDropRule itemDropRule264 = ItemDropRule.Common(3479, 1, 1, 1);
			IItemDropRule itemDropRule265 = this.RegisterToNPC(536, itemDropRule264);
			IItemDropRule itemDropRule266 = ItemDropRule.Common(323, 3, 1, 2);
			IItemDropRule itemDropRule268;
			IItemDropRule itemDropRule267 = this.RegisterToNPC(582, itemDropRule268);
			IItemDropRule itemDropRule269 = ItemDropRule.Common(3772, 50, 1, 1);
			IItemDropRule itemDropRule270 = ItemDropRule.Common(362, 1, 1, 2);
			IItemDropRule itemDropRule271 = this.RegisterToNPC(73, itemDropRule270);
			IItemDropRule itemDropRule272 = ItemDropRule.Common(3109, 30, 1, 1);
			IItemDropRule itemDropRule273 = ItemDropRule.Common(4400, 20, 1, 1);
			IItemDropRule itemDropRule274 = ItemDropRule.Common(68, 3, 1, 1);
			IItemDropRule itemDropRule275 = ItemDropRule.Common(1330, 3, 1, 1);
			IItemDropRule itemDropRule276 = ItemDropRule.Common(68, 3, 1, 2);
			IItemDropRule itemDropRule277 = ItemDropRule.Common(69, 1, 3, 8);
			IItemDropRule itemDropRule278 = ItemDropRule.Common(215, 50, 1, 1);
			IItemDropRule itemDropRule279 = ItemDropRule.WithRerolls(215, 1, 50, 1, 1);
			IItemDropRule itemDropRule280 = ItemDropRule.Common(243, 75, 1, 1);
			IItemDropRule itemDropRule281 = ItemDropRule.Common(3795, 40, 1, 1);
			IItemDropRule itemDropRule282 = this.RegisterToNPC(533, itemDropRule281);
			IItemDropRule itemDropRule283 = ItemDropRule.Common(3770, 30, 1, 1);
			long num19 = 0L;
			IItemDropRule itemDropRule284 = itemDropRule282.OnFailedRoll(itemDropRule283, num19 != 0L);
			IItemDropRule itemDropRule285 = ItemDropRule.Common(1303, 100, 1, 1);
			IItemDropRule itemDropRule286 = ItemDropRule.Common(282, 1, 1, 4);
			IItemDropRule itemDropRule287 = ItemDropRule.Common(282, 1, 1, 4);
			IItemDropRule itemDropRule288 = ItemDropRule.Common(282, 1, 1, 4);
			IItemDropRule itemDropRule290;
			IItemDropRule itemDropRule289 = this.RegisterToNPC(63, itemDropRule290);
			IItemDropRule itemDropRule292;
			IItemDropRule itemDropRule291 = this.RegisterToNPC(64, itemDropRule292);
			IItemDropRule itemDropRule293 = ItemDropRule.Common(3094, 2, 40, 80);
			IItemDropRule itemDropRule294 = this.RegisterToNPC(481, itemDropRule293);
			IItemDropRule itemDropRule296;
			IItemDropRule itemDropRule295 = this.RegisterToNPC(481, itemDropRule296);
			IItemDropRule itemDropRule297 = ItemDropRule.Common(4463, 20, 1, 1);
			IItemDropRule itemDropRule298 = this.RegisterToNPC(481, itemDropRule297);
			IItemDropRule itemDropRule299 = ItemDropRule.Common(118, 25, 1, 1);
			IItemDropRule itemDropRule300 = ItemDropRule.Common(118, 25, 1, 1);
			IItemDropRule itemDropRule301 = this.RegisterToNPC(44, itemDropRule300);
			long num20 = 0L;
			IItemDropRule itemDropRule303;
			IItemDropRule itemDropRule302 = itemDropRule301.OnFailedRoll(itemDropRule303, num20 != 0L);
			IItemDropRule itemDropRule304 = ItemDropRule.Common(166, 1, 1, 3);
			long num21 = 0L;
			IItemDropRule itemDropRule305 = itemDropRule302.OnFailedRoll(itemDropRule304, num21 != 0L);
			IItemDropRule itemDropRule306 = ItemDropRule.Common(238, 1, 1, 1);
			IItemDropRule itemDropRule307 = this.RegisterToNPC(45, itemDropRule306);
			IItemDropRule itemDropRule308 = ItemDropRule.Common(116, 50, 1, 1);
			IItemDropRule itemDropRule309 = this.RegisterToNPC(23, itemDropRule308);
			IItemDropRule itemDropRule310 = ItemDropRule.Common(244, 250, 1, 1);
			IItemDropRule itemDropRule311 = this.RegisterToNPC(24, itemDropRule310);
			IItemDropRule itemDropRule312 = ItemDropRule.Common(932, 250, 1, 1);
			IItemDropRule itemDropRule313 = ItemDropRule.Common(3095, 100, 1, 1);
			long num22 = 0L;
			IItemDropRule itemDropRule315;
			IItemDropRule itemDropRule314 = itemDropRule315.OnFailedRoll(itemDropRule313, num22 != 0L);
			IItemDropRule itemDropRule316 = ItemDropRule.Common(327, 65, 1, 1);
			long num23 = 0L;
			IItemDropRule itemDropRule317 = itemDropRule314.OnFailedRoll(itemDropRule316, num23 != 0L);
			long num24 = 0L;
			IItemDropRule itemDropRule319;
			IItemDropRule itemDropRule318 = itemDropRule317.OnFailedRoll(itemDropRule319, num24 != 0L);
			IItemDropRule itemDropRule320 = ItemDropRule.Common(160, 200, 1, 1);
			IItemDropRule itemDropRule321 = ItemDropRule.Common(161, 2, 1, 5);
			long num25 = 0L;
			IItemDropRule itemDropRule323;
			IItemDropRule itemDropRule322 = itemDropRule323.OnFailedRoll(itemDropRule321, num25 != 0L);
			IItemDropRule itemDropRule324 = ItemDropRule.Common(1265, 100, 1, 1);
			IItemDropRule itemDropRule326;
			IItemDropRule itemDropRule325 = this.RegisterToNPC(175, itemDropRule326);
			IItemDropRule itemDropRule327 = ItemDropRule.Common(209, 1, 1, 1);
			IItemDropRule itemDropRule328 = ItemDropRule.Common(209, 6, 1, 1);
			IItemDropRule itemDropRule329 = this.RegisterToNPC(176, itemDropRule328);
			IItemDropRule itemDropRule330 = ItemDropRule.NormalvsExpert(209, 2, 1);
			IItemDropRule itemDropRule331 = this.RegisterToNPC(204, itemDropRule330);
			IItemDropRule itemDropRule332 = ItemDropRule.NormalvsExpert(210, 2, 1);
			IItemDropRule itemDropRule333 = this.RegisterToNPC(43, itemDropRule332);
			IItemDropRule itemDropRule335;
			IItemDropRule itemDropRule334 = this.RegisterToNPC(43, itemDropRule335);
			IItemDropRule itemDropRule337;
			IItemDropRule itemDropRule336 = this.RegisterToNPC(39, itemDropRule337);
			IItemDropRule itemDropRule339;
			IItemDropRule itemDropRule338 = this.RegisterToNPC(65, itemDropRule339);
			IItemDropRule itemDropRule340 = ItemDropRule.Common(268, 20, 1, 1);
			IItemDropRule itemDropRule341 = this.RegisterToNPC(65, itemDropRule340);
			IItemDropRule itemDropRule342 = ItemDropRule.Common(319, 1, 1, 1);
			long num26 = 0L;
			IItemDropRule itemDropRule343 = itemDropRule342.OnFailedRoll(itemDropRule342, num26 != 0L);
			IItemDropRule itemDropRule344 = ItemDropRule.NotScalingWithLuck(320, 2, 1, 1);
			IItemDropRule itemDropRule345 = this.RegisterToNPC(48, itemDropRule344);
			IItemDropRule itemDropRule346 = ItemDropRule.Common(3783, 1, 1, 1);
			IItemDropRule itemDropRule347 = this.RegisterToNPC(541, itemDropRule346);
			IItemDropRule itemDropRule348 = ItemDropRule.Common(319, 8, 1, 1);
			IItemDropRule itemDropRule349 = ItemDropRule.Common(527, 25, 1, 1);
			IItemDropRule itemDropRule350 = this.RegisterToNPC(543, itemDropRule349);
			IItemDropRule itemDropRule351 = ItemDropRule.Common(527, 25, 1, 1);
			IItemDropRule itemDropRule352 = this.RegisterToNPC(544, itemDropRule351);
			IItemDropRule itemDropRule353 = ItemDropRule.Common(528, 25, 1, 1);
			IItemDropRule itemDropRule354 = this.RegisterToNPC(545, itemDropRule353);
			IItemDropRule itemDropRule356;
			IItemDropRule itemDropRule355 = this.RegisterToNPC(47, itemDropRule356);
			IItemDropRule itemDropRule358;
			IItemDropRule itemDropRule357 = this.RegisterToNPC(464, itemDropRule358);
			IItemDropRule itemDropRule359 = ItemDropRule.Common(1332, 1, 2, 5);
			IItemDropRule itemDropRule360 = this.RegisterToNPC(268, itemDropRule359);
			IItemDropRule itemDropRule361 = ItemDropRule.Common(3, 1, 10, 20);
			IItemDropRule itemDropRule362 = this.RegisterToNPC(631, itemDropRule361);
			IItemDropRule itemDropRule363 = ItemDropRule.Common(4761, 10, 1, 1);
			IItemDropRule itemDropRule364 = this.RegisterToNPC(631, itemDropRule363);
		}

		// Token: 0x06004586 RID: 17798 RVA: 0x00254DE8 File Offset: 0x00252FE8
		public ItemDropDatabase()
		{
		}

		// Token: 0x040081FB RID: 33275
		private List<IItemDropRule> _globalEntries;

		// Token: 0x040081FC RID: 33276
		private Dictionary<int, List<IItemDropRule>> _entriesByNpcNetId;

		// Token: 0x040081FD RID: 33277
		private Dictionary<int, List<int>> _npcNetIdsByType;

		// Token: 0x040081FE RID: 33278
		private int _masterModeDropRng = 4;

		// Token: 0x020008CD RID: 2253
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004587 RID: 17799 RVA: 0x00254E04 File Offset: 0x00253004
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06004588 RID: 17800 RVA: 0x00254E14 File Offset: 0x00253014
			public <>c()
			{
			}

			// Token: 0x06004589 RID: 17801 RVA: 0x000021DB File Offset: 0x000003DB
			internal bool <PrepareNPCNetIDsByTypeDictionary>b__3_0(KeyValuePair<int, NPC> x)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x040081FF RID: 33279
			public static readonly ItemDropDatabase.<>c <>9;

			// Token: 0x04008200 RID: 33280
			public static Func<KeyValuePair<int, NPC>, bool> <>9__3_0;
		}
	}
}
