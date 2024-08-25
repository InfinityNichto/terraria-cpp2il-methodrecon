using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

// Token: 0x020000CE RID: 206
public class GUIControllerItemDuplication : GUIPageContentController
{
	// Token: 0x06000518 RID: 1304 RVA: 0x0000FDC0 File Offset: 0x0000DFC0
	public GUIControllerItemDuplication()
	{
	}

	// Token: 0x06000519 RID: 1305 RVA: 0x0000FDD4 File Offset: 0x0000DFD4
	public virtual bool IsInMenu()
	{
	}

	// Token: 0x0600051A RID: 1306 RVA: 0x0000FDE4 File Offset: 0x0000DFE4
	public override void Activate()
	{
	}

	// Token: 0x0600051B RID: 1307 RVA: 0x0000FDFC File Offset: 0x0000DFFC
	public virtual void RefreshScrollOffset()
	{
	}

	// Token: 0x0600051C RID: 1308 RVA: 0x0000FE44 File Offset: 0x0000E044
	protected virtual void UpdateScroll()
	{
	}

	// Token: 0x1700008F RID: 143
	// (get) Token: 0x0600051D RID: 1309 RVA: 0x000021DB File Offset: 0x000003DB
	public int MinRow
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x17000090 RID: 144
	// (get) Token: 0x0600051E RID: 1310 RVA: 0x000021DB File Offset: 0x000003DB
	public int MinColumns
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x0600051F RID: 1311 RVA: 0x0000FE9C File Offset: 0x0000E09C
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		int num = this.itemColumn;
		int num2 = this.itemColumn;
		int num3 = this.itemColumn;
		this.itemColumn = num3;
		int num4 = this.itemRow;
		int num5 = this.itemRow;
		this.itemRow = num5;
		int num6 = this.itemRow;
		GUIControllerItem guicontrollerItem;
		return guicontrollerItem;
	}

	// Token: 0x06000520 RID: 1312 RVA: 0x0000FEE8 File Offset: 0x0000E0E8
	protected virtual void ClampPosition()
	{
	}

	// Token: 0x06000521 RID: 1313 RVA: 0x0000FF04 File Offset: 0x0000E104
	public override Rectangle GetSelectedItemRegion()
	{
		/*
An exception occurred when decompiling this method (06000521)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle GUIControllerItemDuplication::GetSelectedItemRegion()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:!0(var_0_05, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
	stloc:!0(var_3_0D, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
	stloc:!0(var_4_13, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
	stloc:!0(var_5_1A, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
	stloc:int32(var_7_22, ldfld:int32(GUIControllerItemDuplication::itemColumn, ldloc:GUIControllerItemDuplication(this)))
	stloc:!0(var_8_29, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
	stloc:int32(var_9_31, ldfld:int32(GUIControllerItemDuplication::itemRow, ldloc:GUIControllerItemDuplication(this)))
	stloc:!0(var_10_38, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
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

	// Token: 0x04000475 RID: 1141
	public int itemRow;

	// Token: 0x04000476 RID: 1142
	public int itemColumn;

	// Token: 0x04000477 RID: 1143
	public int scrollOffset;
}
