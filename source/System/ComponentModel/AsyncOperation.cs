using System;
using System.Threading;
using Cpp2IlInjected;

namespace System.ComponentModel
{
	// Token: 0x0200032E RID: 814
	public sealed class AsyncOperation
	{
		// Token: 0x06001532 RID: 5426 RVA: 0x0003FB0C File Offset: 0x0003DD0C
		private AsyncOperation(object userSuppliedState, SynchronizationContext syncContext)
		{
			this._syncContext = syncContext;
			this._userSuppliedState = userSuppliedState;
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x0003FB30 File Offset: 0x0003DD30
		protected override void Finalize()
		{
			if (this._alreadyCompleted || this._syncContext != null)
			{
			}
			base.Finalize();
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06001534 RID: 5428 RVA: 0x0003FB74 File Offset: 0x0003DD74
		public object UserSuppliedState
		{
			get
			{
				return this._userSuppliedState;
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06001535 RID: 5429 RVA: 0x0003FB88 File Offset: 0x0003DD88
		public SynchronizationContext SynchronizationContext
		{
			get
			{
				return this._syncContext;
			}
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x0003FB9C File Offset: 0x0003DD9C
		public void Post(SendOrPostCallback d, object arg)
		{
			long num = 0L;
			this.PostCore(d, arg, num != 0L);
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x0003FBB4 File Offset: 0x0003DDB4
		public void PostOperationCompleted(SendOrPostCallback d, object arg)
		{
			this.PostCore(d, arg, true);
			this.OperationCompletedCore();
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x0003FBD0 File Offset: 0x0003DDD0
		public void OperationCompleted()
		{
			this.VerifyNotCompleted();
			this._alreadyCompleted = true;
			this.OperationCompletedCore();
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x0003FBF0 File Offset: 0x0003DDF0
		private void PostCore(SendOrPostCallback d, object arg, bool markCompleted)
		{
			this.VerifyNotCompleted();
			this.VerifyDelegateNotNull(d);
			this._alreadyCompleted = true;
			SynchronizationContext syncContext = this._syncContext;
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x0003FC18 File Offset: 0x0003DE18
		private void OperationCompletedCore()
		{
			SynchronizationContext syncContext = this._syncContext;
			long num = 0L;
			GC.SuppressFinalize(this);
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x0003FC58 File Offset: 0x0003DE58
		private void VerifyNotCompleted()
		{
			while (this._alreadyCompleted)
			{
			}
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x0003FC70 File Offset: 0x0003DE70
		private void VerifyDelegateNotNull(SendOrPostCallback d)
		{
			while (d == null)
			{
			}
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x00002050 File Offset: 0x00000250
		internal static AsyncOperation CreateOperation(object userSuppliedState, SynchronizationContext syncContext)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600153E RID: 5438 RVA: 0x0003FC80 File Offset: 0x0003DE80
		internal AsyncOperation()
		{
			throw new NotSupportedException();
		}

		// Token: 0x04001173 RID: 4467
		private readonly SynchronizationContext _syncContext;

		// Token: 0x04001174 RID: 4468
		private readonly object _userSuppliedState;

		// Token: 0x04001175 RID: 4469
		private bool _alreadyCompleted;
	}
}
