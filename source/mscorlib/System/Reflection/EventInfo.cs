using System;
using Cpp2IlInjected;
using Mono;

namespace System.Reflection
{
	// Token: 0x020004D0 RID: 1232
	[Serializable]
	public abstract class EventInfo : MemberInfo
	{
		// Token: 0x06002380 RID: 9088 RVA: 0x000504F0 File Offset: 0x0004E6F0
		protected EventInfo()
		{
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06002381 RID: 9089 RVA: 0x00050504 File Offset: 0x0004E704
		public override MemberTypes MemberType
		{
			get
			{
				return MemberTypes.Event;
			}
		}

		// Token: 0x06002382 RID: 9090 RVA: 0x0000207A File Offset: 0x0000027A
		public MethodInfo GetAddMethod()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002383 RID: 9091 RVA: 0x0000207A File Offset: 0x0000027A
		public MethodInfo GetRemoveMethod()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002384 RID: 9092
		public abstract MethodInfo GetAddMethod(bool nonPublic);

		// Token: 0x06002385 RID: 9093
		public abstract MethodInfo GetRemoveMethod(bool nonPublic);

		// Token: 0x06002386 RID: 9094
		public abstract MethodInfo GetRaiseMethod(bool nonPublic);

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06002387 RID: 9095 RVA: 0x00050514 File Offset: 0x0004E714
		public virtual Type EventHandlerType
		{
			get
			{
			}
		}

		// Token: 0x06002388 RID: 9096 RVA: 0x00050524 File Offset: 0x0004E724
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06002389 RID: 9097 RVA: 0x00050538 File Offset: 0x0004E738
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x0600238A RID: 9098 RVA: 0x0005054C File Offset: 0x0004E74C
		public static bool operator ==(EventInfo left, EventInfo right)
		{
			if (left != null)
			{
			}
			return true;
		}

		// Token: 0x0600238B RID: 9099 RVA: 0x00050560 File Offset: 0x0004E760
		public static bool operator !=(EventInfo left, EventInfo right)
		{
			/*
An exception occurred when decompiling this method (0600238B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Reflection.EventInfo::op_Inequality(System.Reflection.EventInfo,System.Reflection.EventInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldloc:EventInfo[exp:bool](left)))
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

		// Token: 0x0600238C RID: 9100 RVA: 0x0000207A File Offset: 0x0000027A
		private static EventInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600238D RID: 9101 RVA: 0x00050570 File Offset: 0x0004E770
		internal static EventInfo GetEventFromHandle(RuntimeEventHandle handle, RuntimeTypeHandle reflectedType)
		{
			bool flag;
			while (!flag)
			{
			}
			return "The handle is invalid.";
		}

		// Token: 0x0400138D RID: 5005
		private EventInfo.AddEventAdapter cached_add_event;

		// Token: 0x020004D1 RID: 1233
		private sealed class AddEventAdapter : MulticastDelegate
		{
			// Token: 0x0600238E RID: 9102 RVA: 0x00050588 File Offset: 0x0004E788
			public AddEventAdapter(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x0600238F RID: 9103 RVA: 0x000505E8 File Offset: 0x0004E7E8
			public void Invoke(object _this, Delegate dele)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}
		}
	}
}
