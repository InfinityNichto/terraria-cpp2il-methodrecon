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

// Token: 0x0200018A RID: 394
public class GUIKeyboardMappings
{
	// Token: 0x1700011E RID: 286
	// (get) Token: 0x06000B20 RID: 2848 RVA: 0x0003834C File Offset: 0x0003654C
	// (set) Token: 0x06000B21 RID: 2849 RVA: 0x00038360 File Offset: 0x00036560
	public bool KeyboardEnabled
	{
		get
		{
			return this._keyboardEnabled;
		}
		set
		{
		}
	}

	// Token: 0x06000B22 RID: 2850 RVA: 0x00038370 File Offset: 0x00036570
	public void RegisterOverlay(GUIKeyboardMappingEntry entry, Rectangle region)
	{
		this.overlayEntry = entry;
		this.overlayRegion = region;
		this.performingBinding = true;
		this.disableScroll = 2;
	}

	// Token: 0x06000B23 RID: 2851 RVA: 0x000021DB File Offset: 0x000003DB
	private ControllerActionButton CreateButtonMapping(string id)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x1700011F RID: 287
	// (get) Token: 0x06000B24 RID: 2852 RVA: 0x0003839C File Offset: 0x0003659C
	// (set) Token: 0x06000B25 RID: 2853 RVA: 0x000383B0 File Offset: 0x000365B0
	public bool EscapeOpensInventory
	{
		get
		{
			return this._escapeOpensInventory;
		}
		set
		{
			bool escapeOpensInventory = this._escapeOpensInventory;
		}
	}

	// Token: 0x06000B26 RID: 2854 RVA: 0x000383CC File Offset: 0x000365CC
	public void SetupEscapeKeySetting()
	{
		if (this._escapeOpensInventory)
		{
			ControllerActionButton inventoryToggle = this.InventoryToggle;
			int num = 1;
			ControllerActionButton.Entry entry = inventoryToggle.GetEntry(num);
			int num2 = 27;
			entry.InputKey = (KeyCode)num2;
			return;
		}
		ControllerActionButton settings = this.Settings;
		int num3 = 1;
		ControllerActionButton.Entry entry2 = settings.GetEntry(num3);
		int num4 = 27;
		entry2.InputKey = (KeyCode)num4;
	}

	// Token: 0x06000B27 RID: 2855 RVA: 0x00038424 File Offset: 0x00036624
	public void DisableEscapeKeyUsage()
	{
		bool escapeOpensInventory = this._escapeOpensInventory;
	}

	// Token: 0x06000B28 RID: 2856 RVA: 0x00038438 File Offset: 0x00036638
	public void SetupMappings()
	{
		ControllerActionAxis controllerActionAxis;
		this.MovementAxisX = controllerActionAxis;
		ControllerActionAxis movementAxisX = this.MovementAxisX;
		ControllerActionAxis controllerActionAxis2;
		this.MovementAxisY = controllerActionAxis2;
		ControllerActionAxis movementAxisY = this.MovementAxisY;
		ControllerActionAxis movementAxisX2 = this.MovementAxisX;
		ControllerActionAxis movementAxisY2 = this.MovementAxisY;
		ControllerActionVector controllerActionVector;
		this.MovementAxis = controllerActionVector;
		ControllerActionVector movementAxis = this.MovementAxis;
		ControllerActionVector controllerActionVector2;
		controllerActionVector2.LinkedAction = movementAxis;
		ControllerActionButton controllerActionButton = this.CreateButtonMapping("KeyboardGrappleFire");
		this.GrappleFire = controllerActionButton;
		ControllerActionButton controllerActionButton2 = this.CreateButtonMapping("KeyboardJump");
		this.Jump = controllerActionButton2;
		ControllerActionButton controllerActionButton3;
		this.Fire = controllerActionButton3;
		ControllerActionButton controllerActionButton4 = this.CreateButtonMapping("KeyboardInteract");
		this.Interact = controllerActionButton4;
		ControllerActionButton controllerActionButton5 = this.CreateButtonMapping("KeyboardTargetLockOn");
		this.TargetLockOn = controllerActionButton5;
		ControllerActionButton controllerActionButton6 = this.CreateButtonMapping("KeyboardInventoryToggle");
		this.InventoryToggle = controllerActionButton6;
		ControllerActionButton controllerActionButton7 = this.CreateButtonMapping("KeyboardAutoSelect");
		this.AutoSelect = controllerActionButton7;
		ControllerActionButton controllerActionButton8 = this.CreateButtonMapping("KeyboardSmartCursor");
		this.SmartCursor = controllerActionButton8;
		ControllerActionButton controllerActionButton9 = this.CreateButtonMapping("KeyboardZoomIn");
		this.ZoomIn = controllerActionButton9;
		ControllerActionButton controllerActionButton10 = this.CreateButtonMapping("KeyboardZoomOut");
		this.ZoomOut = controllerActionButton10;
		ControllerActionButton controllerActionButton11 = this.CreateButtonMapping("KeyboardMapZoomIn");
		this.MapZoomIn = controllerActionButton11;
		ControllerActionButton controllerActionButton12 = this.CreateButtonMapping("KeyboardMapZoomOut");
		this.MapZoomOut = controllerActionButton12;
		ControllerActionButton controllerActionButton13 = this.CreateButtonMapping("KeyboardMapZoomDefault");
		this.MapZoomDefault = controllerActionButton13;
		ControllerActionButton controllerActionButton14 = this.CreateButtonMapping("KeyboardQuickHeal");
		this.QuickHeal = controllerActionButton14;
		ControllerActionButton controllerActionButton15 = this.CreateButtonMapping("KeyboardQuickMana");
		this.QuickMana = controllerActionButton15;
		ControllerActionButton controllerActionButton16 = this.CreateButtonMapping("KeyboardQuickBuff");
		this.QuickBuff = controllerActionButton16;
		ControllerActionButton controllerActionButton17 = this.CreateButtonMapping("KeyboardQuickMount");
		this.QuickMount = controllerActionButton17;
		ControllerActionButton controllerActionButton18 = this.CreateButtonMapping("KeyboardMapToggle");
		this.MapToggle = controllerActionButton18;
		ControllerActionButton controllerActionButton19 = this.CreateButtonMapping("KeyboardMiniMapToggle");
		this.MiniMapToggle = controllerActionButton19;
		ControllerActionButton controllerActionButton20 = this.CreateButtonMapping("KeyboardChatToggle");
		this.ChatToggle = controllerActionButton20;
		ControllerActionButton controllerActionButton21 = this.CreateButtonMapping("KeyboardUISettings");
		this.Settings = controllerActionButton21;
		ControllerActionButton controllerActionButton22 = this.CreateButtonMapping("KeyboardHotbar1");
		this.Hotbar1 = controllerActionButton22;
		ControllerActionButton controllerActionButton23 = this.CreateButtonMapping("KeyboardHotbar2");
		this.Hotbar2 = controllerActionButton23;
		ControllerActionButton controllerActionButton24 = this.CreateButtonMapping("KeyboardHotbar3");
		this.Hotbar3 = controllerActionButton24;
		ControllerActionButton controllerActionButton25 = this.CreateButtonMapping("KeyboardHotbar4");
		this.Hotbar4 = controllerActionButton25;
		ControllerActionButton controllerActionButton26 = this.CreateButtonMapping("KeyboardHotbar5");
		this.Hotbar5 = controllerActionButton26;
		ControllerActionButton controllerActionButton27 = this.CreateButtonMapping("KeyboardHotbar6");
		this.Hotbar6 = controllerActionButton27;
		ControllerActionButton controllerActionButton28 = this.CreateButtonMapping("KeyboardHotbar7");
		this.Hotbar7 = controllerActionButton28;
		ControllerActionButton controllerActionButton29 = this.CreateButtonMapping("KeyboardHotbar8");
		this.Hotbar8 = controllerActionButton29;
		ControllerActionButton controllerActionButton30 = this.CreateButtonMapping("KeyboardHotbar9");
		this.Hotbar9 = controllerActionButton30;
		ControllerActionButton controllerActionButton31 = this.CreateButtonMapping("KeyboardHotbar10");
		this.Hotbar10 = controllerActionButton31;
		ControllerActionButton controllerActionButton32 = this.CreateButtonMapping("KeyboardHotbarNext");
		this.HotbarNext = controllerActionButton32;
		ControllerActionButton controllerActionButton33 = this.CreateButtonMapping("KeyboardHotbarPrevious");
		this.HotbarPrevious = controllerActionButton33;
		ControllerActionButton controllerActionButton34;
		this.LeftPageCycle = controllerActionButton34;
		ControllerActionButton controllerActionButton35 = this.CreateButtonMapping("Weapons - Ammo");
		this.RightPageCycle = controllerActionButton35;
		ControllerActionButton controllerActionButton36 = this.CreateButtonMapping("KeyboardLoadout1");
		this.Loadout1 = controllerActionButton36;
		ControllerActionButton controllerActionButton37 = this.CreateButtonMapping("KeyboardLoadout2");
		this.Loadout2 = controllerActionButton37;
		ControllerActionButton controllerActionButton38 = this.CreateButtonMapping("KeyboardLoadout3");
		this.Loadout3 = controllerActionButton38;
		ControllerActionButton controllerActionButton39 = this.CreateButtonMapping("KeyboardLoadoutCycle");
		this.LoadoutCycle = controllerActionButton39;
		this.LoadDefaults();
		this.SetupEscapeKeySetting();
	}

	// Token: 0x06000B29 RID: 2857 RVA: 0x000387B0 File Offset: 0x000369B0
	private KeyCode LoadKeyCode(Preferences preferences, string id, bool loaded)
	{
		int num = 1;
		loaded.m_value = num != 0;
		if (num == 0)
		{
		}
		throw new InvalidCastException();
	}

	// Token: 0x06000B2A RID: 2858 RVA: 0x000387DC File Offset: 0x000369DC
	public void LoadConfiguration(Preferences preferences)
	{
		ControllerActionAxis movementAxisX = this.MovementAxisX;
	}

	// Token: 0x06000B2B RID: 2859 RVA: 0x000021DB File Offset: 0x000003DB
	public void SaveConfiguration(Preferences preferences)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000B2C RID: 2860 RVA: 0x000388D4 File Offset: 0x00036AD4
	public void LoadDefaults()
	{
		this.MovementAxisX.FirstEntry.Key0 = KeyCode.A;
		this.MovementAxisX.FirstEntry.Key1 = KeyCode.D;
		this.MovementAxisY.FirstEntry.Key0 = KeyCode.W;
		this.MovementAxisY.FirstEntry.Key1 = KeyCode.S;
		this.GrappleFire.FirstEntry.InputKey = KeyCode.E;
		this.Jump.FirstEntry.InputKey = KeyCode.Space;
		this.Fire.FirstEntry.InputKey = KeyCode.Mouse0;
		this.Interact.FirstEntry.InputKey = KeyCode.Mouse1;
		this.TargetLockOn.FirstEntry.InputKey = KeyCode.L;
		this.InventoryToggle.FirstEntry.InputKey = KeyCode.I;
		this.AutoSelect.FirstEntry.InputKey = KeyCode.LeftShift;
		this.SmartCursor.FirstEntry.InputKey = KeyCode.LeftControl;
		this.ZoomIn.FirstEntry.InputKey = KeyCode.Equals;
		this.ZoomOut.FirstEntry.InputKey = KeyCode.Minus;
		this.MapZoomIn.FirstEntry.InputKey = KeyCode.KeypadPlus;
		this.MapZoomOut.FirstEntry.InputKey = KeyCode.KeypadMinus;
		this.MapZoomDefault.FirstEntry.InputKey = KeyCode.KeypadEnter;
		this.QuickHeal.FirstEntry.InputKey = KeyCode.H;
		this.QuickMana.FirstEntry.InputKey = KeyCode.J;
		this.QuickBuff.FirstEntry.InputKey = KeyCode.B;
		this.QuickMount.FirstEntry.InputKey = KeyCode.R;
		this.MapToggle.FirstEntry.InputKey = KeyCode.M;
		this.MiniMapToggle.FirstEntry.InputKey = KeyCode.Tab;
		this.ChatToggle.FirstEntry.InputKey = KeyCode.Return;
		this.Hotbar1.FirstEntry.InputKey = KeyCode.Alpha1;
		this.Hotbar2.FirstEntry.InputKey = KeyCode.Alpha2;
		this.Hotbar3.FirstEntry.InputKey = KeyCode.Alpha3;
		this.Hotbar4.FirstEntry.InputKey = KeyCode.Alpha4;
		this.Hotbar5.FirstEntry.InputKey = KeyCode.Alpha5;
		this.Hotbar6.FirstEntry.InputKey = KeyCode.Alpha6;
		this.Hotbar7.FirstEntry.InputKey = KeyCode.Alpha7;
		this.Hotbar8.FirstEntry.InputKey = KeyCode.Alpha8;
		this.Hotbar9.FirstEntry.InputKey = KeyCode.Alpha9;
		this.Hotbar10.FirstEntry.InputKey = KeyCode.Alpha0;
		this.Settings.FirstEntry.InputKey = KeyCode.P;
		ControllerActionButton.Entry firstEntry = this.HotbarNext.FirstEntry;
		ControllerActionButton.Entry firstEntry2 = this.HotbarPrevious.FirstEntry;
		ControllerActionButton.Entry firstEntry3 = this.LeftPageCycle.FirstEntry;
		ControllerActionButton.Entry firstEntry4 = this.RightPageCycle.FirstEntry;
		ControllerActionButton.Entry firstEntry5 = this.Loadout1.FirstEntry;
		ControllerActionButton.Entry firstEntry6 = this.Loadout2.FirstEntry;
		ControllerActionButton.Entry firstEntry7 = this.Loadout3.FirstEntry;
		ControllerActionButton.Entry firstEntry8 = this.LoadoutCycle.FirstEntry;
	}

	// Token: 0x06000B2D RID: 2861 RVA: 0x00038BD0 File Offset: 0x00036DD0
	public void ClearBinding(KeyCode key)
	{
		KeyCode key2 = this.MovementAxisX.FirstEntry.Key0;
		ControllerActionAxis.Entry firstEntry = this.MovementAxisX.FirstEntry;
		KeyCode key3 = this.MovementAxisX.FirstEntry.Key1;
		ControllerActionAxis.Entry firstEntry2 = this.MovementAxisX.FirstEntry;
		KeyCode key4 = this.MovementAxisY.FirstEntry.Key0;
		ControllerActionAxis.Entry firstEntry3 = this.MovementAxisY.FirstEntry;
		KeyCode key5 = this.MovementAxisY.FirstEntry.Key1;
		ControllerActionAxis.Entry firstEntry4 = this.MovementAxisY.FirstEntry;
		List<ControllerActionButton> allButtonMappings = this.AllButtonMappings;
		ControllerActionButton.Entry entry;
		KeyCode inputKey = entry.InputKey;
	}

	// Token: 0x06000B2E RID: 2862 RVA: 0x00038C80 File Offset: 0x00036E80
	public void Draw()
	{
		GUIKeyboardMappingOverlay controllerInput = this._controllerInput;
	}

	// Token: 0x06000B2F RID: 2863 RVA: 0x00038D10 File Offset: 0x00036F10
	public void LooseFocus()
	{
		if (!this.hasFocus || this._categoriesBlocker != null)
		{
		}
	}

	// Token: 0x06000B30 RID: 2864 RVA: 0x00038D30 File Offset: 0x00036F30
	private void GainFocus()
	{
		if (!this.hasFocus)
		{
			GUIInputRegionExclusive guiinputRegionExclusive;
			this._categoriesBlocker = guiinputRegionExclusive;
			this.hasFocus = true;
		}
	}

	// Token: 0x06000B31 RID: 2865 RVA: 0x00038D54 File Offset: 0x00036F54
	private bool IsOverCategories(Microsoft.Xna.Framework.Vector2 cursorPosition)
	{
		if (this.Enabled && this.overlayEntry == null)
		{
			Rectangle rectangle;
			int bottom = rectangle.Bottom;
			bool flag;
			return flag;
		}
	}

	// Token: 0x06000B32 RID: 2866 RVA: 0x00038D7C File Offset: 0x00036F7C
	private void DrawCategories()
	{
		if (this._categoriesBlocker != null)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		bool mouseLeftRelease = Main.mouseLeftRelease;
		int num = 17096;
		this.TimeSinceItemChange = (float)num;
		KeyboardMappingsCategories_Layout.Category[] tabOrder = this.TabOrder;
		KeyboardMappingsCategories_Layout.Category selected = this.Selected;
		if (this.overlayEntry == null)
		{
			KeyboardMappingsCategories_Layout.Category[] tabOrder2 = this.TabOrder;
			KeyboardMappingsCategories_Layout.Category[] tabOrder3 = this.TabOrder;
			GUIKeyboardMappingOverlay controllerInput = this._controllerInput;
			int num2 = 5;
			controllerInput.selectedControl = (GUIKeyboardMappingOverlay.Controls)num2;
			controllerInput.Activate();
			if (this.overlayEntry == null)
			{
				KeyboardMappingsCategories_Layout.Category[] tabOrder4 = this.TabOrder;
				KeyboardMappingsCategories_Layout.Category[] tabOrder5 = this.TabOrder;
				GUIKeyboardMappingOverlay controllerInput2 = this._controllerInput;
				int num3 = 5;
				controllerInput2.selectedControl = (GUIKeyboardMappingOverlay.Controls)num3;
				controllerInput2.Activate();
			}
		}
		KeyboardMappingsCategories_Layout.Category selected2 = this.Selected;
		GUITransactionButton.InputState inputState;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
			this._controllerInput.Activate();
		}
		KeyboardMappingsCategories_Layout.Category selected3 = this.Selected;
		GUITransactionButton.InputState inputState2;
		if (inputState2 == GUITransactionButton.InputState.Clicked)
		{
			this._controllerInput.Activate();
		}
		KeyboardMappingsCategories_Layout.Category selected4 = this.Selected;
		GUITransactionButton.InputState inputState3;
		if (inputState3 == GUITransactionButton.InputState.Clicked)
		{
			this._controllerInput.Activate();
		}
		KeyboardMappingsCategories_Layout.Category selected5 = this.Selected;
		GUITransactionButton.InputState inputState4;
		if (inputState4 == GUITransactionButton.InputState.Clicked)
		{
			this._controllerInput.Activate();
		}
		KeyboardMappingsCategories_Layout.Category selected6 = this.Selected;
		GUITransactionButton.InputState inputState5;
		if (inputState5 == GUITransactionButton.InputState.Clicked)
		{
			this._controllerInput.Activate();
		}
		float timeSinceItemChange = this.TimeSinceItemChange;
		float deltaTime = Time.deltaTime;
		GUIInputRegionExclusive categoriesBlocker = this._categoriesBlocker;
		if (categoriesBlocker != null)
		{
			int num4 = 1;
			categoriesBlocker.Active = num4 != 0;
		}
	}

	// Token: 0x06000B33 RID: 2867 RVA: 0x00038EE0 File Offset: 0x000370E0
	public void Close()
	{
	}

	// Token: 0x06000B34 RID: 2868 RVA: 0x00038EF0 File Offset: 0x000370F0
	public void Backup()
	{
		int size = this._allSettings._size;
		int size2 = this._allSettings._size;
	}

	// Token: 0x06000B35 RID: 2869 RVA: 0x00038F18 File Offset: 0x00037118
	public void RestoreBackup()
	{
		int size = this._allSettings._size;
		int size2 = this._allSettings._size;
	}

	// Token: 0x06000B36 RID: 2870 RVA: 0x00038F40 File Offset: 0x00037140
	private void DrawMainButtons()
	{
		bool mouseLeft = Main.mouseLeft;
		bool mouseLeftRelease = Main.mouseLeftRelease;
		GUIKeyboardMappingEntry guikeyboardMappingEntry = this.overlayEntry;
		GUITransactionButton.InputState inputState;
		GUIKeyboardMappingEntry guikeyboardMappingEntry2;
		if (inputState != GUITransactionButton.InputState.Clicked)
		{
			guikeyboardMappingEntry2 = this.overlayEntry;
			if (guikeyboardMappingEntry2 != null)
			{
				goto IL_0054;
			}
			if (guikeyboardMappingEntry2 == null)
			{
			}
		}
		if (guikeyboardMappingEntry2 == null)
		{
		}
		bool escapeOpensInventory = this._escapeOpensInventory;
		int num = 128;
		int num2 = 1;
		if (num == 0)
		{
		}
		Main.mouseLeftRelease = false;
		IL_0054:
		if (num2 == 0)
		{
		}
		GUIKeyboardMappingEntry guikeyboardMappingEntry3 = this.overlayEntry;
		int num3 = 1;
		GUITransactionButton.InputState inputState2;
		if (inputState2 == GUITransactionButton.InputState.Clicked)
		{
			if (num3 == 0)
			{
			}
			Main.mouseLeftRelease = false;
			this.RestoreBackup();
		}
		if (guikeyboardMappingEntry3 == null)
		{
		}
		GUIKeyboardMappingEntry guikeyboardMappingEntry4 = this.overlayEntry;
		int num4 = 1;
		GUITransactionButton.InputState inputState3;
		if (inputState3 == GUITransactionButton.InputState.Clicked)
		{
			if (num4 == 0)
			{
			}
			Main.mouseLeftRelease = false;
			this.LoadDefaults();
		}
		if (this.overlayEntry == null)
		{
			bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
			List<GUIKeyboardMappingEntry> categorySettings = this._categorySettings;
			GUIKeyboardMappingOverlay controllerInput = this._controllerInput;
			int size = categorySettings._size;
			int selectedItem = controllerInput._selectedItem;
			if (size == 0)
			{
			}
		}
	}

	// Token: 0x06000B37 RID: 2871 RVA: 0x00039028 File Offset: 0x00037228
	private void ClearMapping()
	{
		GUIKeyboardMappingEntry guikeyboardMappingEntry = this.overlayEntry;
		if (guikeyboardMappingEntry != null)
		{
			guikeyboardMappingEntry.RemoveBinding();
			return;
		}
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		List<GUIKeyboardMappingEntry> categorySettings = this._categorySettings;
		GUIKeyboardMappingOverlay controllerInput = this._controllerInput;
		int size = categorySettings._size;
		int selectedItem = controllerInput._selectedItem;
		while (categorySettings != null)
		{
		}
	}

	// Token: 0x06000B38 RID: 2872 RVA: 0x00039070 File Offset: 0x00037270
	private void DrawTitle()
	{
		string textValue = Language.GetTextValue("GameUI.KeyboardMappingsMenu");
		KeyboardMappingsCategories_Layout.Category selected = this.Selected;
	}

	// Token: 0x06000B39 RID: 2873 RVA: 0x000390C0 File Offset: 0x000372C0
	private void DrawBacking()
	{
	}

	// Token: 0x06000B3A RID: 2874 RVA: 0x000390D0 File Offset: 0x000372D0
	private void DrawCategoryOptions()
	{
		int size = this._categorySettings._size;
		int num = this.disableScroll;
		if ("QuickBuff" == null)
		{
		}
	}

	// Token: 0x06000B3B RID: 2875 RVA: 0x000021DB File Offset: 0x000003DB
	private float SettingScale(int index)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000B3C RID: 2876 RVA: 0x000390F8 File Offset: 0x000372F8
	private void SettingOver(int index)
	{
	}

	// Token: 0x06000B3D RID: 2877 RVA: 0x00039108 File Offset: 0x00037308
	private void SettingDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		List<GUIKeyboardMappingEntry> categorySettings = this._categorySettings;
		List<GUIKeyboardMappingEntry> categorySettings2 = this._categorySettings;
	}

	// Token: 0x06000B3E RID: 2878 RVA: 0x00039124 File Offset: 0x00037324
	private Microsoft.Xna.Framework.Vector2 SettingSize(int index)
	{
		/*
An exception occurred when decompiling this method (06000B3E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 GUIKeyboardMappings::SettingSize(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.List`1<class GUIKeyboardMappingEntry>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIKeyboardMappingEntry>(GUIKeyboardMappings::_categorySettings, ldloc:GUIKeyboardMappings(this)))
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

	// Token: 0x06000B3F RID: 2879 RVA: 0x000021DB File Offset: 0x000003DB
	public void SetCategory(KeyboardMappingsCategories_Layout.Category category)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000B40 RID: 2880 RVA: 0x00039138 File Offset: 0x00037338
	public static string GetControlTag(ControlsKeyboardTagHandler.MappingType mappingType)
	{
		string text;
		return text;
	}

	// Token: 0x06000B41 RID: 2881 RVA: 0x00039148 File Offset: 0x00037348
	public GUIKeyboardMappings()
	{
	}

	// Token: 0x04000BA5 RID: 2981
	private bool _keyboardEnabled;

	// Token: 0x04000BA6 RID: 2982
	public GUIKeyboardMappingOverlay _controllerInput;

	// Token: 0x04000BA7 RID: 2983
	private GUIKeyboardMappingEntry overlayEntry;

	// Token: 0x04000BA8 RID: 2984
	private Rectangle overlayRegion;

	// Token: 0x04000BA9 RID: 2985
	public bool Enabled;

	// Token: 0x04000BAA RID: 2986
	public bool performingBinding;

	// Token: 0x04000BAB RID: 2987
	private int disableScroll;

	// Token: 0x04000BAC RID: 2988
	public ControllerActionAxis MovementAxisX;

	// Token: 0x04000BAD RID: 2989
	public ControllerActionAxis MovementAxisY;

	// Token: 0x04000BAE RID: 2990
	public ControllerActionVector MovementAxis;

	// Token: 0x04000BAF RID: 2991
	public ControllerActionButton GrappleFire;

	// Token: 0x04000BB0 RID: 2992
	public ControllerActionButton Jump;

	// Token: 0x04000BB1 RID: 2993
	public ControllerActionButton Fire;

	// Token: 0x04000BB2 RID: 2994
	public ControllerActionButton Interact;

	// Token: 0x04000BB3 RID: 2995
	public ControllerActionButton TargetLockOn;

	// Token: 0x04000BB4 RID: 2996
	public ControllerActionButton InventoryToggle;

	// Token: 0x04000BB5 RID: 2997
	public ControllerActionButton AutoSelect;

	// Token: 0x04000BB6 RID: 2998
	public ControllerActionButton SmartCursor;

	// Token: 0x04000BB7 RID: 2999
	public ControllerActionButton Settings;

	// Token: 0x04000BB8 RID: 3000
	public ControllerActionButton HotbarNext;

	// Token: 0x04000BB9 RID: 3001
	public ControllerActionButton HotbarPrevious;

	// Token: 0x04000BBA RID: 3002
	public ControllerActionButton LeftPageCycle;

	// Token: 0x04000BBB RID: 3003
	public ControllerActionButton RightPageCycle;

	// Token: 0x04000BBC RID: 3004
	public ControllerActionButton ZoomIn;

	// Token: 0x04000BBD RID: 3005
	public ControllerActionButton ZoomOut;

	// Token: 0x04000BBE RID: 3006
	public ControllerActionButton MapZoomIn;

	// Token: 0x04000BBF RID: 3007
	public ControllerActionButton MapZoomOut;

	// Token: 0x04000BC0 RID: 3008
	public ControllerActionButton MapZoomDefault;

	// Token: 0x04000BC1 RID: 3009
	public ControllerActionButton QuickMount;

	// Token: 0x04000BC2 RID: 3010
	public ControllerActionButton QuickHeal;

	// Token: 0x04000BC3 RID: 3011
	public ControllerActionButton QuickBuff;

	// Token: 0x04000BC4 RID: 3012
	public ControllerActionButton QuickMana;

	// Token: 0x04000BC5 RID: 3013
	public ControllerActionButton MapToggle;

	// Token: 0x04000BC6 RID: 3014
	public ControllerActionButton MiniMapToggle;

	// Token: 0x04000BC7 RID: 3015
	public ControllerActionButton ChatToggle;

	// Token: 0x04000BC8 RID: 3016
	public ControllerActionButton Hotbar1;

	// Token: 0x04000BC9 RID: 3017
	public ControllerActionButton Hotbar2;

	// Token: 0x04000BCA RID: 3018
	public ControllerActionButton Hotbar3;

	// Token: 0x04000BCB RID: 3019
	public ControllerActionButton Hotbar4;

	// Token: 0x04000BCC RID: 3020
	public ControllerActionButton Hotbar5;

	// Token: 0x04000BCD RID: 3021
	public ControllerActionButton Hotbar6;

	// Token: 0x04000BCE RID: 3022
	public ControllerActionButton Hotbar7;

	// Token: 0x04000BCF RID: 3023
	public ControllerActionButton Hotbar8;

	// Token: 0x04000BD0 RID: 3024
	public ControllerActionButton Hotbar9;

	// Token: 0x04000BD1 RID: 3025
	public ControllerActionButton Hotbar10;

	// Token: 0x04000BD2 RID: 3026
	public ControllerActionButton Loadout1;

	// Token: 0x04000BD3 RID: 3027
	public ControllerActionButton Loadout2;

	// Token: 0x04000BD4 RID: 3028
	public ControllerActionButton Loadout3;

	// Token: 0x04000BD5 RID: 3029
	public ControllerActionButton LoadoutCycle;

	// Token: 0x04000BD6 RID: 3030
	private List<ControllerActionButton> AllButtonMappings;

	// Token: 0x04000BD7 RID: 3031
	private bool _escapeOpensInventory = true;

	// Token: 0x04000BD8 RID: 3032
	private float TimeSinceItemChange;

	// Token: 0x04000BD9 RID: 3033
	private KeyboardMappingsCategories_Layout.Category[] TabOrder;

	// Token: 0x04000BDA RID: 3034
	public KeyboardMappingsCategories_Layout.Category Selected;

	// Token: 0x04000BDB RID: 3035
	private float GameplayButtonScale;

	// Token: 0x04000BDC RID: 3036
	private float UIButtonScale;

	// Token: 0x04000BDD RID: 3037
	private float SaveAndCloseButtonScale;

	// Token: 0x04000BDE RID: 3038
	private float ResetSettingsButtonScale;

	// Token: 0x04000BDF RID: 3039
	private float titleScale;

	// Token: 0x04000BE0 RID: 3040
	public float ScrollOffset;

	// Token: 0x04000BE1 RID: 3041
	private float ScrollMomentum;

	// Token: 0x04000BE2 RID: 3042
	private int ScrollDragging;

	// Token: 0x04000BE3 RID: 3043
	private Microsoft.Xna.Framework.Vector2 DragOffset;

	// Token: 0x04000BE4 RID: 3044
	public List<GUIKeyboardMappingEntry> _allSettings;

	// Token: 0x04000BE5 RID: 3045
	public List<GUIKeyboardMappingEntry> _categorySettings;

	// Token: 0x04000BE6 RID: 3046
	private bool hasFocus;

	// Token: 0x04000BE7 RID: 3047
	private GUIInputRegionExclusive _categoriesBlocker;

	// Token: 0x0200018B RID: 395
	[CompilerGenerated]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000B42 RID: 2882 RVA: 0x0003916C File Offset: 0x0003736C
		// Note: this type is marked as 'beforefieldinit'.
		static <>c()
		{
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x0003917C File Offset: 0x0003737C
		public <>c()
		{
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x00039190 File Offset: 0x00037390
		internal int <SetCategory>b__100_0(GUIKeyboardMappingEntry e1, GUIKeyboardMappingEntry e2)
		{
			int sortOrder = e2.SortOrder;
			int num;
			return num;
		}

		// Token: 0x04000BE8 RID: 3048
		public static readonly GUIKeyboardMappings.<>c <>9;

		// Token: 0x04000BE9 RID: 3049
		public static Comparison<GUIKeyboardMappingEntry> <>9__100_0;
	}
}
