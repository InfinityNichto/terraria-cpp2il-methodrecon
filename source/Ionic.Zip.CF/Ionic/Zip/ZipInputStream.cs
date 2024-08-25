using System;
using System.IO;
using System.Text;
using Cpp2IlInjected;
using Ionic.Crc;

namespace Ionic.Zip
{
	// Token: 0x0200002F RID: 47
	public class ZipInputStream : Stream
	{
		// Token: 0x06000227 RID: 551 RVA: 0x00008184 File Offset: 0x00006384
		public ZipInputStream(Stream stream)
		{
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00008194 File Offset: 0x00006394
		public ZipInputStream(string fileName)
		{
			if (!true)
			{
			}
			base..ctor();
			FileStream fileStream = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
			long num = 0L;
			this._Init(fileStream, num != 0L, fileName);
		}

		// Token: 0x06000229 RID: 553 RVA: 0x000081C0 File Offset: 0x000063C0
		public ZipInputStream(Stream stream, bool leaveOpen)
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x0600022A RID: 554 RVA: 0x000081D8 File Offset: 0x000063D8
		private void _Init(Stream stream, bool leaveOpen, string name)
		{
			this._inputStream = stream;
			Encoding encoding = Encoding.GetEncoding("IBM437");
			this._provisionalAlternateEncoding = encoding;
			this._leaveUnderlyingStreamOpen = stream != null;
			this._findRequired = true;
			this._name = "(stream)";
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00008218 File Offset: 0x00006418
		public override string ToString()
		{
			bool leaveUnderlyingStreamOpen = this._leaveUnderlyingStreamOpen;
			string name = this._name;
			string text;
			return text;
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600022C RID: 556 RVA: 0x00008234 File Offset: 0x00006434
		// (set) Token: 0x0600022D RID: 557 RVA: 0x00008248 File Offset: 0x00006448
		public Encoding ProvisionalAlternateEncoding
		{
			get
			{
				return this._provisionalAlternateEncoding;
			}
			set
			{
				this._provisionalAlternateEncoding = value;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600022E RID: 558 RVA: 0x0000825C File Offset: 0x0000645C
		// (set) Token: 0x0600022F RID: 559 RVA: 0x00008270 File Offset: 0x00006470
		public int CodecBufferSize
		{
			get
			{
				return this.<CodecBufferSize>k__BackingField;
			}
			set
			{
				this.<CodecBufferSize>k__BackingField = value;
			}
		}

		// Token: 0x17000084 RID: 132
		// (set) Token: 0x06000230 RID: 560 RVA: 0x00008284 File Offset: 0x00006484
		public string Password
		{
			set
			{
				/*
An exception occurred when decompiling this method (06000230)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Ionic.Zip.ZipInputStream::set_Password(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0010:
	stfld:bool(ZipInputStream::_exceptionPending, ldloc:ZipInputStream(this), ldc.i4:bool(1))
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

		// Token: 0x06000231 RID: 561 RVA: 0x000082A8 File Offset: 0x000064A8
		private void SetupStream()
		{
			ZipEntry currentEntry = this._currentEntry;
			string password = this._Password;
			CrcCalculatorStream crcCalculatorStream = currentEntry.InternalOpenReader(password);
			this._crcStream = crcCalculatorStream;
			this._LeftToRead = crcCalculatorStream;
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000232 RID: 562 RVA: 0x000082DC File Offset: 0x000064DC
		internal Stream ReadStream
		{
			get
			{
				return this._inputStream;
			}
		}

		// Token: 0x06000233 RID: 563 RVA: 0x000082F0 File Offset: 0x000064F0
		public override int Read(byte[] buffer, int offset, int count)
		{
			while (this._closed)
			{
			}
			Stream inputStream2;
			if (this._needSetup)
			{
				ZipEntry currentEntry = this._currentEntry;
				string password = this._Password;
				CrcCalculatorStream crcCalculatorStream = currentEntry.InternalOpenReader(password);
				this._crcStream = crcCalculatorStream;
				this._LeftToRead = crcCalculatorStream;
				if (crcCalculatorStream == null)
				{
					return;
				}
				CrcCalculatorStream crcStream = this._crcStream;
				long leftToRead = this._LeftToRead;
				this._LeftToRead = leftToRead;
				int crc = this._crcStream.Crc;
				this._currentEntry.VerifyCrcAfterExtract(crc);
				Stream inputStream = this._inputStream;
				long endOfEntry = this._endOfEntry;
				inputStream2 = this._inputStream;
				SharedUtilities.Workaround_Ladybug318918(inputStream2);
			}
			while (inputStream2 != null)
			{
			}
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0000838C File Offset: 0x0000658C
		public ZipEntry GetNextEntry()
		{
			bool findRequired = this._findRequired;
			if (findRequired)
			{
				Stream inputStream = this._inputStream;
				if (!findRequired)
				{
				}
				long num = SharedUtilities.FindSignature(inputStream, 19280);
				Stream inputStream2 = this._inputStream;
			}
			long num2;
			if (this._firstEntry)
			{
				Stream inputStream3 = this._inputStream;
				long endOfEntry = this._endOfEntry;
				Stream inputStream4 = this._inputStream;
				num2 = 0L;
				SharedUtilities.Workaround_Ladybug318918(inputStream4);
			}
			ZipContainer container = this._container;
			bool firstEntry = this._firstEntry;
			ZipEntry zipEntry = ZipEntry.ReadEntry(container, num2 != 0L);
			Stream inputStream5 = this._inputStream;
			this._currentEntry = zipEntry;
			this._endOfEntry = inputStream5;
			ZipEntry currentEntry = this._currentEntry;
			this._firstEntry = 257 != 0;
			return currentEntry;
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00008438 File Offset: 0x00006638
		protected override void Dispose(bool disposing)
		{
			if (!this._closed && !this._exceptionPending)
			{
				if (!this._leaveUnderlyingStreamOpen)
				{
					Stream inputStream = this._inputStream;
				}
				this._closed = true;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000236 RID: 566 RVA: 0x0000846C File Offset: 0x0000666C
		public override bool CanRead
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000237 RID: 567 RVA: 0x0000847C File Offset: 0x0000667C
		public override bool CanSeek
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000237)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Ionic.Zip.ZipInputStream::get_CanSeek()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Stream(var_0_06, ldfld:Stream(ZipInputStream::_inputStream, ldloc:ZipInputStream(this)))
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

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000238 RID: 568 RVA: 0x00008490 File Offset: 0x00006690
		public override bool CanWrite
		{
			get
			{
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000239 RID: 569 RVA: 0x000084A0 File Offset: 0x000066A0
		public override long Length
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000239)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int64 Ionic.Zip.ZipInputStream::get_Length()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Stream(var_0_06, ldfld:Stream(ZipInputStream::_inputStream, ldloc:ZipInputStream(this)))
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

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600023A RID: 570 RVA: 0x000084B4 File Offset: 0x000066B4
		// (set) Token: 0x0600023B RID: 571 RVA: 0x000084C8 File Offset: 0x000066C8
		public override long Position
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600023A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int64 Ionic.Zip.ZipInputStream::get_Position()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Stream(var_0_06, ldfld:Stream(ZipInputStream::_inputStream, ldloc:ZipInputStream(this)))
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
			set
			{
			}
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00002122 File Offset: 0x00000322
		public override void Flush()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00002122 File Offset: 0x00000322
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600023E RID: 574 RVA: 0x000084D8 File Offset: 0x000066D8
		public override long Seek(long offset, SeekOrigin origin)
		{
			/*
An exception occurred when decompiling this method (0600023E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int64 Ionic.Zip.ZipInputStream::Seek(System.Int64,System.IO.SeekOrigin)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Stream(var_0_06, ldfld:Stream(ZipInputStream::_inputStream, ldloc:ZipInputStream(this)))
	stfld:bool(ZipInputStream::_findRequired, ldloc:ZipInputStream(this), ldc.i4:bool(1))
	call:void(SharedUtilities::Workaround_Ladybug318918, ldfld:Stream(ZipInputStream::_inputStream, ldloc:ZipInputStream(this)))
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

		// Token: 0x0600023F RID: 575 RVA: 0x00002122 File Offset: 0x00000322
		public override void SetLength(long value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0400010E RID: 270
		private Stream _inputStream;

		// Token: 0x0400010F RID: 271
		private Encoding _provisionalAlternateEncoding;

		// Token: 0x04000110 RID: 272
		private ZipEntry _currentEntry;

		// Token: 0x04000111 RID: 273
		private bool _firstEntry;

		// Token: 0x04000112 RID: 274
		private bool _needSetup;

		// Token: 0x04000113 RID: 275
		private ZipContainer _container;

		// Token: 0x04000114 RID: 276
		private CrcCalculatorStream _crcStream;

		// Token: 0x04000115 RID: 277
		private long _LeftToRead;

		// Token: 0x04000116 RID: 278
		internal string _Password;

		// Token: 0x04000117 RID: 279
		private long _endOfEntry;

		// Token: 0x04000118 RID: 280
		private string _name;

		// Token: 0x04000119 RID: 281
		private bool _leaveUnderlyingStreamOpen;

		// Token: 0x0400011A RID: 282
		private bool _closed;

		// Token: 0x0400011B RID: 283
		private bool _findRequired;

		// Token: 0x0400011C RID: 284
		private bool _exceptionPending;

		// Token: 0x0400011D RID: 285
		private int <CodecBufferSize>k__BackingField;
	}
}
