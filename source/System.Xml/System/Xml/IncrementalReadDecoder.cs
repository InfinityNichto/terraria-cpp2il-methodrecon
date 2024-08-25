using System;

namespace System.Xml
{
	// Token: 0x02000021 RID: 33
	internal abstract class IncrementalReadDecoder
	{
		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000B1 RID: 177
		internal abstract bool IsFull { get; }

		// Token: 0x060000B2 RID: 178
		internal abstract int Decode(char[] chars, int startPos, int len);

		// Token: 0x060000B3 RID: 179 RVA: 0x00003A20 File Offset: 0x00001C20
		protected IncrementalReadDecoder()
		{
		}
	}
}
