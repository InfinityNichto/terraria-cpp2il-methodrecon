using System;

namespace System.Configuration
{
	// Token: 0x020004A8 RID: 1192
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
	public sealed class SettingsManageabilityAttribute : Attribute
	{
		// Token: 0x06002015 RID: 8213 RVA: 0x00052AFC File Offset: 0x00050CFC
		public SettingsManageabilityAttribute(SettingsManageability manageability)
		{
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x06002016 RID: 8214 RVA: 0x00052B0C File Offset: 0x00050D0C
		public SettingsManageability Manageability
		{
			get
			{
				throw new NotSupportedException();
			}
		}
	}
}
