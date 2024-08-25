using System;
using System.Runtime.Versioning;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x020000E3 RID: 227
	[NonVersionable]
	[Serializable]
	public struct Nullable<T> where T : struct
	{
		// Token: 0x0600084D RID: 2125 RVA: 0x000134F0 File Offset: 0x000116F0
		[NonVersionable]
		public Nullable(T value)
		{
			this.hasValue = true;
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600084E RID: 2126 RVA: 0x0000207A File Offset: 0x0000027A
		public bool HasValue
		{
			[NonVersionable]
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600084F RID: 2127 RVA: 0x00013504 File Offset: 0x00011704
		public T Value
		{
			get
			{
				ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue();
				return this.value;
			}
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x00013520 File Offset: 0x00011720
		[NonVersionable]
		public T GetValueOrDefault()
		{
			return this.value;
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00013534 File Offset: 0x00011734
		[NonVersionable]
		public T GetValueOrDefault(T defaultValue)
		{
			/*
An exception occurred when decompiling this method (06000851)

ICSharpCode.Decompiler.DecompilerException: Error decompiling T System.Nullable`1::GetValueOrDefault(T)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:!T(var_0_06, ldfld:!T(Nullable`1::value, ldloc:valuetype System.Nullable`1&(this)))
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

		// Token: 0x06000852 RID: 2130 RVA: 0x00013548 File Offset: 0x00011748
		public override bool Equals(object other)
		{
			bool flag;
			if (other != null)
			{
				return flag;
			}
			return flag;
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x0001355C File Offset: 0x0001175C
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x0001356C File Offset: 0x0001176C
		public override string ToString()
		{
			string text;
			return text;
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x00013580 File Offset: 0x00011780
		private static object Box(T? o)
		{
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x00013590 File Offset: 0x00011790
		private static T? Unbox(object o)
		{
			throw new InvalidCastException();
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x000135A4 File Offset: 0x000117A4
		private static T? UnboxExact(object o)
		{
			Type type;
			Type type2;
			bool flag = type != type2;
			return 1;
		}

		// Token: 0x0400036D RID: 877
		private readonly bool hasValue;

		// Token: 0x0400036E RID: 878
		internal T value;
	}
}
