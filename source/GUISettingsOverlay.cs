using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using UnityEngine;

// Token: 0x0200027F RID: 639
public class GUISettingsOverlay
{
	// Token: 0x06000E72 RID: 3698 RVA: 0x00046BC0 File Offset: 0x00044DC0
	public void Init()
	{
	}

	// Token: 0x06000E73 RID: 3699 RVA: 0x000021DB File Offset: 0x000003DB
	public void UpdateScroll(GUISettingID _id)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000E74 RID: 3700 RVA: 0x000021DB File Offset: 0x000003DB
	public bool IsFullyVisible(GUISettingID _id)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000E75 RID: 3701 RVA: 0x00046C50 File Offset: 0x00044E50
	private bool IsHidden(GUISettingID id)
	{
		bool flag;
		return flag;
	}

	// Token: 0x06000E76 RID: 3702 RVA: 0x00046CBC File Offset: 0x00044EBC
	public bool IsDisabled(GUISettingID id)
	{
		DrPlatform.DrPlatformType currentPlatform = DrPlatform.CurrentPlatform;
		SettingsOverlayOptionCategories_Layout.Category selected = this.Selected;
		return true;
	}

	// Token: 0x06000E77 RID: 3703 RVA: 0x000021DB File Offset: 0x000003DB
	public void SetCategory(SettingsOverlayOptionCategories_Layout.Category category)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000E78 RID: 3704 RVA: 0x00046D10 File Offset: 0x00044F10
	public void RegisterOverlay(GUISettingEntry entry, Rectangle region)
	{
		this.overlayEntry = entry;
		this.overlayRegion = region;
		this.disableScroll = 2;
	}

	// Token: 0x06000E79 RID: 3705 RVA: 0x00046D34 File Offset: 0x00044F34
	public void Shutdown()
	{
		if (!true)
		{
		}
		bool inFancyUI = Main.inFancyUI;
		GUISaveSynchronisation.Close();
		GUIControllerHardwareProfile.Close();
	}

	// Token: 0x06000E7A RID: 3706 RVA: 0x00046D5C File Offset: 0x00044F5C
	public void Draw()
	{
		if (!true)
		{
		}
	}

	// Token: 0x06000E7B RID: 3707 RVA: 0x000021DB File Offset: 0x000003DB
	private float SettingScale(int index)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000E7C RID: 3708 RVA: 0x00046E34 File Offset: 0x00045034
	private void SettingOver(int index)
	{
		if (!true)
		{
		}
		bool mouseLeft = Main.mouseLeft;
	}

	// Token: 0x06000E7D RID: 3709 RVA: 0x00046E50 File Offset: 0x00045050
	private void SettingDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		List<GUISettingEntry> categorySettings = this._categorySettings;
		List<GUISettingEntry> categorySettings2 = this._categorySettings;
	}

	// Token: 0x06000E7E RID: 3710 RVA: 0x00046E6C File Offset: 0x0004506C
	private void DummyDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		List<GUISettingEntry> categorySettings = this._categorySettings;
		GUIControllerSettingsOverlay controllerInput = this._controllerInput;
		GUIPulldownSetting guipulldownSetting = controllerInput._overlayEntry;
		if (guipulldownSetting != null)
		{
			int overlayIndex = controllerInput._overlayIndex;
			guipulldownSetting.RefreshInputRegion();
		}
	}

	// Token: 0x06000E7F RID: 3711 RVA: 0x00046EA0 File Offset: 0x000450A0
	private void DummyOver(int index)
	{
	}

	// Token: 0x06000E80 RID: 3712 RVA: 0x00046EB0 File Offset: 0x000450B0
	public void RefreshInputRegion()
	{
		int size = this._categorySettings._size;
		int num = this.disableScroll;
	}

	// Token: 0x06000E81 RID: 3713 RVA: 0x00046ED0 File Offset: 0x000450D0
	private Microsoft.Xna.Framework.Vector2 SettingSize(int index)
	{
		/*
An exception occurred when decompiling this method (06000E81)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 GUISettingsOverlay::SettingSize(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.List`1<class GUISettingEntry>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUISettingEntry>(GUISettingsOverlay::_categorySettings, ldloc:GUISettingsOverlay(this)))
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

	// Token: 0x06000E82 RID: 3714 RVA: 0x00046EE4 File Offset: 0x000450E4
	private void DrawCategoryOptions()
	{
		bool flag = this.unconfiguredControllerAttached;
		SettingsOverlayOptionCategories_Layout.Category selected = this.Selected;
		this.SetCategory(selected);
		int size = this._categorySettings._size;
		int num = this.disableScroll;
	}

	// Token: 0x06000E83 RID: 3715 RVA: 0x00046F1C File Offset: 0x0004511C
	private void DrawBacking()
	{
	}

	// Token: 0x06000E84 RID: 3716 RVA: 0x00046F2C File Offset: 0x0004512C
	private void DrawTitle()
	{
		string textValue = Language.GetTextValue("GameUI.SettingsMenu");
		SettingsOverlayOptionCategories_Layout.Category selected = this.Selected;
	}

	// Token: 0x06000E85 RID: 3717 RVA: 0x00046F78 File Offset: 0x00045178
	private void ResetSetting(GUISettingID id)
	{
	}

	// Token: 0x06000E86 RID: 3718 RVA: 0x000021DB File Offset: 0x000003DB
	private void ResetPageSettings()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000E87 RID: 3719 RVA: 0x00047274 File Offset: 0x00045474
	private void DrawMainButtons()
	{
		bool mouseLeft = Main.mouseLeft;
		bool mouseLeftRelease = Main.mouseLeftRelease;
		bool gameMenu = Main.gameMenu;
		GUIPulldownSetting guipulldownSetting = this._controllerInput._overlayEntry;
		int num = 1;
		GUITransactionButton.InputState inputState;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
			this.ResetPageSettings();
		}
		if (num == 0)
		{
		}
		GUIPulldownSetting guipulldownSetting2 = this._controllerInput._overlayEntry;
		int num2 = 1;
		GUITransactionButton.InputState inputState2;
		if (inputState2 != GUITransactionButton.InputState.Clicked)
		{
			return;
		}
		if (num2 == 0)
		{
		}
		Main.mouseLeftRelease = false;
		SettingsOverlayOptionCategories_Layout.Category selected = this.Selected;
	}

	// Token: 0x06000E88 RID: 3720 RVA: 0x000472F4 File Offset: 0x000454F4
	public void Close()
	{
		if (!true)
		{
		}
		bool gameMenu = Main.gameMenu;
	}

	// Token: 0x06000E89 RID: 3721 RVA: 0x00047318 File Offset: 0x00045518
	private void DrawCategories()
	{
		if (this._categoriesBlocker != null)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		bool mouseLeftRelease = Main.mouseLeftRelease;
		int num = 17096;
		this.TimeSinceItemChange = (float)num;
		SettingsOverlayOptionCategories_Layout.Category[] tabOrder = this.TabOrder;
		SettingsOverlayOptionCategories_Layout.Category selected = this.Selected;
		SettingsOverlayOptionCategories_Layout.Category[] tabOrder2 = this.TabOrder;
		SettingsOverlayOptionCategories_Layout.Category[] tabOrder3 = this.TabOrder;
		SettingsOverlayOptionCategories_Layout.Category[] tabOrder4 = this.TabOrder;
		this._controllerInput.Activate();
		SettingsOverlayOptionCategories_Layout.Category[] tabOrder5 = this.TabOrder;
		SettingsOverlayOptionCategories_Layout.Category[] tabOrder6 = this.TabOrder;
		SettingsOverlayOptionCategories_Layout.Category[] tabOrder7 = this.TabOrder;
		this._controllerInput.Activate();
		int pendingSelected = this.PendingSelected;
		this._controllerInput.Activate();
		this.PendingSelected = tabOrder7;
		SettingsOverlayOptionCategories_Layout.Category selected2 = this.Selected;
		GUITransactionButton.InputState inputState;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
			this._controllerInput.Activate();
		}
		SettingsOverlayOptionCategories_Layout.Category selected3 = this.Selected;
		GUITransactionButton.InputState inputState2;
		if (inputState2 == GUITransactionButton.InputState.Clicked)
		{
			this._controllerInput.Activate();
		}
		SettingsOverlayOptionCategories_Layout.Category selected4 = this.Selected;
		GUITransactionButton.InputState inputState3;
		if (inputState3 == GUITransactionButton.InputState.Clicked)
		{
			this._controllerInput.Activate();
		}
		SettingsOverlayOptionCategories_Layout.Category selected5 = this.Selected;
		GUITransactionButton.InputState inputState4;
		if (inputState4 == GUITransactionButton.InputState.Clicked)
		{
			this._controllerInput.Activate();
		}
		SettingsOverlayOptionCategories_Layout.Category selected6 = this.Selected;
		GUITransactionButton.InputState inputState5;
		if (inputState5 == GUITransactionButton.InputState.Clicked)
		{
			this._controllerInput.Activate();
		}
		SettingsOverlayOptionCategories_Layout.Category selected7 = this.Selected;
		GUITransactionButton.InputState inputState6;
		if (inputState6 == GUITransactionButton.InputState.Clicked)
		{
			this._controllerInput.Activate();
		}
		SettingsOverlayOptionCategories_Layout.Category selected8 = this.Selected;
		GUITransactionButton.InputState inputState7;
		if (inputState7 == GUITransactionButton.InputState.Clicked)
		{
			this._controllerInput.Activate();
		}
		SettingsOverlayOptionCategories_Layout.Category selected9 = this.Selected;
		GUITransactionButton.InputState inputState8;
		if (inputState8 == GUITransactionButton.InputState.Clicked)
		{
			this._controllerInput.Activate();
		}
		GUISettingEntry guisettingEntry = this.overlayEntry;
		if (guisettingEntry != null)
		{
			SettingsOverlayOptionCategories_Layout.Category selected10 = this.Selected;
			SettingsOverlayOptionCategories_Layout.Category category = guisettingEntry._category;
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

	// Token: 0x06000E8A RID: 3722 RVA: 0x000474FC File Offset: 0x000456FC
	public void LooseFocus()
	{
		if (!this.hasFocus || this._categoriesBlocker != null)
		{
		}
	}

	// Token: 0x06000E8B RID: 3723 RVA: 0x0004751C File Offset: 0x0004571C
	private void GainFocus()
	{
		if (!this.hasFocus)
		{
			GUIInputRegionExclusive guiinputRegionExclusive;
			this._categoriesBlocker = guiinputRegionExclusive;
			this.hasFocus = true;
		}
	}

	// Token: 0x06000E8C RID: 3724 RVA: 0x00047540 File Offset: 0x00045740
	private bool IsOverCategories(Microsoft.Xna.Framework.Vector2 cursorPosition)
	{
		do
		{
			bool inFancyUI = Main.inFancyUI;
		}
		while (this.overlayEntry != null);
		Rectangle rectangle;
		int bottom = rectangle.Bottom;
		bool flag;
		return flag;
	}

	// Token: 0x06000E8D RID: 3725 RVA: 0x0004756C File Offset: 0x0004576C
	public GUISettingsOverlay()
	{
	}

	// Token: 0x04001A62 RID: 6754
	private List<GUISettingEntry> _allSettings;

	// Token: 0x04001A63 RID: 6755
	public List<GUISettingEntry> _categorySettings;

	// Token: 0x04001A64 RID: 6756
	public GUIControllerSettingsOverlay _controllerInput;

	// Token: 0x04001A65 RID: 6757
	public SettingsOverlayOptionCategories_Layout.Category Selected;

	// Token: 0x04001A66 RID: 6758
	public int PendingSelected = 1;

	// Token: 0x04001A67 RID: 6759
	private int disableScroll;

	// Token: 0x04001A68 RID: 6760
	private GUISettingEntry overlayEntry;

	// Token: 0x04001A69 RID: 6761
	private Rectangle overlayRegion;

	// Token: 0x04001A6A RID: 6762
	public float ScrollOffset;

	// Token: 0x04001A6B RID: 6763
	private float ScrollMomentum;

	// Token: 0x04001A6C RID: 6764
	private int ScrollDragging;

	// Token: 0x04001A6D RID: 6765
	private Microsoft.Xna.Framework.Vector2 DragOffset;

	// Token: 0x04001A6E RID: 6766
	private bool unconfiguredControllerAttached;

	// Token: 0x04001A6F RID: 6767
	private float titleScale;

	// Token: 0x04001A70 RID: 6768
	private float GeneralButtonScale;

	// Token: 0x04001A71 RID: 6769
	private float CursorButtonScale;

	// Token: 0x04001A72 RID: 6770
	private float VideoButtonScale;

	// Token: 0x04001A73 RID: 6771
	private float LanguageButtonScale;

	// Token: 0x04001A74 RID: 6772
	private float SaveAndCloseButtonScale;

	// Token: 0x04001A75 RID: 6773
	private float AchievementsButtonScale;

	// Token: 0x04001A76 RID: 6774
	private float InterfaceButtonScale;

	// Token: 0x04001A77 RID: 6775
	private float InfoButtonScale;

	// Token: 0x04001A78 RID: 6776
	private float ResetSettingsButtonScale;

	// Token: 0x04001A79 RID: 6777
	private float KeyboardMouseButtonScale;

	// Token: 0x04001A7A RID: 6778
	private float TimeSinceItemChange;

	// Token: 0x04001A7B RID: 6779
	private SettingsOverlayOptionCategories_Layout.Category[] TabOrder;

	// Token: 0x04001A7C RID: 6780
	private bool hasFocus;

	// Token: 0x04001A7D RID: 6781
	private GUIInputRegionExclusive _categoriesBlocker;

	// Token: 0x02000280 RID: 640
	[CompilerGenerated]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000E8E RID: 3726 RVA: 0x00047588 File Offset: 0x00045788
		// Note: this type is marked as 'beforefieldinit'.
		static <>c()
		{
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x00047598 File Offset: 0x00045798
		public <>c()
		{
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x000475AC File Offset: 0x000457AC
		internal int <SetCategory>b__10_0(GUISettingEntry e1, GUISettingEntry e2)
		{
			int sortId = e2._sortId;
			int num;
			return num;
		}

		// Token: 0x04001A7E RID: 6782
		public static readonly GUISettingsOverlay.<>c <>9;

		// Token: 0x04001A7F RID: 6783
		public static Comparison<GUISettingEntry> <>9__10_0;
	}
}
