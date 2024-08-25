using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.Testing.ChatCommands
{
	// Token: 0x0200050B RID: 1291
	public static class ArgumentHelper
	{
		// Token: 0x06003137 RID: 12599 RVA: 0x000021DB File Offset: 0x000003DB
		public static ArgumentListResult ParseList(string arguments)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0200050C RID: 1292
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003138 RID: 12600 RVA: 0x001F7BF4 File Offset: 0x001F5DF4
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06003139 RID: 12601 RVA: 0x001F7C04 File Offset: 0x001F5E04
			public <>c()
			{
			}

			// Token: 0x0600313A RID: 12602 RVA: 0x001F7C18 File Offset: 0x001F5E18
			internal string <ParseList>b__0_0(string arg)
			{
				return arg.Trim();
			}

			// Token: 0x0600313B RID: 12603 RVA: 0x001F7C2C File Offset: 0x001F5E2C
			internal bool <ParseList>b__0_1(string arg)
			{
				/*
An exception occurred when decompiling this method (0600313B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Testing.ChatCommands.ArgumentHelper/<>c::<ParseList>b__0_1(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(string::_stringLength, ldloc:string(arg)))
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

			// Token: 0x04003AFD RID: 15101
			public static readonly ArgumentHelper.<>c <>9;

			// Token: 0x04003AFE RID: 15102
			public static Func<string, string> <>9__0_0;

			// Token: 0x04003AFF RID: 15103
			public static Func<string, bool> <>9__0_1;
		}
	}
}
