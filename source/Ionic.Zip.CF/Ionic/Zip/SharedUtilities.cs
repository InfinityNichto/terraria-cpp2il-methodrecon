using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Cpp2IlInjected;

namespace Ionic.Zip
{
	// Token: 0x02000017 RID: 23
	internal static class SharedUtilities
	{
		// Token: 0x06000065 RID: 101 RVA: 0x00002800 File Offset: 0x00000A00
		public static long GetFileLength(string fileName)
		{
			long num = 0L;
			FileStream fileStream;
			if (fileStream != null)
			{
			}
			if (num == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002834 File Offset: 0x00000A34
		[Conditional("NETCF")]
		public static void Workaround_Ladybug318918(Stream s)
		{
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002844 File Offset: 0x00000A44
		private static string SimplifyFwdSlashPath(string path)
		{
			string text2;
			string text = text2.Replace("/./", "/");
			string text3;
			return text3;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002864 File Offset: 0x00000A64
		public static string NormalizePathForUseInZipFile(string pathName)
		{
			bool flag = string.IsNullOrEmpty("/");
			string text;
			bool flag2 = text.StartsWith("/");
			return text.Substring(1);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002122 File Offset: 0x00000322
		internal static byte[] StringToByteArray(string value, Encoding encoding)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000028A0 File Offset: 0x00000AA0
		internal static byte[] StringToByteArray(string value)
		{
			/*
An exception occurred when decompiling this method (0600006A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] Ionic.Zip.SharedUtilities::StringToByteArray(System.String)

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

		// Token: 0x0600006B RID: 107 RVA: 0x000028B0 File Offset: 0x00000AB0
		internal static string Utf8StringFromBuffer(byte[] buf)
		{
			/*
An exception occurred when decompiling this method (0600006B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Ionic.Zip.SharedUtilities::Utf8StringFromBuffer(System.Byte[])

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

		// Token: 0x0600006C RID: 108 RVA: 0x00002122 File Offset: 0x00000322
		internal static string StringFromBuffer(byte[] buf, Encoding encoding)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000028C0 File Offset: 0x00000AC0
		internal static int ReadSignature(Stream s)
		{
			if (!true)
			{
			}
			int num;
			return num;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000028D8 File Offset: 0x00000AD8
		internal static int ReadEntrySignature(Stream s)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int num2;
			return num2;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002924 File Offset: 0x00000B24
		internal static int ReadInt(Stream s)
		{
			if (!true)
			{
			}
			int num;
			return num;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002938 File Offset: 0x00000B38
		private static int _ReadFourBytes(Stream s, string message)
		{
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000294C File Offset: 0x00000B4C
		internal static long FindSignature(Stream stream, int SignatureToFind)
		{
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000295C File Offset: 0x00000B5C
		internal static DateTime AdjustTime_Reverse(DateTime time)
		{
			if (!true)
			{
			}
			bool flag = DateTime.Now.IsDaylightSavingTime();
			if (!true)
			{
			}
			bool flag2 = DateTime.Now.IsDaylightSavingTime();
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000029A0 File Offset: 0x00000BA0
		internal static DateTime PackedToDateTime(int packedDateTime)
		{
			int num = 65535;
			if (packedDateTime == 0)
			{
			}
			DateTime now = DateTime.Now;
			if (num == 0)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002A4C File Offset: 0x00000C4C
		internal static int DateTimeToPacked(DateTime time)
		{
			DateTime dateTime;
			int day = dateTime.Day;
			int num;
			return num;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002A64 File Offset: 0x00000C64
		public static void CreateAndOpenUniqueTempFile(string dir, [Out] Stream fs, [Out] string filename)
		{
			int num = 1;
			if (num == 0)
			{
			}
			string text = SharedUtilities.InternalGetTempFileName();
			if (num == 0)
			{
			}
			string text2 = Path.Combine(dir, text);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002A94 File Offset: 0x00000C94
		public static string InternalGetTempFileName()
		{
			if (!true)
			{
			}
			long num = 0L;
			string text = SharedUtilities.GenerateRandomStringImpl(8, (int)num);
			return "DotNetZip-" + text + ".tmp";
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002AC0 File Offset: 0x00000CC0
		internal static string GenerateRandomStringImpl(int length, int delta)
		{
			if (length == 0)
			{
			}
			string text;
			return text;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002AD8 File Offset: 0x00000CD8
		internal static int ReadWithRetry(Stream s, byte[] buffer, int offset, int count, string FileName)
		{
			throw new OutOfMemoryException();
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002AEC File Offset: 0x00000CEC
		private static uint _HRForException(Exception ex1)
		{
			/*
An exception occurred when decompiling this method (06000079)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.UInt32 Ionic.Zip.SharedUtilities::_HRForException(System.Exception)

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

		// Token: 0x0600007A RID: 122 RVA: 0x00002AFC File Offset: 0x00000CFC
		// Note: this type is marked as 'beforefieldinit'.
		static SharedUtilities()
		{
			Encoding encoding = Encoding.GetEncoding("IBM437");
			Encoding encoding2 = Encoding.GetEncoding("UTF-8");
		}

		// Token: 0x04000030 RID: 48
		private static Regex doubleDotRegex1;

		// Token: 0x04000031 RID: 49
		private static Encoding ibm437;

		// Token: 0x04000032 RID: 50
		private static Encoding utf8;
	}
}
