using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Serialization
{
	// Token: 0x020003EE RID: 1006
	[ComVisible(true)]
	[Serializable]
	public readonly struct StreamingContext
	{
		// Token: 0x06001FC7 RID: 8135 RVA: 0x00045BF4 File Offset: 0x00043DF4
		public StreamingContext(StreamingContextStates state)
		{
			this.m_state = state;
		}

		// Token: 0x06001FC8 RID: 8136 RVA: 0x00045C08 File Offset: 0x00043E08
		public StreamingContext(StreamingContextStates state, object additional)
		{
			this.m_state = state;
			this.m_additionalContext = additional;
		}

		// Token: 0x06001FC9 RID: 8137 RVA: 0x00045C24 File Offset: 0x00043E24
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				StreamingContextStates state = this.m_state;
				return true;
			}
			throw new InvalidCastException();
		}

		// Token: 0x06001FCA RID: 8138 RVA: 0x00045C44 File Offset: 0x00043E44
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (06001FCA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Runtime.Serialization.StreamingContext::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:StreamingContextStates(var_0_06, ldfld:StreamingContextStates(StreamingContext::m_state, ldloc:valuetype System.Runtime.Serialization.StreamingContext&(this)))
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

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06001FCB RID: 8139 RVA: 0x00045C58 File Offset: 0x00043E58
		public StreamingContextStates State
		{
			get
			{
				return this.m_state;
			}
		}

		// Token: 0x04000FDA RID: 4058
		internal readonly object m_additionalContext;

		// Token: 0x04000FDB RID: 4059
		internal readonly StreamingContextStates m_state;
	}
}
