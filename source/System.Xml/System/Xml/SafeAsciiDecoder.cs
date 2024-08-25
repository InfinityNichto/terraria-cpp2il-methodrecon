using System;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Xml
{
	// Token: 0x0200009D RID: 157
	internal class SafeAsciiDecoder : Decoder
	{
		// Token: 0x0600074B RID: 1867 RVA: 0x000188D8 File Offset: 0x00016AD8
		public SafeAsciiDecoder()
		{
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x000188EC File Offset: 0x00016AEC
		public override int GetCharCount(byte[] bytes, int index, int count)
		{
			return count;
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x000188FC File Offset: 0x00016AFC
		public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			return byteCount;
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x0001890C File Offset: 0x00016B0C
		public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, [Out] int bytesUsed, [Out] int charsUsed, [Out] bool completed)
		{
		}
	}
}
