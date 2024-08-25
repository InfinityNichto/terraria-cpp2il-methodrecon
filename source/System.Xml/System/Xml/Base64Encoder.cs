using System;

namespace System.Xml
{
	// Token: 0x02000005 RID: 5
	internal abstract class Base64Encoder
	{
		// Token: 0x06000004 RID: 4 RVA: 0x00002090 File Offset: 0x00000290
		internal Base64Encoder()
		{
		}

		// Token: 0x06000005 RID: 5
		internal abstract void WriteChars(char[] chars, int index, int count);

		// Token: 0x06000006 RID: 6 RVA: 0x000020A4 File Offset: 0x000002A4
		internal void Encode(byte[] buffer, int index, int count)
		{
			if (buffer != null)
			{
				int num = this.leftOverBytesCount;
				return;
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002170 File Offset: 0x00000370
		internal void Flush()
		{
			int num = this.leftOverBytesCount;
			byte[] array = this.leftOverBytes;
			char[] array2 = this.charsLine;
			long num2 = 0L;
			long num3 = 0L;
			int num4 = Convert.ToBase64CharArray(array, (int)num2, num, array2, (int)num3);
			char[] array3 = this.charsLine;
		}

		// Token: 0x04000006 RID: 6
		private byte[] leftOverBytes;

		// Token: 0x04000007 RID: 7
		private int leftOverBytesCount;

		// Token: 0x04000008 RID: 8
		private char[] charsLine;
	}
}
