using System;
using System.Xml;

namespace System.Configuration
{
	// Token: 0x02000452 RID: 1106
	public interface IConfigurationSectionHandler
	{
		// Token: 0x06001E02 RID: 7682
		object Create(object parent, object configContext, XmlNode section);
	}
}
