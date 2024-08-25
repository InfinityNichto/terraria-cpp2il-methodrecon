using System;
using Cpp2IlInjected;

namespace System.Collections.Generic
{
	// Token: 0x0200042B RID: 1067
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	internal ref struct ValueListBuilder<T>
	{
		// Token: 0x06001CF5 RID: 7413 RVA: 0x0004EC14 File Offset: 0x0004CE14
		public ValueListBuilder(Span<T> initialSpan)
		{
			this._span = initialSpan;
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06001CF6 RID: 7414 RVA: 0x00002050 File Offset: 0x00000250
		public int Length
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000681 RID: 1665
		public T this[int index]
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06001CF8 RID: 7416 RVA: 0x0004EC28 File Offset: 0x0004CE28
		public void Append(T item)
		{
			this.Grow();
		}

		// Token: 0x06001CF9 RID: 7417 RVA: 0x0004EC3C File Offset: 0x0004CE3C
		public ReadOnlySpan<T> AsSpan()
		{
			/*
An exception occurred when decompiling this method (06001CF9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.ReadOnlySpan`1<T> System.Collections.Generic.ValueListBuilder`1::AsSpan()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(ThrowHelper::ThrowArgumentOutOfRangeException)
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

		// Token: 0x06001CFA RID: 7418 RVA: 0x0004EC50 File Offset: 0x0004CE50
		public void Dispose()
		{
		}

		// Token: 0x06001CFB RID: 7419 RVA: 0x0004EC60 File Offset: 0x0004CE60
		private void Grow()
		{
			if ((ref this) == null)
			{
			}
		}

		// Token: 0x06001CFC RID: 7420 RVA: 0x00002050 File Offset: 0x00000250
		public T Pop()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x040013D4 RID: 5076
		private Span<T> _span;

		// Token: 0x040013D5 RID: 5077
		private T[] _arrayFromPool;

		// Token: 0x040013D6 RID: 5078
		private int _pos;
	}
}
