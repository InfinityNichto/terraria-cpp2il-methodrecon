using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ReLogic.Threading
{
	// Token: 0x02000B0F RID: 2831
	public class AsyncActionDispatcher : IDisposable
	{
		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x06005302 RID: 21250 RVA: 0x00283C90 File Offset: 0x00281E90
		public int ActionsRemaining
		{
			get
			{
				return this._actionQueue.Count;
			}
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06005303 RID: 21251 RVA: 0x00283CA8 File Offset: 0x00281EA8
		// (set) Token: 0x06005304 RID: 21252 RVA: 0x00283CBC File Offset: 0x00281EBC
		public bool IsDisposed
		{
			[CompilerGenerated]
			get
			{
				return this.<IsDisposed>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x06005305 RID: 21253 RVA: 0x00283CCC File Offset: 0x00281ECC
		public bool IsRunning
		{
			get
			{
				return this._isRunning;
			}
		}

		// Token: 0x06005306 RID: 21254 RVA: 0x00283CE0 File Offset: 0x00281EE0
		public void Queue(Action action)
		{
			BlockingCollection<Action> actionQueue = this._actionQueue;
		}

		// Token: 0x06005307 RID: 21255 RVA: 0x00283CF4 File Offset: 0x00281EF4
		public void Start()
		{
			while (this._isRunning)
			{
			}
			this._isRunning = true;
		}

		// Token: 0x06005308 RID: 21256 RVA: 0x00283D10 File Offset: 0x00281F10
		public void Stop()
		{
			while (!this._isRunning)
			{
			}
			this._threadCancellation.Cancel();
			this._actionThread.Join();
		}

		// Token: 0x06005309 RID: 21257 RVA: 0x00283D3C File Offset: 0x00281F3C
		private void LoaderThreadStart()
		{
			if (this._isRunning)
			{
				BlockingCollection<Action> actionQueue = this._actionQueue;
				CancellationToken token = this._threadCancellation.Token;
				Action action = actionQueue.Take(token);
				IntPtr method = action.method;
				IntPtr invoke_impl = action.invoke_impl;
				IntPtr method_code = action.method_code;
				return;
			}
		}

		// Token: 0x0600530A RID: 21258 RVA: 0x00283D8C File Offset: 0x00281F8C
		protected virtual void Dispose(bool disposing)
		{
			if (!this.<IsDisposed>k__BackingField)
			{
				if (this._isRunning)
				{
					this.Stop();
				}
				this._actionQueue.Dispose();
				this._threadCancellation.Dispose();
				this.<IsDisposed>k__BackingField = true;
			}
		}

		// Token: 0x0600530B RID: 21259 RVA: 0x00283DCC File Offset: 0x00281FCC
		public void Dispose()
		{
		}

		// Token: 0x0600530C RID: 21260 RVA: 0x00283DDC File Offset: 0x00281FDC
		public AsyncActionDispatcher()
		{
		}

		// Token: 0x04008AE7 RID: 35559
		private Thread _actionThread;

		// Token: 0x04008AE8 RID: 35560
		private readonly BlockingCollection<Action> _actionQueue;

		// Token: 0x04008AE9 RID: 35561
		private readonly CancellationTokenSource _threadCancellation;

		// Token: 0x04008AEA RID: 35562
		private bool _isRunning;

		// Token: 0x04008AEB RID: 35563
		[CompilerGenerated]
		private bool <IsDisposed>k__BackingField;
	}
}
