using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Cpp2IlInjected;

namespace Internal.Cryptography.Pal
{
	// Token: 0x02000072 RID: 114
	internal struct CertificateData
	{
		// Token: 0x060001AA RID: 426 RVA: 0x00002050 File Offset: 0x00000250
		internal CertificateData(byte[] rawData)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00005D6C File Offset: 0x00003F6C
		public string GetNameInfo(global::System.Security.Cryptography.X509Certificates.X509NameType nameType, bool forIssuer)
		{
			if (nameType != global::System.Security.Cryptography.X509Certificates.X509NameType.SimpleName)
			{
				return "";
			}
			string text;
			if (text == null)
			{
				return text;
			}
			return "";
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00005E20 File Offset: 0x00004020
		private static string GetSimpleNameInfo(global::System.Security.Cryptography.X509Certificates.X500DistinguishedName name)
		{
			long num = 0L;
			long num2 = 0L;
			IEnumerable<KeyValuePair<string, string>> enumerable;
			long num3;
			int num4;
			if (enumerable == null)
			{
				num3 = 0L;
				num4 = 9;
				if (enumerable != null)
				{
				}
			}
			if (num3 != 0L || num4 != 0 || num2 != 0L || num == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00005E70 File Offset: 0x00004070
		private static string FindAltNameMatch(byte[] extensionBytes, GeneralNameType matchType, string otherOid)
		{
			if (extensionBytes != null)
			{
			}
			global::System.Security.Cryptography.DerSequenceReader derSequenceReader;
			string text = derSequenceReader.ReadOidAsString();
			string text2;
			return text2;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00005EA4 File Offset: 0x000040A4
		private static IEnumerable<KeyValuePair<string, string>> ReadReverseRdns(global::System.Security.Cryptography.X509Certificates.X500DistinguishedName name)
		{
			/*
An exception occurred when decompiling this method (060001AE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>> Internal.Cryptography.Pal.CertificateData::ReadReverseRdns(System.Security.Cryptography.X509Certificates.X500DistinguishedName)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_1_07, callgetter:int32(Environment::get_CurrentManagedThreadId))
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

		// Token: 0x04000146 RID: 326
		internal byte[] RawData;

		// Token: 0x04000147 RID: 327
		internal byte[] SubjectPublicKeyInfo;

		// Token: 0x04000148 RID: 328
		internal int Version;

		// Token: 0x04000149 RID: 329
		internal byte[] SerialNumber;

		// Token: 0x0400014A RID: 330
		internal CertificateData.AlgorithmIdentifier TbsSignature;

		// Token: 0x0400014B RID: 331
		internal global::System.Security.Cryptography.X509Certificates.X500DistinguishedName Issuer;

		// Token: 0x0400014C RID: 332
		internal DateTime NotBefore;

		// Token: 0x0400014D RID: 333
		internal DateTime NotAfter;

		// Token: 0x0400014E RID: 334
		internal global::System.Security.Cryptography.X509Certificates.X500DistinguishedName Subject;

		// Token: 0x0400014F RID: 335
		internal CertificateData.AlgorithmIdentifier PublicKeyAlgorithm;

		// Token: 0x04000150 RID: 336
		internal byte[] PublicKey;

		// Token: 0x04000151 RID: 337
		internal byte[] IssuerUniqueId;

		// Token: 0x04000152 RID: 338
		internal byte[] SubjectUniqueId;

		// Token: 0x04000153 RID: 339
		internal List<global::System.Security.Cryptography.X509Certificates.X509Extension> Extensions;

		// Token: 0x04000154 RID: 340
		internal CertificateData.AlgorithmIdentifier SignatureAlgorithm;

		// Token: 0x04000155 RID: 341
		internal byte[] SignatureValue;

		// Token: 0x02000073 RID: 115
		internal struct AlgorithmIdentifier
		{
			// Token: 0x04000156 RID: 342
			internal string AlgorithmId;

			// Token: 0x04000157 RID: 343
			internal byte[] Parameters;
		}

		// Token: 0x02000074 RID: 116
		[CompilerGenerated]
		private sealed class <ReadReverseRdns>d__21 : IEnumerable<KeyValuePair<string, string>>, IEnumerable, IEnumerator<KeyValuePair<string, string>>, IDisposable, IEnumerator
		{
			// Token: 0x060001AF RID: 431 RVA: 0x00005EB8 File Offset: 0x000040B8
			[DebuggerHidden]
			public <ReadReverseRdns>d__21(int <>1__state)
			{
				this.<>1__state = <>1__state;
				int currentManagedThreadId = Environment.CurrentManagedThreadId;
				this.<>l__initialThreadId = currentManagedThreadId;
			}

			// Token: 0x060001B0 RID: 432 RVA: 0x00005EE4 File Offset: 0x000040E4
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			// Token: 0x060001B1 RID: 433 RVA: 0x00002050 File Offset: 0x00000250
			private bool MoveNext()
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x1700005D RID: 93
			// (get) Token: 0x060001B2 RID: 434 RVA: 0x00002050 File Offset: 0x00000250
			KeyValuePair<string, string> IEnumerator<KeyValuePair<string, string>>.Current
			{
				[DebuggerHidden]
				get
				{
					throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x060001B3 RID: 435 RVA: 0x00002050 File Offset: 0x00000250
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x1700005E RID: 94
			// (get) Token: 0x060001B4 RID: 436 RVA: 0x00002050 File Offset: 0x00000250
			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x060001B5 RID: 437 RVA: 0x00005EF4 File Offset: 0x000040F4
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, string>> IEnumerable<KeyValuePair<string, string>>.GetEnumerator()
			{
				/*
An exception occurred when decompiling this method (060001B5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>> Internal.Cryptography.Pal.CertificateData/<ReadReverseRdns>d__21::System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32('<ReadReverseRdns>d__21'::<>1__state, ldloc:'<ReadReverseRdns>d__21'(this)))
	stloc:int32(var_1_0D, ldfld:int32('<ReadReverseRdns>d__21'::<>l__initialThreadId, ldloc:'<ReadReverseRdns>d__21'(this)))
	stloc:int32(var_3_15, callgetter:int32(Environment::get_CurrentManagedThreadId))
	stloc:int32(var_5_1E, callgetter:int32(Environment::get_CurrentManagedThreadId))
	stloc:X500DistinguishedName(var_6_26, ldfld:X500DistinguishedName('<ReadReverseRdns>d__21'::<>3__name, ldloc:'<ReadReverseRdns>d__21'(this)))
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

			// Token: 0x060001B6 RID: 438 RVA: 0x00005F28 File Offset: 0x00004128
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				/*
An exception occurred when decompiling this method (060001B6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.IEnumerator Internal.Cryptography.Pal.CertificateData/<ReadReverseRdns>d__21::System.Collections.IEnumerable.GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.IEnumerator`1<valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string, string>>(var_0_06, call:IEnumerator`1[exp:class [mscorlib]System.Collections.Generic.IEnumerator`1<valuetype [mscorlib]System.Collections.Generic.KeyValuePair`2<string, string>>]('<ReadReverseRdns>d__21'::System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator, ldloc:'<ReadReverseRdns>d__21'(this)))
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

			// Token: 0x04000158 RID: 344
			private int <>1__state;

			// Token: 0x04000159 RID: 345
			private KeyValuePair<string, string> <>2__current;

			// Token: 0x0400015A RID: 346
			private int <>l__initialThreadId;

			// Token: 0x0400015B RID: 347
			private global::System.Security.Cryptography.X509Certificates.X500DistinguishedName name;

			// Token: 0x0400015C RID: 348
			public global::System.Security.Cryptography.X509Certificates.X500DistinguishedName <>3__name;

			// Token: 0x0400015D RID: 349
			private Stack<global::System.Security.Cryptography.DerSequenceReader> <rdnReaders>5__2;

			// Token: 0x0400015E RID: 350
			private global::System.Security.Cryptography.DerSequenceReader <rdnReader>5__3;
		}
	}
}
