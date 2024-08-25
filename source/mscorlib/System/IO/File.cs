using System;
using Cpp2IlInjected;

namespace System.IO
{
	// Token: 0x0200054D RID: 1357
	public static class File
	{
		// Token: 0x06002859 RID: 10329 RVA: 0x00057918 File Offset: 0x00055B18
		public static StreamReader OpenText(string path)
		{
			/*
An exception occurred when decompiling this method (06002859)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IO.StreamReader System.IO.File::OpenText(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Encoding(var_1_07, callgetter:Encoding(Encoding::get_UTF8))
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

		// Token: 0x0600285A RID: 10330 RVA: 0x0005792C File Offset: 0x00055B2C
		public static void Copy(string sourceFileName, string destFileName)
		{
			long num = 0L;
			File.Copy(sourceFileName, destFileName, num != 0L);
		}

		// Token: 0x0600285B RID: 10331 RVA: 0x00057944 File Offset: 0x00055B44
		public static void Copy(string sourceFileName, string destFileName, bool overwrite)
		{
			while (sourceFileName != null)
			{
				if (destFileName == null)
				{
					return;
				}
				if (sourceFileName._stringLength == 0)
				{
					return;
				}
				if (destFileName._stringLength != 0)
				{
					string fullPath = Path.GetFullPath(sourceFileName);
					string fullPath2 = Path.GetFullPath(destFileName);
					FileSystem.CopyFile(fullPath, fullPath2, overwrite);
					return;
				}
			}
		}

		// Token: 0x0600285C RID: 10332 RVA: 0x00057980 File Offset: 0x00055B80
		public static FileStream Create(string path)
		{
			FileStream fileStream;
			return fileStream;
		}

		// Token: 0x0600285D RID: 10333 RVA: 0x0000207A File Offset: 0x0000027A
		public static FileStream Create(string path, int bufferSize)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600285E RID: 10334 RVA: 0x00057990 File Offset: 0x00055B90
		public static void Delete(string path)
		{
			while (path == null)
			{
			}
			FileSystem.DeleteFile(Path.GetFullPath(path));
		}

		// Token: 0x0600285F RID: 10335 RVA: 0x000579AC File Offset: 0x00055BAC
		public static bool Exists(string path)
		{
			string text;
			if (true)
			{
				long num = 0L;
				int stringLength = text._stringLength;
				char c = text[(int)num];
			}
			char rawStringData = text.GetRawStringData();
			int stringLength2 = text._stringLength;
			bool flag;
			return flag;
		}

		// Token: 0x06002860 RID: 10336 RVA: 0x000579F4 File Offset: 0x00055BF4
		public static FileStream Open(string path, FileMode mode)
		{
			FileStream fileStream;
			return fileStream;
		}

		// Token: 0x06002861 RID: 10337 RVA: 0x0000207A File Offset: 0x0000027A
		public static FileStream Open(string path, FileMode mode, FileAccess access, FileShare share)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002862 RID: 10338 RVA: 0x00057A04 File Offset: 0x00055C04
		public static DateTime GetCreationTime(string path)
		{
			if (!true)
			{
			}
			DateTime localDateTime = FileSystem.GetCreationTime(Path.GetFullPath(path)).LocalDateTime;
			return 1;
		}

		// Token: 0x06002863 RID: 10339 RVA: 0x00057A28 File Offset: 0x00055C28
		public static DateTime GetLastAccessTime(string path)
		{
			if (!true)
			{
			}
			DateTime localDateTime = FileSystem.GetLastAccessTime(Path.GetFullPath(path)).LocalDateTime;
			return 1;
		}

		// Token: 0x06002864 RID: 10340 RVA: 0x00057A4C File Offset: 0x00055C4C
		public static DateTime GetLastWriteTime(string path)
		{
			if (!true)
			{
			}
			DateTime localDateTime = FileSystem.GetLastWriteTime(Path.GetFullPath(path)).LocalDateTime;
			return 1;
		}

		// Token: 0x06002865 RID: 10341 RVA: 0x00057A70 File Offset: 0x00055C70
		public static void SetAttributes(string path, FileAttributes fileAttributes)
		{
			if (true)
			{
				FileSystem.SetAttributes(Path.GetFullPath(path), fileAttributes);
				return;
			}
			Path.Validate(path);
			if (!true)
			{
			}
		}

		// Token: 0x06002866 RID: 10342 RVA: 0x0000207A File Offset: 0x0000027A
		public static FileStream OpenRead(string path)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002867 RID: 10343 RVA: 0x00057A98 File Offset: 0x00055C98
		public static byte[] ReadAllBytes(string path)
		{
			if (!false)
			{
				byte[] array;
				return array;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06002868 RID: 10344 RVA: 0x00057ACC File Offset: 0x00055CCC
		private static byte[] ReadAllBytesUnknownLength(FileStream fs)
		{
			/*
An exception occurred when decompiling this method (06002868)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] System.IO.File::ReadAllBytesUnknownLength(System.IO.FileStream)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0032:
	call:void(ThrowHelper::ThrowArgumentOutOfRangeException)
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

		// Token: 0x06002869 RID: 10345 RVA: 0x00057B14 File Offset: 0x00055D14
		public static void WriteAllBytes(string path, byte[] bytes)
		{
			while (path != null)
			{
				if (path._stringLength == 0)
				{
					return;
				}
				if (bytes != null)
				{
					File.InternalWriteAllBytes(path, bytes);
					return;
				}
			}
		}

		// Token: 0x0600286A RID: 10346 RVA: 0x00057B38 File Offset: 0x00055D38
		private static void InternalWriteAllBytes(string path, byte[] bytes)
		{
		}

		// Token: 0x0600286B RID: 10347 RVA: 0x00057B60 File Offset: 0x00055D60
		public static void Move(string sourceFileName, string destFileName)
		{
			while (sourceFileName != null)
			{
				if (destFileName == null)
				{
					return;
				}
				if (sourceFileName._stringLength == 0)
				{
					return;
				}
				if (destFileName._stringLength != 0)
				{
					string fullPath = Path.GetFullPath(sourceFileName);
					string fullPath2 = Path.GetFullPath(destFileName);
					if (fullPath != null)
					{
						char rawStringData = fullPath.GetRawStringData();
						int stringLength = fullPath._stringLength;
						return;
					}
					FileSystem.MoveFile(fullPath, fullPath2);
					return;
				}
			}
		}
	}
}
