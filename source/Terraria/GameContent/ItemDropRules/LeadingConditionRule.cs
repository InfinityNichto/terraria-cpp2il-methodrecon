using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000884 RID: 2180
	public class LeadingConditionRule : IItemDropRule
	{
		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x06004425 RID: 17445 RVA: 0x0024F478 File Offset: 0x0024D678
		// (set) Token: 0x06004426 RID: 17446 RVA: 0x0024F48C File Offset: 0x0024D68C
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

		// Token: 0x06004427 RID: 17447 RVA: 0x0024F4A0 File Offset: 0x0024D6A0
		public LeadingConditionRule(IItemDropRuleCondition condition)
		{
			this.condition = condition;
		}

		// Token: 0x06004428 RID: 17448 RVA: 0x0024F4BC File Offset: 0x0024D6BC
		public bool CanDrop(DropAttemptInfo info)
		{
			/*
An exception occurred when decompiling this method (06004428)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.ItemDropRules.LeadingConditionRule::CanDrop(Terraria.GameContent.ItemDropRules.DropAttemptInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:NPC(var_0_06, ldfld:NPC(DropAttemptInfo::npc, ldloc:DropAttemptInfo[exp:valuetype Terraria.GameContent.ItemDropRules.DropAttemptInfo&](info)))
	stloc:IItemDropRuleCondition(var_1_0D, ldfld:IItemDropRuleCondition(LeadingConditionRule::condition, ldloc:LeadingConditionRule(this)))
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

		// Token: 0x06004429 RID: 17449 RVA: 0x0024F4D8 File Offset: 0x0024D6D8
		public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
			IItemDropRuleCondition itemDropRuleCondition = this.condition;
			List<IItemDropRuleChainAttempt> list = this.<ChainedRules>k__BackingField;
		}

		// Token: 0x0600442A RID: 17450 RVA: 0x0024F4F4 File Offset: 0x0024D6F4
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			return 2;
		}

		// Token: 0x040081D4 RID: 33236
		public IItemDropRuleCondition condition;

		// Token: 0x040081D5 RID: 33237
		[CompilerGenerated]
		private List<IItemDropRuleChainAttempt> <ChainedRules>k__BackingField;
	}
}
