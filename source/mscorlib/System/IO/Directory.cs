using System;
using System.Collections.Generic;

namespace System.IO
{
	// Token: 0x0200054A RID: 1354
	public static class Directory
	{
		// Token: 0x06002837 RID: 10295 RVA: 0x00057594 File Offset: 0x00055794
		public static DirectoryInfo GetParent(string path)
		{
			/*
An exception occurred when decompiling this method (06002837)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IO.DirectoryInfo System.IO.Directory::GetParent(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	brtrue(IL_0000, logicnot:bool(call:string[exp:bool](Path::GetDirectoryName, ldloc:string(var_0))))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x06002838 RID: 10296 RVA: 0x000575AC File Offset: 0x000557AC
		public static DirectoryInfo CreateDirectory(string path)
		{
			/*
An exception occurred when decompiling this method (06002838)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IO.DirectoryInfo System.IO.Directory::CreateDirectory(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(FileSystem::CreateDirectory, ldloc:string(var_0))
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

		// Token: 0x06002839 RID: 10297 RVA: 0x000575C4 File Offset: 0x000557C4
		public static bool Exists(string path)
		{
			if (true)
			{
				string text;
				if (text != null)
				{
					char rawStringData = text.GetRawStringData();
					int stringLength = text._stringLength;
					while (text != null)
					{
					}
				}
				bool flag;
				return flag;
			}
		}

		// Token: 0x0600283A RID: 10298 RVA: 0x00057600 File Offset: 0x00055800
		public static string[] GetFiles(string path)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			string[] array;
			return array;
		}

		// Token: 0x0600283B RID: 10299 RVA: 0x00057614 File Offset: 0x00055814
		public static string[] GetFiles(string path, string searchPattern)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			string[] array;
			return array;
		}

		// Token: 0x0600283C RID: 10300 RVA: 0x00057628 File Offset: 0x00055828
		public static string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
		{
			if (!true)
			{
			}
			string[] array;
			return array;
		}

		// Token: 0x0600283D RID: 10301 RVA: 0x0005763C File Offset: 0x0005583C
		public static string[] GetFiles(string path, string searchPattern, EnumerationOptions enumerationOptions)
		{
			IEnumerable<string> enumerable;
			return enumerable.ToArray<string>();
		}

		// Token: 0x0600283E RID: 10302 RVA: 0x00057650 File Offset: 0x00055850
		public static string[] GetDirectories(string path)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			string[] array;
			return array;
		}

		// Token: 0x0600283F RID: 10303 RVA: 0x00057664 File Offset: 0x00055864
		public static string[] GetDirectories(string path, string searchPattern, EnumerationOptions enumerationOptions)
		{
			IEnumerable<string> enumerable;
			return enumerable.ToArray<string>();
		}

		// Token: 0x06002840 RID: 10304 RVA: 0x00057678 File Offset: 0x00055878
		internal static IEnumerable<string> InternalEnumeratePaths(string path, string searchPattern, SearchTarget searchTarget, EnumerationOptions options)
		{
			while (path == null)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			IEnumerable<string> enumerable;
			return enumerable;
		}

		// Token: 0x06002841 RID: 10305 RVA: 0x000576A0 File Offset: 0x000558A0
		internal static string InternalGetDirectoryRoot(string path)
		{
			string text;
			return text;
		}

		// Token: 0x06002842 RID: 10306 RVA: 0x000576B4 File Offset: 0x000558B4
		public static string GetCurrentDirectory()
		{
			return Environment.CurrentDirectory;
		}

		// Token: 0x06002843 RID: 10307 RVA: 0x000576C8 File Offset: 0x000558C8
		internal static string InsecureGetCurrentDirectory()
		{
			if (!true)
			{
			}
			string text;
			return text;
		}
	}
}
