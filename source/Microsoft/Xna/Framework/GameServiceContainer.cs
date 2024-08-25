using System;
using System.Collections.Generic;

namespace Microsoft.Xna.Framework
{
	// Token: 0x02000334 RID: 820
	public class GameServiceContainer : IServiceProvider
	{
		// Token: 0x06001492 RID: 5266 RVA: 0x0005F0D8 File Offset: 0x0005D2D8
		public GameServiceContainer()
		{
		}

		// Token: 0x06001493 RID: 5267 RVA: 0x0005F0EC File Offset: 0x0005D2EC
		public void AddService(Type type, object provider)
		{
			Dictionary<Type, object> dictionary = this.services;
		}

		// Token: 0x06001494 RID: 5268 RVA: 0x0005F100 File Offset: 0x0005D300
		public object GetService(Type type)
		{
			/*
An exception occurred when decompiling this method (06001494)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object Microsoft.Xna.Framework.GameServiceContainer::GetService(System.Type)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<class [mscorlib]System.Type, object>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<class [mscorlib]System.Type, object>(GameServiceContainer::services, ldloc:GameServiceContainer(this)))
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

		// Token: 0x06001495 RID: 5269 RVA: 0x0005F114 File Offset: 0x0005D314
		public void RemoveService(Type type)
		{
			Dictionary<Type, object> dictionary = this.services;
		}

		// Token: 0x040022AD RID: 8877
		private Dictionary<Type, object> services;
	}
}
