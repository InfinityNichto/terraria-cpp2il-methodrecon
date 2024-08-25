using System;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

// Token: 0x020000BE RID: 190
public class GUIControllerCraftingGuidePopup : GUIControllerItem
{
	// Token: 0x0600049F RID: 1183 RVA: 0x000021DB File Offset: 0x000003DB
	private DraggableItemGrid_Layout GetGrid()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060004A0 RID: 1184 RVA: 0x0000E734 File Offset: 0x0000C934
	private int GetCollectionCount()
	{
		int num;
		return num;
	}

	// Token: 0x060004A1 RID: 1185 RVA: 0x000021DB File Offset: 0x000003DB
	private float GetItemScale()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060004A2 RID: 1186 RVA: 0x000021DB File Offset: 0x000003DB
	private float GetScrollOffset()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060004A3 RID: 1187 RVA: 0x0000E744 File Offset: 0x0000C944
	private void SetScrollOffset(float offset)
	{
	}

	// Token: 0x060004A4 RID: 1188 RVA: 0x0000E754 File Offset: 0x0000C954
	public bool IsInMenu()
	{
		return this.GridNav.InMenu;
	}

	// Token: 0x060004A5 RID: 1189 RVA: 0x0000E76C File Offset: 0x0000C96C
	private int GetMenuItemCount()
	{
	}

	// Token: 0x060004A6 RID: 1190 RVA: 0x0000E77C File Offset: 0x0000C97C
	private int GetDisplayItemCount()
	{
	}

	// Token: 0x17000084 RID: 132
	// (get) Token: 0x060004A7 RID: 1191 RVA: 0x0000E78C File Offset: 0x0000C98C
	public GUIControllerDynamicGridNavigator GridNav
	{
		get
		{
			/*
An exception occurred when decompiling this method (060004A7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerDynamicGridNavigator GUIControllerCraftingGuidePopup::get_GridNav()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:GUIControllerDynamicGridNavigator[exp:bool](GUIControllerCraftingGuidePopup::_gridNav, ldloc:GUIControllerCraftingGuidePopup(this)))
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

	// Token: 0x060004A8 RID: 1192 RVA: 0x0000E7A0 File Offset: 0x0000C9A0
	public int GetNavigationOutDirs()
	{
		return this.GridNav.GetNavigationOutDirs();
	}

	// Token: 0x060004A9 RID: 1193 RVA: 0x0000E7B8 File Offset: 0x0000C9B8
	public void Activate()
	{
		GUIControllerDynamicGridNavigator gridNav = this.GridNav;
		long num = 0L;
		gridNav.Activate((int)num);
	}

	// Token: 0x060004AA RID: 1194 RVA: 0x0000E7D8 File Offset: 0x0000C9D8
	public void RefreshScrollOffset()
	{
		this.GridNav.RefreshScrollOffset();
	}

	// Token: 0x060004AB RID: 1195 RVA: 0x0000E7F0 File Offset: 0x0000C9F0
	protected void UpdateScroll()
	{
	}

	// Token: 0x060004AC RID: 1196 RVA: 0x0000E800 File Offset: 0x0000CA00
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		while (this.selectedControl != GUIControllerCraftingGuidePopup.Controls.Element)
		{
		}
		int itemRow = this.GridNav.itemRow;
		DraggableItemGrid_Layout draggableItemGrid_Layout;
		int itemLineCount = draggableItemGrid_Layout.ItemLineCount;
		DraggableItemGrid_Layout draggableItemGrid_Layout2;
		int itemLineCount2 = draggableItemGrid_Layout2.ItemLineCount;
		GUIControllerDynamicGridNavigator gridNav = this.GridNav;
		GUIControllerItem guicontrollerItem;
		return guicontrollerItem;
	}

	// Token: 0x060004AD RID: 1197 RVA: 0x0000E84C File Offset: 0x0000CA4C
	protected void ClampPosition()
	{
	}

	// Token: 0x060004AE RID: 1198 RVA: 0x0000E85C File Offset: 0x0000CA5C
	public Rectangle GetSelectedItemRegion()
	{
		if (this.selectedControl != GUIControllerCraftingGuidePopup.Controls.Element)
		{
			Rectangle rectangle;
			return rectangle;
		}
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		return this.GridNav.GetSelectedItemRegion();
	}

	// Token: 0x060004AF RID: 1199 RVA: 0x0000E888 File Offset: 0x0000CA88
	public void NavigateInto(int column, int row)
	{
		this.GridNav.NavigateInto(column, row);
	}

	// Token: 0x060004B0 RID: 1200 RVA: 0x0000E8A4 File Offset: 0x0000CAA4
	public GUIControllerCraftingGuidePopup()
	{
	}

	// Token: 0x04000444 RID: 1092
	public GUIControllerCraftingGuidePopup.Controls selectedControl;

	// Token: 0x04000445 RID: 1093
	private GUIControllerDynamicGridNavigator _gridNav;

	// Token: 0x020000BF RID: 191
	public enum Controls
	{
		// Token: 0x04000447 RID: 1095
		Element,
		// Token: 0x04000448 RID: 1096
		Back
	}
}
