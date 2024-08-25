using System;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003AA RID: 938
	internal interface IInternalMessage
	{
		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06001E0B RID: 7691
		// (set) Token: 0x06001E0C RID: 7692
		Identity TargetIdentity { get; set; }

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06001E0D RID: 7693
		// (set) Token: 0x06001E0E RID: 7694
		string Uri { get; set; }
	}
}
