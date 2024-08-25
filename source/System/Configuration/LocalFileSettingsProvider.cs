using System;
using System.Collections.Specialized;

namespace System.Configuration
{
	// Token: 0x0200049E RID: 1182
	public class LocalFileSettingsProvider : SettingsProvider, IApplicationSettingsProvider
	{
		// Token: 0x06001FF4 RID: 8180 RVA: 0x00052878 File Offset: 0x00050A78
		public LocalFileSettingsProvider()
		{
			throw new NotSupportedException();
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06001FF5 RID: 8181 RVA: 0x0005288C File Offset: 0x00050A8C
		// (set) Token: 0x06001FF6 RID: 8182 RVA: 0x000528A0 File Offset: 0x00050AA0
		public override string ApplicationName
		{
			get
			{
				throw new NotSupportedException();
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x000528B4 File Offset: 0x00050AB4
		public SettingsPropertyValue GetPreviousVersion(SettingsContext context, SettingsProperty property)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001FF8 RID: 8184 RVA: 0x000528C8 File Offset: 0x00050AC8
		public override SettingsPropertyValueCollection GetPropertyValues(SettingsContext context, SettingsPropertyCollection properties)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001FF9 RID: 8185 RVA: 0x000528DC File Offset: 0x00050ADC
		public override void Initialize(string name, global::System.Collections.Specialized.NameValueCollection values)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001FFA RID: 8186 RVA: 0x000528F0 File Offset: 0x00050AF0
		public void Reset(SettingsContext context)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001FFB RID: 8187 RVA: 0x00052904 File Offset: 0x00050B04
		public override void SetPropertyValues(SettingsContext context, SettingsPropertyValueCollection values)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001FFC RID: 8188 RVA: 0x00052918 File Offset: 0x00050B18
		public void Upgrade(SettingsContext context, SettingsPropertyCollection properties)
		{
			throw new NotSupportedException();
		}
	}
}
