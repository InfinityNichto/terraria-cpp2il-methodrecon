using System;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000116 RID: 278
	internal class XTextWrapper : XObjectWrapper
	{
		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x0001A0F4 File Offset: 0x000182F4
		private XText Text
		{
			get
			{
				if (this._xmlObject != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x0001A110 File Offset: 0x00018310
		public XTextWrapper(XText text)
		{
			if (!true)
			{
			}
			base..ctor();
			this._xmlObject = text;
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x0001A130 File Offset: 0x00018330
		// (set) Token: 0x06000AE3 RID: 2787 RVA: 0x0001A148 File Offset: 0x00018348
		public override string Value
		{
			get
			{
				return this.Text.text;
			}
			set
			{
				this.Text.Value = value;
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000AE4 RID: 2788 RVA: 0x0001A164 File Offset: 0x00018364
		public override IXmlNode ParentNode
		{
			get
			{
				IXmlNode xmlNode;
				if (this.Text.Parent != null)
				{
					XText xtext;
					xmlNode = XContainerWrapper.WrapNode(xtext.Parent);
					return xmlNode;
				}
				return xmlNode;
			}
		}
	}
}
