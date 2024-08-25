using System;
using System.Runtime.CompilerServices;

namespace Terraria.GameContent
{
	// Token: 0x020007EB RID: 2027
	public static class ShimmerTransforms
	{
		// Token: 0x06004123 RID: 16675 RVA: 0x00244BF0 File Offset: 0x00242DF0
		public static int GetDecraftingRecipeIndex(int type)
		{
			/*
An exception occurred when decompiling this method (06004123)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.GameContent.ShimmerTransforms::GetDecraftingRecipeIndex(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x06004124 RID: 16676 RVA: 0x00244C0C File Offset: 0x00242E0C
		public static bool IsItemTransformLocked(int type)
		{
			int num = 1;
			int decraftingRecipeIndex = ShimmerTransforms.GetDecraftingRecipeIndex(-1073741824);
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06004125 RID: 16677 RVA: 0x00244C2C File Offset: 0x00242E2C
		public static void UpdateRecipeSets()
		{
		}

		// Token: 0x020007EC RID: 2028
		public static class RecipeSets
		{
			// Token: 0x04007EDA RID: 32474
			public static bool[] PostSkeletron;

			// Token: 0x04007EDB RID: 32475
			public static bool[] PostGolem;
		}

		// Token: 0x020007ED RID: 2029
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004126 RID: 16678 RVA: 0x00244C3C File Offset: 0x00242E3C
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06004127 RID: 16679 RVA: 0x00244C4C File Offset: 0x00242E4C
			public <>c()
			{
			}

			// Token: 0x06004128 RID: 16680 RVA: 0x00244C60 File Offset: 0x00242E60
			internal bool <UpdateRecipeSets>b__3_0(Recipe r)
			{
				return r.ContainsIngredient(154);
			}

			// Token: 0x06004129 RID: 16681 RVA: 0x00244C78 File Offset: 0x00242E78
			internal bool <UpdateRecipeSets>b__3_1(Recipe r)
			{
				return r.ContainsIngredient(1101);
			}

			// Token: 0x04007EDC RID: 32476
			public static readonly ShimmerTransforms.<>c <>9;

			// Token: 0x04007EDD RID: 32477
			public static Func<Recipe, bool> <>9__3_0;

			// Token: 0x04007EDE RID: 32478
			public static Func<Recipe, bool> <>9__3_1;
		}
	}
}
