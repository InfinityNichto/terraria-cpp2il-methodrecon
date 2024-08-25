using System;
using System.Security.Cryptography;
using Cpp2IlInjected;

namespace Internal.Cryptography
{
	// Token: 0x02000066 RID: 102
	internal static class Helpers
	{
		// Token: 0x0600023D RID: 573 RVA: 0x000083AC File Offset: 0x000065AC
		public static byte[] CloneByteArray(this byte[] src)
		{
			object obj;
			while (obj == null || obj != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x0600023E RID: 574 RVA: 0x000083C8 File Offset: 0x000065C8
		public static byte[] GenerateRandom(int count)
		{
			RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create();
			long num = 0L;
			if (randomNumberGenerator != null)
			{
			}
			if (num == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00008404 File Offset: 0x00006604
		public static void WriteInt(uint i, byte[] arr, int offset)
		{
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00008414 File Offset: 0x00006614
		public static char[] ToHexArrayUpper(this byte[] bytes)
		{
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00008424 File Offset: 0x00006624
		public static string ToHexStringUpper(this byte[] bytes)
		{
			char[] array;
			return string.Ctor(array);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0000207A File Offset: 0x0000027A
		private static char NibbleToHex(byte b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
