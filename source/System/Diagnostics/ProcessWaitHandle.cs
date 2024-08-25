using System;
using System.Threading;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.Diagnostics
{
	// Token: 0x020000DE RID: 222
	internal class ProcessWaitHandle : WaitHandle
	{
		// Token: 0x06000521 RID: 1313 RVA: 0x00014BF0 File Offset: 0x00012DF0
		internal ProcessWaitHandle(Microsoft.Win32.SafeHandles.SafeProcessHandle processHandle)
		{
			if (!true)
			{
			}
			base..ctor();
			IntPtr currentProcess = Microsoft.Win32.NativeMethods.GetCurrentProcess();
			IntPtr currentProcess2 = Microsoft.Win32.NativeMethods.GetCurrentProcess();
			if (2 == 0)
			{
			}
		}
	}
}
