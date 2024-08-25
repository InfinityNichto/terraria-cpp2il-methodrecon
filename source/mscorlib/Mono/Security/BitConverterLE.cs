using System;
using Cpp2IlInjected;

namespace Mono.Security
{
	// Token: 0x02000041 RID: 65
	internal sealed class BitConverterLE
	{
		// Token: 0x06000111 RID: 273 RVA: 0x000048AC File Offset: 0x00002AAC
		private unsafe static byte[] GetUIntBytes(byte* bytes)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000048C0 File Offset: 0x00002AC0
		private unsafe static byte[] GetULongBytes(byte* bytes)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x000048D4 File Offset: 0x00002AD4
		internal static byte[] GetBytes(int value)
		{
			byte[] array;
			return array;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x000048E4 File Offset: 0x00002AE4
		internal static byte[] GetBytes(float value)
		{
			byte[] array;
			return array;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000048F4 File Offset: 0x00002AF4
		internal static byte[] GetBytes(double value)
		{
			byte[] array;
			return array;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00004904 File Offset: 0x00002B04
		private unsafe static void UIntFromBytes(byte* dst, byte[] src, int startIndex)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00004918 File Offset: 0x00002B18
		private unsafe static void ULongFromBytes(byte* dst, byte[] src, int startIndex)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0000207A File Offset: 0x0000027A
		internal static float ToSingle(byte[] value, int startIndex)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0000207A File Offset: 0x0000027A
		internal static double ToDouble(byte[] value, int startIndex)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
