using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x0200000C RID: 12
[CompilerGenerated]
internal sealed class <>f__AnonymousType10<<DisplayName>j__TPar, <FullId>j__TPar>
{
	// Token: 0x17000013 RID: 19
	// (get) Token: 0x0600003B RID: 59 RVA: 0x000026C0 File Offset: 0x000008C0
	public <DisplayName>j__TPar DisplayName
	{
		get
		{
			return this.<DisplayName>i__Field;
		}
	}

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x0600003C RID: 60 RVA: 0x000026D4 File Offset: 0x000008D4
	public <FullId>j__TPar FullId
	{
		get
		{
			return this.<FullId>i__Field;
		}
	}

	// Token: 0x0600003D RID: 61 RVA: 0x000026E8 File Offset: 0x000008E8
	[DebuggerHidden]
	public <>f__AnonymousType10(<DisplayName>j__TPar DisplayName, <FullId>j__TPar FullId)
	{
		this.<DisplayName>i__Field = DisplayName;
		this.<FullId>i__Field = FullId;
	}

	// Token: 0x0600003E RID: 62 RVA: 0x0000270C File Offset: 0x0000090C
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		if (value != null)
		{
			<DisplayName>j__TPar <DisplayName>j__TPar = this.<DisplayName>i__Field;
			<FullId>j__TPar <FullId>j__TPar = this.<FullId>i__Field;
			return;
		}
	}

	// Token: 0x0600003F RID: 63 RVA: 0x0000272C File Offset: 0x0000092C
	[DebuggerHidden]
	public override int GetHashCode()
	{
		/*
An exception occurred when decompiling this method (0600003F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 <>f__AnonymousType10`2::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:!'<DisplayName>j__TPar'(var_0_06, ldfld:!'<DisplayName>j__TPar'('<>f__AnonymousType10`2'::<DisplayName>i__Field, ldloc:'<>f__AnonymousType10`2'(this)))
	stloc:!'<FullId>j__TPar'(var_1_0D, ldfld:!'<FullId>j__TPar'('<>f__AnonymousType10`2'::<FullId>i__Field, ldloc:'<>f__AnonymousType10`2'(this)))
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

	// Token: 0x06000040 RID: 64 RVA: 0x00002748 File Offset: 0x00000948
	[DebuggerHidden]
	public override string ToString()
	{
		<DisplayName>j__TPar <DisplayName>j__TPar = this.<DisplayName>i__Field;
		if (<DisplayName>j__TPar == null || <DisplayName>j__TPar == null || <DisplayName>j__TPar == null)
		{
		}
		<FullId>j__TPar <FullId>j__TPar = this.<FullId>i__Field;
		if (<FullId>j__TPar != null && <FullId>j__TPar != null && <FullId>j__TPar == null)
		{
			throw new ArrayTypeMismatchException();
		}
		string text;
		return text;
	}

	// Token: 0x04000013 RID: 19
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <DisplayName>j__TPar <DisplayName>i__Field;

	// Token: 0x04000014 RID: 20
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <FullId>j__TPar <FullId>i__Field;
}
