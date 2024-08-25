using System;

namespace System.Threading.Tasks
{
	// Token: 0x02000250 RID: 592
	public class UnobservedTaskExceptionEventArgs : EventArgs
	{
		// Token: 0x0600144D RID: 5197 RVA: 0x0002AA4C File Offset: 0x00028C4C
		public UnobservedTaskExceptionEventArgs(AggregateException exception)
		{
			if (!true)
			{
			}
			base..ctor();
			this.m_exception = exception;
		}

		// Token: 0x04000AC3 RID: 2755
		private AggregateException m_exception;

		// Token: 0x04000AC4 RID: 2756
		internal bool m_observed;
	}
}
