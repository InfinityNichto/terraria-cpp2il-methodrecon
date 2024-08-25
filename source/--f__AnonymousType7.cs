using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

// Token: 0x02000009 RID: 9
[CompilerGenerated]
internal sealed class <>f__AnonymousType7<<NeededWidth>j__TPar, <NeededHeight>j__TPar, <ActualWidth>j__TPar, <ActualHeight>j__TPar>
{
	// Token: 0x1700000C RID: 12
	// (get) Token: 0x06000028 RID: 40 RVA: 0x000024A4 File Offset: 0x000006A4
	public <NeededWidth>j__TPar NeededWidth
	{
		get
		{
			return this.<NeededWidth>i__Field;
		}
	}

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x06000029 RID: 41 RVA: 0x000021DB File Offset: 0x000003DB
	public <NeededHeight>j__TPar NeededHeight
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x0600002A RID: 42 RVA: 0x000024B8 File Offset: 0x000006B8
	public <ActualWidth>j__TPar ActualWidth
	{
		get
		{
			return this.<NeededHeight>i__Field;
		}
	}

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x0600002B RID: 43 RVA: 0x000021DB File Offset: 0x000003DB
	public <ActualHeight>j__TPar ActualHeight
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x0600002C RID: 44 RVA: 0x000024CC File Offset: 0x000006CC
	[DebuggerHidden]
	public <>f__AnonymousType7(<NeededWidth>j__TPar NeededWidth, <NeededHeight>j__TPar NeededHeight, <ActualWidth>j__TPar ActualWidth, <ActualHeight>j__TPar ActualHeight)
	{
		this.<NeededWidth>i__Field = NeededWidth;
		this.<NeededHeight>i__Field = NeededHeight;
		this.<NeededHeight>i__Field = ActualWidth;
		this.<ActualWidth>i__Field = ActualHeight;
	}

	// Token: 0x0600002D RID: 45 RVA: 0x000024FC File Offset: 0x000006FC
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		if (value != null)
		{
			<NeededWidth>j__TPar <NeededWidth>j__TPar = this.<NeededWidth>i__Field;
			<NeededHeight>j__TPar <NeededHeight>j__TPar = this.<NeededHeight>i__Field;
			return;
		}
	}

	// Token: 0x0600002E RID: 46 RVA: 0x0000251C File Offset: 0x0000071C
	[DebuggerHidden]
	public override int GetHashCode()
	{
		/*
An exception occurred when decompiling this method (0600002E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 <>f__AnonymousType7`4::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:!'<NeededWidth>j__TPar'(var_0_06, ldfld:!'<NeededWidth>j__TPar'('<>f__AnonymousType7`4'::<NeededWidth>i__Field, ldloc:'<>f__AnonymousType7`4'(this)))
	stloc:!'<NeededHeight>j__TPar'(var_1_0D, ldfld:!'<NeededHeight>j__TPar'('<>f__AnonymousType7`4'::<NeededHeight>i__Field, ldloc:'<>f__AnonymousType7`4'(this)))
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

	// Token: 0x0600002F RID: 47 RVA: 0x00002538 File Offset: 0x00000738
	[DebuggerHidden]
	public override string ToString()
	{
		<NeededWidth>j__TPar <NeededWidth>j__TPar = this.<NeededWidth>i__Field;
		string text;
		string text2;
		if ((text == null || text != null) && (text2 == null || text2 != null))
		{
			<NeededHeight>j__TPar <NeededHeight>j__TPar = this.<NeededHeight>i__Field;
			string text3;
			string text4;
			if ((text3 == null || text3 != null) && (text4 == null || text4 != null))
			{
				string text5;
				return text5;
			}
		}
		throw new ArrayTypeMismatchException();
	}

	// Token: 0x0400000C RID: 12
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <NeededWidth>j__TPar <NeededWidth>i__Field;

	// Token: 0x0400000D RID: 13
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <NeededHeight>j__TPar <NeededHeight>i__Field;

	// Token: 0x0400000E RID: 14
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <ActualWidth>j__TPar <ActualWidth>i__Field;

	// Token: 0x0400000F RID: 15
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <ActualHeight>j__TPar <ActualHeight>i__Field;
}
