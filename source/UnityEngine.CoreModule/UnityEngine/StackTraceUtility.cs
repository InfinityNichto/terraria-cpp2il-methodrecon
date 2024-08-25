using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000AC RID: 172
	public static class StackTraceUtility
	{
		// Token: 0x06000315 RID: 789 RVA: 0x00006758 File Offset: 0x00004958
		[RequiredByNativeCode]
		internal static void SetProjectFolder(string folder)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00006768 File Offset: 0x00004968
		[RequiredByNativeCode]
		public static string ExtractStackTrace()
		{
			if (!true)
			{
			}
			throw new MissingMethodException();
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00006794 File Offset: 0x00004994
		[RequiredByNativeCode]
		internal static void ExtractStringFromExceptionInternal(object exceptiono, [Out] string message, [Out] string stackTrace)
		{
			while (exceptiono == null)
			{
			}
			if (exceptiono != null)
			{
				return;
			}
			if (exceptiono != null)
			{
			}
			string text;
			int stringLength = text._stringLength;
			if (stringLength != 0)
			{
			}
			string text4;
			if (stringLength != 0)
			{
				string text3;
				string text2 = "Rethrow as " + text3 + "\n" + text4;
				while (exceptiono != null)
				{
				}
				return;
			}
			string text5 = text4 + "\n";
		}

		// Token: 0x06000318 RID: 792 RVA: 0x000067F0 File Offset: 0x000049F0
		internal static string ExtractFormattedStackTrace(StackTrace stackTrace)
		{
			/*
An exception occurred when decompiling this method (06000318)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String UnityEngine.StackTraceUtility::ExtractFormattedStackTrace(System.Diagnostics.StackTrace)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0012:
	stloc:bool(var_25_1C, call:bool(string::IsNullOrEmpty, ldstr:string(" (at ")))
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

		// Token: 0x06000319 RID: 793 RVA: 0x00006820 File Offset: 0x00004A20
		// Note: this type is marked as 'beforefieldinit'.
		static StackTraceUtility()
		{
		}

		// Token: 0x04000369 RID: 873
		private static string projectFolder;
	}
}
