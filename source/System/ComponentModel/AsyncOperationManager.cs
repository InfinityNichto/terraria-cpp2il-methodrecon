using System;
using System.Threading;

namespace System.ComponentModel
{
	// Token: 0x0200032F RID: 815
	public static class AsyncOperationManager
	{
		// Token: 0x0600153F RID: 5439 RVA: 0x0003FC94 File Offset: 0x0003DE94
		public static AsyncOperation CreateOperation(object userSuppliedState)
		{
			SynchronizationContext synchronizationContext = AsyncOperationManager.SynchronizationContext;
			return AsyncOperation.CreateOperation(synchronizationContext, synchronizationContext);
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06001540 RID: 5440 RVA: 0x0003FCB0 File Offset: 0x0003DEB0
		// (set) Token: 0x06001541 RID: 5441 RVA: 0x0003FCD0 File Offset: 0x0003DED0
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static SynchronizationContext SynchronizationContext
		{
			get
			{
				if (SynchronizationContext.Current == null)
				{
				}
				return SynchronizationContext.Current;
			}
			set
			{
				SynchronizationContext.SetSynchronizationContext(value);
			}
		}
	}
}
