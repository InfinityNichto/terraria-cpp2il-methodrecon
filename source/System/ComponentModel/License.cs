using System;

namespace System.ComponentModel
{
	// Token: 0x02000393 RID: 915
	public abstract class License : IDisposable
	{
		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x060017CB RID: 6091
		public abstract string LicenseKey { get; }

		// Token: 0x060017CC RID: 6092
		public abstract void Dispose();

		// Token: 0x060017CD RID: 6093 RVA: 0x00043920 File Offset: 0x00041B20
		protected License()
		{
		}
	}
}
