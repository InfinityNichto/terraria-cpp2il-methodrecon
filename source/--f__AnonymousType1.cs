using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x02000003 RID: 3
[CompilerGenerated]
internal sealed class <>f__AnonymousType1<<Adjective>j__TPar, <Location>j__TPar, <Noun>j__TPar>
{
	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000006 RID: 6 RVA: 0x000020D0 File Offset: 0x000002D0
	public <Adjective>j__TPar Adjective
	{
		get
		{
			return this.<Adjective>i__Field;
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000007 RID: 7 RVA: 0x000020E4 File Offset: 0x000002E4
	public <Location>j__TPar Location
	{
		get
		{
			return this.<Location>i__Field;
		}
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000008 RID: 8 RVA: 0x000020F8 File Offset: 0x000002F8
	public <Noun>j__TPar Noun
	{
		get
		{
			return this.<Noun>i__Field;
		}
	}

	// Token: 0x06000009 RID: 9 RVA: 0x0000210C File Offset: 0x0000030C
	[DebuggerHidden]
	public <>f__AnonymousType1(<Adjective>j__TPar Adjective, <Location>j__TPar Location, <Noun>j__TPar Noun)
	{
		this.<Adjective>i__Field = Adjective;
		this.<Location>i__Field = Location;
		this.<Noun>i__Field = Noun;
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002134 File Offset: 0x00000334
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		if (value != null)
		{
			<Adjective>j__TPar <Adjective>j__TPar = this.<Adjective>i__Field;
			<Location>j__TPar <Location>j__TPar = this.<Location>i__Field;
			<Noun>j__TPar <Noun>j__TPar = this.<Noun>i__Field;
			return;
		}
	}

	// Token: 0x0600000B RID: 11 RVA: 0x0000215C File Offset: 0x0000035C
	[DebuggerHidden]
	public override int GetHashCode()
	{
		/*
An exception occurred when decompiling this method (0600000B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 <>f__AnonymousType1`3::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:!'<Adjective>j__TPar'(var_0_06, ldfld:!'<Adjective>j__TPar'('<>f__AnonymousType1`3'::<Adjective>i__Field, ldloc:'<>f__AnonymousType1`3'(this)))
	stloc:!'<Location>j__TPar'(var_1_0D, ldfld:!'<Location>j__TPar'('<>f__AnonymousType1`3'::<Location>i__Field, ldloc:'<>f__AnonymousType1`3'(this)))
	stloc:!'<Noun>j__TPar'(var_2_14, ldfld:!'<Noun>j__TPar'('<>f__AnonymousType1`3'::<Noun>i__Field, ldloc:'<>f__AnonymousType1`3'(this)))
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

	// Token: 0x0600000C RID: 12 RVA: 0x00002180 File Offset: 0x00000380
	[DebuggerHidden]
	public override string ToString()
	{
		<Adjective>j__TPar <Adjective>j__TPar = this.<Adjective>i__Field;
		if (<Adjective>j__TPar == null || <Adjective>j__TPar == null || <Adjective>j__TPar == null)
		{
		}
		<Location>j__TPar <Location>j__TPar = this.<Location>i__Field;
		if (<Location>j__TPar == null || <Location>j__TPar == null || <Location>j__TPar == null)
		{
		}
		<Noun>j__TPar <Noun>j__TPar = this.<Noun>i__Field;
		if (<Noun>j__TPar != null && <Noun>j__TPar != null && <Noun>j__TPar == null)
		{
			throw new ArrayTypeMismatchException();
		}
		string text;
		return text;
	}

	// Token: 0x04000002 RID: 2
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <Adjective>j__TPar <Adjective>i__Field;

	// Token: 0x04000003 RID: 3
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <Location>j__TPar <Location>i__Field;

	// Token: 0x04000004 RID: 4
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <Noun>j__TPar <Noun>i__Field;
}
