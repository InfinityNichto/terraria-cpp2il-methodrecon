using System;
using System.Reflection;
using Cpp2IlInjected;

namespace System.Collections.Generic
{
	// Token: 0x0200063C RID: 1596
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	[DefaultMember("Item")]
	internal ref struct ValueListBuilder<T>
	{
		// Token: 0x060030DF RID: 12511 RVA: 0x0006AAF0 File Offset: 0x00068CF0
		public ValueListBuilder(Span<T> initialSpan)
		{
			this._span = initialSpan;
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x060030E0 RID: 12512 RVA: 0x0000207A File Offset: 0x0000027A
		public int Length
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060030E1 RID: 12513 RVA: 0x0006AB04 File Offset: 0x00068D04
		public void Append(T item)
		{
			this.Grow();
		}

		// Token: 0x060030E2 RID: 12514 RVA: 0x0006AB18 File Offset: 0x00068D18
		public ReadOnlySpan<T> AsSpan()
		{
			/*
An exception occurred when decompiling this method (060030E2)

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

		// Token: 0x060030E3 RID: 12515 RVA: 0x0006AB2C File Offset: 0x00068D2C
		public void Dispose()
		{
		}

		// Token: 0x060030E4 RID: 12516 RVA: 0x0006AB3C File Offset: 0x00068D3C
		private void Grow()
		{
			if ((ref this) == null)
			{
			}
		}

		// Token: 0x04001A79 RID: 6777
		private Span<T> _span;

		// Token: 0x04001A7A RID: 6778
		private T[] _arrayFromPool;

		// Token: 0x04001A7B RID: 6779
		private int _pos;
	}
}
