using System;

namespace System.Diagnostics
{
	// Token: 0x020000CA RID: 202
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class SwitchLevelAttribute : Attribute
	{
		// Token: 0x0600049B RID: 1179 RVA: 0x000135E8 File Offset: 0x000117E8
		public SwitchLevelAttribute(Type switchLevelType)
		{
			this.SwitchLevelType = switchLevelType;
		}

		// Token: 0x170000C7 RID: 199
		// (set) Token: 0x0600049C RID: 1180 RVA: 0x00013604 File Offset: 0x00011804
		public Type SwitchLevelType
		{
			set
			{
				if (!true)
				{
				}
				bool flag = value == value;
				this.type = value;
			}
		}

		// Token: 0x04000393 RID: 915
		private Type type;
	}
}
