using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Win32.SafeHandles;

// Token: 0x02000002 RID: 2
internal static class Interop
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	private static void ThrowExceptionForIoErrno(Interop.ErrorInfo errorInfo, string path, bool isDirectory, Func<Interop.ErrorInfo, Interop.ErrorInfo> errorRewriter)
	{
		/*
An exception occurred when decompiling this method (06000001)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Interop::ThrowExceptionForIoErrno(Interop/ErrorInfo,System.String,System.Boolean,System.Func`2<Interop/ErrorInfo,Interop/ErrorInfo>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:Exception(var_0_0B, call:Exception(Interop::GetExceptionForIoErrno, ldloc:ErrorInfo(errorInfo), ldloc:string(path), ldloc:bool(isDirectory)))
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

	// Token: 0x06000002 RID: 2 RVA: 0x00002068 File Offset: 0x00000268
	internal static long CheckIo(long result, [Optional] string path, bool isDirectory = false, [Optional] Func<Interop.ErrorInfo, Interop.ErrorInfo> errorRewriter)
	{
		/*
An exception occurred when decompiling this method (06000002)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int64 Interop::CheckIo(System.Int64,System.String,System.Boolean,System.Func`2<Interop/ErrorInfo,Interop/ErrorInfo>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ErrorInfo(var_0_05, call:ErrorInfo(Sys::GetLastErrorInfo))
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

	// Token: 0x06000003 RID: 3 RVA: 0x0000207A File Offset: 0x0000027A
	internal static int CheckIo(int result, [Optional] string path, bool isDirectory = false, [Optional] Func<Interop.ErrorInfo, Interop.ErrorInfo> errorRewriter)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002088 File Offset: 0x00000288
	internal static Exception GetExceptionForIoErrno(Interop.ErrorInfo errorInfo, [Optional] string path, bool isDirectory = false)
	{
		bool flag = string.IsNullOrEmpty("value");
		string text = SR.Format("Access to the path '{0}' is denied.", "Access to the path is denied.");
		bool flag2 = string.IsNullOrEmpty(text);
		Exception ex;
		return ex;
	}

	// Token: 0x06000005 RID: 5 RVA: 0x0000207A File Offset: 0x0000027A
	internal static Exception GetIOException(Interop.ErrorInfo errorInfo)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002124 File Offset: 0x00000324
	internal unsafe static void GetRandomBytes(byte* buffer, int length)
	{
		if (!true)
		{
		}
	}

	// Token: 0x02000003 RID: 3
	internal enum Error
	{
		// Token: 0x04000002 RID: 2
		SUCCESS,
		// Token: 0x04000003 RID: 3
		E2BIG = 65537,
		// Token: 0x04000004 RID: 4
		EACCES,
		// Token: 0x04000005 RID: 5
		EADDRINUSE,
		// Token: 0x04000006 RID: 6
		EADDRNOTAVAIL,
		// Token: 0x04000007 RID: 7
		EAFNOSUPPORT,
		// Token: 0x04000008 RID: 8
		EAGAIN,
		// Token: 0x04000009 RID: 9
		EALREADY,
		// Token: 0x0400000A RID: 10
		EBADF,
		// Token: 0x0400000B RID: 11
		EBADMSG,
		// Token: 0x0400000C RID: 12
		EBUSY,
		// Token: 0x0400000D RID: 13
		ECANCELED,
		// Token: 0x0400000E RID: 14
		ECHILD,
		// Token: 0x0400000F RID: 15
		ECONNABORTED,
		// Token: 0x04000010 RID: 16
		ECONNREFUSED,
		// Token: 0x04000011 RID: 17
		ECONNRESET,
		// Token: 0x04000012 RID: 18
		EDEADLK,
		// Token: 0x04000013 RID: 19
		EDESTADDRREQ,
		// Token: 0x04000014 RID: 20
		EDOM,
		// Token: 0x04000015 RID: 21
		EDQUOT,
		// Token: 0x04000016 RID: 22
		EEXIST,
		// Token: 0x04000017 RID: 23
		EFAULT,
		// Token: 0x04000018 RID: 24
		EFBIG,
		// Token: 0x04000019 RID: 25
		EHOSTUNREACH,
		// Token: 0x0400001A RID: 26
		EIDRM,
		// Token: 0x0400001B RID: 27
		EILSEQ,
		// Token: 0x0400001C RID: 28
		EINPROGRESS,
		// Token: 0x0400001D RID: 29
		EINTR,
		// Token: 0x0400001E RID: 30
		EINVAL,
		// Token: 0x0400001F RID: 31
		EIO,
		// Token: 0x04000020 RID: 32
		EISCONN,
		// Token: 0x04000021 RID: 33
		EISDIR,
		// Token: 0x04000022 RID: 34
		ELOOP,
		// Token: 0x04000023 RID: 35
		EMFILE,
		// Token: 0x04000024 RID: 36
		EMLINK,
		// Token: 0x04000025 RID: 37
		EMSGSIZE,
		// Token: 0x04000026 RID: 38
		EMULTIHOP,
		// Token: 0x04000027 RID: 39
		ENAMETOOLONG,
		// Token: 0x04000028 RID: 40
		ENETDOWN,
		// Token: 0x04000029 RID: 41
		ENETRESET,
		// Token: 0x0400002A RID: 42
		ENETUNREACH,
		// Token: 0x0400002B RID: 43
		ENFILE,
		// Token: 0x0400002C RID: 44
		ENOBUFS,
		// Token: 0x0400002D RID: 45
		ENODEV = 65580,
		// Token: 0x0400002E RID: 46
		ENOENT,
		// Token: 0x0400002F RID: 47
		ENOEXEC,
		// Token: 0x04000030 RID: 48
		ENOLCK,
		// Token: 0x04000031 RID: 49
		ENOLINK,
		// Token: 0x04000032 RID: 50
		ENOMEM,
		// Token: 0x04000033 RID: 51
		ENOMSG,
		// Token: 0x04000034 RID: 52
		ENOPROTOOPT,
		// Token: 0x04000035 RID: 53
		ENOSPC,
		// Token: 0x04000036 RID: 54
		ENOSYS = 65591,
		// Token: 0x04000037 RID: 55
		ENOTCONN,
		// Token: 0x04000038 RID: 56
		ENOTDIR,
		// Token: 0x04000039 RID: 57
		ENOTEMPTY,
		// Token: 0x0400003A RID: 58
		ENOTSOCK = 65596,
		// Token: 0x0400003B RID: 59
		ENOTSUP,
		// Token: 0x0400003C RID: 60
		ENOTTY,
		// Token: 0x0400003D RID: 61
		ENXIO,
		// Token: 0x0400003E RID: 62
		EOVERFLOW,
		// Token: 0x0400003F RID: 63
		EPERM = 65602,
		// Token: 0x04000040 RID: 64
		EPIPE,
		// Token: 0x04000041 RID: 65
		EPROTO,
		// Token: 0x04000042 RID: 66
		EPROTONOSUPPORT,
		// Token: 0x04000043 RID: 67
		EPROTOTYPE,
		// Token: 0x04000044 RID: 68
		ERANGE,
		// Token: 0x04000045 RID: 69
		EROFS,
		// Token: 0x04000046 RID: 70
		ESPIPE,
		// Token: 0x04000047 RID: 71
		ESRCH,
		// Token: 0x04000048 RID: 72
		ESTALE,
		// Token: 0x04000049 RID: 73
		ETIMEDOUT = 65613,
		// Token: 0x0400004A RID: 74
		ETXTBSY,
		// Token: 0x0400004B RID: 75
		EXDEV,
		// Token: 0x0400004C RID: 76
		ESOCKTNOSUPPORT = 65630,
		// Token: 0x0400004D RID: 77
		EPFNOSUPPORT = 65632,
		// Token: 0x0400004E RID: 78
		ESHUTDOWN = 65644,
		// Token: 0x0400004F RID: 79
		EHOSTDOWN = 65648,
		// Token: 0x04000050 RID: 80
		ENODATA,
		// Token: 0x04000051 RID: 81
		EOPNOTSUPP = 65597,
		// Token: 0x04000052 RID: 82
		EWOULDBLOCK = 65542
	}

	// Token: 0x02000004 RID: 4
	internal struct ErrorInfo
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00002134 File Offset: 0x00000334
		internal ErrorInfo(int errno)
		{
			if (!true)
			{
			}
			this._error = (Interop.Error)errno;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000214C File Offset: 0x0000034C
		internal ErrorInfo(Interop.Error error)
		{
			this._error = error;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000009 RID: 9 RVA: 0x0000207A File Offset: 0x0000027A
		internal Interop.Error Error
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002160 File Offset: 0x00000360
		internal int RawErrno
		{
			get
			{
				int rawErrno = this._rawErrno;
				int num;
				this._rawErrno = num;
				return num;
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000217C File Offset: 0x0000037C
		internal string GetErrorMessage()
		{
			return Interop.Sys.StrError(this.RawErrno);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002194 File Offset: 0x00000394
		public override string ToString()
		{
			int rawErrno = this.RawErrno;
			string errorMessage = this.GetErrorMessage();
			string text;
			return text;
		}

		// Token: 0x04000053 RID: 83
		private Interop.Error _error;

		// Token: 0x04000054 RID: 84
		private int _rawErrno;
	}

	// Token: 0x02000005 RID: 5
	internal static class Sys
	{
		// Token: 0x0600000D RID: 13 RVA: 0x000021B0 File Offset: 0x000003B0
		internal static Interop.ErrorInfo GetLastErrorInfo()
		{
			/*
An exception occurred when decompiling this method (0600000D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Interop/ErrorInfo Interop/Sys::GetLastErrorInfo()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_1_0A, call:int32(Marshal::GetLastWin32Error))
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

		// Token: 0x0600000E RID: 14 RVA: 0x000021C8 File Offset: 0x000003C8
		internal static string StrError(int platformErrno)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x0600000F RID: 15
		internal static extern Interop.Error ConvertErrorPlatformToPal(int platformErrno);

		// Token: 0x06000010 RID: 16
		internal static extern int ConvertErrorPalToPlatform(Interop.Error error);

		// Token: 0x06000011 RID: 17
		private unsafe static extern byte* StrErrorR(int platformErrno, byte* buffer, int bufferSize);

		// Token: 0x06000012 RID: 18
		internal unsafe static extern void GetNonCryptographicallySecureRandomBytes(byte* buffer, int length);

		// Token: 0x06000013 RID: 19
		internal static extern IntPtr OpenDir(string path);

		// Token: 0x06000014 RID: 20
		internal static extern int GetReadDirRBufferSize();

		// Token: 0x06000015 RID: 21
		internal unsafe static extern int ReadDirR(IntPtr dir, byte* buffer, int bufferSize, [Out] Interop.Sys.DirectoryEntry outputEntry);

		// Token: 0x06000016 RID: 22
		internal static extern int CloseDir(IntPtr dir);

		// Token: 0x06000017 RID: 23
		private static extern int ReadLink(string path, byte[] buffer, int bufferSize);

		// Token: 0x06000018 RID: 24 RVA: 0x000021DC File Offset: 0x000003DC
		public static string ReadLink(string path)
		{
			/*
An exception occurred when decompiling this method (06000018)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Interop/Sys::ReadLink(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0008:
	stloc:Encoding(var_3_0F, callgetter:Encoding(Encoding::get_UTF8))
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

		// Token: 0x06000019 RID: 25
		internal static extern int Stat(string path, [Out] Interop.Sys.FileStatus output);

		// Token: 0x0600001A RID: 26
		internal static extern int LStat(string path, [Out] Interop.Sys.FileStatus output);

		// Token: 0x0600001B RID: 27
		internal static extern int Symlink(string target, string linkPath);

		// Token: 0x0600001C RID: 28
		internal static extern int ChMod(string path, int mode);

		// Token: 0x0600001D RID: 29
		internal static extern int CopyFile(SafeFileHandle source, SafeFileHandle destination);

		// Token: 0x0600001E RID: 30
		internal static extern uint GetEGid();

		// Token: 0x0600001F RID: 31
		internal static extern uint GetEUid();

		// Token: 0x06000020 RID: 32
		internal static extern int LChflags(string path, uint flags);

		// Token: 0x06000021 RID: 33
		private static extern int LChflagsCanSetHiddenFlag();

		// Token: 0x06000022 RID: 34
		internal static extern int Link(string source, string link);

		// Token: 0x06000023 RID: 35
		internal static extern int MkDir(string path, int mode);

		// Token: 0x06000024 RID: 36
		internal static extern int Rename(string oldPath, string newPath);

		// Token: 0x06000025 RID: 37
		internal static extern int Stat(byte path, [Out] Interop.Sys.FileStatus output);

		// Token: 0x06000026 RID: 38 RVA: 0x000021F8 File Offset: 0x000003F8
		internal static int Stat(ReadOnlySpan<char> path, [Out] Interop.Sys.FileStatus output)
		{
			/*
An exception occurred when decompiling this method (06000026)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Interop/Sys::Stat(System.ReadOnlySpan`1<System.Char>,Interop/Sys/FileStatus)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8(var_1_06, call:!!0[exp:uint8](MemoryMarshal::GetReference, ldloc:valuetype System.Span`1<uint8>[exp:Span`1](var_0)))
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

		// Token: 0x06000027 RID: 39
		internal static extern int LStat(byte path, [Out] Interop.Sys.FileStatus output);

		// Token: 0x06000028 RID: 40 RVA: 0x0000220C File Offset: 0x0000040C
		internal static int LStat(ReadOnlySpan<char> path, [Out] Interop.Sys.FileStatus output)
		{
			/*
An exception occurred when decompiling this method (06000028)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Interop/Sys::LStat(System.ReadOnlySpan`1<System.Char>,Interop/Sys/FileStatus)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8(var_1_06, call:!!0[exp:uint8](MemoryMarshal::GetReference, ldloc:valuetype System.Span`1<uint8>[exp:Span`1](var_0)))
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

		// Token: 0x06000029 RID: 41
		internal static extern int Unlink(string pathname);

		// Token: 0x0600002A RID: 42 RVA: 0x0000207A File Offset: 0x0000027A
		internal unsafe static int DoubleToString(double value, byte* format, byte* buffer, int bufferLength)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002220 File Offset: 0x00000420
		// Note: this type is marked as 'beforefieldinit'.
		static Sys()
		{
		}

		// Token: 0x04000055 RID: 85
		internal static readonly bool CanSetHiddenFlag;

		// Token: 0x02000006 RID: 6
		internal enum NodeType
		{
			// Token: 0x04000057 RID: 87
			DT_UNKNOWN,
			// Token: 0x04000058 RID: 88
			DT_FIFO,
			// Token: 0x04000059 RID: 89
			DT_CHR,
			// Token: 0x0400005A RID: 90
			DT_DIR = 4,
			// Token: 0x0400005B RID: 91
			DT_BLK = 6,
			// Token: 0x0400005C RID: 92
			DT_REG = 8,
			// Token: 0x0400005D RID: 93
			DT_LNK = 10,
			// Token: 0x0400005E RID: 94
			DT_SOCK = 12,
			// Token: 0x0400005F RID: 95
			DT_WHT = 14
		}

		// Token: 0x02000007 RID: 7
		internal struct DirectoryEntry
		{
			// Token: 0x0600002C RID: 44 RVA: 0x00002230 File Offset: 0x00000430
			internal ReadOnlySpan<char> GetName(Span<char> buffer)
			{
				return default(ReadOnlySpan<char>);
			}

			// Token: 0x04000060 RID: 96
			internal unsafe byte* Name;

			// Token: 0x04000061 RID: 97
			internal int NameLength;

			// Token: 0x04000062 RID: 98
			internal Interop.Sys.NodeType InodeType;
		}

		// Token: 0x02000008 RID: 8
		internal struct FileStatus
		{
			// Token: 0x04000063 RID: 99
			internal Interop.Sys.FileStatusFlags Flags;

			// Token: 0x04000064 RID: 100
			internal int Mode;

			// Token: 0x04000065 RID: 101
			internal uint Uid;

			// Token: 0x04000066 RID: 102
			internal uint Gid;

			// Token: 0x04000067 RID: 103
			internal long Size;

			// Token: 0x04000068 RID: 104
			internal long ATime;

			// Token: 0x04000069 RID: 105
			internal long ATimeNsec;

			// Token: 0x0400006A RID: 106
			internal long MTime;

			// Token: 0x0400006B RID: 107
			internal long MTimeNsec;

			// Token: 0x0400006C RID: 108
			internal long CTime;

			// Token: 0x0400006D RID: 109
			internal long CTimeNsec;

			// Token: 0x0400006E RID: 110
			internal long BirthTime;

			// Token: 0x0400006F RID: 111
			internal long BirthTimeNsec;

			// Token: 0x04000070 RID: 112
			internal long Dev;

			// Token: 0x04000071 RID: 113
			internal long Ino;

			// Token: 0x04000072 RID: 114
			internal uint UserFlags;
		}

		// Token: 0x02000009 RID: 9
		[Flags]
		internal enum FileStatusFlags
		{
			// Token: 0x04000074 RID: 116
			None = 0,
			// Token: 0x04000075 RID: 117
			HasBirthTime = 1
		}

		// Token: 0x0200000A RID: 10
		[Flags]
		internal enum Permissions
		{
			// Token: 0x04000077 RID: 119
			Mask = 511,
			// Token: 0x04000078 RID: 120
			S_IRWXU = 448,
			// Token: 0x04000079 RID: 121
			S_IRUSR = 256,
			// Token: 0x0400007A RID: 122
			S_IWUSR = 128,
			// Token: 0x0400007B RID: 123
			S_IXUSR = 64,
			// Token: 0x0400007C RID: 124
			S_IRWXG = 56,
			// Token: 0x0400007D RID: 125
			S_IRGRP = 32,
			// Token: 0x0400007E RID: 126
			S_IWGRP = 16,
			// Token: 0x0400007F RID: 127
			S_IXGRP = 8,
			// Token: 0x04000080 RID: 128
			S_IRWXO = 7,
			// Token: 0x04000081 RID: 129
			S_IROTH = 4,
			// Token: 0x04000082 RID: 130
			S_IWOTH = 2,
			// Token: 0x04000083 RID: 131
			S_IXOTH = 1
		}
	}
}
