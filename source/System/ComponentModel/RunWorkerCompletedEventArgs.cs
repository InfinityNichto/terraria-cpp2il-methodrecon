using System;

namespace System.ComponentModel
{
	// Token: 0x020003EC RID: 1004
	public class RunWorkerCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001ADA RID: 6874 RVA: 0x0004AD44 File Offset: 0x00048F44
		public RunWorkerCompletedEventArgs(object result, Exception error, bool cancelled)
		{
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06001ADB RID: 6875 RVA: 0x0004AD58 File Offset: 0x00048F58
		public object Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return this.result;
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06001ADC RID: 6876 RVA: 0x0004AD74 File Offset: 0x00048F74
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public new object UserState
		{
			get
			{
				return this.userState;
			}
		}

		// Token: 0x0400134E RID: 4942
		private object result = result;
	}
}
