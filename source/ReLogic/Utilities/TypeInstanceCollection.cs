using System;
using System.Collections.Generic;

namespace ReLogic.Utilities
{
	// Token: 0x02000B0C RID: 2828
	internal class TypeInstanceCollection<BaseType> : IDisposable where BaseType : class
	{
		// Token: 0x060052B0 RID: 21168 RVA: 0x00283524 File Offset: 0x00281724
		public void Register<T>(T instance) where T : BaseType
		{
			Dictionary services = this._services;
			if (instance != null && instance == null)
			{
				throw new InvalidCastException();
			}
		}

		// Token: 0x060052B1 RID: 21169 RVA: 0x00283544 File Offset: 0x00281744
		public T Get<T>() where T : BaseType
		{
			Dictionary services;
			do
			{
				services = this._services;
				if (services == null)
				{
					return;
				}
			}
			while (services != null);
			throw new InvalidCastException();
		}

		// Token: 0x060052B2 RID: 21170 RVA: 0x00283568 File Offset: 0x00281768
		public void Remove<T>() where T : BaseType
		{
			Dictionary services = this._services;
		}

		// Token: 0x060052B3 RID: 21171 RVA: 0x0028357C File Offset: 0x0028177C
		public bool Has<T>() where T : BaseType
		{
			/*
An exception occurred when decompiling this method (060052B3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean ReLogic.Utilities.TypeInstanceCollection`1::Has<T>()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Dictionary`2(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<class [mscorlib]System.Type, !BaseType>[exp:Dictionary`2](TypeInstanceCollection`1::_services, ldloc:TypeInstanceCollection`1(this)))
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

		// Token: 0x060052B4 RID: 21172 RVA: 0x00283590 File Offset: 0x00281790
		public bool Has(Type type)
		{
			/*
An exception occurred when decompiling this method (060052B4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean ReLogic.Utilities.TypeInstanceCollection`1::Has(System.Type)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Dictionary`2(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<class [mscorlib]System.Type, !BaseType>[exp:Dictionary`2](TypeInstanceCollection`1::_services, ldloc:TypeInstanceCollection`1(this)))
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

		// Token: 0x060052B5 RID: 21173 RVA: 0x002835A4 File Offset: 0x002817A4
		public void IfHas<T>(Action<T> callback) where T : BaseType
		{
			Dictionary services = this._services;
			if (services != null && services == null)
			{
				throw new InvalidCastException();
			}
		}

		// Token: 0x060052B6 RID: 21174 RVA: 0x002835C4 File Offset: 0x002817C4
		public U IfHas<U, T>(Func<T, U> callback) where T : BaseType
		{
			Dictionary services;
			do
			{
				services = this._services;
				Dictionary.Entry[] entries = services._entries;
			}
			while (services == null || services != null);
			throw new InvalidCastException();
		}

		// Token: 0x060052B7 RID: 21175 RVA: 0x002835EC File Offset: 0x002817EC
		protected virtual void Dispose(bool disposing)
		{
			while (!this._disposedValue)
			{
				if (this._services != null)
				{
					return;
				}
			}
		}

		// Token: 0x060052B8 RID: 21176 RVA: 0x0028363C File Offset: 0x0028183C
		public void Dispose()
		{
		}

		// Token: 0x060052B9 RID: 21177 RVA: 0x0028364C File Offset: 0x0028184C
		public TypeInstanceCollection()
		{
			this._services = this;
			base..ctor();
		}

		// Token: 0x04008ADE RID: 35550
		private Dictionary<Type, BaseType> _services;

		// Token: 0x04008ADF RID: 35551
		private bool _disposedValue;
	}
}
