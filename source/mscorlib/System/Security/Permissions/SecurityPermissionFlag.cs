using System;
using System.Runtime.InteropServices;

namespace System.Security.Permissions
{
	// Token: 0x020002B1 RID: 689
	[Flags]
	[Obsolete("CAS support is not available with Silverlight applications.")]
	[ComVisible(true)]
	[Serializable]
	public enum SecurityPermissionFlag
	{
		// Token: 0x04000BFF RID: 3071
		NoFlags = 0,
		// Token: 0x04000C00 RID: 3072
		Assertion = 1,
		// Token: 0x04000C01 RID: 3073
		UnmanagedCode = 2,
		// Token: 0x04000C02 RID: 3074
		SkipVerification = 4,
		// Token: 0x04000C03 RID: 3075
		Execution = 8,
		// Token: 0x04000C04 RID: 3076
		ControlThread = 16,
		// Token: 0x04000C05 RID: 3077
		ControlEvidence = 32,
		// Token: 0x04000C06 RID: 3078
		ControlPolicy = 64,
		// Token: 0x04000C07 RID: 3079
		SerializationFormatter = 128,
		// Token: 0x04000C08 RID: 3080
		ControlDomainPolicy = 256,
		// Token: 0x04000C09 RID: 3081
		ControlPrincipal = 512,
		// Token: 0x04000C0A RID: 3082
		ControlAppDomain = 1024,
		// Token: 0x04000C0B RID: 3083
		RemotingConfiguration = 2048,
		// Token: 0x04000C0C RID: 3084
		Infrastructure = 4096,
		// Token: 0x04000C0D RID: 3085
		BindingRedirects = 8192,
		// Token: 0x04000C0E RID: 3086
		AllFlags = 16383
	}
}
