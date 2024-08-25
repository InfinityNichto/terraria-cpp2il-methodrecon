using System;

namespace System.Configuration
{
	// Token: 0x0200048C RID: 1164
	public class SettingsLoadedEventArgs : EventArgs
	{
		// Token: 0x06001FA9 RID: 8105 RVA: 0x00052368 File Offset: 0x00050568
		public SettingsLoadedEventArgs(SettingsProvider provider)
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06001FAA RID: 8106 RVA: 0x0005237C File Offset: 0x0005057C
		public SettingsProvider Provider
		{
			get
			{
				throw new NotSupportedException();
			}
		}
	}
}
