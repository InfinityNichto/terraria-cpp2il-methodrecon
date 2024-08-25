using System;

namespace System.Collections.Generic
{
	// Token: 0x02000658 RID: 1624
	[Serializable]
	internal class ObjectEqualityComparer<T> : EqualityComparer<T>
	{
		// Token: 0x06003194 RID: 12692 RVA: 0x0006B7B4 File Offset: 0x000699B4
		public override bool Equals(T x, T y)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06003195 RID: 12693 RVA: 0x0006B7C4 File Offset: 0x000699C4
		public override int GetHashCode(T obj)
		{
			int num;
			return num;
		}

		// Token: 0x06003196 RID: 12694 RVA: 0x0006B7D4 File Offset: 0x000699D4
		internal override int IndexOf(T[] array, T value, int startIndex, int count)
		{
			return count;
		}

		// Token: 0x06003197 RID: 12695 RVA: 0x0006B7E4 File Offset: 0x000699E4
		internal override int LastIndexOf(T[] array, T value, int startIndex, int count)
		{
			return count;
		}

		// Token: 0x06003198 RID: 12696 RVA: 0x0006B7F4 File Offset: 0x000699F4
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				return;
			}
		}

		// Token: 0x06003199 RID: 12697 RVA: 0x0006B808 File Offset: 0x00069A08
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (06003199)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Collections.Generic.ObjectEqualityComparer`1::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Type(var_0_06, call:Type(object::GetType, ldloc:ObjectEqualityComparer`1[exp:object](this)))
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

		// Token: 0x0600319A RID: 12698 RVA: 0x0006B81C File Offset: 0x00069A1C
		public ObjectEqualityComparer()
		{
		}
	}
}
