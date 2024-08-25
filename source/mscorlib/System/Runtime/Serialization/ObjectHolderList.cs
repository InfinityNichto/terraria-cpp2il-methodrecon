using System;

namespace System.Runtime.Serialization
{
	// Token: 0x020003E1 RID: 993
	internal class ObjectHolderList
	{
		// Token: 0x06001F75 RID: 8053 RVA: 0x000451CC File Offset: 0x000433CC
		internal ObjectHolderList()
		{
		}

		// Token: 0x06001F76 RID: 8054 RVA: 0x000451DC File Offset: 0x000433DC
		internal ObjectHolderList(int startingSize)
		{
		}

		// Token: 0x06001F77 RID: 8055 RVA: 0x000451F0 File Offset: 0x000433F0
		internal virtual void Add(ObjectHolder value)
		{
			ObjectHolder[] values = this.m_values;
			int count = this.m_count;
			long id = values.m_id;
			this.EnlargeArray();
			ObjectHolder[] values2 = this.m_values;
			int count2 = this.m_count;
			this.m_count = (int)id;
			if (value == null || value != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06001F78 RID: 8056 RVA: 0x0004523C File Offset: 0x0004343C
		internal ObjectHolderListEnumerator GetFixupEnumerator()
		{
			/*
An exception occurred when decompiling this method (06001F78)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Runtime.Serialization.ObjectHolderListEnumerator System.Runtime.Serialization.ObjectHolderList::GetFixupEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(ObjectHolderList::m_count, ldloc:ObjectHolderList(this)))
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

		// Token: 0x06001F79 RID: 8057 RVA: 0x00045250 File Offset: 0x00043450
		private void EnlargeArray()
		{
			long id = this.m_values.m_id;
			ObjectHolder[] values = this.m_values;
			int count = this.m_count;
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06001F7A RID: 8058 RVA: 0x00045278 File Offset: 0x00043478
		internal int Version
		{
			get
			{
				return this.m_count;
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06001F7B RID: 8059 RVA: 0x0004528C File Offset: 0x0004348C
		internal int Count
		{
			get
			{
				return this.m_count;
			}
		}

		// Token: 0x04000FB9 RID: 4025
		internal ObjectHolder[] m_values;

		// Token: 0x04000FBA RID: 4026
		internal int m_count;
	}
}
