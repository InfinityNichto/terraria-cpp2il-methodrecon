using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Cpp2IlInjected;

namespace Mono.Security.Interface
{
	// Token: 0x0200004E RID: 78
	public sealed class MonoTlsSettings
	{
		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000203 RID: 515 RVA: 0x00008CB8 File Offset: 0x00006EB8
		// (set) Token: 0x06000204 RID: 516 RVA: 0x00008CCC File Offset: 0x00006ECC
		public MonoRemoteCertificateValidationCallback RemoteCertificateValidationCallback
		{
			[CompilerGenerated]
			get
			{
				return this.<RemoteCertificateValidationCallback>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<RemoteCertificateValidationCallback>k__BackingField = value;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000205 RID: 517 RVA: 0x00008CE0 File Offset: 0x00006EE0
		// (set) Token: 0x06000206 RID: 518 RVA: 0x00008CF4 File Offset: 0x00006EF4
		public MonoLocalCertificateSelectionCallback ClientCertificateSelectionCallback
		{
			[CompilerGenerated]
			get
			{
				return this.<ClientCertificateSelectionCallback>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ClientCertificateSelectionCallback>k__BackingField = value;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000207 RID: 519 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000208 RID: 520 RVA: 0x00008D08 File Offset: 0x00006F08
		public bool? UseServicePointManagerCallback
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000209 RID: 521 RVA: 0x00008D18 File Offset: 0x00006F18
		public bool CallbackNeedsCertificateChain
		{
			get
			{
				return this.callbackNeedsChain;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600020A RID: 522 RVA: 0x00008D2C File Offset: 0x00006F2C
		// (set) Token: 0x0600020B RID: 523 RVA: 0x00008D40 File Offset: 0x00006F40
		public DateTime? CertificateValidationTime
		{
			[CompilerGenerated]
			get
			{
				return this.<CertificateValidationTime>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<CertificateValidationTime>k__BackingField = value;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600020C RID: 524 RVA: 0x00008D54 File Offset: 0x00006F54
		// (set) Token: 0x0600020D RID: 525 RVA: 0x00008D68 File Offset: 0x00006F68
		public X509CertificateCollection TrustAnchors
		{
			[CompilerGenerated]
			get
			{
				return this.<TrustAnchors>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<TrustAnchors>k__BackingField = value;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600020E RID: 526 RVA: 0x00008D7C File Offset: 0x00006F7C
		// (set) Token: 0x0600020F RID: 527 RVA: 0x00008D90 File Offset: 0x00006F90
		public object UserSettings
		{
			[CompilerGenerated]
			get
			{
				return this.<UserSettings>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<UserSettings>k__BackingField = value;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000210 RID: 528 RVA: 0x00008DA4 File Offset: 0x00006FA4
		// (set) Token: 0x06000211 RID: 529 RVA: 0x00008DB8 File Offset: 0x00006FB8
		internal string[] CertificateSearchPaths
		{
			[CompilerGenerated]
			get
			{
				return this.<CertificateSearchPaths>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<CertificateSearchPaths>k__BackingField = value;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000212 RID: 530 RVA: 0x00008DCC File Offset: 0x00006FCC
		// (set) Token: 0x06000213 RID: 531 RVA: 0x00008DE0 File Offset: 0x00006FE0
		internal bool SendCloseNotify
		{
			[CompilerGenerated]
			get
			{
				return this.<SendCloseNotify>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000214 RID: 532 RVA: 0x00008DF0 File Offset: 0x00006FF0
		// (set) Token: 0x06000215 RID: 533 RVA: 0x00008E04 File Offset: 0x00007004
		public string[] ClientCertificateIssuers
		{
			[CompilerGenerated]
			get
			{
				return this.<ClientCertificateIssuers>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ClientCertificateIssuers>k__BackingField = value;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000216 RID: 534 RVA: 0x00008E18 File Offset: 0x00007018
		// (set) Token: 0x06000217 RID: 535 RVA: 0x00008E2C File Offset: 0x0000702C
		public bool DisallowUnauthenticatedCertificateRequest
		{
			[CompilerGenerated]
			get
			{
				return this.<DisallowUnauthenticatedCertificateRequest>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000218 RID: 536 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000219 RID: 537 RVA: 0x00008E3C File Offset: 0x0000703C
		public TlsProtocols? EnabledProtocols
		{
			[CompilerGenerated]
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600021A RID: 538 RVA: 0x00008E4C File Offset: 0x0000704C
		// (set) Token: 0x0600021B RID: 539 RVA: 0x00008E60 File Offset: 0x00007060
		[CLSCompliant(false)]
		public CipherSuiteCode[] EnabledCiphers
		{
			[CompilerGenerated]
			get
			{
				return this.<EnabledCiphers>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<EnabledCiphers>k__BackingField = value;
			}
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00008E74 File Offset: 0x00007074
		public MonoTlsSettings()
		{
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600021D RID: 541 RVA: 0x00008E98 File Offset: 0x00007098
		public static MonoTlsSettings DefaultSettings
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600021D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Mono.Security.Interface.MonoTlsSettings Mono.Security.Interface.MonoTlsSettings::get_DefaultSettings()

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

		// Token: 0x0600021E RID: 542 RVA: 0x00008EA8 File Offset: 0x000070A8
		public static MonoTlsSettings CopyDefaultSettings()
		{
			return MonoTlsSettings.DefaultSettings.Clone();
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600021F RID: 543 RVA: 0x00008EC0 File Offset: 0x000070C0
		[Obsolete("Do not use outside System.dll!")]
		public ICertificateValidator CertificateValidator
		{
			get
			{
				return this.certificateValidator;
			}
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00008ED4 File Offset: 0x000070D4
		[Obsolete("Do not use outside System.dll!")]
		public MonoTlsSettings CloneWithValidator(ICertificateValidator validator)
		{
			/*
An exception occurred when decompiling this method (06000220)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Mono.Security.Interface.MonoTlsSettings Mono.Security.Interface.MonoTlsSettings::CloneWithValidator(Mono.Security.Interface.ICertificateValidator)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldfld:bool(MonoTlsSettings::cloned, ldloc:MonoTlsSettings(this))))
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

		// Token: 0x06000221 RID: 545 RVA: 0x00002050 File Offset: 0x00000250
		public MonoTlsSettings Clone()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00008EE8 File Offset: 0x000070E8
		private MonoTlsSettings(MonoTlsSettings other)
		{
			MonoRemoteCertificateValidationCallback monoRemoteCertificateValidationCallback = other.<RemoteCertificateValidationCallback>k__BackingField;
			this.RemoteCertificateValidationCallback = monoRemoteCertificateValidationCallback;
			bool flag = other.checkCertName;
			this.checkCertName = flag;
			bool flag2 = other.checkCertRevocationStatus;
			this.checkCertRevocationStatus = flag2;
			bool flag3 = other.skipSystemValidators;
			this.skipSystemValidators = flag3;
			bool flag4 = other.callbackNeedsChain;
			this.callbackNeedsChain = flag4;
			object obj = other.<UserSettings>k__BackingField;
			this.UserSettings = obj;
			CipherSuiteCode[] array = other.<EnabledCiphers>k__BackingField;
			this.EnabledCiphers = array;
			bool hasValue = other.<CertificateValidationTime>k__BackingField.hasValue;
			this.<CertificateValidationTime>k__BackingField.hasValue = hasValue;
			bool flag5 = other.<SendCloseNotify>k__BackingField;
			this.<SendCloseNotify>k__BackingField = flag5;
			string[] array2 = other.<ClientCertificateIssuers>k__BackingField;
			this.ClientCertificateIssuers = array2;
			bool flag6 = other.<DisallowUnauthenticatedCertificateRequest>k__BackingField;
			this.<DisallowUnauthenticatedCertificateRequest>k__BackingField = flag6;
			if (other.<TrustAnchors>k__BackingField != null)
			{
			}
			if (other.<CertificateSearchPaths>k__BackingField != null)
			{
				string[] array3 = other.<CertificateSearchPaths>k__BackingField;
			}
			this.cloned = true;
		}

		// Token: 0x0400022D RID: 557
		[CompilerGenerated]
		private MonoRemoteCertificateValidationCallback <RemoteCertificateValidationCallback>k__BackingField;

		// Token: 0x0400022E RID: 558
		[CompilerGenerated]
		private MonoLocalCertificateSelectionCallback <ClientCertificateSelectionCallback>k__BackingField;

		// Token: 0x0400022F RID: 559
		[CompilerGenerated]
		private DateTime? <CertificateValidationTime>k__BackingField;

		// Token: 0x04000230 RID: 560
		[CompilerGenerated]
		private X509CertificateCollection <TrustAnchors>k__BackingField;

		// Token: 0x04000231 RID: 561
		[CompilerGenerated]
		private object <UserSettings>k__BackingField;

		// Token: 0x04000232 RID: 562
		[CompilerGenerated]
		private string[] <CertificateSearchPaths>k__BackingField;

		// Token: 0x04000233 RID: 563
		[CompilerGenerated]
		private bool <SendCloseNotify>k__BackingField;

		// Token: 0x04000234 RID: 564
		[CompilerGenerated]
		private string[] <ClientCertificateIssuers>k__BackingField;

		// Token: 0x04000235 RID: 565
		[CompilerGenerated]
		private bool <DisallowUnauthenticatedCertificateRequest>k__BackingField;

		// Token: 0x04000236 RID: 566
		[CompilerGenerated]
		private TlsProtocols? <EnabledProtocols>k__BackingField;

		// Token: 0x04000237 RID: 567
		[CompilerGenerated]
		private CipherSuiteCode[] <EnabledCiphers>k__BackingField;

		// Token: 0x04000238 RID: 568
		private bool cloned;

		// Token: 0x04000239 RID: 569
		private bool checkCertName = true;

		// Token: 0x0400023A RID: 570
		private bool checkCertRevocationStatus;

		// Token: 0x0400023B RID: 571
		private bool? useServicePointManagerCallback;

		// Token: 0x0400023C RID: 572
		private bool skipSystemValidators;

		// Token: 0x0400023D RID: 573
		private bool callbackNeedsChain = true;

		// Token: 0x0400023E RID: 574
		private ICertificateValidator certificateValidator;

		// Token: 0x0400023F RID: 575
		private static MonoTlsSettings defaultSettings;
	}
}
