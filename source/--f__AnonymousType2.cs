using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

// Token: 0x02000004 RID: 4
[CompilerGenerated]
internal sealed class <>f__AnonymousType2<<index>j__TPar, <state>j__TPar>
{
	// Token: 0x17000005 RID: 5
	// (get) Token: 0x0600000D RID: 13 RVA: 0x000021C8 File Offset: 0x000003C8
	public <index>j__TPar index
	{
		get
		{
			return this.<index>i__Field;
		}
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x0600000E RID: 14 RVA: 0x000021DB File Offset: 0x000003DB
	public <state>j__TPar state
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x0600000F RID: 15 RVA: 0x000021E8 File Offset: 0x000003E8
	[DebuggerHidden]
	public <>f__AnonymousType2(<index>j__TPar index, <state>j__TPar state)
	{
		this.<index>i__Field = index;
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00002204 File Offset: 0x00000404
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		if (value != null)
		{
			<index>j__TPar <index>j__TPar = this.<index>i__Field;
			return;
		}
	}

	// Token: 0x06000011 RID: 17 RVA: 0x0000221C File Offset: 0x0000041C
	[DebuggerHidden]
	public override int GetHashCode()
	{
		/*
An exception occurred when decompiling this method (06000011)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 <>f__AnonymousType2`2::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:!'<index>j__TPar'(var_0_06, ldfld:!'<index>j__TPar'('<>f__AnonymousType2`2'::<index>i__Field, ldloc:'<>f__AnonymousType2`2'(this)))
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

	// Token: 0x06000012 RID: 18 RVA: 0x00002230 File Offset: 0x00000430
	[DebuggerHidden]
	public override string ToString()
	{
		<index>j__TPar <index>j__TPar = this.<index>i__Field;
		string text;
		string text2;
		if ((text == null || text != null) && (text2 == null || text2 != null))
		{
			string text3;
			return text3;
		}
		throw new ArrayTypeMismatchException();
	}

	// Token: 0x04000005 RID: 5
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <index>j__TPar <index>i__Field;

	// Token: 0x04000006 RID: 6
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <state>j__TPar <state>i__Field;
}
