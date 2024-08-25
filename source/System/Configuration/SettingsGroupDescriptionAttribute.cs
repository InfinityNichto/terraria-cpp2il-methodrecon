using System;

namespace System.Configuration
{
	// Token: 0x020004A5 RID: 1189
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class SettingsGroupDescriptionAttribute : Attribute
	{
		// Token: 0x06002011 RID: 8209 RVA: 0x00052AB4 File Offset: 0x00050CB4
		public SettingsGroupDescriptionAttribute(string description)
		{
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x06002012 RID: 8210 RVA: 0x00052AC4 File Offset: 0x00050CC4
		public string Description
		{
			get
			{
				throw new NotSupportedException();
			}
		}
	}
}
