using System;

namespace System.Xml
{
	// Token: 0x020000A5 RID: 165
	internal class Ucs4Decoder1234 : Ucs4Decoder
	{
		// Token: 0x06000773 RID: 1907 RVA: 0x00018B48 File Offset: 0x00016D48
		internal override int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00018B5C File Offset: 0x00016D5C
		public Ucs4Decoder1234()
		{
		}
	}
}
