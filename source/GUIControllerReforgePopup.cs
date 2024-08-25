using System;
using Microsoft.Xna.Framework;

// Token: 0x020000D8 RID: 216
public class GUIControllerReforgePopup : GUIControllerItem
{
	// Token: 0x06000598 RID: 1432 RVA: 0x00010D98 File Offset: 0x0000EF98
	public int GetNavigationOutDirs()
	{
	}

	// Token: 0x06000599 RID: 1433 RVA: 0x00010DA8 File Offset: 0x0000EFA8
	public void Activate()
	{
	}

	// Token: 0x0600059A RID: 1434 RVA: 0x00010DB8 File Offset: 0x0000EFB8
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		/*
An exception occurred when decompiling this method (0600059A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerItem GUIControllerReforgePopup::Navigate(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int64(var_0_01, ldc.i4:int64(0))
	stfld:Controls(GUIControllerReforgePopup::selectedControl, ldloc:GUIControllerReforgePopup(this), ldloc:int64[exp:Controls](var_0_01))
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

	// Token: 0x0600059B RID: 1435 RVA: 0x00010DD0 File Offset: 0x0000EFD0
	public Rectangle GetSelectedItemRegion()
	{
		Rectangle rectangle;
		ControlAnchor.SetGridItemRegion(rectangle);
		GUIControllerReforgePopup.Controls controls = this.selectedControl;
		Rectangle rectangle2;
		return rectangle2;
	}

	// Token: 0x0600059C RID: 1436 RVA: 0x00010DEC File Offset: 0x0000EFEC
	public GUIControllerReforgePopup()
	{
	}

	// Token: 0x040004AE RID: 1198
	public GUIControllerReforgePopup.Controls selectedControl;

	// Token: 0x020000D9 RID: 217
	public enum Controls
	{
		// Token: 0x040004B0 RID: 1200
		Reforge,
		// Token: 0x040004B1 RID: 1201
		Back
	}
}
