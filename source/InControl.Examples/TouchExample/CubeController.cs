using System;
using InControl;
using UnityEngine;

namespace TouchExample
{
	// Token: 0x02000004 RID: 4
	public class CubeController : MonoBehaviour
	{
		// Token: 0x0600000D RID: 13 RVA: 0x000023F4 File Offset: 0x000005F4
		private void Start()
		{
			Renderer component = base.GetComponent<Renderer>();
			this.cachedRenderer = component;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002410 File Offset: 0x00000610
		private void Update()
		{
			if (!true)
			{
			}
			InputDevice activeDevice = InputManager.ActiveDevice;
			InputDevice device = TouchManager.Device;
			TouchManager.ControlsEnabled = false;
			Material material = this.cachedRenderer.material;
			Color colorFromActionButtons = CubeController.GetColorFromActionButtons(activeDevice);
			Transform transform = base.transform;
			float deltaTime = Time.deltaTime;
			float <X>k__BackingField = activeDevice.Direction.<X>k__BackingField;
			Transform transform2 = base.transform;
			float deltaTime2 = Time.deltaTime;
			float <Y>k__BackingField = activeDevice.Direction.<Y>k__BackingField;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000248C File Offset: 0x0000068C
		private static Color GetColorFromActionButtons(InputDevice inputDevice)
		{
			/*
An exception occurred when decompiling this method (0600000F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Color TouchExample.CubeController::GetColorFromActionButtons(InControl.InputDevice)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_1_06, call:bool(OneAxisInputControl::op_Implicit, ldloc:InputControl[exp:OneAxisInputControl](var_0)))
	stloc:bool(var_3_0D, call:bool(OneAxisInputControl::op_Implicit, ldloc:InputControl[exp:OneAxisInputControl](var_2)))
	stloc:bool(var_5_15, call:bool(OneAxisInputControl::op_Implicit, ldloc:InputControl[exp:OneAxisInputControl](var_4)))
	stloc:bool(var_7_1E, call:bool(OneAxisInputControl::op_Implicit, ldloc:InputControl[exp:OneAxisInputControl](var_6)))
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

		// Token: 0x06000010 RID: 16 RVA: 0x000024B8 File Offset: 0x000006B8
		private void OnGUI()
		{
			int touchCount = TouchManager.TouchCount;
			global::InControl.Touch touch = TouchManager.GetTouch(0);
			string text2;
			string text3;
			string text = text2 + ": fingerId = " + text3;
			TouchPhase phase = touch.phase;
			string text5;
			string text4 = text + ", phase = " + text5;
			Vector2 startPosition = touch.startPosition;
			string text7;
			string text6 = text4 + ", startPosition = " + text7;
			Vector2 position = touch.position;
			string text9;
			string text8 = text6 + ", position = " + text9;
			bool isMouse = touch.IsMouse;
			string text11;
			string text10 = text8 + ", mouseButton = " + text11;
			int width = Screen.width;
			if (position == null)
			{
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002554 File Offset: 0x00000754
		public CubeController()
		{
		}

		// Token: 0x0400000A RID: 10
		private Renderer cachedRenderer;
	}
}
