using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Threading
{
	// Token: 0x0200020A RID: 522
	public static class Interlocked
	{
		// Token: 0x0600128C RID: 4748 RVA: 0x0000207A File Offset: 0x0000027A
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static int CompareExchange(int location1, int value, int comparand)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x0000207A File Offset: 0x0000027A
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		internal static int CompareExchange(int location1, int value, int comparand, bool succeeded)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x000273C8 File Offset: 0x000255C8
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		private static void CompareExchange(object location1, object value, object comparand, object result)
		{
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x0000207A File Offset: 0x0000027A
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static object CompareExchange(object location1, object value, object comparand)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x0000207A File Offset: 0x0000027A
		public static float CompareExchange(float location1, float value, float comparand)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x0000207A File Offset: 0x0000027A
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static int Decrement(int location)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x0000207A File Offset: 0x0000027A
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static int Increment(int location)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x0000207A File Offset: 0x0000027A
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static int Exchange(int location1, int value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x000273D8 File Offset: 0x000255D8
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		private static void Exchange(object location1, object value, object result)
		{
		}

		// Token: 0x06001295 RID: 4757 RVA: 0x0000207A File Offset: 0x0000027A
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static object Exchange(object location1, object value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x0000207A File Offset: 0x0000027A
		public static float Exchange(float location1, float value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x0000207A File Offset: 0x0000027A
		public static long CompareExchange(long location1, long value, long comparand)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x0000207A File Offset: 0x0000027A
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static IntPtr CompareExchange(IntPtr location1, IntPtr value, IntPtr comparand)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x0000207A File Offset: 0x0000027A
		public static double CompareExchange(double location1, double value, double comparand)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x000273E5 File Offset: 0x000255E5
		[Intrinsic]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[ComVisible(false)]
		public static T CompareExchange<T>(T location1, T value, T comparand) where T : class
		{
			return null;
		}

		// Token: 0x0600129B RID: 4763 RVA: 0x0000207A File Offset: 0x0000027A
		public static long Exchange(long location1, long value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x0000207A File Offset: 0x0000027A
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static IntPtr Exchange(IntPtr location1, IntPtr value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x0000207A File Offset: 0x0000027A
		public static double Exchange(double location1, double value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x000273E5 File Offset: 0x000255E5
		[ComVisible(false)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[Intrinsic]
		public static T Exchange<T>(T location1, T value) where T : class
		{
			return null;
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x0000207A File Offset: 0x0000027A
		public static long Read(long location)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x0000207A File Offset: 0x0000027A
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static int Add(int location1, int value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x000273E8 File Offset: 0x000255E8
		public static void MemoryBarrier()
		{
			Thread.MemoryBarrier();
		}
	}
}
