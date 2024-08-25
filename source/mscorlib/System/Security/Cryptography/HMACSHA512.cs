using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	// Token: 0x020002E0 RID: 736
	[ComVisible(true)]
	public class HMACSHA512 : HMAC
	{
		// Token: 0x060018B7 RID: 6327 RVA: 0x00034F94 File Offset: 0x00033194
		public HMACSHA512()
		{
			if (!true)
			{
			}
			byte[] array = Utils.GenerateRandom(128);
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x00034FB0 File Offset: 0x000331B0
		public HMACSHA512(byte[] key)
		{
			if (!true)
			{
			}
			bool flag = Utils._ProduceLegacyHmacValues();
			this.m_useLegacyBlockSize = true;
			this.blockSizeValue = 64;
			base..ctor();
			this.m_hashName = "SHA512";
			bool useLegacyBlockSize = this.m_useLegacyBlockSize;
			this.HashSizeValue = 512;
			this.blockSizeValue = 128;
			base.InitializeKey(key);
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x060018B9 RID: 6329 RVA: 0x0003500C File Offset: 0x0003320C
		private int BlockSize
		{
			get
			{
				/*
An exception occurred when decompiling this method (060018B9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Security.Cryptography.HMACSHA512::get_BlockSize()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_06, ldfld:bool(HMACSHA512::m_useLegacyBlockSize, ldloc:HMACSHA512(this)))
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

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x060018BA RID: 6330 RVA: 0x00035020 File Offset: 0x00033220
		// (set) Token: 0x060018BB RID: 6331 RVA: 0x00035034 File Offset: 0x00033234
		public bool ProduceLegacyHmacValues
		{
			get
			{
				return this.m_useLegacyBlockSize;
			}
			set
			{
				byte[] keyValue = this.KeyValue;
				this.blockSizeValue = 128;
				base.InitializeKey(keyValue);
			}
		}

		// Token: 0x04000CB9 RID: 3257
		private bool m_useLegacyBlockSize;
	}
}
