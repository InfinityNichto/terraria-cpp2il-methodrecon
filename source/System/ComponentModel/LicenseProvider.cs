using System;

namespace System.ComponentModel
{
	// Token: 0x02000396 RID: 918
	public abstract class LicenseProvider
	{
		// Token: 0x060017E7 RID: 6119
		public abstract License GetLicense(LicenseContext context, Type type, object instance, bool allowExceptions);

		// Token: 0x060017E8 RID: 6120 RVA: 0x00043C1C File Offset: 0x00041E1C
		protected LicenseProvider()
		{
		}
	}
}
