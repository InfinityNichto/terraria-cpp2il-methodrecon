using System;
using System.Collections.Generic;
using System.Threading;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000055 RID: 85
	[Preserve]
	internal class ThreadSafeStore<TKey, TValue>
	{
		// Token: 0x06000310 RID: 784 RVA: 0x000092D4 File Offset: 0x000074D4
		[Preserve]
		public ThreadSafeStore(Func<TKey, TValue> creator)
		{
			do
			{
				base..ctor();
			}
			while (creator == null);
			this._creator = creator;
			this._store = 1;
		}

		// Token: 0x06000311 RID: 785 RVA: 0x000092F8 File Offset: 0x000074F8
		[Preserve]
		public TValue Get(TKey key)
		{
			/*
An exception occurred when decompiling this method (06000311)

ICSharpCode.Decompiler.DecompilerException: Error decompiling TValue Newtonsoft.Json.Utilities.ThreadSafeStore`2::Get(TKey)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Dictionary`2(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<!TKey, !TValue>[exp:Dictionary`2](ThreadSafeStore`2::_store, ldloc:ThreadSafeStore`2(this)))
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

		// Token: 0x06000312 RID: 786 RVA: 0x0000930C File Offset: 0x0000750C
		[Preserve]
		private TValue AddValue(TKey key)
		{
			Func creator = this._creator;
			object @lock = this._lock;
			Monitor.Enter(@lock);
			Dictionary store = this._store;
			if (store != null)
			{
			}
			this._store = store;
			Dictionary store2 = this._store;
			this._store = store;
			Monitor.Exit(@lock);
			Monitor.Exit(@lock);
			throw new OutOfMemoryException();
		}

		// Token: 0x04000194 RID: 404
		private readonly object _lock;

		// Token: 0x04000195 RID: 405
		private Dictionary<TKey, TValue> _store;

		// Token: 0x04000196 RID: 406
		private readonly Func<TKey, TValue> _creator;
	}
}
