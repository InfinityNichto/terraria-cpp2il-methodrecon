using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.Win32.SafeHandles;

namespace System.IO
{
	// Token: 0x02000565 RID: 1381
	[ComVisible(true)]
	public class FileStream : Stream
	{
		// Token: 0x06002968 RID: 10600 RVA: 0x00059CF4 File Offset: 0x00057EF4
		[Obsolete("Use FileStream(SafeFileHandle handle, FileAccess access, int bufferSize) instead")]
		public FileStream(IntPtr handle, FileAccess access, bool ownsHandle, int bufferSize)
		{
		}

		// Token: 0x06002969 RID: 10601 RVA: 0x00059D08 File Offset: 0x00057F08
		internal FileStream(IntPtr handle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync, bool isConsoleWrapper)
		{
			this.name = "[Unknown]";
			if ("[Unknown]" == null)
			{
			}
			base..ctor();
			if ("[Unknown]" == null)
			{
			}
		}

		// Token: 0x0600296A RID: 10602 RVA: 0x00059D44 File Offset: 0x00057F44
		public FileStream(string path, FileMode mode)
		{
		}

		// Token: 0x0600296B RID: 10603 RVA: 0x00059D54 File Offset: 0x00057F54
		public FileStream(string path, FileMode mode, FileAccess access)
		{
		}

		// Token: 0x0600296C RID: 10604 RVA: 0x00059D64 File Offset: 0x00057F64
		public FileStream(string path, FileMode mode, FileAccess access, FileShare share)
		{
		}

		// Token: 0x0600296D RID: 10605 RVA: 0x00059D74 File Offset: 0x00057F74
		public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize)
		{
		}

		// Token: 0x0600296E RID: 10606 RVA: 0x00059D84 File Offset: 0x00057F84
		public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool useAsync)
		{
		}

		// Token: 0x0600296F RID: 10607 RVA: 0x00059D94 File Offset: 0x00057F94
		public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options)
		{
		}

		// Token: 0x06002970 RID: 10608 RVA: 0x00059DA4 File Offset: 0x00057FA4
		internal FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool isAsync, bool anonymous)
		{
		}

		// Token: 0x06002971 RID: 10609 RVA: 0x0000207A File Offset: 0x0000027A
		internal FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool anonymous, FileOptions options)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002972 RID: 10610 RVA: 0x00059DB4 File Offset: 0x00057FB4
		private void Init(SafeFileHandle safeHandle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync, bool isConsoleWrapper)
		{
			/*
An exception occurred when decompiling this method (06002972)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.IO.FileStream::Init(Microsoft.Win32.SafeHandles.SafeFileHandle,System.IO.FileAccess,System.Boolean,System.Int32,System.Boolean,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0076:
	stloc:string(var_9_80, call:string(Environment::GetResourceString, ldstr:string("Invalid handle.")))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06002973 RID: 10611 RVA: 0x00059E44 File Offset: 0x00058044
		public override bool CanRead
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002973)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.IO.FileStream::get_CanRead()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:FileAccess(var_0_06, ldfld:FileAccess(FileStream::access, ldloc:FileStream(this)))
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

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06002974 RID: 10612 RVA: 0x00059E58 File Offset: 0x00058058
		public override bool CanWrite
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002974)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.IO.FileStream::get_CanWrite()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:FileAccess(var_0_06, ldfld:FileAccess(FileStream::access, ldloc:FileStream(this)))
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

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06002975 RID: 10613 RVA: 0x00059E6C File Offset: 0x0005806C
		public override bool CanSeek
		{
			get
			{
				return this.canseek;
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06002976 RID: 10614 RVA: 0x00059E80 File Offset: 0x00058080
		public override long Length
		{
			get
			{
				bool flag;
				do
				{
					bool isClosed = this.safeHandle.IsClosed;
					flag = this.buf_dirty;
					if (flag)
					{
						this.FlushBuffer();
					}
					SafeFileHandle safeFileHandle = this.safeHandle;
					if (!flag)
					{
					}
				}
				while (flag);
				long num;
				return num;
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06002977 RID: 10615 RVA: 0x00059EB8 File Offset: 0x000580B8
		// (set) Token: 0x06002978 RID: 10616 RVA: 0x00059EF8 File Offset: 0x000580F8
		public override long Position
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002977)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int64 System.IO.FileStream::get_Position()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_002B:
	stloc:string(var_6_32, ldfld:string(Exception::_source, ldloc:Exception(var_5)))
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

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06002979 RID: 10617 RVA: 0x00059F10 File Offset: 0x00058110
		public virtual SafeFileHandle SafeFileHandle
		{
			get
			{
				if (!this.isExposed)
				{
					this.isExposed = true;
					this.FlushBuffer();
					long num = 0L;
					this.InitBuffer((int)num, true);
				}
				return this.safeHandle;
			}
		}

		// Token: 0x0600297A RID: 10618 RVA: 0x00059F44 File Offset: 0x00058144
		private void ExposeHandle()
		{
			this.isExposed = true;
			this.FlushBuffer();
			long num = 0L;
			this.InitBuffer((int)num, true);
		}

		// Token: 0x0600297B RID: 10619 RVA: 0x00059F68 File Offset: 0x00058168
		public override int ReadByte()
		{
			bool isClosed = this.safeHandle.IsClosed;
			int num3;
			if (this.buf_size != 0)
			{
				int num = this.buf_length;
				long num2 = this.buf_start;
				this.RefillBuffer();
				if (this.buf_length == 0)
				{
					return num3;
				}
				int num4 = this.buf_offset;
				byte[] array = this.buf;
			}
			SafeFileHandle safeFileHandle = this.safeHandle;
			byte[] array2 = this.buf;
			int num5 = 1;
			long num6 = 0L;
			num3 = this.ReadData(safeFileHandle, array2, (int)num6, num5);
			if (num3 != 0)
			{
				byte[] array3 = this.buf;
				return num3;
			}
			return num3;
		}

		// Token: 0x0600297C RID: 10620 RVA: 0x00059FEC File Offset: 0x000581EC
		public override void WriteByte(byte value)
		{
			bool isClosed = this.safeHandle.IsClosed;
			int num = this.buf_offset;
			int num2 = this.buf_size;
			this.FlushBuffer();
			int num3 = this.buf_size;
			byte[] array = this.buf;
			if (num3 != 0)
			{
				int num4 = this.buf_length;
				long num5 = this.buf_start;
				this.buf_length = (int)num5;
				int num6 = 1;
				this.buf_dirty = num6 != 0;
				return;
			}
			int num7 = 1;
			this.buf_dirty = num7 != 0;
			this.buf_length = num7;
			this.FlushBuffer();
		}

		// Token: 0x0600297D RID: 10621 RVA: 0x0005A06C File Offset: 0x0005826C
		public override int Read([In] [Out] byte[] array, int offset, int count)
		{
			bool isClosed = this.safeHandle.IsClosed;
			if (array != null)
			{
				if (this.async)
				{
				}
				return this.ReadInternal(array, offset, count);
			}
			return "offset";
		}

		// Token: 0x0600297E RID: 10622 RVA: 0x0005A0A8 File Offset: 0x000582A8
		private int ReadInternal(byte[] dest, int offset, int count)
		{
			int num = this.ReadSegment(dest, offset, count);
			int num2 = this.buf_size;
			this.FlushBuffer();
			SafeFileHandle safeFileHandle = this.safeHandle;
			int num3 = this.ReadData(safeFileHandle, dest, count, count);
			long num4 = this.buf_start;
			this.buf_start = num4;
			return num3;
		}

		// Token: 0x0600297F RID: 10623 RVA: 0x0005A0F4 File Offset: 0x000582F4
		public override IAsyncResult BeginRead(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject)
		{
			bool isClosed = this.safeHandle.IsClosed;
			if (array == null)
			{
				return "numBytes";
			}
			if (this.async)
			{
				IAsyncResult asyncResult;
				return asyncResult;
			}
			return base.BeginRead(array, offset, numBytes, userCallback, stateObject);
		}

		// Token: 0x06002980 RID: 10624 RVA: 0x0005A130 File Offset: 0x00058330
		public override int EndRead(IAsyncResult asyncResult)
		{
			while (asyncResult == null || (this.async && asyncResult == null))
			{
			}
			return base.EndRead(asyncResult);
		}

		// Token: 0x06002981 RID: 10625 RVA: 0x0005A154 File Offset: 0x00058354
		public override void Write(byte[] array, int offset, int count)
		{
			bool isClosed = this.safeHandle.IsClosed;
			if (array == null)
			{
				return;
			}
			if (this.async)
			{
				return;
			}
			this.WriteInternal(array, offset, count);
		}

		// Token: 0x06002982 RID: 10626 RVA: 0x0005A188 File Offset: 0x00058388
		private void WriteInternal(byte[] src, int offset, int count)
		{
			/*
An exception occurred when decompiling this method (06002982)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.IO.FileStream::WriteInternal(System.Byte[],System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_005C:
	stloc:string(var_9_62, ldfld:string(FileStream::name, ldloc:FileStream(this)))
	stloc:string(var_10_6C, call:string(FileStream::GetSecureFileName, ldloc:FileStream(this), ldloc:string(var_9_62)))
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

		// Token: 0x06002983 RID: 10627 RVA: 0x0005A204 File Offset: 0x00058404
		public override IAsyncResult BeginWrite(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject)
		{
			bool isClosed = this.safeHandle.IsClosed;
			if (array == null)
			{
				return "numBytes";
			}
			if (this.async)
			{
				IAsyncResult asyncResult;
				return asyncResult;
			}
			return base.BeginWrite(array, offset, numBytes, userCallback, stateObject);
		}

		// Token: 0x06002984 RID: 10628 RVA: 0x0005A240 File Offset: 0x00058440
		public override void EndWrite(IAsyncResult asyncResult)
		{
			while (asyncResult == null)
			{
			}
			if (!this.async)
			{
				base.EndWrite(asyncResult);
				return;
			}
			if (asyncResult != null)
			{
				return;
			}
		}

		// Token: 0x06002985 RID: 10629 RVA: 0x0005A264 File Offset: 0x00058464
		public override long Seek(long offset, SeekOrigin origin)
		{
			long num;
			long num2;
			do
			{
				bool isClosed = this.safeHandle.IsClosed;
				if (origin != SeekOrigin.Begin)
				{
				}
				num = this.append_startpos;
				this.FlushBuffer();
				SafeFileHandle safeFileHandle = this.safeHandle;
				if (num == 0L)
				{
				}
				this.buf_start = num2;
			}
			while (num != 0L);
			return num2;
		}

		// Token: 0x06002986 RID: 10630 RVA: 0x0005A2A8 File Offset: 0x000584A8
		public override void SetLength(long value)
		{
			bool isClosed = this.safeHandle.IsClosed;
			this.FlushBuffer();
			SafeFileHandle safeFileHandle = this.safeHandle;
		}

		// Token: 0x06002987 RID: 10631 RVA: 0x0005A2E4 File Offset: 0x000584E4
		public override void Flush()
		{
			bool isClosed = this.safeHandle.IsClosed;
			this.FlushBuffer();
		}

		// Token: 0x06002988 RID: 10632 RVA: 0x0005A304 File Offset: 0x00058504
		protected override void Finalize()
		{
			base.Finalize();
		}

		// Token: 0x06002989 RID: 10633 RVA: 0x0005A338 File Offset: 0x00058538
		protected override void Dispose(bool disposing)
		{
			SafeFileHandle safeFileHandle = this.safeHandle;
			long num;
			if (safeFileHandle != null)
			{
				bool isClosed = safeFileHandle.IsClosed;
				this.FlushBuffer();
				if (this.owner)
				{
					SafeFileHandle safeFileHandle2 = this.safeHandle;
					IntPtr handle = safeFileHandle2.handle;
					if (safeFileHandle2 == null)
					{
						this.safeHandle.DangerousRelease();
						return;
					}
					goto IL_007C;
				}
			}
			else
			{
				num = 0L;
			}
			if (this.buf == null)
			{
			}
			GC.SuppressFinalize(this);
			if (num == 0L)
			{
				return;
			}
			IL_007C:
			string text = this.name;
			string secureFileName = this.GetSecureFileName(text);
			throw new OutOfMemoryException();
		}

		// Token: 0x0600298A RID: 10634 RVA: 0x0005A3F8 File Offset: 0x000585F8
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			bool isClosed = this.safeHandle.IsClosed;
			return base.FlushAsync(cancellationToken);
		}

		// Token: 0x0600298B RID: 10635 RVA: 0x0005A418 File Offset: 0x00058618
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return base.ReadAsync(buffer, offset, count, cancellationToken);
		}

		// Token: 0x0600298C RID: 10636 RVA: 0x0005A430 File Offset: 0x00058630
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return base.WriteAsync(buffer, offset, count, cancellationToken);
		}

		// Token: 0x0600298D RID: 10637 RVA: 0x0005A448 File Offset: 0x00058648
		private int ReadSegment(byte[] dest, int dest_offset, int count)
		{
			int num = 1;
			int num2 = this.buf_length;
			long num3 = this.buf_start;
			if (num == 0)
			{
			}
			byte[] array = this.buf;
			int num4 = this.buf_offset;
			int num5;
			bool flag = Buffer.InternalBlockCopy(array, num4, dest, dest_offset, num5);
			int num6 = this.buf_offset;
			this.buf_offset = num6;
			return num5;
		}

		// Token: 0x0600298E RID: 10638 RVA: 0x0005A498 File Offset: 0x00058698
		private int WriteSegment(byte[] src, int src_offset, int count)
		{
			/*
An exception occurred when decompiling this method (0600298E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.IO.FileStream::WriteSegment(System.Byte[],System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(FileStream::buf_size, ldloc:FileStream(this)))
	stloc:int32(var_1_0D, ldfld:int32(FileStream::buf_offset, ldloc:FileStream(this)))
	stloc:uint8[](var_2_14, ldfld:uint8[](FileStream::buf, ldloc:FileStream(this)))
	stloc:int32(var_3_1B, ldfld:int32(FileStream::buf_length, ldloc:FileStream(this)))
	stloc:int64(var_4_22, ldfld:int64(FileStream::buf_start, ldloc:FileStream(this)))
	stfld:int32(FileStream::buf_offset, ldloc:FileStream(this), ldloc:int64[exp:int32](var_4_22))
	stfld:int32(FileStream::buf_length, ldloc:FileStream(this), ldloc:int64[exp:int32](var_4_22))
	stloc:int32(var_5_35, ldc.i4:int32(1))
	stfld:bool(FileStream::buf_dirty, ldloc:FileStream(this), ldloc:int32[exp:bool](var_5_35))
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

		// Token: 0x0600298F RID: 10639 RVA: 0x0005A4E4 File Offset: 0x000586E4
		private void FlushBuffer()
		{
			/*
An exception occurred when decompiling this method (0600298F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.IO.FileStream::FlushBuffer()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_005E:
	stloc:string(var_10_64, ldfld:string(FileStream::name, ldloc:FileStream(this)))
	stloc:string(var_11_6E, call:string(FileStream::GetSecureFileName, ldloc:FileStream(this), ldloc:string(var_10_64)))
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

		// Token: 0x06002990 RID: 10640 RVA: 0x0005A560 File Offset: 0x00058760
		private void FlushBufferIfDirty()
		{
			if (this.buf_dirty)
			{
				this.FlushBuffer();
				return;
			}
		}

		// Token: 0x06002991 RID: 10641 RVA: 0x0005A57C File Offset: 0x0005877C
		private void RefillBuffer()
		{
			this.FlushBuffer();
			SafeFileHandle safeFileHandle = this.safeHandle;
			byte[] array = this.buf;
			int num = this.buf_size;
			long num2 = 0L;
			int num3 = this.ReadData(safeFileHandle, array, (int)num2, num);
			this.buf_length = num3;
		}

		// Token: 0x06002992 RID: 10642 RVA: 0x0005A5BC File Offset: 0x000587BC
		private int ReadData(SafeHandle safeHandle, byte[] buf, int offset, int count)
		{
			/*
An exception occurred when decompiling this method (06002992)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.IO.FileStream::ReadData(System.Runtime.InteropServices.SafeHandle,System.Byte[],System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_2_08, ldfld:string(FileStream::name, ldloc:FileStream(this)))
	stloc:string(var_3_10, call:string(FileStream::GetSecureFileName, ldloc:FileStream(this), ldloc:string(var_2_08)))
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

		// Token: 0x06002993 RID: 10643 RVA: 0x0005A5DC File Offset: 0x000587DC
		private void InitBuffer(int size, bool isZeroSize)
		{
		}

		// Token: 0x06002994 RID: 10644 RVA: 0x0005A644 File Offset: 0x00058844
		private string GetSecureFileName(string filename)
		{
			bool flag = this.anonymous;
			if (!true)
			{
			}
			string fileName;
			if (flag)
			{
				fileName = Path.GetFileName(filename);
				return fileName;
			}
			return Path.GetFullPath(fileName);
		}

		// Token: 0x06002995 RID: 10645 RVA: 0x0005A670 File Offset: 0x00058870
		private string GetSecureFileName(string filename, bool full)
		{
			if (this.anonymous)
			{
				return Path.GetFileName(filename);
			}
			return Path.GetFullPath(filename);
		}

		// Token: 0x06002996 RID: 10646 RVA: 0x0005A694 File Offset: 0x00058894
		// Note: this type is marked as 'beforefieldinit'.
		static FileStream()
		{
		}

		// Token: 0x04001637 RID: 5687
		private static byte[] buf_recycle;

		// Token: 0x04001638 RID: 5688
		private static readonly object buf_recycle_lock;

		// Token: 0x04001639 RID: 5689
		private byte[] buf;

		// Token: 0x0400163A RID: 5690
		private string name;

		// Token: 0x0400163B RID: 5691
		private SafeFileHandle safeHandle;

		// Token: 0x0400163C RID: 5692
		private bool isExposed;

		// Token: 0x0400163D RID: 5693
		private long append_startpos;

		// Token: 0x0400163E RID: 5694
		private FileAccess access;

		// Token: 0x0400163F RID: 5695
		private bool owner;

		// Token: 0x04001640 RID: 5696
		private bool async;

		// Token: 0x04001641 RID: 5697
		private bool canseek;

		// Token: 0x04001642 RID: 5698
		private bool anonymous;

		// Token: 0x04001643 RID: 5699
		private bool buf_dirty;

		// Token: 0x04001644 RID: 5700
		private int buf_size;

		// Token: 0x04001645 RID: 5701
		private int buf_length;

		// Token: 0x04001646 RID: 5702
		private int buf_offset;

		// Token: 0x04001647 RID: 5703
		private long buf_start;

		// Token: 0x02000566 RID: 1382
		private sealed class ReadDelegate : MulticastDelegate
		{
			// Token: 0x06002997 RID: 10647 RVA: 0x0005A6A4 File Offset: 0x000588A4
			public ReadDelegate(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06002998 RID: 10648 RVA: 0x0005A6F8 File Offset: 0x000588F8
			public int Invoke(byte[] buffer, int offset, int count)
			{
				/*
An exception occurred when decompiling this method (06002998)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.IO.FileStream/ReadDelegate::Invoke(System.Byte[],System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(Delegate::method_code, ldloc:ReadDelegate[exp:Delegate](this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:ReadDelegate[exp:Delegate](this)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method, ldloc:ReadDelegate[exp:Delegate](this)))
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

			// Token: 0x06002999 RID: 10649 RVA: 0x0000207A File Offset: 0x0000027A
			public IAsyncResult BeginInvoke(byte[] buffer, int offset, int count, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0600299A RID: 10650 RVA: 0x0000207A File Offset: 0x0000027A
			public int EndInvoke(IAsyncResult result)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x02000567 RID: 1383
		private sealed class WriteDelegate : MulticastDelegate
		{
			// Token: 0x0600299B RID: 10651 RVA: 0x0005A71C File Offset: 0x0005891C
			public WriteDelegate(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x0600299C RID: 10652 RVA: 0x0005A770 File Offset: 0x00058970
			public void Invoke(byte[] buffer, int offset, int count)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}

			// Token: 0x0600299D RID: 10653 RVA: 0x0000207A File Offset: 0x0000027A
			public IAsyncResult BeginInvoke(byte[] buffer, int offset, int count, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0600299E RID: 10654 RVA: 0x0005A794 File Offset: 0x00058994
			public void EndInvoke(IAsyncResult result)
			{
			}
		}
	}
}
