using System;
using System.IO;
using Cpp2IlInjected;

namespace Ionic.Zlib
{
	// Token: 0x02000043 RID: 67
	public class DeflateStream : Stream
	{
		// Token: 0x0600033D RID: 829 RVA: 0x0000C280 File Offset: 0x0000A480
		public DeflateStream(Stream stream, CompressionMode mode)
		{
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0000C290 File Offset: 0x0000A490
		public DeflateStream(Stream stream, CompressionMode mode, CompressionLevel level)
		{
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0000C2A0 File Offset: 0x0000A4A0
		public DeflateStream(Stream stream, CompressionMode mode, bool leaveOpen)
		{
		}

		// Token: 0x06000340 RID: 832 RVA: 0x0000C2B0 File Offset: 0x0000A4B0
		public DeflateStream(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen)
		{
			if (!true)
			{
			}
			base..ctor();
			this._innerStream = stream;
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000341 RID: 833 RVA: 0x0000C2D0 File Offset: 0x0000A4D0
		// (set) Token: 0x06000342 RID: 834 RVA: 0x0000C2E8 File Offset: 0x0000A4E8
		public virtual FlushType FlushMode
		{
			get
			{
				return this._baseStream._flushMode;
			}
			set
			{
				while (this._disposed)
				{
				}
				this._baseStream._flushMode = value;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000343 RID: 835 RVA: 0x0000C30C File Offset: 0x0000A50C
		// (set) Token: 0x06000344 RID: 836 RVA: 0x0000C324 File Offset: 0x0000A524
		public int BufferSize
		{
			get
			{
				return this._baseStream._bufferSize;
			}
			set
			{
				while (!this._disposed)
				{
					ZlibBaseStream baseStream = this._baseStream;
					if (baseStream._workingBuffer == null)
					{
						baseStream._bufferSize = value;
						return;
					}
				}
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000345 RID: 837 RVA: 0x0000C350 File Offset: 0x0000A550
		// (set) Token: 0x06000346 RID: 838 RVA: 0x0000C368 File Offset: 0x0000A568
		public CompressionStrategy Strategy
		{
			get
			{
				return this._baseStream.Strategy;
			}
			set
			{
				while (this._disposed)
				{
				}
				this._baseStream.Strategy = value;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000347 RID: 839 RVA: 0x0000C38C File Offset: 0x0000A58C
		public virtual long TotalIn
		{
			get
			{
				return this._baseStream._z.TotalBytesIn;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000348 RID: 840 RVA: 0x0000C3AC File Offset: 0x0000A5AC
		public virtual long TotalOut
		{
			get
			{
				return this._baseStream._z.TotalBytesOut;
			}
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0000C3CC File Offset: 0x0000A5CC
		protected override void Dispose(bool disposing)
		{
			if (!this._disposed)
			{
				if (this._baseStream != null)
				{
				}
				this._disposed = true;
			}
			base.Dispose(disposing);
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600034A RID: 842 RVA: 0x0000C418 File Offset: 0x0000A618
		public override bool CanRead
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600034A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Ionic.Zlib.DeflateStream::get_CanRead()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Stream(var_0_13, ldfld:Stream(ZlibBaseStream::_stream, ldfld:ZlibBaseStream(DeflateStream::_baseStream, ldloc:DeflateStream(this))))
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

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600034B RID: 843 RVA: 0x0000C438 File Offset: 0x0000A638
		public override bool CanSeek
		{
			get
			{
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600034C RID: 844 RVA: 0x0000C448 File Offset: 0x0000A648
		public override bool CanWrite
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600034C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Ionic.Zlib.DeflateStream::get_CanWrite()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Stream(var_0_13, ldfld:Stream(ZlibBaseStream::_stream, ldfld:ZlibBaseStream(DeflateStream::_baseStream, ldloc:DeflateStream(this))))
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

		// Token: 0x0600034D RID: 845 RVA: 0x0000C468 File Offset: 0x0000A668
		public override void Flush()
		{
			while (this._disposed)
			{
			}
			ZlibBaseStream baseStream = this._baseStream;
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600034E RID: 846 RVA: 0x00002122 File Offset: 0x00000322
		public override long Length
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600034F RID: 847 RVA: 0x0000C484 File Offset: 0x0000A684
		// (set) Token: 0x06000350 RID: 848 RVA: 0x00002122 File Offset: 0x00000322
		public override long Position
		{
			get
			{
				ZlibBaseStream baseStream = this._baseStream;
				if (baseStream._streamMode == ZlibBaseStream.StreamMode.Writer)
				{
					byte[] outputBuffer = baseStream._z.OutputBuffer;
				}
				return 0L;
			}
			set
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0000C4B0 File Offset: 0x0000A6B0
		public override int Read(byte[] buffer, int offset, int count)
		{
			/*
An exception occurred when decompiling this method (06000351)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Ionic.Zlib.DeflateStream::Read(System.Byte[],System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ZlibBaseStream(var_0_0E, ldfld:ZlibBaseStream(DeflateStream::_baseStream, ldloc:DeflateStream(this)))
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

		// Token: 0x06000352 RID: 850 RVA: 0x00002122 File Offset: 0x00000322
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00002122 File Offset: 0x00000322
		public override void SetLength(long value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000354 RID: 852 RVA: 0x0000C4CC File Offset: 0x0000A6CC
		public override void Write(byte[] buffer, int offset, int count)
		{
			while (this._disposed)
			{
			}
			ZlibBaseStream baseStream = this._baseStream;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0000C4E8 File Offset: 0x0000A6E8
		public static byte[] CompressString(string s)
		{
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0000C514 File Offset: 0x0000A714
		public static byte[] CompressBuffer(byte[] b)
		{
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000357 RID: 855 RVA: 0x0000C540 File Offset: 0x0000A740
		public static string UncompressString(byte[] compressed)
		{
			if (!false)
			{
				string text;
				return text;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0000C56C File Offset: 0x0000A76C
		public static byte[] UncompressBuffer(byte[] compressed)
		{
			if (!false)
			{
				byte[] array;
				return array;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0400022C RID: 556
		internal ZlibBaseStream _baseStream;

		// Token: 0x0400022D RID: 557
		internal Stream _innerStream;

		// Token: 0x0400022E RID: 558
		private bool _disposed;
	}
}
