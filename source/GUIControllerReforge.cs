using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

// Token: 0x020000D6 RID: 214
public class GUIControllerReforge : GUIPageContentController
{
	// Token: 0x06000581 RID: 1409 RVA: 0x00010B0C File Offset: 0x0000ED0C
	public GUIControllerReforge()
	{
	}

	// Token: 0x06000582 RID: 1410 RVA: 0x00010B20 File Offset: 0x0000ED20
	public override void Activate()
	{
	}

	// Token: 0x170000A6 RID: 166
	// (get) Token: 0x06000583 RID: 1411 RVA: 0x000021DB File Offset: 0x000003DB
	public int MinRow
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x170000A7 RID: 167
	// (get) Token: 0x06000584 RID: 1412 RVA: 0x000021DB File Offset: 0x000003DB
	public int MinColumns
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x06000585 RID: 1413 RVA: 0x00010B30 File Offset: 0x0000ED30
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

	// Token: 0x06000586 RID: 1414 RVA: 0x00010B7C File Offset: 0x0000ED7C
	private void ClampPosition()
	{
		int num = this.itemColumn;
		int minColumns = this.MinColumns;
		int num2;
		this.itemColumn = num2;
	}

	// Token: 0x06000587 RID: 1415 RVA: 0x00010BB8 File Offset: 0x0000EDB8
	public override Rectangle GetSelectedItemRegion()
	{
		/*
An exception occurred when decompiling this method (06000587)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle GUIControllerReforge::GetSelectedItemRegion()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0009:
	stloc:!0(var_0_0E, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
	stloc:!0(var_3_16, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
	stloc:ControlId(var_5_1E, ldfld:ControlId(ItemGrid_Layout::FirstAnchorControl, ldloc:DraggableItemGrid_Layout[exp:ItemGrid_Layout](var_4)))
	stloc:!0(var_6_25, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
	stloc:AnchorType(var_8_2E, ldfld:AnchorType(ItemGrid_Layout::FirstItemAnchor, ldloc:DraggableItemGrid_Layout[exp:ItemGrid_Layout](var_7)))
	stloc:!0(var_9_35, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
	stloc:float32(var_11_43, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](ItemGrid_Layout::FirstItemLocation, ldloc:DraggableItemGrid_Layout[exp:ItemGrid_Layout](var_10))))
	stloc:float32(var_12_51, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](ItemGrid_Layout::FirstItemLocation, ldloc:DraggableItemGrid_Layout[exp:ItemGrid_Layout](var_10))))
	stloc:int32(var_14_59, ldfld:int32(GUIControllerReforge::itemColumn, ldloc:GUIControllerReforge(this)))
	stloc:!0(var_15_60, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
	stloc:float32(var_17_6E, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](ItemGrid_Layout::ExtraElementSpacing, ldloc:DraggableItemGrid_Layout[exp:ItemGrid_Layout](var_16))))
	stloc:int32(var_18_76, ldfld:int32(GUIControllerReforge::itemRow, ldloc:GUIControllerReforge(this)))
	stloc:!0(var_19_7D, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
	stloc:float32(var_21_8B, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](ItemGrid_Layout::ExtraElementSpacing, ldloc:DraggableItemGrid_Layout[exp:ItemGrid_Layout](var_20))))
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

	// Token: 0x06000588 RID: 1416 RVA: 0x00010C54 File Offset: 0x0000EE54
	public virtual bool IsInMenu()
	{
	}

	// Token: 0x040004AB RID: 1195
	public int itemRow;

	// Token: 0x040004AC RID: 1196
	public int itemColumn;
}
