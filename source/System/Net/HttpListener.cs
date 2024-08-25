using System;
using System.Collections;
using System.IO;
using System.Net.Security;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mono.Net.Security.Private;
using Mono.Security.Authenticode;
using Mono.Security.Interface;

namespace System.Net
{
	// Token: 0x02000249 RID: 585
	public sealed class HttpListener : IDisposable
	{
		// Token: 0x06000EC8 RID: 3784 RVA: 0x0002F268 File Offset: 0x0002D468
		internal HttpListener(X509Certificate certificate, MonoTlsProvider tlsProvider, MonoTlsSettings tlsSettings)
		{
			this.tlsSettings = tlsSettings;
			this.certificate = certificate;
			this.tlsProvider = tlsProvider;
		}

		// Token: 0x06000EC9 RID: 3785 RVA: 0x0002F28C File Offset: 0x0002D48C
		internal X509Certificate LoadCertificateAndKey(IPAddress addr, int port)
		{
			int num = 1;
			object internalLock = this._internalLock;
			if (this.certificate != null)
			{
			}
			if (num == 0)
			{
			}
			string text2;
			string text = Path.Combine(Path.Combine(text2, ".mono"), "httplistener");
			string text3;
			bool flag = File.Exists(Path.Combine(text, text3));
			if ("{0}.pvk" == null)
			{
			}
			string text5;
			string text4 = Path.Combine(text, text5);
			bool flag2 = File.Exists(text4);
			RSA rsa = PrivateKey.CreateFromFile(text4).rsa;
			global::System.Security.Cryptography.X509Certificates.X509Certificate2Impl x509Certificate2Impl;
			if (x509Certificate2Impl != null)
			{
			}
			long num2 = 0L;
			Monitor.Exit(internalLock);
			if (num2 == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000ECA RID: 3786 RVA: 0x0002F33C File Offset: 0x0002D53C
		internal global::System.Net.Security.SslStream CreateSslStream(Stream innerStream, bool ownsStream, global::System.Net.Security.RemoteCertificateValidationCallback callback)
		{
			object internalLock;
			do
			{
				internalLock = this._internalLock;
				if (this.tlsProvider == null)
				{
					MonoTlsProvider provider = MonoTlsProviderFactory.GetProvider();
					this.tlsProvider = provider;
				}
			}
			while (this.tlsSettings != null);
			MonoTlsSettings monoTlsSettings = MonoTlsSettings.DefaultSettings.Clone();
			MonoRemoteCertificateValidationCallback monoRemoteCertificateValidationCallback = Mono.Net.Security.Private.CallbackHelpers.PublicToMono(callback);
			monoTlsSettings.<RemoteCertificateValidationCallback>k__BackingField = monoRemoteCertificateValidationCallback;
			MonoTlsProvider monoTlsProvider = this.tlsProvider;
			long num = 0L;
			Monitor.Exit(internalLock);
			if (num == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000ECB RID: 3787 RVA: 0x0002F3C4 File Offset: 0x0002D5C4
		public HttpListener()
		{
			Hashtable hashtable;
			this.connections = hashtable;
			this.auth_schemes = AuthenticationSchemes.Anonymous;
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000ECC RID: 3788 RVA: 0x0002F3EC File Offset: 0x0002D5EC
		// (set) Token: 0x06000ECD RID: 3789 RVA: 0x0002F400 File Offset: 0x0002D600
		public AuthenticationSchemes AuthenticationSchemes
		{
			get
			{
				return this.auth_schemes;
			}
			set
			{
				this.CheckDisposed();
				this.auth_schemes = value;
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000ECE RID: 3790 RVA: 0x0002F41C File Offset: 0x0002D61C
		// (set) Token: 0x06000ECF RID: 3791 RVA: 0x0002F430 File Offset: 0x0002D630
		public AuthenticationSchemeSelector AuthenticationSchemeSelectorDelegate
		{
			get
			{
				return this.auth_selector;
			}
			set
			{
				this.CheckDisposed();
				this.auth_selector = value;
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000ED0 RID: 3792 RVA: 0x0002F44C File Offset: 0x0002D64C
		// (set) Token: 0x06000ED1 RID: 3793 RVA: 0x0002F460 File Offset: 0x0002D660
		public HttpListener.ExtendedProtectionSelector ExtendedProtectionSelectorDelegate
		{
			get
			{
				return this.extendedProtectionSelectorDelegate;
			}
			set
			{
				/*
An exception occurred when decompiling this method (06000ED1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Net.HttpListener::set_ExtendedProtectionSelectorDelegate(System.Net.HttpListener/ExtendedProtectionSelector)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0009:
	stloc:string(var_0_13, call:string(SR::GetString, ldstr:string("This operation requires OS support for extended protection.")))
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
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000ED2 RID: 3794 RVA: 0x0002F480 File Offset: 0x0002D680
		// (set) Token: 0x06000ED3 RID: 3795 RVA: 0x0002F494 File Offset: 0x0002D694
		public bool IgnoreWriteExceptions
		{
			get
			{
				return this.ignore_write_exceptions;
			}
			set
			{
				this.CheckDisposed();
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000ED4 RID: 3796 RVA: 0x0002F4A8 File Offset: 0x0002D6A8
		public bool IsListening
		{
			get
			{
				return this.listening;
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000ED5 RID: 3797 RVA: 0x0002F4BC File Offset: 0x0002D6BC
		public static bool IsSupported
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000ED6 RID: 3798 RVA: 0x0002F4CC File Offset: 0x0002D6CC
		public HttpListenerPrefixCollection Prefixes
		{
			get
			{
				this.CheckDisposed();
				return this.prefixes;
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000ED7 RID: 3799 RVA: 0x00002050 File Offset: 0x00000250
		[MonoTODO]
		public HttpListenerTimeoutManager TimeoutManager
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000ED8 RID: 3800 RVA: 0x0002F4E8 File Offset: 0x0002D6E8
		// (set) Token: 0x06000ED9 RID: 3801 RVA: 0x0002F4FC File Offset: 0x0002D6FC
		[MonoTODO("not used anywhere in the implementation")]
		public global::System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy ExtendedProtectionPolicy
		{
			get
			{
				return this.extendedProtectionPolicy;
			}
			set
			{
				do
				{
					this.CheckDisposed();
					if (value == null)
					{
						goto IL_0020;
					}
					global::System.Security.Authentication.ExtendedProtection.PolicyEnforcement policyEnforcement = value.PolicyEnforcement;
				}
				while (value.CustomChannelBinding != null);
				this.extendedProtectionPolicy = value;
				return;
				IL_0020:
				string @string = SR.GetString("This operation requires OS support for extended protection.");
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000EDA RID: 3802 RVA: 0x0002F534 File Offset: 0x0002D734
		public global::System.Security.Authentication.ExtendedProtection.ServiceNameCollection DefaultServiceNames
		{
			get
			{
				return this.defaultServiceNames.ServiceNames;
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000EDB RID: 3803 RVA: 0x0002F54C File Offset: 0x0002D74C
		// (set) Token: 0x06000EDC RID: 3804 RVA: 0x0002F560 File Offset: 0x0002D760
		public string Realm
		{
			get
			{
				return this.realm;
			}
			set
			{
				this.CheckDisposed();
				this.realm = value;
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000EDD RID: 3805 RVA: 0x0002F57C File Offset: 0x0002D77C
		// (set) Token: 0x06000EDE RID: 3806 RVA: 0x0002F590 File Offset: 0x0002D790
		[MonoTODO("Support for NTLM needs some loving.")]
		public bool UnsafeConnectionNtlmAuthentication
		{
			get
			{
				return this.unsafe_ntlm_auth;
			}
			set
			{
				this.CheckDisposed();
			}
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x0002F5A4 File Offset: 0x0002D7A4
		public void Abort()
		{
			while (!this.disposed)
			{
				if (this.listening)
				{
					this.Close(true);
					return;
				}
			}
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x0002F5CC File Offset: 0x0002D7CC
		public void Close()
		{
			if (!this.disposed)
			{
				if (this.listening)
				{
					this.Close(true);
				}
				this.disposed = true;
			}
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x0002F5F8 File Offset: 0x0002D7F8
		private void Close(bool force)
		{
			this.CheckDisposed();
			if (!true)
			{
			}
			EndPointManager.RemoveListener(this);
			this.Cleanup(force);
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x0002F61C File Offset: 0x0002D81C
		private void Cleanup(bool close_existing)
		{
			object internalLock = this._internalLock;
			Monitor.Enter(internalLock, close_existing);
			Hashtable hashtable = this.registry;
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x0002F7F4 File Offset: 0x0002D9F4
		public IAsyncResult BeginGetContext(AsyncCallback callback, object state)
		{
			this.CheckDisposed();
			if (this.listening)
			{
				ArrayList arrayList = this.wait_queue;
				ArrayList arrayList2 = this.ctx_queue;
				if (this.GetContextFromQueue() != null)
				{
				}
				long num = 0L;
				Monitor.Exit(arrayList2);
				if (num != 0L)
				{
					throw new OutOfMemoryException();
				}
				if (7 == 0)
				{
					ArrayList arrayList3 = this.wait_queue;
				}
				long num2 = 0L;
				Monitor.Exit(arrayList);
				if (num2 == 0L)
				{
				}
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x0002F878 File Offset: 0x0002DA78
		public HttpListenerContext EndGetContext(IAsyncResult asyncResult)
		{
			this.CheckDisposed();
			if (asyncResult != null)
			{
				long num = 0L;
				ArrayList arrayList = this.wait_queue;
				Monitor.Enter(arrayList, num != 0L);
				ArrayList arrayList2 = this.wait_queue;
				ArrayList arrayList3 = this.wait_queue;
				long num2 = 0L;
				int num3 = 13;
				Monitor.Exit(arrayList);
				if (num2 == 0L && num3 == 0)
				{
					AuthenticationSchemeSelector authenticationSchemeSelector = this.auth_selector;
					if (authenticationSchemeSelector != null)
					{
						object[] items = arrayList._items;
						IntPtr invoke_impl = authenticationSchemeSelector.invoke_impl;
						IntPtr method_code = authenticationSchemeSelector.method_code;
						IntPtr method = authenticationSchemeSelector.method;
					}
					AuthenticationSchemes authenticationSchemes = this.auth_schemes;
				}
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x0002F920 File Offset: 0x0002DB20
		internal AuthenticationSchemes SelectAuthenticationScheme(HttpListenerContext context)
		{
			/*
An exception occurred when decompiling this method (06000EE5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.AuthenticationSchemes System.Net.HttpListener::SelectAuthenticationScheme(System.Net.HttpListenerContext)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:HttpListenerRequest(var_1_10, ldfld:HttpListenerRequest(HttpListenerContext::request, ldloc:HttpListenerContext(context)))
	stloc:native int(var_2_17, ldfld:native int(Delegate::invoke_impl, ldloc:AuthenticationSchemeSelector[exp:Delegate](var_0_06)))
	stloc:native int(var_3_1E, ldfld:native int(Delegate::method_code, ldloc:AuthenticationSchemeSelector[exp:Delegate](var_0_06)))
	stloc:native int(var_4_25, ldfld:native int(Delegate::method, ldloc:AuthenticationSchemeSelector[exp:Delegate](var_0_06)))
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

		// Token: 0x06000EE6 RID: 3814 RVA: 0x0002F954 File Offset: 0x0002DB54
		public HttpListenerContext GetContext()
		{
			while (this.prefixes.prefixes._size == 0)
			{
			}
			IAsyncResult asyncResult;
			if (asyncResult != null)
			{
			}
			return this.EndGetContext(asyncResult);
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x0002F988 File Offset: 0x0002DB88
		public void Start()
		{
			this.CheckDisposed();
			if (!this.listening)
			{
				EndPointManager.AddListener(this);
				this.listening = true;
			}
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x0002F9B0 File Offset: 0x0002DBB0
		public void Stop()
		{
			this.CheckDisposed();
			long num = 0L;
			this.Close(num != 0L);
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x0002F9CC File Offset: 0x0002DBCC
		void IDisposable.Dispose()
		{
			if (!this.disposed)
			{
				this.Close(true);
				this.disposed = true;
			}
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x00002050 File Offset: 0x00000250
		public Task<HttpListenerContext> GetContextAsync()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x0002F9F0 File Offset: 0x0002DBF0
		internal void CheckDisposed()
		{
			/*
An exception occurred when decompiling this method (06000EEB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Net.HttpListener::CheckDisposed()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0009:
	stloc:Type(var_0_0F, call:Type(object::GetType, ldloc:HttpListener[exp:object](this)))
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

		// Token: 0x06000EEC RID: 3820 RVA: 0x0002FA0C File Offset: 0x0002DC0C
		private HttpListenerContext GetContextFromQueue()
		{
			while (this.ctx_queue != null)
			{
				ArrayList arrayList = this.ctx_queue;
				ArrayList arrayList2 = this.ctx_queue;
				if (arrayList != null)
				{
					throw new InvalidCastException();
				}
			}
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x0002FA3C File Offset: 0x0002DC3C
		internal void RegisterContext(HttpListenerContext context)
		{
			object internalLock = this._internalLock;
			Hashtable hashtable = this.registry;
			long num = 0L;
			long num2 = 0L;
			Monitor.Exit(internalLock);
			if (num != 0L)
			{
				throw new OutOfMemoryException();
			}
			ArrayList arrayList = this.wait_queue;
			Monitor.Enter(arrayList, num2 != 0L);
			ArrayList arrayList2;
			long num3;
			if (this.wait_queue != null)
			{
				arrayList2 = this.wait_queue;
				if (arrayList2 != null)
				{
				}
				ArrayList arrayList3 = this.wait_queue;
				num3 = 0L;
				return;
			}
			Monitor.Enter(arrayList2, num3 != 0L);
			long num4 = 0L;
			int num5 = 4;
			Monitor.Exit(arrayList2);
			if (num4 != 0L)
			{
				throw new OutOfMemoryException();
			}
			while (num5 == 0)
			{
			}
			long num6 = 0L;
			long num7 = 0L;
			Monitor.Exit(arrayList);
			if (num6 == 0L)
			{
				if (num7 != 0L)
				{
				}
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x0002FB2C File Offset: 0x0002DD2C
		internal void UnregisterContext(HttpListenerContext context)
		{
			object internalLock = this._internalLock;
			Hashtable hashtable = this.registry;
			long num = 0L;
			long num2 = 0L;
			Monitor.Exit(internalLock);
			if (num != 0L)
			{
				throw new OutOfMemoryException();
			}
			ArrayList arrayList = this.ctx_queue;
			Monitor.Enter(arrayList, num2 != 0L);
			ArrayList arrayList2 = this.ctx_queue;
			ArrayList arrayList3 = this.ctx_queue;
			long num3 = 0L;
			Monitor.Exit(arrayList);
			if (num3 == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x0002FBC4 File Offset: 0x0002DDC4
		internal void AddConnection(HttpConnection cnc)
		{
			Hashtable hashtable = this.connections;
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x0002FBD8 File Offset: 0x0002DDD8
		internal void RemoveConnection(HttpConnection cnc)
		{
			Hashtable hashtable = this.connections;
		}

		// Token: 0x04000C15 RID: 3093
		private MonoTlsProvider tlsProvider;

		// Token: 0x04000C16 RID: 3094
		private MonoTlsSettings tlsSettings;

		// Token: 0x04000C17 RID: 3095
		private X509Certificate certificate;

		// Token: 0x04000C18 RID: 3096
		private AuthenticationSchemes auth_schemes;

		// Token: 0x04000C19 RID: 3097
		private HttpListenerPrefixCollection prefixes;

		// Token: 0x04000C1A RID: 3098
		private AuthenticationSchemeSelector auth_selector;

		// Token: 0x04000C1B RID: 3099
		private string realm;

		// Token: 0x04000C1C RID: 3100
		private bool ignore_write_exceptions;

		// Token: 0x04000C1D RID: 3101
		private bool unsafe_ntlm_auth;

		// Token: 0x04000C1E RID: 3102
		private bool listening;

		// Token: 0x04000C1F RID: 3103
		private bool disposed;

		// Token: 0x04000C20 RID: 3104
		private readonly object _internalLock;

		// Token: 0x04000C21 RID: 3105
		private Hashtable registry;

		// Token: 0x04000C22 RID: 3106
		private ArrayList ctx_queue;

		// Token: 0x04000C23 RID: 3107
		private ArrayList wait_queue;

		// Token: 0x04000C24 RID: 3108
		private Hashtable connections;

		// Token: 0x04000C25 RID: 3109
		private ServiceNameStore defaultServiceNames;

		// Token: 0x04000C26 RID: 3110
		private global::System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy extendedProtectionPolicy;

		// Token: 0x04000C27 RID: 3111
		private HttpListener.ExtendedProtectionSelector extendedProtectionSelectorDelegate;

		// Token: 0x0200024A RID: 586
		public sealed class ExtendedProtectionSelector : MulticastDelegate
		{
			// Token: 0x06000EF1 RID: 3825 RVA: 0x0002FBEC File Offset: 0x0002DDEC
			public ExtendedProtectionSelector(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06000EF2 RID: 3826 RVA: 0x0002FC40 File Offset: 0x0002DE40
			public global::System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy Invoke(HttpListenerRequest request)
			{
				/*
An exception occurred when decompiling this method (06000EF2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy System.Net.HttpListener/ExtendedProtectionSelector::Invoke(System.Net.HttpListenerRequest)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(Delegate::method_code, ldloc:ExtendedProtectionSelector[exp:Delegate](this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:ExtendedProtectionSelector[exp:Delegate](this)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method, ldloc:ExtendedProtectionSelector[exp:Delegate](this)))
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

			// Token: 0x06000EF3 RID: 3827 RVA: 0x00002050 File Offset: 0x00000250
			public IAsyncResult BeginInvoke(HttpListenerRequest request, AsyncCallback callback, object @object)
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06000EF4 RID: 3828 RVA: 0x00002050 File Offset: 0x00000250
			public global::System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy EndInvoke(IAsyncResult result)
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}
	}
}
