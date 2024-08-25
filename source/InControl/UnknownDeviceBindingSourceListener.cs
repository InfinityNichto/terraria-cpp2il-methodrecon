using System;

namespace InControl
{
	// Token: 0x02000016 RID: 22
	public class UnknownDeviceBindingSourceListener : BindingSourceListener
	{
		// Token: 0x06000107 RID: 263 RVA: 0x000040B8 File Offset: 0x000022B8
		public void Reset()
		{
			if (!true)
			{
			}
			this.detectFound = 1;
			this.detectFound.IsButton = true;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000040DC File Offset: 0x000022DC
		private void TakeSnapshotOnUnknownDevices()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000040F4 File Offset: 0x000022F4
		public BindingSource Listen(BindingListenOptions listenOptions, InputDevice device)
		{
			/*
An exception occurred when decompiling this method (06000109)

ICSharpCode.Decompiler.DecompilerException: Error decompiling InControl.BindingSource InControl.UnknownDeviceBindingSourceListener::Listen(InControl.BindingListenOptions,InControl.InputDevice)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0076:
	stfld:DetectPhase(UnknownDeviceBindingSourceListener::detectPhase, ldloc:UnknownDeviceBindingSourceListener(this), ldc.i4:DetectPhase(1))
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

		// Token: 0x0600010A RID: 266 RVA: 0x00004180 File Offset: 0x00002380
		private bool IsPressed(UnknownDeviceControl control, InputDevice device)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00004194 File Offset: 0x00002394
		private UnknownDeviceControl ListenForControl(BindingListenOptions listenOptions, InputDevice device)
		{
			UnknownDeviceControl firstPressedButton = device.GetFirstPressedButton();
			UnknownDeviceControl firstPressedAnalog;
			if (firstPressedButton == null && firstPressedButton == null)
			{
				firstPressedAnalog = device.GetFirstPressedAnalog();
				while (firstPressedAnalog == null)
				{
				}
			}
			return firstPressedAnalog;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000041BC File Offset: 0x000023BC
		public UnknownDeviceBindingSourceListener()
		{
		}

		// Token: 0x04000104 RID: 260
		private UnknownDeviceControl detectFound;

		// Token: 0x04000105 RID: 261
		private UnknownDeviceBindingSourceListener.DetectPhase detectPhase;

		// Token: 0x02000017 RID: 23
		private enum DetectPhase
		{
			// Token: 0x04000107 RID: 263
			WaitForInitialRelease,
			// Token: 0x04000108 RID: 264
			WaitForControlPress,
			// Token: 0x04000109 RID: 265
			WaitForControlRelease
		}
	}
}
