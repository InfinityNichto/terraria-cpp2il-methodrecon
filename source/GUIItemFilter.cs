using System;
using System.Collections.Generic;
using Controller;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.Localization;

// Token: 0x0200014F RID: 335
public class GUIItemFilter
{
	// Token: 0x06000929 RID: 2345 RVA: 0x00027DFC File Offset: 0x00025FFC
	public GUIItemFilter(GUIPageIcons.Category cat)
	{
		this._cat = cat;
	}

	// Token: 0x0600092A RID: 2346 RVA: 0x00027E18 File Offset: 0x00026018
	public void Reset(bool expandedOnTouch = false)
	{
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
	}

	// Token: 0x0600092B RID: 2347 RVA: 0x00027E30 File Offset: 0x00026030
	public void SetFilterCategory(GUIItemFilter.CategoryFilter category)
	{
		this.ActiveCategory = category;
	}

	// Token: 0x0600092C RID: 2348 RVA: 0x00027E44 File Offset: 0x00026044
	public void SetSearchTerm(string term)
	{
		this.SearchTerm = term;
		bool flag = string.IsNullOrEmpty(term);
	}

	// Token: 0x0600092D RID: 2349 RVA: 0x00027E70 File Offset: 0x00026070
	public bool Matches(int itemId)
	{
		bool flag = this.miscFilterInitialised;
		int num;
		if (!flag)
		{
			if (!flag)
			{
			}
			num = 1;
			this.miscFilterInitialised = num != 0;
		}
		if (num == 0)
		{
		}
		if (num == 0)
		{
		}
		ISearchFilter<Item> searchFilter = this.searchFilter;
		long value = 0.m_value;
		throw new ArrayTypeMismatchException();
	}

	// Token: 0x0600092E RID: 2350 RVA: 0x00027EB0 File Offset: 0x000260B0
	public void CloseExpandedFilter()
	{
		if (this.editingSearch)
		{
			Main.CloseKeyboard();
			return;
		}
	}

	// Token: 0x0600092F RID: 2351 RVA: 0x00027ED0 File Offset: 0x000260D0
	private void LoadCategoryButtonIcon(TransactionButton_Layout button)
	{
		!0 instance = PageControllerLayoutDefinition.Instance;
		GUIItemFilter.CategoryFilter activeCategory = this.ActiveCategory;
	}

	// Token: 0x06000930 RID: 2352 RVA: 0x00027F04 File Offset: 0x00026104
	private void Close()
	{
		Main.CloseKeyboard();
	}

	// Token: 0x06000931 RID: 2353 RVA: 0x00027F18 File Offset: 0x00026118
	public void DrawFilter()
	{
		!0 instance = PageControllerLayoutDefinition.Instance;
		if (this.Expanded)
		{
			return;
		}
		this.DrawSearch();
		if (this.Expanded)
		{
			bool controllerModeLocked = XNAUnityRunner.ControllerModeLocked;
			if (this.pickingInterceptor == null)
			{
				GUIInputRegionExclusive guiinputRegionExclusive;
				this.pickingInterceptor = guiinputRegionExclusive;
				if (guiinputRegionExclusive != null)
				{
				}
			}
			GUIControllerItemFilter controller = this._controller;
			this.previousNavigationItem = controller;
			GUIControllerItemFilter controller2 = this._controller;
			string textValue = Language.GetTextValue("Mobile.FilterItemsClose");
			string textValue2 = Language.GetTextValue("Mobile.FilterItemsClose");
			bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
			return;
		}
		GUIControllerItemFilter controller3 = this._controller;
		GUIControllerItem guicontrollerItem = this.previousNavigationItem;
		if (this._cat == GUIPageIcons.Category.Crafting)
		{
			return;
		}
		string textValue3 = Language.GetTextValue("Mobile.FilterItems");
		bool anyControllerConnected2 = ControllerActionManager.AnyControllerConnected;
	}

	// Token: 0x06000932 RID: 2354 RVA: 0x000282D4 File Offset: 0x000264D4
	private void DrawSearch()
	{
		!0 instance = PageControllerLayoutDefinition.Instance;
		int num = 320;
		string textValue = Language.GetTextValue("Mobile.Search");
		if (num == 0)
		{
		}
		bool flag = this.editingSearch;
		GUITransactionButton.InputState inputState;
		int num2;
		bool flag2;
		if (inputState != GUITransactionButton.InputState.Clicked)
		{
			if (!this.editingSearch)
			{
				string searchTerm = this.SearchTerm;
				this.editDisplaySearch = searchTerm;
				return;
			}
		}
		else
		{
			num2 = 1;
			int num3 = 1;
			flag2 = this.editingSearch;
			if (!flag2)
			{
				this.editingSearch = num3 != 0;
				if (!flag2)
				{
				}
				Main.clrInput();
				string text = this.editSearch;
				this.editSearchStart = text;
				return;
			}
		}
		if (!flag2)
		{
		}
		if (num != 0)
		{
			return;
		}
		string text2 = this.editSearch;
		int num4 = 312;
		int num5 = 320;
		long num6 = 0L;
		if (num4 == 0)
		{
		}
		int num7 = 1;
		long num8 = 0L;
		long num9 = 0L;
		Rectangle rectangle;
		string inputText = Main.GetInputText(text2, rectangle, (int)num6, num2 != 0, num8 != 0L, num7 != 0, num9 != 0L);
		this.editSearch = inputText;
		if (num5 != 0)
		{
			string text3 = this.editSearchStart;
			this.editSearch = text3;
			if (text3 == null)
			{
			}
			Main.CloseKeyboard();
			return;
		}
		if (num5 == 0)
		{
		}
		Main.CloseKeyboard();
		string text4 = this.editSearch;
		this.SetSearchTerm(text4);
		string text5 = this.editSearch;
		this.editDisplaySearch = text5;
		string text6 = this.editDisplaySearch;
		SpriteFont spriteFont;
		Vector2 vector = spriteFont.MeasureString(text6);
		SpriteFont spriteFont2;
		Vector2 vector2 = spriteFont2.MeasureString("|");
		string text7 = this.editDisplaySearch;
		int num10 = 1;
		string text8 = text7.Substring(num10);
		this.editDisplaySearch = text8;
		string text9 = this.editDisplaySearch;
		SpriteFont spriteFont3;
		Vector2 vector3 = spriteFont3.MeasureString(text9);
		string text10 = this.editDisplaySearch;
	}

	// Token: 0x06000933 RID: 2355 RVA: 0x00028494 File Offset: 0x00026694
	public bool IsOver(Vector2 cursorPosition)
	{
		/*
An exception occurred when decompiling this method (06000933)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIItemFilter::IsOver(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_2:
	stloc:Rectangle(var_8_3E, callgetter:Rectangle(ControlAnchor::get_PageGroupRegion))
	stloc:Rectangle(var_10_48, callgetter:Rectangle(ControlAnchor::get_PageContentRegion))
	call:void(GUIPageIconGrouping::LoadPageAnchor, ldloc:GUIPageIconGrouping(var_6_30))
	stloc:!0(var_11_56, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
	callsetter:Rectangle(ControlAnchor::set_PageGroupRegion, ldloc:Rectangle(var_8_3E))
	callsetter:Rectangle(ControlAnchor::set_PageContentRegion, ldloc:Rectangle(var_10_48))
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

	// Token: 0x06000934 RID: 2356 RVA: 0x00028508 File Offset: 0x00026708
	// Note: this type is marked as 'beforefieldinit'.
	static GUIItemFilter()
	{
		if (("CreativePowers.TabAll" == null || "CreativePowers.TabAll" != null) && ("CreativePowers.TabWeapons" == null || "CreativePowers.TabWeapons" != null) && ("CreativePowers.TabArmor" == null || "CreativePowers.TabArmor" != null) && ("CreativePowers.TabVanity" == null || "CreativePowers.TabVanity" != null) && ("CreativePowers.TabBlocks" == null || "CreativePowers.TabBlocks" != null) && ("CreativePowers.TabFurniture" == null || "CreativePowers.TabFurniture" != null) && ("CreativePowers.TabAccessories" == null || "CreativePowers.TabAccessories" != null) && ("CreativePowers.TabAccessoriesMisc" == null || "CreativePowers.TabAccessoriesMisc" != null) && ("CreativePowers.TabConsumables" == null || "CreativePowers.TabConsumables" != null) && ("CreativePowers.TabTools" == null || "CreativePowers.TabTools" != null) && ("CreativePowers.TabMaterials" == null || "CreativePowers.TabMaterials" != null) && ("CreativePowers.TabMisc" == null || "CreativePowers.TabMisc" != null))
		{
			return;
		}
		throw new ArrayTypeMismatchException();
	}

	// Token: 0x040008A6 RID: 2214
	private GUIPageIcons.Category _cat;

	// Token: 0x040008A7 RID: 2215
	private static string[] categoryName;

	// Token: 0x040008A8 RID: 2216
	public GUIItemFilter.CategoryFilter ActiveCategory;

	// Token: 0x040008A9 RID: 2217
	public string SearchTerm;

	// Token: 0x040008AA RID: 2218
	public bool Expanded;

	// Token: 0x040008AB RID: 2219
	public bool editingSearch;

	// Token: 0x040008AC RID: 2220
	public string editSearch;

	// Token: 0x040008AD RID: 2221
	public string editSearchStart;

	// Token: 0x040008AE RID: 2222
	public string editDisplaySearch;

	// Token: 0x040008AF RID: 2223
	private static List<IItemEntryFilter> everythingButMisc;

	// Token: 0x040008B0 RID: 2224
	private static IItemEntryFilter[] CategoryFilters;

	// Token: 0x040008B1 RID: 2225
	private ISearchFilter<Item> searchFilter;

	// Token: 0x040008B2 RID: 2226
	private bool disableReset;

	// Token: 0x040008B3 RID: 2227
	private bool miscFilterInitialised;

	// Token: 0x040008B4 RID: 2228
	private float collapseScale;

	// Token: 0x040008B5 RID: 2229
	private float allScale;

	// Token: 0x040008B6 RID: 2230
	private float weaponScale;

	// Token: 0x040008B7 RID: 2231
	private float armorScale;

	// Token: 0x040008B8 RID: 2232
	private float vanityScale;

	// Token: 0x040008B9 RID: 2233
	private float buildingBlockScale;

	// Token: 0x040008BA RID: 2234
	private float furnitureScale;

	// Token: 0x040008BB RID: 2235
	private float gameplayItemsScale;

	// Token: 0x040008BC RID: 2236
	private float accessoriesScale;

	// Token: 0x040008BD RID: 2237
	private float equipmentScale;

	// Token: 0x040008BE RID: 2238
	private float consumablesScale;

	// Token: 0x040008BF RID: 2239
	private float toolsScale;

	// Token: 0x040008C0 RID: 2240
	private float materialsScale;

	// Token: 0x040008C1 RID: 2241
	public GUIControllerItemFilter _controller;

	// Token: 0x040008C2 RID: 2242
	private GUIControllerItem previousNavigationItem;

	// Token: 0x040008C3 RID: 2243
	private GUIInputRegionExclusive pickingInterceptor;

	// Token: 0x040008C4 RID: 2244
	private static float BeginSearchScale;

	// Token: 0x02000150 RID: 336
	public enum CategoryFilter
	{
		// Token: 0x040008C6 RID: 2246
		All,
		// Token: 0x040008C7 RID: 2247
		Weapon,
		// Token: 0x040008C8 RID: 2248
		Armor,
		// Token: 0x040008C9 RID: 2249
		Vanity,
		// Token: 0x040008CA RID: 2250
		BuildingBlock,
		// Token: 0x040008CB RID: 2251
		Furniture,
		// Token: 0x040008CC RID: 2252
		Accessories,
		// Token: 0x040008CD RID: 2253
		Equipment,
		// Token: 0x040008CE RID: 2254
		Consumables,
		// Token: 0x040008CF RID: 2255
		Tools,
		// Token: 0x040008D0 RID: 2256
		Materials,
		// Token: 0x040008D1 RID: 2257
		GameplayItems,
		// Token: 0x040008D2 RID: 2258
		Count
	}
}
