using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace UnityEngine.Events
{
	// Token: 0x0200015F RID: 351
	internal class InvokableCall<T1, T2> : BaseInvokableCall
	{
		// Token: 0x06000695 RID: 1685 RVA: 0x0000BB94 File Offset: 0x00009D94
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

		// Token: 0x06000696 RID: 1686 RVA: 0x0000BBD4 File Offset: 0x00009DD4
		public override void Invoke(object[] args)
		{
			bool flag = BaseInvokableCall.AllowInvoke(this.Delegate);
			UnityAction @delegate = this.Delegate;
			if (!flag)
			{
				throw new InvalidCastException();
			}
			if (args != null && args == null)
			{
				throw new InvalidCastException();
			}
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x0000BC0C File Offset: 0x00009E0C
		public override bool Find(object targetObj, MethodInfo method)
		{
			/*
An exception occurred when decompiling this method (06000697)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.Events.InvokableCall`2::Find(System.Object,System.Reflection.MethodInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:UnityAction`2(var_0_06, ldfld:class UnityEngine.Events.UnityAction`2<!T1, !T2>[exp:UnityAction`2](InvokableCall`2::Delegate, ldloc:InvokableCall`2(this)))
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

		// Token: 0x04000650 RID: 1616
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private UnityAction<T1, T2> Delegate;
	}
}
