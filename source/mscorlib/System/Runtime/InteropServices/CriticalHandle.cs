using System;
using System.Runtime.ConstrainedExecution;

namespace System.Runtime.InteropServices
{
	// Token: 0x0200044D RID: 1101
	public abstract class CriticalHandle : CriticalFinalizerObject, IDisposable
	{
		// Token: 0x0600217A RID: 8570 RVA: 0x0004C1D8 File Offset: 0x0004A3D8
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		protected CriticalHandle(IntPtr invalidHandleValue)
		{
			this.handle = invalidHandleValue;
		}

		// Token: 0x0600217B RID: 8571 RVA: 0x0004C1F4 File Offset: 0x0004A3F4
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		protected override void Finalize()
		{
			base.Finalize();
		}

		// Token: 0x0600217C RID: 8572 RVA: 0x0004C228 File Offset: 0x0004A428
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		private void Cleanup()
		{
			if (!this._isClosed)
			{
				this._isClosed = true;
			}
		}

		// Token: 0x0600217D RID: 8573 RVA: 0x0004C24C File Offset: 0x0004A44C
		private static void FireCustomerDebugProbe()
		{
		}

		// Token: 0x0600217E RID: 8574 RVA: 0x0004C25C File Offset: 0x0004A45C
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		protected void SetHandle(IntPtr handle)
		{
			this.handle = handle;
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x0600217F RID: 8575 RVA: 0x0004C270 File Offset: 0x0004A470
		public bool IsClosed
		{
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			get
			{
				return this._isClosed;
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06002180 RID: 8576
		public abstract bool IsInvalid
		{
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			get;
		}

		// Token: 0x06002181 RID: 8577 RVA: 0x0004C284 File Offset: 0x0004A484
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public void Dispose()
		{
		}

		// Token: 0x06002182 RID: 8578 RVA: 0x0004C294 File Offset: 0x0004A494
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		protected virtual void Dispose(bool disposing)
		{
			this.Cleanup();
		}

		// Token: 0x06002183 RID: 8579
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		protected abstract bool ReleaseHandle();

		// Token: 0x0400127B RID: 4731
		protected IntPtr handle;

		// Token: 0x0400127C RID: 4732
		private bool _isClosed;
	}
}
