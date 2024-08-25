using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Cpp2IlInjected;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x0200011C RID: 284
	internal class XElementWrapper : XContainerWrapper, IXmlElement, IXmlNode
	{
		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000B08 RID: 2824 RVA: 0x0001A4E8 File Offset: 0x000186E8
		private XElement Element
		{
			get
			{
				if (this._xmlObject != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x0001A504 File Offset: 0x00018704
		public XElementWrapper(XElement element)
			: base(element)
		{
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x0001A518 File Offset: 0x00018718
		public void SetAttributeNode(IXmlNode attribute)
		{
			if (attribute != null)
			{
			}
			XElement element = this.Element;
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000B0B RID: 2827 RVA: 0x0000212A File Offset: 0x0000032A
		public override List<IXmlNode> Attributes
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x0001A538 File Offset: 0x00018738
		public override IXmlNode AppendChild(IXmlNode newChild)
		{
			return base.AppendChild(newChild);
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000B0D RID: 2829 RVA: 0x0001A54C File Offset: 0x0001874C
		// (set) Token: 0x06000B0E RID: 2830 RVA: 0x0001A564 File Offset: 0x00018764
		public override string Value
		{
			get
			{
				return this.Element.Value;
			}
			set
			{
				this.Element.Value = value;
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000B0F RID: 2831 RVA: 0x0001A580 File Offset: 0x00018780
		public override string LocalName
		{
			get
			{
				return this.Element.name._localName;
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000B10 RID: 2832 RVA: 0x0001A5A0 File Offset: 0x000187A0
		public override string NamespaceUri
		{
			get
			{
				return this.Element.name.NamespaceName;
			}
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x0001A5C0 File Offset: 0x000187C0
		public string GetPrefixOfNamespace(string namespaceUri)
		{
			XElement element = this.Element;
			XNamespace xnamespace = namespaceUri;
			return element.GetPrefixOfNamespace(xnamespace);
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000B12 RID: 2834 RVA: 0x0001A5E4 File Offset: 0x000187E4
		public bool IsEmpty
		{
			get
			{
				return this.Element.IsEmpty;
			}
		}

		// Token: 0x04000419 RID: 1049
		private List<IXmlNode> _attributes;
	}
}
