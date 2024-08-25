using System;

namespace System.Xml
{
	// Token: 0x020000A6 RID: 166
	internal class Ucs4Decoder2143 : Ucs4Decoder
	{
		// Token: 0x06000775 RID: 1909 RVA: 0x00018B70 File Offset: 0x00016D70
		internal override int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x00018B8C File Offset: 0x00016D8C
		public Ucs4Decoder2143()
		{
		}
	}
}
