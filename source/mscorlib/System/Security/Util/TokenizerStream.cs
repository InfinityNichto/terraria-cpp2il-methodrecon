using System;

namespace System.Security.Util
{
	// Token: 0x020002A6 RID: 678
	internal sealed class TokenizerStream
	{
		// Token: 0x06001739 RID: 5945 RVA: 0x00031A7C File Offset: 0x0002FC7C
		internal TokenizerStream()
		{
			TokenizerShortBlock headTokens = this.m_headTokens;
			this.m_currentTokens = headTokens;
		}

		// Token: 0x0600173A RID: 5946 RVA: 0x00031AA0 File Offset: 0x0002FCA0
		internal void AddToken(short token)
		{
			TokenizerShortBlock currentTokens = this.m_currentTokens;
			int indexTokens = this.m_indexTokens;
			short[] block = currentTokens.m_block;
			TokenizerShortBlock currentTokens2 = this.m_currentTokens;
			long num = 0L;
			TokenizerShortBlock next = currentTokens2.m_next;
			this.m_currentTokens = next;
			short[] block2 = next.m_block;
			int countTokens = this.m_countTokens;
			this.m_countTokens = (int)num;
		}

		// Token: 0x0600173B RID: 5947 RVA: 0x00031AF8 File Offset: 0x0002FCF8
		internal void AddString(string str)
		{
			TokenizerStringBlock currentStrings = this.m_currentStrings;
			int indexStrings = this.m_indexStrings;
			string[] block = currentStrings.m_block;
			TokenizerStringBlock next = this.m_currentStrings.m_next;
			this.m_currentStrings = next;
			string[] block2 = next.m_block;
			this.m_indexStrings = next;
			if (str == null || str != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600173C RID: 5948 RVA: 0x00031B50 File Offset: 0x0002FD50
		internal void Reset()
		{
			TokenizerShortBlock headTokens = this.m_headTokens;
			TokenizerStringBlock headStrings = this.m_headStrings;
			this.m_currentTokens = headTokens;
			this.m_currentStrings = headStrings;
		}

		// Token: 0x0600173D RID: 5949 RVA: 0x00031B7C File Offset: 0x0002FD7C
		internal short GetNextFullToken()
		{
			/*
An exception occurred when decompiling this method (0600173D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int16 System.Security.Util.TokenizerStream::GetNextFullToken()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:TokenizerShortBlock(var_0_06, ldfld:TokenizerShortBlock(TokenizerStream::m_currentTokens, ldloc:TokenizerStream(this)))
	stloc:int32(var_1_0D, ldfld:int32(TokenizerStream::m_indexTokens, ldloc:TokenizerStream(this)))
	stloc:int16[](var_2_14, ldfld:int16[](TokenizerShortBlock::m_block, ldloc:TokenizerShortBlock(var_0_06)))
	stfld:TokenizerShortBlock(TokenizerStream::m_lastTokens, ldloc:TokenizerStream(this), ldloc:TokenizerShortBlock(var_0_06))
	stloc:TokenizerShortBlock(var_3_22, ldfld:TokenizerShortBlock(TokenizerShortBlock::m_next, ldloc:TokenizerShortBlock(var_0_06)))
	stfld:TokenizerShortBlock(TokenizerStream::m_currentTokens, ldloc:TokenizerStream(this), ldloc:TokenizerShortBlock(var_3_22))
	stloc:int16[](var_4_30, ldfld:int16[](TokenizerShortBlock::m_block, ldloc:TokenizerShortBlock(var_3_22)))
	stfld:int32(TokenizerStream::m_indexTokens, ldloc:TokenizerStream(this), ldloc:TokenizerShortBlock[exp:int32](var_0_06))
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

		// Token: 0x0600173E RID: 5950 RVA: 0x00031BC4 File Offset: 0x0002FDC4
		internal short GetNextToken()
		{
			/*
An exception occurred when decompiling this method (0600173E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int16 System.Security.Util.TokenizerStream::GetNextToken()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:TokenizerShortBlock(var_0_06, ldfld:TokenizerShortBlock(TokenizerStream::m_currentTokens, ldloc:TokenizerStream(this)))
	stloc:int32(var_1_0D, ldfld:int32(TokenizerStream::m_indexTokens, ldloc:TokenizerStream(this)))
	stloc:int16[](var_2_14, ldfld:int16[](TokenizerShortBlock::m_block, ldloc:TokenizerShortBlock(var_0_06)))
	stfld:TokenizerShortBlock(TokenizerStream::m_lastTokens, ldloc:TokenizerStream(this), ldloc:TokenizerShortBlock(var_0_06))
	stloc:TokenizerShortBlock(var_3_22, ldfld:TokenizerShortBlock(TokenizerShortBlock::m_next, ldloc:TokenizerShortBlock(var_0_06)))
	stfld:TokenizerShortBlock(TokenizerStream::m_currentTokens, ldloc:TokenizerStream(this), ldloc:TokenizerShortBlock(var_3_22))
	stloc:int16[](var_4_30, ldfld:int16[](TokenizerShortBlock::m_block, ldloc:TokenizerShortBlock(var_3_22)))
	stfld:int32(TokenizerStream::m_indexTokens, ldloc:TokenizerStream(this), ldloc:TokenizerShortBlock[exp:int32](var_0_06))
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

		// Token: 0x0600173F RID: 5951 RVA: 0x00031C0C File Offset: 0x0002FE0C
		internal string GetNextString()
		{
			/*
An exception occurred when decompiling this method (0600173F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Security.Util.TokenizerStream::GetNextString()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:TokenizerStringBlock(var_0_06, ldfld:TokenizerStringBlock(TokenizerStream::m_currentStrings, ldloc:TokenizerStream(this)))
	stloc:int32(var_1_0D, ldfld:int32(TokenizerStream::m_indexStrings, ldloc:TokenizerStream(this)))
	stloc:string[](var_2_14, ldfld:string[](TokenizerStringBlock::m_block, ldloc:TokenizerStringBlock(var_0_06)))
	stloc:TokenizerStringBlock(var_3_1B, ldfld:TokenizerStringBlock(TokenizerStringBlock::m_next, ldloc:TokenizerStringBlock(var_0_06)))
	stfld:TokenizerStringBlock(TokenizerStream::m_currentStrings, ldloc:TokenizerStream(this), ldloc:TokenizerStringBlock(var_3_1B))
	stloc:string[](var_4_29, ldfld:string[](TokenizerStringBlock::m_block, ldloc:TokenizerStringBlock(var_3_1B)))
	stfld:int32(TokenizerStream::m_indexStrings, ldloc:TokenizerStream(this), ldloc:TokenizerStringBlock[exp:int32](var_0_06))
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

		// Token: 0x06001740 RID: 5952 RVA: 0x00031C4C File Offset: 0x0002FE4C
		internal void ThrowAwayNextString()
		{
			TokenizerStringBlock currentStrings = this.m_currentStrings;
			int indexStrings = this.m_indexStrings;
			string[] block = currentStrings.m_block;
			TokenizerStringBlock next = currentStrings.m_next;
			long num = 0L;
			this.m_currentStrings = next;
			this.m_indexStrings = (int)num;
		}

		// Token: 0x06001741 RID: 5953 RVA: 0x00031C88 File Offset: 0x0002FE88
		internal void TagLastToken(short tag)
		{
			short[] block;
			if (this.m_indexTokens != 0)
			{
				block = this.m_currentTokens.m_block;
				return;
			}
			this.m_lastTokens.m_block.m_value = block;
		}

		// Token: 0x06001742 RID: 5954 RVA: 0x00031CBC File Offset: 0x0002FEBC
		internal int GetTokenCount()
		{
			return this.m_countTokens;
		}

		// Token: 0x06001743 RID: 5955 RVA: 0x00031CD0 File Offset: 0x0002FED0
		internal void GoToPosition(int position)
		{
			TokenizerShortBlock headTokens = this.m_headTokens;
			TokenizerStringBlock headStrings = this.m_headStrings;
			this.m_currentTokens = headTokens;
			this.m_currentStrings = headStrings;
			short[] block = headTokens.m_block;
			this.m_lastTokens = headTokens;
			TokenizerShortBlock next = headTokens.m_next;
			long num = 0L;
			this.m_currentTokens = next;
			short[] block2 = next.m_block;
			string[] block3 = headStrings.m_block;
			TokenizerStringBlock next2 = headStrings.m_next;
			long num2 = 0L;
			this.m_currentStrings = next2;
			this.m_indexStrings = (int)num2;
			this.m_indexTokens = (int)num;
		}

		// Token: 0x04000BD8 RID: 3032
		private int m_countTokens;

		// Token: 0x04000BD9 RID: 3033
		private TokenizerShortBlock m_headTokens;

		// Token: 0x04000BDA RID: 3034
		private TokenizerShortBlock m_lastTokens;

		// Token: 0x04000BDB RID: 3035
		private TokenizerShortBlock m_currentTokens;

		// Token: 0x04000BDC RID: 3036
		private int m_indexTokens;

		// Token: 0x04000BDD RID: 3037
		private TokenizerStringBlock m_headStrings;

		// Token: 0x04000BDE RID: 3038
		private TokenizerStringBlock m_currentStrings;

		// Token: 0x04000BDF RID: 3039
		private int m_indexStrings;
	}
}
