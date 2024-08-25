using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace Ionic.Zip
{
	// Token: 0x0200002E RID: 46
	internal static class ZipOutput
	{
		// Token: 0x06000222 RID: 546 RVA: 0x00007F50 File Offset: 0x00006150
		public static bool WriteCentralDirectoryStructure(Stream s, ICollection<ZipEntry> entries, uint numSegments, Zip64Option zip64, string comment, ZipContainer container)
		{
			long num = 0L;
			int num2 = 5;
			if (s != null)
			{
			}
			if (num == 0L)
			{
				return num2 == 0 && false;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00008098 File Offset: 0x00006298
		private static Encoding GetEncoding(ZipContainer container, string t)
		{
			while (container == null)
			{
			}
			Encoding encoding;
			CodePageDataItem dataItem = encoding.dataItem;
			Encoding encoding2;
			return encoding2;
		}

		// Token: 0x06000224 RID: 548 RVA: 0x000080B8 File Offset: 0x000062B8
		private static byte[] GenCentralDirectoryFooter(long StartOfCentralDirectory, long EndOfCentralDirectory, Zip64Option zip64, int entryCount, string comment, ZipContainer container)
		{
			int num = 1;
			if (entryCount != 0 && num != 0)
			{
				Encoding encoding;
				CodePageDataItem dataItem = encoding.dataItem;
			}
			return BitConverter.GetBytes(19280U);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x000080F8 File Offset: 0x000062F8
		private static byte[] GenZip64EndOfCentralDirectory(long StartOfCentralDirectory, long EndOfCentralDirectory, int entryCount, uint numSegments)
		{
			/*
An exception occurred when decompiling this method (06000225)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] Ionic.Zip.ZipOutput::GenZip64EndOfCentralDirectory(System.Int64,System.Int64,System.Int32,System.UInt32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_003B:
	stloc:uint8[](var_9_46, call:uint8[](BitConverter::GetBytes, conv.u4:uint32(ldc.i4:int32[exp:uint32](-2147483648))))
	stloc:uint8[](var_10_4E, call:uint8[](BitConverter::GetBytes, ldloc:int64(StartOfCentralDirectory)))
	stloc:uint8[](var_11_56, call:uint8[](BitConverter::GetBytes, ldloc:int32[exp:uint32](entryCount)))
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

		// Token: 0x06000226 RID: 550 RVA: 0x0000815C File Offset: 0x0000635C
		private static int CountEntries(ICollection<ZipEntry> _entries)
		{
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}
	}
}
