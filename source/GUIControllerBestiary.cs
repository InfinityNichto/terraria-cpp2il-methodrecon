using System;
using Microsoft.Xna.Framework;

// Token: 0x02000088 RID: 136
public class GUIControllerBestiary : GUIControllerItem
{
	// Token: 0x06000342 RID: 834 RVA: 0x0000ABA4 File Offset: 0x00008DA4
	public int GetNavigationOutDirs()
	{
	}

	// Token: 0x06000343 RID: 835 RVA: 0x0000ABB4 File Offset: 0x00008DB4
	public void Activate()
	{
		this.UpdateScroll();
	}

	// Token: 0x06000344 RID: 836 RVA: 0x0000ABC8 File Offset: 0x00008DC8
	public int GetSelectedIndex()
	{
		if (this.filtersActive)
		{
			int num = this.filterSelectedColumn;
			bool flag = this.onFilterSearchItem;
		}
		return this.SelectedIndex;
	}

	// Token: 0x06000345 RID: 837 RVA: 0x0000ABF4 File Offset: 0x00008DF4
	public void ActivateFilters()
	{
		if (this.filtersActive)
		{
			return;
		}
		this.onFilterSearchItem = 256 != 0;
	}

	// Token: 0x06000346 RID: 838 RVA: 0x0000AC18 File Offset: 0x00008E18
	public void DeactivateFilters()
	{
		if (this.filtersActive)
		{
			this.UpdateScroll();
			return;
		}
	}

	// Token: 0x06000347 RID: 839 RVA: 0x0000AC34 File Offset: 0x00008E34
	public void ActivateOrders(int maxOrders, int selectedOrder)
	{
		if (this.ordersActive)
		{
			return;
		}
		this.SelectedIndex = selectedOrder;
	}

	// Token: 0x06000348 RID: 840 RVA: 0x0000AC54 File Offset: 0x00008E54
	public void DeactivateOrders()
	{
	}

	// Token: 0x06000349 RID: 841 RVA: 0x0000AC64 File Offset: 0x00008E64
	public void ActivateDrops(int maxDrops)
	{
		if (this.dropsActive)
		{
			return;
		}
		int num = 1;
		this.dropsActive = num != 0;
	}

	// Token: 0x0600034A RID: 842 RVA: 0x0000AC84 File Offset: 0x00008E84
	public void DeactivateDrops()
	{
	}

	// Token: 0x0600034B RID: 843 RVA: 0x0000AC94 File Offset: 0x00008E94
	public void SelectEntry(int index)
	{
		if (true || true)
		{
			return;
		}
	}

	// Token: 0x0600034C RID: 844 RVA: 0x0000ACAC File Offset: 0x00008EAC
	public void SelectNPCEntry(int index)
	{
	}

	// Token: 0x0600034D RID: 845 RVA: 0x0000ACBC File Offset: 0x00008EBC
	public void SelectFilterEntry(int index)
	{
	}

	// Token: 0x0600034E RID: 846 RVA: 0x0000ACCC File Offset: 0x00008ECC
	public void SelectDropEntry(int index)
	{
		this.SelectedIndex = index;
	}

	// Token: 0x17000076 RID: 118
	// (get) Token: 0x0600034F RID: 847 RVA: 0x0000ACE0 File Offset: 0x00008EE0
	private int maxRowIndex
	{
		get
		{
			/*
An exception occurred when decompiling this method (0600034F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 GUIControllerBestiary::get_maxRowIndex()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldfld:bool(GUIControllerBestiary::filtersActive, ldloc:GUIControllerBestiary(this))))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
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
	}

	// Token: 0x17000077 RID: 119
	// (get) Token: 0x06000350 RID: 848 RVA: 0x0000ACF4 File Offset: 0x00008EF4
	private int maxRowColumn
	{
		get
		{
			if (this.filtersActive)
			{
				return;
			}
		}
	}

	// Token: 0x06000351 RID: 849 RVA: 0x0000AD0C File Offset: 0x00008F0C
	private void UpdateScroll()
	{
		Rectangle rectangle;
		ControlAnchor.SetMainMenuPageRegion(rectangle);
		if (this.dropsActive)
		{
			int selectedIndex = this.SelectedIndex;
			return;
		}
		if (!this.filtersActive && !this.ordersActive)
		{
			int selectedRow = this.SelectedRow;
			return;
		}
	}

	// Token: 0x06000352 RID: 850 RVA: 0x0000AD50 File Offset: 0x00008F50
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		/*
An exception occurred when decompiling this method (06000352)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerItem GUIControllerBestiary::Navigate(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_009C:
	stloc:int32(var_13_A2, ldfld:int32(GUIControllerBestiary::SelectedRow, ldloc:GUIControllerBestiary(this)))
	stloc:int32(var_14_AA, ldfld:int32(GUIControllerBestiary::SelectedIndex, ldloc:GUIControllerBestiary(this)))
	stloc:int32(var_15_B2, ldfld:int32(GUIControllerBestiary::maxItemIndex, ldloc:GUIControllerBestiary(this)))
	stfld:int32(GUIControllerBestiary::SelectedIndex, ldloc:GUIControllerBestiary(this), ldloc:int32(var_14_AA))
	stloc:int32(var_16_C2, ldfld:int32(GUIControllerBestiary::filterSelectedColumn, ldloc:GUIControllerBestiary(this)))
	stloc:int32(var_17_CA, callgetter:int32(GUIControllerBestiary::get_maxRowColumn, ldloc:GUIControllerBestiary(this)))
	stloc:int32(var_18_D2, ldfld:int32(GUIControllerBestiary::filterSelectedColumn, ldloc:GUIControllerBestiary(this)))
	stfld:int32(GUIControllerBestiary::filterSelectedColumn, ldloc:GUIControllerBestiary(this), ldloc:int32(var_18_D2))
	call:void(GUIControllerBestiary::UpdateScroll, ldloc:GUIControllerBestiary(this))
	stloc:int32(var_19_E8, ldfld:int32(GUIControllerBestiary::SelectedRow, ldloc:GUIControllerBestiary(this)))
	stloc:int32(var_20_F0, callgetter:int32(GUIControllerBestiary::get_maxRowIndex, ldloc:GUIControllerBestiary(this)))
	stloc:int32(var_21_F8, ldfld:int32(GUIControllerBestiary::SelectedRow, ldloc:GUIControllerBestiary(this)))
	stfld:int32(GUIControllerBestiary::SelectedRow, ldloc:GUIControllerBestiary(this), ldloc:int32(var_21_F8))
	call:void(GUIControllerBestiary::UpdateScroll, ldloc:GUIControllerBestiary(this))
	stloc:int32(var_22_10E, ldfld:int32(GUIControllerBestiary::SelectedColumn, ldloc:GUIControllerBestiary(this)))
	stloc:int32(var_23_116, ldfld:int32(GUIControllerBestiary::SelectedRow, ldloc:GUIControllerBestiary(this)))
	stloc:int32(var_24_11E, callgetter:int32(GUIControllerBestiary::get_maxRowIndex, ldloc:GUIControllerBestiary(this)))
	stloc:int32(var_25_126, ldfld:int32(GUIControllerBestiary::SelectedColumn, ldloc:GUIControllerBestiary(this)))
	stloc:int32(var_26_12E, ldfld:int32(GUIControllerBestiary::SelectedColumn, ldloc:GUIControllerBestiary(this)))
	stloc:int32(var_27_136, callgetter:int32(GUIControllerBestiary::get_maxRowColumn, ldloc:GUIControllerBestiary(this)))
	stloc:int32(var_28_13E, ldfld:int32(GUIControllerBestiary::SelectedColumn, ldloc:GUIControllerBestiary(this)))
	stfld:int32(GUIControllerBestiary::SelectedColumn, ldloc:GUIControllerBestiary(this), ldloc:int32(var_28_13E))
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

	// Token: 0x06000353 RID: 851 RVA: 0x0000AEA4 File Offset: 0x000090A4
	private void ClampGrid()
	{
		int selectedRow = this.SelectedRow;
		int maxRowIndex = this.maxRowIndex;
		int maxRowIndex2 = this.maxRowIndex;
		this.SelectedRow = maxRowIndex2;
		this.UpdateScroll();
		int selectedRow2 = this.SelectedRow;
		int maxRowIndex3 = this.maxRowIndex;
		int selectedColumn = this.SelectedColumn;
		int maxRowColumn = this.maxRowColumn;
		int maxRowColumn2 = this.maxRowColumn;
		this.SelectedColumn = maxRowColumn2;
	}

	// Token: 0x06000354 RID: 852 RVA: 0x0000AF04 File Offset: 0x00009104
	public Rectangle GetSelectedItemRegion()
	{
		/*
An exception occurred when decompiling this method (06000354)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle GUIControllerBestiary::GetSelectedItemRegion()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0047:
	call:void(GUIControllerBestiary::ClampGrid, ldloc:GUIControllerBestiary(this))
	stloc:int32(var_10_53, ldfld:int32(GUIControllerBestiary::SelectedRow, ldloc:GUIControllerBestiary(this)))
	stloc:int32(var_11_5B, ldfld:int32(GUIControllerBestiary::SelectedColumn, ldloc:GUIControllerBestiary(this)))
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

	// Token: 0x06000355 RID: 853 RVA: 0x0000AF70 File Offset: 0x00009170
	public GUIControllerBestiary()
	{
	}

	// Token: 0x04000346 RID: 838
	private int SelectedRow;

	// Token: 0x04000347 RID: 839
	private int SelectedColumn;

	// Token: 0x04000348 RID: 840
	private int SelectedIndex;

	// Token: 0x04000349 RID: 841
	private int filterSelectedColumn;

	// Token: 0x0400034A RID: 842
	private int filterSelectedRow;

	// Token: 0x0400034B RID: 843
	private bool onFilterSearchItem;

	// Token: 0x0400034C RID: 844
	private bool filtersActive;

	// Token: 0x0400034D RID: 845
	private bool ordersActive;

	// Token: 0x0400034E RID: 846
	private bool dropsActive;

	// Token: 0x0400034F RID: 847
	private int maxItemIndex;
}
