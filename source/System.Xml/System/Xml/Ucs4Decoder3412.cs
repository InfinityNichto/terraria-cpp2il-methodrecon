using System;

namespace System.Xml
{
	// Token: 0x020000A7 RID: 167
	internal class Ucs4Decoder3412 : Ucs4Decoder
	{
		// Token: 0x06000777 RID: 1911 RVA: 0x00018BA0 File Offset: 0x00016DA0
		internal override int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00018BB4 File Offset: 0x00016DB4
		public Ucs4Decoder3412()
		{
		}
	}
}
