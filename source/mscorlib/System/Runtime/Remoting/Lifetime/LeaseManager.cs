using System;
using System.Collections;
using System.Threading;

namespace System.Runtime.Remoting.Lifetime
{
	// Token: 0x02000361 RID: 865
	internal class LeaseManager
	{
		// Token: 0x06001CC7 RID: 7367 RVA: 0x0003EBD0 File Offset: 0x0003CDD0
		public void SetPollTime(TimeSpan timeSpan)
		{
			ArrayList objects = this._objects;
			Timer timer = this._timer;
			if (timer != null)
			{
				bool flag = timer.Change(timeSpan, timeSpan);
				return;
			}
			long num = 0L;
			Monitor.Exit(objects);
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001CC8 RID: 7368 RVA: 0x0003EC28 File Offset: 0x0003CE28
		public void TrackLifetime(ServerIdentity identity)
		{
			ArrayList objects = this._objects;
			identity._lease._currentState = LeaseState.Active;
			ArrayList objects2 = this._objects;
			Timer timer = this._timer;
			if (timer == null)
			{
				this.StartManager();
			}
			long num = 0L;
			if (timer != null)
			{
				Monitor.Exit(objects);
			}
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001CC9 RID: 7369 RVA: 0x0003EC98 File Offset: 0x0003CE98
		public void StartManager()
		{
			if (!true)
			{
			}
			if (true)
			{
				return;
			}
			if (!true)
			{
			}
		}

		// Token: 0x06001CCA RID: 7370 RVA: 0x0003ECB0 File Offset: 0x0003CEB0
		public void StopManager()
		{
			Timer timer = this._timer;
			if (timer != null)
			{
				timer.Dispose();
				return;
			}
		}

		// Token: 0x06001CCB RID: 7371 RVA: 0x0003ECD0 File Offset: 0x0003CED0
		public void ManageLeases(object state)
		{
			ArrayList objects = this._objects;
			ArrayList objects2 = this._objects;
			ArrayList objects3 = this._objects;
			if (objects3 != null)
			{
			}
			ArrayList objects4 = this._objects;
		}

		// Token: 0x06001CCC RID: 7372 RVA: 0x0003ED58 File Offset: 0x0003CF58
		public LeaseManager()
		{
		}

		// Token: 0x04000E93 RID: 3731
		private ArrayList _objects;

		// Token: 0x04000E94 RID: 3732
		private Timer _timer;
	}
}
