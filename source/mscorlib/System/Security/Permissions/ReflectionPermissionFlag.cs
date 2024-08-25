using System;

namespace System.Security.Permissions
{
	// Token: 0x020002AB RID: 683
	[Flags]
	public enum ReflectionPermissionFlag
	{
		// Token: 0x04000BEA RID: 3050
		[Obsolete("This permission has been deprecated. Use PermissionState.Unrestricted to get full access.")]
		AllFlags = 7,
		// Token: 0x04000BEB RID: 3051
		MemberAccess = 2,
		// Token: 0x04000BEC RID: 3052
		NoFlags = 0,
		// Token: 0x04000BED RID: 3053
		[Obsolete("This permission is no longer used by the CLR.")]
		ReflectionEmit = 4,
		// Token: 0x04000BEE RID: 3054
		RestrictedMemberAccess = 8,
		// Token: 0x04000BEF RID: 3055
		[Obsolete("This API has been deprecated. http://go.microsoft.com/fwlink/?linkid=14202")]
		TypeInformation = 1
	}
}
