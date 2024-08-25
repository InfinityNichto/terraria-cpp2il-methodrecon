using System;
using Controller;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.UI;
using UnityEngine;

// Token: 0x0200009C RID: 156
public class GUIControllerNavigationController
{
	// Token: 0x1700007B RID: 123
	// (get) Token: 0x060003B4 RID: 948 RVA: 0x0000C194 File Offset: 0x0000A394
	public global::Cursor UICursor
	{
		get
		{
			if (this._currentNavigationItem != null)
			{
				return this.EmulatedCursor;
			}
		}
	}

	// Token: 0x060003B5 RID: 949 RVA: 0x0000C1B4 File Offset: 0x0000A3B4
	public void SetupMappings()
	{
		ControllerActionButton[] uiaction = this.UIAction;
		ControllerActionButton controllerActionButton;
		if (controllerActionButton == null || controllerActionButton != null)
		{
			uiaction.LinkedAction = controllerActionButton;
			ControllerActionButton controllerActionButton2;
			ControllerActionButton controllerActionButton3;
			ControllerActionButton controllerActionButton4;
			ControllerActionButton controllerActionButton5;
			ControllerActionButton controllerActionButton6;
			ControllerActionButton controllerActionButton7;
			ControllerActionButton controllerActionButton8;
			ControllerActionButton controllerActionButton9;
			ControllerActionButton controllerActionButton10;
			ControllerActionButton controllerActionButton11;
			ControllerActionButton controllerActionButton12;
			if ((controllerActionButton2 == null || controllerActionButton2 != null) && (controllerActionButton3 == null || controllerActionButton3 != null) && (controllerActionButton4 == null || controllerActionButton4 != null) && (controllerActionButton5 == null || controllerActionButton5 != null) && (controllerActionButton6 == null || controllerActionButton6 != null) && (controllerActionButton7 == null || controllerActionButton7 != null) && (controllerActionButton8 == null || controllerActionButton8 != null) && (controllerActionButton9 == null || controllerActionButton9 != null) && (controllerActionButton10 == null || controllerActionButton10 != null) && (controllerActionButton11 == null || controllerActionButton11 != null) && (controllerActionButton12 == null || controllerActionButton12 != null))
			{
				ControllerActionButton[] uiaction2 = this.UIAction;
				ControllerActionVector controllerActionVector;
				this.UIScrollAxis = controllerActionVector;
				ControllerActionButton controllerActionButton13;
				this.NextPage = controllerActionButton13;
				ControllerActionButton controllerActionButton14;
				this.PreviousPage = controllerActionButton14;
				ControllerActionButton controllerActionButton15;
				this.PlayFile = controllerActionButton15;
				ControllerActionButton controllerActionButton16;
				this.CloseFileMenu = controllerActionButton16;
				ControllerActionButton controllerActionButton17;
				this.DeleteFile = controllerActionButton17;
				ControllerActionButton controllerActionButton18;
				this.CloudFile = controllerActionButton18;
				ControllerActionButton controllerActionButton19;
				this.FavouriteFile = controllerActionButton19;
				ControllerActionButton controllerActionButton20;
				this.NewFile = controllerActionButton20;
				ControllerActionButton controllerActionButton21;
				this.Settings = controllerActionButton21;
				ControllerActionButton controllerActionButton22;
				this.Share = controllerActionButton22;
				ControllerActionButton controllerActionButton23;
				this.CycleLeftPage = controllerActionButton23;
				ControllerActionButton controllerActionButton24;
				this.CycleRightPage = controllerActionButton24;
				ControllerActionButton controllerActionButton25;
				this.Debug = controllerActionButton25;
				return;
			}
		}
		throw new ArrayTypeMismatchException();
	}

	// Token: 0x060003B6 RID: 950 RVA: 0x0000C2D8 File Offset: 0x0000A4D8
	public void Activate()
	{
		if (!true)
		{
		}
		DateTime now = DateTime.Now;
		GUIControllerItem currentNavigationItem = this._currentNavigationItem;
		this.NavigationTick = now;
		if (currentNavigationItem != null)
		{
			return;
		}
	}

	// Token: 0x1700007C RID: 124
	// (get) Token: 0x060003B7 RID: 951 RVA: 0x0000C304 File Offset: 0x0000A504
	public ControllerActionVector NavigationAxis
	{
		get
		{
			/*
An exception occurred when decompiling this method (060003B7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Controller.ControllerActionVector GUIControllerNavigationController::get_NavigationAxis()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:bool(var_1_0A, callgetter:bool(Main::get_gameMenu))
	stloc:bool(var_3_12, callgetter:bool(Main::get_inFancyUI))
	stloc:bool(var_5_1B, callgetter:bool(Main::get_mapFullscreen))
	stloc:bool(var_7_25, callgetter:bool(Main::get_hairWindow))
	stloc:bool(var_9_2F, callgetter:bool(Main::get_clothesWindow))
	stloc:bool(var_12_43, call:bool(string::op_Inequality, callgetter:string(Main::get_npcChatText), ldstr:string("")))
	stloc:int32(var_14_4D, callgetter:int32(Main::get_myPlayer))
	stloc:bool(var_16_57, callgetter:bool(Settings::get_DrawToolModeUI))
	stloc:bool(var_18_61, callgetter:bool(GUIRubbleMaker::get_DrawRubbleModeUI))
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

	// Token: 0x060003B8 RID: 952 RVA: 0x0000C374 File Offset: 0x0000A574
	public void UpdateUINavigation(float elapsedTime)
	{
		if (!true)
		{
		}
		bool gameMenu = Main.gameMenu;
		bool inFancyUI = Main.inFancyUI;
		bool mapFullscreen = Main.mapFullscreen;
		bool hairWindow = Main.hairWindow;
		bool clothesWindow = Main.clothesWindow;
		bool flag = Main.npcChatText != "";
		int myPlayer = Main.myPlayer;
		bool drawToolModeUI = WiresUI.Settings.DrawToolModeUI;
		bool drawRubbleModeUI = GUIRubbleMaker.DrawRubbleModeUI;
		bool[] uiactionWasPressed = this.UIActionWasPressed;
		bool[] uiactionPressed = this.UIActionPressed;
		ControllerDevice controllerDevice;
		bool buttonState = this.UIAction.LinkedAction.GetButtonState(controllerDevice);
		bool[] uiactionWasPressed2 = this.UIActionWasPressed;
		global::UnityEngine.Vector2 value = this.NavigationAxis.GetValue(controllerDevice);
		bool disableNavigation = this.DisableNavigation;
		if (!disableNavigation)
		{
			return;
		}
		if (this.DisableNavigationAxis == 0)
		{
			return;
		}
		bool[] uiactionPressed2 = this.UIActionPressed;
		if (this._currentNavigationItem != null)
		{
			if (uiactionPressed2 != null)
			{
			}
			return;
		}
		DateTime now = DateTime.Now;
		this.NavigationTick = now;
	}

	// Token: 0x060003B9 RID: 953 RVA: 0x0000C608 File Offset: 0x0000A808
	public void UpdateCursorPosition()
	{
		if (this._currentNavigationItem != null)
		{
			global::Cursor emulatedCursor = this.EmulatedCursor;
			global::UnityEngine.Vector2 position = emulatedCursor.Position;
			emulatedCursor.OldPosition = position;
			GUIControllerItem currentNavigationItem = this._currentNavigationItem;
			if (position != null)
			{
			}
			return;
		}
	}

	// Token: 0x1700007D RID: 125
	// (get) Token: 0x060003BA RID: 954 RVA: 0x0000C648 File Offset: 0x0000A848
	// (set) Token: 0x060003BB RID: 955 RVA: 0x0000C65C File Offset: 0x0000A85C
	public GUIControllerItem CurrentNavigationItem
	{
		get
		{
			return this._currentNavigationItem;
		}
		set
		{
			GUIControllerItem currentNavigationItem = this._currentNavigationItem;
			this._currentNavigationItem = value;
		}
	}

	// Token: 0x060003BC RID: 956 RVA: 0x0000C678 File Offset: 0x0000A878
	public void DisableNavigationFromAxis(int fromAxis = -1)
	{
		this.DisableNavigation = true;
		this.DisableNavigationAxis = fromAxis;
	}

	// Token: 0x060003BD RID: 957 RVA: 0x0000C694 File Offset: 0x0000A894
	public bool Pressed(GUIControllerInputButton.LinkedControlType action)
	{
		/*
An exception occurred when decompiling this method (060003BD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIControllerNavigationController::Pressed(GUIControllerInputButton/LinkedControlType)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool[](var_0_06, ldfld:bool[](GUIControllerNavigationController::UIActionPressed, ldloc:GUIControllerNavigationController(this)))
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

	// Token: 0x060003BE RID: 958 RVA: 0x0000C6A8 File Offset: 0x0000A8A8
	public bool Pressed(int action)
	{
		/*
An exception occurred when decompiling this method (060003BE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIControllerNavigationController::Pressed(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool[](var_0_06, ldfld:bool[](GUIControllerNavigationController::UIActionPressed, ldloc:GUIControllerNavigationController(this)))
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

	// Token: 0x060003BF RID: 959 RVA: 0x0000C6BC File Offset: 0x0000A8BC
	public bool PressedTriggered(GUIControllerInputButton.LinkedControlType action)
	{
		while (this.UIActionWasPressed == null)
		{
		}
	}

	// Token: 0x060003C0 RID: 960 RVA: 0x0000C6D4 File Offset: 0x0000A8D4
	public void ClearUIPressed()
	{
		bool[] uiactionWasPressed = this.UIActionWasPressed;
		bool[] uiactionPressed = this.UIActionPressed;
		if (this.EmulatedCursor == null)
		{
		}
		int num = 1;
		if (num == 0)
		{
		}
		if (num != 0)
		{
			Main.mouseLeft = false;
			Main.mouseLeftRelease = true;
			return;
		}
	}

	// Token: 0x060003C1 RID: 961 RVA: 0x0000C710 File Offset: 0x0000A910
	public bool PressedTriggered(int action)
	{
		while (this.UIActionWasPressed == null)
		{
		}
	}

	// Token: 0x060003C2 RID: 962 RVA: 0x0000C728 File Offset: 0x0000A928
	public bool PressedReleased(GUIControllerInputButton.LinkedControlType action)
	{
		if (this.UIActionWasPressed != null)
		{
			bool[] uiactionPressed = this.UIActionPressed;
			return;
		}
	}

	// Token: 0x060003C3 RID: 963 RVA: 0x0000C748 File Offset: 0x0000A948
	public bool PressedReleased(int action)
	{
		if (this.UIActionWasPressed != null)
		{
			bool[] uiactionPressed = this.UIActionPressed;
			return;
		}
	}

	// Token: 0x060003C4 RID: 964 RVA: 0x0000C768 File Offset: 0x0000A968
	public bool NextPagePressed()
	{
		ControllerDevice controllerDevice;
		return this.NextPage.GetButtonDown(controllerDevice);
	}

	// Token: 0x060003C5 RID: 965 RVA: 0x0000C784 File Offset: 0x0000A984
	public bool PreviousPagePressed()
	{
		ControllerDevice controllerDevice;
		return this.PreviousPage.GetButtonDown(controllerDevice);
	}

	// Token: 0x060003C6 RID: 966 RVA: 0x0000C7A0 File Offset: 0x0000A9A0
	public bool SettingsPressed()
	{
		ControllerDevice controllerDevice;
		return this.Settings.GetButtonUp(controllerDevice);
	}

	// Token: 0x060003C7 RID: 967 RVA: 0x0000C7BC File Offset: 0x0000A9BC
	public GUIControllerNavigationController()
	{
	}

	// Token: 0x04000394 RID: 916
	private global::Cursor EmulatedCursor;

	// Token: 0x04000395 RID: 917
	public float NavigationRepeatDelay;

	// Token: 0x04000396 RID: 918
	public float NavigationDelay;

	// Token: 0x04000397 RID: 919
	public float NavigationDelayToUse;

	// Token: 0x04000398 RID: 920
	public bool InitialNavigationMovement = true;

	// Token: 0x04000399 RID: 921
	public bool previousInteractionDownState;

	// Token: 0x0400039A RID: 922
	private Point lastPoint;

	// Token: 0x0400039B RID: 923
	public bool DisableNavigation;

	// Token: 0x0400039C RID: 924
	public int DisableNavigationAxis;

	// Token: 0x0400039D RID: 925
	public DateTime NavigationTick;

	// Token: 0x0400039E RID: 926
	public ControllerActionVector UINavigationAxis;

	// Token: 0x0400039F RID: 927
	public ControllerActionVector UIScrollAxis;

	// Token: 0x040003A0 RID: 928
	public ControllerActionButton[] UIAction;

	// Token: 0x040003A1 RID: 929
	public ControllerActionButton NextPage;

	// Token: 0x040003A2 RID: 930
	public ControllerActionButton PreviousPage;

	// Token: 0x040003A3 RID: 931
	public ControllerActionButton PlayFile;

	// Token: 0x040003A4 RID: 932
	public ControllerActionButton DeleteFile;

	// Token: 0x040003A5 RID: 933
	public ControllerActionButton CloudFile;

	// Token: 0x040003A6 RID: 934
	public ControllerActionButton FavouriteFile;

	// Token: 0x040003A7 RID: 935
	public ControllerActionButton NewFile;

	// Token: 0x040003A8 RID: 936
	public ControllerActionButton CloseFileMenu;

	// Token: 0x040003A9 RID: 937
	public ControllerActionButton Settings;

	// Token: 0x040003AA RID: 938
	public ControllerActionButton Share;

	// Token: 0x040003AB RID: 939
	public ControllerActionButton CycleLeftPage;

	// Token: 0x040003AC RID: 940
	public ControllerActionButton CycleRightPage;

	// Token: 0x040003AD RID: 941
	public ControllerActionButton Debug;

	// Token: 0x040003AE RID: 942
	public bool[] UIActionWasPressed;

	// Token: 0x040003AF RID: 943
	public bool[] UIActionPressed;

	// Token: 0x040003B0 RID: 944
	private GUIControllerItem _currentNavigationItem;

	// Token: 0x0200009D RID: 157
	public enum InteractionMode
	{

	}
}
