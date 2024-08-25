using System;
using System.Security.Cryptography;
using Cpp2IlInjected;

namespace Mono.Security.Cryptography
{
	// Token: 0x02000052 RID: 82
	public sealed class CryptoConvert
	{
		// Token: 0x06000237 RID: 567 RVA: 0x00002050 File Offset: 0x00000250
		private static int ToInt32LE(byte[] bytes, int offset)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00002050 File Offset: 0x00000250
		private static uint ToUInt32LE(byte[] bytes, int offset)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00009220 File Offset: 0x00007420
		private static byte[] Trim(byte[] array)
		{
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00009230 File Offset: 0x00007430
		public static RSA FromCapiPrivateKeyBlob(byte[] blob)
		{
			RSA rsa;
			return rsa;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00009240 File Offset: 0x00007440
		public static RSA FromCapiPrivateKeyBlob(byte[] blob, int offset)
		{
			return RSA.Create();
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00009260 File Offset: 0x00007460
		private static RSAParameters GetParametersFromCapiPrivateKeyBlob(byte[] blob, int offset)
		{
			int num = 1;
			if (blob != null && num == 0 && num == 0)
			{
				RSAParameters rsaparameters;
				rsaparameters.DP = 42163096;
				rsaparameters.DQ = 42163096;
				rsaparameters.Q = 42163096;
				return;
			}
		}

		// Token: 0x0600023D RID: 573 RVA: 0x000092A4 File Offset: 0x000074A4
		public static string ToHex(byte[] input)
		{
			/*
An exception occurred when decompiling this method (0600023D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Mono.Security.Cryptography.CryptoConvert::ToHex(System.Byte[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:CultureInfo(var_2_09, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
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

		// Token: 0x0600023E RID: 574 RVA: 0x000092C0 File Offset: 0x000074C0
		private static byte FromHexChar(char c)
		{
		}

		// Token: 0x0600023F RID: 575 RVA: 0x000092D8 File Offset: 0x000074D8
		public static byte[] FromHex(string hex)
		{
			char c;
			byte b = CryptoConvert.FromHexChar(c);
			char c2;
			return CryptoConvert.FromHexChar(c2);
		}
	}
}
