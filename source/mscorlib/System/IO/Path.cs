using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Cpp2IlInjected;

namespace System.IO
{
	// Token: 0x0200056D RID: 1389
	[ComVisible(true)]
	public static class Path
	{
		// Token: 0x060029C7 RID: 10695 RVA: 0x0005AAC8 File Offset: 0x00058CC8
		public static string ChangeExtension(string path, string extension)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (path != null && path._stringLength != 0)
			{
				long num2 = 0L;
				char c = path[(int)num2];
				string text = "." + path;
				int num3;
				if (num3 != 0)
				{
					long num4 = 0L;
					return text.Substring((int)num4, num3);
				}
			}
			string text2;
			return text2;
		}

		// Token: 0x060029C8 RID: 10696 RVA: 0x0005AB2C File Offset: 0x00058D2C
		public static string Combine(string path1, string path2)
		{
			int num;
			do
			{
				num = 1;
			}
			while (path1 == null);
			if (num != 0)
			{
				int stringLength = path1._stringLength;
				if (stringLength != 0)
				{
					if (stringLength == 0)
					{
					}
					if (stringLength == 0)
					{
					}
					if (stringLength == 0)
					{
					}
					bool flag = Path.IsPathRooted(path1);
					string text;
					return text;
				}
			}
			return path1;
		}

		// Token: 0x060029C9 RID: 10697 RVA: 0x0005AB6C File Offset: 0x00058D6C
		internal static string CleanPath(string s)
		{
			if (!true)
			{
			}
			long num = 0L;
			if (num != 0L)
			{
			}
			string text;
			return text;
		}

		// Token: 0x060029CA RID: 10698 RVA: 0x0005AB98 File Offset: 0x00058D98
		public static string GetDirectoryName(string path)
		{
			string text;
			int stringLength = text._stringLength;
			if (stringLength != 0)
			{
				if (stringLength == 0)
				{
				}
				if (stringLength == 0)
				{
				}
				int num;
				if (num != 0)
				{
				}
				int num2 = 1;
				string text2;
				int stringLength2 = text2._stringLength;
				char c = text2[num2];
				string text3;
				return text2 + text3;
			}
			return "Argument string consists of whitespace characters only.";
		}

		// Token: 0x060029CB RID: 10699 RVA: 0x0005ABFC File Offset: 0x00058DFC
		public static ReadOnlySpan<char> GetDirectoryName(ReadOnlySpan<char> path)
		{
			string text;
			if (text != null)
			{
				char rawStringData = text.GetRawStringData();
				int stringLength = text._stringLength;
				while (text != null)
				{
				}
				return;
			}
		}

		// Token: 0x060029CC RID: 10700 RVA: 0x0005AC20 File Offset: 0x00058E20
		public static string GetExtension(string path)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			string text;
			return text;
		}

		// Token: 0x060029CD RID: 10701 RVA: 0x0005AC3C File Offset: 0x00058E3C
		public static string GetFileName(string path)
		{
			int num = 1;
			string text;
			if (num != 0)
			{
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				return text;
			}
			return text;
		}

		// Token: 0x060029CE RID: 10702 RVA: 0x0005AC58 File Offset: 0x00058E58
		public static string GetFileNameWithoutExtension(string path)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x060029CF RID: 10703 RVA: 0x0005AC6C File Offset: 0x00058E6C
		public static string GetFullPath(string path)
		{
			if (!true)
			{
			}
			SecurityManager.EnsureElevatedPermissions();
			string text;
			return text;
		}

		// Token: 0x060029D0 RID: 10704 RVA: 0x0005AC84 File Offset: 0x00058E84
		internal static string GetFullPathInternal(string path)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x060029D1 RID: 10705 RVA: 0x0005AC98 File Offset: 0x00058E98
		internal static string InsecureGetFullPath(string path)
		{
			/*
An exception occurred when decompiling this method (060029D1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.IO.Path::InsecureGetFullPath(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0151:
	stloc:string(var_56_15B, call:string(Locale::GetText, ldstr:string("The specified path is not of a legal form (empty).")))
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

		// Token: 0x060029D2 RID: 10706 RVA: 0x0005AE04 File Offset: 0x00059004
		internal static bool IsDirectorySeparator(char c)
		{
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x060029D3 RID: 10707 RVA: 0x0005AE18 File Offset: 0x00059018
		public static string GetPathRoot(string path)
		{
			int stringLength;
			do
			{
				string text;
				stringLength = text._stringLength;
			}
			while (stringLength == 0);
			if (stringLength == 0)
			{
			}
			if (stringLength == 0)
			{
			}
			char c;
			bool flag = Path.IsDirectorySeparator(c);
			char c2;
			bool flag2 = Path.IsDirectorySeparator(c2);
			char c3;
			bool flag3 = Path.IsDirectorySeparator(c3);
			char c4;
			bool flag4 = Path.IsDirectorySeparator(c4);
			char c5;
			bool flag5 = Path.IsDirectorySeparator(c5);
			return Directory.GetCurrentDirectory();
		}

		// Token: 0x060029D4 RID: 10708 RVA: 0x0005AEB8 File Offset: 0x000590B8
		public static string GetTempPath()
		{
			int num = 1;
			SecurityManager.EnsureElevatedPermissions();
			if (num == 0)
			{
			}
			string text;
			return text;
		}

		// Token: 0x060029D5 RID: 10709 RVA: 0x0000207A File Offset: 0x0000027A
		private static string get_temp_path()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060029D6 RID: 10710 RVA: 0x0005AED4 File Offset: 0x000590D4
		public static bool IsPathRooted(ReadOnlySpan<char> path)
		{
			/*
An exception occurred when decompiling this method (060029D6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.IO.Path::IsPathRooted(System.ReadOnlySpan`1<System.Char>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000C:
	brtrue(IL_0000, ldc.i4:bool(0))
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

		// Token: 0x060029D7 RID: 10711 RVA: 0x0005AEF0 File Offset: 0x000590F0
		public static bool IsPathRooted(string path)
		{
			if (true)
			{
				if (!true)
				{
				}
				bool flag;
				return flag;
			}
		}

		// Token: 0x060029D8 RID: 10712 RVA: 0x0005AF08 File Offset: 0x00059108
		public static char[] GetInvalidFileNameChars()
		{
			/*
An exception occurred when decompiling this method (060029D8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Char[] System.IO.Path::GetInvalidFileNameChars()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_1_07, callgetter:bool(Environment::get_IsRunningOnWindows))
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

		// Token: 0x060029D9 RID: 10713 RVA: 0x0005AF1C File Offset: 0x0005911C
		public static char[] GetInvalidPathChars()
		{
			/*
An exception occurred when decompiling this method (060029D9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Char[] System.IO.Path::GetInvalidPathChars()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_1_07, callgetter:bool(Environment::get_IsRunningOnWindows))
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

		// Token: 0x060029DA RID: 10714 RVA: 0x0005AF30 File Offset: 0x00059130
		private static int findExtension(string path)
		{
			int num;
			return num;
		}

		// Token: 0x060029DB RID: 10715 RVA: 0x0005AF40 File Offset: 0x00059140
		static Path()
		{
			string text = Path.GetInvalidPathChars().ToString();
		}

		// Token: 0x060029DC RID: 10716 RVA: 0x0005AF60 File Offset: 0x00059160
		private static string CanonicalizePath(string path)
		{
			bool isRunningOnWindows = Environment.IsRunningOnWindows;
			string text;
			int stringLength = text._stringLength;
			string pathRoot;
			if (stringLength != 0)
			{
				if (stringLength == 0)
				{
				}
				pathRoot = Path.GetPathRoot(text);
				bool isRunningOnWindows2 = Environment.IsRunningOnWindows;
				int stringLength2 = pathRoot._stringLength;
				long num = 0L;
				bool flag = Path.IsDirectorySeparator(pathRoot[(int)num]);
				int num2 = 1;
				bool flag2 = Path.IsDirectorySeparator(pathRoot[num2]);
				long num3 = 0L;
				bool isRunningOnWindows3 = Environment.IsRunningOnWindows;
				string text2;
				if (text2 == null || text2 != null)
				{
					bool flag3 = text2 == ".";
					if (num3 == 0L)
					{
						return text2;
					}
					if (text2 == null || text2 != null)
					{
						return text2;
					}
				}
				throw new ArrayTypeMismatchException();
			}
			return pathRoot;
		}

		// Token: 0x060029DD RID: 10717 RVA: 0x0005B064 File Offset: 0x00059264
		public static string Combine(params string[] paths)
		{
		}

		// Token: 0x060029DE RID: 10718 RVA: 0x0005B078 File Offset: 0x00059278
		public static string Combine(string path1, string path2, string path3)
		{
			while (path1 != null)
			{
				if (path2 != null)
				{
					if (path1 != null && path2 != null)
					{
						string text;
						return text;
					}
					throw new ArrayTypeMismatchException();
				}
			}
			return "path2";
		}

		// Token: 0x060029DF RID: 10719 RVA: 0x0005B0A4 File Offset: 0x000592A4
		internal static void Validate(string path)
		{
			if (!true)
			{
			}
			Path.Validate(path, "path");
		}

		// Token: 0x060029E0 RID: 10720 RVA: 0x0005B0C0 File Offset: 0x000592C0
		internal static void Validate(string path, string parameterName)
		{
			if (path != null)
			{
				bool flag = string.IsNullOrWhiteSpace(path);
				if (!true)
				{
				}
				return;
			}
		}

		// Token: 0x060029E1 RID: 10721 RVA: 0x0005B0E8 File Offset: 0x000592E8
		public static ReadOnlySpan<char> GetFileName(ReadOnlySpan<char> path)
		{
			/*
An exception occurred when decompiling this method (060029E1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.ReadOnlySpan`1<System.Char> System.IO.Path::GetFileName(System.ReadOnlySpan`1<System.Char>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0011:
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

		// Token: 0x060029E2 RID: 10722 RVA: 0x0005B110 File Offset: 0x00059310
		public static string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2)
		{
			if (path1 != null)
			{
				string text;
				return text;
			}
			string text2;
			return text2;
		}

		// Token: 0x060029E3 RID: 10723 RVA: 0x0005B128 File Offset: 0x00059328
		public static string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, ReadOnlySpan<char> path3)
		{
			if (path1 != null && path3 != null)
			{
				string text;
				return text;
			}
			string text2;
			return text2;
		}

		// Token: 0x060029E4 RID: 10724 RVA: 0x0005B140 File Offset: 0x00059340
		public static bool TryJoin(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, Span<char> destination, [Out] int charsWritten)
		{
			int num = 1;
			if (path1 != null)
			{
				if (destination != null)
				{
					if (num == 0)
					{
					}
					bool flag;
					return flag;
				}
			}
			else if (destination != null)
			{
			}
			int length = path1._length;
			if (path1._length == 0)
			{
			}
			return PathInternal.StartsWithDirectorySeparator(path2);
		}

		// Token: 0x060029E5 RID: 10725 RVA: 0x0005B194 File Offset: 0x00059394
		private static string JoinInternal(ReadOnlySpan<char> first, ReadOnlySpan<char> second)
		{
			/*
An exception occurred when decompiling this method (060029E5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.IO.Path::JoinInternal(System.ReadOnlySpan`1<System.Char>,System.ReadOnlySpan`1<System.Char>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000B:
	brtrue(IL_0000, ldloc:int64[exp:bool](var_0_01))
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

		// Token: 0x060029E6 RID: 10726 RVA: 0x0005B1B0 File Offset: 0x000593B0
		private static string JoinInternal(ReadOnlySpan<char> first, ReadOnlySpan<char> second, ReadOnlySpan<char> third)
		{
			/*
An exception occurred when decompiling this method (060029E6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.IO.Path::JoinInternal(System.ReadOnlySpan`1<System.Char>,System.ReadOnlySpan`1<System.Char>,System.ReadOnlySpan`1<System.Char>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000B:
	stloc:bool(var_5_12, call:bool(PathInternal::IsDirectorySeparator, ldloc:int32[exp:char](var_4_06)))
	brtrue(IL_0000, logicnot:bool(ldloc:valuetype System.ReadOnlySpan`1<char>[exp:bool](third)))
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

		// Token: 0x0400167A RID: 5754
		[Obsolete("see GetInvalidPathChars and GetInvalidFileNameChars methods.")]
		public static readonly char[] InvalidPathChars;

		// Token: 0x0400167B RID: 5755
		public static readonly char AltDirectorySeparatorChar;

		// Token: 0x0400167C RID: 5756
		public static readonly char DirectorySeparatorChar;

		// Token: 0x0400167D RID: 5757
		public static readonly char PathSeparator;

		// Token: 0x0400167E RID: 5758
		internal static readonly string DirectorySeparatorStr;

		// Token: 0x0400167F RID: 5759
		public static readonly char VolumeSeparatorChar;

		// Token: 0x04001680 RID: 5760
		internal static readonly char[] PathSeparatorChars;

		// Token: 0x04001681 RID: 5761
		private static readonly bool dirEqualsVolume;

		// Token: 0x04001682 RID: 5762
		internal static readonly char[] trimEndCharsWindows;

		// Token: 0x04001683 RID: 5763
		internal static readonly char[] trimEndCharsUnix;

		// Token: 0x0200056E RID: 1390
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060029E7 RID: 10727 RVA: 0x0005B1D4 File Offset: 0x000593D4
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060029E8 RID: 10728 RVA: 0x0005B1E4 File Offset: 0x000593E4
			public <>c()
			{
			}

			// Token: 0x060029E9 RID: 10729 RVA: 0x0005B1F8 File Offset: 0x000593F8
			internal unsafe void <JoinInternal>b__56_0(Span<char> destination, [TupleElementNames(new string[] { "First", "FirstLength", "Second", "SecondLength", "HasSeparator" })] ValueTuple<IntPtr, int, IntPtr, int, bool> state)
			{
				long num = 0L;
				ThrowHelper.ThrowArgumentOutOfRangeException();
				int num2 = 47;
				destination._pointer = num2;
				void* ptr = (void*)num;
				ThrowHelper.ThrowArgumentOutOfRangeException();
				ThrowHelper.ThrowArgumentOutOfRangeException();
			}

			// Token: 0x060029EA RID: 10730 RVA: 0x0005B230 File Offset: 0x00059430
			internal unsafe void <JoinInternal>b__57_0(Span<char> destination, [TupleElementNames(new string[] { "First", "FirstLength", "Second", "SecondLength", "Third", "ThirdLength", "FirstHasSeparator", "ThirdHasSeparator", null })] ValueTuple<IntPtr, int, IntPtr, int, IntPtr, int, bool, ValueTuple<bool>> state)
			{
				long num = 0L;
				ThrowHelper.ThrowArgumentOutOfRangeException();
				int num2 = 47;
				destination._pointer = num2;
				void* ptr = (void*)num;
				ThrowHelper.ThrowArgumentOutOfRangeException();
				long num3 = 0L;
				ThrowHelper.ThrowArgumentOutOfRangeException();
				void* ptr2 = (void*)num3;
				ThrowHelper.ThrowArgumentOutOfRangeException();
			}

			// Token: 0x04001684 RID: 5764
			public static readonly Path.<>c <>9;

			// Token: 0x04001685 RID: 5765
			[TupleElementNames(new string[] { "First", "FirstLength", "Second", "SecondLength", "HasSeparator" })]
			public static SpanAction<char, ValueTuple<IntPtr, int, IntPtr, int, bool>> <>9__56_0;

			// Token: 0x04001686 RID: 5766
			[TupleElementNames(new string[] { "First", "FirstLength", "Second", "SecondLength", "Third", "ThirdLength", "FirstHasSeparator", "ThirdHasSeparator", null })]
			public static SpanAction<char, ValueTuple<IntPtr, int, IntPtr, int, IntPtr, int, bool, ValueTuple<bool>>> <>9__57_0;
		}
	}
}
