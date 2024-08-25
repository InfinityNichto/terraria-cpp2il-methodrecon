using System;
using System.Diagnostics;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000038 RID: 56
	[NativeHeader("Runtime/Export/Debug/Debug.bindings.h")]
	public class Debug
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000062 RID: 98 RVA: 0x000027C0 File Offset: 0x000009C0
		public static ILogger unityLogger
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000062)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.ILogger UnityEngine.Debug::get_unityLogger()

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
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000027D0 File Offset: 0x000009D0
		[ThreadSafe]
		public unsafe static int ExtractStackTraceNoAlloc(byte* buffer, int bufferMax, string projectFolder)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000027E4 File Offset: 0x000009E4
		public static void Log(object message)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000027F8 File Offset: 0x000009F8
		public static void LogError(object message)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000280C File Offset: 0x00000A0C
		public static void LogError(object message, Object context)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002820 File Offset: 0x00000A20
		public static void LogErrorFormat(Object context, string format, params object[] args)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002834 File Offset: 0x00000A34
		public static void LogException(Exception exception)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002848 File Offset: 0x00000A48
		public static void LogException(Exception exception, Object context)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000285C File Offset: 0x00000A5C
		public static void LogWarning(object message)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002870 File Offset: 0x00000A70
		public static void LogWarning(object message, Object context)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002884 File Offset: 0x00000A84
		public static void LogWarningFormat(Object context, string format, params object[] args)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002898 File Offset: 0x00000A98
		[Conditional("UNITY_ASSERTIONS")]
		public static void Assert(bool condition)
		{
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000028B0 File Offset: 0x00000AB0
		[RequiredByNativeCode]
		internal static bool CallOverridenDebugHandler(Exception exception, Object obj)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			return false;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000028DC File Offset: 0x00000ADC
		[RequiredByNativeCode]
		internal static bool IsLoggingEnabled()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			return false;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002900 File Offset: 0x00000B00
		// Note: this type is marked as 'beforefieldinit'.
		static Debug()
		{
		}

		// Token: 0x040000BD RID: 189
		internal static readonly ILogger s_DefaultLogger;

		// Token: 0x040000BE RID: 190
		internal static ILogger s_Logger;
	}
}
