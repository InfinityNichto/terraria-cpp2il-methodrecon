using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Activation
{
	// Token: 0x02000388 RID: 904
	[ComVisible(true)]
	public interface IActivator
	{
		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06001D60 RID: 7520
		IActivator NextActivator { get; }

		// Token: 0x06001D61 RID: 7521
		IConstructionReturnMessage Activate(IConstructionCallMessage msg);
	}
}
