using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Net.Sockets
{
	// Token: 0x0200030A RID: 778
	public class SocketAsyncEventArgs : EventArgs, IDisposable
	{
		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06001446 RID: 5190 RVA: 0x0003DF68 File Offset: 0x0003C168
		// (set) Token: 0x06001447 RID: 5191 RVA: 0x0003DF7C File Offset: 0x0003C17C
		public Socket AcceptSocket
		{
			[CompilerGenerated]
			get
			{
				return this.<AcceptSocket>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<AcceptSocket>k__BackingField = value;
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06001448 RID: 5192 RVA: 0x0003DF90 File Offset: 0x0003C190
		// (set) Token: 0x06001449 RID: 5193 RVA: 0x0003DFA4 File Offset: 0x0003C1A4
		public int BytesTransferred
		{
			[CompilerGenerated]
			get
			{
				return this.<BytesTransferred>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<BytesTransferred>k__BackingField = value;
			}
		}

		// Token: 0x17000496 RID: 1174
		// (set) Token: 0x0600144A RID: 5194 RVA: 0x0003DFB8 File Offset: 0x0003C1B8
		private SocketAsyncOperation LastOperation
		{
			[CompilerGenerated]
			set
			{
				this.<LastOperation>k__BackingField = value;
			}
		}

		// Token: 0x17000497 RID: 1175
		// (set) Token: 0x0600144B RID: 5195 RVA: 0x0003DFCC File Offset: 0x0003C1CC
		public EndPoint RemoteEndPoint
		{
			set
			{
				this.remote_ep = value;
			}
		}

		// Token: 0x17000498 RID: 1176
		// (set) Token: 0x0600144C RID: 5196 RVA: 0x0003DFE0 File Offset: 0x0003C1E0
		[MonoTODO("unused property")]
		public int SendPacketsSendSize
		{
			[CompilerGenerated]
			set
			{
				this.<SendPacketsSendSize>k__BackingField = value;
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x0600144D RID: 5197 RVA: 0x0003DFF4 File Offset: 0x0003C1F4
		// (set) Token: 0x0600144E RID: 5198 RVA: 0x0003E008 File Offset: 0x0003C208
		public SocketError SocketError
		{
			[CompilerGenerated]
			get
			{
				return this.<SocketError>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<SocketError>k__BackingField = value;
			}
		}

		// Token: 0x1700049A RID: 1178
		// (set) Token: 0x0600144F RID: 5199 RVA: 0x0003E01C File Offset: 0x0003C21C
		public SocketFlags SocketFlags
		{
			[CompilerGenerated]
			set
			{
				this.<SocketFlags>k__BackingField = value;
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06001450 RID: 5200 RVA: 0x0003E030 File Offset: 0x0003C230
		// (set) Token: 0x06001451 RID: 5201 RVA: 0x0003E044 File Offset: 0x0003C244
		public object UserToken
		{
			[CompilerGenerated]
			get
			{
				return this.<UserToken>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<UserToken>k__BackingField = value;
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06001452 RID: 5202 RVA: 0x0003E058 File Offset: 0x0003C258
		// (remove) Token: 0x06001453 RID: 5203 RVA: 0x0003E080 File Offset: 0x0003C280
		public event EventHandler<SocketAsyncEventArgs> Completed
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate = Delegate.Combine(this.Completed, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = Delegate.Remove(this.Completed, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x0003E0A8 File Offset: 0x0003C2A8
		public SocketAsyncEventArgs()
		{
			if (!true)
			{
			}
			base..ctor();
			this.SendPacketsSendSize = 1;
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x0003E0C8 File Offset: 0x0003C2C8
		internal SocketAsyncEventArgs(bool flowExecutionContext)
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x0003E0E0 File Offset: 0x0003C2E0
		protected override void Finalize()
		{
			this.disposed = true;
			base.Finalize();
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x0003E0FC File Offset: 0x0003C2FC
		private void Dispose(bool disposing)
		{
			this.disposed = true;
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x0003E114 File Offset: 0x0003C314
		public void Dispose()
		{
			this.disposed = true;
			if (!true)
			{
			}
			GC.SuppressFinalize(this);
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x0003E134 File Offset: 0x0003C334
		internal void SetBytesTransferred(int value)
		{
			this.<BytesTransferred>k__BackingField = value;
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x0600145A RID: 5210 RVA: 0x0003E148 File Offset: 0x0003C348
		internal Socket CurrentSocket
		{
			get
			{
				return this.current_socket;
			}
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x0003E15C File Offset: 0x0003C35C
		internal void SetCurrentSocket(Socket socket)
		{
			this.current_socket = socket;
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x0003E170 File Offset: 0x0003C370
		internal void SetLastOperation(SocketAsyncOperation op)
		{
			while (!this.disposed)
			{
				int num;
				if (num == 0)
				{
					return;
				}
			}
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x0003E18C File Offset: 0x0003C38C
		internal void Complete_internal()
		{
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x0003E19C File Offset: 0x0003C39C
		protected virtual void OnCompleted(SocketAsyncEventArgs e)
		{
			if (e != null && e.Completed != null)
			{
				Socket socket = e.current_socket;
				return;
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x0600145F RID: 5215 RVA: 0x0003E1BC File Offset: 0x0003C3BC
		public Memory<byte> MemoryBuffer
		{
			get
			{
				Memory<byte> buffer = this._buffer;
				int index = this._buffer._index;
				return buffer;
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06001460 RID: 5216 RVA: 0x0003E1E0 File Offset: 0x0003C3E0
		public int Offset
		{
			get
			{
				return this._offset;
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06001461 RID: 5217 RVA: 0x0003E1F4 File Offset: 0x0003C3F4
		public int Count
		{
			get
			{
				return this._count;
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06001462 RID: 5218 RVA: 0x0003E208 File Offset: 0x0003C408
		public IList<ArraySegment<byte>> BufferList
		{
			get
			{
				return this._bufferList;
			}
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x0003E21C File Offset: 0x0003C41C
		public void SetBuffer(Memory<byte> buffer)
		{
			/*
An exception occurred when decompiling this method (06001463)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Net.Sockets.SocketAsyncEventArgs::SetBuffer(System.Memory`1<System.Byte>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0013:
	stloc:string(var_2_22, call:string(SR::Format, ldstr:string("Buffer and BufferList properties cannot both be non-null."), ldstr:string[exp:object]("BufferList")))
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

		// Token: 0x040010E5 RID: 4325
		private bool disposed;

		// Token: 0x040010E6 RID: 4326
		internal int in_progress;

		// Token: 0x040010E7 RID: 4327
		private EndPoint remote_ep;

		// Token: 0x040010E8 RID: 4328
		private Socket current_socket;

		// Token: 0x040010E9 RID: 4329
		internal SocketAsyncResult socket_async_result;

		// Token: 0x040010EA RID: 4330
		[CompilerGenerated]
		private Socket <AcceptSocket>k__BackingField;

		// Token: 0x040010EB RID: 4331
		[CompilerGenerated]
		private int <BytesTransferred>k__BackingField;

		// Token: 0x040010EC RID: 4332
		[CompilerGenerated]
		private SocketAsyncOperation <LastOperation>k__BackingField;

		// Token: 0x040010ED RID: 4333
		[CompilerGenerated]
		private int <SendPacketsSendSize>k__BackingField;

		// Token: 0x040010EE RID: 4334
		[CompilerGenerated]
		private SocketError <SocketError>k__BackingField;

		// Token: 0x040010EF RID: 4335
		[CompilerGenerated]
		private SocketFlags <SocketFlags>k__BackingField;

		// Token: 0x040010F0 RID: 4336
		[CompilerGenerated]
		private object <UserToken>k__BackingField;

		// Token: 0x040010F1 RID: 4337
		[CompilerGenerated]
		private EventHandler<SocketAsyncEventArgs> Completed;

		// Token: 0x040010F2 RID: 4338
		private Memory<byte> _buffer;

		// Token: 0x040010F3 RID: 4339
		private int _offset;

		// Token: 0x040010F4 RID: 4340
		private int _count;

		// Token: 0x040010F5 RID: 4341
		private bool _bufferIsExplicitArray;

		// Token: 0x040010F6 RID: 4342
		private IList<ArraySegment<byte>> _bufferList;
	}
}
