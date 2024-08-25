using System;

namespace System.Xml
{
	// Token: 0x020000A4 RID: 164
	internal class Ucs4Decoder4321 : Ucs4Decoder
	{
		// Token: 0x06000771 RID: 1905 RVA: 0x00018B20 File Offset: 0x00016D20
		internal override int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00018B34 File Offset: 0x00016D34
		public Ucs4Decoder4321()
		{
		}
	}
}
