using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x02000005 RID: 5
[CompilerGenerated]
internal sealed class <>f__AnonymousType3<<itemId>j__TPar, <count>j__TPar>
{
	// Token: 0x17000007 RID: 7
	// (get) Token: 0x06000013 RID: 19 RVA: 0x0000225C File Offset: 0x0000045C
	public <itemId>j__TPar itemId
	{
		get
		{
			return this.<itemId>i__Field;
		}
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x06000014 RID: 20 RVA: 0x00002270 File Offset: 0x00000470
	public <count>j__TPar count
	{
		get
		{
			return this.<count>i__Field;
		}
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002284 File Offset: 0x00000484
	[DebuggerHidden]
	public <>f__AnonymousType3(<itemId>j__TPar itemId, <count>j__TPar count)
	{
		this.<itemId>i__Field = itemId;
		this.<count>i__Field = count;
	}

	// Token: 0x06000016 RID: 22 RVA: 0x000022A8 File Offset: 0x000004A8
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		if (value != null)
		{
			<itemId>j__TPar <itemId>j__TPar = this.<itemId>i__Field;
			<count>j__TPar <count>j__TPar = this.<count>i__Field;
			return;
		}
	}

	// Token: 0x06000017 RID: 23 RVA: 0x000022C8 File Offset: 0x000004C8
	[DebuggerHidden]
	public override int GetHashCode()
	{
		/*
An exception occurred when decompiling this method (06000017)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 <>f__AnonymousType3`2::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:!'<itemId>j__TPar'(var_0_06, ldfld:!'<itemId>j__TPar'('<>f__AnonymousType3`2'::<itemId>i__Field, ldloc:'<>f__AnonymousType3`2'(this)))
	stloc:!'<count>j__TPar'(var_1_0D, ldfld:!'<count>j__TPar'('<>f__AnonymousType3`2'::<count>i__Field, ldloc:'<>f__AnonymousType3`2'(this)))
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

	// Token: 0x06000018 RID: 24 RVA: 0x000022E4 File Offset: 0x000004E4
	[DebuggerHidden]
	public override string ToString()
	{
		<itemId>j__TPar <itemId>j__TPar = this.<itemId>i__Field;
		string text;
		if (text == null || text != null)
		{
			<count>j__TPar <count>j__TPar = this.<count>i__Field;
			string text2;
			if (text2 == null || text2 != null)
			{
				string text3;
				return text3;
			}
		}
		throw new ArrayTypeMismatchException();
	}

	// Token: 0x04000007 RID: 7
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <itemId>j__TPar <itemId>i__Field;

	// Token: 0x04000008 RID: 8
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <count>j__TPar <count>i__Field;
}
