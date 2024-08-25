using System;
using System.Xml;

namespace System.Configuration
{
	// Token: 0x020004A0 RID: 1184
	public class NameValueSectionHandler : IConfigurationSectionHandler
	{
		// Token: 0x06001FFF RID: 8191 RVA: 0x00052954 File Offset: 0x00050B54
		public NameValueSectionHandler()
		{
			throw new NotSupportedException();
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06002000 RID: 8192 RVA: 0x00052968 File Offset: 0x00050B68
		protected virtual string KeyAttributeName
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06002001 RID: 8193 RVA: 0x0005297C File Offset: 0x00050B7C
		protected virtual string ValueAttributeName
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x06002002 RID: 8194 RVA: 0x00052990 File Offset: 0x00050B90
		public object Create(object parent, object context, XmlNode section)
		{
			throw new NotSupportedException();
		}
	}
}
