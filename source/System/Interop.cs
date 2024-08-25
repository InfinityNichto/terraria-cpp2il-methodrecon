using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Win32.SafeHandles;

// Token: 0x02000002 RID: 2
internal static class Interop
{
	// Token: 0x02000003 RID: 3
	internal static class NetSecurityNative
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		internal static void ReleaseGssBuffer(IntPtr bufferPtr, ulong length)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		internal static global::Interop.NetSecurityNative.Status DisplayMinorStatus([Out] global::Interop.NetSecurityNative.Status minorStatus, global::Interop.NetSecurityNative.Status statusValue, global::Interop.NetSecurityNative.GssBuffer buffer)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		internal static global::Interop.NetSecurityNative.Status DisplayMajorStatus([Out] global::Interop.NetSecurityNative.Status minorStatus, global::Interop.NetSecurityNative.Status statusValue, global::Interop.NetSecurityNative.GssBuffer buffer)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
		internal static global::Interop.NetSecurityNative.Status ImportUserName([Out] global::Interop.NetSecurityNative.Status minorStatus, string inputName, int inputNameByteCount, [Out] Microsoft.Win32.SafeHandles.SafeGssNameHandle outputName)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
		internal static global::Interop.NetSecurityNative.Status ImportPrincipalName([Out] global::Interop.NetSecurityNative.Status minorStatus, string inputName, int inputNameByteCount, [Out] Microsoft.Win32.SafeHandles.SafeGssNameHandle outputName)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
		internal static global::Interop.NetSecurityNative.Status ReleaseName([Out] global::Interop.NetSecurityNative.Status minorStatus, IntPtr inputName)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
		internal static global::Interop.NetSecurityNative.Status InitiateCredSpNego([Out] global::Interop.NetSecurityNative.Status minorStatus, Microsoft.Win32.SafeHandles.SafeGssNameHandle desiredName, [Out] Microsoft.Win32.SafeHandles.SafeGssCredHandle outputCredHandle)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
		internal static global::Interop.NetSecurityNative.Status InitiateCredWithPassword([Out] global::Interop.NetSecurityNative.Status minorStatus, bool isNtlm, Microsoft.Win32.SafeHandles.SafeGssNameHandle desiredName, string password, int passwordLen, [Out] Microsoft.Win32.SafeHandles.SafeGssCredHandle outputCredHandle)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
		internal static global::Interop.NetSecurityNative.Status ReleaseCred([Out] global::Interop.NetSecurityNative.Status minorStatus, IntPtr credHandle)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
		internal static global::Interop.NetSecurityNative.Status InitSecContext([Out] global::Interop.NetSecurityNative.Status minorStatus, Microsoft.Win32.SafeHandles.SafeGssCredHandle initiatorCredHandle, Microsoft.Win32.SafeHandles.SafeGssContextHandle contextHandle, bool isNtlmOnly, Microsoft.Win32.SafeHandles.SafeGssNameHandle targetName, uint reqFlags, byte[] inputBytes, int inputLength, global::Interop.NetSecurityNative.GssBuffer token, [Out] uint retFlags, [Out] int isNtlmUsed)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
		internal static global::Interop.NetSecurityNative.Status DeleteSecContext([Out] global::Interop.NetSecurityNative.Status minorStatus, IntPtr contextHandle)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002050 File Offset: 0x00000250
		private static global::Interop.NetSecurityNative.Status Wrap([Out] global::Interop.NetSecurityNative.Status minorStatus, Microsoft.Win32.SafeHandles.SafeGssContextHandle contextHandle, bool isEncrypt, byte[] inputBytes, int offset, int count, global::Interop.NetSecurityNative.GssBuffer outBuffer)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
		private static global::Interop.NetSecurityNative.Status Unwrap([Out] global::Interop.NetSecurityNative.Status minorStatus, Microsoft.Win32.SafeHandles.SafeGssContextHandle contextHandle, byte[] inputBytes, int offset, int count, global::Interop.NetSecurityNative.GssBuffer outBuffer)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002050 File Offset: 0x00000250
		internal static global::Interop.NetSecurityNative.Status WrapBuffer([Out] global::Interop.NetSecurityNative.Status minorStatus, Microsoft.Win32.SafeHandles.SafeGssContextHandle contextHandle, bool isEncrypt, byte[] inputBytes, int offset, int count, global::Interop.NetSecurityNative.GssBuffer outBuffer)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
		internal static global::Interop.NetSecurityNative.Status UnwrapBuffer([Out] global::Interop.NetSecurityNative.Status minorStatus, Microsoft.Win32.SafeHandles.SafeGssContextHandle contextHandle, byte[] inputBytes, int offset, int count, global::Interop.NetSecurityNative.GssBuffer outBuffer)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x02000004 RID: 4
		internal sealed class GssApiException : Exception
		{
			// Token: 0x06000010 RID: 16 RVA: 0x0000205C File Offset: 0x0000025C
			public GssApiException(string message)
			{
			}

			// Token: 0x06000011 RID: 17 RVA: 0x0000205C File Offset: 0x0000025C
			public GssApiException(global::Interop.NetSecurityNative.Status majorStatus, global::Interop.NetSecurityNative.Status minorStatus)
			{
			}

			// Token: 0x06000012 RID: 18 RVA: 0x0000205E File Offset: 0x0000025E
			private static string GetGssApiDisplayStatus(global::Interop.NetSecurityNative.Status majorStatus, global::Interop.NetSecurityNative.Status minorStatus, string helpText)
			{
				return null;
			}

			// Token: 0x06000013 RID: 19 RVA: 0x0000205E File Offset: 0x0000025E
			private static string GetGssApiDisplayStatus(global::Interop.NetSecurityNative.Status status, bool isMinor)
			{
				return null;
			}

			// Token: 0x04000001 RID: 1
			private readonly global::Interop.NetSecurityNative.Status _minorStatus;
		}

		// Token: 0x02000005 RID: 5
		internal struct GssBuffer : IDisposable
		{
			// Token: 0x06000014 RID: 20 RVA: 0x00002064 File Offset: 0x00000264
			internal int Copy(byte[] destination, int offset)
			{
				return 0;
			}

			// Token: 0x06000015 RID: 21 RVA: 0x0000205E File Offset: 0x0000025E
			internal byte[] ToByteArray()
			{
				return null;
			}

			// Token: 0x06000016 RID: 22 RVA: 0x0000205C File Offset: 0x0000025C
			public void Dispose()
			{
			}

			// Token: 0x04000002 RID: 2
			internal ulong _length;

			// Token: 0x04000003 RID: 3
			internal IntPtr _data;
		}

		// Token: 0x02000006 RID: 6
		internal enum Status : uint
		{
			// Token: 0x04000005 RID: 5
			GSS_S_COMPLETE,
			// Token: 0x04000006 RID: 6
			GSS_S_CONTINUE_NEEDED,
			// Token: 0x04000007 RID: 7
			GSS_S_BAD_MECH = 65536U,
			// Token: 0x04000008 RID: 8
			GSS_S_BAD_NAME = 131072U,
			// Token: 0x04000009 RID: 9
			GSS_S_BAD_NAMETYPE = 196608U,
			// Token: 0x0400000A RID: 10
			GSS_S_BAD_BINDINGS = 262144U,
			// Token: 0x0400000B RID: 11
			GSS_S_BAD_STATUS = 327680U,
			// Token: 0x0400000C RID: 12
			GSS_S_BAD_SIG = 393216U,
			// Token: 0x0400000D RID: 13
			GSS_S_NO_CRED = 458752U,
			// Token: 0x0400000E RID: 14
			GSS_S_NO_CONTEXT = 524288U,
			// Token: 0x0400000F RID: 15
			GSS_S_DEFECTIVE_TOKEN = 589824U,
			// Token: 0x04000010 RID: 16
			GSS_S_DEFECTIVE_CREDENTIAL = 655360U,
			// Token: 0x04000011 RID: 17
			GSS_S_CREDENTIALS_EXPIRED = 720896U,
			// Token: 0x04000012 RID: 18
			GSS_S_CONTEXT_EXPIRED = 786432U,
			// Token: 0x04000013 RID: 19
			GSS_S_FAILURE = 851968U,
			// Token: 0x04000014 RID: 20
			GSS_S_BAD_QOP = 917504U,
			// Token: 0x04000015 RID: 21
			GSS_S_UNAUTHORIZED = 983040U,
			// Token: 0x04000016 RID: 22
			GSS_S_UNAVAILABLE = 1048576U,
			// Token: 0x04000017 RID: 23
			GSS_S_DUPLICATE_ELEMENT = 1114112U,
			// Token: 0x04000018 RID: 24
			GSS_S_NAME_NOT_MN = 1179648U
		}

		// Token: 0x02000007 RID: 7
		[Flags]
		internal enum GssFlags : uint
		{
			// Token: 0x0400001A RID: 26
			GSS_C_DELEG_FLAG = 1U,
			// Token: 0x0400001B RID: 27
			GSS_C_MUTUAL_FLAG = 2U,
			// Token: 0x0400001C RID: 28
			GSS_C_REPLAY_FLAG = 4U,
			// Token: 0x0400001D RID: 29
			GSS_C_SEQUENCE_FLAG = 8U,
			// Token: 0x0400001E RID: 30
			GSS_C_CONF_FLAG = 16U,
			// Token: 0x0400001F RID: 31
			GSS_C_INTEG_FLAG = 32U,
			// Token: 0x04000020 RID: 32
			GSS_C_ANON_FLAG = 64U,
			// Token: 0x04000021 RID: 33
			GSS_C_PROT_READY_FLAG = 128U,
			// Token: 0x04000022 RID: 34
			GSS_C_TRANS_FLAG = 256U,
			// Token: 0x04000023 RID: 35
			GSS_C_DCE_STYLE = 4096U,
			// Token: 0x04000024 RID: 36
			GSS_C_IDENTIFY_FLAG = 8192U,
			// Token: 0x04000025 RID: 37
			GSS_C_EXTENDED_ERROR_FLAG = 16384U,
			// Token: 0x04000026 RID: 38
			GSS_C_DELEG_POLICY_FLAG = 32768U
		}
	}
}
