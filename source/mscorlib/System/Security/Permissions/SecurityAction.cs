using System;
using System.Runtime.InteropServices;

namespace System.Security.Permissions
{
	// Token: 0x020002AE RID: 686
	[Obsolete("CAS support is not available with Silverlight applications.")]
	[ComVisible(true)]
	[Serializable]
	public enum SecurityAction
	{
		// Token: 0x04000BF2 RID: 3058
		Demand = 2,
		// Token: 0x04000BF3 RID: 3059
		Assert,
		// Token: 0x04000BF4 RID: 3060
		[Obsolete("This requests should not be used")]
		Deny,
		// Token: 0x04000BF5 RID: 3061
		PermitOnly,
		// Token: 0x04000BF6 RID: 3062
		LinkDemand,
		// Token: 0x04000BF7 RID: 3063
		InheritanceDemand,
		// Token: 0x04000BF8 RID: 3064
		[Obsolete("This requests should not be used")]
		RequestMinimum,
		// Token: 0x04000BF9 RID: 3065
		[Obsolete("This requests should not be used")]
		RequestOptional,
		// Token: 0x04000BFA RID: 3066
		[Obsolete("This requests should not be used")]
		RequestRefuse
	}
}
