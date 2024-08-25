using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using Mono.Security.Cryptography;

namespace Mono.Security.Protocol.Ntlm
{
	// Token: 0x0200003A RID: 58
	public static class ChallengeResponse2
	{
		// Token: 0x060001BD RID: 445 RVA: 0x00008078 File Offset: 0x00006278
		private static byte[] Compute_LM(string password, byte[] challenge)
		{
			DES.Create().Clear();
			byte[] array;
			return array;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00008098 File Offset: 0x00006298
		private static byte[] Compute_NTLM_Password(string password)
		{
			MD4 md = MD4.Create();
			Encoding unicode = Encoding.Unicode;
			long num = 0L;
			byte[] array;
			Array.Clear(array, (int)num, 42163096);
			return 42163096;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000080CC File Offset: 0x000062CC
		private static byte[] Compute_NTLM(string password, byte[] challenge)
		{
			if (!true)
			{
			}
			byte[] array;
			return array;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x000080E0 File Offset: 0x000062E0
		private static void Compute_NTLMv2_Session(string password, byte[] challenge, [Out] byte[] lm, [Out] byte[] ntlm)
		{
			RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create();
			MD5 md = MD5.Create();
			int num = 8;
			byte[] array;
			ntlm.m_value = array;
			long num2 = 0L;
			byte[] array2;
			Array.Clear(array2, (int)num2, num);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00008120 File Offset: 0x00006320
		private static byte[] Compute_NTLMv2(Type2Message type2, string username, string password, string domain)
		{
			/*
An exception occurred when decompiling this method (060001C1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] Mono.Security.Protocol.Ntlm.ChallengeResponse2::Compute_NTLMv2(Mono.Security.Protocol.Ntlm.Type2Message,System.String,System.String,System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0052:
	stloc:int64(var_14_5F, callgetter:int64(DateTime::get_Ticks, callgetter:DateTime[exp:valuetype [mscorlib]System.DateTime&](DateTime::get_Now)))
	stloc:RandomNumberGenerator(var_17_6C, call:RandomNumberGenerator(RandomNumberGenerator::Create))
	stloc:int64(var_25_72, ldc.i4:int64(0))
	stloc:int64(var_26_75, ldc.i4:int64(0))
	call:void(Array::Clear, ldloc:uint8[][exp:Array](var_11), ldloc:int64[exp:int32](var_26_75), ldloc:int64[exp:int32](var_25_72))
	stloc:int64(var_27_83, ldc.i4:int64(0))
	call:void(Array::Clear, ldloc:uint8[][exp:Array](var_24), ldloc:int64[exp:int32](var_27_83), ldc.i4:int32(-1186988032))
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

		// Token: 0x060001C2 RID: 450 RVA: 0x000081C0 File Offset: 0x000063C0
		public static void Compute(Type2Message type2, NtlmAuthLevel level, string username, string password, string domain, [Out] byte[] lm, [Out] byte[] ntlm)
		{
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00008220 File Offset: 0x00006420
		private static byte[] GetResponse(byte[] challenge, byte[] pwd)
		{
			/*
An exception occurred when decompiling this method (060001C3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] Mono.Security.Protocol.Ntlm.ChallengeResponse2::GetResponse(System.Byte[],System.Byte[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:DES(var_2_0A, call:DES(DES::Create))
	stloc:int64(var_3_0C, ldc.i4:int64(0))
	stloc:uint8[](var_4_14, call:uint8[](ChallengeResponse2::PrepareDESKey, ldloc:uint8[](challenge), ldloc:int64[exp:int32](var_3_0C)))
	stloc:int32(var_5_17, ldc.i4:int32(7))
	stloc:uint8[](var_6_21, call:uint8[](ChallengeResponse2::PrepareDESKey, ldloc:uint8[](challenge), ldloc:int32(var_5_17)))
	stloc:int32(var_7_25, ldc.i4:int32(14))
	stloc:uint8[](var_8_2F, call:uint8[](ChallengeResponse2::PrepareDESKey, ldloc:uint8[](challenge), ldloc:int32(var_7_25)))
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

		// Token: 0x060001C4 RID: 452 RVA: 0x00008260 File Offset: 0x00006460
		private static byte[] PrepareDESKey(byte[] key56bits, int position)
		{
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00008270 File Offset: 0x00006470
		private static byte[] PasswordToKey(string password, int position)
		{
			int num = 7;
			int num2 = Math.Min(0, num);
			Encoding ascii = Encoding.ASCII;
			CultureInfo currentCulture = CultureInfo.CurrentCulture;
			byte[] array;
			return array;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x000082A0 File Offset: 0x000064A0
		// Note: this type is marked as 'beforefieldinit'.
		static ChallengeResponse2()
		{
		}

		// Token: 0x040000D3 RID: 211
		private static byte[] magic;

		// Token: 0x040000D4 RID: 212
		private static byte[] nullEncMagic;
	}
}
