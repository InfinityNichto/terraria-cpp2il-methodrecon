using System;

namespace System.Security
{
	// Token: 0x02000298 RID: 664
	[MonoTODO("work in progress - encryption is missing")]
	public sealed class SecureString : IDisposable
	{
		// Token: 0x060016F7 RID: 5879 RVA: 0x00030648 File Offset: 0x0002E848
		public SecureString()
		{
			long num = 0L;
			this.Alloc(8, num != 0L);
		}

		// Token: 0x060016F8 RID: 5880 RVA: 0x00030668 File Offset: 0x0002E868
		[CLSCompliant(false)]
		public unsafe SecureString(char* value, int length)
		{
			if (value != null)
			{
				long num = 0L;
				this.length = length;
				this.Alloc(length, num != 0L);
				if (length != 0)
				{
					byte[] array = this.data;
					byte[] array2 = this.data;
				}
				return;
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x060016F9 RID: 5881 RVA: 0x000306A4 File Offset: 0x0002E8A4
		public int Length
		{
			get
			{
				while (this.disposed)
				{
				}
				return this.length;
			}
		}

		// Token: 0x060016FA RID: 5882 RVA: 0x000306C0 File Offset: 0x0002E8C0
		public SecureString Copy()
		{
			/*
An exception occurred when decompiling this method (060016FA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Security.SecureString System.Security.SecureString::Copy()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0018:
	stloc:int32(var_3_1E, ldfld:int32(SecureString::length, ldloc:SecureString(this)))
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

		// Token: 0x060016FB RID: 5883 RVA: 0x000306EC File Offset: 0x0002E8EC
		public void Dispose()
		{
			byte[] array = this.data;
			this.disposed = true;
			if (array != null)
			{
			}
		}

		// Token: 0x060016FC RID: 5884 RVA: 0x0003070C File Offset: 0x0002E90C
		private void Encrypt()
		{
		}

		// Token: 0x060016FD RID: 5885 RVA: 0x0003071C File Offset: 0x0002E91C
		private void Decrypt()
		{
		}

		// Token: 0x060016FE RID: 5886 RVA: 0x0003072C File Offset: 0x0002E92C
		private void Alloc(int length, bool realloc)
		{
			byte[] array = this.data;
			if (array != null)
			{
			}
			if (array == null)
			{
			}
			int num = Math.Min(0, length);
		}

		// Token: 0x060016FF RID: 5887 RVA: 0x00030754 File Offset: 0x0002E954
		internal byte[] GetBuffer()
		{
			int num = this.length;
			byte[] array = this.data;
			throw new OutOfMemoryException();
		}

		// Token: 0x04000B9F RID: 2975
		private int length;

		// Token: 0x04000BA0 RID: 2976
		private bool disposed;

		// Token: 0x04000BA1 RID: 2977
		private byte[] data;
	}
}
