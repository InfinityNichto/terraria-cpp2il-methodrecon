using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Win32.SafeHandles;

namespace System.Threading
{
	// Token: 0x0200020C RID: 524
	internal static class NativeEventCalls
	{
		// Token: 0x060012A2 RID: 4770 RVA: 0x000273FC File Offset: 0x000255FC
		public static IntPtr CreateEvent_internal(bool manual, bool initial, string name, [Out] int errorCode)
		{
			/*
An exception occurred when decompiling this method (060012A2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IntPtr System.Threading.NativeEventCalls::CreateEvent_internal(System.Boolean,System.Boolean,System.String,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_1_0A, callgetter:int32(RuntimeHelpers::get_OffsetToStringData))
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

		// Token: 0x060012A3 RID: 4771 RVA: 0x0000207A File Offset: 0x0000027A
		private unsafe static IntPtr CreateEvent_icall(bool manual, bool initial, char* name, int name_length, [Out] int errorCode)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x00027414 File Offset: 0x00025614
		public static bool SetEvent(SafeWaitHandle handle)
		{
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x0000207A File Offset: 0x0000027A
		private static bool SetEvent_internal(IntPtr handle)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060012A6 RID: 4774 RVA: 0x0002743C File Offset: 0x0002563C
		public static bool ResetEvent(SafeWaitHandle handle)
		{
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060012A7 RID: 4775 RVA: 0x0000207A File Offset: 0x0000027A
		private static bool ResetEvent_internal(IntPtr handle)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x00027464 File Offset: 0x00025664
		public static void CloseEvent_internal(IntPtr handle)
		{
		}
	}
}
