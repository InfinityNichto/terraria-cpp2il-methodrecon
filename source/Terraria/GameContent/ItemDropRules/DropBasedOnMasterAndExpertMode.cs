using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000880 RID: 2176
	public class DropBasedOnMasterAndExpertMode : IItemDropRule, INestedItemDropRule
	{
		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x0600440E RID: 17422 RVA: 0x0024F1B8 File Offset: 0x0024D3B8
		// (set) Token: 0x0600440F RID: 17423 RVA: 0x0024F1CC File Offset: 0x0024D3CC
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

		// Token: 0x06004410 RID: 17424 RVA: 0x0024F1E0 File Offset: 0x0024D3E0
		public DropBasedOnMasterAndExpertMode(IItemDropRule ruleForDefault, IItemDropRule ruleForExpertMode, IItemDropRule ruleForMasterMode)
		{
			this.ruleForDefault = ruleForDefault;
			this.ruleForExpertmode = ruleForExpertMode;
			this.ruleForMasterMode = ruleForMasterMode;
		}

		// Token: 0x06004411 RID: 17425 RVA: 0x0024F208 File Offset: 0x0024D408
		public bool CanDrop(DropAttemptInfo info)
		{
			/*
An exception occurred when decompiling this method (06004411)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.ItemDropRules.DropBasedOnMasterAndExpertMode::CanDrop(Terraria.GameContent.ItemDropRules.DropAttemptInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_06, ldfld:bool(DropAttemptInfo::IsMasterMode, ldloc:DropAttemptInfo[exp:valuetype Terraria.GameContent.ItemDropRules.DropAttemptInfo&](info)))
	stloc:bool(var_1_0D, ldfld:bool(DropAttemptInfo::IsExpertMode, ldloc:DropAttemptInfo[exp:valuetype Terraria.GameContent.ItemDropRules.DropAttemptInfo&](info)))
	stloc:NPC(var_2_14, ldfld:NPC(DropAttemptInfo::npc, ldloc:DropAttemptInfo[exp:valuetype Terraria.GameContent.ItemDropRules.DropAttemptInfo&](info)))
	stloc:IItemDropRule(var_3_1B, ldfld:IItemDropRule(DropBasedOnMasterAndExpertMode::ruleForDefault, ldloc:DropBasedOnMasterAndExpertMode(this)))
	stloc:IItemDropRule(var_4_22, ldfld:IItemDropRule(DropBasedOnMasterAndExpertMode::ruleForMasterMode, ldloc:DropBasedOnMasterAndExpertMode(this)))
	stloc:IItemDropRule(var_5_2A, ldfld:IItemDropRule(DropBasedOnMasterAndExpertMode::ruleForExpertmode, ldloc:DropBasedOnMasterAndExpertMode(this)))
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

		// Token: 0x06004412 RID: 17426 RVA: 0x0024F240 File Offset: 0x0024D440
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			return 3;
		}

		// Token: 0x06004413 RID: 17427 RVA: 0x0024F250 File Offset: 0x0024D450
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info, ItemDropRuleResolveAction resolveAction)
		{
			/*
An exception occurred when decompiling this method (06004413)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.ItemDropRules.ItemDropAttemptResult Terraria.GameContent.ItemDropRules.DropBasedOnMasterAndExpertMode::TryDroppingItem(Terraria.GameContent.ItemDropRules.DropAttemptInfo,Terraria.GameContent.ItemDropRules.ItemDropRuleResolveAction)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_06, ldfld:bool(DropAttemptInfo::IsMasterMode, ldloc:DropAttemptInfo[exp:valuetype Terraria.GameContent.ItemDropRules.DropAttemptInfo&](info)))
	stloc:bool(var_1_0D, ldfld:bool(DropAttemptInfo::IsExpertMode, ldloc:DropAttemptInfo[exp:valuetype Terraria.GameContent.ItemDropRules.DropAttemptInfo&](info)))
	stloc:NPC(var_2_14, ldfld:NPC(DropAttemptInfo::npc, ldloc:DropAttemptInfo[exp:valuetype Terraria.GameContent.ItemDropRules.DropAttemptInfo&](info)))
	stloc:IItemDropRule(var_3_1B, ldfld:IItemDropRule(DropBasedOnMasterAndExpertMode::ruleForDefault, ldloc:DropBasedOnMasterAndExpertMode(this)))
	stloc:IItemDropRule(var_4_22, ldfld:IItemDropRule(DropBasedOnMasterAndExpertMode::ruleForMasterMode, ldloc:DropBasedOnMasterAndExpertMode(this)))
	stloc:IItemDropRule(var_5_2A, ldfld:IItemDropRule(DropBasedOnMasterAndExpertMode::ruleForExpertmode, ldloc:DropBasedOnMasterAndExpertMode(this)))
	stloc:native int(var_6_32, ldfld:native int(Delegate::invoke_impl, ldloc:ItemDropRuleResolveAction[exp:Delegate](resolveAction)))
	stloc:native int(var_7_3A, ldfld:native int(Delegate::method_code, ldloc:ItemDropRuleResolveAction[exp:Delegate](resolveAction)))
	stloc:native int(var_8_42, ldfld:native int(Delegate::method, ldloc:ItemDropRuleResolveAction[exp:Delegate](resolveAction)))
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

		// Token: 0x06004414 RID: 17428 RVA: 0x0024F2A0 File Offset: 0x0024D4A0
		public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
			IItemDropRule itemDropRule = this.ruleForMasterMode;
		}

		// Token: 0x040081CC RID: 33228
		public IItemDropRule ruleForDefault;

		// Token: 0x040081CD RID: 33229
		public IItemDropRule ruleForExpertmode;

		// Token: 0x040081CE RID: 33230
		public IItemDropRule ruleForMasterMode;

		// Token: 0x040081CF RID: 33231
		[CompilerGenerated]
		private List<IItemDropRuleChainAttempt> <ChainedRules>k__BackingField;
	}
}
