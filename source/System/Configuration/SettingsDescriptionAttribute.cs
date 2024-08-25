using System;

namespace System.Configuration
{
	// Token: 0x020004A4 RID: 1188
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class SettingsDescriptionAttribute : Attribute
	{
		// Token: 0x0600200F RID: 8207 RVA: 0x00052A90 File Offset: 0x00050C90
		public SettingsDescriptionAttribute(string description)
		{
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x06002010 RID: 8208 RVA: 0x00052AA0 File Offset: 0x00050CA0
		public string Description
		{
			get
			{
				throw new NotSupportedException();
			}
		}
	}
}
