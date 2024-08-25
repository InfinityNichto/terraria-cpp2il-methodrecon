using System;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;

namespace Mono
{
	// Token: 0x02000019 RID: 25
	internal static class RuntimeMarshal
	{
		// Token: 0x0600005C RID: 92 RVA: 0x00002568 File Offset: 0x00000768
		internal static string PtrToUtf8String(IntPtr ptr)
		{
			Encoding utf = Encoding.UTF8;
			string text;
			return text;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000207A File Offset: 0x0000027A
		internal static SafeStringMarshal MarshalString(string str)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002584 File Offset: 0x00000784
		private static int DecodeBlobSize(IntPtr in_ptr, [Out] IntPtr out_ptr)
		{
			/*
An exception occurred when decompiling this method (0600005E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Mono.RuntimeMarshal::DecodeBlobSize(System.IntPtr,System.IntPtr)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_1_06, call:native int(native int::op_Explicit, ldloc:void*(var_0)))
	stfld:void*(native int::m_value, ldloc:native int[exp:native int&](in_ptr), ldloc:native int[exp:void*](var_1_06))
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

		// Token: 0x0600005F RID: 95 RVA: 0x0000207A File Offset: 0x0000027A
		internal static byte[] DecodeBlobArray(IntPtr ptr)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000207A File Offset: 0x0000027A
		internal static int AsciHexDigitValue(int c)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000025A0 File Offset: 0x000007A0
		internal static void FreeAssemblyName(MonoAssemblyName name, bool freeStruct)
		{
		}
	}
}
