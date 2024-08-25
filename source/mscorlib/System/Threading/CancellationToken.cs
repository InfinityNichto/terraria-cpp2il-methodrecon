using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace System.Threading
{
	// Token: 0x020001C9 RID: 457
	[DebuggerDisplay("IsCancellationRequested = {IsCancellationRequested}")]
	public readonly struct CancellationToken
	{
		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060010CE RID: 4302 RVA: 0x000239E4 File Offset: 0x00021BE4
		public static CancellationToken None
		{
			get
			{
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060010CF RID: 4303 RVA: 0x000239F4 File Offset: 0x00021BF4
		public bool IsCancellationRequested
		{
			get
			{
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060010D0 RID: 4304 RVA: 0x0000207A File Offset: 0x0000027A
		public bool CanBeCanceled
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x00023A04 File Offset: 0x00021C04
		internal CancellationToken(CancellationTokenSource source)
		{
			this._source = source;
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x00023A18 File Offset: 0x00021C18
		public CancellationToken(bool canceled)
		{
		}

		// Token: 0x060010D3 RID: 4307 RVA: 0x00023A30 File Offset: 0x00021C30
		public CancellationTokenRegistration Register(Action callback)
		{
			do
			{
				if (!true)
				{
				}
			}
			while (callback == null);
			CancellationTokenRegistration cancellationTokenRegistration;
			return cancellationTokenRegistration;
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x00023A44 File Offset: 0x00021C44
		internal CancellationTokenRegistration InternalRegisterWithoutEC(Action<object> callback, object state)
		{
			long num = 0L;
			long num2 = 0L;
			return this.Register(callback, state, num != 0L, num2 != 0L);
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x00023A60 File Offset: 0x00021C60
		public CancellationTokenRegistration Register(Action<object> callback, object state, bool useSynchronizationContext, bool useExecutionContext)
		{
			while (callback == null)
			{
			}
			SynchronizationContext synchronizationContext = SynchronizationContext.Current;
			ExecutionContext executionContext = ExecutionContext.Capture();
			CancellationTokenRegistration cancellationTokenRegistration;
			return cancellationTokenRegistration;
		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x0000207A File Offset: 0x0000027A
		public bool Equals(CancellationToken other)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x00023A80 File Offset: 0x00021C80
		public override bool Equals(object other)
		{
			if (other != null)
			{
				return;
			}
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x00023A94 File Offset: 0x00021C94
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (060010D8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Threading.CancellationToken::GetHashCode()

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

		// Token: 0x060010D9 RID: 4313 RVA: 0x0000207A File Offset: 0x0000027A
		public static bool operator ==(CancellationToken left, CancellationToken right)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x0000207A File Offset: 0x0000027A
		public static bool operator !=(CancellationToken left, CancellationToken right)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x00023AA4 File Offset: 0x00021CA4
		public void ThrowIfCancellationRequested()
		{
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x0000207A File Offset: 0x0000027A
		private void ThrowOperationCanceledException()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x00023AB8 File Offset: 0x00021CB8
		// Note: this type is marked as 'beforefieldinit'.
		static CancellationToken()
		{
			if (!true)
			{
			}
		}

		// Token: 0x04000918 RID: 2328
		private readonly CancellationTokenSource _source;

		// Token: 0x04000919 RID: 2329
		private static readonly Action<object> s_actionToActionObjShunt;

		// Token: 0x020001CA RID: 458
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060010DE RID: 4318 RVA: 0x00023AC8 File Offset: 0x00021CC8
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060010DF RID: 4319 RVA: 0x00023AD8 File Offset: 0x00021CD8
			public <>c()
			{
			}

			// Token: 0x060010E0 RID: 4320 RVA: 0x00023AEC File Offset: 0x00021CEC
			internal void <.cctor>b__26_0(object obj)
			{
				if (obj != null)
				{
				}
			}

			// Token: 0x0400091A RID: 2330
			public static readonly CancellationToken.<>c <>9;
		}
	}
}
