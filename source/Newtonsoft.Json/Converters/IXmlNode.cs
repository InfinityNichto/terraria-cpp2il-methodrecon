using System;
using System.Collections.Generic;
using System.Xml;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000112 RID: 274
	internal interface IXmlNode
	{
		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000AB6 RID: 2742
		XmlNodeType NodeType { get; }

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000AB7 RID: 2743
		string LocalName { get; }

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000AB8 RID: 2744
		List<IXmlNode> ChildNodes { get; }

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000AB9 RID: 2745
		List<IXmlNode> Attributes { get; }

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000ABA RID: 2746
		IXmlNode ParentNode { get; }

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000ABB RID: 2747
		// (set) Token: 0x06000ABC RID: 2748
		string Value { get; set; }

		// Token: 0x06000ABD RID: 2749
		IXmlNode AppendChild(IXmlNode newChild);

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000ABE RID: 2750
		string NamespaceUri { get; }

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000ABF RID: 2751
		object WrappedNode { get; }
	}
}
