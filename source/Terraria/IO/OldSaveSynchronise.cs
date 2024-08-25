using System;
using Terraria.Utilities;

namespace Terraria.IO
{
	// Token: 0x02000570 RID: 1392
	public class OldSaveSynchronise
	{
		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x060033D5 RID: 13269 RVA: 0x00200990 File Offset: 0x001FEB90
		private static string OldSaveRoot
		{
			get
			{
				/*
An exception occurred when decompiling this method (060033D5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Terraria.IO.OldSaveSynchronise::get_OldSaveRoot()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:RuntimePlatform(var_2_07, callgetter:RuntimePlatform(Application::get_platform))
	stloc:RuntimePlatform(var_4_0F, callgetter:RuntimePlatform(Application::get_platform))
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

		// Token: 0x060033D6 RID: 13270 RVA: 0x002009B0 File Offset: 0x001FEBB0
		public static void CopyOldSaves()
		{
			int num = 1;
			if (num == 0)
			{
			}
			string text = Main.SavePath + "/oldSavesExposed.dat";
			bool flag = string.IsNullOrEmpty(OldSaveSynchronise.OldSaveRoot);
			if (num == 0)
			{
			}
			long num2 = 0L;
			bool flag2 = FileUtilities.Exists(text, num2 != 0L);
		}

		// Token: 0x060033D7 RID: 13271 RVA: 0x00200C60 File Offset: 0x001FEE60
		public OldSaveSynchronise()
		{
		}

		// Token: 0x04003E1A RID: 15898
		private static string _oldSaveRoot;
	}
}
