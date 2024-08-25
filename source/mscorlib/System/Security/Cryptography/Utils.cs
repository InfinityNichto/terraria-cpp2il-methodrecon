using System;
using Cpp2IlInjected;

namespace System.Security.Cryptography
{
	// Token: 0x0200030D RID: 781
	internal static class Utils
	{
		// Token: 0x06001A52 RID: 6738 RVA: 0x000387F4 File Offset: 0x000369F4
		// Note: this type is marked as 'beforefieldinit'.
		static Utils()
		{
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06001A53 RID: 6739 RVA: 0x00038804 File Offset: 0x00036A04
		internal static RNGCryptoServiceProvider StaticRandomNumberGenerator
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001A53)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Security.Cryptography.RNGCryptoServiceProvider System.Security.Cryptography.Utils::get_StaticRandomNumberGenerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
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

		// Token: 0x06001A54 RID: 6740 RVA: 0x00038818 File Offset: 0x00036A18
		internal static byte[] GenerateRandom(int keySize)
		{
			/*
An exception occurred when decompiling this method (06001A54)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] System.Security.Cryptography.Utils::GenerateRandom(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:RNGCryptoServiceProvider(var_0_05, callgetter:RNGCryptoServiceProvider(Utils::get_StaticRandomNumberGenerator))
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

		// Token: 0x06001A55 RID: 6741 RVA: 0x0003882C File Offset: 0x00036A2C
		internal static bool HasAlgorithm(int dwCalg, int dwKeySize)
		{
			return true;
		}

		// Token: 0x06001A56 RID: 6742 RVA: 0x0003883C File Offset: 0x00036A3C
		internal static string DiscardWhiteSpaces(string inputBuffer)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x06001A57 RID: 6743 RVA: 0x00038850 File Offset: 0x00036A50
		internal static string DiscardWhiteSpaces(string inputBuffer, int inputOffset, int inputCount)
		{
			char c;
			bool flag = char.IsWhiteSpace(c);
			char c2;
			bool flag2 = char.IsWhiteSpace(c2);
			string text;
			return text;
		}

		// Token: 0x06001A58 RID: 6744 RVA: 0x00038874 File Offset: 0x00036A74
		internal static int ConvertByteArrayToInt(byte[] input)
		{
		}

		// Token: 0x06001A59 RID: 6745 RVA: 0x00038884 File Offset: 0x00036A84
		internal static byte[] ConvertIntToByteArray(int dwInput)
		{
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x00038898 File Offset: 0x00036A98
		internal static void ConvertIntToByteArray(uint dwInput, byte[] counter)
		{
			if (dwInput != 0U)
			{
				while (dwInput != 0U)
				{
				}
			}
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x000388AC File Offset: 0x00036AAC
		internal static byte[] FixupKeyParity(byte[] key)
		{
		}

		// Token: 0x06001A5C RID: 6748 RVA: 0x000388BC File Offset: 0x00036ABC
		internal unsafe static void DWORDFromLittleEndian(uint* x, int digits, byte* block)
		{
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x000388CC File Offset: 0x00036ACC
		internal static void DWORDToLittleEndian(byte[] block, uint[] x, int digits)
		{
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x000388DC File Offset: 0x00036ADC
		internal unsafe static void DWORDFromBigEndian(uint* x, int digits, byte* block)
		{
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x000388EC File Offset: 0x00036AEC
		internal static void DWORDToBigEndian(byte[] block, uint[] x, int digits)
		{
		}

		// Token: 0x06001A60 RID: 6752 RVA: 0x000388FC File Offset: 0x00036AFC
		internal unsafe static void QuadWordFromBigEndian(ulong* x, int digits, byte* block)
		{
		}

		// Token: 0x06001A61 RID: 6753 RVA: 0x0003890C File Offset: 0x00036B0C
		internal static void QuadWordToBigEndian(byte[] block, ulong[] x, int digits)
		{
		}

		// Token: 0x06001A62 RID: 6754 RVA: 0x0000207A File Offset: 0x0000027A
		internal static byte[] Int(uint i)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001A63 RID: 6755 RVA: 0x0003891C File Offset: 0x00036B1C
		internal static byte[] RsaOaepEncrypt(RSA rsa, HashAlgorithm hash, PKCS1MaskGenerationMethod mgf, RandomNumberGenerator rng, byte[] data)
		{
			if (!true)
			{
			}
			byte[] array;
			return array;
		}

		// Token: 0x06001A64 RID: 6756 RVA: 0x00038930 File Offset: 0x00036B30
		internal static byte[] RsaOaepDecrypt(RSA rsa, HashAlgorithm hash, PKCS1MaskGenerationMethod mgf, byte[] encryptedData)
		{
			/*
An exception occurred when decompiling this method (06001A64)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] System.Security.Cryptography.Utils::RsaOaepDecrypt(System.Security.Cryptography.RSA,System.Security.Cryptography.HashAlgorithm,System.Security.Cryptography.PKCS1MaskGenerationMethod,System.Byte[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0008:
	stloc:string(var_1_12, call:string(Environment::GetResourceString, ldstr:string("Error occurred while decoding OAEP padding.")))
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

		// Token: 0x06001A65 RID: 6757 RVA: 0x00038950 File Offset: 0x00036B50
		internal static byte[] RsaPkcs1Padding(RSA rsa, byte[] oid, byte[] hash)
		{
			/*
An exception occurred when decompiling this method (06001A65)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] System.Security.Cryptography.Utils::RsaPkcs1Padding(System.Security.Cryptography.RSA,System.Byte[],System.Byte[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class System.Security.Cryptography.KeySizes[](var_0_06, ldfld:class System.Security.Cryptography.KeySizes[](AsymmetricAlgorithm::LegalKeySizesValue, ldloc:RSA[exp:AsymmetricAlgorithm](rsa)))
	stloc:class System.Security.Cryptography.KeySizes[](var_1_0D, ldfld:class System.Security.Cryptography.KeySizes[](AsymmetricAlgorithm::LegalKeySizesValue, ldloc:RSA[exp:AsymmetricAlgorithm](rsa)))
	stloc:class System.Security.Cryptography.KeySizes[](var_2_14, ldfld:class System.Security.Cryptography.KeySizes[](AsymmetricAlgorithm::LegalKeySizesValue, ldloc:RSA[exp:AsymmetricAlgorithm](rsa)))
	stloc:class System.Security.Cryptography.KeySizes[](var_4_1B, ldfld:class System.Security.Cryptography.KeySizes[](AsymmetricAlgorithm::LegalKeySizesValue, ldloc:RSA[exp:AsymmetricAlgorithm](rsa)))
	stloc:class System.Security.Cryptography.KeySizes[](var_5_23, ldfld:class System.Security.Cryptography.KeySizes[](AsymmetricAlgorithm::LegalKeySizesValue, ldloc:RSA[exp:AsymmetricAlgorithm](rsa)))
	stloc:class System.Security.Cryptography.KeySizes[](var_6_2B, ldfld:class System.Security.Cryptography.KeySizes[](AsymmetricAlgorithm::LegalKeySizesValue, ldloc:RSA[exp:AsymmetricAlgorithm](rsa)))
	stloc:class System.Security.Cryptography.KeySizes[](var_7_33, ldfld:class System.Security.Cryptography.KeySizes[](AsymmetricAlgorithm::LegalKeySizesValue, ldloc:RSA[exp:AsymmetricAlgorithm](rsa)))
	stloc:class System.Security.Cryptography.KeySizes[](var_8_3B, ldfld:class System.Security.Cryptography.KeySizes[](AsymmetricAlgorithm::LegalKeySizesValue, ldloc:RSA[exp:AsymmetricAlgorithm](rsa)))
	stloc:string(var_11_47, call:string(Environment::GetResourceString, ldstr:string("Object identifier (OID) is unknown.")))
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

		// Token: 0x06001A66 RID: 6758 RVA: 0x000389A8 File Offset: 0x00036BA8
		internal static bool CompareBigIntArrays(byte[] lhs, byte[] rhs)
		{
		}

		// Token: 0x06001A67 RID: 6759 RVA: 0x000389BC File Offset: 0x00036BBC
		internal static HashAlgorithmName OidToHashAlgorithmName(string oid)
		{
			bool flag = "2.16.840.1.101.3.4.2.2" == "1.3.14.3.2.26";
			return HashAlgorithmName.SHA1;
		}

		// Token: 0x06001A68 RID: 6760 RVA: 0x000389FC File Offset: 0x00036BFC
		internal static bool DoesRsaKeyOverride(RSA rsaKey, string methodName, Type[] parameterTypes)
		{
			return true;
		}

		// Token: 0x06001A69 RID: 6761 RVA: 0x00038A0C File Offset: 0x00036C0C
		private static bool DoesRsaKeyOverrideSlowPath(Type t, string methodName, Type[] parameterTypes)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06001A6A RID: 6762 RVA: 0x00038A1C File Offset: 0x00036C1C
		internal static bool _ProduceLegacyHmacValues()
		{
		}

		// Token: 0x04000D7E RID: 3454
		internal const int DefaultRsaProviderType = 1;

		// Token: 0x04000D7F RID: 3455
		private static RNGCryptoServiceProvider _rng;
	}
}
