using System;
using System.Configuration.Provider;

namespace System.Configuration
{
	// Token: 0x02000458 RID: 1112
	public abstract class SettingsProvider : ProviderBase
	{
		// Token: 0x06001E36 RID: 7734 RVA: 0x00050704 File Offset: 0x0004E904
		protected SettingsProvider()
		{
			throw new NotSupportedException();
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06001E37 RID: 7735
		// (set) Token: 0x06001E38 RID: 7736
		public abstract string ApplicationName { get; set; }

		// Token: 0x06001E39 RID: 7737
		public abstract SettingsPropertyValueCollection GetPropertyValues(SettingsContext context, SettingsPropertyCollection collection);

		// Token: 0x06001E3A RID: 7738
		public abstract void SetPropertyValues(SettingsContext context, SettingsPropertyValueCollection collection);
	}
}
