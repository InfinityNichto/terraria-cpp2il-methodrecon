using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000887 RID: 2183
	public class OneFromOptionsNotScaledWithLuckDropRule : IItemDropRule
	{
		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x06004432 RID: 17458 RVA: 0x0024F608 File Offset: 0x0024D808
		// (set) Token: 0x06004433 RID: 17459 RVA: 0x0024F61C File Offset: 0x0024D81C
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

		// Token: 0x06004434 RID: 17460 RVA: 0x0024F630 File Offset: 0x0024D830
		public OneFromOptionsNotScaledWithLuckDropRule(int chanceDenominator, int chanceNumerator, params int[] options)
		{
			this.dropIds = options;
			this.chanceDenominator = chanceDenominator;
			this.ChainedRules = chanceNumerator;
		}

		// Token: 0x06004435 RID: 17461 RVA: 0x0024F658 File Offset: 0x0024D858
		public bool CanDrop(DropAttemptInfo info)
		{
			return true;
		}

		// Token: 0x06004436 RID: 17462 RVA: 0x0024F668 File Offset: 0x0024D868
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			/*
An exception occurred when decompiling this method (06004436)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.ItemDropRules.ItemDropAttemptResult Terraria.GameContent.ItemDropRules.OneFromOptionsNotScaledWithLuckDropRule::TryDroppingItem(Terraria.GameContent.ItemDropRules.DropAttemptInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:UnifiedRandom(var_0_06, ldfld:UnifiedRandom(DropAttemptInfo::rng, ldloc:DropAttemptInfo[exp:valuetype Terraria.GameContent.ItemDropRules.DropAttemptInfo&](info)))
	stloc:int32(var_1_0D, ldfld:int32(OneFromOptionsNotScaledWithLuckDropRule::chanceDenominator, ldloc:OneFromOptionsNotScaledWithLuckDropRule(this)))
	stloc:int32(var_2_15, call:int32(UnifiedRandom::Next, ldloc:UnifiedRandom(var_0_06), ldloc:int32(var_1_0D)))
	stloc:int32(var_3_1C, ldfld:int32(OneFromOptionsNotScaledWithLuckDropRule::chanceNumerator, ldloc:OneFromOptionsNotScaledWithLuckDropRule(this)))
	stloc:int32[](var_4_23, ldfld:int32[](OneFromOptionsNotScaledWithLuckDropRule::dropIds, ldloc:OneFromOptionsNotScaledWithLuckDropRule(this)))
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

		// Token: 0x06004437 RID: 17463 RVA: 0x000021DB File Offset: 0x000003DB
		public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x040081E1 RID: 33249
		public int[] dropIds;

		// Token: 0x040081E2 RID: 33250
		public int chanceDenominator;

		// Token: 0x040081E3 RID: 33251
		public int chanceNumerator;

		// Token: 0x040081E4 RID: 33252
		[CompilerGenerated]
		private List<IItemDropRuleChainAttempt> <ChainedRules>k__BackingField;
	}
}
