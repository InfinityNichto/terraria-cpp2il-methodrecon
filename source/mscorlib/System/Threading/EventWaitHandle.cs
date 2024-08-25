using System;
using System.IO;
using System.Runtime.InteropServices;

namespace System.Threading
{
	// Token: 0x020001E9 RID: 489
	[ComVisible(true)]
	public class EventWaitHandle : WaitHandle
	{
		// Token: 0x0600117A RID: 4474 RVA: 0x000252E0 File Offset: 0x000234E0
		public EventWaitHandle(bool initialState, EventResetMode mode)
		{
		}

		// Token: 0x0600117B RID: 4475 RVA: 0x000252F0 File Offset: 0x000234F0
		public EventWaitHandle(bool initialState, EventResetMode mode, string name)
		{
			if (!true)
			{
			}
			base..ctor();
			if (name != null)
			{
				int stringLength = name._stringLength;
			}
			if (mode != EventResetMode.AutoReset)
			{
				return;
			}
			int stringLength2;
			if (name != null)
			{
				stringLength2 = name._stringLength;
				if (stringLength2 != 0)
				{
					throw new ArrayTypeMismatchException();
				}
			}
			string text;
			__Error.WinIOError(42189712, text);
			if (stringLength2 == 0)
			{
			}
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x00025348 File Offset: 0x00023548
		public bool Reset()
		{
			bool flag = NativeEventCalls.ResetEvent(this.safeWaitHandle);
			return true;
		}

		// Token: 0x0600117D RID: 4477 RVA: 0x00025364 File Offset: 0x00023564
		public bool Set()
		{
			bool flag = NativeEventCalls.SetEvent(this.safeWaitHandle);
			return true;
		}
	}
}
