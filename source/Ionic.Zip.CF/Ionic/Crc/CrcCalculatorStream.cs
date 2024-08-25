using System;
using System.IO;
using Cpp2IlInjected;

namespace Ionic.Crc
{
	// Token: 0x0200005D RID: 93
	public class CrcCalculatorStream : Stream, IDisposable
	{
		// Token: 0x0600040B RID: 1035 RVA: 0x0000F688 File Offset: 0x0000D888
		public CrcCalculatorStream(Stream stream)
		{
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x0000F698 File Offset: 0x0000D898
		public CrcCalculatorStream(Stream stream, bool leaveOpen)
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x0000F6A8 File Offset: 0x0000D8A8
		public CrcCalculatorStream(Stream stream, long length)
		{
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x0000F6B8 File Offset: 0x0000D8B8
		public CrcCalculatorStream(Stream stream, long length, bool leaveOpen)
		{
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x0000F6C8 File Offset: 0x0000D8C8
		public CrcCalculatorStream(Stream stream, long length, bool leaveOpen, CRC32 crc32)
		{
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x0000F6D8 File Offset: 0x0000D8D8
		private CrcCalculatorStream(bool leaveOpen, long length, Stream stream, CRC32 crc32)
		{
			this._lengthLimit = 1L;
			if (!true)
			{
			}
			base..ctor();
			this._innerStream = stream;
			if (crc32 == null)
			{
			}
			this._lengthLimit = length;
			this._leaveOpen = leaveOpen;
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x0000F710 File Offset: 0x0000D910
		public long TotalBytesSlurped
		{
			get
			{
				return this._Crc32._TotalBytesRead;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x0000F728 File Offset: 0x0000D928
		public int Crc
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000412)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Ionic.Crc.CrcCalculatorStream::get_Crc()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint32(var_0_0B, ldfld:uint32(CRC32::_register, ldfld:CRC32(CrcCalculatorStream::_Crc32, ldloc:CrcCalculatorStream(this))))
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

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x0000F740 File Offset: 0x0000D940
		// (set) Token: 0x06000414 RID: 1044 RVA: 0x0000F754 File Offset: 0x0000D954
		public bool LeaveOpen
		{
			get
			{
				return this._leaveOpen;
			}
			set
			{
			}
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0000F764 File Offset: 0x0000D964
		public override int Read(byte[] buffer, int offset, int count)
		{
			/*
An exception occurred when decompiling this method (06000415)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Ionic.Crc.CrcCalculatorStream::Read(System.Byte[],System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int64(var_0_06, ldfld:int64(CrcCalculatorStream::_lengthLimit, ldloc:CrcCalculatorStream(this)))
	stloc:CRC32(var_1_0D, ldfld:CRC32(CrcCalculatorStream::_Crc32, ldloc:CrcCalculatorStream(this)))
	stloc:int64(var_2_14, ldfld:int64(CrcCalculatorStream::_lengthLimit, ldloc:CrcCalculatorStream(this)))
	stloc:int64(var_3_1B, ldfld:int64(CRC32::_TotalBytesRead, ldloc:CRC32(var_1_0D)))
	stloc:Stream(var_4_22, ldfld:Stream(CrcCalculatorStream::_innerStream, ldloc:CrcCalculatorStream(this)))
	stloc:CRC32(var_5_2A, ldfld:CRC32(CrcCalculatorStream::_Crc32, ldloc:CrcCalculatorStream(this)))
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

		// Token: 0x06000416 RID: 1046 RVA: 0x0000F7A0 File Offset: 0x0000D9A0
		public override void Write(byte[] buffer, int offset, int count)
		{
			this._Crc32.SlurpBlock(buffer, offset, count);
			Stream innerStream = this._innerStream;
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x0000F7C4 File Offset: 0x0000D9C4
		public override bool CanRead
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000417)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Ionic.Crc.CrcCalculatorStream::get_CanRead()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Stream(var_0_06, ldfld:Stream(CrcCalculatorStream::_innerStream, ldloc:CrcCalculatorStream(this)))
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

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x0000F7D8 File Offset: 0x0000D9D8
		public override bool CanSeek
		{
			get
			{
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000419 RID: 1049 RVA: 0x0000F7E8 File Offset: 0x0000D9E8
		public override bool CanWrite
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000419)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Ionic.Crc.CrcCalculatorStream::get_CanWrite()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Stream(var_0_06, ldfld:Stream(CrcCalculatorStream::_innerStream, ldloc:CrcCalculatorStream(this)))
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

		// Token: 0x0600041A RID: 1050 RVA: 0x0000F7FC File Offset: 0x0000D9FC
		public override void Flush()
		{
			Stream innerStream = this._innerStream;
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x0000F810 File Offset: 0x0000DA10
		public override long Length
		{
			get
			{
				long lengthLimit = this._lengthLimit;
				Stream innerStream = this._innerStream;
				return this._lengthLimit;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x0000F834 File Offset: 0x0000DA34
		// (set) Token: 0x0600041D RID: 1053 RVA: 0x00002122 File Offset: 0x00000322
		public override long Position
		{
			get
			{
				return this._Crc32._TotalBytesRead;
			}
			set
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00002122 File Offset: 0x00000322
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00002122 File Offset: 0x00000322
		public override void SetLength(long value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x0000F84C File Offset: 0x0000DA4C
		void IDisposable.Dispose()
		{
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x0000F85C File Offset: 0x0000DA5C
		public override void Close()
		{
			base.Close();
			if (this._leaveOpen)
			{
				return;
			}
			Stream innerStream = this._innerStream;
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x0000F880 File Offset: 0x0000DA80
		// Note: this type is marked as 'beforefieldinit'.
		static CrcCalculatorStream()
		{
		}

		// Token: 0x04000321 RID: 801
		private static readonly long UnsetLengthLimit;

		// Token: 0x04000322 RID: 802
		internal Stream _innerStream;

		// Token: 0x04000323 RID: 803
		private CRC32 _Crc32;

		// Token: 0x04000324 RID: 804
		private long _lengthLimit;

		// Token: 0x04000325 RID: 805
		private bool _leaveOpen;
	}
}
