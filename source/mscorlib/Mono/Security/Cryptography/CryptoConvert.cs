using System;
using System.Security.Cryptography;
using Cpp2IlInjected;

namespace Mono.Security.Cryptography
{
	// Token: 0x02000042 RID: 66
	internal sealed class CryptoConvert
	{
		// Token: 0x0600011A RID: 282 RVA: 0x0000207A File Offset: 0x0000027A
		private static int ToInt32LE(byte[] bytes, int offset)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000207A File Offset: 0x0000027A
		private static uint ToUInt32LE(byte[] bytes, int offset)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0000207A File Offset: 0x0000027A
		private static byte[] GetBytesLE(int val)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00004930 File Offset: 0x00002B30
		private static byte[] Trim(byte[] array)
		{
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00004940 File Offset: 0x00002B40
		public static RSA FromCapiPrivateKeyBlob(byte[] blob, int offset)
		{
			return RSA.Create();
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00004954 File Offset: 0x00002B54
		private static RSAParameters GetParametersFromCapiPrivateKeyBlob(byte[] blob, int offset)
		{
			int num = 1;
			if (blob != null && num == 0 && num == 0)
			{
				int num2 = 4;
				long num3 = 0L;
				byte[] array;
				Buffer.BlockCopy(array, 42163096, array, (int)num3, num2);
				RSAParameters rsaparameters;
				rsaparameters.DP = 42163096;
				rsaparameters.DQ = 42163096;
				rsaparameters.Q = 42163096;
				return;
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000049B0 File Offset: 0x00002BB0
		public static DSA FromCapiPrivateKeyBlobDSA(byte[] blob, int offset)
		{
			int num = 1;
			if (num == 0 && num == 0)
			{
				return DSA.Create();
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x000049E0 File Offset: 0x00002BE0
		public static byte[] ToCapiPrivateKeyBlob(RSA rsa)
		{
			byte[] bytesLE = CryptoConvert.GetBytesLE(42163096);
			return 42163096;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00004A08 File Offset: 0x00002C08
		public static byte[] ToCapiPrivateKeyBlob(DSA dsa)
		{
			byte[] bytesLE = CryptoConvert.GetBytesLE(42163096);
			byte[] bytesLE2 = CryptoConvert.GetBytesLE(43151360);
			return 42163096;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00004A34 File Offset: 0x00002C34
		public static RSA FromCapiPublicKeyBlob(byte[] blob, int offset)
		{
			return RSA.Create();
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00004A50 File Offset: 0x00002C50
		private static RSAParameters GetParametersFromCapiPublicKeyBlob(byte[] blob, int offset)
		{
			int num = 1;
			if (blob == null || num != 0 || num == 0)
			{
				return;
			}
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00004A74 File Offset: 0x00002C74
		public static DSA FromCapiPublicKeyBlobDSA(byte[] blob, int offset)
		{
			int num = 1;
			if (num == 0 && num == 0)
			{
				return DSA.Create();
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00004AA0 File Offset: 0x00002CA0
		public static byte[] ToCapiPublicKeyBlob(RSA rsa)
		{
			byte[] bytesLE = CryptoConvert.GetBytesLE(42163096);
			return 42163096;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00004AC4 File Offset: 0x00002CC4
		public static byte[] ToCapiPublicKeyBlob(DSA dsa)
		{
			byte[] bytesLE = CryptoConvert.GetBytesLE(42163096);
			byte[] bytesLE2 = CryptoConvert.GetBytesLE(43151360);
			return 42163096;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00004AF0 File Offset: 0x00002CF0
		public static RSA FromCapiKeyBlob(byte[] blob)
		{
			RSA rsa;
			return rsa;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00004B00 File Offset: 0x00002D00
		public static RSA FromCapiKeyBlob(byte[] blob, int offset)
		{
			RSA rsa;
			return rsa;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00004B10 File Offset: 0x00002D10
		public static DSA FromCapiKeyBlobDSA(byte[] blob)
		{
			DSA dsa;
			return dsa;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00004B20 File Offset: 0x00002D20
		public static DSA FromCapiKeyBlobDSA(byte[] blob, int offset)
		{
			DSA dsa;
			return dsa;
		}
	}
}
