using System;
using System.Runtime.InteropServices;

namespace System.Security
{
	// Token: 0x0200029D RID: 669
	[ComVisible(true)]
	public static class SecurityManager
	{
		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06001720 RID: 5920 RVA: 0x00030D90 File Offset: 0x0002EF90
		[Obsolete("The security manager cannot be turned off on MS runtime")]
		public static bool SecurityEnabled
		{
			get
			{
			}
		}

		// Token: 0x06001721 RID: 5921 RVA: 0x00030DA0 File Offset: 0x0002EFA0
		internal static void EnsureElevatedPermissions()
		{
		}
	}
}
