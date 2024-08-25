using System;
using System.Xml;

namespace System.Configuration
{
	// Token: 0x0200049A RID: 1178
	public class IgnoreSectionHandler : IConfigurationSectionHandler
	{
		// Token: 0x06001FE6 RID: 8166 RVA: 0x00052800 File Offset: 0x00050A00
		public IgnoreSectionHandler()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001FE7 RID: 8167 RVA: 0x00052814 File Offset: 0x00050A14
		public virtual object Create(object parent, object configContext, XmlNode section)
		{
			throw new NotSupportedException();
		}
	}
}
