using System;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x0200087A RID: 2170
	public class DropLocalPerClientAndResetsNPCMoneyTo0 : CommonDrop
	{
		// Token: 0x060043F1 RID: 17393 RVA: 0x0024EDC8 File Offset: 0x0024CFC8
		public DropLocalPerClientAndResetsNPCMoneyTo0(int itemId, int chanceDenominator, int amountDroppedMinimum, int amountDroppedMaximum, IItemDropRuleCondition optionalCondition)
			: base(itemId, chanceDenominator, amountDroppedMinimum, amountDroppedMaximum, 1)
		{
			this.condition = optionalCondition;
		}

		// Token: 0x060043F2 RID: 17394 RVA: 0x0024EDEC File Offset: 0x0024CFEC
		public override bool CanDrop(DropAttemptInfo info)
		{
			if (this.condition != null)
			{
				NPC npc = info.npc;
				return;
			}
		}

		// Token: 0x060043F3 RID: 17395 RVA: 0x0024EE0C File Offset: 0x0024D00C
		public override ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			/*
An exception occurred when decompiling this method (060043F3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.ItemDropRules.ItemDropAttemptResult Terraria.GameContent.ItemDropRules.DropLocalPerClientAndResetsNPCMoneyTo0::TryDroppingItem(Terraria.GameContent.ItemDropRules.DropAttemptInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:UnifiedRandom(var_0_06, ldfld:UnifiedRandom(DropAttemptInfo::rng, ldloc:DropAttemptInfo[exp:valuetype Terraria.GameContent.ItemDropRules.DropAttemptInfo&](info)))
	stloc:int32(var_1_0D, ldfld:int32(CommonDrop::chanceDenominator, ldloc:DropLocalPerClientAndResetsNPCMoneyTo0[exp:CommonDrop](this)))
	stloc:int64(var_2_0F, ldc.i4:int64(0))
	stloc:int32(var_3_17, call:int32(UnifiedRandom::Next, ldloc:UnifiedRandom(var_0_06), ldloc:int32(var_1_0D)))
	stloc:int32(var_4_1E, ldfld:int32(CommonDrop::chanceNumerator, ldloc:DropLocalPerClientAndResetsNPCMoneyTo0[exp:CommonDrop](this)))
	stloc:int32(var_5_26, ldfld:int32(CommonDrop::amountDroppedMinimum, ldloc:DropLocalPerClientAndResetsNPCMoneyTo0[exp:CommonDrop](this)))
	stloc:int32(var_6_2E, ldfld:int32(CommonDrop::chanceNumerator, ldloc:DropLocalPerClientAndResetsNPCMoneyTo0[exp:CommonDrop](this)))
	stloc:UnifiedRandom(var_7_36, ldfld:UnifiedRandom(DropAttemptInfo::rng, ldloc:DropAttemptInfo[exp:valuetype Terraria.GameContent.ItemDropRules.DropAttemptInfo&](info)))
	stloc:int32(var_8_3E, ldfld:int32(CommonDrop::itemId, ldloc:DropLocalPerClientAndResetsNPCMoneyTo0[exp:CommonDrop](this)))
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

		// Token: 0x040081C2 RID: 33218
		public IItemDropRuleCondition condition;
	}
}
