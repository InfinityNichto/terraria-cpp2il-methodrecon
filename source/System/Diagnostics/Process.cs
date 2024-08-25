using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using Cpp2IlInjected;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.Diagnostics
{
	// Token: 0x020000D6 RID: 214
	[global::System.ComponentModel.DefaultEvent("Exited")]
	[MonitoringDescription("Provides access to local and remote processes, enabling starting and stopping of local processes.")]
	[global::System.ComponentModel.DefaultProperty("StartInfo")]
	public class Process : global::System.ComponentModel.Component
	{
		// Token: 0x060004DC RID: 1244 RVA: 0x00013E50 File Offset: 0x00012050
		public Process()
		{
			if (!true)
			{
			}
			base..ctor();
			this.machineName = ".";
			this.m_processAccess = 4095;
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00013E7C File Offset: 0x0001207C
		private Process(string machineName, bool isRemoteMachine, int processId, ProcessInfo processInfo)
		{
			if (!true)
			{
			}
			base..ctor();
			this.machineName = machineName;
			this.processId = processId;
			this.haveProcessId = true;
			this.m_processAccess = 4095;
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060004DE RID: 1246 RVA: 0x00013EB4 File Offset: 0x000120B4
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("Indicates if the process component is associated with a real process.")]
		[global::System.ComponentModel.Browsable(false)]
		private bool Associated
		{
			get
			{
				return !this.haveProcessId || true;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x00013ECC File Offset: 0x000120CC
		[global::System.ComponentModel.Browsable(false)]
		[MonitoringDescription("Indicates if the associated process has been terminated.")]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool HasExited
		{
			get
			{
				if (this.exited)
				{
				}
				this.EnsureState(Process.State.Associated);
				long num = 0L;
				Microsoft.Win32.SafeHandles.SafeProcessHandle processHandle = this.GetProcessHandle(1024, num != 0L);
				this.exited = true;
				bool exitCodeProcess = Microsoft.Win32.NativeMethods.GetExitCodeProcess(processHandle, 1024);
				this.exitCode = 1;
				this.exited = true;
				return exitCodeProcess;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060004E0 RID: 1248 RVA: 0x00013FD8 File Offset: 0x000121D8
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("Returns the native handle for this process.   The handle is only available if the process was started using this component.")]
		public IntPtr Handle
		{
			get
			{
				this.EnsureState(Process.State.Associated);
				int processAccess = this.m_processAccess;
				return this.OpenProcessHandle(processAccess).handle;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x00014000 File Offset: 0x00012200
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("The unique identifier for the process.")]
		public int Id
		{
			get
			{
				this.EnsureState(Process.State.HaveId);
				return this.processId;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (set) Token: 0x060004E2 RID: 1250 RVA: 0x0001401C File Offset: 0x0001221C
		[MonitoringDescription("The priority that the threads in the process run relative to.")]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public ProcessPriorityClass PriorityClass
		{
			set
			{
				if (!true)
				{
				}
				Microsoft.Win32.SafeHandles.SafeProcessHandle processHandle = this.GetProcessHandle(512, true);
				long num = 0L;
				this.priorityClass = value;
				this.havePriorityClass = true;
				if (processHandle != null)
				{
					if (this.haveProcessHandle)
					{
						Microsoft.Win32.SafeHandles.SafeProcessHandle processHandle2 = this.m_processHandle;
					}
					processHandle.Close();
				}
				if (num == 0L)
				{
					return;
				}
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x00014090 File Offset: 0x00012290
		// (set) Token: 0x060004E4 RID: 1252 RVA: 0x000140A4 File Offset: 0x000122A4
		[MonitoringDescription("Specifies information used to start a process.")]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
		public ProcessStartInfo StartInfo
		{
			get
			{
				/*
An exception occurred when decompiling this method (060004E3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Diagnostics.ProcessStartInfo System.Diagnostics.Process::get_StartInfo()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:ProcessStartInfo[exp:bool](Process::startInfo, ldloc:Process(this)))
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
			set
			{
				while (value == null)
				{
				}
				this.startInfo = value;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x000140BC File Offset: 0x000122BC
		[global::System.ComponentModel.DefaultValue(null)]
		[MonitoringDescription("The object used to marshal the event handler calls issued as a result of a Process exit.")]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.ComponentModel.ISynchronizeInvoke SynchronizingObject
		{
			get
			{
				if (this.synchronizingObject == null)
				{
					bool designMode = base.DesignMode;
					if (this != null)
					{
						if (this == null)
						{
							throw new InvalidCastException();
						}
						if (this != null && this != null)
						{
							if (this != null)
							{
								this.synchronizingObject = this;
								if (this != null)
								{
									goto IL_0028;
								}
							}
							throw new InvalidCastException();
						}
					}
				}
				IL_0028:
				return this.synchronizingObject;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060004E6 RID: 1254 RVA: 0x00014104 File Offset: 0x00012304
		[global::System.ComponentModel.Browsable(false)]
		[MonitoringDescription("Standard input stream of the process.")]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public StreamWriter StandardInput
		{
			get
			{
				/*
An exception occurred when decompiling this method (060004E6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IO.StreamWriter System.Diagnostics.Process::get_StandardInput()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0013:
	stloc:string(var_1_1D, call:string(SR::GetString, ldstr:string("StandardIn has not been redirected.")))
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

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x00014130 File Offset: 0x00012330
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("Standard output stream of the process.")]
		public StreamReader StandardOutput
		{
			get
			{
				/*
An exception occurred when decompiling this method (060004E7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IO.StreamReader System.Diagnostics.Process::get_StandardOutput()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0021:
	stloc:string(var_1_2B, call:string(SR::GetString, ldstr:string("Cannot mix synchronous and asynchronous operation on process stream.")))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x060004E8 RID: 1256 RVA: 0x00014168 File Offset: 0x00012368
		private void ReleaseProcessHandle(Microsoft.Win32.SafeHandles.SafeProcessHandle handle)
		{
			if (handle != null)
			{
				if (this.haveProcessHandle)
				{
					Microsoft.Win32.SafeHandles.SafeProcessHandle processHandle = this.m_processHandle;
				}
				handle.Close();
				return;
			}
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00014190 File Offset: 0x00012390
		private void CompletionCallback(object context, bool wasSignaled)
		{
			this.StopWatchingForExit();
			this.RaiseOnExited();
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x000141AC File Offset: 0x000123AC
		protected override void Dispose(bool disposing)
		{
			if (this.disposed)
			{
				return;
			}
			this.Close();
			this.disposed = true;
			base.Dispose(disposing);
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x000141D8 File Offset: 0x000123D8
		public void Close()
		{
			bool flag = this.haveProcessId;
			bool flag2 = this.haveProcessHandle;
			if (flag)
			{
				if (!flag2)
				{
					return;
				}
			}
			else if (!flag2)
			{
				return;
			}
			this.StopWatchingForExit();
			this.m_processHandle.Close();
			StreamWriter streamWriter = this.standardInput;
			this.machineName = ".";
			if (streamWriter == null || this.inputStreamReadMode == Process.StreamReadMode.undefined)
			{
			}
			if (this.standardOutput == null || this.outputStreamReadMode == Process.StreamReadMode.undefined)
			{
			}
			if (this.standardError == null || this.errorStreamReadMode == Process.StreamReadMode.undefined)
			{
			}
			AsyncStreamReader asyncStreamReader = this.output;
			if (asyncStreamReader != null)
			{
				Process.StreamReadMode streamReadMode = this.outputStreamReadMode;
				asyncStreamReader.cancelOperation = true;
			}
			AsyncStreamReader asyncStreamReader2 = this.error;
			if (asyncStreamReader2 != null)
			{
				Process.StreamReadMode streamReadMode2 = this.errorStreamReadMode;
				asyncStreamReader2.cancelOperation = true;
			}
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00014284 File Offset: 0x00012484
		private void EnsureState(Process.State state)
		{
			/*
An exception occurred when decompiling this method (060004EC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Diagnostics.Process::EnsureState(System.Diagnostics.Process/State)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0048:
	stloc:string(var_2_52, call:string(SR::GetString, ldstr:string("No process is associated with this object.")))
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

		// Token: 0x060004ED RID: 1261 RVA: 0x000142E4 File Offset: 0x000124E4
		private void EnsureWatchingForExit()
		{
			if (!this.watchingForExit)
			{
				if (this.watchingForExit)
				{
					return;
				}
				int num = 1;
				this.watchingForExit = num != 0;
				Microsoft.Win32.SafeHandles.SafeProcessHandle processHandle = this.m_processHandle;
				long num2 = 0L;
				RegisteredWaitHandle registeredWaitHandle;
				this.registeredWaitHandle = registeredWaitHandle;
				Monitor.Exit(this);
				if (num2 != 0L)
				{
					throw new OutOfMemoryException();
				}
			}
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00014358 File Offset: 0x00012558
		public static Process GetCurrentProcess()
		{
			/*
An exception occurred when decompiling this method (060004EE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Diagnostics.Process System.Diagnostics.Process::GetCurrentProcess()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_1_07, call:int32(NativeMethods::GetCurrentProcessId))
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

		// Token: 0x060004EF RID: 1263 RVA: 0x0001436C File Offset: 0x0001256C
		protected void OnExited()
		{
			EventHandler eventHandler = this.onExited;
			if (eventHandler == null)
			{
				return;
			}
			if (this.SynchronizingObject != null)
			{
				global::System.ComponentModel.ISynchronizeInvoke synchronizeInvoke = this.SynchronizingObject;
				return;
			}
			IntPtr invoke_impl = eventHandler.invoke_impl;
			IntPtr method_code = eventHandler.method_code;
			IntPtr method = eventHandler.method;
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x000143CC File Offset: 0x000125CC
		private Microsoft.Win32.SafeHandles.SafeProcessHandle GetProcessHandle(int access, bool throwIfExited)
		{
			while (!this.haveProcessHandle)
			{
			}
			Microsoft.Win32.SafeHandles.SafeProcessHandle processHandle = this.m_processHandle;
			long num = 0L;
			int num2 = 3;
			if (num == 0L && num2 == 0)
			{
				if (this.m_processHandle == null)
				{
				}
				IntPtr currentProcess = Microsoft.Win32.NativeMethods.GetCurrentProcess();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00014460 File Offset: 0x00012660
		private Microsoft.Win32.SafeHandles.SafeProcessHandle GetProcessHandle(int access)
		{
			return this.GetProcessHandle(access, true);
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00014478 File Offset: 0x00012678
		private Microsoft.Win32.SafeHandles.SafeProcessHandle OpenProcessHandle(int access)
		{
			/*
An exception occurred when decompiling this method (060004F2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Win32.SafeHandles.SafeProcessHandle System.Diagnostics.Process::OpenProcessHandle(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_003E:
	stloc:Type(var_2_44, call:Type(object::GetType, ldloc:Process[exp:object](this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x060004F3 RID: 1267 RVA: 0x000144CC File Offset: 0x000126CC
		public void Refresh()
		{
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x000144DC File Offset: 0x000126DC
		private void SetProcessHandle(Microsoft.Win32.SafeHandles.SafeProcessHandle processHandle)
		{
			bool flag = this.watchForExit;
			this.m_processHandle = processHandle;
			this.haveProcessHandle = true;
			if (flag)
			{
				this.EnsureWatchingForExit();
				return;
			}
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00014508 File Offset: 0x00012708
		private void SetProcessId(int processId)
		{
			this.processId = processId;
			this.haveProcessId = true;
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00014524 File Offset: 0x00012724
		public bool Start()
		{
			this.Close();
			ProcessStartInfo processStartInfo = this.StartInfo;
			if (processStartInfo.fileName == null)
			{
			}
			if (processStartInfo.useShellExecute)
			{
				return this.StartWithShellExecuteEx(processStartInfo);
			}
			bool flag = this.StartWithCreateProcess(processStartInfo);
			return true;
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0001456C File Offset: 0x0001276C
		public static Process Start(string fileName)
		{
			Process process;
			return process;
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00002050 File Offset: 0x00000250
		public static Process Start(ProcessStartInfo startInfo)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x0001457C File Offset: 0x0001277C
		private void StopWatchingForExit()
		{
			if (this.watchingForExit)
			{
				if (this.watchingForExit)
				{
					RegisteredWaitHandle registeredWaitHandle = this.registeredWaitHandle;
					WaitHandle waitHandle = this.waitHandle;
					return;
				}
				long num = 0L;
				Monitor.Exit(this);
				if (num != 0L)
				{
					throw new OutOfMemoryException();
				}
			}
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x000145D8 File Offset: 0x000127D8
		public override string ToString()
		{
			if (this.haveProcessId || this.haveProcessHandle)
			{
				string processName = this.ProcessName;
				if (processName._stringLength != 0)
				{
					CultureInfo currentCulture = CultureInfo.CurrentCulture;
					string text = base.ToString();
					return string.Format(currentCulture, "{0} ({1})", text, processName);
				}
			}
			return base.ToString();
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00014630 File Offset: 0x00012830
		public bool WaitForExit(int milliseconds)
		{
			long num = 0L;
			Microsoft.Win32.SafeHandles.SafeProcessHandle processHandle = this.GetProcessHandle(16, num != 0L);
			this.signaled = true;
			AsyncStreamReader asyncStreamReader = this.output;
			if (asyncStreamReader != null && asyncStreamReader.eofEvent != null)
			{
				ManualResetEvent eofEvent = asyncStreamReader.eofEvent;
			}
			AsyncStreamReader asyncStreamReader2 = this.error;
			if (asyncStreamReader2 != null && asyncStreamReader2.eofEvent != null)
			{
				ManualResetEvent eofEvent2 = asyncStreamReader2.eofEvent;
			}
			long num2 = 0L;
			if (processHandle != null)
			{
				if (this.haveProcessHandle)
				{
					Microsoft.Win32.SafeHandles.SafeProcessHandle processHandle2 = this.m_processHandle;
				}
				processHandle.Close();
			}
			if (num2 == 0L && 7 == 0 && this.watchForExit)
			{
				this.RaiseOnExited();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x000146F4 File Offset: 0x000128F4
		public void WaitForExit()
		{
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00002050 File Offset: 0x00000250
		private static string ProcessName_icall(IntPtr handle)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00014704 File Offset: 0x00012904
		private static string ProcessName_internal(Microsoft.Win32.SafeHandles.SafeProcessHandle handle)
		{
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x0001472C File Offset: 0x0001292C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("The name of this process.")]
		public string ProcessName
		{
			get
			{
				string text5;
				if (this.process_name == null)
				{
					int num = 1024;
					int num2 = 1;
					Microsoft.Win32.SafeHandles.SafeProcessHandle processHandle = this.GetProcessHandle(num, num2 != 0);
					string text = Process.ProcessName_internal(processHandle);
					this.process_name = text;
					if (text == null)
					{
						long num3 = 0L;
						long num4 = 0L;
						if ((num3 != 0L || num3 != 0L) && this.haveProcessHandle)
						{
							Microsoft.Win32.SafeHandles.SafeProcessHandle processHandle2 = this.m_processHandle;
						}
						if (num4 == 0L)
						{
						}
						throw new OutOfMemoryException();
					}
					bool flag = text.EndsWith(".exe");
					bool flag2 = this.process_name.EndsWith(".bat");
					string text2 = this.process_name;
					long num5 = 0L;
					bool flag3 = text2.EndsWith(".com");
					string text3 = this.process_name;
					int stringLength = text3._stringLength;
					long num6 = 0L;
					string text4 = text3.Substring((int)num6, (int)num5);
					long num7 = 0L;
					this.process_name = text4;
					if (processHandle != null)
					{
						if (this.haveProcessHandle)
						{
							Microsoft.Win32.SafeHandles.SafeProcessHandle processHandle3 = this.m_processHandle;
						}
						processHandle.Close();
					}
					if (num7 != 0L)
					{
						throw new OutOfMemoryException();
					}
					text5 = this.process_name;
				}
				return text5;
			}
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00002050 File Offset: 0x00000250
		private static bool ShellExecuteEx_internal(ProcessStartInfo startInfo, Process.ProcInfo procInfo)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00002050 File Offset: 0x00000250
		private static bool CreateProcess_internal(ProcessStartInfo startInfo, IntPtr stdin, IntPtr stdout, IntPtr stderr, Process.ProcInfo procInfo)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00002050 File Offset: 0x00000250
		private bool StartWithShellExecuteEx(ProcessStartInfo startInfo)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00014828 File Offset: 0x00012A28
		private static void CreatePipe([Out] IntPtr read, [Out] IntPtr write, bool writeDirection)
		{
			if (!true)
			{
			}
			PlatformID platform = Environment.OSVersion._platform;
			Process currentProcess = Process.GetCurrentProcess();
			currentProcess.EnsureState(Process.State.Associated);
			int processAccess = currentProcess.m_processAccess;
			IntPtr handle = currentProcess.OpenProcessHandle(processAccess).handle;
			Process currentProcess2 = Process.GetCurrentProcess();
			currentProcess2.EnsureState(Process.State.Associated);
			int processAccess2 = currentProcess2.m_processAccess;
			Microsoft.Win32.SafeHandles.SafeProcessHandle safeProcessHandle = currentProcess2.OpenProcessHandle(processAccess2);
			IntPtr handle2 = safeProcessHandle.handle;
			if (safeProcessHandle != null)
			{
				write.m_value = safeProcessHandle;
				return;
			}
			read.m_value = safeProcessHandle;
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x000148AC File Offset: 0x00012AAC
		private static bool IsWindows
		{
			get
			{
				PlatformID platform = Environment.OSVersion._platform;
				return true;
			}
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00002050 File Offset: 0x00000250
		private bool StartWithCreateProcess(ProcessStartInfo startInfo)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x000148CC File Offset: 0x00012ACC
		private static void FillUserInfo(ProcessStartInfo startInfo, Process.ProcInfo procInfo)
		{
			string userName = startInfo.userName;
			if (userName == null)
			{
			}
			if (userName == null)
			{
			}
			if (startInfo.domain == null)
			{
			}
			SecureString password = startInfo.password;
			if (password != null)
			{
				IntPtr intPtr = Marshal.SecureStringToBSTR(password);
				return;
			}
			bool loadUserProfile = startInfo.loadUserProfile;
			procInfo.LoadUserProfile = loadUserProfile;
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00014910 File Offset: 0x00012B10
		private void RaiseOnExited()
		{
			if (this.watchForExit && !this.raisedOnExited)
			{
				if (!this.raisedOnExited)
				{
					this.raisedOnExited = true;
					this.OnExited();
				}
				long num = 0L;
				if (true)
				{
					Monitor.Exit(this);
				}
				if (num != 0L)
				{
					throw new OutOfMemoryException();
				}
			}
		}

		// Token: 0x040003C9 RID: 969
		private bool haveProcessId;

		// Token: 0x040003CA RID: 970
		private int processId;

		// Token: 0x040003CB RID: 971
		private bool haveProcessHandle;

		// Token: 0x040003CC RID: 972
		private Microsoft.Win32.SafeHandles.SafeProcessHandle m_processHandle;

		// Token: 0x040003CD RID: 973
		private bool isRemoteMachine;

		// Token: 0x040003CE RID: 974
		private string machineName;

		// Token: 0x040003CF RID: 975
		private int m_processAccess;

		// Token: 0x040003D0 RID: 976
		private ProcessThreadCollection threads;

		// Token: 0x040003D1 RID: 977
		private ProcessModuleCollection modules;

		// Token: 0x040003D2 RID: 978
		private bool haveWorkingSetLimits;

		// Token: 0x040003D3 RID: 979
		private bool havePriorityClass;

		// Token: 0x040003D4 RID: 980
		private ProcessPriorityClass priorityClass;

		// Token: 0x040003D5 RID: 981
		private ProcessStartInfo startInfo;

		// Token: 0x040003D6 RID: 982
		private bool watchForExit;

		// Token: 0x040003D7 RID: 983
		private bool watchingForExit;

		// Token: 0x040003D8 RID: 984
		private EventHandler onExited;

		// Token: 0x040003D9 RID: 985
		private bool exited;

		// Token: 0x040003DA RID: 986
		private int exitCode;

		// Token: 0x040003DB RID: 987
		private bool signaled;

		// Token: 0x040003DC RID: 988
		private bool haveExitTime;

		// Token: 0x040003DD RID: 989
		private bool raisedOnExited;

		// Token: 0x040003DE RID: 990
		private RegisteredWaitHandle registeredWaitHandle;

		// Token: 0x040003DF RID: 991
		private WaitHandle waitHandle;

		// Token: 0x040003E0 RID: 992
		private global::System.ComponentModel.ISynchronizeInvoke synchronizingObject;

		// Token: 0x040003E1 RID: 993
		private StreamReader standardOutput;

		// Token: 0x040003E2 RID: 994
		private StreamWriter standardInput;

		// Token: 0x040003E3 RID: 995
		private StreamReader standardError;

		// Token: 0x040003E4 RID: 996
		private bool disposed;

		// Token: 0x040003E5 RID: 997
		private Process.StreamReadMode outputStreamReadMode;

		// Token: 0x040003E6 RID: 998
		private Process.StreamReadMode errorStreamReadMode;

		// Token: 0x040003E7 RID: 999
		private Process.StreamReadMode inputStreamReadMode;

		// Token: 0x040003E8 RID: 1000
		internal AsyncStreamReader output;

		// Token: 0x040003E9 RID: 1001
		internal AsyncStreamReader error;

		// Token: 0x040003EA RID: 1002
		private string process_name;

		// Token: 0x020000D7 RID: 215
		private enum StreamReadMode
		{
			// Token: 0x040003EC RID: 1004
			undefined,
			// Token: 0x040003ED RID: 1005
			syncMode,
			// Token: 0x040003EE RID: 1006
			asyncMode
		}

		// Token: 0x020000D8 RID: 216
		private enum State
		{
			// Token: 0x040003F0 RID: 1008
			HaveId = 1,
			// Token: 0x040003F1 RID: 1009
			IsLocal,
			// Token: 0x040003F2 RID: 1010
			IsNt = 4,
			// Token: 0x040003F3 RID: 1011
			HaveProcessInfo = 8,
			// Token: 0x040003F4 RID: 1012
			Exited = 16,
			// Token: 0x040003F5 RID: 1013
			Associated = 32,
			// Token: 0x040003F6 RID: 1014
			IsWin2k = 64,
			// Token: 0x040003F7 RID: 1015
			HaveNtProcessInfo = 12
		}

		// Token: 0x020000D9 RID: 217
		private struct ProcInfo
		{
			// Token: 0x040003F8 RID: 1016
			public IntPtr process_handle;

			// Token: 0x040003F9 RID: 1017
			public int pid;

			// Token: 0x040003FA RID: 1018
			public string[] envVariables;

			// Token: 0x040003FB RID: 1019
			public string UserName;

			// Token: 0x040003FC RID: 1020
			public string Domain;

			// Token: 0x040003FD RID: 1021
			public IntPtr Password;

			// Token: 0x040003FE RID: 1022
			public bool LoadUserProfile;
		}
	}
}
