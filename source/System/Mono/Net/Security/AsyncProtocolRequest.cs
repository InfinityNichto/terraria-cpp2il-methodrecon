using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace Mono.Net.Security
{
	// Token: 0x0200004D RID: 77
	internal abstract class AsyncProtocolRequest
	{
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x00003D80 File Offset: 0x00001F80
		public MobileAuthenticatedStream Parent
		{
			[CompilerGenerated]
			get
			{
				return this.<Parent>k__BackingField;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00003D94 File Offset: 0x00001F94
		public bool RunSynchronously
		{
			[CompilerGenerated]
			get
			{
				return this.<RunSynchronously>k__BackingField;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00003DA8 File Offset: 0x00001FA8
		public string Name
		{
			get
			{
				/*
An exception occurred when decompiling this method (060000C9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Mono.Net.Security.AsyncProtocolRequest::get_Name()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Type(var_0_06, call:Type(object::GetType, ldloc:AsyncProtocolRequest[exp:object](this)))
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

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00003DBC File Offset: 0x00001FBC
		// (set) Token: 0x060000CB RID: 203 RVA: 0x00003DD0 File Offset: 0x00001FD0
		public int UserResult
		{
			[CompilerGenerated]
			get
			{
				return this.<UserResult>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.<UserResult>k__BackingField = value;
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00003DE4 File Offset: 0x00001FE4
		public AsyncProtocolRequest(MobileAuthenticatedStream parent, bool sync)
		{
			this.Parent = parent;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00003E00 File Offset: 0x00002000
		internal void RequestRead(int size)
		{
			object obj = this.locker;
			Monitor.Enter(obj, size != 0);
			int requestedSize = this.RequestedSize;
			long num = 0L;
			this.RequestedSize = requestedSize;
			if (requestedSize != 0)
			{
				Monitor.Exit(obj);
			}
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00003E5C File Offset: 0x0000205C
		internal void RequestWrite()
		{
			this.WriteRequested = 1;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00003E70 File Offset: 0x00002070
		internal Task<AsyncProtocolResult> StartOperation(CancellationToken cancellationToken)
		{
			/*
An exception occurred when decompiling this method (060000CF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task`1<Mono.Net.Security.AsyncProtocolResult> Mono.Net.Security.AsyncProtocolRequest::StartOperation(System.Threading.CancellationToken)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
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

		// Token: 0x060000D0 RID: 208 RVA: 0x00003E80 File Offset: 0x00002080
		private Task ProcessOperation(CancellationToken cancellationToken)
		{
			if (!true)
			{
			}
			AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
			Task task;
			return task;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00003E9C File Offset: 0x0000209C
		private Task<int?> InnerRead(CancellationToken cancellationToken)
		{
			if (!true)
			{
			}
			AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
			Task task;
			return task;
		}

		// Token: 0x060000D2 RID: 210
		protected abstract AsyncOperationStatus Run(AsyncOperationStatus status);

		// Token: 0x060000D3 RID: 211 RVA: 0x00003EB4 File Offset: 0x000020B4
		public override string ToString()
		{
			Type type = base.GetType();
			return string.Format("[{0}]", type);
		}

		// Token: 0x040000A8 RID: 168
		[CompilerGenerated]
		private readonly MobileAuthenticatedStream <Parent>k__BackingField;

		// Token: 0x040000A9 RID: 169
		[CompilerGenerated]
		private readonly bool <RunSynchronously>k__BackingField;

		// Token: 0x040000AA RID: 170
		[CompilerGenerated]
		private int <UserResult>k__BackingField;

		// Token: 0x040000AB RID: 171
		private int Started;

		// Token: 0x040000AC RID: 172
		private int RequestedSize;

		// Token: 0x040000AD RID: 173
		private int WriteRequested;

		// Token: 0x040000AE RID: 174
		private readonly object locker;

		// Token: 0x0200004E RID: 78
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <StartOperation>d__23 : IAsyncStateMachine
		{
			// Token: 0x060000D4 RID: 212 RVA: 0x00003ED4 File Offset: 0x000020D4
			private void MoveNext()
			{
				AsyncProtocolRequest asyncProtocolRequest = this.<>4__this;
				int num = 1;
				long num2 = 0L;
				if (Interlocked.CompareExchange(42203912, num, (int)num2) == 0)
				{
					CancellationToken cancellationToken = this.cancellationToken;
					Task task = asyncProtocolRequest.ProcessOperation(cancellationToken);
					long num3 = 0L;
					ConfiguredTaskAwaitable configuredTaskAwaitable = task.ConfigureAwait(num3 != 0L);
					return;
				}
			}

			// Token: 0x060000D5 RID: 213 RVA: 0x00003F44 File Offset: 0x00002144
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x040000AF RID: 175
			public int <>1__state;

			// Token: 0x040000B0 RID: 176
			public AsyncTaskMethodBuilder<AsyncProtocolResult> <>t__builder;

			// Token: 0x040000B1 RID: 177
			public AsyncProtocolRequest <>4__this;

			// Token: 0x040000B2 RID: 178
			public CancellationToken cancellationToken;

			// Token: 0x040000B3 RID: 179
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x0200004F RID: 79
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <ProcessOperation>d__24 : IAsyncStateMachine
		{
			// Token: 0x060000D6 RID: 214 RVA: 0x00002050 File Offset: 0x00000250
			private void MoveNext()
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x060000D7 RID: 215 RVA: 0x00003F54 File Offset: 0x00002154
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x040000B4 RID: 180
			public int <>1__state;

			// Token: 0x040000B5 RID: 181
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040000B6 RID: 182
			public CancellationToken cancellationToken;

			// Token: 0x040000B7 RID: 183
			public AsyncProtocolRequest <>4__this;

			// Token: 0x040000B8 RID: 184
			private AsyncOperationStatus <status>5__2;

			// Token: 0x040000B9 RID: 185
			private AsyncOperationStatus <newStatus>5__3;

			// Token: 0x040000BA RID: 186
			private ConfiguredTaskAwaitable<int?>.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x040000BB RID: 187
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;
		}

		// Token: 0x02000050 RID: 80
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <InnerRead>d__25 : IAsyncStateMachine
		{
			// Token: 0x060000D8 RID: 216 RVA: 0x00003F64 File Offset: 0x00002164
			private void MoveNext()
			{
				AsyncProtocolRequest asyncProtocolRequest = this.<>4__this;
				long num = 0L;
				int num2 = Interlocked.Exchange(1073741824, (int)num);
			}

			// Token: 0x060000D9 RID: 217 RVA: 0x0000401C File Offset: 0x0000221C
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x040000BC RID: 188
			public int <>1__state;

			// Token: 0x040000BD RID: 189
			public AsyncTaskMethodBuilder<int?> <>t__builder;

			// Token: 0x040000BE RID: 190
			public AsyncProtocolRequest <>4__this;

			// Token: 0x040000BF RID: 191
			public CancellationToken cancellationToken;

			// Token: 0x040000C0 RID: 192
			private int? <totalRead>5__2;

			// Token: 0x040000C1 RID: 193
			private int <requestedSize>5__3;

			// Token: 0x040000C2 RID: 194
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__1;
		}
	}
}
