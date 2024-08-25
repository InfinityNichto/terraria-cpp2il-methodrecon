using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000878 RID: 2168
	public class CommonDrop : IItemDropRule
	{
		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x060043E9 RID: 17385 RVA: 0x0024EC7C File Offset: 0x0024CE7C
		// (set) Token: 0x060043EA RID: 17386 RVA: 0x0024EC90 File Offset: 0x0024CE90
		public List<IItemDropRuleChainAttempt> ChainedRules
		{
			[CompilerGenerated]
			get
			{
				return this.<ChainedRules>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<ChainedRules>k__BackingField = value;
			}
		}

		// Token: 0x060043EB RID: 17387 RVA: 0x0024ECA4 File Offset: 0x0024CEA4
		public CommonDrop(int itemId, int chanceDenominator, int amountDroppedMinimum = 1, int amountDroppedMaximum = 1, int chanceNumerator = 1)
		{
			this.itemId = itemId;
			this.amountDroppedMinimum = chanceDenominator;
			this.amountDroppedMinimum = amountDroppedMinimum;
			this.chanceNumerator = amountDroppedMaximum;
			this.chanceNumerator = chanceNumerator;
		}

		// Token: 0x060043EC RID: 17388 RVA: 0x0024ECDC File Offset: 0x0024CEDC
		public virtual bool CanDrop(DropAttemptInfo info)
		{
			return true;
		}

		// Token: 0x060043ED RID: 17389 RVA: 0x0024ECEC File Offset: 0x0024CEEC
		public virtual ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			/*
An exception occurred when decompiling this method (060043ED)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.ItemDropRules.ItemDropAttemptResult Terraria.GameContent.ItemDropRules.CommonDrop::TryDroppingItem(Terraria.GameContent.ItemDropRules.DropAttemptInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Player(var_0_06, ldfld:Player(DropAttemptInfo::player, ldloc:DropAttemptInfo[exp:valuetype Terraria.GameContent.ItemDropRules.DropAttemptInfo&](info)))
	stloc:int32(var_1_0D, ldfld:int32(CommonDrop::chanceDenominator, ldloc:CommonDrop(this)))
	stloc:int64(var_2_0F, ldc.i4:int64(0))
	stloc:int32(var_3_17, call:int32(Player::RollLuck, ldloc:Player(var_0_06), ldloc:int32(var_1_0D)))
	stloc:int32(var_4_1E, ldfld:int32(CommonDrop::chanceNumerator, ldloc:CommonDrop(this)))
	stloc:int32(var_5_26, ldfld:int32(CommonDrop::amountDroppedMinimum, ldloc:CommonDrop(this)))
	stloc:int32(var_6_2E, ldfld:int32(CommonDrop::chanceNumerator, ldloc:CommonDrop(this)))
	stloc:UnifiedRandom(var_7_36, ldfld:UnifiedRandom(DropAttemptInfo::rng, ldloc:DropAttemptInfo[exp:valuetype Terraria.GameContent.ItemDropRules.DropAttemptInfo&](info)))
	stloc:int32(var_8_3E, ldfld:int32(CommonDrop::itemId, ldloc:CommonDrop(this)))
	stloc:int32(var_9_4A, call:int32(UnifiedRandom::Next, ldloc:UnifiedRandom(var_7_36), ldloc:int32(var_5_26), ldloc:int64[exp:int32](var_2_0F)))
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

		// Token: 0x060043EE RID: 17390 RVA: 0x000021DB File Offset: 0x000003DB
		public virtual void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x040081BC RID: 33212
		public int itemId;

		// Token: 0x040081BD RID: 33213
		public int chanceDenominator;

		// Token: 0x040081BE RID: 33214
		public int amountDroppedMinimum;

		// Token: 0x040081BF RID: 33215
		public int amountDroppedMaximum;

		// Token: 0x040081C0 RID: 33216
		public int chanceNumerator;

		// Token: 0x040081C1 RID: 33217
		[CompilerGenerated]
		private List<IItemDropRuleChainAttempt> <ChainedRules>k__BackingField;
	}
}
