using System;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x020000AA RID: 170
	public abstract class FormattableString : IFormattable
	{
		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000683 RID: 1667
		public abstract string Format { get; }

		// Token: 0x06000684 RID: 1668
		public abstract object[] GetArguments();

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000685 RID: 1669
		public abstract int ArgumentCount { get; }

		// Token: 0x06000686 RID: 1670
		public abstract object GetArgument(int index);

		// Token: 0x06000687 RID: 1671
		public abstract string ToString(IFormatProvider formatProvider);

		// Token: 0x06000688 RID: 1672 RVA: 0x0000207A File Offset: 0x0000027A
		string IFormattable.ToString(string ignored, IFormatProvider formatProvider)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x0000FB1C File Offset: 0x0000DD1C
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (06000689)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.FormattableString::ToString()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:CultureInfo(var_1_0A, callgetter:CultureInfo(CultureInfo::get_CurrentCulture))
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

		// Token: 0x0600068A RID: 1674 RVA: 0x0000FB34 File Offset: 0x0000DD34
		protected FormattableString()
		{
		}
	}
}
