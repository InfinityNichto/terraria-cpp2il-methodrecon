using System;

namespace System
{
	// Token: 0x02000118 RID: 280
	[Serializable]
	public class UnhandledExceptionEventArgs : EventArgs
	{
		// Token: 0x06000B05 RID: 2821 RVA: 0x000188D8 File Offset: 0x00016AD8
		public UnhandledExceptionEventArgs(object exception, bool isTerminating)
		{
			if (!true)
			{
			}
			base..ctor();
			this._exception = exception;
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000B06 RID: 2822 RVA: 0x000188F8 File Offset: 0x00016AF8
		public object ExceptionObject
		{
			get
			{
				return this._exception;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000B07 RID: 2823 RVA: 0x0001890C File Offset: 0x00016B0C
		public bool IsTerminating
		{
			get
			{
				return this._isTerminating;
			}
		}

		// Token: 0x040003FF RID: 1023
		private object _exception;

		// Token: 0x04000400 RID: 1024
		private bool _isTerminating;
	}
}
