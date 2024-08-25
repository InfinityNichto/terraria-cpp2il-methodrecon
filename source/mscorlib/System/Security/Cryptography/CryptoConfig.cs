using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;

namespace System.Security.Cryptography
{
	// Token: 0x0200030F RID: 783
	[ComVisible(true)]
	public class CryptoConfig
	{
		// Token: 0x06001A77 RID: 6775 RVA: 0x0000207A File Offset: 0x0000027A
		public static void AddOID(string oid, params string[] names)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001A78 RID: 6776 RVA: 0x00038B0C File Offset: 0x00036D0C
		public static object CreateFromName(string name)
		{
			if (!true)
			{
			}
			object obj;
			return obj;
		}

		// Token: 0x06001A79 RID: 6777 RVA: 0x00038B20 File Offset: 0x00036D20
		public static object CreateFromName(string name, params object[] args)
		{
			string text;
			uint num = <PrivateImplementationDetails>.ComputeStringHash(text);
			bool flag = text == "x509chain";
			if ("x509chain" == null && "2.5.29.19" == null)
			{
				if ("system.security.cryptography.symmetricalgorithm" == null)
				{
				}
				long num2 = 0L;
				if ("system.security.cryptography.symmetricalgorithm" == null)
				{
				}
				Monitor.Enter("system.security.cryptography.symmetricalgorithm", num2 != 0L);
				if ("system.security.cryptography.symmetricalgorithm" == null)
				{
				}
				object obj;
				return obj;
			}
			return "System.Security.Cryptography.AesCryptoServiceProvider, System.Core";
		}

		// Token: 0x06001A7A RID: 6778 RVA: 0x00039024 File Offset: 0x00037224
		internal static string MapNameToOID(string name, object arg)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x06001A7B RID: 6779 RVA: 0x00039038 File Offset: 0x00037238
		public static string MapNameToOID(string name)
		{
			string text;
			uint num = <PrivateImplementationDetails>.ComputeStringHash(text);
			bool flag = text == "md5";
			bool flag2 = text == "system.security.cryptography.sha1cng";
			bool flag3 = text == "rc2";
			bool flag4 = text == "ripemd160";
			bool flag5 = text == "sha512";
			bool flag6 = text == "system.security.cryptography.sha256";
			bool flag7 = text == "system.security.cryptography.sha384managed";
			return "2.16.840.1.101.3.4.2.2";
		}

		// Token: 0x06001A7C RID: 6780 RVA: 0x000390BC File Offset: 0x000372BC
		private static void Initialize()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06001A7D RID: 6781 RVA: 0x000390D4 File Offset: 0x000372D4
		public static void AddAlgorithm(Type algorithm, params string[] names)
		{
			if (!true)
			{
			}
			bool isVisible = algorithm.IsVisible;
			if (names == null)
			{
				return;
			}
			CryptoConfig.Initialize();
			if (!false)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001A7E RID: 6782 RVA: 0x00039120 File Offset: 0x00037320
		public static byte[] EncodeOID(string str)
		{
			byte b2;
			byte b = Convert.ToByte((int)b2);
			long num;
			return Convert.ToByte(num);
		}

		// Token: 0x06001A7F RID: 6783 RVA: 0x0003918C File Offset: 0x0003738C
		private static byte[] EncodeLongNumber(long x)
		{
			/*
An exception occurred when decompiling this method (06001A7F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] System.Security.Cryptography.CryptoConfig::EncodeLongNumber(System.Int64)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8(var_1_08, call:uint8(Convert::ToByte, ldc.i4:int64(1)))
	stloc:string(var_2_13, call:string(Locale::GetText, ldstr:string("Part of OID doesn't fit in Int32")))
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

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06001A80 RID: 6784 RVA: 0x000391AC File Offset: 0x000373AC
		[MonoLimitation("nothing is FIPS certified so it never make sense to restrict to this (empty) subset")]
		public static bool AllowOnlyFipsAlgorithms
		{
			get
			{
			}
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x000391BC File Offset: 0x000373BC
		public CryptoConfig()
		{
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x000391D0 File Offset: 0x000373D0
		// Note: this type is marked as 'beforefieldinit'.
		static CryptoConfig()
		{
		}

		// Token: 0x04000D81 RID: 3457
		private static readonly object lockObject;

		// Token: 0x04000D82 RID: 3458
		private static Dictionary<string, Type> algorithms;
	}
}
