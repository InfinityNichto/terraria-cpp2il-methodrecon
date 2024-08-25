using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using Microsoft.Win32.SafeHandles;

namespace System.Net.Sockets
{
	// Token: 0x02000309 RID: 777
	internal sealed class SafeSocketHandle : SafeHandleMinusOneIsInvalid
	{
		// Token: 0x06001441 RID: 5185 RVA: 0x0003DD44 File Offset: 0x0003BF44
		public SafeSocketHandle(IntPtr preexistingHandle, bool ownsHandle)
			: base(preexistingHandle != 0)
		{
			this.handle = preexistingHandle;
			if (!true)
			{
			}
			if (true)
			{
			}
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x0003DD68 File Offset: 0x0003BF68
		protected override bool ReleaseHandle()
		{
			int num = 1;
			IntPtr handle = this.handle;
			if (num == 0)
			{
			}
			IntPtr handle2 = this.handle;
			int num2 = 2;
			List<Thread> list = this.blocking_threads;
			long num8;
			if (list != null)
			{
				Monitor.Enter(list, num2 != 0);
				int num3 = 1;
				int size = this.blocking_threads._size;
				Thread currentThread = Thread.CurrentThread;
				List<Thread> list2 = this.blocking_threads;
				if (size == 0)
				{
				}
				long num4 = 0L;
				int num5 = 15;
				if (num4 != 0L)
				{
					throw new OutOfMemoryException();
				}
				if (num5 == 0)
				{
					List<Thread> list3 = this.blocking_threads;
					this.in_cleanup = num3 != 0;
					int num6 = 100;
					return Monitor.Wait(list3, num6);
				}
				long num7 = 0L;
				num8 = 0L;
				StringBuilder stringBuilder;
				Monitor.Exit(stringBuilder);
				if (num7 != 0L)
				{
					throw new OutOfMemoryException();
				}
			}
			Socket.Close_icall(this.handle, (int)num8);
			if (false)
			{
				throw new OutOfMemoryException();
			}
			long num9 = 0L;
			long num10;
			Monitor.Exit(num10);
			if (num9 == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x0003DE8C File Offset: 0x0003C08C
		public void RegisterForBlockingSyscall()
		{
			if (this.blocking_threads == null)
			{
			}
			base.DangerousAddRef(true);
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x0003DEAC File Offset: 0x0003C0AC
		public void UnRegisterForBlockingSyscall()
		{
			List<Thread> list = this.blocking_threads;
			Thread currentThread = Thread.CurrentThread;
			List<Thread> list2 = this.blocking_threads;
			List<Thread> list3 = this.blocking_threads;
			Dictionary<Thread, StackTrace> dictionary = this.threads_stacktraces;
			if (this.in_cleanup)
			{
				List<Thread> list4 = this.blocking_threads;
				int size = list4._size;
				if (size == 0)
				{
					Monitor.Pulse(list4);
					long num = 0L;
					if (size != 0)
					{
						Monitor.Exit(list);
					}
					if (num == 0L)
					{
						return;
					}
					throw new OutOfMemoryException();
				}
			}
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x0003DF44 File Offset: 0x0003C144
		// Note: this type is marked as 'beforefieldinit'.
		static SafeSocketHandle()
		{
			bool flag = Environment.GetEnvironmentVariable("MONO_TESTS_IN_PROGRESS") == "yes";
		}

		// Token: 0x040010E1 RID: 4321
		private List<Thread> blocking_threads;

		// Token: 0x040010E2 RID: 4322
		private Dictionary<Thread, StackTrace> threads_stacktraces;

		// Token: 0x040010E3 RID: 4323
		private bool in_cleanup;

		// Token: 0x040010E4 RID: 4324
		private static bool THROW_ON_ABORT_RETRIES;
	}
}
