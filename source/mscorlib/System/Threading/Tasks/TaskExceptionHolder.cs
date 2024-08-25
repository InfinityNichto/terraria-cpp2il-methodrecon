using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.ExceptionServices;

namespace System.Threading.Tasks
{
	// Token: 0x0200024B RID: 587
	internal class TaskExceptionHolder
	{
		// Token: 0x06001423 RID: 5155 RVA: 0x0002A534 File Offset: 0x00028734
		internal TaskExceptionHolder(Task task)
		{
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x0002A548 File Offset: 0x00028748
		private static bool ShouldFailFastOnUnobservedException()
		{
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x0002A558 File Offset: 0x00028758
		protected override void Finalize()
		{
			if (this.m_faultExceptions != null && !this.m_isHandled)
			{
				bool hasShutdownStarted = Environment.HasShutdownStarted;
				LowLevelListWithIList<ExceptionDispatchInfo> faultExceptions = this.m_faultExceptions;
				Task task = this.m_task;
			}
			base.Finalize();
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06001426 RID: 5158 RVA: 0x0002A5BC File Offset: 0x000287BC
		internal bool ContainsFaultList
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001426)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Threading.Tasks.TaskExceptionHolder::get_ContainsFaultList()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class System.Collections.Generic.LowLevelListWithIList`1<class System.Runtime.ExceptionServices.ExceptionDispatchInfo>(var_0_06, ldfld:class System.Collections.Generic.LowLevelListWithIList`1<class System.Runtime.ExceptionServices.ExceptionDispatchInfo>(TaskExceptionHolder::m_faultExceptions, ldloc:TaskExceptionHolder(this)))
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
		}

		// Token: 0x06001427 RID: 5159 RVA: 0x0002A5D0 File Offset: 0x000287D0
		internal void Add(object exceptionObject, bool representsCancellation)
		{
			this.SetCancellationException(exceptionObject);
		}

		// Token: 0x06001428 RID: 5160 RVA: 0x0002A5EC File Offset: 0x000287EC
		private void SetCancellationException(object exceptionObject)
		{
			if (exceptionObject != null)
			{
				return;
			}
			long num = 0L;
			this.m_cancellationException = num;
		}

		// Token: 0x06001429 RID: 5161 RVA: 0x0002A610 File Offset: 0x00028810
		private void AddFaultException(object exceptionObject)
		{
			if (this.m_faultExceptions == null)
			{
			}
			if (exceptionObject != null)
			{
			}
			if (exceptionObject != null)
			{
				return;
			}
			if (exceptionObject != null)
			{
				this.MarkAsUnhandled();
				return;
			}
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x0002A674 File Offset: 0x00028874
		private void MarkAsUnhandled()
		{
			if (this.m_isHandled)
			{
				GC.ReRegisterForFinalize(this);
			}
		}

		// Token: 0x0600142B RID: 5163 RVA: 0x0002A690 File Offset: 0x00028890
		internal void MarkAsHandled(bool calledFromFinalizer)
		{
			bool isHandled = this.m_isHandled;
			GC.SuppressFinalize(this);
			this.m_isHandled = true;
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x0002A6B4 File Offset: 0x000288B4
		internal AggregateException CreateExceptionObject(bool calledFromFinalizer, Exception includeThisException)
		{
			LowLevelListWithIList<ExceptionDispatchInfo> faultExceptions = this.m_faultExceptions;
			this.MarkAsHandled(calledFromFinalizer);
			if (includeThisException != null)
			{
				long num = 0L;
				Exception exception = faultExceptions[(int)num].m_Exception;
				if ((exception != null && exception == null) || includeThisException != null)
				{
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x0002A6F0 File Offset: 0x000288F0
		internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos()
		{
			/*
An exception occurred when decompiling this method (0600142D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.ObjectModel.ReadOnlyCollection`1<System.Runtime.ExceptionServices.ExceptionDispatchInfo> System.Threading.Tasks.TaskExceptionHolder::GetExceptionDispatchInfos()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class System.Collections.Generic.LowLevelListWithIList`1<class System.Runtime.ExceptionServices.ExceptionDispatchInfo>(var_0_06, ldfld:class System.Collections.Generic.LowLevelListWithIList`1<class System.Runtime.ExceptionServices.ExceptionDispatchInfo>(TaskExceptionHolder::m_faultExceptions, ldloc:TaskExceptionHolder(this)))
	stloc:int64(var_1_08, ldc.i4:int64(0))
	call:void(TaskExceptionHolder::MarkAsHandled, ldloc:TaskExceptionHolder(this), ldloc:int64[exp:bool](var_1_08))
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

		// Token: 0x0600142E RID: 5166 RVA: 0x0002A70C File Offset: 0x0002890C
		internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo()
		{
			return this.m_cancellationException;
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x0002A720 File Offset: 0x00028920
		// Note: this type is marked as 'beforefieldinit'.
		static TaskExceptionHolder()
		{
		}

		// Token: 0x04000AB4 RID: 2740
		private static readonly bool s_failFastOnUnobservedException;

		// Token: 0x04000AB5 RID: 2741
		private readonly Task m_task;

		// Token: 0x04000AB6 RID: 2742
		private LowLevelListWithIList<ExceptionDispatchInfo> m_faultExceptions;

		// Token: 0x04000AB7 RID: 2743
		private ExceptionDispatchInfo m_cancellationException;

		// Token: 0x04000AB8 RID: 2744
		private bool m_isHandled;
	}
}
