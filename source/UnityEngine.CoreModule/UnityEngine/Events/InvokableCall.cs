using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace UnityEngine.Events
{
	// Token: 0x0200015D RID: 349
	internal class InvokableCall : BaseInvokableCall
	{
		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000687 RID: 1671 RVA: 0x0000B97C File Offset: 0x00009B7C
		// (remove) Token: 0x06000688 RID: 1672 RVA: 0x0000B9A0 File Offset: 0x00009BA0
		private event UnityAction Delegate
		{
			[CompilerGenerated]
			add
			{
				if (global::System.Delegate.Combine(this.Delegate, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (global::System.Delegate.Remove(this.Delegate, value) != null)
				{
				}
			}
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x0000B9C4 File Offset: 0x00009BC4
		public InvokableCall(object target, MethodInfo theFunction)
			: base(target, theFunction)
		{
			if (!true)
			{
			}
			Type type;
			Delegate @delegate = global::System.Delegate.CreateDelegate(type, target, theFunction);
			if (@delegate != null)
			{
			}
			this.Delegate += @delegate;
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x0000B9F8 File Offset: 0x00009BF8
		public InvokableCall(UnityAction action)
		{
			this.Delegate += action;
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x0000BA14 File Offset: 0x00009C14
		public override void Invoke(object[] args)
		{
			bool flag = BaseInvokableCall.AllowInvoke(this.Delegate);
			UnityAction @delegate = this.Delegate;
			IntPtr invoke_impl = @delegate.invoke_impl;
			IntPtr method_code = @delegate.method_code;
			IntPtr method = @delegate.method;
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x0000BA4C File Offset: 0x00009C4C
		public void Invoke()
		{
			bool flag = BaseInvokableCall.AllowInvoke(this.Delegate);
			UnityAction @delegate = this.Delegate;
			IntPtr invoke_impl = @delegate.invoke_impl;
			IntPtr method_code = @delegate.method_code;
			IntPtr method = @delegate.method;
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x0000BA84 File Offset: 0x00009C84
		public override bool Find(object targetObj, MethodInfo method)
		{
			/*
An exception occurred when decompiling this method (0600068D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.Events.InvokableCall::Find(System.Object,System.Reflection.MethodInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:object(var_0_0B, ldfld:object(Delegate::m_target, ldfld:UnityAction[exp:Delegate](InvokableCall::Delegate, ldloc:InvokableCall(this))))
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

		// Token: 0x0400064E RID: 1614
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private UnityAction Delegate;
	}
}
