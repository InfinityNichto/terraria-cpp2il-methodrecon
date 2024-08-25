using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.IO
{
	// Token: 0x0200056A RID: 1386
	internal static class MonoIO
	{
		// Token: 0x060029A5 RID: 10661 RVA: 0x0005A834 File Offset: 0x00058A34
		public static Exception GetException(MonoIOError error)
		{
			Exception ex;
			return ex;
		}

		// Token: 0x060029A6 RID: 10662 RVA: 0x0005A844 File Offset: 0x00058A44
		public static Exception GetException(string path, MonoIOError error)
		{
			return "Too many open files";
		}

		// Token: 0x060029A7 RID: 10663 RVA: 0x0000207A File Offset: 0x0000027A
		public static string GetCurrentDirectory([Out] MonoIOError error)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060029A8 RID: 10664 RVA: 0x0000207A File Offset: 0x0000027A
		private unsafe static bool SetFileAttributes(char* path, FileAttributes attrs, [Out] MonoIOError error)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060029A9 RID: 10665 RVA: 0x0005A91C File Offset: 0x00058B1C
		public static bool SetFileAttributes(string path, FileAttributes attrs, [Out] MonoIOError error)
		{
			/*
An exception occurred when decompiling this method (060029A9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.IO.MonoIO::SetFileAttributes(System.String,System.IO.FileAttributes,System.IO.MonoIOError)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:int32(var_0_01, ldc.i4:int32(1))
	stloc:int32(var_2_09, callgetter:int32(RuntimeHelpers::get_OffsetToStringData))
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
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

		// Token: 0x060029AA RID: 10666 RVA: 0x0000207A File Offset: 0x0000027A
		private static MonoFileType GetFileType(IntPtr handle, [Out] MonoIOError error)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060029AB RID: 10667 RVA: 0x0005A938 File Offset: 0x00058B38
		public static MonoFileType GetFileType(SafeHandle safeHandle, [Out] MonoIOError error)
		{
			if (!false)
			{
				return (MonoFileType)43155456;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060029AC RID: 10668 RVA: 0x0000207A File Offset: 0x0000027A
		private unsafe static IntPtr Open(char* filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, [Out] MonoIOError error)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060029AD RID: 10669 RVA: 0x0005A968 File Offset: 0x00058B68
		public static IntPtr Open(string filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, [Out] MonoIOError error)
		{
			/*
An exception occurred when decompiling this method (060029AD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IntPtr System.IO.MonoIO::Open(System.String,System.IO.FileMode,System.IO.FileAccess,System.IO.FileShare,System.IO.FileOptions,System.IO.MonoIOError)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:int32(var_0_01, ldc.i4:int32(1))
	stloc:int32(var_2_09, callgetter:int32(RuntimeHelpers::get_OffsetToStringData))
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
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

		// Token: 0x060029AE RID: 10670 RVA: 0x0000207A File Offset: 0x0000027A
		private static bool Cancel_internal(IntPtr handle, [Out] MonoIOError error)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060029AF RID: 10671 RVA: 0x0005A984 File Offset: 0x00058B84
		internal static bool Cancel(SafeHandle safeHandle, [Out] MonoIOError error)
		{
			if (safeHandle == null)
			{
				return false;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060029B0 RID: 10672 RVA: 0x0000207A File Offset: 0x0000027A
		public static bool Close(IntPtr handle, [Out] MonoIOError error)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060029B1 RID: 10673 RVA: 0x0000207A File Offset: 0x0000027A
		private static int Read(IntPtr handle, byte[] dest, int dest_offset, int count, [Out] MonoIOError error)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060029B2 RID: 10674 RVA: 0x0005A9B4 File Offset: 0x00058BB4
		public static int Read(SafeHandle safeHandle, byte[] dest, int dest_offset, int count, [Out] MonoIOError error)
		{
			if (!false)
			{
				return 43155456;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060029B3 RID: 10675 RVA: 0x0000207A File Offset: 0x0000027A
		private static int Write(IntPtr handle, [In] byte[] src, int src_offset, int count, [Out] MonoIOError error)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060029B4 RID: 10676 RVA: 0x0005A9E4 File Offset: 0x00058BE4
		public static int Write(SafeHandle safeHandle, byte[] src, int src_offset, int count, [Out] MonoIOError error)
		{
			if (!false)
			{
				return 43155456;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060029B5 RID: 10677 RVA: 0x0000207A File Offset: 0x0000027A
		private static long Seek(IntPtr handle, long offset, SeekOrigin origin, [Out] MonoIOError error)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060029B6 RID: 10678 RVA: 0x0005AA14 File Offset: 0x00058C14
		public static long Seek(SafeHandle safeHandle, long offset, SeekOrigin origin, [Out] MonoIOError error)
		{
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060029B7 RID: 10679 RVA: 0x0000207A File Offset: 0x0000027A
		private static long GetLength(IntPtr handle, [Out] MonoIOError error)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060029B8 RID: 10680 RVA: 0x0005AA44 File Offset: 0x00058C44
		public static long GetLength(SafeHandle safeHandle, [Out] MonoIOError error)
		{
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060029B9 RID: 10681 RVA: 0x0000207A File Offset: 0x0000027A
		private static bool SetLength(IntPtr handle, long length, [Out] MonoIOError error)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060029BA RID: 10682 RVA: 0x0005AA74 File Offset: 0x00058C74
		public static bool SetLength(SafeHandle safeHandle, long length, [Out] MonoIOError error)
		{
			if (!false)
			{
				return false;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x060029BB RID: 10683 RVA: 0x0000207A File Offset: 0x0000027A
		public static IntPtr ConsoleOutput
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x060029BC RID: 10684 RVA: 0x0000207A File Offset: 0x0000027A
		public static IntPtr ConsoleInput
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x060029BD RID: 10685 RVA: 0x0000207A File Offset: 0x0000027A
		public static IntPtr ConsoleError
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060029BE RID: 10686 RVA: 0x0000207A File Offset: 0x0000027A
		public static bool CreatePipe([Out] IntPtr read_handle, [Out] IntPtr write_handle, [Out] MonoIOError error)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060029BF RID: 10687 RVA: 0x0000207A File Offset: 0x0000027A
		public static bool DuplicateHandle(IntPtr source_process_handle, IntPtr source_handle, IntPtr target_process_handle, [Out] IntPtr target_handle, int access, int inherit, int options, [Out] MonoIOError error)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x060029C0 RID: 10688 RVA: 0x0000207A File Offset: 0x0000027A
		public static char VolumeSeparatorChar
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x060029C1 RID: 10689 RVA: 0x0000207A File Offset: 0x0000027A
		public static char DirectorySeparatorChar
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x060029C2 RID: 10690 RVA: 0x0000207A File Offset: 0x0000027A
		public static char AltDirectorySeparatorChar
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x060029C3 RID: 10691 RVA: 0x0000207A File Offset: 0x0000027A
		public static char PathSeparator
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060029C4 RID: 10692 RVA: 0x0005AAA0 File Offset: 0x00058CA0
		private static void DumpHandles()
		{
		}

		// Token: 0x060029C5 RID: 10693 RVA: 0x0000207A File Offset: 0x0000027A
		public static bool RemapPath(string path, [Out] string newPath)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060029C6 RID: 10694 RVA: 0x0005AAB0 File Offset: 0x00058CB0
		// Note: this type is marked as 'beforefieldinit'.
		static MonoIO()
		{
			string environmentVariable = Environment.GetEnvironmentVariable("MONO_DUMP_HANDLES_ON_ERROR_TOO_MANY_OPEN_FILES");
		}

		// Token: 0x04001657 RID: 5719
		public static readonly IntPtr InvalidHandle;

		// Token: 0x04001658 RID: 5720
		private static bool dump_handles;
	}
}
