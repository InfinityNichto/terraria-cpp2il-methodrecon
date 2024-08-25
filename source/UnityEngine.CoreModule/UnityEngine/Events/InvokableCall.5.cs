using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace UnityEngine.Events
{
	// Token: 0x02000161 RID: 353
	internal class InvokableCall<T1, T2, T3, T4> : BaseInvokableCall
	{
		// Token: 0x0600069B RID: 1691 RVA: 0x0000BCB8 File Offset: 0x00009EB8
		public InvokableCall(object target, MethodInfo theFunction)
			: base(target, theFunction)
		{
			long num = 0L;
			Type type;
			Delegate @delegate = global::System.Delegate.CreateDelegate(type, num, theFunction);
			long num2;
			if (@delegate != null)
			{
				if (@delegate == null)
				{
					throw new InvalidCastException();
				}
			}
			else
			{
				num2 = 0L;
			}
			this.Delegate = num2;
			if (@delegate == null || @delegate != null)
			{
				return;
			}
			throw new InvalidCastException();
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x0000BCFC File Offset: 0x00009EFC
		public override void Invoke(object[] args)
		{
			bool flag = BaseInvokableCall.AllowInvoke(this.Delegate);
			UnityAction @delegate = this.Delegate;
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x0000BD38 File Offset: 0x00009F38
		public override bool Find(object targetObj, MethodInfo method)
		{
			/*
An exception occurred when decompiling this method (0600069D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.Events.InvokableCall`4::Find(System.Object,System.Reflection.MethodInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:UnityAction`4(var_0_06, ldfld:class UnityEngine.Events.UnityAction`4<!T1, !T2, !T3, !T4>[exp:UnityAction`4](InvokableCall`4::Delegate, ldloc:InvokableCall`4(this)))
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

		// Token: 0x04000652 RID: 1618
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private UnityAction<T1, T2, T3, T4> Delegate;
	}
}
