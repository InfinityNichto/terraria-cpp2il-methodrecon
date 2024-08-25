using System;

namespace System.Configuration
{
	// Token: 0x0200049B RID: 1179
	public interface IPersistComponentSettings
	{
		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x06001FE8 RID: 8168
		// (set) Token: 0x06001FE9 RID: 8169
		bool SaveSettings { get; set; }

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06001FEA RID: 8170
		// (set) Token: 0x06001FEB RID: 8171
		string SettingsKey { get; set; }

		// Token: 0x06001FEC RID: 8172
		void LoadComponentSettings();

		// Token: 0x06001FED RID: 8173
		void ResetComponentSettings();

		// Token: 0x06001FEE RID: 8174
		void SaveComponentSettings();
	}
}
