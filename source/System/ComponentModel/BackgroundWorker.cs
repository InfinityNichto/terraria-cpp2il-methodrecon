using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.ComponentModel
{
	// Token: 0x02000330 RID: 816
	[DefaultEvent("DoWork")]
	public class BackgroundWorker : Component
	{
		// Token: 0x06001542 RID: 5442 RVA: 0x0003FCE4 File Offset: 0x0003DEE4
		public BackgroundWorker()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x0003FCFC File Offset: 0x0003DEFC
		private void AsyncOperationCompleted(object arg)
		{
			if (arg != null)
			{
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06001544 RID: 5444 RVA: 0x0003FD14 File Offset: 0x0003DF14
		public bool CancellationPending
		{
			get
			{
				return this._cancellationPending;
			}
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x0003FD28 File Offset: 0x0003DF28
		public void CancelAsync()
		{
			while (!this._canCancelWorker)
			{
			}
			this._cancellationPending = true;
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06001546 RID: 5446 RVA: 0x0003FD44 File Offset: 0x0003DF44
		// (remove) Token: 0x06001547 RID: 5447 RVA: 0x0003FD68 File Offset: 0x0003DF68
		public event DoWorkEventHandler DoWork
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.DoWork, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06001548 RID: 5448 RVA: 0x0003FD80 File Offset: 0x0003DF80
		public bool IsBusy
		{
			get
			{
				return this._isRunning;
			}
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x0003FD94 File Offset: 0x0003DF94
		protected virtual void OnDoWork(DoWorkEventArgs e)
		{
			DoWorkEventHandler doWork = this.DoWork;
			if (doWork != null)
			{
				IntPtr invoke_impl = doWork.invoke_impl;
				IntPtr method_code = doWork.method_code;
				IntPtr method = doWork.method;
				return;
			}
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x0003FDC4 File Offset: 0x0003DFC4
		protected virtual void OnRunWorkerCompleted(RunWorkerCompletedEventArgs e)
		{
			RunWorkerCompletedEventHandler runWorkerCompleted = this.RunWorkerCompleted;
			if (runWorkerCompleted != null)
			{
				IntPtr invoke_impl = runWorkerCompleted.invoke_impl;
				IntPtr method_code = runWorkerCompleted.method_code;
				IntPtr method = runWorkerCompleted.method;
				return;
			}
		}

		// Token: 0x0600154B RID: 5451 RVA: 0x0003FDF4 File Offset: 0x0003DFF4
		protected virtual void OnProgressChanged(ProgressChangedEventArgs e)
		{
			ProgressChangedEventHandler progressChanged = this.ProgressChanged;
			if (progressChanged != null)
			{
				IntPtr invoke_impl = progressChanged.invoke_impl;
				IntPtr method_code = progressChanged.method_code;
				IntPtr method = progressChanged.method;
				return;
			}
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x0600154C RID: 5452 RVA: 0x0003FE24 File Offset: 0x0003E024
		// (remove) Token: 0x0600154D RID: 5453 RVA: 0x0003FE48 File Offset: 0x0003E048
		public event ProgressChangedEventHandler ProgressChanged
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.ProgressChanged, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.ProgressChanged, value) != null)
				{
				}
			}
		}

		// Token: 0x0600154E RID: 5454 RVA: 0x0003FE6C File Offset: 0x0003E06C
		private void ProgressReporter(object arg)
		{
			if (arg != null)
			{
			}
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x0003FE84 File Offset: 0x0003E084
		public void ReportProgress(int percentProgress)
		{
			long num = 0L;
			this.ReportProgress(percentProgress, num);
		}

		// Token: 0x06001550 RID: 5456 RVA: 0x0003FE9C File Offset: 0x0003E09C
		public void ReportProgress(int percentProgress, object userState)
		{
			while (!this._workerReportsProgress)
			{
			}
			AsyncOperation asyncOperation = this._asyncOperation;
			SendOrPostCallback progressReporter = this._progressReporter;
			if (asyncOperation != null)
			{
				return;
			}
			IntPtr invoke_impl = progressReporter.invoke_impl;
			IntPtr method_code = progressReporter.method_code;
			IntPtr method = progressReporter.method;
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x0003FEDC File Offset: 0x0003E0DC
		public void RunWorkerAsync()
		{
			long num = 0L;
			this.RunWorkerAsync(num);
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x0003FEF4 File Offset: 0x0003E0F4
		public void RunWorkerAsync(object argument)
		{
			while (this._isRunning)
			{
			}
			this._cancellationPending = 256 != 0;
			SynchronizationContext synchronizationContext = AsyncOperationManager.SynchronizationContext;
			AsyncOperation asyncOperation = AsyncOperation.CreateOperation(0, synchronizationContext);
			this._asyncOperation = asyncOperation;
			if (256 == 0)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			CancellationToken none = CancellationToken.None;
			if (!true)
			{
			}
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06001553 RID: 5459 RVA: 0x0003FF44 File Offset: 0x0003E144
		// (remove) Token: 0x06001554 RID: 5460 RVA: 0x0003FF68 File Offset: 0x0003E168
		public event RunWorkerCompletedEventHandler RunWorkerCompleted
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.RunWorkerCompleted, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.RunWorkerCompleted, value) != null)
				{
				}
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06001555 RID: 5461 RVA: 0x0003FF8C File Offset: 0x0003E18C
		// (set) Token: 0x06001556 RID: 5462 RVA: 0x0003FFA0 File Offset: 0x0003E1A0
		public bool WorkerReportsProgress
		{
			get
			{
				return this._workerReportsProgress;
			}
			set
			{
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06001557 RID: 5463 RVA: 0x0003FFB0 File Offset: 0x0003E1B0
		// (set) Token: 0x06001558 RID: 5464 RVA: 0x0003FFC4 File Offset: 0x0003E1C4
		public bool WorkerSupportsCancellation
		{
			get
			{
				return this._canCancelWorker;
			}
			set
			{
			}
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x0003FFD4 File Offset: 0x0003E1D4
		private void WorkerThreadStart(object argument)
		{
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x0003FFFC File Offset: 0x0003E1FC
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x0004000C File Offset: 0x0003E20C
		[CompilerGenerated]
		private void <RunWorkerAsync>b__27_0(object arg)
		{
			this.WorkerThreadStart(arg);
		}

		// Token: 0x04001176 RID: 4470
		private bool _canCancelWorker;

		// Token: 0x04001177 RID: 4471
		private bool _workerReportsProgress;

		// Token: 0x04001178 RID: 4472
		private bool _cancellationPending;

		// Token: 0x04001179 RID: 4473
		private bool _isRunning;

		// Token: 0x0400117A RID: 4474
		private AsyncOperation _asyncOperation;

		// Token: 0x0400117B RID: 4475
		private readonly SendOrPostCallback _operationCompleted;

		// Token: 0x0400117C RID: 4476
		private readonly SendOrPostCallback _progressReporter;

		// Token: 0x0400117D RID: 4477
		[CompilerGenerated]
		private DoWorkEventHandler DoWork;

		// Token: 0x0400117E RID: 4478
		[CompilerGenerated]
		private ProgressChangedEventHandler ProgressChanged;

		// Token: 0x0400117F RID: 4479
		[CompilerGenerated]
		private RunWorkerCompletedEventHandler RunWorkerCompleted;
	}
}
