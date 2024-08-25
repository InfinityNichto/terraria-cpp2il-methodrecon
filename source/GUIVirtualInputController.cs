using System;
using System.Runtime.InteropServices;
using Controller;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.GameContent.UI;
using Terraria.GameInput;

// Token: 0x02000175 RID: 373
public class GUIVirtualInputController
{
	// Token: 0x06000A90 RID: 2704 RVA: 0x00033644 File Offset: 0x00031844
	public GUIVirtualInputController()
	{
		int num = 1;
		this.StashCraftedItems = num != 0;
		int num2 = 44564;
		int num3 = 16256;
		int num4 = 16000;
		int num5 = 257;
		this.VirtualControlScale = (float)num3;
		this.AimScale = (float)num4;
		this.AimAxisSnapStarted = num5 != 0;
		this.deadZone = (float)num2;
		int num6 = 17096;
		this.TimeSinceModifyZoom = (float)num6;
		base..ctor();
		CursorInputLayer inputLayer = this._inputLayer;
		int num7 = 100;
		inputLayer.Priority = num7;
		CursorInputLayer inputLayer2 = this._inputLayer2;
		int num8 = 85;
		inputLayer2.Priority = num8;
	}

	// Token: 0x06000A91 RID: 2705 RVA: 0x000336E0 File Offset: 0x000318E0
	public static void LoadContent(ContentManager content)
	{
		Texture2D texture2D = content.Load<Texture2D>("Images/UI/VirtualControls/Nav_NoBacking");
		Texture2D texture2D2 = content.Load<Texture2D>("Images/UI/VirtualControls/Icon_Movement");
		Texture2D texture2D3 = content.Load<Texture2D>("Images/UI/VirtualControls/Crosshair");
	}

	// Token: 0x17000112 RID: 274
	// (get) Token: 0x06000A92 RID: 2706 RVA: 0x00033714 File Offset: 0x00031914
	private bool HasGrapple
	{
		get
		{
			/*
An exception occurred when decompiling this method (06000A92)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIVirtualInputController::get_HasGrapple()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_1_0A, callgetter:int32(Main::get_myPlayer))
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
	}

	// Token: 0x17000113 RID: 275
	// (get) Token: 0x06000A93 RID: 2707 RVA: 0x0003372C File Offset: 0x0003192C
	public bool JumpTapPressed
	{
		get
		{
			/*
An exception occurred when decompiling this method (06000A93)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIVirtualInputController::get_JumpTapPressed()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](GUIVirtualInputController::movementAxis, ldloc:GUIVirtualInputController(this))))
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
	}

	// Token: 0x17000114 RID: 276
	// (get) Token: 0x06000A94 RID: 2708 RVA: 0x00033744 File Offset: 0x00031944
	public bool WasJumpTapPressed
	{
		get
		{
			/*
An exception occurred when decompiling this method (06000A94)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIVirtualInputController::get_WasJumpTapPressed()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:int32(var_0_01, ldc.i4:int32(1))
	stloc:int32(var_1_08, ldfld:int32(GUIVirtualInputController::previousMovementLastFrame, ldloc:GUIVirtualInputController(this)))
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
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

	// Token: 0x06000A95 RID: 2709 RVA: 0x0003375C File Offset: 0x0003195C
	private void UpdateMovementAxis(Vector2 rawAxis)
	{
		if (!true)
		{
		}
		if (!true)
		{
		}
		if (!true)
		{
		}
		if (this.Pressed == null)
		{
		}
		if (!true)
		{
		}
		if (this.Pressed == null)
		{
		}
		if (!true)
		{
		}
		float y = this.movementAxis.Y;
		if (this.Pressed == null)
		{
		}
		if (!true)
		{
		}
		float y2 = this.movementAxis.Y;
		bool[] pressed = this.Pressed;
	}

	// Token: 0x06000A96 RID: 2710 RVA: 0x000337E0 File Offset: 0x000319E0
	private void UpdateFireAxis(Vector2 rawAxis)
	{
		int num = 1;
		this.anyActive = num != 0;
		this.fireAxisFiring = num != 0;
	}

	// Token: 0x06000A97 RID: 2711 RVA: 0x00033800 File Offset: 0x00031A00
	private void HideNotifications()
	{
	}

	// Token: 0x06000A98 RID: 2712 RVA: 0x00033810 File Offset: 0x00031A10
	private void AddInteractBanner(Player player, Item item)
	{
		if (!true)
		{
		}
		bool gameMenu = Main.gameMenu;
	}

	// Token: 0x06000A99 RID: 2713 RVA: 0x00033A38 File Offset: 0x00031C38
	public void ResetSMCurosrNotification()
	{
	}

	// Token: 0x06000A9A RID: 2714 RVA: 0x00033A48 File Offset: 0x00031C48
	private static bool CanInteract(Player player, Item item)
	{
		if (!true)
		{
		}
		bool gameMenu = Main.gameMenu;
		NPC mouseNPC = GUIQuickActionButton.GetMouseNPC();
		int myPlayer = Main.myPlayer;
		bool drawToolModeUI = WiresUI.Settings.DrawToolModeUI;
		bool drawRubbleModeUI = GUIRubbleMaker.DrawRubbleModeUI;
		bool smartInteractShowingGenuine = Main.SmartInteractShowingGenuine;
		float drainBoost;
		if (mouseNPC != null)
		{
			drainBoost = player.drainBoost;
			while (drainBoost == null)
			{
			}
		}
		if (drainBoost == null)
		{
		}
		int signHover = Main.signHover;
		if (drainBoost == null)
		{
		}
		int signHover2 = Main.signHover;
		if (drainBoost != null)
		{
			float drainBoost2 = player.drainBoost;
			if (drainBoost2 == null)
			{
				if (drainBoost2 == null)
				{
				}
				int signHover3 = Main.signHover;
				int signHover4 = Main.signHover;
				Tile tile;
				ushort type = tile.type;
			}
		}
		int tileTargetX = Player.tileTargetX;
		int tileTargetY = Player.tileTargetY;
		bool flag = Minecart.CanSwitchTrack(tileTargetX, tileTargetY);
		float drainBoost3 = player.drainBoost;
		while (drainBoost3 == null)
		{
		}
		if (drainBoost3 == null)
		{
		}
		int tileTargetX2 = Player.tileTargetX;
		int tileTargetY2 = Player.tileTargetY;
		Tile tile2;
		ushort type2 = tile2.type;
		int tileTargetX3 = Player.tileTargetX;
		int tileTargetY3 = Player.tileTargetY;
		Tile tile3;
		ushort type3 = tile3.type;
		int tileTargetX4 = Player.tileTargetX;
		int tileTargetY4 = Player.tileTargetY;
		Tile tile4;
		ushort type4 = tile4.type;
		return WiresUI.Settings.DrawToolModeUI;
	}

	// Token: 0x06000A9B RID: 2715 RVA: 0x00033B84 File Offset: 0x00031D84
	public Vector2 GetPressedControlPosition(VirtualControlsHardwareConfigurationMapping_Layout.ContolType controlType, [Out] VirtualControlsHardwareConfigurationMapping_Layout slotConfiguration)
	{
		if (!true)
		{
		}
		if (!true)
		{
		}
		VirtualControlsProfile_Layout virtualControlsProfile_Layout;
		VirtualControlsHardwareConfiguration_Layout hardwareConfig = virtualControlsProfile_Layout.HardwareConfig;
		if (hardwareConfig != null)
		{
			Cursor cursor;
			CursorInputLayer inputLayer = cursor.InputLayer;
			CursorInputLayer inputLayer2 = this._inputLayer;
			int num;
			while (num == 0)
			{
			}
			Type type = num.GetType();
			if (inputLayer2 == null)
			{
			}
			Type type2;
			bool flag = type == type2;
			VirtualControlsProfile_Layout virtualControlsProfile_Layout2;
			VirtualControlsHardwareConfigurationMapping_Layout.ContolType action = virtualControlsProfile_Layout2.Controls.Action;
			VirtualControlsHardwareConfigurationMapping_Layout.ContolType defaultControl = hardwareConfig.Slots.DefaultControl;
		}
		throw new InvalidCastException();
	}

	// Token: 0x06000A9C RID: 2716 RVA: 0x00033BF0 File Offset: 0x00031DF0
	public void Update(float elapsedTime)
	{
		int num = 1;
		if (num == 0)
		{
		}
		bool gameMenu = Main.gameMenu;
		if (num == 0)
		{
		}
		int myPlayer = Main.myPlayer;
		float timeSinceToggleSmartCursor = this.TimeSinceToggleSmartCursor;
		this.TimeSinceToggleSmartCursor = timeSinceToggleSmartCursor;
		float timeSinceToggleAutoFire = this.TimeSinceToggleAutoFire;
		this.TimeSinceToggleAutoFire = timeSinceToggleAutoFire;
		float timeSinceModifyZoom = this.TimeSinceModifyZoom;
		this.TimeSinceModifyZoom = timeSinceModifyZoom;
		float timeSinceProfileChanged = this.TimeSinceProfileChanged;
		this.TimeSinceProfileChanged = timeSinceProfileChanged;
		bool[] pressed = this.Pressed;
		bool[] wasPressed = this.WasPressed;
		bool flag = this.movementAxisActive;
		bool flag2 = this.grappleAxisActive;
		bool flag3 = this.fireAxisActive;
		bool flag4 = this.fireButtonFiring;
		this.wasMovementAxisActive = flag;
		this.wasGrappleAxisActive = flag2;
		Vector2 vector = this.grappleAxis;
		this.previousGrappleAxis = vector;
		if (vector == null)
		{
		}
		if (true)
		{
			return;
		}
		Vector2 vector2 = this.movementAxis;
		Vector2 vector3 = this.gridSnapAxis;
		this.previousMovementAxis = vector2;
		this.previousGridSnapAxis = vector3;
		if (true)
		{
			return;
		}
		if (true)
		{
			return;
		}
		if (!true)
		{
		}
		bool gameMenu2 = Main.gameMenu;
		int myPlayer2 = Main.myPlayer;
		int myPlayer3 = Main.myPlayer;
		if (this.AutoControlEnabled)
		{
			if (LockOnHelper.AimedTarget != null)
			{
				bool[] pressed2 = this.Pressed;
				if (this.WasPressed == null)
				{
					return;
				}
			}
			else
			{
				float autoControlTimer = this.AutoControlTimer;
				this.AutoControlTimer = autoControlTimer;
			}
		}
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		bool mapFullscreen = Main.mapFullscreen;
		bool gameMenu3 = Main.gameMenu;
	}

	// Token: 0x06000A9D RID: 2717 RVA: 0x00034998 File Offset: 0x00032B98
	private void HandleCursorGridSnap(bool tileBoostWholeScreen, int screenCenterX, int screenCenterY, int tB, float MouseX, float MouseY)
	{
		if (!true)
		{
		}
		if (this.gridSnapUp)
		{
		}
		if (this.gridSnapDown)
		{
		}
		if (this.gridSnapLeft)
		{
		}
		if (this.gridSnapRight)
		{
		}
		int tileRangeX = Player.tileRangeX;
		int tileRangeY = Player.tileRangeY;
	}

	// Token: 0x06000A9E RID: 2718 RVA: 0x00034A28 File Offset: 0x00032C28
	private void HandleGridSnapCursorMovement(Item selectedItem, int screenCenterX, int screenCenterY, int tB, float MouseX, float MouseY)
	{
		if (!true)
		{
		}
		float x;
		float y;
		int lastScreenCentreX;
		if (this.lastGridAimMode)
		{
			int lastWorldPositionX = this.LastWorldPositionX;
			int lastCursorPositionX = this.LastCursorPositionX;
			x = this.LastResultPosition.X;
			y = this.LastResultPosition.Y;
			lastScreenCentreX = this.LastScreenCentreX;
			return;
		}
		int num = 15744;
		int num2 = 32768;
		this.LastWorldPositionX = num;
		this.LastCursorPositionX = num2;
		this.LastAimNavTickPosition = lastScreenCentreX;
		this.LastScreenCentreX = screenCenterX;
		this.deadZone = (float)screenCenterY;
		this.LastAimNavTickPosition.Y = (float)lastScreenCentreX;
		Vector2 lastAimNavTickPosition = this.LastAimNavTickPosition;
		this.LastAimNavTickPositionStart = lastAimNavTickPosition;
		this.LastResultPosition = lastAimNavTickPosition;
		float x2 = this.WorldBlendOffset.X;
		this.LastResultPosition.X = x;
		this.LastResultPosition.Y = y;
	}

	// Token: 0x06000A9F RID: 2719 RVA: 0x00034DD0 File Offset: 0x00032FD0
	private Vector2 FilterFireAxis(Vector2 fireAxis)
	{
		float num = this.deadZone;
		Vector2 vector;
		return vector;
	}

	// Token: 0x06000AA0 RID: 2720 RVA: 0x00034DEC File Offset: 0x00032FEC
	private void UpdateCursorMovement()
	{
		int num = 1;
		if (num == 0)
		{
		}
		int myPlayer = Main.myPlayer;
		if (num == 0 && num == 0)
		{
			return;
		}
		Cursor cursor;
		if (cursor != null)
		{
			Cursor cursor2;
			if (!cursor2.Down)
			{
			}
			int worldMouseX = Main.worldMouseX;
			this.lastWorldCursorPointX = worldMouseX;
			int worldMouseY = Main.worldMouseY;
			this.lastWorldCursorPointY = worldMouseY;
			return;
		}
		if (this.wasWorldCursorActive)
		{
			return;
		}
		long num2 = 0L;
		this.wasWorldCursorActive = num2 != 0L;
		int num3;
		if (num3 == 0)
		{
		}
		float gamepadCursorAlpha = Main.GamepadCursorAlpha;
		float x = this.movementAxis.X;
		float y = this.movementAxis.Y;
		int num4 = 1;
		if (num4 == 0)
		{
		}
		int value = num4.m_value;
		bool leftStickAiming = this.LeftStickAiming;
		if (!leftStickAiming)
		{
			float x2 = this.fireAxis.X;
			float y2 = this.fireAxis.Y;
			if (!leftStickAiming)
			{
			}
			int num5 = 1;
			if (num5 == 0)
			{
			}
			int value2 = num5.m_value;
			if (num5 == 0)
			{
			}
			float num6;
			Main.GamepadCursorAlpha = num6;
			return;
		}
		bool flag;
		if (!flag)
		{
		}
		float num7;
		Main.GamepadCursorAlpha = num7;
		if (!flag)
		{
		}
		Vector2 screenPosition = Main.screenPosition;
		Vector2 screenPosition2 = Main.screenPosition;
		float screenYOffset = Main.screenYOffset;
		bool mapFullscreen = Main.mapFullscreen;
	}

	// Token: 0x17000115 RID: 277
	// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x000355C8 File Offset: 0x000337C8
	public bool InGameUIOpen
	{
		get
		{
			bool ingameOptionsWindow = Main.ingameOptionsWindow;
			bool inFancyUI = Main.inFancyUI;
			bool mapFullscreen = Main.mapFullscreen;
			return true;
		}
	}

	// Token: 0x06000AA2 RID: 2722 RVA: 0x000355FC File Offset: 0x000337FC
	public void SecondaryUpdateCursor(Cursor cursor)
	{
		if (52429 == 0)
		{
		}
		bool ignoreForWorld = cursor.IgnoreForWorld;
		if (!ignoreForWorld)
		{
			if (!ignoreForWorld)
			{
			}
			bool gameMenu = Main.gameMenu;
			if (cursor.InputLayer == null)
			{
				bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
				if (!true)
				{
				}
				VirtualControlsProfile_Layout virtualControlsProfile_Layout;
				VirtualControlsHardwareConfiguration_Layout hardwareConfig = virtualControlsProfile_Layout.HardwareConfig;
				bool mapFullscreen = Main.mapFullscreen;
				VirtualControlsHardwareConfigurationMapping_Layout[] slots2;
				if (hardwareConfig != null)
				{
					VirtualControlsSlotTypeMapping_Layout style = hardwareConfig.Slots.Style;
					VirtualControlsProfile_Layout virtualControlsProfile_Layout2;
					VirtualControlsBinding_Layout[] controls = virtualControlsProfile_Layout2.Controls;
					VirtualControlsHardwareConfigurationMapping_Layout[] slots = hardwareConfig.Slots;
					VirtualControlsHardwareConfigurationMapping_Layout.ContolType action = controls.Action;
					VirtualControlsButtonConfiguration_Layout virtualControlsButtonConfiguration_Layout;
					QuickActionButton_Layout tealLayout = virtualControlsButtonConfiguration_Layout.TealLayout;
					tealLayout.AnchorControl = (ControlAnchor.ControlId)action;
					tealLayout.Location = action;
					if (action == VirtualControlsHardwareConfigurationMapping_Layout.ContolType.AutoFire)
					{
					}
					CursorInputLayer inputLayer = this._inputLayer;
					cursor.InputLayer = inputLayer;
					slots2 = hardwareConfig.Slots;
				}
				if (slots2 == null)
				{
				}
				if (slots2 == null)
				{
				}
				return;
			}
		}
	}

	// Token: 0x06000AA3 RID: 2723 RVA: 0x000358F4 File Offset: 0x00033AF4
	private bool IsOverGroupRegion(GUIPageIconGrouping group, Point mousePoint)
	{
		GUIPageIcons.Category selectedCategory = group.SelectedCategory;
		group.LoadPageAnchor();
		float x = group.pageButtonRegionSize.X;
		float y = group.pageButtonRegionSize.Y;
		int size = group._options._size;
		int size2 = group.SettingEntries._size;
		RightSideHUDAnchorUpdator.Update();
		bool flag = group.GetRegion().Contains(mousePoint);
		group.LoadPageAnchor();
		float x2 = group.pageButtonRegionSize.X;
		float y2 = group.pageButtonRegionSize.Y;
		int size3 = group._options._size;
		int size4 = group.SettingEntries._size;
		group.LoadPageAnchor();
		GUIPageIcons.Category selectedCategory2 = group.SelectedCategory;
		!0 instance = PageControllerLayoutDefinition.Instance;
		Rectangle rectangle;
		bool flag2 = rectangle.Contains(mousePoint);
		!0 instance2 = PageControllerLayoutDefinition.Instance;
		Rectangle rectangle2;
		bool flag3 = rectangle2.Contains(mousePoint);
		!0 instance3 = PageControllerLayoutDefinition.Instance;
		Rectangle rectangle3;
		bool flag4 = rectangle3.Contains(mousePoint);
		!0 instance4 = PageControllerLayoutDefinition.Instance;
		Rectangle rectangle4;
		bool flag5 = rectangle4.Contains(mousePoint);
		int gameMode = Main.GameMode;
		InterfaceProfile_Layout active = InterfaceStyles_Layout.Active;
		InterfaceProfile_Layout active2 = InterfaceStyles_Layout.Active;
		GUIPageIconGrouping guipageIconGrouping;
		if (guipageIconGrouping != null)
		{
			GUIPageIconGrouping guipageIconGrouping2;
			while (guipageIconGrouping2 != null)
			{
			}
		}
		if (group.SelectedCategory == GUIPageIcons.Category.Crafting)
		{
			bool flag6;
			return flag6;
		}
		GUIPageIcons.Category category;
		return category.Collapsed;
	}

	// Token: 0x06000AA4 RID: 2724 RVA: 0x00035C30 File Offset: 0x00033E30
	public void UpdateCursor(Cursor cursor)
	{
		if (!true)
		{
		}
		bool gameMenu = Main.gameMenu;
		if (cursor.InputLayer == null)
		{
			bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
			if (!true)
			{
			}
			float x = cursor.Position.x;
			float y = cursor.Position.y;
			VirtualControlsProfile_Layout virtualControlsProfile_Layout;
			VirtualControlsHardwareConfiguration_Layout hardwareConfig = virtualControlsProfile_Layout.HardwareConfig;
			bool mapFullscreen = Main.mapFullscreen;
			VirtualControlsProfile_Layout virtualControlsProfile_Layout2;
			VirtualControlsHardwareConfigurationMapping_Layout.ContolType action = virtualControlsProfile_Layout2.Controls.Action;
			VirtualControlsButtonConfiguration_Layout virtualControlsButtonConfiguration_Layout;
			QuickActionButton_Layout tealLayout = virtualControlsButtonConfiguration_Layout.TealLayout;
			tealLayout.AnchorControl = (ControlAnchor.ControlId)action;
			tealLayout.Location = action;
			if (action == VirtualControlsHardwareConfigurationMapping_Layout.ContolType.AutoFire)
			{
			}
			CursorInputLayer inputLayer = this._inputLayer;
			cursor.InputLayer = inputLayer;
			if (inputLayer == null)
			{
			}
			if (inputLayer == null)
			{
			}
			return;
		}
	}

	// Token: 0x06000AA5 RID: 2725 RVA: 0x00035E24 File Offset: 0x00034024
	public void Draw()
	{
		bool gameMenu = Main.gameMenu;
		bool mapFullscreen = Main.mapFullscreen;
		bool gameMenu2 = Main.gameMenu;
		bool mapFullscreen2 = Main.mapFullscreen;
		this.DrawMapControls();
	}

	// Token: 0x06000AA6 RID: 2726 RVA: 0x00035EE8 File Offset: 0x000340E8
	private void DrawControlStringNotifications()
	{
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		int num = 584;
		float timeSinceToggleAutoFire = this.TimeSinceToggleAutoFire;
		if (num == 0)
		{
		}
		int num2 = 600;
		float timeSinceToggleSmartCursor = this.TimeSinceToggleSmartCursor;
		bool lockOnAvailable = LockOnHelper.LockOnAvailable;
		bool enabled = LockOnHelper.Enabled;
		if (num2 == 0)
		{
		}
	}

	// Token: 0x06000AA7 RID: 2727 RVA: 0x00035F90 File Offset: 0x00034190
	private void DrawControls()
	{
		VirtualControlsProfile_Layout virtualControlsProfile_Layout;
		VirtualControlsHardwareConfiguration_Layout hardwareConfig = virtualControlsProfile_Layout.HardwareConfig;
		if (hardwareConfig != null)
		{
			VirtualControlsSlotTypeMapping_Layout style = hardwareConfig.Slots.Style;
			VirtualControlsProfile_Layout virtualControlsProfile_Layout2;
			VirtualControlsHardwareConfigurationMapping_Layout.ContolType action = virtualControlsProfile_Layout2.Controls.Action;
			VirtualControlsHardwareConfigurationMapping_Layout[] slots = hardwareConfig.Slots;
			VirtualControlsHardwareConfigurationMapping_Layout.ContolType defaultControl = slots.DefaultControl;
			return;
		}
	}

	// Token: 0x06000AA8 RID: 2728 RVA: 0x0003633C File Offset: 0x0003453C
	private void DrawMapControls()
	{
	}

	// Token: 0x06000AA9 RID: 2729 RVA: 0x000363E8 File Offset: 0x000345E8
	public void Show()
	{
		this.Shown = true;
	}

	// Token: 0x06000AAA RID: 2730 RVA: 0x000363FC File Offset: 0x000345FC
	public void Hide()
	{
	}

	// Token: 0x06000AAB RID: 2731 RVA: 0x0003640C File Offset: 0x0003460C
	// Note: this type is marked as 'beforefieldinit'.
	static GUIVirtualInputController()
	{
	}

	// Token: 0x04000A7B RID: 2683
	private static Texture2D _directionArrow;

	// Token: 0x04000A7C RID: 2684
	private static Texture2D _jump;

	// Token: 0x04000A7D RID: 2685
	public static Texture2D _movement;

	// Token: 0x04000A7E RID: 2686
	public static Texture2D _autoFireOff;

	// Token: 0x04000A7F RID: 2687
	public bool ControllerActive;

	// Token: 0x04000A80 RID: 2688
	public bool AutoControlEnabled;

	// Token: 0x04000A81 RID: 2689
	public float AutoControlTimer;

	// Token: 0x04000A82 RID: 2690
	public bool AutoSelectToggleTouch;

	// Token: 0x04000A83 RID: 2691
	public bool AutoSelectToggleTouchValue;

	// Token: 0x04000A84 RID: 2692
	public bool AutoSelectToggleController;

	// Token: 0x04000A85 RID: 2693
	public bool AutoSelectToggleControllerValue;

	// Token: 0x04000A86 RID: 2694
	public bool AutoSelectToggleKeyboard;

	// Token: 0x04000A87 RID: 2695
	public bool AutoSelectToggleKeyboardValue;

	// Token: 0x04000A88 RID: 2696
	public bool EnableBuildGridSnap;

	// Token: 0x04000A89 RID: 2697
	public bool AimModeFreeMovement;

	// Token: 0x04000A8A RID: 2698
	public bool UseButtonPressed;

	// Token: 0x04000A8B RID: 2699
	public bool StashCraftedItems;

	// Token: 0x04000A8C RID: 2700
	private CursorInputLayer _inputLayer;

	// Token: 0x04000A8D RID: 2701
	private CursorInputLayer _inputLayer2;

	// Token: 0x04000A8E RID: 2702
	public VirtualInputController_Layout.ContolType[] Controls;

	// Token: 0x04000A8F RID: 2703
	public float VirtualControlScale;

	// Token: 0x04000A90 RID: 2704
	public GUIVirtualInputController.LeftStickJumpMode JumpMode;

	// Token: 0x04000A91 RID: 2705
	private int previousMovementLastFrame;

	// Token: 0x04000A92 RID: 2706
	private Vector2 lastFireAxisRaw;

	// Token: 0x04000A93 RID: 2707
	private const float numSteps = 1000f;

	// Token: 0x04000A94 RID: 2708
	private static Item emptyItem;

	// Token: 0x04000A95 RID: 2709
	private bool pulseLeft;

	// Token: 0x04000A96 RID: 2710
	private int pulseLeftTime;

	// Token: 0x04000A97 RID: 2711
	private bool pulseRight;

	// Token: 0x04000A98 RID: 2712
	private int pulseRightTime;

	// Token: 0x04000A99 RID: 2713
	private static int pulseTimer;

	// Token: 0x04000A9A RID: 2714
	private float cursorUpdateTime;

	// Token: 0x04000A9B RID: 2715
	private float LastOffsetX;

	// Token: 0x04000A9C RID: 2716
	private float LastOffsetY;

	// Token: 0x04000A9D RID: 2717
	private int LastFrameUpdate;

	// Token: 0x04000A9E RID: 2718
	private int LastSizeX;

	// Token: 0x04000A9F RID: 2719
	private int LastSizeY;

	// Token: 0x04000AA0 RID: 2720
	private float AimScale;

	// Token: 0x04000AA1 RID: 2721
	private float AimAxisActiveTime;

	// Token: 0x04000AA2 RID: 2722
	private float AimAxisStartX;

	// Token: 0x04000AA3 RID: 2723
	private float AimAxisStartY;

	// Token: 0x04000AA4 RID: 2724
	private float AimAxisTotalX;

	// Token: 0x04000AA5 RID: 2725
	private float AimAxisTotalY;

	// Token: 0x04000AA6 RID: 2726
	private bool AimAxisSnapStarted;

	// Token: 0x04000AA7 RID: 2727
	public bool LeftStickAiming;

	// Token: 0x04000AA8 RID: 2728
	public float ControllerAimSensitivity;

	// Token: 0x04000AA9 RID: 2729
	public float TouchAimSensitivity;

	// Token: 0x04000AAA RID: 2730
	private int InitialAimNavTick;

	// Token: 0x04000AAB RID: 2731
	public DateTime LastAimNavTickTime;

	// Token: 0x04000AAC RID: 2732
	private Vector2 LastAimNavTickPosition;

	// Token: 0x04000AAD RID: 2733
	private Vector2 LastAimNavTickPositionStart;

	// Token: 0x04000AAE RID: 2734
	private Vector2 LastResultPosition;

	// Token: 0x04000AAF RID: 2735
	private Vector2 WorldBlendOffset;

	// Token: 0x04000AB0 RID: 2736
	private bool lastGridAimMode;

	// Token: 0x04000AB1 RID: 2737
	private bool movingX;

	// Token: 0x04000AB2 RID: 2738
	private bool movingY;

	// Token: 0x04000AB3 RID: 2739
	private int movingOffsetX;

	// Token: 0x04000AB4 RID: 2740
	private int movingOffsetY;

	// Token: 0x04000AB5 RID: 2741
	private int LastWorldPositionX;

	// Token: 0x04000AB6 RID: 2742
	private int LastWorldPositionY;

	// Token: 0x04000AB7 RID: 2743
	private int LastCursorPositionX;

	// Token: 0x04000AB8 RID: 2744
	private int LastCursorPositionY;

	// Token: 0x04000AB9 RID: 2745
	private int LastScreenCentreX;

	// Token: 0x04000ABA RID: 2746
	private int LastScreenCentreY;

	// Token: 0x04000ABB RID: 2747
	private float deadZone;

	// Token: 0x04000ABC RID: 2748
	private bool wasWorldCursorActive;

	// Token: 0x04000ABD RID: 2749
	private int lastWorldCursorPointX;

	// Token: 0x04000ABE RID: 2750
	private int lastWorldCursorPointY;

	// Token: 0x04000ABF RID: 2751
	public bool wasMovementAxisActive;

	// Token: 0x04000AC0 RID: 2752
	public bool movementAxisActive;

	// Token: 0x04000AC1 RID: 2753
	public bool grappleAxisActive;

	// Token: 0x04000AC2 RID: 2754
	public bool wasGrappleAxisActive;

	// Token: 0x04000AC3 RID: 2755
	public bool grappleFired;

	// Token: 0x04000AC4 RID: 2756
	public bool fireAxisActive;

	// Token: 0x04000AC5 RID: 2757
	public bool grappleAxisPressed;

	// Token: 0x04000AC6 RID: 2758
	private bool fireAxisFiring;

	// Token: 0x04000AC7 RID: 2759
	public bool fireButtonFiring;

	// Token: 0x04000AC8 RID: 2760
	private bool fireFromHousing;

	// Token: 0x04000AC9 RID: 2761
	private bool anyActive;

	// Token: 0x04000ACA RID: 2762
	private Vector2 grappleAxis;

	// Token: 0x04000ACB RID: 2763
	private Vector2 previousGrappleAxis;

	// Token: 0x04000ACC RID: 2764
	private Vector2 movementAxis;

	// Token: 0x04000ACD RID: 2765
	private Vector2 previousMovementAxis;

	// Token: 0x04000ACE RID: 2766
	private Vector2 fireAxis;

	// Token: 0x04000ACF RID: 2767
	private Vector2 gridSnapAxis;

	// Token: 0x04000AD0 RID: 2768
	private Vector2 previousGridSnapAxis;

	// Token: 0x04000AD1 RID: 2769
	private bool gridSnapUp;

	// Token: 0x04000AD2 RID: 2770
	private bool gridSnapDown;

	// Token: 0x04000AD3 RID: 2771
	private bool gridSnapLeft;

	// Token: 0x04000AD4 RID: 2772
	private bool gridSnapRight;

	// Token: 0x04000AD5 RID: 2773
	private Vector2 movementAxisScreenOffset;

	// Token: 0x04000AD6 RID: 2774
	private Vector2 fireAxisScreenOffset;

	// Token: 0x04000AD7 RID: 2775
	private Vector2 grappleAxisScreenOffset;

	// Token: 0x04000AD8 RID: 2776
	private Vector2 previousGrappleAxisScreenOffset;

	// Token: 0x04000AD9 RID: 2777
	private Vector2 grappleAxisCentre;

	// Token: 0x04000ADA RID: 2778
	private Vector2 movementAxisCentre;

	// Token: 0x04000ADB RID: 2779
	private Vector2 fireAxisCentre;

	// Token: 0x04000ADC RID: 2780
	public bool[] Pressed;

	// Token: 0x04000ADD RID: 2781
	public bool[] WasPressed;

	// Token: 0x04000ADE RID: 2782
	public float[] Scale;

	// Token: 0x04000ADF RID: 2783
	private float TimeSinceToggleSmartCursor;

	// Token: 0x04000AE0 RID: 2784
	private float TimeSinceToggleAutoFire;

	// Token: 0x04000AE1 RID: 2785
	public float TimeSinceModifyZoom;

	// Token: 0x04000AE2 RID: 2786
	private float TimeSinceCombatTargeting;

	// Token: 0x04000AE3 RID: 2787
	private float TimeSinceProfileChanged;

	// Token: 0x04000AE4 RID: 2788
	public bool InventoryToggle;

	// Token: 0x04000AE5 RID: 2789
	private bool Shown;

	// Token: 0x02000176 RID: 374
	public enum LeftStickJumpMode
	{
		// Token: 0x04000AE7 RID: 2791
		DoubleTap,
		// Token: 0x04000AE8 RID: 2792
		SingleTap,
		// Token: 0x04000AE9 RID: 2793
		Up,
		// Token: 0x04000AEA RID: 2794
		Disabled
	}

	// Token: 0x02000177 RID: 375
	public enum ControlType
	{
		// Token: 0x04000AEC RID: 2796
		Left,
		// Token: 0x04000AED RID: 2797
		Right,
		// Token: 0x04000AEE RID: 2798
		Jump,
		// Token: 0x04000AEF RID: 2799
		Up,
		// Token: 0x04000AF0 RID: 2800
		Down,
		// Token: 0x04000AF1 RID: 2801
		Inventory,
		// Token: 0x04000AF2 RID: 2802
		QuickHeal,
		// Token: 0x04000AF3 RID: 2803
		QuickMana,
		// Token: 0x04000AF4 RID: 2804
		QuickMount,
		// Token: 0x04000AF5 RID: 2805
		QuickBuff,
		// Token: 0x04000AF6 RID: 2806
		Grapple,
		// Token: 0x04000AF7 RID: 2807
		Fire,
		// Token: 0x04000AF8 RID: 2808
		UseTileControl,
		// Token: 0x04000AF9 RID: 2809
		Interact,
		// Token: 0x04000AFA RID: 2810
		ZoomIn,
		// Token: 0x04000AFB RID: 2811
		ZoomOut,
		// Token: 0x04000AFC RID: 2812
		AutoFire,
		// Token: 0x04000AFD RID: 2813
		SmartCursor,
		// Token: 0x04000AFE RID: 2814
		InventoryToggle,
		// Token: 0x04000AFF RID: 2815
		AutoSelect,
		// Token: 0x04000B00 RID: 2816
		GrappleSelect,
		// Token: 0x04000B01 RID: 2817
		TargetLockOn,
		// Token: 0x04000B02 RID: 2818
		ProfileSwitch,
		// Token: 0x04000B03 RID: 2819
		UseButton,
		// Token: 0x04000B04 RID: 2820
		Settings,
		// Token: 0x04000B05 RID: 2821
		Loadout1,
		// Token: 0x04000B06 RID: 2822
		Loadout2,
		// Token: 0x04000B07 RID: 2823
		Loadout3,
		// Token: 0x04000B08 RID: 2824
		LoadoutCycle,
		// Token: 0x04000B09 RID: 2825
		Count
	}
}
