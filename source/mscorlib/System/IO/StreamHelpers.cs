using System;

namespace System.IO
{
	// Token: 0x0200053E RID: 1342
	internal static class StreamHelpers
	{
		// Token: 0x06002789 RID: 10121 RVA: 0x00055AD4 File Offset: 0x00053CD4
		public static void ValidateCopyToArgs(Stream source, Stream destination, int bufferSize)
		{
			if (destination != null)
			{
				return;
			}
		}
	}
}
