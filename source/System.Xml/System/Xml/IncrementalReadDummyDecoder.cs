using System;

namespace System.Xml
{
	// Token: 0x02000022 RID: 34
	internal class IncrementalReadDummyDecoder : IncrementalReadDecoder
	{
		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00003A34 File Offset: 0x00001C34
		internal override bool IsFull
		{
			get
			{
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00003A44 File Offset: 0x00001C44
		internal override int Decode(char[] chars, int startPos, int len)
		{
			return len;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00003A54 File Offset: 0x00001C54
		public IncrementalReadDummyDecoder()
		{
		}
	}
}
