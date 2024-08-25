using System;
using System.Globalization;
using System.IO;
using System.Text;
using Cpp2IlInjected;
using Ionic.Crc;

namespace Ionic.Zlib
{
	// Token: 0x02000057 RID: 87
	internal class ZlibBaseStream : Stream
	{
		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060003AE RID: 942 RVA: 0x0000E624 File Offset: 0x0000C824
		internal int Crc32
		{
			get
			{
				CRC32 crc = this.crc;
				if (crc != null)
				{
					uint register = crc._register;
					return;
				}
			}
		}

		// Token: 0x060003AF RID: 943 RVA: 0x0000E644 File Offset: 0x0000C844
		public ZlibBaseStream(Stream stream, CompressionMode compressionMode, CompressionLevel level, ZlibStreamFlavor flavor, bool leaveOpen)
		{
			if (2 == 0)
			{
			}
			base..ctor();
			this._stream = stream;
			this._compressionMode = (CompressionMode)flavor;
			this._compressionMode = compressionMode;
			this._leaveOpen = level != CompressionLevel.None;
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x0000E68C File Offset: 0x0000C88C
		protected internal bool _wantCompress
		{
			get
			{
				/*
An exception occurred when decompiling this method (060003B0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Ionic.Zlib.ZlibBaseStream::get__wantCompress()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:CompressionMode(var_0_06, ldfld:CompressionMode(ZlibBaseStream::_compressionMode, ldloc:ZlibBaseStream(this)))
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

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x0000E6A0 File Offset: 0x0000C8A0
		private ZlibCodec z
		{
			get
			{
				if (this._z == null)
				{
					ZlibStreamFlavor flavor = this._flavor;
					CompressionMode compressionMode = this._compressionMode;
					CompressionStrategy strategy = this.Strategy;
					CompressionLevel level = this._level;
				}
				return this._z;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x0000E6DC File Offset: 0x0000C8DC
		private byte[] workingBuffer
		{
			get
			{
				/*
An exception occurred when decompiling this method (060003B2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] Ionic.Zlib.ZlibBaseStream::get_workingBuffer()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_0E, ldfld:int32(ZlibBaseStream::_bufferSize, ldloc:ZlibBaseStream(this)))
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

		// Token: 0x060003B3 RID: 947 RVA: 0x0000E6F8 File Offset: 0x0000C8F8
		public override void Write(byte[] buffer, int offset, int count)
		{
			CRC32 crc = this.crc;
			if (crc != null)
			{
				crc.SlurpBlock(buffer, offset, count);
			}
			if (this._streamMode != ZlibBaseStream.StreamMode.Writer)
			{
			}
			if (count == 0)
			{
				return;
			}
			this.z.InputBuffer = buffer;
			ZlibCodec z = this._z;
			z.NextIn = offset;
			z.TotalBytesIn = (long)count;
			byte[] workingBuffer = this.workingBuffer;
			z.OutputBuffer = workingBuffer;
			ZlibCodec z2 = this._z;
			byte[] workingBuffer2 = this._workingBuffer;
			z2.AvailableBytesOut = workingBuffer2;
			if (this._compressionMode != CompressionMode.Compress)
			{
				return;
			}
			FlushType flushMode = this._flushMode;
			Stream stream = this._stream;
			ZlibCodec z3 = this._z;
			byte[] workingBuffer3 = this._workingBuffer;
			int availableBytesOut = z3.AvailableBytesOut;
			ZlibCodec z4 = this._z;
			int availableBytesOut2;
			if (z4.AvailableBytesIn == 0)
			{
				availableBytesOut2 = z4.AvailableBytesOut;
			}
			ZlibStreamFlavor flavor = this._flavor;
			if (this._compressionMode != CompressionMode.Compress)
			{
				int availableBytesOut3 = z4.AvailableBytesOut;
				return;
			}
			while (availableBytesOut2 == 0)
			{
			}
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0000E7F4 File Offset: 0x0000C9F4
		private void finish()
		{
			ZlibCodec z = this._z;
			if (z == null || this._streamMode != ZlibBaseStream.StreamMode.Writer)
			{
				return;
			}
			byte[] workingBuffer = this.workingBuffer;
			z.OutputBuffer = workingBuffer;
			ZlibCodec z2 = this._z;
			byte[] workingBuffer2 = this._workingBuffer;
			z2.AvailableBytesOut = workingBuffer2;
			if (this._compressionMode != CompressionMode.Compress)
			{
				return;
			}
			ZlibCodec z3 = this._z;
			byte[] workingBuffer3 = this._workingBuffer;
			int availableBytesOut = z3.AvailableBytesOut;
			Stream stream = this._stream;
			ZlibCodec z4 = this._z;
			if (z4.AvailableBytesIn != 0)
			{
				return;
			}
			int availableBytesOut2 = z4.AvailableBytesOut;
			ZlibStreamFlavor flavor = this._flavor;
			if (this._compressionMode != CompressionMode.Compress)
			{
				int availableBytesOut3 = z4.AvailableBytesOut;
				return;
			}
			while (availableBytesOut2 == 0)
			{
			}
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0000E910 File Offset: 0x0000CB10
		private void end()
		{
			if (this.z != null)
			{
				CompressionMode compressionMode = this._compressionMode;
				ZlibCodec z = this._z;
				if (compressionMode != CompressionMode.Compress)
				{
					int num = z.EndInflate();
					return;
				}
			}
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0000E940 File Offset: 0x0000CB40
		public override void Close()
		{
			if (this._stream != null)
			{
				this.finish();
				long num = 0L;
				this.end();
				if (!this._leaveOpen)
				{
					Stream stream = this._stream;
				}
				if (num != 0L)
				{
					throw new OutOfMemoryException();
				}
			}
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0000E9A0 File Offset: 0x0000CBA0
		public override void Flush()
		{
			Stream stream = this._stream;
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00002122 File Offset: 0x00000322
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0000E9B4 File Offset: 0x0000CBB4
		public override void SetLength(long value)
		{
			Stream stream = this._stream;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0000E9C8 File Offset: 0x0000CBC8
		private string ReadZeroTerminatedString()
		{
			/*
An exception occurred when decompiling this method (060003BA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Ionic.Zlib.ZlibBaseStream::ReadZeroTerminatedString()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8[](var_3_1E, ldfld:uint8[](ZlibBaseStream::_buf1, ldloc:ZlibBaseStream(this)))
	stloc:Stream(var_4_25, ldfld:Stream(ZlibBaseStream::_stream, ldloc:ZlibBaseStream(this)))
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

		// Token: 0x060003BB RID: 955 RVA: 0x0000E9FC File Offset: 0x0000CBFC
		private int _ReadAndValidateGzipHeader()
		{
			int num;
			if (this._stream != null)
			{
				DateTime dateTime;
				this._GzipMtime = dateTime;
				num = 10;
				string text = this.ReadZeroTerminatedString();
				this._GzipFileName = text;
				byte[] buf = this._buf1;
			}
			return num;
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0000EA64 File Offset: 0x0000CC64
		public override int Read(byte[] buffer, int offset, int count)
		{
			do
			{
				ZlibBaseStream.StreamMode streamMode = this._streamMode;
				Stream stream = this._stream;
				int num = 1;
				this._streamMode = (ZlibBaseStream.StreamMode)num;
				ZlibCodec z = this.z;
				ZlibStreamFlavor flavor = this._flavor;
				int num2 = this._ReadAndValidateGzipHeader();
				this._gzipHeaderByteCount = num2;
				if (num2 == 0)
				{
					goto IL_0124;
				}
				ZlibBaseStream.StreamMode streamMode2 = this._streamMode;
				if (count == 0 || (this.nomoreinput && this._compressionMode == CompressionMode.Compress))
				{
					goto IL_0124;
				}
			}
			while (buffer == null);
			ZlibCodec z2 = this._z;
			z2.OutputBuffer = buffer;
			z2.NextOut = offset;
			z2.TotalBytesOut = (long)count;
			byte[] workingBuffer = this.workingBuffer;
			z2.InputBuffer = workingBuffer;
			ZlibCodec z3 = this._z;
			int num3 = 1;
			ZlibCodec z4;
			if (z3.AvailableBytesIn == 0 && !this.nomoreinput)
			{
				Stream stream2 = this._stream;
				byte[] workingBuffer2 = this._workingBuffer;
				z3.AvailableBytesIn = stream2;
				z4 = this._z;
				if (z4.AvailableBytesIn == 0)
				{
					this.nomoreinput = num3 != 0;
				}
			}
			if (this._compressionMode != CompressionMode.Compress)
			{
				int num4;
				return num4;
			}
			FlushType flushMode = this._flushMode;
			int num5 = z4.Deflate(flushMode);
			bool flag = this.nomoreinput;
			if (num5 == 0)
			{
				int availableBytesOut = this._z.AvailableBytesOut;
				if (num5 == 0)
				{
					return num5;
				}
			}
			else
			{
				if (count == 0)
				{
					return "de";
				}
				return "Cannot Read after Writing.";
			}
			IL_0124:
			if (!flag || !flag)
			{
			}
			int num6;
			while (num6 == 0)
			{
			}
			return num6;
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060003BD RID: 957 RVA: 0x0000EBBC File Offset: 0x0000CDBC
		public override bool CanRead
		{
			get
			{
				/*
An exception occurred when decompiling this method (060003BD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Ionic.Zlib.ZlibBaseStream::get_CanRead()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Stream(var_0_06, ldfld:Stream(ZlibBaseStream::_stream, ldloc:ZlibBaseStream(this)))
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

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060003BE RID: 958 RVA: 0x0000EBD0 File Offset: 0x0000CDD0
		public override bool CanSeek
		{
			get
			{
				/*
An exception occurred when decompiling this method (060003BE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Ionic.Zlib.ZlibBaseStream::get_CanSeek()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Stream(var_0_06, ldfld:Stream(ZlibBaseStream::_stream, ldloc:ZlibBaseStream(this)))
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

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060003BF RID: 959 RVA: 0x0000EBE4 File Offset: 0x0000CDE4
		public override bool CanWrite
		{
			get
			{
				/*
An exception occurred when decompiling this method (060003BF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Ionic.Zlib.ZlibBaseStream::get_CanWrite()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Stream(var_0_06, ldfld:Stream(ZlibBaseStream::_stream, ldloc:ZlibBaseStream(this)))
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

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x0000EBF8 File Offset: 0x0000CDF8
		public override long Length
		{
			get
			{
				/*
An exception occurred when decompiling this method (060003C0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int64 Ionic.Zlib.ZlibBaseStream::get_Length()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Stream(var_0_06, ldfld:Stream(ZlibBaseStream::_stream, ldloc:ZlibBaseStream(this)))
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

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x00002122 File Offset: 0x00000322
		// (set) Token: 0x060003C2 RID: 962 RVA: 0x00002122 File Offset: 0x00000322
		public override long Position
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0000EC0C File Offset: 0x0000CE0C
		public static void CompressString(string s, Stream compressor)
		{
			CodePageDataItem dataItem = Encoding.UTF8.dataItem;
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0000EC40 File Offset: 0x0000CE40
		public static void CompressBuffer(byte[] b, Stream compressor)
		{
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0000EC68 File Offset: 0x0000CE68
		public static string UncompressString(byte[] compressed, Stream decompressor)
		{
			Encoding utf = Encoding.UTF8;
			if (compressed != null)
			{
			}
			long num = 0L;
			byte value = compressed.m_value;
			if (num == 0L)
			{
				if (!false)
				{
				}
				throw new OutOfMemoryException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0000ECE8 File Offset: 0x0000CEE8
		public static byte[] UncompressBuffer(byte[] compressed, Stream decompressor)
		{
			if (compressed != null)
			{
			}
			return compressed;
		}

		// Token: 0x040002EA RID: 746
		protected internal ZlibCodec _z;

		// Token: 0x040002EB RID: 747
		protected internal ZlibBaseStream.StreamMode _streamMode = ZlibBaseStream.StreamMode.Undefined;

		// Token: 0x040002EC RID: 748
		protected internal FlushType _flushMode;

		// Token: 0x040002ED RID: 749
		protected internal ZlibStreamFlavor _flavor;

		// Token: 0x040002EE RID: 750
		protected internal CompressionMode _compressionMode;

		// Token: 0x040002EF RID: 751
		protected internal CompressionLevel _level;

		// Token: 0x040002F0 RID: 752
		protected internal bool _leaveOpen;

		// Token: 0x040002F1 RID: 753
		protected internal byte[] _workingBuffer;

		// Token: 0x040002F2 RID: 754
		protected internal int _bufferSize = 8192;

		// Token: 0x040002F3 RID: 755
		protected internal byte[] _buf1;

		// Token: 0x040002F4 RID: 756
		protected internal Stream _stream;

		// Token: 0x040002F5 RID: 757
		protected internal CompressionStrategy Strategy;

		// Token: 0x040002F6 RID: 758
		private CRC32 crc;

		// Token: 0x040002F7 RID: 759
		protected internal string _GzipFileName;

		// Token: 0x040002F8 RID: 760
		protected internal string _GzipComment;

		// Token: 0x040002F9 RID: 761
		protected internal DateTime _GzipMtime;

		// Token: 0x040002FA RID: 762
		protected internal int _gzipHeaderByteCount;

		// Token: 0x040002FB RID: 763
		private bool nomoreinput;

		// Token: 0x02000058 RID: 88
		internal enum StreamMode
		{
			// Token: 0x040002FD RID: 765
			Writer,
			// Token: 0x040002FE RID: 766
			Reader,
			// Token: 0x040002FF RID: 767
			Undefined
		}
	}
}
