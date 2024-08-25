using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using MS.Internal.Xml.Cache;

namespace System.Xml.XPath
{
	// Token: 0x020000B4 RID: 180
	public class XPathDocument
	{
		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060007C4 RID: 1988 RVA: 0x0001986C File Offset: 0x00017A6C
		internal XmlNameTable NameTable
		{
			get
			{
				return this.nameTable;
			}
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x00019880 File Offset: 0x00017A80
		internal int GetXmlNamespaceNode([Out] XPathNode[] pageXmlNmsp)
		{
			XPathNode[] array = this.pageXmlNmsp;
			pageXmlNmsp._info = array;
			return this.idxXmlNmsp;
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x000198A4 File Offset: 0x00017AA4
		internal int LookupNamespaces(XPathNode[] pageElem, int idxElem, [Out] XPathNode[] pageNmsp)
		{
			if (this.mapNmsp != null)
			{
				Dictionary<XPathNodeRef, XPathNodeRef> dictionary = this.mapNmsp;
				pageNmsp._info = dictionary;
				return;
			}
		}

		// Token: 0x040003F0 RID: 1008
		private XPathNode[] pageXmlNmsp;

		// Token: 0x040003F1 RID: 1009
		private int idxXmlNmsp;

		// Token: 0x040003F2 RID: 1010
		private XmlNameTable nameTable;

		// Token: 0x040003F3 RID: 1011
		private Dictionary<XPathNodeRef, XPathNodeRef> mapNmsp;
	}
}
