using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.IO;
using Terraria.Localization;
using UnityEngine;

// Token: 0x02000075 RID: 117
public class GUIControllerMappings
{
	// Token: 0x06000289 RID: 649 RVA: 0x0000732C File Offset: 0x0000552C
	public void ClearMappingStates()
	{
		this.World.ClearMappings();
		this.BaseInventory.ClearMappings();
	}

	// Token: 0x0600028A RID: 650 RVA: 0x00007350 File Offset: 0x00005550
	private void ClearWorldMappings()
	{
		this.MovementAxisX.Clear();
		this.MovementAxisY.Clear();
		this.MovementAxisAltX.Clear();
		this.MovementAxisAltY.Clear();
		this.FireAxisX.Clear();
		this.FireAxisY.Clear();
		this.FireAxisAltX.Clear();
		this.FireAxisAltY.Clear();
		this.GrappleAxisX.Clear();
		this.GrappleAxisY.Clear();
		this.HotbarAxisX.Clear();
		this.HotbarAxisY.Clear();
		this.GrappleFire.Clear();
		this.GridSnapAxisX.Clear();
		this.GridSnapAxisY.Clear();
		this.Jump.Clear();
		this.Fire.Clear();
		this.FireAlt.Clear();
		this.Interact.Clear();
		this.TargetLockOn.Clear();
		this.InventoryToggle.Clear();
		this.AutoSelect.Clear();
		this.SmartCursor.Clear();
		this.AutoFire.Clear();
		this.HotbarNext.Clear();
		this.HotbarPrevious.Clear();
		this.ZoomIn.Clear();
		this.ZoomOut.Clear();
		this.MapZoomIn.Clear();
		this.MapZoomOut.Clear();
		this.MapZoomDefault.Clear();
		this.QuickHeal.Clear();
		this.QuickMana.Clear();
		this.QuickBuff.Clear();
		this.QuickMount.Clear();
		this.MapToggle.Clear();
		this.ChatToggle.Clear();
		this.MiniMapToggle.Clear();
		this.BuffNext.Clear();
		this.BuffPrevious.Clear();
		this.BuffRemove.Clear();
		this.Hotbar1.Clear();
		this.Hotbar2.Clear();
		this.Hotbar3.Clear();
		this.Hotbar4.Clear();
		this.Hotbar5.Clear();
		this.Hotbar6.Clear();
		this.Hotbar7.Clear();
		this.Hotbar8.Clear();
		this.Hotbar9.Clear();
		this.Hotbar10.Clear();
		this.DynamicHotbar1.Clear();
		this.DynamicHotbar2.Clear();
		this.DynamicHotbar3.Clear();
		this.DynamicHotbar4.Clear();
		this.Loadout1.Clear();
		this.Loadout2.Clear();
		this.Loadout3.Clear();
		this.LoadoutCycle.Clear();
	}

	// Token: 0x0600028B RID: 651 RVA: 0x000075E8 File Offset: 0x000057E8
	private void ClearInventoryMappings()
	{
		this.InventoryNavigationX.Clear();
		this.InventoryNavigationY.Clear();
		this.InventoryNavigationAltX.Clear();
		this.InventoryNavigationAltY.Clear();
		this.LeftPageCycle.Clear();
		this.RightPageCycle.Clear();
		this.WorldFocusToggle.Clear();
		this.ThrowItem.Clear();
		this.TrashItem.Clear();
		this.DepositHeldItem.Clear();
		this.FavouriteItem.Clear();
		this.ResearchItem.Clear();
		this.SplitItem.Clear();
		this.PickupPlaceItem.Clear();
		this.CraftItem.Clear();
		this.FilterItems.Clear();
		this.ToggleCraftDuplicate.Clear();
		this.HousingQuery.Clear();
		this.TakeOne.Clear();
		this.Sort.Clear();
		this.BuilderTools.Clear();
		this.ReforgeItem.Clear();
		this.InventoryClose.Clear();
		this.ShowHideItem.Clear();
		this.InfoAccessories.Clear();
		this.ChestQuickStack.Clear();
		this.ChestLootAll.Clear();
		this.ChestDepositAll.Clear();
		this.ChestRestock.Clear();
		this.ChestRename.Clear();
		this.ChestLoot.Clear();
		this.ChestDeposit.Clear();
		this.ChestSort.Clear();
		this.EquipmentEquip.Clear();
		this.EquipmentUnequip.Clear();
		this.ShopSell.Clear();
		this.ShopBuy.Clear();
		this.PVPEnableToggle.Clear();
		this.PVPSwitchTeam.Clear();
	}

	// Token: 0x0600028C RID: 652 RVA: 0x000077A4 File Offset: 0x000059A4
	public void Backup()
	{
		this.World.Backup();
		this.WorldInteract.Backup();
		this.WorldShared.Backup();
		this.WorldInteractFallback.Backup();
		this.BaseInventory.Backup();
		this.Inventory.Backup();
		this.Equipment.Backup();
		this.PVP.Backup();
		this.Housing.Backup();
		this.ItemHeld.Backup();
		this.ChestInv.Backup();
		this.Chest.Backup();
		this.ShopInv.Backup();
		this.Shop.Backup();
		this.Crafting.Backup();
		this.Reforge.Backup();
		this.Chat.Backup();
	}

	// Token: 0x0600028D RID: 653 RVA: 0x0000786C File Offset: 0x00005A6C
	public void RestoreBackup()
	{
		this.World.RestoreBackup();
		this.WorldShared.RestoreBackup();
		this.WorldInteract.RestoreBackup();
		this.WorldInteractFallback.RestoreBackup();
		this.BaseInventory.RestoreBackup();
		this.Inventory.RestoreBackup();
		this.Equipment.RestoreBackup();
		this.PVP.RestoreBackup();
		this.Housing.RestoreBackup();
		this.ItemHeld.RestoreBackup();
		this.ChestInv.RestoreBackup();
		this.Chest.RestoreBackup();
		this.ShopInv.RestoreBackup();
		this.Shop.RestoreBackup();
		this.Crafting.RestoreBackup();
		this.Reforge.RestoreBackup();
		this.Chat.RestoreBackup();
		this.LoadMappingValues();
	}

	// Token: 0x0600028E RID: 654 RVA: 0x0000793C File Offset: 0x00005B3C
	public void ClearMapping()
	{
		List<GUIControllerMappingEntryBase> categorySettings = this._categorySettings;
		GUIControllerMappingOverlay controllerInput = this._controllerInput;
		int size = categorySettings._size;
		int selectedItem = controllerInput._selectedItem;
		if (categorySettings != null)
		{
		}
	}

	// Token: 0x0600028F RID: 655 RVA: 0x00007970 File Offset: 0x00005B70
	public void RegisterOverlay(GUIControllerMappingEntryBase entry, Rectangle region)
	{
		this.overlayEntry = entry;
		this.overlayRegion = region;
		if (entry != null)
		{
		}
	}

	// Token: 0x06000290 RID: 656 RVA: 0x000079A4 File Offset: 0x00005BA4
	public void Draw()
	{
		GUIControllerMappingOverlay controllerInput = this._controllerInput;
	}

	// Token: 0x06000291 RID: 657 RVA: 0x00007A30 File Offset: 0x00005C30
	public void LooseFocus()
	{
		if (!this.hasFocus || this._categoriesBlocker != null)
		{
		}
	}

	// Token: 0x06000292 RID: 658 RVA: 0x00007A50 File Offset: 0x00005C50
	private void GainFocus()
	{
		if (!this.hasFocus)
		{
			GUIInputRegionExclusive guiinputRegionExclusive;
			this._categoriesBlocker = guiinputRegionExclusive;
			this.hasFocus = true;
		}
	}

	// Token: 0x06000293 RID: 659 RVA: 0x00007A74 File Offset: 0x00005C74
	private bool IsOverCategories(Microsoft.Xna.Framework.Vector2 cursorPosition)
	{
		if (this.overlayEntry == null)
		{
			Rectangle rectangle;
			int bottom = rectangle.Bottom;
			bool flag;
			return flag;
		}
	}

	// Token: 0x06000294 RID: 660 RVA: 0x00007A94 File Offset: 0x00005C94
	private void DrawCategories()
	{
		if (this._categoriesBlocker != null)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		bool mouseLeftRelease = Main.mouseLeftRelease;
		int num = 17096;
		this.TimeSinceItemChange = (float)num;
		ControllerMappingsCategories_Layout.Category[] tabOrder = this.TabOrder;
		ControllerMappingsCategories_Layout.Category selected = this.Selected;
		if (this._controllerInput._overlayEntry == null)
		{
			ControllerMappingsCategories_Layout.Category[] tabOrder2 = this.TabOrder;
			ControllerMappingsCategories_Layout.Category[] tabOrder3 = this.TabOrder;
			this.overlayEntry = 0f;
		}
		if (this._controllerInput._overlayEntry == null)
		{
			ControllerMappingsCategories_Layout.Category[] tabOrder4 = this.TabOrder;
			ControllerMappingsCategories_Layout.Category[] tabOrder5 = this.TabOrder;
			this._controllerInput.UpdateScroll();
		}
		ControllerMappingsCategories_Layout.Category selected2 = this.Selected;
		GUITransactionButton.InputState inputState;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
			this._controllerInput.UpdateScroll();
		}
		ControllerMappingsCategories_Layout.Category selected3 = this.Selected;
		GUITransactionButton.InputState inputState2;
		if (inputState2 == GUITransactionButton.InputState.Clicked)
		{
			this._controllerInput.UpdateScroll();
		}
		ControllerMappingsCategories_Layout.Category selected4 = this.Selected;
		GUITransactionButton.InputState inputState3;
		if (inputState3 == GUITransactionButton.InputState.Clicked)
		{
			this._controllerInput.UpdateScroll();
		}
		ControllerMappingsCategories_Layout.Category selected5 = this.Selected;
		GUITransactionButton.InputState inputState4;
		if (inputState4 == GUITransactionButton.InputState.Clicked)
		{
			this._controllerInput.UpdateScroll();
		}
		ControllerMappingsCategories_Layout.Category selected6 = this.Selected;
		GUITransactionButton.InputState inputState5;
		if (inputState5 == GUITransactionButton.InputState.Clicked)
		{
			this._controllerInput.UpdateScroll();
		}
		ControllerMappingsCategories_Layout.Category selected7 = this.Selected;
		GUITransactionButton.InputState inputState6;
		if (inputState6 == GUITransactionButton.InputState.Clicked)
		{
			this._controllerInput.UpdateScroll();
		}
		ControllerMappingsCategories_Layout.Category selected8 = this.Selected;
		GUITransactionButton.InputState inputState7;
		if (inputState7 == GUITransactionButton.InputState.Clicked)
		{
			this._controllerInput.UpdateScroll();
		}
		ControllerMappingsCategories_Layout.Category selected9 = this.Selected;
		GUITransactionButton.InputState inputState8;
		if (inputState8 == GUITransactionButton.InputState.Clicked)
		{
			this._controllerInput.UpdateScroll();
		}
		ControllerMappingsCategories_Layout.Category selected10 = this.Selected;
		GUITransactionButton.InputState inputState9;
		if (inputState9 == GUITransactionButton.InputState.Clicked)
		{
			this._controllerInput.UpdateScroll();
		}
		ControllerMappingsCategories_Layout.Category selected11 = this.Selected;
		GUITransactionButton.InputState inputState10;
		if (inputState10 == GUITransactionButton.InputState.Clicked)
		{
			this._controllerInput.UpdateScroll();
		}
		float timeSinceItemChange = this.TimeSinceItemChange;
		float deltaTime = Time.deltaTime;
		GUIInputRegionExclusive categoriesBlocker = this._categoriesBlocker;
		if (categoriesBlocker != null)
		{
			int num2 = 1;
			categoriesBlocker.Active = num2 != 0;
		}
	}

	// Token: 0x06000295 RID: 661 RVA: 0x00007C68 File Offset: 0x00005E68
	public void Close()
	{
	}

	// Token: 0x06000296 RID: 662 RVA: 0x00007C78 File Offset: 0x00005E78
	private void DrawMainButtons()
	{
		bool mouseLeft = Main.mouseLeft;
		bool mouseLeftRelease = Main.mouseLeftRelease;
		GUIControllerMappingEntryBase guicontrollerMappingEntryBase = this._controllerInput._overlayEntry;
		int num = 1;
		GUITransactionButton.InputState inputState;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
			if (num == 0)
			{
			}
			Main.mouseLeftRelease = false;
		}
		if (guicontrollerMappingEntryBase == null)
		{
		}
		GUIControllerMappingEntryBase guicontrollerMappingEntryBase2 = this._controllerInput._overlayEntry;
		int num2 = 1;
		GUITransactionButton.InputState inputState2;
		if (inputState2 == GUITransactionButton.InputState.Clicked)
		{
			if (num2 == 0)
			{
			}
			Main.mouseLeftRelease = false;
			this.RestoreBackup();
		}
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		GUIControllerMappingOverlay controllerInput = this._controllerInput;
		GUIControllerMappingOverlay.Controls selectedControl = controllerInput.selectedControl;
		List<GUIControllerMappingEntryBase> categorySettings = this._categorySettings;
		int selectedItem = controllerInput._selectedItem;
		int size = categorySettings._size;
		if (categorySettings != null)
		{
			int num3 = 1;
			GUIControllerMappingEntryBase guicontrollerMappingEntryBase3 = this._controllerInput._overlayEntry;
			if (guicontrollerMappingEntryBase3 != null)
			{
				return;
			}
			GUISettingID id = guicontrollerMappingEntryBase3._id;
			GUITransactionButton.InputState inputState3;
			if (inputState3 == GUITransactionButton.InputState.Clicked)
			{
				if (num3 == 0)
				{
				}
				Main.mouseLeftRelease = false;
				this.ClearMapping();
				this.RefreshConfigurationState();
			}
		}
		bool anyControllerConnected2 = ControllerActionManager.AnyControllerConnected;
		GUIControllerMappingOverlay controllerInput2 = this._controllerInput;
		GUIControllerMappingOverlay.Controls selectedControl2 = controllerInput2.selectedControl;
		List<GUIControllerMappingEntryBase> categorySettings2 = this._categorySettings;
		int selectedItem2 = controllerInput2._selectedItem;
		int size2 = categorySettings2._size;
		if (controllerInput2._overlayEntry != null)
		{
			return;
		}
		while (categorySettings2 == null)
		{
		}
	}

	// Token: 0x06000297 RID: 663 RVA: 0x00007D98 File Offset: 0x00005F98
	private void DrawTitle()
	{
		string textValue = Language.GetTextValue("GameUI.ControllerMappingsMenu");
		ControllerMappingsCategories_Layout.Category selected = this.Selected;
	}

	// Token: 0x06000298 RID: 664 RVA: 0x00007DE8 File Offset: 0x00005FE8
	private void DrawBacking()
	{
	}

	// Token: 0x06000299 RID: 665 RVA: 0x00007DF8 File Offset: 0x00005FF8
	private void DrawCategoryOptions()
	{
		int size = this._categorySettings._size;
		int num = this.disableScroll;
	}

	// Token: 0x0600029A RID: 666 RVA: 0x000021DB File Offset: 0x000003DB
	private float SettingScale(int index)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x0600029B RID: 667 RVA: 0x00007E18 File Offset: 0x00006018
	private void SettingOver(int index)
	{
	}

	// Token: 0x0600029C RID: 668 RVA: 0x00007E28 File Offset: 0x00006028
	private void SettingDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		List<GUIControllerMappingEntryBase> categorySettings = this._categorySettings;
		List<GUIControllerMappingEntryBase> categorySettings2 = this._categorySettings;
	}

	// Token: 0x0600029D RID: 669 RVA: 0x00007E44 File Offset: 0x00006044
	private Microsoft.Xna.Framework.Vector2 SettingSize(int index)
	{
		/*
An exception occurred when decompiling this method (0600029D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 GUIControllerMappings::SettingSize(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.List`1<class GUIControllerMappingEntryBase>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIControllerMappingEntryBase>(GUIControllerMappings::_categorySettings, ldloc:GUIControllerMappings(this)))
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

	// Token: 0x0600029E RID: 670 RVA: 0x000021DB File Offset: 0x000003DB
	public void SetCategory(ControllerMappingsCategories_Layout.Category category)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x0600029F RID: 671 RVA: 0x000021DB File Offset: 0x000003DB
	public void RefreshConfigurationState()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060002A0 RID: 672 RVA: 0x00007E58 File Offset: 0x00006058
	public VirtualControllerInputState.CursorInputMode GetMode(Preferences preferences, string id, VirtualControllerInputState.CursorInputMode defaultValue)
	{
	}

	// Token: 0x060002A1 RID: 673 RVA: 0x00007E68 File Offset: 0x00006068
	public void LoadConfiguration(Preferences preferences, bool existingConfiguration)
	{
		bool flag;
		ControllerDevice.SwapBumpersTriggers = flag;
		GUIControllerMappingStateTable worldShared = this.WorldShared;
		List<ControllerActionButton> worldButtonMappings = this.WorldButtonMappings;
		List<ControllerActionAxis> worldAxisTable = this.WorldAxisTable;
		GUIControllerMappingStateTable worldInteractFallback = this.WorldInteractFallback;
		List<ControllerActionButton> worldButtonMappings2 = this.WorldButtonMappings;
		List<ControllerActionAxis> worldAxisTable2 = this.WorldAxisTable;
		GUIControllerMappingStateTable worldInteract = this.WorldInteract;
		List<ControllerActionButton> worldButtonMappings3 = this.WorldButtonMappings;
		List<ControllerActionAxis> worldAxisTable3 = this.WorldAxisTable;
		GUIControllerMappingStateTable world = this.World;
		List<ControllerActionButton> worldButtonMappings4 = this.WorldButtonMappings;
		List<ControllerActionAxis> worldAxisTable4 = this.WorldAxisTable;
		GUIControllerMappingStateTable world2 = this.World;
		ControllerActionButton interact = this.Interact;
		GUIControllerMappingStateTable worldInteract2 = this.WorldInteract;
		world2.TransferMapping(interact, worldInteract2);
		GUIControllerMappingStateTable world3 = this.World;
		ControllerActionButton fire = this.Fire;
		GUIControllerMappingStateTable worldInteractFallback2 = this.WorldInteractFallback;
		world3.TransferMapping(fire, worldInteractFallback2);
		GUIControllerMappingStateTable world4 = this.World;
		ControllerActionButton fireAlt = this.FireAlt;
		GUIControllerMappingStateTable worldInteractFallback3 = this.WorldInteractFallback;
		world4.TransferMapping(fireAlt, worldInteractFallback3);
		GUIControllerMappingStateTable world5 = this.World;
		ControllerActionButton grappleFire = this.GrappleFire;
		GUIControllerMappingStateTable worldInteractFallback4 = this.WorldInteractFallback;
		long num = 0L;
		world5.TransferMapping(grappleFire, worldInteractFallback4);
		GUIControllerMappingStateTable baseInventory = this.BaseInventory;
		List<ControllerActionButton> baseInventoryTable = this.BaseInventoryTable;
		List<ControllerActionAxis> inventoryAxisTable = this.InventoryAxisTable;
		baseInventory.LoadConfiguration("BaseInventoryControls", preferences, num != 0L, baseInventoryTable, inventoryAxisTable);
		GUIControllerMappingStateTable inventory = this.Inventory;
		List<ControllerActionButton> inventoryTable = this.InventoryTable;
		List<ControllerActionAxis> axisTableEmpty = this.AxisTableEmpty;
		inventory.LoadConfiguration("InventoryControls", preferences, num != 0L, inventoryTable, axisTableEmpty);
		GUIControllerMappingStateTable equipment = this.Equipment;
		List<ControllerActionButton> equipmentTable = this.EquipmentTable;
		List<ControllerActionAxis> axisTableEmpty2 = this.AxisTableEmpty;
		equipment.LoadConfiguration("EquipmentControls", preferences, num != 0L, equipmentTable, axisTableEmpty2);
		GUIControllerMappingStateTable pvp = this.PVP;
		List<ControllerActionButton> pvptable = this.PVPTable;
		List<ControllerActionAxis> axisTableEmpty3 = this.AxisTableEmpty;
		pvp.LoadConfiguration("PVPControls", preferences, num != 0L, pvptable, axisTableEmpty3);
		GUIControllerMappingStateTable itemHeld = this.ItemHeld;
		List<ControllerActionButton> itemHeldTable = this.ItemHeldTable;
		List<ControllerActionAxis> axisTableEmpty4 = this.AxisTableEmpty;
		itemHeld.LoadConfiguration("ItemHeldControls", preferences, num != 0L, itemHeldTable, axisTableEmpty4);
		GUIControllerMappingStateTable chestInv = this.ChestInv;
		List<ControllerActionButton> chestInvTable = this.ChestInvTable;
		List<ControllerActionAxis> axisTableEmpty5 = this.AxisTableEmpty;
		chestInv.LoadConfiguration("ChestInvControls", preferences, num != 0L, chestInvTable, axisTableEmpty5);
		GUIControllerMappingStateTable chest = this.Chest;
		List<ControllerActionButton> chestTable = this.ChestTable;
		List<ControllerActionAxis> axisTableEmpty6 = this.AxisTableEmpty;
		chest.LoadConfiguration("ChestControls", preferences, num != 0L, chestTable, axisTableEmpty6);
		GUIControllerMappingStateTable shopInv = this.ShopInv;
		List<ControllerActionButton> shopInvTable = this.ShopInvTable;
		List<ControllerActionAxis> axisTableEmpty7 = this.AxisTableEmpty;
		shopInv.LoadConfiguration("ShopInvControls", preferences, num != 0L, shopInvTable, axisTableEmpty7);
		GUIControllerMappingStateTable shop = this.Shop;
		List<ControllerActionButton> shopTable = this.ShopTable;
		List<ControllerActionAxis> axisTableEmpty8 = this.AxisTableEmpty;
		shop.LoadConfiguration("ShopControls", preferences, num != 0L, shopTable, axisTableEmpty8);
		GUIControllerMappingStateTable crafting = this.Crafting;
		List<ControllerActionButton> craftingTable = this.CraftingTable;
		List<ControllerActionAxis> axisTableEmpty9 = this.AxisTableEmpty;
		crafting.LoadConfiguration("CraftingControls", preferences, num != 0L, craftingTable, axisTableEmpty9);
		GUIControllerMappingStateTable reforge = this.Reforge;
		List<ControllerActionButton> reforgeTable = this.ReforgeTable;
		List<ControllerActionAxis> axisTableEmpty10 = this.AxisTableEmpty;
		reforge.LoadConfiguration("ReforgeControls", preferences, num != 0L, reforgeTable, axisTableEmpty10);
		GUIControllerMappingStateTable housing = this.Housing;
		List<ControllerActionButton> housingTable = this.HousingTable;
		List<ControllerActionAxis> axisTableEmpty11 = this.AxisTableEmpty;
		housing.LoadConfiguration("HousingControls", preferences, num != 0L, housingTable, axisTableEmpty11);
		GUIControllerMappingStateTable chat = this.Chat;
		List<ControllerActionButton> chatTable = this.ChatTable;
		List<ControllerActionAxis> axisTableEmpty12 = this.AxisTableEmpty;
		chat.LoadConfiguration("ChatControls", preferences, num != 0L, chatTable, axisTableEmpty12);
		if ("ChatControls" != null)
		{
			this.RefreshConfigurationState();
			return;
		}
	}

	// Token: 0x060002A2 RID: 674 RVA: 0x000081B4 File Offset: 0x000063B4
	public GUIControllerMappingScheme GetDefaultScheme(GUIControllerMappings.MappingType mappingType)
	{
		/*
An exception occurred when decompiling this method (060002A2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerMappingScheme GUIControllerMappings::GetDefaultScheme(GUIControllerMappings/MappingType)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_0B, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIControllerMappingScheme>[exp:List`1](GUIControllerMappings::Schemes, ldloc:GUIControllerMappings(this))))
	stloc:int32(var_2_19, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIControllerMappingScheme>[exp:List`1](GUIControllerMappings::Schemes, ldloc:GUIControllerMappings(this))))
	stloc:class [mscorlib]System.Collections.Generic.List`1<class GUIControllerMappingScheme>(var_4_22, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIControllerMappingScheme>(GUIControllerMappings::Schemes, ldloc:GUIControllerMappings(this)))
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

	// Token: 0x060002A3 RID: 675 RVA: 0x000081E4 File Offset: 0x000063E4
	public void SetMapping(GUIControllerMappings.MappingType mappingType)
	{
		this.mapping = mappingType;
		GUIControllerMappingScheme defaultScheme = this.GetDefaultScheme(mappingType);
		if (defaultScheme != null)
		{
			this.World.ClearMappings();
			this.BaseInventory.ClearMappings();
			GUIControllerMappingStateTable world = this.World;
			GUIControllerMappingStateTable worldMappings = defaultScheme.WorldMappings;
			world.Copy(worldMappings);
			GUIControllerMappingStateTable worldShared = this.WorldShared;
			GUIControllerMappingStateTable worldSharedMappings = defaultScheme.WorldSharedMappings;
			worldShared.Copy(worldSharedMappings);
			GUIControllerMappingStateTable worldInteract = this.WorldInteract;
			GUIControllerMappingStateTable worldInteractMappings = defaultScheme.WorldInteractMappings;
			worldInteract.Copy(worldInteractMappings);
			GUIControllerMappingStateTable worldInteractFallback = this.WorldInteractFallback;
			GUIControllerMappingStateTable worldInteractFallbackMappings = defaultScheme.WorldInteractFallbackMappings;
			worldInteractFallback.Copy(worldInteractFallbackMappings);
			GUIControllerMappingStateTable baseInventory = this.BaseInventory;
			GUIControllerMappingStateTable baseInventoryMappings = defaultScheme.BaseInventoryMappings;
			baseInventory.Copy(baseInventoryMappings);
			GUIControllerMappingStateTable inventory = this.Inventory;
			GUIControllerMappingStateTable inventoryMappings = defaultScheme.InventoryMappings;
			inventory.Copy(inventoryMappings);
			GUIControllerMappingStateTable pvp = this.PVP;
			GUIControllerMappingStateTable pvpmappings = defaultScheme.PVPMappings;
			pvp.Copy(pvpmappings);
			GUIControllerMappingStateTable housing = this.Housing;
			GUIControllerMappingStateTable housingMappings = defaultScheme.HousingMappings;
			housing.Copy(housingMappings);
			GUIControllerMappingStateTable itemHeld = this.ItemHeld;
			GUIControllerMappingStateTable heldMappings = defaultScheme.HeldMappings;
			itemHeld.Copy(heldMappings);
			GUIControllerMappingStateTable equipment = this.Equipment;
			GUIControllerMappingStateTable equipmentMappings = defaultScheme.EquipmentMappings;
			equipment.Copy(equipmentMappings);
			GUIControllerMappingStateTable chestInv = this.ChestInv;
			GUIControllerMappingStateTable chestInvMappings = defaultScheme.ChestInvMappings;
			chestInv.Copy(chestInvMappings);
			GUIControllerMappingStateTable chest = this.Chest;
			GUIControllerMappingStateTable chestMappings = defaultScheme.ChestMappings;
			chest.Copy(chestMappings);
			GUIControllerMappingStateTable shopInv = this.ShopInv;
			GUIControllerMappingStateTable shopInvMappings = defaultScheme.ShopInvMappings;
			shopInv.Copy(shopInvMappings);
			GUIControllerMappingStateTable shop = this.Shop;
			GUIControllerMappingStateTable shopMappings = defaultScheme.ShopMappings;
			shop.Copy(shopMappings);
			GUIControllerMappingStateTable crafting = this.Crafting;
			GUIControllerMappingStateTable craftingMappings = defaultScheme.CraftingMappings;
			crafting.Copy(craftingMappings);
			GUIControllerMappingStateTable reforge = this.Reforge;
			GUIControllerMappingStateTable reforgeMappings = defaultScheme.ReforgeMappings;
			reforge.Copy(reforgeMappings);
			GUIControllerMappingStateTable chat = this.Chat;
			GUIControllerMappingStateTable chatMappings = defaultScheme.ChatMappings;
			chat.Copy(chatMappings);
			this.LoadMappingValues();
			return;
		}
	}

	// Token: 0x060002A4 RID: 676 RVA: 0x000083C8 File Offset: 0x000065C8
	private void SetupUIMappingState(ControllerActionButton buttonMapping)
	{
		Buttons button = buttonMapping.FirstEntry.Button;
		bool flag = this.BaseInventory.IsAnyLeftButtonConflict(button);
	}

	// Token: 0x060002A5 RID: 677 RVA: 0x00008460 File Offset: 0x00006660
	private void SetupWorldUIMappingState(ControllerActionButton buttonMapping)
	{
		Buttons button = buttonMapping.FirstEntry.Button;
		bool flag = this.World.IsAnyLeftButtonConflict(button);
		bool flag2 = this.World.IsAnyRightButtonConflict(button);
		ControllerActionButton.Entry firstEntry = buttonMapping.FirstEntry;
		ControllerActionButton.RequiredButtonState requiredButtonState = this.noModifiers;
	}

	// Token: 0x060002A6 RID: 678 RVA: 0x0000851C File Offset: 0x0000671C
	public void UpdateUIInteractionOverloads(GUIControllerMappings.InteractionOverloadState newInteractionOverloadState)
	{
		GUIControllerMappings.InteractionOverloadState interactionOverloadState = this.interactionOverloadState;
		if (newInteractionOverloadState == GUIControllerMappings.InteractionOverloadState.None || interactionOverloadState != GUIControllerMappings.InteractionOverloadState.None)
		{
		}
		this.interactionOverloadState = newInteractionOverloadState;
		if (newInteractionOverloadState != GUIControllerMappings.InteractionOverloadState.None)
		{
			GUIControllerMappingStateTable world = this.World;
			GUIControllerMappingStateTable baseInventory = this.BaseInventory;
			world.DisableConflictingActions(baseInventory, true);
			GUIControllerMappingStateTable worldShared = this.WorldShared;
			GUIControllerMappingStateTable baseInventory2 = this.BaseInventory;
			worldShared.DisableConflictingActions(baseInventory2, true);
			GUIControllerMappingStateTable worldInteract = this.WorldInteract;
			GUIControllerMappingStateTable baseInventory3 = this.BaseInventory;
			worldInteract.DisableConflictingActions(baseInventory3, true);
			GUIControllerMappingStateTable worldInteractFallback = this.WorldInteractFallback;
			GUIControllerMappingStateTable baseInventory4 = this.BaseInventory;
			worldInteractFallback.DisableConflictingActions(baseInventory4, true);
			GUIControllerMappingStateTable world2 = this.World;
			GUIControllerMappingStateTable baseInventory5 = this.BaseInventory;
			world2.Normal.SetupWorldRequiredStateOverloads(baseInventory5);
			GUIControllerMappingStateTable worldShared2 = this.WorldShared;
			GUIControllerMappingStateTable baseInventory6 = this.BaseInventory;
			worldShared2.Normal.SetupWorldRequiredStateOverloads(baseInventory6);
			GUIControllerMappingStateTable worldInteract2 = this.WorldInteract;
			GUIControllerMappingStateTable baseInventory7 = this.BaseInventory;
			worldInteract2.Normal.SetupWorldRequiredStateOverloads(baseInventory7);
			GUIControllerMappingStateTable worldInteractFallback2 = this.WorldInteractFallback;
			GUIControllerMappingStateTable baseInventory8 = this.BaseInventory;
			worldInteractFallback2.Normal.SetupWorldRequiredStateOverloads(baseInventory8);
			worldInteractFallback2.Left = 1;
			List<ControllerActionVector> inventoryAxisMappings = this.InventoryAxisMappings;
			List<ControllerActionButton> inventoryButtonMappings = this.InventoryButtonMappings;
			return;
		}
		List<ControllerActionVector> worldAxisMappings = this.WorldAxisMappings;
	}

	// Token: 0x060002A7 RID: 679 RVA: 0x000021DB File Offset: 0x000003DB
	public void SetupMappings()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060002A8 RID: 680 RVA: 0x000086E8 File Offset: 0x000068E8
	public void LoadMappingValues()
	{
		this.ClearWorldMappings();
		this.ClearInventoryMappings();
		this.World.LoadMappingValues();
		this.BaseInventory.LoadMappingValues();
	}

	// Token: 0x060002A9 RID: 681 RVA: 0x00008718 File Offset: 0x00006918
	public void SaveConfiguration(Preferences preferences)
	{
		bool swapBumpersTriggers = ControllerDevice.SwapBumpersTriggers;
		this.World.SaveConfiguration("Controls", preferences);
		this.WorldShared.SaveConfiguration("SharedControls", preferences);
		this.WorldInteract.SaveConfiguration("InteractionControls", preferences);
		this.WorldInteractFallback.SaveConfiguration("InteractionFallbackControls", preferences);
		this.BaseInventory.SaveConfiguration("BaseInventoryControls", preferences);
		this.Inventory.SaveConfiguration("InventoryControls", preferences);
		this.Equipment.SaveConfiguration("EquipmentControls", preferences);
		this.PVP.SaveConfiguration("PVPControls", preferences);
		this.ItemHeld.SaveConfiguration("ItemHeldControls", preferences);
		this.ChestInv.SaveConfiguration("ChestInvControls", preferences);
		this.Chest.SaveConfiguration("ChestControls", preferences);
		this.ShopInv.SaveConfiguration("ShopInvControls", preferences);
		this.Shop.SaveConfiguration("ShopControls", preferences);
		this.Crafting.SaveConfiguration("CraftingControls", preferences);
		this.Reforge.SaveConfiguration("ReforgeControls", preferences);
		this.Housing.SaveConfiguration("HousingControls", preferences);
		this.Chat.SaveConfiguration("ChatControls", preferences);
	}

	// Token: 0x060002AA RID: 682 RVA: 0x00008850 File Offset: 0x00006A50
	public GUIControllerMappings()
	{
	}

	// Token: 0x04000243 RID: 579
	public bool Enabled;

	// Token: 0x04000244 RID: 580
	public GUIControllerMappings.MappingType mapping;

	// Token: 0x04000245 RID: 581
	private VirtualControllerInputState.CursorInputMode BackupControllerAimAndUse;

	// Token: 0x04000246 RID: 582
	private VirtualControllerInputState.CursorInputMode BackupControllerSmartCursor;

	// Token: 0x04000247 RID: 583
	private bool BackupSwapBumpersTriggers;

	// Token: 0x04000248 RID: 584
	private float BackupNavigationDelay;

	// Token: 0x04000249 RID: 585
	private float BackupControllerAimSensitivity;

	// Token: 0x0400024A RID: 586
	private GUIControllerMappingEntryBase overlayEntry;

	// Token: 0x0400024B RID: 587
	private Rectangle overlayRegion;

	// Token: 0x0400024C RID: 588
	public bool performingBinding;

	// Token: 0x0400024D RID: 589
	private int disableScroll;

	// Token: 0x0400024E RID: 590
	private bool hasFocus;

	// Token: 0x0400024F RID: 591
	private GUIInputRegionExclusive _categoriesBlocker;

	// Token: 0x04000250 RID: 592
	private float TimeSinceItemChange;

	// Token: 0x04000251 RID: 593
	private ControllerMappingsCategories_Layout.Category[] TabOrder;

	// Token: 0x04000252 RID: 594
	public ControllerMappingsCategories_Layout.Category Selected;

	// Token: 0x04000253 RID: 595
	private float GameplayButtonScale;

	// Token: 0x04000254 RID: 596
	private float UIButtonScale;

	// Token: 0x04000255 RID: 597
	private float SaveAndCloseButtonScale;

	// Token: 0x04000256 RID: 598
	private float ResetSettingsButtonScale;

	// Token: 0x04000257 RID: 599
	private float titleScale;

	// Token: 0x04000258 RID: 600
	public float ScrollOffset;

	// Token: 0x04000259 RID: 601
	private float ScrollMomentum;

	// Token: 0x0400025A RID: 602
	private int ScrollDragging;

	// Token: 0x0400025B RID: 603
	private Microsoft.Xna.Framework.Vector2 DragOffset;

	// Token: 0x0400025C RID: 604
	public List<GUIControllerMappingEntryBase> _allSettings;

	// Token: 0x0400025D RID: 605
	public List<GUIControllerMappingEntryBase> _categorySettings;

	// Token: 0x0400025E RID: 606
	public GUIControllerMappings.InteractionOverloadState interactionOverloadState;

	// Token: 0x0400025F RID: 607
	private ControllerActionButton.RequiredButtonState noModifiers;

	// Token: 0x04000260 RID: 608
	private ControllerActionButton.RequiredButtonState noLeftModifiers;

	// Token: 0x04000261 RID: 609
	private ControllerActionButton.RequiredButtonState noRightModifiers;

	// Token: 0x04000262 RID: 610
	private List<GUIControllerMappingScheme> Schemes;

	// Token: 0x04000263 RID: 611
	public GUIControllerMappingOverlay _controllerInput;

	// Token: 0x04000264 RID: 612
	public List<ControllerActionAxis> WorldAxisTable;

	// Token: 0x04000265 RID: 613
	public List<ControllerActionVector> WorldAxisMappings;

	// Token: 0x04000266 RID: 614
	public List<ControllerActionButton> WorldButtonMappings;

	// Token: 0x04000267 RID: 615
	public List<ControllerActionVector> InventoryAxisMappings;

	// Token: 0x04000268 RID: 616
	public List<ControllerActionAxis> InventoryAxisTable;

	// Token: 0x04000269 RID: 617
	public List<ControllerActionButton> InventoryButtonMappings;

	// Token: 0x0400026A RID: 618
	public List<ControllerActionButton> BaseInventoryTable;

	// Token: 0x0400026B RID: 619
	public List<ControllerActionButton> InventoryTable;

	// Token: 0x0400026C RID: 620
	public List<ControllerActionButton> EquipmentTable;

	// Token: 0x0400026D RID: 621
	public List<ControllerActionButton> ItemHeldTable;

	// Token: 0x0400026E RID: 622
	public List<ControllerActionButton> ChestInvTable;

	// Token: 0x0400026F RID: 623
	public List<ControllerActionButton> ChestTable;

	// Token: 0x04000270 RID: 624
	public List<ControllerActionButton> ShopTable;

	// Token: 0x04000271 RID: 625
	public List<ControllerActionButton> ShopInvTable;

	// Token: 0x04000272 RID: 626
	public List<ControllerActionButton> CraftingTable;

	// Token: 0x04000273 RID: 627
	public List<ControllerActionButton> PVPTable;

	// Token: 0x04000274 RID: 628
	public List<ControllerActionButton> HousingTable;

	// Token: 0x04000275 RID: 629
	public List<ControllerActionButton> ReforgeTable;

	// Token: 0x04000276 RID: 630
	public List<ControllerActionButton> ChatTable;

	// Token: 0x04000277 RID: 631
	public List<ControllerActionAxis> AxisTableEmpty;

	// Token: 0x04000278 RID: 632
	public ControllerActionAxis MovementAxisX;

	// Token: 0x04000279 RID: 633
	public ControllerActionAxis MovementAxisY;

	// Token: 0x0400027A RID: 634
	public ControllerActionVector MovementAxis;

	// Token: 0x0400027B RID: 635
	public ControllerActionAxis MapAxisX;

	// Token: 0x0400027C RID: 636
	public ControllerActionAxis MapAxisY;

	// Token: 0x0400027D RID: 637
	public ControllerActionVector MapAxis;

	// Token: 0x0400027E RID: 638
	public ControllerActionAxis MovementAxisAltX;

	// Token: 0x0400027F RID: 639
	public ControllerActionAxis MovementAxisAltY;

	// Token: 0x04000280 RID: 640
	public ControllerActionVector MovementAxisAlt;

	// Token: 0x04000281 RID: 641
	public ControllerActionAxis FireAxisX;

	// Token: 0x04000282 RID: 642
	public ControllerActionAxis FireAxisY;

	// Token: 0x04000283 RID: 643
	public ControllerActionVector FireAxis;

	// Token: 0x04000284 RID: 644
	public ControllerActionAxis FireAxisAltX;

	// Token: 0x04000285 RID: 645
	public ControllerActionAxis FireAxisAltY;

	// Token: 0x04000286 RID: 646
	public ControllerActionVector FireAxisAlt;

	// Token: 0x04000287 RID: 647
	public ControllerActionAxis GrappleAxisX;

	// Token: 0x04000288 RID: 648
	public ControllerActionAxis GrappleAxisY;

	// Token: 0x04000289 RID: 649
	public ControllerActionVector GrappleAxis;

	// Token: 0x0400028A RID: 650
	public ControllerActionButton GrappleFire;

	// Token: 0x0400028B RID: 651
	public ControllerActionButton Jump;

	// Token: 0x0400028C RID: 652
	public ControllerActionButton Fire;

	// Token: 0x0400028D RID: 653
	public ControllerActionButton Interact;

	// Token: 0x0400028E RID: 654
	public ControllerActionButton TargetLockOn;

	// Token: 0x0400028F RID: 655
	public ControllerActionButton InventoryToggle;

	// Token: 0x04000290 RID: 656
	public ControllerActionButton AutoSelect;

	// Token: 0x04000291 RID: 657
	public ControllerActionButton SmartCursor;

	// Token: 0x04000292 RID: 658
	public ControllerActionButton AutoFire;

	// Token: 0x04000293 RID: 659
	public ControllerActionButton HotbarNext;

	// Token: 0x04000294 RID: 660
	public ControllerActionButton HotbarPrevious;

	// Token: 0x04000295 RID: 661
	public ControllerActionButton FireAlt;

	// Token: 0x04000296 RID: 662
	public ControllerActionAxis GridSnapAxisX;

	// Token: 0x04000297 RID: 663
	public ControllerActionAxis GridSnapAxisY;

	// Token: 0x04000298 RID: 664
	public ControllerActionVector GridSnapAxis;

	// Token: 0x04000299 RID: 665
	public ControllerActionButton BuffNext;

	// Token: 0x0400029A RID: 666
	public ControllerActionButton BuffPrevious;

	// Token: 0x0400029B RID: 667
	public ControllerActionButton BuffRemove;

	// Token: 0x0400029C RID: 668
	public ControllerActionAxis HotbarAxisX;

	// Token: 0x0400029D RID: 669
	public ControllerActionAxis HotbarAxisY;

	// Token: 0x0400029E RID: 670
	public ControllerActionVector HotbarAxis;

	// Token: 0x0400029F RID: 671
	public ControllerActionButton ZoomIn;

	// Token: 0x040002A0 RID: 672
	public ControllerActionButton ZoomOut;

	// Token: 0x040002A1 RID: 673
	public ControllerActionButton MapZoomIn;

	// Token: 0x040002A2 RID: 674
	public ControllerActionButton MapZoomOut;

	// Token: 0x040002A3 RID: 675
	public ControllerActionButton MapZoomDefault;

	// Token: 0x040002A4 RID: 676
	public ControllerActionButton QuickMount;

	// Token: 0x040002A5 RID: 677
	public ControllerActionButton QuickHeal;

	// Token: 0x040002A6 RID: 678
	public ControllerActionButton QuickBuff;

	// Token: 0x040002A7 RID: 679
	public ControllerActionButton QuickMana;

	// Token: 0x040002A8 RID: 680
	public ControllerActionButton MapToggle;

	// Token: 0x040002A9 RID: 681
	public ControllerActionButton MiniMapToggle;

	// Token: 0x040002AA RID: 682
	public ControllerActionButton ChatToggle;

	// Token: 0x040002AB RID: 683
	public ControllerActionButton Hotbar1;

	// Token: 0x040002AC RID: 684
	public ControllerActionButton Hotbar2;

	// Token: 0x040002AD RID: 685
	public ControllerActionButton Hotbar3;

	// Token: 0x040002AE RID: 686
	public ControllerActionButton Hotbar4;

	// Token: 0x040002AF RID: 687
	public ControllerActionButton Hotbar5;

	// Token: 0x040002B0 RID: 688
	public ControllerActionButton Hotbar6;

	// Token: 0x040002B1 RID: 689
	public ControllerActionButton Hotbar7;

	// Token: 0x040002B2 RID: 690
	public ControllerActionButton Hotbar8;

	// Token: 0x040002B3 RID: 691
	public ControllerActionButton Hotbar9;

	// Token: 0x040002B4 RID: 692
	public ControllerActionButton Hotbar10;

	// Token: 0x040002B5 RID: 693
	public ControllerActionButton DynamicHotbar1;

	// Token: 0x040002B6 RID: 694
	public ControllerActionButton DynamicHotbar2;

	// Token: 0x040002B7 RID: 695
	public ControllerActionButton DynamicHotbar3;

	// Token: 0x040002B8 RID: 696
	public ControllerActionButton DynamicHotbar4;

	// Token: 0x040002B9 RID: 697
	public ControllerActionButton Loadout1;

	// Token: 0x040002BA RID: 698
	public ControllerActionButton Loadout2;

	// Token: 0x040002BB RID: 699
	public ControllerActionButton Loadout3;

	// Token: 0x040002BC RID: 700
	public ControllerActionButton LoadoutCycle;

	// Token: 0x040002BD RID: 701
	public ControllerActionAxis InventoryNavigationX;

	// Token: 0x040002BE RID: 702
	public ControllerActionAxis InventoryNavigationY;

	// Token: 0x040002BF RID: 703
	public ControllerActionVector InventoryNavigation;

	// Token: 0x040002C0 RID: 704
	public ControllerActionAxis InventoryNavigationAltX;

	// Token: 0x040002C1 RID: 705
	public ControllerActionAxis InventoryNavigationAltY;

	// Token: 0x040002C2 RID: 706
	public ControllerActionVector InventoryNavigationAlt;

	// Token: 0x040002C3 RID: 707
	public ControllerActionButton WorldFocusToggle;

	// Token: 0x040002C4 RID: 708
	public ControllerActionButton LeftPageCycle;

	// Token: 0x040002C5 RID: 709
	public ControllerActionButton RightPageCycle;

	// Token: 0x040002C6 RID: 710
	public ControllerActionButton ThrowItem;

	// Token: 0x040002C7 RID: 711
	public ControllerActionButton TrashItem;

	// Token: 0x040002C8 RID: 712
	public ControllerActionButton DepositHeldItem;

	// Token: 0x040002C9 RID: 713
	public ControllerActionButton FavouriteItem;

	// Token: 0x040002CA RID: 714
	public ControllerActionButton ResearchItem;

	// Token: 0x040002CB RID: 715
	public ControllerActionButton SplitItem;

	// Token: 0x040002CC RID: 716
	public ControllerActionButton PickupPlaceItem;

	// Token: 0x040002CD RID: 717
	public ControllerActionButton CraftItem;

	// Token: 0x040002CE RID: 718
	public ControllerActionButton FilterItems;

	// Token: 0x040002CF RID: 719
	public ControllerActionButton ToggleCraftDuplicate;

	// Token: 0x040002D0 RID: 720
	public ControllerActionButton HousingQuery;

	// Token: 0x040002D1 RID: 721
	public ControllerActionButton Sort;

	// Token: 0x040002D2 RID: 722
	public ControllerActionButton BuilderTools;

	// Token: 0x040002D3 RID: 723
	public ControllerActionButton TakeOne;

	// Token: 0x040002D4 RID: 724
	public ControllerActionButton InventoryClose;

	// Token: 0x040002D5 RID: 725
	public ControllerActionButton ReforgeItem;

	// Token: 0x040002D6 RID: 726
	public ControllerActionButton ShowHideItem;

	// Token: 0x040002D7 RID: 727
	public ControllerActionButton InfoAccessories;

	// Token: 0x040002D8 RID: 728
	public ControllerActionButton ChestQuickStack;

	// Token: 0x040002D9 RID: 729
	public ControllerActionButton ChestLootAll;

	// Token: 0x040002DA RID: 730
	public ControllerActionButton ChestDepositAll;

	// Token: 0x040002DB RID: 731
	public ControllerActionButton ChestRestock;

	// Token: 0x040002DC RID: 732
	public ControllerActionButton ChestRename;

	// Token: 0x040002DD RID: 733
	public ControllerActionButton ChestLoot;

	// Token: 0x040002DE RID: 734
	public ControllerActionButton ChestDeposit;

	// Token: 0x040002DF RID: 735
	public ControllerActionButton ChestSort;

	// Token: 0x040002E0 RID: 736
	public ControllerActionButton EquipmentEquip;

	// Token: 0x040002E1 RID: 737
	public ControllerActionButton EquipmentUnequip;

	// Token: 0x040002E2 RID: 738
	public ControllerActionButton ShopSell;

	// Token: 0x040002E3 RID: 739
	public ControllerActionButton ShopBuy;

	// Token: 0x040002E4 RID: 740
	public ControllerActionButton PVPEnableToggle;

	// Token: 0x040002E5 RID: 741
	public ControllerActionButton PVPSwitchTeam;

	// Token: 0x040002E6 RID: 742
	public GUIControllerMappingStateTable WorldInteractFallback;

	// Token: 0x040002E7 RID: 743
	public GUIControllerMappingStateTable WorldInteract;

	// Token: 0x040002E8 RID: 744
	public GUIControllerMappingStateTable WorldShared;

	// Token: 0x040002E9 RID: 745
	public GUIControllerMappingStateTable World;

	// Token: 0x040002EA RID: 746
	public GUIControllerMappingStateTable BaseInventory;

	// Token: 0x040002EB RID: 747
	public GUIControllerMappingStateTable Inventory;

	// Token: 0x040002EC RID: 748
	public GUIControllerMappingStateTable Equipment;

	// Token: 0x040002ED RID: 749
	public GUIControllerMappingStateTable PVP;

	// Token: 0x040002EE RID: 750
	public GUIControllerMappingStateTable Housing;

	// Token: 0x040002EF RID: 751
	public GUIControllerMappingStateTable ItemHeld;

	// Token: 0x040002F0 RID: 752
	public GUIControllerMappingStateTable ChestInv;

	// Token: 0x040002F1 RID: 753
	public GUIControllerMappingStateTable Chest;

	// Token: 0x040002F2 RID: 754
	public GUIControllerMappingStateTable ShopInv;

	// Token: 0x040002F3 RID: 755
	public GUIControllerMappingStateTable Shop;

	// Token: 0x040002F4 RID: 756
	public GUIControllerMappingStateTable Crafting;

	// Token: 0x040002F5 RID: 757
	public GUIControllerMappingStateTable Reforge;

	// Token: 0x040002F6 RID: 758
	public GUIControllerMappingStateTable Chat;

	// Token: 0x02000076 RID: 118
	public enum MappingType
	{
		// Token: 0x040002F8 RID: 760
		Default,
		// Token: 0x040002F9 RID: 761
		Advanced,
		// Token: 0x040002FA RID: 762
		Console,
		// Token: 0x040002FB RID: 763
		Custom
	}

	// Token: 0x02000077 RID: 119
	public enum InteractionOverloadState
	{
		// Token: 0x040002FD RID: 765
		None,
		// Token: 0x040002FE RID: 766
		Inventory,
		// Token: 0x040002FF RID: 767
		NPC,
		// Token: 0x04000300 RID: 768
		NPCItem,
		// Token: 0x04000301 RID: 769
		Map
	}

	// Token: 0x02000078 RID: 120
	[CompilerGenerated]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060002AB RID: 683 RVA: 0x00008874 File Offset: 0x00006A74
		// Note: this type is marked as 'beforefieldinit'.
		static <>c()
		{
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00008884 File Offset: 0x00006A84
		public <>c()
		{
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00008898 File Offset: 0x00006A98
		internal int <SetCategory>b__49_0(GUIControllerMappingEntryBase e1, GUIControllerMappingEntryBase e2)
		{
			int sortOrder = e2.SortOrder;
			int num;
			return num;
		}

		// Token: 0x04000302 RID: 770
		public static readonly GUIControllerMappings.<>c <>9;

		// Token: 0x04000303 RID: 771
		public static Comparison<GUIControllerMappingEntryBase> <>9__49_0;
	}
}
