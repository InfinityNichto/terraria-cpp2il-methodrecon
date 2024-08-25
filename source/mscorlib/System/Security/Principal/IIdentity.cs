using System;

namespace System.Security.Principal
{
	// Token: 0x02000326 RID: 806
	public interface IIdentity
	{
		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06001B56 RID: 6998
		string Name { get; }

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06001B57 RID: 6999
		string AuthenticationType { get; }
	}
}
