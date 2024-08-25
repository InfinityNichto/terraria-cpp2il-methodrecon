using System;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000879 RID: 2169
	public class CommonDropNotScalingWithLuck : CommonDrop
	{
		// Token: 0x060043EF RID: 17391 RVA: 0x0024ED4C File Offset: 0x0024CF4C
		public CommonDropNotScalingWithLuck(int itemId, int chanceDenominator, int amountDroppedMinimum, int amountDroppedMaximum)
			: base(itemId, chanceDenominator, amountDroppedMinimum, amountDroppedMaximum, 1)
		{
		}

		// Token: 0x060043F0 RID: 17392 RVA: 0x0024ED68 File Offset: 0x0024CF68
		public override ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			/*
An exception occurred when decompiling this method (060043F0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.ItemDropRules.ItemDropAttemptResult Terraria.GameContent.ItemDropRules.CommonDropNotScalingWithLuck::TryDroppingItem(Terraria.GameContent.ItemDropRules.DropAttemptInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:UnifiedRandom(var_0_06, ldfld:UnifiedRandom(DropAttemptInfo::rng, ldloc:DropAttemptInfo[exp:valuetype Terraria.GameContent.ItemDropRules.DropAttemptInfo&](info)))
	stloc:int32(var_1_0D, ldfld:int32(CommonDrop::chanceDenominator, ldloc:CommonDropNotScalingWithLuck[exp:CommonDrop](this)))
	stloc:int64(var_2_0F, ldc.i4:int64(0))
	stloc:int32(var_3_17, call:int32(UnifiedRandom::Next, ldloc:UnifiedRandom(var_0_06), ldloc:int32(var_1_0D)))
	stloc:int32(var_4_1E, ldfld:int32(CommonDrop::chanceNumerator, ldloc:CommonDropNotScalingWithLuck[exp:CommonDrop](this)))
	stloc:int32(var_5_26, ldfld:int32(CommonDrop::amountDroppedMinimum, ldloc:CommonDropNotScalingWithLuck[exp:CommonDrop](this)))
	stloc:int32(var_6_2E, ldfld:int32(CommonDrop::chanceNumerator, ldloc:CommonDropNotScalingWithLuck[exp:CommonDrop](this)))
	stloc:UnifiedRandom(var_7_36, ldfld:UnifiedRandom(DropAttemptInfo::rng, ldloc:DropAttemptInfo[exp:valuetype Terraria.GameContent.ItemDropRules.DropAttemptInfo&](info)))
	stloc:int32(var_8_3E, ldfld:int32(CommonDrop::itemId, ldloc:CommonDropNotScalingWithLuck[exp:CommonDrop](this)))
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
	}
}
