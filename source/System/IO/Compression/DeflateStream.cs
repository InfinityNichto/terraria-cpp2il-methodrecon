using System;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace System.IO.Compression
{
	// Token: 0x0200043D RID: 1085
	public class DeflateStream : Stream
	{
		// Token: 0x06001DBC RID: 7612 RVA: 0x0004FB6C File Offset: 0x0004DD6C
		public DeflateStream(Stream stream, CompressionMode mode)
		{
		}

		// Token: 0x06001DBD RID: 7613 RVA: 0x0004FB80 File Offset: 0x0004DD80
		internal DeflateStream(Stream stream, CompressionMode mode, bool leaveOpen, int windowsBits)
		{
		}

		// Token: 0x06001DBE RID: 7614 RVA: 0x0004FB90 File Offset: 0x0004DD90
		internal DeflateStream(Stream compressedStream, CompressionMode mode, bool leaveOpen, bool gzip)
		{
			DeflateStreamNative deflateStreamNative;
			do
			{
				if (!true)
				{
				}
				base..ctor();
				if (compressedStream == null)
				{
					return;
				}
				this.base_stream = compressedStream;
				this.native = deflateStreamNative;
			}
			while (deflateStreamNative == null);
			this.leaveOpen = true;
		}

		// Token: 0x06001DBF RID: 7615 RVA: 0x0004FBC4 File Offset: 0x0004DDC4
		protected override void Finalize()
		{
			base.Finalize();
		}

		// Token: 0x06001DC0 RID: 7616 RVA: 0x0004FBF8 File Offset: 0x0004DDF8
		protected override void Dispose(bool disposing)
		{
			long num = 0L;
			GC.SuppressFinalize(this);
			DeflateStreamNative deflateStreamNative = this.native;
			if (deflateStreamNative != null)
			{
				deflateStreamNative.Dispose(num != 0L);
			}
			if (!this.disposed)
			{
				bool flag = this.leaveOpen;
				this.disposed = true;
				if (flag || this.base_stream != null)
				{
				}
			}
			base.Dispose(num != 0L);
		}

		// Token: 0x06001DC1 RID: 7617 RVA: 0x0004FC48 File Offset: 0x0004DE48
		private int ReadInternal(byte[] array, int offset, int count)
		{
			if (count == 0 || array != null)
			{
			}
			int num;
			return num;
		}

		// Token: 0x06001DC2 RID: 7618 RVA: 0x0004FC60 File Offset: 0x0004DE60
		internal ValueTask<int> ReadAsyncMemory(Memory<byte> destination, CancellationToken cancellationToken)
		{
			return base.ReadAsync(destination, cancellationToken);
		}

		// Token: 0x06001DC3 RID: 7619 RVA: 0x0004FC78 File Offset: 0x0004DE78
		internal int ReadCore(Span<byte> destination)
		{
			/*
An exception occurred when decompiling this method (06001DC3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.IO.Compression.DeflateStream::ReadCore(System.Span`1<System.Byte>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(ThrowHelper::ThrowArgumentOutOfRangeException)
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

		// Token: 0x06001DC4 RID: 7620 RVA: 0x0004FC98 File Offset: 0x0004DE98
		public override int Read(byte[] array, int offset, int count)
		{
			if (!this.disposed)
			{
				if (array == null)
				{
					goto IL_0020;
				}
				if (count != 0)
				{
					DeflateStreamNative deflateStreamNative = this.native;
					int num;
					return num;
				}
			}
			Type type = base.GetType();
			IL_0020:
			return "Dest or count is negative.";
		}

		// Token: 0x06001DC5 RID: 7621 RVA: 0x0004FCD0 File Offset: 0x0004DED0
		private void WriteInternal(byte[] array, int offset, int count)
		{
			if (count == 0)
			{
				return;
			}
			if (array != null)
			{
				return;
			}
			DeflateStreamNative deflateStreamNative = this.native;
		}

		// Token: 0x06001DC6 RID: 7622 RVA: 0x0004FCEC File Offset: 0x0004DEEC
		internal ValueTask WriteAsyncMemory(ReadOnlyMemory<byte> source, CancellationToken cancellationToken)
		{
			return base.WriteAsync(source, cancellationToken);
		}

		// Token: 0x06001DC7 RID: 7623 RVA: 0x00002050 File Offset: 0x00000250
		internal void WriteCore(ReadOnlySpan<byte> source)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001DC8 RID: 7624 RVA: 0x0004FD04 File Offset: 0x0004DF04
		public override void Write(byte[] array, int offset, int count)
		{
			if (!this.disposed)
			{
				if (array != null)
				{
					if (count != 0)
					{
						DeflateStreamNative deflateStreamNative = this.native;
						return;
					}
					return;
				}
			}
			else
			{
				Type type = base.GetType();
			}
		}

		// Token: 0x06001DC9 RID: 7625 RVA: 0x0004FD34 File Offset: 0x0004DF34
		public override void Flush()
		{
			/*
An exception occurred when decompiling this method (06001DC9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.IO.Compression.DeflateStream::Flush()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0015:
	stloc:Type(var_0_1B, call:Type(object::GetType, ldloc:DeflateStream[exp:object](this)))
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

		// Token: 0x06001DCA RID: 7626 RVA: 0x0004FD5C File Offset: 0x0004DF5C
		public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState)
		{
			if (!this.disposed)
			{
				if (array != null)
				{
					IAsyncResult asyncResult;
					return asyncResult;
				}
			}
			else
			{
				Type type = base.GetType();
			}
			return "count";
		}

		// Token: 0x06001DCB RID: 7627 RVA: 0x0004FD84 File Offset: 0x0004DF84
		public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState)
		{
			if (!this.disposed)
			{
				if (array != null)
				{
					IAsyncResult asyncResult;
					return asyncResult;
				}
			}
			else
			{
				Type type = base.GetType();
			}
			return "count";
		}

		// Token: 0x06001DCC RID: 7628 RVA: 0x0004FDAC File Offset: 0x0004DFAC
		public override int EndRead(IAsyncResult asyncResult)
		{
			/*
An exception occurred when decompiling this method (06001DCC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.IO.Compression.DeflateStream::EndRead(System.IAsyncResult)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	brtrue(IL_0000, logicnot:bool(ldloc:IAsyncResult[exp:bool](asyncResult)))
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

		// Token: 0x06001DCD RID: 7629 RVA: 0x0004FDC0 File Offset: 0x0004DFC0
		public override void EndWrite(IAsyncResult asyncResult)
		{
			while (asyncResult == null)
			{
			}
			if (asyncResult != null)
			{
				return;
			}
		}

		// Token: 0x06001DCE RID: 7630 RVA: 0x00002050 File Offset: 0x00000250
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001DCF RID: 7631 RVA: 0x00002050 File Offset: 0x00000250
		public override void SetLength(long value)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06001DD0 RID: 7632 RVA: 0x0004FDD4 File Offset: 0x0004DFD4
		public override bool CanRead
		{
			get
			{
				while (!this.disposed && this.mode == CompressionMode.Decompress)
				{
				}
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x06001DD1 RID: 7633 RVA: 0x0004FDF4 File Offset: 0x0004DFF4
		public override bool CanSeek
		{
			get
			{
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06001DD2 RID: 7634 RVA: 0x0004FE04 File Offset: 0x0004E004
		public override bool CanWrite
		{
			get
			{
				if (!this.disposed)
				{
					CompressionMode compressionMode = this.mode;
					Stream stream = this.base_stream;
					return;
				}
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06001DD3 RID: 7635 RVA: 0x00002050 File Offset: 0x00000250
		public override long Length
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06001DD4 RID: 7636 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001DD5 RID: 7637 RVA: 0x00002050 File Offset: 0x00000250
		public override long Position
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x0400140A RID: 5130
		private Stream base_stream;

		// Token: 0x0400140B RID: 5131
		private CompressionMode mode;

		// Token: 0x0400140C RID: 5132
		private bool leaveOpen;

		// Token: 0x0400140D RID: 5133
		private bool disposed;

		// Token: 0x0400140E RID: 5134
		private DeflateStreamNative native;

		// Token: 0x0200043E RID: 1086
		private sealed class ReadMethod : MulticastDelegate
		{
			// Token: 0x06001DD6 RID: 7638 RVA: 0x0004FE28 File Offset: 0x0004E028
			public ReadMethod(object @object, IntPtr method)
			{
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06001DD7 RID: 7639 RVA: 0x0004FE74 File Offset: 0x0004E074
			public int Invoke(byte[] array, int offset, int count)
			{
				/*
An exception occurred when decompiling this method (06001DD7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.IO.Compression.DeflateStream/ReadMethod::Invoke(System.Byte[],System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(Delegate::method_code, ldloc:ReadMethod[exp:Delegate](this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:ReadMethod[exp:Delegate](this)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method, ldloc:ReadMethod[exp:Delegate](this)))
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

			// Token: 0x06001DD8 RID: 7640 RVA: 0x00002050 File Offset: 0x00000250
			public IAsyncResult BeginInvoke(byte[] array, int offset, int count, AsyncCallback callback, object @object)
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06001DD9 RID: 7641 RVA: 0x00002050 File Offset: 0x00000250
			public int EndInvoke(IAsyncResult result)
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x0200043F RID: 1087
		private sealed class WriteMethod : MulticastDelegate
		{
			// Token: 0x06001DDA RID: 7642 RVA: 0x0004FE98 File Offset: 0x0004E098
			public WriteMethod(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06001DDB RID: 7643 RVA: 0x0004FEEC File Offset: 0x0004E0EC
			public void Invoke(byte[] array, int offset, int count)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}

			// Token: 0x06001DDC RID: 7644 RVA: 0x00002050 File Offset: 0x00000250
			public IAsyncResult BeginInvoke(byte[] array, int offset, int count, AsyncCallback callback, object @object)
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06001DDD RID: 7645 RVA: 0x0004FF10 File Offset: 0x0004E110
			public void EndInvoke(IAsyncResult result)
			{
			}
		}
	}
}
