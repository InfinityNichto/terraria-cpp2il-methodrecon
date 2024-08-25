using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Localization;
using UnityEngine;

// Token: 0x02000151 RID: 337
public class GUIJourneyModeSettings
{
	// Token: 0x06000935 RID: 2357 RVA: 0x000021DB File Offset: 0x000003DB
	public void Init()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000936 RID: 2358 RVA: 0x000285E8 File Offset: 0x000267E8
	public static Microsoft.Xna.Framework.Graphics.Texture2D GetIconTexture(GUISettingID id, [Out] Rectangle frame)
	{
		/*
An exception occurred when decompiling this method (06000936)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Texture2D GUIJourneyModeSettings::GetIconTexture(GUISettingID,Microsoft.Xna.Framework.Rectangle)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stfld:int32(GUISettingID::value__, ldloc:GUISettingID[exp:valuetype GUISettingID&](id), ldloc:Rectangle[exp:int32](var_2))
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

	// Token: 0x06000937 RID: 2359 RVA: 0x00028604 File Offset: 0x00026804
	public void RegisterOverlay(GUISettingEntry entry, Rectangle region)
	{
		this.overlayEntry = entry;
		this.overlayRegion = region;
	}

	// Token: 0x06000938 RID: 2360 RVA: 0x00028620 File Offset: 0x00026820
	public void DrawButton()
	{
		bool mapFullscreen = Main.mapFullscreen;
		int gameMode = Main.GameMode;
		GUITransactionButton.InputState inputState;
		if (inputState != GUITransactionButton.InputState.Clicked)
		{
			return;
		}
		if (this.Enabled)
		{
			this.Close();
			return;
		}
	}

	// Token: 0x06000939 RID: 2361 RVA: 0x00028658 File Offset: 0x00026858
	public void Draw()
	{
		bool enabled = this.Enabled;
		if (enabled)
		{
			if (!enabled)
			{
			}
			bool gameMenu = Main.gameMenu;
			if (!enabled)
			{
			}
			int gameMode = Main.GameMode;
			if (!enabled)
			{
			}
			this.GainFocus();
			GUIControllerJourneyModeSettings controllerInput = this._controllerInput;
			return;
		}
	}

	// Token: 0x0600093A RID: 2362 RVA: 0x000021DB File Offset: 0x000003DB
	private float SettingScale(int index)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x0600093B RID: 2363 RVA: 0x000286E0 File Offset: 0x000268E0
	private void SettingOver(int index)
	{
		if ("Only TraceListeners can be added to a TraceListenerCollection." == null)
		{
		}
		bool mouseLeft = Main.mouseLeft;
	}

	// Token: 0x0600093C RID: 2364 RVA: 0x0002870C File Offset: 0x0002690C
	private void SettingDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		List<GUISettingEntry> categorySettings = this._categorySettings;
		List<GUISettingEntry> categorySettings2 = this._categorySettings;
	}

	// Token: 0x0600093D RID: 2365 RVA: 0x00028728 File Offset: 0x00026928
	private Microsoft.Xna.Framework.Vector2 SettingSize(int index)
	{
		/*
An exception occurred when decompiling this method (0600093D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 GUIJourneyModeSettings::SettingSize(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.List`1<class GUISettingEntry>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUISettingEntry>(GUIJourneyModeSettings::_categorySettings, ldloc:GUIJourneyModeSettings(this)))
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

	// Token: 0x0600093E RID: 2366 RVA: 0x0002873C File Offset: 0x0002693C
	private void DrawCategoryOptions()
	{
		int size = this._categorySettings._size;
	}

	// Token: 0x0600093F RID: 2367 RVA: 0x00028758 File Offset: 0x00026958
	private void DrawTitle()
	{
		string textValue = Language.GetTextValue("Mobile.JourneySettingsMenu");
	}

	// Token: 0x06000940 RID: 2368 RVA: 0x00028770 File Offset: 0x00026970
	public void DrawBacking()
	{
	}

	// Token: 0x06000941 RID: 2369 RVA: 0x00028780 File Offset: 0x00026980
	public void SetCategory(GUIJourneyModeSettings.Category category)
	{
		List<GUISettingEntry> timeSettings = this._timeSettings;
		this.overlayRegion.Width = (int)category;
		if (timeSettings._size == 0)
		{
			this.Init();
			GUIJourneyModeSettings.Category selected = this.Selected;
		}
	}

	// Token: 0x06000942 RID: 2370 RVA: 0x000287B8 File Offset: 0x000269B8
	public void DrawCategories()
	{
		if (this._categoriesBlocker != null)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		bool mouseLeftRelease = Main.mouseLeftRelease;
		int num = 17096;
		this.TimeSinceItemChange = (float)num;
		if (num == 0)
		{
		}
		GUIJourneyModeSettings.Category selected = this.Selected;
		GUIControllerJourneyModeSettings controllerInput = this._controllerInput;
		int num2 = 3;
		controllerInput.selectedControl = (GUIControllerJourneyModeSettings.Controls)num2;
		controllerInput.Activate();
		GUIControllerJourneyModeSettings controllerInput2 = this._controllerInput;
		int num3 = 3;
		controllerInput2.selectedControl = (GUIControllerJourneyModeSettings.Controls)num3;
		controllerInput2.Activate();
		string textValue = Language.GetTextValue("Mobile.JourneyCategoryTime");
		GUIJourneyModeSettings.Category selected2 = this.Selected;
		GUITransactionButton.InputState inputState;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
			this._controllerInput.Activate();
		}
		string textValue2 = Language.GetTextValue("Mobile.JourneyCategoryWeather");
		GUIJourneyModeSettings.Category selected3 = this.Selected;
		GUITransactionButton.InputState inputState2;
		if (inputState2 == GUITransactionButton.InputState.Clicked)
		{
			this._controllerInput.Activate();
		}
		string textValue3 = Language.GetTextValue("Mobile.JourneyCategoryPowers");
		GUIJourneyModeSettings.Category selected4 = this.Selected;
		GUITransactionButton.InputState inputState3;
		if (inputState3 == GUITransactionButton.InputState.Clicked)
		{
			this._controllerInput.Activate();
		}
		float timeSinceItemChange = this.TimeSinceItemChange;
		float deltaTime = Time.deltaTime;
		this.DrawMainButtons();
		GUIInputRegionExclusive categoriesBlocker = this._categoriesBlocker;
		if (categoriesBlocker != null)
		{
			int num4 = 1;
			categoriesBlocker.Active = num4 != 0;
		}
	}

	// Token: 0x06000943 RID: 2371 RVA: 0x000288DC File Offset: 0x00026ADC
	private void DrawMainButtons()
	{
		bool mouseLeft = Main.mouseLeft;
		bool mouseLeftRelease = Main.mouseLeftRelease;
		GUIPulldownSetting guipulldownSetting = this._controllerInput._overlayEntry;
		GUITransactionButton.InputState inputState;
		GUISettingEntry guisettingEntry;
		if (inputState != GUITransactionButton.InputState.Clicked)
		{
			guisettingEntry = this.overlayEntry;
			if (guisettingEntry != null)
			{
				return;
			}
			if (guisettingEntry == null)
			{
			}
		}
		if (guisettingEntry == null)
		{
		}
		Main.mouseLeftRelease = false;
		this.Close();
	}

	// Token: 0x06000944 RID: 2372 RVA: 0x00028934 File Offset: 0x00026B34
	public void Close()
	{
		if (!this.OpenedFromInv)
		{
			bool gameMenu = Main.gameMenu;
		}
	}

	// Token: 0x06000945 RID: 2373 RVA: 0x00028954 File Offset: 0x00026B54
	public void LooseFocus()
	{
		if (!this.hasFocus || this._categoriesBlocker != null)
		{
		}
	}

	// Token: 0x06000946 RID: 2374 RVA: 0x00028974 File Offset: 0x00026B74
	private void GainFocus()
	{
		if (!this.hasFocus)
		{
			GUIInputRegionExclusive guiinputRegionExclusive;
			this._categoriesBlocker = guiinputRegionExclusive;
			this.hasFocus = true;
		}
	}

	// Token: 0x06000947 RID: 2375 RVA: 0x00028998 File Offset: 0x00026B98
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

	// Token: 0x06000948 RID: 2376 RVA: 0x000289C0 File Offset: 0x00026BC0
	public GUIJourneyModeSettings()
	{
	}

	// Token: 0x06000949 RID: 2377 RVA: 0x000289D4 File Offset: 0x00026BD4
	// Note: this type is marked as 'beforefieldinit'.
	static GUIJourneyModeSettings()
	{
	}

	// Token: 0x040008D3 RID: 2259
	public bool Enabled;

	// Token: 0x040008D4 RID: 2260
	public bool OpenedFromInv;

	// Token: 0x040008D5 RID: 2261
	private float jwButtonScale;

	// Token: 0x040008D6 RID: 2262
	public List<GUISettingEntry> _categorySettings;

	// Token: 0x040008D7 RID: 2263
	public List<GUISettingEntry> _timeSettings;

	// Token: 0x040008D8 RID: 2264
	public List<GUISettingEntry> _weatherSettings;

	// Token: 0x040008D9 RID: 2265
	public List<GUISettingEntry> _powerSettings;

	// Token: 0x040008DA RID: 2266
	private float TimeSinceItemChange;

	// Token: 0x040008DB RID: 2267
	public GUIControllerJourneyModeSettings _controllerInput;

	// Token: 0x040008DC RID: 2268
	private static Microsoft.Xna.Framework.Graphics.Texture2D infinitePowersMenu;

	// Token: 0x040008DD RID: 2269
	private GUISettingEntry overlayEntry;

	// Token: 0x040008DE RID: 2270
	private Rectangle overlayRegion;

	// Token: 0x040008DF RID: 2271
	public float ScrollOffset;

	// Token: 0x040008E0 RID: 2272
	private float ScrollMomentum;

	// Token: 0x040008E1 RID: 2273
	private int ScrollDragging;

	// Token: 0x040008E2 RID: 2274
	private Microsoft.Xna.Framework.Vector2 DragOffset;

	// Token: 0x040008E3 RID: 2275
	private float titleScale;

	// Token: 0x040008E4 RID: 2276
	private static GUIJourneyModeSettings.Category[] TabOrder;

	// Token: 0x040008E5 RID: 2277
	private GUIJourneyModeSettings.Category Selected;

	// Token: 0x040008E6 RID: 2278
	private float PowerButtonScale;

	// Token: 0x040008E7 RID: 2279
	private float TimeButtonScale;

	// Token: 0x040008E8 RID: 2280
	private float WeatherButtonScale;

	// Token: 0x040008E9 RID: 2281
	private float CloseButtonScale;

	// Token: 0x040008EA RID: 2282
	private bool hasFocus;

	// Token: 0x040008EB RID: 2283
	private GUIInputRegionExclusive _categoriesBlocker;

	// Token: 0x02000152 RID: 338
	public enum Category
	{
		// Token: 0x040008ED RID: 2285
		Time,
		// Token: 0x040008EE RID: 2286
		Weather,
		// Token: 0x040008EF RID: 2287
		Powers
	}
}
