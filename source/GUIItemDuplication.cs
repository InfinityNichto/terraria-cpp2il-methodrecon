using System;
using System.Collections.Generic;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.UI;

// Token: 0x0200014E RID: 334
public class GUIItemDuplication
{
	// Token: 0x0600091C RID: 2332 RVA: 0x00027874 File Offset: 0x00025A74
	public void Reset()
	{
		if (!true)
		{
		}
		if (!true)
		{
		}
	}

	// Token: 0x170000E5 RID: 229
	// (get) Token: 0x0600091D RID: 2333 RVA: 0x00027888 File Offset: 0x00025A88
	public bool HasFocus
	{
		get
		{
			DrPlatform.DrPlatformType currentPlatform = DrPlatform.CurrentPlatform;
			GUIControllerItemFilter controller = this.Filter._controller;
			bool flag;
			return flag;
		}
	}

	// Token: 0x170000E6 RID: 230
	// (get) Token: 0x0600091E RID: 2334 RVA: 0x000278B0 File Offset: 0x00025AB0
	public bool Collapsed
	{
		get
		{
			if (!true)
			{
			}
			return InterfaceStyles_Layout.Active.IsCollapsed(GUIPageIcons.Category.Duplicate);
		}
	}

	// Token: 0x0600091F RID: 2335 RVA: 0x000278D0 File Offset: 0x00025AD0
	public void DrawCraftButton()
	{
		int focusItem = this.FocusItem;
		int size = this.FilteredItems._size;
		if (this.Filter.Expanded)
		{
			bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		}
		if (size != 0)
		{
			return;
		}
		long num = 0L;
		Cursor cursor;
		if (cursor != null)
		{
			return;
		}
		if (Main.mouseItem.type != 0)
		{
			if (num != 0L)
			{
				if (size != 0)
				{
					return;
				}
				if (size != 0)
				{
					return;
				}
				if (PageControllerLayoutDefinition.Instance != null)
				{
					return;
				}
				List<int> filteredItems = this.FilteredItems;
				int focusItem2 = this.FocusItem;
				string textValue = Language.GetTextValue("Mobile.Duplicate");
				int hoverDuplicateEntry = this.HoverDuplicateEntry;
				int focusItem3 = this.FocusItem;
				GUITransactionButton.InputState inputState;
				if (inputState != GUITransactionButton.InputState.Clicked)
				{
					List<int> filteredItems2 = this.FilteredItems;
					int focusItem4 = this.FocusItem;
					if (hoverDuplicateEntry == 0)
					{
					}
					Main.mouseRight = true;
					return;
				}
				int type = Main.mouseItem.type;
				if (type != 0)
				{
					if (type == 0)
					{
					}
					if (Main.mouseItem.stack != 0)
					{
					}
				}
				List<int> filteredItems3 = this.FilteredItems;
				int focusItem5 = this.FocusItem;
				if (hoverDuplicateEntry == 0)
				{
				}
				return;
			}
		}
		else
		{
			while (num != 0L)
			{
			}
		}
	}

	// Token: 0x06000920 RID: 2336 RVA: 0x00027AC4 File Offset: 0x00025CC4
	public void ResetFilters()
	{
		GUIItemFilter filter = this.Filter;
	}

	// Token: 0x06000921 RID: 2337 RVA: 0x000021DB File Offset: 0x000003DB
	private void UpdateFilter(bool force = false)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000922 RID: 2338 RVA: 0x00027AD8 File Offset: 0x00025CD8
	private int CompareItemOrder(int x, int y)
	{
		int num;
		do
		{
			if (!true)
			{
			}
		}
		while (num != 0 || num.CompareTo(y) != 0);
		string text;
		string text2;
		return text.CompareTo(text2);
	}

	// Token: 0x06000923 RID: 2339 RVA: 0x00027AFC File Offset: 0x00025CFC
	public void LoadPageRegion()
	{
		!0 instance = PageControllerLayoutDefinition.Instance;
		!0 instance2 = PageControllerLayoutDefinition.Instance;
		DraggableItemGrid_Layout draggableItemGrid_Layout;
		int itemCount = draggableItemGrid_Layout.ItemCount;
		Rectangle rectangle;
		ControlAnchor.PageContentRegion = rectangle;
	}

	// Token: 0x06000924 RID: 2340 RVA: 0x00027B24 File Offset: 0x00025D24
	public void Draw()
	{
		int num = 1;
		if (num == 0)
		{
		}
		if (num == 0)
		{
		}
		long num2 = 0L;
		this.UpdateFilter(num2 != 0L);
		!0 instance = PageControllerLayoutDefinition.Instance;
		string textValue = Language.GetTextValue("Mobile.Duplication");
		int num3 = 1;
		!0 instance2 = PageControllerLayoutDefinition.Instance;
		!0 instance3 = PageControllerLayoutDefinition.Instance;
		DraggableItemGrid_Layout draggableItemGrid_Layout;
		int itemCount = draggableItemGrid_Layout.ItemCount;
		if (num3 == 0)
		{
		}
		Rectangle rectangle;
		if (rectangle == null)
		{
		}
		int mouseX = Main.mouseX;
		int mouseY = Main.mouseY;
	}

	// Token: 0x06000925 RID: 2341 RVA: 0x00027BD4 File Offset: 0x00025DD4
	public float CraftItemScale(int index)
	{
		/*
An exception occurred when decompiling this method (06000925)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIItemDuplication::CraftItemScale(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:!0(var_0_05, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
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

	// Token: 0x06000926 RID: 2342 RVA: 0x00027BE8 File Offset: 0x00025DE8
	public void CraftItemOver(int index)
	{
		int offset = this.Offset;
		int num = 1;
		this.wasOverItem = num != 0;
		this.cursorOver = index;
		int focusItem = this.FocusItem;
		int size = this.FilteredItems._size;
		this.FocusItem = index;
		Cursor cursor;
		if (cursor != null)
		{
			return;
		}
		long num2 = 0L;
		int focusItem2 = this.FocusItem;
		if (focusItem2 == 0)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		if (focusItem2 == 0)
		{
		}
		bool mouseLeftRelease = Main.mouseLeftRelease;
		if (num2 != 0L && !this.lastRightDown)
		{
			int size2 = this.FilteredItems._size;
			int focusItem3 = this.FocusItem;
			this.FocusItem = index;
			GUIControllerItemDuplication guicontrollerItemDuplication;
			if (num == 0 && guicontrollerItemDuplication != null)
			{
				int focusItem4 = this.FocusItem;
				GUIControllerDynamicGridNavigator guicontrollerDynamicGridNavigator;
				guicontrollerDynamicGridNavigator.Activate(focusItem4);
			}
		}
		this.lastRightDown = num2 != 0L;
		int size3 = this.FilteredItems._size;
		if (size3 == 0)
		{
		}
		int num3 = 1;
		this.HoverDuplicateEntry = index;
		if (size3 == 0)
		{
		}
		List<int> filteredItems = this.FilteredItems;
		if (num3 == 0)
		{
		}
	}

	// Token: 0x06000927 RID: 2343 RVA: 0x00027CF4 File Offset: 0x00025EF4
	public void CraftItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		int offset = this.Offset;
		int num = this.cursorOver;
		bool hasFocus = this.HasFocus;
		if (num == 0)
		{
		}
		if (!true)
		{
		}
		if (this.FilteredItems._size == 0)
		{
		}
		Main.inventoryScale = scale;
		int focusItem = this.FocusItem;
		if (num == 0)
		{
			bool controllerModeLocked = XNAUnityRunner.ControllerModeLocked;
			int focusItem2 = this.FocusItem;
		}
		int num2 = this.cursorOver;
		bool hasFocus2 = this.HasFocus;
		!0 instance = PageControllerLayoutDefinition.Instance;
		if (num2 == 0)
		{
		}
		ItemSlot.SetSelectHighlight(true, scale);
		if (instance == null)
		{
		}
		List<int> filteredItems = this.FilteredItems;
		if (num2 == 0)
		{
		}
		if (num2 == 0)
		{
		}
	}

	// Token: 0x06000928 RID: 2344 RVA: 0x00027DE0 File Offset: 0x00025FE0
	public GUIItemDuplication()
	{
	}

	// Token: 0x0400088B RID: 2187
	private float CraftButtonScale = (float)1;

	// Token: 0x0400088C RID: 2188
	private int Offset;

	// Token: 0x0400088D RID: 2189
	public int FocusItem;

	// Token: 0x0400088E RID: 2190
	private int LastId;

	// Token: 0x0400088F RID: 2191
	private GUIItemFilter.CategoryFilter LastCategory;

	// Token: 0x04000890 RID: 2192
	private string LastSearch;

	// Token: 0x04000891 RID: 2193
	private bool rightClickHeld;

	// Token: 0x04000892 RID: 2194
	public GUIItemFilter Filter;

	// Token: 0x04000893 RID: 2195
	private List<int> AvailableItems;

	// Token: 0x04000894 RID: 2196
	public List<int> FilteredItems;

	// Token: 0x04000895 RID: 2197
	public float craftScrollOffset;

	// Token: 0x04000896 RID: 2198
	private float craftScrollMomentum;

	// Token: 0x04000897 RID: 2199
	private int craftScrollDragging;

	// Token: 0x04000898 RID: 2200
	private Vector2 craftDragOffset;

	// Token: 0x04000899 RID: 2201
	private bool pendingCraft;

	// Token: 0x0400089A RID: 2202
	public float hoverCraftDelay;

	// Token: 0x0400089B RID: 2203
	public GUITransactionButton.InputState lastState;

	// Token: 0x0400089C RID: 2204
	private bool wasOverItem;

	// Token: 0x0400089D RID: 2205
	private int multiCraftDelay;

	// Token: 0x0400089E RID: 2206
	private int slowRampUp;

	// Token: 0x0400089F RID: 2207
	private int multiCraftRecipe;

	// Token: 0x040008A0 RID: 2208
	private int HoverDuplicateEntry;

	// Token: 0x040008A1 RID: 2209
	private int cursorOver;

	// Token: 0x040008A2 RID: 2210
	private bool lastRightDown;

	// Token: 0x040008A3 RID: 2211
	private Item blankItem;

	// Token: 0x040008A4 RID: 2212
	private string materialHoverItemName;

	// Token: 0x040008A5 RID: 2213
	private Item materialToolTip;
}
