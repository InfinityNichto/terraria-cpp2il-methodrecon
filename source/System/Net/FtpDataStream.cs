using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace System.Net
{
	// Token: 0x0200014D RID: 333
	internal class FtpDataStream : Stream, ICloseEx
	{
		// Token: 0x06000826 RID: 2086 RVA: 0x0001CA1C File Offset: 0x0001AC1C
		internal FtpDataStream(global::System.Net.Sockets.NetworkStream networkStream, FtpWebRequest request, TriState writeOnly)
		{
			if (!true)
			{
			}
			base..ctor();
			if (!true)
			{
			}
			bool isEnabled = NetEventSource.IsEnabled;
			if (!true)
			{
			}
			this._writeable = 257 != 0;
			if (writeOnly != TriState.False)
			{
				return;
			}
			this._request = request;
			this._networkStream = networkStream;
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x0001CA60 File Offset: 0x0001AC60
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x0001CA9C File Offset: 0x0001AC9C
		void ICloseEx.CloseEx(CloseExState closeState)
		{
			if (!true)
			{
			}
			bool isEnabled = NetEventSource.IsEnabled;
			FormattableString formattableString;
			NetEventSource.Info(this, formattableString, "CloseEx");
			if (this._closing)
			{
				return;
			}
			int num = 1;
			long num2 = 0L;
			this._closing = num != 0;
			int num3 = 5;
			long num4;
			if (num != 0)
			{
				num4 = 0L;
				Monitor.Exit(this);
			}
			if (num2 != 0L)
			{
				throw new OutOfMemoryException();
			}
			if (num3 == 0)
			{
				global::System.Net.Sockets.NetworkStream networkStream = this._networkStream;
				networkStream.Close((int)num4);
				return;
			}
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x0001CB8C File Offset: 0x0001AD8C
		private void CheckError()
		{
			/*
An exception occurred when decompiling this method (06000829)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Net.FtpDataStream::CheckError()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000E:
	stloc:WebException(var_1_15, callgetter:WebException(ExceptionHelper::get_RequestAbortedException))
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

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600082A RID: 2090 RVA: 0x0001CBB0 File Offset: 0x0001ADB0
		public override bool CanRead
		{
			get
			{
				return this._readable;
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x0600082B RID: 2091 RVA: 0x0001CBC4 File Offset: 0x0001ADC4
		public override bool CanSeek
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600082B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.FtpDataStream::get_CanSeek()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:NetworkStream(var_0_06, ldfld:NetworkStream(FtpDataStream::_networkStream, ldloc:FtpDataStream(this)))
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

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600082C RID: 2092 RVA: 0x0001CBD8 File Offset: 0x0001ADD8
		public override bool CanWrite
		{
			get
			{
				return this._writeable;
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x0600082D RID: 2093 RVA: 0x0001CBEC File Offset: 0x0001ADEC
		public override long Length
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600082D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int64 System.Net.FtpDataStream::get_Length()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:NetworkStream(var_0_06, ldfld:NetworkStream(FtpDataStream::_networkStream, ldloc:FtpDataStream(this)))
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

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x0600082E RID: 2094 RVA: 0x0001CC00 File Offset: 0x0001AE00
		// (set) Token: 0x0600082F RID: 2095 RVA: 0x0001CC14 File Offset: 0x0001AE14
		public override long Position
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600082E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int64 System.Net.FtpDataStream::get_Position()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:NetworkStream(var_0_06, ldfld:NetworkStream(FtpDataStream::_networkStream, ldloc:FtpDataStream(this)))
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
				global::System.Net.Sockets.NetworkStream networkStream = this._networkStream;
			}
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x0001CC28 File Offset: 0x0001AE28
		public override long Seek(long offset, SeekOrigin origin)
		{
			this.CheckError();
			global::System.Net.Sockets.NetworkStream networkStream = this._networkStream;
			this.CheckError();
			throw new OutOfMemoryException();
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x0001CC50 File Offset: 0x0001AE50
		public override int Read(byte[] buffer, int offset, int size)
		{
			this.CheckError();
			if (this._networkStream == null)
			{
				int num = 1;
				this._isFullyRead = num != 0;
			}
			this.CheckError();
			throw new OutOfMemoryException();
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x0001CC84 File Offset: 0x0001AE84
		public override void Write(byte[] buffer, int offset, int size)
		{
			this.CheckError();
			global::System.Net.Sockets.NetworkStream networkStream = this._networkStream;
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x0001CCAC File Offset: 0x0001AEAC
		private void AsyncReadCallback(IAsyncResult ar)
		{
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x0001CCF0 File Offset: 0x0001AEF0
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
		{
			this.CheckError();
			global::System.Net.Sockets.NetworkStream networkStream = this._networkStream;
			this.CheckError();
			throw new OutOfMemoryException();
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x0001CD18 File Offset: 0x0001AF18
		public override int EndRead(IAsyncResult ar)
		{
			if (ar != null)
			{
			}
			object obj;
			if (obj != null)
			{
			}
			this.CheckError();
			throw new InvalidCastException();
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x0001CD60 File Offset: 0x0001AF60
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
		{
			this.CheckError();
			global::System.Net.Sockets.NetworkStream networkStream = this._networkStream;
			this.CheckError();
			throw new OutOfMemoryException();
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x0001CD88 File Offset: 0x0001AF88
		public override void EndWrite(IAsyncResult asyncResult)
		{
			global::System.Net.Sockets.NetworkStream networkStream = this._networkStream;
			this.CheckError();
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x0001CDC4 File Offset: 0x0001AFC4
		public override void Flush()
		{
			global::System.Net.Sockets.NetworkStream networkStream = this._networkStream;
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x0001CDD8 File Offset: 0x0001AFD8
		public override void SetLength(long value)
		{
			global::System.Net.Sockets.NetworkStream networkStream = this._networkStream;
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x0600083A RID: 2106 RVA: 0x0001CDEC File Offset: 0x0001AFEC
		public override bool CanTimeout
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600083A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.FtpDataStream::get_CanTimeout()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:NetworkStream(var_0_06, ldfld:NetworkStream(FtpDataStream::_networkStream, ldloc:FtpDataStream(this)))
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

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x0600083B RID: 2107 RVA: 0x0001CE00 File Offset: 0x0001B000
		// (set) Token: 0x0600083C RID: 2108 RVA: 0x0001CE14 File Offset: 0x0001B014
		public override int ReadTimeout
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600083B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Net.FtpDataStream::get_ReadTimeout()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:NetworkStream(var_0_06, ldfld:NetworkStream(FtpDataStream::_networkStream, ldloc:FtpDataStream(this)))
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
				global::System.Net.Sockets.NetworkStream networkStream = this._networkStream;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x0600083D RID: 2109 RVA: 0x0001CE28 File Offset: 0x0001B028
		// (set) Token: 0x0600083E RID: 2110 RVA: 0x0001CE3C File Offset: 0x0001B03C
		public override int WriteTimeout
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600083D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Net.FtpDataStream::get_WriteTimeout()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:NetworkStream(var_0_06, ldfld:NetworkStream(FtpDataStream::_networkStream, ldloc:FtpDataStream(this)))
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
				global::System.Net.Sockets.NetworkStream networkStream = this._networkStream;
			}
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x0001CE50 File Offset: 0x0001B050
		internal void SetSocketTimeoutOption(int timeout)
		{
			global::System.Net.Sockets.NetworkStream networkStream = this._networkStream;
			global::System.Net.Sockets.NetworkStream networkStream2 = this._networkStream;
		}

		// Token: 0x04000697 RID: 1687
		private FtpWebRequest _request;

		// Token: 0x04000698 RID: 1688
		private global::System.Net.Sockets.NetworkStream _networkStream;

		// Token: 0x04000699 RID: 1689
		private bool _writeable;

		// Token: 0x0400069A RID: 1690
		private bool _readable;

		// Token: 0x0400069B RID: 1691
		private bool _isFullyRead;

		// Token: 0x0400069C RID: 1692
		private bool _closing;

		// Token: 0x0400069D RID: 1693
		private const int DefaultCloseTimeout = -1;
	}
}
