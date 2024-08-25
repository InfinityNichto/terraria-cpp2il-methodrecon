using System;

namespace System.ComponentModel
{
	// Token: 0x0200033E RID: 830
	public interface ISynchronizeInvoke
	{
		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x060015A1 RID: 5537
		bool InvokeRequired { get; }

		// Token: 0x060015A2 RID: 5538
		IAsyncResult BeginInvoke(Delegate method, object[] args);

		// Token: 0x060015A3 RID: 5539
		object EndInvoke(IAsyncResult result);

		// Token: 0x060015A4 RID: 5540
		object Invoke(Delegate method, object[] args);
	}
}
