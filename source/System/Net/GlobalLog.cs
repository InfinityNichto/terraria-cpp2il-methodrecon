using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x020001F3 RID: 499
	internal static class GlobalLog
	{
		// Token: 0x06000C3E RID: 3134 RVA: 0x00002050 File Offset: 0x00000250
		[ReliabilityContract(Consistency.MayCorruptAppDomain, Cer.None)]
		private static BaseLoggingObject LoggingInitialize()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000C3F RID: 3135 RVA: 0x000276D0 File Offset: 0x000258D0
		internal static ThreadKinds CurrentThreadKind
		{
			get
			{
			}
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x000276E0 File Offset: 0x000258E0
		[Conditional("DEBUG")]
		[ReliabilityContract(Consistency.MayCorruptAppDomain, Cer.None)]
		internal static void SetThreadSource(ThreadKinds source)
		{
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x000276F0 File Offset: 0x000258F0
		[ReliabilityContract(Consistency.MayCorruptAppDomain, Cer.None)]
		[Conditional("DEBUG")]
		internal static void ThreadContract(ThreadKinds kind, string errorMsg)
		{
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x00027700 File Offset: 0x00025900
		[Conditional("DEBUG")]
		[ReliabilityContract(Consistency.MayCorruptAppDomain, Cer.None)]
		internal static void ThreadContract(ThreadKinds kind, ThreadKinds allowedSources, string errorMsg)
		{
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x00027710 File Offset: 0x00025910
		[Conditional("TRAVE")]
		public static void AddToArray(string msg)
		{
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x00027720 File Offset: 0x00025920
		[Conditional("TRAVE")]
		public static void Ignore(object msg)
		{
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x00027730 File Offset: 0x00025930
		[ReliabilityContract(Consistency.MayCorruptAppDomain, Cer.None)]
		[Conditional("TRAVE")]
		public static void Print(string msg)
		{
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x00027740 File Offset: 0x00025940
		[Conditional("TRAVE")]
		public static void PrintHex(string msg, object value)
		{
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x00027750 File Offset: 0x00025950
		[Conditional("TRAVE")]
		public static void Enter(string func)
		{
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x00027760 File Offset: 0x00025960
		[Conditional("TRAVE")]
		public static void Enter(string func, string parms)
		{
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x00027770 File Offset: 0x00025970
		[Conditional("DEBUG")]
		[Conditional("_FORCE_ASSERTS")]
		[ReliabilityContract(Consistency.MayCorruptAppDomain, Cer.None)]
		public static void Assert(bool condition, string messageFormat, params object[] data)
		{
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x00027790 File Offset: 0x00025990
		[Conditional("_FORCE_ASSERTS")]
		[ReliabilityContract(Consistency.MayCorruptAppDomain, Cer.None)]
		[Conditional("DEBUG")]
		public static void Assert(string message)
		{
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x000277A0 File Offset: 0x000259A0
		[Conditional("DEBUG")]
		[Conditional("_FORCE_ASSERTS")]
		[ReliabilityContract(Consistency.MayCorruptAppDomain, Cer.None)]
		public static void Assert(string message, string detailMessage)
		{
			if (!true)
			{
			}
			long num = 0L;
			if (!true)
			{
			}
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x000277D8 File Offset: 0x000259D8
		[Conditional("TRAVE")]
		public static void LeaveException(string func, Exception exception)
		{
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x000277E8 File Offset: 0x000259E8
		[Conditional("TRAVE")]
		public static void Leave(string func)
		{
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x000277F8 File Offset: 0x000259F8
		[Conditional("TRAVE")]
		public static void Leave(string func, string result)
		{
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x00027808 File Offset: 0x00025A08
		[Conditional("TRAVE")]
		public static void Leave(string func, int returnval)
		{
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x00027818 File Offset: 0x00025A18
		[Conditional("TRAVE")]
		public static void Leave(string func, bool returnval)
		{
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x00027828 File Offset: 0x00025A28
		[Conditional("TRAVE")]
		public static void DumpArray()
		{
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x00027838 File Offset: 0x00025A38
		[Conditional("TRAVE")]
		public static void Dump(byte[] buffer)
		{
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x00027848 File Offset: 0x00025A48
		[Conditional("TRAVE")]
		public static void Dump(byte[] buffer, int length)
		{
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x00027858 File Offset: 0x00025A58
		[Conditional("TRAVE")]
		public static void Dump(byte[] buffer, int offset, int length)
		{
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x00027868 File Offset: 0x00025A68
		[Conditional("TRAVE")]
		public static void Dump(IntPtr buffer, int offset, int length)
		{
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x00027878 File Offset: 0x00025A78
		// Note: this type is marked as 'beforefieldinit'.
		static GlobalLog()
		{
			BaseLoggingObject baseLoggingObject = GlobalLog.LoggingInitialize();
		}

		// Token: 0x04000AA0 RID: 2720
		private static BaseLoggingObject Logobject;
	}
}
