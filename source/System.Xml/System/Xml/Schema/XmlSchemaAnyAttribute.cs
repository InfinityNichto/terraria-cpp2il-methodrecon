using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	// Token: 0x0200013D RID: 317
	public class XmlSchemaAnyAttribute : XmlSchemaAnnotated
	{
		// Token: 0x17000310 RID: 784
		// (set) Token: 0x06000ABE RID: 2750 RVA: 0x0001DFD0 File Offset: 0x0001C1D0
		[DefaultValue(XmlSchemaContentProcessing.None)]
		[XmlAttribute("processContents")]
		public XmlSchemaContentProcessing ProcessContents
		{
			set
			{
				this.processContents = value;
			}
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x0001DFE4 File Offset: 0x0001C1E4
		internal void BuildNamespaceList(string targetNamespace)
		{
			if (this.ns != null)
			{
				return;
			}
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x0001DFFC File Offset: 0x0001C1FC
		public XmlSchemaAnyAttribute()
		{
		}

		// Token: 0x04000572 RID: 1394
		private string ns;

		// Token: 0x04000573 RID: 1395
		private XmlSchemaContentProcessing processContents;

		// Token: 0x04000574 RID: 1396
		private NamespaceList namespaceList;
	}
}
