using System;

namespace System.Threading
{
	// Token: 0x020001D0 RID: 464
	public readonly struct CancellationTokenRegistration : IEquatable<CancellationTokenRegistration>, IDisposable
	{
		// Token: 0x06001103 RID: 4355 RVA: 0x00023FD8 File Offset: 0x000221D8
		internal CancellationTokenRegistration(CancellationCallbackInfo callbackInfo, SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> registrationInfo)
		{
			this.m_callbackInfo = callbackInfo;
			this.m_registrationInfo = registrationInfo;
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x00023FF4 File Offset: 0x000221F4
		public bool Unregister()
		{
			/*
An exception occurred when decompiling this method (06001104)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Threading.CancellationTokenRegistration::Unregister()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_13, ldfld:int32(SparselyPopulatedArrayAddInfo`1::_index, ldfld:valuetype System.Threading.SparselyPopulatedArrayAddInfo`1<class System.Threading.CancellationCallbackInfo>[exp:valuetype System.Threading.SparselyPopulatedArrayAddInfo`1&](CancellationTokenRegistration::m_registrationInfo, ldloc:valuetype System.Threading.CancellationTokenRegistration&(this))))
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

		// Token: 0x06001105 RID: 4357 RVA: 0x00024014 File Offset: 0x00022214
		public void Dispose()
		{
			bool flag = this.Unregister();
			int currentManagedThreadId = Environment.CurrentManagedThreadId;
		}

		// Token: 0x06001106 RID: 4358 RVA: 0x00024034 File Offset: 0x00022234
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06001107 RID: 4359 RVA: 0x00024048 File Offset: 0x00022248
		public bool Equals(CancellationTokenRegistration other)
		{
			/*
An exception occurred when decompiling this method (06001107)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Threading.CancellationTokenRegistration::Equals(System.Threading.CancellationTokenRegistration)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:valuetype System.Threading.SparselyPopulatedArrayAddInfo`1<class System.Threading.CancellationCallbackInfo>(var_0_06, ldfld:valuetype System.Threading.SparselyPopulatedArrayAddInfo`1<class System.Threading.CancellationCallbackInfo>(CancellationTokenRegistration::m_registrationInfo, ldloc:valuetype System.Threading.CancellationTokenRegistration&(this)))
	stloc:valuetype System.Threading.SparselyPopulatedArrayAddInfo`1<class System.Threading.CancellationCallbackInfo>(var_1_0D, ldfld:valuetype System.Threading.SparselyPopulatedArrayAddInfo`1<class System.Threading.CancellationCallbackInfo>(CancellationTokenRegistration::m_registrationInfo, ldloc:CancellationTokenRegistration[exp:valuetype System.Threading.CancellationTokenRegistration&](other)))
	stloc:int32(var_3_1B, ldfld:int32(SparselyPopulatedArrayAddInfo`1::_index, ldfld:valuetype System.Threading.SparselyPopulatedArrayAddInfo`1<class System.Threading.CancellationCallbackInfo>[exp:valuetype System.Threading.SparselyPopulatedArrayAddInfo`1&](CancellationTokenRegistration::m_registrationInfo, ldloc:valuetype System.Threading.CancellationTokenRegistration&(this))))
	stloc:int32(var_4_27, ldfld:int32(SparselyPopulatedArrayAddInfo`1::_index, ldfld:valuetype System.Threading.SparselyPopulatedArrayAddInfo`1<class System.Threading.CancellationCallbackInfo>[exp:valuetype System.Threading.SparselyPopulatedArrayAddInfo`1&](CancellationTokenRegistration::m_registrationInfo, ldloc:CancellationTokenRegistration[exp:valuetype System.Threading.CancellationTokenRegistration&](other))))
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

		// Token: 0x06001108 RID: 4360 RVA: 0x00024080 File Offset: 0x00022280
		public override int GetHashCode()
		{
			int num;
			if (this.m_registrationInfo != null)
			{
				int index = this.m_registrationInfo._index;
				return num;
			}
			int index2 = this.m_registrationInfo._index;
			return num.GetHashCode();
		}

		// Token: 0x04000929 RID: 2345
		private readonly CancellationCallbackInfo m_callbackInfo;

		// Token: 0x0400092A RID: 2346
		private readonly SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> m_registrationInfo;
	}
}
