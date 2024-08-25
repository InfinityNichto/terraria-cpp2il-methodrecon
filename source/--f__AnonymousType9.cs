using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x0200000B RID: 11
[CompilerGenerated]
internal sealed class <>f__AnonymousType9<<FilePath>j__TPar, <Reason>j__TPar>
{
	// Token: 0x17000011 RID: 17
	// (get) Token: 0x06000035 RID: 53 RVA: 0x00002600 File Offset: 0x00000800
	public <FilePath>j__TPar FilePath
	{
		get
		{
			return this.<FilePath>i__Field;
		}
	}

	// Token: 0x17000012 RID: 18
	// (get) Token: 0x06000036 RID: 54 RVA: 0x00002614 File Offset: 0x00000814
	public <Reason>j__TPar Reason
	{
		get
		{
			return this.<Reason>i__Field;
		}
	}

	// Token: 0x06000037 RID: 55 RVA: 0x00002628 File Offset: 0x00000828
	[DebuggerHidden]
	public <>f__AnonymousType9(<FilePath>j__TPar FilePath, <Reason>j__TPar Reason)
	{
		this.<FilePath>i__Field = FilePath;
		this.<Reason>i__Field = Reason;
	}

	// Token: 0x06000038 RID: 56 RVA: 0x0000264C File Offset: 0x0000084C
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		if (value != null)
		{
			<FilePath>j__TPar <FilePath>j__TPar = this.<FilePath>i__Field;
			<Reason>j__TPar <Reason>j__TPar = this.<Reason>i__Field;
			return;
		}
	}

	// Token: 0x06000039 RID: 57 RVA: 0x0000266C File Offset: 0x0000086C
	[DebuggerHidden]
	public override int GetHashCode()
	{
		/*
An exception occurred when decompiling this method (06000039)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 <>f__AnonymousType9`2::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:!'<FilePath>j__TPar'(var_0_06, ldfld:!'<FilePath>j__TPar'('<>f__AnonymousType9`2'::<FilePath>i__Field, ldloc:'<>f__AnonymousType9`2'(this)))
	stloc:!'<Reason>j__TPar'(var_1_0D, ldfld:!'<Reason>j__TPar'('<>f__AnonymousType9`2'::<Reason>i__Field, ldloc:'<>f__AnonymousType9`2'(this)))
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

	// Token: 0x0600003A RID: 58 RVA: 0x00002688 File Offset: 0x00000888
	[DebuggerHidden]
	public override string ToString()
	{
		<FilePath>j__TPar <FilePath>j__TPar = this.<FilePath>i__Field;
		if (<FilePath>j__TPar == null || <FilePath>j__TPar == null || <FilePath>j__TPar == null)
		{
		}
		<Reason>j__TPar <Reason>j__TPar = this.<Reason>i__Field;
		if (<Reason>j__TPar != null && <Reason>j__TPar != null && <Reason>j__TPar == null)
		{
			throw new ArrayTypeMismatchException();
		}
		string text;
		return text;
	}

	// Token: 0x04000011 RID: 17
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <FilePath>j__TPar <FilePath>i__Field;

	// Token: 0x04000012 RID: 18
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <Reason>j__TPar <Reason>i__Field;
}
