using System;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria;

// Token: 0x020000CC RID: 204
public class GUIControllerInventory : GUIPageContentController
{
	// Token: 0x06000506 RID: 1286 RVA: 0x0000F8FC File Offset: 0x0000DAFC
	public GUIControllerInventory()
	{
	}

	// Token: 0x06000507 RID: 1287 RVA: 0x0000F910 File Offset: 0x0000DB10
	public override void Activate()
	{
		int myPlayer = Main.myPlayer;
	}

	// Token: 0x06000508 RID: 1288 RVA: 0x000021DB File Offset: 0x000003DB
	public static GUIControllerItem NavigateIntoCoinsAmmo(int row)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000509 RID: 1289 RVA: 0x0000F950 File Offset: 0x0000DB50
	public virtual void NavigateToItem(int item)
	{
	}

	// Token: 0x1700008C RID: 140
	// (get) Token: 0x0600050A RID: 1290 RVA: 0x0000F980 File Offset: 0x0000DB80
	private static int MaxRowIndex
	{
		get
		{
			int itemLineCount = BuilderAccToggles_Layout.Instance.ToggleOptionsGrid.ItemLineCount;
			int num;
			return num;
		}
	}

	// Token: 0x1700008D RID: 141
	// (get) Token: 0x0600050B RID: 1291 RVA: 0x0000F9A0 File Offset: 0x0000DBA0
	private static int MaxColumnIndex
	{
		get
		{
			/*
An exception occurred when decompiling this method (0600050B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 GUIControllerInventory::get_MaxColumnIndex()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_2_11, ldfld:int32(ItemGrid_Layout::ItemLineCount, callgetter:ItemGrid_Layout(BuilderAccToggles_Layout::get_ToggleOptionsGrid, callgetter:BuilderAccToggles_Layout(BuilderAccToggles_Layout::get_Instance))))
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
	}

	// Token: 0x0600050C RID: 1292 RVA: 0x0000F9C0 File Offset: 0x0000DBC0
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		int num = this.toolRow;
		int maxRowIndex = GUIControllerInventory.MaxRowIndex;
		int num2 = this.toolRow;
		this.toolRow = num2;
		int num3 = this.toolColumn;
		int maxColumnIndex = GUIControllerInventory.MaxColumnIndex;
		if (BuilderAccToggles_Layout.Instance.ToggleOptionsGrid.ItemLineCount == 0)
		{
			int itemLineCount = BuilderAccToggles_Layout.Instance.ToggleOptionsGrid.ItemLineCount;
		}
		int num4 = this.toolRow;
		int num5 = this.itemColumn;
		int num6 = this.toolRow;
		this.toolRow = num6;
		int num7 = this.toolColumn;
		int maxColumnIndex2 = GUIControllerInventory.MaxColumnIndex;
		int num8 = this.toolColumn;
		int maxColumnIndex3 = GUIControllerInventory.MaxColumnIndex;
		int itemLineCount2;
		if (BuilderAccToggles_Layout.Instance.ToggleOptionsGrid.ItemLineCount == 0)
		{
			itemLineCount2 = BuilderAccToggles_Layout.Instance.ToggleOptionsGrid.ItemLineCount;
		}
		int num9 = this.toolRow;
		this.toolRow = itemLineCount2;
		int num10 = this.toolColumn;
		this.toolColumn = num10;
		int num11 = this.itemColumn;
		return GUIControllerInventory.NavigateIntoCoinsAmmo(this.itemRow);
	}

	// Token: 0x0600050D RID: 1293 RVA: 0x0000FAE8 File Offset: 0x0000DCE8
	public override Rectangle GetSelectedItemRegion()
	{
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		!0 instance = PageControllerLayoutDefinition.Instance;
		ItemGrid_Layout toggleOptionsGrid = BuilderAccToggles_Layout.Instance.ToggleOptionsGrid;
		ControlAnchor.ControlId firstAnchorControl = toggleOptionsGrid.FirstAnchorControl;
		Vector2 firstItemLocation = toggleOptionsGrid.FirstItemLocation;
		float x = toggleOptionsGrid.FirstItemLocation.X;
		float y = toggleOptionsGrid.FirstItemLocation.Y;
		float toggleScale = BuilderAccToggles_Layout.Instance.ToggleScale;
		float x2 = toggleOptionsGrid.ExtraElementSpacing.X;
		float y2 = toggleOptionsGrid.ExtraElementSpacing.Y;
		int itemLineCount = toggleOptionsGrid.ItemLineCount;
		Rectangle rectangle;
		return rectangle;
	}

	// Token: 0x04000470 RID: 1136
	public int itemRow;

	// Token: 0x04000471 RID: 1137
	public int itemColumn;

	// Token: 0x04000472 RID: 1138
	public int toolRow;

	// Token: 0x04000473 RID: 1139
	public int toolColumn;
}
