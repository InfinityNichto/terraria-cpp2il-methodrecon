using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace System.Threading
{
	// Token: 0x02000213 RID: 531
	public static class Volatile
	{
		// Token: 0x060012CB RID: 4811 RVA: 0x0000207A File Offset: 0x0000027A
		[Intrinsic]
		public static bool Read(bool location)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x0000207A File Offset: 0x0000027A
		[Intrinsic]
		public static int Read(int location)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x00027B7C File Offset: 0x00025D7C
		[Intrinsic]
		public static void Write(int location, int value)
		{
			location.m_value = value;
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x0000207A File Offset: 0x0000027A
		[Intrinsic]
		public static T Read<T>(T location) where T : class
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x00027B90 File Offset: 0x00025D90
		[Intrinsic]
		public static void Write<T>(T location, T value) where T : class
		{
		}

		// Token: 0x02000214 RID: 532
		private struct VolatileBoolean
		{
			// Token: 0x04000A18 RID: 2584
			public bool Value;
		}

		// Token: 0x02000215 RID: 533
		private struct VolatileInt32
		{
			// Token: 0x04000A19 RID: 2585
			public int Value;
		}

		// Token: 0x02000216 RID: 534
		private struct VolatileObject
		{
			// Token: 0x04000A1A RID: 2586
			public object Value;
		}
	}
}
