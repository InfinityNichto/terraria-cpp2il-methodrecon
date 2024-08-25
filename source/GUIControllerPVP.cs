using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

// Token: 0x020000D4 RID: 212
public class GUIControllerPVP : GUIPageContentController
{
	// Token: 0x06000563 RID: 1379 RVA: 0x000106D0 File Offset: 0x0000E8D0
	public GUIControllerPVP()
	{
	}

	// Token: 0x06000564 RID: 1380 RVA: 0x000106E4 File Offset: 0x0000E8E4
	public override void Activate()
	{
	}

	// Token: 0x06000565 RID: 1381 RVA: 0x000106F4 File Offset: 0x0000E8F4
	public virtual bool IsInMenu()
	{
	}

	// Token: 0x170000A2 RID: 162
	// (get) Token: 0x06000566 RID: 1382 RVA: 0x000021DB File Offset: 0x000003DB
	public int MaxRow
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x170000A3 RID: 163
	// (get) Token: 0x06000567 RID: 1383 RVA: 0x000021DB File Offset: 0x000003DB
	public int MaxColumns
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x06000568 RID: 1384 RVA: 0x00010704 File Offset: 0x0000E904
	protected virtual void ClampPosition()
	{
		int num = this.itemColumn;
	}

	// Token: 0x06000569 RID: 1385 RVA: 0x00010728 File Offset: 0x0000E928
	private int SideToRow(int side)
	{
	}

	// Token: 0x0600056A RID: 1386 RVA: 0x00010738 File Offset: 0x0000E938
	private int RowToSide(int row)
	{
	}

	// Token: 0x0600056B RID: 1387 RVA: 0x00010748 File Offset: 0x0000E948
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		int num = this.sideRow;
		int num2 = this.itemColumn;
		int num3 = this.sideRow;
		this.sideRow = num3;
		int num4 = this.itemColumn;
		int num5 = this.itemColumn;
		this.itemColumn = num5;
		int num6 = this.itemRow;
		this.itemRow = num6;
		int num7 = this.itemColumn;
		int num8 = this.itemRow;
		int num9 = this.itemRow;
		int num10 = this.itemRow;
		GUIControllerItem guicontrollerItem;
		return guicontrollerItem;
	}

	// Token: 0x0600056C RID: 1388 RVA: 0x000107C0 File Offset: 0x0000E9C0
	public override Rectangle GetSelectedItemRegion()
	{
		/*
An exception occurred when decompiling this method (0600056C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle GUIControllerPVP::GetSelectedItemRegion()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00F7:
	stloc:!0(var_41_FC, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
	stloc:float32(var_43_10A, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](ItemGrid_Layout::ExtraElementSpacing, ldloc:DraggableItemGrid_Layout[exp:ItemGrid_Layout](var_42))))
	stloc:!0(var_44_111, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
	stloc:float32(var_46_11F, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](ItemGrid_Layout::ExtraElementSpacing, ldloc:DraggableItemGrid_Layout[exp:ItemGrid_Layout](var_45))))
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

	// Token: 0x040004A4 RID: 1188
	public bool insideSideIcons;

	// Token: 0x040004A5 RID: 1189
	public int itemRow;

	// Token: 0x040004A6 RID: 1190
	public int itemColumn;

	// Token: 0x040004A7 RID: 1191
	public int sideRow;
}
