using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Contexts
{
	// Token: 0x0200036D RID: 877
	[ComVisible(true)]
	public interface IContextProperty
	{
		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06001D12 RID: 7442
		string Name { get; }

		// Token: 0x06001D13 RID: 7443
		void Freeze(Context newContext);

		// Token: 0x06001D14 RID: 7444
		bool IsNewContextOK(Context newCtx);
	}
}
