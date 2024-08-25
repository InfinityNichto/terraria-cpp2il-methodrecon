using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000CE RID: 206
	[Preserve]
	public struct JEnumerable<T> : IJEnumerable<T>, IEnumerable<T>, IEnumerable where T : JToken
	{
		// Token: 0x060007A6 RID: 1958 RVA: 0x00013634 File Offset: 0x00011834
		public JEnumerable(IEnumerable<T> enumerable)
		{
			this._enumerable = enumerable;
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x00013648 File Offset: 0x00011848
		public IEnumerator<T> GetEnumerator()
		{
			IEnumerator enumerator;
			return enumerator;
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00013658 File Offset: 0x00011858
		IEnumerator IEnumerable.GetEnumerator()
		{
			/*
An exception occurred when decompiling this method (060007A8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.IEnumerator Newtonsoft.Json.Linq.JEnumerable`1::System.Collections.IEnumerable.GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:IEnumerator`1(var_0_06, call:IEnumerator`1(JEnumerable`1::GetEnumerator, ldloc:valuetype Newtonsoft.Json.Linq.JEnumerable`1&(this)))
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

		// Token: 0x17000176 RID: 374
		public IJEnumerable<JToken> this[object key]
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x00013680 File Offset: 0x00011880
		public bool Equals(JEnumerable<T> other)
		{
			bool flag;
			return flag;
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00013690 File Offset: 0x00011890
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x0000212A File Offset: 0x0000032A
		public override int GetHashCode()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x000136AC File Offset: 0x000118AC
		// Note: this type is marked as 'beforefieldinit'.
		static JEnumerable()
		{
		}

		// Token: 0x04000328 RID: 808
		public static readonly JEnumerable<T> Empty;

		// Token: 0x04000329 RID: 809
		private readonly IEnumerable<T> _enumerable;
	}
}
