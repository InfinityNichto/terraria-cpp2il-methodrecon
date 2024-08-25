using System;
using System.Xml.Schema;

namespace System.Xml
{
	// Token: 0x02000020 RID: 32
	internal interface IValidationEventHandling
	{
		// Token: 0x060000B0 RID: 176
		void SendEvent(Exception exception, XmlSeverityType severity);
	}
}
