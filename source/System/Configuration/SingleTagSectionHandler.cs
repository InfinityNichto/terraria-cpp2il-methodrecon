using System;
using System.Xml;

namespace System.Configuration
{
	// Token: 0x020004AE RID: 1198
	public class SingleTagSectionHandler : IConfigurationSectionHandler
	{
		// Token: 0x06002028 RID: 8232 RVA: 0x00052C68 File Offset: 0x00050E68
		public SingleTagSectionHandler()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06002029 RID: 8233 RVA: 0x00052C7C File Offset: 0x00050E7C
		public virtual object Create(object parent, object context, XmlNode section)
		{
			throw new NotSupportedException();
		}
	}
}
