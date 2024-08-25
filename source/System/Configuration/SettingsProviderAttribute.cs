using System;

namespace System.Configuration
{
	// Token: 0x020004AC RID: 1196
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
	public sealed class SettingsProviderAttribute : Attribute
	{
		// Token: 0x06002023 RID: 8227 RVA: 0x00052C10 File Offset: 0x00050E10
		public SettingsProviderAttribute(string providerTypeName)
		{
		}

		// Token: 0x06002024 RID: 8228 RVA: 0x00052C20 File Offset: 0x00050E20
		public SettingsProviderAttribute(Type providerType)
		{
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06002025 RID: 8229 RVA: 0x00052C30 File Offset: 0x00050E30
		public string ProviderTypeName
		{
			get
			{
				throw new NotSupportedException();
			}
		}
	}
}
