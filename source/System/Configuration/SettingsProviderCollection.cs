using System;
using System.Configuration.Provider;

namespace System.Configuration
{
	// Token: 0x0200045D RID: 1117
	public class SettingsProviderCollection : ProviderCollection
	{
		// Token: 0x06001E55 RID: 7765 RVA: 0x00050920 File Offset: 0x0004EB20
		public SettingsProviderCollection()
		{
			throw new NotSupportedException();
		}

		// Token: 0x170006DE RID: 1758
		public SettingsProvider this[string name]
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x00050948 File Offset: 0x0004EB48
		public override void Add(ProviderBase provider)
		{
			throw new NotSupportedException();
		}
	}
}
