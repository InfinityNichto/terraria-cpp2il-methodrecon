using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	// Token: 0x020002CE RID: 718
	[ComVisible(true)]
	public sealed class KeySizes
	{
		// Token: 0x17000291 RID: 657
		// (get) Token: 0x0600183F RID: 6207 RVA: 0x00033D84 File Offset: 0x00031F84
		public int MinSize
		{
			get
			{
				return this.m_minSize;
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06001840 RID: 6208 RVA: 0x00033D98 File Offset: 0x00031F98
		public int MaxSize
		{
			get
			{
				return this.m_maxSize;
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06001841 RID: 6209 RVA: 0x00033DAC File Offset: 0x00031FAC
		public int SkipSize
		{
			get
			{
				return this.m_skipSize;
			}
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x00033DC0 File Offset: 0x00031FC0
		public KeySizes(int minSize, int maxSize, int skipSize)
		{
			this.m_minSize = minSize;
			this.m_skipSize = maxSize;
			this.m_skipSize = skipSize;
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x00033DE8 File Offset: 0x00031FE8
		internal bool IsLegal(int keySize)
		{
			/*
An exception occurred when decompiling this method (06001843)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Security.Cryptography.KeySizes::IsLegal(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(KeySizes::m_minSize, ldloc:KeySizes(this)))
	stloc:int32(var_1_0D, ldfld:int32(KeySizes::m_maxSize, ldloc:KeySizes(this)))
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

		// Token: 0x06001844 RID: 6212 RVA: 0x00033E04 File Offset: 0x00032004
		internal static bool IsLegalKeySize(KeySizes[] legalKeys, int size)
		{
		}

		// Token: 0x04000C8B RID: 3211
		private int m_minSize;

		// Token: 0x04000C8C RID: 3212
		private int m_maxSize;

		// Token: 0x04000C8D RID: 3213
		private int m_skipSize;
	}
}
