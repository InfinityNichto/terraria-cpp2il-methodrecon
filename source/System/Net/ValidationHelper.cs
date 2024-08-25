using System;
using System.Globalization;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x020001A3 RID: 419
	internal static class ValidationHelper
	{
		// Token: 0x06000A8A RID: 2698 RVA: 0x00002050 File Offset: 0x00000250
		public static string[] MakeEmptyArrayNull(string[] stringArray)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x00002050 File Offset: 0x00000250
		public static string MakeStringNull(string stringValue)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x000234D4 File Offset: 0x000216D4
		public static string ExceptionMessage(Exception exception)
		{
			string text;
			return " (" + " (" + text + ")";
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x000234F8 File Offset: 0x000216F8
		public static string ToString(object objectValue)
		{
			return "(null)";
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x00023520 File Offset: 0x00021720
		public static string HashString(object objectValue)
		{
			NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
			string text;
			return text;
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x00023540 File Offset: 0x00021740
		public static bool IsInvalidHttpString(string stringValue)
		{
			/*
An exception occurred when decompiling this method (06000A8F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.ValidationHelper::IsInvalidHttpString(System.String)

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

		// Token: 0x06000A90 RID: 2704 RVA: 0x00023550 File Offset: 0x00021750
		public static bool IsBlankString(string stringValue)
		{
			return true;
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x00002050 File Offset: 0x00000250
		public static bool ValidateTcpPort(int port)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x00002050 File Offset: 0x00000250
		public static bool ValidateRange(int actual, int fromAllowed, int toAllowed)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x00023560 File Offset: 0x00021760
		internal static void ValidateSegment(ArraySegment<byte> segment)
		{
			while (segment == null)
			{
			}
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x00023574 File Offset: 0x00021774
		// Note: this type is marked as 'beforefieldinit'.
		static ValidationHelper()
		{
		}

		// Token: 0x04000863 RID: 2147
		public static string[] EmptyArray;

		// Token: 0x04000864 RID: 2148
		internal static readonly char[] InvalidMethodChars;

		// Token: 0x04000865 RID: 2149
		internal static readonly char[] InvalidParamChars;
	}
}
