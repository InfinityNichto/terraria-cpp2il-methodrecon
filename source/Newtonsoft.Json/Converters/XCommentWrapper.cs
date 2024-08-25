using System;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000117 RID: 279
	internal class XCommentWrapper : XObjectWrapper
	{
		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000AE5 RID: 2789 RVA: 0x0001A190 File Offset: 0x00018390
		private XComment Text
		{
			get
			{
				if (this._xmlObject != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x0001A1AC File Offset: 0x000183AC
		public XCommentWrapper(XComment text)
		{
			if (!true)
			{
			}
			base..ctor();
			this._xmlObject = text;
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000AE7 RID: 2791 RVA: 0x0001A1CC File Offset: 0x000183CC
		// (set) Token: 0x06000AE8 RID: 2792 RVA: 0x0001A1E4 File Offset: 0x000183E4
		public override string Value
		{
			get
			{
				return this.Text.value;
			}
			set
			{
				this.Text.Value = value;
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000AE9 RID: 2793 RVA: 0x0001A200 File Offset: 0x00018400
		public override IXmlNode ParentNode
		{
			get
			{
				IXmlNode xmlNode;
				if (this.Text.Parent != null)
				{
					xmlNode = XContainerWrapper.WrapNode(this.Text.Parent);
					return xmlNode;
				}
				return xmlNode;
			}
		}
	}
}
