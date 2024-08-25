using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.DataStructures
{
	// Token: 0x0200061A RID: 1562
	public static class BufferPool
	{
		// Token: 0x060035BC RID: 13756 RVA: 0x000021DB File Offset: 0x000003DB
		public static CachedBuffer Request(int size)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060035BD RID: 13757 RVA: 0x0021184C File Offset: 0x0020FA4C
		public static CachedBuffer Request(byte[] data, int offset, int size)
		{
			if (!true)
			{
			}
			CachedBuffer cachedBuffer = BufferPool.Request(offset);
			byte[] data2 = cachedBuffer.Data;
			return cachedBuffer;
		}

		// Token: 0x060035BE RID: 13758 RVA: 0x0021186C File Offset: 0x0020FA6C
		public static void Recycle(CachedBuffer buffer)
		{
			if (buffer.Data == null)
			{
			}
		}

		// Token: 0x060035BF RID: 13759 RVA: 0x002118B4 File Offset: 0x0020FAB4
		public static void PrintBufferSizes()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			string text;
			Console.WriteLine("SmallBufferQueue.Count: " + text);
			string text2;
			Console.WriteLine("MediumBufferQueue.Count: " + text2);
			string text3;
			Console.WriteLine("LargeBufferQueue.Count: " + text3);
			Console.WriteLine("");
			long num = 0L;
			if ("" != null)
			{
			}
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060035C0 RID: 13760 RVA: 0x00211938 File Offset: 0x0020FB38
		// Note: this type is marked as 'beforefieldinit'.
		static BufferPool()
		{
		}

		// Token: 0x04007693 RID: 30355
		private const int SMALL_BUFFER_SIZE = 32;

		// Token: 0x04007694 RID: 30356
		private const int MEDIUM_BUFFER_SIZE = 256;

		// Token: 0x04007695 RID: 30357
		private const int LARGE_BUFFER_SIZE = 16384;

		// Token: 0x04007696 RID: 30358
		private static object bufferLock;

		// Token: 0x04007697 RID: 30359
		private static Queue<CachedBuffer> SmallBufferQueue;

		// Token: 0x04007698 RID: 30360
		private static Queue<CachedBuffer> MediumBufferQueue;

		// Token: 0x04007699 RID: 30361
		private static Queue<CachedBuffer> LargeBufferQueue;
	}
}
