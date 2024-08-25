using System;
using System.ComponentModel;

namespace System.Diagnostics
{
	// Token: 0x020000E0 RID: 224
	[AttributeUsage(AttributeTargets.All)]
	public class MonitoringDescriptionAttribute : global::System.ComponentModel.DescriptionAttribute
	{
		// Token: 0x0600052E RID: 1326 RVA: 0x00014DD0 File Offset: 0x00012FD0
		public MonitoringDescriptionAttribute(string description)
		{
			if (!true)
			{
			}
			base..ctor(description);
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x00014DE8 File Offset: 0x00012FE8
		public override string Description
		{
			get
			{
				return base.Description;
			}
		}
	}
}
