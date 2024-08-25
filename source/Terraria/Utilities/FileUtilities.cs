using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using Cpp2IlInjected;

namespace Terraria.Utilities
{
	// Token: 0x020004F9 RID: 1273
	public static class FileUtilities
	{
		// Token: 0x060030CF RID: 12495 RVA: 0x001F6FAC File Offset: 0x001F51AC
		public static string WildcardToRegex(string pattern)
		{
			if (!true)
			{
			}
			string text2;
			string text = text2.Replace("\\*", ".*").Replace("\\?", ".");
			return "^" + text + "$";
		}

		// Token: 0x060030D0 RID: 12496 RVA: 0x001F6FEC File Offset: 0x001F51EC
		public static string CleanSwitchPath(string path)
		{
			string text;
			return text.Replace("//", "/").Replace("/", "//");
		}

		// Token: 0x060030D1 RID: 12497 RVA: 0x001F7018 File Offset: 0x001F5218
		public static string[] GetFiles(string path, string searchPattern)
		{
			string[] array;
			return array;
		}

		// Token: 0x060030D2 RID: 12498 RVA: 0x001F7028 File Offset: 0x001F5228
		public static void SetAttributes(string path, FileAttributes fileAttributes)
		{
			FileManager.SetAttributes(path, fileAttributes);
		}

		// Token: 0x060030D3 RID: 12499 RVA: 0x001F703C File Offset: 0x001F523C
		public static void CreateDirectory(string path)
		{
			FileManager.CreateDirectory(path);
		}

		// Token: 0x060030D4 RID: 12500 RVA: 0x001F7050 File Offset: 0x001F5250
		public static bool Exists(string path, bool cloud = false)
		{
			bool flag;
			return flag;
		}

		// Token: 0x060030D5 RID: 12501 RVA: 0x001F7060 File Offset: 0x001F5260
		public static void Delete(string path, bool cloud = false)
		{
			if (path != null)
			{
				return;
			}
		}

		// Token: 0x060030D6 RID: 12502 RVA: 0x000021DB File Offset: 0x000003DB
		public static string GetFullPath(string path, bool cloud)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060030D7 RID: 12503 RVA: 0x001F7078 File Offset: 0x001F5278
		public static void Copy(string source, string destination, bool cloud = false, bool overwrite = true)
		{
			if (cloud)
			{
				return;
			}
		}

		// Token: 0x060030D8 RID: 12504 RVA: 0x001F70A8 File Offset: 0x001F52A8
		public static void Move(string source, string destination, bool cloud, bool overwrite = true)
		{
			if (!true)
			{
			}
			FileUtilities.Copy(source, destination, cloud, overwrite);
			FileUtilities.Delete(source, cloud);
		}

		// Token: 0x060030D9 RID: 12505 RVA: 0x001F70C8 File Offset: 0x001F52C8
		public static void WriteAllText(string path, string data)
		{
			Encoding ascii = Encoding.ASCII;
		}

		// Token: 0x060030DA RID: 12506 RVA: 0x001F70E0 File Offset: 0x001F52E0
		public static string ReadAllText(string path)
		{
			/*
An exception occurred when decompiling this method (060030DA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Terraria.Utilities.FileUtilities::ReadAllText(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Encoding(var_1_07, callgetter:Encoding(Encoding::get_Default))
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

		// Token: 0x060030DB RID: 12507 RVA: 0x001F70F4 File Offset: 0x001F52F4
		public static byte[] ReadAllBytes(string path, bool cloud = false)
		{
			byte[] array;
			return array;
		}

		// Token: 0x060030DC RID: 12508 RVA: 0x001F7108 File Offset: 0x001F5308
		public static void WriteAllBytes(string path, byte[] data, bool cloud = false)
		{
			if (!true)
			{
			}
		}

		// Token: 0x060030DD RID: 12509 RVA: 0x001F7118 File Offset: 0x001F5318
		public static void Write(string path, byte[] data, int length, bool cloud)
		{
			if ("" != null)
			{
				return;
			}
		}

		// Token: 0x060030DE RID: 12510 RVA: 0x001F7170 File Offset: 0x001F5370
		public static bool MoveToCloud(string localPath, string cloudPath)
		{
			byte[] array;
			FileUtilities.WriteAllBytes(localPath, array, true);
			return true;
		}

		// Token: 0x060030DF RID: 12511 RVA: 0x001F7188 File Offset: 0x001F5388
		public static bool MoveToLocal(string cloudPath, string localPath)
		{
			/*
An exception occurred when decompiling this method (060030DF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Utilities.FileUtilities::MoveToLocal(System.String,System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int64(var_1_01, ldc.i4:int64(0))
	call:void(FileUtilities::WriteAllBytes, ldloc:string(cloudPath), ldloc:uint8[](var_0), ldloc:int64[exp:bool](var_1_01))
	call:void(FileUtilities::Delete, ldloc:string(cloudPath), ldc.i4:bool(1))
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

		// Token: 0x060030E0 RID: 12512 RVA: 0x001F71A8 File Offset: 0x001F53A8
		public static string GetFileName(string path, bool includeExtension = true)
		{
			if (!true)
			{
			}
			Match match;
			Group group;
			if (match == null || group == null)
			{
				return "";
			}
			Group group2;
			string value = group2.Value;
			Group group3;
			if (group3 != null)
			{
				Group group4;
				return group4.Value;
			}
			return value + "";
		}

		// Token: 0x060030E1 RID: 12513 RVA: 0x001F71E4 File Offset: 0x001F53E4
		public static string GetParentFolderPath(string path, bool includeExtension = true)
		{
			if (!true)
			{
			}
			Match match;
			Group group;
			if (match != null && group != null)
			{
				Group group2;
				return group2.Value;
			}
			return "";
		}

		// Token: 0x060030E2 RID: 12514 RVA: 0x001F7208 File Offset: 0x001F5408
		// Note: this type is marked as 'beforefieldinit'.
		static FileUtilities()
		{
		}

		// Token: 0x04003ACC RID: 15052
		private static Regex FileNameRegex;
	}
}
