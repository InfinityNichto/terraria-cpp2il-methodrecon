using System;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	// Token: 0x02000311 RID: 785
	internal class DESTransform : SymmetricTransform
	{
		// Token: 0x06001A91 RID: 6801 RVA: 0x00039318 File Offset: 0x00037518
		internal DESTransform(SymmetricAlgorithm symmAlgo, bool encryption, byte[] key, byte[] iv)
		{
			int num = 1;
			base..ctor(symmAlgo, encryption, iv);
			byte[] strongKey;
			if (key == null)
			{
				if (num == 0)
				{
				}
				strongKey = DESTransform.GetStrongKey();
			}
			bool flag = DES.IsWeakKey(strongKey);
			if (num == 0)
			{
			}
			bool flag2 = DES.IsSemiWeakKey(strongKey);
			object obj;
			if (strongKey == null && obj != null && obj == null)
			{
				throw new InvalidCastException();
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x00039370 File Offset: 0x00037570
		private uint CipherFunct(uint r, int n)
		{
			int num = 1;
			byte[] array = this.keySchedule;
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x00039390 File Offset: 0x00037590
		internal static void Permutation(byte[] input, byte[] output, uint[] permTab, bool preSwap)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001A94 RID: 6804 RVA: 0x000393AC File Offset: 0x000375AC
		private static void BSwap(byte[] byteBuff)
		{
		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x000393BC File Offset: 0x000375BC
		internal void SetKey(byte[] key)
		{
			int num = 1;
			byte[] array = this.keySchedule;
			if (num == 0)
			{
			}
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x000393F0 File Offset: 0x000375F0
		public void ProcessBlock(byte[] input, byte[] output)
		{
			uint[] array = this.dwordBuff;
			if (!true)
			{
			}
			long num = 0L;
			uint[] array2 = this.dwordBuff;
			if (this.encrypt)
			{
				long num2 = 0L;
				uint num3 = this.CipherFunct((uint)num, (int)num2);
				uint num4 = this.CipherFunct(array, 1);
				uint num5 = this.CipherFunct(array, 2);
				uint num6 = this.CipherFunct(array, 3);
				uint num7 = this.CipherFunct(array, 4);
				uint num8 = this.CipherFunct(array, 5);
				uint num9 = this.CipherFunct(array, 6);
				uint num10 = this.CipherFunct(array, 7);
				uint num11 = this.CipherFunct(array, 8);
				uint num12 = this.CipherFunct(array, 9);
				uint num13 = this.CipherFunct(array, 10);
				uint num14 = this.CipherFunct(array, 11);
				uint num15 = this.CipherFunct(array, 12);
				uint num16 = this.CipherFunct(array, 13);
				uint num17 = this.CipherFunct(array, 14);
				return;
			}
			uint num18 = this.CipherFunct(array, 15);
			uint num19 = this.CipherFunct(array, 14);
			uint num20 = this.CipherFunct(array, 12);
			uint num21 = this.CipherFunct(array, 11);
			uint num22 = this.CipherFunct(array, 10);
			uint num23 = this.CipherFunct(array, 9);
			uint num24 = this.CipherFunct(array, 8);
			uint num25 = this.CipherFunct(array, 7);
			uint num26 = this.CipherFunct(array, 6);
			uint num27 = this.CipherFunct(array, 5);
			uint num28 = this.CipherFunct(array, 4);
			uint num29 = this.CipherFunct(array, 3);
			uint num30 = this.CipherFunct(array, 2);
			uint num31 = this.CipherFunct(array, 1);
			long num32 = 0L;
			uint num33 = this.CipherFunct(array, (int)num32);
			uint[] array3 = this.dwordBuff;
			if (array2 == null)
			{
			}
		}

		// Token: 0x06001A97 RID: 6807 RVA: 0x00039568 File Offset: 0x00037768
		protected override void ECB(byte[] input, byte[] output)
		{
			if (!true)
			{
			}
			byte[] array = this.byteBuff;
			this.ProcessBlock(output, array);
			byte[] array2 = this.byteBuff;
		}

		// Token: 0x06001A98 RID: 6808 RVA: 0x00039590 File Offset: 0x00037790
		internal static byte[] GetStrongKey()
		{
			if ("AnyAtomicType" == null)
			{
			}
			byte[] array = KeyBuilder.Key(41730048);
			bool flag = DES.IsWeakKey(array);
			bool flag2 = DES.IsSemiWeakKey(array);
			return 41730048;
		}

		// Token: 0x06001A99 RID: 6809 RVA: 0x000395C4 File Offset: 0x000377C4
		// Note: this type is marked as 'beforefieldinit'.
		static DESTransform()
		{
		}

		// Token: 0x04000D85 RID: 3461
		internal static readonly int KEY_BIT_SIZE;

		// Token: 0x04000D86 RID: 3462
		internal static readonly int KEY_BYTE_SIZE;

		// Token: 0x04000D87 RID: 3463
		internal static readonly int BLOCK_BIT_SIZE;

		// Token: 0x04000D88 RID: 3464
		internal static readonly int BLOCK_BYTE_SIZE;

		// Token: 0x04000D89 RID: 3465
		private byte[] keySchedule;

		// Token: 0x04000D8A RID: 3466
		private byte[] byteBuff;

		// Token: 0x04000D8B RID: 3467
		private uint[] dwordBuff;

		// Token: 0x04000D8C RID: 3468
		private static readonly uint[] spBoxes;

		// Token: 0x04000D8D RID: 3469
		private static readonly byte[] PC1;

		// Token: 0x04000D8E RID: 3470
		private static readonly byte[] leftRotTotal;

		// Token: 0x04000D8F RID: 3471
		private static readonly byte[] PC2;

		// Token: 0x04000D90 RID: 3472
		internal static readonly uint[] ipTab;

		// Token: 0x04000D91 RID: 3473
		internal static readonly uint[] fpTab;
	}
}
