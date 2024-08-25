using System;
using System.Security;
using System.Security.Permissions;

namespace System.Net
{
	// Token: 0x0200045F RID: 1119
	[Serializable]
	public sealed class DnsPermission : CodeAccessPermission, IUnrestrictedPermission
	{
		// Token: 0x06001E5B RID: 7771 RVA: 0x0005095C File Offset: 0x0004EB5C
		public DnsPermission(PermissionState state)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001E5C RID: 7772 RVA: 0x00050970 File Offset: 0x0004EB70
		public override IPermission Copy()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001E5D RID: 7773 RVA: 0x00050984 File Offset: 0x0004EB84
		public override void FromXml(SecurityElement securityElement)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001E5E RID: 7774 RVA: 0x00050998 File Offset: 0x0004EB98
		public override IPermission Intersect(IPermission target)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001E5F RID: 7775 RVA: 0x000509AC File Offset: 0x0004EBAC
		public override bool IsSubsetOf(IPermission target)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001E60 RID: 7776 RVA: 0x000509C0 File Offset: 0x0004EBC0
		public bool IsUnrestricted()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001E61 RID: 7777 RVA: 0x000509D4 File Offset: 0x0004EBD4
		public override SecurityElement ToXml()
		{
			throw new NotSupportedException();
		}
	}
}
