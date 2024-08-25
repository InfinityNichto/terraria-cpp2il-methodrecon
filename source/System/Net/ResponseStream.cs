using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x0200026D RID: 621
	internal class ResponseStream : Stream
	{
		// Token: 0x060010B3 RID: 4275 RVA: 0x00034BA4 File Offset: 0x00032DA4
		internal ResponseStream(Stream stream, HttpListenerResponse response, bool ignore_errors)
		{
			if (!true)
			{
			}
			base..ctor();
			this.response = response;
			this.stream = stream;
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x060010B4 RID: 4276 RVA: 0x00034BC8 File Offset: 0x00032DC8
		public override bool CanRead
		{
			get
			{
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x060010B5 RID: 4277 RVA: 0x00034BD8 File Offset: 0x00032DD8
		public override bool CanSeek
		{
			get
			{
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x060010B6 RID: 4278 RVA: 0x00034BE8 File Offset: 0x00032DE8
		public override bool CanWrite
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x060010B7 RID: 4279 RVA: 0x00002050 File Offset: 0x00000250
		public override long Length
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x060010B8 RID: 4280 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060010B9 RID: 4281 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x060010BA RID: 4282 RVA: 0x00034BF8 File Offset: 0x00032DF8
		public override void Close()
		{
			if (this.disposed)
			{
				return;
			}
			int num = 1;
			int num2 = 1;
			this.disposed = num != 0;
			MemoryStream headers = this.GetHeaders(num2 != 0);
			Stream stream = this.stream;
			bool chunked = this.response.chunked;
			if (headers != null)
			{
				if (chunked)
				{
					bool flag = this.trailer_sent;
					if (!flag)
					{
						if (!flag)
						{
						}
						int num3 = 1;
						byte[] chunkSizeBytes = ResponseStream.GetChunkSizeBytes(0, num3 != 0);
					}
				}
				int num4 = 1;
				this.trailer_sent = num4 != 0;
				this.response.Close();
				return;
			}
			while (!chunked)
			{
			}
			bool flag2 = this.trailer_sent;
			while (flag2)
			{
			}
			if (!flag2)
			{
			}
			int num5 = 1;
			byte[] chunkSizeBytes2 = ResponseStream.GetChunkSizeBytes(0, num5 != 0);
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x00034CA0 File Offset: 0x00032EA0
		private MemoryStream GetHeaders(bool closing)
		{
			object headers_lock = this.response.headers_lock;
			Monitor.Enter(headers_lock, closing);
			if (this.response.HeadersSent)
			{
			}
			HttpListenerResponse httpListenerResponse = this.response;
			long num = 0L;
			Monitor.Exit(headers_lock);
			if (num == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x00034D00 File Offset: 0x00032F00
		public override void Flush()
		{
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x00034D10 File Offset: 0x00032F10
		private static byte[] GetChunkSizeBytes(int size, bool final)
		{
			/*
An exception occurred when decompiling this method (060010BD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] System.Net.ResponseStream::GetChunkSizeBytes(System.Int32,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Encoding(var_2_07, callgetter:Encoding(Encoding::get_ASCII))
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

		// Token: 0x060010BE RID: 4286 RVA: 0x00034D24 File Offset: 0x00032F24
		internal void InternalWrite(byte[] buffer, int offset, int count)
		{
			Stream stream = this.stream;
			if (this.ignore_errors)
			{
				return;
			}
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x00034D44 File Offset: 0x00032F44
		public override void Write(byte[] buffer, int offset, int count)
		{
			/*
An exception occurred when decompiling this method (060010BF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Net.ResponseStream::Write(System.Byte[],System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0060:
	stloc:Type(var_9_66, call:Type(object::GetType, ldloc:ResponseStream[exp:object](this)))
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

		// Token: 0x060010C0 RID: 4288 RVA: 0x00034DB8 File Offset: 0x00032FB8
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback cback, object state)
		{
			/*
An exception occurred when decompiling this method (060010C0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IAsyncResult System.Net.ResponseStream::BeginWrite(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0055:
	stloc:Type(var_9_5B, call:Type(object::GetType, ldloc:ResponseStream[exp:object](this)))
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

		// Token: 0x060010C1 RID: 4289 RVA: 0x00034E24 File Offset: 0x00033024
		public override void EndWrite(IAsyncResult ares)
		{
			Stream stream2;
			if (!this.disposed)
			{
				Stream stream = this.stream;
				bool chunked;
				if (this.ignore_errors)
				{
					chunked = this.response.chunked;
					if (chunked)
					{
						stream2 = this.stream;
						if (!chunked)
						{
						}
						return;
					}
				}
				else if (chunked)
				{
					if (!chunked)
					{
					}
					return;
				}
				return;
			}
			Type type = stream2.GetType();
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x00002050 File Offset: 0x00000250
		public override int Read([In] [Out] byte[] buffer, int offset, int count)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x00002050 File Offset: 0x00000250
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback cback, object state)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x00002050 File Offset: 0x00000250
		public override int EndRead(IAsyncResult ares)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060010C5 RID: 4293 RVA: 0x00002050 File Offset: 0x00000250
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x00002050 File Offset: 0x00000250
		public override void SetLength(long value)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x00034E78 File Offset: 0x00033078
		// Note: this type is marked as 'beforefieldinit'.
		static ResponseStream()
		{
		}

		// Token: 0x04000D26 RID: 3366
		private HttpListenerResponse response;

		// Token: 0x04000D27 RID: 3367
		private bool ignore_errors;

		// Token: 0x04000D28 RID: 3368
		private bool disposed;

		// Token: 0x04000D29 RID: 3369
		private bool trailer_sent;

		// Token: 0x04000D2A RID: 3370
		private Stream stream;

		// Token: 0x04000D2B RID: 3371
		private static byte[] crlf;
	}
}
