using System;
using System.IO;

namespace System.Net
{
	// Token: 0x0200021C RID: 540
	internal sealed class FileWebStream : FileStream, ICloseEx
	{
		// Token: 0x06000D80 RID: 3456 RVA: 0x0002B7C8 File Offset: 0x000299C8
		public FileWebStream(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing)
		{
			if (!true)
			{
			}
			base..ctor(path, mode, access, sharing);
			this.m_request = request;
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x0002B7EC File Offset: 0x000299EC
		public FileWebStream(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing, int length, bool async)
		{
			if (!true)
			{
			}
			base..ctor(path, mode, access, sharing, length, length != 0);
			this.m_request = request;
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x0002B814 File Offset: 0x00029A14
		protected override void Dispose(bool disposing)
		{
			FileWebRequest request = this.m_request;
			if (request != null)
			{
				request.UnblockReader();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x0002B85C File Offset: 0x00029A5C
		void ICloseEx.CloseEx(CloseExState closeState)
		{
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x0002B86C File Offset: 0x00029A6C
		public override int Read(byte[] buffer, int offset, int size)
		{
			this.CheckError();
			return base.Read(buffer, offset, size);
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x0002B898 File Offset: 0x00029A98
		public override void Write(byte[] buffer, int offset, int size)
		{
			this.CheckError();
			base.Write(buffer, offset, size);
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x0002B8C4 File Offset: 0x00029AC4
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
		{
			this.CheckError();
			return base.BeginRead(buffer, offset, size, callback, state);
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x0002B8F4 File Offset: 0x00029AF4
		public override int EndRead(IAsyncResult ar)
		{
			return base.EndRead(ar);
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x0002B918 File Offset: 0x00029B18
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
		{
			this.CheckError();
			return base.BeginWrite(buffer, offset, size, callback, state);
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x0002B948 File Offset: 0x00029B48
		public override void EndWrite(IAsyncResult ar)
		{
			base.EndWrite(ar);
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x0002B96C File Offset: 0x00029B6C
		private void CheckError()
		{
			/*
An exception occurred when decompiling this method (06000D8A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Net.FileWebStream::CheckError()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000E:
	stloc:string(var_0_19, call:string(NetRes::GetWebStatusString, ldstr:string("net_requestaborted"), ldc.i4:WebExceptionStatus(6)))
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

		// Token: 0x04000B66 RID: 2918
		private FileWebRequest m_request;
	}
}
