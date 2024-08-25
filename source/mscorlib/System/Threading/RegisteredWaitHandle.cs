using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace System.Threading
{
	// Token: 0x0200020D RID: 525
	[ComVisible(true)]
	public sealed class RegisteredWaitHandle : MarshalByRefObject
	{
		// Token: 0x060012A9 RID: 4777 RVA: 0x00027474 File Offset: 0x00025674
		internal RegisteredWaitHandle(WaitHandle waitObject, WaitOrTimerCallback callback, object state, TimeSpan timeout, bool executeOnlyOnce)
		{
			this._waitObject = waitObject;
			this._callback = callback;
			this._timeout = timeout;
			this._state = state;
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x000274A8 File Offset: 0x000256A8
		internal void Wait(object state)
		{
			SafeWaitHandle safeWaitHandle = this._waitObject.SafeWaitHandle;
			WaitHandle waitObject = this._waitObject;
			if (waitObject != null && waitObject == null)
			{
				throw new ArrayTypeMismatchException();
			}
			ManualResetEvent cancelEvent = this._cancelEvent;
			if (cancelEvent != null && cancelEvent == null)
			{
				throw new ArrayTypeMismatchException();
			}
			TimeSpan timeout = this._timeout;
			if (!this._unregistered)
			{
				int callsInProcess = this._callsInProcess;
				long num = 0L;
				this._callsInProcess = callsInProcess;
				if (callsInProcess != 0)
				{
					Monitor.Exit(this);
				}
				if (num != 0L)
				{
					throw new OutOfMemoryException();
				}
				if (!this._unregistered)
				{
					bool executeOnlyOnce = this._executeOnlyOnce;
					while (!executeOnlyOnce)
					{
					}
					return;
				}
			}
			int callsInProcess2 = this._callsInProcess;
			int num2 = 1;
			this._unregistered = num2 != 0;
			if (callsInProcess2 != 0)
			{
				return;
			}
			WaitHandle finalEvent = this._finalEvent;
			while (finalEvent == null)
			{
			}
			bool flag = NativeEventCalls.SetEvent(finalEvent.SafeWaitHandle);
			long num3 = 0L;
			if (callsInProcess2 != 0)
			{
				Monitor.Exit(this);
			}
			if (num3 != 0L)
			{
				throw new OutOfMemoryException();
			}
			long num4 = 0L;
			if (callsInProcess2 != 0)
			{
				this._waitObject.SafeWaitHandle.DangerousRelease();
			}
			if (num4 == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x00027620 File Offset: 0x00025820
		private void DoCallBack(object timedOut)
		{
			WaitOrTimerCallback callback = this._callback;
			if (callback != null)
			{
				object state = this._state;
				IntPtr method_code = callback.method_code;
				IntPtr invoke_impl = callback.invoke_impl;
				IntPtr method = callback.method;
			}
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x00027660 File Offset: 0x00025860
		[ComVisible(true)]
		public bool Unregister(WaitHandle waitObject)
		{
			bool unregistered = this._unregistered;
			long num;
			if (unregistered)
			{
				num = 0L;
			}
			ManualResetEvent cancelEvent = this._cancelEvent;
			this._finalEvent = num;
			this._unregistered = true;
			bool flag = cancelEvent.Set();
			long num2 = 0L;
			if (unregistered)
			{
				Monitor.Exit(this);
			}
			if (num2 == 0L)
			{
				return true;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x040009DA RID: 2522
		private WaitHandle _waitObject;

		// Token: 0x040009DB RID: 2523
		private WaitOrTimerCallback _callback;

		// Token: 0x040009DC RID: 2524
		private object _state;

		// Token: 0x040009DD RID: 2525
		private WaitHandle _finalEvent;

		// Token: 0x040009DE RID: 2526
		private ManualResetEvent _cancelEvent;

		// Token: 0x040009DF RID: 2527
		private TimeSpan _timeout;

		// Token: 0x040009E0 RID: 2528
		private int _callsInProcess;

		// Token: 0x040009E1 RID: 2529
		private bool _executeOnlyOnce;

		// Token: 0x040009E2 RID: 2530
		private bool _unregistered;
	}
}
