using System;
using System.Collections;

namespace System.ComponentModel
{
	// Token: 0x020003D4 RID: 980
	internal class ArraySubsetEnumerator : IEnumerator
	{
		// Token: 0x060019DA RID: 6618 RVA: 0x00047B98 File Offset: 0x00045D98
		public ArraySubsetEnumerator(Array array, int count)
		{
			this.array = array;
			this.total = count;
		}

		// Token: 0x060019DB RID: 6619 RVA: 0x00047BBC File Offset: 0x00045DBC
		public bool MoveNext()
		{
			/*
An exception occurred when decompiling this method (060019DB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.ComponentModel.ArraySubsetEnumerator::MoveNext()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(ArraySubsetEnumerator::total, ldloc:ArraySubsetEnumerator(this)))
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

		// Token: 0x060019DC RID: 6620 RVA: 0x00047BD4 File Offset: 0x00045DD4
		public void Reset()
		{
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x060019DD RID: 6621 RVA: 0x00047BE4 File Offset: 0x00045DE4
		public object Current
		{
			get
			{
				int num = this.current;
				return this.array.GetValue(num);
			}
		}

		// Token: 0x040012E0 RID: 4832
		private Array array;

		// Token: 0x040012E1 RID: 4833
		private int total;

		// Token: 0x040012E2 RID: 4834
		private int current;
	}
}
