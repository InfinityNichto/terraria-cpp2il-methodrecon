using System;

namespace System.Configuration
{
	// Token: 0x020004AD RID: 1197
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
	public sealed class SettingsSerializeAsAttribute : Attribute
	{
		// Token: 0x06002026 RID: 8230 RVA: 0x00052C44 File Offset: 0x00050E44
		public SettingsSerializeAsAttribute(SettingsSerializeAs serializeAs)
		{
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06002027 RID: 8231 RVA: 0x00052C54 File Offset: 0x00050E54
		public SettingsSerializeAs SerializeAs
		{
			get
			{
				throw new NotSupportedException();
			}
		}
	}
}
