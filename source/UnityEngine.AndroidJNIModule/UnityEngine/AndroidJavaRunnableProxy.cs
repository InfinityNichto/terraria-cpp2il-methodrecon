using System;

namespace UnityEngine
{
	// Token: 0x02000006 RID: 6
	internal class AndroidJavaRunnableProxy : AndroidJavaProxy
	{
		// Token: 0x0600006A RID: 106 RVA: 0x00003578 File Offset: 0x00001778
		public AndroidJavaRunnableProxy(AndroidJavaRunnable runnable)
		{
			if (!true)
			{
			}
			base..ctor("java/lang/Runnable");
			this.mRunnable = runnable;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000359C File Offset: 0x0000179C
		public void run()
		{
			AndroidJavaRunnable androidJavaRunnable = this.mRunnable;
			IntPtr invoke_impl = androidJavaRunnable.invoke_impl;
			IntPtr method_code = androidJavaRunnable.method_code;
			IntPtr method = androidJavaRunnable.method;
		}

		// Token: 0x04000004 RID: 4
		private AndroidJavaRunnable mRunnable;
	}
}
