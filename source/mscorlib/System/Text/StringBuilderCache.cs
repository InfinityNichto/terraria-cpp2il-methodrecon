using System;
using Cpp2IlInjected;

namespace System.Text
{
	// Token: 0x02000279 RID: 633
	internal static class StringBuilderCache
	{
		// Token: 0x06001585 RID: 5509 RVA: 0x0002D24C File Offset: 0x0002B44C
		public static StringBuilder Acquire(int capacity = 16)
		{
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x0002D25C File Offset: 0x0002B45C
		public static void Release(StringBuilder sb)
		{
			char[] chunkChars = sb.m_ChunkChars;
			int chunkOffset = sb.m_ChunkOffset;
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x0000207A File Offset: 0x0000027A
		public static string GetStringAndRelease(StringBuilder sb)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x04000B31 RID: 2865
		[ThreadStatic]
		private static StringBuilder t_cachedInstance;
	}
}
