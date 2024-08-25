using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace UnityEngine.Events
{
	// Token: 0x0200015E RID: 350
	internal class InvokableCall<T1> : BaseInvokableCall
	{
		// Token: 0x14000006 RID: 6
		// (add) Token: 0x0600068E RID: 1678 RVA: 0x0000BAA0 File Offset: 0x00009CA0
		// (remove) Token: 0x0600068F RID: 1679 RVA: 0x0000BAC8 File Offset: 0x00009CC8
		protected event UnityAction<T1> Delegate
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate = global::System.Delegate.Combine(this.Delegate, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = global::System.Delegate.Remove(this.Delegate, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x0000BAF0 File Offset: 0x00009CF0
		public InvokableCall(object target, MethodInfo theFunction)
			: base(target, theFunction)
		{
			Type type;
			Delegate @delegate = global::System.Delegate.CreateDelegate(type, target, theFunction);
			if (@delegate != null && @delegate == null)
			{
				throw new InvalidCastException();
			}
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x0000BB1C File Offset: 0x00009D1C
		public InvokableCall(UnityAction<T1> action)
		{
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x0000BB30 File Offset: 0x00009D30
		public override void Invoke(object[] args)
		{
			bool flag = BaseInvokableCall.AllowInvoke(this.Delegate);
			UnityAction @delegate = this.Delegate;
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x0000BB58 File Offset: 0x00009D58
		public virtual void Invoke(T1 args0)
		{
			bool flag = BaseInvokableCall.AllowInvoke(this.Delegate);
			UnityAction @delegate = this.Delegate;
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x0000BB7C File Offset: 0x00009D7C
		public override bool Find(object targetObj, MethodInfo method)
		{
			/*
An exception occurred when decompiling this method (06000694)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.Events.InvokableCall`1::Find(System.Object,System.Reflection.MethodInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:UnityAction`1(var_0_06, ldfld:class UnityEngine.Events.UnityAction`1<!T1>[exp:UnityAction`1](InvokableCall`1::Delegate, ldloc:InvokableCall`1(this)))
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

		// Token: 0x0400064F RID: 1615
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private UnityAction<T1> Delegate;
	}
}
