using System;
using Microsoft.Xna.Framework;

// Token: 0x02000091 RID: 145
public class GUIControllerInterfaceEdit : GUIControllerItem
{
	// Token: 0x06000385 RID: 901 RVA: 0x0000BA88 File Offset: 0x00009C88
	public void Activate()
	{
	}

	// Token: 0x06000386 RID: 902 RVA: 0x0000BA98 File Offset: 0x00009C98
	public int GetNavigationOutDirs()
	{
	}

	// Token: 0x06000387 RID: 903 RVA: 0x0000BAA8 File Offset: 0x00009CA8
	public void UpdatePageScroll()
	{
		int editControl = this.EditControl;
	}

	// Token: 0x06000388 RID: 904 RVA: 0x0000BAC0 File Offset: 0x00009CC0
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		/*
An exception occurred when decompiling this method (06000388)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerItem GUIControllerInterfaceEdit::Navigate(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_015C:
	stloc:int32(var_36_15D, ldc.i4:int32(4))
	stfld:int32(GUIControllerInterfaceEdit::EditControl, ldloc:GUIControllerInterfaceEdit(this), ldloc:int32(var_36_15D))
	call:void(GUIControllerInterfaceEdit::UpdatePageScroll, ldloc:GUIControllerInterfaceEdit(this))
	stloc:int32(var_37_173, ldfld:int32(GUIControllerInterfaceEdit::EditControl, ldloc:GUIControllerInterfaceEdit(this)))
	stloc:int32(var_38_17B, ldfld:int32(GUIControllerInterfaceEdit::EditControl, ldloc:GUIControllerInterfaceEdit(this)))
	stloc:int32(var_39_17E, ldc.i4:int32(6))
	stfld:int32(GUIControllerInterfaceEdit::EditControl, ldloc:GUIControllerInterfaceEdit(this), ldloc:int32(var_39_17E))
	stloc:int32(var_40_18E, ldfld:int32(GUIControllerInterfaceEdit::AdjustRow, ldloc:GUIControllerInterfaceEdit(this)))
	stloc:int32(var_41_196, ldfld:int32(GUIControllerInterfaceEdit::AdjustRow, ldloc:GUIControllerInterfaceEdit(this)))
	stfld:int32(GUIControllerInterfaceEdit::AdjustRow, ldloc:GUIControllerInterfaceEdit(this), ldloc:int32(var_41_196))
	stloc:int32(var_42_1A6, ldfld:int32(GUIControllerInterfaceEdit::AdjustColumn, ldloc:GUIControllerInterfaceEdit(this)))
	stloc:int32(var_43_1AE, ldfld:int32(GUIControllerInterfaceEdit::AdjustColumn, ldloc:GUIControllerInterfaceEdit(this)))
	stfld:int32(GUIControllerInterfaceEdit::AdjustColumn, ldloc:GUIControllerInterfaceEdit(this), ldloc:int32(var_43_1AE))
	brtrue(IL_0000, logicnot:bool(ldc.i4:bool(1)))
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

	// Token: 0x06000389 RID: 905 RVA: 0x0000BC8C File Offset: 0x00009E8C
	public Rectangle GetSelectedItemRegion()
	{
		do
		{
			int pageColumn = this.PageColumn;
			int pageRow = this.PageRow;
		}
		while (32768 == 0);
		if (this.EditProfile != 0)
		{
			if (this.EditTemplate == 0)
			{
			}
			long num = 0L;
			DrPlatform.DrPlatformType currentPlatform = DrPlatform.CurrentPlatform;
			int editTemplate = this.EditTemplate;
			if (num != 0L || num != 0L)
			{
				DrPlatform.DrPlatformType currentPlatform2 = DrPlatform.CurrentPlatform;
				DrPlatform.DrPlatformType currentPlatform3 = DrPlatform.CurrentPlatform;
			}
		}
		Rectangle rectangle;
		return rectangle;
	}

	// Token: 0x0600038A RID: 906 RVA: 0x0000BCFC File Offset: 0x00009EFC
	public GUIControllerInterfaceEdit()
	{
	}

	// Token: 0x04000366 RID: 870
	public int EditControl;

	// Token: 0x04000367 RID: 871
	private int EditProfile;

	// Token: 0x04000368 RID: 872
	private int EditTemplate;

	// Token: 0x04000369 RID: 873
	public int AdjustColumn;

	// Token: 0x0400036A RID: 874
	public int AdjustRow;

	// Token: 0x0400036B RID: 875
	public int PageColumn;

	// Token: 0x0400036C RID: 876
	public int PageRow;
}
