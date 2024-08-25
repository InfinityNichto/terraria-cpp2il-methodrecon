using System;

namespace System.Xml.Schema
{
	// Token: 0x020000D9 RID: 217
	internal class XsdSimpleValue
	{
		// Token: 0x17000208 RID: 520
		// (get) Token: 0x0600086D RID: 2157 RVA: 0x0001AAD4 File Offset: 0x00018CD4
		public XmlSchemaSimpleType XmlType
		{
			get
			{
				return this.xmlType;
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x0600086E RID: 2158 RVA: 0x0001AAE8 File Offset: 0x00018CE8
		public object TypedValue
		{
			get
			{
				return this.typedValue;
			}
		}

		// Token: 0x04000450 RID: 1104
		private XmlSchemaSimpleType xmlType;

		// Token: 0x04000451 RID: 1105
		private object typedValue;
	}
}
