using System;

namespace System.Configuration
{
	// Token: 0x020004B1 RID: 1201
	public sealed class UriSection : ConfigurationSection
	{
		// Token: 0x0600202C RID: 8236 RVA: 0x00052CB4 File Offset: 0x00050EB4
		public UriSection()
		{
			throw new NotSupportedException();
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x0600202D RID: 8237 RVA: 0x00052CC8 File Offset: 0x00050EC8
		public IdnElement Idn
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x0600202E RID: 8238 RVA: 0x00052CDC File Offset: 0x00050EDC
		public IriParsingElement IriParsing
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x0600202F RID: 8239 RVA: 0x00052CF0 File Offset: 0x00050EF0
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x06002030 RID: 8240 RVA: 0x00052D04 File Offset: 0x00050F04
		public SchemeSettingElementCollection SchemeSettings
		{
			get
			{
				throw new NotSupportedException();
			}
		}
	}
}
