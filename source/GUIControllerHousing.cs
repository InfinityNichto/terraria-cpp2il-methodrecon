using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

// Token: 0x020000CA RID: 202
public class GUIControllerHousing : GUIPageContentController
{
	// Token: 0x060004EA RID: 1258 RVA: 0x0000F610 File Offset: 0x0000D810
	public GUIControllerHousing()
	{
	}

	// Token: 0x060004EB RID: 1259 RVA: 0x0000F62C File Offset: 0x0000D82C
	public virtual bool IsInMenu()
	{
	}

	// Token: 0x060004EC RID: 1260 RVA: 0x0000F63C File Offset: 0x0000D83C
	public override void Activate()
	{
	}

	// Token: 0x060004ED RID: 1261 RVA: 0x0000F64C File Offset: 0x0000D84C
	public virtual void NextItem()
	{
	}

	// Token: 0x060004EE RID: 1262 RVA: 0x0000F65C File Offset: 0x0000D85C
	public virtual void PreviousItem()
	{
	}

	// Token: 0x17000089 RID: 137
	// (get) Token: 0x060004EF RID: 1263 RVA: 0x000021DB File Offset: 0x000003DB
	public int MinRow
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x1700008A RID: 138
	// (get) Token: 0x060004F0 RID: 1264 RVA: 0x000021DB File Offset: 0x000003DB
	public int MaxColumns
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x060004F1 RID: 1265 RVA: 0x0000F66C File Offset: 0x0000D86C
	protected virtual void ClampPosition()
	{
		int num = this.itemColumn;
	}

	// Token: 0x060004F2 RID: 1266 RVA: 0x0000F698 File Offset: 0x0000D898
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

	// Token: 0x060004F3 RID: 1267 RVA: 0x0000F6E4 File Offset: 0x0000D8E4
	public override Rectangle GetSelectedItemRegion()
	{
		/*
An exception occurred when decompiling this method (060004F3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle GUIControllerHousing::GetSelectedItemRegion()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:!0(var_0_05, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
	stloc:!0(var_3_0D, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
	stloc:ControlId(var_5_15, ldfld:ControlId(ItemGrid_Layout::FirstAnchorControl, ldloc:DraggableItemGrid_Layout[exp:ItemGrid_Layout](var_4)))
	stloc:!0(var_6_1C, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
	stloc:AnchorType(var_8_25, ldfld:AnchorType(ItemGrid_Layout::FirstItemAnchor, ldloc:DraggableItemGrid_Layout[exp:ItemGrid_Layout](var_7)))
	stloc:!0(var_9_2C, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
	stloc:float32(var_11_3A, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](ItemGrid_Layout::FirstItemLocation, ldloc:DraggableItemGrid_Layout[exp:ItemGrid_Layout](var_10))))
	stloc:float32(var_12_48, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](ItemGrid_Layout::FirstItemLocation, ldloc:DraggableItemGrid_Layout[exp:ItemGrid_Layout](var_10))))
	stloc:int32(var_14_50, ldfld:int32(GUIControllerHousing::itemColumn, ldloc:GUIControllerHousing(this)))
	stloc:!0(var_15_57, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
	stloc:float32(var_17_65, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](ItemGrid_Layout::ExtraElementSpacing, ldloc:DraggableItemGrid_Layout[exp:ItemGrid_Layout](var_16))))
	stloc:int32(var_18_6D, ldfld:int32(GUIControllerHousing::itemRow, ldloc:GUIControllerHousing(this)))
	stloc:!0(var_19_74, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
	stloc:float32(var_21_82, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](ItemGrid_Layout::ExtraElementSpacing, ldloc:DraggableItemGrid_Layout[exp:ItemGrid_Layout](var_20))))
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

	// Token: 0x0400046D RID: 1133
	public int itemRow = 4;

	// Token: 0x0400046E RID: 1134
	public int itemColumn;
}
