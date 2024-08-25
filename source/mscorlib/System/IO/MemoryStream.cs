using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
	// Token: 0x02000539 RID: 1337
	[Serializable]
	public class MemoryStream : Stream
	{
		// Token: 0x0600274E RID: 10062 RVA: 0x00055178 File Offset: 0x00053378
		public MemoryStream()
		{
		}

		// Token: 0x0600274F RID: 10063 RVA: 0x00055188 File Offset: 0x00053388
		public MemoryStream(int capacity)
		{
			if (!true)
			{
			}
			base..ctor();
			if (capacity != 0)
			{
				return;
			}
			this._capacity = capacity;
		}

		// Token: 0x06002750 RID: 10064 RVA: 0x000551B0 File Offset: 0x000533B0
		public MemoryStream(byte[] buffer)
		{
		}

		// Token: 0x06002751 RID: 10065 RVA: 0x000551C0 File Offset: 0x000533C0
		public MemoryStream(byte[] buffer, bool writable)
		{
			do
			{
				if (!true)
				{
				}
				base..ctor();
			}
			while (buffer == null);
			this._buffer = buffer;
			this._writable = true;
			this._exposable = 256 != 0;
		}

		// Token: 0x06002752 RID: 10066 RVA: 0x000551F4 File Offset: 0x000533F4
		public MemoryStream(byte[] buffer, int index, int count)
		{
		}

		// Token: 0x06002753 RID: 10067 RVA: 0x00055204 File Offset: 0x00053404
		public MemoryStream(byte[] buffer, int index, int count, bool writable)
		{
		}

		// Token: 0x06002754 RID: 10068 RVA: 0x00055214 File Offset: 0x00053414
		public MemoryStream(byte[] buffer, int index, int count, bool writable, bool publiclyVisible)
		{
			int num = 1;
			if (num == 0)
			{
			}
			base..ctor();
			if (buffer != null)
			{
				int num2 = 1;
				this._buffer = buffer;
				this._origin = index;
				this._length = index;
				this._writable = num != 0;
				this._isOpen = num2 != 0;
				return;
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06002755 RID: 10069 RVA: 0x00055258 File Offset: 0x00053458
		public override bool CanRead
		{
			get
			{
				return this._isOpen;
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06002756 RID: 10070 RVA: 0x0005526C File Offset: 0x0005346C
		public override bool CanSeek
		{
			get
			{
				return this._isOpen;
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06002757 RID: 10071 RVA: 0x00055280 File Offset: 0x00053480
		public override bool CanWrite
		{
			get
			{
				return this._writable;
			}
		}

		// Token: 0x06002758 RID: 10072 RVA: 0x00055294 File Offset: 0x00053494
		private void EnsureNotClosed()
		{
			/*
An exception occurred when decompiling this method (06002758)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.IO.MemoryStream::EnsureNotClosed()

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

		// Token: 0x06002759 RID: 10073 RVA: 0x000552B0 File Offset: 0x000534B0
		private void EnsureWriteable()
		{
		}

		// Token: 0x0600275A RID: 10074 RVA: 0x000552C4 File Offset: 0x000534C4
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x0600275B RID: 10075 RVA: 0x000552D4 File Offset: 0x000534D4
		private bool EnsureCapacity(int value)
		{
			int capacity = this._capacity;
			return true;
		}

		// Token: 0x0600275C RID: 10076 RVA: 0x000552EC File Offset: 0x000534EC
		public override void Flush()
		{
		}

		// Token: 0x0600275D RID: 10077 RVA: 0x000552FC File Offset: 0x000534FC
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			if (!true)
			{
			}
			Task task;
			return task;
		}

		// Token: 0x0600275E RID: 10078 RVA: 0x00055318 File Offset: 0x00053518
		public virtual byte[] GetBuffer()
		{
			while (!this._exposable)
			{
			}
			return this._buffer;
		}

		// Token: 0x0600275F RID: 10079 RVA: 0x00055334 File Offset: 0x00053534
		internal byte[] InternalGetBuffer()
		{
			return this._buffer;
		}

		// Token: 0x06002760 RID: 10080 RVA: 0x00055348 File Offset: 0x00053548
		internal int InternalGetPosition()
		{
			return this._position;
		}

		// Token: 0x06002761 RID: 10081 RVA: 0x0005535C File Offset: 0x0005355C
		internal int InternalReadInt32()
		{
			/*
An exception occurred when decompiling this method (06002761)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.IO.MemoryStream::InternalReadInt32()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(MemoryStream::EnsureNotClosed, ldloc:MemoryStream(this))
	stloc:int32(var_0_0C, ldfld:int32(MemoryStream::_position, ldloc:MemoryStream(this)))
	stloc:int32(var_1_13, ldfld:int32(MemoryStream::_capacity, ldloc:MemoryStream(this)))
	stloc:uint8[](var_2_1A, ldfld:uint8[](MemoryStream::_buffer, ldloc:MemoryStream(this)))
	stfld:int32(MemoryStream::_position, ldloc:MemoryStream(this), ldloc:uint8[][exp:int32](var_2_1A))
	stloc:Exception(var_3_27, call:Exception(Error::GetEndOfFile))
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

		// Token: 0x06002762 RID: 10082 RVA: 0x00055390 File Offset: 0x00053590
		internal int InternalEmulateRead(int count)
		{
			/*
An exception occurred when decompiling this method (06002762)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.IO.MemoryStream::InternalEmulateRead(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(MemoryStream::EnsureNotClosed, ldloc:MemoryStream(this))
	stloc:int32(var_0_0C, ldfld:int32(MemoryStream::_position, ldloc:MemoryStream(this)))
	stloc:int32(var_1_13, ldfld:int32(MemoryStream::_capacity, ldloc:MemoryStream(this)))
	stfld:int32(MemoryStream::_position, ldloc:MemoryStream(this), ldloc:int32(var_0_0C))
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

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06002763 RID: 10083 RVA: 0x000553B8 File Offset: 0x000535B8
		// (set) Token: 0x06002764 RID: 10084 RVA: 0x000553D8 File Offset: 0x000535D8
		public virtual int Capacity
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002763)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.IO.MemoryStream::get_Capacity()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(MemoryStream::EnsureNotClosed, ldloc:MemoryStream(this))
	stloc:int32(var_0_0C, ldfld:int32(MemoryStream::_capacity, ldloc:MemoryStream(this)))
	stloc:int32(var_1_13, ldfld:int32(MemoryStream::_origin, ldloc:MemoryStream(this)))
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
				this.EnsureNotClosed();
				if (this._expandable || this._expandable)
				{
					int capacity = this._capacity;
					int length = this._length;
					byte[] buffer = this._buffer;
					return;
				}
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06002765 RID: 10085 RVA: 0x0005541C File Offset: 0x0005361C
		public override long Length
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002765)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int64 System.IO.MemoryStream::get_Length()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(MemoryStream::EnsureNotClosed, ldloc:MemoryStream(this))
	stloc:int32(var_0_0C, ldfld:int32(MemoryStream::_length, ldloc:MemoryStream(this)))
	stloc:int32(var_1_13, ldfld:int32(MemoryStream::_origin, ldloc:MemoryStream(this)))
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

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06002766 RID: 10086 RVA: 0x0005543C File Offset: 0x0005363C
		// (set) Token: 0x06002767 RID: 10087 RVA: 0x0005545C File Offset: 0x0005365C
		public override long Position
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002766)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int64 System.IO.MemoryStream::get_Position()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(MemoryStream::EnsureNotClosed, ldloc:MemoryStream(this))
	stloc:int32(var_0_0C, ldfld:int32(MemoryStream::_origin, ldloc:MemoryStream(this)))
	stloc:int32(var_1_13, ldfld:int32(MemoryStream::_length, ldloc:MemoryStream(this)))
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
				this.EnsureNotClosed();
				int origin = this._origin;
				this._position = origin;
			}
		}

		// Token: 0x06002768 RID: 10088 RVA: 0x00055484 File Offset: 0x00053684
		public override int Read(byte[] buffer, int offset, int count)
		{
			if (buffer != null)
			{
				this.EnsureNotClosed();
				int position = this._position;
				int capacity = this._capacity;
				Buffer.BlockCopy(this._buffer, position, buffer, offset, count);
				byte[] buffer2 = this._buffer;
				int position2 = this._position;
				byte[] buffer3 = this._buffer;
				int position3 = this._position;
				this._position = position3;
			}
			return "offset";
		}

		// Token: 0x06002769 RID: 10089 RVA: 0x000554E8 File Offset: 0x000536E8
		public override int Read(Span<byte> buffer)
		{
			Type type;
			bool flag = base.GetType() != type;
			return base.Read(buffer);
		}

		// Token: 0x0600276A RID: 10090 RVA: 0x00055554 File Offset: 0x00053754
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

		// Token: 0x0600276B RID: 10091 RVA: 0x00055588 File Offset: 0x00053788
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

		// Token: 0x0600276C RID: 10092 RVA: 0x000555B4 File Offset: 0x000537B4
		public override int ReadByte()
		{
			/*
An exception occurred when decompiling this method (0600276C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.IO.MemoryStream::ReadByte()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(MemoryStream::EnsureNotClosed, ldloc:MemoryStream(this))
	stloc:int32(var_0_0C, ldfld:int32(MemoryStream::_position, ldloc:MemoryStream(this)))
	stloc:int32(var_1_13, ldfld:int32(MemoryStream::_capacity, ldloc:MemoryStream(this)))
	stloc:uint8[](var_2_1A, ldfld:uint8[](MemoryStream::_buffer, ldloc:MemoryStream(this)))
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

		// Token: 0x0600276D RID: 10093 RVA: 0x000555DC File Offset: 0x000537DC
		public override void CopyTo(Stream destination, int bufferSize)
		{
			StreamHelpers.ValidateCopyToArgs(this, destination, bufferSize);
			Type type;
			bool flag = base.GetType() != type;
			base.CopyTo(destination, bufferSize);
		}

		// Token: 0x0600276E RID: 10094 RVA: 0x0005563C File Offset: 0x0005383C
		public override long Seek(long offset, SeekOrigin loc)
		{
			/*
An exception occurred when decompiling this method (0600276E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int64 System.IO.MemoryStream::Seek(System.Int64,System.IO.SeekOrigin)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_1_15, ldfld:int32(MemoryStream::_origin, ldloc:MemoryStream(this)))
	stfld:int32(MemoryStream::_position, ldloc:MemoryStream(this), ldloc:int32(var_0_0B))
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

		// Token: 0x0600276F RID: 10095 RVA: 0x00055668 File Offset: 0x00053868
		public override void SetLength(long value)
		{
			this.EnsureWriteable();
			int origin = this._origin;
			bool flag = this.EnsureCapacity((int)value);
			int length = this._length;
			byte[] buffer = this._buffer;
			int position = this._position;
			this._length = (int)value;
			this._position = (int)value;
		}

		// Token: 0x06002770 RID: 10096 RVA: 0x000556B0 File Offset: 0x000538B0
		public virtual byte[] ToArray()
		{
			int length = this._length;
			int origin = this._origin;
			byte[] buffer = this._buffer;
			int origin2 = this._origin;
			return buffer;
		}

		// Token: 0x06002771 RID: 10097 RVA: 0x000556DC File Offset: 0x000538DC
		public override void Write(byte[] buffer, int offset, int count)
		{
			if (buffer != null)
			{
				this.EnsureNotClosed();
				this.EnsureWriteable();
				int position = this._position;
				int length = this._length;
				int capacity = this._capacity;
				int length2 = this._length;
				return;
			}
		}

		// Token: 0x06002772 RID: 10098 RVA: 0x00055768 File Offset: 0x00053968
		public override void Write(ReadOnlySpan<byte> buffer)
		{
			Type type = base.GetType();
			Type type2;
			bool flag = type != type2;
			base.Write(buffer);
		}

		// Token: 0x06002773 RID: 10099 RVA: 0x00055804 File Offset: 0x00053A04
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

		// Token: 0x06002774 RID: 10100 RVA: 0x00055828 File Offset: 0x00053A28
		public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, [Optional] CancellationToken cancellationToken)
		{
			Task task;
			if (task == null)
			{
				return;
			}
		}

		// Token: 0x06002775 RID: 10101 RVA: 0x00055844 File Offset: 0x00053A44
		public override void WriteByte(byte value)
		{
			this.EnsureNotClosed();
			this.EnsureWriteable();
			int position = this._position;
			int capacity = this._capacity;
			int capacity2 = this._capacity;
		}

		// Token: 0x04001583 RID: 5507
		private byte[] _buffer;

		// Token: 0x04001584 RID: 5508
		private int _origin;

		// Token: 0x04001585 RID: 5509
		private int _position;

		// Token: 0x04001586 RID: 5510
		private int _length;

		// Token: 0x04001587 RID: 5511
		private int _capacity;

		// Token: 0x04001588 RID: 5512
		private bool _expandable;

		// Token: 0x04001589 RID: 5513
		private bool _writable;

		// Token: 0x0400158A RID: 5514
		private bool _exposable;

		// Token: 0x0400158B RID: 5515
		private bool _isOpen;

		// Token: 0x0400158C RID: 5516
		[NonSerialized]
		private Task<int> _lastReadTask;
	}
}
