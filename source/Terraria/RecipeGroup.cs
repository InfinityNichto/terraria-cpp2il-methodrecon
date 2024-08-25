using System;
using System.Collections.Generic;

namespace Terraria
{
	// Token: 0x02000454 RID: 1108
	public class RecipeGroup
	{
		// Token: 0x06002985 RID: 10629 RVA: 0x0019BE6C File Offset: 0x0019A06C
		public RecipeGroup(Func<string> getName, params int[] validItems)
		{
			this.GetText = getName;
			this.IconicItemId = 1;
		}

		// Token: 0x06002986 RID: 10630 RVA: 0x0019BE90 File Offset: 0x0019A090
		public static int RegisterGroup(string name, RecipeGroup rec)
		{
			if (!true)
			{
			}
			return 43143168;
		}

		// Token: 0x06002987 RID: 10631 RVA: 0x0019BEA8 File Offset: 0x0019A0A8
		public int CountUsableItems(Dictionary<int, int> itemStacksAvailable)
		{
			HashSet<int> validItems = this.ValidItems;
			throw new OutOfMemoryException();
		}

		// Token: 0x06002988 RID: 10632 RVA: 0x0019BECC File Offset: 0x0019A0CC
		public int GetGroupFakeItemId()
		{
			/*
An exception occurred when decompiling this method (06002988)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.RecipeGroup::GetGroupFakeItemId()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(RecipeGroup::RegisteredId, ldloc:RecipeGroup(this)))
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

		// Token: 0x06002989 RID: 10633 RVA: 0x0019BEE0 File Offset: 0x0019A0E0
		// Note: this type is marked as 'beforefieldinit'.
		static RecipeGroup()
		{
		}

		// Token: 0x040036B4 RID: 14004
		public Func<string> GetText;

		// Token: 0x040036B5 RID: 14005
		public HashSet<int> ValidItems;

		// Token: 0x040036B6 RID: 14006
		public int IconicItemId;

		// Token: 0x040036B7 RID: 14007
		public int RegisteredId;

		// Token: 0x040036B8 RID: 14008
		public static Dictionary<int, RecipeGroup> recipeGroups;

		// Token: 0x040036B9 RID: 14009
		public static Dictionary<string, int> recipeGroupIDs;

		// Token: 0x040036BA RID: 14010
		public static int nextRecipeGroupIndex;
	}
}
