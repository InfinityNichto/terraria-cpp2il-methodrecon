using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003B0 RID: 944
	[ComVisible(true)]
	public interface IMethodReturnMessage : IMethodMessage, IMessage
	{
		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06001E1B RID: 7707
		Exception Exception { get; }

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06001E1C RID: 7708
		object[] OutArgs { get; }

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06001E1D RID: 7709
		object ReturnValue { get; }
	}
}
