using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace System
{
	// Token: 0x02000191 RID: 401
	internal class ByteMatcher
	{
		// Token: 0x06000FB0 RID: 4016 RVA: 0x00021828 File Offset: 0x0001FA28
		public void AddMapping(TermInfoStrings key, byte[] val)
		{
			if (true)
			{
				Hashtable hashtable = this.map;
				Hashtable hashtable2 = this.starts;
			}
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x00021848 File Offset: 0x0001FA48
		public void Sort()
		{
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x00021858 File Offset: 0x0001FA58
		public bool StartsWith(int c)
		{
			/*
An exception occurred when decompiling this method (06000FB2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.ByteMatcher::StartsWith(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Hashtable(var_0_06, ldfld:Hashtable(ByteMatcher::starts, ldloc:ByteMatcher(this)))
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

		// Token: 0x06000FB3 RID: 4019 RVA: 0x0002186C File Offset: 0x0001FA6C
		public TermInfoStrings Match(char[] buffer, int offset, int length, [Out] int used)
		{
			Hashtable hashtable = this.map;
			if (hashtable == null || hashtable == null)
			{
			}
			Hashtable hashtable2 = this.map;
			long num = 0L;
			if (hashtable != null)
			{
			}
			if (num == 0L)
			{
				throw new InvalidCastException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x000218BC File Offset: 0x0001FABC
		public ByteMatcher()
		{
		}

		// Token: 0x040006C9 RID: 1737
		private Hashtable map;

		// Token: 0x040006CA RID: 1738
		private Hashtable starts;
	}
}
