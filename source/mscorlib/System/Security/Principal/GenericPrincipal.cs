using System;
using System.Runtime.InteropServices;
using System.Security.Claims;

namespace System.Security.Principal
{
	// Token: 0x02000329 RID: 809
	[ComVisible(true)]
	[Serializable]
	public class GenericPrincipal : ClaimsPrincipal
	{
		// Token: 0x06001B58 RID: 7000 RVA: 0x0003AB2C File Offset: 0x00038D2C
		public GenericPrincipal(IIdentity identity, string[] roles)
		{
			do
			{
				if (!true)
				{
				}
				base..ctor();
			}
			while (identity == null);
			this.m_identity = identity;
			if (roles != null)
			{
				string[] roles2 = this.m_roles;
				return;
			}
		}

		// Token: 0x04000DE7 RID: 3559
		private IIdentity m_identity;

		// Token: 0x04000DE8 RID: 3560
		private string[] m_roles;
	}
}
