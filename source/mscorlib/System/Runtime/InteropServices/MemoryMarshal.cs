using System;
using Cpp2IlInjected;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000431 RID: 1073
	public static class MemoryMarshal
	{
		// Token: 0x06002151 RID: 8529 RVA: 0x0004BE74 File Offset: 0x0004A074
		public static Span<byte> AsBytes<T>(Span<T> span) where T : struct
		{
			throw new OverflowException();
		}

		// Token: 0x06002152 RID: 8530 RVA: 0x0004BE94 File Offset: 0x0004A094
		public static ReadOnlySpan<byte> AsBytes<T>(ReadOnlySpan<T> span) where T : struct
		{
			throw new OverflowException();
		}

		// Token: 0x06002153 RID: 8531 RVA: 0x0000207A File Offset: 0x0000027A
		public static Memory<T> AsMemory<T>(ReadOnlyMemory<T> memory)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002154 RID: 8532 RVA: 0x0000207A File Offset: 0x0000027A
		public static T GetReference<T>(Span<T> span)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002155 RID: 8533 RVA: 0x0000207A File Offset: 0x0000027A
		public static T GetReference<T>(ReadOnlySpan<T> span)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002156 RID: 8534 RVA: 0x0000207A File Offset: 0x0000027A
		internal static T GetNonNullPinnableReference<T>(Span<T> span)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002157 RID: 8535 RVA: 0x0000207A File Offset: 0x0000027A
		internal static T GetNonNullPinnableReference<T>(ReadOnlySpan<T> span)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002158 RID: 8536 RVA: 0x0000207A File Offset: 0x0000027A
		public static ReadOnlySpan<T> CreateReadOnlySpan<T>(T reference, int length)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002159 RID: 8537 RVA: 0x0004BEB4 File Offset: 0x0004A0B4
		public static bool TryGetArray<T>(ReadOnlyMemory<T> memory, [Out] ArraySegment<T> segment)
		{
			if (memory != null)
			{
			}
			long num = 0L;
			segment._array = num;
			segment._offset = memory;
			throw new InvalidCastException();
		}
	}
}
