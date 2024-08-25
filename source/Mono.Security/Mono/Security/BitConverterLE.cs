using System;
using Cpp2IlInjected;

namespace Mono.Security
{
	// Token: 0x02000005 RID: 5
	internal sealed class BitConverterLE
	{
		// Token: 0x0600001B RID: 27 RVA: 0x0000249C File Offset: 0x0000069C
		private unsafe static byte[] GetUIntBytes(byte* bytes)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000024B0 File Offset: 0x000006B0
		private unsafe static byte[] GetULongBytes(byte* bytes)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000024C4 File Offset: 0x000006C4
		internal static byte[] GetBytes(int value)
		{
			byte[] array;
			return array;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000024D4 File Offset: 0x000006D4
		internal static byte[] GetBytes(long value)
		{
			byte[] array;
			return array;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000024E4 File Offset: 0x000006E4
		private unsafe static void UShortFromBytes(byte* dst, byte[] src, int startIndex)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000024F8 File Offset: 0x000006F8
		private unsafe static void UIntFromBytes(byte* dst, byte[] src, int startIndex)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002050 File Offset: 0x00000250
		internal static int ToInt32(byte[] value, int startIndex)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002050 File Offset: 0x00000250
		internal static ushort ToUInt16(byte[] value, int startIndex)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
		internal static uint ToUInt32(byte[] value, int startIndex)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
