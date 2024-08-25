using System;
using System.ComponentModel;

namespace System.Configuration
{
	// Token: 0x0200048A RID: 1162
	public class SettingChangingEventArgs : global::System.ComponentModel.CancelEventArgs
	{
		// Token: 0x06001FA0 RID: 8096 RVA: 0x000522B4 File Offset: 0x000504B4
		public SettingChangingEventArgs(string settingName, string settingClass, string settingKey, object newValue, bool cancel)
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06001FA1 RID: 8097 RVA: 0x000522C8 File Offset: 0x000504C8
		public object NewValue
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06001FA2 RID: 8098 RVA: 0x000522DC File Offset: 0x000504DC
		public string SettingClass
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06001FA3 RID: 8099 RVA: 0x000522F0 File Offset: 0x000504F0
		public string SettingKey
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06001FA4 RID: 8100 RVA: 0x00052304 File Offset: 0x00050504
		public string SettingName
		{
			get
			{
				throw new NotSupportedException();
			}
		}
	}
}
