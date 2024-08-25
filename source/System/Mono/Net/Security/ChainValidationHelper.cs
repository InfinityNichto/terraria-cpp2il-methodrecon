using System;
using System.Net;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Cpp2IlInjected;
using Mono.Net.Security.Private;
using Mono.Security.Interface;

namespace Mono.Net.Security
{
	// Token: 0x02000055 RID: 85
	internal class ChainValidationHelper : ICertificateValidator
	{
		// Token: 0x060000E5 RID: 229 RVA: 0x000041E0 File Offset: 0x000023E0
		internal static ChainValidationHelper GetInternalValidator(global::System.Net.Security.SslStream owner, MobileTlsProvider provider, MonoTlsSettings settings)
		{
			while (provider == null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002050 File Offset: 0x00000250
		internal static ChainValidationHelper Create(MobileTlsProvider provider, MonoTlsSettings settings, MonoTlsStream stream)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000041F8 File Offset: 0x000023F8
		private ChainValidationHelper(global::System.Net.Security.SslStream owner, MobileTlsProvider provider, MonoTlsSettings settings, bool cloneSettings, MonoTlsStream stream)
		{
			MonoTlsSettings monoTlsSettings;
			MobileTlsProvider providerInternal;
			if (settings != null)
			{
				if (provider == null)
				{
					return;
				}
			}
			else
			{
				monoTlsSettings = MonoTlsSettings.CopyDefaultSettings().CloneWithValidator(this);
				if (provider == null)
				{
					providerInternal = MonoTlsProviderFactory.GetProviderInternal();
				}
			}
			this.settings = monoTlsSettings;
			this.provider = providerInternal;
			this.tlsStream = stream;
			if (owner != null)
			{
			}
			if (monoTlsSettings != null)
			{
				global::System.Net.ServerCertValidationCallback validationCallback = ChainValidationHelper.GetValidationCallback(monoTlsSettings);
				this.certValidationCallback = validationCallback;
				global::System.Net.Security.LocalCertSelectionCallback localCertSelectionCallback = Mono.Net.Security.Private.CallbackHelpers.MonoToInternal(monoTlsSettings.<ClientCertificateSelectionCallback>k__BackingField);
				this.certSelectionCallback = localCertSelectionCallback;
				if (stream == null)
				{
					if (owner == null)
					{
						return;
					}
					goto IL_00A0;
				}
			}
			else
			{
				while (stream == null)
				{
				}
			}
			global::System.Net.HttpWebRequest httpWebRequest = stream.request;
			global::System.Net.ServerCertValidationCallback serverCertValidationCallback = this.certValidationCallback;
			this.request = httpWebRequest;
			if (serverCertValidationCallback == null)
			{
				global::System.Net.ServerCertValidationCallback serverCertValidationCallback2 = httpWebRequest.certValidationCallback;
			}
			if (this.certSelectionCallback == null)
			{
			}
			IL_00A0:
			global::System.Net.ServerCertValidationCallback serverCertValidationCallback3 = this.certValidationCallback;
			if (serverCertValidationCallback3 == null)
			{
				if (serverCertValidationCallback3 == null)
				{
				}
				if (!true)
				{
				}
				this.certValidationCallback = 1;
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000042C0 File Offset: 0x000024C0
		private static global::System.Net.ServerCertValidationCallback GetValidationCallback(MonoTlsSettings settings)
		{
			if (true)
			{
				return;
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000042D4 File Offset: 0x000024D4
		private static X509Certificate DefaultSelectionCallback(string targetHost, global::System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers)
		{
			int num;
			if (targetHost != null && num != 0)
			{
				X509Certificate x509Certificate;
				return x509Certificate;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000EA RID: 234 RVA: 0x000042EC File Offset: 0x000024EC
		public MonoTlsSettings Settings
		{
			get
			{
				return this.settings;
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00004300 File Offset: 0x00002500
		public bool SelectClientCertificate(string targetHost, global::System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers, [Out] X509Certificate clientCertificate)
		{
			global::System.Net.Security.LocalCertSelectionCallback localCertSelectionCallback = this.certSelectionCallback;
			if (localCertSelectionCallback != null)
			{
				IntPtr invoke_impl = localCertSelectionCallback.invoke_impl;
				IntPtr method_code = localCertSelectionCallback.method_code;
				IntPtr method = localCertSelectionCallback.method;
			}
			return true;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00004330 File Offset: 0x00002530
		public ValidationResult ValidateCertificate(string host, bool serverMode, X509Certificate leaf, global::System.Security.Cryptography.X509Certificates.X509Chain chain)
		{
			MonoTlsStream monoTlsStream = this.tlsStream;
			ValidationResult validationResult;
			if (monoTlsStream != null)
			{
				if (validationResult != null && validationResult.trusted)
				{
					bool user_denied = validationResult.user_denied;
					return validationResult;
				}
				int num = 1;
				monoTlsStream.<CertificateValidationFailed>k__BackingField = num != 0;
			}
			return validationResult;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00004388 File Offset: 0x00002588
		private ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, global::System.Security.Cryptography.X509Certificates.X509Chain chain, global::System.Security.Cryptography.X509Certificates.X509CertificateCollection certs, global::System.Net.Security.SslPolicyErrors errors)
		{
			ValidationResult validationResult = this.ValidateChain(host, server, leaf, chain, certs, errors);
			long num = 0L;
			long num2;
			if (validationResult != null)
			{
				if (num != 0L)
				{
					return validationResult;
				}
			}
			else if (num2 != 0L)
			{
				throw new OutOfMemoryException();
			}
			return validationResult;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000043E8 File Offset: 0x000025E8
		private ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, global::System.Security.Cryptography.X509Certificates.X509Chain chain, global::System.Security.Cryptography.X509Certificates.X509CertificateCollection certs, global::System.Net.Security.SslPolicyErrors errors)
		{
			MonoTlsStream monoTlsStream = this.tlsStream;
			if (monoTlsStream != null)
			{
				this.request.ServicePoint.UpdateServerCertificate(leaf);
			}
			if (leaf != null)
			{
				bool flag = string.IsNullOrEmpty(host);
				int num = 58;
				int num2 = host.IndexOf((char)num);
				long num3 = 0L;
				string text = host.Substring((int)num3, num2);
				if (monoTlsStream == null)
				{
				}
				int num4 = 1;
				if (num4 == 0)
				{
				}
				if (num4 == 0)
				{
				}
				if (this.certValidationCallback == null)
				{
					goto IL_0071;
				}
				MonoTlsSettings monoTlsSettings = this.settings;
				if (monoTlsSettings != null && !monoTlsSettings.callbackNeedsChain)
				{
					goto IL_0071;
				}
			}
			if (this.certValidationCallback == null)
			{
				return 1;
			}
			IL_0071:
			if (certs != null || leaf != null)
			{
			}
			bool flag2;
			if (!flag2)
			{
				return 1;
			}
			return 1;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00004478 File Offset: 0x00002678
		private bool InvokeCallback(X509Certificate leaf, global::System.Security.Cryptography.X509Certificates.X509Chain chain, global::System.Net.Security.SslPolicyErrors errors)
		{
			long num;
			if (this.request == null)
			{
				if (this.owner != null)
				{
					bool flag;
					return flag;
				}
				num = 0L;
			}
			return this.certValidationCallback.Invoke(num, leaf, chain, errors);
		}

		// Token: 0x040000C5 RID: 197
		private readonly WeakReference<global::System.Net.Security.SslStream> owner;

		// Token: 0x040000C6 RID: 198
		private readonly MonoTlsSettings settings;

		// Token: 0x040000C7 RID: 199
		private readonly MobileTlsProvider provider;

		// Token: 0x040000C8 RID: 200
		private readonly global::System.Net.ServerCertValidationCallback certValidationCallback;

		// Token: 0x040000C9 RID: 201
		private readonly global::System.Net.Security.LocalCertSelectionCallback certSelectionCallback;

		// Token: 0x040000CA RID: 202
		private readonly MonoTlsStream tlsStream;

		// Token: 0x040000CB RID: 203
		private readonly global::System.Net.HttpWebRequest request;

		// Token: 0x02000056 RID: 86
		[CompilerGenerated]
		private sealed class <>c__DisplayClass11_0
		{
			// Token: 0x060000F0 RID: 240 RVA: 0x000044A8 File Offset: 0x000026A8
			public <>c__DisplayClass11_0()
			{
			}

			// Token: 0x060000F1 RID: 241 RVA: 0x000044BC File Offset: 0x000026BC
			internal bool <GetValidationCallback>b__0(object s, X509Certificate c, global::System.Security.Cryptography.X509Certificates.X509Chain ch, global::System.Net.Security.SslPolicyErrors e)
			{
				/*
An exception occurred when decompiling this method (060000F1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Mono.Net.Security.ChainValidationHelper/<>c__DisplayClass11_0::<GetValidationCallback>b__0(System.Object,System.Security.Cryptography.X509Certificates.X509Certificate,System.Security.Cryptography.X509Certificates.X509Chain,System.Net.Security.SslPolicyErrors)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0029:
	stloc:MonoRemoteCertificateValidationCallback(var_8_34, ldfld:MonoRemoteCertificateValidationCallback(MonoTlsSettings::<RemoteCertificateValidationCallback>k__BackingField, ldfld:MonoTlsSettings('<>c__DisplayClass11_0'::settings, ldloc:'<>c__DisplayClass11_0'(this))))
	stloc:native int(var_9_3D, ldfld:native int(Delegate::invoke_impl, ldloc:MonoRemoteCertificateValidationCallback[exp:Delegate](var_8_34)))
	stloc:native int(var_10_46, ldfld:native int(Delegate::method_code, ldloc:MonoRemoteCertificateValidationCallback[exp:Delegate](var_8_34)))
	stloc:native int(var_11_4F, ldfld:native int(Delegate::method, ldloc:MonoRemoteCertificateValidationCallback[exp:Delegate](var_8_34)))
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

			// Token: 0x040000CC RID: 204
			public MonoTlsSettings settings;
		}
	}
}
