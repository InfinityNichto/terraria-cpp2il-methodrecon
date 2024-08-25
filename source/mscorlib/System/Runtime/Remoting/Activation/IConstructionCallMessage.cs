using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Activation
{
	// Token: 0x02000389 RID: 905
	[ComVisible(true)]
	public interface IConstructionCallMessage : IMessage, IMethodCallMessage, IMethodMessage
	{
		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06001D62 RID: 7522
		Type ActivationType { get; }

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06001D63 RID: 7523
		string ActivationTypeName { get; }

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06001D64 RID: 7524
		// (set) Token: 0x06001D65 RID: 7525
		IActivator Activator { get; set; }

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06001D66 RID: 7526
		object[] CallSiteActivationAttributes { get; }

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06001D67 RID: 7527
		IList ContextProperties { get; }
	}
}
