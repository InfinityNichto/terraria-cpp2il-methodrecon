using System;
using Cpp2IlInjected;
using InControl;
using UnityEngine;

namespace VirtualDeviceExample
{
	// Token: 0x02000002 RID: 2
	public class VirtualDevice : InputDevice
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public VirtualDevice()
		{
			if (!true)
			{
			}
			base..ctor("Virtual Controller");
			InputControl inputControl = base.AddControl(InputControlType.LeftStickLeft, "Left Stick Left");
			InputControl inputControl2 = base.AddControl(InputControlType.LeftStickRight, "Left Stick Right");
			InputControl inputControl3 = base.AddControl(InputControlType.LeftStickUp, "Left Stick Up");
			InputControl inputControl4 = base.AddControl(InputControlType.LeftStickDown, "Left Stick Down");
			InputControl inputControl5 = base.AddControl(InputControlType.RightStickLeft, "Right Stick Left");
			InputControl inputControl6 = base.AddControl(InputControlType.RightStickRight, "Right Stick Right");
			InputControl inputControl7 = base.AddControl(InputControlType.RightStickUp, "Right Stick Up");
			InputControl inputControl8 = base.AddControl(InputControlType.RightStickDown, "Right Stick Down");
			InputControl inputControl9 = base.AddControl(InputControlType.Action1, "A");
			InputControl inputControl10 = base.AddControl(InputControlType.Action2, "B");
			InputControl inputControl11 = base.AddControl(InputControlType.Action3, "X");
			InputControl inputControl12 = base.AddControl(InputControlType.Action4, "Y");
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002114 File Offset: 0x00000314
		public override void Update(ulong updateTick, float deltaTime)
		{
			Vector2 vectorFromKeyboard = this.GetVectorFromKeyboard(deltaTime, true);
			Vector2 vectorFromMouse = this.GetVectorFromMouse(deltaTime, true);
			long num = 0L;
			bool key = Input.GetKey(KeyCode.Space);
			base.UpdateWithState(InputControlType.Action1, num != 0L, updateTick, deltaTime);
			bool key2 = Input.GetKey(KeyCode.S);
			base.UpdateWithState(InputControlType.Action2, num != 0L, updateTick, deltaTime);
			bool key3 = Input.GetKey(KeyCode.D);
			base.UpdateWithState(InputControlType.Action3, num != 0L, updateTick, deltaTime);
			bool key4 = Input.GetKey(KeyCode.F);
			base.UpdateWithState(InputControlType.Action4, num != 0L, updateTick, deltaTime);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002184 File Offset: 0x00000384
		private Vector2 GetVectorFromKeyboard(float deltaTime, bool smoothed)
		{
			/*
An exception occurred when decompiling this method (06000003)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Vector2 VirtualDeviceExample.VirtualDevice::GetVectorFromKeyboard(System.Single,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(VirtualDevice::kx, ldloc:VirtualDevice(this)))
	stloc:bool(var_1_11, call:bool(Input::GetKey, ldc.i4:KeyCode(276)))
	stloc:bool(var_2_1C, call:bool(Input::GetKey, ldc.i4:KeyCode(275)))
	stloc:float32(var_4_23, ldfld:float32(VirtualDevice::ky, ldloc:VirtualDevice(this)))
	stloc:bool(var_5_2F, call:bool(Input::GetKey, ldc.i4:KeyCode(273)))
	stloc:bool(var_6_3B, call:bool(Input::GetKey, ldc.i4:KeyCode(274)))
	stloc:bool(var_8_47, call:bool(Input::GetKey, ldc.i4:KeyCode(276)))
	stloc:bool(var_9_53, call:bool(Input::GetKey, ldc.i4:KeyCode(275)))
	stloc:bool(var_10_5F, call:bool(Input::GetKey, ldc.i4:KeyCode(273)))
	stloc:bool(var_11_6B, call:bool(Input::GetKey, ldc.i4:KeyCode(274)))
	stloc:float32(var_12_73, ldfld:float32(VirtualDevice::kx, ldloc:VirtualDevice(this)))
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

		// Token: 0x06000004 RID: 4 RVA: 0x00002208 File Offset: 0x00000408
		private static float GetXFromKeyboard()
		{
			/*
An exception occurred when decompiling this method (06000004)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single VirtualDeviceExample.VirtualDevice::GetXFromKeyboard()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_0A, call:bool(Input::GetKey, ldc.i4:KeyCode(276)))
	stloc:bool(var_1_15, call:bool(Input::GetKey, ldc.i4:KeyCode(275)))
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

		// Token: 0x06000005 RID: 5 RVA: 0x0000222C File Offset: 0x0000042C
		private static float GetYFromKeyboard()
		{
			/*
An exception occurred when decompiling this method (06000005)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single VirtualDeviceExample.VirtualDevice::GetYFromKeyboard()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_0A, call:bool(Input::GetKey, ldc.i4:KeyCode(273)))
	stloc:bool(var_1_15, call:bool(Input::GetKey, ldc.i4:KeyCode(274)))
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

		// Token: 0x06000006 RID: 6 RVA: 0x00002250 File Offset: 0x00000450
		private Vector2 GetVectorFromMouse(float deltaTime, bool smoothed)
		{
			/*
An exception occurred when decompiling this method (06000006)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Vector2 VirtualDeviceExample.VirtualDevice::GetVectorFromMouse(System.Single,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(VirtualDevice::mx, ldloc:VirtualDevice(this)))
	stloc:float32(var_1_11, call:float32(Input::GetAxisRaw, ldstr:string("mouse x")))
	stloc:float32(var_3_18, ldfld:float32(VirtualDevice::my, ldloc:VirtualDevice(this)))
	stloc:float32(var_4_23, call:float32(Input::GetAxisRaw, ldstr:string("mouse y")))
	stloc:float32(var_7_2F, call:float32(Input::GetAxisRaw, ldstr:string("mouse y")))
	stloc:float32(var_8_37, ldfld:float32(VirtualDevice::mx, ldloc:VirtualDevice(this)))
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

		// Token: 0x06000007 RID: 7 RVA: 0x00002295 File Offset: 0x00000495
		private static float ApplySmoothing(float lastValue, float thisValue, float deltaTime, float sensitivity)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x04000001 RID: 1
		private const float Sensitivity = 0.1f;

		// Token: 0x04000002 RID: 2
		private const float MouseScale = 0.05f;

		// Token: 0x04000003 RID: 3
		private float kx;

		// Token: 0x04000004 RID: 4
		private float ky;

		// Token: 0x04000005 RID: 5
		private float mx;

		// Token: 0x04000006 RID: 6
		private float my;
	}
}
