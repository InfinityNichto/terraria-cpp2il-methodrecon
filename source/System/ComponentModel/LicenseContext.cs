using System;
using System.Reflection;

namespace System.ComponentModel
{
	// Token: 0x02000394 RID: 916
	public class LicenseContext : IServiceProvider
	{
		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x060017CE RID: 6094 RVA: 0x00043934 File Offset: 0x00041B34
		public virtual LicenseUsageMode UsageMode
		{
			get
			{
			}
		}

		// Token: 0x060017CF RID: 6095 RVA: 0x00043944 File Offset: 0x00041B44
		public virtual string GetSavedLicenseKey(Type type, Assembly resourceAssembly)
		{
		}

		// Token: 0x060017D0 RID: 6096 RVA: 0x00043954 File Offset: 0x00041B54
		public virtual object GetService(Type type)
		{
		}

		// Token: 0x060017D1 RID: 6097 RVA: 0x00043964 File Offset: 0x00041B64
		public virtual void SetSavedLicenseKey(Type type, string key)
		{
		}

		// Token: 0x060017D2 RID: 6098 RVA: 0x00043974 File Offset: 0x00041B74
		public LicenseContext()
		{
		}
	}
}
