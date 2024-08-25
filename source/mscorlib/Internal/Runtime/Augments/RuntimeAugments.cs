using System;
using System.Runtime.ExceptionServices;

namespace Internal.Runtime.Augments
{
	// Token: 0x02000063 RID: 99
	internal class RuntimeAugments
	{
		// Token: 0x0600022F RID: 559 RVA: 0x000082B0 File Offset: 0x000064B0
		public static void ReportUnhandledException(Exception exception)
		{
			ExceptionDispatchInfo.Capture(exception).Throw();
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000230 RID: 560 RVA: 0x000082C8 File Offset: 0x000064C8
		internal static ReflectionExecutionDomainCallbacks Callbacks
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x06000231 RID: 561 RVA: 0x000082DC File Offset: 0x000064DC
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeAugments()
		{
		}

		// Token: 0x04000195 RID: 405
		private static ReflectionExecutionDomainCallbacks s_reflectionExecutionDomainCallbacks;
	}
}
