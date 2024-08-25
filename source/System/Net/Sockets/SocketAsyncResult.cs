using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace System.Net.Sockets
{
	// Token: 0x0200030B RID: 779
	[StructLayout(0)]
	internal sealed class SocketAsyncResult : global::System.IOAsyncResult
	{
		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06001464 RID: 5220 RVA: 0x0003E24C File Offset: 0x0003C44C
		public IntPtr Handle
		{
			get
			{
				Socket socket;
				do
				{
					socket = this.socket;
				}
				while (socket == null);
				return socket.Handle;
			}
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x0003E26C File Offset: 0x0003C46C
		public SocketAsyncResult()
		{
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x0003E280 File Offset: 0x0003C480
		public void Init(Socket socket, AsyncCallback callback, object state, SocketOperation operation)
		{
			base.Init(callback, state);
			this.socket = socket;
			this.operation = operation;
			Memory memory;
			this.Buffer = memory;
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x0003E2B0 File Offset: 0x0003C4B0
		public SocketAsyncResult(Socket socket, AsyncCallback callback, object state, SocketOperation operation)
			: base(callback, state)
		{
			this.socket = socket;
			this.operation = operation;
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06001468 RID: 5224 RVA: 0x0003E2D4 File Offset: 0x0003C4D4
		public SocketError ErrorCode
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001468)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.Sockets.SocketError System.Net.Sockets.SocketAsyncResult::get_ErrorCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0008:
	stloc:int32(var_0_0E, ldfld:int32(SocketAsyncResult::error, ldloc:SocketAsyncResult(this)))
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

		// Token: 0x06001469 RID: 5225 RVA: 0x0003E2F0 File Offset: 0x0003C4F0
		public void CheckIfThrowDelayedException()
		{
			/*
An exception occurred when decompiling this method (06001469)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Net.Sockets.SocketAsyncResult::CheckIfThrowDelayedException()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0011:
	stloc:Socket(var_0_17, ldfld:Socket(SocketAsyncResult::socket, ldloc:SocketAsyncResult(this)))
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

		// Token: 0x0600146A RID: 5226 RVA: 0x0003E314 File Offset: 0x0003C514
		internal override void CompleteDisposed()
		{
			this.Complete();
		}

		// Token: 0x0600146B RID: 5227 RVA: 0x0003E328 File Offset: 0x0003C528
		public void Complete()
		{
			SocketOperation socketOperation = this.operation;
			bool cleanedUp = this.socket.CleanedUp;
			Type type = this.socket.GetType();
			int num = 1;
			base.IsCompleted = num != 0;
			Socket socket = this.socket;
			bool completed_synchronously = this.completed_synchronously;
			SocketOperation socketOperation2 = this.operation;
			if (!completed_synchronously)
			{
				AsyncCallback async_callback = this.async_callback;
				if (async_callback != null)
				{
					if (async_callback == null)
					{
					}
					if (type != null || async_callback == null)
					{
					}
				}
			}
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x0003E394 File Offset: 0x0003C594
		public void Complete(bool synch)
		{
			this.Complete();
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x0003E3A8 File Offset: 0x0003C5A8
		public void Complete(int total)
		{
			this.Total = total;
			this.Complete();
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x0003E3C4 File Offset: 0x0003C5C4
		public void Complete(Exception e, bool synch)
		{
			this.DelayedException = e;
			this.Complete();
		}

		// Token: 0x0600146F RID: 5231 RVA: 0x0003E3E0 File Offset: 0x0003C5E0
		public void Complete(Exception e)
		{
			this.DelayedException = e;
			this.Complete();
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x0003E3FC File Offset: 0x0003C5FC
		public void Complete(Socket s)
		{
			this.AcceptedSocket = s;
			this.Complete();
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x0003E418 File Offset: 0x0003C618
		public void Complete(Socket s, int total)
		{
			this.AcceptedSocket = s;
			this.Total = total;
			this.Complete();
		}

		// Token: 0x040010F7 RID: 4343
		public Socket socket;

		// Token: 0x040010F8 RID: 4344
		public SocketOperation operation;

		// Token: 0x040010F9 RID: 4345
		private Exception DelayedException;

		// Token: 0x040010FA RID: 4346
		public EndPoint EndPoint;

		// Token: 0x040010FB RID: 4347
		public Memory<byte> Buffer;

		// Token: 0x040010FC RID: 4348
		public int Offset;

		// Token: 0x040010FD RID: 4349
		public int Size;

		// Token: 0x040010FE RID: 4350
		public SocketFlags SockFlags;

		// Token: 0x040010FF RID: 4351
		public Socket AcceptSocket;

		// Token: 0x04001100 RID: 4352
		public IPAddress[] Addresses;

		// Token: 0x04001101 RID: 4353
		public int Port;

		// Token: 0x04001102 RID: 4354
		public IList<ArraySegment<byte>> Buffers;

		// Token: 0x04001103 RID: 4355
		public bool ReuseSocket;

		// Token: 0x04001104 RID: 4356
		public int CurrentAddress;

		// Token: 0x04001105 RID: 4357
		public Socket AcceptedSocket;

		// Token: 0x04001106 RID: 4358
		public int Total;

		// Token: 0x04001107 RID: 4359
		internal int error;

		// Token: 0x04001108 RID: 4360
		public int EndCalled;

		// Token: 0x0200030C RID: 780
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06001472 RID: 5234 RVA: 0x0003E43C File Offset: 0x0003C63C
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06001473 RID: 5235 RVA: 0x0003E44C File Offset: 0x0003C64C
			public <>c()
			{
			}

			// Token: 0x06001474 RID: 5236 RVA: 0x0003E460 File Offset: 0x0003C660
			internal void <Complete>b__27_0(object state)
			{
				if (state != null)
				{
				}
			}

			// Token: 0x04001109 RID: 4361
			public static readonly SocketAsyncResult.<>c <>9;

			// Token: 0x0400110A RID: 4362
			public static WaitCallback <>9__27_0;
		}
	}
}
