using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
	// Token: 0x02000548 RID: 1352
	public class UnmanagedMemoryStream : Stream
	{
		// Token: 0x06002815 RID: 10261 RVA: 0x00056F14 File Offset: 0x00055114
		protected UnmanagedMemoryStream()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x06002816 RID: 10262 RVA: 0x00056F2C File Offset: 0x0005512C
		[CLSCompliant(false)]
		public unsafe UnmanagedMemoryStream(byte* pointer, long length)
		{
			if (!true)
			{
			}
			base..ctor();
			this.Initialize(pointer, length, length, FileAccess.Read);
		}

		// Token: 0x06002817 RID: 10263 RVA: 0x00056F4C File Offset: 0x0005514C
		[CLSCompliant(false)]
		public unsafe UnmanagedMemoryStream(byte* pointer, long length, long capacity, FileAccess access)
		{
			if (!true)
			{
			}
			base..ctor();
			this.Initialize(pointer, length, capacity, access);
		}

		// Token: 0x06002818 RID: 10264 RVA: 0x00056F70 File Offset: 0x00055170
		[CLSCompliant(false)]
		protected unsafe void Initialize(byte* pointer, long length, long capacity, FileAccess access)
		{
			while (pointer != null)
			{
				if (!this._isOpen)
				{
					int num = 1;
					this._mem = pointer;
					this._length = length;
					this._capacity = capacity;
					this._access = access;
					this._isOpen = num != 0;
					return;
				}
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06002819 RID: 10265 RVA: 0x00056FB4 File Offset: 0x000551B4
		public override bool CanRead
		{
			get
			{
				if (this._isOpen)
				{
					FileAccess access = this._access;
					return;
				}
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x0600281A RID: 10266 RVA: 0x00056FD4 File Offset: 0x000551D4
		public override bool CanSeek
		{
			get
			{
				return this._isOpen;
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x0600281B RID: 10267 RVA: 0x00056FE8 File Offset: 0x000551E8
		public override bool CanWrite
		{
			get
			{
				if (this._isOpen)
				{
					FileAccess access = this._access;
					return;
				}
			}
		}

		// Token: 0x0600281C RID: 10268 RVA: 0x00057008 File Offset: 0x00055208
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x0600281D RID: 10269 RVA: 0x00057018 File Offset: 0x00055218
		private void EnsureNotClosed()
		{
			/*
An exception occurred when decompiling this method (0600281D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.IO.UnmanagedMemoryStream::EnsureNotClosed()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0009:
	stloc:Exception(var_0_0E, call:Exception(Error::GetStreamIsClosed))
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

		// Token: 0x0600281E RID: 10270 RVA: 0x00057034 File Offset: 0x00055234
		private void EnsureReadable()
		{
		}

		// Token: 0x0600281F RID: 10271 RVA: 0x00057048 File Offset: 0x00055248
		private void EnsureWriteable()
		{
		}

		// Token: 0x06002820 RID: 10272 RVA: 0x0005705C File Offset: 0x0005525C
		public override void Flush()
		{
			this.EnsureNotClosed();
		}

		// Token: 0x06002821 RID: 10273 RVA: 0x00057070 File Offset: 0x00055270
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			if (!true)
			{
			}
			Task task;
			return task;
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06002822 RID: 10274 RVA: 0x0005708C File Offset: 0x0005528C
		public override long Length
		{
			get
			{
				this.EnsureNotClosed();
				long num;
				return num;
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06002823 RID: 10275 RVA: 0x000570A0 File Offset: 0x000552A0
		// (set) Token: 0x06002824 RID: 10276 RVA: 0x000570B4 File Offset: 0x000552B4
		public override long Position
		{
			get
			{
				long num;
				return num;
			}
			set
			{
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06002825 RID: 10277 RVA: 0x000570C8 File Offset: 0x000552C8
		[CLSCompliant(false)]
		public unsafe byte* PositionPointer
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002825)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte* System.IO.UnmanagedMemoryStream::get_PositionPointer()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(UnmanagedMemoryStream::EnsureNotClosed, ldloc:UnmanagedMemoryStream(this))
	stloc:int64(var_1_14, ldfld:int64(UnmanagedMemoryStream::_capacity, ldloc:UnmanagedMemoryStream(this)))
	stloc:uint8*(var_2_1B, ldfld:uint8*(UnmanagedMemoryStream::_mem, ldloc:UnmanagedMemoryStream(this)))
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

		// Token: 0x06002826 RID: 10278 RVA: 0x000570F0 File Offset: 0x000552F0
		public override int Read(byte[] buffer, int offset, int count)
		{
			if (buffer != null)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
				int num;
				return num;
			}
			return "offset";
		}

		// Token: 0x06002827 RID: 10279 RVA: 0x00057114 File Offset: 0x00055314
		public override int Read(Span<byte> buffer)
		{
			Type type;
			bool flag = base.GetType() == type;
			return this.ReadCore(buffer);
		}

		// Token: 0x06002828 RID: 10280 RVA: 0x00057140 File Offset: 0x00055340
		internal unsafe int ReadCore(Span<byte> buffer)
		{
			this.EnsureNotClosed();
			this.EnsureReadable();
			long num2;
			long num = Interlocked.Read(num2);
			byte reference = MemoryMarshal.GetReference(buffer);
			SafeBuffer buffer2 = this._buffer;
			if (buffer2 != null)
			{
				RuntimeHelpers.PrepareConstrainedRegions();
				SafeBuffer buffer3 = this._buffer;
				long offset = this._offset;
				long num3 = 0L;
				int num4 = 5;
				if (buffer2 != null)
				{
					SafeBuffer buffer4 = this._buffer;
					buffer4.ReleasePointer();
				}
				if (num3 != 0L || num4 != 0)
				{
					goto IL_0070;
				}
			}
			byte* mem = this._mem;
			IL_0070:
			throw new OutOfMemoryException();
		}

		// Token: 0x06002829 RID: 10281 RVA: 0x000571E0 File Offset: 0x000553E0
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			int num = 1;
			if (buffer != null)
			{
				if (num == 0)
				{
				}
				Task task;
				return task;
			}
			return "offset";
		}

		// Token: 0x0600282A RID: 10282 RVA: 0x00057210 File Offset: 0x00055410
		public override ValueTask<int> ReadAsync(Memory<byte> buffer, [Optional] CancellationToken cancellationToken)
		{
			Task task;
			if (task == null)
			{
			}
			ReadOnlyMemory<byte> readOnlyMemory = buffer;
			Task task2;
			if (task2 == null)
			{
				return;
			}
		}

		// Token: 0x0600282B RID: 10283 RVA: 0x0005723C File Offset: 0x0005543C
		public unsafe override int ReadByte()
		{
			this.EnsureNotClosed();
			this.EnsureReadable();
			long num = 0L;
			long num3;
			long num2 = Interlocked.Exchange(Interlocked.Read(num3), num);
			SafeBuffer buffer = this._buffer;
			if (buffer != null)
			{
				RuntimeHelpers.PrepareConstrainedRegions();
				SafeBuffer buffer2 = this._buffer;
				long offset = this._offset;
				long num4 = 0L;
				int num5 = 4;
				if (buffer != null)
				{
					SafeBuffer buffer3 = this._buffer;
					buffer3.ReleasePointer();
				}
				if (num4 != 0L || num5 != 0)
				{
					goto IL_0068;
				}
			}
			byte* mem = this._mem;
			IL_0068:
			throw new OutOfMemoryException();
		}

		// Token: 0x0600282C RID: 10284 RVA: 0x000572DC File Offset: 0x000554DC
		public override long Seek(long offset, SeekOrigin loc)
		{
			do
			{
				this.EnsureNotClosed();
			}
			while (loc != SeekOrigin.Begin);
			long num = 0L;
			long num2;
			return Interlocked.Read(Interlocked.Exchange(num2, num));
		}

		// Token: 0x0600282D RID: 10285 RVA: 0x00057300 File Offset: 0x00055500
		public override void SetLength(long value)
		{
			if (this._buffer == null)
			{
				this.EnsureNotClosed();
				this.EnsureWriteable();
				long capacity = this._capacity;
				long num = 0L;
				long num3;
				long num2 = Interlocked.Read(num3);
				Buffer.ZeroMemory(this._mem, num);
				long num5;
				long num4 = Interlocked.Exchange(num5, value);
				return;
			}
		}

		// Token: 0x0600282E RID: 10286 RVA: 0x0005734C File Offset: 0x0005554C
		public override void Write(byte[] buffer, int offset, int count)
		{
			if (buffer != null)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
				ReadOnlySpan readOnlySpan;
				this.WriteCore(readOnlySpan);
				return;
			}
		}

		// Token: 0x0600282F RID: 10287 RVA: 0x00057374 File Offset: 0x00055574
		public override void Write(ReadOnlySpan<byte> buffer)
		{
			Type type;
			bool flag = base.GetType() == type;
		}

		// Token: 0x06002830 RID: 10288 RVA: 0x00057398 File Offset: 0x00055598
		internal unsafe void WriteCore(ReadOnlySpan<byte> buffer)
		{
			this.EnsureNotClosed();
			this.EnsureWriteable();
			long num = 0L;
			long num3;
			long num2 = Interlocked.Read(num3);
			long capacity = this._capacity;
			if (this._buffer == null)
			{
				byte* mem = this._mem;
				long num4 = Interlocked.Exchange(num2, num);
			}
			byte reference = MemoryMarshal.GetReference(buffer);
			if (this._buffer != null)
			{
				long capacity2 = this._capacity;
				RuntimeHelpers.PrepareConstrainedRegions();
				SafeBuffer buffer2 = this._buffer;
				long offset = this._offset;
				long num5 = 0L;
				int num6 = 14;
				if (capacity2 != 0L)
				{
					this._buffer.ReleasePointer();
				}
				if (num5 != 0L)
				{
					throw new OutOfMemoryException();
				}
				if (num6 != 0)
				{
					return;
				}
			}
			byte* mem2 = this._mem;
		}

		// Token: 0x06002831 RID: 10289 RVA: 0x0005744C File Offset: 0x0005564C
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			int num = 1;
			if (buffer != null)
			{
				if (num == 0)
				{
				}
				Task task;
				return task;
			}
			return "offset";
		}

		// Token: 0x06002832 RID: 10290 RVA: 0x00057470 File Offset: 0x00055670
		public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, [Optional] CancellationToken cancellationToken)
		{
			if (!true)
			{
			}
			Task task;
			if (task == null)
			{
				return;
			}
		}

		// Token: 0x06002833 RID: 10291 RVA: 0x00057490 File Offset: 0x00055690
		public unsafe override void WriteByte(byte value)
		{
			this.EnsureNotClosed();
			this.EnsureWriteable();
			long num = 0L;
			long num3;
			long num2 = Interlocked.Read(num3);
			long capacity = this._capacity;
			if (this._buffer == null)
			{
				byte* mem = this._mem;
				long num4 = Interlocked.Exchange(num2, num);
			}
			SafeBuffer buffer = this._buffer;
			if (buffer != null)
			{
				RuntimeHelpers.PrepareConstrainedRegions();
				SafeBuffer buffer2 = this._buffer;
				long offset = this._offset;
				long num5 = 0L;
				int num6 = 11;
				if (buffer != null)
				{
					this._buffer.ReleasePointer();
				}
				if (num5 != 0L)
				{
					throw new OutOfMemoryException();
				}
				if (num6 != 0)
				{
					return;
				}
			}
			byte* mem2 = this._mem;
			mem2->m_value = value;
		}

		// Token: 0x040015B8 RID: 5560
		private SafeBuffer _buffer;

		// Token: 0x040015B9 RID: 5561
		private unsafe byte* _mem;

		// Token: 0x040015BA RID: 5562
		private long _length;

		// Token: 0x040015BB RID: 5563
		private long _capacity;

		// Token: 0x040015BC RID: 5564
		private long _position;

		// Token: 0x040015BD RID: 5565
		private long _offset;

		// Token: 0x040015BE RID: 5566
		private FileAccess _access;

		// Token: 0x040015BF RID: 5567
		internal bool _isOpen;

		// Token: 0x040015C0 RID: 5568
		private Task<int> _lastReadTask;
	}
}
