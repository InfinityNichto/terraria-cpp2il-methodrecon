using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Mono.Unity
{
	// Token: 0x02000010 RID: 16
	internal static class UnityTls
	{
		// Token: 0x0600003D RID: 61 RVA: 0x00002050 File Offset: 0x00000250
		private static IntPtr GetUnityTlsInterface()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00002500 File Offset: 0x00000700
		public static bool IsSupported
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600003E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Mono.Unity.UnityTls::get_IsSupported()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:unitytls_interface_struct(var_0_05, callgetter:unitytls_interface_struct(UnityTls::get_NativeInterface))
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

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00002050 File Offset: 0x00000250
		public static UnityTls.unitytls_interface_struct NativeInterface
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x0400002E RID: 46
		private static UnityTls.unitytls_interface_struct marshalledInterface;

		// Token: 0x02000011 RID: 17
		public enum unitytls_error_code : uint
		{
			// Token: 0x04000030 RID: 48
			UNITYTLS_SUCCESS,
			// Token: 0x04000031 RID: 49
			UNITYTLS_INVALID_ARGUMENT,
			// Token: 0x04000032 RID: 50
			UNITYTLS_INVALID_FORMAT,
			// Token: 0x04000033 RID: 51
			UNITYTLS_INVALID_PASSWORD,
			// Token: 0x04000034 RID: 52
			UNITYTLS_INVALID_STATE,
			// Token: 0x04000035 RID: 53
			UNITYTLS_BUFFER_OVERFLOW,
			// Token: 0x04000036 RID: 54
			UNITYTLS_OUT_OF_MEMORY,
			// Token: 0x04000037 RID: 55
			UNITYTLS_INTERNAL_ERROR,
			// Token: 0x04000038 RID: 56
			UNITYTLS_NOT_SUPPORTED,
			// Token: 0x04000039 RID: 57
			UNITYTLS_ENTROPY_SOURCE_FAILED,
			// Token: 0x0400003A RID: 58
			UNITYTLS_STREAM_CLOSED,
			// Token: 0x0400003B RID: 59
			UNITYTLS_USER_CUSTOM_ERROR_START = 1048576U,
			// Token: 0x0400003C RID: 60
			UNITYTLS_USER_WOULD_BLOCK,
			// Token: 0x0400003D RID: 61
			UNITYTLS_USER_READ_FAILED,
			// Token: 0x0400003E RID: 62
			UNITYTLS_USER_WRITE_FAILED,
			// Token: 0x0400003F RID: 63
			UNITYTLS_USER_UNKNOWN_ERROR,
			// Token: 0x04000040 RID: 64
			UNITYTLS_USER_CUSTOM_ERROR_END = 2097152U
		}

		// Token: 0x02000012 RID: 18
		public struct unitytls_errorstate
		{
			// Token: 0x04000041 RID: 65
			private uint magic;

			// Token: 0x04000042 RID: 66
			public UnityTls.unitytls_error_code code;

			// Token: 0x04000043 RID: 67
			private ulong reserved;
		}

		// Token: 0x02000013 RID: 19
		public struct unitytls_key
		{
		}

		// Token: 0x02000014 RID: 20
		public struct unitytls_key_ref
		{
			// Token: 0x04000044 RID: 68
			public ulong handle;
		}

		// Token: 0x02000015 RID: 21
		public struct unitytls_x509_ref
		{
			// Token: 0x04000045 RID: 69
			public ulong handle;
		}

		// Token: 0x02000016 RID: 22
		public struct unitytls_x509list
		{
		}

		// Token: 0x02000017 RID: 23
		public struct unitytls_x509list_ref
		{
			// Token: 0x04000046 RID: 70
			public ulong handle;
		}

		// Token: 0x02000018 RID: 24
		[Flags]
		public enum unitytls_x509verify_result : uint
		{
			// Token: 0x04000048 RID: 72
			UNITYTLS_X509VERIFY_SUCCESS = 0U,
			// Token: 0x04000049 RID: 73
			UNITYTLS_X509VERIFY_NOT_DONE = 2147483648U,
			// Token: 0x0400004A RID: 74
			UNITYTLS_X509VERIFY_FATAL_ERROR = 4294967295U,
			// Token: 0x0400004B RID: 75
			UNITYTLS_X509VERIFY_FLAG_EXPIRED = 1U,
			// Token: 0x0400004C RID: 76
			UNITYTLS_X509VERIFY_FLAG_REVOKED = 2U,
			// Token: 0x0400004D RID: 77
			UNITYTLS_X509VERIFY_FLAG_CN_MISMATCH = 4U,
			// Token: 0x0400004E RID: 78
			UNITYTLS_X509VERIFY_FLAG_NOT_TRUSTED = 8U,
			// Token: 0x0400004F RID: 79
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR1 = 65536U,
			// Token: 0x04000050 RID: 80
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR2 = 131072U,
			// Token: 0x04000051 RID: 81
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR3 = 262144U,
			// Token: 0x04000052 RID: 82
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR4 = 524288U,
			// Token: 0x04000053 RID: 83
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR5 = 1048576U,
			// Token: 0x04000054 RID: 84
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR6 = 2097152U,
			// Token: 0x04000055 RID: 85
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR7 = 4194304U,
			// Token: 0x04000056 RID: 86
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR8 = 8388608U,
			// Token: 0x04000057 RID: 87
			UNITYTLS_X509VERIFY_FLAG_UNKNOWN_ERROR = 134217728U
		}

		// Token: 0x02000019 RID: 25
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public sealed class unitytls_x509verify_callback : MulticastDelegate
		{
			// Token: 0x06000040 RID: 64 RVA: 0x00002514 File Offset: 0x00000714
			public unitytls_x509verify_callback(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06000041 RID: 65 RVA: 0x00002568 File Offset: 0x00000768
			public unsafe UnityTls.unitytls_x509verify_result Invoke(void* userData, UnityTls.unitytls_x509_ref cert, UnityTls.unitytls_x509verify_result result, UnityTls.unitytls_errorstate* errorState)
			{
				/*
An exception occurred when decompiling this method (06000041)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Mono.Unity.UnityTls/unitytls_x509verify_result Mono.Unity.UnityTls/unitytls_x509verify_callback::Invoke(System.Void*,Mono.Unity.UnityTls/unitytls_x509_ref,Mono.Unity.UnityTls/unitytls_x509verify_result,Mono.Unity.UnityTls/unitytls_errorstate*)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(Delegate::method_code, ldloc:unitytls_x509verify_callback[exp:Delegate](this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:unitytls_x509verify_callback[exp:Delegate](this)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method, ldloc:unitytls_x509verify_callback[exp:Delegate](this)))
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

		// Token: 0x0200001A RID: 26
		public struct unitytls_tlsctx
		{
		}

		// Token: 0x0200001B RID: 27
		public struct unitytls_x509name
		{
		}

		// Token: 0x0200001C RID: 28
		public enum unitytls_ciphersuite : uint
		{
			// Token: 0x04000059 RID: 89
			UNITYTLS_CIPHERSUITE_INVALID = 16777215U
		}

		// Token: 0x0200001D RID: 29
		public enum unitytls_protocol : uint
		{
			// Token: 0x0400005B RID: 91
			UNITYTLS_PROTOCOL_TLS_1_0,
			// Token: 0x0400005C RID: 92
			UNITYTLS_PROTOCOL_TLS_1_1,
			// Token: 0x0400005D RID: 93
			UNITYTLS_PROTOCOL_TLS_1_2,
			// Token: 0x0400005E RID: 94
			UNITYTLS_PROTOCOL_INVALID
		}

		// Token: 0x0200001E RID: 30
		public struct unitytls_tlsctx_protocolrange
		{
			// Token: 0x0400005F RID: 95
			public UnityTls.unitytls_protocol min;

			// Token: 0x04000060 RID: 96
			public UnityTls.unitytls_protocol max;
		}

		// Token: 0x0200001F RID: 31
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public sealed class unitytls_tlsctx_write_callback : MulticastDelegate
		{
			// Token: 0x06000042 RID: 66 RVA: 0x0000258C File Offset: 0x0000078C
			public unitytls_tlsctx_write_callback(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06000043 RID: 67 RVA: 0x000025E0 File Offset: 0x000007E0
			public unsafe IntPtr Invoke(void* userData, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
				return method_code;
			}
		}

		// Token: 0x02000020 RID: 32
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public sealed class unitytls_tlsctx_read_callback : MulticastDelegate
		{
			// Token: 0x06000044 RID: 68 RVA: 0x00002604 File Offset: 0x00000804
			public unitytls_tlsctx_read_callback(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06000045 RID: 69 RVA: 0x00002658 File Offset: 0x00000858
			public unsafe IntPtr Invoke(void* userData, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
				return method_code;
			}
		}

		// Token: 0x02000021 RID: 33
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public sealed class unitytls_tlsctx_trace_callback : MulticastDelegate
		{
			// Token: 0x06000046 RID: 70 RVA: 0x0000267C File Offset: 0x0000087C
			public unitytls_tlsctx_trace_callback(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06000047 RID: 71 RVA: 0x000026D0 File Offset: 0x000008D0
			public unsafe void Invoke(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* traceMessage, IntPtr traceMessageLen)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}
		}

		// Token: 0x02000022 RID: 34
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public sealed class unitytls_tlsctx_certificate_callback : MulticastDelegate
		{
			// Token: 0x06000048 RID: 72 RVA: 0x000026F4 File Offset: 0x000008F4
			public unitytls_tlsctx_certificate_callback(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.method_code = this;
			}

			// Token: 0x06000049 RID: 73 RVA: 0x00002738 File Offset: 0x00000938
			public unsafe void Invoke(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState)
			{
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
				IntPtr method_code = this.method_code;
			}
		}

		// Token: 0x02000023 RID: 35
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public sealed class unitytls_tlsctx_x509verify_callback : MulticastDelegate
		{
			// Token: 0x0600004A RID: 74 RVA: 0x0000275C File Offset: 0x0000095C
			public unitytls_tlsctx_x509verify_callback(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x0600004B RID: 75 RVA: 0x000027B0 File Offset: 0x000009B0
			public unsafe UnityTls.unitytls_x509verify_result Invoke(void* userData, UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState)
			{
				/*
An exception occurred when decompiling this method (0600004B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Mono.Unity.UnityTls/unitytls_x509verify_result Mono.Unity.UnityTls/unitytls_tlsctx_x509verify_callback::Invoke(System.Void*,Mono.Unity.UnityTls/unitytls_x509list_ref,Mono.Unity.UnityTls/unitytls_errorstate*)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(Delegate::method_code, ldloc:unitytls_tlsctx_x509verify_callback[exp:Delegate](this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:unitytls_tlsctx_x509verify_callback[exp:Delegate](this)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method, ldloc:unitytls_tlsctx_x509verify_callback[exp:Delegate](this)))
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

		// Token: 0x02000024 RID: 36
		public struct unitytls_tlsctx_callbacks
		{
			// Token: 0x04000061 RID: 97
			public UnityTls.unitytls_tlsctx_read_callback read;

			// Token: 0x04000062 RID: 98
			public UnityTls.unitytls_tlsctx_write_callback write;

			// Token: 0x04000063 RID: 99
			public unsafe void* data;
		}

		// Token: 0x02000025 RID: 37
		[StructLayout(0)]
		public class unitytls_interface_struct
		{
			// Token: 0x0600004C RID: 76 RVA: 0x000027D4 File Offset: 0x000009D4
			public unitytls_interface_struct()
			{
			}

			// Token: 0x04000064 RID: 100
			public readonly ulong UNITYTLS_INVALID_HANDLE;

			// Token: 0x04000065 RID: 101
			public readonly UnityTls.unitytls_tlsctx_protocolrange UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT;

			// Token: 0x04000066 RID: 102
			public UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t unitytls_errorstate_create;

			// Token: 0x04000067 RID: 103
			public UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t unitytls_errorstate_raise_error;

			// Token: 0x04000068 RID: 104
			public UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t unitytls_key_get_ref;

			// Token: 0x04000069 RID: 105
			public UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t unitytls_key_parse_der;

			// Token: 0x0400006A RID: 106
			public UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t unitytls_key_parse_pem;

			// Token: 0x0400006B RID: 107
			public UnityTls.unitytls_interface_struct.unitytls_key_free_t unitytls_key_free;

			// Token: 0x0400006C RID: 108
			public UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t unitytls_x509_export_der;

			// Token: 0x0400006D RID: 109
			public UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t unitytls_x509list_get_ref;

			// Token: 0x0400006E RID: 110
			public UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t unitytls_x509list_get_x509;

			// Token: 0x0400006F RID: 111
			public UnityTls.unitytls_interface_struct.unitytls_x509list_create_t unitytls_x509list_create;

			// Token: 0x04000070 RID: 112
			public UnityTls.unitytls_interface_struct.unitytls_x509list_append_t unitytls_x509list_append;

			// Token: 0x04000071 RID: 113
			public UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t unitytls_x509list_append_der;

			// Token: 0x04000072 RID: 114
			public UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t unitytls_x509list_append_pem;

			// Token: 0x04000073 RID: 115
			public UnityTls.unitytls_interface_struct.unitytls_x509list_free_t unitytls_x509list_free;

			// Token: 0x04000074 RID: 116
			public UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t unitytls_x509verify_default_ca;

			// Token: 0x04000075 RID: 117
			public UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t unitytls_x509verify_explicit_ca;

			// Token: 0x04000076 RID: 118
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t unitytls_tlsctx_create_server;

			// Token: 0x04000077 RID: 119
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t unitytls_tlsctx_create_client;

			// Token: 0x04000078 RID: 120
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t unitytls_tlsctx_server_require_client_authentication;

			// Token: 0x04000079 RID: 121
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t unitytls_tlsctx_set_certificate_callback;

			// Token: 0x0400007A RID: 122
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t unitytls_tlsctx_set_trace_callback;

			// Token: 0x0400007B RID: 123
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t unitytls_tlsctx_set_x509verify_callback;

			// Token: 0x0400007C RID: 124
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t unitytls_tlsctx_set_supported_ciphersuites;

			// Token: 0x0400007D RID: 125
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t unitytls_tlsctx_get_ciphersuite;

			// Token: 0x0400007E RID: 126
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t unitytls_tlsctx_get_protocol;

			// Token: 0x0400007F RID: 127
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t unitytls_tlsctx_process_handshake;

			// Token: 0x04000080 RID: 128
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t unitytls_tlsctx_read;

			// Token: 0x04000081 RID: 129
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t unitytls_tlsctx_write;

			// Token: 0x04000082 RID: 130
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t unitytls_tlsctx_notify_close;

			// Token: 0x04000083 RID: 131
			public UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t unitytls_tlsctx_free;

			// Token: 0x04000084 RID: 132
			public UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t unitytls_random_generate_bytes;

			// Token: 0x02000026 RID: 38
			// (Invoke) Token: 0x0600004E RID: 78
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate UnityTls.unitytls_errorstate unitytls_errorstate_create_t();

			// Token: 0x02000027 RID: 39
			// (Invoke) Token: 0x06000050 RID: 80
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate void unitytls_errorstate_raise_error_t(UnityTls.unitytls_errorstate* errorState, UnityTls.unitytls_error_code errorCode);

			// Token: 0x02000028 RID: 40
			// (Invoke) Token: 0x06000052 RID: 82
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate UnityTls.unitytls_key_ref unitytls_key_get_ref_t(UnityTls.unitytls_key* key, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x02000029 RID: 41
			// (Invoke) Token: 0x06000054 RID: 84
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate UnityTls.unitytls_key* unitytls_key_parse_der_t(byte* buffer, IntPtr bufferLen, byte* password, IntPtr passwordLen, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x0200002A RID: 42
			// (Invoke) Token: 0x06000056 RID: 86
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate UnityTls.unitytls_key* unitytls_key_parse_pem_t(byte* buffer, IntPtr bufferLen, byte* password, IntPtr passwordLen, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x0200002B RID: 43
			// (Invoke) Token: 0x06000058 RID: 88
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate void unitytls_key_free_t(UnityTls.unitytls_key* key);

			// Token: 0x0200002C RID: 44
			// (Invoke) Token: 0x0600005A RID: 90
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate IntPtr unitytls_x509_export_der_t(UnityTls.unitytls_x509_ref cert, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x0200002D RID: 45
			// (Invoke) Token: 0x0600005C RID: 92
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate UnityTls.unitytls_x509list_ref unitytls_x509list_get_ref_t(UnityTls.unitytls_x509list* list, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x0200002E RID: 46
			// (Invoke) Token: 0x0600005E RID: 94
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate UnityTls.unitytls_x509_ref unitytls_x509list_get_x509_t(UnityTls.unitytls_x509list_ref list, IntPtr index, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x0200002F RID: 47
			// (Invoke) Token: 0x06000060 RID: 96
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate UnityTls.unitytls_x509list* unitytls_x509list_create_t(UnityTls.unitytls_errorstate* errorState);

			// Token: 0x02000030 RID: 48
			// (Invoke) Token: 0x06000062 RID: 98
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate void unitytls_x509list_append_t(UnityTls.unitytls_x509list* list, UnityTls.unitytls_x509_ref cert, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x02000031 RID: 49
			// (Invoke) Token: 0x06000064 RID: 100
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate void unitytls_x509list_append_der_t(UnityTls.unitytls_x509list* list, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x02000032 RID: 50
			// (Invoke) Token: 0x06000066 RID: 102
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate void unitytls_x509list_free_t(UnityTls.unitytls_x509list* list);

			// Token: 0x02000033 RID: 51
			// (Invoke) Token: 0x06000068 RID: 104
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate UnityTls.unitytls_x509verify_result unitytls_x509verify_default_ca_t(UnityTls.unitytls_x509list_ref chain, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x02000034 RID: 52
			// (Invoke) Token: 0x0600006A RID: 106
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate UnityTls.unitytls_x509verify_result unitytls_x509verify_explicit_ca_t(UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_x509list_ref trustCA, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x02000035 RID: 53
			// (Invoke) Token: 0x0600006C RID: 108
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate UnityTls.unitytls_tlsctx* unitytls_tlsctx_create_server_t(UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, UnityTls.unitytls_tlsctx_callbacks callbacks, ulong certChain, ulong leafCertificateKey, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x02000036 RID: 54
			// (Invoke) Token: 0x0600006E RID: 110
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate UnityTls.unitytls_tlsctx* unitytls_tlsctx_create_client_t(UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, UnityTls.unitytls_tlsctx_callbacks callbacks, byte* cn, IntPtr cnLen, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x02000037 RID: 55
			// (Invoke) Token: 0x06000070 RID: 112
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate void unitytls_tlsctx_server_require_client_authentication_t(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_x509list_ref clientAuthCAList, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x02000038 RID: 56
			// (Invoke) Token: 0x06000072 RID: 114
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate void unitytls_tlsctx_set_certificate_callback_t(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_certificate_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x02000039 RID: 57
			// (Invoke) Token: 0x06000074 RID: 116
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate void unitytls_tlsctx_set_trace_callback_t(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_trace_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x0200003A RID: 58
			// (Invoke) Token: 0x06000076 RID: 118
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate void unitytls_tlsctx_set_x509verify_callback_t(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x0200003B RID: 59
			// (Invoke) Token: 0x06000078 RID: 120
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate void unitytls_tlsctx_set_supported_ciphersuites_t(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_ciphersuite* supportedCiphersuites, IntPtr supportedCiphersuitesLen, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x0200003C RID: 60
			// (Invoke) Token: 0x0600007A RID: 122
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate UnityTls.unitytls_ciphersuite unitytls_tlsctx_get_ciphersuite_t(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x0200003D RID: 61
			// (Invoke) Token: 0x0600007C RID: 124
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate UnityTls.unitytls_protocol unitytls_tlsctx_get_protocol_t(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x0200003E RID: 62
			// (Invoke) Token: 0x0600007E RID: 126
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate UnityTls.unitytls_x509verify_result unitytls_tlsctx_process_handshake_t(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x0200003F RID: 63
			// (Invoke) Token: 0x06000080 RID: 128
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate IntPtr unitytls_tlsctx_read_t(UnityTls.unitytls_tlsctx* ctx, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x02000040 RID: 64
			// (Invoke) Token: 0x06000082 RID: 130
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate IntPtr unitytls_tlsctx_write_t(UnityTls.unitytls_tlsctx* ctx, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x02000041 RID: 65
			// (Invoke) Token: 0x06000084 RID: 132
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate void unitytls_tlsctx_notify_close_t(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState);

			// Token: 0x02000042 RID: 66
			// (Invoke) Token: 0x06000086 RID: 134
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate void unitytls_tlsctx_free_t(UnityTls.unitytls_tlsctx* ctx);

			// Token: 0x02000043 RID: 67
			// (Invoke) Token: 0x06000088 RID: 136
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate void unitytls_random_generate_bytes_t(byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState);
		}
	}
}
