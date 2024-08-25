using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace System.Collections.Concurrent
{
	// Token: 0x02000614 RID: 1556
	[DebuggerDisplay("Head = {Head}, Tail = {Tail}")]
	[StructLayout(2, Pack = 1, Size = 384)]
	internal struct PaddedHeadAndTail
	{
		// Token: 0x04001A28 RID: 6696
		public int Head;

		// Token: 0x04001A29 RID: 6697
		public int Tail;
	}
}
