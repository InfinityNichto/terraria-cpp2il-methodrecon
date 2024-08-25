using System;

namespace System
{
	// Token: 0x02000186 RID: 390
	internal class NullConsoleDriver : IConsoleDriver
	{
		// Token: 0x06000F2E RID: 3886 RVA: 0x00020740 File Offset: 0x0001E940
		public void Clear()
		{
		}

		// Token: 0x06000F2F RID: 3887 RVA: 0x00020750 File Offset: 0x0001E950
		public string ReadLine()
		{
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x00020760 File Offset: 0x0001E960
		public ConsoleKeyInfo ReadKey(bool intercept)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x00020774 File Offset: 0x0001E974
		public NullConsoleDriver()
		{
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x00020784 File Offset: 0x0001E984
		// Note: this type is marked as 'beforefieldinit'.
		static NullConsoleDriver()
		{
		}

		// Token: 0x0400068B RID: 1675
		private static readonly ConsoleKeyInfo EmptyConsoleKeyInfo;
	}
}
