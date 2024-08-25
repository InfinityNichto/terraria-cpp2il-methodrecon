using System;
using Cpp2IlInjected;
using InControl;

namespace Controller
{
	// Token: 0x02000B61 RID: 2913
	public class ControllerDevice
	{
		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06005499 RID: 21657 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x0600549A RID: 21658 RVA: 0x002865F0 File Offset: 0x002847F0
		public static bool SwapBumpersTriggers
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x0600549B RID: 21659 RVA: 0x00286600 File Offset: 0x00284800
		public ControllerDevice(InputDevice device)
		{
			this.Device = device;
			InputControl inputControl;
			string <Handle>k__BackingField = inputControl.<Handle>k__BackingField;
			InputDevice device2 = this.Device;
			InputControl inputControl2;
			string <Handle>k__BackingField2 = inputControl2.<Handle>k__BackingField;
			InputDevice device3 = this.Device;
			InputControl inputControl3;
			string <Handle>k__BackingField3 = inputControl3.<Handle>k__BackingField;
			InputDevice device4 = this.Device;
			InputControl inputControl4;
			string <Handle>k__BackingField4 = inputControl4.<Handle>k__BackingField;
			if (device != null)
			{
			}
			InputDeviceStyle <DeviceStyle>k__BackingField = this.Device.<DeviceStyle>k__BackingField;
		}

		// Token: 0x0600549C RID: 21660 RVA: 0x00286768 File Offset: 0x00284968
		public ControllerDevice(InputDevice leftDevice, InputDevice rightDevice)
		{
			this.Device = leftDevice;
			this.Device2 = rightDevice;
			this.Controls = ControllerDevice.ControlScheme.CONTROLS_SWITCH;
		}

		// Token: 0x0600549D RID: 21661 RVA: 0x00286790 File Offset: 0x00284990
		public ControllerDevice()
		{
		}

		// Token: 0x0600549E RID: 21662 RVA: 0x002867A4 File Offset: 0x002849A4
		public bool HasAxis(Axis axis)
		{
			return true;
		}

		// Token: 0x0600549F RID: 21663 RVA: 0x002867B4 File Offset: 0x002849B4
		public bool HasButton(Buttons button)
		{
			return true;
		}

		// Token: 0x060054A0 RID: 21664 RVA: 0x002867C4 File Offset: 0x002849C4
		public float GetAxis(Axis axis)
		{
			/*
An exception occurred when decompiling this method (060054A0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Controller.ControllerDevice::GetAxis(Controller.Axis)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32[](var_0_06, ldfld:float32[](ControllerDevice::AxisValue, ldloc:ControllerDevice(this)))
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

		// Token: 0x060054A1 RID: 21665 RVA: 0x002867D8 File Offset: 0x002849D8
		public float GetAxisTime(Axis axis)
		{
			/*
An exception occurred when decompiling this method (060054A1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Controller.ControllerDevice::GetAxisTime(Controller.Axis)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32[](var_0_06, ldfld:float32[](ControllerDevice::_AxisTime, ldloc:ControllerDevice(this)))
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

		// Token: 0x060054A2 RID: 21666 RVA: 0x002867EC File Offset: 0x002849EC
		public float GetAxisScaled(Axis axis)
		{
			/*
An exception occurred when decompiling this method (060054A2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Controller.ControllerDevice::GetAxisScaled(Controller.Axis)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32[](var_0_06, ldfld:float32[](ControllerDevice::AxisValueScaled, ldloc:ControllerDevice(this)))
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

		// Token: 0x060054A3 RID: 21667 RVA: 0x00286800 File Offset: 0x00284A00
		public float GetPreviousAxis(Axis axis)
		{
			/*
An exception occurred when decompiling this method (060054A3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Controller.ControllerDevice::GetPreviousAxis(Controller.Axis)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32[](var_0_06, ldfld:float32[](ControllerDevice::PreviousAxisValue, ldloc:ControllerDevice(this)))
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

		// Token: 0x060054A4 RID: 21668 RVA: 0x00286814 File Offset: 0x00284A14
		public float GetPreviousAxisScaled(Axis axis)
		{
			/*
An exception occurred when decompiling this method (060054A4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Controller.ControllerDevice::GetPreviousAxisScaled(Controller.Axis)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32[](var_0_06, ldfld:float32[](ControllerDevice::PreviousAxisValueScaled, ldloc:ControllerDevice(this)))
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

		// Token: 0x060054A5 RID: 21669 RVA: 0x00286828 File Offset: 0x00284A28
		public float ButtonTime(Buttons key)
		{
			/*
An exception occurred when decompiling this method (060054A5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Controller.ControllerDevice::ButtonTime(Controller.Buttons)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32[](var_0_06, ldfld:float32[](ControllerDevice::_KeyTime, ldloc:ControllerDevice(this)))
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

		// Token: 0x060054A6 RID: 21670 RVA: 0x0028683C File Offset: 0x00284A3C
		public bool ButtonConsumed(Buttons key)
		{
			/*
An exception occurred when decompiling this method (060054A6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Controller.ControllerDevice::ButtonConsumed(Controller.Buttons)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool[](var_0_06, ldfld:bool[](ControllerDevice::_KeyConsumed, ldloc:ControllerDevice(this)))
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

		// Token: 0x060054A7 RID: 21671 RVA: 0x00286850 File Offset: 0x00284A50
		public void SetButtonConsumbed(Buttons key)
		{
			bool[] keyConsumed = this._KeyConsumed;
		}

		// Token: 0x060054A8 RID: 21672 RVA: 0x00286868 File Offset: 0x00284A68
		public bool ButtonState(Buttons key)
		{
			/*
An exception occurred when decompiling this method (060054A8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Controller.ControllerDevice::ButtonState(Controller.Buttons)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool[](var_0_06, ldfld:bool[](ControllerDevice::_KeyState, ldloc:ControllerDevice(this)))
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

		// Token: 0x060054A9 RID: 21673 RVA: 0x0028687C File Offset: 0x00284A7C
		public bool PreviousButtonState(Buttons key)
		{
			/*
An exception occurred when decompiling this method (060054A9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Controller.ControllerDevice::PreviousButtonState(Controller.Buttons)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool[](var_0_06, ldfld:bool[](ControllerDevice::_PreviousKeyState, ldloc:ControllerDevice(this)))
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

		// Token: 0x060054AA RID: 21674 RVA: 0x00286890 File Offset: 0x00284A90
		public bool ButtonUp(Buttons key)
		{
			/*
An exception occurred when decompiling this method (060054AA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Controller.ControllerDevice::ButtonUp(Controller.Buttons)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool[](var_0_06, ldfld:bool[](ControllerDevice::_KeyStateUp, ldloc:ControllerDevice(this)))
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

		// Token: 0x060054AB RID: 21675 RVA: 0x002868A4 File Offset: 0x00284AA4
		public bool ButtonDown(Buttons key)
		{
			/*
An exception occurred when decompiling this method (060054AB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Controller.ControllerDevice::ButtonDown(Controller.Buttons)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool[](var_0_06, ldfld:bool[](ControllerDevice::_KeyStateDown, ldloc:ControllerDevice(this)))
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

		// Token: 0x060054AC RID: 21676 RVA: 0x002868B8 File Offset: 0x00284AB8
		public void SetFakedButton(Buttons key)
		{
			bool[] fakedDeviceButtons = this._fakedDeviceButtons;
		}

		// Token: 0x060054AD RID: 21677 RVA: 0x002868D0 File Offset: 0x00284AD0
		public void SetFakedAxis(Axis axis, float value)
		{
			float[] fakedAxisValues = this._fakedAxisValues;
		}

		// Token: 0x060054AE RID: 21678 RVA: 0x002868E4 File Offset: 0x00284AE4
		public void ResetState()
		{
			float[] previousAxisValue = this.PreviousAxisValue;
			float[] previousAxisValueScaled = this.PreviousAxisValueScaled;
			float[] axisValue = this.AxisValue;
			float[] axisValueScaled = this.AxisValueScaled;
			bool[] previousKeyState = this._PreviousKeyState;
			bool[] keyStateUp = this._KeyStateUp;
			bool[] keyState = this._KeyState;
			bool[] keyStateDown = this._KeyStateDown;
			long num = 0L;
			keyStateDown.m_value = num != 0L;
		}

		// Token: 0x060054AF RID: 21679 RVA: 0x00286940 File Offset: 0x00284B40
		public bool Update(float elapsedTime)
		{
			bool flag2;
			float[] axisTime3;
			if (this.Device != null)
			{
				float[] axisValue = this.AxisValue;
				float[] axisValueScaled = this.AxisValueScaled;
				float[] previousAxisValue = this.PreviousAxisValue;
				this.PreviousAxisValueScaled.m_value = axisValueScaled;
				if (this.Device2 != null)
				{
				}
				float[] axisValue2 = this.AxisValue;
				float[] axisValueScaled2 = this.AxisValueScaled;
				float[] axisTime = this._AxisTime;
				float[] previousAxisValue2 = this.PreviousAxisValue;
				float[] axisTime2 = this._AxisTime;
				if (this.Device != null)
				{
					bool[] previousKeyState = this._PreviousKeyState;
					bool[] keyState = this._KeyState;
					if (this.Device2 != null)
					{
						bool flag;
						return flag;
					}
					bool[] previousKeyState2 = this._PreviousKeyState;
					bool[] keyStateUp = this._KeyStateUp;
					bool[] keyState2 = this._KeyState;
					bool[] keyStateDown = this._KeyStateDown;
					bool[] keyState3 = this._KeyState;
					long num;
					if (keyState2 != null)
					{
						num = 0L;
						return flag2;
					}
					if (keyStateDown != null)
					{
						float[] keyTime = this._KeyTime;
						if (num == 0L)
						{
							return flag2;
						}
					}
					else
					{
						float[] keyTime;
						if (keyTime != null)
						{
							return flag2;
						}
						float[] keyTime2 = this._KeyTime;
					}
					bool[] keyConsumed = this._KeyConsumed;
					return flag2;
				}
			}
			else if (this._fakedAxisValues != null)
			{
				float[] previousAxisValue3 = this.PreviousAxisValue;
				float[] previousAxisValueScaled = this.PreviousAxisValueScaled;
				float[] axisValue3 = this.AxisValue;
				float[] axisValueScaled3 = this.AxisValueScaled;
				axisTime3 = this._AxisTime;
				return flag2;
			}
			if (this._fakedDeviceButtons != null)
			{
				bool[] keyStateUp2 = this._KeyStateUp;
				bool[] keyStateDown2 = this._KeyStateDown;
				bool[] previousKeyState3 = this._PreviousKeyState;
				bool[] keyState4 = this._KeyState;
				int num2;
				if (num2 != 0)
				{
				}
				keyStateDown2.m_value = num2 != 0;
				long num3;
				if (num2 != 0)
				{
					num3 = 0L;
					return flag2;
				}
				keyStateUp2.m_value = num3 != 0L;
				previousKeyState3.m_value = num3 != 0L;
				keyState4.m_value = num3 != 0L;
				if (num3 != 0L)
				{
					float[] keyTime3 = this._KeyTime;
					if (axisTime3 != null)
					{
						bool[] keyConsumed2 = this._KeyConsumed;
						return flag2;
					}
				}
			}
			return flag2;
		}

		// Token: 0x060054B0 RID: 21680 RVA: 0x00286AF8 File Offset: 0x00284CF8
		private float GetAxisRaw(Axis axis)
		{
			/*
An exception occurred when decompiling this method (060054B0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Controller.ControllerDevice::GetAxisRaw(Controller.Axis)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_10, ldfld:float32(OneAxisInputControl::sensitivity, callgetter:InputControl[exp:OneAxisInputControl](InputDevice::get_LeftStickX, ldfld:InputDevice(ControllerDevice::Device, ldloc:ControllerDevice(this)))))
	stloc:float32(var_2_17, ldfld:float32(OneAxisInputControl::sensitivity, ldloc:InputControl[exp:OneAxisInputControl](var_1)))
	stloc:float32(var_4_1E, ldfld:float32(OneAxisInputControl::sensitivity, ldloc:InputControl[exp:OneAxisInputControl](var_3)))
	stloc:float32(var_6_27, ldfld:float32(OneAxisInputControl::sensitivity, ldloc:InputControl[exp:OneAxisInputControl](var_5)))
	stloc:float32(var_8_30, ldfld:float32(OneAxisInputControl::sensitivity, ldloc:InputControl[exp:OneAxisInputControl](var_7)))
	stloc:float32(var_10_39, ldfld:float32(OneAxisInputControl::sensitivity, ldloc:InputControl[exp:OneAxisInputControl](var_9)))
	stloc:float32(var_12_42, ldfld:float32(OneAxisInputControl::sensitivity, ldloc:InputControl[exp:OneAxisInputControl](var_11)))
	stloc:float32(var_14_4B, call:float32(OneAxisInputControl::op_Implicit, ldloc:InputControl[exp:OneAxisInputControl](var_13)))
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

		// Token: 0x060054B1 RID: 21681 RVA: 0x00286B54 File Offset: 0x00284D54
		private float GetAxisRaw2(Axis axis)
		{
			/*
An exception occurred when decompiling this method (060054B1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Controller.ControllerDevice::GetAxisRaw2(Controller.Axis)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:InputControl(var_0_0B, callgetter:InputControl(InputDevice::get_LeftStickY, ldfld:InputDevice(ControllerDevice::Device, ldloc:ControllerDevice(this))))
	stloc:float32(var_1_1C, call:float32(OneAxisInputControl::op_Implicit, callgetter:InputControl[exp:OneAxisInputControl](InputDevice::get_LeftStickX, ldfld:InputDevice(ControllerDevice::Device, ldloc:ControllerDevice(this)))))
	stloc:InputControl(var_2_28, callgetter:InputControl(InputDevice::get_LeftStickY, ldfld:InputDevice(ControllerDevice::Device2, ldloc:ControllerDevice(this))))
	stloc:float32(var_3_39, call:float32(OneAxisInputControl::op_Implicit, callgetter:InputControl[exp:OneAxisInputControl](InputDevice::get_LeftStickX, ldfld:InputDevice(ControllerDevice::Device2, ldloc:ControllerDevice(this)))))
	stloc:bool(var_4_4A, callgetter:bool(OneAxisInputControl::get_State, callgetter:InputControl[exp:OneAxisInputControl](InputDevice::get_Action2, ldfld:InputDevice(ControllerDevice::Device, ldloc:ControllerDevice(this)))))
	stloc:bool(var_5_5C, callgetter:bool(OneAxisInputControl::get_State, callgetter:InputControl[exp:OneAxisInputControl](InputDevice::get_Action1, ldfld:InputDevice(ControllerDevice::Device, ldloc:ControllerDevice(this)))))
	stloc:bool(var_6_6E, callgetter:bool(OneAxisInputControl::get_State, callgetter:InputControl[exp:OneAxisInputControl](InputDevice::get_Action3, ldfld:InputDevice(ControllerDevice::Device, ldloc:ControllerDevice(this)))))
	stloc:bool(var_7_80, callgetter:bool(OneAxisInputControl::get_State, callgetter:InputControl[exp:OneAxisInputControl](InputDevice::get_Action4, ldfld:InputDevice(ControllerDevice::Device, ldloc:ControllerDevice(this)))))
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

		// Token: 0x060054B2 RID: 21682 RVA: 0x00286BE4 File Offset: 0x00284DE4
		private bool GetKeyRaw(Buttons key)
		{
			bool swapBumpersTriggers = ControllerDevice.SwapBumpersTriggers;
			InputDevice device = this.Device;
			InputDeviceStyle <DeviceStyle>k__BackingField = device.<DeviceStyle>k__BackingField;
			if (device.<IsAttached>k__BackingField)
			{
				InputControl action = device.Action1;
			}
			InputControl inputControl;
			bool state = inputControl.State;
			InputDevice device2 = this.Device;
			InputControl inputControl2;
			bool state2 = inputControl2.State;
			InputDevice device3 = this.Device;
			InputControl inputControl3;
			bool state3 = inputControl3.State;
			InputDevice device4 = this.Device;
			InputControl inputControl4;
			bool state4 = inputControl4.State;
			InputControl leftStickButton = this.Device.LeftStickButton;
			InputControl inputControl5;
			return inputControl5.State;
		}

		// Token: 0x060054B3 RID: 21683 RVA: 0x00286CC4 File Offset: 0x00284EC4
		private bool GetKeyRaw2(Buttons key)
		{
			bool swapBumpersTriggers = ControllerDevice.SwapBumpersTriggers;
			InputDeviceStyle <DeviceStyle>k__BackingField = this.Device.<DeviceStyle>k__BackingField;
			InputControl action = this.Device2.Action1;
			InputControl action2 = this.Device2.Action2;
			InputControl action3 = this.Device2.Action3;
			InputControl action4 = this.Device2.Action4;
			InputControl rightTrigger = this.Device2.RightTrigger;
			InputDevice device = this.Device2;
			return this.Device2.LeftStickButton.State;
		}

		// Token: 0x04008D8E RID: 36238
		public ControllerDevice.ControlScheme Controls;

		// Token: 0x04008D8F RID: 36239
		public InputDevice Device;

		// Token: 0x04008D90 RID: 36240
		public InputDevice Device2;

		// Token: 0x04008D91 RID: 36241
		private readonly float[] AxisValue;

		// Token: 0x04008D92 RID: 36242
		private readonly float[] AxisValueScaled;

		// Token: 0x04008D93 RID: 36243
		private readonly float[] PreviousAxisValue;

		// Token: 0x04008D94 RID: 36244
		private readonly float[] PreviousAxisValueScaled;

		// Token: 0x04008D95 RID: 36245
		private readonly float[] _AxisTime;

		// Token: 0x04008D96 RID: 36246
		private readonly float[] _KeyTime;

		// Token: 0x04008D97 RID: 36247
		private readonly bool[] _KeyState;

		// Token: 0x04008D98 RID: 36248
		private readonly bool[] _KeyConsumed;

		// Token: 0x04008D99 RID: 36249
		private readonly bool[] _PreviousKeyState;

		// Token: 0x04008D9A RID: 36250
		private readonly bool[] _KeyStateUp;

		// Token: 0x04008D9B RID: 36251
		private readonly bool[] _KeyStateDown;

		// Token: 0x04008D9C RID: 36252
		private readonly float[] _fakedAxisValues;

		// Token: 0x04008D9D RID: 36253
		private readonly bool[] _fakedDeviceButtons;

		// Token: 0x02000B62 RID: 2914
		public enum ControlScheme
		{
			// Token: 0x04008D9F RID: 36255
			CONTROLS_1234,
			// Token: 0x04008DA0 RID: 36256
			CONTROLS_ABXY_GREY,
			// Token: 0x04008DA1 RID: 36257
			CONTROLS_ABXY_XBOX,
			// Token: 0x04008DA2 RID: 36258
			CONTROLS_OUYA,
			// Token: 0x04008DA3 RID: 36259
			CONTROLS_PS4,
			// Token: 0x04008DA4 RID: 36260
			CONTROLS_ABXY_STEELSERIES,
			// Token: 0x04008DA5 RID: 36261
			CONTROLS_SWITCH,
			// Token: 0x04008DA6 RID: 36262
			CONTROLS_STADIA
		}
	}
}
