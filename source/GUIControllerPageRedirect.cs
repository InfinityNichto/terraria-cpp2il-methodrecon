using System;
using Cpp2IlInjected;

// Token: 0x020000D3 RID: 211
public class GUIControllerPageRedirect
{
	// Token: 0x17000093 RID: 147
	// (get) Token: 0x06000549 RID: 1353 RVA: 0x000021DB File Offset: 0x000003DB
	public GUIControllerAmmo Ammo
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x17000094 RID: 148
	// (get) Token: 0x0600054A RID: 1354 RVA: 0x000021DB File Offset: 0x000003DB
	public GUIControllerCoins Coins
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x17000095 RID: 149
	// (get) Token: 0x0600054B RID: 1355 RVA: 0x000021DB File Offset: 0x000003DB
	public GUIControllerEquipment Equipment
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x17000096 RID: 150
	// (get) Token: 0x0600054C RID: 1356 RVA: 0x000021DB File Offset: 0x000003DB
	public GUIControllerInventory Inventory
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x17000097 RID: 151
	// (get) Token: 0x0600054D RID: 1357 RVA: 0x000021DB File Offset: 0x000003DB
	public GUIControllerHousing Housing
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x17000098 RID: 152
	// (get) Token: 0x0600054E RID: 1358 RVA: 0x000021DB File Offset: 0x000003DB
	public GUIControllerPVP PVP
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x17000099 RID: 153
	// (get) Token: 0x0600054F RID: 1359 RVA: 0x000021DB File Offset: 0x000003DB
	public GUIControllerShop Shop
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x1700009A RID: 154
	// (get) Token: 0x06000550 RID: 1360 RVA: 0x000021DB File Offset: 0x000003DB
	public GUIControllerTrash Trash
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x1700009B RID: 155
	// (get) Token: 0x06000551 RID: 1361 RVA: 0x000021DB File Offset: 0x000003DB
	public GUIControllerChest Chest
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x1700009C RID: 156
	// (get) Token: 0x06000552 RID: 1362 RVA: 0x000021DB File Offset: 0x000003DB
	public GUIControllerCrafting Crafting
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x1700009D RID: 157
	// (get) Token: 0x06000553 RID: 1363 RVA: 0x000021DB File Offset: 0x000003DB
	public GUIControllerItemDuplication Duplicate
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x1700009E RID: 158
	// (get) Token: 0x06000554 RID: 1364 RVA: 0x000021DB File Offset: 0x000003DB
	public GUIControllerDisplayDoll DisplayDoll
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x1700009F RID: 159
	// (get) Token: 0x06000555 RID: 1365 RVA: 0x000021DB File Offset: 0x000003DB
	public GUIControllerHatRack HatRack
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x170000A0 RID: 160
	// (get) Token: 0x06000556 RID: 1366 RVA: 0x000021DB File Offset: 0x000003DB
	public GUIControllerReforge Reforge
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x170000A1 RID: 161
	// (get) Token: 0x06000557 RID: 1367 RVA: 0x000021DB File Offset: 0x000003DB
	public GUIControllerCraftingGuide CraftingGuide
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x06000558 RID: 1368 RVA: 0x0001046C File Offset: 0x0000E66C
	public bool IsPageController(GUIControllerItem item)
	{
		GUIControllerLeftPageSelector leftSelector = this.LeftSelector;
		GUIControllerRightPageSelector rightSelector = this.RightSelector;
		if (item != null)
		{
			return;
		}
	}

	// Token: 0x06000559 RID: 1369 RVA: 0x0001048C File Offset: 0x0000E68C
	public GUIControllerItem GetDefaultRightController()
	{
		GUIControllerItem guicontrollerItem;
		return guicontrollerItem;
	}

	// Token: 0x0600055A RID: 1370 RVA: 0x0001049C File Offset: 0x0000E69C
	public GUIPageIcons.Category GetCategoryFromNavigationItem(GUIControllerItem item)
	{
		GUIControllerChest chest = this.Chest;
		GUIControllerEquipment equipment = this.Equipment;
		GUIControllerCrafting crafting = this.Crafting;
		GUIControllerItemDuplication duplicate = this.Duplicate;
		GUIControllerHatRack hatRack = this.HatRack;
		GUIControllerDisplayDoll displayDoll = this.DisplayDoll;
		GUIControllerShop shop = this.Shop;
		GUIControllerHousing housing = this.Housing;
		GUIControllerReforge reforge = this.Reforge;
		GUIControllerResearchPage4Page researchPage = this.ResearchPage;
		GUIControllerChat chat = this.Chat;
		GUIControllerCraftingGuide craftingGuide = this.CraftingGuide;
		GUIControllerPVP pvp = this.PVP;
		GUIControllerAmmo ammo = this.Ammo;
		GUIControllerCoins coins = this.Coins;
		GUIControllerInventory inventory = this.Inventory;
		GUIControllerTrash trash = this.Trash;
		return GUIPageIcons.Category.None;
	}

	// Token: 0x0600055B RID: 1371 RVA: 0x00010554 File Offset: 0x0000E754
	public GUIControllerItem GetItemController(GUIPageIcons.Category item)
	{
		/*
An exception occurred when decompiling this method (0600055B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerItem GUIControllerPageRedirect::GetItemController(GUIPageIcons/Category)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_002A:
	stloc:int32(var_7_32, callgetter:int32(Main::get_myPlayer))
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

	// Token: 0x0600055C RID: 1372 RVA: 0x00010594 File Offset: 0x0000E794
	public GUIControllerItem NavigateIntoEquipment(int itemColumn)
	{
	}

	// Token: 0x0600055D RID: 1373 RVA: 0x000105A4 File Offset: 0x0000E7A4
	public GUIControllerItem NavigateIntoInteraction(int itemColumn)
	{
	}

	// Token: 0x0600055E RID: 1374 RVA: 0x000105B4 File Offset: 0x0000E7B4
	public GUIControllerItem NavigateIntoRight(int itemRow)
	{
		/*
An exception occurred when decompiling this method (0600055E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerItem GUIControllerPageRedirect::NavigateIntoRight(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0085:
	stloc:int32(var_43_8C, ldfld:int32(GUIControllerItemDuplication::scrollOffset, ldloc:GUIControllerItemDuplication(var_42)))
	stloc:int32(var_46_95, ldfld:int32(GUIControllerItemDuplication::scrollOffset, ldloc:GUIControllerItemDuplication(var_45)))
	stfld:int32(GUIControllerItemDuplication::itemColumn, ldloc:GUIControllerItemDuplication(var_44), ldloc:int32(var_46_95))
	stfld:int32(GUIControllerItemDuplication::itemRow, ldloc:GUIControllerItemDuplication(var_47), ldloc:int32(itemRow))
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

	// Token: 0x0600055F RID: 1375 RVA: 0x00010668 File Offset: 0x0000E868
	public GUIControllerItem NavigateIntoCraftColumn(int itemColumn)
	{
	}

	// Token: 0x06000560 RID: 1376 RVA: 0x00010678 File Offset: 0x0000E878
	public GUIControllerItem NavigateIntoLeftColumn(int itemColumn)
	{
	}

	// Token: 0x06000561 RID: 1377 RVA: 0x00010688 File Offset: 0x0000E888
	public GUIControllerItem NavigateIntoLeft(int itemRow)
	{
		return GUIControllerInventory.NavigateIntoCoinsAmmo(itemRow);
	}

	// Token: 0x06000562 RID: 1378 RVA: 0x000106BC File Offset: 0x0000E8BC
	public GUIControllerPageRedirect()
	{
	}

	// Token: 0x04000480 RID: 1152
	public GUIControllerLeftPageSelector LeftSelector;

	// Token: 0x04000481 RID: 1153
	public GUIControllerRightPageSelector RightSelector;

	// Token: 0x04000482 RID: 1154
	public GUIControllerAmmo AmmoNormal;

	// Token: 0x04000483 RID: 1155
	public GUIControllerAmmo4Page Ammo4Page;

	// Token: 0x04000484 RID: 1156
	public GUIControllerCoins CoinsNormal;

	// Token: 0x04000485 RID: 1157
	public GUIControllerCoins4Page Coins4Page;

	// Token: 0x04000486 RID: 1158
	public GUIControllerEquipment EquipmentNormal;

	// Token: 0x04000487 RID: 1159
	public GUIControllerEquipment4Page Equipment4Page;

	// Token: 0x04000488 RID: 1160
	private GUIControllerInventory InventoryNormal;

	// Token: 0x04000489 RID: 1161
	private GUIControllerInventory4Page Inventory4Page;

	// Token: 0x0400048A RID: 1162
	private GUIControllerHousing HousingNormal;

	// Token: 0x0400048B RID: 1163
	private GUIControllerHousing4Page Housing4Page;

	// Token: 0x0400048C RID: 1164
	private GUIControllerPVP PVPNormal;

	// Token: 0x0400048D RID: 1165
	private GUIControllerPVP4Page PVP4Page;

	// Token: 0x0400048E RID: 1166
	private GUIControllerShop ShopNormal;

	// Token: 0x0400048F RID: 1167
	private GUIControllerShop4Page Shop4Page;

	// Token: 0x04000490 RID: 1168
	private GUIControllerTrash TrashNormal;

	// Token: 0x04000491 RID: 1169
	private GUIControllerTrash4Page Trash4Page;

	// Token: 0x04000492 RID: 1170
	private GUIControllerChest ChestNormal;

	// Token: 0x04000493 RID: 1171
	private GUIControllerChest4Page Chest4Page;

	// Token: 0x04000494 RID: 1172
	private GUIControllerCrafting CraftingNormal;

	// Token: 0x04000495 RID: 1173
	private GUIControllerCrafting4Page Crafting4Page;

	// Token: 0x04000496 RID: 1174
	private GUIControllerItemDuplication DuplicateNormal;

	// Token: 0x04000497 RID: 1175
	private GUIControllerItemDuplication4Page Duplicate4Page;

	// Token: 0x04000498 RID: 1176
	private GUIControllerDisplayDoll DisplayDollNormal;

	// Token: 0x04000499 RID: 1177
	private GUIControllerDisplayDoll4Page DisplayDoll4Page;

	// Token: 0x0400049A RID: 1178
	private GUIControllerHatRack HatRackNormal;

	// Token: 0x0400049B RID: 1179
	private GUIControllerHatRack4Page HatRack4Page;

	// Token: 0x0400049C RID: 1180
	private GUIControllerReforge ReforgeNormal;

	// Token: 0x0400049D RID: 1181
	private GUIControllerReforge4Page Reforge4Page;

	// Token: 0x0400049E RID: 1182
	public GUIControllerResearchPage4Page ResearchPage;

	// Token: 0x0400049F RID: 1183
	public GUIControllerDresser Dresser;

	// Token: 0x040004A0 RID: 1184
	public GUIControllerHairStylist Hair;

	// Token: 0x040004A1 RID: 1185
	private GUIControllerCraftingGuide CraftingGuideNormal;

	// Token: 0x040004A2 RID: 1186
	private GUIControllerCraftingGuide4Page CraftingGuide4Page;

	// Token: 0x040004A3 RID: 1187
	public GUIControllerChat Chat;
}
