using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Interop;

namespace System.Threading
{
	// Token: 0x020001F3 RID: 499
	internal class OSSpecificSynchronizationContext : SynchronizationContext
	{
		// Token: 0x060011D1 RID: 4561 RVA: 0x00025D70 File Offset: 0x00023F70
		private OSSpecificSynchronizationContext(object osContext)
		{
			this.m_OSSynchronizationContext = osContext;
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x00025D8C File Offset: 0x00023F8C
		public static OSSpecificSynchronizationContext Get()
		{
			/*
An exception occurred when decompiling this method (060011D2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.OSSpecificSynchronizationContext System.Threading.OSSpecificSynchronizationContext::Get()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x00025D9C File Offset: 0x00023F9C
		public override SynchronizationContext CreateCopy()
		{
			/*
An exception occurred when decompiling this method (060011D3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.SynchronizationContext System.Threading.OSSpecificSynchronizationContext::CreateCopy()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:object(var_0_06, ldfld:object(OSSpecificSynchronizationContext::m_OSSynchronizationContext, ldloc:OSSpecificSynchronizationContext(this)))
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

		// Token: 0x060011D4 RID: 4564 RVA: 0x0000207A File Offset: 0x0000027A
		public override void Send(SendOrPostCallback d, object state)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x00025DB0 File Offset: 0x00023FB0
		public override void Post(SendOrPostCallback d, object state)
		{
			if (!true)
			{
			}
			object ossynchronizationContext = this.m_OSSynchronizationContext;
			GCHandle gchandle;
			IntPtr intPtr = GCHandle.ToIntPtr(gchandle);
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x00025DD4 File Offset: 0x00023FD4
		[MonoPInvokeCallback(typeof(OSSpecificSynchronizationContext.InvocationEntryDelegate))]
		private static void InvocationEntry(IntPtr arg)
		{
			if (GCHandle.FromIntPtr(arg).Target != null)
			{
			}
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x0000207A File Offset: 0x0000027A
		private static object GetOSContext()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x00025E00 File Offset: 0x00024000
		private static void PostInternal(object osSynchronizationContext, IntPtr callback, IntPtr arg)
		{
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x00025E10 File Offset: 0x00024010
		// Note: this type is marked as 'beforefieldinit'.
		static OSSpecificSynchronizationContext()
		{
		}

		// Token: 0x04000996 RID: 2454
		private object m_OSSynchronizationContext;

		// Token: 0x04000997 RID: 2455
		private static readonly ConditionalWeakTable<object, OSSpecificSynchronizationContext> s_ContextCache;

		// Token: 0x020001F4 RID: 500
		private sealed class InvocationEntryDelegate : MulticastDelegate
		{
			// Token: 0x060011DA RID: 4570 RVA: 0x00025E20 File Offset: 0x00024020
			public InvocationEntryDelegate(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x060011DB RID: 4571 RVA: 0x00025E74 File Offset: 0x00024074
			public void Invoke(IntPtr arg)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}
		}

		// Token: 0x020001F5 RID: 501
		private class InvocationContext
		{
			// Token: 0x060011DC RID: 4572 RVA: 0x00025E98 File Offset: 0x00024098
			public InvocationContext(SendOrPostCallback d, object state)
			{
				this.m_Delegate = d;
				this.m_State = state;
			}

			// Token: 0x060011DD RID: 4573 RVA: 0x00025EBC File Offset: 0x000240BC
			public void Invoke()
			{
				SendOrPostCallback @delegate = this.m_Delegate;
				object state = this.m_State;
				IntPtr invoke_impl = @delegate.invoke_impl;
				IntPtr method_code = @delegate.method_code;
				IntPtr method = @delegate.method;
			}

			// Token: 0x04000998 RID: 2456
			private SendOrPostCallback m_Delegate;

			// Token: 0x04000999 RID: 2457
			private object m_State;
		}

		// Token: 0x020001F6 RID: 502
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060011DE RID: 4574 RVA: 0x00025EF0 File Offset: 0x000240F0
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060011DF RID: 4575 RVA: 0x00025F00 File Offset: 0x00024100
			public <>c()
			{
			}

			// Token: 0x060011E0 RID: 4576 RVA: 0x0000207A File Offset: 0x0000027A
			internal OSSpecificSynchronizationContext <Get>b__3_0(object _osContext)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0400099A RID: 2458
			public static readonly OSSpecificSynchronizationContext.<>c <>9;

			// Token: 0x0400099B RID: 2459
			public static ConditionalWeakTable<object, OSSpecificSynchronizationContext>.CreateValueCallback <>9__3_0;
		}
	}
}
