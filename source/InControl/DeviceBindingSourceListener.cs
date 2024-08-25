using System;
using System.Collections.ObjectModel;

namespace InControl
{
	// Token: 0x02000008 RID: 8
	public class DeviceBindingSourceListener : BindingSourceListener
	{
		// Token: 0x0600002B RID: 43 RVA: 0x00002468 File Offset: 0x00000668
		public void Reset()
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002478 File Offset: 0x00000678
		public BindingSource Listen(BindingListenOptions listenOptions, InputDevice device)
		{
			/*
An exception occurred when decompiling this method (0600002C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling InControl.BindingSource InControl.DeviceBindingSourceListener::Listen(InControl.BindingListenOptions,InControl.InputDevice)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0043:
	stfld:int32(DeviceBindingSourceListener::detectPhase, ldloc:DeviceBindingSourceListener(this), ldc.i4:int32(1))
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

		// Token: 0x0600002D RID: 45 RVA: 0x000024D0 File Offset: 0x000006D0
		private bool IsPressed(InputControl control)
		{
			if (control.enabled && control.ownerEnabled)
			{
				float value = control.thisState.Value;
			}
			bool flag;
			return flag;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000024FC File Offset: 0x000006FC
		private bool IsPressed(InputControlType control, InputDevice device)
		{
			InputControl control2 = device.GetControl(control);
			bool flag;
			return flag;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002514 File Offset: 0x00000714
		private InputControlType ListenForControl(BindingListenOptions listenOptions, InputDevice device)
		{
			ReadOnlyCollection<InputControl> <Controls>k__BackingField = device.<Controls>k__BackingField;
			if (device.<Controls>k__BackingField == null)
			{
				return;
			}
			if (!listenOptions.IncludeNonStandardControls)
			{
			}
			if (listenOptions.IncludeNonStandardControls)
			{
				return;
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000254C File Offset: 0x0000074C
		public DeviceBindingSourceListener()
		{
		}

		// Token: 0x0400001E RID: 30
		private InputControlType detectFound;

		// Token: 0x0400001F RID: 31
		private int detectPhase;
	}
}
