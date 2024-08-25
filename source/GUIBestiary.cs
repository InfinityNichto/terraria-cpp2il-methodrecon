using System;
using System.Collections.Generic;
using System.Text;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Terraria.Localization;

// Token: 0x02000123 RID: 291
public class GUIBestiary
{
	// Token: 0x0600074D RID: 1869 RVA: 0x0001B28C File Offset: 0x0001948C
	public GUIBestiary()
	{
	}

	// Token: 0x0600074E RID: 1870 RVA: 0x0001B2A4 File Offset: 0x000194A4
	public static void LoadContent()
	{
		if (!true)
		{
		}
	}

	// Token: 0x0600074F RID: 1871 RVA: 0x0001B2B8 File Offset: 0x000194B8
	public void DrawButton()
	{
		bool mapFullscreen = Main.mapFullscreen;
	}

	// Token: 0x06000750 RID: 1872 RVA: 0x0001B2D0 File Offset: 0x000194D0
	private void NPCDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x06000751 RID: 1873 RVA: 0x000021DB File Offset: 0x000003DB
	private float NPCScale(int index)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000752 RID: 1874 RVA: 0x0001B324 File Offset: 0x00019524
	private void NPCOver(int index)
	{
		this.EntryOver = index;
		if (!true)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		if (!true)
		{
		}
		bool mouseLeftRelease = Main.mouseLeftRelease;
		if (this.editingSearch)
		{
			this.CloseSearchInput();
		}
		List<BestiaryEntry> sortedEntries = this.SortedEntries;
		this.SelectedEntry = sortedEntries;
		this.RefreshSelectedStats();
		this._controllerInput.SelectNPCEntry(index);
	}

	// Token: 0x06000753 RID: 1875 RVA: 0x0001B380 File Offset: 0x00019580
	public void Close()
	{
		this.CloseFilters();
		this.CloseSortOrder();
		this.CloseLootDrops();
		ISearchFilter<BestiaryEntry> searchFilter = this.searchFilter;
		if (searchFilter != null)
		{
		}
		if (this.SelectedEntry != null)
		{
		}
		if (searchFilter == null)
		{
		}
		Main.inFancyUI = false;
		bool openedFromInv = this.OpenedFromInv;
		if (!openedFromInv)
		{
			if (!openedFromInv)
			{
			}
			bool gameMenu = Main.gameMenu;
		}
	}

	// Token: 0x06000754 RID: 1876 RVA: 0x000021DB File Offset: 0x000003DB
	private void RefreshEntries()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000755 RID: 1877 RVA: 0x0001B3D4 File Offset: 0x000195D4
	private int SortCompare(BestiaryEntry x, BestiaryEntry y)
	{
		/*
An exception occurred when decompiling this method (06000755)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 GUIBestiary::SortCompare(Terraria.GameContent.Bestiary.BestiaryEntry,Terraria.GameContent.Bestiary.BestiaryEntry)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_0_09, ldfld:int32(GUIBestiary::SelectedSort, ldloc:GUIBestiary(this)))
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

	// Token: 0x06000756 RID: 1878 RVA: 0x0001B3EC File Offset: 0x000195EC
	private void DrawFilterSearch()
	{
		bool flag = this.editingSearch;
		GUITransactionButton.InputState inputState;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
			int num = 1;
			this.editingSearch = num != 0;
			if (-2147483648 == 0)
			{
			}
			Main.clrInput();
		}
		bool flag2 = this.editingSearch;
		if (flag2)
		{
			if (!flag2)
			{
			}
			return;
		}
		bool flag3 = string.IsNullOrWhiteSpace(this.searchTerm);
		string textValue = Language.GetTextValue("UI.PlayerNameSlot");
	}

	// Token: 0x06000757 RID: 1879 RVA: 0x0001B57C File Offset: 0x0001977C
	private void CloseSearchInput()
	{
		if (!true)
		{
		}
		Main.CloseKeyboard();
	}

	// Token: 0x06000758 RID: 1880 RVA: 0x0001B594 File Offset: 0x00019794
	public void SetSearchTerm(string term)
	{
		bool flag = string.IsNullOrWhiteSpace(term);
	}

	// Token: 0x06000759 RID: 1881 RVA: 0x0001B5AC File Offset: 0x000197AC
	public void Open()
	{
		int num = 1;
		this.Enabled = num != 0;
		int size = this.filterEnabled._size;
		int size2 = this.filterEnabled._size;
		this.RefreshEntries();
		this.RefreshPercentUnlocked();
	}

	// Token: 0x0600075A RID: 1882 RVA: 0x0001B5E8 File Offset: 0x000197E8
	private bool IsOverLoot(Vector2 cursorPosition)
	{
		/*
An exception occurred when decompiling this method (0600075A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIBestiary::IsOverLoot(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	stloc:GUIInputRegionExclusive(var_2_10, ldfld:GUIInputRegionExclusive(GUIBestiary::_lootBlocker, ldloc:GUIBestiary(this)))
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

	// Token: 0x0600075B RID: 1883 RVA: 0x0001B608 File Offset: 0x00019808
	private bool IsOverOrders(Vector2 cursorPosition)
	{
		/*
An exception occurred when decompiling this method (0600075B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIBestiary::IsOverOrders(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	stloc:GUIInputRegionExclusive(var_2_10, ldfld:GUIInputRegionExclusive(GUIBestiary::_orderBlocker, ldloc:GUIBestiary(this)))
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

	// Token: 0x0600075C RID: 1884 RVA: 0x0001B628 File Offset: 0x00019828
	private bool IsOverFilters(Vector2 cursorPosition)
	{
		/*
An exception occurred when decompiling this method (0600075C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIBestiary::IsOverFilters(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	stloc:GUIInputRegionExclusive(var_2_10, ldfld:GUIInputRegionExclusive(GUIBestiary::_filterBlocker, ldloc:GUIBestiary(this)))
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

	// Token: 0x0600075D RID: 1885 RVA: 0x0001B648 File Offset: 0x00019848
	private void DrawLootDrops()
	{
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		int num = 136;
		this.CloseLootDrops();
		BestiaryEntry selectedEntry = this.SelectedEntry;
		List<ItemDropBestiaryInfoElement> dropProviders = this.GetDropProviders(selectedEntry);
		IBestiaryUICollectionInfoProvider uiinfoProvider = selectedEntry.UIInfoProvider;
		if (num != 0)
		{
		}
	}

	// Token: 0x0600075E RID: 1886 RVA: 0x0001B7B8 File Offset: 0x000199B8
	private void DrawProgressBar()
	{
		int num = this.unlockedEntries;
		string text2;
		string text = text2 + "%";
		string text3;
		string text4;
		if (text3 != null && ("/" == null || "/" != null) && (text4 == null || text4 != null) && (" (" == null || " (" != null) && (text == null || text != null) && (")" == null || ")" != null))
		{
			if (!true)
			{
			}
			return;
		}
		throw new ArrayTypeMismatchException();
	}

	// Token: 0x0600075F RID: 1887 RVA: 0x0001B820 File Offset: 0x00019A20
	private void RefreshPercentUnlocked()
	{
		if (!true)
		{
		}
	}

	// Token: 0x06000760 RID: 1888 RVA: 0x0001B84C File Offset: 0x00019A4C
	public void Draw()
	{
		if (!true)
		{
		}
		bool gameMenu = Main.gameMenu;
		this.Close();
	}

	// Token: 0x06000761 RID: 1889 RVA: 0x0001B978 File Offset: 0x00019B78
	private void FilterDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		List<Texture2D> list = this.filterTexture;
		List<Rectangle> list2 = this.filterFrame;
		List<string> list3 = this.filterName;
		if (list2 == null)
		{
		}
		if (32640 == 0)
		{
		}
		List<bool> list4 = this.filterEnabled;
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
	}

	// Token: 0x06000762 RID: 1890 RVA: 0x0001B9B8 File Offset: 0x00019BB8
	private void FilterOver(int index)
	{
		this.filterOver = index;
		if (!true)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		if (!true)
		{
		}
		bool mouseLeftRelease = Main.mouseLeftRelease;
		List<bool> list = this.filterAvailable;
		bool flag = this.editingSearch;
		if (flag)
		{
			this.CloseSearchInput();
		}
		if (!flag)
		{
		}
		Main.mouseLeftRelease = false;
		List<bool> list2 = this.filterEnabled;
		this.RefreshEntries();
	}

	// Token: 0x06000763 RID: 1891 RVA: 0x000021DB File Offset: 0x000003DB
	private float FilterScale(int index)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000764 RID: 1892 RVA: 0x0001BA24 File Offset: 0x00019C24
	private void DrawFilters()
	{
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		int activeFilterCount = this.ActiveFilterCount;
		if (!this.drawLootDrops && !this.displayOrders)
		{
			bool anyControllerConnected2 = ControllerActionManager.AnyControllerConnected;
			return;
		}
		bool anyControllerConnected3 = ControllerActionManager.AnyControllerConnected;
		bool flag = this.displayFilters;
		GUITransactionButton.InputState inputState;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
			bool flag2 = this.displayFilters;
			bool flag3 = this.displayOrders;
			this.displayFilters = flag2;
			if (flag3)
			{
				this.CloseSortOrder();
			}
			if (this.drawLootDrops)
			{
				this.CloseLootDrops();
			}
		}
		if (this.displayFilters)
		{
			if (this._filterBlocker == null)
			{
				GUIInputRegionExclusive guiinputRegionExclusive;
				this._filterBlocker = guiinputRegionExclusive;
				if (guiinputRegionExclusive != null)
				{
				}
			}
			int num = 1;
			bool anyControllerConnected4 = ControllerActionManager.AnyControllerConnected;
			this._controllerInput.ActivateFilters();
			List<bool> list = this.filterEnabled;
			GUIItemGrid.CursorOver cursorOver = this.filterItemOver;
			GUIItemGrid.GetItemScaleHandler getItemScaleHandler = this.filterScale;
			GUIItemGrid.DrawItemHandler drawItemHandler = this.filterDraw;
			int size = list._size;
			if (num == 0)
			{
			}
			this.DrawFilterSearch();
			GUIInputRegionExclusive filterBlocker = this._filterBlocker;
			if (filterBlocker != null)
			{
				int num2 = 1;
				filterBlocker.Active = num2 != 0;
			}
			return;
		}
		this.CloseFilters();
	}

	// Token: 0x06000765 RID: 1893 RVA: 0x0001BB38 File Offset: 0x00019D38
	private void OrderDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		if (32768 == 0)
		{
		}
	}

	// Token: 0x06000766 RID: 1894 RVA: 0x0001BB58 File Offset: 0x00019D58
	private void OrderOver(int index)
	{
		this.orderOver = index;
		if (!true)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		if (!true)
		{
		}
		bool mouseLeftRelease = Main.mouseLeftRelease;
		if (!true)
		{
		}
		Main.mouseLeftRelease = false;
		this.SelectedSort = index;
	}

	// Token: 0x06000767 RID: 1895 RVA: 0x000021DB File Offset: 0x000003DB
	private float OrderScale(int index)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000768 RID: 1896 RVA: 0x0001BB94 File Offset: 0x00019D94
	private void DrawOrders()
	{
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		int num = 96;
		this.CloseSortOrder();
		string textValue = Language.GetTextValue("Mobile.BestiarySort");
		if (num == 0)
		{
		}
		int selectedSort = this.SelectedSort;
		if (num != 0)
		{
		}
	}

	// Token: 0x06000769 RID: 1897 RVA: 0x0001BCCC File Offset: 0x00019ECC
	private NamePlateInfoElement GetName(BestiaryEntry entry)
	{
		/*
An exception occurred when decompiling this method (06000769)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.Bestiary.NamePlateInfoElement GUIBestiary::GetName(Terraria.GameContent.Bestiary.BestiaryEntry)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0013:
	stloc:int32(var_3_1E, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class Terraria.GameContent.Bestiary.IBestiaryInfoElement>[exp:List`1](BestiaryEntry::<Info>k__BackingField, ldloc:BestiaryEntry(entry))))
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

	// Token: 0x0600076A RID: 1898 RVA: 0x0001BCFC File Offset: 0x00019EFC
	private IBestiaryEntryDisplayIndex GetDisplayIndex(BestiaryEntry entry)
	{
		/*
An exception occurred when decompiling this method (0600076A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.Bestiary.IBestiaryEntryDisplayIndex GUIBestiary::GetDisplayIndex(Terraria.GameContent.Bestiary.BestiaryEntry)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_3_1E, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class Terraria.GameContent.Bestiary.IBestiaryInfoElement>[exp:List`1](BestiaryEntry::<Info>k__BackingField, ldloc:BestiaryEntry(entry))))
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

	// Token: 0x0600076B RID: 1899 RVA: 0x0001BD2C File Offset: 0x00019F2C
	private NPCPortraitInfoElement GetNPCPortraitInfo(BestiaryEntry entry)
	{
		/*
An exception occurred when decompiling this method (0600076B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.Bestiary.NPCPortraitInfoElement GUIBestiary::GetNPCPortraitInfo(Terraria.GameContent.Bestiary.BestiaryEntry)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0013:
	stloc:int32(var_3_1E, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class Terraria.GameContent.Bestiary.IBestiaryInfoElement>[exp:List`1](BestiaryEntry::<Info>k__BackingField, ldloc:BestiaryEntry(entry))))
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

	// Token: 0x0600076C RID: 1900 RVA: 0x0001BD5C File Offset: 0x00019F5C
	private NPCStatsReportInfoElement GetNPCStatsInfo(BestiaryEntry entry)
	{
		/*
An exception occurred when decompiling this method (0600076C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.Bestiary.NPCStatsReportInfoElement GUIBestiary::GetNPCStatsInfo(Terraria.GameContent.Bestiary.BestiaryEntry)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0013:
	stloc:int32(var_3_1E, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class Terraria.GameContent.Bestiary.IBestiaryInfoElement>[exp:List`1](BestiaryEntry::<Info>k__BackingField, ldloc:BestiaryEntry(entry))))
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

	// Token: 0x0600076D RID: 1901 RVA: 0x0001BD8C File Offset: 0x00019F8C
	private void RefreshSelectedStats()
	{
		BestiaryEntry selectedEntry = this.SelectedEntry;
		if (selectedEntry != null)
		{
			NPCStatsReportInfoElement npcstatsInfo = this.GetNPCStatsInfo(selectedEntry);
			if (npcstatsInfo != null)
			{
				npcstatsInfo.Refresh();
				return;
			}
		}
	}

	// Token: 0x0600076E RID: 1902 RVA: 0x0001BDB8 File Offset: 0x00019FB8
	private FlavorTextBestiaryInfoElement GetNPCFlavourInfo(BestiaryEntry entry)
	{
		/*
An exception occurred when decompiling this method (0600076E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.Bestiary.FlavorTextBestiaryInfoElement GUIBestiary::GetNPCFlavourInfo(Terraria.GameContent.Bestiary.BestiaryEntry)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0013:
	stloc:int32(var_3_1E, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class Terraria.GameContent.Bestiary.IBestiaryInfoElement>[exp:List`1](BestiaryEntry::<Info>k__BackingField, ldloc:BestiaryEntry(entry))))
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

	// Token: 0x0600076F RID: 1903 RVA: 0x0001BDE8 File Offset: 0x00019FE8
	private IPreferenceProviderElement GetPreferenceProvider(BestiaryEntry entry)
	{
		/*
An exception occurred when decompiling this method (0600076F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.Bestiary.IPreferenceProviderElement GUIBestiary::GetPreferenceProvider(Terraria.GameContent.Bestiary.BestiaryEntry)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_3_1E, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class Terraria.GameContent.Bestiary.IBestiaryInfoElement>[exp:List`1](BestiaryEntry::<Info>k__BackingField, ldloc:BestiaryEntry(entry))))
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

	// Token: 0x06000770 RID: 1904 RVA: 0x000021DB File Offset: 0x000003DB
	private List<IBestiaryBackgroundImagePathAndColorProvider> GetBackgroundImageProviders(BestiaryEntry entry)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000771 RID: 1905 RVA: 0x000021DB File Offset: 0x000003DB
	private List<IBestiaryBackgroundOverlayAndColorProvider> GetBackgroundOverlayProviders(BestiaryEntry entry)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000772 RID: 1906 RVA: 0x0001BE18 File Offset: 0x0001A018
	private int SortBackgroundOverlayElements(IBestiaryBackgroundOverlayAndColorProvider x, IBestiaryBackgroundOverlayAndColorProvider y)
	{
		int num;
		return num;
	}

	// Token: 0x06000773 RID: 1907 RVA: 0x000021DB File Offset: 0x000003DB
	private List<FilterProviderInfoElement> GetFilterProviders(BestiaryEntry entry)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000774 RID: 1908 RVA: 0x000021DB File Offset: 0x000003DB
	private List<ItemDropBestiaryInfoElement> GetDropProviders(BestiaryEntry entry)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000775 RID: 1909 RVA: 0x0001BE28 File Offset: 0x0001A028
	private void UpdateBackgroundImages(BestiaryEntry entry)
	{
		BestiaryEntry bestiaryEntry = this.backgroundEntry;
		Color[] array = this.backgroundColour;
		if (bestiaryEntry == null)
		{
		}
		List<IBestiaryBackgroundImagePathAndColorProvider> backgroundImageProviders = this.GetBackgroundImageProviders(entry);
		IPreferenceProviderElement preferenceProviderElement;
		if (preferenceProviderElement != null)
		{
			return;
		}
	}

	// Token: 0x06000776 RID: 1910 RVA: 0x0001BF40 File Offset: 0x0001A140
	private void DrawImageBackgrounds(Rectangle region, BestiaryEntry entry)
	{
		if (this.backgroundImageCount == 0)
		{
		}
		Texture2D[] array = this.backgroundImage;
		Color[] array2 = this.backgroundColour;
		string <Name>k__BackingField = array.<Name>k__BackingField;
	}

	// Token: 0x06000777 RID: 1911 RVA: 0x000021DB File Offset: 0x000003DB
	private float StarScale(int index)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000778 RID: 1912 RVA: 0x0001BF70 File Offset: 0x0001A170
	private void StarOver(int index)
	{
	}

	// Token: 0x06000779 RID: 1913 RVA: 0x0001BF80 File Offset: 0x0001A180
	private void StarDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		int num = this.starCount;
		if (!true)
		{
		}
	}

	// Token: 0x0600077A RID: 1914 RVA: 0x000021DB File Offset: 0x000003DB
	private float DropScale(int index)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x0600077B RID: 1915 RVA: 0x0001BF9C File Offset: 0x0001A19C
	private void DropOver(int index)
	{
		this.DropItemOver = index;
		if (!true)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		if (!true)
		{
		}
		bool mouseLeftRelease = Main.mouseLeftRelease;
		if (!true)
		{
		}
		Main.mouseLeftRelease = false;
		this.SelectedDropItem = index;
		this._controllerInput.SelectedIndex = index;
	}

	// Token: 0x0600077C RID: 1916 RVA: 0x0001BFE4 File Offset: 0x0001A1E4
	private void SetBestiaryNotesOnItemCache(DropRateInfo info)
	{
		if (info.conditions != null)
		{
			while (info == null)
			{
			}
			return;
		}
	}

	// Token: 0x0600077D RID: 1917 RVA: 0x000021DB File Offset: 0x000003DB
	private void DropDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x0600077E RID: 1918 RVA: 0x000021DB File Offset: 0x000003DB
	private float SpawnScale(int index)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x0600077F RID: 1919 RVA: 0x0001C030 File Offset: 0x0001A230
	private void SpawnOver(int index)
	{
	}

	// Token: 0x06000780 RID: 1920 RVA: 0x000021DB File Offset: 0x000003DB
	private void SpawnDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000781 RID: 1921 RVA: 0x0001C040 File Offset: 0x0001A240
	private void DrawCoins()
	{
		IBestiaryUICollectionInfoProvider uiinfoProvider = this.SelectedEntry.UIInfoProvider;
	}

	// Token: 0x06000782 RID: 1922 RVA: 0x0001C07C File Offset: 0x0001A27C
	private void DrawSelectedEntry()
	{
		BestiaryEntry selectedEntry = this.SelectedEntry;
		IBestiaryUICollectionInfoProvider uiinfoProvider = selectedEntry.UIInfoProvider;
	}

	// Token: 0x06000783 RID: 1923 RVA: 0x0001C1EC File Offset: 0x0001A3EC
	private void CloseLootDrops()
	{
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
	}

	// Token: 0x06000784 RID: 1924 RVA: 0x0001C204 File Offset: 0x0001A404
	private void CloseFilters()
	{
		if (this._filterBlocker != null)
		{
		}
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		this._controllerInput.DeactivateFilters();
	}

	// Token: 0x06000785 RID: 1925 RVA: 0x0001C230 File Offset: 0x0001A430
	private void CloseSortOrder()
	{
		if (this._orderBlocker != null)
		{
		}
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		this._controllerInput.DeactivateOrders();
	}

	// Token: 0x06000786 RID: 1926 RVA: 0x0001C25C File Offset: 0x0001A45C
	// Note: this type is marked as 'beforefieldinit'.
	static GUIBestiary()
	{
	}

	// Token: 0x040005B6 RID: 1462
	private static Texture2D lockedIcon;

	// Token: 0x040005B7 RID: 1463
	private static Texture2D iconRankLight;

	// Token: 0x040005B8 RID: 1464
	private static Texture2D iconRankDim;

	// Token: 0x040005B9 RID: 1465
	private static Texture2D iconTagsShadow;

	// Token: 0x040005BA RID: 1466
	private GUIControllerBestiary _controllerInput;

	// Token: 0x040005BB RID: 1467
	private static Texture_Layout sortIconBackup;

	// Token: 0x040005BC RID: 1468
	private static Texture_Layout sortIconBackup2;

	// Token: 0x040005BD RID: 1469
	private float bestiaryButtonScale;

	// Token: 0x040005BE RID: 1470
	private float TitleScale;

	// Token: 0x040005BF RID: 1471
	private float BackScale;

	// Token: 0x040005C0 RID: 1472
	private GUIItemGrid.CursorOver npcItemOver;

	// Token: 0x040005C1 RID: 1473
	private GUIItemGrid.GetItemScaleHandler npcScale;

	// Token: 0x040005C2 RID: 1474
	private GUIItemGrid.DrawItemHandler npcDraw;

	// Token: 0x040005C3 RID: 1475
	private int EntryOver;

	// Token: 0x040005C4 RID: 1476
	public BestiaryEntry SelectedEntry;

	// Token: 0x040005C5 RID: 1477
	public float ScrollOffset;

	// Token: 0x040005C6 RID: 1478
	private float ScrollMomentum;

	// Token: 0x040005C7 RID: 1479
	private int ScrollDragging;

	// Token: 0x040005C8 RID: 1480
	private Vector2 DragOffset;

	// Token: 0x040005C9 RID: 1481
	public List<BestiaryEntry> SortedEntries;

	// Token: 0x040005CA RID: 1482
	private EntrySorter<BestiaryEntry, IBestiarySortStep> _sorter;

	// Token: 0x040005CB RID: 1483
	private bool editingSearch;

	// Token: 0x040005CC RID: 1484
	private string searchTerm;

	// Token: 0x040005CD RID: 1485
	private string editDisplaySearch;

	// Token: 0x040005CE RID: 1486
	private float BeginSearchScale;

	// Token: 0x040005CF RID: 1487
	private ISearchFilter<BestiaryEntry> searchFilter;

	// Token: 0x040005D0 RID: 1488
	private int ActiveFilterCount;

	// Token: 0x040005D1 RID: 1489
	private int SelectedSort;

	// Token: 0x040005D2 RID: 1490
	public float LootScrollOffset;

	// Token: 0x040005D3 RID: 1491
	private float LootScrollMomentum;

	// Token: 0x040005D4 RID: 1492
	private int LootScrollDragging;

	// Token: 0x040005D5 RID: 1493
	private Vector2 LootDragOffset;

	// Token: 0x040005D6 RID: 1494
	public List<bool> filterEnabled;

	// Token: 0x040005D7 RID: 1495
	private List<Texture2D> filterTexture;

	// Token: 0x040005D8 RID: 1496
	private List<string> filterName;

	// Token: 0x040005D9 RID: 1497
	private List<Rectangle> filterFrame;

	// Token: 0x040005DA RID: 1498
	private List<bool> filterAvailable;

	// Token: 0x040005DB RID: 1499
	public bool Enabled;

	// Token: 0x040005DC RID: 1500
	public bool OpenedFromInv;

	// Token: 0x040005DD RID: 1501
	private GUIInputRegionExclusive _lootBlocker;

	// Token: 0x040005DE RID: 1502
	private int unlockedEntries;

	// Token: 0x040005DF RID: 1503
	private bool displayFilters;

	// Token: 0x040005E0 RID: 1504
	private bool displayOrders;

	// Token: 0x040005E1 RID: 1505
	private float filtersScale;

	// Token: 0x040005E2 RID: 1506
	private float ordersScale;

	// Token: 0x040005E3 RID: 1507
	private GUIItemGrid.CursorOver filterItemOver;

	// Token: 0x040005E4 RID: 1508
	private GUIItemGrid.GetItemScaleHandler filterScale;

	// Token: 0x040005E5 RID: 1509
	private GUIItemGrid.DrawItemHandler filterDraw;

	// Token: 0x040005E6 RID: 1510
	private int filterOver;

	// Token: 0x040005E7 RID: 1511
	private GUIInputRegionExclusive _filterBlocker;

	// Token: 0x040005E8 RID: 1512
	private static StringBuilder sb;

	// Token: 0x040005E9 RID: 1513
	private GUIItemGrid.CursorOver orderItemOver;

	// Token: 0x040005EA RID: 1514
	private GUIItemGrid.GetItemScaleHandler orderScale;

	// Token: 0x040005EB RID: 1515
	private GUIItemGrid.DrawItemHandler orderDraw;

	// Token: 0x040005EC RID: 1516
	private int orderOver;

	// Token: 0x040005ED RID: 1517
	private GUIInputRegionExclusive _orderBlocker;

	// Token: 0x040005EE RID: 1518
	private List<IBestiaryBackgroundImagePathAndColorProvider> BackgroundImageProviders;

	// Token: 0x040005EF RID: 1519
	private List<IBestiaryBackgroundOverlayAndColorProvider> BackgroundOverlayProviders;

	// Token: 0x040005F0 RID: 1520
	private List<FilterProviderInfoElement> FilterProviders;

	// Token: 0x040005F1 RID: 1521
	private List<ItemDropBestiaryInfoElement> DropProviders;

	// Token: 0x040005F2 RID: 1522
	private BestiaryEntry backgroundEntry;

	// Token: 0x040005F3 RID: 1523
	private int backgroundImageCount;

	// Token: 0x040005F4 RID: 1524
	private Texture2D[] backgroundImage;

	// Token: 0x040005F5 RID: 1525
	private Color[] backgroundColour;

	// Token: 0x040005F6 RID: 1526
	private GUIItemGrid.CursorOver starOver;

	// Token: 0x040005F7 RID: 1527
	private GUIItemGrid.GetItemScaleHandler starScale;

	// Token: 0x040005F8 RID: 1528
	private GUIItemGrid.DrawItemHandler starDraw;

	// Token: 0x040005F9 RID: 1529
	private int starCount;

	// Token: 0x040005FA RID: 1530
	private GUIItemGrid.CursorOver dropOver;

	// Token: 0x040005FB RID: 1531
	private GUIItemGrid.GetItemScaleHandler dropScale;

	// Token: 0x040005FC RID: 1532
	private GUIItemGrid.DrawItemHandler dropDraw;

	// Token: 0x040005FD RID: 1533
	private int DropItemOver;

	// Token: 0x040005FE RID: 1534
	private int SelectedDropItem;

	// Token: 0x040005FF RID: 1535
	private Item dropItemInfo;

	// Token: 0x04000600 RID: 1536
	private int dropCount;

	// Token: 0x04000601 RID: 1537
	private GUIItemGrid.CursorOver spawnOver;

	// Token: 0x04000602 RID: 1538
	private GUIItemGrid.GetItemScaleHandler spawnScale;

	// Token: 0x04000603 RID: 1539
	private GUIItemGrid.DrawItemHandler spawnDraw;

	// Token: 0x04000604 RID: 1540
	private int spawnCount;

	// Token: 0x04000605 RID: 1541
	private bool drawLootDrops;

	// Token: 0x04000606 RID: 1542
	private NPCStatsReportInfoElement dummyStatsInfo;
}
