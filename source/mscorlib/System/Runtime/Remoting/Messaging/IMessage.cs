using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003AB RID: 939
	[ComVisible(true)]
	public interface IMessage
	{
		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06001E0F RID: 7695
		IDictionary Properties { get; }
	}
}
