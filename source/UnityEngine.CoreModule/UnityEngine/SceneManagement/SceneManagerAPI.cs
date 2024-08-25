using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.SceneManagement
{
	// Token: 0x02000126 RID: 294
	public class SceneManagerAPI
	{
		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060005E0 RID: 1504 RVA: 0x0000A770 File Offset: 0x00008970
		internal static SceneManagerAPI ActiveAPI
		{
			get
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
				if (true || !true)
				{
				}
				return 1;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x0000A78C File Offset: 0x0000898C
		public static SceneManagerAPI overrideAPI
		{
			[CompilerGenerated]
			get
			{
				/*
An exception occurred when decompiling this method (060005E1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.SceneManagement.SceneManagerAPI UnityEngine.SceneManagement.SceneManagerAPI::get_overrideAPI()

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
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x0000A79C File Offset: 0x0000899C
		protected internal SceneManagerAPI()
		{
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x0000A7B0 File Offset: 0x000089B0
		protected internal virtual AsyncOperation LoadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x0000A7C4 File Offset: 0x000089C4
		protected internal virtual AsyncOperation LoadFirstScene(bool mustLoadAsync)
		{
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x0000A7D4 File Offset: 0x000089D4
		// Note: this type is marked as 'beforefieldinit'.
		static SceneManagerAPI()
		{
		}

		// Token: 0x040004E7 RID: 1255
		private static SceneManagerAPI s_DefaultAPI;

		// Token: 0x040004E8 RID: 1256
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static SceneManagerAPI <overrideAPI>k__BackingField;
	}
}
