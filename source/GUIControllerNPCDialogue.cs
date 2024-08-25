using System;
using Microsoft.Xna.Framework;

// Token: 0x0200009E RID: 158
public class GUIControllerNPCDialogue : GUIControllerItem
{
	// Token: 0x060003C8 RID: 968 RVA: 0x0000C7D8 File Offset: 0x0000A9D8
	public void Activate()
	{
	}

	// Token: 0x060003C9 RID: 969 RVA: 0x0000C7E8 File Offset: 0x0000A9E8
	public int GetNavigationOutDirs()
	{
	}

	// Token: 0x060003CA RID: 970 RVA: 0x0000C7F8 File Offset: 0x0000A9F8
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		/*
An exception occurred when decompiling this method (060003CA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerItem GUIControllerNPCDialogue::Navigate(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(GUIControllerNPCDialogue::_selected, ldloc:GUIControllerNPCDialogue(this)))
	stloc:int32(var_1_0D, ldfld:int32(GUIControllerNPCDialogue::_selected, ldloc:GUIControllerNPCDialogue(this)))
	stfld:int32(GUIControllerNPCDialogue::_selected, ldloc:GUIControllerNPCDialogue(this), ldloc:int32(var_1_0D))
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

	// Token: 0x060003CB RID: 971 RVA: 0x0000C81C File Offset: 0x0000AA1C
	public Rectangle GetSelectedItemRegion()
	{
		int selected = this._selected;
		this._selected = 43139072;
		if (this._selected != 0)
		{
		}
		Rectangle rectangle;
		return rectangle;
	}

	// Token: 0x060003CC RID: 972 RVA: 0x0000C844 File Offset: 0x0000AA44
	public GUIControllerNPCDialogue()
	{
	}

	// Token: 0x040003B2 RID: 946
	private int _selected;
}
