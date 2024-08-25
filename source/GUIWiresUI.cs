using System;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Terraria;
using Terraria.GameContent.UI;
using Terraria.Localization;
using UnityEngine;

// Token: 0x02000178 RID: 376
public class GUIWiresUI
{
	// Token: 0x06000AAC RID: 2732 RVA: 0x0003641C File Offset: 0x0003461C
	public GUIWiresUI()
	{
		if (!true)
		{
		}
		if (!true)
		{
		}
		this.TimeSinceChange = (float)17096;
		base..ctor();
		GUIInputRegionExclusive guiinputRegionExclusive;
		this.PickingInterceptor = guiinputRegionExclusive;
	}

	// Token: 0x06000AAD RID: 2733 RVA: 0x00036450 File Offset: 0x00034650
	public void PlayerMenuDisplayToggle()
	{
		bool displayOptions = this.DisplayOptions;
		if (!displayOptions)
		{
			if (!displayOptions)
			{
			}
			int myPlayer = Main.myPlayer;
			if (!displayOptions)
			{
				int num = 1;
				this.DisplayOptions = num != 0;
				return;
			}
		}
		this.Close();
	}

	// Token: 0x06000AAE RID: 2734 RVA: 0x000364B8 File Offset: 0x000346B8
	private Microsoft.Xna.Framework.Vector2 ClampPositionToScreen(Microsoft.Xna.Framework.Vector2 position)
	{
		/*
An exception occurred when decompiling this method (06000AAE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 GUIWiresUI::ClampPositionToScreen(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000F:
	stloc:float32(var_6_24, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](WireUI_Layout::TouchPanelOffset, callgetter:WireUI_Layout(WireUI_Layout::get_Instance))))
	stloc:float32(var_8_38, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](WireUI_Layout::BackingTLOffset, callgetter:WireUI_Layout(WireUI_Layout::get_Instance))))
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

	// Token: 0x06000AAF RID: 2735 RVA: 0x000021DB File Offset: 0x000003DB
	private float ItemScale(int index)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000AB0 RID: 2736 RVA: 0x00036500 File Offset: 0x00034700
	private void ItemOver(int index)
	{
		this.hoverItem = index;
	}

	// Token: 0x06000AB1 RID: 2737 RVA: 0x00036514 File Offset: 0x00034714
	private void ItemDraw(ItemGrid_Layout gridLayout, int i, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		int num = 1;
		Rectangle region = GUITransactionButton.GetRegion(WireUI_Layout.Instance.PlacementBacking);
		if (num == 0)
		{
		}
		Microsoft.Xna.Framework.Vector2 vector = region.Size();
		WireUI_Layout instance = WireUI_Layout.Instance;
		float x = instance.TouchPanelOffset.X;
		float y = instance.TouchPanelOffset.Y;
		bool overloadSize = WireUI_Layout.Instance.PlacementBacking.overloadSize;
		if (!overloadSize)
		{
			if (!overloadSize)
			{
			}
		}
		int num2 = 32640;
		WiresUI.Settings.MultiToolMode toolMode = WiresUI.Settings.ToolMode;
		WiresUI.Settings.MultiToolMode toolMode2 = WiresUI.Settings.ToolMode;
		if (num2 == 0)
		{
		}
		WiresUI.Settings.MultiToolMode toolMode3 = WiresUI.Settings.ToolMode;
		WireUI_Layout instance2 = WireUI_Layout.Instance;
		float[] buttonScales = this.ButtonScales;
		GUITransactionButton.InputState inputState;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
			return;
		}
	}

	// Token: 0x06000AB2 RID: 2738 RVA: 0x00036640 File Offset: 0x00034840
	private bool CanInteract()
	{
		/*
An exception occurred when decompiling this method (06000AB2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIWiresUI::CanInteract()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_003C:
	stloc:int32(var_10_44, callgetter:int32(Main::get_signHover))
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

	// Token: 0x06000AB3 RID: 2739 RVA: 0x00036694 File Offset: 0x00034894
	public void DrawCursor()
	{
		bool drawToolModeUI = WiresUI.Settings.DrawToolModeUI;
	}

	// Token: 0x06000AB4 RID: 2740 RVA: 0x000366B0 File Offset: 0x000348B0
	public void DrawOverlay()
	{
		if (this.DisplayOptions)
		{
			Rectangle rectangle = this.CalculateRegion();
			this.Close();
		}
		bool drawToolModeUI = WiresUI.Settings.DrawToolModeUI;
		global::Cursor cursor;
		if (cursor != null)
		{
			Microsoft.Xna.Framework.Vector2 uicursorPosition = Mouse.GetUICursorPosition();
			if (this.CalculateRegion() == null)
			{
			}
			bool key = KeyboardInput.GetKey(KeyCode.Mouse1);
		}
		bool drawToolModeUI2 = WiresUI.Settings.DrawToolModeUI;
		if (this.DisplayOptions)
		{
			Main.FlushBatches();
			GUIControllerWiresUI controller = this._controller;
			this._controller.Activate();
			string textValue = Language.GetTextValue("Mobile.FilterItemsClose");
			bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
			return;
		}
	}

	// Token: 0x06000AB5 RID: 2741 RVA: 0x000367E4 File Offset: 0x000349E4
	public void DrawButton()
	{
	}

	// Token: 0x06000AB6 RID: 2742 RVA: 0x000367F4 File Offset: 0x000349F4
	private void DrawCursorArea(SpriteBatch spriteBatch)
	{
		global::Cursor cursor;
		if (cursor != null)
		{
			int worldMouseX = Main.worldMouseX;
			int worldMouseY = Main.worldMouseY;
			WireUI_Layout instance = WireUI_Layout.Instance;
			float x = instance.CursorPanelOffset.X;
			float y = instance.CursorPanelOffset.Y;
			bool drawToolAllowActuators = WiresUI.Settings.DrawToolAllowActuators;
			WiresUI.Settings.MultiToolMode toolMode = WiresUI.Settings.ToolMode;
			int num = 1;
			WiresUI.Settings.MultiToolMode toolMode2 = WiresUI.Settings.ToolMode;
			if (num == 0)
			{
			}
			return;
		}
	}

	// Token: 0x06000AB7 RID: 2743 RVA: 0x000368F4 File Offset: 0x00034AF4
	public void Close()
	{
		if (this.DisplayOptions)
		{
			GUIControllerWiresUI controller = this._controller;
			int selectedItem = Main.LocalPlayer.selectedItem;
			return;
		}
	}

	// Token: 0x06000AB8 RID: 2744 RVA: 0x00036920 File Offset: 0x00034B20
	public bool IsOver(Microsoft.Xna.Framework.Vector2 cursorPosition)
	{
		if (!true)
		{
		}
		bool gameMenu = Main.gameMenu;
		if (this.DisplayOptions)
		{
			bool drawToolModeUI = WiresUI.Settings.DrawToolModeUI;
			InterfaceProfile_Layout active = InterfaceStyles_Layout.Active;
			bool flag = active.AnyOpen();
			bool flag2 = active.IsPageSelected(GUIPageIcons.Category.Inventory);
			if (this.CalculateRegion() == null)
			{
			}
			bool flag3;
			return flag3;
		}
	}

	// Token: 0x06000AB9 RID: 2745 RVA: 0x0003697C File Offset: 0x00034B7C
	private Rectangle CalculateRegion()
	{
		int num = 1;
		ItemGrid_Layout toolOptions = WireUI_Layout.Instance.ToolOptions;
		Rectangle region = GUITransactionButton.GetRegion(WireUI_Layout.Instance.PlacementBacking);
		if (num == 0)
		{
		}
		Microsoft.Xna.Framework.Vector2 vector = region.Size();
		bool drawToolAllowActuators = WiresUI.Settings.DrawToolAllowActuators;
		float x = WireUI_Layout.Instance.BackingTLOffset.X;
		float y = WireUI_Layout.Instance.BackingTLOffset.Y;
		float x2 = WireUI_Layout.Instance.BackingTLOffset.X;
		float y2 = WireUI_Layout.Instance.BackingTLOffset.Y;
		float x3 = WireUI_Layout.Instance.BackingBROffset.X;
		float y3 = WireUI_Layout.Instance.BackingBROffset.Y;
		float x4 = WireUI_Layout.Instance.TouchPanelOffset.X;
		float y4 = WireUI_Layout.Instance.TouchPanelOffset.Y;
		return region;
	}

	// Token: 0x04000B0A RID: 2826
	private int hoverItem = 1;

	// Token: 0x04000B0B RID: 2827
	public Microsoft.Xna.Framework.Vector2 PopupPosition;

	// Token: 0x04000B0C RID: 2828
	private float[] ButtonScales;

	// Token: 0x04000B0D RID: 2829
	private float TimeSinceChange;

	// Token: 0x04000B0E RID: 2830
	private float ToggleButtonScale;

	// Token: 0x04000B0F RID: 2831
	public bool DisplayOptions;

	// Token: 0x04000B10 RID: 2832
	public GUIControllerWiresUI _controller;

	// Token: 0x04000B11 RID: 2833
	public GUIInputRegionExclusive PickingInterceptor;
}
