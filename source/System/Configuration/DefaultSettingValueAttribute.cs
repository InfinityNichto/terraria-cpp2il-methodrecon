using System;

namespace System.Configuration
{
	// Token: 0x02000496 RID: 1174
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class DefaultSettingValueAttribute : Attribute
	{
		// Token: 0x06001FDA RID: 8154 RVA: 0x0005273C File Offset: 0x0005093C
		public DefaultSettingValueAttribute(string value)
		{
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06001FDB RID: 8155 RVA: 0x0005274C File Offset: 0x0005094C
		public string Value
		{
			get
			{
				throw new NotSupportedException();
			}
		}
	}
}
