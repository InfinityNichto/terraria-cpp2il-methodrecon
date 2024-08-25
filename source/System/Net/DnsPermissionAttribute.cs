using System;
using System.Security;
using System.Security.Permissions;

namespace System.Net
{
	// Token: 0x02000460 RID: 1120
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[Serializable]
	public sealed class DnsPermissionAttribute : CodeAccessSecurityAttribute
	{
		// Token: 0x06001E62 RID: 7778 RVA: 0x000509E8 File Offset: 0x0004EBE8
		public DnsPermissionAttribute(SecurityAction action)
		{
		}

		// Token: 0x06001E63 RID: 7779 RVA: 0x000509F8 File Offset: 0x0004EBF8
		public override IPermission CreatePermission()
		{
			throw new NotSupportedException();
		}
	}
}
