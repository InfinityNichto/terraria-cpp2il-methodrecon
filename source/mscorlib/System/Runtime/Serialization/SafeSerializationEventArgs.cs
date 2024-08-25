using System;
using System.Collections.Generic;

namespace System.Runtime.Serialization
{
	// Token: 0x020003E4 RID: 996
	public sealed class SafeSerializationEventArgs : EventArgs
	{
		// Token: 0x06001F81 RID: 8065 RVA: 0x0004535C File Offset: 0x0004355C
		internal SafeSerializationEventArgs(StreamingContext streamingContext)
		{
			if (!true)
			{
			}
			base..ctor();
			this.m_streamingContext = streamingContext;
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06001F82 RID: 8066 RVA: 0x0004537C File Offset: 0x0004357C
		internal IList<object> SerializedStates
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001F82)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IList`1<System.Object> System.Runtime.Serialization.SafeSerializationEventArgs::get_SerializedStates()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class System.Collections.Generic.List`1<object>(var_0_06, ldfld:class System.Collections.Generic.List`1<object>(SafeSerializationEventArgs::m_serializedStates, ldloc:SafeSerializationEventArgs(this)))
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

		// Token: 0x04000FC0 RID: 4032
		private StreamingContext m_streamingContext;

		// Token: 0x04000FC1 RID: 4033
		private List<object> m_serializedStates;
	}
}
