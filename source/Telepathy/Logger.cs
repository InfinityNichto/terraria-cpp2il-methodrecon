using System;

namespace Telepathy
{
	// Token: 0x02000314 RID: 788
	public static class Logger
	{
		// Token: 0x0600126C RID: 4716 RVA: 0x00059A84 File Offset: 0x00057C84
		// Note: this type is marked as 'beforefieldinit'.
		static Logger()
		{
			if (!true)
			{
			}
		}

		// Token: 0x04002202 RID: 8706
		public static Action<string> Log;

		// Token: 0x04002203 RID: 8707
		public static Action<string> LogWarning;

		// Token: 0x04002204 RID: 8708
		public static Action<string> LogError;
	}
}
