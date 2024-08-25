using System;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000952 RID: 2386
	public class GoldCritterUICollectionInfoProvider : IBestiaryUICollectionInfoProvider
	{
		// Token: 0x060047C3 RID: 18371 RVA: 0x0025F40C File Offset: 0x0025D60C
		public GoldCritterUICollectionInfoProvider(int[] normalCritterPersistentId, string goldCritterPersistentId)
		{
			int num = 1;
			base..ctor();
			if (num == 0)
			{
			}
			string[] normalCritterPersistentId2 = this._normalCritterPersistentId;
		}

		// Token: 0x060047C4 RID: 18372 RVA: 0x0025F440 File Offset: 0x0025D640
		public BestiaryUICollectionInfo GetEntryUICollectionInfo()
		{
			string goldCritterPersistentId = this._goldCritterPersistentId;
			BestiaryEntryUnlockState unlockStateForCritter = this.GetUnlockStateForCritter(goldCritterPersistentId);
			string[] normalCritterPersistentId = this._normalCritterPersistentId;
			if (this != null)
			{
				return;
			}
		}

		// Token: 0x060047C5 RID: 18373 RVA: 0x0025F46C File Offset: 0x0025D66C
		private bool TryFindingOneGoldCritterThatIsAlreadyUnlocked()
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x060047C6 RID: 18374 RVA: 0x0025F484 File Offset: 0x0025D684
		private BestiaryEntryUnlockState GetUnlockStateForCritter(string persistentId)
		{
			/*
An exception occurred when decompiling this method (060047C6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.Bestiary.BestiaryEntryUnlockState Terraria.GameContent.Bestiary.GoldCritterUICollectionInfoProvider::GetUnlockStateForCritter(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x04008388 RID: 33672
		private string[] _normalCritterPersistentId;

		// Token: 0x04008389 RID: 33673
		private string _goldCritterPersistentId;
	}
}
