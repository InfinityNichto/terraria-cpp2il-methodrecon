using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace System.Net.Sockets
{
	// Token: 0x020002EA RID: 746
	public class NetworkStream : Stream
	{
		// Token: 0x06001301 RID: 4865 RVA: 0x0003AD4C File Offset: 0x00038F4C
		public NetworkStream(Socket socket)
		{
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x0003AD5C File Offset: 0x00038F5C
		public NetworkStream(Socket socket, bool ownsSocket)
		{
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x0003AD6C File Offset: 0x00038F6C
		public NetworkStream(Socket socket, FileAccess access, bool ownsSocket)
		{
			this._closeTimeout = 1;
			if (!true)
			{
			}
			base..ctor();
			if (socket == null)
			{
				return;
			}
			if (!socket.is_blocking)
			{
				return;
			}
			if (socket.is_connected)
			{
				SocketType socketType = socket.socketType;
				this._streamSocket = socket;
				this._ownsSocket = socketType != (SocketType)0;
				this._readable = true;
				return;
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06001304 RID: 4868 RVA: 0x0003ADC4 File Offset: 0x00038FC4
		public override bool CanRead
		{
			get
			{
				return this._readable;
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06001305 RID: 4869 RVA: 0x0003ADD8 File Offset: 0x00038FD8
		public override bool CanSeek
		{
			get
			{
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06001306 RID: 4870 RVA: 0x0003ADE8 File Offset: 0x00038FE8
		public override bool CanWrite
		{
			get
			{
				return this._writeable;
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06001307 RID: 4871 RVA: 0x0003ADFC File Offset: 0x00038FFC
		public override bool CanTimeout
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06001308 RID: 4872 RVA: 0x0003AE0C File Offset: 0x0003900C
		// (set) Token: 0x06001309 RID: 4873 RVA: 0x0003AE34 File Offset: 0x00039034
		public override int ReadTimeout
		{
			get
			{
				object socketOption = this._streamSocket.GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout);
				throw new InvalidCastException();
			}
			set
			{
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x0600130A RID: 4874 RVA: 0x0003AE44 File Offset: 0x00039044
		// (set) Token: 0x0600130B RID: 4875 RVA: 0x0003AE6C File Offset: 0x0003906C
		public override int WriteTimeout
		{
			get
			{
				object socketOption = this._streamSocket.GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendTimeout);
				throw new InvalidCastException();
			}
			set
			{
				long num = 0L;
				this.SetSocketTimeoutOption(SocketShutdown.Send, value, num != 0L);
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x0600130C RID: 4876 RVA: 0x0003AE84 File Offset: 0x00039084
		public virtual bool DataAvailable
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600130C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.Sockets.NetworkStream::get_DataAvailable()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0014:
	stloc:Type(var_1_1A, call:Type(object::GetType, ldloc:NetworkStream[exp:object](this)))
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

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x0600130D RID: 4877 RVA: 0x00002050 File Offset: 0x00000250
		public override long Length
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x0600130E RID: 4878 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600130F RID: 4879 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x06001310 RID: 4880 RVA: 0x00002050 File Offset: 0x00000250
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x0003AEAC File Offset: 0x000390AC
		public override int Read(byte[] buffer, int offset, int size)
		{
			if (!this._cleanedUp)
			{
				if (buffer != null)
				{
					Socket streamSocket = this._streamSocket;
					int num;
					return num;
				}
			}
			else
			{
				Type type = base.GetType();
			}
			return "offset";
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x0003AEDC File Offset: 0x000390DC
		public override int Read(Span<byte> destination)
		{
			Type type;
			bool flag = base.GetType() != type;
			return base.Read(destination);
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x00002050 File Offset: 0x00000250
		public override int ReadByte()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x0003AF18 File Offset: 0x00039118
		public override void Write(byte[] buffer, int offset, int size)
		{
			if (this._cleanedUp)
			{
				Type type = base.GetType();
				return;
			}
			if (buffer != null)
			{
				Socket streamSocket = this._streamSocket;
				return;
			}
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x0003AF44 File Offset: 0x00039144
		public override void Write(ReadOnlySpan<byte> source)
		{
			Type type;
			bool flag = base.GetType() != type;
			base.Write(source);
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x0003AF80 File Offset: 0x00039180
		public override void WriteByte(byte value)
		{
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x0003AF90 File Offset: 0x00039190
		public void Close(int timeout)
		{
			this._closeTimeout = timeout;
			base.Dispose();
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x0003AFAC File Offset: 0x000391AC
		protected override void Dispose(bool disposing)
		{
			bool cleanedUp = this._cleanedUp;
			this._cleanedUp = true;
			if (this._ownsSocket)
			{
				this._streamSocket.InternalShutdown(SocketShutdown.Send);
				Socket streamSocket = this._streamSocket;
				int closeTimeout = this._closeTimeout;
				streamSocket.linger_timeout = closeTimeout;
				streamSocket.Dispose();
			}
			base.Dispose(true);
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x0003B000 File Offset: 0x00039200
		protected override void Finalize()
		{
			base.Finalize();
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x0003B034 File Offset: 0x00039234
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
		{
			if (!this._cleanedUp)
			{
				if (buffer != null)
				{
					Socket streamSocket = this._streamSocket;
					IAsyncResult asyncResult;
					return asyncResult;
				}
			}
			else
			{
				Type type = base.GetType();
			}
			return "offset";
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x0003B064 File Offset: 0x00039264
		public override int EndRead(IAsyncResult asyncResult)
		{
			/*
An exception occurred when decompiling this method (0600131B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Net.Sockets.NetworkStream::EndRead(System.IAsyncResult)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0018:
	stloc:Type(var_0_1E, call:Type(object::GetType, ldloc:NetworkStream[exp:object](this)))
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

		// Token: 0x0600131C RID: 4892 RVA: 0x0003B090 File Offset: 0x00039290
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
		{
			if (!this._cleanedUp)
			{
				if (buffer != null)
				{
					Socket streamSocket = this._streamSocket;
					IAsyncResult asyncResult;
					return asyncResult;
				}
			}
			else
			{
				Type type = base.GetType();
			}
			return "offset";
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x0003B0D0 File Offset: 0x000392D0
		public override void EndWrite(IAsyncResult asyncResult)
		{
			if (!this._cleanedUp)
			{
				if (asyncResult != null)
				{
					int num = this._streamSocket.EndSend(asyncResult);
					return;
				}
			}
			else
			{
				Type type = base.GetType();
			}
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x0003B100 File Offset: 0x00039300
		public override Task<int> ReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			if (!this._cleanedUp)
			{
				if (buffer != null)
				{
					Socket streamSocket = this._streamSocket;
					ThrowHelper.ThrowArgumentOutOfRangeException();
					ValueTask<int> valueTask;
					return valueTask.AsTask();
				}
			}
			else
			{
				Socket streamSocket;
				Type type = streamSocket.GetType();
			}
			return "offset";
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x0003B13C File Offset: 0x0003933C
		public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken)
		{
			/*
An exception occurred when decompiling this method (0600131F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.ValueTask`1<System.Int32> System.Net.Sockets.NetworkStream::ReadAsync(System.Memory`1<System.Byte>,System.Threading.CancellationToken)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0011:
	stloc:Type(var_2_17, call:Type(object::GetType, ldloc:NetworkStream[exp:object](this)))
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

		// Token: 0x06001320 RID: 4896 RVA: 0x0003B160 File Offset: 0x00039360
		public override Task WriteAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			if (!this._cleanedUp)
			{
				if (buffer != null)
				{
					Socket streamSocket = this._streamSocket;
					ThrowHelper.ThrowArgumentOutOfRangeException();
					ValueTask valueTask;
					return valueTask.AsTask();
				}
			}
			else
			{
				Socket streamSocket;
				Type type = streamSocket.GetType();
			}
			return "offset";
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x0003B19C File Offset: 0x0003939C
		public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken)
		{
			/*
An exception occurred when decompiling this method (06001321)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.ValueTask System.Net.Sockets.NetworkStream::WriteAsync(System.ReadOnlyMemory`1<System.Byte>,System.Threading.CancellationToken)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0011:
	stloc:Type(var_2_17, call:Type(object::GetType, ldloc:NetworkStream[exp:object](this)))
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

		// Token: 0x06001322 RID: 4898 RVA: 0x0003B1C0 File Offset: 0x000393C0
		public override void Flush()
		{
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x0003B1D0 File Offset: 0x000393D0
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			/*
An exception occurred when decompiling this method (06001323)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task System.Net.Sockets.NetworkStream::FlushAsync(System.Threading.CancellationToken)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
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

		// Token: 0x06001324 RID: 4900 RVA: 0x00002050 File Offset: 0x00000250
		public override void SetLength(long value)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x0003B1E4 File Offset: 0x000393E4
		internal void SetSocketTimeoutOption(SocketShutdown mode, int timeout, bool silent)
		{
			if (!true)
			{
			}
			bool isEnabled = NetEventSource.IsEnabled;
			int currentWriteTimeout = this._currentWriteTimeout;
			Socket streamSocket = this._streamSocket;
			this._currentWriteTimeout = timeout;
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06001326 RID: 4902 RVA: 0x0003B22C File Offset: 0x0003942C
		internal Socket InternalSocket
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001326)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.Sockets.Socket System.Net.Sockets.NetworkStream::get_InternalSocket()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0016:
	stloc:Type(var_2_1C, call:Type(object::GetType, ldloc:NetworkStream[exp:object](this)))
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

		// Token: 0x04000F89 RID: 3977
		private readonly Socket _streamSocket;

		// Token: 0x04000F8A RID: 3978
		private readonly bool _ownsSocket;

		// Token: 0x04000F8B RID: 3979
		private bool _readable;

		// Token: 0x04000F8C RID: 3980
		private bool _writeable;

		// Token: 0x04000F8D RID: 3981
		private int _closeTimeout;

		// Token: 0x04000F8E RID: 3982
		private bool _cleanedUp;

		// Token: 0x04000F8F RID: 3983
		private int _currentReadTimeout;

		// Token: 0x04000F90 RID: 3984
		private int _currentWriteTimeout;
	}
}
