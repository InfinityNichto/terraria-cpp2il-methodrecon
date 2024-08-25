using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000889 RID: 2185
	public class FromOptionsWithoutRepeatsDropRule : IItemDropRule
	{
		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x0600443E RID: 17470 RVA: 0x0024F758 File Offset: 0x0024D958
		// (set) Token: 0x0600443F RID: 17471 RVA: 0x0024F76C File Offset: 0x0024D96C
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

		// Token: 0x06004440 RID: 17472 RVA: 0x0024F780 File Offset: 0x0024D980
		public FromOptionsWithoutRepeatsDropRule(int dropCount, params int[] options)
		{
			this.dropCount = dropCount;
			this.dropIds = options;
		}

		// Token: 0x06004441 RID: 17473 RVA: 0x0024F7A4 File Offset: 0x0024D9A4
		public bool CanDrop(DropAttemptInfo info)
		{
			return true;
		}

		// Token: 0x06004442 RID: 17474 RVA: 0x0024F7B4 File Offset: 0x0024D9B4
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			/*
An exception occurred when decompiling this method (06004442)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.ItemDropRules.ItemDropAttemptResult Terraria.GameContent.ItemDropRules.FromOptionsWithoutRepeatsDropRule::TryDroppingItem(Terraria.GameContent.ItemDropRules.DropAttemptInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.List`1<int32>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.List`1<int32>(FromOptionsWithoutRepeatsDropRule::_temporaryAvailableItems, ldloc:FromOptionsWithoutRepeatsDropRule(this)))
	stloc:int32(var_1_0D, ldfld:int32(List`1::_version, ldloc:class [mscorlib]System.Collections.Generic.List`1<int32>[exp:List`1](var_0_06)))
	stfld:object(List`1::_syncRoot, ldloc:class [mscorlib]System.Collections.Generic.List`1<int32>[exp:List`1](var_0_06), ldloc:int32[exp:object](var_1_0D))
	stloc:int32[](var_2_1B, ldfld:int32[](FromOptionsWithoutRepeatsDropRule::dropIds, ldloc:FromOptionsWithoutRepeatsDropRule(this)))
	stloc:int32(var_3_22, ldfld:int32(FromOptionsWithoutRepeatsDropRule::dropCount, ldloc:FromOptionsWithoutRepeatsDropRule(this)))
	stloc:int32(var_5_31, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<int32>[exp:List`1](FromOptionsWithoutRepeatsDropRule::_temporaryAvailableItems, ldloc:FromOptionsWithoutRepeatsDropRule(this))))
	stloc:int32(var_6_40, call:int32(UnifiedRandom::Next, ldfld:UnifiedRandom(DropAttemptInfo::rng, ldloc:DropAttemptInfo[exp:valuetype Terraria.GameContent.ItemDropRules.DropAttemptInfo&](info)), ldloc:int32(var_5_31)))
	stloc:class [mscorlib]System.Collections.Generic.List`1<int32>(var_7_48, ldfld:class [mscorlib]System.Collections.Generic.List`1<int32>(FromOptionsWithoutRepeatsDropRule::_temporaryAvailableItems, ldloc:FromOptionsWithoutRepeatsDropRule(this)))
	stloc:class [mscorlib]System.Collections.Generic.List`1<int32>(var_8_50, ldfld:class [mscorlib]System.Collections.Generic.List`1<int32>(FromOptionsWithoutRepeatsDropRule::_temporaryAvailableItems, ldloc:FromOptionsWithoutRepeatsDropRule(this)))
	stloc:int32(var_9_58, ldfld:int32(FromOptionsWithoutRepeatsDropRule::dropCount, ldloc:FromOptionsWithoutRepeatsDropRule(this)))
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

		// Token: 0x06004443 RID: 17475 RVA: 0x000021DB File Offset: 0x000003DB
		public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x040081E9 RID: 33257
		public int[] dropIds;

		// Token: 0x040081EA RID: 33258
		public int dropCount;

		// Token: 0x040081EB RID: 33259
		[CompilerGenerated]
		private List<IItemDropRuleChainAttempt> <ChainedRules>k__BackingField;

		// Token: 0x040081EC RID: 33260
		private List<int> _temporaryAvailableItems;
	}
}
