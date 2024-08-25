using System;
using System.Runtime.InteropServices;

namespace System.IO
{
	// Token: 0x02000550 RID: 1360
	internal static class FileSystem
	{
		// Token: 0x06002880 RID: 10368 RVA: 0x00057E84 File Offset: 0x00056084
		private static bool CopyDanglingSymlink(string sourceFullPath, string destFullPath)
		{
			/*
An exception occurred when decompiling this method (06002880)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.IO.FileSystem::CopyDanglingSymlink(System.String,System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0029:
	stloc:ErrorInfo(var_7_31, call:ErrorInfo(Sys::GetLastErrorInfo))
	stloc:int64(var_8_34, ldc.i4:int64(0))
	stloc:Exception(var_9_40, call:Exception(Interop::GetExceptionForIoErrno, ldloc:ErrorInfo(var_7_31), ldloc:string(sourceFullPath), ldloc:int64[exp:bool](var_8_34)))
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

		// Token: 0x06002881 RID: 10369 RVA: 0x00057ED4 File Offset: 0x000560D4
		public static void CopyFile(string sourceFullPath, string destFullPath, bool overwrite)
		{
			if (destFullPath != null)
			{
				char rawStringData = destFullPath.GetRawStringData();
				int stringLength = destFullPath._stringLength;
				return;
			}
			string fileName = Path.GetFileName(sourceFullPath);
			string text = Path.Combine(destFullPath, fileName);
			bool flag = FileSystem.CopyDanglingSymlink(sourceFullPath, text);
		}

		// Token: 0x06002882 RID: 10370 RVA: 0x00057F74 File Offset: 0x00056174
		private static void LinkOrCopyFile(string sourceFullPath, string destFullPath)
		{
			int num = 1;
			bool flag = FileSystem.CopyDanglingSymlink(sourceFullPath, destFullPath);
			if (num == 0)
			{
			}
			int num2 = Interop.Sys.Link(sourceFullPath, destFullPath);
		}

		// Token: 0x06002883 RID: 10371 RVA: 0x00057FD0 File Offset: 0x000561D0
		public static void MoveFile(string sourceFullPath, string destFullPath)
		{
			if (!true)
			{
			}
			int num;
			if (num == 0)
			{
				if (!true)
				{
				}
				int num2;
				if (num2 != 0)
				{
					if (!true)
					{
					}
					if (Interop.Sys.Rename(sourceFullPath, destFullPath) == 0)
					{
						return;
					}
				}
			}
			FileSystem.LinkOrCopyFile(sourceFullPath, destFullPath);
			FileSystem.DeleteFile(sourceFullPath);
		}

		// Token: 0x06002884 RID: 10372 RVA: 0x00058004 File Offset: 0x00056204
		public static void DeleteFile(string fullPath)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = Interop.Sys.Unlink(fullPath);
			if (num == 0)
			{
			}
			Interop.ErrorInfo lastErrorInfo = Interop.Sys.GetLastErrorInfo();
			string text = PathInternal.TrimEndingDirectorySeparator(fullPath);
			if (lastErrorInfo != null)
			{
				return;
			}
		}

		// Token: 0x06002885 RID: 10373 RVA: 0x00058064 File Offset: 0x00056264
		public static void CreateDirectory(string fullPath)
		{
			int stringLength = fullPath._stringLength;
			char rawStringData = fullPath.GetRawStringData();
			int stringLength2 = fullPath._stringLength;
			int num = 1;
			char c = fullPath[num];
			int num2 = 2;
			char rawStringData2 = fullPath.GetRawStringData();
			int stringLength3 = fullPath._stringLength;
			char rawStringData3 = fullPath.GetRawStringData();
			int stringLength4 = fullPath._stringLength;
			long num3 = 0L;
			string text = fullPath.Substring((int)num3, num2);
			if (text != null)
			{
				char rawStringData4 = text.GetRawStringData();
				int stringLength5 = text._stringLength;
				return;
			}
		}

		// Token: 0x06002886 RID: 10374 RVA: 0x00058158 File Offset: 0x00056358
		public static bool DirectoryExists(ReadOnlySpan<char> fullPath)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06002887 RID: 10375 RVA: 0x00058168 File Offset: 0x00056368
		private static bool DirectoryExists(ReadOnlySpan<char> fullPath, [Out] Interop.ErrorInfo errorInfo)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06002888 RID: 10376 RVA: 0x00058178 File Offset: 0x00056378
		public static bool FileExists(ReadOnlySpan<char> fullPath)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06002889 RID: 10377 RVA: 0x0005818C File Offset: 0x0005638C
		private static bool FileExists(ReadOnlySpan<char> fullPath, int fileType, [Out] Interop.ErrorInfo errorInfo)
		{
			/*
An exception occurred when decompiling this method (06002889)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.IO.FileSystem::FileExists(System.ReadOnlySpan`1<System.Char>,System.Int32,Interop/ErrorInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0009:
	stloc:ErrorInfo(var_3_10, call:ErrorInfo(Sys::GetLastErrorInfo))
	stfld:Error(ErrorInfo::_error, ldloc:ErrorInfo[exp:valuetype Interop/ErrorInfo&](errorInfo), ldloc:ErrorInfo[exp:Error](var_3_10))
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

		// Token: 0x0600288A RID: 10378 RVA: 0x000581B4 File Offset: 0x000563B4
		public static void SetAttributes(string fullPath, FileAttributes attributes)
		{
		}

		// Token: 0x0600288B RID: 10379 RVA: 0x000581C4 File Offset: 0x000563C4
		public static DateTimeOffset GetCreationTime(string fullPath)
		{
			/*
An exception occurred when decompiling this method (0600288B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.DateTimeOffset System.IO.FileSystem::GetCreationTime(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:DateTimeOffset(var_1_06, call:DateTimeOffset(DateTimeOffset::op_Implicit, ldloc:DateTime(var_0)))
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

		// Token: 0x0600288C RID: 10380 RVA: 0x000581D8 File Offset: 0x000563D8
		public static DateTimeOffset GetLastAccessTime(string fullPath)
		{
			/*
An exception occurred when decompiling this method (0600288C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.DateTimeOffset System.IO.FileSystem::GetLastAccessTime(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:DateTimeOffset(var_1_06, call:DateTimeOffset(DateTimeOffset::op_Implicit, ldloc:DateTime(var_0)))
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

		// Token: 0x0600288D RID: 10381 RVA: 0x000581EC File Offset: 0x000563EC
		public static DateTimeOffset GetLastWriteTime(string fullPath)
		{
			/*
An exception occurred when decompiling this method (0600288D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.DateTimeOffset System.IO.FileSystem::GetLastWriteTime(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:DateTimeOffset(var_1_06, call:DateTimeOffset(DateTimeOffset::op_Implicit, ldloc:DateTime(var_0)))
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
}
