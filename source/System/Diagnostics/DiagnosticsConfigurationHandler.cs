using System;
using System.Configuration;
using System.Xml;

namespace System.Diagnostics
{
	// Token: 0x02000485 RID: 1157
	[Obsolete("This class has been deprecated.  http://go.microsoft.com/fwlink/?linkid=14202")]
	public class DiagnosticsConfigurationHandler : global::System.Configuration.IConfigurationSectionHandler
	{
		// Token: 0x06001F7B RID: 8059 RVA: 0x00051FD8 File Offset: 0x000501D8
		public DiagnosticsConfigurationHandler()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001F7C RID: 8060 RVA: 0x00051FEC File Offset: 0x000501EC
		public virtual object Create(object parent, object configContext, XmlNode section)
		{
			throw new NotSupportedException();
		}
	}
}
