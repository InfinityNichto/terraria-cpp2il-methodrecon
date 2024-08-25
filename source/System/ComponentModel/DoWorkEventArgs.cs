using System;

namespace System.ComponentModel
{
	// Token: 0x020003E0 RID: 992
	public class DoWorkEventArgs : CancelEventArgs
	{
		// Token: 0x06001A39 RID: 6713 RVA: 0x000488E4 File Offset: 0x00046AE4
		public DoWorkEventArgs(object argument)
		{
			this.argument = argument;
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06001A3A RID: 6714 RVA: 0x00048900 File Offset: 0x00046B00
		[global::System.SRDescription("Argument passed into the worker handler from BackgroundWorker.RunWorkerAsync.")]
		public object Argument
		{
			get
			{
				return this.argument;
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06001A3B RID: 6715 RVA: 0x00048914 File Offset: 0x00046B14
		// (set) Token: 0x06001A3C RID: 6716 RVA: 0x00048928 File Offset: 0x00046B28
		[global::System.SRDescription("Result from the worker function.")]
		public object Result
		{
			get
			{
				return this.result;
			}
			set
			{
				this.result = value;
			}
		}

		// Token: 0x04001307 RID: 4871
		private object result;

		// Token: 0x04001308 RID: 4872
		private object argument;
	}
}
