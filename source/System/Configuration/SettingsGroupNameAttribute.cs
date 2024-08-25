using System;

namespace System.Configuration
{
	// Token: 0x020004A6 RID: 1190
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class SettingsGroupNameAttribute : Attribute
	{
		// Token: 0x06002013 RID: 8211 RVA: 0x00052AD8 File Offset: 0x00050CD8
		public SettingsGroupNameAttribute(string groupName)
		{
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06002014 RID: 8212 RVA: 0x00052AE8 File Offset: 0x00050CE8
		public string GroupName
		{
			get
			{
				throw new NotSupportedException();
			}
		}
	}
}
