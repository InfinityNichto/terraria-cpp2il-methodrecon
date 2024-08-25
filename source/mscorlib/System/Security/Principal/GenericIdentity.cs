using System;
using System.Collections.Generic;
using System.Security.Claims;
using Cpp2IlInjected;

namespace System.Security.Principal
{
	// Token: 0x02000325 RID: 805
	[Serializable]
	public class GenericIdentity : ClaimsIdentity
	{
		// Token: 0x06001B4E RID: 6990 RVA: 0x0003AA84 File Offset: 0x00038C84
		public GenericIdentity(string name, string type)
		{
			while (name != null)
			{
				if (type != null)
				{
					this.m_name = name;
					this.m_type = type;
					this.AddNameClaim();
					return;
				}
			}
		}

		// Token: 0x06001B4F RID: 6991 RVA: 0x0003AAAC File Offset: 0x00038CAC
		private GenericIdentity()
		{
		}

		// Token: 0x06001B50 RID: 6992 RVA: 0x0003AABC File Offset: 0x00038CBC
		protected GenericIdentity(GenericIdentity identity)
			: base(identity)
		{
		}

		// Token: 0x06001B51 RID: 6993 RVA: 0x0000207A File Offset: 0x0000027A
		public override ClaimsIdentity Clone()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06001B52 RID: 6994 RVA: 0x0003AAD0 File Offset: 0x00038CD0
		public override IEnumerable<Claim> Claims
		{
			get
			{
				return base.Claims;
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06001B53 RID: 6995 RVA: 0x0003AAE4 File Offset: 0x00038CE4
		public override string Name
		{
			get
			{
				return this.m_name;
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06001B54 RID: 6996 RVA: 0x0003AAF8 File Offset: 0x00038CF8
		public override string AuthenticationType
		{
			get
			{
				return this.m_type;
			}
		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x0003AB0C File Offset: 0x00038D0C
		private void AddNameClaim()
		{
			if (this.m_name != null)
			{
				string nameType = this.m_nameType;
				return;
			}
		}

		// Token: 0x04000DDF RID: 3551
		private readonly string m_name;

		// Token: 0x04000DE0 RID: 3552
		private readonly string m_type;
	}
}
