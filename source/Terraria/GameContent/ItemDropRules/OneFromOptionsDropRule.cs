using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000888 RID: 2184
	public class OneFromOptionsDropRule : IItemDropRule
	{
		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x06004438 RID: 17464 RVA: 0x0024F6B0 File Offset: 0x0024D8B0
		// (set) Token: 0x06004439 RID: 17465 RVA: 0x0024F6C4 File Offset: 0x0024D8C4
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

		// Token: 0x0600443A RID: 17466 RVA: 0x0024F6D8 File Offset: 0x0024D8D8
		public OneFromOptionsDropRule(int chanceDenominator, int chanceNumerator, params int[] options)
		{
			this.chanceDenominator = chanceDenominator;
			this.ChainedRules = chanceNumerator;
			this.dropIds = options;
		}

		// Token: 0x0600443B RID: 17467 RVA: 0x0024F700 File Offset: 0x0024D900
		public bool CanDrop(DropAttemptInfo info)
		{
			return true;
		}

		// Token: 0x0600443C RID: 17468 RVA: 0x0024F710 File Offset: 0x0024D910
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			/*
An exception occurred when decompiling this method (0600443C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.ItemDropRules.ItemDropAttemptResult Terraria.GameContent.ItemDropRules.OneFromOptionsDropRule::TryDroppingItem(Terraria.GameContent.ItemDropRules.DropAttemptInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Player(var_0_06, ldfld:Player(DropAttemptInfo::player, ldloc:DropAttemptInfo[exp:valuetype Terraria.GameContent.ItemDropRules.DropAttemptInfo&](info)))
	stloc:int32(var_1_0D, ldfld:int32(OneFromOptionsDropRule::chanceDenominator, ldloc:OneFromOptionsDropRule(this)))
	stloc:int32(var_2_15, call:int32(Player::RollLuck, ldloc:Player(var_0_06), ldloc:int32(var_1_0D)))
	stloc:int32(var_3_1C, ldfld:int32(OneFromOptionsDropRule::chanceNumerator, ldloc:OneFromOptionsDropRule(this)))
	stloc:int32[](var_4_23, ldfld:int32[](OneFromOptionsDropRule::dropIds, ldloc:OneFromOptionsDropRule(this)))
	stloc:int32(var_5_31, call:int32(UnifiedRandom::Next, ldfld:UnifiedRandom(DropAttemptInfo::rng, ldloc:DropAttemptInfo[exp:valuetype Terraria.GameContent.ItemDropRules.DropAttemptInfo&](info)), ldloc:int32(var_1_0D)))
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

		// Token: 0x0600443D RID: 17469 RVA: 0x000021DB File Offset: 0x000003DB
		public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x040081E5 RID: 33253
		public int[] dropIds;

		// Token: 0x040081E6 RID: 33254
		public int chanceDenominator;

		// Token: 0x040081E7 RID: 33255
		public int chanceNumerator;

		// Token: 0x040081E8 RID: 33256
		[CompilerGenerated]
		private List<IItemDropRuleChainAttempt> <ChainedRules>k__BackingField;
	}
}
