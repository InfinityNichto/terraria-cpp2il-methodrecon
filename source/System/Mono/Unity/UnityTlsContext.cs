using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Cpp2IlInjected;
using Mono.Net.Security;
using Mono.Security.Cryptography;
using Mono.Security.Interface;
using Mono.Util;

namespace Mono.Unity
{
	// Token: 0x02000044 RID: 68
	internal class UnityTlsContext : Mono.Net.Security.MobileTlsContext
	{
		// Token: 0x06000089 RID: 137 RVA: 0x000027E8 File Offset: 0x000009E8
		public UnityTlsContext(Mono.Net.Security.MobileAuthenticatedStream parent, Mono.Net.Security.MonoSslAuthenticationOptions options)
			: base(parent, options)
		{
			GCHandle gchandle = GCHandle.Alloc(this);
			this.handle = gchandle;
			UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t unitytls_errorstate_create = UnityTls.NativeInterface.unitytls_errorstate_create;
			IntPtr invoke_impl = unitytls_errorstate_create.invoke_impl;
			IntPtr method_code = unitytls_errorstate_create.method_code;
			IntPtr method = unitytls_errorstate_create.method;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002B70 File Offset: 0x00000D70
		private unsafe static void ExtractNativeKeyAndChainFromManagedCertificate(X509Certificate cert, UnityTls.unitytls_errorstate* errorState, [Out] UnityTls.unitytls_x509list* nativeCertChain, [Out] UnityTls.unitytls_key* nativeKey)
		{
			if (cert == null)
			{
				return;
			}
			AsymmetricAlgorithm asymmetricAlgorithm;
			if (asymmetricAlgorithm == null)
			{
				return;
			}
			UnityTls.unitytls_interface_struct.unitytls_x509list_create_t unitytls_x509list_create = UnityTls.NativeInterface.unitytls_x509list_create;
			IntPtr method_code = unitytls_x509list_create.method_code;
			IntPtr invoke_impl = unitytls_x509list_create.invoke_impl;
			IntPtr method = unitytls_x509list_create.method;
			AsymmetricAlgorithm asymmetricAlgorithm2;
			if (PKCS8.PrivateKeyInfo.Encode(asymmetricAlgorithm2) != null)
			{
				return;
			}
			UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t unitytls_key_parse_der = UnityTls.NativeInterface.unitytls_key_parse_der;
			IntPtr intPtr = (IntPtr)0;
			IntPtr method_code2 = unitytls_key_parse_der.method_code;
			IntPtr invoke_impl2 = unitytls_key_parse_der.invoke_impl;
			IntPtr method2 = unitytls_key_parse_der.method;
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00002C4C File Offset: 0x00000E4C
		public override bool IsAuthenticated
		{
			get
			{
				return this.isAuthenticated;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00002C60 File Offset: 0x00000E60
		internal override X509Certificate LocalClientCertificate
		{
			get
			{
				return this.localClientCertificate;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00002C74 File Offset: 0x00000E74
		public override global::System.Security.Cryptography.X509Certificates.X509Certificate2 RemoteCertificate
		{
			get
			{
				return this.remoteCertificate;
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002C88 File Offset: 0x00000E88
		public override ValueTuple<int, bool> Read(byte[] buffer, int offset, int count)
		{
			/*
An exception occurred when decompiling this method (0600008E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.ValueTuple`2<System.Int32,System.Boolean> Mono.Unity.UnityTlsContext::Read(System.Byte[],System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0075:
	brtrue(IL_0000, ldfld:bool(UnityTlsContext::closedGraceful, ldloc:UnityTlsContext(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x0600008F RID: 143 RVA: 0x00002D14 File Offset: 0x00000F14
		public override ValueTuple<int, bool> Write(byte[] buffer, int offset, int count)
		{
			/*
An exception occurred when decompiling this method (0600008F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.ValueTuple`2<System.Int32,System.Boolean> Mono.Unity.UnityTlsContext::Write(System.Byte[],System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	brtrue(IL_0000, ldloc:native int[exp:bool](var_7_49))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x06000090 RID: 144 RVA: 0x00002050 File Offset: 0x00000250
		public override void Renegotiate()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002D98 File Offset: 0x00000F98
		public override bool PendingRenegotiation()
		{
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002DA8 File Offset: 0x00000FA8
		public unsafe override void Shutdown()
		{
			MonoTlsSettings <Settings>k__BackingField = this.<Parent>k__BackingField.<Settings>k__BackingField;
			if (<Settings>k__BackingField != null && <Settings>k__BackingField.<SendCloseNotify>k__BackingField)
			{
				UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t unitytls_errorstate_create = UnityTls.NativeInterface.unitytls_errorstate_create;
				IntPtr invoke_impl = unitytls_errorstate_create.invoke_impl;
				IntPtr method_code = unitytls_errorstate_create.method_code;
				IntPtr method = unitytls_errorstate_create.method;
				UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t unitytls_tlsctx_notify_close = UnityTls.NativeInterface.unitytls_tlsctx_notify_close;
				UnityTls.unitytls_tlsctx* ptr = this.tlsContext;
				IntPtr invoke_impl2 = unitytls_tlsctx_notify_close.invoke_impl;
				IntPtr method_code2 = unitytls_tlsctx_notify_close.method_code;
				IntPtr method2 = unitytls_tlsctx_notify_close.method;
			}
			UnityTls.unitytls_interface_struct.unitytls_x509list_free_t unitytls_x509list_free = UnityTls.NativeInterface.unitytls_x509list_free;
			UnityTls.unitytls_x509list* ptr2 = this.requestedClientCertChain;
			IntPtr invoke_impl3 = unitytls_x509list_free.invoke_impl;
			IntPtr method_code3 = unitytls_x509list_free.method_code;
			IntPtr method3 = unitytls_x509list_free.method;
			UnityTls.unitytls_interface_struct.unitytls_key_free_t unitytls_key_free = UnityTls.NativeInterface.unitytls_key_free;
			UnityTls.unitytls_key* ptr3 = this.requestedClientKey;
			IntPtr invoke_impl4 = unitytls_key_free.invoke_impl;
			IntPtr method_code4 = unitytls_key_free.method_code;
			IntPtr method4 = unitytls_key_free.method;
			UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t unitytls_tlsctx_free = UnityTls.NativeInterface.unitytls_tlsctx_free;
			UnityTls.unitytls_tlsctx* ptr4 = this.tlsContext;
			IntPtr invoke_impl5 = unitytls_tlsctx_free.invoke_impl;
			IntPtr method_code5 = unitytls_tlsctx_free.method_code;
			IntPtr method5 = unitytls_tlsctx_free.method;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002EAC File Offset: 0x000010AC
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002EC8 File Offset: 0x000010C8
		public unsafe override void StartHandshake()
		{
			MonoTlsSettings <Settings>k__BackingField = this.<Parent>k__BackingField.<Settings>k__BackingField;
			if (<Settings>k__BackingField != null && <Settings>k__BackingField.<EnabledCiphers>k__BackingField != null)
			{
				Mono.Net.Security.MobileAuthenticatedStream <Parent>k__BackingField = this.<Parent>k__BackingField;
				CipherSuiteCode[] <EnabledCiphers>k__BackingField = <Parent>k__BackingField.<Settings>k__BackingField.<EnabledCiphers>k__BackingField;
				UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t unitytls_errorstate_create = UnityTls.NativeInterface.unitytls_errorstate_create;
				IntPtr invoke_impl = unitytls_errorstate_create.invoke_impl;
				IntPtr method_code = unitytls_errorstate_create.method_code;
				IntPtr method = unitytls_errorstate_create.method;
				UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t unitytls_tlsctx_set_supported_ciphersuites = UnityTls.NativeInterface.unitytls_tlsctx_set_supported_ciphersuites;
				UnityTls.unitytls_tlsctx* ptr = this.tlsContext;
				IntPtr method_code2 = unitytls_tlsctx_set_supported_ciphersuites.method_code;
				IntPtr invoke_impl2 = unitytls_tlsctx_set_supported_ciphersuites.invoke_impl;
				IntPtr method2 = unitytls_tlsctx_set_supported_ciphersuites.method;
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002F58 File Offset: 0x00001158
		public unsafe override bool ProcessHandshake()
		{
			do
			{
				UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t unitytls_errorstate_create = UnityTls.NativeInterface.unitytls_errorstate_create;
				IntPtr invoke_impl = unitytls_errorstate_create.invoke_impl;
				IntPtr method_code = unitytls_errorstate_create.method_code;
				IntPtr method = unitytls_errorstate_create.method;
				UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t unitytls_tlsctx_process_handshake = UnityTls.NativeInterface.unitytls_tlsctx_process_handshake;
				UnityTls.unitytls_tlsctx* ptr = this.tlsContext;
				IntPtr invoke_impl2 = unitytls_tlsctx_process_handshake.invoke_impl;
				IntPtr method_code2 = unitytls_tlsctx_process_handshake.method_code;
				IntPtr method2 = unitytls_tlsctx_process_handshake.method;
			}
			while (this.lastException != null);
			if (this.<IsServer>k__BackingField)
			{
			}
			return true;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002FC8 File Offset: 0x000011C8
		public unsafe override void FinishHandshake()
		{
			UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t unitytls_errorstate_create = UnityTls.NativeInterface.unitytls_errorstate_create;
			IntPtr invoke_impl = unitytls_errorstate_create.invoke_impl;
			IntPtr method_code = unitytls_errorstate_create.method_code;
			IntPtr method = unitytls_errorstate_create.method;
			UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t unitytls_tlsctx_get_ciphersuite = UnityTls.NativeInterface.unitytls_tlsctx_get_ciphersuite;
			UnityTls.unitytls_tlsctx* ptr = this.tlsContext;
			IntPtr invoke_impl2 = unitytls_tlsctx_get_ciphersuite.invoke_impl;
			IntPtr method_code2 = unitytls_tlsctx_get_ciphersuite.method_code;
			IntPtr method2 = unitytls_tlsctx_get_ciphersuite.method;
			UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t unitytls_tlsctx_get_protocol = UnityTls.NativeInterface.unitytls_tlsctx_get_protocol;
			UnityTls.unitytls_tlsctx* ptr2 = this.tlsContext;
			IntPtr invoke_impl3 = unitytls_tlsctx_get_protocol.invoke_impl;
			IntPtr method_code3 = unitytls_tlsctx_get_protocol.method_code;
			IntPtr method3 = unitytls_tlsctx_get_protocol.method;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00003068 File Offset: 0x00001268
		[Mono.Util.MonoPInvokeCallback(typeof(UnityTls.unitytls_tlsctx_write_callback))]
		private unsafe static IntPtr WriteCallback(void* userData, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
		{
			IntPtr intPtr;
			if (((GCHandle)intPtr).Target != null)
			{
			}
			IntPtr intPtr2;
			return intPtr2;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000308C File Offset: 0x0000128C
		private unsafe IntPtr WriteCallback(byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
		{
			if (this.writeBuffer != null)
			{
				int num = (int)bufferLen;
			}
			int num2 = (int)bufferLen;
			byte[] array = this.writeBuffer;
			int num3 = (int)bufferLen;
			long num4 = 0L;
			IntPtr intPtr;
			Marshal.Copy(intPtr, array, (int)num4, num3);
			Mono.Net.Security.MobileAuthenticatedStream <Parent>k__BackingField = this.<Parent>k__BackingField;
			byte[] array2 = this.writeBuffer;
			int num5 = (int)bufferLen;
			long num6 = 0L;
			bool flag = <Parent>k__BackingField.InternalWrite(array2, (int)num6, num5);
			UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t unitytls_errorstate_raise_error = UnityTls.NativeInterface.unitytls_errorstate_raise_error;
			IntPtr method_code = unitytls_errorstate_raise_error.method_code;
			IntPtr invoke_impl = unitytls_errorstate_raise_error.invoke_impl;
			IntPtr method = unitytls_errorstate_raise_error.method;
			long num7 = 0L;
			return (IntPtr)((int)num7);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00003188 File Offset: 0x00001388
		[Mono.Util.MonoPInvokeCallback(typeof(UnityTls.unitytls_tlsctx_read_callback))]
		private unsafe static IntPtr ReadCallback(void* userData, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
		{
			IntPtr intPtr;
			if (((GCHandle)intPtr).Target != null)
			{
			}
			IntPtr intPtr2;
			return intPtr2;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000031AC File Offset: 0x000013AC
		private unsafe IntPtr ReadCallback(byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
		{
			if (this.readBuffer != null)
			{
				int num = (int)bufferLen;
			}
			int num2 = (int)bufferLen;
			byte[] array = this.readBuffer;
			Mono.Net.Security.MobileAuthenticatedStream <Parent>k__BackingField = this.<Parent>k__BackingField;
			int num3 = (int)bufferLen;
			int num4;
			if (num4 != 0)
			{
				byte[] array2 = this.readBuffer;
				int num5 = (int)bufferLen;
				long num6 = 0L;
				IntPtr intPtr;
				Marshal.Copy(array2, (int)num6, intPtr, num5);
				UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t unitytls_errorstate_raise_error = UnityTls.NativeInterface.unitytls_errorstate_raise_error;
				IntPtr method_code = unitytls_errorstate_raise_error.method_code;
				IntPtr invoke_impl = unitytls_errorstate_raise_error.invoke_impl;
				IntPtr method = unitytls_errorstate_raise_error.method;
				return method_code;
			}
			UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t unitytls_errorstate_raise_error2 = UnityTls.NativeInterface.unitytls_errorstate_raise_error;
			IntPtr method_code2 = unitytls_errorstate_raise_error2.method_code;
			IntPtr invoke_impl2 = unitytls_errorstate_raise_error2.invoke_impl;
			IntPtr method2 = unitytls_errorstate_raise_error2.method;
			return method_code2;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00003300 File Offset: 0x00001500
		[Mono.Util.MonoPInvokeCallback(typeof(UnityTls.unitytls_tlsctx_x509verify_callback))]
		private unsafe static UnityTls.unitytls_x509verify_result VerifyCallback(void* userData, UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState)
		{
			IntPtr intPtr;
			if (((GCHandle)intPtr).Target != null)
			{
			}
			UnityTls.unitytls_x509verify_result unitytls_x509verify_result;
			return unitytls_x509verify_result;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00003324 File Offset: 0x00001524
		private unsafe UnityTls.unitytls_x509verify_result VerifyCallback(UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState)
		{
			long num = 0L;
			global::System.Security.Cryptography.X509Certificates.X509ChainElementCollection x509ChainElementCollection;
			global::System.Security.Cryptography.X509Certificates.X509Certificate2 certificate = x509ChainElementCollection[(int)num].certificate;
			this.remoteCertificate = certificate;
			long num2 = 0L;
			int num3 = 3;
			if (num2 != 0L || num3 != 0)
			{
				throw new OutOfMemoryException();
			}
			Exception ex;
			if (!false)
			{
				ex = this.lastException;
				if (ex == null)
				{
				}
			}
			long num4 = 0L;
			if (ex != null)
			{
			}
			if (num4 != 0L)
			{
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000033B4 File Offset: 0x000015B4
		[Mono.Util.MonoPInvokeCallback(typeof(UnityTls.unitytls_tlsctx_certificate_callback))]
		private unsafe static void CertificateCallback(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState)
		{
			if (((GCHandle)((IntPtr)userData)).Target != null)
			{
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000033DC File Offset: 0x000015DC
		private unsafe void CertificateCallback(UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState)
		{
			if (this.remoteCertificate == null)
			{
				return;
			}
			X509Certificate x509Certificate;
			this.localClientCertificate = x509Certificate;
			if (x509Certificate != null)
			{
				UnityTls.unitytls_interface_struct.unitytls_x509list_free_t unitytls_x509list_free = UnityTls.NativeInterface.unitytls_x509list_free;
				UnityTls.unitytls_x509list* ptr = this.requestedClientCertChain;
				IntPtr method_code = unitytls_x509list_free.method_code;
				IntPtr invoke_impl = unitytls_x509list_free.invoke_impl;
				IntPtr method = unitytls_x509list_free.method;
				UnityTls.unitytls_interface_struct.unitytls_key_free_t unitytls_key_free = UnityTls.NativeInterface.unitytls_key_free;
				UnityTls.unitytls_key* ptr2 = this.requestedClientKey;
				IntPtr method_code2 = unitytls_key_free.method_code;
				IntPtr invoke_impl2 = unitytls_key_free.invoke_impl;
				IntPtr method2 = unitytls_key_free.method;
				X509Certificate x509Certificate2 = this.localClientCertificate;
				UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t unitytls_x509list_get_ref = UnityTls.NativeInterface.unitytls_x509list_get_ref;
				IntPtr method_code3 = unitytls_x509list_get_ref.method_code;
				IntPtr invoke_impl3 = unitytls_x509list_get_ref.invoke_impl;
				IntPtr method3 = unitytls_x509list_get_ref.method;
				chain->handle = (ulong)method_code3;
				UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t unitytls_key_get_ref = UnityTls.NativeInterface.unitytls_key_get_ref;
				IntPtr method_code4 = unitytls_key_get_ref.method_code;
				IntPtr invoke_impl4 = unitytls_key_get_ref.invoke_impl;
				IntPtr method4 = unitytls_key_get_ref.method;
				return;
			}
			ulong unitytls_INVALID_HANDLE = UnityTls.NativeInterface.UNITYTLS_INVALID_HANDLE;
			chain->handle = unitytls_INVALID_HANDLE;
			ulong unitytls_INVALID_HANDLE2 = UnityTls.NativeInterface.UNITYTLS_INVALID_HANDLE;
			key->handle = unitytls_INVALID_HANDLE2;
		}

		// Token: 0x04000085 RID: 133
		private unsafe UnityTls.unitytls_tlsctx* tlsContext;

		// Token: 0x04000086 RID: 134
		private unsafe UnityTls.unitytls_x509list* requestedClientCertChain;

		// Token: 0x04000087 RID: 135
		private unsafe UnityTls.unitytls_key* requestedClientKey;

		// Token: 0x04000088 RID: 136
		private UnityTls.unitytls_tlsctx_read_callback readCallback;

		// Token: 0x04000089 RID: 137
		private UnityTls.unitytls_tlsctx_write_callback writeCallback;

		// Token: 0x0400008A RID: 138
		private UnityTls.unitytls_tlsctx_certificate_callback certificateCallback;

		// Token: 0x0400008B RID: 139
		private UnityTls.unitytls_tlsctx_x509verify_callback verifyCallback;

		// Token: 0x0400008C RID: 140
		private X509Certificate localClientCertificate;

		// Token: 0x0400008D RID: 141
		private global::System.Security.Cryptography.X509Certificates.X509Certificate2 remoteCertificate;

		// Token: 0x0400008E RID: 142
		private MonoTlsConnectionInfo connectioninfo;

		// Token: 0x0400008F RID: 143
		private bool isAuthenticated;

		// Token: 0x04000090 RID: 144
		private bool hasContext;

		// Token: 0x04000091 RID: 145
		private bool closedGraceful;

		// Token: 0x04000092 RID: 146
		private byte[] writeBuffer;

		// Token: 0x04000093 RID: 147
		private byte[] readBuffer;

		// Token: 0x04000094 RID: 148
		private GCHandle handle;

		// Token: 0x04000095 RID: 149
		private Exception lastException;
	}
}
