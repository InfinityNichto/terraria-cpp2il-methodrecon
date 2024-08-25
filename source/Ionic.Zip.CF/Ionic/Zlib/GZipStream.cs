using System;
using System.IO;
using System.Text;
using Cpp2IlInjected;
using Ionic.Crc;

namespace Ionic.Zlib
{
	// Token: 0x02000044 RID: 68
	public class GZipStream : Stream
	{
		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000359 RID: 857 RVA: 0x0000C598 File Offset: 0x0000A798
		// (set) Token: 0x0600035A RID: 858 RVA: 0x0000C5AC File Offset: 0x0000A7AC
		public string Comment
		{
			get
			{
				return this._Comment;
			}
			set
			{
				while (this._disposed)
				{
				}
				this._Comment = value;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600035B RID: 859 RVA: 0x0000C5C8 File Offset: 0x0000A7C8
		// (set) Token: 0x0600035C RID: 860 RVA: 0x0000C5DC File Offset: 0x0000A7DC
		public string FileName
		{
			get
			{
				return this._FileName;
			}
			set
			{
				if (!this._disposed)
				{
					this._FileName = value;
					if (value != null)
					{
						int num = value.IndexOf("/");
						string text = this._FileName.Replace("/", "\\");
						this._FileName = text;
						bool flag = text.EndsWith("\\");
						int num2 = this._FileName.IndexOf("\\");
						string fileName = Path.GetFileName(this._FileName);
						this._FileName = fileName;
					}
					return;
				}
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600035D RID: 861 RVA: 0x0000C658 File Offset: 0x0000A858
		public int Crc32
		{
			get
			{
				return this._Crc32;
			}
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0000C66C File Offset: 0x0000A86C
		public GZipStream(Stream stream, CompressionMode mode)
		{
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0000C67C File Offset: 0x0000A87C
		public GZipStream(Stream stream, CompressionMode mode, CompressionLevel level)
		{
		}

		// Token: 0x06000360 RID: 864 RVA: 0x0000C68C File Offset: 0x0000A88C
		public GZipStream(Stream stream, CompressionMode mode, bool leaveOpen)
		{
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0000C69C File Offset: 0x0000A89C
		public GZipStream(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen)
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000362 RID: 866 RVA: 0x0000C6B4 File Offset: 0x0000A8B4
		// (set) Token: 0x06000363 RID: 867 RVA: 0x0000C6CC File Offset: 0x0000A8CC
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

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000364 RID: 868 RVA: 0x0000C6F0 File Offset: 0x0000A8F0
		// (set) Token: 0x06000365 RID: 869 RVA: 0x0000C708 File Offset: 0x0000A908
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

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000366 RID: 870 RVA: 0x0000C734 File Offset: 0x0000A934
		public virtual long TotalIn
		{
			get
			{
				return this._baseStream._z.TotalBytesIn;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000367 RID: 871 RVA: 0x0000C754 File Offset: 0x0000A954
		public virtual long TotalOut
		{
			get
			{
				return this._baseStream._z.TotalBytesOut;
			}
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0000C774 File Offset: 0x0000A974
		protected override void Dispose(bool disposing)
		{
			if (!this._disposed)
			{
				if (this._baseStream != null)
				{
					CRC32 crc = this._baseStream.crc;
					uint register;
					if (crc != null)
					{
						register = crc._register;
					}
					this._Crc32 = (int)register;
				}
				this._disposed = true;
			}
			base.Dispose(disposing);
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000369 RID: 873 RVA: 0x0000C7E0 File Offset: 0x0000A9E0
		public override bool CanRead
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000369)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Ionic.Zlib.GZipStream::get_CanRead()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Stream(var_0_13, ldfld:Stream(ZlibBaseStream::_stream, ldfld:ZlibBaseStream(GZipStream::_baseStream, ldloc:GZipStream(this))))
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

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600036A RID: 874 RVA: 0x0000C800 File Offset: 0x0000AA00
		public override bool CanSeek
		{
			get
			{
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600036B RID: 875 RVA: 0x0000C810 File Offset: 0x0000AA10
		public override bool CanWrite
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600036B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Ionic.Zlib.GZipStream::get_CanWrite()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Stream(var_0_13, ldfld:Stream(ZlibBaseStream::_stream, ldfld:ZlibBaseStream(GZipStream::_baseStream, ldloc:GZipStream(this))))
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

		// Token: 0x0600036C RID: 876 RVA: 0x0000C830 File Offset: 0x0000AA30
		public override void Flush()
		{
			while (this._disposed)
			{
			}
			ZlibBaseStream baseStream = this._baseStream;
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600036D RID: 877 RVA: 0x00002122 File Offset: 0x00000322
		public override long Length
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600036E RID: 878 RVA: 0x0000C84C File Offset: 0x0000AA4C
		// (set) Token: 0x0600036F RID: 879 RVA: 0x00002122 File Offset: 0x00000322
		public override long Position
		{
			get
			{
				ZlibBaseStream baseStream = this._baseStream;
				if (baseStream._streamMode == ZlibBaseStream.StreamMode.Writer)
				{
					ZlibCodec z = baseStream._z;
					ZlibCodec z2 = baseStream._z;
				}
				return 0L;
			}
			set
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0000C878 File Offset: 0x0000AA78
		public override int Read(byte[] buffer, int offset, int count)
		{
			/*
An exception occurred when decompiling this method (06000370)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Ionic.Zlib.GZipStream::Read(System.Byte[],System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	stloc:ZlibBaseStream(var_1_1D, ldfld:ZlibBaseStream(GZipStream::_baseStream, ldloc:GZipStream(this)))
	stfld:bool(GZipStream::_firstReadDone, ldloc:GZipStream(this), ldc.i4:bool(1))
	stloc:string(var_2_2B, ldfld:string(ZlibBaseStream::_GzipFileName, ldloc:ZlibBaseStream(var_1_1D)))
	callsetter:string(GZipStream::set_FileName, ldloc:GZipStream(this), ldloc:string(var_2_2B))
	stloc:string(var_3_3E, ldfld:string(ZlibBaseStream::_GzipComment, ldfld:ZlibBaseStream(GZipStream::_baseStream, ldloc:GZipStream(this))))
	callsetter:string(GZipStream::set_Comment, ldloc:GZipStream(this), ldloc:string(var_3_3E))
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

		// Token: 0x06000371 RID: 881 RVA: 0x00002122 File Offset: 0x00000322
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00002122 File Offset: 0x00000322
		public override void SetLength(long value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0000C8CC File Offset: 0x0000AACC
		public override void Write(byte[] buffer, int offset, int count)
		{
			while (!this._disposed)
			{
				ZlibBaseStream baseStream = this._baseStream;
				ZlibBaseStream.StreamMode streamMode = baseStream._streamMode;
				if (baseStream._compressionMode == CompressionMode.Compress)
				{
					int num = this.EmitHeader();
					ZlibBaseStream baseStream2 = this._baseStream;
					this._headerByteCount = num;
					return;
				}
			}
		}

		// Token: 0x06000374 RID: 884 RVA: 0x0000C910 File Offset: 0x0000AB10
		private int EmitHeader()
		{
			/*
An exception occurred when decompiling this method (06000374)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Ionic.Zlib.GZipStream::EmitHeader()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0088:
	stloc:Stream(var_16_93, ldfld:Stream(ZlibBaseStream::_stream, ldfld:ZlibBaseStream(GZipStream::_baseStream, ldloc:GZipStream(this))))
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

		// Token: 0x06000375 RID: 885 RVA: 0x0000C9B4 File Offset: 0x0000ABB4
		public static byte[] CompressString(string s)
		{
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0000C9E0 File Offset: 0x0000ABE0
		public static byte[] CompressBuffer(byte[] b)
		{
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000377 RID: 887 RVA: 0x0000CA0C File Offset: 0x0000AC0C
		public static string UncompressString(byte[] compressed)
		{
			if (!false)
			{
				string text;
				return text;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0000CA38 File Offset: 0x0000AC38
		public static byte[] UncompressBuffer(byte[] compressed)
		{
			if (!false)
			{
				byte[] array;
				return array;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000379 RID: 889 RVA: 0x0000CA64 File Offset: 0x0000AC64
		// Note: this type is marked as 'beforefieldinit'.
		static GZipStream()
		{
			Encoding encoding = Encoding.GetEncoding("iso-8859-1");
		}

		// Token: 0x0400022F RID: 559
		public DateTime? LastModified;

		// Token: 0x04000230 RID: 560
		private int _headerByteCount;

		// Token: 0x04000231 RID: 561
		internal ZlibBaseStream _baseStream;

		// Token: 0x04000232 RID: 562
		private bool _disposed;

		// Token: 0x04000233 RID: 563
		private bool _firstReadDone;

		// Token: 0x04000234 RID: 564
		private string _FileName;

		// Token: 0x04000235 RID: 565
		private string _Comment;

		// Token: 0x04000236 RID: 566
		private int _Crc32;

		// Token: 0x04000237 RID: 567
		internal static readonly DateTime _unixEpoch;

		// Token: 0x04000238 RID: 568
		internal static readonly Encoding iso8859dash1;
	}
}
