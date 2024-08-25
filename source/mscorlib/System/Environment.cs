using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using Cpp2IlInjected;
using Mono;

namespace System
{
	// Token: 0x02000164 RID: 356
	[ComVisible(true)]
	public static class Environment
	{
		// Token: 0x06000E67 RID: 3687 RVA: 0x0000207A File Offset: 0x0000027A
		internal static string GetResourceString(string key)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x0001F474 File Offset: 0x0001D674
		internal static string GetResourceString(string key, params object[] values)
		{
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string text;
			return text;
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x0001F490 File Offset: 0x0001D690
		internal static string GetResourceStringEncodingName(int codePage)
		{
			return "Unicode (UTF-32)";
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000E6A RID: 3690 RVA: 0x0001F4C4 File Offset: 0x0001D6C4
		public static string CurrentDirectory
		{
			get
			{
				return Directory.InsecureGetCurrentDirectory();
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000E6B RID: 3691 RVA: 0x0001F4D8 File Offset: 0x0001D6D8
		public static int CurrentManagedThreadId
		{
			get
			{
				return Thread.CurrentThread.ManagedThreadId;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000E6C RID: 3692 RVA: 0x0000207A File Offset: 0x0000027A
		public static bool HasShutdownStarted
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000E6D RID: 3693 RVA: 0x0000207A File Offset: 0x0000027A
		public static string MachineName
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x0000207A File Offset: 0x0000027A
		private static string GetNewLine()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000E6F RID: 3695 RVA: 0x0000207A File Offset: 0x0000027A
		public static string NewLine
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000E70 RID: 3696 RVA: 0x0000207A File Offset: 0x0000027A
		internal static PlatformID Platform
		{
			[CompilerGenerated]
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x0000207A File Offset: 0x0000027A
		internal static string GetOSVersionString()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000E72 RID: 3698 RVA: 0x0000207A File Offset: 0x0000027A
		public static OperatingSystem OSVersion
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x0001F4F4 File Offset: 0x0001D6F4
		internal static Version CreateVersionFromString(string info)
		{
			/*
An exception occurred when decompiling this method (06000E73)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Version System.Environment::CreateVersionFromString(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_4_0C, call:bool(char::IsDigit, ldloc:char(var_3)))
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

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000E74 RID: 3700 RVA: 0x0001F524 File Offset: 0x0001D724
		public static string StackTrace
		{
			get
			{
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000E75 RID: 3701 RVA: 0x0000207A File Offset: 0x0000027A
		public static int TickCount
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000E76 RID: 3702 RVA: 0x0000207A File Offset: 0x0000027A
		public static string UserDomainName
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000E77 RID: 3703 RVA: 0x0000207A File Offset: 0x0000027A
		public static string UserName
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x0001F534 File Offset: 0x0001D734
		public static void Exit(int exitCode)
		{
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x0001F544 File Offset: 0x0001D744
		public static string ExpandEnvironmentVariables(string name)
		{
			/*
An exception occurred when decompiling this method (06000E79)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Environment::ExpandEnvironmentVariables(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0025:
	stloc:int64(var_15_2D, ldc.i4:int64(0))
	brtrue(IL_0000, logicnot:bool(ldloc:int64[exp:bool](var_15_2D)))
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

		// Token: 0x06000E7A RID: 3706 RVA: 0x0000207A File Offset: 0x0000027A
		internal static string internalGetEnvironmentVariable_native(IntPtr variable)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x0001F58C File Offset: 0x0001D78C
		internal static string internalGetEnvironmentVariable(string variable)
		{
			SafeStringMarshal safeStringMarshal;
			IntPtr value = safeStringMarshal.Value;
			throw new OutOfMemoryException();
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x0001F5B4 File Offset: 0x0001D7B4
		public static string GetEnvironmentVariable(string variable)
		{
			string text;
			return text;
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x0001F5C4 File Offset: 0x0001D7C4
		private static Hashtable GetEnvironmentVariablesNoCase()
		{
			/*
An exception occurred when decompiling this method (06000E7D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Hashtable System.Environment::GetEnvironmentVariablesNoCase()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:CaseInsensitiveHashCodeProvider(var_1_07, callgetter:CaseInsensitiveHashCodeProvider(CaseInsensitiveHashCodeProvider::get_Default))
	stloc:CaseInsensitiveComparer(var_3_0F, callgetter:CaseInsensitiveComparer(CaseInsensitiveComparer::get_Default))
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

		// Token: 0x06000E7E RID: 3710 RVA: 0x0001F5E4 File Offset: 0x0001D7E4
		public static IDictionary GetEnvironmentVariables()
		{
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x0001F5F4 File Offset: 0x0001D7F4
		public static string GetFolderPath(Environment.SpecialFolder folder)
		{
			string text;
			return text;
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x0000207A File Offset: 0x0000027A
		private static string GetWindowsFolderPath(int folder)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x0001F604 File Offset: 0x0001D804
		public static string GetFolderPath(Environment.SpecialFolder folder, Environment.SpecialFolderOption option)
		{
			SecurityManager.EnsureElevatedPermissions();
			string text;
			return text;
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x0001F61C File Offset: 0x0001D81C
		private static string ReadXdgUserDir(string config_dir, string home_dir, string key, string fallback)
		{
			if (Environment.internalGetEnvironmentVariable(home_dir) != null)
			{
			}
			string text;
			bool flag = File.Exists(text);
			int num = 61;
			string text2;
			int num2 = text2.IndexOf((char)num);
			long num3 = 0L;
			bool flag2 = text2.Substring((int)num3, num2) == home_dir;
			int num4 = 34;
			string text4;
			string text3 = text4.Trim((char)num4);
			bool flag3 = text3.StartsWithOrdinalUnchecked("$HOME/");
			int num5 = 6;
			return text3.Substring(num5);
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x0001F6C4 File Offset: 0x0001D8C4
		internal static string UnixGetFolderPath(Environment.SpecialFolder folder, Environment.SpecialFolderOption option)
		{
			if (Environment.internalGetEnvironmentVariable("XDG_DATA_HOME") != null)
			{
			}
			string text = Path.Combine(Path.Combine("Caches", ".local"), "share");
			if (Environment.internalGetEnvironmentVariable("XDG_CONFIG_HOME") != null)
			{
			}
			return Path.Combine("Caches", ".config");
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x0001F76C File Offset: 0x0001D96C
		public static void FailFast(string message)
		{
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x0001F77C File Offset: 0x0001D97C
		public static void FailFast(string message, Exception exception)
		{
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x0001F78C File Offset: 0x0001D98C
		internal static void FailFast(string message, Exception exception, string errorSource)
		{
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000E87 RID: 3719 RVA: 0x0000207A File Offset: 0x0000027A
		public static int ProcessorCount
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000E88 RID: 3720 RVA: 0x0000207A File Offset: 0x0000027A
		internal static bool IsRunningOnWindows
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x0000207A File Offset: 0x0000027A
		private static string[] GetEnvironmentVariableNames()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x0000207A File Offset: 0x0000027A
		internal static string GetMachineConfigPath()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x0000207A File Offset: 0x0000027A
		internal static string internalGetHome()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x0000207A File Offset: 0x0000027A
		internal static int GetPageSize()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000E8D RID: 3725 RVA: 0x0001F79C File Offset: 0x0001D99C
		internal static bool IsUnix
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x0001F7AC File Offset: 0x0001D9AC
		internal static string GetStackTrace(Exception e, bool needFileInfo)
		{
			string text;
			return text;
		}

		// Token: 0x040005F7 RID: 1527
		private const string mono_corlib_version = "1A5E0066-58DC-428A-B21C-0AD6CDAE2789";

		// Token: 0x040005F8 RID: 1528
		private static string nl;

		// Token: 0x040005F9 RID: 1529
		private static OperatingSystem os;

		// Token: 0x02000165 RID: 357
		[ComVisible(true)]
		public enum SpecialFolder
		{
			// Token: 0x040005FB RID: 1531
			MyDocuments = 5,
			// Token: 0x040005FC RID: 1532
			Desktop = 0,
			// Token: 0x040005FD RID: 1533
			MyComputer = 17,
			// Token: 0x040005FE RID: 1534
			Programs = 2,
			// Token: 0x040005FF RID: 1535
			Personal = 5,
			// Token: 0x04000600 RID: 1536
			Favorites,
			// Token: 0x04000601 RID: 1537
			Startup,
			// Token: 0x04000602 RID: 1538
			Recent,
			// Token: 0x04000603 RID: 1539
			SendTo,
			// Token: 0x04000604 RID: 1540
			StartMenu = 11,
			// Token: 0x04000605 RID: 1541
			MyMusic = 13,
			// Token: 0x04000606 RID: 1542
			DesktopDirectory = 16,
			// Token: 0x04000607 RID: 1543
			Templates = 21,
			// Token: 0x04000608 RID: 1544
			ApplicationData = 26,
			// Token: 0x04000609 RID: 1545
			LocalApplicationData = 28,
			// Token: 0x0400060A RID: 1546
			InternetCache = 32,
			// Token: 0x0400060B RID: 1547
			Cookies,
			// Token: 0x0400060C RID: 1548
			History,
			// Token: 0x0400060D RID: 1549
			CommonApplicationData,
			// Token: 0x0400060E RID: 1550
			System = 37,
			// Token: 0x0400060F RID: 1551
			ProgramFiles,
			// Token: 0x04000610 RID: 1552
			MyPictures,
			// Token: 0x04000611 RID: 1553
			CommonProgramFiles = 43,
			// Token: 0x04000612 RID: 1554
			MyVideos = 14,
			// Token: 0x04000613 RID: 1555
			NetworkShortcuts = 19,
			// Token: 0x04000614 RID: 1556
			Fonts,
			// Token: 0x04000615 RID: 1557
			CommonStartMenu = 22,
			// Token: 0x04000616 RID: 1558
			CommonPrograms,
			// Token: 0x04000617 RID: 1559
			CommonStartup,
			// Token: 0x04000618 RID: 1560
			CommonDesktopDirectory,
			// Token: 0x04000619 RID: 1561
			PrinterShortcuts = 27,
			// Token: 0x0400061A RID: 1562
			Windows = 36,
			// Token: 0x0400061B RID: 1563
			UserProfile = 40,
			// Token: 0x0400061C RID: 1564
			SystemX86,
			// Token: 0x0400061D RID: 1565
			ProgramFilesX86,
			// Token: 0x0400061E RID: 1566
			CommonProgramFilesX86 = 44,
			// Token: 0x0400061F RID: 1567
			CommonTemplates,
			// Token: 0x04000620 RID: 1568
			CommonDocuments,
			// Token: 0x04000621 RID: 1569
			CommonAdminTools,
			// Token: 0x04000622 RID: 1570
			AdminTools,
			// Token: 0x04000623 RID: 1571
			CommonMusic = 53,
			// Token: 0x04000624 RID: 1572
			CommonPictures,
			// Token: 0x04000625 RID: 1573
			CommonVideos,
			// Token: 0x04000626 RID: 1574
			Resources,
			// Token: 0x04000627 RID: 1575
			LocalizedResources,
			// Token: 0x04000628 RID: 1576
			CommonOemLinks,
			// Token: 0x04000629 RID: 1577
			CDBurning
		}

		// Token: 0x02000166 RID: 358
		public enum SpecialFolderOption
		{
			// Token: 0x0400062B RID: 1579
			None,
			// Token: 0x0400062C RID: 1580
			DoNotVerify = 16384,
			// Token: 0x0400062D RID: 1581
			Create = 32768
		}
	}
}
