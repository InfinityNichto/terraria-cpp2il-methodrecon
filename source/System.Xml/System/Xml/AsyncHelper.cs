using System;
using System.Threading.Tasks;

namespace System.Xml
{
	// Token: 0x02000004 RID: 4
	internal static class AsyncHelper
	{
		// Token: 0x06000003 RID: 3 RVA: 0x0000207C File Offset: 0x0000027C
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncHelper()
		{
			if (!true)
			{
			}
		}

		// Token: 0x04000002 RID: 2
		public static readonly Task DoneTask;

		// Token: 0x04000003 RID: 3
		public static readonly Task<bool> DoneTaskTrue;

		// Token: 0x04000004 RID: 4
		public static readonly Task<bool> DoneTaskFalse;

		// Token: 0x04000005 RID: 5
		public static readonly Task<int> DoneTaskZero;
	}
}
