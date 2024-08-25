using System;
using System.Runtime.ConstrainedExecution;

namespace System.Runtime.InteropServices
{
	// Token: 0x0200044E RID: 1102
	[StructLayout(0)]
	public abstract class SafeHandle : CriticalFinalizerObject, IDisposable
	{
		// Token: 0x06002184 RID: 8580 RVA: 0x0004C2A8 File Offset: 0x0004A4A8
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		protected SafeHandle(IntPtr invalidHandleValue, bool ownsHandle)
		{
			this.handle = invalidHandleValue;
			this._state = 4;
			GC.SuppressFinalize(this);
			this._fullyInitialized = true;
		}

		// Token: 0x06002185 RID: 8581 RVA: 0x0004C2D8 File Offset: 0x0004A4D8
		protected override void Finalize()
		{
			base.Finalize();
		}

		// Token: 0x06002186 RID: 8582 RVA: 0x0004C30C File Offset: 0x0004A50C
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		protected void SetHandle(IntPtr handle)
		{
			this.handle = handle;
		}

		// Token: 0x06002187 RID: 8583 RVA: 0x0004C320 File Offset: 0x0004A520
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public IntPtr DangerousGetHandle()
		{
			return this.handle;
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06002188 RID: 8584 RVA: 0x0004C334 File Offset: 0x0004A534
		public bool IsClosed
		{
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			get
			{
				/*
An exception occurred when decompiling this method (06002188)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Runtime.InteropServices.SafeHandle::get_IsClosed()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(SafeHandle::_state, ldloc:SafeHandle(this)))
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

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06002189 RID: 8585
		public abstract bool IsInvalid
		{
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			get;
		}

		// Token: 0x0600218A RID: 8586 RVA: 0x0004C348 File Offset: 0x0004A548
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public void Close()
		{
		}

		// Token: 0x0600218B RID: 8587 RVA: 0x0004C358 File Offset: 0x0004A558
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public void Dispose()
		{
		}

		// Token: 0x0600218C RID: 8588 RVA: 0x0004C368 File Offset: 0x0004A568
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		protected virtual void Dispose(bool disposing)
		{
			this.InternalDispose();
		}

		// Token: 0x0600218D RID: 8589
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		protected abstract bool ReleaseHandle();

		// Token: 0x0600218E RID: 8590 RVA: 0x0004C38C File Offset: 0x0004A58C
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public void SetHandleAsInvalid()
		{
			if (!true)
			{
			}
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600218F RID: 8591 RVA: 0x0004C3A4 File Offset: 0x0004A5A4
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public void DangerousAddRef(bool success)
		{
			if (this._fullyInitialized)
			{
				int state = this._state;
				return;
			}
		}

		// Token: 0x06002190 RID: 8592 RVA: 0x0004C3C4 File Offset: 0x0004A5C4
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public void DangerousRelease()
		{
			long num = 0L;
			this.DangerousReleaseInternal(num != 0L);
		}

		// Token: 0x06002191 RID: 8593 RVA: 0x0004C3DC File Offset: 0x0004A5DC
		private void InternalDispose()
		{
			bool fullyInitialized;
			do
			{
				fullyInitialized = this._fullyInitialized;
			}
			while (!fullyInitialized);
			this.DangerousReleaseInternal(true);
			if (!fullyInitialized)
			{
			}
			GC.SuppressFinalize(this);
		}

		// Token: 0x06002192 RID: 8594 RVA: 0x0004C404 File Offset: 0x0004A604
		private void InternalFinalize()
		{
			if (this._fullyInitialized)
			{
				this.DangerousReleaseInternal(true);
				return;
			}
		}

		// Token: 0x06002193 RID: 8595 RVA: 0x0004C424 File Offset: 0x0004A624
		private void DangerousReleaseInternal(bool dispose)
		{
			if (this._fullyInitialized)
			{
				int state = this._state;
				return;
			}
		}

		// Token: 0x0400127D RID: 4733
		protected IntPtr handle;

		// Token: 0x0400127E RID: 4734
		private int _state;

		// Token: 0x0400127F RID: 4735
		private bool _ownsHandle;

		// Token: 0x04001280 RID: 4736
		private bool _fullyInitialized;

		// Token: 0x04001281 RID: 4737
		private const int RefCount_Mask = 2147483644;

		// Token: 0x04001282 RID: 4738
		private const int RefCount_One = 4;
	}
}
