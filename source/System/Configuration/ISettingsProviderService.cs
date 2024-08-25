using System;

namespace System.Configuration
{
	// Token: 0x0200049D RID: 1181
	public interface ISettingsProviderService
	{
		// Token: 0x06001FF3 RID: 8179
		SettingsProvider GetSettingsProvider(SettingsProperty property);
	}
}
