using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	// Token: 0x020002DF RID: 735
	[ComVisible(true)]
	public class HMACSHA384 : HMAC
	{
		// Token: 0x060018B2 RID: 6322 RVA: 0x00034ECC File Offset: 0x000330CC
		public HMACSHA384()
		{
			if (!true)
			{
			}
			byte[] array = Utils.GenerateRandom(128);
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x00034EE8 File Offset: 0x000330E8
		public HMACSHA384(byte[] key)
		{
			if (!true)
			{
			}
			bool flag = Utils._ProduceLegacyHmacValues();
			this.m_useLegacyBlockSize = true;
			this.blockSizeValue = 64;
			base..ctor();
			this.m_hashName = "SHA384";
			bool useLegacyBlockSize = this.m_useLegacyBlockSize;
			this.HashSizeValue = 384;
			this.blockSizeValue = 128;
			base.InitializeKey(key);
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x060018B4 RID: 6324 RVA: 0x00034F44 File Offset: 0x00033144
		private int BlockSize
		{
			get
			{
				/*
An exception occurred when decompiling this method (060018B4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Security.Cryptography.HMACSHA384::get_BlockSize()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_06, ldfld:bool(HMACSHA384::m_useLegacyBlockSize, ldloc:HMACSHA384(this)))
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

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x060018B5 RID: 6325 RVA: 0x00034F58 File Offset: 0x00033158
		// (set) Token: 0x060018B6 RID: 6326 RVA: 0x00034F6C File Offset: 0x0003316C
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

		// Token: 0x04000CB8 RID: 3256
		private bool m_useLegacyBlockSize;
	}
}
