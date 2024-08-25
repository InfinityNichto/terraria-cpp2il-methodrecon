using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x02000146 RID: 326
	[ComVisible(true)]
	public static class Buffer
	{
		// Token: 0x06000CED RID: 3309 RVA: 0x0000207A File Offset: 0x0000027A
		internal static bool InternalBlockCopy(Array src, int srcOffsetBytes, Array dst, int dstOffsetBytes, int byteCount)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x0001C21C File Offset: 0x0001A41C
		internal unsafe static int IndexOfByte(byte* src, byte value, int index, int count)
		{
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x0000207A File Offset: 0x0000027A
		private static int _ByteLength(Array array)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x0001C230 File Offset: 0x0001A430
		internal unsafe static void ZeroMemory(byte* src, long len)
		{
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x0001C240 File Offset: 0x0001A440
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		internal unsafe static void Memcpy(byte* pDest, int destIndex, byte[] src, int srcIndex, int len)
		{
			if (len == 0)
			{
				return;
			}
			if (src != null)
			{
				return;
			}
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x0001C258 File Offset: 0x0001A458
		internal unsafe static void InternalMemcpy(byte* dest, byte* src, int count)
		{
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x0000207A File Offset: 0x0000027A
		public static int ByteLength(Array array)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x0001C268 File Offset: 0x0001A468
		public static void BlockCopy(Array src, int srcOffset, Array dst, int dstOffset, int count)
		{
			if (src == null)
			{
				return;
			}
			if (dst != null)
			{
				int num = Buffer.ByteLength(src);
				int num2 = Buffer.ByteLength(dst);
				return;
			}
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x0001C290 File Offset: 0x0001A490
		[CLSCompliant(false)]
		public unsafe static void MemoryCopy(void* source, void* destination, long destinationSizeInBytes, long sourceBytesToCopy)
		{
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x0001C2A4 File Offset: 0x0001A4A4
		internal unsafe static void memcpy4(byte* dest, byte* src, int size)
		{
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x0001C2B4 File Offset: 0x0001A4B4
		internal unsafe static void memcpy2(byte* dest, byte* src, int size)
		{
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x0001C2C4 File Offset: 0x0001A4C4
		private unsafe static void memcpy1(byte* dest, byte* src, int size)
		{
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x0001C2D4 File Offset: 0x0001A4D4
		internal unsafe static void Memcpy(byte* dest, byte* src, int len, bool useICall = true)
		{
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x0001C2FC File Offset: 0x0001A4FC
		internal unsafe static void Memmove(byte* dest, byte* src, uint len)
		{
			int num = 1;
			Buffer.Memcpy(dest, src, (int)len, num != 0);
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x0001C320 File Offset: 0x0001A520
		internal static void Memmove<T>(T destination, T source, ulong elementCount)
		{
		}
	}
}
