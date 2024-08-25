using System;

namespace System.Configuration
{
	// Token: 0x020004B0 RID: 1200
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
	public sealed class SpecialSettingAttribute : Attribute
	{
		// Token: 0x0600202A RID: 8234 RVA: 0x00052C90 File Offset: 0x00050E90
		public SpecialSettingAttribute(SpecialSetting specialSetting)
		{
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x0600202B RID: 8235 RVA: 0x00052CA0 File Offset: 0x00050EA0
		public SpecialSetting SpecialSetting
		{
			get
			{
				throw new NotSupportedException();
			}
		}
	}
}
