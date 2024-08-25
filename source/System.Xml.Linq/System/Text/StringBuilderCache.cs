using System;
using Cpp2IlInjected;

namespace System.Text
{
	// Token: 0x0200001F RID: 31
	internal static class StringBuilderCache
	{
		// Token: 0x060000CF RID: 207 RVA: 0x00003D38 File Offset: 0x00001F38
		public static StringBuilder Acquire(int capacity = 16)
		{
			StringBuilder stringBuilder;
			return stringBuilder;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00003D48 File Offset: 0x00001F48
		public static void Release(StringBuilder sb)
		{
			int capacity = sb.Capacity;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002367 File Offset: 0x00000567
		public static string GetStringAndRelease(StringBuilder sb)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0400004F RID: 79
		[ThreadStatic]
		private static StringBuilder t_cachedInstance;
	}
}
