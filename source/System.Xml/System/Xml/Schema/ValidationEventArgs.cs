using System;

namespace System.Xml.Schema
{
	// Token: 0x02000136 RID: 310
	public class ValidationEventArgs : EventArgs
	{
		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000A9C RID: 2716 RVA: 0x0001D9B0 File Offset: 0x0001BBB0
		public XmlSeverityType Severity
		{
			get
			{
				return this.severity;
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x0001D9C4 File Offset: 0x0001BBC4
		public XmlSchemaException Exception
		{
			get
			{
				return this.ex;
			}
		}

		// Token: 0x04000561 RID: 1377
		private XmlSchemaException ex;

		// Token: 0x04000562 RID: 1378
		private XmlSeverityType severity;
	}
}
