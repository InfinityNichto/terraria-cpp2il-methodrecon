using System;
using System.Runtime.InteropServices;

namespace System.Net.Security
{
	// Token: 0x02000316 RID: 790
	internal abstract class SafeFreeCredentials : SafeHandle
	{
		// Token: 0x06001493 RID: 5267 RVA: 0x0003E844 File Offset: 0x0003CA44
		protected SafeFreeCredentials(IntPtr handle, bool ownsHandle)
			: base(handle, ownsHandle)
		{
		}
	}
}
