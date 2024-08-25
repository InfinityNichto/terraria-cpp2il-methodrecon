using System;

namespace System.Configuration
{
	// Token: 0x0200045E RID: 1118
	public interface IApplicationSettingsProvider
	{
		// Token: 0x06001E58 RID: 7768
		SettingsPropertyValue GetPreviousVersion(SettingsContext context, SettingsProperty property);

		// Token: 0x06001E59 RID: 7769
		void Reset(SettingsContext context);

		// Token: 0x06001E5A RID: 7770
		void Upgrade(SettingsContext context, SettingsPropertyCollection properties);
	}
}
