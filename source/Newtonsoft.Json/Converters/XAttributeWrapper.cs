using System;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x0200011B RID: 283
	internal class XAttributeWrapper : XObjectWrapper
	{
		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000B01 RID: 2817 RVA: 0x0001A408 File Offset: 0x00018608
		private XAttribute Attribute
		{
			get
			{
				if (this._xmlObject != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x0001A424 File Offset: 0x00018624
		public XAttributeWrapper(XAttribute attribute)
		{
			if (!true)
			{
			}
			base..ctor();
			this._xmlObject = attribute;
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000B03 RID: 2819 RVA: 0x0001A444 File Offset: 0x00018644
		// (set) Token: 0x06000B04 RID: 2820 RVA: 0x0001A45C File Offset: 0x0001865C
		public override string Value
		{
			get
			{
				return this.Attribute.value;
			}
			set
			{
				this.Attribute.Value = value;
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000B05 RID: 2821 RVA: 0x0001A478 File Offset: 0x00018678
		public override string LocalName
		{
			get
			{
				return this.Attribute.name._localName;
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000B06 RID: 2822 RVA: 0x0001A498 File Offset: 0x00018698
		public override string NamespaceUri
		{
			get
			{
				return this.Attribute.name.NamespaceName;
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000B07 RID: 2823 RVA: 0x0001A4B8 File Offset: 0x000186B8
		public override IXmlNode ParentNode
		{
			get
			{
				IXmlNode xmlNode;
				if (this.Attribute.Parent != null)
				{
					xmlNode = XContainerWrapper.WrapNode(this.Attribute.Parent);
					return xmlNode;
				}
				return xmlNode;
			}
		}
	}
}
