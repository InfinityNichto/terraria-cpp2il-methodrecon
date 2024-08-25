using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace UnityEngine.Events
{
	// Token: 0x02000160 RID: 352
	internal class InvokableCall<T1, T2, T3> : BaseInvokableCall
	{
		// Token: 0x06000698 RID: 1688 RVA: 0x0000BC24 File Offset: 0x00009E24
		public InvokableCall(object target, MethodInfo theFunction)
			: base(target, theFunction)
		{
			Type type;
			Delegate @delegate = global::System.Delegate.CreateDelegate(type, target, theFunction);
			long num;
			if (@delegate != null)
			{
				if (@delegate == null)
				{
					throw new InvalidCastException();
				}
			}
			else
			{
				num = 0L;
			}
			this.Delegate = num;
			if (@delegate == null || @delegate != null)
			{
				return;
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x0000BC64 File Offset: 0x00009E64
		public override void Invoke(object[] args)
		{
			bool flag = BaseInvokableCall.AllowInvoke(this.Delegate);
			UnityAction @delegate = this.Delegate;
			if (!flag)
			{
				return;
			}
			if (!flag)
			{
				throw new InvalidCastException();
			}
			if (args != null && args == null)
			{
				throw new InvalidCastException();
			}
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x0000BCA0 File Offset: 0x00009EA0
		public override bool Find(object targetObj, MethodInfo method)
		{
			/*
An exception occurred when decompiling this method (0600069A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.Events.InvokableCall`3::Find(System.Object,System.Reflection.MethodInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:UnityAction`3(var_0_06, ldfld:class UnityEngine.Events.UnityAction`3<!T1, !T2, !T3>[exp:UnityAction`3](InvokableCall`3::Delegate, ldloc:InvokableCall`3(this)))
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

		// Token: 0x04000651 RID: 1617
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private UnityAction<T1, T2, T3> Delegate;
	}
}
