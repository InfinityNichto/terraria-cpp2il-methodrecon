using System;
using System.IO;
using Cpp2IlInjected;

namespace Ionic.Zlib
{
	// Token: 0x0200005B RID: 91
	public class ZlibStream : Stream
	{
		// Token: 0x060003DE RID: 990 RVA: 0x0000F138 File Offset: 0x0000D338
		public ZlibStream(Stream stream, CompressionMode mode)
		{
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0000F148 File Offset: 0x0000D348
		public ZlibStream(Stream stream, CompressionMode mode, CompressionLevel level)
		{
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0000F158 File Offset: 0x0000D358
		public ZlibStream(Stream stream, CompressionMode mode, bool leaveOpen)
		{
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x0000F168 File Offset: 0x0000D368
		public ZlibStream(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen)
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x0000F180 File Offset: 0x0000D380
		// (set) Token: 0x060003E3 RID: 995 RVA: 0x0000F198 File Offset: 0x0000D398
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

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x0000F1BC File Offset: 0x0000D3BC
		// (set) Token: 0x060003E5 RID: 997 RVA: 0x0000F1D4 File Offset: 0x0000D3D4
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

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x0000F200 File Offset: 0x0000D400
		public virtual long TotalIn
		{
			get
			{
				return this._baseStream._z.TotalBytesIn;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x0000F220 File Offset: 0x0000D420
		public virtual long TotalOut
		{
			get
			{
				return this._baseStream._z.TotalBytesOut;
			}
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x0000F240 File Offset: 0x0000D440
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

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x0000F28C File Offset: 0x0000D48C
		public override bool CanRead
		{
			get
			{
				/*
An exception occurred when decompiling this method (060003E9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Ionic.Zlib.ZlibStream::get_CanRead()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Stream(var_0_13, ldfld:Stream(ZlibBaseStream::_stream, ldfld:ZlibBaseStream(ZlibStream::_baseStream, ldloc:ZlibStream(this))))
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

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x0000F2AC File Offset: 0x0000D4AC
		public override bool CanSeek
		{
			get
			{
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x0000F2BC File Offset: 0x0000D4BC
		public override bool CanWrite
		{
			get
			{
				/*
An exception occurred when decompiling this method (060003EB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Ionic.Zlib.ZlibStream::get_CanWrite()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Stream(var_0_13, ldfld:Stream(ZlibBaseStream::_stream, ldfld:ZlibBaseStream(ZlibStream::_baseStream, ldloc:ZlibStream(this))))
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

		// Token: 0x060003EC RID: 1004 RVA: 0x0000F2DC File Offset: 0x0000D4DC
		public override void Flush()
		{
			while (this._disposed)
			{
			}
			ZlibBaseStream baseStream = this._baseStream;
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x00002122 File Offset: 0x00000322
		public override long Length
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x0000F2F8 File Offset: 0x0000D4F8
		// (set) Token: 0x060003EF RID: 1007 RVA: 0x00002122 File Offset: 0x00000322
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

		// Token: 0x060003F0 RID: 1008 RVA: 0x0000F324 File Offset: 0x0000D524
		public override int Read(byte[] buffer, int offset, int count)
		{
			/*
An exception occurred when decompiling this method (060003F0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Ionic.Zlib.ZlibStream::Read(System.Byte[],System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ZlibBaseStream(var_0_0E, ldfld:ZlibBaseStream(ZlibStream::_baseStream, ldloc:ZlibStream(this)))
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

		// Token: 0x060003F1 RID: 1009 RVA: 0x00002122 File Offset: 0x00000322
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00002122 File Offset: 0x00000322
		public override void SetLength(long value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x0000F340 File Offset: 0x0000D540
		public override void Write(byte[] buffer, int offset, int count)
		{
			while (this._disposed)
			{
			}
			ZlibBaseStream baseStream = this._baseStream;
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x0000F35C File Offset: 0x0000D55C
		public static byte[] CompressString(string s)
		{
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0000F388 File Offset: 0x0000D588
		public static byte[] CompressBuffer(byte[] b)
		{
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0000F3B4 File Offset: 0x0000D5B4
		public static string UncompressString(byte[] compressed)
		{
			if (!false)
			{
				string text;
				return text;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x0000F3E0 File Offset: 0x0000D5E0
		public static byte[] UncompressBuffer(byte[] compressed)
		{
			if (!false)
			{
				byte[] array;
				return array;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x04000319 RID: 793
		internal ZlibBaseStream _baseStream;

		// Token: 0x0400031A RID: 794
		private bool _disposed;
	}
}
