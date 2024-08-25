using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x0200088A RID: 2186
	public class OneFromRulesRule : IItemDropRule, INestedItemDropRule
	{
		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x06004444 RID: 17476 RVA: 0x0024F820 File Offset: 0x0024DA20
		// (set) Token: 0x06004445 RID: 17477 RVA: 0x0024F834 File Offset: 0x0024DA34
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

		// Token: 0x06004446 RID: 17478 RVA: 0x0024F848 File Offset: 0x0024DA48
		public OneFromRulesRule(int chanceDenominator, params IItemDropRule[] options)
		{
			this.chanceDenominator = chanceDenominator;
			this.options = options;
		}

		// Token: 0x06004447 RID: 17479 RVA: 0x0024F86C File Offset: 0x0024DA6C
		public bool CanDrop(DropAttemptInfo info)
		{
			return true;
		}

		// Token: 0x06004448 RID: 17480 RVA: 0x0024F87C File Offset: 0x0024DA7C
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			return 3;
		}

		// Token: 0x06004449 RID: 17481 RVA: 0x0024F88C File Offset: 0x0024DA8C
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info, ItemDropRuleResolveAction resolveAction)
		{
			/*
An exception occurred when decompiling this method (06004449)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.ItemDropRules.ItemDropAttemptResult Terraria.GameContent.ItemDropRules.OneFromRulesRule::TryDroppingItem(Terraria.GameContent.ItemDropRules.DropAttemptInfo,Terraria.GameContent.ItemDropRules.ItemDropRuleResolveAction)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0019:
	stloc:class Terraria.GameContent.ItemDropRules.IItemDropRule[](var_3_1F, ldfld:class Terraria.GameContent.ItemDropRules.IItemDropRule[](OneFromRulesRule::options, ldloc:OneFromRulesRule(this)))
	stloc:int32(var_4_2C, call:int32(UnifiedRandom::Next, ldfld:UnifiedRandom(DropAttemptInfo::rng, ldloc:DropAttemptInfo[exp:valuetype Terraria.GameContent.ItemDropRules.DropAttemptInfo&](info)), ldloc:int32(var_1_0D)))
	stloc:class Terraria.GameContent.ItemDropRules.IItemDropRule[](var_5_34, ldfld:class Terraria.GameContent.ItemDropRules.IItemDropRule[](OneFromRulesRule::options, ldloc:OneFromRulesRule(this)))
	stloc:NPC(var_6_3C, ldfld:NPC(DropAttemptInfo::npc, ldloc:DropAttemptInfo[exp:valuetype Terraria.GameContent.ItemDropRules.DropAttemptInfo&](info)))
	stloc:native int(var_7_44, ldfld:native int(Delegate::invoke_impl, ldloc:ItemDropRuleResolveAction[exp:Delegate](resolveAction)))
	stloc:native int(var_8_4C, ldfld:native int(Delegate::method_code, ldloc:ItemDropRuleResolveAction[exp:Delegate](resolveAction)))
	stloc:native int(var_9_54, ldfld:native int(Delegate::method, ldloc:ItemDropRuleResolveAction[exp:Delegate](resolveAction)))
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

		// Token: 0x0600444A RID: 17482 RVA: 0x0024F8F4 File Offset: 0x0024DAF4
		public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
			int num = this.chanceDenominator;
		}

		// Token: 0x040081ED RID: 33261
		public IItemDropRule[] options;

		// Token: 0x040081EE RID: 33262
		public int chanceDenominator;

		// Token: 0x040081EF RID: 33263
		[CompilerGenerated]
		private List<IItemDropRuleChainAttempt> <ChainedRules>k__BackingField;
	}
}
