using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	// Token: 0x0200013C RID: 316
	public class XmlSchemaAny : XmlSchemaParticle
	{
		// Token: 0x1700030E RID: 782
		// (set) Token: 0x06000ABA RID: 2746 RVA: 0x0001DF78 File Offset: 0x0001C178
		[XmlAttribute("processContents")]
		[DefaultValue(XmlSchemaContentProcessing.None)]
		public XmlSchemaContentProcessing ProcessContents
		{
			set
			{
				this.processContents = value;
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x0001DF8C File Offset: 0x0001C18C
		[XmlIgnore]
		internal NamespaceList NamespaceList
		{
			get
			{
				return this.namespaceList;
			}
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x0001DFA0 File Offset: 0x0001C1A0
		internal void BuildNamespaceList(string targetNamespace)
		{
			if (this.ns != null)
			{
				return;
			}
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x0001DFB8 File Offset: 0x0001C1B8
		public XmlSchemaAny()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x0400056F RID: 1391
		private string ns;

		// Token: 0x04000570 RID: 1392
		private XmlSchemaContentProcessing processContents;

		// Token: 0x04000571 RID: 1393
		private NamespaceList namespaceList;
	}
}
